
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.Runtime.Remoting.ServerIdentity
	/// </summary>
    public partial class RServerIdentity : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Runtime.Remoting.ServerIdentity");
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


		/// <summary>
		/// System.Type _objectType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_F_objectType;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RF_objectType
		{
			get
			{
				if(r_F_objectType == null)
				{
					r_F_objectType = new(this, "_objectType");
				}
				return r_F_objectType;
			}
		}

		/// <summary>
		/// System.MarshalByRefObject _serverObject
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RMarshalByRefObject r_F_serverObject;
		public virtual Hvak.Editor.Refleaction.RSystem.RMarshalByRefObject RF_serverObject
		{
			get
			{
				if(r_F_serverObject == null)
				{
					r_F_serverObject = new(this, "_serverObject");
				}
				return r_F_serverObject;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessageSink _serverSink
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink r_F_serverSink;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink RF_serverSink
		{
			get
			{
				if(r_F_serverSink == null)
				{
					r_F_serverSink = new(this, "_serverSink");
				}
				return r_F_serverSink;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.Context _context
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RContexts.RContext r_F_context;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RContexts.RContext RF_context
		{
			get
			{
				if(r_F_context == null)
				{
					r_F_context = new(this, "_context");
				}
				return r_F_context;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Lifetime.Lease _lease
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RLifetime.RLease r_F_lease;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RLifetime.RLease RF_lease
		{
			get
			{
				if(r_F_lease == null)
				{
					r_F_lease = new(this, "_lease");
				}
				return r_F_lease;
			}
		}

		/// <summary>
		/// System.String _objectUri
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F_objectUri;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF_objectUri
		{
			get
			{
				if(r_F_objectUri == null)
				{
					r_F_objectUri = new(this, "_objectUri");
				}
				return r_F_objectUri;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessageSink _channelSink
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink r_F_channelSink;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink RF_channelSink
		{
			get
			{
				if(r_F_channelSink == null)
				{
					r_F_channelSink = new(this, "_channelSink");
				}
				return r_F_channelSink;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessageSink _envoySink
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink r_F_envoySink;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink RF_envoySink
		{
			get
			{
				if(r_F_envoySink == null)
				{
					r_F_envoySink = new(this, "_envoySink");
				}
				return r_F_envoySink;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjRef _objRef
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RObjRef r_F_objRef;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RObjRef RF_objRef
		{
			get
			{
				if(r_F_objRef == null)
				{
					r_F_objRef = new(this, "_objRef");
				}
				return r_F_objRef;
			}
		}

		/// <summary>
		/// System.Type ObjectType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_PObjectType;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RPObjectType
		{
			get
			{
				if(r_PObjectType == null)
				{
					r_PObjectType = new(this, "ObjectType", -1);
				}
				return r_PObjectType;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Lifetime.Lease Lease
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RLifetime.RLease r_PLease;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RLifetime.RLease RPLease
		{
			get
			{
				if(r_PLease == null)
				{
					r_PLease = new(this, "Lease", -1);
				}
				return r_PLease;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.Context Context
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RContexts.RContext r_PContext;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RContexts.RContext RPContext
		{
			get
			{
				if(r_PContext == null)
				{
					r_PContext = new(this, "Context", -1);
				}
				return r_PContext;
			}
		}

		/// <summary>
		/// Boolean IsFromThisAppDomain
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsFromThisAppDomain;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsFromThisAppDomain
		{
			get
			{
				if(r_PIsFromThisAppDomain == null)
				{
					r_PIsFromThisAppDomain = new(this, "IsFromThisAppDomain", -1);
				}
				return r_PIsFromThisAppDomain;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessageSink ChannelSink
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink r_PChannelSink;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink RPChannelSink
		{
			get
			{
				if(r_PChannelSink == null)
				{
					r_PChannelSink = new(this, "ChannelSink", -1);
				}
				return r_PChannelSink;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessageSink EnvoySink
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink r_PEnvoySink;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink RPEnvoySink
		{
			get
			{
				if(r_PEnvoySink == null)
				{
					r_PEnvoySink = new(this, "EnvoySink", -1);
				}
				return r_PEnvoySink;
			}
		}

		/// <summary>
		/// System.String ObjectUri
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PObjectUri;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPObjectUri
		{
			get
			{
				if(r_PObjectUri == null)
				{
					r_PObjectUri = new(this, "ObjectUri", -1);
				}
				return r_PObjectUri;
			}
		}

		/// <summary>
		/// Boolean IsConnected
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsConnected;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsConnected
		{
			get
			{
				if(r_PIsConnected == null)
				{
					r_PIsConnected = new(this, "IsConnected", -1);
				}
				return r_PIsConnected;
			}
		}

		/// <summary>
		/// Boolean Disposed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PDisposed;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPDisposed
		{
			get
			{
				if(r_PDisposed == null)
				{
					r_PDisposed = new(this, "Disposed", -1);
				}
				return r_PDisposed;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.DynamicPropertyCollection ClientDynamicProperties
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RContexts.RDynamicPropertyCollection r_PClientDynamicProperties;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RContexts.RDynamicPropertyCollection RPClientDynamicProperties
		{
			get
			{
				if(r_PClientDynamicProperties == null)
				{
					r_PClientDynamicProperties = new(this, "ClientDynamicProperties", -1);
				}
				return r_PClientDynamicProperties;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.DynamicPropertyCollection ServerDynamicProperties
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RContexts.RDynamicPropertyCollection r_PServerDynamicProperties;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RContexts.RDynamicPropertyCollection RPServerDynamicProperties
		{
			get
			{
				if(r_PServerDynamicProperties == null)
				{
					r_PServerDynamicProperties = new(this, "ServerDynamicProperties", -1);
				}
				return r_PServerDynamicProperties;
			}
		}

		/// <summary>
		/// Boolean HasClientDynamicSinks
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PHasClientDynamicSinks;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPHasClientDynamicSinks
		{
			get
			{
				if(r_PHasClientDynamicSinks == null)
				{
					r_PHasClientDynamicSinks = new(this, "HasClientDynamicSinks", -1);
				}
				return r_PHasClientDynamicSinks;
			}
		}

		/// <summary>
		/// Boolean HasServerDynamicSinks
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PHasServerDynamicSinks;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPHasServerDynamicSinks
		{
			get
			{
				if(r_PHasServerDynamicSinks == null)
				{
					r_PHasServerDynamicSinks = new(this, "HasServerDynamicSinks", -1);
				}
				return r_PHasServerDynamicSinks;
			}
		}

		/// <summary>
		/// Void StartTrackingLifetime(System.Runtime.Remoting.Lifetime.ILease)
		/// </summary>
		protected RMethod r_MStartTrackingLifetime_ILease;
		public virtual RMethod RMStartTrackingLifetime_ILease
		{
			get
			{
				if(r_MStartTrackingLifetime_ILease == null)
				{
					r_MStartTrackingLifetime_ILease = new(this, "StartTrackingLifetime", 0, typeof(System.Runtime.Remoting.Lifetime.ILease));
				}
				return r_MStartTrackingLifetime_ILease;
			}
		}

		/// <summary>
		/// Void OnLifetimeExpired()
		/// </summary>
		protected RMethod r_MOnLifetimeExpired;
		public virtual RMethod RMOnLifetimeExpired
		{
			get
			{
				if(r_MOnLifetimeExpired == null)
				{
					r_MOnLifetimeExpired = new(this, "OnLifetimeExpired", 0);
				}
				return r_MOnLifetimeExpired;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjRef CreateObjRef(System.Type)
		/// </summary>
		protected RMethod r_MCreateObjRef_Type;
		public virtual RMethod RMCreateObjRef_Type
		{
			get
			{
				if(r_MCreateObjRef_Type == null)
				{
					r_MCreateObjRef_Type = new(this, "CreateObjRef", 0, typeof(System.Type));
				}
				return r_MCreateObjRef_Type;
			}
		}

		/// <summary>
		/// Void AttachServerObject(System.MarshalByRefObject, System.Runtime.Remoting.Contexts.Context)
		/// </summary>
		protected RMethod r_MAttachServerObject_MarshalByRefObject_Context;
		public virtual RMethod RMAttachServerObject_MarshalByRefObject_Context
		{
			get
			{
				if(r_MAttachServerObject_MarshalByRefObject_Context == null)
				{
					r_MAttachServerObject_MarshalByRefObject_Context = new(this, "AttachServerObject", 0, typeof(System.MarshalByRefObject), typeof(System.Runtime.Remoting.Contexts.Context));
				}
				return r_MAttachServerObject_MarshalByRefObject_Context;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessage SyncObjectProcessMessage(System.Runtime.Remoting.Messaging.IMessage)
		/// </summary>
		protected RMethod r_MSyncObjectProcessMessage_IMessage;
		public virtual RMethod RMSyncObjectProcessMessage_IMessage
		{
			get
			{
				if(r_MSyncObjectProcessMessage_IMessage == null)
				{
					r_MSyncObjectProcessMessage_IMessage = new(this, "SyncObjectProcessMessage", 0, typeof(System.Runtime.Remoting.Messaging.IMessage));
				}
				return r_MSyncObjectProcessMessage_IMessage;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessageCtrl AsyncObjectProcessMessage(System.Runtime.Remoting.Messaging.IMessage, System.Runtime.Remoting.Messaging.IMessageSink)
		/// </summary>
		protected RMethod r_MAsyncObjectProcessMessage_IMessage_IMessageSink;
		public virtual RMethod RMAsyncObjectProcessMessage_IMessage_IMessageSink
		{
			get
			{
				if(r_MAsyncObjectProcessMessage_IMessage_IMessageSink == null)
				{
					r_MAsyncObjectProcessMessage_IMessage_IMessageSink = new(this, "AsyncObjectProcessMessage", 0, typeof(System.Runtime.Remoting.Messaging.IMessage), typeof(System.Runtime.Remoting.Messaging.IMessageSink));
				}
				return r_MAsyncObjectProcessMessage_IMessage_IMessageSink;
			}
		}

		/// <summary>
		/// Void DisposeServerObject()
		/// </summary>
		protected RMethod r_MDisposeServerObject;
		public virtual RMethod RMDisposeServerObject
		{
			get
			{
				if(r_MDisposeServerObject == null)
				{
					r_MDisposeServerObject = new(this, "DisposeServerObject", 0);
				}
				return r_MDisposeServerObject;
			}
		}

		/// <summary>
		/// Void NotifyClientDynamicSinks(Boolean, System.Runtime.Remoting.Messaging.IMessage, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MNotifyClientDynamicSinks_Boolean_IMessage_Boolean_Boolean;
		public virtual RMethod RMNotifyClientDynamicSinks_Boolean_IMessage_Boolean_Boolean
		{
			get
			{
				if(r_MNotifyClientDynamicSinks_Boolean_IMessage_Boolean_Boolean == null)
				{
					r_MNotifyClientDynamicSinks_Boolean_IMessage_Boolean_Boolean = new(this, "NotifyClientDynamicSinks", 0, typeof(System.Boolean), typeof(System.Runtime.Remoting.Messaging.IMessage), typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MNotifyClientDynamicSinks_Boolean_IMessage_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void NotifyServerDynamicSinks(Boolean, System.Runtime.Remoting.Messaging.IMessage, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MNotifyServerDynamicSinks_Boolean_IMessage_Boolean_Boolean;
		public virtual RMethod RMNotifyServerDynamicSinks_Boolean_IMessage_Boolean_Boolean
		{
			get
			{
				if(r_MNotifyServerDynamicSinks_Boolean_IMessage_Boolean_Boolean == null)
				{
					r_MNotifyServerDynamicSinks_Boolean_IMessage_Boolean_Boolean = new(this, "NotifyServerDynamicSinks", 0, typeof(System.Boolean), typeof(System.Runtime.Remoting.Messaging.IMessage), typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MNotifyServerDynamicSinks_Boolean_IMessage_Boolean_Boolean;
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


        public virtual void StartTrackingLifetime(System.Runtime.Remoting.Lifetime.ILease @lease)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lease};
            var ___result = RMStartTrackingLifetime_ILease.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLifetimeExpired()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnLifetimeExpired.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Runtime.Remoting.ObjRef CreateObjRef(System.Type @requestedType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@requestedType};
            var ___result = RMCreateObjRef_Type.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Runtime.Remoting.ObjRef>(___result);
        }


        public virtual void AttachServerObject(System.MarshalByRefObject @serverObject, System.Runtime.Remoting.Contexts.Context @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@serverObject, @context};
            var ___result = RMAttachServerObject_MarshalByRefObject_Context.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Runtime.Remoting.Messaging.IMessage SyncObjectProcessMessage(System.Runtime.Remoting.Messaging.IMessage @msg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@msg};
            var ___result = RMSyncObjectProcessMessage_IMessage.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Runtime.Remoting.Messaging.IMessage>(___result);
        }


        public virtual System.Runtime.Remoting.Messaging.IMessageCtrl AsyncObjectProcessMessage(System.Runtime.Remoting.Messaging.IMessage @msg, System.Runtime.Remoting.Messaging.IMessageSink @replySink)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@msg, @replySink};
            var ___result = RMAsyncObjectProcessMessage_IMessage_IMessageSink.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Runtime.Remoting.Messaging.IMessageCtrl>(___result);
        }


        public virtual void DisposeServerObject()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDisposeServerObject.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void NotifyClientDynamicSinks(System.Boolean @start, System.Runtime.Remoting.Messaging.IMessage @req_msg, System.Boolean @client_site, System.Boolean @async)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @req_msg, @client_site, @async};
            var ___result = RMNotifyClientDynamicSinks_Boolean_IMessage_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void NotifyServerDynamicSinks(System.Boolean @start, System.Runtime.Remoting.Messaging.IMessage @req_msg, System.Boolean @client_site, System.Boolean @async)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @req_msg, @client_site, @async};
            var ___result = RMNotifyServerDynamicSinks_Boolean_IMessage_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
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
