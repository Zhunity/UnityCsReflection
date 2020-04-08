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

namespace SMFrame.Editor.Extension
{
	/// <summary>
	/// package manager一键更新
	/// </summary>
	public class PackageManager : Singleton<PackageManager>
	{
#if UNITY_EDITOR
		string packageManagerWidowName = "PackageManagerWindow";
		Type windowType;
		PackageWindow packageWindow;


		public void Init()
		{
			windowType = NativeCodeReader.Instance.GetType(packageManagerWidowName);
			packageWindow = new PackageWindow(windowType);

			Manifest.LoadManifest();
		}

		public void Update()
		{
			var window = Resources.FindObjectsOfTypeAll(windowType).FirstOrDefault();
			if (window != null)
			{
				packageWindow.SetInstance(window);
			}
		}
#endif
	}
}