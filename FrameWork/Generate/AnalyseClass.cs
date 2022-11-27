using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Reflection;
using System.IO;
using System.Text.RegularExpressions;

namespace SMFrame.Editor.Refleaction
{
	public delegate bool Translate(Type t, TypeTranslater translater, out string result);
	public delegate string Format(params string[] args);

    public class TypeFormater
    {
		const string defaultFormat = "{0}";

		public string format = defaultFormat;
		public Format fun;

		public string Format(params string[] elementStr)
        {
			if(fun != null)
			{
				return fun(elementStr);
			}
            return string.Format(format, elementStr);
        }
	}

	public class TypeTranslater
    {
		public bool needNameSpace;
		public Translate translate;
		public TypeFormater Array = new TypeFormater();
		public TypeFormater ByRef = new TypeFormater();
		public TypeFormater Pointer = new TypeFormater();
        public TypeFormater GenericTypeDefinition = new TypeFormater();
		public TypeFormater GenericType = new TypeFormater();
        public TypeFormater GenericParameter = new TypeFormater();
	}

    public static class TypeToString
    {
        

        public static string ToFieldName(this Type type)
        {
			TypeTranslater typeTranslater = new TypeTranslater();
			typeTranslater.needNameSpace = false;
			typeTranslater.Array.format = "{0}Array";
			typeTranslater.Pointer.format = "{0}Pointer";
			typeTranslater.GenericTypeDefinition.format = "_d_{0}_p_";
			typeTranslater.GenericType.format = "_d_{0}_p_";

            return type.ToString(typeTranslater);
        }

        public static string ToDeclareName(this Type type, bool needNameSpace = true)
        {
			TypeTranslater typeTranslater = new TypeTranslater();
			typeTranslater.needNameSpace = needNameSpace;
			typeTranslater.Array.format = "{0}[]";
			typeTranslater.Pointer.format = "{0}*";
			typeTranslater.GenericTypeDefinition.fun = (strs) => {
				var genericDefine = strs[0];
				string genericParamStr = string.Empty;
				for (int i = 1; i < strs.Length; i++)
				{
					genericParamStr += strs[i];
					if (i != strs.Length - 1)
					{
						genericParamStr += ", ";
					}
				}
				var defineName = Regex.Replace(genericDefine, @"`\d+", $"<{genericParamStr}>");
				return defineName;
			};
			typeTranslater.GenericType.fun = (strs) => {
				var genericDefine = strs[0];
				string genericParamStr = string.Empty;
				for (int i = 1; i < strs.Length; i++)
				{
					var paramName = strs[i];
					genericParamStr += paramName;
					if (i != strs.Length - 1)
					{
						genericParamStr += ", ";
					}
				}
				var defineName = Regex.Replace(genericDefine, @"`<,*>", $"<{genericParamStr}>");
				return defineName;
			};

			typeTranslater.translate = VoidToDeclareName;


            return type.ToString(typeTranslater);
        }

		static bool VoidToDeclareName(Type t, TypeTranslater translater, out string result)
		{
			result = string.Empty;
			if(t == typeof(void))
			{
				result = "void";
				return true;
			}
			return false;	
		}


        public static string ToGetMethod(this Type type)
        {
			TypeTranslater typeTranslater = new TypeTranslater();
			typeTranslater.needNameSpace = false;
			typeTranslater.Array.format = "{0}.MakeArrayType()";
			typeTranslater.Pointer.format = "{0}.MakePointerType()";
			typeTranslater.ByRef.format = "{0}.MakeByRefType()";
			typeTranslater.GenericTypeDefinition.format = "<{0}>";
			typeTranslater.GenericType.format = "<{0}>";


			if (type.IsArray)
            {
				var elementType = type.GetElementType();
				return elementType.ToGetMethod() + ".MakeArrayType()";
			}
			else if (type.IsPointer)
			{
				var elementType = type.GetElementType();
				return elementType.ToGetMethod() + ".MakePointerType()";
			}
			else if (type.IsGenericParameter)
            {
                return $"Type.MakeGenericMethodParameter({type.GenericParameterPosition})";
            }
            else if(type.IsByRef)
            {
				var t = type.GetElementType();
                return $"{t.ToGetMethod()}.MakeByRefType()";
			}
			else if (type.IsGenericType && !type.IsGenericTypeDefinition)
            {
				var genericTypes = type.GetGenericArguments();
				var genericDefine = type.GetGenericTypeDefinition();

                var genericDefineStr = genericDefine.ToGetMethod();

				string genericParamStr = string.Empty;
				for (int i = 0; i < genericTypes.Length; i++)
				{
					var genericType = genericTypes[i];
					var paramName = genericType.ToGetMethod();
					genericParamStr += paramName;
					if (i != genericTypes.Length - 1)
					{
						genericParamStr += ", ";
					}
				}
                return $"{genericDefineStr}.MakeGenericType({genericParamStr})";
			}

			else if (type.IsPublic)
            {
                return $"typeof({type.ToDeclareName(true)})";
            }
            else
            {
                return $" ReleactionUtils.GetType(\"{type.ToDeclareName(true)}\")";
            }
        }

