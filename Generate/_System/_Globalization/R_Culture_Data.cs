
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RGlobalization
{
	/// <summary>
	/// System.Globalization.CultureData
	/// </summary>
    public partial class RCultureData : RMember //
    {

		/// <summary>
		/// System.String sAM1159
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FsAM1159;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFsAM1159
		{
			get
			{
				if(r_FsAM1159 == null)
				{
					r_FsAM1159 = new(this, "sAM1159");
					r_FsAM1159.SetBelong(this.instance);
				}
				return r_FsAM1159;
			}
		}

		/// <summary>
		/// System.String sPM2359
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FsPM2359;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFsPM2359
		{
			get
			{
				if(r_FsPM2359 == null)
				{
					r_FsPM2359 = new(this, "sPM2359");
					r_FsPM2359.SetBelong(this.instance);
				}
				return r_FsPM2359;
			}
		}

		/// <summary>
		/// System.String sTimeSeparator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FsTimeSeparator;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFsTimeSeparator
		{
			get
			{
				if(r_FsTimeSeparator == null)
				{
					r_FsTimeSeparator = new(this, "sTimeSeparator");
					r_FsTimeSeparator.SetBelong(this.instance);
				}
				return r_FsTimeSeparator;
			}
		}

		/// <summary>
		/// System.String[] saLongTimes
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FsaLongTimes;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFsaLongTimes
		{
			get
			{
				if(r_FsaLongTimes == null)
				{
					r_FsaLongTimes = new(this, "saLongTimes");
					r_FsaLongTimes.SetBelong(this.instance);
				}
				return r_FsaLongTimes;
			}
		}

		/// <summary>
		/// System.String[] saShortTimes
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FsaShortTimes;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFsaShortTimes
		{
			get
			{
				if(r_FsaShortTimes == null)
				{
					r_FsaShortTimes = new(this, "saShortTimes");
					r_FsaShortTimes.SetBelong(this.instance);
				}
				return r_FsaShortTimes;
			}
		}

		/// <summary>
		/// System.Int32 iFirstDayOfWeek
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FiFirstDayOfWeek;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFiFirstDayOfWeek
		{
			get
			{
				if(r_FiFirstDayOfWeek == null)
				{
					r_FiFirstDayOfWeek = new(this, "iFirstDayOfWeek");
					r_FiFirstDayOfWeek.SetBelong(this.instance);
				}
				return r_FiFirstDayOfWeek;
			}
		}

		/// <summary>
		/// System.Int32 iFirstWeekOfYear
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FiFirstWeekOfYear;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFiFirstWeekOfYear
		{
			get
			{
				if(r_FiFirstWeekOfYear == null)
				{
					r_FiFirstWeekOfYear = new(this, "iFirstWeekOfYear");
					r_FiFirstWeekOfYear.SetBelong(this.instance);
				}
				return r_FiFirstWeekOfYear;
			}
		}

		/// <summary>
		/// System.Int32[] waCalendars
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_FwaCalendars;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> RFwaCalendars
		{
			get
			{
				if(r_FwaCalendars == null)
				{
					r_FwaCalendars = new(this, "waCalendars");
					r_FwaCalendars.SetBelong(this.instance);
				}
				return r_FwaCalendars;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarData[] calendars
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarData> r_Fcalendars;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarData> RFcalendars
		{
			get
			{
				if(r_Fcalendars == null)
				{
					r_Fcalendars = new(this, "calendars");
					r_Fcalendars.SetBelong(this.instance);
				}
				return r_Fcalendars;
			}
		}

		/// <summary>
		/// System.String sISO639Language
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FsISO639Language;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFsISO639Language
		{
			get
			{
				if(r_FsISO639Language == null)
				{
					r_FsISO639Language = new(this, "sISO639Language");
					r_FsISO639Language.SetBelong(this.instance);
				}
				return r_FsISO639Language;
			}
		}

		/// <summary>
		/// System.String sRealName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FsRealName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFsRealName
		{
			get
			{
				if(r_FsRealName == null)
				{
					r_FsRealName = new(this, "sRealName");
					r_FsRealName.SetBelong(this.instance);
				}
				return r_FsRealName;
			}
		}

		/// <summary>
		/// System.Boolean bUseOverrides
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FbUseOverrides;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFbUseOverrides
		{
			get
			{
				if(r_FbUseOverrides == null)
				{
					r_FbUseOverrides = new(this, "bUseOverrides");
					r_FbUseOverrides.SetBelong(this.instance);
				}
				return r_FbUseOverrides;
			}
		}

		/// <summary>
		/// System.Int32 calendarId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FcalendarId;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFcalendarId
		{
			get
			{
				if(r_FcalendarId == null)
				{
					r_FcalendarId = new(this, "calendarId");
					r_FcalendarId.SetBelong(this.instance);
				}
				return r_FcalendarId;
			}
		}

		/// <summary>
		/// System.Int32 numberIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FnumberIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFnumberIndex
		{
			get
			{
				if(r_FnumberIndex == null)
				{
					r_FnumberIndex = new(this, "numberIndex");
					r_FnumberIndex.SetBelong(this.instance);
				}
				return r_FnumberIndex;
			}
		}

		/// <summary>
		/// System.Int32 iDefaultAnsiCodePage
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FiDefaultAnsiCodePage;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFiDefaultAnsiCodePage
		{
			get
			{
				if(r_FiDefaultAnsiCodePage == null)
				{
					r_FiDefaultAnsiCodePage = new(this, "iDefaultAnsiCodePage");
					r_FiDefaultAnsiCodePage.SetBelong(this.instance);
				}
				return r_FiDefaultAnsiCodePage;
			}
		}

		/// <summary>
		/// System.Int32 iDefaultOemCodePage
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FiDefaultOemCodePage;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFiDefaultOemCodePage
		{
			get
			{
				if(r_FiDefaultOemCodePage == null)
				{
					r_FiDefaultOemCodePage = new(this, "iDefaultOemCodePage");
					r_FiDefaultOemCodePage.SetBelong(this.instance);
				}
				return r_FiDefaultOemCodePage;
			}
		}

		/// <summary>
		/// System.Int32 iDefaultMacCodePage
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FiDefaultMacCodePage;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFiDefaultMacCodePage
		{
			get
			{
				if(r_FiDefaultMacCodePage == null)
				{
					r_FiDefaultMacCodePage = new(this, "iDefaultMacCodePage");
					r_FiDefaultMacCodePage.SetBelong(this.instance);
				}
				return r_FiDefaultMacCodePage;
			}
		}

		/// <summary>
		/// System.Int32 iDefaultEbcdicCodePage
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FiDefaultEbcdicCodePage;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFiDefaultEbcdicCodePage
		{
			get
			{
				if(r_FiDefaultEbcdicCodePage == null)
				{
					r_FiDefaultEbcdicCodePage = new(this, "iDefaultEbcdicCodePage");
					r_FiDefaultEbcdicCodePage.SetBelong(this.instance);
				}
				return r_FiDefaultEbcdicCodePage;
			}
		}

		/// <summary>
		/// System.Boolean isRightToLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FisRightToLeft;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFisRightToLeft
		{
			get
			{
				if(r_FisRightToLeft == null)
				{
					r_FisRightToLeft = new(this, "isRightToLeft");
					r_FisRightToLeft.SetBelong(this.instance);
				}
				return r_FisRightToLeft;
			}
		}

		/// <summary>
		/// System.String sListSeparator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FsListSeparator;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFsListSeparator
		{
			get
			{
				if(r_FsListSeparator == null)
				{
					r_FsListSeparator = new(this, "sListSeparator");
					r_FsListSeparator.SetBelong(this.instance);
				}
				return r_FsListSeparator;
			}
		}

		/// <summary>
		/// System.Globalization.CultureData s_Invariant
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureData r_Fs_Invariant;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureData RFs_Invariant
		{
			get
			{
				if(r_Fs_Invariant == null)
				{
					r_Fs_Invariant = new( ReflectionUtils.GetType("System.Globalization.CultureData"), "s_Invariant");
					r_Fs_Invariant.SetBelong(null);
				}
				return r_Fs_Invariant;
			}
		}

		/// <summary>
		/// System.Globalization.CultureData Invariant
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureData r_PInvariant;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureData RPInvariant
		{
			get
			{
				if(r_PInvariant == null)
				{
					r_PInvariant = new( ReflectionUtils.GetType("System.Globalization.CultureData"), "Invariant", -1);
					r_PInvariant.SetBelong(null);
				}
				return r_PInvariant;
			}
		}

		/// <summary>
		/// System.String[] LongTimes
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_PLongTimes;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPLongTimes
		{
			get
			{
				if(r_PLongTimes == null)
				{
					r_PLongTimes = new(this, "LongTimes", -1);
					r_PLongTimes.SetBelong(this.instance);
				}
				return r_PLongTimes;
			}
		}

		/// <summary>
		/// System.String[] ShortTimes
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_PShortTimes;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPShortTimes
		{
			get
			{
				if(r_PShortTimes == null)
				{
					r_PShortTimes = new(this, "ShortTimes", -1);
					r_PShortTimes.SetBelong(this.instance);
				}
				return r_PShortTimes;
			}
		}

		/// <summary>
		/// System.String SISO639LANGNAME
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PSISO639LANGNAME;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPSISO639LANGNAME
		{
			get
			{
				if(r_PSISO639LANGNAME == null)
				{
					r_PSISO639LANGNAME = new(this, "SISO639LANGNAME", -1);
					r_PSISO639LANGNAME.SetBelong(this.instance);
				}
				return r_PSISO639LANGNAME;
			}
		}

		/// <summary>
		/// Int32 IFIRSTDAYOFWEEK
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PIFIRSTDAYOFWEEK;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPIFIRSTDAYOFWEEK
		{
			get
			{
				if(r_PIFIRSTDAYOFWEEK == null)
				{
					r_PIFIRSTDAYOFWEEK = new(this, "IFIRSTDAYOFWEEK", -1);
					r_PIFIRSTDAYOFWEEK.SetBelong(this.instance);
				}
				return r_PIFIRSTDAYOFWEEK;
			}
		}

		/// <summary>
		/// Int32 IFIRSTWEEKOFYEAR
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PIFIRSTWEEKOFYEAR;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPIFIRSTWEEKOFYEAR
		{
			get
			{
				if(r_PIFIRSTWEEKOFYEAR == null)
				{
					r_PIFIRSTWEEKOFYEAR = new(this, "IFIRSTWEEKOFYEAR", -1);
					r_PIFIRSTWEEKOFYEAR.SetBelong(this.instance);
				}
				return r_PIFIRSTWEEKOFYEAR;
			}
		}

		/// <summary>
		/// System.String SAM1159
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PSAM1159;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPSAM1159
		{
			get
			{
				if(r_PSAM1159 == null)
				{
					r_PSAM1159 = new(this, "SAM1159", -1);
					r_PSAM1159.SetBelong(this.instance);
				}
				return r_PSAM1159;
			}
		}

		/// <summary>
		/// System.String SPM2359
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PSPM2359;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPSPM2359
		{
			get
			{
				if(r_PSPM2359 == null)
				{
					r_PSPM2359 = new(this, "SPM2359", -1);
					r_PSPM2359.SetBelong(this.instance);
				}
				return r_PSPM2359;
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
					r_PTimeSeparator.SetBelong(this.instance);
				}
				return r_PTimeSeparator;
			}
		}

		/// <summary>
		/// Int32[] CalendarIds
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_PCalendarIds;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RInt32> RPCalendarIds
		{
			get
			{
				if(r_PCalendarIds == null)
				{
					r_PCalendarIds = new(this, "CalendarIds", -1);
					r_PCalendarIds.SetBelong(this.instance);
				}
				return r_PCalendarIds;
			}
		}

		/// <summary>
		/// Boolean IsInvariantCulture
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsInvariantCulture;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsInvariantCulture
		{
			get
			{
				if(r_PIsInvariantCulture == null)
				{
					r_PIsInvariantCulture = new(this, "IsInvariantCulture", -1);
					r_PIsInvariantCulture.SetBelong(this.instance);
				}
				return r_PIsInvariantCulture;
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
					r_PCultureName.SetBelong(this.instance);
				}
				return r_PCultureName;
			}
		}

		/// <summary>
		/// System.String SCOMPAREINFO
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PSCOMPAREINFO;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPSCOMPAREINFO
		{
			get
			{
				if(r_PSCOMPAREINFO == null)
				{
					r_PSCOMPAREINFO = new(this, "SCOMPAREINFO", -1);
					r_PSCOMPAREINFO.SetBelong(this.instance);
				}
				return r_PSCOMPAREINFO;
			}
		}

		/// <summary>
		/// System.String STEXTINFO
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PSTEXTINFO;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPSTEXTINFO
		{
			get
			{
				if(r_PSTEXTINFO == null)
				{
					r_PSTEXTINFO = new(this, "STEXTINFO", -1);
					r_PSTEXTINFO.SetBelong(this.instance);
				}
				return r_PSTEXTINFO;
			}
		}

		/// <summary>
		/// Int32 ILANGUAGE
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PILANGUAGE;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPILANGUAGE
		{
			get
			{
				if(r_PILANGUAGE == null)
				{
					r_PILANGUAGE = new(this, "ILANGUAGE", -1);
					r_PILANGUAGE.SetBelong(this.instance);
				}
				return r_PILANGUAGE;
			}
		}

		/// <summary>
		/// Int32 IDEFAULTANSICODEPAGE
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PIDEFAULTANSICODEPAGE;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPIDEFAULTANSICODEPAGE
		{
			get
			{
				if(r_PIDEFAULTANSICODEPAGE == null)
				{
					r_PIDEFAULTANSICODEPAGE = new(this, "IDEFAULTANSICODEPAGE", -1);
					r_PIDEFAULTANSICODEPAGE.SetBelong(this.instance);
				}
				return r_PIDEFAULTANSICODEPAGE;
			}
		}

		/// <summary>
		/// Int32 IDEFAULTOEMCODEPAGE
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PIDEFAULTOEMCODEPAGE;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPIDEFAULTOEMCODEPAGE
		{
			get
			{
				if(r_PIDEFAULTOEMCODEPAGE == null)
				{
					r_PIDEFAULTOEMCODEPAGE = new(this, "IDEFAULTOEMCODEPAGE", -1);
					r_PIDEFAULTOEMCODEPAGE.SetBelong(this.instance);
				}
				return r_PIDEFAULTOEMCODEPAGE;
			}
		}

		/// <summary>
		/// Int32 IDEFAULTMACCODEPAGE
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PIDEFAULTMACCODEPAGE;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPIDEFAULTMACCODEPAGE
		{
			get
			{
				if(r_PIDEFAULTMACCODEPAGE == null)
				{
					r_PIDEFAULTMACCODEPAGE = new(this, "IDEFAULTMACCODEPAGE", -1);
					r_PIDEFAULTMACCODEPAGE.SetBelong(this.instance);
				}
				return r_PIDEFAULTMACCODEPAGE;
			}
		}

		/// <summary>
		/// Int32 IDEFAULTEBCDICCODEPAGE
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PIDEFAULTEBCDICCODEPAGE;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPIDEFAULTEBCDICCODEPAGE
		{
			get
			{
				if(r_PIDEFAULTEBCDICCODEPAGE == null)
				{
					r_PIDEFAULTEBCDICCODEPAGE = new(this, "IDEFAULTEBCDICCODEPAGE", -1);
					r_PIDEFAULTEBCDICCODEPAGE.SetBelong(this.instance);
				}
				return r_PIDEFAULTEBCDICCODEPAGE;
			}
		}

		/// <summary>
		/// Boolean IsRightToLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsRightToLeft;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsRightToLeft
		{
			get
			{
				if(r_PIsRightToLeft == null)
				{
					r_PIsRightToLeft = new(this, "IsRightToLeft", -1);
					r_PIsRightToLeft.SetBelong(this.instance);
				}
				return r_PIsRightToLeft;
			}
		}

		/// <summary>
		/// System.String SLIST
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PSLIST;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPSLIST
		{
			get
			{
				if(r_PSLIST == null)
				{
					r_PSLIST = new(this, "SLIST", -1);
					r_PSLIST.SetBelong(this.instance);
				}
				return r_PSLIST;
			}
		}

		/// <summary>
		/// Boolean UseUserOverride
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PUseUserOverride;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPUseUserOverride
		{
			get
			{
				if(r_PUseUserOverride == null)
				{
					r_PUseUserOverride = new(this, "UseUserOverride", -1);
					r_PUseUserOverride.SetBelong(this.instance);
				}
				return r_PUseUserOverride;
			}
		}

		/// <summary>
		/// System.Globalization.CultureData GetCultureData(System.String, Boolean)
		/// </summary>
		protected static RMethod r_MGetCultureData_String_Boolean;
		public static RMethod RMGetCultureData_String_Boolean
		{
			get
			{
				if(r_MGetCultureData_String_Boolean == null)
				{
					r_MGetCultureData_String_Boolean = new( ReflectionUtils.GetType("System.Globalization.CultureData"), "GetCultureData", 0, typeof(System.String), typeof(System.Boolean));
					r_MGetCultureData_String_Boolean.SetBelong(null);
				}
				return r_MGetCultureData_String_Boolean;
			}
		}

		/// <summary>
		/// System.Globalization.CultureData GetCultureData(System.String, Boolean, Int32, Int32, Int32, System.String, Int32, Int32, Int32, Int32, Boolean, System.String)
		/// </summary>
		protected static RMethod r_MGetCultureData_String_Boolean_Int32_Int32_Int32_String_Int32_Int32_Int32_Int32_Boolean_String;
		public static RMethod RMGetCultureData_String_Boolean_Int32_Int32_Int32_String_Int32_Int32_Int32_Int32_Boolean_String
		{
			get
			{
				if(r_MGetCultureData_String_Boolean_Int32_Int32_Int32_String_Int32_Int32_Int32_Int32_Boolean_String == null)
				{
					r_MGetCultureData_String_Boolean_Int32_Int32_Int32_String_Int32_Int32_Int32_Int32_Boolean_String = new( ReflectionUtils.GetType("System.Globalization.CultureData"), "GetCultureData", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.String));
					r_MGetCultureData_String_Boolean_Int32_Int32_Int32_String_Int32_Int32_Int32_Int32_Boolean_String.SetBelong(null);
				}
				return r_MGetCultureData_String_Boolean_Int32_Int32_Int32_String_Int32_Int32_Int32_Int32_Boolean_String;
			}
		}

		/// <summary>
		/// System.Globalization.CultureData GetCultureData(Int32, Boolean)
		/// </summary>
		protected static RMethod r_MGetCultureData_Int32_Boolean;
		public static RMethod RMGetCultureData_Int32_Boolean
		{
			get
			{
				if(r_MGetCultureData_Int32_Boolean == null)
				{
					r_MGetCultureData_Int32_Boolean = new( ReflectionUtils.GetType("System.Globalization.CultureData"), "GetCultureData", 0, typeof(System.Int32), typeof(System.Boolean));
					r_MGetCultureData_Int32_Boolean.SetBelong(null);
				}
				return r_MGetCultureData_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void fill_culture_data(Int32)
		/// </summary>
		protected RMethod r_Mfill_culture_data_Int32;
		public virtual RMethod RMfill_culture_data_Int32
		{
			get
			{
				if(r_Mfill_culture_data_Int32 == null)
				{
					r_Mfill_culture_data_Int32 = new(this, "fill_culture_data", 0, typeof(System.Int32));
					r_Mfill_culture_data_Int32.SetBelong(this.instance);
				}
				return r_Mfill_culture_data_Int32;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarData GetCalendar(Int32)
		/// </summary>
		protected RMethod r_MGetCalendar_Int32;
		public virtual RMethod RMGetCalendar_Int32
		{
			get
			{
				if(r_MGetCalendar_Int32 == null)
				{
					r_MGetCalendar_Int32 = new(this, "GetCalendar", 0, typeof(System.Int32));
					r_MGetCalendar_Int32.SetBelong(this.instance);
				}
				return r_MGetCalendar_Int32;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarId[] GetCalendarIds()
		/// </summary>
		protected RMethod r_MGetCalendarIds;
		public virtual RMethod RMGetCalendarIds
		{
			get
			{
				if(r_MGetCalendarIds == null)
				{
					r_MGetCalendarIds = new(this, "GetCalendarIds", 0);
					r_MGetCalendarIds.SetBelong(this.instance);
				}
				return r_MGetCalendarIds;
			}
		}

		/// <summary>
		/// System.String CalendarName(Int32)
		/// </summary>
		protected RMethod r_MCalendarName_Int32;
		public virtual RMethod RMCalendarName_Int32
		{
			get
			{
				if(r_MCalendarName_Int32 == null)
				{
					r_MCalendarName_Int32 = new(this, "CalendarName", 0, typeof(System.Int32));
					r_MCalendarName_Int32.SetBelong(this.instance);
				}
				return r_MCalendarName_Int32;
			}
		}

		/// <summary>
		/// System.String[] EraNames(Int32)
		/// </summary>
		protected RMethod r_MEraNames_Int32;
		public virtual RMethod RMEraNames_Int32
		{
			get
			{
				if(r_MEraNames_Int32 == null)
				{
					r_MEraNames_Int32 = new(this, "EraNames", 0, typeof(System.Int32));
					r_MEraNames_Int32.SetBelong(this.instance);
				}
				return r_MEraNames_Int32;
			}
		}

		/// <summary>
		/// System.String[] AbbrevEraNames(Int32)
		/// </summary>
		protected RMethod r_MAbbrevEraNames_Int32;
		public virtual RMethod RMAbbrevEraNames_Int32
		{
			get
			{
				if(r_MAbbrevEraNames_Int32 == null)
				{
					r_MAbbrevEraNames_Int32 = new(this, "AbbrevEraNames", 0, typeof(System.Int32));
					r_MAbbrevEraNames_Int32.SetBelong(this.instance);
				}
				return r_MAbbrevEraNames_Int32;
			}
		}

		/// <summary>
		/// System.String[] AbbreviatedEnglishEraNames(Int32)
		/// </summary>
		protected RMethod r_MAbbreviatedEnglishEraNames_Int32;
		public virtual RMethod RMAbbreviatedEnglishEraNames_Int32
		{
			get
			{
				if(r_MAbbreviatedEnglishEraNames_Int32 == null)
				{
					r_MAbbreviatedEnglishEraNames_Int32 = new(this, "AbbreviatedEnglishEraNames", 0, typeof(System.Int32));
					r_MAbbreviatedEnglishEraNames_Int32.SetBelong(this.instance);
				}
				return r_MAbbreviatedEnglishEraNames_Int32;
			}
		}

		/// <summary>
		/// System.String[] ShortDates(Int32)
		/// </summary>
		protected RMethod r_MShortDates_Int32;
		public virtual RMethod RMShortDates_Int32
		{
			get
			{
				if(r_MShortDates_Int32 == null)
				{
					r_MShortDates_Int32 = new(this, "ShortDates", 0, typeof(System.Int32));
					r_MShortDates_Int32.SetBelong(this.instance);
				}
				return r_MShortDates_Int32;
			}
		}

		/// <summary>
		/// System.String[] LongDates(Int32)
		/// </summary>
		protected RMethod r_MLongDates_Int32;
		public virtual RMethod RMLongDates_Int32
		{
			get
			{
				if(r_MLongDates_Int32 == null)
				{
					r_MLongDates_Int32 = new(this, "LongDates", 0, typeof(System.Int32));
					r_MLongDates_Int32.SetBelong(this.instance);
				}
				return r_MLongDates_Int32;
			}
		}

		/// <summary>
		/// System.String[] YearMonths(Int32)
		/// </summary>
		protected RMethod r_MYearMonths_Int32;
		public virtual RMethod RMYearMonths_Int32
		{
			get
			{
				if(r_MYearMonths_Int32 == null)
				{
					r_MYearMonths_Int32 = new(this, "YearMonths", 0, typeof(System.Int32));
					r_MYearMonths_Int32.SetBelong(this.instance);
				}
				return r_MYearMonths_Int32;
			}
		}

		/// <summary>
		/// System.String[] DayNames(Int32)
		/// </summary>
		protected RMethod r_MDayNames_Int32;
		public virtual RMethod RMDayNames_Int32
		{
			get
			{
				if(r_MDayNames_Int32 == null)
				{
					r_MDayNames_Int32 = new(this, "DayNames", 0, typeof(System.Int32));
					r_MDayNames_Int32.SetBelong(this.instance);
				}
				return r_MDayNames_Int32;
			}
		}

		/// <summary>
		/// System.String[] AbbreviatedDayNames(Int32)
		/// </summary>
		protected RMethod r_MAbbreviatedDayNames_Int32;
		public virtual RMethod RMAbbreviatedDayNames_Int32
		{
			get
			{
				if(r_MAbbreviatedDayNames_Int32 == null)
				{
					r_MAbbreviatedDayNames_Int32 = new(this, "AbbreviatedDayNames", 0, typeof(System.Int32));
					r_MAbbreviatedDayNames_Int32.SetBelong(this.instance);
				}
				return r_MAbbreviatedDayNames_Int32;
			}
		}

		/// <summary>
		/// System.String[] SuperShortDayNames(Int32)
		/// </summary>
		protected RMethod r_MSuperShortDayNames_Int32;
		public virtual RMethod RMSuperShortDayNames_Int32
		{
			get
			{
				if(r_MSuperShortDayNames_Int32 == null)
				{
					r_MSuperShortDayNames_Int32 = new(this, "SuperShortDayNames", 0, typeof(System.Int32));
					r_MSuperShortDayNames_Int32.SetBelong(this.instance);
				}
				return r_MSuperShortDayNames_Int32;
			}
		}

		/// <summary>
		/// System.String[] MonthNames(Int32)
		/// </summary>
		protected RMethod r_MMonthNames_Int32;
		public virtual RMethod RMMonthNames_Int32
		{
			get
			{
				if(r_MMonthNames_Int32 == null)
				{
					r_MMonthNames_Int32 = new(this, "MonthNames", 0, typeof(System.Int32));
					r_MMonthNames_Int32.SetBelong(this.instance);
				}
				return r_MMonthNames_Int32;
			}
		}

		/// <summary>
		/// System.String[] GenitiveMonthNames(Int32)
		/// </summary>
		protected RMethod r_MGenitiveMonthNames_Int32;
		public virtual RMethod RMGenitiveMonthNames_Int32
		{
			get
			{
				if(r_MGenitiveMonthNames_Int32 == null)
				{
					r_MGenitiveMonthNames_Int32 = new(this, "GenitiveMonthNames", 0, typeof(System.Int32));
					r_MGenitiveMonthNames_Int32.SetBelong(this.instance);
				}
				return r_MGenitiveMonthNames_Int32;
			}
		}

		/// <summary>
		/// System.String[] AbbreviatedMonthNames(Int32)
		/// </summary>
		protected RMethod r_MAbbreviatedMonthNames_Int32;
		public virtual RMethod RMAbbreviatedMonthNames_Int32
		{
			get
			{
				if(r_MAbbreviatedMonthNames_Int32 == null)
				{
					r_MAbbreviatedMonthNames_Int32 = new(this, "AbbreviatedMonthNames", 0, typeof(System.Int32));
					r_MAbbreviatedMonthNames_Int32.SetBelong(this.instance);
				}
				return r_MAbbreviatedMonthNames_Int32;
			}
		}

		/// <summary>
		/// System.String[] AbbreviatedGenitiveMonthNames(Int32)
		/// </summary>
		protected RMethod r_MAbbreviatedGenitiveMonthNames_Int32;
		public virtual RMethod RMAbbreviatedGenitiveMonthNames_Int32
		{
			get
			{
				if(r_MAbbreviatedGenitiveMonthNames_Int32 == null)
				{
					r_MAbbreviatedGenitiveMonthNames_Int32 = new(this, "AbbreviatedGenitiveMonthNames", 0, typeof(System.Int32));
					r_MAbbreviatedGenitiveMonthNames_Int32.SetBelong(this.instance);
				}
				return r_MAbbreviatedGenitiveMonthNames_Int32;
			}
		}

		/// <summary>
		/// System.String[] LeapYearMonthNames(Int32)
		/// </summary>
		protected RMethod r_MLeapYearMonthNames_Int32;
		public virtual RMethod RMLeapYearMonthNames_Int32
		{
			get
			{
				if(r_MLeapYearMonthNames_Int32 == null)
				{
					r_MLeapYearMonthNames_Int32 = new(this, "LeapYearMonthNames", 0, typeof(System.Int32));
					r_MLeapYearMonthNames_Int32.SetBelong(this.instance);
				}
				return r_MLeapYearMonthNames_Int32;
			}
		}

		/// <summary>
		/// System.String MonthDay(Int32)
		/// </summary>
		protected RMethod r_MMonthDay_Int32;
		public virtual RMethod RMMonthDay_Int32
		{
			get
			{
				if(r_MMonthDay_Int32 == null)
				{
					r_MMonthDay_Int32 = new(this, "MonthDay", 0, typeof(System.Int32));
					r_MMonthDay_Int32.SetBelong(this.instance);
				}
				return r_MMonthDay_Int32;
			}
		}

		/// <summary>
		/// System.String DateSeparator(Int32)
		/// </summary>
		protected RMethod r_MDateSeparator_Int32;
		public virtual RMethod RMDateSeparator_Int32
		{
			get
			{
				if(r_MDateSeparator_Int32 == null)
				{
					r_MDateSeparator_Int32 = new(this, "DateSeparator", 0, typeof(System.Int32));
					r_MDateSeparator_Int32.SetBelong(this.instance);
				}
				return r_MDateSeparator_Int32;
			}
		}

		/// <summary>
		/// System.String GetDateSeparator(System.String)
		/// </summary>
		protected static RMethod r_MGetDateSeparator_String;
		public static RMethod RMGetDateSeparator_String
		{
			get
			{
				if(r_MGetDateSeparator_String == null)
				{
					r_MGetDateSeparator_String = new( ReflectionUtils.GetType("System.Globalization.CultureData"), "GetDateSeparator", 0, typeof(System.String));
					r_MGetDateSeparator_String.SetBelong(null);
				}
				return r_MGetDateSeparator_String;
			}
		}

		/// <summary>
		/// System.String GetSeparator(System.String, System.String)
		/// </summary>
		protected static RMethod r_MGetSeparator_String_String;
		public static RMethod RMGetSeparator_String_String
		{
			get
			{
				if(r_MGetSeparator_String_String == null)
				{
					r_MGetSeparator_String_String = new( ReflectionUtils.GetType("System.Globalization.CultureData"), "GetSeparator", 0, typeof(System.String), typeof(System.String));
					r_MGetSeparator_String_String.SetBelong(null);
				}
				return r_MGetSeparator_String_String;
			}
		}

		/// <summary>
		/// Int32 IndexOfTimePart(System.String, Int32, System.String)
		/// </summary>
		protected static RMethod r_MIndexOfTimePart_String_Int32_String;
		public static RMethod RMIndexOfTimePart_String_Int32_String
		{
			get
			{
				if(r_MIndexOfTimePart_String_Int32_String == null)
				{
					r_MIndexOfTimePart_String_Int32_String = new( ReflectionUtils.GetType("System.Globalization.CultureData"), "IndexOfTimePart", 0, typeof(System.String), typeof(System.Int32), typeof(System.String));
					r_MIndexOfTimePart_String_Int32_String.SetBelong(null);
				}
				return r_MIndexOfTimePart_String_Int32_String;
			}
		}

		/// <summary>
		/// System.String UnescapeNlsString(System.String, Int32, Int32)
		/// </summary>
		protected static RMethod r_MUnescapeNlsString_String_Int32_Int32;
		public static RMethod RMUnescapeNlsString_String_Int32_Int32
		{
			get
			{
				if(r_MUnescapeNlsString_String_Int32_Int32 == null)
				{
					r_MUnescapeNlsString_String_Int32_Int32 = new( ReflectionUtils.GetType("System.Globalization.CultureData"), "UnescapeNlsString", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_MUnescapeNlsString_String_Int32_Int32.SetBelong(null);
				}
				return r_MUnescapeNlsString_String_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String[] ReescapeWin32Strings(System.String[])
		/// </summary>
		protected static RMethod r_MReescapeWin32Strings_StringArray;
		public static RMethod RMReescapeWin32Strings_StringArray
		{
			get
			{
				if(r_MReescapeWin32Strings_StringArray == null)
				{
					r_MReescapeWin32Strings_StringArray = new( ReflectionUtils.GetType("System.Globalization.CultureData"), "ReescapeWin32Strings", 0, typeof(System.String).MakeArrayType());
					r_MReescapeWin32Strings_StringArray.SetBelong(null);
				}
				return r_MReescapeWin32Strings_StringArray;
			}
		}

		/// <summary>
		/// System.String ReescapeWin32String(System.String)
		/// </summary>
		protected static RMethod r_MReescapeWin32String_String;
		public static RMethod RMReescapeWin32String_String
		{
			get
			{
				if(r_MReescapeWin32String_String == null)
				{
					r_MReescapeWin32String_String = new( ReflectionUtils.GetType("System.Globalization.CultureData"), "ReescapeWin32String", 0, typeof(System.String));
					r_MReescapeWin32String_String.SetBelong(null);
				}
				return r_MReescapeWin32String_String;
			}
		}

		/// <summary>
		/// Boolean IsCustomCultureId(Int32)
		/// </summary>
		protected static RMethod r_MIsCustomCultureId_Int32;
		public static RMethod RMIsCustomCultureId_Int32
		{
			get
			{
				if(r_MIsCustomCultureId_Int32 == null)
				{
					r_MIsCustomCultureId_Int32 = new( ReflectionUtils.GetType("System.Globalization.CultureData"), "IsCustomCultureId", 0, typeof(System.Int32));
					r_MIsCustomCultureId_Int32.SetBelong(null);
				}
				return r_MIsCustomCultureId_Int32;
			}
		}

		/// <summary>
		/// Int32 strlen(Byte*)
		/// </summary>
		protected static RMethod r_Mstrlen_BytePointer;
		public static RMethod RMstrlen_BytePointer
		{
			get
			{
				if(r_Mstrlen_BytePointer == null)
				{
					r_Mstrlen_BytePointer = new( ReflectionUtils.GetType("System.Globalization.CultureData"), "strlen", 0, typeof(System.Byte).MakePointerType());
					r_Mstrlen_BytePointer.SetBelong(null);
				}
				return r_Mstrlen_BytePointer;
			}
		}

		/// <summary>
		/// System.String idx2string(Byte*, Int32)
		/// </summary>
		protected static RMethod r_Midx2string_BytePointer_Int32;
		public static RMethod RMidx2string_BytePointer_Int32
		{
			get
			{
				if(r_Midx2string_BytePointer_Int32 == null)
				{
					r_Midx2string_BytePointer_Int32 = new( ReflectionUtils.GetType("System.Globalization.CultureData"), "idx2string", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_Midx2string_BytePointer_Int32.SetBelong(null);
				}
				return r_Midx2string_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Int32[] create_group_sizes_array(Int32, Int32)
		/// </summary>
		protected RMethod r_Mcreate_group_sizes_array_Int32_Int32;
		public virtual RMethod RMcreate_group_sizes_array_Int32_Int32
		{
			get
			{
				if(r_Mcreate_group_sizes_array_Int32_Int32 == null)
				{
					r_Mcreate_group_sizes_array_Int32_Int32 = new(this, "create_group_sizes_array", 0, typeof(System.Int32), typeof(System.Int32));
					r_Mcreate_group_sizes_array_Int32_Int32.SetBelong(this.instance);
				}
				return r_Mcreate_group_sizes_array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void GetNFIValues(System.Globalization.NumberFormatInfo)
		/// </summary>
		protected RMethod r_MGetNFIValues_NumberFormatInfo;
		public virtual RMethod RMGetNFIValues_NumberFormatInfo
		{
			get
			{
				if(r_MGetNFIValues_NumberFormatInfo == null)
				{
					r_MGetNFIValues_NumberFormatInfo = new(this, "GetNFIValues", 0, typeof(System.Globalization.NumberFormatInfo));
					r_MGetNFIValues_NumberFormatInfo.SetBelong(this.instance);
				}
				return r_MGetNFIValues_NumberFormatInfo;
			}
		}

		/// <summary>
		/// Byte* fill_number_data(Int32, NumberFormatEntryManaged ByRef)
		/// </summary>
		protected static RMethod r_Mfill_number_data_Int32_Ref_NumberFormatEntryManaged;
		public static RMethod RMfill_number_data_Int32_Ref_NumberFormatEntryManaged
		{
			get
			{
				if(r_Mfill_number_data_Int32_Ref_NumberFormatEntryManaged == null)
				{
					r_Mfill_number_data_Int32_Ref_NumberFormatEntryManaged = new( ReflectionUtils.GetType("System.Globalization.CultureData"), "fill_number_data", 0, typeof(System.Int32),  ReflectionUtils.GetType("System.Globalization.CultureData+NumberFormatEntryManaged").MakeByRefType());
					r_Mfill_number_data_Int32_Ref_NumberFormatEntryManaged.SetBelong(null);
				}
				return r_Mfill_number_data_Int32_Ref_NumberFormatEntryManaged;
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

        public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureData GetCultureData(System.String @cultureName, System.Boolean @useUserOverride)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cultureName, @useUserOverride};
            var ___result = RMGetCultureData_String_Boolean.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureData(___result);
        }


        public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureData GetCultureData(System.String @cultureName, System.Boolean @useUserOverride, System.Int32 @datetimeIndex, System.Int32 @calendarId, System.Int32 @numberIndex, System.String @iso2lang, System.Int32 @ansiCodePage, System.Int32 @oemCodePage, System.Int32 @macCodePage, System.Int32 @ebcdicCodePage, System.Boolean @rightToLeft, System.String @listSeparator)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cultureName, @useUserOverride, @datetimeIndex, @calendarId, @numberIndex, @iso2lang, @ansiCodePage, @oemCodePage, @macCodePage, @ebcdicCodePage, @rightToLeft, @listSeparator};
            var ___result = RMGetCultureData_String_Boolean_Int32_Int32_Int32_String_Int32_Int32_Int32_Int32_Boolean_String.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureData(___result);
        }


        public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureData GetCultureData(System.Int32 @culture, System.Boolean @bUseUserOverride)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@culture, @bUseUserOverride};
            var ___result = RMGetCultureData_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureData(___result);
        }


        public virtual void fill_culture_data(System.Int32 @datetimeIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@datetimeIndex};
            var ___result = RMfill_culture_data_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarData GetCalendar(System.Int32 @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RMGetCalendar_Int32.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarData(___result);
        }


        public virtual Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId> GetCalendarIds()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCalendarIds.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId>(___result);
        }


        public virtual System.String CalendarName(System.Int32 @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RMCalendarName_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String[] EraNames(System.Int32 @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RMEraNames_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] AbbrevEraNames(System.Int32 @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RMAbbrevEraNames_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] AbbreviatedEnglishEraNames(System.Int32 @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RMAbbreviatedEnglishEraNames_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] ShortDates(System.Int32 @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RMShortDates_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] LongDates(System.Int32 @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RMLongDates_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] YearMonths(System.Int32 @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RMYearMonths_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] DayNames(System.Int32 @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RMDayNames_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] AbbreviatedDayNames(System.Int32 @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RMAbbreviatedDayNames_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] SuperShortDayNames(System.Int32 @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RMSuperShortDayNames_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] MonthNames(System.Int32 @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RMMonthNames_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] GenitiveMonthNames(System.Int32 @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RMGenitiveMonthNames_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] AbbreviatedMonthNames(System.Int32 @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RMAbbreviatedMonthNames_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] AbbreviatedGenitiveMonthNames(System.Int32 @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RMAbbreviatedGenitiveMonthNames_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] LeapYearMonthNames(System.Int32 @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RMLeapYearMonthNames_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String MonthDay(System.Int32 @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RMMonthDay_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String DateSeparator(System.Int32 @calendarId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarId};
            var ___result = RMDateSeparator_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String GetDateSeparator(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMGetDateSeparator_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String GetSeparator(System.String @format, System.String @timeParts)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @timeParts};
            var ___result = RMGetSeparator_String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Int32 IndexOfTimePart(System.String @format, System.Int32 @startIndex, System.String @timeParts)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @startIndex, @timeParts};
            var ___result = RMIndexOfTimePart_String_Int32_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.String UnescapeNlsString(System.String @str, System.Int32 @start, System.Int32 @end)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str, @start, @end};
            var ___result = RMUnescapeNlsString_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String[] ReescapeWin32Strings(System.String[] @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array};
            var ___result = RMReescapeWin32Strings_StringArray.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public static System.String ReescapeWin32String(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RMReescapeWin32String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Boolean IsCustomCultureId(System.Int32 @cultureId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cultureId};
            var ___result = RMIsCustomCultureId_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public unsafe static System.Int32 strlen(System.Byte* @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@s, typeof(System.Byte))};
            var ___result = RMstrlen_BytePointer.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe static System.String idx2string(System.Byte* @data, System.Int32 @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@data, typeof(System.Byte)), @idx};
            var ___result = RMidx2string_BytePointer_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32[] create_group_sizes_array(System.Int32 @gs0, System.Int32 @gs1)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@gs0, @gs1};
            var ___result = RMcreate_group_sizes_array_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32[])___result;
        }


        public virtual void GetNFIValues(System.Globalization.NumberFormatInfo @nfi)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nfi};
            var ___result = RMGetNFIValues_NumberFormatInfo.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe static System.Byte* fill_number_data(System.Int32 @index, ref Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureData.RNumberFormatEntryManaged @nfe)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @nfe.Value};
            var ___result = RMfill_number_data_Int32_Ref_NumberFormatEntryManaged.Invoke(___genericsType, ___parameters);
			@nfe = new Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureData.RNumberFormatEntryManaged(___parameters[1]);

            return (System.Byte*)Pointer.Unbox(___result);
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
