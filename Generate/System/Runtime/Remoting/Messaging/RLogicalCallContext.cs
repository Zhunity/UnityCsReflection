using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging
{
	/// <summary>
	/// System.Runtime.Remoting.Messaging.LogicalCallContext
	/// </summary>
    public partial class RLogicalCallContext : RMember //
    {

		/// <summary>
		/// System.Type s_callContextType
		/// </summary>
		protected static RSystem.RType r_s_callContextType;
		public static RSystem.RType Rs_callContextType
		{
			get
			{
				if(r_s_callContextType == null)
				{
					r_s_callContextType = new(typeof(System.Runtime.Remoting.Messaging.LogicalCallContext), "s_callContextType");
					r_s_callContextType.SetBelong(null);
				}
				return r_s_callContextType;
			}
		}

		/// <summary>
		/// System.String s_CorrelationMgrSlotName
		/// </summary>
		protected static RField r_s_CorrelationMgrSlotName;
		public static RField Rs_CorrelationMgrSlotName
		{
			get
			{
				if(r_s_CorrelationMgrSlotName == null)
				{
					r_s_CorrelationMgrSlotName = new(typeof(System.Runtime.Remoting.Messaging.LogicalCallContext), "s_CorrelationMgrSlotName");
					r_s_CorrelationMgrSlotName.SetBelong(null);
				}
				return r_s_CorrelationMgrSlotName;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable m_Datastore
		/// </summary>
		protected RSystem.RCollections.RHashtable r_m_Datastore;
		public virtual RSystem.RCollections.RHashtable Rm_Datastore
		{
			get
			{
				if(r_m_Datastore == null)
				{
					r_m_Datastore = new(this, "m_Datastore");
					r_m_Datastore.SetBelong(this.instance);
				}
				return r_m_Datastore;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.CallContextRemotingData m_RemotingData
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RMessaging.RCallContextRemotingData r_m_RemotingData;
		public virtual RSystem.RRuntime.RRemoting.RMessaging.RCallContextRemotingData Rm_RemotingData
		{
			get
			{
				if(r_m_RemotingData == null)
				{
					r_m_RemotingData = new(this, "m_RemotingData");
					r_m_RemotingData.SetBelong(this.instance);
				}
				return r_m_RemotingData;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.CallContextSecurityData m_SecurityData
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RMessaging.RCallContextSecurityData r_m_SecurityData;
		public virtual RSystem.RRuntime.RRemoting.RMessaging.RCallContextSecurityData Rm_SecurityData
		{
			get
			{
				if(r_m_SecurityData == null)
				{
					r_m_SecurityData = new(this, "m_SecurityData");
					r_m_SecurityData.SetBelong(this.instance);
				}
				return r_m_SecurityData;
			}
		}

		/// <summary>
		/// System.Object m_HostContext
		/// </summary>
		protected RSystem.RObject r_m_HostContext;
		public virtual RSystem.RObject Rm_HostContext
		{
			get
			{
				if(r_m_HostContext == null)
				{
					r_m_HostContext = new(this, "m_HostContext");
					r_m_HostContext.SetBelong(this.instance);
				}
				return r_m_HostContext;
			}
		}

		/// <summary>
		/// System.Boolean m_IsCorrelationMgr
		/// </summary>
		protected RField r_m_IsCorrelationMgr;
		public virtual RField Rm_IsCorrelationMgr
		{
			get
			{
				if(r_m_IsCorrelationMgr == null)
				{
					r_m_IsCorrelationMgr = new(this, "m_IsCorrelationMgr");
					r_m_IsCorrelationMgr.SetBelong(this.instance);
				}
				return r_m_IsCorrelationMgr;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.Header[] _sendHeaders
		/// </summary>
		protected RFieldArray<RSystem.RRuntime.RRemoting.RMessaging.RHeader> r__sendHeaders;
		public virtual RFieldArray<RSystem.RRuntime.RRemoting.RMessaging.RHeader> R_sendHeaders
		{
			get
			{
				if(r__sendHeaders == null)
				{
					r__sendHeaders = new(this, "_sendHeaders");
					r__sendHeaders.SetBelong(this.instance);
				}
				return r__sendHeaders;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.Header[] _recvHeaders
		/// </summary>
		protected RFieldArray<RSystem.RRuntime.RRemoting.RMessaging.RHeader> r__recvHeaders;
		public virtual RFieldArray<RSystem.RRuntime.RRemoting.RMessaging.RHeader> R_recvHeaders
		{
			get
			{
				if(r__recvHeaders == null)
				{
					r__recvHeaders = new(this, "_recvHeaders");
					r__recvHeaders.SetBelong(this.instance);
				}
				return r__recvHeaders;
			}
		}

		/// <summary>
		/// Boolean HasInfo
		/// </summary>
		protected RProperty r_HasInfo;
		public virtual RProperty RHasInfo
		{
			get
			{
				if(r_HasInfo == null)
				{
					r_HasInfo = new(this, "HasInfo", -1);
					r_HasInfo.SetBelong(this.instance);
				}
				return r_HasInfo;
			}
		}

		/// <summary>
		/// Boolean HasUserData
		/// </summary>
		protected RProperty r_HasUserData;
		public virtual RProperty RHasUserData
		{
			get
			{
				if(r_HasUserData == null)
				{
					r_HasUserData = new(this, "HasUserData", -1);
					r_HasUserData.SetBelong(this.instance);
				}
				return r_HasUserData;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.CallContextRemotingData RemotingData
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RMessaging.RCallContextRemotingData r_RemotingData;
		public virtual RSystem.RRuntime.RRemoting.RMessaging.RCallContextRemotingData RemotingData
		{
			get
			{
				if(r_RemotingData == null)
				{
					r_RemotingData = new(this, "RemotingData", -1);
					r_RemotingData.SetBelong(this.instance);
				}
				return r_RemotingData;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.CallContextSecurityData SecurityData
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RMessaging.RCallContextSecurityData r_SecurityData;
		public virtual RSystem.RRuntime.RRemoting.RMessaging.RCallContextSecurityData RSecurityData
		{
			get
			{
				if(r_SecurityData == null)
				{
					r_SecurityData = new(this, "SecurityData", -1);
					r_SecurityData.SetBelong(this.instance);
				}
				return r_SecurityData;
			}
		}

		/// <summary>
		/// System.Object HostContext
		/// </summary>
		protected RSystem.RObject r_HostContext;
		public virtual RSystem.RObject RHostContext
		{
			get
			{
				if(r_HostContext == null)
				{
					r_HostContext = new(this, "HostContext", -1);
					r_HostContext.SetBelong(this.instance);
				}
				return r_HostContext;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable Datastore
		/// </summary>
		protected RSystem.RCollections.RHashtable r_Datastore;
		public virtual RSystem.RCollections.RHashtable RDatastore
		{
			get
			{
				if(r_Datastore == null)
				{
					r_Datastore = new(this, "Datastore", -1);
					r_Datastore.SetBelong(this.instance);
				}
				return r_Datastore;
			}
		}

		/// <summary>
		/// System.Security.Principal.IPrincipal Principal
		/// </summary>
		protected RSystem.RSecurity.RPrincipal.RIPrincipal r_Principal;
		public virtual RSystem.RSecurity.RPrincipal.RIPrincipal RPrincipal
		{
			get
			{
				if(r_Principal == null)
				{
					r_Principal = new(this, "Principal", -1);
					r_Principal.SetBelong(this.instance);
				}
				return r_Principal;
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
		/// System.Object Clone()
		/// </summary>
		protected RMethod r_RClone;
		public virtual RMethod RClone
		{
			get
			{
				if(r_RClone == null)
				{
					r_RClone = new(this, "Clone", 0);
					r_RClone.SetBelong(this.instance);
				}
				return r_RClone;
			}
		}

		/// <summary>
		/// Void Merge(System.Runtime.Remoting.Messaging.LogicalCallContext)
		/// </summary>
		protected RMethod r_RMerge_LogicalCallContext;
		public virtual RMethod RMerge_LogicalCallContext
		{
			get
			{
				if(r_RMerge_LogicalCallContext == null)
				{
					r_RMerge_LogicalCallContext = new(this, "Merge", 0, typeof(System.Runtime.Remoting.Messaging.LogicalCallContext));
					r_RMerge_LogicalCallContext.SetBelong(this.instance);
				}
				return r_RMerge_LogicalCallContext;
			}
		}

		/// <summary>
		/// Void FreeNamedDataSlot(System.String)
		/// </summary>
		protected RMethod r_RFreeNamedDataSlot_String;
		public virtual RMethod RFreeNamedDataSlot_String
		{
			get
			{
				if(r_RFreeNamedDataSlot_String == null)
				{
					r_RFreeNamedDataSlot_String = new(this, "FreeNamedDataSlot", 0, typeof(System.String));
					r_RFreeNamedDataSlot_String.SetBelong(this.instance);
				}
				return r_RFreeNamedDataSlot_String;
			}
		}

		/// <summary>
		/// System.Object GetData(System.String)
		/// </summary>
		protected RMethod r_RGetData_String;
		public virtual RMethod RGetData_String
		{
			get
			{
				if(r_RGetData_String == null)
				{
					r_RGetData_String = new(this, "GetData", 0, typeof(System.String));
					r_RGetData_String.SetBelong(this.instance);
				}
				return r_RGetData_String;
			}
		}

		/// <summary>
		/// Void SetData(System.String, System.Object)
		/// </summary>
		protected RMethod r_RSetData_String_Object;
		public virtual RMethod RSetData_String_Object
		{
			get
			{
				if(r_RSetData_String_Object == null)
				{
					r_RSetData_String_Object = new(this, "SetData", 0, typeof(System.String), typeof(System.Object));
					r_RSetData_String_Object.SetBelong(this.instance);
				}
				return r_RSetData_String_Object;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.Header[] InternalGetOutgoingHeaders()
		/// </summary>
		protected RMethod r_RInternalGetOutgoingHeaders;
		public virtual RMethod RInternalGetOutgoingHeaders
		{
			get
			{
				if(r_RInternalGetOutgoingHeaders == null)
				{
					r_RInternalGetOutgoingHeaders = new(this, "InternalGetOutgoingHeaders", 0);
					r_RInternalGetOutgoingHeaders.SetBelong(this.instance);
				}
				return r_RInternalGetOutgoingHeaders;
			}
		}

		/// <summary>
		/// Void InternalSetHeaders(System.Runtime.Remoting.Messaging.Header[])
		/// </summary>
		protected RMethod r_RInternalSetHeaders_HeaderArray;
		public virtual RMethod RInternalSetHeaders_HeaderArray
		{
			get
			{
				if(r_RInternalSetHeaders_HeaderArray == null)
				{
					r_RInternalSetHeaders_HeaderArray = new(this, "InternalSetHeaders", 0, typeof(System.Runtime.Remoting.Messaging.Header).MakeArrayType());
					r_RInternalSetHeaders_HeaderArray.SetBelong(this.instance);
				}
				return r_RInternalSetHeaders_HeaderArray;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.Header[] InternalGetHeaders()
		/// </summary>
		protected RMethod r_RInternalGetHeaders;
		public virtual RMethod RInternalGetHeaders
		{
			get
			{
				if(r_RInternalGetHeaders == null)
				{
					r_RInternalGetHeaders = new(this, "InternalGetHeaders", 0);
					r_RInternalGetHeaders.SetBelong(this.instance);
				}
				return r_RInternalGetHeaders;
			}
		}

		/// <summary>
		/// System.Security.Principal.IPrincipal RemovePrincipalIfNotSerializable()
		/// </summary>
		protected RMethod r_RRemovePrincipalIfNotSerializable;
		public virtual RMethod RRemovePrincipalIfNotSerializable
		{
			get
			{
				if(r_RRemovePrincipalIfNotSerializable == null)
				{
					r_RRemovePrincipalIfNotSerializable = new(this, "RemovePrincipalIfNotSerializable", 0);
					r_RRemovePrincipalIfNotSerializable.SetBelong(this.instance);
				}
				return r_RRemovePrincipalIfNotSerializable;
			}
		}

		/// <summary>
		/// Void PropagateOutgoingHeadersToMessage(System.Runtime.Remoting.Messaging.IMessage)
		/// </summary>
		protected RMethod r_RPropagateOutgoingHeadersToMessage_IMessage;
		public virtual RMethod RPropagateOutgoingHeadersToMessage_IMessage
		{
			get
			{
				if(r_RPropagateOutgoingHeadersToMessage_IMessage == null)
				{
					r_RPropagateOutgoingHeadersToMessage_IMessage = new(this, "PropagateOutgoingHeadersToMessage", 0, typeof(System.Runtime.Remoting.Messaging.IMessage));
					r_RPropagateOutgoingHeadersToMessage_IMessage.SetBelong(this.instance);
				}
				return r_RPropagateOutgoingHeadersToMessage_IMessage;
			}
		}

		/// <summary>
		/// System.String GetPropertyKeyForHeader(System.Runtime.Remoting.Messaging.Header)
		/// </summary>
		protected static RMethod r_RGetPropertyKeyForHeader_Header;
		public static RMethod RGetPropertyKeyForHeader_Header
		{
			get
			{
				if(r_RGetPropertyKeyForHeader_Header == null)
				{
					r_RGetPropertyKeyForHeader_Header = new(typeof(System.Runtime.Remoting.Messaging.LogicalCallContext), "GetPropertyKeyForHeader", 0, typeof(System.Runtime.Remoting.Messaging.Header));
					r_RGetPropertyKeyForHeader_Header.SetBelong(null);
				}
				return r_RGetPropertyKeyForHeader_Header;
			}
		}

		/// <summary>
		/// Void PropagateIncomingHeadersToCallContext(System.Runtime.Remoting.Messaging.IMessage)
		/// </summary>
		protected RMethod r_RPropagateIncomingHeadersToCallContext_IMessage;
		public virtual RMethod RPropagateIncomingHeadersToCallContext_IMessage
		{
			get
			{
				if(r_RPropagateIncomingHeadersToCallContext_IMessage == null)
				{
					r_RPropagateIncomingHeadersToCallContext_IMessage = new(this, "PropagateIncomingHeadersToCallContext", 0, typeof(System.Runtime.Remoting.Messaging.IMessage));
					r_RPropagateIncomingHeadersToCallContext_IMessage.SetBelong(this.instance);
				}
				return r_RPropagateIncomingHeadersToCallContext_IMessage;
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

        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo  @info, System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void Merge(System.Runtime.Remoting.Messaging.LogicalCallContext  @lc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lc};
            var ___result = RMerge_LogicalCallContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FreeNamedDataSlot(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RFreeNamedDataSlot_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetData(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetData_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void SetData(System.String  @name, System.Object  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @data};
            var ___result = RSetData_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Runtime.Remoting.Messaging.Header[] InternalGetOutgoingHeaders()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalGetOutgoingHeaders.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.Messaging.Header[])___result;
        }


        public virtual void InternalSetHeaders(System.Runtime.Remoting.Messaging.Header[]  @headers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@headers};
            var ___result = RInternalSetHeaders_HeaderArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Runtime.Remoting.Messaging.Header[] InternalGetHeaders()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalGetHeaders.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.Messaging.Header[])___result;
        }


        public virtual System.Security.Principal.IPrincipal RemovePrincipalIfNotSerializable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRemovePrincipalIfNotSerializable.Invoke(___genericsType, ___parameters);

            return (System.Security.Principal.IPrincipal)___result;
        }


        public virtual void PropagateOutgoingHeadersToMessage(System.Runtime.Remoting.Messaging.IMessage  @msg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@msg};
            var ___result = RPropagateOutgoingHeadersToMessage_IMessage.Invoke(___genericsType, ___parameters);

            
        }


        public static System.String GetPropertyKeyForHeader(System.Runtime.Remoting.Messaging.Header  @header)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@header};
            var ___result = RGetPropertyKeyForHeader_Header.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void PropagateIncomingHeadersToCallContext(System.Runtime.Remoting.Messaging.IMessage  @msg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@msg};
            var ___result = RPropagateIncomingHeadersToCallContext_IMessage.Invoke(___genericsType, ___parameters);

            
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
