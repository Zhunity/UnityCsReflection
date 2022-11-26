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
	public delegate string Translate(Type t);

    public class TypeFormater
    {
        public string format;
        public Translate translate;


        public string Format(string elementStr)
        {
            return string.Format(format, elementStr);
        }
	}

	public class TypeTranslater
    {
		public bool needNameSpace;
		public TypeFormater Array;
		public TypeFormater Pointer;
        public TypeFormater GenericTypeDefinition;
		public TypeFormater GenericType;
        public TypeFormater GenericParameter;
		public TypeFormater ByRef;
        public Dictionary<Type, TypeFormater> type = new Dictionary<Type, TypeFormater>();
	}

    public static class TypeToString
    {
        public static string ToString(this Type type, TypeTranslater translater)
        {
			bool needNameSpace = translater.needNameSpace;

			if (translater.type.TryGetValue(type, out var format))
            {
				return format.translate(type);
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
				string genericParamStr = string.Empty;
				for (int i = 0; i < genericTypes.Length; i++)
				{
					if (i != genericTypes.Length - 1)
					{
						genericParamStr += ", ";
					}
				}

				var defineName = Regex.Replace(genericDefine.Name, @"`\d+", translater.GenericTypeDefinition.Format(genericParamStr));
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
				string genericParamStr = string.Empty;
				for (int i = 0; i < genericTypes.Length; i++)
				{
					var genericType = genericTypes[i];
					var paramName = genericType.ToString(translater);
					genericParamStr += paramName;
					if (i != genericTypes.Length - 1)
					{
						genericParamStr += ", ";
					}
				}
				//  typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1))
				var defineName = Regex.Replace(genericDefine.Name, @"`\d+", translater.GenericType.Format(genericParamStr));
				if (needNameSpace)
				{
					return genericDefine.Namespace + "." + defineName;
				}
				else
				{
					return defineName;
				}
			}
			else if(type.IsGenericParameter)
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

        public static string ToFieldName(this Type type)
        {
            string name = String.Empty;
            if (type.IsArray)
            {
                var elementType = type.GetElementType();
				name += elementType.ToFieldName() + "Array";
            }
			else if(type.IsPointer)
			{
				var elementType = type.GetElementType();
				name += elementType.ToFieldName() + "Pointer";
			}
			else if (type.IsGenericType)
            {
                // https://docs.microsoft.com/zh-cn/dotnet/framework/reflection-and-codedom/how-to-examine-and-instantiate-generic-types-with-reflection
                var genericTypes = type.GetGenericArguments();
                var genericDefine = type.GetGenericTypeDefinition();
                string genericParamStr = string.Empty;
                foreach (var genericType in genericTypes)
                {
                    var paramName = genericType.ToFieldName();
                    genericParamStr += paramName;
                }
                var a = Regex.Replace(genericDefine.Name, @"`\d+", $"_d_{genericParamStr}_p_");
                name += a;
            }
            else if (type.IsByRef)
            {
                var t = type.GetElementType();
                name = t.ToFieldName();
            }
            else
            {
                name = type.Name;
            }


            return name;
        }

        public static string ToDeclareName(this Type type, bool needNameSpace = true)
        {
            string name = String.Empty;
            if (type.IsArray)
            {
                var elementType = type.GetElementType();
				name = elementType.ToDeclareName(needNameSpace) + "[]";
			}
			else if (type.IsPointer)
			{
				var elementType = type.GetElementType();
				name += elementType.ToDeclareName(needNameSpace) + "*";
			}
			else if (type.IsGenericType)
            {
                // https://docs.microsoft.com/zh-cn/dotnet/framework/reflection-and-codedom/how-to-examine-and-instantiate-generic-types-with-reflection
                var genericTypes = type.GetGenericArguments();
                var genericDefine = type.GetGenericTypeDefinition();
                string genericParamStr = string.Empty;
                for (int i = 0; i < genericTypes.Length; i++)
                {
                    if(!type.IsGenericTypeDefinition)
                    {
						var genericType = genericTypes[i];
						var paramName = genericType.ToDeclareName(needNameSpace);
						genericParamStr += paramName;
					}
                    if (i != genericTypes.Length - 1)
                    {
                        genericParamStr += ", ";
                    }
                }
				//  typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1))
				var defineName = Regex.Replace(genericDefine.Name, @"`\d+", $"<{genericParamStr}>");
                if (needNameSpace)
                {
                    name += genericDefine.Namespace + "." + defineName;
                }
                else
                {
                    name += defineName;
                }
            }
            else if (type.IsByRef)
            {
                var t = type.GetElementType();
                name = t.ToDeclareName(needNameSpace);
            }
            else
            {
                if(type == typeof(void))
                {
                    return "void";
                }
                if (needNameSpace && !type.IsGenericParameter)
                {
                    name = type.Namespace + "." + type.Name;
                }
                else
                {
                    name = type.Name;
                }
            }


            return name;
        }


        public static string ToGetMethod(this Type type)
        {
            if(type.IsArray)
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
