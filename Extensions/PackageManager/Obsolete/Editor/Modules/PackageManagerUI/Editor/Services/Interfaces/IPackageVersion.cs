using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Hvak.Editor.Refleaction;

/// <summary>
/// 显示选中package的信息
/// </summary>
public class IPackageVersion : RProperty
{
	public RProperty displayName;
	public RProperty description;
	public RProperty versionId;
	public RProperty dependencies;
	public RProperty resolvedDependencies;
	public RProperty isInstalled;

	public IPackageVersion(RType belongMember, string name) : base(belongMember, name)
	{
		displayName = new RProperty(this, "displayName");
		versionId = new RProperty(this, "versionId");
		dependencies = new RProperty(this, "dependencies");
		resolvedDependencies = new RProperty(this, "resolvedDependencies");
		isInstalled = new RProperty(this, "isInstalled");
	}

	protected override void OnSetBelong()
	{
		var dep = dependencies.GetValue();
		if (dep != null)
		{
			var array = dep as Array;
			foreach (var item in array)
			{
				DependencyInfo info = new DependencyInfo(item.GetType());
				info.SetInstance(item);
			}
		}
	}
}
