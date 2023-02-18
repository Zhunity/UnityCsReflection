
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.ExceptionHandler
	/// </summary>
    public partial class RExceptionHandler : RMember //
    {

		/// <summary>
		/// System.Int32 m_exceptionClass
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_exceptionClass;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_exceptionClass
		{
			get
			{
				if(r_Fm_exceptionClass == null)
				{
					r_Fm_exceptionClass = new(this, "m_exceptionClass");
					r_Fm_exceptionClass.SetBelong(this.GetValue());
				}
				return r_Fm_exceptionClass;
			}
		}

		/// <summary>
		/// System.Int32 m_tryStartOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_tryStartOffset;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_tryStartOffset
		{
			get
			{
				if(r_Fm_tryStartOffset == null)
				{
					r_Fm_tryStartOffset = new(this, "m_tryStartOffset");
					r_Fm_tryStartOffset.SetBelong(this.GetValue());
				}
				return r_Fm_tryStartOffset;
			}
		}

		/// <summary>
		/// System.Int32 m_tryEndOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_tryEndOffset;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_tryEndOffset
		{
			get
			{
				if(r_Fm_tryEndOffset == null)
				{
					r_Fm_tryEndOffset = new(this, "m_tryEndOffset");
					r_Fm_tryEndOffset.SetBelong(this.GetValue());
				}
				return r_Fm_tryEndOffset;
			}
		}

		/// <summary>
		/// System.Int32 m_filterOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_filterOffset;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_filterOffset
		{
			get
			{
				if(r_Fm_filterOffset == null)
				{
					r_Fm_filterOffset = new(this, "m_filterOffset");
					r_Fm_filterOffset.SetBelong(this.GetValue());
				}
				return r_Fm_filterOffset;
			}
		}

		/// <summary>
		/// System.Int32 m_handlerStartOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_handlerStartOffset;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_handlerStartOffset
		{
			get
			{
				if(r_Fm_handlerStartOffset == null)
				{
					r_Fm_handlerStartOffset = new(this, "m_handlerStartOffset");
					r_Fm_handlerStartOffset.SetBelong(this.GetValue());
				}
				return r_Fm_handlerStartOffset;
			}
		}

		/// <summary>
		/// System.Int32 m_handlerEndOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_handlerEndOffset;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_handlerEndOffset
		{
			get
			{
				if(r_Fm_handlerEndOffset == null)
				{
					r_Fm_handlerEndOffset = new(this, "m_handlerEndOffset");
					r_Fm_handlerEndOffset.SetBelong(this.GetValue());
				}
				return r_Fm_handlerEndOffset;
			}
		}

		/// <summary>
		/// System.Reflection.ExceptionHandlingClauseOptions m_kind
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RExceptionHandlingClauseOptions r_Fm_kind;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RExceptionHandlingClauseOptions RFm_kind
		{
			get
			{
				if(r_Fm_kind == null)
				{
					r_Fm_kind = new(this, "m_kind");
					r_Fm_kind.SetBelong(this.GetValue());
				}
				return r_Fm_kind;
			}
		}

		/// <summary>
		/// Int32 ExceptionTypeToken
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PExceptionTypeToken;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPExceptionTypeToken
		{
			get
			{
				if(r_PExceptionTypeToken == null)
				{
					r_PExceptionTypeToken = new(this, "ExceptionTypeToken", -1);
					r_PExceptionTypeToken.SetBelong(this.GetValue());
				}
				return r_PExceptionTypeToken;
			}
		}

		/// <summary>
		/// Int32 TryOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PTryOffset;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPTryOffset
		{
			get
			{
				if(r_PTryOffset == null)
				{
					r_PTryOffset = new(this, "TryOffset", -1);
					r_PTryOffset.SetBelong(this.GetValue());
				}
				return r_PTryOffset;
			}
		}

		/// <summary>
		/// Int32 TryLength
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PTryLength;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPTryLength
		{
			get
			{
				if(r_PTryLength == null)
				{
					r_PTryLength = new(this, "TryLength", -1);
					r_PTryLength.SetBelong(this.GetValue());
				}
				return r_PTryLength;
			}
		}

		/// <summary>
		/// Int32 FilterOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PFilterOffset;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPFilterOffset
		{
			get
			{
				if(r_PFilterOffset == null)
				{
					r_PFilterOffset = new(this, "FilterOffset", -1);
					r_PFilterOffset.SetBelong(this.GetValue());
				}
				return r_PFilterOffset;
			}
		}

		/// <summary>
		/// Int32 HandlerOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PHandlerOffset;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPHandlerOffset
		{
			get
			{
				if(r_PHandlerOffset == null)
				{
					r_PHandlerOffset = new(this, "HandlerOffset", -1);
					r_PHandlerOffset.SetBelong(this.GetValue());
				}
				return r_PHandlerOffset;
			}
		}

		/// <summary>
		/// Int32 HandlerLength
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PHandlerLength;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPHandlerLength
		{
			get
			{
				if(r_PHandlerLength == null)
				{
					r_PHandlerLength = new(this, "HandlerLength", -1);
					r_PHandlerLength.SetBelong(this.GetValue());
				}
				return r_PHandlerLength;
			}
		}

		/// <summary>
		/// System.Reflection.ExceptionHandlingClauseOptions Kind
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RExceptionHandlingClauseOptions r_PKind;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RExceptionHandlingClauseOptions RPKind
		{
			get
			{
				if(r_PKind == null)
				{
					r_PKind = new(this, "Kind", -1);
					r_PKind.SetBelong(this.GetValue());
				}
				return r_PKind;
			}
		}

		/// <summary>
		/// Boolean IsValidKind(System.Reflection.ExceptionHandlingClauseOptions)
		/// </summary>
		protected static RMethod r_MIsValidKind_ExceptionHandlingClauseOptions;
		public static RMethod RMIsValidKind_ExceptionHandlingClauseOptions
		{
			get
			{
				if(r_MIsValidKind_ExceptionHandlingClauseOptions == null)
				{
					r_MIsValidKind_ExceptionHandlingClauseOptions = new(typeof(System.Reflection.Emit.ExceptionHandler), "IsValidKind", 0, typeof(System.Reflection.ExceptionHandlingClauseOptions));
					r_MIsValidKind_ExceptionHandlingClauseOptions.SetBelong(null);
				}
				return r_MIsValidKind_ExceptionHandlingClauseOptions;
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
		/// Boolean Equals(System.Reflection.Emit.ExceptionHandler)
		/// </summary>
		protected RMethod r_MEquals_ExceptionHandler;
		public virtual RMethod RMEquals_ExceptionHandler
		{
			get
			{
				if(r_MEquals_ExceptionHandler == null)
				{
					r_MEquals_ExceptionHandler = new(this, "Equals", 0, typeof(System.Reflection.Emit.ExceptionHandler));
					r_MEquals_ExceptionHandler.SetBelong(this.GetValue());
				}
				return r_MEquals_ExceptionHandler;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Reflection.Emit.ExceptionHandler, System.Reflection.Emit.ExceptionHandler)
		/// </summary>
		protected static RMethod r_Mop_Equality_ExceptionHandler_ExceptionHandler;
		public static RMethod RMop_Equality_ExceptionHandler_ExceptionHandler
		{
			get
			{
				if(r_Mop_Equality_ExceptionHandler_ExceptionHandler == null)
				{
					r_Mop_Equality_ExceptionHandler_ExceptionHandler = new(typeof(System.Reflection.Emit.ExceptionHandler), "op_Equality", 0, typeof(System.Reflection.Emit.ExceptionHandler), typeof(System.Reflection.Emit.ExceptionHandler));
					r_Mop_Equality_ExceptionHandler_ExceptionHandler.SetBelong(null);
				}
				return r_Mop_Equality_ExceptionHandler_ExceptionHandler;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Reflection.Emit.ExceptionHandler, System.Reflection.Emit.ExceptionHandler)
		/// </summary>
		protected static RMethod r_Mop_Inequality_ExceptionHandler_ExceptionHandler;
		public static RMethod RMop_Inequality_ExceptionHandler_ExceptionHandler
		{
			get
			{
				if(r_Mop_Inequality_ExceptionHandler_ExceptionHandler == null)
				{
					r_Mop_Inequality_ExceptionHandler_ExceptionHandler = new(typeof(System.Reflection.Emit.ExceptionHandler), "op_Inequality", 0, typeof(System.Reflection.Emit.ExceptionHandler), typeof(System.Reflection.Emit.ExceptionHandler));
					r_Mop_Inequality_ExceptionHandler_ExceptionHandler.SetBelong(null);
				}
				return r_Mop_Inequality_ExceptionHandler_ExceptionHandler;
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

        public static System.Boolean IsValidKind(System.Reflection.ExceptionHandlingClauseOptions @kind)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kind};
            var ___result = RMIsValidKind_ExceptionHandlingClauseOptions.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Reflection.Emit.ExceptionHandler @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_ExceptionHandler.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(System.Reflection.Emit.ExceptionHandler @left, System.Reflection.Emit.ExceptionHandler @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Equality_ExceptionHandler_ExceptionHandler.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Reflection.Emit.ExceptionHandler @left, System.Reflection.Emit.ExceptionHandler @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Inequality_ExceptionHandler_ExceptionHandler.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
