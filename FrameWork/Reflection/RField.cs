using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using Object = System.Object;

namespace SMFrame.Editor.Refleaction
{
	public class RField : RMember
	{
		FieldInfo fieldInfo;

		public RField(RType belongMember, string name, int genericCount = -1) : base(belongMember, name, genericCount)
		{
		}

		public RField(Type belongType, string name, int genericCount = -1) : base(belongType, name, genericCount)
		{
		}

		public static object GetFieldValue(FieldInfo info, object belong)
		{
			// 判断静态类型
			if (belong == null && !info.IsStatic)
			{
				return null;
			}

			return info.GetValue(belong);
		}

		public override void SetValue(object value)
		{
			if (belong == null && !fieldInfo.IsStatic)
			{
				return;
			}
			fieldInfo.SetValue(belong, value);
		}

		public override object GetValue()
		{
			return GetFieldValue(fieldInfo, belong);
		}

		protected override void SetInfo(Type belongType, string name)
		{
			fieldInfo = belongType.GetField(name, flags);
		}

		protected override void SetType()
		{
			if (fieldInfo == null)
			{
				Debug.LogError("can not find " + name);
				return;
			}
			type = fieldInfo.FieldType;
		}
	}
}