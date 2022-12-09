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
            if(type.IsArray)
            {
                return $"RFieldArray<{GetFieldType(type.GetElementType())}>";
            }
            else if(type.IsGenericType)
            {
				var genericTypes = type.GetGenericArguments();
                string gstr = String.Empty;
                for(int i = 0; i < genericTypes.Length; i ++)
                {
					gstr += GetFieldType(genericTypes[i]);
                    if(i < genericTypes.Length - 1)
                    {
						gstr += ", ";
                    }
				}
				var genericDefine = type.GetGenericTypeDefinition();
				var result = Regex.Replace(genericDefine.Name, @"`\d+", $"<{gstr}>");
                return "R" + result;
			}
            else
            {
                return (PrimitiveTypeConfig.IsPrimitive(type)) ? "RField" : "R" + type.ToDeclareName(false);

			}
        }
    }
}