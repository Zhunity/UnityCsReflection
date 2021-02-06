using SMFrame.Editor.Refleaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RAppdomain : Class
{
	RThreadSafeDictionary _mapType;

	public RAppdomain() : base("Appdomain")
	{
		_mapType = new RThreadSafeDictionary(this, "mapType");
	}

	public object GetMapType()
	{
		return _mapType.Value;
	}
}
