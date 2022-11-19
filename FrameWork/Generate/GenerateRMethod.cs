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
                methodInvoke += GenerateMethodInvoke(method);
            }

            return methodInvoke;
        }

        private static string GenerateMethodDeclare(MethodInfo method)
        {
            string name = GetMethodName(method);

			return $@"
        // {method.ToString()}
        public Method _{name.ToLower()};
        public virtual Method {name}
        {{
            get
            {{
                if(_{name.ToLower()} == null)
                {{
                    _{name.ToLower()} = {GenerateMethodNew(method)};
                }}
                return _{name.ToLower()};
            }}
        }}
";
        }

        private static string GenerateMethodNew(MethodInfo method)
        {
            var generics = method.GetGenericArguments();
            var parameters = method.GetParameters();
            var paramStr = string.Empty;
            for (int i = 0; i < parameters.Length; i++)
            {
                paramStr += $", {parameters[i].ParameterType.ToGetMethod()}";
            }

            return $"new Method(this, \"{method.Name}\", {generics.Length}{paramStr})";
        }

        private static string GenerateMethodInvoke(MethodInfo method)
        {
            string name = GetMethodName(method);

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
						outAssignStr += $"\t\t\t{param.Name} = ({paramType.ToDeclareName()})parameters[{param.Position}];\n";
					}
					else if (param.IsIn)
					{
						str += "in ";
					}
					else
					{
						str += "ref ";
						outAssignStr += $"\t\t\t{param.Name} = ({paramType.ToDeclareName()})parameters[{param.Position}];\n";
					}
				}

				str += paramType.ToDeclareName() + " " + param.Name;
                paramDeclareStr += str;
                paramStr += param.Name;
                if (i < parameters.Length - 1)
                {
					paramDeclareStr += ", ";
                    paramStr += ", ";
                }
            }
			#endregion

			#region 处理返回值
			bool hasReturn = method.ReturnType != typeof(void);
			#endregion

			var result = $@"
        public virtual {(hasReturn ? method.ReturnType.ToDeclareName() : "void")} {method.Name}{genericArgsDelcareStr}({paramDeclareStr})
        {{
{outDefaultStr}
            var genericsType = new Type[] {{{genricArgsStr}}};
            var parameters = new object[]{{{paramStr}}};
            var result = {name}.Invoke(genericsType, parameters);
{outAssignStr}
            {(hasReturn ? "return (" + method.ReturnType.ToDeclareName() + ")result;" : "")}
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