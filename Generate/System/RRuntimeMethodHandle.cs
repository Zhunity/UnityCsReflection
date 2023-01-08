using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.RuntimeMethodHandle
	/// </summary>
    public partial class RRuntimeMethodHandle : RMember //
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
		/// Void GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_GetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RGetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_GetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_GetObjectData_SerializationInfo_StreamingContext = new(this, "GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_GetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_GetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// IntPtr GetFunctionPointer(IntPtr)
		/// </summary>
		protected static RMethod r_GetFunctionPointer_IntPtr;
		public static RMethod RGetFunctionPointer_IntPtr
		{
			get
			{
				if(r_GetFunctionPointer_IntPtr == null)
				{
					r_GetFunctionPointer_IntPtr = new(typeof(System.RuntimeMethodHandle), "GetFunctionPointer", 0, typeof(System.IntPtr));
					r_GetFunctionPointer_IntPtr.SetBelong(null);
				}
				return r_GetFunctionPointer_IntPtr;
			}
		}

		/// <summary>
		/// IntPtr GetFunctionPointer()
		/// </summary>
		protected RMethod r_GetFunctionPointer;
		public virtual RMethod RGetFunctionPointer
		{
			get
			{
				if(r_GetFunctionPointer == null)
				{
					r_GetFunctionPointer = new(this, "GetFunctionPointer", 0);
					r_GetFunctionPointer.SetBelong(this.instance);
				}
				return r_GetFunctionPointer;
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
		/// Boolean Equals(System.RuntimeMethodHandle)
		/// </summary>
		protected RMethod r_Equals_RuntimeMethodHandle;
		public virtual RMethod REquals_RuntimeMethodHandle
		{
			get
			{
				if(r_Equals_RuntimeMethodHandle == null)
				{
					r_Equals_RuntimeMethodHandle = new(this, "Equals", 0, typeof(System.RuntimeMethodHandle));
					r_Equals_RuntimeMethodHandle.SetBelong(this.instance);
				}
				return r_Equals_RuntimeMethodHandle;
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
		/// Boolean op_Equality(System.RuntimeMethodHandle, System.RuntimeMethodHandle)
		/// </summary>
		protected static RMethod r_op_Equality_RuntimeMethodHandle_RuntimeMethodHandle;
		public static RMethod Rop_Equality_RuntimeMethodHandle_RuntimeMethodHandle
		{
			get
			{
				if(r_op_Equality_RuntimeMethodHandle_RuntimeMethodHandle == null)
				{
					r_op_Equality_RuntimeMethodHandle_RuntimeMethodHandle = new(typeof(System.RuntimeMethodHandle), "op_Equality", 0, typeof(System.RuntimeMethodHandle), typeof(System.RuntimeMethodHandle));
					r_op_Equality_RuntimeMethodHandle_RuntimeMethodHandle.SetBelong(null);
				}
				return r_op_Equality_RuntimeMethodHandle_RuntimeMethodHandle;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.RuntimeMethodHandle, System.RuntimeMethodHandle)
		/// </summary>
		protected static RMethod r_op_Inequality_RuntimeMethodHandle_RuntimeMethodHandle;
		public static RMethod Rop_Inequality_RuntimeMethodHandle_RuntimeMethodHandle
		{
			get
			{
				if(r_op_Inequality_RuntimeMethodHandle_RuntimeMethodHandle == null)
				{
					r_op_Inequality_RuntimeMethodHandle_RuntimeMethodHandle = new(typeof(System.RuntimeMethodHandle), "op_Inequality", 0, typeof(System.RuntimeMethodHandle), typeof(System.RuntimeMethodHandle));
					r_op_Inequality_RuntimeMethodHandle_RuntimeMethodHandle.SetBelong(null);
				}
				return r_op_Inequality_RuntimeMethodHandle_RuntimeMethodHandle;
			}
		}

		/// <summary>
		/// System.String ConstructInstantiation(System.Reflection.RuntimeMethodInfo, System.TypeNameFormatFlags)
		/// </summary>
		protected static RMethod r_ConstructInstantiation_RuntimeMethodInfo_TypeNameFormatFlags;
		public static RMethod RConstructInstantiation_RuntimeMethodInfo_TypeNameFormatFlags
		{
			get
			{
				if(r_ConstructInstantiation_RuntimeMethodInfo_TypeNameFormatFlags == null)
				{
					r_ConstructInstantiation_RuntimeMethodInfo_TypeNameFormatFlags = new(typeof(System.RuntimeMethodHandle), "ConstructInstantiation", 0,  ReleactionUtils.GetType("System.Reflection.RuntimeMethodInfo"),  ReleactionUtils.GetType("System.TypeNameFormatFlags"));
					r_ConstructInstantiation_RuntimeMethodInfo_TypeNameFormatFlags.SetBelong(null);
				}
				return r_ConstructInstantiation_RuntimeMethodInfo_TypeNameFormatFlags;
			}
		}

		/// <summary>
		/// Boolean IsNullHandle()
		/// </summary>
		protected RMethod r_IsNullHandle;
		public virtual RMethod RIsNullHandle
		{
			get
			{
				if(r_IsNullHandle == null)
				{
					r_IsNullHandle = new(this, "IsNullHandle", 0);
					r_IsNullHandle.SetBelong(this.instance);
				}
				return r_IsNullHandle;
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


        public RRuntimeMethodHandle() : base("System.RuntimeMethodHandle")
        {
        }

        public RRuntimeMethodHandle(System.Object instance) : base("System.RuntimeMethodHandle")
		{
            SetInstance(instance);
		}

        public RRuntimeMethodHandle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRuntimeMethodHandle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo  @info, System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public static System.IntPtr GetFunctionPointer(System.IntPtr  @m)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@m};
            var ___result = RGetFunctionPointer_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual System.IntPtr GetFunctionPointer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetFunctionPointer.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.RuntimeMethodHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = REquals_RuntimeMethodHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(System.RuntimeMethodHandle  @left, System.RuntimeMethodHandle  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Equality_RuntimeMethodHandle_RuntimeMethodHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.RuntimeMethodHandle  @left, System.RuntimeMethodHandle  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Inequality_RuntimeMethodHandle_RuntimeMethodHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }



        public virtual System.Boolean IsNullHandle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsNullHandle.Invoke(___genericsType, ___parameters);

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
