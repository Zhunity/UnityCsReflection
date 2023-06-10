
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RGlobalization
{
	/// <summary>
	/// System.Globalization.CalendarData
	/// </summary>
    public partial class RCalendarData : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Globalization.CalendarData");
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


		/// <summary>
		/// System.Int32 MAX_CALENDARS
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FMAX_CALENDARS;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFMAX_CALENDARS
		{
			get
			{
				if(r_FMAX_CALENDARS == null)
				{
					r_FMAX_CALENDARS = new( ReflectionUtils.GetType("System.Globalization.CalendarData"), "MAX_CALENDARS");
				}
				return r_FMAX_CALENDARS;
			}
		}

		/// <summary>
		/// System.String sNativeName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FsNativeName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFsNativeName
		{
			get
			{
				if(r_FsNativeName == null)
				{
					r_FsNativeName = new(this, "sNativeName");
				}
				return r_FsNativeName;
			}
		}

		/// <summary>
		/// System.String[] saShortDates
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FsaShortDates;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFsaShortDates
		{
			get
			{
				if(r_FsaShortDates == null)
				{
					r_FsaShortDates = new(this, "saShortDates");
				}
				return r_FsaShortDates;
			}
		}

		/// <summary>
		/// System.String[] saYearMonths
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FsaYearMonths;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFsaYearMonths
		{
			get
			{
				if(r_FsaYearMonths == null)
				{
					r_FsaYearMonths = new(this, "saYearMonths");
				}
				return r_FsaYearMonths;
			}
		}

		/// <summary>
		/// System.String[] saLongDates
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FsaLongDates;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFsaLongDates
		{
			get
			{
				if(r_FsaLongDates == null)
				{
					r_FsaLongDates = new(this, "saLongDates");
				}
				return r_FsaLongDates;
			}
		}

		/// <summary>
		/// System.String sMonthDay
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FsMonthDay;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFsMonthDay
		{
			get
			{
				if(r_FsMonthDay == null)
				{
					r_FsMonthDay = new(this, "sMonthDay");
				}
				return r_FsMonthDay;
			}
		}

		/// <summary>
		/// System.String[] saEraNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FsaEraNames;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFsaEraNames
		{
			get
			{
				if(r_FsaEraNames == null)
				{
					r_FsaEraNames = new(this, "saEraNames");
				}
				return r_FsaEraNames;
			}
		}

		/// <summary>
		/// System.String[] saAbbrevEraNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FsaAbbrevEraNames;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFsaAbbrevEraNames
		{
			get
			{
				if(r_FsaAbbrevEraNames == null)
				{
					r_FsaAbbrevEraNames = new(this, "saAbbrevEraNames");
				}
				return r_FsaAbbrevEraNames;
			}
		}

		/// <summary>
		/// System.String[] saAbbrevEnglishEraNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FsaAbbrevEnglishEraNames;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFsaAbbrevEnglishEraNames
		{
			get
			{
				if(r_FsaAbbrevEnglishEraNames == null)
				{
					r_FsaAbbrevEnglishEraNames = new(this, "saAbbrevEnglishEraNames");
				}
				return r_FsaAbbrevEnglishEraNames;
			}
		}

		/// <summary>
		/// System.String[] saDayNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FsaDayNames;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFsaDayNames
		{
			get
			{
				if(r_FsaDayNames == null)
				{
					r_FsaDayNames = new(this, "saDayNames");
				}
				return r_FsaDayNames;
			}
		}

		/// <summary>
		/// System.String[] saAbbrevDayNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FsaAbbrevDayNames;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFsaAbbrevDayNames
		{
			get
			{
				if(r_FsaAbbrevDayNames == null)
				{
					r_FsaAbbrevDayNames = new(this, "saAbbrevDayNames");
				}
				return r_FsaAbbrevDayNames;
			}
		}

		/// <summary>
		/// System.String[] saSuperShortDayNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FsaSuperShortDayNames;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFsaSuperShortDayNames
		{
			get
			{
				if(r_FsaSuperShortDayNames == null)
				{
					r_FsaSuperShortDayNames = new(this, "saSuperShortDayNames");
				}
				return r_FsaSuperShortDayNames;
			}
		}

		/// <summary>
		/// System.String[] saMonthNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FsaMonthNames;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFsaMonthNames
		{
			get
			{
				if(r_FsaMonthNames == null)
				{
					r_FsaMonthNames = new(this, "saMonthNames");
				}
				return r_FsaMonthNames;
			}
		}

		/// <summary>
		/// System.String[] saAbbrevMonthNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FsaAbbrevMonthNames;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFsaAbbrevMonthNames
		{
			get
			{
				if(r_FsaAbbrevMonthNames == null)
				{
					r_FsaAbbrevMonthNames = new(this, "saAbbrevMonthNames");
				}
				return r_FsaAbbrevMonthNames;
			}
		}

		/// <summary>
		/// System.String[] saMonthGenitiveNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FsaMonthGenitiveNames;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFsaMonthGenitiveNames
		{
			get
			{
				if(r_FsaMonthGenitiveNames == null)
				{
					r_FsaMonthGenitiveNames = new(this, "saMonthGenitiveNames");
				}
				return r_FsaMonthGenitiveNames;
			}
		}

		/// <summary>
		/// System.String[] saAbbrevMonthGenitiveNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FsaAbbrevMonthGenitiveNames;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFsaAbbrevMonthGenitiveNames
		{
			get
			{
				if(r_FsaAbbrevMonthGenitiveNames == null)
				{
					r_FsaAbbrevMonthGenitiveNames = new(this, "saAbbrevMonthGenitiveNames");
				}
				return r_FsaAbbrevMonthGenitiveNames;
			}
		}

		/// <summary>
		/// System.String[] saLeapYearMonthNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FsaLeapYearMonthNames;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFsaLeapYearMonthNames
		{
			get
			{
				if(r_FsaLeapYearMonthNames == null)
				{
					r_FsaLeapYearMonthNames = new(this, "saLeapYearMonthNames");
				}
				return r_FsaLeapYearMonthNames;
			}
		}

		/// <summary>
		/// System.Int32 iTwoDigitYearMax
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FiTwoDigitYearMax;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFiTwoDigitYearMax
		{
			get
			{
				if(r_FiTwoDigitYearMax == null)
				{
					r_FiTwoDigitYearMax = new(this, "iTwoDigitYearMax");
				}
				return r_FiTwoDigitYearMax;
			}
		}

		/// <summary>
		/// System.Int32 iCurrentEra
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FiCurrentEra;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFiCurrentEra
		{
			get
			{
				if(r_FiCurrentEra == null)
				{
					r_FiCurrentEra = new(this, "iCurrentEra");
				}
				return r_FiCurrentEra;
			}
		}

		/// <summary>
		/// System.Boolean bUseUserOverrides
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FbUseUserOverrides;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFbUseUserOverrides
		{
			get
			{
				if(r_FbUseUserOverrides == null)
				{
					r_FbUseUserOverrides = new(this, "bUseUserOverrides");
				}
				return r_FbUseUserOverrides;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarData Invariant
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarData r_FInvariant;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarData RFInvariant
		{
			get
			{
				if(r_FInvariant == null)
				{
					r_FInvariant = new( ReflectionUtils.GetType("System.Globalization.CalendarData"), "Invariant");
				}
				return r_FInvariant;
			}
		}

		/// <summary>
		/// System.String[] HEBREW_MONTH_NAMES
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FHEBREW_MONTH_NAMES;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFHEBREW_MONTH_NAMES
		{
			get
			{
				if(r_FHEBREW_MONTH_NAMES == null)
				{
					r_FHEBREW_MONTH_NAMES = new( ReflectionUtils.GetType("System.Globalization.CalendarData"), "HEBREW_MONTH_NAMES");
				}
				return r_FHEBREW_MONTH_NAMES;
			}
		}

		/// <summary>
		/// System.String[] HEBREW_LEAP_MONTH_NAMES
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FHEBREW_LEAP_MONTH_NAMES;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFHEBREW_LEAP_MONTH_NAMES
		{
			get
			{
				if(r_FHEBREW_LEAP_MONTH_NAMES == null)
				{
					r_FHEBREW_LEAP_MONTH_NAMES = new( ReflectionUtils.GetType("System.Globalization.CalendarData"), "HEBREW_LEAP_MONTH_NAMES");
				}
				return r_FHEBREW_LEAP_MONTH_NAMES;
			}
		}

		/// <summary>
		/// Void InitializeEraNames(System.String, Int32)
		/// </summary>
		protected RMethod r_MInitializeEraNames_String_Int32;
		public virtual RMethod RMInitializeEraNames_String_Int32
		{
			get
			{
				if(r_MInitializeEraNames_String_Int32 == null)
				{
					r_MInitializeEraNames_String_Int32 = new(this, "InitializeEraNames", 0, typeof(System.String), typeof(System.Int32));
				}
				return r_MInitializeEraNames_String_Int32;
			}
		}

		/// <summary>
		/// System.String[] GetJapaneseEraNames()
		/// </summary>
		protected static RMethod r_MGetJapaneseEraNames;
		public static RMethod RMGetJapaneseEraNames
		{
			get
			{
				if(r_MGetJapaneseEraNames == null)
				{
					r_MGetJapaneseEraNames = new( ReflectionUtils.GetType("System.Globalization.CalendarData"), "GetJapaneseEraNames", 0);
				}
				return r_MGetJapaneseEraNames;
			}
		}

		/// <summary>
		/// System.String[] GetJapaneseEnglishEraNames()
		/// </summary>
		protected static RMethod r_MGetJapaneseEnglishEraNames;
		public static RMethod RMGetJapaneseEnglishEraNames
		{
			get
			{
				if(r_MGetJapaneseEnglishEraNames == null)
				{
					r_MGetJapaneseEnglishEraNames = new( ReflectionUtils.GetType("System.Globalization.CalendarData"), "GetJapaneseEnglishEraNames", 0);
				}
				return r_MGetJapaneseEnglishEraNames;
			}
		}

		/// <summary>
		/// Void InitializeAbbreviatedEraNames(System.String, Int32)
		/// </summary>
		protected RMethod r_MInitializeAbbreviatedEraNames_String_Int32;
		public virtual RMethod RMInitializeAbbreviatedEraNames_String_Int32
		{
			get
			{
				if(r_MInitializeAbbreviatedEraNames_String_Int32 == null)
				{
					r_MInitializeAbbreviatedEraNames_String_Int32 = new(this, "InitializeAbbreviatedEraNames", 0, typeof(System.String), typeof(System.Int32));
				}
				return r_MInitializeAbbreviatedEraNames_String_Int32;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarData GetCalendarData(Int32)
		/// </summary>
		protected static RMethod r_MGetCalendarData_Int32;
		public static RMethod RMGetCalendarData_Int32
		{
			get
			{
				if(r_MGetCalendarData_Int32 == null)
				{
					r_MGetCalendarData_Int32 = new( ReflectionUtils.GetType("System.Globalization.CalendarData"), "GetCalendarData", 0, typeof(System.Int32));
				}
				return r_MGetCalendarData_Int32;
			}
		}

		/// <summary>
		/// System.String CalendarIdToCultureName(Int32)
		/// </summary>
		protected static RMethod r_MCalendarIdToCultureName_Int32;
		public static RMethod RMCalendarIdToCultureName_Int32
		{
			get
			{
				if(r_MCalendarIdToCultureName_Int32 == null)
				{
					r_MCalendarIdToCultureName_Int32 = new( ReflectionUtils.GetType("System.Globalization.CalendarData"), "CalendarIdToCultureName", 0, typeof(System.Int32));
				}
				return r_MCalendarIdToCultureName_Int32;
			}
		}

		/// <summary>
		/// Int32 nativeGetTwoDigitYearMax(Int32)
		/// </summary>
		protected static RMethod r_MnativeGetTwoDigitYearMax_Int32;
		public static RMethod RMnativeGetTwoDigitYearMax_Int32
		{
			get
			{
				if(r_MnativeGetTwoDigitYearMax_Int32 == null)
				{
					r_MnativeGetTwoDigitYearMax_Int32 = new( ReflectionUtils.GetType("System.Globalization.CalendarData"), "nativeGetTwoDigitYearMax", 0, typeof(System.Int32));
				}
				return r_MnativeGetTwoDigitYearMax_Int32;
			}
		}

		/// <summary>
		/// Boolean nativeGetCalendarData(System.Globalization.CalendarData, System.String, Int32)
		/// </summary>
		protected static RMethod r_MnativeGetCalendarData_CalendarData_String_Int32;
		public static RMethod RMnativeGetCalendarData_CalendarData_String_Int32
		{
			get
			{
				if(r_MnativeGetCalendarData_CalendarData_String_Int32 == null)
				{
					r_MnativeGetCalendarData_CalendarData_String_Int32 = new( ReflectionUtils.GetType("System.Globalization.CalendarData"), "nativeGetCalendarData", 0,  ReflectionUtils.GetType("System.Globalization.CalendarData"), typeof(System.String), typeof(System.Int32));
				}
				return r_MnativeGetCalendarData_CalendarData_String_Int32;
			}
		}

		/// <summary>
		/// Boolean fill_calendar_data(System.String, Int32)
		/// </summary>
		protected RMethod r_Mfill_calendar_data_String_Int32;
		public virtual RMethod RMfill_calendar_data_String_Int32
		{
			get
			{
				if(r_Mfill_calendar_data_String_Int32 == null)
				{
					r_Mfill_calendar_data_String_Int32 = new(this, "fill_calendar_data", 0, typeof(System.String), typeof(System.Int32));
				}
				return r_Mfill_calendar_data_String_Int32;
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


        public virtual void InitializeEraNames(System.String @localeName, System.Int32 @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localeName, @calendarId};
            var ___result = RMInitializeEraNames_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.String[] GetJapaneseEraNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetJapaneseEraNames.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public static System.String[] GetJapaneseEnglishEraNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetJapaneseEnglishEraNames.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual void InitializeAbbreviatedEraNames(System.String @localeName, System.Int32 @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localeName, @calendarId};
            var ___result = RMInitializeAbbreviatedEraNames_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarData GetCalendarData(System.Int32 @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RMGetCalendarData_Int32.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarData(___result);
        }


        public static System.String CalendarIdToCultureName(System.Int32 @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RMCalendarIdToCultureName_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Int32 nativeGetTwoDigitYearMax(System.Int32 @calID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calID};
            var ___result = RMnativeGetTwoDigitYearMax_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean nativeGetCalendarData(Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarData @data, System.String @localeName, System.Int32 @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data.Value, @localeName, @calendarId};
            var ___result = RMnativeGetCalendarData_CalendarData_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean fill_calendar_data(System.String @localeName, System.Int32 @datetimeIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localeName, @datetimeIndex};
            var ___result = RMfill_calendar_data_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
