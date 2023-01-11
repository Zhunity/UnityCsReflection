using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting
{
	/// <summary>
	/// System.Runtime.Remoting.ServerIdentity
	/// </summary>
    public partial class RServerIdentity : RMember //
    {

		/// <summary>
		/// System.Type _objectType
		/// </summary>
		protected RSystem.RType r__objectType;
		public virtual RSystem.RType R_objectType
		{
			get
			{
				if(r__objectType == null)
				{
					r__objectType = new(this, "_objectType");
					r__objectType.SetBelong(this.instance);
				}
				return r__objectType;
			}
		}

		/// <summary>
		/// System.MarshalByRefObject _serverObject
		/// </summary>
		protected RSystem.RMarshalByRefObject r__serverObject;
		public virtual RSystem.RMarshalByRefObject R_serverObject
		{
			get
			{
				if(r__serverObject == null)
				{
					r__serverObject = new(this, "_serverObject");
					r__serverObject.SetBelong(this.instance);
				}
				return r__serverObject;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessageSink _serverSink
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink r__serverSink;
		public virtual RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink R_serverSink
		{
			get
			{
				if(r__serverSink == null)
				{
					r__serverSink = new(this, "_serverSink");
					r__serverSink.SetBelong(this.instance);
				}
				return r__serverSink;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.Context _context
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RContexts.RContext r__context;
		public virtual RSystem.RRuntime.RRemoting.RContexts.RContext R_context
		{
			get
			{
				if(r__context == null)
				{
					r__context = new(this, "_context");
					r__context.SetBelong(this.instance);
				}
				return r__context;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Lifetime.Lease _lease
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RLifetime.RLease r__lease;
		public virtual RSystem.RRuntime.RRemoting.RLifetime.RLease R_lease
		{
			get
			{
				if(r__lease == null)
				{
					r__lease = new(this, "_lease");
					r__lease.SetBelong(this.instance);
				}
				return r__lease;
			}
		}

		/// <summary>
		/// System.String _objectUri
		/// </summary>
		protected RSystem.RString r__objectUri;
		public virtual RSystem.RString R_objectUri
		{
			get
			{
				if(r__objectUri == null)
				{
					r__objectUri = new(this, "_objectUri");
					r__objectUri.SetBelong(this.instance);
				}
				return r__objectUri;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessageSink _channelSink
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink r__channelSink;
		public virtual RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink R_channelSink
		{
			get
			{
				if(r__channelSink == null)
				{
					r__channelSink = new(this, "_channelSink");
					r__channelSink.SetBelong(this.instance);
				}
				return r__channelSink;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessageSink _envoySink
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink r__envoySink;
		public virtual RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink R_envoySink
		{
			get
			{
				if(r__envoySink == null)
				{
					r__envoySink = new(this, "_envoySink");
					r__envoySink.SetBelong(this.instance);
				}
				return r__envoySink;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjRef _objRef
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RObjRef r__objRef;
		public virtual RSystem.RRuntime.RRemoting.RObjRef R_objRef
		{
			get
			{
				if(r__objRef == null)
				{
					r__objRef = new(this, "_objRef");
					r__objRef.SetBelong(this.instance);
				}
				return r__objRef;
			}
		}

		/// <summary>
		/// System.Type ObjectType
		/// </summary>
		protected RSystem.RType r_ObjectType;
		public virtual RSystem.RType RObjectType
		{
			get
			{
				if(r_ObjectType == null)
				{
					r_ObjectType = new(this, "ObjectType", -1);
					r_ObjectType.SetBelong(this.instance);
				}
				return r_ObjectType;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Lifetime.Lease Lease
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RLifetime.RLease r_Lease;
		public virtual RSystem.RRuntime.RRemoting.RLifetime.RLease RLease
		{
			get
			{
				if(r_Lease == null)
				{
					r_Lease = new(this, "Lease", -1);
					r_Lease.SetBelong(this.instance);
				}
				return r_Lease;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.Context Context
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RContexts.RContext r_Context;
		public virtual RSystem.RRuntime.RRemoting.RContexts.RContext RContext
		{
			get
			{
				if(r_Context == null)
				{
					r_Context = new(this, "Context", -1);
					r_Context.SetBelong(this.instance);
				}
				return r_Context;
			}
		}

		/// <summary>
		/// Boolean IsFromThisAppDomain
		/// </summary>
		protected RSystem.RBoolean r_IsFromThisAppDomain;
		public virtual RSystem.RBoolean RIsFromThisAppDomain
		{
			get
			{
				if(r_IsFromThisAppDomain == null)
				{
					r_IsFromThisAppDomain = new(this, "IsFromThisAppDomain", -1);
					r_IsFromThisAppDomain.SetBelong(this.instance);
				}
				return r_IsFromThisAppDomain;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessageSink ChannelSink
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink r_ChannelSink;
		public virtual RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink RChannelSink
		{
			get
			{
				if(r_ChannelSink == null)
				{
					r_ChannelSink = new(this, "ChannelSink", -1);
					r_ChannelSink.SetBelong(this.instance);
				}
				return r_ChannelSink;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessageSink EnvoySink
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink r_EnvoySink;
		public virtual RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink REnvoySink
		{
			get
			{
				if(r_EnvoySink == null)
				{
					r_EnvoySink = new(this, "EnvoySink", -1);
					r_EnvoySink.SetBelong(this.instance);
				}
				return r_EnvoySink;
			}
		}

		/// <summary>
		/// System.String ObjectUri
		/// </summary>
		protected RSystem.RString r_ObjectUri;
		public virtual RSystem.RString RObjectUri
		{
			get
			{
				if(r_ObjectUri == null)
				{
					r_ObjectUri = new(this, "ObjectUri", -1);
					r_ObjectUri.SetBelong(this.instance);
				}
				return r_ObjectUri;
			}
		}

		/// <summary>
		/// Boolean IsConnected
		/// </summary>
		protected RSystem.RBoolean r_IsConnected;
		public virtual RSystem.RBoolean RIsConnected
		{
			get
			{
				if(r_IsConnected == null)
				{
					r_IsConnected = new(this, "IsConnected", -1);
					r_IsConnected.SetBelong(this.instance);
				}
				return r_IsConnected;
			}
		}

		/// <summary>
		/// Boolean Disposed
		/// </summary>
		protected RSystem.RBoolean r_Disposed;
		public virtual RSystem.RBoolean RDisposed
		{
			get
			{
				if(r_Disposed == null)
				{
					r_Disposed = new(this, "Disposed", -1);
					r_Disposed.SetBelong(this.instance);
				}
				return r_Disposed;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.DynamicPropertyCollection ClientDynamicProperties
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RContexts.RDynamicPropertyCollection r_ClientDynamicProperties;
		public virtual RSystem.RRuntime.RRemoting.RContexts.RDynamicPropertyCollection RClientDynamicProperties
		{
			get
			{
				if(r_ClientDynamicProperties == null)
				{
					r_ClientDynamicProperties = new(this, "ClientDynamicProperties", -1);
					r_ClientDynamicProperties.SetBelong(this.instance);
				}
				return r_ClientDynamicProperties;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.DynamicPropertyCollection ServerDynamicProperties
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RContexts.RDynamicPropertyCollection r_ServerDynamicProperties;
		public virtual RSystem.RRuntime.RRemoting.RContexts.RDynamicPropertyCollection RServerDynamicProperties
		{
			get
			{
				if(r_ServerDynamicProperties == null)
				{
					r_ServerDynamicProperties = new(this, "ServerDynamicProperties", -1);
					r_ServerDynamicProperties.SetBelong(this.instance);
				}
				return r_ServerDynamicProperties;
			}
		}

		/// <summary>
		/// Boolean HasClientDynamicSinks
		/// </summary>
		protected RSystem.RBoolean r_HasClientDynamicSinks;
		public virtual RSystem.RBoolean RHasClientDynamicSinks
		{
			get
			{
				if(r_HasClientDynamicSinks == null)
				{
					r_HasClientDynamicSinks = new(this, "HasClientDynamicSinks", -1);
					r_HasClientDynamicSinks.SetBelong(this.instance);
				}
				return r_HasClientDynamicSinks;
			}
		}

		/// <summary>
		/// Boolean HasServerDynamicSinks
		/// </summary>
		protected RSystem.RBoolean r_HasServerDynamicSinks;
		public virtual RSystem.RBoolean RHasServerDynamicSinks
		{
			get
			{
				if(r_HasServerDynamicSinks == null)
				{
					r_HasServerDynamicSinks = new(this, "HasServerDynamicSinks", -1);
					r_HasServerDynamicSinks.SetBelong(this.instance);
				}
				return r_HasServerDynamicSinks;
			}
		}

		/// <summary>
		/// Void StartTrackingLifetime(System.Runtime.Remoting.Lifetime.ILease)
		/// </summary>
		protected RMethod r_StartTrackingLifetime_ILease;
		public virtual RMethod RStartTrackingLifetime_ILease
		{
			get
			{
				if(r_StartTrackingLifetime_ILease == null)
				{
					r_StartTrackingLifetime_ILease = new(this, "StartTrackingLifetime", 0, typeof(System.Runtime.Remoting.Lifetime.ILease));
					r_StartTrackingLifetime_ILease.SetBelong(this.instance);
				}
				return r_StartTrackingLifetime_ILease;
			}
		}

		/// <summary>
		/// Void OnLifetimeExpired()
		/// </summary>
		protected RMethod r_OnLifetimeExpired;
		public virtual RMethod ROnLifetimeExpired
		{
			get
			{
				if(r_OnLifetimeExpired == null)
				{
					r_OnLifetimeExpired = new(this, "OnLifetimeExpired", 0);
					r_OnLifetimeExpired.SetBelong(this.instance);
				}
				return r_OnLifetimeExpired;
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
		/// Void AttachServerObject(System.MarshalByRefObject, System.Runtime.Remoting.Contexts.Context)
		/// </summary>
		protected RMethod r_AttachServerObject_MarshalByRefObject_Context;
		public virtual RMethod RAttachServerObject_MarshalByRefObject_Context
		{
			get
			{
				if(r_AttachServerObject_MarshalByRefObject_Context == null)
				{
					r_AttachServerObject_MarshalByRefObject_Context = new(this, "AttachServerObject", 0, typeof(System.MarshalByRefObject), typeof(System.Runtime.Remoting.Contexts.Context));
					r_AttachServerObject_MarshalByRefObject_Context.SetBelong(this.instance);
				}
				return r_AttachServerObject_MarshalByRefObject_Context;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessage SyncObjectProcessMessage(System.Runtime.Remoting.Messaging.IMessage)
		/// </summary>
		protected RMethod r_SyncObjectProcessMessage_IMessage;
		public virtual RMethod RSyncObjectProcessMessage_IMessage
		{
			get
			{
				if(r_SyncObjectProcessMessage_IMessage == null)
				{
					r_SyncObjectProcessMessage_IMessage = new(this, "SyncObjectProcessMessage", 0, typeof(System.Runtime.Remoting.Messaging.IMessage));
					r_SyncObjectProcessMessage_IMessage.SetBelong(this.instance);
				}
				return r_SyncObjectProcessMessage_IMessage;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessageCtrl AsyncObjectProcessMessage(System.Runtime.Remoting.Messaging.IMessage, System.Runtime.Remoting.Messaging.IMessageSink)
		/// </summary>
		protected RMethod r_AsyncObjectProcessMessage_IMessage_IMessageSink;
		public virtual RMethod RAsyncObjectProcessMessage_IMessage_IMessageSink
		{
			get
			{
				if(r_AsyncObjectProcessMessage_IMessage_IMessageSink == null)
				{
					r_AsyncObjectProcessMessage_IMessage_IMessageSink = new(this, "AsyncObjectProcessMessage", 0, typeof(System.Runtime.Remoting.Messaging.IMessage), typeof(System.Runtime.Remoting.Messaging.IMessageSink));
					r_AsyncObjectProcessMessage_IMessage_IMessageSink.SetBelong(this.instance);
				}
				return r_AsyncObjectProcessMessage_IMessage_IMessageSink;
			}
		}

		/// <summary>
		/// Void DisposeServerObject()
		/// </summary>
		protected RMethod r_DisposeServerObject;
		public virtual RMethod RDisposeServerObject
		{
			get
			{
				if(r_DisposeServerObject == null)
				{
					r_DisposeServerObject = new(this, "DisposeServerObject", 0);
					r_DisposeServerObject.SetBelong(this.instance);
				}
				return r_DisposeServerObject;
			}
		}

		/// <summary>
		/// Void NotifyClientDynamicSinks(Boolean, System.Runtime.Remoting.Messaging.IMessage, Boolean, Boolean)
		/// </summary>
		protected RMethod r_NotifyClientDynamicSinks_Boolean_IMessage_Boolean_Boolean;
		public virtual RMethod RNotifyClientDynamicSinks_Boolean_IMessage_Boolean_Boolean
		{
			get
			{
				if(r_NotifyClientDynamicSinks_Boolean_IMessage_Boolean_Boolean == null)
				{
					r_NotifyClientDynamicSinks_Boolean_IMessage_Boolean_Boolean = new(this, "NotifyClientDynamicSinks", 0, typeof(System.Boolean), typeof(System.Runtime.Remoting.Messaging.IMessage), typeof(System.Boolean), typeof(System.Boolean));
					r_NotifyClientDynamicSinks_Boolean_IMessage_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_NotifyClientDynamicSinks_Boolean_IMessage_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void NotifyServerDynamicSinks(Boolean, System.Runtime.Remoting.Messaging.IMessage, Boolean, Boolean)
		/// </summary>
		protected RMethod r_NotifyServerDynamicSinks_Boolean_IMessage_Boolean_Boolean;
		public virtual RMethod RNotifyServerDynamicSinks_Boolean_IMessage_Boolean_Boolean
		{
			get
			{
				if(r_NotifyServerDynamicSinks_Boolean_IMessage_Boolean_Boolean == null)
				{
					r_NotifyServerDynamicSinks_Boolean_IMessage_Boolean_Boolean = new(this, "NotifyServerDynamicSinks", 0, typeof(System.Boolean), typeof(System.Runtime.Remoting.Messaging.IMessage), typeof(System.Boolean), typeof(System.Boolean));
					r_NotifyServerDynamicSinks_Boolean_IMessage_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_NotifyServerDynamicSinks_Boolean_IMessage_Boolean_Boolean;
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


        public RServerIdentity() : base("System.Runtime.Remoting.ServerIdentity")
        {
        }

        public RServerIdentity(System.Object instance) : base("System.Runtime.Remoting.ServerIdentity")
		{
            SetInstance(instance);
		}

        public RServerIdentity(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RServerIdentity(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void StartTrackingLifetime(System.Runtime.Remoting.Lifetime.ILease @lease)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lease};
            var ___result = RStartTrackingLifetime_ILease.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLifetimeExpired()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnLifetimeExpired.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Runtime.Remoting.ObjRef CreateObjRef(System.Type @requestedType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@requestedType};
            var ___result = RCreateObjRef_Type.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjRef)___result;
        }


        public virtual void AttachServerObject(System.MarshalByRefObject @serverObject, System.Runtime.Remoting.Contexts.Context @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@serverObject, @context};
            var ___result = RAttachServerObject_MarshalByRefObject_Context.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Runtime.Remoting.Messaging.IMessage SyncObjectProcessMessage(System.Runtime.Remoting.Messaging.IMessage @msg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@msg};
            var ___result = RSyncObjectProcessMessage_IMessage.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.Messaging.IMessage)___result;
        }


        public virtual System.Runtime.Remoting.Messaging.IMessageCtrl AsyncObjectProcessMessage(System.Runtime.Remoting.Messaging.IMessage @msg, System.Runtime.Remoting.Messaging.IMessageSink @replySink)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@msg, @replySink};
            var ___result = RAsyncObjectProcessMessage_IMessage_IMessageSink.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.Messaging.IMessageCtrl)___result;
        }


        public virtual void DisposeServerObject()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDisposeServerObject.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void NotifyClientDynamicSinks(System.Boolean @start, System.Runtime.Remoting.Messaging.IMessage @req_msg, System.Boolean @client_site, System.Boolean @async)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @req_msg, @client_site, @async};
            var ___result = RNotifyClientDynamicSinks_Boolean_IMessage_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void NotifyServerDynamicSinks(System.Boolean @start, System.Runtime.Remoting.Messaging.IMessage @req_msg, System.Boolean @client_site, System.Boolean @async)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @req_msg, @client_site, @async};
            var ___result = RNotifyServerDynamicSinks_Boolean_IMessage_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
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
