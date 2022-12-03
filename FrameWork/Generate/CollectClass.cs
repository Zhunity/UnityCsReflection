using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Reflection;
using System.IO;
using System.Text.RegularExpressions;

namespace SMFrame.Editor.Refleaction
{

	public partial class GenerateRClass
	{
		private static HashSet<Type> CollectClass(Type classType)
		{
			HashSet<Type> refs = new HashSet<Type>();
			var properties = classType.GetProperties(Class.flags);
			foreach(var property in properties)
			{
				property.PropertyType.GetRefType(ref refs);
			}

			var fields = classType.GetFields(Class.flags);
			foreach (var field in fields)
			{
				field.FieldType.GetRefType(ref refs);
			}

			HashSet<Type> methodTypes = new HashSet<Type>();
			var methods = classType.GetMethods(Class.flags);
			foreach (var method in methods)
			{
				method.ReturnType.GetRefType(ref methodTypes);
				var parameters = method.GetParameters();
				foreach (var param in parameters)
				{
					param.ParameterType.GetRefType(ref methodTypes);
				}
			}

			HashSet<Type> types = new HashSet<Type>();
			foreach (var type in refs)
			{
				types.Add(type.ToBasicType());
			}

			// 函数只用生成非共有的类
			foreach(var type in methodTypes)
			{
				var basicType = type.ToBasicType();
				if(basicType == null || basicType.IsPublic)
				{
					continue;
				}
				types.Add(basicType);
			}
			return types;
		}
    }
}
