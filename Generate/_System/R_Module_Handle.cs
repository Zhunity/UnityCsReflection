
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.ModuleHandle
	/// </summary>
    public partial class RModuleHandle : RMember //
    {

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
					r_Fvalue.SetBelong(this.GetValue());
				}
				return r_Fvalue;
			}
		}

		/// <summary>
		/// System.ModuleHandle EmptyHandle
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RModuleHandle r_FEmptyHandle;
		public static Hvak.Editor.Refleaction.RSystem.RModuleHandle RFEmptyHandle
		{
			get
			{
				if(r_FEmptyHandle == null)
				{
					r_FEmptyHandle = new(typeof(System.ModuleHandle), "EmptyHandle");
					r_FEmptyHandle.SetBelong(null);
				}
				return r_FEmptyHandle;
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
					r_PValue.SetBelong(this.GetValue());
				}
				return r_PValue;
			}
		}

		/// <summary>
		/// Int32 MDStreamVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PMDStreamVersion;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPMDStreamVersion
		{
			get
			{
				if(r_PMDStreamVersion == null)
				{
					r_PMDStreamVersion = new(this, "MDStreamVersion", -1);
					r_PMDStreamVersion.SetBelong(this.GetValue());
				}
				return r_PMDStreamVersion;
			}
		}

		/// <summary>
		/// Void GetPEKind(System.Reflection.PortableExecutableKinds ByRef, System.Reflection.ImageFileMachine ByRef)
		/// </summary>
		protected RMethod r_MGetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine;
		public virtual RMethod RMGetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine
		{
			get
			{
				if(r_MGetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine == null)
				{
					r_MGetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine = new(this, "GetPEKind", 0, typeof(System.Reflection.PortableExecutableKinds).MakeByRefType(), typeof(System.Reflection.ImageFileMachine).MakeByRefType());
					r_MGetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine.SetBelong(this.GetValue());
				}
				return r_MGetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine;
			}
		}

		/// <summary>
		/// System.RuntimeFieldHandle ResolveFieldHandle(Int32)
		/// </summary>
		protected RMethod r_MResolveFieldHandle_Int32;
		public virtual RMethod RMResolveFieldHandle_Int32
		{
			get
			{
				if(r_MResolveFieldHandle_Int32 == null)
				{
					r_MResolveFieldHandle_Int32 = new(this, "ResolveFieldHandle", 0, typeof(System.Int32));
					r_MResolveFieldHandle_Int32.SetBelong(this.GetValue());
				}
				return r_MResolveFieldHandle_Int32;
			}
		}

		/// <summary>
		/// System.RuntimeMethodHandle ResolveMethodHandle(Int32)
		/// </summary>
		protected RMethod r_MResolveMethodHandle_Int32;
		public virtual RMethod RMResolveMethodHandle_Int32
		{
			get
			{
				if(r_MResolveMethodHandle_Int32 == null)
				{
					r_MResolveMethodHandle_Int32 = new(this, "ResolveMethodHandle", 0, typeof(System.Int32));
					r_MResolveMethodHandle_Int32.SetBelong(this.GetValue());
				}
				return r_MResolveMethodHandle_Int32;
			}
		}

		/// <summary>
		/// System.RuntimeTypeHandle ResolveTypeHandle(Int32)
		/// </summary>
		protected RMethod r_MResolveTypeHandle_Int32;
		public virtual RMethod RMResolveTypeHandle_Int32
		{
			get
			{
				if(r_MResolveTypeHandle_Int32 == null)
				{
					r_MResolveTypeHandle_Int32 = new(this, "ResolveTypeHandle", 0, typeof(System.Int32));
					r_MResolveTypeHandle_Int32.SetBelong(this.GetValue());
				}
				return r_MResolveTypeHandle_Int32;
			}
		}

		/// <summary>
		/// IntPtr[] ptrs_from_handles(System.RuntimeTypeHandle[])
		/// </summary>
		protected RMethod r_Mptrs_from_handles_RuntimeTypeHandleArray;
		public virtual RMethod RMptrs_from_handles_RuntimeTypeHandleArray
		{
			get
			{
				if(r_Mptrs_from_handles_RuntimeTypeHandleArray == null)
				{
					r_Mptrs_from_handles_RuntimeTypeHandleArray = new(this, "ptrs_from_handles", 0, typeof(System.RuntimeTypeHandle).MakeArrayType());
					r_Mptrs_from_handles_RuntimeTypeHandleArray.SetBelong(this.GetValue());
				}
				return r_Mptrs_from_handles_RuntimeTypeHandleArray;
			}
		}

		/// <summary>
		/// System.RuntimeTypeHandle ResolveTypeHandle(Int32, System.RuntimeTypeHandle[], System.RuntimeTypeHandle[])
		/// </summary>
		protected RMethod r_MResolveTypeHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray;
		public virtual RMethod RMResolveTypeHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray
		{
			get
			{
				if(r_MResolveTypeHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray == null)
				{
					r_MResolveTypeHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray = new(this, "ResolveTypeHandle", 0, typeof(System.Int32), typeof(System.RuntimeTypeHandle).MakeArrayType(), typeof(System.RuntimeTypeHandle).MakeArrayType());
					r_MResolveTypeHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray.SetBelong(this.GetValue());
				}
				return r_MResolveTypeHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray;
			}
		}

		/// <summary>
		/// System.RuntimeMethodHandle ResolveMethodHandle(Int32, System.RuntimeTypeHandle[], System.RuntimeTypeHandle[])
		/// </summary>
		protected RMethod r_MResolveMethodHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray;
		public virtual RMethod RMResolveMethodHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray
		{
			get
			{
				if(r_MResolveMethodHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray == null)
				{
					r_MResolveMethodHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray = new(this, "ResolveMethodHandle", 0, typeof(System.Int32), typeof(System.RuntimeTypeHandle).MakeArrayType(), typeof(System.RuntimeTypeHandle).MakeArrayType());
					r_MResolveMethodHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray.SetBelong(this.GetValue());
				}
				return r_MResolveMethodHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray;
			}
		}

		/// <summary>
		/// System.RuntimeFieldHandle ResolveFieldHandle(Int32, System.RuntimeTypeHandle[], System.RuntimeTypeHandle[])
		/// </summary>
		protected RMethod r_MResolveFieldHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray;
		public virtual RMethod RMResolveFieldHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray
		{
			get
			{
				if(r_MResolveFieldHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray == null)
				{
					r_MResolveFieldHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray = new(this, "ResolveFieldHandle", 0, typeof(System.Int32), typeof(System.RuntimeTypeHandle).MakeArrayType(), typeof(System.RuntimeTypeHandle).MakeArrayType());
					r_MResolveFieldHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray.SetBelong(this.GetValue());
				}
				return r_MResolveFieldHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray;
			}
		}

		/// <summary>
		/// System.RuntimeFieldHandle GetRuntimeFieldHandleFromMetadataToken(Int32)
		/// </summary>
		protected RMethod r_MGetRuntimeFieldHandleFromMetadataToken_Int32;
		public virtual RMethod RMGetRuntimeFieldHandleFromMetadataToken_Int32
		{
			get
			{
				if(r_MGetRuntimeFieldHandleFromMetadataToken_Int32 == null)
				{
					r_MGetRuntimeFieldHandleFromMetadataToken_Int32 = new(this, "GetRuntimeFieldHandleFromMetadataToken", 0, typeof(System.Int32));
					r_MGetRuntimeFieldHandleFromMetadataToken_Int32.SetBelong(this.GetValue());
				}
				return r_MGetRuntimeFieldHandleFromMetadataToken_Int32;
			}
		}

		/// <summary>
		/// System.RuntimeMethodHandle GetRuntimeMethodHandleFromMetadataToken(Int32)
		/// </summary>
		protected RMethod r_MGetRuntimeMethodHandleFromMetadataToken_Int32;
		public virtual RMethod RMGetRuntimeMethodHandleFromMetadataToken_Int32
		{
			get
			{
				if(r_MGetRuntimeMethodHandleFromMetadataToken_Int32 == null)
				{
					r_MGetRuntimeMethodHandleFromMetadataToken_Int32 = new(this, "GetRuntimeMethodHandleFromMetadataToken", 0, typeof(System.Int32));
					r_MGetRuntimeMethodHandleFromMetadataToken_Int32.SetBelong(this.GetValue());
				}
				return r_MGetRuntimeMethodHandleFromMetadataToken_Int32;
			}
		}

		/// <summary>
		/// System.RuntimeTypeHandle GetRuntimeTypeHandleFromMetadataToken(Int32)
		/// </summary>
		protected RMethod r_MGetRuntimeTypeHandleFromMetadataToken_Int32;
		public virtual RMethod RMGetRuntimeTypeHandleFromMetadataToken_Int32
		{
			get
			{
				if(r_MGetRuntimeTypeHandleFromMetadataToken_Int32 == null)
				{
					r_MGetRuntimeTypeHandleFromMetadataToken_Int32 = new(this, "GetRuntimeTypeHandleFromMetadataToken", 0, typeof(System.Int32));
					r_MGetRuntimeTypeHandleFromMetadataToken_Int32.SetBelong(this.GetValue());
				}
				return r_MGetRuntimeTypeHandleFromMetadataToken_Int32;
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
					r_MEquals_Object.SetBelong(this.GetValue());
				}
				return r_MEquals_Object;
			}
		}

		/// <summary>
		/// Boolean Equals(System.ModuleHandle)
		/// </summary>
		protected RMethod r_MEquals_ModuleHandle;
		public virtual RMethod RMEquals_ModuleHandle
		{
			get
			{
				if(r_MEquals_ModuleHandle == null)
				{
					r_MEquals_ModuleHandle = new(this, "Equals", 0, typeof(System.ModuleHandle));
					r_MEquals_ModuleHandle.SetBelong(this.GetValue());
				}
				return r_MEquals_ModuleHandle;
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
					r_MGetHashCode.SetBelong(this.GetValue());
				}
				return r_MGetHashCode;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.ModuleHandle, System.ModuleHandle)
		/// </summary>
		protected static RMethod r_Mop_Equality_ModuleHandle_ModuleHandle;
		public static RMethod RMop_Equality_ModuleHandle_ModuleHandle
		{
			get
			{
				if(r_Mop_Equality_ModuleHandle_ModuleHandle == null)
				{
					r_Mop_Equality_ModuleHandle_ModuleHandle = new(typeof(System.ModuleHandle), "op_Equality", 0, typeof(System.ModuleHandle), typeof(System.ModuleHandle));
					r_Mop_Equality_ModuleHandle_ModuleHandle.SetBelong(null);
				}
				return r_Mop_Equality_ModuleHandle_ModuleHandle;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.ModuleHandle, System.ModuleHandle)
		/// </summary>
		protected static RMethod r_Mop_Inequality_ModuleHandle_ModuleHandle;
		public static RMethod RMop_Inequality_ModuleHandle_ModuleHandle
		{
			get
			{
				if(r_Mop_Inequality_ModuleHandle_ModuleHandle == null)
				{
					r_Mop_Inequality_ModuleHandle_ModuleHandle = new(typeof(System.ModuleHandle), "op_Inequality", 0, typeof(System.ModuleHandle), typeof(System.ModuleHandle));
					r_Mop_Inequality_ModuleHandle_ModuleHandle.SetBelong(null);
				}
				return r_Mop_Inequality_ModuleHandle_ModuleHandle;
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
					r_MToString.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
				}
				return r_MMemberwiseClone;
			}
		}


        public RModuleHandle() : base("System.ModuleHandle")
        {
        }

        public RModuleHandle(System.Object instance) : base("System.ModuleHandle")
		{
            SetInstance(instance);
		}

        public RModuleHandle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RModuleHandle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void GetPEKind(out System.Reflection.PortableExecutableKinds @peKind, out System.Reflection.ImageFileMachine @machine)
        {
			@peKind = default;
			@machine = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@peKind, @machine};
            var ___result = RMGetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine.Invoke(___genericsType, ___parameters);
			@peKind = (System.Reflection.PortableExecutableKinds)___parameters[0];
			@machine = (System.Reflection.ImageFileMachine)___parameters[1];

            
        }


        public virtual System.RuntimeFieldHandle ResolveFieldHandle(System.Int32 @fieldToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fieldToken};
            var ___result = RMResolveFieldHandle_Int32.Invoke(___genericsType, ___parameters);

            return (System.RuntimeFieldHandle)___result;
        }


        public virtual System.RuntimeMethodHandle ResolveMethodHandle(System.Int32 @methodToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodToken};
            var ___result = RMResolveMethodHandle_Int32.Invoke(___genericsType, ___parameters);

            return (System.RuntimeMethodHandle)___result;
        }


        public virtual System.RuntimeTypeHandle ResolveTypeHandle(System.Int32 @typeToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeToken};
            var ___result = RMResolveTypeHandle_Int32.Invoke(___genericsType, ___parameters);

            return (System.RuntimeTypeHandle)___result;
        }


        public virtual System.IntPtr[] ptrs_from_handles(System.RuntimeTypeHandle[] @handles)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handles};
            var ___result = RMptrs_from_handles_RuntimeTypeHandleArray.Invoke(___genericsType, ___parameters);

            return (System.IntPtr[])___result;
        }


        public virtual System.RuntimeTypeHandle ResolveTypeHandle(System.Int32 @typeToken, System.RuntimeTypeHandle[] @typeInstantiationContext, System.RuntimeTypeHandle[] @methodInstantiationContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeToken, @typeInstantiationContext, @methodInstantiationContext};
            var ___result = RMResolveTypeHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray.Invoke(___genericsType, ___parameters);

            return (System.RuntimeTypeHandle)___result;
        }


        public virtual System.RuntimeMethodHandle ResolveMethodHandle(System.Int32 @methodToken, System.RuntimeTypeHandle[] @typeInstantiationContext, System.RuntimeTypeHandle[] @methodInstantiationContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodToken, @typeInstantiationContext, @methodInstantiationContext};
            var ___result = RMResolveMethodHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray.Invoke(___genericsType, ___parameters);

            return (System.RuntimeMethodHandle)___result;
        }


        public virtual System.RuntimeFieldHandle ResolveFieldHandle(System.Int32 @fieldToken, System.RuntimeTypeHandle[] @typeInstantiationContext, System.RuntimeTypeHandle[] @methodInstantiationContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fieldToken, @typeInstantiationContext, @methodInstantiationContext};
            var ___result = RMResolveFieldHandle_Int32_RuntimeTypeHandleArray_RuntimeTypeHandleArray.Invoke(___genericsType, ___parameters);

            return (System.RuntimeFieldHandle)___result;
        }


        public virtual System.RuntimeFieldHandle GetRuntimeFieldHandleFromMetadataToken(System.Int32 @fieldToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fieldToken};
            var ___result = RMGetRuntimeFieldHandleFromMetadataToken_Int32.Invoke(___genericsType, ___parameters);

            return (System.RuntimeFieldHandle)___result;
        }


        public virtual System.RuntimeMethodHandle GetRuntimeMethodHandleFromMetadataToken(System.Int32 @methodToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodToken};
            var ___result = RMGetRuntimeMethodHandleFromMetadataToken_Int32.Invoke(___genericsType, ___parameters);

            return (System.RuntimeMethodHandle)___result;
        }


        public virtual System.RuntimeTypeHandle GetRuntimeTypeHandleFromMetadataToken(System.Int32 @typeToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeToken};
            var ___result = RMGetRuntimeTypeHandleFromMetadataToken_Int32.Invoke(___genericsType, ___parameters);

            return (System.RuntimeTypeHandle)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.ModuleHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMEquals_ModuleHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(System.ModuleHandle @left, System.ModuleHandle @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Equality_ModuleHandle_ModuleHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.ModuleHandle @left, System.ModuleHandle @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Inequality_ModuleHandle_ModuleHandle.Invoke(___genericsType, ___parameters);

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
