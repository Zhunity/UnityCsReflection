
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.ScheduledItem
	/// </summary>
    public partial class RScheduledItem : RMember //
    {

		/// <summary>
		/// System.Func`1[System.Boolean] timerUpdateStopCondition
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RSystem.RBoolean> r_FtimerUpdateStopCondition;
		public virtual Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RSystem.RBoolean> RFtimerUpdateStopCondition
		{
			get
			{
				if(r_FtimerUpdateStopCondition == null)
				{
					r_FtimerUpdateStopCondition = new(this, "timerUpdateStopCondition");
				}
				return r_FtimerUpdateStopCondition;
			}
		}

		/// <summary>
		/// System.Func`1[System.Boolean] OnceCondition
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RSystem.RBoolean> r_FOnceCondition;
		public static Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RSystem.RBoolean> RFOnceCondition
		{
			get
			{
				if(r_FOnceCondition == null)
				{
					r_FOnceCondition = new( ReflectionUtils.GetType("UnityEngine.UIElements.ScheduledItem"), "OnceCondition");
				}
				return r_FOnceCondition;
			}
		}

		/// <summary>
		/// System.Func`1[System.Boolean] ForeverCondition
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RSystem.RBoolean> r_FForeverCondition;
		public static Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RSystem.RBoolean> RFForeverCondition
		{
			get
			{
				if(r_FForeverCondition == null)
				{
					r_FForeverCondition = new( ReflectionUtils.GetType("UnityEngine.UIElements.ScheduledItem"), "ForeverCondition");
				}
				return r_FForeverCondition;
			}
		}

		/// <summary>
		/// System.Int64 <startMs>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_F__0__startMs__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RF__0__startMs__1__k__BackingField
		{
			get
			{
				if(r_F__0__startMs__1__k__BackingField == null)
				{
					r_F__0__startMs__1__k__BackingField = new(this, "<startMs>k__BackingField");
				}
				return r_F__0__startMs__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int64 <delayMs>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_F__0__delayMs__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RF__0__delayMs__1__k__BackingField
		{
			get
			{
				if(r_F__0__delayMs__1__k__BackingField == null)
				{
					r_F__0__delayMs__1__k__BackingField = new(this, "<delayMs>k__BackingField");
				}
				return r_F__0__delayMs__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int64 <intervalMs>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_F__0__intervalMs__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RF__0__intervalMs__1__k__BackingField
		{
			get
			{
				if(r_F__0__intervalMs__1__k__BackingField == null)
				{
					r_F__0__intervalMs__1__k__BackingField = new(this, "<intervalMs>k__BackingField");
				}
				return r_F__0__intervalMs__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int64 <endTimeMs>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_F__0__endTimeMs__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RF__0__endTimeMs__1__k__BackingField
		{
			get
			{
				if(r_F__0__endTimeMs__1__k__BackingField == null)
				{
					r_F__0__endTimeMs__1__k__BackingField = new(this, "<endTimeMs>k__BackingField");
				}
				return r_F__0__endTimeMs__1__k__BackingField;
			}
		}

		/// <summary>
		/// Int64 startMs
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_PstartMs;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RPstartMs
		{
			get
			{
				if(r_PstartMs == null)
				{
					r_PstartMs = new(this, "startMs", -1);
				}
				return r_PstartMs;
			}
		}

		/// <summary>
		/// Int64 delayMs
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_PdelayMs;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RPdelayMs
		{
			get
			{
				if(r_PdelayMs == null)
				{
					r_PdelayMs = new(this, "delayMs", -1);
				}
				return r_PdelayMs;
			}
		}

		/// <summary>
		/// Int64 intervalMs
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_PintervalMs;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RPintervalMs
		{
			get
			{
				if(r_PintervalMs == null)
				{
					r_PintervalMs = new(this, "intervalMs", -1);
				}
				return r_PintervalMs;
			}
		}

		/// <summary>
		/// Int64 endTimeMs
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_PendTimeMs;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RPendTimeMs
		{
			get
			{
				if(r_PendTimeMs == null)
				{
					r_PendTimeMs = new(this, "endTimeMs", -1);
				}
				return r_PendTimeMs;
			}
		}

		/// <summary>
		/// Void ResetStartTime()
		/// </summary>
		protected RMethod r_MResetStartTime;
		public virtual RMethod RMResetStartTime
		{
			get
			{
				if(r_MResetStartTime == null)
				{
					r_MResetStartTime = new(this, "ResetStartTime", 0);
				}
				return r_MResetStartTime;
			}
		}

		/// <summary>
		/// Void SetDuration(Int64)
		/// </summary>
		protected RMethod r_MSetDuration_Int64;
		public virtual RMethod RMSetDuration_Int64
		{
			get
			{
				if(r_MSetDuration_Int64 == null)
				{
					r_MSetDuration_Int64 = new(this, "SetDuration", 0, typeof(System.Int64));
				}
				return r_MSetDuration_Int64;
			}
		}

		/// <summary>
		/// Void PerformTimerUpdate(UnityEngine.UIElements.TimerState)
		/// </summary>
		protected RMethod r_MPerformTimerUpdate_TimerState;
		public virtual RMethod RMPerformTimerUpdate_TimerState
		{
			get
			{
				if(r_MPerformTimerUpdate_TimerState == null)
				{
					r_MPerformTimerUpdate_TimerState = new(this, "PerformTimerUpdate", 0, typeof(UnityEngine.UIElements.TimerState));
				}
				return r_MPerformTimerUpdate_TimerState;
			}
		}

		/// <summary>
		/// Void OnItemUnscheduled()
		/// </summary>
		protected RMethod r_MOnItemUnscheduled;
		public virtual RMethod RMOnItemUnscheduled
		{
			get
			{
				if(r_MOnItemUnscheduled == null)
				{
					r_MOnItemUnscheduled = new(this, "OnItemUnscheduled", 0);
				}
				return r_MOnItemUnscheduled;
			}
		}

		/// <summary>
		/// Boolean ShouldUnschedule()
		/// </summary>
		protected RMethod r_MShouldUnschedule;
		public virtual RMethod RMShouldUnschedule
		{
			get
			{
				if(r_MShouldUnschedule == null)
				{
					r_MShouldUnschedule = new(this, "ShouldUnschedule", 0);
				}
				return r_MShouldUnschedule;
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


        public RScheduledItem() : base("UnityEngine.UIElements.ScheduledItem")
        {
        }

        public RScheduledItem(System.Object instance) : base("UnityEngine.UIElements.ScheduledItem")
		{
            SetInstance(instance);
		}

        public RScheduledItem(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RScheduledItem(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void ResetStartTime()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetStartTime.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetDuration(System.Int64 @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@durationMs};
            var ___result = RMSetDuration_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PerformTimerUpdate(UnityEngine.UIElements.TimerState @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state};
            var ___result = RMPerformTimerUpdate_TimerState.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnItemUnscheduled()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnItemUnscheduled.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ShouldUnschedule()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShouldUnschedule.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
