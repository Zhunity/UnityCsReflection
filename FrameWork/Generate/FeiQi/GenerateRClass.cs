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

        static string UnityCSReflectionPath;

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

			GenerateProperty(classType, ref delcareStr, ref newStr, getSetHash);

			var fields = classType.GetFields(RClass.flags);
            foreach (var field in fields)
            {
                delcareStr += GenerateMemberDeclare(field.FieldType, field.Name, "RField", field.IsStatic);
                newStr += GenerateMemberNew(field.FieldType, field.Name, "RField");
            }

            var events = classType.GetEvents(RClass.flags);
            foreach (var @event in events)
            {
                getSetHash.Add(@event.AddMethod);
                getSetHash.Add(@event.RemoveMethod);
                delcareStr += GenerateMemberDeclare(null, @event.Name, "REvent", @event.IsStatic());
                newStr += GenerateMemberNew(null, @event.Name, "REvent");
            }

            string methodInvoke = GenerateMethod(classType, getSetHash, ref delcareStr, ref newStr);

            var generateStr = $@"{nameSpaceStr}using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R{classType.Namespace.Replace(".", ".R")}
{{
    public partial class R{classType.ToClassName()} : RMember
    {{
{delcareStr}

        public R{classType.ToConstructorName()}() : base(""{classType.FullName}"")
        {{
            NewMembers();
        }}

        public R{classType.ToConstructorName()}(System.Object instance) : base(""{classType.FullName}"")
		{{
			NewMembers();
            SetInstance(instance);
		}}

        public R{classType.ToConstructorName()}(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
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
            var path = $"{UnityCSReflectionPath}Generate/{classType.Namespace.Replace(".", "/")}/R{classType.Name}.cs";
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
            name = LegalName(name);

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
			return $"\t\t\t{LegalName(name)} = new {propertyType}(this, \"{name}\");\n";
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
                type.IsGenericParameter ||
                type.IsEnum || type.IsPrimitive; // int float等值类型
        }
        #endregion
    }
}