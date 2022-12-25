using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RText
{
	/// <summary>
	/// System.Text.EncoderFallbackBuffer
	/// </summary>
    public partial class REncoderFallbackBuffer : RMember //
    {

		/// <summary>
		/// System.Char* charStart
		/// </summary>
		protected RFieldPointer<RField> r_charStart;
		public virtual RFieldPointer<RField> RcharStart
		{
			get
			{
				if(r_charStart == null)
				{
					r_charStart = new(this, "charStart");
					r_charStart.SetBelong(this.instance);
				}
				return r_charStart;
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
		/// System.Text.EncoderNLS encoder
		/// </summary>
		protected RSystem.RText.REncoderNLS r_encoder;
		public virtual RSystem.RText.REncoderNLS Rencoder
		{
			get
			{
				if(r_encoder == null)
				{
					r_encoder = new(this, "encoder");
					r_encoder.SetBelong(this.instance);
				}
				return r_encoder;
			}
		}

		/// <summary>
		/// System.Boolean setEncoder
		/// </summary>
		protected RField r_setEncoder;
		public virtual RField RsetEncoder
		{
			get
			{
				if(r_setEncoder == null)
				{
					r_setEncoder = new(this, "setEncoder");
					r_setEncoder.SetBelong(this.instance);
				}
				return r_setEncoder;
			}
		}

		/// <summary>
		/// System.Boolean bUsedEncoder
		/// </summary>
		protected RField r_bUsedEncoder;
		public virtual RField RbUsedEncoder
		{
			get
			{
				if(r_bUsedEncoder == null)
				{
					r_bUsedEncoder = new(this, "bUsedEncoder");
					r_bUsedEncoder.SetBelong(this.instance);
				}
				return r_bUsedEncoder;
			}
		}

		/// <summary>
		/// System.Boolean bFallingBack
		/// </summary>
		protected RField r_bFallingBack;
		public virtual RField RbFallingBack
		{
			get
			{
				if(r_bFallingBack == null)
				{
					r_bFallingBack = new(this, "bFallingBack");
					r_bFallingBack.SetBelong(this.instance);
				}
				return r_bFallingBack;
			}
		}

		/// <summary>
		/// System.Int32 iRecursionCount
		/// </summary>
		protected RField r_iRecursionCount;
		public virtual RField RiRecursionCount
		{
			get
			{
				if(r_iRecursionCount == null)
				{
					r_iRecursionCount = new(this, "iRecursionCount");
					r_iRecursionCount.SetBelong(this.instance);
				}
				return r_iRecursionCount;
			}
		}

		/// <summary>
		/// System.Int32 iMaxRecursion
		/// </summary>
		protected static RField r_iMaxRecursion;
		public static RField RiMaxRecursion
		{
			get
			{
				if(r_iMaxRecursion == null)
				{
					r_iMaxRecursion = new(typeof(System.Text.EncoderFallbackBuffer), "iMaxRecursion");
					r_iMaxRecursion.SetBelong(null);
				}
				return r_iMaxRecursion;
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
		/// Boolean Fallback(Char, Int32)
		/// </summary>
		protected RMethod r_RFallback_Char_Int32;
		public virtual RMethod RFallback_Char_Int32
		{
			get
			{
				if(r_RFallback_Char_Int32 == null)
				{
					r_RFallback_Char_Int32 = new(this, "Fallback", 0, typeof(System.Char), typeof(System.Int32));
					r_RFallback_Char_Int32.SetBelong(this.instance);
				}
				return r_RFallback_Char_Int32;
			}
		}

		/// <summary>
		/// Boolean Fallback(Char, Char, Int32)
		/// </summary>
		protected RMethod r_RFallback_Char_Char_Int32;
		public virtual RMethod RFallback_Char_Char_Int32
		{
			get
			{
				if(r_RFallback_Char_Char_Int32 == null)
				{
					r_RFallback_Char_Char_Int32 = new(this, "Fallback", 0, typeof(System.Char), typeof(System.Char), typeof(System.Int32));
					r_RFallback_Char_Char_Int32.SetBelong(this.instance);
				}
				return r_RFallback_Char_Char_Int32;
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
		/// Void InternalInitialize(Char*, Char*, System.Text.EncoderNLS, Boolean)
		/// </summary>
		protected RMethod r_RInternalInitialize_CharPointer_CharPointer_EncoderNLS_Boolean;
		public virtual RMethod RInternalInitialize_CharPointer_CharPointer_EncoderNLS_Boolean
		{
			get
			{
				if(r_RInternalInitialize_CharPointer_CharPointer_EncoderNLS_Boolean == null)
				{
					r_RInternalInitialize_CharPointer_CharPointer_EncoderNLS_Boolean = new(this, "InternalInitialize", 0, typeof(System.Char).MakePointerType(), typeof(System.Char).MakePointerType(),  ReleactionUtils.GetType("System.Text.EncoderNLS"), typeof(System.Boolean));
					r_RInternalInitialize_CharPointer_CharPointer_EncoderNLS_Boolean.SetBelong(this.instance);
				}
				return r_RInternalInitialize_CharPointer_CharPointer_EncoderNLS_Boolean;
			}
		}

		/// <summary>
		/// Char InternalGetNextChar()
		/// </summary>
		protected RMethod r_RInternalGetNextChar;
		public virtual RMethod RInternalGetNextChar
		{
			get
			{
				if(r_RInternalGetNextChar == null)
				{
					r_RInternalGetNextChar = new(this, "InternalGetNextChar", 0);
					r_RInternalGetNextChar.SetBelong(this.instance);
				}
				return r_RInternalGetNextChar;
			}
		}

		/// <summary>
		/// Boolean InternalFallback(Char, Char* ByRef)
		/// </summary>
		protected RMethod r_RInternalFallback_Char_Ref_CharPointer;
		public virtual RMethod RInternalFallback_Char_Ref_CharPointer
		{
			get
			{
				if(r_RInternalFallback_Char_Ref_CharPointer == null)
				{
					r_RInternalFallback_Char_Ref_CharPointer = new(this, "InternalFallback", 0, typeof(System.Char), typeof(System.Char).MakePointerType().MakeByRefType());
					r_RInternalFallback_Char_Ref_CharPointer.SetBelong(this.instance);
				}
				return r_RInternalFallback_Char_Ref_CharPointer;
			}
		}

		/// <summary>
		/// Void ThrowLastCharRecursive(Int32)
		/// </summary>
		protected RMethod r_RThrowLastCharRecursive_Int32;
		public virtual RMethod RThrowLastCharRecursive_Int32
		{
			get
			{
				if(r_RThrowLastCharRecursive_Int32 == null)
				{
					r_RThrowLastCharRecursive_Int32 = new(this, "ThrowLastCharRecursive", 0, typeof(System.Int32));
					r_RThrowLastCharRecursive_Int32.SetBelong(this.instance);
				}
				return r_RThrowLastCharRecursive_Int32;
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


        public REncoderFallbackBuffer() : base("System.Text.EncoderFallbackBuffer")
        {
        }

        public REncoderFallbackBuffer(System.Object instance) : base("System.Text.EncoderFallbackBuffer")
		{
            SetInstance(instance);
		}

        public REncoderFallbackBuffer(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REncoderFallbackBuffer(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Fallback(System.Char  @charUnknown, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@charUnknown, @index};
            var ___result = RFallback_Char_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Fallback(System.Char  @charUnknownHigh, System.Char  @charUnknownLow, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@charUnknownHigh, @charUnknownLow, @index};
            var ___result = RFallback_Char_Char_Int32.Invoke(___genericsType, ___parameters);

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



        public virtual System.Char InternalGetNextChar()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalGetNextChar.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }



        public virtual void ThrowLastCharRecursive(System.Int32  @charRecursive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@charRecursive};
            var ___result = RThrowLastCharRecursive_Int32.Invoke(___genericsType, ___parameters);

            
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
