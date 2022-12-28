using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions
{
	/// <summary>
	/// System.Text.RegularExpressions.RegexCompilationInfo
	/// </summary>
    public partial class RRegexCompilationInfo : RMember //
    {

		/// <summary>
		/// System.String _pattern
		/// </summary>
		protected RField r__pattern;
		public virtual RField R_pattern
		{
			get
			{
				if(r__pattern == null)
				{
					r__pattern = new(this, "_pattern");
					r__pattern.SetBelong(this.instance);
				}
				return r__pattern;
			}
		}

		/// <summary>
		/// System.String _name
		/// </summary>
		protected RField r__name;
		public virtual RField R_name
		{
			get
			{
				if(r__name == null)
				{
					r__name = new(this, "_name");
					r__name.SetBelong(this.instance);
				}
				return r__name;
			}
		}

		/// <summary>
		/// System.String _nspace
		/// </summary>
		protected RField r__nspace;
		public virtual RField R_nspace
		{
			get
			{
				if(r__nspace == null)
				{
					r__nspace = new(this, "_nspace");
					r__nspace.SetBelong(this.instance);
				}
				return r__nspace;
			}
		}

		/// <summary>
		/// System.TimeSpan _matchTimeout
		/// </summary>
		protected RSystem.RTimeSpan r__matchTimeout;
		public virtual RSystem.RTimeSpan R_matchTimeout
		{
			get
			{
				if(r__matchTimeout == null)
				{
					r__matchTimeout = new(this, "_matchTimeout");
					r__matchTimeout.SetBelong(this.instance);
				}
				return r__matchTimeout;
			}
		}

		/// <summary>
		/// System.Boolean <IsPublic>k__BackingField
		/// </summary>
		protected RField r___1__IsPublic__2__k__BackingField;
		public virtual RField R__1__IsPublic__2__k__BackingField
		{
			get
			{
				if(r___1__IsPublic__2__k__BackingField == null)
				{
					r___1__IsPublic__2__k__BackingField = new(this, "<IsPublic>k__BackingField");
					r___1__IsPublic__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__IsPublic__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexOptions <Options>k__BackingField
		/// </summary>
		protected RField r___1__Options__2__k__BackingField;
		public virtual RField R__1__Options__2__k__BackingField
		{
			get
			{
				if(r___1__Options__2__k__BackingField == null)
				{
					r___1__Options__2__k__BackingField = new(this, "<Options>k__BackingField");
					r___1__Options__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__Options__2__k__BackingField;
			}
		}

		/// <summary>
		/// Boolean IsPublic
		/// </summary>
		protected RProperty r_IsPublic;
		public virtual RProperty RIsPublic
		{
			get
			{
				if(r_IsPublic == null)
				{
					r_IsPublic = new(this, "IsPublic", -1);
					r_IsPublic.SetBelong(this.instance);
				}
				return r_IsPublic;
			}
		}

		/// <summary>
		/// System.TimeSpan MatchTimeout
		/// </summary>
		protected RSystem.RTimeSpan r_MatchTimeout;
		public virtual RSystem.RTimeSpan RMatchTimeout
		{
			get
			{
				if(r_MatchTimeout == null)
				{
					r_MatchTimeout = new(this, "MatchTimeout", -1);
					r_MatchTimeout.SetBelong(this.instance);
				}
				return r_MatchTimeout;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected RProperty r_Name;
		public virtual RProperty RName
		{
			get
			{
				if(r_Name == null)
				{
					r_Name = new(this, "Name", -1);
					r_Name.SetBelong(this.instance);
				}
				return r_Name;
			}
		}

		/// <summary>
		/// System.String Namespace
		/// </summary>
		protected RProperty r_Namespace;
		public virtual RProperty RNamespace
		{
			get
			{
				if(r_Namespace == null)
				{
					r_Namespace = new(this, "Namespace", -1);
					r_Namespace.SetBelong(this.instance);
				}
				return r_Namespace;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexOptions Options
		/// </summary>
		protected RProperty r_Options;
		public virtual RProperty ROptions
		{
			get
			{
				if(r_Options == null)
				{
					r_Options = new(this, "Options", -1);
					r_Options.SetBelong(this.instance);
				}
				return r_Options;
			}
		}

		/// <summary>
		/// System.String Pattern
		/// </summary>
		protected RProperty r_Pattern;
		public virtual RProperty RPattern
		{
			get
			{
				if(r_Pattern == null)
				{
					r_Pattern = new(this, "Pattern", -1);
					r_Pattern.SetBelong(this.instance);
				}
				return r_Pattern;
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


        public RRegexCompilationInfo() : base("System.Text.RegularExpressions.RegexCompilationInfo")
        {
        }

        public RRegexCompilationInfo(System.Object instance) : base("System.Text.RegularExpressions.RegexCompilationInfo")
		{
            SetInstance(instance);
		}

        public RRegexCompilationInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRegexCompilationInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}