
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RText
{
	/// <summary>
	/// System.Text.EncoderFallbackBuffer
	/// </summary>
    public partial class REncoderFallbackBuffer : RMember //
    {

		/// <summary>
		/// System.Char* charStart
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldPointer<Hvak.Editor.Refleaction.RSystem.RChar> r_FcharStart;
		public virtual Hvak.Editor.Refleaction.RFieldPointer<Hvak.Editor.Refleaction.RSystem.RChar> RFcharStart
		{
			get
			{
				if(r_FcharStart == null)
				{
					r_FcharStart = new(this, "charStart");
					r_FcharStart.SetBelong(this.GetValue());
				}
				return r_FcharStart;
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
					r_FcharEnd.SetBelong(this.GetValue());
				}
				return r_FcharEnd;
			}
		}

		/// <summary>
		/// System.Text.EncoderNLS encoder
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.REncoderNLS r_Fencoder;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.REncoderNLS RFencoder
		{
			get
			{
				if(r_Fencoder == null)
				{
					r_Fencoder = new(this, "encoder");
					r_Fencoder.SetBelong(this.GetValue());
				}
				return r_Fencoder;
			}
		}

		/// <summary>
		/// System.Boolean setEncoder
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FsetEncoder;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFsetEncoder
		{
			get
			{
				if(r_FsetEncoder == null)
				{
					r_FsetEncoder = new(this, "setEncoder");
					r_FsetEncoder.SetBelong(this.GetValue());
				}
				return r_FsetEncoder;
			}
		}

		/// <summary>
		/// System.Boolean bUsedEncoder
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FbUsedEncoder;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFbUsedEncoder
		{
			get
			{
				if(r_FbUsedEncoder == null)
				{
					r_FbUsedEncoder = new(this, "bUsedEncoder");
					r_FbUsedEncoder.SetBelong(this.GetValue());
				}
				return r_FbUsedEncoder;
			}
		}

		/// <summary>
		/// System.Boolean bFallingBack
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FbFallingBack;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFbFallingBack
		{
			get
			{
				if(r_FbFallingBack == null)
				{
					r_FbFallingBack = new(this, "bFallingBack");
					r_FbFallingBack.SetBelong(this.GetValue());
				}
				return r_FbFallingBack;
			}
		}

		/// <summary>
		/// System.Int32 iRecursionCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FiRecursionCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFiRecursionCount
		{
			get
			{
				if(r_FiRecursionCount == null)
				{
					r_FiRecursionCount = new(this, "iRecursionCount");
					r_FiRecursionCount.SetBelong(this.GetValue());
				}
				return r_FiRecursionCount;
			}
		}

		/// <summary>
		/// System.Int32 iMaxRecursion
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FiMaxRecursion;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFiMaxRecursion
		{
			get
			{
				if(r_FiMaxRecursion == null)
				{
					r_FiMaxRecursion = new(typeof(System.Text.EncoderFallbackBuffer), "iMaxRecursion");
					r_FiMaxRecursion.SetBelong(null);
				}
				return r_FiMaxRecursion;
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
					r_PRemaining.SetBelong(this.GetValue());
				}
				return r_PRemaining;
			}
		}

		/// <summary>
		/// Boolean Fallback(Char, Int32)
		/// </summary>
		protected RMethod r_MFallback_Char_Int32;
		public virtual RMethod RMFallback_Char_Int32
		{
			get
			{
				if(r_MFallback_Char_Int32 == null)
				{
					r_MFallback_Char_Int32 = new(this, "Fallback", 0, typeof(System.Char), typeof(System.Int32));
					r_MFallback_Char_Int32.SetBelong(this.GetValue());
				}
				return r_MFallback_Char_Int32;
			}
		}

		/// <summary>
		/// Boolean Fallback(Char, Char, Int32)
		/// </summary>
		protected RMethod r_MFallback_Char_Char_Int32;
		public virtual RMethod RMFallback_Char_Char_Int32
		{
			get
			{
				if(r_MFallback_Char_Char_Int32 == null)
				{
					r_MFallback_Char_Char_Int32 = new(this, "Fallback", 0, typeof(System.Char), typeof(System.Char), typeof(System.Int32));
					r_MFallback_Char_Char_Int32.SetBelong(this.GetValue());
				}
				return r_MFallback_Char_Char_Int32;
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
					r_MGetNextChar.SetBelong(this.GetValue());
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
					r_MMovePrevious.SetBelong(this.GetValue());
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
					r_MReset.SetBelong(this.GetValue());
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
					r_MInternalReset.SetBelong(this.GetValue());
				}
				return r_MInternalReset;
			}
		}

		/// <summary>
		/// Void InternalInitialize(Char*, Char*, System.Text.EncoderNLS, Boolean)
		/// </summary>
		protected RMethod r_MInternalInitialize_CharPointer_CharPointer_EncoderNLS_Boolean;
		public virtual RMethod RMInternalInitialize_CharPointer_CharPointer_EncoderNLS_Boolean
		{
			get
			{
				if(r_MInternalInitialize_CharPointer_CharPointer_EncoderNLS_Boolean == null)
				{
					r_MInternalInitialize_CharPointer_CharPointer_EncoderNLS_Boolean = new(this, "InternalInitialize", 0, typeof(System.Char).MakePointerType(), typeof(System.Char).MakePointerType(),  ReflectionUtils.GetType("System.Text.EncoderNLS"), typeof(System.Boolean));
					r_MInternalInitialize_CharPointer_CharPointer_EncoderNLS_Boolean.SetBelong(this.GetValue());
				}
				return r_MInternalInitialize_CharPointer_CharPointer_EncoderNLS_Boolean;
			}
		}

		/// <summary>
		/// Char InternalGetNextChar()
		/// </summary>
		protected RMethod r_MInternalGetNextChar;
		public virtual RMethod RMInternalGetNextChar
		{
			get
			{
				if(r_MInternalGetNextChar == null)
				{
					r_MInternalGetNextChar = new(this, "InternalGetNextChar", 0);
					r_MInternalGetNextChar.SetBelong(this.GetValue());
				}
				return r_MInternalGetNextChar;
			}
		}

		/// <summary>
		/// Boolean InternalFallback(Char, Char* ByRef)
		/// </summary>
		protected RMethod r_MInternalFallback_Char_Ref_CharPointer;
		public virtual RMethod RMInternalFallback_Char_Ref_CharPointer
		{
			get
			{
				if(r_MInternalFallback_Char_Ref_CharPointer == null)
				{
					r_MInternalFallback_Char_Ref_CharPointer = new(this, "InternalFallback", 0, typeof(System.Char), typeof(System.Char).MakePointerType().MakeByRefType());
					r_MInternalFallback_Char_Ref_CharPointer.SetBelong(this.GetValue());
				}
				return r_MInternalFallback_Char_Ref_CharPointer;
			}
		}

		/// <summary>
		/// Void ThrowLastCharRecursive(Int32)
		/// </summary>
		protected RMethod r_MThrowLastCharRecursive_Int32;
		public virtual RMethod RMThrowLastCharRecursive_Int32
		{
			get
			{
				if(r_MThrowLastCharRecursive_Int32 == null)
				{
					r_MThrowLastCharRecursive_Int32 = new(this, "ThrowLastCharRecursive", 0, typeof(System.Int32));
					r_MThrowLastCharRecursive_Int32.SetBelong(this.GetValue());
				}
				return r_MThrowLastCharRecursive_Int32;
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetHashCode.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
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

        public virtual System.Boolean Fallback(System.Char @charUnknown, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@charUnknown, @index};
            var ___result = RMFallback_Char_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Fallback(System.Char @charUnknownHigh, System.Char @charUnknownLow, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@charUnknownHigh, @charUnknownLow, @index};
            var ___result = RMFallback_Char_Char_Int32.Invoke(___genericsType, ___parameters);

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


        public unsafe virtual void InternalInitialize(System.Char* @charStart, System.Char* @charEnd, Hvak.Editor.Refleaction.RSystem.RText.REncoderNLS @encoder, System.Boolean @setEncoder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@charStart, typeof(System.Char)), Pointer.Box(@charEnd, typeof(System.Char)), @encoder.Value, @setEncoder};
            var ___result = RMInternalInitialize_CharPointer_CharPointer_EncoderNLS_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Char InternalGetNextChar()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternalGetNextChar.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public unsafe virtual System.Boolean InternalFallback(System.Char @ch, ref System.Char* @chars)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch, Pointer.Box(@chars, typeof(System.Char))};
            var ___result = RMInternalFallback_Char_Ref_CharPointer.Invoke(___genericsType, ___parameters);
			@chars = (System.Char*)Pointer.Unbox(___parameters[1]);
            return (System.Boolean)___result;
        }


        public virtual void ThrowLastCharRecursive(System.Int32 @charRecursive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@charRecursive};
            var ___result = RMThrowLastCharRecursive_Int32.Invoke(___genericsType, ___parameters);

            
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
