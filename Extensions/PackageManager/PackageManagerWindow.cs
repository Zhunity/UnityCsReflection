using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Hvak.Editor.Refleaction;
using Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI
{
	/// <summary>
	/// package管理界面
	/// </summary>
	public partial class RPackageManagerWindow
	{
		protected override void OnInit()
		{
			RFm_Root.GetValue();
		}
	}
}
