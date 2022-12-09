using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Rendering;

namespace SMFrame.Editor.Refleaction
{
    public class GType
    {
        List<GField> fields = new List<GField> ();
        List<GProperty> properties = new List<GProperty> ();
        List<GEvent> events = new List<GEvent> ();
        List<GMethod> methods = new List<GMethod> ();

		List<GMember> members = new List<GMember>();

		HashSet<Type> refs = new HashSet<Type>();

		Type type;

        public GType(Type type)
        {
            this.type = type;
			var fields = type.GetFields(RType.flags);
			foreach (var field in fields)
			{
                GField gField = new(field);
                this.fields.Add(gField);
			}

			var properties = type.GetProperties(RType.flags);
			foreach (var property in properties)
			{
				GProperty gProperty = new(property);
				this.properties.Add(gProperty);
			}

			var events = type.GetEvents(RType.flags);
			foreach (var @event in events)
			{
				GEvent gEvent = new(@event);
				this.events.Add(gEvent);
			}

			var methods = type.GetMethods(RType.flags);
			foreach (var metod in methods)
			{
				GMethod gMethod = new(metod);
				this.methods.Add(gMethod);
			}

			members.AddRange(this.fields);
			members.AddRange(this.properties);
			members.AddRange(this.events);
			members.AddRange(this.methods);
		}

		public override string ToString()
		{
			string nameSpaceStr = GetNameSpace();
			string delcareStr = "";
			string methodInvoke = "";


			return $@"{nameSpaceStr}using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R{type.Namespace.Replace(".", ".R")}
{{
    public partial class R{type.ToClassName()} : RMember
    {{
{delcareStr}

        public R{type.ToConstructorName()}() : base(""{type.FullName}"")
        {{
        }}

        public R{type.ToConstructorName()}(System.Object instance) : base(""{type.FullName}"")
		{{
            SetInstance(instance);
		}}

        public R{type.ToConstructorName()}(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {{
	    }}
{methodInvoke}
    }}
}}
";
		}

		public HashSet<Type> GetRefTypes()
		{
			if(refs != null || refs.Count > 0)
			{
				return refs;
			}
			
			foreach(var field in fields)
			{
				field.GetRefTypes(refs);
			}

			foreach(var property in properties)
			{
				property.GetRefTypes(refs);
			}

			HashSet<Type> methodTypes = new HashSet<Type>();
			foreach(var method in methods)
			{
				method.GetRefTypes(refs);
			}

			HashSet<Type> types = new HashSet<Type>();
			foreach (var type in refs)
			{
				types.Add(type.ToBasicType());
			}

			// 函数只用生成非共有的类
			foreach (var type in methodTypes)
			{
				var basicType = type.ToBasicType();
				if (basicType == null || basicType.IsPublic)
				{
					continue;
				}
				types.Add(basicType);
			}
			return types;
		}

		private string GetNameSpace()
		{
			var refTypes = GetRefTypes();
			if(refTypes == null || refTypes.Count <= 0)
			{
				return string.Empty;
			}
			HashSet<string> nameSpaces = new();
			foreach(var refType in refTypes)
			{
				if(string.IsNullOrEmpty(refType.Namespace) || GenerateInput.IsPrimitive(refType))
				{
					continue;
				}
				nameSpaces.Add(refType.Namespace);
			}

			StringBuilder sb = new StringBuilder();
			foreach(var nameSpace in nameSpaces)
			{
				sb.AppendLine($"using SMFrame.Editor.Refleaction.R{nameSpace.Replace(".", ".R")};");
			}
			return sb.ToString();
		}
	}
}