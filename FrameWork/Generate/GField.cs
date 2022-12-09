using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
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
			string fieldType = (PrimitiveTypeConfig.IsPrimitive(field.FieldType)) ? "RField" : "R" + field.FieldType.ToDeclareName(false);
            var declareStr = GetDeclareStr(fieldType, field.Name, field.FieldType.ToString());
            sb.Append(declareStr);
		}
    }
}