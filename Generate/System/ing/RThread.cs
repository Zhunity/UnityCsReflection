using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.Thread
	/// </summary>
    public partial class RThread : RMember //
    {

		/// <summary>
		/// System.LocalDataStoreMgr s_LocalDataStoreMgr
		/// </summary>
		protected static RSystem.RLocalDataStoreMgr r_s_LocalDataStoreMgr;
		public static RSystem.RLocalDataStoreMgr Rs_LocalDataStoreMgr
		{
			get
			{
				if(r_s_LocalDataStoreMgr == null)
				{
					r_s_LocalDataStoreMgr = new(typeof(System.Threading.Thread), "s_LocalDataStoreMgr");
					r_s_LocalDataStoreMgr.SetBelong(null);
				}
				return r_s_LocalDataStoreMgr;
			}
		}

		/// <summary>
		/// System.LocalDataStoreHolder s_LocalDataStore
		/// </summary>
		protected static RSystem.RLocalDataStoreHolder r_s_LocalDataStore;
		public static RSystem.RLocalDataStoreHolder Rs_LocalDataStore
		{
			get
			{
				if(r_s_LocalDataStore == null)
				{
					r_s_LocalDataStore = new(typeof(System.Threading.Thread), "s_LocalDataStore");
					r_s_LocalDataStore.SetBelong(null);
				}
				return r_s_LocalDataStore;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo m_CurrentCulture
		/// </summary>
		protected static RSystem.RGlobalization.RCultureInfo r_m_CurrentCulture;
		public static RSystem.RGlobalization.RCultureInfo Rm_CurrentCulture
		{
			get
			{
				if(r_m_CurrentCulture == null)
				{
					r_m_CurrentCulture = new(typeof(System.Threading.Thread), "m_CurrentCulture");
					r_m_CurrentCulture.SetBelong(null);
				}
				return r_m_CurrentCulture;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo m_CurrentUICulture
		/// </summary>
		protected static RSystem.RGlobalization.RCultureInfo r_m_CurrentUICulture;
		public static RSystem.RGlobalization.RCultureInfo Rm_CurrentUICulture
		{
			get
			{
				if(r_m_CurrentUICulture == null)
				{
					r_m_CurrentUICulture = new(typeof(System.Threading.Thread), "m_CurrentUICulture");
					r_m_CurrentUICulture.SetBelong(null);
				}
				return r_m_CurrentUICulture;
			}
		}

		/// <summary>
		/// System.Threading.AsyncLocal`1[System.Globalization.CultureInfo] s_asyncLocalCurrentCulture
		/// </summary>
		protected static RSystem.RThreading.RAsyncLocal<RSystem.RGlobalization.RCultureInfo> r_s_asyncLocalCurrentCulture;
		public static RSystem.RThreading.RAsyncLocal<RSystem.RGlobalization.RCultureInfo> Rs_asyncLocalCurrentCulture
		{
			get
			{
				if(r_s_asyncLocalCurrentCulture == null)
				{
					r_s_asyncLocalCurrentCulture = new(typeof(System.Threading.Thread), "s_asyncLocalCurrentCulture");
					r_s_asyncLocalCurrentCulture.SetBelong(null);
				}
				return r_s_asyncLocalCurrentCulture;
			}
		}

		/// <summary>
		/// System.Threading.AsyncLocal`1[System.Globalization.CultureInfo] s_asyncLocalCurrentUICulture
		/// </summary>
		protected static RSystem.RThreading.RAsyncLocal<RSystem.RGlobalization.RCultureInfo> r_s_asyncLocalCurrentUICulture;
		public static RSystem.RThreading.RAsyncLocal<RSystem.RGlobalization.RCultureInfo> Rs_asyncLocalCurrentUICulture
		{
			get
			{
				if(r_s_asyncLocalCurrentUICulture == null)
				{
					r_s_asyncLocalCurrentUICulture = new(typeof(System.Threading.Thread), "s_asyncLocalCurrentUICulture");
					r_s_asyncLocalCurrentUICulture.SetBelong(null);
				}
				return r_s_asyncLocalCurrentUICulture;
			}
		}

		/// <summary>
		/// System.Threading.InternalThread internal_thread
		/// </summary>
		protected RSystem.RThreading.RInternalThread r_internal_thread;
		public virtual RSystem.RThreading.RInternalThread Rinternal_thread
		{
			get
			{
				if(r_internal_thread == null)
				{
					r_internal_thread = new(this, "internal_thread");
					r_internal_thread.SetBelong(this.instance);
				}
				return r_internal_thread;
			}
		}

		/// <summary>
		/// System.Object m_ThreadStartArg
		/// </summary>
		protected RSystem.RObject r_m_ThreadStartArg;
		public virtual RSystem.RObject Rm_ThreadStartArg
		{
			get
			{
				if(r_m_ThreadStartArg == null)
				{
					r_m_ThreadStartArg = new(this, "m_ThreadStartArg");
					r_m_ThreadStartArg.SetBelong(this.instance);
				}
				return r_m_ThreadStartArg;
			}
		}

		/// <summary>
		/// System.Object pending_exception
		/// </summary>
		protected RSystem.RObject r_pending_exception;
		public virtual RSystem.RObject Rpending_exception
		{
			get
			{
				if(r_pending_exception == null)
				{
					r_pending_exception = new(this, "pending_exception");
					r_pending_exception.SetBelong(this.instance);
				}
				return r_pending_exception;
			}
		}

		/// <summary>
		/// System.Threading.Thread current_thread
		/// </summary>
		protected static RSystem.RThreading.RThread r_current_thread;
		public static RSystem.RThreading.RThread Rcurrent_thread
		{
			get
			{
				if(r_current_thread == null)
				{
					r_current_thread = new(typeof(System.Threading.Thread), "current_thread");
					r_current_thread.SetBelong(null);
				}
				return r_current_thread;
			}
		}

		/// <summary>
		/// System.MulticastDelegate m_Delegate
		/// </summary>
		protected RSystem.RMulticastDelegate r_m_Delegate;
		public virtual RSystem.RMulticastDelegate Rm_Delegate
		{
			get
			{
				if(r_m_Delegate == null)
				{
					r_m_Delegate = new(this, "m_Delegate");
					r_m_Delegate.SetBelong(this.instance);
				}
				return r_m_Delegate;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext m_ExecutionContext
		/// </summary>
		protected RSystem.RThreading.RExecutionContext r_m_ExecutionContext;
		public virtual RSystem.RThreading.RExecutionContext Rm_ExecutionContext
		{
			get
			{
				if(r_m_ExecutionContext == null)
				{
					r_m_ExecutionContext = new(this, "m_ExecutionContext");
					r_m_ExecutionContext.SetBelong(this.instance);
				}
				return r_m_ExecutionContext;
			}
		}

		/// <summary>
		/// System.Boolean m_ExecutionContextBelongsToOuterScope
		/// </summary>
		protected RField r_m_ExecutionContextBelongsToOuterScope;
		public virtual RField Rm_ExecutionContextBelongsToOuterScope
		{
			get
			{
				if(r_m_ExecutionContextBelongsToOuterScope == null)
				{
					r_m_ExecutionContextBelongsToOuterScope = new(this, "m_ExecutionContextBelongsToOuterScope");
					r_m_ExecutionContextBelongsToOuterScope.SetBelong(this.instance);
				}
				return r_m_ExecutionContextBelongsToOuterScope;
			}
		}

		/// <summary>
		/// System.Security.Principal.IPrincipal principal
		/// </summary>
		protected RSystem.RSecurity.RPrincipal.RIPrincipal r_principal;
		public virtual RSystem.RSecurity.RPrincipal.RIPrincipal Rprincipal
		{
			get
			{
				if(r_principal == null)
				{
					r_principal = new(this, "principal");
					r_principal.SetBelong(this.instance);
				}
				return r_principal;
			}
		}

		/// <summary>
		/// System.Int32 principal_version
		/// </summary>
		protected RField r_principal_version;
		public virtual RField Rprincipal_version
		{
			get
			{
				if(r_principal_version == null)
				{
					r_principal_version = new(this, "principal_version");
					r_principal_version.SetBelong(this.instance);
				}
				return r_principal_version;
			}
		}

		/// <summary>
		/// Boolean ExecutionContextBelongsToCurrentScope
		/// </summary>
		protected RProperty r_ExecutionContextBelongsToCurrentScope;
		public virtual RProperty RExecutionContextBelongsToCurrentScope
		{
			get
			{
				if(r_ExecutionContextBelongsToCurrentScope == null)
				{
					r_ExecutionContextBelongsToCurrentScope = new(this, "ExecutionContextBelongsToCurrentScope", -1);
					r_ExecutionContextBelongsToCurrentScope.SetBelong(this.instance);
				}
				return r_ExecutionContextBelongsToCurrentScope;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext ExecutionContext
		/// </summary>
		protected RSystem.RThreading.RExecutionContext r_ExecutionContext;
		public virtual RSystem.RThreading.RExecutionContext RExecutionContext
		{
			get
			{
				if(r_ExecutionContext == null)
				{
					r_ExecutionContext = new(this, "ExecutionContext", -1);
					r_ExecutionContext.SetBelong(this.instance);
				}
				return r_ExecutionContext;
			}
		}

		/// <summary>
		/// System.Threading.ThreadPriority Priority
		/// </summary>
		protected RProperty r_Priority;
		public virtual RProperty RPriority
		{
			get
			{
				if(r_Priority == null)
				{
					r_Priority = new(this, "Priority", -1);
					r_Priority.SetBelong(this.instance);
				}
				return r_Priority;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo CurrentUICulture
		/// </summary>
		protected RSystem.RGlobalization.RCultureInfo r_CurrentUICulture;
		public virtual RSystem.RGlobalization.RCultureInfo RCurrentUICulture
		{
			get
			{
				if(r_CurrentUICulture == null)
				{
					r_CurrentUICulture = new(this, "CurrentUICulture", -1);
					r_CurrentUICulture.SetBelong(this.instance);
				}
				return r_CurrentUICulture;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo CurrentCulture
		/// </summary>
		protected RSystem.RGlobalization.RCultureInfo r_CurrentCulture;
		public virtual RSystem.RGlobalization.RCultureInfo RCurrentCulture
		{
			get
			{
				if(r_CurrentCulture == null)
				{
					r_CurrentCulture = new(this, "CurrentCulture", -1);
					r_CurrentCulture.SetBelong(this.instance);
				}
				return r_CurrentCulture;
			}
		}

		/// <summary>
		/// System.LocalDataStoreMgr LocalDataStoreManager
		/// </summary>
		protected static RSystem.RLocalDataStoreMgr r_LocalDataStoreManager;
		public static RSystem.RLocalDataStoreMgr RLocalDataStoreManager
		{
			get
			{
				if(r_LocalDataStoreManager == null)
				{
					r_LocalDataStoreManager = new(typeof(System.Threading.Thread), "LocalDataStoreManager", -1);
					r_LocalDataStoreManager.SetBelong(null);
				}
				return r_LocalDataStoreManager;
			}
		}

		/// <summary>
		/// System.Threading.InternalThread Internal
		/// </summary>
		protected RSystem.RThreading.RInternalThread r_Internal;
		public virtual RSystem.RThreading.RInternalThread RInternal
		{
			get
			{
				if(r_Internal == null)
				{
					r_Internal = new(this, "Internal", -1);
					r_Internal.SetBelong(this.instance);
				}
				return r_Internal;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.Context CurrentContext
		/// </summary>
		protected static RSystem.RRuntime.RRemoting.RContexts.RContext r_CurrentContext;
		public static RSystem.RRuntime.RRemoting.RContexts.RContext RCurrentContext
		{
			get
			{
				if(r_CurrentContext == null)
				{
					r_CurrentContext = new(typeof(System.Threading.Thread), "CurrentContext", -1);
					r_CurrentContext.SetBelong(null);
				}
				return r_CurrentContext;
			}
		}

		/// <summary>
		/// System.Security.Principal.IPrincipal CurrentPrincipal
		/// </summary>
		protected static RSystem.RSecurity.RPrincipal.RIPrincipal r_CurrentPrincipal;
		public static RSystem.RSecurity.RPrincipal.RIPrincipal RCurrentPrincipal
		{
			get
			{
				if(r_CurrentPrincipal == null)
				{
					r_CurrentPrincipal = new(typeof(System.Threading.Thread), "CurrentPrincipal", -1);
					r_CurrentPrincipal.SetBelong(null);
				}
				return r_CurrentPrincipal;
			}
		}

		/// <summary>
		/// System.Threading.Thread CurrentThread
		/// </summary>
		protected static RSystem.RThreading.RThread r_CurrentThread;
		public static RSystem.RThreading.RThread RCurrentThread
		{
			get
			{
				if(r_CurrentThread == null)
				{
					r_CurrentThread = new(typeof(System.Threading.Thread), "CurrentThread", -1);
					r_CurrentThread.SetBelong(null);
				}
				return r_CurrentThread;
			}
		}

		/// <summary>
		/// Int32 CurrentThreadId
		/// </summary>
		protected static RProperty r_CurrentThreadId;
		public static RProperty RCurrentThreadId
		{
			get
			{
				if(r_CurrentThreadId == null)
				{
					r_CurrentThreadId = new(typeof(System.Threading.Thread), "CurrentThreadId", -1);
					r_CurrentThreadId.SetBelong(null);
				}
				return r_CurrentThreadId;
			}
		}

		/// <summary>
		/// System.Threading.ApartmentState ApartmentState
		/// </summary>
		protected RProperty r_ApartmentState;
		public virtual RProperty RApartmentState
		{
			get
			{
				if(r_ApartmentState == null)
				{
					r_ApartmentState = new(this, "ApartmentState", -1);
					r_ApartmentState.SetBelong(this.instance);
				}
				return r_ApartmentState;
			}
		}

		/// <summary>
		/// Boolean IsThreadPoolThread
		/// </summary>
		protected RProperty r_IsThreadPoolThread;
		public virtual RProperty RIsThreadPoolThread
		{
			get
			{
				if(r_IsThreadPoolThread == null)
				{
					r_IsThreadPoolThread = new(this, "IsThreadPoolThread", -1);
					r_IsThreadPoolThread.SetBelong(this.instance);
				}
				return r_IsThreadPoolThread;
			}
		}

		/// <summary>
		/// Boolean IsThreadPoolThreadInternal
		/// </summary>
		protected RProperty r_IsThreadPoolThreadInternal;
		public virtual RProperty RIsThreadPoolThreadInternal
		{
			get
			{
				if(r_IsThreadPoolThreadInternal == null)
				{
					r_IsThreadPoolThreadInternal = new(this, "IsThreadPoolThreadInternal", -1);
					r_IsThreadPoolThreadInternal.SetBelong(this.instance);
				}
				return r_IsThreadPoolThreadInternal;
			}
		}

		/// <summary>
		/// Boolean IsAlive
		/// </summary>
		protected RProperty r_IsAlive;
		public virtual RProperty RIsAlive
		{
			get
			{
				if(r_IsAlive == null)
				{
					r_IsAlive = new(this, "IsAlive", -1);
					r_IsAlive.SetBelong(this.instance);
				}
				return r_IsAlive;
			}
		}

		/// <summary>
		/// Boolean IsBackground
		/// </summary>
		protected RProperty r_IsBackground;
		public virtual RProperty RIsBackground
		{
			get
			{
				if(r_IsBackground == null)
				{
					r_IsBackground = new(this, "IsBackground", -1);
					r_IsBackground.SetBelong(this.instance);
				}
				return r_IsBackground;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected RProperty r_Name;
		public virtual RProperty RName
		{
			get
			{
				if(r_Name == null)
				{
					r_Name = new(this, "Name", -1);
					r_Name.SetBelong(this.instance);
				}
				return r_Name;
			}
		}

		/// <summary>
		/// System.Threading.ThreadState ThreadState
		/// </summary>
		protected RProperty r_ThreadState;
		public virtual RProperty RThreadState
		{
			get
			{
				if(r_ThreadState == null)
				{
					r_ThreadState = new(this, "ThreadState", -1);
					r_ThreadState.SetBelong(this.instance);
				}
				return r_ThreadState;
			}
		}

		/// <summary>
		/// System.Object AbortReason
		/// </summary>
		protected RSystem.RObject r_AbortReason;
		public virtual RSystem.RObject RAbortReason
		{
			get
			{
				if(r_AbortReason == null)
				{
					r_AbortReason = new(this, "AbortReason", -1);
					r_AbortReason.SetBelong(this.instance);
				}
				return r_AbortReason;
			}
		}

		/// <summary>
		/// Int32 ManagedThreadId
		/// </summary>
		protected RProperty r_ManagedThreadId;
		public virtual RProperty RManagedThreadId
		{
			get
			{
				if(r_ManagedThreadId == null)
				{
					r_ManagedThreadId = new(this, "ManagedThreadId", -1);
					r_ManagedThreadId.SetBelong(this.instance);
				}
				return r_ManagedThreadId;
			}
		}

		/// <summary>
		/// Void AsyncLocalSetCurrentCulture(System.Threading.AsyncLocalValueChangedArgs`1[System.Globalization.CultureInfo])
		/// </summary>
		protected static RMethod r_RAsyncLocalSetCurrentCulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_;
		public static RMethod RAsyncLocalSetCurrentCulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_
		{
			get
			{
				if(r_RAsyncLocalSetCurrentCulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_ == null)
				{
					r_RAsyncLocalSetCurrentCulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_ = new(typeof(System.Threading.Thread), "AsyncLocalSetCurrentCulture", 0, typeof(System.Threading.AsyncLocalValueChangedArgs<>).MakeGenericType(typeof(System.Globalization.CultureInfo)));
					r_RAsyncLocalSetCurrentCulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_.SetBelong(null);
				}
				return r_RAsyncLocalSetCurrentCulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_;
			}
		}

		/// <summary>
		/// Void AsyncLocalSetCurrentUICulture(System.Threading.AsyncLocalValueChangedArgs`1[System.Globalization.CultureInfo])
		/// </summary>
		protected static RMethod r_RAsyncLocalSetCurrentUICulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_;
		public static RMethod RAsyncLocalSetCurrentUICulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_
		{
			get
			{
				if(r_RAsyncLocalSetCurrentUICulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_ == null)
				{
					r_RAsyncLocalSetCurrentUICulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_ = new(typeof(System.Threading.Thread), "AsyncLocalSetCurrentUICulture", 0, typeof(System.Threading.AsyncLocalValueChangedArgs<>).MakeGenericType(typeof(System.Globalization.CultureInfo)));
					r_RAsyncLocalSetCurrentUICulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_.SetBelong(null);
				}
				return r_RAsyncLocalSetCurrentUICulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_;
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
		/// Void Start(System.Object)
		/// </summary>
		protected RMethod r_RStart_Object;
		public virtual RMethod RStart_Object
		{
			get
			{
				if(r_RStart_Object == null)
				{
					r_RStart_Object = new(this, "Start", 0, typeof(System.Object));
					r_RStart_Object.SetBelong(this.instance);
				}
				return r_RStart_Object;
			}
		}

		/// <summary>
		/// Void Start(System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected RMethod r_RStart_Ref_StackCrawlMark;
		public virtual RMethod RStart_Ref_StackCrawlMark
		{
			get
			{
				if(r_RStart_Ref_StackCrawlMark == null)
				{
					r_RStart_Ref_StackCrawlMark = new(this, "Start", 0,  ReleactionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
					r_RStart_Ref_StackCrawlMark.SetBelong(this.instance);
				}
				return r_RStart_Ref_StackCrawlMark;
			}
		}

		/// <summary>
		/// Reader GetExecutionContextReader()
		/// </summary>
		protected RMethod r_RGetExecutionContextReader;
		public virtual RMethod RGetExecutionContextReader
		{
			get
			{
				if(r_RGetExecutionContextReader == null)
				{
					r_RGetExecutionContextReader = new(this, "GetExecutionContextReader", 0);
					r_RGetExecutionContextReader.SetBelong(this.instance);
				}
				return r_RGetExecutionContextReader;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext GetMutableExecutionContext()
		/// </summary>
		protected RMethod r_RGetMutableExecutionContext;
		public virtual RMethod RGetMutableExecutionContext
		{
			get
			{
				if(r_RGetMutableExecutionContext == null)
				{
					r_RGetMutableExecutionContext = new(this, "GetMutableExecutionContext", 0);
					r_RGetMutableExecutionContext.SetBelong(this.instance);
				}
				return r_RGetMutableExecutionContext;
			}
		}

		/// <summary>
		/// Void SetExecutionContext(System.Threading.ExecutionContext, Boolean)
		/// </summary>
		protected RMethod r_RSetExecutionContext_ExecutionContext_Boolean;
		public virtual RMethod RSetExecutionContext_ExecutionContext_Boolean
		{
			get
			{
				if(r_RSetExecutionContext_ExecutionContext_Boolean == null)
				{
					r_RSetExecutionContext_ExecutionContext_Boolean = new(this, "SetExecutionContext", 0, typeof(System.Threading.ExecutionContext), typeof(System.Boolean));
					r_RSetExecutionContext_ExecutionContext_Boolean.SetBelong(this.instance);
				}
				return r_RSetExecutionContext_ExecutionContext_Boolean;
			}
		}

		/// <summary>
		/// Void SetExecutionContext(Reader, Boolean)
		/// </summary>
		protected RMethod r_RSetExecutionContext_Reader_Boolean;
		public virtual RMethod RSetExecutionContext_Reader_Boolean
		{
			get
			{
				if(r_RSetExecutionContext_Reader_Boolean == null)
				{
					r_RSetExecutionContext_Reader_Boolean = new(this, "SetExecutionContext", 0,  ReleactionUtils.GetType("System.Threading.ExecutionContext+Reader"), typeof(System.Boolean));
					r_RSetExecutionContext_Reader_Boolean.SetBelong(this.instance);
				}
				return r_RSetExecutionContext_Reader_Boolean;
			}
		}

		/// <summary>
		/// Void SetCompressedStack(System.Threading.CompressedStack)
		/// </summary>
		protected RMethod r_RSetCompressedStack_CompressedStack;
		public virtual RMethod RSetCompressedStack_CompressedStack
		{
			get
			{
				if(r_RSetCompressedStack_CompressedStack == null)
				{
					r_RSetCompressedStack_CompressedStack = new(this, "SetCompressedStack", 0, typeof(System.Threading.CompressedStack));
					r_RSetCompressedStack_CompressedStack.SetBelong(this.instance);
				}
				return r_RSetCompressedStack_CompressedStack;
			}
		}

		/// <summary>
		/// System.Threading.CompressedStack GetCompressedStack()
		/// </summary>
		protected RMethod r_RGetCompressedStack;
		public virtual RMethod RGetCompressedStack
		{
			get
			{
				if(r_RGetCompressedStack == null)
				{
					r_RGetCompressedStack = new(this, "GetCompressedStack", 0);
					r_RGetCompressedStack.SetBelong(this.instance);
				}
				return r_RGetCompressedStack;
			}
		}

		/// <summary>
		/// Void ResetAbort()
		/// </summary>
		protected static RMethod r_RResetAbort;
		public static RMethod RResetAbort
		{
			get
			{
				if(r_RResetAbort == null)
				{
					r_RResetAbort = new(typeof(System.Threading.Thread), "ResetAbort", 0);
					r_RResetAbort.SetBelong(null);
				}
				return r_RResetAbort;
			}
		}

		/// <summary>
		/// Void ResetAbortNative()
		/// </summary>
		protected RMethod r_RResetAbortNative;
		public virtual RMethod RResetAbortNative
		{
			get
			{
				if(r_RResetAbortNative == null)
				{
					r_RResetAbortNative = new(this, "ResetAbortNative", 0);
					r_RResetAbortNative.SetBelong(this.instance);
				}
				return r_RResetAbortNative;
			}
		}

		/// <summary>
		/// Void Suspend()
		/// </summary>
		protected RMethod r_RSuspend;
		public virtual RMethod RSuspend
		{
			get
			{
				if(r_RSuspend == null)
				{
					r_RSuspend = new(this, "Suspend", 0);
					r_RSuspend.SetBelong(this.instance);
				}
				return r_RSuspend;
			}
		}

		/// <summary>
		/// Void SuspendInternal()
		/// </summary>
		protected RMethod r_RSuspendInternal;
		public virtual RMethod RSuspendInternal
		{
			get
			{
				if(r_RSuspendInternal == null)
				{
					r_RSuspendInternal = new(this, "SuspendInternal", 0);
					r_RSuspendInternal.SetBelong(this.instance);
				}
				return r_RSuspendInternal;
			}
		}

		/// <summary>
		/// Void Resume()
		/// </summary>
		protected RMethod r_RResume;
		public virtual RMethod RResume
		{
			get
			{
				if(r_RResume == null)
				{
					r_RResume = new(this, "Resume", 0);
					r_RResume.SetBelong(this.instance);
				}
				return r_RResume;
			}
		}

		/// <summary>
		/// Void ResumeInternal()
		/// </summary>
		protected RMethod r_RResumeInternal;
		public virtual RMethod RResumeInternal
		{
			get
			{
				if(r_RResumeInternal == null)
				{
					r_RResumeInternal = new(this, "ResumeInternal", 0);
					r_RResumeInternal.SetBelong(this.instance);
				}
				return r_RResumeInternal;
			}
		}

		/// <summary>
		/// Void Interrupt()
		/// </summary>
		protected RMethod r_RInterrupt;
		public virtual RMethod RInterrupt
		{
			get
			{
				if(r_RInterrupt == null)
				{
					r_RInterrupt = new(this, "Interrupt", 0);
					r_RInterrupt.SetBelong(this.instance);
				}
				return r_RInterrupt;
			}
		}

		/// <summary>
		/// Void InterruptInternal()
		/// </summary>
		protected RMethod r_RInterruptInternal;
		public virtual RMethod RInterruptInternal
		{
			get
			{
				if(r_RInterruptInternal == null)
				{
					r_RInterruptInternal = new(this, "InterruptInternal", 0);
					r_RInterruptInternal.SetBelong(this.instance);
				}
				return r_RInterruptInternal;
			}
		}

		/// <summary>
		/// Int32 GetPriorityNative()
		/// </summary>
		protected RMethod r_RGetPriorityNative;
		public virtual RMethod RGetPriorityNative
		{
			get
			{
				if(r_RGetPriorityNative == null)
				{
					r_RGetPriorityNative = new(this, "GetPriorityNative", 0);
					r_RGetPriorityNative.SetBelong(this.instance);
				}
				return r_RGetPriorityNative;
			}
		}

		/// <summary>
		/// Void SetPriorityNative(Int32)
		/// </summary>
		protected RMethod r_RSetPriorityNative_Int32;
		public virtual RMethod RSetPriorityNative_Int32
		{
			get
			{
				if(r_RSetPriorityNative_Int32 == null)
				{
					r_RSetPriorityNative_Int32 = new(this, "SetPriorityNative", 0, typeof(System.Int32));
					r_RSetPriorityNative_Int32.SetBelong(this.instance);
				}
				return r_RSetPriorityNative_Int32;
			}
		}

		/// <summary>
		/// Boolean JoinInternal(Int32)
		/// </summary>
		protected RMethod r_RJoinInternal_Int32;
		public virtual RMethod RJoinInternal_Int32
		{
			get
			{
				if(r_RJoinInternal_Int32 == null)
				{
					r_RJoinInternal_Int32 = new(this, "JoinInternal", 0, typeof(System.Int32));
					r_RJoinInternal_Int32.SetBelong(this.instance);
				}
				return r_RJoinInternal_Int32;
			}
		}

		/// <summary>
		/// Void Join()
		/// </summary>
		protected RMethod r_RJoin;
		public virtual RMethod RJoin
		{
			get
			{
				if(r_RJoin == null)
				{
					r_RJoin = new(this, "Join", 0);
					r_RJoin.SetBelong(this.instance);
				}
				return r_RJoin;
			}
		}

		/// <summary>
		/// Boolean Join(Int32)
		/// </summary>
		protected RMethod r_RJoin_Int32;
		public virtual RMethod RJoin_Int32
		{
			get
			{
				if(r_RJoin_Int32 == null)
				{
					r_RJoin_Int32 = new(this, "Join", 0, typeof(System.Int32));
					r_RJoin_Int32.SetBelong(this.instance);
				}
				return r_RJoin_Int32;
			}
		}

		/// <summary>
		/// Boolean Join(System.TimeSpan)
		/// </summary>
		protected RMethod r_RJoin_TimeSpan;
		public virtual RMethod RJoin_TimeSpan
		{
			get
			{
				if(r_RJoin_TimeSpan == null)
				{
					r_RJoin_TimeSpan = new(this, "Join", 0, typeof(System.TimeSpan));
					r_RJoin_TimeSpan.SetBelong(this.instance);
				}
				return r_RJoin_TimeSpan;
			}
		}

		/// <summary>
		/// Void SleepInternal(Int32)
		/// </summary>
		protected static RMethod r_RSleepInternal_Int32;
		public static RMethod RSleepInternal_Int32
		{
			get
			{
				if(r_RSleepInternal_Int32 == null)
				{
					r_RSleepInternal_Int32 = new(typeof(System.Threading.Thread), "SleepInternal", 0, typeof(System.Int32));
					r_RSleepInternal_Int32.SetBelong(null);
				}
				return r_RSleepInternal_Int32;
			}
		}

		/// <summary>
		/// Void Sleep(Int32)
		/// </summary>
		protected static RMethod r_RSleep_Int32;
		public static RMethod RSleep_Int32
		{
			get
			{
				if(r_RSleep_Int32 == null)
				{
					r_RSleep_Int32 = new(typeof(System.Threading.Thread), "Sleep", 0, typeof(System.Int32));
					r_RSleep_Int32.SetBelong(null);
				}
				return r_RSleep_Int32;
			}
		}

		/// <summary>
		/// Void Sleep(System.TimeSpan)
		/// </summary>
		protected static RMethod r_RSleep_TimeSpan;
		public static RMethod RSleep_TimeSpan
		{
			get
			{
				if(r_RSleep_TimeSpan == null)
				{
					r_RSleep_TimeSpan = new(typeof(System.Threading.Thread), "Sleep", 0, typeof(System.TimeSpan));
					r_RSleep_TimeSpan.SetBelong(null);
				}
				return r_RSleep_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean YieldInternal()
		/// </summary>
		protected static RMethod r_RYieldInternal;
		public static RMethod RYieldInternal
		{
			get
			{
				if(r_RYieldInternal == null)
				{
					r_RYieldInternal = new(typeof(System.Threading.Thread), "YieldInternal", 0);
					r_RYieldInternal.SetBelong(null);
				}
				return r_RYieldInternal;
			}
		}

		/// <summary>
		/// Boolean Yield()
		/// </summary>
		protected static RMethod r_RYield;
		public static RMethod RYield
		{
			get
			{
				if(r_RYield == null)
				{
					r_RYield = new(typeof(System.Threading.Thread), "Yield", 0);
					r_RYield.SetBelong(null);
				}
				return r_RYield;
			}
		}

		/// <summary>
		/// Void SetStartHelper(System.Delegate, Int32)
		/// </summary>
		protected RMethod r_RSetStartHelper_Delegate_Int32;
		public virtual RMethod RSetStartHelper_Delegate_Int32
		{
			get
			{
				if(r_RSetStartHelper_Delegate_Int32 == null)
				{
					r_RSetStartHelper_Delegate_Int32 = new(this, "SetStartHelper", 0, typeof(System.Delegate), typeof(System.Int32));
					r_RSetStartHelper_Delegate_Int32.SetBelong(this.instance);
				}
				return r_RSetStartHelper_Delegate_Int32;
			}
		}

		/// <summary>
		/// System.LocalDataStoreSlot AllocateDataSlot()
		/// </summary>
		protected static RMethod r_RAllocateDataSlot;
		public static RMethod RAllocateDataSlot
		{
			get
			{
				if(r_RAllocateDataSlot == null)
				{
					r_RAllocateDataSlot = new(typeof(System.Threading.Thread), "AllocateDataSlot", 0);
					r_RAllocateDataSlot.SetBelong(null);
				}
				return r_RAllocateDataSlot;
			}
		}

		/// <summary>
		/// System.LocalDataStoreSlot AllocateNamedDataSlot(System.String)
		/// </summary>
		protected static RMethod r_RAllocateNamedDataSlot_String;
		public static RMethod RAllocateNamedDataSlot_String
		{
			get
			{
				if(r_RAllocateNamedDataSlot_String == null)
				{
					r_RAllocateNamedDataSlot_String = new(typeof(System.Threading.Thread), "AllocateNamedDataSlot", 0, typeof(System.String));
					r_RAllocateNamedDataSlot_String.SetBelong(null);
				}
				return r_RAllocateNamedDataSlot_String;
			}
		}

		/// <summary>
		/// System.LocalDataStoreSlot GetNamedDataSlot(System.String)
		/// </summary>
		protected static RMethod r_RGetNamedDataSlot_String;
		public static RMethod RGetNamedDataSlot_String
		{
			get
			{
				if(r_RGetNamedDataSlot_String == null)
				{
					r_RGetNamedDataSlot_String = new(typeof(System.Threading.Thread), "GetNamedDataSlot", 0, typeof(System.String));
					r_RGetNamedDataSlot_String.SetBelong(null);
				}
				return r_RGetNamedDataSlot_String;
			}
		}

		/// <summary>
		/// Void FreeNamedDataSlot(System.String)
		/// </summary>
		protected static RMethod r_RFreeNamedDataSlot_String;
		public static RMethod RFreeNamedDataSlot_String
		{
			get
			{
				if(r_RFreeNamedDataSlot_String == null)
				{
					r_RFreeNamedDataSlot_String = new(typeof(System.Threading.Thread), "FreeNamedDataSlot", 0, typeof(System.String));
					r_RFreeNamedDataSlot_String.SetBelong(null);
				}
				return r_RFreeNamedDataSlot_String;
			}
		}

		/// <summary>
		/// System.Object GetData(System.LocalDataStoreSlot)
		/// </summary>
		protected static RMethod r_RGetData_LocalDataStoreSlot;
		public static RMethod RGetData_LocalDataStoreSlot
		{
			get
			{
				if(r_RGetData_LocalDataStoreSlot == null)
				{
					r_RGetData_LocalDataStoreSlot = new(typeof(System.Threading.Thread), "GetData", 0, typeof(System.LocalDataStoreSlot));
					r_RGetData_LocalDataStoreSlot.SetBelong(null);
				}
				return r_RGetData_LocalDataStoreSlot;
			}
		}

		/// <summary>
		/// Void SetData(System.LocalDataStoreSlot, System.Object)
		/// </summary>
		protected static RMethod r_RSetData_LocalDataStoreSlot_Object;
		public static RMethod RSetData_LocalDataStoreSlot_Object
		{
			get
			{
				if(r_RSetData_LocalDataStoreSlot_Object == null)
				{
					r_RSetData_LocalDataStoreSlot_Object = new(typeof(System.Threading.Thread), "SetData", 0, typeof(System.LocalDataStoreSlot), typeof(System.Object));
					r_RSetData_LocalDataStoreSlot_Object.SetBelong(null);
				}
				return r_RSetData_LocalDataStoreSlot_Object;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo GetCurrentUICultureNoAppX()
		/// </summary>
		protected RMethod r_RGetCurrentUICultureNoAppX;
		public virtual RMethod RGetCurrentUICultureNoAppX
		{
			get
			{
				if(r_RGetCurrentUICultureNoAppX == null)
				{
					r_RGetCurrentUICultureNoAppX = new(this, "GetCurrentUICultureNoAppX", 0);
					r_RGetCurrentUICultureNoAppX.SetBelong(this.instance);
				}
				return r_RGetCurrentUICultureNoAppX;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo GetCurrentCultureNoAppX()
		/// </summary>
		protected RMethod r_RGetCurrentCultureNoAppX;
		public virtual RMethod RGetCurrentCultureNoAppX
		{
			get
			{
				if(r_RGetCurrentCultureNoAppX == null)
				{
					r_RGetCurrentCultureNoAppX = new(this, "GetCurrentCultureNoAppX", 0);
					r_RGetCurrentCultureNoAppX.SetBelong(this.instance);
				}
				return r_RGetCurrentCultureNoAppX;
			}
		}

		/// <summary>
		/// Void nativeInitCultureAccessors()
		/// </summary>
		protected static RMethod r_RnativeInitCultureAccessors;
		public static RMethod RnativeInitCultureAccessors
		{
			get
			{
				if(r_RnativeInitCultureAccessors == null)
				{
					r_RnativeInitCultureAccessors = new(typeof(System.Threading.Thread), "nativeInitCultureAccessors", 0);
					r_RnativeInitCultureAccessors.SetBelong(null);
				}
				return r_RnativeInitCultureAccessors;
			}
		}

		/// <summary>
		/// Void MemoryBarrier()
		/// </summary>
		protected static RMethod r_RMemoryBarrier;
		public static RMethod RMemoryBarrier
		{
			get
			{
				if(r_RMemoryBarrier == null)
				{
					r_RMemoryBarrier = new(typeof(System.Threading.Thread), "MemoryBarrier", 0);
					r_RMemoryBarrier.SetBelong(null);
				}
				return r_RMemoryBarrier;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._Thread.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__InteropServices__0___Thread__0__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RSystem__0__Runtime__0__InteropServices__0___Thread__0__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_RSystem__0__Runtime__0__InteropServices__0___Thread__0__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_RSystem__0__Runtime__0__InteropServices__0___Thread__0__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._Thread.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
					r_RSystem__0__Runtime__0__InteropServices__0___Thread__0__GetTypeInfoCount_Out_UInt32.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__InteropServices__0___Thread__0__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._Thread.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__InteropServices__0___Thread__0__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__0__Runtime__0__InteropServices__0___Thread__0__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_RSystem__0__Runtime__0__InteropServices__0___Thread__0__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_RSystem__0__Runtime__0__InteropServices__0___Thread__0__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._Thread.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_RSystem__0__Runtime__0__InteropServices__0___Thread__0__GetTypeInfo_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__InteropServices__0___Thread__0__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._Thread.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__InteropServices__0___Thread__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__0__Runtime__0__InteropServices__0___Thread__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_RSystem__0__Runtime__0__InteropServices__0___Thread__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_RSystem__0__Runtime__0__InteropServices__0___Thread__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._Thread.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_RSystem__0__Runtime__0__InteropServices__0___Thread__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__InteropServices__0___Thread__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._Thread.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__InteropServices__0___Thread__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RSystem__0__Runtime__0__InteropServices__0___Thread__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_RSystem__0__Runtime__0__InteropServices__0___Thread__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_RSystem__0__Runtime__0__InteropServices__0___Thread__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._Thread.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
					r_RSystem__0__Runtime__0__InteropServices__0___Thread__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__InteropServices__0___Thread__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// Void ConstructInternalThread()
		/// </summary>
		protected RMethod r_RConstructInternalThread;
		public virtual RMethod RConstructInternalThread
		{
			get
			{
				if(r_RConstructInternalThread == null)
				{
					r_RConstructInternalThread = new(this, "ConstructInternalThread", 0);
					r_RConstructInternalThread.SetBelong(this.instance);
				}
				return r_RConstructInternalThread;
			}
		}

		/// <summary>
		/// Byte[] ByteArrayToRootDomain(Byte[])
		/// </summary>
		protected static RMethod r_RByteArrayToRootDomain_ByteArray;
		public static RMethod RByteArrayToRootDomain_ByteArray
		{
			get
			{
				if(r_RByteArrayToRootDomain_ByteArray == null)
				{
					r_RByteArrayToRootDomain_ByteArray = new(typeof(System.Threading.Thread), "ByteArrayToRootDomain", 0, typeof(System.Byte).MakeArrayType());
					r_RByteArrayToRootDomain_ByteArray.SetBelong(null);
				}
				return r_RByteArrayToRootDomain_ByteArray;
			}
		}

		/// <summary>
		/// Byte[] ByteArrayToCurrentDomain(Byte[])
		/// </summary>
		protected static RMethod r_RByteArrayToCurrentDomain_ByteArray;
		public static RMethod RByteArrayToCurrentDomain_ByteArray
		{
			get
			{
				if(r_RByteArrayToCurrentDomain_ByteArray == null)
				{
					r_RByteArrayToCurrentDomain_ByteArray = new(typeof(System.Threading.Thread), "ByteArrayToCurrentDomain", 0, typeof(System.Byte).MakeArrayType());
					r_RByteArrayToCurrentDomain_ByteArray.SetBelong(null);
				}
				return r_RByteArrayToCurrentDomain_ByteArray;
			}
		}

		/// <summary>
		/// Void DeserializePrincipal(System.Threading.Thread)
		/// </summary>
		protected static RMethod r_RDeserializePrincipal_Thread;
		public static RMethod RDeserializePrincipal_Thread
		{
			get
			{
				if(r_RDeserializePrincipal_Thread == null)
				{
					r_RDeserializePrincipal_Thread = new(typeof(System.Threading.Thread), "DeserializePrincipal", 0, typeof(System.Threading.Thread));
					r_RDeserializePrincipal_Thread.SetBelong(null);
				}
				return r_RDeserializePrincipal_Thread;
			}
		}

		/// <summary>
		/// Void SerializePrincipal(System.Threading.Thread, System.Security.Principal.IPrincipal)
		/// </summary>
		protected static RMethod r_RSerializePrincipal_Thread_IPrincipal;
		public static RMethod RSerializePrincipal_Thread_IPrincipal
		{
			get
			{
				if(r_RSerializePrincipal_Thread_IPrincipal == null)
				{
					r_RSerializePrincipal_Thread_IPrincipal = new(typeof(System.Threading.Thread), "SerializePrincipal", 0, typeof(System.Threading.Thread), typeof(System.Security.Principal.IPrincipal));
					r_RSerializePrincipal_Thread_IPrincipal.SetBelong(null);
				}
				return r_RSerializePrincipal_Thread_IPrincipal;
			}
		}

		/// <summary>
		/// System.AppDomain GetDomain()
		/// </summary>
		protected static RMethod r_RGetDomain;
		public static RMethod RGetDomain
		{
			get
			{
				if(r_RGetDomain == null)
				{
					r_RGetDomain = new(typeof(System.Threading.Thread), "GetDomain", 0);
					r_RGetDomain.SetBelong(null);
				}
				return r_RGetDomain;
			}
		}

		/// <summary>
		/// Void GetCurrentThread_icall(System.Threading.Thread ByRef)
		/// </summary>
		protected static RMethod r_RGetCurrentThread_icall_Ref_Thread;
		public static RMethod RGetCurrentThread_icall_Ref_Thread
		{
			get
			{
				if(r_RGetCurrentThread_icall_Ref_Thread == null)
				{
					r_RGetCurrentThread_icall_Ref_Thread = new(typeof(System.Threading.Thread), "GetCurrentThread_icall", 0, typeof(System.Threading.Thread).MakeByRefType());
					r_RGetCurrentThread_icall_Ref_Thread.SetBelong(null);
				}
				return r_RGetCurrentThread_icall_Ref_Thread;
			}
		}

		/// <summary>
		/// System.Threading.Thread GetCurrentThread()
		/// </summary>
		protected static RMethod r_RGetCurrentThread;
		public static RMethod RGetCurrentThread
		{
			get
			{
				if(r_RGetCurrentThread == null)
				{
					r_RGetCurrentThread = new(typeof(System.Threading.Thread), "GetCurrentThread", 0);
					r_RGetCurrentThread.SetBelong(null);
				}
				return r_RGetCurrentThread;
			}
		}

		/// <summary>
		/// Int32 GetDomainID()
		/// </summary>
		protected static RMethod r_RGetDomainID;
		public static RMethod RGetDomainID
		{
			get
			{
				if(r_RGetDomainID == null)
				{
					r_RGetDomainID = new(typeof(System.Threading.Thread), "GetDomainID", 0);
					r_RGetDomainID.SetBelong(null);
				}
				return r_RGetDomainID;
			}
		}

		/// <summary>
		/// Boolean Thread_internal(System.MulticastDelegate)
		/// </summary>
		protected RMethod r_RThread_internal_MulticastDelegate;
		public virtual RMethod RThread_internal_MulticastDelegate
		{
			get
			{
				if(r_RThread_internal_MulticastDelegate == null)
				{
					r_RThread_internal_MulticastDelegate = new(this, "Thread_internal", 0, typeof(System.MulticastDelegate));
					r_RThread_internal_MulticastDelegate.SetBelong(this.instance);
				}
				return r_RThread_internal_MulticastDelegate;
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
		/// System.String GetName_internal(System.Threading.InternalThread)
		/// </summary>
		protected static RMethod r_RGetName_internal_InternalThread;
		public static RMethod RGetName_internal_InternalThread
		{
			get
			{
				if(r_RGetName_internal_InternalThread == null)
				{
					r_RGetName_internal_InternalThread = new(typeof(System.Threading.Thread), "GetName_internal", 0,  ReleactionUtils.GetType("System.Threading.InternalThread"));
					r_RGetName_internal_InternalThread.SetBelong(null);
				}
				return r_RGetName_internal_InternalThread;
			}
		}

		/// <summary>
		/// Void SetName_icall(System.Threading.InternalThread, Char*, Int32)
		/// </summary>
		protected static RMethod r_RSetName_icall_InternalThread_CharPointer_Int32;
		public static RMethod RSetName_icall_InternalThread_CharPointer_Int32
		{
			get
			{
				if(r_RSetName_icall_InternalThread_CharPointer_Int32 == null)
				{
					r_RSetName_icall_InternalThread_CharPointer_Int32 = new(typeof(System.Threading.Thread), "SetName_icall", 0,  ReleactionUtils.GetType("System.Threading.InternalThread"), typeof(System.Char).MakePointerType(), typeof(System.Int32));
					r_RSetName_icall_InternalThread_CharPointer_Int32.SetBelong(null);
				}
				return r_RSetName_icall_InternalThread_CharPointer_Int32;
			}
		}

		/// <summary>
		/// Void SetName_internal(System.Threading.InternalThread, System.String)
		/// </summary>
		protected static RMethod r_RSetName_internal_InternalThread_String;
		public static RMethod RSetName_internal_InternalThread_String
		{
			get
			{
				if(r_RSetName_internal_InternalThread_String == null)
				{
					r_RSetName_internal_InternalThread_String = new(typeof(System.Threading.Thread), "SetName_internal", 0,  ReleactionUtils.GetType("System.Threading.InternalThread"), typeof(System.String));
					r_RSetName_internal_InternalThread_String.SetBelong(null);
				}
				return r_RSetName_internal_InternalThread_String;
			}
		}

		/// <summary>
		/// Void Abort_internal(System.Threading.InternalThread, System.Object)
		/// </summary>
		protected static RMethod r_RAbort_internal_InternalThread_Object;
		public static RMethod RAbort_internal_InternalThread_Object
		{
			get
			{
				if(r_RAbort_internal_InternalThread_Object == null)
				{
					r_RAbort_internal_InternalThread_Object = new(typeof(System.Threading.Thread), "Abort_internal", 0,  ReleactionUtils.GetType("System.Threading.InternalThread"), typeof(System.Object));
					r_RAbort_internal_InternalThread_Object.SetBelong(null);
				}
				return r_RAbort_internal_InternalThread_Object;
			}
		}

		/// <summary>
		/// Void Abort()
		/// </summary>
		protected RMethod r_RAbort;
		public virtual RMethod RAbort
		{
			get
			{
				if(r_RAbort == null)
				{
					r_RAbort = new(this, "Abort", 0);
					r_RAbort.SetBelong(this.instance);
				}
				return r_RAbort;
			}
		}

		/// <summary>
		/// Void Abort(System.Object)
		/// </summary>
		protected RMethod r_RAbort_Object;
		public virtual RMethod RAbort_Object
		{
			get
			{
				if(r_RAbort_Object == null)
				{
					r_RAbort_Object = new(this, "Abort", 0, typeof(System.Object));
					r_RAbort_Object.SetBelong(this.instance);
				}
				return r_RAbort_Object;
			}
		}

		/// <summary>
		/// System.Object GetAbortExceptionState()
		/// </summary>
		protected RMethod r_RGetAbortExceptionState;
		public virtual RMethod RGetAbortExceptionState
		{
			get
			{
				if(r_RGetAbortExceptionState == null)
				{
					r_RGetAbortExceptionState = new(this, "GetAbortExceptionState", 0);
					r_RGetAbortExceptionState.SetBelong(this.instance);
				}
				return r_RGetAbortExceptionState;
			}
		}

		/// <summary>
		/// Void ClearAbortReason()
		/// </summary>
		protected RMethod r_RClearAbortReason;
		public virtual RMethod RClearAbortReason
		{
			get
			{
				if(r_RClearAbortReason == null)
				{
					r_RClearAbortReason = new(this, "ClearAbortReason", 0);
					r_RClearAbortReason.SetBelong(this.instance);
				}
				return r_RClearAbortReason;
			}
		}

		/// <summary>
		/// Void SpinWait_nop()
		/// </summary>
		protected static RMethod r_RSpinWait_nop;
		public static RMethod RSpinWait_nop
		{
			get
			{
				if(r_RSpinWait_nop == null)
				{
					r_RSpinWait_nop = new(typeof(System.Threading.Thread), "SpinWait_nop", 0);
					r_RSpinWait_nop.SetBelong(null);
				}
				return r_RSpinWait_nop;
			}
		}

		/// <summary>
		/// Void SpinWait(Int32)
		/// </summary>
		protected static RMethod r_RSpinWait_Int32;
		public static RMethod RSpinWait_Int32
		{
			get
			{
				if(r_RSpinWait_Int32 == null)
				{
					r_RSpinWait_Int32 = new(typeof(System.Threading.Thread), "SpinWait", 0, typeof(System.Int32));
					r_RSpinWait_Int32.SetBelong(null);
				}
				return r_RSpinWait_Int32;
			}
		}

		/// <summary>
		/// Void StartInternal(System.Object, System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected RMethod r_RStartInternal_Object_Ref_StackCrawlMark;
		public virtual RMethod RStartInternal_Object_Ref_StackCrawlMark
		{
			get
			{
				if(r_RStartInternal_Object_Ref_StackCrawlMark == null)
				{
					r_RStartInternal_Object_Ref_StackCrawlMark = new(this, "StartInternal", 0, typeof(System.Object),  ReleactionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
					r_RStartInternal_Object_Ref_StackCrawlMark.SetBelong(this.instance);
				}
				return r_RStartInternal_Object_Ref_StackCrawlMark;
			}
		}

		/// <summary>
		/// Void SetState(System.Threading.InternalThread, System.Threading.ThreadState)
		/// </summary>
		protected static RMethod r_RSetState_InternalThread_ThreadState;
		public static RMethod RSetState_InternalThread_ThreadState
		{
			get
			{
				if(r_RSetState_InternalThread_ThreadState == null)
				{
					r_RSetState_InternalThread_ThreadState = new(typeof(System.Threading.Thread), "SetState", 0,  ReleactionUtils.GetType("System.Threading.InternalThread"), typeof(System.Threading.ThreadState));
					r_RSetState_InternalThread_ThreadState.SetBelong(null);
				}
				return r_RSetState_InternalThread_ThreadState;
			}
		}

		/// <summary>
		/// Void ClrState(System.Threading.InternalThread, System.Threading.ThreadState)
		/// </summary>
		protected static RMethod r_RClrState_InternalThread_ThreadState;
		public static RMethod RClrState_InternalThread_ThreadState
		{
			get
			{
				if(r_RClrState_InternalThread_ThreadState == null)
				{
					r_RClrState_InternalThread_ThreadState = new(typeof(System.Threading.Thread), "ClrState", 0,  ReleactionUtils.GetType("System.Threading.InternalThread"), typeof(System.Threading.ThreadState));
					r_RClrState_InternalThread_ThreadState.SetBelong(null);
				}
				return r_RClrState_InternalThread_ThreadState;
			}
		}

		/// <summary>
		/// System.Threading.ThreadState GetState(System.Threading.InternalThread)
		/// </summary>
		protected static RMethod r_RGetState_InternalThread;
		public static RMethod RGetState_InternalThread
		{
			get
			{
				if(r_RGetState_InternalThread == null)
				{
					r_RGetState_InternalThread = new(typeof(System.Threading.Thread), "GetState", 0,  ReleactionUtils.GetType("System.Threading.InternalThread"));
					r_RGetState_InternalThread.SetBelong(null);
				}
				return r_RGetState_InternalThread;
			}
		}

		/// <summary>
		/// Byte VolatileRead(Byte ByRef)
		/// </summary>
		protected static RMethod r_RVolatileRead_Ref_Byte;
		public static RMethod RVolatileRead_Ref_Byte
		{
			get
			{
				if(r_RVolatileRead_Ref_Byte == null)
				{
					r_RVolatileRead_Ref_Byte = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.Byte).MakeByRefType());
					r_RVolatileRead_Ref_Byte.SetBelong(null);
				}
				return r_RVolatileRead_Ref_Byte;
			}
		}

		/// <summary>
		/// Double VolatileRead(Double ByRef)
		/// </summary>
		protected static RMethod r_RVolatileRead_Ref_Double;
		public static RMethod RVolatileRead_Ref_Double
		{
			get
			{
				if(r_RVolatileRead_Ref_Double == null)
				{
					r_RVolatileRead_Ref_Double = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.Double).MakeByRefType());
					r_RVolatileRead_Ref_Double.SetBelong(null);
				}
				return r_RVolatileRead_Ref_Double;
			}
		}

		/// <summary>
		/// Int16 VolatileRead(Int16 ByRef)
		/// </summary>
		protected static RMethod r_RVolatileRead_Ref_Int16;
		public static RMethod RVolatileRead_Ref_Int16
		{
			get
			{
				if(r_RVolatileRead_Ref_Int16 == null)
				{
					r_RVolatileRead_Ref_Int16 = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.Int16).MakeByRefType());
					r_RVolatileRead_Ref_Int16.SetBelong(null);
				}
				return r_RVolatileRead_Ref_Int16;
			}
		}

		/// <summary>
		/// Int32 VolatileRead(Int32 ByRef)
		/// </summary>
		protected static RMethod r_RVolatileRead_Ref_Int32;
		public static RMethod RVolatileRead_Ref_Int32
		{
			get
			{
				if(r_RVolatileRead_Ref_Int32 == null)
				{
					r_RVolatileRead_Ref_Int32 = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.Int32).MakeByRefType());
					r_RVolatileRead_Ref_Int32.SetBelong(null);
				}
				return r_RVolatileRead_Ref_Int32;
			}
		}

		/// <summary>
		/// Int64 VolatileRead(Int64 ByRef)
		/// </summary>
		protected static RMethod r_RVolatileRead_Ref_Int64;
		public static RMethod RVolatileRead_Ref_Int64
		{
			get
			{
				if(r_RVolatileRead_Ref_Int64 == null)
				{
					r_RVolatileRead_Ref_Int64 = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.Int64).MakeByRefType());
					r_RVolatileRead_Ref_Int64.SetBelong(null);
				}
				return r_RVolatileRead_Ref_Int64;
			}
		}

		/// <summary>
		/// IntPtr VolatileRead(IntPtr ByRef)
		/// </summary>
		protected static RMethod r_RVolatileRead_Ref_IntPtr;
		public static RMethod RVolatileRead_Ref_IntPtr
		{
			get
			{
				if(r_RVolatileRead_Ref_IntPtr == null)
				{
					r_RVolatileRead_Ref_IntPtr = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.IntPtr).MakeByRefType());
					r_RVolatileRead_Ref_IntPtr.SetBelong(null);
				}
				return r_RVolatileRead_Ref_IntPtr;
			}
		}

		/// <summary>
		/// System.Object VolatileRead(System.Object ByRef)
		/// </summary>
		protected static RMethod r_RVolatileRead_Ref_Object;
		public static RMethod RVolatileRead_Ref_Object
		{
			get
			{
				if(r_RVolatileRead_Ref_Object == null)
				{
					r_RVolatileRead_Ref_Object = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.Object).MakeByRefType());
					r_RVolatileRead_Ref_Object.SetBelong(null);
				}
				return r_RVolatileRead_Ref_Object;
			}
		}

		/// <summary>
		/// SByte VolatileRead(SByte ByRef)
		/// </summary>
		protected static RMethod r_RVolatileRead_Ref_SByte;
		public static RMethod RVolatileRead_Ref_SByte
		{
			get
			{
				if(r_RVolatileRead_Ref_SByte == null)
				{
					r_RVolatileRead_Ref_SByte = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.SByte).MakeByRefType());
					r_RVolatileRead_Ref_SByte.SetBelong(null);
				}
				return r_RVolatileRead_Ref_SByte;
			}
		}

		/// <summary>
		/// Single VolatileRead(Single ByRef)
		/// </summary>
		protected static RMethod r_RVolatileRead_Ref_Single;
		public static RMethod RVolatileRead_Ref_Single
		{
			get
			{
				if(r_RVolatileRead_Ref_Single == null)
				{
					r_RVolatileRead_Ref_Single = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.Single).MakeByRefType());
					r_RVolatileRead_Ref_Single.SetBelong(null);
				}
				return r_RVolatileRead_Ref_Single;
			}
		}

		/// <summary>
		/// UInt16 VolatileRead(UInt16 ByRef)
		/// </summary>
		protected static RMethod r_RVolatileRead_Ref_UInt16;
		public static RMethod RVolatileRead_Ref_UInt16
		{
			get
			{
				if(r_RVolatileRead_Ref_UInt16 == null)
				{
					r_RVolatileRead_Ref_UInt16 = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.UInt16).MakeByRefType());
					r_RVolatileRead_Ref_UInt16.SetBelong(null);
				}
				return r_RVolatileRead_Ref_UInt16;
			}
		}

		/// <summary>
		/// UInt32 VolatileRead(UInt32 ByRef)
		/// </summary>
		protected static RMethod r_RVolatileRead_Ref_UInt32;
		public static RMethod RVolatileRead_Ref_UInt32
		{
			get
			{
				if(r_RVolatileRead_Ref_UInt32 == null)
				{
					r_RVolatileRead_Ref_UInt32 = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.UInt32).MakeByRefType());
					r_RVolatileRead_Ref_UInt32.SetBelong(null);
				}
				return r_RVolatileRead_Ref_UInt32;
			}
		}

		/// <summary>
		/// UInt64 VolatileRead(UInt64 ByRef)
		/// </summary>
		protected static RMethod r_RVolatileRead_Ref_UInt64;
		public static RMethod RVolatileRead_Ref_UInt64
		{
			get
			{
				if(r_RVolatileRead_Ref_UInt64 == null)
				{
					r_RVolatileRead_Ref_UInt64 = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.UInt64).MakeByRefType());
					r_RVolatileRead_Ref_UInt64.SetBelong(null);
				}
				return r_RVolatileRead_Ref_UInt64;
			}
		}

		/// <summary>
		/// UIntPtr VolatileRead(UIntPtr ByRef)
		/// </summary>
		protected static RMethod r_RVolatileRead_Ref_UIntPtr;
		public static RMethod RVolatileRead_Ref_UIntPtr
		{
			get
			{
				if(r_RVolatileRead_Ref_UIntPtr == null)
				{
					r_RVolatileRead_Ref_UIntPtr = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.UIntPtr).MakeByRefType());
					r_RVolatileRead_Ref_UIntPtr.SetBelong(null);
				}
				return r_RVolatileRead_Ref_UIntPtr;
			}
		}

		/// <summary>
		/// Void VolatileWrite(Byte ByRef, Byte)
		/// </summary>
		protected static RMethod r_RVolatileWrite_Ref_Byte_Byte;
		public static RMethod RVolatileWrite_Ref_Byte_Byte
		{
			get
			{
				if(r_RVolatileWrite_Ref_Byte_Byte == null)
				{
					r_RVolatileWrite_Ref_Byte_Byte = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.Byte).MakeByRefType(), typeof(System.Byte));
					r_RVolatileWrite_Ref_Byte_Byte.SetBelong(null);
				}
				return r_RVolatileWrite_Ref_Byte_Byte;
			}
		}

		/// <summary>
		/// Void VolatileWrite(Double ByRef, Double)
		/// </summary>
		protected static RMethod r_RVolatileWrite_Ref_Double_Double;
		public static RMethod RVolatileWrite_Ref_Double_Double
		{
			get
			{
				if(r_RVolatileWrite_Ref_Double_Double == null)
				{
					r_RVolatileWrite_Ref_Double_Double = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.Double).MakeByRefType(), typeof(System.Double));
					r_RVolatileWrite_Ref_Double_Double.SetBelong(null);
				}
				return r_RVolatileWrite_Ref_Double_Double;
			}
		}

		/// <summary>
		/// Void VolatileWrite(Int16 ByRef, Int16)
		/// </summary>
		protected static RMethod r_RVolatileWrite_Ref_Int16_Int16;
		public static RMethod RVolatileWrite_Ref_Int16_Int16
		{
			get
			{
				if(r_RVolatileWrite_Ref_Int16_Int16 == null)
				{
					r_RVolatileWrite_Ref_Int16_Int16 = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.Int16).MakeByRefType(), typeof(System.Int16));
					r_RVolatileWrite_Ref_Int16_Int16.SetBelong(null);
				}
				return r_RVolatileWrite_Ref_Int16_Int16;
			}
		}

		/// <summary>
		/// Void VolatileWrite(Int32 ByRef, Int32)
		/// </summary>
		protected static RMethod r_RVolatileWrite_Ref_Int32_Int32;
		public static RMethod RVolatileWrite_Ref_Int32_Int32
		{
			get
			{
				if(r_RVolatileWrite_Ref_Int32_Int32 == null)
				{
					r_RVolatileWrite_Ref_Int32_Int32 = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.Int32).MakeByRefType(), typeof(System.Int32));
					r_RVolatileWrite_Ref_Int32_Int32.SetBelong(null);
				}
				return r_RVolatileWrite_Ref_Int32_Int32;
			}
		}

		/// <summary>
		/// Void VolatileWrite(Int64 ByRef, Int64)
		/// </summary>
		protected static RMethod r_RVolatileWrite_Ref_Int64_Int64;
		public static RMethod RVolatileWrite_Ref_Int64_Int64
		{
			get
			{
				if(r_RVolatileWrite_Ref_Int64_Int64 == null)
				{
					r_RVolatileWrite_Ref_Int64_Int64 = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.Int64).MakeByRefType(), typeof(System.Int64));
					r_RVolatileWrite_Ref_Int64_Int64.SetBelong(null);
				}
				return r_RVolatileWrite_Ref_Int64_Int64;
			}
		}

		/// <summary>
		/// Void VolatileWrite(IntPtr ByRef, IntPtr)
		/// </summary>
		protected static RMethod r_RVolatileWrite_Ref_IntPtr_IntPtr;
		public static RMethod RVolatileWrite_Ref_IntPtr_IntPtr
		{
			get
			{
				if(r_RVolatileWrite_Ref_IntPtr_IntPtr == null)
				{
					r_RVolatileWrite_Ref_IntPtr_IntPtr = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.IntPtr).MakeByRefType(), typeof(System.IntPtr));
					r_RVolatileWrite_Ref_IntPtr_IntPtr.SetBelong(null);
				}
				return r_RVolatileWrite_Ref_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// Void VolatileWrite(System.Object ByRef, System.Object)
		/// </summary>
		protected static RMethod r_RVolatileWrite_Ref_Object_Object;
		public static RMethod RVolatileWrite_Ref_Object_Object
		{
			get
			{
				if(r_RVolatileWrite_Ref_Object_Object == null)
				{
					r_RVolatileWrite_Ref_Object_Object = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.Object).MakeByRefType(), typeof(System.Object));
					r_RVolatileWrite_Ref_Object_Object.SetBelong(null);
				}
				return r_RVolatileWrite_Ref_Object_Object;
			}
		}

		/// <summary>
		/// Void VolatileWrite(SByte ByRef, SByte)
		/// </summary>
		protected static RMethod r_RVolatileWrite_Ref_SByte_SByte;
		public static RMethod RVolatileWrite_Ref_SByte_SByte
		{
			get
			{
				if(r_RVolatileWrite_Ref_SByte_SByte == null)
				{
					r_RVolatileWrite_Ref_SByte_SByte = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.SByte).MakeByRefType(), typeof(System.SByte));
					r_RVolatileWrite_Ref_SByte_SByte.SetBelong(null);
				}
				return r_RVolatileWrite_Ref_SByte_SByte;
			}
		}

		/// <summary>
		/// Void VolatileWrite(Single ByRef, Single)
		/// </summary>
		protected static RMethod r_RVolatileWrite_Ref_Single_Single;
		public static RMethod RVolatileWrite_Ref_Single_Single
		{
			get
			{
				if(r_RVolatileWrite_Ref_Single_Single == null)
				{
					r_RVolatileWrite_Ref_Single_Single = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.Single).MakeByRefType(), typeof(System.Single));
					r_RVolatileWrite_Ref_Single_Single.SetBelong(null);
				}
				return r_RVolatileWrite_Ref_Single_Single;
			}
		}

		/// <summary>
		/// Void VolatileWrite(UInt16 ByRef, UInt16)
		/// </summary>
		protected static RMethod r_RVolatileWrite_Ref_UInt16_UInt16;
		public static RMethod RVolatileWrite_Ref_UInt16_UInt16
		{
			get
			{
				if(r_RVolatileWrite_Ref_UInt16_UInt16 == null)
				{
					r_RVolatileWrite_Ref_UInt16_UInt16 = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.UInt16).MakeByRefType(), typeof(System.UInt16));
					r_RVolatileWrite_Ref_UInt16_UInt16.SetBelong(null);
				}
				return r_RVolatileWrite_Ref_UInt16_UInt16;
			}
		}

		/// <summary>
		/// Void VolatileWrite(UInt32 ByRef, UInt32)
		/// </summary>
		protected static RMethod r_RVolatileWrite_Ref_UInt32_UInt32;
		public static RMethod RVolatileWrite_Ref_UInt32_UInt32
		{
			get
			{
				if(r_RVolatileWrite_Ref_UInt32_UInt32 == null)
				{
					r_RVolatileWrite_Ref_UInt32_UInt32 = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.UInt32).MakeByRefType(), typeof(System.UInt32));
					r_RVolatileWrite_Ref_UInt32_UInt32.SetBelong(null);
				}
				return r_RVolatileWrite_Ref_UInt32_UInt32;
			}
		}

		/// <summary>
		/// Void VolatileWrite(UInt64 ByRef, UInt64)
		/// </summary>
		protected static RMethod r_RVolatileWrite_Ref_UInt64_UInt64;
		public static RMethod RVolatileWrite_Ref_UInt64_UInt64
		{
			get
			{
				if(r_RVolatileWrite_Ref_UInt64_UInt64 == null)
				{
					r_RVolatileWrite_Ref_UInt64_UInt64 = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.UInt64).MakeByRefType(), typeof(System.UInt64));
					r_RVolatileWrite_Ref_UInt64_UInt64.SetBelong(null);
				}
				return r_RVolatileWrite_Ref_UInt64_UInt64;
			}
		}

		/// <summary>
		/// Void VolatileWrite(UIntPtr ByRef, UIntPtr)
		/// </summary>
		protected static RMethod r_RVolatileWrite_Ref_UIntPtr_UIntPtr;
		public static RMethod RVolatileWrite_Ref_UIntPtr_UIntPtr
		{
			get
			{
				if(r_RVolatileWrite_Ref_UIntPtr_UIntPtr == null)
				{
					r_RVolatileWrite_Ref_UIntPtr_UIntPtr = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.UIntPtr).MakeByRefType(), typeof(System.UIntPtr));
					r_RVolatileWrite_Ref_UIntPtr_UIntPtr.SetBelong(null);
				}
				return r_RVolatileWrite_Ref_UIntPtr_UIntPtr;
			}
		}

		/// <summary>
		/// Int32 SystemMaxStackStize()
		/// </summary>
		protected static RMethod r_RSystemMaxStackStize;
		public static RMethod RSystemMaxStackStize
		{
			get
			{
				if(r_RSystemMaxStackStize == null)
				{
					r_RSystemMaxStackStize = new(typeof(System.Threading.Thread), "SystemMaxStackStize", 0);
					r_RSystemMaxStackStize.SetBelong(null);
				}
				return r_RSystemMaxStackStize;
			}
		}

		/// <summary>
		/// Int32 GetProcessDefaultStackSize(Int32)
		/// </summary>
		protected static RMethod r_RGetProcessDefaultStackSize_Int32;
		public static RMethod RGetProcessDefaultStackSize_Int32
		{
			get
			{
				if(r_RGetProcessDefaultStackSize_Int32 == null)
				{
					r_RGetProcessDefaultStackSize_Int32 = new(typeof(System.Threading.Thread), "GetProcessDefaultStackSize", 0, typeof(System.Int32));
					r_RGetProcessDefaultStackSize_Int32.SetBelong(null);
				}
				return r_RGetProcessDefaultStackSize_Int32;
			}
		}

		/// <summary>
		/// Void SetStart(System.MulticastDelegate, Int32)
		/// </summary>
		protected RMethod r_RSetStart_MulticastDelegate_Int32;
		public virtual RMethod RSetStart_MulticastDelegate_Int32
		{
			get
			{
				if(r_RSetStart_MulticastDelegate_Int32 == null)
				{
					r_RSetStart_MulticastDelegate_Int32 = new(this, "SetStart", 0, typeof(System.MulticastDelegate), typeof(System.Int32));
					r_RSetStart_MulticastDelegate_Int32.SetBelong(this.instance);
				}
				return r_RSetStart_MulticastDelegate_Int32;
			}
		}

		/// <summary>
		/// Void BeginCriticalRegion()
		/// </summary>
		protected static RMethod r_RBeginCriticalRegion;
		public static RMethod RBeginCriticalRegion
		{
			get
			{
				if(r_RBeginCriticalRegion == null)
				{
					r_RBeginCriticalRegion = new(typeof(System.Threading.Thread), "BeginCriticalRegion", 0);
					r_RBeginCriticalRegion.SetBelong(null);
				}
				return r_RBeginCriticalRegion;
			}
		}

		/// <summary>
		/// Void EndCriticalRegion()
		/// </summary>
		protected static RMethod r_REndCriticalRegion;
		public static RMethod REndCriticalRegion
		{
			get
			{
				if(r_REndCriticalRegion == null)
				{
					r_REndCriticalRegion = new(typeof(System.Threading.Thread), "EndCriticalRegion", 0);
					r_REndCriticalRegion.SetBelong(null);
				}
				return r_REndCriticalRegion;
			}
		}

		/// <summary>
		/// Void BeginThreadAffinity()
		/// </summary>
		protected static RMethod r_RBeginThreadAffinity;
		public static RMethod RBeginThreadAffinity
		{
			get
			{
				if(r_RBeginThreadAffinity == null)
				{
					r_RBeginThreadAffinity = new(typeof(System.Threading.Thread), "BeginThreadAffinity", 0);
					r_RBeginThreadAffinity.SetBelong(null);
				}
				return r_RBeginThreadAffinity;
			}
		}

		/// <summary>
		/// Void EndThreadAffinity()
		/// </summary>
		protected static RMethod r_REndThreadAffinity;
		public static RMethod REndThreadAffinity
		{
			get
			{
				if(r_REndThreadAffinity == null)
				{
					r_REndThreadAffinity = new(typeof(System.Threading.Thread), "EndThreadAffinity", 0);
					r_REndThreadAffinity.SetBelong(null);
				}
				return r_REndThreadAffinity;
			}
		}

		/// <summary>
		/// System.Threading.ApartmentState GetApartmentState()
		/// </summary>
		protected RMethod r_RGetApartmentState;
		public virtual RMethod RGetApartmentState
		{
			get
			{
				if(r_RGetApartmentState == null)
				{
					r_RGetApartmentState = new(this, "GetApartmentState", 0);
					r_RGetApartmentState.SetBelong(this.instance);
				}
				return r_RGetApartmentState;
			}
		}

		/// <summary>
		/// Void SetApartmentState(System.Threading.ApartmentState)
		/// </summary>
		protected RMethod r_RSetApartmentState_ApartmentState;
		public virtual RMethod RSetApartmentState_ApartmentState
		{
			get
			{
				if(r_RSetApartmentState_ApartmentState == null)
				{
					r_RSetApartmentState_ApartmentState = new(this, "SetApartmentState", 0, typeof(System.Threading.ApartmentState));
					r_RSetApartmentState_ApartmentState.SetBelong(this.instance);
				}
				return r_RSetApartmentState_ApartmentState;
			}
		}

		/// <summary>
		/// Boolean TrySetApartmentState(System.Threading.ApartmentState)
		/// </summary>
		protected RMethod r_RTrySetApartmentState_ApartmentState;
		public virtual RMethod RTrySetApartmentState_ApartmentState
		{
			get
			{
				if(r_RTrySetApartmentState_ApartmentState == null)
				{
					r_RTrySetApartmentState_ApartmentState = new(this, "TrySetApartmentState", 0, typeof(System.Threading.ApartmentState));
					r_RTrySetApartmentState_ApartmentState.SetBelong(this.instance);
				}
				return r_RTrySetApartmentState_ApartmentState;
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
		/// Void GetStackTraces(System.Threading.Thread[] ByRef, System.Object[] ByRef)
		/// </summary>
		protected static RMethod r_RGetStackTraces_Out_ThreadArray_Out_ObjectArray;
		public static RMethod RGetStackTraces_Out_ThreadArray_Out_ObjectArray
		{
			get
			{
				if(r_RGetStackTraces_Out_ThreadArray_Out_ObjectArray == null)
				{
					r_RGetStackTraces_Out_ThreadArray_Out_ObjectArray = new(typeof(System.Threading.Thread), "GetStackTraces", 0, typeof(System.Threading.Thread).MakeArrayType().MakeByRefType(), typeof(System.Object).MakeArrayType().MakeByRefType());
					r_RGetStackTraces_Out_ThreadArray_Out_ObjectArray.SetBelong(null);
				}
				return r_RGetStackTraces_Out_ThreadArray_Out_ObjectArray;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Threading.Thread,System.Diagnostics.StackTrace] Mono_GetStackTraces()
		/// </summary>
		protected static RMethod r_RMono_GetStackTraces;
		public static RMethod RMono_GetStackTraces
		{
			get
			{
				if(r_RMono_GetStackTraces == null)
				{
					r_RMono_GetStackTraces = new(typeof(System.Threading.Thread), "Mono_GetStackTraces", 0);
					r_RMono_GetStackTraces.SetBelong(null);
				}
				return r_RMono_GetStackTraces;
			}
		}

		/// <summary>
		/// Void DisableComObjectEagerCleanup()
		/// </summary>
		protected RMethod r_RDisableComObjectEagerCleanup;
		public virtual RMethod RDisableComObjectEagerCleanup
		{
			get
			{
				if(r_RDisableComObjectEagerCleanup == null)
				{
					r_RDisableComObjectEagerCleanup = new(this, "DisableComObjectEagerCleanup", 0);
					r_RDisableComObjectEagerCleanup.SetBelong(this.instance);
				}
				return r_RDisableComObjectEagerCleanup;
			}
		}

		/// <summary>
		/// System.Threading.ThreadState ValidateThreadState()
		/// </summary>
		protected RMethod r_RValidateThreadState;
		public virtual RMethod RValidateThreadState
		{
			get
			{
				if(r_RValidateThreadState == null)
				{
					r_RValidateThreadState = new(this, "ValidateThreadState", 0);
					r_RValidateThreadState.SetBelong(this.instance);
				}
				return r_RValidateThreadState;
			}
		}

		/// <summary>
		/// Int32 GetCurrentProcessorId()
		/// </summary>
		protected static RMethod r_RGetCurrentProcessorId;
		public static RMethod RGetCurrentProcessorId
		{
			get
			{
				if(r_RGetCurrentProcessorId == null)
				{
					r_RGetCurrentProcessorId = new(typeof(System.Threading.Thread), "GetCurrentProcessorId", 0);
					r_RGetCurrentProcessorId.SetBelong(null);
				}
				return r_RGetCurrentProcessorId;
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

        public static void AsyncLocalSetCurrentCulture(System.Threading.AsyncLocalValueChangedArgs<System.Globalization.CultureInfo>  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RAsyncLocalSetCurrentCulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void AsyncLocalSetCurrentUICulture(System.Threading.AsyncLocalValueChangedArgs<System.Globalization.CultureInfo>  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RAsyncLocalSetCurrentUICulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Start()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStart.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Start(System.Object  @parameter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parameter};
            var ___result = RStart_Object.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Object GetExecutionContextReader()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetExecutionContextReader.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Threading.ExecutionContext GetMutableExecutionContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMutableExecutionContext.Invoke(___genericsType, ___parameters);

            return (System.Threading.ExecutionContext)___result;
        }


        public virtual void SetExecutionContext(System.Threading.ExecutionContext  @value, System.Boolean  @belongsToCurrentScope)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @belongsToCurrentScope};
            var ___result = RSetExecutionContext_ExecutionContext_Boolean.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void SetCompressedStack(System.Threading.CompressedStack  @stack)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stack};
            var ___result = RSetCompressedStack_CompressedStack.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Threading.CompressedStack GetCompressedStack()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCompressedStack.Invoke(___genericsType, ___parameters);

            return (System.Threading.CompressedStack)___result;
        }


        public static void ResetAbort()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetAbort.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetAbortNative()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetAbortNative.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Suspend()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSuspend.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SuspendInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSuspendInternal.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Resume()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResume.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResumeInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResumeInternal.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Interrupt()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInterrupt.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InterruptInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInterruptInternal.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetPriorityNative()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPriorityNative.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void SetPriorityNative(System.Int32  @priority)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@priority};
            var ___result = RSetPriorityNative_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean JoinInternal(System.Int32  @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout};
            var ___result = RJoinInternal_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Join()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RJoin.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Join(System.Int32  @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout};
            var ___result = RJoin_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Join(System.TimeSpan  @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout};
            var ___result = RJoin_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void SleepInternal(System.Int32  @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout};
            var ___result = RSleepInternal_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sleep(System.Int32  @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout};
            var ___result = RSleep_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sleep(System.TimeSpan  @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout};
            var ___result = RSleep_TimeSpan.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean YieldInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RYieldInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean Yield()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RYield.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetStartHelper(System.Delegate  @start, System.Int32  @maxStackSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @maxStackSize};
            var ___result = RSetStartHelper_Delegate_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.LocalDataStoreSlot AllocateDataSlot()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAllocateDataSlot.Invoke(___genericsType, ___parameters);

            return (System.LocalDataStoreSlot)___result;
        }


        public static System.LocalDataStoreSlot AllocateNamedDataSlot(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RAllocateNamedDataSlot_String.Invoke(___genericsType, ___parameters);

            return (System.LocalDataStoreSlot)___result;
        }


        public static System.LocalDataStoreSlot GetNamedDataSlot(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetNamedDataSlot_String.Invoke(___genericsType, ___parameters);

            return (System.LocalDataStoreSlot)___result;
        }


        public static void FreeNamedDataSlot(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RFreeNamedDataSlot_String.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Object GetData(System.LocalDataStoreSlot  @slot)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slot};
            var ___result = RGetData_LocalDataStoreSlot.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static void SetData(System.LocalDataStoreSlot  @slot, System.Object  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slot, @data};
            var ___result = RSetData_LocalDataStoreSlot_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Globalization.CultureInfo GetCurrentUICultureNoAppX()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCurrentUICultureNoAppX.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CultureInfo)___result;
        }


        public virtual System.Globalization.CultureInfo GetCurrentCultureNoAppX()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCurrentCultureNoAppX.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CultureInfo)___result;
        }


        public static void nativeInitCultureAccessors()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RnativeInitCultureAccessors.Invoke(___genericsType, ___parameters);

            
        }


        public static void MemoryBarrier()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMemoryBarrier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Runtime__0__InteropServices__0___Thread__0__GetTypeInfoCount(out System.UInt32  @pcTInfo)
        {
			pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RSystem__0__Runtime__0__InteropServices__0___Thread__0__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__0__Runtime__0__InteropServices__0___Thread__0__GetTypeInfo(System.UInt32  @iTInfo, System.UInt32  @lcid, System.IntPtr  @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RSystem__0__Runtime__0__InteropServices__0___Thread__0__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Runtime__0__InteropServices__0___Thread__0__GetIDsOfNames(in System.Guid  @riid, System.IntPtr  @rgszNames, System.UInt32  @cNames, System.UInt32  @lcid, System.IntPtr  @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RSystem__0__Runtime__0__InteropServices__0___Thread__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Runtime__0__InteropServices__0___Thread__0__Invoke(System.UInt32  @dispIdMember, in System.Guid  @riid, System.UInt32  @lcid, System.Int16  @wFlags, System.IntPtr  @pDispParams, System.IntPtr  @pVarResult, System.IntPtr  @pExcepInfo, System.IntPtr  @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RSystem__0__Runtime__0__InteropServices__0___Thread__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ConstructInternalThread()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RConstructInternalThread.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Byte[] ByteArrayToRootDomain(System.Byte[]  @arr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arr};
            var ___result = RByteArrayToRootDomain_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public static System.Byte[] ByteArrayToCurrentDomain(System.Byte[]  @arr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arr};
            var ___result = RByteArrayToCurrentDomain_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public static void DeserializePrincipal(System.Threading.Thread  @th)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@th};
            var ___result = RDeserializePrincipal_Thread.Invoke(___genericsType, ___parameters);

            
        }


        public static void SerializePrincipal(System.Threading.Thread  @th, System.Security.Principal.IPrincipal  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@th, @value};
            var ___result = RSerializePrincipal_Thread_IPrincipal.Invoke(___genericsType, ___parameters);

            
        }


        public static System.AppDomain GetDomain()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDomain.Invoke(___genericsType, ___parameters);

            return (System.AppDomain)___result;
        }


        public static void GetCurrentThread_icall(ref System.Threading.Thread  @thread)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@thread};
            var ___result = RGetCurrentThread_icall_Ref_Thread.Invoke(___genericsType, ___parameters);
			thread = (System.Threading.Thread)___parameters[0];

            
        }


        public static System.Threading.Thread GetCurrentThread()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCurrentThread.Invoke(___genericsType, ___parameters);

            return (System.Threading.Thread)___result;
        }


        public static System.Int32 GetDomainID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDomainID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Thread_internal(System.MulticastDelegate  @start)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start};
            var ___result = RThread_internal_MulticastDelegate.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }






        public virtual void Abort()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAbort.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Abort(System.Object  @stateInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stateInfo};
            var ___result = RAbort_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetAbortExceptionState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAbortExceptionState.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void ClearAbortReason()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearAbortReason.Invoke(___genericsType, ___parameters);

            
        }


        public static void SpinWait_nop()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSpinWait_nop.Invoke(___genericsType, ___parameters);

            
        }


        public static void SpinWait(System.Int32  @iterations)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iterations};
            var ___result = RSpinWait_Int32.Invoke(___genericsType, ___parameters);

            
        }






        public static System.Byte VolatileRead(ref System.Byte  @address)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address};
            var ___result = RVolatileRead_Ref_Byte.Invoke(___genericsType, ___parameters);
			address = (System.Byte)___parameters[0];

            return (System.Byte)___result;
        }


        public static System.Double VolatileRead(ref System.Double  @address)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address};
            var ___result = RVolatileRead_Ref_Double.Invoke(___genericsType, ___parameters);
			address = (System.Double)___parameters[0];

            return (System.Double)___result;
        }


        public static System.Int16 VolatileRead(ref System.Int16  @address)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address};
            var ___result = RVolatileRead_Ref_Int16.Invoke(___genericsType, ___parameters);
			address = (System.Int16)___parameters[0];

            return (System.Int16)___result;
        }


        public static System.Int32 VolatileRead(ref System.Int32  @address)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address};
            var ___result = RVolatileRead_Ref_Int32.Invoke(___genericsType, ___parameters);
			address = (System.Int32)___parameters[0];

            return (System.Int32)___result;
        }


        public static System.Int64 VolatileRead(ref System.Int64  @address)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address};
            var ___result = RVolatileRead_Ref_Int64.Invoke(___genericsType, ___parameters);
			address = (System.Int64)___parameters[0];

            return (System.Int64)___result;
        }


        public static System.IntPtr VolatileRead(ref System.IntPtr  @address)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address};
            var ___result = RVolatileRead_Ref_IntPtr.Invoke(___genericsType, ___parameters);
			address = (System.IntPtr)___parameters[0];

            return (System.IntPtr)___result;
        }


        public static System.Object VolatileRead(ref System.Object  @address)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address};
            var ___result = RVolatileRead_Ref_Object.Invoke(___genericsType, ___parameters);
			address = (System.Object)___parameters[0];

            return (System.Object)___result;
        }


        public static System.SByte VolatileRead(ref System.SByte  @address)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address};
            var ___result = RVolatileRead_Ref_SByte.Invoke(___genericsType, ___parameters);
			address = (System.SByte)___parameters[0];

            return (System.SByte)___result;
        }


        public static System.Single VolatileRead(ref System.Single  @address)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address};
            var ___result = RVolatileRead_Ref_Single.Invoke(___genericsType, ___parameters);
			address = (System.Single)___parameters[0];

            return (System.Single)___result;
        }


        public static System.UInt16 VolatileRead(ref System.UInt16  @address)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address};
            var ___result = RVolatileRead_Ref_UInt16.Invoke(___genericsType, ___parameters);
			address = (System.UInt16)___parameters[0];

            return (System.UInt16)___result;
        }


        public static System.UInt32 VolatileRead(ref System.UInt32  @address)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address};
            var ___result = RVolatileRead_Ref_UInt32.Invoke(___genericsType, ___parameters);
			address = (System.UInt32)___parameters[0];

            return (System.UInt32)___result;
        }


        public static System.UInt64 VolatileRead(ref System.UInt64  @address)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address};
            var ___result = RVolatileRead_Ref_UInt64.Invoke(___genericsType, ___parameters);
			address = (System.UInt64)___parameters[0];

            return (System.UInt64)___result;
        }


        public static System.UIntPtr VolatileRead(ref System.UIntPtr  @address)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address};
            var ___result = RVolatileRead_Ref_UIntPtr.Invoke(___genericsType, ___parameters);
			address = (System.UIntPtr)___parameters[0];

            return (System.UIntPtr)___result;
        }


        public static void VolatileWrite(ref System.Byte  @address, System.Byte  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address, @value};
            var ___result = RVolatileWrite_Ref_Byte_Byte.Invoke(___genericsType, ___parameters);
			address = (System.Byte)___parameters[0];

            
        }


        public static void VolatileWrite(ref System.Double  @address, System.Double  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address, @value};
            var ___result = RVolatileWrite_Ref_Double_Double.Invoke(___genericsType, ___parameters);
			address = (System.Double)___parameters[0];

            
        }


        public static void VolatileWrite(ref System.Int16  @address, System.Int16  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address, @value};
            var ___result = RVolatileWrite_Ref_Int16_Int16.Invoke(___genericsType, ___parameters);
			address = (System.Int16)___parameters[0];

            
        }


        public static void VolatileWrite(ref System.Int32  @address, System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address, @value};
            var ___result = RVolatileWrite_Ref_Int32_Int32.Invoke(___genericsType, ___parameters);
			address = (System.Int32)___parameters[0];

            
        }


        public static void VolatileWrite(ref System.Int64  @address, System.Int64  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address, @value};
            var ___result = RVolatileWrite_Ref_Int64_Int64.Invoke(___genericsType, ___parameters);
			address = (System.Int64)___parameters[0];

            
        }


        public static void VolatileWrite(ref System.IntPtr  @address, System.IntPtr  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address, @value};
            var ___result = RVolatileWrite_Ref_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);
			address = (System.IntPtr)___parameters[0];

            
        }


        public static void VolatileWrite(ref System.Object  @address, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address, @value};
            var ___result = RVolatileWrite_Ref_Object_Object.Invoke(___genericsType, ___parameters);
			address = (System.Object)___parameters[0];

            
        }


        public static void VolatileWrite(ref System.SByte  @address, System.SByte  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address, @value};
            var ___result = RVolatileWrite_Ref_SByte_SByte.Invoke(___genericsType, ___parameters);
			address = (System.SByte)___parameters[0];

            
        }


        public static void VolatileWrite(ref System.Single  @address, System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address, @value};
            var ___result = RVolatileWrite_Ref_Single_Single.Invoke(___genericsType, ___parameters);
			address = (System.Single)___parameters[0];

            
        }


        public static void VolatileWrite(ref System.UInt16  @address, System.UInt16  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address, @value};
            var ___result = RVolatileWrite_Ref_UInt16_UInt16.Invoke(___genericsType, ___parameters);
			address = (System.UInt16)___parameters[0];

            
        }


        public static void VolatileWrite(ref System.UInt32  @address, System.UInt32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address, @value};
            var ___result = RVolatileWrite_Ref_UInt32_UInt32.Invoke(___genericsType, ___parameters);
			address = (System.UInt32)___parameters[0];

            
        }


        public static void VolatileWrite(ref System.UInt64  @address, System.UInt64  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address, @value};
            var ___result = RVolatileWrite_Ref_UInt64_UInt64.Invoke(___genericsType, ___parameters);
			address = (System.UInt64)___parameters[0];

            
        }


        public static void VolatileWrite(ref System.UIntPtr  @address, System.UIntPtr  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address, @value};
            var ___result = RVolatileWrite_Ref_UIntPtr_UIntPtr.Invoke(___genericsType, ___parameters);
			address = (System.UIntPtr)___parameters[0];

            
        }


        public static System.Int32 SystemMaxStackStize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystemMaxStackStize.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 GetProcessDefaultStackSize(System.Int32  @maxStackSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@maxStackSize};
            var ___result = RGetProcessDefaultStackSize_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void SetStart(System.MulticastDelegate  @start, System.Int32  @maxStackSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @maxStackSize};
            var ___result = RSetStart_MulticastDelegate_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void BeginCriticalRegion()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBeginCriticalRegion.Invoke(___genericsType, ___parameters);

            
        }


        public static void EndCriticalRegion()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REndCriticalRegion.Invoke(___genericsType, ___parameters);

            
        }


        public static void BeginThreadAffinity()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBeginThreadAffinity.Invoke(___genericsType, ___parameters);

            
        }


        public static void EndThreadAffinity()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REndThreadAffinity.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Threading.ApartmentState GetApartmentState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetApartmentState.Invoke(___genericsType, ___parameters);

            return (System.Threading.ApartmentState)___result;
        }


        public virtual void SetApartmentState(System.Threading.ApartmentState  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state};
            var ___result = RSetApartmentState_ApartmentState.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TrySetApartmentState(System.Threading.ApartmentState  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state};
            var ___result = RTrySetApartmentState_ApartmentState.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static void GetStackTraces(out System.Threading.Thread[]  @threads, out System.Object[]  @stack_frames)
        {
			threads = default;
			stack_frames = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@threads, @stack_frames};
            var ___result = RGetStackTraces_Out_ThreadArray_Out_ObjectArray.Invoke(___genericsType, ___parameters);
			threads = (System.Threading.Thread[])___parameters[0];
			stack_frames = (System.Object[])___parameters[1];

            
        }


        public static System.Collections.Generic.Dictionary<System.Threading.Thread, System.Diagnostics.StackTrace> Mono_GetStackTraces()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMono_GetStackTraces.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.Dictionary<System.Threading.Thread, System.Diagnostics.StackTrace>)___result;
        }


        public virtual void DisableComObjectEagerCleanup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDisableComObjectEagerCleanup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Threading.ThreadState ValidateThreadState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RValidateThreadState.Invoke(___genericsType, ___parameters);

            return (System.Threading.ThreadState)___result;
        }


        public static System.Int32 GetCurrentProcessorId()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCurrentProcessorId.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
