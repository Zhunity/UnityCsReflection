
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RText
{
	/// <summary>
	/// System.Text.DecoderFallbackBuffer
	/// </summary>
    public partial class RDecoderFallbackBuffer : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Text.DecoderFallbackBuffer);
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


		/// <summary>
		/// System.Byte* byteStart
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldPointer<Hvak.Editor.Refleaction.RSystem.RByte> r_FbyteStart;
		public virtual Hvak.Editor.Refleaction.RFieldPointer<Hvak.Editor.Refleaction.RSystem.RByte> RFbyteStart
		{
			get
			{
				if(r_FbyteStart == null)
				{
					r_FbyteStart = new(this, "byteStart");
				}
				return r_FbyteStart;
			}
		}

		/// <summary>
		/// System.Char* charEnd
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldPointer<Hvak.Editor.Refleaction.RSystem.RChar> r_FcharEnd;
		public virtual Hvak.Editor.Refleaction.RFieldPointer<Hvak.Editor.Refleaction.RSystem.RChar> RFcharEnd
		{
			get
			{
				if(r_FcharEnd == null)
				{
					r_FcharEnd = new(this, "charEnd");
				}
				return r_FcharEnd;
			}
		}

		/// <summary>
		/// Int32 Remaining
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PRemaining;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPRemaining
		{
			get
			{
				if(r_PRemaining == null)
				{
					r_PRemaining = new(this, "Remaining", -1);
				}
				return r_PRemaining;
			}
		}

		/// <summary>
		/// Boolean Fallback(Byte[], Int32)
		/// </summary>
		protected RMethod r_MFallback_ByteArray_Int32;
		public virtual RMethod RMFallback_ByteArray_Int32
		{
			get
			{
				if(r_MFallback_ByteArray_Int32 == null)
				{
					r_MFallback_ByteArray_Int32 = new(this, "Fallback", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
				}
				return r_MFallback_ByteArray_Int32;
			}
		}

		/// <summary>
		/// Char GetNextChar()
		/// </summary>
		protected RMethod r_MGetNextChar;
		public virtual RMethod RMGetNextChar
		{
			get
			{
				if(r_MGetNextChar == null)
				{
					r_MGetNextChar = new(this, "GetNextChar", 0);
				}
				return r_MGetNextChar;
			}
		}

		/// <summary>
		/// Boolean MovePrevious()
		/// </summary>
		protected RMethod r_MMovePrevious;
		public virtual RMethod RMMovePrevious
		{
			get
			{
				if(r_MMovePrevious == null)
				{
					r_MMovePrevious = new(this, "MovePrevious", 0);
				}
				return r_MMovePrevious;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_MReset;
		public virtual RMethod RMReset
		{
			get
			{
				if(r_MReset == null)
				{
					r_MReset = new(this, "Reset", 0);
				}
				return r_MReset;
			}
		}

		/// <summary>
		/// Void InternalReset()
		/// </summary>
		protected RMethod r_MInternalReset;
		public virtual RMethod RMInternalReset
		{
			get
			{
				if(r_MInternalReset == null)
				{
					r_MInternalReset = new(this, "InternalReset", 0);
				}
				return r_MInternalReset;
			}
		}

		/// <summary>
		/// Void InternalInitialize(Byte*, Char*)
		/// </summary>
		protected RMethod r_MInternalInitialize_BytePointer_CharPointer;
		public virtual RMethod RMInternalInitialize_BytePointer_CharPointer
		{
			get
			{
				if(r_MInternalInitialize_BytePointer_CharPointer == null)
				{
					r_MInternalInitialize_BytePointer_CharPointer = new(this, "InternalInitialize", 0, typeof(System.Byte).MakePointerType(), typeof(System.Char).MakePointerType());
				}
				return r_MInternalInitialize_BytePointer_CharPointer;
			}
		}

		/// <summary>
		/// Boolean InternalFallback(Byte[], Byte*, Char* ByRef)
		/// </summary>
		protected RMethod r_MInternalFallback_ByteArray_BytePointer_Ref_CharPointer;
		public virtual RMethod RMInternalFallback_ByteArray_BytePointer_Ref_CharPointer
		{
			get
			{
				if(r_MInternalFallback_ByteArray_BytePointer_Ref_CharPointer == null)
				{
					r_MInternalFallback_ByteArray_BytePointer_Ref_CharPointer = new(this, "InternalFallback", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakePointerType(), typeof(System.Char).MakePointerType().MakeByRefType());
				}
				return r_MInternalFallback_ByteArray_BytePointer_Ref_CharPointer;
			}
		}

		/// <summary>
		/// Int32 InternalFallback(Byte[], Byte*)
		/// </summary>
		protected RMethod r_MInternalFallback_ByteArray_BytePointer;
		public virtual RMethod RMInternalFallback_ByteArray_BytePointer
		{
			get
			{
				if(r_MInternalFallback_ByteArray_BytePointer == null)
				{
					r_MInternalFallback_ByteArray_BytePointer = new(this, "InternalFallback", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakePointerType());
				}
				return r_MInternalFallback_ByteArray_BytePointer;
			}
		}

		/// <summary>
		/// Void ThrowLastBytesRecursive(Byte[])
		/// </summary>
		protected RMethod r_MThrowLastBytesRecursive_ByteArray;
		public virtual RMethod RMThrowLastBytesRecursive_ByteArray
		{
			get
			{
				if(r_MThrowLastBytesRecursive_ByteArray == null)
				{
					r_MThrowLastBytesRecursive_ByteArray = new(this, "ThrowLastBytesRecursive", 0, typeof(System.Byte).MakeArrayType());
				}
				return r_MThrowLastBytesRecursive_ByteArray;
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
				}
				return r_MToString;
			}
		}


        public virtual System.Boolean Fallback(System.Byte[] @bytesUnknown, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytesUnknown, @index};
            var ___result = RMFallback_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Char GetNextChar()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetNextChar.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public virtual System.Boolean MovePrevious()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMovePrevious.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalReset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternalReset.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe virtual void InternalInitialize(System.Byte* @byteStart, System.Char* @charEnd)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@byteStart, typeof(System.Byte)), Pointer.Box(@charEnd, typeof(System.Char))};
            var ___result = RMInternalInitialize_BytePointer_CharPointer.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe virtual System.Boolean InternalFallback(System.Byte[] @bytes, System.Byte* @pBytes, ref System.Char* @chars)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes, Pointer.Box(@pBytes, typeof(System.Byte)), Pointer.Box(@chars, typeof(System.Char))};
            var ___result = RMInternalFallback_ByteArray_BytePointer_Ref_CharPointer.Invoke(___genericsType, ___parameters);
			@chars = (System.Char*)Pointer.Unbox(___parameters[2]);
            return (System.Boolean)___result;
        }


        public unsafe virtual System.Int32 InternalFallback(System.Byte[] @bytes, System.Byte* @pBytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes, Pointer.Box(@pBytes, typeof(System.Byte))};
            var ___result = RMInternalFallback_ByteArray_BytePointer.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void ThrowLastBytesRecursive(System.Byte[] @bytesUnknown)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytesUnknown};
            var ___result = RMThrowLastBytesRecursive_ByteArray.Invoke(___genericsType, ___parameters);

            
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
