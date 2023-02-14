
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RMono.RSecurity
{
	/// <summary>
	/// Mono.Security.StrongName
	/// </summary>
    public partial class RStrongName : RMember //
    {

		/// <summary>
		/// System.Security.Cryptography.RSA rsa
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSA r_Frsa;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSA RFrsa
		{
			get
			{
				if(r_Frsa == null)
				{
					r_Frsa = new(this, "rsa");
					r_Frsa.SetBelong(this.instance);
				}
				return r_Frsa;
			}
		}

		/// <summary>
		/// System.Byte[] publicKey
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> r_FpublicKey;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> RFpublicKey
		{
			get
			{
				if(r_FpublicKey == null)
				{
					r_FpublicKey = new(this, "publicKey");
					r_FpublicKey.SetBelong(this.instance);
				}
				return r_FpublicKey;
			}
		}

		/// <summary>
		/// System.Byte[] keyToken
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> r_FkeyToken;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> RFkeyToken
		{
			get
			{
				if(r_FkeyToken == null)
				{
					r_FkeyToken = new(this, "keyToken");
					r_FkeyToken.SetBelong(this.instance);
				}
				return r_FkeyToken;
			}
		}

		/// <summary>
		/// System.String tokenAlgorithm
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FtokenAlgorithm;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFtokenAlgorithm
		{
			get
			{
				if(r_FtokenAlgorithm == null)
				{
					r_FtokenAlgorithm = new(this, "tokenAlgorithm");
					r_FtokenAlgorithm.SetBelong(this.instance);
				}
				return r_FtokenAlgorithm;
			}
		}

		/// <summary>
		/// System.Object lockObject
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RObject r_FlockObject;
		public static Hvak.Editor.Refleaction.RSystem.RObject RFlockObject
		{
			get
			{
				if(r_FlockObject == null)
				{
					r_FlockObject = new( ReflectionUtils.GetType("Mono.Security.StrongName"), "lockObject");
					r_FlockObject.SetBelong(null);
				}
				return r_FlockObject;
			}
		}

		/// <summary>
		/// System.Boolean initialized
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RBoolean r_Finitialized;
		public static Hvak.Editor.Refleaction.RSystem.RBoolean RFinitialized
		{
			get
			{
				if(r_Finitialized == null)
				{
					r_Finitialized = new( ReflectionUtils.GetType("Mono.Security.StrongName"), "initialized");
					r_Finitialized.SetBelong(null);
				}
				return r_Finitialized;
			}
		}

		/// <summary>
		/// Boolean CanSign
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PCanSign;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPCanSign
		{
			get
			{
				if(r_PCanSign == null)
				{
					r_PCanSign = new(this, "CanSign", -1);
					r_PCanSign.SetBelong(this.instance);
				}
				return r_PCanSign;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSA RSA
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSA r_PRSA;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSA RPRSA
		{
			get
			{
				if(r_PRSA == null)
				{
					r_PRSA = new(this, "RSA", -1);
					r_PRSA.SetBelong(this.instance);
				}
				return r_PRSA;
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
					r_PPublicKey.SetBelong(this.instance);
				}
				return r_PPublicKey;
			}
		}

		/// <summary>
		/// Byte[] PublicKeyToken
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RByte> r_PPublicKeyToken;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RByte> RPPublicKeyToken
		{
			get
			{
				if(r_PPublicKeyToken == null)
				{
					r_PPublicKeyToken = new(this, "PublicKeyToken", -1);
					r_PPublicKeyToken.SetBelong(this.instance);
				}
				return r_PPublicKeyToken;
			}
		}

		/// <summary>
		/// System.String TokenAlgorithm
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PTokenAlgorithm;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPTokenAlgorithm
		{
			get
			{
				if(r_PTokenAlgorithm == null)
				{
					r_PTokenAlgorithm = new(this, "TokenAlgorithm", -1);
					r_PTokenAlgorithm.SetBelong(this.instance);
				}
				return r_PTokenAlgorithm;
			}
		}

		/// <summary>
		/// Void InvalidateCache()
		/// </summary>
		protected RMethod r_MInvalidateCache;
		public virtual RMethod RMInvalidateCache
		{
			get
			{
				if(r_MInvalidateCache == null)
				{
					r_MInvalidateCache = new(this, "InvalidateCache", 0);
					r_MInvalidateCache.SetBelong(this.instance);
				}
				return r_MInvalidateCache;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.HashAlgorithm GetHashAlgorithm(System.String)
		/// </summary>
		protected static RMethod r_MGetHashAlgorithm_String;
		public static RMethod RMGetHashAlgorithm_String
		{
			get
			{
				if(r_MGetHashAlgorithm_String == null)
				{
					r_MGetHashAlgorithm_String = new( ReflectionUtils.GetType("Mono.Security.StrongName"), "GetHashAlgorithm", 0, typeof(System.String));
					r_MGetHashAlgorithm_String.SetBelong(null);
				}
				return r_MGetHashAlgorithm_String;
			}
		}

		/// <summary>
		/// Byte[] GetBytes()
		/// </summary>
		protected RMethod r_MGetBytes;
		public virtual RMethod RMGetBytes
		{
			get
			{
				if(r_MGetBytes == null)
				{
					r_MGetBytes = new(this, "GetBytes", 0);
					r_MGetBytes.SetBelong(this.instance);
				}
				return r_MGetBytes;
			}
		}

		/// <summary>
		/// UInt32 RVAtoPosition(UInt32, Int32, Byte[])
		/// </summary>
		protected RMethod r_MRVAtoPosition_UInt32_Int32_ByteArray;
		public virtual RMethod RMRVAtoPosition_UInt32_Int32_ByteArray
		{
			get
			{
				if(r_MRVAtoPosition_UInt32_Int32_ByteArray == null)
				{
					r_MRVAtoPosition_UInt32_Int32_ByteArray = new(this, "RVAtoPosition", 0, typeof(System.UInt32), typeof(System.Int32), typeof(System.Byte).MakeArrayType());
					r_MRVAtoPosition_UInt32_Int32_ByteArray.SetBelong(this.instance);
				}
				return r_MRVAtoPosition_UInt32_Int32_ByteArray;
			}
		}

		/// <summary>
		/// StrongNameSignature Error(System.String)
		/// </summary>
		protected static RMethod r_MError_String;
		public static RMethod RMError_String
		{
			get
			{
				if(r_MError_String == null)
				{
					r_MError_String = new( ReflectionUtils.GetType("Mono.Security.StrongName"), "Error", 0, typeof(System.String));
					r_MError_String.SetBelong(null);
				}
				return r_MError_String;
			}
		}

		/// <summary>
		/// Byte[] ReadMore(System.IO.Stream, Byte[], Int32)
		/// </summary>
		protected static RMethod r_MReadMore_Stream_ByteArray_Int32;
		public static RMethod RMReadMore_Stream_ByteArray_Int32
		{
			get
			{
				if(r_MReadMore_Stream_ByteArray_Int32 == null)
				{
					r_MReadMore_Stream_ByteArray_Int32 = new( ReflectionUtils.GetType("Mono.Security.StrongName"), "ReadMore", 0, typeof(System.IO.Stream), typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_MReadMore_Stream_ByteArray_Int32.SetBelong(null);
				}
				return r_MReadMore_Stream_ByteArray_Int32;
			}
		}

		/// <summary>
		/// StrongNameSignature StrongHash(System.IO.Stream, StrongNameOptions)
		/// </summary>
		protected RMethod r_MStrongHash_Stream_StrongNameOptions;
		public virtual RMethod RMStrongHash_Stream_StrongNameOptions
		{
			get
			{
				if(r_MStrongHash_Stream_StrongNameOptions == null)
				{
					r_MStrongHash_Stream_StrongNameOptions = new(this, "StrongHash", 0, typeof(System.IO.Stream),  ReflectionUtils.GetType("Mono.Security.StrongName+StrongNameOptions"));
					r_MStrongHash_Stream_StrongNameOptions.SetBelong(this.instance);
				}
				return r_MStrongHash_Stream_StrongNameOptions;
			}
		}

		/// <summary>
		/// Byte[] Hash(System.String)
		/// </summary>
		protected RMethod r_MHash_String;
		public virtual RMethod RMHash_String
		{
			get
			{
				if(r_MHash_String == null)
				{
					r_MHash_String = new(this, "Hash", 0, typeof(System.String));
					r_MHash_String.SetBelong(this.instance);
				}
				return r_MHash_String;
			}
		}

		/// <summary>
		/// Boolean Sign(System.String)
		/// </summary>
		protected RMethod r_MSign_String;
		public virtual RMethod RMSign_String
		{
			get
			{
				if(r_MSign_String == null)
				{
					r_MSign_String = new(this, "Sign", 0, typeof(System.String));
					r_MSign_String.SetBelong(this.instance);
				}
				return r_MSign_String;
			}
		}

		/// <summary>
		/// Boolean Verify(System.String)
		/// </summary>
		protected RMethod r_MVerify_String;
		public virtual RMethod RMVerify_String
		{
			get
			{
				if(r_MVerify_String == null)
				{
					r_MVerify_String = new(this, "Verify", 0, typeof(System.String));
					r_MVerify_String.SetBelong(this.instance);
				}
				return r_MVerify_String;
			}
		}

		/// <summary>
		/// Boolean Verify(System.IO.Stream)
		/// </summary>
		protected RMethod r_MVerify_Stream;
		public virtual RMethod RMVerify_Stream
		{
			get
			{
				if(r_MVerify_Stream == null)
				{
					r_MVerify_Stream = new(this, "Verify", 0, typeof(System.IO.Stream));
					r_MVerify_Stream.SetBelong(this.instance);
				}
				return r_MVerify_Stream;
			}
		}

		/// <summary>
		/// Boolean IsAssemblyStrongnamed(System.String)
		/// </summary>
		protected static RMethod r_MIsAssemblyStrongnamed_String;
		public static RMethod RMIsAssemblyStrongnamed_String
		{
			get
			{
				if(r_MIsAssemblyStrongnamed_String == null)
				{
					r_MIsAssemblyStrongnamed_String = new( ReflectionUtils.GetType("Mono.Security.StrongName"), "IsAssemblyStrongnamed", 0, typeof(System.String));
					r_MIsAssemblyStrongnamed_String.SetBelong(null);
				}
				return r_MIsAssemblyStrongnamed_String;
			}
		}

		/// <summary>
		/// Boolean VerifySignature(Byte[], Int32, Byte[], Byte[])
		/// </summary>
		protected static RMethod r_MVerifySignature_ByteArray_Int32_ByteArray_ByteArray;
		public static RMethod RMVerifySignature_ByteArray_Int32_ByteArray_ByteArray
		{
			get
			{
				if(r_MVerifySignature_ByteArray_Int32_ByteArray_ByteArray == null)
				{
					r_MVerifySignature_ByteArray_Int32_ByteArray_ByteArray = new( ReflectionUtils.GetType("Mono.Security.StrongName"), "VerifySignature", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType());
					r_MVerifySignature_ByteArray_Int32_ByteArray_ByteArray.SetBelong(null);
				}
				return r_MVerifySignature_ByteArray_Int32_ByteArray_ByteArray;
			}
		}

		/// <summary>
		/// Boolean Verify(System.Security.Cryptography.RSA, System.Configuration.Assemblies.AssemblyHashAlgorithm, Byte[], Byte[])
		/// </summary>
		protected static RMethod r_MVerify_RSA_AssemblyHashAlgorithm_ByteArray_ByteArray;
		public static RMethod RMVerify_RSA_AssemblyHashAlgorithm_ByteArray_ByteArray
		{
			get
			{
				if(r_MVerify_RSA_AssemblyHashAlgorithm_ByteArray_ByteArray == null)
				{
					r_MVerify_RSA_AssemblyHashAlgorithm_ByteArray_ByteArray = new( ReflectionUtils.GetType("Mono.Security.StrongName"), "Verify", 0, typeof(System.Security.Cryptography.RSA), typeof(System.Configuration.Assemblies.AssemblyHashAlgorithm), typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType());
					r_MVerify_RSA_AssemblyHashAlgorithm_ByteArray_ByteArray.SetBelong(null);
				}
				return r_MVerify_RSA_AssemblyHashAlgorithm_ByteArray_ByteArray;
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
            var ___result = RMInvalidateCache.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Security.Cryptography.HashAlgorithm GetHashAlgorithm(System.String @algorithm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@algorithm};
            var ___result = RMGetHashAlgorithm_String.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.HashAlgorithm)___result;
        }


        public virtual System.Byte[] GetBytes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetBytes.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.UInt32 RVAtoPosition(System.UInt32 @r, System.Int32 @sections, System.Byte[] @headers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@r, @sections, @headers};
            var ___result = RMRVAtoPosition_UInt32_Int32_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public static Hvak.Editor.Refleaction.RMono.RSecurity.RStrongName.RStrongNameSignature Error(System.String @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RMError_String.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RMono.RSecurity.RStrongName.RStrongNameSignature(___result);
        }


        public static System.Byte[] ReadMore(System.IO.Stream @stream, System.Byte[] @a, System.Int32 @newSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stream, @a, @newSize};
            var ___result = RMReadMore_Stream_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual Hvak.Editor.Refleaction.RMono.RSecurity.RStrongName.RStrongNameSignature StrongHash(System.IO.Stream @stream, Hvak.Editor.Refleaction.RMono.RSecurity.RStrongName.RStrongNameOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stream, @options.Value};
            var ___result = RMStrongHash_Stream_StrongNameOptions.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RMono.RSecurity.RStrongName.RStrongNameSignature(___result);
        }


        public virtual System.Byte[] Hash(System.String @fileName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileName};
            var ___result = RMHash_String.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Boolean Sign(System.String @fileName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileName};
            var ___result = RMSign_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Verify(System.String @fileName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileName};
            var ___result = RMVerify_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Verify(System.IO.Stream @stream)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stream};
            var ___result = RMVerify_Stream.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsAssemblyStrongnamed(System.String @assemblyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName};
            var ___result = RMIsAssemblyStrongnamed_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean VerifySignature(System.Byte[] @publicKey, System.Int32 @algorithm, System.Byte[] @hash, System.Byte[] @signature)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@publicKey, @algorithm, @hash, @signature};
            var ___result = RMVerifySignature_ByteArray_Int32_ByteArray_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean Verify(System.Security.Cryptography.RSA @rsa, System.Configuration.Assemblies.AssemblyHashAlgorithm @algorithm, System.Byte[] @hash, System.Byte[] @signature)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rsa, @algorithm, @hash, @signature};
            var ___result = RMVerify_RSA_AssemblyHashAlgorithm_ByteArray_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
