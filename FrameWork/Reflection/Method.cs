using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using Object = System.Object;

namespace SMFrame.Editor.Refleaction
{
	public sealed class Method : Member
	{
		MethodInfo methodInfo;
		int genericCount = -1;
		Type[] types;

		public Method(Class belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name)
		{
			this.genericCount = genericCount; 
            this.types = types;
        }

		public Method(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name)
		{
            this.genericCount = genericCount;
            this.types = types;
        }

		protected override void SetInfo(Type belongType, string name)
		{
			methodInfo = belongType.GetMethod(name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static, null, types, null);

        }

		/// <summary>
		/// 这个好像也没其他类型可以用了
		/// 反正也不需要继承，不管了，也用不上
		/// </summary>
		protected override void SetType()
		{
			type = methodInfo.ReturnType;
		}

		/// <summary>
		/// 创建回调
		/// </summary>
		/// <param name="delegateType"></param>
		/// <returns></returns>
		public Delegate CreateDelegate(Type delegateType)
		{
			if (belong == null && !methodInfo.IsStatic)
			{
				return null;
			}
			return methodInfo.CreateDelegate(delegateType, belong);
		}

		/// <summary>
		/// 函数执行
		/// </summary>
		/// <param name="parameters"></param>
		/// <returns></returns>
		public object Invoke(params object[] parameters)
		{
			if(belong == null && !methodInfo.IsStatic)
			{
				return null;
			}
			return methodInfo.Invoke(belong, parameters);
		}
	}
}