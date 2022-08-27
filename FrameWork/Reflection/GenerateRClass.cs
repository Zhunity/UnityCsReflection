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
            GenerateInternal(classType);
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

        public static void GenerateInternal(Type classType)
        {
            var properties = classType.GetProperties();
            var nameSpaceStr = string.Empty;
            var delcareStr = string.Empty;
            var newStr = string.Empty;
            HashSet<string> nameSpaceCache = new HashSet<string>();
            foreach (var property in properties)
            {
                nameSpaceStr += GenerateMemberNameSpace(property.PropertyType, nameSpaceCache);
                delcareStr += GenerateMemberDeclare(property.PropertyType, property.Name, "Property");
                newStr += GenerateMemberNew(property.PropertyType, property.Name, "Property");
            }

            var fields = classType.GetFields();
            foreach (var field in fields)
            {
                nameSpaceStr += GenerateMemberNameSpace(field.FieldType, nameSpaceCache);
                delcareStr += GenerateMemberDeclare(field.FieldType, field.Name, "Field");
                newStr += GenerateMemberNew(field.FieldType, field.Name, "Field");
            }

            Debug.Log(nameSpaceStr);
            Debug.Log(delcareStr);
            Debug.Log(newStr);

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

        private static string GenerateMemberNameSpace(Type type, HashSet<string> nameSpaceCache)
        {
            var nameSpace = type.Namespace;
            if (IsPrimitive(type) || string.IsNullOrEmpty(nameSpace) || nameSpaceCache.Contains(nameSpace))
            {
                return string.Empty;
            }
            nameSpaceCache.Add(nameSpace);
            return $"using SMFrame.Editor.Refleaction.{nameSpace};\n";
        }

        private static string GenerateMemberDeclare(Type type, string name, string memberType)
        {
            string propertyType = IsPrimitive(type) ? memberType : "R" + type.Name;
            return $"\t\tpublic {propertyType} {name}; //{type.FullName}\n";
        }

        private static string GenerateMemberNew(Type type, string name, string memberType)
        {
            string propertyType = IsPrimitive(type) ? memberType : "R" + type.Name;
            //m_PackageItemsLookup = new Field(this, "m_PackageItemsLookup");
            return $"\t\t\t{name} = new {propertyType}(this, \"{name}\");\n";
        }


        private static void GenerateType(Type type)
        {
            if(IsPrimitive(type) || _cacheType.Contains(type))
            {
                return;
            }
            _cacheType.Add(type);
            Generate(type);
        }

        static HashSet<Type> PrimitiveType = new HashSet<Type>()
        {
            typeof(string),
        };

        private static bool IsPrimitive(Type type)
        {
            return PrimitiveType.Contains(type) || // 字符串
                type.IsEnum || type.IsPrimitive; // int float等值类型
        }
        #endregion
    }
}
