using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
    public class GenerateRClass
    {
        [MenuItem("Tools/fff")]
        static void G()
        {
            Generate<UnityEngine.UI.Text>();
        }

        public static void Generate(Type classType)
        {
            var properties = classType.GetProperties();
            foreach(var property in properties)
            {
                //GenerateMember(property);
            }
            var fields = classType.GetFields();
            foreach (var field in fields)
            {
                //GenerateMember(field);
            }

            var events = classType.GetEvents();
            foreach (var @event in events)
            {
                //Debug.Log(@event.Name + "  " + @event.MemberType + "  " + @event.DeclaringType);
            }

            var methods = classType.GetMethods();
            foreach (var method in methods)
            {
                //Debug.Log(method.Name + "  " + method.MemberType + "  " + method.DeclaringType);
            }
        }

        public static void Generate<T>()
        {
            Generate(typeof(T));
        }

        public static void Generate(string className)
        {
            Generate(ReleactionUtils.GetType(className));
        }

        public static void Generate(object instance)
        {
            Generate(instance.GetType());
        }


        #region 生成文件代码
        static HashSet<Type> _cacheType = new HashSet<Type>();

        private static string GeneratePropertyDeclare(PropertyInfo info)
        {
            Type type = info.PropertyType;
            if(type == typeof(string) || IsPrimitive(type))
            {
                Debug.Log("primitive " + info.Name + "  " + info.MemberType + "  " + type);
                return "Property ";
            }

            Debug.Log("not " + info.Name + "  " + info.MemberType + "  " + type);
            if(_cacheType.Contains(type))
            {
                return string.Empty;
            }
            _cacheType.Add(type);
            Generate(type);
            return string.Empty;
        }



        private static bool IsPrimitive(Type type)
        {
            return type.IsValueType && type.IsEnum && type.IsPrimitive;
        }
        #endregion
    }
}
