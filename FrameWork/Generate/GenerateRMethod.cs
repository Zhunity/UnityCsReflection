using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Rendering;

namespace SMFrame.Editor.Refleaction
{
    public partial class GenerateRClass
    {
        private static string GenerateMethod(Type classType, HashSet<MethodInfo> getSetHash, ref string delcareStr,  ref string newStr)
        {
            string methodInvoke = string.Empty;
            var methods = classType.GetMethods(Class.flags);
            foreach (var method in methods)
            {
                if (getSetHash.Contains(method))
                {
                    continue;
                }
                delcareStr += GenerateMethodDeclare(method);
                newStr += GenerateMethodNew(method);
                methodInvoke += GenerateMethodInvoke(method);
            }

            return methodInvoke;
        }

        private static string GenerateMethodDeclare(MethodInfo method)
        {
            string name = GetMethodName(method);

            return GenerateDeclare("Method", name, method.ToString(), method.IsStatic);
        }

        private static string GenerateMethodNew(MethodInfo method)
        {
            string name = GetMethodName(method);

            var generics = method.GetGenericArguments();
            var parameters = method.GetParameters();
            var paramStr = string.Empty;
            for (int i = 0; i < parameters.Length; i++)
            {
                paramStr += $", {parameters[i].ParameterType.ToGetMethod()}";
            }

            return $"\t\t\t{name} = new Method(this, \"{method.Name}\", {generics.Length}{paramStr});\n";
        }

        private static string GenerateMethodInvoke(MethodInfo method)
        {
            string name = GetMethodName(method);
            bool isUnsafe = false;

			#region 处理泛型
			var genericArgsDelcareStr = string.Empty;
            var genricArgsStr = string.Empty;
            var generics = method.GetGenericArguments();
            if (generics.Length > 0)
            {
				genericArgsDelcareStr += "<";
                for (int i = 0; i < generics.Length; i++)
                {
					genericArgsDelcareStr += generics[i].Name;
					genricArgsStr += $"typeof({generics[i].Name})";
                    if (i < generics.Length - 1)
                    {
						genericArgsDelcareStr += ", ";
						genricArgsStr += ", ";
                    }
                }
				genericArgsDelcareStr += ">";
            }
			#endregion

			#region 处理参数
			var parameters = method.GetParameters();
			var paramStr = string.Empty;
			string paramDeclareStr = string.Empty;
            string outDefaultStr = string.Empty;
            string outAssignStr = string.Empty;

            for (int i = 0; i < parameters.Length; i++)
            {
                var param = parameters[i];
                var paramType = param.ParameterType;
                if (paramType.IsNotPublic)
                {
                    return string.Empty;
                }

                string str = string.Empty;
				if (paramType.IsByRef)
				{
					if (param.IsOut)
					{
						str += "out ";
                        outDefaultStr += $"\t\t\t{param.Name} = default;\n";
						outAssignStr += $"\t\t\t{param.Name} = ({paramType.ToDeclareName()})___parameters[{param.Position}];\n";
					}
					else if (param.IsIn)
					{
						str += "in ";
					}
					else
					{
						str += "ref ";
						outAssignStr += $"\t\t\t{param.Name} = ({paramType.ToDeclareName()})___parameters[{param.Position}];\n";
					}
				}
                if(paramType.IsPointer)
                {
                    isUnsafe = true;
                }

				str += paramType.ToDeclareName() + "  @" + param.Name;
                paramDeclareStr += str;
                paramStr += "@" + param.Name;
                if (i < parameters.Length - 1)
                {
					paramDeclareStr += ", ";
                    paramStr += ", ";
                }
            }
			#endregion

			#region 处理返回值
			bool hasReturn = method.ReturnType != typeof(void);
            if(method.ReturnType.IsPointer)
            {
                isUnsafe = true;
            }
			#endregion

			var result = $@"
        public {(isUnsafe ? "unsafe " : "")}{(method.IsStatic ? "static" : "virtual")} {method.ReturnType.ToDeclareName()} {method.Name}{genericArgsDelcareStr}({paramDeclareStr})
        {{
{outDefaultStr}
            var ___genericsType = new Type[] {{{genricArgsStr}}};
            var ___parameters = new object[]{{{paramStr}}};
            var ___result = {name}.Invoke(___genericsType, ___parameters);
{outAssignStr}
            {(hasReturn ? "return (" + method.ReturnType.ToDeclareName() + ")___result;" : "")}
        }}
";
            return result;
        }

        static private string GetMethodName(MethodInfo method)
        {
            var generics = method.GetGenericArguments();
            string paramStr = "R" + method.Name;
            foreach (var generic in generics)
            {
                paramStr += "_G" + generic.Name;
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
                else if(parameter.IsIn)
                {
                    paramStr += "_In_" + name;
                }
                else
                {
                    paramStr += "_Ref_" + name;
                }    
                
            }
            return paramStr;
        }
    }
}