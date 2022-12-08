using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using Object = System.Object;

namespace SMFrame.Editor.Refleaction
{
	public class RProperty : RMember
	{
		public PropertyInfo propertyInfo;

		public RProperty(RType belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
		{
		}

		public RProperty(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
		{
		}



		/// <summary>
		/// 设置PropertyInfo值的静态类，供Mermber、Property用
		/// </summary>
		public static object GetPropertyValue(PropertyInfo info, object belong)
		{
			// 判断静态类型
			if (belong == null && !info.GetMethod.IsStatic)
			{
				return null;
			}

			// 参数个数大于0，表示是索引器
			// 返回索引器的函数，供外面调用
			if (info.GetIndexParameters().Length > 0)
			{
				UniversalFunc indexer = (object[] param) =>
				{
					return info.GetValue(belong, param);
				};
				return indexer;
			}
			else
			{
				return info.GetValue(belong);
			}

		}

		public override void SetValue(object value)
		{
			if (belong == null && !propertyInfo.SetMethod.IsStatic)
			{
				return;
			}

			propertyInfo.SetValue(belong, value);
		}

		/// <summary>
		/// 数组会有问题
		/// 如RPackageItem.Item
		/// 类型是UnityEngine.UIElements.VisualElement Item [Int32]
		/// 修改方法：object value = info.GetValue(instance, new object[] { 0 });
		/// TODO 看看怎么判断是数组
		/// </summary>
		/// <returns></returns>
		public override object GetValue()
		{
			return GetPropertyValue(propertyInfo, belong);
		}

		/// <summary>
		/// 判断是不是索引器
		/// </summary>
		/// <returns></returns>
		public bool IsIndexer()
		{
			return propertyInfo.GetIndexParameters().Length > 0;
		}

		protected override void SetInfo(Type belongType, string name)
		{
			propertyInfo = belongType.GetProperty(name, RType.flags, null, null, types, null); ;
		}

		protected override void SetType()
		{
			if (propertyInfo == null)
			{
				Debug.LogError("can not find " + name);
				return;
			}
			type = propertyInfo.PropertyType;
		}
	}
}