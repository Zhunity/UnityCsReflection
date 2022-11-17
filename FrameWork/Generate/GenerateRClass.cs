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

        //public static float N<T>(int e, out T a, ref float b, in long c, params bool[][][] d)
        //{
        //    a = default;
        //    return 1;
        //}

        public string N(float a = 0)
        {
            return "12312312";
        }

        //public string N(out bool a )
        //{
        //    a = true;
        //    return "12312312";
        //}

        public string N(bool[][][][] a)
        {
            return "12312312";
        }

        public string N(in Dictionary<int[], List<string[][]>>[][] a)
        {
            return "12312312";
        }

        //public string N(ref List<int> a)
        //{
        //    return "12312312";
        //}
    }

    public partial class GenerateRClass
    {
        [MenuItem("Tools/fff")]
        static void G()
        {
            //var a = GenerateParameterType(typeof(Dictionary<int[], List<string[][]>>[][]));
            //Debug.Log(a);
            //Generate<Dictionary<int[], List<string[][]>>[][]>();

            A b = new A();
            //Generate(b);
            SMFrame.Editor.Refleaction.RA a = new();
            a.SetInstance(b);
            Debug.Log( a.N(1));
            //         Debug.Log(a.N<int, float>(1, " ", 2f));
            //Debug.Log(a.N<float>());

            //Debug.Log(a.N());
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
                nameSpaceStr += GenerateMemberNameSpace(property.PropertyType, nameSpaceCache);
                delcareStr += GenerateMemberDeclare(property.PropertyType, property.Name, "Property");
                newStr += GenerateMemberNew(property.PropertyType, property.Name, "Property");
            }

            var fields = classType.GetFields(Class.flags);
            foreach (var field in fields)
            {
                nameSpaceStr += GenerateMemberNameSpace(field.FieldType, nameSpaceCache);
                delcareStr += GenerateMemberDeclare(field.FieldType, field.Name, "Field");
                newStr += GenerateMemberNew(field.FieldType, field.Name, "Field");
            }

            var events = classType.GetEvents(Class.flags);
            foreach (var @event in events)
            {
                getSetHash.Add(@event.AddMethod);
                getSetHash.Add(@event.RemoveMethod);
                delcareStr += GenerateMemberDeclare(null, @event.Name, "Event");
                newStr += GenerateMemberNew(null, @event.Name, "Event");
            }

            string methodInvoke = GenerateMethod(classType, getSetHash, ref delcareStr, ref newStr);

            var generateStr = $@"{nameSpaceStr}using SMFrame.Editor.Refleaction;
using System;

namespace SMFrame.Editor.Refleaction.{classType.Namespace}
{{
    public class R{classType.ToDeclareName(false)} : Member
    {{
{delcareStr}

        public R{classType.ToDeclareName(false)}() : base(""{classType.FullName}"")
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
            var path = $"{Application.dataPath}/Script/UnityCsReflection/Generate/{classType.Namespace.Replace(".", "/")}/R{classType.Name}.cs";
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
