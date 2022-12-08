using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Event = SMFrame.Editor.Refleaction.REvent;
using System;

namespace SMFrame.Editor.Refleaction
{
	public class RAddComponentWindow : RClass
	{
		// 选中Component修改时的Event
		public REvent selectionChanged;

		// AddComponentWindow窗口关闭时的Event
		public REvent windowClosed;

		public RAddComponentWindow() : base("AddComponentWindow")
		{
			selectionChanged = new REvent(this, "selectionChanged");
			windowClosed = new REvent(this, "windowClosed");
		}

		public void AddSelectionEventHandler(Delegate action)
		{
			selectionChanged.AddEventHandler(action);
		}

		public void RemoveSelectionEventHandler(Delegate action)
		{
			selectionChanged.RemoveEventHandler(action);
		}

		public void AddCloseEventHandler(Delegate action)
		{
			windowClosed.AddEventHandler(action);
		}

		public void RemoveCloseEventHandler(Delegate action)
		{
			windowClosed.RemoveEventHandler(action);
		}
	}
}