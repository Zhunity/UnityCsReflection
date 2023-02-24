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
			if(RPinstalled.RPversionId.Value == null)
			{
				return;
			}
			var rtargetVersion = GetUpdateTarget(RPinstalled);
			string installVersion = RPinstalled.RPversionId.Value as string;
			string targetVersion = rtargetVersion.RPversionId.Value as string;
			if (installVersion == targetVersion)
			{
				return;
			}
			var package = rBelong as RIPackage;
			Debug.Log(package.id + "  Value : " + package.Value + " RPdisplayName : " + package.RPdisplayName.Value + " RPinstalled : " + RPinstalled.RPversionId.Value + " targetVersion : " + rtargetVersion.RPversionId.Value);
		}
	}
}