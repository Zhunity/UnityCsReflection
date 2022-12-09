using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEditor.PackageManager;
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

		public Type type;

        public GType(Type type)
        {
            this.type = type;
			var fields = type.GetFields(RType.flags);
			foreach (var field in fields)
			{
                GField gField = new(field);
                this.fields.Add(gField);
			}

			HashSet<MethodInfo> getSetHash = new HashSet<MethodInfo>();
			var properties = type.GetProperties(RType.flags);
			foreach (var property in properties)
			{
				getSetHash.Add(property.GetMethod);
				getSetHash.Add(property.SetMethod);
				GProperty gProperty = new(property);
				this.properties.Add(gProperty);
			}

			var events = type.GetEvents(RType.flags);
			foreach (var @event in events)
			{
				getSetHash.Add(@event.AddMethod);
				getSetHash.Add(@event.RemoveMethod);
				GEvent gEvent = new(@event);
				this.events.Add(gEvent);
			}

			var methods = type.GetMethods(RType.flags);
			foreach (var method in methods)
			{
				if (getSetHash.Contains(method))
				{
					continue;
				}
				GMethod gMethod = new(method);
				this.methods.Add(gMethod);
			}

			members.AddRange(this.fields);
			members.AddRange(this.properties);
			members.AddRange(this.events);
			members.AddRange(this.methods);

			foreach(var member in members)
			{
				member.gType = this;
			}
		}

		public override string ToString()
		{
			string nameSpaceStr = GetNameSpace();
			string delcareStr = GetMemberDeclareStr();
			string methodInvoke = GetMethodInvokeStr();


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

		 public R{type.ToConstructorName()}(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {{
	    }}
{methodInvoke}
    }}
}}
";
		}

		public HashSet<Type> GetRefTypes()
		{
			if(refs != null && refs.Count > 0)
			{
				return refs;
			}

			HashSet<Type> types = new HashSet<Type>();
			foreach(var member in members)
			{
				member.GetRefTypes(types);
			}

			foreach (var type in types)
			{
				refs.Add(type.ToBasicType());
			}
			return refs;
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
				if(refType == null || string.IsNullOrEmpty(refType.Namespace) || GenerateInput.IsPrimitive(refType))
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

		private string GetMemberDeclareStr()
		{
			StringBuilder sb = new StringBuilder();
			foreach(var member in members)
			{
				member.GetDeclareStr(sb);
			}
			return sb.ToString();
		}

		private string GetMethodInvokeStr()
		{
			StringBuilder sb = new StringBuilder();
			foreach (var method in methods)
			{
				sb.AppendLine(method.GenerateMethodInvoke());
			}
			return sb.ToString();
		}
	}
}