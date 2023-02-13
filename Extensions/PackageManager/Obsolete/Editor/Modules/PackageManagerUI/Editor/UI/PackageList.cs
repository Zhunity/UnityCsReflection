using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using SMFrame.Editor.Refleaction;

/// <summary>
/// 显示出来的package列表
/// </summary>
public class PackageList : RMember
{
	RField m_PackageItemsLookup;
	Type packageItemType;
	Dictionary<string, RPackageItem> r_PackageItemsLookup = new Dictionary<string, RPackageItem>(); // 122个

	public PackageList(RMember belongMember, string name) : base(belongMember, name)
	{
		m_PackageItemsLookup = new RField(this, "m_PackageItemsLookup");
		var arguments = m_PackageItemsLookup.GetGenericTypeArguments();
		r_PackageItemsLookup.Clear();
		packageItemType = arguments[1];
	}

	protected override void OnSetBelong()
	{
		r_PackageItemsLookup.Clear();
		IDictionary dict = m_PackageItemsLookup.Value as IDictionary;
		Debug.Log(dict.Count);
		var iter = dict.GetEnumerator();
		while(iter.MoveNext())
		{
			RPackageItem item = new RPackageItem(packageItemType);
			item.SetInstance(iter.Value);
			r_PackageItemsLookup.Add(iter.Key.ToString(), item);
		}

		bool needUpdate = false;
		foreach(var item in r_PackageItemsLookup)
		{
			if(item.Value.NeedUpdate())
			{
				needUpdate = true;
			}
		}

		
		if (needUpdate)
		{
			if(EditorUtility.DisplayDialog("一键升级", "检测到有package可以升级，是否一键升级？", "确认", "取消"))
			{
				Manifest.SaveManifest();
			}
		}
	}
}
