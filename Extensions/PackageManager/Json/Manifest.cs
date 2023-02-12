using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public static class Manifest
{
	private static string LoadTextInEditor(string assetPath)
	{
		try
		{
			return File.ReadAllText(assetPath);
		}
		catch (Exception)
		{
			return null;
		}
	}
	private static void SaveTextInEditor(string assetPath, string text)
	{
		try
		{
			File.WriteAllText(assetPath, text);
		}
		catch (Exception)
		{
		}
	}

	static Dictionary<string, object> manifest;
	static Dictionary<string, object> package;
	static string path = Application.dataPath + "/../Packages/manifest.json";

	public static void LoadManifest()
	{
		var text = LoadTextInEditor(path);
		if (string.IsNullOrEmpty(text)) return;
		manifest = MiniJSON.Json.Deserialize(text) as Dictionary<string, object>;
		object list;
		manifest.TryGetValue("dependencies", out list);
		package = list as Dictionary<string, object>;
	}

	public static void SaveManifest()
	{
		var text = MiniJSON.Json.Serialize(manifest);
		if (string.IsNullOrEmpty(text)) return;
		SaveTextInEditor(path, text);
	}

	public static void SetVersion(string name, string version)
	{
		package[name] = version;
	}
}
