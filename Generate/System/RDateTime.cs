using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.DateTime
	/// </summary>
    public partial class RDateTime : RMember //
    {

		/// <summary>
		/// System.Int64 TicksPerMillisecond
		/// </summary>
		protected static RSystem.RInt64 r_TicksPerMillisecond;
		public static RSystem.RInt64 RTicksPerMillisecond
		{
			get
			{
				if(r_TicksPerMillisecond == null)
				{
					r_TicksPerMillisecond = new(typeof(System.DateTime), "TicksPerMillisecond");
					r_TicksPerMillisecond.SetBelong(null);
				}
				return r_TicksPerMillisecond;
			}
		}

		/// <summary>
		/// System.Int64 TicksPerSecond
		/// </summary>
		protected static RSystem.RInt64 r_TicksPerSecond;
		public static RSystem.RInt64 RTicksPerSecond
		{
			get
			{
				if(r_TicksPerSecond == null)
				{
					r_TicksPerSecond = new(typeof(System.DateTime), "TicksPerSecond");
					r_TicksPerSecond.SetBelong(null);
				}
				return r_TicksPerSecond;
			}
		}

		/// <summary>
		/// System.Int64 TicksPerMinute
		/// </summary>
		protected static RSystem.RInt64 r_TicksPerMinute;
		public static RSystem.RInt64 RTicksPerMinute
		{
			get
			{
				if(r_TicksPerMinute == null)
				{
					r_TicksPerMinute = new(typeof(System.DateTime), "TicksPerMinute");
					r_TicksPerMinute.SetBelong(null);
				}
				return r_TicksPerMinute;
			}
		}

		/// <summary>
		/// System.Int64 TicksPerHour
		/// </summary>
		protected static RSystem.RInt64 r_TicksPerHour;
		public static RSystem.RInt64 RTicksPerHour
		{
			get
			{
				if(r_TicksPerHour == null)
				{
					r_TicksPerHour = new(typeof(System.DateTime), "TicksPerHour");
					r_TicksPerHour.SetBelong(null);
				}
				return r_TicksPerHour;
			}
		}

		/// <summary>
		/// System.Int64 TicksPerDay
		/// </summary>
		protected static RSystem.RInt64 r_TicksPerDay;
		public static RSystem.RInt64 RTicksPerDay
		{
			get
			{
				if(r_TicksPerDay == null)
				{
					r_TicksPerDay = new(typeof(System.DateTime), "TicksPerDay");
					r_TicksPerDay.SetBelong(null);
				}
				return r_TicksPerDay;
			}
		}

		/// <summary>
		/// System.Int32 MillisPerSecond
		/// </summary>
		protected static RSystem.RInt32 r_MillisPerSecond;
		public static RSystem.RInt32 RMillisPerSecond
		{
			get
			{
				if(r_MillisPerSecond == null)
				{
					r_MillisPerSecond = new(typeof(System.DateTime), "MillisPerSecond");
					r_MillisPerSecond.SetBelong(null);
				}
				return r_MillisPerSecond;
			}
		}

		/// <summary>
		/// System.Int32 MillisPerMinute
		/// </summary>
		protected static RSystem.RInt32 r_MillisPerMinute;
		public static RSystem.RInt32 RMillisPerMinute
		{
			get
			{
				if(r_MillisPerMinute == null)
				{
					r_MillisPerMinute = new(typeof(System.DateTime), "MillisPerMinute");
					r_MillisPerMinute.SetBelong(null);
				}
				return r_MillisPerMinute;
			}
		}

		/// <summary>
		/// System.Int32 MillisPerHour
		/// </summary>
		protected static RSystem.RInt32 r_MillisPerHour;
		public static RSystem.RInt32 RMillisPerHour
		{
			get
			{
				if(r_MillisPerHour == null)
				{
					r_MillisPerHour = new(typeof(System.DateTime), "MillisPerHour");
					r_MillisPerHour.SetBelong(null);
				}
				return r_MillisPerHour;
			}
		}

		/// <summary>
		/// System.Int32 MillisPerDay
		/// </summary>
		protected static RSystem.RInt32 r_MillisPerDay;
		public static RSystem.RInt32 RMillisPerDay
		{
			get
			{
				if(r_MillisPerDay == null)
				{
					r_MillisPerDay = new(typeof(System.DateTime), "MillisPerDay");
					r_MillisPerDay.SetBelong(null);
				}
				return r_MillisPerDay;
			}
		}

		/// <summary>
		/// System.Int32 DaysPerYear
		/// </summary>
		protected static RSystem.RInt32 r_DaysPerYear;
		public static RSystem.RInt32 RDaysPerYear
		{
			get
			{
				if(r_DaysPerYear == null)
				{
					r_DaysPerYear = new(typeof(System.DateTime), "DaysPerYear");
					r_DaysPerYear.SetBelong(null);
				}
				return r_DaysPerYear;
			}
		}

		/// <summary>
		/// System.Int32 DaysPer4Years
		/// </summary>
		protected static RSystem.RInt32 r_DaysPer4Years;
		public static RSystem.RInt32 RDaysPer4Years
		{
			get
			{
				if(r_DaysPer4Years == null)
				{
					r_DaysPer4Years = new(typeof(System.DateTime), "DaysPer4Years");
					r_DaysPer4Years.SetBelong(null);
				}
				return r_DaysPer4Years;
			}
		}

		/// <summary>
		/// System.Int32 DaysPer100Years
		/// </summary>
		protected static RSystem.RInt32 r_DaysPer100Years;
		public static RSystem.RInt32 RDaysPer100Years
		{
			get
			{
				if(r_DaysPer100Years == null)
				{
					r_DaysPer100Years = new(typeof(System.DateTime), "DaysPer100Years");
					r_DaysPer100Years.SetBelong(null);
				}
				return r_DaysPer100Years;
			}
		}

		/// <summary>
		/// System.Int32 DaysPer400Years
		/// </summary>
		protected static RSystem.RInt32 r_DaysPer400Years;
		public static RSystem.RInt32 RDaysPer400Years
		{
			get
			{
				if(r_DaysPer400Years == null)
				{
					r_DaysPer400Years = new(typeof(System.DateTime), "DaysPer400Years");
					r_DaysPer400Years.SetBelong(null);
				}
				return r_DaysPer400Years;
			}
		}

		/// <summary>
		/// System.Int32 DaysTo1601
		/// </summary>
		protected static RSystem.RInt32 r_DaysTo1601;
		public static RSystem.RInt32 RDaysTo1601
		{
			get
			{
				if(r_DaysTo1601 == null)
				{
					r_DaysTo1601 = new(typeof(System.DateTime), "DaysTo1601");
					r_DaysTo1601.SetBelong(null);
				}
				return r_DaysTo1601;
			}
		}

		/// <summary>
		/// System.Int32 DaysTo1899
		/// </summary>
		protected static RSystem.RInt32 r_DaysTo1899;
		public static RSystem.RInt32 RDaysTo1899
		{
			get
			{
				if(r_DaysTo1899 == null)
				{
					r_DaysTo1899 = new(typeof(System.DateTime), "DaysTo1899");
					r_DaysTo1899.SetBelong(null);
				}
				return r_DaysTo1899;
			}
		}

		/// <summary>
		/// System.Int32 DaysTo1970
		/// </summary>
		protected static RSystem.RInt32 r_DaysTo1970;
		public static RSystem.RInt32 RDaysTo1970
		{
			get
			{
				if(r_DaysTo1970 == null)
				{
					r_DaysTo1970 = new(typeof(System.DateTime), "DaysTo1970");
					r_DaysTo1970.SetBelong(null);
				}
				return r_DaysTo1970;
			}
		}

		/// <summary>
		/// System.Int32 DaysTo10000
		/// </summary>
		protected static RSystem.RInt32 r_DaysTo10000;
		public static RSystem.RInt32 RDaysTo10000
		{
			get
			{
				if(r_DaysTo10000 == null)
				{
					r_DaysTo10000 = new(typeof(System.DateTime), "DaysTo10000");
					r_DaysTo10000.SetBelong(null);
				}
				return r_DaysTo10000;
			}
		}

		/// <summary>
		/// System.Int64 MinTicks
		/// </summary>
		protected static RSystem.RInt64 r_MinTicks;
		public static RSystem.RInt64 RMinTicks
		{
			get
			{
				if(r_MinTicks == null)
				{
					r_MinTicks = new(typeof(System.DateTime), "MinTicks");
					r_MinTicks.SetBelong(null);
				}
				return r_MinTicks;
			}
		}

		/// <summary>
		/// System.Int64 MaxTicks
		/// </summary>
		protected static RSystem.RInt64 r_MaxTicks;
		public static RSystem.RInt64 RMaxTicks
		{
			get
			{
				if(r_MaxTicks == null)
				{
					r_MaxTicks = new(typeof(System.DateTime), "MaxTicks");
					r_MaxTicks.SetBelong(null);
				}
				return r_MaxTicks;
			}
		}

		/// <summary>
		/// System.Int64 MaxMillis
		/// </summary>
		protected static RSystem.RInt64 r_MaxMillis;
		public static RSystem.RInt64 RMaxMillis
		{
			get
			{
				if(r_MaxMillis == null)
				{
					r_MaxMillis = new(typeof(System.DateTime), "MaxMillis");
					r_MaxMillis.SetBelong(null);
				}
				return r_MaxMillis;
			}
		}

		/// <summary>
		/// System.Int64 UnixEpochTicks
		/// </summary>
		protected static RSystem.RInt64 r_UnixEpochTicks;
		public static RSystem.RInt64 RUnixEpochTicks
		{
			get
			{
				if(r_UnixEpochTicks == null)
				{
					r_UnixEpochTicks = new(typeof(System.DateTime), "UnixEpochTicks");
					r_UnixEpochTicks.SetBelong(null);
				}
				return r_UnixEpochTicks;
			}
		}

		/// <summary>
		/// System.Int64 FileTimeOffset
		/// </summary>
		protected static RSystem.RInt64 r_FileTimeOffset;
		public static RSystem.RInt64 RFileTimeOffset
		{
			get
			{
				if(r_FileTimeOffset == null)
				{
					r_FileTimeOffset = new(typeof(System.DateTime), "FileTimeOffset");
					r_FileTimeOffset.SetBelong(null);
				}
				return r_FileTimeOffset;
			}
		}

		/// <summary>
		/// System.Int64 DoubleDateOffset
		/// </summary>
		protected static RSystem.RInt64 r_DoubleDateOffset;
		public static RSystem.RInt64 RDoubleDateOffset
		{
			get
			{
				if(r_DoubleDateOffset == null)
				{
					r_DoubleDateOffset = new(typeof(System.DateTime), "DoubleDateOffset");
					r_DoubleDateOffset.SetBelong(null);
				}
				return r_DoubleDateOffset;
			}
		}

		/// <summary>
		/// System.Int64 OADateMinAsTicks
		/// </summary>
		protected static RSystem.RInt64 r_OADateMinAsTicks;
		public static RSystem.RInt64 ROADateMinAsTicks
		{
			get
			{
				if(r_OADateMinAsTicks == null)
				{
					r_OADateMinAsTicks = new(typeof(System.DateTime), "OADateMinAsTicks");
					r_OADateMinAsTicks.SetBelong(null);
				}
				return r_OADateMinAsTicks;
			}
		}

		/// <summary>
		/// System.Double OADateMinAsDouble
		/// </summary>
		protected static RSystem.RDouble r_OADateMinAsDouble;
		public static RSystem.RDouble ROADateMinAsDouble
		{
			get
			{
				if(r_OADateMinAsDouble == null)
				{
					r_OADateMinAsDouble = new(typeof(System.DateTime), "OADateMinAsDouble");
					r_OADateMinAsDouble.SetBelong(null);
				}
				return r_OADateMinAsDouble;
			}
		}

		/// <summary>
		/// System.Double OADateMaxAsDouble
		/// </summary>
		protected static RSystem.RDouble r_OADateMaxAsDouble;
		public static RSystem.RDouble ROADateMaxAsDouble
		{
			get
			{
				if(r_OADateMaxAsDouble == null)
				{
					r_OADateMaxAsDouble = new(typeof(System.DateTime), "OADateMaxAsDouble");
					r_OADateMaxAsDouble.SetBelong(null);
				}
				return r_OADateMaxAsDouble;
			}
		}

		/// <summary>
		/// System.Int32 DatePartYear
		/// </summary>
		protected static RSystem.RInt32 r_DatePartYear;
		public static RSystem.RInt32 RDatePartYear
		{
			get
			{
				if(r_DatePartYear == null)
				{
					r_DatePartYear = new(typeof(System.DateTime), "DatePartYear");
					r_DatePartYear.SetBelong(null);
				}
				return r_DatePartYear;
			}
		}

		/// <summary>
		/// System.Int32 DatePartDayOfYear
		/// </summary>
		protected static RSystem.RInt32 r_DatePartDayOfYear;
		public static RSystem.RInt32 RDatePartDayOfYear
		{
			get
			{
				if(r_DatePartDayOfYear == null)
				{
					r_DatePartDayOfYear = new(typeof(System.DateTime), "DatePartDayOfYear");
					r_DatePartDayOfYear.SetBelong(null);
				}
				return r_DatePartDayOfYear;
			}
		}

		/// <summary>
		/// System.Int32 DatePartMonth
		/// </summary>
		protected static RSystem.RInt32 r_DatePartMonth;
		public static RSystem.RInt32 RDatePartMonth
		{
			get
			{
				if(r_DatePartMonth == null)
				{
					r_DatePartMonth = new(typeof(System.DateTime), "DatePartMonth");
					r_DatePartMonth.SetBelong(null);
				}
				return r_DatePartMonth;
			}
		}

		/// <summary>
		/// System.Int32 DatePartDay
		/// </summary>
		protected static RSystem.RInt32 r_DatePartDay;
		public static RSystem.RInt32 RDatePartDay
		{
			get
			{
				if(r_DatePartDay == null)
				{
					r_DatePartDay = new(typeof(System.DateTime), "DatePartDay");
					r_DatePartDay.SetBelong(null);
				}
				return r_DatePartDay;
			}
		}

		/// <summary>
		/// System.Int32[] s_daysToMonth365
		/// </summary>
		protected static RFieldArray<RSystem.RInt32> r_s_daysToMonth365;
		public static RFieldArray<RSystem.RInt32> Rs_daysToMonth365
		{
			get
			{
				if(r_s_daysToMonth365 == null)
				{
					r_s_daysToMonth365 = new(typeof(System.DateTime), "s_daysToMonth365");
					r_s_daysToMonth365.SetBelong(null);
				}
				return r_s_daysToMonth365;
			}
		}

		/// <summary>
		/// System.Int32[] s_daysToMonth366
		/// </summary>
		protected static RFieldArray<RSystem.RInt32> r_s_daysToMonth366;
		public static RFieldArray<RSystem.RInt32> Rs_daysToMonth366
		{
			get
			{
				if(r_s_daysToMonth366 == null)
				{
					r_s_daysToMonth366 = new(typeof(System.DateTime), "s_daysToMonth366");
					r_s_daysToMonth366.SetBelong(null);
				}
				return r_s_daysToMonth366;
			}
		}

		/// <summary>
		/// System.DateTime MinValue
		/// </summary>
		protected static RSystem.RDateTime r_MinValue;
		public static RSystem.RDateTime RMinValue
		{
			get
			{
				if(r_MinValue == null)
				{
					r_MinValue = new(typeof(System.DateTime), "MinValue");
					r_MinValue.SetBelong(null);
				}
				return r_MinValue;
			}
		}

		/// <summary>
		/// System.DateTime MaxValue
		/// </summary>
		protected static RSystem.RDateTime r_MaxValue;
		public static RSystem.RDateTime RMaxValue
		{
			get
			{
				if(r_MaxValue == null)
				{
					r_MaxValue = new(typeof(System.DateTime), "MaxValue");
					r_MaxValue.SetBelong(null);
				}
				return r_MaxValue;
			}
		}

		/// <summary>
		/// System.DateTime UnixEpoch
		/// </summary>
		protected static RSystem.RDateTime r_UnixEpoch;
		public static RSystem.RDateTime RUnixEpoch
		{
			get
			{
				if(r_UnixEpoch == null)
				{
					r_UnixEpoch = new(typeof(System.DateTime), "UnixEpoch");
					r_UnixEpoch.SetBelong(null);
				}
				return r_UnixEpoch;
			}
		}

		/// <summary>
		/// System.UInt64 TicksMask
		/// </summary>
		protected static RSystem.RUInt64 r_TicksMask;
		public static RSystem.RUInt64 RTicksMask
		{
			get
			{
				if(r_TicksMask == null)
				{
					r_TicksMask = new(typeof(System.DateTime), "TicksMask");
					r_TicksMask.SetBelong(null);
				}
				return r_TicksMask;
			}
		}

		/// <summary>
		/// System.UInt64 FlagsMask
		/// </summary>
		protected static RSystem.RUInt64 r_FlagsMask;
		public static RSystem.RUInt64 RFlagsMask
		{
			get
			{
				if(r_FlagsMask == null)
				{
					r_FlagsMask = new(typeof(System.DateTime), "FlagsMask");
					r_FlagsMask.SetBelong(null);
				}
				return r_FlagsMask;
			}
		}

		/// <summary>
		/// System.UInt64 LocalMask
		/// </summary>
		protected static RSystem.RUInt64 r_LocalMask;
		public static RSystem.RUInt64 RLocalMask
		{
			get
			{
				if(r_LocalMask == null)
				{
					r_LocalMask = new(typeof(System.DateTime), "LocalMask");
					r_LocalMask.SetBelong(null);
				}
				return r_LocalMask;
			}
		}

		/// <summary>
		/// System.Int64 TicksCeiling
		/// </summary>
		protected static RSystem.RInt64 r_TicksCeiling;
		public static RSystem.RInt64 RTicksCeiling
		{
			get
			{
				if(r_TicksCeiling == null)
				{
					r_TicksCeiling = new(typeof(System.DateTime), "TicksCeiling");
					r_TicksCeiling.SetBelong(null);
				}
				return r_TicksCeiling;
			}
		}

		/// <summary>
		/// System.UInt64 KindUnspecified
		/// </summary>
		protected static RSystem.RUInt64 r_KindUnspecified;
		public static RSystem.RUInt64 RKindUnspecified
		{
			get
			{
				if(r_KindUnspecified == null)
				{
					r_KindUnspecified = new(typeof(System.DateTime), "KindUnspecified");
					r_KindUnspecified.SetBelong(null);
				}
				return r_KindUnspecified;
			}
		}

		/// <summary>
		/// System.UInt64 KindUtc
		/// </summary>
		protected static RSystem.RUInt64 r_KindUtc;
		public static RSystem.RUInt64 RKindUtc
		{
			get
			{
				if(r_KindUtc == null)
				{
					r_KindUtc = new(typeof(System.DateTime), "KindUtc");
					r_KindUtc.SetBelong(null);
				}
				return r_KindUtc;
			}
		}

		/// <summary>
		/// System.UInt64 KindLocal
		/// </summary>
		protected static RSystem.RUInt64 r_KindLocal;
		public static RSystem.RUInt64 RKindLocal
		{
			get
			{
				if(r_KindLocal == null)
				{
					r_KindLocal = new(typeof(System.DateTime), "KindLocal");
					r_KindLocal.SetBelong(null);
				}
				return r_KindLocal;
			}
		}

		/// <summary>
		/// System.UInt64 KindLocalAmbiguousDst
		/// </summary>
		protected static RSystem.RUInt64 r_KindLocalAmbiguousDst;
		public static RSystem.RUInt64 RKindLocalAmbiguousDst
		{
			get
			{
				if(r_KindLocalAmbiguousDst == null)
				{
					r_KindLocalAmbiguousDst = new(typeof(System.DateTime), "KindLocalAmbiguousDst");
					r_KindLocalAmbiguousDst.SetBelong(null);
				}
				return r_KindLocalAmbiguousDst;
			}
		}

		/// <summary>
		/// System.Int32 KindShift
		/// </summary>
		protected static RSystem.RInt32 r_KindShift;
		public static RSystem.RInt32 RKindShift
		{
			get
			{
				if(r_KindShift == null)
				{
					r_KindShift = new(typeof(System.DateTime), "KindShift");
					r_KindShift.SetBelong(null);
				}
				return r_KindShift;
			}
		}

		/// <summary>
		/// System.String TicksField
		/// </summary>
		protected static RSystem.RString r_TicksField;
		public static RSystem.RString RTicksField
		{
			get
			{
				if(r_TicksField == null)
				{
					r_TicksField = new(typeof(System.DateTime), "TicksField");
					r_TicksField.SetBelong(null);
				}
				return r_TicksField;
			}
		}

		/// <summary>
		/// System.String DateDataField
		/// </summary>
		protected static RSystem.RString r_DateDataField;
		public static RSystem.RString RDateDataField
		{
			get
			{
				if(r_DateDataField == null)
				{
					r_DateDataField = new(typeof(System.DateTime), "DateDataField");
					r_DateDataField.SetBelong(null);
				}
				return r_DateDataField;
			}
		}

		/// <summary>
		/// System.UInt64 _dateData
		/// </summary>
		protected RSystem.RUInt64 r__dateData;
		public virtual RSystem.RUInt64 R_dateData
		{
			get
			{
				if(r__dateData == null)
				{
					r__dateData = new(this, "_dateData");
					r__dateData.SetBelong(this.instance);
				}
				return r__dateData;
			}
		}

		/// <summary>
		/// Int64 InternalTicks
		/// </summary>
		protected RSystem.RInt64 r_InternalTicks;
		public virtual RSystem.RInt64 RInternalTicks
		{
			get
			{
				if(r_InternalTicks == null)
				{
					r_InternalTicks = new(this, "InternalTicks", -1);
					r_InternalTicks.SetBelong(this.instance);
				}
				return r_InternalTicks;
			}
		}

		/// <summary>
		/// UInt64 InternalKind
		/// </summary>
		protected RSystem.RUInt64 r_InternalKind;
		public virtual RSystem.RUInt64 RInternalKind
		{
			get
			{
				if(r_InternalKind == null)
				{
					r_InternalKind = new(this, "InternalKind", -1);
					r_InternalKind.SetBelong(this.instance);
				}
				return r_InternalKind;
			}
		}

		/// <summary>
		/// System.DateTime Date
		/// </summary>
		protected RSystem.RDateTime r_Date;
		public virtual RSystem.RDateTime RDate
		{
			get
			{
				if(r_Date == null)
				{
					r_Date = new(this, "Date", -1);
					r_Date.SetBelong(this.instance);
				}
				return r_Date;
			}
		}

		/// <summary>
		/// Int32 Day
		/// </summary>
		protected RSystem.RInt32 r_Day;
		public virtual RSystem.RInt32 RDay
		{
			get
			{
				if(r_Day == null)
				{
					r_Day = new(this, "Day", -1);
					r_Day.SetBelong(this.instance);
				}
				return r_Day;
			}
		}

		/// <summary>
		/// System.DayOfWeek DayOfWeek
		/// </summary>
		protected RProperty r_DayOfWeek;
		public virtual RProperty RDayOfWeek
		{
			get
			{
				if(r_DayOfWeek == null)
				{
					r_DayOfWeek = new(this, "DayOfWeek", -1);
					r_DayOfWeek.SetBelong(this.instance);
				}
				return r_DayOfWeek;
			}
		}

		/// <summary>
		/// Int32 DayOfYear
		/// </summary>
		protected RSystem.RInt32 r_DayOfYear;
		public virtual RSystem.RInt32 RDayOfYear
		{
			get
			{
				if(r_DayOfYear == null)
				{
					r_DayOfYear = new(this, "DayOfYear", -1);
					r_DayOfYear.SetBelong(this.instance);
				}
				return r_DayOfYear;
			}
		}

		/// <summary>
		/// Int32 Hour
		/// </summary>
		protected RSystem.RInt32 r_Hour;
		public virtual RSystem.RInt32 RHour
		{
			get
			{
				if(r_Hour == null)
				{
					r_Hour = new(this, "Hour", -1);
					r_Hour.SetBelong(this.instance);
				}
				return r_Hour;
			}
		}

		/// <summary>
		/// System.DateTimeKind Kind
		/// </summary>
		protected RProperty r_Kind;
		public virtual RProperty RKind
		{
			get
			{
				if(r_Kind == null)
				{
					r_Kind = new(this, "Kind", -1);
					r_Kind.SetBelong(this.instance);
				}
				return r_Kind;
			}
		}

		/// <summary>
		/// Int32 Millisecond
		/// </summary>
		protected RSystem.RInt32 r_Millisecond;
		public virtual RSystem.RInt32 RMillisecond
		{
			get
			{
				if(r_Millisecond == null)
				{
					r_Millisecond = new(this, "Millisecond", -1);
					r_Millisecond.SetBelong(this.instance);
				}
				return r_Millisecond;
			}
		}

		/// <summary>
		/// Int32 Minute
		/// </summary>
		protected RSystem.RInt32 r_Minute;
		public virtual RSystem.RInt32 RMinute
		{
			get
			{
				if(r_Minute == null)
				{
					r_Minute = new(this, "Minute", -1);
					r_Minute.SetBelong(this.instance);
				}
				return r_Minute;
			}
		}

		/// <summary>
		/// Int32 Month
		/// </summary>
		protected RSystem.RInt32 r_Month;
		public virtual RSystem.RInt32 RMonth
		{
			get
			{
				if(r_Month == null)
				{
					r_Month = new(this, "Month", -1);
					r_Month.SetBelong(this.instance);
				}
				return r_Month;
			}
		}

		/// <summary>
		/// System.DateTime Now
		/// </summary>
		protected static RSystem.RDateTime r_Now;
		public static RSystem.RDateTime RNow
		{
			get
			{
				if(r_Now == null)
				{
					r_Now = new(typeof(System.DateTime), "Now", -1);
					r_Now.SetBelong(null);
				}
				return r_Now;
			}
		}

		/// <summary>
		/// Int32 Second
		/// </summary>
		protected RSystem.RInt32 r_Second;
		public virtual RSystem.RInt32 RSecond
		{
			get
			{
				if(r_Second == null)
				{
					r_Second = new(this, "Second", -1);
					r_Second.SetBelong(this.instance);
				}
				return r_Second;
			}
		}

		/// <summary>
		/// Int64 Ticks
		/// </summary>
		protected RSystem.RInt64 r_Ticks;
		public virtual RSystem.RInt64 RTicks
		{
			get
			{
				if(r_Ticks == null)
				{
					r_Ticks = new(this, "Ticks", -1);
					r_Ticks.SetBelong(this.instance);
				}
				return r_Ticks;
			}
		}

		/// <summary>
		/// System.TimeSpan TimeOfDay
		/// </summary>
		protected RSystem.RTimeSpan r_TimeOfDay;
		public virtual RSystem.RTimeSpan RTimeOfDay
		{
			get
			{
				if(r_TimeOfDay == null)
				{
					r_TimeOfDay = new(this, "TimeOfDay", -1);
					r_TimeOfDay.SetBelong(this.instance);
				}
				return r_TimeOfDay;
			}
		}

		/// <summary>
		/// System.DateTime Today
		/// </summary>
		protected static RSystem.RDateTime r_Today;
		public static RSystem.RDateTime RToday
		{
			get
			{
				if(r_Today == null)
				{
					r_Today = new(typeof(System.DateTime), "Today", -1);
					r_Today.SetBelong(null);
				}
				return r_Today;
			}
		}

		/// <summary>
		/// Int32 Year
		/// </summary>
		protected RSystem.RInt32 r_Year;
		public virtual RSystem.RInt32 RYear
		{
			get
			{
				if(r_Year == null)
				{
					r_Year = new(this, "Year", -1);
					r_Year.SetBelong(this.instance);
				}
				return r_Year;
			}
		}

		/// <summary>
		/// System.DateTime UtcNow
		/// </summary>
		protected static RSystem.RDateTime r_UtcNow;
		public static RSystem.RDateTime RUtcNow
		{
			get
			{
				if(r_UtcNow == null)
				{
					r_UtcNow = new(typeof(System.DateTime), "UtcNow", -1);
					r_UtcNow.SetBelong(null);
				}
				return r_UtcNow;
			}
		}

		/// <summary>
		/// System.DateTime Add(System.TimeSpan)
		/// </summary>
		protected RMethod r_Add_TimeSpan;
		public virtual RMethod RAdd_TimeSpan
		{
			get
			{
				if(r_Add_TimeSpan == null)
				{
					r_Add_TimeSpan = new(this, "Add", 0, typeof(System.TimeSpan));
					r_Add_TimeSpan.SetBelong(this.instance);
				}
				return r_Add_TimeSpan;
			}
		}

		/// <summary>
		/// System.DateTime Add(Double, Int32)
		/// </summary>
		protected RMethod r_Add_Double_Int32;
		public virtual RMethod RAdd_Double_Int32
		{
			get
			{
				if(r_Add_Double_Int32 == null)
				{
					r_Add_Double_Int32 = new(this, "Add", 0, typeof(System.Double), typeof(System.Int32));
					r_Add_Double_Int32.SetBelong(this.instance);
				}
				return r_Add_Double_Int32;
			}
		}

		/// <summary>
		/// System.DateTime AddDays(Double)
		/// </summary>
		protected RMethod r_AddDays_Double;
		public virtual RMethod RAddDays_Double
		{
			get
			{
				if(r_AddDays_Double == null)
				{
					r_AddDays_Double = new(this, "AddDays", 0, typeof(System.Double));
					r_AddDays_Double.SetBelong(this.instance);
				}
				return r_AddDays_Double;
			}
		}

		/// <summary>
		/// System.DateTime AddHours(Double)
		/// </summary>
		protected RMethod r_AddHours_Double;
		public virtual RMethod RAddHours_Double
		{
			get
			{
				if(r_AddHours_Double == null)
				{
					r_AddHours_Double = new(this, "AddHours", 0, typeof(System.Double));
					r_AddHours_Double.SetBelong(this.instance);
				}
				return r_AddHours_Double;
			}
		}

		/// <summary>
		/// System.DateTime AddMilliseconds(Double)
		/// </summary>
		protected RMethod r_AddMilliseconds_Double;
		public virtual RMethod RAddMilliseconds_Double
		{
			get
			{
				if(r_AddMilliseconds_Double == null)
				{
					r_AddMilliseconds_Double = new(this, "AddMilliseconds", 0, typeof(System.Double));
					r_AddMilliseconds_Double.SetBelong(this.instance);
				}
				return r_AddMilliseconds_Double;
			}
		}

		/// <summary>
		/// System.DateTime AddMinutes(Double)
		/// </summary>
		protected RMethod r_AddMinutes_Double;
		public virtual RMethod RAddMinutes_Double
		{
			get
			{
				if(r_AddMinutes_Double == null)
				{
					r_AddMinutes_Double = new(this, "AddMinutes", 0, typeof(System.Double));
					r_AddMinutes_Double.SetBelong(this.instance);
				}
				return r_AddMinutes_Double;
			}
		}

		/// <summary>
		/// System.DateTime AddMonths(Int32)
		/// </summary>
		protected RMethod r_AddMonths_Int32;
		public virtual RMethod RAddMonths_Int32
		{
			get
			{
				if(r_AddMonths_Int32 == null)
				{
					r_AddMonths_Int32 = new(this, "AddMonths", 0, typeof(System.Int32));
					r_AddMonths_Int32.SetBelong(this.instance);
				}
				return r_AddMonths_Int32;
			}
		}

		/// <summary>
		/// System.DateTime AddSeconds(Double)
		/// </summary>
		protected RMethod r_AddSeconds_Double;
		public virtual RMethod RAddSeconds_Double
		{
			get
			{
				if(r_AddSeconds_Double == null)
				{
					r_AddSeconds_Double = new(this, "AddSeconds", 0, typeof(System.Double));
					r_AddSeconds_Double.SetBelong(this.instance);
				}
				return r_AddSeconds_Double;
			}
		}

		/// <summary>
		/// System.DateTime AddTicks(Int64)
		/// </summary>
		protected RMethod r_AddTicks_Int64;
		public virtual RMethod RAddTicks_Int64
		{
			get
			{
				if(r_AddTicks_Int64 == null)
				{
					r_AddTicks_Int64 = new(this, "AddTicks", 0, typeof(System.Int64));
					r_AddTicks_Int64.SetBelong(this.instance);
				}
				return r_AddTicks_Int64;
			}
		}

		/// <summary>
		/// System.DateTime AddYears(Int32)
		/// </summary>
		protected RMethod r_AddYears_Int32;
		public virtual RMethod RAddYears_Int32
		{
			get
			{
				if(r_AddYears_Int32 == null)
				{
					r_AddYears_Int32 = new(this, "AddYears", 0, typeof(System.Int32));
					r_AddYears_Int32.SetBelong(this.instance);
				}
				return r_AddYears_Int32;
			}
		}

		/// <summary>
		/// Int32 Compare(System.DateTime, System.DateTime)
		/// </summary>
		protected static RMethod r_Compare_DateTime_DateTime;
		public static RMethod RCompare_DateTime_DateTime
		{
			get
			{
				if(r_Compare_DateTime_DateTime == null)
				{
					r_Compare_DateTime_DateTime = new(typeof(System.DateTime), "Compare", 0, typeof(System.DateTime), typeof(System.DateTime));
					r_Compare_DateTime_DateTime.SetBelong(null);
				}
				return r_Compare_DateTime_DateTime;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Object)
		/// </summary>
		protected RMethod r_CompareTo_Object;
		public virtual RMethod RCompareTo_Object
		{
			get
			{
				if(r_CompareTo_Object == null)
				{
					r_CompareTo_Object = new(this, "CompareTo", 0, typeof(System.Object));
					r_CompareTo_Object.SetBelong(this.instance);
				}
				return r_CompareTo_Object;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.DateTime)
		/// </summary>
		protected RMethod r_CompareTo_DateTime;
		public virtual RMethod RCompareTo_DateTime
		{
			get
			{
				if(r_CompareTo_DateTime == null)
				{
					r_CompareTo_DateTime = new(this, "CompareTo", 0, typeof(System.DateTime));
					r_CompareTo_DateTime.SetBelong(this.instance);
				}
				return r_CompareTo_DateTime;
			}
		}

		/// <summary>
		/// Int64 DateToTicks(Int32, Int32, Int32)
		/// </summary>
		protected static RMethod r_DateToTicks_Int32_Int32_Int32;
		public static RMethod RDateToTicks_Int32_Int32_Int32
		{
			get
			{
				if(r_DateToTicks_Int32_Int32_Int32 == null)
				{
					r_DateToTicks_Int32_Int32_Int32 = new(typeof(System.DateTime), "DateToTicks", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_DateToTicks_Int32_Int32_Int32.SetBelong(null);
				}
				return r_DateToTicks_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Int64 TimeToTicks(Int32, Int32, Int32)
		/// </summary>
		protected static RMethod r_TimeToTicks_Int32_Int32_Int32;
		public static RMethod RTimeToTicks_Int32_Int32_Int32
		{
			get
			{
				if(r_TimeToTicks_Int32_Int32_Int32 == null)
				{
					r_TimeToTicks_Int32_Int32_Int32 = new(typeof(System.DateTime), "TimeToTicks", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_TimeToTicks_Int32_Int32_Int32.SetBelong(null);
				}
				return r_TimeToTicks_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 DaysInMonth(Int32, Int32)
		/// </summary>
		protected static RMethod r_DaysInMonth_Int32_Int32;
		public static RMethod RDaysInMonth_Int32_Int32
		{
			get
			{
				if(r_DaysInMonth_Int32_Int32 == null)
				{
					r_DaysInMonth_Int32_Int32 = new(typeof(System.DateTime), "DaysInMonth", 0, typeof(System.Int32), typeof(System.Int32));
					r_DaysInMonth_Int32_Int32.SetBelong(null);
				}
				return r_DaysInMonth_Int32_Int32;
			}
		}

		/// <summary>
		/// Int64 DoubleDateToTicks(Double)
		/// </summary>
		protected static RMethod r_DoubleDateToTicks_Double;
		public static RMethod RDoubleDateToTicks_Double
		{
			get
			{
				if(r_DoubleDateToTicks_Double == null)
				{
					r_DoubleDateToTicks_Double = new(typeof(System.DateTime), "DoubleDateToTicks", 0, typeof(System.Double));
					r_DoubleDateToTicks_Double.SetBelong(null);
				}
				return r_DoubleDateToTicks_Double;
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
		/// Boolean Equals(System.DateTime)
		/// </summary>
		protected RMethod r_Equals_DateTime;
		public virtual RMethod REquals_DateTime
		{
			get
			{
				if(r_Equals_DateTime == null)
				{
					r_Equals_DateTime = new(this, "Equals", 0, typeof(System.DateTime));
					r_Equals_DateTime.SetBelong(this.instance);
				}
				return r_Equals_DateTime;
			}
		}

		/// <summary>
		/// Boolean Equals(System.DateTime, System.DateTime)
		/// </summary>
		protected static RMethod r_Equals_DateTime_DateTime;
		public static RMethod REquals_DateTime_DateTime
		{
			get
			{
				if(r_Equals_DateTime_DateTime == null)
				{
					r_Equals_DateTime_DateTime = new(typeof(System.DateTime), "Equals", 0, typeof(System.DateTime), typeof(System.DateTime));
					r_Equals_DateTime_DateTime.SetBelong(null);
				}
				return r_Equals_DateTime_DateTime;
			}
		}

		/// <summary>
		/// System.DateTime FromBinary(Int64)
		/// </summary>
		protected static RMethod r_FromBinary_Int64;
		public static RMethod RFromBinary_Int64
		{
			get
			{
				if(r_FromBinary_Int64 == null)
				{
					r_FromBinary_Int64 = new(typeof(System.DateTime), "FromBinary", 0, typeof(System.Int64));
					r_FromBinary_Int64.SetBelong(null);
				}
				return r_FromBinary_Int64;
			}
		}

		/// <summary>
		/// System.DateTime FromBinaryRaw(Int64)
		/// </summary>
		protected static RMethod r_FromBinaryRaw_Int64;
		public static RMethod RFromBinaryRaw_Int64
		{
			get
			{
				if(r_FromBinaryRaw_Int64 == null)
				{
					r_FromBinaryRaw_Int64 = new(typeof(System.DateTime), "FromBinaryRaw", 0, typeof(System.Int64));
					r_FromBinaryRaw_Int64.SetBelong(null);
				}
				return r_FromBinaryRaw_Int64;
			}
		}

		/// <summary>
		/// System.DateTime FromFileTime(Int64)
		/// </summary>
		protected static RMethod r_FromFileTime_Int64;
		public static RMethod RFromFileTime_Int64
		{
			get
			{
				if(r_FromFileTime_Int64 == null)
				{
					r_FromFileTime_Int64 = new(typeof(System.DateTime), "FromFileTime", 0, typeof(System.Int64));
					r_FromFileTime_Int64.SetBelong(null);
				}
				return r_FromFileTime_Int64;
			}
		}

		/// <summary>
		/// System.DateTime FromFileTimeUtc(Int64)
		/// </summary>
		protected static RMethod r_FromFileTimeUtc_Int64;
		public static RMethod RFromFileTimeUtc_Int64
		{
			get
			{
				if(r_FromFileTimeUtc_Int64 == null)
				{
					r_FromFileTimeUtc_Int64 = new(typeof(System.DateTime), "FromFileTimeUtc", 0, typeof(System.Int64));
					r_FromFileTimeUtc_Int64.SetBelong(null);
				}
				return r_FromFileTimeUtc_Int64;
			}
		}

		/// <summary>
		/// System.DateTime FromOADate(Double)
		/// </summary>
		protected static RMethod r_FromOADate_Double;
		public static RMethod RFromOADate_Double
		{
			get
			{
				if(r_FromOADate_Double == null)
				{
					r_FromOADate_Double = new(typeof(System.DateTime), "FromOADate", 0, typeof(System.Double));
					r_FromOADate_Double.SetBelong(null);
				}
				return r_FromOADate_Double;
			}
		}

		/// <summary>
		/// Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext = new(this, "System.Runtime.Serialization.ISerializable.GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// Boolean IsDaylightSavingTime()
		/// </summary>
		protected RMethod r_IsDaylightSavingTime;
		public virtual RMethod RIsDaylightSavingTime
		{
			get
			{
				if(r_IsDaylightSavingTime == null)
				{
					r_IsDaylightSavingTime = new(this, "IsDaylightSavingTime", 0);
					r_IsDaylightSavingTime.SetBelong(this.instance);
				}
				return r_IsDaylightSavingTime;
			}
		}

		/// <summary>
		/// System.DateTime SpecifyKind(System.DateTime, System.DateTimeKind)
		/// </summary>
		protected static RMethod r_SpecifyKind_DateTime_DateTimeKind;
		public static RMethod RSpecifyKind_DateTime_DateTimeKind
		{
			get
			{
				if(r_SpecifyKind_DateTime_DateTimeKind == null)
				{
					r_SpecifyKind_DateTime_DateTimeKind = new(typeof(System.DateTime), "SpecifyKind", 0, typeof(System.DateTime), typeof(System.DateTimeKind));
					r_SpecifyKind_DateTime_DateTimeKind.SetBelong(null);
				}
				return r_SpecifyKind_DateTime_DateTimeKind;
			}
		}

		/// <summary>
		/// Int64 ToBinary()
		/// </summary>
		protected RMethod r_ToBinary;
		public virtual RMethod RToBinary
		{
			get
			{
				if(r_ToBinary == null)
				{
					r_ToBinary = new(this, "ToBinary", 0);
					r_ToBinary.SetBelong(this.instance);
				}
				return r_ToBinary;
			}
		}

		/// <summary>
		/// Int32 GetDatePart(Int32)
		/// </summary>
		protected RMethod r_GetDatePart_Int32;
		public virtual RMethod RGetDatePart_Int32
		{
			get
			{
				if(r_GetDatePart_Int32 == null)
				{
					r_GetDatePart_Int32 = new(this, "GetDatePart", 0, typeof(System.Int32));
					r_GetDatePart_Int32.SetBelong(this.instance);
				}
				return r_GetDatePart_Int32;
			}
		}

		/// <summary>
		/// Void GetDatePart(Int32 ByRef, Int32 ByRef, Int32 ByRef)
		/// </summary>
		protected RMethod r_GetDatePart_Out_Int32_Out_Int32_Out_Int32;
		public virtual RMethod RGetDatePart_Out_Int32_Out_Int32_Out_Int32
		{
			get
			{
				if(r_GetDatePart_Out_Int32_Out_Int32_Out_Int32 == null)
				{
					r_GetDatePart_Out_Int32_Out_Int32_Out_Int32 = new(this, "GetDatePart", 0, typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_GetDatePart_Out_Int32_Out_Int32_Out_Int32.SetBelong(this.instance);
				}
				return r_GetDatePart_Out_Int32_Out_Int32_Out_Int32;
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
		/// Boolean IsAmbiguousDaylightSavingTime()
		/// </summary>
		protected RMethod r_IsAmbiguousDaylightSavingTime;
		public virtual RMethod RIsAmbiguousDaylightSavingTime
		{
			get
			{
				if(r_IsAmbiguousDaylightSavingTime == null)
				{
					r_IsAmbiguousDaylightSavingTime = new(this, "IsAmbiguousDaylightSavingTime", 0);
					r_IsAmbiguousDaylightSavingTime.SetBelong(this.instance);
				}
				return r_IsAmbiguousDaylightSavingTime;
			}
		}

		/// <summary>
		/// Boolean IsLeapYear(Int32)
		/// </summary>
		protected static RMethod r_IsLeapYear_Int32;
		public static RMethod RIsLeapYear_Int32
		{
			get
			{
				if(r_IsLeapYear_Int32 == null)
				{
					r_IsLeapYear_Int32 = new(typeof(System.DateTime), "IsLeapYear", 0, typeof(System.Int32));
					r_IsLeapYear_Int32.SetBelong(null);
				}
				return r_IsLeapYear_Int32;
			}
		}

		/// <summary>
		/// System.DateTime Parse(System.String)
		/// </summary>
		protected static RMethod r_Parse_String;
		public static RMethod RParse_String
		{
			get
			{
				if(r_Parse_String == null)
				{
					r_Parse_String = new(typeof(System.DateTime), "Parse", 0, typeof(System.String));
					r_Parse_String.SetBelong(null);
				}
				return r_Parse_String;
			}
		}

		/// <summary>
		/// System.DateTime Parse(System.String, System.IFormatProvider)
		/// </summary>
		protected static RMethod r_Parse_String_IFormatProvider;
		public static RMethod RParse_String_IFormatProvider
		{
			get
			{
				if(r_Parse_String_IFormatProvider == null)
				{
					r_Parse_String_IFormatProvider = new(typeof(System.DateTime), "Parse", 0, typeof(System.String), typeof(System.IFormatProvider));
					r_Parse_String_IFormatProvider.SetBelong(null);
				}
				return r_Parse_String_IFormatProvider;
			}
		}

		/// <summary>
		/// System.DateTime Parse(System.String, System.IFormatProvider, System.Globalization.DateTimeStyles)
		/// </summary>
		protected static RMethod r_Parse_String_IFormatProvider_DateTimeStyles;
		public static RMethod RParse_String_IFormatProvider_DateTimeStyles
		{
			get
			{
				if(r_Parse_String_IFormatProvider_DateTimeStyles == null)
				{
					r_Parse_String_IFormatProvider_DateTimeStyles = new(typeof(System.DateTime), "Parse", 0, typeof(System.String), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles));
					r_Parse_String_IFormatProvider_DateTimeStyles.SetBelong(null);
				}
				return r_Parse_String_IFormatProvider_DateTimeStyles;
			}
		}

		/// <summary>
		/// System.DateTime Parse(System.ReadOnlySpan`1[System.Char], System.IFormatProvider, System.Globalization.DateTimeStyles)
		/// </summary>
		protected static RMethod r_Parse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles;
		public static RMethod RParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles
		{
			get
			{
				if(r_Parse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles == null)
				{
					r_Parse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles = new(typeof(System.DateTime), "Parse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles));
					r_Parse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles.SetBelong(null);
				}
				return r_Parse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles;
			}
		}

		/// <summary>
		/// System.DateTime ParseExact(System.String, System.String, System.IFormatProvider)
		/// </summary>
		protected static RMethod r_ParseExact_String_String_IFormatProvider;
		public static RMethod RParseExact_String_String_IFormatProvider
		{
			get
			{
				if(r_ParseExact_String_String_IFormatProvider == null)
				{
					r_ParseExact_String_String_IFormatProvider = new(typeof(System.DateTime), "ParseExact", 0, typeof(System.String), typeof(System.String), typeof(System.IFormatProvider));
					r_ParseExact_String_String_IFormatProvider.SetBelong(null);
				}
				return r_ParseExact_String_String_IFormatProvider;
			}
		}

		/// <summary>
		/// System.DateTime ParseExact(System.String, System.String, System.IFormatProvider, System.Globalization.DateTimeStyles)
		/// </summary>
		protected static RMethod r_ParseExact_String_String_IFormatProvider_DateTimeStyles;
		public static RMethod RParseExact_String_String_IFormatProvider_DateTimeStyles
		{
			get
			{
				if(r_ParseExact_String_String_IFormatProvider_DateTimeStyles == null)
				{
					r_ParseExact_String_String_IFormatProvider_DateTimeStyles = new(typeof(System.DateTime), "ParseExact", 0, typeof(System.String), typeof(System.String), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles));
					r_ParseExact_String_String_IFormatProvider_DateTimeStyles.SetBelong(null);
				}
				return r_ParseExact_String_String_IFormatProvider_DateTimeStyles;
			}
		}

		/// <summary>
		/// System.DateTime ParseExact(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.IFormatProvider, System.Globalization.DateTimeStyles)
		/// </summary>
		protected static RMethod r_ParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles;
		public static RMethod RParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles
		{
			get
			{
				if(r_ParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles == null)
				{
					r_ParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles = new(typeof(System.DateTime), "ParseExact", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles));
					r_ParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles.SetBelong(null);
				}
				return r_ParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles;
			}
		}

		/// <summary>
		/// System.DateTime ParseExact(System.String, System.String[], System.IFormatProvider, System.Globalization.DateTimeStyles)
		/// </summary>
		protected static RMethod r_ParseExact_String_StringArray_IFormatProvider_DateTimeStyles;
		public static RMethod RParseExact_String_StringArray_IFormatProvider_DateTimeStyles
		{
			get
			{
				if(r_ParseExact_String_StringArray_IFormatProvider_DateTimeStyles == null)
				{
					r_ParseExact_String_StringArray_IFormatProvider_DateTimeStyles = new(typeof(System.DateTime), "ParseExact", 0, typeof(System.String), typeof(System.String).MakeArrayType(), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles));
					r_ParseExact_String_StringArray_IFormatProvider_DateTimeStyles.SetBelong(null);
				}
				return r_ParseExact_String_StringArray_IFormatProvider_DateTimeStyles;
			}
		}

		/// <summary>
		/// System.DateTime ParseExact(System.ReadOnlySpan`1[System.Char], System.String[], System.IFormatProvider, System.Globalization.DateTimeStyles)
		/// </summary>
		protected static RMethod r_ParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles;
		public static RMethod RParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles
		{
			get
			{
				if(r_ParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles == null)
				{
					r_ParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles = new(typeof(System.DateTime), "ParseExact", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.String).MakeArrayType(), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles));
					r_ParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles.SetBelong(null);
				}
				return r_ParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles;
			}
		}

		/// <summary>
		/// System.TimeSpan Subtract(System.DateTime)
		/// </summary>
		protected RMethod r_Subtract_DateTime;
		public virtual RMethod RSubtract_DateTime
		{
			get
			{
				if(r_Subtract_DateTime == null)
				{
					r_Subtract_DateTime = new(this, "Subtract", 0, typeof(System.DateTime));
					r_Subtract_DateTime.SetBelong(this.instance);
				}
				return r_Subtract_DateTime;
			}
		}

		/// <summary>
		/// System.DateTime Subtract(System.TimeSpan)
		/// </summary>
		protected RMethod r_Subtract_TimeSpan;
		public virtual RMethod RSubtract_TimeSpan
		{
			get
			{
				if(r_Subtract_TimeSpan == null)
				{
					r_Subtract_TimeSpan = new(this, "Subtract", 0, typeof(System.TimeSpan));
					r_Subtract_TimeSpan.SetBelong(this.instance);
				}
				return r_Subtract_TimeSpan;
			}
		}

		/// <summary>
		/// Double TicksToOADate(Int64)
		/// </summary>
		protected static RMethod r_TicksToOADate_Int64;
		public static RMethod RTicksToOADate_Int64
		{
			get
			{
				if(r_TicksToOADate_Int64 == null)
				{
					r_TicksToOADate_Int64 = new(typeof(System.DateTime), "TicksToOADate", 0, typeof(System.Int64));
					r_TicksToOADate_Int64.SetBelong(null);
				}
				return r_TicksToOADate_Int64;
			}
		}

		/// <summary>
		/// Double ToOADate()
		/// </summary>
		protected RMethod r_ToOADate;
		public virtual RMethod RToOADate
		{
			get
			{
				if(r_ToOADate == null)
				{
					r_ToOADate = new(this, "ToOADate", 0);
					r_ToOADate.SetBelong(this.instance);
				}
				return r_ToOADate;
			}
		}

		/// <summary>
		/// Int64 ToFileTime()
		/// </summary>
		protected RMethod r_ToFileTime;
		public virtual RMethod RToFileTime
		{
			get
			{
				if(r_ToFileTime == null)
				{
					r_ToFileTime = new(this, "ToFileTime", 0);
					r_ToFileTime.SetBelong(this.instance);
				}
				return r_ToFileTime;
			}
		}

		/// <summary>
		/// Int64 ToFileTimeUtc()
		/// </summary>
		protected RMethod r_ToFileTimeUtc;
		public virtual RMethod RToFileTimeUtc
		{
			get
			{
				if(r_ToFileTimeUtc == null)
				{
					r_ToFileTimeUtc = new(this, "ToFileTimeUtc", 0);
					r_ToFileTimeUtc.SetBelong(this.instance);
				}
				return r_ToFileTimeUtc;
			}
		}

		/// <summary>
		/// System.DateTime ToLocalTime()
		/// </summary>
		protected RMethod r_ToLocalTime;
		public virtual RMethod RToLocalTime
		{
			get
			{
				if(r_ToLocalTime == null)
				{
					r_ToLocalTime = new(this, "ToLocalTime", 0);
					r_ToLocalTime.SetBelong(this.instance);
				}
				return r_ToLocalTime;
			}
		}

		/// <summary>
		/// System.DateTime ToLocalTime(Boolean)
		/// </summary>
		protected RMethod r_ToLocalTime_Boolean;
		public virtual RMethod RToLocalTime_Boolean
		{
			get
			{
				if(r_ToLocalTime_Boolean == null)
				{
					r_ToLocalTime_Boolean = new(this, "ToLocalTime", 0, typeof(System.Boolean));
					r_ToLocalTime_Boolean.SetBelong(this.instance);
				}
				return r_ToLocalTime_Boolean;
			}
		}

		/// <summary>
		/// System.String ToLongDateString()
		/// </summary>
		protected RMethod r_ToLongDateString;
		public virtual RMethod RToLongDateString
		{
			get
			{
				if(r_ToLongDateString == null)
				{
					r_ToLongDateString = new(this, "ToLongDateString", 0);
					r_ToLongDateString.SetBelong(this.instance);
				}
				return r_ToLongDateString;
			}
		}

		/// <summary>
		/// System.String ToLongTimeString()
		/// </summary>
		protected RMethod r_ToLongTimeString;
		public virtual RMethod RToLongTimeString
		{
			get
			{
				if(r_ToLongTimeString == null)
				{
					r_ToLongTimeString = new(this, "ToLongTimeString", 0);
					r_ToLongTimeString.SetBelong(this.instance);
				}
				return r_ToLongTimeString;
			}
		}

		/// <summary>
		/// System.String ToShortDateString()
		/// </summary>
		protected RMethod r_ToShortDateString;
		public virtual RMethod RToShortDateString
		{
			get
			{
				if(r_ToShortDateString == null)
				{
					r_ToShortDateString = new(this, "ToShortDateString", 0);
					r_ToShortDateString.SetBelong(this.instance);
				}
				return r_ToShortDateString;
			}
		}

		/// <summary>
		/// System.String ToShortTimeString()
		/// </summary>
		protected RMethod r_ToShortTimeString;
		public virtual RMethod RToShortTimeString
		{
			get
			{
				if(r_ToShortTimeString == null)
				{
					r_ToShortTimeString = new(this, "ToShortTimeString", 0);
					r_ToShortTimeString.SetBelong(this.instance);
				}
				return r_ToShortTimeString;
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

		/// <summary>
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_ToString_String;
		public virtual RMethod RToString_String
		{
			get
			{
				if(r_ToString_String == null)
				{
					r_ToString_String = new(this, "ToString", 0, typeof(System.String));
					r_ToString_String.SetBelong(this.instance);
				}
				return r_ToString_String;
			}
		}

		/// <summary>
		/// System.String ToString(System.IFormatProvider)
		/// </summary>
		protected RMethod r_ToString_IFormatProvider;
		public virtual RMethod RToString_IFormatProvider
		{
			get
			{
				if(r_ToString_IFormatProvider == null)
				{
					r_ToString_IFormatProvider = new(this, "ToString", 0, typeof(System.IFormatProvider));
					r_ToString_IFormatProvider.SetBelong(this.instance);
				}
				return r_ToString_IFormatProvider;
			}
		}

		/// <summary>
		/// System.String ToString(System.String, System.IFormatProvider)
		/// </summary>
		protected RMethod r_ToString_String_IFormatProvider;
		public virtual RMethod RToString_String_IFormatProvider
		{
			get
			{
				if(r_ToString_String_IFormatProvider == null)
				{
					r_ToString_String_IFormatProvider = new(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
					r_ToString_String_IFormatProvider.SetBelong(this.instance);
				}
				return r_ToString_String_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean TryFormat(System.Span`1[System.Char], Int32 ByRef, System.ReadOnlySpan`1[System.Char], System.IFormatProvider)
		/// </summary>
		protected RMethod r_TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider;
		public virtual RMethod RTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider
		{
			get
			{
				if(r_TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider == null)
				{
					r_TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider = new(this, "TryFormat", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Char)), typeof(System.Int32).MakeByRefType(), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider));
					r_TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider.SetBelong(this.instance);
				}
				return r_TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider;
			}
		}

		/// <summary>
		/// System.DateTime ToUniversalTime()
		/// </summary>
		protected RMethod r_ToUniversalTime;
		public virtual RMethod RToUniversalTime
		{
			get
			{
				if(r_ToUniversalTime == null)
				{
					r_ToUniversalTime = new(this, "ToUniversalTime", 0);
					r_ToUniversalTime.SetBelong(this.instance);
				}
				return r_ToUniversalTime;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.String, System.DateTime ByRef)
		/// </summary>
		protected static RMethod r_TryParse_String_Out_DateTime;
		public static RMethod RTryParse_String_Out_DateTime
		{
			get
			{
				if(r_TryParse_String_Out_DateTime == null)
				{
					r_TryParse_String_Out_DateTime = new(typeof(System.DateTime), "TryParse", 0, typeof(System.String), typeof(System.DateTime).MakeByRefType());
					r_TryParse_String_Out_DateTime.SetBelong(null);
				}
				return r_TryParse_String_Out_DateTime;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], System.DateTime ByRef)
		/// </summary>
		protected static RMethod r_TryParse_ReadOnlySpan_d_Char_p__Out_DateTime;
		public static RMethod RTryParse_ReadOnlySpan_d_Char_p__Out_DateTime
		{
			get
			{
				if(r_TryParse_ReadOnlySpan_d_Char_p__Out_DateTime == null)
				{
					r_TryParse_ReadOnlySpan_d_Char_p__Out_DateTime = new(typeof(System.DateTime), "TryParse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.DateTime).MakeByRefType());
					r_TryParse_ReadOnlySpan_d_Char_p__Out_DateTime.SetBelong(null);
				}
				return r_TryParse_ReadOnlySpan_d_Char_p__Out_DateTime;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.String, System.IFormatProvider, System.Globalization.DateTimeStyles, System.DateTime ByRef)
		/// </summary>
		protected static RMethod r_TryParse_String_IFormatProvider_DateTimeStyles_Out_DateTime;
		public static RMethod RTryParse_String_IFormatProvider_DateTimeStyles_Out_DateTime
		{
			get
			{
				if(r_TryParse_String_IFormatProvider_DateTimeStyles_Out_DateTime == null)
				{
					r_TryParse_String_IFormatProvider_DateTimeStyles_Out_DateTime = new(typeof(System.DateTime), "TryParse", 0, typeof(System.String), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles), typeof(System.DateTime).MakeByRefType());
					r_TryParse_String_IFormatProvider_DateTimeStyles_Out_DateTime.SetBelong(null);
				}
				return r_TryParse_String_IFormatProvider_DateTimeStyles_Out_DateTime;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], System.IFormatProvider, System.Globalization.DateTimeStyles, System.DateTime ByRef)
		/// </summary>
		protected static RMethod r_TryParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTime;
		public static RMethod RTryParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTime
		{
			get
			{
				if(r_TryParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTime == null)
				{
					r_TryParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTime = new(typeof(System.DateTime), "TryParse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles), typeof(System.DateTime).MakeByRefType());
					r_TryParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTime.SetBelong(null);
				}
				return r_TryParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTime;
			}
		}

		/// <summary>
		/// Boolean TryParseExact(System.String, System.String, System.IFormatProvider, System.Globalization.DateTimeStyles, System.DateTime ByRef)
		/// </summary>
		protected static RMethod r_TryParseExact_String_String_IFormatProvider_DateTimeStyles_Out_DateTime;
		public static RMethod RTryParseExact_String_String_IFormatProvider_DateTimeStyles_Out_DateTime
		{
			get
			{
				if(r_TryParseExact_String_String_IFormatProvider_DateTimeStyles_Out_DateTime == null)
				{
					r_TryParseExact_String_String_IFormatProvider_DateTimeStyles_Out_DateTime = new(typeof(System.DateTime), "TryParseExact", 0, typeof(System.String), typeof(System.String), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles), typeof(System.DateTime).MakeByRefType());
					r_TryParseExact_String_String_IFormatProvider_DateTimeStyles_Out_DateTime.SetBelong(null);
				}
				return r_TryParseExact_String_String_IFormatProvider_DateTimeStyles_Out_DateTime;
			}
		}

		/// <summary>
		/// Boolean TryParseExact(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.IFormatProvider, System.Globalization.DateTimeStyles, System.DateTime ByRef)
		/// </summary>
		protected static RMethod r_TryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTime;
		public static RMethod RTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTime
		{
			get
			{
				if(r_TryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTime == null)
				{
					r_TryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTime = new(typeof(System.DateTime), "TryParseExact", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles), typeof(System.DateTime).MakeByRefType());
					r_TryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTime.SetBelong(null);
				}
				return r_TryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTime;
			}
		}

		/// <summary>
		/// Boolean TryParseExact(System.String, System.String[], System.IFormatProvider, System.Globalization.DateTimeStyles, System.DateTime ByRef)
		/// </summary>
		protected static RMethod r_TryParseExact_String_StringArray_IFormatProvider_DateTimeStyles_Out_DateTime;
		public static RMethod RTryParseExact_String_StringArray_IFormatProvider_DateTimeStyles_Out_DateTime
		{
			get
			{
				if(r_TryParseExact_String_StringArray_IFormatProvider_DateTimeStyles_Out_DateTime == null)
				{
					r_TryParseExact_String_StringArray_IFormatProvider_DateTimeStyles_Out_DateTime = new(typeof(System.DateTime), "TryParseExact", 0, typeof(System.String), typeof(System.String).MakeArrayType(), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles), typeof(System.DateTime).MakeByRefType());
					r_TryParseExact_String_StringArray_IFormatProvider_DateTimeStyles_Out_DateTime.SetBelong(null);
				}
				return r_TryParseExact_String_StringArray_IFormatProvider_DateTimeStyles_Out_DateTime;
			}
		}

		/// <summary>
		/// Boolean TryParseExact(System.ReadOnlySpan`1[System.Char], System.String[], System.IFormatProvider, System.Globalization.DateTimeStyles, System.DateTime ByRef)
		/// </summary>
		protected static RMethod r_TryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles_Out_DateTime;
		public static RMethod RTryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles_Out_DateTime
		{
			get
			{
				if(r_TryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles_Out_DateTime == null)
				{
					r_TryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles_Out_DateTime = new(typeof(System.DateTime), "TryParseExact", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.String).MakeArrayType(), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles), typeof(System.DateTime).MakeByRefType());
					r_TryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles_Out_DateTime.SetBelong(null);
				}
				return r_TryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles_Out_DateTime;
			}
		}

		/// <summary>
		/// System.DateTime op_Addition(System.DateTime, System.TimeSpan)
		/// </summary>
		protected static RMethod r_op_Addition_DateTime_TimeSpan;
		public static RMethod Rop_Addition_DateTime_TimeSpan
		{
			get
			{
				if(r_op_Addition_DateTime_TimeSpan == null)
				{
					r_op_Addition_DateTime_TimeSpan = new(typeof(System.DateTime), "op_Addition", 0, typeof(System.DateTime), typeof(System.TimeSpan));
					r_op_Addition_DateTime_TimeSpan.SetBelong(null);
				}
				return r_op_Addition_DateTime_TimeSpan;
			}
		}

		/// <summary>
		/// System.DateTime op_Subtraction(System.DateTime, System.TimeSpan)
		/// </summary>
		protected static RMethod r_op_Subtraction_DateTime_TimeSpan;
		public static RMethod Rop_Subtraction_DateTime_TimeSpan
		{
			get
			{
				if(r_op_Subtraction_DateTime_TimeSpan == null)
				{
					r_op_Subtraction_DateTime_TimeSpan = new(typeof(System.DateTime), "op_Subtraction", 0, typeof(System.DateTime), typeof(System.TimeSpan));
					r_op_Subtraction_DateTime_TimeSpan.SetBelong(null);
				}
				return r_op_Subtraction_DateTime_TimeSpan;
			}
		}

		/// <summary>
		/// System.TimeSpan op_Subtraction(System.DateTime, System.DateTime)
		/// </summary>
		protected static RMethod r_op_Subtraction_DateTime_DateTime;
		public static RMethod Rop_Subtraction_DateTime_DateTime
		{
			get
			{
				if(r_op_Subtraction_DateTime_DateTime == null)
				{
					r_op_Subtraction_DateTime_DateTime = new(typeof(System.DateTime), "op_Subtraction", 0, typeof(System.DateTime), typeof(System.DateTime));
					r_op_Subtraction_DateTime_DateTime.SetBelong(null);
				}
				return r_op_Subtraction_DateTime_DateTime;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.DateTime, System.DateTime)
		/// </summary>
		protected static RMethod r_op_Equality_DateTime_DateTime;
		public static RMethod Rop_Equality_DateTime_DateTime
		{
			get
			{
				if(r_op_Equality_DateTime_DateTime == null)
				{
					r_op_Equality_DateTime_DateTime = new(typeof(System.DateTime), "op_Equality", 0, typeof(System.DateTime), typeof(System.DateTime));
					r_op_Equality_DateTime_DateTime.SetBelong(null);
				}
				return r_op_Equality_DateTime_DateTime;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.DateTime, System.DateTime)
		/// </summary>
		protected static RMethod r_op_Inequality_DateTime_DateTime;
		public static RMethod Rop_Inequality_DateTime_DateTime
		{
			get
			{
				if(r_op_Inequality_DateTime_DateTime == null)
				{
					r_op_Inequality_DateTime_DateTime = new(typeof(System.DateTime), "op_Inequality", 0, typeof(System.DateTime), typeof(System.DateTime));
					r_op_Inequality_DateTime_DateTime.SetBelong(null);
				}
				return r_op_Inequality_DateTime_DateTime;
			}
		}

		/// <summary>
		/// Boolean op_LessThan(System.DateTime, System.DateTime)
		/// </summary>
		protected static RMethod r_op_LessThan_DateTime_DateTime;
		public static RMethod Rop_LessThan_DateTime_DateTime
		{
			get
			{
				if(r_op_LessThan_DateTime_DateTime == null)
				{
					r_op_LessThan_DateTime_DateTime = new(typeof(System.DateTime), "op_LessThan", 0, typeof(System.DateTime), typeof(System.DateTime));
					r_op_LessThan_DateTime_DateTime.SetBelong(null);
				}
				return r_op_LessThan_DateTime_DateTime;
			}
		}

		/// <summary>
		/// Boolean op_LessThanOrEqual(System.DateTime, System.DateTime)
		/// </summary>
		protected static RMethod r_op_LessThanOrEqual_DateTime_DateTime;
		public static RMethod Rop_LessThanOrEqual_DateTime_DateTime
		{
			get
			{
				if(r_op_LessThanOrEqual_DateTime_DateTime == null)
				{
					r_op_LessThanOrEqual_DateTime_DateTime = new(typeof(System.DateTime), "op_LessThanOrEqual", 0, typeof(System.DateTime), typeof(System.DateTime));
					r_op_LessThanOrEqual_DateTime_DateTime.SetBelong(null);
				}
				return r_op_LessThanOrEqual_DateTime_DateTime;
			}
		}

		/// <summary>
		/// Boolean op_GreaterThan(System.DateTime, System.DateTime)
		/// </summary>
		protected static RMethod r_op_GreaterThan_DateTime_DateTime;
		public static RMethod Rop_GreaterThan_DateTime_DateTime
		{
			get
			{
				if(r_op_GreaterThan_DateTime_DateTime == null)
				{
					r_op_GreaterThan_DateTime_DateTime = new(typeof(System.DateTime), "op_GreaterThan", 0, typeof(System.DateTime), typeof(System.DateTime));
					r_op_GreaterThan_DateTime_DateTime.SetBelong(null);
				}
				return r_op_GreaterThan_DateTime_DateTime;
			}
		}

		/// <summary>
		/// Boolean op_GreaterThanOrEqual(System.DateTime, System.DateTime)
		/// </summary>
		protected static RMethod r_op_GreaterThanOrEqual_DateTime_DateTime;
		public static RMethod Rop_GreaterThanOrEqual_DateTime_DateTime
		{
			get
			{
				if(r_op_GreaterThanOrEqual_DateTime_DateTime == null)
				{
					r_op_GreaterThanOrEqual_DateTime_DateTime = new(typeof(System.DateTime), "op_GreaterThanOrEqual", 0, typeof(System.DateTime), typeof(System.DateTime));
					r_op_GreaterThanOrEqual_DateTime_DateTime.SetBelong(null);
				}
				return r_op_GreaterThanOrEqual_DateTime_DateTime;
			}
		}

		/// <summary>
		/// System.String[] GetDateTimeFormats()
		/// </summary>
		protected RMethod r_GetDateTimeFormats;
		public virtual RMethod RGetDateTimeFormats
		{
			get
			{
				if(r_GetDateTimeFormats == null)
				{
					r_GetDateTimeFormats = new(this, "GetDateTimeFormats", 0);
					r_GetDateTimeFormats.SetBelong(this.instance);
				}
				return r_GetDateTimeFormats;
			}
		}

		/// <summary>
		/// System.String[] GetDateTimeFormats(System.IFormatProvider)
		/// </summary>
		protected RMethod r_GetDateTimeFormats_IFormatProvider;
		public virtual RMethod RGetDateTimeFormats_IFormatProvider
		{
			get
			{
				if(r_GetDateTimeFormats_IFormatProvider == null)
				{
					r_GetDateTimeFormats_IFormatProvider = new(this, "GetDateTimeFormats", 0, typeof(System.IFormatProvider));
					r_GetDateTimeFormats_IFormatProvider.SetBelong(this.instance);
				}
				return r_GetDateTimeFormats_IFormatProvider;
			}
		}

		/// <summary>
		/// System.String[] GetDateTimeFormats(Char)
		/// </summary>
		protected RMethod r_GetDateTimeFormats_Char;
		public virtual RMethod RGetDateTimeFormats_Char
		{
			get
			{
				if(r_GetDateTimeFormats_Char == null)
				{
					r_GetDateTimeFormats_Char = new(this, "GetDateTimeFormats", 0, typeof(System.Char));
					r_GetDateTimeFormats_Char.SetBelong(this.instance);
				}
				return r_GetDateTimeFormats_Char;
			}
		}

		/// <summary>
		/// System.String[] GetDateTimeFormats(Char, System.IFormatProvider)
		/// </summary>
		protected RMethod r_GetDateTimeFormats_Char_IFormatProvider;
		public virtual RMethod RGetDateTimeFormats_Char_IFormatProvider
		{
			get
			{
				if(r_GetDateTimeFormats_Char_IFormatProvider == null)
				{
					r_GetDateTimeFormats_Char_IFormatProvider = new(this, "GetDateTimeFormats", 0, typeof(System.Char), typeof(System.IFormatProvider));
					r_GetDateTimeFormats_Char_IFormatProvider.SetBelong(this.instance);
				}
				return r_GetDateTimeFormats_Char_IFormatProvider;
			}
		}

		/// <summary>
		/// System.TypeCode GetTypeCode()
		/// </summary>
		protected RMethod r_GetTypeCode;
		public virtual RMethod RGetTypeCode
		{
			get
			{
				if(r_GetTypeCode == null)
				{
					r_GetTypeCode = new(this, "GetTypeCode", 0);
					r_GetTypeCode.SetBelong(this.instance);
				}
				return r_GetTypeCode;
			}
		}

		/// <summary>
		/// Boolean System.IConvertible.ToBoolean(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToBoolean_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToBoolean_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToBoolean_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToBoolean_IFormatProvider = new(this, "System.IConvertible.ToBoolean", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToBoolean_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToBoolean_IFormatProvider;
			}
		}

		/// <summary>
		/// Char System.IConvertible.ToChar(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToChar_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToChar_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToChar_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToChar_IFormatProvider = new(this, "System.IConvertible.ToChar", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToChar_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToChar_IFormatProvider;
			}
		}

		/// <summary>
		/// SByte System.IConvertible.ToSByte(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToSByte_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToSByte_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToSByte_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToSByte_IFormatProvider = new(this, "System.IConvertible.ToSByte", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToSByte_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToSByte_IFormatProvider;
			}
		}

		/// <summary>
		/// Byte System.IConvertible.ToByte(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToByte_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToByte_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToByte_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToByte_IFormatProvider = new(this, "System.IConvertible.ToByte", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToByte_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToByte_IFormatProvider;
			}
		}

		/// <summary>
		/// Int16 System.IConvertible.ToInt16(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToInt16_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToInt16_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToInt16_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToInt16_IFormatProvider = new(this, "System.IConvertible.ToInt16", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToInt16_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToInt16_IFormatProvider;
			}
		}

		/// <summary>
		/// UInt16 System.IConvertible.ToUInt16(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToUInt16_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToUInt16_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToUInt16_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToUInt16_IFormatProvider = new(this, "System.IConvertible.ToUInt16", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToUInt16_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToUInt16_IFormatProvider;
			}
		}

		/// <summary>
		/// Int32 System.IConvertible.ToInt32(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToInt32_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToInt32_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToInt32_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToInt32_IFormatProvider = new(this, "System.IConvertible.ToInt32", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToInt32_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToInt32_IFormatProvider;
			}
		}

		/// <summary>
		/// UInt32 System.IConvertible.ToUInt32(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToUInt32_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToUInt32_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToUInt32_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToUInt32_IFormatProvider = new(this, "System.IConvertible.ToUInt32", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToUInt32_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToUInt32_IFormatProvider;
			}
		}

		/// <summary>
		/// Int64 System.IConvertible.ToInt64(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToInt64_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToInt64_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToInt64_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToInt64_IFormatProvider = new(this, "System.IConvertible.ToInt64", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToInt64_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToInt64_IFormatProvider;
			}
		}

		/// <summary>
		/// UInt64 System.IConvertible.ToUInt64(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToUInt64_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToUInt64_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToUInt64_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToUInt64_IFormatProvider = new(this, "System.IConvertible.ToUInt64", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToUInt64_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToUInt64_IFormatProvider;
			}
		}

		/// <summary>
		/// Single System.IConvertible.ToSingle(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToSingle_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToSingle_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToSingle_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToSingle_IFormatProvider = new(this, "System.IConvertible.ToSingle", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToSingle_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToSingle_IFormatProvider;
			}
		}

		/// <summary>
		/// Double System.IConvertible.ToDouble(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToDouble_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToDouble_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToDouble_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToDouble_IFormatProvider = new(this, "System.IConvertible.ToDouble", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToDouble_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToDouble_IFormatProvider;
			}
		}

		/// <summary>
		/// System.Decimal System.IConvertible.ToDecimal(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToDecimal_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToDecimal_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToDecimal_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToDecimal_IFormatProvider = new(this, "System.IConvertible.ToDecimal", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToDecimal_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToDecimal_IFormatProvider;
			}
		}

		/// <summary>
		/// System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToDateTime_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToDateTime_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToDateTime_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToDateTime_IFormatProvider = new(this, "System.IConvertible.ToDateTime", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToDateTime_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToDateTime_IFormatProvider;
			}
		}

		/// <summary>
		/// System.Object System.IConvertible.ToType(System.Type, System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToType_Type_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToType_Type_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToType_Type_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToType_Type_IFormatProvider = new(this, "System.IConvertible.ToType", 0, typeof(System.Type), typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToType_Type_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToType_Type_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean TryCreate(Int32, Int32, Int32, Int32, Int32, Int32, Int32, System.DateTime ByRef)
		/// </summary>
		protected static RMethod r_TryCreate_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Out_DateTime;
		public static RMethod RTryCreate_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Out_DateTime
		{
			get
			{
				if(r_TryCreate_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Out_DateTime == null)
				{
					r_TryCreate_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Out_DateTime = new(typeof(System.DateTime), "TryCreate", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.DateTime).MakeByRefType());
					r_TryCreate_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Out_DateTime.SetBelong(null);
				}
				return r_TryCreate_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Out_DateTime;
			}
		}

		/// <summary>
		/// Int64 GetSystemTimeAsFileTime()
		/// </summary>
		protected static RMethod r_GetSystemTimeAsFileTime;
		public static RMethod RGetSystemTimeAsFileTime
		{
			get
			{
				if(r_GetSystemTimeAsFileTime == null)
				{
					r_GetSystemTimeAsFileTime = new(typeof(System.DateTime), "GetSystemTimeAsFileTime", 0);
					r_GetSystemTimeAsFileTime.SetBelong(null);
				}
				return r_GetSystemTimeAsFileTime;
			}
		}

		/// <summary>
		/// Int64 ToBinaryRaw()
		/// </summary>
		protected RMethod r_ToBinaryRaw;
		public virtual RMethod RToBinaryRaw
		{
			get
			{
				if(r_ToBinaryRaw == null)
				{
					r_ToBinaryRaw = new(this, "ToBinaryRaw", 0);
					r_ToBinaryRaw.SetBelong(this.instance);
				}
				return r_ToBinaryRaw;
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


        public RDateTime() : base("System.DateTime")
        {
        }

        public RDateTime(System.Object instance) : base("System.DateTime")
		{
            SetInstance(instance);
		}

        public RDateTime(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDateTime(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.DateTime Add(System.TimeSpan @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAdd_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime Add(System.Double @value, System.Int32 @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @scale};
            var ___result = RAdd_Double_Int32.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime AddDays(System.Double @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAddDays_Double.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime AddHours(System.Double @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAddHours_Double.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime AddMilliseconds(System.Double @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAddMilliseconds_Double.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime AddMinutes(System.Double @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAddMinutes_Double.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime AddMonths(System.Int32 @months)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@months};
            var ___result = RAddMonths_Int32.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime AddSeconds(System.Double @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAddSeconds_Double.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime AddTicks(System.Int64 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAddTicks_Int64.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime AddYears(System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAddYears_Int32.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.Int32 Compare(System.DateTime @t1, System.DateTime @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = RCompare_DateTime_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareTo(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareTo(System.DateTime @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RCompareTo_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int64 DateToTicks(System.Int32 @year, System.Int32 @month, System.Int32 @day)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @month, @day};
            var ___result = RDateToTicks_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public static System.Int64 TimeToTicks(System.Int32 @hour, System.Int32 @minute, System.Int32 @second)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hour, @minute, @second};
            var ___result = RTimeToTicks_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public static System.Int32 DaysInMonth(System.Int32 @year, System.Int32 @month)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @month};
            var ___result = RDaysInMonth_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int64 DoubleDateToTicks(System.Double @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RDoubleDateToTicks_Double.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.Boolean Equals(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.DateTime @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = REquals_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean Equals(System.DateTime @t1, System.DateTime @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = REquals_DateTime_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.DateTime FromBinary(System.Int64 @dateData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dateData};
            var ___result = RFromBinary_Int64.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.DateTime FromBinaryRaw(System.Int64 @dateData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dateData};
            var ___result = RFromBinaryRaw_Int64.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.DateTime FromFileTime(System.Int64 @fileTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileTime};
            var ___result = RFromFileTime_Int64.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.DateTime FromFileTimeUtc(System.Int64 @fileTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileTime};
            var ___result = RFromFileTimeUtc_Int64.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.DateTime FromOADate(System.Double @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RFromOADate_Double.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual void System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsDaylightSavingTime()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsDaylightSavingTime.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.DateTime SpecifyKind(System.DateTime @value, System.DateTimeKind @kind)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @kind};
            var ___result = RSpecifyKind_DateTime_DateTimeKind.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.Int64 ToBinary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToBinary.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.Int32 GetDatePart(System.Int32 @part)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@part};
            var ___result = RGetDatePart_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void GetDatePart(out System.Int32 @year, out System.Int32 @month, out System.Int32 @day)
        {
			@year = default;
			@month = default;
			@day = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @month, @day};
            var ___result = RGetDatePart_Out_Int32_Out_Int32_Out_Int32.Invoke(___genericsType, ___parameters);
			@year = (System.Int32)___parameters[0];
			@month = (System.Int32)___parameters[1];
			@day = (System.Int32)___parameters[2];

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean IsAmbiguousDaylightSavingTime()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsAmbiguousDaylightSavingTime.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsLeapYear(System.Int32 @year)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year};
            var ___result = RIsLeapYear_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.DateTime Parse(System.String @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RParse_String.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.DateTime Parse(System.String @s, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @provider};
            var ___result = RParse_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.DateTime Parse(System.String @s, System.IFormatProvider @provider, System.Globalization.DateTimeStyles @styles)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @provider, @styles};
            var ___result = RParse_String_IFormatProvider_DateTimeStyles.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.DateTime Parse(RSystem.RReadOnlySpan<RSystem.RChar> @s, System.IFormatProvider @provider, System.Globalization.DateTimeStyles @styles)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @provider, @styles};
            var ___result = RParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.DateTime ParseExact(System.String @s, System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @format, @provider};
            var ___result = RParseExact_String_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.DateTime ParseExact(System.String @s, System.String @format, System.IFormatProvider @provider, System.Globalization.DateTimeStyles @style)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @format, @provider, @style};
            var ___result = RParseExact_String_String_IFormatProvider_DateTimeStyles.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.DateTime ParseExact(RSystem.RReadOnlySpan<RSystem.RChar> @s, RSystem.RReadOnlySpan<RSystem.RChar> @format, System.IFormatProvider @provider, System.Globalization.DateTimeStyles @style)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @format.Value, @provider, @style};
            var ___result = RParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.DateTime ParseExact(System.String @s, System.String[] @formats, System.IFormatProvider @provider, System.Globalization.DateTimeStyles @style)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @formats, @provider, @style};
            var ___result = RParseExact_String_StringArray_IFormatProvider_DateTimeStyles.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.DateTime ParseExact(RSystem.RReadOnlySpan<RSystem.RChar> @s, System.String[] @formats, System.IFormatProvider @provider, System.Globalization.DateTimeStyles @style)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @formats, @provider, @style};
            var ___result = RParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.TimeSpan Subtract(System.DateTime @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSubtract_DateTime.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public virtual System.DateTime Subtract(System.TimeSpan @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSubtract_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.Double TicksToOADate(System.Int64 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RTicksToOADate_Int64.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Double ToOADate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToOADate.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Int64 ToFileTime()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToFileTime.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.Int64 ToFileTimeUtc()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToFileTimeUtc.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.DateTime ToLocalTime()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToLocalTime.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime ToLocalTime(System.Boolean @throwOnOverflow)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@throwOnOverflow};
            var ___result = RToLocalTime_Boolean.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.String ToLongDateString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToLongDateString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToLongTimeString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToLongTimeString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToShortDateString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToShortDateString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToShortTimeString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToShortTimeString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean TryFormat(RSystem.RSpan<RSystem.RChar> @destination, out System.Int32 @charsWritten, RSystem.RReadOnlySpan<RSystem.RChar> @format, System.IFormatProvider @provider)
        {
			@charsWritten = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination.Value, @charsWritten, @format.Value, @provider};
            var ___result = RTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider.Invoke(___genericsType, ___parameters);
			@charsWritten = (System.Int32)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.DateTime ToUniversalTime()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToUniversalTime.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.Boolean TryParse(System.String @s, out System.DateTime @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @result};
            var ___result = RTryParse_String_Out_DateTime.Invoke(___genericsType, ___parameters);
			@result = (System.DateTime)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParse(RSystem.RReadOnlySpan<RSystem.RChar> @s, out System.DateTime @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @result};
            var ___result = RTryParse_ReadOnlySpan_d_Char_p__Out_DateTime.Invoke(___genericsType, ___parameters);
			@result = (System.DateTime)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParse(System.String @s, System.IFormatProvider @provider, System.Globalization.DateTimeStyles @styles, out System.DateTime @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @provider, @styles, @result};
            var ___result = RTryParse_String_IFormatProvider_DateTimeStyles_Out_DateTime.Invoke(___genericsType, ___parameters);
			@result = (System.DateTime)___parameters[3];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParse(RSystem.RReadOnlySpan<RSystem.RChar> @s, System.IFormatProvider @provider, System.Globalization.DateTimeStyles @styles, out System.DateTime @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @provider, @styles, @result};
            var ___result = RTryParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTime.Invoke(___genericsType, ___parameters);
			@result = (System.DateTime)___parameters[3];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParseExact(System.String @s, System.String @format, System.IFormatProvider @provider, System.Globalization.DateTimeStyles @style, out System.DateTime @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @format, @provider, @style, @result};
            var ___result = RTryParseExact_String_String_IFormatProvider_DateTimeStyles_Out_DateTime.Invoke(___genericsType, ___parameters);
			@result = (System.DateTime)___parameters[4];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParseExact(RSystem.RReadOnlySpan<RSystem.RChar> @s, RSystem.RReadOnlySpan<RSystem.RChar> @format, System.IFormatProvider @provider, System.Globalization.DateTimeStyles @style, out System.DateTime @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @format.Value, @provider, @style, @result};
            var ___result = RTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTime.Invoke(___genericsType, ___parameters);
			@result = (System.DateTime)___parameters[4];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParseExact(System.String @s, System.String[] @formats, System.IFormatProvider @provider, System.Globalization.DateTimeStyles @style, out System.DateTime @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @formats, @provider, @style, @result};
            var ___result = RTryParseExact_String_StringArray_IFormatProvider_DateTimeStyles_Out_DateTime.Invoke(___genericsType, ___parameters);
			@result = (System.DateTime)___parameters[4];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParseExact(RSystem.RReadOnlySpan<RSystem.RChar> @s, System.String[] @formats, System.IFormatProvider @provider, System.Globalization.DateTimeStyles @style, out System.DateTime @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @formats, @provider, @style, @result};
            var ___result = RTryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles_Out_DateTime.Invoke(___genericsType, ___parameters);
			@result = (System.DateTime)___parameters[4];

            return (System.Boolean)___result;
        }


        public static System.DateTime op_Addition(System.DateTime @d, System.TimeSpan @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d, @t};
            var ___result = Rop_Addition_DateTime_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.DateTime op_Subtraction(System.DateTime @d, System.TimeSpan @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d, @t};
            var ___result = Rop_Subtraction_DateTime_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.TimeSpan op_Subtraction(System.DateTime @d1, System.DateTime @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = Rop_Subtraction_DateTime_DateTime.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.Boolean op_Equality(System.DateTime @d1, System.DateTime @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = Rop_Equality_DateTime_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.DateTime @d1, System.DateTime @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = Rop_Inequality_DateTime_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_LessThan(System.DateTime @t1, System.DateTime @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = Rop_LessThan_DateTime_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_LessThanOrEqual(System.DateTime @t1, System.DateTime @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = Rop_LessThanOrEqual_DateTime_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_GreaterThan(System.DateTime @t1, System.DateTime @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = Rop_GreaterThan_DateTime_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_GreaterThanOrEqual(System.DateTime @t1, System.DateTime @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = Rop_GreaterThanOrEqual_DateTime_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String[] GetDateTimeFormats()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDateTimeFormats.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] GetDateTimeFormats(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RGetDateTimeFormats_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] GetDateTimeFormats(System.Char @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RGetDateTimeFormats_Char.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] GetDateTimeFormats(System.Char @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RGetDateTimeFormats_Char_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTypeCode.Invoke(___genericsType, ___parameters);

            return (System.TypeCode)___result;
        }


        public virtual System.Boolean System__2__IConvertible__2__ToBoolean(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToBoolean_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Char System__2__IConvertible__2__ToChar(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToChar_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public virtual System.SByte System__2__IConvertible__2__ToSByte(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToSByte_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.SByte)___result;
        }


        public virtual System.Byte System__2__IConvertible__2__ToByte(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToByte_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Byte)___result;
        }


        public virtual System.Int16 System__2__IConvertible__2__ToInt16(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToInt16_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Int16)___result;
        }


        public virtual System.UInt16 System__2__IConvertible__2__ToUInt16(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToUInt16_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.UInt16)___result;
        }


        public virtual System.Int32 System__2__IConvertible__2__ToInt32(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToInt32_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.UInt32 System__2__IConvertible__2__ToUInt32(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToUInt32_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual System.Int64 System__2__IConvertible__2__ToInt64(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToInt64_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.UInt64 System__2__IConvertible__2__ToUInt64(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToUInt64_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public virtual System.Single System__2__IConvertible__2__ToSingle(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToSingle_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Double System__2__IConvertible__2__ToDouble(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToDouble_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Decimal System__2__IConvertible__2__ToDecimal(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToDecimal_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public virtual System.DateTime System__2__IConvertible__2__ToDateTime(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToDateTime_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.Object System__2__IConvertible__2__ToType(System.Type @type, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @provider};
            var ___result = RSystem__2__IConvertible__2__ToType_Type_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Boolean TryCreate(System.Int32 @year, System.Int32 @month, System.Int32 @day, System.Int32 @hour, System.Int32 @minute, System.Int32 @second, System.Int32 @millisecond, out System.DateTime @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @month, @day, @hour, @minute, @second, @millisecond, @result};
            var ___result = RTryCreate_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Out_DateTime.Invoke(___genericsType, ___parameters);
			@result = (System.DateTime)___parameters[7];

            return (System.Boolean)___result;
        }


        public static System.Int64 GetSystemTimeAsFileTime()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSystemTimeAsFileTime.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.Int64 ToBinaryRaw()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToBinaryRaw.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
