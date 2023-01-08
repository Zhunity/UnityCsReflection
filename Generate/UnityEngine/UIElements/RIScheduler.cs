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
		protected RMethod r_ScheduleOnce_Action_d_TimerState_p__Int64;
		public virtual RMethod RScheduleOnce_Action_d_TimerState_p__Int64
		{
			get
			{
				if(r_ScheduleOnce_Action_d_TimerState_p__Int64 == null)
				{
					r_ScheduleOnce_Action_d_TimerState_p__Int64 = new(this, "ScheduleOnce", 0, typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.UIElements.TimerState)), typeof(System.Int64));
					r_ScheduleOnce_Action_d_TimerState_p__Int64.SetBelong(this.instance);
				}
				return r_ScheduleOnce_Action_d_TimerState_p__Int64;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ScheduledItem ScheduleUntil(System.Action`1[UnityEngine.UIElements.TimerState], Int64, Int64, System.Func`1[System.Boolean])
		/// </summary>
		protected RMethod r_ScheduleUntil_Action_d_TimerState_p__Int64_Int64_Func_d_Boolean_p_;
		public virtual RMethod RScheduleUntil_Action_d_TimerState_p__Int64_Int64_Func_d_Boolean_p_
		{
			get
			{
				if(r_ScheduleUntil_Action_d_TimerState_p__Int64_Int64_Func_d_Boolean_p_ == null)
				{
					r_ScheduleUntil_Action_d_TimerState_p__Int64_Int64_Func_d_Boolean_p_ = new(this, "ScheduleUntil", 0, typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.UIElements.TimerState)), typeof(System.Int64), typeof(System.Int64), typeof(System.Func<>).MakeGenericType(typeof(System.Boolean)));
					r_ScheduleUntil_Action_d_TimerState_p__Int64_Int64_Func_d_Boolean_p_.SetBelong(this.instance);
				}
				return r_ScheduleUntil_Action_d_TimerState_p__Int64_Int64_Func_d_Boolean_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ScheduledItem ScheduleForDuration(System.Action`1[UnityEngine.UIElements.TimerState], Int64, Int64, Int64)
		/// </summary>
		protected RMethod r_ScheduleForDuration_Action_d_TimerState_p__Int64_Int64_Int64;
		public virtual RMethod RScheduleForDuration_Action_d_TimerState_p__Int64_Int64_Int64
		{
			get
			{
				if(r_ScheduleForDuration_Action_d_TimerState_p__Int64_Int64_Int64 == null)
				{
					r_ScheduleForDuration_Action_d_TimerState_p__Int64_Int64_Int64 = new(this, "ScheduleForDuration", 0, typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.UIElements.TimerState)), typeof(System.Int64), typeof(System.Int64), typeof(System.Int64));
					r_ScheduleForDuration_Action_d_TimerState_p__Int64_Int64_Int64.SetBelong(this.instance);
				}
				return r_ScheduleForDuration_Action_d_TimerState_p__Int64_Int64_Int64;
			}
		}

		/// <summary>
		/// Void Unschedule(UnityEngine.UIElements.ScheduledItem)
		/// </summary>
		protected RMethod r_Unschedule_ScheduledItem;
		public virtual RMethod RUnschedule_ScheduledItem
		{
			get
			{
				if(r_Unschedule_ScheduledItem == null)
				{
					r_Unschedule_ScheduledItem = new(this, "Unschedule", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.ScheduledItem"));
					r_Unschedule_ScheduledItem.SetBelong(this.instance);
				}
				return r_Unschedule_ScheduledItem;
			}
		}

		/// <summary>
		/// Void Schedule(UnityEngine.UIElements.ScheduledItem)
		/// </summary>
		protected RMethod r_Schedule_ScheduledItem;
		public virtual RMethod RSchedule_ScheduledItem
		{
			get
			{
				if(r_Schedule_ScheduledItem == null)
				{
					r_Schedule_ScheduledItem = new(this, "Schedule", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.ScheduledItem"));
					r_Schedule_ScheduledItem.SetBelong(this.instance);
				}
				return r_Schedule_ScheduledItem;
			}
		}

		/// <summary>
		/// Void UpdateScheduledEvents()
		/// </summary>
		protected RMethod r_UpdateScheduledEvents;
		public virtual RMethod RUpdateScheduledEvents
		{
			get
			{
				if(r_UpdateScheduledEvents == null)
				{
					r_UpdateScheduledEvents = new(this, "UpdateScheduledEvents", 0);
					r_UpdateScheduledEvents.SetBelong(this.instance);
				}
				return r_UpdateScheduledEvents;
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

        public virtual RUnityEngine.RUIElements.RScheduledItem ScheduleOnce(System.Action<UnityEngine.UIElements.TimerState> @timerUpdateEvent, System.Int64 @delayMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timerUpdateEvent, @delayMs};
            var ___result = RScheduleOnce_Action_d_TimerState_p__Int64.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RScheduledItem(___result);
        }


        public virtual RUnityEngine.RUIElements.RScheduledItem ScheduleUntil(System.Action<UnityEngine.UIElements.TimerState> @timerUpdateEvent, System.Int64 @delayMs, System.Int64 @intervalMs, System.Func<System.Boolean> @stopCondition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timerUpdateEvent, @delayMs, @intervalMs, @stopCondition};
            var ___result = RScheduleUntil_Action_d_TimerState_p__Int64_Int64_Func_d_Boolean_p_.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RScheduledItem(___result);
        }


        public virtual RUnityEngine.RUIElements.RScheduledItem ScheduleForDuration(System.Action<UnityEngine.UIElements.TimerState> @timerUpdateEvent, System.Int64 @delayMs, System.Int64 @intervalMs, System.Int64 @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timerUpdateEvent, @delayMs, @intervalMs, @durationMs};
            var ___result = RScheduleForDuration_Action_d_TimerState_p__Int64_Int64_Int64.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RScheduledItem(___result);
        }


        public virtual void Unschedule(RUnityEngine.RUIElements.RScheduledItem @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item.Value};
            var ___result = RUnschedule_ScheduledItem.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Schedule(RUnityEngine.RUIElements.RScheduledItem @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item.Value};
            var ___result = RSchedule_ScheduledItem.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateScheduledEvents()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateScheduledEvents.Invoke(___genericsType, ___parameters);

            
        }


    }
}
