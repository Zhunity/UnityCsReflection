using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions
{
	/// <summary>
	/// System.Text.RegularExpressions.RegexBoyerMoore
	/// </summary>
    public partial class RRegexBoyerMoore : RMember //
    {

		/// <summary>
		/// System.Int32[] Positive
		/// </summary>
		protected RFieldArray<RField> r_Positive;
		public virtual RFieldArray<RField> RPositive
		{
			get
			{
				if(r_Positive == null)
				{
					r_Positive = new(this, "Positive");
					r_Positive.SetBelong(this.instance);
				}
				return r_Positive;
			}
		}

		/// <summary>
		/// System.Int32[] NegativeASCII
		/// </summary>
		protected RFieldArray<RField> r_NegativeASCII;
		public virtual RFieldArray<RField> RNegativeASCII
		{
			get
			{
				if(r_NegativeASCII == null)
				{
					r_NegativeASCII = new(this, "NegativeASCII");
					r_NegativeASCII.SetBelong(this.instance);
				}
				return r_NegativeASCII;
			}
		}

		/// <summary>
		/// System.Int32[][] NegativeUnicode
		/// </summary>
		protected RFieldArray<RFieldArray<RField>> r_NegativeUnicode;
		public virtual RFieldArray<RFieldArray<RField>> RNegativeUnicode
		{
			get
			{
				if(r_NegativeUnicode == null)
				{
					r_NegativeUnicode = new(this, "NegativeUnicode");
					r_NegativeUnicode.SetBelong(this.instance);
				}
				return r_NegativeUnicode;
			}
		}

		/// <summary>
		/// System.String Pattern
		/// </summary>
		protected RField r_Pattern;
		public virtual RField RPattern
		{
			get
			{
				if(r_Pattern == null)
				{
					r_Pattern = new(this, "Pattern");
					r_Pattern.SetBelong(this.instance);
				}
				return r_Pattern;
			}
		}

		/// <summary>
		/// System.Int32 LowASCII
		/// </summary>
		protected RField r_LowASCII;
		public virtual RField RLowASCII
		{
			get
			{
				if(r_LowASCII == null)
				{
					r_LowASCII = new(this, "LowASCII");
					r_LowASCII.SetBelong(this.instance);
				}
				return r_LowASCII;
			}
		}

		/// <summary>
		/// System.Int32 HighASCII
		/// </summary>
		protected RField r_HighASCII;
		public virtual RField RHighASCII
		{
			get
			{
				if(r_HighASCII == null)
				{
					r_HighASCII = new(this, "HighASCII");
					r_HighASCII.SetBelong(this.instance);
				}
				return r_HighASCII;
			}
		}

		/// <summary>
		/// System.Boolean RightToLeft
		/// </summary>
		protected RField r_RightToLeft;
		public virtual RField RRightToLeft
		{
			get
			{
				if(r_RightToLeft == null)
				{
					r_RightToLeft = new(this, "RightToLeft");
					r_RightToLeft.SetBelong(this.instance);
				}
				return r_RightToLeft;
			}
		}

		/// <summary>
		/// System.Boolean CaseInsensitive
		/// </summary>
		protected RField r_CaseInsensitive;
		public virtual RField RCaseInsensitive
		{
			get
			{
				if(r_CaseInsensitive == null)
				{
					r_CaseInsensitive = new(this, "CaseInsensitive");
					r_CaseInsensitive.SetBelong(this.instance);
				}
				return r_CaseInsensitive;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo _culture
		/// </summary>
		protected RSystem.RGlobalization.RCultureInfo r__culture;
		public virtual RSystem.RGlobalization.RCultureInfo R_culture
		{
			get
			{
				if(r__culture == null)
				{
					r__culture = new(this, "_culture");
					r__culture.SetBelong(this.instance);
				}
				return r__culture;
			}
		}

		/// <summary>
		/// Boolean MatchPattern(System.String, Int32)
		/// </summary>
		protected RMethod r_MatchPattern_String_Int32;
		public virtual RMethod RMatchPattern_String_Int32
		{
			get
			{
				if(r_MatchPattern_String_Int32 == null)
				{
					r_MatchPattern_String_Int32 = new(this, "MatchPattern", 0, typeof(System.String), typeof(System.Int32));
					r_MatchPattern_String_Int32.SetBelong(this.instance);
				}
				return r_MatchPattern_String_Int32;
			}
		}

		/// <summary>
		/// Boolean IsMatch(System.String, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_IsMatch_String_Int32_Int32_Int32;
		public virtual RMethod RIsMatch_String_Int32_Int32_Int32
		{
			get
			{
				if(r_IsMatch_String_Int32_Int32_Int32 == null)
				{
					r_IsMatch_String_Int32_Int32_Int32 = new(this, "IsMatch", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_IsMatch_String_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_IsMatch_String_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 Scan(System.String, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_Scan_String_Int32_Int32_Int32;
		public virtual RMethod RScan_String_Int32_Int32_Int32
		{
			get
			{
				if(r_Scan_String_Int32_Int32_Int32 == null)
				{
					r_Scan_String_Int32_Int32_Int32 = new(this, "Scan", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_Scan_String_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_Scan_String_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_Equals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_Equals_Object == null)
				{
					r_Equals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_Equals_Object.SetBelong(this.instance);
				}
				return r_Equals_Object;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_Finalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_Finalize == null)
				{
					r_Finalize = new(this, "Finalize", 0);
					r_Finalize.SetBelong(this.instance);
				}
				return r_Finalize;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_GetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_GetHashCode == null)
				{
					r_GetHashCode = new(this, "GetHashCode", 0);
					r_GetHashCode.SetBelong(this.instance);
				}
				return r_GetHashCode;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_GetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_GetType == null)
				{
					r_GetType = new(this, "GetType", 0);
					r_GetType.SetBelong(this.instance);
				}
				return r_GetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_MemberwiseClone == null)
				{
					r_MemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MemberwiseClone.SetBelong(this.instance);
				}
				return r_MemberwiseClone;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_ToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_ToString == null)
				{
					r_ToString = new(this, "ToString", 0);
					r_ToString.SetBelong(this.instance);
				}
				return r_ToString;
			}
		}


        public RRegexBoyerMoore() : base("System.Text.RegularExpressions.RegexBoyerMoore")
        {
        }

        public RRegexBoyerMoore(System.Object instance) : base("System.Text.RegularExpressions.RegexBoyerMoore")
		{
            SetInstance(instance);
		}

        public RRegexBoyerMoore(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRegexBoyerMoore(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean MatchPattern(System.String @text, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @index};
            var ___result = RMatchPattern_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsMatch(System.String @text, System.Int32 @index, System.Int32 @beglimit, System.Int32 @endlimit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @index, @beglimit, @endlimit};
            var ___result = RIsMatch_String_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 Scan(System.String @text, System.Int32 @index, System.Int32 @beglimit, System.Int32 @endlimit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @index, @beglimit, @endlimit};
            var ___result = RScan_String_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
