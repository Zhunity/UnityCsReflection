
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.TokenType
	/// </summary>
    public partial class RTokenType : RMember //
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
		/// System.TokenType NumberToken
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTokenType r_FNumberToken;
		public static SMFrame.Editor.Refleaction.RSystem.RTokenType RFNumberToken
		{
			get
			{
				if(r_FNumberToken == null)
				{
					r_FNumberToken = new( ReflectionUtils.GetType("System.TokenType"), "NumberToken");
					r_FNumberToken.SetBelong(null);
				}
				return r_FNumberToken;
			}
		}

		/// <summary>
		/// System.TokenType YearNumberToken
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTokenType r_FYearNumberToken;
		public static SMFrame.Editor.Refleaction.RSystem.RTokenType RFYearNumberToken
		{
			get
			{
				if(r_FYearNumberToken == null)
				{
					r_FYearNumberToken = new( ReflectionUtils.GetType("System.TokenType"), "YearNumberToken");
					r_FYearNumberToken.SetBelong(null);
				}
				return r_FYearNumberToken;
			}
		}

		/// <summary>
		/// System.TokenType Am
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTokenType r_FAm;
		public static SMFrame.Editor.Refleaction.RSystem.RTokenType RFAm
		{
			get
			{
				if(r_FAm == null)
				{
					r_FAm = new( ReflectionUtils.GetType("System.TokenType"), "Am");
					r_FAm.SetBelong(null);
				}
				return r_FAm;
			}
		}

		/// <summary>
		/// System.TokenType Pm
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTokenType r_FPm;
		public static SMFrame.Editor.Refleaction.RSystem.RTokenType RFPm
		{
			get
			{
				if(r_FPm == null)
				{
					r_FPm = new( ReflectionUtils.GetType("System.TokenType"), "Pm");
					r_FPm.SetBelong(null);
				}
				return r_FPm;
			}
		}

		/// <summary>
		/// System.TokenType MonthToken
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTokenType r_FMonthToken;
		public static SMFrame.Editor.Refleaction.RSystem.RTokenType RFMonthToken
		{
			get
			{
				if(r_FMonthToken == null)
				{
					r_FMonthToken = new( ReflectionUtils.GetType("System.TokenType"), "MonthToken");
					r_FMonthToken.SetBelong(null);
				}
				return r_FMonthToken;
			}
		}

		/// <summary>
		/// System.TokenType EndOfString
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTokenType r_FEndOfString;
		public static SMFrame.Editor.Refleaction.RSystem.RTokenType RFEndOfString
		{
			get
			{
				if(r_FEndOfString == null)
				{
					r_FEndOfString = new( ReflectionUtils.GetType("System.TokenType"), "EndOfString");
					r_FEndOfString.SetBelong(null);
				}
				return r_FEndOfString;
			}
		}

		/// <summary>
		/// System.TokenType DayOfWeekToken
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTokenType r_FDayOfWeekToken;
		public static SMFrame.Editor.Refleaction.RSystem.RTokenType RFDayOfWeekToken
		{
			get
			{
				if(r_FDayOfWeekToken == null)
				{
					r_FDayOfWeekToken = new( ReflectionUtils.GetType("System.TokenType"), "DayOfWeekToken");
					r_FDayOfWeekToken.SetBelong(null);
				}
				return r_FDayOfWeekToken;
			}
		}

		/// <summary>
		/// System.TokenType TimeZoneToken
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTokenType r_FTimeZoneToken;
		public static SMFrame.Editor.Refleaction.RSystem.RTokenType RFTimeZoneToken
		{
			get
			{
				if(r_FTimeZoneToken == null)
				{
					r_FTimeZoneToken = new( ReflectionUtils.GetType("System.TokenType"), "TimeZoneToken");
					r_FTimeZoneToken.SetBelong(null);
				}
				return r_FTimeZoneToken;
			}
		}

		/// <summary>
		/// System.TokenType EraToken
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTokenType r_FEraToken;
		public static SMFrame.Editor.Refleaction.RSystem.RTokenType RFEraToken
		{
			get
			{
				if(r_FEraToken == null)
				{
					r_FEraToken = new( ReflectionUtils.GetType("System.TokenType"), "EraToken");
					r_FEraToken.SetBelong(null);
				}
				return r_FEraToken;
			}
		}

		/// <summary>
		/// System.TokenType DateWordToken
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTokenType r_FDateWordToken;
		public static SMFrame.Editor.Refleaction.RSystem.RTokenType RFDateWordToken
		{
			get
			{
				if(r_FDateWordToken == null)
				{
					r_FDateWordToken = new( ReflectionUtils.GetType("System.TokenType"), "DateWordToken");
					r_FDateWordToken.SetBelong(null);
				}
				return r_FDateWordToken;
			}
		}

		/// <summary>
		/// System.TokenType UnknownToken
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTokenType r_FUnknownToken;
		public static SMFrame.Editor.Refleaction.RSystem.RTokenType RFUnknownToken
		{
			get
			{
				if(r_FUnknownToken == null)
				{
					r_FUnknownToken = new( ReflectionUtils.GetType("System.TokenType"), "UnknownToken");
					r_FUnknownToken.SetBelong(null);
				}
				return r_FUnknownToken;
			}
		}

		/// <summary>
		/// System.TokenType HebrewNumber
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTokenType r_FHebrewNumber;
		public static SMFrame.Editor.Refleaction.RSystem.RTokenType RFHebrewNumber
		{
			get
			{
				if(r_FHebrewNumber == null)
				{
					r_FHebrewNumber = new( ReflectionUtils.GetType("System.TokenType"), "HebrewNumber");
					r_FHebrewNumber.SetBelong(null);
				}
				return r_FHebrewNumber;
			}
		}

		/// <summary>
		/// System.TokenType JapaneseEraToken
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTokenType r_FJapaneseEraToken;
		public static SMFrame.Editor.Refleaction.RSystem.RTokenType RFJapaneseEraToken
		{
			get
			{
				if(r_FJapaneseEraToken == null)
				{
					r_FJapaneseEraToken = new( ReflectionUtils.GetType("System.TokenType"), "JapaneseEraToken");
					r_FJapaneseEraToken.SetBelong(null);
				}
				return r_FJapaneseEraToken;
			}
		}

		/// <summary>
		/// System.TokenType TEraToken
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTokenType r_FTEraToken;
		public static SMFrame.Editor.Refleaction.RSystem.RTokenType RFTEraToken
		{
			get
			{
				if(r_FTEraToken == null)
				{
					r_FTEraToken = new( ReflectionUtils.GetType("System.TokenType"), "TEraToken");
					r_FTEraToken.SetBelong(null);
				}
				return r_FTEraToken;
			}
		}

		/// <summary>
		/// System.TokenType IgnorableSymbol
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTokenType r_FIgnorableSymbol;
		public static SMFrame.Editor.Refleaction.RSystem.RTokenType RFIgnorableSymbol
		{
			get
			{
				if(r_FIgnorableSymbol == null)
				{
					r_FIgnorableSymbol = new( ReflectionUtils.GetType("System.TokenType"), "IgnorableSymbol");
					r_FIgnorableSymbol.SetBelong(null);
				}
				return r_FIgnorableSymbol;
			}
		}

		/// <summary>
		/// System.TokenType SEP_Unk
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTokenType r_FSEP_Unk;
		public static SMFrame.Editor.Refleaction.RSystem.RTokenType RFSEP_Unk
		{
			get
			{
				if(r_FSEP_Unk == null)
				{
					r_FSEP_Unk = new( ReflectionUtils.GetType("System.TokenType"), "SEP_Unk");
					r_FSEP_Unk.SetBelong(null);
				}
				return r_FSEP_Unk;
			}
		}

		/// <summary>
		/// System.TokenType SEP_End
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTokenType r_FSEP_End;
		public static SMFrame.Editor.Refleaction.RSystem.RTokenType RFSEP_End
		{
			get
			{
				if(r_FSEP_End == null)
				{
					r_FSEP_End = new( ReflectionUtils.GetType("System.TokenType"), "SEP_End");
					r_FSEP_End.SetBelong(null);
				}
				return r_FSEP_End;
			}
		}

		/// <summary>
		/// System.TokenType SEP_Space
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTokenType r_FSEP_Space;
		public static SMFrame.Editor.Refleaction.RSystem.RTokenType RFSEP_Space
		{
			get
			{
				if(r_FSEP_Space == null)
				{
					r_FSEP_Space = new( ReflectionUtils.GetType("System.TokenType"), "SEP_Space");
					r_FSEP_Space.SetBelong(null);
				}
				return r_FSEP_Space;
			}
		}

		/// <summary>
		/// System.TokenType SEP_Am
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTokenType r_FSEP_Am;
		public static SMFrame.Editor.Refleaction.RSystem.RTokenType RFSEP_Am
		{
			get
			{
				if(r_FSEP_Am == null)
				{
					r_FSEP_Am = new( ReflectionUtils.GetType("System.TokenType"), "SEP_Am");
					r_FSEP_Am.SetBelong(null);
				}
				return r_FSEP_Am;
			}
		}

		/// <summary>
		/// System.TokenType SEP_Pm
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTokenType r_FSEP_Pm;
		public static SMFrame.Editor.Refleaction.RSystem.RTokenType RFSEP_Pm
		{
			get
			{
				if(r_FSEP_Pm == null)
				{
					r_FSEP_Pm = new( ReflectionUtils.GetType("System.TokenType"), "SEP_Pm");
					r_FSEP_Pm.SetBelong(null);
				}
				return r_FSEP_Pm;
			}
		}

		/// <summary>
		/// System.TokenType SEP_Date
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTokenType r_FSEP_Date;
		public static SMFrame.Editor.Refleaction.RSystem.RTokenType RFSEP_Date
		{
			get
			{
				if(r_FSEP_Date == null)
				{
					r_FSEP_Date = new( ReflectionUtils.GetType("System.TokenType"), "SEP_Date");
					r_FSEP_Date.SetBelong(null);
				}
				return r_FSEP_Date;
			}
		}

		/// <summary>
		/// System.TokenType SEP_Time
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTokenType r_FSEP_Time;
		public static SMFrame.Editor.Refleaction.RSystem.RTokenType RFSEP_Time
		{
			get
			{
				if(r_FSEP_Time == null)
				{
					r_FSEP_Time = new( ReflectionUtils.GetType("System.TokenType"), "SEP_Time");
					r_FSEP_Time.SetBelong(null);
				}
				return r_FSEP_Time;
			}
		}

		/// <summary>
		/// System.TokenType SEP_YearSuff
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTokenType r_FSEP_YearSuff;
		public static SMFrame.Editor.Refleaction.RSystem.RTokenType RFSEP_YearSuff
		{
			get
			{
				if(r_FSEP_YearSuff == null)
				{
					r_FSEP_YearSuff = new( ReflectionUtils.GetType("System.TokenType"), "SEP_YearSuff");
					r_FSEP_YearSuff.SetBelong(null);
				}
				return r_FSEP_YearSuff;
			}
		}

		/// <summary>
		/// System.TokenType SEP_MonthSuff
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTokenType r_FSEP_MonthSuff;
		public static SMFrame.Editor.Refleaction.RSystem.RTokenType RFSEP_MonthSuff
		{
			get
			{
				if(r_FSEP_MonthSuff == null)
				{
					r_FSEP_MonthSuff = new( ReflectionUtils.GetType("System.TokenType"), "SEP_MonthSuff");
					r_FSEP_MonthSuff.SetBelong(null);
				}
				return r_FSEP_MonthSuff;
			}
		}

		/// <summary>
		/// System.TokenType SEP_DaySuff
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTokenType r_FSEP_DaySuff;
		public static SMFrame.Editor.Refleaction.RSystem.RTokenType RFSEP_DaySuff
		{
			get
			{
				if(r_FSEP_DaySuff == null)
				{
					r_FSEP_DaySuff = new( ReflectionUtils.GetType("System.TokenType"), "SEP_DaySuff");
					r_FSEP_DaySuff.SetBelong(null);
				}
				return r_FSEP_DaySuff;
			}
		}

		/// <summary>
		/// System.TokenType SEP_HourSuff
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTokenType r_FSEP_HourSuff;
		public static SMFrame.Editor.Refleaction.RSystem.RTokenType RFSEP_HourSuff
		{
			get
			{
				if(r_FSEP_HourSuff == null)
				{
					r_FSEP_HourSuff = new( ReflectionUtils.GetType("System.TokenType"), "SEP_HourSuff");
					r_FSEP_HourSuff.SetBelong(null);
				}
				return r_FSEP_HourSuff;
			}
		}

		/// <summary>
		/// System.TokenType SEP_MinuteSuff
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTokenType r_FSEP_MinuteSuff;
		public static SMFrame.Editor.Refleaction.RSystem.RTokenType RFSEP_MinuteSuff
		{
			get
			{
				if(r_FSEP_MinuteSuff == null)
				{
					r_FSEP_MinuteSuff = new( ReflectionUtils.GetType("System.TokenType"), "SEP_MinuteSuff");
					r_FSEP_MinuteSuff.SetBelong(null);
				}
				return r_FSEP_MinuteSuff;
			}
		}

		/// <summary>
		/// System.TokenType SEP_SecondSuff
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTokenType r_FSEP_SecondSuff;
		public static SMFrame.Editor.Refleaction.RSystem.RTokenType RFSEP_SecondSuff
		{
			get
			{
				if(r_FSEP_SecondSuff == null)
				{
					r_FSEP_SecondSuff = new( ReflectionUtils.GetType("System.TokenType"), "SEP_SecondSuff");
					r_FSEP_SecondSuff.SetBelong(null);
				}
				return r_FSEP_SecondSuff;
			}
		}

		/// <summary>
		/// System.TokenType SEP_LocalTimeMark
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTokenType r_FSEP_LocalTimeMark;
		public static SMFrame.Editor.Refleaction.RSystem.RTokenType RFSEP_LocalTimeMark
		{
			get
			{
				if(r_FSEP_LocalTimeMark == null)
				{
					r_FSEP_LocalTimeMark = new( ReflectionUtils.GetType("System.TokenType"), "SEP_LocalTimeMark");
					r_FSEP_LocalTimeMark.SetBelong(null);
				}
				return r_FSEP_LocalTimeMark;
			}
		}

		/// <summary>
		/// System.TokenType SEP_DateOrOffset
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTokenType r_FSEP_DateOrOffset;
		public static SMFrame.Editor.Refleaction.RSystem.RTokenType RFSEP_DateOrOffset
		{
			get
			{
				if(r_FSEP_DateOrOffset == null)
				{
					r_FSEP_DateOrOffset = new( ReflectionUtils.GetType("System.TokenType"), "SEP_DateOrOffset");
					r_FSEP_DateOrOffset.SetBelong(null);
				}
				return r_FSEP_DateOrOffset;
			}
		}

		/// <summary>
		/// System.TokenType RegularTokenMask
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTokenType r_FRegularTokenMask;
		public static SMFrame.Editor.Refleaction.RSystem.RTokenType RFRegularTokenMask
		{
			get
			{
				if(r_FRegularTokenMask == null)
				{
					r_FRegularTokenMask = new( ReflectionUtils.GetType("System.TokenType"), "RegularTokenMask");
					r_FRegularTokenMask.SetBelong(null);
				}
				return r_FRegularTokenMask;
			}
		}

		/// <summary>
		/// System.TokenType SeparatorTokenMask
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTokenType r_FSeparatorTokenMask;
		public static SMFrame.Editor.Refleaction.RSystem.RTokenType RFSeparatorTokenMask
		{
			get
			{
				if(r_FSeparatorTokenMask == null)
				{
					r_FSeparatorTokenMask = new( ReflectionUtils.GetType("System.TokenType"), "SeparatorTokenMask");
					r_FSeparatorTokenMask.SetBelong(null);
				}
				return r_FSeparatorTokenMask;
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


        public RTokenType() : base("System.TokenType")
        {
        }

        public RTokenType(System.Object instance) : base("System.TokenType")
		{
            SetInstance(instance);
		}

        public RTokenType(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTokenType(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
