using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RMono
{
	/// <summary>
	/// Mono.RuntimeEventHandle
	/// </summary>
    public partial class RRuntimeEventHandle : RMember //
    {

		/// <summary>
		/// System.IntPtr value
		/// </summary>
		protected RSystem.RIntPtr r_Fvalue;
		public virtual RSystem.RIntPtr RFvalue
		{
			get
			{
				if(r_Fvalue == null)
				{
					r_Fvalue = new(this, "value");
					r_Fvalue.SetBelong(this.instance);
				}
				return r_Fvalue;
			}
		}

		/// <summary>
		/// IntPtr Value
		/// </summary>
		protected RSystem.RIntPtr r_PValue;
		public virtual RSystem.RIntPtr RPValue
		{
			get
			{
				if(r_PValue == null)
				{
					r_PValue = new(this, "Value", -1);
					r_PValue.SetBelong(this.instance);
				}
				return r_PValue;
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
		/// Boolean Equals(Mono.RuntimeEventHandle)
		/// </summary>
		protected RMethod r_MEquals_RuntimeEventHandle;
		public virtual RMethod RMEquals_RuntimeEventHandle
		{
			get
			{
				if(r_MEquals_RuntimeEventHandle == null)
				{
					r_MEquals_RuntimeEventHandle = new(this, "Equals", 0,  ReflectionUtils.GetType("Mono.RuntimeEventHandle"));
					r_MEquals_RuntimeEventHandle.SetBelong(this.instance);
				}
				return r_MEquals_RuntimeEventHandle;
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
		/// Boolean op_Equality(Mono.RuntimeEventHandle, Mono.RuntimeEventHandle)
		/// </summary>
		protected static RMethod r_Mop_Equality_RuntimeEventHandle_RuntimeEventHandle;
		public static RMethod RMop_Equality_RuntimeEventHandle_RuntimeEventHandle
		{
			get
			{
				if(r_Mop_Equality_RuntimeEventHandle_RuntimeEventHandle == null)
				{
					r_Mop_Equality_RuntimeEventHandle_RuntimeEventHandle = new( ReflectionUtils.GetType("Mono.RuntimeEventHandle"), "op_Equality", 0,  ReflectionUtils.GetType("Mono.RuntimeEventHandle"),  ReflectionUtils.GetType("Mono.RuntimeEventHandle"));
					r_Mop_Equality_RuntimeEventHandle_RuntimeEventHandle.SetBelong(null);
				}
				return r_Mop_Equality_RuntimeEventHandle_RuntimeEventHandle;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(Mono.RuntimeEventHandle, Mono.RuntimeEventHandle)
		/// </summary>
		protected static RMethod r_Mop_Inequality_RuntimeEventHandle_RuntimeEventHandle;
		public static RMethod RMop_Inequality_RuntimeEventHandle_RuntimeEventHandle
		{
			get
			{
				if(r_Mop_Inequality_RuntimeEventHandle_RuntimeEventHandle == null)
				{
					r_Mop_Inequality_RuntimeEventHandle_RuntimeEventHandle = new( ReflectionUtils.GetType("Mono.RuntimeEventHandle"), "op_Inequality", 0,  ReflectionUtils.GetType("Mono.RuntimeEventHandle"),  ReflectionUtils.GetType("Mono.RuntimeEventHandle"));
					r_Mop_Inequality_RuntimeEventHandle_RuntimeEventHandle.SetBelong(null);
				}
				return r_Mop_Inequality_RuntimeEventHandle_RuntimeEventHandle;
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


        public RRuntimeEventHandle() : base("Mono.RuntimeEventHandle")
        {
        }

        public RRuntimeEventHandle(System.Object instance) : base("Mono.RuntimeEventHandle")
		{
            SetInstance(instance);
		}

        public RRuntimeEventHandle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRuntimeEventHandle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(RMono.RRuntimeEventHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RMEquals_RuntimeEventHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(RMono.RRuntimeEventHandle @left, RMono.RRuntimeEventHandle @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = RMop_Equality_RuntimeEventHandle_RuntimeEventHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(RMono.RRuntimeEventHandle @left, RMono.RRuntimeEventHandle @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = RMop_Inequality_RuntimeEventHandle_RuntimeEventHandle.Invoke(___genericsType, ___parameters);

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