        public static Type ToBasicType(this Type type)
        {
			if (type.IsArray)
			{
				var elementType = type.GetElementType();
				return elementType.ToBasicType();
			}
			else if (type.IsGenericParameter)
            {
                return null;
            }
            else if(type.IsByRef)
            {
				var elementType = type.GetElementType();
				return elementType.ToBasicType();
			}
            else if(type.IsPointer)
            {
				var elementType = type.GetElementType();
				return elementType.ToBasicType();
			}
			else if (type.IsGenericType && !type.IsGenericTypeDefinition)
            {
                return type.GetGenericTypeDefinition().ToBasicType();
			}
            else
            {
                return type;
            }
		}

		public static string ToString(this Type type, TypeTranslater translater)
		{
			bool needNameSpace = translater.needNameSpace;

			if(type == null)
			{
				return String.Empty;
			}
			else if (translater.translate != null && translater.translate(type, translater, out string result))
			{
				return result;
			}
			else if (type.IsArray)
			{
				var elementType = type.GetElementType();
				return translater.Array.Format(elementType.ToString(translater));
			}
			else if (type.IsPointer)
			{
				var elementType = type.GetElementType();
				return translater.Pointer.Format(elementType.ToString(translater));
			}
			else if (type.IsByRef)
			{
				var elementType = type.GetElementType();
				return translater.ByRef.Format(elementType.ToString(translater));
			}
			// 这个要在IsGenericType前，因为IsGenericTypeDefinition也是IsGenericType
			else if (type.IsGenericTypeDefinition)
			{
				var genericTypes = type.GetGenericArguments();
				var genericDefine = type.GetGenericTypeDefinition();
				string[] genericParamStr = new string[genericTypes.Length + 1];
				genericParamStr[0] = genericDefine.Name;
				for (int i = 0; i < genericTypes.Length; i++)
				{
					genericParamStr[i + 1] = genericTypes[i].ToString(translater);
				}

				var defineName = translater.GenericTypeDefinition.Format(genericParamStr);
				if (needNameSpace)
				{
					return genericDefine.Namespace + "." + defineName;
				}
				else
				{
					return defineName;
				}
			}
			else if (type.IsGenericType)
			{
				// https://docs.microsoft.com/zh-cn/dotnet/framework/reflection-and-codedom/how-to-examine-and-instantiate-generic-types-with-reflection
				var genericTypes = type.GetGenericArguments();
				var genericDefine = type.GetGenericTypeDefinition();
				string[] genericParamStr = new string[genericTypes.Length + 1];
				genericParamStr[0] = genericDefine.ToString(translater);
				for (int i = 0; i < genericTypes.Length; i++)
				{
					var genericType = genericTypes[i];
					var paramName = genericType.ToString(translater);
					genericParamStr[i + 1] = paramName;
				}

				var defineName = translater.GenericType.Format(genericParamStr);
				return defineName;
			}
			else if (type.IsGenericParameter)
			{
				return type.Name;
			}
			else
			{
				if (needNameSpace)
				{
					return type.Namespace + "." + type.Name;
				}
				else
				{
					return type.Name;
				}
			}
		}

		public static bool IsStatic(this PropertyInfo propertyInfo)
		{
			return ((propertyInfo.CanRead && propertyInfo.GetMethod.IsStatic) ||
				(propertyInfo.CanWrite && propertyInfo.SetMethod.IsStatic));
		}

		public static bool IsStatic(this EventInfo eventInfo)
		{
			return ((eventInfo.AddMethod != null && eventInfo.AddMethod.IsStatic) ||
				(eventInfo.RemoveMethod != null && eventInfo.RemoveMethod.IsStatic));
		}
	}
}
