using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Reflection;
using System.IO;
namespace SMFrame.Editor.Refleaction
{

    public partial class GenerateRClass
    {
        [MenuItem("Tools/generate a file")]
        static void f()
        {
            var types = CollectClass(typeof(GameObject));
            foreach(var type in types)
            {
                Debug.Log(type);
            }
			//Generate(typeof(GameObject));
		}

		[MenuItem("Tools/ra invoke")]
		static void G()
		{
			
		}

        private static Queue<Type> _waitToGenerate = new Queue<Type>();
		static HashSet<Type> _cacheType = new HashSet<Type>();
		public static void AddGenerateClass(Type type)
        {
            _waitToGenerate.Enqueue(type);
		}

        public static void GenerateClasses()
        {
            while(_waitToGenerate.Count > 0)
            {
                Type type = _waitToGenerate.Dequeue();
                if (IsPrimitive(type) || _cacheType.Contains(type))
                {
                    return;
                }
                _cacheType.Add(type);
                Generate(type);
			}
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
        

        public static void GenerateInternal(Type classType)
        {
			var nameSpaceStr = string.Empty;
            var delcareStr = string.Empty;
            var newStr = string.Empty;
            HashSet<string> nameSpaceCache = new HashSet<string>();
			var types = CollectClass(classType);
			foreach (var type in types)
			{
				Debug.Log(type);
                AddGenerateClass(type);
				nameSpaceStr += GenerateMemberNameSpace(type, nameSpaceCache);
			}

			HashSet<MethodInfo> getSetHash = new HashSet<MethodInfo>();

            var properties = classType.GetProperties(Class.flags);
            foreach (var property in properties)
            {
                getSetHash.Add(property.SetMethod);
                getSetHash.Add(property.GetMethod);
                delcareStr += GenerateMemberDeclare(property.PropertyType, property.Name, "Property");
                newStr += GenerateMemberNew(property.PropertyType, property.Name, "Property");
            }

            var fields = classType.GetFields(Class.flags);
            foreach (var field in fields)
            {
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
            string propertyType = (IsPrimitive(type) || type.IsPublic) ? memberType : "R" + type.ToDeclareName(false);
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
