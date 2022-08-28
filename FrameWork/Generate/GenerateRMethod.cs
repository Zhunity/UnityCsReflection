using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Reflection;
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

            var generics = method.GetGenericArguments();
            var parameters = method.GetParameters();

            var noteStr = method.ReturnType.Name + " " + method.Name;
            if (generics.Length > 0)
            {
                noteStr += "<";
                for (int i = 0; i < generics.Length; i++)
                {
                    noteStr += generics[i].Name;
                    if (i < generics.Length - 1)
                    {
                        noteStr += ", ";
                    }
                }
                noteStr += ">";
            }

            noteStr += "(";
            for (int i = 0; i < parameters.Length; i++)
            {
                noteStr += parameters[i].ParameterType.Name + " " + parameters[i].Name;
                if (i < parameters.Length - 1)
                {
                    noteStr += ", ";
                }
            }
            noteStr += ")";
            return GenerateDeclare("Method", name, noteStr);
        }

        private static string GenerateMethodNew(MethodInfo method)
        {
            string name = GetMethodName(method);

            var generics = method.GetGenericArguments();
            var parameters = method.GetParameters();
            var paramStr = string.Empty;
            for (int i = 0; i < parameters.Length; i++)
            {
                paramStr += $", ReleactionUtils.GetType(\"{parameters[i].ParameterType.FullName}\")";
            }

            return $"\t\t\t{name} = new Method(this, \"{method.Name}\", {generics.Length}{paramStr});\n";
        }

        private static string GenerateMethodInvoke(MethodInfo method)
        {
            string name = GetMethodName(method);

            string declareStr = $"public object {method.Name}";
            var parameters = method.GetParameters();

            var paramStr = string.Empty;
            var generics = method.GetGenericArguments();
            if (generics.Length > 0)
            {
                declareStr += "<";
                paramStr = "new Type[] { ";
                for (int i = 0; i < generics.Length; i++)
                {
                    declareStr += generics[i].Name;
                    paramStr += $"typeof({generics[i].Name})";
                    if (i < generics.Length - 1)
                    {
                        declareStr += ", ";
                        paramStr += ", ";
                    }
                }
                declareStr += ">";
                paramStr += " }";

                if (parameters.Length > 0)
                {
                    paramStr += ", ";
                }
            }


            declareStr += "(";
            for (int i = 0; i < parameters.Length; i++)
            {
                var param = parameters[i];
                var paramType = param.ParameterType;
                if (paramType.IsNotPublic)
                {
                    return string.Empty;
                }
                var paramTypeStr = string.IsNullOrEmpty(paramType.FullName) ? paramType.Name : paramType.FullName;
                declareStr += paramTypeStr + " " + param.Name;
                paramStr += param.Name;
                if (i < parameters.Length - 1)
                {
                    declareStr += ", ";
                    paramStr += ", ";
                }
            }
            declareStr += ")";

            var result = $@"
        {declareStr}
        {{
            return {name}.Invoke({paramStr});
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

                var name = GenerateParameterType(parameter.ParameterType);

                bool isRef = name.IndexOf('&') > 0;
                if (!isRef)
                {
                    paramStr += "_" + name;
                    continue;
                }

                name = name.Replace("&", "");
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

        static private string GenerateParameterType(Type parameterType)
        {
            string name = String.Empty;
            if(parameterType.IsArray)
            {
                var curElementType = parameterType;
                var elementType = parameterType.GetElementType();
                int rank = 0;
                while (elementType != null)
                {
                    curElementType = elementType;
                    elementType = elementType.GetElementType();
                    rank++;
                }

                name = GenerateParameterType(curElementType);
                for(int i = 0; i < rank; i ++)
                {
                    name += "Array";
                }
            }
            else if(parameterType.IsGenericType)
            {
                // https://docs.microsoft.com/zh-cn/dotnet/framework/reflection-and-codedom/how-to-examine-and-instantiate-generic-types-with-reflection
                var genericTypes = parameterType.GetGenericArguments();
                var genericDefine = parameterType.GetGenericTypeDefinition();
                string genericParamStr = string.Empty;
                foreach (var genericType in genericTypes)
                {
                    var paramName = GenerateParameterType(genericType);
                    genericParamStr += paramName;
                }
                Regex regex = new Regex(@"`\d+");
                var a = Regex.Replace(genericDefine.Name, @"`\d+", $"_d_{genericParamStr}_p_");
                name += a;
            }
            else
            {
                name = parameterType.Name;
            }
            

            return name;
        }
    }
}