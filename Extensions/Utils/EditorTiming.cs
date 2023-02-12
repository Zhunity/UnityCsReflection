using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;

namespace SMFrame.Editor.Extension
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
#if !UNITY_2020_2_OR_NEWER
			PackageManager.Instance.Init();
#endif
		}

		static private void Update()
		{
			AddComponentListener.Instance.Update();
#if !UNITY_2020_2_OR_NEWER
			PackageManager.Instance.Update();
#endif
		}

		static private void OnSceneGUI(SceneView view)
		{

		}
	}
}

