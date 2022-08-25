using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using Object = System.Object;

namespace SMFrame.Editor.Refleaction
{
	public class Class
	{
		public string name;         // 名字（在member中相当于变量名）
		public Type type;           // 对象的实际类型


		protected Object instance;     // 这个对象的实例
		public Object Instance
		{
			get => instance;
			set
			{
                // 如果是同一个，无需继续操作
                if (instance == value)
                {
                    return;
                }

                instance = value;

                // 给反射成员设置所属对象
                if (memberList != null && memberList.Count > 0)
                {
                    foreach (var member in memberList)
                    {
                        member.SetBelong(instance);
                    }
                }

                OnSetInstance();
            }
		}

        public virtual Object Value
        {
            set
            {
                Instance = value;
            }
            get
            {
                return Instance;
            }
        }

        protected List<Member> memberList = new List<Member>();

		

		protected Class()
		{
			memberList.Clear();
		}

		/// <summary>
		/// 传进一个类型名字，创建该类型的反射类
		/// 毕竟主工程中可能拿不到该类型，只能通过传名字来完成操作
		/// </summary>
		/// <param name="type"></param>
		public Class(string type)
		{
			this.type = ReleactionUtils.GetType(type);
			name = type;
			memberList.Clear();
		}

		/// <summary>
		/// 直接传进类型，省去查找类型的过程
		/// </summary>
		/// <param name="type"></param>
		public Class(Type type)
		{
			this.type = type;
			name = type.FullName;
			memberList.Clear();
		}

		public virtual void SetValue(object value)
		{
			SetInstance(value);
		}

		public virtual Object GetValue()
		{
			return Instance;
		}

		/// <summary>
		/// 设置实例
		/// </summary>
		/// <param name="instance"></param>
		public void SetInstance(Object instance)
		{
			// 如果是同一个，无需继续操作
			if (this.Instance == instance)
			{
				return;
			}

			this.Instance = instance;

			// 给反射成员设置所属对象
			if (memberList != null && memberList.Count > 0)
			{
				foreach (var member in memberList)
				{
					member.SetBelong(instance);
				}
			}

			OnSetInstance();
		}

		/// <summary>
		/// 子类重写的函数，不建议直接重写SetInstance
		/// 反射类设置好实例之后
		/// </summary>
		protected virtual void OnSetInstance()
		{

		}

		/// <summary>
		/// 添加反射类成员
		/// </summary>
		/// <param name="belongMember"></param>
		public void AddMember(Member member)
		{
			memberList.Add(member);
		}

		/// <summary>
		/// 获取对象的模板参数
		/// </summary>
		/// <returns></returns>
		public Type[] GetGenericTypeArguments()
		{
			if (type.IsGenericType)
			{
				return type.GenericTypeArguments;
			}
			return null;
		}

		public object ConvertObject(Type type)
		{
			return ReleactionUtils.ConvertObject(Value, type);
		}

		public Member CreateMember(string name)
		{
			return new Member(this, name);
		}

		public Field CreateField(string name)
		{
			return new Field(this, name);
		}

		public Property CreateProperty(string name)
		{
			return new Property(this, name);
		}

		public Method CreateMethod(string name)
		{
			return new Method(this, name);
		}

		public Event CreateEvent(string name)
		{
			return new Event(this, name);
		}

		/// <summary>
		/// Name:变量名
		/// ReflectedType：当前变量所在的变量
		/// MemberType：Property, Field等类型
		/// DeclaringType：定义这个变量的类型位置
		/// </summary>
		public void ShowMembers()
		{
			var list = type.GetMembers(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
			foreach (var item in list)
			{
				Debug.Log("Name:\t\t" + item.Name + "\nReflectedType:\t" + item.ReflectedType + "\nMemberType:\t" + item.MemberType + "\nDeclaringType:\t" + item.DeclaringType);
			}
		}

		/// <summary>
		/// 显示内部成员的值
		/// </summary>
		public void ShowMembersValue(string desc = "")
		{
			Object instance = GetValue();
			if (instance == null)
			{
				return;
			}

			Debug.Log("");
			Debug.Log("----------------------------" + name + "  " + desc + " begin--------------------------------");
			var list = type.GetMembers(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
			foreach (var item in list)
			{
				if (item.MemberType == MemberTypes.Property)
				{
					PropertyInfo info = item as PropertyInfo;
					object value = Property.GetPropertyValue(info, instance);
					Debug.Log("Name:\t\t" + item.Name + "\nvalue:\t\t" + value + "\nReflectedType:\t" + item.ReflectedType + "\nMemberType:\t" + item.MemberType + "\nPropertyType:\t" + info.PropertyType + "\ndesc:\t\t" + desc);
				}
				else if (item.MemberType == MemberTypes.Field)
				{
					FieldInfo info = item as FieldInfo;
					object value = Field.GetFieldValue(info, instance);
					Debug.Log("Name:\t\t" + item.Name + "\nvalue:\t\t" + value + "\nReflectedType:\t" + item.ReflectedType + "\nMemberType:\t" + item.MemberType + "\nFieldType:\t" + info.FieldType + "\ndesc:\t\t" + desc);
				}
			}
			Debug.Log("----------------------------" + name + "  " + desc + " end--------------------------------");
			Debug.Log("");
		}
	}
}