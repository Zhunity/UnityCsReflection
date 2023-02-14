using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;

namespace Hvak.Editor.Extension
{
	/// <summary>
	/// 编辑器下各种实际
	/// </summary>
	[InitializeOnLoad]
	public static class EditorTiming
	{

		[DidReloadScripts]
		static private void Init()
		{
			EditorApplication.update += Update;
			SceneView.duringSceneGui += OnSceneGUI;
			
			AddComponentListener.Instance.Init();
			PackageManager.Instance.Init();
		}

		static private void Update()
		{
			AddComponentListener.Instance.Update();
			PackageManager.Instance.Update();
		}

		static private void OnSceneGUI(SceneView view)
		{

		}
	}
}

