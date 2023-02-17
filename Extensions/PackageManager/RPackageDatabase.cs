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
				Debug.Log("");
				Debug.Log("");
				RIPackage item = new RIPackage(iter.Value);
				Debug.Log("RPdisplayName : " +item.RPdisplayName.Value + " RPpublisherName :  " + item.RPpublisherName.Value + " Key : " + iter.Key + " Value : " + iter.Value);
				Debug.Log("");
				Debug.Log("");

				if(item.RPversions.instance == null)
				break;
			}
		}
	}
}