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
		}

		static private void Init()
		{
			ComponentListener.Instance.Init();
			PackageManager.Instance.Init();
		}

		static private void Update()
		{
			ComponentListener.Instance.Update();
			PackageManager.Instance.Update();
		}
	}
}

