using SMFrame.Editor.Extension;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace SMFrame.Editor
{
	/// <summary>
	/// 创建UI组件
	/// </summary>
	public class AddUI
	{
		/// <summary>
		/// 创建Image
		/// </summary>
		public static void InstanceImage()
		{
			Image image = CreateComponent<Image>();
			AddComponentOptimizing.OptimizingImage(image);
		}

		/// <summary>
		/// 创建Text
		/// </summary>
		public static void InstanceText()
		{
			Text text = CreateComponent<Text>();
			AddComponentOptimizing.OptimizingText(text);
		}

		private static T CreateComponent<T>() where T : Component
		{
			string name = typeof(T).Name;
			GameObject go = new GameObject(name);
			Transform parent = GetUIParent();
			go.transform.SetParent(parent, false);
			T com = go.AddComponent<T>();
			return com;
		}

		private static Transform GetUIParent()
		{
			Transform select = Selection.activeTransform;
			if (select)
			{
				if (select.GetComponentInParent<Canvas>())
				{
					return select;
				}
				else
				{
					Canvas canvas = select.GetComponentInChildren<Canvas>();
					if (canvas == null)
					{
						canvas = InstanceCanvas(select);
					}
					return canvas.transform;
				}
			}
			else
			{
				Canvas canvas = GetCanvasInScene();
				if (canvas == null)
				{
					canvas = InstanceCanvas();
				}
				return canvas.transform;
			}
		}

		/// <summary>
		/// 参考PrefabStageUtility.HandleUIReparentingIfNeeded
		/// </summary>
		/// <returns></returns>
		static Canvas GetCanvasInScene()
		{
			// TODO 为什么会找不到？
			//Canvas canvas = Object.FindObjectOfType<Canvas>();
			Scene scene = SceneManager.GetActiveScene();
			foreach (GameObject go in scene.GetRootGameObjects())
			{
				// Do not search for Canvas's under the prefab root since we want to
				// have a Canvas for the prefab root
				var canvas = go.GetComponentInChildren<Canvas>();
				if (canvas != null)
					return canvas;
			}
			return null;
		}

		/// <summary>
		/// 参考PrefabStageUtility.HandleUIReparentingIfNeeded
		/// </summary>
		/// <returns></returns>
		private static Canvas InstanceCanvas(Transform parent = null)
		{
			const string kUILayerName = "UI";
			// Create canvas root for the UI
			GameObject root = EditorUtility.CreateGameObjectWithHideFlags("Canvas", HideFlags.DontSave);
			root.layer = LayerMask.NameToLayer(kUILayerName);
			Canvas canvas = root.AddComponent<Canvas>();
			canvas.renderMode = RenderMode.ScreenSpaceOverlay;
			root.AddComponent<CanvasScaler>();
			root.AddComponent<GraphicRaycaster>();
			if (parent)
			{
				canvas.transform.SetParent(parent, false);
			}
			return canvas;
		}
	}
}