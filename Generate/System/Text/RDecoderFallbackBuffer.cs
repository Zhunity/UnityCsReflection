using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RText
{
	/// <summary>
	/// System.Text.DecoderFallbackBuffer
	/// </summary>
    public partial class RDecoderFallbackBuffer : RMember //
    {

		/// <summary>
		/// System.Byte* byteStart
		/// </summary>
		protected RFieldPointer<RSystem.RByte> r_byteStart;
		public virtual RFieldPointer<RSystem.RByte> RbyteStart
		{
			get
			{
				if(r_byteStart == null)
				{
					r_byteStart = new(this, "byteStart");
					r_byteStart.SetBelong(this.instance);
				}
				return r_byteStart;
			}
		}

		/// <summary>
		/// System.Char* charEnd
		/// </summary>
		protected RFieldPointer<RSystem.RChar> r_charEnd;
		public virtual RFieldPointer<RSystem.RChar> RcharEnd
		{
			get
			{
				if(r_charEnd == null)
				{
					r_charEnd = new(this, "charEnd");
					r_charEnd.SetBelong(this.instance);
				}
				return r_charEnd;
			}
		}

		/// <summary>
		/// Int32 Remaining
		/// </summary>
		protected RSystem.RInt32 r_Remaining;
		public virtual RSystem.RInt32 RRemaining
		{
			get
			{
				if(r_Remaining == null)
				{
					r_Remaining = new(this, "Remaining", -1);
					r_Remaining.SetBelong(this.instance);
				}
				return r_Remaining;
			}
		}

		/// <summary>
		/// Boolean Fallback(Byte[], Int32)
		/// </summary>
		protected RMethod r_Fallback_ByteArray_Int32;
		public virtual RMethod RFallback_ByteArray_Int32
		{
			get
			{
				if(r_Fallback_ByteArray_Int32 == null)
				{
					r_Fallback_ByteArray_Int32 = new(this, "Fallback", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_Fallback_ByteArray_Int32.SetBelong(this.instance);
				}
				return r_Fallback_ByteArray_Int32;
			}
		}

		/// <summary>
		/// Char GetNextChar()
		/// </summary>
		protected RMethod r_GetNextChar;
		public virtual RMethod RGetNextChar
		{
			get
			{
				if(r_GetNextChar == null)
				{
					r_GetNextChar = new(this, "GetNextChar", 0);
					r_GetNextChar.SetBelong(this.instance);
				}
				return r_GetNextChar;
			}
		}

		/// <summary>
		/// Boolean MovePrevious()
		/// </summary>
		protected RMethod r_MovePrevious;
		public virtual RMethod RMovePrevious
		{
			get
			{
				if(r_MovePrevious == null)
				{
					r_MovePrevious = new(this, "MovePrevious", 0);
					r_MovePrevious.SetBelong(this.instance);
				}
				return r_MovePrevious;
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
		/// Void InternalReset()
		/// </summary>
		protected RMethod r_InternalReset;
		public virtual RMethod RInternalReset
		{
			get
			{
				if(r_InternalReset == null)
				{
					r_InternalReset = new(this, "InternalReset", 0);
					r_InternalReset.SetBelong(this.instance);
				}
				return r_InternalReset;
			}
		}

		/// <summary>
		/// Void InternalInitialize(Byte*, Char*)
		/// </summary>
		protected RMethod r_InternalInitialize_BytePointer_CharPointer;
		public virtual RMethod RInternalInitialize_BytePointer_CharPointer
		{
			get
			{
				if(r_InternalInitialize_BytePointer_CharPointer == null)
				{
					r_InternalInitialize_BytePointer_CharPointer = new(this, "InternalInitialize", 0, typeof(System.Byte).MakePointerType(), typeof(System.Char).MakePointerType());
					r_InternalInitialize_BytePointer_CharPointer.SetBelong(this.instance);
				}
				return r_InternalInitialize_BytePointer_CharPointer;
			}
		}

		/// <summary>
		/// Boolean InternalFallback(Byte[], Byte*, Char* ByRef)
		/// </summary>
		protected RMethod r_InternalFallback_ByteArray_BytePointer_Ref_CharPointer;
		public virtual RMethod RInternalFallback_ByteArray_BytePointer_Ref_CharPointer
		{
			get
			{
				if(r_InternalFallback_ByteArray_BytePointer_Ref_CharPointer == null)
				{
					r_InternalFallback_ByteArray_BytePointer_Ref_CharPointer = new(this, "InternalFallback", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakePointerType(), typeof(System.Char).MakePointerType().MakeByRefType());
					r_InternalFallback_ByteArray_BytePointer_Ref_CharPointer.SetBelong(this.instance);
				}
				return r_InternalFallback_ByteArray_BytePointer_Ref_CharPointer;
			}
		}

		/// <summary>
		/// Int32 InternalFallback(Byte[], Byte*)
		/// </summary>
		protected RMethod r_InternalFallback_ByteArray_BytePointer;
		public virtual RMethod RInternalFallback_ByteArray_BytePointer
		{
			get
			{
				if(r_InternalFallback_ByteArray_BytePointer == null)
				{
					r_InternalFallback_ByteArray_BytePointer = new(this, "InternalFallback", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakePointerType());
					r_InternalFallback_ByteArray_BytePointer.SetBelong(this.instance);
				}
				return r_InternalFallback_ByteArray_BytePointer;
			}
		}

		/// <summary>
		/// Void ThrowLastBytesRecursive(Byte[])
		/// </summary>
		protected RMethod r_ThrowLastBytesRecursive_ByteArray;
		public virtual RMethod RThrowLastBytesRecursive_ByteArray
		{
			get
			{
				if(r_ThrowLastBytesRecursive_ByteArray == null)
				{
					r_ThrowLastBytesRecursive_ByteArray = new(this, "ThrowLastBytesRecursive", 0, typeof(System.Byte).MakeArrayType());
					r_ThrowLastBytesRecursive_ByteArray.SetBelong(this.instance);
				}
				return r_ThrowLastBytesRecursive_ByteArray;
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


        public RDecoderFallbackBuffer() : base("System.Text.DecoderFallbackBuffer")
        {
        }

        public RDecoderFallbackBuffer(System.Object instance) : base("System.Text.DecoderFallbackBuffer")
		{
            SetInstance(instance);
		}

        public RDecoderFallbackBuffer(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDecoderFallbackBuffer(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Fallback(System.Byte[] @bytesUnknown, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytesUnknown, @index};
            var ___result = RFallback_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Char GetNextChar()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetNextChar.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public virtual System.Boolean MovePrevious()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMovePrevious.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalReset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalReset.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe virtual void InternalInitialize(System.Byte* @byteStart, System.Char* @charEnd)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@byteStart, typeof(System.Byte)), Pointer.Box(@charEnd, typeof(System.Char))};
            var ___result = RInternalInitialize_BytePointer_CharPointer.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe virtual System.Boolean InternalFallback(System.Byte[] @bytes, System.Byte* @pBytes, ref System.Char* @chars)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes, Pointer.Box(@pBytes, typeof(System.Byte)), Pointer.Box(@chars, typeof(System.Char))};
            var ___result = RInternalFallback_ByteArray_BytePointer_Ref_CharPointer.Invoke(___genericsType, ___parameters);
			@chars = (System.Char*)Pointer.Unbox(___parameters[2]);
            return (System.Boolean)___result;
        }


        public unsafe virtual System.Int32 InternalFallback(System.Byte[] @bytes, System.Byte* @pBytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes, Pointer.Box(@pBytes, typeof(System.Byte))};
            var ___result = RInternalFallback_ByteArray_BytePointer.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void ThrowLastBytesRecursive(System.Byte[] @bytesUnknown)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytesUnknown};
            var ___result = RThrowLastBytesRecursive_ByteArray.Invoke(___genericsType, ___parameters);

            
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
