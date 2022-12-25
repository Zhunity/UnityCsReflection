using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks
{
	/// <summary>
	/// System.Threading.Tasks.TaskScheduler
	/// </summary>
    public partial class RTaskScheduler : RMember //
    {

		/// <summary>
		/// System.Runtime.CompilerServices.ConditionalWeakTable`2[System.Threading.Tasks.TaskScheduler,System.Object] s_activeTaskSchedulers
		/// </summary>
		protected static RSystem.RRuntime.RCompilerServices.RConditionalWeakTable<RSystem.RThreading.RTasks.RTaskScheduler, RSystem.RObject> r_s_activeTaskSchedulers;
		public static RSystem.RRuntime.RCompilerServices.RConditionalWeakTable<RSystem.RThreading.RTasks.RTaskScheduler, RSystem.RObject> Rs_activeTaskSchedulers
		{
			get
			{
				if(r_s_activeTaskSchedulers == null)
				{
					r_s_activeTaskSchedulers = new(typeof(System.Threading.Tasks.TaskScheduler), "s_activeTaskSchedulers");
					r_s_activeTaskSchedulers.SetBelong(null);
				}
				return r_s_activeTaskSchedulers;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskScheduler s_defaultTaskScheduler
		/// </summary>
		protected static RSystem.RThreading.RTasks.RTaskScheduler r_s_defaultTaskScheduler;
		public static RSystem.RThreading.RTasks.RTaskScheduler Rs_defaultTaskScheduler
		{
			get
			{
				if(r_s_defaultTaskScheduler == null)
				{
					r_s_defaultTaskScheduler = new(typeof(System.Threading.Tasks.TaskScheduler), "s_defaultTaskScheduler");
					r_s_defaultTaskScheduler.SetBelong(null);
				}
				return r_s_defaultTaskScheduler;
			}
		}

		/// <summary>
		/// System.Int32 s_taskSchedulerIdCounter
		/// </summary>
		protected static RField r_s_taskSchedulerIdCounter;
		public static RField Rs_taskSchedulerIdCounter
		{
			get
			{
				if(r_s_taskSchedulerIdCounter == null)
				{
					r_s_taskSchedulerIdCounter = new(typeof(System.Threading.Tasks.TaskScheduler), "s_taskSchedulerIdCounter");
					r_s_taskSchedulerIdCounter.SetBelong(null);
				}
				return r_s_taskSchedulerIdCounter;
			}
		}

		/// <summary>
		/// System.Int32 m_taskSchedulerId
		/// </summary>
		protected RField r_m_taskSchedulerId;
		public virtual RField Rm_taskSchedulerId
		{
			get
			{
				if(r_m_taskSchedulerId == null)
				{
					r_m_taskSchedulerId = new(this, "m_taskSchedulerId");
					r_m_taskSchedulerId.SetBelong(this.instance);
				}
				return r_m_taskSchedulerId;
			}
		}

		/// <summary>
		/// System.EventHandler`1[System.Threading.Tasks.UnobservedTaskExceptionEventArgs] _unobservedTaskException
		/// </summary>
		protected static RSystem.REventHandler<RSystem.RThreading.RTasks.RUnobservedTaskExceptionEventArgs> r__unobservedTaskException;
		public static RSystem.REventHandler<RSystem.RThreading.RTasks.RUnobservedTaskExceptionEventArgs> R_unobservedTaskException
		{
			get
			{
				if(r__unobservedTaskException == null)
				{
					r__unobservedTaskException = new(typeof(System.Threading.Tasks.TaskScheduler), "_unobservedTaskException");
					r__unobservedTaskException.SetBelong(null);
				}
				return r__unobservedTaskException;
			}
		}

		/// <summary>
		/// System.Threading.Lock _unobservedTaskExceptionLockObject
		/// </summary>
		protected static RSystem.RThreading.RLock r__unobservedTaskExceptionLockObject;
		public static RSystem.RThreading.RLock R_unobservedTaskExceptionLockObject
		{
			get
			{
				if(r__unobservedTaskExceptionLockObject == null)
				{
					r__unobservedTaskExceptionLockObject = new(typeof(System.Threading.Tasks.TaskScheduler), "_unobservedTaskExceptionLockObject");
					r__unobservedTaskExceptionLockObject.SetBelong(null);
				}
				return r__unobservedTaskExceptionLockObject;
			}
		}

		/// <summary>
		/// Int32 MaximumConcurrencyLevel
		/// </summary>
		protected RProperty r_MaximumConcurrencyLevel;
		public virtual RProperty RMaximumConcurrencyLevel
		{
			get
			{
				if(r_MaximumConcurrencyLevel == null)
				{
					r_MaximumConcurrencyLevel = new(this, "MaximumConcurrencyLevel", -1);
					r_MaximumConcurrencyLevel.SetBelong(this.instance);
				}
				return r_MaximumConcurrencyLevel;
			}
		}

		/// <summary>
		/// Boolean RequiresAtomicStartTransition
		/// </summary>
		protected RProperty r_RequiresAtomicStartTransition;
		public virtual RProperty RequiresAtomicStartTransition
		{
			get
			{
				if(r_RequiresAtomicStartTransition == null)
				{
					r_RequiresAtomicStartTransition = new(this, "RequiresAtomicStartTransition", -1);
					r_RequiresAtomicStartTransition.SetBelong(this.instance);
				}
				return r_RequiresAtomicStartTransition;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskScheduler Default
		/// </summary>
		protected static RSystem.RThreading.RTasks.RTaskScheduler r_Default;
		public static RSystem.RThreading.RTasks.RTaskScheduler RDefault
		{
			get
			{
				if(r_Default == null)
				{
					r_Default = new(typeof(System.Threading.Tasks.TaskScheduler), "Default", -1);
					r_Default.SetBelong(null);
				}
				return r_Default;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskScheduler Current
		/// </summary>
		protected static RSystem.RThreading.RTasks.RTaskScheduler r_Current;
		public static RSystem.RThreading.RTasks.RTaskScheduler RCurrent
		{
			get
			{
				if(r_Current == null)
				{
					r_Current = new(typeof(System.Threading.Tasks.TaskScheduler), "Current", -1);
					r_Current.SetBelong(null);
				}
				return r_Current;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskScheduler InternalCurrent
		/// </summary>
		protected static RSystem.RThreading.RTasks.RTaskScheduler r_InternalCurrent;
		public static RSystem.RThreading.RTasks.RTaskScheduler RInternalCurrent
		{
			get
			{
				if(r_InternalCurrent == null)
				{
					r_InternalCurrent = new(typeof(System.Threading.Tasks.TaskScheduler), "InternalCurrent", -1);
					r_InternalCurrent.SetBelong(null);
				}
				return r_InternalCurrent;
			}
		}

		/// <summary>
		/// Int32 Id
		/// </summary>
		protected RProperty r_Id;
		public virtual RProperty RId
		{
			get
			{
				if(r_Id == null)
				{
					r_Id = new(this, "Id", -1);
					r_Id.SetBelong(this.instance);
				}
				return r_Id;
			}
		}

		/// <summary>
		/// System.EventHandler`1[System.Threading.Tasks.UnobservedTaskExceptionEventArgs] UnobservedTaskException
		/// </summary>
		protected static REvent r_UnobservedTaskException;
		public static REvent RUnobservedTaskException
		{
			get
			{
				if(r_UnobservedTaskException == null)
				{
					r_UnobservedTaskException = new(typeof(System.Threading.Tasks.TaskScheduler), "UnobservedTaskException");
					r_UnobservedTaskException.SetBelong(null);
				}
				return r_UnobservedTaskException;
			}
		}

		/// <summary>
		/// Void QueueTask(System.Threading.Tasks.Task)
		/// </summary>
		protected RMethod r_RQueueTask_Task;
		public virtual RMethod RQueueTask_Task
		{
			get
			{
				if(r_RQueueTask_Task == null)
				{
					r_RQueueTask_Task = new(this, "QueueTask", 0, typeof(System.Threading.Tasks.Task));
					r_RQueueTask_Task.SetBelong(this.instance);
				}
				return r_RQueueTask_Task;
			}
		}

		/// <summary>
		/// Boolean TryExecuteTaskInline(System.Threading.Tasks.Task, Boolean)
		/// </summary>
		protected RMethod r_RTryExecuteTaskInline_Task_Boolean;
		public virtual RMethod RTryExecuteTaskInline_Task_Boolean
		{
			get
			{
				if(r_RTryExecuteTaskInline_Task_Boolean == null)
				{
					r_RTryExecuteTaskInline_Task_Boolean = new(this, "TryExecuteTaskInline", 0, typeof(System.Threading.Tasks.Task), typeof(System.Boolean));
					r_RTryExecuteTaskInline_Task_Boolean.SetBelong(this.instance);
				}
				return r_RTryExecuteTaskInline_Task_Boolean;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Threading.Tasks.Task] GetScheduledTasks()
		/// </summary>
		protected RMethod r_RGetScheduledTasks;
		public virtual RMethod RGetScheduledTasks
		{
			get
			{
				if(r_RGetScheduledTasks == null)
				{
					r_RGetScheduledTasks = new(this, "GetScheduledTasks", 0);
					r_RGetScheduledTasks.SetBelong(this.instance);
				}
				return r_RGetScheduledTasks;
			}
		}

		/// <summary>
		/// Boolean TryRunInline(System.Threading.Tasks.Task, Boolean)
		/// </summary>
		protected RMethod r_RTryRunInline_Task_Boolean;
		public virtual RMethod RTryRunInline_Task_Boolean
		{
			get
			{
				if(r_RTryRunInline_Task_Boolean == null)
				{
					r_RTryRunInline_Task_Boolean = new(this, "TryRunInline", 0, typeof(System.Threading.Tasks.Task), typeof(System.Boolean));
					r_RTryRunInline_Task_Boolean.SetBelong(this.instance);
				}
				return r_RTryRunInline_Task_Boolean;
			}
		}

		/// <summary>
		/// Boolean TryDequeue(System.Threading.Tasks.Task)
		/// </summary>
		protected RMethod r_RTryDequeue_Task;
		public virtual RMethod RTryDequeue_Task
		{
			get
			{
				if(r_RTryDequeue_Task == null)
				{
					r_RTryDequeue_Task = new(this, "TryDequeue", 0, typeof(System.Threading.Tasks.Task));
					r_RTryDequeue_Task.SetBelong(this.instance);
				}
				return r_RTryDequeue_Task;
			}
		}

		/// <summary>
		/// Void NotifyWorkItemProgress()
		/// </summary>
		protected RMethod r_RNotifyWorkItemProgress;
		public virtual RMethod RNotifyWorkItemProgress
		{
			get
			{
				if(r_RNotifyWorkItemProgress == null)
				{
					r_RNotifyWorkItemProgress = new(this, "NotifyWorkItemProgress", 0);
					r_RNotifyWorkItemProgress.SetBelong(this.instance);
				}
				return r_RNotifyWorkItemProgress;
			}
		}

		/// <summary>
		/// Void AddToActiveTaskSchedulers()
		/// </summary>
		protected RMethod r_RAddToActiveTaskSchedulers;
		public virtual RMethod RAddToActiveTaskSchedulers
		{
			get
			{
				if(r_RAddToActiveTaskSchedulers == null)
				{
					r_RAddToActiveTaskSchedulers = new(this, "AddToActiveTaskSchedulers", 0);
					r_RAddToActiveTaskSchedulers.SetBelong(this.instance);
				}
				return r_RAddToActiveTaskSchedulers;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskScheduler FromCurrentSynchronizationContext()
		/// </summary>
		protected static RMethod r_RFromCurrentSynchronizationContext;
		public static RMethod RFromCurrentSynchronizationContext
		{
			get
			{
				if(r_RFromCurrentSynchronizationContext == null)
				{
					r_RFromCurrentSynchronizationContext = new(typeof(System.Threading.Tasks.TaskScheduler), "FromCurrentSynchronizationContext", 0);
					r_RFromCurrentSynchronizationContext.SetBelong(null);
				}
				return r_RFromCurrentSynchronizationContext;
			}
		}

		/// <summary>
		/// Boolean TryExecuteTask(System.Threading.Tasks.Task)
		/// </summary>
		protected RMethod r_RTryExecuteTask_Task;
		public virtual RMethod RTryExecuteTask_Task
		{
			get
			{
				if(r_RTryExecuteTask_Task == null)
				{
					r_RTryExecuteTask_Task = new(this, "TryExecuteTask", 0, typeof(System.Threading.Tasks.Task));
					r_RTryExecuteTask_Task.SetBelong(this.instance);
				}
				return r_RTryExecuteTask_Task;
			}
		}

		/// <summary>
		/// Void PublishUnobservedTaskException(System.Object, System.Threading.Tasks.UnobservedTaskExceptionEventArgs)
		/// </summary>
		protected static RMethod r_RPublishUnobservedTaskException_Object_UnobservedTaskExceptionEventArgs;
		public static RMethod RPublishUnobservedTaskException_Object_UnobservedTaskExceptionEventArgs
		{
			get
			{
				if(r_RPublishUnobservedTaskException_Object_UnobservedTaskExceptionEventArgs == null)
				{
					r_RPublishUnobservedTaskException_Object_UnobservedTaskExceptionEventArgs = new(typeof(System.Threading.Tasks.TaskScheduler), "PublishUnobservedTaskException", 0, typeof(System.Object), typeof(System.Threading.Tasks.UnobservedTaskExceptionEventArgs));
					r_RPublishUnobservedTaskException_Object_UnobservedTaskExceptionEventArgs.SetBelong(null);
				}
				return r_RPublishUnobservedTaskException_Object_UnobservedTaskExceptionEventArgs;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task[] GetScheduledTasksForDebugger()
		/// </summary>
		protected RMethod r_RGetScheduledTasksForDebugger;
		public virtual RMethod RGetScheduledTasksForDebugger
		{
			get
			{
				if(r_RGetScheduledTasksForDebugger == null)
				{
					r_RGetScheduledTasksForDebugger = new(this, "GetScheduledTasksForDebugger", 0);
					r_RGetScheduledTasksForDebugger.SetBelong(this.instance);
				}
				return r_RGetScheduledTasksForDebugger;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskScheduler[] GetTaskSchedulersForDebugger()
		/// </summary>
		protected static RMethod r_RGetTaskSchedulersForDebugger;
		public static RMethod RGetTaskSchedulersForDebugger
		{
			get
			{
				if(r_RGetTaskSchedulersForDebugger == null)
				{
					r_RGetTaskSchedulersForDebugger = new(typeof(System.Threading.Tasks.TaskScheduler), "GetTaskSchedulersForDebugger", 0);
					r_RGetTaskSchedulersForDebugger.SetBelong(null);
				}
				return r_RGetTaskSchedulersForDebugger;
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


        public RTaskScheduler() : base("System.Threading.Tasks.TaskScheduler")
        {
        }

        public RTaskScheduler(System.Object instance) : base("System.Threading.Tasks.TaskScheduler")
		{
            SetInstance(instance);
		}

        public RTaskScheduler(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTaskScheduler(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void QueueTask(System.Threading.Tasks.Task  @task)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task};
            var ___result = RQueueTask_Task.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryExecuteTaskInline(System.Threading.Tasks.Task  @task, System.Boolean  @taskWasPreviouslyQueued)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task, @taskWasPreviouslyQueued};
            var ___result = RTryExecuteTaskInline_Task_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task> GetScheduledTasks()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetScheduledTasks.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task>)___result;
        }


        public virtual System.Boolean TryRunInline(System.Threading.Tasks.Task  @task, System.Boolean  @taskWasPreviouslyQueued)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task, @taskWasPreviouslyQueued};
            var ___result = RTryRunInline_Task_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryDequeue(System.Threading.Tasks.Task  @task)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task};
            var ___result = RTryDequeue_Task.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void NotifyWorkItemProgress()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RNotifyWorkItemProgress.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddToActiveTaskSchedulers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAddToActiveTaskSchedulers.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Threading.Tasks.TaskScheduler FromCurrentSynchronizationContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFromCurrentSynchronizationContext.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.TaskScheduler)___result;
        }


        public virtual System.Boolean TryExecuteTask(System.Threading.Tasks.Task  @task)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task};
            var ___result = RTryExecuteTask_Task.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void PublishUnobservedTaskException(System.Object  @sender, System.Threading.Tasks.UnobservedTaskExceptionEventArgs  @ueea)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender, @ueea};
            var ___result = RPublishUnobservedTaskException_Object_UnobservedTaskExceptionEventArgs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Threading.Tasks.Task[] GetScheduledTasksForDebugger()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetScheduledTasksForDebugger.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task[])___result;
        }


        public static System.Threading.Tasks.TaskScheduler[] GetTaskSchedulersForDebugger()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTaskSchedulersForDebugger.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.TaskScheduler[])___result;
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
