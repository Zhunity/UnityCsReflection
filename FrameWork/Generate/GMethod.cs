using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace SMFrame.Editor.Refleaction
{
    public class GMethod : GMember
    {
        MethodInfo method;

        public GMethod(MethodInfo method)
        {
            this.method = method;
        }

		public void GetRefTypes(HashSet<Type> refTypes)
		{
			method.ReturnType.GetRefType(ref refTypes);
			var parameters = method.GetParameters();
			foreach (var param in parameters)
			{
				param.ParameterType.GetRefType(ref refTypes);
			}
		}
	}
}