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
		protected RFieldPointer<RField> r_byteStart;
		public virtual RFieldPointer<RField> RbyteStart
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
		protected RFieldPointer<RField> r_charEnd;
		public virtual RFieldPointer<RField> RcharEnd
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
		protected RProperty r_Remaining;
		public virtual RProperty Remaining
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
		protected RMethod r_RFallback_ByteArray_Int32;
		public virtual RMethod RFallback_ByteArray_Int32
		{
			get
			{
				if(r_RFallback_ByteArray_Int32 == null)
				{
					r_RFallback_ByteArray_Int32 = new(this, "Fallback", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_RFallback_ByteArray_Int32.SetBelong(this.instance);
				}
				return r_RFallback_ByteArray_Int32;
			}
		}

		/// <summary>
		/// Char GetNextChar()
		/// </summary>
		protected RMethod r_RGetNextChar;
		public virtual RMethod RGetNextChar
		{
			get
			{
				if(r_RGetNextChar == null)
				{
					r_RGetNextChar = new(this, "GetNextChar", 0);
					r_RGetNextChar.SetBelong(this.instance);
				}
				return r_RGetNextChar;
			}
		}

		/// <summary>
		/// Boolean MovePrevious()
		/// </summary>
		protected RMethod r_RMovePrevious;
		public virtual RMethod RMovePrevious
		{
			get
			{
				if(r_RMovePrevious == null)
				{
					r_RMovePrevious = new(this, "MovePrevious", 0);
					r_RMovePrevious.SetBelong(this.instance);
				}
				return r_RMovePrevious;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_RReset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_RReset == null)
				{
					r_RReset = new(this, "Reset", 0);
					r_RReset.SetBelong(this.instance);
				}
				return r_RReset;
			}
		}

		/// <summary>
		/// Void InternalReset()
		/// </summary>
		protected RMethod r_RInternalReset;
		public virtual RMethod RInternalReset
		{
			get
			{
				if(r_RInternalReset == null)
				{
					r_RInternalReset = new(this, "InternalReset", 0);
					r_RInternalReset.SetBelong(this.instance);
				}
				return r_RInternalReset;
			}
		}

		/// <summary>
		/// Void InternalInitialize(Byte*, Char*)
		/// </summary>
		protected RMethod r_RInternalInitialize_BytePointer_CharPointer;
		public virtual RMethod RInternalInitialize_BytePointer_CharPointer
		{
			get
			{
				if(r_RInternalInitialize_BytePointer_CharPointer == null)
				{
					r_RInternalInitialize_BytePointer_CharPointer = new(this, "InternalInitialize", 0, typeof(System.Byte).MakePointerType(), typeof(System.Char).MakePointerType());
					r_RInternalInitialize_BytePointer_CharPointer.SetBelong(this.instance);
				}
				return r_RInternalInitialize_BytePointer_CharPointer;
			}
		}

		/// <summary>
		/// Boolean InternalFallback(Byte[], Byte*, Char* ByRef)
		/// </summary>
		protected RMethod r_RInternalFallback_ByteArray_BytePointer_Ref_CharPointer;
		public virtual RMethod RInternalFallback_ByteArray_BytePointer_Ref_CharPointer
		{
			get
			{
				if(r_RInternalFallback_ByteArray_BytePointer_Ref_CharPointer == null)
				{
					r_RInternalFallback_ByteArray_BytePointer_Ref_CharPointer = new(this, "InternalFallback", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakePointerType(), typeof(System.Char).MakePointerType().MakeByRefType());
					r_RInternalFallback_ByteArray_BytePointer_Ref_CharPointer.SetBelong(this.instance);
				}
				return r_RInternalFallback_ByteArray_BytePointer_Ref_CharPointer;
			}
		}

		/// <summary>
		/// Int32 InternalFallback(Byte[], Byte*)
		/// </summary>
		protected RMethod r_RInternalFallback_ByteArray_BytePointer;
		public virtual RMethod RInternalFallback_ByteArray_BytePointer
		{
			get
			{
				if(r_RInternalFallback_ByteArray_BytePointer == null)
				{
					r_RInternalFallback_ByteArray_BytePointer = new(this, "InternalFallback", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakePointerType());
					r_RInternalFallback_ByteArray_BytePointer.SetBelong(this.instance);
				}
				return r_RInternalFallback_ByteArray_BytePointer;
			}
		}

		/// <summary>
		/// Void ThrowLastBytesRecursive(Byte[])
		/// </summary>
		protected RMethod r_RThrowLastBytesRecursive_ByteArray;
		public virtual RMethod RThrowLastBytesRecursive_ByteArray
		{
			get
			{
				if(r_RThrowLastBytesRecursive_ByteArray == null)
				{
					r_RThrowLastBytesRecursive_ByteArray = new(this, "ThrowLastBytesRecursive", 0, typeof(System.Byte).MakeArrayType());
					r_RThrowLastBytesRecursive_ByteArray.SetBelong(this.instance);
				}
				return r_RThrowLastBytesRecursive_ByteArray;
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

        public virtual System.Boolean Fallback(System.Byte[]  @bytesUnknown, System.Int32  @index)
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





        public virtual void ThrowLastBytesRecursive(System.Byte[]  @bytesUnknown)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytesUnknown};
            var ___result = RThrowLastBytesRecursive_ByteArray.Invoke(___genericsType, ___parameters);

            
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
