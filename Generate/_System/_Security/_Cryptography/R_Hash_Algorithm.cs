
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
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_F_disposed;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RF_disposed
		{
			get
			{
				if(r_F_disposed == null)
				{
					r_F_disposed = new(this, "_disposed");
					r_F_disposed.SetBelong(this.instance);
				}
				return r_F_disposed;
			}
		}

		/// <summary>
		/// System.Int32 HashSizeValue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FHashSizeValue;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFHashSizeValue
		{
			get
			{
				if(r_FHashSizeValue == null)
				{
					r_FHashSizeValue = new(this, "HashSizeValue");
					r_FHashSizeValue.SetBelong(this.instance);
				}
				return r_FHashSizeValue;
			}
		}

		/// <summary>
		/// System.Byte[] HashValue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RByte> r_FHashValue;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RByte> RFHashValue
		{
			get
			{
				if(r_FHashValue == null)
				{
					r_FHashValue = new(this, "HashValue");
					r_FHashValue.SetBelong(this.instance);
				}
				return r_FHashValue;
			}
		}

		/// <summary>
		/// System.Int32 State
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FState;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFState
		{
			get
			{
				if(r_FState == null)
				{
					r_FState = new(this, "State");
					r_FState.SetBelong(this.instance);
				}
				return r_FState;
			}
		}

		/// <summary>
		/// Int32 HashSize
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PHashSize;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPHashSize
		{
			get
			{
				if(r_PHashSize == null)
				{
					r_PHashSize = new(this, "HashSize", -1);
					r_PHashSize.SetBelong(this.instance);
				}
				return r_PHashSize;
			}
		}

		/// <summary>
		/// Byte[] Hash
		/// </summary>
		protected SMFrame.Editor.Refleaction.RPropertyArray<SMFrame.Editor.Refleaction.RSystem.RByte> r_PHash;
		public virtual SMFrame.Editor.Refleaction.RPropertyArray<SMFrame.Editor.Refleaction.RSystem.RByte> RPHash
		{
			get
			{
				if(r_PHash == null)
				{
					r_PHash = new(this, "Hash", -1);
					r_PHash.SetBelong(this.instance);
				}
				return r_PHash;
			}
		}

		/// <summary>
		/// Int32 InputBlockSize
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PInputBlockSize;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPInputBlockSize
		{
			get
			{
				if(r_PInputBlockSize == null)
				{
					r_PInputBlockSize = new(this, "InputBlockSize", -1);
					r_PInputBlockSize.SetBelong(this.instance);
				}
				return r_PInputBlockSize;
			}
		}

		/// <summary>
		/// Int32 OutputBlockSize
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_POutputBlockSize;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPOutputBlockSize
		{
			get
			{
				if(r_POutputBlockSize == null)
				{
					r_POutputBlockSize = new(this, "OutputBlockSize", -1);
					r_POutputBlockSize.SetBelong(this.instance);
				}
				return r_POutputBlockSize;
			}
		}

		/// <summary>
		/// Boolean CanTransformMultipleBlocks
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PCanTransformMultipleBlocks;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPCanTransformMultipleBlocks
		{
			get
			{
				if(r_PCanTransformMultipleBlocks == null)
				{
					r_PCanTransformMultipleBlocks = new(this, "CanTransformMultipleBlocks", -1);
					r_PCanTransformMultipleBlocks.SetBelong(this.instance);
				}
				return r_PCanTransformMultipleBlocks;
			}
		}

		/// <summary>
		/// Boolean CanReuseTransform
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PCanReuseTransform;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPCanReuseTransform
		{
			get
			{
				if(r_PCanReuseTransform == null)
				{
					r_PCanReuseTransform = new(this, "CanReuseTransform", -1);
					r_PCanReuseTransform.SetBelong(this.instance);
				}
				return r_PCanReuseTransform;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.HashAlgorithm Create()
		/// </summary>
		protected static RMethod r_MCreate;
		public static RMethod RMCreate
		{
			get
			{
				if(r_MCreate == null)
				{
					r_MCreate = new(typeof(System.Security.Cryptography.HashAlgorithm), "Create", 0);
					r_MCreate.SetBelong(null);
				}
				return r_MCreate;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.HashAlgorithm Create(System.String)
		/// </summary>
		protected static RMethod r_MCreate_String;
		public static RMethod RMCreate_String
		{
			get
			{
				if(r_MCreate_String == null)
				{
					r_MCreate_String = new(typeof(System.Security.Cryptography.HashAlgorithm), "Create", 0, typeof(System.String));
					r_MCreate_String.SetBelong(null);
				}
				return r_MCreate_String;
			}
		}

		/// <summary>
		/// Byte[] ComputeHash(Byte[])
		/// </summary>
		protected RMethod r_MComputeHash_ByteArray;
		public virtual RMethod RMComputeHash_ByteArray
		{
			get
			{
				if(r_MComputeHash_ByteArray == null)
				{
					r_MComputeHash_ByteArray = new(this, "ComputeHash", 0, typeof(System.Byte).MakeArrayType());
					r_MComputeHash_ByteArray.SetBelong(this.instance);
				}
				return r_MComputeHash_ByteArray;
			}
		}

		/// <summary>
		/// Boolean TryComputeHash(System.ReadOnlySpan`1[System.Byte], System.Span`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_MTryComputeHash_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__Out_Int32;
		public virtual RMethod RMTryComputeHash_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_MTryComputeHash_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__Out_Int32 == null)
				{
					r_MTryComputeHash_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__Out_Int32 = new(this, "TryComputeHash", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_MTryComputeHash_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_MTryComputeHash_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// Byte[] ComputeHash(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_MComputeHash_ByteArray_Int32_Int32;
		public virtual RMethod RMComputeHash_ByteArray_Int32_Int32
		{
			get
			{
				if(r_MComputeHash_ByteArray_Int32_Int32 == null)
				{
					r_MComputeHash_ByteArray_Int32_Int32 = new(this, "ComputeHash", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MComputeHash_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_MComputeHash_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Byte[] ComputeHash(System.IO.Stream)
		/// </summary>
		protected RMethod r_MComputeHash_Stream;
		public virtual RMethod RMComputeHash_Stream
		{
			get
			{
				if(r_MComputeHash_Stream == null)
				{
					r_MComputeHash_Stream = new(this, "ComputeHash", 0, typeof(System.IO.Stream));
					r_MComputeHash_Stream.SetBelong(this.instance);
				}
				return r_MComputeHash_Stream;
			}
		}

		/// <summary>
		/// Byte[] CaptureHashCodeAndReinitialize()
		/// </summary>
		protected RMethod r_MCaptureHashCodeAndReinitialize;
		public virtual RMethod RMCaptureHashCodeAndReinitialize
		{
			get
			{
				if(r_MCaptureHashCodeAndReinitialize == null)
				{
					r_MCaptureHashCodeAndReinitialize = new(this, "CaptureHashCodeAndReinitialize", 0);
					r_MCaptureHashCodeAndReinitialize.SetBelong(this.instance);
				}
				return r_MCaptureHashCodeAndReinitialize;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_MDispose;
		public virtual RMethod RMDispose
		{
			get
			{
				if(r_MDispose == null)
				{
					r_MDispose = new(this, "Dispose", 0);
					r_MDispose.SetBelong(this.instance);
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_MClear;
		public virtual RMethod RMClear
		{
			get
			{
				if(r_MClear == null)
				{
					r_MClear = new(this, "Clear", 0);
					r_MClear.SetBelong(this.instance);
				}
				return r_MClear;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_MDispose_Boolean;
		public virtual RMethod RMDispose_Boolean
		{
			get
			{
				if(r_MDispose_Boolean == null)
				{
					r_MDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_MDispose_Boolean.SetBelong(this.instance);
				}
				return r_MDispose_Boolean;
			}
		}

		/// <summary>
		/// Int32 TransformBlock(Byte[], Int32, Int32, Byte[], Int32)
		/// </summary>
		protected RMethod r_MTransformBlock_ByteArray_Int32_Int32_ByteArray_Int32;
		public virtual RMethod RMTransformBlock_ByteArray_Int32_Int32_ByteArray_Int32
		{
			get
			{
				if(r_MTransformBlock_ByteArray_Int32_Int32_ByteArray_Int32 == null)
				{
					r_MTransformBlock_ByteArray_Int32_Int32_ByteArray_Int32 = new(this, "TransformBlock", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_MTransformBlock_ByteArray_Int32_Int32_ByteArray_Int32.SetBelong(this.instance);
				}
				return r_MTransformBlock_ByteArray_Int32_Int32_ByteArray_Int32;
			}
		}

		/// <summary>
		/// Byte[] TransformFinalBlock(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_MTransformFinalBlock_ByteArray_Int32_Int32;
		public virtual RMethod RMTransformFinalBlock_ByteArray_Int32_Int32
		{
			get
			{
				if(r_MTransformFinalBlock_ByteArray_Int32_Int32 == null)
				{
					r_MTransformFinalBlock_ByteArray_Int32_Int32 = new(this, "TransformFinalBlock", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MTransformFinalBlock_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_MTransformFinalBlock_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void ValidateTransformBlock(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_MValidateTransformBlock_ByteArray_Int32_Int32;
		public virtual RMethod RMValidateTransformBlock_ByteArray_Int32_Int32
		{
			get
			{
				if(r_MValidateTransformBlock_ByteArray_Int32_Int32 == null)
				{
					r_MValidateTransformBlock_ByteArray_Int32_Int32 = new(this, "ValidateTransformBlock", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MValidateTransformBlock_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_MValidateTransformBlock_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void HashCore(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_MHashCore_ByteArray_Int32_Int32;
		public virtual RMethod RMHashCore_ByteArray_Int32_Int32
		{
			get
			{
				if(r_MHashCore_ByteArray_Int32_Int32 == null)
				{
					r_MHashCore_ByteArray_Int32_Int32 = new(this, "HashCore", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MHashCore_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_MHashCore_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Byte[] HashFinal()
		/// </summary>
		protected RMethod r_MHashFinal;
		public virtual RMethod RMHashFinal
		{
			get
			{
				if(r_MHashFinal == null)
				{
					r_MHashFinal = new(this, "HashFinal", 0);
					r_MHashFinal.SetBelong(this.instance);
				}
				return r_MHashFinal;
			}
		}

		/// <summary>
		/// Void Initialize()
		/// </summary>
		protected RMethod r_MInitialize;
		public virtual RMethod RMInitialize
		{
			get
			{
				if(r_MInitialize == null)
				{
					r_MInitialize = new(this, "Initialize", 0);
					r_MInitialize.SetBelong(this.instance);
				}
				return r_MInitialize;
			}
		}

		/// <summary>
		/// Void HashCore(System.ReadOnlySpan`1[System.Byte])
		/// </summary>
		protected RMethod r_MHashCore_ReadOnlySpan_d_Byte_p_;
		public virtual RMethod RMHashCore_ReadOnlySpan_d_Byte_p_
		{
			get
			{
				if(r_MHashCore_ReadOnlySpan_d_Byte_p_ == null)
				{
					r_MHashCore_ReadOnlySpan_d_Byte_p_ = new(this, "HashCore", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)));
					r_MHashCore_ReadOnlySpan_d_Byte_p_.SetBelong(this.instance);
				}
				return r_MHashCore_ReadOnlySpan_d_Byte_p_;
			}
		}

		/// <summary>
		/// Boolean TryHashFinal(System.Span`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_MTryHashFinal_Span_d_Byte_p__Out_Int32;
		public virtual RMethod RMTryHashFinal_Span_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_MTryHashFinal_Span_d_Byte_p__Out_Int32 == null)
				{
					r_MTryHashFinal_Span_d_Byte_p__Out_Int32 = new(this, "TryHashFinal", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_MTryHashFinal_Span_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_MTryHashFinal_Span_d_Byte_p__Out_Int32;
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
            var ___result = RMCreate.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.HashAlgorithm)___result;
        }


        public static System.Security.Cryptography.HashAlgorithm Create(System.String @hashName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hashName};
            var ___result = RMCreate_String.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.HashAlgorithm)___result;
        }


        public virtual System.Byte[] ComputeHash(System.Byte[] @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer};
            var ___result = RMComputeHash_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Boolean TryComputeHash(SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RSystem.RByte> @source, SMFrame.Editor.Refleaction.RSystem.RSpan<SMFrame.Editor.Refleaction.RSystem.RByte> @destination, out System.Int32 @bytesWritten)
        {
			@bytesWritten = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source.Value, @destination.Value, @bytesWritten};
            var ___result = RMTryComputeHash_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__Out_Int32.Invoke(___genericsType, ___parameters);
			@bytesWritten = (System.Int32)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual System.Byte[] ComputeHash(System.Byte[] @buffer, System.Int32 @offset, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count};
            var ___result = RMComputeHash_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] ComputeHash(System.IO.Stream @inputStream)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inputStream};
            var ___result = RMComputeHash_Stream.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] CaptureHashCodeAndReinitialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCaptureHashCodeAndReinitialize.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RMDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 TransformBlock(System.Byte[] @inputBuffer, System.Int32 @inputOffset, System.Int32 @inputCount, System.Byte[] @outputBuffer, System.Int32 @outputOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inputBuffer, @inputOffset, @inputCount, @outputBuffer, @outputOffset};
            var ___result = RMTransformBlock_ByteArray_Int32_Int32_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Byte[] TransformFinalBlock(System.Byte[] @inputBuffer, System.Int32 @inputOffset, System.Int32 @inputCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inputBuffer, @inputOffset, @inputCount};
            var ___result = RMTransformFinalBlock_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual void ValidateTransformBlock(System.Byte[] @inputBuffer, System.Int32 @inputOffset, System.Int32 @inputCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inputBuffer, @inputOffset, @inputCount};
            var ___result = RMValidateTransformBlock_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HashCore(System.Byte[] @array, System.Int32 @ibStart, System.Int32 @cbSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @ibStart, @cbSize};
            var ___result = RMHashCore_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Byte[] HashFinal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHashFinal.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual void Initialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HashCore(SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RSystem.RByte> @source)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source.Value};
            var ___result = RMHashCore_ReadOnlySpan_d_Byte_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryHashFinal(SMFrame.Editor.Refleaction.RSystem.RSpan<SMFrame.Editor.Refleaction.RSystem.RByte> @destination, out System.Int32 @bytesWritten)
        {
			@bytesWritten = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination.Value, @bytesWritten};
            var ___result = RMTryHashFinal_Span_d_Byte_p__Out_Int32.Invoke(___genericsType, ___parameters);
			@bytesWritten = (System.Int32)___parameters[1];

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
