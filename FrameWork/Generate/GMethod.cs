using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using UnityEngine;

namespace SMFrame.Editor.Refleaction
{
    public class GMethod : GMember
    {
        MethodInfo method;

        public GMethod(MethodInfo method)
        {
            this.method = method;
			isStatic = method.IsStatic;
        }

		public override void GetRefTypes(HashSet<Type> refTypes)
		{
			method.ReturnType.GetRefType(ref refTypes);
			var parameters = method.GetParameters();
			foreach (var param in parameters)
			{
				param.ParameterType.GetRefType(ref refTypes);
			}
		}

		public override void GetDeclareStr(StringBuilder sb)
		{
			string name = GetMethodName(method);
			var declareStr = GetDeclareStr("RMethod", name, method.Name, method.ToString());
			sb.AppendLine(declareStr);
		}

		protected override string GetNewParamStr()
		{
			var generics = method.GetGenericArguments();
			var parameters = method.GetParameters();
			var paramStr = string.Empty;
			for (int i = 0; i < parameters.Length; i++)
			{
				paramStr += $", {parameters[i].ParameterType.ToGetMethod()}";
			}

			return $", {generics.Length}{paramStr}";
		}

		static private string GetMethodName(MethodInfo method)
		{
			var generics = method.GetGenericArguments();
			string paramStr = LegalNameConfig.LegalName(method.Name);
			foreach (var generic in generics)
			{
				paramStr += "_G" + generic.ToFieldName();
			}

			var parameters = method.GetParameters();
			foreach (var parameter in parameters)
			{
				Type parameterType = parameter.ParameterType;

				var name = parameterType.ToFieldName();

				bool isRef = parameterType.IsByRef;
				if (!isRef)
				{
					paramStr += "_" + name;
					continue;
				}
				if (parameter.IsOut)
				{
					paramStr += "_Out_" + name;
				}
				else if (parameter.IsIn)
				{
					paramStr += "_In_" + name;
				}
				else
				{
					paramStr += "_Ref_" + name;
				}
			}
			paramStr = "R" + paramStr;
			return paramStr;
		}
	}
}