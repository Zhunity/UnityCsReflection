using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using UnityEngine;

namespace SMFrame.Editor.Refleaction
{
    public class GEvent : GMember
    {
        EventInfo @event;

        public GEvent(EventInfo @event)
        {
            this.@event = @event;
            isStatic = @event.IsStatic();
        }

		public override void GetRefTypes(HashSet<Type> refTypes)
		{
		}

		public override string GetDeclareName()
		{
			return @event.Name;
		}

		public override void GetDeclareStr(StringBuilder sb)
        {
			string fieldType = "REvent";
			var declareStr = GetDeclareStr(fieldType, @event.Name, @event.ToString());
			sb.AppendLine(declareStr);
		}
    }
}