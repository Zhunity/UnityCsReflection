
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Reflection.ExceptionHandlingClause
	/// </summary>
    public partial class RExceptionHandlingClause : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Reflection.ExceptionHandlingClause);
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


		/// <summary>
		/// System.Type catch_type
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_Fcatch_type;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RFcatch_type
		{
			get
			{
				if(r_Fcatch_type == null)
				{
					r_Fcatch_type = new(this, "catch_type");
				}
				return r_Fcatch_type;
			}
		}

		/// <summary>
		/// System.Int32 filter_offset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Ffilter_offset;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFfilter_offset
		{
			get
			{
				if(r_Ffilter_offset == null)
				{
					r_Ffilter_offset = new(this, "filter_offset");
				}
				return r_Ffilter_offset;
			}
		}

		/// <summary>
		/// System.Reflection.ExceptionHandlingClauseOptions flags
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RExceptionHandlingClauseOptions r_Fflags;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RExceptionHandlingClauseOptions RFflags
		{
			get
			{
				if(r_Fflags == null)
				{
					r_Fflags = new(this, "flags");
				}
				return r_Fflags;
			}
		}

		/// <summary>
		/// System.Int32 try_offset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Ftry_offset;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFtry_offset
		{
			get
			{
				if(r_Ftry_offset == null)
				{
					r_Ftry_offset = new(this, "try_offset");
				}
				return r_Ftry_offset;
			}
		}

		/// <summary>
		/// System.Int32 try_length
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Ftry_length;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFtry_length
		{
			get
			{
				if(r_Ftry_length == null)
				{
					r_Ftry_length = new(this, "try_length");
				}
				return r_Ftry_length;
			}
		}

		/// <summary>
		/// System.Int32 handler_offset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fhandler_offset;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFhandler_offset
		{
			get
			{
				if(r_Fhandler_offset == null)
				{
					r_Fhandler_offset = new(this, "handler_offset");
				}
				return r_Fhandler_offset;
			}
		}

		/// <summary>
		/// System.Int32 handler_length
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fhandler_length;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFhandler_length
		{
			get
			{
				if(r_Fhandler_length == null)
				{
					r_Fhandler_length = new(this, "handler_length");
				}
				return r_Fhandler_length;
			}
		}

		/// <summary>
		/// System.Type CatchType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_PCatchType;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RPCatchType
		{
			get
			{
				if(r_PCatchType == null)
				{
					r_PCatchType = new(this, "CatchType", -1);
				}
				return r_PCatchType;
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
				}
				return r_PFilterOffset;
			}
		}

		/// <summary>
		/// System.Reflection.ExceptionHandlingClauseOptions Flags
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RExceptionHandlingClauseOptions r_PFlags;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RExceptionHandlingClauseOptions RPFlags
		{
			get
			{
				if(r_PFlags == null)
				{
					r_PFlags = new(this, "Flags", -1);
				}
				return r_PFlags;
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
				}
				return r_PHandlerLength;
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
				}
				return r_PHandlerOffset;
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
				}
				return r_PTryLength;
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
				}
				return r_PTryOffset;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
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
