using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RGlobalization
{
	/// <summary>
	/// System.Globalization.DateTimeFormatInfo
	/// </summary>
    public partial class RDateTimeFormatInfo : RMember //
    {

		/// <summary>
		/// System.Globalization.DateTimeFormatInfo s_invariantInfo
		/// </summary>
		protected static RSystem.RGlobalization.RDateTimeFormatInfo r_s_invariantInfo;
		public static RSystem.RGlobalization.RDateTimeFormatInfo Rs_invariantInfo
		{
			get
			{
				if(r_s_invariantInfo == null)
				{
					r_s_invariantInfo = new(typeof(System.Globalization.DateTimeFormatInfo), "s_invariantInfo");
					r_s_invariantInfo.SetBelong(null);
				}
				return r_s_invariantInfo;
			}
		}

		/// <summary>
		/// System.Globalization.CultureData _cultureData
		/// </summary>
		protected RSystem.RGlobalization.RCultureData r__cultureData;
		public virtual RSystem.RGlobalization.RCultureData R_cultureData
		{
			get
			{
				if(r__cultureData == null)
				{
					r__cultureData = new(this, "_cultureData");
					r__cultureData.SetBelong(this.instance);
				}
				return r__cultureData;
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
		/// System.String _langName
		/// </summary>
		protected RField r__langName;
		public virtual RField R_langName
		{
			get
			{
				if(r__langName == null)
				{
					r__langName = new(this, "_langName");
					r__langName.SetBelong(this.instance);
				}
				return r__langName;
			}
		}

		/// <summary>
		/// System.Globalization.CompareInfo _compareInfo
		/// </summary>
		protected RSystem.RGlobalization.RCompareInfo r__compareInfo;
		public virtual RSystem.RGlobalization.RCompareInfo R_compareInfo
		{
			get
			{
				if(r__compareInfo == null)
				{
					r__compareInfo = new(this, "_compareInfo");
					r__compareInfo.SetBelong(this.instance);
				}
				return r__compareInfo;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo _cultureInfo
		/// </summary>
		protected RSystem.RGlobalization.RCultureInfo r__cultureInfo;
		public virtual RSystem.RGlobalization.RCultureInfo R_cultureInfo
		{
			get
			{
				if(r__cultureInfo == null)
				{
					r__cultureInfo = new(this, "_cultureInfo");
					r__cultureInfo.SetBelong(this.instance);
				}
				return r__cultureInfo;
			}
		}

		/// <summary>
		/// System.String amDesignator
		/// </summary>
		protected RField r_amDesignator;
		public virtual RField RamDesignator
		{
			get
			{
				if(r_amDesignator == null)
				{
					r_amDesignator = new(this, "amDesignator");
					r_amDesignator.SetBelong(this.instance);
				}
				return r_amDesignator;
			}
		}

		/// <summary>
		/// System.String pmDesignator
		/// </summary>
		protected RField r_pmDesignator;
		public virtual RField RpmDesignator
		{
			get
			{
				if(r_pmDesignator == null)
				{
					r_pmDesignator = new(this, "pmDesignator");
					r_pmDesignator.SetBelong(this.instance);
				}
				return r_pmDesignator;
			}
		}

		/// <summary>
		/// System.String dateSeparator
		/// </summary>
		protected RField r_dateSeparator;
		public virtual RField RdateSeparator
		{
			get
			{
				if(r_dateSeparator == null)
				{
					r_dateSeparator = new(this, "dateSeparator");
					r_dateSeparator.SetBelong(this.instance);
				}
				return r_dateSeparator;
			}
		}

		/// <summary>
		/// System.String generalShortTimePattern
		/// </summary>
		protected RField r_generalShortTimePattern;
		public virtual RField RgeneralShortTimePattern
		{
			get
			{
				if(r_generalShortTimePattern == null)
				{
					r_generalShortTimePattern = new(this, "generalShortTimePattern");
					r_generalShortTimePattern.SetBelong(this.instance);
				}
				return r_generalShortTimePattern;
			}
		}

		/// <summary>
		/// System.String generalLongTimePattern
		/// </summary>
		protected RField r_generalLongTimePattern;
		public virtual RField RgeneralLongTimePattern
		{
			get
			{
				if(r_generalLongTimePattern == null)
				{
					r_generalLongTimePattern = new(this, "generalLongTimePattern");
					r_generalLongTimePattern.SetBelong(this.instance);
				}
				return r_generalLongTimePattern;
			}
		}

		/// <summary>
		/// System.String timeSeparator
		/// </summary>
		protected RField r_timeSeparator;
		public virtual RField RtimeSeparator
		{
			get
			{
				if(r_timeSeparator == null)
				{
					r_timeSeparator = new(this, "timeSeparator");
					r_timeSeparator.SetBelong(this.instance);
				}
				return r_timeSeparator;
			}
		}

		/// <summary>
		/// System.String monthDayPattern
		/// </summary>
		protected RField r_monthDayPattern;
		public virtual RField RmonthDayPattern
		{
			get
			{
				if(r_monthDayPattern == null)
				{
					r_monthDayPattern = new(this, "monthDayPattern");
					r_monthDayPattern.SetBelong(this.instance);
				}
				return r_monthDayPattern;
			}
		}

		/// <summary>
		/// System.String dateTimeOffsetPattern
		/// </summary>
		protected RField r_dateTimeOffsetPattern;
		public virtual RField RdateTimeOffsetPattern
		{
			get
			{
				if(r_dateTimeOffsetPattern == null)
				{
					r_dateTimeOffsetPattern = new(this, "dateTimeOffsetPattern");
					r_dateTimeOffsetPattern.SetBelong(this.instance);
				}
				return r_dateTimeOffsetPattern;
			}
		}

		/// <summary>
		/// System.String rfc1123Pattern
		/// </summary>
		protected static RField r_rfc1123Pattern;
		public static RField Rrfc1123Pattern
		{
			get
			{
				if(r_rfc1123Pattern == null)
				{
					r_rfc1123Pattern = new(typeof(System.Globalization.DateTimeFormatInfo), "rfc1123Pattern");
					r_rfc1123Pattern.SetBelong(null);
				}
				return r_rfc1123Pattern;
			}
		}

		/// <summary>
		/// System.String sortableDateTimePattern
		/// </summary>
		protected static RField r_sortableDateTimePattern;
		public static RField RsortableDateTimePattern
		{
			get
			{
				if(r_sortableDateTimePattern == null)
				{
					r_sortableDateTimePattern = new(typeof(System.Globalization.DateTimeFormatInfo), "sortableDateTimePattern");
					r_sortableDateTimePattern.SetBelong(null);
				}
				return r_sortableDateTimePattern;
			}
		}

		/// <summary>
		/// System.String universalSortableDateTimePattern
		/// </summary>
		protected static RField r_universalSortableDateTimePattern;
		public static RField RuniversalSortableDateTimePattern
		{
			get
			{
				if(r_universalSortableDateTimePattern == null)
				{
					r_universalSortableDateTimePattern = new(typeof(System.Globalization.DateTimeFormatInfo), "universalSortableDateTimePattern");
					r_universalSortableDateTimePattern.SetBelong(null);
				}
				return r_universalSortableDateTimePattern;
			}
		}

		/// <summary>
		/// System.Globalization.Calendar calendar
		/// </summary>
		protected RSystem.RGlobalization.RCalendar r_calendar;
		public virtual RSystem.RGlobalization.RCalendar Rcalendar
		{
			get
			{
				if(r_calendar == null)
				{
					r_calendar = new(this, "calendar");
					r_calendar.SetBelong(this.instance);
				}
				return r_calendar;
			}
		}

		/// <summary>
		/// System.Int32 firstDayOfWeek
		/// </summary>
		protected RField r_firstDayOfWeek;
		public virtual RField RfirstDayOfWeek
		{
			get
			{
				if(r_firstDayOfWeek == null)
				{
					r_firstDayOfWeek = new(this, "firstDayOfWeek");
					r_firstDayOfWeek.SetBelong(this.instance);
				}
				return r_firstDayOfWeek;
			}
		}

		/// <summary>
		/// System.Int32 calendarWeekRule
		/// </summary>
		protected RField r_calendarWeekRule;
		public virtual RField RcalendarWeekRule
		{
			get
			{
				if(r_calendarWeekRule == null)
				{
					r_calendarWeekRule = new(this, "calendarWeekRule");
					r_calendarWeekRule.SetBelong(this.instance);
				}
				return r_calendarWeekRule;
			}
		}

		/// <summary>
		/// System.String fullDateTimePattern
		/// </summary>
		protected RField r_fullDateTimePattern;
		public virtual RField RfullDateTimePattern
		{
			get
			{
				if(r_fullDateTimePattern == null)
				{
					r_fullDateTimePattern = new(this, "fullDateTimePattern");
					r_fullDateTimePattern.SetBelong(this.instance);
				}
				return r_fullDateTimePattern;
			}
		}

		/// <summary>
		/// System.String[] abbreviatedDayNames
		/// </summary>
		protected RFieldArray<RField> r_abbreviatedDayNames;
		public virtual RFieldArray<RField> RabbreviatedDayNames
		{
			get
			{
				if(r_abbreviatedDayNames == null)
				{
					r_abbreviatedDayNames = new(this, "abbreviatedDayNames");
					r_abbreviatedDayNames.SetBelong(this.instance);
				}
				return r_abbreviatedDayNames;
			}
		}

		/// <summary>
		/// System.String[] m_superShortDayNames
		/// </summary>
		protected RFieldArray<RField> r_m_superShortDayNames;
		public virtual RFieldArray<RField> Rm_superShortDayNames
		{
			get
			{
				if(r_m_superShortDayNames == null)
				{
					r_m_superShortDayNames = new(this, "m_superShortDayNames");
					r_m_superShortDayNames.SetBelong(this.instance);
				}
				return r_m_superShortDayNames;
			}
		}

		/// <summary>
		/// System.String[] dayNames
		/// </summary>
		protected RFieldArray<RField> r_dayNames;
		public virtual RFieldArray<RField> RdayNames
		{
			get
			{
				if(r_dayNames == null)
				{
					r_dayNames = new(this, "dayNames");
					r_dayNames.SetBelong(this.instance);
				}
				return r_dayNames;
			}
		}

		/// <summary>
		/// System.String[] abbreviatedMonthNames
		/// </summary>
		protected RFieldArray<RField> r_abbreviatedMonthNames;
		public virtual RFieldArray<RField> RabbreviatedMonthNames
		{
			get
			{
				if(r_abbreviatedMonthNames == null)
				{
					r_abbreviatedMonthNames = new(this, "abbreviatedMonthNames");
					r_abbreviatedMonthNames.SetBelong(this.instance);
				}
				return r_abbreviatedMonthNames;
			}
		}

		/// <summary>
		/// System.String[] monthNames
		/// </summary>
		protected RFieldArray<RField> r_monthNames;
		public virtual RFieldArray<RField> RmonthNames
		{
			get
			{
				if(r_monthNames == null)
				{
					r_monthNames = new(this, "monthNames");
					r_monthNames.SetBelong(this.instance);
				}
				return r_monthNames;
			}
		}

		/// <summary>
		/// System.String[] genitiveMonthNames
		/// </summary>
		protected RFieldArray<RField> r_genitiveMonthNames;
		public virtual RFieldArray<RField> RgenitiveMonthNames
		{
			get
			{
				if(r_genitiveMonthNames == null)
				{
					r_genitiveMonthNames = new(this, "genitiveMonthNames");
					r_genitiveMonthNames.SetBelong(this.instance);
				}
				return r_genitiveMonthNames;
			}
		}

		/// <summary>
		/// System.String[] m_genitiveAbbreviatedMonthNames
		/// </summary>
		protected RFieldArray<RField> r_m_genitiveAbbreviatedMonthNames;
		public virtual RFieldArray<RField> Rm_genitiveAbbreviatedMonthNames
		{
			get
			{
				if(r_m_genitiveAbbreviatedMonthNames == null)
				{
					r_m_genitiveAbbreviatedMonthNames = new(this, "m_genitiveAbbreviatedMonthNames");
					r_m_genitiveAbbreviatedMonthNames.SetBelong(this.instance);
				}
				return r_m_genitiveAbbreviatedMonthNames;
			}
		}

		/// <summary>
		/// System.String[] leapYearMonthNames
		/// </summary>
		protected RFieldArray<RField> r_leapYearMonthNames;
		public virtual RFieldArray<RField> RleapYearMonthNames
		{
			get
			{
				if(r_leapYearMonthNames == null)
				{
					r_leapYearMonthNames = new(this, "leapYearMonthNames");
					r_leapYearMonthNames.SetBelong(this.instance);
				}
				return r_leapYearMonthNames;
			}
		}

		/// <summary>
		/// System.String longDatePattern
		/// </summary>
		protected RField r_longDatePattern;
		public virtual RField RlongDatePattern
		{
			get
			{
				if(r_longDatePattern == null)
				{
					r_longDatePattern = new(this, "longDatePattern");
					r_longDatePattern.SetBelong(this.instance);
				}
				return r_longDatePattern;
			}
		}

		/// <summary>
		/// System.String shortDatePattern
		/// </summary>
		protected RField r_shortDatePattern;
		public virtual RField RshortDatePattern
		{
			get
			{
				if(r_shortDatePattern == null)
				{
					r_shortDatePattern = new(this, "shortDatePattern");
					r_shortDatePattern.SetBelong(this.instance);
				}
				return r_shortDatePattern;
			}
		}

		/// <summary>
		/// System.String yearMonthPattern
		/// </summary>
		protected RField r_yearMonthPattern;
		public virtual RField RyearMonthPattern
		{
			get
			{
				if(r_yearMonthPattern == null)
				{
					r_yearMonthPattern = new(this, "yearMonthPattern");
					r_yearMonthPattern.SetBelong(this.instance);
				}
				return r_yearMonthPattern;
			}
		}

		/// <summary>
		/// System.String longTimePattern
		/// </summary>
		protected RField r_longTimePattern;
		public virtual RField RlongTimePattern
		{
			get
			{
				if(r_longTimePattern == null)
				{
					r_longTimePattern = new(this, "longTimePattern");
					r_longTimePattern.SetBelong(this.instance);
				}
				return r_longTimePattern;
			}
		}

		/// <summary>
		/// System.String shortTimePattern
		/// </summary>
		protected RField r_shortTimePattern;
		public virtual RField RshortTimePattern
		{
			get
			{
				if(r_shortTimePattern == null)
				{
					r_shortTimePattern = new(this, "shortTimePattern");
					r_shortTimePattern.SetBelong(this.instance);
				}
				return r_shortTimePattern;
			}
		}

		/// <summary>
		/// System.String[] allYearMonthPatterns
		/// </summary>
		protected RFieldArray<RField> r_allYearMonthPatterns;
		public virtual RFieldArray<RField> RallYearMonthPatterns
		{
			get
			{
				if(r_allYearMonthPatterns == null)
				{
					r_allYearMonthPatterns = new(this, "allYearMonthPatterns");
					r_allYearMonthPatterns.SetBelong(this.instance);
				}
				return r_allYearMonthPatterns;
			}
		}

		/// <summary>
		/// System.String[] allShortDatePatterns
		/// </summary>
		protected RFieldArray<RField> r_allShortDatePatterns;
		public virtual RFieldArray<RField> RallShortDatePatterns
		{
			get
			{
				if(r_allShortDatePatterns == null)
				{
					r_allShortDatePatterns = new(this, "allShortDatePatterns");
					r_allShortDatePatterns.SetBelong(this.instance);
				}
				return r_allShortDatePatterns;
			}
		}

		/// <summary>
		/// System.String[] allLongDatePatterns
		/// </summary>
		protected RFieldArray<RField> r_allLongDatePatterns;
		public virtual RFieldArray<RField> RallLongDatePatterns
		{
			get
			{
				if(r_allLongDatePatterns == null)
				{
					r_allLongDatePatterns = new(this, "allLongDatePatterns");
					r_allLongDatePatterns.SetBelong(this.instance);
				}
				return r_allLongDatePatterns;
			}
		}

		/// <summary>
		/// System.String[] allShortTimePatterns
		/// </summary>
		protected RFieldArray<RField> r_allShortTimePatterns;
		public virtual RFieldArray<RField> RallShortTimePatterns
		{
			get
			{
				if(r_allShortTimePatterns == null)
				{
					r_allShortTimePatterns = new(this, "allShortTimePatterns");
					r_allShortTimePatterns.SetBelong(this.instance);
				}
				return r_allShortTimePatterns;
			}
		}

		/// <summary>
		/// System.String[] allLongTimePatterns
		/// </summary>
		protected RFieldArray<RField> r_allLongTimePatterns;
		public virtual RFieldArray<RField> RallLongTimePatterns
		{
			get
			{
				if(r_allLongTimePatterns == null)
				{
					r_allLongTimePatterns = new(this, "allLongTimePatterns");
					r_allLongTimePatterns.SetBelong(this.instance);
				}
				return r_allLongTimePatterns;
			}
		}

		/// <summary>
		/// System.String[] m_eraNames
		/// </summary>
		protected RFieldArray<RField> r_m_eraNames;
		public virtual RFieldArray<RField> Rm_eraNames
		{
			get
			{
				if(r_m_eraNames == null)
				{
					r_m_eraNames = new(this, "m_eraNames");
					r_m_eraNames.SetBelong(this.instance);
				}
				return r_m_eraNames;
			}
		}

		/// <summary>
		/// System.String[] m_abbrevEraNames
		/// </summary>
		protected RFieldArray<RField> r_m_abbrevEraNames;
		public virtual RFieldArray<RField> Rm_abbrevEraNames
		{
			get
			{
				if(r_m_abbrevEraNames == null)
				{
					r_m_abbrevEraNames = new(this, "m_abbrevEraNames");
					r_m_abbrevEraNames.SetBelong(this.instance);
				}
				return r_m_abbrevEraNames;
			}
		}

		/// <summary>
		/// System.String[] m_abbrevEnglishEraNames
		/// </summary>
		protected RFieldArray<RField> r_m_abbrevEnglishEraNames;
		public virtual RFieldArray<RField> Rm_abbrevEnglishEraNames
		{
			get
			{
				if(r_m_abbrevEnglishEraNames == null)
				{
					r_m_abbrevEnglishEraNames = new(this, "m_abbrevEnglishEraNames");
					r_m_abbrevEnglishEraNames.SetBelong(this.instance);
				}
				return r_m_abbrevEnglishEraNames;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarId[] optionalCalendars
		/// </summary>
		protected RFieldArray<RField> r_optionalCalendars;
		public virtual RFieldArray<RField> RoptionalCalendars
		{
			get
			{
				if(r_optionalCalendars == null)
				{
					r_optionalCalendars = new(this, "optionalCalendars");
					r_optionalCalendars.SetBelong(this.instance);
				}
				return r_optionalCalendars;
			}
		}

		/// <summary>
		/// System.Int32 DEFAULT_ALL_DATETIMES_SIZE
		/// </summary>
		protected static RField r_DEFAULT_ALL_DATETIMES_SIZE;
		public static RField RDEFAULT_ALL_DATETIMES_SIZE
		{
			get
			{
				if(r_DEFAULT_ALL_DATETIMES_SIZE == null)
				{
					r_DEFAULT_ALL_DATETIMES_SIZE = new(typeof(System.Globalization.DateTimeFormatInfo), "DEFAULT_ALL_DATETIMES_SIZE");
					r_DEFAULT_ALL_DATETIMES_SIZE.SetBelong(null);
				}
				return r_DEFAULT_ALL_DATETIMES_SIZE;
			}
		}

		/// <summary>
		/// System.Boolean _isReadOnly
		/// </summary>
		protected RField r__isReadOnly;
		public virtual RField R_isReadOnly
		{
			get
			{
				if(r__isReadOnly == null)
				{
					r__isReadOnly = new(this, "_isReadOnly");
					r__isReadOnly.SetBelong(this.instance);
				}
				return r__isReadOnly;
			}
		}

		/// <summary>
		/// System.Globalization.DateTimeFormatFlags formatFlags
		/// </summary>
		protected RField r_formatFlags;
		public virtual RField RformatFlags
		{
			get
			{
				if(r_formatFlags == null)
				{
					r_formatFlags = new(this, "formatFlags");
					r_formatFlags.SetBelong(this.instance);
				}
				return r_formatFlags;
			}
		}

		/// <summary>
		/// System.Char[] s_monthSpaces
		/// </summary>
		protected static RFieldArray<RField> r_s_monthSpaces;
		public static RFieldArray<RField> Rs_monthSpaces
		{
			get
			{
				if(r_s_monthSpaces == null)
				{
					r_s_monthSpaces = new(typeof(System.Globalization.DateTimeFormatInfo), "s_monthSpaces");
					r_s_monthSpaces.SetBelong(null);
				}
				return r_s_monthSpaces;
			}
		}

		/// <summary>
		/// System.String RoundtripFormat
		/// </summary>
		protected static RField r_RoundtripFormat;
		public static RField RoundtripFormat
		{
			get
			{
				if(r_RoundtripFormat == null)
				{
					r_RoundtripFormat = new(typeof(System.Globalization.DateTimeFormatInfo), "RoundtripFormat");
					r_RoundtripFormat.SetBelong(null);
				}
				return r_RoundtripFormat;
			}
		}

		/// <summary>
		/// System.String RoundtripDateTimeUnfixed
		/// </summary>
		protected static RField r_RoundtripDateTimeUnfixed;
		public static RField RoundtripDateTimeUnfixed
		{
			get
			{
				if(r_RoundtripDateTimeUnfixed == null)
				{
					r_RoundtripDateTimeUnfixed = new(typeof(System.Globalization.DateTimeFormatInfo), "RoundtripDateTimeUnfixed");
					r_RoundtripDateTimeUnfixed.SetBelong(null);
				}
				return r_RoundtripDateTimeUnfixed;
			}
		}

		/// <summary>
		/// System.String _fullTimeSpanPositivePattern
		/// </summary>
		protected RField r__fullTimeSpanPositivePattern;
		public virtual RField R_fullTimeSpanPositivePattern
		{
			get
			{
				if(r__fullTimeSpanPositivePattern == null)
				{
					r__fullTimeSpanPositivePattern = new(this, "_fullTimeSpanPositivePattern");
					r__fullTimeSpanPositivePattern.SetBelong(this.instance);
				}
				return r__fullTimeSpanPositivePattern;
			}
		}

		/// <summary>
		/// System.String _fullTimeSpanNegativePattern
		/// </summary>
		protected RField r__fullTimeSpanNegativePattern;
		public virtual RField R_fullTimeSpanNegativePattern
		{
			get
			{
				if(r__fullTimeSpanNegativePattern == null)
				{
					r__fullTimeSpanNegativePattern = new(this, "_fullTimeSpanNegativePattern");
					r__fullTimeSpanNegativePattern.SetBelong(this.instance);
				}
				return r__fullTimeSpanNegativePattern;
			}
		}

		/// <summary>
		/// System.Globalization.DateTimeStyles InvalidDateTimeStyles
		/// </summary>
		protected static RField r_InvalidDateTimeStyles;
		public static RField RInvalidDateTimeStyles
		{
			get
			{
				if(r_InvalidDateTimeStyles == null)
				{
					r_InvalidDateTimeStyles = new(typeof(System.Globalization.DateTimeFormatInfo), "InvalidDateTimeStyles");
					r_InvalidDateTimeStyles.SetBelong(null);
				}
				return r_InvalidDateTimeStyles;
			}
		}

		/// <summary>
		/// System.Globalization.DateTimeFormatInfo+TokenHashValue[] _dtfiTokenHash
		/// </summary>
		protected RFieldArray<RSystem.RGlobalization.RDateTimeFormatInfo.RTokenHashValue> r__dtfiTokenHash;
		public virtual RFieldArray<RSystem.RGlobalization.RDateTimeFormatInfo.RTokenHashValue> R_dtfiTokenHash
		{
			get
			{
				if(r__dtfiTokenHash == null)
				{
					r__dtfiTokenHash = new(this, "_dtfiTokenHash");
					r__dtfiTokenHash.SetBelong(this.instance);
				}
				return r__dtfiTokenHash;
			}
		}

		/// <summary>
		/// System.Int32 TOKEN_HASH_SIZE
		/// </summary>
		protected static RField r_TOKEN_HASH_SIZE;
		public static RField RTOKEN_HASH_SIZE
		{
			get
			{
				if(r_TOKEN_HASH_SIZE == null)
				{
					r_TOKEN_HASH_SIZE = new(typeof(System.Globalization.DateTimeFormatInfo), "TOKEN_HASH_SIZE");
					r_TOKEN_HASH_SIZE.SetBelong(null);
				}
				return r_TOKEN_HASH_SIZE;
			}
		}

		/// <summary>
		/// System.Int32 SECOND_PRIME
		/// </summary>
		protected static RField r_SECOND_PRIME;
		public static RField RSECOND_PRIME
		{
			get
			{
				if(r_SECOND_PRIME == null)
				{
					r_SECOND_PRIME = new(typeof(System.Globalization.DateTimeFormatInfo), "SECOND_PRIME");
					r_SECOND_PRIME.SetBelong(null);
				}
				return r_SECOND_PRIME;
			}
		}

		/// <summary>
		/// System.String dateSeparatorOrTimeZoneOffset
		/// </summary>
		protected static RField r_dateSeparatorOrTimeZoneOffset;
		public static RField RdateSeparatorOrTimeZoneOffset
		{
			get
			{
				if(r_dateSeparatorOrTimeZoneOffset == null)
				{
					r_dateSeparatorOrTimeZoneOffset = new(typeof(System.Globalization.DateTimeFormatInfo), "dateSeparatorOrTimeZoneOffset");
					r_dateSeparatorOrTimeZoneOffset.SetBelong(null);
				}
				return r_dateSeparatorOrTimeZoneOffset;
			}
		}

		/// <summary>
		/// System.String invariantDateSeparator
		/// </summary>
		protected static RField r_invariantDateSeparator;
		public static RField RinvariantDateSeparator
		{
			get
			{
				if(r_invariantDateSeparator == null)
				{
					r_invariantDateSeparator = new(typeof(System.Globalization.DateTimeFormatInfo), "invariantDateSeparator");
					r_invariantDateSeparator.SetBelong(null);
				}
				return r_invariantDateSeparator;
			}
		}

		/// <summary>
		/// System.String invariantTimeSeparator
		/// </summary>
		protected static RField r_invariantTimeSeparator;
		public static RField RinvariantTimeSeparator
		{
			get
			{
				if(r_invariantTimeSeparator == null)
				{
					r_invariantTimeSeparator = new(typeof(System.Globalization.DateTimeFormatInfo), "invariantTimeSeparator");
					r_invariantTimeSeparator.SetBelong(null);
				}
				return r_invariantTimeSeparator;
			}
		}

		/// <summary>
		/// System.String IgnorablePeriod
		/// </summary>
		protected static RField r_IgnorablePeriod;
		public static RField RIgnorablePeriod
		{
			get
			{
				if(r_IgnorablePeriod == null)
				{
					r_IgnorablePeriod = new(typeof(System.Globalization.DateTimeFormatInfo), "IgnorablePeriod");
					r_IgnorablePeriod.SetBelong(null);
				}
				return r_IgnorablePeriod;
			}
		}

		/// <summary>
		/// System.String IgnorableComma
		/// </summary>
		protected static RField r_IgnorableComma;
		public static RField RIgnorableComma
		{
			get
			{
				if(r_IgnorableComma == null)
				{
					r_IgnorableComma = new(typeof(System.Globalization.DateTimeFormatInfo), "IgnorableComma");
					r_IgnorableComma.SetBelong(null);
				}
				return r_IgnorableComma;
			}
		}

		/// <summary>
		/// System.String CJKYearSuff
		/// </summary>
		protected static RField r_CJKYearSuff;
		public static RField RCJKYearSuff
		{
			get
			{
				if(r_CJKYearSuff == null)
				{
					r_CJKYearSuff = new(typeof(System.Globalization.DateTimeFormatInfo), "CJKYearSuff");
					r_CJKYearSuff.SetBelong(null);
				}
				return r_CJKYearSuff;
			}
		}

		/// <summary>
		/// System.String CJKMonthSuff
		/// </summary>
		protected static RField r_CJKMonthSuff;
		public static RField RCJKMonthSuff
		{
			get
			{
				if(r_CJKMonthSuff == null)
				{
					r_CJKMonthSuff = new(typeof(System.Globalization.DateTimeFormatInfo), "CJKMonthSuff");
					r_CJKMonthSuff.SetBelong(null);
				}
				return r_CJKMonthSuff;
			}
		}

		/// <summary>
		/// System.String CJKDaySuff
		/// </summary>
		protected static RField r_CJKDaySuff;
		public static RField RCJKDaySuff
		{
			get
			{
				if(r_CJKDaySuff == null)
				{
					r_CJKDaySuff = new(typeof(System.Globalization.DateTimeFormatInfo), "CJKDaySuff");
					r_CJKDaySuff.SetBelong(null);
				}
				return r_CJKDaySuff;
			}
		}

		/// <summary>
		/// System.String KoreanYearSuff
		/// </summary>
		protected static RField r_KoreanYearSuff;
		public static RField RKoreanYearSuff
		{
			get
			{
				if(r_KoreanYearSuff == null)
				{
					r_KoreanYearSuff = new(typeof(System.Globalization.DateTimeFormatInfo), "KoreanYearSuff");
					r_KoreanYearSuff.SetBelong(null);
				}
				return r_KoreanYearSuff;
			}
		}

		/// <summary>
		/// System.String KoreanMonthSuff
		/// </summary>
		protected static RField r_KoreanMonthSuff;
		public static RField RKoreanMonthSuff
		{
			get
			{
				if(r_KoreanMonthSuff == null)
				{
					r_KoreanMonthSuff = new(typeof(System.Globalization.DateTimeFormatInfo), "KoreanMonthSuff");
					r_KoreanMonthSuff.SetBelong(null);
				}
				return r_KoreanMonthSuff;
			}
		}

		/// <summary>
		/// System.String KoreanDaySuff
		/// </summary>
		protected static RField r_KoreanDaySuff;
		public static RField RKoreanDaySuff
		{
			get
			{
				if(r_KoreanDaySuff == null)
				{
					r_KoreanDaySuff = new(typeof(System.Globalization.DateTimeFormatInfo), "KoreanDaySuff");
					r_KoreanDaySuff.SetBelong(null);
				}
				return r_KoreanDaySuff;
			}
		}

		/// <summary>
		/// System.String KoreanHourSuff
		/// </summary>
		protected static RField r_KoreanHourSuff;
		public static RField RKoreanHourSuff
		{
			get
			{
				if(r_KoreanHourSuff == null)
				{
					r_KoreanHourSuff = new(typeof(System.Globalization.DateTimeFormatInfo), "KoreanHourSuff");
					r_KoreanHourSuff.SetBelong(null);
				}
				return r_KoreanHourSuff;
			}
		}

		/// <summary>
		/// System.String KoreanMinuteSuff
		/// </summary>
		protected static RField r_KoreanMinuteSuff;
		public static RField RKoreanMinuteSuff
		{
			get
			{
				if(r_KoreanMinuteSuff == null)
				{
					r_KoreanMinuteSuff = new(typeof(System.Globalization.DateTimeFormatInfo), "KoreanMinuteSuff");
					r_KoreanMinuteSuff.SetBelong(null);
				}
				return r_KoreanMinuteSuff;
			}
		}

		/// <summary>
		/// System.String KoreanSecondSuff
		/// </summary>
		protected static RField r_KoreanSecondSuff;
		public static RField RKoreanSecondSuff
		{
			get
			{
				if(r_KoreanSecondSuff == null)
				{
					r_KoreanSecondSuff = new(typeof(System.Globalization.DateTimeFormatInfo), "KoreanSecondSuff");
					r_KoreanSecondSuff.SetBelong(null);
				}
				return r_KoreanSecondSuff;
			}
		}

		/// <summary>
		/// System.String CJKHourSuff
		/// </summary>
		protected static RField r_CJKHourSuff;
		public static RField RCJKHourSuff
		{
			get
			{
				if(r_CJKHourSuff == null)
				{
					r_CJKHourSuff = new(typeof(System.Globalization.DateTimeFormatInfo), "CJKHourSuff");
					r_CJKHourSuff.SetBelong(null);
				}
				return r_CJKHourSuff;
			}
		}

		/// <summary>
		/// System.String ChineseHourSuff
		/// </summary>
		protected static RField r_ChineseHourSuff;
		public static RField RChineseHourSuff
		{
			get
			{
				if(r_ChineseHourSuff == null)
				{
					r_ChineseHourSuff = new(typeof(System.Globalization.DateTimeFormatInfo), "ChineseHourSuff");
					r_ChineseHourSuff.SetBelong(null);
				}
				return r_ChineseHourSuff;
			}
		}

		/// <summary>
		/// System.String CJKMinuteSuff
		/// </summary>
		protected static RField r_CJKMinuteSuff;
		public static RField RCJKMinuteSuff
		{
			get
			{
				if(r_CJKMinuteSuff == null)
				{
					r_CJKMinuteSuff = new(typeof(System.Globalization.DateTimeFormatInfo), "CJKMinuteSuff");
					r_CJKMinuteSuff.SetBelong(null);
				}
				return r_CJKMinuteSuff;
			}
		}

		/// <summary>
		/// System.String CJKSecondSuff
		/// </summary>
		protected static RField r_CJKSecondSuff;
		public static RField RCJKSecondSuff
		{
			get
			{
				if(r_CJKSecondSuff == null)
				{
					r_CJKSecondSuff = new(typeof(System.Globalization.DateTimeFormatInfo), "CJKSecondSuff");
					r_CJKSecondSuff.SetBelong(null);
				}
				return r_CJKSecondSuff;
			}
		}

		/// <summary>
		/// System.String JapaneseEraStart
		/// </summary>
		protected static RField r_JapaneseEraStart;
		public static RField RJapaneseEraStart
		{
			get
			{
				if(r_JapaneseEraStart == null)
				{
					r_JapaneseEraStart = new(typeof(System.Globalization.DateTimeFormatInfo), "JapaneseEraStart");
					r_JapaneseEraStart.SetBelong(null);
				}
				return r_JapaneseEraStart;
			}
		}

		/// <summary>
		/// System.String LocalTimeMark
		/// </summary>
		protected static RField r_LocalTimeMark;
		public static RField RLocalTimeMark
		{
			get
			{
				if(r_LocalTimeMark == null)
				{
					r_LocalTimeMark = new(typeof(System.Globalization.DateTimeFormatInfo), "LocalTimeMark");
					r_LocalTimeMark.SetBelong(null);
				}
				return r_LocalTimeMark;
			}
		}

		/// <summary>
		/// System.String GMTName
		/// </summary>
		protected static RField r_GMTName;
		public static RField RGMTName
		{
			get
			{
				if(r_GMTName == null)
				{
					r_GMTName = new(typeof(System.Globalization.DateTimeFormatInfo), "GMTName");
					r_GMTName.SetBelong(null);
				}
				return r_GMTName;
			}
		}

		/// <summary>
		/// System.String ZuluName
		/// </summary>
		protected static RField r_ZuluName;
		public static RField RZuluName
		{
			get
			{
				if(r_ZuluName == null)
				{
					r_ZuluName = new(typeof(System.Globalization.DateTimeFormatInfo), "ZuluName");
					r_ZuluName.SetBelong(null);
				}
				return r_ZuluName;
			}
		}

		/// <summary>
		/// System.String KoreanLangName
		/// </summary>
		protected static RField r_KoreanLangName;
		public static RField RKoreanLangName
		{
			get
			{
				if(r_KoreanLangName == null)
				{
					r_KoreanLangName = new(typeof(System.Globalization.DateTimeFormatInfo), "KoreanLangName");
					r_KoreanLangName.SetBelong(null);
				}
				return r_KoreanLangName;
			}
		}

		/// <summary>
		/// System.String JapaneseLangName
		/// </summary>
		protected static RField r_JapaneseLangName;
		public static RField RJapaneseLangName
		{
			get
			{
				if(r_JapaneseLangName == null)
				{
					r_JapaneseLangName = new(typeof(System.Globalization.DateTimeFormatInfo), "JapaneseLangName");
					r_JapaneseLangName.SetBelong(null);
				}
				return r_JapaneseLangName;
			}
		}

		/// <summary>
		/// System.String EnglishLangName
		/// </summary>
		protected static RField r_EnglishLangName;
		public static RField REnglishLangName
		{
			get
			{
				if(r_EnglishLangName == null)
				{
					r_EnglishLangName = new(typeof(System.Globalization.DateTimeFormatInfo), "EnglishLangName");
					r_EnglishLangName.SetBelong(null);
				}
				return r_EnglishLangName;
			}
		}

		/// <summary>
		/// System.Globalization.DateTimeFormatInfo s_jajpDTFI
		/// </summary>
		protected static RSystem.RGlobalization.RDateTimeFormatInfo r_s_jajpDTFI;
		public static RSystem.RGlobalization.RDateTimeFormatInfo Rs_jajpDTFI
		{
			get
			{
				if(r_s_jajpDTFI == null)
				{
					r_s_jajpDTFI = new(typeof(System.Globalization.DateTimeFormatInfo), "s_jajpDTFI");
					r_s_jajpDTFI.SetBelong(null);
				}
				return r_s_jajpDTFI;
			}
		}

		/// <summary>
		/// System.Globalization.DateTimeFormatInfo s_zhtwDTFI
		/// </summary>
		protected static RSystem.RGlobalization.RDateTimeFormatInfo r_s_zhtwDTFI;
		public static RSystem.RGlobalization.RDateTimeFormatInfo Rs_zhtwDTFI
		{
			get
			{
				if(r_s_zhtwDTFI == null)
				{
					r_s_zhtwDTFI = new(typeof(System.Globalization.DateTimeFormatInfo), "s_zhtwDTFI");
					r_s_zhtwDTFI.SetBelong(null);
				}
				return r_s_zhtwDTFI;
			}
		}

		/// <summary>
		/// System.String CultureName
		/// </summary>
		protected RProperty r_CultureName;
		public virtual RProperty RCultureName
		{
			get
			{
				if(r_CultureName == null)
				{
					r_CultureName = new(this, "CultureName", -1);
					r_CultureName.SetBelong(this.instance);
				}
				return r_CultureName;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo Culture
		/// </summary>
		protected RSystem.RGlobalization.RCultureInfo r_Culture;
		public virtual RSystem.RGlobalization.RCultureInfo RCulture
		{
			get
			{
				if(r_Culture == null)
				{
					r_Culture = new(this, "Culture", -1);
					r_Culture.SetBelong(this.instance);
				}
				return r_Culture;
			}
		}

		/// <summary>
		/// System.String LanguageName
		/// </summary>
		protected RProperty r_LanguageName;
		public virtual RProperty RLanguageName
		{
			get
			{
				if(r_LanguageName == null)
				{
					r_LanguageName = new(this, "LanguageName", -1);
					r_LanguageName.SetBelong(this.instance);
				}
				return r_LanguageName;
			}
		}

		/// <summary>
		/// System.Globalization.DateTimeFormatInfo InvariantInfo
		/// </summary>
		protected static RSystem.RGlobalization.RDateTimeFormatInfo r_InvariantInfo;
		public static RSystem.RGlobalization.RDateTimeFormatInfo RInvariantInfo
		{
			get
			{
				if(r_InvariantInfo == null)
				{
					r_InvariantInfo = new(typeof(System.Globalization.DateTimeFormatInfo), "InvariantInfo", -1);
					r_InvariantInfo.SetBelong(null);
				}
				return r_InvariantInfo;
			}
		}

		/// <summary>
		/// System.Globalization.DateTimeFormatInfo CurrentInfo
		/// </summary>
		protected static RSystem.RGlobalization.RDateTimeFormatInfo r_CurrentInfo;
		public static RSystem.RGlobalization.RDateTimeFormatInfo RCurrentInfo
		{
			get
			{
				if(r_CurrentInfo == null)
				{
					r_CurrentInfo = new(typeof(System.Globalization.DateTimeFormatInfo), "CurrentInfo", -1);
					r_CurrentInfo.SetBelong(null);
				}
				return r_CurrentInfo;
			}
		}

		/// <summary>
		/// System.String AMDesignator
		/// </summary>
		protected RProperty r_AMDesignator;
		public virtual RProperty RAMDesignator
		{
			get
			{
				if(r_AMDesignator == null)
				{
					r_AMDesignator = new(this, "AMDesignator", -1);
					r_AMDesignator.SetBelong(this.instance);
				}
				return r_AMDesignator;
			}
		}

		/// <summary>
		/// System.Globalization.Calendar Calendar
		/// </summary>
		protected RSystem.RGlobalization.RCalendar r_Calendar;
		public virtual RSystem.RGlobalization.RCalendar RCalendar
		{
			get
			{
				if(r_Calendar == null)
				{
					r_Calendar = new(this, "Calendar", -1);
					r_Calendar.SetBelong(this.instance);
				}
				return r_Calendar;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarId[] OptionalCalendars
		/// </summary>
		protected RPropertyArray<RProperty> r_OptionalCalendars;
		public virtual RPropertyArray<RProperty> ROptionalCalendars
		{
			get
			{
				if(r_OptionalCalendars == null)
				{
					r_OptionalCalendars = new(this, "OptionalCalendars", -1);
					r_OptionalCalendars.SetBelong(this.instance);
				}
				return r_OptionalCalendars;
			}
		}

		/// <summary>
		/// System.String[] EraNames
		/// </summary>
		protected RPropertyArray<RProperty> r_EraNames;
		public virtual RPropertyArray<RProperty> REraNames
		{
			get
			{
				if(r_EraNames == null)
				{
					r_EraNames = new(this, "EraNames", -1);
					r_EraNames.SetBelong(this.instance);
				}
				return r_EraNames;
			}
		}

		/// <summary>
		/// System.String[] AbbreviatedEraNames
		/// </summary>
		protected RPropertyArray<RProperty> r_AbbreviatedEraNames;
		public virtual RPropertyArray<RProperty> RAbbreviatedEraNames
		{
			get
			{
				if(r_AbbreviatedEraNames == null)
				{
					r_AbbreviatedEraNames = new(this, "AbbreviatedEraNames", -1);
					r_AbbreviatedEraNames.SetBelong(this.instance);
				}
				return r_AbbreviatedEraNames;
			}
		}

		/// <summary>
		/// System.String[] AbbreviatedEnglishEraNames
		/// </summary>
		protected RPropertyArray<RProperty> r_AbbreviatedEnglishEraNames;
		public virtual RPropertyArray<RProperty> RAbbreviatedEnglishEraNames
		{
			get
			{
				if(r_AbbreviatedEnglishEraNames == null)
				{
					r_AbbreviatedEnglishEraNames = new(this, "AbbreviatedEnglishEraNames", -1);
					r_AbbreviatedEnglishEraNames.SetBelong(this.instance);
				}
				return r_AbbreviatedEnglishEraNames;
			}
		}

		/// <summary>
		/// System.String DateSeparator
		/// </summary>
		protected RProperty r_DateSeparator;
		public virtual RProperty RDateSeparator
		{
			get
			{
				if(r_DateSeparator == null)
				{
					r_DateSeparator = new(this, "DateSeparator", -1);
					r_DateSeparator.SetBelong(this.instance);
				}
				return r_DateSeparator;
			}
		}

		/// <summary>
		/// System.DayOfWeek FirstDayOfWeek
		/// </summary>
		protected RProperty r_FirstDayOfWeek;
		public virtual RProperty RFirstDayOfWeek
		{
			get
			{
				if(r_FirstDayOfWeek == null)
				{
					r_FirstDayOfWeek = new(this, "FirstDayOfWeek", -1);
					r_FirstDayOfWeek.SetBelong(this.instance);
				}
				return r_FirstDayOfWeek;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarWeekRule CalendarWeekRule
		/// </summary>
		protected RProperty r_CalendarWeekRule;
		public virtual RProperty RCalendarWeekRule
		{
			get
			{
				if(r_CalendarWeekRule == null)
				{
					r_CalendarWeekRule = new(this, "CalendarWeekRule", -1);
					r_CalendarWeekRule.SetBelong(this.instance);
				}
				return r_CalendarWeekRule;
			}
		}

		/// <summary>
		/// System.String FullDateTimePattern
		/// </summary>
		protected RProperty r_FullDateTimePattern;
		public virtual RProperty RFullDateTimePattern
		{
			get
			{
				if(r_FullDateTimePattern == null)
				{
					r_FullDateTimePattern = new(this, "FullDateTimePattern", -1);
					r_FullDateTimePattern.SetBelong(this.instance);
				}
				return r_FullDateTimePattern;
			}
		}

		/// <summary>
		/// System.String LongDatePattern
		/// </summary>
		protected RProperty r_LongDatePattern;
		public virtual RProperty RLongDatePattern
		{
			get
			{
				if(r_LongDatePattern == null)
				{
					r_LongDatePattern = new(this, "LongDatePattern", -1);
					r_LongDatePattern.SetBelong(this.instance);
				}
				return r_LongDatePattern;
			}
		}

		/// <summary>
		/// System.String LongTimePattern
		/// </summary>
		protected RProperty r_LongTimePattern;
		public virtual RProperty RLongTimePattern
		{
			get
			{
				if(r_LongTimePattern == null)
				{
					r_LongTimePattern = new(this, "LongTimePattern", -1);
					r_LongTimePattern.SetBelong(this.instance);
				}
				return r_LongTimePattern;
			}
		}

		/// <summary>
		/// System.String MonthDayPattern
		/// </summary>
		protected RProperty r_MonthDayPattern;
		public virtual RProperty RMonthDayPattern
		{
			get
			{
				if(r_MonthDayPattern == null)
				{
					r_MonthDayPattern = new(this, "MonthDayPattern", -1);
					r_MonthDayPattern.SetBelong(this.instance);
				}
				return r_MonthDayPattern;
			}
		}

		/// <summary>
		/// System.String PMDesignator
		/// </summary>
		protected RProperty r_PMDesignator;
		public virtual RProperty RPMDesignator
		{
			get
			{
				if(r_PMDesignator == null)
				{
					r_PMDesignator = new(this, "PMDesignator", -1);
					r_PMDesignator.SetBelong(this.instance);
				}
				return r_PMDesignator;
			}
		}

		/// <summary>
		/// System.String RFC1123Pattern
		/// </summary>
		protected RProperty r_RFC1123Pattern;
		public virtual RProperty RFC1123Pattern
		{
			get
			{
				if(r_RFC1123Pattern == null)
				{
					r_RFC1123Pattern = new(this, "RFC1123Pattern", -1);
					r_RFC1123Pattern.SetBelong(this.instance);
				}
				return r_RFC1123Pattern;
			}
		}

		/// <summary>
		/// System.String ShortDatePattern
		/// </summary>
		protected RProperty r_ShortDatePattern;
		public virtual RProperty RShortDatePattern
		{
			get
			{
				if(r_ShortDatePattern == null)
				{
					r_ShortDatePattern = new(this, "ShortDatePattern", -1);
					r_ShortDatePattern.SetBelong(this.instance);
				}
				return r_ShortDatePattern;
			}
		}

		/// <summary>
		/// System.String ShortTimePattern
		/// </summary>
		protected RProperty r_ShortTimePattern;
		public virtual RProperty RShortTimePattern
		{
			get
			{
				if(r_ShortTimePattern == null)
				{
					r_ShortTimePattern = new(this, "ShortTimePattern", -1);
					r_ShortTimePattern.SetBelong(this.instance);
				}
				return r_ShortTimePattern;
			}
		}

		/// <summary>
		/// System.String SortableDateTimePattern
		/// </summary>
		protected RProperty r_SortableDateTimePattern;
		public virtual RProperty RSortableDateTimePattern
		{
			get
			{
				if(r_SortableDateTimePattern == null)
				{
					r_SortableDateTimePattern = new(this, "SortableDateTimePattern", -1);
					r_SortableDateTimePattern.SetBelong(this.instance);
				}
				return r_SortableDateTimePattern;
			}
		}

		/// <summary>
		/// System.String GeneralShortTimePattern
		/// </summary>
		protected RProperty r_GeneralShortTimePattern;
		public virtual RProperty RGeneralShortTimePattern
		{
			get
			{
				if(r_GeneralShortTimePattern == null)
				{
					r_GeneralShortTimePattern = new(this, "GeneralShortTimePattern", -1);
					r_GeneralShortTimePattern.SetBelong(this.instance);
				}
				return r_GeneralShortTimePattern;
			}
		}

		/// <summary>
		/// System.String GeneralLongTimePattern
		/// </summary>
		protected RProperty r_GeneralLongTimePattern;
		public virtual RProperty RGeneralLongTimePattern
		{
			get
			{
				if(r_GeneralLongTimePattern == null)
				{
					r_GeneralLongTimePattern = new(this, "GeneralLongTimePattern", -1);
					r_GeneralLongTimePattern.SetBelong(this.instance);
				}
				return r_GeneralLongTimePattern;
			}
		}

		/// <summary>
		/// System.String DateTimeOffsetPattern
		/// </summary>
		protected RProperty r_DateTimeOffsetPattern;
		public virtual RProperty RDateTimeOffsetPattern
		{
			get
			{
				if(r_DateTimeOffsetPattern == null)
				{
					r_DateTimeOffsetPattern = new(this, "DateTimeOffsetPattern", -1);
					r_DateTimeOffsetPattern.SetBelong(this.instance);
				}
				return r_DateTimeOffsetPattern;
			}
		}

		/// <summary>
		/// System.String TimeSeparator
		/// </summary>
		protected RProperty r_TimeSeparator;
		public virtual RProperty RTimeSeparator
		{
			get
			{
				if(r_TimeSeparator == null)
				{
					r_TimeSeparator = new(this, "TimeSeparator", -1);
					r_TimeSeparator.SetBelong(this.instance);
				}
				return r_TimeSeparator;
			}
		}

		/// <summary>
		/// System.String UniversalSortableDateTimePattern
		/// </summary>
		protected RProperty r_UniversalSortableDateTimePattern;
		public virtual RProperty RUniversalSortableDateTimePattern
		{
			get
			{
				if(r_UniversalSortableDateTimePattern == null)
				{
					r_UniversalSortableDateTimePattern = new(this, "UniversalSortableDateTimePattern", -1);
					r_UniversalSortableDateTimePattern.SetBelong(this.instance);
				}
				return r_UniversalSortableDateTimePattern;
			}
		}

		/// <summary>
		/// System.String YearMonthPattern
		/// </summary>
		protected RProperty r_YearMonthPattern;
		public virtual RProperty RYearMonthPattern
		{
			get
			{
				if(r_YearMonthPattern == null)
				{
					r_YearMonthPattern = new(this, "YearMonthPattern", -1);
					r_YearMonthPattern.SetBelong(this.instance);
				}
				return r_YearMonthPattern;
			}
		}

		/// <summary>
		/// System.String[] AbbreviatedDayNames
		/// </summary>
		protected RPropertyArray<RProperty> r_AbbreviatedDayNames;
		public virtual RPropertyArray<RProperty> RAbbreviatedDayNames
		{
			get
			{
				if(r_AbbreviatedDayNames == null)
				{
					r_AbbreviatedDayNames = new(this, "AbbreviatedDayNames", -1);
					r_AbbreviatedDayNames.SetBelong(this.instance);
				}
				return r_AbbreviatedDayNames;
			}
		}

		/// <summary>
		/// System.String[] ShortestDayNames
		/// </summary>
		protected RPropertyArray<RProperty> r_ShortestDayNames;
		public virtual RPropertyArray<RProperty> RShortestDayNames
		{
			get
			{
				if(r_ShortestDayNames == null)
				{
					r_ShortestDayNames = new(this, "ShortestDayNames", -1);
					r_ShortestDayNames.SetBelong(this.instance);
				}
				return r_ShortestDayNames;
			}
		}

		/// <summary>
		/// System.String[] DayNames
		/// </summary>
		protected RPropertyArray<RProperty> r_DayNames;
		public virtual RPropertyArray<RProperty> RDayNames
		{
			get
			{
				if(r_DayNames == null)
				{
					r_DayNames = new(this, "DayNames", -1);
					r_DayNames.SetBelong(this.instance);
				}
				return r_DayNames;
			}
		}

		/// <summary>
		/// System.String[] AbbreviatedMonthNames
		/// </summary>
		protected RPropertyArray<RProperty> r_AbbreviatedMonthNames;
		public virtual RPropertyArray<RProperty> RAbbreviatedMonthNames
		{
			get
			{
				if(r_AbbreviatedMonthNames == null)
				{
					r_AbbreviatedMonthNames = new(this, "AbbreviatedMonthNames", -1);
					r_AbbreviatedMonthNames.SetBelong(this.instance);
				}
				return r_AbbreviatedMonthNames;
			}
		}

		/// <summary>
		/// System.String[] MonthNames
		/// </summary>
		protected RPropertyArray<RProperty> r_MonthNames;
		public virtual RPropertyArray<RProperty> RMonthNames
		{
			get
			{
				if(r_MonthNames == null)
				{
					r_MonthNames = new(this, "MonthNames", -1);
					r_MonthNames.SetBelong(this.instance);
				}
				return r_MonthNames;
			}
		}

		/// <summary>
		/// Boolean HasSpacesInMonthNames
		/// </summary>
		protected RProperty r_HasSpacesInMonthNames;
		public virtual RProperty RHasSpacesInMonthNames
		{
			get
			{
				if(r_HasSpacesInMonthNames == null)
				{
					r_HasSpacesInMonthNames = new(this, "HasSpacesInMonthNames", -1);
					r_HasSpacesInMonthNames.SetBelong(this.instance);
				}
				return r_HasSpacesInMonthNames;
			}
		}

		/// <summary>
		/// Boolean HasSpacesInDayNames
		/// </summary>
		protected RProperty r_HasSpacesInDayNames;
		public virtual RProperty RHasSpacesInDayNames
		{
			get
			{
				if(r_HasSpacesInDayNames == null)
				{
					r_HasSpacesInDayNames = new(this, "HasSpacesInDayNames", -1);
					r_HasSpacesInDayNames.SetBelong(this.instance);
				}
				return r_HasSpacesInDayNames;
			}
		}

		/// <summary>
		/// System.String[] AllYearMonthPatterns
		/// </summary>
		protected RPropertyArray<RProperty> r_AllYearMonthPatterns;
		public virtual RPropertyArray<RProperty> RAllYearMonthPatterns
		{
			get
			{
				if(r_AllYearMonthPatterns == null)
				{
					r_AllYearMonthPatterns = new(this, "AllYearMonthPatterns", -1);
					r_AllYearMonthPatterns.SetBelong(this.instance);
				}
				return r_AllYearMonthPatterns;
			}
		}

		/// <summary>
		/// System.String[] AllShortDatePatterns
		/// </summary>
		protected RPropertyArray<RProperty> r_AllShortDatePatterns;
		public virtual RPropertyArray<RProperty> RAllShortDatePatterns
		{
			get
			{
				if(r_AllShortDatePatterns == null)
				{
					r_AllShortDatePatterns = new(this, "AllShortDatePatterns", -1);
					r_AllShortDatePatterns.SetBelong(this.instance);
				}
				return r_AllShortDatePatterns;
			}
		}

		/// <summary>
		/// System.String[] AllShortTimePatterns
		/// </summary>
		protected RPropertyArray<RProperty> r_AllShortTimePatterns;
		public virtual RPropertyArray<RProperty> RAllShortTimePatterns
		{
			get
			{
				if(r_AllShortTimePatterns == null)
				{
					r_AllShortTimePatterns = new(this, "AllShortTimePatterns", -1);
					r_AllShortTimePatterns.SetBelong(this.instance);
				}
				return r_AllShortTimePatterns;
			}
		}

		/// <summary>
		/// System.String[] AllLongDatePatterns
		/// </summary>
		protected RPropertyArray<RProperty> r_AllLongDatePatterns;
		public virtual RPropertyArray<RProperty> RAllLongDatePatterns
		{
			get
			{
				if(r_AllLongDatePatterns == null)
				{
					r_AllLongDatePatterns = new(this, "AllLongDatePatterns", -1);
					r_AllLongDatePatterns.SetBelong(this.instance);
				}
				return r_AllLongDatePatterns;
			}
		}

		/// <summary>
		/// System.String[] AllLongTimePatterns
		/// </summary>
		protected RPropertyArray<RProperty> r_AllLongTimePatterns;
		public virtual RPropertyArray<RProperty> RAllLongTimePatterns
		{
			get
			{
				if(r_AllLongTimePatterns == null)
				{
					r_AllLongTimePatterns = new(this, "AllLongTimePatterns", -1);
					r_AllLongTimePatterns.SetBelong(this.instance);
				}
				return r_AllLongTimePatterns;
			}
		}

		/// <summary>
		/// System.String[] UnclonedYearMonthPatterns
		/// </summary>
		protected RPropertyArray<RProperty> r_UnclonedYearMonthPatterns;
		public virtual RPropertyArray<RProperty> RUnclonedYearMonthPatterns
		{
			get
			{
				if(r_UnclonedYearMonthPatterns == null)
				{
					r_UnclonedYearMonthPatterns = new(this, "UnclonedYearMonthPatterns", -1);
					r_UnclonedYearMonthPatterns.SetBelong(this.instance);
				}
				return r_UnclonedYearMonthPatterns;
			}
		}

		/// <summary>
		/// System.String[] UnclonedShortDatePatterns
		/// </summary>
		protected RPropertyArray<RProperty> r_UnclonedShortDatePatterns;
		public virtual RPropertyArray<RProperty> RUnclonedShortDatePatterns
		{
			get
			{
				if(r_UnclonedShortDatePatterns == null)
				{
					r_UnclonedShortDatePatterns = new(this, "UnclonedShortDatePatterns", -1);
					r_UnclonedShortDatePatterns.SetBelong(this.instance);
				}
				return r_UnclonedShortDatePatterns;
			}
		}

		/// <summary>
		/// System.String[] UnclonedLongDatePatterns
		/// </summary>
		protected RPropertyArray<RProperty> r_UnclonedLongDatePatterns;
		public virtual RPropertyArray<RProperty> RUnclonedLongDatePatterns
		{
			get
			{
				if(r_UnclonedLongDatePatterns == null)
				{
					r_UnclonedLongDatePatterns = new(this, "UnclonedLongDatePatterns", -1);
					r_UnclonedLongDatePatterns.SetBelong(this.instance);
				}
				return r_UnclonedLongDatePatterns;
			}
		}

		/// <summary>
		/// System.String[] UnclonedShortTimePatterns
		/// </summary>
		protected RPropertyArray<RProperty> r_UnclonedShortTimePatterns;
		public virtual RPropertyArray<RProperty> RUnclonedShortTimePatterns
		{
			get
			{
				if(r_UnclonedShortTimePatterns == null)
				{
					r_UnclonedShortTimePatterns = new(this, "UnclonedShortTimePatterns", -1);
					r_UnclonedShortTimePatterns.SetBelong(this.instance);
				}
				return r_UnclonedShortTimePatterns;
			}
		}

		/// <summary>
		/// System.String[] UnclonedLongTimePatterns
		/// </summary>
		protected RPropertyArray<RProperty> r_UnclonedLongTimePatterns;
		public virtual RPropertyArray<RProperty> RUnclonedLongTimePatterns
		{
			get
			{
				if(r_UnclonedLongTimePatterns == null)
				{
					r_UnclonedLongTimePatterns = new(this, "UnclonedLongTimePatterns", -1);
					r_UnclonedLongTimePatterns.SetBelong(this.instance);
				}
				return r_UnclonedLongTimePatterns;
			}
		}

		/// <summary>
		/// Boolean IsReadOnly
		/// </summary>
		protected RProperty r_IsReadOnly;
		public virtual RProperty RIsReadOnly
		{
			get
			{
				if(r_IsReadOnly == null)
				{
					r_IsReadOnly = new(this, "IsReadOnly", -1);
					r_IsReadOnly.SetBelong(this.instance);
				}
				return r_IsReadOnly;
			}
		}

		/// <summary>
		/// System.String NativeCalendarName
		/// </summary>
		protected RProperty r_NativeCalendarName;
		public virtual RProperty RNativeCalendarName
		{
			get
			{
				if(r_NativeCalendarName == null)
				{
					r_NativeCalendarName = new(this, "NativeCalendarName", -1);
					r_NativeCalendarName.SetBelong(this.instance);
				}
				return r_NativeCalendarName;
			}
		}

		/// <summary>
		/// System.String[] AbbreviatedMonthGenitiveNames
		/// </summary>
		protected RPropertyArray<RProperty> r_AbbreviatedMonthGenitiveNames;
		public virtual RPropertyArray<RProperty> RAbbreviatedMonthGenitiveNames
		{
			get
			{
				if(r_AbbreviatedMonthGenitiveNames == null)
				{
					r_AbbreviatedMonthGenitiveNames = new(this, "AbbreviatedMonthGenitiveNames", -1);
					r_AbbreviatedMonthGenitiveNames.SetBelong(this.instance);
				}
				return r_AbbreviatedMonthGenitiveNames;
			}
		}

		/// <summary>
		/// System.String[] MonthGenitiveNames
		/// </summary>
		protected RPropertyArray<RProperty> r_MonthGenitiveNames;
		public virtual RPropertyArray<RProperty> RMonthGenitiveNames
		{
			get
			{
				if(r_MonthGenitiveNames == null)
				{
					r_MonthGenitiveNames = new(this, "MonthGenitiveNames", -1);
					r_MonthGenitiveNames.SetBelong(this.instance);
				}
				return r_MonthGenitiveNames;
			}
		}

		/// <summary>
		/// System.String FullTimeSpanPositivePattern
		/// </summary>
		protected RProperty r_FullTimeSpanPositivePattern;
		public virtual RProperty RFullTimeSpanPositivePattern
		{
			get
			{
				if(r_FullTimeSpanPositivePattern == null)
				{
					r_FullTimeSpanPositivePattern = new(this, "FullTimeSpanPositivePattern", -1);
					r_FullTimeSpanPositivePattern.SetBelong(this.instance);
				}
				return r_FullTimeSpanPositivePattern;
			}
		}

		/// <summary>
		/// System.String FullTimeSpanNegativePattern
		/// </summary>
		protected RProperty r_FullTimeSpanNegativePattern;
		public virtual RProperty RFullTimeSpanNegativePattern
		{
			get
			{
				if(r_FullTimeSpanNegativePattern == null)
				{
					r_FullTimeSpanNegativePattern = new(this, "FullTimeSpanNegativePattern", -1);
					r_FullTimeSpanNegativePattern.SetBelong(this.instance);
				}
				return r_FullTimeSpanNegativePattern;
			}
		}

		/// <summary>
		/// System.Globalization.CompareInfo CompareInfo
		/// </summary>
		protected RSystem.RGlobalization.RCompareInfo r_CompareInfo;
		public virtual RSystem.RGlobalization.RCompareInfo RCompareInfo
		{
			get
			{
				if(r_CompareInfo == null)
				{
					r_CompareInfo = new(this, "CompareInfo", -1);
					r_CompareInfo.SetBelong(this.instance);
				}
				return r_CompareInfo;
			}
		}

		/// <summary>
		/// System.Globalization.DateTimeFormatFlags FormatFlags
		/// </summary>
		protected RProperty r_FormatFlags;
		public virtual RProperty RFormatFlags
		{
			get
			{
				if(r_FormatFlags == null)
				{
					r_FormatFlags = new(this, "FormatFlags", -1);
					r_FormatFlags.SetBelong(this.instance);
				}
				return r_FormatFlags;
			}
		}

		/// <summary>
		/// Boolean HasForceTwoDigitYears
		/// </summary>
		protected RProperty r_HasForceTwoDigitYears;
		public virtual RProperty RHasForceTwoDigitYears
		{
			get
			{
				if(r_HasForceTwoDigitYears == null)
				{
					r_HasForceTwoDigitYears = new(this, "HasForceTwoDigitYears", -1);
					r_HasForceTwoDigitYears.SetBelong(this.instance);
				}
				return r_HasForceTwoDigitYears;
			}
		}

		/// <summary>
		/// Boolean HasYearMonthAdjustment
		/// </summary>
		protected RProperty r_HasYearMonthAdjustment;
		public virtual RProperty RHasYearMonthAdjustment
		{
			get
			{
				if(r_HasYearMonthAdjustment == null)
				{
					r_HasYearMonthAdjustment = new(this, "HasYearMonthAdjustment", -1);
					r_HasYearMonthAdjustment.SetBelong(this.instance);
				}
				return r_HasYearMonthAdjustment;
			}
		}

		/// <summary>
		/// System.String[] internalGetAbbreviatedDayOfWeekNames()
		/// </summary>
		protected RMethod r_RinternalGetAbbreviatedDayOfWeekNames;
		public virtual RMethod RinternalGetAbbreviatedDayOfWeekNames
		{
			get
			{
				if(r_RinternalGetAbbreviatedDayOfWeekNames == null)
				{
					r_RinternalGetAbbreviatedDayOfWeekNames = new(this, "internalGetAbbreviatedDayOfWeekNames", 0);
					r_RinternalGetAbbreviatedDayOfWeekNames.SetBelong(this.instance);
				}
				return r_RinternalGetAbbreviatedDayOfWeekNames;
			}
		}

		/// <summary>
		/// System.String[] internalGetAbbreviatedDayOfWeekNamesCore()
		/// </summary>
		protected RMethod r_RinternalGetAbbreviatedDayOfWeekNamesCore;
		public virtual RMethod RinternalGetAbbreviatedDayOfWeekNamesCore
		{
			get
			{
				if(r_RinternalGetAbbreviatedDayOfWeekNamesCore == null)
				{
					r_RinternalGetAbbreviatedDayOfWeekNamesCore = new(this, "internalGetAbbreviatedDayOfWeekNamesCore", 0);
					r_RinternalGetAbbreviatedDayOfWeekNamesCore.SetBelong(this.instance);
				}
				return r_RinternalGetAbbreviatedDayOfWeekNamesCore;
			}
		}

		/// <summary>
		/// System.String[] internalGetSuperShortDayNames()
		/// </summary>
		protected RMethod r_RinternalGetSuperShortDayNames;
		public virtual RMethod RinternalGetSuperShortDayNames
		{
			get
			{
				if(r_RinternalGetSuperShortDayNames == null)
				{
					r_RinternalGetSuperShortDayNames = new(this, "internalGetSuperShortDayNames", 0);
					r_RinternalGetSuperShortDayNames.SetBelong(this.instance);
				}
				return r_RinternalGetSuperShortDayNames;
			}
		}

		/// <summary>
		/// System.String[] internalGetSuperShortDayNamesCore()
		/// </summary>
		protected RMethod r_RinternalGetSuperShortDayNamesCore;
		public virtual RMethod RinternalGetSuperShortDayNamesCore
		{
			get
			{
				if(r_RinternalGetSuperShortDayNamesCore == null)
				{
					r_RinternalGetSuperShortDayNamesCore = new(this, "internalGetSuperShortDayNamesCore", 0);
					r_RinternalGetSuperShortDayNamesCore.SetBelong(this.instance);
				}
				return r_RinternalGetSuperShortDayNamesCore;
			}
		}

		/// <summary>
		/// System.String[] internalGetDayOfWeekNames()
		/// </summary>
		protected RMethod r_RinternalGetDayOfWeekNames;
		public virtual RMethod RinternalGetDayOfWeekNames
		{
			get
			{
				if(r_RinternalGetDayOfWeekNames == null)
				{
					r_RinternalGetDayOfWeekNames = new(this, "internalGetDayOfWeekNames", 0);
					r_RinternalGetDayOfWeekNames.SetBelong(this.instance);
				}
				return r_RinternalGetDayOfWeekNames;
			}
		}

		/// <summary>
		/// System.String[] internalGetDayOfWeekNamesCore()
		/// </summary>
		protected RMethod r_RinternalGetDayOfWeekNamesCore;
		public virtual RMethod RinternalGetDayOfWeekNamesCore
		{
			get
			{
				if(r_RinternalGetDayOfWeekNamesCore == null)
				{
					r_RinternalGetDayOfWeekNamesCore = new(this, "internalGetDayOfWeekNamesCore", 0);
					r_RinternalGetDayOfWeekNamesCore.SetBelong(this.instance);
				}
				return r_RinternalGetDayOfWeekNamesCore;
			}
		}

		/// <summary>
		/// System.String[] internalGetAbbreviatedMonthNames()
		/// </summary>
		protected RMethod r_RinternalGetAbbreviatedMonthNames;
		public virtual RMethod RinternalGetAbbreviatedMonthNames
		{
			get
			{
				if(r_RinternalGetAbbreviatedMonthNames == null)
				{
					r_RinternalGetAbbreviatedMonthNames = new(this, "internalGetAbbreviatedMonthNames", 0);
					r_RinternalGetAbbreviatedMonthNames.SetBelong(this.instance);
				}
				return r_RinternalGetAbbreviatedMonthNames;
			}
		}

		/// <summary>
		/// System.String[] internalGetAbbreviatedMonthNamesCore()
		/// </summary>
		protected RMethod r_RinternalGetAbbreviatedMonthNamesCore;
		public virtual RMethod RinternalGetAbbreviatedMonthNamesCore
		{
			get
			{
				if(r_RinternalGetAbbreviatedMonthNamesCore == null)
				{
					r_RinternalGetAbbreviatedMonthNamesCore = new(this, "internalGetAbbreviatedMonthNamesCore", 0);
					r_RinternalGetAbbreviatedMonthNamesCore.SetBelong(this.instance);
				}
				return r_RinternalGetAbbreviatedMonthNamesCore;
			}
		}

		/// <summary>
		/// System.String[] internalGetMonthNames()
		/// </summary>
		protected RMethod r_RinternalGetMonthNames;
		public virtual RMethod RinternalGetMonthNames
		{
			get
			{
				if(r_RinternalGetMonthNames == null)
				{
					r_RinternalGetMonthNames = new(this, "internalGetMonthNames", 0);
					r_RinternalGetMonthNames.SetBelong(this.instance);
				}
				return r_RinternalGetMonthNames;
			}
		}

		/// <summary>
		/// System.String[] internalGetMonthNamesCore()
		/// </summary>
		protected RMethod r_RinternalGetMonthNamesCore;
		public virtual RMethod RinternalGetMonthNamesCore
		{
			get
			{
				if(r_RinternalGetMonthNamesCore == null)
				{
					r_RinternalGetMonthNamesCore = new(this, "internalGetMonthNamesCore", 0);
					r_RinternalGetMonthNamesCore.SetBelong(this.instance);
				}
				return r_RinternalGetMonthNamesCore;
			}
		}

		/// <summary>
		/// Void InitializeOverridableProperties(System.Globalization.CultureData, Int32)
		/// </summary>
		protected RMethod r_RInitializeOverridableProperties_CultureData_Int32;
		public virtual RMethod RInitializeOverridableProperties_CultureData_Int32
		{
			get
			{
				if(r_RInitializeOverridableProperties_CultureData_Int32 == null)
				{
					r_RInitializeOverridableProperties_CultureData_Int32 = new(this, "InitializeOverridableProperties", 0,  ReleactionUtils.GetType("System.Globalization.CultureData"), typeof(System.Int32));
					r_RInitializeOverridableProperties_CultureData_Int32.SetBelong(this.instance);
				}
				return r_RInitializeOverridableProperties_CultureData_Int32;
			}
		}

		/// <summary>
		/// System.Globalization.DateTimeFormatInfo GetInstance(System.IFormatProvider)
		/// </summary>
		protected static RMethod r_RGetInstance_IFormatProvider;
		public static RMethod RGetInstance_IFormatProvider
		{
			get
			{
				if(r_RGetInstance_IFormatProvider == null)
				{
					r_RGetInstance_IFormatProvider = new(typeof(System.Globalization.DateTimeFormatInfo), "GetInstance", 0, typeof(System.IFormatProvider));
					r_RGetInstance_IFormatProvider.SetBelong(null);
				}
				return r_RGetInstance_IFormatProvider;
			}
		}

		/// <summary>
		/// System.Object GetFormat(System.Type)
		/// </summary>
		protected RMethod r_RGetFormat_Type;
		public virtual RMethod RGetFormat_Type
		{
			get
			{
				if(r_RGetFormat_Type == null)
				{
					r_RGetFormat_Type = new(this, "GetFormat", 0, typeof(System.Type));
					r_RGetFormat_Type.SetBelong(this.instance);
				}
				return r_RGetFormat_Type;
			}
		}

		/// <summary>
		/// System.Object Clone()
		/// </summary>
		protected RMethod r_RClone;
		public virtual RMethod RClone
		{
			get
			{
				if(r_RClone == null)
				{
					r_RClone = new(this, "Clone", 0);
					r_RClone.SetBelong(this.instance);
				}
				return r_RClone;
			}
		}

		/// <summary>
		/// Int32 GetEra(System.String)
		/// </summary>
		protected RMethod r_RGetEra_String;
		public virtual RMethod RGetEra_String
		{
			get
			{
				if(r_RGetEra_String == null)
				{
					r_RGetEra_String = new(this, "GetEra", 0, typeof(System.String));
					r_RGetEra_String.SetBelong(this.instance);
				}
				return r_RGetEra_String;
			}
		}

		/// <summary>
		/// System.String GetEraName(Int32)
		/// </summary>
		protected RMethod r_RGetEraName_Int32;
		public virtual RMethod RGetEraName_Int32
		{
			get
			{
				if(r_RGetEraName_Int32 == null)
				{
					r_RGetEraName_Int32 = new(this, "GetEraName", 0, typeof(System.Int32));
					r_RGetEraName_Int32.SetBelong(this.instance);
				}
				return r_RGetEraName_Int32;
			}
		}

		/// <summary>
		/// System.String GetAbbreviatedEraName(Int32)
		/// </summary>
		protected RMethod r_RGetAbbreviatedEraName_Int32;
		public virtual RMethod RGetAbbreviatedEraName_Int32
		{
			get
			{
				if(r_RGetAbbreviatedEraName_Int32 == null)
				{
					r_RGetAbbreviatedEraName_Int32 = new(this, "GetAbbreviatedEraName", 0, typeof(System.Int32));
					r_RGetAbbreviatedEraName_Int32.SetBelong(this.instance);
				}
				return r_RGetAbbreviatedEraName_Int32;
			}
		}

		/// <summary>
		/// Void CheckNullValue(System.String[], Int32)
		/// </summary>
		protected static RMethod r_RCheckNullValue_StringArray_Int32;
		public static RMethod RCheckNullValue_StringArray_Int32
		{
			get
			{
				if(r_RCheckNullValue_StringArray_Int32 == null)
				{
					r_RCheckNullValue_StringArray_Int32 = new(typeof(System.Globalization.DateTimeFormatInfo), "CheckNullValue", 0, typeof(System.String).MakeArrayType(), typeof(System.Int32));
					r_RCheckNullValue_StringArray_Int32.SetBelong(null);
				}
				return r_RCheckNullValue_StringArray_Int32;
			}
		}

		/// <summary>
		/// System.String internalGetMonthName(Int32, System.Globalization.MonthNameStyles, Boolean)
		/// </summary>
		protected RMethod r_RinternalGetMonthName_Int32_MonthNameStyles_Boolean;
		public virtual RMethod RinternalGetMonthName_Int32_MonthNameStyles_Boolean
		{
			get
			{
				if(r_RinternalGetMonthName_Int32_MonthNameStyles_Boolean == null)
				{
					r_RinternalGetMonthName_Int32_MonthNameStyles_Boolean = new(this, "internalGetMonthName", 0, typeof(System.Int32),  ReleactionUtils.GetType("System.Globalization.MonthNameStyles"), typeof(System.Boolean));
					r_RinternalGetMonthName_Int32_MonthNameStyles_Boolean.SetBelong(this.instance);
				}
				return r_RinternalGetMonthName_Int32_MonthNameStyles_Boolean;
			}
		}

		/// <summary>
		/// System.String[] internalGetGenitiveMonthNames(Boolean)
		/// </summary>
		protected RMethod r_RinternalGetGenitiveMonthNames_Boolean;
		public virtual RMethod RinternalGetGenitiveMonthNames_Boolean
		{
			get
			{
				if(r_RinternalGetGenitiveMonthNames_Boolean == null)
				{
					r_RinternalGetGenitiveMonthNames_Boolean = new(this, "internalGetGenitiveMonthNames", 0, typeof(System.Boolean));
					r_RinternalGetGenitiveMonthNames_Boolean.SetBelong(this.instance);
				}
				return r_RinternalGetGenitiveMonthNames_Boolean;
			}
		}

		/// <summary>
		/// System.String[] internalGetLeapYearMonthNames()
		/// </summary>
		protected RMethod r_RinternalGetLeapYearMonthNames;
		public virtual RMethod RinternalGetLeapYearMonthNames
		{
			get
			{
				if(r_RinternalGetLeapYearMonthNames == null)
				{
					r_RinternalGetLeapYearMonthNames = new(this, "internalGetLeapYearMonthNames", 0);
					r_RinternalGetLeapYearMonthNames.SetBelong(this.instance);
				}
				return r_RinternalGetLeapYearMonthNames;
			}
		}

		/// <summary>
		/// System.String GetAbbreviatedDayName(System.DayOfWeek)
		/// </summary>
		protected RMethod r_RGetAbbreviatedDayName_DayOfWeek;
		public virtual RMethod RGetAbbreviatedDayName_DayOfWeek
		{
			get
			{
				if(r_RGetAbbreviatedDayName_DayOfWeek == null)
				{
					r_RGetAbbreviatedDayName_DayOfWeek = new(this, "GetAbbreviatedDayName", 0, typeof(System.DayOfWeek));
					r_RGetAbbreviatedDayName_DayOfWeek.SetBelong(this.instance);
				}
				return r_RGetAbbreviatedDayName_DayOfWeek;
			}
		}

		/// <summary>
		/// System.String GetShortestDayName(System.DayOfWeek)
		/// </summary>
		protected RMethod r_RGetShortestDayName_DayOfWeek;
		public virtual RMethod RGetShortestDayName_DayOfWeek
		{
			get
			{
				if(r_RGetShortestDayName_DayOfWeek == null)
				{
					r_RGetShortestDayName_DayOfWeek = new(this, "GetShortestDayName", 0, typeof(System.DayOfWeek));
					r_RGetShortestDayName_DayOfWeek.SetBelong(this.instance);
				}
				return r_RGetShortestDayName_DayOfWeek;
			}
		}

		/// <summary>
		/// System.String[] GetCombinedPatterns(System.String[], System.String[], System.String)
		/// </summary>
		protected static RMethod r_RGetCombinedPatterns_StringArray_StringArray_String;
		public static RMethod RGetCombinedPatterns_StringArray_StringArray_String
		{
			get
			{
				if(r_RGetCombinedPatterns_StringArray_StringArray_String == null)
				{
					r_RGetCombinedPatterns_StringArray_StringArray_String = new(typeof(System.Globalization.DateTimeFormatInfo), "GetCombinedPatterns", 0, typeof(System.String).MakeArrayType(), typeof(System.String).MakeArrayType(), typeof(System.String));
					r_RGetCombinedPatterns_StringArray_StringArray_String.SetBelong(null);
				}
				return r_RGetCombinedPatterns_StringArray_StringArray_String;
			}
		}

		/// <summary>
		/// System.String[] GetAllDateTimePatterns()
		/// </summary>
		protected RMethod r_RGetAllDateTimePatterns;
		public virtual RMethod RGetAllDateTimePatterns
		{
			get
			{
				if(r_RGetAllDateTimePatterns == null)
				{
					r_RGetAllDateTimePatterns = new(this, "GetAllDateTimePatterns", 0);
					r_RGetAllDateTimePatterns.SetBelong(this.instance);
				}
				return r_RGetAllDateTimePatterns;
			}
		}

		/// <summary>
		/// System.String[] GetAllDateTimePatterns(Char)
		/// </summary>
		protected RMethod r_RGetAllDateTimePatterns_Char;
		public virtual RMethod RGetAllDateTimePatterns_Char
		{
			get
			{
				if(r_RGetAllDateTimePatterns_Char == null)
				{
					r_RGetAllDateTimePatterns_Char = new(this, "GetAllDateTimePatterns", 0, typeof(System.Char));
					r_RGetAllDateTimePatterns_Char.SetBelong(this.instance);
				}
				return r_RGetAllDateTimePatterns_Char;
			}
		}

		/// <summary>
		/// System.String GetDayName(System.DayOfWeek)
		/// </summary>
		protected RMethod r_RGetDayName_DayOfWeek;
		public virtual RMethod RGetDayName_DayOfWeek
		{
			get
			{
				if(r_RGetDayName_DayOfWeek == null)
				{
					r_RGetDayName_DayOfWeek = new(this, "GetDayName", 0, typeof(System.DayOfWeek));
					r_RGetDayName_DayOfWeek.SetBelong(this.instance);
				}
				return r_RGetDayName_DayOfWeek;
			}
		}

		/// <summary>
		/// System.String GetAbbreviatedMonthName(Int32)
		/// </summary>
		protected RMethod r_RGetAbbreviatedMonthName_Int32;
		public virtual RMethod RGetAbbreviatedMonthName_Int32
		{
			get
			{
				if(r_RGetAbbreviatedMonthName_Int32 == null)
				{
					r_RGetAbbreviatedMonthName_Int32 = new(this, "GetAbbreviatedMonthName", 0, typeof(System.Int32));
					r_RGetAbbreviatedMonthName_Int32.SetBelong(this.instance);
				}
				return r_RGetAbbreviatedMonthName_Int32;
			}
		}

		/// <summary>
		/// System.String GetMonthName(Int32)
		/// </summary>
		protected RMethod r_RGetMonthName_Int32;
		public virtual RMethod RGetMonthName_Int32
		{
			get
			{
				if(r_RGetMonthName_Int32 == null)
				{
					r_RGetMonthName_Int32 = new(this, "GetMonthName", 0, typeof(System.Int32));
					r_RGetMonthName_Int32.SetBelong(this.instance);
				}
				return r_RGetMonthName_Int32;
			}
		}

		/// <summary>
		/// System.String[] GetMergedPatterns(System.String[], System.String)
		/// </summary>
		protected static RMethod r_RGetMergedPatterns_StringArray_String;
		public static RMethod RGetMergedPatterns_StringArray_String
		{
			get
			{
				if(r_RGetMergedPatterns_StringArray_String == null)
				{
					r_RGetMergedPatterns_StringArray_String = new(typeof(System.Globalization.DateTimeFormatInfo), "GetMergedPatterns", 0, typeof(System.String).MakeArrayType(), typeof(System.String));
					r_RGetMergedPatterns_StringArray_String.SetBelong(null);
				}
				return r_RGetMergedPatterns_StringArray_String;
			}
		}

		/// <summary>
		/// System.Globalization.DateTimeFormatInfo ReadOnly(System.Globalization.DateTimeFormatInfo)
		/// </summary>
		protected static RMethod r_RReadOnly_DateTimeFormatInfo;
		public static RMethod RReadOnly_DateTimeFormatInfo
		{
			get
			{
				if(r_RReadOnly_DateTimeFormatInfo == null)
				{
					r_RReadOnly_DateTimeFormatInfo = new(typeof(System.Globalization.DateTimeFormatInfo), "ReadOnly", 0, typeof(System.Globalization.DateTimeFormatInfo));
					r_RReadOnly_DateTimeFormatInfo.SetBelong(null);
				}
				return r_RReadOnly_DateTimeFormatInfo;
			}
		}

		/// <summary>
		/// Void SetAllDateTimePatterns(System.String[], Char)
		/// </summary>
		protected RMethod r_RSetAllDateTimePatterns_StringArray_Char;
		public virtual RMethod RSetAllDateTimePatterns_StringArray_Char
		{
			get
			{
				if(r_RSetAllDateTimePatterns_StringArray_Char == null)
				{
					r_RSetAllDateTimePatterns_StringArray_Char = new(this, "SetAllDateTimePatterns", 0, typeof(System.String).MakeArrayType(), typeof(System.Char));
					r_RSetAllDateTimePatterns_StringArray_Char.SetBelong(this.instance);
				}
				return r_RSetAllDateTimePatterns_StringArray_Char;
			}
		}

		/// <summary>
		/// Void ValidateStyles(System.Globalization.DateTimeStyles, System.String)
		/// </summary>
		protected static RMethod r_RValidateStyles_DateTimeStyles_String;
		public static RMethod RValidateStyles_DateTimeStyles_String
		{
			get
			{
				if(r_RValidateStyles_DateTimeStyles_String == null)
				{
					r_RValidateStyles_DateTimeStyles_String = new(typeof(System.Globalization.DateTimeFormatInfo), "ValidateStyles", 0, typeof(System.Globalization.DateTimeStyles), typeof(System.String));
					r_RValidateStyles_DateTimeStyles_String.SetBelong(null);
				}
				return r_RValidateStyles_DateTimeStyles_String;
			}
		}

		/// <summary>
		/// System.Globalization.DateTimeFormatFlags InitializeFormatFlags()
		/// </summary>
		protected RMethod r_RInitializeFormatFlags;
		public virtual RMethod RInitializeFormatFlags
		{
			get
			{
				if(r_RInitializeFormatFlags == null)
				{
					r_RInitializeFormatFlags = new(this, "InitializeFormatFlags", 0);
					r_RInitializeFormatFlags.SetBelong(this.instance);
				}
				return r_RInitializeFormatFlags;
			}
		}

		/// <summary>
		/// Boolean YearMonthAdjustment(Int32 ByRef, Int32 ByRef, Boolean)
		/// </summary>
		protected RMethod r_RYearMonthAdjustment_Ref_Int32_Ref_Int32_Boolean;
		public virtual RMethod RYearMonthAdjustment_Ref_Int32_Ref_Int32_Boolean
		{
			get
			{
				if(r_RYearMonthAdjustment_Ref_Int32_Ref_Int32_Boolean == null)
				{
					r_RYearMonthAdjustment_Ref_Int32_Ref_Int32_Boolean = new(this, "YearMonthAdjustment", 0, typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Boolean));
					r_RYearMonthAdjustment_Ref_Int32_Ref_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RYearMonthAdjustment_Ref_Int32_Ref_Int32_Boolean;
			}
		}

		/// <summary>
		/// System.Globalization.DateTimeFormatInfo GetJapaneseCalendarDTFI()
		/// </summary>
		protected static RMethod r_RGetJapaneseCalendarDTFI;
		public static RMethod RGetJapaneseCalendarDTFI
		{
			get
			{
				if(r_RGetJapaneseCalendarDTFI == null)
				{
					r_RGetJapaneseCalendarDTFI = new(typeof(System.Globalization.DateTimeFormatInfo), "GetJapaneseCalendarDTFI", 0);
					r_RGetJapaneseCalendarDTFI.SetBelong(null);
				}
				return r_RGetJapaneseCalendarDTFI;
			}
		}

		/// <summary>
		/// System.Globalization.DateTimeFormatInfo GetTaiwanCalendarDTFI()
		/// </summary>
		protected static RMethod r_RGetTaiwanCalendarDTFI;
		public static RMethod RGetTaiwanCalendarDTFI
		{
			get
			{
				if(r_RGetTaiwanCalendarDTFI == null)
				{
					r_RGetTaiwanCalendarDTFI = new(typeof(System.Globalization.DateTimeFormatInfo), "GetTaiwanCalendarDTFI", 0);
					r_RGetTaiwanCalendarDTFI.SetBelong(null);
				}
				return r_RGetTaiwanCalendarDTFI;
			}
		}

		/// <summary>
		/// Void ClearTokenHashTable()
		/// </summary>
		protected RMethod r_RClearTokenHashTable;
		public virtual RMethod RClearTokenHashTable
		{
			get
			{
				if(r_RClearTokenHashTable == null)
				{
					r_RClearTokenHashTable = new(this, "ClearTokenHashTable", 0);
					r_RClearTokenHashTable.SetBelong(this.instance);
				}
				return r_RClearTokenHashTable;
			}
		}

		/// <summary>
		/// TokenHashValue[] CreateTokenHashTable()
		/// </summary>
		protected RMethod r_RCreateTokenHashTable;
		public virtual RMethod RCreateTokenHashTable
		{
			get
			{
				if(r_RCreateTokenHashTable == null)
				{
					r_RCreateTokenHashTable = new(this, "CreateTokenHashTable", 0);
					r_RCreateTokenHashTable.SetBelong(this.instance);
				}
				return r_RCreateTokenHashTable;
			}
		}

		/// <summary>
		/// Void PopulateSpecialTokenHashTable(TokenHashValue[], Boolean ByRef)
		/// </summary>
		protected RMethod r_RPopulateSpecialTokenHashTable_TokenHashValueArray_Ref_Boolean;
		public virtual RMethod RPopulateSpecialTokenHashTable_TokenHashValueArray_Ref_Boolean
		{
			get
			{
				if(r_RPopulateSpecialTokenHashTable_TokenHashValueArray_Ref_Boolean == null)
				{
					r_RPopulateSpecialTokenHashTable_TokenHashValueArray_Ref_Boolean = new(this, "PopulateSpecialTokenHashTable", 0,  ReleactionUtils.GetType("System.Globalization.DateTimeFormatInfo+TokenHashValue").MakeArrayType(), typeof(System.Boolean).MakeByRefType());
					r_RPopulateSpecialTokenHashTable_TokenHashValueArray_Ref_Boolean.SetBelong(this.instance);
				}
				return r_RPopulateSpecialTokenHashTable_TokenHashValueArray_Ref_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsJapaneseCalendar(System.Globalization.Calendar)
		/// </summary>
		protected static RMethod r_RIsJapaneseCalendar_Calendar;
		public static RMethod RIsJapaneseCalendar_Calendar
		{
			get
			{
				if(r_RIsJapaneseCalendar_Calendar == null)
				{
					r_RIsJapaneseCalendar_Calendar = new(typeof(System.Globalization.DateTimeFormatInfo), "IsJapaneseCalendar", 0, typeof(System.Globalization.Calendar));
					r_RIsJapaneseCalendar_Calendar.SetBelong(null);
				}
				return r_RIsJapaneseCalendar_Calendar;
			}
		}

		/// <summary>
		/// Void AddMonthNames(TokenHashValue[], System.String)
		/// </summary>
		protected RMethod r_RAddMonthNames_TokenHashValueArray_String;
		public virtual RMethod RAddMonthNames_TokenHashValueArray_String
		{
			get
			{
				if(r_RAddMonthNames_TokenHashValueArray_String == null)
				{
					r_RAddMonthNames_TokenHashValueArray_String = new(this, "AddMonthNames", 0,  ReleactionUtils.GetType("System.Globalization.DateTimeFormatInfo+TokenHashValue").MakeArrayType(), typeof(System.String));
					r_RAddMonthNames_TokenHashValueArray_String.SetBelong(this.instance);
				}
				return r_RAddMonthNames_TokenHashValueArray_String;
			}
		}

		/// <summary>
		/// Boolean TryParseHebrewNumber(System.__DTString ByRef, Boolean ByRef, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RTryParseHebrewNumber_Ref___DTString_Out_Boolean_Out_Int32;
		public static RMethod RTryParseHebrewNumber_Ref___DTString_Out_Boolean_Out_Int32
		{
			get
			{
				if(r_RTryParseHebrewNumber_Ref___DTString_Out_Boolean_Out_Int32 == null)
				{
					r_RTryParseHebrewNumber_Ref___DTString_Out_Boolean_Out_Int32 = new(typeof(System.Globalization.DateTimeFormatInfo), "TryParseHebrewNumber", 0,  ReleactionUtils.GetType("System.__DTString").MakeByRefType(), typeof(System.Boolean).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_RTryParseHebrewNumber_Ref___DTString_Out_Boolean_Out_Int32.SetBelong(null);
				}
				return r_RTryParseHebrewNumber_Ref___DTString_Out_Boolean_Out_Int32;
			}
		}

		/// <summary>
		/// Boolean IsHebrewChar(Char)
		/// </summary>
		protected static RMethod r_RIsHebrewChar_Char;
		public static RMethod RIsHebrewChar_Char
		{
			get
			{
				if(r_RIsHebrewChar_Char == null)
				{
					r_RIsHebrewChar_Char = new(typeof(System.Globalization.DateTimeFormatInfo), "IsHebrewChar", 0, typeof(System.Char));
					r_RIsHebrewChar_Char.SetBelong(null);
				}
				return r_RIsHebrewChar_Char;
			}
		}

		/// <summary>
		/// Boolean IsAllowedJapaneseTokenFollowedByNonSpaceLetter(System.String, Char)
		/// </summary>
		protected RMethod r_RIsAllowedJapaneseTokenFollowedByNonSpaceLetter_String_Char;
		public virtual RMethod RIsAllowedJapaneseTokenFollowedByNonSpaceLetter_String_Char
		{
			get
			{
				if(r_RIsAllowedJapaneseTokenFollowedByNonSpaceLetter_String_Char == null)
				{
					r_RIsAllowedJapaneseTokenFollowedByNonSpaceLetter_String_Char = new(this, "IsAllowedJapaneseTokenFollowedByNonSpaceLetter", 0, typeof(System.String), typeof(System.Char));
					r_RIsAllowedJapaneseTokenFollowedByNonSpaceLetter_String_Char.SetBelong(this.instance);
				}
				return r_RIsAllowedJapaneseTokenFollowedByNonSpaceLetter_String_Char;
			}
		}

		/// <summary>
		/// Boolean Tokenize(System.TokenType, System.TokenType ByRef, Int32 ByRef, System.__DTString ByRef)
		/// </summary>
		protected RMethod r_RTokenize_TokenType_Out_TokenType_Out_Int32_Ref___DTString;
		public virtual RMethod RTokenize_TokenType_Out_TokenType_Out_Int32_Ref___DTString
		{
			get
			{
				if(r_RTokenize_TokenType_Out_TokenType_Out_Int32_Ref___DTString == null)
				{
					r_RTokenize_TokenType_Out_TokenType_Out_Int32_Ref___DTString = new(this, "Tokenize", 0,  ReleactionUtils.GetType("System.TokenType"),  ReleactionUtils.GetType("System.TokenType").MakeByRefType(), typeof(System.Int32).MakeByRefType(),  ReleactionUtils.GetType("System.__DTString").MakeByRefType());
					r_RTokenize_TokenType_Out_TokenType_Out_Int32_Ref___DTString.SetBelong(this.instance);
				}
				return r_RTokenize_TokenType_Out_TokenType_Out_Int32_Ref___DTString;
			}
		}

		/// <summary>
		/// Void InsertAtCurrentHashNode(TokenHashValue[], System.String, Char, System.TokenType, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RInsertAtCurrentHashNode_TokenHashValueArray_String_Char_TokenType_Int32_Int32_Int32_Int32;
		public virtual RMethod RInsertAtCurrentHashNode_TokenHashValueArray_String_Char_TokenType_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_RInsertAtCurrentHashNode_TokenHashValueArray_String_Char_TokenType_Int32_Int32_Int32_Int32 == null)
				{
					r_RInsertAtCurrentHashNode_TokenHashValueArray_String_Char_TokenType_Int32_Int32_Int32_Int32 = new(this, "InsertAtCurrentHashNode", 0,  ReleactionUtils.GetType("System.Globalization.DateTimeFormatInfo+TokenHashValue").MakeArrayType(), typeof(System.String), typeof(System.Char),  ReleactionUtils.GetType("System.TokenType"), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RInsertAtCurrentHashNode_TokenHashValueArray_String_Char_TokenType_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RInsertAtCurrentHashNode_TokenHashValueArray_String_Char_TokenType_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void InsertHash(TokenHashValue[], System.String, System.TokenType, Int32)
		/// </summary>
		protected RMethod r_RInsertHash_TokenHashValueArray_String_TokenType_Int32;
		public virtual RMethod RInsertHash_TokenHashValueArray_String_TokenType_Int32
		{
			get
			{
				if(r_RInsertHash_TokenHashValueArray_String_TokenType_Int32 == null)
				{
					r_RInsertHash_TokenHashValueArray_String_TokenType_Int32 = new(this, "InsertHash", 0,  ReleactionUtils.GetType("System.Globalization.DateTimeFormatInfo+TokenHashValue").MakeArrayType(), typeof(System.String),  ReleactionUtils.GetType("System.TokenType"), typeof(System.Int32));
					r_RInsertHash_TokenHashValueArray_String_TokenType_Int32.SetBelong(this.instance);
				}
				return r_RInsertHash_TokenHashValueArray_String_TokenType_Int32;
			}
		}

		/// <summary>
		/// Boolean CompareStringIgnoreCaseOptimized(System.String, Int32, Int32, System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_RCompareStringIgnoreCaseOptimized_String_Int32_Int32_String_Int32_Int32;
		public virtual RMethod RCompareStringIgnoreCaseOptimized_String_Int32_Int32_String_Int32_Int32
		{
			get
			{
				if(r_RCompareStringIgnoreCaseOptimized_String_Int32_Int32_String_Int32_Int32 == null)
				{
					r_RCompareStringIgnoreCaseOptimized_String_Int32_Int32_String_Int32_Int32 = new(this, "CompareStringIgnoreCaseOptimized", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_RCompareStringIgnoreCaseOptimized_String_Int32_Int32_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_RCompareStringIgnoreCaseOptimized_String_Int32_Int32_String_Int32_Int32;
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

        public virtual System.String[] internalGetAbbreviatedDayOfWeekNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RinternalGetAbbreviatedDayOfWeekNames.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] internalGetAbbreviatedDayOfWeekNamesCore()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RinternalGetAbbreviatedDayOfWeekNamesCore.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] internalGetSuperShortDayNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RinternalGetSuperShortDayNames.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] internalGetSuperShortDayNamesCore()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RinternalGetSuperShortDayNamesCore.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] internalGetDayOfWeekNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RinternalGetDayOfWeekNames.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] internalGetDayOfWeekNamesCore()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RinternalGetDayOfWeekNamesCore.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] internalGetAbbreviatedMonthNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RinternalGetAbbreviatedMonthNames.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] internalGetAbbreviatedMonthNamesCore()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RinternalGetAbbreviatedMonthNamesCore.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] internalGetMonthNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RinternalGetMonthNames.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] internalGetMonthNamesCore()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RinternalGetMonthNamesCore.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }



        public static System.Globalization.DateTimeFormatInfo GetInstance(System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RGetInstance_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Globalization.DateTimeFormatInfo)___result;
        }


        public virtual System.Object GetFormat(System.Type  @formatType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@formatType};
            var ___result = RGetFormat_Type.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Int32 GetEra(System.String  @eraName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eraName};
            var ___result = RGetEra_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String GetEraName(System.Int32  @era)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@era};
            var ___result = RGetEraName_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetAbbreviatedEraName(System.Int32  @era)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@era};
            var ___result = RGetAbbreviatedEraName_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static void CheckNullValue(System.String[]  @values, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@values, @length};
            var ___result = RCheckNullValue_StringArray_Int32.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.String[] internalGetGenitiveMonthNames(System.Boolean  @abbreviated)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@abbreviated};
            var ___result = RinternalGetGenitiveMonthNames_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] internalGetLeapYearMonthNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RinternalGetLeapYearMonthNames.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String GetAbbreviatedDayName(System.DayOfWeek  @dayofweek)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dayofweek};
            var ___result = RGetAbbreviatedDayName_DayOfWeek.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetShortestDayName(System.DayOfWeek  @dayOfWeek)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dayOfWeek};
            var ___result = RGetShortestDayName_DayOfWeek.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String[] GetCombinedPatterns(System.String[]  @patterns1, System.String[]  @patterns2, System.String  @connectString)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@patterns1, @patterns2, @connectString};
            var ___result = RGetCombinedPatterns_StringArray_StringArray_String.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] GetAllDateTimePatterns()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAllDateTimePatterns.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] GetAllDateTimePatterns(System.Char  @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RGetAllDateTimePatterns_Char.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String GetDayName(System.DayOfWeek  @dayofweek)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dayofweek};
            var ___result = RGetDayName_DayOfWeek.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetAbbreviatedMonthName(System.Int32  @month)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@month};
            var ___result = RGetAbbreviatedMonthName_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetMonthName(System.Int32  @month)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@month};
            var ___result = RGetMonthName_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String[] GetMergedPatterns(System.String[]  @patterns, System.String  @defaultPattern)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@patterns, @defaultPattern};
            var ___result = RGetMergedPatterns_StringArray_String.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public static System.Globalization.DateTimeFormatInfo ReadOnly(System.Globalization.DateTimeFormatInfo  @dtfi)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dtfi};
            var ___result = RReadOnly_DateTimeFormatInfo.Invoke(___genericsType, ___parameters);

            return (System.Globalization.DateTimeFormatInfo)___result;
        }


        public virtual void SetAllDateTimePatterns(System.String[]  @patterns, System.Char  @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@patterns, @format};
            var ___result = RSetAllDateTimePatterns_StringArray_Char.Invoke(___genericsType, ___parameters);

            
        }


        public static void ValidateStyles(System.Globalization.DateTimeStyles  @style, System.String  @parameterName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style, @parameterName};
            var ___result = RValidateStyles_DateTimeStyles_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object InitializeFormatFlags()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitializeFormatFlags.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean YearMonthAdjustment(ref System.Int32  @year, ref System.Int32  @month, System.Boolean  @parsedMonthName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @month, @parsedMonthName};
            var ___result = RYearMonthAdjustment_Ref_Int32_Ref_Int32_Boolean.Invoke(___genericsType, ___parameters);
			year = (System.Int32)___parameters[0];
			month = (System.Int32)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.Globalization.DateTimeFormatInfo GetJapaneseCalendarDTFI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetJapaneseCalendarDTFI.Invoke(___genericsType, ___parameters);

            return (System.Globalization.DateTimeFormatInfo)___result;
        }


        public static System.Globalization.DateTimeFormatInfo GetTaiwanCalendarDTFI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTaiwanCalendarDTFI.Invoke(___genericsType, ___parameters);

            return (System.Globalization.DateTimeFormatInfo)___result;
        }


        public virtual void ClearTokenHashTable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearTokenHashTable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object CreateTokenHashTable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateTokenHashTable.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }



        public static System.Boolean IsJapaneseCalendar(System.Globalization.Calendar  @calendar)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendar};
            var ___result = RIsJapaneseCalendar_Calendar.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }




        public static System.Boolean IsHebrewChar(System.Char  @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RIsHebrewChar_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsAllowedJapaneseTokenFollowedByNonSpaceLetter(System.String  @tokenString, System.Char  @nextCh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tokenString, @nextCh};
            var ___result = RIsAllowedJapaneseTokenFollowedByNonSpaceLetter_String_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }





        public virtual System.Boolean CompareStringIgnoreCaseOptimized(System.String  @string1, System.Int32  @offset1, System.Int32  @length1, System.String  @string2, System.Int32  @offset2, System.Int32  @length2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@string1, @offset1, @length1, @string2, @offset2, @length2};
            var ___result = RCompareStringIgnoreCaseOptimized_String_Int32_Int32_String_Int32_Int32.Invoke(___genericsType, ___parameters);

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
