using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
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
			else
			{
				return (PrimitiveTypeConfig.IsPrimitive(type)) ? "RProperty" : "R" + type.ToDeclareName(false);

			}
		}
	}
}