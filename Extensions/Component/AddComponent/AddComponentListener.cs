﻿using System;
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
using Hvak.Editor.Refleaction.RUnityEditor.RAddComponent;

namespace Hvak.Editor.Extension
{
	/// <summary>
	/// InspectorWindow.AddComponentButton打开选择Component下拉框
	/// UnityResourceReference AddComponentGUI是添加代码用的
	/// AddComponentWindow.Show 打开
	/// AddComponentWindow.OnItemSelected 目测时这个选中
	/// AddComponentWindow.
	/// </summary>
	public class AddComponentListener : Singleton<AddComponentListener>
	{
#if UNITY_EDITOR
		#region Common 通用逻辑
		// 添加组件的窗口对象
		RAddComponentWindow addComponentWindow = new RAddComponentWindow();

		Delegate closedDelegate;
		Delegate selectDelegate;

		// ComponentItem的对象的对象
		RComponentDropdownItem componentItem = new RComponentDropdownItem();

		private bool isClear = false;

		public void Init()
		{
			AddComponentDataSource.ShowNameToComponentName();
			closedDelegate = CreateDelegate(addComponentWindow.REwindowClosed.type, "WindowClosed");
			selectDelegate = CreateDelegate(addComponentWindow.REselectionChanged.type, "ItemSelect");
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

		#region 选中组件之后，进行分类操作
		/// <summary>
		/// 选中要添加的组件
		/// </summary>
		/// <param name="para"></param>
		public void ItemSelect(Object para)
		{
			if (para.GetType() == componentItem.type)
			{
				componentItem.SetInstance(para);
				string showName = (string)componentItem.displayName.GetValue();
				string componentName = AddComponentDataSource.GetComponentName(showName);
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
								AddComponentOptimizing.OptimizingImage(com as Image);
								break;
							}
						case ("Text"):
							{
								AddComponentOptimizing.OptimizingText(com as Text);
								break;
							}
						case ("Mask"):
							{
								AddComponentOptimizing.OptimizingMask(com as Mask);
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
		#endregion
#endif
	}
}