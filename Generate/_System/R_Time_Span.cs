
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.TimeSpan
	/// </summary>
    public partial class RTimeSpan : RMember //
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
					r_FTicksPerMillisecond = new(typeof(System.TimeSpan), "TicksPerMillisecond");
					r_FTicksPerMillisecond.SetBelong(null);
				}
				return r_FTicksPerMillisecond;
			}
		}

		/// <summary>
		/// System.Double MillisecondsPerTick
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RDouble r_FMillisecondsPerTick;
		public static Hvak.Editor.Refleaction.RSystem.RDouble RFMillisecondsPerTick
		{
			get
			{
				if(r_FMillisecondsPerTick == null)
				{
					r_FMillisecondsPerTick = new(typeof(System.TimeSpan), "MillisecondsPerTick");
					r_FMillisecondsPerTick.SetBelong(null);
				}
				return r_FMillisecondsPerTick;
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
					r_FTicksPerSecond = new(typeof(System.TimeSpan), "TicksPerSecond");
					r_FTicksPerSecond.SetBelong(null);
				}
				return r_FTicksPerSecond;
			}
		}

		/// <summary>
		/// System.Double SecondsPerTick
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RDouble r_FSecondsPerTick;
		public static Hvak.Editor.Refleaction.RSystem.RDouble RFSecondsPerTick
		{
			get
			{
				if(r_FSecondsPerTick == null)
				{
					r_FSecondsPerTick = new(typeof(System.TimeSpan), "SecondsPerTick");
					r_FSecondsPerTick.SetBelong(null);
				}
				return r_FSecondsPerTick;
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
					r_FTicksPerMinute = new(typeof(System.TimeSpan), "TicksPerMinute");
					r_FTicksPerMinute.SetBelong(null);
				}
				return r_FTicksPerMinute;
			}
		}

		/// <summary>
		/// System.Double MinutesPerTick
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RDouble r_FMinutesPerTick;
		public static Hvak.Editor.Refleaction.RSystem.RDouble RFMinutesPerTick
		{
			get
			{
				if(r_FMinutesPerTick == null)
				{
					r_FMinutesPerTick = new(typeof(System.TimeSpan), "MinutesPerTick");
					r_FMinutesPerTick.SetBelong(null);
				}
				return r_FMinutesPerTick;
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
					r_FTicksPerHour = new(typeof(System.TimeSpan), "TicksPerHour");
					r_FTicksPerHour.SetBelong(null);
				}
				return r_FTicksPerHour;
			}
		}

		/// <summary>
		/// System.Double HoursPerTick
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RDouble r_FHoursPerTick;
		public static Hvak.Editor.Refleaction.RSystem.RDouble RFHoursPerTick
		{
			get
			{
				if(r_FHoursPerTick == null)
				{
					r_FHoursPerTick = new(typeof(System.TimeSpan), "HoursPerTick");
					r_FHoursPerTick.SetBelong(null);
				}
				return r_FHoursPerTick;
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
					r_FTicksPerDay = new(typeof(System.TimeSpan), "TicksPerDay");
					r_FTicksPerDay.SetBelong(null);
				}
				return r_FTicksPerDay;
			}
		}

		/// <summary>
		/// System.Double DaysPerTick
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RDouble r_FDaysPerTick;
		public static Hvak.Editor.Refleaction.RSystem.RDouble RFDaysPerTick
		{
			get
			{
				if(r_FDaysPerTick == null)
				{
					r_FDaysPerTick = new(typeof(System.TimeSpan), "DaysPerTick");
					r_FDaysPerTick.SetBelong(null);
				}
				return r_FDaysPerTick;
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
					r_FMillisPerSecond = new(typeof(System.TimeSpan), "MillisPerSecond");
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
					r_FMillisPerMinute = new(typeof(System.TimeSpan), "MillisPerMinute");
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
					r_FMillisPerHour = new(typeof(System.TimeSpan), "MillisPerHour");
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
					r_FMillisPerDay = new(typeof(System.TimeSpan), "MillisPerDay");
					r_FMillisPerDay.SetBelong(null);
				}
				return r_FMillisPerDay;
			}
		}

		/// <summary>
		/// System.Int64 MaxSeconds
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt64 r_FMaxSeconds;
		public static Hvak.Editor.Refleaction.RSystem.RInt64 RFMaxSeconds
		{
			get
			{
				if(r_FMaxSeconds == null)
				{
					r_FMaxSeconds = new(typeof(System.TimeSpan), "MaxSeconds");
					r_FMaxSeconds.SetBelong(null);
				}
				return r_FMaxSeconds;
			}
		}

		/// <summary>
		/// System.Int64 MinSeconds
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt64 r_FMinSeconds;
		public static Hvak.Editor.Refleaction.RSystem.RInt64 RFMinSeconds
		{
			get
			{
				if(r_FMinSeconds == null)
				{
					r_FMinSeconds = new(typeof(System.TimeSpan), "MinSeconds");
					r_FMinSeconds.SetBelong(null);
				}
				return r_FMinSeconds;
			}
		}

		/// <summary>
		/// System.Int64 MaxMilliSeconds
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt64 r_FMaxMilliSeconds;
		public static Hvak.Editor.Refleaction.RSystem.RInt64 RFMaxMilliSeconds
		{
			get
			{
				if(r_FMaxMilliSeconds == null)
				{
					r_FMaxMilliSeconds = new(typeof(System.TimeSpan), "MaxMilliSeconds");
					r_FMaxMilliSeconds.SetBelong(null);
				}
				return r_FMaxMilliSeconds;
			}
		}

		/// <summary>
		/// System.Int64 MinMilliSeconds
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt64 r_FMinMilliSeconds;
		public static Hvak.Editor.Refleaction.RSystem.RInt64 RFMinMilliSeconds
		{
			get
			{
				if(r_FMinMilliSeconds == null)
				{
					r_FMinMilliSeconds = new(typeof(System.TimeSpan), "MinMilliSeconds");
					r_FMinMilliSeconds.SetBelong(null);
				}
				return r_FMinMilliSeconds;
			}
		}

		/// <summary>
		/// System.Int64 TicksPerTenthSecond
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt64 r_FTicksPerTenthSecond;
		public static Hvak.Editor.Refleaction.RSystem.RInt64 RFTicksPerTenthSecond
		{
			get
			{
				if(r_FTicksPerTenthSecond == null)
				{
					r_FTicksPerTenthSecond = new(typeof(System.TimeSpan), "TicksPerTenthSecond");
					r_FTicksPerTenthSecond.SetBelong(null);
				}
				return r_FTicksPerTenthSecond;
			}
		}

		/// <summary>
		/// System.TimeSpan Zero
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RTimeSpan r_FZero;
		public static Hvak.Editor.Refleaction.RSystem.RTimeSpan RFZero
		{
			get
			{
				if(r_FZero == null)
				{
					r_FZero = new(typeof(System.TimeSpan), "Zero");
					r_FZero.SetBelong(null);
				}
				return r_FZero;
			}
		}

		/// <summary>
		/// System.TimeSpan MaxValue
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RTimeSpan r_FMaxValue;
		public static Hvak.Editor.Refleaction.RSystem.RTimeSpan RFMaxValue
		{
			get
			{
				if(r_FMaxValue == null)
				{
					r_FMaxValue = new(typeof(System.TimeSpan), "MaxValue");
					r_FMaxValue.SetBelong(null);
				}
				return r_FMaxValue;
			}
		}

		/// <summary>
		/// System.TimeSpan MinValue
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RTimeSpan r_FMinValue;
		public static Hvak.Editor.Refleaction.RSystem.RTimeSpan RFMinValue
		{
			get
			{
				if(r_FMinValue == null)
				{
					r_FMinValue = new(typeof(System.TimeSpan), "MinValue");
					r_FMinValue.SetBelong(null);
				}
				return r_FMinValue;
			}
		}

		/// <summary>
		/// System.Int64 _ticks
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_F_ticks;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RF_ticks
		{
			get
			{
				if(r_F_ticks == null)
				{
					r_F_ticks = new(this, "_ticks");
					r_F_ticks.SetBelong(this.instance);
				}
				return r_F_ticks;
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
					r_PTicks.SetBelong(this.instance);
				}
				return r_PTicks;
			}
		}

		/// <summary>
		/// Int32 Days
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PDays;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPDays
		{
			get
			{
				if(r_PDays == null)
				{
					r_PDays = new(this, "Days", -1);
					r_PDays.SetBelong(this.instance);
				}
				return r_PDays;
			}
		}

		/// <summary>
		/// Int32 Hours
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PHours;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPHours
		{
			get
			{
				if(r_PHours == null)
				{
					r_PHours = new(this, "Hours", -1);
					r_PHours.SetBelong(this.instance);
				}
				return r_PHours;
			}
		}

		/// <summary>
		/// Int32 Milliseconds
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PMilliseconds;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPMilliseconds
		{
			get
			{
				if(r_PMilliseconds == null)
				{
					r_PMilliseconds = new(this, "Milliseconds", -1);
					r_PMilliseconds.SetBelong(this.instance);
				}
				return r_PMilliseconds;
			}
		}

		/// <summary>
		/// Int32 Minutes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PMinutes;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPMinutes
		{
			get
			{
				if(r_PMinutes == null)
				{
					r_PMinutes = new(this, "Minutes", -1);
					r_PMinutes.SetBelong(this.instance);
				}
				return r_PMinutes;
			}
		}

		/// <summary>
		/// Int32 Seconds
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PSeconds;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPSeconds
		{
			get
			{
				if(r_PSeconds == null)
				{
					r_PSeconds = new(this, "Seconds", -1);
					r_PSeconds.SetBelong(this.instance);
				}
				return r_PSeconds;
			}
		}

		/// <summary>
		/// Double TotalDays
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RDouble r_PTotalDays;
		public virtual Hvak.Editor.Refleaction.RSystem.RDouble RPTotalDays
		{
			get
			{
				if(r_PTotalDays == null)
				{
					r_PTotalDays = new(this, "TotalDays", -1);
					r_PTotalDays.SetBelong(this.instance);
				}
				return r_PTotalDays;
			}
		}

		/// <summary>
		/// Double TotalHours
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RDouble r_PTotalHours;
		public virtual Hvak.Editor.Refleaction.RSystem.RDouble RPTotalHours
		{
			get
			{
				if(r_PTotalHours == null)
				{
					r_PTotalHours = new(this, "TotalHours", -1);
					r_PTotalHours.SetBelong(this.instance);
				}
				return r_PTotalHours;
			}
		}

		/// <summary>
		/// Double TotalMilliseconds
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RDouble r_PTotalMilliseconds;
		public virtual Hvak.Editor.Refleaction.RSystem.RDouble RPTotalMilliseconds
		{
			get
			{
				if(r_PTotalMilliseconds == null)
				{
					r_PTotalMilliseconds = new(this, "TotalMilliseconds", -1);
					r_PTotalMilliseconds.SetBelong(this.instance);
				}
				return r_PTotalMilliseconds;
			}
		}

		/// <summary>
		/// Double TotalMinutes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RDouble r_PTotalMinutes;
		public virtual Hvak.Editor.Refleaction.RSystem.RDouble RPTotalMinutes
		{
			get
			{
				if(r_PTotalMinutes == null)
				{
					r_PTotalMinutes = new(this, "TotalMinutes", -1);
					r_PTotalMinutes.SetBelong(this.instance);
				}
				return r_PTotalMinutes;
			}
		}

		/// <summary>
		/// Double TotalSeconds
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RDouble r_PTotalSeconds;
		public virtual Hvak.Editor.Refleaction.RSystem.RDouble RPTotalSeconds
		{
			get
			{
				if(r_PTotalSeconds == null)
				{
					r_PTotalSeconds = new(this, "TotalSeconds", -1);
					r_PTotalSeconds.SetBelong(this.instance);
				}
				return r_PTotalSeconds;
			}
		}

		/// <summary>
		/// System.TimeSpan Add(System.TimeSpan)
		/// </summary>
		protected RMethod r_MAdd_TimeSpan;
		public virtual RMethod RMAdd_TimeSpan
		{
			get
			{
				if(r_MAdd_TimeSpan == null)
				{
					r_MAdd_TimeSpan = new(this, "Add", 0, typeof(System.TimeSpan));
					r_MAdd_TimeSpan.SetBelong(this.instance);
				}
				return r_MAdd_TimeSpan;
			}
		}

		/// <summary>
		/// Int32 Compare(System.TimeSpan, System.TimeSpan)
		/// </summary>
		protected static RMethod r_MCompare_TimeSpan_TimeSpan;
		public static RMethod RMCompare_TimeSpan_TimeSpan
		{
			get
			{
				if(r_MCompare_TimeSpan_TimeSpan == null)
				{
					r_MCompare_TimeSpan_TimeSpan = new(typeof(System.TimeSpan), "Compare", 0, typeof(System.TimeSpan), typeof(System.TimeSpan));
					r_MCompare_TimeSpan_TimeSpan.SetBelong(null);
				}
				return r_MCompare_TimeSpan_TimeSpan;
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
					r_MCompareTo_Object.SetBelong(this.instance);
				}
				return r_MCompareTo_Object;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.TimeSpan)
		/// </summary>
		protected RMethod r_MCompareTo_TimeSpan;
		public virtual RMethod RMCompareTo_TimeSpan
		{
			get
			{
				if(r_MCompareTo_TimeSpan == null)
				{
					r_MCompareTo_TimeSpan = new(this, "CompareTo", 0, typeof(System.TimeSpan));
					r_MCompareTo_TimeSpan.SetBelong(this.instance);
				}
				return r_MCompareTo_TimeSpan;
			}
		}

		/// <summary>
		/// System.TimeSpan FromDays(Double)
		/// </summary>
		protected static RMethod r_MFromDays_Double;
		public static RMethod RMFromDays_Double
		{
			get
			{
				if(r_MFromDays_Double == null)
				{
					r_MFromDays_Double = new(typeof(System.TimeSpan), "FromDays", 0, typeof(System.Double));
					r_MFromDays_Double.SetBelong(null);
				}
				return r_MFromDays_Double;
			}
		}

		/// <summary>
		/// System.TimeSpan Duration()
		/// </summary>
		protected RMethod r_MDuration;
		public virtual RMethod RMDuration
		{
			get
			{
				if(r_MDuration == null)
				{
					r_MDuration = new(this, "Duration", 0);
					r_MDuration.SetBelong(this.instance);
				}
				return r_MDuration;
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
		/// Boolean Equals(System.TimeSpan)
		/// </summary>
		protected RMethod r_MEquals_TimeSpan;
		public virtual RMethod RMEquals_TimeSpan
		{
			get
			{
				if(r_MEquals_TimeSpan == null)
				{
					r_MEquals_TimeSpan = new(this, "Equals", 0, typeof(System.TimeSpan));
					r_MEquals_TimeSpan.SetBelong(this.instance);
				}
				return r_MEquals_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean Equals(System.TimeSpan, System.TimeSpan)
		/// </summary>
		protected static RMethod r_MEquals_TimeSpan_TimeSpan;
		public static RMethod RMEquals_TimeSpan_TimeSpan
		{
			get
			{
				if(r_MEquals_TimeSpan_TimeSpan == null)
				{
					r_MEquals_TimeSpan_TimeSpan = new(typeof(System.TimeSpan), "Equals", 0, typeof(System.TimeSpan), typeof(System.TimeSpan));
					r_MEquals_TimeSpan_TimeSpan.SetBelong(null);
				}
				return r_MEquals_TimeSpan_TimeSpan;
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
		/// System.TimeSpan FromHours(Double)
		/// </summary>
		protected static RMethod r_MFromHours_Double;
		public static RMethod RMFromHours_Double
		{
			get
			{
				if(r_MFromHours_Double == null)
				{
					r_MFromHours_Double = new(typeof(System.TimeSpan), "FromHours", 0, typeof(System.Double));
					r_MFromHours_Double.SetBelong(null);
				}
				return r_MFromHours_Double;
			}
		}

		/// <summary>
		/// System.TimeSpan Interval(Double, Int32)
		/// </summary>
		protected static RMethod r_MInterval_Double_Int32;
		public static RMethod RMInterval_Double_Int32
		{
			get
			{
				if(r_MInterval_Double_Int32 == null)
				{
					r_MInterval_Double_Int32 = new(typeof(System.TimeSpan), "Interval", 0, typeof(System.Double), typeof(System.Int32));
					r_MInterval_Double_Int32.SetBelong(null);
				}
				return r_MInterval_Double_Int32;
			}
		}

		/// <summary>
		/// System.TimeSpan FromMilliseconds(Double)
		/// </summary>
		protected static RMethod r_MFromMilliseconds_Double;
		public static RMethod RMFromMilliseconds_Double
		{
			get
			{
				if(r_MFromMilliseconds_Double == null)
				{
					r_MFromMilliseconds_Double = new(typeof(System.TimeSpan), "FromMilliseconds", 0, typeof(System.Double));
					r_MFromMilliseconds_Double.SetBelong(null);
				}
				return r_MFromMilliseconds_Double;
			}
		}

		/// <summary>
		/// System.TimeSpan FromMinutes(Double)
		/// </summary>
		protected static RMethod r_MFromMinutes_Double;
		public static RMethod RMFromMinutes_Double
		{
			get
			{
				if(r_MFromMinutes_Double == null)
				{
					r_MFromMinutes_Double = new(typeof(System.TimeSpan), "FromMinutes", 0, typeof(System.Double));
					r_MFromMinutes_Double.SetBelong(null);
				}
				return r_MFromMinutes_Double;
			}
		}

		/// <summary>
		/// System.TimeSpan Negate()
		/// </summary>
		protected RMethod r_MNegate;
		public virtual RMethod RMNegate
		{
			get
			{
				if(r_MNegate == null)
				{
					r_MNegate = new(this, "Negate", 0);
					r_MNegate.SetBelong(this.instance);
				}
				return r_MNegate;
			}
		}

		/// <summary>
		/// System.TimeSpan FromSeconds(Double)
		/// </summary>
		protected static RMethod r_MFromSeconds_Double;
		public static RMethod RMFromSeconds_Double
		{
			get
			{
				if(r_MFromSeconds_Double == null)
				{
					r_MFromSeconds_Double = new(typeof(System.TimeSpan), "FromSeconds", 0, typeof(System.Double));
					r_MFromSeconds_Double.SetBelong(null);
				}
				return r_MFromSeconds_Double;
			}
		}

		/// <summary>
		/// System.TimeSpan Subtract(System.TimeSpan)
		/// </summary>
		protected RMethod r_MSubtract_TimeSpan;
		public virtual RMethod RMSubtract_TimeSpan
		{
			get
			{
				if(r_MSubtract_TimeSpan == null)
				{
					r_MSubtract_TimeSpan = new(this, "Subtract", 0, typeof(System.TimeSpan));
					r_MSubtract_TimeSpan.SetBelong(this.instance);
				}
				return r_MSubtract_TimeSpan;
			}
		}

		/// <summary>
		/// System.TimeSpan Multiply(Double)
		/// </summary>
		protected RMethod r_MMultiply_Double;
		public virtual RMethod RMMultiply_Double
		{
			get
			{
				if(r_MMultiply_Double == null)
				{
					r_MMultiply_Double = new(this, "Multiply", 0, typeof(System.Double));
					r_MMultiply_Double.SetBelong(this.instance);
				}
				return r_MMultiply_Double;
			}
		}

		/// <summary>
		/// System.TimeSpan Divide(Double)
		/// </summary>
		protected RMethod r_MDivide_Double;
		public virtual RMethod RMDivide_Double
		{
			get
			{
				if(r_MDivide_Double == null)
				{
					r_MDivide_Double = new(this, "Divide", 0, typeof(System.Double));
					r_MDivide_Double.SetBelong(this.instance);
				}
				return r_MDivide_Double;
			}
		}

		/// <summary>
		/// Double Divide(System.TimeSpan)
		/// </summary>
		protected RMethod r_MDivide_TimeSpan;
		public virtual RMethod RMDivide_TimeSpan
		{
			get
			{
				if(r_MDivide_TimeSpan == null)
				{
					r_MDivide_TimeSpan = new(this, "Divide", 0, typeof(System.TimeSpan));
					r_MDivide_TimeSpan.SetBelong(this.instance);
				}
				return r_MDivide_TimeSpan;
			}
		}

		/// <summary>
		/// System.TimeSpan FromTicks(Int64)
		/// </summary>
		protected static RMethod r_MFromTicks_Int64;
		public static RMethod RMFromTicks_Int64
		{
			get
			{
				if(r_MFromTicks_Int64 == null)
				{
					r_MFromTicks_Int64 = new(typeof(System.TimeSpan), "FromTicks", 0, typeof(System.Int64));
					r_MFromTicks_Int64.SetBelong(null);
				}
				return r_MFromTicks_Int64;
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
					r_MTimeToTicks_Int32_Int32_Int32 = new(typeof(System.TimeSpan), "TimeToTicks", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_MTimeToTicks_Int32_Int32_Int32.SetBelong(null);
				}
				return r_MTimeToTicks_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void ValidateStyles(System.Globalization.TimeSpanStyles, System.String)
		/// </summary>
		protected static RMethod r_MValidateStyles_TimeSpanStyles_String;
		public static RMethod RMValidateStyles_TimeSpanStyles_String
		{
			get
			{
				if(r_MValidateStyles_TimeSpanStyles_String == null)
				{
					r_MValidateStyles_TimeSpanStyles_String = new(typeof(System.TimeSpan), "ValidateStyles", 0, typeof(System.Globalization.TimeSpanStyles), typeof(System.String));
					r_MValidateStyles_TimeSpanStyles_String.SetBelong(null);
				}
				return r_MValidateStyles_TimeSpanStyles_String;
			}
		}

		/// <summary>
		/// System.TimeSpan Parse(System.String)
		/// </summary>
		protected static RMethod r_MParse_String;
		public static RMethod RMParse_String
		{
			get
			{
				if(r_MParse_String == null)
				{
					r_MParse_String = new(typeof(System.TimeSpan), "Parse", 0, typeof(System.String));
					r_MParse_String.SetBelong(null);
				}
				return r_MParse_String;
			}
		}

		/// <summary>
		/// System.TimeSpan Parse(System.String, System.IFormatProvider)
		/// </summary>
		protected static RMethod r_MParse_String_IFormatProvider;
		public static RMethod RMParse_String_IFormatProvider
		{
			get
			{
				if(r_MParse_String_IFormatProvider == null)
				{
					r_MParse_String_IFormatProvider = new(typeof(System.TimeSpan), "Parse", 0, typeof(System.String), typeof(System.IFormatProvider));
					r_MParse_String_IFormatProvider.SetBelong(null);
				}
				return r_MParse_String_IFormatProvider;
			}
		}

		/// <summary>
		/// System.TimeSpan Parse(System.ReadOnlySpan`1[System.Char], System.IFormatProvider)
		/// </summary>
		protected static RMethod r_MParse_ReadOnlySpan_d_Char_p__IFormatProvider;
		public static RMethod RMParse_ReadOnlySpan_d_Char_p__IFormatProvider
		{
			get
			{
				if(r_MParse_ReadOnlySpan_d_Char_p__IFormatProvider == null)
				{
					r_MParse_ReadOnlySpan_d_Char_p__IFormatProvider = new(typeof(System.TimeSpan), "Parse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider));
					r_MParse_ReadOnlySpan_d_Char_p__IFormatProvider.SetBelong(null);
				}
				return r_MParse_ReadOnlySpan_d_Char_p__IFormatProvider;
			}
		}

		/// <summary>
		/// System.TimeSpan ParseExact(System.String, System.String, System.IFormatProvider)
		/// </summary>
		protected static RMethod r_MParseExact_String_String_IFormatProvider;
		public static RMethod RMParseExact_String_String_IFormatProvider
		{
			get
			{
				if(r_MParseExact_String_String_IFormatProvider == null)
				{
					r_MParseExact_String_String_IFormatProvider = new(typeof(System.TimeSpan), "ParseExact", 0, typeof(System.String), typeof(System.String), typeof(System.IFormatProvider));
					r_MParseExact_String_String_IFormatProvider.SetBelong(null);
				}
				return r_MParseExact_String_String_IFormatProvider;
			}
		}

		/// <summary>
		/// System.TimeSpan ParseExact(System.String, System.String[], System.IFormatProvider)
		/// </summary>
		protected static RMethod r_MParseExact_String_StringArray_IFormatProvider;
		public static RMethod RMParseExact_String_StringArray_IFormatProvider
		{
			get
			{
				if(r_MParseExact_String_StringArray_IFormatProvider == null)
				{
					r_MParseExact_String_StringArray_IFormatProvider = new(typeof(System.TimeSpan), "ParseExact", 0, typeof(System.String), typeof(System.String).MakeArrayType(), typeof(System.IFormatProvider));
					r_MParseExact_String_StringArray_IFormatProvider.SetBelong(null);
				}
				return r_MParseExact_String_StringArray_IFormatProvider;
			}
		}

		/// <summary>
		/// System.TimeSpan ParseExact(System.String, System.String, System.IFormatProvider, System.Globalization.TimeSpanStyles)
		/// </summary>
		protected static RMethod r_MParseExact_String_String_IFormatProvider_TimeSpanStyles;
		public static RMethod RMParseExact_String_String_IFormatProvider_TimeSpanStyles
		{
			get
			{
				if(r_MParseExact_String_String_IFormatProvider_TimeSpanStyles == null)
				{
					r_MParseExact_String_String_IFormatProvider_TimeSpanStyles = new(typeof(System.TimeSpan), "ParseExact", 0, typeof(System.String), typeof(System.String), typeof(System.IFormatProvider), typeof(System.Globalization.TimeSpanStyles));
					r_MParseExact_String_String_IFormatProvider_TimeSpanStyles.SetBelong(null);
				}
				return r_MParseExact_String_String_IFormatProvider_TimeSpanStyles;
			}
		}

		/// <summary>
		/// System.TimeSpan ParseExact(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.IFormatProvider, System.Globalization.TimeSpanStyles)
		/// </summary>
		protected static RMethod r_MParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_TimeSpanStyles;
		public static RMethod RMParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_TimeSpanStyles
		{
			get
			{
				if(r_MParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_TimeSpanStyles == null)
				{
					r_MParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_TimeSpanStyles = new(typeof(System.TimeSpan), "ParseExact", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider), typeof(System.Globalization.TimeSpanStyles));
					r_MParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_TimeSpanStyles.SetBelong(null);
				}
				return r_MParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_TimeSpanStyles;
			}
		}

		/// <summary>
		/// System.TimeSpan ParseExact(System.String, System.String[], System.IFormatProvider, System.Globalization.TimeSpanStyles)
		/// </summary>
		protected static RMethod r_MParseExact_String_StringArray_IFormatProvider_TimeSpanStyles;
		public static RMethod RMParseExact_String_StringArray_IFormatProvider_TimeSpanStyles
		{
			get
			{
				if(r_MParseExact_String_StringArray_IFormatProvider_TimeSpanStyles == null)
				{
					r_MParseExact_String_StringArray_IFormatProvider_TimeSpanStyles = new(typeof(System.TimeSpan), "ParseExact", 0, typeof(System.String), typeof(System.String).MakeArrayType(), typeof(System.IFormatProvider), typeof(System.Globalization.TimeSpanStyles));
					r_MParseExact_String_StringArray_IFormatProvider_TimeSpanStyles.SetBelong(null);
				}
				return r_MParseExact_String_StringArray_IFormatProvider_TimeSpanStyles;
			}
		}

		/// <summary>
		/// System.TimeSpan ParseExact(System.ReadOnlySpan`1[System.Char], System.String[], System.IFormatProvider, System.Globalization.TimeSpanStyles)
		/// </summary>
		protected static RMethod r_MParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_TimeSpanStyles;
		public static RMethod RMParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_TimeSpanStyles
		{
			get
			{
				if(r_MParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_TimeSpanStyles == null)
				{
					r_MParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_TimeSpanStyles = new(typeof(System.TimeSpan), "ParseExact", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.String).MakeArrayType(), typeof(System.IFormatProvider), typeof(System.Globalization.TimeSpanStyles));
					r_MParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_TimeSpanStyles.SetBelong(null);
				}
				return r_MParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_TimeSpanStyles;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.String, System.TimeSpan ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_String_Out_TimeSpan;
		public static RMethod RMTryParse_String_Out_TimeSpan
		{
			get
			{
				if(r_MTryParse_String_Out_TimeSpan == null)
				{
					r_MTryParse_String_Out_TimeSpan = new(typeof(System.TimeSpan), "TryParse", 0, typeof(System.String), typeof(System.TimeSpan).MakeByRefType());
					r_MTryParse_String_Out_TimeSpan.SetBelong(null);
				}
				return r_MTryParse_String_Out_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], System.TimeSpan ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_ReadOnlySpan_d_Char_p__Out_TimeSpan;
		public static RMethod RMTryParse_ReadOnlySpan_d_Char_p__Out_TimeSpan
		{
			get
			{
				if(r_MTryParse_ReadOnlySpan_d_Char_p__Out_TimeSpan == null)
				{
					r_MTryParse_ReadOnlySpan_d_Char_p__Out_TimeSpan = new(typeof(System.TimeSpan), "TryParse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.TimeSpan).MakeByRefType());
					r_MTryParse_ReadOnlySpan_d_Char_p__Out_TimeSpan.SetBelong(null);
				}
				return r_MTryParse_ReadOnlySpan_d_Char_p__Out_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.String, System.IFormatProvider, System.TimeSpan ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_String_IFormatProvider_Out_TimeSpan;
		public static RMethod RMTryParse_String_IFormatProvider_Out_TimeSpan
		{
			get
			{
				if(r_MTryParse_String_IFormatProvider_Out_TimeSpan == null)
				{
					r_MTryParse_String_IFormatProvider_Out_TimeSpan = new(typeof(System.TimeSpan), "TryParse", 0, typeof(System.String), typeof(System.IFormatProvider), typeof(System.TimeSpan).MakeByRefType());
					r_MTryParse_String_IFormatProvider_Out_TimeSpan.SetBelong(null);
				}
				return r_MTryParse_String_IFormatProvider_Out_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], System.IFormatProvider, System.TimeSpan ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_ReadOnlySpan_d_Char_p__IFormatProvider_Out_TimeSpan;
		public static RMethod RMTryParse_ReadOnlySpan_d_Char_p__IFormatProvider_Out_TimeSpan
		{
			get
			{
				if(r_MTryParse_ReadOnlySpan_d_Char_p__IFormatProvider_Out_TimeSpan == null)
				{
					r_MTryParse_ReadOnlySpan_d_Char_p__IFormatProvider_Out_TimeSpan = new(typeof(System.TimeSpan), "TryParse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider), typeof(System.TimeSpan).MakeByRefType());
					r_MTryParse_ReadOnlySpan_d_Char_p__IFormatProvider_Out_TimeSpan.SetBelong(null);
				}
				return r_MTryParse_ReadOnlySpan_d_Char_p__IFormatProvider_Out_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean TryParseExact(System.String, System.String, System.IFormatProvider, System.TimeSpan ByRef)
		/// </summary>
		protected static RMethod r_MTryParseExact_String_String_IFormatProvider_Out_TimeSpan;
		public static RMethod RMTryParseExact_String_String_IFormatProvider_Out_TimeSpan
		{
			get
			{
				if(r_MTryParseExact_String_String_IFormatProvider_Out_TimeSpan == null)
				{
					r_MTryParseExact_String_String_IFormatProvider_Out_TimeSpan = new(typeof(System.TimeSpan), "TryParseExact", 0, typeof(System.String), typeof(System.String), typeof(System.IFormatProvider), typeof(System.TimeSpan).MakeByRefType());
					r_MTryParseExact_String_String_IFormatProvider_Out_TimeSpan.SetBelong(null);
				}
				return r_MTryParseExact_String_String_IFormatProvider_Out_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean TryParseExact(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.IFormatProvider, System.TimeSpan ByRef)
		/// </summary>
		protected static RMethod r_MTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_Out_TimeSpan;
		public static RMethod RMTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_Out_TimeSpan
		{
			get
			{
				if(r_MTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_Out_TimeSpan == null)
				{
					r_MTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_Out_TimeSpan = new(typeof(System.TimeSpan), "TryParseExact", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider), typeof(System.TimeSpan).MakeByRefType());
					r_MTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_Out_TimeSpan.SetBelong(null);
				}
				return r_MTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_Out_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean TryParseExact(System.String, System.String[], System.IFormatProvider, System.TimeSpan ByRef)
		/// </summary>
		protected static RMethod r_MTryParseExact_String_StringArray_IFormatProvider_Out_TimeSpan;
		public static RMethod RMTryParseExact_String_StringArray_IFormatProvider_Out_TimeSpan
		{
			get
			{
				if(r_MTryParseExact_String_StringArray_IFormatProvider_Out_TimeSpan == null)
				{
					r_MTryParseExact_String_StringArray_IFormatProvider_Out_TimeSpan = new(typeof(System.TimeSpan), "TryParseExact", 0, typeof(System.String), typeof(System.String).MakeArrayType(), typeof(System.IFormatProvider), typeof(System.TimeSpan).MakeByRefType());
					r_MTryParseExact_String_StringArray_IFormatProvider_Out_TimeSpan.SetBelong(null);
				}
				return r_MTryParseExact_String_StringArray_IFormatProvider_Out_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean TryParseExact(System.ReadOnlySpan`1[System.Char], System.String[], System.IFormatProvider, System.TimeSpan ByRef)
		/// </summary>
		protected static RMethod r_MTryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_Out_TimeSpan;
		public static RMethod RMTryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_Out_TimeSpan
		{
			get
			{
				if(r_MTryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_Out_TimeSpan == null)
				{
					r_MTryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_Out_TimeSpan = new(typeof(System.TimeSpan), "TryParseExact", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.String).MakeArrayType(), typeof(System.IFormatProvider), typeof(System.TimeSpan).MakeByRefType());
					r_MTryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_Out_TimeSpan.SetBelong(null);
				}
				return r_MTryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_Out_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean TryParseExact(System.String, System.String, System.IFormatProvider, System.Globalization.TimeSpanStyles, System.TimeSpan ByRef)
		/// </summary>
		protected static RMethod r_MTryParseExact_String_String_IFormatProvider_TimeSpanStyles_Out_TimeSpan;
		public static RMethod RMTryParseExact_String_String_IFormatProvider_TimeSpanStyles_Out_TimeSpan
		{
			get
			{
				if(r_MTryParseExact_String_String_IFormatProvider_TimeSpanStyles_Out_TimeSpan == null)
				{
					r_MTryParseExact_String_String_IFormatProvider_TimeSpanStyles_Out_TimeSpan = new(typeof(System.TimeSpan), "TryParseExact", 0, typeof(System.String), typeof(System.String), typeof(System.IFormatProvider), typeof(System.Globalization.TimeSpanStyles), typeof(System.TimeSpan).MakeByRefType());
					r_MTryParseExact_String_String_IFormatProvider_TimeSpanStyles_Out_TimeSpan.SetBelong(null);
				}
				return r_MTryParseExact_String_String_IFormatProvider_TimeSpanStyles_Out_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean TryParseExact(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.IFormatProvider, System.Globalization.TimeSpanStyles, System.TimeSpan ByRef)
		/// </summary>
		protected static RMethod r_MTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_TimeSpanStyles_Out_TimeSpan;
		public static RMethod RMTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_TimeSpanStyles_Out_TimeSpan
		{
			get
			{
				if(r_MTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_TimeSpanStyles_Out_TimeSpan == null)
				{
					r_MTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_TimeSpanStyles_Out_TimeSpan = new(typeof(System.TimeSpan), "TryParseExact", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider), typeof(System.Globalization.TimeSpanStyles), typeof(System.TimeSpan).MakeByRefType());
					r_MTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_TimeSpanStyles_Out_TimeSpan.SetBelong(null);
				}
				return r_MTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_TimeSpanStyles_Out_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean TryParseExact(System.String, System.String[], System.IFormatProvider, System.Globalization.TimeSpanStyles, System.TimeSpan ByRef)
		/// </summary>
		protected static RMethod r_MTryParseExact_String_StringArray_IFormatProvider_TimeSpanStyles_Out_TimeSpan;
		public static RMethod RMTryParseExact_String_StringArray_IFormatProvider_TimeSpanStyles_Out_TimeSpan
		{
			get
			{
				if(r_MTryParseExact_String_StringArray_IFormatProvider_TimeSpanStyles_Out_TimeSpan == null)
				{
					r_MTryParseExact_String_StringArray_IFormatProvider_TimeSpanStyles_Out_TimeSpan = new(typeof(System.TimeSpan), "TryParseExact", 0, typeof(System.String), typeof(System.String).MakeArrayType(), typeof(System.IFormatProvider), typeof(System.Globalization.TimeSpanStyles), typeof(System.TimeSpan).MakeByRefType());
					r_MTryParseExact_String_StringArray_IFormatProvider_TimeSpanStyles_Out_TimeSpan.SetBelong(null);
				}
				return r_MTryParseExact_String_StringArray_IFormatProvider_TimeSpanStyles_Out_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean TryParseExact(System.ReadOnlySpan`1[System.Char], System.String[], System.IFormatProvider, System.Globalization.TimeSpanStyles, System.TimeSpan ByRef)
		/// </summary>
		protected static RMethod r_MTryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_TimeSpanStyles_Out_TimeSpan;
		public static RMethod RMTryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_TimeSpanStyles_Out_TimeSpan
		{
			get
			{
				if(r_MTryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_TimeSpanStyles_Out_TimeSpan == null)
				{
					r_MTryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_TimeSpanStyles_Out_TimeSpan = new(typeof(System.TimeSpan), "TryParseExact", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.String).MakeArrayType(), typeof(System.IFormatProvider), typeof(System.Globalization.TimeSpanStyles), typeof(System.TimeSpan).MakeByRefType());
					r_MTryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_TimeSpanStyles_Out_TimeSpan.SetBelong(null);
				}
				return r_MTryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_TimeSpanStyles_Out_TimeSpan;
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
					r_MToString_String.SetBelong(this.instance);
				}
				return r_MToString_String;
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
					r_MToString_String_IFormatProvider.SetBelong(this.instance);
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
					r_MTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider.SetBelong(this.instance);
				}
				return r_MTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider;
			}
		}

		/// <summary>
		/// System.TimeSpan op_UnaryNegation(System.TimeSpan)
		/// </summary>
		protected static RMethod r_Mop_UnaryNegation_TimeSpan;
		public static RMethod RMop_UnaryNegation_TimeSpan
		{
			get
			{
				if(r_Mop_UnaryNegation_TimeSpan == null)
				{
					r_Mop_UnaryNegation_TimeSpan = new(typeof(System.TimeSpan), "op_UnaryNegation", 0, typeof(System.TimeSpan));
					r_Mop_UnaryNegation_TimeSpan.SetBelong(null);
				}
				return r_Mop_UnaryNegation_TimeSpan;
			}
		}

		/// <summary>
		/// System.TimeSpan op_Subtraction(System.TimeSpan, System.TimeSpan)
		/// </summary>
		protected static RMethod r_Mop_Subtraction_TimeSpan_TimeSpan;
		public static RMethod RMop_Subtraction_TimeSpan_TimeSpan
		{
			get
			{
				if(r_Mop_Subtraction_TimeSpan_TimeSpan == null)
				{
					r_Mop_Subtraction_TimeSpan_TimeSpan = new(typeof(System.TimeSpan), "op_Subtraction", 0, typeof(System.TimeSpan), typeof(System.TimeSpan));
					r_Mop_Subtraction_TimeSpan_TimeSpan.SetBelong(null);
				}
				return r_Mop_Subtraction_TimeSpan_TimeSpan;
			}
		}

		/// <summary>
		/// System.TimeSpan op_UnaryPlus(System.TimeSpan)
		/// </summary>
		protected static RMethod r_Mop_UnaryPlus_TimeSpan;
		public static RMethod RMop_UnaryPlus_TimeSpan
		{
			get
			{
				if(r_Mop_UnaryPlus_TimeSpan == null)
				{
					r_Mop_UnaryPlus_TimeSpan = new(typeof(System.TimeSpan), "op_UnaryPlus", 0, typeof(System.TimeSpan));
					r_Mop_UnaryPlus_TimeSpan.SetBelong(null);
				}
				return r_Mop_UnaryPlus_TimeSpan;
			}
		}

		/// <summary>
		/// System.TimeSpan op_Addition(System.TimeSpan, System.TimeSpan)
		/// </summary>
		protected static RMethod r_Mop_Addition_TimeSpan_TimeSpan;
		public static RMethod RMop_Addition_TimeSpan_TimeSpan
		{
			get
			{
				if(r_Mop_Addition_TimeSpan_TimeSpan == null)
				{
					r_Mop_Addition_TimeSpan_TimeSpan = new(typeof(System.TimeSpan), "op_Addition", 0, typeof(System.TimeSpan), typeof(System.TimeSpan));
					r_Mop_Addition_TimeSpan_TimeSpan.SetBelong(null);
				}
				return r_Mop_Addition_TimeSpan_TimeSpan;
			}
		}

		/// <summary>
		/// System.TimeSpan op_Multiply(System.TimeSpan, Double)
		/// </summary>
		protected static RMethod r_Mop_Multiply_TimeSpan_Double;
		public static RMethod RMop_Multiply_TimeSpan_Double
		{
			get
			{
				if(r_Mop_Multiply_TimeSpan_Double == null)
				{
					r_Mop_Multiply_TimeSpan_Double = new(typeof(System.TimeSpan), "op_Multiply", 0, typeof(System.TimeSpan), typeof(System.Double));
					r_Mop_Multiply_TimeSpan_Double.SetBelong(null);
				}
				return r_Mop_Multiply_TimeSpan_Double;
			}
		}

		/// <summary>
		/// System.TimeSpan op_Multiply(Double, System.TimeSpan)
		/// </summary>
		protected static RMethod r_Mop_Multiply_Double_TimeSpan;
		public static RMethod RMop_Multiply_Double_TimeSpan
		{
			get
			{
				if(r_Mop_Multiply_Double_TimeSpan == null)
				{
					r_Mop_Multiply_Double_TimeSpan = new(typeof(System.TimeSpan), "op_Multiply", 0, typeof(System.Double), typeof(System.TimeSpan));
					r_Mop_Multiply_Double_TimeSpan.SetBelong(null);
				}
				return r_Mop_Multiply_Double_TimeSpan;
			}
		}

		/// <summary>
		/// System.TimeSpan op_Division(System.TimeSpan, Double)
		/// </summary>
		protected static RMethod r_Mop_Division_TimeSpan_Double;
		public static RMethod RMop_Division_TimeSpan_Double
		{
			get
			{
				if(r_Mop_Division_TimeSpan_Double == null)
				{
					r_Mop_Division_TimeSpan_Double = new(typeof(System.TimeSpan), "op_Division", 0, typeof(System.TimeSpan), typeof(System.Double));
					r_Mop_Division_TimeSpan_Double.SetBelong(null);
				}
				return r_Mop_Division_TimeSpan_Double;
			}
		}

		/// <summary>
		/// Double op_Division(System.TimeSpan, System.TimeSpan)
		/// </summary>
		protected static RMethod r_Mop_Division_TimeSpan_TimeSpan;
		public static RMethod RMop_Division_TimeSpan_TimeSpan
		{
			get
			{
				if(r_Mop_Division_TimeSpan_TimeSpan == null)
				{
					r_Mop_Division_TimeSpan_TimeSpan = new(typeof(System.TimeSpan), "op_Division", 0, typeof(System.TimeSpan), typeof(System.TimeSpan));
					r_Mop_Division_TimeSpan_TimeSpan.SetBelong(null);
				}
				return r_Mop_Division_TimeSpan_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.TimeSpan, System.TimeSpan)
		/// </summary>
		protected static RMethod r_Mop_Equality_TimeSpan_TimeSpan;
		public static RMethod RMop_Equality_TimeSpan_TimeSpan
		{
			get
			{
				if(r_Mop_Equality_TimeSpan_TimeSpan == null)
				{
					r_Mop_Equality_TimeSpan_TimeSpan = new(typeof(System.TimeSpan), "op_Equality", 0, typeof(System.TimeSpan), typeof(System.TimeSpan));
					r_Mop_Equality_TimeSpan_TimeSpan.SetBelong(null);
				}
				return r_Mop_Equality_TimeSpan_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.TimeSpan, System.TimeSpan)
		/// </summary>
		protected static RMethod r_Mop_Inequality_TimeSpan_TimeSpan;
		public static RMethod RMop_Inequality_TimeSpan_TimeSpan
		{
			get
			{
				if(r_Mop_Inequality_TimeSpan_TimeSpan == null)
				{
					r_Mop_Inequality_TimeSpan_TimeSpan = new(typeof(System.TimeSpan), "op_Inequality", 0, typeof(System.TimeSpan), typeof(System.TimeSpan));
					r_Mop_Inequality_TimeSpan_TimeSpan.SetBelong(null);
				}
				return r_Mop_Inequality_TimeSpan_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean op_LessThan(System.TimeSpan, System.TimeSpan)
		/// </summary>
		protected static RMethod r_Mop_LessThan_TimeSpan_TimeSpan;
		public static RMethod RMop_LessThan_TimeSpan_TimeSpan
		{
			get
			{
				if(r_Mop_LessThan_TimeSpan_TimeSpan == null)
				{
					r_Mop_LessThan_TimeSpan_TimeSpan = new(typeof(System.TimeSpan), "op_LessThan", 0, typeof(System.TimeSpan), typeof(System.TimeSpan));
					r_Mop_LessThan_TimeSpan_TimeSpan.SetBelong(null);
				}
				return r_Mop_LessThan_TimeSpan_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean op_LessThanOrEqual(System.TimeSpan, System.TimeSpan)
		/// </summary>
		protected static RMethod r_Mop_LessThanOrEqual_TimeSpan_TimeSpan;
		public static RMethod RMop_LessThanOrEqual_TimeSpan_TimeSpan
		{
			get
			{
				if(r_Mop_LessThanOrEqual_TimeSpan_TimeSpan == null)
				{
					r_Mop_LessThanOrEqual_TimeSpan_TimeSpan = new(typeof(System.TimeSpan), "op_LessThanOrEqual", 0, typeof(System.TimeSpan), typeof(System.TimeSpan));
					r_Mop_LessThanOrEqual_TimeSpan_TimeSpan.SetBelong(null);
				}
				return r_Mop_LessThanOrEqual_TimeSpan_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean op_GreaterThan(System.TimeSpan, System.TimeSpan)
		/// </summary>
		protected static RMethod r_Mop_GreaterThan_TimeSpan_TimeSpan;
		public static RMethod RMop_GreaterThan_TimeSpan_TimeSpan
		{
			get
			{
				if(r_Mop_GreaterThan_TimeSpan_TimeSpan == null)
				{
					r_Mop_GreaterThan_TimeSpan_TimeSpan = new(typeof(System.TimeSpan), "op_GreaterThan", 0, typeof(System.TimeSpan), typeof(System.TimeSpan));
					r_Mop_GreaterThan_TimeSpan_TimeSpan.SetBelong(null);
				}
				return r_Mop_GreaterThan_TimeSpan_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean op_GreaterThanOrEqual(System.TimeSpan, System.TimeSpan)
		/// </summary>
		protected static RMethod r_Mop_GreaterThanOrEqual_TimeSpan_TimeSpan;
		public static RMethod RMop_GreaterThanOrEqual_TimeSpan_TimeSpan
		{
			get
			{
				if(r_Mop_GreaterThanOrEqual_TimeSpan_TimeSpan == null)
				{
					r_Mop_GreaterThanOrEqual_TimeSpan_TimeSpan = new(typeof(System.TimeSpan), "op_GreaterThanOrEqual", 0, typeof(System.TimeSpan), typeof(System.TimeSpan));
					r_Mop_GreaterThanOrEqual_TimeSpan_TimeSpan.SetBelong(null);
				}
				return r_Mop_GreaterThanOrEqual_TimeSpan_TimeSpan;
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
            var ___result = RMAdd_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.Int32 Compare(System.TimeSpan @t1, System.TimeSpan @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = RMCompare_TimeSpan_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareTo(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareTo(System.TimeSpan @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMCompareTo_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.TimeSpan FromDays(System.Double @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMFromDays_Double.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public virtual System.TimeSpan Duration()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDuration.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public virtual System.Boolean Equals(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.TimeSpan @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean Equals(System.TimeSpan @t1, System.TimeSpan @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = RMEquals_TimeSpan_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.TimeSpan FromHours(System.Double @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMFromHours_Double.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan Interval(System.Double @value, System.Int32 @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @scale};
            var ___result = RMInterval_Double_Int32.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan FromMilliseconds(System.Double @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMFromMilliseconds_Double.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan FromMinutes(System.Double @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMFromMinutes_Double.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public virtual System.TimeSpan Negate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMNegate.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan FromSeconds(System.Double @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMFromSeconds_Double.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public virtual System.TimeSpan Subtract(System.TimeSpan @ts)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ts};
            var ___result = RMSubtract_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public virtual System.TimeSpan Multiply(System.Double @factor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@factor};
            var ___result = RMMultiply_Double.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public virtual System.TimeSpan Divide(System.Double @divisor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@divisor};
            var ___result = RMDivide_Double.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public virtual System.Double Divide(System.TimeSpan @ts)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ts};
            var ___result = RMDivide_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public static System.TimeSpan FromTicks(System.Int64 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMFromTicks_Int64.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.Int64 TimeToTicks(System.Int32 @hour, System.Int32 @minute, System.Int32 @second)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hour, @minute, @second};
            var ___result = RMTimeToTicks_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public static void ValidateStyles(System.Globalization.TimeSpanStyles @style, System.String @parameterName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style, @parameterName};
            var ___result = RMValidateStyles_TimeSpanStyles_String.Invoke(___genericsType, ___parameters);

            
        }


        public static System.TimeSpan Parse(System.String @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RMParse_String.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan Parse(System.String @input, System.IFormatProvider @formatProvider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @formatProvider};
            var ___result = RMParse_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan Parse(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @input, System.IFormatProvider @formatProvider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input.Value, @formatProvider};
            var ___result = RMParse_ReadOnlySpan_d_Char_p__IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan ParseExact(System.String @input, System.String @format, System.IFormatProvider @formatProvider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @format, @formatProvider};
            var ___result = RMParseExact_String_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan ParseExact(System.String @input, System.String[] @formats, System.IFormatProvider @formatProvider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @formats, @formatProvider};
            var ___result = RMParseExact_String_StringArray_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan ParseExact(System.String @input, System.String @format, System.IFormatProvider @formatProvider, System.Globalization.TimeSpanStyles @styles)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @format, @formatProvider, @styles};
            var ___result = RMParseExact_String_String_IFormatProvider_TimeSpanStyles.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan ParseExact(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @input, Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @format, System.IFormatProvider @formatProvider, System.Globalization.TimeSpanStyles @styles)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input.Value, @format.Value, @formatProvider, @styles};
            var ___result = RMParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_TimeSpanStyles.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan ParseExact(System.String @input, System.String[] @formats, System.IFormatProvider @formatProvider, System.Globalization.TimeSpanStyles @styles)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @formats, @formatProvider, @styles};
            var ___result = RMParseExact_String_StringArray_IFormatProvider_TimeSpanStyles.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan ParseExact(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @input, System.String[] @formats, System.IFormatProvider @formatProvider, System.Globalization.TimeSpanStyles @styles)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input.Value, @formats, @formatProvider, @styles};
            var ___result = RMParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_TimeSpanStyles.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.Boolean TryParse(System.String @s, out System.TimeSpan @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @result};
            var ___result = RMTryParse_String_Out_TimeSpan.Invoke(___genericsType, ___parameters);
			@result = (System.TimeSpan)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParse(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @s, out System.TimeSpan @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @result};
            var ___result = RMTryParse_ReadOnlySpan_d_Char_p__Out_TimeSpan.Invoke(___genericsType, ___parameters);
			@result = (System.TimeSpan)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParse(System.String @input, System.IFormatProvider @formatProvider, out System.TimeSpan @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @formatProvider, @result};
            var ___result = RMTryParse_String_IFormatProvider_Out_TimeSpan.Invoke(___genericsType, ___parameters);
			@result = (System.TimeSpan)___parameters[2];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParse(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @input, System.IFormatProvider @formatProvider, out System.TimeSpan @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input.Value, @formatProvider, @result};
            var ___result = RMTryParse_ReadOnlySpan_d_Char_p__IFormatProvider_Out_TimeSpan.Invoke(___genericsType, ___parameters);
			@result = (System.TimeSpan)___parameters[2];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParseExact(System.String @input, System.String @format, System.IFormatProvider @formatProvider, out System.TimeSpan @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @format, @formatProvider, @result};
            var ___result = RMTryParseExact_String_String_IFormatProvider_Out_TimeSpan.Invoke(___genericsType, ___parameters);
			@result = (System.TimeSpan)___parameters[3];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParseExact(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @input, Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @format, System.IFormatProvider @formatProvider, out System.TimeSpan @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input.Value, @format.Value, @formatProvider, @result};
            var ___result = RMTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_Out_TimeSpan.Invoke(___genericsType, ___parameters);
			@result = (System.TimeSpan)___parameters[3];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParseExact(System.String @input, System.String[] @formats, System.IFormatProvider @formatProvider, out System.TimeSpan @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @formats, @formatProvider, @result};
            var ___result = RMTryParseExact_String_StringArray_IFormatProvider_Out_TimeSpan.Invoke(___genericsType, ___parameters);
			@result = (System.TimeSpan)___parameters[3];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParseExact(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @input, System.String[] @formats, System.IFormatProvider @formatProvider, out System.TimeSpan @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input.Value, @formats, @formatProvider, @result};
            var ___result = RMTryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_Out_TimeSpan.Invoke(___genericsType, ___parameters);
			@result = (System.TimeSpan)___parameters[3];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParseExact(System.String @input, System.String @format, System.IFormatProvider @formatProvider, System.Globalization.TimeSpanStyles @styles, out System.TimeSpan @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @format, @formatProvider, @styles, @result};
            var ___result = RMTryParseExact_String_String_IFormatProvider_TimeSpanStyles_Out_TimeSpan.Invoke(___genericsType, ___parameters);
			@result = (System.TimeSpan)___parameters[4];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParseExact(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @input, Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @format, System.IFormatProvider @formatProvider, System.Globalization.TimeSpanStyles @styles, out System.TimeSpan @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input.Value, @format.Value, @formatProvider, @styles, @result};
            var ___result = RMTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_TimeSpanStyles_Out_TimeSpan.Invoke(___genericsType, ___parameters);
			@result = (System.TimeSpan)___parameters[4];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParseExact(System.String @input, System.String[] @formats, System.IFormatProvider @formatProvider, System.Globalization.TimeSpanStyles @styles, out System.TimeSpan @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @formats, @formatProvider, @styles, @result};
            var ___result = RMTryParseExact_String_StringArray_IFormatProvider_TimeSpanStyles_Out_TimeSpan.Invoke(___genericsType, ___parameters);
			@result = (System.TimeSpan)___parameters[4];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParseExact(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @input, System.String[] @formats, System.IFormatProvider @formatProvider, System.Globalization.TimeSpanStyles @styles, out System.TimeSpan @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input.Value, @formats, @formatProvider, @styles, @result};
            var ___result = RMTryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_TimeSpanStyles_Out_TimeSpan.Invoke(___genericsType, ___parameters);
			@result = (System.TimeSpan)___parameters[4];

            return (System.Boolean)___result;
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


        public virtual System.String ToString(System.String @format, System.IFormatProvider @formatProvider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @formatProvider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean TryFormat(Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RSystem.RChar> @destination, out System.Int32 @charsWritten, Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @format, System.IFormatProvider @formatProvider)
        {
			@charsWritten = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination.Value, @charsWritten, @format.Value, @formatProvider};
            var ___result = RMTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider.Invoke(___genericsType, ___parameters);
			@charsWritten = (System.Int32)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.TimeSpan op_UnaryNegation(System.TimeSpan @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RMop_UnaryNegation_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan op_Subtraction(System.TimeSpan @t1, System.TimeSpan @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = RMop_Subtraction_TimeSpan_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan op_UnaryPlus(System.TimeSpan @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RMop_UnaryPlus_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan op_Addition(System.TimeSpan @t1, System.TimeSpan @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = RMop_Addition_TimeSpan_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan op_Multiply(System.TimeSpan @timeSpan, System.Double @factor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeSpan, @factor};
            var ___result = RMop_Multiply_TimeSpan_Double.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan op_Multiply(System.Double @factor, System.TimeSpan @timeSpan)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@factor, @timeSpan};
            var ___result = RMop_Multiply_Double_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.TimeSpan op_Division(System.TimeSpan @timeSpan, System.Double @divisor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeSpan, @divisor};
            var ___result = RMop_Division_TimeSpan_Double.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.Double op_Division(System.TimeSpan @t1, System.TimeSpan @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = RMop_Division_TimeSpan_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public static System.Boolean op_Equality(System.TimeSpan @t1, System.TimeSpan @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = RMop_Equality_TimeSpan_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.TimeSpan @t1, System.TimeSpan @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = RMop_Inequality_TimeSpan_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_LessThan(System.TimeSpan @t1, System.TimeSpan @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = RMop_LessThan_TimeSpan_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_LessThanOrEqual(System.TimeSpan @t1, System.TimeSpan @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = RMop_LessThanOrEqual_TimeSpan_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_GreaterThan(System.TimeSpan @t1, System.TimeSpan @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = RMop_GreaterThan_TimeSpan_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_GreaterThanOrEqual(System.TimeSpan @t1, System.TimeSpan @t2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t1, @t2};
            var ___result = RMop_GreaterThanOrEqual_TimeSpan_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
