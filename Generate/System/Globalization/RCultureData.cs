using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RGlobalization
{
	/// <summary>
	/// System.Globalization.CultureData
	/// </summary>
    public partial class RCultureData : RMember //
    {

		/// <summary>
		/// System.String sAM1159
		/// </summary>
		protected RField r_sAM1159;
		public virtual RField RsAM1159
		{
			get
			{
				if(r_sAM1159 == null)
				{
					r_sAM1159 = new(this, "sAM1159");
					r_sAM1159.SetBelong(this.instance);
				}
				return r_sAM1159;
			}
		}

		/// <summary>
		/// System.String sPM2359
		/// </summary>
		protected RField r_sPM2359;
		public virtual RField RsPM2359
		{
			get
			{
				if(r_sPM2359 == null)
				{
					r_sPM2359 = new(this, "sPM2359");
					r_sPM2359.SetBelong(this.instance);
				}
				return r_sPM2359;
			}
		}

		/// <summary>
		/// System.String sTimeSeparator
		/// </summary>
		protected RField r_sTimeSeparator;
		public virtual RField RsTimeSeparator
		{
			get
			{
				if(r_sTimeSeparator == null)
				{
					r_sTimeSeparator = new(this, "sTimeSeparator");
					r_sTimeSeparator.SetBelong(this.instance);
				}
				return r_sTimeSeparator;
			}
		}

		/// <summary>
		/// System.String[] saLongTimes
		/// </summary>
		protected RFieldArray<RField> r_saLongTimes;
		public virtual RFieldArray<RField> RsaLongTimes
		{
			get
			{
				if(r_saLongTimes == null)
				{
					r_saLongTimes = new(this, "saLongTimes");
					r_saLongTimes.SetBelong(this.instance);
				}
				return r_saLongTimes;
			}
		}

		/// <summary>
		/// System.String[] saShortTimes
		/// </summary>
		protected RFieldArray<RField> r_saShortTimes;
		public virtual RFieldArray<RField> RsaShortTimes
		{
			get
			{
				if(r_saShortTimes == null)
				{
					r_saShortTimes = new(this, "saShortTimes");
					r_saShortTimes.SetBelong(this.instance);
				}
				return r_saShortTimes;
			}
		}

		/// <summary>
		/// System.Int32 iFirstDayOfWeek
		/// </summary>
		protected RField r_iFirstDayOfWeek;
		public virtual RField RiFirstDayOfWeek
		{
			get
			{
				if(r_iFirstDayOfWeek == null)
				{
					r_iFirstDayOfWeek = new(this, "iFirstDayOfWeek");
					r_iFirstDayOfWeek.SetBelong(this.instance);
				}
				return r_iFirstDayOfWeek;
			}
		}

		/// <summary>
		/// System.Int32 iFirstWeekOfYear
		/// </summary>
		protected RField r_iFirstWeekOfYear;
		public virtual RField RiFirstWeekOfYear
		{
			get
			{
				if(r_iFirstWeekOfYear == null)
				{
					r_iFirstWeekOfYear = new(this, "iFirstWeekOfYear");
					r_iFirstWeekOfYear.SetBelong(this.instance);
				}
				return r_iFirstWeekOfYear;
			}
		}

		/// <summary>
		/// System.Int32[] waCalendars
		/// </summary>
		protected RFieldArray<RField> r_waCalendars;
		public virtual RFieldArray<RField> RwaCalendars
		{
			get
			{
				if(r_waCalendars == null)
				{
					r_waCalendars = new(this, "waCalendars");
					r_waCalendars.SetBelong(this.instance);
				}
				return r_waCalendars;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarData[] calendars
		/// </summary>
		protected RFieldArray<RSystem.RGlobalization.RCalendarData> r_calendars;
		public virtual RFieldArray<RSystem.RGlobalization.RCalendarData> Rcalendars
		{
			get
			{
				if(r_calendars == null)
				{
					r_calendars = new(this, "calendars");
					r_calendars.SetBelong(this.instance);
				}
				return r_calendars;
			}
		}

		/// <summary>
		/// System.String sISO639Language
		/// </summary>
		protected RField r_sISO639Language;
		public virtual RField RsISO639Language
		{
			get
			{
				if(r_sISO639Language == null)
				{
					r_sISO639Language = new(this, "sISO639Language");
					r_sISO639Language.SetBelong(this.instance);
				}
				return r_sISO639Language;
			}
		}

		/// <summary>
		/// System.String sRealName
		/// </summary>
		protected RField r_sRealName;
		public virtual RField RsRealName
		{
			get
			{
				if(r_sRealName == null)
				{
					r_sRealName = new(this, "sRealName");
					r_sRealName.SetBelong(this.instance);
				}
				return r_sRealName;
			}
		}

		/// <summary>
		/// System.Boolean bUseOverrides
		/// </summary>
		protected RField r_bUseOverrides;
		public virtual RField RbUseOverrides
		{
			get
			{
				if(r_bUseOverrides == null)
				{
					r_bUseOverrides = new(this, "bUseOverrides");
					r_bUseOverrides.SetBelong(this.instance);
				}
				return r_bUseOverrides;
			}
		}

		/// <summary>
		/// System.Int32 calendarId
		/// </summary>
		protected RField r_calendarId;
		public virtual RField RcalendarId
		{
			get
			{
				if(r_calendarId == null)
				{
					r_calendarId = new(this, "calendarId");
					r_calendarId.SetBelong(this.instance);
				}
				return r_calendarId;
			}
		}

		/// <summary>
		/// System.Int32 numberIndex
		/// </summary>
		protected RField r_numberIndex;
		public virtual RField RnumberIndex
		{
			get
			{
				if(r_numberIndex == null)
				{
					r_numberIndex = new(this, "numberIndex");
					r_numberIndex.SetBelong(this.instance);
				}
				return r_numberIndex;
			}
		}

		/// <summary>
		/// System.Int32 iDefaultAnsiCodePage
		/// </summary>
		protected RField r_iDefaultAnsiCodePage;
		public virtual RField RiDefaultAnsiCodePage
		{
			get
			{
				if(r_iDefaultAnsiCodePage == null)
				{
					r_iDefaultAnsiCodePage = new(this, "iDefaultAnsiCodePage");
					r_iDefaultAnsiCodePage.SetBelong(this.instance);
				}
				return r_iDefaultAnsiCodePage;
			}
		}

		/// <summary>
		/// System.Int32 iDefaultOemCodePage
		/// </summary>
		protected RField r_iDefaultOemCodePage;
		public virtual RField RiDefaultOemCodePage
		{
			get
			{
				if(r_iDefaultOemCodePage == null)
				{
					r_iDefaultOemCodePage = new(this, "iDefaultOemCodePage");
					r_iDefaultOemCodePage.SetBelong(this.instance);
				}
				return r_iDefaultOemCodePage;
			}
		}

		/// <summary>
		/// System.Int32 iDefaultMacCodePage
		/// </summary>
		protected RField r_iDefaultMacCodePage;
		public virtual RField RiDefaultMacCodePage
		{
			get
			{
				if(r_iDefaultMacCodePage == null)
				{
					r_iDefaultMacCodePage = new(this, "iDefaultMacCodePage");
					r_iDefaultMacCodePage.SetBelong(this.instance);
				}
				return r_iDefaultMacCodePage;
			}
		}

		/// <summary>
		/// System.Int32 iDefaultEbcdicCodePage
		/// </summary>
		protected RField r_iDefaultEbcdicCodePage;
		public virtual RField RiDefaultEbcdicCodePage
		{
			get
			{
				if(r_iDefaultEbcdicCodePage == null)
				{
					r_iDefaultEbcdicCodePage = new(this, "iDefaultEbcdicCodePage");
					r_iDefaultEbcdicCodePage.SetBelong(this.instance);
				}
				return r_iDefaultEbcdicCodePage;
			}
		}

		/// <summary>
		/// System.Boolean isRightToLeft
		/// </summary>
		protected RField r_isRightToLeft;
		public virtual RField RisRightToLeft
		{
			get
			{
				if(r_isRightToLeft == null)
				{
					r_isRightToLeft = new(this, "isRightToLeft");
					r_isRightToLeft.SetBelong(this.instance);
				}
				return r_isRightToLeft;
			}
		}

		/// <summary>
		/// System.String sListSeparator
		/// </summary>
		protected RField r_sListSeparator;
		public virtual RField RsListSeparator
		{
			get
			{
				if(r_sListSeparator == null)
				{
					r_sListSeparator = new(this, "sListSeparator");
					r_sListSeparator.SetBelong(this.instance);
				}
				return r_sListSeparator;
			}
		}

		/// <summary>
		/// System.Globalization.CultureData s_Invariant
		/// </summary>
		protected static RSystem.RGlobalization.RCultureData r_s_Invariant;
		public static RSystem.RGlobalization.RCultureData Rs_Invariant
		{
			get
			{
				if(r_s_Invariant == null)
				{
					r_s_Invariant = new( ReleactionUtils.GetType("System.Globalization.CultureData"), "s_Invariant");
					r_s_Invariant.SetBelong(null);
				}
				return r_s_Invariant;
			}
		}

		/// <summary>
		/// System.Globalization.CultureData Invariant
		/// </summary>
		protected static RSystem.RGlobalization.RCultureData r_Invariant;
		public static RSystem.RGlobalization.RCultureData RInvariant
		{
			get
			{
				if(r_Invariant == null)
				{
					r_Invariant = new( ReleactionUtils.GetType("System.Globalization.CultureData"), "Invariant", -1);
					r_Invariant.SetBelong(null);
				}
				return r_Invariant;
			}
		}

		/// <summary>
		/// System.String[] LongTimes
		/// </summary>
		protected RPropertyArray<RProperty> r_LongTimes;
		public virtual RPropertyArray<RProperty> RLongTimes
		{
			get
			{
				if(r_LongTimes == null)
				{
					r_LongTimes = new(this, "LongTimes", -1);
					r_LongTimes.SetBelong(this.instance);
				}
				return r_LongTimes;
			}
		}

		/// <summary>
		/// System.String[] ShortTimes
		/// </summary>
		protected RPropertyArray<RProperty> r_ShortTimes;
		public virtual RPropertyArray<RProperty> RShortTimes
		{
			get
			{
				if(r_ShortTimes == null)
				{
					r_ShortTimes = new(this, "ShortTimes", -1);
					r_ShortTimes.SetBelong(this.instance);
				}
				return r_ShortTimes;
			}
		}

		/// <summary>
		/// System.String SISO639LANGNAME
		/// </summary>
		protected RProperty r_SISO639LANGNAME;
		public virtual RProperty RSISO639LANGNAME
		{
			get
			{
				if(r_SISO639LANGNAME == null)
				{
					r_SISO639LANGNAME = new(this, "SISO639LANGNAME", -1);
					r_SISO639LANGNAME.SetBelong(this.instance);
				}
				return r_SISO639LANGNAME;
			}
		}

		/// <summary>
		/// Int32 IFIRSTDAYOFWEEK
		/// </summary>
		protected RProperty r_IFIRSTDAYOFWEEK;
		public virtual RProperty RIFIRSTDAYOFWEEK
		{
			get
			{
				if(r_IFIRSTDAYOFWEEK == null)
				{
					r_IFIRSTDAYOFWEEK = new(this, "IFIRSTDAYOFWEEK", -1);
					r_IFIRSTDAYOFWEEK.SetBelong(this.instance);
				}
				return r_IFIRSTDAYOFWEEK;
			}
		}

		/// <summary>
		/// Int32 IFIRSTWEEKOFYEAR
		/// </summary>
		protected RProperty r_IFIRSTWEEKOFYEAR;
		public virtual RProperty RIFIRSTWEEKOFYEAR
		{
			get
			{
				if(r_IFIRSTWEEKOFYEAR == null)
				{
					r_IFIRSTWEEKOFYEAR = new(this, "IFIRSTWEEKOFYEAR", -1);
					r_IFIRSTWEEKOFYEAR.SetBelong(this.instance);
				}
				return r_IFIRSTWEEKOFYEAR;
			}
		}

		/// <summary>
		/// System.String SAM1159
		/// </summary>
		protected RProperty r_SAM1159;
		public virtual RProperty RSAM1159
		{
			get
			{
				if(r_SAM1159 == null)
				{
					r_SAM1159 = new(this, "SAM1159", -1);
					r_SAM1159.SetBelong(this.instance);
				}
				return r_SAM1159;
			}
		}

		/// <summary>
		/// System.String SPM2359
		/// </summary>
		protected RProperty r_SPM2359;
		public virtual RProperty RSPM2359
		{
			get
			{
				if(r_SPM2359 == null)
				{
					r_SPM2359 = new(this, "SPM2359", -1);
					r_SPM2359.SetBelong(this.instance);
				}
				return r_SPM2359;
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
		/// Int32[] CalendarIds
		/// </summary>
		protected RPropertyArray<RProperty> r_CalendarIds;
		public virtual RPropertyArray<RProperty> RCalendarIds
		{
			get
			{
				if(r_CalendarIds == null)
				{
					r_CalendarIds = new(this, "CalendarIds", -1);
					r_CalendarIds.SetBelong(this.instance);
				}
				return r_CalendarIds;
			}
		}

		/// <summary>
		/// Boolean IsInvariantCulture
		/// </summary>
		protected RProperty r_IsInvariantCulture;
		public virtual RProperty RIsInvariantCulture
		{
			get
			{
				if(r_IsInvariantCulture == null)
				{
					r_IsInvariantCulture = new(this, "IsInvariantCulture", -1);
					r_IsInvariantCulture.SetBelong(this.instance);
				}
				return r_IsInvariantCulture;
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
		/// System.String SCOMPAREINFO
		/// </summary>
		protected RProperty r_SCOMPAREINFO;
		public virtual RProperty RSCOMPAREINFO
		{
			get
			{
				if(r_SCOMPAREINFO == null)
				{
					r_SCOMPAREINFO = new(this, "SCOMPAREINFO", -1);
					r_SCOMPAREINFO.SetBelong(this.instance);
				}
				return r_SCOMPAREINFO;
			}
		}

		/// <summary>
		/// System.String STEXTINFO
		/// </summary>
		protected RProperty r_STEXTINFO;
		public virtual RProperty RSTEXTINFO
		{
			get
			{
				if(r_STEXTINFO == null)
				{
					r_STEXTINFO = new(this, "STEXTINFO", -1);
					r_STEXTINFO.SetBelong(this.instance);
				}
				return r_STEXTINFO;
			}
		}

		/// <summary>
		/// Int32 ILANGUAGE
		/// </summary>
		protected RProperty r_ILANGUAGE;
		public virtual RProperty RILANGUAGE
		{
			get
			{
				if(r_ILANGUAGE == null)
				{
					r_ILANGUAGE = new(this, "ILANGUAGE", -1);
					r_ILANGUAGE.SetBelong(this.instance);
				}
				return r_ILANGUAGE;
			}
		}

		/// <summary>
		/// Int32 IDEFAULTANSICODEPAGE
		/// </summary>
		protected RProperty r_IDEFAULTANSICODEPAGE;
		public virtual RProperty RIDEFAULTANSICODEPAGE
		{
			get
			{
				if(r_IDEFAULTANSICODEPAGE == null)
				{
					r_IDEFAULTANSICODEPAGE = new(this, "IDEFAULTANSICODEPAGE", -1);
					r_IDEFAULTANSICODEPAGE.SetBelong(this.instance);
				}
				return r_IDEFAULTANSICODEPAGE;
			}
		}

		/// <summary>
		/// Int32 IDEFAULTOEMCODEPAGE
		/// </summary>
		protected RProperty r_IDEFAULTOEMCODEPAGE;
		public virtual RProperty RIDEFAULTOEMCODEPAGE
		{
			get
			{
				if(r_IDEFAULTOEMCODEPAGE == null)
				{
					r_IDEFAULTOEMCODEPAGE = new(this, "IDEFAULTOEMCODEPAGE", -1);
					r_IDEFAULTOEMCODEPAGE.SetBelong(this.instance);
				}
				return r_IDEFAULTOEMCODEPAGE;
			}
		}

		/// <summary>
		/// Int32 IDEFAULTMACCODEPAGE
		/// </summary>
		protected RProperty r_IDEFAULTMACCODEPAGE;
		public virtual RProperty RIDEFAULTMACCODEPAGE
		{
			get
			{
				if(r_IDEFAULTMACCODEPAGE == null)
				{
					r_IDEFAULTMACCODEPAGE = new(this, "IDEFAULTMACCODEPAGE", -1);
					r_IDEFAULTMACCODEPAGE.SetBelong(this.instance);
				}
				return r_IDEFAULTMACCODEPAGE;
			}
		}

		/// <summary>
		/// Int32 IDEFAULTEBCDICCODEPAGE
		/// </summary>
		protected RProperty r_IDEFAULTEBCDICCODEPAGE;
		public virtual RProperty RIDEFAULTEBCDICCODEPAGE
		{
			get
			{
				if(r_IDEFAULTEBCDICCODEPAGE == null)
				{
					r_IDEFAULTEBCDICCODEPAGE = new(this, "IDEFAULTEBCDICCODEPAGE", -1);
					r_IDEFAULTEBCDICCODEPAGE.SetBelong(this.instance);
				}
				return r_IDEFAULTEBCDICCODEPAGE;
			}
		}

		/// <summary>
		/// Boolean IsRightToLeft
		/// </summary>
		protected RProperty r_IsRightToLeft;
		public virtual RProperty RIsRightToLeft
		{
			get
			{
				if(r_IsRightToLeft == null)
				{
					r_IsRightToLeft = new(this, "IsRightToLeft", -1);
					r_IsRightToLeft.SetBelong(this.instance);
				}
				return r_IsRightToLeft;
			}
		}

		/// <summary>
		/// System.String SLIST
		/// </summary>
		protected RProperty r_SLIST;
		public virtual RProperty RSLIST
		{
			get
			{
				if(r_SLIST == null)
				{
					r_SLIST = new(this, "SLIST", -1);
					r_SLIST.SetBelong(this.instance);
				}
				return r_SLIST;
			}
		}

		/// <summary>
		/// Boolean UseUserOverride
		/// </summary>
		protected RProperty r_UseUserOverride;
		public virtual RProperty RUseUserOverride
		{
			get
			{
				if(r_UseUserOverride == null)
				{
					r_UseUserOverride = new(this, "UseUserOverride", -1);
					r_UseUserOverride.SetBelong(this.instance);
				}
				return r_UseUserOverride;
			}
		}

		/// <summary>
		/// System.Globalization.CultureData GetCultureData(System.String, Boolean)
		/// </summary>
		protected static RMethod r_GetCultureData_String_Boolean;
		public static RMethod RGetCultureData_String_Boolean
		{
			get
			{
				if(r_GetCultureData_String_Boolean == null)
				{
					r_GetCultureData_String_Boolean = new( ReleactionUtils.GetType("System.Globalization.CultureData"), "GetCultureData", 0, typeof(System.String), typeof(System.Boolean));
					r_GetCultureData_String_Boolean.SetBelong(null);
				}
				return r_GetCultureData_String_Boolean;
			}
		}

		/// <summary>
		/// System.Globalization.CultureData GetCultureData(System.String, Boolean, Int32, Int32, Int32, System.String, Int32, Int32, Int32, Int32, Boolean, System.String)
		/// </summary>
		protected static RMethod r_GetCultureData_String_Boolean_Int32_Int32_Int32_String_Int32_Int32_Int32_Int32_Boolean_String;
		public static RMethod RGetCultureData_String_Boolean_Int32_Int32_Int32_String_Int32_Int32_Int32_Int32_Boolean_String
		{
			get
			{
				if(r_GetCultureData_String_Boolean_Int32_Int32_Int32_String_Int32_Int32_Int32_Int32_Boolean_String == null)
				{
					r_GetCultureData_String_Boolean_Int32_Int32_Int32_String_Int32_Int32_Int32_Int32_Boolean_String = new( ReleactionUtils.GetType("System.Globalization.CultureData"), "GetCultureData", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.String));
					r_GetCultureData_String_Boolean_Int32_Int32_Int32_String_Int32_Int32_Int32_Int32_Boolean_String.SetBelong(null);
				}
				return r_GetCultureData_String_Boolean_Int32_Int32_Int32_String_Int32_Int32_Int32_Int32_Boolean_String;
			}
		}

		/// <summary>
		/// System.Globalization.CultureData GetCultureData(Int32, Boolean)
		/// </summary>
		protected static RMethod r_GetCultureData_Int32_Boolean;
		public static RMethod RGetCultureData_Int32_Boolean
		{
			get
			{
				if(r_GetCultureData_Int32_Boolean == null)
				{
					r_GetCultureData_Int32_Boolean = new( ReleactionUtils.GetType("System.Globalization.CultureData"), "GetCultureData", 0, typeof(System.Int32), typeof(System.Boolean));
					r_GetCultureData_Int32_Boolean.SetBelong(null);
				}
				return r_GetCultureData_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void fill_culture_data(Int32)
		/// </summary>
		protected RMethod r_fill_culture_data_Int32;
		public virtual RMethod Rfill_culture_data_Int32
		{
			get
			{
				if(r_fill_culture_data_Int32 == null)
				{
					r_fill_culture_data_Int32 = new(this, "fill_culture_data", 0, typeof(System.Int32));
					r_fill_culture_data_Int32.SetBelong(this.instance);
				}
				return r_fill_culture_data_Int32;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarData GetCalendar(Int32)
		/// </summary>
		protected RMethod r_GetCalendar_Int32;
		public virtual RMethod RGetCalendar_Int32
		{
			get
			{
				if(r_GetCalendar_Int32 == null)
				{
					r_GetCalendar_Int32 = new(this, "GetCalendar", 0, typeof(System.Int32));
					r_GetCalendar_Int32.SetBelong(this.instance);
				}
				return r_GetCalendar_Int32;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarId[] GetCalendarIds()
		/// </summary>
		protected RMethod r_GetCalendarIds;
		public virtual RMethod RGetCalendarIds
		{
			get
			{
				if(r_GetCalendarIds == null)
				{
					r_GetCalendarIds = new(this, "GetCalendarIds", 0);
					r_GetCalendarIds.SetBelong(this.instance);
				}
				return r_GetCalendarIds;
			}
		}

		/// <summary>
		/// System.String CalendarName(Int32)
		/// </summary>
		protected RMethod r_CalendarName_Int32;
		public virtual RMethod RCalendarName_Int32
		{
			get
			{
				if(r_CalendarName_Int32 == null)
				{
					r_CalendarName_Int32 = new(this, "CalendarName", 0, typeof(System.Int32));
					r_CalendarName_Int32.SetBelong(this.instance);
				}
				return r_CalendarName_Int32;
			}
		}

		/// <summary>
		/// System.String[] EraNames(Int32)
		/// </summary>
		protected RMethod r_EraNames_Int32;
		public virtual RMethod REraNames_Int32
		{
			get
			{
				if(r_EraNames_Int32 == null)
				{
					r_EraNames_Int32 = new(this, "EraNames", 0, typeof(System.Int32));
					r_EraNames_Int32.SetBelong(this.instance);
				}
				return r_EraNames_Int32;
			}
		}

		/// <summary>
		/// System.String[] AbbrevEraNames(Int32)
		/// </summary>
		protected RMethod r_AbbrevEraNames_Int32;
		public virtual RMethod RAbbrevEraNames_Int32
		{
			get
			{
				if(r_AbbrevEraNames_Int32 == null)
				{
					r_AbbrevEraNames_Int32 = new(this, "AbbrevEraNames", 0, typeof(System.Int32));
					r_AbbrevEraNames_Int32.SetBelong(this.instance);
				}
				return r_AbbrevEraNames_Int32;
			}
		}

		/// <summary>
		/// System.String[] AbbreviatedEnglishEraNames(Int32)
		/// </summary>
		protected RMethod r_AbbreviatedEnglishEraNames_Int32;
		public virtual RMethod RAbbreviatedEnglishEraNames_Int32
		{
			get
			{
				if(r_AbbreviatedEnglishEraNames_Int32 == null)
				{
					r_AbbreviatedEnglishEraNames_Int32 = new(this, "AbbreviatedEnglishEraNames", 0, typeof(System.Int32));
					r_AbbreviatedEnglishEraNames_Int32.SetBelong(this.instance);
				}
				return r_AbbreviatedEnglishEraNames_Int32;
			}
		}

		/// <summary>
		/// System.String[] ShortDates(Int32)
		/// </summary>
		protected RMethod r_ShortDates_Int32;
		public virtual RMethod RShortDates_Int32
		{
			get
			{
				if(r_ShortDates_Int32 == null)
				{
					r_ShortDates_Int32 = new(this, "ShortDates", 0, typeof(System.Int32));
					r_ShortDates_Int32.SetBelong(this.instance);
				}
				return r_ShortDates_Int32;
			}
		}

		/// <summary>
		/// System.String[] LongDates(Int32)
		/// </summary>
		protected RMethod r_LongDates_Int32;
		public virtual RMethod RLongDates_Int32
		{
			get
			{
				if(r_LongDates_Int32 == null)
				{
					r_LongDates_Int32 = new(this, "LongDates", 0, typeof(System.Int32));
					r_LongDates_Int32.SetBelong(this.instance);
				}
				return r_LongDates_Int32;
			}
		}

		/// <summary>
		/// System.String[] YearMonths(Int32)
		/// </summary>
		protected RMethod r_YearMonths_Int32;
		public virtual RMethod RYearMonths_Int32
		{
			get
			{
				if(r_YearMonths_Int32 == null)
				{
					r_YearMonths_Int32 = new(this, "YearMonths", 0, typeof(System.Int32));
					r_YearMonths_Int32.SetBelong(this.instance);
				}
				return r_YearMonths_Int32;
			}
		}

		/// <summary>
		/// System.String[] DayNames(Int32)
		/// </summary>
		protected RMethod r_DayNames_Int32;
		public virtual RMethod RDayNames_Int32
		{
			get
			{
				if(r_DayNames_Int32 == null)
				{
					r_DayNames_Int32 = new(this, "DayNames", 0, typeof(System.Int32));
					r_DayNames_Int32.SetBelong(this.instance);
				}
				return r_DayNames_Int32;
			}
		}

		/// <summary>
		/// System.String[] AbbreviatedDayNames(Int32)
		/// </summary>
		protected RMethod r_AbbreviatedDayNames_Int32;
		public virtual RMethod RAbbreviatedDayNames_Int32
		{
			get
			{
				if(r_AbbreviatedDayNames_Int32 == null)
				{
					r_AbbreviatedDayNames_Int32 = new(this, "AbbreviatedDayNames", 0, typeof(System.Int32));
					r_AbbreviatedDayNames_Int32.SetBelong(this.instance);
				}
				return r_AbbreviatedDayNames_Int32;
			}
		}

		/// <summary>
		/// System.String[] SuperShortDayNames(Int32)
		/// </summary>
		protected RMethod r_SuperShortDayNames_Int32;
		public virtual RMethod RSuperShortDayNames_Int32
		{
			get
			{
				if(r_SuperShortDayNames_Int32 == null)
				{
					r_SuperShortDayNames_Int32 = new(this, "SuperShortDayNames", 0, typeof(System.Int32));
					r_SuperShortDayNames_Int32.SetBelong(this.instance);
				}
				return r_SuperShortDayNames_Int32;
			}
		}

		/// <summary>
		/// System.String[] MonthNames(Int32)
		/// </summary>
		protected RMethod r_MonthNames_Int32;
		public virtual RMethod RMonthNames_Int32
		{
			get
			{
				if(r_MonthNames_Int32 == null)
				{
					r_MonthNames_Int32 = new(this, "MonthNames", 0, typeof(System.Int32));
					r_MonthNames_Int32.SetBelong(this.instance);
				}
				return r_MonthNames_Int32;
			}
		}

		/// <summary>
		/// System.String[] GenitiveMonthNames(Int32)
		/// </summary>
		protected RMethod r_GenitiveMonthNames_Int32;
		public virtual RMethod RGenitiveMonthNames_Int32
		{
			get
			{
				if(r_GenitiveMonthNames_Int32 == null)
				{
					r_GenitiveMonthNames_Int32 = new(this, "GenitiveMonthNames", 0, typeof(System.Int32));
					r_GenitiveMonthNames_Int32.SetBelong(this.instance);
				}
				return r_GenitiveMonthNames_Int32;
			}
		}

		/// <summary>
		/// System.String[] AbbreviatedMonthNames(Int32)
		/// </summary>
		protected RMethod r_AbbreviatedMonthNames_Int32;
		public virtual RMethod RAbbreviatedMonthNames_Int32
		{
			get
			{
				if(r_AbbreviatedMonthNames_Int32 == null)
				{
					r_AbbreviatedMonthNames_Int32 = new(this, "AbbreviatedMonthNames", 0, typeof(System.Int32));
					r_AbbreviatedMonthNames_Int32.SetBelong(this.instance);
				}
				return r_AbbreviatedMonthNames_Int32;
			}
		}

		/// <summary>
		/// System.String[] AbbreviatedGenitiveMonthNames(Int32)
		/// </summary>
		protected RMethod r_AbbreviatedGenitiveMonthNames_Int32;
		public virtual RMethod RAbbreviatedGenitiveMonthNames_Int32
		{
			get
			{
				if(r_AbbreviatedGenitiveMonthNames_Int32 == null)
				{
					r_AbbreviatedGenitiveMonthNames_Int32 = new(this, "AbbreviatedGenitiveMonthNames", 0, typeof(System.Int32));
					r_AbbreviatedGenitiveMonthNames_Int32.SetBelong(this.instance);
				}
				return r_AbbreviatedGenitiveMonthNames_Int32;
			}
		}

		/// <summary>
		/// System.String[] LeapYearMonthNames(Int32)
		/// </summary>
		protected RMethod r_LeapYearMonthNames_Int32;
		public virtual RMethod RLeapYearMonthNames_Int32
		{
			get
			{
				if(r_LeapYearMonthNames_Int32 == null)
				{
					r_LeapYearMonthNames_Int32 = new(this, "LeapYearMonthNames", 0, typeof(System.Int32));
					r_LeapYearMonthNames_Int32.SetBelong(this.instance);
				}
				return r_LeapYearMonthNames_Int32;
			}
		}

		/// <summary>
		/// System.String MonthDay(Int32)
		/// </summary>
		protected RMethod r_MonthDay_Int32;
		public virtual RMethod RMonthDay_Int32
		{
			get
			{
				if(r_MonthDay_Int32 == null)
				{
					r_MonthDay_Int32 = new(this, "MonthDay", 0, typeof(System.Int32));
					r_MonthDay_Int32.SetBelong(this.instance);
				}
				return r_MonthDay_Int32;
			}
		}

		/// <summary>
		/// System.String DateSeparator(Int32)
		/// </summary>
		protected RMethod r_DateSeparator_Int32;
		public virtual RMethod RDateSeparator_Int32
		{
			get
			{
				if(r_DateSeparator_Int32 == null)
				{
					r_DateSeparator_Int32 = new(this, "DateSeparator", 0, typeof(System.Int32));
					r_DateSeparator_Int32.SetBelong(this.instance);
				}
				return r_DateSeparator_Int32;
			}
		}

		/// <summary>
		/// System.String GetDateSeparator(System.String)
		/// </summary>
		protected static RMethod r_GetDateSeparator_String;
		public static RMethod RGetDateSeparator_String
		{
			get
			{
				if(r_GetDateSeparator_String == null)
				{
					r_GetDateSeparator_String = new( ReleactionUtils.GetType("System.Globalization.CultureData"), "GetDateSeparator", 0, typeof(System.String));
					r_GetDateSeparator_String.SetBelong(null);
				}
				return r_GetDateSeparator_String;
			}
		}

		/// <summary>
		/// System.String GetSeparator(System.String, System.String)
		/// </summary>
		protected static RMethod r_GetSeparator_String_String;
		public static RMethod RGetSeparator_String_String
		{
			get
			{
				if(r_GetSeparator_String_String == null)
				{
					r_GetSeparator_String_String = new( ReleactionUtils.GetType("System.Globalization.CultureData"), "GetSeparator", 0, typeof(System.String), typeof(System.String));
					r_GetSeparator_String_String.SetBelong(null);
				}
				return r_GetSeparator_String_String;
			}
		}

		/// <summary>
		/// Int32 IndexOfTimePart(System.String, Int32, System.String)
		/// </summary>
		protected static RMethod r_IndexOfTimePart_String_Int32_String;
		public static RMethod RIndexOfTimePart_String_Int32_String
		{
			get
			{
				if(r_IndexOfTimePart_String_Int32_String == null)
				{
					r_IndexOfTimePart_String_Int32_String = new( ReleactionUtils.GetType("System.Globalization.CultureData"), "IndexOfTimePart", 0, typeof(System.String), typeof(System.Int32), typeof(System.String));
					r_IndexOfTimePart_String_Int32_String.SetBelong(null);
				}
				return r_IndexOfTimePart_String_Int32_String;
			}
		}

		/// <summary>
		/// System.String UnescapeNlsString(System.String, Int32, Int32)
		/// </summary>
		protected static RMethod r_UnescapeNlsString_String_Int32_Int32;
		public static RMethod RUnescapeNlsString_String_Int32_Int32
		{
			get
			{
				if(r_UnescapeNlsString_String_Int32_Int32 == null)
				{
					r_UnescapeNlsString_String_Int32_Int32 = new( ReleactionUtils.GetType("System.Globalization.CultureData"), "UnescapeNlsString", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_UnescapeNlsString_String_Int32_Int32.SetBelong(null);
				}
				return r_UnescapeNlsString_String_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String[] ReescapeWin32Strings(System.String[])
		/// </summary>
		protected static RMethod r_ReescapeWin32Strings_StringArray;
		public static RMethod RReescapeWin32Strings_StringArray
		{
			get
			{
				if(r_ReescapeWin32Strings_StringArray == null)
				{
					r_ReescapeWin32Strings_StringArray = new( ReleactionUtils.GetType("System.Globalization.CultureData"), "ReescapeWin32Strings", 0, typeof(System.String).MakeArrayType());
					r_ReescapeWin32Strings_StringArray.SetBelong(null);
				}
				return r_ReescapeWin32Strings_StringArray;
			}
		}

		/// <summary>
		/// System.String ReescapeWin32String(System.String)
		/// </summary>
		protected static RMethod r_ReescapeWin32String_String;
		public static RMethod RReescapeWin32String_String
		{
			get
			{
				if(r_ReescapeWin32String_String == null)
				{
					r_ReescapeWin32String_String = new( ReleactionUtils.GetType("System.Globalization.CultureData"), "ReescapeWin32String", 0, typeof(System.String));
					r_ReescapeWin32String_String.SetBelong(null);
				}
				return r_ReescapeWin32String_String;
			}
		}

		/// <summary>
		/// Boolean IsCustomCultureId(Int32)
		/// </summary>
		protected static RMethod r_IsCustomCultureId_Int32;
		public static RMethod RIsCustomCultureId_Int32
		{
			get
			{
				if(r_IsCustomCultureId_Int32 == null)
				{
					r_IsCustomCultureId_Int32 = new( ReleactionUtils.GetType("System.Globalization.CultureData"), "IsCustomCultureId", 0, typeof(System.Int32));
					r_IsCustomCultureId_Int32.SetBelong(null);
				}
				return r_IsCustomCultureId_Int32;
			}
		}

		/// <summary>
		/// Int32 strlen(Byte*)
		/// </summary>
		protected static RMethod r_strlen_BytePointer;
		public static RMethod Rstrlen_BytePointer
		{
			get
			{
				if(r_strlen_BytePointer == null)
				{
					r_strlen_BytePointer = new( ReleactionUtils.GetType("System.Globalization.CultureData"), "strlen", 0, typeof(System.Byte).MakePointerType());
					r_strlen_BytePointer.SetBelong(null);
				}
				return r_strlen_BytePointer;
			}
		}

		/// <summary>
		/// System.String idx2string(Byte*, Int32)
		/// </summary>
		protected static RMethod r_idx2string_BytePointer_Int32;
		public static RMethod Ridx2string_BytePointer_Int32
		{
			get
			{
				if(r_idx2string_BytePointer_Int32 == null)
				{
					r_idx2string_BytePointer_Int32 = new( ReleactionUtils.GetType("System.Globalization.CultureData"), "idx2string", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_idx2string_BytePointer_Int32.SetBelong(null);
				}
				return r_idx2string_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Int32[] create_group_sizes_array(Int32, Int32)
		/// </summary>
		protected RMethod r_create_group_sizes_array_Int32_Int32;
		public virtual RMethod Rcreate_group_sizes_array_Int32_Int32
		{
			get
			{
				if(r_create_group_sizes_array_Int32_Int32 == null)
				{
					r_create_group_sizes_array_Int32_Int32 = new(this, "create_group_sizes_array", 0, typeof(System.Int32), typeof(System.Int32));
					r_create_group_sizes_array_Int32_Int32.SetBelong(this.instance);
				}
				return r_create_group_sizes_array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void GetNFIValues(System.Globalization.NumberFormatInfo)
		/// </summary>
		protected RMethod r_GetNFIValues_NumberFormatInfo;
		public virtual RMethod RGetNFIValues_NumberFormatInfo
		{
			get
			{
				if(r_GetNFIValues_NumberFormatInfo == null)
				{
					r_GetNFIValues_NumberFormatInfo = new(this, "GetNFIValues", 0, typeof(System.Globalization.NumberFormatInfo));
					r_GetNFIValues_NumberFormatInfo.SetBelong(this.instance);
				}
				return r_GetNFIValues_NumberFormatInfo;
			}
		}

		/// <summary>
		/// Byte* fill_number_data(Int32, NumberFormatEntryManaged ByRef)
		/// </summary>
		protected static RMethod r_fill_number_data_Int32_Ref_NumberFormatEntryManaged;
		public static RMethod Rfill_number_data_Int32_Ref_NumberFormatEntryManaged
		{
			get
			{
				if(r_fill_number_data_Int32_Ref_NumberFormatEntryManaged == null)
				{
					r_fill_number_data_Int32_Ref_NumberFormatEntryManaged = new( ReleactionUtils.GetType("System.Globalization.CultureData"), "fill_number_data", 0, typeof(System.Int32),  ReleactionUtils.GetType("System.Globalization.CultureData+NumberFormatEntryManaged").MakeByRefType());
					r_fill_number_data_Int32_Ref_NumberFormatEntryManaged.SetBelong(null);
				}
				return r_fill_number_data_Int32_Ref_NumberFormatEntryManaged;
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


        public RCultureData() : base("System.Globalization.CultureData")
        {
        }

        public RCultureData(System.Object instance) : base("System.Globalization.CultureData")
		{
            SetInstance(instance);
		}

        public RCultureData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCultureData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Object GetCultureData(System.String  @cultureName, System.Boolean  @useUserOverride)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cultureName, @useUserOverride};
            var ___result = RGetCultureData_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object GetCultureData(System.String  @cultureName, System.Boolean  @useUserOverride, System.Int32  @datetimeIndex, System.Int32  @calendarId, System.Int32  @numberIndex, System.String  @iso2lang, System.Int32  @ansiCodePage, System.Int32  @oemCodePage, System.Int32  @macCodePage, System.Int32  @ebcdicCodePage, System.Boolean  @rightToLeft, System.String  @listSeparator)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cultureName, @useUserOverride, @datetimeIndex, @calendarId, @numberIndex, @iso2lang, @ansiCodePage, @oemCodePage, @macCodePage, @ebcdicCodePage, @rightToLeft, @listSeparator};
            var ___result = RGetCultureData_String_Boolean_Int32_Int32_Int32_String_Int32_Int32_Int32_Int32_Boolean_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object GetCultureData(System.Int32  @culture, System.Boolean  @bUseUserOverride)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@culture, @bUseUserOverride};
            var ___result = RGetCultureData_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void fill_culture_data(System.Int32  @datetimeIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@datetimeIndex};
            var ___result = Rfill_culture_data_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetCalendar(System.Int32  @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RGetCalendar_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetCalendarIds()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCalendarIds.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String CalendarName(System.Int32  @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RCalendarName_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String[] EraNames(System.Int32  @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = REraNames_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] AbbrevEraNames(System.Int32  @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RAbbrevEraNames_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] AbbreviatedEnglishEraNames(System.Int32  @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RAbbreviatedEnglishEraNames_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] ShortDates(System.Int32  @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RShortDates_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] LongDates(System.Int32  @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RLongDates_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] YearMonths(System.Int32  @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RYearMonths_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] DayNames(System.Int32  @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RDayNames_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] AbbreviatedDayNames(System.Int32  @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RAbbreviatedDayNames_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] SuperShortDayNames(System.Int32  @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RSuperShortDayNames_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] MonthNames(System.Int32  @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RMonthNames_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] GenitiveMonthNames(System.Int32  @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RGenitiveMonthNames_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] AbbreviatedMonthNames(System.Int32  @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RAbbreviatedMonthNames_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] AbbreviatedGenitiveMonthNames(System.Int32  @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RAbbreviatedGenitiveMonthNames_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] LeapYearMonthNames(System.Int32  @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RLeapYearMonthNames_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String MonthDay(System.Int32  @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RMonthDay_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String DateSeparator(System.Int32  @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RDateSeparator_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String GetDateSeparator(System.String  @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RGetDateSeparator_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String GetSeparator(System.String  @format, System.String  @timeParts)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @timeParts};
            var ___result = RGetSeparator_String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Int32 IndexOfTimePart(System.String  @format, System.Int32  @startIndex, System.String  @timeParts)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @startIndex, @timeParts};
            var ___result = RIndexOfTimePart_String_Int32_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.String UnescapeNlsString(System.String  @str, System.Int32  @start, System.Int32  @end)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str, @start, @end};
            var ___result = RUnescapeNlsString_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String[] ReescapeWin32Strings(System.String[]  @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array};
            var ___result = RReescapeWin32Strings_StringArray.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public static System.String ReescapeWin32String(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RReescapeWin32String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Boolean IsCustomCultureId(System.Int32  @cultureId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cultureId};
            var ___result = RIsCustomCultureId_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }




        public virtual System.Int32[] create_group_sizes_array(System.Int32  @gs0, System.Int32  @gs1)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@gs0, @gs1};
            var ___result = Rcreate_group_sizes_array_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32[])___result;
        }


        public virtual void GetNFIValues(System.Globalization.NumberFormatInfo  @nfi)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nfi};
            var ___result = RGetNFIValues_NumberFormatInfo.Invoke(___genericsType, ___parameters);

            
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
