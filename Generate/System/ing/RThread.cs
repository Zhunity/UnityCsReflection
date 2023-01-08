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
		protected static RMethod r_AsyncLocalSetCurrentCulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_;
		public static RMethod RAsyncLocalSetCurrentCulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_
		{
			get
			{
				if(r_AsyncLocalSetCurrentCulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_ == null)
				{
					r_AsyncLocalSetCurrentCulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_ = new(typeof(System.Threading.Thread), "AsyncLocalSetCurrentCulture", 0, typeof(System.Threading.AsyncLocalValueChangedArgs<>).MakeGenericType(typeof(System.Globalization.CultureInfo)));
					r_AsyncLocalSetCurrentCulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_.SetBelong(null);
				}
				return r_AsyncLocalSetCurrentCulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_;
			}
		}

		/// <summary>
		/// Void AsyncLocalSetCurrentUICulture(System.Threading.AsyncLocalValueChangedArgs`1[System.Globalization.CultureInfo])
		/// </summary>
		protected static RMethod r_AsyncLocalSetCurrentUICulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_;
		public static RMethod RAsyncLocalSetCurrentUICulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_
		{
			get
			{
				if(r_AsyncLocalSetCurrentUICulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_ == null)
				{
					r_AsyncLocalSetCurrentUICulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_ = new(typeof(System.Threading.Thread), "AsyncLocalSetCurrentUICulture", 0, typeof(System.Threading.AsyncLocalValueChangedArgs<>).MakeGenericType(typeof(System.Globalization.CultureInfo)));
					r_AsyncLocalSetCurrentUICulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_.SetBelong(null);
				}
				return r_AsyncLocalSetCurrentUICulture_AsyncLocalValueChangedArgs_d_CultureInfo_p_;
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
		/// Void Start(System.Object)
		/// </summary>
		protected RMethod r_Start_Object;
		public virtual RMethod RStart_Object
		{
			get
			{
				if(r_Start_Object == null)
				{
					r_Start_Object = new(this, "Start", 0, typeof(System.Object));
					r_Start_Object.SetBelong(this.instance);
				}
				return r_Start_Object;
			}
		}

		/// <summary>
		/// Void Start(System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected RMethod r_Start_Ref_StackCrawlMark;
		public virtual RMethod RStart_Ref_StackCrawlMark
		{
			get
			{
				if(r_Start_Ref_StackCrawlMark == null)
				{
					r_Start_Ref_StackCrawlMark = new(this, "Start", 0,  ReflectionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
					r_Start_Ref_StackCrawlMark.SetBelong(this.instance);
				}
				return r_Start_Ref_StackCrawlMark;
			}
		}

		/// <summary>
		/// Reader GetExecutionContextReader()
		/// </summary>
		protected RMethod r_GetExecutionContextReader;
		public virtual RMethod RGetExecutionContextReader
		{
			get
			{
				if(r_GetExecutionContextReader == null)
				{
					r_GetExecutionContextReader = new(this, "GetExecutionContextReader", 0);
					r_GetExecutionContextReader.SetBelong(this.instance);
				}
				return r_GetExecutionContextReader;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext GetMutableExecutionContext()
		/// </summary>
		protected RMethod r_GetMutableExecutionContext;
		public virtual RMethod RGetMutableExecutionContext
		{
			get
			{
				if(r_GetMutableExecutionContext == null)
				{
					r_GetMutableExecutionContext = new(this, "GetMutableExecutionContext", 0);
					r_GetMutableExecutionContext.SetBelong(this.instance);
				}
				return r_GetMutableExecutionContext;
			}
		}

		/// <summary>
		/// Void SetExecutionContext(System.Threading.ExecutionContext, Boolean)
		/// </summary>
		protected RMethod r_SetExecutionContext_ExecutionContext_Boolean;
		public virtual RMethod RSetExecutionContext_ExecutionContext_Boolean
		{
			get
			{
				if(r_SetExecutionContext_ExecutionContext_Boolean == null)
				{
					r_SetExecutionContext_ExecutionContext_Boolean = new(this, "SetExecutionContext", 0, typeof(System.Threading.ExecutionContext), typeof(System.Boolean));
					r_SetExecutionContext_ExecutionContext_Boolean.SetBelong(this.instance);
				}
				return r_SetExecutionContext_ExecutionContext_Boolean;
			}
		}

		/// <summary>
		/// Void SetExecutionContext(Reader, Boolean)
		/// </summary>
		protected RMethod r_SetExecutionContext_Reader_Boolean;
		public virtual RMethod RSetExecutionContext_Reader_Boolean
		{
			get
			{
				if(r_SetExecutionContext_Reader_Boolean == null)
				{
					r_SetExecutionContext_Reader_Boolean = new(this, "SetExecutionContext", 0,  ReflectionUtils.GetType("System.Threading.ExecutionContext+Reader"), typeof(System.Boolean));
					r_SetExecutionContext_Reader_Boolean.SetBelong(this.instance);
				}
				return r_SetExecutionContext_Reader_Boolean;
			}
		}

		/// <summary>
		/// Void SetCompressedStack(System.Threading.CompressedStack)
		/// </summary>
		protected RMethod r_SetCompressedStack_CompressedStack;
		public virtual RMethod RSetCompressedStack_CompressedStack
		{
			get
			{
				if(r_SetCompressedStack_CompressedStack == null)
				{
					r_SetCompressedStack_CompressedStack = new(this, "SetCompressedStack", 0, typeof(System.Threading.CompressedStack));
					r_SetCompressedStack_CompressedStack.SetBelong(this.instance);
				}
				return r_SetCompressedStack_CompressedStack;
			}
		}

		/// <summary>
		/// System.Threading.CompressedStack GetCompressedStack()
		/// </summary>
		protected RMethod r_GetCompressedStack;
		public virtual RMethod RGetCompressedStack
		{
			get
			{
				if(r_GetCompressedStack == null)
				{
					r_GetCompressedStack = new(this, "GetCompressedStack", 0);
					r_GetCompressedStack.SetBelong(this.instance);
				}
				return r_GetCompressedStack;
			}
		}

		/// <summary>
		/// Void ResetAbort()
		/// </summary>
		protected static RMethod r_ResetAbort;
		public static RMethod RResetAbort
		{
			get
			{
				if(r_ResetAbort == null)
				{
					r_ResetAbort = new(typeof(System.Threading.Thread), "ResetAbort", 0);
					r_ResetAbort.SetBelong(null);
				}
				return r_ResetAbort;
			}
		}

		/// <summary>
		/// Void ResetAbortNative()
		/// </summary>
		protected RMethod r_ResetAbortNative;
		public virtual RMethod RResetAbortNative
		{
			get
			{
				if(r_ResetAbortNative == null)
				{
					r_ResetAbortNative = new(this, "ResetAbortNative", 0);
					r_ResetAbortNative.SetBelong(this.instance);
				}
				return r_ResetAbortNative;
			}
		}

		/// <summary>
		/// Void Suspend()
		/// </summary>
		protected RMethod r_Suspend;
		public virtual RMethod RSuspend
		{
			get
			{
				if(r_Suspend == null)
				{
					r_Suspend = new(this, "Suspend", 0);
					r_Suspend.SetBelong(this.instance);
				}
				return r_Suspend;
			}
		}

		/// <summary>
		/// Void SuspendInternal()
		/// </summary>
		protected RMethod r_SuspendInternal;
		public virtual RMethod RSuspendInternal
		{
			get
			{
				if(r_SuspendInternal == null)
				{
					r_SuspendInternal = new(this, "SuspendInternal", 0);
					r_SuspendInternal.SetBelong(this.instance);
				}
				return r_SuspendInternal;
			}
		}

		/// <summary>
		/// Void Resume()
		/// </summary>
		protected RMethod r_Resume;
		public virtual RMethod RResume
		{
			get
			{
				if(r_Resume == null)
				{
					r_Resume = new(this, "Resume", 0);
					r_Resume.SetBelong(this.instance);
				}
				return r_Resume;
			}
		}

		/// <summary>
		/// Void ResumeInternal()
		/// </summary>
		protected RMethod r_ResumeInternal;
		public virtual RMethod RResumeInternal
		{
			get
			{
				if(r_ResumeInternal == null)
				{
					r_ResumeInternal = new(this, "ResumeInternal", 0);
					r_ResumeInternal.SetBelong(this.instance);
				}
				return r_ResumeInternal;
			}
		}

		/// <summary>
		/// Void Interrupt()
		/// </summary>
		protected RMethod r_Interrupt;
		public virtual RMethod RInterrupt
		{
			get
			{
				if(r_Interrupt == null)
				{
					r_Interrupt = new(this, "Interrupt", 0);
					r_Interrupt.SetBelong(this.instance);
				}
				return r_Interrupt;
			}
		}

		/// <summary>
		/// Void InterruptInternal()
		/// </summary>
		protected RMethod r_InterruptInternal;
		public virtual RMethod RInterruptInternal
		{
			get
			{
				if(r_InterruptInternal == null)
				{
					r_InterruptInternal = new(this, "InterruptInternal", 0);
					r_InterruptInternal.SetBelong(this.instance);
				}
				return r_InterruptInternal;
			}
		}

		/// <summary>
		/// Int32 GetPriorityNative()
		/// </summary>
		protected RMethod r_GetPriorityNative;
		public virtual RMethod RGetPriorityNative
		{
			get
			{
				if(r_GetPriorityNative == null)
				{
					r_GetPriorityNative = new(this, "GetPriorityNative", 0);
					r_GetPriorityNative.SetBelong(this.instance);
				}
				return r_GetPriorityNative;
			}
		}

		/// <summary>
		/// Void SetPriorityNative(Int32)
		/// </summary>
		protected RMethod r_SetPriorityNative_Int32;
		public virtual RMethod RSetPriorityNative_Int32
		{
			get
			{
				if(r_SetPriorityNative_Int32 == null)
				{
					r_SetPriorityNative_Int32 = new(this, "SetPriorityNative", 0, typeof(System.Int32));
					r_SetPriorityNative_Int32.SetBelong(this.instance);
				}
				return r_SetPriorityNative_Int32;
			}
		}

		/// <summary>
		/// Boolean JoinInternal(Int32)
		/// </summary>
		protected RMethod r_JoinInternal_Int32;
		public virtual RMethod RJoinInternal_Int32
		{
			get
			{
				if(r_JoinInternal_Int32 == null)
				{
					r_JoinInternal_Int32 = new(this, "JoinInternal", 0, typeof(System.Int32));
					r_JoinInternal_Int32.SetBelong(this.instance);
				}
				return r_JoinInternal_Int32;
			}
		}

		/// <summary>
		/// Void Join()
		/// </summary>
		protected RMethod r_Join;
		public virtual RMethod RJoin
		{
			get
			{
				if(r_Join == null)
				{
					r_Join = new(this, "Join", 0);
					r_Join.SetBelong(this.instance);
				}
				return r_Join;
			}
		}

		/// <summary>
		/// Boolean Join(Int32)
		/// </summary>
		protected RMethod r_Join_Int32;
		public virtual RMethod RJoin_Int32
		{
			get
			{
				if(r_Join_Int32 == null)
				{
					r_Join_Int32 = new(this, "Join", 0, typeof(System.Int32));
					r_Join_Int32.SetBelong(this.instance);
				}
				return r_Join_Int32;
			}
		}

		/// <summary>
		/// Boolean Join(System.TimeSpan)
		/// </summary>
		protected RMethod r_Join_TimeSpan;
		public virtual RMethod RJoin_TimeSpan
		{
			get
			{
				if(r_Join_TimeSpan == null)
				{
					r_Join_TimeSpan = new(this, "Join", 0, typeof(System.TimeSpan));
					r_Join_TimeSpan.SetBelong(this.instance);
				}
				return r_Join_TimeSpan;
			}
		}

		/// <summary>
		/// Void SleepInternal(Int32)
		/// </summary>
		protected static RMethod r_SleepInternal_Int32;
		public static RMethod RSleepInternal_Int32
		{
			get
			{
				if(r_SleepInternal_Int32 == null)
				{
					r_SleepInternal_Int32 = new(typeof(System.Threading.Thread), "SleepInternal", 0, typeof(System.Int32));
					r_SleepInternal_Int32.SetBelong(null);
				}
				return r_SleepInternal_Int32;
			}
		}

		/// <summary>
		/// Void Sleep(Int32)
		/// </summary>
		protected static RMethod r_Sleep_Int32;
		public static RMethod RSleep_Int32
		{
			get
			{
				if(r_Sleep_Int32 == null)
				{
					r_Sleep_Int32 = new(typeof(System.Threading.Thread), "Sleep", 0, typeof(System.Int32));
					r_Sleep_Int32.SetBelong(null);
				}
				return r_Sleep_Int32;
			}
		}

		/// <summary>
		/// Void Sleep(System.TimeSpan)
		/// </summary>
		protected static RMethod r_Sleep_TimeSpan;
		public static RMethod RSleep_TimeSpan
		{
			get
			{
				if(r_Sleep_TimeSpan == null)
				{
					r_Sleep_TimeSpan = new(typeof(System.Threading.Thread), "Sleep", 0, typeof(System.TimeSpan));
					r_Sleep_TimeSpan.SetBelong(null);
				}
				return r_Sleep_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean YieldInternal()
		/// </summary>
		protected static RMethod r_YieldInternal;
		public static RMethod RYieldInternal
		{
			get
			{
				if(r_YieldInternal == null)
				{
					r_YieldInternal = new(typeof(System.Threading.Thread), "YieldInternal", 0);
					r_YieldInternal.SetBelong(null);
				}
				return r_YieldInternal;
			}
		}

		/// <summary>
		/// Boolean Yield()
		/// </summary>
		protected static RMethod r_Yield;
		public static RMethod RYield
		{
			get
			{
				if(r_Yield == null)
				{
					r_Yield = new(typeof(System.Threading.Thread), "Yield", 0);
					r_Yield.SetBelong(null);
				}
				return r_Yield;
			}
		}

		/// <summary>
		/// Void SetStartHelper(System.Delegate, Int32)
		/// </summary>
		protected RMethod r_SetStartHelper_Delegate_Int32;
		public virtual RMethod RSetStartHelper_Delegate_Int32
		{
			get
			{
				if(r_SetStartHelper_Delegate_Int32 == null)
				{
					r_SetStartHelper_Delegate_Int32 = new(this, "SetStartHelper", 0, typeof(System.Delegate), typeof(System.Int32));
					r_SetStartHelper_Delegate_Int32.SetBelong(this.instance);
				}
				return r_SetStartHelper_Delegate_Int32;
			}
		}

		/// <summary>
		/// System.LocalDataStoreSlot AllocateDataSlot()
		/// </summary>
		protected static RMethod r_AllocateDataSlot;
		public static RMethod RAllocateDataSlot
		{
			get
			{
				if(r_AllocateDataSlot == null)
				{
					r_AllocateDataSlot = new(typeof(System.Threading.Thread), "AllocateDataSlot", 0);
					r_AllocateDataSlot.SetBelong(null);
				}
				return r_AllocateDataSlot;
			}
		}

		/// <summary>
		/// System.LocalDataStoreSlot AllocateNamedDataSlot(System.String)
		/// </summary>
		protected static RMethod r_AllocateNamedDataSlot_String;
		public static RMethod RAllocateNamedDataSlot_String
		{
			get
			{
				if(r_AllocateNamedDataSlot_String == null)
				{
					r_AllocateNamedDataSlot_String = new(typeof(System.Threading.Thread), "AllocateNamedDataSlot", 0, typeof(System.String));
					r_AllocateNamedDataSlot_String.SetBelong(null);
				}
				return r_AllocateNamedDataSlot_String;
			}
		}

		/// <summary>
		/// System.LocalDataStoreSlot GetNamedDataSlot(System.String)
		/// </summary>
		protected static RMethod r_GetNamedDataSlot_String;
		public static RMethod RGetNamedDataSlot_String
		{
			get
			{
				if(r_GetNamedDataSlot_String == null)
				{
					r_GetNamedDataSlot_String = new(typeof(System.Threading.Thread), "GetNamedDataSlot", 0, typeof(System.String));
					r_GetNamedDataSlot_String.SetBelong(null);
				}
				return r_GetNamedDataSlot_String;
			}
		}

		/// <summary>
		/// Void FreeNamedDataSlot(System.String)
		/// </summary>
		protected static RMethod r_FreeNamedDataSlot_String;
		public static RMethod RFreeNamedDataSlot_String
		{
			get
			{
				if(r_FreeNamedDataSlot_String == null)
				{
					r_FreeNamedDataSlot_String = new(typeof(System.Threading.Thread), "FreeNamedDataSlot", 0, typeof(System.String));
					r_FreeNamedDataSlot_String.SetBelong(null);
				}
				return r_FreeNamedDataSlot_String;
			}
		}

		/// <summary>
		/// System.Object GetData(System.LocalDataStoreSlot)
		/// </summary>
		protected static RMethod r_GetData_LocalDataStoreSlot;
		public static RMethod RGetData_LocalDataStoreSlot
		{
			get
			{
				if(r_GetData_LocalDataStoreSlot == null)
				{
					r_GetData_LocalDataStoreSlot = new(typeof(System.Threading.Thread), "GetData", 0, typeof(System.LocalDataStoreSlot));
					r_GetData_LocalDataStoreSlot.SetBelong(null);
				}
				return r_GetData_LocalDataStoreSlot;
			}
		}

		/// <summary>
		/// Void SetData(System.LocalDataStoreSlot, System.Object)
		/// </summary>
		protected static RMethod r_SetData_LocalDataStoreSlot_Object;
		public static RMethod RSetData_LocalDataStoreSlot_Object
		{
			get
			{
				if(r_SetData_LocalDataStoreSlot_Object == null)
				{
					r_SetData_LocalDataStoreSlot_Object = new(typeof(System.Threading.Thread), "SetData", 0, typeof(System.LocalDataStoreSlot), typeof(System.Object));
					r_SetData_LocalDataStoreSlot_Object.SetBelong(null);
				}
				return r_SetData_LocalDataStoreSlot_Object;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo GetCurrentUICultureNoAppX()
		/// </summary>
		protected RMethod r_GetCurrentUICultureNoAppX;
		public virtual RMethod RGetCurrentUICultureNoAppX
		{
			get
			{
				if(r_GetCurrentUICultureNoAppX == null)
				{
					r_GetCurrentUICultureNoAppX = new(this, "GetCurrentUICultureNoAppX", 0);
					r_GetCurrentUICultureNoAppX.SetBelong(this.instance);
				}
				return r_GetCurrentUICultureNoAppX;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo GetCurrentCultureNoAppX()
		/// </summary>
		protected RMethod r_GetCurrentCultureNoAppX;
		public virtual RMethod RGetCurrentCultureNoAppX
		{
			get
			{
				if(r_GetCurrentCultureNoAppX == null)
				{
					r_GetCurrentCultureNoAppX = new(this, "GetCurrentCultureNoAppX", 0);
					r_GetCurrentCultureNoAppX.SetBelong(this.instance);
				}
				return r_GetCurrentCultureNoAppX;
			}
		}

		/// <summary>
		/// Void nativeInitCultureAccessors()
		/// </summary>
		protected static RMethod r_nativeInitCultureAccessors;
		public static RMethod RnativeInitCultureAccessors
		{
			get
			{
				if(r_nativeInitCultureAccessors == null)
				{
					r_nativeInitCultureAccessors = new(typeof(System.Threading.Thread), "nativeInitCultureAccessors", 0);
					r_nativeInitCultureAccessors.SetBelong(null);
				}
				return r_nativeInitCultureAccessors;
			}
		}

		/// <summary>
		/// Void MemoryBarrier()
		/// </summary>
		protected static RMethod r_MemoryBarrier;
		public static RMethod RMemoryBarrier
		{
			get
			{
				if(r_MemoryBarrier == null)
				{
					r_MemoryBarrier = new(typeof(System.Threading.Thread), "MemoryBarrier", 0);
					r_MemoryBarrier.SetBelong(null);
				}
				return r_MemoryBarrier;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._Thread.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___Thread__2__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___Thread__2__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___Thread__2__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_System__2__Runtime__2__InteropServices__2___Thread__2__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._Thread.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
					r_System__2__Runtime__2__InteropServices__2___Thread__2__GetTypeInfoCount_Out_UInt32.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___Thread__2__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._Thread.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___Thread__2__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___Thread__2__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___Thread__2__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_System__2__Runtime__2__InteropServices__2___Thread__2__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._Thread.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_System__2__Runtime__2__InteropServices__2___Thread__2__GetTypeInfo_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___Thread__2__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._Thread.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___Thread__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___Thread__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___Thread__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_System__2__Runtime__2__InteropServices__2___Thread__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._Thread.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_System__2__Runtime__2__InteropServices__2___Thread__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___Thread__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._Thread.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___Thread__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___Thread__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___Thread__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_System__2__Runtime__2__InteropServices__2___Thread__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._Thread.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
					r_System__2__Runtime__2__InteropServices__2___Thread__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___Thread__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// Void ConstructInternalThread()
		/// </summary>
		protected RMethod r_ConstructInternalThread;
		public virtual RMethod RConstructInternalThread
		{
			get
			{
				if(r_ConstructInternalThread == null)
				{
					r_ConstructInternalThread = new(this, "ConstructInternalThread", 0);
					r_ConstructInternalThread.SetBelong(this.instance);
				}
				return r_ConstructInternalThread;
			}
		}

		/// <summary>
		/// Byte[] ByteArrayToRootDomain(Byte[])
		/// </summary>
		protected static RMethod r_ByteArrayToRootDomain_ByteArray;
		public static RMethod RByteArrayToRootDomain_ByteArray
		{
			get
			{
				if(r_ByteArrayToRootDomain_ByteArray == null)
				{
					r_ByteArrayToRootDomain_ByteArray = new(typeof(System.Threading.Thread), "ByteArrayToRootDomain", 0, typeof(System.Byte).MakeArrayType());
					r_ByteArrayToRootDomain_ByteArray.SetBelong(null);
				}
				return r_ByteArrayToRootDomain_ByteArray;
			}
		}

		/// <summary>
		/// Byte[] ByteArrayToCurrentDomain(Byte[])
		/// </summary>
		protected static RMethod r_ByteArrayToCurrentDomain_ByteArray;
		public static RMethod RByteArrayToCurrentDomain_ByteArray
		{
			get
			{
				if(r_ByteArrayToCurrentDomain_ByteArray == null)
				{
					r_ByteArrayToCurrentDomain_ByteArray = new(typeof(System.Threading.Thread), "ByteArrayToCurrentDomain", 0, typeof(System.Byte).MakeArrayType());
					r_ByteArrayToCurrentDomain_ByteArray.SetBelong(null);
				}
				return r_ByteArrayToCurrentDomain_ByteArray;
			}
		}

		/// <summary>
		/// Void DeserializePrincipal(System.Threading.Thread)
		/// </summary>
		protected static RMethod r_DeserializePrincipal_Thread;
		public static RMethod RDeserializePrincipal_Thread
		{
			get
			{
				if(r_DeserializePrincipal_Thread == null)
				{
					r_DeserializePrincipal_Thread = new(typeof(System.Threading.Thread), "DeserializePrincipal", 0, typeof(System.Threading.Thread));
					r_DeserializePrincipal_Thread.SetBelong(null);
				}
				return r_DeserializePrincipal_Thread;
			}
		}

		/// <summary>
		/// Void SerializePrincipal(System.Threading.Thread, System.Security.Principal.IPrincipal)
		/// </summary>
		protected static RMethod r_SerializePrincipal_Thread_IPrincipal;
		public static RMethod RSerializePrincipal_Thread_IPrincipal
		{
			get
			{
				if(r_SerializePrincipal_Thread_IPrincipal == null)
				{
					r_SerializePrincipal_Thread_IPrincipal = new(typeof(System.Threading.Thread), "SerializePrincipal", 0, typeof(System.Threading.Thread), typeof(System.Security.Principal.IPrincipal));
					r_SerializePrincipal_Thread_IPrincipal.SetBelong(null);
				}
				return r_SerializePrincipal_Thread_IPrincipal;
			}
		}

		/// <summary>
		/// System.AppDomain GetDomain()
		/// </summary>
		protected static RMethod r_GetDomain;
		public static RMethod RGetDomain
		{
			get
			{
				if(r_GetDomain == null)
				{
					r_GetDomain = new(typeof(System.Threading.Thread), "GetDomain", 0);
					r_GetDomain.SetBelong(null);
				}
				return r_GetDomain;
			}
		}

		/// <summary>
		/// Void GetCurrentThread_icall(System.Threading.Thread ByRef)
		/// </summary>
		protected static RMethod r_GetCurrentThread_icall_Ref_Thread;
		public static RMethod RGetCurrentThread_icall_Ref_Thread
		{
			get
			{
				if(r_GetCurrentThread_icall_Ref_Thread == null)
				{
					r_GetCurrentThread_icall_Ref_Thread = new(typeof(System.Threading.Thread), "GetCurrentThread_icall", 0, typeof(System.Threading.Thread).MakeByRefType());
					r_GetCurrentThread_icall_Ref_Thread.SetBelong(null);
				}
				return r_GetCurrentThread_icall_Ref_Thread;
			}
		}

		/// <summary>
		/// System.Threading.Thread GetCurrentThread()
		/// </summary>
		protected static RMethod r_GetCurrentThread;
		public static RMethod RGetCurrentThread
		{
			get
			{
				if(r_GetCurrentThread == null)
				{
					r_GetCurrentThread = new(typeof(System.Threading.Thread), "GetCurrentThread", 0);
					r_GetCurrentThread.SetBelong(null);
				}
				return r_GetCurrentThread;
			}
		}

		/// <summary>
		/// Int32 GetDomainID()
		/// </summary>
		protected static RMethod r_GetDomainID;
		public static RMethod RGetDomainID
		{
			get
			{
				if(r_GetDomainID == null)
				{
					r_GetDomainID = new(typeof(System.Threading.Thread), "GetDomainID", 0);
					r_GetDomainID.SetBelong(null);
				}
				return r_GetDomainID;
			}
		}

		/// <summary>
		/// Boolean Thread_internal(System.MulticastDelegate)
		/// </summary>
		protected RMethod r_Thread_internal_MulticastDelegate;
		public virtual RMethod RThread_internal_MulticastDelegate
		{
			get
			{
				if(r_Thread_internal_MulticastDelegate == null)
				{
					r_Thread_internal_MulticastDelegate = new(this, "Thread_internal", 0, typeof(System.MulticastDelegate));
					r_Thread_internal_MulticastDelegate.SetBelong(this.instance);
				}
				return r_Thread_internal_MulticastDelegate;
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
		/// System.String GetName_internal(System.Threading.InternalThread)
		/// </summary>
		protected static RMethod r_GetName_internal_InternalThread;
		public static RMethod RGetName_internal_InternalThread
		{
			get
			{
				if(r_GetName_internal_InternalThread == null)
				{
					r_GetName_internal_InternalThread = new(typeof(System.Threading.Thread), "GetName_internal", 0,  ReflectionUtils.GetType("System.Threading.InternalThread"));
					r_GetName_internal_InternalThread.SetBelong(null);
				}
				return r_GetName_internal_InternalThread;
			}
		}

		/// <summary>
		/// Void SetName_icall(System.Threading.InternalThread, Char*, Int32)
		/// </summary>
		protected static RMethod r_SetName_icall_InternalThread_CharPointer_Int32;
		public static RMethod RSetName_icall_InternalThread_CharPointer_Int32
		{
			get
			{
				if(r_SetName_icall_InternalThread_CharPointer_Int32 == null)
				{
					r_SetName_icall_InternalThread_CharPointer_Int32 = new(typeof(System.Threading.Thread), "SetName_icall", 0,  ReflectionUtils.GetType("System.Threading.InternalThread"), typeof(System.Char).MakePointerType(), typeof(System.Int32));
					r_SetName_icall_InternalThread_CharPointer_Int32.SetBelong(null);
				}
				return r_SetName_icall_InternalThread_CharPointer_Int32;
			}
		}

		/// <summary>
		/// Void SetName_internal(System.Threading.InternalThread, System.String)
		/// </summary>
		protected static RMethod r_SetName_internal_InternalThread_String;
		public static RMethod RSetName_internal_InternalThread_String
		{
			get
			{
				if(r_SetName_internal_InternalThread_String == null)
				{
					r_SetName_internal_InternalThread_String = new(typeof(System.Threading.Thread), "SetName_internal", 0,  ReflectionUtils.GetType("System.Threading.InternalThread"), typeof(System.String));
					r_SetName_internal_InternalThread_String.SetBelong(null);
				}
				return r_SetName_internal_InternalThread_String;
			}
		}

		/// <summary>
		/// Void Abort_internal(System.Threading.InternalThread, System.Object)
		/// </summary>
		protected static RMethod r_Abort_internal_InternalThread_Object;
		public static RMethod RAbort_internal_InternalThread_Object
		{
			get
			{
				if(r_Abort_internal_InternalThread_Object == null)
				{
					r_Abort_internal_InternalThread_Object = new(typeof(System.Threading.Thread), "Abort_internal", 0,  ReflectionUtils.GetType("System.Threading.InternalThread"), typeof(System.Object));
					r_Abort_internal_InternalThread_Object.SetBelong(null);
				}
				return r_Abort_internal_InternalThread_Object;
			}
		}

		/// <summary>
		/// Void Abort()
		/// </summary>
		protected RMethod r_Abort;
		public virtual RMethod RAbort
		{
			get
			{
				if(r_Abort == null)
				{
					r_Abort = new(this, "Abort", 0);
					r_Abort.SetBelong(this.instance);
				}
				return r_Abort;
			}
		}

		/// <summary>
		/// Void Abort(System.Object)
		/// </summary>
		protected RMethod r_Abort_Object;
		public virtual RMethod RAbort_Object
		{
			get
			{
				if(r_Abort_Object == null)
				{
					r_Abort_Object = new(this, "Abort", 0, typeof(System.Object));
					r_Abort_Object.SetBelong(this.instance);
				}
				return r_Abort_Object;
			}
		}

		/// <summary>
		/// System.Object GetAbortExceptionState()
		/// </summary>
		protected RMethod r_GetAbortExceptionState;
		public virtual RMethod RGetAbortExceptionState
		{
			get
			{
				if(r_GetAbortExceptionState == null)
				{
					r_GetAbortExceptionState = new(this, "GetAbortExceptionState", 0);
					r_GetAbortExceptionState.SetBelong(this.instance);
				}
				return r_GetAbortExceptionState;
			}
		}

		/// <summary>
		/// Void ClearAbortReason()
		/// </summary>
		protected RMethod r_ClearAbortReason;
		public virtual RMethod RClearAbortReason
		{
			get
			{
				if(r_ClearAbortReason == null)
				{
					r_ClearAbortReason = new(this, "ClearAbortReason", 0);
					r_ClearAbortReason.SetBelong(this.instance);
				}
				return r_ClearAbortReason;
			}
		}

		/// <summary>
		/// Void SpinWait_nop()
		/// </summary>
		protected static RMethod r_SpinWait_nop;
		public static RMethod RSpinWait_nop
		{
			get
			{
				if(r_SpinWait_nop == null)
				{
					r_SpinWait_nop = new(typeof(System.Threading.Thread), "SpinWait_nop", 0);
					r_SpinWait_nop.SetBelong(null);
				}
				return r_SpinWait_nop;
			}
		}

		/// <summary>
		/// Void SpinWait(Int32)
		/// </summary>
		protected static RMethod r_SpinWait_Int32;
		public static RMethod RSpinWait_Int32
		{
			get
			{
				if(r_SpinWait_Int32 == null)
				{
					r_SpinWait_Int32 = new(typeof(System.Threading.Thread), "SpinWait", 0, typeof(System.Int32));
					r_SpinWait_Int32.SetBelong(null);
				}
				return r_SpinWait_Int32;
			}
		}

		/// <summary>
		/// Void StartInternal(System.Object, System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected RMethod r_StartInternal_Object_Ref_StackCrawlMark;
		public virtual RMethod RStartInternal_Object_Ref_StackCrawlMark
		{
			get
			{
				if(r_StartInternal_Object_Ref_StackCrawlMark == null)
				{
					r_StartInternal_Object_Ref_StackCrawlMark = new(this, "StartInternal", 0, typeof(System.Object),  ReflectionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
					r_StartInternal_Object_Ref_StackCrawlMark.SetBelong(this.instance);
				}
				return r_StartInternal_Object_Ref_StackCrawlMark;
			}
		}

		/// <summary>
		/// Void SetState(System.Threading.InternalThread, System.Threading.ThreadState)
		/// </summary>
		protected static RMethod r_SetState_InternalThread_ThreadState;
		public static RMethod RSetState_InternalThread_ThreadState
		{
			get
			{
				if(r_SetState_InternalThread_ThreadState == null)
				{
					r_SetState_InternalThread_ThreadState = new(typeof(System.Threading.Thread), "SetState", 0,  ReflectionUtils.GetType("System.Threading.InternalThread"), typeof(System.Threading.ThreadState));
					r_SetState_InternalThread_ThreadState.SetBelong(null);
				}
				return r_SetState_InternalThread_ThreadState;
			}
		}

		/// <summary>
		/// Void ClrState(System.Threading.InternalThread, System.Threading.ThreadState)
		/// </summary>
		protected static RMethod r_ClrState_InternalThread_ThreadState;
		public static RMethod RClrState_InternalThread_ThreadState
		{
			get
			{
				if(r_ClrState_InternalThread_ThreadState == null)
				{
					r_ClrState_InternalThread_ThreadState = new(typeof(System.Threading.Thread), "ClrState", 0,  ReflectionUtils.GetType("System.Threading.InternalThread"), typeof(System.Threading.ThreadState));
					r_ClrState_InternalThread_ThreadState.SetBelong(null);
				}
				return r_ClrState_InternalThread_ThreadState;
			}
		}

		/// <summary>
		/// System.Threading.ThreadState GetState(System.Threading.InternalThread)
		/// </summary>
		protected static RMethod r_GetState_InternalThread;
		public static RMethod RGetState_InternalThread
		{
			get
			{
				if(r_GetState_InternalThread == null)
				{
					r_GetState_InternalThread = new(typeof(System.Threading.Thread), "GetState", 0,  ReflectionUtils.GetType("System.Threading.InternalThread"));
					r_GetState_InternalThread.SetBelong(null);
				}
				return r_GetState_InternalThread;
			}
		}

		/// <summary>
		/// Byte VolatileRead(Byte ByRef)
		/// </summary>
		protected static RMethod r_VolatileRead_Ref_Byte;
		public static RMethod RVolatileRead_Ref_Byte
		{
			get
			{
				if(r_VolatileRead_Ref_Byte == null)
				{
					r_VolatileRead_Ref_Byte = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.Byte).MakeByRefType());
					r_VolatileRead_Ref_Byte.SetBelong(null);
				}
				return r_VolatileRead_Ref_Byte;
			}
		}

		/// <summary>
		/// Double VolatileRead(Double ByRef)
		/// </summary>
		protected static RMethod r_VolatileRead_Ref_Double;
		public static RMethod RVolatileRead_Ref_Double
		{
			get
			{
				if(r_VolatileRead_Ref_Double == null)
				{
					r_VolatileRead_Ref_Double = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.Double).MakeByRefType());
					r_VolatileRead_Ref_Double.SetBelong(null);
				}
				return r_VolatileRead_Ref_Double;
			}
		}

		/// <summary>
		/// Int16 VolatileRead(Int16 ByRef)
		/// </summary>
		protected static RMethod r_VolatileRead_Ref_Int16;
		public static RMethod RVolatileRead_Ref_Int16
		{
			get
			{
				if(r_VolatileRead_Ref_Int16 == null)
				{
					r_VolatileRead_Ref_Int16 = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.Int16).MakeByRefType());
					r_VolatileRead_Ref_Int16.SetBelong(null);
				}
				return r_VolatileRead_Ref_Int16;
			}
		}

		/// <summary>
		/// Int32 VolatileRead(Int32 ByRef)
		/// </summary>
		protected static RMethod r_VolatileRead_Ref_Int32;
		public static RMethod RVolatileRead_Ref_Int32
		{
			get
			{
				if(r_VolatileRead_Ref_Int32 == null)
				{
					r_VolatileRead_Ref_Int32 = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.Int32).MakeByRefType());
					r_VolatileRead_Ref_Int32.SetBelong(null);
				}
				return r_VolatileRead_Ref_Int32;
			}
		}

		/// <summary>
		/// Int64 VolatileRead(Int64 ByRef)
		/// </summary>
		protected static RMethod r_VolatileRead_Ref_Int64;
		public static RMethod RVolatileRead_Ref_Int64
		{
			get
			{
				if(r_VolatileRead_Ref_Int64 == null)
				{
					r_VolatileRead_Ref_Int64 = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.Int64).MakeByRefType());
					r_VolatileRead_Ref_Int64.SetBelong(null);
				}
				return r_VolatileRead_Ref_Int64;
			}
		}

		/// <summary>
		/// IntPtr VolatileRead(IntPtr ByRef)
		/// </summary>
		protected static RMethod r_VolatileRead_Ref_IntPtr;
		public static RMethod RVolatileRead_Ref_IntPtr
		{
			get
			{
				if(r_VolatileRead_Ref_IntPtr == null)
				{
					r_VolatileRead_Ref_IntPtr = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.IntPtr).MakeByRefType());
					r_VolatileRead_Ref_IntPtr.SetBelong(null);
				}
				return r_VolatileRead_Ref_IntPtr;
			}
		}

		/// <summary>
		/// System.Object VolatileRead(System.Object ByRef)
		/// </summary>
		protected static RMethod r_VolatileRead_Ref_Object;
		public static RMethod RVolatileRead_Ref_Object
		{
			get
			{
				if(r_VolatileRead_Ref_Object == null)
				{
					r_VolatileRead_Ref_Object = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.Object).MakeByRefType());
					r_VolatileRead_Ref_Object.SetBelong(null);
				}
				return r_VolatileRead_Ref_Object;
			}
		}

		/// <summary>
		/// SByte VolatileRead(SByte ByRef)
		/// </summary>
		protected static RMethod r_VolatileRead_Ref_SByte;
		public static RMethod RVolatileRead_Ref_SByte
		{
			get
			{
				if(r_VolatileRead_Ref_SByte == null)
				{
					r_VolatileRead_Ref_SByte = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.SByte).MakeByRefType());
					r_VolatileRead_Ref_SByte.SetBelong(null);
				}
				return r_VolatileRead_Ref_SByte;
			}
		}

		/// <summary>
		/// Single VolatileRead(Single ByRef)
		/// </summary>
		protected static RMethod r_VolatileRead_Ref_Single;
		public static RMethod RVolatileRead_Ref_Single
		{
			get
			{
				if(r_VolatileRead_Ref_Single == null)
				{
					r_VolatileRead_Ref_Single = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.Single).MakeByRefType());
					r_VolatileRead_Ref_Single.SetBelong(null);
				}
				return r_VolatileRead_Ref_Single;
			}
		}

		/// <summary>
		/// UInt16 VolatileRead(UInt16 ByRef)
		/// </summary>
		protected static RMethod r_VolatileRead_Ref_UInt16;
		public static RMethod RVolatileRead_Ref_UInt16
		{
			get
			{
				if(r_VolatileRead_Ref_UInt16 == null)
				{
					r_VolatileRead_Ref_UInt16 = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.UInt16).MakeByRefType());
					r_VolatileRead_Ref_UInt16.SetBelong(null);
				}
				return r_VolatileRead_Ref_UInt16;
			}
		}

		/// <summary>
		/// UInt32 VolatileRead(UInt32 ByRef)
		/// </summary>
		protected static RMethod r_VolatileRead_Ref_UInt32;
		public static RMethod RVolatileRead_Ref_UInt32
		{
			get
			{
				if(r_VolatileRead_Ref_UInt32 == null)
				{
					r_VolatileRead_Ref_UInt32 = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.UInt32).MakeByRefType());
					r_VolatileRead_Ref_UInt32.SetBelong(null);
				}
				return r_VolatileRead_Ref_UInt32;
			}
		}

		/// <summary>
		/// UInt64 VolatileRead(UInt64 ByRef)
		/// </summary>
		protected static RMethod r_VolatileRead_Ref_UInt64;
		public static RMethod RVolatileRead_Ref_UInt64
		{
			get
			{
				if(r_VolatileRead_Ref_UInt64 == null)
				{
					r_VolatileRead_Ref_UInt64 = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.UInt64).MakeByRefType());
					r_VolatileRead_Ref_UInt64.SetBelong(null);
				}
				return r_VolatileRead_Ref_UInt64;
			}
		}

		/// <summary>
		/// UIntPtr VolatileRead(UIntPtr ByRef)
		/// </summary>
		protected static RMethod r_VolatileRead_Ref_UIntPtr;
		public static RMethod RVolatileRead_Ref_UIntPtr
		{
			get
			{
				if(r_VolatileRead_Ref_UIntPtr == null)
				{
					r_VolatileRead_Ref_UIntPtr = new(typeof(System.Threading.Thread), "VolatileRead", 0, typeof(System.UIntPtr).MakeByRefType());
					r_VolatileRead_Ref_UIntPtr.SetBelong(null);
				}
				return r_VolatileRead_Ref_UIntPtr;
			}
		}

		/// <summary>
		/// Void VolatileWrite(Byte ByRef, Byte)
		/// </summary>
		protected static RMethod r_VolatileWrite_Ref_Byte_Byte;
		public static RMethod RVolatileWrite_Ref_Byte_Byte
		{
			get
			{
				if(r_VolatileWrite_Ref_Byte_Byte == null)
				{
					r_VolatileWrite_Ref_Byte_Byte = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.Byte).MakeByRefType(), typeof(System.Byte));
					r_VolatileWrite_Ref_Byte_Byte.SetBelong(null);
				}
				return r_VolatileWrite_Ref_Byte_Byte;
			}
		}

		/// <summary>
		/// Void VolatileWrite(Double ByRef, Double)
		/// </summary>
		protected static RMethod r_VolatileWrite_Ref_Double_Double;
		public static RMethod RVolatileWrite_Ref_Double_Double
		{
			get
			{
				if(r_VolatileWrite_Ref_Double_Double == null)
				{
					r_VolatileWrite_Ref_Double_Double = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.Double).MakeByRefType(), typeof(System.Double));
					r_VolatileWrite_Ref_Double_Double.SetBelong(null);
				}
				return r_VolatileWrite_Ref_Double_Double;
			}
		}

		/// <summary>
		/// Void VolatileWrite(Int16 ByRef, Int16)
		/// </summary>
		protected static RMethod r_VolatileWrite_Ref_Int16_Int16;
		public static RMethod RVolatileWrite_Ref_Int16_Int16
		{
			get
			{
				if(r_VolatileWrite_Ref_Int16_Int16 == null)
				{
					r_VolatileWrite_Ref_Int16_Int16 = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.Int16).MakeByRefType(), typeof(System.Int16));
					r_VolatileWrite_Ref_Int16_Int16.SetBelong(null);
				}
				return r_VolatileWrite_Ref_Int16_Int16;
			}
		}

		/// <summary>
		/// Void VolatileWrite(Int32 ByRef, Int32)
		/// </summary>
		protected static RMethod r_VolatileWrite_Ref_Int32_Int32;
		public static RMethod RVolatileWrite_Ref_Int32_Int32
		{
			get
			{
				if(r_VolatileWrite_Ref_Int32_Int32 == null)
				{
					r_VolatileWrite_Ref_Int32_Int32 = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.Int32).MakeByRefType(), typeof(System.Int32));
					r_VolatileWrite_Ref_Int32_Int32.SetBelong(null);
				}
				return r_VolatileWrite_Ref_Int32_Int32;
			}
		}

		/// <summary>
		/// Void VolatileWrite(Int64 ByRef, Int64)
		/// </summary>
		protected static RMethod r_VolatileWrite_Ref_Int64_Int64;
		public static RMethod RVolatileWrite_Ref_Int64_Int64
		{
			get
			{
				if(r_VolatileWrite_Ref_Int64_Int64 == null)
				{
					r_VolatileWrite_Ref_Int64_Int64 = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.Int64).MakeByRefType(), typeof(System.Int64));
					r_VolatileWrite_Ref_Int64_Int64.SetBelong(null);
				}
				return r_VolatileWrite_Ref_Int64_Int64;
			}
		}

		/// <summary>
		/// Void VolatileWrite(IntPtr ByRef, IntPtr)
		/// </summary>
		protected static RMethod r_VolatileWrite_Ref_IntPtr_IntPtr;
		public static RMethod RVolatileWrite_Ref_IntPtr_IntPtr
		{
			get
			{
				if(r_VolatileWrite_Ref_IntPtr_IntPtr == null)
				{
					r_VolatileWrite_Ref_IntPtr_IntPtr = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.IntPtr).MakeByRefType(), typeof(System.IntPtr));
					r_VolatileWrite_Ref_IntPtr_IntPtr.SetBelong(null);
				}
				return r_VolatileWrite_Ref_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// Void VolatileWrite(System.Object ByRef, System.Object)
		/// </summary>
		protected static RMethod r_VolatileWrite_Ref_Object_Object;
		public static RMethod RVolatileWrite_Ref_Object_Object
		{
			get
			{
				if(r_VolatileWrite_Ref_Object_Object == null)
				{
					r_VolatileWrite_Ref_Object_Object = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.Object).MakeByRefType(), typeof(System.Object));
					r_VolatileWrite_Ref_Object_Object.SetBelong(null);
				}
				return r_VolatileWrite_Ref_Object_Object;
			}
		}

		/// <summary>
		/// Void VolatileWrite(SByte ByRef, SByte)
		/// </summary>
		protected static RMethod r_VolatileWrite_Ref_SByte_SByte;
		public static RMethod RVolatileWrite_Ref_SByte_SByte
		{
			get
			{
				if(r_VolatileWrite_Ref_SByte_SByte == null)
				{
					r_VolatileWrite_Ref_SByte_SByte = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.SByte).MakeByRefType(), typeof(System.SByte));
					r_VolatileWrite_Ref_SByte_SByte.SetBelong(null);
				}
				return r_VolatileWrite_Ref_SByte_SByte;
			}
		}

		/// <summary>
		/// Void VolatileWrite(Single ByRef, Single)
		/// </summary>
		protected static RMethod r_VolatileWrite_Ref_Single_Single;
		public static RMethod RVolatileWrite_Ref_Single_Single
		{
			get
			{
				if(r_VolatileWrite_Ref_Single_Single == null)
				{
					r_VolatileWrite_Ref_Single_Single = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.Single).MakeByRefType(), typeof(System.Single));
					r_VolatileWrite_Ref_Single_Single.SetBelong(null);
				}
				return r_VolatileWrite_Ref_Single_Single;
			}
		}

		/// <summary>
		/// Void VolatileWrite(UInt16 ByRef, UInt16)
		/// </summary>
		protected static RMethod r_VolatileWrite_Ref_UInt16_UInt16;
		public static RMethod RVolatileWrite_Ref_UInt16_UInt16
		{
			get
			{
				if(r_VolatileWrite_Ref_UInt16_UInt16 == null)
				{
					r_VolatileWrite_Ref_UInt16_UInt16 = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.UInt16).MakeByRefType(), typeof(System.UInt16));
					r_VolatileWrite_Ref_UInt16_UInt16.SetBelong(null);
				}
				return r_VolatileWrite_Ref_UInt16_UInt16;
			}
		}

		/// <summary>
		/// Void VolatileWrite(UInt32 ByRef, UInt32)
		/// </summary>
		protected static RMethod r_VolatileWrite_Ref_UInt32_UInt32;
		public static RMethod RVolatileWrite_Ref_UInt32_UInt32
		{
			get
			{
				if(r_VolatileWrite_Ref_UInt32_UInt32 == null)
				{
					r_VolatileWrite_Ref_UInt32_UInt32 = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.UInt32).MakeByRefType(), typeof(System.UInt32));
					r_VolatileWrite_Ref_UInt32_UInt32.SetBelong(null);
				}
				return r_VolatileWrite_Ref_UInt32_UInt32;
			}
		}

		/// <summary>
		/// Void VolatileWrite(UInt64 ByRef, UInt64)
		/// </summary>
		protected static RMethod r_VolatileWrite_Ref_UInt64_UInt64;
		public static RMethod RVolatileWrite_Ref_UInt64_UInt64
		{
			get
			{
				if(r_VolatileWrite_Ref_UInt64_UInt64 == null)
				{
					r_VolatileWrite_Ref_UInt64_UInt64 = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.UInt64).MakeByRefType(), typeof(System.UInt64));
					r_VolatileWrite_Ref_UInt64_UInt64.SetBelong(null);
				}
				return r_VolatileWrite_Ref_UInt64_UInt64;
			}
		}

		/// <summary>
		/// Void VolatileWrite(UIntPtr ByRef, UIntPtr)
		/// </summary>
		protected static RMethod r_VolatileWrite_Ref_UIntPtr_UIntPtr;
		public static RMethod RVolatileWrite_Ref_UIntPtr_UIntPtr
		{
			get
			{
				if(r_VolatileWrite_Ref_UIntPtr_UIntPtr == null)
				{
					r_VolatileWrite_Ref_UIntPtr_UIntPtr = new(typeof(System.Threading.Thread), "VolatileWrite", 0, typeof(System.UIntPtr).MakeByRefType(), typeof(System.UIntPtr));
					r_VolatileWrite_Ref_UIntPtr_UIntPtr.SetBelong(null);
				}
				return r_VolatileWrite_Ref_UIntPtr_UIntPtr;
			}
		}

		/// <summary>
		/// Int32 SystemMaxStackStize()
		/// </summary>
		protected static RMethod r_SystemMaxStackStize;
		public static RMethod RSystemMaxStackStize
		{
			get
			{
				if(r_SystemMaxStackStize == null)
				{
					r_SystemMaxStackStize = new(typeof(System.Threading.Thread), "SystemMaxStackStize", 0);
					r_SystemMaxStackStize.SetBelong(null);
				}
				return r_SystemMaxStackStize;
			}
		}

		/// <summary>
		/// Int32 GetProcessDefaultStackSize(Int32)
		/// </summary>
		protected static RMethod r_GetProcessDefaultStackSize_Int32;
		public static RMethod RGetProcessDefaultStackSize_Int32
		{
			get
			{
				if(r_GetProcessDefaultStackSize_Int32 == null)
				{
					r_GetProcessDefaultStackSize_Int32 = new(typeof(System.Threading.Thread), "GetProcessDefaultStackSize", 0, typeof(System.Int32));
					r_GetProcessDefaultStackSize_Int32.SetBelong(null);
				}
				return r_GetProcessDefaultStackSize_Int32;
			}
		}

		/// <summary>
		/// Void SetStart(System.MulticastDelegate, Int32)
		/// </summary>
		protected RMethod r_SetStart_MulticastDelegate_Int32;
		public virtual RMethod RSetStart_MulticastDelegate_Int32
		{
			get
			{
				if(r_SetStart_MulticastDelegate_Int32 == null)
				{
					r_SetStart_MulticastDelegate_Int32 = new(this, "SetStart", 0, typeof(System.MulticastDelegate), typeof(System.Int32));
					r_SetStart_MulticastDelegate_Int32.SetBelong(this.instance);
				}
				return r_SetStart_MulticastDelegate_Int32;
			}
		}

		/// <summary>
		/// Void BeginCriticalRegion()
		/// </summary>
		protected static RMethod r_BeginCriticalRegion;
		public static RMethod RBeginCriticalRegion
		{
			get
			{
				if(r_BeginCriticalRegion == null)
				{
					r_BeginCriticalRegion = new(typeof(System.Threading.Thread), "BeginCriticalRegion", 0);
					r_BeginCriticalRegion.SetBelong(null);
				}
				return r_BeginCriticalRegion;
			}
		}

		/// <summary>
		/// Void EndCriticalRegion()
		/// </summary>
		protected static RMethod r_EndCriticalRegion;
		public static RMethod REndCriticalRegion
		{
			get
			{
				if(r_EndCriticalRegion == null)
				{
					r_EndCriticalRegion = new(typeof(System.Threading.Thread), "EndCriticalRegion", 0);
					r_EndCriticalRegion.SetBelong(null);
				}
				return r_EndCriticalRegion;
			}
		}

		/// <summary>
		/// Void BeginThreadAffinity()
		/// </summary>
		protected static RMethod r_BeginThreadAffinity;
		public static RMethod RBeginThreadAffinity
		{
			get
			{
				if(r_BeginThreadAffinity == null)
				{
					r_BeginThreadAffinity = new(typeof(System.Threading.Thread), "BeginThreadAffinity", 0);
					r_BeginThreadAffinity.SetBelong(null);
				}
				return r_BeginThreadAffinity;
			}
		}

		/// <summary>
		/// Void EndThreadAffinity()
		/// </summary>
		protected static RMethod r_EndThreadAffinity;
		public static RMethod REndThreadAffinity
		{
			get
			{
				if(r_EndThreadAffinity == null)
				{
					r_EndThreadAffinity = new(typeof(System.Threading.Thread), "EndThreadAffinity", 0);
					r_EndThreadAffinity.SetBelong(null);
				}
				return r_EndThreadAffinity;
			}
		}

		/// <summary>
		/// System.Threading.ApartmentState GetApartmentState()
		/// </summary>
		protected RMethod r_GetApartmentState;
		public virtual RMethod RGetApartmentState
		{
			get
			{
				if(r_GetApartmentState == null)
				{
					r_GetApartmentState = new(this, "GetApartmentState", 0);
					r_GetApartmentState.SetBelong(this.instance);
				}
				return r_GetApartmentState;
			}
		}

		/// <summary>
		/// Void SetApartmentState(System.Threading.ApartmentState)
		/// </summary>
		protected RMethod r_SetApartmentState_ApartmentState;
		public virtual RMethod RSetApartmentState_ApartmentState
		{
			get
			{
				if(r_SetApartmentState_ApartmentState == null)
				{
					r_SetApartmentState_ApartmentState = new(this, "SetApartmentState", 0, typeof(System.Threading.ApartmentState));
					r_SetApartmentState_ApartmentState.SetBelong(this.instance);
				}
				return r_SetApartmentState_ApartmentState;
			}
		}

		/// <summary>
		/// Boolean TrySetApartmentState(System.Threading.ApartmentState)
		/// </summary>
		protected RMethod r_TrySetApartmentState_ApartmentState;
		public virtual RMethod RTrySetApartmentState_ApartmentState
		{
			get
			{
				if(r_TrySetApartmentState_ApartmentState == null)
				{
					r_TrySetApartmentState_ApartmentState = new(this, "TrySetApartmentState", 0, typeof(System.Threading.ApartmentState));
					r_TrySetApartmentState_ApartmentState.SetBelong(this.instance);
				}
				return r_TrySetApartmentState_ApartmentState;
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
		/// Void GetStackTraces(System.Threading.Thread[] ByRef, System.Object[] ByRef)
		/// </summary>
		protected static RMethod r_GetStackTraces_Out_ThreadArray_Out_ObjectArray;
		public static RMethod RGetStackTraces_Out_ThreadArray_Out_ObjectArray
		{
			get
			{
				if(r_GetStackTraces_Out_ThreadArray_Out_ObjectArray == null)
				{
					r_GetStackTraces_Out_ThreadArray_Out_ObjectArray = new(typeof(System.Threading.Thread), "GetStackTraces", 0, typeof(System.Threading.Thread).MakeArrayType().MakeByRefType(), typeof(System.Object).MakeArrayType().MakeByRefType());
					r_GetStackTraces_Out_ThreadArray_Out_ObjectArray.SetBelong(null);
				}
				return r_GetStackTraces_Out_ThreadArray_Out_ObjectArray;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Threading.Thread,System.Diagnostics.StackTrace] Mono_GetStackTraces()
		/// </summary>
		protected static RMethod r_Mono_GetStackTraces;
		public static RMethod RMono_GetStackTraces
		{
			get
			{
				if(r_Mono_GetStackTraces == null)
				{
					r_Mono_GetStackTraces = new(typeof(System.Threading.Thread), "Mono_GetStackTraces", 0);
					r_Mono_GetStackTraces.SetBelong(null);
				}
				return r_Mono_GetStackTraces;
			}
		}

		/// <summary>
		/// Void DisableComObjectEagerCleanup()
		/// </summary>
		protected RMethod r_DisableComObjectEagerCleanup;
		public virtual RMethod RDisableComObjectEagerCleanup
		{
			get
			{
				if(r_DisableComObjectEagerCleanup == null)
				{
					r_DisableComObjectEagerCleanup = new(this, "DisableComObjectEagerCleanup", 0);
					r_DisableComObjectEagerCleanup.SetBelong(this.instance);
				}
				return r_DisableComObjectEagerCleanup;
			}
		}

		/// <summary>
		/// System.Threading.ThreadState ValidateThreadState()
		/// </summary>
		protected RMethod r_ValidateThreadState;
		public virtual RMethod RValidateThreadState
		{
			get
			{
				if(r_ValidateThreadState == null)
				{
					r_ValidateThreadState = new(this, "ValidateThreadState", 0);
					r_ValidateThreadState.SetBelong(this.instance);
				}
				return r_ValidateThreadState;
			}
		}

		/// <summary>
		/// Int32 GetCurrentProcessorId()
		/// </summary>
		protected static RMethod r_GetCurrentProcessorId;
		public static RMethod RGetCurrentProcessorId
		{
			get
			{
				if(r_GetCurrentProcessorId == null)
				{
					r_GetCurrentProcessorId = new(typeof(System.Threading.Thread), "GetCurrentProcessorId", 0);
					r_GetCurrentProcessorId.SetBelong(null);
				}
				return r_GetCurrentProcessorId;
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


        public virtual void System__2__Runtime__2__InteropServices__2___Thread__2__GetTypeInfoCount(out System.UInt32  @pcTInfo)
        {
			pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___Thread__2__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___Thread__2__GetTypeInfo(System.UInt32  @iTInfo, System.UInt32  @lcid, System.IntPtr  @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___Thread__2__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___Thread__2__GetIDsOfNames(in System.Guid  @riid, System.IntPtr  @rgszNames, System.UInt32  @cNames, System.UInt32  @lcid, System.IntPtr  @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___Thread__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___Thread__2__Invoke(System.UInt32  @dispIdMember, in System.Guid  @riid, System.UInt32  @lcid, System.Int16  @wFlags, System.IntPtr  @pDispParams, System.IntPtr  @pVarResult, System.IntPtr  @pExcepInfo, System.IntPtr  @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___Thread__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
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
