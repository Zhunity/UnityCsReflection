using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SMFrame.Editor.Refleaction;

/// <summary>
/// 显示选中package的信息
/// </summary>
public class IPackageVersion : Property
{
	public Property displayName;
	public Property description;
	public Property versionId;
	public Property dependencies;
	public Property resolvedDependencies;
	public Property isInstalled;

	public IPackageVersion(Class belongMember, string name) : base(belongMember, name)
	{
		displayName = new Property(this, "displayName");
		versionId = new Property(this, "versionId");
		dependencies = new Property(this, "dependencies");
		resolvedDependencies = new Property(this, "resolvedDependencies");
		isInstalled = new Property(this, "isInstalled");
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
