
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.TimerEventScheduler
	/// </summary>
    public partial class RTimerEventScheduler : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.ScheduledItem] m_ScheduledItems
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RScheduledItem> r_Fm_ScheduledItems;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RScheduledItem> RFm_ScheduledItems
		{
			get
			{
				if(r_Fm_ScheduledItems == null)
				{
					r_Fm_ScheduledItems = new(this, "m_ScheduledItems");
					r_Fm_ScheduledItems.SetBelong(this.instance);
				}
				return r_Fm_ScheduledItems;
			}
		}

		/// <summary>
		/// System.Boolean m_TransactionMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_TransactionMode;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_TransactionMode
		{
			get
			{
				if(r_Fm_TransactionMode == null)
				{
					r_Fm_TransactionMode = new(this, "m_TransactionMode");
					r_Fm_TransactionMode.SetBelong(this.instance);
				}
				return r_Fm_TransactionMode;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.ScheduledItem] m_ScheduleTransactions
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RScheduledItem> r_Fm_ScheduleTransactions;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RScheduledItem> RFm_ScheduleTransactions
		{
			get
			{
				if(r_Fm_ScheduleTransactions == null)
				{
					r_Fm_ScheduleTransactions = new(this, "m_ScheduleTransactions");
					r_Fm_ScheduleTransactions.SetBelong(this.instance);
				}
				return r_Fm_ScheduleTransactions;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[UnityEngine.UIElements.ScheduledItem] m_UnscheduleTransactions
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RScheduledItem> r_Fm_UnscheduleTransactions;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RScheduledItem> RFm_UnscheduleTransactions
		{
			get
			{
				if(r_Fm_UnscheduleTransactions == null)
				{
					r_Fm_UnscheduleTransactions = new(this, "m_UnscheduleTransactions");
					r_Fm_UnscheduleTransactions.SetBelong(this.instance);
				}
				return r_Fm_UnscheduleTransactions;
			}
		}

		/// <summary>
		/// System.Boolean disableThrottling
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FdisableThrottling;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFdisableThrottling
		{
			get
			{
				if(r_FdisableThrottling == null)
				{
					r_FdisableThrottling = new(this, "disableThrottling");
					r_FdisableThrottling.SetBelong(this.instance);
				}
				return r_FdisableThrottling;
			}
		}

		/// <summary>
		/// System.Int32 m_LastUpdatedIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_LastUpdatedIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_LastUpdatedIndex
		{
			get
			{
				if(r_Fm_LastUpdatedIndex == null)
				{
					r_Fm_LastUpdatedIndex = new(this, "m_LastUpdatedIndex");
					r_Fm_LastUpdatedIndex.SetBelong(this.instance);
				}
				return r_Fm_LastUpdatedIndex;
			}
		}

		/// <summary>
		/// Void Schedule(UnityEngine.UIElements.ScheduledItem)
		/// </summary>
		protected RMethod r_MSchedule_ScheduledItem;
		public virtual RMethod RMSchedule_ScheduledItem
		{
			get
			{
				if(r_MSchedule_ScheduledItem == null)
				{
					r_MSchedule_ScheduledItem = new(this, "Schedule", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.ScheduledItem"));
					r_MSchedule_ScheduledItem.SetBelong(this.instance);
				}
				return r_MSchedule_ScheduledItem;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ScheduledItem ScheduleOnce(System.Action`1[UnityEngine.UIElements.TimerState], Int64)
		/// </summary>
		protected RMethod r_MScheduleOnce_Action_d_TimerState_p__Int64;
		public virtual RMethod RMScheduleOnce_Action_d_TimerState_p__Int64
		{
			get
			{
				if(r_MScheduleOnce_Action_d_TimerState_p__Int64 == null)
				{
					r_MScheduleOnce_Action_d_TimerState_p__Int64 = new(this, "ScheduleOnce", 0, typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.UIElements.TimerState)), typeof(System.Int64));
					r_MScheduleOnce_Action_d_TimerState_p__Int64.SetBelong(this.instance);
				}
				return r_MScheduleOnce_Action_d_TimerState_p__Int64;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ScheduledItem ScheduleUntil(System.Action`1[UnityEngine.UIElements.TimerState], Int64, Int64, System.Func`1[System.Boolean])
		/// </summary>
		protected RMethod r_MScheduleUntil_Action_d_TimerState_p__Int64_Int64_Func_d_Boolean_p_;
		public virtual RMethod RMScheduleUntil_Action_d_TimerState_p__Int64_Int64_Func_d_Boolean_p_
		{
			get
			{
				if(r_MScheduleUntil_Action_d_TimerState_p__Int64_Int64_Func_d_Boolean_p_ == null)
				{
					r_MScheduleUntil_Action_d_TimerState_p__Int64_Int64_Func_d_Boolean_p_ = new(this, "ScheduleUntil", 0, typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.UIElements.TimerState)), typeof(System.Int64), typeof(System.Int64), typeof(System.Func<>).MakeGenericType(typeof(System.Boolean)));
					r_MScheduleUntil_Action_d_TimerState_p__Int64_Int64_Func_d_Boolean_p_.SetBelong(this.instance);
				}
				return r_MScheduleUntil_Action_d_TimerState_p__Int64_Int64_Func_d_Boolean_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ScheduledItem ScheduleForDuration(System.Action`1[UnityEngine.UIElements.TimerState], Int64, Int64, Int64)
		/// </summary>
		protected RMethod r_MScheduleForDuration_Action_d_TimerState_p__Int64_Int64_Int64;
		public virtual RMethod RMScheduleForDuration_Action_d_TimerState_p__Int64_Int64_Int64
		{
			get
			{
				if(r_MScheduleForDuration_Action_d_TimerState_p__Int64_Int64_Int64 == null)
				{
					r_MScheduleForDuration_Action_d_TimerState_p__Int64_Int64_Int64 = new(this, "ScheduleForDuration", 0, typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.UIElements.TimerState)), typeof(System.Int64), typeof(System.Int64), typeof(System.Int64));
					r_MScheduleForDuration_Action_d_TimerState_p__Int64_Int64_Int64.SetBelong(this.instance);
				}
				return r_MScheduleForDuration_Action_d_TimerState_p__Int64_Int64_Int64;
			}
		}

		/// <summary>
		/// Boolean RemovedScheduledItemAt(Int32)
		/// </summary>
		protected RMethod r_MRemovedScheduledItemAt_Int32;
		public virtual RMethod RMRemovedScheduledItemAt_Int32
		{
			get
			{
				if(r_MRemovedScheduledItemAt_Int32 == null)
				{
					r_MRemovedScheduledItemAt_Int32 = new(this, "RemovedScheduledItemAt", 0, typeof(System.Int32));
					r_MRemovedScheduledItemAt_Int32.SetBelong(this.instance);
				}
				return r_MRemovedScheduledItemAt_Int32;
			}
		}

		/// <summary>
		/// Void Unschedule(UnityEngine.UIElements.ScheduledItem)
		/// </summary>
		protected RMethod r_MUnschedule_ScheduledItem;
		public virtual RMethod RMUnschedule_ScheduledItem
		{
			get
			{
				if(r_MUnschedule_ScheduledItem == null)
				{
					r_MUnschedule_ScheduledItem = new(this, "Unschedule", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.ScheduledItem"));
					r_MUnschedule_ScheduledItem.SetBelong(this.instance);
				}
				return r_MUnschedule_ScheduledItem;
			}
		}

		/// <summary>
		/// Boolean PrivateUnSchedule(UnityEngine.UIElements.ScheduledItem)
		/// </summary>
		protected RMethod r_MPrivateUnSchedule_ScheduledItem;
		public virtual RMethod RMPrivateUnSchedule_ScheduledItem
		{
			get
			{
				if(r_MPrivateUnSchedule_ScheduledItem == null)
				{
					r_MPrivateUnSchedule_ScheduledItem = new(this, "PrivateUnSchedule", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.ScheduledItem"));
					r_MPrivateUnSchedule_ScheduledItem.SetBelong(this.instance);
				}
				return r_MPrivateUnSchedule_ScheduledItem;
			}
		}

		/// <summary>
		/// Void UpdateScheduledEvents()
		/// </summary>
		protected RMethod r_MUpdateScheduledEvents;
		public virtual RMethod RMUpdateScheduledEvents
		{
			get
			{
				if(r_MUpdateScheduledEvents == null)
				{
					r_MUpdateScheduledEvents = new(this, "UpdateScheduledEvents", 0);
					r_MUpdateScheduledEvents.SetBelong(this.instance);
				}
				return r_MUpdateScheduledEvents;
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

        public virtual void Schedule(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RScheduledItem @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item.Value};
            var ___result = RMSchedule_ScheduledItem.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RScheduledItem ScheduleOnce(System.Action<UnityEngine.UIElements.TimerState> @timerUpdateEvent, System.Int64 @delayMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timerUpdateEvent, @delayMs};
            var ___result = RMScheduleOnce_Action_d_TimerState_p__Int64.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RScheduledItem(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RScheduledItem ScheduleUntil(System.Action<UnityEngine.UIElements.TimerState> @timerUpdateEvent, System.Int64 @delayMs, System.Int64 @intervalMs, System.Func<System.Boolean> @stopCondition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timerUpdateEvent, @delayMs, @intervalMs, @stopCondition};
            var ___result = RMScheduleUntil_Action_d_TimerState_p__Int64_Int64_Func_d_Boolean_p_.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RScheduledItem(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RScheduledItem ScheduleForDuration(System.Action<UnityEngine.UIElements.TimerState> @timerUpdateEvent, System.Int64 @delayMs, System.Int64 @intervalMs, System.Int64 @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timerUpdateEvent, @delayMs, @intervalMs, @durationMs};
            var ___result = RMScheduleForDuration_Action_d_TimerState_p__Int64_Int64_Int64.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RScheduledItem(___result);
        }


        public virtual System.Boolean RemovedScheduledItemAt(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMRemovedScheduledItemAt_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Unschedule(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RScheduledItem @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item.Value};
            var ___result = RMUnschedule_ScheduledItem.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean PrivateUnSchedule(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RScheduledItem @sItem)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sItem.Value};
            var ___result = RMPrivateUnSchedule_ScheduledItem.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void UpdateScheduledEvents()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateScheduledEvents.Invoke(___genericsType, ___parameters);

            
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
