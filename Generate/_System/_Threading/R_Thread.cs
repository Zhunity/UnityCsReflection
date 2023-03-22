
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.Thread
	/// </summary>
    public partial class RThread : RMember //
    {

		/// <summary>
		/// System.LocalDataStoreMgr s_LocalDataStoreMgr
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RLocalDataStoreMgr r_Fs_LocalDataStoreMgr;
		public static Hvak.Editor.Refleaction.RSystem.RLocalDataStoreMgr RFs_LocalDataStoreMgr
		{
			get
			{
				if(r_Fs_LocalDataStoreMgr == null)
				{
					r_Fs_LocalDataStoreMgr = new(typeof(System.Threading.Thread), "s_LocalDataStoreMgr");
				}
				return r_Fs_LocalDataStoreMgr;
			}
		}

		/// <summary>
		/// System.LocalDataStoreHolder s_LocalDataStore
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RLocalDataStoreHolder r_Fs_LocalDataStore;
		public static Hvak.Editor.Refleaction.RSystem.RLocalDataStoreHolder RFs_LocalDataStore
		{
			get
			{
				if(r_Fs_LocalDataStore == null)
				{
					r_Fs_LocalDataStore = new(typeof(System.Threading.Thread), "s_LocalDataStore");
				}
				return r_Fs_LocalDataStore;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo m_CurrentCulture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo r_Fm_CurrentCulture;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo RFm_CurrentCulture
		{
			get
			{
				if(r_Fm_CurrentCulture == null)
				{
					r_Fm_CurrentCulture = new(typeof(System.Threading.Thread), "m_CurrentCulture");
				}
				return r_Fm_CurrentCulture;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo m_CurrentUICulture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo r_Fm_CurrentUICulture;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo RFm_CurrentUICulture
		{
			get
			{
				if(r_Fm_CurrentUICulture == null)
				{
					r_Fm_CurrentUICulture = new(typeof(System.Threading.Thread), "m_CurrentUICulture");
				}
				return r_Fm_CurrentUICulture;
			}
		}

		/// <summary>
		/// System.Threading.AsyncLocal`1[System.Globalization.CultureInfo] s_asyncLocalCurrentCulture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RAsyncLocal<Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo> r_Fs_asyncLocalCurrentCulture;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RAsyncLocal<Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo> RFs_asyncLocalCurrentCulture
		{
			get
			{
				if(r_Fs_asyncLocalCurrentCulture == null)
				{
					r_Fs_asyncLocalCurrentCulture = new(typeof(System.Threading.Thread), "s_asyncLocalCurrentCulture");
				}
				return r_Fs_asyncLocalCurrentCulture;
			}
		}

		/// <summary>
		/// System.Threading.AsyncLocal`1[System.Globalization.CultureInfo] s_asyncLocalCurrentUICulture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RAsyncLocal<Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo> r_Fs_asyncLocalCurrentUICulture;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RAsyncLocal<Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo> RFs_asyncLocalCurrentUICulture
		{
			get
			{
				if(r_Fs_asyncLocalCurrentUICulture == null)
				{
					r_Fs_asyncLocalCurrentUICulture = new(typeof(System.Threading.Thread), "s_asyncLocalCurrentUICulture");
				}
				return r_Fs_asyncLocalCurrentUICulture;
			}
		}

		/// <summary>
		/// System.Threading.InternalThread internal_thread
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RInternalThread r_Finternal_thread;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RInternalThread RFinternal_thread
		{
			get
			{
				if(r_Finternal_thread == null)
				{
					r_Finternal_thread = new(this, "internal_thread");
				}
				return r_Finternal_thread;
			}
		}

		/// <summary>
		/// System.Object m_ThreadStartArg
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_Fm_ThreadStartArg;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RFm_ThreadStartArg
		{
			get
			{
				if(r_Fm_ThreadStartArg == null)
				{
					r_Fm_ThreadStartArg = new(this, "m_ThreadStartArg");
				}
				return r_Fm_ThreadStartArg;
			}
		}

		/// <summary>
		/// System.Object pending_exception
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_Fpending_exception;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RFpending_exception
		{
			get
			{
				if(r_Fpending_exception == null)
				{
					r_Fpending_exception = new(this, "pending_exception");
				}
				return r_Fpending_exception;
			}
		}

		/// <summary>
		/// System.Threading.Thread current_thread
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RThread r_Fcurrent_thread;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RThread RFcurrent_thread
		{
			get
			{
				if(r_Fcurrent_thread == null)
				{
					r_Fcurrent_thread = new(typeof(System.Threading.Thread), "current_thread");
				}
				return r_Fcurrent_thread;
			}
		}

		/// <summary>
		/// System.MulticastDelegate m_Delegate
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RMulticastDelegate r_Fm_Delegate;
		public virtual Hvak.Editor.Refleaction.RSystem.RMulticastDelegate RFm_Delegate
		{
			get
			{
				if(r_Fm_Delegate == null)
				{
					r_Fm_Delegate = new(this, "m_Delegate");
				}
				return r_Fm_Delegate;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext m_ExecutionContext
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RExecutionContext r_Fm_ExecutionContext;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RExecutionContext RFm_ExecutionContext
		{
			get
			{
				if(r_Fm_ExecutionContext == null)
				{
					r_Fm_ExecutionContext = new(this, "m_ExecutionContext");
				}
				return r_Fm_ExecutionContext;
			}
		}

		/// <summary>
		/// System.Boolean m_ExecutionContextBelongsToOuterScope
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_ExecutionContextBelongsToOuterScope;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_ExecutionContextBelongsToOuterScope
		{
			get
			{
				if(r_Fm_ExecutionContextBelongsToOuterScope == null)
				{
					r_Fm_ExecutionContextBelongsToOuterScope = new(this, "m_ExecutionContextBelongsToOuterScope");
				}
				return r_Fm_ExecutionContextBelongsToOuterScope;
			}
		}

		/// <summary>
		/// System.Security.Principal.IPrincipal principal
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RIPrincipal r_Fprincipal;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RIPrincipal RFprincipal
		{
			get
			{
				if(r_Fprincipal == null)
				{
					r_Fprincipal = new(this, "principal");
				}
				return r_Fprincipal;
			}
		}

		/// <summary>
		/// System.Int32 principal_version
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fprincipal_version;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFprincipal_version
		{
			get
			{
				if(r_Fprincipal_version == null)
				{
					r_Fprincipal_version = new(this, "principal_version");
				}
				return r_Fprincipal_version;
			}
		}

		/// <summary>
		/// Boolean ExecutionContextBelongsToCurrentScope
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PExecutionContextBelongsToCurrentScope;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPExecutionContextBelongsToCurrentScope
		{
			get
			{
				if(r_PExecutionContextBelongsToCurrentScope == null)
				{
					r_PExecutionContextBelongsToCurrentScope = new(this, "ExecutionContextBelongsToCurrentScope", -1);
				}
				return r_PExecutionContextBelongsToCurrentScope;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext ExecutionContext
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RExecutionContext r_PExecutionContext;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RExecutionContext RPExecutionContext
		{
			get
			{
				if(r_PExecutionContext == null)
				{
					r_PExecutionContext = new(this, "ExecutionContext", -1);
				}
				return r_PExecutionContext;
			}
		}

		/// <summary>
		/// System.Threading.ThreadPriority Priority
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RThreadPriority r_PPriority;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RThreadPriority RPPriority
		{
			get
			{
				if(r_PPriority == null)
				{
					r_PPriority = new(this, "Priority", -1);
				}
				return r_PPriority;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo CurrentUICulture
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo r_PCurrentUICulture;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo RPCurrentUICulture
		{
			get
			{
				if(r_PCurrentUICulture == null)
				{
					r_PCurrentUICulture = new(this, "CurrentUICulture", -1);
				}
				return r_PCurrentUICulture;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo CurrentCulture
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo r_PCurrentCulture;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo RPCurrentCulture
		{
			get
			{
				if(r_PCurrentCulture == null)
				{
					r_PCurrentCulture = new(this, "CurrentCulture", -1);
				}
				return r_PCurrentCulture;
			}
		}

		/// <summary>
		/// System.LocalDataStoreMgr LocalDataStoreManager
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RLocalDataStoreMgr r_PLocalDataStoreManager;
		public static Hvak.Editor.Refleaction.RSystem.RLocalDataStoreMgr RPLocalDataStoreManager
		{
			get
			{
				if(r_PLocalDataStoreManager == null)
				{
					r_PLocalDataStoreManager = new(typeof(System.Threading.Thread), "LocalDataStoreManager", -1);
				}
				return r_PLocalDataStoreManager;
			}
		}

		/// <summary>
		/// System.Threading.InternalThread Internal
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RInternalThread r_PInternal;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RInternalThread RPInternal
		{
			get
			{
				if(r_PInternal == null)
				{
					r_PInternal = new(this, "Internal", -1);
				}
				return r_PInternal;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.Context CurrentContext
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RContexts.RContext r_PCurrentContext;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RContexts.RContext RPCurrentContext
		{
			get
			{
				if(r_PCurrentContext == null)
				{
					r_PCurrentContext = new(typeof(System.Threading.Thread), "CurrentContext", -1);
				}
				return r_PCurrentContext;
			}
		}

		/// <summary>
		/// System.Security.Principal.IPrincipal CurrentPrincipal
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RIPrincipal r_PCurrentPrincipal;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RIPrincipal RPCurrentPrincipal
		{
			get
			{
				if(r_PCurrentPrincipal == null)
				{
					r_PCurrentPrincipal = new(typeof(System.Threading.Thread), "CurrentPrincipal", -1);
				}
				return r_PCurrentPrincipal;
			}
		}

		/// <summary>
		/// System.Threading.Thread CurrentThread
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RThread r_PCurrentThread;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RThread RPCurrentThread
		{
			get
			{
				if(r_PCurrentThread == null)
				{
					r_PCurrentThread = new(typeof(System.Threading.Thread), "CurrentThread", -1);
				}
				return r_PCurrentThread;
			}
		}

		/// <summary>
		/// Int32 CurrentThreadId
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_PCurrentThreadId;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RPCurrentThreadId
		{
			get
			{
				if(r_PCurrentThreadId == null)
				{
					r_PCurrentThreadId = new(typeof(System.Threading.Thread), "CurrentThreadId", -1);
				}
				return r_PCurrentThreadId;
			}
		}

		/// <summary>
		/// System.Threading.ApartmentState ApartmentState
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RApartmentState r_PApartmentState;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RApartmentState RPApartmentState
		{
			get
			{
				if(r_PApartmentState == null)
				{
					r_PApartmentState = new(this, "ApartmentState", -1);
				}
				return r_PApartmentState;
			}
		}

		/// <summary>
		/// Boolean IsThreadPoolThread
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsThreadPoolThread;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsThreadPoolThread
		{
			get
			{
				if(r_PIsThreadPoolThread == null)
				{
					r_PIsThreadPoolThread = new(this, "IsThreadPoolThread", -1);
				}
				return r_PIsThreadPoolThread;
			}
		}

		/// <summary>
		/// Boolean IsThreadPoolThreadInternal
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsThreadPoolThreadInternal;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsThreadPoolThreadInternal
		{
			get
			{
				if(r_PIsThreadPoolThreadInternal == null)
				{
					r_PIsThreadPoolThreadInternal = new(this, "IsThreadPoolThreadInternal", -1);
				}
				return r_PIsThreadPoolThreadInternal;
			}
		}

		/// <summary>
		/// Boolean IsAlive
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsAlive;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsAlive
		{
			get
			{
				if(r_PIsAlive == null)
				{
					r_PIsAlive = new(this, "IsAlive", -1);
				}
				return r_PIsAlive;
			}
		}

		/// <summary>
		/// Boolean IsBackground
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsBackground;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsBackground
		{
			get
			{
				if(r_PIsBackground == null)
				{
					r_PIsBackground = new(this, "IsBackground", -1);
				}
				return r_PIsBackground;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPName
		{
			get
			{
				if(r_PName == null)
				{
					r_PName = new(this, "Name", -1);
				}
				return r_PName;
			}
		}

		/// <summary>
		/// System.Threading.ThreadState ThreadState
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RThreadState r_PThreadState;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RThreadState RPThreadState
		{
			get
			{
				if(r_PThreadState == null)
				{
					r_PThreadState = new(this, "ThreadState", -1);
				}
				return r_PThreadState;
			}
		}

		/// <summary>
		/// System.Object AbortReason
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PAbortReason;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPAbortReason
		{
			get
			{
				if(r_PAbortReason == null)
				{
					r_PAbortReason = new(this, "AbortReason", -1);
				}
				return r_PAbortReason;
			}
		}

		/// <summary>
		/// Int32 ManagedThreadId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PManagedThreadId;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPManagedThreadId
		{
			get
			{
				if(r_PManagedThreadId == null)
				{
					r_PManagedThreadId = new(this, "ManagedThreadId", -1);
				}
				return r_PManagedThreadId;
			}
		}

		/// <summary>
		/// Void AsyncLocalSetCurrentCulture(System.Threading.AsyncLocalValueChangedArgs`1[System.Globalization.CultureInfo])
		/// </summary>
		protected static RMethod r_MAsyncLocalSetCurrentCulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_;
		public static RMethod RMAsyncLocalSetCurrentCulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_
		{
			get
			{
				if(r_MAsyncLocalSetCurrentCulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_ == null)
				{
					r_MAsyncLocalSetCurrentCulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_ = new(typeof(System.Threading.Thread), "AsyncLocalSetCurrentCulture", 0, typeof(System.Threading.AsyncLocalValueChangedArgs<>).MakeGenericType(typeof(System.Globalization.CultureInfo)));
				}
				return r_MAsyncLocalSetCurrentCulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_;
			}
		}

		/// <summary>
		/// Void AsyncLocalSetCurrentUICulture(System.Threading.AsyncLocalValueChangedArgs`1[System.Globalization.CultureInfo])
		/// </summary>
		protected static RMethod r_MAsyncLocalSetCurrentUICulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_;
		public static RMethod RMAsyncLocalSetCurrentUICulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_
		{
			get
			{
				if(r_MAsyncLocalSetCurrentUICulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_ == null)
				{
					r_MAsyncLocalSetCurrentUICulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_ = new(typeof(System.Threading.Thread), "AsyncLocalSetCurrentUICulture", 0, typeof(System.Threading.AsyncLocalValueChangedArgs<>).MakeGenericType(typeof(System.Globalization.CultureInfo)));
				}
				return r_MAsyncLocalSetCurrentUICulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_;
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
		/// Void Start(System.Object)
		/// </summary>
		protected RMethod r_MStart_Object;
		public virtual RMethod RMStart_Object
		{
			get
			{
				if(r_MStart_Object == null)
				{
					r_MStart_Object = new(this, "Start", 0, typeof(System.Object));
				}
				return r_MStart_Object;
			}
		}

		/// <summary>
		/// Void Start(System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected RMethod r_MStart_Ref_StackCrawlMark;
		public virtual RMethod RMStart_Ref_StackCrawlMark
		{
			get
			{
				if(r_MStart_Ref_StackCrawlMark == null)
				{
					r_MStart_Ref_StackCrawlMark = new(this, "Start", 0,  ReflectionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
				}
				return r_MStart_Ref_StackCrawlMark;
			}
		}

		/// <summary>
		/// Reader GetExecutionContextReader()
		/// </summary>
		protected RMethod r_MGetExecutionContextReader;
		public virtual RMethod RMGetExecutionContextReader
		{
			get
			{
				if(r_MGetExecutionContextReader == null)
				{
					r_MGetExecutionContextReader = new(this, "GetExecutionContextReader", 0);
				}
				return r_MGetExecutionContextReader;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext GetMutableExecutionContext()
		/// </summary>
		protected RMethod r_MGetMutableExecutionContext;
		public virtual RMethod RMGetMutableExecutionContext
		{
			get
			{
				if(r_MGetMutableExecutionContext == null)
				{
					r_MGetMutableExecutionContext = new(this, "GetMutableExecutionContext", 0);
				}
				return r_MGetMutableExecutionContext;
			}
		}

		/// <summary>
		/// Void SetExecutionContext(System.Threading.ExecutionContext, Boolean)
		/// </summary>
		protected RMethod r_MSetExecutionContext_ExecutionContext_Boolean;
		public virtual RMethod RMSetExecutionContext_ExecutionContext_Boolean
		{
			get
			{
				if(r_MSetExecutionContext_ExecutionContext_Boolean == null)
				{
					r_MSetExecutionContext_ExecutionContext_Boolean = new(this, "SetExecutionContext", 0, typeof(System.Threading.ExecutionContext), typeof(System.Boolean));
				}
				return r_MSetExecutionContext_ExecutionContext_Boolean;
			}
		}

		/// <summary>
		/// Void SetExecutionContext(Reader, Boolean)
		/// </summary>
		protected RMethod r_MSetExecutionContext_Reader_Boolean;
		public virtual RMethod RMSetExecutionContext_Reader_Boolean
		{
			get
			{
				if(r_MSetExecutionContext_Reader_Boolean == null)
				{
					r_MSetExecutionContext_Reader_Boolean = new(this, "SetExecutionContext", 0,  ReflectionUtils.GetType("System.Threading.ExecutionContext+Reader"), typeof(System.Boolean));
				}
				return r_MSetExecutionContext_Reader_Boolean;
			}
		}

		/// <summary>
		/// Void SetCompressedStack(System.Threading.CompressedStack)
		/// </summary>
		protected RMethod r_MSetCompressedStack_CompressedStack;
		public virtual RMethod RMSetCompressedStack_CompressedStack
		{
			get
			{
				if(r_MSetCompressedStack_CompressedStack == null)
				{
					r_MSetCompressedStack_CompressedStack = new(this, "SetCompressedStack", 0, typeof(System.Threading.CompressedStack));
				}
				return r_MSetCompressedStack_CompressedStack;
			}
		}

		/// <summary>
		/// System.Threading.CompressedStack GetCompressedStack()
		/// </summary>
		protected RMethod r_MGetCompressedStack;
		public virtual RMethod RMGetCompressedStack
		{
			get
			{
				if(r_MGetCompressedStack == null)
				{
					r_MGetCompressedStack = new(this, "GetCompressedStack", 0);
				}
				return r_MGetCompressedStack;
			}
		}

		/// <summary>
		/// Void ResetAbort()
		/// </summary>
		protected static RMethod r_MResetAbort;
		public static RMethod RMResetAbort
		{
			get
			{
				if(r_MResetAbort == null)
				{
					r_MResetAbort = new(typeof(System.Threading.Thread), "ResetAbort", 0);
				}
				return r_MResetAbort;
			}
		}

		/// <summary>
		/// Void ResetAbortNative()
		/// </summary>
		protected RMethod r_MResetAbortNative;
		public virtual RMethod RMResetAbortNative
		{
			get
			{
				if(r_MResetAbortNative == null)
				{
					r_MResetAbortNative = new(this, "ResetAbortNative", 0);
				}
				return r_MResetAbortNative;
			}
		}

		/// <summary>
		/// Void Suspend()
		/// </summary>
		protected RMethod r_MSuspend;
		public virtual RMethod RMSuspend
		{
			get
			{
				if(r_MSuspend == null)
				{
					r_MSuspend = new(this, "Suspend", 0);
				}
				return r_MSuspend;
			}
		}

		/// <summary>
		/// Void SuspendInternal()
		/// </summary>
		protected RMethod r_MSuspendInternal;
		public virtual RMethod RMSuspendInternal
		{
			get
			{
				if(r_MSuspendInternal == null)
				{
					r_MSuspendInternal = new(this, "SuspendInternal", 0);
				}
				return r_MSuspendInternal;
			}
		}

		/// <summary>
		/// Void Resume()
		/// </summary>
		protected RMethod r_MResume;
		public virtual RMethod RMResume
		{
			get
			{
				if(r_MResume == null)
				{
					r_MResume = new(this, "Resume", 0);
				}
				return r_MResume;
			}
		}

		/// <summary>
		/// Void ResumeInternal()
		/// </summary>
		protected RMethod r_MResumeInternal;
		public virtual RMethod RMResumeInternal
		{
			get
			{
				if(r_MResumeInternal == null)
				{
					r_MResumeInternal = new(this, "ResumeInternal", 0);
				}
				return r_MResumeInternal;
			}
		}

		/// <summary>
		/// Void Interrupt()
		/// </summary>
		protected RMethod r_MInterrupt;
		public virtual RMethod RMInterrupt
		{
			get
			{
				if(r_MInterrupt == null)
				{
					r_MInterrupt = new(this, "Interrupt", 0);
				}
				return r_MInterrupt;
			}
		}

		/// <summary>
		/// Void InterruptInternal()
		/// </summary>
		protected RMethod r_MInterruptInternal;
		public virtual RMethod RMInterruptInternal
		{
			get
			{
				if(r_MInterruptInternal == null)
				{
					r_MInterruptInternal = new(this, "InterruptInternal", 0);
				}
				return r_MInterruptInternal;
			}
		}

		/// <summary>
		/// Int32 GetPriorityNative()
		/// </summary>
		protected RMethod r_MGetPriorityNative;
		public virtual RMethod RMGetPriorityNative
		{
			get
			{
				if(r_MGetPriorityNative == null)
				{
					r_MGetPriorityNative = new(this, "GetPriorityNative", 0);
				}
				return r_MGetPriorityNative;
			}
		}

		/// <summary>
		/// Void SetPriorityNative(Int32)
		/// </summary>
		protected RMethod r_MSetPriorityNative_Int32;
		public virtual RMethod RMSetPriorityNative_Int32
		{
			get
			{
				if(r_MSetPriorityNative_Int32 == null)
				{
					r_MSetPriorityNative_Int32 = new(this, "SetPriorityNative", 0, typeof(System.Int32));
				}
				return r_MSetPriorityNative_Int32;
			}
		}

		/// <summary>
		/// Boolean JoinInternal(Int32)
		/// </summary>
		protected RMethod r_MJoinInternal_Int32;
		public virtual RMethod RMJoinInternal_Int32
		{
			get
			{
				if(r_MJoinInternal_Int32 == null)
				{
					r_MJoinInternal_Int32 = new(this, "JoinInternal", 0, typeof(System.Int32));
				}
				return r_MJoinInternal_Int32;
			}
		}

		/// <summary>
		/// Void Join()
		/// </summary>
		protected RMethod r_MJoin;
		public virtual RMethod RMJoin
		{
			get
			{
				if(r_MJoin == null)
				{
					r_MJoin = new(this, "Join", 0);
				}
				return r_MJoin;
			}
		}

		/// <summary>
		/// Boolean Join(Int32)
		/// </summary>
		protected RMethod r_MJoin_Int32;
		public virtual RMethod RMJoin_Int32
		{
			get
			{
				if(r_MJoin_Int32 == null)
				{
					r_MJoin_Int32 = new(this, "Join", 0, typeof(System.Int32));
				}
				return r_MJoin_Int32;
			}
		}

		/// <summary>
		/// Boolean Join(System.TimeSpan)
		/// </summary>
		protected RMethod r_MJoin_TimeSpan;
		public virtual RMethod RMJoin_TimeSpan
		{
			get
			{
				if(r_MJoin_TimeSpan == null)
				{
					r_MJoin_TimeSpan = new(this, "Join", 0, typeof(System.TimeSpan));
				}
				return r_MJoin_TimeSpan;
			}
		}

		/// <summary>
		/// Void SleepInternal(Int32)
		/// </summary>
		protected static RMethod r_MSleepInternal_Int32;
		public static RMethod RMSleepInternal_Int32
		{
			get
			{
				if(r_MSleepInternal_Int32 == null)
				{
					r_MSleepInternal_Int32 = new(typeof(System.Threading.Thread), "SleepInternal", 0, typeof(System.Int32));
				}
				return r_MSleepInternal_Int32;
			}
		}

		/// <summary>
		/// Void Sleep(Int32)
		/// </summary>
		protected static RMethod r_MSleep_Int32;
		public static RMethod RMSleep_Int32
		{
			get
			{
				if(r_MSleep_Int32 == null)
				{
					r_MSleep_Int32 = new(typeof(System.Threading.Thread), "Sleep", 0, typeof(System.Int32));
				}
				return r_MSleep_Int32;
			}
		}

		/// <summary>
		/// Void Sleep(System.TimeSpan)
		/// </summary>
		protected static RMethod r_MSleep_TimeSpan;
		public static RMethod RMSleep_TimeSpan
		{
			get
			{
				if(r_MSleep_TimeSpan == null)
				{
					r_MSleep_TimeSpan = new(typeof(System.Threading.Thread), "Sleep", 0, typeof(System.TimeSpan));
				}
				return r_MSleep_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean YieldInternal()
		/// </summary>
		protected static RMethod r_MYieldInternal;
		public static RMethod RMYieldInternal
		{
			get
			{
				if(r_MYieldInternal == null)
				{
					r_MYieldInternal = new(typeof(System.Threading.Thread), "YieldInternal", 0);
				}
				return r_MYieldInternal;
			}
		}

		/// <summary>
		/// Boolean Yield()
		/// </summary>
		protected static RMethod r_MYield;
		public static RMethod RMYield
		{
			get
			{
				if(r_MYield == null)
				{
					r_MYield = new(typeof(System.Threading.Thread), "Yield", 0);
				}
				return r_MYield;
			}
		}

		/// <summary>
		/// Void SetStartHelper(System.Delegate, Int32)
		/// </summary>
		protected RMethod r_MSetStartHelper_Delegate_Int32;
		public virtual RMethod RMSetStartHelper_Delegate_Int32
		{
			get
			{
				if(r_MSetStartHelper_Delegate_Int32 == null)
				{
					r_MSetStartHelper_Delegate_Int32 = new(this, "SetStartHelper", 0, typeof(System.Delegate), typeof(System.Int32));
				}
				return r_MSetStartHelper_Delegate_Int32;
			}
		}

		/// <summary>
		/// System.LocalDataStoreSlot AllocateDataSlot()
		/// </summary>
		protected static RMethod r_MAllocateDataSlot;
		public static RMethod RMAllocateDataSlot
		{
			get
			{
				if(r_MAllocateDataSlot == null)
				{
					r_MAllocateDataSlot = new(typeof(System.Threading.Thread), "AllocateDataSlot", 0);
				}
				return r_MAllocateDataSlot;
			}
		}

		/// <summary>
		/// System.LocalDataStoreSlot AllocateNamedDataSlot(System.String)
		/// </summary>
		protected static RMethod r_MAllocateNamedDataSlot_String;
		public static RMethod RMAllocateNamedDataSlot_String
		{
			get
			{
				if(r_MAllocateNamedDataSlot_String == null)
				{
					r_MAllocateNamedDataSlot_String = new(typeof(System.Threading.Thread), "AllocateNamedDataSlot", 0, typeof(System.String));
				}
				return r_MAllocateNamedDataSlot_String;
			}
		}

		/// <summary>
		/// System.LocalDataStoreSlot GetNamedDataSlot(System.String)
		/// </summary>
		protected static RMethod r_MGetNamedDataSlot_String;
		public static RMethod RMGetNamedDataSlot_String
		{
			get
			{
				if(r_MGetNamedDataSlot_String == null)
				{
					r_MGetNamedDataSlot_String = new(typeof(System.Threading.Thread), "GetNamedDataSlot", 0, typeof(System.String));
				}
				return r_MGetNamedDataSlot_String;
			}
		}

		/// <summary>
		/// Void FreeNamedDataSlot(System.String)
		/// </summary>
		protected static RMethod r_MFreeNamedDataSlot_String;
		public static RMethod RMFreeNamedDataSlot_String
		{
			get
			{
				if(r_MFreeNamedDataSlot_String == null)
				{
					r_MFreeNamedDataSlot_String = new(typeof(System.Threading.Thread), "FreeNamedDataSlot", 0, typeof(System.String));
				}
				return r_MFreeNamedDataSlot_String;
			}
		}

		/// <summary>
		/// System.Object GetData(System.LocalDataStoreSlot)
		/// </summary>
		protected static RMethod r_MGetData_LocalDataStoreSlot;
		public static RMethod RMGetData_LocalDataStoreSlot
		{
			get
			{
				if(r_MGetData_LocalDataStoreSlot == null)
				{
					r_MGetData_LocalDataStoreSlot = new(typeof(System.Threading.Thread), "GetData", 0, typeof(System.LocalDataStoreSlot));
				}
				return r_MGetData_LocalDataStoreSlot;
			}
		}

		/// <summary>
		/// Void SetData(System.LocalDataStoreSlot, System.Object)
		/// </summary>
		protected static RMethod r_MSetData_LocalDataStoreSlot_Object;
		public static RMethod RMSetData_LocalDataStoreSlot_Object
		{
			get
			{
				if(r_MSetData_LocalDataStoreSlot_Object == null)
				{
					r_MSetData_LocalDataStoreSlot_Object = new(typeof(System.Threading.Thread), "SetData", 0, typeof(System.LocalDataStoreSlot), typeof(System.Object));
				}
				return r_MSetData_LocalDataStoreSlot_Object;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo GetCurrentUICultureNoAppX()
		/// </summary>
		protected RMethod r_MGetCurrentUICultureNoAppX;
		public virtual RMethod RMGetCurrentUICultureNoAppX
		{
			get
			{
				if(r_MGetCurrentUICultureNoAppX == null)
				{
					r_MGetCurrentUICultureNoAppX = new(this, "GetCurrentUICultureNoAppX", 0);
				}
				return r_MGetCurrentUICultureNoAppX;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo GetCurrentCultureNoAppX()
		/// </summary>
		protected RMethod r_MGetCurrentCultureNoAppX;
		public virtual RMethod RMGetCurrentCultureNoAppX
		{
			get
			{
				if(r_MGetCurrentCultureNoAppX == null)
				{
					r_MGetCurrentCultureNoAppX = new(this, "GetCurrentCultureNoAppX", 0);
				}
				return r_MGetCurrentCultureNoAppX;
			}
		}

		/// <summary>
		/// Void nativeInitCultureAccessors()
		/// </summary>
		protected static RMethod r_MnativeInitCultureAccessors;
		public static RMethod RMnativeInitCultureAccessors
		{
			get
			{
				if(r_MnativeInitCultureAccessors == null)
				{
					r_MnativeInitCultureAccessors = new(typeof(System.Threading.Thread), "nativeInitCultureAccessors", 0);
				}
				return r_MnativeInitCultureAccessors;
			}
		}

		/// <summary>
		/// Void MemoryBarrier()
		/// </summary>
		protected static RMethod r_MMemoryBarrier;
		public static RMethod RMMemoryBarrier
		{
			get
			{
				if(r_MMemoryBarrier == null)
				{
					r_MMemoryBarrier = new(typeof(System.Threading.Thread), "MemoryBarrier", 0);
				}
				return r_MMemoryBarrier;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._Thread.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___Thread__2__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___Thread__2__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___Thread__2__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___Thread__2__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._Thread.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___Thread__2__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._Thread.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___Thread__2__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___Thread__2__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___Thread__2__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___Thread__2__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._Thread.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___Thread__2__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._Thread.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___Thread__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___Thread__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___Thread__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___Thread__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._Thread.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___Thread__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._Thread.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___Thread__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___Thread__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___Thread__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___Thread__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._Thread.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___Thread__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// Void ConstructInternalThread()
		/// </summary>
		protected RMethod r_MConstructInternalThread;
		public virtual RMethod RMConstructInternalThread
		{
			get
			{
				if(r_MConstructInternalThread == null)
				{
					r_MConstructInternalThread = new(this, "ConstructInternalThread", 0);
				}
				return r_MConstructInternalThread;
			}
		}

		/// <summary>
		/// Byte[] ByteArrayToRootDomain(Byte[])
		/// </summary>
		protected static RMethod r_MByteArrayToRootDomain_ByteArray;
		public static RMethod RMByteArrayToRootDomain_ByteArray
		{
			get
			{
				if(r_MByteArrayToRootDomain_ByteArray == null)
				{
					r_MByteArrayToRootDomain_ByteArray = new(typeof(System.Threading.Thread), "ByteArrayToRootDomain", 0, typeof(System.Byte).MakeArrayType());
				}
				return r_MByteArrayToRootDomain_ByteArray;
			}
		}

		/// <summary>
		/// Byte[] ByteArrayToCurrentDomain(Byte[])
		/// </summary>
		protected static RMethod r_MByteArrayToCurrentDomain_ByteArray;
		public static RMethod RMByteArrayToCurrentDomain_ByteArray
		{
			get
			{
				if(r_MByteArrayToCurrentDomain_ByteArray == null)
				{
					r_MByteArrayToCurrentDomain_ByteArray = new(typeof(System.Threading.Thread), "ByteArrayToCurrentDomain", 0, typeof(System.Byte).MakeArrayType());
				}
				return r_MByteArrayToCurrentDomain_ByteArray;
			}
		}

		/// <summary>
		/// Void DeserializePrincipal(System.Threading.Thread)
		/// </summary>
		protected static RMethod r_MDeserializePrincipal_Thread;
		public static RMethod RMDeserializePrincipal_Thread
		{
			get
			{
				if(r_MDeserializePrincipal_Thread == null)
				{
					r_MDeserializePrincipal_Thread = new(typeof(System.Threading.Thread), "DeserializePrincipal", 0, typeof(System.Threading.Thread));
				}
				return r_MDeserializePrincipal_Thread;
			}
		}

		/// <summary>
		/// Void SerializePrincipal(System.Threading.Thread, System.Security.Principal.IPrincipal)
		/// </summary>
		protected static RMethod r_MSerializePrincipal_Thread_IPrincipal;
		public static RMethod RMSerializePrincipal_Thread_IPrincipal
		{
			get
			{
				if(r_MSerializePrincipal_Thread_IPrincipal == null)
				{
					r_MSerializePrincipal_Thread_IPrincipal = new(typeof(System.Threading.Thread), "SerializePrincipal", 0, typeof(System.Threading.Thread), typeof(System.Security.Principal.IPrincipal));
				}
				return r_MSerializePrincipal_Thread_IPrincipal;
			}
		}

		/// <summary>
		/// System.AppDomain GetDomain()
		/// </summary>
		protected static RMethod r_MGetDomain;
		public static RMethod RMGetDomain
		{
			get
			{
				if(r_MGetDomain == null)
				{
					r_MGetDomain = new(typeof(System.Threading.Thread), "GetDomain", 0);
				}
				return r_MGetDomain;
			}
		}

		/// <summary>
		/// Void GetCurrentThread_icall(System.Threading.Thread ByRef)
		/// </summary>
		protected static RMethod r_MGetCurrentThread_icall_Ref_Thread;
		public static RMethod RMGetCurrentThread_icall_Ref_Thread
		{
			get
			{
				if(r_MGetCurrentThread_icall_Ref_Thread == null)
				{
					r_MGetCurrentThread_icall_Ref_Thread = new(typeof(System.Threading.Thread), "GetCurrentThread_icall", 0, typeof(System.Threading.Thread).MakeByRefType());
				}
				return r_MGetCurrentThread_icall_Ref_Thread;
			}
		}

		/// <summary>
		/// System.Threading.Thread GetCurrentThread()
		/// </summary>
		protected static RMethod r_MGetCurrentThread;
		public static RMethod RMGetCurrentThread
		{
			get
			{
				if(r_MGetCurrentThread == null)
				{
					r_MGetCurrentThread = new(typeof(System.Threading.Thread), "GetCurrentThread", 0);
				}
				return r_MGetCurrentThread;
			}
		}

		/// <summary>
		/// Int32 GetDomainID()
		/// </summary>
		protected static RMethod r_MGetDomainID;
		public static RMethod RMGetDomainID
		{
			get
			{
				if(r_MGetDomainID == null)
				{
					r_MGetDomainID = new(typeof(System.Threading.Thread), "GetDomainID", 0);
				}
				return r_MGetDomainID;
			}
		}

		/// <summary>
		/// Boolean Thread_internal(System.MulticastDelegate)
		/// </summary>
		protected RMethod r_MThread_internal_MulticastDelegate;
		public virtual RMethod RMThread_internal_MulticastDelegate
		{
			get
			{
				if(r_MThread_internal_MulticastDelegate == null)
				{
					r_MThread_internal_MulticastDelegate = new(this, "Thread_internal", 0, typeof(System.MulticastDelegate));
				}
				return r_MThread_internal_MulticastDelegate;
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
		/// System.String GetName_internal(System.Threading.InternalThread)
		/// </summary>
		protected static RMethod r_MGetName_internal_InternalThread;
		public static RMethod RMGetName_internal_InternalThread
		{
			get
			{
				if(r_MGetName_internal_InternalThread == null)
				{
					r_MGetName_internal_InternalThread = new(typeof(System.Threading.Thread), "GetName_internal", 0,  ReflectionUtils.GetType("System.Threading.InternalThread"));
				}
				return r_MGetName_internal_InternalThread;
			}
		}

		/// <summary>
		/// Void SetName_icall(System.Threading.InternalThread, Char*, Int32)
		/// </summary>
		protected static RMethod r_MSetName_icall_InternalThread_CharPointer_Int32;
		public static RMethod RMSetName_icall_InternalThread_CharPointer_Int32
		{
			get
			{
				if(r_MSetName_icall_InternalThread_CharPointer_Int32 == null)
				{
					r_MSetName_icall_InternalThread_CharPointer_Int32 = new(typeof(System.Threading.Thread), "SetName_icall", 0,  ReflectionUtils.GetType("System.Threading.InternalThread"), typeof(System.Char).MakePointerType(), typeof(System.Int32));
				}
				return r_MSetName_icall_InternalThread_CharPointer_Int32;
			}
		}

		/// <summary>
		/// Void SetName_internal(System.Threading.InternalThread, System.String)
		/// </summary>
		protected static RMethod r_MSetName_internal_InternalThread_String;
		public static RMethod RMSetName_internal_InternalThread_String
		{
			get
			{
				if(r_MSetName_internal_InternalThread_String == null)
				{
					r_MSetName_internal_InternalThread_String = new(typeof(System.Threading.Thread), "SetName_internal", 0,  ReflectionUtils.GetType("System.Threading.InternalThread"), typeof(System.String));
				}
				return r_MSetName_internal_InternalThread_String;
			}
		}

		/// <summary>
		/// Void Abort_internal(System.Threading.InternalThread, System.Object)
		/// </summary>
		protected static RMethod r_MAbort_internal_InternalThread_Object;
		public static RMethod RMAbort_internal_InternalThread_Object
		{
			get
			{
				if(r_MAbort_internal_InternalThread_Object == null)
				{
					r_MAbort_internal_InternalThread_Object = new(typeof(System.Threading.Thread), "Abort_internal", 0,  ReflectionUtils.GetType("System.Threading.InternalThread"), typeof(System.Object));
				}
				return r_MAbort_internal_InternalThread_Object;
			}
		}

		/// <summary>
		/// Void Abort()
		/// </summary>
		protected RMethod r_MAbort;
		public virtual RMethod RMAbort
		{
			get
			{
				if(r_MAbort == null)
				{
					r_MAbort = new(this, "Abort", 0);
				}
				return r_MAbort;
			}
		}

		/// <summary>
		/// Void Abort(System.Object)
		/// </summary>
		protected RMethod r_MAbort_Object;
		public virtual RMethod RMAbort_Object
		{
			get
			{
				if(r_MAbort_Object == null)
				{
					r_MAbort_Object = new(this, "Abort", 0, typeof(System.Object));
				}
				return r_MAbort_Object;
			}
		}

		/// <summary>
		/// System.Object GetAbortExceptionState()
		/// </summary>
		protected RMethod r_MGetAbortExceptionState;
		public virtual RMethod RMGetAbortExceptionState
		{
			get
			{
				if(r_MGetAbortExceptionState == null)
				{
					r_MGetAbortExceptionState = new(this, "GetAbortExceptionState", 0);
				}
				return r_MGetAbortExceptionState;
			}
		}

		/// <summary>
		/// Void ClearAbortReason()
		/// </summary>
		protected RMethod r_MClearAbortReason;
		public virtual RMethod RMClearAbortReason
		{
			get
			{
				if(r_MClearAbortReason == null)
				{
					r_MClearAbortReason = new(this, "ClearAbortReason", 0);
				}
				return r_MClearAbortReason;
			}
		}

		/// <summary>
		/// Void SpinWait_nop()
		/// </summary>
		protected static RMethod r_MSpinWait_nop;
		public static RMethod RMSpinWait_nop
		{
			get
			{
				if(r_MSpinWait_nop == null)
				{
					r_MSpinWait_nop = new(typeof(System.Threading.Thread), "SpinWait_nop", 0);
				}
				return r_MSpinWait_nop;
			}
		}

		/// <summary>
		/// Void SpinWait(Int32)
		/// </summary>
		protected static RMethod r_MSpinWait_Int32;
		public static RMethod RMSpinWait_Int32
		{
			get
			{
				if(r_MSpinWait_Int32 == null)
				{
					r_MSpinWait_Int32 = new(typeof(System.Threading.Thread), "SpinWait", 0, typeof(System.Int32));
				}
				return r_MSpinWait_Int32;
			}
		}

		/// <summary>
		/// Void StartInternal(System.Object, System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected RMethod r_MStartInternal_Object_Ref_StackCrawlMark;
		public virtual RMethod RMStartInternal_Object_Ref_StackCrawlMark
		{
			get
			{
				if(r_MStartInternal_Object_Ref_StackCrawlMark == null)
				{
					r_MStartInternal_Object_Ref_StackCrawlMark = new(this, "StartInternal", 0, typeof(System.Object),  ReflectionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
				}
				return r_MStartInternal_Object_Ref_StackCrawlMark;
			}
		}

		/// <summary>
		/// Void SetState(System.Threading.InternalThread, System.Threading.ThreadState)
		/// </summary>
		protected static RMethod r_MSetState_InternalThread_ThreadState;
		public static RMethod RMSetState_InternalThread_ThreadState
		{
			get
			{
				if(r_MSetState_InternalThread_ThreadState == null)
				{
					r_MSetState_InternalThread_ThreadState = new(typeof(System.Threading.Thread), "SetState", 0,  ReflectionUtils.GetType("System.Threading.InternalThread"), typeof(System.Threading.ThreadState));
				}
				return r_MSetState_InternalThread_ThreadState;
			}
		}

		/// <summary>
		/// Void ClrState(System.Threading.InternalThread, System.Threading.ThreadState)
		/// </summary>
		protected static RMethod r_MClrState_InternalThread_ThreadState;
		public static RMethod RMClrState_InternalThread_ThreadState
		{
			get
			{
				if(r_MClrState_InternalThread_ThreadState == null)
				{
					r_MClrState_InternalThread_ThreadState = new(typeof(System.Threading.Thread), "ClrState", 0,  ReflectionUtils.GetType("System.Threading.InternalThread"), typeof(System.Threading.ThreadState));
				}
				return r_MClrState_InternalThread_ThreadState;
			}
		}

		/// <summary>
		/// System.Threading.ThreadState GetState(System.Threading.InternalThread)
		/// </summary>
		protected static RMethod r_MGetState_InternalThread;
		public static RMethod RMGetState_InternalThread
		{
			get
			{
				if(r_MGetState_InternalThread == null)
				{
					r_MGetState_InternalThread = new(typeof(System.Threading.Thread), "GetState", 0,  ReflectionUtils.GetType("System.Threading.InternalThread"));
				}
				return r_MGetState_InternalThread;
			}
		}

		/// <summary>
		/// Byte VolatileRead(Byte ByRef)
		/// </summary>
		protected static RMethod r_MVolatileRead_Ref_Byte;
		public static RMethod RMVolatileRead_Ref_Byte
		{
			get
			{
				if(r_MVolatileRead_Ref_Byte == null)
				{
					r_MVolatileRead_Ref_Byte = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.Byte).MakeByRefType());
				}
				return r_MVolatileRead_Ref_Byte;
			}
		}

		/// <summary>
		/// Double VolatileRead(Double ByRef)
		/// </summary>
		protected static RMethod r_MVolatileRead_Ref_Double;
		public static RMethod RMVolatileRead_Ref_Double
		{
			get
			{
				if(r_MVolatileRead_Ref_Double == null)
				{
					r_MVolatileRead_Ref_Double = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.Double).MakeByRefType());
				}
				return r_MVolatileRead_Ref_Double;
			}
		}

		/// <summary>
		/// Int16 VolatileRead(Int16 ByRef)
		/// </summary>
		protected static RMethod r_MVolatileRead_Ref_Int16;
		public static RMethod RMVolatileRead_Ref_Int16
		{
			get
			{
				if(r_MVolatileRead_Ref_Int16 == null)
				{
					r_MVolatileRead_Ref_Int16 = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.Int16).MakeByRefType());
				}
				return r_MVolatileRead_Ref_Int16;
			}
		}

		/// <summary>
		/// Int32 VolatileRead(Int32 ByRef)
		/// </summary>
		protected static RMethod r_MVolatileRead_Ref_Int32;
		public static RMethod RMVolatileRead_Ref_Int32
		{
			get
			{
				if(r_MVolatileRead_Ref_Int32 == null)
				{
					r_MVolatileRead_Ref_Int32 = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.Int32).MakeByRefType());
				}
				return r_MVolatileRead_Ref_Int32;
			}
		}

		/// <summary>
		/// Int64 VolatileRead(Int64 ByRef)
		/// </summary>
		protected static RMethod r_MVolatileRead_Ref_Int64;
		public static RMethod RMVolatileRead_Ref_Int64
		{
			get
			{
				if(r_MVolatileRead_Ref_Int64 == null)
				{
					r_MVolatileRead_Ref_Int64 = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.Int64).MakeByRefType());
				}
				return r_MVolatileRead_Ref_Int64;
			}
		}

		/// <summary>
		/// IntPtr VolatileRead(IntPtr ByRef)
		/// </summary>
		protected static RMethod r_MVolatileRead_Ref_IntPtr;
		public static RMethod RMVolatileRead_Ref_IntPtr
		{
			get
			{
				if(r_MVolatileRead_Ref_IntPtr == null)
				{
					r_MVolatileRead_Ref_IntPtr = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.IntPtr).MakeByRefType());
				}
				return r_MVolatileRead_Ref_IntPtr;
			}
		}

		/// <summary>
		/// System.Object VolatileRead(System.Object ByRef)
		/// </summary>
		protected static RMethod r_MVolatileRead_Ref_Object;
		public static RMethod RMVolatileRead_Ref_Object
		{
			get
			{
				if(r_MVolatileRead_Ref_Object == null)
				{
					r_MVolatileRead_Ref_Object = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.Object).MakeByRefType());
				}
				return r_MVolatileRead_Ref_Object;
			}
		}

		/// <summary>
		/// SByte VolatileRead(SByte ByRef)
		/// </summary>
		protected static RMethod r_MVolatileRead_Ref_SByte;
		public static RMethod RMVolatileRead_Ref_SByte
		{
			get
			{
				if(r_MVolatileRead_Ref_SByte == null)
				{
					r_MVolatileRead_Ref_SByte = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.SByte).MakeByRefType());
				}
				return r_MVolatileRead_Ref_SByte;
			}
		}

		/// <summary>
		/// Single VolatileRead(Single ByRef)
		/// </summary>
		protected static RMethod r_MVolatileRead_Ref_Single;
		public static RMethod RMVolatileRead_Ref_Single
		{
			get
			{
				if(r_MVolatileRead_Ref_Single == null)
				{
					r_MVolatileRead_Ref_Single = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.Single).MakeByRefType());
				}
				return r_MVolatileRead_Ref_Single;
			}
		}

		/// <summary>
		/// UInt16 VolatileRead(UInt16 ByRef)
		/// </summary>
		protected static RMethod r_MVolatileRead_Ref_UInt16;
		public static RMethod RMVolatileRead_Ref_UInt16
		{
			get
			{
				if(r_MVolatileRead_Ref_UInt16 == null)
				{
					r_MVolatileRead_Ref_UInt16 = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.UInt16).MakeByRefType());
				}
				return r_MVolatileRead_Ref_UInt16;
			}
		}

		/// <summary>
		/// UInt32 VolatileRead(UInt32 ByRef)
		/// </summary>
		protected static RMethod r_MVolatileRead_Ref_UInt32;
		public static RMethod RMVolatileRead_Ref_UInt32
		{
			get
			{
				if(r_MVolatileRead_Ref_UInt32 == null)
				{
					r_MVolatileRead_Ref_UInt32 = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.UInt32).MakeByRefType());
				}
				return r_MVolatileRead_Ref_UInt32;
			}
		}

		/// <summary>
		/// UInt64 VolatileRead(UInt64 ByRef)
		/// </summary>
		protected static RMethod r_MVolatileRead_Ref_UInt64;
		public static RMethod RMVolatileRead_Ref_UInt64
		{
			get
			{
				if(r_MVolatileRead_Ref_UInt64 == null)
				{
					r_MVolatileRead_Ref_UInt64 = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.UInt64).MakeByRefType());
				}
				return r_MVolatileRead_Ref_UInt64;
			}
		}

		/// <summary>
		/// UIntPtr VolatileRead(UIntPtr ByRef)
		/// </summary>
		protected static RMethod r_MVolatileRead_Ref_UIntPtr;
		public static RMethod RMVolatileRead_Ref_UIntPtr
		{
			get
			{
				if(r_MVolatileRead_Ref_UIntPtr == null)
				{
					r_MVolatileRead_Ref_UIntPtr = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.UIntPtr).MakeByRefType());
				}
				return r_MVolatileRead_Ref_UIntPtr;
			}
		}

		/// <summary>
		/// Void VolatileWrite(Byte ByRef, Byte)
		/// </summary>
		protected static RMethod r_MVolatileWrite_Ref_Byte_Byte;
		public static RMethod RMVolatileWrite_Ref_Byte_Byte
		{
			get
			{
				if(r_MVolatileWrite_Ref_Byte_Byte == null)
				{
					r_MVolatileWrite_Ref_Byte_Byte = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.Byte).MakeByRefType(), typeof(System.Byte));
				}
				return r_MVolatileWrite_Ref_Byte_Byte;
			}
		}

		/// <summary>
		/// Void VolatileWrite(Double ByRef, Double)
		/// </summary>
		protected static RMethod r_MVolatileWrite_Ref_Double_Double;
		public static RMethod RMVolatileWrite_Ref_Double_Double
		{
			get
			{
				if(r_MVolatileWrite_Ref_Double_Double == null)
				{
					r_MVolatileWrite_Ref_Double_Double = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.Double).MakeByRefType(), typeof(System.Double));
				}
				return r_MVolatileWrite_Ref_Double_Double;
			}
		}

		/// <summary>
		/// Void VolatileWrite(Int16 ByRef, Int16)
		/// </summary>
		protected static RMethod r_MVolatileWrite_Ref_Int16_Int16;
		public static RMethod RMVolatileWrite_Ref_Int16_Int16
		{
			get
			{
				if(r_MVolatileWrite_Ref_Int16_Int16 == null)
				{
					r_MVolatileWrite_Ref_Int16_Int16 = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.Int16).MakeByRefType(), typeof(System.Int16));
				}
				return r_MVolatileWrite_Ref_Int16_Int16;
			}
		}

		/// <summary>
		/// Void VolatileWrite(Int32 ByRef, Int32)
		/// </summary>
		protected static RMethod r_MVolatileWrite_Ref_Int32_Int32;
		public static RMethod RMVolatileWrite_Ref_Int32_Int32
		{
			get
			{
				if(r_MVolatileWrite_Ref_Int32_Int32 == null)
				{
					r_MVolatileWrite_Ref_Int32_Int32 = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.Int32).MakeByRefType(), typeof(System.Int32));
				}
				return r_MVolatileWrite_Ref_Int32_Int32;
			}
		}

		/// <summary>
		/// Void VolatileWrite(Int64 ByRef, Int64)
		/// </summary>
		protected static RMethod r_MVolatileWrite_Ref_Int64_Int64;
		public static RMethod RMVolatileWrite_Ref_Int64_Int64
		{
			get
			{
				if(r_MVolatileWrite_Ref_Int64_Int64 == null)
				{
					r_MVolatileWrite_Ref_Int64_Int64 = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.Int64).MakeByRefType(), typeof(System.Int64));
				}
				return r_MVolatileWrite_Ref_Int64_Int64;
			}
		}

		/// <summary>
		/// Void VolatileWrite(IntPtr ByRef, IntPtr)
		/// </summary>
		protected static RMethod r_MVolatileWrite_Ref_IntPtr_IntPtr;
		public static RMethod RMVolatileWrite_Ref_IntPtr_IntPtr
		{
			get
			{
				if(r_MVolatileWrite_Ref_IntPtr_IntPtr == null)
				{
					r_MVolatileWrite_Ref_IntPtr_IntPtr = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.IntPtr).MakeByRefType(), typeof(System.IntPtr));
				}
				return r_MVolatileWrite_Ref_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// Void VolatileWrite(System.Object ByRef, System.Object)
		/// </summary>
		protected static RMethod r_MVolatileWrite_Ref_Object_Object;
		public static RMethod RMVolatileWrite_Ref_Object_Object
		{
			get
			{
				if(r_MVolatileWrite_Ref_Object_Object == null)
				{
					r_MVolatileWrite_Ref_Object_Object = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.Object).MakeByRefType(), typeof(System.Object));
				}
				return r_MVolatileWrite_Ref_Object_Object;
			}
		}

		/// <summary>
		/// Void VolatileWrite(SByte ByRef, SByte)
		/// </summary>
		protected static RMethod r_MVolatileWrite_Ref_SByte_SByte;
		public static RMethod RMVolatileWrite_Ref_SByte_SByte
		{
			get
			{
				if(r_MVolatileWrite_Ref_SByte_SByte == null)
				{
					r_MVolatileWrite_Ref_SByte_SByte = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.SByte).MakeByRefType(), typeof(System.SByte));
				}
				return r_MVolatileWrite_Ref_SByte_SByte;
			}
		}

		/// <summary>
		/// Void VolatileWrite(Single ByRef, Single)
		/// </summary>
		protected static RMethod r_MVolatileWrite_Ref_Single_Single;
		public static RMethod RMVolatileWrite_Ref_Single_Single
		{
			get
			{
				if(r_MVolatileWrite_Ref_Single_Single == null)
				{
					r_MVolatileWrite_Ref_Single_Single = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.Single).MakeByRefType(), typeof(System.Single));
				}
				return r_MVolatileWrite_Ref_Single_Single;
			}
		}

		/// <summary>
		/// Void VolatileWrite(UInt16 ByRef, UInt16)
		/// </summary>
		protected static RMethod r_MVolatileWrite_Ref_UInt16_UInt16;
		public static RMethod RMVolatileWrite_Ref_UInt16_UInt16
		{
			get
			{
				if(r_MVolatileWrite_Ref_UInt16_UInt16 == null)
				{
					r_MVolatileWrite_Ref_UInt16_UInt16 = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.UInt16).MakeByRefType(), typeof(System.UInt16));
				}
				return r_MVolatileWrite_Ref_UInt16_UInt16;
			}
		}

		/// <summary>
		/// Void VolatileWrite(UInt32 ByRef, UInt32)
		/// </summary>
		protected static RMethod r_MVolatileWrite_Ref_UInt32_UInt32;
		public static RMethod RMVolatileWrite_Ref_UInt32_UInt32
		{
			get
			{
				if(r_MVolatileWrite_Ref_UInt32_UInt32 == null)
				{
					r_MVolatileWrite_Ref_UInt32_UInt32 = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.UInt32).MakeByRefType(), typeof(System.UInt32));
				}
				return r_MVolatileWrite_Ref_UInt32_UInt32;
			}
		}

		/// <summary>
		/// Void VolatileWrite(UInt64 ByRef, UInt64)
		/// </summary>
		protected static RMethod r_MVolatileWrite_Ref_UInt64_UInt64;
		public static RMethod RMVolatileWrite_Ref_UInt64_UInt64
		{
			get
			{
				if(r_MVolatileWrite_Ref_UInt64_UInt64 == null)
				{
					r_MVolatileWrite_Ref_UInt64_UInt64 = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.UInt64).MakeByRefType(), typeof(System.UInt64));
				}
				return r_MVolatileWrite_Ref_UInt64_UInt64;
			}
		}

		/// <summary>
		/// Void VolatileWrite(UIntPtr ByRef, UIntPtr)
		/// </summary>
		protected static RMethod r_MVolatileWrite_Ref_UIntPtr_UIntPtr;
		public static RMethod RMVolatileWrite_Ref_UIntPtr_UIntPtr
		{
			get
			{
				if(r_MVolatileWrite_Ref_UIntPtr_UIntPtr == null)
				{
					r_MVolatileWrite_Ref_UIntPtr_UIntPtr = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.UIntPtr).MakeByRefType(), typeof(System.UIntPtr));
				}
				return r_MVolatileWrite_Ref_UIntPtr_UIntPtr;
			}
		}

		/// <summary>
		/// Int32 SystemMaxStackStize()
		/// </summary>
		protected static RMethod r_MSystemMaxStackStize;
		public static RMethod RMSystemMaxStackStize
		{
			get
			{
				if(r_MSystemMaxStackStize == null)
				{
					r_MSystemMaxStackStize = new(typeof(System.Threading.Thread), "SystemMaxStackStize", 0);
				}
				return r_MSystemMaxStackStize;
			}
		}

		/// <summary>
		/// Int32 GetProcessDefaultStackSize(Int32)
		/// </summary>
		protected static RMethod r_MGetProcessDefaultStackSize_Int32;
		public static RMethod RMGetProcessDefaultStackSize_Int32
		{
			get
			{
				if(r_MGetProcessDefaultStackSize_Int32 == null)
				{
					r_MGetProcessDefaultStackSize_Int32 = new(typeof(System.Threading.Thread), "GetProcessDefaultStackSize", 0, typeof(System.Int32));
				}
				return r_MGetProcessDefaultStackSize_Int32;
			}
		}

		/// <summary>
		/// Void SetStart(System.MulticastDelegate, Int32)
		/// </summary>
		protected RMethod r_MSetStart_MulticastDelegate_Int32;
		public virtual RMethod RMSetStart_MulticastDelegate_Int32
		{
			get
			{
				if(r_MSetStart_MulticastDelegate_Int32 == null)
				{
					r_MSetStart_MulticastDelegate_Int32 = new(this, "SetStart", 0, typeof(System.MulticastDelegate), typeof(System.Int32));
				}
				return r_MSetStart_MulticastDelegate_Int32;
			}
		}

		/// <summary>
		/// Void BeginCriticalRegion()
		/// </summary>
		protected static RMethod r_MBeginCriticalRegion;
		public static RMethod RMBeginCriticalRegion
		{
			get
			{
				if(r_MBeginCriticalRegion == null)
				{
					r_MBeginCriticalRegion = new(typeof(System.Threading.Thread), "BeginCriticalRegion", 0);
				}
				return r_MBeginCriticalRegion;
			}
		}

		/// <summary>
		/// Void EndCriticalRegion()
		/// </summary>
		protected static RMethod r_MEndCriticalRegion;
		public static RMethod RMEndCriticalRegion
		{
			get
			{
				if(r_MEndCriticalRegion == null)
				{
					r_MEndCriticalRegion = new(typeof(System.Threading.Thread), "EndCriticalRegion", 0);
				}
				return r_MEndCriticalRegion;
			}
		}

		/// <summary>
		/// Void BeginThreadAffinity()
		/// </summary>
		protected static RMethod r_MBeginThreadAffinity;
		public static RMethod RMBeginThreadAffinity
		{
			get
			{
				if(r_MBeginThreadAffinity == null)
				{
					r_MBeginThreadAffinity = new(typeof(System.Threading.Thread), "BeginThreadAffinity", 0);
				}
				return r_MBeginThreadAffinity;
			}
		}

		/// <summary>
		/// Void EndThreadAffinity()
		/// </summary>
		protected static RMethod r_MEndThreadAffinity;
		public static RMethod RMEndThreadAffinity
		{
			get
			{
				if(r_MEndThreadAffinity == null)
				{
					r_MEndThreadAffinity = new(typeof(System.Threading.Thread), "EndThreadAffinity", 0);
				}
				return r_MEndThreadAffinity;
			}
		}

		/// <summary>
		/// System.Threading.ApartmentState GetApartmentState()
		/// </summary>
		protected RMethod r_MGetApartmentState;
		public virtual RMethod RMGetApartmentState
		{
			get
			{
				if(r_MGetApartmentState == null)
				{
					r_MGetApartmentState = new(this, "GetApartmentState", 0);
				}
				return r_MGetApartmentState;
			}
		}

		/// <summary>
		/// Void SetApartmentState(System.Threading.ApartmentState)
		/// </summary>
		protected RMethod r_MSetApartmentState_ApartmentState;
		public virtual RMethod RMSetApartmentState_ApartmentState
		{
			get
			{
				if(r_MSetApartmentState_ApartmentState == null)
				{
					r_MSetApartmentState_ApartmentState = new(this, "SetApartmentState", 0, typeof(System.Threading.ApartmentState));
				}
				return r_MSetApartmentState_ApartmentState;
			}
		}

		/// <summary>
		/// Boolean TrySetApartmentState(System.Threading.ApartmentState)
		/// </summary>
		protected RMethod r_MTrySetApartmentState_ApartmentState;
		public virtual RMethod RMTrySetApartmentState_ApartmentState
		{
			get
			{
				if(r_MTrySetApartmentState_ApartmentState == null)
				{
					r_MTrySetApartmentState_ApartmentState = new(this, "TrySetApartmentState", 0, typeof(System.Threading.ApartmentState));
				}
				return r_MTrySetApartmentState_ApartmentState;
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
		/// Void GetStackTraces(System.Threading.Thread[] ByRef, System.Object[] ByRef)
		/// </summary>
		protected static RMethod r_MGetStackTraces_Out_ThreadArray_Out_ObjectArray;
		public static RMethod RMGetStackTraces_Out_ThreadArray_Out_ObjectArray
		{
			get
			{
				if(r_MGetStackTraces_Out_ThreadArray_Out_ObjectArray == null)
				{
					r_MGetStackTraces_Out_ThreadArray_Out_ObjectArray = new(typeof(System.Threading.Thread), "GetStackTraces", 0, typeof(System.Threading.Thread).MakeArrayType().MakeByRefType(), typeof(System.Object).MakeArrayType().MakeByRefType());
				}
				return r_MGetStackTraces_Out_ThreadArray_Out_ObjectArray;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Threading.Thread,System.Diagnostics.StackTrace] Mono_GetStackTraces()
		/// </summary>
		protected static RMethod r_MMono_GetStackTraces;
		public static RMethod RMMono_GetStackTraces
		{
			get
			{
				if(r_MMono_GetStackTraces == null)
				{
					r_MMono_GetStackTraces = new(typeof(System.Threading.Thread), "Mono_GetStackTraces", 0);
				}
				return r_MMono_GetStackTraces;
			}
		}

		/// <summary>
		/// Void DisableComObjectEagerCleanup()
		/// </summary>
		protected RMethod r_MDisableComObjectEagerCleanup;
		public virtual RMethod RMDisableComObjectEagerCleanup
		{
			get
			{
				if(r_MDisableComObjectEagerCleanup == null)
				{
					r_MDisableComObjectEagerCleanup = new(this, "DisableComObjectEagerCleanup", 0);
				}
				return r_MDisableComObjectEagerCleanup;
			}
		}

		/// <summary>
		/// System.Threading.ThreadState ValidateThreadState()
		/// </summary>
		protected RMethod r_MValidateThreadState;
		public virtual RMethod RMValidateThreadState
		{
			get
			{
				if(r_MValidateThreadState == null)
				{
					r_MValidateThreadState = new(this, "ValidateThreadState", 0);
				}
				return r_MValidateThreadState;
			}
		}

		/// <summary>
		/// Int32 GetCurrentProcessorId()
		/// </summary>
		protected static RMethod r_MGetCurrentProcessorId;
		public static RMethod RMGetCurrentProcessorId
		{
			get
			{
				if(r_MGetCurrentProcessorId == null)
				{
					r_MGetCurrentProcessorId = new(typeof(System.Threading.Thread), "GetCurrentProcessorId", 0);
				}
				return r_MGetCurrentProcessorId;
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


        public RThread() : base("System.Threading.Thread")
        {
        }

        public RThread(System.Object instance) : base("System.Threading.Thread")
		{
            SetInstance(instance);
		}

        public RThread(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RThread(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static void AsyncLocalSetCurrentCulture(System.Threading.AsyncLocalValueChangedArgs<System.Globalization.CultureInfo> @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RMAsyncLocalSetCurrentCulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void AsyncLocalSetCurrentUICulture(System.Threading.AsyncLocalValueChangedArgs<System.Globalization.CultureInfo> @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RMAsyncLocalSetCurrentUICulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Start()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMStart.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Start(System.Object @parameter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parameter};
            var ___result = RMStart_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Start(ref Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark @stackMark)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stackMark.Value};
            var ___result = RMStart_Ref_StackCrawlMark.Invoke(___genericsType, ___parameters);
			@stackMark = new Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark(___parameters[0]);

            
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RExecutionContext.RReader GetExecutionContextReader()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetExecutionContextReader.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RThreading.RExecutionContext.RReader(___result);
        }


        public virtual System.Threading.ExecutionContext GetMutableExecutionContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetMutableExecutionContext.Invoke(___genericsType, ___parameters);

            return (System.Threading.ExecutionContext)___result;
        }


        public virtual void SetExecutionContext(System.Threading.ExecutionContext @value, System.Boolean @belongsToCurrentScope)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @belongsToCurrentScope};
            var ___result = RMSetExecutionContext_ExecutionContext_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetExecutionContext(Hvak.Editor.Refleaction.RSystem.RThreading.RExecutionContext.RReader @value, System.Boolean @belongsToCurrentScope)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value.Value, @belongsToCurrentScope};
            var ___result = RMSetExecutionContext_Reader_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCompressedStack(System.Threading.CompressedStack @stack)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stack};
            var ___result = RMSetCompressedStack_CompressedStack.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Threading.CompressedStack GetCompressedStack()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCompressedStack.Invoke(___genericsType, ___parameters);

            return (System.Threading.CompressedStack)___result;
        }


        public static void ResetAbort()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetAbort.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetAbortNative()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetAbortNative.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Suspend()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSuspend.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SuspendInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSuspendInternal.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Resume()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResume.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResumeInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResumeInternal.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Interrupt()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInterrupt.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InterruptInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInterruptInternal.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetPriorityNative()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPriorityNative.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void SetPriorityNative(System.Int32 @priority)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@priority};
            var ___result = RMSetPriorityNative_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean JoinInternal(System.Int32 @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout};
            var ___result = RMJoinInternal_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Join()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMJoin.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Join(System.Int32 @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout};
            var ___result = RMJoin_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Join(System.TimeSpan @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout};
            var ___result = RMJoin_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void SleepInternal(System.Int32 @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout};
            var ___result = RMSleepInternal_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sleep(System.Int32 @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout};
            var ___result = RMSleep_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sleep(System.TimeSpan @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout};
            var ___result = RMSleep_TimeSpan.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean YieldInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMYieldInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean Yield()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMYield.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetStartHelper(System.Delegate @start, System.Int32 @maxStackSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @maxStackSize};
            var ___result = RMSetStartHelper_Delegate_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.LocalDataStoreSlot AllocateDataSlot()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAllocateDataSlot.Invoke(___genericsType, ___parameters);

            return (System.LocalDataStoreSlot)___result;
        }


        public static System.LocalDataStoreSlot AllocateNamedDataSlot(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMAllocateNamedDataSlot_String.Invoke(___genericsType, ___parameters);

            return (System.LocalDataStoreSlot)___result;
        }


        public static System.LocalDataStoreSlot GetNamedDataSlot(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetNamedDataSlot_String.Invoke(___genericsType, ___parameters);

            return (System.LocalDataStoreSlot)___result;
        }


        public static void FreeNamedDataSlot(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMFreeNamedDataSlot_String.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Object GetData(System.LocalDataStoreSlot @slot)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slot};
            var ___result = RMGetData_LocalDataStoreSlot.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static void SetData(System.LocalDataStoreSlot @slot, System.Object @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slot, @data};
            var ___result = RMSetData_LocalDataStoreSlot_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Globalization.CultureInfo GetCurrentUICultureNoAppX()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCurrentUICultureNoAppX.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CultureInfo)___result;
        }


        public virtual System.Globalization.CultureInfo GetCurrentCultureNoAppX()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCurrentCultureNoAppX.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CultureInfo)___result;
        }


        public static void nativeInitCultureAccessors()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMnativeInitCultureAccessors.Invoke(___genericsType, ___parameters);

            
        }


        public static void MemoryBarrier()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemoryBarrier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___Thread__2__GetTypeInfoCount(out System.UInt32 @pcTInfo)
        {
			@pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___Thread__2__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			@pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___Thread__2__GetTypeInfo(System.UInt32 @iTInfo, System.UInt32 @lcid, System.IntPtr @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___Thread__2__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___Thread__2__GetIDsOfNames(in System.Guid @riid, System.IntPtr @rgszNames, System.UInt32 @cNames, System.UInt32 @lcid, System.IntPtr @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___Thread__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___Thread__2__Invoke(System.UInt32 @dispIdMember, in System.Guid @riid, System.UInt32 @lcid, System.Int16 @wFlags, System.IntPtr @pDispParams, System.IntPtr @pVarResult, System.IntPtr @pExcepInfo, System.IntPtr @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___Thread__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ConstructInternalThread()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMConstructInternalThread.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Byte[] ByteArrayToRootDomain(System.Byte[] @arr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arr};
            var ___result = RMByteArrayToRootDomain_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public static System.Byte[] ByteArrayToCurrentDomain(System.Byte[] @arr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arr};
            var ___result = RMByteArrayToCurrentDomain_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public static void DeserializePrincipal(System.Threading.Thread @th)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@th};
            var ___result = RMDeserializePrincipal_Thread.Invoke(___genericsType, ___parameters);

            
        }


        public static void SerializePrincipal(System.Threading.Thread @th, System.Security.Principal.IPrincipal @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@th, @value};
            var ___result = RMSerializePrincipal_Thread_IPrincipal.Invoke(___genericsType, ___parameters);

            
        }


        public static System.AppDomain GetDomain()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDomain.Invoke(___genericsType, ___parameters);

            return (System.AppDomain)___result;
        }


        public static void GetCurrentThread_icall(ref System.Threading.Thread @thread)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@thread};
            var ___result = RMGetCurrentThread_icall_Ref_Thread.Invoke(___genericsType, ___parameters);
			@thread = (System.Threading.Thread)___parameters[0];

            
        }


        public static System.Threading.Thread GetCurrentThread()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCurrentThread.Invoke(___genericsType, ___parameters);

            return (System.Threading.Thread)___result;
        }


        public static System.Int32 GetDomainID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDomainID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Thread_internal(System.MulticastDelegate @start)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start};
            var ___result = RMThread_internal_MulticastDelegate.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public static System.String GetName_internal(Hvak.Editor.Refleaction.RSystem.RThreading.RInternalThread @thread)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@thread.Value};
            var ___result = RMGetName_internal_InternalThread.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe static void SetName_icall(Hvak.Editor.Refleaction.RSystem.RThreading.RInternalThread @thread, System.Char* @name, System.Int32 @nameLength)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@thread.Value, Pointer.Box(@name, typeof(System.Char)), @nameLength};
            var ___result = RMSetName_icall_InternalThread_CharPointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetName_internal(Hvak.Editor.Refleaction.RSystem.RThreading.RInternalThread @thread, System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@thread.Value, @name};
            var ___result = RMSetName_internal_InternalThread_String.Invoke(___genericsType, ___parameters);

            
        }


        public static void Abort_internal(Hvak.Editor.Refleaction.RSystem.RThreading.RInternalThread @thread, System.Object @stateInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@thread.Value, @stateInfo};
            var ___result = RMAbort_internal_InternalThread_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Abort()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAbort.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Abort(System.Object @stateInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stateInfo};
            var ___result = RMAbort_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetAbortExceptionState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetAbortExceptionState.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void ClearAbortReason()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearAbortReason.Invoke(___genericsType, ___parameters);

            
        }


        public static void SpinWait_nop()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSpinWait_nop.Invoke(___genericsType, ___parameters);

            
        }


        public static void SpinWait(System.Int32 @iterations)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iterations};
            var ___result = RMSpinWait_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StartInternal(System.Object @principal, ref Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark @stackMark)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@principal, @stackMark.Value};
            var ___result = RMStartInternal_Object_Ref_StackCrawlMark.Invoke(___genericsType, ___parameters);
			@stackMark = new Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark(___parameters[1]);

            
        }


        public static void SetState(Hvak.Editor.Refleaction.RSystem.RThreading.RInternalThread @thread, System.Threading.ThreadState @set)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@thread.Value, @set};
            var ___result = RMSetState_InternalThread_ThreadState.Invoke(___genericsType, ___parameters);

            
        }


        public static void ClrState(Hvak.Editor.Refleaction.RSystem.RThreading.RInternalThread @thread, System.Threading.ThreadState @clr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@thread.Value, @clr};
            var ___result = RMClrState_InternalThread_ThreadState.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Threading.ThreadState GetState(Hvak.Editor.Refleaction.RSystem.RThreading.RInternalThread @thread)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@thread.Value};
            var ___result = RMGetState_InternalThread.Invoke(___genericsType, ___parameters);

            return (System.Threading.ThreadState)___result;
        }


        public static System.Byte VolatileRead(ref System.Byte @address)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address};
            var ___result = RMVolatileRead_Ref_Byte.Invoke(___genericsType, ___parameters);
			@address = (System.Byte)___parameters[0];

            return (System.Byte)___result;
        }


        public static System.Double VolatileRead(ref System.Double @address)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address};
            var ___result = RMVolatileRead_Ref_Double.Invoke(___genericsType, ___parameters);
			@address = (System.Double)___parameters[0];

            return (System.Double)___result;
        }


        public static System.Int16 VolatileRead(ref System.Int16 @address)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address};
            var ___result = RMVolatileRead_Ref_Int16.Invoke(___genericsType, ___parameters);
			@address = (System.Int16)___parameters[0];

            return (System.Int16)___result;
        }


        public static System.Int32 VolatileRead(ref System.Int32 @address)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address};
            var ___result = RMVolatileRead_Ref_Int32.Invoke(___genericsType, ___parameters);
			@address = (System.Int32)___parameters[0];

            return (System.Int32)___result;
        }


        public static System.Int64 VolatileRead(ref System.Int64 @address)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address};
            var ___result = RMVolatileRead_Ref_Int64.Invoke(___genericsType, ___parameters);
			@address = (System.Int64)___parameters[0];

            return (System.Int64)___result;
        }


        public static System.IntPtr VolatileRead(ref System.IntPtr @address)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address};
            var ___result = RMVolatileRead_Ref_IntPtr.Invoke(___genericsType, ___parameters);
			@address = (System.IntPtr)___parameters[0];

            return (System.IntPtr)___result;
        }


        public static System.Object VolatileRead(ref System.Object @address)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address};
            var ___result = RMVolatileRead_Ref_Object.Invoke(___genericsType, ___parameters);
			@address = (System.Object)___parameters[0];

            return (System.Object)___result;
        }


        public static System.SByte VolatileRead(ref System.SByte @address)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address};
            var ___result = RMVolatileRead_Ref_SByte.Invoke(___genericsType, ___parameters);
			@address = (System.SByte)___parameters[0];

            return (System.SByte)___result;
        }


        public static System.Single VolatileRead(ref System.Single @address)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address};
            var ___result = RMVolatileRead_Ref_Single.Invoke(___genericsType, ___parameters);
			@address = (System.Single)___parameters[0];

            return (System.Single)___result;
        }


        public static System.UInt16 VolatileRead(ref System.UInt16 @address)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address};
            var ___result = RMVolatileRead_Ref_UInt16.Invoke(___genericsType, ___parameters);
			@address = (System.UInt16)___parameters[0];

            return (System.UInt16)___result;
        }


        public static System.UInt32 VolatileRead(ref System.UInt32 @address)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address};
            var ___result = RMVolatileRead_Ref_UInt32.Invoke(___genericsType, ___parameters);
			@address = (System.UInt32)___parameters[0];

            return (System.UInt32)___result;
        }


        public static System.UInt64 VolatileRead(ref System.UInt64 @address)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address};
            var ___result = RMVolatileRead_Ref_UInt64.Invoke(___genericsType, ___parameters);
			@address = (System.UInt64)___parameters[0];

            return (System.UInt64)___result;
        }


        public static System.UIntPtr VolatileRead(ref System.UIntPtr @address)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address};
            var ___result = RMVolatileRead_Ref_UIntPtr.Invoke(___genericsType, ___parameters);
			@address = (System.UIntPtr)___parameters[0];

            return (System.UIntPtr)___result;
        }


        public static void VolatileWrite(ref System.Byte @address, System.Byte @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address, @value};
            var ___result = RMVolatileWrite_Ref_Byte_Byte.Invoke(___genericsType, ___parameters);
			@address = (System.Byte)___parameters[0];

            
        }


        public static void VolatileWrite(ref System.Double @address, System.Double @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address, @value};
            var ___result = RMVolatileWrite_Ref_Double_Double.Invoke(___genericsType, ___parameters);
			@address = (System.Double)___parameters[0];

            
        }


        public static void VolatileWrite(ref System.Int16 @address, System.Int16 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address, @value};
            var ___result = RMVolatileWrite_Ref_Int16_Int16.Invoke(___genericsType, ___parameters);
			@address = (System.Int16)___parameters[0];

            
        }


        public static void VolatileWrite(ref System.Int32 @address, System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address, @value};
            var ___result = RMVolatileWrite_Ref_Int32_Int32.Invoke(___genericsType, ___parameters);
			@address = (System.Int32)___parameters[0];

            
        }


        public static void VolatileWrite(ref System.Int64 @address, System.Int64 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address, @value};
            var ___result = RMVolatileWrite_Ref_Int64_Int64.Invoke(___genericsType, ___parameters);
			@address = (System.Int64)___parameters[0];

            
        }


        public static void VolatileWrite(ref System.IntPtr @address, System.IntPtr @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address, @value};
            var ___result = RMVolatileWrite_Ref_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);
			@address = (System.IntPtr)___parameters[0];

            
        }


        public static void VolatileWrite(ref System.Object @address, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address, @value};
            var ___result = RMVolatileWrite_Ref_Object_Object.Invoke(___genericsType, ___parameters);
			@address = (System.Object)___parameters[0];

            
        }


        public static void VolatileWrite(ref System.SByte @address, System.SByte @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address, @value};
            var ___result = RMVolatileWrite_Ref_SByte_SByte.Invoke(___genericsType, ___parameters);
			@address = (System.SByte)___parameters[0];

            
        }


        public static void VolatileWrite(ref System.Single @address, System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address, @value};
            var ___result = RMVolatileWrite_Ref_Single_Single.Invoke(___genericsType, ___parameters);
			@address = (System.Single)___parameters[0];

            
        }


        public static void VolatileWrite(ref System.UInt16 @address, System.UInt16 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address, @value};
            var ___result = RMVolatileWrite_Ref_UInt16_UInt16.Invoke(___genericsType, ___parameters);
			@address = (System.UInt16)___parameters[0];

            
        }


        public static void VolatileWrite(ref System.UInt32 @address, System.UInt32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address, @value};
            var ___result = RMVolatileWrite_Ref_UInt32_UInt32.Invoke(___genericsType, ___parameters);
			@address = (System.UInt32)___parameters[0];

            
        }


        public static void VolatileWrite(ref System.UInt64 @address, System.UInt64 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address, @value};
            var ___result = RMVolatileWrite_Ref_UInt64_UInt64.Invoke(___genericsType, ___parameters);
			@address = (System.UInt64)___parameters[0];

            
        }


        public static void VolatileWrite(ref System.UIntPtr @address, System.UIntPtr @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address, @value};
            var ___result = RMVolatileWrite_Ref_UIntPtr_UIntPtr.Invoke(___genericsType, ___parameters);
			@address = (System.UIntPtr)___parameters[0];

            
        }


        public static System.Int32 SystemMaxStackStize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystemMaxStackStize.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 GetProcessDefaultStackSize(System.Int32 @maxStackSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@maxStackSize};
            var ___result = RMGetProcessDefaultStackSize_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void SetStart(System.MulticastDelegate @start, System.Int32 @maxStackSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @maxStackSize};
            var ___result = RMSetStart_MulticastDelegate_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void BeginCriticalRegion()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBeginCriticalRegion.Invoke(___genericsType, ___parameters);

            
        }


        public static void EndCriticalRegion()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMEndCriticalRegion.Invoke(___genericsType, ___parameters);

            
        }


        public static void BeginThreadAffinity()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBeginThreadAffinity.Invoke(___genericsType, ___parameters);

            
        }


        public static void EndThreadAffinity()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMEndThreadAffinity.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Threading.ApartmentState GetApartmentState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetApartmentState.Invoke(___genericsType, ___parameters);

            return (System.Threading.ApartmentState)___result;
        }


        public virtual void SetApartmentState(System.Threading.ApartmentState @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state};
            var ___result = RMSetApartmentState_ApartmentState.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TrySetApartmentState(System.Threading.ApartmentState @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state};
            var ___result = RMTrySetApartmentState_ApartmentState.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static void GetStackTraces(out System.Threading.Thread[] @threads, out System.Object[] @stack_frames)
        {
			@threads = default;
			@stack_frames = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@threads, @stack_frames};
            var ___result = RMGetStackTraces_Out_ThreadArray_Out_ObjectArray.Invoke(___genericsType, ___parameters);
			@threads = (System.Threading.Thread[])___parameters[0];
			@stack_frames = (System.Object[])___parameters[1];

            
        }


        public static System.Collections.Generic.Dictionary<System.Threading.Thread, System.Diagnostics.StackTrace> Mono_GetStackTraces()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMono_GetStackTraces.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.Dictionary<System.Threading.Thread, System.Diagnostics.StackTrace>)___result;
        }


        public virtual void DisableComObjectEagerCleanup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDisableComObjectEagerCleanup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Threading.ThreadState ValidateThreadState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMValidateThreadState.Invoke(___genericsType, ___parameters);

            return (System.Threading.ThreadState)___result;
        }


        public static System.Int32 GetCurrentProcessorId()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCurrentProcessorId.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
