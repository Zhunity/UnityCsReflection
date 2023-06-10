
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices
{
	/// <summary>
	/// System.Runtime.InteropServices.GCHandle
	/// </summary>
    public partial class RGCHandle : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Runtime.InteropServices.GCHandle);
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


		/// <summary>
		/// System.IntPtr handle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fhandle;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFhandle
		{
			get
			{
				if(r_Fhandle == null)
				{
					r_Fhandle = new(this, "handle");
				}
				return r_Fhandle;
			}
		}

		/// <summary>
		/// Boolean IsAllocated
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsAllocated;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsAllocated
		{
			get
			{
				if(r_PIsAllocated == null)
				{
					r_PIsAllocated = new(this, "IsAllocated", -1);
				}
				return r_PIsAllocated;
			}
		}

		/// <summary>
		/// System.Object Target
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PTarget;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPTarget
		{
			get
			{
				if(r_PTarget == null)
				{
					r_PTarget = new(this, "Target", -1);
				}
				return r_PTarget;
			}
		}

		/// <summary>
		/// IntPtr AddrOfPinnedObject()
		/// </summary>
		protected RMethod r_MAddrOfPinnedObject;
		public virtual RMethod RMAddrOfPinnedObject
		{
			get
			{
				if(r_MAddrOfPinnedObject == null)
				{
					r_MAddrOfPinnedObject = new(this, "AddrOfPinnedObject", 0);
				}
				return r_MAddrOfPinnedObject;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.GCHandle Alloc(System.Object)
		/// </summary>
		protected static RMethod r_MAlloc_Object;
		public static RMethod RMAlloc_Object
		{
			get
			{
				if(r_MAlloc_Object == null)
				{
					r_MAlloc_Object = new(typeof(System.Runtime.InteropServices.GCHandle), "Alloc", 0, typeof(System.Object));
				}
				return r_MAlloc_Object;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.GCHandle Alloc(System.Object, System.Runtime.InteropServices.GCHandleType)
		/// </summary>
		protected static RMethod r_MAlloc_Object_GCHandleType;
		public static RMethod RMAlloc_Object_GCHandleType
		{
			get
			{
				if(r_MAlloc_Object_GCHandleType == null)
				{
					r_MAlloc_Object_GCHandleType = new(typeof(System.Runtime.InteropServices.GCHandle), "Alloc", 0, typeof(System.Object), typeof(System.Runtime.InteropServices.GCHandleType));
				}
				return r_MAlloc_Object_GCHandleType;
			}
		}

		/// <summary>
		/// Void Free()
		/// </summary>
		protected RMethod r_MFree;
		public virtual RMethod RMFree
		{
			get
			{
				if(r_MFree == null)
				{
					r_MFree = new(this, "Free", 0);
				}
				return r_MFree;
			}
		}

		/// <summary>
		/// IntPtr op_Explicit(System.Runtime.InteropServices.GCHandle)
		/// </summary>
		protected static RMethod r_Mop_Explicit_GCHandle;
		public static RMethod RMop_Explicit_GCHandle
		{
			get
			{
				if(r_Mop_Explicit_GCHandle == null)
				{
					r_Mop_Explicit_GCHandle = new(typeof(System.Runtime.InteropServices.GCHandle), "op_Explicit", 0, typeof(System.Runtime.InteropServices.GCHandle));
				}
				return r_Mop_Explicit_GCHandle;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.GCHandle op_Explicit(IntPtr)
		/// </summary>
		protected static RMethod r_Mop_Explicit_IntPtr;
		public static RMethod RMop_Explicit_IntPtr
		{
			get
			{
				if(r_Mop_Explicit_IntPtr == null)
				{
					r_Mop_Explicit_IntPtr = new(typeof(System.Runtime.InteropServices.GCHandle), "op_Explicit", 0, typeof(System.IntPtr));
				}
				return r_Mop_Explicit_IntPtr;
			}
		}

		/// <summary>
		/// Boolean CheckCurrentDomain(IntPtr)
		/// </summary>
		protected static RMethod r_MCheckCurrentDomain_IntPtr;
		public static RMethod RMCheckCurrentDomain_IntPtr
		{
			get
			{
				if(r_MCheckCurrentDomain_IntPtr == null)
				{
					r_MCheckCurrentDomain_IntPtr = new(typeof(System.Runtime.InteropServices.GCHandle), "CheckCurrentDomain", 0, typeof(System.IntPtr));
				}
				return r_MCheckCurrentDomain_IntPtr;
			}
		}

		/// <summary>
		/// System.Object GetTarget(IntPtr)
		/// </summary>
		protected static RMethod r_MGetTarget_IntPtr;
		public static RMethod RMGetTarget_IntPtr
		{
			get
			{
				if(r_MGetTarget_IntPtr == null)
				{
					r_MGetTarget_IntPtr = new(typeof(System.Runtime.InteropServices.GCHandle), "GetTarget", 0, typeof(System.IntPtr));
				}
				return r_MGetTarget_IntPtr;
			}
		}

		/// <summary>
		/// IntPtr GetTargetHandle(System.Object, IntPtr, System.Runtime.InteropServices.GCHandleType)
		/// </summary>
		protected static RMethod r_MGetTargetHandle_Object_IntPtr_GCHandleType;
		public static RMethod RMGetTargetHandle_Object_IntPtr_GCHandleType
		{
			get
			{
				if(r_MGetTargetHandle_Object_IntPtr_GCHandleType == null)
				{
					r_MGetTargetHandle_Object_IntPtr_GCHandleType = new(typeof(System.Runtime.InteropServices.GCHandle), "GetTargetHandle", 0, typeof(System.Object), typeof(System.IntPtr), typeof(System.Runtime.InteropServices.GCHandleType));
				}
				return r_MGetTargetHandle_Object_IntPtr_GCHandleType;
			}
		}

		/// <summary>
		/// Void FreeHandle(IntPtr)
		/// </summary>
		protected static RMethod r_MFreeHandle_IntPtr;
		public static RMethod RMFreeHandle_IntPtr
		{
			get
			{
				if(r_MFreeHandle_IntPtr == null)
				{
					r_MFreeHandle_IntPtr = new(typeof(System.Runtime.InteropServices.GCHandle), "FreeHandle", 0, typeof(System.IntPtr));
				}
				return r_MFreeHandle_IntPtr;
			}
		}

		/// <summary>
		/// IntPtr GetAddrOfPinnedObject(IntPtr)
		/// </summary>
		protected static RMethod r_MGetAddrOfPinnedObject_IntPtr;
		public static RMethod RMGetAddrOfPinnedObject_IntPtr
		{
			get
			{
				if(r_MGetAddrOfPinnedObject_IntPtr == null)
				{
					r_MGetAddrOfPinnedObject_IntPtr = new(typeof(System.Runtime.InteropServices.GCHandle), "GetAddrOfPinnedObject", 0, typeof(System.IntPtr));
				}
				return r_MGetAddrOfPinnedObject_IntPtr;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Runtime.InteropServices.GCHandle, System.Runtime.InteropServices.GCHandle)
		/// </summary>
		protected static RMethod r_Mop_Equality_GCHandle_GCHandle;
		public static RMethod RMop_Equality_GCHandle_GCHandle
		{
			get
			{
				if(r_Mop_Equality_GCHandle_GCHandle == null)
				{
					r_Mop_Equality_GCHandle_GCHandle = new(typeof(System.Runtime.InteropServices.GCHandle), "op_Equality", 0, typeof(System.Runtime.InteropServices.GCHandle), typeof(System.Runtime.InteropServices.GCHandle));
				}
				return r_Mop_Equality_GCHandle_GCHandle;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Runtime.InteropServices.GCHandle, System.Runtime.InteropServices.GCHandle)
		/// </summary>
		protected static RMethod r_Mop_Inequality_GCHandle_GCHandle;
		public static RMethod RMop_Inequality_GCHandle_GCHandle
		{
			get
			{
				if(r_Mop_Inequality_GCHandle_GCHandle == null)
				{
					r_Mop_Inequality_GCHandle_GCHandle = new(typeof(System.Runtime.InteropServices.GCHandle), "op_Inequality", 0, typeof(System.Runtime.InteropServices.GCHandle), typeof(System.Runtime.InteropServices.GCHandle));
				}
				return r_Mop_Inequality_GCHandle_GCHandle;
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
		/// System.Runtime.InteropServices.GCHandle FromIntPtr(IntPtr)
		/// </summary>
		protected static RMethod r_MFromIntPtr_IntPtr;
		public static RMethod RMFromIntPtr_IntPtr
		{
			get
			{
				if(r_MFromIntPtr_IntPtr == null)
				{
					r_MFromIntPtr_IntPtr = new(typeof(System.Runtime.InteropServices.GCHandle), "FromIntPtr", 0, typeof(System.IntPtr));
				}
				return r_MFromIntPtr_IntPtr;
			}
		}

		/// <summary>
		/// IntPtr ToIntPtr(System.Runtime.InteropServices.GCHandle)
		/// </summary>
		protected static RMethod r_MToIntPtr_GCHandle;
		public static RMethod RMToIntPtr_GCHandle
		{
			get
			{
				if(r_MToIntPtr_GCHandle == null)
				{
					r_MToIntPtr_GCHandle = new(typeof(System.Runtime.InteropServices.GCHandle), "ToIntPtr", 0, typeof(System.Runtime.InteropServices.GCHandle));
				}
				return r_MToIntPtr_GCHandle;
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


        public virtual System.IntPtr AddrOfPinnedObject()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAddrOfPinnedObject.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static System.Runtime.InteropServices.GCHandle Alloc(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMAlloc_Object.Invoke(___genericsType, ___parameters);

            return (System.Runtime.InteropServices.GCHandle)___result;
        }


        public static System.Runtime.InteropServices.GCHandle Alloc(System.Object @value, System.Runtime.InteropServices.GCHandleType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @type};
            var ___result = RMAlloc_Object_GCHandleType.Invoke(___genericsType, ___parameters);

            return (System.Runtime.InteropServices.GCHandle)___result;
        }


        public virtual void Free()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFree.Invoke(___genericsType, ___parameters);

            
        }


        public static System.IntPtr op_Explicit(System.Runtime.InteropServices.GCHandle @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMop_Explicit_GCHandle.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static System.Runtime.InteropServices.GCHandle op_Explicit(System.IntPtr @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMop_Explicit_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Runtime.InteropServices.GCHandle)___result;
        }


        public static System.Boolean CheckCurrentDomain(System.IntPtr @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMCheckCurrentDomain_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Object GetTarget(System.IntPtr @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetTarget_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.IntPtr GetTargetHandle(System.Object @obj, System.IntPtr @handle, System.Runtime.InteropServices.GCHandleType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @handle, @type};
            var ___result = RMGetTargetHandle_Object_IntPtr_GCHandleType.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static void FreeHandle(System.IntPtr @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMFreeHandle_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public static System.IntPtr GetAddrOfPinnedObject(System.IntPtr @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetAddrOfPinnedObject_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static System.Boolean op_Equality(System.Runtime.InteropServices.GCHandle @a, System.Runtime.InteropServices.GCHandle @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Equality_GCHandle_GCHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Runtime.InteropServices.GCHandle @a, System.Runtime.InteropServices.GCHandle @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Inequality_GCHandle_GCHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Runtime.InteropServices.GCHandle FromIntPtr(System.IntPtr @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMFromIntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Runtime.InteropServices.GCHandle)___result;
        }


        public static System.IntPtr ToIntPtr(System.Runtime.InteropServices.GCHandle @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMToIntPtr_GCHandle.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
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
