
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.DateTime
	/// </summary>
    public partial class RDateTime : RMember //
    {

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
					r_FTicksPerMillisecond = new(typeof(System.DateTime), "TicksPerMillisecond");
					r_FTicksPerMillisecond.SetBelong(null);
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
					r_FTicksPerSecond = new(typeof(System.DateTime), "TicksPerSecond");
					r_FTicksPerSecond.SetBelong(null);
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
					r_FTicksPerMinute = new(typeof(System.DateTime), "TicksPerMinute");
					r_FTicksPerMinute.SetBelong(null);
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
					r_FTicksPerHour = new(typeof(System.DateTime), "TicksPerHour");
					r_FTicksPerHour.SetBelong(null);
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
					r_FTicksPerDay = new(typeof(System.DateTime), "TicksPerDay");
					r_FTicksPerDay.SetBelong(null);
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
					r_FMillisPerSecond = new(typeof(System.DateTime), "MillisPerSecond");
					r_FMillisPerSecond.SetBelong(null);
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
					r_FMillisPerMinute = new(typeof(System.DateTime), "MillisPerMinute");
					r_FMillisPerMinute.SetBelong(null);
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
					r_FMillisPerHour = new(typeof(System.DateTime), "MillisPerHour");
					r_FMillisPerHour.SetBelong(null);
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
					r_FMillisPerDay = new(typeof(System.DateTime), "MillisPerDay");
					r_FMillisPerDay.SetBelong(null);
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
					r_FDaysPerYear = new(typeof(System.DateTime), "DaysPerYear");
					r_FDaysPerYear.SetBelong(null);
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
					r_FDaysPer4Years = new(typeof(System.DateTime), "DaysPer4Years");
					r_FDaysPer4Years.SetBelong(null);
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
					r_FDaysPer100Years = new(typeof(System.DateTime), "DaysPer100Years");
					r_FDaysPer100Years.SetBelong(null);
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
					r_FDaysPer400Years = new(typeof(System.DateTime), "DaysPer400Years");
					r_FDaysPer400Years.SetBelong(null);
				}
				return r_FDaysPer400Years;
			}
		}

		/// <summary>
		/// System.Int32 DaysTo1601
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FDaysTo1601;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFDaysTo1601
		{
			get
			{
				if(r_FDaysTo1601 == null)
				{
					r_FDaysTo1601 = new(typeof(System.DateTime), "DaysTo1601");
					r_FDaysTo1601.SetBelong(null);
				}
				return r_FDaysTo1601;
			}
		}

		/// <summary>
		/// System.Int32 DaysTo1899
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FDaysTo1899;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFDaysTo1899
		{
			get
			{
				if(r_FDaysTo1899 == null)
				{
					r_FDaysTo1899 = new(typeof(System.DateTime), "DaysTo1899");
					r_FDaysTo1899.SetBelong(null);
				}
				return r_FDaysTo1899;
			}
		}

		/// <summary>
		/// System.Int32 DaysTo1970
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FDaysTo1970;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFDaysTo1970
		{
			get
			{
				if(r_FDaysTo1970 == null)
				{
					r_FDaysTo1970 = new(typeof(System.DateTime), "DaysTo1970");
					r_FDaysTo1970.SetBelong(null);
				}
				return r_FDaysTo1970;
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
					r_FDaysTo10000 = new(typeof(System.DateTime), "DaysTo10000");
					r_FDaysTo10000.SetBelong(null);
				}
				return r_FDaysTo10000;
			}
		}

		/// <summary>
		/// System.Int64 MinTicks
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt64 r_FMinTicks;
		public static Hvak.Editor.Refleaction.RSystem.RInt64 RFMinTicks
		{
			get
			{
				if(r_FMinTicks == null)
				{
					r_FMinTicks = new(typeof(System.DateTime), "MinTicks");
					r_FMinTicks.SetBelong(null);
				}
				return r_FMinTicks;
			}
		}

		/// <summary>
		/// System.Int64 MaxTicks
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt64 r_FMaxTicks;
		public static Hvak.Editor.Refleaction.RSystem.RInt64 RFMaxTicks
		{
			get
			{
				if(r_FMaxTicks == null)
				{
					r_FMaxTicks = new(typeof(System.DateTime), "MaxTicks");
					r_FMaxTicks.SetBelong(null);
				}
				return r_FMaxTicks;
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
					r_FMaxMillis = new(typeof(System.DateTime), "MaxMillis");
					r_FMaxMillis.SetBelong(null);
				}
				return r_FMaxMillis;
			}
		}

		/// <summary>
		/// System.Int64 UnixEpochTicks
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt64 r_FUnixEpochTicks;
		public static Hvak.Editor.Refleaction.RSystem.RInt64 RFUnixEpochTicks
		{
			get
			{
				if(r_FUnixEpochTicks == null)
				{
					r_FUnixEpochTicks = new(typeof(System.DateTime), "UnixEpochTicks");
					r_FUnixEpochTicks.SetBelong(null);
				}
				return r_FUnixEpochTicks;
			}
		}

		/// <summary>
		/// System.Int64 FileTimeOffset
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt64 r_FFileTimeOffset;
		public static Hvak.Editor.Refleaction.RSystem.RInt64 RFFileTimeOffset
		{
			get
			{
				if(r_FFileTimeOffset == null)
				{
					r_FFileTimeOffset = new(typeof(System.DateTime), "FileTimeOffset");
					r_FFileTimeOffset.SetBelong(null);
				}
				return r_FFileTimeOffset;
			}
		}

		/// <summary>
		/// System.Int64 DoubleDateOffset
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt64 r_FDoubleDateOffset;
		public static Hvak.Editor.Refleaction.RSystem.RInt64 RFDoubleDateOffset
		{
			get
			{
				if(r_FDoubleDateOffset == null)
				{
					r_FDoubleDateOffset = new(typeof(System.DateTime), "DoubleDateOffset");
					r_FDoubleDateOffset.SetBelong(null);
				}
				return r_FDoubleDateOffset;
			}
		}

		/// <summary>
		/// System.Int64 OADateMinAsTicks
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt64 r_FOADateMinAsTicks;
		public static Hvak.Editor.Refleaction.RSystem.RInt64 RFOADateMinAsTicks
		{
			get
			{
				if(r_FOADateMinAsTicks == null)
				{
					r_FOADateMinAsTicks = new(typeof(System.DateTime), "OADateMinAsTicks");
					r_FOADateMinAsTicks.SetBelong(null);
				}
				return r_FOADateMinAsTicks;
			}
		}

		/// <summary>
		/// System.Double OADateMinAsDouble
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RDouble r_FOADateMinAsDouble;
		public static Hvak.Editor.Refleaction.RSystem.RDouble RFOADateMinAsDouble
		{
			get
			{
				if(r_FOADateMinAsDouble == null)
				{
					r_FOADateMinAsDouble = new(typeof(System.DateTime), "OADateMinAsDouble");
					r_FOADateMinAsDouble.SetBelong(null);
				}
				return r_FOADateMinAsDouble;
			}
		}

		/// <summary>
		/// System.Double OADateMaxAsDouble
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RDouble r_FOADateMaxAsDouble;
		public static Hvak.Editor.Refleaction.RSystem.RDouble RFOADateMaxAsDouble
		{
			get
			{
				if(r_FOADateMaxAsDouble == null)
				{
					r_FOADateMaxAsDouble = new(typeof(System.DateTime), "OADateMaxAsDouble");
					r_FOADateMaxAsDouble.SetBelong(null);
				}
				return r_FOADateMaxAsDouble;
			}
		}

		/// <summary>
		/// System.Int32 DatePartYear
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FDatePartYear;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFDatePartYear
		{
			get
			{
				if(r_FDatePartYear == null)
				{
					r_FDatePartYear = new(typeof(System.DateTime), "DatePartYear");
					r_FDatePartYear.SetBelong(null);
				}
				return r_FDatePartYear;
			}
		}

		/// <summary>
		/// System.Int32 DatePartDayOfYear
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FDatePartDayOfYear;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFDatePartDayOfYear
		{
			get
			{
				if(r_FDatePartDayOfYear == null)
				{
					r_FDatePartDayOfYear = new(typeof(System.DateTime), "DatePartDayOfYear");
					r_FDatePartDayOfYear.SetBelong(null);
				}
				return r_FDatePartDayOfYear;
			}
		}

		/// <summary>
		/// System.Int32 DatePartMonth
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FDatePartMonth;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFDatePartMonth
		{
			get
			{
				if(r_FDatePartMonth == null)
				{
					r_FDatePartMonth = new(typeof(System.DateTime), "DatePartMonth");
					r_FDatePartMonth.SetBelong(null);
				}
				return r_FDatePartMonth;
			}
		}

		/// <summary>
		/// System.Int32 DatePartDay
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FDatePartDay;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFDatePartDay
		{
			get
			{
				if(r_FDatePartDay == null)
				{
					r_FDatePartDay = new(typeof(System.DateTime), "DatePartDay");
					r_FDatePartDay.SetBelong(null);
				}
				return r_FDatePartDay;
			}
		}

		/// <summary>
		/// System.Int32[] s_daysToMonth365
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_Fs_daysToMonth365;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> RFs_daysToMonth365
		{
			get
			{
				if(r_Fs_daysToMonth365 == null)
				{
					r_Fs_daysToMonth365 = new(typeof(System.DateTime), "s_daysToMonth365");
					r_Fs_daysToMonth365.SetBelong(null);
				}
				return r_Fs_daysToMonth365;
			}
		}

		/// <summary>
		/// System.Int32[] s_daysToMonth366
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_Fs_daysToMonth366;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> RFs_daysToMonth366
		{
			get
			{
				if(r_Fs_daysToMonth366 == null)
				{
					r_Fs_daysToMonth366 = new(typeof(System.DateTime), "s_daysToMonth366");
					r_Fs_daysToMonth366.SetBelong(null);
				}
				return r_Fs_daysToMonth366;
			}
		}

		/// <summary>
		/// System.DateTime MinValue
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RDateTime r_FMinValue;
		public static Hvak.Editor.Refleaction.RSystem.RDateTime RFMinValue
		{
			get
			{
				if(r_FMinValue == null)
				{
					r_FMinValue = new(typeof(System.DateTime), "MinValue");
					r_FMinValue.SetBelong(null);
				}
				return r_FMinValue;
			}
		}

		/// <summary>
		/// System.DateTime MaxValue
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RDateTime r_FMaxValue;
		public static Hvak.Editor.Refleaction.RSystem.RDateTime RFMaxValue
		{
			get
			{
				if(r_FMaxValue == null)
				{
					r_FMaxValue = new(typeof(System.DateTime), "MaxValue");
					r_FMaxValue.SetBelong(null);
				}
				return r_FMaxValue;
			}
		}

		/// <summary>
		/// System.DateTime UnixEpoch
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RDateTime r_FUnixEpoch;
		public static Hvak.Editor.Refleaction.RSystem.RDateTime RFUnixEpoch
		{
			get
			{
				if(r_FUnixEpoch == null)
				{
					r_FUnixEpoch = new(typeof(System.DateTime), "UnixEpoch");
					r_FUnixEpoch.SetBelong(null);
				}
				return r_FUnixEpoch;
			}
		}

		/// <summary>
		/// System.UInt64 TicksMask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RUInt64 r_FTicksMask;
		public static Hvak.Editor.Refleaction.RSystem.RUInt64 RFTicksMask
		{
			get
			{
				if(r_FTicksMask == null)
				{
					r_FTicksMask = new(typeof(System.DateTime), "TicksMask");
					r_FTicksMask.SetBelong(null);
				}
				return r_FTicksMask;
			}
		}

		/// <summary>
		/// System.UInt64 FlagsMask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RUInt64 r_FFlagsMask;
		public static Hvak.Editor.Refleaction.RSystem.RUInt64 RFFlagsMask
		{
			get
			{
				if(r_FFlagsMask == null)
				{
					r_FFlagsMask = new(typeof(System.DateTime), "FlagsMask");
					r_FFlagsMask.SetBelong(null);
				}
				return r_FFlagsMask;
			}
		}

		/// <summary>
		/// System.UInt64 LocalMask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RUInt64 r_FLocalMask;
		public static Hvak.Editor.Refleaction.RSystem.RUInt64 RFLocalMask
		{
			get
			{
				if(r_FLocalMask == null)
				{
					r_FLocalMask = new(typeof(System.DateTime), "LocalMask");
					r_FLocalMask.SetBelong(null);
				}
				return r_FLocalMask;
			}
		}

		/// <summary>
		/// System.Int64 TicksCeiling
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt64 r_FTicksCeiling;
		public static Hvak.Editor.Refleaction.RSystem.RInt64 RFTicksCeiling
		{
			get
			{
				if(r_FTicksCeiling == null)
				{
					r_FTicksCeiling = new(typeof(System.DateTime), "TicksCeiling");
					r_FTicksCeiling.SetBelong(null);
				}
				return r_FTicksCeiling;
			}
		}

		/// <summary>
		/// System.UInt64 KindUnspecified
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RUInt64 r_FKindUnspecified;
		public static Hvak.Editor.Refleaction.RSystem.RUInt64 RFKindUnspecified
		{
			get
			{
				if(r_FKindUnspecified == null)
				{
					r_FKindUnspecified = new(typeof(System.DateTime), "KindUnspecified");
					r_FKindUnspecified.SetBelong(null);
				}
				return r_FKindUnspecified;
			}
		}

		/// <summary>
		/// System.UInt64 KindUtc
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RUInt64 r_FKindUtc;
		public static Hvak.Editor.Refleaction.RSystem.RUInt64 RFKindUtc
		{
			get
			{
				if(r_FKindUtc == null)
				{
					r_FKindUtc = new(typeof(System.DateTime), "KindUtc");
					r_FKindUtc.SetBelong(null);
				}
				return r_FKindUtc;
			}
		}

		/// <summary>
		/// System.UInt64 KindLocal
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RUInt64 r_FKindLocal;
		public static Hvak.Editor.Refleaction.RSystem.RUInt64 RFKindLocal
		{
			get
			{
				if(r_FKindLocal == null)
				{
					r_FKindLocal = new(typeof(System.DateTime), "KindLocal");
					r_FKindLocal.SetBelong(null);
				}
				return r_FKindLocal;
			}
		}

		/// <summary>
		/// System.UInt64 KindLocalAmbiguousDst
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RUInt64 r_FKindLocalAmbiguousDst;
		public static Hvak.Editor.Refleaction.RSystem.RUInt64 RFKindLocalAmbiguousDst
		{
			get
			{
				if(r_FKindLocalAmbiguousDst == null)
				{
					r_FKindLocalAmbiguousDst = new(typeof(System.DateTime), "KindLocalAmbiguousDst");
					r_FKindLocalAmbiguousDst.SetBelong(null);
				}
				return r_FKindLocalAmbiguousDst;
			}
		}

		/// <summary>
		/// System.Int32 KindShift
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FKindShift;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFKindShift
		{
			get
			{
				if(r_FKindShift == null)
				{
					r_FKindShift = new(typeof(System.DateTime), "KindShift");
					r_FKindShift.SetBelong(null);
				}
				return r_FKindShift;
			}
		}

		/// <summary>
		/// System.String TicksField
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FTicksField;
		public static Hvak.Editor.Refleaction.RSystem.RString RFTicksField
		{
			get
			{
				if(r_FTicksField == null)
				{
					r_FTicksField = new(typeof(System.DateTime), "TicksField");
					r_FTicksField.SetBelong(null);
				}
				return r_FTicksField;
			}
		}

		/// <summary>
		/// System.String DateDataField
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FDateDataField;
		public static Hvak.Editor.Refleaction.RSystem.RString RFDateDataField
		{
			get
			{
				if(r_FDateDataField == null)
				{
					r_FDateDataField = new(typeof(System.DateTime), "DateDataField");
					r_FDateDataField.SetBelong(null);
				}
				return r_FDateDataField;
			}
		}

		/// <summary>
		/// System.UInt64 _dateData
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt64 r_F_dateData;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt64 RF_dateData
		{
			get
			{
				if(r_F_dateData == null)
				{
					r_F_dateData = new(this, "_dateData");
					r_F_dateData.SetBelong(this.GetValue());
				}
				return r_F_dateData;
			}
		}

		/// <summary>
		/// Int64 InternalTicks
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_PInternalTicks;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RPInternalTicks
		{
			get
			{
				if(r_PInternalTicks == null)
				{
					r_PInternalTicks = new(this, "InternalTicks", -1);
					r_PInternalTicks.SetBelong(this.GetValue());
				}
				return r_PInternalTicks;
			}
		}

		/// <summary>
		/// UInt64 InternalKind
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt64 r_PInternalKind;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt64 RPInternalKind
		{
			get
			{
				if(r_PInternalKind == null)
				{
					r_PInternalKind = new(this, "InternalKind", -1);
					r_PInternalKind.SetBelong(this.GetValue());
				}
				return r_PInternalKind;
			}
		}

		/// <summary>
		/// System.DateTime Date
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RDateTime r_PDate;
		public virtual Hvak.Editor.Refleaction.RSystem.RDateTime RPDate
		{
			get
			{
				if(r_PDate == null)
				{
					r_PDate = new(this, "Date", -1);
					r_PDate.SetBelong(this.GetValue());
				}
				return r_PDate;
			}
		}

		/// <summary>
		/// Int32 Day
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PDay;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPDay
		{
			get
			{
				if(r_PDay == null)
				{
					r_PDay = new(this, "Day", -1);
					r_PDay.SetBelong(this.GetValue());
				}
				return r_PDay;
			}
		}

		/// <summary>
		/// System.DayOfWeek DayOfWeek
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RDayOfWeek r_PDayOfWeek;
		public virtual Hvak.Editor.Refleaction.RSystem.RDayOfWeek RPDayOfWeek
		{
			get
			{
				if(r_PDayOfWeek == null)
				{
					r_PDayOfWeek = new(this, "DayOfWeek", -1);
					r_PDayOfWeek.SetBelong(this.GetValue());
				}
				return r_PDayOfWeek;
			}
		}

		/// <summary>
		/// Int32 DayOfYear
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PDayOfYear;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPDayOfYear
		{
			get
			{
				if(r_PDayOfYear == null)
				{
					r_PDayOfYear = new(this, "DayOfYear", -1);
					r_PDayOfYear.SetBelong(this.GetValue());
				}
				return r_PDayOfYear;
			}
		}

		/// <summary>
		/// Int32 Hour
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PHour;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPHour
		{
			get
			{
				if(r_PHour == null)
				{
					r_PHour = new(this, "Hour", -1);
					r_PHour.SetBelong(this.GetValue());
				}
				return r_PHour;
			}
		}

		/// <summary>
		/// System.DateTimeKind Kind
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RDateTimeKind r_PKind;
		public virtual Hvak.Editor.Refleaction.RSystem.RDateTimeKind RPKind
		{
			get
			{
				if(r_PKind == null)
				{
					r_PKind = new(this, "Kind", -1);
					r_PKind.SetBelong(this.GetValue());
				}
				return r_PKind;
			}
		}

		/// <summary>
		/// Int32 Millisecond
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PMillisecond;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPMillisecond
		{
			get
			{
				if(r_PMillisecond == null)
				{
					r_PMillisecond = new(this, "Millisecond", -1);
					r_PMillisecond.SetBelong(this.GetValue());
				}
				return r_PMillisecond;
			}
		}

		/// <summary>
		/// Int32 Minute
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PMinute;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPMinute
		{
			get
			{
				if(r_PMinute == null)
				{
					r_PMinute = new(this, "Minute", -1);
					r_PMinute.SetBelong(this.GetValue());
				}
				return r_PMinute;
			}
		}

		/// <summary>
		/// Int32 Month
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PMonth;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPMonth
		{
			get
			{
				if(r_PMonth == null)
				{
					r_PMonth = new(this, "Month", -1);
					r_PMonth.SetBelong(this.GetValue());
				}
				return r_PMonth;
			}
		}

		/// <summary>
		/// System.DateTime Now
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RDateTime r_PNow;
		public static Hvak.Editor.Refleaction.RSystem.RDateTime RPNow
		{
			get
			{
				if(r_PNow == null)
				{
					r_PNow = new(typeof(System.DateTime), "Now", -1);
					r_PNow.SetBelong(null);
				}
				return r_PNow;
			}
		}

		/// <summary>
		/// Int32 Second
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PSecond;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPSecond
		{
			get
			{
				if(r_PSecond == null)
				{
					r_PSecond = new(this, "Second", -1);
					r_PSecond.SetBelong(this.GetValue());
				}
				return r_PSecond;
			}
		}

		/// <summary>
		/// Int64 Ticks
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_PTicks;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RPTicks
		{
			get
			{
				if(r_PTicks == null)
				{
					r_PTicks = new(this, "Ticks", -1);
					r_PTicks.SetBelong(this.GetValue());
				}
				return r_PTicks;
			}
		}

		/// <summary>
		/// System.TimeSpan TimeOfDay
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RTimeSpan r_PTimeOfDay;
		public virtual Hvak.Editor.Refleaction.RSystem.RTimeSpan RPTimeOfDay
		{
			get
			{
				if(r_PTimeOfDay == null)
				{
					r_PTimeOfDay = new(this, "TimeOfDay", -1);
					r_PTimeOfDay.SetBelong(this.GetValue());
				}
				return r_PTimeOfDay;
			}
		}

		/// <summary>
		/// System.DateTime Today
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RDateTime r_PToday;
		public static Hvak.Editor.Refleaction.RSystem.RDateTime RPToday
		{
			get
			{
				if(r_PToday == null)
				{
					r_PToday = new(typeof(System.DateTime), "Today", -1);
					r_PToday.SetBelong(null);
				}
				return r_PToday;
			}
		}

		/// <summary>
		/// Int32 Year
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PYear;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPYear
		{
			get
			{
				if(r_PYear == null)
				{
					r_PYear = new(this, "Year", -1);
					r_PYear.SetBelong(this.GetValue());
				}
				return r_PYear;
			}
		}

		/// <summary>
		/// System.DateTime UtcNow
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RDateTime r_PUtcNow;
		public static Hvak.Editor.Refleaction.RSystem.RDateTime RPUtcNow
		{
			get
			{
				if(r_PUtcNow == null)
				{
					r_PUtcNow = new(typeof(System.DateTime), "UtcNow", -1);
					r_PUtcNow.SetBelong(null);
				}
				return r_PUtcNow;
			}
		}

		/// <summary>
		/// System.DateTime Add(System.TimeSpan)
		/// </summary>
		protected RMethod r_MAdd_TimeSpan;
		public virtual RMethod RMAdd_TimeSpan
		{
			get
			{
				if(r_MAdd_TimeSpan == null)
				{
					r_MAdd_TimeSpan = new(this, "Add", 0, typeof(System.TimeSpan));
					r_MAdd_TimeSpan.SetBelong(this.GetValue());
				}
				return r_MAdd_TimeSpan;
			}
		}

		/// <summary>
		/// System.DateTime Add(Double, Int32)
		/// </summary>
		protected RMethod r_MAdd_Double_Int32;
		public virtual RMethod RMAdd_Double_Int32
		{
			get
			{
				if(r_MAdd_Double_Int32 == null)
				{
					r_MAdd_Double_Int32 = new(this, "Add", 0, typeof(System.Double), typeof(System.Int32));
					r_MAdd_Double_Int32.SetBelong(this.GetValue());
				}
				return r_MAdd_Double_Int32;
			}
		}

		/// <summary>
		/// System.DateTime AddDays(Double)
		/// </summary>
		protected RMethod r_MAddDays_Double;
		public virtual RMethod RMAddDays_Double
		{
			get
			{
				if(r_MAddDays_Double == null)
				{
					r_MAddDays_Double = new(this, "AddDays", 0, typeof(System.Double));
					r_MAddDays_Double.SetBelong(this.GetValue());
				}
				return r_MAddDays_Double;
			}
		}

		/// <summary>
		/// System.DateTime AddHours(Double)
		/// </summary>
		protected RMethod r_MAddHours_Double;
		public virtual RMethod RMAddHours_Double
		{
			get
			{
				if(r_MAddHours_Double == null)
				{
					r_MAddHours_Double = new(this, "AddHours", 0, typeof(System.Double));
					r_MAddHours_Double.SetBelong(this.GetValue());
				}
				return r_MAddHours_Double;
			}
		}

		/// <summary>
		/// System.DateTime AddMilliseconds(Double)
		/// </summary>
		protected RMethod r_MAddMilliseconds_Double;
		public virtual RMethod RMAddMilliseconds_Double
		{
			get
			{
				if(r_MAddMilliseconds_Double == null)
				{
					r_MAddMilliseconds_Double = new(this, "AddMilliseconds", 0, typeof(System.Double));
					r_MAddMilliseconds_Double.SetBelong(this.GetValue());
				}
				return r_MAddMilliseconds_Double;
			}
		}

		/// <summary>
		/// System.DateTime AddMinutes(Double)
		/// </summary>
		protected RMethod r_MAddMinutes_Double;
		public virtual RMethod RMAddMinutes_Double
		{
			get
			{
				if(r_MAddMinutes_Double == null)
				{
					r_MAddMinutes_Double = new(this, "AddMinutes", 0, typeof(System.Double));
					r_MAddMinutes_Double.SetBelong(this.GetValue());
				}
				return r_MAddMinutes_Double;
			}
		}

		/// <summary>
		/// System.DateTime AddMonths(Int32)
		/// </summary>
		protected RMethod r_MAddMonths_Int32;
		public virtual RMethod RMAddMonths_Int32
		{
			get
			{
				if(r_MAddMonths_Int32 == null)
				{
					r_MAddMonths_Int32 = new(this, "AddMonths", 0, typeof(System.Int32));
					r_MAddMonths_Int32.SetBelong(this.GetValue());
				}
				return r_MAddMonths_Int32;
			}
		}

		/// <summary>
		/// System.DateTime AddSeconds(Double)
		/// </summary>
		protected RMethod r_MAddSeconds_Double;
		public virtual RMethod RMAddSeconds_Double
		{
			get
			{
				if(r_MAddSeconds_Double == null)
				{
					r_MAddSeconds_Double = new(this, "AddSeconds", 0, typeof(System.Double));
					r_MAddSeconds_Double.SetBelong(this.GetValue());
				}
				return r_MAddSeconds_Double;
			}
		}

		/// <summary>
		/// System.DateTime AddTicks(Int64)
		/// </summary>
		protected RMethod r_MAddTicks_Int64;
		public virtual RMethod RMAddTicks_Int64
		{
			get
			{
				if(r_MAddTicks_Int64 == null)
				{
					r_MAddTicks_Int64 = new(this, "AddTicks", 0, typeof(System.Int64));
					r_MAddTicks_Int64.SetBelong(this.GetValue());
				}
				return r_MAddTicks_Int64;
			}
		}

		/// <summary>
		/// System.DateTime AddYears(Int32)
		/// </summary>
		protected RMethod r_MAddYears_Int32;
		public virtual RMethod RMAddYears_Int32
		{
			get
			{
				if(r_MAddYears_Int32 == null)
				{
					r_MAddYears_Int32 = new(this, "AddYears", 0, typeof(System.Int32));
					r_MAddYears_Int32.SetBelong(this.GetValue());
				}
				return r_MAddYears_Int32;
			}
		}

		/// <summary>
		/// Int32 Compare(System.DateTime, System.DateTime)
		/// </summary>
		protected static RMethod r_MCompare_DateTime_DateTime;
		public static RMethod RMCompare_DateTime_DateTime
		{
			get
			{
				if(r_MCompare_DateTime_DateTime == null)
				{
					r_MCompare_DateTime_DateTime = new(typeof(System.DateTime), "Compare", 0, typeof(System.DateTime), typeof(System.DateTime));
					r_MCompare_DateTime_DateTime.SetBelong(null);
				}
				return r_MCompare_DateTime_DateTime;
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
					r_MCompareTo_Object.SetBelong(this.GetValue());
				}
				return r_MCompareTo_Object;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.DateTime)
		/// </summary>
		protected RMethod r_MCompareTo_DateTime;
		public virtual RMethod RMCompareTo_DateTime
		{
			get
			{
				if(r_MCompareTo_DateTime == null)
				{
					r_MCompareTo_DateTime = new(this, "CompareTo", 0, typeof(System.DateTime));
					r_MCompareTo_DateTime.SetBelong(this.GetValue());
				}
				return r_MCompareTo_DateTime;
			}
		}

		/// <summary>
		/// Int64 DateToTicks(Int32, Int32, Int32)
		/// </summary>
		protected static RMethod r_MDateToTicks_Int32_Int32_Int32;
		public static RMethod RMDateToTicks_Int32_Int32_Int32
		{
			get
			{
				if(r_MDateToTicks_Int32_Int32_Int32 == null)
				{
					r_MDateToTicks_Int32_Int32_Int32 = new(typeof(System.DateTime), "DateToTicks", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_MDateToTicks_Int32_Int32_Int32.SetBelong(null);
				}
				return r_MDateToTicks_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Int64 TimeToTicks(Int32, Int32, Int32)
		/// </summary>
		protected static RMethod r_MTimeToTicks_Int32_Int32_Int32;
		public static RMethod RMTimeToTicks_Int32_Int32_Int32
		{
			get
			{
				if(r_MTimeToTicks_Int32_Int32_Int32 == null)
				{
					r_MTimeToTicks_Int32_Int32_Int32 = new(typeof(System.DateTime), "TimeToTicks", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_MTimeToTicks_Int32_Int32_Int32.SetBelong(null);
				}
				return r_MTimeToTicks_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 DaysInMonth(Int32, Int32)
		/// </summary>
		protected static RMethod r_MDaysInMonth_Int32_Int32;
		public static RMethod RMDaysInMonth_Int32_Int32
		{
			get
			{
				if(r_MDaysInMonth_Int32_Int32 == null)
				{
					r_MDaysInMonth_Int32_Int32 = new(typeof(System.DateTime), "DaysInMonth", 0, typeof(System.Int32), typeof(System.Int32));
					r_MDaysInMonth_Int32_Int32.SetBelong(null);
				}
				return r_MDaysInMonth_Int32_Int32;
			}
		}

		/// <summary>
		/// Int64 DoubleDateToTicks(Double)
		/// </summary>
		protected static RMethod r_MDoubleDateToTicks_Double;
		public static RMethod RMDoubleDateToTicks_Double
		{
			get
			{
				if(r_MDoubleDateToTicks_Double == null)
				{
					r_MDoubleDateToTicks_Double = new(typeof(System.DateTime), "DoubleDateToTicks", 0, typeof(System.Double));
					r_MDoubleDateToTicks_Double.SetBelong(null);
				}
				return r_MDoubleDateToTicks_Double;
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
					r_MEquals_Object.SetBelong(this.GetValue());
				}
				return r_MEquals_Object;
			}
		}

		/// <summary>
		/// Boolean Equals(System.DateTime)
		/// </summary>
		protected RMethod r_MEquals_DateTime;
		public virtual RMethod RMEquals_DateTime
		{
			get
			{
				if(r_MEquals_DateTime == null)
				{
					r_MEquals_DateTime = new(this, "Equals", 0, typeof(System.DateTime));
					r_MEquals_DateTime.SetBelong(this.GetValue());
				}
				return r_MEquals_DateTime;
			}
		}

		/// <summary>
		/// Boolean Equals(System.DateTime, System.DateTime)
		/// </summary>
		protected static RMethod r_MEquals_DateTime_DateTime;
		public static RMethod RMEquals_DateTime_DateTime
		{
			get
			{
				if(r_MEquals_DateTime_DateTime == null)
				{
					r_MEquals_DateTime_DateTime = new(typeof(System.DateTime), "Equals", 0, typeof(System.DateTime), typeof(System.DateTime));
					r_MEquals_DateTime_DateTime.SetBelong(null);
				}
				return r_MEquals_DateTime_DateTime;
			}
		}

		/// <summary>
		/// System.DateTime FromBinary(Int64)
		/// </summary>
		protected static RMethod r_MFromBinary_Int64;
		public static RMethod RMFromBinary_Int64
		{
			get
			{
				if(r_MFromBinary_Int64 == null)
				{
					r_MFromBinary_Int64 = new(typeof(System.DateTime), "FromBinary", 0, typeof(System.Int64));
					r_MFromBinary_Int64.SetBelong(null);
				}
				return r_MFromBinary_Int64;
			}
		}

		/// <summary>
		/// System.DateTime FromBinaryRaw(Int64)
		/// </summary>
		protected static RMethod r_MFromBinaryRaw_Int64;
		public static RMethod RMFromBinaryRaw_Int64
		{
			get
			{
				if(r_MFromBinaryRaw_Int64 == null)
				{
					r_MFromBinaryRaw_Int64 = new(typeof(System.DateTime), "FromBinaryRaw", 0, typeof(System.Int64));
					r_MFromBinaryRaw_Int64.SetBelong(null);
				}
				return r_MFromBinaryRaw_Int64;
			}
		}

		/// <summary>
		/// System.DateTime FromFileTime(Int64)
		/// </summary>
		protected static RMethod r_MFromFileTime_Int64;
		public static RMethod RMFromFileTime_Int64
		{
			get
			{
				if(r_MFromFileTime_Int64 == null)
				{
					r_MFromFileTime_Int64 = new(typeof(System.DateTime), "FromFileTime", 0, typeof(System.Int64));
					r_MFromFileTime_Int64.SetBelong(null);
				}
				return r_MFromFileTime_Int64;
			}
		}

		/// <summary>
		/// System.DateTime FromFileTimeUtc(Int64)
		/// </summary>
		protected static RMethod r_MFromFileTimeUtc_Int64;
		public static RMethod RMFromFileTimeUtc_Int64
		{
			get
			{
				if(r_MFromFileTimeUtc_Int64 == null)
				{
					r_MFromFileTimeUtc_Int64 = new(typeof(System.DateTime), "FromFileTimeUtc", 0, typeof(System.Int64));
					r_MFromFileTimeUtc_Int64.SetBelong(null);
				}
				return r_MFromFileTimeUtc_Int64;
			}
		}

		/// <summary>
		/// System.DateTime FromOADate(Double)
		/// </summary>
		protected static RMethod r_MFromOADate_Double;
		public static RMethod RMFromOADate_Double
		{
			get
			{
				if(r_MFromOADate_Double == null)
				{
					r_MFromOADate_Double = new(typeof(System.DateTime), "FromOADate", 0, typeof(System.Double));
					r_MFromOADate_Double.SetBelong(null);
				}
				return r_MFromOADate_Double;
			}
		}

		/// <summary>
		/// Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RMSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext = new(this, "System.Runtime.Serialization.ISerializable.GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext.SetBelong(this.GetValue());
				}
				return r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// Boolean IsDaylightSavingTime()
		/// </summary>
		protected RMethod r_MIsDaylightSavingTime;
		public virtual RMethod RMIsDaylightSavingTime
		{
			get
			{
				if(r_MIsDaylightSavingTime == null)
				{
					r_MIsDaylightSavingTime = new(this, "IsDaylightSavingTime", 0);
					r_MIsDaylightSavingTime.SetBelong(this.GetValue());
				}
				return r_MIsDaylightSavingTime;
			}
		}

		/// <summary>
		/// System.DateTime SpecifyKind(System.DateTime, System.DateTimeKind)
		/// </summary>
		protected static RMethod r_MSpecifyKind_DateTime_DateTimeKind;
		public static RMethod RMSpecifyKind_DateTime_DateTimeKind
		{
			get
			{
				if(r_MSpecifyKind_DateTime_DateTimeKind == null)
				{
					r_MSpecifyKind_DateTime_DateTimeKind = new(typeof(System.DateTime), "SpecifyKind", 0, typeof(System.DateTime), typeof(System.DateTimeKind));
					r_MSpecifyKind_DateTime_DateTimeKind.SetBelong(null);
				}
				return r_MSpecifyKind_DateTime_DateTimeKind;
			}
		}

		/// <summary>
		/// Int64 ToBinary()
		/// </summary>
		protected RMethod r_MToBinary;
		public virtual RMethod RMToBinary
		{
			get
			{
				if(r_MToBinary == null)
				{
					r_MToBinary = new(this, "ToBinary", 0);
					r_MToBinary.SetBelong(this.GetValue());
				}
				return r_MToBinary;
			}
		}

		/// <summary>
		/// Int32 GetDatePart(Int32)
		/// </summary>
		protected RMethod r_MGetDatePart_Int32;
		public virtual RMethod RMGetDatePart_Int32
		{
			get
			{
				if(r_MGetDatePart_Int32 == null)
				{
					r_MGetDatePart_Int32 = new(this, "GetDatePart", 0, typeof(System.Int32));
					r_MGetDatePart_Int32.SetBelong(this.GetValue());
				}
				return r_MGetDatePart_Int32;
			}
		}

		/// <summary>
		/// Void GetDatePart(Int32 ByRef, Int32 ByRef, Int32 ByRef)
		/// </summary>
		protected RMethod r_MGetDatePart_Out_Int32_Out_Int32_Out_Int32;
		public virtual RMethod RMGetDatePart_Out_Int32_Out_Int32_Out_Int32
		{
			get
			{
				if(r_MGetDatePart_Out_Int32_Out_Int32_Out_Int32 == null)
				{
					r_MGetDatePart_Out_Int32_Out_Int32_Out_Int32 = new(this, "GetDatePart", 0, typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_MGetDatePart_Out_Int32_Out_Int32_Out_Int32.SetBelong(this.GetValue());
				}
				return r_MGetDatePart_Out_Int32_Out_Int32_Out_Int32;
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
					r_MGetHashCode.SetBelong(this.GetValue());
				}
				return r_MGetHashCode;
			}
		}

		/// <summary>
		/// Boolean IsAmbiguousDaylightSavingTime()
		/// </summary>
		protected RMethod r_MIsAmbiguousDaylightSavingTime;
		public virtual RMethod RMIsAmbiguousDaylightSavingTime
		{
			get
			{
				if(r_MIsAmbiguousDaylightSavingTime == null)
				{
					r_MIsAmbiguousDaylightSavingTime = new(this, "IsAmbiguousDaylightSavingTime", 0);
					r_MIsAmbiguousDaylightSavingTime.SetBelong(this.GetValue());
				}
				return r_MIsAmbiguousDaylightSavingTime;
			}
		}

		/// <summary>
		/// Boolean IsLeapYear(Int32)
		/// </summary>
		protected static RMethod r_MIsLeapYear_Int32;
		public static RMethod RMIsLeapYear_Int32
		{
			get
			{
				if(r_MIsLeapYear_Int32 == null)
				{
					r_MIsLeapYear_Int32 = new(typeof(System.DateTime), "IsLeapYear", 0, typeof(System.Int32));
					r_MIsLeapYear_Int32.SetBelong(null);
				}
				return r_MIsLeapYear_Int32;
			}
		}

		/// <summary>
		/// System.DateTime Parse(System.String)
		/// </summary>
		protected static RMethod r_MParse_String;
		public static RMethod RMParse_String
		{
			get
			{
				if(r_MParse_String == null)
				{
					r_MParse_String = new(typeof(System.DateTime), "Parse", 0, typeof(System.String));
					r_MParse_String.SetBelong(null);
				}
				return r_MParse_String;
			}
		}

		/// <summary>
		/// System.DateTime Parse(System.String, System.IFormatProvider)
		/// </summary>
		protected static RMethod r_MParse_String_IFormatProvider;
		public static RMethod RMParse_String_IFormatProvider
		{
			get
			{
				if(r_MParse_String_IFormatProvider == null)
				{
					r_MParse_String_IFormatProvider = new(typeof(System.DateTime), "Parse", 0, typeof(System.String), typeof(System.IFormatProvider));
					r_MParse_String_IFormatProvider.SetBelong(null);
				}
				return r_MParse_String_IFormatProvider;
			}
		}

		/// <summary>
		/// System.DateTime Parse(System.String, System.IFormatProvider, System.Globalization.DateTimeStyles)
		/// </summary>
		protected static RMethod r_MParse_String_IFormatProvider_DateTimeStyles;
		public static RMethod RMParse_String_IFormatProvider_DateTimeStyles
		{
			get
			{
				if(r_MParse_String_IFormatProvider_DateTimeStyles == null)
				{
					r_MParse_String_IFormatProvider_DateTimeStyles = new(typeof(System.DateTime), "Parse", 0, typeof(System.String), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles));
					r_MParse_String_IFormatProvider_DateTimeStyles.SetBelong(null);
				}
				return r_MParse_String_IFormatProvider_DateTimeStyles;
			}
		}

		/// <summary>
		/// System.DateTime Parse(System.ReadOnlySpan`1[System.Char], System.IFormatProvider, System.Globalization.DateTimeStyles)
		/// </summary>
		protected static RMethod r_MParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles;
		public static RMethod RMParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles
		{
			get
			{
				if(r_MParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles == null)
				{
					r_MParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles = new(typeof(System.DateTime), "Parse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles));
					r_MParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles.SetBelong(null);
				}
				return r_MParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles;
			}
		}

		/// <summary>
		/// System.DateTime ParseExact(System.String, System.String, System.IFormatProvider)
		/// </summary>
		protected static RMethod r_MParseExact_String_String_IFormatProvider;
		public static RMethod RMParseExact_String_String_IFormatProvider
		{
			get
			{
				if(r_MParseExact_String_String_IFormatProvider == null)
				{
					r_MParseExact_String_String_IFormatProvider = new(typeof(System.DateTime), "ParseExact", 0, typeof(System.String), typeof(System.String), typeof(System.IFormatProvider));
					r_MParseExact_String_String_IFormatProvider.SetBelong(null);
				}
				return r_MParseExact_String_String_IFormatProvider;
			}
		}

		/// <summary>
		/// System.DateTime ParseExact(System.String, System.String, System.IFormatProvider, System.Globalization.DateTimeStyles)
		/// </summary>
		protected static RMethod r_MParseExact_String_String_IFormatProvider_DateTimeStyles;
		public static RMethod RMParseExact_String_String_IFormatProvider_DateTimeStyles
		{
			get
			{
				if(r_MParseExact_String_String_IFormatProvider_DateTimeStyles == null)
				{
					r_MParseExact_String_String_IFormatProvider_DateTimeStyles = new(typeof(System.DateTime), "ParseExact", 0, typeof(System.String), typeof(System.String), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles));
					r_MParseExact_String_String_IFormatProvider_DateTimeStyles.SetBelong(null);
				}
				return r_MParseExact_String_String_IFormatProvider_DateTimeStyles;
			}
		}

		/// <summary>
		/// System.DateTime ParseExact(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.IFormatProvider, System.Globalization.DateTimeStyles)
		/// </summary>
		protected static RMethod r_MParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles;
		public static RMethod RMParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles
		{
			get
			{
				if(r_MParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles == null)
				{
					r_MParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles = new(typeof(System.DateTime), "ParseExact", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles));
					r_MParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles.SetBelong(null);
				}
				return r_MParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles;
			}
		}

		/// <summary>
		/// System.DateTime ParseExact(System.String, System.String[], System.IFormatProvider, System.Globalization.DateTimeStyles)
		/// </summary>
		protected static RMethod r_MParseExact_String_StringArray_IFormatProvider_DateTimeStyles;
		public static RMethod RMParseExact_String_StringArray_IFormatProvider_DateTimeStyles
		{
			get
			{
				if(r_MParseExact_String_StringArray_IFormatProvider_DateTimeStyles == null)
				{
					r_MParseExact_String_StringArray_IFormatProvider_DateTimeStyles = new(typeof(System.DateTime), "ParseExact", 0, typeof(System.String), typeof(System.String).MakeArrayType(), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles));
					r_MParseExact_String_StringArray_IFormatProvider_DateTimeStyles.SetBelong(null);
				}
				return r_MParseExact_String_StringArray_IFormatProvider_DateTimeStyles;
			}
		}

		/// <summary>
		/// System.DateTime ParseExact(System.ReadOnlySpan`1[System.Char], System.String[], System.IFormatProvider, System.Globalization.DateTimeStyles)
		/// </summary>
		protected static RMethod r_MParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles;
		public static RMethod RMParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles
		{
			get
			{
				if(r_MParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles == null)
				{
					r_MParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles = new(typeof(System.DateTime), "ParseExact", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.String).MakeArrayType(), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles));
					r_MParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles.SetBelong(null);
				}
				return r_MParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles;
			}
		}

		/// <summary>
		/// System.TimeSpan Subtract(System.DateTime)
		/// </summary>
		protected RMethod r_MSubtract_DateTime;
		public virtual RMethod RMSubtract_DateTime
		{
			get
			{
				if(r_MSubtract_DateTime == null)
				{
					r_MSubtract_DateTime = new(this, "Subtract", 0, typeof(System.DateTime));
					r_MSubtract_DateTime.SetBelong(this.GetValue());
				}
				return r_MSubtract_DateTime;
			}
		}

		/// <summary>
		/// System.DateTime Subtract(System.TimeSpan)
		/// </summary>
		protected RMethod r_MSubtract_TimeSpan;
		public virtual RMethod RMSubtract_TimeSpan
		{
			get
			{
				if(r_MSubtract_TimeSpan == null)
				{
					r_MSubtract_TimeSpan = new(this, "Subtract", 0, typeof(System.TimeSpan));
					r_MSubtract_TimeSpan.SetBelong(this.GetValue());
				}
				return r_MSubtract_TimeSpan;
			}
		}

		/// <summary>
		/// Double TicksToOADate(Int64)
		/// </summary>
		protected static RMethod r_MTicksToOADate_Int64;
		public static RMethod RMTicksToOADate_Int64
		{
			get
			{
				if(r_MTicksToOADate_Int64 == null)
				{
					r_MTicksToOADate_Int64 = new(typeof(System.DateTime), "TicksToOADate", 0, typeof(System.Int64));
					r_MTicksToOADate_Int64.SetBelong(null);
				}
				return r_MTicksToOADate_Int64;
			}
		}

		/// <summary>
		/// Double ToOADate()
		/// </summary>
		protected RMethod r_MToOADate;
		public virtual RMethod RMToOADate
		{
			get
			{
				if(r_MToOADate == null)
				{
					r_MToOADate = new(this, "ToOADate", 0);
					r_MToOADate.SetBelong(this.GetValue());
				}
				return r_MToOADate;
			}
		}

		/// <summary>
		/// Int64 ToFileTime()
		/// </summary>
		protected RMethod r_MToFileTime;
		public virtual RMethod RMToFileTime
		{
			get
			{
				if(r_MToFileTime == null)
				{
					r_MToFileTime = new(this, "ToFileTime", 0);
					r_MToFileTime.SetBelong(this.GetValue());
				}
				return r_MToFileTime;
			}
		}

		/// <summary>
		/// Int64 ToFileTimeUtc()
		/// </summary>
		protected RMethod r_MToFileTimeUtc;
		public virtual RMethod RMToFileTimeUtc
		{
			get
			{
				if(r_MToFileTimeUtc == null)
				{
					r_MToFileTimeUtc = new(this, "ToFileTimeUtc", 0);
					r_MToFileTimeUtc.SetBelong(this.GetValue());
				}
				return r_MToFileTimeUtc;
			}
		}

		/// <summary>
		/// System.DateTime ToLocalTime()
		/// </summary>
		protected RMethod r_MToLocalTime;
		public virtual RMethod RMToLocalTime
		{
			get
			{
				if(r_MToLocalTime == null)
				{
					r_MToLocalTime = new(this, "ToLocalTime", 0);
					r_MToLocalTime.SetBelong(this.GetValue());
				}
				return r_MToLocalTime;
			}
		}

		/// <summary>
		/// System.DateTime ToLocalTime(Boolean)
		/// </summary>
		protected RMethod r_MToLocalTime_Boolean;
		public virtual RMethod RMToLocalTime_Boolean
		{
			get
			{
				if(r_MToLocalTime_Boolean == null)
				{
					r_MToLocalTime_Boolean = new(this, "ToLocalTime", 0, typeof(System.Boolean));
					r_MToLocalTime_Boolean.SetBelong(this.GetValue());
				}
				return r_MToLocalTime_Boolean;
			}
		}

		/// <summary>
		/// System.String ToLongDateString()
		/// </summary>
		protected RMethod r_MToLongDateString;
		public virtual RMethod RMToLongDateString
		{
			get
			{
				if(r_MToLongDateString == null)
				{
					r_MToLongDateString = new(this, "ToLongDateString", 0);
					r_MToLongDateString.SetBelong(this.GetValue());
				}
				return r_MToLongDateString;
			}
		}

		/// <summary>
		/// System.String ToLongTimeString()
		/// </summary>
		protected RMethod r_MToLongTimeString;
		public virtual RMethod RMToLongTimeString
		{
			get
			{
				if(r_MToLongTimeString == null)
				{
					r_MToLongTimeString = new(this, "ToLongTimeString", 0);
					r_MToLongTimeString.SetBelong(this.GetValue());
				}
				return r_MToLongTimeString;
			}
		}

		/// <summary>
		/// System.String ToShortDateString()
		/// </summary>
		protected RMethod r_MToShortDateString;
		public virtual RMethod RMToShortDateString
		{
			get
			{
				if(r_MToShortDateString == null)
				{
					r_MToShortDateString = new(this, "ToShortDateString", 0);
					r_MToShortDateString.SetBelong(this.GetValue());
				}
				return r_MToShortDateString;
			}
		}

		/// <summary>
		/// System.String ToShortTimeString()
		/// </summary>
		protected RMethod r_MToShortTimeString;
		public virtual RMethod RMToShortTimeString
		{
			get
			{
				if(r_MToShortTimeString == null)
				{
					r_MToShortTimeString = new(this, "ToShortTimeString", 0);
					r_MToShortTimeString.SetBelong(this.GetValue());
				}
				return r_MToShortTimeString;
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
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
					r_MToString_String.SetBelong(this.GetValue());
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
					r_MToString_IFormatProvider.SetBelong(this.GetValue());
				}
				return r_MToString_IFormatProvider;
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
					r_MToString_String_IFormatProvider.SetBelong(this.GetValue());
				}
				return r_MToString_String_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean TryFormat(System.Span`1[System.Char], Int32 ByRef, System.ReadOnlySpan`1[System.Char], System.IFormatProvider)
		/// </summary>
		protected RMethod r_MTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider;
		public virtual RMethod RMTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider
		{
			get
			{
				if(r_MTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider == null)
				{
					r_MTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider = new(this, "TryFormat", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Char)), typeof(System.Int32).MakeByRefType(), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider));
					r_MTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider.SetBelong(this.GetValue());
				}
				return r_MTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider;
			}
		}

		/// <summary>
		/// System.DateTime ToUniversalTime()
		/// </summary>
		protected RMethod r_MToUniversalTime;
		public virtual RMethod RMToUniversalTime
		{
			get
			{
				if(r_MToUniversalTime == null)
				{
					r_MToUniversalTime = new(this, "ToUniversalTime", 0);
					r_MToUniversalTime.SetBelong(this.GetValue());
				}
				return r_MToUniversalTime;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.String, System.DateTime ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_String_Out_DateTime;
		public static RMethod RMTryParse_String_Out_DateTime
		{
			get
			{
				if(r_MTryParse_String_Out_DateTime == null)
				{
					r_MTryParse_String_Out_DateTime = new(typeof(System.DateTime), "TryParse", 0, typeof(System.String), typeof(System.DateTime).MakeByRefType());
					r_MTryParse_String_Out_DateTime.SetBelong(null);
				}
				return r_MTryParse_String_Out_DateTime;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], System.DateTime ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_ReadOnlySpan_d_Char_p__Out_DateTime;
		public static RMethod RMTryParse_ReadOnlySpan_d_Char_p__Out_DateTime
		{
			get
			{
				if(r_MTryParse_ReadOnlySpan_d_Char_p__Out_DateTime == null)
				{
					r_MTryParse_ReadOnlySpan_d_Char_p__Out_DateTime = new(typeof(System.DateTime), "TryParse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.DateTime).MakeByRefType());
					r_MTryParse_ReadOnlySpan_d_Char_p__Out_DateTime.SetBelong(null);
				}
				return r_MTryParse_ReadOnlySpan_d_Char_p__Out_DateTime;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.String, System.IFormatProvider, System.Globalization.DateTimeStyles, System.DateTime ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_String_IFormatProvider_DateTimeStyles_Out_DateTime;
		public static RMethod RMTryParse_String_IFormatProvider_DateTimeStyles_Out_DateTime
		{
			get
			{
				if(r_MTryParse_String_IFormatProvider_DateTimeStyles_Out_DateTime == null)
				{
					r_MTryParse_String_IFormatProvider_DateTimeStyles_Out_DateTime = new(typeof(System.DateTime), "TryParse", 0, typeof(System.String), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles), typeof(System.DateTime).MakeByRefType());
					r_MTryParse_String_IFormatProvider_DateTimeStyles_Out_DateTime.SetBelong(null);
				}
				return r_MTryParse_String_IFormatProvider_DateTimeStyles_Out_DateTime;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], System.IFormatProvider, System.Globalization.DateTimeStyles, System.DateTime ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTime;
		public static RMethod RMTryParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTime
		{
			get
			{
				if(r_MTryParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTime == null)
				{
					r_MTryParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTime = new(typeof(System.DateTime), "TryParse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles), typeof(System.DateTime).MakeByRefType());
					r_MTryParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTime.SetBelong(null);
				}
				return r_MTryParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTime;
			}
		}

		/// <summary>
		/// Boolean TryParseExact(System.String, System.String, System.IFormatProvider, System.Globalization.DateTimeStyles, System.DateTime ByRef)
		/// </summary>
		protected static RMethod r_MTryParseExact_String_String_IFormatProvider_DateTimeStyles_Out_DateTime;
		public static RMethod RMTryParseExact_String_String_IFormatProvider_DateTimeStyles_Out_DateTime
		{
			get
			{
				if(r_MTryParseExact_String_String_IFormatProvider_DateTimeStyles_Out_DateTime == null)
				{
					r_MTryParseExact_String_String_IFormatProvider_DateTimeStyles_Out_DateTime = new(typeof(System.DateTime), "TryParseExact", 0, typeof(System.String), typeof(System.String), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles), typeof(System.DateTime).MakeByRefType());
					r_MTryParseExact_String_String_IFormatProvider_DateTimeStyles_Out_DateTime.SetBelong(null);
				}
				return r_MTryParseExact_String_String_IFormatProvider_DateTimeStyles_Out_DateTime;
			}
		}

		/// <summary>
		/// Boolean TryParseExact(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.IFormatProvider, System.Globalization.DateTimeStyles, System.DateTime ByRef)
		/// </summary>
		protected static RMethod r_MTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTime;
		public static RMethod RMTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTime
		{
			get
			{
				if(r_MTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTime == null)
				{
					r_MTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTime = new(typeof(System.DateTime), "TryParseExact", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles), typeof(System.DateTime).MakeByRefType());
					r_MTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTime.SetBelong(null);
				}
				return r_MTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTime;
			}
		}

		/// <summary>
		/// Boolean TryParseExact(System.String, System.String[], System.IFormatProvider, System.Globalization.DateTimeStyles, System.DateTime ByRef)
		/// </summary>
		protected static RMethod r_MTryParseExact_String_StringArray_IFormatProvider_DateTimeStyles_Out_DateTime;
		public static RMethod RMTryParseExact_String_StringArray_IFormatProvider_DateTimeStyles_Out_DateTime
		{
			get
			{
				if(r_MTryParseExact_String_StringArray_IFormatProvider_DateTimeStyles_Out_DateTime == null)
				{
					r_MTryParseExact_String_StringArray_IFormatProvider_DateTimeStyles_Out_DateTime = new(typeof(System.DateTime), "TryParseExact", 0, typeof(System.String), typeof(System.String).MakeArrayType(), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles), typeof(System.DateTime).MakeByRefType());
					r_MTryParseExact_String_StringArray_IFormatProvider_DateTimeStyles_Out_DateTime.SetBelong(null);
				}
				return r_MTryParseExact_String_StringArray_IFormatProvider_DateTimeStyles_Out_DateTime;
			}
		}

		/// <summary>
		/// Boolean TryParseExact(System.ReadOnlySpan`1[System.Char], System.String[], System.IFormatProvider, System.Globalization.DateTimeStyles, System.DateTime ByRef)
		/// </summary>
		protected static RMethod r_MTryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles_Out_DateTime;
		public static RMethod RMTryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles_Out_DateTime
		{
			get
			{
				if(r_MTryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles_Out_DateTime == null)
				{
					r_MTryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles_Out_DateTime = new(typeof(System.DateTime), "TryParseExact", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.String).MakeArrayType(), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles), typeof(System.DateTime).MakeByRefType());
					r_MTryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles_Out_DateTime.SetBelong(null);
				}
				return r_MTryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles_Out_DateTime;
			}
		}

		/// <summary>
		/// System.DateTime op_Addition(System.DateTime, System.TimeSpan)
		/// </summary>
		protected static RMethod r_Mop_Addition_DateTime_TimeSpan;
		public static RMethod RMop_Addition_DateTime_TimeSpan
		{
			get
			{
				if(r_Mop_Addition_DateTime_TimeSpan == null)
				{
					r_Mop_Addition_DateTime_TimeSpan = new(typeof(System.DateTime), "op_Addition", 0, typeof(System.DateTime), typeof(System.TimeSpan));
					r_Mop_Addition_DateTime_TimeSpan.SetBelong(null);
				}
				return r_Mop_Addition_DateTime_TimeSpan;
			}
		}

		/// <summary>
		/// System.DateTime op_Subtraction(System.DateTime, System.TimeSpan)
		/// </summary>
		protected static RMethod r_Mop_Subtraction_DateTime_TimeSpan;
		public static RMethod RMop_Subtraction_DateTime_TimeSpan
		{
			get
			{
				if(r_Mop_Subtraction_DateTime_TimeSpan == null)
				{
					r_Mop_Subtraction_DateTime_TimeSpan = new(typeof(System.DateTime), "op_Subtraction", 0, typeof(System.DateTime), typeof(System.TimeSpan));
					r_Mop_Subtraction_DateTime_TimeSpan.SetBelong(null);
				}
				return r_Mop_Subtraction_DateTime_TimeSpan;
			}
		}

		/// <summary>
		/// System.TimeSpan op_Subtraction(System.DateTime, System.DateTime)
		/// </summary>
		protected static RMethod r_Mop_Subtraction_DateTime_DateTime;
		public static RMethod RMop_Subtraction_DateTime_DateTime
		{
			get
			{
				if(r_Mop_Subtraction_DateTime_DateTime == null)
				{
					r_Mop_Subtraction_DateTime_DateTime = new(typeof(System.DateTime), "op_Subtraction", 0, typeof(System.DateTime), typeof(System.DateTime));
					r_Mop_Subtraction_DateTime_DateTime.SetBelong(null);
				}
				return r_Mop_Subtraction_DateTime_DateTime;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.DateTime, System.DateTime)
		/// </summary>
		protected static RMethod r_Mop_Equality_DateTime_DateTime;
		public static RMethod RMop_Equality_DateTime_DateTime
		{
			get
			{
				if(r_Mop_Equality_DateTime_DateTime == null)
				{
					r_Mop_Equality_DateTime_DateTime = new(typeof(System.DateTime), "op_Equality", 0, typeof(System.DateTime), typeof(System.DateTime));
					r_Mop_Equality_DateTime_DateTime.SetBelong(null);
				}
				return r_Mop_Equality_DateTime_DateTime;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.DateTime, System.DateTime)
		/// </summary>
		protected static RMethod r_Mop_Inequality_DateTime_DateTime;
		public static RMethod RMop_Inequality_DateTime_DateTime
		{
			get
			{
				if(r_Mop_Inequality_DateTime_DateTime == null)
				{
					r_Mop_Inequality_DateTime_DateTime = new(typeof(System.DateTime), "op_Inequality", 0, typeof(System.DateTime), typeof(System.DateTime));
					r_Mop_Inequality_DateTime_DateTime.SetBelong(null);
				}
				return r_Mop_Inequality_DateTime_DateTime;
			}
		}

		/// <summary>
		/// Boolean op_LessThan(System.DateTime, System.DateTime)
		/// </summary>
		protected static RMethod r_Mop_LessThan_DateTime_DateTime;
		public static RMethod RMop_LessThan_DateTime_DateTime
		{
			get
			{
				if(r_Mop_LessThan_DateTime_DateTime == null)
				{
					r_Mop_LessThan_DateTime_DateTime = new(typeof(System.DateTime), "op_LessThan", 0, typeof(System.DateTime), typeof(System.DateTime));
					r_Mop_LessThan_DateTime_DateTime.SetBelong(null);
				}
				return r_Mop_LessThan_DateTime_DateTime;
			}
		}

		/// <summary>
		/// Boolean op_LessThanOrEqual(System.DateTime, System.DateTime)
		/// </summary>
		protected static RMethod r_Mop_LessThanOrEqual_DateTime_DateTime;
		public static RMethod RMop_LessThanOrEqual_DateTime_DateTime
		{
			get
			{
				if(r_Mop_LessThanOrEqual_DateTime_DateTime == null)
				{
					r_Mop_LessThanOrEqual_DateTime_DateTime = new(typeof(System.DateTime), "op_LessThanOrEqual", 0, typeof(System.DateTime), typeof(System.DateTime));
					r_Mop_LessThanOrEqual_DateTime_DateTime.SetBelong(null);
				}
				return r_Mop_LessThanOrEqual_DateTime_DateTime;
			}
		}

		/// <summary>
		/// Boolean op_GreaterThan(System.DateTime, System.DateTime)
		/// </summary>
		protected static RMethod r_Mop_GreaterThan_DateTime_DateTime;
		public static RMethod RMop_GreaterThan_DateTime_DateTime
		{
			get
			{
				if(r_Mop_GreaterThan_DateTime_DateTime == null)
				{
					r_Mop_GreaterThan_DateTime_DateTime = new(typeof(System.DateTime), "op_GreaterThan", 0, typeof(System.DateTime), typeof(System.DateTime));
					r_Mop_GreaterThan_DateTime_DateTime.SetBelong(null);
				}
				return r_Mop_GreaterThan_DateTime_DateTime;
			}
		}

		/// <summary>
		/// Boolean op_GreaterThanOrEqual(System.DateTime, System.DateTime)
		/// </summary>
		protected static RMethod r_Mop_GreaterThanOrEqual_DateTime_DateTime;
		public static RMethod RMop_GreaterThanOrEqual_DateTime_DateTime
		{
			get
			{
				if(r_Mop_GreaterThanOrEqual_DateTime_DateTime == null)
				{
					r_Mop_GreaterThanOrEqual_DateTime_DateTime = new(typeof(System.DateTime), "op_GreaterThanOrEqual", 0, typeof(System.DateTime), typeof(System.DateTime));
					r_Mop_GreaterThanOrEqual_DateTime_DateTime.SetBelong(null);
				}
				return r_Mop_GreaterThanOrEqual_DateTime_DateTime;
			}
		}

		/// <summary>
		/// System.String[] GetDateTimeFormats()
		/// </summary>
		protected RMethod r_MGetDateTimeFormats;
		public virtual RMethod RMGetDateTimeFormats
		{
			get
			{
				if(r_MGetDateTimeFormats == null)
				{
					r_MGetDateTimeFormats = new(this, "GetDateTimeFormats", 0);
					r_MGetDateTimeFormats.SetBelong(this.GetValue());
				}
				return r_MGetDateTimeFormats;
			}
		}

		/// <summary>
		/// System.String[] GetDateTimeFormats(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MGetDateTimeFormats_IFormatProvider;
		public virtual RMethod RMGetDateTimeFormats_IFormatProvider
		{
			get
			{
				if(r_MGetDateTimeFormats_IFormatProvider == null)
				{
					r_MGetDateTimeFormats_IFormatProvider = new(this, "GetDateTimeFormats", 0, typeof(System.IFormatProvider));
					r_MGetDateTimeFormats_IFormatProvider.SetBelong(this.GetValue());
				}
				return r_MGetDateTimeFormats_IFormatProvider;
			}
		}

		/// <summary>
		/// System.String[] GetDateTimeFormats(Char)
		/// </summary>
		protected RMethod r_MGetDateTimeFormats_Char;
		public virtual RMethod RMGetDateTimeFormats_Char
		{
			get
			{
				if(r_MGetDateTimeFormats_Char == null)
				{
					r_MGetDateTimeFormats_Char = new(this, "GetDateTimeFormats", 0, typeof(System.Char));
					r_MGetDateTimeFormats_Char.SetBelong(this.GetValue());
				}
				return r_MGetDateTimeFormats_Char;
			}
		}

		/// <summary>
		/// System.String[] GetDateTimeFormats(Char, System.IFormatProvider)
		/// </summary>
		protected RMethod r_MGetDateTimeFormats_Char_IFormatProvider;
		public virtual RMethod RMGetDateTimeFormats_Char_IFormatProvider
		{
			get
			{
				if(r_MGetDateTimeFormats_Char_IFormatProvider == null)
				{
					r_MGetDateTimeFormats_Char_IFormatProvider = new(this, "GetDateTimeFormats", 0, typeof(System.Char), typeof(System.IFormatProvider));
					r_MGetDateTimeFormats_Char_IFormatProvider.SetBelong(this.GetValue());
				}
				return r_MGetDateTimeFormats_Char_IFormatProvider;
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
					r_MGetTypeCode.SetBelong(this.GetValue());
				}
				return r_MGetTypeCode;
			}
		}

		/// <summary>
		/// Boolean System.IConvertible.ToBoolean(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MSystem__2__IConvertible__2__ToBoolean_IFormatProvider;
		public virtual RMethod RMSystem__2__IConvertible__2__ToBoolean_IFormatProvider
		{
			get
			{
				if(r_MSystem__2__IConvertible__2__ToBoolean_IFormatProvider == null)
				{
					r_MSystem__2__IConvertible__2__ToBoolean_IFormatProvider = new(this, "System.IConvertible.ToBoolean", 0, typeof(System.IFormatProvider));
					r_MSystem__2__IConvertible__2__ToBoolean_IFormatProvider.SetBelong(this.GetValue());
				}
				return r_MSystem__2__IConvertible__2__ToBoolean_IFormatProvider;
			}
		}

		/// <summary>
		/// Char System.IConvertible.ToChar(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MSystem__2__IConvertible__2__ToChar_IFormatProvider;
		public virtual RMethod RMSystem__2__IConvertible__2__ToChar_IFormatProvider
		{
			get
			{
				if(r_MSystem__2__IConvertible__2__ToChar_IFormatProvider == null)
				{
					r_MSystem__2__IConvertible__2__ToChar_IFormatProvider = new(this, "System.IConvertible.ToChar", 0, typeof(System.IFormatProvider));
					r_MSystem__2__IConvertible__2__ToChar_IFormatProvider.SetBelong(this.GetValue());
				}
				return r_MSystem__2__IConvertible__2__ToChar_IFormatProvider;
			}
		}

		/// <summary>
		/// SByte System.IConvertible.ToSByte(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MSystem__2__IConvertible__2__ToSByte_IFormatProvider;
		public virtual RMethod RMSystem__2__IConvertible__2__ToSByte_IFormatProvider
		{
			get
			{
				if(r_MSystem__2__IConvertible__2__ToSByte_IFormatProvider == null)
				{
					r_MSystem__2__IConvertible__2__ToSByte_IFormatProvider = new(this, "System.IConvertible.ToSByte", 0, typeof(System.IFormatProvider));
					r_MSystem__2__IConvertible__2__ToSByte_IFormatProvider.SetBelong(this.GetValue());
				}
				return r_MSystem__2__IConvertible__2__ToSByte_IFormatProvider;
			}
		}

		/// <summary>
		/// Byte System.IConvertible.ToByte(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MSystem__2__IConvertible__2__ToByte_IFormatProvider;
		public virtual RMethod RMSystem__2__IConvertible__2__ToByte_IFormatProvider
		{
			get
			{
				if(r_MSystem__2__IConvertible__2__ToByte_IFormatProvider == null)
				{
					r_MSystem__2__IConvertible__2__ToByte_IFormatProvider = new(this, "System.IConvertible.ToByte", 0, typeof(System.IFormatProvider));
					r_MSystem__2__IConvertible__2__ToByte_IFormatProvider.SetBelong(this.GetValue());
				}
				return r_MSystem__2__IConvertible__2__ToByte_IFormatProvider;
			}
		}

		/// <summary>
		/// Int16 System.IConvertible.ToInt16(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MSystem__2__IConvertible__2__ToInt16_IFormatProvider;
		public virtual RMethod RMSystem__2__IConvertible__2__ToInt16_IFormatProvider
		{
			get
			{
				if(r_MSystem__2__IConvertible__2__ToInt16_IFormatProvider == null)
				{
					r_MSystem__2__IConvertible__2__ToInt16_IFormatProvider = new(this, "System.IConvertible.ToInt16", 0, typeof(System.IFormatProvider));
					r_MSystem__2__IConvertible__2__ToInt16_IFormatProvider.SetBelong(this.GetValue());
				}
				return r_MSystem__2__IConvertible__2__ToInt16_IFormatProvider;
			}
		}

		/// <summary>
		/// UInt16 System.IConvertible.ToUInt16(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MSystem__2__IConvertible__2__ToUInt16_IFormatProvider;
		public virtual RMethod RMSystem__2__IConvertible__2__ToUInt16_IFormatProvider
		{
			get
			{
				if(r_MSystem__2__IConvertible__2__ToUInt16_IFormatProvider == null)
				{
					r_MSystem__2__IConvertible__2__ToUInt16_IFormatProvider = new(this, "System.IConvertible.ToUInt16", 0, typeof(System.IFormatProvider));
					r_MSystem__2__IConvertible__2__ToUInt16_IFormatProvider.SetBelong(this.GetValue());
				}
				return r_MSystem__2__IConvertible__2__ToUInt16_IFormatProvider;
			}
		}

		/// <summary>
		/// Int32 System.IConvertible.ToInt32(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MSystem__2__IConvertible__2__ToInt32_IFormatProvider;
		public virtual RMethod RMSystem__2__IConvertible__2__ToInt32_IFormatProvider
		{
			get
			{
				if(r_MSystem__2__IConvertible__2__ToInt32_IFormatProvider == null)
				{
					r_MSystem__2__IConvertible__2__ToInt32_IFormatProvider = new(this, "System.IConvertible.ToInt32", 0, typeof(System.IFormatProvider));
					r_MSystem__2__IConvertible__2__ToInt32_IFormatProvider.SetBelong(this.GetValue());
				}
				return r_MSystem__2__IConvertible__2__ToInt32_IFormatProvider;
			}
		}

		/// <summary>
		/// UInt32 System.IConvertible.ToUInt32(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MSystem__2__IConvertible__2__ToUInt32_IFormatProvider;
		public virtual RMethod RMSystem__2__IConvertible__2__ToUInt32_IFormatProvider
		{
			get
			{
				if(r_MSystem__2__IConvertible__2__ToUInt32_IFormatProvider == null)
				{
					r_MSystem__2__IConvertible__2__ToUInt32_IFormatProvider = new(this, "System.IConvertible.ToUInt32", 0, typeof(System.IFormatProvider));
					r_MSystem__2__IConvertible__2__ToUInt32_IFormatProvider.SetBelong(this.GetValue());
				}
				return r_MSystem__2__IConvertible__2__ToUInt32_IFormatProvider;
			}
		}

		/// <summary>
		/// Int64 System.IConvertible.ToInt64(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MSystem__2__IConvertible__2__ToInt64_IFormatProvider;
		public virtual RMethod RMSystem__2__IConvertible__2__ToInt64_IFormatProvider
		{
			get
			{
				if(r_MSystem__2__IConvertible__2__ToInt64_IFormatProvider == null)
				{
					r_MSystem__2__IConvertible__2__ToInt64_IFormatProvider = new(this, "System.IConvertible.ToInt64", 0, typeof(System.IFormatProvider));
					r_MSystem__2__IConvertible__2__ToInt64_IFormatProvider.SetBelong(this.GetValue());
				}
				return r_MSystem__2__IConvertible__2__ToInt64_IFormatProvider;
			}
		}

		/// <summary>
		/// UInt64 System.IConvertible.ToUInt64(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MSystem__2__IConvertible__2__ToUInt64_IFormatProvider;
		public virtual RMethod RMSystem__2__IConvertible__2__ToUInt64_IFormatProvider
		{
			get
			{
				if(r_MSystem__2__IConvertible__2__ToUInt64_IFormatProvider == null)
				{
					r_MSystem__2__IConvertible__2__ToUInt64_IFormatProvider = new(this, "System.IConvertible.ToUInt64", 0, typeof(System.IFormatProvider));
					r_MSystem__2__IConvertible__2__ToUInt64_IFormatProvider.SetBelong(this.GetValue());
				}
				return r_MSystem__2__IConvertible__2__ToUInt64_IFormatProvider;
			}
		}

		/// <summary>
		/// Single System.IConvertible.ToSingle(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MSystem__2__IConvertible__2__ToSingle_IFormatProvider;
		public virtual RMethod RMSystem__2__IConvertible__2__ToSingle_IFormatProvider
		{
			get
			{
				if(r_MSystem__2__IConvertible__2__ToSingle_IFormatProvider == null)
				{
					r_MSystem__2__IConvertible__2__ToSingle_IFormatProvider = new(this, "System.IConvertible.ToSingle", 0, typeof(System.IFormatProvider));
					r_MSystem__2__IConvertible__2__ToSingle_IFormatProvider.SetBelong(this.GetValue());
				}
				return r_MSystem__2__IConvertible__2__ToSingle_IFormatProvider;
			}
		}

		/// <summary>
		/// Double System.IConvertible.ToDouble(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MSystem__2__IConvertible__2__ToDouble_IFormatProvider;
		public virtual RMethod RMSystem__2__IConvertible__2__ToDouble_IFormatProvider
		{
			get
			{
				if(r_MSystem__2__IConvertible__2__ToDouble_IFormatProvider == null)
				{
					r_MSystem__2__IConvertible__2__ToDouble_IFormatProvider = new(this, "System.IConvertible.ToDouble", 0, typeof(System.IFormatProvider));
					r_MSystem__2__IConvertible__2__ToDouble_IFormatProvider.SetBelong(this.GetValue());
				}
				return r_MSystem__2__IConvertible__2__ToDouble_IFormatProvider;
			}
		}

		/// <summary>
		/// System.Decimal System.IConvertible.ToDecimal(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MSystem__2__IConvertible__2__ToDecimal_IFormatProvider;
		public virtual RMethod RMSystem__2__IConvertible__2__ToDecimal_IFormatProvider
		{
			get
			{
				if(r_MSystem__2__IConvertible__2__ToDecimal_IFormatProvider == null)
				{
					r_MSystem__2__IConvertible__2__ToDecimal_IFormatProvider = new(this, "System.IConvertible.ToDecimal", 0, typeof(System.IFormatProvider));
					r_MSystem__2__IConvertible__2__ToDecimal_IFormatProvider.SetBelong(this.GetValue());
				}
				return r_MSystem__2__IConvertible__2__ToDecimal_IFormatProvider;
			}
		}

		/// <summary>
		/// System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MSystem__2__IConvertible__2__ToDateTime_IFormatProvider;
		public virtual RMethod RMSystem__2__IConvertible__2__ToDateTime_IFormatProvider
		{
			get
			{
				if(r_MSystem__2__IConvertible__2__ToDateTime_IFormatProvider == null)
				{
					r_MSystem__2__IConvertible__2__ToDateTime_IFormatProvider = new(this, "System.IConvertible.ToDateTime", 0, typeof(System.IFormatProvider));
					r_MSystem__2__IConvertible__2__ToDateTime_IFormatProvider.SetBelong(this.GetValue());
				}
				return r_MSystem__2__IConvertible__2__ToDateTime_IFormatProvider;
			}
		}

		/// <summary>
		/// System.Object System.IConvertible.ToType(System.Type, System.IFormatProvider)
		/// </summary>
		protected RMethod r_MSystem__2__IConvertible__2__ToType_Type_IFormatProvider;
		public virtual RMethod RMSystem__2__IConvertible__2__ToType_Type_IFormatProvider
		{
			get
			{
				if(r_MSystem__2__IConvertible__2__ToType_Type_IFormatProvider == null)
				{
					r_MSystem__2__IConvertible__2__ToType_Type_IFormatProvider = new(this, "System.IConvertible.ToType", 0, typeof(System.Type), typeof(System.IFormatProvider));
					r_MSystem__2__IConvertible__2__ToType_Type_IFormatProvider.SetBelong(this.GetValue());
				}
				return r_MSystem__2__IConvertible__2__ToType_Type_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean TryCreate(Int32, Int32, Int32, Int32, Int32, Int32, Int32, System.DateTime ByRef)
		/// </summary>
		protected static RMethod r_MTryCreate_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Out_DateTime;
		public static RMethod RMTryCreate_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Out_DateTime
		{
			get
			{
				if(r_MTryCreate_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Out_DateTime == null)
				{
					r_MTryCreate_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Out_DateTime = new(typeof(System.DateTime), "TryCreate", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.DateTime).MakeByRefType());
					r_MTryCreate_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Out_DateTime.SetBelong(null);
				}
				return r_MTryCreate_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Out_DateTime;
			}
		}

		/// <summary>
		/// Int64 GetSystemTimeAsFileTime()
		/// </summary>
		protected static RMethod r_MGetSystemTimeAsFileTime;
		public static RMethod RMGetSystemTimeAsFileTime
		{
			get
			{
				if(r_MGetSystemTimeAsFileTime == null)
				{
					r_MGetSystemTimeAsFileTime = new(typeof(System.DateTime), "GetSystemTimeAsFileTime", 0);
					r_MGetSystemTimeAsFileTime.SetBelong(null);
				}
				return r_MGetSystemTimeAsFileTime;
			}
		}

		/// <summary>
		/// Int64 ToBinaryRaw()
		/// </summary>
		protected RMethod r_MToBinaryRaw;
		public virtual RMethod RMToBinaryRaw
		{
			get
			{
				if(r_MToBinaryRaw == null)
				{
					r_MToBinaryRaw = new(this, "ToBinaryRaw", 0);
					r_MToBinaryRaw.SetBelong(this.GetValue());
				}
				return r_MToBinaryRaw;
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
				}
				return r_MMemberwiseClone;
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
            var ___result = RMAdd_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime Add(System.Double @value, System.Int32 @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @scale};
            var ___result = RMAdd_Double_Int32.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime AddDays(System.Double @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMAddDays_Double.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime AddHours(System.Double @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMAddHours_Double.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime AddMilliseconds(System.Double @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMAddMilliseconds_Double.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime AddMinutes(System.Double @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMAddMinutes_Double.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime AddMonths(System.Int32 @months)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@months};
            var ___result = RMAddMonths_Int32.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime AddSeconds(System.Double @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMAddSeconds_Double.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime AddTicks(System.Int64 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMAddTicks_Int64.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime AddYears(System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMAddYears_Int32.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.Int32 Compare(System.DateTime @t1, System.DateTime @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = RMCompare_DateTime_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareTo(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareTo(System.DateTime @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMCompareTo_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int64 DateToTicks(System.Int32 @year, System.Int32 @month, System.Int32 @day)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @month, @day};
            var ___result = RMDateToTicks_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public static System.Int64 TimeToTicks(System.Int32 @hour, System.Int32 @minute, System.Int32 @second)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hour, @minute, @second};
            var ___result = RMTimeToTicks_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public static System.Int32 DaysInMonth(System.Int32 @year, System.Int32 @month)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @month};
            var ___result = RMDaysInMonth_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int64 DoubleDateToTicks(System.Double @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMDoubleDateToTicks_Double.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.Boolean Equals(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.DateTime @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMEquals_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean Equals(System.DateTime @t1, System.DateTime @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = RMEquals_DateTime_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.DateTime FromBinary(System.Int64 @dateData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dateData};
            var ___result = RMFromBinary_Int64.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.DateTime FromBinaryRaw(System.Int64 @dateData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dateData};
            var ___result = RMFromBinaryRaw_Int64.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.DateTime FromFileTime(System.Int64 @fileTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileTime};
            var ___result = RMFromFileTime_Int64.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.DateTime FromFileTimeUtc(System.Int64 @fileTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileTime};
            var ___result = RMFromFileTimeUtc_Int64.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.DateTime FromOADate(System.Double @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMFromOADate_Double.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual void System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsDaylightSavingTime()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsDaylightSavingTime.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.DateTime SpecifyKind(System.DateTime @value, System.DateTimeKind @kind)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @kind};
            var ___result = RMSpecifyKind_DateTime_DateTimeKind.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.Int64 ToBinary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToBinary.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.Int32 GetDatePart(System.Int32 @part)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@part};
            var ___result = RMGetDatePart_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void GetDatePart(out System.Int32 @year, out System.Int32 @month, out System.Int32 @day)
        {
			@year = default;
			@month = default;
			@day = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @month, @day};
            var ___result = RMGetDatePart_Out_Int32_Out_Int32_Out_Int32.Invoke(___genericsType, ___parameters);
			@year = (System.Int32)___parameters[0];
			@month = (System.Int32)___parameters[1];
			@day = (System.Int32)___parameters[2];

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean IsAmbiguousDaylightSavingTime()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsAmbiguousDaylightSavingTime.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsLeapYear(System.Int32 @year)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year};
            var ___result = RMIsLeapYear_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.DateTime Parse(System.String @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RMParse_String.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.DateTime Parse(System.String @s, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @provider};
            var ___result = RMParse_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.DateTime Parse(System.String @s, System.IFormatProvider @provider, System.Globalization.DateTimeStyles @styles)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @provider, @styles};
            var ___result = RMParse_String_IFormatProvider_DateTimeStyles.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.DateTime Parse(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @s, System.IFormatProvider @provider, System.Globalization.DateTimeStyles @styles)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @provider, @styles};
            var ___result = RMParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.DateTime ParseExact(System.String @s, System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @format, @provider};
            var ___result = RMParseExact_String_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.DateTime ParseExact(System.String @s, System.String @format, System.IFormatProvider @provider, System.Globalization.DateTimeStyles @style)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @format, @provider, @style};
            var ___result = RMParseExact_String_String_IFormatProvider_DateTimeStyles.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.DateTime ParseExact(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @s, Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @format, System.IFormatProvider @provider, System.Globalization.DateTimeStyles @style)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @format.Value, @provider, @style};
            var ___result = RMParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.DateTime ParseExact(System.String @s, System.String[] @formats, System.IFormatProvider @provider, System.Globalization.DateTimeStyles @style)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @formats, @provider, @style};
            var ___result = RMParseExact_String_StringArray_IFormatProvider_DateTimeStyles.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.DateTime ParseExact(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @s, System.String[] @formats, System.IFormatProvider @provider, System.Globalization.DateTimeStyles @style)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @formats, @provider, @style};
            var ___result = RMParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.TimeSpan Subtract(System.DateTime @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSubtract_DateTime.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public virtual System.DateTime Subtract(System.TimeSpan @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSubtract_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.Double TicksToOADate(System.Int64 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMTicksToOADate_Int64.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Double ToOADate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToOADate.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Int64 ToFileTime()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToFileTime.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.Int64 ToFileTimeUtc()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToFileTimeUtc.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.DateTime ToLocalTime()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToLocalTime.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime ToLocalTime(System.Boolean @throwOnOverflow)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@throwOnOverflow};
            var ___result = RMToLocalTime_Boolean.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.String ToLongDateString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToLongDateString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToLongTimeString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToLongTimeString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToShortDateString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToShortDateString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToShortTimeString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToShortTimeString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean TryFormat(Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RSystem.RChar> @destination, out System.Int32 @charsWritten, Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @format, System.IFormatProvider @provider)
        {
			@charsWritten = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination.Value, @charsWritten, @format.Value, @provider};
            var ___result = RMTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider.Invoke(___genericsType, ___parameters);
			@charsWritten = (System.Int32)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.DateTime ToUniversalTime()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToUniversalTime.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.Boolean TryParse(System.String @s, out System.DateTime @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @result};
            var ___result = RMTryParse_String_Out_DateTime.Invoke(___genericsType, ___parameters);
			@result = (System.DateTime)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParse(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @s, out System.DateTime @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @result};
            var ___result = RMTryParse_ReadOnlySpan_d_Char_p__Out_DateTime.Invoke(___genericsType, ___parameters);
			@result = (System.DateTime)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParse(System.String @s, System.IFormatProvider @provider, System.Globalization.DateTimeStyles @styles, out System.DateTime @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @provider, @styles, @result};
            var ___result = RMTryParse_String_IFormatProvider_DateTimeStyles_Out_DateTime.Invoke(___genericsType, ___parameters);
			@result = (System.DateTime)___parameters[3];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParse(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @s, System.IFormatProvider @provider, System.Globalization.DateTimeStyles @styles, out System.DateTime @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @provider, @styles, @result};
            var ___result = RMTryParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTime.Invoke(___genericsType, ___parameters);
			@result = (System.DateTime)___parameters[3];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParseExact(System.String @s, System.String @format, System.IFormatProvider @provider, System.Globalization.DateTimeStyles @style, out System.DateTime @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @format, @provider, @style, @result};
            var ___result = RMTryParseExact_String_String_IFormatProvider_DateTimeStyles_Out_DateTime.Invoke(___genericsType, ___parameters);
			@result = (System.DateTime)___parameters[4];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParseExact(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @s, Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @format, System.IFormatProvider @provider, System.Globalization.DateTimeStyles @style, out System.DateTime @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @format.Value, @provider, @style, @result};
            var ___result = RMTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTime.Invoke(___genericsType, ___parameters);
			@result = (System.DateTime)___parameters[4];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParseExact(System.String @s, System.String[] @formats, System.IFormatProvider @provider, System.Globalization.DateTimeStyles @style, out System.DateTime @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @formats, @provider, @style, @result};
            var ___result = RMTryParseExact_String_StringArray_IFormatProvider_DateTimeStyles_Out_DateTime.Invoke(___genericsType, ___parameters);
			@result = (System.DateTime)___parameters[4];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParseExact(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @s, System.String[] @formats, System.IFormatProvider @provider, System.Globalization.DateTimeStyles @style, out System.DateTime @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @formats, @provider, @style, @result};
            var ___result = RMTryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles_Out_DateTime.Invoke(___genericsType, ___parameters);
			@result = (System.DateTime)___parameters[4];

            return (System.Boolean)___result;
        }


        public static System.DateTime op_Addition(System.DateTime @d, System.TimeSpan @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d, @t};
            var ___result = RMop_Addition_DateTime_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.DateTime op_Subtraction(System.DateTime @d, System.TimeSpan @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d, @t};
            var ___result = RMop_Subtraction_DateTime_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.TimeSpan op_Subtraction(System.DateTime @d1, System.DateTime @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RMop_Subtraction_DateTime_DateTime.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.Boolean op_Equality(System.DateTime @d1, System.DateTime @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RMop_Equality_DateTime_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.DateTime @d1, System.DateTime @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RMop_Inequality_DateTime_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_LessThan(System.DateTime @t1, System.DateTime @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = RMop_LessThan_DateTime_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_LessThanOrEqual(System.DateTime @t1, System.DateTime @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = RMop_LessThanOrEqual_DateTime_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_GreaterThan(System.DateTime @t1, System.DateTime @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = RMop_GreaterThan_DateTime_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_GreaterThanOrEqual(System.DateTime @t1, System.DateTime @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = RMop_GreaterThanOrEqual_DateTime_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String[] GetDateTimeFormats()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDateTimeFormats.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] GetDateTimeFormats(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMGetDateTimeFormats_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] GetDateTimeFormats(System.Char @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMGetDateTimeFormats_Char.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] GetDateTimeFormats(System.Char @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMGetDateTimeFormats_Char_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCode.Invoke(___genericsType, ___parameters);

            return (System.TypeCode)___result;
        }


        public virtual System.Boolean System__2__IConvertible__2__ToBoolean(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToBoolean_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Char System__2__IConvertible__2__ToChar(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToChar_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public virtual System.SByte System__2__IConvertible__2__ToSByte(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToSByte_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.SByte)___result;
        }


        public virtual System.Byte System__2__IConvertible__2__ToByte(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToByte_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Byte)___result;
        }


        public virtual System.Int16 System__2__IConvertible__2__ToInt16(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToInt16_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Int16)___result;
        }


        public virtual System.UInt16 System__2__IConvertible__2__ToUInt16(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToUInt16_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.UInt16)___result;
        }


        public virtual System.Int32 System__2__IConvertible__2__ToInt32(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToInt32_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.UInt32 System__2__IConvertible__2__ToUInt32(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToUInt32_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual System.Int64 System__2__IConvertible__2__ToInt64(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToInt64_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.UInt64 System__2__IConvertible__2__ToUInt64(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToUInt64_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public virtual System.Single System__2__IConvertible__2__ToSingle(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToSingle_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Double System__2__IConvertible__2__ToDouble(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToDouble_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Decimal System__2__IConvertible__2__ToDecimal(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToDecimal_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public virtual System.DateTime System__2__IConvertible__2__ToDateTime(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToDateTime_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.Object System__2__IConvertible__2__ToType(System.Type @type, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @provider};
            var ___result = RMSystem__2__IConvertible__2__ToType_Type_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Boolean TryCreate(System.Int32 @year, System.Int32 @month, System.Int32 @day, System.Int32 @hour, System.Int32 @minute, System.Int32 @second, System.Int32 @millisecond, out System.DateTime @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@year, @month, @day, @hour, @minute, @second, @millisecond, @result};
            var ___result = RMTryCreate_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Out_DateTime.Invoke(___genericsType, ___parameters);
			@result = (System.DateTime)___parameters[7];

            return (System.Boolean)___result;
        }


        public static System.Int64 GetSystemTimeAsFileTime()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSystemTimeAsFileTime.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.Int64 ToBinaryRaw()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToBinaryRaw.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
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
