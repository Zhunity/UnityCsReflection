using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
    public partial class RPackageManagerWindowRoot 
    {
		protected override void OnSetBelong()
		{
			Debug.LogError(RFm_PackageDatabase.Value + "  " + RPpackageDetails.Value + " " + RPpackageList.Value);
		}
	}
}
