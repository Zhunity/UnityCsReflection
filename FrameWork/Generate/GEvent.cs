using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace SMFrame.Editor.Refleaction
{
    public class GEvent : GMember
    {
        EventInfo @event;

        public GEvent(EventInfo @event)
        {
            this.@event = @event;
        }

		public void GetRefTypes(HashSet<Type> refTypes)
		{
		}
	}
}