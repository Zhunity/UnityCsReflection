using SMFrame.Editor.Refleaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RThreadSafeDictionary : Member
{
	Field InnerDictionary;

	public RThreadSafeDictionary(Class belong) : base(belong, "ThreadSafeDictionary")
	{
		InnerDictionary = CreateField("InnerDictionary");
	}
}
