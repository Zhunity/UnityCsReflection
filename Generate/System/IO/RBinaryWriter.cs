using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RIO
{
	/// <summary>
	/// System.IO.BinaryWriter
	/// </summary>
    public partial class RBinaryWriter : RMember //
    {

		/// <summary>
		/// System.IO.BinaryWriter Null
		/// </summary>
		protected static RSystem.RIO.RBinaryWriter r_Null;
		public static RSystem.RIO.RBinaryWriter RNull
		{
			get
			{
				if(r_Null == null)
				{
					r_Null = new(typeof(System.IO.BinaryWriter), "Null");
					r_Null.SetBelong(null);
				}
				return r_Null;
			}
		}

		/// <summary>
		/// System.IO.Stream OutStream
		/// </summary>
		protected RSystem.RIO.RStream r_OutStream;
		public virtual RSystem.RIO.RStream ROutStream
		{
			get
			{
				if(r_OutStream == null)
				{
					r_OutStream = new(this, "OutStream");
					r_OutStream.SetBelong(this.instance);
				}
				return r_OutStream;
			}
		}

		/// <summary>
		/// System.Byte[] _buffer
		/// </summary>
		protected RFieldArray<RField> r__buffer;
		public virtual RFieldArray<RField> R_buffer
		{
			get
			{
				if(r__buffer == null)
				{
					r__buffer = new(this, "_buffer");
					r__buffer.SetBelong(this.instance);
				}
				return r__buffer;
			}
		}

		/// <summary>
		/// System.Text.Encoding _encoding
		/// </summary>
		protected RSystem.RText.REncoding r__encoding;
		public virtual RSystem.RText.REncoding R_encoding
		{
			get
			{
				if(r__encoding == null)
				{
					r__encoding = new(this, "_encoding");
					r__encoding.SetBelong(this.instance);
				}
				return r__encoding;
			}
		}

		/// <summary>
		/// System.Text.Encoder _encoder
		/// </summary>
		protected RSystem.RText.REncoder r__encoder;
		public virtual RSystem.RText.REncoder R_encoder
		{
			get
			{
				if(r__encoder == null)
				{
					r__encoder = new(this, "_encoder");
					r__encoder.SetBelong(this.instance);
				}
				return r__encoder;
			}
		}

		/// <summary>
		/// System.Boolean _leaveOpen
		/// </summary>
		protected RField r__leaveOpen;
		public virtual RField R_leaveOpen
		{
			get
			{
				if(r__leaveOpen == null)
				{
					r__leaveOpen = new(this, "_leaveOpen");
					r__leaveOpen.SetBelong(this.instance);
				}
				return r__leaveOpen;
			}
		}

		/// <summary>
		/// System.Char[] _tmpOneCharBuffer
		/// </summary>
		protected RFieldArray<RField> r__tmpOneCharBuffer;
		public virtual RFieldArray<RField> R_tmpOneCharBuffer
		{
			get
			{
				if(r__tmpOneCharBuffer == null)
				{
					r__tmpOneCharBuffer = new(this, "_tmpOneCharBuffer");
					r__tmpOneCharBuffer.SetBelong(this.instance);
				}
				return r__tmpOneCharBuffer;
			}
		}

		/// <summary>
		/// System.Byte[] _largeByteBuffer
		/// </summary>
		protected RFieldArray<RField> r__largeByteBuffer;
		public virtual RFieldArray<RField> R_largeByteBuffer
		{
			get
			{
				if(r__largeByteBuffer == null)
				{
					r__largeByteBuffer = new(this, "_largeByteBuffer");
					r__largeByteBuffer.SetBelong(this.instance);
				}
				return r__largeByteBuffer;
			}
		}

		/// <summary>
		/// System.Int32 _maxChars
		/// </summary>
		protected RField r__maxChars;
		public virtual RField R_maxChars
		{
			get
			{
				if(r__maxChars == null)
				{
					r__maxChars = new(this, "_maxChars");
					r__maxChars.SetBelong(this.instance);
				}
				return r__maxChars;
			}
		}

		/// <summary>
		/// System.Int32 LargeByteBufferSize
		/// </summary>
		protected static RField r_LargeByteBufferSize;
		public static RField RLargeByteBufferSize
		{
			get
			{
				if(r_LargeByteBufferSize == null)
				{
					r_LargeByteBufferSize = new(typeof(System.IO.BinaryWriter), "LargeByteBufferSize");
					r_LargeByteBufferSize.SetBelong(null);
				}
				return r_LargeByteBufferSize;
			}
		}

		/// <summary>
		/// System.IO.Stream BaseStream
		/// </summary>
		protected RSystem.RIO.RStream r_BaseStream;
		public virtual RSystem.RIO.RStream RBaseStream
		{
			get
			{
				if(r_BaseStream == null)
				{
					r_BaseStream = new(this, "BaseStream", -1);
					r_BaseStream.SetBelong(this.instance);
				}
				return r_BaseStream;
			}
		}

		/// <summary>
		/// Void Close()
		/// </summary>
		protected RMethod r_RClose;
		public virtual RMethod RClose
		{
			get
			{
				if(r_RClose == null)
				{
					r_RClose = new(this, "Close", 0);
					r_RClose.SetBelong(this.instance);
				}
				return r_RClose;
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
		/// Void Flush()
		/// </summary>
		protected RMethod r_RFlush;
		public virtual RMethod RFlush
		{
			get
			{
				if(r_RFlush == null)
				{
					r_RFlush = new(this, "Flush", 0);
					r_RFlush.SetBelong(this.instance);
				}
				return r_RFlush;
			}
		}

		/// <summary>
		/// Int64 Seek(Int32, System.IO.SeekOrigin)
		/// </summary>
		protected RMethod r_RSeek_Int32_SeekOrigin;
		public virtual RMethod RSeek_Int32_SeekOrigin
		{
			get
			{
				if(r_RSeek_Int32_SeekOrigin == null)
				{
					r_RSeek_Int32_SeekOrigin = new(this, "Seek", 0, typeof(System.Int32), typeof(System.IO.SeekOrigin));
					r_RSeek_Int32_SeekOrigin.SetBelong(this.instance);
				}
				return r_RSeek_Int32_SeekOrigin;
			}
		}

		/// <summary>
		/// Void Write(System.ReadOnlySpan`1[System.Byte])
		/// </summary>
		protected RMethod r_RWrite_ReadOnlySpan_d_Byte_p_;
		public virtual RMethod RWrite_ReadOnlySpan_d_Byte_p_
		{
			get
			{
				if(r_RWrite_ReadOnlySpan_d_Byte_p_ == null)
				{
					r_RWrite_ReadOnlySpan_d_Byte_p_ = new(this, "Write", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)));
					r_RWrite_ReadOnlySpan_d_Byte_p_.SetBelong(this.instance);
				}
				return r_RWrite_ReadOnlySpan_d_Byte_p_;
			}
		}

		/// <summary>
		/// Void Write(System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected RMethod r_RWrite_ReadOnlySpan_d_Char_p_;
		public virtual RMethod RWrite_ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_RWrite_ReadOnlySpan_d_Char_p_ == null)
				{
					r_RWrite_ReadOnlySpan_d_Char_p_ = new(this, "Write", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_RWrite_ReadOnlySpan_d_Char_p_.SetBelong(this.instance);
				}
				return r_RWrite_ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.ValueTask DisposeAsync()
		/// </summary>
		protected RMethod r_RDisposeAsync;
		public virtual RMethod RDisposeAsync
		{
			get
			{
				if(r_RDisposeAsync == null)
				{
					r_RDisposeAsync = new(this, "DisposeAsync", 0);
					r_RDisposeAsync.SetBelong(this.instance);
				}
				return r_RDisposeAsync;
			}
		}

		/// <summary>
		/// Void Write(Boolean)
		/// </summary>
		protected RMethod r_RWrite_Boolean;
		public virtual RMethod RWrite_Boolean
		{
			get
			{
				if(r_RWrite_Boolean == null)
				{
					r_RWrite_Boolean = new(this, "Write", 0, typeof(System.Boolean));
					r_RWrite_Boolean.SetBelong(this.instance);
				}
				return r_RWrite_Boolean;
			}
		}

		/// <summary>
		/// Void Write(Byte)
		/// </summary>
		protected RMethod r_RWrite_Byte;
		public virtual RMethod RWrite_Byte
		{
			get
			{
				if(r_RWrite_Byte == null)
				{
					r_RWrite_Byte = new(this, "Write", 0, typeof(System.Byte));
					r_RWrite_Byte.SetBelong(this.instance);
				}
				return r_RWrite_Byte;
			}
		}

		/// <summary>
		/// Void Write(SByte)
		/// </summary>
		protected RMethod r_RWrite_SByte;
		public virtual RMethod RWrite_SByte
		{
			get
			{
				if(r_RWrite_SByte == null)
				{
					r_RWrite_SByte = new(this, "Write", 0, typeof(System.SByte));
					r_RWrite_SByte.SetBelong(this.instance);
				}
				return r_RWrite_SByte;
			}
		}

		/// <summary>
		/// Void Write(Byte[])
		/// </summary>
		protected RMethod r_RWrite_ByteArray;
		public virtual RMethod RWrite_ByteArray
		{
			get
			{
				if(r_RWrite_ByteArray == null)
				{
					r_RWrite_ByteArray = new(this, "Write", 0, typeof(System.Byte).MakeArrayType());
					r_RWrite_ByteArray.SetBelong(this.instance);
				}
				return r_RWrite_ByteArray;
			}
		}

		/// <summary>
		/// Void Write(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RWrite_ByteArray_Int32_Int32;
		public virtual RMethod RWrite_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RWrite_ByteArray_Int32_Int32 == null)
				{
					r_RWrite_ByteArray_Int32_Int32 = new(this, "Write", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RWrite_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RWrite_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Write(Char)
		/// </summary>
		protected RMethod r_RWrite_Char;
		public virtual RMethod RWrite_Char
		{
			get
			{
				if(r_RWrite_Char == null)
				{
					r_RWrite_Char = new(this, "Write", 0, typeof(System.Char));
					r_RWrite_Char.SetBelong(this.instance);
				}
				return r_RWrite_Char;
			}
		}

		/// <summary>
		/// Void Write(Char[])
		/// </summary>
		protected RMethod r_RWrite_CharArray;
		public virtual RMethod RWrite_CharArray
		{
			get
			{
				if(r_RWrite_CharArray == null)
				{
					r_RWrite_CharArray = new(this, "Write", 0, typeof(System.Char).MakeArrayType());
					r_RWrite_CharArray.SetBelong(this.instance);
				}
				return r_RWrite_CharArray;
			}
		}

		/// <summary>
		/// Void Write(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RWrite_CharArray_Int32_Int32;
		public virtual RMethod RWrite_CharArray_Int32_Int32
		{
			get
			{
				if(r_RWrite_CharArray_Int32_Int32 == null)
				{
					r_RWrite_CharArray_Int32_Int32 = new(this, "Write", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RWrite_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RWrite_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Write(Double)
		/// </summary>
		protected RMethod r_RWrite_Double;
		public virtual RMethod RWrite_Double
		{
			get
			{
				if(r_RWrite_Double == null)
				{
					r_RWrite_Double = new(this, "Write", 0, typeof(System.Double));
					r_RWrite_Double.SetBelong(this.instance);
				}
				return r_RWrite_Double;
			}
		}

		/// <summary>
		/// Void Write(System.Decimal)
		/// </summary>
		protected RMethod r_RWrite_Decimal;
		public virtual RMethod RWrite_Decimal
		{
			get
			{
				if(r_RWrite_Decimal == null)
				{
					r_RWrite_Decimal = new(this, "Write", 0, typeof(System.Decimal));
					r_RWrite_Decimal.SetBelong(this.instance);
				}
				return r_RWrite_Decimal;
			}
		}

		/// <summary>
		/// Void Write(Int16)
		/// </summary>
		protected RMethod r_RWrite_Int16;
		public virtual RMethod RWrite_Int16
		{
			get
			{
				if(r_RWrite_Int16 == null)
				{
					r_RWrite_Int16 = new(this, "Write", 0, typeof(System.Int16));
					r_RWrite_Int16.SetBelong(this.instance);
				}
				return r_RWrite_Int16;
			}
		}

		/// <summary>
		/// Void Write(UInt16)
		/// </summary>
		protected RMethod r_RWrite_UInt16;
		public virtual RMethod RWrite_UInt16
		{
			get
			{
				if(r_RWrite_UInt16 == null)
				{
					r_RWrite_UInt16 = new(this, "Write", 0, typeof(System.UInt16));
					r_RWrite_UInt16.SetBelong(this.instance);
				}
				return r_RWrite_UInt16;
			}
		}

		/// <summary>
		/// Void Write(Int32)
		/// </summary>
		protected RMethod r_RWrite_Int32;
		public virtual RMethod RWrite_Int32
		{
			get
			{
				if(r_RWrite_Int32 == null)
				{
					r_RWrite_Int32 = new(this, "Write", 0, typeof(System.Int32));
					r_RWrite_Int32.SetBelong(this.instance);
				}
				return r_RWrite_Int32;
			}
		}

		/// <summary>
		/// Void Write(UInt32)
		/// </summary>
		protected RMethod r_RWrite_UInt32;
		public virtual RMethod RWrite_UInt32
		{
			get
			{
				if(r_RWrite_UInt32 == null)
				{
					r_RWrite_UInt32 = new(this, "Write", 0, typeof(System.UInt32));
					r_RWrite_UInt32.SetBelong(this.instance);
				}
				return r_RWrite_UInt32;
			}
		}

		/// <summary>
		/// Void Write(Int64)
		/// </summary>
		protected RMethod r_RWrite_Int64;
		public virtual RMethod RWrite_Int64
		{
			get
			{
				if(r_RWrite_Int64 == null)
				{
					r_RWrite_Int64 = new(this, "Write", 0, typeof(System.Int64));
					r_RWrite_Int64.SetBelong(this.instance);
				}
				return r_RWrite_Int64;
			}
		}

		/// <summary>
		/// Void Write(UInt64)
		/// </summary>
		protected RMethod r_RWrite_UInt64;
		public virtual RMethod RWrite_UInt64
		{
			get
			{
				if(r_RWrite_UInt64 == null)
				{
					r_RWrite_UInt64 = new(this, "Write", 0, typeof(System.UInt64));
					r_RWrite_UInt64.SetBelong(this.instance);
				}
				return r_RWrite_UInt64;
			}
		}

		/// <summary>
		/// Void Write(Single)
		/// </summary>
		protected RMethod r_RWrite_Single;
		public virtual RMethod RWrite_Single
		{
			get
			{
				if(r_RWrite_Single == null)
				{
					r_RWrite_Single = new(this, "Write", 0, typeof(System.Single));
					r_RWrite_Single.SetBelong(this.instance);
				}
				return r_RWrite_Single;
			}
		}

		/// <summary>
		/// Void Write(System.String)
		/// </summary>
		protected RMethod r_RWrite_String;
		public virtual RMethod RWrite_String
		{
			get
			{
				if(r_RWrite_String == null)
				{
					r_RWrite_String = new(this, "Write", 0, typeof(System.String));
					r_RWrite_String.SetBelong(this.instance);
				}
				return r_RWrite_String;
			}
		}

		/// <summary>
		/// Void Write7BitEncodedInt(Int32)
		/// </summary>
		protected RMethod r_RWrite7BitEncodedInt_Int32;
		public virtual RMethod RWrite7BitEncodedInt_Int32
		{
			get
			{
				if(r_RWrite7BitEncodedInt_Int32 == null)
				{
					r_RWrite7BitEncodedInt_Int32 = new(this, "Write7BitEncodedInt", 0, typeof(System.Int32));
					r_RWrite7BitEncodedInt_Int32.SetBelong(this.instance);
				}
				return r_RWrite7BitEncodedInt_Int32;
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


        public RBinaryWriter() : base("System.IO.BinaryWriter")
        {
        }

        public RBinaryWriter(System.Object instance) : base("System.IO.BinaryWriter")
		{
            SetInstance(instance);
		}

        public RBinaryWriter(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBinaryWriter(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean  @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Flush()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFlush.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int64 Seek(System.Int32  @offset, System.IO.SeekOrigin  @origin)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@offset, @origin};
            var ___result = RSeek_Int32_SeekOrigin.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }




        public virtual System.Threading.Tasks.ValueTask DisposeAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDisposeAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask)___result;
        }


        public virtual void Write(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWrite_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Byte  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWrite_Byte.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.SByte  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWrite_SByte.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Byte[]  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer};
            var ___result = RWrite_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RWrite_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Char  @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RWrite_Char.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Char[]  @chars)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars};
            var ___result = RWrite_CharArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Char[]  @chars, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars, @index, @count};
            var ___result = RWrite_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Double  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWrite_Double.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Decimal  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWrite_Decimal.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Int16  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWrite_Int16.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.UInt16  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWrite_UInt16.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWrite_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.UInt32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWrite_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Int64  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWrite_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.UInt64  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWrite_UInt64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWrite_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWrite_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write7BitEncodedInt(System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWrite7BitEncodedInt_Int32.Invoke(___genericsType, ___parameters);

            
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
