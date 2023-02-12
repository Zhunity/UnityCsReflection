
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
		protected static SMFrame.Editor.Refleaction.RSystem.RIO.RBinaryWriter r_FNull;
		public static SMFrame.Editor.Refleaction.RSystem.RIO.RBinaryWriter RFNull
		{
			get
			{
				if(r_FNull == null)
				{
					r_FNull = new(typeof(System.IO.BinaryWriter), "Null");
					r_FNull.SetBelong(null);
				}
				return r_FNull;
			}
		}

		/// <summary>
		/// System.IO.Stream OutStream
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RIO.RStream r_FOutStream;
		public virtual SMFrame.Editor.Refleaction.RSystem.RIO.RStream RFOutStream
		{
			get
			{
				if(r_FOutStream == null)
				{
					r_FOutStream = new(this, "OutStream");
					r_FOutStream.SetBelong(this.instance);
				}
				return r_FOutStream;
			}
		}

		/// <summary>
		/// System.Byte[] _buffer
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RByte> r_F_buffer;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RByte> RF_buffer
		{
			get
			{
				if(r_F_buffer == null)
				{
					r_F_buffer = new(this, "_buffer");
					r_F_buffer.SetBelong(this.instance);
				}
				return r_F_buffer;
			}
		}

		/// <summary>
		/// System.Text.Encoding _encoding
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RText.REncoding r_F_encoding;
		public virtual SMFrame.Editor.Refleaction.RSystem.RText.REncoding RF_encoding
		{
			get
			{
				if(r_F_encoding == null)
				{
					r_F_encoding = new(this, "_encoding");
					r_F_encoding.SetBelong(this.instance);
				}
				return r_F_encoding;
			}
		}

		/// <summary>
		/// System.Text.Encoder _encoder
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RText.REncoder r_F_encoder;
		public virtual SMFrame.Editor.Refleaction.RSystem.RText.REncoder RF_encoder
		{
			get
			{
				if(r_F_encoder == null)
				{
					r_F_encoder = new(this, "_encoder");
					r_F_encoder.SetBelong(this.instance);
				}
				return r_F_encoder;
			}
		}

		/// <summary>
		/// System.Boolean _leaveOpen
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_F_leaveOpen;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RF_leaveOpen
		{
			get
			{
				if(r_F_leaveOpen == null)
				{
					r_F_leaveOpen = new(this, "_leaveOpen");
					r_F_leaveOpen.SetBelong(this.instance);
				}
				return r_F_leaveOpen;
			}
		}

		/// <summary>
		/// System.Char[] _tmpOneCharBuffer
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RChar> r_F_tmpOneCharBuffer;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RChar> RF_tmpOneCharBuffer
		{
			get
			{
				if(r_F_tmpOneCharBuffer == null)
				{
					r_F_tmpOneCharBuffer = new(this, "_tmpOneCharBuffer");
					r_F_tmpOneCharBuffer.SetBelong(this.instance);
				}
				return r_F_tmpOneCharBuffer;
			}
		}

		/// <summary>
		/// System.Byte[] _largeByteBuffer
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RByte> r_F_largeByteBuffer;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RByte> RF_largeByteBuffer
		{
			get
			{
				if(r_F_largeByteBuffer == null)
				{
					r_F_largeByteBuffer = new(this, "_largeByteBuffer");
					r_F_largeByteBuffer.SetBelong(this.instance);
				}
				return r_F_largeByteBuffer;
			}
		}

		/// <summary>
		/// System.Int32 _maxChars
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_F_maxChars;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RF_maxChars
		{
			get
			{
				if(r_F_maxChars == null)
				{
					r_F_maxChars = new(this, "_maxChars");
					r_F_maxChars.SetBelong(this.instance);
				}
				return r_F_maxChars;
			}
		}

		/// <summary>
		/// System.Int32 LargeByteBufferSize
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RInt32 r_FLargeByteBufferSize;
		public static SMFrame.Editor.Refleaction.RSystem.RInt32 RFLargeByteBufferSize
		{
			get
			{
				if(r_FLargeByteBufferSize == null)
				{
					r_FLargeByteBufferSize = new(typeof(System.IO.BinaryWriter), "LargeByteBufferSize");
					r_FLargeByteBufferSize.SetBelong(null);
				}
				return r_FLargeByteBufferSize;
			}
		}

		/// <summary>
		/// System.IO.Stream BaseStream
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RIO.RStream r_PBaseStream;
		public virtual SMFrame.Editor.Refleaction.RSystem.RIO.RStream RPBaseStream
		{
			get
			{
				if(r_PBaseStream == null)
				{
					r_PBaseStream = new(this, "BaseStream", -1);
					r_PBaseStream.SetBelong(this.instance);
				}
				return r_PBaseStream;
			}
		}

		/// <summary>
		/// Void Close()
		/// </summary>
		protected RMethod r_MClose;
		public virtual RMethod RMClose
		{
			get
			{
				if(r_MClose == null)
				{
					r_MClose = new(this, "Close", 0);
					r_MClose.SetBelong(this.instance);
				}
				return r_MClose;
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
		/// Void Flush()
		/// </summary>
		protected RMethod r_MFlush;
		public virtual RMethod RMFlush
		{
			get
			{
				if(r_MFlush == null)
				{
					r_MFlush = new(this, "Flush", 0);
					r_MFlush.SetBelong(this.instance);
				}
				return r_MFlush;
			}
		}

		/// <summary>
		/// Int64 Seek(Int32, System.IO.SeekOrigin)
		/// </summary>
		protected RMethod r_MSeek_Int32_SeekOrigin;
		public virtual RMethod RMSeek_Int32_SeekOrigin
		{
			get
			{
				if(r_MSeek_Int32_SeekOrigin == null)
				{
					r_MSeek_Int32_SeekOrigin = new(this, "Seek", 0, typeof(System.Int32), typeof(System.IO.SeekOrigin));
					r_MSeek_Int32_SeekOrigin.SetBelong(this.instance);
				}
				return r_MSeek_Int32_SeekOrigin;
			}
		}

		/// <summary>
		/// Void Write(System.ReadOnlySpan`1[System.Byte])
		/// </summary>
		protected RMethod r_MWrite_ReadOnlySpan_d_Byte_p_;
		public virtual RMethod RMWrite_ReadOnlySpan_d_Byte_p_
		{
			get
			{
				if(r_MWrite_ReadOnlySpan_d_Byte_p_ == null)
				{
					r_MWrite_ReadOnlySpan_d_Byte_p_ = new(this, "Write", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)));
					r_MWrite_ReadOnlySpan_d_Byte_p_.SetBelong(this.instance);
				}
				return r_MWrite_ReadOnlySpan_d_Byte_p_;
			}
		}

		/// <summary>
		/// Void Write(System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected RMethod r_MWrite_ReadOnlySpan_d_Char_p_;
		public virtual RMethod RMWrite_ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_MWrite_ReadOnlySpan_d_Char_p_ == null)
				{
					r_MWrite_ReadOnlySpan_d_Char_p_ = new(this, "Write", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_MWrite_ReadOnlySpan_d_Char_p_.SetBelong(this.instance);
				}
				return r_MWrite_ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.ValueTask DisposeAsync()
		/// </summary>
		protected RMethod r_MDisposeAsync;
		public virtual RMethod RMDisposeAsync
		{
			get
			{
				if(r_MDisposeAsync == null)
				{
					r_MDisposeAsync = new(this, "DisposeAsync", 0);
					r_MDisposeAsync.SetBelong(this.instance);
				}
				return r_MDisposeAsync;
			}
		}

		/// <summary>
		/// Void Write(Boolean)
		/// </summary>
		protected RMethod r_MWrite_Boolean;
		public virtual RMethod RMWrite_Boolean
		{
			get
			{
				if(r_MWrite_Boolean == null)
				{
					r_MWrite_Boolean = new(this, "Write", 0, typeof(System.Boolean));
					r_MWrite_Boolean.SetBelong(this.instance);
				}
				return r_MWrite_Boolean;
			}
		}

		/// <summary>
		/// Void Write(Byte)
		/// </summary>
		protected RMethod r_MWrite_Byte;
		public virtual RMethod RMWrite_Byte
		{
			get
			{
				if(r_MWrite_Byte == null)
				{
					r_MWrite_Byte = new(this, "Write", 0, typeof(System.Byte));
					r_MWrite_Byte.SetBelong(this.instance);
				}
				return r_MWrite_Byte;
			}
		}

		/// <summary>
		/// Void Write(SByte)
		/// </summary>
		protected RMethod r_MWrite_SByte;
		public virtual RMethod RMWrite_SByte
		{
			get
			{
				if(r_MWrite_SByte == null)
				{
					r_MWrite_SByte = new(this, "Write", 0, typeof(System.SByte));
					r_MWrite_SByte.SetBelong(this.instance);
				}
				return r_MWrite_SByte;
			}
		}

		/// <summary>
		/// Void Write(Byte[])
		/// </summary>
		protected RMethod r_MWrite_ByteArray;
		public virtual RMethod RMWrite_ByteArray
		{
			get
			{
				if(r_MWrite_ByteArray == null)
				{
					r_MWrite_ByteArray = new(this, "Write", 0, typeof(System.Byte).MakeArrayType());
					r_MWrite_ByteArray.SetBelong(this.instance);
				}
				return r_MWrite_ByteArray;
			}
		}

		/// <summary>
		/// Void Write(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_MWrite_ByteArray_Int32_Int32;
		public virtual RMethod RMWrite_ByteArray_Int32_Int32
		{
			get
			{
				if(r_MWrite_ByteArray_Int32_Int32 == null)
				{
					r_MWrite_ByteArray_Int32_Int32 = new(this, "Write", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MWrite_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_MWrite_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Write(Char)
		/// </summary>
		protected RMethod r_MWrite_Char;
		public virtual RMethod RMWrite_Char
		{
			get
			{
				if(r_MWrite_Char == null)
				{
					r_MWrite_Char = new(this, "Write", 0, typeof(System.Char));
					r_MWrite_Char.SetBelong(this.instance);
				}
				return r_MWrite_Char;
			}
		}

		/// <summary>
		/// Void Write(Char[])
		/// </summary>
		protected RMethod r_MWrite_CharArray;
		public virtual RMethod RMWrite_CharArray
		{
			get
			{
				if(r_MWrite_CharArray == null)
				{
					r_MWrite_CharArray = new(this, "Write", 0, typeof(System.Char).MakeArrayType());
					r_MWrite_CharArray.SetBelong(this.instance);
				}
				return r_MWrite_CharArray;
			}
		}

		/// <summary>
		/// Void Write(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_MWrite_CharArray_Int32_Int32;
		public virtual RMethod RMWrite_CharArray_Int32_Int32
		{
			get
			{
				if(r_MWrite_CharArray_Int32_Int32 == null)
				{
					r_MWrite_CharArray_Int32_Int32 = new(this, "Write", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MWrite_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_MWrite_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Write(Double)
		/// </summary>
		protected RMethod r_MWrite_Double;
		public virtual RMethod RMWrite_Double
		{
			get
			{
				if(r_MWrite_Double == null)
				{
					r_MWrite_Double = new(this, "Write", 0, typeof(System.Double));
					r_MWrite_Double.SetBelong(this.instance);
				}
				return r_MWrite_Double;
			}
		}

		/// <summary>
		/// Void Write(System.Decimal)
		/// </summary>
		protected RMethod r_MWrite_Decimal;
		public virtual RMethod RMWrite_Decimal
		{
			get
			{
				if(r_MWrite_Decimal == null)
				{
					r_MWrite_Decimal = new(this, "Write", 0, typeof(System.Decimal));
					r_MWrite_Decimal.SetBelong(this.instance);
				}
				return r_MWrite_Decimal;
			}
		}

		/// <summary>
		/// Void Write(Int16)
		/// </summary>
		protected RMethod r_MWrite_Int16;
		public virtual RMethod RMWrite_Int16
		{
			get
			{
				if(r_MWrite_Int16 == null)
				{
					r_MWrite_Int16 = new(this, "Write", 0, typeof(System.Int16));
					r_MWrite_Int16.SetBelong(this.instance);
				}
				return r_MWrite_Int16;
			}
		}

		/// <summary>
		/// Void Write(UInt16)
		/// </summary>
		protected RMethod r_MWrite_UInt16;
		public virtual RMethod RMWrite_UInt16
		{
			get
			{
				if(r_MWrite_UInt16 == null)
				{
					r_MWrite_UInt16 = new(this, "Write", 0, typeof(System.UInt16));
					r_MWrite_UInt16.SetBelong(this.instance);
				}
				return r_MWrite_UInt16;
			}
		}

		/// <summary>
		/// Void Write(Int32)
		/// </summary>
		protected RMethod r_MWrite_Int32;
		public virtual RMethod RMWrite_Int32
		{
			get
			{
				if(r_MWrite_Int32 == null)
				{
					r_MWrite_Int32 = new(this, "Write", 0, typeof(System.Int32));
					r_MWrite_Int32.SetBelong(this.instance);
				}
				return r_MWrite_Int32;
			}
		}

		/// <summary>
		/// Void Write(UInt32)
		/// </summary>
		protected RMethod r_MWrite_UInt32;
		public virtual RMethod RMWrite_UInt32
		{
			get
			{
				if(r_MWrite_UInt32 == null)
				{
					r_MWrite_UInt32 = new(this, "Write", 0, typeof(System.UInt32));
					r_MWrite_UInt32.SetBelong(this.instance);
				}
				return r_MWrite_UInt32;
			}
		}

		/// <summary>
		/// Void Write(Int64)
		/// </summary>
		protected RMethod r_MWrite_Int64;
		public virtual RMethod RMWrite_Int64
		{
			get
			{
				if(r_MWrite_Int64 == null)
				{
					r_MWrite_Int64 = new(this, "Write", 0, typeof(System.Int64));
					r_MWrite_Int64.SetBelong(this.instance);
				}
				return r_MWrite_Int64;
			}
		}

		/// <summary>
		/// Void Write(UInt64)
		/// </summary>
		protected RMethod r_MWrite_UInt64;
		public virtual RMethod RMWrite_UInt64
		{
			get
			{
				if(r_MWrite_UInt64 == null)
				{
					r_MWrite_UInt64 = new(this, "Write", 0, typeof(System.UInt64));
					r_MWrite_UInt64.SetBelong(this.instance);
				}
				return r_MWrite_UInt64;
			}
		}

		/// <summary>
		/// Void Write(Single)
		/// </summary>
		protected RMethod r_MWrite_Single;
		public virtual RMethod RMWrite_Single
		{
			get
			{
				if(r_MWrite_Single == null)
				{
					r_MWrite_Single = new(this, "Write", 0, typeof(System.Single));
					r_MWrite_Single.SetBelong(this.instance);
				}
				return r_MWrite_Single;
			}
		}

		/// <summary>
		/// Void Write(System.String)
		/// </summary>
		protected RMethod r_MWrite_String;
		public virtual RMethod RMWrite_String
		{
			get
			{
				if(r_MWrite_String == null)
				{
					r_MWrite_String = new(this, "Write", 0, typeof(System.String));
					r_MWrite_String.SetBelong(this.instance);
				}
				return r_MWrite_String;
			}
		}

		/// <summary>
		/// Void Write7BitEncodedInt(Int32)
		/// </summary>
		protected RMethod r_MWrite7BitEncodedInt_Int32;
		public virtual RMethod RMWrite7BitEncodedInt_Int32
		{
			get
			{
				if(r_MWrite7BitEncodedInt_Int32 == null)
				{
					r_MWrite7BitEncodedInt_Int32 = new(this, "Write7BitEncodedInt", 0, typeof(System.Int32));
					r_MWrite7BitEncodedInt_Int32.SetBelong(this.instance);
				}
				return r_MWrite7BitEncodedInt_Int32;
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
            var ___result = RMClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RMDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Flush()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFlush.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int64 Seek(System.Int32 @offset, System.IO.SeekOrigin @origin)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@offset, @origin};
            var ___result = RMSeek_Int32_SeekOrigin.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual void Write(SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RSystem.RByte> @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer.Value};
            var ___result = RMWrite_ReadOnlySpan_d_Byte_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RSystem.RChar> @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer.Value};
            var ___result = RMWrite_ReadOnlySpan_d_Char_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Threading.Tasks.ValueTask DisposeAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDisposeAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask)___result;
        }


        public virtual void Write(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMWrite_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Byte @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMWrite_Byte.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.SByte @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMWrite_SByte.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Byte[] @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer};
            var ___result = RMWrite_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Byte[] @buffer, System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RMWrite_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Char @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RMWrite_Char.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Char[] @chars)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars};
            var ___result = RMWrite_CharArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Char[] @chars, System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars, @index, @count};
            var ___result = RMWrite_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Double @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMWrite_Double.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Decimal @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMWrite_Decimal.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Int16 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMWrite_Int16.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.UInt16 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMWrite_UInt16.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMWrite_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.UInt32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMWrite_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Int64 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMWrite_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.UInt64 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMWrite_UInt64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMWrite_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMWrite_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write7BitEncodedInt(System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMWrite7BitEncodedInt_Int32.Invoke(___genericsType, ___parameters);

            
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