using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography
{
	/// <summary>
	/// System.Security.Cryptography.HashAlgorithm
	/// </summary>
    public partial class RHashAlgorithm : RMember //
    {

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
		/// System.Int32 HashSizeValue
		/// </summary>
		protected RField r_HashSizeValue;
		public virtual RField RHashSizeValue
		{
			get
			{
				if(r_HashSizeValue == null)
				{
					r_HashSizeValue = new(this, "HashSizeValue");
					r_HashSizeValue.SetBelong(this.instance);
				}
				return r_HashSizeValue;
			}
		}

		/// <summary>
		/// System.Byte[] HashValue
		/// </summary>
		protected RFieldArray<RField> r_HashValue;
		public virtual RFieldArray<RField> RHashValue
		{
			get
			{
				if(r_HashValue == null)
				{
					r_HashValue = new(this, "HashValue");
					r_HashValue.SetBelong(this.instance);
				}
				return r_HashValue;
			}
		}

		/// <summary>
		/// System.Int32 State
		/// </summary>
		protected RField r_State;
		public virtual RField RState
		{
			get
			{
				if(r_State == null)
				{
					r_State = new(this, "State");
					r_State.SetBelong(this.instance);
				}
				return r_State;
			}
		}

		/// <summary>
		/// Int32 HashSize
		/// </summary>
		protected RProperty r_HashSize;
		public virtual RProperty RHashSize
		{
			get
			{
				if(r_HashSize == null)
				{
					r_HashSize = new(this, "HashSize", -1);
					r_HashSize.SetBelong(this.instance);
				}
				return r_HashSize;
			}
		}

		/// <summary>
		/// Byte[] Hash
		/// </summary>
		protected RPropertyArray<RProperty> r_Hash;
		public virtual RPropertyArray<RProperty> RHash
		{
			get
			{
				if(r_Hash == null)
				{
					r_Hash = new(this, "Hash", -1);
					r_Hash.SetBelong(this.instance);
				}
				return r_Hash;
			}
		}

		/// <summary>
		/// Int32 InputBlockSize
		/// </summary>
		protected RProperty r_InputBlockSize;
		public virtual RProperty RInputBlockSize
		{
			get
			{
				if(r_InputBlockSize == null)
				{
					r_InputBlockSize = new(this, "InputBlockSize", -1);
					r_InputBlockSize.SetBelong(this.instance);
				}
				return r_InputBlockSize;
			}
		}

		/// <summary>
		/// Int32 OutputBlockSize
		/// </summary>
		protected RProperty r_OutputBlockSize;
		public virtual RProperty ROutputBlockSize
		{
			get
			{
				if(r_OutputBlockSize == null)
				{
					r_OutputBlockSize = new(this, "OutputBlockSize", -1);
					r_OutputBlockSize.SetBelong(this.instance);
				}
				return r_OutputBlockSize;
			}
		}

		/// <summary>
		/// Boolean CanTransformMultipleBlocks
		/// </summary>
		protected RProperty r_CanTransformMultipleBlocks;
		public virtual RProperty RCanTransformMultipleBlocks
		{
			get
			{
				if(r_CanTransformMultipleBlocks == null)
				{
					r_CanTransformMultipleBlocks = new(this, "CanTransformMultipleBlocks", -1);
					r_CanTransformMultipleBlocks.SetBelong(this.instance);
				}
				return r_CanTransformMultipleBlocks;
			}
		}

		/// <summary>
		/// Boolean CanReuseTransform
		/// </summary>
		protected RProperty r_CanReuseTransform;
		public virtual RProperty RCanReuseTransform
		{
			get
			{
				if(r_CanReuseTransform == null)
				{
					r_CanReuseTransform = new(this, "CanReuseTransform", -1);
					r_CanReuseTransform.SetBelong(this.instance);
				}
				return r_CanReuseTransform;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.HashAlgorithm Create()
		/// </summary>
		protected static RMethod r_RCreate;
		public static RMethod RCreate
		{
			get
			{
				if(r_RCreate == null)
				{
					r_RCreate = new(typeof(System.Security.Cryptography.HashAlgorithm), "Create", 0);
					r_RCreate.SetBelong(null);
				}
				return r_RCreate;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.HashAlgorithm Create(System.String)
		/// </summary>
		protected static RMethod r_RCreate_String;
		public static RMethod RCreate_String
		{
			get
			{
				if(r_RCreate_String == null)
				{
					r_RCreate_String = new(typeof(System.Security.Cryptography.HashAlgorithm), "Create", 0, typeof(System.String));
					r_RCreate_String.SetBelong(null);
				}
				return r_RCreate_String;
			}
		}

		/// <summary>
		/// Byte[] ComputeHash(Byte[])
		/// </summary>
		protected RMethod r_RComputeHash_ByteArray;
		public virtual RMethod RComputeHash_ByteArray
		{
			get
			{
				if(r_RComputeHash_ByteArray == null)
				{
					r_RComputeHash_ByteArray = new(this, "ComputeHash", 0, typeof(System.Byte).MakeArrayType());
					r_RComputeHash_ByteArray.SetBelong(this.instance);
				}
				return r_RComputeHash_ByteArray;
			}
		}

		/// <summary>
		/// Boolean TryComputeHash(System.ReadOnlySpan`1[System.Byte], System.Span`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_RTryComputeHash_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__Out_Int32;
		public virtual RMethod RTryComputeHash_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_RTryComputeHash_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__Out_Int32 == null)
				{
					r_RTryComputeHash_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__Out_Int32 = new(this, "TryComputeHash", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_RTryComputeHash_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_RTryComputeHash_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// Byte[] ComputeHash(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RComputeHash_ByteArray_Int32_Int32;
		public virtual RMethod RComputeHash_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RComputeHash_ByteArray_Int32_Int32 == null)
				{
					r_RComputeHash_ByteArray_Int32_Int32 = new(this, "ComputeHash", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RComputeHash_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RComputeHash_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Byte[] ComputeHash(System.IO.Stream)
		/// </summary>
		protected RMethod r_RComputeHash_Stream;
		public virtual RMethod RComputeHash_Stream
		{
			get
			{
				if(r_RComputeHash_Stream == null)
				{
					r_RComputeHash_Stream = new(this, "ComputeHash", 0, typeof(System.IO.Stream));
					r_RComputeHash_Stream.SetBelong(this.instance);
				}
				return r_RComputeHash_Stream;
			}
		}

		/// <summary>
		/// Byte[] CaptureHashCodeAndReinitialize()
		/// </summary>
		protected RMethod r_RCaptureHashCodeAndReinitialize;
		public virtual RMethod RCaptureHashCodeAndReinitialize
		{
			get
			{
				if(r_RCaptureHashCodeAndReinitialize == null)
				{
					r_RCaptureHashCodeAndReinitialize = new(this, "CaptureHashCodeAndReinitialize", 0);
					r_RCaptureHashCodeAndReinitialize.SetBelong(this.instance);
				}
				return r_RCaptureHashCodeAndReinitialize;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_RDispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_RDispose == null)
				{
					r_RDispose = new(this, "Dispose", 0);
					r_RDispose.SetBelong(this.instance);
				}
				return r_RDispose;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_RClear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_RClear == null)
				{
					r_RClear = new(this, "Clear", 0);
					r_RClear.SetBelong(this.instance);
				}
				return r_RClear;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_RDispose_Boolean;
		public virtual RMethod RDispose_Boolean
		{
			get
			{
				if(r_RDispose_Boolean == null)
				{
					r_RDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_RDispose_Boolean.SetBelong(this.instance);
				}
				return r_RDispose_Boolean;
			}
		}

		/// <summary>
		/// Int32 TransformBlock(Byte[], Int32, Int32, Byte[], Int32)
		/// </summary>
		protected RMethod r_RTransformBlock_ByteArray_Int32_Int32_ByteArray_Int32;
		public virtual RMethod RTransformBlock_ByteArray_Int32_Int32_ByteArray_Int32
		{
			get
			{
				if(r_RTransformBlock_ByteArray_Int32_Int32_ByteArray_Int32 == null)
				{
					r_RTransformBlock_ByteArray_Int32_Int32_ByteArray_Int32 = new(this, "TransformBlock", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_RTransformBlock_ByteArray_Int32_Int32_ByteArray_Int32.SetBelong(this.instance);
				}
				return r_RTransformBlock_ByteArray_Int32_Int32_ByteArray_Int32;
			}
		}

		/// <summary>
		/// Byte[] TransformFinalBlock(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RTransformFinalBlock_ByteArray_Int32_Int32;
		public virtual RMethod RTransformFinalBlock_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RTransformFinalBlock_ByteArray_Int32_Int32 == null)
				{
					r_RTransformFinalBlock_ByteArray_Int32_Int32 = new(this, "TransformFinalBlock", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RTransformFinalBlock_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RTransformFinalBlock_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void ValidateTransformBlock(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RValidateTransformBlock_ByteArray_Int32_Int32;
		public virtual RMethod RValidateTransformBlock_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RValidateTransformBlock_ByteArray_Int32_Int32 == null)
				{
					r_RValidateTransformBlock_ByteArray_Int32_Int32 = new(this, "ValidateTransformBlock", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RValidateTransformBlock_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RValidateTransformBlock_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void HashCore(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RHashCore_ByteArray_Int32_Int32;
		public virtual RMethod RHashCore_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RHashCore_ByteArray_Int32_Int32 == null)
				{
					r_RHashCore_ByteArray_Int32_Int32 = new(this, "HashCore", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RHashCore_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RHashCore_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Byte[] HashFinal()
		/// </summary>
		protected RMethod r_RHashFinal;
		public virtual RMethod RHashFinal
		{
			get
			{
				if(r_RHashFinal == null)
				{
					r_RHashFinal = new(this, "HashFinal", 0);
					r_RHashFinal.SetBelong(this.instance);
				}
				return r_RHashFinal;
			}
		}

		/// <summary>
		/// Void Initialize()
		/// </summary>
		protected RMethod r_RInitialize;
		public virtual RMethod RInitialize
		{
			get
			{
				if(r_RInitialize == null)
				{
					r_RInitialize = new(this, "Initialize", 0);
					r_RInitialize.SetBelong(this.instance);
				}
				return r_RInitialize;
			}
		}

		/// <summary>
		/// Void HashCore(System.ReadOnlySpan`1[System.Byte])
		/// </summary>
		protected RMethod r_RHashCore_ReadOnlySpan_d_Byte_p_;
		public virtual RMethod RHashCore_ReadOnlySpan_d_Byte_p_
		{
			get
			{
				if(r_RHashCore_ReadOnlySpan_d_Byte_p_ == null)
				{
					r_RHashCore_ReadOnlySpan_d_Byte_p_ = new(this, "HashCore", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)));
					r_RHashCore_ReadOnlySpan_d_Byte_p_.SetBelong(this.instance);
				}
				return r_RHashCore_ReadOnlySpan_d_Byte_p_;
			}
		}

		/// <summary>
		/// Boolean TryHashFinal(System.Span`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_RTryHashFinal_Span_d_Byte_p__Out_Int32;
		public virtual RMethod RTryHashFinal_Span_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_RTryHashFinal_Span_d_Byte_p__Out_Int32 == null)
				{
					r_RTryHashFinal_Span_d_Byte_p__Out_Int32 = new(this, "TryHashFinal", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_RTryHashFinal_Span_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_RTryHashFinal_Span_d_Byte_p__Out_Int32;
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


        public RHashAlgorithm() : base("System.Security.Cryptography.HashAlgorithm")
        {
        }

        public RHashAlgorithm(System.Object instance) : base("System.Security.Cryptography.HashAlgorithm")
		{
            SetInstance(instance);
		}

        public RHashAlgorithm(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RHashAlgorithm(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Security.Cryptography.HashAlgorithm Create()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreate.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.HashAlgorithm)___result;
        }


        public static System.Security.Cryptography.HashAlgorithm Create(System.String  @hashName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hashName};
            var ___result = RCreate_String.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.HashAlgorithm)___result;
        }


        public virtual System.Byte[] ComputeHash(System.Byte[]  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer};
            var ___result = RComputeHash_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }



        public virtual System.Byte[] ComputeHash(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count};
            var ___result = RComputeHash_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] ComputeHash(System.IO.Stream  @inputStream)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inputStream};
            var ___result = RComputeHash_Stream.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] CaptureHashCodeAndReinitialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCaptureHashCodeAndReinitialize.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean  @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 TransformBlock(System.Byte[]  @inputBuffer, System.Int32  @inputOffset, System.Int32  @inputCount, System.Byte[]  @outputBuffer, System.Int32  @outputOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inputBuffer, @inputOffset, @inputCount, @outputBuffer, @outputOffset};
            var ___result = RTransformBlock_ByteArray_Int32_Int32_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Byte[] TransformFinalBlock(System.Byte[]  @inputBuffer, System.Int32  @inputOffset, System.Int32  @inputCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inputBuffer, @inputOffset, @inputCount};
            var ___result = RTransformFinalBlock_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual void ValidateTransformBlock(System.Byte[]  @inputBuffer, System.Int32  @inputOffset, System.Int32  @inputCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inputBuffer, @inputOffset, @inputCount};
            var ___result = RValidateTransformBlock_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HashCore(System.Byte[]  @array, System.Int32  @ibStart, System.Int32  @cbSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @ibStart, @cbSize};
            var ___result = RHashCore_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Byte[] HashFinal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHashFinal.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual void Initialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitialize.Invoke(___genericsType, ___parameters);

            
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
