using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.ILExceptionBlock
	/// </summary>
    public partial class RILExceptionBlock : RMember //
    {

		/// <summary>
		/// System.Int32 CATCH
		/// </summary>
		protected static RField r_CATCH;
		public static RField RCATCH
		{
			get
			{
				if(r_CATCH == null)
				{
					r_CATCH = new( ReflectionUtils.GetType("System.Reflection.Emit.ILExceptionBlock"), "CATCH");
					r_CATCH.SetBelong(null);
				}
				return r_CATCH;
			}
		}

		/// <summary>
		/// System.Int32 FILTER
		/// </summary>
		protected static RField r_FILTER;
		public static RField RFILTER
		{
			get
			{
				if(r_FILTER == null)
				{
					r_FILTER = new( ReflectionUtils.GetType("System.Reflection.Emit.ILExceptionBlock"), "FILTER");
					r_FILTER.SetBelong(null);
				}
				return r_FILTER;
			}
		}

		/// <summary>
		/// System.Int32 FINALLY
		/// </summary>
		protected static RField r_FINALLY;
		public static RField RFINALLY
		{
			get
			{
				if(r_FINALLY == null)
				{
					r_FINALLY = new( ReflectionUtils.GetType("System.Reflection.Emit.ILExceptionBlock"), "FINALLY");
					r_FINALLY.SetBelong(null);
				}
				return r_FINALLY;
			}
		}

		/// <summary>
		/// System.Int32 FAULT
		/// </summary>
		protected static RField r_FAULT;
		public static RField RFAULT
		{
			get
			{
				if(r_FAULT == null)
				{
					r_FAULT = new( ReflectionUtils.GetType("System.Reflection.Emit.ILExceptionBlock"), "FAULT");
					r_FAULT.SetBelong(null);
				}
				return r_FAULT;
			}
		}

		/// <summary>
		/// System.Int32 FILTER_START
		/// </summary>
		protected static RField r_FILTER_START;
		public static RField RFILTER_START
		{
			get
			{
				if(r_FILTER_START == null)
				{
					r_FILTER_START = new( ReflectionUtils.GetType("System.Reflection.Emit.ILExceptionBlock"), "FILTER_START");
					r_FILTER_START.SetBelong(null);
				}
				return r_FILTER_START;
			}
		}

		/// <summary>
		/// System.Type extype
		/// </summary>
		protected RSystem.RType r_extype;
		public virtual RSystem.RType Rextype
		{
			get
			{
				if(r_extype == null)
				{
					r_extype = new(this, "extype");
					r_extype.SetBelong(this.instance);
				}
				return r_extype;
			}
		}

		/// <summary>
		/// System.Int32 type
		/// </summary>
		protected RField r_type;
		public virtual RField Rtype
		{
			get
			{
				if(r_type == null)
				{
					r_type = new(this, "type");
					r_type.SetBelong(this.instance);
				}
				return r_type;
			}
		}

		/// <summary>
		/// System.Int32 start
		/// </summary>
		protected RField r_start;
		public virtual RField Rstart
		{
			get
			{
				if(r_start == null)
				{
					r_start = new(this, "start");
					r_start.SetBelong(this.instance);
				}
				return r_start;
			}
		}

		/// <summary>
		/// System.Int32 len
		/// </summary>
		protected RField r_len;
		public virtual RField Rlen
		{
			get
			{
				if(r_len == null)
				{
					r_len = new(this, "len");
					r_len.SetBelong(this.instance);
				}
				return r_len;
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
		/// Void Debug()
		/// </summary>
		protected RMethod r_Debug;
		public virtual RMethod RDebug
		{
			get
			{
				if(r_Debug == null)
				{
					r_Debug = new(this, "Debug", 0);
					r_Debug.SetBelong(this.instance);
				}
				return r_Debug;
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


        public RILExceptionBlock() : base("System.Reflection.Emit.ILExceptionBlock")
        {
        }

        public RILExceptionBlock(System.Object instance) : base("System.Reflection.Emit.ILExceptionBlock")
		{
            SetInstance(instance);
		}

        public RILExceptionBlock(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RILExceptionBlock(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Debug()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDebug.Invoke(___genericsType, ___parameters);

            
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
