using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace SMFrame.Editor.Refleaction
{
    public class GMember
    {
		public GType gType;

		protected bool isStatic = false;

		public virtual void GetRefTypes(HashSet<Type> refTypes) { }

		public virtual void GetDeclareStr(StringBuilder sb) { }

		protected virtual string GetNewParamStr()
		{
			return string.Empty;
		}

		protected string GetDeclareStr(string type, string name, string note)
		{
			string staticFieldStr = isStatic ? "static " : string.Empty;
			string statiPropertyStr = isStatic ? "static " : "virtual ";
			string belong = isStatic ? gType.type.ToGetMethod() : "this";
			string setBelong = isStatic ? "null" : "this.instance";
			name = LegalNameConfig.LegalName(name);
			string protectedName = "r_" + name;
			string paramStr = GetNewParamStr();
			string result = @$"
		/// <summary>
		/// {note}
		/// </summary>
		protected {staticFieldStr}{type} {protectedName};
		public {statiPropertyStr}{type} {name}
		{{
			get
			{{
				if({protectedName} == null)
				{{
					{protectedName} = new {type}({belong}, ""{name}""{paramStr});
					{protectedName}.SetBelong({setBelong});
				}}
				return {protectedName};
			}}
		}}";
			return result;
		}
	}
}
