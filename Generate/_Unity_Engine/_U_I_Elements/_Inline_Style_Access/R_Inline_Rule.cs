
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
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet r_Fsheet;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet RFsheet
		{
			get
			{
				if(r_Fsheet == null)
				{
					r_Fsheet = new(this, "sheet");
					r_Fsheet.SetBelong(this.instance);
				}
				return r_Fsheet;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleRule rule
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RStyleRule r_Frule;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RStyleRule RFrule
		{
			get
			{
				if(r_Frule == null)
				{
					r_Frule = new(this, "rule");
					r_Frule.SetBelong(this.instance);
				}
				return r_Frule;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId[] propertyIds
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId> r_FpropertyIds;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId> RFpropertyIds
		{
			get
			{
				if(r_FpropertyIds == null)
				{
					r_FpropertyIds = new(this, "propertyIds");
					r_FpropertyIds.SetBelong(this.instance);
				}
				return r_FpropertyIds;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleProperty[] properties
		/// </summary>
		protected SMFrame.Editor.Refleaction.RPropertyArray<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RStyleProperty> r_Pproperties;
		public virtual SMFrame.Editor.Refleaction.RPropertyArray<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RStyleProperty> RPproperties
		{
			get
			{
				if(r_Pproperties == null)
				{
					r_Pproperties = new(this, "properties", -1);
					r_Pproperties.SetBelong(this.instance);
				}
				return r_Pproperties;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_MEquals_Object;
		public virtual RMethod RMEquals_Object
		{
			get
			{
				if(r_MEquals_Object == null)
				{
					r_MEquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_MEquals_Object.SetBelong(this.instance);
				}
				return r_MEquals_Object;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_MGetHashCode;
		public virtual RMethod RMGetHashCode
		{
			get
			{
				if(r_MGetHashCode == null)
				{
					r_MGetHashCode = new(this, "GetHashCode", 0);
					r_MGetHashCode.SetBelong(this.instance);
				}
				return r_MGetHashCode;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_MToString;
		public virtual RMethod RMToString
		{
			get
			{
				if(r_MToString == null)
				{
					r_MToString = new(this, "ToString", 0);
					r_MToString.SetBelong(this.instance);
				}
				return r_MToString;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_MFinalize;
		public virtual RMethod RMFinalize
		{
			get
			{
				if(r_MFinalize == null)
				{
					r_MFinalize = new(this, "Finalize", 0);
					r_MFinalize.SetBelong(this.instance);
				}
				return r_MFinalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_MGetType;
		public virtual RMethod RMGetType
		{
			get
			{
				if(r_MGetType == null)
				{
					r_MGetType = new(this, "GetType", 0);
					r_MGetType.SetBelong(this.instance);
				}
				return r_MGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MMemberwiseClone;
		public virtual RMethod RMMemberwiseClone
		{
			get
			{
				if(r_MMemberwiseClone == null)
				{
					r_MMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
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

        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
}