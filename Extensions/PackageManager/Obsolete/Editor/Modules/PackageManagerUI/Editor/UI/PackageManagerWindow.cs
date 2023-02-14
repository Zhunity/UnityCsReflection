using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Hvak.Editor.Refleaction;

/// <summary>
/// package管理界面
/// </summary>
public class PackageWindow : RMember
{
	const string packageDetailsName = "packageDetails";
	PackageDetails packageDetails;
	PackageList packageList;

	public PackageWindow() : base("PackageManagerWindow")
	{
		packageDetails = new PackageDetails(this, packageDetailsName);
		packageList = new PackageList(this, "packageList");
	}
}
