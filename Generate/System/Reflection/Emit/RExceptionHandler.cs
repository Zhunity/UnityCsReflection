using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.ExceptionHandler
	/// </summary>
    public partial class RExceptionHandler : RMember //
    {

		/// <summary>
		/// System.Int32 m_exceptionClass
		/// </summary>
		protected RField r_m_exceptionClass;
		public virtual RField Rm_exceptionClass
		{
			get
			{
				if(r_m_exceptionClass == null)
				{
					r_m_exceptionClass = new(this, "m_exceptionClass");
					r_m_exceptionClass.SetBelong(this.instance);
				}
				return r_m_exceptionClass;
			}
		}

		/// <summary>
		/// System.Int32 m_tryStartOffset
		/// </summary>
		protected RField r_m_tryStartOffset;
		public virtual RField Rm_tryStartOffset
		{
			get
			{
				if(r_m_tryStartOffset == null)
				{
					r_m_tryStartOffset = new(this, "m_tryStartOffset");
					r_m_tryStartOffset.SetBelong(this.instance);
				}
				return r_m_tryStartOffset;
			}
		}

		/// <summary>
		/// System.Int32 m_tryEndOffset
		/// </summary>
		protected RField r_m_tryEndOffset;
		public virtual RField Rm_tryEndOffset
		{
			get
			{
				if(r_m_tryEndOffset == null)
				{
					r_m_tryEndOffset = new(this, "m_tryEndOffset");
					r_m_tryEndOffset.SetBelong(this.instance);
				}
				return r_m_tryEndOffset;
			}
		}

		/// <summary>
		/// System.Int32 m_filterOffset
		/// </summary>
		protected RField r_m_filterOffset;
		public virtual RField Rm_filterOffset
		{
			get
			{
				if(r_m_filterOffset == null)
				{
					r_m_filterOffset = new(this, "m_filterOffset");
					r_m_filterOffset.SetBelong(this.instance);
				}
				return r_m_filterOffset;
			}
		}

		/// <summary>
		/// System.Int32 m_handlerStartOffset
		/// </summary>
		protected RField r_m_handlerStartOffset;
		public virtual RField Rm_handlerStartOffset
		{
			get
			{
				if(r_m_handlerStartOffset == null)
				{
					r_m_handlerStartOffset = new(this, "m_handlerStartOffset");
					r_m_handlerStartOffset.SetBelong(this.instance);
				}
				return r_m_handlerStartOffset;
			}
		}

		/// <summary>
		/// System.Int32 m_handlerEndOffset
		/// </summary>
		protected RField r_m_handlerEndOffset;
		public virtual RField Rm_handlerEndOffset
		{
			get
			{
				if(r_m_handlerEndOffset == null)
				{
					r_m_handlerEndOffset = new(this, "m_handlerEndOffset");
					r_m_handlerEndOffset.SetBelong(this.instance);
				}
				return r_m_handlerEndOffset;
			}
		}

		/// <summary>
		/// System.Reflection.ExceptionHandlingClauseOptions m_kind
		/// </summary>
		protected RField r_m_kind;
		public virtual RField Rm_kind
		{
			get
			{
				if(r_m_kind == null)
				{
					r_m_kind = new(this, "m_kind");
					r_m_kind.SetBelong(this.instance);
				}
				return r_m_kind;
			}
		}

		/// <summary>
		/// Int32 ExceptionTypeToken
		/// </summary>
		protected RProperty r_ExceptionTypeToken;
		public virtual RProperty RExceptionTypeToken
		{
			get
			{
				if(r_ExceptionTypeToken == null)
				{
					r_ExceptionTypeToken = new(this, "ExceptionTypeToken", -1);
					r_ExceptionTypeToken.SetBelong(this.instance);
				}
				return r_ExceptionTypeToken;
			}
		}

		/// <summary>
		/// Int32 TryOffset
		/// </summary>
		protected RProperty r_TryOffset;
		public virtual RProperty RTryOffset
		{
			get
			{
				if(r_TryOffset == null)
				{
					r_TryOffset = new(this, "TryOffset", -1);
					r_TryOffset.SetBelong(this.instance);
				}
				return r_TryOffset;
			}
		}

		/// <summary>
		/// Int32 TryLength
		/// </summary>
		protected RProperty r_TryLength;
		public virtual RProperty RTryLength
		{
			get
			{
				if(r_TryLength == null)
				{
					r_TryLength = new(this, "TryLength", -1);
					r_TryLength.SetBelong(this.instance);
				}
				return r_TryLength;
			}
		}

		/// <summary>
		/// Int32 FilterOffset
		/// </summary>
		protected RProperty r_FilterOffset;
		public virtual RProperty RFilterOffset
		{
			get
			{
				if(r_FilterOffset == null)
				{
					r_FilterOffset = new(this, "FilterOffset", -1);
					r_FilterOffset.SetBelong(this.instance);
				}
				return r_FilterOffset;
			}
		}

		/// <summary>
		/// Int32 HandlerOffset
		/// </summary>
		protected RProperty r_HandlerOffset;
		public virtual RProperty RHandlerOffset
		{
			get
			{
				if(r_HandlerOffset == null)
				{
					r_HandlerOffset = new(this, "HandlerOffset", -1);
					r_HandlerOffset.SetBelong(this.instance);
				}
				return r_HandlerOffset;
			}
		}

		/// <summary>
		/// Int32 HandlerLength
		/// </summary>
		protected RProperty r_HandlerLength;
		public virtual RProperty RHandlerLength
		{
			get
			{
				if(r_HandlerLength == null)
				{
					r_HandlerLength = new(this, "HandlerLength", -1);
					r_HandlerLength.SetBelong(this.instance);
				}
				return r_HandlerLength;
			}
		}

		/// <summary>
		/// System.Reflection.ExceptionHandlingClauseOptions Kind
		/// </summary>
		protected RProperty r_Kind;
		public virtual RProperty RKind
		{
			get
			{
				if(r_Kind == null)
				{
					r_Kind = new(this, "Kind", -1);
					r_Kind.SetBelong(this.instance);
				}
				return r_Kind;
			}
		}

		/// <summary>
		/// Boolean IsValidKind(System.Reflection.ExceptionHandlingClauseOptions)
		/// </summary>
		protected static RMethod r_RIsValidKind_ExceptionHandlingClauseOptions;
		public static RMethod RIsValidKind_ExceptionHandlingClauseOptions
		{
			get
			{
				if(r_RIsValidKind_ExceptionHandlingClauseOptions == null)
				{
					r_RIsValidKind_ExceptionHandlingClauseOptions = new(typeof(System.Reflection.Emit.ExceptionHandler), "IsValidKind", 0, typeof(System.Reflection.ExceptionHandlingClauseOptions));
					r_RIsValidKind_ExceptionHandlingClauseOptions.SetBelong(null);
				}
				return r_RIsValidKind_ExceptionHandlingClauseOptions;
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
		/// Boolean Equals(System.Reflection.Emit.ExceptionHandler)
		/// </summary>
		protected RMethod r_REquals_ExceptionHandler;
		public virtual RMethod REquals_ExceptionHandler
		{
			get
			{
				if(r_REquals_ExceptionHandler == null)
				{
					r_REquals_ExceptionHandler = new(this, "Equals", 0, typeof(System.Reflection.Emit.ExceptionHandler));
					r_REquals_ExceptionHandler.SetBelong(this.instance);
				}
				return r_REquals_ExceptionHandler;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Reflection.Emit.ExceptionHandler, System.Reflection.Emit.ExceptionHandler)
		/// </summary>
		protected static RMethod r_Rop_Equality_ExceptionHandler_ExceptionHandler;
		public static RMethod Rop_Equality_ExceptionHandler_ExceptionHandler
		{
			get
			{
				if(r_Rop_Equality_ExceptionHandler_ExceptionHandler == null)
				{
					r_Rop_Equality_ExceptionHandler_ExceptionHandler = new(typeof(System.Reflection.Emit.ExceptionHandler), "op_Equality", 0, typeof(System.Reflection.Emit.ExceptionHandler), typeof(System.Reflection.Emit.ExceptionHandler));
					r_Rop_Equality_ExceptionHandler_ExceptionHandler.SetBelong(null);
				}
				return r_Rop_Equality_ExceptionHandler_ExceptionHandler;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Reflection.Emit.ExceptionHandler, System.Reflection.Emit.ExceptionHandler)
		/// </summary>
		protected static RMethod r_Rop_Inequality_ExceptionHandler_ExceptionHandler;
		public static RMethod Rop_Inequality_ExceptionHandler_ExceptionHandler
		{
			get
			{
				if(r_Rop_Inequality_ExceptionHandler_ExceptionHandler == null)
				{
					r_Rop_Inequality_ExceptionHandler_ExceptionHandler = new(typeof(System.Reflection.Emit.ExceptionHandler), "op_Inequality", 0, typeof(System.Reflection.Emit.ExceptionHandler), typeof(System.Reflection.Emit.ExceptionHandler));
					r_Rop_Inequality_ExceptionHandler_ExceptionHandler.SetBelong(null);
				}
				return r_Rop_Inequality_ExceptionHandler_ExceptionHandler;
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


        public RExceptionHandler() : base("System.Reflection.Emit.ExceptionHandler")
        {
        }

        public RExceptionHandler(System.Object instance) : base("System.Reflection.Emit.ExceptionHandler")
		{
            SetInstance(instance);
		}

        public RExceptionHandler(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RExceptionHandler(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean IsValidKind(System.Reflection.ExceptionHandlingClauseOptions  @kind)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kind};
            var ___result = RIsValidKind_ExceptionHandlingClauseOptions.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Reflection.Emit.ExceptionHandler  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_ExceptionHandler.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(System.Reflection.Emit.ExceptionHandler  @left, System.Reflection.Emit.ExceptionHandler  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Equality_ExceptionHandler_ExceptionHandler.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Reflection.Emit.ExceptionHandler  @left, System.Reflection.Emit.ExceptionHandler  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Inequality_ExceptionHandler_ExceptionHandler.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
