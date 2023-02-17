using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
    public partial class RIVersionList
    {
		protected override void OnInit()
		{
			RPinstalled.GetValue();
			RPlatest.GetValue();
			RPimportAvailable.GetValue();
			RPrecommended.GetValue();
		}

		protected override void OnSetBelong()
		{
			Debug.Log("OnSetBelong : " + RPinstalled.Value + "  " + GetHashCode() + " " + instance + "  hash code " + GetHashCode());
		}
	}
}