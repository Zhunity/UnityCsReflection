
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.WaitHandle
	/// </summary>
    public partial class RWaitHandle : RMember //
    {

		/// <summary>
		/// System.Int32 WaitTimeout
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FWaitTimeout;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFWaitTimeout
		{
			get
			{
				if(r_FWaitTimeout == null)
				{
					r_FWaitTimeout = new(typeof(System.Threading.WaitHandle), "WaitTimeout");
					r_FWaitTimeout.SetBelong(null);
				}
				return r_FWaitTimeout;
			}
		}

		/// <summary>
		/// System.Int32 MAX_WAITHANDLES
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FMAX_WAITHANDLES;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFMAX_WAITHANDLES
		{
			get
			{
				if(r_FMAX_WAITHANDLES == null)
				{
					r_FMAX_WAITHANDLES = new(typeof(System.Threading.WaitHandle), "MAX_WAITHANDLES");
					r_FMAX_WAITHANDLES.SetBelong(null);
				}
				return r_FMAX_WAITHANDLES;
			}
		}

		/// <summary>
		/// System.IntPtr waitHandle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_FwaitHandle;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFwaitHandle
		{
			get
			{
				if(r_FwaitHandle == null)
				{
					r_FwaitHandle = new(this, "waitHandle");
					r_FwaitHandle.SetBelong(this.GetValue());
				}
				return r_FwaitHandle;
			}
		}

		/// <summary>
		/// Microsoft.Win32.SafeHandles.SafeWaitHandle safeWaitHandle
		/// </summary>
		protected Hvak.Editor.Refleaction.RMicrosoft.RWin32.RSafeHandles.RSafeWaitHandle r_FsafeWaitHandle;
		public virtual Hvak.Editor.Refleaction.RMicrosoft.RWin32.RSafeHandles.RSafeWaitHandle RFsafeWaitHandle
		{
			get
			{
				if(r_FsafeWaitHandle == null)
				{
					r_FsafeWaitHandle = new(this, "safeWaitHandle");
					r_FsafeWaitHandle.SetBelong(this.GetValue());
				}
				return r_FsafeWaitHandle;
			}
		}

		/// <summary>
		/// System.Boolean hasThreadAffinity
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FhasThreadAffinity;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFhasThreadAffinity
		{
			get
			{
				if(r_FhasThreadAffinity == null)
				{
					r_FhasThreadAffinity = new(this, "hasThreadAffinity");
					r_FhasThreadAffinity.SetBelong(this.GetValue());
				}
				return r_FhasThreadAffinity;
			}
		}

		/// <summary>
		/// System.Int32 WAIT_OBJECT_0
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FWAIT_OBJECT_0;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFWAIT_OBJECT_0
		{
			get
			{
				if(r_FWAIT_OBJECT_0 == null)
				{
					r_FWAIT_OBJECT_0 = new(typeof(System.Threading.WaitHandle), "WAIT_OBJECT_0");
					r_FWAIT_OBJECT_0.SetBelong(null);
				}
				return r_FWAIT_OBJECT_0;
			}
		}

		/// <summary>
		/// System.Int32 WAIT_ABANDONED
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FWAIT_ABANDONED;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFWAIT_ABANDONED
		{
			get
			{
				if(r_FWAIT_ABANDONED == null)
				{
					r_FWAIT_ABANDONED = new(typeof(System.Threading.WaitHandle), "WAIT_ABANDONED");
					r_FWAIT_ABANDONED.SetBelong(null);
				}
				return r_FWAIT_ABANDONED;
			}
		}

		/// <summary>
		/// System.Int32 WAIT_FAILED
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FWAIT_FAILED;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFWAIT_FAILED
		{
			get
			{
				if(r_FWAIT_FAILED == null)
				{
					r_FWAIT_FAILED = new(typeof(System.Threading.WaitHandle), "WAIT_FAILED");
					r_FWAIT_FAILED.SetBelong(null);
				}
				return r_FWAIT_FAILED;
			}
		}

		/// <summary>
		/// System.Int32 ERROR_TOO_MANY_POSTS
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FERROR_TOO_MANY_POSTS;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFERROR_TOO_MANY_POSTS
		{
			get
			{
				if(r_FERROR_TOO_MANY_POSTS == null)
				{
					r_FERROR_TOO_MANY_POSTS = new(typeof(System.Threading.WaitHandle), "ERROR_TOO_MANY_POSTS");
					r_FERROR_TOO_MANY_POSTS.SetBelong(null);
				}
				return r_FERROR_TOO_MANY_POSTS;
			}
		}

		/// <summary>
		/// System.Int32 ERROR_NOT_OWNED_BY_CALLER
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FERROR_NOT_OWNED_BY_CALLER;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFERROR_NOT_OWNED_BY_CALLER
		{
			get
			{
				if(r_FERROR_NOT_OWNED_BY_CALLER == null)
				{
					r_FERROR_NOT_OWNED_BY_CALLER = new(typeof(System.Threading.WaitHandle), "ERROR_NOT_OWNED_BY_CALLER");
					r_FERROR_NOT_OWNED_BY_CALLER.SetBelong(null);
				}
				return r_FERROR_NOT_OWNED_BY_CALLER;
			}
		}

		/// <summary>
		/// System.IntPtr InvalidHandle
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RIntPtr r_FInvalidHandle;
		public static Hvak.Editor.Refleaction.RSystem.RIntPtr RFInvalidHandle
		{
			get
			{
				if(r_FInvalidHandle == null)
				{
					r_FInvalidHandle = new(typeof(System.Threading.WaitHandle), "InvalidHandle");
					r_FInvalidHandle.SetBelong(null);
				}
				return r_FInvalidHandle;
			}
		}

		/// <summary>
		/// System.Int32 MaxWaitHandles
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FMaxWaitHandles;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFMaxWaitHandles
		{
			get
			{
				if(r_FMaxWaitHandles == null)
				{
					r_FMaxWaitHandles = new(typeof(System.Threading.WaitHandle), "MaxWaitHandles");
					r_FMaxWaitHandles.SetBelong(null);
				}
				return r_FMaxWaitHandles;
			}
		}

		/// <summary>
		/// IntPtr Handle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_PHandle;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RPHandle
		{
			get
			{
				if(r_PHandle == null)
				{
					r_PHandle = new(this, "Handle", -1);
					r_PHandle.SetBelong(this.GetValue());
				}
				return r_PHandle;
			}
		}

		/// <summary>
		/// Microsoft.Win32.SafeHandles.SafeWaitHandle SafeWaitHandle
		/// </summary>
		protected Hvak.Editor.Refleaction.RMicrosoft.RWin32.RSafeHandles.RSafeWaitHandle r_PSafeWaitHandle;
		public virtual Hvak.Editor.Refleaction.RMicrosoft.RWin32.RSafeHandles.RSafeWaitHandle RPSafeWaitHandle
		{
			get
			{
				if(r_PSafeWaitHandle == null)
				{
					r_PSafeWaitHandle = new(this, "SafeWaitHandle", -1);
					r_PSafeWaitHandle.SetBelong(this.GetValue());
				}
				return r_PSafeWaitHandle;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ServerIdentity ObjectIdentity
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RServerIdentity r_PObjectIdentity;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RServerIdentity RPObjectIdentity
		{
			get
			{
				if(r_PObjectIdentity == null)
				{
					r_PObjectIdentity = new(this, "ObjectIdentity", -1);
					r_PObjectIdentity.SetBelong(this.GetValue());
				}
				return r_PObjectIdentity;
			}
		}

		/// <summary>
		/// Void Init()
		/// </summary>
		protected RMethod r_MInit;
		public virtual RMethod RMInit
		{
			get
			{
				if(r_MInit == null)
				{
					r_MInit = new(this, "Init", 0);
					r_MInit.SetBelong(this.GetValue());
				}
				return r_MInit;
			}
		}

		/// <summary>
		/// Void SetHandleInternal(Microsoft.Win32.SafeHandles.SafeWaitHandle)
		/// </summary>
		protected RMethod r_MSetHandleInternal_SafeWaitHandle;
		public virtual RMethod RMSetHandleInternal_SafeWaitHandle
		{
			get
			{
				if(r_MSetHandleInternal_SafeWaitHandle == null)
				{
					r_MSetHandleInternal_SafeWaitHandle = new(this, "SetHandleInternal", 0, typeof(Microsoft.Win32.SafeHandles.SafeWaitHandle));
					r_MSetHandleInternal_SafeWaitHandle.SetBelong(this.GetValue());
				}
				return r_MSetHandleInternal_SafeWaitHandle;
			}
		}

		/// <summary>
		/// Boolean WaitOne(Int32, Boolean)
		/// </summary>
		protected RMethod r_MWaitOne_Int32_Boolean;
		public virtual RMethod RMWaitOne_Int32_Boolean
		{
			get
			{
				if(r_MWaitOne_Int32_Boolean == null)
				{
					r_MWaitOne_Int32_Boolean = new(this, "WaitOne", 0, typeof(System.Int32), typeof(System.Boolean));
					r_MWaitOne_Int32_Boolean.SetBelong(this.GetValue());
				}
				return r_MWaitOne_Int32_Boolean;
			}
		}

		/// <summary>
		/// Boolean WaitOne(System.TimeSpan, Boolean)
		/// </summary>
		protected RMethod r_MWaitOne_TimeSpan_Boolean;
		public virtual RMethod RMWaitOne_TimeSpan_Boolean
		{
			get
			{
				if(r_MWaitOne_TimeSpan_Boolean == null)
				{
					r_MWaitOne_TimeSpan_Boolean = new(this, "WaitOne", 0, typeof(System.TimeSpan), typeof(System.Boolean));
					r_MWaitOne_TimeSpan_Boolean.SetBelong(this.GetValue());
				}
				return r_MWaitOne_TimeSpan_Boolean;
			}
		}

		/// <summary>
		/// Boolean WaitOne()
		/// </summary>
		protected RMethod r_MWaitOne;
		public virtual RMethod RMWaitOne
		{
			get
			{
				if(r_MWaitOne == null)
				{
					r_MWaitOne = new(this, "WaitOne", 0);
					r_MWaitOne.SetBelong(this.GetValue());
				}
				return r_MWaitOne;
			}
		}

		/// <summary>
		/// Boolean WaitOne(Int32)
		/// </summary>
		protected RMethod r_MWaitOne_Int32;
		public virtual RMethod RMWaitOne_Int32
		{
			get
			{
				if(r_MWaitOne_Int32 == null)
				{
					r_MWaitOne_Int32 = new(this, "WaitOne", 0, typeof(System.Int32));
					r_MWaitOne_Int32.SetBelong(this.GetValue());
				}
				return r_MWaitOne_Int32;
			}
		}

		/// <summary>
		/// Boolean WaitOne(System.TimeSpan)
		/// </summary>
		protected RMethod r_MWaitOne_TimeSpan;
		public virtual RMethod RMWaitOne_TimeSpan
		{
			get
			{
				if(r_MWaitOne_TimeSpan == null)
				{
					r_MWaitOne_TimeSpan = new(this, "WaitOne", 0, typeof(System.TimeSpan));
					r_MWaitOne_TimeSpan.SetBelong(this.GetValue());
				}
				return r_MWaitOne_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean WaitOne(Int64, Boolean)
		/// </summary>
		protected RMethod r_MWaitOne_Int64_Boolean;
		public virtual RMethod RMWaitOne_Int64_Boolean
		{
			get
			{
				if(r_MWaitOne_Int64_Boolean == null)
				{
					r_MWaitOne_Int64_Boolean = new(this, "WaitOne", 0, typeof(System.Int64), typeof(System.Boolean));
					r_MWaitOne_Int64_Boolean.SetBelong(this.GetValue());
				}
				return r_MWaitOne_Int64_Boolean;
			}
		}

		/// <summary>
		/// Boolean InternalWaitOne(System.Runtime.InteropServices.SafeHandle, Int64, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_MInternalWaitOne_SafeHandle_Int64_Boolean_Boolean;
		public static RMethod RMInternalWaitOne_SafeHandle_Int64_Boolean_Boolean
		{
			get
			{
				if(r_MInternalWaitOne_SafeHandle_Int64_Boolean_Boolean == null)
				{
					r_MInternalWaitOne_SafeHandle_Int64_Boolean_Boolean = new(typeof(System.Threading.WaitHandle), "InternalWaitOne", 0, typeof(System.Runtime.InteropServices.SafeHandle), typeof(System.Int64), typeof(System.Boolean), typeof(System.Boolean));
					r_MInternalWaitOne_SafeHandle_Int64_Boolean_Boolean.SetBelong(null);
				}
				return r_MInternalWaitOne_SafeHandle_Int64_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Boolean WaitOneWithoutFAS()
		/// </summary>
		protected RMethod r_MWaitOneWithoutFAS;
		public virtual RMethod RMWaitOneWithoutFAS
		{
			get
			{
				if(r_MWaitOneWithoutFAS == null)
				{
					r_MWaitOneWithoutFAS = new(this, "WaitOneWithoutFAS", 0);
					r_MWaitOneWithoutFAS.SetBelong(this.GetValue());
				}
				return r_MWaitOneWithoutFAS;
			}
		}

		/// <summary>
		/// Boolean WaitAll(System.Threading.WaitHandle[], Int32, Boolean)
		/// </summary>
		protected static RMethod r_MWaitAll_WaitHandleArray_Int32_Boolean;
		public static RMethod RMWaitAll_WaitHandleArray_Int32_Boolean
		{
			get
			{
				if(r_MWaitAll_WaitHandleArray_Int32_Boolean == null)
				{
					r_MWaitAll_WaitHandleArray_Int32_Boolean = new(typeof(System.Threading.WaitHandle), "WaitAll", 0, typeof(System.Threading.WaitHandle).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean));
					r_MWaitAll_WaitHandleArray_Int32_Boolean.SetBelong(null);
				}
				return r_MWaitAll_WaitHandleArray_Int32_Boolean;
			}
		}

		/// <summary>
		/// Boolean WaitAll(System.Threading.WaitHandle[], System.TimeSpan, Boolean)
		/// </summary>
		protected static RMethod r_MWaitAll_WaitHandleArray_TimeSpan_Boolean;
		public static RMethod RMWaitAll_WaitHandleArray_TimeSpan_Boolean
		{
			get
			{
				if(r_MWaitAll_WaitHandleArray_TimeSpan_Boolean == null)
				{
					r_MWaitAll_WaitHandleArray_TimeSpan_Boolean = new(typeof(System.Threading.WaitHandle), "WaitAll", 0, typeof(System.Threading.WaitHandle).MakeArrayType(), typeof(System.TimeSpan), typeof(System.Boolean));
					r_MWaitAll_WaitHandleArray_TimeSpan_Boolean.SetBelong(null);
				}
				return r_MWaitAll_WaitHandleArray_TimeSpan_Boolean;
			}
		}

		/// <summary>
		/// Boolean WaitAll(System.Threading.WaitHandle[])
		/// </summary>
		protected static RMethod r_MWaitAll_WaitHandleArray;
		public static RMethod RMWaitAll_WaitHandleArray
		{
			get
			{
				if(r_MWaitAll_WaitHandleArray == null)
				{
					r_MWaitAll_WaitHandleArray = new(typeof(System.Threading.WaitHandle), "WaitAll", 0, typeof(System.Threading.WaitHandle).MakeArrayType());
					r_MWaitAll_WaitHandleArray.SetBelong(null);
				}
				return r_MWaitAll_WaitHandleArray;
			}
		}

		/// <summary>
		/// Boolean WaitAll(System.Threading.WaitHandle[], Int32)
		/// </summary>
		protected static RMethod r_MWaitAll_WaitHandleArray_Int32;
		public static RMethod RMWaitAll_WaitHandleArray_Int32
		{
			get
			{
				if(r_MWaitAll_WaitHandleArray_Int32 == null)
				{
					r_MWaitAll_WaitHandleArray_Int32 = new(typeof(System.Threading.WaitHandle), "WaitAll", 0, typeof(System.Threading.WaitHandle).MakeArrayType(), typeof(System.Int32));
					r_MWaitAll_WaitHandleArray_Int32.SetBelong(null);
				}
				return r_MWaitAll_WaitHandleArray_Int32;
			}
		}

		/// <summary>
		/// Boolean WaitAll(System.Threading.WaitHandle[], System.TimeSpan)
		/// </summary>
		protected static RMethod r_MWaitAll_WaitHandleArray_TimeSpan;
		public static RMethod RMWaitAll_WaitHandleArray_TimeSpan
		{
			get
			{
				if(r_MWaitAll_WaitHandleArray_TimeSpan == null)
				{
					r_MWaitAll_WaitHandleArray_TimeSpan = new(typeof(System.Threading.WaitHandle), "WaitAll", 0, typeof(System.Threading.WaitHandle).MakeArrayType(), typeof(System.TimeSpan));
					r_MWaitAll_WaitHandleArray_TimeSpan.SetBelong(null);
				}
				return r_MWaitAll_WaitHandleArray_TimeSpan;
			}
		}

		/// <summary>
		/// Int32 WaitAny(System.Threading.WaitHandle[], Int32, Boolean)
		/// </summary>
		protected static RMethod r_MWaitAny_WaitHandleArray_Int32_Boolean;
		public static RMethod RMWaitAny_WaitHandleArray_Int32_Boolean
		{
			get
			{
				if(r_MWaitAny_WaitHandleArray_Int32_Boolean == null)
				{
					r_MWaitAny_WaitHandleArray_Int32_Boolean = new(typeof(System.Threading.WaitHandle), "WaitAny", 0, typeof(System.Threading.WaitHandle).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean));
					r_MWaitAny_WaitHandleArray_Int32_Boolean.SetBelong(null);
				}
				return r_MWaitAny_WaitHandleArray_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 WaitAny(System.Threading.WaitHandle[], System.TimeSpan, Boolean)
		/// </summary>
		protected static RMethod r_MWaitAny_WaitHandleArray_TimeSpan_Boolean;
		public static RMethod RMWaitAny_WaitHandleArray_TimeSpan_Boolean
		{
			get
			{
				if(r_MWaitAny_WaitHandleArray_TimeSpan_Boolean == null)
				{
					r_MWaitAny_WaitHandleArray_TimeSpan_Boolean = new(typeof(System.Threading.WaitHandle), "WaitAny", 0, typeof(System.Threading.WaitHandle).MakeArrayType(), typeof(System.TimeSpan), typeof(System.Boolean));
					r_MWaitAny_WaitHandleArray_TimeSpan_Boolean.SetBelong(null);
				}
				return r_MWaitAny_WaitHandleArray_TimeSpan_Boolean;
			}
		}

		/// <summary>
		/// Int32 WaitAny(System.Threading.WaitHandle[], System.TimeSpan)
		/// </summary>
		protected static RMethod r_MWaitAny_WaitHandleArray_TimeSpan;
		public static RMethod RMWaitAny_WaitHandleArray_TimeSpan
		{
			get
			{
				if(r_MWaitAny_WaitHandleArray_TimeSpan == null)
				{
					r_MWaitAny_WaitHandleArray_TimeSpan = new(typeof(System.Threading.WaitHandle), "WaitAny", 0, typeof(System.Threading.WaitHandle).MakeArrayType(), typeof(System.TimeSpan));
					r_MWaitAny_WaitHandleArray_TimeSpan.SetBelong(null);
				}
				return r_MWaitAny_WaitHandleArray_TimeSpan;
			}
		}

		/// <summary>
		/// Int32 WaitAny(System.Threading.WaitHandle[])
		/// </summary>
		protected static RMethod r_MWaitAny_WaitHandleArray;
		public static RMethod RMWaitAny_WaitHandleArray
		{
			get
			{
				if(r_MWaitAny_WaitHandleArray == null)
				{
					r_MWaitAny_WaitHandleArray = new(typeof(System.Threading.WaitHandle), "WaitAny", 0, typeof(System.Threading.WaitHandle).MakeArrayType());
					r_MWaitAny_WaitHandleArray.SetBelong(null);
				}
				return r_MWaitAny_WaitHandleArray;
			}
		}

		/// <summary>
		/// Int32 WaitAny(System.Threading.WaitHandle[], Int32)
		/// </summary>
		protected static RMethod r_MWaitAny_WaitHandleArray_Int32;
		public static RMethod RMWaitAny_WaitHandleArray_Int32
		{
			get
			{
				if(r_MWaitAny_WaitHandleArray_Int32 == null)
				{
					r_MWaitAny_WaitHandleArray_Int32 = new(typeof(System.Threading.WaitHandle), "WaitAny", 0, typeof(System.Threading.WaitHandle).MakeArrayType(), typeof(System.Int32));
					r_MWaitAny_WaitHandleArray_Int32.SetBelong(null);
				}
				return r_MWaitAny_WaitHandleArray_Int32;
			}
		}

		/// <summary>
		/// Boolean SignalAndWait(System.Threading.WaitHandle, System.Threading.WaitHandle)
		/// </summary>
		protected static RMethod r_MSignalAndWait_WaitHandle_WaitHandle;
		public static RMethod RMSignalAndWait_WaitHandle_WaitHandle
		{
			get
			{
				if(r_MSignalAndWait_WaitHandle_WaitHandle == null)
				{
					r_MSignalAndWait_WaitHandle_WaitHandle = new(typeof(System.Threading.WaitHandle), "SignalAndWait", 0, typeof(System.Threading.WaitHandle), typeof(System.Threading.WaitHandle));
					r_MSignalAndWait_WaitHandle_WaitHandle.SetBelong(null);
				}
				return r_MSignalAndWait_WaitHandle_WaitHandle;
			}
		}

		/// <summary>
		/// Boolean SignalAndWait(System.Threading.WaitHandle, System.Threading.WaitHandle, System.TimeSpan, Boolean)
		/// </summary>
		protected static RMethod r_MSignalAndWait_WaitHandle_WaitHandle_TimeSpan_Boolean;
		public static RMethod RMSignalAndWait_WaitHandle_WaitHandle_TimeSpan_Boolean
		{
			get
			{
				if(r_MSignalAndWait_WaitHandle_WaitHandle_TimeSpan_Boolean == null)
				{
					r_MSignalAndWait_WaitHandle_WaitHandle_TimeSpan_Boolean = new(typeof(System.Threading.WaitHandle), "SignalAndWait", 0, typeof(System.Threading.WaitHandle), typeof(System.Threading.WaitHandle), typeof(System.TimeSpan), typeof(System.Boolean));
					r_MSignalAndWait_WaitHandle_WaitHandle_TimeSpan_Boolean.SetBelong(null);
				}
				return r_MSignalAndWait_WaitHandle_WaitHandle_TimeSpan_Boolean;
			}
		}

		/// <summary>
		/// Boolean SignalAndWait(System.Threading.WaitHandle, System.Threading.WaitHandle, Int32, Boolean)
		/// </summary>
		protected static RMethod r_MSignalAndWait_WaitHandle_WaitHandle_Int32_Boolean;
		public static RMethod RMSignalAndWait_WaitHandle_WaitHandle_Int32_Boolean
		{
			get
			{
				if(r_MSignalAndWait_WaitHandle_WaitHandle_Int32_Boolean == null)
				{
					r_MSignalAndWait_WaitHandle_WaitHandle_Int32_Boolean = new(typeof(System.Threading.WaitHandle), "SignalAndWait", 0, typeof(System.Threading.WaitHandle), typeof(System.Threading.WaitHandle), typeof(System.Int32), typeof(System.Boolean));
					r_MSignalAndWait_WaitHandle_WaitHandle_Int32_Boolean.SetBelong(null);
				}
				return r_MSignalAndWait_WaitHandle_WaitHandle_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void ThrowAbandonedMutexException()
		/// </summary>
		protected static RMethod r_MThrowAbandonedMutexException;
		public static RMethod RMThrowAbandonedMutexException
		{
			get
			{
				if(r_MThrowAbandonedMutexException == null)
				{
					r_MThrowAbandonedMutexException = new(typeof(System.Threading.WaitHandle), "ThrowAbandonedMutexException", 0);
					r_MThrowAbandonedMutexException.SetBelong(null);
				}
				return r_MThrowAbandonedMutexException;
			}
		}

		/// <summary>
		/// Void ThrowAbandonedMutexException(Int32, System.Threading.WaitHandle)
		/// </summary>
		protected static RMethod r_MThrowAbandonedMutexException_Int32_WaitHandle;
		public static RMethod RMThrowAbandonedMutexException_Int32_WaitHandle
		{
			get
			{
				if(r_MThrowAbandonedMutexException_Int32_WaitHandle == null)
				{
					r_MThrowAbandonedMutexException_Int32_WaitHandle = new(typeof(System.Threading.WaitHandle), "ThrowAbandonedMutexException", 0, typeof(System.Int32), typeof(System.Threading.WaitHandle));
					r_MThrowAbandonedMutexException_Int32_WaitHandle.SetBelong(null);
				}
				return r_MThrowAbandonedMutexException_Int32_WaitHandle;
			}
		}

		/// <summary>
		/// Void Close()
		/// </summary>
		protected RMethod r_MClose;
		public virtual RMethod RMClose
		{
			get
			{
				if(r_MClose == null)
				{
					r_MClose = new(this, "Close", 0);
					r_MClose.SetBelong(this.GetValue());
				}
				return r_MClose;
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
					r_MDispose_Boolean.SetBelong(this.GetValue());
				}
				return r_MDispose_Boolean;
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
					r_MDispose.SetBelong(this.GetValue());
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// Int32 WaitOneNative(System.Runtime.InteropServices.SafeHandle, UInt32, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_MWaitOneNative_SafeHandle_UInt32_Boolean_Boolean;
		public static RMethod RMWaitOneNative_SafeHandle_UInt32_Boolean_Boolean
		{
			get
			{
				if(r_MWaitOneNative_SafeHandle_UInt32_Boolean_Boolean == null)
				{
					r_MWaitOneNative_SafeHandle_UInt32_Boolean_Boolean = new(typeof(System.Threading.WaitHandle), "WaitOneNative", 0, typeof(System.Runtime.InteropServices.SafeHandle), typeof(System.UInt32), typeof(System.Boolean), typeof(System.Boolean));
					r_MWaitOneNative_SafeHandle_UInt32_Boolean_Boolean.SetBelong(null);
				}
				return r_MWaitOneNative_SafeHandle_UInt32_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Int32 WaitMultiple(System.Threading.WaitHandle[], Int32, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_MWaitMultiple_WaitHandleArray_Int32_Boolean_Boolean;
		public static RMethod RMWaitMultiple_WaitHandleArray_Int32_Boolean_Boolean
		{
			get
			{
				if(r_MWaitMultiple_WaitHandleArray_Int32_Boolean_Boolean == null)
				{
					r_MWaitMultiple_WaitHandleArray_Int32_Boolean_Boolean = new(typeof(System.Threading.WaitHandle), "WaitMultiple", 0, typeof(System.Threading.WaitHandle).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean), typeof(System.Boolean));
					r_MWaitMultiple_WaitHandleArray_Int32_Boolean_Boolean.SetBelong(null);
				}
				return r_MWaitMultiple_WaitHandleArray_Int32_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Int32 Wait_internal(IntPtr*, Int32, Boolean, Int32)
		/// </summary>
		protected static RMethod r_MWait_internal_IntPtrPointer_Int32_Boolean_Int32;
		public static RMethod RMWait_internal_IntPtrPointer_Int32_Boolean_Int32
		{
			get
			{
				if(r_MWait_internal_IntPtrPointer_Int32_Boolean_Int32 == null)
				{
					r_MWait_internal_IntPtrPointer_Int32_Boolean_Int32 = new(typeof(System.Threading.WaitHandle), "Wait_internal", 0, typeof(System.IntPtr).MakePointerType(), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_MWait_internal_IntPtrPointer_Int32_Boolean_Int32.SetBelong(null);
				}
				return r_MWait_internal_IntPtrPointer_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Int32 SignalAndWaitOne(Microsoft.Win32.SafeHandles.SafeWaitHandle, Microsoft.Win32.SafeHandles.SafeWaitHandle, Int32, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_MSignalAndWaitOne_SafeWaitHandle_SafeWaitHandle_Int32_Boolean_Boolean;
		public static RMethod RMSignalAndWaitOne_SafeWaitHandle_SafeWaitHandle_Int32_Boolean_Boolean
		{
			get
			{
				if(r_MSignalAndWaitOne_SafeWaitHandle_SafeWaitHandle_Int32_Boolean_Boolean == null)
				{
					r_MSignalAndWaitOne_SafeWaitHandle_SafeWaitHandle_Int32_Boolean_Boolean = new(typeof(System.Threading.WaitHandle), "SignalAndWaitOne", 0, typeof(Microsoft.Win32.SafeHandles.SafeWaitHandle), typeof(Microsoft.Win32.SafeHandles.SafeWaitHandle), typeof(System.Int32), typeof(System.Boolean), typeof(System.Boolean));
					r_MSignalAndWaitOne_SafeWaitHandle_SafeWaitHandle_Int32_Boolean_Boolean.SetBelong(null);
				}
				return r_MSignalAndWaitOne_SafeWaitHandle_SafeWaitHandle_Int32_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Int32 SignalAndWait_Internal(IntPtr, IntPtr, Int32)
		/// </summary>
		protected static RMethod r_MSignalAndWait_Internal_IntPtr_IntPtr_Int32;
		public static RMethod RMSignalAndWait_Internal_IntPtr_IntPtr_Int32
		{
			get
			{
				if(r_MSignalAndWait_Internal_IntPtr_IntPtr_Int32 == null)
				{
					r_MSignalAndWait_Internal_IntPtr_IntPtr_Int32 = new(typeof(System.Threading.WaitHandle), "SignalAndWait_Internal", 0, typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.Int32));
					r_MSignalAndWait_Internal_IntPtr_IntPtr_Int32.SetBelong(null);
				}
				return r_MSignalAndWait_Internal_IntPtr_IntPtr_Int32;
			}
		}

		/// <summary>
		/// Int32 ToTimeoutMilliseconds(System.TimeSpan)
		/// </summary>
		protected static RMethod r_MToTimeoutMilliseconds_TimeSpan;
		public static RMethod RMToTimeoutMilliseconds_TimeSpan
		{
			get
			{
				if(r_MToTimeoutMilliseconds_TimeSpan == null)
				{
					r_MToTimeoutMilliseconds_TimeSpan = new(typeof(System.Threading.WaitHandle), "ToTimeoutMilliseconds", 0, typeof(System.TimeSpan));
					r_MToTimeoutMilliseconds_TimeSpan.SetBelong(null);
				}
				return r_MToTimeoutMilliseconds_TimeSpan;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Identity GetObjectIdentity(System.MarshalByRefObject, Boolean ByRef)
		/// </summary>
		protected RMethod r_MGetObjectIdentity_MarshalByRefObject_Out_Boolean;
		public virtual RMethod RMGetObjectIdentity_MarshalByRefObject_Out_Boolean
		{
			get
			{
				if(r_MGetObjectIdentity_MarshalByRefObject_Out_Boolean == null)
				{
					r_MGetObjectIdentity_MarshalByRefObject_Out_Boolean = new(this, "GetObjectIdentity", 0, typeof(System.MarshalByRefObject), typeof(System.Boolean).MakeByRefType());
					r_MGetObjectIdentity_MarshalByRefObject_Out_Boolean.SetBelong(this.GetValue());
				}
				return r_MGetObjectIdentity_MarshalByRefObject_Out_Boolean;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjRef CreateObjRef(System.Type)
		/// </summary>
		protected RMethod r_MCreateObjRef_Type;
		public virtual RMethod RMCreateObjRef_Type
		{
			get
			{
				if(r_MCreateObjRef_Type == null)
				{
					r_MCreateObjRef_Type = new(this, "CreateObjRef", 0, typeof(System.Type));
					r_MCreateObjRef_Type.SetBelong(this.GetValue());
				}
				return r_MCreateObjRef_Type;
			}
		}

		/// <summary>
		/// System.Object GetLifetimeService()
		/// </summary>
		protected RMethod r_MGetLifetimeService;
		public virtual RMethod RMGetLifetimeService
		{
			get
			{
				if(r_MGetLifetimeService == null)
				{
					r_MGetLifetimeService = new(this, "GetLifetimeService", 0);
					r_MGetLifetimeService.SetBelong(this.GetValue());
				}
				return r_MGetLifetimeService;
			}
		}

		/// <summary>
		/// System.Object InitializeLifetimeService()
		/// </summary>
		protected RMethod r_MInitializeLifetimeService;
		public virtual RMethod RMInitializeLifetimeService
		{
			get
			{
				if(r_MInitializeLifetimeService == null)
				{
					r_MInitializeLifetimeService = new(this, "InitializeLifetimeService", 0);
					r_MInitializeLifetimeService.SetBelong(this.GetValue());
				}
				return r_MInitializeLifetimeService;
			}
		}

		/// <summary>
		/// System.MarshalByRefObject MemberwiseClone(Boolean)
		/// </summary>
		protected RMethod r_MMemberwiseClone_Boolean;
		public virtual RMethod RMMemberwiseClone_Boolean
		{
			get
			{
				if(r_MMemberwiseClone_Boolean == null)
				{
					r_MMemberwiseClone_Boolean = new(this, "MemberwiseClone", 0, typeof(System.Boolean));
					r_MMemberwiseClone_Boolean.SetBelong(this.GetValue());
				}
				return r_MMemberwiseClone_Boolean;
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetHashCode.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
			}
		}


        public RWaitHandle() : base("System.Threading.WaitHandle")
        {
        }

        public RWaitHandle(System.Object instance) : base("System.Threading.WaitHandle")
		{
            SetInstance(instance);
		}

        public RWaitHandle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RWaitHandle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Init()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInit.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetHandleInternal(Microsoft.Win32.SafeHandles.SafeWaitHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMSetHandleInternal_SafeWaitHandle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean WaitOne(System.Int32 @millisecondsTimeout, System.Boolean @exitContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout, @exitContext};
            var ___result = RMWaitOne_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean WaitOne(System.TimeSpan @timeout, System.Boolean @exitContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout, @exitContext};
            var ___result = RMWaitOne_TimeSpan_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean WaitOne()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMWaitOne.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean WaitOne(System.Int32 @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout};
            var ___result = RMWaitOne_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean WaitOne(System.TimeSpan @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout};
            var ___result = RMWaitOne_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean WaitOne(System.Int64 @timeout, System.Boolean @exitContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout, @exitContext};
            var ___result = RMWaitOne_Int64_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean InternalWaitOne(System.Runtime.InteropServices.SafeHandle @waitableSafeHandle, System.Int64 @millisecondsTimeout, System.Boolean @hasThreadAffinity, System.Boolean @exitContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitableSafeHandle, @millisecondsTimeout, @hasThreadAffinity, @exitContext};
            var ___result = RMInternalWaitOne_SafeHandle_Int64_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean WaitOneWithoutFAS()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMWaitOneWithoutFAS.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean WaitAll(System.Threading.WaitHandle[] @waitHandles, System.Int32 @millisecondsTimeout, System.Boolean @exitContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitHandles, @millisecondsTimeout, @exitContext};
            var ___result = RMWaitAll_WaitHandleArray_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean WaitAll(System.Threading.WaitHandle[] @waitHandles, System.TimeSpan @timeout, System.Boolean @exitContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitHandles, @timeout, @exitContext};
            var ___result = RMWaitAll_WaitHandleArray_TimeSpan_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean WaitAll(System.Threading.WaitHandle[] @waitHandles)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitHandles};
            var ___result = RMWaitAll_WaitHandleArray.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean WaitAll(System.Threading.WaitHandle[] @waitHandles, System.Int32 @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitHandles, @millisecondsTimeout};
            var ___result = RMWaitAll_WaitHandleArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean WaitAll(System.Threading.WaitHandle[] @waitHandles, System.TimeSpan @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitHandles, @timeout};
            var ___result = RMWaitAll_WaitHandleArray_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Int32 WaitAny(System.Threading.WaitHandle[] @waitHandles, System.Int32 @millisecondsTimeout, System.Boolean @exitContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitHandles, @millisecondsTimeout, @exitContext};
            var ___result = RMWaitAny_WaitHandleArray_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 WaitAny(System.Threading.WaitHandle[] @waitHandles, System.TimeSpan @timeout, System.Boolean @exitContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitHandles, @timeout, @exitContext};
            var ___result = RMWaitAny_WaitHandleArray_TimeSpan_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 WaitAny(System.Threading.WaitHandle[] @waitHandles, System.TimeSpan @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitHandles, @timeout};
            var ___result = RMWaitAny_WaitHandleArray_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 WaitAny(System.Threading.WaitHandle[] @waitHandles)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitHandles};
            var ___result = RMWaitAny_WaitHandleArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 WaitAny(System.Threading.WaitHandle[] @waitHandles, System.Int32 @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitHandles, @millisecondsTimeout};
            var ___result = RMWaitAny_WaitHandleArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean SignalAndWait(System.Threading.WaitHandle @toSignal, System.Threading.WaitHandle @toWaitOn)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@toSignal, @toWaitOn};
            var ___result = RMSignalAndWait_WaitHandle_WaitHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean SignalAndWait(System.Threading.WaitHandle @toSignal, System.Threading.WaitHandle @toWaitOn, System.TimeSpan @timeout, System.Boolean @exitContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@toSignal, @toWaitOn, @timeout, @exitContext};
            var ___result = RMSignalAndWait_WaitHandle_WaitHandle_TimeSpan_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean SignalAndWait(System.Threading.WaitHandle @toSignal, System.Threading.WaitHandle @toWaitOn, System.Int32 @millisecondsTimeout, System.Boolean @exitContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@toSignal, @toWaitOn, @millisecondsTimeout, @exitContext};
            var ___result = RMSignalAndWait_WaitHandle_WaitHandle_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void ThrowAbandonedMutexException()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMThrowAbandonedMutexException.Invoke(___genericsType, ___parameters);

            
        }


        public static void ThrowAbandonedMutexException(System.Int32 @location, System.Threading.WaitHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@location, @handle};
            var ___result = RMThrowAbandonedMutexException_Int32_WaitHandle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean @explicitDisposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@explicitDisposing};
            var ___result = RMDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 WaitOneNative(System.Runtime.InteropServices.SafeHandle @waitableSafeHandle, System.UInt32 @millisecondsTimeout, System.Boolean @hasThreadAffinity, System.Boolean @exitContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitableSafeHandle, @millisecondsTimeout, @hasThreadAffinity, @exitContext};
            var ___result = RMWaitOneNative_SafeHandle_UInt32_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 WaitMultiple(System.Threading.WaitHandle[] @waitHandles, System.Int32 @millisecondsTimeout, System.Boolean @exitContext, System.Boolean @WaitAll)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitHandles, @millisecondsTimeout, @exitContext, @WaitAll};
            var ___result = RMWaitMultiple_WaitHandleArray_Int32_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe static System.Int32 Wait_internal(System.IntPtr* @handles, System.Int32 @numHandles, System.Boolean @waitAll, System.Int32 @ms)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@handles, typeof(System.IntPtr)), @numHandles, @waitAll, @ms};
            var ___result = RMWait_internal_IntPtrPointer_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 SignalAndWaitOne(Microsoft.Win32.SafeHandles.SafeWaitHandle @waitHandleToSignal, Microsoft.Win32.SafeHandles.SafeWaitHandle @waitHandleToWaitOn, System.Int32 @millisecondsTimeout, System.Boolean @hasThreadAffinity, System.Boolean @exitContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitHandleToSignal, @waitHandleToWaitOn, @millisecondsTimeout, @hasThreadAffinity, @exitContext};
            var ___result = RMSignalAndWaitOne_SafeWaitHandle_SafeWaitHandle_Int32_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 SignalAndWait_Internal(System.IntPtr @toSignal, System.IntPtr @toWaitOn, System.Int32 @ms)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@toSignal, @toWaitOn, @ms};
            var ___result = RMSignalAndWait_Internal_IntPtr_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 ToTimeoutMilliseconds(System.TimeSpan @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout};
            var ___result = RMToTimeoutMilliseconds_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RIdentity GetObjectIdentity(System.MarshalByRefObject @obj, out System.Boolean @IsClient)
        {
			@IsClient = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @IsClient};
            var ___result = RMGetObjectIdentity_MarshalByRefObject_Out_Boolean.Invoke(___genericsType, ___parameters);
			@IsClient = (System.Boolean)___parameters[1];

            return new Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RIdentity(___result);
        }


        public virtual System.Runtime.Remoting.ObjRef CreateObjRef(System.Type @requestedType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@requestedType};
            var ___result = RMCreateObjRef_Type.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjRef)___result;
        }


        public virtual System.Object GetLifetimeService()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetLifetimeService.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object InitializeLifetimeService()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitializeLifetimeService.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.MarshalByRefObject MemberwiseClone(System.Boolean @cloneIdentity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cloneIdentity};
            var ___result = RMMemberwiseClone_Boolean.Invoke(___genericsType, ___parameters);

            return (System.MarshalByRefObject)___result;
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
