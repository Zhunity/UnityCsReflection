
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RThreading
{public partial class RTimer
{
	
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.Threading.Timer+Scheduler
	/// </summary>
    public partial class RScheduler : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Threading.Timer+Scheduler");
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


		/// <summary>
		/// System.Threading.Timer+Scheduler instance
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RTimer.RScheduler r_Finstance;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RTimer.RScheduler RFinstance
		{
			get
			{
				if(r_Finstance == null)
				{
					r_Finstance = new(Type, "instance");
				}
				return r_Finstance;
			}
		}

		/// <summary>
		/// System.Boolean needReSort
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FneedReSort;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFneedReSort
		{
			get
			{
				if(r_FneedReSort == null)
				{
					r_FneedReSort = new(this, "needReSort");
				}
				return r_FneedReSort;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Threading.Timer] list
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RThreading.RTimer> r_Flist;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RThreading.RTimer> RFlist
		{
			get
			{
				if(r_Flist == null)
				{
					r_Flist = new(this, "list");
				}
				return r_Flist;
			}
		}

		/// <summary>
		/// System.Int64 current_next_run
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_Fcurrent_next_run;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RFcurrent_next_run
		{
			get
			{
				if(r_Fcurrent_next_run == null)
				{
					r_Fcurrent_next_run = new(this, "current_next_run");
				}
				return r_Fcurrent_next_run;
			}
		}

		/// <summary>
		/// System.Threading.ManualResetEvent changed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RManualResetEvent r_Fchanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RManualResetEvent RFchanged
		{
			get
			{
				if(r_Fchanged == null)
				{
					r_Fchanged = new(this, "changed");
				}
				return r_Fchanged;
			}
		}

		/// <summary>
		/// Scheduler Instance
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RTimer.RScheduler r_PInstance;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RTimer.RScheduler RPInstance
		{
			get
			{
				if(r_PInstance == null)
				{
					r_PInstance = new(Type, "Instance", -1);
				}
				return r_PInstance;
			}
		}

		/// <summary>
		/// Void InitScheduler()
		/// </summary>
		protected RMethod r_MInitScheduler;
		public virtual RMethod RMInitScheduler
		{
			get
			{
				if(r_MInitScheduler == null)
				{
					r_MInitScheduler = new(this, "InitScheduler", 0);
				}
				return r_MInitScheduler;
			}
		}

		/// <summary>
		/// Void WakeupScheduler()
		/// </summary>
		protected RMethod r_MWakeupScheduler;
		public virtual RMethod RMWakeupScheduler
		{
			get
			{
				if(r_MWakeupScheduler == null)
				{
					r_MWakeupScheduler = new(this, "WakeupScheduler", 0);
				}
				return r_MWakeupScheduler;
			}
		}

		/// <summary>
		/// Void SchedulerThread()
		/// </summary>
		protected RMethod r_MSchedulerThread;
		public virtual RMethod RMSchedulerThread
		{
			get
			{
				if(r_MSchedulerThread == null)
				{
					r_MSchedulerThread = new(this, "SchedulerThread", 0);
				}
				return r_MSchedulerThread;
			}
		}

		/// <summary>
		/// Void Remove(System.Threading.Timer)
		/// </summary>
		protected RMethod r_MRemove_Timer;
		public virtual RMethod RMRemove_Timer
		{
			get
			{
				if(r_MRemove_Timer == null)
				{
					r_MRemove_Timer = new(this, "Remove", 0, typeof(System.Threading.Timer));
				}
				return r_MRemove_Timer;
			}
		}

		/// <summary>
		/// Void Change(System.Threading.Timer, Int64)
		/// </summary>
		protected RMethod r_MChange_Timer_Int64;
		public virtual RMethod RMChange_Timer_Int64
		{
			get
			{
				if(r_MChange_Timer_Int64 == null)
				{
					r_MChange_Timer_Int64 = new(this, "Change", 0, typeof(System.Threading.Timer), typeof(System.Int64));
				}
				return r_MChange_Timer_Int64;
			}
		}

		/// <summary>
		/// Void Add(System.Threading.Timer)
		/// </summary>
		protected RMethod r_MAdd_Timer;
		public virtual RMethod RMAdd_Timer
		{
			get
			{
				if(r_MAdd_Timer == null)
				{
					r_MAdd_Timer = new(this, "Add", 0, typeof(System.Threading.Timer));
				}
				return r_MAdd_Timer;
			}
		}

		/// <summary>
		/// Void InternalRemove(System.Threading.Timer)
		/// </summary>
		protected RMethod r_MInternalRemove_Timer;
		public virtual RMethod RMInternalRemove_Timer
		{
			get
			{
				if(r_MInternalRemove_Timer == null)
				{
					r_MInternalRemove_Timer = new(this, "InternalRemove", 0, typeof(System.Threading.Timer));
				}
				return r_MInternalRemove_Timer;
			}
		}

		/// <summary>
		/// Void TimerCB(System.Object)
		/// </summary>
		protected static RMethod r_MTimerCB_Object;
		public static RMethod RMTimerCB_Object
		{
			get
			{
				if(r_MTimerCB_Object == null)
				{
					r_MTimerCB_Object = new(Type, "TimerCB", 0, typeof(System.Object));
				}
				return r_MTimerCB_Object;
			}
		}

		/// <summary>
		/// Void FireTimer(System.Threading.Timer)
		/// </summary>
		protected RMethod r_MFireTimer_Timer;
		public virtual RMethod RMFireTimer_Timer
		{
			get
			{
				if(r_MFireTimer_Timer == null)
				{
					r_MFireTimer_Timer = new(this, "FireTimer", 0, typeof(System.Threading.Timer));
				}
				return r_MFireTimer_Timer;
			}
		}

		/// <summary>
		/// Int32 RunSchedulerLoop()
		/// </summary>
		protected RMethod r_MRunSchedulerLoop;
		public virtual RMethod RMRunSchedulerLoop
		{
			get
			{
				if(r_MRunSchedulerLoop == null)
				{
					r_MRunSchedulerLoop = new(this, "RunSchedulerLoop", 0);
				}
				return r_MRunSchedulerLoop;
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


        public virtual void InitScheduler()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitScheduler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WakeupScheduler()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMWakeupScheduler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SchedulerThread()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSchedulerThread.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Remove(System.Threading.Timer @timer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timer};
            var ___result = RMRemove_Timer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Change(System.Threading.Timer @timer, System.Int64 @new_next_run)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timer, @new_next_run};
            var ___result = RMChange_Timer_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Add(System.Threading.Timer @timer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timer};
            var ___result = RMAdd_Timer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalRemove(System.Threading.Timer @timer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timer};
            var ___result = RMInternalRemove_Timer.Invoke(___genericsType, ___parameters);

            
        }


        public static void TimerCB(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMTimerCB_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FireTimer(System.Threading.Timer @timer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timer};
            var ___result = RMFireTimer_Timer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 RunSchedulerLoop()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRunSchedulerLoop.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
}