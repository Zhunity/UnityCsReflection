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
					r_instance = new( ReleactionUtils.GetType("System.Threading.Timer+Scheduler"), "instance");
					r_instance.SetBelong(null);
				}
				return r_instance;
			}
		}

		/// <summary>
		/// System.Boolean needReSort
		/// </summary>
		protected RField r_needReSort;
		public virtual RField RneedReSort
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
		protected RField r_current_next_run;
		public virtual RField Rcurrent_next_run
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
					r_Instance = new( ReleactionUtils.GetType("System.Threading.Timer+Scheduler"), "Instance", -1);
					r_Instance.SetBelong(null);
				}
				return r_Instance;
			}
		}

		/// <summary>
		/// Void InitScheduler()
		/// </summary>
		protected RMethod r_RInitScheduler;
		public virtual RMethod RInitScheduler
		{
			get
			{
				if(r_RInitScheduler == null)
				{
					r_RInitScheduler = new(this, "InitScheduler", 0);
					r_RInitScheduler.SetBelong(this.instance);
				}
				return r_RInitScheduler;
			}
		}

		/// <summary>
		/// Void WakeupScheduler()
		/// </summary>
		protected RMethod r_RWakeupScheduler;
		public virtual RMethod RWakeupScheduler
		{
			get
			{
				if(r_RWakeupScheduler == null)
				{
					r_RWakeupScheduler = new(this, "WakeupScheduler", 0);
					r_RWakeupScheduler.SetBelong(this.instance);
				}
				return r_RWakeupScheduler;
			}
		}

		/// <summary>
		/// Void SchedulerThread()
		/// </summary>
		protected RMethod r_RSchedulerThread;
		public virtual RMethod RSchedulerThread
		{
			get
			{
				if(r_RSchedulerThread == null)
				{
					r_RSchedulerThread = new(this, "SchedulerThread", 0);
					r_RSchedulerThread.SetBelong(this.instance);
				}
				return r_RSchedulerThread;
			}
		}

		/// <summary>
		/// Void Remove(System.Threading.Timer)
		/// </summary>
		protected RMethod r_RRemove_Timer;
		public virtual RMethod RRemove_Timer
		{
			get
			{
				if(r_RRemove_Timer == null)
				{
					r_RRemove_Timer = new(this, "Remove", 0, typeof(System.Threading.Timer));
					r_RRemove_Timer.SetBelong(this.instance);
				}
				return r_RRemove_Timer;
			}
		}

		/// <summary>
		/// Void Change(System.Threading.Timer, Int64)
		/// </summary>
		protected RMethod r_RChange_Timer_Int64;
		public virtual RMethod RChange_Timer_Int64
		{
			get
			{
				if(r_RChange_Timer_Int64 == null)
				{
					r_RChange_Timer_Int64 = new(this, "Change", 0, typeof(System.Threading.Timer), typeof(System.Int64));
					r_RChange_Timer_Int64.SetBelong(this.instance);
				}
				return r_RChange_Timer_Int64;
			}
		}

		/// <summary>
		/// Void Add(System.Threading.Timer)
		/// </summary>
		protected RMethod r_RAdd_Timer;
		public virtual RMethod RAdd_Timer
		{
			get
			{
				if(r_RAdd_Timer == null)
				{
					r_RAdd_Timer = new(this, "Add", 0, typeof(System.Threading.Timer));
					r_RAdd_Timer.SetBelong(this.instance);
				}
				return r_RAdd_Timer;
			}
		}

		/// <summary>
		/// Void InternalRemove(System.Threading.Timer)
		/// </summary>
		protected RMethod r_RInternalRemove_Timer;
		public virtual RMethod RInternalRemove_Timer
		{
			get
			{
				if(r_RInternalRemove_Timer == null)
				{
					r_RInternalRemove_Timer = new(this, "InternalRemove", 0, typeof(System.Threading.Timer));
					r_RInternalRemove_Timer.SetBelong(this.instance);
				}
				return r_RInternalRemove_Timer;
			}
		}

		/// <summary>
		/// Void TimerCB(System.Object)
		/// </summary>
		protected static RMethod r_RTimerCB_Object;
		public static RMethod RTimerCB_Object
		{
			get
			{
				if(r_RTimerCB_Object == null)
				{
					r_RTimerCB_Object = new( ReleactionUtils.GetType("System.Threading.Timer+Scheduler"), "TimerCB", 0, typeof(System.Object));
					r_RTimerCB_Object.SetBelong(null);
				}
				return r_RTimerCB_Object;
			}
		}

		/// <summary>
		/// Void FireTimer(System.Threading.Timer)
		/// </summary>
		protected RMethod r_RFireTimer_Timer;
		public virtual RMethod RFireTimer_Timer
		{
			get
			{
				if(r_RFireTimer_Timer == null)
				{
					r_RFireTimer_Timer = new(this, "FireTimer", 0, typeof(System.Threading.Timer));
					r_RFireTimer_Timer.SetBelong(this.instance);
				}
				return r_RFireTimer_Timer;
			}
		}

		/// <summary>
		/// Int32 RunSchedulerLoop()
		/// </summary>
		protected RMethod r_RRunSchedulerLoop;
		public virtual RMethod RRunSchedulerLoop
		{
			get
			{
				if(r_RRunSchedulerLoop == null)
				{
					r_RRunSchedulerLoop = new(this, "RunSchedulerLoop", 0);
					r_RRunSchedulerLoop.SetBelong(this.instance);
				}
				return r_RRunSchedulerLoop;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
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


        public virtual void Remove(System.Threading.Timer  @timer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timer};
            var ___result = RRemove_Timer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Change(System.Threading.Timer  @timer, System.Int64  @new_next_run)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timer, @new_next_run};
            var ___result = RChange_Timer_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Add(System.Threading.Timer  @timer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timer};
            var ___result = RAdd_Timer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalRemove(System.Threading.Timer  @timer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timer};
            var ___result = RInternalRemove_Timer.Invoke(___genericsType, ___parameters);

            
        }


        public static void TimerCB(System.Object  @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RTimerCB_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FireTimer(System.Threading.Timer  @timer)
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
}