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

		public static float N<T>(int e, out T a, ref float b, in long c, params bool[][][] d)
		{
			a = default;
			return 1;
		}

		public void N()
		{
			Debug.Log("no param");
		}

		public string N<T>(T[] a = default)
		{
			return "12312312";
		}

		public int N(ref string[] s)
		{
			return 1111;
		}

		public void N<a, b, c, d, e, f, g>(Dictionary<a, int> s, b[] asdf, HashSet<Dictionary<e, c[]>> wer)
		{
			Debug.Log("N ???");
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

		public string N(bool a)
		{
			a = true;
			return "iiiii";
		}

		public string N(bool[][][][] a)
		{
			return "12312312";
		}

		public string N(in Dictionary<int[], List<string[][]>>[][] a)
		{
			return "Dictionary<int[], List<string[][]>>[][]";
		}

		public int N<T, U, A, z>(Dictionary<T, U> www, A fff, float e)
		{
			return 999;
		}

		public string N(ref List<int> a)
		{
			return "12312312";
		}
	}

    public partial class GenerateRClass
    {
        [MenuItem("Tools/generate a file")]
        static void f()
        {
            _waitToGenerate.Clear();
            _cacheType.Clear();

            AddGenerateClass(typeof(GameObject));
            GenerateClasses();
            AssetDatabase.Refresh();
        }

        class s : IDisposable
        {
             void IDisposable.Dispose()
            {
                throw new NotImplementedException();
            }

            void Dispose()
            {

            }

            public class ins {

            }

        }
        class g<T> { }
		
		[MenuItem("Tools/ra invoke")]
		static void G()
		{

            // TODO
            // 1. 类中类
            var type = typeof(s.ins);
            //         Debug.Log(type.Name + "  " + type.FullName + "  " + type.ToString());
            //         Debug.Log(ReleactionUtils.GetType(" SMFrame.Editor.Refleaction.GenerateRClass+s+ins"));

            //// 2.泛型
            //type = typeof(Dictionary<,>);
            //Debug.Log(type.Name + "  " + type.FullName + "  " + type.ToString());
            //         Debug.Log(ReleactionUtils.GetType("System.Collections.Generic.Dictionary`2"));

            // 3.接口里面的xxx.xxx
            type = typeof(DateTime);
            var m = type.GetMethod("System.IConvertible.ToBoolean", Class.flags);
            Debug.Log(m);

            //Debug.Log(type+ " ----  " + type.Name + " ----  " + type.GetGenericArguments().Length);
            Generate(typeof(DateTime));
            AssetDatabase.Refresh();
            //a<int> ss = new a<int> ();
            //RSMFrame.REditor.RRefleaction.Ra<int> test = new();
            //test.SetBelong(ss);
            //Debug.Log( test.ToString());
            //         A a = new A();
            //         RA ra = new RA();
            //         ra.SetInstance(a);
            //         ra.N();

            //Debug.Log(ra.N(new int[] { }));
        }

        private static Queue<Type> _waitToGenerate = new Queue<Type>();
		static HashSet<Type> _cacheType = new HashSet<Type>();
		public static void AddGenerateClass(Type type)
        {
            _waitToGenerate.Enqueue(type);
		}

        public static void GenerateClasses()
        {
            int i = 0;
			while (_waitToGenerate.Count > 0)
            {
				i++;
				if (EditorUtility.DisplayCancelableProgressBar("生成文件", $"已生成{i}， 剩余{_waitToGenerate.Count}", (float)i / (float)_waitToGenerate.Count))
				{
					break;
				}
				Type type = _waitToGenerate.Dequeue();
				try
                {
                    if (IsPrimitive(type) || _cacheType.Contains(type))
                    {
                        continue;
                    }
                    _cacheType.Add(type);
                    Generate(type);
                }
                catch(Exception e)
                {
                    Debug.LogError(type + "\n" + e.ToString());
                }
			}
            EditorUtility.ClearProgressBar();
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
                AddGenerateClass(type);
				nameSpaceStr += GenerateMemberNameSpace(type, nameSpaceCache);
			}

			HashSet<MethodInfo> getSetHash = new HashSet<MethodInfo>();

            var properties = classType.GetProperties(Class.flags);
            foreach (var property in properties)
            {
                getSetHash.Add(property.SetMethod);
                getSetHash.Add(property.GetMethod);

                delcareStr += GenerateMemberDeclare(property.PropertyType, property.Name, "Property", property.IsStatic());
                newStr += GenerateMemberNew(property.PropertyType, property.Name, "Property");
            }

            var fields = classType.GetFields(Class.flags);
            foreach (var field in fields)
            {
                delcareStr += GenerateMemberDeclare(field.FieldType, field.Name, "Field", field.IsStatic);
                newStr += GenerateMemberNew(field.FieldType, field.Name, "Field");
            }

            var events = classType.GetEvents(Class.flags);
            foreach (var @event in events)
            {
                getSetHash.Add(@event.AddMethod);
                getSetHash.Add(@event.RemoveMethod);
                delcareStr += GenerateMemberDeclare(null, @event.Name, "Event", @event.IsStatic());
                newStr += GenerateMemberNew(null, @event.Name, "Event");
            }

            string methodInvoke = GenerateMethod(classType, getSetHash, ref delcareStr, ref newStr);

            var generateStr = $@"{nameSpaceStr}using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R{classType.Namespace.Replace(".", ".R")}
{{
    public partial class R{classType.ToClassName()} : Member
    {{
{delcareStr}

        public R{classType.ToConstructorName()}() : base(""{classType.FullName}"")
        {{
            NewMembers();
        }}

        public R{classType.ToConstructorName()}(Member belongMember, string name) : base(belongMember, name)
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

            //Debug.Log(nameSpaceStr);
            //Debug.Log(delcareStr);
            //Debug.Log(newStr);
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
        }

        private static string GenerateMemberNameSpace(Type type, HashSet<string> nameSpaceCache)
        {
            if(type == null)
            {
                return String.Empty;
            }
            var nameSpace = type.Namespace;
            if (string.IsNullOrEmpty(nameSpace) || nameSpaceCache.Contains(nameSpace))
            {
                return string.Empty;
            }
            nameSpaceCache.Add(nameSpace);
            var result = $"";
            if(!IsPrimitive(type))
            {
				result += $"using SMFrame.Editor.Refleaction.R{nameSpace.Replace(".", ".R")};\n";

			}
			return result;
        }

        private static string GenerateDeclare(string typeName, string name, string note, bool isStatic)
        {
            name = name.Substring(name.LastIndexOf('.') + 1);

			return $"\t\tpublic {(isStatic ? "static" : "")} {typeName} {name}; //{note}\n";
        }

        private static string GenerateMemberDeclare(Type type, string name, string memberType, bool isStatic)
        {
            string propertyType = (IsPrimitive(type)) ? memberType : "R" + type.ToDeclareName(false);
            return GenerateDeclare(propertyType, name, type?.FullName, isStatic);
        }

        private static string GenerateMemberNew(Type type, string name, string memberType)
        {
            string propertyType = IsPrimitive(type) ? memberType : "R" + type.ToDeclareName(false);
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
