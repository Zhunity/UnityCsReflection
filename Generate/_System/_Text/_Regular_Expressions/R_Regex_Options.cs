
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions
{
	/// <summary>
	/// System.Text.RegularExpressions.RegexOptions
	/// </summary>
    public partial class RRegexOptions : RMember //
    {

		/// <summary>
		/// System.Int32 value__
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fvalue__;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFvalue__
		{
			get
			{
				if(r_Fvalue__ == null)
				{
					r_Fvalue__ = new(this, "value__");
					r_Fvalue__.SetBelong(this.instance);
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexOptions None
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexOptions r_FNone;
		public static SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexOptions RFNone
		{
			get
			{
				if(r_FNone == null)
				{
					r_FNone = new(typeof(System.Text.RegularExpressions.RegexOptions), "None");
					r_FNone.SetBelong(null);
				}
				return r_FNone;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexOptions IgnoreCase
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexOptions r_FIgnoreCase;
		public static SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexOptions RFIgnoreCase
		{
			get
			{
				if(r_FIgnoreCase == null)
				{
					r_FIgnoreCase = new(typeof(System.Text.RegularExpressions.RegexOptions), "IgnoreCase");
					r_FIgnoreCase.SetBelong(null);
				}
				return r_FIgnoreCase;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexOptions Multiline
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexOptions r_FMultiline;
		public static SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexOptions RFMultiline
		{
			get
			{
				if(r_FMultiline == null)
				{
					r_FMultiline = new(typeof(System.Text.RegularExpressions.RegexOptions), "Multiline");
					r_FMultiline.SetBelong(null);
				}
				return r_FMultiline;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexOptions ExplicitCapture
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexOptions r_FExplicitCapture;
		public static SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexOptions RFExplicitCapture
		{
			get
			{
				if(r_FExplicitCapture == null)
				{
					r_FExplicitCapture = new(typeof(System.Text.RegularExpressions.RegexOptions), "ExplicitCapture");
					r_FExplicitCapture.SetBelong(null);
				}
				return r_FExplicitCapture;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexOptions Compiled
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexOptions r_FCompiled;
		public static SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexOptions RFCompiled
		{
			get
			{
				if(r_FCompiled == null)
				{
					r_FCompiled = new(typeof(System.Text.RegularExpressions.RegexOptions), "Compiled");
					r_FCompiled.SetBelong(null);
				}
				return r_FCompiled;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexOptions Singleline
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexOptions r_FSingleline;
		public static SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexOptions RFSingleline
		{
			get
			{
				if(r_FSingleline == null)
				{
					r_FSingleline = new(typeof(System.Text.RegularExpressions.RegexOptions), "Singleline");
					r_FSingleline.SetBelong(null);
				}
				return r_FSingleline;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexOptions IgnorePatternWhitespace
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexOptions r_FIgnorePatternWhitespace;
		public static SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexOptions RFIgnorePatternWhitespace
		{
			get
			{
				if(r_FIgnorePatternWhitespace == null)
				{
					r_FIgnorePatternWhitespace = new(typeof(System.Text.RegularExpressions.RegexOptions), "IgnorePatternWhitespace");
					r_FIgnorePatternWhitespace.SetBelong(null);
				}
				return r_FIgnorePatternWhitespace;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexOptions RightToLeft
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexOptions r_FRightToLeft;
		public static SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexOptions RFRightToLeft
		{
			get
			{
				if(r_FRightToLeft == null)
				{
					r_FRightToLeft = new(typeof(System.Text.RegularExpressions.RegexOptions), "RightToLeft");
					r_FRightToLeft.SetBelong(null);
				}
				return r_FRightToLeft;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexOptions ECMAScript
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexOptions r_FECMAScript;
		public static SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexOptions RFECMAScript
		{
			get
			{
				if(r_FECMAScript == null)
				{
					r_FECMAScript = new(typeof(System.Text.RegularExpressions.RegexOptions), "ECMAScript");
					r_FECMAScript.SetBelong(null);
				}
				return r_FECMAScript;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexOptions CultureInvariant
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexOptions r_FCultureInvariant;
		public static SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexOptions RFCultureInvariant
		{
			get
			{
				if(r_FCultureInvariant == null)
				{
					r_FCultureInvariant = new(typeof(System.Text.RegularExpressions.RegexOptions), "CultureInvariant");
					r_FCultureInvariant.SetBelong(null);
				}
				return r_FCultureInvariant;
			}
		}

		/// <summary>
		/// System.Object GetValue()
		/// </summary>
		protected RMethod r_MGetValue;
		public virtual RMethod RMGetValue
		{
			get
			{
				if(r_MGetValue == null)
				{
					r_MGetValue = new(this, "GetValue", 0);
					r_MGetValue.SetBelong(this.instance);
				}
				return r_MGetValue;
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
		/// System.String ToString(System.String, System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_String_IFormatProvider;
		public virtual RMethod RMToString_String_IFormatProvider
		{
			get
			{
				if(r_MToString_String_IFormatProvider == null)
				{
					r_MToString_String_IFormatProvider = new(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
					r_MToString_String_IFormatProvider.SetBelong(this.instance);
				}
				return r_MToString_String_IFormatProvider;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Object)
		/// </summary>
		protected RMethod r_MCompareTo_Object;
		public virtual RMethod RMCompareTo_Object
		{
			get
			{
				if(r_MCompareTo_Object == null)
				{
					r_MCompareTo_Object = new(this, "CompareTo", 0, typeof(System.Object));
					r_MCompareTo_Object.SetBelong(this.instance);
				}
				return r_MCompareTo_Object;
			}
		}

		/// <summary>
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_MToString_String;
		public virtual RMethod RMToString_String
		{
			get
			{
				if(r_MToString_String == null)
				{
					r_MToString_String = new(this, "ToString", 0, typeof(System.String));
					r_MToString_String.SetBelong(this.instance);
				}
				return r_MToString_String;
			}
		}

		/// <summary>
		/// System.String ToString(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_IFormatProvider;
		public virtual RMethod RMToString_IFormatProvider
		{
			get
			{
				if(r_MToString_IFormatProvider == null)
				{
					r_MToString_IFormatProvider = new(this, "ToString", 0, typeof(System.IFormatProvider));
					r_MToString_IFormatProvider.SetBelong(this.instance);
				}
				return r_MToString_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean HasFlag(System.Enum)
		/// </summary>
		protected RMethod r_MHasFlag_Enum;
		public virtual RMethod RMHasFlag_Enum
		{
			get
			{
				if(r_MHasFlag_Enum == null)
				{
					r_MHasFlag_Enum = new(this, "HasFlag", 0, typeof(System.Enum));
					r_MHasFlag_Enum.SetBelong(this.instance);
				}
				return r_MHasFlag_Enum;
			}
		}

		/// <summary>
		/// System.TypeCode GetTypeCode()
		/// </summary>
		protected RMethod r_MGetTypeCode;
		public virtual RMethod RMGetTypeCode
		{
			get
			{
				if(r_MGetTypeCode == null)
				{
					r_MGetTypeCode = new(this, "GetTypeCode", 0);
					r_MGetTypeCode.SetBelong(this.instance);
				}
				return r_MGetTypeCode;
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


        public RRegexOptions() : base("System.Text.RegularExpressions.RegexOptions")
        {
        }

        public RRegexOptions(System.Object instance) : base("System.Text.RegularExpressions.RegexOptions")
		{
            SetInstance(instance);
		}

        public RRegexOptions(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRegexOptions(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object GetValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValue.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 CompareTo(System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean HasFlag(System.Enum @flag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flag};
            var ___result = RMHasFlag_Enum.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCode.Invoke(___genericsType, ___parameters);

            return (System.TypeCode)___result;
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