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
		public virtual RProperty RRequiresAtomicStartTransition
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
		/// Void QueueTask(System.Threading.Tasks.Task)
		/// </summary>
		protected RMethod r_QueueTask_Task;
		public virtual RMethod RQueueTask_Task
		{
			get
			{
				if(r_QueueTask_Task == null)
				{
					r_QueueTask_Task = new(this, "QueueTask", 0, typeof(System.Threading.Tasks.Task));
					r_QueueTask_Task.SetBelong(this.instance);
				}
				return r_QueueTask_Task;
			}
		}

		/// <summary>
		/// Boolean TryExecuteTaskInline(System.Threading.Tasks.Task, Boolean)
		/// </summary>
		protected RMethod r_TryExecuteTaskInline_Task_Boolean;
		public virtual RMethod RTryExecuteTaskInline_Task_Boolean
		{
			get
			{
				if(r_TryExecuteTaskInline_Task_Boolean == null)
				{
					r_TryExecuteTaskInline_Task_Boolean = new(this, "TryExecuteTaskInline", 0, typeof(System.Threading.Tasks.Task), typeof(System.Boolean));
					r_TryExecuteTaskInline_Task_Boolean.SetBelong(this.instance);
				}
				return r_TryExecuteTaskInline_Task_Boolean;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Threading.Tasks.Task] GetScheduledTasks()
		/// </summary>
		protected RMethod r_GetScheduledTasks;
		public virtual RMethod RGetScheduledTasks
		{
			get
			{
				if(r_GetScheduledTasks == null)
				{
					r_GetScheduledTasks = new(this, "GetScheduledTasks", 0);
					r_GetScheduledTasks.SetBelong(this.instance);
				}
				return r_GetScheduledTasks;
			}
		}

		/// <summary>
		/// Boolean TryRunInline(System.Threading.Tasks.Task, Boolean)
		/// </summary>
		protected RMethod r_TryRunInline_Task_Boolean;
		public virtual RMethod RTryRunInline_Task_Boolean
		{
			get
			{
				if(r_TryRunInline_Task_Boolean == null)
				{
					r_TryRunInline_Task_Boolean = new(this, "TryRunInline", 0, typeof(System.Threading.Tasks.Task), typeof(System.Boolean));
					r_TryRunInline_Task_Boolean.SetBelong(this.instance);
				}
				return r_TryRunInline_Task_Boolean;
			}
		}

		/// <summary>
		/// Boolean TryDequeue(System.Threading.Tasks.Task)
		/// </summary>
		protected RMethod r_TryDequeue_Task;
		public virtual RMethod RTryDequeue_Task
		{
			get
			{
				if(r_TryDequeue_Task == null)
				{
					r_TryDequeue_Task = new(this, "TryDequeue", 0, typeof(System.Threading.Tasks.Task));
					r_TryDequeue_Task.SetBelong(this.instance);
				}
				return r_TryDequeue_Task;
			}
		}

		/// <summary>
		/// Void NotifyWorkItemProgress()
		/// </summary>
		protected RMethod r_NotifyWorkItemProgress;
		public virtual RMethod RNotifyWorkItemProgress
		{
			get
			{
				if(r_NotifyWorkItemProgress == null)
				{
					r_NotifyWorkItemProgress = new(this, "NotifyWorkItemProgress", 0);
					r_NotifyWorkItemProgress.SetBelong(this.instance);
				}
				return r_NotifyWorkItemProgress;
			}
		}

		/// <summary>
		/// Void AddToActiveTaskSchedulers()
		/// </summary>
		protected RMethod r_AddToActiveTaskSchedulers;
		public virtual RMethod RAddToActiveTaskSchedulers
		{
			get
			{
				if(r_AddToActiveTaskSchedulers == null)
				{
					r_AddToActiveTaskSchedulers = new(this, "AddToActiveTaskSchedulers", 0);
					r_AddToActiveTaskSchedulers.SetBelong(this.instance);
				}
				return r_AddToActiveTaskSchedulers;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskScheduler FromCurrentSynchronizationContext()
		/// </summary>
		protected static RMethod r_FromCurrentSynchronizationContext;
		public static RMethod RFromCurrentSynchronizationContext
		{
			get
			{
				if(r_FromCurrentSynchronizationContext == null)
				{
					r_FromCurrentSynchronizationContext = new(typeof(System.Threading.Tasks.TaskScheduler), "FromCurrentSynchronizationContext", 0);
					r_FromCurrentSynchronizationContext.SetBelong(null);
				}
				return r_FromCurrentSynchronizationContext;
			}
		}

		/// <summary>
		/// Boolean TryExecuteTask(System.Threading.Tasks.Task)
		/// </summary>
		protected RMethod r_TryExecuteTask_Task;
		public virtual RMethod RTryExecuteTask_Task
		{
			get
			{
				if(r_TryExecuteTask_Task == null)
				{
					r_TryExecuteTask_Task = new(this, "TryExecuteTask", 0, typeof(System.Threading.Tasks.Task));
					r_TryExecuteTask_Task.SetBelong(this.instance);
				}
				return r_TryExecuteTask_Task;
			}
		}

		/// <summary>
		/// Void PublishUnobservedTaskException(System.Object, System.Threading.Tasks.UnobservedTaskExceptionEventArgs)
		/// </summary>
		protected static RMethod r_PublishUnobservedTaskException_Object_UnobservedTaskExceptionEventArgs;
		public static RMethod RPublishUnobservedTaskException_Object_UnobservedTaskExceptionEventArgs
		{
			get
			{
				if(r_PublishUnobservedTaskException_Object_UnobservedTaskExceptionEventArgs == null)
				{
					r_PublishUnobservedTaskException_Object_UnobservedTaskExceptionEventArgs = new(typeof(System.Threading.Tasks.TaskScheduler), "PublishUnobservedTaskException", 0, typeof(System.Object), typeof(System.Threading.Tasks.UnobservedTaskExceptionEventArgs));
					r_PublishUnobservedTaskException_Object_UnobservedTaskExceptionEventArgs.SetBelong(null);
				}
				return r_PublishUnobservedTaskException_Object_UnobservedTaskExceptionEventArgs;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task[] GetScheduledTasksForDebugger()
		/// </summary>
		protected RMethod r_GetScheduledTasksForDebugger;
		public virtual RMethod RGetScheduledTasksForDebugger
		{
			get
			{
				if(r_GetScheduledTasksForDebugger == null)
				{
					r_GetScheduledTasksForDebugger = new(this, "GetScheduledTasksForDebugger", 0);
					r_GetScheduledTasksForDebugger.SetBelong(this.instance);
				}
				return r_GetScheduledTasksForDebugger;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskScheduler[] GetTaskSchedulersForDebugger()
		/// </summary>
		protected static RMethod r_GetTaskSchedulersForDebugger;
		public static RMethod RGetTaskSchedulersForDebugger
		{
			get
			{
				if(r_GetTaskSchedulersForDebugger == null)
				{
					r_GetTaskSchedulersForDebugger = new(typeof(System.Threading.Tasks.TaskScheduler), "GetTaskSchedulersForDebugger", 0);
					r_GetTaskSchedulersForDebugger.SetBelong(null);
				}
				return r_GetTaskSchedulersForDebugger;
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

        public virtual void QueueTask(System.Threading.Tasks.Task @task)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task};
            var ___result = RQueueTask_Task.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryExecuteTaskInline(System.Threading.Tasks.Task @task, System.Boolean @taskWasPreviouslyQueued)
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


        public virtual System.Boolean TryRunInline(System.Threading.Tasks.Task @task, System.Boolean @taskWasPreviouslyQueued)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task, @taskWasPreviouslyQueued};
            var ___result = RTryRunInline_Task_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryDequeue(System.Threading.Tasks.Task @task)
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


        public virtual System.Boolean TryExecuteTask(System.Threading.Tasks.Task @task)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task};
            var ___result = RTryExecuteTask_Task.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void PublishUnobservedTaskException(System.Object @sender, System.Threading.Tasks.UnobservedTaskExceptionEventArgs @ueea)
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
