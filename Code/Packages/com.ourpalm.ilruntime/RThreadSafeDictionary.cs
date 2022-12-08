using SMFrame.Editor.Refleaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RThreadSafeDictionary : RField
{
	public RProperty InnerDictionary;

	public RThreadSafeDictionary(RType belong, string name) : base(belong, name)
	{
		InnerDictionary = CreateProperty("InnerDictionary");
	}
}
