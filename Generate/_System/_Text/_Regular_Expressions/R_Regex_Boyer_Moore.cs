
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Text.RegularExpressions.RegexBoyerMoore
	/// </summary>
    public partial class RRegexBoyerMoore : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Text.RegularExpressions.RegexBoyerMoore");
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


		/// <summary>
		/// System.Int32[] Positive
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_FPositive;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> RFPositive
		{
			get
			{
				if(r_FPositive == null)
				{
					r_FPositive = new(this, "Positive");
				}
				return r_FPositive;
			}
		}

		/// <summary>
		/// System.Int32[] NegativeASCII
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_FNegativeASCII;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> RFNegativeASCII
		{
			get
			{
				if(r_FNegativeASCII == null)
				{
					r_FNegativeASCII = new(this, "NegativeASCII");
				}
				return r_FNegativeASCII;
			}
		}

		/// <summary>
		/// System.Int32[][] NegativeUnicode
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32>> r_FNegativeUnicode;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32>> RFNegativeUnicode
		{
			get
			{
				if(r_FNegativeUnicode == null)
				{
					r_FNegativeUnicode = new(this, "NegativeUnicode");
				}
				return r_FNegativeUnicode;
			}
		}

		/// <summary>
		/// System.String Pattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FPattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFPattern
		{
			get
			{
				if(r_FPattern == null)
				{
					r_FPattern = new(this, "Pattern");
				}
				return r_FPattern;
			}
		}

		/// <summary>
		/// System.Int32 LowASCII
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FLowASCII;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFLowASCII
		{
			get
			{
				if(r_FLowASCII == null)
				{
					r_FLowASCII = new(this, "LowASCII");
				}
				return r_FLowASCII;
			}
		}

		/// <summary>
		/// System.Int32 HighASCII
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FHighASCII;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFHighASCII
		{
			get
			{
				if(r_FHighASCII == null)
				{
					r_FHighASCII = new(this, "HighASCII");
				}
				return r_FHighASCII;
			}
		}

		/// <summary>
		/// System.Boolean RightToLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FRightToLeft;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFRightToLeft
		{
			get
			{
				if(r_FRightToLeft == null)
				{
					r_FRightToLeft = new(this, "RightToLeft");
				}
				return r_FRightToLeft;
			}
		}

		/// <summary>
		/// System.Boolean CaseInsensitive
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FCaseInsensitive;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFCaseInsensitive
		{
			get
			{
				if(r_FCaseInsensitive == null)
				{
					r_FCaseInsensitive = new(this, "CaseInsensitive");
				}
				return r_FCaseInsensitive;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo _culture
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo r_F_culture;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo RF_culture
		{
			get
			{
				if(r_F_culture == null)
				{
					r_F_culture = new(this, "_culture");
				}
				return r_F_culture;
			}
		}

		/// <summary>
		/// Boolean MatchPattern(System.String, Int32)
		/// </summary>
		protected RMethod r_MMatchPattern_String_Int32;
		public virtual RMethod RMMatchPattern_String_Int32
		{
			get
			{
				if(r_MMatchPattern_String_Int32 == null)
				{
					r_MMatchPattern_String_Int32 = new(this, "MatchPattern", 0, typeof(System.String), typeof(System.Int32));
				}
				return r_MMatchPattern_String_Int32;
			}
		}

		/// <summary>
		/// Boolean IsMatch(System.String, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MIsMatch_String_Int32_Int32_Int32;
		public virtual RMethod RMIsMatch_String_Int32_Int32_Int32
		{
			get
			{
				if(r_MIsMatch_String_Int32_Int32_Int32 == null)
				{
					r_MIsMatch_String_Int32_Int32_Int32 = new(this, "IsMatch", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MIsMatch_String_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 Scan(System.String, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MScan_String_Int32_Int32_Int32;
		public virtual RMethod RMScan_String_Int32_Int32_Int32
		{
			get
			{
				if(r_MScan_String_Int32_Int32_Int32 == null)
				{
					r_MScan_String_Int32_Int32_Int32 = new(this, "Scan", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MScan_String_Int32_Int32_Int32;
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
				}
				return r_MToString;
			}
		}


        public virtual System.Boolean MatchPattern(System.String @text, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @index};
            var ___result = RMMatchPattern_String_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean IsMatch(System.String @text, System.Int32 @index, System.Int32 @beglimit, System.Int32 @endlimit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @index, @beglimit, @endlimit};
            var ___result = RMIsMatch_String_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 Scan(System.String @text, System.Int32 @index, System.Int32 @beglimit, System.Int32 @endlimit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @index, @beglimit, @endlimit};
            var ___result = RMScan_String_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
