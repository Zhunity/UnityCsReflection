using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using UnityEngine;

namespace SMFrame.Editor.Refleaction
{
    public class LegalNameConfig
    {
		[Serializable]
		public class JsonDictionary<TKey, TValue> : Dictionary<TKey, TValue>, ISerializationCallbackReceiver
		{
			[SerializeField]
			private List<TKey> keys;
			[SerializeField]
			private List<TValue> values;

			public virtual void OnAfterDeserialize()
			{
				int count = Math.Min(keys.Count, values.Count);
				for (int i = 0; i < count; i++)
				{
					Add(keys[i], values[i]);
				}
			}

			public virtual void OnBeforeSerialize()
			{
				keys = new List<TKey>(Keys);
				values = new List<TValue>(Values);
			}
		}

		static JsonDictionary<string, int> replace;

		public static void LoadReplace(string jsonFile)
		{
			if (!File.Exists(jsonFile))
			{
				replace = new JsonDictionary<string, int>();
				return;
			}
			var str = File.ReadAllText(jsonFile);
			replace = JsonUtility.FromJson<JsonDictionary<string, int>>(str);
		}

		public static string LegalName(string str)
		{
			var matches = Regex.Matches(str, @"\W");
			if (matches == null || matches.Count <= 0)
			{
				return str;
			}
			foreach (var match in matches)
			{
				var c = match.ToString();
				if (!replace.TryGetValue(c, out int value))
				{
					value = replace.Count;
					replace[c] = value;
				}
				str = str.Replace(c, "__" + value.ToString() + "__");
			}
			return str;
		}

		public static void SaveReplace(string jsonFile)
		{
			if (File.Exists(jsonFile))
			{
				File.Delete(jsonFile);
			}
			if(!Directory.Exists(Path.GetDirectoryName(jsonFile)))
			{
				Directory.CreateDirectory(Path.GetDirectoryName(jsonFile));
			}
			File.WriteAllText(jsonFile, JsonUtility.ToJson(replace));
		}
	}
}
