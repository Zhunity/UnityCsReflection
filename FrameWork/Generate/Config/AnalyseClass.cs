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

		public bool can = true;
		public string format = defaultFormat;
		public Format fun;

		public string Format(params string[] elementStr)
        {
			if(!can)
			{
				return String.Empty;
			}
			if(fun != null)
			{
				return fun(elementStr);
			}
            return string.Format(format, elementStr);
        }

		public TypeFormater Clone()
		{
			var result = new TypeFormater();
			result.can = this.can;
			result.format = this.format;
			result.fun = this.fun;
			return result;
		}
	}

	public class TypeTranslater
    {
		public bool fullName;
		public Translate translate;
		public TypeFormater Array = new TypeFormater();
		public TypeFormater ByRef = new TypeFormater();
		public TypeFormater Pointer = new TypeFormater();
        public TypeFormater GenericTypeDefinition = new TypeFormater();
		public TypeFormater GenericType = new TypeFormater();
        public TypeFormater GenericParameter = new TypeFormater();
        public Translate defaultTran;

        public TypeTranslater Clone()
		{
			var result = new TypeTranslater();
			result.fullName = this.fullName;
			result.defaultTran = this.defaultTran;
			result.Array = this.Array.Clone();
			result.ByRef = this.ByRef.Clone();
			result.Pointer = this.Pointer.Clone();
			result.GenericTypeDefinition = this.GenericTypeDefinition.Clone();
			result.GenericType = this.GenericType.Clone();
			result.GenericParameter = this.GenericParameter.Clone();
			return result;
		}
	}

    public static class TypeToString
    {
        

        public static string ToFieldName(this Type type)
        {
			TypeTranslater typeTranslater = new TypeTranslater();
			typeTranslater.fullName = false;
			typeTranslater.Array.format = "{0}Array";
			typeTranslater.Pointer.format = "{0}Pointer";
			typeTranslater.GenericTypeDefinition.fun = (strs) =>
			{
				string genericDefine = strs[0];
				string genericParamStr = string.Empty;
				for(int i = 1; i < strs.Length; i++)
				{
					var paramName = strs[i];
					genericParamStr += paramName;
					if (i != strs.Length - 1)
					{
						genericParamStr += "_";
					}
				}
				var a = Regex.Replace(genericDefine, @"`\d+", $"_d_{genericParamStr}_p_");
				return a;
			};
			typeTranslater.GenericType.fun = (strs) => {
				string genericDefine = strs[1];
				string genericParamStr = string.Empty;
				for (int i = 2; i < strs.Length; i++)
				{
					var paramName = strs[i];
					genericParamStr += paramName;
					if (i != strs.Length - 1)
					{
						genericParamStr += "_";
					}
				}
				var a = Regex.Replace(genericDefine, @"`\d+", $"_d_{genericParamStr}_p_");
				return a;
			};

            return type.ToString(typeTranslater);
        }

		public static string ToClassName(this Type type, bool fullName = false)
		{
			TypeTranslater typeTranslater = new TypeTranslater();
			typeTranslater.fullName = fullName;
			typeTranslater.Array.format = "{0}[]";
			typeTranslater.Pointer.format = "{0}*";
			typeTranslater.GenericTypeDefinition.fun = (strs) => {
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
				var defineName = Regex.Replace(genericDefine, @"`\d+", $"<{genericParamStr}>");
				return defineName;
			};
			typeTranslater.GenericType.fun = (strs) => {
				var genericDefine = strs[1];
				string genericParamStr = string.Empty;
				for (int i = 2; i < strs.Length; i++)
				{
					var paramName = strs[i];
					genericParamStr += paramName;
					if (i != strs.Length - 1)
					{
						genericParamStr += ", ";
					}
				}
				var defineName = Regex.Replace(genericDefine, @"`\d+", $"<{genericParamStr}>");
				return defineName;
			};

			typeTranslater.defaultTran = VoidToDeclareName;


			return type.ToString(typeTranslater);
		}

		public static string ToConstructorName(this Type type)
		{
			TypeTranslater typeTranslater = new TypeTranslater();
			typeTranslater.fullName = false;
			typeTranslater.Array.format = "{0}[]";
			typeTranslater.Pointer.format = "{0}*";
			typeTranslater.GenericTypeDefinition.fun = (strs) => {
				var genericDefine = strs[0];
				var defineName = Regex.Replace(genericDefine, @"`\d+", $"");
				return defineName;
			};
			typeTranslater.GenericType.fun = (strs) => {
				var genericDefine = strs[1];
				string genericParamStr = string.Empty;
				for (int i = 2; i < strs.Length; i++)
				{
					var paramName = strs[i];
					genericParamStr += paramName;
					if (i != strs.Length - 1)
					{
						genericParamStr += ", ";
					}
				}
				var defineName = Regex.Replace(genericDefine, @"`\d+", $"<{genericParamStr}>");
				return defineName;
			};

			typeTranslater.defaultTran = VoidToDeclareName;


			return type.ToString(typeTranslater);
		}


		public static string ToDeclareName(this Type type, bool fullName = true)
        {
			TypeTranslater typeTranslater = new TypeTranslater();
			typeTranslater.fullName = fullName;
			typeTranslater.Array.format = "{0}[]";
			typeTranslater.Pointer.format = "{0}*";
			typeTranslater.GenericTypeDefinition.fun = (strs) => {
				var genericDefine = strs[0];
				string genericParamStr = string.Empty;
				for (int i = 1; i < strs.Length; i++)
				{
					if (i != strs.Length - 1)
					{
						genericParamStr += ", ";
					}
				}
				var defineName = Regex.Replace(genericDefine, @"`\d+", $"<{genericParamStr}>");
				return defineName;
			};
			typeTranslater.GenericType.fun = (strs) => {
				var genericDefine = strs[1];
				string genericParamStr = string.Empty;
				for (int i = 2; i < strs.Length; i++)
				{
					var paramName = strs[i];
					genericParamStr += paramName;
					if (i != strs.Length - 1)
					{
						genericParamStr += ", ";
					}
				}
				var defineName = Regex.Replace(genericDefine, @"`\d+", $"<{genericParamStr}>");
				return defineName;
			};

			typeTranslater.defaultTran = VoidToDeclareName;


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


		static bool PublicToGetMethod(Type t, TypeTranslater translater, out string result)
		{
			if (t.IsPublic)
			{
				result = $"typeof({t.ToDeclareName(true)})";
			}
			else
			{
				result = $" ReleactionUtils.GetType(\"{t.FullName}\")";
			}
			return true;
		}

		public static string ToGetMethod(this Type type)
        {
			TypeTranslater typeTranslater = new TypeTranslater();
			typeTranslater.fullName = false;
			typeTranslater.Array.format = "{0}.MakeArrayType()";
			typeTranslater.Pointer.format = "{0}.MakePointerType()";
			typeTranslater.ByRef.format = "{0}.MakeByRefType()";
			typeTranslater.GenericTypeDefinition.can = false;
			typeTranslater.GenericType.fun = (strs) =>
			{
				string genericDefineStr = strs[0];
				string genericParamStr = string.Empty;
				for (int i = 2; i < strs.Length; i++)
				{
					var paramName = strs[i];
					genericParamStr += paramName;
					if (i != strs.Length - 1)
					{
						genericParamStr += ", ";
					}
				}
				return $"{genericDefineStr}.MakeGenericType({genericParamStr})";
			};
			typeTranslater.GenericParameter.format = "Type.MakeGenericMethodParameter({1})";
			typeTranslater.defaultTran = PublicToGetMethod;


			return type.ToString(typeTranslater);
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

		public static void GetRefType(this Type type, ref HashSet<Type> child)
		{
			if (type.IsArray)
			{
				var elementType = type.GetElementType();
				elementType.GetRefType(ref child);
			}
			else if (type.IsGenericParameter)
			{
				return;
			}
			else if (type.IsByRef)
			{
				var elementType = type.GetElementType();
				elementType.GetRefType(ref child);
			}
			else if (type.IsPointer)
			{
				var elementType = type.GetElementType();
				elementType.GetRefType(ref child);
			}
			else if (type.IsGenericType && !type.IsGenericTypeDefinition)
			{
				var definition = type.GetGenericTypeDefinition();
				definition.GetRefType(ref child);

				var paras = type.GetGenericArguments();
				foreach(var para in paras)
				{
					para.GetRefType(ref child);
				}
			}
			child.Add(type);
		}

		public static string ToString(this Type type, TypeTranslater translater)
		{
			bool needFullName = translater.fullName;


            if (translater.translate != null && translater.translate(type, translater, out string result))
            {
                return result;
            }
            else if(type == null)
			{
				return String.Empty;
			}
			else if (type.IsArray && translater.Array.can)
			{
				var elementType = type.GetElementType();
				return translater.Array.Format(elementType.ToString(translater));
			}
			else if (type.IsPointer && translater.Pointer.can)
			{
				var elementType = type.GetElementType();
				return translater.Pointer.Format(elementType.ToString(translater));
			}
			else if (type.IsByRef && translater.ByRef.can)
			{
				var elementType = type.GetElementType();
				return translater.ByRef.Format(elementType.ToString(translater));
			}
			// 这个要在IsGenericType前，因为IsGenericTypeDefinition也是IsGenericType
			else if (type.IsGenericTypeDefinition && translater.GenericTypeDefinition.can)
			{
				var genericTypes = type.GetGenericArgumentsWithoutDeclareType();
				var genericDefine = type.GetGenericTypeDefinition();
				string[] genericParamStr = new string[genericTypes.Length + 1];
				genericParamStr[0] = genericDefine.Name;
				for (int i = 0; i < genericTypes.Length; i++)
				{
					genericParamStr[i + 1] = genericTypes[i].ToString(translater);
				}

				var defineName = translater.GenericTypeDefinition.Format(genericParamStr);
				if (needFullName)
				{
					return GetNestedFullName(genericDefine, translater, defineName); 
				}
				else
				{
					return defineName;
				}
			}
			else if (type.IsGenericType && !type.IsGenericTypeDefinition && translater.GenericType.can)
			{
				// https://docs.microsoft.com/zh-cn/dotnet/framework/reflection-and-codedom/how-to-examine-and-instantiate-generic-types-with-reflection
				var genericTypes = type.GetGenericArguments();
				var genericDefine = type.GetGenericTypeDefinition();
				string[] genericParamStr = new string[genericTypes.Length + 2];
				genericParamStr[0] = genericDefine.ToString(translater);
				genericParamStr[1] = genericDefine.Name;
				for (int i = 0; i < genericTypes.Length; i++)
				{
					var genericType = genericTypes[i];
					var paramName = genericType.ToString(translater);
					genericParamStr[i + 2] = paramName;
				}

				var defineName = translater.GenericType.Format(genericParamStr);
				return defineName;
			}
			else if (type.IsGenericParameter && translater.GenericParameter.can)
			{
				return translater.GenericParameter.Format(type.Name, type.GenericParameterPosition.ToString());
			}
			else if (translater.defaultTran != null && translater.defaultTran(type, translater, out result))
			{
				return result;
			}
			else
			{
				if (needFullName)
				{
					return GetNestedFullName(type, translater, LegalNameConfig.LegalName(type.Name));
				}
				else
				{
					return LegalNameConfig.LegalName(type.Name);
				}
			}
		}

		static string GetNestedFullName(Type type, TypeTranslater translater, string name)
		{
			if (type.IsNested)
			{
				string result = LegalNameConfig.LegalName(name);
				var declareStr = type.DeclaringType.ToString(translater);
				result = declareStr + "." + result;
				return result;
			}
			else if(string.IsNullOrEmpty(type.Namespace))
			{
				return LegalNameConfig.LegalName(name);
			}
			else
			{
				var nameSpaceSplit = type.Namespace.Split(".");
				string result = string.Empty;
				foreach(var item in nameSpaceSplit)
				{
					result += LegalNameConfig.LegalName(item) + ".";
				}
				result += LegalNameConfig.LegalName(name);
				return result;
			}
		}

		public static bool IsPublic(this Type type)
		{
			HashSet<Type> refTypes = new HashSet<Type>();
			type.GetRefType(ref refTypes);
			foreach(var refType in refTypes)
			{
				if(!refType.IsPublic)
				{
					return false;
				}
			}
			return true;
		}

		public static bool IsUnsafe(this Type type)
		{
			HashSet<Type> refTypes = new HashSet<Type>();
			type.GetRefType(ref refTypes);
			foreach (var refType in refTypes)
			{
				if (refType.IsPointer)
				{
					return true;
				}
			}
			return false;
		}

		public static bool ContainType(this Type type, Type targetType)
		{
			HashSet<Type> refTypes = new HashSet<Type>();
			type.GetRefType(ref refTypes);
			foreach(var refType in refTypes)
			{
				if(refType == targetType)
				{
					return true;
				}
			}
			return false;
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

		public static Type[] GetGenericArgumentsWithoutDeclareType(this Type type)
		{
			var totalGenericArguments = type.GetGenericArguments();
			if(totalGenericArguments == null)
			{
				return new Type[] { };
			}
			if (!type.IsNested)
			{
				return totalGenericArguments;
			}

			int declareGenericCount = 0;
			var declareType = type.DeclaringType;
			while (declareType != null)
			{
				if (declareType.IsGenericType)
				{
					var genericArgs2 = declareType.GetGenericArguments();
					declareGenericCount += genericArgs2.Length;
				}
				declareType = declareType.DeclaringType;
			}

			Type[] genericArgs = new Type[totalGenericArguments.Length - declareGenericCount];
			for(int i = declareGenericCount; i < totalGenericArguments.Length; i++)
			{
				genericArgs[i - declareGenericCount] = totalGenericArguments[i];
			}
			return genericArgs;
		}
	}
}
