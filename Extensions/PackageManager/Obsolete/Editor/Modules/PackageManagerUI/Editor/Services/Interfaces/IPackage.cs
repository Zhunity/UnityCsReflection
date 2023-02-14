using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Hvak.Editor.Refleaction;

public class IPackage : RProperty
{
	RProperty displayName;
	RProperty packageName;
	IPackageVersion installedVersion;
	IPackageVersion latestVersion;

	// the recommended version to install or update to
	IPackageVersion recommendedVersion;


	// the primary version is most important version that we want to show to the user
	// it will be the default that will be displayed if no versions are selected
	IPackageVersion primaryVersion;

	public IPackage(RType belongMember, string name) : base(belongMember, name)
	{
		displayName = new RProperty(this, "displayName");
		packageName = new RProperty(this, "name");
		installedVersion = new IPackageVersion(this, "installedVersion");
		latestVersion = new IPackageVersion(this, "latestVersion");
		recommendedVersion = new IPackageVersion(this, "recommendedVersion");
		primaryVersion = new IPackageVersion(this, "primaryVersion");
	}

	protected override void OnSetBelong()
	{
	}

	public bool CheckVersion()
	{
		if(!IsInstalled())
		{
			return false;
		}

		if(!NeedUpdate())
		{
			return false;
		}

		Manifest.SetVersion(packageName.GetValue().ToString(), recommendedVersion.versionId.GetValue().ToString());
		return true;
	}

	private bool IsInstalled()
	{
		return (bool)(primaryVersion.isInstalled.GetValue());
	}

	private bool NeedUpdate()
	{
		return primaryVersion.versionId.GetValue().ToString() != recommendedVersion.versionId.GetValue().ToString();
	}

	private void ShowVersion()
	{
		Debug.Log("");
		Debug.Log("----------------------------" + displayName.GetValue() + " begin--------------------------------");
		Debug.Log("installedVersion:\t" + installedVersion.versionId.GetValue() + "\n" + displayName.GetValue() + "\n" + installedVersion.isInstalled.GetValue());
		Debug.Log("latestVersion:\t" + latestVersion.versionId.GetValue() + "\n" + displayName.GetValue() + "\n" + latestVersion.isInstalled.GetValue());
		Debug.Log("recommendedVersion:\t" + recommendedVersion.versionId.GetValue() + "\n" + displayName.GetValue() + "\n" + recommendedVersion.isInstalled.GetValue());
		Debug.Log("primaryVersion:\t" + primaryVersion.versionId.GetValue() + "\n" + displayName.GetValue() + "\n" + primaryVersion.isInstalled.GetValue());
		Debug.Log("----------------------------" + displayName.GetValue() + " end--------------------------------");
		Debug.Log("");
	}
}
