using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.ScheduledItem
	/// </summary>
    public partial class RScheduledItem : RMember //
    {

		/// <summary>
		/// System.Func`1[System.Boolean] timerUpdateStopCondition
		/// </summary>
		protected RSystem.RFunc<RField> r_timerUpdateStopCondition;
		public virtual RSystem.RFunc<RField> RtimerUpdateStopCondition
		{
			get
			{
				if(r_timerUpdateStopCondition == null)
				{
					r_timerUpdateStopCondition = new(this, "timerUpdateStopCondition");
					r_timerUpdateStopCondition.SetBelong(this.instance);
				}
				return r_timerUpdateStopCondition;
			}
		}

		/// <summary>
		/// System.Func`1[System.Boolean] OnceCondition
		/// </summary>
		protected static RSystem.RFunc<RField> r_OnceCondition;
		public static RSystem.RFunc<RField> ROnceCondition
		{
			get
			{
				if(r_OnceCondition == null)
				{
					r_OnceCondition = new( ReleactionUtils.GetType("UnityEngine.UIElements.ScheduledItem"), "OnceCondition");
					r_OnceCondition.SetBelong(null);
				}
				return r_OnceCondition;
			}
		}

		/// <summary>
		/// System.Func`1[System.Boolean] ForeverCondition
		/// </summary>
		protected static RSystem.RFunc<RField> r_ForeverCondition;
		public static RSystem.RFunc<RField> RForeverCondition
		{
			get
			{
				if(r_ForeverCondition == null)
				{
					r_ForeverCondition = new( ReleactionUtils.GetType("UnityEngine.UIElements.ScheduledItem"), "ForeverCondition");
					r_ForeverCondition.SetBelong(null);
				}
				return r_ForeverCondition;
			}
		}

		/// <summary>
		/// System.Int64 <startMs>k__BackingField
		/// </summary>
		protected RField r___0__startMs__1__k__BackingField;
		public virtual RField R__0__startMs__1__k__BackingField
		{
			get
			{
				if(r___0__startMs__1__k__BackingField == null)
				{
					r___0__startMs__1__k__BackingField = new(this, "<startMs>k__BackingField");
					r___0__startMs__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__startMs__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int64 <delayMs>k__BackingField
		/// </summary>
		protected RField r___0__delayMs__1__k__BackingField;
		public virtual RField R__0__delayMs__1__k__BackingField
		{
			get
			{
				if(r___0__delayMs__1__k__BackingField == null)
				{
					r___0__delayMs__1__k__BackingField = new(this, "<delayMs>k__BackingField");
					r___0__delayMs__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__delayMs__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int64 <intervalMs>k__BackingField
		/// </summary>
		protected RField r___0__intervalMs__1__k__BackingField;
		public virtual RField R__0__intervalMs__1__k__BackingField
		{
			get
			{
				if(r___0__intervalMs__1__k__BackingField == null)
				{
					r___0__intervalMs__1__k__BackingField = new(this, "<intervalMs>k__BackingField");
					r___0__intervalMs__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__intervalMs__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int64 <endTimeMs>k__BackingField
		/// </summary>
		protected RField r___0__endTimeMs__1__k__BackingField;
		public virtual RField R__0__endTimeMs__1__k__BackingField
		{
			get
			{
				if(r___0__endTimeMs__1__k__BackingField == null)
				{
					r___0__endTimeMs__1__k__BackingField = new(this, "<endTimeMs>k__BackingField");
					r___0__endTimeMs__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__endTimeMs__1__k__BackingField;
			}
		}

		/// <summary>
		/// Int64 startMs
		/// </summary>
		protected RProperty r_startMs;
		public virtual RProperty RstartMs
		{
			get
			{
				if(r_startMs == null)
				{
					r_startMs = new(this, "startMs", -1);
					r_startMs.SetBelong(this.instance);
				}
				return r_startMs;
			}
		}

		/// <summary>
		/// Int64 delayMs
		/// </summary>
		protected RProperty r_delayMs;
		public virtual RProperty RdelayMs
		{
			get
			{
				if(r_delayMs == null)
				{
					r_delayMs = new(this, "delayMs", -1);
					r_delayMs.SetBelong(this.instance);
				}
				return r_delayMs;
			}
		}

		/// <summary>
		/// Int64 intervalMs
		/// </summary>
		protected RProperty r_intervalMs;
		public virtual RProperty RintervalMs
		{
			get
			{
				if(r_intervalMs == null)
				{
					r_intervalMs = new(this, "intervalMs", -1);
					r_intervalMs.SetBelong(this.instance);
				}
				return r_intervalMs;
			}
		}

		/// <summary>
		/// Int64 endTimeMs
		/// </summary>
		protected RProperty r_endTimeMs;
		public virtual RProperty RendTimeMs
		{
			get
			{
				if(r_endTimeMs == null)
				{
					r_endTimeMs = new(this, "endTimeMs", -1);
					r_endTimeMs.SetBelong(this.instance);
				}
				return r_endTimeMs;
			}
		}

		/// <summary>
		/// Void ResetStartTime()
		/// </summary>
		protected RMethod r_ResetStartTime;
		public virtual RMethod RResetStartTime
		{
			get
			{
				if(r_ResetStartTime == null)
				{
					r_ResetStartTime = new(this, "ResetStartTime", 0);
					r_ResetStartTime.SetBelong(this.instance);
				}
				return r_ResetStartTime;
			}
		}

		/// <summary>
		/// Void SetDuration(Int64)
		/// </summary>
		protected RMethod r_SetDuration_Int64;
		public virtual RMethod RSetDuration_Int64
		{
			get
			{
				if(r_SetDuration_Int64 == null)
				{
					r_SetDuration_Int64 = new(this, "SetDuration", 0, typeof(System.Int64));
					r_SetDuration_Int64.SetBelong(this.instance);
				}
				return r_SetDuration_Int64;
			}
		}

		/// <summary>
		/// Void PerformTimerUpdate(UnityEngine.UIElements.TimerState)
		/// </summary>
		protected RMethod r_PerformTimerUpdate_TimerState;
		public virtual RMethod RPerformTimerUpdate_TimerState
		{
			get
			{
				if(r_PerformTimerUpdate_TimerState == null)
				{
					r_PerformTimerUpdate_TimerState = new(this, "PerformTimerUpdate", 0, typeof(UnityEngine.UIElements.TimerState));
					r_PerformTimerUpdate_TimerState.SetBelong(this.instance);
				}
				return r_PerformTimerUpdate_TimerState;
			}
		}

		/// <summary>
		/// Void OnItemUnscheduled()
		/// </summary>
		protected RMethod r_OnItemUnscheduled;
		public virtual RMethod ROnItemUnscheduled
		{
			get
			{
				if(r_OnItemUnscheduled == null)
				{
					r_OnItemUnscheduled = new(this, "OnItemUnscheduled", 0);
					r_OnItemUnscheduled.SetBelong(this.instance);
				}
				return r_OnItemUnscheduled;
			}
		}

		/// <summary>
		/// Boolean ShouldUnschedule()
		/// </summary>
		protected RMethod r_ShouldUnschedule;
		public virtual RMethod RShouldUnschedule
		{
			get
			{
				if(r_ShouldUnschedule == null)
				{
					r_ShouldUnschedule = new(this, "ShouldUnschedule", 0);
					r_ShouldUnschedule.SetBelong(this.instance);
				}
				return r_ShouldUnschedule;
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
            var ___result = RResetStartTime.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetDuration(System.Int64  @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@durationMs};
            var ___result = RSetDuration_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PerformTimerUpdate(UnityEngine.UIElements.TimerState  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state};
            var ___result = RPerformTimerUpdate_TimerState.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnItemUnscheduled()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnItemUnscheduled.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ShouldUnschedule()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShouldUnschedule.Invoke(___genericsType, ___parameters);

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
