using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.ExecutionContext
	/// </summary>
    public partial class RExecutionContext : RMember //
    {

		/// <summary>
		/// System.Threading.SynchronizationContext _syncContext
		/// </summary>
		protected RSystem.RThreading.RSynchronizationContext r__syncContext;
		public virtual RSystem.RThreading.RSynchronizationContext R_syncContext
		{
			get
			{
				if(r__syncContext == null)
				{
					r__syncContext = new(this, "_syncContext");
					r__syncContext.SetBelong(this.instance);
				}
				return r__syncContext;
			}
		}

		/// <summary>
		/// System.Threading.SynchronizationContext _syncContextNoFlow
		/// </summary>
		protected RSystem.RThreading.RSynchronizationContext r__syncContextNoFlow;
		public virtual RSystem.RThreading.RSynchronizationContext R_syncContextNoFlow
		{
			get
			{
				if(r__syncContextNoFlow == null)
				{
					r__syncContextNoFlow = new(this, "_syncContextNoFlow");
					r__syncContextNoFlow.SetBelong(this.instance);
				}
				return r__syncContextNoFlow;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.LogicalCallContext _logicalCallContext
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RMessaging.RLogicalCallContext r__logicalCallContext;
		public virtual RSystem.RRuntime.RRemoting.RMessaging.RLogicalCallContext R_logicalCallContext
		{
			get
			{
				if(r__logicalCallContext == null)
				{
					r__logicalCallContext = new(this, "_logicalCallContext");
					r__logicalCallContext.SetBelong(this.instance);
				}
				return r__logicalCallContext;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IllogicalCallContext _illogicalCallContext
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RMessaging.RIllogicalCallContext r__illogicalCallContext;
		public virtual RSystem.RRuntime.RRemoting.RMessaging.RIllogicalCallContext R_illogicalCallContext
		{
			get
			{
				if(r__illogicalCallContext == null)
				{
					r__illogicalCallContext = new(this, "_illogicalCallContext");
					r__illogicalCallContext.SetBelong(this.instance);
				}
				return r__illogicalCallContext;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext+Flags _flags
		/// </summary>
		protected RField r__flags;
		public virtual RField R_flags
		{
			get
			{
				if(r__flags == null)
				{
					r__flags = new(this, "_flags");
					r__flags.SetBelong(this.instance);
				}
				return r__flags;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Threading.IAsyncLocal,System.Object] _localValues
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RThreading.RIAsyncLocal, RSystem.RObject> r__localValues;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RThreading.RIAsyncLocal, RSystem.RObject> R_localValues
		{
			get
			{
				if(r__localValues == null)
				{
					r__localValues = new(this, "_localValues");
					r__localValues.SetBelong(this.instance);
				}
				return r__localValues;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Threading.IAsyncLocal] _localChangeNotifications
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSystem.RThreading.RIAsyncLocal> r__localChangeNotifications;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RThreading.RIAsyncLocal> R_localChangeNotifications
		{
			get
			{
				if(r__localChangeNotifications == null)
				{
					r__localChangeNotifications = new(this, "_localChangeNotifications");
					r__localChangeNotifications.SetBelong(this.instance);
				}
				return r__localChangeNotifications;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext s_dummyDefaultEC
		/// </summary>
		protected static RSystem.RThreading.RExecutionContext r_s_dummyDefaultEC;
		public static RSystem.RThreading.RExecutionContext Rs_dummyDefaultEC
		{
			get
			{
				if(r_s_dummyDefaultEC == null)
				{
					r_s_dummyDefaultEC = new(typeof(System.Threading.ExecutionContext), "s_dummyDefaultEC");
					r_s_dummyDefaultEC.SetBelong(null);
				}
				return r_s_dummyDefaultEC;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext Default
		/// </summary>
		protected static RSystem.RThreading.RExecutionContext r_Default;
		public static RSystem.RThreading.RExecutionContext RDefault
		{
			get
			{
				if(r_Default == null)
				{
					r_Default = new(typeof(System.Threading.ExecutionContext), "Default");
					r_Default.SetBelong(null);
				}
				return r_Default;
			}
		}

		/// <summary>
		/// Boolean isNewCapture
		/// </summary>
		protected RSystem.RBoolean r_isNewCapture;
		public virtual RSystem.RBoolean RisNewCapture
		{
			get
			{
				if(r_isNewCapture == null)
				{
					r_isNewCapture = new(this, "isNewCapture", -1);
					r_isNewCapture.SetBelong(this.instance);
				}
				return r_isNewCapture;
			}
		}

		/// <summary>
		/// Boolean isFlowSuppressed
		/// </summary>
		protected RSystem.RBoolean r_isFlowSuppressed;
		public virtual RSystem.RBoolean RisFlowSuppressed
		{
			get
			{
				if(r_isFlowSuppressed == null)
				{
					r_isFlowSuppressed = new(this, "isFlowSuppressed", -1);
					r_isFlowSuppressed.SetBelong(this.instance);
				}
				return r_isFlowSuppressed;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext PreAllocatedDefault
		/// </summary>
		protected static RSystem.RThreading.RExecutionContext r_PreAllocatedDefault;
		public static RSystem.RThreading.RExecutionContext RPreAllocatedDefault
		{
			get
			{
				if(r_PreAllocatedDefault == null)
				{
					r_PreAllocatedDefault = new(typeof(System.Threading.ExecutionContext), "PreAllocatedDefault", -1);
					r_PreAllocatedDefault.SetBelong(null);
				}
				return r_PreAllocatedDefault;
			}
		}

		/// <summary>
		/// Boolean IsPreAllocatedDefault
		/// </summary>
		protected RSystem.RBoolean r_IsPreAllocatedDefault;
		public virtual RSystem.RBoolean RIsPreAllocatedDefault
		{
			get
			{
				if(r_IsPreAllocatedDefault == null)
				{
					r_IsPreAllocatedDefault = new(this, "IsPreAllocatedDefault", -1);
					r_IsPreAllocatedDefault.SetBelong(this.instance);
				}
				return r_IsPreAllocatedDefault;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.LogicalCallContext LogicalCallContext
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RMessaging.RLogicalCallContext r_LogicalCallContext;
		public virtual RSystem.RRuntime.RRemoting.RMessaging.RLogicalCallContext RLogicalCallContext
		{
			get
			{
				if(r_LogicalCallContext == null)
				{
					r_LogicalCallContext = new(this, "LogicalCallContext", -1);
					r_LogicalCallContext.SetBelong(this.instance);
				}
				return r_LogicalCallContext;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IllogicalCallContext IllogicalCallContext
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RMessaging.RIllogicalCallContext r_IllogicalCallContext;
		public virtual RSystem.RRuntime.RRemoting.RMessaging.RIllogicalCallContext RIllogicalCallContext
		{
			get
			{
				if(r_IllogicalCallContext == null)
				{
					r_IllogicalCallContext = new(this, "IllogicalCallContext", -1);
					r_IllogicalCallContext.SetBelong(this.instance);
				}
				return r_IllogicalCallContext;
			}
		}

		/// <summary>
		/// System.Threading.SynchronizationContext SynchronizationContext
		/// </summary>
		protected RSystem.RThreading.RSynchronizationContext r_SynchronizationContext;
		public virtual RSystem.RThreading.RSynchronizationContext RSynchronizationContext
		{
			get
			{
				if(r_SynchronizationContext == null)
				{
					r_SynchronizationContext = new(this, "SynchronizationContext", -1);
					r_SynchronizationContext.SetBelong(this.instance);
				}
				return r_SynchronizationContext;
			}
		}

		/// <summary>
		/// System.Threading.SynchronizationContext SynchronizationContextNoFlow
		/// </summary>
		protected RSystem.RThreading.RSynchronizationContext r_SynchronizationContextNoFlow;
		public virtual RSystem.RThreading.RSynchronizationContext RSynchronizationContextNoFlow
		{
			get
			{
				if(r_SynchronizationContextNoFlow == null)
				{
					r_SynchronizationContextNoFlow = new(this, "SynchronizationContextNoFlow", -1);
					r_SynchronizationContextNoFlow.SetBelong(this.instance);
				}
				return r_SynchronizationContextNoFlow;
			}
		}

		/// <summary>
		/// System.Object GetLocalValue(System.Threading.IAsyncLocal)
		/// </summary>
		protected static RMethod r_GetLocalValue_IAsyncLocal;
		public static RMethod RGetLocalValue_IAsyncLocal
		{
			get
			{
				if(r_GetLocalValue_IAsyncLocal == null)
				{
					r_GetLocalValue_IAsyncLocal = new(typeof(System.Threading.ExecutionContext), "GetLocalValue", 0,  ReflectionUtils.GetType("System.Threading.IAsyncLocal"));
					r_GetLocalValue_IAsyncLocal.SetBelong(null);
				}
				return r_GetLocalValue_IAsyncLocal;
			}
		}

		/// <summary>
		/// Void SetLocalValue(System.Threading.IAsyncLocal, System.Object, Boolean)
		/// </summary>
		protected static RMethod r_SetLocalValue_IAsyncLocal_Object_Boolean;
		public static RMethod RSetLocalValue_IAsyncLocal_Object_Boolean
		{
			get
			{
				if(r_SetLocalValue_IAsyncLocal_Object_Boolean == null)
				{
					r_SetLocalValue_IAsyncLocal_Object_Boolean = new(typeof(System.Threading.ExecutionContext), "SetLocalValue", 0,  ReflectionUtils.GetType("System.Threading.IAsyncLocal"), typeof(System.Object), typeof(System.Boolean));
					r_SetLocalValue_IAsyncLocal_Object_Boolean.SetBelong(null);
				}
				return r_SetLocalValue_IAsyncLocal_Object_Boolean;
			}
		}

		/// <summary>
		/// Void OnAsyncLocalContextChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
		/// </summary>
		protected static RMethod r_OnAsyncLocalContextChanged_ExecutionContext_ExecutionContext;
		public static RMethod ROnAsyncLocalContextChanged_ExecutionContext_ExecutionContext
		{
			get
			{
				if(r_OnAsyncLocalContextChanged_ExecutionContext_ExecutionContext == null)
				{
					r_OnAsyncLocalContextChanged_ExecutionContext_ExecutionContext = new(typeof(System.Threading.ExecutionContext), "OnAsyncLocalContextChanged", 0, typeof(System.Threading.ExecutionContext), typeof(System.Threading.ExecutionContext));
					r_OnAsyncLocalContextChanged_ExecutionContext_ExecutionContext.SetBelong(null);
				}
				return r_OnAsyncLocalContextChanged_ExecutionContext_ExecutionContext;
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
		/// Void Run(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object)
		/// </summary>
		protected static RMethod r_Run_ExecutionContext_ContextCallback_Object;
		public static RMethod RRun_ExecutionContext_ContextCallback_Object
		{
			get
			{
				if(r_Run_ExecutionContext_ContextCallback_Object == null)
				{
					r_Run_ExecutionContext_ContextCallback_Object = new(typeof(System.Threading.ExecutionContext), "Run", 0, typeof(System.Threading.ExecutionContext), typeof(System.Threading.ContextCallback), typeof(System.Object));
					r_Run_ExecutionContext_ContextCallback_Object.SetBelong(null);
				}
				return r_Run_ExecutionContext_ContextCallback_Object;
			}
		}

		/// <summary>
		/// Void Run(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)
		/// </summary>
		protected static RMethod r_Run_ExecutionContext_ContextCallback_Object_Boolean;
		public static RMethod RRun_ExecutionContext_ContextCallback_Object_Boolean
		{
			get
			{
				if(r_Run_ExecutionContext_ContextCallback_Object_Boolean == null)
				{
					r_Run_ExecutionContext_ContextCallback_Object_Boolean = new(typeof(System.Threading.ExecutionContext), "Run", 0, typeof(System.Threading.ExecutionContext), typeof(System.Threading.ContextCallback), typeof(System.Object), typeof(System.Boolean));
					r_Run_ExecutionContext_ContextCallback_Object_Boolean.SetBelong(null);
				}
				return r_Run_ExecutionContext_ContextCallback_Object_Boolean;
			}
		}

		/// <summary>
		/// Void RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object)
		/// </summary>
		protected static RMethod r_RunInternal_ExecutionContext_ContextCallback_Object;
		public static RMethod RRunInternal_ExecutionContext_ContextCallback_Object
		{
			get
			{
				if(r_RunInternal_ExecutionContext_ContextCallback_Object == null)
				{
					r_RunInternal_ExecutionContext_ContextCallback_Object = new(typeof(System.Threading.ExecutionContext), "RunInternal", 0, typeof(System.Threading.ExecutionContext), typeof(System.Threading.ContextCallback), typeof(System.Object));
					r_RunInternal_ExecutionContext_ContextCallback_Object.SetBelong(null);
				}
				return r_RunInternal_ExecutionContext_ContextCallback_Object;
			}
		}

		/// <summary>
		/// Void RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)
		/// </summary>
		protected static RMethod r_RunInternal_ExecutionContext_ContextCallback_Object_Boolean;
		public static RMethod RRunInternal_ExecutionContext_ContextCallback_Object_Boolean
		{
			get
			{
				if(r_RunInternal_ExecutionContext_ContextCallback_Object_Boolean == null)
				{
					r_RunInternal_ExecutionContext_ContextCallback_Object_Boolean = new(typeof(System.Threading.ExecutionContext), "RunInternal", 0, typeof(System.Threading.ExecutionContext), typeof(System.Threading.ContextCallback), typeof(System.Object), typeof(System.Boolean));
					r_RunInternal_ExecutionContext_ContextCallback_Object_Boolean.SetBelong(null);
				}
				return r_RunInternal_ExecutionContext_ContextCallback_Object_Boolean;
			}
		}

		/// <summary>
		/// Void RunInternal[TState](System.Threading.ExecutionContext, System.Threading.ContextCallback`1[TState], TState ByRef)
		/// </summary>
		protected static RMethod r_RunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState;
		public static RMethod RRunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState
		{
			get
			{
				if(r_RunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState == null)
				{
					r_RunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState = new(typeof(System.Threading.ExecutionContext), "RunInternal", 1, typeof(System.Threading.ExecutionContext),  ReflectionUtils.GetType("System.Threading.ContextCallback`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_RunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState.SetBelong(null);
				}
				return r_RunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState;
			}
		}

		/// <summary>
		/// Void RunInternal[TState](System.Threading.ExecutionContext, System.Threading.ContextCallback`1[TState], TState ByRef, Boolean)
		/// </summary>
		protected static RMethod r_RunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState_Boolean;
		public static RMethod RRunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState_Boolean
		{
			get
			{
				if(r_RunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState_Boolean == null)
				{
					r_RunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState_Boolean = new(typeof(System.Threading.ExecutionContext), "RunInternal", 1, typeof(System.Threading.ExecutionContext),  ReflectionUtils.GetType("System.Threading.ContextCallback`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0).MakeByRefType(), typeof(System.Boolean));
					r_RunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState_Boolean.SetBelong(null);
				}
				return r_RunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState_Boolean;
			}
		}

		/// <summary>
		/// Void EstablishCopyOnWriteScope(System.Threading.ExecutionContextSwitcher ByRef)
		/// </summary>
		protected static RMethod r_EstablishCopyOnWriteScope_Ref_ExecutionContextSwitcher;
		public static RMethod REstablishCopyOnWriteScope_Ref_ExecutionContextSwitcher
		{
			get
			{
				if(r_EstablishCopyOnWriteScope_Ref_ExecutionContextSwitcher == null)
				{
					r_EstablishCopyOnWriteScope_Ref_ExecutionContextSwitcher = new(typeof(System.Threading.ExecutionContext), "EstablishCopyOnWriteScope", 0,  ReflectionUtils.GetType("System.Threading.ExecutionContextSwitcher").MakeByRefType());
					r_EstablishCopyOnWriteScope_Ref_ExecutionContextSwitcher.SetBelong(null);
				}
				return r_EstablishCopyOnWriteScope_Ref_ExecutionContextSwitcher;
			}
		}

		/// <summary>
		/// Void EstablishCopyOnWriteScope(System.Threading.Thread, Boolean, System.Threading.ExecutionContextSwitcher ByRef)
		/// </summary>
		protected static RMethod r_EstablishCopyOnWriteScope_Thread_Boolean_Ref_ExecutionContextSwitcher;
		public static RMethod REstablishCopyOnWriteScope_Thread_Boolean_Ref_ExecutionContextSwitcher
		{
			get
			{
				if(r_EstablishCopyOnWriteScope_Thread_Boolean_Ref_ExecutionContextSwitcher == null)
				{
					r_EstablishCopyOnWriteScope_Thread_Boolean_Ref_ExecutionContextSwitcher = new(typeof(System.Threading.ExecutionContext), "EstablishCopyOnWriteScope", 0, typeof(System.Threading.Thread), typeof(System.Boolean),  ReflectionUtils.GetType("System.Threading.ExecutionContextSwitcher").MakeByRefType());
					r_EstablishCopyOnWriteScope_Thread_Boolean_Ref_ExecutionContextSwitcher.SetBelong(null);
				}
				return r_EstablishCopyOnWriteScope_Thread_Boolean_Ref_ExecutionContextSwitcher;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContextSwitcher SetExecutionContext(System.Threading.ExecutionContext, Boolean)
		/// </summary>
		protected static RMethod r_SetExecutionContext_ExecutionContext_Boolean;
		public static RMethod RSetExecutionContext_ExecutionContext_Boolean
		{
			get
			{
				if(r_SetExecutionContext_ExecutionContext_Boolean == null)
				{
					r_SetExecutionContext_ExecutionContext_Boolean = new(typeof(System.Threading.ExecutionContext), "SetExecutionContext", 0, typeof(System.Threading.ExecutionContext), typeof(System.Boolean));
					r_SetExecutionContext_ExecutionContext_Boolean.SetBelong(null);
				}
				return r_SetExecutionContext_ExecutionContext_Boolean;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext CreateCopy()
		/// </summary>
		protected RMethod r_CreateCopy;
		public virtual RMethod RCreateCopy
		{
			get
			{
				if(r_CreateCopy == null)
				{
					r_CreateCopy = new(this, "CreateCopy", 0);
					r_CreateCopy.SetBelong(this.instance);
				}
				return r_CreateCopy;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext CreateMutableCopy()
		/// </summary>
		protected RMethod r_CreateMutableCopy;
		public virtual RMethod RCreateMutableCopy
		{
			get
			{
				if(r_CreateMutableCopy == null)
				{
					r_CreateMutableCopy = new(this, "CreateMutableCopy", 0);
					r_CreateMutableCopy.SetBelong(this.instance);
				}
				return r_CreateMutableCopy;
			}
		}

		/// <summary>
		/// System.Threading.AsyncFlowControl SuppressFlow()
		/// </summary>
		protected static RMethod r_SuppressFlow;
		public static RMethod RSuppressFlow
		{
			get
			{
				if(r_SuppressFlow == null)
				{
					r_SuppressFlow = new(typeof(System.Threading.ExecutionContext), "SuppressFlow", 0);
					r_SuppressFlow.SetBelong(null);
				}
				return r_SuppressFlow;
			}
		}

		/// <summary>
		/// Void RestoreFlow()
		/// </summary>
		protected static RMethod r_RestoreFlow;
		public static RMethod RRestoreFlow
		{
			get
			{
				if(r_RestoreFlow == null)
				{
					r_RestoreFlow = new(typeof(System.Threading.ExecutionContext), "RestoreFlow", 0);
					r_RestoreFlow.SetBelong(null);
				}
				return r_RestoreFlow;
			}
		}

		/// <summary>
		/// Boolean IsFlowSuppressed()
		/// </summary>
		protected static RMethod r_IsFlowSuppressed;
		public static RMethod RIsFlowSuppressed
		{
			get
			{
				if(r_IsFlowSuppressed == null)
				{
					r_IsFlowSuppressed = new(typeof(System.Threading.ExecutionContext), "IsFlowSuppressed", 0);
					r_IsFlowSuppressed.SetBelong(null);
				}
				return r_IsFlowSuppressed;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext Capture()
		/// </summary>
		protected static RMethod r_Capture;
		public static RMethod RCapture
		{
			get
			{
				if(r_Capture == null)
				{
					r_Capture = new(typeof(System.Threading.ExecutionContext), "Capture", 0);
					r_Capture.SetBelong(null);
				}
				return r_Capture;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext FastCapture()
		/// </summary>
		protected static RMethod r_FastCapture;
		public static RMethod RFastCapture
		{
			get
			{
				if(r_FastCapture == null)
				{
					r_FastCapture = new(typeof(System.Threading.ExecutionContext), "FastCapture", 0);
					r_FastCapture.SetBelong(null);
				}
				return r_FastCapture;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext Capture(System.Threading.StackCrawlMark ByRef, CaptureOptions)
		/// </summary>
		protected static RMethod r_Capture_Ref_StackCrawlMark_CaptureOptions;
		public static RMethod RCapture_Ref_StackCrawlMark_CaptureOptions
		{
			get
			{
				if(r_Capture_Ref_StackCrawlMark_CaptureOptions == null)
				{
					r_Capture_Ref_StackCrawlMark_CaptureOptions = new(typeof(System.Threading.ExecutionContext), "Capture", 0,  ReflectionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType(),  ReflectionUtils.GetType("System.Threading.ExecutionContext+CaptureOptions"));
					r_Capture_Ref_StackCrawlMark_CaptureOptions.SetBelong(null);
				}
				return r_Capture_Ref_StackCrawlMark_CaptureOptions;
			}
		}

		/// <summary>
		/// Void GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_GetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RGetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_GetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_GetObjectData_SerializationInfo_StreamingContext = new(this, "GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_GetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_GetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// Boolean IsDefaultFTContext(Boolean)
		/// </summary>
		protected RMethod r_IsDefaultFTContext_Boolean;
		public virtual RMethod RIsDefaultFTContext_Boolean
		{
			get
			{
				if(r_IsDefaultFTContext_Boolean == null)
				{
					r_IsDefaultFTContext_Boolean = new(this, "IsDefaultFTContext", 0, typeof(System.Boolean));
					r_IsDefaultFTContext_Boolean.SetBelong(this.instance);
				}
				return r_IsDefaultFTContext_Boolean;
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


        public RExecutionContext() : base("System.Threading.ExecutionContext")
        {
        }

        public RExecutionContext(System.Object instance) : base("System.Threading.ExecutionContext")
		{
            SetInstance(instance);
		}

        public RExecutionContext(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RExecutionContext(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Object GetLocalValue(RSystem.RThreading.RIAsyncLocal @local)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@local.Value};
            var ___result = RGetLocalValue_IAsyncLocal.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static void SetLocalValue(RSystem.RThreading.RIAsyncLocal @local, System.Object @newValue, System.Boolean @needChangeNotifications)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@local.Value, @newValue, @needChangeNotifications};
            var ___result = RSetLocalValue_IAsyncLocal_Object_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static void OnAsyncLocalContextChanged(System.Threading.ExecutionContext @previous, System.Threading.ExecutionContext @current)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@previous, @current};
            var ___result = ROnAsyncLocalContextChanged_ExecutionContext_ExecutionContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public static void Run(System.Threading.ExecutionContext @executionContext, System.Threading.ContextCallback @callback, System.Object @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@executionContext, @callback, @state};
            var ___result = RRun_ExecutionContext_ContextCallback_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static void Run(System.Threading.ExecutionContext @executionContext, System.Threading.ContextCallback @callback, System.Object @state, System.Boolean @preserveSyncCtx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@executionContext, @callback, @state, @preserveSyncCtx};
            var ___result = RRun_ExecutionContext_ContextCallback_Object_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static void RunInternal(System.Threading.ExecutionContext @executionContext, System.Threading.ContextCallback @callback, System.Object @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@executionContext, @callback, @state};
            var ___result = RRunInternal_ExecutionContext_ContextCallback_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static void RunInternal(System.Threading.ExecutionContext @executionContext, System.Threading.ContextCallback @callback, System.Object @state, System.Boolean @preserveSyncCtx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@executionContext, @callback, @state, @preserveSyncCtx};
            var ___result = RRunInternal_ExecutionContext_ContextCallback_Object_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static void RunInternal<TState>(System.Threading.ExecutionContext @executionContext, RSystem.RThreading.RContextCallback<RType> @callback, ref TState @state)
        {

            var ___genericsType = new Type[] {typeof(TState)};
            var ___parameters = new object[]{@executionContext, @callback.Value, @state};
            var ___result = RRunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState.Invoke(___genericsType, ___parameters);
			@state = (TState)___parameters[2];

            
        }


        public static void RunInternal<TState>(System.Threading.ExecutionContext @executionContext, RSystem.RThreading.RContextCallback<RType> @callback, ref TState @state, System.Boolean @preserveSyncCtx)
        {

            var ___genericsType = new Type[] {typeof(TState)};
            var ___parameters = new object[]{@executionContext, @callback.Value, @state, @preserveSyncCtx};
            var ___result = RRunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState_Boolean.Invoke(___genericsType, ___parameters);
			@state = (TState)___parameters[2];

            
        }


        public static void EstablishCopyOnWriteScope(ref RSystem.RThreading.RExecutionContextSwitcher @ecsw)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ecsw.Value};
            var ___result = REstablishCopyOnWriteScope_Ref_ExecutionContextSwitcher.Invoke(___genericsType, ___parameters);
			@ecsw = new RSystem.RThreading.RExecutionContextSwitcher(___parameters[0]);

            
        }


        public static void EstablishCopyOnWriteScope(System.Threading.Thread @currentThread, System.Boolean @knownNullWindowsIdentity, ref RSystem.RThreading.RExecutionContextSwitcher @ecsw)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@currentThread, @knownNullWindowsIdentity, @ecsw.Value};
            var ___result = REstablishCopyOnWriteScope_Thread_Boolean_Ref_ExecutionContextSwitcher.Invoke(___genericsType, ___parameters);
			@ecsw = new RSystem.RThreading.RExecutionContextSwitcher(___parameters[2]);

            
        }


        public static RSystem.RThreading.RExecutionContextSwitcher SetExecutionContext(System.Threading.ExecutionContext @executionContext, System.Boolean @preserveSyncCtx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@executionContext, @preserveSyncCtx};
            var ___result = RSetExecutionContext_ExecutionContext_Boolean.Invoke(___genericsType, ___parameters);

            return new RSystem.RThreading.RExecutionContextSwitcher(___result);
        }


        public virtual System.Threading.ExecutionContext CreateCopy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateCopy.Invoke(___genericsType, ___parameters);

            return (System.Threading.ExecutionContext)___result;
        }


        public virtual System.Threading.ExecutionContext CreateMutableCopy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateMutableCopy.Invoke(___genericsType, ___parameters);

            return (System.Threading.ExecutionContext)___result;
        }


        public static System.Threading.AsyncFlowControl SuppressFlow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSuppressFlow.Invoke(___genericsType, ___parameters);

            return (System.Threading.AsyncFlowControl)___result;
        }


        public static void RestoreFlow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRestoreFlow.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsFlowSuppressed()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsFlowSuppressed.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Threading.ExecutionContext Capture()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCapture.Invoke(___genericsType, ___parameters);

            return (System.Threading.ExecutionContext)___result;
        }


        public static System.Threading.ExecutionContext FastCapture()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFastCapture.Invoke(___genericsType, ___parameters);

            return (System.Threading.ExecutionContext)___result;
        }


        public static System.Threading.ExecutionContext Capture(ref RType @stackMark, RType @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stackMark.Value, @options.Value};
            var ___result = RCapture_Ref_StackCrawlMark_CaptureOptions.Invoke(___genericsType, ___parameters);
			@stackMark = new RType(___parameters[0]);

            return (System.Threading.ExecutionContext)___result;
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsDefaultFTContext(System.Boolean @ignoreSyncCtx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ignoreSyncCtx};
            var ___result = RIsDefaultFTContext_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
