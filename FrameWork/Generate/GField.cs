using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;

namespace SMFrame.Editor.Refleaction
{
    public class GField : GMember
    {
        FieldInfo field;
        public GField(FieldInfo info)
        {
            field = info;
            isStatic = field.IsStatic;
		}

        public override void GetRefTypes(HashSet<Type> refTypes)
        {
			field.FieldType.GetRefType(ref refTypes);
		}

        public override void GetDeclareStr(StringBuilder sb)
        {
            string fieldType = GetFieldType(field.FieldType);
            var declareStr = GetDeclareStr(fieldType, field.Name, field.Name, field.ToString());
            sb.AppendLine(declareStr);
		}

        private string GetFieldType(Type type)
        {
			TypeTranslater typeTranslater = new TypeTranslater();
			typeTranslater.fullName = true;
			typeTranslater.Array.format = "RFieldArray<{0}>";
			typeTranslater.Pointer.format = "RFieldPointer<{0}>";
            typeTranslater.GenericTypeDefinition.fun = (strs) =>
            {
				var genericDefine = strs[0];
				string genericParamStr = string.Empty;
				for (int i = 1; i < strs.Length; i++)
				{
					var paramName = strs[i];
					genericParamStr += paramName;
					if (i != strs.Length - 1)
					{
						genericParamStr += ", ";
					}
				}
				var defineName = Regex.Replace(genericDefine, @"`\d+", $"<{genericParamStr}>");
				return defineName;
			};
            typeTranslater.GenericType.fun = (strs) =>
            {
				var genericDefine = strs[1];
				string genericParamStr = string.Empty;
				for (int i = 2; i < strs.Length; i++)
				{
					var paramName = strs[i];
					genericParamStr += paramName;
					if (i != strs.Length - 1)
					{
						genericParamStr += ", ";
					}
				}
				var defineName = Regex.Replace(genericDefine, @"`\d+", $"<{genericParamStr}>");
				return defineName;
			};
            typeTranslater.GenericParameter.format = "RField";
            typeTranslater.translate = Translater;

			


			var declare = type.ToString(typeTranslater);
			string nameSpace = GetNameSpace(declare);
			return nameSpace;
		}

        private bool Translater(Type t, TypeTranslater translater, out string result)
        {
			if (PrimitiveTypeConfig.IsPrimitive(t))
			{
                result = "RField";
				return true;
			}
            result = String.Empty;
            return false;
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