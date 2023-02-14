
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.ManualResetEventSlim
	/// </summary>
    public partial class RManualResetEventSlim : RMember //
    {

		/// <summary>
		/// System.Int32 DEFAULT_SPIN_SP
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FDEFAULT_SPIN_SP;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFDEFAULT_SPIN_SP
		{
			get
			{
				if(r_FDEFAULT_SPIN_SP == null)
				{
					r_FDEFAULT_SPIN_SP = new(typeof(System.Threading.ManualResetEventSlim), "DEFAULT_SPIN_SP");
					r_FDEFAULT_SPIN_SP.SetBelong(null);
				}
				return r_FDEFAULT_SPIN_SP;
			}
		}

		/// <summary>
		/// System.Object m_lock
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_Fm_lock;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RFm_lock
		{
			get
			{
				if(r_Fm_lock == null)
				{
					r_Fm_lock = new(this, "m_lock");
					r_Fm_lock.SetBelong(this.instance);
				}
				return r_Fm_lock;
			}
		}

		/// <summary>
		/// System.Threading.ManualResetEvent m_eventObj
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RManualResetEvent r_Fm_eventObj;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RManualResetEvent RFm_eventObj
		{
			get
			{
				if(r_Fm_eventObj == null)
				{
					r_Fm_eventObj = new(this, "m_eventObj");
					r_Fm_eventObj.SetBelong(this.instance);
				}
				return r_Fm_eventObj;
			}
		}

		/// <summary>
		/// System.Int32 m_combinedState
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_combinedState;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_combinedState
		{
			get
			{
				if(r_Fm_combinedState == null)
				{
					r_Fm_combinedState = new(this, "m_combinedState");
					r_Fm_combinedState.SetBelong(this.instance);
				}
				return r_Fm_combinedState;
			}
		}

		/// <summary>
		/// System.Int32 SignalledState_BitMask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FSignalledState_BitMask;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFSignalledState_BitMask
		{
			get
			{
				if(r_FSignalledState_BitMask == null)
				{
					r_FSignalledState_BitMask = new(typeof(System.Threading.ManualResetEventSlim), "SignalledState_BitMask");
					r_FSignalledState_BitMask.SetBelong(null);
				}
				return r_FSignalledState_BitMask;
			}
		}

		/// <summary>
		/// System.Int32 SignalledState_ShiftCount
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FSignalledState_ShiftCount;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFSignalledState_ShiftCount
		{
			get
			{
				if(r_FSignalledState_ShiftCount == null)
				{
					r_FSignalledState_ShiftCount = new(typeof(System.Threading.ManualResetEventSlim), "SignalledState_ShiftCount");
					r_FSignalledState_ShiftCount.SetBelong(null);
				}
				return r_FSignalledState_ShiftCount;
			}
		}

		/// <summary>
		/// System.Int32 Dispose_BitMask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FDispose_BitMask;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFDispose_BitMask
		{
			get
			{
				if(r_FDispose_BitMask == null)
				{
					r_FDispose_BitMask = new(typeof(System.Threading.ManualResetEventSlim), "Dispose_BitMask");
					r_FDispose_BitMask.SetBelong(null);
				}
				return r_FDispose_BitMask;
			}
		}

		/// <summary>
		/// System.Int32 SpinCountState_BitMask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FSpinCountState_BitMask;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFSpinCountState_BitMask
		{
			get
			{
				if(r_FSpinCountState_BitMask == null)
				{
					r_FSpinCountState_BitMask = new(typeof(System.Threading.ManualResetEventSlim), "SpinCountState_BitMask");
					r_FSpinCountState_BitMask.SetBelong(null);
				}
				return r_FSpinCountState_BitMask;
			}
		}

		/// <summary>
		/// System.Int32 SpinCountState_ShiftCount
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FSpinCountState_ShiftCount;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFSpinCountState_ShiftCount
		{
			get
			{
				if(r_FSpinCountState_ShiftCount == null)
				{
					r_FSpinCountState_ShiftCount = new(typeof(System.Threading.ManualResetEventSlim), "SpinCountState_ShiftCount");
					r_FSpinCountState_ShiftCount.SetBelong(null);
				}
				return r_FSpinCountState_ShiftCount;
			}
		}

		/// <summary>
		/// System.Int32 SpinCountState_MaxValue
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FSpinCountState_MaxValue;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFSpinCountState_MaxValue
		{
			get
			{
				if(r_FSpinCountState_MaxValue == null)
				{
					r_FSpinCountState_MaxValue = new(typeof(System.Threading.ManualResetEventSlim), "SpinCountState_MaxValue");
					r_FSpinCountState_MaxValue.SetBelong(null);
				}
				return r_FSpinCountState_MaxValue;
			}
		}

		/// <summary>
		/// System.Int32 NumWaitersState_BitMask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FNumWaitersState_BitMask;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFNumWaitersState_BitMask
		{
			get
			{
				if(r_FNumWaitersState_BitMask == null)
				{
					r_FNumWaitersState_BitMask = new(typeof(System.Threading.ManualResetEventSlim), "NumWaitersState_BitMask");
					r_FNumWaitersState_BitMask.SetBelong(null);
				}
				return r_FNumWaitersState_BitMask;
			}
		}

		/// <summary>
		/// System.Int32 NumWaitersState_ShiftCount
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FNumWaitersState_ShiftCount;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFNumWaitersState_ShiftCount
		{
			get
			{
				if(r_FNumWaitersState_ShiftCount == null)
				{
					r_FNumWaitersState_ShiftCount = new(typeof(System.Threading.ManualResetEventSlim), "NumWaitersState_ShiftCount");
					r_FNumWaitersState_ShiftCount.SetBelong(null);
				}
				return r_FNumWaitersState_ShiftCount;
			}
		}

		/// <summary>
		/// System.Int32 NumWaitersState_MaxValue
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FNumWaitersState_MaxValue;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFNumWaitersState_MaxValue
		{
			get
			{
				if(r_FNumWaitersState_MaxValue == null)
				{
					r_FNumWaitersState_MaxValue = new(typeof(System.Threading.ManualResetEventSlim), "NumWaitersState_MaxValue");
					r_FNumWaitersState_MaxValue.SetBelong(null);
				}
				return r_FNumWaitersState_MaxValue;
			}
		}

		/// <summary>
		/// System.Action`1[System.Object] s_cancellationTokenCallback
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RObject> r_Fs_cancellationTokenCallback;
		public static Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RObject> RFs_cancellationTokenCallback
		{
			get
			{
				if(r_Fs_cancellationTokenCallback == null)
				{
					r_Fs_cancellationTokenCallback = new(typeof(System.Threading.ManualResetEventSlim), "s_cancellationTokenCallback");
					r_Fs_cancellationTokenCallback.SetBelong(null);
				}
				return r_Fs_cancellationTokenCallback;
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
					r_PWaitHandle.SetBelong(this.instance);
				}
				return r_PWaitHandle;
			}
		}

		/// <summary>
		/// Boolean IsSet
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsSet;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsSet
		{
			get
			{
				if(r_PIsSet == null)
				{
					r_PIsSet = new(this, "IsSet", -1);
					r_PIsSet.SetBelong(this.instance);
				}
				return r_PIsSet;
			}
		}

		/// <summary>
		/// Int32 SpinCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PSpinCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPSpinCount
		{
			get
			{
				if(r_PSpinCount == null)
				{
					r_PSpinCount = new(this, "SpinCount", -1);
					r_PSpinCount.SetBelong(this.instance);
				}
				return r_PSpinCount;
			}
		}

		/// <summary>
		/// Int32 Waiters
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PWaiters;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPWaiters
		{
			get
			{
				if(r_PWaiters == null)
				{
					r_PWaiters = new(this, "Waiters", -1);
					r_PWaiters.SetBelong(this.instance);
				}
				return r_PWaiters;
			}
		}

		/// <summary>
		/// Void Initialize(Boolean, Int32)
		/// </summary>
		protected RMethod r_MInitialize_Boolean_Int32;
		public virtual RMethod RMInitialize_Boolean_Int32
		{
			get
			{
				if(r_MInitialize_Boolean_Int32 == null)
				{
					r_MInitialize_Boolean_Int32 = new(this, "Initialize", 0, typeof(System.Boolean), typeof(System.Int32));
					r_MInitialize_Boolean_Int32.SetBelong(this.instance);
				}
				return r_MInitialize_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void EnsureLockObjectCreated()
		/// </summary>
		protected RMethod r_MEnsureLockObjectCreated;
		public virtual RMethod RMEnsureLockObjectCreated
		{
			get
			{
				if(r_MEnsureLockObjectCreated == null)
				{
					r_MEnsureLockObjectCreated = new(this, "EnsureLockObjectCreated", 0);
					r_MEnsureLockObjectCreated.SetBelong(this.instance);
				}
				return r_MEnsureLockObjectCreated;
			}
		}

		/// <summary>
		/// Boolean LazyInitializeEvent()
		/// </summary>
		protected RMethod r_MLazyInitializeEvent;
		public virtual RMethod RMLazyInitializeEvent
		{
			get
			{
				if(r_MLazyInitializeEvent == null)
				{
					r_MLazyInitializeEvent = new(this, "LazyInitializeEvent", 0);
					r_MLazyInitializeEvent.SetBelong(this.instance);
				}
				return r_MLazyInitializeEvent;
			}
		}

		/// <summary>
		/// Void Set()
		/// </summary>
		protected RMethod r_MSet;
		public virtual RMethod RMSet
		{
			get
			{
				if(r_MSet == null)
				{
					r_MSet = new(this, "Set", 0);
					r_MSet.SetBelong(this.instance);
				}
				return r_MSet;
			}
		}

		/// <summary>
		/// Void Set(Boolean)
		/// </summary>
		protected RMethod r_MSet_Boolean;
		public virtual RMethod RMSet_Boolean
		{
			get
			{
				if(r_MSet_Boolean == null)
				{
					r_MSet_Boolean = new(this, "Set", 0, typeof(System.Boolean));
					r_MSet_Boolean.SetBelong(this.instance);
				}
				return r_MSet_Boolean;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_MReset;
		public virtual RMethod RMReset
		{
			get
			{
				if(r_MReset == null)
				{
					r_MReset = new(this, "Reset", 0);
					r_MReset.SetBelong(this.instance);
				}
				return r_MReset;
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
					r_MWait.SetBelong(this.instance);
				}
				return r_MWait;
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
					r_MWait_CancellationToken.SetBelong(this.instance);
				}
				return r_MWait_CancellationToken;
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
					r_MWait_TimeSpan.SetBelong(this.instance);
				}
				return r_MWait_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean Wait(System.TimeSpan, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MWait_TimeSpan_CancellationToken;
		public virtual RMethod RMWait_TimeSpan_CancellationToken
		{
			get
			{
				if(r_MWait_TimeSpan_CancellationToken == null)
				{
					r_MWait_TimeSpan_CancellationToken = new(this, "Wait", 0, typeof(System.TimeSpan), typeof(System.Threading.CancellationToken));
					r_MWait_TimeSpan_CancellationToken.SetBelong(this.instance);
				}
				return r_MWait_TimeSpan_CancellationToken;
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
					r_MWait_Int32.SetBelong(this.instance);
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
					r_MWait_Int32_CancellationToken.SetBelong(this.instance);
				}
				return r_MWait_Int32_CancellationToken;
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
					r_MDispose.SetBelong(this.instance);
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
					r_MDispose_Boolean.SetBelong(this.instance);
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
					r_MThrowIfDisposed.SetBelong(this.instance);
				}
				return r_MThrowIfDisposed;
			}
		}

		/// <summary>
		/// Void CancellationTokenCallback(System.Object)
		/// </summary>
		protected static RMethod r_MCancellationTokenCallback_Object;
		public static RMethod RMCancellationTokenCallback_Object
		{
			get
			{
				if(r_MCancellationTokenCallback_Object == null)
				{
					r_MCancellationTokenCallback_Object = new(typeof(System.Threading.ManualResetEventSlim), "CancellationTokenCallback", 0, typeof(System.Object));
					r_MCancellationTokenCallback_Object.SetBelong(null);
				}
				return r_MCancellationTokenCallback_Object;
			}
		}

		/// <summary>
		/// Void UpdateStateAtomically(Int32, Int32)
		/// </summary>
		protected RMethod r_MUpdateStateAtomically_Int32_Int32;
		public virtual RMethod RMUpdateStateAtomically_Int32_Int32
		{
			get
			{
				if(r_MUpdateStateAtomically_Int32_Int32 == null)
				{
					r_MUpdateStateAtomically_Int32_Int32 = new(this, "UpdateStateAtomically", 0, typeof(System.Int32), typeof(System.Int32));
					r_MUpdateStateAtomically_Int32_Int32.SetBelong(this.instance);
				}
				return r_MUpdateStateAtomically_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 ExtractStatePortionAndShiftRight(Int32, Int32, Int32)
		/// </summary>
		protected static RMethod r_MExtractStatePortionAndShiftRight_Int32_Int32_Int32;
		public static RMethod RMExtractStatePortionAndShiftRight_Int32_Int32_Int32
		{
			get
			{
				if(r_MExtractStatePortionAndShiftRight_Int32_Int32_Int32 == null)
				{
					r_MExtractStatePortionAndShiftRight_Int32_Int32_Int32 = new(typeof(System.Threading.ManualResetEventSlim), "ExtractStatePortionAndShiftRight", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_MExtractStatePortionAndShiftRight_Int32_Int32_Int32.SetBelong(null);
				}
				return r_MExtractStatePortionAndShiftRight_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 ExtractStatePortion(Int32, Int32)
		/// </summary>
		protected static RMethod r_MExtractStatePortion_Int32_Int32;
		public static RMethod RMExtractStatePortion_Int32_Int32
		{
			get
			{
				if(r_MExtractStatePortion_Int32_Int32 == null)
				{
					r_MExtractStatePortion_Int32_Int32 = new(typeof(System.Threading.ManualResetEventSlim), "ExtractStatePortion", 0, typeof(System.Int32), typeof(System.Int32));
					r_MExtractStatePortion_Int32_Int32.SetBelong(null);
				}
				return r_MExtractStatePortion_Int32_Int32;
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
            var ___result = RMInitialize_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnsureLockObjectCreated()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMEnsureLockObjectCreated.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean LazyInitializeEvent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMLazyInitializeEvent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Set()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSet.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Set(System.Boolean @duringCancellation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@duringCancellation};
            var ___result = RMSet_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Wait()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMWait.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Wait(System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cancellationToken};
            var ___result = RMWait_CancellationToken.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Wait(System.TimeSpan @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout};
            var ___result = RMWait_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Wait(System.TimeSpan @timeout, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout, @cancellationToken};
            var ___result = RMWait_TimeSpan_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public static void CancellationTokenCallback(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMCancellationTokenCallback_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateStateAtomically(System.Int32 @newBits, System.Int32 @updateBitsMask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newBits, @updateBitsMask};
            var ___result = RMUpdateStateAtomically_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 ExtractStatePortionAndShiftRight(System.Int32 @state, System.Int32 @mask, System.Int32 @rightBitShiftCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state, @mask, @rightBitShiftCount};
            var ___result = RMExtractStatePortionAndShiftRight_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 ExtractStatePortion(System.Int32 @state, System.Int32 @mask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state, @mask};
            var ___result = RMExtractStatePortion_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
