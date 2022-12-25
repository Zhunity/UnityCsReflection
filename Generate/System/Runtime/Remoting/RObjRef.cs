using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting
{
	/// <summary>
	/// System.Runtime.Remoting.ObjRef
	/// </summary>
    public partial class RObjRef : RMember //
    {

		/// <summary>
		/// System.Runtime.Remoting.IChannelInfo channel_info
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RIChannelInfo r_channel_info;
		public virtual RSystem.RRuntime.RRemoting.RIChannelInfo Rchannel_info
		{
			get
			{
				if(r_channel_info == null)
				{
					r_channel_info = new(this, "channel_info");
					r_channel_info.SetBelong(this.instance);
				}
				return r_channel_info;
			}
		}

		/// <summary>
		/// System.String uri
		/// </summary>
		protected RField r_uri;
		public virtual RField Ruri
		{
			get
			{
				if(r_uri == null)
				{
					r_uri = new(this, "uri");
					r_uri.SetBelong(this.instance);
				}
				return r_uri;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.IRemotingTypeInfo typeInfo
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RIRemotingTypeInfo r_typeInfo;
		public virtual RSystem.RRuntime.RRemoting.RIRemotingTypeInfo RtypeInfo
		{
			get
			{
				if(r_typeInfo == null)
				{
					r_typeInfo = new(this, "typeInfo");
					r_typeInfo.SetBelong(this.instance);
				}
				return r_typeInfo;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.IEnvoyInfo envoyInfo
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RIEnvoyInfo r_envoyInfo;
		public virtual RSystem.RRuntime.RRemoting.RIEnvoyInfo RenvoyInfo
		{
			get
			{
				if(r_envoyInfo == null)
				{
					r_envoyInfo = new(this, "envoyInfo");
					r_envoyInfo.SetBelong(this.instance);
				}
				return r_envoyInfo;
			}
		}

		/// <summary>
		/// System.Int32 flags
		/// </summary>
		protected RField r_flags;
		public virtual RField Rflags
		{
			get
			{
				if(r_flags == null)
				{
					r_flags = new(this, "flags");
					r_flags.SetBelong(this.instance);
				}
				return r_flags;
			}
		}

		/// <summary>
		/// System.Type _serverType
		/// </summary>
		protected RSystem.RType r__serverType;
		public virtual RSystem.RType R_serverType
		{
			get
			{
				if(r__serverType == null)
				{
					r__serverType = new(this, "_serverType");
					r__serverType.SetBelong(this.instance);
				}
				return r__serverType;
			}
		}

		/// <summary>
		/// System.Int32 MarshalledObjectRef
		/// </summary>
		protected static RField r_MarshalledObjectRef;
		public static RField RMarshalledObjectRef
		{
			get
			{
				if(r_MarshalledObjectRef == null)
				{
					r_MarshalledObjectRef = new(typeof(System.Runtime.Remoting.ObjRef), "MarshalledObjectRef");
					r_MarshalledObjectRef.SetBelong(null);
				}
				return r_MarshalledObjectRef;
			}
		}

		/// <summary>
		/// System.Int32 WellKnowObjectRef
		/// </summary>
		protected static RField r_WellKnowObjectRef;
		public static RField RWellKnowObjectRef
		{
			get
			{
				if(r_WellKnowObjectRef == null)
				{
					r_WellKnowObjectRef = new(typeof(System.Runtime.Remoting.ObjRef), "WellKnowObjectRef");
					r_WellKnowObjectRef.SetBelong(null);
				}
				return r_WellKnowObjectRef;
			}
		}

		/// <summary>
		/// Boolean IsReferenceToWellKnow
		/// </summary>
		protected RProperty r_IsReferenceToWellKnow;
		public virtual RProperty RIsReferenceToWellKnow
		{
			get
			{
				if(r_IsReferenceToWellKnow == null)
				{
					r_IsReferenceToWellKnow = new(this, "IsReferenceToWellKnow", -1);
					r_IsReferenceToWellKnow.SetBelong(this.instance);
				}
				return r_IsReferenceToWellKnow;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.IChannelInfo ChannelInfo
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RIChannelInfo r_ChannelInfo;
		public virtual RSystem.RRuntime.RRemoting.RIChannelInfo RChannelInfo
		{
			get
			{
				if(r_ChannelInfo == null)
				{
					r_ChannelInfo = new(this, "ChannelInfo", -1);
					r_ChannelInfo.SetBelong(this.instance);
				}
				return r_ChannelInfo;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.IEnvoyInfo EnvoyInfo
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RIEnvoyInfo r_EnvoyInfo;
		public virtual RSystem.RRuntime.RRemoting.RIEnvoyInfo REnvoyInfo
		{
			get
			{
				if(r_EnvoyInfo == null)
				{
					r_EnvoyInfo = new(this, "EnvoyInfo", -1);
					r_EnvoyInfo.SetBelong(this.instance);
				}
				return r_EnvoyInfo;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.IRemotingTypeInfo TypeInfo
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RIRemotingTypeInfo r_TypeInfo;
		public virtual RSystem.RRuntime.RRemoting.RIRemotingTypeInfo RTypeInfo
		{
			get
			{
				if(r_TypeInfo == null)
				{
					r_TypeInfo = new(this, "TypeInfo", -1);
					r_TypeInfo.SetBelong(this.instance);
				}
				return r_TypeInfo;
			}
		}

		/// <summary>
		/// System.String URI
		/// </summary>
		protected RProperty r_URI;
		public virtual RProperty RURI
		{
			get
			{
				if(r_URI == null)
				{
					r_URI = new(this, "URI", -1);
					r_URI.SetBelong(this.instance);
				}
				return r_URI;
			}
		}

		/// <summary>
		/// System.Type ServerType
		/// </summary>
		protected RSystem.RType r_ServerType;
		public virtual RSystem.RType RServerType
		{
			get
			{
				if(r_ServerType == null)
				{
					r_ServerType = new(this, "ServerType", -1);
					r_ServerType.SetBelong(this.instance);
				}
				return r_ServerType;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjRef DeserializeInTheCurrentDomain(Int32, Byte[])
		/// </summary>
		protected RMethod r_RDeserializeInTheCurrentDomain_Int32_ByteArray;
		public virtual RMethod RDeserializeInTheCurrentDomain_Int32_ByteArray
		{
			get
			{
				if(r_RDeserializeInTheCurrentDomain_Int32_ByteArray == null)
				{
					r_RDeserializeInTheCurrentDomain_Int32_ByteArray = new(this, "DeserializeInTheCurrentDomain", 0, typeof(System.Int32), typeof(System.Byte).MakeArrayType());
					r_RDeserializeInTheCurrentDomain_Int32_ByteArray.SetBelong(this.instance);
				}
				return r_RDeserializeInTheCurrentDomain_Int32_ByteArray;
			}
		}

		/// <summary>
		/// Byte[] SerializeType()
		/// </summary>
		protected RMethod r_RSerializeType;
		public virtual RMethod RSerializeType
		{
			get
			{
				if(r_RSerializeType == null)
				{
					r_RSerializeType = new(this, "SerializeType", 0);
					r_RSerializeType.SetBelong(this.instance);
				}
				return r_RSerializeType;
			}
		}

		/// <summary>
		/// Boolean IsPossibleToCAD()
		/// </summary>
		protected RMethod r_RIsPossibleToCAD;
		public virtual RMethod RIsPossibleToCAD
		{
			get
			{
				if(r_RIsPossibleToCAD == null)
				{
					r_RIsPossibleToCAD = new(this, "IsPossibleToCAD", 0);
					r_RIsPossibleToCAD.SetBelong(this.instance);
				}
				return r_RIsPossibleToCAD;
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
		/// System.Object GetRealObject(System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_RGetRealObject_StreamingContext;
		public virtual RMethod RGetRealObject_StreamingContext
		{
			get
			{
				if(r_RGetRealObject_StreamingContext == null)
				{
					r_RGetRealObject_StreamingContext = new(this, "GetRealObject", 0, typeof(System.Runtime.Serialization.StreamingContext));
					r_RGetRealObject_StreamingContext.SetBelong(this.instance);
				}
				return r_RGetRealObject_StreamingContext;
			}
		}

		/// <summary>
		/// Boolean IsFromThisAppDomain()
		/// </summary>
		protected RMethod r_RIsFromThisAppDomain;
		public virtual RMethod RIsFromThisAppDomain
		{
			get
			{
				if(r_RIsFromThisAppDomain == null)
				{
					r_RIsFromThisAppDomain = new(this, "IsFromThisAppDomain", 0);
					r_RIsFromThisAppDomain.SetBelong(this.instance);
				}
				return r_RIsFromThisAppDomain;
			}
		}

		/// <summary>
		/// Boolean IsFromThisProcess()
		/// </summary>
		protected RMethod r_RIsFromThisProcess;
		public virtual RMethod RIsFromThisProcess
		{
			get
			{
				if(r_RIsFromThisProcess == null)
				{
					r_RIsFromThisProcess = new(this, "IsFromThisProcess", 0);
					r_RIsFromThisProcess.SetBelong(this.instance);
				}
				return r_RIsFromThisProcess;
			}
		}

		/// <summary>
		/// Void UpdateChannelInfo()
		/// </summary>
		protected RMethod r_RUpdateChannelInfo;
		public virtual RMethod RUpdateChannelInfo
		{
			get
			{
				if(r_RUpdateChannelInfo == null)
				{
					r_RUpdateChannelInfo = new(this, "UpdateChannelInfo", 0);
					r_RUpdateChannelInfo.SetBelong(this.instance);
				}
				return r_RUpdateChannelInfo;
			}
		}

		/// <summary>
		/// Void SetDomainID(Int32)
		/// </summary>
		protected RMethod r_RSetDomainID_Int32;
		public virtual RMethod RSetDomainID_Int32
		{
			get
			{
				if(r_RSetDomainID_Int32 == null)
				{
					r_RSetDomainID_Int32 = new(this, "SetDomainID", 0, typeof(System.Int32));
					r_RSetDomainID_Int32.SetBelong(this.instance);
				}
				return r_RSetDomainID_Int32;
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


        public RObjRef() : base("System.Runtime.Remoting.ObjRef")
        {
        }

        public RObjRef(System.Object instance) : base("System.Runtime.Remoting.ObjRef")
		{
            SetInstance(instance);
		}

        public RObjRef(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RObjRef(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Runtime.Remoting.ObjRef DeserializeInTheCurrentDomain(System.Int32  @domainId, System.Byte[]  @tInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@domainId, @tInfo};
            var ___result = RDeserializeInTheCurrentDomain_Int32_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjRef)___result;
        }


        public virtual System.Byte[] SerializeType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSerializeType.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Boolean IsPossibleToCAD()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsPossibleToCAD.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo  @info, System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetRealObject(System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@context};
            var ___result = RGetRealObject_StreamingContext.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean IsFromThisAppDomain()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsFromThisAppDomain.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsFromThisProcess()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsFromThisProcess.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void UpdateChannelInfo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateChannelInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetDomainID(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RSetDomainID_Int32.Invoke(___genericsType, ___parameters);

            
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
