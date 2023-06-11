
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RThreading.RTasks
{
	/// <summary>
	/// System.Threading.Tasks.Task
	/// </summary>
    public partial class RTask : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Threading.Tasks.Task);
            }
        }

        public RTask() : base("System.Threading.Tasks.Task")
        {
        }

        public RTask(System.Object instance) : base("System.Threading.Tasks.Task")
		{
            SetInstance(instance);
		}

        public RTask(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTask(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 s_taskIdCounter
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fs_taskIdCounter;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFs_taskIdCounter
		{
			get
			{
				if(r_Fs_taskIdCounter == null)
				{
					r_Fs_taskIdCounter = new(typeof(System.Threading.Tasks.Task), "s_taskIdCounter");
				}
				return r_Fs_taskIdCounter;
			}
		}

		/// <summary>
		/// System.Int32 m_taskId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_taskId;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_taskId
		{
			get
			{
				if(r_Fm_taskId == null)
				{
					r_Fm_taskId = new(this, "m_taskId");
				}
				return r_Fm_taskId;
			}
		}

		/// <summary>
		/// System.Delegate m_action
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RDelegate r_Fm_action;
		public virtual Hvak.Editor.Refleaction.RSystem.RDelegate RFm_action
		{
			get
			{
				if(r_Fm_action == null)
				{
					r_Fm_action = new(this, "m_action");
				}
				return r_Fm_action;
			}
		}

		/// <summary>
		/// System.Object m_stateObject
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_Fm_stateObject;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RFm_stateObject
		{
			get
			{
				if(r_Fm_stateObject == null)
				{
					r_Fm_stateObject = new(this, "m_stateObject");
				}
				return r_Fm_stateObject;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskScheduler m_taskScheduler
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskScheduler r_Fm_taskScheduler;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskScheduler RFm_taskScheduler
		{
			get
			{
				if(r_Fm_taskScheduler == null)
				{
					r_Fm_taskScheduler = new(this, "m_taskScheduler");
				}
				return r_Fm_taskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task m_parent
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask r_Fm_parent;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask RFm_parent
		{
			get
			{
				if(r_Fm_parent == null)
				{
					r_Fm_parent = new(this, "m_parent");
				}
				return r_Fm_parent;
			}
		}

		/// <summary>
		/// System.Int32 m_stateFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_stateFlags;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_stateFlags
		{
			get
			{
				if(r_Fm_stateFlags == null)
				{
					r_Fm_stateFlags = new(this, "m_stateFlags");
				}
				return r_Fm_stateFlags;
			}
		}

		/// <summary>
		/// System.Int32 OptionsMask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FOptionsMask;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFOptionsMask
		{
			get
			{
				if(r_FOptionsMask == null)
				{
					r_FOptionsMask = new(typeof(System.Threading.Tasks.Task), "OptionsMask");
				}
				return r_FOptionsMask;
			}
		}

		/// <summary>
		/// System.Int32 TASK_STATE_STARTED
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FTASK_STATE_STARTED;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFTASK_STATE_STARTED
		{
			get
			{
				if(r_FTASK_STATE_STARTED == null)
				{
					r_FTASK_STATE_STARTED = new(typeof(System.Threading.Tasks.Task), "TASK_STATE_STARTED");
				}
				return r_FTASK_STATE_STARTED;
			}
		}

		/// <summary>
		/// System.Int32 TASK_STATE_DELEGATE_INVOKED
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FTASK_STATE_DELEGATE_INVOKED;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFTASK_STATE_DELEGATE_INVOKED
		{
			get
			{
				if(r_FTASK_STATE_DELEGATE_INVOKED == null)
				{
					r_FTASK_STATE_DELEGATE_INVOKED = new(typeof(System.Threading.Tasks.Task), "TASK_STATE_DELEGATE_INVOKED");
				}
				return r_FTASK_STATE_DELEGATE_INVOKED;
			}
		}

		/// <summary>
		/// System.Int32 TASK_STATE_DISPOSED
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FTASK_STATE_DISPOSED;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFTASK_STATE_DISPOSED
		{
			get
			{
				if(r_FTASK_STATE_DISPOSED == null)
				{
					r_FTASK_STATE_DISPOSED = new(typeof(System.Threading.Tasks.Task), "TASK_STATE_DISPOSED");
				}
				return r_FTASK_STATE_DISPOSED;
			}
		}

		/// <summary>
		/// System.Int32 TASK_STATE_EXCEPTIONOBSERVEDBYPARENT
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FTASK_STATE_EXCEPTIONOBSERVEDBYPARENT;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFTASK_STATE_EXCEPTIONOBSERVEDBYPARENT
		{
			get
			{
				if(r_FTASK_STATE_EXCEPTIONOBSERVEDBYPARENT == null)
				{
					r_FTASK_STATE_EXCEPTIONOBSERVEDBYPARENT = new(typeof(System.Threading.Tasks.Task), "TASK_STATE_EXCEPTIONOBSERVEDBYPARENT");
				}
				return r_FTASK_STATE_EXCEPTIONOBSERVEDBYPARENT;
			}
		}

		/// <summary>
		/// System.Int32 TASK_STATE_CANCELLATIONACKNOWLEDGED
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FTASK_STATE_CANCELLATIONACKNOWLEDGED;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFTASK_STATE_CANCELLATIONACKNOWLEDGED
		{
			get
			{
				if(r_FTASK_STATE_CANCELLATIONACKNOWLEDGED == null)
				{
					r_FTASK_STATE_CANCELLATIONACKNOWLEDGED = new(typeof(System.Threading.Tasks.Task), "TASK_STATE_CANCELLATIONACKNOWLEDGED");
				}
				return r_FTASK_STATE_CANCELLATIONACKNOWLEDGED;
			}
		}

		/// <summary>
		/// System.Int32 TASK_STATE_FAULTED
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FTASK_STATE_FAULTED;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFTASK_STATE_FAULTED
		{
			get
			{
				if(r_FTASK_STATE_FAULTED == null)
				{
					r_FTASK_STATE_FAULTED = new(typeof(System.Threading.Tasks.Task), "TASK_STATE_FAULTED");
				}
				return r_FTASK_STATE_FAULTED;
			}
		}

		/// <summary>
		/// System.Int32 TASK_STATE_CANCELED
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FTASK_STATE_CANCELED;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFTASK_STATE_CANCELED
		{
			get
			{
				if(r_FTASK_STATE_CANCELED == null)
				{
					r_FTASK_STATE_CANCELED = new(typeof(System.Threading.Tasks.Task), "TASK_STATE_CANCELED");
				}
				return r_FTASK_STATE_CANCELED;
			}
		}

		/// <summary>
		/// System.Int32 TASK_STATE_WAITING_ON_CHILDREN
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FTASK_STATE_WAITING_ON_CHILDREN;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFTASK_STATE_WAITING_ON_CHILDREN
		{
			get
			{
				if(r_FTASK_STATE_WAITING_ON_CHILDREN == null)
				{
					r_FTASK_STATE_WAITING_ON_CHILDREN = new(typeof(System.Threading.Tasks.Task), "TASK_STATE_WAITING_ON_CHILDREN");
				}
				return r_FTASK_STATE_WAITING_ON_CHILDREN;
			}
		}

		/// <summary>
		/// System.Int32 TASK_STATE_RAN_TO_COMPLETION
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FTASK_STATE_RAN_TO_COMPLETION;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFTASK_STATE_RAN_TO_COMPLETION
		{
			get
			{
				if(r_FTASK_STATE_RAN_TO_COMPLETION == null)
				{
					r_FTASK_STATE_RAN_TO_COMPLETION = new(typeof(System.Threading.Tasks.Task), "TASK_STATE_RAN_TO_COMPLETION");
				}
				return r_FTASK_STATE_RAN_TO_COMPLETION;
			}
		}

		/// <summary>
		/// System.Int32 TASK_STATE_WAITINGFORACTIVATION
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FTASK_STATE_WAITINGFORACTIVATION;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFTASK_STATE_WAITINGFORACTIVATION
		{
			get
			{
				if(r_FTASK_STATE_WAITINGFORACTIVATION == null)
				{
					r_FTASK_STATE_WAITINGFORACTIVATION = new(typeof(System.Threading.Tasks.Task), "TASK_STATE_WAITINGFORACTIVATION");
				}
				return r_FTASK_STATE_WAITINGFORACTIVATION;
			}
		}

		/// <summary>
		/// System.Int32 TASK_STATE_COMPLETION_RESERVED
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FTASK_STATE_COMPLETION_RESERVED;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFTASK_STATE_COMPLETION_RESERVED
		{
			get
			{
				if(r_FTASK_STATE_COMPLETION_RESERVED == null)
				{
					r_FTASK_STATE_COMPLETION_RESERVED = new(typeof(System.Threading.Tasks.Task), "TASK_STATE_COMPLETION_RESERVED");
				}
				return r_FTASK_STATE_COMPLETION_RESERVED;
			}
		}

		/// <summary>
		/// System.Int32 TASK_STATE_THREAD_WAS_ABORTED
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FTASK_STATE_THREAD_WAS_ABORTED;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFTASK_STATE_THREAD_WAS_ABORTED
		{
			get
			{
				if(r_FTASK_STATE_THREAD_WAS_ABORTED == null)
				{
					r_FTASK_STATE_THREAD_WAS_ABORTED = new(typeof(System.Threading.Tasks.Task), "TASK_STATE_THREAD_WAS_ABORTED");
				}
				return r_FTASK_STATE_THREAD_WAS_ABORTED;
			}
		}

		/// <summary>
		/// System.Int32 TASK_STATE_WAIT_COMPLETION_NOTIFICATION
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FTASK_STATE_WAIT_COMPLETION_NOTIFICATION;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFTASK_STATE_WAIT_COMPLETION_NOTIFICATION
		{
			get
			{
				if(r_FTASK_STATE_WAIT_COMPLETION_NOTIFICATION == null)
				{
					r_FTASK_STATE_WAIT_COMPLETION_NOTIFICATION = new(typeof(System.Threading.Tasks.Task), "TASK_STATE_WAIT_COMPLETION_NOTIFICATION");
				}
				return r_FTASK_STATE_WAIT_COMPLETION_NOTIFICATION;
			}
		}

		/// <summary>
		/// System.Int32 TASK_STATE_COMPLETED_MASK
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FTASK_STATE_COMPLETED_MASK;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFTASK_STATE_COMPLETED_MASK
		{
			get
			{
				if(r_FTASK_STATE_COMPLETED_MASK == null)
				{
					r_FTASK_STATE_COMPLETED_MASK = new(typeof(System.Threading.Tasks.Task), "TASK_STATE_COMPLETED_MASK");
				}
				return r_FTASK_STATE_COMPLETED_MASK;
			}
		}

		/// <summary>
		/// System.Int32 CANCELLATION_REQUESTED
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCANCELLATION_REQUESTED;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCANCELLATION_REQUESTED
		{
			get
			{
				if(r_FCANCELLATION_REQUESTED == null)
				{
					r_FCANCELLATION_REQUESTED = new(typeof(System.Threading.Tasks.Task), "CANCELLATION_REQUESTED");
				}
				return r_FCANCELLATION_REQUESTED;
			}
		}

		/// <summary>
		/// System.Object m_continuationObject
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_Fm_continuationObject;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RFm_continuationObject
		{
			get
			{
				if(r_Fm_continuationObject == null)
				{
					r_Fm_continuationObject = new(this, "m_continuationObject");
				}
				return r_Fm_continuationObject;
			}
		}

		/// <summary>
		/// System.Object s_taskCompletionSentinel
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RObject r_Fs_taskCompletionSentinel;
		public static Hvak.Editor.Refleaction.RSystem.RObject RFs_taskCompletionSentinel
		{
			get
			{
				if(r_Fs_taskCompletionSentinel == null)
				{
					r_Fs_taskCompletionSentinel = new(typeof(System.Threading.Tasks.Task), "s_taskCompletionSentinel");
				}
				return r_Fs_taskCompletionSentinel;
			}
		}

		/// <summary>
		/// System.Boolean s_asyncDebuggingEnabled
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RBoolean r_Fs_asyncDebuggingEnabled;
		public static Hvak.Editor.Refleaction.RSystem.RBoolean RFs_asyncDebuggingEnabled
		{
			get
			{
				if(r_Fs_asyncDebuggingEnabled == null)
				{
					r_Fs_asyncDebuggingEnabled = new(typeof(System.Threading.Tasks.Task), "s_asyncDebuggingEnabled");
				}
				return r_Fs_asyncDebuggingEnabled;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task+ContingentProperties m_contingentProperties
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask.RContingentProperties r_Fm_contingentProperties;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask.RContingentProperties RFm_contingentProperties
		{
			get
			{
				if(r_Fm_contingentProperties == null)
				{
					r_Fm_contingentProperties = new(this, "m_contingentProperties");
				}
				return r_Fm_contingentProperties;
			}
		}

		/// <summary>
		/// System.Action`1[System.Object] s_taskCancelCallback
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RObject> r_Fs_taskCancelCallback;
		public static Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RObject> RFs_taskCancelCallback
		{
			get
			{
				if(r_Fs_taskCancelCallback == null)
				{
					r_Fs_taskCancelCallback = new(typeof(System.Threading.Tasks.Task), "s_taskCancelCallback");
				}
				return r_Fs_taskCancelCallback;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task t_currentTask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask r_Ft_currentTask;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask RFt_currentTask
		{
			get
			{
				if(r_Ft_currentTask == null)
				{
					r_Ft_currentTask = new(typeof(System.Threading.Tasks.Task), "t_currentTask");
				}
				return r_Ft_currentTask;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.StackGuard t_stackGuard
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RStackGuard r_Ft_stackGuard;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RStackGuard RFt_stackGuard
		{
			get
			{
				if(r_Ft_stackGuard == null)
				{
					r_Ft_stackGuard = new(typeof(System.Threading.Tasks.Task), "t_stackGuard");
				}
				return r_Ft_stackGuard;
			}
		}

		/// <summary>
		/// System.Func`1[System.Threading.Tasks.Task+ContingentProperties] s_createContingentProperties
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask.RContingentProperties> r_Fs_createContingentProperties;
		public static Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask.RContingentProperties> RFs_createContingentProperties
		{
			get
			{
				if(r_Fs_createContingentProperties == null)
				{
					r_Fs_createContingentProperties = new(typeof(System.Threading.Tasks.Task), "s_createContingentProperties");
				}
				return r_Fs_createContingentProperties;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskFactory <Factory>k__BackingField
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskFactory r_F__0__Factory__1__k__BackingField;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskFactory RF__0__Factory__1__k__BackingField
		{
			get
			{
				if(r_F__0__Factory__1__k__BackingField == null)
				{
					r_F__0__Factory__1__k__BackingField = new(typeof(System.Threading.Tasks.Task), "<Factory>k__BackingField");
				}
				return r_F__0__Factory__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task <CompletedTask>k__BackingField
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask r_F__0__CompletedTask__1__k__BackingField;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask RF__0__CompletedTask__1__k__BackingField
		{
			get
			{
				if(r_F__0__CompletedTask__1__k__BackingField == null)
				{
					r_F__0__CompletedTask__1__k__BackingField = new(typeof(System.Threading.Tasks.Task), "<CompletedTask>k__BackingField");
				}
				return r_F__0__CompletedTask__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Predicate`1[System.Threading.Tasks.Task] s_IsExceptionObservedByParentPredicate
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RPredicate<Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask> r_Fs_IsExceptionObservedByParentPredicate;
		public static Hvak.Editor.Refleaction.RSystem.RPredicate<Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask> RFs_IsExceptionObservedByParentPredicate
		{
			get
			{
				if(r_Fs_IsExceptionObservedByParentPredicate == null)
				{
					r_Fs_IsExceptionObservedByParentPredicate = new(typeof(System.Threading.Tasks.Task), "s_IsExceptionObservedByParentPredicate");
				}
				return r_Fs_IsExceptionObservedByParentPredicate;
			}
		}

		/// <summary>
		/// System.Threading.ContextCallback s_ecCallback
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RContextCallback r_Fs_ecCallback;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RContextCallback RFs_ecCallback
		{
			get
			{
				if(r_Fs_ecCallback == null)
				{
					r_Fs_ecCallback = new(typeof(System.Threading.Tasks.Task), "s_ecCallback");
				}
				return r_Fs_ecCallback;
			}
		}

		/// <summary>
		/// System.Predicate`1[System.Object] s_IsTaskContinuationNullPredicate
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RPredicate<Hvak.Editor.Refleaction.RSystem.RObject> r_Fs_IsTaskContinuationNullPredicate;
		public static Hvak.Editor.Refleaction.RSystem.RPredicate<Hvak.Editor.Refleaction.RSystem.RObject> RFs_IsTaskContinuationNullPredicate
		{
			get
			{
				if(r_Fs_IsTaskContinuationNullPredicate == null)
				{
					r_Fs_IsTaskContinuationNullPredicate = new(typeof(System.Threading.Tasks.Task), "s_IsTaskContinuationNullPredicate");
				}
				return r_Fs_IsTaskContinuationNullPredicate;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,System.Threading.Tasks.Task] s_currentActiveTasks
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RInt32, Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask> r_Fs_currentActiveTasks;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RInt32, Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask> RFs_currentActiveTasks
		{
			get
			{
				if(r_Fs_currentActiveTasks == null)
				{
					r_Fs_currentActiveTasks = new(typeof(System.Threading.Tasks.Task), "s_currentActiveTasks");
				}
				return r_Fs_currentActiveTasks;
			}
		}

		/// <summary>
		/// System.Object s_activeTasksLock
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RObject r_Fs_activeTasksLock;
		public static Hvak.Editor.Refleaction.RSystem.RObject RFs_activeTasksLock
		{
			get
			{
				if(r_Fs_activeTasksLock == null)
				{
					r_Fs_activeTasksLock = new(typeof(System.Threading.Tasks.Task), "s_activeTasksLock");
				}
				return r_Fs_activeTasksLock;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ParentForDebugger
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask r_PParentForDebugger;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask RPParentForDebugger
		{
			get
			{
				if(r_PParentForDebugger == null)
				{
					r_PParentForDebugger = new(this, "ParentForDebugger", -1);
				}
				return r_PParentForDebugger;
			}
		}

		/// <summary>
		/// Int32 StateFlagsForDebugger
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PStateFlagsForDebugger;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPStateFlagsForDebugger
		{
			get
			{
				if(r_PStateFlagsForDebugger == null)
				{
					r_PStateFlagsForDebugger = new(this, "StateFlagsForDebugger", -1);
				}
				return r_PStateFlagsForDebugger;
			}
		}

		/// <summary>
		/// System.String DebuggerDisplayMethodDescription
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PDebuggerDisplayMethodDescription;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPDebuggerDisplayMethodDescription
		{
			get
			{
				if(r_PDebuggerDisplayMethodDescription == null)
				{
					r_PDebuggerDisplayMethodDescription = new(this, "DebuggerDisplayMethodDescription", -1);
				}
				return r_PDebuggerDisplayMethodDescription;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskCreationOptions Options
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskCreationOptions r_POptions;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskCreationOptions RPOptions
		{
			get
			{
				if(r_POptions == null)
				{
					r_POptions = new(this, "Options", -1);
				}
				return r_POptions;
			}
		}

		/// <summary>
		/// Boolean IsWaitNotificationEnabledOrNotRanToCompletion
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsWaitNotificationEnabledOrNotRanToCompletion;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsWaitNotificationEnabledOrNotRanToCompletion
		{
			get
			{
				if(r_PIsWaitNotificationEnabledOrNotRanToCompletion == null)
				{
					r_PIsWaitNotificationEnabledOrNotRanToCompletion = new(this, "IsWaitNotificationEnabledOrNotRanToCompletion", -1);
				}
				return r_PIsWaitNotificationEnabledOrNotRanToCompletion;
			}
		}

		/// <summary>
		/// Boolean ShouldNotifyDebuggerOfWaitCompletion
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PShouldNotifyDebuggerOfWaitCompletion;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPShouldNotifyDebuggerOfWaitCompletion
		{
			get
			{
				if(r_PShouldNotifyDebuggerOfWaitCompletion == null)
				{
					r_PShouldNotifyDebuggerOfWaitCompletion = new(this, "ShouldNotifyDebuggerOfWaitCompletion", -1);
				}
				return r_PShouldNotifyDebuggerOfWaitCompletion;
			}
		}

		/// <summary>
		/// Boolean IsWaitNotificationEnabled
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsWaitNotificationEnabled;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsWaitNotificationEnabled
		{
			get
			{
				if(r_PIsWaitNotificationEnabled == null)
				{
					r_PIsWaitNotificationEnabled = new(this, "IsWaitNotificationEnabled", -1);
				}
				return r_PIsWaitNotificationEnabled;
			}
		}

		/// <summary>
		/// Int32 Id
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PId;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPId
		{
			get
			{
				if(r_PId == null)
				{
					r_PId = new(this, "Id", -1);
				}
				return r_PId;
			}
		}

		/// <summary>
		/// System.Nullable`1[System.Int32] CurrentId
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RSystem.RInt32> r_PCurrentId;
		public static Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RSystem.RInt32> RPCurrentId
		{
			get
			{
				if(r_PCurrentId == null)
				{
					r_PCurrentId = new(typeof(System.Threading.Tasks.Task), "CurrentId", -1);
				}
				return r_PCurrentId;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task InternalCurrent
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask r_PInternalCurrent;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask RPInternalCurrent
		{
			get
			{
				if(r_PInternalCurrent == null)
				{
					r_PInternalCurrent = new(typeof(System.Threading.Tasks.Task), "InternalCurrent", -1);
				}
				return r_PInternalCurrent;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.StackGuard CurrentStackGuard
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RStackGuard r_PCurrentStackGuard;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RStackGuard RPCurrentStackGuard
		{
			get
			{
				if(r_PCurrentStackGuard == null)
				{
					r_PCurrentStackGuard = new(typeof(System.Threading.Tasks.Task), "CurrentStackGuard", -1);
				}
				return r_PCurrentStackGuard;
			}
		}

		/// <summary>
		/// System.AggregateException Exception
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAggregateException r_PException;
		public virtual Hvak.Editor.Refleaction.RSystem.RAggregateException RPException
		{
			get
			{
				if(r_PException == null)
				{
					r_PException = new(this, "Exception", -1);
				}
				return r_PException;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskStatus Status
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskStatus r_PStatus;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskStatus RPStatus
		{
			get
			{
				if(r_PStatus == null)
				{
					r_PStatus = new(this, "Status", -1);
				}
				return r_PStatus;
			}
		}

		/// <summary>
		/// Boolean IsCanceled
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsCanceled;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsCanceled
		{
			get
			{
				if(r_PIsCanceled == null)
				{
					r_PIsCanceled = new(this, "IsCanceled", -1);
				}
				return r_PIsCanceled;
			}
		}

		/// <summary>
		/// Boolean IsCancellationRequested
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsCancellationRequested;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsCancellationRequested
		{
			get
			{
				if(r_PIsCancellationRequested == null)
				{
					r_PIsCancellationRequested = new(this, "IsCancellationRequested", -1);
				}
				return r_PIsCancellationRequested;
			}
		}

		/// <summary>
		/// System.Threading.CancellationToken CancellationToken
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RCancellationToken r_PCancellationToken;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RCancellationToken RPCancellationToken
		{
			get
			{
				if(r_PCancellationToken == null)
				{
					r_PCancellationToken = new(this, "CancellationToken", -1);
				}
				return r_PCancellationToken;
			}
		}

		/// <summary>
		/// Boolean IsCancellationAcknowledged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsCancellationAcknowledged;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsCancellationAcknowledged
		{
			get
			{
				if(r_PIsCancellationAcknowledged == null)
				{
					r_PIsCancellationAcknowledged = new(this, "IsCancellationAcknowledged", -1);
				}
				return r_PIsCancellationAcknowledged;
			}
		}

		/// <summary>
		/// Boolean IsCompleted
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsCompleted;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsCompleted
		{
			get
			{
				if(r_PIsCompleted == null)
				{
					r_PIsCompleted = new(this, "IsCompleted", -1);
				}
				return r_PIsCompleted;
			}
		}

		/// <summary>
		/// Boolean IsCompletedSuccessfully
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsCompletedSuccessfully;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsCompletedSuccessfully
		{
			get
			{
				if(r_PIsCompletedSuccessfully == null)
				{
					r_PIsCompletedSuccessfully = new(this, "IsCompletedSuccessfully", -1);
				}
				return r_PIsCompletedSuccessfully;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskCreationOptions CreationOptions
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskCreationOptions r_PCreationOptions;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskCreationOptions RPCreationOptions
		{
			get
			{
				if(r_PCreationOptions == null)
				{
					r_PCreationOptions = new(this, "CreationOptions", -1);
				}
				return r_PCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.WaitHandle System.IAsyncResult.AsyncWaitHandle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RWaitHandle r_PSystem__2__IAsyncResult__2__AsyncWaitHandle;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RWaitHandle RPSystem__2__IAsyncResult__2__AsyncWaitHandle
		{
			get
			{
				if(r_PSystem__2__IAsyncResult__2__AsyncWaitHandle == null)
				{
					r_PSystem__2__IAsyncResult__2__AsyncWaitHandle = new(this, "System.IAsyncResult.AsyncWaitHandle", -1);
				}
				return r_PSystem__2__IAsyncResult__2__AsyncWaitHandle;
			}
		}

		/// <summary>
		/// System.Object AsyncState
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PAsyncState;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPAsyncState
		{
			get
			{
				if(r_PAsyncState == null)
				{
					r_PAsyncState = new(this, "AsyncState", -1);
				}
				return r_PAsyncState;
			}
		}

		/// <summary>
		/// Boolean System.IAsyncResult.CompletedSynchronously
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PSystem__2__IAsyncResult__2__CompletedSynchronously;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPSystem__2__IAsyncResult__2__CompletedSynchronously
		{
			get
			{
				if(r_PSystem__2__IAsyncResult__2__CompletedSynchronously == null)
				{
					r_PSystem__2__IAsyncResult__2__CompletedSynchronously = new(this, "System.IAsyncResult.CompletedSynchronously", -1);
				}
				return r_PSystem__2__IAsyncResult__2__CompletedSynchronously;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskScheduler ExecutingTaskScheduler
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskScheduler r_PExecutingTaskScheduler;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskScheduler RPExecutingTaskScheduler
		{
			get
			{
				if(r_PExecutingTaskScheduler == null)
				{
					r_PExecutingTaskScheduler = new(this, "ExecutingTaskScheduler", -1);
				}
				return r_PExecutingTaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskFactory Factory
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskFactory r_PFactory;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskFactory RPFactory
		{
			get
			{
				if(r_PFactory == null)
				{
					r_PFactory = new(typeof(System.Threading.Tasks.Task), "Factory", -1);
				}
				return r_PFactory;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task CompletedTask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask r_PCompletedTask;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask RPCompletedTask
		{
			get
			{
				if(r_PCompletedTask == null)
				{
					r_PCompletedTask = new(typeof(System.Threading.Tasks.Task), "CompletedTask", -1);
				}
				return r_PCompletedTask;
			}
		}

		/// <summary>
		/// System.Threading.ManualResetEventSlim CompletedEvent
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RManualResetEventSlim r_PCompletedEvent;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RManualResetEventSlim RPCompletedEvent
		{
			get
			{
				if(r_PCompletedEvent == null)
				{
					r_PCompletedEvent = new(this, "CompletedEvent", -1);
				}
				return r_PCompletedEvent;
			}
		}

		/// <summary>
		/// Boolean ExceptionRecorded
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PExceptionRecorded;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPExceptionRecorded
		{
			get
			{
				if(r_PExceptionRecorded == null)
				{
					r_PExceptionRecorded = new(this, "ExceptionRecorded", -1);
				}
				return r_PExceptionRecorded;
			}
		}

		/// <summary>
		/// Boolean IsFaulted
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsFaulted;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsFaulted
		{
			get
			{
				if(r_PIsFaulted == null)
				{
					r_PIsFaulted = new(this, "IsFaulted", -1);
				}
				return r_PIsFaulted;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext CapturedContext
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RExecutionContext r_PCapturedContext;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RExecutionContext RPCapturedContext
		{
			get
			{
				if(r_PCapturedContext == null)
				{
					r_PCapturedContext = new(this, "CapturedContext", -1);
				}
				return r_PCapturedContext;
			}
		}

		/// <summary>
		/// Boolean IsExceptionObservedByParent
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsExceptionObservedByParent;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsExceptionObservedByParent
		{
			get
			{
				if(r_PIsExceptionObservedByParent == null)
				{
					r_PIsExceptionObservedByParent = new(this, "IsExceptionObservedByParent", -1);
				}
				return r_PIsExceptionObservedByParent;
			}
		}

		/// <summary>
		/// Boolean IsDelegateInvoked
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsDelegateInvoked;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsDelegateInvoked
		{
			get
			{
				if(r_PIsDelegateInvoked == null)
				{
					r_PIsDelegateInvoked = new(this, "IsDelegateInvoked", -1);
				}
				return r_PIsDelegateInvoked;
			}
		}

		/// <summary>
		/// Void TaskConstructorCore(System.Delegate, System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.InternalTaskOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_MTaskConstructorCore_Delegate_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler;
		public virtual RMethod RMTaskConstructorCore_Delegate_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler
		{
			get
			{
				if(r_MTaskConstructorCore_Delegate_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler == null)
				{
					r_MTaskConstructorCore_Delegate_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler = new(this, "TaskConstructorCore", 0, typeof(System.Delegate), typeof(System.Object), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskCreationOptions),  ReflectionUtils.GetType("System.Threading.Tasks.InternalTaskOptions"), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MTaskConstructorCore_Delegate_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// Void AssignCancellationToken(System.Threading.CancellationToken, System.Threading.Tasks.Task, System.Threading.Tasks.TaskContinuation)
		/// </summary>
		protected RMethod r_MAssignCancellationToken_CancellationToken_Task_TaskContinuation;
		public virtual RMethod RMAssignCancellationToken_CancellationToken_Task_TaskContinuation
		{
			get
			{
				if(r_MAssignCancellationToken_CancellationToken_Task_TaskContinuation == null)
				{
					r_MAssignCancellationToken_CancellationToken_Task_TaskContinuation = new(this, "AssignCancellationToken", 0, typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.Task),  ReflectionUtils.GetType("System.Threading.Tasks.TaskContinuation"));
				}
				return r_MAssignCancellationToken_CancellationToken_Task_TaskContinuation;
			}
		}

		/// <summary>
		/// Void TaskCancelCallback(System.Object)
		/// </summary>
		protected static RMethod r_MTaskCancelCallback_Object;
		public static RMethod RMTaskCancelCallback_Object
		{
			get
			{
				if(r_MTaskCancelCallback_Object == null)
				{
					r_MTaskCancelCallback_Object = new(typeof(System.Threading.Tasks.Task), "TaskCancelCallback", 0, typeof(System.Object));
				}
				return r_MTaskCancelCallback_Object;
			}
		}

		/// <summary>
		/// Boolean TrySetCanceled(System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MTrySetCanceled_CancellationToken;
		public virtual RMethod RMTrySetCanceled_CancellationToken
		{
			get
			{
				if(r_MTrySetCanceled_CancellationToken == null)
				{
					r_MTrySetCanceled_CancellationToken = new(this, "TrySetCanceled", 0, typeof(System.Threading.CancellationToken));
				}
				return r_MTrySetCanceled_CancellationToken;
			}
		}

		/// <summary>
		/// Boolean TrySetCanceled(System.Threading.CancellationToken, System.Object)
		/// </summary>
		protected RMethod r_MTrySetCanceled_CancellationToken_Object;
		public virtual RMethod RMTrySetCanceled_CancellationToken_Object
		{
			get
			{
				if(r_MTrySetCanceled_CancellationToken_Object == null)
				{
					r_MTrySetCanceled_CancellationToken_Object = new(this, "TrySetCanceled", 0, typeof(System.Threading.CancellationToken), typeof(System.Object));
				}
				return r_MTrySetCanceled_CancellationToken_Object;
			}
		}

		/// <summary>
		/// Boolean TrySetException(System.Object)
		/// </summary>
		protected RMethod r_MTrySetException_Object;
		public virtual RMethod RMTrySetException_Object
		{
			get
			{
				if(r_MTrySetException_Object == null)
				{
					r_MTrySetException_Object = new(this, "TrySetException", 0, typeof(System.Object));
				}
				return r_MTrySetException_Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskCreationOptions OptionsMethod(Int32)
		/// </summary>
		protected static RMethod r_MOptionsMethod_Int32;
		public static RMethod RMOptionsMethod_Int32
		{
			get
			{
				if(r_MOptionsMethod_Int32 == null)
				{
					r_MOptionsMethod_Int32 = new(typeof(System.Threading.Tasks.Task), "OptionsMethod", 0, typeof(System.Int32));
				}
				return r_MOptionsMethod_Int32;
			}
		}

		/// <summary>
		/// Boolean AtomicStateUpdate(Int32, Int32)
		/// </summary>
		protected RMethod r_MAtomicStateUpdate_Int32_Int32;
		public virtual RMethod RMAtomicStateUpdate_Int32_Int32
		{
			get
			{
				if(r_MAtomicStateUpdate_Int32_Int32 == null)
				{
					r_MAtomicStateUpdate_Int32_Int32 = new(this, "AtomicStateUpdate", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MAtomicStateUpdate_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean AtomicStateUpdate(Int32, Int32, Int32 ByRef)
		/// </summary>
		protected RMethod r_MAtomicStateUpdate_Int32_Int32_Ref_Int32;
		public virtual RMethod RMAtomicStateUpdate_Int32_Int32_Ref_Int32
		{
			get
			{
				if(r_MAtomicStateUpdate_Int32_Int32_Ref_Int32 == null)
				{
					r_MAtomicStateUpdate_Int32_Int32_Ref_Int32 = new(this, "AtomicStateUpdate", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32).MakeByRefType());
				}
				return r_MAtomicStateUpdate_Int32_Int32_Ref_Int32;
			}
		}

		/// <summary>
		/// Void SetNotificationForWaitCompletion(Boolean)
		/// </summary>
		protected RMethod r_MSetNotificationForWaitCompletion_Boolean;
		public virtual RMethod RMSetNotificationForWaitCompletion_Boolean
		{
			get
			{
				if(r_MSetNotificationForWaitCompletion_Boolean == null)
				{
					r_MSetNotificationForWaitCompletion_Boolean = new(this, "SetNotificationForWaitCompletion", 0, typeof(System.Boolean));
				}
				return r_MSetNotificationForWaitCompletion_Boolean;
			}
		}

		/// <summary>
		/// Boolean NotifyDebuggerOfWaitCompletionIfNecessary()
		/// </summary>
		protected RMethod r_MNotifyDebuggerOfWaitCompletionIfNecessary;
		public virtual RMethod RMNotifyDebuggerOfWaitCompletionIfNecessary
		{
			get
			{
				if(r_MNotifyDebuggerOfWaitCompletionIfNecessary == null)
				{
					r_MNotifyDebuggerOfWaitCompletionIfNecessary = new(this, "NotifyDebuggerOfWaitCompletionIfNecessary", 0);
				}
				return r_MNotifyDebuggerOfWaitCompletionIfNecessary;
			}
		}

		/// <summary>
		/// Boolean AnyTaskRequiresNotifyDebuggerOfWaitCompletion(System.Threading.Tasks.Task[])
		/// </summary>
		protected static RMethod r_MAnyTaskRequiresNotifyDebuggerOfWaitCompletion_TaskArray;
		public static RMethod RMAnyTaskRequiresNotifyDebuggerOfWaitCompletion_TaskArray
		{
			get
			{
				if(r_MAnyTaskRequiresNotifyDebuggerOfWaitCompletion_TaskArray == null)
				{
					r_MAnyTaskRequiresNotifyDebuggerOfWaitCompletion_TaskArray = new(typeof(System.Threading.Tasks.Task), "AnyTaskRequiresNotifyDebuggerOfWaitCompletion", 0, typeof(System.Threading.Tasks.Task).MakeArrayType());
				}
				return r_MAnyTaskRequiresNotifyDebuggerOfWaitCompletion_TaskArray;
			}
		}

		/// <summary>
		/// Void NotifyDebuggerOfWaitCompletion()
		/// </summary>
		protected RMethod r_MNotifyDebuggerOfWaitCompletion;
		public virtual RMethod RMNotifyDebuggerOfWaitCompletion
		{
			get
			{
				if(r_MNotifyDebuggerOfWaitCompletion == null)
				{
					r_MNotifyDebuggerOfWaitCompletion = new(this, "NotifyDebuggerOfWaitCompletion", 0);
				}
				return r_MNotifyDebuggerOfWaitCompletion;
			}
		}

		/// <summary>
		/// Boolean MarkStarted()
		/// </summary>
		protected RMethod r_MMarkStarted;
		public virtual RMethod RMMarkStarted
		{
			get
			{
				if(r_MMarkStarted == null)
				{
					r_MMarkStarted = new(this, "MarkStarted", 0);
				}
				return r_MMarkStarted;
			}
		}

		/// <summary>
		/// Void AddNewChild()
		/// </summary>
		protected RMethod r_MAddNewChild;
		public virtual RMethod RMAddNewChild
		{
			get
			{
				if(r_MAddNewChild == null)
				{
					r_MAddNewChild = new(this, "AddNewChild", 0);
				}
				return r_MAddNewChild;
			}
		}

		/// <summary>
		/// Void DisregardChild()
		/// </summary>
		protected RMethod r_MDisregardChild;
		public virtual RMethod RMDisregardChild
		{
			get
			{
				if(r_MDisregardChild == null)
				{
					r_MDisregardChild = new(this, "DisregardChild", 0);
				}
				return r_MDisregardChild;
			}
		}

		/// <summary>
		/// Void Start()
		/// </summary>
		protected RMethod r_MStart;
		public virtual RMethod RMStart
		{
			get
			{
				if(r_MStart == null)
				{
					r_MStart = new(this, "Start", 0);
				}
				return r_MStart;
			}
		}

		/// <summary>
		/// Void Start(System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_MStart_TaskScheduler;
		public virtual RMethod RMStart_TaskScheduler
		{
			get
			{
				if(r_MStart_TaskScheduler == null)
				{
					r_MStart_TaskScheduler = new(this, "Start", 0, typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MStart_TaskScheduler;
			}
		}

		/// <summary>
		/// Void RunSynchronously()
		/// </summary>
		protected RMethod r_MRunSynchronously;
		public virtual RMethod RMRunSynchronously
		{
			get
			{
				if(r_MRunSynchronously == null)
				{
					r_MRunSynchronously = new(this, "RunSynchronously", 0);
				}
				return r_MRunSynchronously;
			}
		}

		/// <summary>
		/// Void RunSynchronously(System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_MRunSynchronously_TaskScheduler;
		public virtual RMethod RMRunSynchronously_TaskScheduler
		{
			get
			{
				if(r_MRunSynchronously_TaskScheduler == null)
				{
					r_MRunSynchronously_TaskScheduler = new(this, "RunSynchronously", 0, typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MRunSynchronously_TaskScheduler;
			}
		}

		/// <summary>
		/// Void InternalRunSynchronously(System.Threading.Tasks.TaskScheduler, Boolean)
		/// </summary>
		protected RMethod r_MInternalRunSynchronously_TaskScheduler_Boolean;
		public virtual RMethod RMInternalRunSynchronously_TaskScheduler_Boolean
		{
			get
			{
				if(r_MInternalRunSynchronously_TaskScheduler_Boolean == null)
				{
					r_MInternalRunSynchronously_TaskScheduler_Boolean = new(this, "InternalRunSynchronously", 0, typeof(System.Threading.Tasks.TaskScheduler), typeof(System.Boolean));
				}
				return r_MInternalRunSynchronously_TaskScheduler_Boolean;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task InternalStartNew(System.Threading.Tasks.Task, System.Delegate, System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskScheduler, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.InternalTaskOptions)
		/// </summary>
		protected static RMethod r_MInternalStartNew_Task_Delegate_Object_CancellationToken_TaskScheduler_TaskCreationOptions_InternalTaskOptions;
		public static RMethod RMInternalStartNew_Task_Delegate_Object_CancellationToken_TaskScheduler_TaskCreationOptions_InternalTaskOptions
		{
			get
			{
				if(r_MInternalStartNew_Task_Delegate_Object_CancellationToken_TaskScheduler_TaskCreationOptions_InternalTaskOptions == null)
				{
					r_MInternalStartNew_Task_Delegate_Object_CancellationToken_TaskScheduler_TaskCreationOptions_InternalTaskOptions = new(typeof(System.Threading.Tasks.Task), "InternalStartNew", 0, typeof(System.Threading.Tasks.Task), typeof(System.Delegate), typeof(System.Object), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskScheduler), typeof(System.Threading.Tasks.TaskCreationOptions),  ReflectionUtils.GetType("System.Threading.Tasks.InternalTaskOptions"));
				}
				return r_MInternalStartNew_Task_Delegate_Object_CancellationToken_TaskScheduler_TaskCreationOptions_InternalTaskOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task InternalCurrentIfAttached(System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected static RMethod r_MInternalCurrentIfAttached_TaskCreationOptions;
		public static RMethod RMInternalCurrentIfAttached_TaskCreationOptions
		{
			get
			{
				if(r_MInternalCurrentIfAttached_TaskCreationOptions == null)
				{
					r_MInternalCurrentIfAttached_TaskCreationOptions = new(typeof(System.Threading.Tasks.Task), "InternalCurrentIfAttached", 0, typeof(System.Threading.Tasks.TaskCreationOptions));
				}
				return r_MInternalCurrentIfAttached_TaskCreationOptions;
			}
		}

		/// <summary>
		/// ContingentProperties EnsureContingentPropertiesInitialized(Boolean)
		/// </summary>
		protected RMethod r_MEnsureContingentPropertiesInitialized_Boolean;
		public virtual RMethod RMEnsureContingentPropertiesInitialized_Boolean
		{
			get
			{
				if(r_MEnsureContingentPropertiesInitialized_Boolean == null)
				{
					r_MEnsureContingentPropertiesInitialized_Boolean = new(this, "EnsureContingentPropertiesInitialized", 0, typeof(System.Boolean));
				}
				return r_MEnsureContingentPropertiesInitialized_Boolean;
			}
		}

		/// <summary>
		/// ContingentProperties EnsureContingentPropertiesInitializedCore(Boolean)
		/// </summary>
		protected RMethod r_MEnsureContingentPropertiesInitializedCore_Boolean;
		public virtual RMethod RMEnsureContingentPropertiesInitializedCore_Boolean
		{
			get
			{
				if(r_MEnsureContingentPropertiesInitializedCore_Boolean == null)
				{
					r_MEnsureContingentPropertiesInitializedCore_Boolean = new(this, "EnsureContingentPropertiesInitializedCore", 0, typeof(System.Boolean));
				}
				return r_MEnsureContingentPropertiesInitializedCore_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsCompletedMethod(Int32)
		/// </summary>
		protected static RMethod r_MIsCompletedMethod_Int32;
		public static RMethod RMIsCompletedMethod_Int32
		{
			get
			{
				if(r_MIsCompletedMethod_Int32 == null)
				{
					r_MIsCompletedMethod_Int32 = new(typeof(System.Threading.Tasks.Task), "IsCompletedMethod", 0, typeof(System.Int32));
				}
				return r_MIsCompletedMethod_Int32;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_MDispose;
		public virtual RMethod RMDispose
		{
			get
			{
				if(r_MDispose == null)
				{
					r_MDispose = new(this, "Dispose", 0);
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_MDispose_Boolean;
		public virtual RMethod RMDispose_Boolean
		{
			get
			{
				if(r_MDispose_Boolean == null)
				{
					r_MDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
				}
				return r_MDispose_Boolean;
			}
		}

		/// <summary>
		/// Void ScheduleAndStart(Boolean)
		/// </summary>
		protected RMethod r_MScheduleAndStart_Boolean;
		public virtual RMethod RMScheduleAndStart_Boolean
		{
			get
			{
				if(r_MScheduleAndStart_Boolean == null)
				{
					r_MScheduleAndStart_Boolean = new(this, "ScheduleAndStart", 0, typeof(System.Boolean));
				}
				return r_MScheduleAndStart_Boolean;
			}
		}

		/// <summary>
		/// Void AddException(System.Object)
		/// </summary>
		protected RMethod r_MAddException_Object;
		public virtual RMethod RMAddException_Object
		{
			get
			{
				if(r_MAddException_Object == null)
				{
					r_MAddException_Object = new(this, "AddException", 0, typeof(System.Object));
				}
				return r_MAddException_Object;
			}
		}

		/// <summary>
		/// Void AddException(System.Object, Boolean)
		/// </summary>
		protected RMethod r_MAddException_Object_Boolean;
		public virtual RMethod RMAddException_Object_Boolean
		{
			get
			{
				if(r_MAddException_Object_Boolean == null)
				{
					r_MAddException_Object_Boolean = new(this, "AddException", 0, typeof(System.Object), typeof(System.Boolean));
				}
				return r_MAddException_Object_Boolean;
			}
		}

		/// <summary>
		/// System.AggregateException GetExceptions(Boolean)
		/// </summary>
		protected RMethod r_MGetExceptions_Boolean;
		public virtual RMethod RMGetExceptions_Boolean
		{
			get
			{
				if(r_MGetExceptions_Boolean == null)
				{
					r_MGetExceptions_Boolean = new(this, "GetExceptions", 0, typeof(System.Boolean));
				}
				return r_MGetExceptions_Boolean;
			}
		}

		/// <summary>
		/// System.Collections.ObjectModel.ReadOnlyCollection`1[System.Runtime.ExceptionServices.ExceptionDispatchInfo] GetExceptionDispatchInfos()
		/// </summary>
		protected RMethod r_MGetExceptionDispatchInfos;
		public virtual RMethod RMGetExceptionDispatchInfos
		{
			get
			{
				if(r_MGetExceptionDispatchInfos == null)
				{
					r_MGetExceptionDispatchInfos = new(this, "GetExceptionDispatchInfos", 0);
				}
				return r_MGetExceptionDispatchInfos;
			}
		}

		/// <summary>
		/// System.Runtime.ExceptionServices.ExceptionDispatchInfo GetCancellationExceptionDispatchInfo()
		/// </summary>
		protected RMethod r_MGetCancellationExceptionDispatchInfo;
		public virtual RMethod RMGetCancellationExceptionDispatchInfo
		{
			get
			{
				if(r_MGetCancellationExceptionDispatchInfo == null)
				{
					r_MGetCancellationExceptionDispatchInfo = new(this, "GetCancellationExceptionDispatchInfo", 0);
				}
				return r_MGetCancellationExceptionDispatchInfo;
			}
		}

		/// <summary>
		/// Void ThrowIfExceptional(Boolean)
		/// </summary>
		protected RMethod r_MThrowIfExceptional_Boolean;
		public virtual RMethod RMThrowIfExceptional_Boolean
		{
			get
			{
				if(r_MThrowIfExceptional_Boolean == null)
				{
					r_MThrowIfExceptional_Boolean = new(this, "ThrowIfExceptional", 0, typeof(System.Boolean));
				}
				return r_MThrowIfExceptional_Boolean;
			}
		}

		/// <summary>
		/// Void UpdateExceptionObservedStatus()
		/// </summary>
		protected RMethod r_MUpdateExceptionObservedStatus;
		public virtual RMethod RMUpdateExceptionObservedStatus
		{
			get
			{
				if(r_MUpdateExceptionObservedStatus == null)
				{
					r_MUpdateExceptionObservedStatus = new(this, "UpdateExceptionObservedStatus", 0);
				}
				return r_MUpdateExceptionObservedStatus;
			}
		}

		/// <summary>
		/// Void Finish(Boolean)
		/// </summary>
		protected RMethod r_MFinish_Boolean;
		public virtual RMethod RMFinish_Boolean
		{
			get
			{
				if(r_MFinish_Boolean == null)
				{
					r_MFinish_Boolean = new(this, "Finish", 0, typeof(System.Boolean));
				}
				return r_MFinish_Boolean;
			}
		}

		/// <summary>
		/// Void FinishStageTwo()
		/// </summary>
		protected RMethod r_MFinishStageTwo;
		public virtual RMethod RMFinishStageTwo
		{
			get
			{
				if(r_MFinishStageTwo == null)
				{
					r_MFinishStageTwo = new(this, "FinishStageTwo", 0);
				}
				return r_MFinishStageTwo;
			}
		}

		/// <summary>
		/// Void FinishStageThree()
		/// </summary>
		protected RMethod r_MFinishStageThree;
		public virtual RMethod RMFinishStageThree
		{
			get
			{
				if(r_MFinishStageThree == null)
				{
					r_MFinishStageThree = new(this, "FinishStageThree", 0);
				}
				return r_MFinishStageThree;
			}
		}

		/// <summary>
		/// Void ProcessChildCompletion(System.Threading.Tasks.Task)
		/// </summary>
		protected RMethod r_MProcessChildCompletion_Task;
		public virtual RMethod RMProcessChildCompletion_Task
		{
			get
			{
				if(r_MProcessChildCompletion_Task == null)
				{
					r_MProcessChildCompletion_Task = new(this, "ProcessChildCompletion", 0, typeof(System.Threading.Tasks.Task));
				}
				return r_MProcessChildCompletion_Task;
			}
		}

		/// <summary>
		/// Void AddExceptionsFromChildren()
		/// </summary>
		protected RMethod r_MAddExceptionsFromChildren;
		public virtual RMethod RMAddExceptionsFromChildren
		{
			get
			{
				if(r_MAddExceptionsFromChildren == null)
				{
					r_MAddExceptionsFromChildren = new(this, "AddExceptionsFromChildren", 0);
				}
				return r_MAddExceptionsFromChildren;
			}
		}

		/// <summary>
		/// Void Execute()
		/// </summary>
		protected RMethod r_MExecute;
		public virtual RMethod RMExecute
		{
			get
			{
				if(r_MExecute == null)
				{
					r_MExecute = new(this, "Execute", 0);
				}
				return r_MExecute;
			}
		}

		/// <summary>
		/// Void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem()
		/// </summary>
		protected RMethod r_MSystem__2__Threading__2__IThreadPoolWorkItem__2__ExecuteWorkItem;
		public virtual RMethod RMSystem__2__Threading__2__IThreadPoolWorkItem__2__ExecuteWorkItem
		{
			get
			{
				if(r_MSystem__2__Threading__2__IThreadPoolWorkItem__2__ExecuteWorkItem == null)
				{
					r_MSystem__2__Threading__2__IThreadPoolWorkItem__2__ExecuteWorkItem = new(this, "System.Threading.IThreadPoolWorkItem.ExecuteWorkItem", 0);
				}
				return r_MSystem__2__Threading__2__IThreadPoolWorkItem__2__ExecuteWorkItem;
			}
		}

		/// <summary>
		/// Boolean ExecuteEntry(Boolean)
		/// </summary>
		protected RMethod r_MExecuteEntry_Boolean;
		public virtual RMethod RMExecuteEntry_Boolean
		{
			get
			{
				if(r_MExecuteEntry_Boolean == null)
				{
					r_MExecuteEntry_Boolean = new(this, "ExecuteEntry", 0, typeof(System.Boolean));
				}
				return r_MExecuteEntry_Boolean;
			}
		}

		/// <summary>
		/// Void ExecutionContextCallback(System.Object)
		/// </summary>
		protected static RMethod r_MExecutionContextCallback_Object;
		public static RMethod RMExecutionContextCallback_Object
		{
			get
			{
				if(r_MExecutionContextCallback_Object == null)
				{
					r_MExecutionContextCallback_Object = new(typeof(System.Threading.Tasks.Task), "ExecutionContextCallback", 0, typeof(System.Object));
				}
				return r_MExecutionContextCallback_Object;
			}
		}

		/// <summary>
		/// Void InnerInvoke()
		/// </summary>
		protected RMethod r_MInnerInvoke;
		public virtual RMethod RMInnerInvoke
		{
			get
			{
				if(r_MInnerInvoke == null)
				{
					r_MInnerInvoke = new(this, "InnerInvoke", 0);
				}
				return r_MInnerInvoke;
			}
		}

		/// <summary>
		/// Void HandleException(System.Exception)
		/// </summary>
		protected RMethod r_MHandleException_Exception;
		public virtual RMethod RMHandleException_Exception
		{
			get
			{
				if(r_MHandleException_Exception == null)
				{
					r_MHandleException_Exception = new(this, "HandleException", 0, typeof(System.Exception));
				}
				return r_MHandleException_Exception;
			}
		}

		/// <summary>
		/// System.Runtime.CompilerServices.TaskAwaiter GetAwaiter()
		/// </summary>
		protected RMethod r_MGetAwaiter;
		public virtual RMethod RMGetAwaiter
		{
			get
			{
				if(r_MGetAwaiter == null)
				{
					r_MGetAwaiter = new(this, "GetAwaiter", 0);
				}
				return r_MGetAwaiter;
			}
		}

		/// <summary>
		/// System.Runtime.CompilerServices.ConfiguredTaskAwaitable ConfigureAwait(Boolean)
		/// </summary>
		protected RMethod r_MConfigureAwait_Boolean;
		public virtual RMethod RMConfigureAwait_Boolean
		{
			get
			{
				if(r_MConfigureAwait_Boolean == null)
				{
					r_MConfigureAwait_Boolean = new(this, "ConfigureAwait", 0, typeof(System.Boolean));
				}
				return r_MConfigureAwait_Boolean;
			}
		}

		/// <summary>
		/// Void SetContinuationForAwait(System.Action, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MSetContinuationForAwait_Action_Boolean_Boolean;
		public virtual RMethod RMSetContinuationForAwait_Action_Boolean_Boolean
		{
			get
			{
				if(r_MSetContinuationForAwait_Action_Boolean_Boolean == null)
				{
					r_MSetContinuationForAwait_Action_Boolean_Boolean = new(this, "SetContinuationForAwait", 0, typeof(System.Action), typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MSetContinuationForAwait_Action_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Runtime.CompilerServices.YieldAwaitable Yield()
		/// </summary>
		protected static RMethod r_MYield;
		public static RMethod RMYield
		{
			get
			{
				if(r_MYield == null)
				{
					r_MYield = new(typeof(System.Threading.Tasks.Task), "Yield", 0);
				}
				return r_MYield;
			}
		}

		/// <summary>
		/// Void Wait()
		/// </summary>
		protected RMethod r_MWait;
		public virtual RMethod RMWait
		{
			get
			{
				if(r_MWait == null)
				{
					r_MWait = new(this, "Wait", 0);
				}
				return r_MWait;
			}
		}

		/// <summary>
		/// Boolean Wait(System.TimeSpan)
		/// </summary>
		protected RMethod r_MWait_TimeSpan;
		public virtual RMethod RMWait_TimeSpan
		{
			get
			{
				if(r_MWait_TimeSpan == null)
				{
					r_MWait_TimeSpan = new(this, "Wait", 0, typeof(System.TimeSpan));
				}
				return r_MWait_TimeSpan;
			}
		}

		/// <summary>
		/// Void Wait(System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MWait_CancellationToken;
		public virtual RMethod RMWait_CancellationToken
		{
			get
			{
				if(r_MWait_CancellationToken == null)
				{
					r_MWait_CancellationToken = new(this, "Wait", 0, typeof(System.Threading.CancellationToken));
				}
				return r_MWait_CancellationToken;
			}
		}

		/// <summary>
		/// Boolean Wait(Int32)
		/// </summary>
		protected RMethod r_MWait_Int32;
		public virtual RMethod RMWait_Int32
		{
			get
			{
				if(r_MWait_Int32 == null)
				{
					r_MWait_Int32 = new(this, "Wait", 0, typeof(System.Int32));
				}
				return r_MWait_Int32;
			}
		}

		/// <summary>
		/// Boolean Wait(Int32, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MWait_Int32_CancellationToken;
		public virtual RMethod RMWait_Int32_CancellationToken
		{
			get
			{
				if(r_MWait_Int32_CancellationToken == null)
				{
					r_MWait_Int32_CancellationToken = new(this, "Wait", 0, typeof(System.Int32), typeof(System.Threading.CancellationToken));
				}
				return r_MWait_Int32_CancellationToken;
			}
		}

		/// <summary>
		/// Boolean WrappedTryRunInline()
		/// </summary>
		protected RMethod r_MWrappedTryRunInline;
		public virtual RMethod RMWrappedTryRunInline
		{
			get
			{
				if(r_MWrappedTryRunInline == null)
				{
					r_MWrappedTryRunInline = new(this, "WrappedTryRunInline", 0);
				}
				return r_MWrappedTryRunInline;
			}
		}

		/// <summary>
		/// Boolean InternalWait(Int32, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MInternalWait_Int32_CancellationToken;
		public virtual RMethod RMInternalWait_Int32_CancellationToken
		{
			get
			{
				if(r_MInternalWait_Int32_CancellationToken == null)
				{
					r_MInternalWait_Int32_CancellationToken = new(this, "InternalWait", 0, typeof(System.Int32), typeof(System.Threading.CancellationToken));
				}
				return r_MInternalWait_Int32_CancellationToken;
			}
		}

		/// <summary>
		/// Boolean SpinThenBlockingWait(Int32, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MSpinThenBlockingWait_Int32_CancellationToken;
		public virtual RMethod RMSpinThenBlockingWait_Int32_CancellationToken
		{
			get
			{
				if(r_MSpinThenBlockingWait_Int32_CancellationToken == null)
				{
					r_MSpinThenBlockingWait_Int32_CancellationToken = new(this, "SpinThenBlockingWait", 0, typeof(System.Int32), typeof(System.Threading.CancellationToken));
				}
				return r_MSpinThenBlockingWait_Int32_CancellationToken;
			}
		}

		/// <summary>
		/// Boolean SpinWait(Int32)
		/// </summary>
		protected RMethod r_MSpinWait_Int32;
		public virtual RMethod RMSpinWait_Int32
		{
			get
			{
				if(r_MSpinWait_Int32 == null)
				{
					r_MSpinWait_Int32 = new(this, "SpinWait", 0, typeof(System.Int32));
				}
				return r_MSpinWait_Int32;
			}
		}

		/// <summary>
		/// Boolean InternalCancel(Boolean)
		/// </summary>
		protected RMethod r_MInternalCancel_Boolean;
		public virtual RMethod RMInternalCancel_Boolean
		{
			get
			{
				if(r_MInternalCancel_Boolean == null)
				{
					r_MInternalCancel_Boolean = new(this, "InternalCancel", 0, typeof(System.Boolean));
				}
				return r_MInternalCancel_Boolean;
			}
		}

		/// <summary>
		/// Void RecordInternalCancellationRequest()
		/// </summary>
		protected RMethod r_MRecordInternalCancellationRequest;
		public virtual RMethod RMRecordInternalCancellationRequest
		{
			get
			{
				if(r_MRecordInternalCancellationRequest == null)
				{
					r_MRecordInternalCancellationRequest = new(this, "RecordInternalCancellationRequest", 0);
				}
				return r_MRecordInternalCancellationRequest;
			}
		}

		/// <summary>
		/// Void RecordInternalCancellationRequest(System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MRecordInternalCancellationRequest_CancellationToken;
		public virtual RMethod RMRecordInternalCancellationRequest_CancellationToken
		{
			get
			{
				if(r_MRecordInternalCancellationRequest_CancellationToken == null)
				{
					r_MRecordInternalCancellationRequest_CancellationToken = new(this, "RecordInternalCancellationRequest", 0, typeof(System.Threading.CancellationToken));
				}
				return r_MRecordInternalCancellationRequest_CancellationToken;
			}
		}

		/// <summary>
		/// Void RecordInternalCancellationRequest(System.Threading.CancellationToken, System.Object)
		/// </summary>
		protected RMethod r_MRecordInternalCancellationRequest_CancellationToken_Object;
		public virtual RMethod RMRecordInternalCancellationRequest_CancellationToken_Object
		{
			get
			{
				if(r_MRecordInternalCancellationRequest_CancellationToken_Object == null)
				{
					r_MRecordInternalCancellationRequest_CancellationToken_Object = new(this, "RecordInternalCancellationRequest", 0, typeof(System.Threading.CancellationToken), typeof(System.Object));
				}
				return r_MRecordInternalCancellationRequest_CancellationToken_Object;
			}
		}

		/// <summary>
		/// Void CancellationCleanupLogic()
		/// </summary>
		protected RMethod r_MCancellationCleanupLogic;
		public virtual RMethod RMCancellationCleanupLogic
		{
			get
			{
				if(r_MCancellationCleanupLogic == null)
				{
					r_MCancellationCleanupLogic = new(this, "CancellationCleanupLogic", 0);
				}
				return r_MCancellationCleanupLogic;
			}
		}

		/// <summary>
		/// Void SetCancellationAcknowledged()
		/// </summary>
		protected RMethod r_MSetCancellationAcknowledged;
		public virtual RMethod RMSetCancellationAcknowledged
		{
			get
			{
				if(r_MSetCancellationAcknowledged == null)
				{
					r_MSetCancellationAcknowledged = new(this, "SetCancellationAcknowledged", 0);
				}
				return r_MSetCancellationAcknowledged;
			}
		}

		/// <summary>
		/// Void FinishContinuations()
		/// </summary>
		protected RMethod r_MFinishContinuations;
		public virtual RMethod RMFinishContinuations
		{
			get
			{
				if(r_MFinishContinuations == null)
				{
					r_MFinishContinuations = new(this, "FinishContinuations", 0);
				}
				return r_MFinishContinuations;
			}
		}

		/// <summary>
		/// Void LogFinishCompletionNotification()
		/// </summary>
		protected RMethod r_MLogFinishCompletionNotification;
		public virtual RMethod RMLogFinishCompletionNotification
		{
			get
			{
				if(r_MLogFinishCompletionNotification == null)
				{
					r_MLogFinishCompletionNotification = new(this, "LogFinishCompletionNotification", 0);
				}
				return r_MLogFinishCompletionNotification;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task])
		/// </summary>
		protected RMethod r_MContinueWith_Action_d_Task_p_;
		public virtual RMethod RMContinueWith_Action_d_Task_p_
		{
			get
			{
				if(r_MContinueWith_Action_d_Task_p_ == null)
				{
					r_MContinueWith_Action_d_Task_p_ = new(this, "ContinueWith", 0,  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(System.Threading.Tasks.Task)));
				}
				return r_MContinueWith_Action_d_Task_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MContinueWith_Action_d_Task_p__CancellationToken;
		public virtual RMethod RMContinueWith_Action_d_Task_p__CancellationToken
		{
			get
			{
				if(r_MContinueWith_Action_d_Task_p__CancellationToken == null)
				{
					r_MContinueWith_Action_d_Task_p__CancellationToken = new(this, "ContinueWith", 0,  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(System.Threading.Tasks.Task)), typeof(System.Threading.CancellationToken));
				}
				return r_MContinueWith_Action_d_Task_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task], System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_MContinueWith_Action_d_Task_p__TaskScheduler;
		public virtual RMethod RMContinueWith_Action_d_Task_p__TaskScheduler
		{
			get
			{
				if(r_MContinueWith_Action_d_Task_p__TaskScheduler == null)
				{
					r_MContinueWith_Action_d_Task_p__TaskScheduler = new(this, "ContinueWith", 0,  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(System.Threading.Tasks.Task)), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MContinueWith_Action_d_Task_p__TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task], System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_MContinueWith_Action_d_Task_p__TaskContinuationOptions;
		public virtual RMethod RMContinueWith_Action_d_Task_p__TaskContinuationOptions
		{
			get
			{
				if(r_MContinueWith_Action_d_Task_p__TaskContinuationOptions == null)
				{
					r_MContinueWith_Action_d_Task_p__TaskContinuationOptions = new(this, "ContinueWith", 0,  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(System.Threading.Tasks.Task)), typeof(System.Threading.Tasks.TaskContinuationOptions));
				}
				return r_MContinueWith_Action_d_Task_p__TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task], System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_MContinueWith_Action_d_Task_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RMContinueWith_Action_d_Task_p__CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_MContinueWith_Action_d_Task_p__CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_MContinueWith_Action_d_Task_p__CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWith", 0,  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(System.Threading.Tasks.Task)), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MContinueWith_Action_d_Task_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task], System.Threading.Tasks.TaskScheduler, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_MContinueWith_Action_d_Task_p__TaskScheduler_CancellationToken_TaskContinuationOptions;
		public virtual RMethod RMContinueWith_Action_d_Task_p__TaskScheduler_CancellationToken_TaskContinuationOptions
		{
			get
			{
				if(r_MContinueWith_Action_d_Task_p__TaskScheduler_CancellationToken_TaskContinuationOptions == null)
				{
					r_MContinueWith_Action_d_Task_p__TaskScheduler_CancellationToken_TaskContinuationOptions = new(this, "ContinueWith", 0,  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(System.Threading.Tasks.Task)), typeof(System.Threading.Tasks.TaskScheduler), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions));
				}
				return r_MContinueWith_Action_d_Task_p__TaskScheduler_CancellationToken_TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task,System.Object], System.Object)
		/// </summary>
		protected RMethod r_MContinueWith_Action_d_Task_Object_p__Object;
		public virtual RMethod RMContinueWith_Action_d_Task_Object_p__Object
		{
			get
			{
				if(r_MContinueWith_Action_d_Task_Object_p__Object == null)
				{
					r_MContinueWith_Action_d_Task_Object_p__Object = new(this, "ContinueWith", 0,  ReflectionUtils.GetType("System.Action`2").MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object)), typeof(System.Object));
				}
				return r_MContinueWith_Action_d_Task_Object_p__Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task,System.Object], System.Object, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MContinueWith_Action_d_Task_Object_p__Object_CancellationToken;
		public virtual RMethod RMContinueWith_Action_d_Task_Object_p__Object_CancellationToken
		{
			get
			{
				if(r_MContinueWith_Action_d_Task_Object_p__Object_CancellationToken == null)
				{
					r_MContinueWith_Action_d_Task_Object_p__Object_CancellationToken = new(this, "ContinueWith", 0,  ReflectionUtils.GetType("System.Action`2").MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object)), typeof(System.Object), typeof(System.Threading.CancellationToken));
				}
				return r_MContinueWith_Action_d_Task_Object_p__Object_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task,System.Object], System.Object, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_MContinueWith_Action_d_Task_Object_p__Object_TaskScheduler;
		public virtual RMethod RMContinueWith_Action_d_Task_Object_p__Object_TaskScheduler
		{
			get
			{
				if(r_MContinueWith_Action_d_Task_Object_p__Object_TaskScheduler == null)
				{
					r_MContinueWith_Action_d_Task_Object_p__Object_TaskScheduler = new(this, "ContinueWith", 0,  ReflectionUtils.GetType("System.Action`2").MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object)), typeof(System.Object), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MContinueWith_Action_d_Task_Object_p__Object_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task,System.Object], System.Object, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_MContinueWith_Action_d_Task_Object_p__Object_TaskContinuationOptions;
		public virtual RMethod RMContinueWith_Action_d_Task_Object_p__Object_TaskContinuationOptions
		{
			get
			{
				if(r_MContinueWith_Action_d_Task_Object_p__Object_TaskContinuationOptions == null)
				{
					r_MContinueWith_Action_d_Task_Object_p__Object_TaskContinuationOptions = new(this, "ContinueWith", 0,  ReflectionUtils.GetType("System.Action`2").MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object)), typeof(System.Object), typeof(System.Threading.Tasks.TaskContinuationOptions));
				}
				return r_MContinueWith_Action_d_Task_Object_p__Object_TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task,System.Object], System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_MContinueWith_Action_d_Task_Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RMContinueWith_Action_d_Task_Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_MContinueWith_Action_d_Task_Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_MContinueWith_Action_d_Task_Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWith", 0,  ReflectionUtils.GetType("System.Action`2").MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object)), typeof(System.Object), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MContinueWith_Action_d_Task_Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task,System.Object], System.Object, System.Threading.Tasks.TaskScheduler, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_MContinueWith_Action_d_Task_Object_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions;
		public virtual RMethod RMContinueWith_Action_d_Task_Object_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions
		{
			get
			{
				if(r_MContinueWith_Action_d_Task_Object_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions == null)
				{
					r_MContinueWith_Action_d_Task_Object_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions = new(this, "ContinueWith", 0,  ReflectionUtils.GetType("System.Action`2").MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object)), typeof(System.Object), typeof(System.Threading.Tasks.TaskScheduler), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions));
				}
				return r_MContinueWith_Action_d_Task_Object_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`2[System.Threading.Tasks.Task,TResult])
		/// </summary>
		protected RMethod r_MContinueWith_GTResult_Func_d_Task_TResult_p_;
		public virtual RMethod RMContinueWith_GTResult_Func_d_Task_TResult_p_
		{
			get
			{
				if(r_MContinueWith_GTResult_Func_d_Task_TResult_p_ == null)
				{
					r_MContinueWith_GTResult_Func_d_Task_TResult_p_ = new(this, "ContinueWith", 1,  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)));
				}
				return r_MContinueWith_GTResult_Func_d_Task_TResult_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`2[System.Threading.Tasks.Task,TResult], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken;
		public virtual RMethod RMContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken
		{
			get
			{
				if(r_MContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken == null)
				{
					r_MContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken = new(this, "ContinueWith", 1,  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken));
				}
				return r_MContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`2[System.Threading.Tasks.Task,TResult], System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_MContinueWith_GTResult_Func_d_Task_TResult_p__TaskScheduler;
		public virtual RMethod RMContinueWith_GTResult_Func_d_Task_TResult_p__TaskScheduler
		{
			get
			{
				if(r_MContinueWith_GTResult_Func_d_Task_TResult_p__TaskScheduler == null)
				{
					r_MContinueWith_GTResult_Func_d_Task_TResult_p__TaskScheduler = new(this, "ContinueWith", 1,  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MContinueWith_GTResult_Func_d_Task_TResult_p__TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`2[System.Threading.Tasks.Task,TResult], System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_MContinueWith_GTResult_Func_d_Task_TResult_p__TaskContinuationOptions;
		public virtual RMethod RMContinueWith_GTResult_Func_d_Task_TResult_p__TaskContinuationOptions
		{
			get
			{
				if(r_MContinueWith_GTResult_Func_d_Task_TResult_p__TaskContinuationOptions == null)
				{
					r_MContinueWith_GTResult_Func_d_Task_TResult_p__TaskContinuationOptions = new(this, "ContinueWith", 1,  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskContinuationOptions));
				}
				return r_MContinueWith_GTResult_Func_d_Task_TResult_p__TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`2[System.Threading.Tasks.Task,TResult], System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_MContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RMContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_MContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_MContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWith", 1,  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`2[System.Threading.Tasks.Task,TResult], System.Threading.Tasks.TaskScheduler, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_MContinueWith_GTResult_Func_d_Task_TResult_p__TaskScheduler_CancellationToken_TaskContinuationOptions;
		public virtual RMethod RMContinueWith_GTResult_Func_d_Task_TResult_p__TaskScheduler_CancellationToken_TaskContinuationOptions
		{
			get
			{
				if(r_MContinueWith_GTResult_Func_d_Task_TResult_p__TaskScheduler_CancellationToken_TaskContinuationOptions == null)
				{
					r_MContinueWith_GTResult_Func_d_Task_TResult_p__TaskScheduler_CancellationToken_TaskContinuationOptions = new(this, "ContinueWith", 1,  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskScheduler), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions));
				}
				return r_MContinueWith_GTResult_Func_d_Task_TResult_p__TaskScheduler_CancellationToken_TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`3[System.Threading.Tasks.Task,System.Object,TResult], System.Object)
		/// </summary>
		protected RMethod r_MContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object;
		public virtual RMethod RMContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object
		{
			get
			{
				if(r_MContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object == null)
				{
					r_MContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object = new(this, "ContinueWith", 1,  ReflectionUtils.GetType("System.Func`3").MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object));
				}
				return r_MContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`3[System.Threading.Tasks.Task,System.Object,TResult], System.Object, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken;
		public virtual RMethod RMContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken
		{
			get
			{
				if(r_MContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken == null)
				{
					r_MContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken = new(this, "ContinueWith", 1,  ReflectionUtils.GetType("System.Func`3").MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.CancellationToken));
				}
				return r_MContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`3[System.Threading.Tasks.Task,System.Object,TResult], System.Object, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_MContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskScheduler;
		public virtual RMethod RMContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskScheduler
		{
			get
			{
				if(r_MContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskScheduler == null)
				{
					r_MContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskScheduler = new(this, "ContinueWith", 1,  ReflectionUtils.GetType("System.Func`3").MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`3[System.Threading.Tasks.Task,System.Object,TResult], System.Object, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_MContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskContinuationOptions;
		public virtual RMethod RMContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskContinuationOptions
		{
			get
			{
				if(r_MContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskContinuationOptions == null)
				{
					r_MContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskContinuationOptions = new(this, "ContinueWith", 1,  ReflectionUtils.GetType("System.Func`3").MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.Tasks.TaskContinuationOptions));
				}
				return r_MContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`3[System.Threading.Tasks.Task,System.Object,TResult], System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_MContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RMContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_MContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_MContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWith", 1,  ReflectionUtils.GetType("System.Func`3").MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`3[System.Threading.Tasks.Task,System.Object,TResult], System.Object, System.Threading.Tasks.TaskScheduler, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_MContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions;
		public virtual RMethod RMContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions
		{
			get
			{
				if(r_MContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions == null)
				{
					r_MContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions = new(this, "ContinueWith", 1,  ReflectionUtils.GetType("System.Func`3").MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.Tasks.TaskScheduler), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions));
				}
				return r_MContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions;
			}
		}

		/// <summary>
		/// Void CreationOptionsFromContinuationOptions(System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskCreationOptions ByRef, System.Threading.Tasks.InternalTaskOptions ByRef)
		/// </summary>
		protected static RMethod r_MCreationOptionsFromContinuationOptions_TaskContinuationOptions_Out_TaskCreationOptions_Out_InternalTaskOptions;
		public static RMethod RMCreationOptionsFromContinuationOptions_TaskContinuationOptions_Out_TaskCreationOptions_Out_InternalTaskOptions
		{
			get
			{
				if(r_MCreationOptionsFromContinuationOptions_TaskContinuationOptions_Out_TaskCreationOptions_Out_InternalTaskOptions == null)
				{
					r_MCreationOptionsFromContinuationOptions_TaskContinuationOptions_Out_TaskCreationOptions_Out_InternalTaskOptions = new(typeof(System.Threading.Tasks.Task), "CreationOptionsFromContinuationOptions", 0, typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskCreationOptions).MakeByRefType(),  ReflectionUtils.GetType("System.Threading.Tasks.InternalTaskOptions").MakeByRefType());
				}
				return r_MCreationOptionsFromContinuationOptions_TaskContinuationOptions_Out_TaskCreationOptions_Out_InternalTaskOptions;
			}
		}

		/// <summary>
		/// Void ContinueWithCore(System.Threading.Tasks.Task, System.Threading.Tasks.TaskScheduler, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_MContinueWithCore_Task_TaskScheduler_CancellationToken_TaskContinuationOptions;
		public virtual RMethod RMContinueWithCore_Task_TaskScheduler_CancellationToken_TaskContinuationOptions
		{
			get
			{
				if(r_MContinueWithCore_Task_TaskScheduler_CancellationToken_TaskContinuationOptions == null)
				{
					r_MContinueWithCore_Task_TaskScheduler_CancellationToken_TaskContinuationOptions = new(this, "ContinueWithCore", 0, typeof(System.Threading.Tasks.Task), typeof(System.Threading.Tasks.TaskScheduler), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions));
				}
				return r_MContinueWithCore_Task_TaskScheduler_CancellationToken_TaskContinuationOptions;
			}
		}

		/// <summary>
		/// Void AddCompletionAction(System.Threading.Tasks.ITaskCompletionAction)
		/// </summary>
		protected RMethod r_MAddCompletionAction_ITaskCompletionAction;
		public virtual RMethod RMAddCompletionAction_ITaskCompletionAction
		{
			get
			{
				if(r_MAddCompletionAction_ITaskCompletionAction == null)
				{
					r_MAddCompletionAction_ITaskCompletionAction = new(this, "AddCompletionAction", 0,  ReflectionUtils.GetType("System.Threading.Tasks.ITaskCompletionAction"));
				}
				return r_MAddCompletionAction_ITaskCompletionAction;
			}
		}

		/// <summary>
		/// Void AddCompletionAction(System.Threading.Tasks.ITaskCompletionAction, Boolean)
		/// </summary>
		protected RMethod r_MAddCompletionAction_ITaskCompletionAction_Boolean;
		public virtual RMethod RMAddCompletionAction_ITaskCompletionAction_Boolean
		{
			get
			{
				if(r_MAddCompletionAction_ITaskCompletionAction_Boolean == null)
				{
					r_MAddCompletionAction_ITaskCompletionAction_Boolean = new(this, "AddCompletionAction", 0,  ReflectionUtils.GetType("System.Threading.Tasks.ITaskCompletionAction"), typeof(System.Boolean));
				}
				return r_MAddCompletionAction_ITaskCompletionAction_Boolean;
			}
		}

		/// <summary>
		/// Boolean AddTaskContinuationComplex(System.Object, Boolean)
		/// </summary>
		protected RMethod r_MAddTaskContinuationComplex_Object_Boolean;
		public virtual RMethod RMAddTaskContinuationComplex_Object_Boolean
		{
			get
			{
				if(r_MAddTaskContinuationComplex_Object_Boolean == null)
				{
					r_MAddTaskContinuationComplex_Object_Boolean = new(this, "AddTaskContinuationComplex", 0, typeof(System.Object), typeof(System.Boolean));
				}
				return r_MAddTaskContinuationComplex_Object_Boolean;
			}
		}

		/// <summary>
		/// Boolean AddTaskContinuation(System.Object, Boolean)
		/// </summary>
		protected RMethod r_MAddTaskContinuation_Object_Boolean;
		public virtual RMethod RMAddTaskContinuation_Object_Boolean
		{
			get
			{
				if(r_MAddTaskContinuation_Object_Boolean == null)
				{
					r_MAddTaskContinuation_Object_Boolean = new(this, "AddTaskContinuation", 0, typeof(System.Object), typeof(System.Boolean));
				}
				return r_MAddTaskContinuation_Object_Boolean;
			}
		}

		/// <summary>
		/// Void RemoveContinuation(System.Object)
		/// </summary>
		protected RMethod r_MRemoveContinuation_Object;
		public virtual RMethod RMRemoveContinuation_Object
		{
			get
			{
				if(r_MRemoveContinuation_Object == null)
				{
					r_MRemoveContinuation_Object = new(this, "RemoveContinuation", 0, typeof(System.Object));
				}
				return r_MRemoveContinuation_Object;
			}
		}

		/// <summary>
		/// Void WaitAll(System.Threading.Tasks.Task[])
		/// </summary>
		protected static RMethod r_MWaitAll_TaskArray;
		public static RMethod RMWaitAll_TaskArray
		{
			get
			{
				if(r_MWaitAll_TaskArray == null)
				{
					r_MWaitAll_TaskArray = new(typeof(System.Threading.Tasks.Task), "WaitAll", 0, typeof(System.Threading.Tasks.Task).MakeArrayType());
				}
				return r_MWaitAll_TaskArray;
			}
		}

		/// <summary>
		/// Boolean WaitAll(System.Threading.Tasks.Task[], System.TimeSpan)
		/// </summary>
		protected static RMethod r_MWaitAll_TaskArray_TimeSpan;
		public static RMethod RMWaitAll_TaskArray_TimeSpan
		{
			get
			{
				if(r_MWaitAll_TaskArray_TimeSpan == null)
				{
					r_MWaitAll_TaskArray_TimeSpan = new(typeof(System.Threading.Tasks.Task), "WaitAll", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.TimeSpan));
				}
				return r_MWaitAll_TaskArray_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean WaitAll(System.Threading.Tasks.Task[], Int32)
		/// </summary>
		protected static RMethod r_MWaitAll_TaskArray_Int32;
		public static RMethod RMWaitAll_TaskArray_Int32
		{
			get
			{
				if(r_MWaitAll_TaskArray_Int32 == null)
				{
					r_MWaitAll_TaskArray_Int32 = new(typeof(System.Threading.Tasks.Task), "WaitAll", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Int32));
				}
				return r_MWaitAll_TaskArray_Int32;
			}
		}

		/// <summary>
		/// Void WaitAll(System.Threading.Tasks.Task[], System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_MWaitAll_TaskArray_CancellationToken;
		public static RMethod RMWaitAll_TaskArray_CancellationToken
		{
			get
			{
				if(r_MWaitAll_TaskArray_CancellationToken == null)
				{
					r_MWaitAll_TaskArray_CancellationToken = new(typeof(System.Threading.Tasks.Task), "WaitAll", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Threading.CancellationToken));
				}
				return r_MWaitAll_TaskArray_CancellationToken;
			}
		}

		/// <summary>
		/// Boolean WaitAll(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_MWaitAll_TaskArray_Int32_CancellationToken;
		public static RMethod RMWaitAll_TaskArray_Int32_CancellationToken
		{
			get
			{
				if(r_MWaitAll_TaskArray_Int32_CancellationToken == null)
				{
					r_MWaitAll_TaskArray_Int32_CancellationToken = new(typeof(System.Threading.Tasks.Task), "WaitAll", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Int32), typeof(System.Threading.CancellationToken));
				}
				return r_MWaitAll_TaskArray_Int32_CancellationToken;
			}
		}

		/// <summary>
		/// Void AddToList[T](T, System.Collections.Generic.LowLevelListWithIList`1[T] ByRef, Int32)
		/// </summary>
		protected static RMethod r_MAddToList_GT_T_Ref_LowLevelListWithIList_d_T_p__Int32;
		public static RMethod RMAddToList_GT_T_Ref_LowLevelListWithIList_d_T_p__Int32
		{
			get
			{
				if(r_MAddToList_GT_T_Ref_LowLevelListWithIList_d_T_p__Int32 == null)
				{
					r_MAddToList_GT_T_Ref_LowLevelListWithIList_d_T_p__Int32 = new(typeof(System.Threading.Tasks.Task), "AddToList", 1, Type.MakeGenericMethodParameter(0),  ReflectionUtils.GetType("System.Collections.Generic.LowLevelListWithIList`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(System.Int32));
				}
				return r_MAddToList_GT_T_Ref_LowLevelListWithIList_d_T_p__Int32;
			}
		}

		/// <summary>
		/// Boolean WaitAllBlockingCore(System.Collections.Generic.LowLevelListWithIList`1[System.Threading.Tasks.Task], Int32, System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_MWaitAllBlockingCore_LowLevelListWithIList_d_Task_p__Int32_CancellationToken;
		public static RMethod RMWaitAllBlockingCore_LowLevelListWithIList_d_Task_p__Int32_CancellationToken
		{
			get
			{
				if(r_MWaitAllBlockingCore_LowLevelListWithIList_d_Task_p__Int32_CancellationToken == null)
				{
					r_MWaitAllBlockingCore_LowLevelListWithIList_d_Task_p__Int32_CancellationToken = new(typeof(System.Threading.Tasks.Task), "WaitAllBlockingCore", 0,  ReflectionUtils.GetType("System.Collections.Generic.LowLevelListWithIList`1").MakeGenericType(typeof(System.Threading.Tasks.Task)), typeof(System.Int32), typeof(System.Threading.CancellationToken));
				}
				return r_MWaitAllBlockingCore_LowLevelListWithIList_d_Task_p__Int32_CancellationToken;
			}
		}

		/// <summary>
		/// Void AddExceptionsForCompletedTask(System.Collections.Generic.LowLevelListWithIList`1[System.Exception] ByRef, System.Threading.Tasks.Task)
		/// </summary>
		protected static RMethod r_MAddExceptionsForCompletedTask_Ref_LowLevelListWithIList_d_Exception_p__Task;
		public static RMethod RMAddExceptionsForCompletedTask_Ref_LowLevelListWithIList_d_Exception_p__Task
		{
			get
			{
				if(r_MAddExceptionsForCompletedTask_Ref_LowLevelListWithIList_d_Exception_p__Task == null)
				{
					r_MAddExceptionsForCompletedTask_Ref_LowLevelListWithIList_d_Exception_p__Task = new(typeof(System.Threading.Tasks.Task), "AddExceptionsForCompletedTask", 0,  ReflectionUtils.GetType("System.Collections.Generic.LowLevelListWithIList`1").MakeGenericType(typeof(System.Exception)).MakeByRefType(), typeof(System.Threading.Tasks.Task));
				}
				return r_MAddExceptionsForCompletedTask_Ref_LowLevelListWithIList_d_Exception_p__Task;
			}
		}

		/// <summary>
		/// Int32 WaitAny(System.Threading.Tasks.Task[])
		/// </summary>
		protected static RMethod r_MWaitAny_TaskArray;
		public static RMethod RMWaitAny_TaskArray
		{
			get
			{
				if(r_MWaitAny_TaskArray == null)
				{
					r_MWaitAny_TaskArray = new(typeof(System.Threading.Tasks.Task), "WaitAny", 0, typeof(System.Threading.Tasks.Task).MakeArrayType());
				}
				return r_MWaitAny_TaskArray;
			}
		}

		/// <summary>
		/// Int32 WaitAny(System.Threading.Tasks.Task[], System.TimeSpan)
		/// </summary>
		protected static RMethod r_MWaitAny_TaskArray_TimeSpan;
		public static RMethod RMWaitAny_TaskArray_TimeSpan
		{
			get
			{
				if(r_MWaitAny_TaskArray_TimeSpan == null)
				{
					r_MWaitAny_TaskArray_TimeSpan = new(typeof(System.Threading.Tasks.Task), "WaitAny", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.TimeSpan));
				}
				return r_MWaitAny_TaskArray_TimeSpan;
			}
		}

		/// <summary>
		/// Int32 WaitAny(System.Threading.Tasks.Task[], System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_MWaitAny_TaskArray_CancellationToken;
		public static RMethod RMWaitAny_TaskArray_CancellationToken
		{
			get
			{
				if(r_MWaitAny_TaskArray_CancellationToken == null)
				{
					r_MWaitAny_TaskArray_CancellationToken = new(typeof(System.Threading.Tasks.Task), "WaitAny", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Threading.CancellationToken));
				}
				return r_MWaitAny_TaskArray_CancellationToken;
			}
		}

		/// <summary>
		/// Int32 WaitAny(System.Threading.Tasks.Task[], Int32)
		/// </summary>
		protected static RMethod r_MWaitAny_TaskArray_Int32;
		public static RMethod RMWaitAny_TaskArray_Int32
		{
			get
			{
				if(r_MWaitAny_TaskArray_Int32 == null)
				{
					r_MWaitAny_TaskArray_Int32 = new(typeof(System.Threading.Tasks.Task), "WaitAny", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Int32));
				}
				return r_MWaitAny_TaskArray_Int32;
			}
		}

		/// <summary>
		/// Int32 WaitAny(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_MWaitAny_TaskArray_Int32_CancellationToken;
		public static RMethod RMWaitAny_TaskArray_Int32_CancellationToken
		{
			get
			{
				if(r_MWaitAny_TaskArray_Int32_CancellationToken == null)
				{
					r_MWaitAny_TaskArray_Int32_CancellationToken = new(typeof(System.Threading.Tasks.Task), "WaitAny", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Int32), typeof(System.Threading.CancellationToken));
				}
				return r_MWaitAny_TaskArray_Int32_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromResult[TResult](TResult)
		/// </summary>
		protected static RMethod r_MFromResult_GTResult_TResult;
		public static RMethod RMFromResult_GTResult_TResult
		{
			get
			{
				if(r_MFromResult_GTResult_TResult == null)
				{
					r_MFromResult_GTResult_TResult = new(typeof(System.Threading.Tasks.Task), "FromResult", 1, Type.MakeGenericMethodParameter(0));
				}
				return r_MFromResult_GTResult_TResult;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FromException(System.Exception)
		/// </summary>
		protected static RMethod r_MFromException_Exception;
		public static RMethod RMFromException_Exception
		{
			get
			{
				if(r_MFromException_Exception == null)
				{
					r_MFromException_Exception = new(typeof(System.Threading.Tasks.Task), "FromException", 0, typeof(System.Exception));
				}
				return r_MFromException_Exception;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromException[TResult](System.Exception)
		/// </summary>
		protected static RMethod r_MFromException_GTResult_Exception;
		public static RMethod RMFromException_GTResult_Exception
		{
			get
			{
				if(r_MFromException_GTResult_Exception == null)
				{
					r_MFromException_GTResult_Exception = new(typeof(System.Threading.Tasks.Task), "FromException", 1, typeof(System.Exception));
				}
				return r_MFromException_GTResult_Exception;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FromCancellation(System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_MFromCancellation_CancellationToken;
		public static RMethod RMFromCancellation_CancellationToken
		{
			get
			{
				if(r_MFromCancellation_CancellationToken == null)
				{
					r_MFromCancellation_CancellationToken = new(typeof(System.Threading.Tasks.Task), "FromCancellation", 0, typeof(System.Threading.CancellationToken));
				}
				return r_MFromCancellation_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FromCanceled(System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_MFromCanceled_CancellationToken;
		public static RMethod RMFromCanceled_CancellationToken
		{
			get
			{
				if(r_MFromCanceled_CancellationToken == null)
				{
					r_MFromCanceled_CancellationToken = new(typeof(System.Threading.Tasks.Task), "FromCanceled", 0, typeof(System.Threading.CancellationToken));
				}
				return r_MFromCanceled_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromCancellation[TResult](System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_MFromCancellation_GTResult_CancellationToken;
		public static RMethod RMFromCancellation_GTResult_CancellationToken
		{
			get
			{
				if(r_MFromCancellation_GTResult_CancellationToken == null)
				{
					r_MFromCancellation_GTResult_CancellationToken = new(typeof(System.Threading.Tasks.Task), "FromCancellation", 1, typeof(System.Threading.CancellationToken));
				}
				return r_MFromCancellation_GTResult_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromCanceled[TResult](System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_MFromCanceled_GTResult_CancellationToken;
		public static RMethod RMFromCanceled_GTResult_CancellationToken
		{
			get
			{
				if(r_MFromCanceled_GTResult_CancellationToken == null)
				{
					r_MFromCanceled_GTResult_CancellationToken = new(typeof(System.Threading.Tasks.Task), "FromCanceled", 1, typeof(System.Threading.CancellationToken));
				}
				return r_MFromCanceled_GTResult_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromCancellation[TResult](System.OperationCanceledException)
		/// </summary>
		protected static RMethod r_MFromCancellation_GTResult_OperationCanceledException;
		public static RMethod RMFromCancellation_GTResult_OperationCanceledException
		{
			get
			{
				if(r_MFromCancellation_GTResult_OperationCanceledException == null)
				{
					r_MFromCancellation_GTResult_OperationCanceledException = new(typeof(System.Threading.Tasks.Task), "FromCancellation", 1, typeof(System.OperationCanceledException));
				}
				return r_MFromCancellation_GTResult_OperationCanceledException;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task Run(System.Action)
		/// </summary>
		protected static RMethod r_MRun_Action;
		public static RMethod RMRun_Action
		{
			get
			{
				if(r_MRun_Action == null)
				{
					r_MRun_Action = new(typeof(System.Threading.Tasks.Task), "Run", 0, typeof(System.Action));
				}
				return r_MRun_Action;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task Run(System.Action, System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_MRun_Action_CancellationToken;
		public static RMethod RMRun_Action_CancellationToken
		{
			get
			{
				if(r_MRun_Action_CancellationToken == null)
				{
					r_MRun_Action_CancellationToken = new(typeof(System.Threading.Tasks.Task), "Run", 0, typeof(System.Action), typeof(System.Threading.CancellationToken));
				}
				return r_MRun_Action_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] Run[TResult](System.Func`1[TResult])
		/// </summary>
		protected static RMethod r_MRun_GTResult_Func_d_TResult_p_;
		public static RMethod RMRun_GTResult_Func_d_TResult_p_
		{
			get
			{
				if(r_MRun_GTResult_Func_d_TResult_p_ == null)
				{
					r_MRun_GTResult_Func_d_TResult_p_ = new(typeof(System.Threading.Tasks.Task), "Run", 1,  ReflectionUtils.GetType("System.Func`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MRun_GTResult_Func_d_TResult_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] Run[TResult](System.Func`1[TResult], System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_MRun_GTResult_Func_d_TResult_p__CancellationToken;
		public static RMethod RMRun_GTResult_Func_d_TResult_p__CancellationToken
		{
			get
			{
				if(r_MRun_GTResult_Func_d_TResult_p__CancellationToken == null)
				{
					r_MRun_GTResult_Func_d_TResult_p__CancellationToken = new(typeof(System.Threading.Tasks.Task), "Run", 1,  ReflectionUtils.GetType("System.Func`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken));
				}
				return r_MRun_GTResult_Func_d_TResult_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task Run(System.Func`1[System.Threading.Tasks.Task])
		/// </summary>
		protected static RMethod r_MRun_Func_d_Task_p_;
		public static RMethod RMRun_Func_d_Task_p_
		{
			get
			{
				if(r_MRun_Func_d_Task_p_ == null)
				{
					r_MRun_Func_d_Task_p_ = new(typeof(System.Threading.Tasks.Task), "Run", 0,  ReflectionUtils.GetType("System.Func`1").MakeGenericType(typeof(System.Threading.Tasks.Task)));
				}
				return r_MRun_Func_d_Task_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task Run(System.Func`1[System.Threading.Tasks.Task], System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_MRun_Func_d_Task_p__CancellationToken;
		public static RMethod RMRun_Func_d_Task_p__CancellationToken
		{
			get
			{
				if(r_MRun_Func_d_Task_p__CancellationToken == null)
				{
					r_MRun_Func_d_Task_p__CancellationToken = new(typeof(System.Threading.Tasks.Task), "Run", 0,  ReflectionUtils.GetType("System.Func`1").MakeGenericType(typeof(System.Threading.Tasks.Task)), typeof(System.Threading.CancellationToken));
				}
				return r_MRun_Func_d_Task_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] Run[TResult](System.Func`1[System.Threading.Tasks.Task`1[TResult]])
		/// </summary>
		protected static RMethod r_MRun_GTResult_Func_d_Task_d_TResult_p__p_;
		public static RMethod RMRun_GTResult_Func_d_Task_d_TResult_p__p_
		{
			get
			{
				if(r_MRun_GTResult_Func_d_Task_d_TResult_p__p_ == null)
				{
					r_MRun_GTResult_Func_d_Task_d_TResult_p__p_ = new(typeof(System.Threading.Tasks.Task), "Run", 1,  ReflectionUtils.GetType("System.Func`1").MakeGenericType( ReflectionUtils.GetType("System.Threading.Tasks.Task`1").MakeGenericType(Type.MakeGenericMethodParameter(0))));
				}
				return r_MRun_GTResult_Func_d_Task_d_TResult_p__p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] Run[TResult](System.Func`1[System.Threading.Tasks.Task`1[TResult]], System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_MRun_GTResult_Func_d_Task_d_TResult_p__p__CancellationToken;
		public static RMethod RMRun_GTResult_Func_d_Task_d_TResult_p__p__CancellationToken
		{
			get
			{
				if(r_MRun_GTResult_Func_d_Task_d_TResult_p__p__CancellationToken == null)
				{
					r_MRun_GTResult_Func_d_Task_d_TResult_p__p__CancellationToken = new(typeof(System.Threading.Tasks.Task), "Run", 1,  ReflectionUtils.GetType("System.Func`1").MakeGenericType( ReflectionUtils.GetType("System.Threading.Tasks.Task`1").MakeGenericType(Type.MakeGenericMethodParameter(0))), typeof(System.Threading.CancellationToken));
				}
				return r_MRun_GTResult_Func_d_Task_d_TResult_p__p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task Delay(System.TimeSpan)
		/// </summary>
		protected static RMethod r_MDelay_TimeSpan;
		public static RMethod RMDelay_TimeSpan
		{
			get
			{
				if(r_MDelay_TimeSpan == null)
				{
					r_MDelay_TimeSpan = new(typeof(System.Threading.Tasks.Task), "Delay", 0, typeof(System.TimeSpan));
				}
				return r_MDelay_TimeSpan;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task Delay(System.TimeSpan, System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_MDelay_TimeSpan_CancellationToken;
		public static RMethod RMDelay_TimeSpan_CancellationToken
		{
			get
			{
				if(r_MDelay_TimeSpan_CancellationToken == null)
				{
					r_MDelay_TimeSpan_CancellationToken = new(typeof(System.Threading.Tasks.Task), "Delay", 0, typeof(System.TimeSpan), typeof(System.Threading.CancellationToken));
				}
				return r_MDelay_TimeSpan_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task Delay(Int32)
		/// </summary>
		protected static RMethod r_MDelay_Int32;
		public static RMethod RMDelay_Int32
		{
			get
			{
				if(r_MDelay_Int32 == null)
				{
					r_MDelay_Int32 = new(typeof(System.Threading.Tasks.Task), "Delay", 0, typeof(System.Int32));
				}
				return r_MDelay_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task Delay(Int32, System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_MDelay_Int32_CancellationToken;
		public static RMethod RMDelay_Int32_CancellationToken
		{
			get
			{
				if(r_MDelay_Int32_CancellationToken == null)
				{
					r_MDelay_Int32_CancellationToken = new(typeof(System.Threading.Tasks.Task), "Delay", 0, typeof(System.Int32), typeof(System.Threading.CancellationToken));
				}
				return r_MDelay_Int32_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WhenAll(System.Collections.Generic.IEnumerable`1[System.Threading.Tasks.Task])
		/// </summary>
		protected static RMethod r_MWhenAll_IEnumerable_d_Task_p_;
		public static RMethod RMWhenAll_IEnumerable_d_Task_p_
		{
			get
			{
				if(r_MWhenAll_IEnumerable_d_Task_p_ == null)
				{
					r_MWhenAll_IEnumerable_d_Task_p_ = new(typeof(System.Threading.Tasks.Task), "WhenAll", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType(typeof(System.Threading.Tasks.Task)));
				}
				return r_MWhenAll_IEnumerable_d_Task_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WhenAll(System.Threading.Tasks.Task[])
		/// </summary>
		protected static RMethod r_MWhenAll_TaskArray;
		public static RMethod RMWhenAll_TaskArray
		{
			get
			{
				if(r_MWhenAll_TaskArray == null)
				{
					r_MWhenAll_TaskArray = new(typeof(System.Threading.Tasks.Task), "WhenAll", 0, typeof(System.Threading.Tasks.Task).MakeArrayType());
				}
				return r_MWhenAll_TaskArray;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task InternalWhenAll(System.Threading.Tasks.Task[])
		/// </summary>
		protected static RMethod r_MInternalWhenAll_TaskArray;
		public static RMethod RMInternalWhenAll_TaskArray
		{
			get
			{
				if(r_MInternalWhenAll_TaskArray == null)
				{
					r_MInternalWhenAll_TaskArray = new(typeof(System.Threading.Tasks.Task), "InternalWhenAll", 0, typeof(System.Threading.Tasks.Task).MakeArrayType());
				}
				return r_MInternalWhenAll_TaskArray;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult[]] WhenAll[TResult](System.Collections.Generic.IEnumerable`1[System.Threading.Tasks.Task`1[TResult]])
		/// </summary>
		protected static RMethod r_MWhenAll_GTResult_IEnumerable_d_Task_d_TResult_p__p_;
		public static RMethod RMWhenAll_GTResult_IEnumerable_d_Task_d_TResult_p__p_
		{
			get
			{
				if(r_MWhenAll_GTResult_IEnumerable_d_Task_d_TResult_p__p_ == null)
				{
					r_MWhenAll_GTResult_IEnumerable_d_Task_d_TResult_p__p_ = new(typeof(System.Threading.Tasks.Task), "WhenAll", 1,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType( ReflectionUtils.GetType("System.Threading.Tasks.Task`1").MakeGenericType(Type.MakeGenericMethodParameter(0))));
				}
				return r_MWhenAll_GTResult_IEnumerable_d_Task_d_TResult_p__p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult[]] WhenAll[TResult](System.Threading.Tasks.Task`1[TResult][])
		/// </summary>
		protected static RMethod r_MWhenAll_GTResult_Task_d_TResult_p_Array;
		public static RMethod RMWhenAll_GTResult_Task_d_TResult_p_Array
		{
			get
			{
				if(r_MWhenAll_GTResult_Task_d_TResult_p_Array == null)
				{
					r_MWhenAll_GTResult_Task_d_TResult_p_Array = new(typeof(System.Threading.Tasks.Task), "WhenAll", 1,  ReflectionUtils.GetType("System.Threading.Tasks.Task`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType());
				}
				return r_MWhenAll_GTResult_Task_d_TResult_p_Array;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult[]] InternalWhenAll[TResult](System.Threading.Tasks.Task`1[TResult][])
		/// </summary>
		protected static RMethod r_MInternalWhenAll_GTResult_Task_d_TResult_p_Array;
		public static RMethod RMInternalWhenAll_GTResult_Task_d_TResult_p_Array
		{
			get
			{
				if(r_MInternalWhenAll_GTResult_Task_d_TResult_p_Array == null)
				{
					r_MInternalWhenAll_GTResult_Task_d_TResult_p_Array = new(typeof(System.Threading.Tasks.Task), "InternalWhenAll", 1,  ReflectionUtils.GetType("System.Threading.Tasks.Task`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType());
				}
				return r_MInternalWhenAll_GTResult_Task_d_TResult_p_Array;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Threading.Tasks.Task] WhenAny(System.Threading.Tasks.Task[])
		/// </summary>
		protected static RMethod r_MWhenAny_TaskArray;
		public static RMethod RMWhenAny_TaskArray
		{
			get
			{
				if(r_MWhenAny_TaskArray == null)
				{
					r_MWhenAny_TaskArray = new(typeof(System.Threading.Tasks.Task), "WhenAny", 0, typeof(System.Threading.Tasks.Task).MakeArrayType());
				}
				return r_MWhenAny_TaskArray;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Threading.Tasks.Task] WhenAny(System.Collections.Generic.IEnumerable`1[System.Threading.Tasks.Task])
		/// </summary>
		protected static RMethod r_MWhenAny_IEnumerable_d_Task_p_;
		public static RMethod RMWhenAny_IEnumerable_d_Task_p_
		{
			get
			{
				if(r_MWhenAny_IEnumerable_d_Task_p_ == null)
				{
					r_MWhenAny_IEnumerable_d_Task_p_ = new(typeof(System.Threading.Tasks.Task), "WhenAny", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType(typeof(System.Threading.Tasks.Task)));
				}
				return r_MWhenAny_IEnumerable_d_Task_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Threading.Tasks.Task`1[TResult]] WhenAny[TResult](System.Threading.Tasks.Task`1[TResult][])
		/// </summary>
		protected static RMethod r_MWhenAny_GTResult_Task_d_TResult_p_Array;
		public static RMethod RMWhenAny_GTResult_Task_d_TResult_p_Array
		{
			get
			{
				if(r_MWhenAny_GTResult_Task_d_TResult_p_Array == null)
				{
					r_MWhenAny_GTResult_Task_d_TResult_p_Array = new(typeof(System.Threading.Tasks.Task), "WhenAny", 1,  ReflectionUtils.GetType("System.Threading.Tasks.Task`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType());
				}
				return r_MWhenAny_GTResult_Task_d_TResult_p_Array;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Threading.Tasks.Task`1[TResult]] WhenAny[TResult](System.Collections.Generic.IEnumerable`1[System.Threading.Tasks.Task`1[TResult]])
		/// </summary>
		protected static RMethod r_MWhenAny_GTResult_IEnumerable_d_Task_d_TResult_p__p_;
		public static RMethod RMWhenAny_GTResult_IEnumerable_d_Task_d_TResult_p__p_
		{
			get
			{
				if(r_MWhenAny_GTResult_IEnumerable_d_Task_d_TResult_p__p_ == null)
				{
					r_MWhenAny_GTResult_IEnumerable_d_Task_d_TResult_p__p_ = new(typeof(System.Threading.Tasks.Task), "WhenAny", 1,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType( ReflectionUtils.GetType("System.Threading.Tasks.Task`1").MakeGenericType(Type.MakeGenericMethodParameter(0))));
				}
				return r_MWhenAny_GTResult_IEnumerable_d_Task_d_TResult_p__p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] CreateUnwrapPromise[TResult](System.Threading.Tasks.Task, Boolean)
		/// </summary>
		protected static RMethod r_MCreateUnwrapPromise_GTResult_Task_Boolean;
		public static RMethod RMCreateUnwrapPromise_GTResult_Task_Boolean
		{
			get
			{
				if(r_MCreateUnwrapPromise_GTResult_Task_Boolean == null)
				{
					r_MCreateUnwrapPromise_GTResult_Task_Boolean = new(typeof(System.Threading.Tasks.Task), "CreateUnwrapPromise", 1, typeof(System.Threading.Tasks.Task), typeof(System.Boolean));
				}
				return r_MCreateUnwrapPromise_GTResult_Task_Boolean;
			}
		}

		/// <summary>
		/// System.Delegate[] GetDelegateContinuationsForDebugger()
		/// </summary>
		protected RMethod r_MGetDelegateContinuationsForDebugger;
		public virtual RMethod RMGetDelegateContinuationsForDebugger
		{
			get
			{
				if(r_MGetDelegateContinuationsForDebugger == null)
				{
					r_MGetDelegateContinuationsForDebugger = new(this, "GetDelegateContinuationsForDebugger", 0);
				}
				return r_MGetDelegateContinuationsForDebugger;
			}
		}

		/// <summary>
		/// System.Delegate[] GetDelegatesFromContinuationObject(System.Object)
		/// </summary>
		protected static RMethod r_MGetDelegatesFromContinuationObject_Object;
		public static RMethod RMGetDelegatesFromContinuationObject_Object
		{
			get
			{
				if(r_MGetDelegatesFromContinuationObject_Object == null)
				{
					r_MGetDelegatesFromContinuationObject_Object = new(typeof(System.Threading.Tasks.Task), "GetDelegatesFromContinuationObject", 0, typeof(System.Object));
				}
				return r_MGetDelegatesFromContinuationObject_Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task GetActiveTaskFromId(Int32)
		/// </summary>
		protected static RMethod r_MGetActiveTaskFromId_Int32;
		public static RMethod RMGetActiveTaskFromId_Int32
		{
			get
			{
				if(r_MGetActiveTaskFromId_Int32 == null)
				{
					r_MGetActiveTaskFromId_Int32 = new(typeof(System.Threading.Tasks.Task), "GetActiveTaskFromId", 0, typeof(System.Int32));
				}
				return r_MGetActiveTaskFromId_Int32;
			}
		}

		/// <summary>
		/// Boolean AddToActiveTasks(System.Threading.Tasks.Task)
		/// </summary>
		protected static RMethod r_MAddToActiveTasks_Task;
		public static RMethod RMAddToActiveTasks_Task
		{
			get
			{
				if(r_MAddToActiveTasks_Task == null)
				{
					r_MAddToActiveTasks_Task = new(typeof(System.Threading.Tasks.Task), "AddToActiveTasks", 0, typeof(System.Threading.Tasks.Task));
				}
				return r_MAddToActiveTasks_Task;
			}
		}

		/// <summary>
		/// Void RemoveFromActiveTasks(Int32)
		/// </summary>
		protected static RMethod r_MRemoveFromActiveTasks_Int32;
		public static RMethod RMRemoveFromActiveTasks_Int32
		{
			get
			{
				if(r_MRemoveFromActiveTasks_Int32 == null)
				{
					r_MRemoveFromActiveTasks_Int32 = new(typeof(System.Threading.Tasks.Task), "RemoveFromActiveTasks", 0, typeof(System.Int32));
				}
				return r_MRemoveFromActiveTasks_Int32;
			}
		}

		/// <summary>
		/// Void MarkAborted(System.Threading.ThreadAbortException)
		/// </summary>
		protected RMethod r_MMarkAborted_ThreadAbortException;
		public virtual RMethod RMMarkAborted_ThreadAbortException
		{
			get
			{
				if(r_MMarkAborted_ThreadAbortException == null)
				{
					r_MMarkAborted_ThreadAbortException = new(this, "MarkAborted", 0, typeof(System.Threading.ThreadAbortException));
				}
				return r_MMarkAborted_ThreadAbortException;
			}
		}

		/// <summary>
		/// Void ExecuteWithThreadLocal(System.Threading.Tasks.Task ByRef)
		/// </summary>
		protected RMethod r_MExecuteWithThreadLocal_Ref_Task;
		public virtual RMethod RMExecuteWithThreadLocal_Ref_Task
		{
			get
			{
				if(r_MExecuteWithThreadLocal_Ref_Task == null)
				{
					r_MExecuteWithThreadLocal_Ref_Task = new(this, "ExecuteWithThreadLocal", 0, typeof(System.Threading.Tasks.Task).MakeByRefType());
				}
				return r_MExecuteWithThreadLocal_Ref_Task;
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


        public virtual void TaskConstructorCore(System.Delegate @action, System.Object @state, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskCreationOptions @creationOptions, Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RInternalTaskOptions @internalOptions, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action, @state, @cancellationToken, @creationOptions, @internalOptions.Value, @scheduler};
            var ___result = RMTaskConstructorCore_Delegate_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AssignCancellationToken(System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.Task @antecedent, Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuation @continuation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cancellationToken, @antecedent, @continuation.Value};
            var ___result = RMAssignCancellationToken_CancellationToken_Task_TaskContinuation.Invoke(___genericsType, ___parameters);

            
        }


        public static void TaskCancelCallback(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMTaskCancelCallback_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TrySetCanceled(System.Threading.CancellationToken @tokenToRecord)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tokenToRecord};
            var ___result = RMTrySetCanceled_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TrySetCanceled(System.Threading.CancellationToken @tokenToRecord, System.Object @cancellationException)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tokenToRecord, @cancellationException};
            var ___result = RMTrySetCanceled_CancellationToken_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TrySetException(System.Object @exceptionObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exceptionObject};
            var ___result = RMTrySetException_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Threading.Tasks.TaskCreationOptions OptionsMethod(System.Int32 @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flags};
            var ___result = RMOptionsMethod_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.TaskCreationOptions)___result;
        }


        public virtual System.Boolean AtomicStateUpdate(System.Int32 @newBits, System.Int32 @illegalBits)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newBits, @illegalBits};
            var ___result = RMAtomicStateUpdate_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean AtomicStateUpdate(System.Int32 @newBits, System.Int32 @illegalBits, ref System.Int32 @oldFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newBits, @illegalBits, @oldFlags};
            var ___result = RMAtomicStateUpdate_Int32_Int32_Ref_Int32.Invoke(___genericsType, ___parameters);
			@oldFlags = (System.Int32)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual void SetNotificationForWaitCompletion(System.Boolean @enabled)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enabled};
            var ___result = RMSetNotificationForWaitCompletion_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean NotifyDebuggerOfWaitCompletionIfNecessary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMNotifyDebuggerOfWaitCompletionIfNecessary.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean AnyTaskRequiresNotifyDebuggerOfWaitCompletion(System.Threading.Tasks.Task[] @tasks)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks};
            var ___result = RMAnyTaskRequiresNotifyDebuggerOfWaitCompletion_TaskArray.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void NotifyDebuggerOfWaitCompletion()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMNotifyDebuggerOfWaitCompletion.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean MarkStarted()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMarkStarted.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void AddNewChild()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAddNewChild.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DisregardChild()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDisregardChild.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Start()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMStart.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Start(System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scheduler};
            var ___result = RMStart_TaskScheduler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RunSynchronously()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRunSynchronously.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RunSynchronously(System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scheduler};
            var ___result = RMRunSynchronously_TaskScheduler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalRunSynchronously(System.Threading.Tasks.TaskScheduler @scheduler, System.Boolean @waitForCompletion)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scheduler, @waitForCompletion};
            var ___result = RMInternalRunSynchronously_TaskScheduler_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Threading.Tasks.Task InternalStartNew(System.Threading.Tasks.Task @creatingTask, System.Delegate @action, System.Object @state, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskScheduler @scheduler, System.Threading.Tasks.TaskCreationOptions @options, Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RInternalTaskOptions @internalOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@creatingTask, @action, @state, @cancellationToken, @scheduler, @options, @internalOptions.Value};
            var ___result = RMInternalStartNew_Task_Delegate_Object_CancellationToken_TaskScheduler_TaskCreationOptions_InternalTaskOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public static System.Threading.Tasks.Task InternalCurrentIfAttached(System.Threading.Tasks.TaskCreationOptions @creationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@creationOptions};
            var ___result = RMInternalCurrentIfAttached_TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask.RContingentProperties EnsureContingentPropertiesInitialized(System.Boolean @needsProtection)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@needsProtection};
            var ___result = RMEnsureContingentPropertiesInitialized_Boolean.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask.RContingentProperties(___result);
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask.RContingentProperties EnsureContingentPropertiesInitializedCore(System.Boolean @needsProtection)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@needsProtection};
            var ___result = RMEnsureContingentPropertiesInitializedCore_Boolean.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask.RContingentProperties(___result);
        }


        public static System.Boolean IsCompletedMethod(System.Int32 @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flags};
            var ___result = RMIsCompletedMethod_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RMDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ScheduleAndStart(System.Boolean @needsProtection)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@needsProtection};
            var ___result = RMScheduleAndStart_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddException(System.Object @exceptionObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exceptionObject};
            var ___result = RMAddException_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddException(System.Object @exceptionObject, System.Boolean @representsCancellation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exceptionObject, @representsCancellation};
            var ___result = RMAddException_Object_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.AggregateException GetExceptions(System.Boolean @includeTaskCanceledExceptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@includeTaskCanceledExceptions};
            var ___result = RMGetExceptions_Boolean.Invoke(___genericsType, ___parameters);

            return (System.AggregateException)___result;
        }


        public virtual System.Collections.ObjectModel.ReadOnlyCollection<System.Runtime.ExceptionServices.ExceptionDispatchInfo> GetExceptionDispatchInfos()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetExceptionDispatchInfos.Invoke(___genericsType, ___parameters);

            return (System.Collections.ObjectModel.ReadOnlyCollection<System.Runtime.ExceptionServices.ExceptionDispatchInfo>)___result;
        }


        public virtual System.Runtime.ExceptionServices.ExceptionDispatchInfo GetCancellationExceptionDispatchInfo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCancellationExceptionDispatchInfo.Invoke(___genericsType, ___parameters);

            return (System.Runtime.ExceptionServices.ExceptionDispatchInfo)___result;
        }


        public virtual void ThrowIfExceptional(System.Boolean @includeTaskCanceledExceptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@includeTaskCanceledExceptions};
            var ___result = RMThrowIfExceptional_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateExceptionObservedStatus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateExceptionObservedStatus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Finish(System.Boolean @bUserDelegateExecuted)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bUserDelegateExecuted};
            var ___result = RMFinish_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FinishStageTwo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinishStageTwo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FinishStageThree()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinishStageThree.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessChildCompletion(System.Threading.Tasks.Task @childTask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@childTask};
            var ___result = RMProcessChildCompletion_Task.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddExceptionsFromChildren()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAddExceptionsFromChildren.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Execute()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMExecute.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Threading__2__IThreadPoolWorkItem__2__ExecuteWorkItem()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Threading__2__IThreadPoolWorkItem__2__ExecuteWorkItem.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ExecuteEntry(System.Boolean @bPreventDoubleExecution)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bPreventDoubleExecution};
            var ___result = RMExecuteEntry_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void ExecutionContextCallback(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMExecutionContextCallback_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InnerInvoke()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInnerInvoke.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleException(System.Exception @unhandledException)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unhandledException};
            var ___result = RMHandleException_Exception.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Runtime.CompilerServices.TaskAwaiter GetAwaiter()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetAwaiter.Invoke(___genericsType, ___parameters);

            return (System.Runtime.CompilerServices.TaskAwaiter)___result;
        }


        public virtual System.Runtime.CompilerServices.ConfiguredTaskAwaitable ConfigureAwait(System.Boolean @continueOnCapturedContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continueOnCapturedContext};
            var ___result = RMConfigureAwait_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Runtime.CompilerServices.ConfiguredTaskAwaitable)___result;
        }


        public virtual void SetContinuationForAwait(System.Action @continuationAction, System.Boolean @continueOnCapturedContext, System.Boolean @flowExecutionContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @continueOnCapturedContext, @flowExecutionContext};
            var ___result = RMSetContinuationForAwait_Action_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Runtime.CompilerServices.YieldAwaitable Yield()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMYield.Invoke(___genericsType, ___parameters);

            return (System.Runtime.CompilerServices.YieldAwaitable)___result;
        }


        public virtual void Wait()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMWait.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Wait(System.TimeSpan @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout};
            var ___result = RMWait_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Wait(System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cancellationToken};
            var ___result = RMWait_CancellationToken.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Wait(System.Int32 @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout};
            var ___result = RMWait_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Wait(System.Int32 @millisecondsTimeout, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout, @cancellationToken};
            var ___result = RMWait_Int32_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean WrappedTryRunInline()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMWrappedTryRunInline.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean InternalWait(System.Int32 @millisecondsTimeout, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout, @cancellationToken};
            var ___result = RMInternalWait_Int32_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean SpinThenBlockingWait(System.Int32 @millisecondsTimeout, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout, @cancellationToken};
            var ___result = RMSpinThenBlockingWait_Int32_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean SpinWait(System.Int32 @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout};
            var ___result = RMSpinWait_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean InternalCancel(System.Boolean @bCancelNonExecutingOnly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bCancelNonExecutingOnly};
            var ___result = RMInternalCancel_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void RecordInternalCancellationRequest()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRecordInternalCancellationRequest.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecordInternalCancellationRequest(System.Threading.CancellationToken @tokenToRecord)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tokenToRecord};
            var ___result = RMRecordInternalCancellationRequest_CancellationToken.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecordInternalCancellationRequest(System.Threading.CancellationToken @tokenToRecord, System.Object @cancellationException)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tokenToRecord, @cancellationException};
            var ___result = RMRecordInternalCancellationRequest_CancellationToken_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CancellationCleanupLogic()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCancellationCleanupLogic.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCancellationAcknowledged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetCancellationAcknowledged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FinishContinuations()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinishContinuations.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LogFinishCompletionNotification()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMLogFinishCompletionNotification.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task> @continuationAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction};
            var ___result = RMContinueWith_Action_d_Task_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task> @continuationAction, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @cancellationToken};
            var ___result = RMContinueWith_Action_d_Task_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task> @continuationAction, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @scheduler};
            var ___result = RMContinueWith_Action_d_Task_p__TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task> @continuationAction, System.Threading.Tasks.TaskContinuationOptions @continuationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @continuationOptions};
            var ___result = RMContinueWith_Action_d_Task_p__TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task> @continuationAction, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskContinuationOptions @continuationOptions, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RMContinueWith_Action_d_Task_p__CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task> @continuationAction, System.Threading.Tasks.TaskScheduler @scheduler, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskContinuationOptions @continuationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @scheduler, @cancellationToken, @continuationOptions};
            var ___result = RMContinueWith_Action_d_Task_p__TaskScheduler_CancellationToken_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task, System.Object> @continuationAction, System.Object @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @state};
            var ___result = RMContinueWith_Action_d_Task_Object_p__Object.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task, System.Object> @continuationAction, System.Object @state, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @state, @cancellationToken};
            var ___result = RMContinueWith_Action_d_Task_Object_p__Object_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task, System.Object> @continuationAction, System.Object @state, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @state, @scheduler};
            var ___result = RMContinueWith_Action_d_Task_Object_p__Object_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task, System.Object> @continuationAction, System.Object @state, System.Threading.Tasks.TaskContinuationOptions @continuationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @state, @continuationOptions};
            var ___result = RMContinueWith_Action_d_Task_Object_p__Object_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task, System.Object> @continuationAction, System.Object @state, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskContinuationOptions @continuationOptions, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @state, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RMContinueWith_Action_d_Task_Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task, System.Object> @continuationAction, System.Object @state, System.Threading.Tasks.TaskScheduler @scheduler, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskContinuationOptions @continuationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @state, @scheduler, @cancellationToken, @continuationOptions};
            var ___result = RMContinueWith_Action_d_Task_Object_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, TResult> @continuationFunction)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@continuationFunction};
            var ___result = RMContinueWith_GTResult_Func_d_Task_TResult_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, TResult> @continuationFunction, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@continuationFunction, @cancellationToken};
            var ___result = RMContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, TResult> @continuationFunction, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@continuationFunction, @scheduler};
            var ___result = RMContinueWith_GTResult_Func_d_Task_TResult_p__TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, TResult> @continuationFunction, System.Threading.Tasks.TaskContinuationOptions @continuationOptions)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@continuationFunction, @continuationOptions};
            var ___result = RMContinueWith_GTResult_Func_d_Task_TResult_p__TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, TResult> @continuationFunction, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskContinuationOptions @continuationOptions, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@continuationFunction, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RMContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, TResult> @continuationFunction, System.Threading.Tasks.TaskScheduler @scheduler, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskContinuationOptions @continuationOptions)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@continuationFunction, @scheduler, @cancellationToken, @continuationOptions};
            var ___result = RMContinueWith_GTResult_Func_d_Task_TResult_p__TaskScheduler_CancellationToken_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, System.Object, TResult> @continuationFunction, System.Object @state)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@continuationFunction, @state};
            var ___result = RMContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, System.Object, TResult> @continuationFunction, System.Object @state, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@continuationFunction, @state, @cancellationToken};
            var ___result = RMContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, System.Object, TResult> @continuationFunction, System.Object @state, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@continuationFunction, @state, @scheduler};
            var ___result = RMContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, System.Object, TResult> @continuationFunction, System.Object @state, System.Threading.Tasks.TaskContinuationOptions @continuationOptions)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@continuationFunction, @state, @continuationOptions};
            var ___result = RMContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, System.Object, TResult> @continuationFunction, System.Object @state, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskContinuationOptions @continuationOptions, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@continuationFunction, @state, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RMContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, System.Object, TResult> @continuationFunction, System.Object @state, System.Threading.Tasks.TaskScheduler @scheduler, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskContinuationOptions @continuationOptions)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@continuationFunction, @state, @scheduler, @cancellationToken, @continuationOptions};
            var ___result = RMContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static void CreationOptionsFromContinuationOptions(System.Threading.Tasks.TaskContinuationOptions @continuationOptions, out System.Threading.Tasks.TaskCreationOptions @creationOptions, out Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RInternalTaskOptions @internalOptions)
        {
			@creationOptions = default;
			@internalOptions = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationOptions, @creationOptions, @internalOptions.Value};
            var ___result = RMCreationOptionsFromContinuationOptions_TaskContinuationOptions_Out_TaskCreationOptions_Out_InternalTaskOptions.Invoke(___genericsType, ___parameters);
			@creationOptions = (System.Threading.Tasks.TaskCreationOptions)___parameters[1];
			@internalOptions = new Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RInternalTaskOptions(___parameters[2]);

            
        }


        public virtual void ContinueWithCore(System.Threading.Tasks.Task @continuationTask, System.Threading.Tasks.TaskScheduler @scheduler, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskContinuationOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationTask, @scheduler, @cancellationToken, @options};
            var ___result = RMContinueWithCore_Task_TaskScheduler_CancellationToken_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddCompletionAction(Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RITaskCompletionAction @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action.Value};
            var ___result = RMAddCompletionAction_ITaskCompletionAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddCompletionAction(Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RITaskCompletionAction @action, System.Boolean @addBeforeOthers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action.Value, @addBeforeOthers};
            var ___result = RMAddCompletionAction_ITaskCompletionAction_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean AddTaskContinuationComplex(System.Object @tc, System.Boolean @addBeforeOthers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tc, @addBeforeOthers};
            var ___result = RMAddTaskContinuationComplex_Object_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean AddTaskContinuation(System.Object @tc, System.Boolean @addBeforeOthers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tc, @addBeforeOthers};
            var ___result = RMAddTaskContinuation_Object_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void RemoveContinuation(System.Object @continuationObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationObject};
            var ___result = RMRemoveContinuation_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static void WaitAll(System.Threading.Tasks.Task[] @tasks)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks};
            var ___result = RMWaitAll_TaskArray.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean WaitAll(System.Threading.Tasks.Task[] @tasks, System.TimeSpan @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @timeout};
            var ___result = RMWaitAll_TaskArray_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean WaitAll(System.Threading.Tasks.Task[] @tasks, System.Int32 @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @millisecondsTimeout};
            var ___result = RMWaitAll_TaskArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void WaitAll(System.Threading.Tasks.Task[] @tasks, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @cancellationToken};
            var ___result = RMWaitAll_TaskArray_CancellationToken.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean WaitAll(System.Threading.Tasks.Task[] @tasks, System.Int32 @millisecondsTimeout, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @millisecondsTimeout, @cancellationToken};
            var ___result = RMWaitAll_TaskArray_Int32_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void AddToList<T>(T @item, ref Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RLowLevelListWithIList<Hvak.Editor.Refleaction.RType> @list, System.Int32 @initSize)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@item, @list.Value, @initSize};
            var ___result = RMAddToList_GT_T_Ref_LowLevelListWithIList_d_T_p__Int32.Invoke(___genericsType, ___parameters);
			@list = new Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RLowLevelListWithIList<Hvak.Editor.Refleaction.RType>(___parameters[1]);

            
        }


        public static System.Boolean WaitAllBlockingCore(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RLowLevelListWithIList<Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask> @tasks, System.Int32 @millisecondsTimeout, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks.Value, @millisecondsTimeout, @cancellationToken};
            var ___result = RMWaitAllBlockingCore_LowLevelListWithIList_d_Task_p__Int32_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void AddExceptionsForCompletedTask(ref Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RLowLevelListWithIList<Hvak.Editor.Refleaction.RSystem.RException> @exceptions, System.Threading.Tasks.Task @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exceptions.Value, @t};
            var ___result = RMAddExceptionsForCompletedTask_Ref_LowLevelListWithIList_d_Exception_p__Task.Invoke(___genericsType, ___parameters);
			@exceptions = new Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RLowLevelListWithIList<Hvak.Editor.Refleaction.RSystem.RException>(___parameters[0]);

            
        }


        public static System.Int32 WaitAny(System.Threading.Tasks.Task[] @tasks)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks};
            var ___result = RMWaitAny_TaskArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 WaitAny(System.Threading.Tasks.Task[] @tasks, System.TimeSpan @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @timeout};
            var ___result = RMWaitAny_TaskArray_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 WaitAny(System.Threading.Tasks.Task[] @tasks, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @cancellationToken};
            var ___result = RMWaitAny_TaskArray_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 WaitAny(System.Threading.Tasks.Task[] @tasks, System.Int32 @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @millisecondsTimeout};
            var ___result = RMWaitAny_TaskArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 WaitAny(System.Threading.Tasks.Task[] @tasks, System.Int32 @millisecondsTimeout, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @millisecondsTimeout, @cancellationToken};
            var ___result = RMWaitAny_TaskArray_Int32_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Threading.Tasks.Task<TResult> FromResult<TResult>(TResult @result)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@result};
            var ___result = RMFromResult_GTResult_TResult.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task FromException(System.Exception @exception)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exception};
            var ___result = RMFromException_Exception.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public static System.Threading.Tasks.Task<TResult> FromException<TResult>(System.Exception @exception)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@exception};
            var ___result = RMFromException_GTResult_Exception.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task FromCancellation(System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cancellationToken};
            var ___result = RMFromCancellation_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public static System.Threading.Tasks.Task FromCanceled(System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cancellationToken};
            var ___result = RMFromCanceled_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public static System.Threading.Tasks.Task<TResult> FromCancellation<TResult>(System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@cancellationToken};
            var ___result = RMFromCancellation_GTResult_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task<TResult> FromCanceled<TResult>(System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@cancellationToken};
            var ___result = RMFromCanceled_GTResult_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task<TResult> FromCancellation<TResult>(System.OperationCanceledException @exception)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@exception};
            var ___result = RMFromCancellation_GTResult_OperationCanceledException.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task Run(System.Action @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action};
            var ___result = RMRun_Action.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public static System.Threading.Tasks.Task Run(System.Action @action, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action, @cancellationToken};
            var ___result = RMRun_Action_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public static System.Threading.Tasks.Task<TResult> Run<TResult>(System.Func<TResult> @function)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@function};
            var ___result = RMRun_GTResult_Func_d_TResult_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task<TResult> Run<TResult>(System.Func<TResult> @function, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@function, @cancellationToken};
            var ___result = RMRun_GTResult_Func_d_TResult_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task Run(System.Func<System.Threading.Tasks.Task> @function)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@function};
            var ___result = RMRun_Func_d_Task_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public static System.Threading.Tasks.Task Run(System.Func<System.Threading.Tasks.Task> @function, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@function, @cancellationToken};
            var ___result = RMRun_Func_d_Task_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public static System.Threading.Tasks.Task<TResult> Run<TResult>(System.Func<System.Threading.Tasks.Task<TResult>> @function)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@function};
            var ___result = RMRun_GTResult_Func_d_Task_d_TResult_p__p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task<TResult> Run<TResult>(System.Func<System.Threading.Tasks.Task<TResult>> @function, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@function, @cancellationToken};
            var ___result = RMRun_GTResult_Func_d_Task_d_TResult_p__p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task Delay(System.TimeSpan @delay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delay};
            var ___result = RMDelay_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public static System.Threading.Tasks.Task Delay(System.TimeSpan @delay, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delay, @cancellationToken};
            var ___result = RMDelay_TimeSpan_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public static System.Threading.Tasks.Task Delay(System.Int32 @millisecondsDelay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsDelay};
            var ___result = RMDelay_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public static System.Threading.Tasks.Task Delay(System.Int32 @millisecondsDelay, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsDelay, @cancellationToken};
            var ___result = RMDelay_Int32_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public static System.Threading.Tasks.Task WhenAll(System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task> @tasks)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks};
            var ___result = RMWhenAll_IEnumerable_d_Task_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public static System.Threading.Tasks.Task WhenAll(System.Threading.Tasks.Task[] @tasks)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks};
            var ___result = RMWhenAll_TaskArray.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public static System.Threading.Tasks.Task InternalWhenAll(System.Threading.Tasks.Task[] @tasks)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks};
            var ___result = RMInternalWhenAll_TaskArray.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public static System.Threading.Tasks.Task<TResult[]> WhenAll<TResult>(System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task<TResult>> @tasks)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@tasks};
            var ___result = RMWhenAll_GTResult_IEnumerable_d_Task_d_TResult_p__p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult[]>)___result;
        }


        public static System.Threading.Tasks.Task<TResult[]> WhenAll<TResult>(System.Threading.Tasks.Task<TResult>[] @tasks)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@tasks};
            var ___result = RMWhenAll_GTResult_Task_d_TResult_p_Array.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult[]>)___result;
        }


        public static System.Threading.Tasks.Task<TResult[]> InternalWhenAll<TResult>(System.Threading.Tasks.Task<TResult>[] @tasks)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@tasks};
            var ___result = RMInternalWhenAll_GTResult_Task_d_TResult_p_Array.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult[]>)___result;
        }


        public static System.Threading.Tasks.Task<System.Threading.Tasks.Task> WhenAny(System.Threading.Tasks.Task[] @tasks)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks};
            var ___result = RMWhenAny_TaskArray.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Threading.Tasks.Task>)___result;
        }


        public static System.Threading.Tasks.Task<System.Threading.Tasks.Task> WhenAny(System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task> @tasks)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks};
            var ___result = RMWhenAny_IEnumerable_d_Task_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Threading.Tasks.Task>)___result;
        }


        public static System.Threading.Tasks.Task<System.Threading.Tasks.Task<TResult>> WhenAny<TResult>(System.Threading.Tasks.Task<TResult>[] @tasks)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@tasks};
            var ___result = RMWhenAny_GTResult_Task_d_TResult_p_Array.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Threading.Tasks.Task<TResult>>)___result;
        }


        public static System.Threading.Tasks.Task<System.Threading.Tasks.Task<TResult>> WhenAny<TResult>(System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task<TResult>> @tasks)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@tasks};
            var ___result = RMWhenAny_GTResult_IEnumerable_d_Task_d_TResult_p__p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Threading.Tasks.Task<TResult>>)___result;
        }


        public static System.Threading.Tasks.Task<TResult> CreateUnwrapPromise<TResult>(System.Threading.Tasks.Task @outerTask, System.Boolean @lookForOce)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@outerTask, @lookForOce};
            var ___result = RMCreateUnwrapPromise_GTResult_Task_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Delegate[] GetDelegateContinuationsForDebugger()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDelegateContinuationsForDebugger.Invoke(___genericsType, ___parameters);

            return (System.Delegate[])___result;
        }


        public static System.Delegate[] GetDelegatesFromContinuationObject(System.Object @continuationObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationObject};
            var ___result = RMGetDelegatesFromContinuationObject_Object.Invoke(___genericsType, ___parameters);

            return (System.Delegate[])___result;
        }


        public static System.Threading.Tasks.Task GetActiveTaskFromId(System.Int32 @taskId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@taskId};
            var ___result = RMGetActiveTaskFromId_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public static System.Boolean AddToActiveTasks(System.Threading.Tasks.Task @task)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task};
            var ___result = RMAddToActiveTasks_Task.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void RemoveFromActiveTasks(System.Int32 @taskId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@taskId};
            var ___result = RMRemoveFromActiveTasks_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkAborted(System.Threading.ThreadAbortException @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMMarkAborted_ThreadAbortException.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExecuteWithThreadLocal(ref System.Threading.Tasks.Task @currentTaskSlot)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@currentTaskSlot};
            var ___result = RMExecuteWithThreadLocal_Ref_Task.Invoke(___genericsType, ___parameters);
			@currentTaskSlot = (System.Threading.Tasks.Task)___parameters[0];

            
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
