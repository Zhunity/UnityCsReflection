using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RText
{
	/// <summary>
	/// System.Text.Encoder
	/// </summary>
    public partial class REncoder : RMember //
    {

		/// <summary>
		/// System.Text.EncoderFallback _fallback
		/// </summary>
		protected RSystem.RText.REncoderFallback r__fallback;
		public virtual RSystem.RText.REncoderFallback R_fallback
		{
			get
			{
				if(r__fallback == null)
				{
					r__fallback = new(this, "_fallback");
					r__fallback.SetBelong(this.instance);
				}
				return r__fallback;
			}
		}

		/// <summary>
		/// System.Text.EncoderFallbackBuffer _fallbackBuffer
		/// </summary>
		protected RSystem.RText.REncoderFallbackBuffer r__fallbackBuffer;
		public virtual RSystem.RText.REncoderFallbackBuffer R_fallbackBuffer
		{
			get
			{
				if(r__fallbackBuffer == null)
				{
					r__fallbackBuffer = new(this, "_fallbackBuffer");
					r__fallbackBuffer.SetBelong(this.instance);
				}
				return r__fallbackBuffer;
			}
		}

		/// <summary>
		/// System.Text.EncoderFallback Fallback
		/// </summary>
		protected RSystem.RText.REncoderFallback r_Fallback;
		public virtual RSystem.RText.REncoderFallback RFallback
		{
			get
			{
				if(r_Fallback == null)
				{
					r_Fallback = new(this, "Fallback", -1);
					r_Fallback.SetBelong(this.instance);
				}
				return r_Fallback;
			}
		}

		/// <summary>
		/// System.Text.EncoderFallbackBuffer FallbackBuffer
		/// </summary>
		protected RSystem.RText.REncoderFallbackBuffer r_FallbackBuffer;
		public virtual RSystem.RText.REncoderFallbackBuffer RFallbackBuffer
		{
			get
			{
				if(r_FallbackBuffer == null)
				{
					r_FallbackBuffer = new(this, "FallbackBuffer", -1);
					r_FallbackBuffer.SetBelong(this.instance);
				}
				return r_FallbackBuffer;
			}
		}

		/// <summary>
		/// Boolean InternalHasFallbackBuffer
		/// </summary>
		protected RProperty r_InternalHasFallbackBuffer;
		public virtual RProperty RInternalHasFallbackBuffer
		{
			get
			{
				if(r_InternalHasFallbackBuffer == null)
				{
					r_InternalHasFallbackBuffer = new(this, "InternalHasFallbackBuffer", -1);
					r_InternalHasFallbackBuffer.SetBelong(this.instance);
				}
				return r_InternalHasFallbackBuffer;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_Reset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_Reset == null)
				{
					r_Reset = new(this, "Reset", 0);
					r_Reset.SetBelong(this.instance);
				}
				return r_Reset;
			}
		}

		/// <summary>
		/// Int32 GetByteCount(Char[], Int32, Int32, Boolean)
		/// </summary>
		protected RMethod r_GetByteCount_CharArray_Int32_Int32_Boolean;
		public virtual RMethod RGetByteCount_CharArray_Int32_Int32_Boolean
		{
			get
			{
				if(r_GetByteCount_CharArray_Int32_Int32_Boolean == null)
				{
					r_GetByteCount_CharArray_Int32_Int32_Boolean = new(this, "GetByteCount", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_GetByteCount_CharArray_Int32_Int32_Boolean.SetBelong(this.instance);
				}
				return r_GetByteCount_CharArray_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 GetByteCount(Char*, Int32, Boolean)
		/// </summary>
		protected RMethod r_GetByteCount_CharPointer_Int32_Boolean;
		public virtual RMethod RGetByteCount_CharPointer_Int32_Boolean
		{
			get
			{
				if(r_GetByteCount_CharPointer_Int32_Boolean == null)
				{
					r_GetByteCount_CharPointer_Int32_Boolean = new(this, "GetByteCount", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Boolean));
					r_GetByteCount_CharPointer_Int32_Boolean.SetBelong(this.instance);
				}
				return r_GetByteCount_CharPointer_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 GetByteCount(System.ReadOnlySpan`1[System.Char], Boolean)
		/// </summary>
		protected RMethod r_GetByteCount_ReadOnlySpan_d_Char_p__Boolean;
		public virtual RMethod RGetByteCount_ReadOnlySpan_d_Char_p__Boolean
		{
			get
			{
				if(r_GetByteCount_ReadOnlySpan_d_Char_p__Boolean == null)
				{
					r_GetByteCount_ReadOnlySpan_d_Char_p__Boolean = new(this, "GetByteCount", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Boolean));
					r_GetByteCount_ReadOnlySpan_d_Char_p__Boolean.SetBelong(this.instance);
				}
				return r_GetByteCount_ReadOnlySpan_d_Char_p__Boolean;
			}
		}

		/// <summary>
		/// Int32 GetBytes(Char[], Int32, Int32, Byte[], Int32, Boolean)
		/// </summary>
		protected RMethod r_GetBytes_CharArray_Int32_Int32_ByteArray_Int32_Boolean;
		public virtual RMethod RGetBytes_CharArray_Int32_Int32_ByteArray_Int32_Boolean
		{
			get
			{
				if(r_GetBytes_CharArray_Int32_Int32_ByteArray_Int32_Boolean == null)
				{
					r_GetBytes_CharArray_Int32_Int32_ByteArray_Int32_Boolean = new(this, "GetBytes", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean));
					r_GetBytes_CharArray_Int32_Int32_ByteArray_Int32_Boolean.SetBelong(this.instance);
				}
				return r_GetBytes_CharArray_Int32_Int32_ByteArray_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 GetBytes(Char*, Int32, Byte*, Int32, Boolean)
		/// </summary>
		protected RMethod r_GetBytes_CharPointer_Int32_BytePointer_Int32_Boolean;
		public virtual RMethod RGetBytes_CharPointer_Int32_BytePointer_Int32_Boolean
		{
			get
			{
				if(r_GetBytes_CharPointer_Int32_BytePointer_Int32_Boolean == null)
				{
					r_GetBytes_CharPointer_Int32_BytePointer_Int32_Boolean = new(this, "GetBytes", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Byte).MakePointerType(), typeof(System.Int32), typeof(System.Boolean));
					r_GetBytes_CharPointer_Int32_BytePointer_Int32_Boolean.SetBelong(this.instance);
				}
				return r_GetBytes_CharPointer_Int32_BytePointer_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 GetBytes(System.ReadOnlySpan`1[System.Char], System.Span`1[System.Byte], Boolean)
		/// </summary>
		protected RMethod r_GetBytes_ReadOnlySpan_d_Char_p__Span_d_Byte_p__Boolean;
		public virtual RMethod RGetBytes_ReadOnlySpan_d_Char_p__Span_d_Byte_p__Boolean
		{
			get
			{
				if(r_GetBytes_ReadOnlySpan_d_Char_p__Span_d_Byte_p__Boolean == null)
				{
					r_GetBytes_ReadOnlySpan_d_Char_p__Span_d_Byte_p__Boolean = new(this, "GetBytes", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Boolean));
					r_GetBytes_ReadOnlySpan_d_Char_p__Span_d_Byte_p__Boolean.SetBelong(this.instance);
				}
				return r_GetBytes_ReadOnlySpan_d_Char_p__Span_d_Byte_p__Boolean;
			}
		}

		/// <summary>
		/// Void Convert(Char[], Int32, Int32, Byte[], Int32, Int32, Boolean, Int32 ByRef, Int32 ByRef, Boolean ByRef)
		/// </summary>
		protected RMethod r_Convert_CharArray_Int32_Int32_ByteArray_Int32_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean;
		public virtual RMethod RConvert_CharArray_Int32_Int32_ByteArray_Int32_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean
		{
			get
			{
				if(r_Convert_CharArray_Int32_Int32_ByteArray_Int32_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean == null)
				{
					r_Convert_CharArray_Int32_Int32_ByteArray_Int32_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean = new(this, "Convert", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Boolean).MakeByRefType());
					r_Convert_CharArray_Int32_Int32_ByteArray_Int32_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean.SetBelong(this.instance);
				}
				return r_Convert_CharArray_Int32_Int32_ByteArray_Int32_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean;
			}
		}

		/// <summary>
		/// Void Convert(Char*, Int32, Byte*, Int32, Boolean, Int32 ByRef, Int32 ByRef, Boolean ByRef)
		/// </summary>
		protected RMethod r_Convert_CharPointer_Int32_BytePointer_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean;
		public virtual RMethod RConvert_CharPointer_Int32_BytePointer_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean
		{
			get
			{
				if(r_Convert_CharPointer_Int32_BytePointer_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean == null)
				{
					r_Convert_CharPointer_Int32_BytePointer_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean = new(this, "Convert", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Byte).MakePointerType(), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Boolean).MakeByRefType());
					r_Convert_CharPointer_Int32_BytePointer_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean.SetBelong(this.instance);
				}
				return r_Convert_CharPointer_Int32_BytePointer_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean;
			}
		}

		/// <summary>
		/// Void Convert(System.ReadOnlySpan`1[System.Char], System.Span`1[System.Byte], Boolean, Int32 ByRef, Int32 ByRef, Boolean ByRef)
		/// </summary>
		protected RMethod r_Convert_ReadOnlySpan_d_Char_p__Span_d_Byte_p__Boolean_Out_Int32_Out_Int32_Out_Boolean;
		public virtual RMethod RConvert_ReadOnlySpan_d_Char_p__Span_d_Byte_p__Boolean_Out_Int32_Out_Int32_Out_Boolean
		{
			get
			{
				if(r_Convert_ReadOnlySpan_d_Char_p__Span_d_Byte_p__Boolean_Out_Int32_Out_Int32_Out_Boolean == null)
				{
					r_Convert_ReadOnlySpan_d_Char_p__Span_d_Byte_p__Boolean_Out_Int32_Out_Int32_Out_Boolean = new(this, "Convert", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Boolean), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Boolean).MakeByRefType());
					r_Convert_ReadOnlySpan_d_Char_p__Span_d_Byte_p__Boolean_Out_Int32_Out_Int32_Out_Boolean.SetBelong(this.instance);
				}
				return r_Convert_ReadOnlySpan_d_Char_p__Span_d_Byte_p__Boolean_Out_Int32_Out_Int32_Out_Boolean;
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


        public REncoder() : base("System.Text.Encoder")
        {
        }

        public REncoder(System.Object instance) : base("System.Text.Encoder")
		{
            SetInstance(instance);
		}

        public REncoder(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REncoder(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetByteCount(System.Char[]  @chars, System.Int32  @index, System.Int32  @count, System.Boolean  @flush)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars, @index, @count, @flush};
            var ___result = RGetByteCount_CharArray_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }




        public virtual System.Int32 GetBytes(System.Char[]  @chars, System.Int32  @charIndex, System.Int32  @charCount, System.Byte[]  @bytes, System.Int32  @byteIndex, System.Boolean  @flush)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars, @charIndex, @charCount, @bytes, @byteIndex, @flush};
            var ___result = RGetBytes_CharArray_Int32_Int32_ByteArray_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }




        public virtual void Convert(System.Char[]  @chars, System.Int32  @charIndex, System.Int32  @charCount, System.Byte[]  @bytes, System.Int32  @byteIndex, System.Int32  @byteCount, System.Boolean  @flush, out System.Int32  @charsUsed, out System.Int32  @bytesUsed, out System.Boolean  @completed)
        {
			charsUsed = default;
			bytesUsed = default;
			completed = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars, @charIndex, @charCount, @bytes, @byteIndex, @byteCount, @flush, @charsUsed, @bytesUsed, @completed};
            var ___result = RConvert_CharArray_Int32_Int32_ByteArray_Int32_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean.Invoke(___genericsType, ___parameters);
			charsUsed = (System.Int32)___parameters[7];
			bytesUsed = (System.Int32)___parameters[8];
			completed = (System.Boolean)___parameters[9];

            
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
