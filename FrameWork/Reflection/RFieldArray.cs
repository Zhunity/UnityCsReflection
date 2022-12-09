using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SMFrame.Editor.Refleaction
{
    public class RFieldArray<T> : RField
    {
		public RFieldArray(RType belongMember, string name, int genericCount = -1) : base(belongMember, name, genericCount)
		{
		}

		public RFieldArray(Type belongType, string name, int genericCount = -1) : base(belongType, name, genericCount)
		{
		}
	}
}