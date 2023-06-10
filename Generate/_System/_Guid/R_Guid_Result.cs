
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{public partial class RGuid
{
	
	/// <summary>
	/// System.Guid+GuidResult
	/// </summary>
    public partial class RGuidResult : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Guid+GuidResult");
            }
        }

        public RGuidResult() : base("System.Guid+GuidResult")
        {
        }

        public RGuidResult(System.Object instance) : base("System.Guid+GuidResult")
		{
            SetInstance(instance);
		}

        public RGuidResult(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGuidResult(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Guid _parsedGuid
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGuid r_F_parsedGuid;
		public virtual Hvak.Editor.Refleaction.RSystem.RGuid RF_parsedGuid
		{
			get
			{
				if(r_F_parsedGuid == null)
				{
					r_F_parsedGuid = new(this, "_parsedGuid");
				}
				return r_F_parsedGuid;
			}
		}

		/// <summary>
		/// System.Guid+GuidParseThrowStyle _throwStyle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGuid.RGuidParseThrowStyle r_F_throwStyle;
		public virtual Hvak.Editor.Refleaction.RSystem.RGuid.RGuidParseThrowStyle RF_throwStyle
		{
			get
			{
				if(r_F_throwStyle == null)
				{
					r_F_throwStyle = new(this, "_throwStyle");
				}
				return r_F_throwStyle;
			}
		}

		/// <summary>
		/// System.Guid+ParseFailureKind _failure
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGuid.RParseFailureKind r_F_failure;
		public virtual Hvak.Editor.Refleaction.RSystem.RGuid.RParseFailureKind RF_failure
		{
			get
			{
				if(r_F_failure == null)
				{
					r_F_failure = new(this, "_failure");
				}
				return r_F_failure;
			}
		}

		/// <summary>
		/// System.String _failureMessageID
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F_failureMessageID;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF_failureMessageID
		{
			get
			{
				if(r_F_failureMessageID == null)
				{
					r_F_failureMessageID = new(this, "_failureMessageID");
				}
				return r_F_failureMessageID;
			}
		}

		/// <summary>
		/// System.Object _failureMessageFormatArgument
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_F_failureMessageFormatArgument;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RF_failureMessageFormatArgument
		{
			get
			{
				if(r_F_failureMessageFormatArgument == null)
				{
					r_F_failureMessageFormatArgument = new(this, "_failureMessageFormatArgument");
				}
				return r_F_failureMessageFormatArgument;
			}
		}

		/// <summary>
		/// System.String _failureArgumentName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F_failureArgumentName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF_failureArgumentName
		{
			get
			{
				if(r_F_failureArgumentName == null)
				{
					r_F_failureArgumentName = new(this, "_failureArgumentName");
				}
				return r_F_failureArgumentName;
			}
		}

		/// <summary>
		/// System.Exception _innerException
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RException r_F_innerException;
		public virtual Hvak.Editor.Refleaction.RSystem.RException RF_innerException
		{
			get
			{
				if(r_F_innerException == null)
				{
					r_F_innerException = new(this, "_innerException");
				}
				return r_F_innerException;
			}
		}

		/// <summary>
		/// Void Init(GuidParseThrowStyle)
		/// </summary>
		protected RMethod r_MInit_GuidParseThrowStyle;
		public virtual RMethod RMInit_GuidParseThrowStyle
		{
			get
			{
				if(r_MInit_GuidParseThrowStyle == null)
				{
					r_MInit_GuidParseThrowStyle = new(this, "Init", 0,  ReflectionUtils.GetType("System.Guid+GuidParseThrowStyle"));
				}
				return r_MInit_GuidParseThrowStyle;
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
					r_MSetFailure_ParseFailureKind_String = new(this, "SetFailure", 0,  ReflectionUtils.GetType("System.Guid+ParseFailureKind"), typeof(System.String));
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
					r_MSetFailure_ParseFailureKind_String_Object = new(this, "SetFailure", 0,  ReflectionUtils.GetType("System.Guid+ParseFailureKind"), typeof(System.String), typeof(System.Object));
				}
				return r_MSetFailure_ParseFailureKind_String_Object;
			}
		}

		/// <summary>
		/// Void SetFailure(ParseFailureKind, System.String, System.Object, System.String, System.Exception)
		/// </summary>
		protected RMethod r_MSetFailure_ParseFailureKind_String_Object_String_Exception;
		public virtual RMethod RMSetFailure_ParseFailureKind_String_Object_String_Exception
		{
			get
			{
				if(r_MSetFailure_ParseFailureKind_String_Object_String_Exception == null)
				{
					r_MSetFailure_ParseFailureKind_String_Object_String_Exception = new(this, "SetFailure", 0,  ReflectionUtils.GetType("System.Guid+ParseFailureKind"), typeof(System.String), typeof(System.Object), typeof(System.String), typeof(System.Exception));
				}
				return r_MSetFailure_ParseFailureKind_String_Object_String_Exception;
			}
		}

		/// <summary>
		/// System.Exception GetGuidParseException()
		/// </summary>
		protected RMethod r_MGetGuidParseException;
		public virtual RMethod RMGetGuidParseException
		{
			get
			{
				if(r_MGetGuidParseException == null)
				{
					r_MGetGuidParseException = new(this, "GetGuidParseException", 0);
				}
				return r_MGetGuidParseException;
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


        public virtual void Init(Hvak.Editor.Refleaction.RSystem.RGuid.RGuidParseThrowStyle @canThrow)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@canThrow.Value};
            var ___result = RMInit_GuidParseThrowStyle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFailure(System.Exception @nativeException)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nativeException};
            var ___result = RMSetFailure_Exception.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFailure(Hvak.Editor.Refleaction.RSystem.RGuid.RParseFailureKind @failure, System.String @failureMessageID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@failure.Value, @failureMessageID};
            var ___result = RMSetFailure_ParseFailureKind_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFailure(Hvak.Editor.Refleaction.RSystem.RGuid.RParseFailureKind @failure, System.String @failureMessageID, System.Object @failureMessageFormatArgument)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@failure.Value, @failureMessageID, @failureMessageFormatArgument};
            var ___result = RMSetFailure_ParseFailureKind_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFailure(Hvak.Editor.Refleaction.RSystem.RGuid.RParseFailureKind @failure, System.String @failureMessageID, System.Object @failureMessageFormatArgument, System.String @failureArgumentName, System.Exception @innerException)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@failure.Value, @failureMessageID, @failureMessageFormatArgument, @failureArgumentName, @innerException};
            var ___result = RMSetFailure_ParseFailureKind_String_Object_String_Exception.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Exception GetGuidParseException()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetGuidParseException.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
}