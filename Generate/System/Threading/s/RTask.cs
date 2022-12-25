using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks
{
	/// <summary>
	/// System.Threading.Tasks.Task
	/// </summary>
    public partial class RTask : RMember //
    {

		/// <summary>
		/// System.Int32 s_taskIdCounter
		/// </summary>
		protected static RField r_s_taskIdCounter;
		public static RField Rs_taskIdCounter
		{
			get
			{
				if(r_s_taskIdCounter == null)
				{
					r_s_taskIdCounter = new(typeof(System.Threading.Tasks.Task), "s_taskIdCounter");
					r_s_taskIdCounter.SetBelong(null);
				}
				return r_s_taskIdCounter;
			}
		}

		/// <summary>
		/// System.Int32 m_taskId
		/// </summary>
		protected RField r_m_taskId;
		public virtual RField Rm_taskId
		{
			get
			{
				if(r_m_taskId == null)
				{
					r_m_taskId = new(this, "m_taskId");
					r_m_taskId.SetBelong(this.instance);
				}
				return r_m_taskId;
			}
		}

		/// <summary>
		/// System.Delegate m_action
		/// </summary>
		protected RSystem.RDelegate r_m_action;
		public virtual RSystem.RDelegate Rm_action
		{
			get
			{
				if(r_m_action == null)
				{
					r_m_action = new(this, "m_action");
					r_m_action.SetBelong(this.instance);
				}
				return r_m_action;
			}
		}

		/// <summary>
		/// System.Object m_stateObject
		/// </summary>
		protected RSystem.RObject r_m_stateObject;
		public virtual RSystem.RObject Rm_stateObject
		{
			get
			{
				if(r_m_stateObject == null)
				{
					r_m_stateObject = new(this, "m_stateObject");
					r_m_stateObject.SetBelong(this.instance);
				}
				return r_m_stateObject;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskScheduler m_taskScheduler
		/// </summary>
		protected RSystem.RThreading.RTasks.RTaskScheduler r_m_taskScheduler;
		public virtual RSystem.RThreading.RTasks.RTaskScheduler Rm_taskScheduler
		{
			get
			{
				if(r_m_taskScheduler == null)
				{
					r_m_taskScheduler = new(this, "m_taskScheduler");
					r_m_taskScheduler.SetBelong(this.instance);
				}
				return r_m_taskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task m_parent
		/// </summary>
		protected RSystem.RThreading.RTasks.RTask r_m_parent;
		public virtual RSystem.RThreading.RTasks.RTask Rm_parent
		{
			get
			{
				if(r_m_parent == null)
				{
					r_m_parent = new(this, "m_parent");
					r_m_parent.SetBelong(this.instance);
				}
				return r_m_parent;
			}
		}

		/// <summary>
		/// System.Int32 m_stateFlags
		/// </summary>
		protected RField r_m_stateFlags;
		public virtual RField Rm_stateFlags
		{
			get
			{
				if(r_m_stateFlags == null)
				{
					r_m_stateFlags = new(this, "m_stateFlags");
					r_m_stateFlags.SetBelong(this.instance);
				}
				return r_m_stateFlags;
			}
		}

		/// <summary>
		/// System.Int32 OptionsMask
		/// </summary>
		protected static RField r_OptionsMask;
		public static RField ROptionsMask
		{
			get
			{
				if(r_OptionsMask == null)
				{
					r_OptionsMask = new(typeof(System.Threading.Tasks.Task), "OptionsMask");
					r_OptionsMask.SetBelong(null);
				}
				return r_OptionsMask;
			}
		}

		/// <summary>
		/// System.Int32 TASK_STATE_STARTED
		/// </summary>
		protected static RField r_TASK_STATE_STARTED;
		public static RField RTASK_STATE_STARTED
		{
			get
			{
				if(r_TASK_STATE_STARTED == null)
				{
					r_TASK_STATE_STARTED = new(typeof(System.Threading.Tasks.Task), "TASK_STATE_STARTED");
					r_TASK_STATE_STARTED.SetBelong(null);
				}
				return r_TASK_STATE_STARTED;
			}
		}

		/// <summary>
		/// System.Int32 TASK_STATE_DELEGATE_INVOKED
		/// </summary>
		protected static RField r_TASK_STATE_DELEGATE_INVOKED;
		public static RField RTASK_STATE_DELEGATE_INVOKED
		{
			get
			{
				if(r_TASK_STATE_DELEGATE_INVOKED == null)
				{
					r_TASK_STATE_DELEGATE_INVOKED = new(typeof(System.Threading.Tasks.Task), "TASK_STATE_DELEGATE_INVOKED");
					r_TASK_STATE_DELEGATE_INVOKED.SetBelong(null);
				}
				return r_TASK_STATE_DELEGATE_INVOKED;
			}
		}

		/// <summary>
		/// System.Int32 TASK_STATE_DISPOSED
		/// </summary>
		protected static RField r_TASK_STATE_DISPOSED;
		public static RField RTASK_STATE_DISPOSED
		{
			get
			{
				if(r_TASK_STATE_DISPOSED == null)
				{
					r_TASK_STATE_DISPOSED = new(typeof(System.Threading.Tasks.Task), "TASK_STATE_DISPOSED");
					r_TASK_STATE_DISPOSED.SetBelong(null);
				}
				return r_TASK_STATE_DISPOSED;
			}
		}

		/// <summary>
		/// System.Int32 TASK_STATE_EXCEPTIONOBSERVEDBYPARENT
		/// </summary>
		protected static RField r_TASK_STATE_EXCEPTIONOBSERVEDBYPARENT;
		public static RField RTASK_STATE_EXCEPTIONOBSERVEDBYPARENT
		{
			get
			{
				if(r_TASK_STATE_EXCEPTIONOBSERVEDBYPARENT == null)
				{
					r_TASK_STATE_EXCEPTIONOBSERVEDBYPARENT = new(typeof(System.Threading.Tasks.Task), "TASK_STATE_EXCEPTIONOBSERVEDBYPARENT");
					r_TASK_STATE_EXCEPTIONOBSERVEDBYPARENT.SetBelong(null);
				}
				return r_TASK_STATE_EXCEPTIONOBSERVEDBYPARENT;
			}
		}

		/// <summary>
		/// System.Int32 TASK_STATE_CANCELLATIONACKNOWLEDGED
		/// </summary>
		protected static RField r_TASK_STATE_CANCELLATIONACKNOWLEDGED;
		public static RField RTASK_STATE_CANCELLATIONACKNOWLEDGED
		{
			get
			{
				if(r_TASK_STATE_CANCELLATIONACKNOWLEDGED == null)
				{
					r_TASK_STATE_CANCELLATIONACKNOWLEDGED = new(typeof(System.Threading.Tasks.Task), "TASK_STATE_CANCELLATIONACKNOWLEDGED");
					r_TASK_STATE_CANCELLATIONACKNOWLEDGED.SetBelong(null);
				}
				return r_TASK_STATE_CANCELLATIONACKNOWLEDGED;
			}
		}

		/// <summary>
		/// System.Int32 TASK_STATE_FAULTED
		/// </summary>
		protected static RField r_TASK_STATE_FAULTED;
		public static RField RTASK_STATE_FAULTED
		{
			get
			{
				if(r_TASK_STATE_FAULTED == null)
				{
					r_TASK_STATE_FAULTED = new(typeof(System.Threading.Tasks.Task), "TASK_STATE_FAULTED");
					r_TASK_STATE_FAULTED.SetBelong(null);
				}
				return r_TASK_STATE_FAULTED;
			}
		}

		/// <summary>
		/// System.Int32 TASK_STATE_CANCELED
		/// </summary>
		protected static RField r_TASK_STATE_CANCELED;
		public static RField RTASK_STATE_CANCELED
		{
			get
			{
				if(r_TASK_STATE_CANCELED == null)
				{
					r_TASK_STATE_CANCELED = new(typeof(System.Threading.Tasks.Task), "TASK_STATE_CANCELED");
					r_TASK_STATE_CANCELED.SetBelong(null);
				}
				return r_TASK_STATE_CANCELED;
			}
		}

		/// <summary>
		/// System.Int32 TASK_STATE_WAITING_ON_CHILDREN
		/// </summary>
		protected static RField r_TASK_STATE_WAITING_ON_CHILDREN;
		public static RField RTASK_STATE_WAITING_ON_CHILDREN
		{
			get
			{
				if(r_TASK_STATE_WAITING_ON_CHILDREN == null)
				{
					r_TASK_STATE_WAITING_ON_CHILDREN = new(typeof(System.Threading.Tasks.Task), "TASK_STATE_WAITING_ON_CHILDREN");
					r_TASK_STATE_WAITING_ON_CHILDREN.SetBelong(null);
				}
				return r_TASK_STATE_WAITING_ON_CHILDREN;
			}
		}

		/// <summary>
		/// System.Int32 TASK_STATE_RAN_TO_COMPLETION
		/// </summary>
		protected static RField r_TASK_STATE_RAN_TO_COMPLETION;
		public static RField RTASK_STATE_RAN_TO_COMPLETION
		{
			get
			{
				if(r_TASK_STATE_RAN_TO_COMPLETION == null)
				{
					r_TASK_STATE_RAN_TO_COMPLETION = new(typeof(System.Threading.Tasks.Task), "TASK_STATE_RAN_TO_COMPLETION");
					r_TASK_STATE_RAN_TO_COMPLETION.SetBelong(null);
				}
				return r_TASK_STATE_RAN_TO_COMPLETION;
			}
		}

		/// <summary>
		/// System.Int32 TASK_STATE_WAITINGFORACTIVATION
		/// </summary>
		protected static RField r_TASK_STATE_WAITINGFORACTIVATION;
		public static RField RTASK_STATE_WAITINGFORACTIVATION
		{
			get
			{
				if(r_TASK_STATE_WAITINGFORACTIVATION == null)
				{
					r_TASK_STATE_WAITINGFORACTIVATION = new(typeof(System.Threading.Tasks.Task), "TASK_STATE_WAITINGFORACTIVATION");
					r_TASK_STATE_WAITINGFORACTIVATION.SetBelong(null);
				}
				return r_TASK_STATE_WAITINGFORACTIVATION;
			}
		}

		/// <summary>
		/// System.Int32 TASK_STATE_COMPLETION_RESERVED
		/// </summary>
		protected static RField r_TASK_STATE_COMPLETION_RESERVED;
		public static RField RTASK_STATE_COMPLETION_RESERVED
		{
			get
			{
				if(r_TASK_STATE_COMPLETION_RESERVED == null)
				{
					r_TASK_STATE_COMPLETION_RESERVED = new(typeof(System.Threading.Tasks.Task), "TASK_STATE_COMPLETION_RESERVED");
					r_TASK_STATE_COMPLETION_RESERVED.SetBelong(null);
				}
				return r_TASK_STATE_COMPLETION_RESERVED;
			}
		}

		/// <summary>
		/// System.Int32 TASK_STATE_THREAD_WAS_ABORTED
		/// </summary>
		protected static RField r_TASK_STATE_THREAD_WAS_ABORTED;
		public static RField RTASK_STATE_THREAD_WAS_ABORTED
		{
			get
			{
				if(r_TASK_STATE_THREAD_WAS_ABORTED == null)
				{
					r_TASK_STATE_THREAD_WAS_ABORTED = new(typeof(System.Threading.Tasks.Task), "TASK_STATE_THREAD_WAS_ABORTED");
					r_TASK_STATE_THREAD_WAS_ABORTED.SetBelong(null);
				}
				return r_TASK_STATE_THREAD_WAS_ABORTED;
			}
		}

		/// <summary>
		/// System.Int32 TASK_STATE_WAIT_COMPLETION_NOTIFICATION
		/// </summary>
		protected static RField r_TASK_STATE_WAIT_COMPLETION_NOTIFICATION;
		public static RField RTASK_STATE_WAIT_COMPLETION_NOTIFICATION
		{
			get
			{
				if(r_TASK_STATE_WAIT_COMPLETION_NOTIFICATION == null)
				{
					r_TASK_STATE_WAIT_COMPLETION_NOTIFICATION = new(typeof(System.Threading.Tasks.Task), "TASK_STATE_WAIT_COMPLETION_NOTIFICATION");
					r_TASK_STATE_WAIT_COMPLETION_NOTIFICATION.SetBelong(null);
				}
				return r_TASK_STATE_WAIT_COMPLETION_NOTIFICATION;
			}
		}

		/// <summary>
		/// System.Int32 TASK_STATE_COMPLETED_MASK
		/// </summary>
		protected static RField r_TASK_STATE_COMPLETED_MASK;
		public static RField RTASK_STATE_COMPLETED_MASK
		{
			get
			{
				if(r_TASK_STATE_COMPLETED_MASK == null)
				{
					r_TASK_STATE_COMPLETED_MASK = new(typeof(System.Threading.Tasks.Task), "TASK_STATE_COMPLETED_MASK");
					r_TASK_STATE_COMPLETED_MASK.SetBelong(null);
				}
				return r_TASK_STATE_COMPLETED_MASK;
			}
		}

		/// <summary>
		/// System.Int32 CANCELLATION_REQUESTED
		/// </summary>
		protected static RField r_CANCELLATION_REQUESTED;
		public static RField RCANCELLATION_REQUESTED
		{
			get
			{
				if(r_CANCELLATION_REQUESTED == null)
				{
					r_CANCELLATION_REQUESTED = new(typeof(System.Threading.Tasks.Task), "CANCELLATION_REQUESTED");
					r_CANCELLATION_REQUESTED.SetBelong(null);
				}
				return r_CANCELLATION_REQUESTED;
			}
		}

		/// <summary>
		/// System.Object m_continuationObject
		/// </summary>
		protected RSystem.RObject r_m_continuationObject;
		public virtual RSystem.RObject Rm_continuationObject
		{
			get
			{
				if(r_m_continuationObject == null)
				{
					r_m_continuationObject = new(this, "m_continuationObject");
					r_m_continuationObject.SetBelong(this.instance);
				}
				return r_m_continuationObject;
			}
		}

		/// <summary>
		/// System.Object s_taskCompletionSentinel
		/// </summary>
		protected static RSystem.RObject r_s_taskCompletionSentinel;
		public static RSystem.RObject Rs_taskCompletionSentinel
		{
			get
			{
				if(r_s_taskCompletionSentinel == null)
				{
					r_s_taskCompletionSentinel = new(typeof(System.Threading.Tasks.Task), "s_taskCompletionSentinel");
					r_s_taskCompletionSentinel.SetBelong(null);
				}
				return r_s_taskCompletionSentinel;
			}
		}

		/// <summary>
		/// System.Boolean s_asyncDebuggingEnabled
		/// </summary>
		protected static RField r_s_asyncDebuggingEnabled;
		public static RField Rs_asyncDebuggingEnabled
		{
			get
			{
				if(r_s_asyncDebuggingEnabled == null)
				{
					r_s_asyncDebuggingEnabled = new(typeof(System.Threading.Tasks.Task), "s_asyncDebuggingEnabled");
					r_s_asyncDebuggingEnabled.SetBelong(null);
				}
				return r_s_asyncDebuggingEnabled;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task+ContingentProperties m_contingentProperties
		/// </summary>
		protected RSystem.RThreading.RTasks.RTask.RContingentProperties r_m_contingentProperties;
		public virtual RSystem.RThreading.RTasks.RTask.RContingentProperties Rm_contingentProperties
		{
			get
			{
				if(r_m_contingentProperties == null)
				{
					r_m_contingentProperties = new(this, "m_contingentProperties");
					r_m_contingentProperties.SetBelong(this.instance);
				}
				return r_m_contingentProperties;
			}
		}

		/// <summary>
		/// System.Action`1[System.Object] s_taskCancelCallback
		/// </summary>
		protected static RSystem.RAction<RSystem.RObject> r_s_taskCancelCallback;
		public static RSystem.RAction<RSystem.RObject> Rs_taskCancelCallback
		{
			get
			{
				if(r_s_taskCancelCallback == null)
				{
					r_s_taskCancelCallback = new(typeof(System.Threading.Tasks.Task), "s_taskCancelCallback");
					r_s_taskCancelCallback.SetBelong(null);
				}
				return r_s_taskCancelCallback;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task t_currentTask
		/// </summary>
		protected static RSystem.RThreading.RTasks.RTask r_t_currentTask;
		public static RSystem.RThreading.RTasks.RTask Rt_currentTask
		{
			get
			{
				if(r_t_currentTask == null)
				{
					r_t_currentTask = new(typeof(System.Threading.Tasks.Task), "t_currentTask");
					r_t_currentTask.SetBelong(null);
				}
				return r_t_currentTask;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.StackGuard t_stackGuard
		/// </summary>
		protected static RSystem.RThreading.RTasks.RStackGuard r_t_stackGuard;
		public static RSystem.RThreading.RTasks.RStackGuard Rt_stackGuard
		{
			get
			{
				if(r_t_stackGuard == null)
				{
					r_t_stackGuard = new(typeof(System.Threading.Tasks.Task), "t_stackGuard");
					r_t_stackGuard.SetBelong(null);
				}
				return r_t_stackGuard;
			}
		}

		/// <summary>
		/// System.Func`1[System.Threading.Tasks.Task+ContingentProperties] s_createContingentProperties
		/// </summary>
		protected static RSystem.RFunc<RSystem.RThreading.RTasks.RTask.RContingentProperties> r_s_createContingentProperties;
		public static RSystem.RFunc<RSystem.RThreading.RTasks.RTask.RContingentProperties> Rs_createContingentProperties
		{
			get
			{
				if(r_s_createContingentProperties == null)
				{
					r_s_createContingentProperties = new(typeof(System.Threading.Tasks.Task), "s_createContingentProperties");
					r_s_createContingentProperties.SetBelong(null);
				}
				return r_s_createContingentProperties;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskFactory <Factory>k__BackingField
		/// </summary>
		protected static RSystem.RThreading.RTasks.RTaskFactory r___1__Factory__2__k__BackingField;
		public static RSystem.RThreading.RTasks.RTaskFactory R__1__Factory__2__k__BackingField
		{
			get
			{
				if(r___1__Factory__2__k__BackingField == null)
				{
					r___1__Factory__2__k__BackingField = new(typeof(System.Threading.Tasks.Task), "<Factory>k__BackingField");
					r___1__Factory__2__k__BackingField.SetBelong(null);
				}
				return r___1__Factory__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task <CompletedTask>k__BackingField
		/// </summary>
		protected static RSystem.RThreading.RTasks.RTask r___1__CompletedTask__2__k__BackingField;
		public static RSystem.RThreading.RTasks.RTask R__1__CompletedTask__2__k__BackingField
		{
			get
			{
				if(r___1__CompletedTask__2__k__BackingField == null)
				{
					r___1__CompletedTask__2__k__BackingField = new(typeof(System.Threading.Tasks.Task), "<CompletedTask>k__BackingField");
					r___1__CompletedTask__2__k__BackingField.SetBelong(null);
				}
				return r___1__CompletedTask__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Predicate`1[System.Threading.Tasks.Task] s_IsExceptionObservedByParentPredicate
		/// </summary>
		protected static RSystem.RPredicate<RSystem.RThreading.RTasks.RTask> r_s_IsExceptionObservedByParentPredicate;
		public static RSystem.RPredicate<RSystem.RThreading.RTasks.RTask> Rs_IsExceptionObservedByParentPredicate
		{
			get
			{
				if(r_s_IsExceptionObservedByParentPredicate == null)
				{
					r_s_IsExceptionObservedByParentPredicate = new(typeof(System.Threading.Tasks.Task), "s_IsExceptionObservedByParentPredicate");
					r_s_IsExceptionObservedByParentPredicate.SetBelong(null);
				}
				return r_s_IsExceptionObservedByParentPredicate;
			}
		}

		/// <summary>
		/// System.Threading.ContextCallback s_ecCallback
		/// </summary>
		protected static RSystem.RThreading.RContextCallback r_s_ecCallback;
		public static RSystem.RThreading.RContextCallback Rs_ecCallback
		{
			get
			{
				if(r_s_ecCallback == null)
				{
					r_s_ecCallback = new(typeof(System.Threading.Tasks.Task), "s_ecCallback");
					r_s_ecCallback.SetBelong(null);
				}
				return r_s_ecCallback;
			}
		}

		/// <summary>
		/// System.Predicate`1[System.Object] s_IsTaskContinuationNullPredicate
		/// </summary>
		protected static RSystem.RPredicate<RSystem.RObject> r_s_IsTaskContinuationNullPredicate;
		public static RSystem.RPredicate<RSystem.RObject> Rs_IsTaskContinuationNullPredicate
		{
			get
			{
				if(r_s_IsTaskContinuationNullPredicate == null)
				{
					r_s_IsTaskContinuationNullPredicate = new(typeof(System.Threading.Tasks.Task), "s_IsTaskContinuationNullPredicate");
					r_s_IsTaskContinuationNullPredicate.SetBelong(null);
				}
				return r_s_IsTaskContinuationNullPredicate;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,System.Threading.Tasks.Task] s_currentActiveTasks
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RThreading.RTasks.RTask> r_s_currentActiveTasks;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RThreading.RTasks.RTask> Rs_currentActiveTasks
		{
			get
			{
				if(r_s_currentActiveTasks == null)
				{
					r_s_currentActiveTasks = new(typeof(System.Threading.Tasks.Task), "s_currentActiveTasks");
					r_s_currentActiveTasks.SetBelong(null);
				}
				return r_s_currentActiveTasks;
			}
		}

		/// <summary>
		/// System.Object s_activeTasksLock
		/// </summary>
		protected static RSystem.RObject r_s_activeTasksLock;
		public static RSystem.RObject Rs_activeTasksLock
		{
			get
			{
				if(r_s_activeTasksLock == null)
				{
					r_s_activeTasksLock = new(typeof(System.Threading.Tasks.Task), "s_activeTasksLock");
					r_s_activeTasksLock.SetBelong(null);
				}
				return r_s_activeTasksLock;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ParentForDebugger
		/// </summary>
		protected RSystem.RThreading.RTasks.RTask r_ParentForDebugger;
		public virtual RSystem.RThreading.RTasks.RTask RParentForDebugger
		{
			get
			{
				if(r_ParentForDebugger == null)
				{
					r_ParentForDebugger = new(this, "ParentForDebugger", -1);
					r_ParentForDebugger.SetBelong(this.instance);
				}
				return r_ParentForDebugger;
			}
		}

		/// <summary>
		/// Int32 StateFlagsForDebugger
		/// </summary>
		protected RProperty r_StateFlagsForDebugger;
		public virtual RProperty RStateFlagsForDebugger
		{
			get
			{
				if(r_StateFlagsForDebugger == null)
				{
					r_StateFlagsForDebugger = new(this, "StateFlagsForDebugger", -1);
					r_StateFlagsForDebugger.SetBelong(this.instance);
				}
				return r_StateFlagsForDebugger;
			}
		}

		/// <summary>
		/// System.String DebuggerDisplayMethodDescription
		/// </summary>
		protected RProperty r_DebuggerDisplayMethodDescription;
		public virtual RProperty RDebuggerDisplayMethodDescription
		{
			get
			{
				if(r_DebuggerDisplayMethodDescription == null)
				{
					r_DebuggerDisplayMethodDescription = new(this, "DebuggerDisplayMethodDescription", -1);
					r_DebuggerDisplayMethodDescription.SetBelong(this.instance);
				}
				return r_DebuggerDisplayMethodDescription;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskCreationOptions Options
		/// </summary>
		protected RProperty r_Options;
		public virtual RProperty ROptions
		{
			get
			{
				if(r_Options == null)
				{
					r_Options = new(this, "Options", -1);
					r_Options.SetBelong(this.instance);
				}
				return r_Options;
			}
		}

		/// <summary>
		/// Boolean IsWaitNotificationEnabledOrNotRanToCompletion
		/// </summary>
		protected RProperty r_IsWaitNotificationEnabledOrNotRanToCompletion;
		public virtual RProperty RIsWaitNotificationEnabledOrNotRanToCompletion
		{
			get
			{
				if(r_IsWaitNotificationEnabledOrNotRanToCompletion == null)
				{
					r_IsWaitNotificationEnabledOrNotRanToCompletion = new(this, "IsWaitNotificationEnabledOrNotRanToCompletion", -1);
					r_IsWaitNotificationEnabledOrNotRanToCompletion.SetBelong(this.instance);
				}
				return r_IsWaitNotificationEnabledOrNotRanToCompletion;
			}
		}

		/// <summary>
		/// Boolean ShouldNotifyDebuggerOfWaitCompletion
		/// </summary>
		protected RProperty r_ShouldNotifyDebuggerOfWaitCompletion;
		public virtual RProperty RShouldNotifyDebuggerOfWaitCompletion
		{
			get
			{
				if(r_ShouldNotifyDebuggerOfWaitCompletion == null)
				{
					r_ShouldNotifyDebuggerOfWaitCompletion = new(this, "ShouldNotifyDebuggerOfWaitCompletion", -1);
					r_ShouldNotifyDebuggerOfWaitCompletion.SetBelong(this.instance);
				}
				return r_ShouldNotifyDebuggerOfWaitCompletion;
			}
		}

		/// <summary>
		/// Boolean IsWaitNotificationEnabled
		/// </summary>
		protected RProperty r_IsWaitNotificationEnabled;
		public virtual RProperty RIsWaitNotificationEnabled
		{
			get
			{
				if(r_IsWaitNotificationEnabled == null)
				{
					r_IsWaitNotificationEnabled = new(this, "IsWaitNotificationEnabled", -1);
					r_IsWaitNotificationEnabled.SetBelong(this.instance);
				}
				return r_IsWaitNotificationEnabled;
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
		/// System.Nullable`1[System.Int32] CurrentId
		/// </summary>
		protected static RProperty r_CurrentId;
		public static RProperty RCurrentId
		{
			get
			{
				if(r_CurrentId == null)
				{
					r_CurrentId = new(typeof(System.Threading.Tasks.Task), "CurrentId", -1);
					r_CurrentId.SetBelong(null);
				}
				return r_CurrentId;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task InternalCurrent
		/// </summary>
		protected static RSystem.RThreading.RTasks.RTask r_InternalCurrent;
		public static RSystem.RThreading.RTasks.RTask RInternalCurrent
		{
			get
			{
				if(r_InternalCurrent == null)
				{
					r_InternalCurrent = new(typeof(System.Threading.Tasks.Task), "InternalCurrent", -1);
					r_InternalCurrent.SetBelong(null);
				}
				return r_InternalCurrent;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.StackGuard CurrentStackGuard
		/// </summary>
		protected static RSystem.RThreading.RTasks.RStackGuard r_CurrentStackGuard;
		public static RSystem.RThreading.RTasks.RStackGuard RCurrentStackGuard
		{
			get
			{
				if(r_CurrentStackGuard == null)
				{
					r_CurrentStackGuard = new(typeof(System.Threading.Tasks.Task), "CurrentStackGuard", -1);
					r_CurrentStackGuard.SetBelong(null);
				}
				return r_CurrentStackGuard;
			}
		}

		/// <summary>
		/// System.AggregateException Exception
		/// </summary>
		protected RSystem.RAggregateException r_Exception;
		public virtual RSystem.RAggregateException RException
		{
			get
			{
				if(r_Exception == null)
				{
					r_Exception = new(this, "Exception", -1);
					r_Exception.SetBelong(this.instance);
				}
				return r_Exception;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskStatus Status
		/// </summary>
		protected RProperty r_Status;
		public virtual RProperty RStatus
		{
			get
			{
				if(r_Status == null)
				{
					r_Status = new(this, "Status", -1);
					r_Status.SetBelong(this.instance);
				}
				return r_Status;
			}
		}

		/// <summary>
		/// Boolean IsCanceled
		/// </summary>
		protected RProperty r_IsCanceled;
		public virtual RProperty RIsCanceled
		{
			get
			{
				if(r_IsCanceled == null)
				{
					r_IsCanceled = new(this, "IsCanceled", -1);
					r_IsCanceled.SetBelong(this.instance);
				}
				return r_IsCanceled;
			}
		}

		/// <summary>
		/// Boolean IsCancellationRequested
		/// </summary>
		protected RProperty r_IsCancellationRequested;
		public virtual RProperty RIsCancellationRequested
		{
			get
			{
				if(r_IsCancellationRequested == null)
				{
					r_IsCancellationRequested = new(this, "IsCancellationRequested", -1);
					r_IsCancellationRequested.SetBelong(this.instance);
				}
				return r_IsCancellationRequested;
			}
		}

		/// <summary>
		/// System.Threading.CancellationToken CancellationToken
		/// </summary>
		protected RSystem.RThreading.RCancellationToken r_CancellationToken;
		public virtual RSystem.RThreading.RCancellationToken RCancellationToken
		{
			get
			{
				if(r_CancellationToken == null)
				{
					r_CancellationToken = new(this, "CancellationToken", -1);
					r_CancellationToken.SetBelong(this.instance);
				}
				return r_CancellationToken;
			}
		}

		/// <summary>
		/// Boolean IsCancellationAcknowledged
		/// </summary>
		protected RProperty r_IsCancellationAcknowledged;
		public virtual RProperty RIsCancellationAcknowledged
		{
			get
			{
				if(r_IsCancellationAcknowledged == null)
				{
					r_IsCancellationAcknowledged = new(this, "IsCancellationAcknowledged", -1);
					r_IsCancellationAcknowledged.SetBelong(this.instance);
				}
				return r_IsCancellationAcknowledged;
			}
		}

		/// <summary>
		/// Boolean IsCompleted
		/// </summary>
		protected RProperty r_IsCompleted;
		public virtual RProperty RIsCompleted
		{
			get
			{
				if(r_IsCompleted == null)
				{
					r_IsCompleted = new(this, "IsCompleted", -1);
					r_IsCompleted.SetBelong(this.instance);
				}
				return r_IsCompleted;
			}
		}

		/// <summary>
		/// Boolean IsCompletedSuccessfully
		/// </summary>
		protected RProperty r_IsCompletedSuccessfully;
		public virtual RProperty RIsCompletedSuccessfully
		{
			get
			{
				if(r_IsCompletedSuccessfully == null)
				{
					r_IsCompletedSuccessfully = new(this, "IsCompletedSuccessfully", -1);
					r_IsCompletedSuccessfully.SetBelong(this.instance);
				}
				return r_IsCompletedSuccessfully;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskCreationOptions CreationOptions
		/// </summary>
		protected RProperty r_CreationOptions;
		public virtual RProperty RCreationOptions
		{
			get
			{
				if(r_CreationOptions == null)
				{
					r_CreationOptions = new(this, "CreationOptions", -1);
					r_CreationOptions.SetBelong(this.instance);
				}
				return r_CreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.WaitHandle System.IAsyncResult.AsyncWaitHandle
		/// </summary>
		protected RSystem.RThreading.RWaitHandle r_RSystem__0__IAsyncResult__0__get_AsyncWaitHandle;
		public virtual RSystem.RThreading.RWaitHandle RSystem__0__IAsyncResult__0__get_AsyncWaitHandle
		{
			get
			{
				if(r_RSystem__0__IAsyncResult__0__get_AsyncWaitHandle == null)
				{
					r_RSystem__0__IAsyncResult__0__get_AsyncWaitHandle = new(this, "System.IAsyncResult.AsyncWaitHandle", -1);
					r_RSystem__0__IAsyncResult__0__get_AsyncWaitHandle.SetBelong(this.instance);
				}
				return r_RSystem__0__IAsyncResult__0__get_AsyncWaitHandle;
			}
		}

		/// <summary>
		/// System.Object AsyncState
		/// </summary>
		protected RSystem.RObject r_AsyncState;
		public virtual RSystem.RObject RAsyncState
		{
			get
			{
				if(r_AsyncState == null)
				{
					r_AsyncState = new(this, "AsyncState", -1);
					r_AsyncState.SetBelong(this.instance);
				}
				return r_AsyncState;
			}
		}

		/// <summary>
		/// Boolean System.IAsyncResult.CompletedSynchronously
		/// </summary>
		protected RProperty r_RSystem__0__IAsyncResult__0__get_CompletedSynchronously;
		public virtual RProperty RSystem__0__IAsyncResult__0__get_CompletedSynchronously
		{
			get
			{
				if(r_RSystem__0__IAsyncResult__0__get_CompletedSynchronously == null)
				{
					r_RSystem__0__IAsyncResult__0__get_CompletedSynchronously = new(this, "System.IAsyncResult.CompletedSynchronously", -1);
					r_RSystem__0__IAsyncResult__0__get_CompletedSynchronously.SetBelong(this.instance);
				}
				return r_RSystem__0__IAsyncResult__0__get_CompletedSynchronously;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskScheduler ExecutingTaskScheduler
		/// </summary>
		protected RSystem.RThreading.RTasks.RTaskScheduler r_ExecutingTaskScheduler;
		public virtual RSystem.RThreading.RTasks.RTaskScheduler RExecutingTaskScheduler
		{
			get
			{
				if(r_ExecutingTaskScheduler == null)
				{
					r_ExecutingTaskScheduler = new(this, "ExecutingTaskScheduler", -1);
					r_ExecutingTaskScheduler.SetBelong(this.instance);
				}
				return r_ExecutingTaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskFactory Factory
		/// </summary>
		protected static RSystem.RThreading.RTasks.RTaskFactory r_Factory;
		public static RSystem.RThreading.RTasks.RTaskFactory RFactory
		{
			get
			{
				if(r_Factory == null)
				{
					r_Factory = new(typeof(System.Threading.Tasks.Task), "Factory", -1);
					r_Factory.SetBelong(null);
				}
				return r_Factory;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task CompletedTask
		/// </summary>
		protected static RSystem.RThreading.RTasks.RTask r_CompletedTask;
		public static RSystem.RThreading.RTasks.RTask RCompletedTask
		{
			get
			{
				if(r_CompletedTask == null)
				{
					r_CompletedTask = new(typeof(System.Threading.Tasks.Task), "CompletedTask", -1);
					r_CompletedTask.SetBelong(null);
				}
				return r_CompletedTask;
			}
		}

		/// <summary>
		/// System.Threading.ManualResetEventSlim CompletedEvent
		/// </summary>
		protected RSystem.RThreading.RManualResetEventSlim r_CompletedEvent;
		public virtual RSystem.RThreading.RManualResetEventSlim RCompletedEvent
		{
			get
			{
				if(r_CompletedEvent == null)
				{
					r_CompletedEvent = new(this, "CompletedEvent", -1);
					r_CompletedEvent.SetBelong(this.instance);
				}
				return r_CompletedEvent;
			}
		}

		/// <summary>
		/// Boolean ExceptionRecorded
		/// </summary>
		protected RProperty r_ExceptionRecorded;
		public virtual RProperty RExceptionRecorded
		{
			get
			{
				if(r_ExceptionRecorded == null)
				{
					r_ExceptionRecorded = new(this, "ExceptionRecorded", -1);
					r_ExceptionRecorded.SetBelong(this.instance);
				}
				return r_ExceptionRecorded;
			}
		}

		/// <summary>
		/// Boolean IsFaulted
		/// </summary>
		protected RProperty r_IsFaulted;
		public virtual RProperty RIsFaulted
		{
			get
			{
				if(r_IsFaulted == null)
				{
					r_IsFaulted = new(this, "IsFaulted", -1);
					r_IsFaulted.SetBelong(this.instance);
				}
				return r_IsFaulted;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext CapturedContext
		/// </summary>
		protected RSystem.RThreading.RExecutionContext r_CapturedContext;
		public virtual RSystem.RThreading.RExecutionContext RCapturedContext
		{
			get
			{
				if(r_CapturedContext == null)
				{
					r_CapturedContext = new(this, "CapturedContext", -1);
					r_CapturedContext.SetBelong(this.instance);
				}
				return r_CapturedContext;
			}
		}

		/// <summary>
		/// Boolean IsExceptionObservedByParent
		/// </summary>
		protected RProperty r_IsExceptionObservedByParent;
		public virtual RProperty RIsExceptionObservedByParent
		{
			get
			{
				if(r_IsExceptionObservedByParent == null)
				{
					r_IsExceptionObservedByParent = new(this, "IsExceptionObservedByParent", -1);
					r_IsExceptionObservedByParent.SetBelong(this.instance);
				}
				return r_IsExceptionObservedByParent;
			}
		}

		/// <summary>
		/// Boolean IsDelegateInvoked
		/// </summary>
		protected RProperty r_IsDelegateInvoked;
		public virtual RProperty RIsDelegateInvoked
		{
			get
			{
				if(r_IsDelegateInvoked == null)
				{
					r_IsDelegateInvoked = new(this, "IsDelegateInvoked", -1);
					r_IsDelegateInvoked.SetBelong(this.instance);
				}
				return r_IsDelegateInvoked;
			}
		}

		/// <summary>
		/// Void TaskConstructorCore(System.Delegate, System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.InternalTaskOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RTaskConstructorCore_Delegate_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler;
		public virtual RMethod RTaskConstructorCore_Delegate_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler
		{
			get
			{
				if(r_RTaskConstructorCore_Delegate_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler == null)
				{
					r_RTaskConstructorCore_Delegate_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler = new(this, "TaskConstructorCore", 0, typeof(System.Delegate), typeof(System.Object), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskCreationOptions),  ReleactionUtils.GetType("System.Threading.Tasks.InternalTaskOptions"), typeof(System.Threading.Tasks.TaskScheduler));
					r_RTaskConstructorCore_Delegate_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_RTaskConstructorCore_Delegate_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// Void AssignCancellationToken(System.Threading.CancellationToken, System.Threading.Tasks.Task, System.Threading.Tasks.TaskContinuation)
		/// </summary>
		protected RMethod r_RAssignCancellationToken_CancellationToken_Task_TaskContinuation;
		public virtual RMethod RAssignCancellationToken_CancellationToken_Task_TaskContinuation
		{
			get
			{
				if(r_RAssignCancellationToken_CancellationToken_Task_TaskContinuation == null)
				{
					r_RAssignCancellationToken_CancellationToken_Task_TaskContinuation = new(this, "AssignCancellationToken", 0, typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.Task),  ReleactionUtils.GetType("System.Threading.Tasks.TaskContinuation"));
					r_RAssignCancellationToken_CancellationToken_Task_TaskContinuation.SetBelong(this.instance);
				}
				return r_RAssignCancellationToken_CancellationToken_Task_TaskContinuation;
			}
		}

		/// <summary>
		/// Void TaskCancelCallback(System.Object)
		/// </summary>
		protected static RMethod r_RTaskCancelCallback_Object;
		public static RMethod RTaskCancelCallback_Object
		{
			get
			{
				if(r_RTaskCancelCallback_Object == null)
				{
					r_RTaskCancelCallback_Object = new(typeof(System.Threading.Tasks.Task), "TaskCancelCallback", 0, typeof(System.Object));
					r_RTaskCancelCallback_Object.SetBelong(null);
				}
				return r_RTaskCancelCallback_Object;
			}
		}

		/// <summary>
		/// Boolean TrySetCanceled(System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RTrySetCanceled_CancellationToken;
		public virtual RMethod RTrySetCanceled_CancellationToken
		{
			get
			{
				if(r_RTrySetCanceled_CancellationToken == null)
				{
					r_RTrySetCanceled_CancellationToken = new(this, "TrySetCanceled", 0, typeof(System.Threading.CancellationToken));
					r_RTrySetCanceled_CancellationToken.SetBelong(this.instance);
				}
				return r_RTrySetCanceled_CancellationToken;
			}
		}

		/// <summary>
		/// Boolean TrySetCanceled(System.Threading.CancellationToken, System.Object)
		/// </summary>
		protected RMethod r_RTrySetCanceled_CancellationToken_Object;
		public virtual RMethod RTrySetCanceled_CancellationToken_Object
		{
			get
			{
				if(r_RTrySetCanceled_CancellationToken_Object == null)
				{
					r_RTrySetCanceled_CancellationToken_Object = new(this, "TrySetCanceled", 0, typeof(System.Threading.CancellationToken), typeof(System.Object));
					r_RTrySetCanceled_CancellationToken_Object.SetBelong(this.instance);
				}
				return r_RTrySetCanceled_CancellationToken_Object;
			}
		}

		/// <summary>
		/// Boolean TrySetException(System.Object)
		/// </summary>
		protected RMethod r_RTrySetException_Object;
		public virtual RMethod RTrySetException_Object
		{
			get
			{
				if(r_RTrySetException_Object == null)
				{
					r_RTrySetException_Object = new(this, "TrySetException", 0, typeof(System.Object));
					r_RTrySetException_Object.SetBelong(this.instance);
				}
				return r_RTrySetException_Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskCreationOptions OptionsMethod(Int32)
		/// </summary>
		protected static RMethod r_ROptionsMethod_Int32;
		public static RMethod ROptionsMethod_Int32
		{
			get
			{
				if(r_ROptionsMethod_Int32 == null)
				{
					r_ROptionsMethod_Int32 = new(typeof(System.Threading.Tasks.Task), "OptionsMethod", 0, typeof(System.Int32));
					r_ROptionsMethod_Int32.SetBelong(null);
				}
				return r_ROptionsMethod_Int32;
			}
		}

		/// <summary>
		/// Boolean AtomicStateUpdate(Int32, Int32)
		/// </summary>
		protected RMethod r_RAtomicStateUpdate_Int32_Int32;
		public virtual RMethod RAtomicStateUpdate_Int32_Int32
		{
			get
			{
				if(r_RAtomicStateUpdate_Int32_Int32 == null)
				{
					r_RAtomicStateUpdate_Int32_Int32 = new(this, "AtomicStateUpdate", 0, typeof(System.Int32), typeof(System.Int32));
					r_RAtomicStateUpdate_Int32_Int32.SetBelong(this.instance);
				}
				return r_RAtomicStateUpdate_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean AtomicStateUpdate(Int32, Int32, Int32 ByRef)
		/// </summary>
		protected RMethod r_RAtomicStateUpdate_Int32_Int32_Ref_Int32;
		public virtual RMethod RAtomicStateUpdate_Int32_Int32_Ref_Int32
		{
			get
			{
				if(r_RAtomicStateUpdate_Int32_Int32_Ref_Int32 == null)
				{
					r_RAtomicStateUpdate_Int32_Int32_Ref_Int32 = new(this, "AtomicStateUpdate", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32).MakeByRefType());
					r_RAtomicStateUpdate_Int32_Int32_Ref_Int32.SetBelong(this.instance);
				}
				return r_RAtomicStateUpdate_Int32_Int32_Ref_Int32;
			}
		}

		/// <summary>
		/// Void SetNotificationForWaitCompletion(Boolean)
		/// </summary>
		protected RMethod r_RSetNotificationForWaitCompletion_Boolean;
		public virtual RMethod RSetNotificationForWaitCompletion_Boolean
		{
			get
			{
				if(r_RSetNotificationForWaitCompletion_Boolean == null)
				{
					r_RSetNotificationForWaitCompletion_Boolean = new(this, "SetNotificationForWaitCompletion", 0, typeof(System.Boolean));
					r_RSetNotificationForWaitCompletion_Boolean.SetBelong(this.instance);
				}
				return r_RSetNotificationForWaitCompletion_Boolean;
			}
		}

		/// <summary>
		/// Boolean NotifyDebuggerOfWaitCompletionIfNecessary()
		/// </summary>
		protected RMethod r_RNotifyDebuggerOfWaitCompletionIfNecessary;
		public virtual RMethod RNotifyDebuggerOfWaitCompletionIfNecessary
		{
			get
			{
				if(r_RNotifyDebuggerOfWaitCompletionIfNecessary == null)
				{
					r_RNotifyDebuggerOfWaitCompletionIfNecessary = new(this, "NotifyDebuggerOfWaitCompletionIfNecessary", 0);
					r_RNotifyDebuggerOfWaitCompletionIfNecessary.SetBelong(this.instance);
				}
				return r_RNotifyDebuggerOfWaitCompletionIfNecessary;
			}
		}

		/// <summary>
		/// Boolean AnyTaskRequiresNotifyDebuggerOfWaitCompletion(System.Threading.Tasks.Task[])
		/// </summary>
		protected static RMethod r_RAnyTaskRequiresNotifyDebuggerOfWaitCompletion_TaskArray;
		public static RMethod RAnyTaskRequiresNotifyDebuggerOfWaitCompletion_TaskArray
		{
			get
			{
				if(r_RAnyTaskRequiresNotifyDebuggerOfWaitCompletion_TaskArray == null)
				{
					r_RAnyTaskRequiresNotifyDebuggerOfWaitCompletion_TaskArray = new(typeof(System.Threading.Tasks.Task), "AnyTaskRequiresNotifyDebuggerOfWaitCompletion", 0, typeof(System.Threading.Tasks.Task).MakeArrayType());
					r_RAnyTaskRequiresNotifyDebuggerOfWaitCompletion_TaskArray.SetBelong(null);
				}
				return r_RAnyTaskRequiresNotifyDebuggerOfWaitCompletion_TaskArray;
			}
		}

		/// <summary>
		/// Void NotifyDebuggerOfWaitCompletion()
		/// </summary>
		protected RMethod r_RNotifyDebuggerOfWaitCompletion;
		public virtual RMethod RNotifyDebuggerOfWaitCompletion
		{
			get
			{
				if(r_RNotifyDebuggerOfWaitCompletion == null)
				{
					r_RNotifyDebuggerOfWaitCompletion = new(this, "NotifyDebuggerOfWaitCompletion", 0);
					r_RNotifyDebuggerOfWaitCompletion.SetBelong(this.instance);
				}
				return r_RNotifyDebuggerOfWaitCompletion;
			}
		}

		/// <summary>
		/// Boolean MarkStarted()
		/// </summary>
		protected RMethod r_RMarkStarted;
		public virtual RMethod RMarkStarted
		{
			get
			{
				if(r_RMarkStarted == null)
				{
					r_RMarkStarted = new(this, "MarkStarted", 0);
					r_RMarkStarted.SetBelong(this.instance);
				}
				return r_RMarkStarted;
			}
		}

		/// <summary>
		/// Void AddNewChild()
		/// </summary>
		protected RMethod r_RAddNewChild;
		public virtual RMethod RAddNewChild
		{
			get
			{
				if(r_RAddNewChild == null)
				{
					r_RAddNewChild = new(this, "AddNewChild", 0);
					r_RAddNewChild.SetBelong(this.instance);
				}
				return r_RAddNewChild;
			}
		}

		/// <summary>
		/// Void DisregardChild()
		/// </summary>
		protected RMethod r_RDisregardChild;
		public virtual RMethod RDisregardChild
		{
			get
			{
				if(r_RDisregardChild == null)
				{
					r_RDisregardChild = new(this, "DisregardChild", 0);
					r_RDisregardChild.SetBelong(this.instance);
				}
				return r_RDisregardChild;
			}
		}

		/// <summary>
		/// Void Start()
		/// </summary>
		protected RMethod r_RStart;
		public virtual RMethod RStart
		{
			get
			{
				if(r_RStart == null)
				{
					r_RStart = new(this, "Start", 0);
					r_RStart.SetBelong(this.instance);
				}
				return r_RStart;
			}
		}

		/// <summary>
		/// Void Start(System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RStart_TaskScheduler;
		public virtual RMethod RStart_TaskScheduler
		{
			get
			{
				if(r_RStart_TaskScheduler == null)
				{
					r_RStart_TaskScheduler = new(this, "Start", 0, typeof(System.Threading.Tasks.TaskScheduler));
					r_RStart_TaskScheduler.SetBelong(this.instance);
				}
				return r_RStart_TaskScheduler;
			}
		}

		/// <summary>
		/// Void RunSynchronously()
		/// </summary>
		protected RMethod r_RRunSynchronously;
		public virtual RMethod RRunSynchronously
		{
			get
			{
				if(r_RRunSynchronously == null)
				{
					r_RRunSynchronously = new(this, "RunSynchronously", 0);
					r_RRunSynchronously.SetBelong(this.instance);
				}
				return r_RRunSynchronously;
			}
		}

		/// <summary>
		/// Void RunSynchronously(System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RRunSynchronously_TaskScheduler;
		public virtual RMethod RRunSynchronously_TaskScheduler
		{
			get
			{
				if(r_RRunSynchronously_TaskScheduler == null)
				{
					r_RRunSynchronously_TaskScheduler = new(this, "RunSynchronously", 0, typeof(System.Threading.Tasks.TaskScheduler));
					r_RRunSynchronously_TaskScheduler.SetBelong(this.instance);
				}
				return r_RRunSynchronously_TaskScheduler;
			}
		}

		/// <summary>
		/// Void InternalRunSynchronously(System.Threading.Tasks.TaskScheduler, Boolean)
		/// </summary>
		protected RMethod r_RInternalRunSynchronously_TaskScheduler_Boolean;
		public virtual RMethod RInternalRunSynchronously_TaskScheduler_Boolean
		{
			get
			{
				if(r_RInternalRunSynchronously_TaskScheduler_Boolean == null)
				{
					r_RInternalRunSynchronously_TaskScheduler_Boolean = new(this, "InternalRunSynchronously", 0, typeof(System.Threading.Tasks.TaskScheduler), typeof(System.Boolean));
					r_RInternalRunSynchronously_TaskScheduler_Boolean.SetBelong(this.instance);
				}
				return r_RInternalRunSynchronously_TaskScheduler_Boolean;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task InternalStartNew(System.Threading.Tasks.Task, System.Delegate, System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskScheduler, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.InternalTaskOptions)
		/// </summary>
		protected static RMethod r_RInternalStartNew_Task_Delegate_Object_CancellationToken_TaskScheduler_TaskCreationOptions_InternalTaskOptions;
		public static RMethod RInternalStartNew_Task_Delegate_Object_CancellationToken_TaskScheduler_TaskCreationOptions_InternalTaskOptions
		{
			get
			{
				if(r_RInternalStartNew_Task_Delegate_Object_CancellationToken_TaskScheduler_TaskCreationOptions_InternalTaskOptions == null)
				{
					r_RInternalStartNew_Task_Delegate_Object_CancellationToken_TaskScheduler_TaskCreationOptions_InternalTaskOptions = new(typeof(System.Threading.Tasks.Task), "InternalStartNew", 0, typeof(System.Threading.Tasks.Task), typeof(System.Delegate), typeof(System.Object), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskScheduler), typeof(System.Threading.Tasks.TaskCreationOptions),  ReleactionUtils.GetType("System.Threading.Tasks.InternalTaskOptions"));
					r_RInternalStartNew_Task_Delegate_Object_CancellationToken_TaskScheduler_TaskCreationOptions_InternalTaskOptions.SetBelong(null);
				}
				return r_RInternalStartNew_Task_Delegate_Object_CancellationToken_TaskScheduler_TaskCreationOptions_InternalTaskOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task InternalCurrentIfAttached(System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected static RMethod r_RInternalCurrentIfAttached_TaskCreationOptions;
		public static RMethod RInternalCurrentIfAttached_TaskCreationOptions
		{
			get
			{
				if(r_RInternalCurrentIfAttached_TaskCreationOptions == null)
				{
					r_RInternalCurrentIfAttached_TaskCreationOptions = new(typeof(System.Threading.Tasks.Task), "InternalCurrentIfAttached", 0, typeof(System.Threading.Tasks.TaskCreationOptions));
					r_RInternalCurrentIfAttached_TaskCreationOptions.SetBelong(null);
				}
				return r_RInternalCurrentIfAttached_TaskCreationOptions;
			}
		}

		/// <summary>
		/// ContingentProperties EnsureContingentPropertiesInitialized(Boolean)
		/// </summary>
		protected RMethod r_REnsureContingentPropertiesInitialized_Boolean;
		public virtual RMethod REnsureContingentPropertiesInitialized_Boolean
		{
			get
			{
				if(r_REnsureContingentPropertiesInitialized_Boolean == null)
				{
					r_REnsureContingentPropertiesInitialized_Boolean = new(this, "EnsureContingentPropertiesInitialized", 0, typeof(System.Boolean));
					r_REnsureContingentPropertiesInitialized_Boolean.SetBelong(this.instance);
				}
				return r_REnsureContingentPropertiesInitialized_Boolean;
			}
		}

		/// <summary>
		/// ContingentProperties EnsureContingentPropertiesInitializedCore(Boolean)
		/// </summary>
		protected RMethod r_REnsureContingentPropertiesInitializedCore_Boolean;
		public virtual RMethod REnsureContingentPropertiesInitializedCore_Boolean
		{
			get
			{
				if(r_REnsureContingentPropertiesInitializedCore_Boolean == null)
				{
					r_REnsureContingentPropertiesInitializedCore_Boolean = new(this, "EnsureContingentPropertiesInitializedCore", 0, typeof(System.Boolean));
					r_REnsureContingentPropertiesInitializedCore_Boolean.SetBelong(this.instance);
				}
				return r_REnsureContingentPropertiesInitializedCore_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsCompletedMethod(Int32)
		/// </summary>
		protected static RMethod r_RIsCompletedMethod_Int32;
		public static RMethod RIsCompletedMethod_Int32
		{
			get
			{
				if(r_RIsCompletedMethod_Int32 == null)
				{
					r_RIsCompletedMethod_Int32 = new(typeof(System.Threading.Tasks.Task), "IsCompletedMethod", 0, typeof(System.Int32));
					r_RIsCompletedMethod_Int32.SetBelong(null);
				}
				return r_RIsCompletedMethod_Int32;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_RDispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_RDispose == null)
				{
					r_RDispose = new(this, "Dispose", 0);
					r_RDispose.SetBelong(this.instance);
				}
				return r_RDispose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_RDispose_Boolean;
		public virtual RMethod RDispose_Boolean
		{
			get
			{
				if(r_RDispose_Boolean == null)
				{
					r_RDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_RDispose_Boolean.SetBelong(this.instance);
				}
				return r_RDispose_Boolean;
			}
		}

		/// <summary>
		/// Void ScheduleAndStart(Boolean)
		/// </summary>
		protected RMethod r_RScheduleAndStart_Boolean;
		public virtual RMethod RScheduleAndStart_Boolean
		{
			get
			{
				if(r_RScheduleAndStart_Boolean == null)
				{
					r_RScheduleAndStart_Boolean = new(this, "ScheduleAndStart", 0, typeof(System.Boolean));
					r_RScheduleAndStart_Boolean.SetBelong(this.instance);
				}
				return r_RScheduleAndStart_Boolean;
			}
		}

		/// <summary>
		/// Void AddException(System.Object)
		/// </summary>
		protected RMethod r_RAddException_Object;
		public virtual RMethod RAddException_Object
		{
			get
			{
				if(r_RAddException_Object == null)
				{
					r_RAddException_Object = new(this, "AddException", 0, typeof(System.Object));
					r_RAddException_Object.SetBelong(this.instance);
				}
				return r_RAddException_Object;
			}
		}

		/// <summary>
		/// Void AddException(System.Object, Boolean)
		/// </summary>
		protected RMethod r_RAddException_Object_Boolean;
		public virtual RMethod RAddException_Object_Boolean
		{
			get
			{
				if(r_RAddException_Object_Boolean == null)
				{
					r_RAddException_Object_Boolean = new(this, "AddException", 0, typeof(System.Object), typeof(System.Boolean));
					r_RAddException_Object_Boolean.SetBelong(this.instance);
				}
				return r_RAddException_Object_Boolean;
			}
		}

		/// <summary>
		/// System.AggregateException GetExceptions(Boolean)
		/// </summary>
		protected RMethod r_RGetExceptions_Boolean;
		public virtual RMethod RGetExceptions_Boolean
		{
			get
			{
				if(r_RGetExceptions_Boolean == null)
				{
					r_RGetExceptions_Boolean = new(this, "GetExceptions", 0, typeof(System.Boolean));
					r_RGetExceptions_Boolean.SetBelong(this.instance);
				}
				return r_RGetExceptions_Boolean;
			}
		}

		/// <summary>
		/// System.Collections.ObjectModel.ReadOnlyCollection`1[System.Runtime.ExceptionServices.ExceptionDispatchInfo] GetExceptionDispatchInfos()
		/// </summary>
		protected RMethod r_RGetExceptionDispatchInfos;
		public virtual RMethod RGetExceptionDispatchInfos
		{
			get
			{
				if(r_RGetExceptionDispatchInfos == null)
				{
					r_RGetExceptionDispatchInfos = new(this, "GetExceptionDispatchInfos", 0);
					r_RGetExceptionDispatchInfos.SetBelong(this.instance);
				}
				return r_RGetExceptionDispatchInfos;
			}
		}

		/// <summary>
		/// System.Runtime.ExceptionServices.ExceptionDispatchInfo GetCancellationExceptionDispatchInfo()
		/// </summary>
		protected RMethod r_RGetCancellationExceptionDispatchInfo;
		public virtual RMethod RGetCancellationExceptionDispatchInfo
		{
			get
			{
				if(r_RGetCancellationExceptionDispatchInfo == null)
				{
					r_RGetCancellationExceptionDispatchInfo = new(this, "GetCancellationExceptionDispatchInfo", 0);
					r_RGetCancellationExceptionDispatchInfo.SetBelong(this.instance);
				}
				return r_RGetCancellationExceptionDispatchInfo;
			}
		}

		/// <summary>
		/// Void ThrowIfExceptional(Boolean)
		/// </summary>
		protected RMethod r_RThrowIfExceptional_Boolean;
		public virtual RMethod RThrowIfExceptional_Boolean
		{
			get
			{
				if(r_RThrowIfExceptional_Boolean == null)
				{
					r_RThrowIfExceptional_Boolean = new(this, "ThrowIfExceptional", 0, typeof(System.Boolean));
					r_RThrowIfExceptional_Boolean.SetBelong(this.instance);
				}
				return r_RThrowIfExceptional_Boolean;
			}
		}

		/// <summary>
		/// Void UpdateExceptionObservedStatus()
		/// </summary>
		protected RMethod r_RUpdateExceptionObservedStatus;
		public virtual RMethod RUpdateExceptionObservedStatus
		{
			get
			{
				if(r_RUpdateExceptionObservedStatus == null)
				{
					r_RUpdateExceptionObservedStatus = new(this, "UpdateExceptionObservedStatus", 0);
					r_RUpdateExceptionObservedStatus.SetBelong(this.instance);
				}
				return r_RUpdateExceptionObservedStatus;
			}
		}

		/// <summary>
		/// Void Finish(Boolean)
		/// </summary>
		protected RMethod r_RFinish_Boolean;
		public virtual RMethod RFinish_Boolean
		{
			get
			{
				if(r_RFinish_Boolean == null)
				{
					r_RFinish_Boolean = new(this, "Finish", 0, typeof(System.Boolean));
					r_RFinish_Boolean.SetBelong(this.instance);
				}
				return r_RFinish_Boolean;
			}
		}

		/// <summary>
		/// Void FinishStageTwo()
		/// </summary>
		protected RMethod r_RFinishStageTwo;
		public virtual RMethod RFinishStageTwo
		{
			get
			{
				if(r_RFinishStageTwo == null)
				{
					r_RFinishStageTwo = new(this, "FinishStageTwo", 0);
					r_RFinishStageTwo.SetBelong(this.instance);
				}
				return r_RFinishStageTwo;
			}
		}

		/// <summary>
		/// Void FinishStageThree()
		/// </summary>
		protected RMethod r_RFinishStageThree;
		public virtual RMethod RFinishStageThree
		{
			get
			{
				if(r_RFinishStageThree == null)
				{
					r_RFinishStageThree = new(this, "FinishStageThree", 0);
					r_RFinishStageThree.SetBelong(this.instance);
				}
				return r_RFinishStageThree;
			}
		}

		/// <summary>
		/// Void ProcessChildCompletion(System.Threading.Tasks.Task)
		/// </summary>
		protected RMethod r_RProcessChildCompletion_Task;
		public virtual RMethod RProcessChildCompletion_Task
		{
			get
			{
				if(r_RProcessChildCompletion_Task == null)
				{
					r_RProcessChildCompletion_Task = new(this, "ProcessChildCompletion", 0, typeof(System.Threading.Tasks.Task));
					r_RProcessChildCompletion_Task.SetBelong(this.instance);
				}
				return r_RProcessChildCompletion_Task;
			}
		}

		/// <summary>
		/// Void AddExceptionsFromChildren()
		/// </summary>
		protected RMethod r_RAddExceptionsFromChildren;
		public virtual RMethod RAddExceptionsFromChildren
		{
			get
			{
				if(r_RAddExceptionsFromChildren == null)
				{
					r_RAddExceptionsFromChildren = new(this, "AddExceptionsFromChildren", 0);
					r_RAddExceptionsFromChildren.SetBelong(this.instance);
				}
				return r_RAddExceptionsFromChildren;
			}
		}

		/// <summary>
		/// Void Execute()
		/// </summary>
		protected RMethod r_RExecute;
		public virtual RMethod RExecute
		{
			get
			{
				if(r_RExecute == null)
				{
					r_RExecute = new(this, "Execute", 0);
					r_RExecute.SetBelong(this.instance);
				}
				return r_RExecute;
			}
		}

		/// <summary>
		/// Void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem()
		/// </summary>
		protected RMethod r_RSystem__0__Threading__0__IThreadPoolWorkItem__0__ExecuteWorkItem;
		public virtual RMethod RSystem__0__Threading__0__IThreadPoolWorkItem__0__ExecuteWorkItem
		{
			get
			{
				if(r_RSystem__0__Threading__0__IThreadPoolWorkItem__0__ExecuteWorkItem == null)
				{
					r_RSystem__0__Threading__0__IThreadPoolWorkItem__0__ExecuteWorkItem = new(this, "System.Threading.IThreadPoolWorkItem.ExecuteWorkItem", 0);
					r_RSystem__0__Threading__0__IThreadPoolWorkItem__0__ExecuteWorkItem.SetBelong(this.instance);
				}
				return r_RSystem__0__Threading__0__IThreadPoolWorkItem__0__ExecuteWorkItem;
			}
		}

		/// <summary>
		/// Boolean ExecuteEntry(Boolean)
		/// </summary>
		protected RMethod r_RExecuteEntry_Boolean;
		public virtual RMethod RExecuteEntry_Boolean
		{
			get
			{
				if(r_RExecuteEntry_Boolean == null)
				{
					r_RExecuteEntry_Boolean = new(this, "ExecuteEntry", 0, typeof(System.Boolean));
					r_RExecuteEntry_Boolean.SetBelong(this.instance);
				}
				return r_RExecuteEntry_Boolean;
			}
		}

		/// <summary>
		/// Void ExecutionContextCallback(System.Object)
		/// </summary>
		protected static RMethod r_RExecutionContextCallback_Object;
		public static RMethod RExecutionContextCallback_Object
		{
			get
			{
				if(r_RExecutionContextCallback_Object == null)
				{
					r_RExecutionContextCallback_Object = new(typeof(System.Threading.Tasks.Task), "ExecutionContextCallback", 0, typeof(System.Object));
					r_RExecutionContextCallback_Object.SetBelong(null);
				}
				return r_RExecutionContextCallback_Object;
			}
		}

		/// <summary>
		/// Void InnerInvoke()
		/// </summary>
		protected RMethod r_RInnerInvoke;
		public virtual RMethod RInnerInvoke
		{
			get
			{
				if(r_RInnerInvoke == null)
				{
					r_RInnerInvoke = new(this, "InnerInvoke", 0);
					r_RInnerInvoke.SetBelong(this.instance);
				}
				return r_RInnerInvoke;
			}
		}

		/// <summary>
		/// Void HandleException(System.Exception)
		/// </summary>
		protected RMethod r_RHandleException_Exception;
		public virtual RMethod RHandleException_Exception
		{
			get
			{
				if(r_RHandleException_Exception == null)
				{
					r_RHandleException_Exception = new(this, "HandleException", 0, typeof(System.Exception));
					r_RHandleException_Exception.SetBelong(this.instance);
				}
				return r_RHandleException_Exception;
			}
		}

		/// <summary>
		/// System.Runtime.CompilerServices.TaskAwaiter GetAwaiter()
		/// </summary>
		protected RMethod r_RGetAwaiter;
		public virtual RMethod RGetAwaiter
		{
			get
			{
				if(r_RGetAwaiter == null)
				{
					r_RGetAwaiter = new(this, "GetAwaiter", 0);
					r_RGetAwaiter.SetBelong(this.instance);
				}
				return r_RGetAwaiter;
			}
		}

		/// <summary>
		/// System.Runtime.CompilerServices.ConfiguredTaskAwaitable ConfigureAwait(Boolean)
		/// </summary>
		protected RMethod r_RConfigureAwait_Boolean;
		public virtual RMethod RConfigureAwait_Boolean
		{
			get
			{
				if(r_RConfigureAwait_Boolean == null)
				{
					r_RConfigureAwait_Boolean = new(this, "ConfigureAwait", 0, typeof(System.Boolean));
					r_RConfigureAwait_Boolean.SetBelong(this.instance);
				}
				return r_RConfigureAwait_Boolean;
			}
		}

		/// <summary>
		/// Void SetContinuationForAwait(System.Action, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RSetContinuationForAwait_Action_Boolean_Boolean;
		public virtual RMethod RSetContinuationForAwait_Action_Boolean_Boolean
		{
			get
			{
				if(r_RSetContinuationForAwait_Action_Boolean_Boolean == null)
				{
					r_RSetContinuationForAwait_Action_Boolean_Boolean = new(this, "SetContinuationForAwait", 0, typeof(System.Action), typeof(System.Boolean), typeof(System.Boolean));
					r_RSetContinuationForAwait_Action_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RSetContinuationForAwait_Action_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Runtime.CompilerServices.YieldAwaitable Yield()
		/// </summary>
		protected static RMethod r_RYield;
		public static RMethod RYield
		{
			get
			{
				if(r_RYield == null)
				{
					r_RYield = new(typeof(System.Threading.Tasks.Task), "Yield", 0);
					r_RYield.SetBelong(null);
				}
				return r_RYield;
			}
		}

		/// <summary>
		/// Void Wait()
		/// </summary>
		protected RMethod r_RWait;
		public virtual RMethod RWait
		{
			get
			{
				if(r_RWait == null)
				{
					r_RWait = new(this, "Wait", 0);
					r_RWait.SetBelong(this.instance);
				}
				return r_RWait;
			}
		}

		/// <summary>
		/// Boolean Wait(System.TimeSpan)
		/// </summary>
		protected RMethod r_RWait_TimeSpan;
		public virtual RMethod RWait_TimeSpan
		{
			get
			{
				if(r_RWait_TimeSpan == null)
				{
					r_RWait_TimeSpan = new(this, "Wait", 0, typeof(System.TimeSpan));
					r_RWait_TimeSpan.SetBelong(this.instance);
				}
				return r_RWait_TimeSpan;
			}
		}

		/// <summary>
		/// Void Wait(System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RWait_CancellationToken;
		public virtual RMethod RWait_CancellationToken
		{
			get
			{
				if(r_RWait_CancellationToken == null)
				{
					r_RWait_CancellationToken = new(this, "Wait", 0, typeof(System.Threading.CancellationToken));
					r_RWait_CancellationToken.SetBelong(this.instance);
				}
				return r_RWait_CancellationToken;
			}
		}

		/// <summary>
		/// Boolean Wait(Int32)
		/// </summary>
		protected RMethod r_RWait_Int32;
		public virtual RMethod RWait_Int32
		{
			get
			{
				if(r_RWait_Int32 == null)
				{
					r_RWait_Int32 = new(this, "Wait", 0, typeof(System.Int32));
					r_RWait_Int32.SetBelong(this.instance);
				}
				return r_RWait_Int32;
			}
		}

		/// <summary>
		/// Boolean Wait(Int32, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RWait_Int32_CancellationToken;
		public virtual RMethod RWait_Int32_CancellationToken
		{
			get
			{
				if(r_RWait_Int32_CancellationToken == null)
				{
					r_RWait_Int32_CancellationToken = new(this, "Wait", 0, typeof(System.Int32), typeof(System.Threading.CancellationToken));
					r_RWait_Int32_CancellationToken.SetBelong(this.instance);
				}
				return r_RWait_Int32_CancellationToken;
			}
		}

		/// <summary>
		/// Boolean WrappedTryRunInline()
		/// </summary>
		protected RMethod r_RWrappedTryRunInline;
		public virtual RMethod RWrappedTryRunInline
		{
			get
			{
				if(r_RWrappedTryRunInline == null)
				{
					r_RWrappedTryRunInline = new(this, "WrappedTryRunInline", 0);
					r_RWrappedTryRunInline.SetBelong(this.instance);
				}
				return r_RWrappedTryRunInline;
			}
		}

		/// <summary>
		/// Boolean InternalWait(Int32, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RInternalWait_Int32_CancellationToken;
		public virtual RMethod RInternalWait_Int32_CancellationToken
		{
			get
			{
				if(r_RInternalWait_Int32_CancellationToken == null)
				{
					r_RInternalWait_Int32_CancellationToken = new(this, "InternalWait", 0, typeof(System.Int32), typeof(System.Threading.CancellationToken));
					r_RInternalWait_Int32_CancellationToken.SetBelong(this.instance);
				}
				return r_RInternalWait_Int32_CancellationToken;
			}
		}

		/// <summary>
		/// Boolean SpinThenBlockingWait(Int32, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RSpinThenBlockingWait_Int32_CancellationToken;
		public virtual RMethod RSpinThenBlockingWait_Int32_CancellationToken
		{
			get
			{
				if(r_RSpinThenBlockingWait_Int32_CancellationToken == null)
				{
					r_RSpinThenBlockingWait_Int32_CancellationToken = new(this, "SpinThenBlockingWait", 0, typeof(System.Int32), typeof(System.Threading.CancellationToken));
					r_RSpinThenBlockingWait_Int32_CancellationToken.SetBelong(this.instance);
				}
				return r_RSpinThenBlockingWait_Int32_CancellationToken;
			}
		}

		/// <summary>
		/// Boolean SpinWait(Int32)
		/// </summary>
		protected RMethod r_RSpinWait_Int32;
		public virtual RMethod RSpinWait_Int32
		{
			get
			{
				if(r_RSpinWait_Int32 == null)
				{
					r_RSpinWait_Int32 = new(this, "SpinWait", 0, typeof(System.Int32));
					r_RSpinWait_Int32.SetBelong(this.instance);
				}
				return r_RSpinWait_Int32;
			}
		}

		/// <summary>
		/// Boolean InternalCancel(Boolean)
		/// </summary>
		protected RMethod r_RInternalCancel_Boolean;
		public virtual RMethod RInternalCancel_Boolean
		{
			get
			{
				if(r_RInternalCancel_Boolean == null)
				{
					r_RInternalCancel_Boolean = new(this, "InternalCancel", 0, typeof(System.Boolean));
					r_RInternalCancel_Boolean.SetBelong(this.instance);
				}
				return r_RInternalCancel_Boolean;
			}
		}

		/// <summary>
		/// Void RecordInternalCancellationRequest()
		/// </summary>
		protected RMethod r_RRecordInternalCancellationRequest;
		public virtual RMethod RRecordInternalCancellationRequest
		{
			get
			{
				if(r_RRecordInternalCancellationRequest == null)
				{
					r_RRecordInternalCancellationRequest = new(this, "RecordInternalCancellationRequest", 0);
					r_RRecordInternalCancellationRequest.SetBelong(this.instance);
				}
				return r_RRecordInternalCancellationRequest;
			}
		}

		/// <summary>
		/// Void RecordInternalCancellationRequest(System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RRecordInternalCancellationRequest_CancellationToken;
		public virtual RMethod RRecordInternalCancellationRequest_CancellationToken
		{
			get
			{
				if(r_RRecordInternalCancellationRequest_CancellationToken == null)
				{
					r_RRecordInternalCancellationRequest_CancellationToken = new(this, "RecordInternalCancellationRequest", 0, typeof(System.Threading.CancellationToken));
					r_RRecordInternalCancellationRequest_CancellationToken.SetBelong(this.instance);
				}
				return r_RRecordInternalCancellationRequest_CancellationToken;
			}
		}

		/// <summary>
		/// Void RecordInternalCancellationRequest(System.Threading.CancellationToken, System.Object)
		/// </summary>
		protected RMethod r_RRecordInternalCancellationRequest_CancellationToken_Object;
		public virtual RMethod RRecordInternalCancellationRequest_CancellationToken_Object
		{
			get
			{
				if(r_RRecordInternalCancellationRequest_CancellationToken_Object == null)
				{
					r_RRecordInternalCancellationRequest_CancellationToken_Object = new(this, "RecordInternalCancellationRequest", 0, typeof(System.Threading.CancellationToken), typeof(System.Object));
					r_RRecordInternalCancellationRequest_CancellationToken_Object.SetBelong(this.instance);
				}
				return r_RRecordInternalCancellationRequest_CancellationToken_Object;
			}
		}

		/// <summary>
		/// Void CancellationCleanupLogic()
		/// </summary>
		protected RMethod r_RCancellationCleanupLogic;
		public virtual RMethod RCancellationCleanupLogic
		{
			get
			{
				if(r_RCancellationCleanupLogic == null)
				{
					r_RCancellationCleanupLogic = new(this, "CancellationCleanupLogic", 0);
					r_RCancellationCleanupLogic.SetBelong(this.instance);
				}
				return r_RCancellationCleanupLogic;
			}
		}

		/// <summary>
		/// Void SetCancellationAcknowledged()
		/// </summary>
		protected RMethod r_RSetCancellationAcknowledged;
		public virtual RMethod RSetCancellationAcknowledged
		{
			get
			{
				if(r_RSetCancellationAcknowledged == null)
				{
					r_RSetCancellationAcknowledged = new(this, "SetCancellationAcknowledged", 0);
					r_RSetCancellationAcknowledged.SetBelong(this.instance);
				}
				return r_RSetCancellationAcknowledged;
			}
		}

		/// <summary>
		/// Void FinishContinuations()
		/// </summary>
		protected RMethod r_RFinishContinuations;
		public virtual RMethod RFinishContinuations
		{
			get
			{
				if(r_RFinishContinuations == null)
				{
					r_RFinishContinuations = new(this, "FinishContinuations", 0);
					r_RFinishContinuations.SetBelong(this.instance);
				}
				return r_RFinishContinuations;
			}
		}

		/// <summary>
		/// Void LogFinishCompletionNotification()
		/// </summary>
		protected RMethod r_RLogFinishCompletionNotification;
		public virtual RMethod RLogFinishCompletionNotification
		{
			get
			{
				if(r_RLogFinishCompletionNotification == null)
				{
					r_RLogFinishCompletionNotification = new(this, "LogFinishCompletionNotification", 0);
					r_RLogFinishCompletionNotification.SetBelong(this.instance);
				}
				return r_RLogFinishCompletionNotification;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task])
		/// </summary>
		protected RMethod r_RContinueWith_Action_d_Task_p_;
		public virtual RMethod RContinueWith_Action_d_Task_p_
		{
			get
			{
				if(r_RContinueWith_Action_d_Task_p_ == null)
				{
					r_RContinueWith_Action_d_Task_p_ = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task)));
					r_RContinueWith_Action_d_Task_p_.SetBelong(this.instance);
				}
				return r_RContinueWith_Action_d_Task_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RContinueWith_Action_d_Task_p__CancellationToken;
		public virtual RMethod RContinueWith_Action_d_Task_p__CancellationToken
		{
			get
			{
				if(r_RContinueWith_Action_d_Task_p__CancellationToken == null)
				{
					r_RContinueWith_Action_d_Task_p__CancellationToken = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task)), typeof(System.Threading.CancellationToken));
					r_RContinueWith_Action_d_Task_p__CancellationToken.SetBelong(this.instance);
				}
				return r_RContinueWith_Action_d_Task_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task], System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RContinueWith_Action_d_Task_p__TaskScheduler;
		public virtual RMethod RContinueWith_Action_d_Task_p__TaskScheduler
		{
			get
			{
				if(r_RContinueWith_Action_d_Task_p__TaskScheduler == null)
				{
					r_RContinueWith_Action_d_Task_p__TaskScheduler = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task)), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWith_Action_d_Task_p__TaskScheduler.SetBelong(this.instance);
				}
				return r_RContinueWith_Action_d_Task_p__TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task], System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_RContinueWith_Action_d_Task_p__TaskContinuationOptions;
		public virtual RMethod RContinueWith_Action_d_Task_p__TaskContinuationOptions
		{
			get
			{
				if(r_RContinueWith_Action_d_Task_p__TaskContinuationOptions == null)
				{
					r_RContinueWith_Action_d_Task_p__TaskContinuationOptions = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task)), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_RContinueWith_Action_d_Task_p__TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_RContinueWith_Action_d_Task_p__TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task], System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RContinueWith_Action_d_Task_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RContinueWith_Action_d_Task_p__CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_RContinueWith_Action_d_Task_p__CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_RContinueWith_Action_d_Task_p__CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task)), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWith_Action_d_Task_p__CancellationToken_TaskContinuationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_RContinueWith_Action_d_Task_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task], System.Threading.Tasks.TaskScheduler, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_RContinueWith_Action_d_Task_p__TaskScheduler_CancellationToken_TaskContinuationOptions;
		public virtual RMethod RContinueWith_Action_d_Task_p__TaskScheduler_CancellationToken_TaskContinuationOptions
		{
			get
			{
				if(r_RContinueWith_Action_d_Task_p__TaskScheduler_CancellationToken_TaskContinuationOptions == null)
				{
					r_RContinueWith_Action_d_Task_p__TaskScheduler_CancellationToken_TaskContinuationOptions = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task)), typeof(System.Threading.Tasks.TaskScheduler), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_RContinueWith_Action_d_Task_p__TaskScheduler_CancellationToken_TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_RContinueWith_Action_d_Task_p__TaskScheduler_CancellationToken_TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task,System.Object], System.Object)
		/// </summary>
		protected RMethod r_RContinueWith_Action_d_Task_Object_p__Object;
		public virtual RMethod RContinueWith_Action_d_Task_Object_p__Object
		{
			get
			{
				if(r_RContinueWith_Action_d_Task_Object_p__Object == null)
				{
					r_RContinueWith_Action_d_Task_Object_p__Object = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object)), typeof(System.Object));
					r_RContinueWith_Action_d_Task_Object_p__Object.SetBelong(this.instance);
				}
				return r_RContinueWith_Action_d_Task_Object_p__Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task,System.Object], System.Object, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RContinueWith_Action_d_Task_Object_p__Object_CancellationToken;
		public virtual RMethod RContinueWith_Action_d_Task_Object_p__Object_CancellationToken
		{
			get
			{
				if(r_RContinueWith_Action_d_Task_Object_p__Object_CancellationToken == null)
				{
					r_RContinueWith_Action_d_Task_Object_p__Object_CancellationToken = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object)), typeof(System.Object), typeof(System.Threading.CancellationToken));
					r_RContinueWith_Action_d_Task_Object_p__Object_CancellationToken.SetBelong(this.instance);
				}
				return r_RContinueWith_Action_d_Task_Object_p__Object_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task,System.Object], System.Object, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RContinueWith_Action_d_Task_Object_p__Object_TaskScheduler;
		public virtual RMethod RContinueWith_Action_d_Task_Object_p__Object_TaskScheduler
		{
			get
			{
				if(r_RContinueWith_Action_d_Task_Object_p__Object_TaskScheduler == null)
				{
					r_RContinueWith_Action_d_Task_Object_p__Object_TaskScheduler = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object)), typeof(System.Object), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWith_Action_d_Task_Object_p__Object_TaskScheduler.SetBelong(this.instance);
				}
				return r_RContinueWith_Action_d_Task_Object_p__Object_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task,System.Object], System.Object, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_RContinueWith_Action_d_Task_Object_p__Object_TaskContinuationOptions;
		public virtual RMethod RContinueWith_Action_d_Task_Object_p__Object_TaskContinuationOptions
		{
			get
			{
				if(r_RContinueWith_Action_d_Task_Object_p__Object_TaskContinuationOptions == null)
				{
					r_RContinueWith_Action_d_Task_Object_p__Object_TaskContinuationOptions = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object)), typeof(System.Object), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_RContinueWith_Action_d_Task_Object_p__Object_TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_RContinueWith_Action_d_Task_Object_p__Object_TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task,System.Object], System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RContinueWith_Action_d_Task_Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RContinueWith_Action_d_Task_Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_RContinueWith_Action_d_Task_Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_RContinueWith_Action_d_Task_Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object)), typeof(System.Object), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWith_Action_d_Task_Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_RContinueWith_Action_d_Task_Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task,System.Object], System.Object, System.Threading.Tasks.TaskScheduler, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_RContinueWith_Action_d_Task_Object_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions;
		public virtual RMethod RContinueWith_Action_d_Task_Object_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions
		{
			get
			{
				if(r_RContinueWith_Action_d_Task_Object_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions == null)
				{
					r_RContinueWith_Action_d_Task_Object_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object)), typeof(System.Object), typeof(System.Threading.Tasks.TaskScheduler), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_RContinueWith_Action_d_Task_Object_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_RContinueWith_Action_d_Task_Object_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`2[System.Threading.Tasks.Task,TResult])
		/// </summary>
		protected RMethod r_RContinueWith_GTResult_Func_d_Task_TResult_p_;
		public virtual RMethod RContinueWith_GTResult_Func_d_Task_TResult_p_
		{
			get
			{
				if(r_RContinueWith_GTResult_Func_d_Task_TResult_p_ == null)
				{
					r_RContinueWith_GTResult_Func_d_Task_TResult_p_ = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)));
					r_RContinueWith_GTResult_Func_d_Task_TResult_p_.SetBelong(this.instance);
				}
				return r_RContinueWith_GTResult_Func_d_Task_TResult_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`2[System.Threading.Tasks.Task,TResult], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken;
		public virtual RMethod RContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken
		{
			get
			{
				if(r_RContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken == null)
				{
					r_RContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken));
					r_RContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken.SetBelong(this.instance);
				}
				return r_RContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`2[System.Threading.Tasks.Task,TResult], System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RContinueWith_GTResult_Func_d_Task_TResult_p__TaskScheduler;
		public virtual RMethod RContinueWith_GTResult_Func_d_Task_TResult_p__TaskScheduler
		{
			get
			{
				if(r_RContinueWith_GTResult_Func_d_Task_TResult_p__TaskScheduler == null)
				{
					r_RContinueWith_GTResult_Func_d_Task_TResult_p__TaskScheduler = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWith_GTResult_Func_d_Task_TResult_p__TaskScheduler.SetBelong(this.instance);
				}
				return r_RContinueWith_GTResult_Func_d_Task_TResult_p__TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`2[System.Threading.Tasks.Task,TResult], System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_RContinueWith_GTResult_Func_d_Task_TResult_p__TaskContinuationOptions;
		public virtual RMethod RContinueWith_GTResult_Func_d_Task_TResult_p__TaskContinuationOptions
		{
			get
			{
				if(r_RContinueWith_GTResult_Func_d_Task_TResult_p__TaskContinuationOptions == null)
				{
					r_RContinueWith_GTResult_Func_d_Task_TResult_p__TaskContinuationOptions = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_RContinueWith_GTResult_Func_d_Task_TResult_p__TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_RContinueWith_GTResult_Func_d_Task_TResult_p__TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`2[System.Threading.Tasks.Task,TResult], System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_RContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_RContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_RContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`2[System.Threading.Tasks.Task,TResult], System.Threading.Tasks.TaskScheduler, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_RContinueWith_GTResult_Func_d_Task_TResult_p__TaskScheduler_CancellationToken_TaskContinuationOptions;
		public virtual RMethod RContinueWith_GTResult_Func_d_Task_TResult_p__TaskScheduler_CancellationToken_TaskContinuationOptions
		{
			get
			{
				if(r_RContinueWith_GTResult_Func_d_Task_TResult_p__TaskScheduler_CancellationToken_TaskContinuationOptions == null)
				{
					r_RContinueWith_GTResult_Func_d_Task_TResult_p__TaskScheduler_CancellationToken_TaskContinuationOptions = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskScheduler), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_RContinueWith_GTResult_Func_d_Task_TResult_p__TaskScheduler_CancellationToken_TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_RContinueWith_GTResult_Func_d_Task_TResult_p__TaskScheduler_CancellationToken_TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`3[System.Threading.Tasks.Task,System.Object,TResult], System.Object)
		/// </summary>
		protected RMethod r_RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object;
		public virtual RMethod RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object
		{
			get
			{
				if(r_RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object == null)
				{
					r_RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object));
					r_RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object.SetBelong(this.instance);
				}
				return r_RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`3[System.Threading.Tasks.Task,System.Object,TResult], System.Object, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken;
		public virtual RMethod RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken
		{
			get
			{
				if(r_RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken == null)
				{
					r_RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.CancellationToken));
					r_RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken.SetBelong(this.instance);
				}
				return r_RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`3[System.Threading.Tasks.Task,System.Object,TResult], System.Object, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskScheduler;
		public virtual RMethod RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskScheduler
		{
			get
			{
				if(r_RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskScheduler == null)
				{
					r_RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskScheduler = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskScheduler.SetBelong(this.instance);
				}
				return r_RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`3[System.Threading.Tasks.Task,System.Object,TResult], System.Object, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskContinuationOptions;
		public virtual RMethod RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskContinuationOptions
		{
			get
			{
				if(r_RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskContinuationOptions == null)
				{
					r_RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskContinuationOptions = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`3[System.Threading.Tasks.Task,System.Object,TResult], System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`3[System.Threading.Tasks.Task,System.Object,TResult], System.Object, System.Threading.Tasks.TaskScheduler, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions;
		public virtual RMethod RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions
		{
			get
			{
				if(r_RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions == null)
				{
					r_RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.Tasks.TaskScheduler), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions;
			}
		}

		/// <summary>
		/// Void CreationOptionsFromContinuationOptions(System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskCreationOptions ByRef, System.Threading.Tasks.InternalTaskOptions ByRef)
		/// </summary>
		protected static RMethod r_RCreationOptionsFromContinuationOptions_TaskContinuationOptions_Out_TaskCreationOptions_Out_InternalTaskOptions;
		public static RMethod RCreationOptionsFromContinuationOptions_TaskContinuationOptions_Out_TaskCreationOptions_Out_InternalTaskOptions
		{
			get
			{
				if(r_RCreationOptionsFromContinuationOptions_TaskContinuationOptions_Out_TaskCreationOptions_Out_InternalTaskOptions == null)
				{
					r_RCreationOptionsFromContinuationOptions_TaskContinuationOptions_Out_TaskCreationOptions_Out_InternalTaskOptions = new(typeof(System.Threading.Tasks.Task), "CreationOptionsFromContinuationOptions", 0, typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskCreationOptions).MakeByRefType(),  ReleactionUtils.GetType("System.Threading.Tasks.InternalTaskOptions").MakeByRefType());
					r_RCreationOptionsFromContinuationOptions_TaskContinuationOptions_Out_TaskCreationOptions_Out_InternalTaskOptions.SetBelong(null);
				}
				return r_RCreationOptionsFromContinuationOptions_TaskContinuationOptions_Out_TaskCreationOptions_Out_InternalTaskOptions;
			}
		}

		/// <summary>
		/// Void ContinueWithCore(System.Threading.Tasks.Task, System.Threading.Tasks.TaskScheduler, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_RContinueWithCore_Task_TaskScheduler_CancellationToken_TaskContinuationOptions;
		public virtual RMethod RContinueWithCore_Task_TaskScheduler_CancellationToken_TaskContinuationOptions
		{
			get
			{
				if(r_RContinueWithCore_Task_TaskScheduler_CancellationToken_TaskContinuationOptions == null)
				{
					r_RContinueWithCore_Task_TaskScheduler_CancellationToken_TaskContinuationOptions = new(this, "ContinueWithCore", 0, typeof(System.Threading.Tasks.Task), typeof(System.Threading.Tasks.TaskScheduler), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_RContinueWithCore_Task_TaskScheduler_CancellationToken_TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_RContinueWithCore_Task_TaskScheduler_CancellationToken_TaskContinuationOptions;
			}
		}

		/// <summary>
		/// Void AddCompletionAction(System.Threading.Tasks.ITaskCompletionAction)
		/// </summary>
		protected RMethod r_RAddCompletionAction_ITaskCompletionAction;
		public virtual RMethod RAddCompletionAction_ITaskCompletionAction
		{
			get
			{
				if(r_RAddCompletionAction_ITaskCompletionAction == null)
				{
					r_RAddCompletionAction_ITaskCompletionAction = new(this, "AddCompletionAction", 0,  ReleactionUtils.GetType("System.Threading.Tasks.ITaskCompletionAction"));
					r_RAddCompletionAction_ITaskCompletionAction.SetBelong(this.instance);
				}
				return r_RAddCompletionAction_ITaskCompletionAction;
			}
		}

		/// <summary>
		/// Void AddCompletionAction(System.Threading.Tasks.ITaskCompletionAction, Boolean)
		/// </summary>
		protected RMethod r_RAddCompletionAction_ITaskCompletionAction_Boolean;
		public virtual RMethod RAddCompletionAction_ITaskCompletionAction_Boolean
		{
			get
			{
				if(r_RAddCompletionAction_ITaskCompletionAction_Boolean == null)
				{
					r_RAddCompletionAction_ITaskCompletionAction_Boolean = new(this, "AddCompletionAction", 0,  ReleactionUtils.GetType("System.Threading.Tasks.ITaskCompletionAction"), typeof(System.Boolean));
					r_RAddCompletionAction_ITaskCompletionAction_Boolean.SetBelong(this.instance);
				}
				return r_RAddCompletionAction_ITaskCompletionAction_Boolean;
			}
		}

		/// <summary>
		/// Boolean AddTaskContinuationComplex(System.Object, Boolean)
		/// </summary>
		protected RMethod r_RAddTaskContinuationComplex_Object_Boolean;
		public virtual RMethod RAddTaskContinuationComplex_Object_Boolean
		{
			get
			{
				if(r_RAddTaskContinuationComplex_Object_Boolean == null)
				{
					r_RAddTaskContinuationComplex_Object_Boolean = new(this, "AddTaskContinuationComplex", 0, typeof(System.Object), typeof(System.Boolean));
					r_RAddTaskContinuationComplex_Object_Boolean.SetBelong(this.instance);
				}
				return r_RAddTaskContinuationComplex_Object_Boolean;
			}
		}

		/// <summary>
		/// Boolean AddTaskContinuation(System.Object, Boolean)
		/// </summary>
		protected RMethod r_RAddTaskContinuation_Object_Boolean;
		public virtual RMethod RAddTaskContinuation_Object_Boolean
		{
			get
			{
				if(r_RAddTaskContinuation_Object_Boolean == null)
				{
					r_RAddTaskContinuation_Object_Boolean = new(this, "AddTaskContinuation", 0, typeof(System.Object), typeof(System.Boolean));
					r_RAddTaskContinuation_Object_Boolean.SetBelong(this.instance);
				}
				return r_RAddTaskContinuation_Object_Boolean;
			}
		}

		/// <summary>
		/// Void RemoveContinuation(System.Object)
		/// </summary>
		protected RMethod r_RRemoveContinuation_Object;
		public virtual RMethod RRemoveContinuation_Object
		{
			get
			{
				if(r_RRemoveContinuation_Object == null)
				{
					r_RRemoveContinuation_Object = new(this, "RemoveContinuation", 0, typeof(System.Object));
					r_RRemoveContinuation_Object.SetBelong(this.instance);
				}
				return r_RRemoveContinuation_Object;
			}
		}

		/// <summary>
		/// Void WaitAll(System.Threading.Tasks.Task[])
		/// </summary>
		protected static RMethod r_RWaitAll_TaskArray;
		public static RMethod RWaitAll_TaskArray
		{
			get
			{
				if(r_RWaitAll_TaskArray == null)
				{
					r_RWaitAll_TaskArray = new(typeof(System.Threading.Tasks.Task), "WaitAll", 0, typeof(System.Threading.Tasks.Task).MakeArrayType());
					r_RWaitAll_TaskArray.SetBelong(null);
				}
				return r_RWaitAll_TaskArray;
			}
		}

		/// <summary>
		/// Boolean WaitAll(System.Threading.Tasks.Task[], System.TimeSpan)
		/// </summary>
		protected static RMethod r_RWaitAll_TaskArray_TimeSpan;
		public static RMethod RWaitAll_TaskArray_TimeSpan
		{
			get
			{
				if(r_RWaitAll_TaskArray_TimeSpan == null)
				{
					r_RWaitAll_TaskArray_TimeSpan = new(typeof(System.Threading.Tasks.Task), "WaitAll", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.TimeSpan));
					r_RWaitAll_TaskArray_TimeSpan.SetBelong(null);
				}
				return r_RWaitAll_TaskArray_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean WaitAll(System.Threading.Tasks.Task[], Int32)
		/// </summary>
		protected static RMethod r_RWaitAll_TaskArray_Int32;
		public static RMethod RWaitAll_TaskArray_Int32
		{
			get
			{
				if(r_RWaitAll_TaskArray_Int32 == null)
				{
					r_RWaitAll_TaskArray_Int32 = new(typeof(System.Threading.Tasks.Task), "WaitAll", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Int32));
					r_RWaitAll_TaskArray_Int32.SetBelong(null);
				}
				return r_RWaitAll_TaskArray_Int32;
			}
		}

		/// <summary>
		/// Void WaitAll(System.Threading.Tasks.Task[], System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_RWaitAll_TaskArray_CancellationToken;
		public static RMethod RWaitAll_TaskArray_CancellationToken
		{
			get
			{
				if(r_RWaitAll_TaskArray_CancellationToken == null)
				{
					r_RWaitAll_TaskArray_CancellationToken = new(typeof(System.Threading.Tasks.Task), "WaitAll", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Threading.CancellationToken));
					r_RWaitAll_TaskArray_CancellationToken.SetBelong(null);
				}
				return r_RWaitAll_TaskArray_CancellationToken;
			}
		}

		/// <summary>
		/// Boolean WaitAll(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_RWaitAll_TaskArray_Int32_CancellationToken;
		public static RMethod RWaitAll_TaskArray_Int32_CancellationToken
		{
			get
			{
				if(r_RWaitAll_TaskArray_Int32_CancellationToken == null)
				{
					r_RWaitAll_TaskArray_Int32_CancellationToken = new(typeof(System.Threading.Tasks.Task), "WaitAll", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Int32), typeof(System.Threading.CancellationToken));
					r_RWaitAll_TaskArray_Int32_CancellationToken.SetBelong(null);
				}
				return r_RWaitAll_TaskArray_Int32_CancellationToken;
			}
		}

		/// <summary>
		/// Void AddToList[T](T, System.Collections.Generic.LowLevelListWithIList`1[T] ByRef, Int32)
		/// </summary>
		protected static RMethod r_RAddToList_GT_T_Ref_LowLevelListWithIList_d_T_p__Int32;
		public static RMethod RAddToList_GT_T_Ref_LowLevelListWithIList_d_T_p__Int32
		{
			get
			{
				if(r_RAddToList_GT_T_Ref_LowLevelListWithIList_d_T_p__Int32 == null)
				{
					r_RAddToList_GT_T_Ref_LowLevelListWithIList_d_T_p__Int32 = new(typeof(System.Threading.Tasks.Task), "AddToList", 1, Type.MakeGenericMethodParameter(0),  ReleactionUtils.GetType("System.Collections.Generic.LowLevelListWithIList`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(System.Int32));
					r_RAddToList_GT_T_Ref_LowLevelListWithIList_d_T_p__Int32.SetBelong(null);
				}
				return r_RAddToList_GT_T_Ref_LowLevelListWithIList_d_T_p__Int32;
			}
		}

		/// <summary>
		/// Boolean WaitAllBlockingCore(System.Collections.Generic.LowLevelListWithIList`1[System.Threading.Tasks.Task], Int32, System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_RWaitAllBlockingCore_LowLevelListWithIList_d_Task_p__Int32_CancellationToken;
		public static RMethod RWaitAllBlockingCore_LowLevelListWithIList_d_Task_p__Int32_CancellationToken
		{
			get
			{
				if(r_RWaitAllBlockingCore_LowLevelListWithIList_d_Task_p__Int32_CancellationToken == null)
				{
					r_RWaitAllBlockingCore_LowLevelListWithIList_d_Task_p__Int32_CancellationToken = new(typeof(System.Threading.Tasks.Task), "WaitAllBlockingCore", 0,  ReleactionUtils.GetType("System.Collections.Generic.LowLevelListWithIList`1").MakeGenericType(typeof(System.Threading.Tasks.Task)), typeof(System.Int32), typeof(System.Threading.CancellationToken));
					r_RWaitAllBlockingCore_LowLevelListWithIList_d_Task_p__Int32_CancellationToken.SetBelong(null);
				}
				return r_RWaitAllBlockingCore_LowLevelListWithIList_d_Task_p__Int32_CancellationToken;
			}
		}

		/// <summary>
		/// Void AddExceptionsForCompletedTask(System.Collections.Generic.LowLevelListWithIList`1[System.Exception] ByRef, System.Threading.Tasks.Task)
		/// </summary>
		protected static RMethod r_RAddExceptionsForCompletedTask_Ref_LowLevelListWithIList_d_Exception_p__Task;
		public static RMethod RAddExceptionsForCompletedTask_Ref_LowLevelListWithIList_d_Exception_p__Task
		{
			get
			{
				if(r_RAddExceptionsForCompletedTask_Ref_LowLevelListWithIList_d_Exception_p__Task == null)
				{
					r_RAddExceptionsForCompletedTask_Ref_LowLevelListWithIList_d_Exception_p__Task = new(typeof(System.Threading.Tasks.Task), "AddExceptionsForCompletedTask", 0,  ReleactionUtils.GetType("System.Collections.Generic.LowLevelListWithIList`1").MakeGenericType(typeof(System.Exception)).MakeByRefType(), typeof(System.Threading.Tasks.Task));
					r_RAddExceptionsForCompletedTask_Ref_LowLevelListWithIList_d_Exception_p__Task.SetBelong(null);
				}
				return r_RAddExceptionsForCompletedTask_Ref_LowLevelListWithIList_d_Exception_p__Task;
			}
		}

		/// <summary>
		/// Int32 WaitAny(System.Threading.Tasks.Task[])
		/// </summary>
		protected static RMethod r_RWaitAny_TaskArray;
		public static RMethod RWaitAny_TaskArray
		{
			get
			{
				if(r_RWaitAny_TaskArray == null)
				{
					r_RWaitAny_TaskArray = new(typeof(System.Threading.Tasks.Task), "WaitAny", 0, typeof(System.Threading.Tasks.Task).MakeArrayType());
					r_RWaitAny_TaskArray.SetBelong(null);
				}
				return r_RWaitAny_TaskArray;
			}
		}

		/// <summary>
		/// Int32 WaitAny(System.Threading.Tasks.Task[], System.TimeSpan)
		/// </summary>
		protected static RMethod r_RWaitAny_TaskArray_TimeSpan;
		public static RMethod RWaitAny_TaskArray_TimeSpan
		{
			get
			{
				if(r_RWaitAny_TaskArray_TimeSpan == null)
				{
					r_RWaitAny_TaskArray_TimeSpan = new(typeof(System.Threading.Tasks.Task), "WaitAny", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.TimeSpan));
					r_RWaitAny_TaskArray_TimeSpan.SetBelong(null);
				}
				return r_RWaitAny_TaskArray_TimeSpan;
			}
		}

		/// <summary>
		/// Int32 WaitAny(System.Threading.Tasks.Task[], System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_RWaitAny_TaskArray_CancellationToken;
		public static RMethod RWaitAny_TaskArray_CancellationToken
		{
			get
			{
				if(r_RWaitAny_TaskArray_CancellationToken == null)
				{
					r_RWaitAny_TaskArray_CancellationToken = new(typeof(System.Threading.Tasks.Task), "WaitAny", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Threading.CancellationToken));
					r_RWaitAny_TaskArray_CancellationToken.SetBelong(null);
				}
				return r_RWaitAny_TaskArray_CancellationToken;
			}
		}

		/// <summary>
		/// Int32 WaitAny(System.Threading.Tasks.Task[], Int32)
		/// </summary>
		protected static RMethod r_RWaitAny_TaskArray_Int32;
		public static RMethod RWaitAny_TaskArray_Int32
		{
			get
			{
				if(r_RWaitAny_TaskArray_Int32 == null)
				{
					r_RWaitAny_TaskArray_Int32 = new(typeof(System.Threading.Tasks.Task), "WaitAny", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Int32));
					r_RWaitAny_TaskArray_Int32.SetBelong(null);
				}
				return r_RWaitAny_TaskArray_Int32;
			}
		}

		/// <summary>
		/// Int32 WaitAny(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_RWaitAny_TaskArray_Int32_CancellationToken;
		public static RMethod RWaitAny_TaskArray_Int32_CancellationToken
		{
			get
			{
				if(r_RWaitAny_TaskArray_Int32_CancellationToken == null)
				{
					r_RWaitAny_TaskArray_Int32_CancellationToken = new(typeof(System.Threading.Tasks.Task), "WaitAny", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Int32), typeof(System.Threading.CancellationToken));
					r_RWaitAny_TaskArray_Int32_CancellationToken.SetBelong(null);
				}
				return r_RWaitAny_TaskArray_Int32_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromResult[TResult](TResult)
		/// </summary>
		protected static RMethod r_RFromResult_GTResult_TResult;
		public static RMethod RFromResult_GTResult_TResult
		{
			get
			{
				if(r_RFromResult_GTResult_TResult == null)
				{
					r_RFromResult_GTResult_TResult = new(typeof(System.Threading.Tasks.Task), "FromResult", 1, Type.MakeGenericMethodParameter(0));
					r_RFromResult_GTResult_TResult.SetBelong(null);
				}
				return r_RFromResult_GTResult_TResult;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FromException(System.Exception)
		/// </summary>
		protected static RMethod r_RFromException_Exception;
		public static RMethod RFromException_Exception
		{
			get
			{
				if(r_RFromException_Exception == null)
				{
					r_RFromException_Exception = new(typeof(System.Threading.Tasks.Task), "FromException", 0, typeof(System.Exception));
					r_RFromException_Exception.SetBelong(null);
				}
				return r_RFromException_Exception;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromException[TResult](System.Exception)
		/// </summary>
		protected static RMethod r_RFromException_GTResult_Exception;
		public static RMethod RFromException_GTResult_Exception
		{
			get
			{
				if(r_RFromException_GTResult_Exception == null)
				{
					r_RFromException_GTResult_Exception = new(typeof(System.Threading.Tasks.Task), "FromException", 1, typeof(System.Exception));
					r_RFromException_GTResult_Exception.SetBelong(null);
				}
				return r_RFromException_GTResult_Exception;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FromCancellation(System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_RFromCancellation_CancellationToken;
		public static RMethod RFromCancellation_CancellationToken
		{
			get
			{
				if(r_RFromCancellation_CancellationToken == null)
				{
					r_RFromCancellation_CancellationToken = new(typeof(System.Threading.Tasks.Task), "FromCancellation", 0, typeof(System.Threading.CancellationToken));
					r_RFromCancellation_CancellationToken.SetBelong(null);
				}
				return r_RFromCancellation_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FromCanceled(System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_RFromCanceled_CancellationToken;
		public static RMethod RFromCanceled_CancellationToken
		{
			get
			{
				if(r_RFromCanceled_CancellationToken == null)
				{
					r_RFromCanceled_CancellationToken = new(typeof(System.Threading.Tasks.Task), "FromCanceled", 0, typeof(System.Threading.CancellationToken));
					r_RFromCanceled_CancellationToken.SetBelong(null);
				}
				return r_RFromCanceled_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromCancellation[TResult](System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_RFromCancellation_GTResult_CancellationToken;
		public static RMethod RFromCancellation_GTResult_CancellationToken
		{
			get
			{
				if(r_RFromCancellation_GTResult_CancellationToken == null)
				{
					r_RFromCancellation_GTResult_CancellationToken = new(typeof(System.Threading.Tasks.Task), "FromCancellation", 1, typeof(System.Threading.CancellationToken));
					r_RFromCancellation_GTResult_CancellationToken.SetBelong(null);
				}
				return r_RFromCancellation_GTResult_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromCanceled[TResult](System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_RFromCanceled_GTResult_CancellationToken;
		public static RMethod RFromCanceled_GTResult_CancellationToken
		{
			get
			{
				if(r_RFromCanceled_GTResult_CancellationToken == null)
				{
					r_RFromCanceled_GTResult_CancellationToken = new(typeof(System.Threading.Tasks.Task), "FromCanceled", 1, typeof(System.Threading.CancellationToken));
					r_RFromCanceled_GTResult_CancellationToken.SetBelong(null);
				}
				return r_RFromCanceled_GTResult_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromCancellation[TResult](System.OperationCanceledException)
		/// </summary>
		protected static RMethod r_RFromCancellation_GTResult_OperationCanceledException;
		public static RMethod RFromCancellation_GTResult_OperationCanceledException
		{
			get
			{
				if(r_RFromCancellation_GTResult_OperationCanceledException == null)
				{
					r_RFromCancellation_GTResult_OperationCanceledException = new(typeof(System.Threading.Tasks.Task), "FromCancellation", 1, typeof(System.OperationCanceledException));
					r_RFromCancellation_GTResult_OperationCanceledException.SetBelong(null);
				}
				return r_RFromCancellation_GTResult_OperationCanceledException;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task Run(System.Action)
		/// </summary>
		protected static RMethod r_RRun_Action;
		public static RMethod RRun_Action
		{
			get
			{
				if(r_RRun_Action == null)
				{
					r_RRun_Action = new(typeof(System.Threading.Tasks.Task), "Run", 0, typeof(System.Action));
					r_RRun_Action.SetBelong(null);
				}
				return r_RRun_Action;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task Run(System.Action, System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_RRun_Action_CancellationToken;
		public static RMethod RRun_Action_CancellationToken
		{
			get
			{
				if(r_RRun_Action_CancellationToken == null)
				{
					r_RRun_Action_CancellationToken = new(typeof(System.Threading.Tasks.Task), "Run", 0, typeof(System.Action), typeof(System.Threading.CancellationToken));
					r_RRun_Action_CancellationToken.SetBelong(null);
				}
				return r_RRun_Action_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] Run[TResult](System.Func`1[TResult])
		/// </summary>
		protected static RMethod r_RRun_GTResult_Func_d_TResult_p_;
		public static RMethod RRun_GTResult_Func_d_TResult_p_
		{
			get
			{
				if(r_RRun_GTResult_Func_d_TResult_p_ == null)
				{
					r_RRun_GTResult_Func_d_TResult_p_ = new(typeof(System.Threading.Tasks.Task), "Run", 1, typeof(System.Func<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RRun_GTResult_Func_d_TResult_p_.SetBelong(null);
				}
				return r_RRun_GTResult_Func_d_TResult_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] Run[TResult](System.Func`1[TResult], System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_RRun_GTResult_Func_d_TResult_p__CancellationToken;
		public static RMethod RRun_GTResult_Func_d_TResult_p__CancellationToken
		{
			get
			{
				if(r_RRun_GTResult_Func_d_TResult_p__CancellationToken == null)
				{
					r_RRun_GTResult_Func_d_TResult_p__CancellationToken = new(typeof(System.Threading.Tasks.Task), "Run", 1, typeof(System.Func<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken));
					r_RRun_GTResult_Func_d_TResult_p__CancellationToken.SetBelong(null);
				}
				return r_RRun_GTResult_Func_d_TResult_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task Run(System.Func`1[System.Threading.Tasks.Task])
		/// </summary>
		protected static RMethod r_RRun_Func_d_Task_p_;
		public static RMethod RRun_Func_d_Task_p_
		{
			get
			{
				if(r_RRun_Func_d_Task_p_ == null)
				{
					r_RRun_Func_d_Task_p_ = new(typeof(System.Threading.Tasks.Task), "Run", 0, typeof(System.Func<>).MakeGenericType(typeof(System.Threading.Tasks.Task)));
					r_RRun_Func_d_Task_p_.SetBelong(null);
				}
				return r_RRun_Func_d_Task_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task Run(System.Func`1[System.Threading.Tasks.Task], System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_RRun_Func_d_Task_p__CancellationToken;
		public static RMethod RRun_Func_d_Task_p__CancellationToken
		{
			get
			{
				if(r_RRun_Func_d_Task_p__CancellationToken == null)
				{
					r_RRun_Func_d_Task_p__CancellationToken = new(typeof(System.Threading.Tasks.Task), "Run", 0, typeof(System.Func<>).MakeGenericType(typeof(System.Threading.Tasks.Task)), typeof(System.Threading.CancellationToken));
					r_RRun_Func_d_Task_p__CancellationToken.SetBelong(null);
				}
				return r_RRun_Func_d_Task_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] Run[TResult](System.Func`1[System.Threading.Tasks.Task`1[TResult]])
		/// </summary>
		protected static RMethod r_RRun_GTResult_Func_d_Task_d_TResult_p__p_;
		public static RMethod RRun_GTResult_Func_d_Task_d_TResult_p__p_
		{
			get
			{
				if(r_RRun_GTResult_Func_d_Task_d_TResult_p__p_ == null)
				{
					r_RRun_GTResult_Func_d_Task_d_TResult_p__p_ = new(typeof(System.Threading.Tasks.Task), "Run", 1, typeof(System.Func<>).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0))));
					r_RRun_GTResult_Func_d_Task_d_TResult_p__p_.SetBelong(null);
				}
				return r_RRun_GTResult_Func_d_Task_d_TResult_p__p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] Run[TResult](System.Func`1[System.Threading.Tasks.Task`1[TResult]], System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_RRun_GTResult_Func_d_Task_d_TResult_p__p__CancellationToken;
		public static RMethod RRun_GTResult_Func_d_Task_d_TResult_p__p__CancellationToken
		{
			get
			{
				if(r_RRun_GTResult_Func_d_Task_d_TResult_p__p__CancellationToken == null)
				{
					r_RRun_GTResult_Func_d_Task_d_TResult_p__p__CancellationToken = new(typeof(System.Threading.Tasks.Task), "Run", 1, typeof(System.Func<>).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0))), typeof(System.Threading.CancellationToken));
					r_RRun_GTResult_Func_d_Task_d_TResult_p__p__CancellationToken.SetBelong(null);
				}
				return r_RRun_GTResult_Func_d_Task_d_TResult_p__p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task Delay(System.TimeSpan)
		/// </summary>
		protected static RMethod r_RDelay_TimeSpan;
		public static RMethod RDelay_TimeSpan
		{
			get
			{
				if(r_RDelay_TimeSpan == null)
				{
					r_RDelay_TimeSpan = new(typeof(System.Threading.Tasks.Task), "Delay", 0, typeof(System.TimeSpan));
					r_RDelay_TimeSpan.SetBelong(null);
				}
				return r_RDelay_TimeSpan;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task Delay(System.TimeSpan, System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_RDelay_TimeSpan_CancellationToken;
		public static RMethod RDelay_TimeSpan_CancellationToken
		{
			get
			{
				if(r_RDelay_TimeSpan_CancellationToken == null)
				{
					r_RDelay_TimeSpan_CancellationToken = new(typeof(System.Threading.Tasks.Task), "Delay", 0, typeof(System.TimeSpan), typeof(System.Threading.CancellationToken));
					r_RDelay_TimeSpan_CancellationToken.SetBelong(null);
				}
				return r_RDelay_TimeSpan_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task Delay(Int32)
		/// </summary>
		protected static RMethod r_RDelay_Int32;
		public static RMethod RDelay_Int32
		{
			get
			{
				if(r_RDelay_Int32 == null)
				{
					r_RDelay_Int32 = new(typeof(System.Threading.Tasks.Task), "Delay", 0, typeof(System.Int32));
					r_RDelay_Int32.SetBelong(null);
				}
				return r_RDelay_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task Delay(Int32, System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_RDelay_Int32_CancellationToken;
		public static RMethod RDelay_Int32_CancellationToken
		{
			get
			{
				if(r_RDelay_Int32_CancellationToken == null)
				{
					r_RDelay_Int32_CancellationToken = new(typeof(System.Threading.Tasks.Task), "Delay", 0, typeof(System.Int32), typeof(System.Threading.CancellationToken));
					r_RDelay_Int32_CancellationToken.SetBelong(null);
				}
				return r_RDelay_Int32_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WhenAll(System.Collections.Generic.IEnumerable`1[System.Threading.Tasks.Task])
		/// </summary>
		protected static RMethod r_RWhenAll_IEnumerable_d_Task_p_;
		public static RMethod RWhenAll_IEnumerable_d_Task_p_
		{
			get
			{
				if(r_RWhenAll_IEnumerable_d_Task_p_ == null)
				{
					r_RWhenAll_IEnumerable_d_Task_p_ = new(typeof(System.Threading.Tasks.Task), "WhenAll", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.Threading.Tasks.Task)));
					r_RWhenAll_IEnumerable_d_Task_p_.SetBelong(null);
				}
				return r_RWhenAll_IEnumerable_d_Task_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WhenAll(System.Threading.Tasks.Task[])
		/// </summary>
		protected static RMethod r_RWhenAll_TaskArray;
		public static RMethod RWhenAll_TaskArray
		{
			get
			{
				if(r_RWhenAll_TaskArray == null)
				{
					r_RWhenAll_TaskArray = new(typeof(System.Threading.Tasks.Task), "WhenAll", 0, typeof(System.Threading.Tasks.Task).MakeArrayType());
					r_RWhenAll_TaskArray.SetBelong(null);
				}
				return r_RWhenAll_TaskArray;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task InternalWhenAll(System.Threading.Tasks.Task[])
		/// </summary>
		protected static RMethod r_RInternalWhenAll_TaskArray;
		public static RMethod RInternalWhenAll_TaskArray
		{
			get
			{
				if(r_RInternalWhenAll_TaskArray == null)
				{
					r_RInternalWhenAll_TaskArray = new(typeof(System.Threading.Tasks.Task), "InternalWhenAll", 0, typeof(System.Threading.Tasks.Task).MakeArrayType());
					r_RInternalWhenAll_TaskArray.SetBelong(null);
				}
				return r_RInternalWhenAll_TaskArray;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult[]] WhenAll[TResult](System.Collections.Generic.IEnumerable`1[System.Threading.Tasks.Task`1[TResult]])
		/// </summary>
		protected static RMethod r_RWhenAll_GTResult_IEnumerable_d_Task_d_TResult_p__p_;
		public static RMethod RWhenAll_GTResult_IEnumerable_d_Task_d_TResult_p__p_
		{
			get
			{
				if(r_RWhenAll_GTResult_IEnumerable_d_Task_d_TResult_p__p_ == null)
				{
					r_RWhenAll_GTResult_IEnumerable_d_Task_d_TResult_p__p_ = new(typeof(System.Threading.Tasks.Task), "WhenAll", 1, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0))));
					r_RWhenAll_GTResult_IEnumerable_d_Task_d_TResult_p__p_.SetBelong(null);
				}
				return r_RWhenAll_GTResult_IEnumerable_d_Task_d_TResult_p__p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult[]] WhenAll[TResult](System.Threading.Tasks.Task`1[TResult][])
		/// </summary>
		protected static RMethod r_RWhenAll_GTResult_Task_d_TResult_p_Array;
		public static RMethod RWhenAll_GTResult_Task_d_TResult_p_Array
		{
			get
			{
				if(r_RWhenAll_GTResult_Task_d_TResult_p_Array == null)
				{
					r_RWhenAll_GTResult_Task_d_TResult_p_Array = new(typeof(System.Threading.Tasks.Task), "WhenAll", 1, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType());
					r_RWhenAll_GTResult_Task_d_TResult_p_Array.SetBelong(null);
				}
				return r_RWhenAll_GTResult_Task_d_TResult_p_Array;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult[]] InternalWhenAll[TResult](System.Threading.Tasks.Task`1[TResult][])
		/// </summary>
		protected static RMethod r_RInternalWhenAll_GTResult_Task_d_TResult_p_Array;
		public static RMethod RInternalWhenAll_GTResult_Task_d_TResult_p_Array
		{
			get
			{
				if(r_RInternalWhenAll_GTResult_Task_d_TResult_p_Array == null)
				{
					r_RInternalWhenAll_GTResult_Task_d_TResult_p_Array = new(typeof(System.Threading.Tasks.Task), "InternalWhenAll", 1, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType());
					r_RInternalWhenAll_GTResult_Task_d_TResult_p_Array.SetBelong(null);
				}
				return r_RInternalWhenAll_GTResult_Task_d_TResult_p_Array;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Threading.Tasks.Task] WhenAny(System.Threading.Tasks.Task[])
		/// </summary>
		protected static RMethod r_RWhenAny_TaskArray;
		public static RMethod RWhenAny_TaskArray
		{
			get
			{
				if(r_RWhenAny_TaskArray == null)
				{
					r_RWhenAny_TaskArray = new(typeof(System.Threading.Tasks.Task), "WhenAny", 0, typeof(System.Threading.Tasks.Task).MakeArrayType());
					r_RWhenAny_TaskArray.SetBelong(null);
				}
				return r_RWhenAny_TaskArray;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Threading.Tasks.Task] WhenAny(System.Collections.Generic.IEnumerable`1[System.Threading.Tasks.Task])
		/// </summary>
		protected static RMethod r_RWhenAny_IEnumerable_d_Task_p_;
		public static RMethod RWhenAny_IEnumerable_d_Task_p_
		{
			get
			{
				if(r_RWhenAny_IEnumerable_d_Task_p_ == null)
				{
					r_RWhenAny_IEnumerable_d_Task_p_ = new(typeof(System.Threading.Tasks.Task), "WhenAny", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.Threading.Tasks.Task)));
					r_RWhenAny_IEnumerable_d_Task_p_.SetBelong(null);
				}
				return r_RWhenAny_IEnumerable_d_Task_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Threading.Tasks.Task`1[TResult]] WhenAny[TResult](System.Threading.Tasks.Task`1[TResult][])
		/// </summary>
		protected static RMethod r_RWhenAny_GTResult_Task_d_TResult_p_Array;
		public static RMethod RWhenAny_GTResult_Task_d_TResult_p_Array
		{
			get
			{
				if(r_RWhenAny_GTResult_Task_d_TResult_p_Array == null)
				{
					r_RWhenAny_GTResult_Task_d_TResult_p_Array = new(typeof(System.Threading.Tasks.Task), "WhenAny", 1, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType());
					r_RWhenAny_GTResult_Task_d_TResult_p_Array.SetBelong(null);
				}
				return r_RWhenAny_GTResult_Task_d_TResult_p_Array;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Threading.Tasks.Task`1[TResult]] WhenAny[TResult](System.Collections.Generic.IEnumerable`1[System.Threading.Tasks.Task`1[TResult]])
		/// </summary>
		protected static RMethod r_RWhenAny_GTResult_IEnumerable_d_Task_d_TResult_p__p_;
		public static RMethod RWhenAny_GTResult_IEnumerable_d_Task_d_TResult_p__p_
		{
			get
			{
				if(r_RWhenAny_GTResult_IEnumerable_d_Task_d_TResult_p__p_ == null)
				{
					r_RWhenAny_GTResult_IEnumerable_d_Task_d_TResult_p__p_ = new(typeof(System.Threading.Tasks.Task), "WhenAny", 1, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0))));
					r_RWhenAny_GTResult_IEnumerable_d_Task_d_TResult_p__p_.SetBelong(null);
				}
				return r_RWhenAny_GTResult_IEnumerable_d_Task_d_TResult_p__p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] CreateUnwrapPromise[TResult](System.Threading.Tasks.Task, Boolean)
		/// </summary>
		protected static RMethod r_RCreateUnwrapPromise_GTResult_Task_Boolean;
		public static RMethod RCreateUnwrapPromise_GTResult_Task_Boolean
		{
			get
			{
				if(r_RCreateUnwrapPromise_GTResult_Task_Boolean == null)
				{
					r_RCreateUnwrapPromise_GTResult_Task_Boolean = new(typeof(System.Threading.Tasks.Task), "CreateUnwrapPromise", 1, typeof(System.Threading.Tasks.Task), typeof(System.Boolean));
					r_RCreateUnwrapPromise_GTResult_Task_Boolean.SetBelong(null);
				}
				return r_RCreateUnwrapPromise_GTResult_Task_Boolean;
			}
		}

		/// <summary>
		/// System.Delegate[] GetDelegateContinuationsForDebugger()
		/// </summary>
		protected RMethod r_RGetDelegateContinuationsForDebugger;
		public virtual RMethod RGetDelegateContinuationsForDebugger
		{
			get
			{
				if(r_RGetDelegateContinuationsForDebugger == null)
				{
					r_RGetDelegateContinuationsForDebugger = new(this, "GetDelegateContinuationsForDebugger", 0);
					r_RGetDelegateContinuationsForDebugger.SetBelong(this.instance);
				}
				return r_RGetDelegateContinuationsForDebugger;
			}
		}

		/// <summary>
		/// System.Delegate[] GetDelegatesFromContinuationObject(System.Object)
		/// </summary>
		protected static RMethod r_RGetDelegatesFromContinuationObject_Object;
		public static RMethod RGetDelegatesFromContinuationObject_Object
		{
			get
			{
				if(r_RGetDelegatesFromContinuationObject_Object == null)
				{
					r_RGetDelegatesFromContinuationObject_Object = new(typeof(System.Threading.Tasks.Task), "GetDelegatesFromContinuationObject", 0, typeof(System.Object));
					r_RGetDelegatesFromContinuationObject_Object.SetBelong(null);
				}
				return r_RGetDelegatesFromContinuationObject_Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task GetActiveTaskFromId(Int32)
		/// </summary>
		protected static RMethod r_RGetActiveTaskFromId_Int32;
		public static RMethod RGetActiveTaskFromId_Int32
		{
			get
			{
				if(r_RGetActiveTaskFromId_Int32 == null)
				{
					r_RGetActiveTaskFromId_Int32 = new(typeof(System.Threading.Tasks.Task), "GetActiveTaskFromId", 0, typeof(System.Int32));
					r_RGetActiveTaskFromId_Int32.SetBelong(null);
				}
				return r_RGetActiveTaskFromId_Int32;
			}
		}

		/// <summary>
		/// Boolean AddToActiveTasks(System.Threading.Tasks.Task)
		/// </summary>
		protected static RMethod r_RAddToActiveTasks_Task;
		public static RMethod RAddToActiveTasks_Task
		{
			get
			{
				if(r_RAddToActiveTasks_Task == null)
				{
					r_RAddToActiveTasks_Task = new(typeof(System.Threading.Tasks.Task), "AddToActiveTasks", 0, typeof(System.Threading.Tasks.Task));
					r_RAddToActiveTasks_Task.SetBelong(null);
				}
				return r_RAddToActiveTasks_Task;
			}
		}

		/// <summary>
		/// Void RemoveFromActiveTasks(Int32)
		/// </summary>
		protected static RMethod r_RRemoveFromActiveTasks_Int32;
		public static RMethod RRemoveFromActiveTasks_Int32
		{
			get
			{
				if(r_RRemoveFromActiveTasks_Int32 == null)
				{
					r_RRemoveFromActiveTasks_Int32 = new(typeof(System.Threading.Tasks.Task), "RemoveFromActiveTasks", 0, typeof(System.Int32));
					r_RRemoveFromActiveTasks_Int32.SetBelong(null);
				}
				return r_RRemoveFromActiveTasks_Int32;
			}
		}

		/// <summary>
		/// Void MarkAborted(System.Threading.ThreadAbortException)
		/// </summary>
		protected RMethod r_RMarkAborted_ThreadAbortException;
		public virtual RMethod RMarkAborted_ThreadAbortException
		{
			get
			{
				if(r_RMarkAborted_ThreadAbortException == null)
				{
					r_RMarkAborted_ThreadAbortException = new(this, "MarkAborted", 0, typeof(System.Threading.ThreadAbortException));
					r_RMarkAborted_ThreadAbortException.SetBelong(this.instance);
				}
				return r_RMarkAborted_ThreadAbortException;
			}
		}

		/// <summary>
		/// Void ExecuteWithThreadLocal(System.Threading.Tasks.Task ByRef)
		/// </summary>
		protected RMethod r_RExecuteWithThreadLocal_Ref_Task;
		public virtual RMethod RExecuteWithThreadLocal_Ref_Task
		{
			get
			{
				if(r_RExecuteWithThreadLocal_Ref_Task == null)
				{
					r_RExecuteWithThreadLocal_Ref_Task = new(this, "ExecuteWithThreadLocal", 0, typeof(System.Threading.Tasks.Task).MakeByRefType());
					r_RExecuteWithThreadLocal_Ref_Task.SetBelong(this.instance);
				}
				return r_RExecuteWithThreadLocal_Ref_Task;
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



        public static void TaskCancelCallback(System.Object  @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RTaskCancelCallback_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TrySetCanceled(System.Threading.CancellationToken  @tokenToRecord)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tokenToRecord};
            var ___result = RTrySetCanceled_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TrySetCanceled(System.Threading.CancellationToken  @tokenToRecord, System.Object  @cancellationException)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tokenToRecord, @cancellationException};
            var ___result = RTrySetCanceled_CancellationToken_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TrySetException(System.Object  @exceptionObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exceptionObject};
            var ___result = RTrySetException_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Threading.Tasks.TaskCreationOptions OptionsMethod(System.Int32  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flags};
            var ___result = ROptionsMethod_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.TaskCreationOptions)___result;
        }


        public virtual System.Boolean AtomicStateUpdate(System.Int32  @newBits, System.Int32  @illegalBits)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newBits, @illegalBits};
            var ___result = RAtomicStateUpdate_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean AtomicStateUpdate(System.Int32  @newBits, System.Int32  @illegalBits, ref System.Int32  @oldFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newBits, @illegalBits, @oldFlags};
            var ___result = RAtomicStateUpdate_Int32_Int32_Ref_Int32.Invoke(___genericsType, ___parameters);
			oldFlags = (System.Int32)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual void SetNotificationForWaitCompletion(System.Boolean  @enabled)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enabled};
            var ___result = RSetNotificationForWaitCompletion_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean NotifyDebuggerOfWaitCompletionIfNecessary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RNotifyDebuggerOfWaitCompletionIfNecessary.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean AnyTaskRequiresNotifyDebuggerOfWaitCompletion(System.Threading.Tasks.Task[]  @tasks)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks};
            var ___result = RAnyTaskRequiresNotifyDebuggerOfWaitCompletion_TaskArray.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void NotifyDebuggerOfWaitCompletion()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RNotifyDebuggerOfWaitCompletion.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean MarkStarted()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMarkStarted.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void AddNewChild()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAddNewChild.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DisregardChild()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDisregardChild.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Start()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStart.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Start(System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scheduler};
            var ___result = RStart_TaskScheduler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RunSynchronously()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRunSynchronously.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RunSynchronously(System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scheduler};
            var ___result = RRunSynchronously_TaskScheduler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalRunSynchronously(System.Threading.Tasks.TaskScheduler  @scheduler, System.Boolean  @waitForCompletion)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scheduler, @waitForCompletion};
            var ___result = RInternalRunSynchronously_TaskScheduler_Boolean.Invoke(___genericsType, ___parameters);

            
        }



        public static System.Threading.Tasks.Task InternalCurrentIfAttached(System.Threading.Tasks.TaskCreationOptions  @creationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@creationOptions};
            var ___result = RInternalCurrentIfAttached_TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Object EnsureContingentPropertiesInitialized(System.Boolean  @needsProtection)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@needsProtection};
            var ___result = REnsureContingentPropertiesInitialized_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object EnsureContingentPropertiesInitializedCore(System.Boolean  @needsProtection)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@needsProtection};
            var ___result = REnsureContingentPropertiesInitializedCore_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Boolean IsCompletedMethod(System.Int32  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flags};
            var ___result = RIsCompletedMethod_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean  @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ScheduleAndStart(System.Boolean  @needsProtection)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@needsProtection};
            var ___result = RScheduleAndStart_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddException(System.Object  @exceptionObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exceptionObject};
            var ___result = RAddException_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddException(System.Object  @exceptionObject, System.Boolean  @representsCancellation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exceptionObject, @representsCancellation};
            var ___result = RAddException_Object_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.AggregateException GetExceptions(System.Boolean  @includeTaskCanceledExceptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@includeTaskCanceledExceptions};
            var ___result = RGetExceptions_Boolean.Invoke(___genericsType, ___parameters);

            return (System.AggregateException)___result;
        }


        public virtual System.Collections.ObjectModel.ReadOnlyCollection<System.Runtime.ExceptionServices.ExceptionDispatchInfo> GetExceptionDispatchInfos()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetExceptionDispatchInfos.Invoke(___genericsType, ___parameters);

            return (System.Collections.ObjectModel.ReadOnlyCollection<System.Runtime.ExceptionServices.ExceptionDispatchInfo>)___result;
        }


        public virtual System.Runtime.ExceptionServices.ExceptionDispatchInfo GetCancellationExceptionDispatchInfo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCancellationExceptionDispatchInfo.Invoke(___genericsType, ___parameters);

            return (System.Runtime.ExceptionServices.ExceptionDispatchInfo)___result;
        }


        public virtual void ThrowIfExceptional(System.Boolean  @includeTaskCanceledExceptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@includeTaskCanceledExceptions};
            var ___result = RThrowIfExceptional_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateExceptionObservedStatus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateExceptionObservedStatus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Finish(System.Boolean  @bUserDelegateExecuted)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bUserDelegateExecuted};
            var ___result = RFinish_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FinishStageTwo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinishStageTwo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FinishStageThree()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinishStageThree.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessChildCompletion(System.Threading.Tasks.Task  @childTask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@childTask};
            var ___result = RProcessChildCompletion_Task.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddExceptionsFromChildren()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAddExceptionsFromChildren.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Execute()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RExecute.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Threading__0__IThreadPoolWorkItem__0__ExecuteWorkItem()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__0__Threading__0__IThreadPoolWorkItem__0__ExecuteWorkItem.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ExecuteEntry(System.Boolean  @bPreventDoubleExecution)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bPreventDoubleExecution};
            var ___result = RExecuteEntry_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void ExecutionContextCallback(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RExecutionContextCallback_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InnerInvoke()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInnerInvoke.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleException(System.Exception  @unhandledException)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unhandledException};
            var ___result = RHandleException_Exception.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Runtime.CompilerServices.TaskAwaiter GetAwaiter()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAwaiter.Invoke(___genericsType, ___parameters);

            return (System.Runtime.CompilerServices.TaskAwaiter)___result;
        }


        public virtual System.Runtime.CompilerServices.ConfiguredTaskAwaitable ConfigureAwait(System.Boolean  @continueOnCapturedContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continueOnCapturedContext};
            var ___result = RConfigureAwait_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Runtime.CompilerServices.ConfiguredTaskAwaitable)___result;
        }


        public virtual void SetContinuationForAwait(System.Action  @continuationAction, System.Boolean  @continueOnCapturedContext, System.Boolean  @flowExecutionContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @continueOnCapturedContext, @flowExecutionContext};
            var ___result = RSetContinuationForAwait_Action_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Runtime.CompilerServices.YieldAwaitable Yield()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RYield.Invoke(___genericsType, ___parameters);

            return (System.Runtime.CompilerServices.YieldAwaitable)___result;
        }


        public virtual void Wait()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWait.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Wait(System.TimeSpan  @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout};
            var ___result = RWait_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Wait(System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cancellationToken};
            var ___result = RWait_CancellationToken.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Wait(System.Int32  @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout};
            var ___result = RWait_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Wait(System.Int32  @millisecondsTimeout, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout, @cancellationToken};
            var ___result = RWait_Int32_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean WrappedTryRunInline()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWrappedTryRunInline.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean InternalWait(System.Int32  @millisecondsTimeout, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout, @cancellationToken};
            var ___result = RInternalWait_Int32_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean SpinThenBlockingWait(System.Int32  @millisecondsTimeout, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout, @cancellationToken};
            var ___result = RSpinThenBlockingWait_Int32_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean SpinWait(System.Int32  @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout};
            var ___result = RSpinWait_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean InternalCancel(System.Boolean  @bCancelNonExecutingOnly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bCancelNonExecutingOnly};
            var ___result = RInternalCancel_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void RecordInternalCancellationRequest()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRecordInternalCancellationRequest.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecordInternalCancellationRequest(System.Threading.CancellationToken  @tokenToRecord)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tokenToRecord};
            var ___result = RRecordInternalCancellationRequest_CancellationToken.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecordInternalCancellationRequest(System.Threading.CancellationToken  @tokenToRecord, System.Object  @cancellationException)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tokenToRecord, @cancellationException};
            var ___result = RRecordInternalCancellationRequest_CancellationToken_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CancellationCleanupLogic()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCancellationCleanupLogic.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCancellationAcknowledged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetCancellationAcknowledged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FinishContinuations()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinishContinuations.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LogFinishCompletionNotification()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RLogFinishCompletionNotification.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task>  @continuationAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction};
            var ___result = RContinueWith_Action_d_Task_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task>  @continuationAction, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @cancellationToken};
            var ___result = RContinueWith_Action_d_Task_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task>  @continuationAction, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @scheduler};
            var ___result = RContinueWith_Action_d_Task_p__TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task>  @continuationAction, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @continuationOptions};
            var ___result = RContinueWith_Action_d_Task_p__TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task>  @continuationAction, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RContinueWith_Action_d_Task_p__CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task>  @continuationAction, System.Threading.Tasks.TaskScheduler  @scheduler, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @scheduler, @cancellationToken, @continuationOptions};
            var ___result = RContinueWith_Action_d_Task_p__TaskScheduler_CancellationToken_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task, System.Object>  @continuationAction, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @state};
            var ___result = RContinueWith_Action_d_Task_Object_p__Object.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task, System.Object>  @continuationAction, System.Object  @state, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @state, @cancellationToken};
            var ___result = RContinueWith_Action_d_Task_Object_p__Object_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task, System.Object>  @continuationAction, System.Object  @state, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @state, @scheduler};
            var ___result = RContinueWith_Action_d_Task_Object_p__Object_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task, System.Object>  @continuationAction, System.Object  @state, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @state, @continuationOptions};
            var ___result = RContinueWith_Action_d_Task_Object_p__Object_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task, System.Object>  @continuationAction, System.Object  @state, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @state, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RContinueWith_Action_d_Task_Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task, System.Object>  @continuationAction, System.Object  @state, System.Threading.Tasks.TaskScheduler  @scheduler, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @state, @scheduler, @cancellationToken, @continuationOptions};
            var ___result = RContinueWith_Action_d_Task_Object_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, TResult>  @continuationFunction)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@continuationFunction};
            var ___result = RContinueWith_GTResult_Func_d_Task_TResult_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, TResult>  @continuationFunction, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@continuationFunction, @cancellationToken};
            var ___result = RContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, TResult>  @continuationFunction, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@continuationFunction, @scheduler};
            var ___result = RContinueWith_GTResult_Func_d_Task_TResult_p__TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, TResult>  @continuationFunction, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@continuationFunction, @continuationOptions};
            var ___result = RContinueWith_GTResult_Func_d_Task_TResult_p__TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, TResult>  @continuationFunction, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@continuationFunction, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, TResult>  @continuationFunction, System.Threading.Tasks.TaskScheduler  @scheduler, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@continuationFunction, @scheduler, @cancellationToken, @continuationOptions};
            var ___result = RContinueWith_GTResult_Func_d_Task_TResult_p__TaskScheduler_CancellationToken_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, System.Object, TResult>  @continuationFunction, System.Object  @state)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@continuationFunction, @state};
            var ___result = RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, System.Object, TResult>  @continuationFunction, System.Object  @state, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@continuationFunction, @state, @cancellationToken};
            var ___result = RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, System.Object, TResult>  @continuationFunction, System.Object  @state, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@continuationFunction, @state, @scheduler};
            var ___result = RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, System.Object, TResult>  @continuationFunction, System.Object  @state, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@continuationFunction, @state, @continuationOptions};
            var ___result = RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, System.Object, TResult>  @continuationFunction, System.Object  @state, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@continuationFunction, @state, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, System.Object, TResult>  @continuationFunction, System.Object  @state, System.Threading.Tasks.TaskScheduler  @scheduler, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@continuationFunction, @state, @scheduler, @cancellationToken, @continuationOptions};
            var ___result = RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }



        public virtual void ContinueWithCore(System.Threading.Tasks.Task  @continuationTask, System.Threading.Tasks.TaskScheduler  @scheduler, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationTask, @scheduler, @cancellationToken, @options};
            var ___result = RContinueWithCore_Task_TaskScheduler_CancellationToken_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            
        }




        public virtual System.Boolean AddTaskContinuationComplex(System.Object  @tc, System.Boolean  @addBeforeOthers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tc, @addBeforeOthers};
            var ___result = RAddTaskContinuationComplex_Object_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean AddTaskContinuation(System.Object  @tc, System.Boolean  @addBeforeOthers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tc, @addBeforeOthers};
            var ___result = RAddTaskContinuation_Object_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void RemoveContinuation(System.Object  @continuationObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationObject};
            var ___result = RRemoveContinuation_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static void WaitAll(System.Threading.Tasks.Task[]  @tasks)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks};
            var ___result = RWaitAll_TaskArray.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean WaitAll(System.Threading.Tasks.Task[]  @tasks, System.TimeSpan  @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @timeout};
            var ___result = RWaitAll_TaskArray_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean WaitAll(System.Threading.Tasks.Task[]  @tasks, System.Int32  @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @millisecondsTimeout};
            var ___result = RWaitAll_TaskArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void WaitAll(System.Threading.Tasks.Task[]  @tasks, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @cancellationToken};
            var ___result = RWaitAll_TaskArray_CancellationToken.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean WaitAll(System.Threading.Tasks.Task[]  @tasks, System.Int32  @millisecondsTimeout, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @millisecondsTimeout, @cancellationToken};
            var ___result = RWaitAll_TaskArray_Int32_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }





        public static System.Int32 WaitAny(System.Threading.Tasks.Task[]  @tasks)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks};
            var ___result = RWaitAny_TaskArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 WaitAny(System.Threading.Tasks.Task[]  @tasks, System.TimeSpan  @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @timeout};
            var ___result = RWaitAny_TaskArray_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 WaitAny(System.Threading.Tasks.Task[]  @tasks, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @cancellationToken};
            var ___result = RWaitAny_TaskArray_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 WaitAny(System.Threading.Tasks.Task[]  @tasks, System.Int32  @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @millisecondsTimeout};
            var ___result = RWaitAny_TaskArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 WaitAny(System.Threading.Tasks.Task[]  @tasks, System.Int32  @millisecondsTimeout, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @millisecondsTimeout, @cancellationToken};
            var ___result = RWaitAny_TaskArray_Int32_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Threading.Tasks.Task<TResult> FromResult<TResult>(TResult  @result)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@result};
            var ___result = RFromResult_GTResult_TResult.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task FromException(System.Exception  @exception)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exception};
            var ___result = RFromException_Exception.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public static System.Threading.Tasks.Task<TResult> FromException<TResult>(System.Exception  @exception)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@exception};
            var ___result = RFromException_GTResult_Exception.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task FromCancellation(System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cancellationToken};
            var ___result = RFromCancellation_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public static System.Threading.Tasks.Task FromCanceled(System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cancellationToken};
            var ___result = RFromCanceled_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public static System.Threading.Tasks.Task<TResult> FromCancellation<TResult>(System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@cancellationToken};
            var ___result = RFromCancellation_GTResult_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task<TResult> FromCanceled<TResult>(System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@cancellationToken};
            var ___result = RFromCanceled_GTResult_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task<TResult> FromCancellation<TResult>(System.OperationCanceledException  @exception)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@exception};
            var ___result = RFromCancellation_GTResult_OperationCanceledException.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task Run(System.Action  @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action};
            var ___result = RRun_Action.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public static System.Threading.Tasks.Task Run(System.Action  @action, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action, @cancellationToken};
            var ___result = RRun_Action_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public static System.Threading.Tasks.Task<TResult> Run<TResult>(System.Func<TResult>  @function)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@function};
            var ___result = RRun_GTResult_Func_d_TResult_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task<TResult> Run<TResult>(System.Func<TResult>  @function, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@function, @cancellationToken};
            var ___result = RRun_GTResult_Func_d_TResult_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task Run(System.Func<System.Threading.Tasks.Task>  @function)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@function};
            var ___result = RRun_Func_d_Task_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public static System.Threading.Tasks.Task Run(System.Func<System.Threading.Tasks.Task>  @function, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@function, @cancellationToken};
            var ___result = RRun_Func_d_Task_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public static System.Threading.Tasks.Task<TResult> Run<TResult>(System.Func<System.Threading.Tasks.Task<TResult>>  @function)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@function};
            var ___result = RRun_GTResult_Func_d_Task_d_TResult_p__p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task<TResult> Run<TResult>(System.Func<System.Threading.Tasks.Task<TResult>>  @function, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@function, @cancellationToken};
            var ___result = RRun_GTResult_Func_d_Task_d_TResult_p__p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task Delay(System.TimeSpan  @delay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delay};
            var ___result = RDelay_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public static System.Threading.Tasks.Task Delay(System.TimeSpan  @delay, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delay, @cancellationToken};
            var ___result = RDelay_TimeSpan_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public static System.Threading.Tasks.Task Delay(System.Int32  @millisecondsDelay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsDelay};
            var ___result = RDelay_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public static System.Threading.Tasks.Task Delay(System.Int32  @millisecondsDelay, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsDelay, @cancellationToken};
            var ___result = RDelay_Int32_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public static System.Threading.Tasks.Task WhenAll(System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task>  @tasks)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks};
            var ___result = RWhenAll_IEnumerable_d_Task_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public static System.Threading.Tasks.Task WhenAll(System.Threading.Tasks.Task[]  @tasks)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks};
            var ___result = RWhenAll_TaskArray.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public static System.Threading.Tasks.Task InternalWhenAll(System.Threading.Tasks.Task[]  @tasks)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks};
            var ___result = RInternalWhenAll_TaskArray.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public static System.Threading.Tasks.Task<TResult[]> WhenAll<TResult>(System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task<TResult>>  @tasks)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@tasks};
            var ___result = RWhenAll_GTResult_IEnumerable_d_Task_d_TResult_p__p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult[]>)___result;
        }


        public static System.Threading.Tasks.Task<TResult[]> WhenAll<TResult>(System.Threading.Tasks.Task<TResult>[]  @tasks)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@tasks};
            var ___result = RWhenAll_GTResult_Task_d_TResult_p_Array.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult[]>)___result;
        }


        public static System.Threading.Tasks.Task<TResult[]> InternalWhenAll<TResult>(System.Threading.Tasks.Task<TResult>[]  @tasks)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@tasks};
            var ___result = RInternalWhenAll_GTResult_Task_d_TResult_p_Array.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult[]>)___result;
        }


        public static System.Threading.Tasks.Task<System.Threading.Tasks.Task> WhenAny(System.Threading.Tasks.Task[]  @tasks)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks};
            var ___result = RWhenAny_TaskArray.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Threading.Tasks.Task>)___result;
        }


        public static System.Threading.Tasks.Task<System.Threading.Tasks.Task> WhenAny(System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task>  @tasks)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks};
            var ___result = RWhenAny_IEnumerable_d_Task_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Threading.Tasks.Task>)___result;
        }


        public static System.Threading.Tasks.Task<System.Threading.Tasks.Task<TResult>> WhenAny<TResult>(System.Threading.Tasks.Task<TResult>[]  @tasks)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@tasks};
            var ___result = RWhenAny_GTResult_Task_d_TResult_p_Array.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Threading.Tasks.Task<TResult>>)___result;
        }


        public static System.Threading.Tasks.Task<System.Threading.Tasks.Task<TResult>> WhenAny<TResult>(System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task<TResult>>  @tasks)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@tasks};
            var ___result = RWhenAny_GTResult_IEnumerable_d_Task_d_TResult_p__p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Threading.Tasks.Task<TResult>>)___result;
        }


        public static System.Threading.Tasks.Task<TResult> CreateUnwrapPromise<TResult>(System.Threading.Tasks.Task  @outerTask, System.Boolean  @lookForOce)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@outerTask, @lookForOce};
            var ___result = RCreateUnwrapPromise_GTResult_Task_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Delegate[] GetDelegateContinuationsForDebugger()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDelegateContinuationsForDebugger.Invoke(___genericsType, ___parameters);

            return (System.Delegate[])___result;
        }


        public static System.Delegate[] GetDelegatesFromContinuationObject(System.Object  @continuationObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationObject};
            var ___result = RGetDelegatesFromContinuationObject_Object.Invoke(___genericsType, ___parameters);

            return (System.Delegate[])___result;
        }


        public static System.Threading.Tasks.Task GetActiveTaskFromId(System.Int32  @taskId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@taskId};
            var ___result = RGetActiveTaskFromId_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public static System.Boolean AddToActiveTasks(System.Threading.Tasks.Task  @task)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task};
            var ___result = RAddToActiveTasks_Task.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void RemoveFromActiveTasks(System.Int32  @taskId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@taskId};
            var ___result = RRemoveFromActiveTasks_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkAborted(System.Threading.ThreadAbortException  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMarkAborted_ThreadAbortException.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExecuteWithThreadLocal(ref System.Threading.Tasks.Task  @currentTaskSlot)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@currentTaskSlot};
            var ___result = RExecuteWithThreadLocal_Ref_Task.Invoke(___genericsType, ___parameters);
			currentTaskSlot = (System.Threading.Tasks.Task)___parameters[0];

            
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
