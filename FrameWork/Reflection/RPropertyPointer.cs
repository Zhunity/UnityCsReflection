using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SMFrame.Editor.Refleaction
{
	public class RPropertyPointer<T> : RProperty
	{
		public RPropertyPointer(RType belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
		{
		}

		public RPropertyPointer(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
		{
		}
	}
}