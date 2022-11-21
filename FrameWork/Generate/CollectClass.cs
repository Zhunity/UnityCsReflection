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
			HashSet <Type> types = new HashSet<Type>();
			var properties = classType.GetProperties(Class.flags);
			foreach(var property in properties)
			{
				types.Add(property.PropertyType.ToBasicType());
			}

			var fields = classType.GetFields(Class.flags);
			foreach (var field in fields)
			{
				types.Add(field.FieldType.ToBasicType());
			}

			var methods = classType.GetMethods(Class.flags);
			foreach (var method in methods)
			{
				types.Add(method.ReturnType.ToBasicType());
				var parameters = method.GetParameters();
				foreach (var param in parameters)
				{
					types.Add(param.ParameterType.ToBasicType());
				}
			}

			return types;
		}
    }
}
