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
				if(type == null)
				{
					continue;
				}
				type = type.ToBasicType();
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

		#region 生成单个
		public static void Generate(Type classType, bool refType = true)
		{
			_waitToGenerate.Clear();
			_cacheType.Clear();
			string jsonFile = UnityCSReflectionPath + "FrameWork/Generate/Config/Replace.txt";
			LegalNameConfig.LoadReplace(jsonFile);
			GenerateInternal(classType, refType);
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
		#endregion

		#region 生成多个
		public static void Generate(IEnumerable<Type> types)
		{
			_waitToGenerate.Clear();
			_cacheType.Clear();
			string jsonFile = UnityCSReflectionPath + "FrameWork/Generate/Config/Replace.txt";
			LegalNameConfig.LoadReplace(jsonFile);
			foreach (var type in types)
			{
				AddGenerateClass(type);
			}
			GenerateClasses();
			LegalNameConfig.SaveReplace(jsonFile);
			AssetDatabase.Refresh();
		}

		public static void Generate(IEnumerable<string> types)
		{
			_waitToGenerate.Clear();
			_cacheType.Clear();
			string jsonFile = UnityCSReflectionPath + "FrameWork/Generate/Config/Replace.txt";
			LegalNameConfig.LoadReplace(jsonFile);
			foreach (var type in types)
			{
				AddGenerateClass(ReleactionUtils.GetType(type));
			}
			GenerateClasses();
			LegalNameConfig.SaveReplace(jsonFile);
			AssetDatabase.Refresh();
		}

		public static void Generate(IEnumerable<object> objs)
		{
			_waitToGenerate.Clear();
			_cacheType.Clear();
			string jsonFile = UnityCSReflectionPath + "FrameWork/Generate/Config/Replace.txt";
			LegalNameConfig.LoadReplace(jsonFile);
			foreach (var obj in objs)
			{
				Type type;
				switch(obj)
				{
					case Type t:
						type = t;
						break;
					case string name:
						type = ReleactionUtils.GetType(name);
						break;
					default:
						type = obj.GetType();
						break;
				}
				AddGenerateClass(type);
			}
			GenerateClasses();
			LegalNameConfig.SaveReplace(jsonFile);
			AssetDatabase.Refresh();
		}
		#endregion

		public static void GenerateInternal(Type classType, bool refType = true)
		{
			GType gType = new(classType);
			if(refType)
			{
				var types = gType.GetRefTypes();
				foreach (var type in types)
				{
					AddGenerateClass(type);
				}
			}	

			var generateStr = gType.ToString();
			var path = GetPath(classType);

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


		private static string GetPath(Type classType)
		{
			string path = classType.FullName.Replace(classType.Name, "");
			var nameSpaceSplits = path.Split(".");
			string result = $"{UnityCSReflectionPath}Generate/";
			for(int i = 0; i < nameSpaceSplits.Length; i ++)
			{
				var nameSpaceSplit = nameSpaceSplits[i];
				if(string.IsNullOrEmpty(nameSpaceSplit))
				{
					continue;
				}
				var nestedTypeSplits = nameSpaceSplit.Split("+");
				for(int j = 0; j < nestedTypeSplits.Length; j ++)
				{
					var nestedTypeSplit = nestedTypeSplits[j];
					if (string.IsNullOrEmpty(nestedTypeSplit))
					{
						continue;
					}
					result += LegalNameConfig.LegalName(nestedTypeSplit) + "/";
				}

			}
			result += $"R{ LegalNameConfig.LegalName(classType.Name)}.cs";
			return result;
		}
		

		/// <summary>
		/// 判断是否是原始类型
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public static bool IsPrimitive(Type type)
		{
			return PrimitiveTypeConfig.IsPrimitive(type);
		}
	}
}