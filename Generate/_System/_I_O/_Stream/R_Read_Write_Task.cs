
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RIO
{public partial class RStream
{
	
	/// <summary>
	/// System.IO.Stream+ReadWriteTask
	/// </summary>
    public partial class RReadWriteTask : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.IO.Stream+ReadWriteTask");
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


		/// <summary>
		/// System.Boolean _isRead
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F_isRead;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF_isRead
		{
			get
			{
				if(r_F_isRead == null)
				{
					r_F_isRead = new(this, "_isRead");
				}
				return r_F_isRead;
			}
		}

		/// <summary>
		/// System.Boolean _apm
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F_apm;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF_apm
		{
			get
			{
				if(r_F_apm == null)
				{
					r_F_apm = new(this, "_apm");
				}
				return r_F_apm;
			}
		}

		/// <summary>
		/// System.IO.Stream _stream
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIO.RStream r_F_stream;
		public virtual Hvak.Editor.Refleaction.RSystem.RIO.RStream RF_stream
		{
			get
			{
				if(r_F_stream == null)
				{
					r_F_stream = new(this, "_stream");
				}
				return r_F_stream;
			}
		}

		/// <summary>
		/// System.Byte[] _buffer
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> r_F_buffer;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> RF_buffer
		{
			get
			{
				if(r_F_buffer == null)
				{
					r_F_buffer = new(this, "_buffer");
				}
				return r_F_buffer;
			}
		}

		/// <summary>
		/// System.Int32 _offset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_offset;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_offset
		{
			get
			{
				if(r_F_offset == null)
				{
					r_F_offset = new(this, "_offset");
				}
				return r_F_offset;
			}
		}

		/// <summary>
		/// System.Int32 _count
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_count;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_count
		{
			get
			{
				if(r_F_count == null)
				{
					r_F_count = new(this, "_count");
				}
				return r_F_count;
			}
		}

		/// <summary>
		/// System.AsyncCallback _callback
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAsyncCallback r_F_callback;
		public virtual Hvak.Editor.Refleaction.RSystem.RAsyncCallback RF_callback
		{
			get
			{
				if(r_F_callback == null)
				{
					r_F_callback = new(this, "_callback");
				}
				return r_F_callback;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext _context
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RExecutionContext r_F_context;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RExecutionContext RF_context
		{
			get
			{
				if(r_F_context == null)
				{
					r_F_context = new(this, "_context");
				}
				return r_F_context;
			}
		}

		/// <summary>
		/// System.Threading.ContextCallback s_invokeAsyncCallback
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RContextCallback r_Fs_invokeAsyncCallback;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RContextCallback RFs_invokeAsyncCallback
		{
			get
			{
				if(r_Fs_invokeAsyncCallback == null)
				{
					r_Fs_invokeAsyncCallback = new( ReflectionUtils.GetType("System.IO.Stream+ReadWriteTask"), "s_invokeAsyncCallback");
				}
				return r_Fs_invokeAsyncCallback;
			}
		}

		/// <summary>
		/// System.Int32 m_result
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_result;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_result
		{
			get
			{
				if(r_Fm_result == null)
				{
					r_Fm_result = new(this, "m_result");
				}
				return r_Fm_result;
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
		/// Boolean System.Threading.Tasks.ITaskCompletionAction.InvokeMayRunArbitraryCode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PSystem__2__Threading__2__Tasks__2__ITaskCompletionAction__2__InvokeMayRunArbitraryCode;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPSystem__2__Threading__2__Tasks__2__ITaskCompletionAction__2__InvokeMayRunArbitraryCode
		{
			get
			{
				if(r_PSystem__2__Threading__2__Tasks__2__ITaskCompletionAction__2__InvokeMayRunArbitraryCode == null)
				{
					r_PSystem__2__Threading__2__Tasks__2__ITaskCompletionAction__2__InvokeMayRunArbitraryCode = new(this, "System.Threading.Tasks.ITaskCompletionAction.InvokeMayRunArbitraryCode", -1);
				}
				return r_PSystem__2__Threading__2__Tasks__2__ITaskCompletionAction__2__InvokeMayRunArbitraryCode;
			}
		}

		/// <summary>
		/// Int32 Result
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PResult;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPResult
		{
			get
			{
				if(r_PResult == null)
				{
					r_PResult = new(this, "Result", -1);
				}
				return r_PResult;
			}
		}

		/// <summary>
		/// Int32 ResultOnSuccess
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PResultOnSuccess;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPResultOnSuccess
		{
			get
			{
				if(r_PResultOnSuccess == null)
				{
					r_PResultOnSuccess = new(this, "ResultOnSuccess", -1);
				}
				return r_PResultOnSuccess;
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
		/// Void ClearBeginState()
		/// </summary>
		protected RMethod r_MClearBeginState;
		public virtual RMethod RMClearBeginState
		{
			get
			{
				if(r_MClearBeginState == null)
				{
					r_MClearBeginState = new(this, "ClearBeginState", 0);
				}
				return r_MClearBeginState;
			}
		}

		/// <summary>
		/// Void InvokeAsyncCallback(System.Object)
		/// </summary>
		protected static RMethod r_MInvokeAsyncCallback_Object;
		public static RMethod RMInvokeAsyncCallback_Object
		{
			get
			{
				if(r_MInvokeAsyncCallback_Object == null)
				{
					r_MInvokeAsyncCallback_Object = new( ReflectionUtils.GetType("System.IO.Stream+ReadWriteTask"), "InvokeAsyncCallback", 0, typeof(System.Object));
				}
				return r_MInvokeAsyncCallback_Object;
			}
		}

		/// <summary>
		/// Void System.Threading.Tasks.ITaskCompletionAction.Invoke(System.Threading.Tasks.Task)
		/// </summary>
		protected RMethod r_MSystem__2__Threading__2__Tasks__2__ITaskCompletionAction__2__Invoke_Task;
		public virtual RMethod RMSystem__2__Threading__2__Tasks__2__ITaskCompletionAction__2__Invoke_Task
		{
			get
			{
				if(r_MSystem__2__Threading__2__Tasks__2__ITaskCompletionAction__2__Invoke_Task == null)
				{
					r_MSystem__2__Threading__2__Tasks__2__ITaskCompletionAction__2__Invoke_Task = new(this, "System.Threading.Tasks.ITaskCompletionAction.Invoke", 0, typeof(System.Threading.Tasks.Task));
				}
				return r_MSystem__2__Threading__2__Tasks__2__ITaskCompletionAction__2__Invoke_Task;
			}
		}

		/// <summary>
		/// Boolean TrySetResult(Int32)
		/// </summary>
		protected RMethod r_MTrySetResult_Int32;
		public virtual RMethod RMTrySetResult_Int32
		{
			get
			{
				if(r_MTrySetResult_Int32 == null)
				{
					r_MTrySetResult_Int32 = new(this, "TrySetResult", 0, typeof(System.Int32));
				}
				return r_MTrySetResult_Int32;
			}
		}

		/// <summary>
		/// Void DangerousSetResult(Int32)
		/// </summary>
		protected RMethod r_MDangerousSetResult_Int32;
		public virtual RMethod RMDangerousSetResult_Int32
		{
			get
			{
				if(r_MDangerousSetResult_Int32 == null)
				{
					r_MDangerousSetResult_Int32 = new(this, "DangerousSetResult", 0, typeof(System.Int32));
				}
				return r_MDangerousSetResult_Int32;
			}
		}

		/// <summary>
		/// Int32 GetResultCore(Boolean)
		/// </summary>
		protected RMethod r_MGetResultCore_Boolean;
		public virtual RMethod RMGetResultCore_Boolean
		{
			get
			{
				if(r_MGetResultCore_Boolean == null)
				{
					r_MGetResultCore_Boolean = new(this, "GetResultCore", 0, typeof(System.Boolean));
				}
				return r_MGetResultCore_Boolean;
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
		/// System.Runtime.CompilerServices.TaskAwaiter`1[System.Int32] GetAwaiter()
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
		/// System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1[System.Int32] ConfigureAwait(Boolean)
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
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task`1[System.Int32]])
		/// </summary>
		protected RMethod r_MContinueWith_Action_d_Task_d_Int32_p__p_;
		public virtual RMethod RMContinueWith_Action_d_Task_d_Int32_p__p_
		{
			get
			{
				if(r_MContinueWith_Action_d_Task_d_Int32_p__p_ == null)
				{
					r_MContinueWith_Action_d_Task_d_Int32_p__p_ = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32))));
				}
				return r_MContinueWith_Action_d_Task_d_Int32_p__p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task`1[System.Int32]], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MContinueWith_Action_d_Task_d_Int32_p__p__CancellationToken;
		public virtual RMethod RMContinueWith_Action_d_Task_d_Int32_p__p__CancellationToken
		{
			get
			{
				if(r_MContinueWith_Action_d_Task_d_Int32_p__p__CancellationToken == null)
				{
					r_MContinueWith_Action_d_Task_d_Int32_p__p__CancellationToken = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32))), typeof(System.Threading.CancellationToken));
				}
				return r_MContinueWith_Action_d_Task_d_Int32_p__p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task`1[System.Int32]], System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_MContinueWith_Action_d_Task_d_Int32_p__p__TaskScheduler;
		public virtual RMethod RMContinueWith_Action_d_Task_d_Int32_p__p__TaskScheduler
		{
			get
			{
				if(r_MContinueWith_Action_d_Task_d_Int32_p__p__TaskScheduler == null)
				{
					r_MContinueWith_Action_d_Task_d_Int32_p__p__TaskScheduler = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32))), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MContinueWith_Action_d_Task_d_Int32_p__p__TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task`1[System.Int32]], System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_MContinueWith_Action_d_Task_d_Int32_p__p__TaskContinuationOptions;
		public virtual RMethod RMContinueWith_Action_d_Task_d_Int32_p__p__TaskContinuationOptions
		{
			get
			{
				if(r_MContinueWith_Action_d_Task_d_Int32_p__p__TaskContinuationOptions == null)
				{
					r_MContinueWith_Action_d_Task_d_Int32_p__p__TaskContinuationOptions = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32))), typeof(System.Threading.Tasks.TaskContinuationOptions));
				}
				return r_MContinueWith_Action_d_Task_d_Int32_p__p__TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task`1[System.Int32]], System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_MContinueWith_Action_d_Task_d_Int32_p__p__CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RMContinueWith_Action_d_Task_d_Int32_p__p__CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_MContinueWith_Action_d_Task_d_Int32_p__p__CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_MContinueWith_Action_d_Task_d_Int32_p__p__CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32))), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MContinueWith_Action_d_Task_d_Int32_p__p__CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task`1[System.Int32]], System.Threading.Tasks.TaskScheduler, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_MContinueWith_Action_d_Task_d_Int32_p__p__TaskScheduler_CancellationToken_TaskContinuationOptions;
		public virtual RMethod RMContinueWith_Action_d_Task_d_Int32_p__p__TaskScheduler_CancellationToken_TaskContinuationOptions
		{
			get
			{
				if(r_MContinueWith_Action_d_Task_d_Int32_p__p__TaskScheduler_CancellationToken_TaskContinuationOptions == null)
				{
					r_MContinueWith_Action_d_Task_d_Int32_p__p__TaskScheduler_CancellationToken_TaskContinuationOptions = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32))), typeof(System.Threading.Tasks.TaskScheduler), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions));
				}
				return r_MContinueWith_Action_d_Task_d_Int32_p__p__TaskScheduler_CancellationToken_TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task`1[System.Int32],System.Object], System.Object)
		/// </summary>
		protected RMethod r_MContinueWith_Action_d_Task_d_Int32_p__Object_p__Object;
		public virtual RMethod RMContinueWith_Action_d_Task_d_Int32_p__Object_p__Object
		{
			get
			{
				if(r_MContinueWith_Action_d_Task_d_Int32_p__Object_p__Object == null)
				{
					r_MContinueWith_Action_d_Task_d_Int32_p__Object_p__Object = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), typeof(System.Object)), typeof(System.Object));
				}
				return r_MContinueWith_Action_d_Task_d_Int32_p__Object_p__Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task`1[System.Int32],System.Object], System.Object, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_CancellationToken;
		public virtual RMethod RMContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_CancellationToken
		{
			get
			{
				if(r_MContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_CancellationToken == null)
				{
					r_MContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_CancellationToken = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), typeof(System.Object)), typeof(System.Object), typeof(System.Threading.CancellationToken));
				}
				return r_MContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task`1[System.Int32],System.Object], System.Object, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_MContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskScheduler;
		public virtual RMethod RMContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskScheduler
		{
			get
			{
				if(r_MContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskScheduler == null)
				{
					r_MContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskScheduler = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), typeof(System.Object)), typeof(System.Object), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task`1[System.Int32],System.Object], System.Object, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_MContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskContinuationOptions;
		public virtual RMethod RMContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskContinuationOptions
		{
			get
			{
				if(r_MContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskContinuationOptions == null)
				{
					r_MContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskContinuationOptions = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), typeof(System.Object)), typeof(System.Object), typeof(System.Threading.Tasks.TaskContinuationOptions));
				}
				return r_MContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task`1[System.Int32],System.Object], System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_MContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RMContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_MContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_MContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), typeof(System.Object)), typeof(System.Object), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWith(System.Action`2[System.Threading.Tasks.Task`1[System.Int32],System.Object], System.Object, System.Threading.Tasks.TaskScheduler, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_MContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions;
		public virtual RMethod RMContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions
		{
			get
			{
				if(r_MContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions == null)
				{
					r_MContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), typeof(System.Object)), typeof(System.Object), typeof(System.Threading.Tasks.TaskScheduler), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions));
				}
				return r_MContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`2[System.Threading.Tasks.Task`1[System.Int32],TNewResult])
		/// </summary>
		protected RMethod r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p_;
		public virtual RMethod RMContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p_
		{
			get
			{
				if(r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p_ == null)
				{
					r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p_ = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), Type.MakeGenericMethodParameter(0)));
				}
				return r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`2[System.Threading.Tasks.Task`1[System.Int32],TNewResult], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__CancellationToken;
		public virtual RMethod RMContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__CancellationToken
		{
			get
			{
				if(r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__CancellationToken == null)
				{
					r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__CancellationToken = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken));
				}
				return r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`2[System.Threading.Tasks.Task`1[System.Int32],TNewResult], System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskScheduler;
		public virtual RMethod RMContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskScheduler
		{
			get
			{
				if(r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskScheduler == null)
				{
					r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskScheduler = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`2[System.Threading.Tasks.Task`1[System.Int32],TNewResult], System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskContinuationOptions;
		public virtual RMethod RMContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskContinuationOptions
		{
			get
			{
				if(r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskContinuationOptions == null)
				{
					r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskContinuationOptions = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskContinuationOptions));
				}
				return r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`2[System.Threading.Tasks.Task`1[System.Int32],TNewResult], System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RMContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`2[System.Threading.Tasks.Task`1[System.Int32],TNewResult], System.Threading.Tasks.TaskScheduler, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskScheduler_CancellationToken_TaskContinuationOptions;
		public virtual RMethod RMContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskScheduler_CancellationToken_TaskContinuationOptions
		{
			get
			{
				if(r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskScheduler_CancellationToken_TaskContinuationOptions == null)
				{
					r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskScheduler_CancellationToken_TaskContinuationOptions = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskScheduler), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions));
				}
				return r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskScheduler_CancellationToken_TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`3[System.Threading.Tasks.Task`1[System.Int32],System.Object,TNewResult], System.Object)
		/// </summary>
		protected RMethod r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object;
		public virtual RMethod RMContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object
		{
			get
			{
				if(r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object == null)
				{
					r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object));
				}
				return r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`3[System.Threading.Tasks.Task`1[System.Int32],System.Object,TNewResult], System.Object, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_CancellationToken;
		public virtual RMethod RMContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_CancellationToken
		{
			get
			{
				if(r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_CancellationToken == null)
				{
					r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_CancellationToken = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.CancellationToken));
				}
				return r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`3[System.Threading.Tasks.Task`1[System.Int32],System.Object,TNewResult], System.Object, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskScheduler;
		public virtual RMethod RMContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskScheduler
		{
			get
			{
				if(r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskScheduler == null)
				{
					r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskScheduler = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`3[System.Threading.Tasks.Task`1[System.Int32],System.Object,TNewResult], System.Object, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskContinuationOptions;
		public virtual RMethod RMContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskContinuationOptions
		{
			get
			{
				if(r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskContinuationOptions == null)
				{
					r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskContinuationOptions = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.Tasks.TaskContinuationOptions));
				}
				return r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`3[System.Threading.Tasks.Task`1[System.Int32],System.Object,TNewResult], System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RMContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TNewResult] ContinueWith[TNewResult](System.Func`3[System.Threading.Tasks.Task`1[System.Int32],System.Object,TNewResult], System.Object, System.Threading.Tasks.TaskScheduler, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions;
		public virtual RMethod RMContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions
		{
			get
			{
				if(r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions == null)
				{
					r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.Tasks.TaskScheduler), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions));
				}
				return r_MContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions;
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
		/// System.Threading.Tasks.Task ContinueWith(System.Action`1[System.Threading.Tasks.Task])
		/// </summary>
		protected RMethod r_MContinueWith_Action_d_Task_p_;
		public virtual RMethod RMContinueWith_Action_d_Task_p_
		{
			get
			{
				if(r_MContinueWith_Action_d_Task_p_ == null)
				{
					r_MContinueWith_Action_d_Task_p_ = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task)));
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
					r_MContinueWith_Action_d_Task_p__CancellationToken = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task)), typeof(System.Threading.CancellationToken));
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
					r_MContinueWith_Action_d_Task_p__TaskScheduler = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task)), typeof(System.Threading.Tasks.TaskScheduler));
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
					r_MContinueWith_Action_d_Task_p__TaskContinuationOptions = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task)), typeof(System.Threading.Tasks.TaskContinuationOptions));
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
					r_MContinueWith_Action_d_Task_p__CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWith", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task)), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MContinueWith_Action_d_Task_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
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
					r_MContinueWith_Action_d_Task_Object_p__Object = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object)), typeof(System.Object));
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
					r_MContinueWith_Action_d_Task_Object_p__Object_CancellationToken = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object)), typeof(System.Object), typeof(System.Threading.CancellationToken));
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
					r_MContinueWith_Action_d_Task_Object_p__Object_TaskScheduler = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object)), typeof(System.Object), typeof(System.Threading.Tasks.TaskScheduler));
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
					r_MContinueWith_Action_d_Task_Object_p__Object_TaskContinuationOptions = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object)), typeof(System.Object), typeof(System.Threading.Tasks.TaskContinuationOptions));
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
					r_MContinueWith_Action_d_Task_Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWith", 0, typeof(System.Action<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object)), typeof(System.Object), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MContinueWith_Action_d_Task_Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler;
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
					r_MContinueWith_GTResult_Func_d_Task_TResult_p_ = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)));
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
					r_MContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken));
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
					r_MContinueWith_GTResult_Func_d_Task_TResult_p__TaskScheduler = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskScheduler));
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
					r_MContinueWith_GTResult_Func_d_Task_TResult_p__TaskContinuationOptions = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskContinuationOptions));
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
					r_MContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWith", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MContinueWith_GTResult_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
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
					r_MContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object));
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
					r_MContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.CancellationToken));
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
					r_MContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskScheduler = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.Tasks.TaskScheduler));
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
					r_MContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_TaskContinuationOptions = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.Tasks.TaskContinuationOptions));
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
					r_MContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWith", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.Threading.Tasks.Task), typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MContinueWith_GTResult_Func_d_Task_Object_TResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler;
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


        public virtual void ClearBeginState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearBeginState.Invoke(___genericsType, ___parameters);

            
        }


        public static void InvokeAsyncCallback(System.Object @completedTask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@completedTask};
            var ___result = RMInvokeAsyncCallback_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Threading__2__Tasks__2__ITaskCompletionAction__2__Invoke(System.Threading.Tasks.Task @completingTask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@completingTask};
            var ___result = RMSystem__2__Threading__2__Tasks__2__ITaskCompletionAction__2__Invoke_Task.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TrySetResult(System.Int32 @result)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@result};
            var ___result = RMTrySetResult_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void DangerousSetResult(System.Int32 @result)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@result};
            var ___result = RMDangerousSetResult_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetResultCore(System.Boolean @waitCompletionNotification)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitCompletionNotification};
            var ___result = RMGetResultCore_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void InnerInvoke()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInnerInvoke.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Runtime.CompilerServices.TaskAwaiter<System.Int32> GetAwaiter()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetAwaiter.Invoke(___genericsType, ___parameters);

            return (System.Runtime.CompilerServices.TaskAwaiter<System.Int32>)___result;
        }


        public virtual System.Runtime.CompilerServices.ConfiguredTaskAwaitable<System.Int32> ConfigureAwait(System.Boolean @continueOnCapturedContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continueOnCapturedContext};
            var ___result = RMConfigureAwait_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Runtime.CompilerServices.ConfiguredTaskAwaitable<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<System.Int32>> @continuationAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction};
            var ___result = RMContinueWith_Action_d_Task_d_Int32_p__p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<System.Int32>> @continuationAction, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @cancellationToken};
            var ___result = RMContinueWith_Action_d_Task_d_Int32_p__p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<System.Int32>> @continuationAction, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @scheduler};
            var ___result = RMContinueWith_Action_d_Task_d_Int32_p__p__TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<System.Int32>> @continuationAction, System.Threading.Tasks.TaskContinuationOptions @continuationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @continuationOptions};
            var ___result = RMContinueWith_Action_d_Task_d_Int32_p__p__TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<System.Int32>> @continuationAction, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskContinuationOptions @continuationOptions, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RMContinueWith_Action_d_Task_d_Int32_p__p__CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<System.Int32>> @continuationAction, System.Threading.Tasks.TaskScheduler @scheduler, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskContinuationOptions @continuationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @scheduler, @cancellationToken, @continuationOptions};
            var ___result = RMContinueWith_Action_d_Task_d_Int32_p__p__TaskScheduler_CancellationToken_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<System.Int32>, System.Object> @continuationAction, System.Object @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @state};
            var ___result = RMContinueWith_Action_d_Task_d_Int32_p__Object_p__Object.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<System.Int32>, System.Object> @continuationAction, System.Object @state, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @state, @cancellationToken};
            var ___result = RMContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<System.Int32>, System.Object> @continuationAction, System.Object @state, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @state, @scheduler};
            var ___result = RMContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<System.Int32>, System.Object> @continuationAction, System.Object @state, System.Threading.Tasks.TaskContinuationOptions @continuationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @state, @continuationOptions};
            var ___result = RMContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<System.Int32>, System.Object> @continuationAction, System.Object @state, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskContinuationOptions @continuationOptions, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @state, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RMContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<System.Int32>, System.Object> @continuationAction, System.Object @state, System.Threading.Tasks.TaskScheduler @scheduler, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskContinuationOptions @continuationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @state, @scheduler, @cancellationToken, @continuationOptions};
            var ___result = RMContinueWith_Action_d_Task_d_Int32_p__Object_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<System.Int32>, TNewResult> @continuationFunction)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction};
            var ___result = RMContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<System.Int32>, TNewResult> @continuationFunction, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction, @cancellationToken};
            var ___result = RMContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<System.Int32>, TNewResult> @continuationFunction, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction, @scheduler};
            var ___result = RMContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<System.Int32>, TNewResult> @continuationFunction, System.Threading.Tasks.TaskContinuationOptions @continuationOptions)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction, @continuationOptions};
            var ___result = RMContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<System.Int32>, TNewResult> @continuationFunction, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskContinuationOptions @continuationOptions, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RMContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<System.Int32>, TNewResult> @continuationFunction, System.Threading.Tasks.TaskScheduler @scheduler, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskContinuationOptions @continuationOptions)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction, @scheduler, @cancellationToken, @continuationOptions};
            var ___result = RMContinueWith_GTNewResult_Func_d_Task_d_Int32_p__TNewResult_p__TaskScheduler_CancellationToken_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<System.Int32>, System.Object, TNewResult> @continuationFunction, System.Object @state)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction, @state};
            var ___result = RMContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<System.Int32>, System.Object, TNewResult> @continuationFunction, System.Object @state, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction, @state, @cancellationToken};
            var ___result = RMContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<System.Int32>, System.Object, TNewResult> @continuationFunction, System.Object @state, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction, @state, @scheduler};
            var ___result = RMContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<System.Int32>, System.Object, TNewResult> @continuationFunction, System.Object @state, System.Threading.Tasks.TaskContinuationOptions @continuationOptions)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction, @state, @continuationOptions};
            var ___result = RMContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<System.Int32>, System.Object, TNewResult> @continuationFunction, System.Object @state, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskContinuationOptions @continuationOptions, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction, @state, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RMContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<System.Int32>, System.Object, TNewResult> @continuationFunction, System.Object @state, System.Threading.Tasks.TaskScheduler @scheduler, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskContinuationOptions @continuationOptions)
        {

            var ___genericsType = new Type[] {typeof(TNewResult)};
            var ___parameters = new object[]{@continuationFunction, @state, @scheduler, @cancellationToken, @continuationOptions};
            var ___result = RMContinueWith_GTNewResult_Func_d_Task_d_Int32_p__Object_TNewResult_p__Object_TaskScheduler_CancellationToken_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TNewResult>)___result;
        }


        public virtual void TaskConstructorCore(System.Delegate @action, System.Object @state, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskCreationOptions @creationOptions, Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RInternalTaskOptions @internalOptions, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action, @state, @cancellationToken, @creationOptions, @internalOptions.Value, @scheduler};
            var ___result = RMTaskConstructorCore_Delegate_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            
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


        public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask.RContingentProperties EnsureContingentPropertiesInitialized(System.Boolean @needsProtection)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@needsProtection};
            var ___result = RMEnsureContingentPropertiesInitialized_Boolean.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask.RContingentProperties(___result);
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


        public virtual System.Boolean ExecuteEntry(System.Boolean @bPreventDoubleExecution)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bPreventDoubleExecution};
            var ___result = RMExecuteEntry_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetContinuationForAwait(System.Action @continuationAction, System.Boolean @continueOnCapturedContext, System.Boolean @flowExecutionContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationAction, @continueOnCapturedContext, @flowExecutionContext};
            var ___result = RMSetContinuationForAwait_Action_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Boolean InternalWait(System.Int32 @millisecondsTimeout, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout, @cancellationToken};
            var ___result = RMInternalWait_Int32_CancellationToken.Invoke(___genericsType, ___parameters);

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


        public virtual void FinishContinuations()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinishContinuations.Invoke(___genericsType, ___parameters);

            
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


        public virtual void RemoveContinuation(System.Object @continuationObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationObject};
            var ___result = RMRemoveContinuation_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Delegate[] GetDelegateContinuationsForDebugger()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDelegateContinuationsForDebugger.Invoke(___genericsType, ___parameters);

            return (System.Delegate[])___result;
        }


        public virtual void MarkAborted(System.Threading.ThreadAbortException @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMMarkAborted_ThreadAbortException.Invoke(___genericsType, ___parameters);

            
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
}