using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SMFrame.Editor.Extension
{
	/// <summary>
	/// 编辑器下各种实际
	/// </summary>
	[InitializeOnLoad]
	public static class EditorTiming
	{
		static EditorTiming()
		{
			Init();
			EditorApplication.update += Update;
			SceneView.duringSceneGui += OnSceneGUI;
		}

		static private void Init()
		{
			AddComponentDataSource.ShowNameToComponentName();
			AddComponentListener.Instance.Init();
			PackageManager.Instance.Init();
			//SceneGrid.Instance.Init();
		}

		static private void Update()
		{
			AddComponentListener.Instance.Update();
			PackageManager.Instance.Update();
		}

		static private void OnSceneGUI(SceneView view)
		{
			//SceneGrid.Instance.OnSceneGUI();
		}
	}
}

