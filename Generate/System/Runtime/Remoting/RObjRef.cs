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
		protected RSystem.RRuntime.RRemoting.RIChannelInfo r_Fchannel_info;
		public virtual RSystem.RRuntime.RRemoting.RIChannelInfo RFchannel_info
		{
			get
			{
				if(r_Fchannel_info == null)
				{
					r_Fchannel_info = new(this, "channel_info");
					r_Fchannel_info.SetBelong(this.instance);
				}
				return r_Fchannel_info;
			}
		}

		/// <summary>
		/// System.String uri
		/// </summary>
		protected RSystem.RString r_Furi;
		public virtual RSystem.RString RFuri
		{
			get
			{
				if(r_Furi == null)
				{
					r_Furi = new(this, "uri");
					r_Furi.SetBelong(this.instance);
				}
				return r_Furi;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.IRemotingTypeInfo typeInfo
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RIRemotingTypeInfo r_FtypeInfo;
		public virtual RSystem.RRuntime.RRemoting.RIRemotingTypeInfo RFtypeInfo
		{
			get
			{
				if(r_FtypeInfo == null)
				{
					r_FtypeInfo = new(this, "typeInfo");
					r_FtypeInfo.SetBelong(this.instance);
				}
				return r_FtypeInfo;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.IEnvoyInfo envoyInfo
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RIEnvoyInfo r_FenvoyInfo;
		public virtual RSystem.RRuntime.RRemoting.RIEnvoyInfo RFenvoyInfo
		{
			get
			{
				if(r_FenvoyInfo == null)
				{
					r_FenvoyInfo = new(this, "envoyInfo");
					r_FenvoyInfo.SetBelong(this.instance);
				}
				return r_FenvoyInfo;
			}
		}

		/// <summary>
		/// System.Int32 flags
		/// </summary>
		protected RSystem.RInt32 r_Fflags;
		public virtual RSystem.RInt32 RFflags
		{
			get
			{
				if(r_Fflags == null)
				{
					r_Fflags = new(this, "flags");
					r_Fflags.SetBelong(this.instance);
				}
				return r_Fflags;
			}
		}

		/// <summary>
		/// System.Type _serverType
		/// </summary>
		protected RSystem.RType r_F_serverType;
		public virtual RSystem.RType RF_serverType
		{
			get
			{
				if(r_F_serverType == null)
				{
					r_F_serverType = new(this, "_serverType");
					r_F_serverType.SetBelong(this.instance);
				}
				return r_F_serverType;
			}
		}

		/// <summary>
		/// System.Int32 MarshalledObjectRef
		/// </summary>
		protected static RSystem.RInt32 r_FMarshalledObjectRef;
		public static RSystem.RInt32 RFMarshalledObjectRef
		{
			get
			{
				if(r_FMarshalledObjectRef == null)
				{
					r_FMarshalledObjectRef = new(typeof(System.Runtime.Remoting.ObjRef), "MarshalledObjectRef");
					r_FMarshalledObjectRef.SetBelong(null);
				}
				return r_FMarshalledObjectRef;
			}
		}

		/// <summary>
		/// System.Int32 WellKnowObjectRef
		/// </summary>
		protected static RSystem.RInt32 r_FWellKnowObjectRef;
		public static RSystem.RInt32 RFWellKnowObjectRef
		{
			get
			{
				if(r_FWellKnowObjectRef == null)
				{
					r_FWellKnowObjectRef = new(typeof(System.Runtime.Remoting.ObjRef), "WellKnowObjectRef");
					r_FWellKnowObjectRef.SetBelong(null);
				}
				return r_FWellKnowObjectRef;
			}
		}

		/// <summary>
		/// Boolean IsReferenceToWellKnow
		/// </summary>
		protected RSystem.RBoolean r_PIsReferenceToWellKnow;
		public virtual RSystem.RBoolean RPIsReferenceToWellKnow
		{
			get
			{
				if(r_PIsReferenceToWellKnow == null)
				{
					r_PIsReferenceToWellKnow = new(this, "IsReferenceToWellKnow", -1);
					r_PIsReferenceToWellKnow.SetBelong(this.instance);
				}
				return r_PIsReferenceToWellKnow;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.IChannelInfo ChannelInfo
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RIChannelInfo r_PChannelInfo;
		public virtual RSystem.RRuntime.RRemoting.RIChannelInfo RPChannelInfo
		{
			get
			{
				if(r_PChannelInfo == null)
				{
					r_PChannelInfo = new(this, "ChannelInfo", -1);
					r_PChannelInfo.SetBelong(this.instance);
				}
				return r_PChannelInfo;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.IEnvoyInfo EnvoyInfo
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RIEnvoyInfo r_PEnvoyInfo;
		public virtual RSystem.RRuntime.RRemoting.RIEnvoyInfo RPEnvoyInfo
		{
			get
			{
				if(r_PEnvoyInfo == null)
				{
					r_PEnvoyInfo = new(this, "EnvoyInfo", -1);
					r_PEnvoyInfo.SetBelong(this.instance);
				}
				return r_PEnvoyInfo;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.IRemotingTypeInfo TypeInfo
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RIRemotingTypeInfo r_PTypeInfo;
		public virtual RSystem.RRuntime.RRemoting.RIRemotingTypeInfo RPTypeInfo
		{
			get
			{
				if(r_PTypeInfo == null)
				{
					r_PTypeInfo = new(this, "TypeInfo", -1);
					r_PTypeInfo.SetBelong(this.instance);
				}
				return r_PTypeInfo;
			}
		}

		/// <summary>
		/// System.String URI
		/// </summary>
		protected RSystem.RString r_PURI;
		public virtual RSystem.RString RPURI
		{
			get
			{
				if(r_PURI == null)
				{
					r_PURI = new(this, "URI", -1);
					r_PURI.SetBelong(this.instance);
				}
				return r_PURI;
			}
		}

		/// <summary>
		/// System.Type ServerType
		/// </summary>
		protected RSystem.RType r_PServerType;
		public virtual RSystem.RType RPServerType
		{
			get
			{
				if(r_PServerType == null)
				{
					r_PServerType = new(this, "ServerType", -1);
					r_PServerType.SetBelong(this.instance);
				}
				return r_PServerType;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjRef DeserializeInTheCurrentDomain(Int32, Byte[])
		/// </summary>
		protected RMethod r_MDeserializeInTheCurrentDomain_Int32_ByteArray;
		public virtual RMethod RMDeserializeInTheCurrentDomain_Int32_ByteArray
		{
			get
			{
				if(r_MDeserializeInTheCurrentDomain_Int32_ByteArray == null)
				{
					r_MDeserializeInTheCurrentDomain_Int32_ByteArray = new(this, "DeserializeInTheCurrentDomain", 0, typeof(System.Int32), typeof(System.Byte).MakeArrayType());
					r_MDeserializeInTheCurrentDomain_Int32_ByteArray.SetBelong(this.instance);
				}
				return r_MDeserializeInTheCurrentDomain_Int32_ByteArray;
			}
		}

		/// <summary>
		/// Byte[] SerializeType()
		/// </summary>
		protected RMethod r_MSerializeType;
		public virtual RMethod RMSerializeType
		{
			get
			{
				if(r_MSerializeType == null)
				{
					r_MSerializeType = new(this, "SerializeType", 0);
					r_MSerializeType.SetBelong(this.instance);
				}
				return r_MSerializeType;
			}
		}

		/// <summary>
		/// Boolean IsPossibleToCAD()
		/// </summary>
		protected RMethod r_MIsPossibleToCAD;
		public virtual RMethod RMIsPossibleToCAD
		{
			get
			{
				if(r_MIsPossibleToCAD == null)
				{
					r_MIsPossibleToCAD = new(this, "IsPossibleToCAD", 0);
					r_MIsPossibleToCAD.SetBelong(this.instance);
				}
				return r_MIsPossibleToCAD;
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
					r_MGetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_MGetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// System.Object GetRealObject(System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MGetRealObject_StreamingContext;
		public virtual RMethod RMGetRealObject_StreamingContext
		{
			get
			{
				if(r_MGetRealObject_StreamingContext == null)
				{
					r_MGetRealObject_StreamingContext = new(this, "GetRealObject", 0, typeof(System.Runtime.Serialization.StreamingContext));
					r_MGetRealObject_StreamingContext.SetBelong(this.instance);
				}
				return r_MGetRealObject_StreamingContext;
			}
		}

		/// <summary>
		/// Boolean IsFromThisAppDomain()
		/// </summary>
		protected RMethod r_MIsFromThisAppDomain;
		public virtual RMethod RMIsFromThisAppDomain
		{
			get
			{
				if(r_MIsFromThisAppDomain == null)
				{
					r_MIsFromThisAppDomain = new(this, "IsFromThisAppDomain", 0);
					r_MIsFromThisAppDomain.SetBelong(this.instance);
				}
				return r_MIsFromThisAppDomain;
			}
		}

		/// <summary>
		/// Boolean IsFromThisProcess()
		/// </summary>
		protected RMethod r_MIsFromThisProcess;
		public virtual RMethod RMIsFromThisProcess
		{
			get
			{
				if(r_MIsFromThisProcess == null)
				{
					r_MIsFromThisProcess = new(this, "IsFromThisProcess", 0);
					r_MIsFromThisProcess.SetBelong(this.instance);
				}
				return r_MIsFromThisProcess;
			}
		}

		/// <summary>
		/// Void UpdateChannelInfo()
		/// </summary>
		protected RMethod r_MUpdateChannelInfo;
		public virtual RMethod RMUpdateChannelInfo
		{
			get
			{
				if(r_MUpdateChannelInfo == null)
				{
					r_MUpdateChannelInfo = new(this, "UpdateChannelInfo", 0);
					r_MUpdateChannelInfo.SetBelong(this.instance);
				}
				return r_MUpdateChannelInfo;
			}
		}

		/// <summary>
		/// Void SetDomainID(Int32)
		/// </summary>
		protected RMethod r_MSetDomainID_Int32;
		public virtual RMethod RMSetDomainID_Int32
		{
			get
			{
				if(r_MSetDomainID_Int32 == null)
				{
					r_MSetDomainID_Int32 = new(this, "SetDomainID", 0, typeof(System.Int32));
					r_MSetDomainID_Int32.SetBelong(this.instance);
				}
				return r_MSetDomainID_Int32;
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

        public virtual System.Runtime.Remoting.ObjRef DeserializeInTheCurrentDomain(System.Int32 @domainId, System.Byte[] @tInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@domainId, @tInfo};
            var ___result = RMDeserializeInTheCurrentDomain_Int32_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjRef)___result;
        }


        public virtual System.Byte[] SerializeType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSerializeType.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Boolean IsPossibleToCAD()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsPossibleToCAD.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetRealObject(System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@context};
            var ___result = RMGetRealObject_StreamingContext.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean IsFromThisAppDomain()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsFromThisAppDomain.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsFromThisProcess()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsFromThisProcess.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void UpdateChannelInfo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateChannelInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetDomainID(System.Int32 @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RMSetDomainID_Int32.Invoke(___genericsType, ___parameters);

            
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
