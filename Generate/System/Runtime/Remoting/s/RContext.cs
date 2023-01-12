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
		protected RSystem.RInt32 r_Fdomain_id;
		public virtual RSystem.RInt32 RFdomain_id
		{
			get
			{
				if(r_Fdomain_id == null)
				{
					r_Fdomain_id = new(this, "domain_id");
					r_Fdomain_id.SetBelong(this.instance);
				}
				return r_Fdomain_id;
			}
		}

		/// <summary>
		/// System.Int32 context_id
		/// </summary>
		protected RSystem.RInt32 r_Fcontext_id;
		public virtual RSystem.RInt32 RFcontext_id
		{
			get
			{
				if(r_Fcontext_id == null)
				{
					r_Fcontext_id = new(this, "context_id");
					r_Fcontext_id.SetBelong(this.instance);
				}
				return r_Fcontext_id;
			}
		}

		/// <summary>
		/// System.UIntPtr static_data
		/// </summary>
		protected RSystem.RUIntPtr r_Fstatic_data;
		public virtual RSystem.RUIntPtr RFstatic_data
		{
			get
			{
				if(r_Fstatic_data == null)
				{
					r_Fstatic_data = new(this, "static_data");
					r_Fstatic_data.SetBelong(this.instance);
				}
				return r_Fstatic_data;
			}
		}

		/// <summary>
		/// System.UIntPtr data
		/// </summary>
		protected RSystem.RUIntPtr r_Fdata;
		public virtual RSystem.RUIntPtr RFdata
		{
			get
			{
				if(r_Fdata == null)
				{
					r_Fdata = new(this, "data");
					r_Fdata.SetBelong(this.instance);
				}
				return r_Fdata;
			}
		}

		/// <summary>
		/// System.Object[] local_slots
		/// </summary>
		protected static RFieldArray<RSystem.RObject> r_Flocal_slots;
		public static RFieldArray<RSystem.RObject> RFlocal_slots
		{
			get
			{
				if(r_Flocal_slots == null)
				{
					r_Flocal_slots = new(typeof(System.Runtime.Remoting.Contexts.Context), "local_slots");
					r_Flocal_slots.SetBelong(null);
				}
				return r_Flocal_slots;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessageSink default_server_context_sink
		/// </summary>
		protected static RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink r_Fdefault_server_context_sink;
		public static RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink RFdefault_server_context_sink
		{
			get
			{
				if(r_Fdefault_server_context_sink == null)
				{
					r_Fdefault_server_context_sink = new(typeof(System.Runtime.Remoting.Contexts.Context), "default_server_context_sink");
					r_Fdefault_server_context_sink.SetBelong(null);
				}
				return r_Fdefault_server_context_sink;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessageSink server_context_sink_chain
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink r_Fserver_context_sink_chain;
		public virtual RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink RFserver_context_sink_chain
		{
			get
			{
				if(r_Fserver_context_sink_chain == null)
				{
					r_Fserver_context_sink_chain = new(this, "server_context_sink_chain");
					r_Fserver_context_sink_chain.SetBelong(this.instance);
				}
				return r_Fserver_context_sink_chain;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessageSink client_context_sink_chain
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink r_Fclient_context_sink_chain;
		public virtual RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink RFclient_context_sink_chain
		{
			get
			{
				if(r_Fclient_context_sink_chain == null)
				{
					r_Fclient_context_sink_chain = new(this, "client_context_sink_chain");
					r_Fclient_context_sink_chain.SetBelong(this.instance);
				}
				return r_Fclient_context_sink_chain;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Runtime.Remoting.Contexts.IContextProperty] context_properties
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSystem.RRuntime.RRemoting.RContexts.RIContextProperty> r_Fcontext_properties;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RRuntime.RRemoting.RContexts.RIContextProperty> RFcontext_properties
		{
			get
			{
				if(r_Fcontext_properties == null)
				{
					r_Fcontext_properties = new(this, "context_properties");
					r_Fcontext_properties.SetBelong(this.instance);
				}
				return r_Fcontext_properties;
			}
		}

		/// <summary>
		/// System.Int32 global_count
		/// </summary>
		protected static RSystem.RInt32 r_Fglobal_count;
		public static RSystem.RInt32 RFglobal_count
		{
			get
			{
				if(r_Fglobal_count == null)
				{
					r_Fglobal_count = new(typeof(System.Runtime.Remoting.Contexts.Context), "global_count");
					r_Fglobal_count.SetBelong(null);
				}
				return r_Fglobal_count;
			}
		}

		/// <summary>
		/// System.LocalDataStoreHolder _localDataStore
		/// </summary>
		protected RSystem.RLocalDataStoreHolder r_F_localDataStore;
		public virtual RSystem.RLocalDataStoreHolder RF_localDataStore
		{
			get
			{
				if(r_F_localDataStore == null)
				{
					r_F_localDataStore = new(this, "_localDataStore");
					r_F_localDataStore.SetBelong(this.instance);
				}
				return r_F_localDataStore;
			}
		}

		/// <summary>
		/// System.LocalDataStoreMgr _localDataStoreMgr
		/// </summary>
		protected static RSystem.RLocalDataStoreMgr r_F_localDataStoreMgr;
		public static RSystem.RLocalDataStoreMgr RF_localDataStoreMgr
		{
			get
			{
				if(r_F_localDataStoreMgr == null)
				{
					r_F_localDataStoreMgr = new(typeof(System.Runtime.Remoting.Contexts.Context), "_localDataStoreMgr");
					r_F_localDataStoreMgr.SetBelong(null);
				}
				return r_F_localDataStoreMgr;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.DynamicPropertyCollection global_dynamic_properties
		/// </summary>
		protected static RSystem.RRuntime.RRemoting.RContexts.RDynamicPropertyCollection r_Fglobal_dynamic_properties;
		public static RSystem.RRuntime.RRemoting.RContexts.RDynamicPropertyCollection RFglobal_dynamic_properties
		{
			get
			{
				if(r_Fglobal_dynamic_properties == null)
				{
					r_Fglobal_dynamic_properties = new(typeof(System.Runtime.Remoting.Contexts.Context), "global_dynamic_properties");
					r_Fglobal_dynamic_properties.SetBelong(null);
				}
				return r_Fglobal_dynamic_properties;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.DynamicPropertyCollection context_dynamic_properties
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RContexts.RDynamicPropertyCollection r_Fcontext_dynamic_properties;
		public virtual RSystem.RRuntime.RRemoting.RContexts.RDynamicPropertyCollection RFcontext_dynamic_properties
		{
			get
			{
				if(r_Fcontext_dynamic_properties == null)
				{
					r_Fcontext_dynamic_properties = new(this, "context_dynamic_properties");
					r_Fcontext_dynamic_properties.SetBelong(this.instance);
				}
				return r_Fcontext_dynamic_properties;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.ContextCallbackObject callback_object
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RContexts.RContextCallbackObject r_Fcallback_object;
		public virtual RSystem.RRuntime.RRemoting.RContexts.RContextCallbackObject RFcallback_object
		{
			get
			{
				if(r_Fcallback_object == null)
				{
					r_Fcallback_object = new(this, "callback_object");
					r_Fcallback_object.SetBelong(this.instance);
				}
				return r_Fcallback_object;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.Context DefaultContext
		/// </summary>
		protected static RSystem.RRuntime.RRemoting.RContexts.RContext r_PDefaultContext;
		public static RSystem.RRuntime.RRemoting.RContexts.RContext RPDefaultContext
		{
			get
			{
				if(r_PDefaultContext == null)
				{
					r_PDefaultContext = new(typeof(System.Runtime.Remoting.Contexts.Context), "DefaultContext", -1);
					r_PDefaultContext.SetBelong(null);
				}
				return r_PDefaultContext;
			}
		}

		/// <summary>
		/// Int32 ContextID
		/// </summary>
		protected RSystem.RInt32 r_PContextID;
		public virtual RSystem.RInt32 RPContextID
		{
			get
			{
				if(r_PContextID == null)
				{
					r_PContextID = new(this, "ContextID", -1);
					r_PContextID.SetBelong(this.instance);
				}
				return r_PContextID;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.IContextProperty[] ContextProperties
		/// </summary>
		protected RPropertyArray<RSystem.RRuntime.RRemoting.RContexts.RIContextProperty> r_PContextProperties;
		public virtual RPropertyArray<RSystem.RRuntime.RRemoting.RContexts.RIContextProperty> RPContextProperties
		{
			get
			{
				if(r_PContextProperties == null)
				{
					r_PContextProperties = new(this, "ContextProperties", -1);
					r_PContextProperties.SetBelong(this.instance);
				}
				return r_PContextProperties;
			}
		}

		/// <summary>
		/// Boolean IsDefaultContext
		/// </summary>
		protected RSystem.RBoolean r_PIsDefaultContext;
		public virtual RSystem.RBoolean RPIsDefaultContext
		{
			get
			{
				if(r_PIsDefaultContext == null)
				{
					r_PIsDefaultContext = new(this, "IsDefaultContext", -1);
					r_PIsDefaultContext.SetBelong(this.instance);
				}
				return r_PIsDefaultContext;
			}
		}

		/// <summary>
		/// Boolean NeedsContextSink
		/// </summary>
		protected RSystem.RBoolean r_PNeedsContextSink;
		public virtual RSystem.RBoolean RPNeedsContextSink
		{
			get
			{
				if(r_PNeedsContextSink == null)
				{
					r_PNeedsContextSink = new(this, "NeedsContextSink", -1);
					r_PNeedsContextSink.SetBelong(this.instance);
				}
				return r_PNeedsContextSink;
			}
		}

		/// <summary>
		/// Boolean HasGlobalDynamicSinks
		/// </summary>
		protected static RSystem.RBoolean r_PHasGlobalDynamicSinks;
		public static RSystem.RBoolean RPHasGlobalDynamicSinks
		{
			get
			{
				if(r_PHasGlobalDynamicSinks == null)
				{
					r_PHasGlobalDynamicSinks = new(typeof(System.Runtime.Remoting.Contexts.Context), "HasGlobalDynamicSinks", -1);
					r_PHasGlobalDynamicSinks.SetBelong(null);
				}
				return r_PHasGlobalDynamicSinks;
			}
		}

		/// <summary>
		/// Boolean HasDynamicSinks
		/// </summary>
		protected RSystem.RBoolean r_PHasDynamicSinks;
		public virtual RSystem.RBoolean RPHasDynamicSinks
		{
			get
			{
				if(r_PHasDynamicSinks == null)
				{
					r_PHasDynamicSinks = new(this, "HasDynamicSinks", -1);
					r_PHasDynamicSinks.SetBelong(this.instance);
				}
				return r_PHasDynamicSinks;
			}
		}

		/// <summary>
		/// Boolean HasExitSinks
		/// </summary>
		protected RSystem.RBoolean r_PHasExitSinks;
		public virtual RSystem.RBoolean RPHasExitSinks
		{
			get
			{
				if(r_PHasExitSinks == null)
				{
					r_PHasExitSinks = new(this, "HasExitSinks", -1);
					r_PHasExitSinks.SetBelong(this.instance);
				}
				return r_PHasExitSinks;
			}
		}

		/// <summary>
		/// System.LocalDataStore MyLocalStore
		/// </summary>
		protected RSystem.RLocalDataStore r_PMyLocalStore;
		public virtual RSystem.RLocalDataStore RPMyLocalStore
		{
			get
			{
				if(r_PMyLocalStore == null)
				{
					r_PMyLocalStore = new(this, "MyLocalStore", -1);
					r_PMyLocalStore.SetBelong(this.instance);
				}
				return r_PMyLocalStore;
			}
		}

		/// <summary>
		/// Void RegisterContext(System.Runtime.Remoting.Contexts.Context)
		/// </summary>
		protected static RMethod r_MRegisterContext_Context;
		public static RMethod RMRegisterContext_Context
		{
			get
			{
				if(r_MRegisterContext_Context == null)
				{
					r_MRegisterContext_Context = new(typeof(System.Runtime.Remoting.Contexts.Context), "RegisterContext", 0, typeof(System.Runtime.Remoting.Contexts.Context));
					r_MRegisterContext_Context.SetBelong(null);
				}
				return r_MRegisterContext_Context;
			}
		}

		/// <summary>
		/// Void ReleaseContext(System.Runtime.Remoting.Contexts.Context)
		/// </summary>
		protected static RMethod r_MReleaseContext_Context;
		public static RMethod RMReleaseContext_Context
		{
			get
			{
				if(r_MReleaseContext_Context == null)
				{
					r_MReleaseContext_Context = new(typeof(System.Runtime.Remoting.Contexts.Context), "ReleaseContext", 0, typeof(System.Runtime.Remoting.Contexts.Context));
					r_MReleaseContext_Context.SetBelong(null);
				}
				return r_MReleaseContext_Context;
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
		/// Boolean RegisterDynamicProperty(System.Runtime.Remoting.Contexts.IDynamicProperty, System.ContextBoundObject, System.Runtime.Remoting.Contexts.Context)
		/// </summary>
		protected static RMethod r_MRegisterDynamicProperty_IDynamicProperty_ContextBoundObject_Context;
		public static RMethod RMRegisterDynamicProperty_IDynamicProperty_ContextBoundObject_Context
		{
			get
			{
				if(r_MRegisterDynamicProperty_IDynamicProperty_ContextBoundObject_Context == null)
				{
					r_MRegisterDynamicProperty_IDynamicProperty_ContextBoundObject_Context = new(typeof(System.Runtime.Remoting.Contexts.Context), "RegisterDynamicProperty", 0, typeof(System.Runtime.Remoting.Contexts.IDynamicProperty), typeof(System.ContextBoundObject), typeof(System.Runtime.Remoting.Contexts.Context));
					r_MRegisterDynamicProperty_IDynamicProperty_ContextBoundObject_Context.SetBelong(null);
				}
				return r_MRegisterDynamicProperty_IDynamicProperty_ContextBoundObject_Context;
			}
		}

		/// <summary>
		/// Boolean UnregisterDynamicProperty(System.String, System.ContextBoundObject, System.Runtime.Remoting.Contexts.Context)
		/// </summary>
		protected static RMethod r_MUnregisterDynamicProperty_String_ContextBoundObject_Context;
		public static RMethod RMUnregisterDynamicProperty_String_ContextBoundObject_Context
		{
			get
			{
				if(r_MUnregisterDynamicProperty_String_ContextBoundObject_Context == null)
				{
					r_MUnregisterDynamicProperty_String_ContextBoundObject_Context = new(typeof(System.Runtime.Remoting.Contexts.Context), "UnregisterDynamicProperty", 0, typeof(System.String), typeof(System.ContextBoundObject), typeof(System.Runtime.Remoting.Contexts.Context));
					r_MUnregisterDynamicProperty_String_ContextBoundObject_Context.SetBelong(null);
				}
				return r_MUnregisterDynamicProperty_String_ContextBoundObject_Context;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.DynamicPropertyCollection GetDynamicPropertyCollection(System.ContextBoundObject, System.Runtime.Remoting.Contexts.Context)
		/// </summary>
		protected static RMethod r_MGetDynamicPropertyCollection_ContextBoundObject_Context;
		public static RMethod RMGetDynamicPropertyCollection_ContextBoundObject_Context
		{
			get
			{
				if(r_MGetDynamicPropertyCollection_ContextBoundObject_Context == null)
				{
					r_MGetDynamicPropertyCollection_ContextBoundObject_Context = new(typeof(System.Runtime.Remoting.Contexts.Context), "GetDynamicPropertyCollection", 0, typeof(System.ContextBoundObject), typeof(System.Runtime.Remoting.Contexts.Context));
					r_MGetDynamicPropertyCollection_ContextBoundObject_Context.SetBelong(null);
				}
				return r_MGetDynamicPropertyCollection_ContextBoundObject_Context;
			}
		}

		/// <summary>
		/// Void NotifyGlobalDynamicSinks(Boolean, System.Runtime.Remoting.Messaging.IMessage, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_MNotifyGlobalDynamicSinks_Boolean_IMessage_Boolean_Boolean;
		public static RMethod RMNotifyGlobalDynamicSinks_Boolean_IMessage_Boolean_Boolean
		{
			get
			{
				if(r_MNotifyGlobalDynamicSinks_Boolean_IMessage_Boolean_Boolean == null)
				{
					r_MNotifyGlobalDynamicSinks_Boolean_IMessage_Boolean_Boolean = new(typeof(System.Runtime.Remoting.Contexts.Context), "NotifyGlobalDynamicSinks", 0, typeof(System.Boolean), typeof(System.Runtime.Remoting.Messaging.IMessage), typeof(System.Boolean), typeof(System.Boolean));
					r_MNotifyGlobalDynamicSinks_Boolean_IMessage_Boolean_Boolean.SetBelong(null);
				}
				return r_MNotifyGlobalDynamicSinks_Boolean_IMessage_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void NotifyDynamicSinks(Boolean, System.Runtime.Remoting.Messaging.IMessage, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MNotifyDynamicSinks_Boolean_IMessage_Boolean_Boolean;
		public virtual RMethod RMNotifyDynamicSinks_Boolean_IMessage_Boolean_Boolean
		{
			get
			{
				if(r_MNotifyDynamicSinks_Boolean_IMessage_Boolean_Boolean == null)
				{
					r_MNotifyDynamicSinks_Boolean_IMessage_Boolean_Boolean = new(this, "NotifyDynamicSinks", 0, typeof(System.Boolean), typeof(System.Runtime.Remoting.Messaging.IMessage), typeof(System.Boolean), typeof(System.Boolean));
					r_MNotifyDynamicSinks_Boolean_IMessage_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_MNotifyDynamicSinks_Boolean_IMessage_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.IContextProperty GetProperty(System.String)
		/// </summary>
		protected RMethod r_MGetProperty_String;
		public virtual RMethod RMGetProperty_String
		{
			get
			{
				if(r_MGetProperty_String == null)
				{
					r_MGetProperty_String = new(this, "GetProperty", 0, typeof(System.String));
					r_MGetProperty_String.SetBelong(this.instance);
				}
				return r_MGetProperty_String;
			}
		}

		/// <summary>
		/// Void SetProperty(System.Runtime.Remoting.Contexts.IContextProperty)
		/// </summary>
		protected RMethod r_MSetProperty_IContextProperty;
		public virtual RMethod RMSetProperty_IContextProperty
		{
			get
			{
				if(r_MSetProperty_IContextProperty == null)
				{
					r_MSetProperty_IContextProperty = new(this, "SetProperty", 0, typeof(System.Runtime.Remoting.Contexts.IContextProperty));
					r_MSetProperty_IContextProperty.SetBelong(this.instance);
				}
				return r_MSetProperty_IContextProperty;
			}
		}

		/// <summary>
		/// Void Freeze()
		/// </summary>
		protected RMethod r_MFreeze;
		public virtual RMethod RMFreeze
		{
			get
			{
				if(r_MFreeze == null)
				{
					r_MFreeze = new(this, "Freeze", 0);
					r_MFreeze.SetBelong(this.instance);
				}
				return r_MFreeze;
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

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessageSink GetServerContextSinkChain()
		/// </summary>
		protected RMethod r_MGetServerContextSinkChain;
		public virtual RMethod RMGetServerContextSinkChain
		{
			get
			{
				if(r_MGetServerContextSinkChain == null)
				{
					r_MGetServerContextSinkChain = new(this, "GetServerContextSinkChain", 0);
					r_MGetServerContextSinkChain.SetBelong(this.instance);
				}
				return r_MGetServerContextSinkChain;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessageSink GetClientContextSinkChain()
		/// </summary>
		protected RMethod r_MGetClientContextSinkChain;
		public virtual RMethod RMGetClientContextSinkChain
		{
			get
			{
				if(r_MGetClientContextSinkChain == null)
				{
					r_MGetClientContextSinkChain = new(this, "GetClientContextSinkChain", 0);
					r_MGetClientContextSinkChain.SetBelong(this.instance);
				}
				return r_MGetClientContextSinkChain;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessageSink CreateServerObjectSinkChain(System.MarshalByRefObject, Boolean)
		/// </summary>
		protected RMethod r_MCreateServerObjectSinkChain_MarshalByRefObject_Boolean;
		public virtual RMethod RMCreateServerObjectSinkChain_MarshalByRefObject_Boolean
		{
			get
			{
				if(r_MCreateServerObjectSinkChain_MarshalByRefObject_Boolean == null)
				{
					r_MCreateServerObjectSinkChain_MarshalByRefObject_Boolean = new(this, "CreateServerObjectSinkChain", 0, typeof(System.MarshalByRefObject), typeof(System.Boolean));
					r_MCreateServerObjectSinkChain_MarshalByRefObject_Boolean.SetBelong(this.instance);
				}
				return r_MCreateServerObjectSinkChain_MarshalByRefObject_Boolean;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessageSink CreateEnvoySink(System.MarshalByRefObject)
		/// </summary>
		protected RMethod r_MCreateEnvoySink_MarshalByRefObject;
		public virtual RMethod RMCreateEnvoySink_MarshalByRefObject
		{
			get
			{
				if(r_MCreateEnvoySink_MarshalByRefObject == null)
				{
					r_MCreateEnvoySink_MarshalByRefObject = new(this, "CreateEnvoySink", 0, typeof(System.MarshalByRefObject));
					r_MCreateEnvoySink_MarshalByRefObject.SetBelong(this.instance);
				}
				return r_MCreateEnvoySink_MarshalByRefObject;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.Context SwitchToContext(System.Runtime.Remoting.Contexts.Context)
		/// </summary>
		protected static RMethod r_MSwitchToContext_Context;
		public static RMethod RMSwitchToContext_Context
		{
			get
			{
				if(r_MSwitchToContext_Context == null)
				{
					r_MSwitchToContext_Context = new(typeof(System.Runtime.Remoting.Contexts.Context), "SwitchToContext", 0, typeof(System.Runtime.Remoting.Contexts.Context));
					r_MSwitchToContext_Context.SetBelong(null);
				}
				return r_MSwitchToContext_Context;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.Context CreateNewContext(System.Runtime.Remoting.Activation.IConstructionCallMessage)
		/// </summary>
		protected static RMethod r_MCreateNewContext_IConstructionCallMessage;
		public static RMethod RMCreateNewContext_IConstructionCallMessage
		{
			get
			{
				if(r_MCreateNewContext_IConstructionCallMessage == null)
				{
					r_MCreateNewContext_IConstructionCallMessage = new(typeof(System.Runtime.Remoting.Contexts.Context), "CreateNewContext", 0, typeof(System.Runtime.Remoting.Activation.IConstructionCallMessage));
					r_MCreateNewContext_IConstructionCallMessage.SetBelong(null);
				}
				return r_MCreateNewContext_IConstructionCallMessage;
			}
		}

		/// <summary>
		/// Void DoCallBack(System.Runtime.Remoting.Contexts.CrossContextDelegate)
		/// </summary>
		protected RMethod r_MDoCallBack_CrossContextDelegate;
		public virtual RMethod RMDoCallBack_CrossContextDelegate
		{
			get
			{
				if(r_MDoCallBack_CrossContextDelegate == null)
				{
					r_MDoCallBack_CrossContextDelegate = new(this, "DoCallBack", 0, typeof(System.Runtime.Remoting.Contexts.CrossContextDelegate));
					r_MDoCallBack_CrossContextDelegate.SetBelong(this.instance);
				}
				return r_MDoCallBack_CrossContextDelegate;
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
					r_MAllocateDataSlot = new(typeof(System.Runtime.Remoting.Contexts.Context), "AllocateDataSlot", 0);
					r_MAllocateDataSlot.SetBelong(null);
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
					r_MAllocateNamedDataSlot_String = new(typeof(System.Runtime.Remoting.Contexts.Context), "AllocateNamedDataSlot", 0, typeof(System.String));
					r_MAllocateNamedDataSlot_String.SetBelong(null);
				}
				return r_MAllocateNamedDataSlot_String;
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
					r_MFreeNamedDataSlot_String = new(typeof(System.Runtime.Remoting.Contexts.Context), "FreeNamedDataSlot", 0, typeof(System.String));
					r_MFreeNamedDataSlot_String.SetBelong(null);
				}
				return r_MFreeNamedDataSlot_String;
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
					r_MGetNamedDataSlot_String = new(typeof(System.Runtime.Remoting.Contexts.Context), "GetNamedDataSlot", 0, typeof(System.String));
					r_MGetNamedDataSlot_String.SetBelong(null);
				}
				return r_MGetNamedDataSlot_String;
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
					r_MGetData_LocalDataStoreSlot = new(typeof(System.Runtime.Remoting.Contexts.Context), "GetData", 0, typeof(System.LocalDataStoreSlot));
					r_MGetData_LocalDataStoreSlot.SetBelong(null);
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
					r_MSetData_LocalDataStoreSlot_Object = new(typeof(System.Runtime.Remoting.Contexts.Context), "SetData", 0, typeof(System.LocalDataStoreSlot), typeof(System.Object));
					r_MSetData_LocalDataStoreSlot_Object.SetBelong(null);
				}
				return r_MSetData_LocalDataStoreSlot_Object;
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

        public static void RegisterContext(System.Runtime.Remoting.Contexts.Context @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx};
            var ___result = RMRegisterContext_Context.Invoke(___genericsType, ___parameters);

            
        }


        public static void ReleaseContext(System.Runtime.Remoting.Contexts.Context @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx};
            var ___result = RMReleaseContext_Context.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean RegisterDynamicProperty(System.Runtime.Remoting.Contexts.IDynamicProperty @prop, System.ContextBoundObject @obj, System.Runtime.Remoting.Contexts.Context @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prop, @obj, @ctx};
            var ___result = RMRegisterDynamicProperty_IDynamicProperty_ContextBoundObject_Context.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean UnregisterDynamicProperty(System.String @name, System.ContextBoundObject @obj, System.Runtime.Remoting.Contexts.Context @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @obj, @ctx};
            var ___result = RMUnregisterDynamicProperty_String_ContextBoundObject_Context.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static RSystem.RRuntime.RRemoting.RContexts.RDynamicPropertyCollection GetDynamicPropertyCollection(System.ContextBoundObject @obj, System.Runtime.Remoting.Contexts.Context @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @ctx};
            var ___result = RMGetDynamicPropertyCollection_ContextBoundObject_Context.Invoke(___genericsType, ___parameters);

            return new RSystem.RRuntime.RRemoting.RContexts.RDynamicPropertyCollection(___result);
        }


        public static void NotifyGlobalDynamicSinks(System.Boolean @start, System.Runtime.Remoting.Messaging.IMessage @req_msg, System.Boolean @client_site, System.Boolean @async)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @req_msg, @client_site, @async};
            var ___result = RMNotifyGlobalDynamicSinks_Boolean_IMessage_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void NotifyDynamicSinks(System.Boolean @start, System.Runtime.Remoting.Messaging.IMessage @req_msg, System.Boolean @client_site, System.Boolean @async)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @req_msg, @client_site, @async};
            var ___result = RMNotifyDynamicSinks_Boolean_IMessage_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Runtime.Remoting.Contexts.IContextProperty GetProperty(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetProperty_String.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.Contexts.IContextProperty)___result;
        }


        public virtual void SetProperty(System.Runtime.Remoting.Contexts.IContextProperty @prop)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prop};
            var ___result = RMSetProperty_IContextProperty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Freeze()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFreeze.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Runtime.Remoting.Messaging.IMessageSink GetServerContextSinkChain()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetServerContextSinkChain.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.Messaging.IMessageSink)___result;
        }


        public virtual System.Runtime.Remoting.Messaging.IMessageSink GetClientContextSinkChain()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetClientContextSinkChain.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.Messaging.IMessageSink)___result;
        }


        public virtual System.Runtime.Remoting.Messaging.IMessageSink CreateServerObjectSinkChain(System.MarshalByRefObject @obj, System.Boolean @forceInternalExecute)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @forceInternalExecute};
            var ___result = RMCreateServerObjectSinkChain_MarshalByRefObject_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.Messaging.IMessageSink)___result;
        }


        public virtual System.Runtime.Remoting.Messaging.IMessageSink CreateEnvoySink(System.MarshalByRefObject @serverObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@serverObject};
            var ___result = RMCreateEnvoySink_MarshalByRefObject.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.Messaging.IMessageSink)___result;
        }


        public static System.Runtime.Remoting.Contexts.Context SwitchToContext(System.Runtime.Remoting.Contexts.Context @newContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newContext};
            var ___result = RMSwitchToContext_Context.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.Contexts.Context)___result;
        }


        public static System.Runtime.Remoting.Contexts.Context CreateNewContext(System.Runtime.Remoting.Activation.IConstructionCallMessage @msg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@msg};
            var ___result = RMCreateNewContext_IConstructionCallMessage.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.Contexts.Context)___result;
        }


        public virtual void DoCallBack(System.Runtime.Remoting.Contexts.CrossContextDelegate @deleg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@deleg};
            var ___result = RMDoCallBack_CrossContextDelegate.Invoke(___genericsType, ___parameters);

            
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


        public static void FreeNamedDataSlot(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMFreeNamedDataSlot_String.Invoke(___genericsType, ___parameters);

            
        }


        public static System.LocalDataStoreSlot GetNamedDataSlot(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetNamedDataSlot_String.Invoke(___genericsType, ___parameters);

            return (System.LocalDataStoreSlot)___result;
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


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


    }
}
