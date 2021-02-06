using SMFrame.Editor.Refleaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RThreadSafeDictionary : Field
{
	public Property InnerDictionary;

	public RThreadSafeDictionary(Class belong, string name) : base(belong, name)
	{
		InnerDictionary = CreateProperty("InnerDictionary");
	}
}
