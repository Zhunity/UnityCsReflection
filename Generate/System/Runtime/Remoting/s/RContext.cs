using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RContexts
{
	/// <summary>
	/// System.Runtime.Remoting.Contexts.Context
	/// </summary>
    public partial class RContext : RMember //
    {

		/// <summary>
		/// System.Int32 domain_id
		/// </summary>
		protected RField r_domain_id;
		public virtual RField Rdomain_id
		{
			get
			{
				if(r_domain_id == null)
				{
					r_domain_id = new(this, "domain_id");
					r_domain_id.SetBelong(this.instance);
				}
				return r_domain_id;
			}
		}

		/// <summary>
		/// System.Int32 context_id
		/// </summary>
		protected RField r_context_id;
		public virtual RField Rcontext_id
		{
			get
			{
				if(r_context_id == null)
				{
					r_context_id = new(this, "context_id");
					r_context_id.SetBelong(this.instance);
				}
				return r_context_id;
			}
		}

		/// <summary>
		/// System.UIntPtr static_data
		/// </summary>
		protected RField r_static_data;
		public virtual RField Rstatic_data
		{
			get
			{
				if(r_static_data == null)
				{
					r_static_data = new(this, "static_data");
					r_static_data.SetBelong(this.instance);
				}
				return r_static_data;
			}
		}

		/// <summary>
		/// System.UIntPtr data
		/// </summary>
		protected RField r_data;
		public virtual RField Rdata
		{
			get
			{
				if(r_data == null)
				{
					r_data = new(this, "data");
					r_data.SetBelong(this.instance);
				}
				return r_data;
			}
		}

		/// <summary>
		/// System.Object[] local_slots
		/// </summary>
		protected static RFieldArray<RSystem.RObject> r_local_slots;
		public static RFieldArray<RSystem.RObject> Rlocal_slots
		{
			get
			{
				if(r_local_slots == null)
				{
					r_local_slots = new(typeof(System.Runtime.Remoting.Contexts.Context), "local_slots");
					r_local_slots.SetBelong(null);
				}
				return r_local_slots;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessageSink default_server_context_sink
		/// </summary>
		protected static RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink r_default_server_context_sink;
		public static RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink Rdefault_server_context_sink
		{
			get
			{
				if(r_default_server_context_sink == null)
				{
					r_default_server_context_sink = new(typeof(System.Runtime.Remoting.Contexts.Context), "default_server_context_sink");
					r_default_server_context_sink.SetBelong(null);
				}
				return r_default_server_context_sink;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessageSink server_context_sink_chain
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink r_server_context_sink_chain;
		public virtual RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink Rserver_context_sink_chain
		{
			get
			{
				if(r_server_context_sink_chain == null)
				{
					r_server_context_sink_chain = new(this, "server_context_sink_chain");
					r_server_context_sink_chain.SetBelong(this.instance);
				}
				return r_server_context_sink_chain;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessageSink client_context_sink_chain
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink r_client_context_sink_chain;
		public virtual RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink Rclient_context_sink_chain
		{
			get
			{
				if(r_client_context_sink_chain == null)
				{
					r_client_context_sink_chain = new(this, "client_context_sink_chain");
					r_client_context_sink_chain.SetBelong(this.instance);
				}
				return r_client_context_sink_chain;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Runtime.Remoting.Contexts.IContextProperty] context_properties
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSystem.RRuntime.RRemoting.RContexts.RIContextProperty> r_context_properties;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RRuntime.RRemoting.RContexts.RIContextProperty> Rcontext_properties
		{
			get
			{
				if(r_context_properties == null)
				{
					r_context_properties = new(this, "context_properties");
					r_context_properties.SetBelong(this.instance);
				}
				return r_context_properties;
			}
		}

		/// <summary>
		/// System.Int32 global_count
		/// </summary>
		protected static RField r_global_count;
		public static RField Rglobal_count
		{
			get
			{
				if(r_global_count == null)
				{
					r_global_count = new(typeof(System.Runtime.Remoting.Contexts.Context), "global_count");
					r_global_count.SetBelong(null);
				}
				return r_global_count;
			}
		}

		/// <summary>
		/// System.LocalDataStoreHolder _localDataStore
		/// </summary>
		protected RSystem.RLocalDataStoreHolder r__localDataStore;
		public virtual RSystem.RLocalDataStoreHolder R_localDataStore
		{
			get
			{
				if(r__localDataStore == null)
				{
					r__localDataStore = new(this, "_localDataStore");
					r__localDataStore.SetBelong(this.instance);
				}
				return r__localDataStore;
			}
		}

		/// <summary>
		/// System.LocalDataStoreMgr _localDataStoreMgr
		/// </summary>
		protected static RSystem.RLocalDataStoreMgr r__localDataStoreMgr;
		public static RSystem.RLocalDataStoreMgr R_localDataStoreMgr
		{
			get
			{
				if(r__localDataStoreMgr == null)
				{
					r__localDataStoreMgr = new(typeof(System.Runtime.Remoting.Contexts.Context), "_localDataStoreMgr");
					r__localDataStoreMgr.SetBelong(null);
				}
				return r__localDataStoreMgr;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.DynamicPropertyCollection global_dynamic_properties
		/// </summary>
		protected static RSystem.RRuntime.RRemoting.RContexts.RDynamicPropertyCollection r_global_dynamic_properties;
		public static RSystem.RRuntime.RRemoting.RContexts.RDynamicPropertyCollection Rglobal_dynamic_properties
		{
			get
			{
				if(r_global_dynamic_properties == null)
				{
					r_global_dynamic_properties = new(typeof(System.Runtime.Remoting.Contexts.Context), "global_dynamic_properties");
					r_global_dynamic_properties.SetBelong(null);
				}
				return r_global_dynamic_properties;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.DynamicPropertyCollection context_dynamic_properties
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RContexts.RDynamicPropertyCollection r_context_dynamic_properties;
		public virtual RSystem.RRuntime.RRemoting.RContexts.RDynamicPropertyCollection Rcontext_dynamic_properties
		{
			get
			{
				if(r_context_dynamic_properties == null)
				{
					r_context_dynamic_properties = new(this, "context_dynamic_properties");
					r_context_dynamic_properties.SetBelong(this.instance);
				}
				return r_context_dynamic_properties;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.ContextCallbackObject callback_object
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RContexts.RContextCallbackObject r_callback_object;
		public virtual RSystem.RRuntime.RRemoting.RContexts.RContextCallbackObject Rcallback_object
		{
			get
			{
				if(r_callback_object == null)
				{
					r_callback_object = new(this, "callback_object");
					r_callback_object.SetBelong(this.instance);
				}
				return r_callback_object;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.Context DefaultContext
		/// </summary>
		protected static RSystem.RRuntime.RRemoting.RContexts.RContext r_DefaultContext;
		public static RSystem.RRuntime.RRemoting.RContexts.RContext RDefaultContext
		{
			get
			{
				if(r_DefaultContext == null)
				{
					r_DefaultContext = new(typeof(System.Runtime.Remoting.Contexts.Context), "DefaultContext", -1);
					r_DefaultContext.SetBelong(null);
				}
				return r_DefaultContext;
			}
		}

		/// <summary>
		/// Int32 ContextID
		/// </summary>
		protected RProperty r_ContextID;
		public virtual RProperty RContextID
		{
			get
			{
				if(r_ContextID == null)
				{
					r_ContextID = new(this, "ContextID", -1);
					r_ContextID.SetBelong(this.instance);
				}
				return r_ContextID;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.IContextProperty[] ContextProperties
		/// </summary>
		protected RPropertyArray<RSystem.RRuntime.RRemoting.RContexts.RIContextProperty> r_ContextProperties;
		public virtual RPropertyArray<RSystem.RRuntime.RRemoting.RContexts.RIContextProperty> RContextProperties
		{
			get
			{
				if(r_ContextProperties == null)
				{
					r_ContextProperties = new(this, "ContextProperties", -1);
					r_ContextProperties.SetBelong(this.instance);
				}
				return r_ContextProperties;
			}
		}

		/// <summary>
		/// Boolean IsDefaultContext
		/// </summary>
		protected RProperty r_IsDefaultContext;
		public virtual RProperty RIsDefaultContext
		{
			get
			{
				if(r_IsDefaultContext == null)
				{
					r_IsDefaultContext = new(this, "IsDefaultContext", -1);
					r_IsDefaultContext.SetBelong(this.instance);
				}
				return r_IsDefaultContext;
			}
		}

		/// <summary>
		/// Boolean NeedsContextSink
		/// </summary>
		protected RProperty r_NeedsContextSink;
		public virtual RProperty RNeedsContextSink
		{
			get
			{
				if(r_NeedsContextSink == null)
				{
					r_NeedsContextSink = new(this, "NeedsContextSink", -1);
					r_NeedsContextSink.SetBelong(this.instance);
				}
				return r_NeedsContextSink;
			}
		}

		/// <summary>
		/// Boolean HasGlobalDynamicSinks
		/// </summary>
		protected static RProperty r_HasGlobalDynamicSinks;
		public static RProperty RHasGlobalDynamicSinks
		{
			get
			{
				if(r_HasGlobalDynamicSinks == null)
				{
					r_HasGlobalDynamicSinks = new(typeof(System.Runtime.Remoting.Contexts.Context), "HasGlobalDynamicSinks", -1);
					r_HasGlobalDynamicSinks.SetBelong(null);
				}
				return r_HasGlobalDynamicSinks;
			}
		}

		/// <summary>
		/// Boolean HasDynamicSinks
		/// </summary>
		protected RProperty r_HasDynamicSinks;
		public virtual RProperty RHasDynamicSinks
		{
			get
			{
				if(r_HasDynamicSinks == null)
				{
					r_HasDynamicSinks = new(this, "HasDynamicSinks", -1);
					r_HasDynamicSinks.SetBelong(this.instance);
				}
				return r_HasDynamicSinks;
			}
		}

		/// <summary>
		/// Boolean HasExitSinks
		/// </summary>
		protected RProperty r_HasExitSinks;
		public virtual RProperty RHasExitSinks
		{
			get
			{
				if(r_HasExitSinks == null)
				{
					r_HasExitSinks = new(this, "HasExitSinks", -1);
					r_HasExitSinks.SetBelong(this.instance);
				}
				return r_HasExitSinks;
			}
		}

		/// <summary>
		/// System.LocalDataStore MyLocalStore
		/// </summary>
		protected RSystem.RLocalDataStore r_MyLocalStore;
		public virtual RSystem.RLocalDataStore RMyLocalStore
		{
			get
			{
				if(r_MyLocalStore == null)
				{
					r_MyLocalStore = new(this, "MyLocalStore", -1);
					r_MyLocalStore.SetBelong(this.instance);
				}
				return r_MyLocalStore;
			}
		}

		/// <summary>
		/// Void RegisterContext(System.Runtime.Remoting.Contexts.Context)
		/// </summary>
		protected static RMethod r_RegisterContext_Context;
		public static RMethod RRegisterContext_Context
		{
			get
			{
				if(r_RegisterContext_Context == null)
				{
					r_RegisterContext_Context = new(typeof(System.Runtime.Remoting.Contexts.Context), "RegisterContext", 0, typeof(System.Runtime.Remoting.Contexts.Context));
					r_RegisterContext_Context.SetBelong(null);
				}
				return r_RegisterContext_Context;
			}
		}

		/// <summary>
		/// Void ReleaseContext(System.Runtime.Remoting.Contexts.Context)
		/// </summary>
		protected static RMethod r_ReleaseContext_Context;
		public static RMethod RReleaseContext_Context
		{
			get
			{
				if(r_ReleaseContext_Context == null)
				{
					r_ReleaseContext_Context = new(typeof(System.Runtime.Remoting.Contexts.Context), "ReleaseContext", 0, typeof(System.Runtime.Remoting.Contexts.Context));
					r_ReleaseContext_Context.SetBelong(null);
				}
				return r_ReleaseContext_Context;
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
		/// Boolean RegisterDynamicProperty(System.Runtime.Remoting.Contexts.IDynamicProperty, System.ContextBoundObject, System.Runtime.Remoting.Contexts.Context)
		/// </summary>
		protected static RMethod r_RegisterDynamicProperty_IDynamicProperty_ContextBoundObject_Context;
		public static RMethod RRegisterDynamicProperty_IDynamicProperty_ContextBoundObject_Context
		{
			get
			{
				if(r_RegisterDynamicProperty_IDynamicProperty_ContextBoundObject_Context == null)
				{
					r_RegisterDynamicProperty_IDynamicProperty_ContextBoundObject_Context = new(typeof(System.Runtime.Remoting.Contexts.Context), "RegisterDynamicProperty", 0, typeof(System.Runtime.Remoting.Contexts.IDynamicProperty), typeof(System.ContextBoundObject), typeof(System.Runtime.Remoting.Contexts.Context));
					r_RegisterDynamicProperty_IDynamicProperty_ContextBoundObject_Context.SetBelong(null);
				}
				return r_RegisterDynamicProperty_IDynamicProperty_ContextBoundObject_Context;
			}
		}

		/// <summary>
		/// Boolean UnregisterDynamicProperty(System.String, System.ContextBoundObject, System.Runtime.Remoting.Contexts.Context)
		/// </summary>
		protected static RMethod r_UnregisterDynamicProperty_String_ContextBoundObject_Context;
		public static RMethod RUnregisterDynamicProperty_String_ContextBoundObject_Context
		{
			get
			{
				if(r_UnregisterDynamicProperty_String_ContextBoundObject_Context == null)
				{
					r_UnregisterDynamicProperty_String_ContextBoundObject_Context = new(typeof(System.Runtime.Remoting.Contexts.Context), "UnregisterDynamicProperty", 0, typeof(System.String), typeof(System.ContextBoundObject), typeof(System.Runtime.Remoting.Contexts.Context));
					r_UnregisterDynamicProperty_String_ContextBoundObject_Context.SetBelong(null);
				}
				return r_UnregisterDynamicProperty_String_ContextBoundObject_Context;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.DynamicPropertyCollection GetDynamicPropertyCollection(System.ContextBoundObject, System.Runtime.Remoting.Contexts.Context)
		/// </summary>
		protected static RMethod r_GetDynamicPropertyCollection_ContextBoundObject_Context;
		public static RMethod RGetDynamicPropertyCollection_ContextBoundObject_Context
		{
			get
			{
				if(r_GetDynamicPropertyCollection_ContextBoundObject_Context == null)
				{
					r_GetDynamicPropertyCollection_ContextBoundObject_Context = new(typeof(System.Runtime.Remoting.Contexts.Context), "GetDynamicPropertyCollection", 0, typeof(System.ContextBoundObject), typeof(System.Runtime.Remoting.Contexts.Context));
					r_GetDynamicPropertyCollection_ContextBoundObject_Context.SetBelong(null);
				}
				return r_GetDynamicPropertyCollection_ContextBoundObject_Context;
			}
		}

		/// <summary>
		/// Void NotifyGlobalDynamicSinks(Boolean, System.Runtime.Remoting.Messaging.IMessage, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_NotifyGlobalDynamicSinks_Boolean_IMessage_Boolean_Boolean;
		public static RMethod RNotifyGlobalDynamicSinks_Boolean_IMessage_Boolean_Boolean
		{
			get
			{
				if(r_NotifyGlobalDynamicSinks_Boolean_IMessage_Boolean_Boolean == null)
				{
					r_NotifyGlobalDynamicSinks_Boolean_IMessage_Boolean_Boolean = new(typeof(System.Runtime.Remoting.Contexts.Context), "NotifyGlobalDynamicSinks", 0, typeof(System.Boolean), typeof(System.Runtime.Remoting.Messaging.IMessage), typeof(System.Boolean), typeof(System.Boolean));
					r_NotifyGlobalDynamicSinks_Boolean_IMessage_Boolean_Boolean.SetBelong(null);
				}
				return r_NotifyGlobalDynamicSinks_Boolean_IMessage_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void NotifyDynamicSinks(Boolean, System.Runtime.Remoting.Messaging.IMessage, Boolean, Boolean)
		/// </summary>
		protected RMethod r_NotifyDynamicSinks_Boolean_IMessage_Boolean_Boolean;
		public virtual RMethod RNotifyDynamicSinks_Boolean_IMessage_Boolean_Boolean
		{
			get
			{
				if(r_NotifyDynamicSinks_Boolean_IMessage_Boolean_Boolean == null)
				{
					r_NotifyDynamicSinks_Boolean_IMessage_Boolean_Boolean = new(this, "NotifyDynamicSinks", 0, typeof(System.Boolean), typeof(System.Runtime.Remoting.Messaging.IMessage), typeof(System.Boolean), typeof(System.Boolean));
					r_NotifyDynamicSinks_Boolean_IMessage_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_NotifyDynamicSinks_Boolean_IMessage_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.IContextProperty GetProperty(System.String)
		/// </summary>
		protected RMethod r_GetProperty_String;
		public virtual RMethod RGetProperty_String
		{
			get
			{
				if(r_GetProperty_String == null)
				{
					r_GetProperty_String = new(this, "GetProperty", 0, typeof(System.String));
					r_GetProperty_String.SetBelong(this.instance);
				}
				return r_GetProperty_String;
			}
		}

		/// <summary>
		/// Void SetProperty(System.Runtime.Remoting.Contexts.IContextProperty)
		/// </summary>
		protected RMethod r_SetProperty_IContextProperty;
		public virtual RMethod RSetProperty_IContextProperty
		{
			get
			{
				if(r_SetProperty_IContextProperty == null)
				{
					r_SetProperty_IContextProperty = new(this, "SetProperty", 0, typeof(System.Runtime.Remoting.Contexts.IContextProperty));
					r_SetProperty_IContextProperty.SetBelong(this.instance);
				}
				return r_SetProperty_IContextProperty;
			}
		}

		/// <summary>
		/// Void Freeze()
		/// </summary>
		protected RMethod r_Freeze;
		public virtual RMethod RFreeze
		{
			get
			{
				if(r_Freeze == null)
				{
					r_Freeze = new(this, "Freeze", 0);
					r_Freeze.SetBelong(this.instance);
				}
				return r_Freeze;
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

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessageSink GetServerContextSinkChain()
		/// </summary>
		protected RMethod r_GetServerContextSinkChain;
		public virtual RMethod RGetServerContextSinkChain
		{
			get
			{
				if(r_GetServerContextSinkChain == null)
				{
					r_GetServerContextSinkChain = new(this, "GetServerContextSinkChain", 0);
					r_GetServerContextSinkChain.SetBelong(this.instance);
				}
				return r_GetServerContextSinkChain;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessageSink GetClientContextSinkChain()
		/// </summary>
		protected RMethod r_GetClientContextSinkChain;
		public virtual RMethod RGetClientContextSinkChain
		{
			get
			{
				if(r_GetClientContextSinkChain == null)
				{
					r_GetClientContextSinkChain = new(this, "GetClientContextSinkChain", 0);
					r_GetClientContextSinkChain.SetBelong(this.instance);
				}
				return r_GetClientContextSinkChain;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessageSink CreateServerObjectSinkChain(System.MarshalByRefObject, Boolean)
		/// </summary>
		protected RMethod r_CreateServerObjectSinkChain_MarshalByRefObject_Boolean;
		public virtual RMethod RCreateServerObjectSinkChain_MarshalByRefObject_Boolean
		{
			get
			{
				if(r_CreateServerObjectSinkChain_MarshalByRefObject_Boolean == null)
				{
					r_CreateServerObjectSinkChain_MarshalByRefObject_Boolean = new(this, "CreateServerObjectSinkChain", 0, typeof(System.MarshalByRefObject), typeof(System.Boolean));
					r_CreateServerObjectSinkChain_MarshalByRefObject_Boolean.SetBelong(this.instance);
				}
				return r_CreateServerObjectSinkChain_MarshalByRefObject_Boolean;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessageSink CreateEnvoySink(System.MarshalByRefObject)
		/// </summary>
		protected RMethod r_CreateEnvoySink_MarshalByRefObject;
		public virtual RMethod RCreateEnvoySink_MarshalByRefObject
		{
			get
			{
				if(r_CreateEnvoySink_MarshalByRefObject == null)
				{
					r_CreateEnvoySink_MarshalByRefObject = new(this, "CreateEnvoySink", 0, typeof(System.MarshalByRefObject));
					r_CreateEnvoySink_MarshalByRefObject.SetBelong(this.instance);
				}
				return r_CreateEnvoySink_MarshalByRefObject;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.Context SwitchToContext(System.Runtime.Remoting.Contexts.Context)
		/// </summary>
		protected static RMethod r_SwitchToContext_Context;
		public static RMethod RSwitchToContext_Context
		{
			get
			{
				if(r_SwitchToContext_Context == null)
				{
					r_SwitchToContext_Context = new(typeof(System.Runtime.Remoting.Contexts.Context), "SwitchToContext", 0, typeof(System.Runtime.Remoting.Contexts.Context));
					r_SwitchToContext_Context.SetBelong(null);
				}
				return r_SwitchToContext_Context;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.Context CreateNewContext(System.Runtime.Remoting.Activation.IConstructionCallMessage)
		/// </summary>
		protected static RMethod r_CreateNewContext_IConstructionCallMessage;
		public static RMethod RCreateNewContext_IConstructionCallMessage
		{
			get
			{
				if(r_CreateNewContext_IConstructionCallMessage == null)
				{
					r_CreateNewContext_IConstructionCallMessage = new(typeof(System.Runtime.Remoting.Contexts.Context), "CreateNewContext", 0, typeof(System.Runtime.Remoting.Activation.IConstructionCallMessage));
					r_CreateNewContext_IConstructionCallMessage.SetBelong(null);
				}
				return r_CreateNewContext_IConstructionCallMessage;
			}
		}

		/// <summary>
		/// Void DoCallBack(System.Runtime.Remoting.Contexts.CrossContextDelegate)
		/// </summary>
		protected RMethod r_DoCallBack_CrossContextDelegate;
		public virtual RMethod RDoCallBack_CrossContextDelegate
		{
			get
			{
				if(r_DoCallBack_CrossContextDelegate == null)
				{
					r_DoCallBack_CrossContextDelegate = new(this, "DoCallBack", 0, typeof(System.Runtime.Remoting.Contexts.CrossContextDelegate));
					r_DoCallBack_CrossContextDelegate.SetBelong(this.instance);
				}
				return r_DoCallBack_CrossContextDelegate;
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
					r_AllocateDataSlot = new(typeof(System.Runtime.Remoting.Contexts.Context), "AllocateDataSlot", 0);
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
					r_AllocateNamedDataSlot_String = new(typeof(System.Runtime.Remoting.Contexts.Context), "AllocateNamedDataSlot", 0, typeof(System.String));
					r_AllocateNamedDataSlot_String.SetBelong(null);
				}
				return r_AllocateNamedDataSlot_String;
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
					r_FreeNamedDataSlot_String = new(typeof(System.Runtime.Remoting.Contexts.Context), "FreeNamedDataSlot", 0, typeof(System.String));
					r_FreeNamedDataSlot_String.SetBelong(null);
				}
				return r_FreeNamedDataSlot_String;
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
					r_GetNamedDataSlot_String = new(typeof(System.Runtime.Remoting.Contexts.Context), "GetNamedDataSlot", 0, typeof(System.String));
					r_GetNamedDataSlot_String.SetBelong(null);
				}
				return r_GetNamedDataSlot_String;
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
					r_GetData_LocalDataStoreSlot = new(typeof(System.Runtime.Remoting.Contexts.Context), "GetData", 0, typeof(System.LocalDataStoreSlot));
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
					r_SetData_LocalDataStoreSlot_Object = new(typeof(System.Runtime.Remoting.Contexts.Context), "SetData", 0, typeof(System.LocalDataStoreSlot), typeof(System.Object));
					r_SetData_LocalDataStoreSlot_Object.SetBelong(null);
				}
				return r_SetData_LocalDataStoreSlot_Object;
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


        public RContext() : base("System.Runtime.Remoting.Contexts.Context")
        {
        }

        public RContext(System.Object instance) : base("System.Runtime.Remoting.Contexts.Context")
		{
            SetInstance(instance);
		}

        public RContext(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RContext(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static void RegisterContext(System.Runtime.Remoting.Contexts.Context  @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx};
            var ___result = RRegisterContext_Context.Invoke(___genericsType, ___parameters);

            
        }


        public static void ReleaseContext(System.Runtime.Remoting.Contexts.Context  @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx};
            var ___result = RReleaseContext_Context.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean RegisterDynamicProperty(System.Runtime.Remoting.Contexts.IDynamicProperty  @prop, System.ContextBoundObject  @obj, System.Runtime.Remoting.Contexts.Context  @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prop, @obj, @ctx};
            var ___result = RRegisterDynamicProperty_IDynamicProperty_ContextBoundObject_Context.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean UnregisterDynamicProperty(System.String  @name, System.ContextBoundObject  @obj, System.Runtime.Remoting.Contexts.Context  @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @obj, @ctx};
            var ___result = RUnregisterDynamicProperty_String_ContextBoundObject_Context.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Object GetDynamicPropertyCollection(System.ContextBoundObject  @obj, System.Runtime.Remoting.Contexts.Context  @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @ctx};
            var ___result = RGetDynamicPropertyCollection_ContextBoundObject_Context.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static void NotifyGlobalDynamicSinks(System.Boolean  @start, System.Runtime.Remoting.Messaging.IMessage  @req_msg, System.Boolean  @client_site, System.Boolean  @async)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @req_msg, @client_site, @async};
            var ___result = RNotifyGlobalDynamicSinks_Boolean_IMessage_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void NotifyDynamicSinks(System.Boolean  @start, System.Runtime.Remoting.Messaging.IMessage  @req_msg, System.Boolean  @client_site, System.Boolean  @async)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @req_msg, @client_site, @async};
            var ___result = RNotifyDynamicSinks_Boolean_IMessage_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Runtime.Remoting.Contexts.IContextProperty GetProperty(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetProperty_String.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.Contexts.IContextProperty)___result;
        }


        public virtual void SetProperty(System.Runtime.Remoting.Contexts.IContextProperty  @prop)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prop};
            var ___result = RSetProperty_IContextProperty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Freeze()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFreeze.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Runtime.Remoting.Messaging.IMessageSink GetServerContextSinkChain()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetServerContextSinkChain.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.Messaging.IMessageSink)___result;
        }


        public virtual System.Runtime.Remoting.Messaging.IMessageSink GetClientContextSinkChain()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetClientContextSinkChain.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.Messaging.IMessageSink)___result;
        }


        public virtual System.Runtime.Remoting.Messaging.IMessageSink CreateServerObjectSinkChain(System.MarshalByRefObject  @obj, System.Boolean  @forceInternalExecute)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @forceInternalExecute};
            var ___result = RCreateServerObjectSinkChain_MarshalByRefObject_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.Messaging.IMessageSink)___result;
        }


        public virtual System.Runtime.Remoting.Messaging.IMessageSink CreateEnvoySink(System.MarshalByRefObject  @serverObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@serverObject};
            var ___result = RCreateEnvoySink_MarshalByRefObject.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.Messaging.IMessageSink)___result;
        }


        public static System.Runtime.Remoting.Contexts.Context SwitchToContext(System.Runtime.Remoting.Contexts.Context  @newContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newContext};
            var ___result = RSwitchToContext_Context.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.Contexts.Context)___result;
        }


        public static System.Runtime.Remoting.Contexts.Context CreateNewContext(System.Runtime.Remoting.Activation.IConstructionCallMessage  @msg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@msg};
            var ___result = RCreateNewContext_IConstructionCallMessage.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.Contexts.Context)___result;
        }


        public virtual void DoCallBack(System.Runtime.Remoting.Contexts.CrossContextDelegate  @deleg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@deleg};
            var ___result = RDoCallBack_CrossContextDelegate.Invoke(___genericsType, ___parameters);

            
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


        public static void FreeNamedDataSlot(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RFreeNamedDataSlot_String.Invoke(___genericsType, ___parameters);

            
        }


        public static System.LocalDataStoreSlot GetNamedDataSlot(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetNamedDataSlot_String.Invoke(___genericsType, ___parameters);

            return (System.LocalDataStoreSlot)___result;
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


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


    }
}
