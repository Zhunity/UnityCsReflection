using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Reflection;
using static Codice.Client.Common.WebApi.WebApiEndpoints;

namespace SMFrame.Editor.Refleaction
{
    class A
    {
        public int N<T1,T2>(int a, string b, float c)
        {
            return 0;
        }

        public  float N<T>()
        {
            return 1;
        }

        public string N()
        {
            return "";
        }
    }

    public class GenerateRClass
    {
        [MenuItem("Tools/fff")]
        static void G()
        {
            Generate<A>();
        }

        public static void Generate(Type classType)
        {
            GenerateInternal(classType);
        }

        public static void Generate<T>()
        {
            Generate(typeof(T));
        }

        public static void Generate(string className)
        {
            Generate(ReleactionUtils.GetType(className));
        }

        public static void Generate(object instance)
        {
            Generate(instance.GetType());
        }


        #region 生成文件代码
        static HashSet<Type> _cacheType = new HashSet<Type>();

        public static void GenerateInternal(Type classType)
        {
            
            var nameSpaceStr = string.Empty;
            var delcareStr = string.Empty;
            var newStr = string.Empty;
            HashSet<string> nameSpaceCache = new HashSet<string>();
            HashSet<MethodInfo> getSetHash = new HashSet<MethodInfo>();

            var properties = classType.GetProperties(Class.flags);
            foreach (var property in properties)
            {
                getSetHash.Add(property.SetMethod);
                getSetHash.Add(property.GetMethod);
                //nameSpaceStr += GenerateMemberNameSpace(property.PropertyType, nameSpaceCache);
                //delcareStr += GenerateMemberDeclare(property.PropertyType, property.Name, "Property");
                //newStr += GenerateMemberNew(property.PropertyType, property.Name, "Property");
            }

            var fields = classType.GetFields(Class.flags);
            foreach (var field in fields)
            {
                //nameSpaceStr += GenerateMemberNameSpace(field.FieldType, nameSpaceCache);
                //delcareStr += GenerateMemberDeclare(field.FieldType, field.Name, "Field");
                //newStr += GenerateMemberNew(field.FieldType, field.Name, "Field");
            }

            var events = classType.GetEvents(Class.flags);
            foreach (var @event in events)
            {
                getSetHash.Add(@event.AddMethod);
                getSetHash.Add(@event.RemoveMethod);
                //delcareStr += GenerateMemberDeclare(null, @event.Name, "Event");
                //newStr += GenerateMemberNew(null, @event.Name, "Event");
            }

            var methods = classType.GetMethods(Class.flags);
            foreach (var method in methods)
            {
                if(getSetHash.Contains(method))
                {
                    continue;
                }
                delcareStr += GenerateMethodDeclare(method);
                newStr += GenerateMethodNew(method);
            }

            var generateStr = $@"{nameSpaceStr}using SMFrame.Editor.Refleaction;

namespace SMFrame.Editor.Refleaction.{classType.Namespace}
{{
    public class R{classType.Name} : Member
    {{
{delcareStr}

        public R{classType.Name}(Type type) : base(type)
	    {{
{newStr}
	    }}
    }}
}}
";

            Debug.Log(nameSpaceStr);
            Debug.Log(delcareStr);
            Debug.Log(newStr);
            Debug.Log(generateStr);
        }

        private static string GenerateMemberNameSpace(Type type, HashSet<string> nameSpaceCache)
        {
            var nameSpace = type.Namespace;
            if (IsPrimitive(type) || string.IsNullOrEmpty(nameSpace) || nameSpaceCache.Contains(nameSpace))
            {
                return string.Empty;
            }
            nameSpaceCache.Add(nameSpace);
            return $"using SMFrame.Editor.Refleaction.{nameSpace};\n";
        }

        private static string GenerateDeclare(string typeName, string name, string note)
        {
            return $"\t\tpublic {typeName} {name}; //{note}\n";
        }

        private static string GenerateMemberDeclare(Type type, string name, string memberType)
        {
            string propertyType = IsPrimitive(type) ? memberType : "R" + type.Name;
            return GenerateDeclare(propertyType, name, type?.FullName);
        }

        private static string GenerateMemberNew(Type type, string name, string memberType)
        {
            string propertyType = IsPrimitive(type) ? memberType : "R" + type.Name;
            return $"\t\t\t{name} = new {propertyType}(this, \"{name}\");\n";
        }

        private static string GenerateMethodDeclare(MethodInfo method)
        {
            string name = GetMethodName(method);

            var generics = method.GetGenericArguments();
            var parameters = method.GetParameters();

            var noteStr = method.ReturnType.Name + " " + method.Name;
            if(generics.Length > 0)
            {
                noteStr += "<";
                for(int i = 0; i < generics.Length; i++)
                {
                    noteStr += generics[i].Name;
                    if(i < generics.Length - 1)
                    {
                        noteStr += ", ";
                    }
                }
                noteStr += ">";
            }

            noteStr += "(";
            for (int i = 0; i < parameters.Length; i++)
            {
                noteStr += parameters[i].ParameterType.Name + " " + parameters[i].Name;
                if (i < parameters.Length - 1)
                {
                    noteStr += ", ";
                }
            }
            noteStr += ")";
            return GenerateDeclare("Method", name, noteStr);
        }

        private static string GenerateMethodNew(MethodInfo method)
        {
            string name = GetMethodName(method);

            var generics = method.GetGenericArguments();
            var parameters = method.GetParameters();
            var paramStr = string.Empty;
            for (int i = 0; i < parameters.Length; i++)
            {
                paramStr += $", ReleactionUtils.GetType({parameters[i].ParameterType.FullName})";
            }

            return $"\t\t\t{name} = new Method(this, \"{method.Name}\", {generics.Length}{paramStr});\n";
        }

        static private string GetMethodName(MethodInfo method)
        {
            var generics = method.GetGenericArguments();
            string paramStr = method.Name;
            foreach (var generic in generics)
            {
                paramStr += "_G" + generic.Name;
            }

            var parameters = method.GetParameters();
            foreach (var parameter in parameters)
            {
                paramStr += "_" + parameter.ParameterType.Name;
            }
            return paramStr;
        }


        private static void GenerateType(Type type)
        {
            if(IsPrimitive(type) || _cacheType.Contains(type))
            {
                return;
            }
            _cacheType.Add(type);
            Generate(type);
        }

        static HashSet<Type> PrimitiveType = new HashSet<Type>()
        {
            typeof(string),
        };

        private static bool IsPrimitive(Type type)
        {
            return type == null ||
                PrimitiveType.Contains(type) || 
                type.IsEnum || type.IsPrimitive; // int float等值类型
        }
        #endregion
    }
}
