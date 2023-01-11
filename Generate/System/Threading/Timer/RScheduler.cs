using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading
{public partial class RTimer
{
	
	/// <summary>
	/// System.Threading.Timer+Scheduler
	/// </summary>
    public partial class RScheduler : RMember //
    {

		/// <summary>
		/// System.Threading.Timer+Scheduler instance
		/// </summary>
		protected static RSystem.RThreading.RTimer.RScheduler r_instance;
		public static RSystem.RThreading.RTimer.RScheduler Rinstance
		{
			get
			{
				if(r_instance == null)
				{
					r_instance = new( ReflectionUtils.GetType("System.Threading.Timer+Scheduler"), "instance");
					r_instance.SetBelong(null);
				}
				return r_instance;
			}
		}

		/// <summary>
		/// System.Boolean needReSort
		/// </summary>
		protected RSystem.RBoolean r_needReSort;
		public virtual RSystem.RBoolean RneedReSort
		{
			get
			{
				if(r_needReSort == null)
				{
					r_needReSort = new(this, "needReSort");
					r_needReSort.SetBelong(this.instance);
				}
				return r_needReSort;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Threading.Timer] list
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSystem.RThreading.RTimer> r_list;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RThreading.RTimer> Rlist
		{
			get
			{
				if(r_list == null)
				{
					r_list = new(this, "list");
					r_list.SetBelong(this.instance);
				}
				return r_list;
			}
		}

		/// <summary>
		/// System.Int64 current_next_run
		/// </summary>
		protected RSystem.RInt64 r_current_next_run;
		public virtual RSystem.RInt64 Rcurrent_next_run
		{
			get
			{
				if(r_current_next_run == null)
				{
					r_current_next_run = new(this, "current_next_run");
					r_current_next_run.SetBelong(this.instance);
				}
				return r_current_next_run;
			}
		}

		/// <summary>
		/// System.Threading.ManualResetEvent changed
		/// </summary>
		protected RSystem.RThreading.RManualResetEvent r_changed;
		public virtual RSystem.RThreading.RManualResetEvent Rchanged
		{
			get
			{
				if(r_changed == null)
				{
					r_changed = new(this, "changed");
					r_changed.SetBelong(this.instance);
				}
				return r_changed;
			}
		}

		/// <summary>
		/// Scheduler Instance
		/// </summary>
		protected static RSystem.RThreading.RTimer.RScheduler r_Instance;
		public static RSystem.RThreading.RTimer.RScheduler RInstance
		{
			get
			{
				if(r_Instance == null)
				{
					r_Instance = new( ReflectionUtils.GetType("System.Threading.Timer+Scheduler"), "Instance", -1);
					r_Instance.SetBelong(null);
				}
				return r_Instance;
			}
		}

		/// <summary>
		/// Void InitScheduler()
		/// </summary>
		protected RMethod r_InitScheduler;
		public virtual RMethod RInitScheduler
		{
			get
			{
				if(r_InitScheduler == null)
				{
					r_InitScheduler = new(this, "InitScheduler", 0);
					r_InitScheduler.SetBelong(this.instance);
				}
				return r_InitScheduler;
			}
		}

		/// <summary>
		/// Void WakeupScheduler()
		/// </summary>
		protected RMethod r_WakeupScheduler;
		public virtual RMethod RWakeupScheduler
		{
			get
			{
				if(r_WakeupScheduler == null)
				{
					r_WakeupScheduler = new(this, "WakeupScheduler", 0);
					r_WakeupScheduler.SetBelong(this.instance);
				}
				return r_WakeupScheduler;
			}
		}

		/// <summary>
		/// Void SchedulerThread()
		/// </summary>
		protected RMethod r_SchedulerThread;
		public virtual RMethod RSchedulerThread
		{
			get
			{
				if(r_SchedulerThread == null)
				{
					r_SchedulerThread = new(this, "SchedulerThread", 0);
					r_SchedulerThread.SetBelong(this.instance);
				}
				return r_SchedulerThread;
			}
		}

		/// <summary>
		/// Void Remove(System.Threading.Timer)
		/// </summary>
		protected RMethod r_Remove_Timer;
		public virtual RMethod RRemove_Timer
		{
			get
			{
				if(r_Remove_Timer == null)
				{
					r_Remove_Timer = new(this, "Remove", 0, typeof(System.Threading.Timer));
					r_Remove_Timer.SetBelong(this.instance);
				}
				return r_Remove_Timer;
			}
		}

		/// <summary>
		/// Void Change(System.Threading.Timer, Int64)
		/// </summary>
		protected RMethod r_Change_Timer_Int64;
		public virtual RMethod RChange_Timer_Int64
		{
			get
			{
				if(r_Change_Timer_Int64 == null)
				{
					r_Change_Timer_Int64 = new(this, "Change", 0, typeof(System.Threading.Timer), typeof(System.Int64));
					r_Change_Timer_Int64.SetBelong(this.instance);
				}
				return r_Change_Timer_Int64;
			}
		}

		/// <summary>
		/// Void Add(System.Threading.Timer)
		/// </summary>
		protected RMethod r_Add_Timer;
		public virtual RMethod RAdd_Timer
		{
			get
			{
				if(r_Add_Timer == null)
				{
					r_Add_Timer = new(this, "Add", 0, typeof(System.Threading.Timer));
					r_Add_Timer.SetBelong(this.instance);
				}
				return r_Add_Timer;
			}
		}

		/// <summary>
		/// Void InternalRemove(System.Threading.Timer)
		/// </summary>
		protected RMethod r_InternalRemove_Timer;
		public virtual RMethod RInternalRemove_Timer
		{
			get
			{
				if(r_InternalRemove_Timer == null)
				{
					r_InternalRemove_Timer = new(this, "InternalRemove", 0, typeof(System.Threading.Timer));
					r_InternalRemove_Timer.SetBelong(this.instance);
				}
				return r_InternalRemove_Timer;
			}
		}

		/// <summary>
		/// Void TimerCB(System.Object)
		/// </summary>
		protected static RMethod r_TimerCB_Object;
		public static RMethod RTimerCB_Object
		{
			get
			{
				if(r_TimerCB_Object == null)
				{
					r_TimerCB_Object = new( ReflectionUtils.GetType("System.Threading.Timer+Scheduler"), "TimerCB", 0, typeof(System.Object));
					r_TimerCB_Object.SetBelong(null);
				}
				return r_TimerCB_Object;
			}
		}

		/// <summary>
		/// Void FireTimer(System.Threading.Timer)
		/// </summary>
		protected RMethod r_FireTimer_Timer;
		public virtual RMethod RFireTimer_Timer
		{
			get
			{
				if(r_FireTimer_Timer == null)
				{
					r_FireTimer_Timer = new(this, "FireTimer", 0, typeof(System.Threading.Timer));
					r_FireTimer_Timer.SetBelong(this.instance);
				}
				return r_FireTimer_Timer;
			}
		}

		/// <summary>
		/// Int32 RunSchedulerLoop()
		/// </summary>
		protected RMethod r_RunSchedulerLoop;
		public virtual RMethod RRunSchedulerLoop
		{
			get
			{
				if(r_RunSchedulerLoop == null)
				{
					r_RunSchedulerLoop = new(this, "RunSchedulerLoop", 0);
					r_RunSchedulerLoop.SetBelong(this.instance);
				}
				return r_RunSchedulerLoop;
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


        public RScheduler() : base("System.Threading.Timer+Scheduler")
        {
        }

        public RScheduler(System.Object instance) : base("System.Threading.Timer+Scheduler")
		{
            SetInstance(instance);
		}

        public RScheduler(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RScheduler(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void InitScheduler()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitScheduler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WakeupScheduler()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWakeupScheduler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SchedulerThread()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSchedulerThread.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Remove(System.Threading.Timer @timer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timer};
            var ___result = RRemove_Timer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Change(System.Threading.Timer @timer, System.Int64 @new_next_run)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timer, @new_next_run};
            var ___result = RChange_Timer_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Add(System.Threading.Timer @timer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timer};
            var ___result = RAdd_Timer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalRemove(System.Threading.Timer @timer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timer};
            var ___result = RInternalRemove_Timer.Invoke(___genericsType, ___parameters);

            
        }


        public static void TimerCB(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RTimerCB_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FireTimer(System.Threading.Timer @timer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timer};
            var ___result = RFireTimer_Timer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 RunSchedulerLoop()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRunSchedulerLoop.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
}