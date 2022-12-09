using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;
using Object = System.Object;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// 一个对象里面的成员
	/// 如果一种类型既有在Property成员，也有Field类型，建议使用Member
	/// 继承Class是因为，一种类型，既可能是单独定义出来的，也可能是别的类型中的一个成员，适配这种情况
	/// </summary>
	public class RMember : RType
	{
		public MemberInfo memberInfo;   // 反射出来的信息
		public Type belongType;         // 在哪个类里面反射出来的成员
		public Object belong;           // 所属的实例对象

		#region 初始化类型数据
		/// <summary>
		/// 由于可能需要单独成为一个类型，而不是作为成员，所以需要实现类型的定义的构造函数
		/// </summary>
		/// <param name="type"></param>
		public RMember(string type, int genericCount = -1, params Type[] types) : base(type, genericCount, types)
		{
		}

		/// <summary>
		/// 这个是定义类型用的，同上
		/// </summary>
		/// <param name="type"></param>
		public RMember(Type type, int genericCount = -1, params Type[] types) : base(type, genericCount, types)
		{
		}

		/// <summary>
		/// 这个是递归引用时用的
		/// 即在一个Class（or RMember）中，需要添加成员变量，调用这个接口，完成成员的绑定
		/// </summary>
		/// <param name="belongMember"></param>
		/// <param name="name"></param>
		public RMember(RType belongMember, string name, int genericCount = -1, params Type[] types) : this(belongMember?.type, name, genericCount, types)
		{
			belongMember.AddMember(this as RMember);
		}

		/// <summary>
		/// 这个是根节点用的
		///  只用一个类型内的某个参数，不需要定义一个类型
		///  即不想定义一个成员的所属实例，只想单独拿目标实例中的一个成员时用的
		/// </summary>
		/// <param name="belongType"></param>
		/// <param name="name"></param>
		public RMember(Type belongType, string name, int genericCount = -1, params Type[] types)
		{
			this.genericCount = genericCount;
			this.types = types;
			SetInfo(belongType, name);
			SetBelongType(belongType);
			SetName(name);
			SetType();
		}

		/// <summary>
		/// 设置变量成员信息
		/// </summary>
		/// <param name="belongType"></param>
		/// <param name="name"></param>
		/// <returns></returns>
		protected virtual void SetInfo(Type belongType, string name)
		{
			memberInfo = belongType.GetMember(name, flags).First();
		}

		/// <summary>
		/// 设置变量名
		/// 操作简单，目测不用重写
		/// </summary>
		/// <param name="name"></param>
		protected void SetName(string name)
		{
			this.name = name;
		}

		/// <summary>
		/// 设置所属对象类型
		/// </summary>
		/// <param name="belongType"></param>
		protected void SetBelongType(Type belongType)
		{
			this.belongType = belongType;
		}

		/// <summary>
		/// 设置成员类型
		/// </summary>
		protected virtual void SetType()
		{
			if(memberInfo == null)
			{
				return;
			}
			if (memberInfo.MemberType == MemberTypes.Property)
			{
				PropertyInfo info = memberInfo as PropertyInfo;
				type = info.PropertyType;
			}
			else if (memberInfo.MemberType == MemberTypes.Field)
			{
				FieldInfo info = memberInfo as FieldInfo;
				type = info.FieldType;
			}
		}
		#endregion

		#region 设置持有该成员的对象
		/// <summary>
		/// 设置持有该成员的对象
		/// </summary>
		/// <param name="belong"></param>
		public void SetBelong(Object belong)
		{
			if (this.belong == belong)
			{
				return;
			}
			this.belong = belong;
			if (memberList != null && memberList.Count > 0)
			{
				foreach (var member in memberList)
				{
					member.SetBelong(this);
				}
			}
			OnSetBelong();
		}

		public void SetBelong(RMember belong)
		{
			var obj = belong?.GetValue();
			SetBelong(obj);
		}

		protected virtual void OnSetBelong()
		{

		}
		#endregion

		/// <summary>
		/// 修改某个成员的值
		/// </summary>
		/// <param name="value"></param>
		public override void SetValue(object value)
		{
			// 兼容Class
			if (memberInfo == null)
			{
				base.SetValue(value);
			}

			// 兼容Property， RField
			if (memberInfo.MemberType == MemberTypes.Property)
			{
				// TODO 可能索引器需要注意
				PropertyInfo info = memberInfo as PropertyInfo;
				info.SetValue(belong, value);
			}
			else if (memberInfo.MemberType == MemberTypes.Field)
			{
				FieldInfo info = memberInfo as FieldInfo;
				info.SetValue(belong, value);
			}
		}

		/// <summary>
		/// 获取该成员变量的值
		/// </summary>
		/// <returns></returns>
		public override Object GetValue()
		{
			// 兼容Class
			if (memberInfo == null)
			{
				return instance;
			}

			// 兼容Property， RField
			if (memberInfo.MemberType == MemberTypes.Property)
			{
				PropertyInfo info = memberInfo as PropertyInfo;
				return RProperty.GetPropertyValue(info, belong);
			}
			else if (memberInfo.MemberType == MemberTypes.Field)
			{
				FieldInfo info = memberInfo as FieldInfo;
				return RField.GetFieldValue(info, belong);
			}
			return null;
		}
	}
}