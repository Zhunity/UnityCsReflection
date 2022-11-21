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
    public static class TypeToString
    {
        public static string ToFieldName(this Type type)
        {
            string name = String.Empty;
            if (type.IsArray)
            {
                var elementType = type.GetElementType();
				name += elementType.ToFieldName() + "Array";
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
				name = elementType.ToDeclareName(true) + "[]";
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
						var paramName = genericType.ToDeclareName(true);
						genericParamStr += paramName;
					}
                    if (i != genericTypes.Length - 1)
                    {
                        genericParamStr += ", ";
                    }
                }
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
                name = t.ToDeclareName(true);
            }
            else
            {
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
    }
}
