using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RGlobalization
{
	/// <summary>
	/// System.Globalization.CalendarData
	/// </summary>
    public partial class RCalendarData : RMember //
    {

		/// <summary>
		/// System.Int32 MAX_CALENDARS
		/// </summary>
		protected static RField r_MAX_CALENDARS;
		public static RField RMAX_CALENDARS
		{
			get
			{
				if(r_MAX_CALENDARS == null)
				{
					r_MAX_CALENDARS = new( ReflectionUtils.GetType("System.Globalization.CalendarData"), "MAX_CALENDARS");
					r_MAX_CALENDARS.SetBelong(null);
				}
				return r_MAX_CALENDARS;
			}
		}

		/// <summary>
		/// System.String sNativeName
		/// </summary>
		protected RField r_sNativeName;
		public virtual RField RsNativeName
		{
			get
			{
				if(r_sNativeName == null)
				{
					r_sNativeName = new(this, "sNativeName");
					r_sNativeName.SetBelong(this.instance);
				}
				return r_sNativeName;
			}
		}

		/// <summary>
		/// System.String[] saShortDates
		/// </summary>
		protected RFieldArray<RField> r_saShortDates;
		public virtual RFieldArray<RField> RsaShortDates
		{
			get
			{
				if(r_saShortDates == null)
				{
					r_saShortDates = new(this, "saShortDates");
					r_saShortDates.SetBelong(this.instance);
				}
				return r_saShortDates;
			}
		}

		/// <summary>
		/// System.String[] saYearMonths
		/// </summary>
		protected RFieldArray<RField> r_saYearMonths;
		public virtual RFieldArray<RField> RsaYearMonths
		{
			get
			{
				if(r_saYearMonths == null)
				{
					r_saYearMonths = new(this, "saYearMonths");
					r_saYearMonths.SetBelong(this.instance);
				}
				return r_saYearMonths;
			}
		}

		/// <summary>
		/// System.String[] saLongDates
		/// </summary>
		protected RFieldArray<RField> r_saLongDates;
		public virtual RFieldArray<RField> RsaLongDates
		{
			get
			{
				if(r_saLongDates == null)
				{
					r_saLongDates = new(this, "saLongDates");
					r_saLongDates.SetBelong(this.instance);
				}
				return r_saLongDates;
			}
		}

		/// <summary>
		/// System.String sMonthDay
		/// </summary>
		protected RField r_sMonthDay;
		public virtual RField RsMonthDay
		{
			get
			{
				if(r_sMonthDay == null)
				{
					r_sMonthDay = new(this, "sMonthDay");
					r_sMonthDay.SetBelong(this.instance);
				}
				return r_sMonthDay;
			}
		}

		/// <summary>
		/// System.String[] saEraNames
		/// </summary>
		protected RFieldArray<RField> r_saEraNames;
		public virtual RFieldArray<RField> RsaEraNames
		{
			get
			{
				if(r_saEraNames == null)
				{
					r_saEraNames = new(this, "saEraNames");
					r_saEraNames.SetBelong(this.instance);
				}
				return r_saEraNames;
			}
		}

		/// <summary>
		/// System.String[] saAbbrevEraNames
		/// </summary>
		protected RFieldArray<RField> r_saAbbrevEraNames;
		public virtual RFieldArray<RField> RsaAbbrevEraNames
		{
			get
			{
				if(r_saAbbrevEraNames == null)
				{
					r_saAbbrevEraNames = new(this, "saAbbrevEraNames");
					r_saAbbrevEraNames.SetBelong(this.instance);
				}
				return r_saAbbrevEraNames;
			}
		}

		/// <summary>
		/// System.String[] saAbbrevEnglishEraNames
		/// </summary>
		protected RFieldArray<RField> r_saAbbrevEnglishEraNames;
		public virtual RFieldArray<RField> RsaAbbrevEnglishEraNames
		{
			get
			{
				if(r_saAbbrevEnglishEraNames == null)
				{
					r_saAbbrevEnglishEraNames = new(this, "saAbbrevEnglishEraNames");
					r_saAbbrevEnglishEraNames.SetBelong(this.instance);
				}
				return r_saAbbrevEnglishEraNames;
			}
		}

		/// <summary>
		/// System.String[] saDayNames
		/// </summary>
		protected RFieldArray<RField> r_saDayNames;
		public virtual RFieldArray<RField> RsaDayNames
		{
			get
			{
				if(r_saDayNames == null)
				{
					r_saDayNames = new(this, "saDayNames");
					r_saDayNames.SetBelong(this.instance);
				}
				return r_saDayNames;
			}
		}

		/// <summary>
		/// System.String[] saAbbrevDayNames
		/// </summary>
		protected RFieldArray<RField> r_saAbbrevDayNames;
		public virtual RFieldArray<RField> RsaAbbrevDayNames
		{
			get
			{
				if(r_saAbbrevDayNames == null)
				{
					r_saAbbrevDayNames = new(this, "saAbbrevDayNames");
					r_saAbbrevDayNames.SetBelong(this.instance);
				}
				return r_saAbbrevDayNames;
			}
		}

		/// <summary>
		/// System.String[] saSuperShortDayNames
		/// </summary>
		protected RFieldArray<RField> r_saSuperShortDayNames;
		public virtual RFieldArray<RField> RsaSuperShortDayNames
		{
			get
			{
				if(r_saSuperShortDayNames == null)
				{
					r_saSuperShortDayNames = new(this, "saSuperShortDayNames");
					r_saSuperShortDayNames.SetBelong(this.instance);
				}
				return r_saSuperShortDayNames;
			}
		}

		/// <summary>
		/// System.String[] saMonthNames
		/// </summary>
		protected RFieldArray<RField> r_saMonthNames;
		public virtual RFieldArray<RField> RsaMonthNames
		{
			get
			{
				if(r_saMonthNames == null)
				{
					r_saMonthNames = new(this, "saMonthNames");
					r_saMonthNames.SetBelong(this.instance);
				}
				return r_saMonthNames;
			}
		}

		/// <summary>
		/// System.String[] saAbbrevMonthNames
		/// </summary>
		protected RFieldArray<RField> r_saAbbrevMonthNames;
		public virtual RFieldArray<RField> RsaAbbrevMonthNames
		{
			get
			{
				if(r_saAbbrevMonthNames == null)
				{
					r_saAbbrevMonthNames = new(this, "saAbbrevMonthNames");
					r_saAbbrevMonthNames.SetBelong(this.instance);
				}
				return r_saAbbrevMonthNames;
			}
		}

		/// <summary>
		/// System.String[] saMonthGenitiveNames
		/// </summary>
		protected RFieldArray<RField> r_saMonthGenitiveNames;
		public virtual RFieldArray<RField> RsaMonthGenitiveNames
		{
			get
			{
				if(r_saMonthGenitiveNames == null)
				{
					r_saMonthGenitiveNames = new(this, "saMonthGenitiveNames");
					r_saMonthGenitiveNames.SetBelong(this.instance);
				}
				return r_saMonthGenitiveNames;
			}
		}

		/// <summary>
		/// System.String[] saAbbrevMonthGenitiveNames
		/// </summary>
		protected RFieldArray<RField> r_saAbbrevMonthGenitiveNames;
		public virtual RFieldArray<RField> RsaAbbrevMonthGenitiveNames
		{
			get
			{
				if(r_saAbbrevMonthGenitiveNames == null)
				{
					r_saAbbrevMonthGenitiveNames = new(this, "saAbbrevMonthGenitiveNames");
					r_saAbbrevMonthGenitiveNames.SetBelong(this.instance);
				}
				return r_saAbbrevMonthGenitiveNames;
			}
		}

		/// <summary>
		/// System.String[] saLeapYearMonthNames
		/// </summary>
		protected RFieldArray<RField> r_saLeapYearMonthNames;
		public virtual RFieldArray<RField> RsaLeapYearMonthNames
		{
			get
			{
				if(r_saLeapYearMonthNames == null)
				{
					r_saLeapYearMonthNames = new(this, "saLeapYearMonthNames");
					r_saLeapYearMonthNames.SetBelong(this.instance);
				}
				return r_saLeapYearMonthNames;
			}
		}

		/// <summary>
		/// System.Int32 iTwoDigitYearMax
		/// </summary>
		protected RField r_iTwoDigitYearMax;
		public virtual RField RiTwoDigitYearMax
		{
			get
			{
				if(r_iTwoDigitYearMax == null)
				{
					r_iTwoDigitYearMax = new(this, "iTwoDigitYearMax");
					r_iTwoDigitYearMax.SetBelong(this.instance);
				}
				return r_iTwoDigitYearMax;
			}
		}

		/// <summary>
		/// System.Int32 iCurrentEra
		/// </summary>
		protected RField r_iCurrentEra;
		public virtual RField RiCurrentEra
		{
			get
			{
				if(r_iCurrentEra == null)
				{
					r_iCurrentEra = new(this, "iCurrentEra");
					r_iCurrentEra.SetBelong(this.instance);
				}
				return r_iCurrentEra;
			}
		}

		/// <summary>
		/// System.Boolean bUseUserOverrides
		/// </summary>
		protected RField r_bUseUserOverrides;
		public virtual RField RbUseUserOverrides
		{
			get
			{
				if(r_bUseUserOverrides == null)
				{
					r_bUseUserOverrides = new(this, "bUseUserOverrides");
					r_bUseUserOverrides.SetBelong(this.instance);
				}
				return r_bUseUserOverrides;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarData Invariant
		/// </summary>
		protected static RSystem.RGlobalization.RCalendarData r_Invariant;
		public static RSystem.RGlobalization.RCalendarData RInvariant
		{
			get
			{
				if(r_Invariant == null)
				{
					r_Invariant = new( ReflectionUtils.GetType("System.Globalization.CalendarData"), "Invariant");
					r_Invariant.SetBelong(null);
				}
				return r_Invariant;
			}
		}

		/// <summary>
		/// System.String[] HEBREW_MONTH_NAMES
		/// </summary>
		protected static RFieldArray<RField> r_HEBREW_MONTH_NAMES;
		public static RFieldArray<RField> RHEBREW_MONTH_NAMES
		{
			get
			{
				if(r_HEBREW_MONTH_NAMES == null)
				{
					r_HEBREW_MONTH_NAMES = new( ReflectionUtils.GetType("System.Globalization.CalendarData"), "HEBREW_MONTH_NAMES");
					r_HEBREW_MONTH_NAMES.SetBelong(null);
				}
				return r_HEBREW_MONTH_NAMES;
			}
		}

		/// <summary>
		/// System.String[] HEBREW_LEAP_MONTH_NAMES
		/// </summary>
		protected static RFieldArray<RField> r_HEBREW_LEAP_MONTH_NAMES;
		public static RFieldArray<RField> RHEBREW_LEAP_MONTH_NAMES
		{
			get
			{
				if(r_HEBREW_LEAP_MONTH_NAMES == null)
				{
					r_HEBREW_LEAP_MONTH_NAMES = new( ReflectionUtils.GetType("System.Globalization.CalendarData"), "HEBREW_LEAP_MONTH_NAMES");
					r_HEBREW_LEAP_MONTH_NAMES.SetBelong(null);
				}
				return r_HEBREW_LEAP_MONTH_NAMES;
			}
		}

		/// <summary>
		/// Void InitializeEraNames(System.String, Int32)
		/// </summary>
		protected RMethod r_InitializeEraNames_String_Int32;
		public virtual RMethod RInitializeEraNames_String_Int32
		{
			get
			{
				if(r_InitializeEraNames_String_Int32 == null)
				{
					r_InitializeEraNames_String_Int32 = new(this, "InitializeEraNames", 0, typeof(System.String), typeof(System.Int32));
					r_InitializeEraNames_String_Int32.SetBelong(this.instance);
				}
				return r_InitializeEraNames_String_Int32;
			}
		}

		/// <summary>
		/// System.String[] GetJapaneseEraNames()
		/// </summary>
		protected static RMethod r_GetJapaneseEraNames;
		public static RMethod RGetJapaneseEraNames
		{
			get
			{
				if(r_GetJapaneseEraNames == null)
				{
					r_GetJapaneseEraNames = new( ReflectionUtils.GetType("System.Globalization.CalendarData"), "GetJapaneseEraNames", 0);
					r_GetJapaneseEraNames.SetBelong(null);
				}
				return r_GetJapaneseEraNames;
			}
		}

		/// <summary>
		/// System.String[] GetJapaneseEnglishEraNames()
		/// </summary>
		protected static RMethod r_GetJapaneseEnglishEraNames;
		public static RMethod RGetJapaneseEnglishEraNames
		{
			get
			{
				if(r_GetJapaneseEnglishEraNames == null)
				{
					r_GetJapaneseEnglishEraNames = new( ReflectionUtils.GetType("System.Globalization.CalendarData"), "GetJapaneseEnglishEraNames", 0);
					r_GetJapaneseEnglishEraNames.SetBelong(null);
				}
				return r_GetJapaneseEnglishEraNames;
			}
		}

		/// <summary>
		/// Void InitializeAbbreviatedEraNames(System.String, Int32)
		/// </summary>
		protected RMethod r_InitializeAbbreviatedEraNames_String_Int32;
		public virtual RMethod RInitializeAbbreviatedEraNames_String_Int32
		{
			get
			{
				if(r_InitializeAbbreviatedEraNames_String_Int32 == null)
				{
					r_InitializeAbbreviatedEraNames_String_Int32 = new(this, "InitializeAbbreviatedEraNames", 0, typeof(System.String), typeof(System.Int32));
					r_InitializeAbbreviatedEraNames_String_Int32.SetBelong(this.instance);
				}
				return r_InitializeAbbreviatedEraNames_String_Int32;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarData GetCalendarData(Int32)
		/// </summary>
		protected static RMethod r_GetCalendarData_Int32;
		public static RMethod RGetCalendarData_Int32
		{
			get
			{
				if(r_GetCalendarData_Int32 == null)
				{
					r_GetCalendarData_Int32 = new( ReflectionUtils.GetType("System.Globalization.CalendarData"), "GetCalendarData", 0, typeof(System.Int32));
					r_GetCalendarData_Int32.SetBelong(null);
				}
				return r_GetCalendarData_Int32;
			}
		}

		/// <summary>
		/// System.String CalendarIdToCultureName(Int32)
		/// </summary>
		protected static RMethod r_CalendarIdToCultureName_Int32;
		public static RMethod RCalendarIdToCultureName_Int32
		{
			get
			{
				if(r_CalendarIdToCultureName_Int32 == null)
				{
					r_CalendarIdToCultureName_Int32 = new( ReflectionUtils.GetType("System.Globalization.CalendarData"), "CalendarIdToCultureName", 0, typeof(System.Int32));
					r_CalendarIdToCultureName_Int32.SetBelong(null);
				}
				return r_CalendarIdToCultureName_Int32;
			}
		}

		/// <summary>
		/// Int32 nativeGetTwoDigitYearMax(Int32)
		/// </summary>
		protected static RMethod r_nativeGetTwoDigitYearMax_Int32;
		public static RMethod RnativeGetTwoDigitYearMax_Int32
		{
			get
			{
				if(r_nativeGetTwoDigitYearMax_Int32 == null)
				{
					r_nativeGetTwoDigitYearMax_Int32 = new( ReflectionUtils.GetType("System.Globalization.CalendarData"), "nativeGetTwoDigitYearMax", 0, typeof(System.Int32));
					r_nativeGetTwoDigitYearMax_Int32.SetBelong(null);
				}
				return r_nativeGetTwoDigitYearMax_Int32;
			}
		}

		/// <summary>
		/// Boolean nativeGetCalendarData(System.Globalization.CalendarData, System.String, Int32)
		/// </summary>
		protected static RMethod r_nativeGetCalendarData_CalendarData_String_Int32;
		public static RMethod RnativeGetCalendarData_CalendarData_String_Int32
		{
			get
			{
				if(r_nativeGetCalendarData_CalendarData_String_Int32 == null)
				{
					r_nativeGetCalendarData_CalendarData_String_Int32 = new( ReflectionUtils.GetType("System.Globalization.CalendarData"), "nativeGetCalendarData", 0,  ReflectionUtils.GetType("System.Globalization.CalendarData"), typeof(System.String), typeof(System.Int32));
					r_nativeGetCalendarData_CalendarData_String_Int32.SetBelong(null);
				}
				return r_nativeGetCalendarData_CalendarData_String_Int32;
			}
		}

		/// <summary>
		/// Boolean fill_calendar_data(System.String, Int32)
		/// </summary>
		protected RMethod r_fill_calendar_data_String_Int32;
		public virtual RMethod Rfill_calendar_data_String_Int32
		{
			get
			{
				if(r_fill_calendar_data_String_Int32 == null)
				{
					r_fill_calendar_data_String_Int32 = new(this, "fill_calendar_data", 0, typeof(System.String), typeof(System.Int32));
					r_fill_calendar_data_String_Int32.SetBelong(this.instance);
				}
				return r_fill_calendar_data_String_Int32;
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


        public RCalendarData() : base("System.Globalization.CalendarData")
        {
        }

        public RCalendarData(System.Object instance) : base("System.Globalization.CalendarData")
		{
            SetInstance(instance);
		}

        public RCalendarData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCalendarData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void InitializeEraNames(System.String  @localeName, System.Int32  @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localeName, @calendarId};
            var ___result = RInitializeEraNames_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.String[] GetJapaneseEraNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetJapaneseEraNames.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public static System.String[] GetJapaneseEnglishEraNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetJapaneseEnglishEraNames.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual void InitializeAbbreviatedEraNames(System.String  @localeName, System.Int32  @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localeName, @calendarId};
            var ___result = RInitializeAbbreviatedEraNames_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Object GetCalendarData(System.Int32  @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RGetCalendarData_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.String CalendarIdToCultureName(System.Int32  @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RCalendarIdToCultureName_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Int32 nativeGetTwoDigitYearMax(System.Int32  @calID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calID};
            var ___result = RnativeGetTwoDigitYearMax_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }



        public virtual System.Boolean fill_calendar_data(System.String  @localeName, System.Int32  @datetimeIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localeName, @datetimeIndex};
            var ___result = Rfill_calendar_data_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
