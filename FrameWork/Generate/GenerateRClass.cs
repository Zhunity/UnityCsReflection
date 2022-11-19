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

        public void N()
        {
            Debug.Log("no param");
        }

        public string N<T>(T a = default)
        {
            return "12312312";
        }

		public string N<T, U>(T a, U b)
		{
			return "wwwww";
		}

        /// <summary>
        /// out找不到
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public string N(out bool a)
        {
            a = true;
            return "out bool";
        }

		public string N(ref int a)
		{
			a = 234234;
			return "ref www";
		}

		public string N( bool a)
		{
			a = true;
			return "iiiii";
		}

        //public string N(bool[][][][] a)
        //{
        //    return "12312312";
        //}

        public string N(in Dictionary<int[], List<string[][]>>[][] a)
        {
            return "Dictionary<int[], List<string[][]>>[][]";
        }

        public int N<T, U, A, z>(Dictionary<T, U> www, A fff, float e)
        {
            return 999;
        }

        //public string N(ref List<int> a)
        //{
        //    return "12312312";
        //}
    }

    public partial class GenerateRClass
    {
        [MenuItem("Tools/generate a file")]
        static void f()
        {
            //var a = GenerateParameterType(typeof(Dictionary<int[], List<string[][]>>[][]));
            //Debug.Log(a);
            //Generate<Dictionary<int[], List<string[][]>>[][]>();

            A b = new A();
            Generate(b);

        }

		[MenuItem("Tools/ra invoke")]
		static void G()
		{
			//var a = GenerateParameterType(typeof(Dictionary<int[], List<string[][]>>[][]));
			//Debug.Log(a);
			//Generate<Dictionary<int[], List<string[][]>>[][]>();

			A b = new A();

            SMFrame.Editor.Refleaction.RA a = new();
            a.SetInstance(b);
            Debug.Log(a.N<int>(1));
            Debug.Log(a.N<int, float>(1, 2f));

            Debug.Log(a.N(false));

            bool s = false;
            Debug.Log(a.N(out s));
            Debug.Log(s);

            int e = 0;
            Debug.Log(a.N(ref e));
            Debug.Log(e);

            Dictionary<int[], List<string[][]>>[][] starnge = new Dictionary<int[], List<string[][]>>[1][];
            Debug.Log(a.N(in starnge));


            Dictionary<int, string> d = new Dictionary<int, string>();
            //Debug.Log(a.N<int, string, int, string>(d, 1, 2));

            var tyope = d.GetType().GetGenericTypeDefinition();
			Debug.Log(tyope.Name + "  " + tyope.ToString() + "  " + tyope.ToDeclareName() + "  " + tyope.ToGetMethod());
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
			//if (IsPrimitive(classType) || _cacheType.Contains(classType))
			//{
			//	return;
			//}
			//_cacheType.Add(classType);

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
    public partial class R{classType.ToDeclareName(false)} : Member
    {{
{delcareStr}

        public R{classType.ToDeclareName(false)}() : base(""{classType.ToDeclareName()}"")
        {{
            NewMembers();
        }}

        public R{classType.ToDeclareName(false)}(Member belongMember, string name) : base(belongMember, name)
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

        static HashSet<Type> PrimitiveType = new HashSet<Type>()
        {
            typeof(string),
        };

        /// <summary>
        /// 判断是否是原始类型
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private static bool IsPrimitive(Type type)
        {
            return type == null ||
                PrimitiveType.Contains(type) || 
                type.IsEnum || type.IsPrimitive; // int float等值类型
        }
        #endregion
    }
}
