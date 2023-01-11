using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.TimeSpan
	/// </summary>
    public partial class RTimeSpan : RMember //
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
					r_TicksPerMillisecond = new(typeof(System.TimeSpan), "TicksPerMillisecond");
					r_TicksPerMillisecond.SetBelong(null);
				}
				return r_TicksPerMillisecond;
			}
		}

		/// <summary>
		/// System.Double MillisecondsPerTick
		/// </summary>
		protected static RSystem.RDouble r_MillisecondsPerTick;
		public static RSystem.RDouble RMillisecondsPerTick
		{
			get
			{
				if(r_MillisecondsPerTick == null)
				{
					r_MillisecondsPerTick = new(typeof(System.TimeSpan), "MillisecondsPerTick");
					r_MillisecondsPerTick.SetBelong(null);
				}
				return r_MillisecondsPerTick;
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
					r_TicksPerSecond = new(typeof(System.TimeSpan), "TicksPerSecond");
					r_TicksPerSecond.SetBelong(null);
				}
				return r_TicksPerSecond;
			}
		}

		/// <summary>
		/// System.Double SecondsPerTick
		/// </summary>
		protected static RSystem.RDouble r_SecondsPerTick;
		public static RSystem.RDouble RSecondsPerTick
		{
			get
			{
				if(r_SecondsPerTick == null)
				{
					r_SecondsPerTick = new(typeof(System.TimeSpan), "SecondsPerTick");
					r_SecondsPerTick.SetBelong(null);
				}
				return r_SecondsPerTick;
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
					r_TicksPerMinute = new(typeof(System.TimeSpan), "TicksPerMinute");
					r_TicksPerMinute.SetBelong(null);
				}
				return r_TicksPerMinute;
			}
		}

		/// <summary>
		/// System.Double MinutesPerTick
		/// </summary>
		protected static RSystem.RDouble r_MinutesPerTick;
		public static RSystem.RDouble RMinutesPerTick
		{
			get
			{
				if(r_MinutesPerTick == null)
				{
					r_MinutesPerTick = new(typeof(System.TimeSpan), "MinutesPerTick");
					r_MinutesPerTick.SetBelong(null);
				}
				return r_MinutesPerTick;
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
					r_TicksPerHour = new(typeof(System.TimeSpan), "TicksPerHour");
					r_TicksPerHour.SetBelong(null);
				}
				return r_TicksPerHour;
			}
		}

		/// <summary>
		/// System.Double HoursPerTick
		/// </summary>
		protected static RSystem.RDouble r_HoursPerTick;
		public static RSystem.RDouble RHoursPerTick
		{
			get
			{
				if(r_HoursPerTick == null)
				{
					r_HoursPerTick = new(typeof(System.TimeSpan), "HoursPerTick");
					r_HoursPerTick.SetBelong(null);
				}
				return r_HoursPerTick;
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
					r_TicksPerDay = new(typeof(System.TimeSpan), "TicksPerDay");
					r_TicksPerDay.SetBelong(null);
				}
				return r_TicksPerDay;
			}
		}

		/// <summary>
		/// System.Double DaysPerTick
		/// </summary>
		protected static RSystem.RDouble r_DaysPerTick;
		public static RSystem.RDouble RDaysPerTick
		{
			get
			{
				if(r_DaysPerTick == null)
				{
					r_DaysPerTick = new(typeof(System.TimeSpan), "DaysPerTick");
					r_DaysPerTick.SetBelong(null);
				}
				return r_DaysPerTick;
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
					r_MillisPerSecond = new(typeof(System.TimeSpan), "MillisPerSecond");
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
					r_MillisPerMinute = new(typeof(System.TimeSpan), "MillisPerMinute");
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
					r_MillisPerHour = new(typeof(System.TimeSpan), "MillisPerHour");
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
					r_MillisPerDay = new(typeof(System.TimeSpan), "MillisPerDay");
					r_MillisPerDay.SetBelong(null);
				}
				return r_MillisPerDay;
			}
		}

		/// <summary>
		/// System.Int64 MaxSeconds
		/// </summary>
		protected static RSystem.RInt64 r_MaxSeconds;
		public static RSystem.RInt64 RMaxSeconds
		{
			get
			{
				if(r_MaxSeconds == null)
				{
					r_MaxSeconds = new(typeof(System.TimeSpan), "MaxSeconds");
					r_MaxSeconds.SetBelong(null);
				}
				return r_MaxSeconds;
			}
		}

		/// <summary>
		/// System.Int64 MinSeconds
		/// </summary>
		protected static RSystem.RInt64 r_MinSeconds;
		public static RSystem.RInt64 RMinSeconds
		{
			get
			{
				if(r_MinSeconds == null)
				{
					r_MinSeconds = new(typeof(System.TimeSpan), "MinSeconds");
					r_MinSeconds.SetBelong(null);
				}
				return r_MinSeconds;
			}
		}

		/// <summary>
		/// System.Int64 MaxMilliSeconds
		/// </summary>
		protected static RSystem.RInt64 r_MaxMilliSeconds;
		public static RSystem.RInt64 RMaxMilliSeconds
		{
			get
			{
				if(r_MaxMilliSeconds == null)
				{
					r_MaxMilliSeconds = new(typeof(System.TimeSpan), "MaxMilliSeconds");
					r_MaxMilliSeconds.SetBelong(null);
				}
				return r_MaxMilliSeconds;
			}
		}

		/// <summary>
		/// System.Int64 MinMilliSeconds
		/// </summary>
		protected static RSystem.RInt64 r_MinMilliSeconds;
		public static RSystem.RInt64 RMinMilliSeconds
		{
			get
			{
				if(r_MinMilliSeconds == null)
				{
					r_MinMilliSeconds = new(typeof(System.TimeSpan), "MinMilliSeconds");
					r_MinMilliSeconds.SetBelong(null);
				}
				return r_MinMilliSeconds;
			}
		}

		/// <summary>
		/// System.Int64 TicksPerTenthSecond
		/// </summary>
		protected static RSystem.RInt64 r_TicksPerTenthSecond;
		public static RSystem.RInt64 RTicksPerTenthSecond
		{
			get
			{
				if(r_TicksPerTenthSecond == null)
				{
					r_TicksPerTenthSecond = new(typeof(System.TimeSpan), "TicksPerTenthSecond");
					r_TicksPerTenthSecond.SetBelong(null);
				}
				return r_TicksPerTenthSecond;
			}
		}

		/// <summary>
		/// System.TimeSpan Zero
		/// </summary>
		protected static RSystem.RTimeSpan r_Zero;
		public static RSystem.RTimeSpan RZero
		{
			get
			{
				if(r_Zero == null)
				{
					r_Zero = new(typeof(System.TimeSpan), "Zero");
					r_Zero.SetBelong(null);
				}
				return r_Zero;
			}
		}

		/// <summary>
		/// System.TimeSpan MaxValue
		/// </summary>
		protected static RSystem.RTimeSpan r_MaxValue;
		public static RSystem.RTimeSpan RMaxValue
		{
			get
			{
				if(r_MaxValue == null)
				{
					r_MaxValue = new(typeof(System.TimeSpan), "MaxValue");
					r_MaxValue.SetBelong(null);
				}
				return r_MaxValue;
			}
		}

		/// <summary>
		/// System.TimeSpan MinValue
		/// </summary>
		protected static RSystem.RTimeSpan r_MinValue;
		public static RSystem.RTimeSpan RMinValue
		{
			get
			{
				if(r_MinValue == null)
				{
					r_MinValue = new(typeof(System.TimeSpan), "MinValue");
					r_MinValue.SetBelong(null);
				}
				return r_MinValue;
			}
		}

		/// <summary>
		/// System.Int64 _ticks
		/// </summary>
		protected RSystem.RInt64 r__ticks;
		public virtual RSystem.RInt64 R_ticks
		{
			get
			{
				if(r__ticks == null)
				{
					r__ticks = new(this, "_ticks");
					r__ticks.SetBelong(this.instance);
				}
				return r__ticks;
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
		/// Int32 Days
		/// </summary>
		protected RSystem.RInt32 r_Days;
		public virtual RSystem.RInt32 RDays
		{
			get
			{
				if(r_Days == null)
				{
					r_Days = new(this, "Days", -1);
					r_Days.SetBelong(this.instance);
				}
				return r_Days;
			}
		}

		/// <summary>
		/// Int32 Hours
		/// </summary>
		protected RSystem.RInt32 r_Hours;
		public virtual RSystem.RInt32 RHours
		{
			get
			{
				if(r_Hours == null)
				{
					r_Hours = new(this, "Hours", -1);
					r_Hours.SetBelong(this.instance);
				}
				return r_Hours;
			}
		}

		/// <summary>
		/// Int32 Milliseconds
		/// </summary>
		protected RSystem.RInt32 r_Milliseconds;
		public virtual RSystem.RInt32 RMilliseconds
		{
			get
			{
				if(r_Milliseconds == null)
				{
					r_Milliseconds = new(this, "Milliseconds", -1);
					r_Milliseconds.SetBelong(this.instance);
				}
				return r_Milliseconds;
			}
		}

		/// <summary>
		/// Int32 Minutes
		/// </summary>
		protected RSystem.RInt32 r_Minutes;
		public virtual RSystem.RInt32 RMinutes
		{
			get
			{
				if(r_Minutes == null)
				{
					r_Minutes = new(this, "Minutes", -1);
					r_Minutes.SetBelong(this.instance);
				}
				return r_Minutes;
			}
		}

		/// <summary>
		/// Int32 Seconds
		/// </summary>
		protected RSystem.RInt32 r_Seconds;
		public virtual RSystem.RInt32 RSeconds
		{
			get
			{
				if(r_Seconds == null)
				{
					r_Seconds = new(this, "Seconds", -1);
					r_Seconds.SetBelong(this.instance);
				}
				return r_Seconds;
			}
		}

		/// <summary>
		/// Double TotalDays
		/// </summary>
		protected RSystem.RDouble r_TotalDays;
		public virtual RSystem.RDouble RTotalDays
		{
			get
			{
				if(r_TotalDays == null)
				{
					r_TotalDays = new(this, "TotalDays", -1);
					r_TotalDays.SetBelong(this.instance);
				}
				return r_TotalDays;
			}
		}

		/// <summary>
		/// Double TotalHours
		/// </summary>
		protected RSystem.RDouble r_TotalHours;
		public virtual RSystem.RDouble RTotalHours
		{
			get
			{
				if(r_TotalHours == null)
				{
					r_TotalHours = new(this, "TotalHours", -1);
					r_TotalHours.SetBelong(this.instance);
				}
				return r_TotalHours;
			}
		}

		/// <summary>
		/// Double TotalMilliseconds
		/// </summary>
		protected RSystem.RDouble r_TotalMilliseconds;
		public virtual RSystem.RDouble RTotalMilliseconds
		{
			get
			{
				if(r_TotalMilliseconds == null)
				{
					r_TotalMilliseconds = new(this, "TotalMilliseconds", -1);
					r_TotalMilliseconds.SetBelong(this.instance);
				}
				return r_TotalMilliseconds;
			}
		}

		/// <summary>
		/// Double TotalMinutes
		/// </summary>
		protected RSystem.RDouble r_TotalMinutes;
		public virtual RSystem.RDouble RTotalMinutes
		{
			get
			{
				if(r_TotalMinutes == null)
				{
					r_TotalMinutes = new(this, "TotalMinutes", -1);
					r_TotalMinutes.SetBelong(this.instance);
				}
				return r_TotalMinutes;
			}
		}

		/// <summary>
		/// Double TotalSeconds
		/// </summary>
		protected RSystem.RDouble r_TotalSeconds;
		public virtual RSystem.RDouble RTotalSeconds
		{
			get
			{
				if(r_TotalSeconds == null)
				{
					r_TotalSeconds = new(this, "TotalSeconds", -1);
					r_TotalSeconds.SetBelong(this.instance);
				}
				return r_TotalSeconds;
			}
		}

		/// <summary>
		/// System.TimeSpan Add(System.TimeSpan)
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
		/// Int32 Compare(System.TimeSpan, System.TimeSpan)
		/// </summary>
		protected static RMethod r_Compare_TimeSpan_TimeSpan;
		public static RMethod RCompare_TimeSpan_TimeSpan
		{
			get
			{
				if(r_Compare_TimeSpan_TimeSpan == null)
				{
					r_Compare_TimeSpan_TimeSpan = new(typeof(System.TimeSpan), "Compare", 0, typeof(System.TimeSpan), typeof(System.TimeSpan));
					r_Compare_TimeSpan_TimeSpan.SetBelong(null);
				}
				return r_Compare_TimeSpan_TimeSpan;
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
		/// Int32 CompareTo(System.TimeSpan)
		/// </summary>
		protected RMethod r_CompareTo_TimeSpan;
		public virtual RMethod RCompareTo_TimeSpan
		{
			get
			{
				if(r_CompareTo_TimeSpan == null)
				{
					r_CompareTo_TimeSpan = new(this, "CompareTo", 0, typeof(System.TimeSpan));
					r_CompareTo_TimeSpan.SetBelong(this.instance);
				}
				return r_CompareTo_TimeSpan;
			}
		}

		/// <summary>
		/// System.TimeSpan FromDays(Double)
		/// </summary>
		protected static RMethod r_FromDays_Double;
		public static RMethod RFromDays_Double
		{
			get
			{
				if(r_FromDays_Double == null)
				{
					r_FromDays_Double = new(typeof(System.TimeSpan), "FromDays", 0, typeof(System.Double));
					r_FromDays_Double.SetBelong(null);
				}
				return r_FromDays_Double;
			}
		}

		/// <summary>
		/// System.TimeSpan Duration()
		/// </summary>
		protected RMethod r_Duration;
		public virtual RMethod RDuration
		{
			get
			{
				if(r_Duration == null)
				{
					r_Duration = new(this, "Duration", 0);
					r_Duration.SetBelong(this.instance);
				}
				return r_Duration;
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
		/// Boolean Equals(System.TimeSpan)
		/// </summary>
		protected RMethod r_Equals_TimeSpan;
		public virtual RMethod REquals_TimeSpan
		{
			get
			{
				if(r_Equals_TimeSpan == null)
				{
					r_Equals_TimeSpan = new(this, "Equals", 0, typeof(System.TimeSpan));
					r_Equals_TimeSpan.SetBelong(this.instance);
				}
				return r_Equals_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean Equals(System.TimeSpan, System.TimeSpan)
		/// </summary>
		protected static RMethod r_Equals_TimeSpan_TimeSpan;
		public static RMethod REquals_TimeSpan_TimeSpan
		{
			get
			{
				if(r_Equals_TimeSpan_TimeSpan == null)
				{
					r_Equals_TimeSpan_TimeSpan = new(typeof(System.TimeSpan), "Equals", 0, typeof(System.TimeSpan), typeof(System.TimeSpan));
					r_Equals_TimeSpan_TimeSpan.SetBelong(null);
				}
				return r_Equals_TimeSpan_TimeSpan;
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
		/// System.TimeSpan FromHours(Double)
		/// </summary>
		protected static RMethod r_FromHours_Double;
		public static RMethod RFromHours_Double
		{
			get
			{
				if(r_FromHours_Double == null)
				{
					r_FromHours_Double = new(typeof(System.TimeSpan), "FromHours", 0, typeof(System.Double));
					r_FromHours_Double.SetBelong(null);
				}
				return r_FromHours_Double;
			}
		}

		/// <summary>
		/// System.TimeSpan Interval(Double, Int32)
		/// </summary>
		protected static RMethod r_Interval_Double_Int32;
		public static RMethod RInterval_Double_Int32
		{
			get
			{
				if(r_Interval_Double_Int32 == null)
				{
					r_Interval_Double_Int32 = new(typeof(System.TimeSpan), "Interval", 0, typeof(System.Double), typeof(System.Int32));
					r_Interval_Double_Int32.SetBelong(null);
				}
				return r_Interval_Double_Int32;
			}
		}

		/// <summary>
		/// System.TimeSpan FromMilliseconds(Double)
		/// </summary>
		protected static RMethod r_FromMilliseconds_Double;
		public static RMethod RFromMilliseconds_Double
		{
			get
			{
				if(r_FromMilliseconds_Double == null)
				{
					r_FromMilliseconds_Double = new(typeof(System.TimeSpan), "FromMilliseconds", 0, typeof(System.Double));
					r_FromMilliseconds_Double.SetBelong(null);
				}
				return r_FromMilliseconds_Double;
			}
		}

		/// <summary>
		/// System.TimeSpan FromMinutes(Double)
		/// </summary>
		protected static RMethod r_FromMinutes_Double;
		public static RMethod RFromMinutes_Double
		{
			get
			{
				if(r_FromMinutes_Double == null)
				{
					r_FromMinutes_Double = new(typeof(System.TimeSpan), "FromMinutes", 0, typeof(System.Double));
					r_FromMinutes_Double.SetBelong(null);
				}
				return r_FromMinutes_Double;
			}
		}

		/// <summary>
		/// System.TimeSpan Negate()
		/// </summary>
		protected RMethod r_Negate;
		public virtual RMethod RNegate
		{
			get
			{
				if(r_Negate == null)
				{
					r_Negate = new(this, "Negate", 0);
					r_Negate.SetBelong(this.instance);
				}
				return r_Negate;
			}
		}

		/// <summary>
		/// System.TimeSpan FromSeconds(Double)
		/// </summary>
		protected static RMethod r_FromSeconds_Double;
		public static RMethod RFromSeconds_Double
		{
			get
			{
				if(r_FromSeconds_Double == null)
				{
					r_FromSeconds_Double = new(typeof(System.TimeSpan), "FromSeconds", 0, typeof(System.Double));
					r_FromSeconds_Double.SetBelong(null);
				}
				return r_FromSeconds_Double;
			}
		}

		/// <summary>
		/// System.TimeSpan Subtract(System.TimeSpan)
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
		/// System.TimeSpan Multiply(Double)
		/// </summary>
		protected RMethod r_Multiply_Double;
		public virtual RMethod RMultiply_Double
		{
			get
			{
				if(r_Multiply_Double == null)
				{
					r_Multiply_Double = new(this, "Multiply", 0, typeof(System.Double));
					r_Multiply_Double.SetBelong(this.instance);
				}
				return r_Multiply_Double;
			}
		}

		/// <summary>
		/// System.TimeSpan Divide(Double)
		/// </summary>
		protected RMethod r_Divide_Double;
		public virtual RMethod RDivide_Double
		{
			get
			{
				if(r_Divide_Double == null)
				{
					r_Divide_Double = new(this, "Divide", 0, typeof(System.Double));
					r_Divide_Double.SetBelong(this.instance);
				}
				return r_Divide_Double;
			}
		}

		/// <summary>
		/// Double Divide(System.TimeSpan)
		/// </summary>
		protected RMethod r_Divide_TimeSpan;
		public virtual RMethod RDivide_TimeSpan
		{
			get
			{
				if(r_Divide_TimeSpan == null)
				{
					r_Divide_TimeSpan = new(this, "Divide", 0, typeof(System.TimeSpan));
					r_Divide_TimeSpan.SetBelong(this.instance);
				}
				return r_Divide_TimeSpan;
			}
		}

		/// <summary>
		/// System.TimeSpan FromTicks(Int64)
		/// </summary>
		protected static RMethod r_FromTicks_Int64;
		public static RMethod RFromTicks_Int64
		{
			get
			{
				if(r_FromTicks_Int64 == null)
				{
					r_FromTicks_Int64 = new(typeof(System.TimeSpan), "FromTicks", 0, typeof(System.Int64));
					r_FromTicks_Int64.SetBelong(null);
				}
				return r_FromTicks_Int64;
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
					r_TimeToTicks_Int32_Int32_Int32 = new(typeof(System.TimeSpan), "TimeToTicks", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_TimeToTicks_Int32_Int32_Int32.SetBelong(null);
				}
				return r_TimeToTicks_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void ValidateStyles(System.Globalization.TimeSpanStyles, System.String)
		/// </summary>
		protected static RMethod r_ValidateStyles_TimeSpanStyles_String;
		public static RMethod RValidateStyles_TimeSpanStyles_String
		{
			get
			{
				if(r_ValidateStyles_TimeSpanStyles_String == null)
				{
					r_ValidateStyles_TimeSpanStyles_String = new(typeof(System.TimeSpan), "ValidateStyles", 0, typeof(System.Globalization.TimeSpanStyles), typeof(System.String));
					r_ValidateStyles_TimeSpanStyles_String.SetBelong(null);
				}
				return r_ValidateStyles_TimeSpanStyles_String;
			}
		}

		/// <summary>
		/// System.TimeSpan Parse(System.String)
		/// </summary>
		protected static RMethod r_Parse_String;
		public static RMethod RParse_String
		{
			get
			{
				if(r_Parse_String == null)
				{
					r_Parse_String = new(typeof(System.TimeSpan), "Parse", 0, typeof(System.String));
					r_Parse_String.SetBelong(null);
				}
				return r_Parse_String;
			}
		}

		/// <summary>
		/// System.TimeSpan Parse(System.String, System.IFormatProvider)
		/// </summary>
		protected static RMethod r_Parse_String_IFormatProvider;
		public static RMethod RParse_String_IFormatProvider
		{
			get
			{
				if(r_Parse_String_IFormatProvider == null)
				{
					r_Parse_String_IFormatProvider = new(typeof(System.TimeSpan), "Parse", 0, typeof(System.String), typeof(System.IFormatProvider));
					r_Parse_String_IFormatProvider.SetBelong(null);
				}
				return r_Parse_String_IFormatProvider;
			}
		}

		/// <summary>
		/// System.TimeSpan Parse(System.ReadOnlySpan`1[System.Char], System.IFormatProvider)
		/// </summary>
		protected static RMethod r_Parse_ReadOnlySpan_d_Char_p__IFormatProvider;
		public static RMethod RParse_ReadOnlySpan_d_Char_p__IFormatProvider
		{
			get
			{
				if(r_Parse_ReadOnlySpan_d_Char_p__IFormatProvider == null)
				{
					r_Parse_ReadOnlySpan_d_Char_p__IFormatProvider = new(typeof(System.TimeSpan), "Parse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider));
					r_Parse_ReadOnlySpan_d_Char_p__IFormatProvider.SetBelong(null);
				}
				return r_Parse_ReadOnlySpan_d_Char_p__IFormatProvider;
			}
		}

		/// <summary>
		/// System.TimeSpan ParseExact(System.String, System.String, System.IFormatProvider)
		/// </summary>
		protected static RMethod r_ParseExact_String_String_IFormatProvider;
		public static RMethod RParseExact_String_String_IFormatProvider
		{
			get
			{
				if(r_ParseExact_String_String_IFormatProvider == null)
				{
					r_ParseExact_String_String_IFormatProvider = new(typeof(System.TimeSpan), "ParseExact", 0, typeof(System.String), typeof(System.String), typeof(System.IFormatProvider));
					r_ParseExact_String_String_IFormatProvider.SetBelong(null);
				}
				return r_ParseExact_String_String_IFormatProvider;
			}
		}

		/// <summary>
		/// System.TimeSpan ParseExact(System.String, System.String[], System.IFormatProvider)
		/// </summary>
		protected static RMethod r_ParseExact_String_StringArray_IFormatProvider;
		public static RMethod RParseExact_String_StringArray_IFormatProvider
		{
			get
			{
				if(r_ParseExact_String_StringArray_IFormatProvider == null)
				{
					r_ParseExact_String_StringArray_IFormatProvider = new(typeof(System.TimeSpan), "ParseExact", 0, typeof(System.String), typeof(System.String).MakeArrayType(), typeof(System.IFormatProvider));
					r_ParseExact_String_StringArray_IFormatProvider.SetBelong(null);
				}
				return r_ParseExact_String_StringArray_IFormatProvider;
			}
		}

		/// <summary>
		/// System.TimeSpan ParseExact(System.String, System.String, System.IFormatProvider, System.Globalization.TimeSpanStyles)
		/// </summary>
		protected static RMethod r_ParseExact_String_String_IFormatProvider_TimeSpanStyles;
		public static RMethod RParseExact_String_String_IFormatProvider_TimeSpanStyles
		{
			get
			{
				if(r_ParseExact_String_String_IFormatProvider_TimeSpanStyles == null)
				{
					r_ParseExact_String_String_IFormatProvider_TimeSpanStyles = new(typeof(System.TimeSpan), "ParseExact", 0, typeof(System.String), typeof(System.String), typeof(System.IFormatProvider), typeof(System.Globalization.TimeSpanStyles));
					r_ParseExact_String_String_IFormatProvider_TimeSpanStyles.SetBelong(null);
				}
				return r_ParseExact_String_String_IFormatProvider_TimeSpanStyles;
			}
		}

		/// <summary>
		/// System.TimeSpan ParseExact(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.IFormatProvider, System.Globalization.TimeSpanStyles)
		/// </summary>
		protected static RMethod r_ParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_TimeSpanStyles;
		public static RMethod RParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_TimeSpanStyles
		{
			get
			{
				if(r_ParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_TimeSpanStyles == null)
				{
					r_ParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_TimeSpanStyles = new(typeof(System.TimeSpan), "ParseExact", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider), typeof(System.Globalization.TimeSpanStyles));
					r_ParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_TimeSpanStyles.SetBelong(null);
				}
				return r_ParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_TimeSpanStyles;
			}
		}

		/// <summary>
		/// System.TimeSpan ParseExact(System.String, System.String[], System.IFormatProvider, System.Globalization.TimeSpanStyles)
		/// </summary>
		protected static RMethod r_ParseExact_String_StringArray_IFormatProvider_TimeSpanStyles;
		public static RMethod RParseExact_String_StringArray_IFormatProvider_TimeSpanStyles
		{
			get
			{
				if(r_ParseExact_String_StringArray_IFormatProvider_TimeSpanStyles == null)
				{
					r_ParseExact_String_StringArray_IFormatProvider_TimeSpanStyles = new(typeof(System.TimeSpan), "ParseExact", 0, typeof(System.String), typeof(System.String).MakeArrayType(), typeof(System.IFormatProvider), typeof(System.Globalization.TimeSpanStyles));
					r_ParseExact_String_StringArray_IFormatProvider_TimeSpanStyles.SetBelong(null);
				}
				return r_ParseExact_String_StringArray_IFormatProvider_TimeSpanStyles;
			}
		}

		/// <summary>
		/// System.TimeSpan ParseExact(System.ReadOnlySpan`1[System.Char], System.String[], System.IFormatProvider, System.Globalization.TimeSpanStyles)
		/// </summary>
		protected static RMethod r_ParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_TimeSpanStyles;
		public static RMethod RParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_TimeSpanStyles
		{
			get
			{
				if(r_ParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_TimeSpanStyles == null)
				{
					r_ParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_TimeSpanStyles = new(typeof(System.TimeSpan), "ParseExact", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.String).MakeArrayType(), typeof(System.IFormatProvider), typeof(System.Globalization.TimeSpanStyles));
					r_ParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_TimeSpanStyles.SetBelong(null);
				}
				return r_ParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_TimeSpanStyles;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.String, System.TimeSpan ByRef)
		/// </summary>
		protected static RMethod r_TryParse_String_Out_TimeSpan;
		public static RMethod RTryParse_String_Out_TimeSpan
		{
			get
			{
				if(r_TryParse_String_Out_TimeSpan == null)
				{
					r_TryParse_String_Out_TimeSpan = new(typeof(System.TimeSpan), "TryParse", 0, typeof(System.String), typeof(System.TimeSpan).MakeByRefType());
					r_TryParse_String_Out_TimeSpan.SetBelong(null);
				}
				return r_TryParse_String_Out_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], System.TimeSpan ByRef)
		/// </summary>
		protected static RMethod r_TryParse_ReadOnlySpan_d_Char_p__Out_TimeSpan;
		public static RMethod RTryParse_ReadOnlySpan_d_Char_p__Out_TimeSpan
		{
			get
			{
				if(r_TryParse_ReadOnlySpan_d_Char_p__Out_TimeSpan == null)
				{
					r_TryParse_ReadOnlySpan_d_Char_p__Out_TimeSpan = new(typeof(System.TimeSpan), "TryParse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.TimeSpan).MakeByRefType());
					r_TryParse_ReadOnlySpan_d_Char_p__Out_TimeSpan.SetBelong(null);
				}
				return r_TryParse_ReadOnlySpan_d_Char_p__Out_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.String, System.IFormatProvider, System.TimeSpan ByRef)
		/// </summary>
		protected static RMethod r_TryParse_String_IFormatProvider_Out_TimeSpan;
		public static RMethod RTryParse_String_IFormatProvider_Out_TimeSpan
		{
			get
			{
				if(r_TryParse_String_IFormatProvider_Out_TimeSpan == null)
				{
					r_TryParse_String_IFormatProvider_Out_TimeSpan = new(typeof(System.TimeSpan), "TryParse", 0, typeof(System.String), typeof(System.IFormatProvider), typeof(System.TimeSpan).MakeByRefType());
					r_TryParse_String_IFormatProvider_Out_TimeSpan.SetBelong(null);
				}
				return r_TryParse_String_IFormatProvider_Out_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], System.IFormatProvider, System.TimeSpan ByRef)
		/// </summary>
		protected static RMethod r_TryParse_ReadOnlySpan_d_Char_p__IFormatProvider_Out_TimeSpan;
		public static RMethod RTryParse_ReadOnlySpan_d_Char_p__IFormatProvider_Out_TimeSpan
		{
			get
			{
				if(r_TryParse_ReadOnlySpan_d_Char_p__IFormatProvider_Out_TimeSpan == null)
				{
					r_TryParse_ReadOnlySpan_d_Char_p__IFormatProvider_Out_TimeSpan = new(typeof(System.TimeSpan), "TryParse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider), typeof(System.TimeSpan).MakeByRefType());
					r_TryParse_ReadOnlySpan_d_Char_p__IFormatProvider_Out_TimeSpan.SetBelong(null);
				}
				return r_TryParse_ReadOnlySpan_d_Char_p__IFormatProvider_Out_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean TryParseExact(System.String, System.String, System.IFormatProvider, System.TimeSpan ByRef)
		/// </summary>
		protected static RMethod r_TryParseExact_String_String_IFormatProvider_Out_TimeSpan;
		public static RMethod RTryParseExact_String_String_IFormatProvider_Out_TimeSpan
		{
			get
			{
				if(r_TryParseExact_String_String_IFormatProvider_Out_TimeSpan == null)
				{
					r_TryParseExact_String_String_IFormatProvider_Out_TimeSpan = new(typeof(System.TimeSpan), "TryParseExact", 0, typeof(System.String), typeof(System.String), typeof(System.IFormatProvider), typeof(System.TimeSpan).MakeByRefType());
					r_TryParseExact_String_String_IFormatProvider_Out_TimeSpan.SetBelong(null);
				}
				return r_TryParseExact_String_String_IFormatProvider_Out_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean TryParseExact(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.IFormatProvider, System.TimeSpan ByRef)
		/// </summary>
		protected static RMethod r_TryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_Out_TimeSpan;
		public static RMethod RTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_Out_TimeSpan
		{
			get
			{
				if(r_TryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_Out_TimeSpan == null)
				{
					r_TryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_Out_TimeSpan = new(typeof(System.TimeSpan), "TryParseExact", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider), typeof(System.TimeSpan).MakeByRefType());
					r_TryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_Out_TimeSpan.SetBelong(null);
				}
				return r_TryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_Out_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean TryParseExact(System.String, System.String[], System.IFormatProvider, System.TimeSpan ByRef)
		/// </summary>
		protected static RMethod r_TryParseExact_String_StringArray_IFormatProvider_Out_TimeSpan;
		public static RMethod RTryParseExact_String_StringArray_IFormatProvider_Out_TimeSpan
		{
			get
			{
				if(r_TryParseExact_String_StringArray_IFormatProvider_Out_TimeSpan == null)
				{
					r_TryParseExact_String_StringArray_IFormatProvider_Out_TimeSpan = new(typeof(System.TimeSpan), "TryParseExact", 0, typeof(System.String), typeof(System.String).MakeArrayType(), typeof(System.IFormatProvider), typeof(System.TimeSpan).MakeByRefType());
					r_TryParseExact_String_StringArray_IFormatProvider_Out_TimeSpan.SetBelong(null);
				}
				return r_TryParseExact_String_StringArray_IFormatProvider_Out_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean TryParseExact(System.ReadOnlySpan`1[System.Char], System.String[], System.IFormatProvider, System.TimeSpan ByRef)
		/// </summary>
		protected static RMethod r_TryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_Out_TimeSpan;
		public static RMethod RTryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_Out_TimeSpan
		{
			get
			{
				if(r_TryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_Out_TimeSpan == null)
				{
					r_TryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_Out_TimeSpan = new(typeof(System.TimeSpan), "TryParseExact", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.String).MakeArrayType(), typeof(System.IFormatProvider), typeof(System.TimeSpan).MakeByRefType());
					r_TryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_Out_TimeSpan.SetBelong(null);
				}
				return r_TryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_Out_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean TryParseExact(System.String, System.String, System.IFormatProvider, System.Globalization.TimeSpanStyles, System.TimeSpan ByRef)
		/// </summary>
		protected static RMethod r_TryParseExact_String_String_IFormatProvider_TimeSpanStyles_Out_TimeSpan;
		public static RMethod RTryParseExact_String_String_IFormatProvider_TimeSpanStyles_Out_TimeSpan
		{
			get
			{
				if(r_TryParseExact_String_String_IFormatProvider_TimeSpanStyles_Out_TimeSpan == null)
				{
					r_TryParseExact_String_String_IFormatProvider_TimeSpanStyles_Out_TimeSpan = new(typeof(System.TimeSpan), "TryParseExact", 0, typeof(System.String), typeof(System.String), typeof(System.IFormatProvider), typeof(System.Globalization.TimeSpanStyles), typeof(System.TimeSpan).MakeByRefType());
					r_TryParseExact_String_String_IFormatProvider_TimeSpanStyles_Out_TimeSpan.SetBelong(null);
				}
				return r_TryParseExact_String_String_IFormatProvider_TimeSpanStyles_Out_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean TryParseExact(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.IFormatProvider, System.Globalization.TimeSpanStyles, System.TimeSpan ByRef)
		/// </summary>
		protected static RMethod r_TryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_TimeSpanStyles_Out_TimeSpan;
		public static RMethod RTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_TimeSpanStyles_Out_TimeSpan
		{
			get
			{
				if(r_TryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_TimeSpanStyles_Out_TimeSpan == null)
				{
					r_TryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_TimeSpanStyles_Out_TimeSpan = new(typeof(System.TimeSpan), "TryParseExact", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider), typeof(System.Globalization.TimeSpanStyles), typeof(System.TimeSpan).MakeByRefType());
					r_TryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_TimeSpanStyles_Out_TimeSpan.SetBelong(null);
				}
				return r_TryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_TimeSpanStyles_Out_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean TryParseExact(System.String, System.String[], System.IFormatProvider, System.Globalization.TimeSpanStyles, System.TimeSpan ByRef)
		/// </summary>
		protected static RMethod r_TryParseExact_String_StringArray_IFormatProvider_TimeSpanStyles_Out_TimeSpan;
		public static RMethod RTryParseExact_String_StringArray_IFormatProvider_TimeSpanStyles_Out_TimeSpan
		{
			get
			{
				if(r_TryParseExact_String_StringArray_IFormatProvider_TimeSpanStyles_Out_TimeSpan == null)
				{
					r_TryParseExact_String_StringArray_IFormatProvider_TimeSpanStyles_Out_TimeSpan = new(typeof(System.TimeSpan), "TryParseExact", 0, typeof(System.String), typeof(System.String).MakeArrayType(), typeof(System.IFormatProvider), typeof(System.Globalization.TimeSpanStyles), typeof(System.TimeSpan).MakeByRefType());
					r_TryParseExact_String_StringArray_IFormatProvider_TimeSpanStyles_Out_TimeSpan.SetBelong(null);
				}
				return r_TryParseExact_String_StringArray_IFormatProvider_TimeSpanStyles_Out_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean TryParseExact(System.ReadOnlySpan`1[System.Char], System.String[], System.IFormatProvider, System.Globalization.TimeSpanStyles, System.TimeSpan ByRef)
		/// </summary>
		protected static RMethod r_TryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_TimeSpanStyles_Out_TimeSpan;
		public static RMethod RTryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_TimeSpanStyles_Out_TimeSpan
		{
			get
			{
				if(r_TryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_TimeSpanStyles_Out_TimeSpan == null)
				{
					r_TryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_TimeSpanStyles_Out_TimeSpan = new(typeof(System.TimeSpan), "TryParseExact", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.String).MakeArrayType(), typeof(System.IFormatProvider), typeof(System.Globalization.TimeSpanStyles), typeof(System.TimeSpan).MakeByRefType());
					r_TryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_TimeSpanStyles_Out_TimeSpan.SetBelong(null);
				}
				return r_TryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_TimeSpanStyles_Out_TimeSpan;
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
		/// System.TimeSpan op_UnaryNegation(System.TimeSpan)
		/// </summary>
		protected static RMethod r_op_UnaryNegation_TimeSpan;
		public static RMethod Rop_UnaryNegation_TimeSpan
		{
			get
			{
				if(r_op_UnaryNegation_TimeSpan == null)
				{
					r_op_UnaryNegation_TimeSpan = new(typeof(System.TimeSpan), "op_UnaryNegation", 0, typeof(System.TimeSpan));
					r_op_UnaryNegation_TimeSpan.SetBelong(null);
				}
				return r_op_UnaryNegation_TimeSpan;
			}
		}

		/// <summary>
		/// System.TimeSpan op_Subtraction(System.TimeSpan, System.TimeSpan)
		/// </summary>
		protected static RMethod r_op_Subtraction_TimeSpan_TimeSpan;
		public static RMethod Rop_Subtraction_TimeSpan_TimeSpan
		{
			get
			{
				if(r_op_Subtraction_TimeSpan_TimeSpan == null)
				{
					r_op_Subtraction_TimeSpan_TimeSpan = new(typeof(System.TimeSpan), "op_Subtraction", 0, typeof(System.TimeSpan), typeof(System.TimeSpan));
					r_op_Subtraction_TimeSpan_TimeSpan.SetBelong(null);
				}
				return r_op_Subtraction_TimeSpan_TimeSpan;
			}
		}

		/// <summary>
		/// System.TimeSpan op_UnaryPlus(System.TimeSpan)
		/// </summary>
		protected static RMethod r_op_UnaryPlus_TimeSpan;
		public static RMethod Rop_UnaryPlus_TimeSpan
		{
			get
			{
				if(r_op_UnaryPlus_TimeSpan == null)
				{
					r_op_UnaryPlus_TimeSpan = new(typeof(System.TimeSpan), "op_UnaryPlus", 0, typeof(System.TimeSpan));
					r_op_UnaryPlus_TimeSpan.SetBelong(null);
				}
				return r_op_UnaryPlus_TimeSpan;
			}
		}

		/// <summary>
		/// System.TimeSpan op_Addition(System.TimeSpan, System.TimeSpan)
		/// </summary>
		protected static RMethod r_op_Addition_TimeSpan_TimeSpan;
		public static RMethod Rop_Addition_TimeSpan_TimeSpan
		{
			get
			{
				if(r_op_Addition_TimeSpan_TimeSpan == null)
				{
					r_op_Addition_TimeSpan_TimeSpan = new(typeof(System.TimeSpan), "op_Addition", 0, typeof(System.TimeSpan), typeof(System.TimeSpan));
					r_op_Addition_TimeSpan_TimeSpan.SetBelong(null);
				}
				return r_op_Addition_TimeSpan_TimeSpan;
			}
		}

		/// <summary>
		/// System.TimeSpan op_Multiply(System.TimeSpan, Double)
		/// </summary>
		protected static RMethod r_op_Multiply_TimeSpan_Double;
		public static RMethod Rop_Multiply_TimeSpan_Double
		{
			get
			{
				if(r_op_Multiply_TimeSpan_Double == null)
				{
					r_op_Multiply_TimeSpan_Double = new(typeof(System.TimeSpan), "op_Multiply", 0, typeof(System.TimeSpan), typeof(System.Double));
					r_op_Multiply_TimeSpan_Double.SetBelong(null);
				}
				return r_op_Multiply_TimeSpan_Double;
			}
		}

		/// <summary>
		/// System.TimeSpan op_Multiply(Double, System.TimeSpan)
		/// </summary>
		protected static RMethod r_op_Multiply_Double_TimeSpan;
		public static RMethod Rop_Multiply_Double_TimeSpan
		{
			get
			{
				if(r_op_Multiply_Double_TimeSpan == null)
				{
					r_op_Multiply_Double_TimeSpan = new(typeof(System.TimeSpan), "op_Multiply", 0, typeof(System.Double), typeof(System.TimeSpan));
					r_op_Multiply_Double_TimeSpan.SetBelong(null);
				}
				return r_op_Multiply_Double_TimeSpan;
			}
		}

		/// <summary>
		/// System.TimeSpan op_Division(System.TimeSpan, Double)
		/// </summary>
		protected static RMethod r_op_Division_TimeSpan_Double;
		public static RMethod Rop_Division_TimeSpan_Double
		{
			get
			{
				if(r_op_Division_TimeSpan_Double == null)
				{
					r_op_Division_TimeSpan_Double = new(typeof(System.TimeSpan), "op_Division", 0, typeof(System.TimeSpan), typeof(System.Double));
					r_op_Division_TimeSpan_Double.SetBelong(null);
				}
				return r_op_Division_TimeSpan_Double;
			}
		}

		/// <summary>
		/// Double op_Division(System.TimeSpan, System.TimeSpan)
		/// </summary>
		protected static RMethod r_op_Division_TimeSpan_TimeSpan;
		public static RMethod Rop_Division_TimeSpan_TimeSpan
		{
			get
			{
				if(r_op_Division_TimeSpan_TimeSpan == null)
				{
					r_op_Division_TimeSpan_TimeSpan = new(typeof(System.TimeSpan), "op_Division", 0, typeof(System.TimeSpan), typeof(System.TimeSpan));
					r_op_Division_TimeSpan_TimeSpan.SetBelong(null);
				}
				return r_op_Division_TimeSpan_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.TimeSpan, System.TimeSpan)
		/// </summary>
		protected static RMethod r_op_Equality_TimeSpan_TimeSpan;
		public static RMethod Rop_Equality_TimeSpan_TimeSpan
		{
			get
			{
				if(r_op_Equality_TimeSpan_TimeSpan == null)
				{
					r_op_Equality_TimeSpan_TimeSpan = new(typeof(System.TimeSpan), "op_Equality", 0, typeof(System.TimeSpan), typeof(System.TimeSpan));
					r_op_Equality_TimeSpan_TimeSpan.SetBelong(null);
				}
				return r_op_Equality_TimeSpan_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.TimeSpan, System.TimeSpan)
		/// </summary>
		protected static RMethod r_op_Inequality_TimeSpan_TimeSpan;
		public static RMethod Rop_Inequality_TimeSpan_TimeSpan
		{
			get
			{
				if(r_op_Inequality_TimeSpan_TimeSpan == null)
				{
					r_op_Inequality_TimeSpan_TimeSpan = new(typeof(System.TimeSpan), "op_Inequality", 0, typeof(System.TimeSpan), typeof(System.TimeSpan));
					r_op_Inequality_TimeSpan_TimeSpan.SetBelong(null);
				}
				return r_op_Inequality_TimeSpan_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean op_LessThan(System.TimeSpan, System.TimeSpan)
		/// </summary>
		protected static RMethod r_op_LessThan_TimeSpan_TimeSpan;
		public static RMethod Rop_LessThan_TimeSpan_TimeSpan
		{
			get
			{
				if(r_op_LessThan_TimeSpan_TimeSpan == null)
				{
					r_op_LessThan_TimeSpan_TimeSpan = new(typeof(System.TimeSpan), "op_LessThan", 0, typeof(System.TimeSpan), typeof(System.TimeSpan));
					r_op_LessThan_TimeSpan_TimeSpan.SetBelong(null);
				}
				return r_op_LessThan_TimeSpan_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean op_LessThanOrEqual(System.TimeSpan, System.TimeSpan)
		/// </summary>
		protected static RMethod r_op_LessThanOrEqual_TimeSpan_TimeSpan;
		public static RMethod Rop_LessThanOrEqual_TimeSpan_TimeSpan
		{
			get
			{
				if(r_op_LessThanOrEqual_TimeSpan_TimeSpan == null)
				{
					r_op_LessThanOrEqual_TimeSpan_TimeSpan = new(typeof(System.TimeSpan), "op_LessThanOrEqual", 0, typeof(System.TimeSpan), typeof(System.TimeSpan));
					r_op_LessThanOrEqual_TimeSpan_TimeSpan.SetBelong(null);
				}
				return r_op_LessThanOrEqual_TimeSpan_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean op_GreaterThan(System.TimeSpan, System.TimeSpan)
		/// </summary>
		protected static RMethod r_op_GreaterThan_TimeSpan_TimeSpan;
		public static RMethod Rop_GreaterThan_TimeSpan_TimeSpan
		{
			get
			{
				if(r_op_GreaterThan_TimeSpan_TimeSpan == null)
				{
					r_op_GreaterThan_TimeSpan_TimeSpan = new(typeof(System.TimeSpan), "op_GreaterThan", 0, typeof(System.TimeSpan), typeof(System.TimeSpan));
					r_op_GreaterThan_TimeSpan_TimeSpan.SetBelong(null);
				}
				return r_op_GreaterThan_TimeSpan_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean op_GreaterThanOrEqual(System.TimeSpan, System.TimeSpan)
		/// </summary>
		protected static RMethod r_op_GreaterThanOrEqual_TimeSpan_TimeSpan;
		public static RMethod Rop_GreaterThanOrEqual_TimeSpan_TimeSpan
		{
			get
			{
				if(r_op_GreaterThanOrEqual_TimeSpan_TimeSpan == null)
				{
					r_op_GreaterThanOrEqual_TimeSpan_TimeSpan = new(typeof(System.TimeSpan), "op_GreaterThanOrEqual", 0, typeof(System.TimeSpan), typeof(System.TimeSpan));
					r_op_GreaterThanOrEqual_TimeSpan_TimeSpan.SetBelong(null);
				}
				return r_op_GreaterThanOrEqual_TimeSpan_TimeSpan;
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


        public RTimeSpan() : base("System.TimeSpan")
        {
        }

        public RTimeSpan(System.Object instance) : base("System.TimeSpan")
		{
            SetInstance(instance);
		}

        public RTimeSpan(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTimeSpan(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.TimeSpan Add(System.TimeSpan @ts)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ts};
            var ___result = RAdd_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.Int32 Compare(System.TimeSpan @t1, System.TimeSpan @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = RCompare_TimeSpan_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareTo(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareTo(System.TimeSpan @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RCompareTo_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.TimeSpan FromDays(System.Double @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RFromDays_Double.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public virtual System.TimeSpan Duration()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDuration.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public virtual System.Boolean Equals(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.TimeSpan @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean Equals(System.TimeSpan @t1, System.TimeSpan @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = REquals_TimeSpan_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.TimeSpan FromHours(System.Double @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RFromHours_Double.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan Interval(System.Double @value, System.Int32 @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @scale};
            var ___result = RInterval_Double_Int32.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan FromMilliseconds(System.Double @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RFromMilliseconds_Double.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan FromMinutes(System.Double @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RFromMinutes_Double.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public virtual System.TimeSpan Negate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RNegate.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan FromSeconds(System.Double @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RFromSeconds_Double.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public virtual System.TimeSpan Subtract(System.TimeSpan @ts)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ts};
            var ___result = RSubtract_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public virtual System.TimeSpan Multiply(System.Double @factor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@factor};
            var ___result = RMultiply_Double.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public virtual System.TimeSpan Divide(System.Double @divisor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@divisor};
            var ___result = RDivide_Double.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public virtual System.Double Divide(System.TimeSpan @ts)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ts};
            var ___result = RDivide_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public static System.TimeSpan FromTicks(System.Int64 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RFromTicks_Int64.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.Int64 TimeToTicks(System.Int32 @hour, System.Int32 @minute, System.Int32 @second)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hour, @minute, @second};
            var ___result = RTimeToTicks_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public static void ValidateStyles(System.Globalization.TimeSpanStyles @style, System.String @parameterName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style, @parameterName};
            var ___result = RValidateStyles_TimeSpanStyles_String.Invoke(___genericsType, ___parameters);

            
        }


        public static System.TimeSpan Parse(System.String @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RParse_String.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan Parse(System.String @input, System.IFormatProvider @formatProvider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @formatProvider};
            var ___result = RParse_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan Parse(RSystem.RReadOnlySpan<RSystem.RChar> @input, System.IFormatProvider @formatProvider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input.Value, @formatProvider};
            var ___result = RParse_ReadOnlySpan_d_Char_p__IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan ParseExact(System.String @input, System.String @format, System.IFormatProvider @formatProvider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @format, @formatProvider};
            var ___result = RParseExact_String_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan ParseExact(System.String @input, System.String[] @formats, System.IFormatProvider @formatProvider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @formats, @formatProvider};
            var ___result = RParseExact_String_StringArray_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan ParseExact(System.String @input, System.String @format, System.IFormatProvider @formatProvider, System.Globalization.TimeSpanStyles @styles)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @format, @formatProvider, @styles};
            var ___result = RParseExact_String_String_IFormatProvider_TimeSpanStyles.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan ParseExact(RSystem.RReadOnlySpan<RSystem.RChar> @input, RSystem.RReadOnlySpan<RSystem.RChar> @format, System.IFormatProvider @formatProvider, System.Globalization.TimeSpanStyles @styles)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input.Value, @format.Value, @formatProvider, @styles};
            var ___result = RParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_TimeSpanStyles.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan ParseExact(System.String @input, System.String[] @formats, System.IFormatProvider @formatProvider, System.Globalization.TimeSpanStyles @styles)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @formats, @formatProvider, @styles};
            var ___result = RParseExact_String_StringArray_IFormatProvider_TimeSpanStyles.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan ParseExact(RSystem.RReadOnlySpan<RSystem.RChar> @input, System.String[] @formats, System.IFormatProvider @formatProvider, System.Globalization.TimeSpanStyles @styles)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input.Value, @formats, @formatProvider, @styles};
            var ___result = RParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_TimeSpanStyles.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.Boolean TryParse(System.String @s, out System.TimeSpan @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @result};
            var ___result = RTryParse_String_Out_TimeSpan.Invoke(___genericsType, ___parameters);
			@result = (System.TimeSpan)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParse(RSystem.RReadOnlySpan<RSystem.RChar> @s, out System.TimeSpan @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @result};
            var ___result = RTryParse_ReadOnlySpan_d_Char_p__Out_TimeSpan.Invoke(___genericsType, ___parameters);
			@result = (System.TimeSpan)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParse(System.String @input, System.IFormatProvider @formatProvider, out System.TimeSpan @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @formatProvider, @result};
            var ___result = RTryParse_String_IFormatProvider_Out_TimeSpan.Invoke(___genericsType, ___parameters);
			@result = (System.TimeSpan)___parameters[2];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParse(RSystem.RReadOnlySpan<RSystem.RChar> @input, System.IFormatProvider @formatProvider, out System.TimeSpan @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input.Value, @formatProvider, @result};
            var ___result = RTryParse_ReadOnlySpan_d_Char_p__IFormatProvider_Out_TimeSpan.Invoke(___genericsType, ___parameters);
			@result = (System.TimeSpan)___parameters[2];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParseExact(System.String @input, System.String @format, System.IFormatProvider @formatProvider, out System.TimeSpan @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @format, @formatProvider, @result};
            var ___result = RTryParseExact_String_String_IFormatProvider_Out_TimeSpan.Invoke(___genericsType, ___parameters);
			@result = (System.TimeSpan)___parameters[3];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParseExact(RSystem.RReadOnlySpan<RSystem.RChar> @input, RSystem.RReadOnlySpan<RSystem.RChar> @format, System.IFormatProvider @formatProvider, out System.TimeSpan @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input.Value, @format.Value, @formatProvider, @result};
            var ___result = RTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_Out_TimeSpan.Invoke(___genericsType, ___parameters);
			@result = (System.TimeSpan)___parameters[3];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParseExact(System.String @input, System.String[] @formats, System.IFormatProvider @formatProvider, out System.TimeSpan @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @formats, @formatProvider, @result};
            var ___result = RTryParseExact_String_StringArray_IFormatProvider_Out_TimeSpan.Invoke(___genericsType, ___parameters);
			@result = (System.TimeSpan)___parameters[3];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParseExact(RSystem.RReadOnlySpan<RSystem.RChar> @input, System.String[] @formats, System.IFormatProvider @formatProvider, out System.TimeSpan @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input.Value, @formats, @formatProvider, @result};
            var ___result = RTryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_Out_TimeSpan.Invoke(___genericsType, ___parameters);
			@result = (System.TimeSpan)___parameters[3];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParseExact(System.String @input, System.String @format, System.IFormatProvider @formatProvider, System.Globalization.TimeSpanStyles @styles, out System.TimeSpan @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @format, @formatProvider, @styles, @result};
            var ___result = RTryParseExact_String_String_IFormatProvider_TimeSpanStyles_Out_TimeSpan.Invoke(___genericsType, ___parameters);
			@result = (System.TimeSpan)___parameters[4];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParseExact(RSystem.RReadOnlySpan<RSystem.RChar> @input, RSystem.RReadOnlySpan<RSystem.RChar> @format, System.IFormatProvider @formatProvider, System.Globalization.TimeSpanStyles @styles, out System.TimeSpan @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input.Value, @format.Value, @formatProvider, @styles, @result};
            var ___result = RTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_TimeSpanStyles_Out_TimeSpan.Invoke(___genericsType, ___parameters);
			@result = (System.TimeSpan)___parameters[4];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParseExact(System.String @input, System.String[] @formats, System.IFormatProvider @formatProvider, System.Globalization.TimeSpanStyles @styles, out System.TimeSpan @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @formats, @formatProvider, @styles, @result};
            var ___result = RTryParseExact_String_StringArray_IFormatProvider_TimeSpanStyles_Out_TimeSpan.Invoke(___genericsType, ___parameters);
			@result = (System.TimeSpan)___parameters[4];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParseExact(RSystem.RReadOnlySpan<RSystem.RChar> @input, System.String[] @formats, System.IFormatProvider @formatProvider, System.Globalization.TimeSpanStyles @styles, out System.TimeSpan @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input.Value, @formats, @formatProvider, @styles, @result};
            var ___result = RTryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_TimeSpanStyles_Out_TimeSpan.Invoke(___genericsType, ___parameters);
			@result = (System.TimeSpan)___parameters[4];

            return (System.Boolean)___result;
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


        public virtual System.String ToString(System.String @format, System.IFormatProvider @formatProvider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @formatProvider};
            var ___result = RToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean TryFormat(RSystem.RSpan<RSystem.RChar> @destination, out System.Int32 @charsWritten, RSystem.RReadOnlySpan<RSystem.RChar> @format, System.IFormatProvider @formatProvider)
        {
			@charsWritten = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination.Value, @charsWritten, @format.Value, @formatProvider};
            var ___result = RTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider.Invoke(___genericsType, ___parameters);
			@charsWritten = (System.Int32)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.TimeSpan op_UnaryNegation(System.TimeSpan @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = Rop_UnaryNegation_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan op_Subtraction(System.TimeSpan @t1, System.TimeSpan @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = Rop_Subtraction_TimeSpan_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan op_UnaryPlus(System.TimeSpan @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = Rop_UnaryPlus_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan op_Addition(System.TimeSpan @t1, System.TimeSpan @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = Rop_Addition_TimeSpan_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan op_Multiply(System.TimeSpan @timeSpan, System.Double @factor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeSpan, @factor};
            var ___result = Rop_Multiply_TimeSpan_Double.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan op_Multiply(System.Double @factor, System.TimeSpan @timeSpan)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@factor, @timeSpan};
            var ___result = Rop_Multiply_Double_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan op_Division(System.TimeSpan @timeSpan, System.Double @divisor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeSpan, @divisor};
            var ___result = Rop_Division_TimeSpan_Double.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.Double op_Division(System.TimeSpan @t1, System.TimeSpan @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = Rop_Division_TimeSpan_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public static System.Boolean op_Equality(System.TimeSpan @t1, System.TimeSpan @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = Rop_Equality_TimeSpan_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.TimeSpan @t1, System.TimeSpan @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = Rop_Inequality_TimeSpan_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_LessThan(System.TimeSpan @t1, System.TimeSpan @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = Rop_LessThan_TimeSpan_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_LessThanOrEqual(System.TimeSpan @t1, System.TimeSpan @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = Rop_LessThanOrEqual_TimeSpan_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_GreaterThan(System.TimeSpan @t1, System.TimeSpan @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = Rop_GreaterThan_TimeSpan_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_GreaterThanOrEqual(System.TimeSpan @t1, System.TimeSpan @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = Rop_GreaterThanOrEqual_TimeSpan_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
