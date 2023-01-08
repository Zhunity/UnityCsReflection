using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.GraphicsBufferHandle
	/// </summary>
    public partial class RGraphicsBufferHandle : RMember //
    {

		/// <summary>
		/// System.UInt32 value
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
		/// Boolean Equals(UnityEngine.GraphicsBufferHandle)
		/// </summary>
		protected RMethod r_Equals_GraphicsBufferHandle;
		public virtual RMethod REquals_GraphicsBufferHandle
		{
			get
			{
				if(r_Equals_GraphicsBufferHandle == null)
				{
					r_Equals_GraphicsBufferHandle = new(this, "Equals", 0, typeof(UnityEngine.GraphicsBufferHandle));
					r_Equals_GraphicsBufferHandle.SetBelong(this.instance);
				}
				return r_Equals_GraphicsBufferHandle;
			}
		}

		/// <summary>
		/// Int32 CompareTo(UnityEngine.GraphicsBufferHandle)
		/// </summary>
		protected RMethod r_CompareTo_GraphicsBufferHandle;
		public virtual RMethod RCompareTo_GraphicsBufferHandle
		{
			get
			{
				if(r_CompareTo_GraphicsBufferHandle == null)
				{
					r_CompareTo_GraphicsBufferHandle = new(this, "CompareTo", 0, typeof(UnityEngine.GraphicsBufferHandle));
					r_CompareTo_GraphicsBufferHandle.SetBelong(this.instance);
				}
				return r_CompareTo_GraphicsBufferHandle;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.GraphicsBufferHandle, UnityEngine.GraphicsBufferHandle)
		/// </summary>
		protected static RMethod r_op_Equality_GraphicsBufferHandle_GraphicsBufferHandle;
		public static RMethod Rop_Equality_GraphicsBufferHandle_GraphicsBufferHandle
		{
			get
			{
				if(r_op_Equality_GraphicsBufferHandle_GraphicsBufferHandle == null)
				{
					r_op_Equality_GraphicsBufferHandle_GraphicsBufferHandle = new(typeof(UnityEngine.GraphicsBufferHandle), "op_Equality", 0, typeof(UnityEngine.GraphicsBufferHandle), typeof(UnityEngine.GraphicsBufferHandle));
					r_op_Equality_GraphicsBufferHandle_GraphicsBufferHandle.SetBelong(null);
				}
				return r_op_Equality_GraphicsBufferHandle_GraphicsBufferHandle;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.GraphicsBufferHandle, UnityEngine.GraphicsBufferHandle)
		/// </summary>
		protected static RMethod r_op_Inequality_GraphicsBufferHandle_GraphicsBufferHandle;
		public static RMethod Rop_Inequality_GraphicsBufferHandle_GraphicsBufferHandle
		{
			get
			{
				if(r_op_Inequality_GraphicsBufferHandle_GraphicsBufferHandle == null)
				{
					r_op_Inequality_GraphicsBufferHandle_GraphicsBufferHandle = new(typeof(UnityEngine.GraphicsBufferHandle), "op_Inequality", 0, typeof(UnityEngine.GraphicsBufferHandle), typeof(UnityEngine.GraphicsBufferHandle));
					r_op_Inequality_GraphicsBufferHandle_GraphicsBufferHandle.SetBelong(null);
				}
				return r_op_Inequality_GraphicsBufferHandle_GraphicsBufferHandle;
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


        public RGraphicsBufferHandle() : base("UnityEngine.GraphicsBufferHandle")
        {
        }

        public RGraphicsBufferHandle(System.Object instance) : base("UnityEngine.GraphicsBufferHandle")
		{
            SetInstance(instance);
		}

        public RGraphicsBufferHandle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGraphicsBufferHandle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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


        public virtual System.Boolean Equals(UnityEngine.GraphicsBufferHandle  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_GraphicsBufferHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 CompareTo(UnityEngine.GraphicsBufferHandle  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RCompareTo_GraphicsBufferHandle.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.GraphicsBufferHandle  @a, UnityEngine.GraphicsBufferHandle  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Equality_GraphicsBufferHandle_GraphicsBufferHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.GraphicsBufferHandle  @a, UnityEngine.GraphicsBufferHandle  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Inequality_GraphicsBufferHandle_GraphicsBufferHandle.Invoke(___genericsType, ___parameters);

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
