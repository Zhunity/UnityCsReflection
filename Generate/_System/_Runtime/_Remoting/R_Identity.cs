
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.Runtime.Remoting.Identity
	/// </summary>
    public partial class RIdentity : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Runtime.Remoting.Identity");
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
		/// System.Runtime.Remoting.Contexts.DynamicPropertyCollection _clientDynamicProperties
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RContexts.RDynamicPropertyCollection r_F_clientDynamicProperties;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RContexts.RDynamicPropertyCollection RF_clientDynamicProperties
		{
			get
			{
				if(r_F_clientDynamicProperties == null)
				{
					r_F_clientDynamicProperties = new(this, "_clientDynamicProperties");
				}
				return r_F_clientDynamicProperties;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.DynamicPropertyCollection _serverDynamicProperties
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RContexts.RDynamicPropertyCollection r_F_serverDynamicProperties;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RContexts.RDynamicPropertyCollection RF_serverDynamicProperties
		{
			get
			{
				if(r_F_serverDynamicProperties == null)
				{
					r_F_serverDynamicProperties = new(this, "_serverDynamicProperties");
				}
				return r_F_serverDynamicProperties;
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
		/// System.Boolean _disposed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F_disposed;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF_disposed
		{
			get
			{
				if(r_F_disposed == null)
				{
					r_F_disposed = new(this, "_disposed");
				}
				return r_F_disposed;
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


        public virtual System.Runtime.Remoting.ObjRef CreateObjRef(System.Type @requestedType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@requestedType};
            var ___result = RMCreateObjRef_Type.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Runtime.Remoting.ObjRef>(___result);
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
