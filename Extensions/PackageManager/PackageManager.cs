using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.PackageManager;
using System;
using System.Reflection;
using Hvak;
#if UNITY_EDITOR
using UnityEditor;
using Hvak.Editor.Refleaction;
#endif
using Object = UnityEngine.Object;
using System.Linq;
using Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI;

namespace Hvak.Editor.Extension
{
	/// <summary>
	/// package manager一键更新
	/// </summary>
	public class PackageManager : Singleton<PackageManager>
	{
		RPackageManagerWindow packageManagerWindow = new RPackageManagerWindow();


		public void Init()
		{
		}

		public void Update()
		{
			var window = RPackageManagerWindow.RPinstance.Value;
			if (window != null)
			{
				packageManagerWindow.SetInstance(window);
			}
		}
	}
}