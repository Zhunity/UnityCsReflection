
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RGlobalization
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Globalization.Calendar
	/// </summary>
    public partial class RCalendar : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Globalization.Calendar);
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


		/// <summary>
		/// System.Int64 TicksPerMillisecond
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt64 r_FTicksPerMillisecond;
		public static Hvak.Editor.Refleaction.RSystem.RInt64 RFTicksPerMillisecond
		{
			get
			{
				if(r_FTicksPerMillisecond == null)
				{
					r_FTicksPerMillisecond = new(Type, "TicksPerMillisecond");
				}
				return r_FTicksPerMillisecond;
			}
		}

		/// <summary>
		/// System.Int64 TicksPerSecond
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt64 r_FTicksPerSecond;
		public static Hvak.Editor.Refleaction.RSystem.RInt64 RFTicksPerSecond
		{
			get
			{
				if(r_FTicksPerSecond == null)
				{
					r_FTicksPerSecond = new(Type, "TicksPerSecond");
				}
				return r_FTicksPerSecond;
			}
		}

		/// <summary>
		/// System.Int64 TicksPerMinute
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt64 r_FTicksPerMinute;
		public static Hvak.Editor.Refleaction.RSystem.RInt64 RFTicksPerMinute
		{
			get
			{
				if(r_FTicksPerMinute == null)
				{
					r_FTicksPerMinute = new(Type, "TicksPerMinute");
				}
				return r_FTicksPerMinute;
			}
		}

		/// <summary>
		/// System.Int64 TicksPerHour
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt64 r_FTicksPerHour;
		public static Hvak.Editor.Refleaction.RSystem.RInt64 RFTicksPerHour
		{
			get
			{
				if(r_FTicksPerHour == null)
				{
					r_FTicksPerHour = new(Type, "TicksPerHour");
				}
				return r_FTicksPerHour;
			}
		}

		/// <summary>
		/// System.Int64 TicksPerDay
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt64 r_FTicksPerDay;
		public static Hvak.Editor.Refleaction.RSystem.RInt64 RFTicksPerDay
		{
			get
			{
				if(r_FTicksPerDay == null)
				{
					r_FTicksPerDay = new(Type, "TicksPerDay");
				}
				return r_FTicksPerDay;
			}
		}

		/// <summary>
		/// System.Int32 MillisPerSecond
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FMillisPerSecond;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFMillisPerSecond
		{
			get
			{
				if(r_FMillisPerSecond == null)
				{
					r_FMillisPerSecond = new(Type, "MillisPerSecond");
				}
				return r_FMillisPerSecond;
			}
		}

		/// <summary>
		/// System.Int32 MillisPerMinute
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FMillisPerMinute;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFMillisPerMinute
		{
			get
			{
				if(r_FMillisPerMinute == null)
				{
					r_FMillisPerMinute = new(Type, "MillisPerMinute");
				}
				return r_FMillisPerMinute;
			}
		}

		/// <summary>
		/// System.Int32 MillisPerHour
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FMillisPerHour;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFMillisPerHour
		{
			get
			{
				if(r_FMillisPerHour == null)
				{
					r_FMillisPerHour = new(Type, "MillisPerHour");
				}
				return r_FMillisPerHour;
			}
		}

		/// <summary>
		/// System.Int32 MillisPerDay
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FMillisPerDay;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFMillisPerDay
		{
			get
			{
				if(r_FMillisPerDay == null)
				{
					r_FMillisPerDay = new(Type, "MillisPerDay");
				}
				return r_FMillisPerDay;
			}
		}

		/// <summary>
		/// System.Int32 DaysPerYear
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FDaysPerYear;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFDaysPerYear
		{
			get
			{
				if(r_FDaysPerYear == null)
				{
					r_FDaysPerYear = new(Type, "DaysPerYear");
				}
				return r_FDaysPerYear;
			}
		}

		/// <summary>
		/// System.Int32 DaysPer4Years
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FDaysPer4Years;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFDaysPer4Years
		{
			get
			{
				if(r_FDaysPer4Years == null)
				{
					r_FDaysPer4Years = new(Type, "DaysPer4Years");
				}
				return r_FDaysPer4Years;
			}
		}

		/// <summary>
		/// System.Int32 DaysPer100Years
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FDaysPer100Years;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFDaysPer100Years
		{
			get
			{
				if(r_FDaysPer100Years == null)
				{
					r_FDaysPer100Years = new(Type, "DaysPer100Years");
				}
				return r_FDaysPer100Years;
			}
		}

		/// <summary>
		/// System.Int32 DaysPer400Years
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FDaysPer400Years;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFDaysPer400Years
		{
			get
			{
				if(r_FDaysPer400Years == null)
				{
					r_FDaysPer400Years = new(Type, "DaysPer400Years");
				}
				return r_FDaysPer400Years;
			}
		}

		/// <summary>
		/// System.Int32 DaysTo10000
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FDaysTo10000;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFDaysTo10000
		{
			get
			{
				if(r_FDaysTo10000 == null)
				{
					r_FDaysTo10000 = new(Type, "DaysTo10000");
				}
				return r_FDaysTo10000;
			}
		}

		/// <summary>
		/// System.Int64 MaxMillis
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt64 r_FMaxMillis;
		public static Hvak.Editor.Refleaction.RSystem.RInt64 RFMaxMillis
		{
			get
			{
				if(r_FMaxMillis == null)
				{
					r_FMaxMillis = new(Type, "MaxMillis");
				}
				return r_FMaxMillis;
			}
		}

		/// <summary>
		/// System.Int32 CAL_GREGORIAN
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCAL_GREGORIAN;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCAL_GREGORIAN
		{
			get
			{
				if(r_FCAL_GREGORIAN == null)
				{
					r_FCAL_GREGORIAN = new(Type, "CAL_GREGORIAN");
				}
				return r_FCAL_GREGORIAN;
			}
		}

		/// <summary>
		/// System.Int32 CAL_GREGORIAN_US
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCAL_GREGORIAN_US;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCAL_GREGORIAN_US
		{
			get
			{
				if(r_FCAL_GREGORIAN_US == null)
				{
					r_FCAL_GREGORIAN_US = new(Type, "CAL_GREGORIAN_US");
				}
				return r_FCAL_GREGORIAN_US;
			}
		}

		/// <summary>
		/// System.Int32 CAL_JAPAN
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCAL_JAPAN;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCAL_JAPAN
		{
			get
			{
				if(r_FCAL_JAPAN == null)
				{
					r_FCAL_JAPAN = new(Type, "CAL_JAPAN");
				}
				return r_FCAL_JAPAN;
			}
		}

		/// <summary>
		/// System.Int32 CAL_TAIWAN
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCAL_TAIWAN;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCAL_TAIWAN
		{
			get
			{
				if(r_FCAL_TAIWAN == null)
				{
					r_FCAL_TAIWAN = new(Type, "CAL_TAIWAN");
				}
				return r_FCAL_TAIWAN;
			}
		}

		/// <summary>
		/// System.Int32 CAL_KOREA
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCAL_KOREA;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCAL_KOREA
		{
			get
			{
				if(r_FCAL_KOREA == null)
				{
					r_FCAL_KOREA = new(Type, "CAL_KOREA");
				}
				return r_FCAL_KOREA;
			}
		}

		/// <summary>
		/// System.Int32 CAL_HIJRI
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCAL_HIJRI;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCAL_HIJRI
		{
			get
			{
				if(r_FCAL_HIJRI == null)
				{
					r_FCAL_HIJRI = new(Type, "CAL_HIJRI");
				}
				return r_FCAL_HIJRI;
			}
		}

		/// <summary>
		/// System.Int32 CAL_THAI
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCAL_THAI;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCAL_THAI
		{
			get
			{
				if(r_FCAL_THAI == null)
				{
					r_FCAL_THAI = new(Type, "CAL_THAI");
				}
				return r_FCAL_THAI;
			}
		}

		/// <summary>
		/// System.Int32 CAL_HEBREW
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCAL_HEBREW;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCAL_HEBREW
		{
			get
			{
				if(r_FCAL_HEBREW == null)
				{
					r_FCAL_HEBREW = new(Type, "CAL_HEBREW");
				}
				return r_FCAL_HEBREW;
			}
		}

		/// <summary>
		/// System.Int32 CAL_GREGORIAN_ME_FRENCH
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCAL_GREGORIAN_ME_FRENCH;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCAL_GREGORIAN_ME_FRENCH
		{
			get
			{
				if(r_FCAL_GREGORIAN_ME_FRENCH == null)
				{
					r_FCAL_GREGORIAN_ME_FRENCH = new(Type, "CAL_GREGORIAN_ME_FRENCH");
				}
				return r_FCAL_GREGORIAN_ME_FRENCH;
			}
		}

		/// <summary>
		/// System.Int32 CAL_GREGORIAN_ARABIC
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCAL_GREGORIAN_ARABIC;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCAL_GREGORIAN_ARABIC
		{
			get
			{
				if(r_FCAL_GREGORIAN_ARABIC == null)
				{
					r_FCAL_GREGORIAN_ARABIC = new(Type, "CAL_GREGORIAN_ARABIC");
				}
				return r_FCAL_GREGORIAN_ARABIC;
			}
		}

		/// <summary>
		/// System.Int32 CAL_GREGORIAN_XLIT_ENGLISH
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCAL_GREGORIAN_XLIT_ENGLISH;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCAL_GREGORIAN_XLIT_ENGLISH
		{
			get
			{
				if(r_FCAL_GREGORIAN_XLIT_ENGLISH == null)
				{
					r_FCAL_GREGORIAN_XLIT_ENGLISH = new(Type, "CAL_GREGORIAN_XLIT_ENGLISH");
				}
				return r_FCAL_GREGORIAN_XLIT_ENGLISH;
			}
		}

		/// <summary>
		/// System.Int32 CAL_GREGORIAN_XLIT_FRENCH
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCAL_GREGORIAN_XLIT_FRENCH;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCAL_GREGORIAN_XLIT_FRENCH
		{
			get
			{
				if(r_FCAL_GREGORIAN_XLIT_FRENCH == null)
				{
					r_FCAL_GREGORIAN_XLIT_FRENCH = new(Type, "CAL_GREGORIAN_XLIT_FRENCH");
				}
				return r_FCAL_GREGORIAN_XLIT_FRENCH;
			}
		}

		/// <summary>
		/// System.Int32 CAL_JULIAN
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCAL_JULIAN;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCAL_JULIAN
		{
			get
			{
				if(r_FCAL_JULIAN == null)
				{
					r_FCAL_JULIAN = new(Type, "CAL_JULIAN");
				}
				return r_FCAL_JULIAN;
			}
		}

		/// <summary>
		/// System.Int32 CAL_JAPANESELUNISOLAR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCAL_JAPANESELUNISOLAR;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCAL_JAPANESELUNISOLAR
		{
			get
			{
				if(r_FCAL_JAPANESELUNISOLAR == null)
				{
					r_FCAL_JAPANESELUNISOLAR = new(Type, "CAL_JAPANESELUNISOLAR");
				}
				return r_FCAL_JAPANESELUNISOLAR;
			}
		}

		/// <summary>
		/// System.Int32 CAL_CHINESELUNISOLAR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCAL_CHINESELUNISOLAR;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCAL_CHINESELUNISOLAR
		{
			get
			{
				if(r_FCAL_CHINESELUNISOLAR == null)
				{
					r_FCAL_CHINESELUNISOLAR = new(Type, "CAL_CHINESELUNISOLAR");
				}
				return r_FCAL_CHINESELUNISOLAR;
			}
		}

		/// <summary>
		/// System.Int32 CAL_SAKA
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCAL_SAKA;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCAL_SAKA
		{
			get
			{
				if(r_FCAL_SAKA == null)
				{
					r_FCAL_SAKA = new(Type, "CAL_SAKA");
				}
				return r_FCAL_SAKA;
			}
		}

		/// <summary>
		/// System.Int32 CAL_LUNAR_ETO_CHN
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCAL_LUNAR_ETO_CHN;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCAL_LUNAR_ETO_CHN
		{
			get
			{
				if(r_FCAL_LUNAR_ETO_CHN == null)
				{
					r_FCAL_LUNAR_ETO_CHN = new(Type, "CAL_LUNAR_ETO_CHN");
				}
				return r_FCAL_LUNAR_ETO_CHN;
			}
		}

		/// <summary>
		/// System.Int32 CAL_LUNAR_ETO_KOR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCAL_LUNAR_ETO_KOR;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCAL_LUNAR_ETO_KOR
		{
			get
			{
				if(r_FCAL_LUNAR_ETO_KOR == null)
				{
					r_FCAL_LUNAR_ETO_KOR = new(Type, "CAL_LUNAR_ETO_KOR");
				}
				return r_FCAL_LUNAR_ETO_KOR;
			}
		}

		/// <summary>
		/// System.Int32 CAL_LUNAR_ETO_ROKUYOU
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCAL_LUNAR_ETO_ROKUYOU;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCAL_LUNAR_ETO_ROKUYOU
		{
			get
			{
				if(r_FCAL_LUNAR_ETO_ROKUYOU == null)
				{
					r_FCAL_LUNAR_ETO_ROKUYOU = new(Type, "CAL_LUNAR_ETO_ROKUYOU");
				}
				return r_FCAL_LUNAR_ETO_ROKUYOU;
			}
		}

		/// <summary>
		/// System.Int32 CAL_KOREANLUNISOLAR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCAL_KOREANLUNISOLAR;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCAL_KOREANLUNISOLAR
		{
			get
			{
				if(r_FCAL_KOREANLUNISOLAR == null)
				{
					r_FCAL_KOREANLUNISOLAR = new(Type, "CAL_KOREANLUNISOLAR");
				}
				return r_FCAL_KOREANLUNISOLAR;
			}
		}

		/// <summary>
		/// System.Int32 CAL_TAIWANLUNISOLAR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCAL_TAIWANLUNISOLAR;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCAL_TAIWANLUNISOLAR
		{
			get
			{
				if(r_FCAL_TAIWANLUNISOLAR == null)
				{
					r_FCAL_TAIWANLUNISOLAR = new(Type, "CAL_TAIWANLUNISOLAR");
				}
				return r_FCAL_TAIWANLUNISOLAR;
			}
		}

		/// <summary>
		/// System.Int32 CAL_PERSIAN
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCAL_PERSIAN;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCAL_PERSIAN
		{
			get
			{
				if(r_FCAL_PERSIAN == null)
				{
					r_FCAL_PERSIAN = new(Type, "CAL_PERSIAN");
				}
				return r_FCAL_PERSIAN;
			}
		}

		/// <summary>
		/// System.Int32 CAL_UMALQURA
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCAL_UMALQURA;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCAL_UMALQURA
		{
			get
			{
				if(r_FCAL_UMALQURA == null)
				{
					r_FCAL_UMALQURA = new(Type, "CAL_UMALQURA");
				}
				return r_FCAL_UMALQURA;
			}
		}

		/// <summary>
		/// System.Int32 m_currentEraValue
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_currentEraValue;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_currentEraValue
		{
			get
			{
				if(r_Fm_currentEraValue == null)
				{
					r_Fm_currentEraValue = new(this, "m_currentEraValue");
				}
				return r_Fm_currentEraValue;
			}
		}

		/// <summary>
		/// System.Boolean m_isReadOnly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_isReadOnly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_isReadOnly
		{
			get
			{
				if(r_Fm_isReadOnly == null)
				{
					r_Fm_isReadOnly = new(this, "m_isReadOnly");
				}
				return r_Fm_isReadOnly;
			}
		}

		/// <summary>
		/// System.Int32 CurrentEra
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCurrentEra;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCurrentEra
		{
			get
			{
				if(r_FCurrentEra == null)
				{
					r_FCurrentEra = new(Type, "CurrentEra");
				}
				return r_FCurrentEra;
			}
		}

		/// <summary>
		/// System.Int32 twoDigitYearMax
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FtwoDigitYearMax;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFtwoDigitYearMax
		{
			get
			{
				if(r_FtwoDigitYearMax == null)
				{
					r_FtwoDigitYearMax = new(this, "twoDigitYearMax");
				}
				return r_FtwoDigitYearMax;
			}
		}

		/// <summary>
		/// System.DateTime MinSupportedDateTime
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RDateTime r_PMinSupportedDateTime;
		public virtual Hvak.Editor.Refleaction.RSystem.RDateTime RPMinSupportedDateTime
		{
			get
			{
				if(r_PMinSupportedDateTime == null)
				{
					r_PMinSupportedDateTime = new(this, "MinSupportedDateTime", -1);
				}
				return r_PMinSupportedDateTime;
			}
		}

		/// <summary>
		/// System.DateTime MaxSupportedDateTime
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RDateTime r_PMaxSupportedDateTime;
		public virtual Hvak.Editor.Refleaction.RSystem.RDateTime RPMaxSupportedDateTime
		{
			get
			{
				if(r_PMaxSupportedDateTime == null)
				{
					r_PMaxSupportedDateTime = new(this, "MaxSupportedDateTime", -1);
				}
				return r_PMaxSupportedDateTime;
			}
		}

		/// <summary>
		/// Int32 ID
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PID;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPID
		{
			get
			{
				if(r_PID == null)
				{
					r_PID = new(this, "ID", -1);
				}
				return r_PID;
			}
		}

		/// <summary>
		/// Int32 BaseCalendarID
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PBaseCalendarID;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPBaseCalendarID
		{
			get
			{
				if(r_PBaseCalendarID == null)
				{
					r_PBaseCalendarID = new(this, "BaseCalendarID", -1);
				}
				return r_PBaseCalendarID;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarAlgorithmType AlgorithmType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarAlgorithmType r_PAlgorithmType;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarAlgorithmType RPAlgorithmType
		{
			get
			{
				if(r_PAlgorithmType == null)
				{
					r_PAlgorithmType = new(this, "AlgorithmType", -1);
				}
				return r_PAlgorithmType;
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
		/// Int32 CurrentEraValue
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PCurrentEraValue;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPCurrentEraValue
		{
			get
			{
				if(r_PCurrentEraValue == null)
				{
					r_PCurrentEraValue = new(this, "CurrentEraValue", -1);
				}
				return r_PCurrentEraValue;
			}
		}

		/// <summary>
		/// Int32[] Eras
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_PEras;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RInt32> RPEras
		{
			get
			{
				if(r_PEras == null)
				{
					r_PEras = new(this, "Eras", -1);
				}
				return r_PEras;
			}
		}

		/// <summary>
		/// Int32 DaysInYearBeforeMinSupportedYear
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PDaysInYearBeforeMinSupportedYear;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPDaysInYearBeforeMinSupportedYear
		{
			get
			{
				if(r_PDaysInYearBeforeMinSupportedYear == null)
				{
					r_PDaysInYearBeforeMinSupportedYear = new(this, "DaysInYearBeforeMinSupportedYear", -1);
				}
				return r_PDaysInYearBeforeMinSupportedYear;
			}
		}

		/// <summary>
		/// Int32 TwoDigitYearMax
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PTwoDigitYearMax;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPTwoDigitYearMax
		{
			get
			{
				if(r_PTwoDigitYearMax == null)
				{
					r_PTwoDigitYearMax = new(this, "TwoDigitYearMax", -1);
				}
				return r_PTwoDigitYearMax;
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
		/// System.Globalization.Calendar ReadOnly(System.Globalization.Calendar)
		/// </summary>
		protected static RMethod r_MReadOnly_Calendar;
		public static RMethod RMReadOnly_Calendar
		{
			get
			{
				if(r_MReadOnly_Calendar == null)
				{
					r_MReadOnly_Calendar = new(Type, "ReadOnly", 0, typeof(System.Globalization.Calendar));
				}
				return r_MReadOnly_Calendar;
			}
		}

		/// <summary>
		/// Void VerifyWritable()
		/// </summary>
		protected RMethod r_MVerifyWritable;
		public virtual RMethod RMVerifyWritable
		{
			get
			{
				if(r_MVerifyWritable == null)
				{
					r_MVerifyWritable = new(this, "VerifyWritable", 0);
				}
				return r_MVerifyWritable;
			}
		}

		/// <summary>
		/// Void SetReadOnlyState(Boolean)
		/// </summary>
		protected RMethod r_MSetReadOnlyState_Boolean;
		public virtual RMethod RMSetReadOnlyState_Boolean
		{
			get
			{
				if(r_MSetReadOnlyState_Boolean == null)
				{
					r_MSetReadOnlyState_Boolean = new(this, "SetReadOnlyState", 0, typeof(System.Boolean));
				}
				return r_MSetReadOnlyState_Boolean;
			}
		}

		/// <summary>
		/// Void CheckAddResult(Int64, System.DateTime, System.DateTime)
		/// </summary>
		protected static RMethod r_MCheckAddResult_Int64_DateTime_DateTime;
		public static RMethod RMCheckAddResult_Int64_DateTime_DateTime
		{
			get
			{
				if(r_MCheckAddResult_Int64_DateTime_DateTime == null)
				{
					r_MCheckAddResult_Int64_DateTime_DateTime = new(Type, "CheckAddResult", 0, typeof(System.Int64), typeof(System.DateTime), typeof(System.DateTime));
				}
				return r_MCheckAddResult_Int64_DateTime_DateTime;
			}
		}

		/// <summary>
		/// System.DateTime Add(System.DateTime, Double, Int32)
		/// </summary>
		protected RMethod r_MAdd_DateTime_Double_Int32;
		public virtual RMethod RMAdd_DateTime_Double_Int32
		{
			get
			{
				if(r_MAdd_DateTime_Double_Int32 == null)
				{
					r_MAdd_DateTime_Double_Int32 = new(this, "Add", 0, typeof(System.DateTime), typeof(System.Double), typeof(System.Int32));
				}
				return r_MAdd_DateTime_Double_Int32;
			}
		}

		/// <summary>
		/// System.DateTime AddMilliseconds(System.DateTime, Double)
		/// </summary>
		protected RMethod r_MAddMilliseconds_DateTime_Double;
		public virtual RMethod RMAddMilliseconds_DateTime_Double
		{
			get
			{
				if(r_MAddMilliseconds_DateTime_Double == null)
				{
					r_MAddMilliseconds_DateTime_Double = new(this, "AddMilliseconds", 0, typeof(System.DateTime), typeof(System.Double));
				}
				return r_MAddMilliseconds_DateTime_Double;
			}
		}

		/// <summary>
		/// System.DateTime AddDays(System.DateTime, Int32)
		/// </summary>
		protected RMethod r_MAddDays_DateTime_Int32;
		public virtual RMethod RMAddDays_DateTime_Int32
		{
			get
			{
				if(r_MAddDays_DateTime_Int32 == null)
				{
					r_MAddDays_DateTime_Int32 = new(this, "AddDays", 0, typeof(System.DateTime), typeof(System.Int32));
				}
				return r_MAddDays_DateTime_Int32;
			}
		}

		/// <summary>
		/// System.DateTime AddHours(System.DateTime, Int32)
		/// </summary>
		protected RMethod r_MAddHours_DateTime_Int32;
		public virtual RMethod RMAddHours_DateTime_Int32
		{
			get
			{
				if(r_MAddHours_DateTime_Int32 == null)
				{
					r_MAddHours_DateTime_Int32 = new(this, "AddHours", 0, typeof(System.DateTime), typeof(System.Int32));
				}
				return r_MAddHours_DateTime_Int32;
			}
		}

		/// <summary>
		/// System.DateTime AddMinutes(System.DateTime, Int32)
		/// </summary>
		protected RMethod r_MAddMinutes_DateTime_Int32;
		public virtual RMethod RMAddMinutes_DateTime_Int32
		{
			get
			{
				if(r_MAddMinutes_DateTime_Int32 == null)
				{
					r_MAddMinutes_DateTime_Int32 = new(this, "AddMinutes", 0, typeof(System.DateTime), typeof(System.Int32));
				}
				return r_MAddMinutes_DateTime_Int32;
			}
		}

		/// <summary>
		/// System.DateTime AddMonths(System.DateTime, Int32)
		/// </summary>
		protected RMethod r_MAddMonths_DateTime_Int32;
		public virtual RMethod RMAddMonths_DateTime_Int32
		{
			get
			{
				if(r_MAddMonths_DateTime_Int32 == null)
				{
					r_MAddMonths_DateTime_Int32 = new(this, "AddMonths", 0, typeof(System.DateTime), typeof(System.Int32));
				}
				return r_MAddMonths_DateTime_Int32;
			}
		}

		/// <summary>
		/// System.DateTime AddSeconds(System.DateTime, Int32)
		/// </summary>
		protected RMethod r_MAddSeconds_DateTime_Int32;
		public virtual RMethod RMAddSeconds_DateTime_Int32
		{
			get
			{
				if(r_MAddSeconds_DateTime_Int32 == null)
				{
					r_MAddSeconds_DateTime_Int32 = new(this, "AddSeconds", 0, typeof(System.DateTime), typeof(System.Int32));
				}
				return r_MAddSeconds_DateTime_Int32;
			}
		}

		/// <summary>
		/// System.DateTime AddWeeks(System.DateTime, Int32)
		/// </summary>
		protected RMethod r_MAddWeeks_DateTime_Int32;
		public virtual RMethod RMAddWeeks_DateTime_Int32
		{
			get
			{
				if(r_MAddWeeks_DateTime_Int32 == null)
				{
					r_MAddWeeks_DateTime_Int32 = new(this, "AddWeeks", 0, typeof(System.DateTime), typeof(System.Int32));
				}
				return r_MAddWeeks_DateTime_Int32;
			}
		}

		/// <summary>
		/// System.DateTime AddYears(System.DateTime, Int32)
		/// </summary>
		protected RMethod r_MAddYears_DateTime_Int32;
		public virtual RMethod RMAddYears_DateTime_Int32
		{
			get
			{
				if(r_MAddYears_DateTime_Int32 == null)
				{
					r_MAddYears_DateTime_Int32 = new(this, "AddYears", 0, typeof(System.DateTime), typeof(System.Int32));
				}
				return r_MAddYears_DateTime_Int32;
			}
		}

		/// <summary>
		/// Int32 GetDayOfMonth(System.DateTime)
		/// </summary>
		protected RMethod r_MGetDayOfMonth_DateTime;
		public virtual RMethod RMGetDayOfMonth_DateTime
		{
			get
			{
				if(r_MGetDayOfMonth_DateTime == null)
				{
					r_MGetDayOfMonth_DateTime = new(this, "GetDayOfMonth", 0, typeof(System.DateTime));
				}
				return r_MGetDayOfMonth_DateTime;
			}
		}

		/// <summary>
		/// System.DayOfWeek GetDayOfWeek(System.DateTime)
		/// </summary>
		protected RMethod r_MGetDayOfWeek_DateTime;
		public virtual RMethod RMGetDayOfWeek_DateTime
		{
			get
			{
				if(r_MGetDayOfWeek_DateTime == null)
				{
					r_MGetDayOfWeek_DateTime = new(this, "GetDayOfWeek", 0, typeof(System.DateTime));
				}
				return r_MGetDayOfWeek_DateTime;
			}
		}

		/// <summary>
		/// Int32 GetDayOfYear(System.DateTime)
		/// </summary>
		protected RMethod r_MGetDayOfYear_DateTime;
		public virtual RMethod RMGetDayOfYear_DateTime
		{
			get
			{
				if(r_MGetDayOfYear_DateTime == null)
				{
					r_MGetDayOfYear_DateTime = new(this, "GetDayOfYear", 0, typeof(System.DateTime));
				}
				return r_MGetDayOfYear_DateTime;
			}
		}

		/// <summary>
		/// Int32 GetDaysInMonth(Int32, Int32)
		/// </summary>
		protected RMethod r_MGetDaysInMonth_Int32_Int32;
		public virtual RMethod RMGetDaysInMonth_Int32_Int32
		{
			get
			{
				if(r_MGetDaysInMonth_Int32_Int32 == null)
				{
					r_MGetDaysInMonth_Int32_Int32 = new(this, "GetDaysInMonth", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MGetDaysInMonth_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetDaysInMonth(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MGetDaysInMonth_Int32_Int32_Int32;
		public virtual RMethod RMGetDaysInMonth_Int32_Int32_Int32
		{
			get
			{
				if(r_MGetDaysInMonth_Int32_Int32_Int32 == null)
				{
					r_MGetDaysInMonth_Int32_Int32_Int32 = new(this, "GetDaysInMonth", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MGetDaysInMonth_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetDaysInYear(Int32)
		/// </summary>
		protected RMethod r_MGetDaysInYear_Int32;
		public virtual RMethod RMGetDaysInYear_Int32
		{
			get
			{
				if(r_MGetDaysInYear_Int32 == null)
				{
					r_MGetDaysInYear_Int32 = new(this, "GetDaysInYear", 0, typeof(System.Int32));
				}
				return r_MGetDaysInYear_Int32;
			}
		}

		/// <summary>
		/// Int32 GetDaysInYear(Int32, Int32)
		/// </summary>
		protected RMethod r_MGetDaysInYear_Int32_Int32;
		public virtual RMethod RMGetDaysInYear_Int32_Int32
		{
			get
			{
				if(r_MGetDaysInYear_Int32_Int32 == null)
				{
					r_MGetDaysInYear_Int32_Int32 = new(this, "GetDaysInYear", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MGetDaysInYear_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetEra(System.DateTime)
		/// </summary>
		protected RMethod r_MGetEra_DateTime;
		public virtual RMethod RMGetEra_DateTime
		{
			get
			{
				if(r_MGetEra_DateTime == null)
				{
					r_MGetEra_DateTime = new(this, "GetEra", 0, typeof(System.DateTime));
				}
				return r_MGetEra_DateTime;
			}
		}

		/// <summary>
		/// Int32 GetHour(System.DateTime)
		/// </summary>
		protected RMethod r_MGetHour_DateTime;
		public virtual RMethod RMGetHour_DateTime
		{
			get
			{
				if(r_MGetHour_DateTime == null)
				{
					r_MGetHour_DateTime = new(this, "GetHour", 0, typeof(System.DateTime));
				}
				return r_MGetHour_DateTime;
			}
		}

		/// <summary>
		/// Double GetMilliseconds(System.DateTime)
		/// </summary>
		protected RMethod r_MGetMilliseconds_DateTime;
		public virtual RMethod RMGetMilliseconds_DateTime
		{
			get
			{
				if(r_MGetMilliseconds_DateTime == null)
				{
					r_MGetMilliseconds_DateTime = new(this, "GetMilliseconds", 0, typeof(System.DateTime));
				}
				return r_MGetMilliseconds_DateTime;
			}
		}

		/// <summary>
		/// Int32 GetMinute(System.DateTime)
		/// </summary>
		protected RMethod r_MGetMinute_DateTime;
		public virtual RMethod RMGetMinute_DateTime
		{
			get
			{
				if(r_MGetMinute_DateTime == null)
				{
					r_MGetMinute_DateTime = new(this, "GetMinute", 0, typeof(System.DateTime));
				}
				return r_MGetMinute_DateTime;
			}
		}

		/// <summary>
		/// Int32 GetMonth(System.DateTime)
		/// </summary>
		protected RMethod r_MGetMonth_DateTime;
		public virtual RMethod RMGetMonth_DateTime
		{
			get
			{
				if(r_MGetMonth_DateTime == null)
				{
					r_MGetMonth_DateTime = new(this, "GetMonth", 0, typeof(System.DateTime));
				}
				return r_MGetMonth_DateTime;
			}
		}

		/// <summary>
		/// Int32 GetMonthsInYear(Int32)
		/// </summary>
		protected RMethod r_MGetMonthsInYear_Int32;
		public virtual RMethod RMGetMonthsInYear_Int32
		{
			get
			{
				if(r_MGetMonthsInYear_Int32 == null)
				{
					r_MGetMonthsInYear_Int32 = new(this, "GetMonthsInYear", 0, typeof(System.Int32));
				}
				return r_MGetMonthsInYear_Int32;
			}
		}

		/// <summary>
		/// Int32 GetMonthsInYear(Int32, Int32)
		/// </summary>
		protected RMethod r_MGetMonthsInYear_Int32_Int32;
		public virtual RMethod RMGetMonthsInYear_Int32_Int32
		{
			get
			{
				if(r_MGetMonthsInYear_Int32_Int32 == null)
				{
					r_MGetMonthsInYear_Int32_Int32 = new(this, "GetMonthsInYear", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MGetMonthsInYear_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetSecond(System.DateTime)
		/// </summary>
		protected RMethod r_MGetSecond_DateTime;
		public virtual RMethod RMGetSecond_DateTime
		{
			get
			{
				if(r_MGetSecond_DateTime == null)
				{
					r_MGetSecond_DateTime = new(this, "GetSecond", 0, typeof(System.DateTime));
				}
				return r_MGetSecond_DateTime;
			}
		}

		/// <summary>
		/// Int32 GetFirstDayWeekOfYear(System.DateTime, Int32)
		/// </summary>
		protected RMethod r_MGetFirstDayWeekOfYear_DateTime_Int32;
		public virtual RMethod RMGetFirstDayWeekOfYear_DateTime_Int32
		{
			get
			{
				if(r_MGetFirstDayWeekOfYear_DateTime_Int32 == null)
				{
					r_MGetFirstDayWeekOfYear_DateTime_Int32 = new(this, "GetFirstDayWeekOfYear", 0, typeof(System.DateTime), typeof(System.Int32));
				}
				return r_MGetFirstDayWeekOfYear_DateTime_Int32;
			}
		}

		/// <summary>
		/// Int32 GetWeekOfYearFullDays(System.DateTime, Int32, Int32)
		/// </summary>
		protected RMethod r_MGetWeekOfYearFullDays_DateTime_Int32_Int32;
		public virtual RMethod RMGetWeekOfYearFullDays_DateTime_Int32_Int32
		{
			get
			{
				if(r_MGetWeekOfYearFullDays_DateTime_Int32_Int32 == null)
				{
					r_MGetWeekOfYearFullDays_DateTime_Int32_Int32 = new(this, "GetWeekOfYearFullDays", 0, typeof(System.DateTime), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MGetWeekOfYearFullDays_DateTime_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetWeekOfYearOfMinSupportedDateTime(Int32, Int32)
		/// </summary>
		protected RMethod r_MGetWeekOfYearOfMinSupportedDateTime_Int32_Int32;
		public virtual RMethod RMGetWeekOfYearOfMinSupportedDateTime_Int32_Int32
		{
			get
			{
				if(r_MGetWeekOfYearOfMinSupportedDateTime_Int32_Int32 == null)
				{
					r_MGetWeekOfYearOfMinSupportedDateTime_Int32_Int32 = new(this, "GetWeekOfYearOfMinSupportedDateTime", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MGetWeekOfYearOfMinSupportedDateTime_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetWeekOfYear(System.DateTime, System.Globalization.CalendarWeekRule, System.DayOfWeek)
		/// </summary>
		protected RMethod r_MGetWeekOfYear_DateTime_CalendarWeekRule_DayOfWeek;
		public virtual RMethod RMGetWeekOfYear_DateTime_CalendarWeekRule_DayOfWeek
		{
			get
			{
				if(r_MGetWeekOfYear_DateTime_CalendarWeekRule_DayOfWeek == null)
				{
					r_MGetWeekOfYear_DateTime_CalendarWeekRule_DayOfWeek = new(this, "GetWeekOfYear", 0, typeof(System.DateTime), typeof(System.Globalization.CalendarWeekRule), typeof(System.DayOfWeek));
				}
				return r_MGetWeekOfYear_DateTime_CalendarWeekRule_DayOfWeek;
			}
		}

		/// <summary>
		/// Int32 GetYear(System.DateTime)
		/// </summary>
		protected RMethod r_MGetYear_DateTime;
		public virtual RMethod RMGetYear_DateTime
		{
			get
			{
				if(r_MGetYear_DateTime == null)
				{
					r_MGetYear_DateTime = new(this, "GetYear", 0, typeof(System.DateTime));
				}
				return r_MGetYear_DateTime;
			}
		}

		/// <summary>
		/// Boolean IsLeapDay(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MIsLeapDay_Int32_Int32_Int32;
		public virtual RMethod RMIsLeapDay_Int32_Int32_Int32
		{
			get
			{
				if(r_MIsLeapDay_Int32_Int32_Int32 == null)
				{
					r_MIsLeapDay_Int32_Int32_Int32 = new(this, "IsLeapDay", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MIsLeapDay_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean IsLeapDay(Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MIsLeapDay_Int32_Int32_Int32_Int32;
		public virtual RMethod RMIsLeapDay_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MIsLeapDay_Int32_Int32_Int32_Int32 == null)
				{
					r_MIsLeapDay_Int32_Int32_Int32_Int32 = new(this, "IsLeapDay", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MIsLeapDay_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean IsLeapMonth(Int32, Int32)
		/// </summary>
		protected RMethod r_MIsLeapMonth_Int32_Int32;
		public virtual RMethod RMIsLeapMonth_Int32_Int32
		{
			get
			{
				if(r_MIsLeapMonth_Int32_Int32 == null)
				{
					r_MIsLeapMonth_Int32_Int32 = new(this, "IsLeapMonth", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MIsLeapMonth_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean IsLeapMonth(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MIsLeapMonth_Int32_Int32_Int32;
		public virtual RMethod RMIsLeapMonth_Int32_Int32_Int32
		{
			get
			{
				if(r_MIsLeapMonth_Int32_Int32_Int32 == null)
				{
					r_MIsLeapMonth_Int32_Int32_Int32 = new(this, "IsLeapMonth", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MIsLeapMonth_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetLeapMonth(Int32)
		/// </summary>
		protected RMethod r_MGetLeapMonth_Int32;
		public virtual RMethod RMGetLeapMonth_Int32
		{
			get
			{
				if(r_MGetLeapMonth_Int32 == null)
				{
					r_MGetLeapMonth_Int32 = new(this, "GetLeapMonth", 0, typeof(System.Int32));
				}
				return r_MGetLeapMonth_Int32;
			}
		}

		/// <summary>
		/// Int32 GetLeapMonth(Int32, Int32)
		/// </summary>
		protected RMethod r_MGetLeapMonth_Int32_Int32;
		public virtual RMethod RMGetLeapMonth_Int32_Int32
		{
			get
			{
				if(r_MGetLeapMonth_Int32_Int32 == null)
				{
					r_MGetLeapMonth_Int32_Int32 = new(this, "GetLeapMonth", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MGetLeapMonth_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean IsLeapYear(Int32)
		/// </summary>
		protected RMethod r_MIsLeapYear_Int32;
		public virtual RMethod RMIsLeapYear_Int32
		{
			get
			{
				if(r_MIsLeapYear_Int32 == null)
				{
					r_MIsLeapYear_Int32 = new(this, "IsLeapYear", 0, typeof(System.Int32));
				}
				return r_MIsLeapYear_Int32;
			}
		}

		/// <summary>
		/// Boolean IsLeapYear(Int32, Int32)
		/// </summary>
		protected RMethod r_MIsLeapYear_Int32_Int32;
		public virtual RMethod RMIsLeapYear_Int32_Int32
		{
			get
			{
				if(r_MIsLeapYear_Int32_Int32 == null)
				{
					r_MIsLeapYear_Int32_Int32 = new(this, "IsLeapYear", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MIsLeapYear_Int32_Int32;
			}
		}

		/// <summary>
		/// System.DateTime ToDateTime(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32;
		public virtual RMethod RMToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32 == null)
				{
					r_MToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32 = new(this, "ToDateTime", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// System.DateTime ToDateTime(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32;
		public virtual RMethod RMToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32 == null)
				{
					r_MToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32 = new(this, "ToDateTime", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean TryToDateTime(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, System.DateTime ByRef)
		/// </summary>
		protected RMethod r_MTryToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Out_DateTime;
		public virtual RMethod RMTryToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Out_DateTime
		{
			get
			{
				if(r_MTryToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Out_DateTime == null)
				{
					r_MTryToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Out_DateTime = new(this, "TryToDateTime", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.DateTime).MakeByRefType());
				}
				return r_MTryToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Out_DateTime;
			}
		}

		/// <summary>
		/// Boolean IsValidYear(Int32, Int32)
		/// </summary>
		protected RMethod r_MIsValidYear_Int32_Int32;
		public virtual RMethod RMIsValidYear_Int32_Int32
		{
			get
			{
				if(r_MIsValidYear_Int32_Int32 == null)
				{
					r_MIsValidYear_Int32_Int32 = new(this, "IsValidYear", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MIsValidYear_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean IsValidMonth(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MIsValidMonth_Int32_Int32_Int32;
		public virtual RMethod RMIsValidMonth_Int32_Int32_Int32
		{
			get
			{
				if(r_MIsValidMonth_Int32_Int32_Int32 == null)
				{
					r_MIsValidMonth_Int32_Int32_Int32 = new(this, "IsValidMonth", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MIsValidMonth_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean IsValidDay(Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MIsValidDay_Int32_Int32_Int32_Int32;
		public virtual RMethod RMIsValidDay_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MIsValidDay_Int32_Int32_Int32_Int32 == null)
				{
					r_MIsValidDay_Int32_Int32_Int32_Int32 = new(this, "IsValidDay", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MIsValidDay_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 ToFourDigitYear(Int32)
		/// </summary>
		protected RMethod r_MToFourDigitYear_Int32;
		public virtual RMethod RMToFourDigitYear_Int32
		{
			get
			{
				if(r_MToFourDigitYear_Int32 == null)
				{
					r_MToFourDigitYear_Int32 = new(this, "ToFourDigitYear", 0, typeof(System.Int32));
				}
				return r_MToFourDigitYear_Int32;
			}
		}

		/// <summary>
		/// Int64 TimeToTicks(Int32, Int32, Int32, Int32)
		/// </summary>
		protected static RMethod r_MTimeToTicks_Int32_Int32_Int32_Int32;
		public static RMethod RMTimeToTicks_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MTimeToTicks_Int32_Int32_Int32_Int32 == null)
				{
					r_MTimeToTicks_Int32_Int32_Int32_Int32 = new(Type, "TimeToTicks", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MTimeToTicks_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetSystemTwoDigitYearSetting(Int32, Int32)
		/// </summary>
		protected static RMethod r_MGetSystemTwoDigitYearSetting_Int32_Int32;
		public static RMethod RMGetSystemTwoDigitYearSetting_Int32_Int32
		{
			get
			{
				if(r_MGetSystemTwoDigitYearSetting_Int32_Int32 == null)
				{
					r_MGetSystemTwoDigitYearSetting_Int32_Int32 = new(Type, "GetSystemTwoDigitYearSetting", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MGetSystemTwoDigitYearSetting_Int32_Int32;
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


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public static System.Globalization.Calendar ReadOnly(System.Globalization.Calendar @calendar)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendar};
            var ___result = RMReadOnly_Calendar.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Globalization.Calendar>(___result);
        }


        public virtual void VerifyWritable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMVerifyWritable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetReadOnlyState(System.Boolean @readOnly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@readOnly};
            var ___result = RMSetReadOnlyState_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static void CheckAddResult(System.Int64 @ticks, System.DateTime @minValue, System.DateTime @maxValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ticks, @minValue, @maxValue};
            var ___result = RMCheckAddResult_Int64_DateTime_DateTime.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.DateTime Add(System.DateTime @time, System.Double @value, System.Int32 @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time, @value, @scale};
            var ___result = RMAdd_DateTime_Double_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.DateTime>(___result);
        }


        public virtual System.DateTime AddMilliseconds(System.DateTime @time, System.Double @milliseconds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time, @milliseconds};
            var ___result = RMAddMilliseconds_DateTime_Double.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.DateTime>(___result);
        }


        public virtual System.DateTime AddDays(System.DateTime @time, System.Int32 @days)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time, @days};
            var ___result = RMAddDays_DateTime_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.DateTime>(___result);
        }


        public virtual System.DateTime AddHours(System.DateTime @time, System.Int32 @hours)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time, @hours};
            var ___result = RMAddHours_DateTime_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.DateTime>(___result);
        }


        public virtual System.DateTime AddMinutes(System.DateTime @time, System.Int32 @minutes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time, @minutes};
            var ___result = RMAddMinutes_DateTime_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.DateTime>(___result);
        }


        public virtual System.DateTime AddMonths(System.DateTime @time, System.Int32 @months)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time, @months};
            var ___result = RMAddMonths_DateTime_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.DateTime>(___result);
        }


        public virtual System.DateTime AddSeconds(System.DateTime @time, System.Int32 @seconds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time, @seconds};
            var ___result = RMAddSeconds_DateTime_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.DateTime>(___result);
        }


        public virtual System.DateTime AddWeeks(System.DateTime @time, System.Int32 @weeks)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time, @weeks};
            var ___result = RMAddWeeks_DateTime_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.DateTime>(___result);
        }


        public virtual System.DateTime AddYears(System.DateTime @time, System.Int32 @years)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time, @years};
            var ___result = RMAddYears_DateTime_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.DateTime>(___result);
        }


        public virtual System.Int32 GetDayOfMonth(System.DateTime @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time};
            var ___result = RMGetDayOfMonth_DateTime.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.DayOfWeek GetDayOfWeek(System.DateTime @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time};
            var ___result = RMGetDayOfWeek_DateTime.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.DayOfWeek>(___result);
        }


        public virtual System.Int32 GetDayOfYear(System.DateTime @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time};
            var ___result = RMGetDayOfYear_DateTime.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetDaysInMonth(System.Int32 @year, System.Int32 @month)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @month};
            var ___result = RMGetDaysInMonth_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetDaysInMonth(System.Int32 @year, System.Int32 @month, System.Int32 @era)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @month, @era};
            var ___result = RMGetDaysInMonth_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetDaysInYear(System.Int32 @year)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year};
            var ___result = RMGetDaysInYear_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetDaysInYear(System.Int32 @year, System.Int32 @era)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @era};
            var ___result = RMGetDaysInYear_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetEra(System.DateTime @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time};
            var ___result = RMGetEra_DateTime.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetHour(System.DateTime @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time};
            var ___result = RMGetHour_DateTime.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Double GetMilliseconds(System.DateTime @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time};
            var ___result = RMGetMilliseconds_DateTime.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Double>(___result);
        }


        public virtual System.Int32 GetMinute(System.DateTime @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time};
            var ___result = RMGetMinute_DateTime.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetMonth(System.DateTime @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time};
            var ___result = RMGetMonth_DateTime.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetMonthsInYear(System.Int32 @year)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year};
            var ___result = RMGetMonthsInYear_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetMonthsInYear(System.Int32 @year, System.Int32 @era)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @era};
            var ___result = RMGetMonthsInYear_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetSecond(System.DateTime @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time};
            var ___result = RMGetSecond_DateTime.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetFirstDayWeekOfYear(System.DateTime @time, System.Int32 @firstDayOfWeek)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time, @firstDayOfWeek};
            var ___result = RMGetFirstDayWeekOfYear_DateTime_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetWeekOfYearFullDays(System.DateTime @time, System.Int32 @firstDayOfWeek, System.Int32 @fullDays)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time, @firstDayOfWeek, @fullDays};
            var ___result = RMGetWeekOfYearFullDays_DateTime_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetWeekOfYearOfMinSupportedDateTime(System.Int32 @firstDayOfWeek, System.Int32 @minimumDaysInFirstWeek)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@firstDayOfWeek, @minimumDaysInFirstWeek};
            var ___result = RMGetWeekOfYearOfMinSupportedDateTime_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetWeekOfYear(System.DateTime @time, System.Globalization.CalendarWeekRule @rule, System.DayOfWeek @firstDayOfWeek)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time, @rule, @firstDayOfWeek};
            var ___result = RMGetWeekOfYear_DateTime_CalendarWeekRule_DayOfWeek.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetYear(System.DateTime @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time};
            var ___result = RMGetYear_DateTime.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean IsLeapDay(System.Int32 @year, System.Int32 @month, System.Int32 @day)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @month, @day};
            var ___result = RMIsLeapDay_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean IsLeapDay(System.Int32 @year, System.Int32 @month, System.Int32 @day, System.Int32 @era)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @month, @day, @era};
            var ___result = RMIsLeapDay_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean IsLeapMonth(System.Int32 @year, System.Int32 @month)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @month};
            var ___result = RMIsLeapMonth_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean IsLeapMonth(System.Int32 @year, System.Int32 @month, System.Int32 @era)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @month, @era};
            var ___result = RMIsLeapMonth_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetLeapMonth(System.Int32 @year)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year};
            var ___result = RMGetLeapMonth_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetLeapMonth(System.Int32 @year, System.Int32 @era)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @era};
            var ___result = RMGetLeapMonth_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean IsLeapYear(System.Int32 @year)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year};
            var ___result = RMIsLeapYear_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean IsLeapYear(System.Int32 @year, System.Int32 @era)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @era};
            var ___result = RMIsLeapYear_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.DateTime ToDateTime(System.Int32 @year, System.Int32 @month, System.Int32 @day, System.Int32 @hour, System.Int32 @minute, System.Int32 @second, System.Int32 @millisecond)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @month, @day, @hour, @minute, @second, @millisecond};
            var ___result = RMToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.DateTime>(___result);
        }


        public virtual System.DateTime ToDateTime(System.Int32 @year, System.Int32 @month, System.Int32 @day, System.Int32 @hour, System.Int32 @minute, System.Int32 @second, System.Int32 @millisecond, System.Int32 @era)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @month, @day, @hour, @minute, @second, @millisecond, @era};
            var ___result = RMToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.DateTime>(___result);
        }


        public virtual System.Boolean TryToDateTime(System.Int32 @year, System.Int32 @month, System.Int32 @day, System.Int32 @hour, System.Int32 @minute, System.Int32 @second, System.Int32 @millisecond, System.Int32 @era, out System.DateTime @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @month, @day, @hour, @minute, @second, @millisecond, @era, @result};
            var ___result = RMTryToDateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Out_DateTime.Invoke(___genericsType, ___parameters);
			@result = ReflectionUtils.Convert<System.DateTime>(___parameters[8]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean IsValidYear(System.Int32 @year, System.Int32 @era)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @era};
            var ___result = RMIsValidYear_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean IsValidMonth(System.Int32 @year, System.Int32 @month, System.Int32 @era)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @month, @era};
            var ___result = RMIsValidMonth_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean IsValidDay(System.Int32 @year, System.Int32 @month, System.Int32 @day, System.Int32 @era)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @month, @day, @era};
            var ___result = RMIsValidDay_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 ToFourDigitYear(System.Int32 @year)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year};
            var ___result = RMToFourDigitYear_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.Int64 TimeToTicks(System.Int32 @hour, System.Int32 @minute, System.Int32 @second, System.Int32 @millisecond)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hour, @minute, @second, @millisecond};
            var ___result = RMTimeToTicks_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int64>(___result);
        }


        public static System.Int32 GetSystemTwoDigitYearSetting(System.Int32 @CalID, System.Int32 @defaultYearValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@CalID, @defaultYearValue};
            var ___result = RMGetSystemTwoDigitYearSetting_Int32_Int32.Invoke(___genericsType, ___parameters);

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
