using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using Object = System.Object;

namespace SMFrame.Editor.Refleaction
{
	public sealed class REvent : RMember
	{
		EventInfo eventInfo;

		public REvent(RType belongMember, string name) : base(belongMember, name)
		{
		}

		public REvent(Type belongType, string name) : base(belongType, name)
		{
		}

		public void AddEventHandler(Delegate handler)
		{
			if(belong == null && !eventInfo.GetAddMethod().IsStatic)
			{
				return;
			}
			eventInfo.AddEventHandler(belong, handler);
		}

		public void RemoveEventHandler(Delegate handler)
		{
			if (belong == null && !eventInfo.GetRemoveMethod().IsStatic)
			{
				return;
			}
			eventInfo.RemoveEventHandler(belong, handler);
		}

		protected override void SetInfo(Type belongType, string name)
		{
			eventInfo = belongType.GetEvent(name, flags);
		}

		protected override void SetType()
		{
			if (eventInfo == null)
			{
				Debug.LogError("can not find " + name);
				return;
			}
			type = eventInfo.EventHandlerType;
		}
	}
}