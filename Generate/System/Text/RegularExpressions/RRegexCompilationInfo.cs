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
		protected RSystem.RString r_F_pattern;
		public virtual RSystem.RString RF_pattern
		{
			get
			{
				if(r_F_pattern == null)
				{
					r_F_pattern = new(this, "_pattern");
					r_F_pattern.SetBelong(this.instance);
				}
				return r_F_pattern;
			}
		}

		/// <summary>
		/// System.String _name
		/// </summary>
		protected RSystem.RString r_F_name;
		public virtual RSystem.RString RF_name
		{
			get
			{
				if(r_F_name == null)
				{
					r_F_name = new(this, "_name");
					r_F_name.SetBelong(this.instance);
				}
				return r_F_name;
			}
		}

		/// <summary>
		/// System.String _nspace
		/// </summary>
		protected RSystem.RString r_F_nspace;
		public virtual RSystem.RString RF_nspace
		{
			get
			{
				if(r_F_nspace == null)
				{
					r_F_nspace = new(this, "_nspace");
					r_F_nspace.SetBelong(this.instance);
				}
				return r_F_nspace;
			}
		}

		/// <summary>
		/// System.TimeSpan _matchTimeout
		/// </summary>
		protected RSystem.RTimeSpan r_F_matchTimeout;
		public virtual RSystem.RTimeSpan RF_matchTimeout
		{
			get
			{
				if(r_F_matchTimeout == null)
				{
					r_F_matchTimeout = new(this, "_matchTimeout");
					r_F_matchTimeout.SetBelong(this.instance);
				}
				return r_F_matchTimeout;
			}
		}

		/// <summary>
		/// System.Boolean <IsPublic>k__BackingField
		/// </summary>
		protected RSystem.RBoolean r_F__0__IsPublic__1__k__BackingField;
		public virtual RSystem.RBoolean RF__0__IsPublic__1__k__BackingField
		{
			get
			{
				if(r_F__0__IsPublic__1__k__BackingField == null)
				{
					r_F__0__IsPublic__1__k__BackingField = new(this, "<IsPublic>k__BackingField");
					r_F__0__IsPublic__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__IsPublic__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexOptions <Options>k__BackingField
		/// </summary>
		protected RSystem.RText.RRegularExpressions.RRegexOptions r_F__0__Options__1__k__BackingField;
		public virtual RSystem.RText.RRegularExpressions.RRegexOptions RF__0__Options__1__k__BackingField
		{
			get
			{
				if(r_F__0__Options__1__k__BackingField == null)
				{
					r_F__0__Options__1__k__BackingField = new(this, "<Options>k__BackingField");
					r_F__0__Options__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__Options__1__k__BackingField;
			}
		}

		/// <summary>
		/// Boolean IsPublic
		/// </summary>
		protected RSystem.RBoolean r_PIsPublic;
		public virtual RSystem.RBoolean RPIsPublic
		{
			get
			{
				if(r_PIsPublic == null)
				{
					r_PIsPublic = new(this, "IsPublic", -1);
					r_PIsPublic.SetBelong(this.instance);
				}
				return r_PIsPublic;
			}
		}

		/// <summary>
		/// System.TimeSpan MatchTimeout
		/// </summary>
		protected RSystem.RTimeSpan r_PMatchTimeout;
		public virtual RSystem.RTimeSpan RPMatchTimeout
		{
			get
			{
				if(r_PMatchTimeout == null)
				{
					r_PMatchTimeout = new(this, "MatchTimeout", -1);
					r_PMatchTimeout.SetBelong(this.instance);
				}
				return r_PMatchTimeout;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected RSystem.RString r_PName;
		public virtual RSystem.RString RPName
		{
			get
			{
				if(r_PName == null)
				{
					r_PName = new(this, "Name", -1);
					r_PName.SetBelong(this.instance);
				}
				return r_PName;
			}
		}

		/// <summary>
		/// System.String Namespace
		/// </summary>
		protected RSystem.RString r_PNamespace;
		public virtual RSystem.RString RPNamespace
		{
			get
			{
				if(r_PNamespace == null)
				{
					r_PNamespace = new(this, "Namespace", -1);
					r_PNamespace.SetBelong(this.instance);
				}
				return r_PNamespace;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexOptions Options
		/// </summary>
		protected RSystem.RText.RRegularExpressions.RRegexOptions r_POptions;
		public virtual RSystem.RText.RRegularExpressions.RRegexOptions RPOptions
		{
			get
			{
				if(r_POptions == null)
				{
					r_POptions = new(this, "Options", -1);
					r_POptions.SetBelong(this.instance);
				}
				return r_POptions;
			}
		}

		/// <summary>
		/// System.String Pattern
		/// </summary>
		protected RSystem.RString r_PPattern;
		public virtual RSystem.RString RPPattern
		{
			get
			{
				if(r_PPattern == null)
				{
					r_PPattern = new(this, "Pattern", -1);
					r_PPattern.SetBelong(this.instance);
				}
				return r_PPattern;
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

        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
