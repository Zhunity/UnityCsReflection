
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.RuntimeMethodHandle
	/// </summary>
    public partial class RRuntimeMethodHandle : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.RuntimeMethodHandle);
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
		/// Void GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MGetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RMGetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_MGetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_MGetObjectData_SerializationInfo_StreamingContext = new(this, "GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
				}
				return r_MGetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// IntPtr GetFunctionPointer(IntPtr)
		/// </summary>
		protected static RMethod r_MGetFunctionPointer_IntPtr;
		public static RMethod RMGetFunctionPointer_IntPtr
		{
			get
			{
				if(r_MGetFunctionPointer_IntPtr == null)
				{
					r_MGetFunctionPointer_IntPtr = new(typeof(System.RuntimeMethodHandle), "GetFunctionPointer", 0, typeof(System.IntPtr));
				}
				return r_MGetFunctionPointer_IntPtr;
			}
		}

		/// <summary>
		/// IntPtr GetFunctionPointer()
		/// </summary>
		protected RMethod r_MGetFunctionPointer;
		public virtual RMethod RMGetFunctionPointer
		{
			get
			{
				if(r_MGetFunctionPointer == null)
				{
					r_MGetFunctionPointer = new(this, "GetFunctionPointer", 0);
				}
				return r_MGetFunctionPointer;
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
		/// Boolean Equals(System.RuntimeMethodHandle)
		/// </summary>
		protected RMethod r_MEquals_RuntimeMethodHandle;
		public virtual RMethod RMEquals_RuntimeMethodHandle
		{
			get
			{
				if(r_MEquals_RuntimeMethodHandle == null)
				{
					r_MEquals_RuntimeMethodHandle = new(this, "Equals", 0, typeof(System.RuntimeMethodHandle));
				}
				return r_MEquals_RuntimeMethodHandle;
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
		/// Boolean op_Equality(System.RuntimeMethodHandle, System.RuntimeMethodHandle)
		/// </summary>
		protected static RMethod r_Mop_Equality_RuntimeMethodHandle_RuntimeMethodHandle;
		public static RMethod RMop_Equality_RuntimeMethodHandle_RuntimeMethodHandle
		{
			get
			{
				if(r_Mop_Equality_RuntimeMethodHandle_RuntimeMethodHandle == null)
				{
					r_Mop_Equality_RuntimeMethodHandle_RuntimeMethodHandle = new(typeof(System.RuntimeMethodHandle), "op_Equality", 0, typeof(System.RuntimeMethodHandle), typeof(System.RuntimeMethodHandle));
				}
				return r_Mop_Equality_RuntimeMethodHandle_RuntimeMethodHandle;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.RuntimeMethodHandle, System.RuntimeMethodHandle)
		/// </summary>
		protected static RMethod r_Mop_Inequality_RuntimeMethodHandle_RuntimeMethodHandle;
		public static RMethod RMop_Inequality_RuntimeMethodHandle_RuntimeMethodHandle
		{
			get
			{
				if(r_Mop_Inequality_RuntimeMethodHandle_RuntimeMethodHandle == null)
				{
					r_Mop_Inequality_RuntimeMethodHandle_RuntimeMethodHandle = new(typeof(System.RuntimeMethodHandle), "op_Inequality", 0, typeof(System.RuntimeMethodHandle), typeof(System.RuntimeMethodHandle));
				}
				return r_Mop_Inequality_RuntimeMethodHandle_RuntimeMethodHandle;
			}
		}

		/// <summary>
		/// System.String ConstructInstantiation(System.Reflection.RuntimeMethodInfo, System.TypeNameFormatFlags)
		/// </summary>
		protected static RMethod r_MConstructInstantiation_RuntimeMethodInfo_TypeNameFormatFlags;
		public static RMethod RMConstructInstantiation_RuntimeMethodInfo_TypeNameFormatFlags
		{
			get
			{
				if(r_MConstructInstantiation_RuntimeMethodInfo_TypeNameFormatFlags == null)
				{
					r_MConstructInstantiation_RuntimeMethodInfo_TypeNameFormatFlags = new(typeof(System.RuntimeMethodHandle), "ConstructInstantiation", 0,  ReflectionUtils.GetType("System.Reflection.RuntimeMethodInfo"),  ReflectionUtils.GetType("System.TypeNameFormatFlags"));
				}
				return r_MConstructInstantiation_RuntimeMethodInfo_TypeNameFormatFlags;
			}
		}

		/// <summary>
		/// Boolean IsNullHandle()
		/// </summary>
		protected RMethod r_MIsNullHandle;
		public virtual RMethod RMIsNullHandle
		{
			get
			{
				if(r_MIsNullHandle == null)
				{
					r_MIsNullHandle = new(this, "IsNullHandle", 0);
				}
				return r_MIsNullHandle;
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


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public static System.IntPtr GetFunctionPointer(System.IntPtr @m)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@m};
            var ___result = RMGetFunctionPointer_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual System.IntPtr GetFunctionPointer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetFunctionPointer.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.RuntimeMethodHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMEquals_RuntimeMethodHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(System.RuntimeMethodHandle @left, System.RuntimeMethodHandle @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Equality_RuntimeMethodHandle_RuntimeMethodHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.RuntimeMethodHandle @left, System.RuntimeMethodHandle @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Inequality_RuntimeMethodHandle_RuntimeMethodHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.String ConstructInstantiation(Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeMethodInfo @method, Hvak.Editor.Refleaction.RSystem.RTypeNameFormatFlags @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method.Value, @format.Value};
            var ___result = RMConstructInstantiation_RuntimeMethodInfo_TypeNameFormatFlags.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean IsNullHandle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsNullHandle.Invoke(___genericsType, ___parameters);

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
