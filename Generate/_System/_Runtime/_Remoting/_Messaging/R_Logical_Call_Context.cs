
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging
{
	/// <summary>
	/// System.Runtime.Remoting.Messaging.LogicalCallContext
	/// </summary>
    public partial class RLogicalCallContext : RMember //
    {

		/// <summary>
		/// System.Type s_callContextType
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RType r_Fs_callContextType;
		public static Hvak.Editor.Refleaction.RSystem.RType RFs_callContextType
		{
			get
			{
				if(r_Fs_callContextType == null)
				{
					r_Fs_callContextType = new(typeof(System.Runtime.Remoting.Messaging.LogicalCallContext), "s_callContextType");
				}
				return r_Fs_callContextType;
			}
		}

		/// <summary>
		/// System.String s_CorrelationMgrSlotName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fs_CorrelationMgrSlotName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFs_CorrelationMgrSlotName
		{
			get
			{
				if(r_Fs_CorrelationMgrSlotName == null)
				{
					r_Fs_CorrelationMgrSlotName = new(typeof(System.Runtime.Remoting.Messaging.LogicalCallContext), "s_CorrelationMgrSlotName");
				}
				return r_Fs_CorrelationMgrSlotName;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable m_Datastore
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RHashtable r_Fm_Datastore;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RHashtable RFm_Datastore
		{
			get
			{
				if(r_Fm_Datastore == null)
				{
					r_Fm_Datastore = new(this, "m_Datastore");
				}
				return r_Fm_Datastore;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.CallContextRemotingData m_RemotingData
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RCallContextRemotingData r_Fm_RemotingData;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RCallContextRemotingData RFm_RemotingData
		{
			get
			{
				if(r_Fm_RemotingData == null)
				{
					r_Fm_RemotingData = new(this, "m_RemotingData");
				}
				return r_Fm_RemotingData;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.CallContextSecurityData m_SecurityData
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RCallContextSecurityData r_Fm_SecurityData;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RCallContextSecurityData RFm_SecurityData
		{
			get
			{
				if(r_Fm_SecurityData == null)
				{
					r_Fm_SecurityData = new(this, "m_SecurityData");
				}
				return r_Fm_SecurityData;
			}
		}

		/// <summary>
		/// System.Object m_HostContext
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_Fm_HostContext;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RFm_HostContext
		{
			get
			{
				if(r_Fm_HostContext == null)
				{
					r_Fm_HostContext = new(this, "m_HostContext");
				}
				return r_Fm_HostContext;
			}
		}

		/// <summary>
		/// System.Boolean m_IsCorrelationMgr
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_IsCorrelationMgr;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_IsCorrelationMgr
		{
			get
			{
				if(r_Fm_IsCorrelationMgr == null)
				{
					r_Fm_IsCorrelationMgr = new(this, "m_IsCorrelationMgr");
				}
				return r_Fm_IsCorrelationMgr;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.Header[] _sendHeaders
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RHeader> r_F_sendHeaders;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RHeader> RF_sendHeaders
		{
			get
			{
				if(r_F_sendHeaders == null)
				{
					r_F_sendHeaders = new(this, "_sendHeaders");
				}
				return r_F_sendHeaders;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.Header[] _recvHeaders
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RHeader> r_F_recvHeaders;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RHeader> RF_recvHeaders
		{
			get
			{
				if(r_F_recvHeaders == null)
				{
					r_F_recvHeaders = new(this, "_recvHeaders");
				}
				return r_F_recvHeaders;
			}
		}

		/// <summary>
		/// Boolean HasInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PHasInfo;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPHasInfo
		{
			get
			{
				if(r_PHasInfo == null)
				{
					r_PHasInfo = new(this, "HasInfo", -1);
				}
				return r_PHasInfo;
			}
		}

		/// <summary>
		/// Boolean HasUserData
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PHasUserData;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPHasUserData
		{
			get
			{
				if(r_PHasUserData == null)
				{
					r_PHasUserData = new(this, "HasUserData", -1);
				}
				return r_PHasUserData;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.CallContextRemotingData RemotingData
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RCallContextRemotingData r_PRemotingData;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RCallContextRemotingData RPRemotingData
		{
			get
			{
				if(r_PRemotingData == null)
				{
					r_PRemotingData = new(this, "RemotingData", -1);
				}
				return r_PRemotingData;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.CallContextSecurityData SecurityData
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RCallContextSecurityData r_PSecurityData;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RCallContextSecurityData RPSecurityData
		{
			get
			{
				if(r_PSecurityData == null)
				{
					r_PSecurityData = new(this, "SecurityData", -1);
				}
				return r_PSecurityData;
			}
		}

		/// <summary>
		/// System.Object HostContext
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PHostContext;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPHostContext
		{
			get
			{
				if(r_PHostContext == null)
				{
					r_PHostContext = new(this, "HostContext", -1);
				}
				return r_PHostContext;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable Datastore
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RHashtable r_PDatastore;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RHashtable RPDatastore
		{
			get
			{
				if(r_PDatastore == null)
				{
					r_PDatastore = new(this, "Datastore", -1);
				}
				return r_PDatastore;
			}
		}

		/// <summary>
		/// System.Security.Principal.IPrincipal Principal
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RIPrincipal r_PPrincipal;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RIPrincipal RPPrincipal
		{
			get
			{
				if(r_PPrincipal == null)
				{
					r_PPrincipal = new(this, "Principal", -1);
				}
				return r_PPrincipal;
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
		/// System.Object Clone()
		/// </summary>
		protected RMethod r_MClone;
		public virtual RMethod RMClone
		{
			get
			{
				if(r_MClone == null)
				{
					r_MClone = new(this, "Clone", 0);
				}
				return r_MClone;
			}
		}

		/// <summary>
		/// Void Merge(System.Runtime.Remoting.Messaging.LogicalCallContext)
		/// </summary>
		protected RMethod r_MMerge_LogicalCallContext;
		public virtual RMethod RMMerge_LogicalCallContext
		{
			get
			{
				if(r_MMerge_LogicalCallContext == null)
				{
					r_MMerge_LogicalCallContext = new(this, "Merge", 0, typeof(System.Runtime.Remoting.Messaging.LogicalCallContext));
				}
				return r_MMerge_LogicalCallContext;
			}
		}

		/// <summary>
		/// Void FreeNamedDataSlot(System.String)
		/// </summary>
		protected RMethod r_MFreeNamedDataSlot_String;
		public virtual RMethod RMFreeNamedDataSlot_String
		{
			get
			{
				if(r_MFreeNamedDataSlot_String == null)
				{
					r_MFreeNamedDataSlot_String = new(this, "FreeNamedDataSlot", 0, typeof(System.String));
				}
				return r_MFreeNamedDataSlot_String;
			}
		}

		/// <summary>
		/// System.Object GetData(System.String)
		/// </summary>
		protected RMethod r_MGetData_String;
		public virtual RMethod RMGetData_String
		{
			get
			{
				if(r_MGetData_String == null)
				{
					r_MGetData_String = new(this, "GetData", 0, typeof(System.String));
				}
				return r_MGetData_String;
			}
		}

		/// <summary>
		/// Void SetData(System.String, System.Object)
		/// </summary>
		protected RMethod r_MSetData_String_Object;
		public virtual RMethod RMSetData_String_Object
		{
			get
			{
				if(r_MSetData_String_Object == null)
				{
					r_MSetData_String_Object = new(this, "SetData", 0, typeof(System.String), typeof(System.Object));
				}
				return r_MSetData_String_Object;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.Header[] InternalGetOutgoingHeaders()
		/// </summary>
		protected RMethod r_MInternalGetOutgoingHeaders;
		public virtual RMethod RMInternalGetOutgoingHeaders
		{
			get
			{
				if(r_MInternalGetOutgoingHeaders == null)
				{
					r_MInternalGetOutgoingHeaders = new(this, "InternalGetOutgoingHeaders", 0);
				}
				return r_MInternalGetOutgoingHeaders;
			}
		}

		/// <summary>
		/// Void InternalSetHeaders(System.Runtime.Remoting.Messaging.Header[])
		/// </summary>
		protected RMethod r_MInternalSetHeaders_HeaderArray;
		public virtual RMethod RMInternalSetHeaders_HeaderArray
		{
			get
			{
				if(r_MInternalSetHeaders_HeaderArray == null)
				{
					r_MInternalSetHeaders_HeaderArray = new(this, "InternalSetHeaders", 0, typeof(System.Runtime.Remoting.Messaging.Header).MakeArrayType());
				}
				return r_MInternalSetHeaders_HeaderArray;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.Header[] InternalGetHeaders()
		/// </summary>
		protected RMethod r_MInternalGetHeaders;
		public virtual RMethod RMInternalGetHeaders
		{
			get
			{
				if(r_MInternalGetHeaders == null)
				{
					r_MInternalGetHeaders = new(this, "InternalGetHeaders", 0);
				}
				return r_MInternalGetHeaders;
			}
		}

		/// <summary>
		/// System.Security.Principal.IPrincipal RemovePrincipalIfNotSerializable()
		/// </summary>
		protected RMethod r_MRemovePrincipalIfNotSerializable;
		public virtual RMethod RMRemovePrincipalIfNotSerializable
		{
			get
			{
				if(r_MRemovePrincipalIfNotSerializable == null)
				{
					r_MRemovePrincipalIfNotSerializable = new(this, "RemovePrincipalIfNotSerializable", 0);
				}
				return r_MRemovePrincipalIfNotSerializable;
			}
		}

		/// <summary>
		/// Void PropagateOutgoingHeadersToMessage(System.Runtime.Remoting.Messaging.IMessage)
		/// </summary>
		protected RMethod r_MPropagateOutgoingHeadersToMessage_IMessage;
		public virtual RMethod RMPropagateOutgoingHeadersToMessage_IMessage
		{
			get
			{
				if(r_MPropagateOutgoingHeadersToMessage_IMessage == null)
				{
					r_MPropagateOutgoingHeadersToMessage_IMessage = new(this, "PropagateOutgoingHeadersToMessage", 0, typeof(System.Runtime.Remoting.Messaging.IMessage));
				}
				return r_MPropagateOutgoingHeadersToMessage_IMessage;
			}
		}

		/// <summary>
		/// System.String GetPropertyKeyForHeader(System.Runtime.Remoting.Messaging.Header)
		/// </summary>
		protected static RMethod r_MGetPropertyKeyForHeader_Header;
		public static RMethod RMGetPropertyKeyForHeader_Header
		{
			get
			{
				if(r_MGetPropertyKeyForHeader_Header == null)
				{
					r_MGetPropertyKeyForHeader_Header = new(typeof(System.Runtime.Remoting.Messaging.LogicalCallContext), "GetPropertyKeyForHeader", 0, typeof(System.Runtime.Remoting.Messaging.Header));
				}
				return r_MGetPropertyKeyForHeader_Header;
			}
		}

		/// <summary>
		/// Void PropagateIncomingHeadersToCallContext(System.Runtime.Remoting.Messaging.IMessage)
		/// </summary>
		protected RMethod r_MPropagateIncomingHeadersToCallContext_IMessage;
		public virtual RMethod RMPropagateIncomingHeadersToCallContext_IMessage
		{
			get
			{
				if(r_MPropagateIncomingHeadersToCallContext_IMessage == null)
				{
					r_MPropagateIncomingHeadersToCallContext_IMessage = new(this, "PropagateIncomingHeadersToCallContext", 0, typeof(System.Runtime.Remoting.Messaging.IMessage));
				}
				return r_MPropagateIncomingHeadersToCallContext_IMessage;
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


        public RLogicalCallContext() : base("System.Runtime.Remoting.Messaging.LogicalCallContext")
        {
        }

        public RLogicalCallContext(System.Object instance) : base("System.Runtime.Remoting.Messaging.LogicalCallContext")
		{
            SetInstance(instance);
		}

        public RLogicalCallContext(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RLogicalCallContext(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void Merge(System.Runtime.Remoting.Messaging.LogicalCallContext @lc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lc};
            var ___result = RMMerge_LogicalCallContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FreeNamedDataSlot(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMFreeNamedDataSlot_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetData(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetData_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void SetData(System.String @name, System.Object @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @data};
            var ___result = RMSetData_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Runtime.Remoting.Messaging.Header[] InternalGetOutgoingHeaders()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternalGetOutgoingHeaders.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.Messaging.Header[])___result;
        }


        public virtual void InternalSetHeaders(System.Runtime.Remoting.Messaging.Header[] @headers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@headers};
            var ___result = RMInternalSetHeaders_HeaderArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Runtime.Remoting.Messaging.Header[] InternalGetHeaders()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternalGetHeaders.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.Messaging.Header[])___result;
        }


        public virtual System.Security.Principal.IPrincipal RemovePrincipalIfNotSerializable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRemovePrincipalIfNotSerializable.Invoke(___genericsType, ___parameters);

            return (System.Security.Principal.IPrincipal)___result;
        }


        public virtual void PropagateOutgoingHeadersToMessage(System.Runtime.Remoting.Messaging.IMessage @msg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@msg};
            var ___result = RMPropagateOutgoingHeadersToMessage_IMessage.Invoke(___genericsType, ___parameters);

            
        }


        public static System.String GetPropertyKeyForHeader(System.Runtime.Remoting.Messaging.Header @header)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@header};
            var ___result = RMGetPropertyKeyForHeader_Header.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void PropagateIncomingHeadersToCallContext(System.Runtime.Remoting.Messaging.IMessage @msg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@msg};
            var ___result = RMPropagateIncomingHeadersToCallContext_IMessage.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
