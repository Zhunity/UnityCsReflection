using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
    public partial class RPackageDatabase
    {
		RIPackage item = new RIPackage();

		protected override void OnInit()
		{
			RFm_Packages.GetValue();
		}

		protected override void OnSetBelong()
		{
			var packages = RFm_Packages.GetValue() as IDictionary;
			var iter = packages.GetEnumerator();
			while (iter.MoveNext())
			{
				item.SetInstance(iter.Value);
				if (item.RPstate.Value.Equals( RPackageState.RFUpdateAvailable.Value))
				{
					if (UnityEditor.EditorUtility.DisplayDialog("一键升级", $"检测到有{item.RPdisplayName.Value}可以升级，是否一键升级？", "确认", "取消"))
					{
						var updateTarget = item.RPversions.GetUpdateTarget(item.RPversions.RPinstalled);
						Install(updateTarget);
						Debug.Log(item.id + " update  " + item.RPdisplayName.Value + "  state " + item.RPstate.Value + " to version : " + updateTarget.RPversionId.Value);
					}
					break;
				}
			}
		}
	}
}