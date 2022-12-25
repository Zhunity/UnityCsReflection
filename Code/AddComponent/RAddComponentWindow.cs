using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Event = SMFrame.Editor.Refleaction.REvent;
using System;

namespace SMFrame.Editor.Refleaction.RUnityEditor.RAddComponent
{
	public partial class RAddComponentWindow
	{

		/// <summary>
		/// 选中Component修改时的Event
		/// </summary>
		/// <param name="action"></param>
		public void AddSelectionEventHandler(Delegate action)
		{
			RselectionChanged.AddEventHandler(action);
		}

		public void RemoveSelectionEventHandler(Delegate action)
		{
			RselectionChanged.RemoveEventHandler(action);
		}

		/// <summary>
		/// AddComponentWindow窗口关闭时的Event
		/// </summary>
		/// <param name="action"></param>
		public void AddCloseEventHandler(Delegate action)
		{
			RwindowClosed.AddEventHandler(action);
		}

		public void RemoveCloseEventHandler(Delegate action)
		{
			RwindowClosed.RemoveEventHandler(action);
		}
	}
}