using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions
{
	/// <summary>
	/// System.Text.RegularExpressions.RegexPrefix
	/// </summary>
    public partial class RRegexPrefix : RMember //
    {

		/// <summary>
		/// System.Boolean <CaseInsensitive>k__BackingField
		/// </summary>
		protected RField r___1__CaseInsensitive__2__k__BackingField;
		public virtual RField R__1__CaseInsensitive__2__k__BackingField
		{
			get
			{
				if(r___1__CaseInsensitive__2__k__BackingField == null)
				{
					r___1__CaseInsensitive__2__k__BackingField = new(this, "<CaseInsensitive>k__BackingField");
					r___1__CaseInsensitive__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__CaseInsensitive__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexPrefix <Empty>k__BackingField
		/// </summary>
		protected static RSystem.RText.RRegularExpressions.RRegexPrefix r___1__Empty__2__k__BackingField;
		public static RSystem.RText.RRegularExpressions.RRegexPrefix R__1__Empty__2__k__BackingField
		{
			get
			{
				if(r___1__Empty__2__k__BackingField == null)
				{
					r___1__Empty__2__k__BackingField = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexPrefix"), "<Empty>k__BackingField");
					r___1__Empty__2__k__BackingField.SetBelong(null);
				}
				return r___1__Empty__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.String <Prefix>k__BackingField
		/// </summary>
		protected RField r___1__Prefix__2__k__BackingField;
		public virtual RField R__1__Prefix__2__k__BackingField
		{
			get
			{
				if(r___1__Prefix__2__k__BackingField == null)
				{
					r___1__Prefix__2__k__BackingField = new(this, "<Prefix>k__BackingField");
					r___1__Prefix__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__Prefix__2__k__BackingField;
			}
		}

		/// <summary>
		/// Boolean CaseInsensitive
		/// </summary>
		protected RProperty r_CaseInsensitive;
		public virtual RProperty RCaseInsensitive
		{
			get
			{
				if(r_CaseInsensitive == null)
				{
					r_CaseInsensitive = new(this, "CaseInsensitive", -1);
					r_CaseInsensitive.SetBelong(this.instance);
				}
				return r_CaseInsensitive;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexPrefix Empty
		/// </summary>
		protected static RSystem.RText.RRegularExpressions.RRegexPrefix r_Empty;
		public static RSystem.RText.RRegularExpressions.RRegexPrefix REmpty
		{
			get
			{
				if(r_Empty == null)
				{
					r_Empty = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexPrefix"), "Empty", -1);
					r_Empty.SetBelong(null);
				}
				return r_Empty;
			}
		}

		/// <summary>
		/// System.String Prefix
		/// </summary>
		protected RProperty r_Prefix;
		public virtual RProperty RPrefix
		{
			get
			{
				if(r_Prefix == null)
				{
					r_Prefix = new(this, "Prefix", -1);
					r_Prefix.SetBelong(this.instance);
				}
				return r_Prefix;
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


        public RRegexPrefix() : base("System.Text.RegularExpressions.RegexPrefix")
        {
        }

        public RRegexPrefix(System.Object instance) : base("System.Text.RegularExpressions.RegexPrefix")
		{
            SetInstance(instance);
		}

        public RRegexPrefix(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRegexPrefix(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
