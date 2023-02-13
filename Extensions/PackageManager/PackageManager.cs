using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.PackageManager;
using System;
using System.Reflection;
using SMFrame;
#if UNITY_EDITOR
using UnityEditor;
using SMFrame.Editor.Refleaction;
#endif
using Object = UnityEngine.Object;
using System.Linq;
using SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI;

namespace SMFrame.Editor.Extension
{
	/// <summary>
	/// package manager一键更新
	/// </summary>
	public class PackageManager : Singleton<PackageManager>
	{
		RPackageManagerWindow packageWindow = new RPackageManagerWindow();


		public void Init()
		{
			Manifest.LoadManifest();
		}

		public void Update()
		{
			var window = Resources.FindObjectsOfTypeAll(packageWindow.type).FirstOrDefault();
			if (window != null)
			{
				packageWindow.SetInstance(window);
			}
		}
	}
}