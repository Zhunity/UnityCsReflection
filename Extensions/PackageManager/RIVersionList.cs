using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
    public partial class RIVersionList
    {
		protected override void OnInit()
		{
			RPinstalled.GetValue();
			RPlatest.GetValue();
			RPimportAvailable.GetValue();
			RPrecommended.GetValue();
		}

		/// <summary>
		/// 兼容旧版 Unity 内部 API 的更新目标选择逻辑。
		/// 新版生成代码里没有 GetUpdateTarget 时，优先选择 recommended，其次 latest/importAvailable/installed。
		/// </summary>
		public RIPackageVersion GetUpdateTarget(RIPackageVersion installedVersion)
		{
			if (RPrecommended.Value != null)
			{
				return RPrecommended;
			}
			if (RPlatest.Value != null)
			{
				return RPlatest;
			}
			if (RPimportAvailable.Value != null)
			{
				return RPimportAvailable;
			}
			return installedVersion ?? RPinstalled;
		}

		protected override void OnSetBelong()
		{
			if(RPinstalled.RPversionId.Value == null)
			{
				return;
			}
			var rtargetVersion = GetUpdateTarget(RPinstalled);
			if (rtargetVersion?.RPversionId.Value == null)
			{
				return;
			}
			string installVersion = RPinstalled.RPversionId.Value as string;
			string targetVersion = rtargetVersion.RPversionId.Value as string;
			if (installVersion == targetVersion)
			{
				return;
			}
			var package = rBelong as RIPackage;
		}
	}
}