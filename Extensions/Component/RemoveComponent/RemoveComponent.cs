using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace Hvak.Editor.Extension
{


	public static class RemoveComponent 
	{
		[MenuItem("CONTEXT/Image/Remove Component")]
		public static void RemoveImage(MenuCommand menuCommand)
		{
			var img = menuCommand.context as Image;
			var canvasRenderer = img.GetComponent<CanvasRenderer>();
			UnityEngine.Object.DestroyImmediate(img);

			UnityEngine.Object.DestroyImmediate(canvasRenderer);
		}

		[MenuItem("CONTEXT/Text/Remove Component")]
		public static void RemoveText(MenuCommand menuCommand)
		{
			var txt = menuCommand.context as Text;
			var canvasRenderer = txt.GetComponent<CanvasRenderer>();
			UnityEngine.Object.DestroyImmediate(txt);

			UnityEngine.Object.DestroyImmediate(canvasRenderer);
		}
	}
}