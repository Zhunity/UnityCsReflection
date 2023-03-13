using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using UnityEditor.Experimental.SceneManagement;
using UnityEngine.SceneManagement;

namespace Hvak.Editor
{
	/// <summary>
	/// Hierarchy的右键菜单
	/// TODO 可参考UnityResourceReference  SceneHierarchy.AddCreateGameObjectItemsToMenu
	/// </summary>
	public class AddUIMenuItem
	{
		[MenuItem("GameObject/UI/Image")]
		static void CreatImage()
		{
			AddUI.InstanceImage();
		}

		[MenuItem("GameObject/UI/Text")]
		static void CreatText()
		{
			AddUI.InstanceText();
		}

		[MenuItem("GameObject/UI/Text - TextMeshPro")]
		static void CreatTMP()
		{
			AddUI.InstacneTMP();
		}
	}
}
