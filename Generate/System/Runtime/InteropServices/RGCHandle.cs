using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices
{
	/// <summary>
	/// System.Runtime.InteropServices.GCHandle
	/// </summary>
    public partial class RGCHandle : RMember //
    {

		/// <summary>
		/// System.IntPtr handle
		/// </summary>
		protected RField r_handle;
		public virtual RField Rhandle
		{
			get
			{
				if(r_handle == null)
				{
					r_handle = new(this, "handle");
					r_handle.SetBelong(this.instance);
				}
				return r_handle;
			}
		}

		/// <summary>
		/// Boolean IsAllocated
		/// </summary>
		protected RProperty r_IsAllocated;
		public virtual RProperty RIsAllocated
		{
			get
			{
				if(r_IsAllocated == null)
				{
					r_IsAllocated = new(this, "IsAllocated", -1);
					r_IsAllocated.SetBelong(this.instance);
				}
				return r_IsAllocated;
			}
		}

		/// <summary>
		/// System.Object Target
		/// </summary>
		protected RSystem.RObject r_Target;
		public virtual RSystem.RObject RTarget
		{
			get
			{
				if(r_Target == null)
				{
					r_Target = new(this, "Target", -1);
					r_Target.SetBelong(this.instance);
				}
				return r_Target;
			}
		}

		/// <summary>
		/// IntPtr AddrOfPinnedObject()
		/// </summary>
		protected RMethod r_AddrOfPinnedObject;
		public virtual RMethod RAddrOfPinnedObject
		{
			get
			{
				if(r_AddrOfPinnedObject == null)
				{
					r_AddrOfPinnedObject = new(this, "AddrOfPinnedObject", 0);
					r_AddrOfPinnedObject.SetBelong(this.instance);
				}
				return r_AddrOfPinnedObject;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.GCHandle Alloc(System.Object)
		/// </summary>
		protected static RMethod r_Alloc_Object;
		public static RMethod RAlloc_Object
		{
			get
			{
				if(r_Alloc_Object == null)
				{
					r_Alloc_Object = new(typeof(System.Runtime.InteropServices.GCHandle), "Alloc", 0, typeof(System.Object));
					r_Alloc_Object.SetBelong(null);
				}
				return r_Alloc_Object;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.GCHandle Alloc(System.Object, System.Runtime.InteropServices.GCHandleType)
		/// </summary>
		protected static RMethod r_Alloc_Object_GCHandleType;
		public static RMethod RAlloc_Object_GCHandleType
		{
			get
			{
				if(r_Alloc_Object_GCHandleType == null)
				{
					r_Alloc_Object_GCHandleType = new(typeof(System.Runtime.InteropServices.GCHandle), "Alloc", 0, typeof(System.Object), typeof(System.Runtime.InteropServices.GCHandleType));
					r_Alloc_Object_GCHandleType.SetBelong(null);
				}
				return r_Alloc_Object_GCHandleType;
			}
		}

		/// <summary>
		/// Void Free()
		/// </summary>
		protected RMethod r_Free;
		public virtual RMethod RFree
		{
			get
			{
				if(r_Free == null)
				{
					r_Free = new(this, "Free", 0);
					r_Free.SetBelong(this.instance);
				}
				return r_Free;
			}
		}

		/// <summary>
		/// IntPtr op_Explicit(System.Runtime.InteropServices.GCHandle)
		/// </summary>
		protected static RMethod r_op_Explicit_GCHandle;
		public static RMethod Rop_Explicit_GCHandle
		{
			get
			{
				if(r_op_Explicit_GCHandle == null)
				{
					r_op_Explicit_GCHandle = new(typeof(System.Runtime.InteropServices.GCHandle), "op_Explicit", 0, typeof(System.Runtime.InteropServices.GCHandle));
					r_op_Explicit_GCHandle.SetBelong(null);
				}
				return r_op_Explicit_GCHandle;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.GCHandle op_Explicit(IntPtr)
		/// </summary>
		protected static RMethod r_op_Explicit_IntPtr;
		public static RMethod Rop_Explicit_IntPtr
		{
			get
			{
				if(r_op_Explicit_IntPtr == null)
				{
					r_op_Explicit_IntPtr = new(typeof(System.Runtime.InteropServices.GCHandle), "op_Explicit", 0, typeof(System.IntPtr));
					r_op_Explicit_IntPtr.SetBelong(null);
				}
				return r_op_Explicit_IntPtr;
			}
		}

		/// <summary>
		/// Boolean CheckCurrentDomain(IntPtr)
		/// </summary>
		protected static RMethod r_CheckCurrentDomain_IntPtr;
		public static RMethod RCheckCurrentDomain_IntPtr
		{
			get
			{
				if(r_CheckCurrentDomain_IntPtr == null)
				{
					r_CheckCurrentDomain_IntPtr = new(typeof(System.Runtime.InteropServices.GCHandle), "CheckCurrentDomain", 0, typeof(System.IntPtr));
					r_CheckCurrentDomain_IntPtr.SetBelong(null);
				}
				return r_CheckCurrentDomain_IntPtr;
			}
		}

		/// <summary>
		/// System.Object GetTarget(IntPtr)
		/// </summary>
		protected static RMethod r_GetTarget_IntPtr;
		public static RMethod RGetTarget_IntPtr
		{
			get
			{
				if(r_GetTarget_IntPtr == null)
				{
					r_GetTarget_IntPtr = new(typeof(System.Runtime.InteropServices.GCHandle), "GetTarget", 0, typeof(System.IntPtr));
					r_GetTarget_IntPtr.SetBelong(null);
				}
				return r_GetTarget_IntPtr;
			}
		}

		/// <summary>
		/// IntPtr GetTargetHandle(System.Object, IntPtr, System.Runtime.InteropServices.GCHandleType)
		/// </summary>
		protected static RMethod r_GetTargetHandle_Object_IntPtr_GCHandleType;
		public static RMethod RGetTargetHandle_Object_IntPtr_GCHandleType
		{
			get
			{
				if(r_GetTargetHandle_Object_IntPtr_GCHandleType == null)
				{
					r_GetTargetHandle_Object_IntPtr_GCHandleType = new(typeof(System.Runtime.InteropServices.GCHandle), "GetTargetHandle", 0, typeof(System.Object), typeof(System.IntPtr), typeof(System.Runtime.InteropServices.GCHandleType));
					r_GetTargetHandle_Object_IntPtr_GCHandleType.SetBelong(null);
				}
				return r_GetTargetHandle_Object_IntPtr_GCHandleType;
			}
		}

		/// <summary>
		/// Void FreeHandle(IntPtr)
		/// </summary>
		protected static RMethod r_FreeHandle_IntPtr;
		public static RMethod RFreeHandle_IntPtr
		{
			get
			{
				if(r_FreeHandle_IntPtr == null)
				{
					r_FreeHandle_IntPtr = new(typeof(System.Runtime.InteropServices.GCHandle), "FreeHandle", 0, typeof(System.IntPtr));
					r_FreeHandle_IntPtr.SetBelong(null);
				}
				return r_FreeHandle_IntPtr;
			}
		}

		/// <summary>
		/// IntPtr GetAddrOfPinnedObject(IntPtr)
		/// </summary>
		protected static RMethod r_GetAddrOfPinnedObject_IntPtr;
		public static RMethod RGetAddrOfPinnedObject_IntPtr
		{
			get
			{
				if(r_GetAddrOfPinnedObject_IntPtr == null)
				{
					r_GetAddrOfPinnedObject_IntPtr = new(typeof(System.Runtime.InteropServices.GCHandle), "GetAddrOfPinnedObject", 0, typeof(System.IntPtr));
					r_GetAddrOfPinnedObject_IntPtr.SetBelong(null);
				}
				return r_GetAddrOfPinnedObject_IntPtr;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Runtime.InteropServices.GCHandle, System.Runtime.InteropServices.GCHandle)
		/// </summary>
		protected static RMethod r_op_Equality_GCHandle_GCHandle;
		public static RMethod Rop_Equality_GCHandle_GCHandle
		{
			get
			{
				if(r_op_Equality_GCHandle_GCHandle == null)
				{
					r_op_Equality_GCHandle_GCHandle = new(typeof(System.Runtime.InteropServices.GCHandle), "op_Equality", 0, typeof(System.Runtime.InteropServices.GCHandle), typeof(System.Runtime.InteropServices.GCHandle));
					r_op_Equality_GCHandle_GCHandle.SetBelong(null);
				}
				return r_op_Equality_GCHandle_GCHandle;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Runtime.InteropServices.GCHandle, System.Runtime.InteropServices.GCHandle)
		/// </summary>
		protected static RMethod r_op_Inequality_GCHandle_GCHandle;
		public static RMethod Rop_Inequality_GCHandle_GCHandle
		{
			get
			{
				if(r_op_Inequality_GCHandle_GCHandle == null)
				{
					r_op_Inequality_GCHandle_GCHandle = new(typeof(System.Runtime.InteropServices.GCHandle), "op_Inequality", 0, typeof(System.Runtime.InteropServices.GCHandle), typeof(System.Runtime.InteropServices.GCHandle));
					r_op_Inequality_GCHandle_GCHandle.SetBelong(null);
				}
				return r_op_Inequality_GCHandle_GCHandle;
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
		/// System.Runtime.InteropServices.GCHandle FromIntPtr(IntPtr)
		/// </summary>
		protected static RMethod r_FromIntPtr_IntPtr;
		public static RMethod RFromIntPtr_IntPtr
		{
			get
			{
				if(r_FromIntPtr_IntPtr == null)
				{
					r_FromIntPtr_IntPtr = new(typeof(System.Runtime.InteropServices.GCHandle), "FromIntPtr", 0, typeof(System.IntPtr));
					r_FromIntPtr_IntPtr.SetBelong(null);
				}
				return r_FromIntPtr_IntPtr;
			}
		}

		/// <summary>
		/// IntPtr ToIntPtr(System.Runtime.InteropServices.GCHandle)
		/// </summary>
		protected static RMethod r_ToIntPtr_GCHandle;
		public static RMethod RToIntPtr_GCHandle
		{
			get
			{
				if(r_ToIntPtr_GCHandle == null)
				{
					r_ToIntPtr_GCHandle = new(typeof(System.Runtime.InteropServices.GCHandle), "ToIntPtr", 0, typeof(System.Runtime.InteropServices.GCHandle));
					r_ToIntPtr_GCHandle.SetBelong(null);
				}
				return r_ToIntPtr_GCHandle;
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


        public RGCHandle() : base("System.Runtime.InteropServices.GCHandle")
        {
        }

        public RGCHandle(System.Object instance) : base("System.Runtime.InteropServices.GCHandle")
		{
            SetInstance(instance);
		}

        public RGCHandle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGCHandle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.IntPtr AddrOfPinnedObject()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAddrOfPinnedObject.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static System.Runtime.InteropServices.GCHandle Alloc(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAlloc_Object.Invoke(___genericsType, ___parameters);

            return (System.Runtime.InteropServices.GCHandle)___result;
        }


        public static System.Runtime.InteropServices.GCHandle Alloc(System.Object @value, System.Runtime.InteropServices.GCHandleType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @type};
            var ___result = RAlloc_Object_GCHandleType.Invoke(___genericsType, ___parameters);

            return (System.Runtime.InteropServices.GCHandle)___result;
        }


        public virtual void Free()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFree.Invoke(___genericsType, ___parameters);

            
        }


        public static System.IntPtr op_Explicit(System.Runtime.InteropServices.GCHandle @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rop_Explicit_GCHandle.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static System.Runtime.InteropServices.GCHandle op_Explicit(System.IntPtr @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rop_Explicit_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Runtime.InteropServices.GCHandle)___result;
        }


        public static System.Boolean CheckCurrentDomain(System.IntPtr @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RCheckCurrentDomain_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Object GetTarget(System.IntPtr @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetTarget_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.IntPtr GetTargetHandle(System.Object @obj, System.IntPtr @handle, System.Runtime.InteropServices.GCHandleType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @handle, @type};
            var ___result = RGetTargetHandle_Object_IntPtr_GCHandleType.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static void FreeHandle(System.IntPtr @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RFreeHandle_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public static System.IntPtr GetAddrOfPinnedObject(System.IntPtr @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetAddrOfPinnedObject_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static System.Boolean op_Equality(System.Runtime.InteropServices.GCHandle @a, System.Runtime.InteropServices.GCHandle @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Equality_GCHandle_GCHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Runtime.InteropServices.GCHandle @a, System.Runtime.InteropServices.GCHandle @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Inequality_GCHandle_GCHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
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


        public static System.Runtime.InteropServices.GCHandle FromIntPtr(System.IntPtr @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RFromIntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Runtime.InteropServices.GCHandle)___result;
        }


        public static System.IntPtr ToIntPtr(System.Runtime.InteropServices.GCHandle @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToIntPtr_GCHandle.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
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
