using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting
{
	/// <summary>
	/// System.Runtime.Remoting.Identity
	/// </summary>
    public partial class RIdentity : RMember //
    {

		/// <summary>
		/// System.String _objectUri
		/// </summary>
		protected RField r__objectUri;
		public virtual RField R_objectUri
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
		/// System.Runtime.Remoting.Contexts.DynamicPropertyCollection _clientDynamicProperties
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RContexts.RDynamicPropertyCollection r__clientDynamicProperties;
		public virtual RSystem.RRuntime.RRemoting.RContexts.RDynamicPropertyCollection R_clientDynamicProperties
		{
			get
			{
				if(r__clientDynamicProperties == null)
				{
					r__clientDynamicProperties = new(this, "_clientDynamicProperties");
					r__clientDynamicProperties.SetBelong(this.instance);
				}
				return r__clientDynamicProperties;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.DynamicPropertyCollection _serverDynamicProperties
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RContexts.RDynamicPropertyCollection r__serverDynamicProperties;
		public virtual RSystem.RRuntime.RRemoting.RContexts.RDynamicPropertyCollection R_serverDynamicProperties
		{
			get
			{
				if(r__serverDynamicProperties == null)
				{
					r__serverDynamicProperties = new(this, "_serverDynamicProperties");
					r__serverDynamicProperties.SetBelong(this.instance);
				}
				return r__serverDynamicProperties;
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
		/// System.Boolean _disposed
		/// </summary>
		protected RField r__disposed;
		public virtual RField R_disposed
		{
			get
			{
				if(r__disposed == null)
				{
					r__disposed = new(this, "_disposed");
					r__disposed.SetBelong(this.instance);
				}
				return r__disposed;
			}
		}

		/// <summary>
		/// Boolean IsFromThisAppDomain
		/// </summary>
		protected RProperty r_IsFromThisAppDomain;
		public virtual RProperty RIsFromThisAppDomain
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
		protected RProperty r_ObjectUri;
		public virtual RProperty RObjectUri
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
		protected RProperty r_IsConnected;
		public virtual RProperty RIsConnected
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
		protected RProperty r_Disposed;
		public virtual RProperty RDisposed
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
		protected RProperty r_HasClientDynamicSinks;
		public virtual RProperty RHasClientDynamicSinks
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
		protected RProperty r_HasServerDynamicSinks;
		public virtual RProperty RHasServerDynamicSinks
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
		/// System.Runtime.Remoting.ObjRef CreateObjRef(System.Type)
		/// </summary>
		protected RMethod r_RCreateObjRef_Type;
		public virtual RMethod RCreateObjRef_Type
		{
			get
			{
				if(r_RCreateObjRef_Type == null)
				{
					r_RCreateObjRef_Type = new(this, "CreateObjRef", 0, typeof(System.Type));
					r_RCreateObjRef_Type.SetBelong(this.instance);
				}
				return r_RCreateObjRef_Type;
			}
		}

		/// <summary>
		/// Void NotifyClientDynamicSinks(Boolean, System.Runtime.Remoting.Messaging.IMessage, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RNotifyClientDynamicSinks_Boolean_IMessage_Boolean_Boolean;
		public virtual RMethod RNotifyClientDynamicSinks_Boolean_IMessage_Boolean_Boolean
		{
			get
			{
				if(r_RNotifyClientDynamicSinks_Boolean_IMessage_Boolean_Boolean == null)
				{
					r_RNotifyClientDynamicSinks_Boolean_IMessage_Boolean_Boolean = new(this, "NotifyClientDynamicSinks", 0, typeof(System.Boolean), typeof(System.Runtime.Remoting.Messaging.IMessage), typeof(System.Boolean), typeof(System.Boolean));
					r_RNotifyClientDynamicSinks_Boolean_IMessage_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RNotifyClientDynamicSinks_Boolean_IMessage_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void NotifyServerDynamicSinks(Boolean, System.Runtime.Remoting.Messaging.IMessage, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RNotifyServerDynamicSinks_Boolean_IMessage_Boolean_Boolean;
		public virtual RMethod RNotifyServerDynamicSinks_Boolean_IMessage_Boolean_Boolean
		{
			get
			{
				if(r_RNotifyServerDynamicSinks_Boolean_IMessage_Boolean_Boolean == null)
				{
					r_RNotifyServerDynamicSinks_Boolean_IMessage_Boolean_Boolean = new(this, "NotifyServerDynamicSinks", 0, typeof(System.Boolean), typeof(System.Runtime.Remoting.Messaging.IMessage), typeof(System.Boolean), typeof(System.Boolean));
					r_RNotifyServerDynamicSinks_Boolean_IMessage_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RNotifyServerDynamicSinks_Boolean_IMessage_Boolean_Boolean;
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


        public RIdentity() : base("System.Runtime.Remoting.Identity")
        {
        }

        public RIdentity(System.Object instance) : base("System.Runtime.Remoting.Identity")
		{
            SetInstance(instance);
		}

        public RIdentity(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIdentity(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Runtime.Remoting.ObjRef CreateObjRef(System.Type  @requestedType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@requestedType};
            var ___result = RCreateObjRef_Type.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjRef)___result;
        }


        public virtual void NotifyClientDynamicSinks(System.Boolean  @start, System.Runtime.Remoting.Messaging.IMessage  @req_msg, System.Boolean  @client_site, System.Boolean  @async)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @req_msg, @client_site, @async};
            var ___result = RNotifyClientDynamicSinks_Boolean_IMessage_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void NotifyServerDynamicSinks(System.Boolean  @start, System.Runtime.Remoting.Messaging.IMessage  @req_msg, System.Boolean  @client_site, System.Boolean  @async)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @req_msg, @client_site, @async};
            var ___result = RNotifyServerDynamicSinks_Boolean_IMessage_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
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