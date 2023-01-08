using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RIO
{public partial class RStream
{
	
	/// <summary>
	/// System.IO.Stream+ReadWriteTask
	/// </summary>
    public partial class RReadWriteTask : RMember //
    {

		/// <summary>
		/// System.Boolean _isRead
		/// </summary>
		protected RField r__isRead;
		public virtual RField R_isRead
		{
			get
			{
				if(r__isRead == null)
				{
					r__isRead = new(this, "_isRead");
					r__isRead.SetBelong(this.instance);
				}
				return r__isRead;
			}
		}

		/// <summary>
		/// System.Boolean _apm
		/// </summary>
		protected RField r__apm;
		public virtual RField R_apm
		{
			get
			{
				if(r__apm == null)
				{
					r__apm = new(this, "_apm");
					r__apm.SetBelong(this.instance);
				}
				return r__apm;
			}
		}

		/// <summary>
		/// System.IO.Stream _stream
		/// </summary>
		protected RSystem.RIO.RStream r__stream;
		public virtual RSystem.RIO.RStream R_stream
		{
			get
			{
				if(r__stream == null)
				{
					r__stream = new(this, "_stream");
					r__stream.SetBelong(this.instance);
				}
				return r__stream;
			}
		}

		/// <summary>
		/// System.Byte[] _buffer
		/// </summary>
		protected RFieldArray<RField> r__buffer;
		public virtual RFieldArray<RField> R_buffer
		{
			get
			{
				if(r__buffer == null)
				{
					r__buffer = new(this, "_buffer");
					r__buffer.SetBelong(this.instance);
				}
				return r__buffer;
			}
		}

		/// <summary>
		/// System.Int32 _offset
		/// </summary>
		protected RField r__offset;
		public virtual RField R_offset
		{
			get
			{
				if(r__offset == null)
				{
					r__offset = new(this, "_offset");
					r__offset.SetBelong(this.instance);
				}
				return r__offset;
			}
		}

		/// <summary>
		/// System.Int32 _count
		/// </summary>
		protected RField r__count;
		public virtual RField R_count
		{
			get
			{
				if(r__count == null)
				{
					r__count = new(this, "_count");
					r__count.SetBelong(this.instance);
				}
				return r__count;
			}
		}

		/// <summary>
		/// System.AsyncCallback _callback
		/// </summary>
		protected RSystem.RAsyncCallback r__callback;
		public virtual RSystem.RAsyncCallback R_callback
		{
			get
			{
				if(r__callback == null)
				{
					r__callback = new(this, "_callback");
					r__callback.SetBelong(this.instance);
				}
				return r__callback;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext _context
		/// </summary>
		protected RSystem.RThreading.RExecutionContext r__context;
		public virtual RSystem.RThreading.RExecutionContext R_context
		{
			get
			{
				if(r__context == null)
				{
					r__context = new(this, "_context");
					r__context.SetBelong(this.instance);
				}
				return r__context;
			}
		}

		/// <summary>
		/// System.Threading.ContextCallback s_invokeAsyncCallback
		/// </summary>
		protected static RSystem.RThreading.RContextCallback r_s_invokeAsyncCallback;
		public static RSystem.RThreading.RContextCallback Rs_invokeAsyncCallback
		{
			get
			{
				if(r_s_invokeAsyncCallback == null)
				{
					r_s_invokeAsyncCallback = new( ReflectionUtils.GetType("System.IO.Stream+ReadWriteTask"), "s_invokeAsyncCallback");
					r_s_invokeAsyncCallback.SetBelong(null);
				}
				return r_s_invokeAsyncCallback;
			}
		}

		/// <summary>
		/// System.Int32 m_result
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
		/// Boolean System.Threading.Tasks.ITaskCompletionAction.InvokeMayRunArbitraryCode
		/// </summary>
		protected RProperty r_System__2__Threading__2__Tasks__2__ITaskCompletionAction__2__InvokeMayRunArbitraryCode;
		public virtual RProperty RSystem__2__Threading__2__Tasks__2__ITaskCompletionAction__2__InvokeMayRunArbitraryCode
		{
			get
			{
				if(r_System__2__Threading__2__Tasks__2__ITaskCompletionAction__2__InvokeMayRunArbitraryCode == null)
				{
					r_System__2__Threading__2__Tasks__2__ITaskCompletionAction__2__InvokeMayRunArbitraryCode = new(this, "System.Threading.Tasks.ITaskCompletionAction.InvokeMayRunArbitraryCode", -1);
					r_System__2__Threading__2__Tasks__2__ITaskCompletionAction__2__InvokeMayRunArbitraryCode.SetBelong(this.instance);
				}
				return r_System__2__Threading__2__Tasks__2__ITaskCompletionAction__2__InvokeMayRunArbitraryCode;
			}
		}

		/// <summary>
		/// Int32 Result
		/// </summary>
		protected RProperty r_Result;
		public virtual RProperty RResult
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
		/// Int32 ResultOnSuccess
		/// </summary>
		protected RProperty r_ResultOnSuccess;
		public virtual RProperty RResultOnSuccess
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
		/// Void ClearBeginState()
		/// </summary>
		protected RMethod r_ClearBeginState;
		public virtual RMethod RClearBeginState
		{
			get
			{
				if(r_ClearBeginState == null)
				{
					r_ClearBeginState = new(this, "ClearBeginState", 0);
					r_ClearBeginState.SetBelong(this.instance);
				}
				return r_ClearBeginState;
			}
		}

		/// <summary>
		/// Void InvokeAsyncCallback(System.Object)
		/// </summary>
		protected static RMethod r_InvokeAsyncCallback_Object;
		public static RMethod RInvokeAsyncCallback_Object
		{
			get
			{
				if(r_InvokeAsyncCallback_Object == null)
				{
					r_InvokeAsyncCallback_Object = new( ReflectionUtils.GetType("System.IO.Stream+ReadWriteTask"), "InvokeAsyncCallback", 0, typeof(System.Object));
					r_InvokeAsyncCallback_Object.SetBelong(null);
				}
				return r_InvokeAsyncCallback_Object;
			}
		}

		/// <summary>
		/// Void System.Threading.Tasks.ITaskCompletionAction.Invoke(System.Threading.Tasks.Task)
		/// </summary>
		protected RMethod r_System__2__Threading__2__Tasks__2__ITaskCompletionAction__2__Invoke_Task;
		public virtual RMethod RSystem__2__Threading__2__Tasks__2__ITaskCompletionAction__2__Invoke_Task
		{
			get
			{
				if(r_System__2__Threading__2__Tasks__2__ITaskCompletionAction__2__Invoke_Task == null)
				{
					r_System__2__Threading__2__Tasks__2__ITaskCompletionAction__2__Invoke_Task = new(this, "System.Threading.Tasks.ITaskCompletionAction.Invoke", 0, typeof(System.Threading.Tasks.Task));
					r_System__2__Threading__2__Tasks__2__ITaskCompletionAction__2__Invoke_Task.SetBelong(this.instance);
				}
				return r_System__2__Threading__2__Tasks__2__ITaskCompletionAction__2__Invoke_Task;
			}
		}

		/// <summary>
		/// Boolean TrySetResult(Int32)
		/// </summary>
		protected RMethod r_TrySetResult_Int32;
		public virtual RMethod RTrySetResult_Int32
		{
			get
			{
				if(r_TrySetResult_Int32 == null)
				{
					r_TrySetResult_Int32 = new(this, "TrySetResult", 0, typeof(System.Int32));
					r_TrySetResult_Int32.SetBelong(this.instance);
				}
				return r_TrySetResult_Int32;
			}
		}

		/// <summary>
		/// Void DangerousSetResult(Int32)
		/// </summary>
		protected RMethod r_DangerousSetResult_Int32;
		public virtual RMethod RDangerousSetResult_Int32
		{
			get
			{
				if(r_DangerousSetResult_Int32 == null)
				{
					r_DangerousSetResult_Int32 = new(this, "DangerousSetResult", 0, typeof(System.Int32));
					r_DangerousSetResult_Int32.SetBelong(this.instance);
				}
				return r_DangerousSetResult_Int32;
			}
		}

		/// <summary>
		/// Int32 GetResultCore(Boolean)
		/// </summary>
		protected RMethod r_GetResultCore_Boolean;
		public virtual RMethod RGetResultCore_Boolean
		{
			get
			{
				if(r_GetResultCore_Boolean == null)
				{
					r_GetResultCore_Boolean = new(this, "GetResultCore", 0, typeof(System.Boolean));
					r_GetResultCore_Boolean.SetBelong(this.instance);
				}
				return r_GetResultCore_Boolean;
			}
		}

		/// <summary>
		/// Void InnerInvoke()
		/// </summary>
		protected RMethod r_InnerInvoke;
		public virtual RMethod RInnerInvoke
		{
			get
			{
				if(r_InnerInvoke == null)
				{
					r_InnerInvoke = new(this, "InnerInvoke", 0);
					r_InnerInvoke.SetBelong(this.instance);
				}
				return r_InnerInvoke;
			}
		}

		/// <summary>
		/// System.Runtime.CompilerServices.TaskAwaiter`1[System.Int32] GetAwaiter()
		/// </summary>
		protected RMethod r_GetAwaiter;
		public virtual RMethod RGetAwaiter
		{
			get
			{
				if(r_GetAwaiter == null)
				{
					r_GetAwaiter = new(this, "GetAwaiter", 0);
					r_GetAwaiter.SetBelong(this.instance);
				}
				return r_GetAwaiter;
			}
		}

		/// <summary>
		/// System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1[System.Int32] ConfigureAwait(Boolean)
		/// </summary>
		protected RMethod r_ConfigureAwait_Boolean;
		public virtual RMethod RConfigureAwait_Boolean
		{
			get
			{
				if(r_ConfigureAwait_Boolean == null)
				{
					r_ConfigureAwait_Boolean = new(this, "ConfigureAwait", 0, typeof(System.Boolean));
					r_ConfigureAwait_Boolean.SetBelong(this.instance);
				}
				return r_ConfigureAwait_Boolean;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task`1[System.Int32]])
		/// </summary>
		protected RMethod r_ContinueWith_Action_d_Task_d_Int32_p__p_;
		public virtual RMethod RContinueWith_Action_d_Task_d_Int32_p__p_
		{
			get
			{
				if(r_ContinueWith_Action_d_Task_d_Int32_p__p_ == null)
				{
					r_ContinueWith_Action_d_Task_d_Int32_p__p_ = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32))));
					r_ContinueWith_Action_d_Task_d_Int32_p__p_.SetBelong(this.instance);
				}
				return r_ContinueWith_Action_d_Task_d_Int32_p__p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task`1[System.Int32]], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_ContinueWith_Action_d_Task_d_Int32_p__p__CancellationToken;
		public virtual RMethod RContinueWith_Action_d_Task_d_Int32_p__p__CancellationToken
		{
			get
			{
				if(r_ContinueWith_Action_d_Task_d_Int32_p__p__CancellationToken == null)
				{
					r_ContinueWith_Action_d_Task_d_Int32_p__p__CancellationToken = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32))), typeof(System.Threading.CancellationToken));
					r_ContinueWith_Action_d_Task_d_Int32_p__p__CancellationToken.SetBelong(this.instance);
				}
				return r_ContinueWith_Action_d_Task_d_Int32_p__p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task`1[System.Int32]], System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_ContinueWith_Action_d_Task_d_Int32_p__p__TaskScheduler;
		public virtual RMethod RContinueWith_Action_d_Task_d_Int32_p__p__TaskScheduler
		{
			get
			{
				if(r_ContinueWith_Action_d_Task_d_Int32_p__p__TaskScheduler == null)
				{
					r_ContinueWith_Action_d_Task_d_Int32_p__p__TaskScheduler = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32))), typeof(System.Threading.Tasks.TaskScheduler));
					r_ContinueWith_Action_d_Task_d_Int32_p__p__TaskScheduler.SetBelong(this.instance);
				}
				return r_ContinueWith_Action_d_Task_d_Int32_p__p__TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task`1[System.Int32]], System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_ContinueWith_Action_d_Task_d_Int32_p__p__TaskContinuationOptions;
		public virtual RMethod RContinueWith_Action_d_Task_d_Int32_p__p__TaskContinuationOptions
		{
			get
			{
				if(r_ContinueWith_Action_d_Task_d_Int32_p__p__TaskContinuationOptions == null)
				{
					r_ContinueWith_Action_d_Task_d_Int32_p__p__TaskContinuationOptions = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32))), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_ContinueWith_Action_d_Task_d_Int32_p__p__TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_ContinueWith_Action_d_Task_d_Int32_p__p__TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task`1[System.Int32]], System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_ContinueWith_Action_d_Task_d_Int32_p__p__CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RContinueWith_Action_d_Task_d_Int32_p__p__CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_ContinueWith_Action_d_Task_d_Int32_p__p__CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_ContinueWith_Action_d_Task_d_Int32_p__p__CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32))), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_ContinueWith_Action_d_Task_d_Int32_p__p__CancellationToken_TaskContinuationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_ContinueWith_Action_d_Task_d_Int32_p__p__CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task`1[System.Int32]], System.Threading.Tasks.TaskScheduler, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_ContinueWith_Action_d_Task_d_Int32_p__p__TaskScheduler_CancellationToken_TaskContinuationOptions;
		public virtual RMethod RContinueWith_Action_d_Task_d_Int32_p__p__TaskScheduler_CancellationToken_TaskContinuationOptions
		{
			get
			{
				if(r_ContinueWith_Action_d_Task_d_Int32_p__p__TaskScheduler_CancellationToken_TaskContinuationOptions == null)
				{
					r_ContinueWith_Action_d_Task_d_Int32_p__p__TaskScheduler_CancellationToken_TaskContinuationOptions = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32))), typeof(System.Threading.Tasks.TaskScheduler), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_ContinueWith_Action_d_Task_d_Int32_p__p__TaskScheduler_CancellationToken_TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_ContinueWith_Action_d_Task_d_Int32_p__p__TaskScheduler_CancellationToken_TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task`1[System.Int32],System.Object], System.Object)
		/// </summary>
		protected RMethod r_ContinueWith_Action_d_Task_d_Int32_p__Object_p__Object;
		public virtual RMethod RContinueWith_Action_d_Task_d_Int32_p__Object_p__Object
		{
			get
			{
				if(r_ContinueWith_Action_d_Task_d_Int32_p__Object_p__Object == null)
				{
					r_ContinueWith_Action_d_Task_d_Int32_p__Object_p__Object = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), typeof(System.Object)), typeof(System.Object));
					r_ContinueWith_Action_d_Task_d_Int32_p__Object_p__Object.SetBelong(this.instance);
				}
				return r_ContinueWith_Action_d_Task_d_Int32_p__Object_p__Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task`1[System.Int32],System.Object], System.Object, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_ContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_CancellationToken;
		public virtual RMethod RContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_CancellationToken
		{
			get
			{
				if(r_ContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_CancellationToken == null)
				{
					r_ContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_CancellationToken = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), typeof(System.Object)), typeof(System.Object), typeof(System.Threading.CancellationToken));
					r_ContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_CancellationToken.SetBelong(this.instance);
				}
				return r_ContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task`1[System.Int32],System.Object], System.Object, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_ContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskScheduler;
		public virtual RMethod RContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskScheduler
		{
			get
			{
				if(r_ContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskScheduler == null)
				{
					r_ContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskScheduler = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), typeof(System.Object)), typeof(System.Object), typeof(System.Threading.Tasks.TaskScheduler));
					r_ContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskScheduler.SetBelong(this.instance);
				}
				return r_ContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task`1[System.Int32],System.Object], System.Object, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_ContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskContinuationOptions;
		public virtual RMethod RContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskContinuationOptions
		{
			get
			{
				if(r_ContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskContinuationOptions == null)
				{
					r_ContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskContinuationOptions = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), typeof(System.Object)), typeof(System.Object), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_ContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_ContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task`1[System.Int32],System.Object], System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_ContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_ContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_ContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), typeof(System.Object)), typeof(System.Object), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_ContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_ContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task`1[System.Int32],System.Object], System.Object, System.Threading.Tasks.TaskScheduler, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_ContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions;
		public virtual RMethod RContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions
		{
			get
			{
				if(r_ContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions == null)
				{
					r_ContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), typeof(System.Object)), typeof(System.Object), typeof(System.Threading.Tasks.TaskScheduler), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_ContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_ContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`2[System.Threading.Tasks.Task`1[System.Int32],TNewResult])
		/// </summary>
		protected RMethod r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p_;
		public virtual RMethod RContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p_
		{
			get
			{
				if(r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p_ == null)
				{
					r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p_ = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), Type.MakeGenericMethodParameter(0)));
					r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p_.SetBelong(this.instance);
				}
				return r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`2[System.Threading.Tasks.Task`1[System.Int32],TNewResult], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__CancellationToken;
		public virtual RMethod RContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__CancellationToken
		{
			get
			{
				if(r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__CancellationToken == null)
				{
					r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__CancellationToken = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken));
					r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__CancellationToken.SetBelong(this.instance);
				}
				return r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`2[System.Threading.Tasks.Task`1[System.Int32],TNewResult], System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskScheduler;
		public virtual RMethod RContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskScheduler
		{
			get
			{
				if(r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskScheduler == null)
				{
					r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskScheduler = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskScheduler));
					r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskScheduler.SetBelong(this.instance);
				}
				return r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`2[System.Threading.Tasks.Task`1[System.Int32],TNewResult], System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskContinuationOptions;
		public virtual RMethod RContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskContinuationOptions
		{
			get
			{
				if(r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskContinuationOptions == null)
				{
					r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskContinuationOptions = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`2[System.Threading.Tasks.Task`1[System.Int32],TNewResult], System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`2[System.Threading.Tasks.Task`1[System.Int32],TNewResult], System.Threading.Tasks.TaskScheduler, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskScheduler_CancellationToken_TaskContinuationOptions;
		public virtual RMethod RContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskScheduler_CancellationToken_TaskContinuationOptions
		{
			get
			{
				if(r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskScheduler_CancellationToken_TaskContinuationOptions == null)
				{
					r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskScheduler_CancellationToken_TaskContinuationOptions = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskScheduler), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskScheduler_CancellationToken_TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskScheduler_CancellationToken_TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`3[System.Threading.Tasks.Task`1[System.Int32],System.Object,TNewResult], System.Object)
		/// </summary>
		protected RMethod r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object;
		public virtual RMethod RContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object
		{
			get
			{
				if(r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object == null)
				{
					r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object));
					r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object.SetBelong(this.instance);
				}
				return r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`3[System.Threading.Tasks.Task`1[System.Int32],System.Object,TNewResult], System.Object, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_CancellationToken;
		public virtual RMethod RContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_CancellationToken
		{
			get
			{
				if(r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_CancellationToken == null)
				{
					r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_CancellationToken = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.CancellationToken));
					r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_CancellationToken.SetBelong(this.instance);
				}
				return r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`3[System.Threading.Tasks.Task`1[System.Int32],System.Object,TNewResult], System.Object, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskScheduler;
		public virtual RMethod RContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskScheduler
		{
			get
			{
				if(r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskScheduler == null)
				{
					r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskScheduler = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.Tasks.TaskScheduler));
					r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskScheduler.SetBelong(this.instance);
				}
				return r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`3[System.Threading.Tasks.Task`1[System.Int32],System.Object,TNewResult], System.Object, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskContinuationOptions;
		public virtual RMethod RContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskContinuationOptions
		{
			get
			{
				if(r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskContinuationOptions == null)
				{
					r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskContinuationOptions = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`3[System.Threading.Tasks.Task`1[System.Int32],System.Object,TNewResult], System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`3[System.Threading.Tasks.Task`1[System.Int32],System.Object,TNewResult], System.Object, System.Threading.Tasks.TaskScheduler, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions;
		public virtual RMethod RContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions
		{
			get
			{
				if(r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions == null)
				{
					r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.Tasks.TaskScheduler), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_ContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions;
			}
		}

		/// <summary>
		/// Void TaskConstructorCore(System.Delegate, System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.InternalTaskOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_TaskConstructorCore_Delegate_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler;
		public virtual RMethod RTaskConstructorCore_Delegate_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler
		{
			get
			{
				if(r_TaskConstructorCore_Delegate_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler == null)
				{
					r_TaskConstructorCore_Delegate_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler = new(this, "TaskConstructorCore", 0, typeof(System.Delegate), typeof(System.Object), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskCreationOptions),  ReflectionUtils.GetType("System.Threading.Tasks.InternalTaskOptions"), typeof(System.Threading.Tasks.TaskScheduler));
					r_TaskConstructorCore_Delegate_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_TaskConstructorCore_Delegate_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// Boolean TrySetCanceled(System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_TrySetCanceled_CancellationToken;
		public virtual RMethod RTrySetCanceled_CancellationToken
		{
			get
			{
				if(r_TrySetCanceled_CancellationToken == null)
				{
					r_TrySetCanceled_CancellationToken = new(this, "TrySetCanceled", 0, typeof(System.Threading.CancellationToken));
					r_TrySetCanceled_CancellationToken.SetBelong(this.instance);
				}
				return r_TrySetCanceled_CancellationToken;
			}
		}

		/// <summary>
		/// Boolean TrySetCanceled(System.Threading.CancellationToken, System.Object)
		/// </summary>
		protected RMethod r_TrySetCanceled_CancellationToken_Object;
		public virtual RMethod RTrySetCanceled_CancellationToken_Object
		{
			get
			{
				if(r_TrySetCanceled_CancellationToken_Object == null)
				{
					r_TrySetCanceled_CancellationToken_Object = new(this, "TrySetCanceled", 0, typeof(System.Threading.CancellationToken), typeof(System.Object));
					r_TrySetCanceled_CancellationToken_Object.SetBelong(this.instance);
				}
				return r_TrySetCanceled_CancellationToken_Object;
			}
		}

		/// <summary>
		/// Boolean TrySetException(System.Object)
		/// </summary>
		protected RMethod r_TrySetException_Object;
		public virtual RMethod RTrySetException_Object
		{
			get
			{
				if(r_TrySetException_Object == null)
				{
					r_TrySetException_Object = new(this, "TrySetException", 0, typeof(System.Object));
					r_TrySetException_Object.SetBelong(this.instance);
				}
				return r_TrySetException_Object;
			}
		}

		/// <summary>
		/// Boolean AtomicStateUpdate(Int32, Int32)
		/// </summary>
		protected RMethod r_AtomicStateUpdate_Int32_Int32;
		public virtual RMethod RAtomicStateUpdate_Int32_Int32
		{
			get
			{
				if(r_AtomicStateUpdate_Int32_Int32 == null)
				{
					r_AtomicStateUpdate_Int32_Int32 = new(this, "AtomicStateUpdate", 0, typeof(System.Int32), typeof(System.Int32));
					r_AtomicStateUpdate_Int32_Int32.SetBelong(this.instance);
				}
				return r_AtomicStateUpdate_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean AtomicStateUpdate(Int32, Int32, Int32 ByRef)
		/// </summary>
		protected RMethod r_AtomicStateUpdate_Int32_Int32_Ref_Int32;
		public virtual RMethod RAtomicStateUpdate_Int32_Int32_Ref_Int32
		{
			get
			{
				if(r_AtomicStateUpdate_Int32_Int32_Ref_Int32 == null)
				{
					r_AtomicStateUpdate_Int32_Int32_Ref_Int32 = new(this, "AtomicStateUpdate", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32).MakeByRefType());
					r_AtomicStateUpdate_Int32_Int32_Ref_Int32.SetBelong(this.instance);
				}
				return r_AtomicStateUpdate_Int32_Int32_Ref_Int32;
			}
		}

		/// <summary>
		/// Void SetNotificationForWaitCompletion(Boolean)
		/// </summary>
		protected RMethod r_SetNotificationForWaitCompletion_Boolean;
		public virtual RMethod RSetNotificationForWaitCompletion_Boolean
		{
			get
			{
				if(r_SetNotificationForWaitCompletion_Boolean == null)
				{
					r_SetNotificationForWaitCompletion_Boolean = new(this, "SetNotificationForWaitCompletion", 0, typeof(System.Boolean));
					r_SetNotificationForWaitCompletion_Boolean.SetBelong(this.instance);
				}
				return r_SetNotificationForWaitCompletion_Boolean;
			}
		}

		/// <summary>
		/// Boolean NotifyDebuggerOfWaitCompletionIfNecessary()
		/// </summary>
		protected RMethod r_NotifyDebuggerOfWaitCompletionIfNecessary;
		public virtual RMethod RNotifyDebuggerOfWaitCompletionIfNecessary
		{
			get
			{
				if(r_NotifyDebuggerOfWaitCompletionIfNecessary == null)
				{
					r_NotifyDebuggerOfWaitCompletionIfNecessary = new(this, "NotifyDebuggerOfWaitCompletionIfNecessary", 0);
					r_NotifyDebuggerOfWaitCompletionIfNecessary.SetBelong(this.instance);
				}
				return r_NotifyDebuggerOfWaitCompletionIfNecessary;
			}
		}

		/// <summary>
		/// Boolean MarkStarted()
		/// </summary>
		protected RMethod r_MarkStarted;
		public virtual RMethod RMarkStarted
		{
			get
			{
				if(r_MarkStarted == null)
				{
					r_MarkStarted = new(this, "MarkStarted", 0);
					r_MarkStarted.SetBelong(this.instance);
				}
				return r_MarkStarted;
			}
		}

		/// <summary>
		/// Void AddNewChild()
		/// </summary>
		protected RMethod r_AddNewChild;
		public virtual RMethod RAddNewChild
		{
			get
			{
				if(r_AddNewChild == null)
				{
					r_AddNewChild = new(this, "AddNewChild", 0);
					r_AddNewChild.SetBelong(this.instance);
				}
				return r_AddNewChild;
			}
		}

		/// <summary>
		/// Void DisregardChild()
		/// </summary>
		protected RMethod r_DisregardChild;
		public virtual RMethod RDisregardChild
		{
			get
			{
				if(r_DisregardChild == null)
				{
					r_DisregardChild = new(this, "DisregardChild", 0);
					r_DisregardChild.SetBelong(this.instance);
				}
				return r_DisregardChild;
			}
		}

		/// <summary>
		/// Void Start()
		/// </summary>
		protected RMethod r_Start;
		public virtual RMethod RStart
		{
			get
			{
				if(r_Start == null)
				{
					r_Start = new(this, "Start", 0);
					r_Start.SetBelong(this.instance);
				}
				return r_Start;
			}
		}

		/// <summary>
		/// Void Start(System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_Start_TaskScheduler;
		public virtual RMethod RStart_TaskScheduler
		{
			get
			{
				if(r_Start_TaskScheduler == null)
				{
					r_Start_TaskScheduler = new(this, "Start", 0, typeof(System.Threading.Tasks.TaskScheduler));
					r_Start_TaskScheduler.SetBelong(this.instance);
				}
				return r_Start_TaskScheduler;
			}
		}

		/// <summary>
		/// Void RunSynchronously()
		/// </summary>
		protected RMethod r_RunSynchronously;
		public virtual RMethod RRunSynchronously
		{
			get
			{
				if(r_RunSynchronously == null)
				{
					r_RunSynchronously = new(this, "RunSynchronously", 0);
					r_RunSynchronously.SetBelong(this.instance);
				}
				return r_RunSynchronously;
			}
		}

		/// <summary>
		/// Void RunSynchronously(System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RunSynchronously_TaskScheduler;
		public virtual RMethod RRunSynchronously_TaskScheduler
		{
			get
			{
				if(r_RunSynchronously_TaskScheduler == null)
				{
					r_RunSynchronously_TaskScheduler = new(this, "RunSynchronously", 0, typeof(System.Threading.Tasks.TaskScheduler));
					r_RunSynchronously_TaskScheduler.SetBelong(this.instance);
				}
				return r_RunSynchronously_TaskScheduler;
			}
		}

		/// <summary>
		/// Void InternalRunSynchronously(System.Threading.Tasks.TaskScheduler, Boolean)
		/// </summary>
		protected RMethod r_InternalRunSynchronously_TaskScheduler_Boolean;
		public virtual RMethod RInternalRunSynchronously_TaskScheduler_Boolean
		{
			get
			{
				if(r_InternalRunSynchronously_TaskScheduler_Boolean == null)
				{
					r_InternalRunSynchronously_TaskScheduler_Boolean = new(this, "InternalRunSynchronously", 0, typeof(System.Threading.Tasks.TaskScheduler), typeof(System.Boolean));
					r_InternalRunSynchronously_TaskScheduler_Boolean.SetBelong(this.instance);
				}
				return r_InternalRunSynchronously_TaskScheduler_Boolean;
			}
		}

		/// <summary>
		/// ContingentProperties EnsureContingentPropertiesInitialized(Boolean)
		/// </summary>
		protected RMethod r_EnsureContingentPropertiesInitialized_Boolean;
		public virtual RMethod REnsureContingentPropertiesInitialized_Boolean
		{
			get
			{
				if(r_EnsureContingentPropertiesInitialized_Boolean == null)
				{
					r_EnsureContingentPropertiesInitialized_Boolean = new(this, "EnsureContingentPropertiesInitialized", 0, typeof(System.Boolean));
					r_EnsureContingentPropertiesInitialized_Boolean.SetBelong(this.instance);
				}
				return r_EnsureContingentPropertiesInitialized_Boolean;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_Dispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_Dispose == null)
				{
					r_Dispose = new(this, "Dispose", 0);
					r_Dispose.SetBelong(this.instance);
				}
				return r_Dispose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_Dispose_Boolean;
		public virtual RMethod RDispose_Boolean
		{
			get
			{
				if(r_Dispose_Boolean == null)
				{
					r_Dispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_Dispose_Boolean.SetBelong(this.instance);
				}
				return r_Dispose_Boolean;
			}
		}

		/// <summary>
		/// Void ScheduleAndStart(Boolean)
		/// </summary>
		protected RMethod r_ScheduleAndStart_Boolean;
		public virtual RMethod RScheduleAndStart_Boolean
		{
			get
			{
				if(r_ScheduleAndStart_Boolean == null)
				{
					r_ScheduleAndStart_Boolean = new(this, "ScheduleAndStart", 0, typeof(System.Boolean));
					r_ScheduleAndStart_Boolean.SetBelong(this.instance);
				}
				return r_ScheduleAndStart_Boolean;
			}
		}

		/// <summary>
		/// Void AddException(System.Object)
		/// </summary>
		protected RMethod r_AddException_Object;
		public virtual RMethod RAddException_Object
		{
			get
			{
				if(r_AddException_Object == null)
				{
					r_AddException_Object = new(this, "AddException", 0, typeof(System.Object));
					r_AddException_Object.SetBelong(this.instance);
				}
				return r_AddException_Object;
			}
		}

		/// <summary>
		/// Void AddException(System.Object, Boolean)
		/// </summary>
		protected RMethod r_AddException_Object_Boolean;
		public virtual RMethod RAddException_Object_Boolean
		{
			get
			{
				if(r_AddException_Object_Boolean == null)
				{
					r_AddException_Object_Boolean = new(this, "AddException", 0, typeof(System.Object), typeof(System.Boolean));
					r_AddException_Object_Boolean.SetBelong(this.instance);
				}
				return r_AddException_Object_Boolean;
			}
		}

		/// <summary>
		/// System.Collections.ObjectModel.ReadOnlyCollection`1[System.Runtime.ExceptionServices.ExceptionDispatchInfo] GetExceptionDispatchInfos()
		/// </summary>
		protected RMethod r_GetExceptionDispatchInfos;
		public virtual RMethod RGetExceptionDispatchInfos
		{
			get
			{
				if(r_GetExceptionDispatchInfos == null)
				{
					r_GetExceptionDispatchInfos = new(this, "GetExceptionDispatchInfos", 0);
					r_GetExceptionDispatchInfos.SetBelong(this.instance);
				}
				return r_GetExceptionDispatchInfos;
			}
		}

		/// <summary>
		/// System.Runtime.ExceptionServices.ExceptionDispatchInfo GetCancellationExceptionDispatchInfo()
		/// </summary>
		protected RMethod r_GetCancellationExceptionDispatchInfo;
		public virtual RMethod RGetCancellationExceptionDispatchInfo
		{
			get
			{
				if(r_GetCancellationExceptionDispatchInfo == null)
				{
					r_GetCancellationExceptionDispatchInfo = new(this, "GetCancellationExceptionDispatchInfo", 0);
					r_GetCancellationExceptionDispatchInfo.SetBelong(this.instance);
				}
				return r_GetCancellationExceptionDispatchInfo;
			}
		}

		/// <summary>
		/// Void ThrowIfExceptional(Boolean)
		/// </summary>
		protected RMethod r_ThrowIfExceptional_Boolean;
		public virtual RMethod RThrowIfExceptional_Boolean
		{
			get
			{
				if(r_ThrowIfExceptional_Boolean == null)
				{
					r_ThrowIfExceptional_Boolean = new(this, "ThrowIfExceptional", 0, typeof(System.Boolean));
					r_ThrowIfExceptional_Boolean.SetBelong(this.instance);
				}
				return r_ThrowIfExceptional_Boolean;
			}
		}

		/// <summary>
		/// Void UpdateExceptionObservedStatus()
		/// </summary>
		protected RMethod r_UpdateExceptionObservedStatus;
		public virtual RMethod RUpdateExceptionObservedStatus
		{
			get
			{
				if(r_UpdateExceptionObservedStatus == null)
				{
					r_UpdateExceptionObservedStatus = new(this, "UpdateExceptionObservedStatus", 0);
					r_UpdateExceptionObservedStatus.SetBelong(this.instance);
				}
				return r_UpdateExceptionObservedStatus;
			}
		}

		/// <summary>
		/// Void Finish(Boolean)
		/// </summary>
		protected RMethod r_Finish_Boolean;
		public virtual RMethod RFinish_Boolean
		{
			get
			{
				if(r_Finish_Boolean == null)
				{
					r_Finish_Boolean = new(this, "Finish", 0, typeof(System.Boolean));
					r_Finish_Boolean.SetBelong(this.instance);
				}
				return r_Finish_Boolean;
			}
		}

		/// <summary>
		/// Void FinishStageTwo()
		/// </summary>
		protected RMethod r_FinishStageTwo;
		public virtual RMethod RFinishStageTwo
		{
			get
			{
				if(r_FinishStageTwo == null)
				{
					r_FinishStageTwo = new(this, "FinishStageTwo", 0);
					r_FinishStageTwo.SetBelong(this.instance);
				}
				return r_FinishStageTwo;
			}
		}

		/// <summary>
		/// Void FinishStageThree()
		/// </summary>
		protected RMethod r_FinishStageThree;
		public virtual RMethod RFinishStageThree
		{
			get
			{
				if(r_FinishStageThree == null)
				{
					r_FinishStageThree = new(this, "FinishStageThree", 0);
					r_FinishStageThree.SetBelong(this.instance);
				}
				return r_FinishStageThree;
			}
		}

		/// <summary>
		/// Void ProcessChildCompletion(System.Threading.Tasks.Task)
		/// </summary>
		protected RMethod r_ProcessChildCompletion_Task;
		public virtual RMethod RProcessChildCompletion_Task
		{
			get
			{
				if(r_ProcessChildCompletion_Task == null)
				{
					r_ProcessChildCompletion_Task = new(this, "ProcessChildCompletion", 0, typeof(System.Threading.Tasks.Task));
					r_ProcessChildCompletion_Task.SetBelong(this.instance);
				}
				return r_ProcessChildCompletion_Task;
			}
		}

		/// <summary>
		/// Void AddExceptionsFromChildren()
		/// </summary>
		protected RMethod r_AddExceptionsFromChildren;
		public virtual RMethod RAddExceptionsFromChildren
		{
			get
			{
				if(r_AddExceptionsFromChildren == null)
				{
					r_AddExceptionsFromChildren = new(this, "AddExceptionsFromChildren", 0);
					r_AddExceptionsFromChildren.SetBelong(this.instance);
				}
				return r_AddExceptionsFromChildren;
			}
		}

		/// <summary>
		/// Boolean ExecuteEntry(Boolean)
		/// </summary>
		protected RMethod r_ExecuteEntry_Boolean;
		public virtual RMethod RExecuteEntry_Boolean
		{
			get
			{
				if(r_ExecuteEntry_Boolean == null)
				{
					r_ExecuteEntry_Boolean = new(this, "ExecuteEntry", 0, typeof(System.Boolean));
					r_ExecuteEntry_Boolean.SetBelong(this.instance);
				}
				return r_ExecuteEntry_Boolean;
			}
		}

		/// <summary>
		/// Void SetContinuationForAwait(System.Action, Boolean, Boolean)
		/// </summary>
		protected RMethod r_SetContinuationForAwait_Action_Boolean_Boolean;
		public virtual RMethod RSetContinuationForAwait_Action_Boolean_Boolean
		{
			get
			{
				if(r_SetContinuationForAwait_Action_Boolean_Boolean == null)
				{
					r_SetContinuationForAwait_Action_Boolean_Boolean = new(this, "SetContinuationForAwait", 0, typeof(System.Action), typeof(System.Boolean), typeof(System.Boolean));
					r_SetContinuationForAwait_Action_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_SetContinuationForAwait_Action_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void Wait()
		/// </summary>
		protected RMethod r_Wait;
		public virtual RMethod RWait
		{
			get
			{
				if(r_Wait == null)
				{
					r_Wait = new(this, "Wait", 0);
					r_Wait.SetBelong(this.instance);
				}
				return r_Wait;
			}
		}

		/// <summary>
		/// Boolean Wait(System.TimeSpan)
		/// </summary>
		protected RMethod r_Wait_TimeSpan;
		public virtual RMethod RWait_TimeSpan
		{
			get
			{
				if(r_Wait_TimeSpan == null)
				{
					r_Wait_TimeSpan = new(this, "Wait", 0, typeof(System.TimeSpan));
					r_Wait_TimeSpan.SetBelong(this.instance);
				}
				return r_Wait_TimeSpan;
			}
		}

		/// <summary>
		/// Void Wait(System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_Wait_CancellationToken;
		public virtual RMethod RWait_CancellationToken
		{
			get
			{
				if(r_Wait_CancellationToken == null)
				{
					r_Wait_CancellationToken = new(this, "Wait", 0, typeof(System.Threading.CancellationToken));
					r_Wait_CancellationToken.SetBelong(this.instance);
				}
				return r_Wait_CancellationToken;
			}
		}

		/// <summary>
		/// Boolean Wait(Int32)
		/// </summary>
		protected RMethod r_Wait_Int32;
		public virtual RMethod RWait_Int32
		{
			get
			{
				if(r_Wait_Int32 == null)
				{
					r_Wait_Int32 = new(this, "Wait", 0, typeof(System.Int32));
					r_Wait_Int32.SetBelong(this.instance);
				}
				return r_Wait_Int32;
			}
		}

		/// <summary>
		/// Boolean Wait(Int32, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_Wait_Int32_CancellationToken;
		public virtual RMethod RWait_Int32_CancellationToken
		{
			get
			{
				if(r_Wait_Int32_CancellationToken == null)
				{
					r_Wait_Int32_CancellationToken = new(this, "Wait", 0, typeof(System.Int32), typeof(System.Threading.CancellationToken));
					r_Wait_Int32_CancellationToken.SetBelong(this.instance);
				}
				return r_Wait_Int32_CancellationToken;
			}
		}

		/// <summary>
		/// Boolean InternalWait(Int32, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_InternalWait_Int32_CancellationToken;
		public virtual RMethod RInternalWait_Int32_CancellationToken
		{
			get
			{
				if(r_InternalWait_Int32_CancellationToken == null)
				{
					r_InternalWait_Int32_CancellationToken = new(this, "InternalWait", 0, typeof(System.Int32), typeof(System.Threading.CancellationToken));
					r_InternalWait_Int32_CancellationToken.SetBelong(this.instance);
				}
				return r_InternalWait_Int32_CancellationToken;
			}
		}

		/// <summary>
		/// Boolean InternalCancel(Boolean)
		/// </summary>
		protected RMethod r_InternalCancel_Boolean;
		public virtual RMethod RInternalCancel_Boolean
		{
			get
			{
				if(r_InternalCancel_Boolean == null)
				{
					r_InternalCancel_Boolean = new(this, "InternalCancel", 0, typeof(System.Boolean));
					r_InternalCancel_Boolean.SetBelong(this.instance);
				}
				return r_InternalCancel_Boolean;
			}
		}

		/// <summary>
		/// Void RecordInternalCancellationRequest()
		/// </summary>
		protected RMethod r_RecordInternalCancellationRequest;
		public virtual RMethod RRecordInternalCancellationRequest
		{
			get
			{
				if(r_RecordInternalCancellationRequest == null)
				{
					r_RecordInternalCancellationRequest = new(this, "RecordInternalCancellationRequest", 0);
					r_RecordInternalCancellationRequest.SetBelong(this.instance);
				}
				return r_RecordInternalCancellationRequest;
			}
		}

		/// <summary>
		/// Void RecordInternalCancellationRequest(System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RecordInternalCancellationRequest_CancellationToken;
		public virtual RMethod RRecordInternalCancellationRequest_CancellationToken
		{
			get
			{
				if(r_RecordInternalCancellationRequest_CancellationToken == null)
				{
					r_RecordInternalCancellationRequest_CancellationToken = new(this, "RecordInternalCancellationRequest", 0, typeof(System.Threading.CancellationToken));
					r_RecordInternalCancellationRequest_CancellationToken.SetBelong(this.instance);
				}
				return r_RecordInternalCancellationRequest_CancellationToken;
			}
		}

		/// <summary>
		/// Void RecordInternalCancellationRequest(System.Threading.CancellationToken, System.Object)
		/// </summary>
		protected RMethod r_RecordInternalCancellationRequest_CancellationToken_Object;
		public virtual RMethod RRecordInternalCancellationRequest_CancellationToken_Object
		{
			get
			{
				if(r_RecordInternalCancellationRequest_CancellationToken_Object == null)
				{
					r_RecordInternalCancellationRequest_CancellationToken_Object = new(this, "RecordInternalCancellationRequest", 0, typeof(System.Threading.CancellationToken), typeof(System.Object));
					r_RecordInternalCancellationRequest_CancellationToken_Object.SetBelong(this.instance);
				}
				return r_RecordInternalCancellationRequest_CancellationToken_Object;
			}
		}

		/// <summary>
		/// Void CancellationCleanupLogic()
		/// </summary>
		protected RMethod r_CancellationCleanupLogic;
		public virtual RMethod RCancellationCleanupLogic
		{
			get
			{
				if(r_CancellationCleanupLogic == null)
				{
					r_CancellationCleanupLogic = new(this, "CancellationCleanupLogic", 0);
					r_CancellationCleanupLogic.SetBelong(this.instance);
				}
				return r_CancellationCleanupLogic;
			}
		}

		/// <summary>
		/// Void FinishContinuations()
		/// </summary>
		protected RMethod r_FinishContinuations;
		public virtual RMethod RFinishContinuations
		{
			get
			{
				if(r_FinishContinuations == null)
				{
					r_FinishContinuations = new(this, "FinishContinuations", 0);
					r_FinishContinuations.SetBelong(this.instance);
				}
				return r_FinishContinuations;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task])
		/// </summary>
		protected RMethod r_ContinueWith_Action_d_Task_p_;
		public virtual RMethod RContinueWith_Action_d_Task_p_
		{
			get
			{
				if(r_ContinueWith_Action_d_Task_p_ == null)
				{
					r_ContinueWith_Action_d_Task_p_ = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task)));
					r_ContinueWith_Action_d_Task_p_.SetBelong(this.instance);
				}
				return r_ContinueWith_Action_d_Task_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_ContinueWith_Action_d_Task_p__CancellationToken;
		public virtual RMethod RContinueWith_Action_d_Task_p__CancellationToken
		{
			get
			{
				if(r_ContinueWith_Action_d_Task_p__CancellationToken == null)
				{
					r_ContinueWith_Action_d_Task_p__CancellationToken = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task)), typeof(System.Threading.CancellationToken));
					r_ContinueWith_Action_d_Task_p__CancellationToken.SetBelong(this.instance);
				}
				return r_ContinueWith_Action_d_Task_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task], System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_ContinueWith_Action_d_Task_p__TaskScheduler;
		public virtual RMethod RContinueWith_Action_d_Task_p__TaskScheduler
		{
			get
			{
				if(r_ContinueWith_Action_d_Task_p__TaskScheduler == null)
				{
					r_ContinueWith_Action_d_Task_p__TaskScheduler = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task)), typeof(System.Threading.Tasks.TaskScheduler));
					r_ContinueWith_Action_d_Task_p__TaskScheduler.SetBelong(this.instance);
				}
				return r_ContinueWith_Action_d_Task_p__TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task], System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_ContinueWith_Action_d_Task_p__TaskContinuationOptions;
		public virtual RMethod RContinueWith_Action_d_Task_p__TaskContinuationOptions
		{
			get
			{
				if(r_ContinueWith_Action_d_Task_p__TaskContinuationOptions == null)
				{
					r_ContinueWith_Action_d_Task_p__TaskContinuationOptions = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task)), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_ContinueWith_Action_d_Task_p__TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_ContinueWith_Action_d_Task_p__TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task], System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_ContinueWith_Action_d_Task_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RContinueWith_Action_d_Task_p__CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_ContinueWith_Action_d_Task_p__CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_ContinueWith_Action_d_Task_p__CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task)), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_ContinueWith_Action_d_Task_p__CancellationToken_TaskContinuationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_ContinueWith_Action_d_Task_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task,System.Object], System.Object)
		/// </summary>
		protected RMethod r_ContinueWith_Action_d_Task_Object_p__Object;
		public virtual RMethod RContinueWith_Action_d_Task_Object_p__Object
		{
			get
			{
				if(r_ContinueWith_Action_d_Task_Object_p__Object == null)
				{
					r_ContinueWith_Action_d_Task_Object_p__Object = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object)), typeof(System.Object));
					r_ContinueWith_Action_d_Task_Object_p__Object.SetBelong(this.instance);
				}
				return r_ContinueWith_Action_d_Task_Object_p__Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task,System.Object], System.Object, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_ContinueWith_Action_d_Task_Object_p__Object_CancellationToken;
		public virtual RMethod RContinueWith_Action_d_Task_Object_p__Object_CancellationToken
		{
			get
			{
				if(r_ContinueWith_Action_d_Task_Object_p__Object_CancellationToken == null)
				{
					r_ContinueWith_Action_d_Task_Object_p__Object_CancellationToken = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object)), typeof(System.Object), typeof(System.Threading.CancellationToken));
					r_ContinueWith_Action_d_Task_Object_p__Object_CancellationToken.SetBelong(this.instance);
				}
				return r_ContinueWith_Action_d_Task_Object_p__Object_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task,System.Object], System.Object, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_ContinueWith_Action_d_Task_Object_p__Object_TaskScheduler;
		public virtual RMethod RContinueWith_Action_d_Task_Object_p__Object_TaskScheduler
		{
			get
			{
				if(r_ContinueWith_Action_d_Task_Object_p__Object_TaskScheduler == null)
				{
					r_ContinueWith_Action_d_Task_Object_p__Object_TaskScheduler = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object)), typeof(System.Object), typeof(System.Threading.Tasks.TaskScheduler));
					r_ContinueWith_Action_d_Task_Object_p__Object_TaskScheduler.SetBelong(this.instance);
				}
				return r_ContinueWith_Action_d_Task_Object_p__Object_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task,System.Object], System.Object, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_ContinueWith_Action_d_Task_Object_p__Object_TaskContinuationOptions;
		public virtual RMethod RContinueWith_Action_d_Task_Object_p__Object_TaskContinuationOptions
		{
			get
			{
				if(r_ContinueWith_Action_d_Task_Object_p__Object_TaskContinuationOptions == null)
				{
					r_ContinueWith_Action_d_Task_Object_p__Object_TaskContinuationOptions = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object)), typeof(System.Object), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_ContinueWith_Action_d_Task_Object_p__Object_TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_ContinueWith_Action_d_Task_Object_p__Object_TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task,System.Object], System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_ContinueWith_Action_d_Task_Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RContinueWith_Action_d_Task_Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_ContinueWith_Action_d_Task_Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_ContinueWith_Action_d_Task_Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object)), typeof(System.Object), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_ContinueWith_Action_d_Task_Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_ContinueWith_Action_d_Task_Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`2[System.Threading.Tasks.Task,TResult])
		/// </summary>
		protected RMethod r_ContinueWith_GTResult_Func_d_Task_TResult_p_;
		public virtual RMethod RContinueWith_GTResult_Func_d_Task_TResult_p_
		{
			get
			{
				if(r_ContinueWith_GTResult_Func_d_Task_TResult_p_ == null)
				{
					r_ContinueWith_GTResult_Func_d_Task_TResult_p_ = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)));
					r_ContinueWith_GTResult_Func_d_Task_TResult_p_.SetBelong(this.instance);
				}
				return r_ContinueWith_GTResult_Func_d_Task_TResult_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`2[System.Threading.Tasks.Task,TResult], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_ContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken;
		public virtual RMethod RContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken
		{
			get
			{
				if(r_ContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken == null)
				{
					r_ContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken));
					r_ContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken.SetBelong(this.instance);
				}
				return r_ContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`2[System.Threading.Tasks.Task,TResult], System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_ContinueWith_GTResult_Func_d_Task_TResult_p__TaskScheduler;
		public virtual RMethod RContinueWith_GTResult_Func_d_Task_TResult_p__TaskScheduler
		{
			get
			{
				if(r_ContinueWith_GTResult_Func_d_Task_TResult_p__TaskScheduler == null)
				{
					r_ContinueWith_GTResult_Func_d_Task_TResult_p__TaskScheduler = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskScheduler));
					r_ContinueWith_GTResult_Func_d_Task_TResult_p__TaskScheduler.SetBelong(this.instance);
				}
				return r_ContinueWith_GTResult_Func_d_Task_TResult_p__TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`2[System.Threading.Tasks.Task,TResult], System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_ContinueWith_GTResult_Func_d_Task_TResult_p__TaskContinuationOptions;
		public virtual RMethod RContinueWith_GTResult_Func_d_Task_TResult_p__TaskContinuationOptions
		{
			get
			{
				if(r_ContinueWith_GTResult_Func_d_Task_TResult_p__TaskContinuationOptions == null)
				{
					r_ContinueWith_GTResult_Func_d_Task_TResult_p__TaskContinuationOptions = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_ContinueWith_GTResult_Func_d_Task_TResult_p__TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_ContinueWith_GTResult_Func_d_Task_TResult_p__TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`2[System.Threading.Tasks.Task,TResult], System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_ContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_ContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_ContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_ContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_ContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`3[System.Threading.Tasks.Task,System.Object,TResult], System.Object)
		/// </summary>
		protected RMethod r_ContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object;
		public virtual RMethod RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object
		{
			get
			{
				if(r_ContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object == null)
				{
					r_ContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object));
					r_ContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object.SetBelong(this.instance);
				}
				return r_ContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`3[System.Threading.Tasks.Task,System.Object,TResult], System.Object, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_ContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken;
		public virtual RMethod RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken
		{
			get
			{
				if(r_ContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken == null)
				{
					r_ContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.CancellationToken));
					r_ContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken.SetBelong(this.instance);
				}
				return r_ContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`3[System.Threading.Tasks.Task,System.Object,TResult], System.Object, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_ContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskScheduler;
		public virtual RMethod RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskScheduler
		{
			get
			{
				if(r_ContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskScheduler == null)
				{
					r_ContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskScheduler = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.Tasks.TaskScheduler));
					r_ContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskScheduler.SetBelong(this.instance);
				}
				return r_ContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`3[System.Threading.Tasks.Task,System.Object,TResult], System.Object, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_ContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskContinuationOptions;
		public virtual RMethod RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskContinuationOptions
		{
			get
			{
				if(r_ContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskContinuationOptions == null)
				{
					r_ContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskContinuationOptions = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_ContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_ContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWith[TResult](System.Func`3[System.Threading.Tasks.Task,System.Object,TResult], System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_ContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_ContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_ContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_ContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_ContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// Void ContinueWithCore(System.Threading.Tasks.Task, System.Threading.Tasks.TaskScheduler, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_ContinueWithCore_Task_TaskScheduler_CancellationToken_TaskContinuationOptions;
		public virtual RMethod RContinueWithCore_Task_TaskScheduler_CancellationToken_TaskContinuationOptions
		{
			get
			{
				if(r_ContinueWithCore_Task_TaskScheduler_CancellationToken_TaskContinuationOptions == null)
				{
					r_ContinueWithCore_Task_TaskScheduler_CancellationToken_TaskContinuationOptions = new(this, "ContinueWithCore", 0, typeof(System.Threading.Tasks.Task), typeof(System.Threading.Tasks.TaskScheduler), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_ContinueWithCore_Task_TaskScheduler_CancellationToken_TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_ContinueWithCore_Task_TaskScheduler_CancellationToken_TaskContinuationOptions;
			}
		}

		/// <summary>
		/// Void AddCompletionAction(System.Threading.Tasks.ITaskCompletionAction)
		/// </summary>
		protected RMethod r_AddCompletionAction_ITaskCompletionAction;
		public virtual RMethod RAddCompletionAction_ITaskCompletionAction
		{
			get
			{
				if(r_AddCompletionAction_ITaskCompletionAction == null)
				{
					r_AddCompletionAction_ITaskCompletionAction = new(this, "AddCompletionAction", 0,  ReflectionUtils.GetType("System.Threading.Tasks.ITaskCompletionAction"));
					r_AddCompletionAction_ITaskCompletionAction.SetBelong(this.instance);
				}
				return r_AddCompletionAction_ITaskCompletionAction;
			}
		}

		/// <summary>
		/// Void RemoveContinuation(System.Object)
		/// </summary>
		protected RMethod r_RemoveContinuation_Object;
		public virtual RMethod RRemoveContinuation_Object
		{
			get
			{
				if(r_RemoveContinuation_Object == null)
				{
					r_RemoveContinuation_Object = new(this, "RemoveContinuation", 0, typeof(System.Object));
					r_RemoveContinuation_Object.SetBelong(this.instance);
				}
				return r_RemoveContinuation_Object;
			}
		}

		/// <summary>
		/// System.Delegate[] GetDelegateContinuationsForDebugger()
		/// </summary>
		protected RMethod r_GetDelegateContinuationsForDebugger;
		public virtual RMethod RGetDelegateContinuationsForDebugger
		{
			get
			{
				if(r_GetDelegateContinuationsForDebugger == null)
				{
					r_GetDelegateContinuationsForDebugger = new(this, "GetDelegateContinuationsForDebugger", 0);
					r_GetDelegateContinuationsForDebugger.SetBelong(this.instance);
				}
				return r_GetDelegateContinuationsForDebugger;
			}
		}

		/// <summary>
		/// Void MarkAborted(System.Threading.ThreadAbortException)
		/// </summary>
		protected RMethod r_MarkAborted_ThreadAbortException;
		public virtual RMethod RMarkAborted_ThreadAbortException
		{
			get
			{
				if(r_MarkAborted_ThreadAbortException == null)
				{
					r_MarkAborted_ThreadAbortException = new(this, "MarkAborted", 0, typeof(System.Threading.ThreadAbortException));
					r_MarkAborted_ThreadAbortException.SetBelong(this.instance);
				}
				return r_MarkAborted_ThreadAbortException;
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


        public RReadWriteTask() : base("System.IO.Stream+ReadWriteTask")
        {
        }

        public RReadWriteTask(System.Object instance) : base("System.IO.Stream+ReadWriteTask")
		{
            SetInstance(instance);
		}

        public RReadWriteTask(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RReadWriteTask(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void ClearBeginState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearBeginState.Invoke(___genericsType, ___parameters);

            
        }


        public static void InvokeAsyncCallback(System.Object  @completedTask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@completedTask};
            var ___result = RInvokeAsyncCallback_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Threading__2__Tasks__2__ITaskCompletionAction__2__Invoke(System.Threading.Tasks.Task  @completingTask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@completingTask};
            var ___result = RSystem__2__Threading__2__Tasks__2__ITaskCompletionAction__2__Invoke_Task.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TrySetResult(System.Int32  @result)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@result};
            var ___result = RTrySetResult_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void DangerousSetResult(System.Int32  @result)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@result};
            var ___result = RDangerousSetResult_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetResultCore(System.Boolean  @waitCompletionNotification)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitCompletionNotification};
            var ___result = RGetResultCore_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void InnerInvoke()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInnerInvoke.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Runtime.CompilerServices.TaskAwaiter<System.Int32> GetAwaiter()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAwaiter.Invoke(___genericsType, ___parameters);

            return (System.Runtime.CompilerServices.TaskAwaiter<System.Int32>)___result;
        }


        public virtual System.Runtime.CompilerServices.ConfiguredTaskAwaitable<System.Int32> ConfigureAwait(System.Boolean  @continueOnCapturedContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continueOnCapturedContext};
            var ___result = RConfigureAwait_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Runtime.CompilerServices.ConfiguredTaskAwaitable<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<System.Int32>>  @continuationAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction};
            var ___result = RContinueWith_Action_d_Task_d_Int32_p__p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<System.Int32>>  @continuationAction, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @cancellationToken};
            var ___result = RContinueWith_Action_d_Task_d_Int32_p__p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<System.Int32>>  @continuationAction, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @scheduler};
            var ___result = RContinueWith_Action_d_Task_d_Int32_p__p__TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<System.Int32>>  @continuationAction, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @continuationOptions};
            var ___result = RContinueWith_Action_d_Task_d_Int32_p__p__TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<System.Int32>>  @continuationAction, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RContinueWith_Action_d_Task_d_Int32_p__p__CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<System.Int32>>  @continuationAction, System.Threading.Tasks.TaskScheduler  @scheduler, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @scheduler, @cancellationToken, @continuationOptions};
            var ___result = RContinueWith_Action_d_Task_d_Int32_p__p__TaskScheduler_CancellationToken_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<System.Int32>, System.Object>  @continuationAction, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @state};
            var ___result = RContinueWith_Action_d_Task_d_Int32_p__Object_p__Object.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<System.Int32>, System.Object>  @continuationAction, System.Object  @state, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @state, @cancellationToken};
            var ___result = RContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<System.Int32>, System.Object>  @continuationAction, System.Object  @state, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @state, @scheduler};
            var ___result = RContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<System.Int32>, System.Object>  @continuationAction, System.Object  @state, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @state, @continuationOptions};
            var ___result = RContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<System.Int32>, System.Object>  @continuationAction, System.Object  @state, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @state, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<System.Int32>, System.Object>  @continuationAction, System.Object  @state, System.Threading.Tasks.TaskScheduler  @scheduler, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @state, @scheduler, @cancellationToken, @continuationOptions};
            var ___result = RContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<System.Int32>, TNewResult>  @continuationFunction)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction};
            var ___result = RContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<System.Int32>, TNewResult>  @continuationFunction, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction, @cancellationToken};
            var ___result = RContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<System.Int32>, TNewResult>  @continuationFunction, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction, @scheduler};
            var ___result = RContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<System.Int32>, TNewResult>  @continuationFunction, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction, @continuationOptions};
            var ___result = RContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<System.Int32>, TNewResult>  @continuationFunction, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<System.Int32>, TNewResult>  @continuationFunction, System.Threading.Tasks.TaskScheduler  @scheduler, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction, @scheduler, @cancellationToken, @continuationOptions};
            var ___result = RContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskScheduler_CancellationToken_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<System.Int32>, System.Object, TNewResult>  @continuationFunction, System.Object  @state)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction, @state};
            var ___result = RContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<System.Int32>, System.Object, TNewResult>  @continuationFunction, System.Object  @state, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction, @state, @cancellationToken};
            var ___result = RContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<System.Int32>, System.Object, TNewResult>  @continuationFunction, System.Object  @state, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction, @state, @scheduler};
            var ___result = RContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<System.Int32>, System.Object, TNewResult>  @continuationFunction, System.Object  @state, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction, @state, @continuationOptions};
            var ___result = RContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<System.Int32>, System.Object, TNewResult>  @continuationFunction, System.Object  @state, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction, @state, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<System.Int32>, System.Object, TNewResult>  @continuationFunction, System.Object  @state, System.Threading.Tasks.TaskScheduler  @scheduler, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction, @state, @scheduler, @cancellationToken, @continuationOptions};
            var ___result = RContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

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
}