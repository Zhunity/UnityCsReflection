using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SMFrame.Editor.Refleaction;

/// <summary>
/// package管理界面
/// </summary>
public class PackageWindow : Member
{
	const string packageDetailsName = "packageDetails";
	PackageDetails packageDetails;
	PackageList packageList;

	public PackageWindow(Type type) : base(type)
	{
		packageDetails = new PackageDetails(this, packageDetailsName);
		packageList = new PackageList(this, "packageList");
	}
}
