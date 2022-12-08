using SMFrame.Editor.Refleaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RAppdomain : RType
{
	RThreadSafeDictionary _mapType;

	public RAppdomain() : base("ILRuntime.Runtime.Enviorment.AppDomain")
	{
		_mapType = new RThreadSafeDictionary(this, "mapType");
	}

	public void GetMapType()
	{
		var d = _mapType.InnerDictionary.Value as IDictionary;
		var iter = d.GetEnumerator();
		while (iter.MoveNext())
		{
			Debug.Log(iter.Key);
		}
	}
}
