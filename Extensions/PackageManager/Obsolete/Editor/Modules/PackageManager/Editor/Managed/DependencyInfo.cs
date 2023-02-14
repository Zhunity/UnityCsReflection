using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Hvak.Editor.Refleaction;

public class DependencyInfo : RType
{
	public RProperty version;
	public RProperty packageName;

	public DependencyInfo(Type type) : base(type)
	{
		version = new RProperty(this, "version");
		this.packageName = new RProperty(this, "name");
	}
}
