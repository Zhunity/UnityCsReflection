using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SMFrame.Editor.Refleaction
{
	public class RFieldPointer<T> : RField
	{
		public RFieldPointer(RType belongMember, string name, int genericCount = -1) : base(belongMember, name, genericCount)
		{
		}

		public RFieldPointer(Type belongType, string name, int genericCount = -1) : base(belongType, name, genericCount)
		{
		}
	}
}