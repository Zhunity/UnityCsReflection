using Hvak.Editor.Refleaction;
using Hvak.Editor.Refleaction.RUnityEditor;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Hvak.Editor.Extension
{
	public static class AddComponentDataSource
	{
		static Dictionary<string, string> _showNameToComponentName = new Dictionary<string, string>();

		public static string GetComponentName(string showName)
		{
			_showNameToComponentName.TryGetValue(showName, out string name);
			return name;
		}

		public static void ShowNameToComponentName()
		{
			_showNameToComponentName.Clear();
			var menuDictionary = GetMenuDictionary();
			menuDictionary.Sort(CompareItems);
			for (var i = 0; i < menuDictionary.Count; i++)
			{
				var menu = menuDictionary[i];
				if (menu.Value == "ADD")
				{
					continue;
				}

				var menuPath = menu.Key;
				var paths = menuPath.Split('/');
				var path = paths[paths.Length - 1];
				var componentName = GetComponentNameInternal(menu.Value);
				_showNameToComponentName[path] = componentName;
				//var element = new ComponentDropdownItem(path, L10n.Tr(path), menuPath, menu.Value);
				//Debug.LogErrorFormat("path : {0}\nL10n.Tr(path) : {1}\nmenuPath : {2}\nmenu.Value : {3}\ncomponentName : {4}", path, L10n.Tr(path), menuPath, menu.Value, componentName);
			}
		}

		private static List<KeyValuePair<string, string>> GetMenuDictionary()
		{
			var menus = Unsupported.GetSubmenus("Component");
			var commands = Unsupported.GetSubmenusCommands("Component");

			var menuDictionary = new Dictionary<string, string>(menus.Length);
			for (var i = 0; i < menus.Length; i++)
			{
				menuDictionary.Add(menus[i], commands[i]);
			}
			return menuDictionary.ToList();
		}

		private static int CompareItems(KeyValuePair<string, string> x, KeyValuePair<string, string> y)
		{
			var legacyString = "legacy";
			var isStr1Legacy = x.Key.ToLower().Contains(legacyString);
			var isStr2Legacy = y.Key.ToLower().Contains(legacyString);
			if (isStr1Legacy && isStr2Legacy)
				return x.Key.CompareTo(y.Key);
			if (isStr1Legacy)
				return 1;
			if (isStr2Legacy)
				return -1;
			return x.Key.CompareTo(y.Key);
		}

		private static string GetComponentNameInternal(string command)
		{
			if (command.StartsWith("SCRIPT"))
			{
				var scriptId = int.Parse(command.Substring(6));
				var obj = EditorUtility.InstanceIDToObject(scriptId);
				return obj.name;
			}
			else
			{
				var classId = int.Parse(command);
				var unityType = RUnityType.FindTypeByPersistentTypeID(classId);
				return unityType.RPname.GetValue().ToString();
			}
		}
	}
}