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
            if (type.IsArray)
            {
                return $"RFieldArray<{GetFieldType(type.GetElementType())}>";
            }
            else if (type.IsPointer)
            {
                return $"RFieldPointer<{GetFieldType(type.GetElementType())}>";
            }
            else if (type.IsGenericType)
            {
                var genericTypes = type.GetGenericArguments();
                string gstr = String.Empty;
                for (int i = 0; i < genericTypes.Length; i++)
                {
                    gstr += GetFieldType(genericTypes[i]);
                    if (i < genericTypes.Length - 1)
                    {
                        gstr += ", ";
                    }
                }
                var genericDefine = type.GetGenericTypeDefinition();
                var declare = genericDefine.ToClassName(true);

                string nameSpace = GetNameSpace(declare);
                var result = Regex.Replace(nameSpace, @"<\,*>", $"<{gstr}>");
                return result;
            }
            else if (PrimitiveTypeConfig.IsPrimitive(type))
            {
                return "RField";
            }
            else
            {
				var declare = type.ToClassName(true);
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