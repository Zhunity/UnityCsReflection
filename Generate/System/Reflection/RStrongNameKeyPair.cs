using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.StrongNameKeyPair
	/// </summary>
    public partial class RStrongNameKeyPair : RMember //
    {

		/// <summary>
		/// System.Byte[] _publicKey
		/// </summary>
		protected RFieldArray<RSystem.RByte> r__publicKey;
		public virtual RFieldArray<RSystem.RByte> R_publicKey
		{
			get
			{
				if(r__publicKey == null)
				{
					r__publicKey = new(this, "_publicKey");
					r__publicKey.SetBelong(this.instance);
				}
				return r__publicKey;
			}
		}

		/// <summary>
		/// System.String _keyPairContainer
		/// </summary>
		protected RSystem.RString r__keyPairContainer;
		public virtual RSystem.RString R_keyPairContainer
		{
			get
			{
				if(r__keyPairContainer == null)
				{
					r__keyPairContainer = new(this, "_keyPairContainer");
					r__keyPairContainer.SetBelong(this.instance);
				}
				return r__keyPairContainer;
			}
		}

		/// <summary>
		/// System.Boolean _keyPairExported
		/// </summary>
		protected RSystem.RBoolean r__keyPairExported;
		public virtual RSystem.RBoolean R_keyPairExported
		{
			get
			{
				if(r__keyPairExported == null)
				{
					r__keyPairExported = new(this, "_keyPairExported");
					r__keyPairExported.SetBelong(this.instance);
				}
				return r__keyPairExported;
			}
		}

		/// <summary>
		/// System.Byte[] _keyPairArray
		/// </summary>
		protected RFieldArray<RSystem.RByte> r__keyPairArray;
		public virtual RFieldArray<RSystem.RByte> R_keyPairArray
		{
			get
			{
				if(r__keyPairArray == null)
				{
					r__keyPairArray = new(this, "_keyPairArray");
					r__keyPairArray.SetBelong(this.instance);
				}
				return r__keyPairArray;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSA _rsa
		/// </summary>
		protected RSystem.RSecurity.RCryptography.RRSA r__rsa;
		public virtual RSystem.RSecurity.RCryptography.RRSA R_rsa
		{
			get
			{
				if(r__rsa == null)
				{
					r__rsa = new(this, "_rsa");
					r__rsa.SetBelong(this.instance);
				}
				return r__rsa;
			}
		}

		/// <summary>
		/// Byte[] PublicKey
		/// </summary>
		protected RPropertyArray<RSystem.RByte> r_PublicKey;
		public virtual RPropertyArray<RSystem.RByte> RPublicKey
		{
			get
			{
				if(r_PublicKey == null)
				{
					r_PublicKey = new(this, "PublicKey", -1);
					r_PublicKey.SetBelong(this.instance);
				}
				return r_PublicKey;
			}
		}

		/// <summary>
		/// Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext = new(this, "System.Runtime.Serialization.ISerializable.GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// Void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(System.Object)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object;
		public virtual RMethod RSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object
		{
			get
			{
				if(r_System__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object == null)
				{
					r_System__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object = new(this, "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", 0, typeof(System.Object));
					r_System__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSA GetRSA()
		/// </summary>
		protected RMethod r_GetRSA;
		public virtual RMethod RGetRSA
		{
			get
			{
				if(r_GetRSA == null)
				{
					r_GetRSA = new(this, "GetRSA", 0);
					r_GetRSA.SetBelong(this.instance);
				}
				return r_GetRSA;
			}
		}

		/// <summary>
		/// Void LoadKey(Byte[])
		/// </summary>
		protected RMethod r_LoadKey_ByteArray;
		public virtual RMethod RLoadKey_ByteArray
		{
			get
			{
				if(r_LoadKey_ByteArray == null)
				{
					r_LoadKey_ByteArray = new(this, "LoadKey", 0, typeof(System.Byte).MakeArrayType());
					r_LoadKey_ByteArray.SetBelong(this.instance);
				}
				return r_LoadKey_ByteArray;
			}
		}

		/// <summary>
		/// Mono.Security.StrongName StrongName()
		/// </summary>
		protected RMethod r_StrongName;
		public virtual RMethod RStrongName
		{
			get
			{
				if(r_StrongName == null)
				{
					r_StrongName = new(this, "StrongName", 0);
					r_StrongName.SetBelong(this.instance);
				}
				return r_StrongName;
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


        public RStrongNameKeyPair() : base("System.Reflection.StrongNameKeyPair")
        {
        }

        public RStrongNameKeyPair(System.Object instance) : base("System.Reflection.StrongNameKeyPair")
		{
            SetInstance(instance);
		}

        public RStrongNameKeyPair(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStrongNameKeyPair(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization(System.Object @sender)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender};
            var ___result = RSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.Cryptography.RSA GetRSA()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRSA.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.RSA)___result;
        }


        public virtual void LoadKey(System.Byte[] @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RLoadKey_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RMono.RSecurity.RStrongName StrongName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStrongName.Invoke(___genericsType, ___parameters);

            return new RMono.RSecurity.RStrongName(___result);
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
