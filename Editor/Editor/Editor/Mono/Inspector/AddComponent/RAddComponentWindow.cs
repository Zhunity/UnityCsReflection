using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Event = SMFrame.Editor.Refleaction.Event;
using System;

namespace SMFrame.Editor.Refleaction
{
	public class RAddComponentWindow : Class
	{
		// 选中Component修改时的Event
		public Event selectionChanged;

		// AddComponentWindow窗口关闭时的Event
		public Event windowClosed;

		public RAddComponentWindow(string name) : base(name)
		{
			selectionChanged = new Event(this, "selectionChanged");
			windowClosed = new Event(this, "windowClosed");
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