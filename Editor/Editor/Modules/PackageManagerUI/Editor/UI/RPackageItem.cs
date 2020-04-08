using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SMFrame.Editor.Refleaction;

public class RPackageItem : Class
{

	Property Item;  // UnityEngine.UIElements.VisualElement Item [Int32]
	IPackage package;

	public RPackageItem(Type type) : base(type)
	{
		// 索引器
		Item = new Property(this, "Item");
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
