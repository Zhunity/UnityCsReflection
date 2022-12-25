using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.IScheduler
	/// </summary>
    public partial class RIScheduler : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.ScheduledItem ScheduleOnce(System.Action`1[UnityEngine.UIElements.TimerState], Int64)
		/// </summary>
		protected RMethod r_RScheduleOnce_Action_d_TimerState_p__Int64;
		public virtual RMethod RScheduleOnce_Action_d_TimerState_p__Int64
		{
			get
			{
				if(r_RScheduleOnce_Action_d_TimerState_p__Int64 == null)
				{
					r_RScheduleOnce_Action_d_TimerState_p__Int64 = new(this, "ScheduleOnce", 0, typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.UIElements.TimerState)), typeof(System.Int64));
					r_RScheduleOnce_Action_d_TimerState_p__Int64.SetBelong(this.instance);
				}
				return r_RScheduleOnce_Action_d_TimerState_p__Int64;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ScheduledItem ScheduleUntil(System.Action`1[UnityEngine.UIElements.TimerState], Int64, Int64, System.Func`1[System.Boolean])
		/// </summary>
		protected RMethod r_RScheduleUntil_Action_d_TimerState_p__Int64_Int64_Func_d_Boolean_p_;
		public virtual RMethod RScheduleUntil_Action_d_TimerState_p__Int64_Int64_Func_d_Boolean_p_
		{
			get
			{
				if(r_RScheduleUntil_Action_d_TimerState_p__Int64_Int64_Func_d_Boolean_p_ == null)
				{
					r_RScheduleUntil_Action_d_TimerState_p__Int64_Int64_Func_d_Boolean_p_ = new(this, "ScheduleUntil", 0, typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.UIElements.TimerState)), typeof(System.Int64), typeof(System.Int64), typeof(System.Func<>).MakeGenericType(typeof(System.Boolean)));
					r_RScheduleUntil_Action_d_TimerState_p__Int64_Int64_Func_d_Boolean_p_.SetBelong(this.instance);
				}
				return r_RScheduleUntil_Action_d_TimerState_p__Int64_Int64_Func_d_Boolean_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ScheduledItem ScheduleForDuration(System.Action`1[UnityEngine.UIElements.TimerState], Int64, Int64, Int64)
		/// </summary>
		protected RMethod r_RScheduleForDuration_Action_d_TimerState_p__Int64_Int64_Int64;
		public virtual RMethod RScheduleForDuration_Action_d_TimerState_p__Int64_Int64_Int64
		{
			get
			{
				if(r_RScheduleForDuration_Action_d_TimerState_p__Int64_Int64_Int64 == null)
				{
					r_RScheduleForDuration_Action_d_TimerState_p__Int64_Int64_Int64 = new(this, "ScheduleForDuration", 0, typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.UIElements.TimerState)), typeof(System.Int64), typeof(System.Int64), typeof(System.Int64));
					r_RScheduleForDuration_Action_d_TimerState_p__Int64_Int64_Int64.SetBelong(this.instance);
				}
				return r_RScheduleForDuration_Action_d_TimerState_p__Int64_Int64_Int64;
			}
		}

		/// <summary>
		/// Void Unschedule(UnityEngine.UIElements.ScheduledItem)
		/// </summary>
		protected RMethod r_RUnschedule_ScheduledItem;
		public virtual RMethod RUnschedule_ScheduledItem
		{
			get
			{
				if(r_RUnschedule_ScheduledItem == null)
				{
					r_RUnschedule_ScheduledItem = new(this, "Unschedule", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.ScheduledItem"));
					r_RUnschedule_ScheduledItem.SetBelong(this.instance);
				}
				return r_RUnschedule_ScheduledItem;
			}
		}

		/// <summary>
		/// Void Schedule(UnityEngine.UIElements.ScheduledItem)
		/// </summary>
		protected RMethod r_RSchedule_ScheduledItem;
		public virtual RMethod RSchedule_ScheduledItem
		{
			get
			{
				if(r_RSchedule_ScheduledItem == null)
				{
					r_RSchedule_ScheduledItem = new(this, "Schedule", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.ScheduledItem"));
					r_RSchedule_ScheduledItem.SetBelong(this.instance);
				}
				return r_RSchedule_ScheduledItem;
			}
		}

		/// <summary>
		/// Void UpdateScheduledEvents()
		/// </summary>
		protected RMethod r_RUpdateScheduledEvents;
		public virtual RMethod RUpdateScheduledEvents
		{
			get
			{
				if(r_RUpdateScheduledEvents == null)
				{
					r_RUpdateScheduledEvents = new(this, "UpdateScheduledEvents", 0);
					r_RUpdateScheduledEvents.SetBelong(this.instance);
				}
				return r_RUpdateScheduledEvents;
			}
		}


        public RIScheduler() : base("UnityEngine.UIElements.IScheduler")
        {
        }

        public RIScheduler(System.Object instance) : base("UnityEngine.UIElements.IScheduler")
		{
            SetInstance(instance);
		}

        public RIScheduler(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIScheduler(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object ScheduleOnce(System.Action<UnityEngine.UIElements.TimerState>  @timerUpdateEvent, System.Int64  @delayMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timerUpdateEvent, @delayMs};
            var ___result = RScheduleOnce_Action_d_TimerState_p__Int64.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object ScheduleUntil(System.Action<UnityEngine.UIElements.TimerState>  @timerUpdateEvent, System.Int64  @delayMs, System.Int64  @intervalMs, System.Func<System.Boolean>  @stopCondition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timerUpdateEvent, @delayMs, @intervalMs, @stopCondition};
            var ___result = RScheduleUntil_Action_d_TimerState_p__Int64_Int64_Func_d_Boolean_p_.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object ScheduleForDuration(System.Action<UnityEngine.UIElements.TimerState>  @timerUpdateEvent, System.Int64  @delayMs, System.Int64  @intervalMs, System.Int64  @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timerUpdateEvent, @delayMs, @intervalMs, @durationMs};
            var ___result = RScheduleForDuration_Action_d_TimerState_p__Int64_Int64_Int64.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }




        public virtual void UpdateScheduledEvents()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateScheduledEvents.Invoke(___genericsType, ___parameters);

            
        }


    }
}
