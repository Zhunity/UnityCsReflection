
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.Threading.CancellationTokenSource
	/// </summary>
    public partial class RCancellationTokenSource : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Threading.CancellationTokenSource);
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


		/// <summary>
		/// System.Threading.CancellationTokenSource s_canceledSource
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RCancellationTokenSource r_Fs_canceledSource;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RCancellationTokenSource RFs_canceledSource
		{
			get
			{
				if(r_Fs_canceledSource == null)
				{
					r_Fs_canceledSource = new(Type, "s_canceledSource");
				}
				return r_Fs_canceledSource;
			}
		}

		/// <summary>
		/// System.Threading.CancellationTokenSource s_neverCanceledSource
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RCancellationTokenSource r_Fs_neverCanceledSource;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RCancellationTokenSource RFs_neverCanceledSource
		{
			get
			{
				if(r_Fs_neverCanceledSource == null)
				{
					r_Fs_neverCanceledSource = new(Type, "s_neverCanceledSource");
				}
				return r_Fs_neverCanceledSource;
			}
		}

		/// <summary>
		/// System.Int32 s_nLists
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fs_nLists;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFs_nLists
		{
			get
			{
				if(r_Fs_nLists == null)
				{
					r_Fs_nLists = new(Type, "s_nLists");
				}
				return r_Fs_nLists;
			}
		}

		/// <summary>
		/// System.Threading.ManualResetEvent _kernelEvent
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RManualResetEvent r_F_kernelEvent;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RManualResetEvent RF_kernelEvent
		{
			get
			{
				if(r_F_kernelEvent == null)
				{
					r_F_kernelEvent = new(this, "_kernelEvent");
				}
				return r_F_kernelEvent;
			}
		}

		/// <summary>
		/// System.Threading.SparselyPopulatedArray`1[System.Threading.CancellationCallbackInfo][] _registeredCallbacksLists
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RThreading.RSparselyPopulatedArray<Hvak.Editor.Refleaction.RSystem.RThreading.RCancellationCallbackInfo>> r_F_registeredCallbacksLists;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RThreading.RSparselyPopulatedArray<Hvak.Editor.Refleaction.RSystem.RThreading.RCancellationCallbackInfo>> RF_registeredCallbacksLists
		{
			get
			{
				if(r_F_registeredCallbacksLists == null)
				{
					r_F_registeredCallbacksLists = new(this, "_registeredCallbacksLists");
				}
				return r_F_registeredCallbacksLists;
			}
		}

		/// <summary>
		/// System.Int32 CannotBeCanceled
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCannotBeCanceled;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCannotBeCanceled
		{
			get
			{
				if(r_FCannotBeCanceled == null)
				{
					r_FCannotBeCanceled = new(Type, "CannotBeCanceled");
				}
				return r_FCannotBeCanceled;
			}
		}

		/// <summary>
		/// System.Int32 NotCanceledState
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FNotCanceledState;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFNotCanceledState
		{
			get
			{
				if(r_FNotCanceledState == null)
				{
					r_FNotCanceledState = new(Type, "NotCanceledState");
				}
				return r_FNotCanceledState;
			}
		}

		/// <summary>
		/// System.Int32 NotifyingState
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FNotifyingState;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFNotifyingState
		{
			get
			{
				if(r_FNotifyingState == null)
				{
					r_FNotifyingState = new(Type, "NotifyingState");
				}
				return r_FNotifyingState;
			}
		}

		/// <summary>
		/// System.Int32 NotifyingCompleteState
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FNotifyingCompleteState;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFNotifyingCompleteState
		{
			get
			{
				if(r_FNotifyingCompleteState == null)
				{
					r_FNotifyingCompleteState = new(Type, "NotifyingCompleteState");
				}
				return r_FNotifyingCompleteState;
			}
		}

		/// <summary>
		/// System.Int32 _state
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_state;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_state
		{
			get
			{
				if(r_F_state == null)
				{
					r_F_state = new(this, "_state");
				}
				return r_F_state;
			}
		}

		/// <summary>
		/// System.Int32 _threadIDExecutingCallbacks
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_threadIDExecutingCallbacks;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_threadIDExecutingCallbacks
		{
			get
			{
				if(r_F_threadIDExecutingCallbacks == null)
				{
					r_F_threadIDExecutingCallbacks = new(this, "_threadIDExecutingCallbacks");
				}
				return r_F_threadIDExecutingCallbacks;
			}
		}

		/// <summary>
		/// System.Boolean _disposed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F_disposed;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF_disposed
		{
			get
			{
				if(r_F_disposed == null)
				{
					r_F_disposed = new(this, "_disposed");
				}
				return r_F_disposed;
			}
		}

		/// <summary>
		/// System.Threading.CancellationCallbackInfo _executingCallback
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RCancellationCallbackInfo r_F_executingCallback;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RCancellationCallbackInfo RF_executingCallback
		{
			get
			{
				if(r_F_executingCallback == null)
				{
					r_F_executingCallback = new(this, "_executingCallback");
				}
				return r_F_executingCallback;
			}
		}

		/// <summary>
		/// System.Threading.Timer _timer
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RTimer r_F_timer;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RTimer RF_timer
		{
			get
			{
				if(r_F_timer == null)
				{
					r_F_timer = new(this, "_timer");
				}
				return r_F_timer;
			}
		}

		/// <summary>
		/// System.Threading.TimerCallback s_timerCallback
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RTimerCallback r_Fs_timerCallback;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RTimerCallback RFs_timerCallback
		{
			get
			{
				if(r_Fs_timerCallback == null)
				{
					r_Fs_timerCallback = new(Type, "s_timerCallback");
				}
				return r_Fs_timerCallback;
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
		/// Boolean IsCancellationCompleted
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsCancellationCompleted;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsCancellationCompleted
		{
			get
			{
				if(r_PIsCancellationCompleted == null)
				{
					r_PIsCancellationCompleted = new(this, "IsCancellationCompleted", -1);
				}
				return r_PIsCancellationCompleted;
			}
		}

		/// <summary>
		/// Boolean IsDisposed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsDisposed;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsDisposed
		{
			get
			{
				if(r_PIsDisposed == null)
				{
					r_PIsDisposed = new(this, "IsDisposed", -1);
				}
				return r_PIsDisposed;
			}
		}

		/// <summary>
		/// Int32 ThreadIDExecutingCallbacks
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PThreadIDExecutingCallbacks;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPThreadIDExecutingCallbacks
		{
			get
			{
				if(r_PThreadIDExecutingCallbacks == null)
				{
					r_PThreadIDExecutingCallbacks = new(this, "ThreadIDExecutingCallbacks", -1);
				}
				return r_PThreadIDExecutingCallbacks;
			}
		}

		/// <summary>
		/// System.Threading.CancellationToken Token
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RCancellationToken r_PToken;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RCancellationToken RPToken
		{
			get
			{
				if(r_PToken == null)
				{
					r_PToken = new(this, "Token", -1);
				}
				return r_PToken;
			}
		}

		/// <summary>
		/// Boolean CanBeCanceled
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PCanBeCanceled;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPCanBeCanceled
		{
			get
			{
				if(r_PCanBeCanceled == null)
				{
					r_PCanBeCanceled = new(this, "CanBeCanceled", -1);
				}
				return r_PCanBeCanceled;
			}
		}

		/// <summary>
		/// System.Threading.WaitHandle WaitHandle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RWaitHandle r_PWaitHandle;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RWaitHandle RPWaitHandle
		{
			get
			{
				if(r_PWaitHandle == null)
				{
					r_PWaitHandle = new(this, "WaitHandle", -1);
				}
				return r_PWaitHandle;
			}
		}

		/// <summary>
		/// System.Threading.CancellationCallbackInfo ExecutingCallback
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RCancellationCallbackInfo r_PExecutingCallback;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RCancellationCallbackInfo RPExecutingCallback
		{
			get
			{
				if(r_PExecutingCallback == null)
				{
					r_PExecutingCallback = new(this, "ExecutingCallback", -1);
				}
				return r_PExecutingCallback;
			}
		}

		/// <summary>
		/// Void InitializeWithTimer(Int32)
		/// </summary>
		protected RMethod r_MInitializeWithTimer_Int32;
		public virtual RMethod RMInitializeWithTimer_Int32
		{
			get
			{
				if(r_MInitializeWithTimer_Int32 == null)
				{
					r_MInitializeWithTimer_Int32 = new(this, "InitializeWithTimer", 0, typeof(System.Int32));
				}
				return r_MInitializeWithTimer_Int32;
			}
		}

		/// <summary>
		/// Void Cancel()
		/// </summary>
		protected RMethod r_MCancel;
		public virtual RMethod RMCancel
		{
			get
			{
				if(r_MCancel == null)
				{
					r_MCancel = new(this, "Cancel", 0);
				}
				return r_MCancel;
			}
		}

		/// <summary>
		/// Void Cancel(Boolean)
		/// </summary>
		protected RMethod r_MCancel_Boolean;
		public virtual RMethod RMCancel_Boolean
		{
			get
			{
				if(r_MCancel_Boolean == null)
				{
					r_MCancel_Boolean = new(this, "Cancel", 0, typeof(System.Boolean));
				}
				return r_MCancel_Boolean;
			}
		}

		/// <summary>
		/// Void CancelAfter(System.TimeSpan)
		/// </summary>
		protected RMethod r_MCancelAfter_TimeSpan;
		public virtual RMethod RMCancelAfter_TimeSpan
		{
			get
			{
				if(r_MCancelAfter_TimeSpan == null)
				{
					r_MCancelAfter_TimeSpan = new(this, "CancelAfter", 0, typeof(System.TimeSpan));
				}
				return r_MCancelAfter_TimeSpan;
			}
		}

		/// <summary>
		/// Void CancelAfter(Int32)
		/// </summary>
		protected RMethod r_MCancelAfter_Int32;
		public virtual RMethod RMCancelAfter_Int32
		{
			get
			{
				if(r_MCancelAfter_Int32 == null)
				{
					r_MCancelAfter_Int32 = new(this, "CancelAfter", 0, typeof(System.Int32));
				}
				return r_MCancelAfter_Int32;
			}
		}

		/// <summary>
		/// Void TimerCallbackLogic(System.Object)
		/// </summary>
		protected static RMethod r_MTimerCallbackLogic_Object;
		public static RMethod RMTimerCallbackLogic_Object
		{
			get
			{
				if(r_MTimerCallbackLogic_Object == null)
				{
					r_MTimerCallbackLogic_Object = new(Type, "TimerCallbackLogic", 0, typeof(System.Object));
				}
				return r_MTimerCallbackLogic_Object;
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
		/// Void ThrowIfDisposed()
		/// </summary>
		protected RMethod r_MThrowIfDisposed;
		public virtual RMethod RMThrowIfDisposed
		{
			get
			{
				if(r_MThrowIfDisposed == null)
				{
					r_MThrowIfDisposed = new(this, "ThrowIfDisposed", 0);
				}
				return r_MThrowIfDisposed;
			}
		}

		/// <summary>
		/// Void ThrowObjectDisposedException()
		/// </summary>
		protected static RMethod r_MThrowObjectDisposedException;
		public static RMethod RMThrowObjectDisposedException
		{
			get
			{
				if(r_MThrowObjectDisposedException == null)
				{
					r_MThrowObjectDisposedException = new(Type, "ThrowObjectDisposedException", 0);
				}
				return r_MThrowObjectDisposedException;
			}
		}

		/// <summary>
		/// System.Threading.CancellationTokenRegistration InternalRegister(System.Action`1[System.Object], System.Object, System.Threading.SynchronizationContext, System.Threading.ExecutionContext)
		/// </summary>
		protected RMethod r_MInternalRegister_Action_d_Object_p__Object_SynchronizationContext_ExecutionContext;
		public virtual RMethod RMInternalRegister_Action_d_Object_p__Object_SynchronizationContext_ExecutionContext
		{
			get
			{
				if(r_MInternalRegister_Action_d_Object_p__Object_SynchronizationContext_ExecutionContext == null)
				{
					r_MInternalRegister_Action_d_Object_p__Object_SynchronizationContext_ExecutionContext = new(this, "InternalRegister", 0,  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(System.Object)), typeof(System.Object), typeof(System.Threading.SynchronizationContext), typeof(System.Threading.ExecutionContext));
				}
				return r_MInternalRegister_Action_d_Object_p__Object_SynchronizationContext_ExecutionContext;
			}
		}

		/// <summary>
		/// Void NotifyCancellation(Boolean)
		/// </summary>
		protected RMethod r_MNotifyCancellation_Boolean;
		public virtual RMethod RMNotifyCancellation_Boolean
		{
			get
			{
				if(r_MNotifyCancellation_Boolean == null)
				{
					r_MNotifyCancellation_Boolean = new(this, "NotifyCancellation", 0, typeof(System.Boolean));
				}
				return r_MNotifyCancellation_Boolean;
			}
		}

		/// <summary>
		/// Void ExecuteCallbackHandlers(Boolean)
		/// </summary>
		protected RMethod r_MExecuteCallbackHandlers_Boolean;
		public virtual RMethod RMExecuteCallbackHandlers_Boolean
		{
			get
			{
				if(r_MExecuteCallbackHandlers_Boolean == null)
				{
					r_MExecuteCallbackHandlers_Boolean = new(this, "ExecuteCallbackHandlers", 0, typeof(System.Boolean));
				}
				return r_MExecuteCallbackHandlers_Boolean;
			}
		}

		/// <summary>
		/// Void CancellationCallbackCoreWork_OnSyncContext(System.Object)
		/// </summary>
		protected RMethod r_MCancellationCallbackCoreWork_OnSyncContext_Object;
		public virtual RMethod RMCancellationCallbackCoreWork_OnSyncContext_Object
		{
			get
			{
				if(r_MCancellationCallbackCoreWork_OnSyncContext_Object == null)
				{
					r_MCancellationCallbackCoreWork_OnSyncContext_Object = new(this, "CancellationCallbackCoreWork_OnSyncContext", 0, typeof(System.Object));
				}
				return r_MCancellationCallbackCoreWork_OnSyncContext_Object;
			}
		}

		/// <summary>
		/// Void CancellationCallbackCoreWork(System.Threading.CancellationCallbackCoreWorkArguments)
		/// </summary>
		protected RMethod r_MCancellationCallbackCoreWork_CancellationCallbackCoreWorkArguments;
		public virtual RMethod RMCancellationCallbackCoreWork_CancellationCallbackCoreWorkArguments
		{
			get
			{
				if(r_MCancellationCallbackCoreWork_CancellationCallbackCoreWorkArguments == null)
				{
					r_MCancellationCallbackCoreWork_CancellationCallbackCoreWorkArguments = new(this, "CancellationCallbackCoreWork", 0,  ReflectionUtils.GetType("System.Threading.CancellationCallbackCoreWorkArguments"));
				}
				return r_MCancellationCallbackCoreWork_CancellationCallbackCoreWorkArguments;
			}
		}

		/// <summary>
		/// System.Threading.CancellationTokenSource CreateLinkedTokenSource(System.Threading.CancellationToken, System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_MCreateLinkedTokenSource_CancellationToken_CancellationToken;
		public static RMethod RMCreateLinkedTokenSource_CancellationToken_CancellationToken
		{
			get
			{
				if(r_MCreateLinkedTokenSource_CancellationToken_CancellationToken == null)
				{
					r_MCreateLinkedTokenSource_CancellationToken_CancellationToken = new(Type, "CreateLinkedTokenSource", 0, typeof(System.Threading.CancellationToken), typeof(System.Threading.CancellationToken));
				}
				return r_MCreateLinkedTokenSource_CancellationToken_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.CancellationTokenSource CreateLinkedTokenSource(System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_MCreateLinkedTokenSource_CancellationToken;
		public static RMethod RMCreateLinkedTokenSource_CancellationToken
		{
			get
			{
				if(r_MCreateLinkedTokenSource_CancellationToken == null)
				{
					r_MCreateLinkedTokenSource_CancellationToken = new(Type, "CreateLinkedTokenSource", 0, typeof(System.Threading.CancellationToken));
				}
				return r_MCreateLinkedTokenSource_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.CancellationTokenSource CreateLinkedTokenSource(System.Threading.CancellationToken[])
		/// </summary>
		protected static RMethod r_MCreateLinkedTokenSource_CancellationTokenArray;
		public static RMethod RMCreateLinkedTokenSource_CancellationTokenArray
		{
			get
			{
				if(r_MCreateLinkedTokenSource_CancellationTokenArray == null)
				{
					r_MCreateLinkedTokenSource_CancellationTokenArray = new(Type, "CreateLinkedTokenSource", 0, typeof(System.Threading.CancellationToken).MakeArrayType());
				}
				return r_MCreateLinkedTokenSource_CancellationTokenArray;
			}
		}

		/// <summary>
		/// Void WaitForCallbackToComplete(System.Threading.CancellationCallbackInfo)
		/// </summary>
		protected RMethod r_MWaitForCallbackToComplete_CancellationCallbackInfo;
		public virtual RMethod RMWaitForCallbackToComplete_CancellationCallbackInfo
		{
			get
			{
				if(r_MWaitForCallbackToComplete_CancellationCallbackInfo == null)
				{
					r_MWaitForCallbackToComplete_CancellationCallbackInfo = new(this, "WaitForCallbackToComplete", 0,  ReflectionUtils.GetType("System.Threading.CancellationCallbackInfo"));
				}
				return r_MWaitForCallbackToComplete_CancellationCallbackInfo;
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


        public virtual void InitializeWithTimer(System.Int32 @millisecondsDelay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsDelay};
            var ___result = RMInitializeWithTimer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Cancel()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCancel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Cancel(System.Boolean @throwOnFirstException)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@throwOnFirstException};
            var ___result = RMCancel_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CancelAfter(System.TimeSpan @delay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delay};
            var ___result = RMCancelAfter_TimeSpan.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CancelAfter(System.Int32 @millisecondsDelay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsDelay};
            var ___result = RMCancelAfter_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void TimerCallbackLogic(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMTimerCallbackLogic_Object.Invoke(___genericsType, ___parameters);

            
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


        public virtual void ThrowIfDisposed()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMThrowIfDisposed.Invoke(___genericsType, ___parameters);

            
        }


        public static void ThrowObjectDisposedException()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMThrowObjectDisposedException.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Threading.CancellationTokenRegistration InternalRegister(System.Action<System.Object> @callback, System.Object @stateForCallback, System.Threading.SynchronizationContext @targetSyncContext, System.Threading.ExecutionContext @executionContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @stateForCallback, @targetSyncContext, @executionContext};
            var ___result = RMInternalRegister_Action_d_Object_p__Object_SynchronizationContext_ExecutionContext.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.CancellationTokenRegistration>(___result);
        }


        public virtual void NotifyCancellation(System.Boolean @throwOnFirstException)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@throwOnFirstException};
            var ___result = RMNotifyCancellation_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExecuteCallbackHandlers(System.Boolean @throwOnFirstException)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@throwOnFirstException};
            var ___result = RMExecuteCallbackHandlers_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CancellationCallbackCoreWork_OnSyncContext(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMCancellationCallbackCoreWork_OnSyncContext_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CancellationCallbackCoreWork(Hvak.Editor.Refleaction.RSystem.RThreading.RCancellationCallbackCoreWorkArguments @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args.Value};
            var ___result = RMCancellationCallbackCoreWork_CancellationCallbackCoreWorkArguments.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Threading.CancellationTokenSource CreateLinkedTokenSource(System.Threading.CancellationToken @token1, System.Threading.CancellationToken @token2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@token1, @token2};
            var ___result = RMCreateLinkedTokenSource_CancellationToken_CancellationToken.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.CancellationTokenSource>(___result);
        }


        public static System.Threading.CancellationTokenSource CreateLinkedTokenSource(System.Threading.CancellationToken @token)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@token};
            var ___result = RMCreateLinkedTokenSource_CancellationToken.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.CancellationTokenSource>(___result);
        }


        public static System.Threading.CancellationTokenSource CreateLinkedTokenSource(System.Threading.CancellationToken[] @tokens)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tokens};
            var ___result = RMCreateLinkedTokenSource_CancellationTokenArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.CancellationTokenSource>(___result);
        }


        public virtual void WaitForCallbackToComplete(Hvak.Editor.Refleaction.RSystem.RThreading.RCancellationCallbackInfo @callbackInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callbackInfo.Value};
            var ___result = RMWaitForCallbackToComplete_CancellationCallbackInfo.Invoke(___genericsType, ___parameters);

            
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
