using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RMono
{
	/// <summary>
	/// Mono.RuntimePropertyHandle
	/// </summary>
    public partial class RRuntimePropertyHandle : RMember //
    {

		/// <summary>
		/// System.IntPtr value
		/// </summary>
		protected RField r_value;
		public virtual RField Rvalue
		{
			get
			{
				if(r_value == null)
				{
					r_value = new(this, "value");
					r_value.SetBelong(this.instance);
				}
				return r_value;
			}
		}

		/// <summary>
		/// IntPtr Value
		/// </summary>
		protected RProperty r_Value;
		public virtual RProperty RValue
		{
			get
			{
				if(r_Value == null)
				{
					r_Value = new(this, "Value", -1);
					r_Value.SetBelong(this.instance);
				}
				return r_Value;
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
		/// Boolean Equals(Mono.RuntimePropertyHandle)
		/// </summary>
		protected RMethod r_Equals_RuntimePropertyHandle;
		public virtual RMethod REquals_RuntimePropertyHandle
		{
			get
			{
				if(r_Equals_RuntimePropertyHandle == null)
				{
					r_Equals_RuntimePropertyHandle = new(this, "Equals", 0,  ReflectionUtils.GetType("Mono.RuntimePropertyHandle"));
					r_Equals_RuntimePropertyHandle.SetBelong(this.instance);
				}
				return r_Equals_RuntimePropertyHandle;
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
		/// Boolean op_Equality(Mono.RuntimePropertyHandle, Mono.RuntimePropertyHandle)
		/// </summary>
		protected static RMethod r_op_Equality_RuntimePropertyHandle_RuntimePropertyHandle;
		public static RMethod Rop_Equality_RuntimePropertyHandle_RuntimePropertyHandle
		{
			get
			{
				if(r_op_Equality_RuntimePropertyHandle_RuntimePropertyHandle == null)
				{
					r_op_Equality_RuntimePropertyHandle_RuntimePropertyHandle = new( ReflectionUtils.GetType("Mono.RuntimePropertyHandle"), "op_Equality", 0,  ReflectionUtils.GetType("Mono.RuntimePropertyHandle"),  ReflectionUtils.GetType("Mono.RuntimePropertyHandle"));
					r_op_Equality_RuntimePropertyHandle_RuntimePropertyHandle.SetBelong(null);
				}
				return r_op_Equality_RuntimePropertyHandle_RuntimePropertyHandle;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(Mono.RuntimePropertyHandle, Mono.RuntimePropertyHandle)
		/// </summary>
		protected static RMethod r_op_Inequality_RuntimePropertyHandle_RuntimePropertyHandle;
		public static RMethod Rop_Inequality_RuntimePropertyHandle_RuntimePropertyHandle
		{
			get
			{
				if(r_op_Inequality_RuntimePropertyHandle_RuntimePropertyHandle == null)
				{
					r_op_Inequality_RuntimePropertyHandle_RuntimePropertyHandle = new( ReflectionUtils.GetType("Mono.RuntimePropertyHandle"), "op_Inequality", 0,  ReflectionUtils.GetType("Mono.RuntimePropertyHandle"),  ReflectionUtils.GetType("Mono.RuntimePropertyHandle"));
					r_op_Inequality_RuntimePropertyHandle_RuntimePropertyHandle.SetBelong(null);
				}
				return r_op_Inequality_RuntimePropertyHandle_RuntimePropertyHandle;
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


        public RRuntimePropertyHandle() : base("Mono.RuntimePropertyHandle")
        {
        }

        public RRuntimePropertyHandle(System.Object instance) : base("Mono.RuntimePropertyHandle")
		{
            SetInstance(instance);
		}

        public RRuntimePropertyHandle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRuntimePropertyHandle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
