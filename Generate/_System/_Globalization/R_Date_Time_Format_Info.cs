
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RGlobalization
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Globalization.DateTimeFormatInfo
	/// </summary>
    public partial class RDateTimeFormatInfo : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Globalization.DateTimeFormatInfo);
            }
        }

        public RDateTimeFormatInfo() : base("System.Globalization.DateTimeFormatInfo")
        {
        }

        public RDateTimeFormatInfo(System.Object instance) : base("System.Globalization.DateTimeFormatInfo")
		{
            SetInstance(instance);
		}

        public RDateTimeFormatInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDateTimeFormatInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Globalization.DateTimeFormatInfo s_invariantInfo
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RDateTimeFormatInfo r_Fs_invariantInfo;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RDateTimeFormatInfo RFs_invariantInfo
		{
			get
			{
				if(r_Fs_invariantInfo == null)
				{
					r_Fs_invariantInfo = new(Type, "s_invariantInfo");
				}
				return r_Fs_invariantInfo;
			}
		}

		/// <summary>
		/// System.Globalization.CultureData _cultureData
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureData r_F_cultureData;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureData RF_cultureData
		{
			get
			{
				if(r_F_cultureData == null)
				{
					r_F_cultureData = new(this, "_cultureData");
				}
				return r_F_cultureData;
			}
		}

		/// <summary>
		/// System.String _name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F_name;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF_name
		{
			get
			{
				if(r_F_name == null)
				{
					r_F_name = new(this, "_name");
				}
				return r_F_name;
			}
		}

		/// <summary>
		/// System.String _langName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F_langName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF_langName
		{
			get
			{
				if(r_F_langName == null)
				{
					r_F_langName = new(this, "_langName");
				}
				return r_F_langName;
			}
		}

		/// <summary>
		/// System.Globalization.CompareInfo _compareInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RCompareInfo r_F_compareInfo;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RCompareInfo RF_compareInfo
		{
			get
			{
				if(r_F_compareInfo == null)
				{
					r_F_compareInfo = new(this, "_compareInfo");
				}
				return r_F_compareInfo;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo _cultureInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo r_F_cultureInfo;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo RF_cultureInfo
		{
			get
			{
				if(r_F_cultureInfo == null)
				{
					r_F_cultureInfo = new(this, "_cultureInfo");
				}
				return r_F_cultureInfo;
			}
		}

		/// <summary>
		/// System.String amDesignator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FamDesignator;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFamDesignator
		{
			get
			{
				if(r_FamDesignator == null)
				{
					r_FamDesignator = new(this, "amDesignator");
				}
				return r_FamDesignator;
			}
		}

		/// <summary>
		/// System.String pmDesignator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FpmDesignator;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFpmDesignator
		{
			get
			{
				if(r_FpmDesignator == null)
				{
					r_FpmDesignator = new(this, "pmDesignator");
				}
				return r_FpmDesignator;
			}
		}

		/// <summary>
		/// System.String dateSeparator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FdateSeparator;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFdateSeparator
		{
			get
			{
				if(r_FdateSeparator == null)
				{
					r_FdateSeparator = new(this, "dateSeparator");
				}
				return r_FdateSeparator;
			}
		}

		/// <summary>
		/// System.String generalShortTimePattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FgeneralShortTimePattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFgeneralShortTimePattern
		{
			get
			{
				if(r_FgeneralShortTimePattern == null)
				{
					r_FgeneralShortTimePattern = new(this, "generalShortTimePattern");
				}
				return r_FgeneralShortTimePattern;
			}
		}

		/// <summary>
		/// System.String generalLongTimePattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FgeneralLongTimePattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFgeneralLongTimePattern
		{
			get
			{
				if(r_FgeneralLongTimePattern == null)
				{
					r_FgeneralLongTimePattern = new(this, "generalLongTimePattern");
				}
				return r_FgeneralLongTimePattern;
			}
		}

		/// <summary>
		/// System.String timeSeparator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FtimeSeparator;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFtimeSeparator
		{
			get
			{
				if(r_FtimeSeparator == null)
				{
					r_FtimeSeparator = new(this, "timeSeparator");
				}
				return r_FtimeSeparator;
			}
		}

		/// <summary>
		/// System.String monthDayPattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FmonthDayPattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFmonthDayPattern
		{
			get
			{
				if(r_FmonthDayPattern == null)
				{
					r_FmonthDayPattern = new(this, "monthDayPattern");
				}
				return r_FmonthDayPattern;
			}
		}

		/// <summary>
		/// System.String dateTimeOffsetPattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FdateTimeOffsetPattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFdateTimeOffsetPattern
		{
			get
			{
				if(r_FdateTimeOffsetPattern == null)
				{
					r_FdateTimeOffsetPattern = new(this, "dateTimeOffsetPattern");
				}
				return r_FdateTimeOffsetPattern;
			}
		}

		/// <summary>
		/// System.String rfc1123Pattern
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Frfc1123Pattern;
		public static Hvak.Editor.Refleaction.RSystem.RString RFrfc1123Pattern
		{
			get
			{
				if(r_Frfc1123Pattern == null)
				{
					r_Frfc1123Pattern = new(Type, "rfc1123Pattern");
				}
				return r_Frfc1123Pattern;
			}
		}

		/// <summary>
		/// System.String sortableDateTimePattern
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FsortableDateTimePattern;
		public static Hvak.Editor.Refleaction.RSystem.RString RFsortableDateTimePattern
		{
			get
			{
				if(r_FsortableDateTimePattern == null)
				{
					r_FsortableDateTimePattern = new(Type, "sortableDateTimePattern");
				}
				return r_FsortableDateTimePattern;
			}
		}

		/// <summary>
		/// System.String universalSortableDateTimePattern
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FuniversalSortableDateTimePattern;
		public static Hvak.Editor.Refleaction.RSystem.RString RFuniversalSortableDateTimePattern
		{
			get
			{
				if(r_FuniversalSortableDateTimePattern == null)
				{
					r_FuniversalSortableDateTimePattern = new(Type, "universalSortableDateTimePattern");
				}
				return r_FuniversalSortableDateTimePattern;
			}
		}

		/// <summary>
		/// System.Globalization.Calendar calendar
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendar r_Fcalendar;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendar RFcalendar
		{
			get
			{
				if(r_Fcalendar == null)
				{
					r_Fcalendar = new(this, "calendar");
				}
				return r_Fcalendar;
			}
		}

		/// <summary>
		/// System.Int32 firstDayOfWeek
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FfirstDayOfWeek;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFfirstDayOfWeek
		{
			get
			{
				if(r_FfirstDayOfWeek == null)
				{
					r_FfirstDayOfWeek = new(this, "firstDayOfWeek");
				}
				return r_FfirstDayOfWeek;
			}
		}

		/// <summary>
		/// System.Int32 calendarWeekRule
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FcalendarWeekRule;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFcalendarWeekRule
		{
			get
			{
				if(r_FcalendarWeekRule == null)
				{
					r_FcalendarWeekRule = new(this, "calendarWeekRule");
				}
				return r_FcalendarWeekRule;
			}
		}

		/// <summary>
		/// System.String fullDateTimePattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FfullDateTimePattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFfullDateTimePattern
		{
			get
			{
				if(r_FfullDateTimePattern == null)
				{
					r_FfullDateTimePattern = new(this, "fullDateTimePattern");
				}
				return r_FfullDateTimePattern;
			}
		}

		/// <summary>
		/// System.String[] abbreviatedDayNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FabbreviatedDayNames;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFabbreviatedDayNames
		{
			get
			{
				if(r_FabbreviatedDayNames == null)
				{
					r_FabbreviatedDayNames = new(this, "abbreviatedDayNames");
				}
				return r_FabbreviatedDayNames;
			}
		}

		/// <summary>
		/// System.String[] m_superShortDayNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_superShortDayNames;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFm_superShortDayNames
		{
			get
			{
				if(r_Fm_superShortDayNames == null)
				{
					r_Fm_superShortDayNames = new(this, "m_superShortDayNames");
				}
				return r_Fm_superShortDayNames;
			}
		}

		/// <summary>
		/// System.String[] dayNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FdayNames;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFdayNames
		{
			get
			{
				if(r_FdayNames == null)
				{
					r_FdayNames = new(this, "dayNames");
				}
				return r_FdayNames;
			}
		}

		/// <summary>
		/// System.String[] abbreviatedMonthNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FabbreviatedMonthNames;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFabbreviatedMonthNames
		{
			get
			{
				if(r_FabbreviatedMonthNames == null)
				{
					r_FabbreviatedMonthNames = new(this, "abbreviatedMonthNames");
				}
				return r_FabbreviatedMonthNames;
			}
		}

		/// <summary>
		/// System.String[] monthNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FmonthNames;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFmonthNames
		{
			get
			{
				if(r_FmonthNames == null)
				{
					r_FmonthNames = new(this, "monthNames");
				}
				return r_FmonthNames;
			}
		}

		/// <summary>
		/// System.String[] genitiveMonthNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FgenitiveMonthNames;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFgenitiveMonthNames
		{
			get
			{
				if(r_FgenitiveMonthNames == null)
				{
					r_FgenitiveMonthNames = new(this, "genitiveMonthNames");
				}
				return r_FgenitiveMonthNames;
			}
		}

		/// <summary>
		/// System.String[] m_genitiveAbbreviatedMonthNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_genitiveAbbreviatedMonthNames;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFm_genitiveAbbreviatedMonthNames
		{
			get
			{
				if(r_Fm_genitiveAbbreviatedMonthNames == null)
				{
					r_Fm_genitiveAbbreviatedMonthNames = new(this, "m_genitiveAbbreviatedMonthNames");
				}
				return r_Fm_genitiveAbbreviatedMonthNames;
			}
		}

		/// <summary>
		/// System.String[] leapYearMonthNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FleapYearMonthNames;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFleapYearMonthNames
		{
			get
			{
				if(r_FleapYearMonthNames == null)
				{
					r_FleapYearMonthNames = new(this, "leapYearMonthNames");
				}
				return r_FleapYearMonthNames;
			}
		}

		/// <summary>
		/// System.String longDatePattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FlongDatePattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFlongDatePattern
		{
			get
			{
				if(r_FlongDatePattern == null)
				{
					r_FlongDatePattern = new(this, "longDatePattern");
				}
				return r_FlongDatePattern;
			}
		}

		/// <summary>
		/// System.String shortDatePattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FshortDatePattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFshortDatePattern
		{
			get
			{
				if(r_FshortDatePattern == null)
				{
					r_FshortDatePattern = new(this, "shortDatePattern");
				}
				return r_FshortDatePattern;
			}
		}

		/// <summary>
		/// System.String yearMonthPattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FyearMonthPattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFyearMonthPattern
		{
			get
			{
				if(r_FyearMonthPattern == null)
				{
					r_FyearMonthPattern = new(this, "yearMonthPattern");
				}
				return r_FyearMonthPattern;
			}
		}

		/// <summary>
		/// System.String longTimePattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FlongTimePattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFlongTimePattern
		{
			get
			{
				if(r_FlongTimePattern == null)
				{
					r_FlongTimePattern = new(this, "longTimePattern");
				}
				return r_FlongTimePattern;
			}
		}

		/// <summary>
		/// System.String shortTimePattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FshortTimePattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFshortTimePattern
		{
			get
			{
				if(r_FshortTimePattern == null)
				{
					r_FshortTimePattern = new(this, "shortTimePattern");
				}
				return r_FshortTimePattern;
			}
		}

		/// <summary>
		/// System.String[] allYearMonthPatterns
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FallYearMonthPatterns;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFallYearMonthPatterns
		{
			get
			{
				if(r_FallYearMonthPatterns == null)
				{
					r_FallYearMonthPatterns = new(this, "allYearMonthPatterns");
				}
				return r_FallYearMonthPatterns;
			}
		}

		/// <summary>
		/// System.String[] allShortDatePatterns
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FallShortDatePatterns;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFallShortDatePatterns
		{
			get
			{
				if(r_FallShortDatePatterns == null)
				{
					r_FallShortDatePatterns = new(this, "allShortDatePatterns");
				}
				return r_FallShortDatePatterns;
			}
		}

		/// <summary>
		/// System.String[] allLongDatePatterns
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FallLongDatePatterns;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFallLongDatePatterns
		{
			get
			{
				if(r_FallLongDatePatterns == null)
				{
					r_FallLongDatePatterns = new(this, "allLongDatePatterns");
				}
				return r_FallLongDatePatterns;
			}
		}

		/// <summary>
		/// System.String[] allShortTimePatterns
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FallShortTimePatterns;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFallShortTimePatterns
		{
			get
			{
				if(r_FallShortTimePatterns == null)
				{
					r_FallShortTimePatterns = new(this, "allShortTimePatterns");
				}
				return r_FallShortTimePatterns;
			}
		}

		/// <summary>
		/// System.String[] allLongTimePatterns
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FallLongTimePatterns;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFallLongTimePatterns
		{
			get
			{
				if(r_FallLongTimePatterns == null)
				{
					r_FallLongTimePatterns = new(this, "allLongTimePatterns");
				}
				return r_FallLongTimePatterns;
			}
		}

		/// <summary>
		/// System.String[] m_eraNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_eraNames;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFm_eraNames
		{
			get
			{
				if(r_Fm_eraNames == null)
				{
					r_Fm_eraNames = new(this, "m_eraNames");
				}
				return r_Fm_eraNames;
			}
		}

		/// <summary>
		/// System.String[] m_abbrevEraNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_abbrevEraNames;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFm_abbrevEraNames
		{
			get
			{
				if(r_Fm_abbrevEraNames == null)
				{
					r_Fm_abbrevEraNames = new(this, "m_abbrevEraNames");
				}
				return r_Fm_abbrevEraNames;
			}
		}

		/// <summary>
		/// System.String[] m_abbrevEnglishEraNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_abbrevEnglishEraNames;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFm_abbrevEnglishEraNames
		{
			get
			{
				if(r_Fm_abbrevEnglishEraNames == null)
				{
					r_Fm_abbrevEnglishEraNames = new(this, "m_abbrevEnglishEraNames");
				}
				return r_Fm_abbrevEnglishEraNames;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarId[] optionalCalendars
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId> r_FoptionalCalendars;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId> RFoptionalCalendars
		{
			get
			{
				if(r_FoptionalCalendars == null)
				{
					r_FoptionalCalendars = new(this, "optionalCalendars");
				}
				return r_FoptionalCalendars;
			}
		}

		/// <summary>
		/// System.Int32 DEFAULT_ALL_DATETIMES_SIZE
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FDEFAULT_ALL_DATETIMES_SIZE;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFDEFAULT_ALL_DATETIMES_SIZE
		{
			get
			{
				if(r_FDEFAULT_ALL_DATETIMES_SIZE == null)
				{
					r_FDEFAULT_ALL_DATETIMES_SIZE = new(Type, "DEFAULT_ALL_DATETIMES_SIZE");
				}
				return r_FDEFAULT_ALL_DATETIMES_SIZE;
			}
		}

		/// <summary>
		/// System.Boolean _isReadOnly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F_isReadOnly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF_isReadOnly
		{
			get
			{
				if(r_F_isReadOnly == null)
				{
					r_F_isReadOnly = new(this, "_isReadOnly");
				}
				return r_F_isReadOnly;
			}
		}

		/// <summary>
		/// System.Globalization.DateTimeFormatFlags formatFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RDateTimeFormatFlags r_FformatFlags;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RDateTimeFormatFlags RFformatFlags
		{
			get
			{
				if(r_FformatFlags == null)
				{
					r_FformatFlags = new(this, "formatFlags");
				}
				return r_FformatFlags;
			}
		}

		/// <summary>
		/// System.Char[] s_monthSpaces
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RChar> r_Fs_monthSpaces;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RChar> RFs_monthSpaces
		{
			get
			{
				if(r_Fs_monthSpaces == null)
				{
					r_Fs_monthSpaces = new(Type, "s_monthSpaces");
				}
				return r_Fs_monthSpaces;
			}
		}

		/// <summary>
		/// System.String RoundtripFormat
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FRoundtripFormat;
		public static Hvak.Editor.Refleaction.RSystem.RString RFRoundtripFormat
		{
			get
			{
				if(r_FRoundtripFormat == null)
				{
					r_FRoundtripFormat = new(Type, "RoundtripFormat");
				}
				return r_FRoundtripFormat;
			}
		}

		/// <summary>
		/// System.String RoundtripDateTimeUnfixed
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FRoundtripDateTimeUnfixed;
		public static Hvak.Editor.Refleaction.RSystem.RString RFRoundtripDateTimeUnfixed
		{
			get
			{
				if(r_FRoundtripDateTimeUnfixed == null)
				{
					r_FRoundtripDateTimeUnfixed = new(Type, "RoundtripDateTimeUnfixed");
				}
				return r_FRoundtripDateTimeUnfixed;
			}
		}

		/// <summary>
		/// System.String _fullTimeSpanPositivePattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F_fullTimeSpanPositivePattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF_fullTimeSpanPositivePattern
		{
			get
			{
				if(r_F_fullTimeSpanPositivePattern == null)
				{
					r_F_fullTimeSpanPositivePattern = new(this, "_fullTimeSpanPositivePattern");
				}
				return r_F_fullTimeSpanPositivePattern;
			}
		}

		/// <summary>
		/// System.String _fullTimeSpanNegativePattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F_fullTimeSpanNegativePattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF_fullTimeSpanNegativePattern
		{
			get
			{
				if(r_F_fullTimeSpanNegativePattern == null)
				{
					r_F_fullTimeSpanNegativePattern = new(this, "_fullTimeSpanNegativePattern");
				}
				return r_F_fullTimeSpanNegativePattern;
			}
		}

		/// <summary>
		/// System.Globalization.DateTimeStyles InvalidDateTimeStyles
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RDateTimeStyles r_FInvalidDateTimeStyles;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RDateTimeStyles RFInvalidDateTimeStyles
		{
			get
			{
				if(r_FInvalidDateTimeStyles == null)
				{
					r_FInvalidDateTimeStyles = new(Type, "InvalidDateTimeStyles");
				}
				return r_FInvalidDateTimeStyles;
			}
		}

		/// <summary>
		/// System.Globalization.DateTimeFormatInfo+TokenHashValue[] _dtfiTokenHash
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RGlobalization.RDateTimeFormatInfo.RTokenHashValue> r_F_dtfiTokenHash;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RGlobalization.RDateTimeFormatInfo.RTokenHashValue> RF_dtfiTokenHash
		{
			get
			{
				if(r_F_dtfiTokenHash == null)
				{
					r_F_dtfiTokenHash = new(this, "_dtfiTokenHash");
				}
				return r_F_dtfiTokenHash;
			}
		}

		/// <summary>
		/// System.Int32 TOKEN_HASH_SIZE
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FTOKEN_HASH_SIZE;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFTOKEN_HASH_SIZE
		{
			get
			{
				if(r_FTOKEN_HASH_SIZE == null)
				{
					r_FTOKEN_HASH_SIZE = new(Type, "TOKEN_HASH_SIZE");
				}
				return r_FTOKEN_HASH_SIZE;
			}
		}

		/// <summary>
		/// System.Int32 SECOND_PRIME
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FSECOND_PRIME;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFSECOND_PRIME
		{
			get
			{
				if(r_FSECOND_PRIME == null)
				{
					r_FSECOND_PRIME = new(Type, "SECOND_PRIME");
				}
				return r_FSECOND_PRIME;
			}
		}

		/// <summary>
		/// System.String dateSeparatorOrTimeZoneOffset
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FdateSeparatorOrTimeZoneOffset;
		public static Hvak.Editor.Refleaction.RSystem.RString RFdateSeparatorOrTimeZoneOffset
		{
			get
			{
				if(r_FdateSeparatorOrTimeZoneOffset == null)
				{
					r_FdateSeparatorOrTimeZoneOffset = new(Type, "dateSeparatorOrTimeZoneOffset");
				}
				return r_FdateSeparatorOrTimeZoneOffset;
			}
		}

		/// <summary>
		/// System.String invariantDateSeparator
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FinvariantDateSeparator;
		public static Hvak.Editor.Refleaction.RSystem.RString RFinvariantDateSeparator
		{
			get
			{
				if(r_FinvariantDateSeparator == null)
				{
					r_FinvariantDateSeparator = new(Type, "invariantDateSeparator");
				}
				return r_FinvariantDateSeparator;
			}
		}

		/// <summary>
		/// System.String invariantTimeSeparator
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FinvariantTimeSeparator;
		public static Hvak.Editor.Refleaction.RSystem.RString RFinvariantTimeSeparator
		{
			get
			{
				if(r_FinvariantTimeSeparator == null)
				{
					r_FinvariantTimeSeparator = new(Type, "invariantTimeSeparator");
				}
				return r_FinvariantTimeSeparator;
			}
		}

		/// <summary>
		/// System.String IgnorablePeriod
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FIgnorablePeriod;
		public static Hvak.Editor.Refleaction.RSystem.RString RFIgnorablePeriod
		{
			get
			{
				if(r_FIgnorablePeriod == null)
				{
					r_FIgnorablePeriod = new(Type, "IgnorablePeriod");
				}
				return r_FIgnorablePeriod;
			}
		}

		/// <summary>
		/// System.String IgnorableComma
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FIgnorableComma;
		public static Hvak.Editor.Refleaction.RSystem.RString RFIgnorableComma
		{
			get
			{
				if(r_FIgnorableComma == null)
				{
					r_FIgnorableComma = new(Type, "IgnorableComma");
				}
				return r_FIgnorableComma;
			}
		}

		/// <summary>
		/// System.String CJKYearSuff
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FCJKYearSuff;
		public static Hvak.Editor.Refleaction.RSystem.RString RFCJKYearSuff
		{
			get
			{
				if(r_FCJKYearSuff == null)
				{
					r_FCJKYearSuff = new(Type, "CJKYearSuff");
				}
				return r_FCJKYearSuff;
			}
		}

		/// <summary>
		/// System.String CJKMonthSuff
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FCJKMonthSuff;
		public static Hvak.Editor.Refleaction.RSystem.RString RFCJKMonthSuff
		{
			get
			{
				if(r_FCJKMonthSuff == null)
				{
					r_FCJKMonthSuff = new(Type, "CJKMonthSuff");
				}
				return r_FCJKMonthSuff;
			}
		}

		/// <summary>
		/// System.String CJKDaySuff
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FCJKDaySuff;
		public static Hvak.Editor.Refleaction.RSystem.RString RFCJKDaySuff
		{
			get
			{
				if(r_FCJKDaySuff == null)
				{
					r_FCJKDaySuff = new(Type, "CJKDaySuff");
				}
				return r_FCJKDaySuff;
			}
		}

		/// <summary>
		/// System.String KoreanYearSuff
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FKoreanYearSuff;
		public static Hvak.Editor.Refleaction.RSystem.RString RFKoreanYearSuff
		{
			get
			{
				if(r_FKoreanYearSuff == null)
				{
					r_FKoreanYearSuff = new(Type, "KoreanYearSuff");
				}
				return r_FKoreanYearSuff;
			}
		}

		/// <summary>
		/// System.String KoreanMonthSuff
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FKoreanMonthSuff;
		public static Hvak.Editor.Refleaction.RSystem.RString RFKoreanMonthSuff
		{
			get
			{
				if(r_FKoreanMonthSuff == null)
				{
					r_FKoreanMonthSuff = new(Type, "KoreanMonthSuff");
				}
				return r_FKoreanMonthSuff;
			}
		}

		/// <summary>
		/// System.String KoreanDaySuff
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FKoreanDaySuff;
		public static Hvak.Editor.Refleaction.RSystem.RString RFKoreanDaySuff
		{
			get
			{
				if(r_FKoreanDaySuff == null)
				{
					r_FKoreanDaySuff = new(Type, "KoreanDaySuff");
				}
				return r_FKoreanDaySuff;
			}
		}

		/// <summary>
		/// System.String KoreanHourSuff
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FKoreanHourSuff;
		public static Hvak.Editor.Refleaction.RSystem.RString RFKoreanHourSuff
		{
			get
			{
				if(r_FKoreanHourSuff == null)
				{
					r_FKoreanHourSuff = new(Type, "KoreanHourSuff");
				}
				return r_FKoreanHourSuff;
			}
		}

		/// <summary>
		/// System.String KoreanMinuteSuff
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FKoreanMinuteSuff;
		public static Hvak.Editor.Refleaction.RSystem.RString RFKoreanMinuteSuff
		{
			get
			{
				if(r_FKoreanMinuteSuff == null)
				{
					r_FKoreanMinuteSuff = new(Type, "KoreanMinuteSuff");
				}
				return r_FKoreanMinuteSuff;
			}
		}

		/// <summary>
		/// System.String KoreanSecondSuff
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FKoreanSecondSuff;
		public static Hvak.Editor.Refleaction.RSystem.RString RFKoreanSecondSuff
		{
			get
			{
				if(r_FKoreanSecondSuff == null)
				{
					r_FKoreanSecondSuff = new(Type, "KoreanSecondSuff");
				}
				return r_FKoreanSecondSuff;
			}
		}

		/// <summary>
		/// System.String CJKHourSuff
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FCJKHourSuff;
		public static Hvak.Editor.Refleaction.RSystem.RString RFCJKHourSuff
		{
			get
			{
				if(r_FCJKHourSuff == null)
				{
					r_FCJKHourSuff = new(Type, "CJKHourSuff");
				}
				return r_FCJKHourSuff;
			}
		}

		/// <summary>
		/// System.String ChineseHourSuff
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FChineseHourSuff;
		public static Hvak.Editor.Refleaction.RSystem.RString RFChineseHourSuff
		{
			get
			{
				if(r_FChineseHourSuff == null)
				{
					r_FChineseHourSuff = new(Type, "ChineseHourSuff");
				}
				return r_FChineseHourSuff;
			}
		}

		/// <summary>
		/// System.String CJKMinuteSuff
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FCJKMinuteSuff;
		public static Hvak.Editor.Refleaction.RSystem.RString RFCJKMinuteSuff
		{
			get
			{
				if(r_FCJKMinuteSuff == null)
				{
					r_FCJKMinuteSuff = new(Type, "CJKMinuteSuff");
				}
				return r_FCJKMinuteSuff;
			}
		}

		/// <summary>
		/// System.String CJKSecondSuff
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FCJKSecondSuff;
		public static Hvak.Editor.Refleaction.RSystem.RString RFCJKSecondSuff
		{
			get
			{
				if(r_FCJKSecondSuff == null)
				{
					r_FCJKSecondSuff = new(Type, "CJKSecondSuff");
				}
				return r_FCJKSecondSuff;
			}
		}

		/// <summary>
		/// System.String JapaneseEraStart
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FJapaneseEraStart;
		public static Hvak.Editor.Refleaction.RSystem.RString RFJapaneseEraStart
		{
			get
			{
				if(r_FJapaneseEraStart == null)
				{
					r_FJapaneseEraStart = new(Type, "JapaneseEraStart");
				}
				return r_FJapaneseEraStart;
			}
		}

		/// <summary>
		/// System.String LocalTimeMark
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FLocalTimeMark;
		public static Hvak.Editor.Refleaction.RSystem.RString RFLocalTimeMark
		{
			get
			{
				if(r_FLocalTimeMark == null)
				{
					r_FLocalTimeMark = new(Type, "LocalTimeMark");
				}
				return r_FLocalTimeMark;
			}
		}

		/// <summary>
		/// System.String GMTName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FGMTName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFGMTName
		{
			get
			{
				if(r_FGMTName == null)
				{
					r_FGMTName = new(Type, "GMTName");
				}
				return r_FGMTName;
			}
		}

		/// <summary>
		/// System.String ZuluName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FZuluName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFZuluName
		{
			get
			{
				if(r_FZuluName == null)
				{
					r_FZuluName = new(Type, "ZuluName");
				}
				return r_FZuluName;
			}
		}

		/// <summary>
		/// System.String KoreanLangName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FKoreanLangName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFKoreanLangName
		{
			get
			{
				if(r_FKoreanLangName == null)
				{
					r_FKoreanLangName = new(Type, "KoreanLangName");
				}
				return r_FKoreanLangName;
			}
		}

		/// <summary>
		/// System.String JapaneseLangName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FJapaneseLangName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFJapaneseLangName
		{
			get
			{
				if(r_FJapaneseLangName == null)
				{
					r_FJapaneseLangName = new(Type, "JapaneseLangName");
				}
				return r_FJapaneseLangName;
			}
		}

		/// <summary>
		/// System.String EnglishLangName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FEnglishLangName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFEnglishLangName
		{
			get
			{
				if(r_FEnglishLangName == null)
				{
					r_FEnglishLangName = new(Type, "EnglishLangName");
				}
				return r_FEnglishLangName;
			}
		}

		/// <summary>
		/// System.Globalization.DateTimeFormatInfo s_jajpDTFI
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RDateTimeFormatInfo r_Fs_jajpDTFI;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RDateTimeFormatInfo RFs_jajpDTFI
		{
			get
			{
				if(r_Fs_jajpDTFI == null)
				{
					r_Fs_jajpDTFI = new(Type, "s_jajpDTFI");
				}
				return r_Fs_jajpDTFI;
			}
		}

		/// <summary>
		/// System.Globalization.DateTimeFormatInfo s_zhtwDTFI
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RDateTimeFormatInfo r_Fs_zhtwDTFI;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RDateTimeFormatInfo RFs_zhtwDTFI
		{
			get
			{
				if(r_Fs_zhtwDTFI == null)
				{
					r_Fs_zhtwDTFI = new(Type, "s_zhtwDTFI");
				}
				return r_Fs_zhtwDTFI;
			}
		}

		/// <summary>
		/// System.String CultureName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PCultureName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPCultureName
		{
			get
			{
				if(r_PCultureName == null)
				{
					r_PCultureName = new(this, "CultureName", -1);
				}
				return r_PCultureName;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo Culture
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo r_PCulture;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo RPCulture
		{
			get
			{
				if(r_PCulture == null)
				{
					r_PCulture = new(this, "Culture", -1);
				}
				return r_PCulture;
			}
		}

		/// <summary>
		/// System.String LanguageName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PLanguageName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPLanguageName
		{
			get
			{
				if(r_PLanguageName == null)
				{
					r_PLanguageName = new(this, "LanguageName", -1);
				}
				return r_PLanguageName;
			}
		}

		/// <summary>
		/// System.Globalization.DateTimeFormatInfo InvariantInfo
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RDateTimeFormatInfo r_PInvariantInfo;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RDateTimeFormatInfo RPInvariantInfo
		{
			get
			{
				if(r_PInvariantInfo == null)
				{
					r_PInvariantInfo = new(Type, "InvariantInfo", -1);
				}
				return r_PInvariantInfo;
			}
		}

		/// <summary>
		/// System.Globalization.DateTimeFormatInfo CurrentInfo
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RDateTimeFormatInfo r_PCurrentInfo;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RDateTimeFormatInfo RPCurrentInfo
		{
			get
			{
				if(r_PCurrentInfo == null)
				{
					r_PCurrentInfo = new(Type, "CurrentInfo", -1);
				}
				return r_PCurrentInfo;
			}
		}

		/// <summary>
		/// System.String AMDesignator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PAMDesignator;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPAMDesignator
		{
			get
			{
				if(r_PAMDesignator == null)
				{
					r_PAMDesignator = new(this, "AMDesignator", -1);
				}
				return r_PAMDesignator;
			}
		}

		/// <summary>
		/// System.Globalization.Calendar Calendar
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendar r_PCalendar;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendar RPCalendar
		{
			get
			{
				if(r_PCalendar == null)
				{
					r_PCalendar = new(this, "Calendar", -1);
				}
				return r_PCalendar;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarId[] OptionalCalendars
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId> r_POptionalCalendars;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId> RPOptionalCalendars
		{
			get
			{
				if(r_POptionalCalendars == null)
				{
					r_POptionalCalendars = new(this, "OptionalCalendars", -1);
				}
				return r_POptionalCalendars;
			}
		}

		/// <summary>
		/// System.String[] EraNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_PEraNames;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPEraNames
		{
			get
			{
				if(r_PEraNames == null)
				{
					r_PEraNames = new(this, "EraNames", -1);
				}
				return r_PEraNames;
			}
		}

		/// <summary>
		/// System.String[] AbbreviatedEraNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_PAbbreviatedEraNames;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPAbbreviatedEraNames
		{
			get
			{
				if(r_PAbbreviatedEraNames == null)
				{
					r_PAbbreviatedEraNames = new(this, "AbbreviatedEraNames", -1);
				}
				return r_PAbbreviatedEraNames;
			}
		}

		/// <summary>
		/// System.String[] AbbreviatedEnglishEraNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_PAbbreviatedEnglishEraNames;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPAbbreviatedEnglishEraNames
		{
			get
			{
				if(r_PAbbreviatedEnglishEraNames == null)
				{
					r_PAbbreviatedEnglishEraNames = new(this, "AbbreviatedEnglishEraNames", -1);
				}
				return r_PAbbreviatedEnglishEraNames;
			}
		}

		/// <summary>
		/// System.String DateSeparator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PDateSeparator;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPDateSeparator
		{
			get
			{
				if(r_PDateSeparator == null)
				{
					r_PDateSeparator = new(this, "DateSeparator", -1);
				}
				return r_PDateSeparator;
			}
		}

		/// <summary>
		/// System.DayOfWeek FirstDayOfWeek
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RDayOfWeek r_PFirstDayOfWeek;
		public virtual Hvak.Editor.Refleaction.RSystem.RDayOfWeek RPFirstDayOfWeek
		{
			get
			{
				if(r_PFirstDayOfWeek == null)
				{
					r_PFirstDayOfWeek = new(this, "FirstDayOfWeek", -1);
				}
				return r_PFirstDayOfWeek;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarWeekRule CalendarWeekRule
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarWeekRule r_PCalendarWeekRule;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarWeekRule RPCalendarWeekRule
		{
			get
			{
				if(r_PCalendarWeekRule == null)
				{
					r_PCalendarWeekRule = new(this, "CalendarWeekRule", -1);
				}
				return r_PCalendarWeekRule;
			}
		}

		/// <summary>
		/// System.String FullDateTimePattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PFullDateTimePattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPFullDateTimePattern
		{
			get
			{
				if(r_PFullDateTimePattern == null)
				{
					r_PFullDateTimePattern = new(this, "FullDateTimePattern", -1);
				}
				return r_PFullDateTimePattern;
			}
		}

		/// <summary>
		/// System.String LongDatePattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PLongDatePattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPLongDatePattern
		{
			get
			{
				if(r_PLongDatePattern == null)
				{
					r_PLongDatePattern = new(this, "LongDatePattern", -1);
				}
				return r_PLongDatePattern;
			}
		}

		/// <summary>
		/// System.String LongTimePattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PLongTimePattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPLongTimePattern
		{
			get
			{
				if(r_PLongTimePattern == null)
				{
					r_PLongTimePattern = new(this, "LongTimePattern", -1);
				}
				return r_PLongTimePattern;
			}
		}

		/// <summary>
		/// System.String MonthDayPattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PMonthDayPattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPMonthDayPattern
		{
			get
			{
				if(r_PMonthDayPattern == null)
				{
					r_PMonthDayPattern = new(this, "MonthDayPattern", -1);
				}
				return r_PMonthDayPattern;
			}
		}

		/// <summary>
		/// System.String PMDesignator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PPMDesignator;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPPMDesignator
		{
			get
			{
				if(r_PPMDesignator == null)
				{
					r_PPMDesignator = new(this, "PMDesignator", -1);
				}
				return r_PPMDesignator;
			}
		}

		/// <summary>
		/// System.String RFC1123Pattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PRFC1123Pattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPRFC1123Pattern
		{
			get
			{
				if(r_PRFC1123Pattern == null)
				{
					r_PRFC1123Pattern = new(this, "RFC1123Pattern", -1);
				}
				return r_PRFC1123Pattern;
			}
		}

		/// <summary>
		/// System.String ShortDatePattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PShortDatePattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPShortDatePattern
		{
			get
			{
				if(r_PShortDatePattern == null)
				{
					r_PShortDatePattern = new(this, "ShortDatePattern", -1);
				}
				return r_PShortDatePattern;
			}
		}

		/// <summary>
		/// System.String ShortTimePattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PShortTimePattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPShortTimePattern
		{
			get
			{
				if(r_PShortTimePattern == null)
				{
					r_PShortTimePattern = new(this, "ShortTimePattern", -1);
				}
				return r_PShortTimePattern;
			}
		}

		/// <summary>
		/// System.String SortableDateTimePattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PSortableDateTimePattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPSortableDateTimePattern
		{
			get
			{
				if(r_PSortableDateTimePattern == null)
				{
					r_PSortableDateTimePattern = new(this, "SortableDateTimePattern", -1);
				}
				return r_PSortableDateTimePattern;
			}
		}

		/// <summary>
		/// System.String GeneralShortTimePattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PGeneralShortTimePattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPGeneralShortTimePattern
		{
			get
			{
				if(r_PGeneralShortTimePattern == null)
				{
					r_PGeneralShortTimePattern = new(this, "GeneralShortTimePattern", -1);
				}
				return r_PGeneralShortTimePattern;
			}
		}

		/// <summary>
		/// System.String GeneralLongTimePattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PGeneralLongTimePattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPGeneralLongTimePattern
		{
			get
			{
				if(r_PGeneralLongTimePattern == null)
				{
					r_PGeneralLongTimePattern = new(this, "GeneralLongTimePattern", -1);
				}
				return r_PGeneralLongTimePattern;
			}
		}

		/// <summary>
		/// System.String DateTimeOffsetPattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PDateTimeOffsetPattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPDateTimeOffsetPattern
		{
			get
			{
				if(r_PDateTimeOffsetPattern == null)
				{
					r_PDateTimeOffsetPattern = new(this, "DateTimeOffsetPattern", -1);
				}
				return r_PDateTimeOffsetPattern;
			}
		}

		/// <summary>
		/// System.String TimeSeparator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PTimeSeparator;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPTimeSeparator
		{
			get
			{
				if(r_PTimeSeparator == null)
				{
					r_PTimeSeparator = new(this, "TimeSeparator", -1);
				}
				return r_PTimeSeparator;
			}
		}

		/// <summary>
		/// System.String UniversalSortableDateTimePattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PUniversalSortableDateTimePattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPUniversalSortableDateTimePattern
		{
			get
			{
				if(r_PUniversalSortableDateTimePattern == null)
				{
					r_PUniversalSortableDateTimePattern = new(this, "UniversalSortableDateTimePattern", -1);
				}
				return r_PUniversalSortableDateTimePattern;
			}
		}

		/// <summary>
		/// System.String YearMonthPattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PYearMonthPattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPYearMonthPattern
		{
			get
			{
				if(r_PYearMonthPattern == null)
				{
					r_PYearMonthPattern = new(this, "YearMonthPattern", -1);
				}
				return r_PYearMonthPattern;
			}
		}

		/// <summary>
		/// System.String[] AbbreviatedDayNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_PAbbreviatedDayNames;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPAbbreviatedDayNames
		{
			get
			{
				if(r_PAbbreviatedDayNames == null)
				{
					r_PAbbreviatedDayNames = new(this, "AbbreviatedDayNames", -1);
				}
				return r_PAbbreviatedDayNames;
			}
		}

		/// <summary>
		/// System.String[] ShortestDayNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_PShortestDayNames;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPShortestDayNames
		{
			get
			{
				if(r_PShortestDayNames == null)
				{
					r_PShortestDayNames = new(this, "ShortestDayNames", -1);
				}
				return r_PShortestDayNames;
			}
		}

		/// <summary>
		/// System.String[] DayNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_PDayNames;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPDayNames
		{
			get
			{
				if(r_PDayNames == null)
				{
					r_PDayNames = new(this, "DayNames", -1);
				}
				return r_PDayNames;
			}
		}

		/// <summary>
		/// System.String[] AbbreviatedMonthNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_PAbbreviatedMonthNames;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPAbbreviatedMonthNames
		{
			get
			{
				if(r_PAbbreviatedMonthNames == null)
				{
					r_PAbbreviatedMonthNames = new(this, "AbbreviatedMonthNames", -1);
				}
				return r_PAbbreviatedMonthNames;
			}
		}

		/// <summary>
		/// System.String[] MonthNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_PMonthNames;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPMonthNames
		{
			get
			{
				if(r_PMonthNames == null)
				{
					r_PMonthNames = new(this, "MonthNames", -1);
				}
				return r_PMonthNames;
			}
		}

		/// <summary>
		/// Boolean HasSpacesInMonthNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PHasSpacesInMonthNames;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPHasSpacesInMonthNames
		{
			get
			{
				if(r_PHasSpacesInMonthNames == null)
				{
					r_PHasSpacesInMonthNames = new(this, "HasSpacesInMonthNames", -1);
				}
				return r_PHasSpacesInMonthNames;
			}
		}

		/// <summary>
		/// Boolean HasSpacesInDayNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PHasSpacesInDayNames;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPHasSpacesInDayNames
		{
			get
			{
				if(r_PHasSpacesInDayNames == null)
				{
					r_PHasSpacesInDayNames = new(this, "HasSpacesInDayNames", -1);
				}
				return r_PHasSpacesInDayNames;
			}
		}

		/// <summary>
		/// System.String[] AllYearMonthPatterns
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_PAllYearMonthPatterns;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPAllYearMonthPatterns
		{
			get
			{
				if(r_PAllYearMonthPatterns == null)
				{
					r_PAllYearMonthPatterns = new(this, "AllYearMonthPatterns", -1);
				}
				return r_PAllYearMonthPatterns;
			}
		}

		/// <summary>
		/// System.String[] AllShortDatePatterns
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_PAllShortDatePatterns;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPAllShortDatePatterns
		{
			get
			{
				if(r_PAllShortDatePatterns == null)
				{
					r_PAllShortDatePatterns = new(this, "AllShortDatePatterns", -1);
				}
				return r_PAllShortDatePatterns;
			}
		}

		/// <summary>
		/// System.String[] AllShortTimePatterns
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_PAllShortTimePatterns;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPAllShortTimePatterns
		{
			get
			{
				if(r_PAllShortTimePatterns == null)
				{
					r_PAllShortTimePatterns = new(this, "AllShortTimePatterns", -1);
				}
				return r_PAllShortTimePatterns;
			}
		}

		/// <summary>
		/// System.String[] AllLongDatePatterns
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_PAllLongDatePatterns;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPAllLongDatePatterns
		{
			get
			{
				if(r_PAllLongDatePatterns == null)
				{
					r_PAllLongDatePatterns = new(this, "AllLongDatePatterns", -1);
				}
				return r_PAllLongDatePatterns;
			}
		}

		/// <summary>
		/// System.String[] AllLongTimePatterns
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_PAllLongTimePatterns;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPAllLongTimePatterns
		{
			get
			{
				if(r_PAllLongTimePatterns == null)
				{
					r_PAllLongTimePatterns = new(this, "AllLongTimePatterns", -1);
				}
				return r_PAllLongTimePatterns;
			}
		}

		/// <summary>
		/// System.String[] UnclonedYearMonthPatterns
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_PUnclonedYearMonthPatterns;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPUnclonedYearMonthPatterns
		{
			get
			{
				if(r_PUnclonedYearMonthPatterns == null)
				{
					r_PUnclonedYearMonthPatterns = new(this, "UnclonedYearMonthPatterns", -1);
				}
				return r_PUnclonedYearMonthPatterns;
			}
		}

		/// <summary>
		/// System.String[] UnclonedShortDatePatterns
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_PUnclonedShortDatePatterns;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPUnclonedShortDatePatterns
		{
			get
			{
				if(r_PUnclonedShortDatePatterns == null)
				{
					r_PUnclonedShortDatePatterns = new(this, "UnclonedShortDatePatterns", -1);
				}
				return r_PUnclonedShortDatePatterns;
			}
		}

		/// <summary>
		/// System.String[] UnclonedLongDatePatterns
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_PUnclonedLongDatePatterns;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPUnclonedLongDatePatterns
		{
			get
			{
				if(r_PUnclonedLongDatePatterns == null)
				{
					r_PUnclonedLongDatePatterns = new(this, "UnclonedLongDatePatterns", -1);
				}
				return r_PUnclonedLongDatePatterns;
			}
		}

		/// <summary>
		/// System.String[] UnclonedShortTimePatterns
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_PUnclonedShortTimePatterns;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPUnclonedShortTimePatterns
		{
			get
			{
				if(r_PUnclonedShortTimePatterns == null)
				{
					r_PUnclonedShortTimePatterns = new(this, "UnclonedShortTimePatterns", -1);
				}
				return r_PUnclonedShortTimePatterns;
			}
		}

		/// <summary>
		/// System.String[] UnclonedLongTimePatterns
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_PUnclonedLongTimePatterns;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPUnclonedLongTimePatterns
		{
			get
			{
				if(r_PUnclonedLongTimePatterns == null)
				{
					r_PUnclonedLongTimePatterns = new(this, "UnclonedLongTimePatterns", -1);
				}
				return r_PUnclonedLongTimePatterns;
			}
		}

		/// <summary>
		/// Boolean IsReadOnly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsReadOnly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsReadOnly
		{
			get
			{
				if(r_PIsReadOnly == null)
				{
					r_PIsReadOnly = new(this, "IsReadOnly", -1);
				}
				return r_PIsReadOnly;
			}
		}

		/// <summary>
		/// System.String NativeCalendarName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PNativeCalendarName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPNativeCalendarName
		{
			get
			{
				if(r_PNativeCalendarName == null)
				{
					r_PNativeCalendarName = new(this, "NativeCalendarName", -1);
				}
				return r_PNativeCalendarName;
			}
		}

		/// <summary>
		/// System.String[] AbbreviatedMonthGenitiveNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_PAbbreviatedMonthGenitiveNames;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPAbbreviatedMonthGenitiveNames
		{
			get
			{
				if(r_PAbbreviatedMonthGenitiveNames == null)
				{
					r_PAbbreviatedMonthGenitiveNames = new(this, "AbbreviatedMonthGenitiveNames", -1);
				}
				return r_PAbbreviatedMonthGenitiveNames;
			}
		}

		/// <summary>
		/// System.String[] MonthGenitiveNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_PMonthGenitiveNames;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPMonthGenitiveNames
		{
			get
			{
				if(r_PMonthGenitiveNames == null)
				{
					r_PMonthGenitiveNames = new(this, "MonthGenitiveNames", -1);
				}
				return r_PMonthGenitiveNames;
			}
		}

		/// <summary>
		/// System.String FullTimeSpanPositivePattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PFullTimeSpanPositivePattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPFullTimeSpanPositivePattern
		{
			get
			{
				if(r_PFullTimeSpanPositivePattern == null)
				{
					r_PFullTimeSpanPositivePattern = new(this, "FullTimeSpanPositivePattern", -1);
				}
				return r_PFullTimeSpanPositivePattern;
			}
		}

		/// <summary>
		/// System.String FullTimeSpanNegativePattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PFullTimeSpanNegativePattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPFullTimeSpanNegativePattern
		{
			get
			{
				if(r_PFullTimeSpanNegativePattern == null)
				{
					r_PFullTimeSpanNegativePattern = new(this, "FullTimeSpanNegativePattern", -1);
				}
				return r_PFullTimeSpanNegativePattern;
			}
		}

		/// <summary>
		/// System.Globalization.CompareInfo CompareInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RCompareInfo r_PCompareInfo;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RCompareInfo RPCompareInfo
		{
			get
			{
				if(r_PCompareInfo == null)
				{
					r_PCompareInfo = new(this, "CompareInfo", -1);
				}
				return r_PCompareInfo;
			}
		}

		/// <summary>
		/// System.Globalization.DateTimeFormatFlags FormatFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RDateTimeFormatFlags r_PFormatFlags;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RDateTimeFormatFlags RPFormatFlags
		{
			get
			{
				if(r_PFormatFlags == null)
				{
					r_PFormatFlags = new(this, "FormatFlags", -1);
				}
				return r_PFormatFlags;
			}
		}

		/// <summary>
		/// Boolean HasForceTwoDigitYears
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PHasForceTwoDigitYears;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPHasForceTwoDigitYears
		{
			get
			{
				if(r_PHasForceTwoDigitYears == null)
				{
					r_PHasForceTwoDigitYears = new(this, "HasForceTwoDigitYears", -1);
				}
				return r_PHasForceTwoDigitYears;
			}
		}

		/// <summary>
		/// Boolean HasYearMonthAdjustment
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PHasYearMonthAdjustment;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPHasYearMonthAdjustment
		{
			get
			{
				if(r_PHasYearMonthAdjustment == null)
				{
					r_PHasYearMonthAdjustment = new(this, "HasYearMonthAdjustment", -1);
				}
				return r_PHasYearMonthAdjustment;
			}
		}

		/// <summary>
		/// System.String[] internalGetAbbreviatedDayOfWeekNames()
		/// </summary>
		protected RMethod r_MinternalGetAbbreviatedDayOfWeekNames;
		public virtual RMethod RMinternalGetAbbreviatedDayOfWeekNames
		{
			get
			{
				if(r_MinternalGetAbbreviatedDayOfWeekNames == null)
				{
					r_MinternalGetAbbreviatedDayOfWeekNames = new(this, "internalGetAbbreviatedDayOfWeekNames", 0);
				}
				return r_MinternalGetAbbreviatedDayOfWeekNames;
			}
		}

		/// <summary>
		/// System.String[] internalGetAbbreviatedDayOfWeekNamesCore()
		/// </summary>
		protected RMethod r_MinternalGetAbbreviatedDayOfWeekNamesCore;
		public virtual RMethod RMinternalGetAbbreviatedDayOfWeekNamesCore
		{
			get
			{
				if(r_MinternalGetAbbreviatedDayOfWeekNamesCore == null)
				{
					r_MinternalGetAbbreviatedDayOfWeekNamesCore = new(this, "internalGetAbbreviatedDayOfWeekNamesCore", 0);
				}
				return r_MinternalGetAbbreviatedDayOfWeekNamesCore;
			}
		}

		/// <summary>
		/// System.String[] internalGetSuperShortDayNames()
		/// </summary>
		protected RMethod r_MinternalGetSuperShortDayNames;
		public virtual RMethod RMinternalGetSuperShortDayNames
		{
			get
			{
				if(r_MinternalGetSuperShortDayNames == null)
				{
					r_MinternalGetSuperShortDayNames = new(this, "internalGetSuperShortDayNames", 0);
				}
				return r_MinternalGetSuperShortDayNames;
			}
		}

		/// <summary>
		/// System.String[] internalGetSuperShortDayNamesCore()
		/// </summary>
		protected RMethod r_MinternalGetSuperShortDayNamesCore;
		public virtual RMethod RMinternalGetSuperShortDayNamesCore
		{
			get
			{
				if(r_MinternalGetSuperShortDayNamesCore == null)
				{
					r_MinternalGetSuperShortDayNamesCore = new(this, "internalGetSuperShortDayNamesCore", 0);
				}
				return r_MinternalGetSuperShortDayNamesCore;
			}
		}

		/// <summary>
		/// System.String[] internalGetDayOfWeekNames()
		/// </summary>
		protected RMethod r_MinternalGetDayOfWeekNames;
		public virtual RMethod RMinternalGetDayOfWeekNames
		{
			get
			{
				if(r_MinternalGetDayOfWeekNames == null)
				{
					r_MinternalGetDayOfWeekNames = new(this, "internalGetDayOfWeekNames", 0);
				}
				return r_MinternalGetDayOfWeekNames;
			}
		}

		/// <summary>
		/// System.String[] internalGetDayOfWeekNamesCore()
		/// </summary>
		protected RMethod r_MinternalGetDayOfWeekNamesCore;
		public virtual RMethod RMinternalGetDayOfWeekNamesCore
		{
			get
			{
				if(r_MinternalGetDayOfWeekNamesCore == null)
				{
					r_MinternalGetDayOfWeekNamesCore = new(this, "internalGetDayOfWeekNamesCore", 0);
				}
				return r_MinternalGetDayOfWeekNamesCore;
			}
		}

		/// <summary>
		/// System.String[] internalGetAbbreviatedMonthNames()
		/// </summary>
		protected RMethod r_MinternalGetAbbreviatedMonthNames;
		public virtual RMethod RMinternalGetAbbreviatedMonthNames
		{
			get
			{
				if(r_MinternalGetAbbreviatedMonthNames == null)
				{
					r_MinternalGetAbbreviatedMonthNames = new(this, "internalGetAbbreviatedMonthNames", 0);
				}
				return r_MinternalGetAbbreviatedMonthNames;
			}
		}

		/// <summary>
		/// System.String[] internalGetAbbreviatedMonthNamesCore()
		/// </summary>
		protected RMethod r_MinternalGetAbbreviatedMonthNamesCore;
		public virtual RMethod RMinternalGetAbbreviatedMonthNamesCore
		{
			get
			{
				if(r_MinternalGetAbbreviatedMonthNamesCore == null)
				{
					r_MinternalGetAbbreviatedMonthNamesCore = new(this, "internalGetAbbreviatedMonthNamesCore", 0);
				}
				return r_MinternalGetAbbreviatedMonthNamesCore;
			}
		}

		/// <summary>
		/// System.String[] internalGetMonthNames()
		/// </summary>
		protected RMethod r_MinternalGetMonthNames;
		public virtual RMethod RMinternalGetMonthNames
		{
			get
			{
				if(r_MinternalGetMonthNames == null)
				{
					r_MinternalGetMonthNames = new(this, "internalGetMonthNames", 0);
				}
				return r_MinternalGetMonthNames;
			}
		}

		/// <summary>
		/// System.String[] internalGetMonthNamesCore()
		/// </summary>
		protected RMethod r_MinternalGetMonthNamesCore;
		public virtual RMethod RMinternalGetMonthNamesCore
		{
			get
			{
				if(r_MinternalGetMonthNamesCore == null)
				{
					r_MinternalGetMonthNamesCore = new(this, "internalGetMonthNamesCore", 0);
				}
				return r_MinternalGetMonthNamesCore;
			}
		}

		/// <summary>
		/// Void InitializeOverridableProperties(System.Globalization.CultureData, Int32)
		/// </summary>
		protected RMethod r_MInitializeOverridableProperties_CultureData_Int32;
		public virtual RMethod RMInitializeOverridableProperties_CultureData_Int32
		{
			get
			{
				if(r_MInitializeOverridableProperties_CultureData_Int32 == null)
				{
					r_MInitializeOverridableProperties_CultureData_Int32 = new(this, "InitializeOverridableProperties", 0,  ReflectionUtils.GetType("System.Globalization.CultureData"), typeof(System.Int32));
				}
				return r_MInitializeOverridableProperties_CultureData_Int32;
			}
		}

		/// <summary>
		/// System.Globalization.DateTimeFormatInfo GetInstance(System.IFormatProvider)
		/// </summary>
		protected static RMethod r_MGetInstance_IFormatProvider;
		public static RMethod RMGetInstance_IFormatProvider
		{
			get
			{
				if(r_MGetInstance_IFormatProvider == null)
				{
					r_MGetInstance_IFormatProvider = new(Type, "GetInstance", 0, typeof(System.IFormatProvider));
				}
				return r_MGetInstance_IFormatProvider;
			}
		}

		/// <summary>
		/// System.Object GetFormat(System.Type)
		/// </summary>
		protected RMethod r_MGetFormat_Type;
		public virtual RMethod RMGetFormat_Type
		{
			get
			{
				if(r_MGetFormat_Type == null)
				{
					r_MGetFormat_Type = new(this, "GetFormat", 0, typeof(System.Type));
				}
				return r_MGetFormat_Type;
			}
		}

		/// <summary>
		/// System.Object Clone()
		/// </summary>
		protected RMethod r_MClone;
		public virtual RMethod RMClone
		{
			get
			{
				if(r_MClone == null)
				{
					r_MClone = new(this, "Clone", 0);
				}
				return r_MClone;
			}
		}

		/// <summary>
		/// Int32 GetEra(System.String)
		/// </summary>
		protected RMethod r_MGetEra_String;
		public virtual RMethod RMGetEra_String
		{
			get
			{
				if(r_MGetEra_String == null)
				{
					r_MGetEra_String = new(this, "GetEra", 0, typeof(System.String));
				}
				return r_MGetEra_String;
			}
		}

		/// <summary>
		/// System.String GetEraName(Int32)
		/// </summary>
		protected RMethod r_MGetEraName_Int32;
		public virtual RMethod RMGetEraName_Int32
		{
			get
			{
				if(r_MGetEraName_Int32 == null)
				{
					r_MGetEraName_Int32 = new(this, "GetEraName", 0, typeof(System.Int32));
				}
				return r_MGetEraName_Int32;
			}
		}

		/// <summary>
		/// System.String GetAbbreviatedEraName(Int32)
		/// </summary>
		protected RMethod r_MGetAbbreviatedEraName_Int32;
		public virtual RMethod RMGetAbbreviatedEraName_Int32
		{
			get
			{
				if(r_MGetAbbreviatedEraName_Int32 == null)
				{
					r_MGetAbbreviatedEraName_Int32 = new(this, "GetAbbreviatedEraName", 0, typeof(System.Int32));
				}
				return r_MGetAbbreviatedEraName_Int32;
			}
		}

		/// <summary>
		/// Void CheckNullValue(System.String[], Int32)
		/// </summary>
		protected static RMethod r_MCheckNullValue_StringArray_Int32;
		public static RMethod RMCheckNullValue_StringArray_Int32
		{
			get
			{
				if(r_MCheckNullValue_StringArray_Int32 == null)
				{
					r_MCheckNullValue_StringArray_Int32 = new(Type, "CheckNullValue", 0, typeof(System.String).MakeArrayType(), typeof(System.Int32));
				}
				return r_MCheckNullValue_StringArray_Int32;
			}
		}

		/// <summary>
		/// System.String internalGetMonthName(Int32, System.Globalization.MonthNameStyles, Boolean)
		/// </summary>
		protected RMethod r_MinternalGetMonthName_Int32_MonthNameStyles_Boolean;
		public virtual RMethod RMinternalGetMonthName_Int32_MonthNameStyles_Boolean
		{
			get
			{
				if(r_MinternalGetMonthName_Int32_MonthNameStyles_Boolean == null)
				{
					r_MinternalGetMonthName_Int32_MonthNameStyles_Boolean = new(this, "internalGetMonthName", 0, typeof(System.Int32),  ReflectionUtils.GetType("System.Globalization.MonthNameStyles"), typeof(System.Boolean));
				}
				return r_MinternalGetMonthName_Int32_MonthNameStyles_Boolean;
			}
		}

		/// <summary>
		/// System.String[] internalGetGenitiveMonthNames(Boolean)
		/// </summary>
		protected RMethod r_MinternalGetGenitiveMonthNames_Boolean;
		public virtual RMethod RMinternalGetGenitiveMonthNames_Boolean
		{
			get
			{
				if(r_MinternalGetGenitiveMonthNames_Boolean == null)
				{
					r_MinternalGetGenitiveMonthNames_Boolean = new(this, "internalGetGenitiveMonthNames", 0, typeof(System.Boolean));
				}
				return r_MinternalGetGenitiveMonthNames_Boolean;
			}
		}

		/// <summary>
		/// System.String[] internalGetLeapYearMonthNames()
		/// </summary>
		protected RMethod r_MinternalGetLeapYearMonthNames;
		public virtual RMethod RMinternalGetLeapYearMonthNames
		{
			get
			{
				if(r_MinternalGetLeapYearMonthNames == null)
				{
					r_MinternalGetLeapYearMonthNames = new(this, "internalGetLeapYearMonthNames", 0);
				}
				return r_MinternalGetLeapYearMonthNames;
			}
		}

		/// <summary>
		/// System.String GetAbbreviatedDayName(System.DayOfWeek)
		/// </summary>
		protected RMethod r_MGetAbbreviatedDayName_DayOfWeek;
		public virtual RMethod RMGetAbbreviatedDayName_DayOfWeek
		{
			get
			{
				if(r_MGetAbbreviatedDayName_DayOfWeek == null)
				{
					r_MGetAbbreviatedDayName_DayOfWeek = new(this, "GetAbbreviatedDayName", 0, typeof(System.DayOfWeek));
				}
				return r_MGetAbbreviatedDayName_DayOfWeek;
			}
		}

		/// <summary>
		/// System.String GetShortestDayName(System.DayOfWeek)
		/// </summary>
		protected RMethod r_MGetShortestDayName_DayOfWeek;
		public virtual RMethod RMGetShortestDayName_DayOfWeek
		{
			get
			{
				if(r_MGetShortestDayName_DayOfWeek == null)
				{
					r_MGetShortestDayName_DayOfWeek = new(this, "GetShortestDayName", 0, typeof(System.DayOfWeek));
				}
				return r_MGetShortestDayName_DayOfWeek;
			}
		}

		/// <summary>
		/// System.String[] GetCombinedPatterns(System.String[], System.String[], System.String)
		/// </summary>
		protected static RMethod r_MGetCombinedPatterns_StringArray_StringArray_String;
		public static RMethod RMGetCombinedPatterns_StringArray_StringArray_String
		{
			get
			{
				if(r_MGetCombinedPatterns_StringArray_StringArray_String == null)
				{
					r_MGetCombinedPatterns_StringArray_StringArray_String = new(Type, "GetCombinedPatterns", 0, typeof(System.String).MakeArrayType(), typeof(System.String).MakeArrayType(), typeof(System.String));
				}
				return r_MGetCombinedPatterns_StringArray_StringArray_String;
			}
		}

		/// <summary>
		/// System.String[] GetAllDateTimePatterns()
		/// </summary>
		protected RMethod r_MGetAllDateTimePatterns;
		public virtual RMethod RMGetAllDateTimePatterns
		{
			get
			{
				if(r_MGetAllDateTimePatterns == null)
				{
					r_MGetAllDateTimePatterns = new(this, "GetAllDateTimePatterns", 0);
				}
				return r_MGetAllDateTimePatterns;
			}
		}

		/// <summary>
		/// System.String[] GetAllDateTimePatterns(Char)
		/// </summary>
		protected RMethod r_MGetAllDateTimePatterns_Char;
		public virtual RMethod RMGetAllDateTimePatterns_Char
		{
			get
			{
				if(r_MGetAllDateTimePatterns_Char == null)
				{
					r_MGetAllDateTimePatterns_Char = new(this, "GetAllDateTimePatterns", 0, typeof(System.Char));
				}
				return r_MGetAllDateTimePatterns_Char;
			}
		}

		/// <summary>
		/// System.String GetDayName(System.DayOfWeek)
		/// </summary>
		protected RMethod r_MGetDayName_DayOfWeek;
		public virtual RMethod RMGetDayName_DayOfWeek
		{
			get
			{
				if(r_MGetDayName_DayOfWeek == null)
				{
					r_MGetDayName_DayOfWeek = new(this, "GetDayName", 0, typeof(System.DayOfWeek));
				}
				return r_MGetDayName_DayOfWeek;
			}
		}

		/// <summary>
		/// System.String GetAbbreviatedMonthName(Int32)
		/// </summary>
		protected RMethod r_MGetAbbreviatedMonthName_Int32;
		public virtual RMethod RMGetAbbreviatedMonthName_Int32
		{
			get
			{
				if(r_MGetAbbreviatedMonthName_Int32 == null)
				{
					r_MGetAbbreviatedMonthName_Int32 = new(this, "GetAbbreviatedMonthName", 0, typeof(System.Int32));
				}
				return r_MGetAbbreviatedMonthName_Int32;
			}
		}

		/// <summary>
		/// System.String GetMonthName(Int32)
		/// </summary>
		protected RMethod r_MGetMonthName_Int32;
		public virtual RMethod RMGetMonthName_Int32
		{
			get
			{
				if(r_MGetMonthName_Int32 == null)
				{
					r_MGetMonthName_Int32 = new(this, "GetMonthName", 0, typeof(System.Int32));
				}
				return r_MGetMonthName_Int32;
			}
		}

		/// <summary>
		/// System.String[] GetMergedPatterns(System.String[], System.String)
		/// </summary>
		protected static RMethod r_MGetMergedPatterns_StringArray_String;
		public static RMethod RMGetMergedPatterns_StringArray_String
		{
			get
			{
				if(r_MGetMergedPatterns_StringArray_String == null)
				{
					r_MGetMergedPatterns_StringArray_String = new(Type, "GetMergedPatterns", 0, typeof(System.String).MakeArrayType(), typeof(System.String));
				}
				return r_MGetMergedPatterns_StringArray_String;
			}
		}

		/// <summary>
		/// System.Globalization.DateTimeFormatInfo ReadOnly(System.Globalization.DateTimeFormatInfo)
		/// </summary>
		protected static RMethod r_MReadOnly_DateTimeFormatInfo;
		public static RMethod RMReadOnly_DateTimeFormatInfo
		{
			get
			{
				if(r_MReadOnly_DateTimeFormatInfo == null)
				{
					r_MReadOnly_DateTimeFormatInfo = new(Type, "ReadOnly", 0, typeof(System.Globalization.DateTimeFormatInfo));
				}
				return r_MReadOnly_DateTimeFormatInfo;
			}
		}

		/// <summary>
		/// Void SetAllDateTimePatterns(System.String[], Char)
		/// </summary>
		protected RMethod r_MSetAllDateTimePatterns_StringArray_Char;
		public virtual RMethod RMSetAllDateTimePatterns_StringArray_Char
		{
			get
			{
				if(r_MSetAllDateTimePatterns_StringArray_Char == null)
				{
					r_MSetAllDateTimePatterns_StringArray_Char = new(this, "SetAllDateTimePatterns", 0, typeof(System.String).MakeArrayType(), typeof(System.Char));
				}
				return r_MSetAllDateTimePatterns_StringArray_Char;
			}
		}

		/// <summary>
		/// Void ValidateStyles(System.Globalization.DateTimeStyles, System.String)
		/// </summary>
		protected static RMethod r_MValidateStyles_DateTimeStyles_String;
		public static RMethod RMValidateStyles_DateTimeStyles_String
		{
			get
			{
				if(r_MValidateStyles_DateTimeStyles_String == null)
				{
					r_MValidateStyles_DateTimeStyles_String = new(Type, "ValidateStyles", 0, typeof(System.Globalization.DateTimeStyles), typeof(System.String));
				}
				return r_MValidateStyles_DateTimeStyles_String;
			}
		}

		/// <summary>
		/// System.Globalization.DateTimeFormatFlags InitializeFormatFlags()
		/// </summary>
		protected RMethod r_MInitializeFormatFlags;
		public virtual RMethod RMInitializeFormatFlags
		{
			get
			{
				if(r_MInitializeFormatFlags == null)
				{
					r_MInitializeFormatFlags = new(this, "InitializeFormatFlags", 0);
				}
				return r_MInitializeFormatFlags;
			}
		}

		/// <summary>
		/// Boolean YearMonthAdjustment(Int32 ByRef, Int32 ByRef, Boolean)
		/// </summary>
		protected RMethod r_MYearMonthAdjustment_Ref_Int32_Ref_Int32_Boolean;
		public virtual RMethod RMYearMonthAdjustment_Ref_Int32_Ref_Int32_Boolean
		{
			get
			{
				if(r_MYearMonthAdjustment_Ref_Int32_Ref_Int32_Boolean == null)
				{
					r_MYearMonthAdjustment_Ref_Int32_Ref_Int32_Boolean = new(this, "YearMonthAdjustment", 0, typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Boolean));
				}
				return r_MYearMonthAdjustment_Ref_Int32_Ref_Int32_Boolean;
			}
		}

		/// <summary>
		/// System.Globalization.DateTimeFormatInfo GetJapaneseCalendarDTFI()
		/// </summary>
		protected static RMethod r_MGetJapaneseCalendarDTFI;
		public static RMethod RMGetJapaneseCalendarDTFI
		{
			get
			{
				if(r_MGetJapaneseCalendarDTFI == null)
				{
					r_MGetJapaneseCalendarDTFI = new(Type, "GetJapaneseCalendarDTFI", 0);
				}
				return r_MGetJapaneseCalendarDTFI;
			}
		}

		/// <summary>
		/// System.Globalization.DateTimeFormatInfo GetTaiwanCalendarDTFI()
		/// </summary>
		protected static RMethod r_MGetTaiwanCalendarDTFI;
		public static RMethod RMGetTaiwanCalendarDTFI
		{
			get
			{
				if(r_MGetTaiwanCalendarDTFI == null)
				{
					r_MGetTaiwanCalendarDTFI = new(Type, "GetTaiwanCalendarDTFI", 0);
				}
				return r_MGetTaiwanCalendarDTFI;
			}
		}

		/// <summary>
		/// Void ClearTokenHashTable()
		/// </summary>
		protected RMethod r_MClearTokenHashTable;
		public virtual RMethod RMClearTokenHashTable
		{
			get
			{
				if(r_MClearTokenHashTable == null)
				{
					r_MClearTokenHashTable = new(this, "ClearTokenHashTable", 0);
				}
				return r_MClearTokenHashTable;
			}
		}

		/// <summary>
		/// TokenHashValue[] CreateTokenHashTable()
		/// </summary>
		protected RMethod r_MCreateTokenHashTable;
		public virtual RMethod RMCreateTokenHashTable
		{
			get
			{
				if(r_MCreateTokenHashTable == null)
				{
					r_MCreateTokenHashTable = new(this, "CreateTokenHashTable", 0);
				}
				return r_MCreateTokenHashTable;
			}
		}

		/// <summary>
		/// Void PopulateSpecialTokenHashTable(TokenHashValue[], Boolean ByRef)
		/// </summary>
		protected RMethod r_MPopulateSpecialTokenHashTable_TokenHashValueArray_Ref_Boolean;
		public virtual RMethod RMPopulateSpecialTokenHashTable_TokenHashValueArray_Ref_Boolean
		{
			get
			{
				if(r_MPopulateSpecialTokenHashTable_TokenHashValueArray_Ref_Boolean == null)
				{
					r_MPopulateSpecialTokenHashTable_TokenHashValueArray_Ref_Boolean = new(this, "PopulateSpecialTokenHashTable", 0,  ReflectionUtils.GetType("System.Globalization.DateTimeFormatInfo+TokenHashValue").MakeArrayType(), typeof(System.Boolean).MakeByRefType());
				}
				return r_MPopulateSpecialTokenHashTable_TokenHashValueArray_Ref_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsJapaneseCalendar(System.Globalization.Calendar)
		/// </summary>
		protected static RMethod r_MIsJapaneseCalendar_Calendar;
		public static RMethod RMIsJapaneseCalendar_Calendar
		{
			get
			{
				if(r_MIsJapaneseCalendar_Calendar == null)
				{
					r_MIsJapaneseCalendar_Calendar = new(Type, "IsJapaneseCalendar", 0, typeof(System.Globalization.Calendar));
				}
				return r_MIsJapaneseCalendar_Calendar;
			}
		}

		/// <summary>
		/// Void AddMonthNames(TokenHashValue[], System.String)
		/// </summary>
		protected RMethod r_MAddMonthNames_TokenHashValueArray_String;
		public virtual RMethod RMAddMonthNames_TokenHashValueArray_String
		{
			get
			{
				if(r_MAddMonthNames_TokenHashValueArray_String == null)
				{
					r_MAddMonthNames_TokenHashValueArray_String = new(this, "AddMonthNames", 0,  ReflectionUtils.GetType("System.Globalization.DateTimeFormatInfo+TokenHashValue").MakeArrayType(), typeof(System.String));
				}
				return r_MAddMonthNames_TokenHashValueArray_String;
			}
		}

		/// <summary>
		/// Boolean TryParseHebrewNumber(System.__DTString ByRef, Boolean ByRef, Int32 ByRef)
		/// </summary>
		protected static RMethod r_MTryParseHebrewNumber_Ref___DTString_Out_Boolean_Out_Int32;
		public static RMethod RMTryParseHebrewNumber_Ref___DTString_Out_Boolean_Out_Int32
		{
			get
			{
				if(r_MTryParseHebrewNumber_Ref___DTString_Out_Boolean_Out_Int32 == null)
				{
					r_MTryParseHebrewNumber_Ref___DTString_Out_Boolean_Out_Int32 = new(Type, "TryParseHebrewNumber", 0,  ReflectionUtils.GetType("System.__DTString").MakeByRefType(), typeof(System.Boolean).MakeByRefType(), typeof(System.Int32).MakeByRefType());
				}
				return r_MTryParseHebrewNumber_Ref___DTString_Out_Boolean_Out_Int32;
			}
		}

		/// <summary>
		/// Boolean IsHebrewChar(Char)
		/// </summary>
		protected static RMethod r_MIsHebrewChar_Char;
		public static RMethod RMIsHebrewChar_Char
		{
			get
			{
				if(r_MIsHebrewChar_Char == null)
				{
					r_MIsHebrewChar_Char = new(Type, "IsHebrewChar", 0, typeof(System.Char));
				}
				return r_MIsHebrewChar_Char;
			}
		}

		/// <summary>
		/// Boolean IsAllowedJapaneseTokenFollowedByNonSpaceLetter(System.String, Char)
		/// </summary>
		protected RMethod r_MIsAllowedJapaneseTokenFollowedByNonSpaceLetter_String_Char;
		public virtual RMethod RMIsAllowedJapaneseTokenFollowedByNonSpaceLetter_String_Char
		{
			get
			{
				if(r_MIsAllowedJapaneseTokenFollowedByNonSpaceLetter_String_Char == null)
				{
					r_MIsAllowedJapaneseTokenFollowedByNonSpaceLetter_String_Char = new(this, "IsAllowedJapaneseTokenFollowedByNonSpaceLetter", 0, typeof(System.String), typeof(System.Char));
				}
				return r_MIsAllowedJapaneseTokenFollowedByNonSpaceLetter_String_Char;
			}
		}

		/// <summary>
		/// Boolean Tokenize(System.TokenType, System.TokenType ByRef, Int32 ByRef, System.__DTString ByRef)
		/// </summary>
		protected RMethod r_MTokenize_TokenType_Out_TokenType_Out_Int32_Ref___DTString;
		public virtual RMethod RMTokenize_TokenType_Out_TokenType_Out_Int32_Ref___DTString
		{
			get
			{
				if(r_MTokenize_TokenType_Out_TokenType_Out_Int32_Ref___DTString == null)
				{
					r_MTokenize_TokenType_Out_TokenType_Out_Int32_Ref___DTString = new(this, "Tokenize", 0,  ReflectionUtils.GetType("System.TokenType"),  ReflectionUtils.GetType("System.TokenType").MakeByRefType(), typeof(System.Int32).MakeByRefType(),  ReflectionUtils.GetType("System.__DTString").MakeByRefType());
				}
				return r_MTokenize_TokenType_Out_TokenType_Out_Int32_Ref___DTString;
			}
		}

		/// <summary>
		/// Void InsertAtCurrentHashNode(TokenHashValue[], System.String, Char, System.TokenType, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MInsertAtCurrentHashNode_TokenHashValueArray_String_Char_TokenType_Int32_Int32_Int32_Int32;
		public virtual RMethod RMInsertAtCurrentHashNode_TokenHashValueArray_String_Char_TokenType_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MInsertAtCurrentHashNode_TokenHashValueArray_String_Char_TokenType_Int32_Int32_Int32_Int32 == null)
				{
					r_MInsertAtCurrentHashNode_TokenHashValueArray_String_Char_TokenType_Int32_Int32_Int32_Int32 = new(this, "InsertAtCurrentHashNode", 0,  ReflectionUtils.GetType("System.Globalization.DateTimeFormatInfo+TokenHashValue").MakeArrayType(), typeof(System.String), typeof(System.Char),  ReflectionUtils.GetType("System.TokenType"), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MInsertAtCurrentHashNode_TokenHashValueArray_String_Char_TokenType_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void InsertHash(TokenHashValue[], System.String, System.TokenType, Int32)
		/// </summary>
		protected RMethod r_MInsertHash_TokenHashValueArray_String_TokenType_Int32;
		public virtual RMethod RMInsertHash_TokenHashValueArray_String_TokenType_Int32
		{
			get
			{
				if(r_MInsertHash_TokenHashValueArray_String_TokenType_Int32 == null)
				{
					r_MInsertHash_TokenHashValueArray_String_TokenType_Int32 = new(this, "InsertHash", 0,  ReflectionUtils.GetType("System.Globalization.DateTimeFormatInfo+TokenHashValue").MakeArrayType(), typeof(System.String),  ReflectionUtils.GetType("System.TokenType"), typeof(System.Int32));
				}
				return r_MInsertHash_TokenHashValueArray_String_TokenType_Int32;
			}
		}

		/// <summary>
		/// Boolean CompareStringIgnoreCaseOptimized(System.String, Int32, Int32, System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_MCompareStringIgnoreCaseOptimized_String_Int32_Int32_String_Int32_Int32;
		public virtual RMethod RMCompareStringIgnoreCaseOptimized_String_Int32_Int32_String_Int32_Int32
		{
			get
			{
				if(r_MCompareStringIgnoreCaseOptimized_String_Int32_Int32_String_Int32_Int32 == null)
				{
					r_MCompareStringIgnoreCaseOptimized_String_Int32_Int32_String_Int32_Int32 = new(this, "CompareStringIgnoreCaseOptimized", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MCompareStringIgnoreCaseOptimized_String_Int32_Int32_String_Int32_Int32;
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


        public virtual System.String[] internalGetAbbreviatedDayOfWeekNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMinternalGetAbbreviatedDayOfWeekNames.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String[]>(___result);
        }


        public virtual System.String[] internalGetAbbreviatedDayOfWeekNamesCore()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMinternalGetAbbreviatedDayOfWeekNamesCore.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String[]>(___result);
        }


        public virtual System.String[] internalGetSuperShortDayNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMinternalGetSuperShortDayNames.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String[]>(___result);
        }


        public virtual System.String[] internalGetSuperShortDayNamesCore()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMinternalGetSuperShortDayNamesCore.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String[]>(___result);
        }


        public virtual System.String[] internalGetDayOfWeekNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMinternalGetDayOfWeekNames.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String[]>(___result);
        }


        public virtual System.String[] internalGetDayOfWeekNamesCore()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMinternalGetDayOfWeekNamesCore.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String[]>(___result);
        }


        public virtual System.String[] internalGetAbbreviatedMonthNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMinternalGetAbbreviatedMonthNames.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String[]>(___result);
        }


        public virtual System.String[] internalGetAbbreviatedMonthNamesCore()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMinternalGetAbbreviatedMonthNamesCore.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String[]>(___result);
        }


        public virtual System.String[] internalGetMonthNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMinternalGetMonthNames.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String[]>(___result);
        }


        public virtual System.String[] internalGetMonthNamesCore()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMinternalGetMonthNamesCore.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String[]>(___result);
        }


        public virtual void InitializeOverridableProperties(Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureData @cultureData, System.Int32 @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cultureData.Value, @calendarId};
            var ___result = RMInitializeOverridableProperties_CultureData_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Globalization.DateTimeFormatInfo GetInstance(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMGetInstance_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Globalization.DateTimeFormatInfo>(___result);
        }


        public virtual System.Object GetFormat(System.Type @formatType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@formatType};
            var ___result = RMGetFormat_Type.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Int32 GetEra(System.String @eraName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eraName};
            var ___result = RMGetEra_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String GetEraName(System.Int32 @era)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@era};
            var ___result = RMGetEraName_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String GetAbbreviatedEraName(System.Int32 @era)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@era};
            var ___result = RMGetAbbreviatedEraName_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public static void CheckNullValue(System.String[] @values, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@values, @length};
            var ___result = RMCheckNullValue_StringArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String internalGetMonthName(System.Int32 @month, Hvak.Editor.Refleaction.RSystem.RGlobalization.RMonthNameStyles @style, System.Boolean @abbreviated)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@month, @style.Value, @abbreviated};
            var ___result = RMinternalGetMonthName_Int32_MonthNameStyles_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String[] internalGetGenitiveMonthNames(System.Boolean @abbreviated)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@abbreviated};
            var ___result = RMinternalGetGenitiveMonthNames_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String[]>(___result);
        }


        public virtual System.String[] internalGetLeapYearMonthNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMinternalGetLeapYearMonthNames.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String[]>(___result);
        }


        public virtual System.String GetAbbreviatedDayName(System.DayOfWeek @dayofweek)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dayofweek};
            var ___result = RMGetAbbreviatedDayName_DayOfWeek.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String GetShortestDayName(System.DayOfWeek @dayOfWeek)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dayOfWeek};
            var ___result = RMGetShortestDayName_DayOfWeek.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public static System.String[] GetCombinedPatterns(System.String[] @patterns1, System.String[] @patterns2, System.String @connectString)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@patterns1, @patterns2, @connectString};
            var ___result = RMGetCombinedPatterns_StringArray_StringArray_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String[]>(___result);
        }


        public virtual System.String[] GetAllDateTimePatterns()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetAllDateTimePatterns.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String[]>(___result);
        }


        public virtual System.String[] GetAllDateTimePatterns(System.Char @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMGetAllDateTimePatterns_Char.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String[]>(___result);
        }


        public virtual System.String GetDayName(System.DayOfWeek @dayofweek)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dayofweek};
            var ___result = RMGetDayName_DayOfWeek.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String GetAbbreviatedMonthName(System.Int32 @month)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@month};
            var ___result = RMGetAbbreviatedMonthName_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String GetMonthName(System.Int32 @month)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@month};
            var ___result = RMGetMonthName_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public static System.String[] GetMergedPatterns(System.String[] @patterns, System.String @defaultPattern)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@patterns, @defaultPattern};
            var ___result = RMGetMergedPatterns_StringArray_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String[]>(___result);
        }


        public static System.Globalization.DateTimeFormatInfo ReadOnly(System.Globalization.DateTimeFormatInfo @dtfi)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dtfi};
            var ___result = RMReadOnly_DateTimeFormatInfo.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Globalization.DateTimeFormatInfo>(___result);
        }


        public virtual void SetAllDateTimePatterns(System.String[] @patterns, System.Char @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@patterns, @format};
            var ___result = RMSetAllDateTimePatterns_StringArray_Char.Invoke(___genericsType, ___parameters);

            
        }


        public static void ValidateStyles(System.Globalization.DateTimeStyles @style, System.String @parameterName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style, @parameterName};
            var ___result = RMValidateStyles_DateTimeStyles_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RDateTimeFormatFlags InitializeFormatFlags()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitializeFormatFlags.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RGlobalization.RDateTimeFormatFlags>(___result);
        }


        public virtual System.Boolean YearMonthAdjustment(ref System.Int32 @year, ref System.Int32 @month, System.Boolean @parsedMonthName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @month, @parsedMonthName};
            var ___result = RMYearMonthAdjustment_Ref_Int32_Ref_Int32_Boolean.Invoke(___genericsType, ___parameters);
			@year = ReflectionUtils.Convert<System.Int32>(___parameters[0]);
			@month = ReflectionUtils.Convert<System.Int32>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Globalization.DateTimeFormatInfo GetJapaneseCalendarDTFI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetJapaneseCalendarDTFI.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Globalization.DateTimeFormatInfo>(___result);
        }


        public static System.Globalization.DateTimeFormatInfo GetTaiwanCalendarDTFI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTaiwanCalendarDTFI.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Globalization.DateTimeFormatInfo>(___result);
        }


        public virtual void ClearTokenHashTable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearTokenHashTable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RSystem.RGlobalization.RDateTimeFormatInfo.RTokenHashValue> CreateTokenHashTable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateTokenHashTable.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RSystem.RGlobalization.RDateTimeFormatInfo.RTokenHashValue>>(___result);
        }


        public virtual void PopulateSpecialTokenHashTable(Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RSystem.RGlobalization.RDateTimeFormatInfo.RTokenHashValue> @temp, ref System.Boolean @useDateSepAsIgnorableSymbol)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@temp.Value, @useDateSepAsIgnorableSymbol};
            var ___result = RMPopulateSpecialTokenHashTable_TokenHashValueArray_Ref_Boolean.Invoke(___genericsType, ___parameters);
			@useDateSepAsIgnorableSymbol = ReflectionUtils.Convert<System.Boolean>(___parameters[1]);

            
        }


        public static System.Boolean IsJapaneseCalendar(System.Globalization.Calendar @calendar)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendar};
            var ___result = RMIsJapaneseCalendar_Calendar.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void AddMonthNames(Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RSystem.RGlobalization.RDateTimeFormatInfo.RTokenHashValue> @temp, System.String @monthPostfix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@temp.Value, @monthPostfix};
            var ___result = RMAddMonthNames_TokenHashValueArray_String.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean TryParseHebrewNumber(ref Hvak.Editor.Refleaction.RSystem.R__DTString @str, out System.Boolean @badFormat, out System.Int32 @number)
        {
			@badFormat = default;
			@number = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str.Value, @badFormat, @number};
            var ___result = RMTryParseHebrewNumber_Ref___DTString_Out_Boolean_Out_Int32.Invoke(___genericsType, ___parameters);
			@str = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.R__DTString>(___parameters[0]);
			@badFormat = ReflectionUtils.Convert<System.Boolean>(___parameters[1]);
			@number = ReflectionUtils.Convert<System.Int32>(___parameters[2]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean IsHebrewChar(System.Char @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RMIsHebrewChar_Char.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean IsAllowedJapaneseTokenFollowedByNonSpaceLetter(System.String @tokenString, System.Char @nextCh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tokenString, @nextCh};
            var ___result = RMIsAllowedJapaneseTokenFollowedByNonSpaceLetter_String_Char.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Tokenize(Hvak.Editor.Refleaction.RSystem.RTokenType @TokenMask, out Hvak.Editor.Refleaction.RSystem.RTokenType @tokenType, out System.Int32 @tokenValue, ref Hvak.Editor.Refleaction.RSystem.R__DTString @str)
        {
			@tokenType = default;
			@tokenValue = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@TokenMask.Value, @tokenType.Value, @tokenValue, @str.Value};
            var ___result = RMTokenize_TokenType_Out_TokenType_Out_Int32_Ref___DTString.Invoke(___genericsType, ___parameters);
			@tokenType = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RTokenType>(___parameters[1]);
			@tokenValue = ReflectionUtils.Convert<System.Int32>(___parameters[2]);
			@str = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.R__DTString>(___parameters[3]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void InsertAtCurrentHashNode(Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RSystem.RGlobalization.RDateTimeFormatInfo.RTokenHashValue> @hashTable, System.String @str, System.Char @ch, Hvak.Editor.Refleaction.RSystem.RTokenType @tokenType, System.Int32 @tokenValue, System.Int32 @pos, System.Int32 @hashcode, System.Int32 @hashProbe)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hashTable.Value, @str, @ch, @tokenType.Value, @tokenValue, @pos, @hashcode, @hashProbe};
            var ___result = RMInsertAtCurrentHashNode_TokenHashValueArray_String_Char_TokenType_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InsertHash(Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RSystem.RGlobalization.RDateTimeFormatInfo.RTokenHashValue> @hashTable, System.String @str, Hvak.Editor.Refleaction.RSystem.RTokenType @tokenType, System.Int32 @tokenValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hashTable.Value, @str, @tokenType.Value, @tokenValue};
            var ___result = RMInsertHash_TokenHashValueArray_String_TokenType_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CompareStringIgnoreCaseOptimized(System.String @string1, System.Int32 @offset1, System.Int32 @length1, System.String @string2, System.Int32 @offset2, System.Int32 @length2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@string1, @offset1, @length1, @string2, @offset2, @length2};
            var ___result = RMCompareStringIgnoreCaseOptimized_String_Int32_Int32_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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
