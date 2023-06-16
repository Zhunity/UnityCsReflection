
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Threading.ExecutionContext
	/// </summary>
    public partial class RExecutionContext : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Threading.ExecutionContext);
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


		/// <summary>
		/// System.Threading.SynchronizationContext _syncContext
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RSynchronizationContext r_F_syncContext;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RSynchronizationContext RF_syncContext
		{
			get
			{
				if(r_F_syncContext == null)
				{
					r_F_syncContext = new(this, "_syncContext");
				}
				return r_F_syncContext;
			}
		}

		/// <summary>
		/// System.Threading.SynchronizationContext _syncContextNoFlow
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RSynchronizationContext r_F_syncContextNoFlow;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RSynchronizationContext RF_syncContextNoFlow
		{
			get
			{
				if(r_F_syncContextNoFlow == null)
				{
					r_F_syncContextNoFlow = new(this, "_syncContextNoFlow");
				}
				return r_F_syncContextNoFlow;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.LogicalCallContext _logicalCallContext
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RLogicalCallContext r_F_logicalCallContext;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RLogicalCallContext RF_logicalCallContext
		{
			get
			{
				if(r_F_logicalCallContext == null)
				{
					r_F_logicalCallContext = new(this, "_logicalCallContext");
				}
				return r_F_logicalCallContext;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IllogicalCallContext _illogicalCallContext
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RIllogicalCallContext r_F_illogicalCallContext;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RIllogicalCallContext RF_illogicalCallContext
		{
			get
			{
				if(r_F_illogicalCallContext == null)
				{
					r_F_illogicalCallContext = new(this, "_illogicalCallContext");
				}
				return r_F_illogicalCallContext;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext+Flags _flags
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RExecutionContext.RFlags r_F_flags;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RExecutionContext.RFlags RF_flags
		{
			get
			{
				if(r_F_flags == null)
				{
					r_F_flags = new(this, "_flags");
				}
				return r_F_flags;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Threading.IAsyncLocal,System.Object] _localValues
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RThreading.RIAsyncLocal, Hvak.Editor.Refleaction.RSystem.RObject> r_F_localValues;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RThreading.RIAsyncLocal, Hvak.Editor.Refleaction.RSystem.RObject> RF_localValues
		{
			get
			{
				if(r_F_localValues == null)
				{
					r_F_localValues = new(this, "_localValues");
				}
				return r_F_localValues;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Threading.IAsyncLocal] _localChangeNotifications
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RThreading.RIAsyncLocal> r_F_localChangeNotifications;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RThreading.RIAsyncLocal> RF_localChangeNotifications
		{
			get
			{
				if(r_F_localChangeNotifications == null)
				{
					r_F_localChangeNotifications = new(this, "_localChangeNotifications");
				}
				return r_F_localChangeNotifications;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext s_dummyDefaultEC
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RExecutionContext r_Fs_dummyDefaultEC;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RExecutionContext RFs_dummyDefaultEC
		{
			get
			{
				if(r_Fs_dummyDefaultEC == null)
				{
					r_Fs_dummyDefaultEC = new(Type, "s_dummyDefaultEC");
				}
				return r_Fs_dummyDefaultEC;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext Default
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RExecutionContext r_FDefault;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RExecutionContext RFDefault
		{
			get
			{
				if(r_FDefault == null)
				{
					r_FDefault = new(Type, "Default");
				}
				return r_FDefault;
			}
		}

		/// <summary>
		/// Boolean isNewCapture
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisNewCapture;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisNewCapture
		{
			get
			{
				if(r_PisNewCapture == null)
				{
					r_PisNewCapture = new(this, "isNewCapture", -1);
				}
				return r_PisNewCapture;
			}
		}

		/// <summary>
		/// Boolean isFlowSuppressed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisFlowSuppressed;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisFlowSuppressed
		{
			get
			{
				if(r_PisFlowSuppressed == null)
				{
					r_PisFlowSuppressed = new(this, "isFlowSuppressed", -1);
				}
				return r_PisFlowSuppressed;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext PreAllocatedDefault
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RExecutionContext r_PPreAllocatedDefault;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RExecutionContext RPPreAllocatedDefault
		{
			get
			{
				if(r_PPreAllocatedDefault == null)
				{
					r_PPreAllocatedDefault = new(Type, "PreAllocatedDefault", -1);
				}
				return r_PPreAllocatedDefault;
			}
		}

		/// <summary>
		/// Boolean IsPreAllocatedDefault
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsPreAllocatedDefault;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsPreAllocatedDefault
		{
			get
			{
				if(r_PIsPreAllocatedDefault == null)
				{
					r_PIsPreAllocatedDefault = new(this, "IsPreAllocatedDefault", -1);
				}
				return r_PIsPreAllocatedDefault;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.LogicalCallContext LogicalCallContext
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RLogicalCallContext r_PLogicalCallContext;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RLogicalCallContext RPLogicalCallContext
		{
			get
			{
				if(r_PLogicalCallContext == null)
				{
					r_PLogicalCallContext = new(this, "LogicalCallContext", -1);
				}
				return r_PLogicalCallContext;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IllogicalCallContext IllogicalCallContext
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RIllogicalCallContext r_PIllogicalCallContext;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RIllogicalCallContext RPIllogicalCallContext
		{
			get
			{
				if(r_PIllogicalCallContext == null)
				{
					r_PIllogicalCallContext = new(this, "IllogicalCallContext", -1);
				}
				return r_PIllogicalCallContext;
			}
		}

		/// <summary>
		/// System.Threading.SynchronizationContext SynchronizationContext
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RSynchronizationContext r_PSynchronizationContext;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RSynchronizationContext RPSynchronizationContext
		{
			get
			{
				if(r_PSynchronizationContext == null)
				{
					r_PSynchronizationContext = new(this, "SynchronizationContext", -1);
				}
				return r_PSynchronizationContext;
			}
		}

		/// <summary>
		/// System.Threading.SynchronizationContext SynchronizationContextNoFlow
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RSynchronizationContext r_PSynchronizationContextNoFlow;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RSynchronizationContext RPSynchronizationContextNoFlow
		{
			get
			{
				if(r_PSynchronizationContextNoFlow == null)
				{
					r_PSynchronizationContextNoFlow = new(this, "SynchronizationContextNoFlow", -1);
				}
				return r_PSynchronizationContextNoFlow;
			}
		}

		/// <summary>
		/// System.Object GetLocalValue(System.Threading.IAsyncLocal)
		/// </summary>
		protected static RMethod r_MGetLocalValue_IAsyncLocal;
		public static RMethod RMGetLocalValue_IAsyncLocal
		{
			get
			{
				if(r_MGetLocalValue_IAsyncLocal == null)
				{
					r_MGetLocalValue_IAsyncLocal = new(Type, "GetLocalValue", 0,  ReflectionUtils.GetType("System.Threading.IAsyncLocal"));
				}
				return r_MGetLocalValue_IAsyncLocal;
			}
		}

		/// <summary>
		/// Void SetLocalValue(System.Threading.IAsyncLocal, System.Object, Boolean)
		/// </summary>
		protected static RMethod r_MSetLocalValue_IAsyncLocal_Object_Boolean;
		public static RMethod RMSetLocalValue_IAsyncLocal_Object_Boolean
		{
			get
			{
				if(r_MSetLocalValue_IAsyncLocal_Object_Boolean == null)
				{
					r_MSetLocalValue_IAsyncLocal_Object_Boolean = new(Type, "SetLocalValue", 0,  ReflectionUtils.GetType("System.Threading.IAsyncLocal"), typeof(System.Object), typeof(System.Boolean));
				}
				return r_MSetLocalValue_IAsyncLocal_Object_Boolean;
			}
		}

		/// <summary>
		/// Void OnAsyncLocalContextChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
		/// </summary>
		protected static RMethod r_MOnAsyncLocalContextChanged_ExecutionContext_ExecutionContext;
		public static RMethod RMOnAsyncLocalContextChanged_ExecutionContext_ExecutionContext
		{
			get
			{
				if(r_MOnAsyncLocalContextChanged_ExecutionContext_ExecutionContext == null)
				{
					r_MOnAsyncLocalContextChanged_ExecutionContext_ExecutionContext = new(Type, "OnAsyncLocalContextChanged", 0, typeof(System.Threading.ExecutionContext), typeof(System.Threading.ExecutionContext));
				}
				return r_MOnAsyncLocalContextChanged_ExecutionContext_ExecutionContext;
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
		/// Void Run(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object)
		/// </summary>
		protected static RMethod r_MRun_ExecutionContext_ContextCallback_Object;
		public static RMethod RMRun_ExecutionContext_ContextCallback_Object
		{
			get
			{
				if(r_MRun_ExecutionContext_ContextCallback_Object == null)
				{
					r_MRun_ExecutionContext_ContextCallback_Object = new(Type, "Run", 0, typeof(System.Threading.ExecutionContext), typeof(System.Threading.ContextCallback), typeof(System.Object));
				}
				return r_MRun_ExecutionContext_ContextCallback_Object;
			}
		}

		/// <summary>
		/// Void Run(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)
		/// </summary>
		protected static RMethod r_MRun_ExecutionContext_ContextCallback_Object_Boolean;
		public static RMethod RMRun_ExecutionContext_ContextCallback_Object_Boolean
		{
			get
			{
				if(r_MRun_ExecutionContext_ContextCallback_Object_Boolean == null)
				{
					r_MRun_ExecutionContext_ContextCallback_Object_Boolean = new(Type, "Run", 0, typeof(System.Threading.ExecutionContext), typeof(System.Threading.ContextCallback), typeof(System.Object), typeof(System.Boolean));
				}
				return r_MRun_ExecutionContext_ContextCallback_Object_Boolean;
			}
		}

		/// <summary>
		/// Void RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object)
		/// </summary>
		protected static RMethod r_MRunInternal_ExecutionContext_ContextCallback_Object;
		public static RMethod RMRunInternal_ExecutionContext_ContextCallback_Object
		{
			get
			{
				if(r_MRunInternal_ExecutionContext_ContextCallback_Object == null)
				{
					r_MRunInternal_ExecutionContext_ContextCallback_Object = new(Type, "RunInternal", 0, typeof(System.Threading.ExecutionContext), typeof(System.Threading.ContextCallback), typeof(System.Object));
				}
				return r_MRunInternal_ExecutionContext_ContextCallback_Object;
			}
		}

		/// <summary>
		/// Void RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)
		/// </summary>
		protected static RMethod r_MRunInternal_ExecutionContext_ContextCallback_Object_Boolean;
		public static RMethod RMRunInternal_ExecutionContext_ContextCallback_Object_Boolean
		{
			get
			{
				if(r_MRunInternal_ExecutionContext_ContextCallback_Object_Boolean == null)
				{
					r_MRunInternal_ExecutionContext_ContextCallback_Object_Boolean = new(Type, "RunInternal", 0, typeof(System.Threading.ExecutionContext), typeof(System.Threading.ContextCallback), typeof(System.Object), typeof(System.Boolean));
				}
				return r_MRunInternal_ExecutionContext_ContextCallback_Object_Boolean;
			}
		}

		/// <summary>
		/// Void RunInternal[TState](System.Threading.ExecutionContext, System.Threading.ContextCallback`1[TState], TState ByRef)
		/// </summary>
		protected static RMethod r_MRunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState;
		public static RMethod RMRunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState
		{
			get
			{
				if(r_MRunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState == null)
				{
					r_MRunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState = new(Type, "RunInternal", 1, typeof(System.Threading.ExecutionContext),  ReflectionUtils.GetType("System.Threading.ContextCallback`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0).MakeByRefType());
				}
				return r_MRunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState;
			}
		}

		/// <summary>
		/// Void RunInternal[TState](System.Threading.ExecutionContext, System.Threading.ContextCallback`1[TState], TState ByRef, Boolean)
		/// </summary>
		protected static RMethod r_MRunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState_Boolean;
		public static RMethod RMRunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState_Boolean
		{
			get
			{
				if(r_MRunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState_Boolean == null)
				{
					r_MRunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState_Boolean = new(Type, "RunInternal", 1, typeof(System.Threading.ExecutionContext),  ReflectionUtils.GetType("System.Threading.ContextCallback`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0).MakeByRefType(), typeof(System.Boolean));
				}
				return r_MRunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState_Boolean;
			}
		}

		/// <summary>
		/// Void EstablishCopyOnWriteScope(System.Threading.ExecutionContextSwitcher ByRef)
		/// </summary>
		protected static RMethod r_MEstablishCopyOnWriteScope_Ref_ExecutionContextSwitcher;
		public static RMethod RMEstablishCopyOnWriteScope_Ref_ExecutionContextSwitcher
		{
			get
			{
				if(r_MEstablishCopyOnWriteScope_Ref_ExecutionContextSwitcher == null)
				{
					r_MEstablishCopyOnWriteScope_Ref_ExecutionContextSwitcher = new(Type, "EstablishCopyOnWriteScope", 0,  ReflectionUtils.GetType("System.Threading.ExecutionContextSwitcher").MakeByRefType());
				}
				return r_MEstablishCopyOnWriteScope_Ref_ExecutionContextSwitcher;
			}
		}

		/// <summary>
		/// Void EstablishCopyOnWriteScope(System.Threading.Thread, Boolean, System.Threading.ExecutionContextSwitcher ByRef)
		/// </summary>
		protected static RMethod r_MEstablishCopyOnWriteScope_Thread_Boolean_Ref_ExecutionContextSwitcher;
		public static RMethod RMEstablishCopyOnWriteScope_Thread_Boolean_Ref_ExecutionContextSwitcher
		{
			get
			{
				if(r_MEstablishCopyOnWriteScope_Thread_Boolean_Ref_ExecutionContextSwitcher == null)
				{
					r_MEstablishCopyOnWriteScope_Thread_Boolean_Ref_ExecutionContextSwitcher = new(Type, "EstablishCopyOnWriteScope", 0, typeof(System.Threading.Thread), typeof(System.Boolean),  ReflectionUtils.GetType("System.Threading.ExecutionContextSwitcher").MakeByRefType());
				}
				return r_MEstablishCopyOnWriteScope_Thread_Boolean_Ref_ExecutionContextSwitcher;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContextSwitcher SetExecutionContext(System.Threading.ExecutionContext, Boolean)
		/// </summary>
		protected static RMethod r_MSetExecutionContext_ExecutionContext_Boolean;
		public static RMethod RMSetExecutionContext_ExecutionContext_Boolean
		{
			get
			{
				if(r_MSetExecutionContext_ExecutionContext_Boolean == null)
				{
					r_MSetExecutionContext_ExecutionContext_Boolean = new(Type, "SetExecutionContext", 0, typeof(System.Threading.ExecutionContext), typeof(System.Boolean));
				}
				return r_MSetExecutionContext_ExecutionContext_Boolean;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext CreateCopy()
		/// </summary>
		protected RMethod r_MCreateCopy;
		public virtual RMethod RMCreateCopy
		{
			get
			{
				if(r_MCreateCopy == null)
				{
					r_MCreateCopy = new(this, "CreateCopy", 0);
				}
				return r_MCreateCopy;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext CreateMutableCopy()
		/// </summary>
		protected RMethod r_MCreateMutableCopy;
		public virtual RMethod RMCreateMutableCopy
		{
			get
			{
				if(r_MCreateMutableCopy == null)
				{
					r_MCreateMutableCopy = new(this, "CreateMutableCopy", 0);
				}
				return r_MCreateMutableCopy;
			}
		}

		/// <summary>
		/// System.Threading.AsyncFlowControl SuppressFlow()
		/// </summary>
		protected static RMethod r_MSuppressFlow;
		public static RMethod RMSuppressFlow
		{
			get
			{
				if(r_MSuppressFlow == null)
				{
					r_MSuppressFlow = new(Type, "SuppressFlow", 0);
				}
				return r_MSuppressFlow;
			}
		}

		/// <summary>
		/// Void RestoreFlow()
		/// </summary>
		protected static RMethod r_MRestoreFlow;
		public static RMethod RMRestoreFlow
		{
			get
			{
				if(r_MRestoreFlow == null)
				{
					r_MRestoreFlow = new(Type, "RestoreFlow", 0);
				}
				return r_MRestoreFlow;
			}
		}

		/// <summary>
		/// Boolean IsFlowSuppressed()
		/// </summary>
		protected static RMethod r_MIsFlowSuppressed;
		public static RMethod RMIsFlowSuppressed
		{
			get
			{
				if(r_MIsFlowSuppressed == null)
				{
					r_MIsFlowSuppressed = new(Type, "IsFlowSuppressed", 0);
				}
				return r_MIsFlowSuppressed;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext Capture()
		/// </summary>
		protected static RMethod r_MCapture;
		public static RMethod RMCapture
		{
			get
			{
				if(r_MCapture == null)
				{
					r_MCapture = new(Type, "Capture", 0);
				}
				return r_MCapture;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext FastCapture()
		/// </summary>
		protected static RMethod r_MFastCapture;
		public static RMethod RMFastCapture
		{
			get
			{
				if(r_MFastCapture == null)
				{
					r_MFastCapture = new(Type, "FastCapture", 0);
				}
				return r_MFastCapture;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext Capture(System.Threading.StackCrawlMark ByRef, CaptureOptions)
		/// </summary>
		protected static RMethod r_MCapture_Ref_StackCrawlMark_CaptureOptions;
		public static RMethod RMCapture_Ref_StackCrawlMark_CaptureOptions
		{
			get
			{
				if(r_MCapture_Ref_StackCrawlMark_CaptureOptions == null)
				{
					r_MCapture_Ref_StackCrawlMark_CaptureOptions = new(Type, "Capture", 0,  ReflectionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType(),  ReflectionUtils.GetType("System.Threading.ExecutionContext+CaptureOptions"));
				}
				return r_MCapture_Ref_StackCrawlMark_CaptureOptions;
			}
		}

		/// <summary>
		/// Void GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MGetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RMGetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_MGetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_MGetObjectData_SerializationInfo_StreamingContext = new(this, "GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
				}
				return r_MGetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// Boolean IsDefaultFTContext(Boolean)
		/// </summary>
		protected RMethod r_MIsDefaultFTContext_Boolean;
		public virtual RMethod RMIsDefaultFTContext_Boolean
		{
			get
			{
				if(r_MIsDefaultFTContext_Boolean == null)
				{
					r_MIsDefaultFTContext_Boolean = new(this, "IsDefaultFTContext", 0, typeof(System.Boolean));
				}
				return r_MIsDefaultFTContext_Boolean;
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


        public static System.Object GetLocalValue(Hvak.Editor.Refleaction.RSystem.RThreading.RIAsyncLocal @local)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@local.Value};
            var ___result = RMGetLocalValue_IAsyncLocal.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public static void SetLocalValue(Hvak.Editor.Refleaction.RSystem.RThreading.RIAsyncLocal @local, System.Object @newValue, System.Boolean @needChangeNotifications)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@local.Value, @newValue, @needChangeNotifications};
            var ___result = RMSetLocalValue_IAsyncLocal_Object_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static void OnAsyncLocalContextChanged(System.Threading.ExecutionContext @previous, System.Threading.ExecutionContext @current)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@previous, @current};
            var ___result = RMOnAsyncLocalContextChanged_ExecutionContext_ExecutionContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public static void Run(System.Threading.ExecutionContext @executionContext, System.Threading.ContextCallback @callback, System.Object @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@executionContext, @callback, @state};
            var ___result = RMRun_ExecutionContext_ContextCallback_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static void Run(System.Threading.ExecutionContext @executionContext, System.Threading.ContextCallback @callback, System.Object @state, System.Boolean @preserveSyncCtx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@executionContext, @callback, @state, @preserveSyncCtx};
            var ___result = RMRun_ExecutionContext_ContextCallback_Object_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static void RunInternal(System.Threading.ExecutionContext @executionContext, System.Threading.ContextCallback @callback, System.Object @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@executionContext, @callback, @state};
            var ___result = RMRunInternal_ExecutionContext_ContextCallback_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static void RunInternal(System.Threading.ExecutionContext @executionContext, System.Threading.ContextCallback @callback, System.Object @state, System.Boolean @preserveSyncCtx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@executionContext, @callback, @state, @preserveSyncCtx};
            var ___result = RMRunInternal_ExecutionContext_ContextCallback_Object_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static void RunInternal<TState>(System.Threading.ExecutionContext @executionContext, Hvak.Editor.Refleaction.RSystem.RThreading.RContextCallback<Hvak.Editor.Refleaction.RType> @callback, ref TState @state)
        {

            var ___genericsType = new Type[] {typeof(TState)};
            var ___parameters = new object[]{@executionContext, @callback.Value, @state};
            var ___result = RMRunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState.Invoke(___genericsType, ___parameters);
			@state = ReflectionUtils.Convert<TState>(___parameters[2]);

            
        }


        public static void RunInternal<TState>(System.Threading.ExecutionContext @executionContext, Hvak.Editor.Refleaction.RSystem.RThreading.RContextCallback<Hvak.Editor.Refleaction.RType> @callback, ref TState @state, System.Boolean @preserveSyncCtx)
        {

            var ___genericsType = new Type[] {typeof(TState)};
            var ___parameters = new object[]{@executionContext, @callback.Value, @state, @preserveSyncCtx};
            var ___result = RMRunInternal_GTState_ExecutionContext_ContextCallback_d_TState_p__Ref_TState_Boolean.Invoke(___genericsType, ___parameters);
			@state = ReflectionUtils.Convert<TState>(___parameters[2]);

            
        }


        public static void EstablishCopyOnWriteScope(ref Hvak.Editor.Refleaction.RSystem.RThreading.RExecutionContextSwitcher @ecsw)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ecsw.Value};
            var ___result = RMEstablishCopyOnWriteScope_Ref_ExecutionContextSwitcher.Invoke(___genericsType, ___parameters);
			@ecsw = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RThreading.RExecutionContextSwitcher>(___parameters[0]);

            
        }


        public static void EstablishCopyOnWriteScope(System.Threading.Thread @currentThread, System.Boolean @knownNullWindowsIdentity, ref Hvak.Editor.Refleaction.RSystem.RThreading.RExecutionContextSwitcher @ecsw)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@currentThread, @knownNullWindowsIdentity, @ecsw.Value};
            var ___result = RMEstablishCopyOnWriteScope_Thread_Boolean_Ref_ExecutionContextSwitcher.Invoke(___genericsType, ___parameters);
			@ecsw = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RThreading.RExecutionContextSwitcher>(___parameters[2]);

            
        }


        public static Hvak.Editor.Refleaction.RSystem.RThreading.RExecutionContextSwitcher SetExecutionContext(System.Threading.ExecutionContext @executionContext, System.Boolean @preserveSyncCtx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@executionContext, @preserveSyncCtx};
            var ___result = RMSetExecutionContext_ExecutionContext_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RThreading.RExecutionContextSwitcher>(___result);
        }


        public virtual System.Threading.ExecutionContext CreateCopy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateCopy.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.ExecutionContext>(___result);
        }


        public virtual System.Threading.ExecutionContext CreateMutableCopy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateMutableCopy.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.ExecutionContext>(___result);
        }


        public static System.Threading.AsyncFlowControl SuppressFlow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSuppressFlow.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.AsyncFlowControl>(___result);
        }


        public static void RestoreFlow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRestoreFlow.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsFlowSuppressed()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsFlowSuppressed.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Threading.ExecutionContext Capture()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCapture.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.ExecutionContext>(___result);
        }


        public static System.Threading.ExecutionContext FastCapture()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFastCapture.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.ExecutionContext>(___result);
        }


        public static System.Threading.ExecutionContext Capture(ref Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark @stackMark, Hvak.Editor.Refleaction.RSystem.RThreading.RExecutionContext.RCaptureOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stackMark.Value, @options.Value};
            var ___result = RMCapture_Ref_StackCrawlMark_CaptureOptions.Invoke(___genericsType, ___parameters);
			@stackMark = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark>(___parameters[0]);

            return ReflectionUtils.Convert<System.Threading.ExecutionContext>(___result);
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsDefaultFTContext(System.Boolean @ignoreSyncCtx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ignoreSyncCtx};
            var ___result = RMIsDefaultFTContext_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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
