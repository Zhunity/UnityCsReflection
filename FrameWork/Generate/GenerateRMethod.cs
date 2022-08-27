using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
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
                if (parameters[i].ParameterType.IsNotPublic)
                {
                    return string.Empty;
                }
                declareStr += parameters[i].ParameterType.FullName + " " + parameters[i].Name;
                paramStr += parameters[i].Name;
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
                paramStr += "_" + parameter.ParameterType.Name;
            }
            return paramStr;
        }
    }
}