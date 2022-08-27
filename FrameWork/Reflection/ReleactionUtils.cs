using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using System.ComponentModel;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// 通用的有返回值类型的委托
	/// </summary>
	/// <param name="obj"></param>
	/// <returns></returns>
	public delegate object UniversalFunc(params object[] obj);

	/// <summary>
	/// 通用的无返回值类型的委托
	/// 不过感觉反射一般用上面那个就好了
	/// </summary>
	/// <param name="obj"></param>
	public delegate void UniversalAction(params object[] obj);

	public static class ReleactionUtils
	{
		static private Dictionary<string, Type> _typeCache = new Dictionary<string, Type>();

		/// <summary>
		/// 获取类型
		/// </summary>
		/// <param name="typeName"></param>
		/// <returns></returns>
		public static Type GetType(string typeName)
		{
			Type type = null;
			if (_typeCache.TryGetValue(typeName, out type))
			{
				return type;
			}


			Assembly[] assemblyArray = AppDomain.CurrentDomain.GetAssemblies();
			int assemblyArrayLength = assemblyArray.Length;
			for (int i = 0; i < assemblyArrayLength; ++i)
			{
				type = assemblyArray[i].GetType(typeName);
				if (type != null)
				{
					_typeCache.Add(typeName, type);
					return type;
				}
			}

			for (int i = 0; (i < assemblyArrayLength); ++i)
			{
				Type[] typeArray = assemblyArray[i].GetTypes();
				int typeArrayLength = typeArray.Length;
				for (int j = 0; j < typeArrayLength; ++j)
				{
					if (typeArray[j].Name.Equals(typeName))
					{
						_typeCache.Add(typeName, typeArray[j]);
						return typeArray[j];
					}
				}
			}
			return type;
		}

		/// <summary>
		/// 将一个对象转换为指定类型
		/// https://q.cnblogs.com/q/53404/
		/// </summary>
		/// <param name="obj">待转换的对象</param>
		/// <param name="type">目标类型</param>
		/// <returns>转换后的对象</returns>
		public static object ConvertObject(object obj, Type type)
		{
			if (type == null) return obj;
			if (obj == null) return type.IsValueType ? Activator.CreateInstance(type) : null;

			Type underlyingType = Nullable.GetUnderlyingType(type);
			if (type.IsAssignableFrom(obj.GetType())) // 如果待转换对象的类型与目标类型兼容，则无需转换
			{
				return obj;
			}
			else if ((underlyingType ?? type).IsEnum) // 如果待转换的对象的基类型为枚举
			{
				if (underlyingType != null && string.IsNullOrEmpty(obj.ToString())) // 如果目标类型为可空枚举，并且待转换对象为null 则直接返回null值
				{
					return null;
				}
				else
				{
					return Enum.Parse(underlyingType ?? type, obj.ToString());
				}
			}
			else if (typeof(IConvertible).IsAssignableFrom(underlyingType ?? type)) // 如果目标类型的基类型实现了IConvertible，则直接转换
			{
				try
				{
					return Convert.ChangeType(obj, underlyingType ?? type, null);
				}
				catch
				{
					return underlyingType == null ? Activator.CreateInstance(type) : null;
				}
			}
			else
			{
				TypeConverter converter = TypeDescriptor.GetConverter(type);
				if (converter.CanConvertFrom(obj.GetType()))
				{
					return converter.ConvertFrom(obj);
				}
				ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
				if (constructor != null)
				{
					object o = constructor.Invoke(null);
					PropertyInfo[] propertys = type.GetProperties();
					Type oldType = obj.GetType();
					foreach (PropertyInfo property in propertys)
					{
						PropertyInfo p = oldType.GetProperty(property.Name);
						if (property.CanWrite && p != null && p.CanRead)
						{
							property.SetValue(o, ConvertObject(p.GetValue(obj, null), property.PropertyType), null);
						}
					}
					return o;
				}
			}
			return obj;
		}
	}
}