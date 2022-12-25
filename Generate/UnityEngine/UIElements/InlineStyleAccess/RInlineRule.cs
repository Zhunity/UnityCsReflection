using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{public partial class RInlineStyleAccess
{
	
	/// <summary>
	/// UnityEngine.UIElements.InlineStyleAccess+InlineRule
	/// </summary>
    public partial class RInlineRule : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.StyleSheet sheet
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleSheet r_sheet;
		public virtual RUnityEngine.RUIElements.RStyleSheet Rsheet
		{
			get
			{
				if(r_sheet == null)
				{
					r_sheet = new(this, "sheet");
					r_sheet.SetBelong(this.instance);
				}
				return r_sheet;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleRule rule
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleRule r_rule;
		public virtual RUnityEngine.RUIElements.RStyleRule Rrule
		{
			get
			{
				if(r_rule == null)
				{
					r_rule = new(this, "rule");
					r_rule.SetBelong(this.instance);
				}
				return r_rule;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId[] propertyIds
		/// </summary>
		protected RFieldArray<RField> r_propertyIds;
		public virtual RFieldArray<RField> RpropertyIds
		{
			get
			{
				if(r_propertyIds == null)
				{
					r_propertyIds = new(this, "propertyIds");
					r_propertyIds.SetBelong(this.instance);
				}
				return r_propertyIds;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleProperty[] properties
		/// </summary>
		protected RPropertyArray<RUnityEngine.RUIElements.RStyleProperty> r_properties;
		public virtual RPropertyArray<RUnityEngine.RUIElements.RStyleProperty> Rproperties
		{
			get
			{
				if(r_properties == null)
				{
					r_properties = new(this, "properties", -1);
					r_properties.SetBelong(this.instance);
				}
				return r_properties;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
			}
		}


        public RInlineRule() : base("UnityEngine.UIElements.InlineStyleAccess+InlineRule")
        {
        }

        public RInlineRule(System.Object instance) : base("UnityEngine.UIElements.InlineStyleAccess+InlineRule")
		{
            SetInstance(instance);
		}

        public RInlineRule(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RInlineRule(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
}