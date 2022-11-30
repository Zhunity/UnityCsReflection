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

			var methods = classType.GetMethods(Class.flags);
			foreach (var method in methods)
			{
				method.ReturnType.GetRefType(ref refs);
				var parameters = method.GetParameters();
				foreach (var param in parameters)
				{
					param.ParameterType.GetRefType(ref refs);
				}
			}

			HashSet<Type> types = new HashSet<Type>();
			foreach (var type in refs)
			{
				types.Add(type.ToBasicType());
			}
			return types;
		}
    }
}
