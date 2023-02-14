using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using Object = UnityEngine.Object;
using Hvak.Editor.Refleaction;

public class PackageDetails : RProperty
{
	IPackageVersion displayVersion;
	IPackageVersion targetVersion;

	public PackageDetails(RMember belongMember, string name) : base(belongMember, name)
	{
		displayVersion = new IPackageVersion(this, "displayVersion");
	}
}
