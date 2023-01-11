using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.WaitHandle
	/// </summary>
    public partial class RWaitHandle : RMember //
    {

		/// <summary>
		/// System.Int32 WaitTimeout
		/// </summary>
		protected static RSystem.RInt32 r_WaitTimeout;
		public static RSystem.RInt32 RWaitTimeout
		{
			get
			{
				if(r_WaitTimeout == null)
				{
					r_WaitTimeout = new(typeof(System.Threading.WaitHandle), "WaitTimeout");
					r_WaitTimeout.SetBelong(null);
				}
				return r_WaitTimeout;
			}
		}

		/// <summary>
		/// System.Int32 MAX_WAITHANDLES
		/// </summary>
		protected static RSystem.RInt32 r_MAX_WAITHANDLES;
		public static RSystem.RInt32 RMAX_WAITHANDLES
		{
			get
			{
				if(r_MAX_WAITHANDLES == null)
				{
					r_MAX_WAITHANDLES = new(typeof(System.Threading.WaitHandle), "MAX_WAITHANDLES");
					r_MAX_WAITHANDLES.SetBelong(null);
				}
				return r_MAX_WAITHANDLES;
			}
		}

		/// <summary>
		/// System.IntPtr waitHandle
		/// </summary>
		protected RSystem.RIntPtr r_waitHandle;
		public virtual RSystem.RIntPtr RwaitHandle
		{
			get
			{
				if(r_waitHandle == null)
				{
					r_waitHandle = new(this, "waitHandle");
					r_waitHandle.SetBelong(this.instance);
				}
				return r_waitHandle;
			}
		}

		/// <summary>
		/// Microsoft.Win32.SafeHandles.SafeWaitHandle safeWaitHandle
		/// </summary>
		protected RMicrosoft.RWin32.RSafeHandles.RSafeWaitHandle r_safeWaitHandle;
		public virtual RMicrosoft.RWin32.RSafeHandles.RSafeWaitHandle RsafeWaitHandle
		{
			get
			{
				if(r_safeWaitHandle == null)
				{
					r_safeWaitHandle = new(this, "safeWaitHandle");
					r_safeWaitHandle.SetBelong(this.instance);
				}
				return r_safeWaitHandle;
			}
		}

		/// <summary>
		/// System.Boolean hasThreadAffinity
		/// </summary>
		protected RSystem.RBoolean r_hasThreadAffinity;
		public virtual RSystem.RBoolean RhasThreadAffinity
		{
			get
			{
				if(r_hasThreadAffinity == null)
				{
					r_hasThreadAffinity = new(this, "hasThreadAffinity");
					r_hasThreadAffinity.SetBelong(this.instance);
				}
				return r_hasThreadAffinity;
			}
		}

		/// <summary>
		/// System.Int32 WAIT_OBJECT_0
		/// </summary>
		protected static RSystem.RInt32 r_WAIT_OBJECT_0;
		public static RSystem.RInt32 RWAIT_OBJECT_0
		{
			get
			{
				if(r_WAIT_OBJECT_0 == null)
				{
					r_WAIT_OBJECT_0 = new(typeof(System.Threading.WaitHandle), "WAIT_OBJECT_0");
					r_WAIT_OBJECT_0.SetBelong(null);
				}
				return r_WAIT_OBJECT_0;
			}
		}

		/// <summary>
		/// System.Int32 WAIT_ABANDONED
		/// </summary>
		protected static RSystem.RInt32 r_WAIT_ABANDONED;
		public static RSystem.RInt32 RWAIT_ABANDONED
		{
			get
			{
				if(r_WAIT_ABANDONED == null)
				{
					r_WAIT_ABANDONED = new(typeof(System.Threading.WaitHandle), "WAIT_ABANDONED");
					r_WAIT_ABANDONED.SetBelong(null);
				}
				return r_WAIT_ABANDONED;
			}
		}

		/// <summary>
		/// System.Int32 WAIT_FAILED
		/// </summary>
		protected static RSystem.RInt32 r_WAIT_FAILED;
		public static RSystem.RInt32 RWAIT_FAILED
		{
			get
			{
				if(r_WAIT_FAILED == null)
				{
					r_WAIT_FAILED = new(typeof(System.Threading.WaitHandle), "WAIT_FAILED");
					r_WAIT_FAILED.SetBelong(null);
				}
				return r_WAIT_FAILED;
			}
		}

		/// <summary>
		/// System.Int32 ERROR_TOO_MANY_POSTS
		/// </summary>
		protected static RSystem.RInt32 r_ERROR_TOO_MANY_POSTS;
		public static RSystem.RInt32 RERROR_TOO_MANY_POSTS
		{
			get
			{
				if(r_ERROR_TOO_MANY_POSTS == null)
				{
					r_ERROR_TOO_MANY_POSTS = new(typeof(System.Threading.WaitHandle), "ERROR_TOO_MANY_POSTS");
					r_ERROR_TOO_MANY_POSTS.SetBelong(null);
				}
				return r_ERROR_TOO_MANY_POSTS;
			}
		}

		/// <summary>
		/// System.Int32 ERROR_NOT_OWNED_BY_CALLER
		/// </summary>
		protected static RSystem.RInt32 r_ERROR_NOT_OWNED_BY_CALLER;
		public static RSystem.RInt32 RERROR_NOT_OWNED_BY_CALLER
		{
			get
			{
				if(r_ERROR_NOT_OWNED_BY_CALLER == null)
				{
					r_ERROR_NOT_OWNED_BY_CALLER = new(typeof(System.Threading.WaitHandle), "ERROR_NOT_OWNED_BY_CALLER");
					r_ERROR_NOT_OWNED_BY_CALLER.SetBelong(null);
				}
				return r_ERROR_NOT_OWNED_BY_CALLER;
			}
		}

		/// <summary>
		/// System.IntPtr InvalidHandle
		/// </summary>
		protected static RSystem.RIntPtr r_InvalidHandle;
		public static RSystem.RIntPtr RInvalidHandle
		{
			get
			{
				if(r_InvalidHandle == null)
				{
					r_InvalidHandle = new(typeof(System.Threading.WaitHandle), "InvalidHandle");
					r_InvalidHandle.SetBelong(null);
				}
				return r_InvalidHandle;
			}
		}

		/// <summary>
		/// System.Int32 MaxWaitHandles
		/// </summary>
		protected static RSystem.RInt32 r_MaxWaitHandles;
		public static RSystem.RInt32 RMaxWaitHandles
		{
			get
			{
				if(r_MaxWaitHandles == null)
				{
					r_MaxWaitHandles = new(typeof(System.Threading.WaitHandle), "MaxWaitHandles");
					r_MaxWaitHandles.SetBelong(null);
				}
				return r_MaxWaitHandles;
			}
		}

		/// <summary>
		/// IntPtr Handle
		/// </summary>
		protected RSystem.RIntPtr r_Handle;
		public virtual RSystem.RIntPtr RHandle
		{
			get
			{
				if(r_Handle == null)
				{
					r_Handle = new(this, "Handle", -1);
					r_Handle.SetBelong(this.instance);
				}
				return r_Handle;
			}
		}

		/// <summary>
		/// Microsoft.Win32.SafeHandles.SafeWaitHandle SafeWaitHandle
		/// </summary>
		protected RMicrosoft.RWin32.RSafeHandles.RSafeWaitHandle r_SafeWaitHandle;
		public virtual RMicrosoft.RWin32.RSafeHandles.RSafeWaitHandle RSafeWaitHandle
		{
			get
			{
				if(r_SafeWaitHandle == null)
				{
					r_SafeWaitHandle = new(this, "SafeWaitHandle", -1);
					r_SafeWaitHandle.SetBelong(this.instance);
				}
				return r_SafeWaitHandle;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ServerIdentity ObjectIdentity
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RServerIdentity r_ObjectIdentity;
		public virtual RSystem.RRuntime.RRemoting.RServerIdentity RObjectIdentity
		{
			get
			{
				if(r_ObjectIdentity == null)
				{
					r_ObjectIdentity = new(this, "ObjectIdentity", -1);
					r_ObjectIdentity.SetBelong(this.instance);
				}
				return r_ObjectIdentity;
			}
		}

		/// <summary>
		/// Void Init()
		/// </summary>
		protected RMethod r_Init;
		public virtual RMethod RInit
		{
			get
			{
				if(r_Init == null)
				{
					r_Init = new(this, "Init", 0);
					r_Init.SetBelong(this.instance);
				}
				return r_Init;
			}
		}

		/// <summary>
		/// Void SetHandleInternal(Microsoft.Win32.SafeHandles.SafeWaitHandle)
		/// </summary>
		protected RMethod r_SetHandleInternal_SafeWaitHandle;
		public virtual RMethod RSetHandleInternal_SafeWaitHandle
		{
			get
			{
				if(r_SetHandleInternal_SafeWaitHandle == null)
				{
					r_SetHandleInternal_SafeWaitHandle = new(this, "SetHandleInternal", 0, typeof(Microsoft.Win32.SafeHandles.SafeWaitHandle));
					r_SetHandleInternal_SafeWaitHandle.SetBelong(this.instance);
				}
				return r_SetHandleInternal_SafeWaitHandle;
			}
		}

		/// <summary>
		/// Boolean WaitOne(Int32, Boolean)
		/// </summary>
		protected RMethod r_WaitOne_Int32_Boolean;
		public virtual RMethod RWaitOne_Int32_Boolean
		{
			get
			{
				if(r_WaitOne_Int32_Boolean == null)
				{
					r_WaitOne_Int32_Boolean = new(this, "WaitOne", 0, typeof(System.Int32), typeof(System.Boolean));
					r_WaitOne_Int32_Boolean.SetBelong(this.instance);
				}
				return r_WaitOne_Int32_Boolean;
			}
		}

		/// <summary>
		/// Boolean WaitOne(System.TimeSpan, Boolean)
		/// </summary>
		protected RMethod r_WaitOne_TimeSpan_Boolean;
		public virtual RMethod RWaitOne_TimeSpan_Boolean
		{
			get
			{
				if(r_WaitOne_TimeSpan_Boolean == null)
				{
					r_WaitOne_TimeSpan_Boolean = new(this, "WaitOne", 0, typeof(System.TimeSpan), typeof(System.Boolean));
					r_WaitOne_TimeSpan_Boolean.SetBelong(this.instance);
				}
				return r_WaitOne_TimeSpan_Boolean;
			}
		}

		/// <summary>
		/// Boolean WaitOne()
		/// </summary>
		protected RMethod r_WaitOne;
		public virtual RMethod RWaitOne
		{
			get
			{
				if(r_WaitOne == null)
				{
					r_WaitOne = new(this, "WaitOne", 0);
					r_WaitOne.SetBelong(this.instance);
				}
				return r_WaitOne;
			}
		}

		/// <summary>
		/// Boolean WaitOne(Int32)
		/// </summary>
		protected RMethod r_WaitOne_Int32;
		public virtual RMethod RWaitOne_Int32
		{
			get
			{
				if(r_WaitOne_Int32 == null)
				{
					r_WaitOne_Int32 = new(this, "WaitOne", 0, typeof(System.Int32));
					r_WaitOne_Int32.SetBelong(this.instance);
				}
				return r_WaitOne_Int32;
			}
		}

		/// <summary>
		/// Boolean WaitOne(System.TimeSpan)
		/// </summary>
		protected RMethod r_WaitOne_TimeSpan;
		public virtual RMethod RWaitOne_TimeSpan
		{
			get
			{
				if(r_WaitOne_TimeSpan == null)
				{
					r_WaitOne_TimeSpan = new(this, "WaitOne", 0, typeof(System.TimeSpan));
					r_WaitOne_TimeSpan.SetBelong(this.instance);
				}
				return r_WaitOne_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean WaitOne(Int64, Boolean)
		/// </summary>
		protected RMethod r_WaitOne_Int64_Boolean;
		public virtual RMethod RWaitOne_Int64_Boolean
		{
			get
			{
				if(r_WaitOne_Int64_Boolean == null)
				{
					r_WaitOne_Int64_Boolean = new(this, "WaitOne", 0, typeof(System.Int64), typeof(System.Boolean));
					r_WaitOne_Int64_Boolean.SetBelong(this.instance);
				}
				return r_WaitOne_Int64_Boolean;
			}
		}

		/// <summary>
		/// Boolean InternalWaitOne(System.Runtime.InteropServices.SafeHandle, Int64, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_InternalWaitOne_SafeHandle_Int64_Boolean_Boolean;
		public static RMethod RInternalWaitOne_SafeHandle_Int64_Boolean_Boolean
		{
			get
			{
				if(r_InternalWaitOne_SafeHandle_Int64_Boolean_Boolean == null)
				{
					r_InternalWaitOne_SafeHandle_Int64_Boolean_Boolean = new(typeof(System.Threading.WaitHandle), "InternalWaitOne", 0, typeof(System.Runtime.InteropServices.SafeHandle), typeof(System.Int64), typeof(System.Boolean), typeof(System.Boolean));
					r_InternalWaitOne_SafeHandle_Int64_Boolean_Boolean.SetBelong(null);
				}
				return r_InternalWaitOne_SafeHandle_Int64_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Boolean WaitOneWithoutFAS()
		/// </summary>
		protected RMethod r_WaitOneWithoutFAS;
		public virtual RMethod RWaitOneWithoutFAS
		{
			get
			{
				if(r_WaitOneWithoutFAS == null)
				{
					r_WaitOneWithoutFAS = new(this, "WaitOneWithoutFAS", 0);
					r_WaitOneWithoutFAS.SetBelong(this.instance);
				}
				return r_WaitOneWithoutFAS;
			}
		}

		/// <summary>
		/// Boolean WaitAll(System.Threading.WaitHandle[], Int32, Boolean)
		/// </summary>
		protected static RMethod r_WaitAll_WaitHandleArray_Int32_Boolean;
		public static RMethod RWaitAll_WaitHandleArray_Int32_Boolean
		{
			get
			{
				if(r_WaitAll_WaitHandleArray_Int32_Boolean == null)
				{
					r_WaitAll_WaitHandleArray_Int32_Boolean = new(typeof(System.Threading.WaitHandle), "WaitAll", 0, typeof(System.Threading.WaitHandle).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean));
					r_WaitAll_WaitHandleArray_Int32_Boolean.SetBelong(null);
				}
				return r_WaitAll_WaitHandleArray_Int32_Boolean;
			}
		}

		/// <summary>
		/// Boolean WaitAll(System.Threading.WaitHandle[], System.TimeSpan, Boolean)
		/// </summary>
		protected static RMethod r_WaitAll_WaitHandleArray_TimeSpan_Boolean;
		public static RMethod RWaitAll_WaitHandleArray_TimeSpan_Boolean
		{
			get
			{
				if(r_WaitAll_WaitHandleArray_TimeSpan_Boolean == null)
				{
					r_WaitAll_WaitHandleArray_TimeSpan_Boolean = new(typeof(System.Threading.WaitHandle), "WaitAll", 0, typeof(System.Threading.WaitHandle).MakeArrayType(), typeof(System.TimeSpan), typeof(System.Boolean));
					r_WaitAll_WaitHandleArray_TimeSpan_Boolean.SetBelong(null);
				}
				return r_WaitAll_WaitHandleArray_TimeSpan_Boolean;
			}
		}

		/// <summary>
		/// Boolean WaitAll(System.Threading.WaitHandle[])
		/// </summary>
		protected static RMethod r_WaitAll_WaitHandleArray;
		public static RMethod RWaitAll_WaitHandleArray
		{
			get
			{
				if(r_WaitAll_WaitHandleArray == null)
				{
					r_WaitAll_WaitHandleArray = new(typeof(System.Threading.WaitHandle), "WaitAll", 0, typeof(System.Threading.WaitHandle).MakeArrayType());
					r_WaitAll_WaitHandleArray.SetBelong(null);
				}
				return r_WaitAll_WaitHandleArray;
			}
		}

		/// <summary>
		/// Boolean WaitAll(System.Threading.WaitHandle[], Int32)
		/// </summary>
		protected static RMethod r_WaitAll_WaitHandleArray_Int32;
		public static RMethod RWaitAll_WaitHandleArray_Int32
		{
			get
			{
				if(r_WaitAll_WaitHandleArray_Int32 == null)
				{
					r_WaitAll_WaitHandleArray_Int32 = new(typeof(System.Threading.WaitHandle), "WaitAll", 0, typeof(System.Threading.WaitHandle).MakeArrayType(), typeof(System.Int32));
					r_WaitAll_WaitHandleArray_Int32.SetBelong(null);
				}
				return r_WaitAll_WaitHandleArray_Int32;
			}
		}

		/// <summary>
		/// Boolean WaitAll(System.Threading.WaitHandle[], System.TimeSpan)
		/// </summary>
		protected static RMethod r_WaitAll_WaitHandleArray_TimeSpan;
		public static RMethod RWaitAll_WaitHandleArray_TimeSpan
		{
			get
			{
				if(r_WaitAll_WaitHandleArray_TimeSpan == null)
				{
					r_WaitAll_WaitHandleArray_TimeSpan = new(typeof(System.Threading.WaitHandle), "WaitAll", 0, typeof(System.Threading.WaitHandle).MakeArrayType(), typeof(System.TimeSpan));
					r_WaitAll_WaitHandleArray_TimeSpan.SetBelong(null);
				}
				return r_WaitAll_WaitHandleArray_TimeSpan;
			}
		}

		/// <summary>
		/// Int32 WaitAny(System.Threading.WaitHandle[], Int32, Boolean)
		/// </summary>
		protected static RMethod r_WaitAny_WaitHandleArray_Int32_Boolean;
		public static RMethod RWaitAny_WaitHandleArray_Int32_Boolean
		{
			get
			{
				if(r_WaitAny_WaitHandleArray_Int32_Boolean == null)
				{
					r_WaitAny_WaitHandleArray_Int32_Boolean = new(typeof(System.Threading.WaitHandle), "WaitAny", 0, typeof(System.Threading.WaitHandle).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean));
					r_WaitAny_WaitHandleArray_Int32_Boolean.SetBelong(null);
				}
				return r_WaitAny_WaitHandleArray_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 WaitAny(System.Threading.WaitHandle[], System.TimeSpan, Boolean)
		/// </summary>
		protected static RMethod r_WaitAny_WaitHandleArray_TimeSpan_Boolean;
		public static RMethod RWaitAny_WaitHandleArray_TimeSpan_Boolean
		{
			get
			{
				if(r_WaitAny_WaitHandleArray_TimeSpan_Boolean == null)
				{
					r_WaitAny_WaitHandleArray_TimeSpan_Boolean = new(typeof(System.Threading.WaitHandle), "WaitAny", 0, typeof(System.Threading.WaitHandle).MakeArrayType(), typeof(System.TimeSpan), typeof(System.Boolean));
					r_WaitAny_WaitHandleArray_TimeSpan_Boolean.SetBelong(null);
				}
				return r_WaitAny_WaitHandleArray_TimeSpan_Boolean;
			}
		}

		/// <summary>
		/// Int32 WaitAny(System.Threading.WaitHandle[], System.TimeSpan)
		/// </summary>
		protected static RMethod r_WaitAny_WaitHandleArray_TimeSpan;
		public static RMethod RWaitAny_WaitHandleArray_TimeSpan
		{
			get
			{
				if(r_WaitAny_WaitHandleArray_TimeSpan == null)
				{
					r_WaitAny_WaitHandleArray_TimeSpan = new(typeof(System.Threading.WaitHandle), "WaitAny", 0, typeof(System.Threading.WaitHandle).MakeArrayType(), typeof(System.TimeSpan));
					r_WaitAny_WaitHandleArray_TimeSpan.SetBelong(null);
				}
				return r_WaitAny_WaitHandleArray_TimeSpan;
			}
		}

		/// <summary>
		/// Int32 WaitAny(System.Threading.WaitHandle[])
		/// </summary>
		protected static RMethod r_WaitAny_WaitHandleArray;
		public static RMethod RWaitAny_WaitHandleArray
		{
			get
			{
				if(r_WaitAny_WaitHandleArray == null)
				{
					r_WaitAny_WaitHandleArray = new(typeof(System.Threading.WaitHandle), "WaitAny", 0, typeof(System.Threading.WaitHandle).MakeArrayType());
					r_WaitAny_WaitHandleArray.SetBelong(null);
				}
				return r_WaitAny_WaitHandleArray;
			}
		}

		/// <summary>
		/// Int32 WaitAny(System.Threading.WaitHandle[], Int32)
		/// </summary>
		protected static RMethod r_WaitAny_WaitHandleArray_Int32;
		public static RMethod RWaitAny_WaitHandleArray_Int32
		{
			get
			{
				if(r_WaitAny_WaitHandleArray_Int32 == null)
				{
					r_WaitAny_WaitHandleArray_Int32 = new(typeof(System.Threading.WaitHandle), "WaitAny", 0, typeof(System.Threading.WaitHandle).MakeArrayType(), typeof(System.Int32));
					r_WaitAny_WaitHandleArray_Int32.SetBelong(null);
				}
				return r_WaitAny_WaitHandleArray_Int32;
			}
		}

		/// <summary>
		/// Boolean SignalAndWait(System.Threading.WaitHandle, System.Threading.WaitHandle)
		/// </summary>
		protected static RMethod r_SignalAndWait_WaitHandle_WaitHandle;
		public static RMethod RSignalAndWait_WaitHandle_WaitHandle
		{
			get
			{
				if(r_SignalAndWait_WaitHandle_WaitHandle == null)
				{
					r_SignalAndWait_WaitHandle_WaitHandle = new(typeof(System.Threading.WaitHandle), "SignalAndWait", 0, typeof(System.Threading.WaitHandle), typeof(System.Threading.WaitHandle));
					r_SignalAndWait_WaitHandle_WaitHandle.SetBelong(null);
				}
				return r_SignalAndWait_WaitHandle_WaitHandle;
			}
		}

		/// <summary>
		/// Boolean SignalAndWait(System.Threading.WaitHandle, System.Threading.WaitHandle, System.TimeSpan, Boolean)
		/// </summary>
		protected static RMethod r_SignalAndWait_WaitHandle_WaitHandle_TimeSpan_Boolean;
		public static RMethod RSignalAndWait_WaitHandle_WaitHandle_TimeSpan_Boolean
		{
			get
			{
				if(r_SignalAndWait_WaitHandle_WaitHandle_TimeSpan_Boolean == null)
				{
					r_SignalAndWait_WaitHandle_WaitHandle_TimeSpan_Boolean = new(typeof(System.Threading.WaitHandle), "SignalAndWait", 0, typeof(System.Threading.WaitHandle), typeof(System.Threading.WaitHandle), typeof(System.TimeSpan), typeof(System.Boolean));
					r_SignalAndWait_WaitHandle_WaitHandle_TimeSpan_Boolean.SetBelong(null);
				}
				return r_SignalAndWait_WaitHandle_WaitHandle_TimeSpan_Boolean;
			}
		}

		/// <summary>
		/// Boolean SignalAndWait(System.Threading.WaitHandle, System.Threading.WaitHandle, Int32, Boolean)
		/// </summary>
		protected static RMethod r_SignalAndWait_WaitHandle_WaitHandle_Int32_Boolean;
		public static RMethod RSignalAndWait_WaitHandle_WaitHandle_Int32_Boolean
		{
			get
			{
				if(r_SignalAndWait_WaitHandle_WaitHandle_Int32_Boolean == null)
				{
					r_SignalAndWait_WaitHandle_WaitHandle_Int32_Boolean = new(typeof(System.Threading.WaitHandle), "SignalAndWait", 0, typeof(System.Threading.WaitHandle), typeof(System.Threading.WaitHandle), typeof(System.Int32), typeof(System.Boolean));
					r_SignalAndWait_WaitHandle_WaitHandle_Int32_Boolean.SetBelong(null);
				}
				return r_SignalAndWait_WaitHandle_WaitHandle_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void ThrowAbandonedMutexException()
		/// </summary>
		protected static RMethod r_ThrowAbandonedMutexException;
		public static RMethod RThrowAbandonedMutexException
		{
			get
			{
				if(r_ThrowAbandonedMutexException == null)
				{
					r_ThrowAbandonedMutexException = new(typeof(System.Threading.WaitHandle), "ThrowAbandonedMutexException", 0);
					r_ThrowAbandonedMutexException.SetBelong(null);
				}
				return r_ThrowAbandonedMutexException;
			}
		}

		/// <summary>
		/// Void ThrowAbandonedMutexException(Int32, System.Threading.WaitHandle)
		/// </summary>
		protected static RMethod r_ThrowAbandonedMutexException_Int32_WaitHandle;
		public static RMethod RThrowAbandonedMutexException_Int32_WaitHandle
		{
			get
			{
				if(r_ThrowAbandonedMutexException_Int32_WaitHandle == null)
				{
					r_ThrowAbandonedMutexException_Int32_WaitHandle = new(typeof(System.Threading.WaitHandle), "ThrowAbandonedMutexException", 0, typeof(System.Int32), typeof(System.Threading.WaitHandle));
					r_ThrowAbandonedMutexException_Int32_WaitHandle.SetBelong(null);
				}
				return r_ThrowAbandonedMutexException_Int32_WaitHandle;
			}
		}

		/// <summary>
		/// Void Close()
		/// </summary>
		protected RMethod r_Close;
		public virtual RMethod RClose
		{
			get
			{
				if(r_Close == null)
				{
					r_Close = new(this, "Close", 0);
					r_Close.SetBelong(this.instance);
				}
				return r_Close;
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
		/// Int32 WaitOneNative(System.Runtime.InteropServices.SafeHandle, UInt32, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_WaitOneNative_SafeHandle_UInt32_Boolean_Boolean;
		public static RMethod RWaitOneNative_SafeHandle_UInt32_Boolean_Boolean
		{
			get
			{
				if(r_WaitOneNative_SafeHandle_UInt32_Boolean_Boolean == null)
				{
					r_WaitOneNative_SafeHandle_UInt32_Boolean_Boolean = new(typeof(System.Threading.WaitHandle), "WaitOneNative", 0, typeof(System.Runtime.InteropServices.SafeHandle), typeof(System.UInt32), typeof(System.Boolean), typeof(System.Boolean));
					r_WaitOneNative_SafeHandle_UInt32_Boolean_Boolean.SetBelong(null);
				}
				return r_WaitOneNative_SafeHandle_UInt32_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Int32 WaitMultiple(System.Threading.WaitHandle[], Int32, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_WaitMultiple_WaitHandleArray_Int32_Boolean_Boolean;
		public static RMethod RWaitMultiple_WaitHandleArray_Int32_Boolean_Boolean
		{
			get
			{
				if(r_WaitMultiple_WaitHandleArray_Int32_Boolean_Boolean == null)
				{
					r_WaitMultiple_WaitHandleArray_Int32_Boolean_Boolean = new(typeof(System.Threading.WaitHandle), "WaitMultiple", 0, typeof(System.Threading.WaitHandle).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean), typeof(System.Boolean));
					r_WaitMultiple_WaitHandleArray_Int32_Boolean_Boolean.SetBelong(null);
				}
				return r_WaitMultiple_WaitHandleArray_Int32_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Int32 Wait_internal(IntPtr*, Int32, Boolean, Int32)
		/// </summary>
		protected static RMethod r_Wait_internal_IntPtrPointer_Int32_Boolean_Int32;
		public static RMethod RWait_internal_IntPtrPointer_Int32_Boolean_Int32
		{
			get
			{
				if(r_Wait_internal_IntPtrPointer_Int32_Boolean_Int32 == null)
				{
					r_Wait_internal_IntPtrPointer_Int32_Boolean_Int32 = new(typeof(System.Threading.WaitHandle), "Wait_internal", 0, typeof(System.IntPtr).MakePointerType(), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_Wait_internal_IntPtrPointer_Int32_Boolean_Int32.SetBelong(null);
				}
				return r_Wait_internal_IntPtrPointer_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Int32 SignalAndWaitOne(Microsoft.Win32.SafeHandles.SafeWaitHandle, Microsoft.Win32.SafeHandles.SafeWaitHandle, Int32, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_SignalAndWaitOne_SafeWaitHandle_SafeWaitHandle_Int32_Boolean_Boolean;
		public static RMethod RSignalAndWaitOne_SafeWaitHandle_SafeWaitHandle_Int32_Boolean_Boolean
		{
			get
			{
				if(r_SignalAndWaitOne_SafeWaitHandle_SafeWaitHandle_Int32_Boolean_Boolean == null)
				{
					r_SignalAndWaitOne_SafeWaitHandle_SafeWaitHandle_Int32_Boolean_Boolean = new(typeof(System.Threading.WaitHandle), "SignalAndWaitOne", 0, typeof(Microsoft.Win32.SafeHandles.SafeWaitHandle), typeof(Microsoft.Win32.SafeHandles.SafeWaitHandle), typeof(System.Int32), typeof(System.Boolean), typeof(System.Boolean));
					r_SignalAndWaitOne_SafeWaitHandle_SafeWaitHandle_Int32_Boolean_Boolean.SetBelong(null);
				}
				return r_SignalAndWaitOne_SafeWaitHandle_SafeWaitHandle_Int32_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Int32 SignalAndWait_Internal(IntPtr, IntPtr, Int32)
		/// </summary>
		protected static RMethod r_SignalAndWait_Internal_IntPtr_IntPtr_Int32;
		public static RMethod RSignalAndWait_Internal_IntPtr_IntPtr_Int32
		{
			get
			{
				if(r_SignalAndWait_Internal_IntPtr_IntPtr_Int32 == null)
				{
					r_SignalAndWait_Internal_IntPtr_IntPtr_Int32 = new(typeof(System.Threading.WaitHandle), "SignalAndWait_Internal", 0, typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.Int32));
					r_SignalAndWait_Internal_IntPtr_IntPtr_Int32.SetBelong(null);
				}
				return r_SignalAndWait_Internal_IntPtr_IntPtr_Int32;
			}
		}

		/// <summary>
		/// Int32 ToTimeoutMilliseconds(System.TimeSpan)
		/// </summary>
		protected static RMethod r_ToTimeoutMilliseconds_TimeSpan;
		public static RMethod RToTimeoutMilliseconds_TimeSpan
		{
			get
			{
				if(r_ToTimeoutMilliseconds_TimeSpan == null)
				{
					r_ToTimeoutMilliseconds_TimeSpan = new(typeof(System.Threading.WaitHandle), "ToTimeoutMilliseconds", 0, typeof(System.TimeSpan));
					r_ToTimeoutMilliseconds_TimeSpan.SetBelong(null);
				}
				return r_ToTimeoutMilliseconds_TimeSpan;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Identity GetObjectIdentity(System.MarshalByRefObject, Boolean ByRef)
		/// </summary>
		protected RMethod r_GetObjectIdentity_MarshalByRefObject_Out_Boolean;
		public virtual RMethod RGetObjectIdentity_MarshalByRefObject_Out_Boolean
		{
			get
			{
				if(r_GetObjectIdentity_MarshalByRefObject_Out_Boolean == null)
				{
					r_GetObjectIdentity_MarshalByRefObject_Out_Boolean = new(this, "GetObjectIdentity", 0, typeof(System.MarshalByRefObject), typeof(System.Boolean).MakeByRefType());
					r_GetObjectIdentity_MarshalByRefObject_Out_Boolean.SetBelong(this.instance);
				}
				return r_GetObjectIdentity_MarshalByRefObject_Out_Boolean;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjRef CreateObjRef(System.Type)
		/// </summary>
		protected RMethod r_CreateObjRef_Type;
		public virtual RMethod RCreateObjRef_Type
		{
			get
			{
				if(r_CreateObjRef_Type == null)
				{
					r_CreateObjRef_Type = new(this, "CreateObjRef", 0, typeof(System.Type));
					r_CreateObjRef_Type.SetBelong(this.instance);
				}
				return r_CreateObjRef_Type;
			}
		}

		/// <summary>
		/// System.Object GetLifetimeService()
		/// </summary>
		protected RMethod r_GetLifetimeService;
		public virtual RMethod RGetLifetimeService
		{
			get
			{
				if(r_GetLifetimeService == null)
				{
					r_GetLifetimeService = new(this, "GetLifetimeService", 0);
					r_GetLifetimeService.SetBelong(this.instance);
				}
				return r_GetLifetimeService;
			}
		}

		/// <summary>
		/// System.Object InitializeLifetimeService()
		/// </summary>
		protected RMethod r_InitializeLifetimeService;
		public virtual RMethod RInitializeLifetimeService
		{
			get
			{
				if(r_InitializeLifetimeService == null)
				{
					r_InitializeLifetimeService = new(this, "InitializeLifetimeService", 0);
					r_InitializeLifetimeService.SetBelong(this.instance);
				}
				return r_InitializeLifetimeService;
			}
		}

		/// <summary>
		/// System.MarshalByRefObject MemberwiseClone(Boolean)
		/// </summary>
		protected RMethod r_MemberwiseClone_Boolean;
		public virtual RMethod RMemberwiseClone_Boolean
		{
			get
			{
				if(r_MemberwiseClone_Boolean == null)
				{
					r_MemberwiseClone_Boolean = new(this, "MemberwiseClone", 0, typeof(System.Boolean));
					r_MemberwiseClone_Boolean.SetBelong(this.instance);
				}
				return r_MemberwiseClone_Boolean;
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
            var ___result = RInit.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetHandleInternal(Microsoft.Win32.SafeHandles.SafeWaitHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RSetHandleInternal_SafeWaitHandle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean WaitOne(System.Int32 @millisecondsTimeout, System.Boolean @exitContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout, @exitContext};
            var ___result = RWaitOne_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean WaitOne(System.TimeSpan @timeout, System.Boolean @exitContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout, @exitContext};
            var ___result = RWaitOne_TimeSpan_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean WaitOne()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWaitOne.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean WaitOne(System.Int32 @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout};
            var ___result = RWaitOne_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean WaitOne(System.TimeSpan @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout};
            var ___result = RWaitOne_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean WaitOne(System.Int64 @timeout, System.Boolean @exitContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout, @exitContext};
            var ___result = RWaitOne_Int64_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean InternalWaitOne(System.Runtime.InteropServices.SafeHandle @waitableSafeHandle, System.Int64 @millisecondsTimeout, System.Boolean @hasThreadAffinity, System.Boolean @exitContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitableSafeHandle, @millisecondsTimeout, @hasThreadAffinity, @exitContext};
            var ___result = RInternalWaitOne_SafeHandle_Int64_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean WaitOneWithoutFAS()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWaitOneWithoutFAS.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean WaitAll(System.Threading.WaitHandle[] @waitHandles, System.Int32 @millisecondsTimeout, System.Boolean @exitContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitHandles, @millisecondsTimeout, @exitContext};
            var ___result = RWaitAll_WaitHandleArray_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean WaitAll(System.Threading.WaitHandle[] @waitHandles, System.TimeSpan @timeout, System.Boolean @exitContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitHandles, @timeout, @exitContext};
            var ___result = RWaitAll_WaitHandleArray_TimeSpan_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean WaitAll(System.Threading.WaitHandle[] @waitHandles)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitHandles};
            var ___result = RWaitAll_WaitHandleArray.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean WaitAll(System.Threading.WaitHandle[] @waitHandles, System.Int32 @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitHandles, @millisecondsTimeout};
            var ___result = RWaitAll_WaitHandleArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean WaitAll(System.Threading.WaitHandle[] @waitHandles, System.TimeSpan @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitHandles, @timeout};
            var ___result = RWaitAll_WaitHandleArray_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Int32 WaitAny(System.Threading.WaitHandle[] @waitHandles, System.Int32 @millisecondsTimeout, System.Boolean @exitContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitHandles, @millisecondsTimeout, @exitContext};
            var ___result = RWaitAny_WaitHandleArray_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 WaitAny(System.Threading.WaitHandle[] @waitHandles, System.TimeSpan @timeout, System.Boolean @exitContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitHandles, @timeout, @exitContext};
            var ___result = RWaitAny_WaitHandleArray_TimeSpan_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 WaitAny(System.Threading.WaitHandle[] @waitHandles, System.TimeSpan @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitHandles, @timeout};
            var ___result = RWaitAny_WaitHandleArray_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 WaitAny(System.Threading.WaitHandle[] @waitHandles)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitHandles};
            var ___result = RWaitAny_WaitHandleArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 WaitAny(System.Threading.WaitHandle[] @waitHandles, System.Int32 @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitHandles, @millisecondsTimeout};
            var ___result = RWaitAny_WaitHandleArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean SignalAndWait(System.Threading.WaitHandle @toSignal, System.Threading.WaitHandle @toWaitOn)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@toSignal, @toWaitOn};
            var ___result = RSignalAndWait_WaitHandle_WaitHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean SignalAndWait(System.Threading.WaitHandle @toSignal, System.Threading.WaitHandle @toWaitOn, System.TimeSpan @timeout, System.Boolean @exitContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@toSignal, @toWaitOn, @timeout, @exitContext};
            var ___result = RSignalAndWait_WaitHandle_WaitHandle_TimeSpan_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean SignalAndWait(System.Threading.WaitHandle @toSignal, System.Threading.WaitHandle @toWaitOn, System.Int32 @millisecondsTimeout, System.Boolean @exitContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@toSignal, @toWaitOn, @millisecondsTimeout, @exitContext};
            var ___result = RSignalAndWait_WaitHandle_WaitHandle_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void ThrowAbandonedMutexException()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RThrowAbandonedMutexException.Invoke(___genericsType, ___parameters);

            
        }


        public static void ThrowAbandonedMutexException(System.Int32 @location, System.Threading.WaitHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@location, @handle};
            var ___result = RThrowAbandonedMutexException_Int32_WaitHandle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean @explicitDisposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@explicitDisposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 WaitOneNative(System.Runtime.InteropServices.SafeHandle @waitableSafeHandle, System.UInt32 @millisecondsTimeout, System.Boolean @hasThreadAffinity, System.Boolean @exitContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitableSafeHandle, @millisecondsTimeout, @hasThreadAffinity, @exitContext};
            var ___result = RWaitOneNative_SafeHandle_UInt32_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 WaitMultiple(System.Threading.WaitHandle[] @waitHandles, System.Int32 @millisecondsTimeout, System.Boolean @exitContext, System.Boolean @WaitAll)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitHandles, @millisecondsTimeout, @exitContext, @WaitAll};
            var ___result = RWaitMultiple_WaitHandleArray_Int32_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe static System.Int32 Wait_internal(System.IntPtr* @handles, System.Int32 @numHandles, System.Boolean @waitAll, System.Int32 @ms)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@handles, typeof(System.IntPtr)), @numHandles, @waitAll, @ms};
            var ___result = RWait_internal_IntPtrPointer_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 SignalAndWaitOne(Microsoft.Win32.SafeHandles.SafeWaitHandle @waitHandleToSignal, Microsoft.Win32.SafeHandles.SafeWaitHandle @waitHandleToWaitOn, System.Int32 @millisecondsTimeout, System.Boolean @hasThreadAffinity, System.Boolean @exitContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitHandleToSignal, @waitHandleToWaitOn, @millisecondsTimeout, @hasThreadAffinity, @exitContext};
            var ___result = RSignalAndWaitOne_SafeWaitHandle_SafeWaitHandle_Int32_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 SignalAndWait_Internal(System.IntPtr @toSignal, System.IntPtr @toWaitOn, System.Int32 @ms)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@toSignal, @toWaitOn, @ms};
            var ___result = RSignalAndWait_Internal_IntPtr_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 ToTimeoutMilliseconds(System.TimeSpan @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout};
            var ___result = RToTimeoutMilliseconds_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual RSystem.RRuntime.RRemoting.RIdentity GetObjectIdentity(System.MarshalByRefObject @obj, out System.Boolean @IsClient)
        {
			@IsClient = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @IsClient};
            var ___result = RGetObjectIdentity_MarshalByRefObject_Out_Boolean.Invoke(___genericsType, ___parameters);
			@IsClient = (System.Boolean)___parameters[1];

            return new RSystem.RRuntime.RRemoting.RIdentity(___result);
        }


        public virtual System.Runtime.Remoting.ObjRef CreateObjRef(System.Type @requestedType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@requestedType};
            var ___result = RCreateObjRef_Type.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjRef)___result;
        }


        public virtual System.Object GetLifetimeService()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLifetimeService.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object InitializeLifetimeService()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitializeLifetimeService.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.MarshalByRefObject MemberwiseClone(System.Boolean @cloneIdentity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cloneIdentity};
            var ___result = RMemberwiseClone_Boolean.Invoke(___genericsType, ___parameters);

            return (System.MarshalByRefObject)___result;
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
