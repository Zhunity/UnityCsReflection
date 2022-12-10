using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;

namespace SMFrame.Editor.Refleaction
{
    public class GProperty : GMember
    {
        PropertyInfo property;

        public GProperty(PropertyInfo property)
        {
            this.property = property;
            isStatic = property.IsStatic();
        }

		public override void GetRefTypes(HashSet<Type> refTypes)
		{
			property.PropertyType.GetRefType(ref refTypes);
		}

		public override void GetDeclareStr(StringBuilder sb)
		{
			string fieldType = GetPropertyType(property.PropertyType); 
			string name = GetPropertyName(property);
			var declareStr = GetDeclareStr(fieldType, name, property.Name, property.ToString());
			sb.AppendLine(declareStr);
		}

		static private string GetPropertyName(PropertyInfo property)
		{
			var method = property.GetMethod == null ? property.SetMethod : property.GetMethod;
			string paramStr = GMethod.GetMethodName(method);
			paramStr = paramStr.Replace("Rget_", "").Replace("Rset_", "");
			return paramStr;
		}

		protected override string GetNewParamStr()
		{
			var method = property.GetMethod == null ? property.SetMethod : property.GetMethod;
			var parameters = method.GetParameters();
			var paramStr = string.Empty;
			for (int i = 0; i < parameters.Length; i++)
			{
				paramStr += $", {parameters[i].ParameterType.ToGetMethod()}";
			}
			return ", -1" + paramStr;
		}

		private string GetPropertyType(Type type)
		{
			if (type.IsArray)
			{
				return $"RPropertyArray<{GetPropertyType(type.GetElementType())}>";
			}
			else if (type.IsPointer)
			{
				return $"RPropertyPointer<{GetPropertyType(type.GetElementType())}>";
			}
			else if (type.IsGenericType)
			{
				var genericTypes = type.GetGenericArguments();
				string gstr = String.Empty;
				for (int i = 0; i < genericTypes.Length; i++)
				{
					gstr += GetPropertyType(genericTypes[i]);
					if (i < genericTypes.Length - 1)
					{
						gstr += ", ";
					}
				}
				var genericDefine = type.GetGenericTypeDefinition();
				var declare = genericDefine.ToDeclareName(true);

				string nameSpace = GetNameSpace(declare);
				var result = Regex.Replace(nameSpace, @"<\,*>", $"<{gstr}>");
				return result;
			}
			else if(PrimitiveTypeConfig.IsPrimitive(type))
			{
				return "RProperty";
			}
			else
			{
				var declare = type.ToDeclareName(true);
				string nameSpace = GetNameSpace(declare);
				return nameSpace;
			}
		}

		private string GetNameSpace(string declare)
		{
			if (string.IsNullOrEmpty(declare))
			{
				return string.Empty;
			}
			return $"SMFrame.Editor.Refleaction.R{declare.Replace(".", ".R")}";
		}
	}
}