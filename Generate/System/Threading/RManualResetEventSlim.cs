using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.ManualResetEventSlim
	/// </summary>
    public partial class RManualResetEventSlim : RMember //
    {

		/// <summary>
		/// System.Int32 DEFAULT_SPIN_SP
		/// </summary>
		protected static RSystem.RInt32 r_DEFAULT_SPIN_SP;
		public static RSystem.RInt32 RDEFAULT_SPIN_SP
		{
			get
			{
				if(r_DEFAULT_SPIN_SP == null)
				{
					r_DEFAULT_SPIN_SP = new(typeof(System.Threading.ManualResetEventSlim), "DEFAULT_SPIN_SP");
					r_DEFAULT_SPIN_SP.SetBelong(null);
				}
				return r_DEFAULT_SPIN_SP;
			}
		}

		/// <summary>
		/// System.Object m_lock
		/// </summary>
		protected RSystem.RObject r_m_lock;
		public virtual RSystem.RObject Rm_lock
		{
			get
			{
				if(r_m_lock == null)
				{
					r_m_lock = new(this, "m_lock");
					r_m_lock.SetBelong(this.instance);
				}
				return r_m_lock;
			}
		}

		/// <summary>
		/// System.Threading.ManualResetEvent m_eventObj
		/// </summary>
		protected RSystem.RThreading.RManualResetEvent r_m_eventObj;
		public virtual RSystem.RThreading.RManualResetEvent Rm_eventObj
		{
			get
			{
				if(r_m_eventObj == null)
				{
					r_m_eventObj = new(this, "m_eventObj");
					r_m_eventObj.SetBelong(this.instance);
				}
				return r_m_eventObj;
			}
		}

		/// <summary>
		/// System.Int32 m_combinedState
		/// </summary>
		protected RSystem.RInt32 r_m_combinedState;
		public virtual RSystem.RInt32 Rm_combinedState
		{
			get
			{
				if(r_m_combinedState == null)
				{
					r_m_combinedState = new(this, "m_combinedState");
					r_m_combinedState.SetBelong(this.instance);
				}
				return r_m_combinedState;
			}
		}

		/// <summary>
		/// System.Int32 SignalledState_BitMask
		/// </summary>
		protected static RSystem.RInt32 r_SignalledState_BitMask;
		public static RSystem.RInt32 RSignalledState_BitMask
		{
			get
			{
				if(r_SignalledState_BitMask == null)
				{
					r_SignalledState_BitMask = new(typeof(System.Threading.ManualResetEventSlim), "SignalledState_BitMask");
					r_SignalledState_BitMask.SetBelong(null);
				}
				return r_SignalledState_BitMask;
			}
		}

		/// <summary>
		/// System.Int32 SignalledState_ShiftCount
		/// </summary>
		protected static RSystem.RInt32 r_SignalledState_ShiftCount;
		public static RSystem.RInt32 RSignalledState_ShiftCount
		{
			get
			{
				if(r_SignalledState_ShiftCount == null)
				{
					r_SignalledState_ShiftCount = new(typeof(System.Threading.ManualResetEventSlim), "SignalledState_ShiftCount");
					r_SignalledState_ShiftCount.SetBelong(null);
				}
				return r_SignalledState_ShiftCount;
			}
		}

		/// <summary>
		/// System.Int32 Dispose_BitMask
		/// </summary>
		protected static RSystem.RInt32 r_Dispose_BitMask;
		public static RSystem.RInt32 RDispose_BitMask
		{
			get
			{
				if(r_Dispose_BitMask == null)
				{
					r_Dispose_BitMask = new(typeof(System.Threading.ManualResetEventSlim), "Dispose_BitMask");
					r_Dispose_BitMask.SetBelong(null);
				}
				return r_Dispose_BitMask;
			}
		}

		/// <summary>
		/// System.Int32 SpinCountState_BitMask
		/// </summary>
		protected static RSystem.RInt32 r_SpinCountState_BitMask;
		public static RSystem.RInt32 RSpinCountState_BitMask
		{
			get
			{
				if(r_SpinCountState_BitMask == null)
				{
					r_SpinCountState_BitMask = new(typeof(System.Threading.ManualResetEventSlim), "SpinCountState_BitMask");
					r_SpinCountState_BitMask.SetBelong(null);
				}
				return r_SpinCountState_BitMask;
			}
		}

		/// <summary>
		/// System.Int32 SpinCountState_ShiftCount
		/// </summary>
		protected static RSystem.RInt32 r_SpinCountState_ShiftCount;
		public static RSystem.RInt32 RSpinCountState_ShiftCount
		{
			get
			{
				if(r_SpinCountState_ShiftCount == null)
				{
					r_SpinCountState_ShiftCount = new(typeof(System.Threading.ManualResetEventSlim), "SpinCountState_ShiftCount");
					r_SpinCountState_ShiftCount.SetBelong(null);
				}
				return r_SpinCountState_ShiftCount;
			}
		}

		/// <summary>
		/// System.Int32 SpinCountState_MaxValue
		/// </summary>
		protected static RSystem.RInt32 r_SpinCountState_MaxValue;
		public static RSystem.RInt32 RSpinCountState_MaxValue
		{
			get
			{
				if(r_SpinCountState_MaxValue == null)
				{
					r_SpinCountState_MaxValue = new(typeof(System.Threading.ManualResetEventSlim), "SpinCountState_MaxValue");
					r_SpinCountState_MaxValue.SetBelong(null);
				}
				return r_SpinCountState_MaxValue;
			}
		}

		/// <summary>
		/// System.Int32 NumWaitersState_BitMask
		/// </summary>
		protected static RSystem.RInt32 r_NumWaitersState_BitMask;
		public static RSystem.RInt32 RNumWaitersState_BitMask
		{
			get
			{
				if(r_NumWaitersState_BitMask == null)
				{
					r_NumWaitersState_BitMask = new(typeof(System.Threading.ManualResetEventSlim), "NumWaitersState_BitMask");
					r_NumWaitersState_BitMask.SetBelong(null);
				}
				return r_NumWaitersState_BitMask;
			}
		}

		/// <summary>
		/// System.Int32 NumWaitersState_ShiftCount
		/// </summary>
		protected static RSystem.RInt32 r_NumWaitersState_ShiftCount;
		public static RSystem.RInt32 RNumWaitersState_ShiftCount
		{
			get
			{
				if(r_NumWaitersState_ShiftCount == null)
				{
					r_NumWaitersState_ShiftCount = new(typeof(System.Threading.ManualResetEventSlim), "NumWaitersState_ShiftCount");
					r_NumWaitersState_ShiftCount.SetBelong(null);
				}
				return r_NumWaitersState_ShiftCount;
			}
		}

		/// <summary>
		/// System.Int32 NumWaitersState_MaxValue
		/// </summary>
		protected static RSystem.RInt32 r_NumWaitersState_MaxValue;
		public static RSystem.RInt32 RNumWaitersState_MaxValue
		{
			get
			{
				if(r_NumWaitersState_MaxValue == null)
				{
					r_NumWaitersState_MaxValue = new(typeof(System.Threading.ManualResetEventSlim), "NumWaitersState_MaxValue");
					r_NumWaitersState_MaxValue.SetBelong(null);
				}
				return r_NumWaitersState_MaxValue;
			}
		}

		/// <summary>
		/// System.Action`1[System.Object] s_cancellationTokenCallback
		/// </summary>
		protected static RSystem.RAction<RSystem.RObject> r_s_cancellationTokenCallback;
		public static RSystem.RAction<RSystem.RObject> Rs_cancellationTokenCallback
		{
			get
			{
				if(r_s_cancellationTokenCallback == null)
				{
					r_s_cancellationTokenCallback = new(typeof(System.Threading.ManualResetEventSlim), "s_cancellationTokenCallback");
					r_s_cancellationTokenCallback.SetBelong(null);
				}
				return r_s_cancellationTokenCallback;
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
		/// Boolean IsSet
		/// </summary>
		protected RSystem.RBoolean r_IsSet;
		public virtual RSystem.RBoolean RIsSet
		{
			get
			{
				if(r_IsSet == null)
				{
					r_IsSet = new(this, "IsSet", -1);
					r_IsSet.SetBelong(this.instance);
				}
				return r_IsSet;
			}
		}

		/// <summary>
		/// Int32 SpinCount
		/// </summary>
		protected RSystem.RInt32 r_SpinCount;
		public virtual RSystem.RInt32 RSpinCount
		{
			get
			{
				if(r_SpinCount == null)
				{
					r_SpinCount = new(this, "SpinCount", -1);
					r_SpinCount.SetBelong(this.instance);
				}
				return r_SpinCount;
			}
		}

		/// <summary>
		/// Int32 Waiters
		/// </summary>
		protected RSystem.RInt32 r_Waiters;
		public virtual RSystem.RInt32 RWaiters
		{
			get
			{
				if(r_Waiters == null)
				{
					r_Waiters = new(this, "Waiters", -1);
					r_Waiters.SetBelong(this.instance);
				}
				return r_Waiters;
			}
		}

		/// <summary>
		/// Void Initialize(Boolean, Int32)
		/// </summary>
		protected RMethod r_Initialize_Boolean_Int32;
		public virtual RMethod RInitialize_Boolean_Int32
		{
			get
			{
				if(r_Initialize_Boolean_Int32 == null)
				{
					r_Initialize_Boolean_Int32 = new(this, "Initialize", 0, typeof(System.Boolean), typeof(System.Int32));
					r_Initialize_Boolean_Int32.SetBelong(this.instance);
				}
				return r_Initialize_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void EnsureLockObjectCreated()
		/// </summary>
		protected RMethod r_EnsureLockObjectCreated;
		public virtual RMethod REnsureLockObjectCreated
		{
			get
			{
				if(r_EnsureLockObjectCreated == null)
				{
					r_EnsureLockObjectCreated = new(this, "EnsureLockObjectCreated", 0);
					r_EnsureLockObjectCreated.SetBelong(this.instance);
				}
				return r_EnsureLockObjectCreated;
			}
		}

		/// <summary>
		/// Boolean LazyInitializeEvent()
		/// </summary>
		protected RMethod r_LazyInitializeEvent;
		public virtual RMethod RLazyInitializeEvent
		{
			get
			{
				if(r_LazyInitializeEvent == null)
				{
					r_LazyInitializeEvent = new(this, "LazyInitializeEvent", 0);
					r_LazyInitializeEvent.SetBelong(this.instance);
				}
				return r_LazyInitializeEvent;
			}
		}

		/// <summary>
		/// Void Set()
		/// </summary>
		protected RMethod r_Set;
		public virtual RMethod RSet
		{
			get
			{
				if(r_Set == null)
				{
					r_Set = new(this, "Set", 0);
					r_Set.SetBelong(this.instance);
				}
				return r_Set;
			}
		}

		/// <summary>
		/// Void Set(Boolean)
		/// </summary>
		protected RMethod r_Set_Boolean;
		public virtual RMethod RSet_Boolean
		{
			get
			{
				if(r_Set_Boolean == null)
				{
					r_Set_Boolean = new(this, "Set", 0, typeof(System.Boolean));
					r_Set_Boolean.SetBelong(this.instance);
				}
				return r_Set_Boolean;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_Reset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_Reset == null)
				{
					r_Reset = new(this, "Reset", 0);
					r_Reset.SetBelong(this.instance);
				}
				return r_Reset;
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
		/// Boolean Wait(System.TimeSpan, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_Wait_TimeSpan_CancellationToken;
		public virtual RMethod RWait_TimeSpan_CancellationToken
		{
			get
			{
				if(r_Wait_TimeSpan_CancellationToken == null)
				{
					r_Wait_TimeSpan_CancellationToken = new(this, "Wait", 0, typeof(System.TimeSpan), typeof(System.Threading.CancellationToken));
					r_Wait_TimeSpan_CancellationToken.SetBelong(this.instance);
				}
				return r_Wait_TimeSpan_CancellationToken;
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
		/// Void CancellationTokenCallback(System.Object)
		/// </summary>
		protected static RMethod r_CancellationTokenCallback_Object;
		public static RMethod RCancellationTokenCallback_Object
		{
			get
			{
				if(r_CancellationTokenCallback_Object == null)
				{
					r_CancellationTokenCallback_Object = new(typeof(System.Threading.ManualResetEventSlim), "CancellationTokenCallback", 0, typeof(System.Object));
					r_CancellationTokenCallback_Object.SetBelong(null);
				}
				return r_CancellationTokenCallback_Object;
			}
		}

		/// <summary>
		/// Void UpdateStateAtomically(Int32, Int32)
		/// </summary>
		protected RMethod r_UpdateStateAtomically_Int32_Int32;
		public virtual RMethod RUpdateStateAtomically_Int32_Int32
		{
			get
			{
				if(r_UpdateStateAtomically_Int32_Int32 == null)
				{
					r_UpdateStateAtomically_Int32_Int32 = new(this, "UpdateStateAtomically", 0, typeof(System.Int32), typeof(System.Int32));
					r_UpdateStateAtomically_Int32_Int32.SetBelong(this.instance);
				}
				return r_UpdateStateAtomically_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 ExtractStatePortionAndShiftRight(Int32, Int32, Int32)
		/// </summary>
		protected static RMethod r_ExtractStatePortionAndShiftRight_Int32_Int32_Int32;
		public static RMethod RExtractStatePortionAndShiftRight_Int32_Int32_Int32
		{
			get
			{
				if(r_ExtractStatePortionAndShiftRight_Int32_Int32_Int32 == null)
				{
					r_ExtractStatePortionAndShiftRight_Int32_Int32_Int32 = new(typeof(System.Threading.ManualResetEventSlim), "ExtractStatePortionAndShiftRight", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_ExtractStatePortionAndShiftRight_Int32_Int32_Int32.SetBelong(null);
				}
				return r_ExtractStatePortionAndShiftRight_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 ExtractStatePortion(Int32, Int32)
		/// </summary>
		protected static RMethod r_ExtractStatePortion_Int32_Int32;
		public static RMethod RExtractStatePortion_Int32_Int32
		{
			get
			{
				if(r_ExtractStatePortion_Int32_Int32 == null)
				{
					r_ExtractStatePortion_Int32_Int32 = new(typeof(System.Threading.ManualResetEventSlim), "ExtractStatePortion", 0, typeof(System.Int32), typeof(System.Int32));
					r_ExtractStatePortion_Int32_Int32.SetBelong(null);
				}
				return r_ExtractStatePortion_Int32_Int32;
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


        public RManualResetEventSlim() : base("System.Threading.ManualResetEventSlim")
        {
        }

        public RManualResetEventSlim(System.Object instance) : base("System.Threading.ManualResetEventSlim")
		{
            SetInstance(instance);
		}

        public RManualResetEventSlim(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RManualResetEventSlim(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Initialize(System.Boolean @initialState, System.Int32 @spinCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@initialState, @spinCount};
            var ___result = RInitialize_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnsureLockObjectCreated()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REnsureLockObjectCreated.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean LazyInitializeEvent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RLazyInitializeEvent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Set()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSet.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Set(System.Boolean @duringCancellation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@duringCancellation};
            var ___result = RSet_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Wait()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWait.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Wait(System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cancellationToken};
            var ___result = RWait_CancellationToken.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Wait(System.TimeSpan @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout};
            var ___result = RWait_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Wait(System.TimeSpan @timeout, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout, @cancellationToken};
            var ___result = RWait_TimeSpan_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Wait(System.Int32 @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout};
            var ___result = RWait_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Wait(System.Int32 @millisecondsTimeout, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout, @cancellationToken};
            var ___result = RWait_Int32_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public static void CancellationTokenCallback(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RCancellationTokenCallback_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateStateAtomically(System.Int32 @newBits, System.Int32 @updateBitsMask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newBits, @updateBitsMask};
            var ___result = RUpdateStateAtomically_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 ExtractStatePortionAndShiftRight(System.Int32 @state, System.Int32 @mask, System.Int32 @rightBitShiftCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state, @mask, @rightBitShiftCount};
            var ___result = RExtractStatePortionAndShiftRight_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 ExtractStatePortion(System.Int32 @state, System.Int32 @mask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state, @mask};
            var ___result = RExtractStatePortion_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
