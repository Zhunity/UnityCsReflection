using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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