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
			if (packages == null)
			{
				return;
			}

			var iter = packages.GetEnumerator();
			while (iter.MoveNext())
			{
				item.SetInstance(iter.Value);
				if (item.RPstate.Value.Equals(RPackageState.RFUpdateAvailable.Value))
				{
					if (UnityEditor.EditorUtility.DisplayDialog("一键更新", $"检测到 {item.RPdisplayName.Value} 可更新，是否立即更新？", "确定", "取消"))
					{
						var updateTarget = item.RPversions.GetUpdateTarget(item.RPversions.RPinstalled);
						Install(updateTarget);
						Debug.Log($"{item.id} 更新 {item.RPdisplayName.Value}，状态 {item.RPstate.Value}，目标版本：{updateTarget.RPversionId.Value}");
					}
					break;
				}
			}
		}
	}
}