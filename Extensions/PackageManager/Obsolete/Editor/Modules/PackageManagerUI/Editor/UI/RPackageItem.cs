using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Hvak.Editor.Refleaction;

public class RPackageItem : RType
{

	RProperty Item;  // UnityEngine.UIElements.VisualElement Item [Int32]
	IPackage package;

	public RPackageItem(Type type) : base(type)
	{
		// 索引器
		Item = new RProperty(this, "Item");
		package = new IPackage(this, "package");
	}

	protected override void OnSetInstance()
	{
	}

	public bool NeedUpdate()
	{
		return package.CheckVersion();
	}
}
