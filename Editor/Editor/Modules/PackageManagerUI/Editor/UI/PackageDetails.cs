using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using Object = UnityEngine.Object;
using SMFrame.Editor.Refleaction;

public class PackageDetails : Property
{
	IPackageVersion displayVersion;
	IPackageVersion targetVersion;

	public PackageDetails(Member belongMember, string name) : base(belongMember, name)
	{
		displayVersion = new IPackageVersion(this, "displayVersion");
	}
}
