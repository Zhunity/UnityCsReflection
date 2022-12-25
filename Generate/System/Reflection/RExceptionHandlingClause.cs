using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.ExceptionHandlingClause
	/// </summary>
    public partial class RExceptionHandlingClause : RMember //
    {

		/// <summary>
		/// System.Type catch_type
		/// </summary>
		protected RSystem.RType r_catch_type;
		public virtual RSystem.RType Rcatch_type
		{
			get
			{
				if(r_catch_type == null)
				{
					r_catch_type = new(this, "catch_type");
					r_catch_type.SetBelong(this.instance);
				}
				return r_catch_type;
			}
		}

		/// <summary>
		/// System.Int32 filter_offset
		/// </summary>
		protected RField r_filter_offset;
		public virtual RField Rfilter_offset
		{
			get
			{
				if(r_filter_offset == null)
				{
					r_filter_offset = new(this, "filter_offset");
					r_filter_offset.SetBelong(this.instance);
				}
				return r_filter_offset;
			}
		}

		/// <summary>
		/// System.Reflection.ExceptionHandlingClauseOptions flags
		/// </summary>
		protected RField r_flags;
		public virtual RField Rflags
		{
			get
			{
				if(r_flags == null)
				{
					r_flags = new(this, "flags");
					r_flags.SetBelong(this.instance);
				}
				return r_flags;
			}
		}

		/// <summary>
		/// System.Int32 try_offset
		/// </summary>
		protected RField r_try_offset;
		public virtual RField Rtry_offset
		{
			get
			{
				if(r_try_offset == null)
				{
					r_try_offset = new(this, "try_offset");
					r_try_offset.SetBelong(this.instance);
				}
				return r_try_offset;
			}
		}

		/// <summary>
		/// System.Int32 try_length
		/// </summary>
		protected RField r_try_length;
		public virtual RField Rtry_length
		{
			get
			{
				if(r_try_length == null)
				{
					r_try_length = new(this, "try_length");
					r_try_length.SetBelong(this.instance);
				}
				return r_try_length;
			}
		}

		/// <summary>
		/// System.Int32 handler_offset
		/// </summary>
		protected RField r_handler_offset;
		public virtual RField Rhandler_offset
		{
			get
			{
				if(r_handler_offset == null)
				{
					r_handler_offset = new(this, "handler_offset");
					r_handler_offset.SetBelong(this.instance);
				}
				return r_handler_offset;
			}
		}

		/// <summary>
		/// System.Int32 handler_length
		/// </summary>
		protected RField r_handler_length;
		public virtual RField Rhandler_length
		{
			get
			{
				if(r_handler_length == null)
				{
					r_handler_length = new(this, "handler_length");
					r_handler_length.SetBelong(this.instance);
				}
				return r_handler_length;
			}
		}

		/// <summary>
		/// System.Type CatchType
		/// </summary>
		protected RSystem.RType r_CatchType;
		public virtual RSystem.RType RCatchType
		{
			get
			{
				if(r_CatchType == null)
				{
					r_CatchType = new(this, "CatchType", -1);
					r_CatchType.SetBelong(this.instance);
				}
				return r_CatchType;
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
		/// System.Reflection.ExceptionHandlingClauseOptions Flags
		/// </summary>
		protected RProperty r_Flags;
		public virtual RProperty RFlags
		{
			get
			{
				if(r_Flags == null)
				{
					r_Flags = new(this, "Flags", -1);
					r_Flags.SetBelong(this.instance);
				}
				return r_Flags;
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


        public RExceptionHandlingClause() : base("System.Reflection.ExceptionHandlingClause")
        {
        }

        public RExceptionHandlingClause(System.Object instance) : base("System.Reflection.ExceptionHandlingClause")
		{
            SetInstance(instance);
		}

        public RExceptionHandlingClause(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RExceptionHandlingClause(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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


    }
}
