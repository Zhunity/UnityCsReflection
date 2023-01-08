using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RMono.RSecurity
{
	/// <summary>
	/// Mono.Security.StrongName
	/// </summary>
    public partial class RStrongName : RMember //
    {

		/// <summary>
		/// System.Security.Cryptography.RSA rsa
		/// </summary>
		protected RSystem.RSecurity.RCryptography.RRSA r_rsa;
		public virtual RSystem.RSecurity.RCryptography.RRSA Rrsa
		{
			get
			{
				if(r_rsa == null)
				{
					r_rsa = new(this, "rsa");
					r_rsa.SetBelong(this.instance);
				}
				return r_rsa;
			}
		}

		/// <summary>
		/// System.Byte[] publicKey
		/// </summary>
		protected RFieldArray<RField> r_publicKey;
		public virtual RFieldArray<RField> RpublicKey
		{
			get
			{
				if(r_publicKey == null)
				{
					r_publicKey = new(this, "publicKey");
					r_publicKey.SetBelong(this.instance);
				}
				return r_publicKey;
			}
		}

		/// <summary>
		/// System.Byte[] keyToken
		/// </summary>
		protected RFieldArray<RField> r_keyToken;
		public virtual RFieldArray<RField> RkeyToken
		{
			get
			{
				if(r_keyToken == null)
				{
					r_keyToken = new(this, "keyToken");
					r_keyToken.SetBelong(this.instance);
				}
				return r_keyToken;
			}
		}

		/// <summary>
		/// System.String tokenAlgorithm
		/// </summary>
		protected RField r_tokenAlgorithm;
		public virtual RField RtokenAlgorithm
		{
			get
			{
				if(r_tokenAlgorithm == null)
				{
					r_tokenAlgorithm = new(this, "tokenAlgorithm");
					r_tokenAlgorithm.SetBelong(this.instance);
				}
				return r_tokenAlgorithm;
			}
		}

		/// <summary>
		/// System.Object lockObject
		/// </summary>
		protected static RSystem.RObject r_lockObject;
		public static RSystem.RObject RlockObject
		{
			get
			{
				if(r_lockObject == null)
				{
					r_lockObject = new( ReflectionUtils.GetType("Mono.Security.StrongName"), "lockObject");
					r_lockObject.SetBelong(null);
				}
				return r_lockObject;
			}
		}

		/// <summary>
		/// System.Boolean initialized
		/// </summary>
		protected static RField r_initialized;
		public static RField Rinitialized
		{
			get
			{
				if(r_initialized == null)
				{
					r_initialized = new( ReflectionUtils.GetType("Mono.Security.StrongName"), "initialized");
					r_initialized.SetBelong(null);
				}
				return r_initialized;
			}
		}

		/// <summary>
		/// Boolean CanSign
		/// </summary>
		protected RProperty r_CanSign;
		public virtual RProperty RCanSign
		{
			get
			{
				if(r_CanSign == null)
				{
					r_CanSign = new(this, "CanSign", -1);
					r_CanSign.SetBelong(this.instance);
				}
				return r_CanSign;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSA RSA
		/// </summary>
		protected RSystem.RSecurity.RCryptography.RRSA r_RSA;
		public virtual RSystem.RSecurity.RCryptography.RRSA RRSA
		{
			get
			{
				if(r_RSA == null)
				{
					r_RSA = new(this, "RSA", -1);
					r_RSA.SetBelong(this.instance);
				}
				return r_RSA;
			}
		}

		/// <summary>
		/// Byte[] PublicKey
		/// </summary>
		protected RPropertyArray<RProperty> r_PublicKey;
		public virtual RPropertyArray<RProperty> RPublicKey
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
		/// Byte[] PublicKeyToken
		/// </summary>
		protected RPropertyArray<RProperty> r_PublicKeyToken;
		public virtual RPropertyArray<RProperty> RPublicKeyToken
		{
			get
			{
				if(r_PublicKeyToken == null)
				{
					r_PublicKeyToken = new(this, "PublicKeyToken", -1);
					r_PublicKeyToken.SetBelong(this.instance);
				}
				return r_PublicKeyToken;
			}
		}

		/// <summary>
		/// System.String TokenAlgorithm
		/// </summary>
		protected RProperty r_TokenAlgorithm;
		public virtual RProperty RTokenAlgorithm
		{
			get
			{
				if(r_TokenAlgorithm == null)
				{
					r_TokenAlgorithm = new(this, "TokenAlgorithm", -1);
					r_TokenAlgorithm.SetBelong(this.instance);
				}
				return r_TokenAlgorithm;
			}
		}

		/// <summary>
		/// Void InvalidateCache()
		/// </summary>
		protected RMethod r_InvalidateCache;
		public virtual RMethod RInvalidateCache
		{
			get
			{
				if(r_InvalidateCache == null)
				{
					r_InvalidateCache = new(this, "InvalidateCache", 0);
					r_InvalidateCache.SetBelong(this.instance);
				}
				return r_InvalidateCache;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.HashAlgorithm GetHashAlgorithm(System.String)
		/// </summary>
		protected static RMethod r_GetHashAlgorithm_String;
		public static RMethod RGetHashAlgorithm_String
		{
			get
			{
				if(r_GetHashAlgorithm_String == null)
				{
					r_GetHashAlgorithm_String = new( ReflectionUtils.GetType("Mono.Security.StrongName"), "GetHashAlgorithm", 0, typeof(System.String));
					r_GetHashAlgorithm_String.SetBelong(null);
				}
				return r_GetHashAlgorithm_String;
			}
		}

		/// <summary>
		/// Byte[] GetBytes()
		/// </summary>
		protected RMethod r_GetBytes;
		public virtual RMethod RGetBytes
		{
			get
			{
				if(r_GetBytes == null)
				{
					r_GetBytes = new(this, "GetBytes", 0);
					r_GetBytes.SetBelong(this.instance);
				}
				return r_GetBytes;
			}
		}

		/// <summary>
		/// UInt32 RVAtoPosition(UInt32, Int32, Byte[])
		/// </summary>
		protected RMethod r_RVAtoPosition_UInt32_Int32_ByteArray;
		public virtual RMethod RRVAtoPosition_UInt32_Int32_ByteArray
		{
			get
			{
				if(r_RVAtoPosition_UInt32_Int32_ByteArray == null)
				{
					r_RVAtoPosition_UInt32_Int32_ByteArray = new(this, "RVAtoPosition", 0, typeof(System.UInt32), typeof(System.Int32), typeof(System.Byte).MakeArrayType());
					r_RVAtoPosition_UInt32_Int32_ByteArray.SetBelong(this.instance);
				}
				return r_RVAtoPosition_UInt32_Int32_ByteArray;
			}
		}

		/// <summary>
		/// StrongNameSignature Error(System.String)
		/// </summary>
		protected static RMethod r_Error_String;
		public static RMethod RError_String
		{
			get
			{
				if(r_Error_String == null)
				{
					r_Error_String = new( ReflectionUtils.GetType("Mono.Security.StrongName"), "Error", 0, typeof(System.String));
					r_Error_String.SetBelong(null);
				}
				return r_Error_String;
			}
		}

		/// <summary>
		/// Byte[] ReadMore(System.IO.Stream, Byte[], Int32)
		/// </summary>
		protected static RMethod r_ReadMore_Stream_ByteArray_Int32;
		public static RMethod RReadMore_Stream_ByteArray_Int32
		{
			get
			{
				if(r_ReadMore_Stream_ByteArray_Int32 == null)
				{
					r_ReadMore_Stream_ByteArray_Int32 = new( ReflectionUtils.GetType("Mono.Security.StrongName"), "ReadMore", 0, typeof(System.IO.Stream), typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_ReadMore_Stream_ByteArray_Int32.SetBelong(null);
				}
				return r_ReadMore_Stream_ByteArray_Int32;
			}
		}

		/// <summary>
		/// StrongNameSignature StrongHash(System.IO.Stream, StrongNameOptions)
		/// </summary>
		protected RMethod r_StrongHash_Stream_StrongNameOptions;
		public virtual RMethod RStrongHash_Stream_StrongNameOptions
		{
			get
			{
				if(r_StrongHash_Stream_StrongNameOptions == null)
				{
					r_StrongHash_Stream_StrongNameOptions = new(this, "StrongHash", 0, typeof(System.IO.Stream),  ReflectionUtils.GetType("Mono.Security.StrongName+StrongNameOptions"));
					r_StrongHash_Stream_StrongNameOptions.SetBelong(this.instance);
				}
				return r_StrongHash_Stream_StrongNameOptions;
			}
		}

		/// <summary>
		/// Byte[] Hash(System.String)
		/// </summary>
		protected RMethod r_Hash_String;
		public virtual RMethod RHash_String
		{
			get
			{
				if(r_Hash_String == null)
				{
					r_Hash_String = new(this, "Hash", 0, typeof(System.String));
					r_Hash_String.SetBelong(this.instance);
				}
				return r_Hash_String;
			}
		}

		/// <summary>
		/// Boolean Sign(System.String)
		/// </summary>
		protected RMethod r_Sign_String;
		public virtual RMethod RSign_String
		{
			get
			{
				if(r_Sign_String == null)
				{
					r_Sign_String = new(this, "Sign", 0, typeof(System.String));
					r_Sign_String.SetBelong(this.instance);
				}
				return r_Sign_String;
			}
		}

		/// <summary>
		/// Boolean Verify(System.String)
		/// </summary>
		protected RMethod r_Verify_String;
		public virtual RMethod RVerify_String
		{
			get
			{
				if(r_Verify_String == null)
				{
					r_Verify_String = new(this, "Verify", 0, typeof(System.String));
					r_Verify_String.SetBelong(this.instance);
				}
				return r_Verify_String;
			}
		}

		/// <summary>
		/// Boolean Verify(System.IO.Stream)
		/// </summary>
		protected RMethod r_Verify_Stream;
		public virtual RMethod RVerify_Stream
		{
			get
			{
				if(r_Verify_Stream == null)
				{
					r_Verify_Stream = new(this, "Verify", 0, typeof(System.IO.Stream));
					r_Verify_Stream.SetBelong(this.instance);
				}
				return r_Verify_Stream;
			}
		}

		/// <summary>
		/// Boolean IsAssemblyStrongnamed(System.String)
		/// </summary>
		protected static RMethod r_IsAssemblyStrongnamed_String;
		public static RMethod RIsAssemblyStrongnamed_String
		{
			get
			{
				if(r_IsAssemblyStrongnamed_String == null)
				{
					r_IsAssemblyStrongnamed_String = new( ReflectionUtils.GetType("Mono.Security.StrongName"), "IsAssemblyStrongnamed", 0, typeof(System.String));
					r_IsAssemblyStrongnamed_String.SetBelong(null);
				}
				return r_IsAssemblyStrongnamed_String;
			}
		}

		/// <summary>
		/// Boolean VerifySignature(Byte[], Int32, Byte[], Byte[])
		/// </summary>
		protected static RMethod r_VerifySignature_ByteArray_Int32_ByteArray_ByteArray;
		public static RMethod RVerifySignature_ByteArray_Int32_ByteArray_ByteArray
		{
			get
			{
				if(r_VerifySignature_ByteArray_Int32_ByteArray_ByteArray == null)
				{
					r_VerifySignature_ByteArray_Int32_ByteArray_ByteArray = new( ReflectionUtils.GetType("Mono.Security.StrongName"), "VerifySignature", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType());
					r_VerifySignature_ByteArray_Int32_ByteArray_ByteArray.SetBelong(null);
				}
				return r_VerifySignature_ByteArray_Int32_ByteArray_ByteArray;
			}
		}

		/// <summary>
		/// Boolean Verify(System.Security.Cryptography.RSA, System.Configuration.Assemblies.AssemblyHashAlgorithm, Byte[], Byte[])
		/// </summary>
		protected static RMethod r_Verify_RSA_AssemblyHashAlgorithm_ByteArray_ByteArray;
		public static RMethod RVerify_RSA_AssemblyHashAlgorithm_ByteArray_ByteArray
		{
			get
			{
				if(r_Verify_RSA_AssemblyHashAlgorithm_ByteArray_ByteArray == null)
				{
					r_Verify_RSA_AssemblyHashAlgorithm_ByteArray_ByteArray = new( ReflectionUtils.GetType("Mono.Security.StrongName"), "Verify", 0, typeof(System.Security.Cryptography.RSA), typeof(System.Configuration.Assemblies.AssemblyHashAlgorithm), typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType());
					r_Verify_RSA_AssemblyHashAlgorithm_ByteArray_ByteArray.SetBelong(null);
				}
				return r_Verify_RSA_AssemblyHashAlgorithm_ByteArray_ByteArray;
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


        public RStrongName() : base("Mono.Security.StrongName")
        {
        }

        public RStrongName(System.Object instance) : base("Mono.Security.StrongName")
		{
            SetInstance(instance);
		}

        public RStrongName(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStrongName(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void InvalidateCache()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInvalidateCache.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Security.Cryptography.HashAlgorithm GetHashAlgorithm(System.String  @algorithm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@algorithm};
            var ___result = RGetHashAlgorithm_String.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.HashAlgorithm)___result;
        }


        public virtual System.Byte[] GetBytes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetBytes.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.UInt32 RVAtoPosition(System.UInt32  @r, System.Int32  @sections, System.Byte[]  @headers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@r, @sections, @headers};
            var ___result = RRVAtoPosition_UInt32_Int32_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public static System.Object Error(System.String  @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RError_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Byte[] ReadMore(System.IO.Stream  @stream, System.Byte[]  @a, System.Int32  @newSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stream, @a, @newSize};
            var ___result = RReadMore_Stream_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Object StrongHash(System.IO.Stream  @stream, RType  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stream, @options.Value};
            var ___result = RStrongHash_Stream_StrongNameOptions.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Byte[] Hash(System.String  @fileName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileName};
            var ___result = RHash_String.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Boolean Sign(System.String  @fileName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileName};
            var ___result = RSign_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Verify(System.String  @fileName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileName};
            var ___result = RVerify_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Verify(System.IO.Stream  @stream)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stream};
            var ___result = RVerify_Stream.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsAssemblyStrongnamed(System.String  @assemblyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName};
            var ___result = RIsAssemblyStrongnamed_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean VerifySignature(System.Byte[]  @publicKey, System.Int32  @algorithm, System.Byte[]  @hash, System.Byte[]  @signature)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@publicKey, @algorithm, @hash, @signature};
            var ___result = RVerifySignature_ByteArray_Int32_ByteArray_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean Verify(System.Security.Cryptography.RSA  @rsa, System.Configuration.Assemblies.AssemblyHashAlgorithm  @algorithm, System.Byte[]  @hash, System.Byte[]  @signature)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rsa, @algorithm, @hash, @signature};
            var ___result = RVerify_RSA_AssemblyHashAlgorithm_ByteArray_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
