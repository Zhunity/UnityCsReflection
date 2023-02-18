
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.StrongNameKeyPair
	/// </summary>
    public partial class RStrongNameKeyPair : RMember //
    {

		/// <summary>
		/// System.Byte[] _publicKey
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> r_F_publicKey;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> RF_publicKey
		{
			get
			{
				if(r_F_publicKey == null)
				{
					r_F_publicKey = new(this, "_publicKey");
					r_F_publicKey.SetBelong(this.GetValue());
				}
				return r_F_publicKey;
			}
		}

		/// <summary>
		/// System.String _keyPairContainer
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F_keyPairContainer;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF_keyPairContainer
		{
			get
			{
				if(r_F_keyPairContainer == null)
				{
					r_F_keyPairContainer = new(this, "_keyPairContainer");
					r_F_keyPairContainer.SetBelong(this.GetValue());
				}
				return r_F_keyPairContainer;
			}
		}

		/// <summary>
		/// System.Boolean _keyPairExported
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F_keyPairExported;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF_keyPairExported
		{
			get
			{
				if(r_F_keyPairExported == null)
				{
					r_F_keyPairExported = new(this, "_keyPairExported");
					r_F_keyPairExported.SetBelong(this.GetValue());
				}
				return r_F_keyPairExported;
			}
		}

		/// <summary>
		/// System.Byte[] _keyPairArray
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> r_F_keyPairArray;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> RF_keyPairArray
		{
			get
			{
				if(r_F_keyPairArray == null)
				{
					r_F_keyPairArray = new(this, "_keyPairArray");
					r_F_keyPairArray.SetBelong(this.GetValue());
				}
				return r_F_keyPairArray;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSA _rsa
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSA r_F_rsa;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSA RF_rsa
		{
			get
			{
				if(r_F_rsa == null)
				{
					r_F_rsa = new(this, "_rsa");
					r_F_rsa.SetBelong(this.GetValue());
				}
				return r_F_rsa;
			}
		}

		/// <summary>
		/// Byte[] PublicKey
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RByte> r_PPublicKey;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RByte> RPPublicKey
		{
			get
			{
				if(r_PPublicKey == null)
				{
					r_PPublicKey = new(this, "PublicKey", -1);
					r_PPublicKey.SetBelong(this.GetValue());
				}
				return r_PPublicKey;
			}
		}

		/// <summary>
		/// Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RMSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext = new(this, "System.Runtime.Serialization.ISerializable.GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext.SetBelong(this.GetValue());
				}
				return r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// Void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(System.Object)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object;
		public virtual RMethod RMSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object
		{
			get
			{
				if(r_MSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object == null)
				{
					r_MSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object = new(this, "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", 0, typeof(System.Object));
					r_MSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object.SetBelong(this.GetValue());
				}
				return r_MSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSA GetRSA()
		/// </summary>
		protected RMethod r_MGetRSA;
		public virtual RMethod RMGetRSA
		{
			get
			{
				if(r_MGetRSA == null)
				{
					r_MGetRSA = new(this, "GetRSA", 0);
					r_MGetRSA.SetBelong(this.GetValue());
				}
				return r_MGetRSA;
			}
		}

		/// <summary>
		/// Void LoadKey(Byte[])
		/// </summary>
		protected RMethod r_MLoadKey_ByteArray;
		public virtual RMethod RMLoadKey_ByteArray
		{
			get
			{
				if(r_MLoadKey_ByteArray == null)
				{
					r_MLoadKey_ByteArray = new(this, "LoadKey", 0, typeof(System.Byte).MakeArrayType());
					r_MLoadKey_ByteArray.SetBelong(this.GetValue());
				}
				return r_MLoadKey_ByteArray;
			}
		}

		/// <summary>
		/// Mono.Security.StrongName StrongName()
		/// </summary>
		protected RMethod r_MStrongName;
		public virtual RMethod RMStrongName
		{
			get
			{
				if(r_MStrongName == null)
				{
					r_MStrongName = new(this, "StrongName", 0);
					r_MStrongName.SetBelong(this.GetValue());
				}
				return r_MStrongName;
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetHashCode.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
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
            var ___result = RMSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization(System.Object @sender)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender};
            var ___result = RMSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.Cryptography.RSA GetRSA()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRSA.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.RSA)___result;
        }


        public virtual void LoadKey(System.Byte[] @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMLoadKey_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RMono.RSecurity.RStrongName StrongName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMStrongName.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RMono.RSecurity.RStrongName(___result);
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
