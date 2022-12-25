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
		protected RProperty r_isNewCapture;
		public virtual RProperty RisNewCapture
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
		protected RProperty r_isFlowSuppressed;
		public virtual RProperty RisFlowSuppressed
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
		protected RProperty r_IsPreAllocatedDefault;
		public virtual RProperty RIsPreAllocatedDefault
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
		protected static RMethod r_RGetLocalValue_IAsyncLocal;
		public static RMethod RGetLocalValue_IAsyncLocal
		{
			get
			{
				if(r_RGetLocalValue_IAsyncLocal == null)
				{
					r_RGetLocalValue_IAsyncLocal = new(typeof(System.Threading.ExecutionContext), "GetLocalValue", 0,  ReleactionUtils.GetType("System.Threading.IAsyncLocal"));
					r_RGetLocalValue_IAsyncLocal.SetBelong(null);
				}
				return r_RGetLocalValue_IAsyncLocal;
			}
		}

		/// <summary>
		/// Void SetLocalValue(System.Threading.IAsyncLocal, System.Object, Boolean)
		/// </summary>
		protected static RMethod r_RSetLocalValue_IAsyncLocal_Object_Boolean;
		public static RMethod RSetLocalValue_IAsyncLocal_Object_Boolean
		{
			get
			{
				if(r_RSetLocalValue_IAsyncLocal_Object_Boolean == null)
				{
					r_RSetLocalValue_IAsyncLocal_Object_Boolean = new(typeof(System.Threading.ExecutionContext), "SetLocalValue", 0,  ReleactionUtils.GetType("System.Threading.IAsyncLocal"), typeof(System.Object), typeof(System.Boolean));
					r_RSetLocalValue_IAsyncLocal_Object_Boolean.SetBelong(null);
				}
				return r_RSetLocalValue_IAsyncLocal_Object_Boolean;
			}
		}

		/// <summary>
		/// Void OnAsyncLocalContextChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
		/// </summary>
		protected static RMethod r_ROnAsyncLocalContextChanged_ExecutionContext_ExecutionContext;
		public static RMethod ROnAsyncLocalContextChanged_ExecutionContext_ExecutionContext
		{
			get
			{
				if(r_ROnAsyncLocalContextChanged_ExecutionContext_ExecutionContext == null)
				{
					r_ROnAsyncLocalContextChanged_ExecutionContext_ExecutionContext = new(typeof(System.Threading.ExecutionContext), "OnAsyncLocalContextChanged", 0, typeof(System.Threading.ExecutionContext), typeof(System.Threading.ExecutionContext));
					r_ROnAsyncLocalContextChanged_ExecutionContext_ExecutionContext.SetBelong(null);
				}
				return r_ROnAsyncLocalContextChanged_ExecutionContext_ExecutionContext;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_RDispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_RDispose == null)
				{
					r_RDispose = new(this, "Dispose", 0);
					r_RDispose.SetBelong(this.instance);
				}
				return r_RDispose;
			}
		}

		/// <summary>
		/// Void Run(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object)
		/// </summary>
		protected static RMethod r_RRun_ExecutionContext_ContextCallback_Object;
		public static RMethod RRun_ExecutionContext_ContextCallback_Object
		{
			get
			{
				if(r_RRun_ExecutionContext_ContextCallback_Object == null)
				{
					r_RRun_ExecutionContext_ContextCallback_Object = new(typeof(System.Threading.ExecutionContext), "Run", 0, typeof(System.Threading.ExecutionContext), typeof(System.Threading.ContextCallback), typeof(System.Object));
					r_RRun_ExecutionContext_ContextCallback_Object.SetBelong(null);
				}
				return r_RRun_ExecutionContext_ContextCallback_Object;
			}
		}

		/// <summary>
		/// Void Run(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)
		/// </summary>
		protected static RMethod r_RRun_ExecutionContext_ContextCallback_Object_Boolean;
		public static RMethod RRun_ExecutionContext_ContextCallback_Object_Boolean
		{
			get
			{
				if(r_RRun_ExecutionContext_ContextCallback_Object_Boolean == null)
				{
					r_RRun_ExecutionContext_ContextCallback_Object_Boolean = new(typeof(System.Threading.ExecutionContext), "Run", 0, typeof(System.Threading.ExecutionContext), typeof(System.Threading.ContextCallback), typeof(System.Object), typeof(System.Boolean));
					r_RRun_ExecutionContext_ContextCallback_Object_Boolean.SetBelong(null);
				}
				return r_RRun_ExecutionContext_ContextCallback_Object_Boolean;
			}
		}

		/// <summary>
		/// Void RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object)
		/// </summary>
		protected static RMethod r_RRunInternal_ExecutionContext_ContextCallback_Object;
		public static RMethod RRunInternal_ExecutionContext_ContextCallback_Object
		{
			get
			{
				if(r_RRunInternal_ExecutionContext_ContextCallback_Object == null)
				{
					r_RRunInternal_ExecutionContext_ContextCallback_Object = new(typeof(System.Threading.ExecutionContext), "RunInternal", 0, typeof(System.Threading.ExecutionContext), typeof(System.Threading.ContextCallback), typeof(System.Object));
					r_RRunInternal_ExecutionContext_ContextCallback_Object.SetBelong(null);
				}
				return r_RRunInternal_ExecutionContext_ContextCallback_Object;
			}
		}

		/// <summary>
		/// Void RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)
		/// </summary>
		protected static RMethod r_RRunInternal_ExecutionContext_ContextCallback_Object_Boolean;
		public static RMethod RRunInternal_ExecutionContext_ContextCallback_Object_Boolean
		{
			get
			{
				if(r_RRunInternal_ExecutionContext_ContextCallback_Object_Boolean == null)
				{
					r_RRunInternal_ExecutionContext_ContextCallback_Object_Boolean = new(typeof(System.Threading.ExecutionContext), "RunInternal", 0, typeof(System.Threading.ExecutionContext), typeof(System.Threading.ContextCallback), typeof(System.Object), typeof(System.Boolean));
					r_RRunInternal_ExecutionContext_ContextCallback_Object_Boolean.SetBelong(null);
				}
				return r_RRunInternal_ExecutionContext_ContextCallback_Object_Boolean;
			}
		}

		/// <summary>
		/// Void RunInternal[TState](System.Threading.ExecutionContext, System.Threading.ContextCallback`1[TState], TState ByRef)
		/// </summary>
		protected static RMethod r_RRunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState;
		public static RMethod RRunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState
		{
			get
			{
				if(r_RRunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState == null)
				{
					r_RRunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState = new(typeof(System.Threading.ExecutionContext), "RunInternal", 1, typeof(System.Threading.ExecutionContext),  ReleactionUtils.GetType("System.Threading.ContextCallback`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_RRunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState.SetBelong(null);
				}
				return r_RRunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState;
			}
		}

		/// <summary>
		/// Void RunInternal[TState](System.Threading.ExecutionContext, System.Threading.ContextCallback`1[TState], TState ByRef, Boolean)
		/// </summary>
		protected static RMethod r_RRunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState_Boolean;
		public static RMethod RRunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState_Boolean
		{
			get
			{
				if(r_RRunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState_Boolean == null)
				{
					r_RRunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState_Boolean = new(typeof(System.Threading.ExecutionContext), "RunInternal", 1, typeof(System.Threading.ExecutionContext),  ReleactionUtils.GetType("System.Threading.ContextCallback`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0).MakeByRefType(), typeof(System.Boolean));
					r_RRunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState_Boolean.SetBelong(null);
				}
				return r_RRunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState_Boolean;
			}
		}

		/// <summary>
		/// Void EstablishCopyOnWriteScope(System.Threading.ExecutionContextSwitcher ByRef)
		/// </summary>
		protected static RMethod r_REstablishCopyOnWriteScope_Ref_ExecutionContextSwitcher;
		public static RMethod REstablishCopyOnWriteScope_Ref_ExecutionContextSwitcher
		{
			get
			{
				if(r_REstablishCopyOnWriteScope_Ref_ExecutionContextSwitcher == null)
				{
					r_REstablishCopyOnWriteScope_Ref_ExecutionContextSwitcher = new(typeof(System.Threading.ExecutionContext), "EstablishCopyOnWriteScope", 0,  ReleactionUtils.GetType("System.Threading.ExecutionContextSwitcher").MakeByRefType());
					r_REstablishCopyOnWriteScope_Ref_ExecutionContextSwitcher.SetBelong(null);
				}
				return r_REstablishCopyOnWriteScope_Ref_ExecutionContextSwitcher;
			}
		}

		/// <summary>
		/// Void EstablishCopyOnWriteScope(System.Threading.Thread, Boolean, System.Threading.ExecutionContextSwitcher ByRef)
		/// </summary>
		protected static RMethod r_REstablishCopyOnWriteScope_Thread_Boolean_Ref_ExecutionContextSwitcher;
		public static RMethod REstablishCopyOnWriteScope_Thread_Boolean_Ref_ExecutionContextSwitcher
		{
			get
			{
				if(r_REstablishCopyOnWriteScope_Thread_Boolean_Ref_ExecutionContextSwitcher == null)
				{
					r_REstablishCopyOnWriteScope_Thread_Boolean_Ref_ExecutionContextSwitcher = new(typeof(System.Threading.ExecutionContext), "EstablishCopyOnWriteScope", 0, typeof(System.Threading.Thread), typeof(System.Boolean),  ReleactionUtils.GetType("System.Threading.ExecutionContextSwitcher").MakeByRefType());
					r_REstablishCopyOnWriteScope_Thread_Boolean_Ref_ExecutionContextSwitcher.SetBelong(null);
				}
				return r_REstablishCopyOnWriteScope_Thread_Boolean_Ref_ExecutionContextSwitcher;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContextSwitcher SetExecutionContext(System.Threading.ExecutionContext, Boolean)
		/// </summary>
		protected static RMethod r_RSetExecutionContext_ExecutionContext_Boolean;
		public static RMethod RSetExecutionContext_ExecutionContext_Boolean
		{
			get
			{
				if(r_RSetExecutionContext_ExecutionContext_Boolean == null)
				{
					r_RSetExecutionContext_ExecutionContext_Boolean = new(typeof(System.Threading.ExecutionContext), "SetExecutionContext", 0, typeof(System.Threading.ExecutionContext), typeof(System.Boolean));
					r_RSetExecutionContext_ExecutionContext_Boolean.SetBelong(null);
				}
				return r_RSetExecutionContext_ExecutionContext_Boolean;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext CreateCopy()
		/// </summary>
		protected RMethod r_RCreateCopy;
		public virtual RMethod RCreateCopy
		{
			get
			{
				if(r_RCreateCopy == null)
				{
					r_RCreateCopy = new(this, "CreateCopy", 0);
					r_RCreateCopy.SetBelong(this.instance);
				}
				return r_RCreateCopy;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext CreateMutableCopy()
		/// </summary>
		protected RMethod r_RCreateMutableCopy;
		public virtual RMethod RCreateMutableCopy
		{
			get
			{
				if(r_RCreateMutableCopy == null)
				{
					r_RCreateMutableCopy = new(this, "CreateMutableCopy", 0);
					r_RCreateMutableCopy.SetBelong(this.instance);
				}
				return r_RCreateMutableCopy;
			}
		}

		/// <summary>
		/// System.Threading.AsyncFlowControl SuppressFlow()
		/// </summary>
		protected static RMethod r_RSuppressFlow;
		public static RMethod RSuppressFlow
		{
			get
			{
				if(r_RSuppressFlow == null)
				{
					r_RSuppressFlow = new(typeof(System.Threading.ExecutionContext), "SuppressFlow", 0);
					r_RSuppressFlow.SetBelong(null);
				}
				return r_RSuppressFlow;
			}
		}

		/// <summary>
		/// Void RestoreFlow()
		/// </summary>
		protected static RMethod r_RRestoreFlow;
		public static RMethod RRestoreFlow
		{
			get
			{
				if(r_RRestoreFlow == null)
				{
					r_RRestoreFlow = new(typeof(System.Threading.ExecutionContext), "RestoreFlow", 0);
					r_RRestoreFlow.SetBelong(null);
				}
				return r_RRestoreFlow;
			}
		}

		/// <summary>
		/// Boolean IsFlowSuppressed()
		/// </summary>
		protected static RMethod r_RIsFlowSuppressed;
		public static RMethod RIsFlowSuppressed
		{
			get
			{
				if(r_RIsFlowSuppressed == null)
				{
					r_RIsFlowSuppressed = new(typeof(System.Threading.ExecutionContext), "IsFlowSuppressed", 0);
					r_RIsFlowSuppressed.SetBelong(null);
				}
				return r_RIsFlowSuppressed;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext Capture()
		/// </summary>
		protected static RMethod r_RCapture;
		public static RMethod RCapture
		{
			get
			{
				if(r_RCapture == null)
				{
					r_RCapture = new(typeof(System.Threading.ExecutionContext), "Capture", 0);
					r_RCapture.SetBelong(null);
				}
				return r_RCapture;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext FastCapture()
		/// </summary>
		protected static RMethod r_RFastCapture;
		public static RMethod RFastCapture
		{
			get
			{
				if(r_RFastCapture == null)
				{
					r_RFastCapture = new(typeof(System.Threading.ExecutionContext), "FastCapture", 0);
					r_RFastCapture.SetBelong(null);
				}
				return r_RFastCapture;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext Capture(System.Threading.StackCrawlMark ByRef, CaptureOptions)
		/// </summary>
		protected static RMethod r_RCapture_Ref_StackCrawlMark_CaptureOptions;
		public static RMethod RCapture_Ref_StackCrawlMark_CaptureOptions
		{
			get
			{
				if(r_RCapture_Ref_StackCrawlMark_CaptureOptions == null)
				{
					r_RCapture_Ref_StackCrawlMark_CaptureOptions = new(typeof(System.Threading.ExecutionContext), "Capture", 0,  ReleactionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType(),  ReleactionUtils.GetType("System.Threading.ExecutionContext+CaptureOptions"));
					r_RCapture_Ref_StackCrawlMark_CaptureOptions.SetBelong(null);
				}
				return r_RCapture_Ref_StackCrawlMark_CaptureOptions;
			}
		}

		/// <summary>
		/// Void GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_RGetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RGetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_RGetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_RGetObjectData_SerializationInfo_StreamingContext = new(this, "GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_RGetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_RGetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// Boolean IsDefaultFTContext(Boolean)
		/// </summary>
		protected RMethod r_RIsDefaultFTContext_Boolean;
		public virtual RMethod RIsDefaultFTContext_Boolean
		{
			get
			{
				if(r_RIsDefaultFTContext_Boolean == null)
				{
					r_RIsDefaultFTContext_Boolean = new(this, "IsDefaultFTContext", 0, typeof(System.Boolean));
					r_RIsDefaultFTContext_Boolean.SetBelong(this.instance);
				}
				return r_RIsDefaultFTContext_Boolean;
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



        public static void OnAsyncLocalContextChanged(System.Threading.ExecutionContext  @previous, System.Threading.ExecutionContext  @current)
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


        public static void Run(System.Threading.ExecutionContext  @executionContext, System.Threading.ContextCallback  @callback, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@executionContext, @callback, @state};
            var ___result = RRun_ExecutionContext_ContextCallback_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static void Run(System.Threading.ExecutionContext  @executionContext, System.Threading.ContextCallback  @callback, System.Object  @state, System.Boolean  @preserveSyncCtx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@executionContext, @callback, @state, @preserveSyncCtx};
            var ___result = RRun_ExecutionContext_ContextCallback_Object_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static void RunInternal(System.Threading.ExecutionContext  @executionContext, System.Threading.ContextCallback  @callback, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@executionContext, @callback, @state};
            var ___result = RRunInternal_ExecutionContext_ContextCallback_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static void RunInternal(System.Threading.ExecutionContext  @executionContext, System.Threading.ContextCallback  @callback, System.Object  @state, System.Boolean  @preserveSyncCtx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@executionContext, @callback, @state, @preserveSyncCtx};
            var ___result = RRunInternal_ExecutionContext_ContextCallback_Object_Boolean.Invoke(___genericsType, ___parameters);

            
        }






        public static System.Object SetExecutionContext(System.Threading.ExecutionContext  @executionContext, System.Boolean  @preserveSyncCtx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@executionContext, @preserveSyncCtx};
            var ___result = RSetExecutionContext_ExecutionContext_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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



        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo  @info, System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsDefaultFTContext(System.Boolean  @ignoreSyncCtx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ignoreSyncCtx};
            var ___result = RIsDefaultFTContext_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
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
