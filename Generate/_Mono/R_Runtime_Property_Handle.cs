
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RMono
{
	/// <summary>
	/// Mono.RuntimePropertyHandle
	/// </summary>
    public partial class RRuntimePropertyHandle : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("Mono.RuntimePropertyHandle");
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


		/// <summary>
		/// System.IntPtr value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fvalue;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFvalue
		{
			get
			{
				if(r_Fvalue == null)
				{
					r_Fvalue = new(this, "value");
				}
				return r_Fvalue;
			}
		}

		/// <summary>
		/// IntPtr Value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_PValue;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RPValue
		{
			get
			{
				if(r_PValue == null)
				{
					r_PValue = new(this, "Value", -1);
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
				}
				return r_MEquals_Object;
			}
		}

		/// <summary>
		/// Boolean Equals(Mono.RuntimePropertyHandle)
		/// </summary>
		protected RMethod r_MEquals_RuntimePropertyHandle;
		public virtual RMethod RMEquals_RuntimePropertyHandle
		{
			get
			{
				if(r_MEquals_RuntimePropertyHandle == null)
				{
					r_MEquals_RuntimePropertyHandle = new(this, "Equals", 0,  ReflectionUtils.GetType("Mono.RuntimePropertyHandle"));
				}
				return r_MEquals_RuntimePropertyHandle;
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
		/// Boolean op_Equality(Mono.RuntimePropertyHandle, Mono.RuntimePropertyHandle)
		/// </summary>
		protected static RMethod r_Mop_Equality_RuntimePropertyHandle_RuntimePropertyHandle;
		public static RMethod RMop_Equality_RuntimePropertyHandle_RuntimePropertyHandle
		{
			get
			{
				if(r_Mop_Equality_RuntimePropertyHandle_RuntimePropertyHandle == null)
				{
					r_Mop_Equality_RuntimePropertyHandle_RuntimePropertyHandle = new( ReflectionUtils.GetType("Mono.RuntimePropertyHandle"), "op_Equality", 0,  ReflectionUtils.GetType("Mono.RuntimePropertyHandle"),  ReflectionUtils.GetType("Mono.RuntimePropertyHandle"));
				}
				return r_Mop_Equality_RuntimePropertyHandle_RuntimePropertyHandle;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(Mono.RuntimePropertyHandle, Mono.RuntimePropertyHandle)
		/// </summary>
		protected static RMethod r_Mop_Inequality_RuntimePropertyHandle_RuntimePropertyHandle;
		public static RMethod RMop_Inequality_RuntimePropertyHandle_RuntimePropertyHandle
		{
			get
			{
				if(r_Mop_Inequality_RuntimePropertyHandle_RuntimePropertyHandle == null)
				{
					r_Mop_Inequality_RuntimePropertyHandle_RuntimePropertyHandle = new( ReflectionUtils.GetType("Mono.RuntimePropertyHandle"), "op_Inequality", 0,  ReflectionUtils.GetType("Mono.RuntimePropertyHandle"),  ReflectionUtils.GetType("Mono.RuntimePropertyHandle"));
				}
				return r_Mop_Inequality_RuntimePropertyHandle_RuntimePropertyHandle;
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


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(Hvak.Editor.Refleaction.RMono.RRuntimePropertyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RMEquals_RuntimePropertyHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(Hvak.Editor.Refleaction.RMono.RRuntimePropertyHandle @left, Hvak.Editor.Refleaction.RMono.RRuntimePropertyHandle @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = RMop_Equality_RuntimePropertyHandle_RuntimePropertyHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(Hvak.Editor.Refleaction.RMono.RRuntimePropertyHandle @left, Hvak.Editor.Refleaction.RMono.RRuntimePropertyHandle @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = RMop_Inequality_RuntimePropertyHandle_RuntimePropertyHandle.Invoke(___genericsType, ___parameters);

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
