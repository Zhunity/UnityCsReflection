using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

namespace SMFrame.Editor.Extension
{
	/// <summary>
	/// 组件优化
	/// </summary>
	public class AddComponentOptimizing
	{
		#region Image
		public static void OptimizingImage(Image image)
		{
			image.raycastTarget = false;
		}
		#endregion


		#region Text
		public static void OptimizingText(Text text)
		{
			text.raycastTarget = false;
			text.supportRichText = false;
		}

		public static void OptimizingTMP(TextMeshPro tmp)
		{
			tmp.raycastTarget = false;
			tmp.font = AssetDatabase.LoadAssetAtPath<TMP_FontAsset>("Assets/ABRes/Font/simsun SDF.asset");
		}
		#endregion

		#region Mask
		public static void OptimizingMask(Mask mask)
		{
			var canvas = mask.GetComponentInParent<Canvas>();
			if(canvas == null)
			{
				return;
			}
			// TODO UI上mask转Rect Mask 2D
		}
		#endregion
	}
}