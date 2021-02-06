using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SMFrame.Editor.Refleaction;

public class DependencyInfo : Class
{
	public Property version;
	public Property packageName;

	public DependencyInfo(Type type) : base(type)
	{
		version = new Property(this, "version");
		this.packageName = new Property(this, "name");
	}
}
