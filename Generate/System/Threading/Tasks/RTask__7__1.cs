using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks
{
	/// <summary>
	/// System.Threading.Tasks.Task`1
	/// </summary>
    public partial class RTask<TResult> : RMember //
    {

		/// <summary>
		/// TResult m_result
		/// </summary>
		protected RField r_m_result;
		public virtual RField Rm_result
		{
			get
			{
				if(r_m_result == null)
				{
					r_m_result = new(this, "m_result");
					r_m_result.SetBelong(this.instance);
				}
				return r_m_result;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskFactory`1[TResult] s_defaultFactory
		/// </summary>
		protected static RSystem.RThreading.RTasks.RTaskFactory<RField> r_s_defaultFactory;
		public static RSystem.RThreading.RTasks.RTaskFactory<RField> Rs_defaultFactory
		{
			get
			{
				if(r_s_defaultFactory == null)
				{
					r_s_defaultFactory = new(typeof(System.Threading.Tasks.Task<>), "s_defaultFactory");
					r_s_defaultFactory.SetBelong(null);
				}
				return r_s_defaultFactory;
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
		/// System.String DebuggerDisplayResultDescription
		/// </summary>
		protected RProperty r_DebuggerDisplayResultDescription;
		public virtual RProperty RDebuggerDisplayResultDescription
		{
			get
			{
				if(r_DebuggerDisplayResultDescription == null)
				{
					r_DebuggerDisplayResultDescription = new(this, "DebuggerDisplayResultDescription", -1);
					r_DebuggerDisplayResultDescription.SetBelong(this.instance);
				}
				return r_DebuggerDisplayResultDescription;
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
		/// TResult Result
		/// </summary>
		protected RProperty r_Result;
		public virtual RProperty Result
		{
			get
			{
				if(r_Result == null)
				{
					r_Result = new(this, "Result", -1);
					r_Result.SetBelong(this.instance);
				}
				return r_Result;
			}
		}

		/// <summary>
		/// TResult ResultOnSuccess
		/// </summary>
		protected RProperty r_ResultOnSuccess;
		public virtual RProperty ResultOnSuccess
		{
			get
			{
				if(r_ResultOnSuccess == null)
				{
					r_ResultOnSuccess = new(this, "ResultOnSuccess", -1);
					r_ResultOnSuccess.SetBelong(this.instance);
				}
				return r_ResultOnSuccess;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskFactory`1[TResult] Factory
		/// </summary>
		protected static RSystem.RThreading.RTasks.RTaskFactory<RProperty> r_Factory;
		public static RSystem.RThreading.RTasks.RTaskFactory<RProperty> RFactory
		{
			get
			{
				if(r_Factory == null)
				{
					r_Factory = new(typeof(System.Threading.Tasks.Task<>), "Factory", -1);
					r_Factory.SetBelong(null);
				}
				return r_Factory;
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
		/// System.Threading.Tasks.Task`1[TResult] StartNew(System.Threading.Tasks.Task, System.Func`1[TResult], System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.InternalTaskOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected static RMethod r_RStartNew_Task_Func_d_TResult_p__CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler;
		public static RMethod RStartNew_Task_Func_d_TResult_p__CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler
		{
			get
			{
				if(r_RStartNew_Task_Func_d_TResult_p__CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler == null)
				{
					r_RStartNew_Task_Func_d_TResult_p__CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler = new(typeof(System.Threading.Tasks.Task<>), "StartNew", 0, typeof(System.Threading.Tasks.Task), typeof(System.Func<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskCreationOptions),  ReleactionUtils.GetType("System.Threading.Tasks.InternalTaskOptions"), typeof(System.Threading.Tasks.TaskScheduler));
					r_RStartNew_Task_Func_d_TResult_p__CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler.SetBelong(null);
				}
				return r_RStartNew_Task_Func_d_TResult_p__CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] StartNew(System.Threading.Tasks.Task, System.Func`2[System.Object,TResult], System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.InternalTaskOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected static RMethod r_RStartNew_Task_Func_d_Object_TResult_p__Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler;
		public static RMethod RStartNew_Task_Func_d_Object_TResult_p__Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler
		{
			get
			{
				if(r_RStartNew_Task_Func_d_Object_TResult_p__Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler == null)
				{
					r_RStartNew_Task_Func_d_Object_TResult_p__Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler = new(typeof(System.Threading.Tasks.Task<>), "StartNew", 0, typeof(System.Threading.Tasks.Task), typeof(System.Func<, >).MakeGenericType(typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskCreationOptions),  ReleactionUtils.GetType("System.Threading.Tasks.InternalTaskOptions"), typeof(System.Threading.Tasks.TaskScheduler));
					r_RStartNew_Task_Func_d_Object_TResult_p__Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler.SetBelong(null);
				}
				return r_RStartNew_Task_Func_d_Object_TResult_p__Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// Boolean TrySetResult(TResult)
		/// </summary>
		protected RMethod r_RTrySetResult_TResult;
		public virtual RMethod RTrySetResult_TResult
		{
			get
			{
				if(r_RTrySetResult_TResult == null)
				{
					r_RTrySetResult_TResult = new(this, "TrySetResult", 0, Type.MakeGenericMethodParameter(0));
					r_RTrySetResult_TResult.SetBelong(this.instance);
				}
				return r_RTrySetResult_TResult;
			}
		}

		/// <summary>
		/// Void DangerousSetResult(TResult)
		/// </summary>
		protected RMethod r_RDangerousSetResult_TResult;
		public virtual RMethod RDangerousSetResult_TResult
		{
			get
			{
				if(r_RDangerousSetResult_TResult == null)
				{
					r_RDangerousSetResult_TResult = new(this, "DangerousSetResult", 0, Type.MakeGenericMethodParameter(0));
					r_RDangerousSetResult_TResult.SetBelong(this.instance);
				}
				return r_RDangerousSetResult_TResult;
			}
		}

		/// <summary>
		/// TResult GetResultCore(Boolean)
		/// </summary>
		protected RMethod r_RGetResultCore_Boolean;
		public virtual RMethod RGetResultCore_Boolean
		{
			get
			{
				if(r_RGetResultCore_Boolean == null)
				{
					r_RGetResultCore_Boolean = new(this, "GetResultCore", 0, typeof(System.Boolean));
					r_RGetResultCore_Boolean.SetBelong(this.instance);
				}
				return r_RGetResultCore_Boolean;
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
		/// System.Runtime.CompilerServices.TaskAwaiter`1[TResult] GetAwaiter()
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
		/// System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1[TResult] ConfigureAwait(Boolean)
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
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task`1[TResult]])
		/// </summary>
		protected RMethod r_RContinueWith_Action_d_Task_d_TResult_p__p_;
		public virtual RMethod RContinueWith_Action_d_Task_d_TResult_p__p_
		{
			get
			{
				if(r_RContinueWith_Action_d_Task_d_TResult_p__p_ == null)
				{
					r_RContinueWith_Action_d_Task_d_TResult_p__p_ = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task<>)));
					r_RContinueWith_Action_d_Task_d_TResult_p__p_.SetBelong(this.instance);
				}
				return r_RContinueWith_Action_d_Task_d_TResult_p__p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task`1[TResult]], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RContinueWith_Action_d_Task_d_TResult_p__p__CancellationToken;
		public virtual RMethod RContinueWith_Action_d_Task_d_TResult_p__p__CancellationToken
		{
			get
			{
				if(r_RContinueWith_Action_d_Task_d_TResult_p__p__CancellationToken == null)
				{
					r_RContinueWith_Action_d_Task_d_TResult_p__p__CancellationToken = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task<>)), typeof(System.Threading.CancellationToken));
					r_RContinueWith_Action_d_Task_d_TResult_p__p__CancellationToken.SetBelong(this.instance);
				}
				return r_RContinueWith_Action_d_Task_d_TResult_p__p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task`1[TResult]], System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RContinueWith_Action_d_Task_d_TResult_p__p__TaskScheduler;
		public virtual RMethod RContinueWith_Action_d_Task_d_TResult_p__p__TaskScheduler
		{
			get
			{
				if(r_RContinueWith_Action_d_Task_d_TResult_p__p__TaskScheduler == null)
				{
					r_RContinueWith_Action_d_Task_d_TResult_p__p__TaskScheduler = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task<>)), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWith_Action_d_Task_d_TResult_p__p__TaskScheduler.SetBelong(this.instance);
				}
				return r_RContinueWith_Action_d_Task_d_TResult_p__p__TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task`1[TResult]], System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_RContinueWith_Action_d_Task_d_TResult_p__p__TaskContinuationOptions;
		public virtual RMethod RContinueWith_Action_d_Task_d_TResult_p__p__TaskContinuationOptions
		{
			get
			{
				if(r_RContinueWith_Action_d_Task_d_TResult_p__p__TaskContinuationOptions == null)
				{
					r_RContinueWith_Action_d_Task_d_TResult_p__p__TaskContinuationOptions = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task<>)), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_RContinueWith_Action_d_Task_d_TResult_p__p__TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_RContinueWith_Action_d_Task_d_TResult_p__p__TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task`1[TResult]], System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RContinueWith_Action_d_Task_d_TResult_p__p__CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RContinueWith_Action_d_Task_d_TResult_p__p__CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_RContinueWith_Action_d_Task_d_TResult_p__p__CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_RContinueWith_Action_d_Task_d_TResult_p__p__CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task<>)), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWith_Action_d_Task_d_TResult_p__p__CancellationToken_TaskContinuationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_RContinueWith_Action_d_Task_d_TResult_p__p__CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task`1[TResult]], System.Threading.Tasks.TaskScheduler, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_RContinueWith_Action_d_Task_d_TResult_p__p__TaskScheduler_CancellationToken_TaskContinuationOptions;
		public virtual RMethod RContinueWith_Action_d_Task_d_TResult_p__p__TaskScheduler_CancellationToken_TaskContinuationOptions
		{
			get
			{
				if(r_RContinueWith_Action_d_Task_d_TResult_p__p__TaskScheduler_CancellationToken_TaskContinuationOptions == null)
				{
					r_RContinueWith_Action_d_Task_d_TResult_p__p__TaskScheduler_CancellationToken_TaskContinuationOptions = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task<>)), typeof(System.Threading.Tasks.TaskScheduler), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_RContinueWith_Action_d_Task_d_TResult_p__p__TaskScheduler_CancellationToken_TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_RContinueWith_Action_d_Task_d_TResult_p__p__TaskScheduler_CancellationToken_TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task`1[TResult],System.Object], System.Object)
		/// </summary>
		protected RMethod r_RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object;
		public virtual RMethod RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object
		{
			get
			{
				if(r_RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object == null)
				{
					r_RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>), typeof(System.Object)), typeof(System.Object));
					r_RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object.SetBelong(this.instance);
				}
				return r_RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task`1[TResult],System.Object], System.Object, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_CancellationToken;
		public virtual RMethod RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_CancellationToken
		{
			get
			{
				if(r_RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_CancellationToken == null)
				{
					r_RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_CancellationToken = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>), typeof(System.Object)), typeof(System.Object), typeof(System.Threading.CancellationToken));
					r_RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_CancellationToken.SetBelong(this.instance);
				}
				return r_RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task`1[TResult],System.Object], System.Object, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_TaskScheduler;
		public virtual RMethod RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_TaskScheduler
		{
			get
			{
				if(r_RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_TaskScheduler == null)
				{
					r_RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_TaskScheduler = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>), typeof(System.Object)), typeof(System.Object), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_TaskScheduler.SetBelong(this.instance);
				}
				return r_RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task`1[TResult],System.Object], System.Object, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_TaskContinuationOptions;
		public virtual RMethod RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_TaskContinuationOptions
		{
			get
			{
				if(r_RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_TaskContinuationOptions == null)
				{
					r_RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_TaskContinuationOptions = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>), typeof(System.Object)), typeof(System.Object), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task`1[TResult],System.Object], System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>), typeof(System.Object)), typeof(System.Object), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task`1[TResult],System.Object], System.Object, System.Threading.Tasks.TaskScheduler, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions;
		public virtual RMethod RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions
		{
			get
			{
				if(r_RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions == null)
				{
					r_RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>), typeof(System.Object)), typeof(System.Object), typeof(System.Threading.Tasks.TaskScheduler), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`2[System.Threading.Tasks.Task`1[TResult],TNewResult])
		/// </summary>
		protected RMethod r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p_;
		public virtual RMethod RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p_
		{
			get
			{
				if(r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p_ == null)
				{
					r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p_ = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>), Type.MakeGenericMethodParameter(0)));
					r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p_.SetBelong(this.instance);
				}
				return r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`2[System.Threading.Tasks.Task`1[TResult],TNewResult], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__CancellationToken;
		public virtual RMethod RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__CancellationToken
		{
			get
			{
				if(r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__CancellationToken == null)
				{
					r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__CancellationToken = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken));
					r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__CancellationToken.SetBelong(this.instance);
				}
				return r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`2[System.Threading.Tasks.Task`1[TResult],TNewResult], System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__TaskScheduler;
		public virtual RMethod RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__TaskScheduler
		{
			get
			{
				if(r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__TaskScheduler == null)
				{
					r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__TaskScheduler = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__TaskScheduler.SetBelong(this.instance);
				}
				return r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`2[System.Threading.Tasks.Task`1[TResult],TNewResult], System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__TaskContinuationOptions;
		public virtual RMethod RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__TaskContinuationOptions
		{
			get
			{
				if(r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__TaskContinuationOptions == null)
				{
					r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__TaskContinuationOptions = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`2[System.Threading.Tasks.Task`1[TResult],TNewResult], System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`2[System.Threading.Tasks.Task`1[TResult],TNewResult], System.Threading.Tasks.TaskScheduler, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__TaskScheduler_CancellationToken_TaskContinuationOptions;
		public virtual RMethod RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__TaskScheduler_CancellationToken_TaskContinuationOptions
		{
			get
			{
				if(r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__TaskScheduler_CancellationToken_TaskContinuationOptions == null)
				{
					r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__TaskScheduler_CancellationToken_TaskContinuationOptions = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskScheduler), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__TaskScheduler_CancellationToken_TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__TaskScheduler_CancellationToken_TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`3[System.Threading.Tasks.Task`1[TResult],System.Object,TNewResult], System.Object)
		/// </summary>
		protected RMethod r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object;
		public virtual RMethod RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object
		{
			get
			{
				if(r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object == null)
				{
					r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task<>), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object));
					r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object.SetBelong(this.instance);
				}
				return r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`3[System.Threading.Tasks.Task`1[TResult],System.Object,TNewResult], System.Object, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_CancellationToken;
		public virtual RMethod RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_CancellationToken
		{
			get
			{
				if(r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_CancellationToken == null)
				{
					r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_CancellationToken = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task<>), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.CancellationToken));
					r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_CancellationToken.SetBelong(this.instance);
				}
				return r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`3[System.Threading.Tasks.Task`1[TResult],System.Object,TNewResult], System.Object, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_TaskScheduler;
		public virtual RMethod RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_TaskScheduler
		{
			get
			{
				if(r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_TaskScheduler == null)
				{
					r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_TaskScheduler = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task<>), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_TaskScheduler.SetBelong(this.instance);
				}
				return r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`3[System.Threading.Tasks.Task`1[TResult],System.Object,TNewResult], System.Object, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_TaskContinuationOptions;
		public virtual RMethod RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_TaskContinuationOptions
		{
			get
			{
				if(r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_TaskContinuationOptions == null)
				{
					r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_TaskContinuationOptions = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task<>), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`3[System.Threading.Tasks.Task`1[TResult],System.Object,TNewResult], System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task<>), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`3[System.Threading.Tasks.Task`1[TResult],System.Object,TNewResult], System.Object, System.Threading.Tasks.TaskScheduler, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions;
		public virtual RMethod RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions
		{
			get
			{
				if(r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions == null)
				{
					r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task<>), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.Tasks.TaskScheduler), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions;
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


        public RTask() : base("System.Threading.Tasks.Task`1")
        {
        }

        public RTask(System.Object instance) : base("System.Threading.Tasks.Task`1")
		{
            SetInstance(instance);
		}

        public RTask(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTask(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }



        public virtual System.Boolean TrySetResult(TResult  @result)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@result};
            var ___result = RTrySetResult_TResult.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void DangerousSetResult(TResult  @result)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@result};
            var ___result = RDangerousSetResult_TResult.Invoke(___genericsType, ___parameters);

            
        }


        public virtual TResult GetResultCore(System.Boolean  @waitCompletionNotification)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitCompletionNotification};
            var ___result = RGetResultCore_Boolean.Invoke(___genericsType, ___parameters);

            return (TResult)___result;
        }


        public virtual void InnerInvoke()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInnerInvoke.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Runtime.CompilerServices.TaskAwaiter<TResult> GetAwaiter()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAwaiter.Invoke(___genericsType, ___parameters);

            return (System.Runtime.CompilerServices.TaskAwaiter<TResult>)___result;
        }


        public virtual System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult> ConfigureAwait(System.Boolean  @continueOnCapturedContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continueOnCapturedContext};
            var ___result = RConfigureAwait_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>>  @continuationAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction};
            var ___result = RContinueWith_Action_d_Task_d_TResult_p__p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>>  @continuationAction, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @cancellationToken};
            var ___result = RContinueWith_Action_d_Task_d_TResult_p__p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>>  @continuationAction, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @scheduler};
            var ___result = RContinueWith_Action_d_Task_d_TResult_p__p__TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>>  @continuationAction, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @continuationOptions};
            var ___result = RContinueWith_Action_d_Task_d_TResult_p__p__TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>>  @continuationAction, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RContinueWith_Action_d_Task_d_TResult_p__p__CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>>  @continuationAction, System.Threading.Tasks.TaskScheduler  @scheduler, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @scheduler, @cancellationToken, @continuationOptions};
            var ___result = RContinueWith_Action_d_Task_d_TResult_p__p__TaskScheduler_CancellationToken_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>, System.Object>  @continuationAction, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @state};
            var ___result = RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>, System.Object>  @continuationAction, System.Object  @state, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @state, @cancellationToken};
            var ___result = RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>, System.Object>  @continuationAction, System.Object  @state, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @state, @scheduler};
            var ___result = RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>, System.Object>  @continuationAction, System.Object  @state, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @state, @continuationOptions};
            var ___result = RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>, System.Object>  @continuationAction, System.Object  @state, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @state, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>, System.Object>  @continuationAction, System.Object  @state, System.Threading.Tasks.TaskScheduler  @scheduler, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @state, @scheduler, @cancellationToken, @continuationOptions};
            var ___result = RContinueWith_Action_d_Task_d_TResult_p__Object_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<TResult>, TNewResult>  @continuationFunction)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction};
            var ___result = RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<TResult>, TNewResult>  @continuationFunction, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction, @cancellationToken};
            var ___result = RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<TResult>, TNewResult>  @continuationFunction, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction, @scheduler};
            var ___result = RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<TResult>, TNewResult>  @continuationFunction, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction, @continuationOptions};
            var ___result = RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<TResult>, TNewResult>  @continuationFunction, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<TResult>, TNewResult>  @continuationFunction, System.Threading.Tasks.TaskScheduler  @scheduler, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction, @scheduler, @cancellationToken, @continuationOptions};
            var ___result = RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__TNewResult_p__TaskScheduler_CancellationToken_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<TResult>, System.Object, TNewResult>  @continuationFunction, System.Object  @state)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction, @state};
            var ___result = RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<TResult>, System.Object, TNewResult>  @continuationFunction, System.Object  @state, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction, @state, @cancellationToken};
            var ___result = RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<TResult>, System.Object, TNewResult>  @continuationFunction, System.Object  @state, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction, @state, @scheduler};
            var ___result = RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<TResult>, System.Object, TNewResult>  @continuationFunction, System.Object  @state, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction, @state, @continuationOptions};
            var ___result = RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<TResult>, System.Object, TNewResult>  @continuationFunction, System.Object  @state, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction, @state, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<TResult>, System.Object, TNewResult>  @continuationFunction, System.Object  @state, System.Threading.Tasks.TaskScheduler  @scheduler, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction, @state, @scheduler, @cancellationToken, @continuationOptions};
            var ___result = RContinueWith_GTNewResult_Func_d_Task_d_TResult_p__Object_TNewResult_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
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


        public virtual System.Object EnsureContingentPropertiesInitialized(System.Boolean  @needsProtection)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@needsProtection};
            var ___result = REnsureContingentPropertiesInitialized_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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


        public virtual System.Boolean ExecuteEntry(System.Boolean  @bPreventDoubleExecution)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bPreventDoubleExecution};
            var ___result = RExecuteEntry_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetContinuationForAwait(System.Action  @continuationAction, System.Boolean  @continueOnCapturedContext, System.Boolean  @flowExecutionContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @continueOnCapturedContext, @flowExecutionContext};
            var ___result = RSetContinuationForAwait_Action_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Boolean InternalWait(System.Int32  @millisecondsTimeout, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout, @cancellationToken};
            var ___result = RInternalWait_Int32_CancellationToken.Invoke(___genericsType, ___parameters);

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


        public virtual void FinishContinuations()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinishContinuations.Invoke(___genericsType, ___parameters);

            
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


        public virtual void ContinueWithCore(System.Threading.Tasks.Task  @continuationTask, System.Threading.Tasks.TaskScheduler  @scheduler, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationTask, @scheduler, @cancellationToken, @options};
            var ___result = RContinueWithCore_Task_TaskScheduler_CancellationToken_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void RemoveContinuation(System.Object  @continuationObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationObject};
            var ___result = RRemoveContinuation_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Delegate[] GetDelegateContinuationsForDebugger()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDelegateContinuationsForDebugger.Invoke(___genericsType, ___parameters);

            return (System.Delegate[])___result;
        }


        public virtual void MarkAborted(System.Threading.ThreadAbortException  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMarkAborted_ThreadAbortException.Invoke(___genericsType, ___parameters);

            
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
