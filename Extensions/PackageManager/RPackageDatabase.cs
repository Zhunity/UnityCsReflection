using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
    public partial class RPackageDatabase
    {
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
				RIPackage item = new RIPackage(iter.Value);
				//Debug.Log(item.id + " create xxxxxxxxxxxxxxxxxxx  " + item.Value + "  " + item.RPdisplayName.Value);
			}
		}
	}
}