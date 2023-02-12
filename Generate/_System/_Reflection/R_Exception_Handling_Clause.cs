
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
		protected SMFrame.Editor.Refleaction.RSystem.RType r_Fcatch_type;
		public virtual SMFrame.Editor.Refleaction.RSystem.RType RFcatch_type
		{
			get
			{
				if(r_Fcatch_type == null)
				{
					r_Fcatch_type = new(this, "catch_type");
					r_Fcatch_type.SetBelong(this.instance);
				}
				return r_Fcatch_type;
			}
		}

		/// <summary>
		/// System.Int32 filter_offset
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Ffilter_offset;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFfilter_offset
		{
			get
			{
				if(r_Ffilter_offset == null)
				{
					r_Ffilter_offset = new(this, "filter_offset");
					r_Ffilter_offset.SetBelong(this.instance);
				}
				return r_Ffilter_offset;
			}
		}

		/// <summary>
		/// System.Reflection.ExceptionHandlingClauseOptions flags
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RExceptionHandlingClauseOptions r_Fflags;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RExceptionHandlingClauseOptions RFflags
		{
			get
			{
				if(r_Fflags == null)
				{
					r_Fflags = new(this, "flags");
					r_Fflags.SetBelong(this.instance);
				}
				return r_Fflags;
			}
		}

		/// <summary>
		/// System.Int32 try_offset
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Ftry_offset;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFtry_offset
		{
			get
			{
				if(r_Ftry_offset == null)
				{
					r_Ftry_offset = new(this, "try_offset");
					r_Ftry_offset.SetBelong(this.instance);
				}
				return r_Ftry_offset;
			}
		}

		/// <summary>
		/// System.Int32 try_length
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Ftry_length;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFtry_length
		{
			get
			{
				if(r_Ftry_length == null)
				{
					r_Ftry_length = new(this, "try_length");
					r_Ftry_length.SetBelong(this.instance);
				}
				return r_Ftry_length;
			}
		}

		/// <summary>
		/// System.Int32 handler_offset
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fhandler_offset;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFhandler_offset
		{
			get
			{
				if(r_Fhandler_offset == null)
				{
					r_Fhandler_offset = new(this, "handler_offset");
					r_Fhandler_offset.SetBelong(this.instance);
				}
				return r_Fhandler_offset;
			}
		}

		/// <summary>
		/// System.Int32 handler_length
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fhandler_length;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFhandler_length
		{
			get
			{
				if(r_Fhandler_length == null)
				{
					r_Fhandler_length = new(this, "handler_length");
					r_Fhandler_length.SetBelong(this.instance);
				}
				return r_Fhandler_length;
			}
		}

		/// <summary>
		/// System.Type CatchType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RType r_PCatchType;
		public virtual SMFrame.Editor.Refleaction.RSystem.RType RPCatchType
		{
			get
			{
				if(r_PCatchType == null)
				{
					r_PCatchType = new(this, "CatchType", -1);
					r_PCatchType.SetBelong(this.instance);
				}
				return r_PCatchType;
			}
		}

		/// <summary>
		/// Int32 FilterOffset
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PFilterOffset;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPFilterOffset
		{
			get
			{
				if(r_PFilterOffset == null)
				{
					r_PFilterOffset = new(this, "FilterOffset", -1);
					r_PFilterOffset.SetBelong(this.instance);
				}
				return r_PFilterOffset;
			}
		}

		/// <summary>
		/// System.Reflection.ExceptionHandlingClauseOptions Flags
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RExceptionHandlingClauseOptions r_PFlags;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RExceptionHandlingClauseOptions RPFlags
		{
			get
			{
				if(r_PFlags == null)
				{
					r_PFlags = new(this, "Flags", -1);
					r_PFlags.SetBelong(this.instance);
				}
				return r_PFlags;
			}
		}

		/// <summary>
		/// Int32 HandlerLength
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PHandlerLength;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPHandlerLength
		{
			get
			{
				if(r_PHandlerLength == null)
				{
					r_PHandlerLength = new(this, "HandlerLength", -1);
					r_PHandlerLength.SetBelong(this.instance);
				}
				return r_PHandlerLength;
			}
		}

		/// <summary>
		/// Int32 HandlerOffset
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PHandlerOffset;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPHandlerOffset
		{
			get
			{
				if(r_PHandlerOffset == null)
				{
					r_PHandlerOffset = new(this, "HandlerOffset", -1);
					r_PHandlerOffset.SetBelong(this.instance);
				}
				return r_PHandlerOffset;
			}
		}

		/// <summary>
		/// Int32 TryLength
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PTryLength;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPTryLength
		{
			get
			{
				if(r_PTryLength == null)
				{
					r_PTryLength = new(this, "TryLength", -1);
					r_PTryLength.SetBelong(this.instance);
				}
				return r_PTryLength;
			}
		}

		/// <summary>
		/// Int32 TryOffset
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PTryOffset;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPTryOffset
		{
			get
			{
				if(r_PTryOffset == null)
				{
					r_PTryOffset = new(this, "TryOffset", -1);
					r_PTryOffset.SetBelong(this.instance);
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
					r_MToString.SetBelong(this.instance);
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
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
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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


    }
}
