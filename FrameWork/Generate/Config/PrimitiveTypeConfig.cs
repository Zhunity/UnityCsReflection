using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SMFrame.Editor.Refleaction
{
    public class PrimitiveTypeConfig
    {
		static HashSet<Type> PrimitiveType = new HashSet<Type>()
		{
			typeof(string),
			typeof(void),
		};

		/// <summary>
		/// 判断是否是原始类型
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public static bool IsPrimitive(Type type)
		{
			return type == null ||
				PrimitiveType.Contains(type) ||
				type.IsGenericParameter ||
				type.IsEnum || type.IsPrimitive; // int float等值类型
		}
	}
}