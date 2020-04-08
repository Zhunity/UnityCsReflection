using SMFrame;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.UI;
using Object = System.Object;
using System.Linq;
using SMFrame.Editor.Refleaction;

namespace SMFrame.Editor.Extension
{
	/// <summary>
	/// InspectorWindow.AddComponentButton打开选择Component下拉框
	/// UnityResourceReference AddComponentGUI是添加代码用的
	/// AddComponentWindow.Show 打开
	/// AddComponentWindow.OnItemSelected 目测时这个选中
	/// AddComponentWindow.
	/// </summary>
	public class ComponentListener : Singleton<ComponentListener>
	{
#if UNITY_EDITOR
		#region Common 通用逻辑
		// 添加组件的窗口对象
		RAddComponentWindow addComponentWindow = new RAddComponentWindow("AddComponentWindow");

		Delegate closedDelegate;
		Delegate selectDelegate;

		// ComponentItem的对象的对象
		const string COMPONENT_ITEM_TYPE_NAME = "ComponentDropdownItem";
		RComponentDropdownItem componentItem = new RComponentDropdownItem(COMPONENT_ITEM_TYPE_NAME);

		private bool isClear = false;

		public void Init()
		{
			closedDelegate = CreateDelegate(addComponentWindow.windowClosed.type, "WindowClosed");
			selectDelegate = CreateDelegate(addComponentWindow.selectionChanged.type, "ItemSelect");
		}


		public void Update()
		{
			var windows = Resources.FindObjectsOfTypeAll(addComponentWindow.type).FirstOrDefault();
			if (windows != null)
			{
				if (isClear)
				{
					return;
				}
				isClear = true;
				addComponentWindow.SetInstance(windows);
				addComponentWindow.AddSelectionEventHandler(selectDelegate);
				addComponentWindow.AddCloseEventHandler(closedDelegate);
			}
			else
			{
				isClear = false;
			}
		}

		public void WindowClosed(Object para)
		{
			isClear = false;
		}

		protected void OnDestroy()
		{
			addComponentWindow.RemoveCloseEventHandler(closedDelegate);
			addComponentWindow.RemoveSelectionEventHandler(selectDelegate);
		}

		private Delegate CreateDelegate(Type type, string name)
		{
			Type t = this.GetType();
			var method = t.GetMethod(name);
			return method.CreateDelegate(type, this);
		}
		#endregion

		/// <summary>
		/// 选中要添加的组件
		/// </summary>
		/// <param name="para"></param>
		public void ItemSelect(Object para)
		{
			if (para.GetType().Name == COMPONENT_ITEM_TYPE_NAME)
			{
				componentItem.SetInstance(para);
				string componentName = (string)componentItem.displayName.GetValue();
				var gos = Selection.gameObjects;
				foreach (var go in gos)
				{
					Component com = go.GetComponent(componentName);
					if (com == null)
					{
						Debug.LogError("can not find com ", go);
						continue;
					}
					switch (componentName)
					{
						case ("Image"):
							{
								ComponentOptimizing.OptimizingImage(com as Image);
								break;
							}
						case ("Text"):
							{
								ComponentOptimizing.OptimizingText(com as Text);
								break;
							}
						case ("Mask"):
							{
								ComponentOptimizing.OptimizingMask(com as Mask);
								break;
							}
						default:
							{
								Debug.Log("add " + componentName);
								break;
							}
					}
				}

				isClear = false;
			}
		}
#endif
	}
}