using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Reflection;
using System.IO;

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
            return "12312312";
        }
    }

    public class GenerateRClass
    {
        [MenuItem("Tools/fff")]
        static void G()
        {
            // Generate<A>();

            A b = new A();

            SMFrame.Editor.Refleaction.RA a = new SMFrame.Editor.Refleaction.RA();
            a.SetInstance(b);

            Debug.Log(a.N<int, float>(1, " ", 2f));
            Debug.Log(a.N<float>());

            Debug.Log(a.N());
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

            string methodInvoke = string.Empty;
            var methods = classType.GetMethods(Class.flags);
            foreach (var method in methods)
            {
                if(getSetHash.Contains(method))
                {
                    continue;
                }
                delcareStr += GenerateMethodDeclare(method);
                newStr += GenerateMethodNew(method);
                methodInvoke += GenerateMethodInvoke(method);
            }

            var generateStr = $@"{nameSpaceStr}using SMFrame.Editor.Refleaction;
using System;

namespace SMFrame.Editor.Refleaction.{classType.Namespace}
{{
    public class R{classType.Name} : Member
    {{
{delcareStr}

        public R{classType.Name}() : base(""{classType.FullName}"")
        {{
            NewMembers();
        }}

        public R{classType.Name}(Member belongMember, string name) : base(belongMember, name)
	    {{
            NewMembers();
	    }}

        private void NewMembers()
        {{
{newStr}
        }}
{methodInvoke}
    }}
}}
";

            Debug.Log(nameSpaceStr);
            Debug.Log(delcareStr);
            Debug.Log(newStr);
            Debug.Log(generateStr);
            var path = $"{Application.dataPath}/UnityCsReflection/Generate/{classType.Namespace.Replace(".", "/")}/R{classType.Name}.cs";
            var folder = Path.GetDirectoryName(path);
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            File.WriteAllText(path, generateStr);
            AssetDatabase.Refresh();
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
                paramStr += $", ReleactionUtils.GetType(\"{parameters[i].ParameterType.FullName}\")";
            }

            return $"\t\t\t{name} = new Method(this, \"{method.Name}\", {generics.Length}{paramStr});\n";
        }

        private static string GenerateMethodInvoke(MethodInfo method)
        {
            string name = GetMethodName(method);

            string declareStr = $"public object {method.Name}";
            var parameters = method.GetParameters();

            var paramStr = string.Empty;
            var generics = method.GetGenericArguments();
            if (generics.Length > 0)
            {
                declareStr += "<";
                paramStr = "new Type[] { ";
                for (int i = 0; i < generics.Length; i++)
                {
                    declareStr += generics[i].Name;
                    paramStr += $"typeof({generics[i].Name})";
                    if (i < generics.Length - 1)
                    {
                        declareStr += ", ";
                        paramStr += ", ";
                    }
                }
                declareStr += ">";
                paramStr += " }";

                if(parameters.Length > 0)
                {
                    paramStr += ", ";
                }
            }

            
            declareStr += "(";
            for (int i = 0; i < parameters.Length; i++)
            {
                if(parameters[i].ParameterType.IsNotPublic)
                {
                    return string.Empty;
                }
                declareStr += parameters[i].ParameterType.FullName + " " + parameters[i].Name;
                paramStr += parameters[i].Name;
                if (i < parameters.Length - 1)
                {
                    declareStr += ", ";
                    paramStr += ", ";
                }
            }
            declareStr += ")";

            var result = $@"
        {declareStr}
        {{
            return {name}.Invoke({paramStr});
        }}
";
            return result;
        }

        static private string GetMethodName(MethodInfo method)
        {
            var generics = method.GetGenericArguments();
            string paramStr = "R" + method.Name;
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
