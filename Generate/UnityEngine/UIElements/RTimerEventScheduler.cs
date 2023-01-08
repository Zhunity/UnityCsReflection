using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.TimerEventScheduler
	/// </summary>
    public partial class RTimerEventScheduler : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.ScheduledItem] m_ScheduledItems
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RScheduledItem> r_m_ScheduledItems;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RScheduledItem> Rm_ScheduledItems
		{
			get
			{
				if(r_m_ScheduledItems == null)
				{
					r_m_ScheduledItems = new(this, "m_ScheduledItems");
					r_m_ScheduledItems.SetBelong(this.instance);
				}
				return r_m_ScheduledItems;
			}
		}

		/// <summary>
		/// System.Boolean m_TransactionMode
		/// </summary>
		protected RField r_m_TransactionMode;
		public virtual RField Rm_TransactionMode
		{
			get
			{
				if(r_m_TransactionMode == null)
				{
					r_m_TransactionMode = new(this, "m_TransactionMode");
					r_m_TransactionMode.SetBelong(this.instance);
				}
				return r_m_TransactionMode;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.ScheduledItem] m_ScheduleTransactions
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RScheduledItem> r_m_ScheduleTransactions;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RScheduledItem> Rm_ScheduleTransactions
		{
			get
			{
				if(r_m_ScheduleTransactions == null)
				{
					r_m_ScheduleTransactions = new(this, "m_ScheduleTransactions");
					r_m_ScheduleTransactions.SetBelong(this.instance);
				}
				return r_m_ScheduleTransactions;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[UnityEngine.UIElements.ScheduledItem] m_UnscheduleTransactions
		/// </summary>
		protected RSystem.RCollections.RGeneric.RHashSet<RUnityEngine.RUIElements.RScheduledItem> r_m_UnscheduleTransactions;
		public virtual RSystem.RCollections.RGeneric.RHashSet<RUnityEngine.RUIElements.RScheduledItem> Rm_UnscheduleTransactions
		{
			get
			{
				if(r_m_UnscheduleTransactions == null)
				{
					r_m_UnscheduleTransactions = new(this, "m_UnscheduleTransactions");
					r_m_UnscheduleTransactions.SetBelong(this.instance);
				}
				return r_m_UnscheduleTransactions;
			}
		}

		/// <summary>
		/// System.Boolean disableThrottling
		/// </summary>
		protected RField r_disableThrottling;
		public virtual RField RdisableThrottling
		{
			get
			{
				if(r_disableThrottling == null)
				{
					r_disableThrottling = new(this, "disableThrottling");
					r_disableThrottling.SetBelong(this.instance);
				}
				return r_disableThrottling;
			}
		}

		/// <summary>
		/// System.Int32 m_LastUpdatedIndex
		/// </summary>
		protected RField r_m_LastUpdatedIndex;
		public virtual RField Rm_LastUpdatedIndex
		{
			get
			{
				if(r_m_LastUpdatedIndex == null)
				{
					r_m_LastUpdatedIndex = new(this, "m_LastUpdatedIndex");
					r_m_LastUpdatedIndex.SetBelong(this.instance);
				}
				return r_m_LastUpdatedIndex;
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
					r_Schedule_ScheduledItem = new(this, "Schedule", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.ScheduledItem"));
					r_Schedule_ScheduledItem.SetBelong(this.instance);
				}
				return r_Schedule_ScheduledItem;
			}
		}

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
		/// Boolean RemovedScheduledItemAt(Int32)
		/// </summary>
		protected RMethod r_RemovedScheduledItemAt_Int32;
		public virtual RMethod RRemovedScheduledItemAt_Int32
		{
			get
			{
				if(r_RemovedScheduledItemAt_Int32 == null)
				{
					r_RemovedScheduledItemAt_Int32 = new(this, "RemovedScheduledItemAt", 0, typeof(System.Int32));
					r_RemovedScheduledItemAt_Int32.SetBelong(this.instance);
				}
				return r_RemovedScheduledItemAt_Int32;
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
					r_Unschedule_ScheduledItem = new(this, "Unschedule", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.ScheduledItem"));
					r_Unschedule_ScheduledItem.SetBelong(this.instance);
				}
				return r_Unschedule_ScheduledItem;
			}
		}

		/// <summary>
		/// Boolean PrivateUnSchedule(UnityEngine.UIElements.ScheduledItem)
		/// </summary>
		protected RMethod r_PrivateUnSchedule_ScheduledItem;
		public virtual RMethod RPrivateUnSchedule_ScheduledItem
		{
			get
			{
				if(r_PrivateUnSchedule_ScheduledItem == null)
				{
					r_PrivateUnSchedule_ScheduledItem = new(this, "PrivateUnSchedule", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.ScheduledItem"));
					r_PrivateUnSchedule_ScheduledItem.SetBelong(this.instance);
				}
				return r_PrivateUnSchedule_ScheduledItem;
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


        public RTimerEventScheduler() : base("UnityEngine.UIElements.TimerEventScheduler")
        {
        }

        public RTimerEventScheduler(System.Object instance) : base("UnityEngine.UIElements.TimerEventScheduler")
		{
            SetInstance(instance);
		}

        public RTimerEventScheduler(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTimerEventScheduler(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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


        public virtual System.Boolean RemovedScheduledItemAt(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RRemovedScheduledItemAt_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }




        public virtual void UpdateScheduledEvents()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateScheduledEvents.Invoke(___genericsType, ___parameters);

            
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
