using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace SMFrame.Editor.Refleaction
{
    public partial class GenerateInput 
    {
		public static string UnityCSReflectionPath;

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
					GenerateInternal(type);
				}
				catch (Exception e)
				{
					Debug.LogError(type + "\n" + e.ToString());
				}
			}
			EditorUtility.ClearProgressBar();
		}

		public static void Generate(Type classType, bool refType = true)
		{
			_waitToGenerate.Clear();
			_cacheType.Clear();
			string jsonFile = UnityCSReflectionPath + "FrameWork/Generate/Config/Replace.txt";
			LegalNameConfig.LoadReplace(jsonFile);
			GenerateInternal(classType);
			if(refType)
			{
				GenerateClasses();
			}
			LegalNameConfig.SaveReplace(jsonFile);
			AssetDatabase.Refresh();
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

		public static void GenerateInternal(Type classType)
		{
			GType gType = new(classType);
			var types = gType.GetRefTypes();
			foreach (var type in types)
			{
				AddGenerateClass(type);
			}

			var generateStr = gType.ToString();
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

		static HashSet<Type> PrimitiveType = new HashSet<Type>()
		{
			typeof(string),
		};

		/// <summary>
		/// 判断是否是原始类型
		/// TODO nuodao ling waiyi ge weizhi
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public static bool IsPrimitive(Type type)
		{
			return type == null ||
				PrimitiveType.Contains(type) ||
				type.IsGenericParameter ||
				type.IsEnum || type.IsPrimitive; // int float等值类型
		}
	}
}