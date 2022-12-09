using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SMFrame.Editor.Refleaction
{
    public interface GMember
    {
		void GetRefTypes(HashSet<Type> refTypes);
	}
}
