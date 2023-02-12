
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
		protected static REvent r_EUnobservedTaskException;
		public static REvent REUnobservedTaskException
		{
			get
			{
				if(r_EUnobservedTaskException == null)
				{
					r_EUnobservedTaskException = new(typeof(System.Threading.Tasks.TaskScheduler), "UnobservedTaskException");
					r_EUnobservedTaskException.SetBelong(null);
				}
				return r_EUnobservedTaskException;
			}
		}

		/// <summary>
		/// System.Runtime.CompilerServices.ConditionalWeakTable`2[System.Threading.Tasks.TaskScheduler,System.Object] s_activeTaskSchedulers
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RCompilerServices.RConditionalWeakTable<SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskScheduler, SMFrame.Editor.Refleaction.RSystem.RObject> r_Fs_activeTaskSchedulers;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RCompilerServices.RConditionalWeakTable<SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskScheduler, SMFrame.Editor.Refleaction.RSystem.RObject> RFs_activeTaskSchedulers
		{
			get
			{
				if(r_Fs_activeTaskSchedulers == null)
				{
					r_Fs_activeTaskSchedulers = new(typeof(System.Threading.Tasks.TaskScheduler), "s_activeTaskSchedulers");
					r_Fs_activeTaskSchedulers.SetBelong(null);
				}
				return r_Fs_activeTaskSchedulers;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskScheduler s_defaultTaskScheduler
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskScheduler r_Fs_defaultTaskScheduler;
		public static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskScheduler RFs_defaultTaskScheduler
		{
			get
			{
				if(r_Fs_defaultTaskScheduler == null)
				{
					r_Fs_defaultTaskScheduler = new(typeof(System.Threading.Tasks.TaskScheduler), "s_defaultTaskScheduler");
					r_Fs_defaultTaskScheduler.SetBelong(null);
				}
				return r_Fs_defaultTaskScheduler;
			}
		}

		/// <summary>
		/// System.Int32 s_taskSchedulerIdCounter
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fs_taskSchedulerIdCounter;
		public static SMFrame.Editor.Refleaction.RSystem.RInt32 RFs_taskSchedulerIdCounter
		{
			get
			{
				if(r_Fs_taskSchedulerIdCounter == null)
				{
					r_Fs_taskSchedulerIdCounter = new(typeof(System.Threading.Tasks.TaskScheduler), "s_taskSchedulerIdCounter");
					r_Fs_taskSchedulerIdCounter.SetBelong(null);
				}
				return r_Fs_taskSchedulerIdCounter;
			}
		}

		/// <summary>
		/// System.Int32 m_taskSchedulerId
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fm_taskSchedulerId;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFm_taskSchedulerId
		{
			get
			{
				if(r_Fm_taskSchedulerId == null)
				{
					r_Fm_taskSchedulerId = new(this, "m_taskSchedulerId");
					r_Fm_taskSchedulerId.SetBelong(this.instance);
				}
				return r_Fm_taskSchedulerId;
			}
		}

		/// <summary>
		/// System.EventHandler`1[System.Threading.Tasks.UnobservedTaskExceptionEventArgs] _unobservedTaskException
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.REventHandler<SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RUnobservedTaskExceptionEventArgs> r_F_unobservedTaskException;
		public static SMFrame.Editor.Refleaction.RSystem.REventHandler<SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RUnobservedTaskExceptionEventArgs> RF_unobservedTaskException
		{
			get
			{
				if(r_F_unobservedTaskException == null)
				{
					r_F_unobservedTaskException = new(typeof(System.Threading.Tasks.TaskScheduler), "_unobservedTaskException");
					r_F_unobservedTaskException.SetBelong(null);
				}
				return r_F_unobservedTaskException;
			}
		}

		/// <summary>
		/// System.Threading.Lock _unobservedTaskExceptionLockObject
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RThreading.RLock r_F_unobservedTaskExceptionLockObject;
		public static SMFrame.Editor.Refleaction.RSystem.RThreading.RLock RF_unobservedTaskExceptionLockObject
		{
			get
			{
				if(r_F_unobservedTaskExceptionLockObject == null)
				{
					r_F_unobservedTaskExceptionLockObject = new(typeof(System.Threading.Tasks.TaskScheduler), "_unobservedTaskExceptionLockObject");
					r_F_unobservedTaskExceptionLockObject.SetBelong(null);
				}
				return r_F_unobservedTaskExceptionLockObject;
			}
		}

		/// <summary>
		/// Int32 MaximumConcurrencyLevel
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PMaximumConcurrencyLevel;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPMaximumConcurrencyLevel
		{
			get
			{
				if(r_PMaximumConcurrencyLevel == null)
				{
					r_PMaximumConcurrencyLevel = new(this, "MaximumConcurrencyLevel", -1);
					r_PMaximumConcurrencyLevel.SetBelong(this.instance);
				}
				return r_PMaximumConcurrencyLevel;
			}
		}

		/// <summary>
		/// Boolean RequiresAtomicStartTransition
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PRequiresAtomicStartTransition;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPRequiresAtomicStartTransition
		{
			get
			{
				if(r_PRequiresAtomicStartTransition == null)
				{
					r_PRequiresAtomicStartTransition = new(this, "RequiresAtomicStartTransition", -1);
					r_PRequiresAtomicStartTransition.SetBelong(this.instance);
				}
				return r_PRequiresAtomicStartTransition;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskScheduler Default
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskScheduler r_PDefault;
		public static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskScheduler RPDefault
		{
			get
			{
				if(r_PDefault == null)
				{
					r_PDefault = new(typeof(System.Threading.Tasks.TaskScheduler), "Default", -1);
					r_PDefault.SetBelong(null);
				}
				return r_PDefault;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskScheduler Current
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskScheduler r_PCurrent;
		public static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskScheduler RPCurrent
		{
			get
			{
				if(r_PCurrent == null)
				{
					r_PCurrent = new(typeof(System.Threading.Tasks.TaskScheduler), "Current", -1);
					r_PCurrent.SetBelong(null);
				}
				return r_PCurrent;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskScheduler InternalCurrent
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskScheduler r_PInternalCurrent;
		public static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskScheduler RPInternalCurrent
		{
			get
			{
				if(r_PInternalCurrent == null)
				{
					r_PInternalCurrent = new(typeof(System.Threading.Tasks.TaskScheduler), "InternalCurrent", -1);
					r_PInternalCurrent.SetBelong(null);
				}
				return r_PInternalCurrent;
			}
		}

		/// <summary>
		/// Int32 Id
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PId;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPId
		{
			get
			{
				if(r_PId == null)
				{
					r_PId = new(this, "Id", -1);
					r_PId.SetBelong(this.instance);
				}
				return r_PId;
			}
		}

		/// <summary>
		/// Void QueueTask(System.Threading.Tasks.Task)
		/// </summary>
		protected RMethod r_MQueueTask_Task;
		public virtual RMethod RMQueueTask_Task
		{
			get
			{
				if(r_MQueueTask_Task == null)
				{
					r_MQueueTask_Task = new(this, "QueueTask", 0, typeof(System.Threading.Tasks.Task));
					r_MQueueTask_Task.SetBelong(this.instance);
				}
				return r_MQueueTask_Task;
			}
		}

		/// <summary>
		/// Boolean TryExecuteTaskInline(System.Threading.Tasks.Task, Boolean)
		/// </summary>
		protected RMethod r_MTryExecuteTaskInline_Task_Boolean;
		public virtual RMethod RMTryExecuteTaskInline_Task_Boolean
		{
			get
			{
				if(r_MTryExecuteTaskInline_Task_Boolean == null)
				{
					r_MTryExecuteTaskInline_Task_Boolean = new(this, "TryExecuteTaskInline", 0, typeof(System.Threading.Tasks.Task), typeof(System.Boolean));
					r_MTryExecuteTaskInline_Task_Boolean.SetBelong(this.instance);
				}
				return r_MTryExecuteTaskInline_Task_Boolean;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Threading.Tasks.Task] GetScheduledTasks()
		/// </summary>
		protected RMethod r_MGetScheduledTasks;
		public virtual RMethod RMGetScheduledTasks
		{
			get
			{
				if(r_MGetScheduledTasks == null)
				{
					r_MGetScheduledTasks = new(this, "GetScheduledTasks", 0);
					r_MGetScheduledTasks.SetBelong(this.instance);
				}
				return r_MGetScheduledTasks;
			}
		}

		/// <summary>
		/// Boolean TryRunInline(System.Threading.Tasks.Task, Boolean)
		/// </summary>
		protected RMethod r_MTryRunInline_Task_Boolean;
		public virtual RMethod RMTryRunInline_Task_Boolean
		{
			get
			{
				if(r_MTryRunInline_Task_Boolean == null)
				{
					r_MTryRunInline_Task_Boolean = new(this, "TryRunInline", 0, typeof(System.Threading.Tasks.Task), typeof(System.Boolean));
					r_MTryRunInline_Task_Boolean.SetBelong(this.instance);
				}
				return r_MTryRunInline_Task_Boolean;
			}
		}

		/// <summary>
		/// Boolean TryDequeue(System.Threading.Tasks.Task)
		/// </summary>
		protected RMethod r_MTryDequeue_Task;
		public virtual RMethod RMTryDequeue_Task
		{
			get
			{
				if(r_MTryDequeue_Task == null)
				{
					r_MTryDequeue_Task = new(this, "TryDequeue", 0, typeof(System.Threading.Tasks.Task));
					r_MTryDequeue_Task.SetBelong(this.instance);
				}
				return r_MTryDequeue_Task;
			}
		}

		/// <summary>
		/// Void NotifyWorkItemProgress()
		/// </summary>
		protected RMethod r_MNotifyWorkItemProgress;
		public virtual RMethod RMNotifyWorkItemProgress
		{
			get
			{
				if(r_MNotifyWorkItemProgress == null)
				{
					r_MNotifyWorkItemProgress = new(this, "NotifyWorkItemProgress", 0);
					r_MNotifyWorkItemProgress.SetBelong(this.instance);
				}
				return r_MNotifyWorkItemProgress;
			}
		}

		/// <summary>
		/// Void AddToActiveTaskSchedulers()
		/// </summary>
		protected RMethod r_MAddToActiveTaskSchedulers;
		public virtual RMethod RMAddToActiveTaskSchedulers
		{
			get
			{
				if(r_MAddToActiveTaskSchedulers == null)
				{
					r_MAddToActiveTaskSchedulers = new(this, "AddToActiveTaskSchedulers", 0);
					r_MAddToActiveTaskSchedulers.SetBelong(this.instance);
				}
				return r_MAddToActiveTaskSchedulers;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskScheduler FromCurrentSynchronizationContext()
		/// </summary>
		protected static RMethod r_MFromCurrentSynchronizationContext;
		public static RMethod RMFromCurrentSynchronizationContext
		{
			get
			{
				if(r_MFromCurrentSynchronizationContext == null)
				{
					r_MFromCurrentSynchronizationContext = new(typeof(System.Threading.Tasks.TaskScheduler), "FromCurrentSynchronizationContext", 0);
					r_MFromCurrentSynchronizationContext.SetBelong(null);
				}
				return r_MFromCurrentSynchronizationContext;
			}
		}

		/// <summary>
		/// Boolean TryExecuteTask(System.Threading.Tasks.Task)
		/// </summary>
		protected RMethod r_MTryExecuteTask_Task;
		public virtual RMethod RMTryExecuteTask_Task
		{
			get
			{
				if(r_MTryExecuteTask_Task == null)
				{
					r_MTryExecuteTask_Task = new(this, "TryExecuteTask", 0, typeof(System.Threading.Tasks.Task));
					r_MTryExecuteTask_Task.SetBelong(this.instance);
				}
				return r_MTryExecuteTask_Task;
			}
		}

		/// <summary>
		/// Void PublishUnobservedTaskException(System.Object, System.Threading.Tasks.UnobservedTaskExceptionEventArgs)
		/// </summary>
		protected static RMethod r_MPublishUnobservedTaskException_Object_UnobservedTaskExceptionEventArgs;
		public static RMethod RMPublishUnobservedTaskException_Object_UnobservedTaskExceptionEventArgs
		{
			get
			{
				if(r_MPublishUnobservedTaskException_Object_UnobservedTaskExceptionEventArgs == null)
				{
					r_MPublishUnobservedTaskException_Object_UnobservedTaskExceptionEventArgs = new(typeof(System.Threading.Tasks.TaskScheduler), "PublishUnobservedTaskException", 0, typeof(System.Object), typeof(System.Threading.Tasks.UnobservedTaskExceptionEventArgs));
					r_MPublishUnobservedTaskException_Object_UnobservedTaskExceptionEventArgs.SetBelong(null);
				}
				return r_MPublishUnobservedTaskException_Object_UnobservedTaskExceptionEventArgs;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task[] GetScheduledTasksForDebugger()
		/// </summary>
		protected RMethod r_MGetScheduledTasksForDebugger;
		public virtual RMethod RMGetScheduledTasksForDebugger
		{
			get
			{
				if(r_MGetScheduledTasksForDebugger == null)
				{
					r_MGetScheduledTasksForDebugger = new(this, "GetScheduledTasksForDebugger", 0);
					r_MGetScheduledTasksForDebugger.SetBelong(this.instance);
				}
				return r_MGetScheduledTasksForDebugger;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskScheduler[] GetTaskSchedulersForDebugger()
		/// </summary>
		protected static RMethod r_MGetTaskSchedulersForDebugger;
		public static RMethod RMGetTaskSchedulersForDebugger
		{
			get
			{
				if(r_MGetTaskSchedulersForDebugger == null)
				{
					r_MGetTaskSchedulersForDebugger = new(typeof(System.Threading.Tasks.TaskScheduler), "GetTaskSchedulersForDebugger", 0);
					r_MGetTaskSchedulersForDebugger.SetBelong(null);
				}
				return r_MGetTaskSchedulersForDebugger;
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
            var ___result = RMQueueTask_Task.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryExecuteTaskInline(System.Threading.Tasks.Task @task, System.Boolean @taskWasPreviouslyQueued)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task, @taskWasPreviouslyQueued};
            var ___result = RMTryExecuteTaskInline_Task_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task> GetScheduledTasks()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetScheduledTasks.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task>)___result;
        }


        public virtual System.Boolean TryRunInline(System.Threading.Tasks.Task @task, System.Boolean @taskWasPreviouslyQueued)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task, @taskWasPreviouslyQueued};
            var ___result = RMTryRunInline_Task_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryDequeue(System.Threading.Tasks.Task @task)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task};
            var ___result = RMTryDequeue_Task.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void NotifyWorkItemProgress()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMNotifyWorkItemProgress.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddToActiveTaskSchedulers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAddToActiveTaskSchedulers.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Threading.Tasks.TaskScheduler FromCurrentSynchronizationContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFromCurrentSynchronizationContext.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.TaskScheduler)___result;
        }


        public virtual System.Boolean TryExecuteTask(System.Threading.Tasks.Task @task)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task};
            var ___result = RMTryExecuteTask_Task.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void PublishUnobservedTaskException(System.Object @sender, System.Threading.Tasks.UnobservedTaskExceptionEventArgs @ueea)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender, @ueea};
            var ___result = RMPublishUnobservedTaskException_Object_UnobservedTaskExceptionEventArgs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Threading.Tasks.Task[] GetScheduledTasksForDebugger()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetScheduledTasksForDebugger.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task[])___result;
        }


        public static System.Threading.Tasks.TaskScheduler[] GetTaskSchedulersForDebugger()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTaskSchedulersForDebugger.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.TaskScheduler[])___result;
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
