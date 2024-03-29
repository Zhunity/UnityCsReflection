
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{public partial class REnum
{
	
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Enum+EnumResult
	/// </summary>
    public partial class REnumResult : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Enum+EnumResult");
            }
        }

        public REnumResult() : base("System.Enum+EnumResult")
        {
        }

        public REnumResult(System.Object instance) : base("System.Enum+EnumResult")
		{
            SetInstance(instance);
		}

        public REnumResult(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REnumResult(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Object parsedEnum
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_FparsedEnum;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RFparsedEnum
		{
			get
			{
				if(r_FparsedEnum == null)
				{
					r_FparsedEnum = new(this, "parsedEnum");
				}
				return r_FparsedEnum;
			}
		}

		/// <summary>
		/// System.Boolean canThrow
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FcanThrow;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFcanThrow
		{
			get
			{
				if(r_FcanThrow == null)
				{
					r_FcanThrow = new(this, "canThrow");
				}
				return r_FcanThrow;
			}
		}

		/// <summary>
		/// System.Enum+ParseFailureKind m_failure
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.REnum.RParseFailureKind r_Fm_failure;
		public virtual Hvak.Editor.Refleaction.RSystem.REnum.RParseFailureKind RFm_failure
		{
			get
			{
				if(r_Fm_failure == null)
				{
					r_Fm_failure = new(this, "m_failure");
				}
				return r_Fm_failure;
			}
		}

		/// <summary>
		/// System.String m_failureMessageID
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_failureMessageID;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_failureMessageID
		{
			get
			{
				if(r_Fm_failureMessageID == null)
				{
					r_Fm_failureMessageID = new(this, "m_failureMessageID");
				}
				return r_Fm_failureMessageID;
			}
		}

		/// <summary>
		/// System.String m_failureParameter
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_failureParameter;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_failureParameter
		{
			get
			{
				if(r_Fm_failureParameter == null)
				{
					r_Fm_failureParameter = new(this, "m_failureParameter");
				}
				return r_Fm_failureParameter;
			}
		}

		/// <summary>
		/// System.Object m_failureMessageFormatArgument
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_Fm_failureMessageFormatArgument;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RFm_failureMessageFormatArgument
		{
			get
			{
				if(r_Fm_failureMessageFormatArgument == null)
				{
					r_Fm_failureMessageFormatArgument = new(this, "m_failureMessageFormatArgument");
				}
				return r_Fm_failureMessageFormatArgument;
			}
		}

		/// <summary>
		/// System.Exception m_innerException
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RException r_Fm_innerException;
		public virtual Hvak.Editor.Refleaction.RSystem.RException RFm_innerException
		{
			get
			{
				if(r_Fm_innerException == null)
				{
					r_Fm_innerException = new(this, "m_innerException");
				}
				return r_Fm_innerException;
			}
		}

		/// <summary>
		/// Void Init(Boolean)
		/// </summary>
		protected RMethod r_MInit_Boolean;
		public virtual RMethod RMInit_Boolean
		{
			get
			{
				if(r_MInit_Boolean == null)
				{
					r_MInit_Boolean = new(this, "Init", 0, typeof(System.Boolean));
				}
				return r_MInit_Boolean;
			}
		}

		/// <summary>
		/// Void SetFailure(System.Exception)
		/// </summary>
		protected RMethod r_MSetFailure_Exception;
		public virtual RMethod RMSetFailure_Exception
		{
			get
			{
				if(r_MSetFailure_Exception == null)
				{
					r_MSetFailure_Exception = new(this, "SetFailure", 0, typeof(System.Exception));
				}
				return r_MSetFailure_Exception;
			}
		}

		/// <summary>
		/// Void SetFailure(ParseFailureKind, System.String)
		/// </summary>
		protected RMethod r_MSetFailure_ParseFailureKind_String;
		public virtual RMethod RMSetFailure_ParseFailureKind_String
		{
			get
			{
				if(r_MSetFailure_ParseFailureKind_String == null)
				{
					r_MSetFailure_ParseFailureKind_String = new(this, "SetFailure", 0,  ReflectionUtils.GetType("System.Enum+ParseFailureKind"), typeof(System.String));
				}
				return r_MSetFailure_ParseFailureKind_String;
			}
		}

		/// <summary>
		/// Void SetFailure(ParseFailureKind, System.String, System.Object)
		/// </summary>
		protected RMethod r_MSetFailure_ParseFailureKind_String_Object;
		public virtual RMethod RMSetFailure_ParseFailureKind_String_Object
		{
			get
			{
				if(r_MSetFailure_ParseFailureKind_String_Object == null)
				{
					r_MSetFailure_ParseFailureKind_String_Object = new(this, "SetFailure", 0,  ReflectionUtils.GetType("System.Enum+ParseFailureKind"), typeof(System.String), typeof(System.Object));
				}
				return r_MSetFailure_ParseFailureKind_String_Object;
			}
		}

		/// <summary>
		/// System.Exception GetEnumParseException()
		/// </summary>
		protected RMethod r_MGetEnumParseException;
		public virtual RMethod RMGetEnumParseException
		{
			get
			{
				if(r_MGetEnumParseException == null)
				{
					r_MGetEnumParseException = new(this, "GetEnumParseException", 0);
				}
				return r_MGetEnumParseException;
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


        public virtual void Init(System.Boolean @canMethodThrow)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@canMethodThrow};
            var ___result = RMInit_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFailure(System.Exception @unhandledException)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unhandledException};
            var ___result = RMSetFailure_Exception.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFailure(Hvak.Editor.Refleaction.RSystem.REnum.RParseFailureKind @failure, System.String @failureParameter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@failure.Value, @failureParameter};
            var ___result = RMSetFailure_ParseFailureKind_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFailure(Hvak.Editor.Refleaction.RSystem.REnum.RParseFailureKind @failure, System.String @failureMessageID, System.Object @failureMessageFormatArgument)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@failure.Value, @failureMessageID, @failureMessageFormatArgument};
            var ___result = RMSetFailure_ParseFailureKind_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Exception GetEnumParseException()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumParseException.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Exception>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
}