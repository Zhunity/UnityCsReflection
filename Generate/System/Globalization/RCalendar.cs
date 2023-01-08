using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RGlobalization
{
	/// <summary>
	/// System.Globalization.Calendar
	/// </summary>
    public partial class RCalendar : RMember //
    {

		/// <summary>
		/// System.Int64 TicksPerMillisecond
		/// </summary>
		protected static RField r_TicksPerMillisecond;
		public static RField RTicksPerMillisecond
		{
			get
			{
				if(r_TicksPerMillisecond == null)
				{
					r_TicksPerMillisecond = new(typeof(System.Globalization.Calendar), "TicksPerMillisecond");
					r_TicksPerMillisecond.SetBelong(null);
				}
				return r_TicksPerMillisecond;
			}
		}

		/// <summary>
		/// System.Int64 TicksPerSecond
		/// </summary>
		protected static RField r_TicksPerSecond;
		public static RField RTicksPerSecond
		{
			get
			{
				if(r_TicksPerSecond == null)
				{
					r_TicksPerSecond = new(typeof(System.Globalization.Calendar), "TicksPerSecond");
					r_TicksPerSecond.SetBelong(null);
				}
				return r_TicksPerSecond;
			}
		}

		/// <summary>
		/// System.Int64 TicksPerMinute
		/// </summary>
		protected static RField r_TicksPerMinute;
		public static RField RTicksPerMinute
		{
			get
			{
				if(r_TicksPerMinute == null)
				{
					r_TicksPerMinute = new(typeof(System.Globalization.Calendar), "TicksPerMinute");
					r_TicksPerMinute.SetBelong(null);
				}
				return r_TicksPerMinute;
			}
		}

		/// <summary>
		/// System.Int64 TicksPerHour
		/// </summary>
		protected static RField r_TicksPerHour;
		public static RField RTicksPerHour
		{
			get
			{
				if(r_TicksPerHour == null)
				{
					r_TicksPerHour = new(typeof(System.Globalization.Calendar), "TicksPerHour");
					r_TicksPerHour.SetBelong(null);
				}
				return r_TicksPerHour;
			}
		}

		/// <summary>
		/// System.Int64 TicksPerDay
		/// </summary>
		protected static RField r_TicksPerDay;
		public static RField RTicksPerDay
		{
			get
			{
				if(r_TicksPerDay == null)
				{
					r_TicksPerDay = new(typeof(System.Globalization.Calendar), "TicksPerDay");
					r_TicksPerDay.SetBelong(null);
				}
				return r_TicksPerDay;
			}
		}

		/// <summary>
		/// System.Int32 MillisPerSecond
		/// </summary>
		protected static RField r_MillisPerSecond;
		public static RField RMillisPerSecond
		{
			get
			{
				if(r_MillisPerSecond == null)
				{
					r_MillisPerSecond = new(typeof(System.Globalization.Calendar), "MillisPerSecond");
					r_MillisPerSecond.SetBelong(null);
				}
				return r_MillisPerSecond;
			}
		}

		/// <summary>
		/// System.Int32 MillisPerMinute
		/// </summary>
		protected static RField r_MillisPerMinute;
		public static RField RMillisPerMinute
		{
			get
			{
				if(r_MillisPerMinute == null)
				{
					r_MillisPerMinute = new(typeof(System.Globalization.Calendar), "MillisPerMinute");
					r_MillisPerMinute.SetBelong(null);
				}
				return r_MillisPerMinute;
			}
		}

		/// <summary>
		/// System.Int32 MillisPerHour
		/// </summary>
		protected static RField r_MillisPerHour;
		public static RField RMillisPerHour
		{
			get
			{
				if(r_MillisPerHour == null)
				{
					r_MillisPerHour = new(typeof(System.Globalization.Calendar), "MillisPerHour");
					r_MillisPerHour.SetBelong(null);
				}
				return r_MillisPerHour;
			}
		}

		/// <summary>
		/// System.Int32 MillisPerDay
		/// </summary>
		protected static RField r_MillisPerDay;
		public static RField RMillisPerDay
		{
			get
			{
				if(r_MillisPerDay == null)
				{
					r_MillisPerDay = new(typeof(System.Globalization.Calendar), "MillisPerDay");
					r_MillisPerDay.SetBelong(null);
				}
				return r_MillisPerDay;
			}
		}

		/// <summary>
		/// System.Int32 DaysPerYear
		/// </summary>
		protected static RField r_DaysPerYear;
		public static RField RDaysPerYear
		{
			get
			{
				if(r_DaysPerYear == null)
				{
					r_DaysPerYear = new(typeof(System.Globalization.Calendar), "DaysPerYear");
					r_DaysPerYear.SetBelong(null);
				}
				return r_DaysPerYear;
			}
		}

		/// <summary>
		/// System.Int32 DaysPer4Years
		/// </summary>
		protected static RField r_DaysPer4Years;
		public static RField RDaysPer4Years
		{
			get
			{
				if(r_DaysPer4Years == null)
				{
					r_DaysPer4Years = new(typeof(System.Globalization.Calendar), "DaysPer4Years");
					r_DaysPer4Years.SetBelong(null);
				}
				return r_DaysPer4Years;
			}
		}

		/// <summary>
		/// System.Int32 DaysPer100Years
		/// </summary>
		protected static RField r_DaysPer100Years;
		public static RField RDaysPer100Years
		{
			get
			{
				if(r_DaysPer100Years == null)
				{
					r_DaysPer100Years = new(typeof(System.Globalization.Calendar), "DaysPer100Years");
					r_DaysPer100Years.SetBelong(null);
				}
				return r_DaysPer100Years;
			}
		}

		/// <summary>
		/// System.Int32 DaysPer400Years
		/// </summary>
		protected static RField r_DaysPer400Years;
		public static RField RDaysPer400Years
		{
			get
			{
				if(r_DaysPer400Years == null)
				{
					r_DaysPer400Years = new(typeof(System.Globalization.Calendar), "DaysPer400Years");
					r_DaysPer400Years.SetBelong(null);
				}
				return r_DaysPer400Years;
			}
		}

		/// <summary>
		/// System.Int32 DaysTo10000
		/// </summary>
		protected static RField r_DaysTo10000;
		public static RField RDaysTo10000
		{
			get
			{
				if(r_DaysTo10000 == null)
				{
					r_DaysTo10000 = new(typeof(System.Globalization.Calendar), "DaysTo10000");
					r_DaysTo10000.SetBelong(null);
				}
				return r_DaysTo10000;
			}
		}

		/// <summary>
		/// System.Int64 MaxMillis
		/// </summary>
		protected static RField r_MaxMillis;
		public static RField RMaxMillis
		{
			get
			{
				if(r_MaxMillis == null)
				{
					r_MaxMillis = new(typeof(System.Globalization.Calendar), "MaxMillis");
					r_MaxMillis.SetBelong(null);
				}
				return r_MaxMillis;
			}
		}

		/// <summary>
		/// System.Int32 CAL_GREGORIAN
		/// </summary>
		protected static RField r_CAL_GREGORIAN;
		public static RField RCAL_GREGORIAN
		{
			get
			{
				if(r_CAL_GREGORIAN == null)
				{
					r_CAL_GREGORIAN = new(typeof(System.Globalization.Calendar), "CAL_GREGORIAN");
					r_CAL_GREGORIAN.SetBelong(null);
				}
				return r_CAL_GREGORIAN;
			}
		}

		/// <summary>
		/// System.Int32 CAL_GREGORIAN_US
		/// </summary>
		protected static RField r_CAL_GREGORIAN_US;
		public static RField RCAL_GREGORIAN_US
		{
			get
			{
				if(r_CAL_GREGORIAN_US == null)
				{
					r_CAL_GREGORIAN_US = new(typeof(System.Globalization.Calendar), "CAL_GREGORIAN_US");
					r_CAL_GREGORIAN_US.SetBelong(null);
				}
				return r_CAL_GREGORIAN_US;
			}
		}

		/// <summary>
		/// System.Int32 CAL_JAPAN
		/// </summary>
		protected static RField r_CAL_JAPAN;
		public static RField RCAL_JAPAN
		{
			get
			{
				if(r_CAL_JAPAN == null)
				{
					r_CAL_JAPAN = new(typeof(System.Globalization.Calendar), "CAL_JAPAN");
					r_CAL_JAPAN.SetBelong(null);
				}
				return r_CAL_JAPAN;
			}
		}

		/// <summary>
		/// System.Int32 CAL_TAIWAN
		/// </summary>
		protected static RField r_CAL_TAIWAN;
		public static RField RCAL_TAIWAN
		{
			get
			{
				if(r_CAL_TAIWAN == null)
				{
					r_CAL_TAIWAN = new(typeof(System.Globalization.Calendar), "CAL_TAIWAN");
					r_CAL_TAIWAN.SetBelong(null);
				}
				return r_CAL_TAIWAN;
			}
		}

		/// <summary>
		/// System.Int32 CAL_KOREA
		/// </summary>
		protected static RField r_CAL_KOREA;
		public static RField RCAL_KOREA
		{
			get
			{
				if(r_CAL_KOREA == null)
				{
					r_CAL_KOREA = new(typeof(System.Globalization.Calendar), "CAL_KOREA");
					r_CAL_KOREA.SetBelong(null);
				}
				return r_CAL_KOREA;
			}
		}

		/// <summary>
		/// System.Int32 CAL_HIJRI
		/// </summary>
		protected static RField r_CAL_HIJRI;
		public static RField RCAL_HIJRI
		{
			get
			{
				if(r_CAL_HIJRI == null)
				{
					r_CAL_HIJRI = new(typeof(System.Globalization.Calendar), "CAL_HIJRI");
					r_CAL_HIJRI.SetBelong(null);
				}
				return r_CAL_HIJRI;
			}
		}

		/// <summary>
		/// System.Int32 CAL_THAI
		/// </summary>
		protected static RField r_CAL_THAI;
		public static RField RCAL_THAI
		{
			get
			{
				if(r_CAL_THAI == null)
				{
					r_CAL_THAI = new(typeof(System.Globalization.Calendar), "CAL_THAI");
					r_CAL_THAI.SetBelong(null);
				}
				return r_CAL_THAI;
			}
		}

		/// <summary>
		/// System.Int32 CAL_HEBREW
		/// </summary>
		protected static RField r_CAL_HEBREW;
		public static RField RCAL_HEBREW
		{
			get
			{
				if(r_CAL_HEBREW == null)
				{
					r_CAL_HEBREW = new(typeof(System.Globalization.Calendar), "CAL_HEBREW");
					r_CAL_HEBREW.SetBelong(null);
				}
				return r_CAL_HEBREW;
			}
		}

		/// <summary>
		/// System.Int32 CAL_GREGORIAN_ME_FRENCH
		/// </summary>
		protected static RField r_CAL_GREGORIAN_ME_FRENCH;
		public static RField RCAL_GREGORIAN_ME_FRENCH
		{
			get
			{
				if(r_CAL_GREGORIAN_ME_FRENCH == null)
				{
					r_CAL_GREGORIAN_ME_FRENCH = new(typeof(System.Globalization.Calendar), "CAL_GREGORIAN_ME_FRENCH");
					r_CAL_GREGORIAN_ME_FRENCH.SetBelong(null);
				}
				return r_CAL_GREGORIAN_ME_FRENCH;
			}
		}

		/// <summary>
		/// System.Int32 CAL_GREGORIAN_ARABIC
		/// </summary>
		protected static RField r_CAL_GREGORIAN_ARABIC;
		public static RField RCAL_GREGORIAN_ARABIC
		{
			get
			{
				if(r_CAL_GREGORIAN_ARABIC == null)
				{
					r_CAL_GREGORIAN_ARABIC = new(typeof(System.Globalization.Calendar), "CAL_GREGORIAN_ARABIC");
					r_CAL_GREGORIAN_ARABIC.SetBelong(null);
				}
				return r_CAL_GREGORIAN_ARABIC;
			}
		}

		/// <summary>
		/// System.Int32 CAL_GREGORIAN_XLIT_ENGLISH
		/// </summary>
		protected static RField r_CAL_GREGORIAN_XLIT_ENGLISH;
		public static RField RCAL_GREGORIAN_XLIT_ENGLISH
		{
			get
			{
				if(r_CAL_GREGORIAN_XLIT_ENGLISH == null)
				{
					r_CAL_GREGORIAN_XLIT_ENGLISH = new(typeof(System.Globalization.Calendar), "CAL_GREGORIAN_XLIT_ENGLISH");
					r_CAL_GREGORIAN_XLIT_ENGLISH.SetBelong(null);
				}
				return r_CAL_GREGORIAN_XLIT_ENGLISH;
			}
		}

		/// <summary>
		/// System.Int32 CAL_GREGORIAN_XLIT_FRENCH
		/// </summary>
		protected static RField r_CAL_GREGORIAN_XLIT_FRENCH;
		public static RField RCAL_GREGORIAN_XLIT_FRENCH
		{
			get
			{
				if(r_CAL_GREGORIAN_XLIT_FRENCH == null)
				{
					r_CAL_GREGORIAN_XLIT_FRENCH = new(typeof(System.Globalization.Calendar), "CAL_GREGORIAN_XLIT_FRENCH");
					r_CAL_GREGORIAN_XLIT_FRENCH.SetBelong(null);
				}
				return r_CAL_GREGORIAN_XLIT_FRENCH;
			}
		}

		/// <summary>
		/// System.Int32 CAL_JULIAN
		/// </summary>
		protected static RField r_CAL_JULIAN;
		public static RField RCAL_JULIAN
		{
			get
			{
				if(r_CAL_JULIAN == null)
				{
					r_CAL_JULIAN = new(typeof(System.Globalization.Calendar), "CAL_JULIAN");
					r_CAL_JULIAN.SetBelong(null);
				}
				return r_CAL_JULIAN;
			}
		}

		/// <summary>
		/// System.Int32 CAL_JAPANESELUNISOLAR
		/// </summary>
		protected static RField r_CAL_JAPANESELUNISOLAR;
		public static RField RCAL_JAPANESELUNISOLAR
		{
			get
			{
				if(r_CAL_JAPANESELUNISOLAR == null)
				{
					r_CAL_JAPANESELUNISOLAR = new(typeof(System.Globalization.Calendar), "CAL_JAPANESELUNISOLAR");
					r_CAL_JAPANESELUNISOLAR.SetBelong(null);
				}
				return r_CAL_JAPANESELUNISOLAR;
			}
		}

		/// <summary>
		/// System.Int32 CAL_CHINESELUNISOLAR
		/// </summary>
		protected static RField r_CAL_CHINESELUNISOLAR;
		public static RField RCAL_CHINESELUNISOLAR
		{
			get
			{
				if(r_CAL_CHINESELUNISOLAR == null)
				{
					r_CAL_CHINESELUNISOLAR = new(typeof(System.Globalization.Calendar), "CAL_CHINESELUNISOLAR");
					r_CAL_CHINESELUNISOLAR.SetBelong(null);
				}
				return r_CAL_CHINESELUNISOLAR;
			}
		}

		/// <summary>
		/// System.Int32 CAL_SAKA
		/// </summary>
		protected static RField r_CAL_SAKA;
		public static RField RCAL_SAKA
		{
			get
			{
				if(r_CAL_SAKA == null)
				{
					r_CAL_SAKA = new(typeof(System.Globalization.Calendar), "CAL_SAKA");
					r_CAL_SAKA.SetBelong(null);
				}
				return r_CAL_SAKA;
			}
		}

		/// <summary>
		/// System.Int32 CAL_LUNAR_ETO_CHN
		/// </summary>
		protected static RField r_CAL_LUNAR_ETO_CHN;
		public static RField RCAL_LUNAR_ETO_CHN
		{
			get
			{
				if(r_CAL_LUNAR_ETO_CHN == null)
				{
					r_CAL_LUNAR_ETO_CHN = new(typeof(System.Globalization.Calendar), "CAL_LUNAR_ETO_CHN");
					r_CAL_LUNAR_ETO_CHN.SetBelong(null);
				}
				return r_CAL_LUNAR_ETO_CHN;
			}
		}

		/// <summary>
		/// System.Int32 CAL_LUNAR_ETO_KOR
		/// </summary>
		protected static RField r_CAL_LUNAR_ETO_KOR;
		public static RField RCAL_LUNAR_ETO_KOR
		{
			get
			{
				if(r_CAL_LUNAR_ETO_KOR == null)
				{
					r_CAL_LUNAR_ETO_KOR = new(typeof(System.Globalization.Calendar), "CAL_LUNAR_ETO_KOR");
					r_CAL_LUNAR_ETO_KOR.SetBelong(null);
				}
				return r_CAL_LUNAR_ETO_KOR;
			}
		}

		/// <summary>
		/// System.Int32 CAL_LUNAR_ETO_ROKUYOU
		/// </summary>
		protected static RField r_CAL_LUNAR_ETO_ROKUYOU;
		public static RField RCAL_LUNAR_ETO_ROKUYOU
		{
			get
			{
				if(r_CAL_LUNAR_ETO_ROKUYOU == null)
				{
					r_CAL_LUNAR_ETO_ROKUYOU = new(typeof(System.Globalization.Calendar), "CAL_LUNAR_ETO_ROKUYOU");
					r_CAL_LUNAR_ETO_ROKUYOU.SetBelong(null);
				}
				return r_CAL_LUNAR_ETO_ROKUYOU;
			}
		}

		/// <summary>
		/// System.Int32 CAL_KOREANLUNISOLAR
		/// </summary>
		protected static RField r_CAL_KOREANLUNISOLAR;
		public static RField RCAL_KOREANLUNISOLAR
		{
			get
			{
				if(r_CAL_KOREANLUNISOLAR == null)
				{
					r_CAL_KOREANLUNISOLAR = new(typeof(System.Globalization.Calendar), "CAL_KOREANLUNISOLAR");
					r_CAL_KOREANLUNISOLAR.SetBelong(null);
				}
				return r_CAL_KOREANLUNISOLAR;
			}
		}

		/// <summary>
		/// System.Int32 CAL_TAIWANLUNISOLAR
		/// </summary>
		protected static RField r_CAL_TAIWANLUNISOLAR;
		public static RField RCAL_TAIWANLUNISOLAR
		{
			get
			{
				if(r_CAL_TAIWANLUNISOLAR == null)
				{
					r_CAL_TAIWANLUNISOLAR = new(typeof(System.Globalization.Calendar), "CAL_TAIWANLUNISOLAR");
					r_CAL_TAIWANLUNISOLAR.SetBelong(null);
				}
				return r_CAL_TAIWANLUNISOLAR;
			}
		}

		/// <summary>
		/// System.Int32 CAL_PERSIAN
		/// </summary>
		protected static RField r_CAL_PERSIAN;
		public static RField RCAL_PERSIAN
		{
			get
			{
				if(r_CAL_PERSIAN == null)
				{
					r_CAL_PERSIAN = new(typeof(System.Globalization.Calendar), "CAL_PERSIAN");
					r_CAL_PERSIAN.SetBelong(null);
				}
				return r_CAL_PERSIAN;
			}
		}

		/// <summary>
		/// System.Int32 CAL_UMALQURA
		/// </summary>
		protected static RField r_CAL_UMALQURA;
		public static RField RCAL_UMALQURA
		{
			get
			{
				if(r_CAL_UMALQURA == null)
				{
					r_CAL_UMALQURA = new(typeof(System.Globalization.Calendar), "CAL_UMALQURA");
					r_CAL_UMALQURA.SetBelong(null);
				}
				return r_CAL_UMALQURA;
			}
		}

		/// <summary>
		/// System.Int32 m_currentEraValue
		/// </summary>
		protected RField r_m_currentEraValue;
		public virtual RField Rm_currentEraValue
		{
			get
			{
				if(r_m_currentEraValue == null)
				{
					r_m_currentEraValue = new(this, "m_currentEraValue");
					r_m_currentEraValue.SetBelong(this.instance);
				}
				return r_m_currentEraValue;
			}
		}

		/// <summary>
		/// System.Boolean m_isReadOnly
		/// </summary>
		protected RField r_m_isReadOnly;
		public virtual RField Rm_isReadOnly
		{
			get
			{
				if(r_m_isReadOnly == null)
				{
					r_m_isReadOnly = new(this, "m_isReadOnly");
					r_m_isReadOnly.SetBelong(this.instance);
				}
				return r_m_isReadOnly;
			}
		}

		/// <summary>
		/// System.Int32 CurrentEra
		/// </summary>
		protected static RField r_CurrentEra;
		public static RField RCurrentEra
		{
			get
			{
				if(r_CurrentEra == null)
				{
					r_CurrentEra = new(typeof(System.Globalization.Calendar), "CurrentEra");
					r_CurrentEra.SetBelong(null);
				}
				return r_CurrentEra;
			}
		}

		/// <summary>
		/// System.Int32 twoDigitYearMax
		/// </summary>
		protected RField r_twoDigitYearMax;
		public virtual RField RtwoDigitYearMax
		{
			get
			{
				if(r_twoDigitYearMax == null)
				{
					r_twoDigitYearMax = new(this, "twoDigitYearMax");
					r_twoDigitYearMax.SetBelong(this.instance);
				}
				return r_twoDigitYearMax;
			}
		}

		/// <summary>
		/// System.DateTime MinSupportedDateTime
		/// </summary>
		protected RSystem.RDateTime r_MinSupportedDateTime;
		public virtual RSystem.RDateTime RMinSupportedDateTime
		{
			get
			{
				if(r_MinSupportedDateTime == null)
				{
					r_MinSupportedDateTime = new(this, "MinSupportedDateTime", -1);
					r_MinSupportedDateTime.SetBelong(this.instance);
				}
				return r_MinSupportedDateTime;
			}
		}

		/// <summary>
		/// System.DateTime MaxSupportedDateTime
		/// </summary>
		protected RSystem.RDateTime r_MaxSupportedDateTime;
		public virtual RSystem.RDateTime RMaxSupportedDateTime
		{
			get
			{
				if(r_MaxSupportedDateTime == null)
				{
					r_MaxSupportedDateTime = new(this, "MaxSupportedDateTime", -1);
					r_MaxSupportedDateTime.SetBelong(this.instance);
				}
				return r_MaxSupportedDateTime;
			}
		}

		/// <summary>
		/// Int32 ID
		/// </summary>
		protected RProperty r_ID;
		public virtual RProperty RID
		{
			get
			{
				if(r_ID == null)
				{
					r_ID = new(this, "ID", -1);
					r_ID.SetBelong(this.instance);
				}
				return r_ID;
			}
		}

		/// <summary>
		/// Int32 BaseCalendarID
		/// </summary>
		protected RProperty r_BaseCalendarID;
		public virtual RProperty RBaseCalendarID
		{
			get
			{
				if(r_BaseCalendarID == null)
				{
					r_BaseCalendarID = new(this, "BaseCalendarID", -1);
					r_BaseCalendarID.SetBelong(this.instance);
				}
				return r_BaseCalendarID;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarAlgorithmType AlgorithmType
		/// </summary>
		protected RProperty r_AlgorithmType;
		public virtual RProperty RAlgorithmType
		{
			get
			{
				if(r_AlgorithmType == null)
				{
					r_AlgorithmType = new(this, "AlgorithmType", -1);
					r_AlgorithmType.SetBelong(this.instance);
				}
				return r_AlgorithmType;
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
		/// Int32 CurrentEraValue
		/// </summary>
		protected RProperty r_CurrentEraValue;
		public virtual RProperty RCurrentEraValue
		{
			get
			{
				if(r_CurrentEraValue == null)
				{
					r_CurrentEraValue = new(this, "CurrentEraValue", -1);
					r_CurrentEraValue.SetBelong(this.instance);
				}
				return r_CurrentEraValue;
			}
		}

		/// <summary>
		/// Int32[] Eras
		/// </summary>
		protected RPropertyArray<RProperty> r_Eras;
		public virtual RPropertyArray<RProperty> REras
		{
			get
			{
				if(r_Eras == null)
				{
					r_Eras = new(this, "Eras", -1);
					r_Eras.SetBelong(this.instance);
				}
				return r_Eras;
			}
		}

		/// <summary>
		/// Int32 DaysInYearBeforeMinSupportedYear
		/// </summary>
		protected RProperty r_DaysInYearBeforeMinSupportedYear;
		public virtual RProperty RDaysInYearBeforeMinSupportedYear
		{
			get
			{
				if(r_DaysInYearBeforeMinSupportedYear == null)
				{
					r_DaysInYearBeforeMinSupportedYear = new(this, "DaysInYearBeforeMinSupportedYear", -1);
					r_DaysInYearBeforeMinSupportedYear.SetBelong(this.instance);
				}
				return r_DaysInYearBeforeMinSupportedYear;
			}
		}

		/// <summary>
		/// Int32 TwoDigitYearMax
		/// </summary>
		protected RProperty r_TwoDigitYearMax;
		public virtual RProperty RTwoDigitYearMax
		{
			get
			{
				if(r_TwoDigitYearMax == null)
				{
					r_TwoDigitYearMax = new(this, "TwoDigitYearMax", -1);
					r_TwoDigitYearMax.SetBelong(this.instance);
				}
				return r_TwoDigitYearMax;
			}
		}

		/// <summary>
		/// System.Object Clone()
		/// </summary>
		protected RMethod r_Clone;
		public virtual RMethod RClone
		{
			get
			{
				if(r_Clone == null)
				{
					r_Clone = new(this, "Clone", 0);
					r_Clone.SetBelong(this.instance);
				}
				return r_Clone;
			}
		}

		/// <summary>
		/// System.Globalization.Calendar ReadOnly(System.Globalization.Calendar)
		/// </summary>
		protected static RMethod r_ReadOnly_Calendar;
		public static RMethod RReadOnly_Calendar
		{
			get
			{
				if(r_ReadOnly_Calendar == null)
				{
					r_ReadOnly_Calendar = new(typeof(System.Globalization.Calendar), "ReadOnly", 0, typeof(System.Globalization.Calendar));
					r_ReadOnly_Calendar.SetBelong(null);
				}
				return r_ReadOnly_Calendar;
			}
		}

		/// <summary>
		/// Void VerifyWritable()
		/// </summary>
		protected RMethod r_VerifyWritable;
		public virtual RMethod RVerifyWritable
		{
			get
			{
				if(r_VerifyWritable == null)
				{
					r_VerifyWritable = new(this, "VerifyWritable", 0);
					r_VerifyWritable.SetBelong(this.instance);
				}
				return r_VerifyWritable;
			}
		}

		/// <summary>
		/// Void SetReadOnlyState(Boolean)
		/// </summary>
		protected RMethod r_SetReadOnlyState_Boolean;
		public virtual RMethod RSetReadOnlyState_Boolean
		{
			get
			{
				if(r_SetReadOnlyState_Boolean == null)
				{
					r_SetReadOnlyState_Boolean = new(this, "SetReadOnlyState", 0, typeof(System.Boolean));
					r_SetReadOnlyState_Boolean.SetBelong(this.instance);
				}
				return r_SetReadOnlyState_Boolean;
			}
		}

		/// <summary>
		/// Void CheckAddResult(Int64, System.DateTime, System.DateTime)
		/// </summary>
		protected static RMethod r_CheckAddResult_Int64_DateTime_DateTime;
		public static RMethod RCheckAddResult_Int64_DateTime_DateTime
		{
			get
			{
				if(r_CheckAddResult_Int64_DateTime_DateTime == null)
				{
					r_CheckAddResult_Int64_DateTime_DateTime = new(typeof(System.Globalization.Calendar), "CheckAddResult", 0, typeof(System.Int64), typeof(System.DateTime), typeof(System.DateTime));
					r_CheckAddResult_Int64_DateTime_DateTime.SetBelong(null);
				}
				return r_CheckAddResult_Int64_DateTime_DateTime;
			}
		}

		/// <summary>
		/// System.DateTime Add(System.DateTime, Double, Int32)
		/// </summary>
		protected RMethod r_Add_DateTime_Double_Int32;
		public virtual RMethod RAdd_DateTime_Double_Int32
		{
			get
			{
				if(r_Add_DateTime_Double_Int32 == null)
				{
					r_Add_DateTime_Double_Int32 = new(this, "Add", 0, typeof(System.DateTime), typeof(System.Double), typeof(System.Int32));
					r_Add_DateTime_Double_Int32.SetBelong(this.instance);
				}
				return r_Add_DateTime_Double_Int32;
			}
		}

		/// <summary>
		/// System.DateTime AddMilliseconds(System.DateTime, Double)
		/// </summary>
		protected RMethod r_AddMilliseconds_DateTime_Double;
		public virtual RMethod RAddMilliseconds_DateTime_Double
		{
			get
			{
				if(r_AddMilliseconds_DateTime_Double == null)
				{
					r_AddMilliseconds_DateTime_Double = new(this, "AddMilliseconds", 0, typeof(System.DateTime), typeof(System.Double));
					r_AddMilliseconds_DateTime_Double.SetBelong(this.instance);
				}
				return r_AddMilliseconds_DateTime_Double;
			}
		}

		/// <summary>
		/// System.DateTime AddDays(System.DateTime, Int32)
		/// </summary>
		protected RMethod r_AddDays_DateTime_Int32;
		public virtual RMethod RAddDays_DateTime_Int32
		{
			get
			{
				if(r_AddDays_DateTime_Int32 == null)
				{
					r_AddDays_DateTime_Int32 = new(this, "AddDays", 0, typeof(System.DateTime), typeof(System.Int32));
					r_AddDays_DateTime_Int32.SetBelong(this.instance);
				}
				return r_AddDays_DateTime_Int32;
			}
		}

		/// <summary>
		/// System.DateTime AddHours(System.DateTime, Int32)
		/// </summary>
		protected RMethod r_AddHours_DateTime_Int32;
		public virtual RMethod RAddHours_DateTime_Int32
		{
			get
			{
				if(r_AddHours_DateTime_Int32 == null)
				{
					r_AddHours_DateTime_Int32 = new(this, "AddHours", 0, typeof(System.DateTime), typeof(System.Int32));
					r_AddHours_DateTime_Int32.SetBelong(this.instance);
				}
				return r_AddHours_DateTime_Int32;
			}
		}

		/// <summary>
		/// System.DateTime AddMinutes(System.DateTime, Int32)
		/// </summary>
		protected RMethod r_AddMinutes_DateTime_Int32;
		public virtual RMethod RAddMinutes_DateTime_Int32
		{
			get
			{
				if(r_AddMinutes_DateTime_Int32 == null)
				{
					r_AddMinutes_DateTime_Int32 = new(this, "AddMinutes", 0, typeof(System.DateTime), typeof(System.Int32));
					r_AddMinutes_DateTime_Int32.SetBelong(this.instance);
				}
				return r_AddMinutes_DateTime_Int32;
			}
		}

		/// <summary>
		/// System.DateTime AddMonths(System.DateTime, Int32)
		/// </summary>
		protected RMethod r_AddMonths_DateTime_Int32;
		public virtual RMethod RAddMonths_DateTime_Int32
		{
			get
			{
				if(r_AddMonths_DateTime_Int32 == null)
				{
					r_AddMonths_DateTime_Int32 = new(this, "AddMonths", 0, typeof(System.DateTime), typeof(System.Int32));
					r_AddMonths_DateTime_Int32.SetBelong(this.instance);
				}
				return r_AddMonths_DateTime_Int32;
			}
		}

		/// <summary>
		/// System.DateTime AddSeconds(System.DateTime, Int32)
		/// </summary>
		protected RMethod r_AddSeconds_DateTime_Int32;
		public virtual RMethod RAddSeconds_DateTime_Int32
		{
			get
			{
				if(r_AddSeconds_DateTime_Int32 == null)
				{
					r_AddSeconds_DateTime_Int32 = new(this, "AddSeconds", 0, typeof(System.DateTime), typeof(System.Int32));
					r_AddSeconds_DateTime_Int32.SetBelong(this.instance);
				}
				return r_AddSeconds_DateTime_Int32;
			}
		}

		/// <summary>
		/// System.DateTime AddWeeks(System.DateTime, Int32)
		/// </summary>
		protected RMethod r_AddWeeks_DateTime_Int32;
		public virtual RMethod RAddWeeks_DateTime_Int32
		{
			get
			{
				if(r_AddWeeks_DateTime_Int32 == null)
				{
					r_AddWeeks_DateTime_Int32 = new(this, "AddWeeks", 0, typeof(System.DateTime), typeof(System.Int32));
					r_AddWeeks_DateTime_Int32.SetBelong(this.instance);
				}
				return r_AddWeeks_DateTime_Int32;
			}
		}

		/// <summary>
		/// System.DateTime AddYears(System.DateTime, Int32)
		/// </summary>
		protected RMethod r_AddYears_DateTime_Int32;
		public virtual RMethod RAddYears_DateTime_Int32
		{
			get
			{
				if(r_AddYears_DateTime_Int32 == null)
				{
					r_AddYears_DateTime_Int32 = new(this, "AddYears", 0, typeof(System.DateTime), typeof(System.Int32));
					r_AddYears_DateTime_Int32.SetBelong(this.instance);
				}
				return r_AddYears_DateTime_Int32;
			}
		}

		/// <summary>
		/// Int32 GetDayOfMonth(System.DateTime)
		/// </summary>
		protected RMethod r_GetDayOfMonth_DateTime;
		public virtual RMethod RGetDayOfMonth_DateTime
		{
			get
			{
				if(r_GetDayOfMonth_DateTime == null)
				{
					r_GetDayOfMonth_DateTime = new(this, "GetDayOfMonth", 0, typeof(System.DateTime));
					r_GetDayOfMonth_DateTime.SetBelong(this.instance);
				}
				return r_GetDayOfMonth_DateTime;
			}
		}

		/// <summary>
		/// System.DayOfWeek GetDayOfWeek(System.DateTime)
		/// </summary>
		protected RMethod r_GetDayOfWeek_DateTime;
		public virtual RMethod RGetDayOfWeek_DateTime
		{
			get
			{
				if(r_GetDayOfWeek_DateTime == null)
				{
					r_GetDayOfWeek_DateTime = new(this, "GetDayOfWeek", 0, typeof(System.DateTime));
					r_GetDayOfWeek_DateTime.SetBelong(this.instance);
				}
				return r_GetDayOfWeek_DateTime;
			}
		}

		/// <summary>
		/// Int32 GetDayOfYear(System.DateTime)
		/// </summary>
		protected RMethod r_GetDayOfYear_DateTime;
		public virtual RMethod RGetDayOfYear_DateTime
		{
			get
			{
				if(r_GetDayOfYear_DateTime == null)
				{
					r_GetDayOfYear_DateTime = new(this, "GetDayOfYear", 0, typeof(System.DateTime));
					r_GetDayOfYear_DateTime.SetBelong(this.instance);
				}
				return r_GetDayOfYear_DateTime;
			}
		}

		/// <summary>
		/// Int32 GetDaysInMonth(Int32, Int32)
		/// </summary>
		protected RMethod r_GetDaysInMonth_Int32_Int32;
		public virtual RMethod RGetDaysInMonth_Int32_Int32
		{
			get
			{
				if(r_GetDaysInMonth_Int32_Int32 == null)
				{
					r_GetDaysInMonth_Int32_Int32 = new(this, "GetDaysInMonth", 0, typeof(System.Int32), typeof(System.Int32));
					r_GetDaysInMonth_Int32_Int32.SetBelong(this.instance);
				}
				return r_GetDaysInMonth_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetDaysInMonth(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_GetDaysInMonth_Int32_Int32_Int32;
		public virtual RMethod RGetDaysInMonth_Int32_Int32_Int32
		{
			get
			{
				if(r_GetDaysInMonth_Int32_Int32_Int32 == null)
				{
					r_GetDaysInMonth_Int32_Int32_Int32 = new(this, "GetDaysInMonth", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_GetDaysInMonth_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_GetDaysInMonth_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetDaysInYear(Int32)
		/// </summary>
		protected RMethod r_GetDaysInYear_Int32;
		public virtual RMethod RGetDaysInYear_Int32
		{
			get
			{
				if(r_GetDaysInYear_Int32 == null)
				{
					r_GetDaysInYear_Int32 = new(this, "GetDaysInYear", 0, typeof(System.Int32));
					r_GetDaysInYear_Int32.SetBelong(this.instance);
				}
				return r_GetDaysInYear_Int32;
			}
		}

		/// <summary>
		/// Int32 GetDaysInYear(Int32, Int32)
		/// </summary>
		protected RMethod r_GetDaysInYear_Int32_Int32;
		public virtual RMethod RGetDaysInYear_Int32_Int32
		{
			get
			{
				if(r_GetDaysInYear_Int32_Int32 == null)
				{
					r_GetDaysInYear_Int32_Int32 = new(this, "GetDaysInYear", 0, typeof(System.Int32), typeof(System.Int32));
					r_GetDaysInYear_Int32_Int32.SetBelong(this.instance);
				}
				return r_GetDaysInYear_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetEra(System.DateTime)
		/// </summary>
		protected RMethod r_GetEra_DateTime;
		public virtual RMethod RGetEra_DateTime
		{
			get
			{
				if(r_GetEra_DateTime == null)
				{
					r_GetEra_DateTime = new(this, "GetEra", 0, typeof(System.DateTime));
					r_GetEra_DateTime.SetBelong(this.instance);
				}
				return r_GetEra_DateTime;
			}
		}

		/// <summary>
		/// Int32 GetHour(System.DateTime)
		/// </summary>
		protected RMethod r_GetHour_DateTime;
		public virtual RMethod RGetHour_DateTime
		{
			get
			{
				if(r_GetHour_DateTime == null)
				{
					r_GetHour_DateTime = new(this, "GetHour", 0, typeof(System.DateTime));
					r_GetHour_DateTime.SetBelong(this.instance);
				}
				return r_GetHour_DateTime;
			}
		}

		/// <summary>
		/// Double GetMilliseconds(System.DateTime)
		/// </summary>
		protected RMethod r_GetMilliseconds_DateTime;
		public virtual RMethod RGetMilliseconds_DateTime
		{
			get
			{
				if(r_GetMilliseconds_DateTime == null)
				{
					r_GetMilliseconds_DateTime = new(this, "GetMilliseconds", 0, typeof(System.DateTime));
					r_GetMilliseconds_DateTime.SetBelong(this.instance);
				}
				return r_GetMilliseconds_DateTime;
			}
		}

		/// <summary>
		/// Int32 GetMinute(System.DateTime)
		/// </summary>
		protected RMethod r_GetMinute_DateTime;
		public virtual RMethod RGetMinute_DateTime
		{
			get
			{
				if(r_GetMinute_DateTime == null)
				{
					r_GetMinute_DateTime = new(this, "GetMinute", 0, typeof(System.DateTime));
					r_GetMinute_DateTime.SetBelong(this.instance);
				}
				return r_GetMinute_DateTime;
			}
		}

		/// <summary>
		/// Int32 GetMonth(System.DateTime)
		/// </summary>
		protected RMethod r_GetMonth_DateTime;
		public virtual RMethod RGetMonth_DateTime
		{
			get
			{
				if(r_GetMonth_DateTime == null)
				{
					r_GetMonth_DateTime = new(this, "GetMonth", 0, typeof(System.DateTime));
					r_GetMonth_DateTime.SetBelong(this.instance);
				}
				return r_GetMonth_DateTime;
			}
		}

		/// <summary>
		/// Int32 GetMonthsInYear(Int32)
		/// </summary>
		protected RMethod r_GetMonthsInYear_Int32;
		public virtual RMethod RGetMonthsInYear_Int32
		{
			get
			{
				if(r_GetMonthsInYear_Int32 == null)
				{
					r_GetMonthsInYear_Int32 = new(this, "GetMonthsInYear", 0, typeof(System.Int32));
					r_GetMonthsInYear_Int32.SetBelong(this.instance);
				}
				return r_GetMonthsInYear_Int32;
			}
		}

		/// <summary>
		/// Int32 GetMonthsInYear(Int32, Int32)
		/// </summary>
		protected RMethod r_GetMonthsInYear_Int32_Int32;
		public virtual RMethod RGetMonthsInYear_Int32_Int32
		{
			get
			{
				if(r_GetMonthsInYear_Int32_Int32 == null)
				{
					r_GetMonthsInYear_Int32_Int32 = new(this, "GetMonthsInYear", 0, typeof(System.Int32), typeof(System.Int32));
					r_GetMonthsInYear_Int32_Int32.SetBelong(this.instance);
				}
				return r_GetMonthsInYear_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetSecond(System.DateTime)
		/// </summary>
		protected RMethod r_GetSecond_DateTime;
		public virtual RMethod RGetSecond_DateTime
		{
			get
			{
				if(r_GetSecond_DateTime == null)
				{
					r_GetSecond_DateTime = new(this, "GetSecond", 0, typeof(System.DateTime));
					r_GetSecond_DateTime.SetBelong(this.instance);
				}
				return r_GetSecond_DateTime;
			}
		}

		/// <summary>
		/// Int32 GetFirstDayWeekOfYear(System.DateTime, Int32)
		/// </summary>
		protected RMethod r_GetFirstDayWeekOfYear_DateTime_Int32;
		public virtual RMethod RGetFirstDayWeekOfYear_DateTime_Int32
		{
			get
			{
				if(r_GetFirstDayWeekOfYear_DateTime_Int32 == null)
				{
					r_GetFirstDayWeekOfYear_DateTime_Int32 = new(this, "GetFirstDayWeekOfYear", 0, typeof(System.DateTime), typeof(System.Int32));
					r_GetFirstDayWeekOfYear_DateTime_Int32.SetBelong(this.instance);
				}
				return r_GetFirstDayWeekOfYear_DateTime_Int32;
			}
		}

		/// <summary>
		/// Int32 GetWeekOfYearFullDays(System.DateTime, Int32, Int32)
		/// </summary>
		protected RMethod r_GetWeekOfYearFullDays_DateTime_Int32_Int32;
		public virtual RMethod RGetWeekOfYearFullDays_DateTime_Int32_Int32
		{
			get
			{
				if(r_GetWeekOfYearFullDays_DateTime_Int32_Int32 == null)
				{
					r_GetWeekOfYearFullDays_DateTime_Int32_Int32 = new(this, "GetWeekOfYearFullDays", 0, typeof(System.DateTime), typeof(System.Int32), typeof(System.Int32));
					r_GetWeekOfYearFullDays_DateTime_Int32_Int32.SetBelong(this.instance);
				}
				return r_GetWeekOfYearFullDays_DateTime_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetWeekOfYearOfMinSupportedDateTime(Int32, Int32)
		/// </summary>
		protected RMethod r_GetWeekOfYearOfMinSupportedDateTime_Int32_Int32;
		public virtual RMethod RGetWeekOfYearOfMinSupportedDateTime_Int32_Int32
		{
			get
			{
				if(r_GetWeekOfYearOfMinSupportedDateTime_Int32_Int32 == null)
				{
					r_GetWeekOfYearOfMinSupportedDateTime_Int32_Int32 = new(this, "GetWeekOfYearOfMinSupportedDateTime", 0, typeof(System.Int32), typeof(System.Int32));
					r_GetWeekOfYearOfMinSupportedDateTime_Int32_Int32.SetBelong(this.instance);
				}
				return r_GetWeekOfYearOfMinSupportedDateTime_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetWeekOfYear(System.DateTime, System.Globalization.CalendarWeekRule, System.DayOfWeek)
		/// </summary>
		protected RMethod r_GetWeekOfYear_DateTime_CalendarWeekRule_DayOfWeek;
		public virtual RMethod RGetWeekOfYear_DateTime_CalendarWeekRule_DayOfWeek
		{
			get
			{
				if(r_GetWeekOfYear_DateTime_CalendarWeekRule_DayOfWeek == null)
				{
					r_GetWeekOfYear_DateTime_CalendarWeekRule_DayOfWeek = new(this, "GetWeekOfYear", 0, typeof(System.DateTime), typeof(System.Globalization.CalendarWeekRule), typeof(System.DayOfWeek));
					r_GetWeekOfYear_DateTime_CalendarWeekRule_DayOfWeek.SetBelong(this.instance);
				}
				return r_GetWeekOfYear_DateTime_CalendarWeekRule_DayOfWeek;
			}
		}

		/// <summary>
		/// Int32 GetYear(System.DateTime)
		/// </summary>
		protected RMethod r_GetYear_DateTime;
		public virtual RMethod RGetYear_DateTime
		{
			get
			{
				if(r_GetYear_DateTime == null)
				{
					r_GetYear_DateTime = new(this, "GetYear", 0, typeof(System.DateTime));
					r_GetYear_DateTime.SetBelong(this.instance);
				}
				return r_GetYear_DateTime;
			}
		}

		/// <summary>
		/// Boolean IsLeapDay(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_IsLeapDay_Int32_Int32_Int32;
		public virtual RMethod RIsLeapDay_Int32_Int32_Int32
		{
			get
			{
				if(r_IsLeapDay_Int32_Int32_Int32 == null)
				{
					r_IsLeapDay_Int32_Int32_Int32 = new(this, "IsLeapDay", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_IsLeapDay_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_IsLeapDay_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean IsLeapDay(Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_IsLeapDay_Int32_Int32_Int32_Int32;
		public virtual RMethod RIsLeapDay_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_IsLeapDay_Int32_Int32_Int32_Int32 == null)
				{
					r_IsLeapDay_Int32_Int32_Int32_Int32 = new(this, "IsLeapDay", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_IsLeapDay_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_IsLeapDay_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean IsLeapMonth(Int32, Int32)
		/// </summary>
		protected RMethod r_IsLeapMonth_Int32_Int32;
		public virtual RMethod RIsLeapMonth_Int32_Int32
		{
			get
			{
				if(r_IsLeapMonth_Int32_Int32 == null)
				{
					r_IsLeapMonth_Int32_Int32 = new(this, "IsLeapMonth", 0, typeof(System.Int32), typeof(System.Int32));
					r_IsLeapMonth_Int32_Int32.SetBelong(this.instance);
				}
				return r_IsLeapMonth_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean IsLeapMonth(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_IsLeapMonth_Int32_Int32_Int32;
		public virtual RMethod RIsLeapMonth_Int32_Int32_Int32
		{
			get
			{
				if(r_IsLeapMonth_Int32_Int32_Int32 == null)
				{
					r_IsLeapMonth_Int32_Int32_Int32 = new(this, "IsLeapMonth", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_IsLeapMonth_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_IsLeapMonth_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetLeapMonth(Int32)
		/// </summary>
		protected RMethod r_GetLeapMonth_Int32;
		public virtual RMethod RGetLeapMonth_Int32
		{
			get
			{
				if(r_GetLeapMonth_Int32 == null)
				{
					r_GetLeapMonth_Int32 = new(this, "GetLeapMonth", 0, typeof(System.Int32));
					r_GetLeapMonth_Int32.SetBelong(this.instance);
				}
				return r_GetLeapMonth_Int32;
			}
		}

		/// <summary>
		/// Int32 GetLeapMonth(Int32, Int32)
		/// </summary>
		protected RMethod r_GetLeapMonth_Int32_Int32;
		public virtual RMethod RGetLeapMonth_Int32_Int32
		{
			get
			{
				if(r_GetLeapMonth_Int32_Int32 == null)
				{
					r_GetLeapMonth_Int32_Int32 = new(this, "GetLeapMonth", 0, typeof(System.Int32), typeof(System.Int32));
					r_GetLeapMonth_Int32_Int32.SetBelong(this.instance);
				}
				return r_GetLeapMonth_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean IsLeapYear(Int32)
		/// </summary>
		protected RMethod r_IsLeapYear_Int32;
		public virtual RMethod RIsLeapYear_Int32
		{
			get
			{
				if(r_IsLeapYear_Int32 == null)
				{
					r_IsLeapYear_Int32 = new(this, "IsLeapYear", 0, typeof(System.Int32));
					r_IsLeapYear_Int32.SetBelong(this.instance);
				}
				return r_IsLeapYear_Int32;
			}
		}

		/// <summary>
		/// Boolean IsLeapYear(Int32, Int32)
		/// </summary>
		protected RMethod r_IsLeapYear_Int32_Int32;
		public virtual RMethod RIsLeapYear_Int32_Int32
		{
			get
			{
				if(r_IsLeapYear_Int32_Int32 == null)
				{
					r_IsLeapYear_Int32_Int32 = new(this, "IsLeapYear", 0, typeof(System.Int32), typeof(System.Int32));
					r_IsLeapYear_Int32_Int32.SetBelong(this.instance);
				}
				return r_IsLeapYear_Int32_Int32;
			}
		}

		/// <summary>
		/// System.DateTime ToDateTime(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_ToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32;
		public virtual RMethod RToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_ToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32 == null)
				{
					r_ToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32 = new(this, "ToDateTime", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_ToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_ToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// System.DateTime ToDateTime(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_ToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32;
		public virtual RMethod RToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_ToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32 == null)
				{
					r_ToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32 = new(this, "ToDateTime", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_ToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_ToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean TryToDateTime(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, System.DateTime ByRef)
		/// </summary>
		protected RMethod r_TryToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Out_DateTime;
		public virtual RMethod RTryToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Out_DateTime
		{
			get
			{
				if(r_TryToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Out_DateTime == null)
				{
					r_TryToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Out_DateTime = new(this, "TryToDateTime", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.DateTime).MakeByRefType());
					r_TryToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Out_DateTime.SetBelong(this.instance);
				}
				return r_TryToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Out_DateTime;
			}
		}

		/// <summary>
		/// Boolean IsValidYear(Int32, Int32)
		/// </summary>
		protected RMethod r_IsValidYear_Int32_Int32;
		public virtual RMethod RIsValidYear_Int32_Int32
		{
			get
			{
				if(r_IsValidYear_Int32_Int32 == null)
				{
					r_IsValidYear_Int32_Int32 = new(this, "IsValidYear", 0, typeof(System.Int32), typeof(System.Int32));
					r_IsValidYear_Int32_Int32.SetBelong(this.instance);
				}
				return r_IsValidYear_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean IsValidMonth(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_IsValidMonth_Int32_Int32_Int32;
		public virtual RMethod RIsValidMonth_Int32_Int32_Int32
		{
			get
			{
				if(r_IsValidMonth_Int32_Int32_Int32 == null)
				{
					r_IsValidMonth_Int32_Int32_Int32 = new(this, "IsValidMonth", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_IsValidMonth_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_IsValidMonth_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean IsValidDay(Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_IsValidDay_Int32_Int32_Int32_Int32;
		public virtual RMethod RIsValidDay_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_IsValidDay_Int32_Int32_Int32_Int32 == null)
				{
					r_IsValidDay_Int32_Int32_Int32_Int32 = new(this, "IsValidDay", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_IsValidDay_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_IsValidDay_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 ToFourDigitYear(Int32)
		/// </summary>
		protected RMethod r_ToFourDigitYear_Int32;
		public virtual RMethod RToFourDigitYear_Int32
		{
			get
			{
				if(r_ToFourDigitYear_Int32 == null)
				{
					r_ToFourDigitYear_Int32 = new(this, "ToFourDigitYear", 0, typeof(System.Int32));
					r_ToFourDigitYear_Int32.SetBelong(this.instance);
				}
				return r_ToFourDigitYear_Int32;
			}
		}

		/// <summary>
		/// Int64 TimeToTicks(Int32, Int32, Int32, Int32)
		/// </summary>
		protected static RMethod r_TimeToTicks_Int32_Int32_Int32_Int32;
		public static RMethod RTimeToTicks_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_TimeToTicks_Int32_Int32_Int32_Int32 == null)
				{
					r_TimeToTicks_Int32_Int32_Int32_Int32 = new(typeof(System.Globalization.Calendar), "TimeToTicks", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_TimeToTicks_Int32_Int32_Int32_Int32.SetBelong(null);
				}
				return r_TimeToTicks_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetSystemTwoDigitYearSetting(Int32, Int32)
		/// </summary>
		protected static RMethod r_GetSystemTwoDigitYearSetting_Int32_Int32;
		public static RMethod RGetSystemTwoDigitYearSetting_Int32_Int32
		{
			get
			{
				if(r_GetSystemTwoDigitYearSetting_Int32_Int32 == null)
				{
					r_GetSystemTwoDigitYearSetting_Int32_Int32 = new(typeof(System.Globalization.Calendar), "GetSystemTwoDigitYearSetting", 0, typeof(System.Int32), typeof(System.Int32));
					r_GetSystemTwoDigitYearSetting_Int32_Int32.SetBelong(null);
				}
				return r_GetSystemTwoDigitYearSetting_Int32_Int32;
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


        public RCalendar() : base("System.Globalization.Calendar")
        {
        }

        public RCalendar(System.Object instance) : base("System.Globalization.Calendar")
		{
            SetInstance(instance);
		}

        public RCalendar(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCalendar(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Globalization.Calendar ReadOnly(System.Globalization.Calendar  @calendar)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendar};
            var ___result = RReadOnly_Calendar.Invoke(___genericsType, ___parameters);

            return (System.Globalization.Calendar)___result;
        }


        public virtual void VerifyWritable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RVerifyWritable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetReadOnlyState(System.Boolean  @readOnly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@readOnly};
            var ___result = RSetReadOnlyState_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static void CheckAddResult(System.Int64  @ticks, System.DateTime  @minValue, System.DateTime  @maxValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ticks, @minValue, @maxValue};
            var ___result = RCheckAddResult_Int64_DateTime_DateTime.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.DateTime Add(System.DateTime  @time, System.Double  @value, System.Int32  @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time, @value, @scale};
            var ___result = RAdd_DateTime_Double_Int32.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime AddMilliseconds(System.DateTime  @time, System.Double  @milliseconds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time, @milliseconds};
            var ___result = RAddMilliseconds_DateTime_Double.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime AddDays(System.DateTime  @time, System.Int32  @days)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time, @days};
            var ___result = RAddDays_DateTime_Int32.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime AddHours(System.DateTime  @time, System.Int32  @hours)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time, @hours};
            var ___result = RAddHours_DateTime_Int32.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime AddMinutes(System.DateTime  @time, System.Int32  @minutes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time, @minutes};
            var ___result = RAddMinutes_DateTime_Int32.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime AddMonths(System.DateTime  @time, System.Int32  @months)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time, @months};
            var ___result = RAddMonths_DateTime_Int32.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime AddSeconds(System.DateTime  @time, System.Int32  @seconds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time, @seconds};
            var ___result = RAddSeconds_DateTime_Int32.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime AddWeeks(System.DateTime  @time, System.Int32  @weeks)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time, @weeks};
            var ___result = RAddWeeks_DateTime_Int32.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime AddYears(System.DateTime  @time, System.Int32  @years)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time, @years};
            var ___result = RAddYears_DateTime_Int32.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.Int32 GetDayOfMonth(System.DateTime  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time};
            var ___result = RGetDayOfMonth_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.DayOfWeek GetDayOfWeek(System.DateTime  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time};
            var ___result = RGetDayOfWeek_DateTime.Invoke(___genericsType, ___parameters);

            return (System.DayOfWeek)___result;
        }


        public virtual System.Int32 GetDayOfYear(System.DateTime  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time};
            var ___result = RGetDayOfYear_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetDaysInMonth(System.Int32  @year, System.Int32  @month)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @month};
            var ___result = RGetDaysInMonth_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetDaysInMonth(System.Int32  @year, System.Int32  @month, System.Int32  @era)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @month, @era};
            var ___result = RGetDaysInMonth_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetDaysInYear(System.Int32  @year)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year};
            var ___result = RGetDaysInYear_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetDaysInYear(System.Int32  @year, System.Int32  @era)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @era};
            var ___result = RGetDaysInYear_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetEra(System.DateTime  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time};
            var ___result = RGetEra_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHour(System.DateTime  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time};
            var ___result = RGetHour_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Double GetMilliseconds(System.DateTime  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time};
            var ___result = RGetMilliseconds_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Int32 GetMinute(System.DateTime  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time};
            var ___result = RGetMinute_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetMonth(System.DateTime  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time};
            var ___result = RGetMonth_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetMonthsInYear(System.Int32  @year)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year};
            var ___result = RGetMonthsInYear_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetMonthsInYear(System.Int32  @year, System.Int32  @era)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @era};
            var ___result = RGetMonthsInYear_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetSecond(System.DateTime  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time};
            var ___result = RGetSecond_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetFirstDayWeekOfYear(System.DateTime  @time, System.Int32  @firstDayOfWeek)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time, @firstDayOfWeek};
            var ___result = RGetFirstDayWeekOfYear_DateTime_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetWeekOfYearFullDays(System.DateTime  @time, System.Int32  @firstDayOfWeek, System.Int32  @fullDays)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time, @firstDayOfWeek, @fullDays};
            var ___result = RGetWeekOfYearFullDays_DateTime_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetWeekOfYearOfMinSupportedDateTime(System.Int32  @firstDayOfWeek, System.Int32  @minimumDaysInFirstWeek)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@firstDayOfWeek, @minimumDaysInFirstWeek};
            var ___result = RGetWeekOfYearOfMinSupportedDateTime_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetWeekOfYear(System.DateTime  @time, System.Globalization.CalendarWeekRule  @rule, System.DayOfWeek  @firstDayOfWeek)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time, @rule, @firstDayOfWeek};
            var ___result = RGetWeekOfYear_DateTime_CalendarWeekRule_DayOfWeek.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetYear(System.DateTime  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time};
            var ___result = RGetYear_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean IsLeapDay(System.Int32  @year, System.Int32  @month, System.Int32  @day)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @month, @day};
            var ___result = RIsLeapDay_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsLeapDay(System.Int32  @year, System.Int32  @month, System.Int32  @day, System.Int32  @era)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @month, @day, @era};
            var ___result = RIsLeapDay_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsLeapMonth(System.Int32  @year, System.Int32  @month)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @month};
            var ___result = RIsLeapMonth_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsLeapMonth(System.Int32  @year, System.Int32  @month, System.Int32  @era)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @month, @era};
            var ___result = RIsLeapMonth_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetLeapMonth(System.Int32  @year)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year};
            var ___result = RGetLeapMonth_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetLeapMonth(System.Int32  @year, System.Int32  @era)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @era};
            var ___result = RGetLeapMonth_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean IsLeapYear(System.Int32  @year)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year};
            var ___result = RIsLeapYear_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsLeapYear(System.Int32  @year, System.Int32  @era)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @era};
            var ___result = RIsLeapYear_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.DateTime ToDateTime(System.Int32  @year, System.Int32  @month, System.Int32  @day, System.Int32  @hour, System.Int32  @minute, System.Int32  @second, System.Int32  @millisecond)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @month, @day, @hour, @minute, @second, @millisecond};
            var ___result = RToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime ToDateTime(System.Int32  @year, System.Int32  @month, System.Int32  @day, System.Int32  @hour, System.Int32  @minute, System.Int32  @second, System.Int32  @millisecond, System.Int32  @era)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @month, @day, @hour, @minute, @second, @millisecond, @era};
            var ___result = RToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.Boolean TryToDateTime(System.Int32  @year, System.Int32  @month, System.Int32  @day, System.Int32  @hour, System.Int32  @minute, System.Int32  @second, System.Int32  @millisecond, System.Int32  @era, out System.DateTime  @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @month, @day, @hour, @minute, @second, @millisecond, @era, @result};
            var ___result = RTryToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Out_DateTime.Invoke(___genericsType, ___parameters);
			@result = (System.DateTime)___parameters[8];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsValidYear(System.Int32  @year, System.Int32  @era)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @era};
            var ___result = RIsValidYear_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsValidMonth(System.Int32  @year, System.Int32  @month, System.Int32  @era)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @month, @era};
            var ___result = RIsValidMonth_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsValidDay(System.Int32  @year, System.Int32  @month, System.Int32  @day, System.Int32  @era)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @month, @day, @era};
            var ___result = RIsValidDay_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 ToFourDigitYear(System.Int32  @year)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year};
            var ___result = RToFourDigitYear_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int64 TimeToTicks(System.Int32  @hour, System.Int32  @minute, System.Int32  @second, System.Int32  @millisecond)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hour, @minute, @second, @millisecond};
            var ___result = RTimeToTicks_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public static System.Int32 GetSystemTwoDigitYearSetting(System.Int32  @CalID, System.Int32  @defaultYearValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@CalID, @defaultYearValue};
            var ___result = RGetSystemTwoDigitYearSetting_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
