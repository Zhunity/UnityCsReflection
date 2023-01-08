using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.CancellationTokenSource
	/// </summary>
    public partial class RCancellationTokenSource : RMember //
    {

		/// <summary>
		/// System.Threading.CancellationTokenSource s_canceledSource
		/// </summary>
		protected static RSystem.RThreading.RCancellationTokenSource r_s_canceledSource;
		public static RSystem.RThreading.RCancellationTokenSource Rs_canceledSource
		{
			get
			{
				if(r_s_canceledSource == null)
				{
					r_s_canceledSource = new(typeof(System.Threading.CancellationTokenSource), "s_canceledSource");
					r_s_canceledSource.SetBelong(null);
				}
				return r_s_canceledSource;
			}
		}

		/// <summary>
		/// System.Threading.CancellationTokenSource s_neverCanceledSource
		/// </summary>
		protected static RSystem.RThreading.RCancellationTokenSource r_s_neverCanceledSource;
		public static RSystem.RThreading.RCancellationTokenSource Rs_neverCanceledSource
		{
			get
			{
				if(r_s_neverCanceledSource == null)
				{
					r_s_neverCanceledSource = new(typeof(System.Threading.CancellationTokenSource), "s_neverCanceledSource");
					r_s_neverCanceledSource.SetBelong(null);
				}
				return r_s_neverCanceledSource;
			}
		}

		/// <summary>
		/// System.Int32 s_nLists
		/// </summary>
		protected static RField r_s_nLists;
		public static RField Rs_nLists
		{
			get
			{
				if(r_s_nLists == null)
				{
					r_s_nLists = new(typeof(System.Threading.CancellationTokenSource), "s_nLists");
					r_s_nLists.SetBelong(null);
				}
				return r_s_nLists;
			}
		}

		/// <summary>
		/// System.Threading.ManualResetEvent _kernelEvent
		/// </summary>
		protected RSystem.RThreading.RManualResetEvent r__kernelEvent;
		public virtual RSystem.RThreading.RManualResetEvent R_kernelEvent
		{
			get
			{
				if(r__kernelEvent == null)
				{
					r__kernelEvent = new(this, "_kernelEvent");
					r__kernelEvent.SetBelong(this.instance);
				}
				return r__kernelEvent;
			}
		}

		/// <summary>
		/// System.Threading.SparselyPopulatedArray`1[System.Threading.CancellationCallbackInfo][] _registeredCallbacksLists
		/// </summary>
		protected RFieldArray<RSystem.RThreading.RSparselyPopulatedArray<RSystem.RThreading.RCancellationCallbackInfo>> r__registeredCallbacksLists;
		public virtual RFieldArray<RSystem.RThreading.RSparselyPopulatedArray<RSystem.RThreading.RCancellationCallbackInfo>> R_registeredCallbacksLists
		{
			get
			{
				if(r__registeredCallbacksLists == null)
				{
					r__registeredCallbacksLists = new(this, "_registeredCallbacksLists");
					r__registeredCallbacksLists.SetBelong(this.instance);
				}
				return r__registeredCallbacksLists;
			}
		}

		/// <summary>
		/// System.Int32 CannotBeCanceled
		/// </summary>
		protected static RField r_CannotBeCanceled;
		public static RField RCannotBeCanceled
		{
			get
			{
				if(r_CannotBeCanceled == null)
				{
					r_CannotBeCanceled = new(typeof(System.Threading.CancellationTokenSource), "CannotBeCanceled");
					r_CannotBeCanceled.SetBelong(null);
				}
				return r_CannotBeCanceled;
			}
		}

		/// <summary>
		/// System.Int32 NotCanceledState
		/// </summary>
		protected static RField r_NotCanceledState;
		public static RField RNotCanceledState
		{
			get
			{
				if(r_NotCanceledState == null)
				{
					r_NotCanceledState = new(typeof(System.Threading.CancellationTokenSource), "NotCanceledState");
					r_NotCanceledState.SetBelong(null);
				}
				return r_NotCanceledState;
			}
		}

		/// <summary>
		/// System.Int32 NotifyingState
		/// </summary>
		protected static RField r_NotifyingState;
		public static RField RNotifyingState
		{
			get
			{
				if(r_NotifyingState == null)
				{
					r_NotifyingState = new(typeof(System.Threading.CancellationTokenSource), "NotifyingState");
					r_NotifyingState.SetBelong(null);
				}
				return r_NotifyingState;
			}
		}

		/// <summary>
		/// System.Int32 NotifyingCompleteState
		/// </summary>
		protected static RField r_NotifyingCompleteState;
		public static RField RNotifyingCompleteState
		{
			get
			{
				if(r_NotifyingCompleteState == null)
				{
					r_NotifyingCompleteState = new(typeof(System.Threading.CancellationTokenSource), "NotifyingCompleteState");
					r_NotifyingCompleteState.SetBelong(null);
				}
				return r_NotifyingCompleteState;
			}
		}

		/// <summary>
		/// System.Int32 _state
		/// </summary>
		protected RField r__state;
		public virtual RField R_state
		{
			get
			{
				if(r__state == null)
				{
					r__state = new(this, "_state");
					r__state.SetBelong(this.instance);
				}
				return r__state;
			}
		}

		/// <summary>
		/// System.Int32 _threadIDExecutingCallbacks
		/// </summary>
		protected RField r__threadIDExecutingCallbacks;
		public virtual RField R_threadIDExecutingCallbacks
		{
			get
			{
				if(r__threadIDExecutingCallbacks == null)
				{
					r__threadIDExecutingCallbacks = new(this, "_threadIDExecutingCallbacks");
					r__threadIDExecutingCallbacks.SetBelong(this.instance);
				}
				return r__threadIDExecutingCallbacks;
			}
		}

		/// <summary>
		/// System.Boolean _disposed
		/// </summary>
		protected RField r__disposed;
		public virtual RField R_disposed
		{
			get
			{
				if(r__disposed == null)
				{
					r__disposed = new(this, "_disposed");
					r__disposed.SetBelong(this.instance);
				}
				return r__disposed;
			}
		}

		/// <summary>
		/// System.Threading.CancellationCallbackInfo _executingCallback
		/// </summary>
		protected RSystem.RThreading.RCancellationCallbackInfo r__executingCallback;
		public virtual RSystem.RThreading.RCancellationCallbackInfo R_executingCallback
		{
			get
			{
				if(r__executingCallback == null)
				{
					r__executingCallback = new(this, "_executingCallback");
					r__executingCallback.SetBelong(this.instance);
				}
				return r__executingCallback;
			}
		}

		/// <summary>
		/// System.Threading.Timer _timer
		/// </summary>
		protected RSystem.RThreading.RTimer r__timer;
		public virtual RSystem.RThreading.RTimer R_timer
		{
			get
			{
				if(r__timer == null)
				{
					r__timer = new(this, "_timer");
					r__timer.SetBelong(this.instance);
				}
				return r__timer;
			}
		}

		/// <summary>
		/// System.Threading.TimerCallback s_timerCallback
		/// </summary>
		protected static RSystem.RThreading.RTimerCallback r_s_timerCallback;
		public static RSystem.RThreading.RTimerCallback Rs_timerCallback
		{
			get
			{
				if(r_s_timerCallback == null)
				{
					r_s_timerCallback = new(typeof(System.Threading.CancellationTokenSource), "s_timerCallback");
					r_s_timerCallback.SetBelong(null);
				}
				return r_s_timerCallback;
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
		/// Boolean IsCancellationCompleted
		/// </summary>
		protected RProperty r_IsCancellationCompleted;
		public virtual RProperty RIsCancellationCompleted
		{
			get
			{
				if(r_IsCancellationCompleted == null)
				{
					r_IsCancellationCompleted = new(this, "IsCancellationCompleted", -1);
					r_IsCancellationCompleted.SetBelong(this.instance);
				}
				return r_IsCancellationCompleted;
			}
		}

		/// <summary>
		/// Boolean IsDisposed
		/// </summary>
		protected RProperty r_IsDisposed;
		public virtual RProperty RIsDisposed
		{
			get
			{
				if(r_IsDisposed == null)
				{
					r_IsDisposed = new(this, "IsDisposed", -1);
					r_IsDisposed.SetBelong(this.instance);
				}
				return r_IsDisposed;
			}
		}

		/// <summary>
		/// Int32 ThreadIDExecutingCallbacks
		/// </summary>
		protected RProperty r_ThreadIDExecutingCallbacks;
		public virtual RProperty RThreadIDExecutingCallbacks
		{
			get
			{
				if(r_ThreadIDExecutingCallbacks == null)
				{
					r_ThreadIDExecutingCallbacks = new(this, "ThreadIDExecutingCallbacks", -1);
					r_ThreadIDExecutingCallbacks.SetBelong(this.instance);
				}
				return r_ThreadIDExecutingCallbacks;
			}
		}

		/// <summary>
		/// System.Threading.CancellationToken Token
		/// </summary>
		protected RSystem.RThreading.RCancellationToken r_Token;
		public virtual RSystem.RThreading.RCancellationToken RToken
		{
			get
			{
				if(r_Token == null)
				{
					r_Token = new(this, "Token", -1);
					r_Token.SetBelong(this.instance);
				}
				return r_Token;
			}
		}

		/// <summary>
		/// Boolean CanBeCanceled
		/// </summary>
		protected RProperty r_CanBeCanceled;
		public virtual RProperty RCanBeCanceled
		{
			get
			{
				if(r_CanBeCanceled == null)
				{
					r_CanBeCanceled = new(this, "CanBeCanceled", -1);
					r_CanBeCanceled.SetBelong(this.instance);
				}
				return r_CanBeCanceled;
			}
		}

		/// <summary>
		/// System.Threading.WaitHandle WaitHandle
		/// </summary>
		protected RSystem.RThreading.RWaitHandle r_WaitHandle;
		public virtual RSystem.RThreading.RWaitHandle RWaitHandle
		{
			get
			{
				if(r_WaitHandle == null)
				{
					r_WaitHandle = new(this, "WaitHandle", -1);
					r_WaitHandle.SetBelong(this.instance);
				}
				return r_WaitHandle;
			}
		}

		/// <summary>
		/// System.Threading.CancellationCallbackInfo ExecutingCallback
		/// </summary>
		protected RSystem.RThreading.RCancellationCallbackInfo r_ExecutingCallback;
		public virtual RSystem.RThreading.RCancellationCallbackInfo RExecutingCallback
		{
			get
			{
				if(r_ExecutingCallback == null)
				{
					r_ExecutingCallback = new(this, "ExecutingCallback", -1);
					r_ExecutingCallback.SetBelong(this.instance);
				}
				return r_ExecutingCallback;
			}
		}

		/// <summary>
		/// Void InitializeWithTimer(Int32)
		/// </summary>
		protected RMethod r_InitializeWithTimer_Int32;
		public virtual RMethod RInitializeWithTimer_Int32
		{
			get
			{
				if(r_InitializeWithTimer_Int32 == null)
				{
					r_InitializeWithTimer_Int32 = new(this, "InitializeWithTimer", 0, typeof(System.Int32));
					r_InitializeWithTimer_Int32.SetBelong(this.instance);
				}
				return r_InitializeWithTimer_Int32;
			}
		}

		/// <summary>
		/// Void Cancel()
		/// </summary>
		protected RMethod r_Cancel;
		public virtual RMethod RCancel
		{
			get
			{
				if(r_Cancel == null)
				{
					r_Cancel = new(this, "Cancel", 0);
					r_Cancel.SetBelong(this.instance);
				}
				return r_Cancel;
			}
		}

		/// <summary>
		/// Void Cancel(Boolean)
		/// </summary>
		protected RMethod r_Cancel_Boolean;
		public virtual RMethod RCancel_Boolean
		{
			get
			{
				if(r_Cancel_Boolean == null)
				{
					r_Cancel_Boolean = new(this, "Cancel", 0, typeof(System.Boolean));
					r_Cancel_Boolean.SetBelong(this.instance);
				}
				return r_Cancel_Boolean;
			}
		}

		/// <summary>
		/// Void CancelAfter(System.TimeSpan)
		/// </summary>
		protected RMethod r_CancelAfter_TimeSpan;
		public virtual RMethod RCancelAfter_TimeSpan
		{
			get
			{
				if(r_CancelAfter_TimeSpan == null)
				{
					r_CancelAfter_TimeSpan = new(this, "CancelAfter", 0, typeof(System.TimeSpan));
					r_CancelAfter_TimeSpan.SetBelong(this.instance);
				}
				return r_CancelAfter_TimeSpan;
			}
		}

		/// <summary>
		/// Void CancelAfter(Int32)
		/// </summary>
		protected RMethod r_CancelAfter_Int32;
		public virtual RMethod RCancelAfter_Int32
		{
			get
			{
				if(r_CancelAfter_Int32 == null)
				{
					r_CancelAfter_Int32 = new(this, "CancelAfter", 0, typeof(System.Int32));
					r_CancelAfter_Int32.SetBelong(this.instance);
				}
				return r_CancelAfter_Int32;
			}
		}

		/// <summary>
		/// Void TimerCallbackLogic(System.Object)
		/// </summary>
		protected static RMethod r_TimerCallbackLogic_Object;
		public static RMethod RTimerCallbackLogic_Object
		{
			get
			{
				if(r_TimerCallbackLogic_Object == null)
				{
					r_TimerCallbackLogic_Object = new(typeof(System.Threading.CancellationTokenSource), "TimerCallbackLogic", 0, typeof(System.Object));
					r_TimerCallbackLogic_Object.SetBelong(null);
				}
				return r_TimerCallbackLogic_Object;
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
		/// Void ThrowIfDisposed()
		/// </summary>
		protected RMethod r_ThrowIfDisposed;
		public virtual RMethod RThrowIfDisposed
		{
			get
			{
				if(r_ThrowIfDisposed == null)
				{
					r_ThrowIfDisposed = new(this, "ThrowIfDisposed", 0);
					r_ThrowIfDisposed.SetBelong(this.instance);
				}
				return r_ThrowIfDisposed;
			}
		}

		/// <summary>
		/// Void ThrowObjectDisposedException()
		/// </summary>
		protected static RMethod r_ThrowObjectDisposedException;
		public static RMethod RThrowObjectDisposedException
		{
			get
			{
				if(r_ThrowObjectDisposedException == null)
				{
					r_ThrowObjectDisposedException = new(typeof(System.Threading.CancellationTokenSource), "ThrowObjectDisposedException", 0);
					r_ThrowObjectDisposedException.SetBelong(null);
				}
				return r_ThrowObjectDisposedException;
			}
		}

		/// <summary>
		/// System.Threading.CancellationTokenRegistration InternalRegister(System.Action`1[System.Object], System.Object, System.Threading.SynchronizationContext, System.Threading.ExecutionContext)
		/// </summary>
		protected RMethod r_InternalRegister_Action_d_Object_p__Object_SynchronizationContext_ExecutionContext;
		public virtual RMethod RInternalRegister_Action_d_Object_p__Object_SynchronizationContext_ExecutionContext
		{
			get
			{
				if(r_InternalRegister_Action_d_Object_p__Object_SynchronizationContext_ExecutionContext == null)
				{
					r_InternalRegister_Action_d_Object_p__Object_SynchronizationContext_ExecutionContext = new(this, "InternalRegister", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Object)), typeof(System.Object), typeof(System.Threading.SynchronizationContext), typeof(System.Threading.ExecutionContext));
					r_InternalRegister_Action_d_Object_p__Object_SynchronizationContext_ExecutionContext.SetBelong(this.instance);
				}
				return r_InternalRegister_Action_d_Object_p__Object_SynchronizationContext_ExecutionContext;
			}
		}

		/// <summary>
		/// Void NotifyCancellation(Boolean)
		/// </summary>
		protected RMethod r_NotifyCancellation_Boolean;
		public virtual RMethod RNotifyCancellation_Boolean
		{
			get
			{
				if(r_NotifyCancellation_Boolean == null)
				{
					r_NotifyCancellation_Boolean = new(this, "NotifyCancellation", 0, typeof(System.Boolean));
					r_NotifyCancellation_Boolean.SetBelong(this.instance);
				}
				return r_NotifyCancellation_Boolean;
			}
		}

		/// <summary>
		/// Void ExecuteCallbackHandlers(Boolean)
		/// </summary>
		protected RMethod r_ExecuteCallbackHandlers_Boolean;
		public virtual RMethod RExecuteCallbackHandlers_Boolean
		{
			get
			{
				if(r_ExecuteCallbackHandlers_Boolean == null)
				{
					r_ExecuteCallbackHandlers_Boolean = new(this, "ExecuteCallbackHandlers", 0, typeof(System.Boolean));
					r_ExecuteCallbackHandlers_Boolean.SetBelong(this.instance);
				}
				return r_ExecuteCallbackHandlers_Boolean;
			}
		}

		/// <summary>
		/// Void CancellationCallbackCoreWork_OnSyncContext(System.Object)
		/// </summary>
		protected RMethod r_CancellationCallbackCoreWork_OnSyncContext_Object;
		public virtual RMethod RCancellationCallbackCoreWork_OnSyncContext_Object
		{
			get
			{
				if(r_CancellationCallbackCoreWork_OnSyncContext_Object == null)
				{
					r_CancellationCallbackCoreWork_OnSyncContext_Object = new(this, "CancellationCallbackCoreWork_OnSyncContext", 0, typeof(System.Object));
					r_CancellationCallbackCoreWork_OnSyncContext_Object.SetBelong(this.instance);
				}
				return r_CancellationCallbackCoreWork_OnSyncContext_Object;
			}
		}

		/// <summary>
		/// Void CancellationCallbackCoreWork(System.Threading.CancellationCallbackCoreWorkArguments)
		/// </summary>
		protected RMethod r_CancellationCallbackCoreWork_CancellationCallbackCoreWorkArguments;
		public virtual RMethod RCancellationCallbackCoreWork_CancellationCallbackCoreWorkArguments
		{
			get
			{
				if(r_CancellationCallbackCoreWork_CancellationCallbackCoreWorkArguments == null)
				{
					r_CancellationCallbackCoreWork_CancellationCallbackCoreWorkArguments = new(this, "CancellationCallbackCoreWork", 0,  ReflectionUtils.GetType("System.Threading.CancellationCallbackCoreWorkArguments"));
					r_CancellationCallbackCoreWork_CancellationCallbackCoreWorkArguments.SetBelong(this.instance);
				}
				return r_CancellationCallbackCoreWork_CancellationCallbackCoreWorkArguments;
			}
		}

		/// <summary>
		/// System.Threading.CancellationTokenSource CreateLinkedTokenSource(System.Threading.CancellationToken, System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_CreateLinkedTokenSource_CancellationToken_CancellationToken;
		public static RMethod RCreateLinkedTokenSource_CancellationToken_CancellationToken
		{
			get
			{
				if(r_CreateLinkedTokenSource_CancellationToken_CancellationToken == null)
				{
					r_CreateLinkedTokenSource_CancellationToken_CancellationToken = new(typeof(System.Threading.CancellationTokenSource), "CreateLinkedTokenSource", 0, typeof(System.Threading.CancellationToken), typeof(System.Threading.CancellationToken));
					r_CreateLinkedTokenSource_CancellationToken_CancellationToken.SetBelong(null);
				}
				return r_CreateLinkedTokenSource_CancellationToken_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.CancellationTokenSource CreateLinkedTokenSource(System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_CreateLinkedTokenSource_CancellationToken;
		public static RMethod RCreateLinkedTokenSource_CancellationToken
		{
			get
			{
				if(r_CreateLinkedTokenSource_CancellationToken == null)
				{
					r_CreateLinkedTokenSource_CancellationToken = new(typeof(System.Threading.CancellationTokenSource), "CreateLinkedTokenSource", 0, typeof(System.Threading.CancellationToken));
					r_CreateLinkedTokenSource_CancellationToken.SetBelong(null);
				}
				return r_CreateLinkedTokenSource_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.CancellationTokenSource CreateLinkedTokenSource(System.Threading.CancellationToken[])
		/// </summary>
		protected static RMethod r_CreateLinkedTokenSource_CancellationTokenArray;
		public static RMethod RCreateLinkedTokenSource_CancellationTokenArray
		{
			get
			{
				if(r_CreateLinkedTokenSource_CancellationTokenArray == null)
				{
					r_CreateLinkedTokenSource_CancellationTokenArray = new(typeof(System.Threading.CancellationTokenSource), "CreateLinkedTokenSource", 0, typeof(System.Threading.CancellationToken).MakeArrayType());
					r_CreateLinkedTokenSource_CancellationTokenArray.SetBelong(null);
				}
				return r_CreateLinkedTokenSource_CancellationTokenArray;
			}
		}

		/// <summary>
		/// Void WaitForCallbackToComplete(System.Threading.CancellationCallbackInfo)
		/// </summary>
		protected RMethod r_WaitForCallbackToComplete_CancellationCallbackInfo;
		public virtual RMethod RWaitForCallbackToComplete_CancellationCallbackInfo
		{
			get
			{
				if(r_WaitForCallbackToComplete_CancellationCallbackInfo == null)
				{
					r_WaitForCallbackToComplete_CancellationCallbackInfo = new(this, "WaitForCallbackToComplete", 0,  ReflectionUtils.GetType("System.Threading.CancellationCallbackInfo"));
					r_WaitForCallbackToComplete_CancellationCallbackInfo.SetBelong(this.instance);
				}
				return r_WaitForCallbackToComplete_CancellationCallbackInfo;
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


        public RCancellationTokenSource() : base("System.Threading.CancellationTokenSource")
        {
        }

        public RCancellationTokenSource(System.Object instance) : base("System.Threading.CancellationTokenSource")
		{
            SetInstance(instance);
		}

        public RCancellationTokenSource(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCancellationTokenSource(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void InitializeWithTimer(System.Int32 @millisecondsDelay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsDelay};
            var ___result = RInitializeWithTimer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Cancel()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCancel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Cancel(System.Boolean @throwOnFirstException)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@throwOnFirstException};
            var ___result = RCancel_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CancelAfter(System.TimeSpan @delay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delay};
            var ___result = RCancelAfter_TimeSpan.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CancelAfter(System.Int32 @millisecondsDelay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsDelay};
            var ___result = RCancelAfter_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void TimerCallbackLogic(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RTimerCallbackLogic_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ThrowIfDisposed()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RThrowIfDisposed.Invoke(___genericsType, ___parameters);

            
        }


        public static void ThrowObjectDisposedException()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RThrowObjectDisposedException.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Threading.CancellationTokenRegistration InternalRegister(System.Action<System.Object> @callback, System.Object @stateForCallback, System.Threading.SynchronizationContext @targetSyncContext, System.Threading.ExecutionContext @executionContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @stateForCallback, @targetSyncContext, @executionContext};
            var ___result = RInternalRegister_Action_d_Object_p__Object_SynchronizationContext_ExecutionContext.Invoke(___genericsType, ___parameters);

            return (System.Threading.CancellationTokenRegistration)___result;
        }


        public virtual void NotifyCancellation(System.Boolean @throwOnFirstException)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@throwOnFirstException};
            var ___result = RNotifyCancellation_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExecuteCallbackHandlers(System.Boolean @throwOnFirstException)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@throwOnFirstException};
            var ___result = RExecuteCallbackHandlers_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CancellationCallbackCoreWork_OnSyncContext(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RCancellationCallbackCoreWork_OnSyncContext_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CancellationCallbackCoreWork(RSystem.RThreading.RCancellationCallbackCoreWorkArguments @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args.Value};
            var ___result = RCancellationCallbackCoreWork_CancellationCallbackCoreWorkArguments.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Threading.CancellationTokenSource CreateLinkedTokenSource(System.Threading.CancellationToken @token1, System.Threading.CancellationToken @token2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@token1, @token2};
            var ___result = RCreateLinkedTokenSource_CancellationToken_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.CancellationTokenSource)___result;
        }


        public static System.Threading.CancellationTokenSource CreateLinkedTokenSource(System.Threading.CancellationToken @token)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@token};
            var ___result = RCreateLinkedTokenSource_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.CancellationTokenSource)___result;
        }


        public static System.Threading.CancellationTokenSource CreateLinkedTokenSource(System.Threading.CancellationToken[] @tokens)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tokens};
            var ___result = RCreateLinkedTokenSource_CancellationTokenArray.Invoke(___genericsType, ___parameters);

            return (System.Threading.CancellationTokenSource)___result;
        }


        public virtual void WaitForCallbackToComplete(RSystem.RThreading.RCancellationCallbackInfo @callbackInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callbackInfo.Value};
            var ___result = RWaitForCallbackToComplete_CancellationCallbackInfo.Invoke(___genericsType, ___parameters);

            
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
