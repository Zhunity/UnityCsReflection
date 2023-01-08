using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{public partial class RGuid
{
	
	/// <summary>
	/// System.Guid+GuidResult
	/// </summary>
    public partial class RGuidResult : RMember //
    {

		/// <summary>
		/// System.Guid _parsedGuid
		/// </summary>
		protected RSystem.RGuid r__parsedGuid;
		public virtual RSystem.RGuid R_parsedGuid
		{
			get
			{
				if(r__parsedGuid == null)
				{
					r__parsedGuid = new(this, "_parsedGuid");
					r__parsedGuid.SetBelong(this.instance);
				}
				return r__parsedGuid;
			}
		}

		/// <summary>
		/// System.Guid+GuidParseThrowStyle _throwStyle
		/// </summary>
		protected RField r__throwStyle;
		public virtual RField R_throwStyle
		{
			get
			{
				if(r__throwStyle == null)
				{
					r__throwStyle = new(this, "_throwStyle");
					r__throwStyle.SetBelong(this.instance);
				}
				return r__throwStyle;
			}
		}

		/// <summary>
		/// System.Guid+ParseFailureKind _failure
		/// </summary>
		protected RField r__failure;
		public virtual RField R_failure
		{
			get
			{
				if(r__failure == null)
				{
					r__failure = new(this, "_failure");
					r__failure.SetBelong(this.instance);
				}
				return r__failure;
			}
		}

		/// <summary>
		/// System.String _failureMessageID
		/// </summary>
		protected RField r__failureMessageID;
		public virtual RField R_failureMessageID
		{
			get
			{
				if(r__failureMessageID == null)
				{
					r__failureMessageID = new(this, "_failureMessageID");
					r__failureMessageID.SetBelong(this.instance);
				}
				return r__failureMessageID;
			}
		}

		/// <summary>
		/// System.Object _failureMessageFormatArgument
		/// </summary>
		protected RSystem.RObject r__failureMessageFormatArgument;
		public virtual RSystem.RObject R_failureMessageFormatArgument
		{
			get
			{
				if(r__failureMessageFormatArgument == null)
				{
					r__failureMessageFormatArgument = new(this, "_failureMessageFormatArgument");
					r__failureMessageFormatArgument.SetBelong(this.instance);
				}
				return r__failureMessageFormatArgument;
			}
		}

		/// <summary>
		/// System.String _failureArgumentName
		/// </summary>
		protected RField r__failureArgumentName;
		public virtual RField R_failureArgumentName
		{
			get
			{
				if(r__failureArgumentName == null)
				{
					r__failureArgumentName = new(this, "_failureArgumentName");
					r__failureArgumentName.SetBelong(this.instance);
				}
				return r__failureArgumentName;
			}
		}

		/// <summary>
		/// System.Exception _innerException
		/// </summary>
		protected RSystem.RException r__innerException;
		public virtual RSystem.RException R_innerException
		{
			get
			{
				if(r__innerException == null)
				{
					r__innerException = new(this, "_innerException");
					r__innerException.SetBelong(this.instance);
				}
				return r__innerException;
			}
		}

		/// <summary>
		/// Void Init(GuidParseThrowStyle)
		/// </summary>
		protected RMethod r_Init_GuidParseThrowStyle;
		public virtual RMethod RInit_GuidParseThrowStyle
		{
			get
			{
				if(r_Init_GuidParseThrowStyle == null)
				{
					r_Init_GuidParseThrowStyle = new(this, "Init", 0,  ReleactionUtils.GetType("System.Guid+GuidParseThrowStyle"));
					r_Init_GuidParseThrowStyle.SetBelong(this.instance);
				}
				return r_Init_GuidParseThrowStyle;
			}
		}

		/// <summary>
		/// Void SetFailure(System.Exception)
		/// </summary>
		protected RMethod r_SetFailure_Exception;
		public virtual RMethod RSetFailure_Exception
		{
			get
			{
				if(r_SetFailure_Exception == null)
				{
					r_SetFailure_Exception = new(this, "SetFailure", 0, typeof(System.Exception));
					r_SetFailure_Exception.SetBelong(this.instance);
				}
				return r_SetFailure_Exception;
			}
		}

		/// <summary>
		/// Void SetFailure(ParseFailureKind, System.String)
		/// </summary>
		protected RMethod r_SetFailure_ParseFailureKind_String;
		public virtual RMethod RSetFailure_ParseFailureKind_String
		{
			get
			{
				if(r_SetFailure_ParseFailureKind_String == null)
				{
					r_SetFailure_ParseFailureKind_String = new(this, "SetFailure", 0,  ReleactionUtils.GetType("System.Guid+ParseFailureKind"), typeof(System.String));
					r_SetFailure_ParseFailureKind_String.SetBelong(this.instance);
				}
				return r_SetFailure_ParseFailureKind_String;
			}
		}

		/// <summary>
		/// Void SetFailure(ParseFailureKind, System.String, System.Object)
		/// </summary>
		protected RMethod r_SetFailure_ParseFailureKind_String_Object;
		public virtual RMethod RSetFailure_ParseFailureKind_String_Object
		{
			get
			{
				if(r_SetFailure_ParseFailureKind_String_Object == null)
				{
					r_SetFailure_ParseFailureKind_String_Object = new(this, "SetFailure", 0,  ReleactionUtils.GetType("System.Guid+ParseFailureKind"), typeof(System.String), typeof(System.Object));
					r_SetFailure_ParseFailureKind_String_Object.SetBelong(this.instance);
				}
				return r_SetFailure_ParseFailureKind_String_Object;
			}
		}

		/// <summary>
		/// Void SetFailure(ParseFailureKind, System.String, System.Object, System.String, System.Exception)
		/// </summary>
		protected RMethod r_SetFailure_ParseFailureKind_String_Object_String_Exception;
		public virtual RMethod RSetFailure_ParseFailureKind_String_Object_String_Exception
		{
			get
			{
				if(r_SetFailure_ParseFailureKind_String_Object_String_Exception == null)
				{
					r_SetFailure_ParseFailureKind_String_Object_String_Exception = new(this, "SetFailure", 0,  ReleactionUtils.GetType("System.Guid+ParseFailureKind"), typeof(System.String), typeof(System.Object), typeof(System.String), typeof(System.Exception));
					r_SetFailure_ParseFailureKind_String_Object_String_Exception.SetBelong(this.instance);
				}
				return r_SetFailure_ParseFailureKind_String_Object_String_Exception;
			}
		}

		/// <summary>
		/// System.Exception GetGuidParseException()
		/// </summary>
		protected RMethod r_GetGuidParseException;
		public virtual RMethod RGetGuidParseException
		{
			get
			{
				if(r_GetGuidParseException == null)
				{
					r_GetGuidParseException = new(this, "GetGuidParseException", 0);
					r_GetGuidParseException.SetBelong(this.instance);
				}
				return r_GetGuidParseException;
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


        public virtual void SetFailure(System.Exception  @nativeException)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nativeException};
            var ___result = RSetFailure_Exception.Invoke(___genericsType, ___parameters);

            
        }





        public virtual System.Exception GetGuidParseException()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetGuidParseException.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
}