using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RText
{
	/// <summary>
	/// System.Text.Decoder
	/// </summary>
    public partial class RDecoder : RMember //
    {

		/// <summary>
		/// System.Text.DecoderFallback _fallback
		/// </summary>
		protected RSystem.RText.RDecoderFallback r__fallback;
		public virtual RSystem.RText.RDecoderFallback R_fallback
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
		/// System.Text.DecoderFallbackBuffer _fallbackBuffer
		/// </summary>
		protected RSystem.RText.RDecoderFallbackBuffer r__fallbackBuffer;
		public virtual RSystem.RText.RDecoderFallbackBuffer R_fallbackBuffer
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
		/// System.Text.DecoderFallback Fallback
		/// </summary>
		protected RSystem.RText.RDecoderFallback r_Fallback;
		public virtual RSystem.RText.RDecoderFallback RFallback
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
		/// System.Text.DecoderFallbackBuffer FallbackBuffer
		/// </summary>
		protected RSystem.RText.RDecoderFallbackBuffer r_FallbackBuffer;
		public virtual RSystem.RText.RDecoderFallbackBuffer RFallbackBuffer
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
		/// Int32 GetCharCount(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_GetCharCount_ByteArray_Int32_Int32;
		public virtual RMethod RGetCharCount_ByteArray_Int32_Int32
		{
			get
			{
				if(r_GetCharCount_ByteArray_Int32_Int32 == null)
				{
					r_GetCharCount_ByteArray_Int32_Int32 = new(this, "GetCharCount", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_GetCharCount_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_GetCharCount_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetCharCount(Byte[], Int32, Int32, Boolean)
		/// </summary>
		protected RMethod r_GetCharCount_ByteArray_Int32_Int32_Boolean;
		public virtual RMethod RGetCharCount_ByteArray_Int32_Int32_Boolean
		{
			get
			{
				if(r_GetCharCount_ByteArray_Int32_Int32_Boolean == null)
				{
					r_GetCharCount_ByteArray_Int32_Int32_Boolean = new(this, "GetCharCount", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_GetCharCount_ByteArray_Int32_Int32_Boolean.SetBelong(this.instance);
				}
				return r_GetCharCount_ByteArray_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 GetCharCount(Byte*, Int32, Boolean)
		/// </summary>
		protected RMethod r_GetCharCount_BytePointer_Int32_Boolean;
		public virtual RMethod RGetCharCount_BytePointer_Int32_Boolean
		{
			get
			{
				if(r_GetCharCount_BytePointer_Int32_Boolean == null)
				{
					r_GetCharCount_BytePointer_Int32_Boolean = new(this, "GetCharCount", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32), typeof(System.Boolean));
					r_GetCharCount_BytePointer_Int32_Boolean.SetBelong(this.instance);
				}
				return r_GetCharCount_BytePointer_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 GetCharCount(System.ReadOnlySpan`1[System.Byte], Boolean)
		/// </summary>
		protected RMethod r_GetCharCount_ReadOnlySpan_d_Byte_p__Boolean;
		public virtual RMethod RGetCharCount_ReadOnlySpan_d_Byte_p__Boolean
		{
			get
			{
				if(r_GetCharCount_ReadOnlySpan_d_Byte_p__Boolean == null)
				{
					r_GetCharCount_ReadOnlySpan_d_Byte_p__Boolean = new(this, "GetCharCount", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Boolean));
					r_GetCharCount_ReadOnlySpan_d_Byte_p__Boolean.SetBelong(this.instance);
				}
				return r_GetCharCount_ReadOnlySpan_d_Byte_p__Boolean;
			}
		}

		/// <summary>
		/// Int32 GetChars(Byte[], Int32, Int32, Char[], Int32)
		/// </summary>
		protected RMethod r_GetChars_ByteArray_Int32_Int32_CharArray_Int32;
		public virtual RMethod RGetChars_ByteArray_Int32_Int32_CharArray_Int32
		{
			get
			{
				if(r_GetChars_ByteArray_Int32_Int32_CharArray_Int32 == null)
				{
					r_GetChars_ByteArray_Int32_Int32_CharArray_Int32 = new(this, "GetChars", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Char).MakeArrayType(), typeof(System.Int32));
					r_GetChars_ByteArray_Int32_Int32_CharArray_Int32.SetBelong(this.instance);
				}
				return r_GetChars_ByteArray_Int32_Int32_CharArray_Int32;
			}
		}

		/// <summary>
		/// Int32 GetChars(Byte[], Int32, Int32, Char[], Int32, Boolean)
		/// </summary>
		protected RMethod r_GetChars_ByteArray_Int32_Int32_CharArray_Int32_Boolean;
		public virtual RMethod RGetChars_ByteArray_Int32_Int32_CharArray_Int32_Boolean
		{
			get
			{
				if(r_GetChars_ByteArray_Int32_Int32_CharArray_Int32_Boolean == null)
				{
					r_GetChars_ByteArray_Int32_Int32_CharArray_Int32_Boolean = new(this, "GetChars", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean));
					r_GetChars_ByteArray_Int32_Int32_CharArray_Int32_Boolean.SetBelong(this.instance);
				}
				return r_GetChars_ByteArray_Int32_Int32_CharArray_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 GetChars(Byte*, Int32, Char*, Int32, Boolean)
		/// </summary>
		protected RMethod r_GetChars_BytePointer_Int32_CharPointer_Int32_Boolean;
		public virtual RMethod RGetChars_BytePointer_Int32_CharPointer_Int32_Boolean
		{
			get
			{
				if(r_GetChars_BytePointer_Int32_CharPointer_Int32_Boolean == null)
				{
					r_GetChars_BytePointer_Int32_CharPointer_Int32_Boolean = new(this, "GetChars", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32), typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Boolean));
					r_GetChars_BytePointer_Int32_CharPointer_Int32_Boolean.SetBelong(this.instance);
				}
				return r_GetChars_BytePointer_Int32_CharPointer_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 GetChars(System.ReadOnlySpan`1[System.Byte], System.Span`1[System.Char], Boolean)
		/// </summary>
		protected RMethod r_GetChars_ReadOnlySpan_d_Byte_p__Span_d_Char_p__Boolean;
		public virtual RMethod RGetChars_ReadOnlySpan_d_Byte_p__Span_d_Char_p__Boolean
		{
			get
			{
				if(r_GetChars_ReadOnlySpan_d_Byte_p__Span_d_Char_p__Boolean == null)
				{
					r_GetChars_ReadOnlySpan_d_Byte_p__Span_d_Char_p__Boolean = new(this, "GetChars", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Span<>).MakeGenericType(typeof(System.Char)), typeof(System.Boolean));
					r_GetChars_ReadOnlySpan_d_Byte_p__Span_d_Char_p__Boolean.SetBelong(this.instance);
				}
				return r_GetChars_ReadOnlySpan_d_Byte_p__Span_d_Char_p__Boolean;
			}
		}

		/// <summary>
		/// Void Convert(Byte[], Int32, Int32, Char[], Int32, Int32, Boolean, Int32 ByRef, Int32 ByRef, Boolean ByRef)
		/// </summary>
		protected RMethod r_Convert_ByteArray_Int32_Int32_CharArray_Int32_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean;
		public virtual RMethod RConvert_ByteArray_Int32_Int32_CharArray_Int32_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean
		{
			get
			{
				if(r_Convert_ByteArray_Int32_Int32_CharArray_Int32_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean == null)
				{
					r_Convert_ByteArray_Int32_Int32_CharArray_Int32_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean = new(this, "Convert", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Boolean).MakeByRefType());
					r_Convert_ByteArray_Int32_Int32_CharArray_Int32_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean.SetBelong(this.instance);
				}
				return r_Convert_ByteArray_Int32_Int32_CharArray_Int32_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean;
			}
		}

		/// <summary>
		/// Void Convert(Byte*, Int32, Char*, Int32, Boolean, Int32 ByRef, Int32 ByRef, Boolean ByRef)
		/// </summary>
		protected RMethod r_Convert_BytePointer_Int32_CharPointer_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean;
		public virtual RMethod RConvert_BytePointer_Int32_CharPointer_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean
		{
			get
			{
				if(r_Convert_BytePointer_Int32_CharPointer_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean == null)
				{
					r_Convert_BytePointer_Int32_CharPointer_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean = new(this, "Convert", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32), typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Boolean).MakeByRefType());
					r_Convert_BytePointer_Int32_CharPointer_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean.SetBelong(this.instance);
				}
				return r_Convert_BytePointer_Int32_CharPointer_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean;
			}
		}

		/// <summary>
		/// Void Convert(System.ReadOnlySpan`1[System.Byte], System.Span`1[System.Char], Boolean, Int32 ByRef, Int32 ByRef, Boolean ByRef)
		/// </summary>
		protected RMethod r_Convert_ReadOnlySpan_d_Byte_p__Span_d_Char_p__Boolean_Out_Int32_Out_Int32_Out_Boolean;
		public virtual RMethod RConvert_ReadOnlySpan_d_Byte_p__Span_d_Char_p__Boolean_Out_Int32_Out_Int32_Out_Boolean
		{
			get
			{
				if(r_Convert_ReadOnlySpan_d_Byte_p__Span_d_Char_p__Boolean_Out_Int32_Out_Int32_Out_Boolean == null)
				{
					r_Convert_ReadOnlySpan_d_Byte_p__Span_d_Char_p__Boolean_Out_Int32_Out_Int32_Out_Boolean = new(this, "Convert", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Span<>).MakeGenericType(typeof(System.Char)), typeof(System.Boolean), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Boolean).MakeByRefType());
					r_Convert_ReadOnlySpan_d_Byte_p__Span_d_Char_p__Boolean_Out_Int32_Out_Int32_Out_Boolean.SetBelong(this.instance);
				}
				return r_Convert_ReadOnlySpan_d_Byte_p__Span_d_Char_p__Boolean_Out_Int32_Out_Int32_Out_Boolean;
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


        public RDecoder() : base("System.Text.Decoder")
        {
        }

        public RDecoder(System.Object instance) : base("System.Text.Decoder")
		{
            SetInstance(instance);
		}

        public RDecoder(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDecoder(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetCharCount(System.Byte[]  @bytes, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes, @index, @count};
            var ___result = RGetCharCount_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetCharCount(System.Byte[]  @bytes, System.Int32  @index, System.Int32  @count, System.Boolean  @flush)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes, @index, @count, @flush};
            var ___result = RGetCharCount_ByteArray_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }




        public virtual System.Int32 GetChars(System.Byte[]  @bytes, System.Int32  @byteIndex, System.Int32  @byteCount, System.Char[]  @chars, System.Int32  @charIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes, @byteIndex, @byteCount, @chars, @charIndex};
            var ___result = RGetChars_ByteArray_Int32_Int32_CharArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetChars(System.Byte[]  @bytes, System.Int32  @byteIndex, System.Int32  @byteCount, System.Char[]  @chars, System.Int32  @charIndex, System.Boolean  @flush)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes, @byteIndex, @byteCount, @chars, @charIndex, @flush};
            var ___result = RGetChars_ByteArray_Int32_Int32_CharArray_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }




        public virtual void Convert(System.Byte[]  @bytes, System.Int32  @byteIndex, System.Int32  @byteCount, System.Char[]  @chars, System.Int32  @charIndex, System.Int32  @charCount, System.Boolean  @flush, out System.Int32  @bytesUsed, out System.Int32  @charsUsed, out System.Boolean  @completed)
        {
			@bytesUsed = default;
			@charsUsed = default;
			@completed = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes, @byteIndex, @byteCount, @chars, @charIndex, @charCount, @flush, @bytesUsed, @charsUsed, @completed};
            var ___result = RConvert_ByteArray_Int32_Int32_CharArray_Int32_Int32_Boolean_Out_Int32_Out_Int32_Out_Boolean.Invoke(___genericsType, ___parameters);
			@bytesUsed = (System.Int32)___parameters[7];
			@charsUsed = (System.Int32)___parameters[8];
			@completed = (System.Boolean)___parameters[9];

            
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
