using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices
{
	/// <summary>
	/// System.Runtime.InteropServices.SafeHandle
	/// </summary>
    public partial class RSafeHandle : RMember //
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
		/// System.Int32 _state
		/// </summary>
		protected RField r__state;
		public virtual RField R_state
		{
			get
			{
				if(r__state == null)
				{
					r__state = new(this, "_state");
					r__state.SetBelong(this.instance);
				}
				return r__state;
			}
		}

		/// <summary>
		/// System.Boolean _ownsHandle
		/// </summary>
		protected RField r__ownsHandle;
		public virtual RField R_ownsHandle
		{
			get
			{
				if(r__ownsHandle == null)
				{
					r__ownsHandle = new(this, "_ownsHandle");
					r__ownsHandle.SetBelong(this.instance);
				}
				return r__ownsHandle;
			}
		}

		/// <summary>
		/// System.Boolean _fullyInitialized
		/// </summary>
		protected RField r__fullyInitialized;
		public virtual RField R_fullyInitialized
		{
			get
			{
				if(r__fullyInitialized == null)
				{
					r__fullyInitialized = new(this, "_fullyInitialized");
					r__fullyInitialized.SetBelong(this.instance);
				}
				return r__fullyInitialized;
			}
		}

		/// <summary>
		/// System.Int32 RefCount_Mask
		/// </summary>
		protected static RField r_RefCount_Mask;
		public static RField RRefCount_Mask
		{
			get
			{
				if(r_RefCount_Mask == null)
				{
					r_RefCount_Mask = new(typeof(System.Runtime.InteropServices.SafeHandle), "RefCount_Mask");
					r_RefCount_Mask.SetBelong(null);
				}
				return r_RefCount_Mask;
			}
		}

		/// <summary>
		/// System.Int32 RefCount_One
		/// </summary>
		protected static RField r_RefCount_One;
		public static RField RRefCount_One
		{
			get
			{
				if(r_RefCount_One == null)
				{
					r_RefCount_One = new(typeof(System.Runtime.InteropServices.SafeHandle), "RefCount_One");
					r_RefCount_One.SetBelong(null);
				}
				return r_RefCount_One;
			}
		}

		/// <summary>
		/// Boolean IsClosed
		/// </summary>
		protected RProperty r_IsClosed;
		public virtual RProperty RIsClosed
		{
			get
			{
				if(r_IsClosed == null)
				{
					r_IsClosed = new(this, "IsClosed", -1);
					r_IsClosed.SetBelong(this.instance);
				}
				return r_IsClosed;
			}
		}

		/// <summary>
		/// Boolean IsInvalid
		/// </summary>
		protected RProperty r_IsInvalid;
		public virtual RProperty RIsInvalid
		{
			get
			{
				if(r_IsInvalid == null)
				{
					r_IsInvalid = new(this, "IsInvalid", -1);
					r_IsInvalid.SetBelong(this.instance);
				}
				return r_IsInvalid;
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
		/// Void SetHandle(IntPtr)
		/// </summary>
		protected RMethod r_SetHandle_IntPtr;
		public virtual RMethod RSetHandle_IntPtr
		{
			get
			{
				if(r_SetHandle_IntPtr == null)
				{
					r_SetHandle_IntPtr = new(this, "SetHandle", 0, typeof(System.IntPtr));
					r_SetHandle_IntPtr.SetBelong(this.instance);
				}
				return r_SetHandle_IntPtr;
			}
		}

		/// <summary>
		/// IntPtr DangerousGetHandle()
		/// </summary>
		protected RMethod r_DangerousGetHandle;
		public virtual RMethod RDangerousGetHandle
		{
			get
			{
				if(r_DangerousGetHandle == null)
				{
					r_DangerousGetHandle = new(this, "DangerousGetHandle", 0);
					r_DangerousGetHandle.SetBelong(this.instance);
				}
				return r_DangerousGetHandle;
			}
		}

		/// <summary>
		/// Void Close()
		/// </summary>
		protected RMethod r_Close;
		public virtual RMethod RClose
		{
			get
			{
				if(r_Close == null)
				{
					r_Close = new(this, "Close", 0);
					r_Close.SetBelong(this.instance);
				}
				return r_Close;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_Dispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_Dispose == null)
				{
					r_Dispose = new(this, "Dispose", 0);
					r_Dispose.SetBelong(this.instance);
				}
				return r_Dispose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_Dispose_Boolean;
		public virtual RMethod RDispose_Boolean
		{
			get
			{
				if(r_Dispose_Boolean == null)
				{
					r_Dispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_Dispose_Boolean.SetBelong(this.instance);
				}
				return r_Dispose_Boolean;
			}
		}

		/// <summary>
		/// Boolean ReleaseHandle()
		/// </summary>
		protected RMethod r_ReleaseHandle;
		public virtual RMethod RReleaseHandle
		{
			get
			{
				if(r_ReleaseHandle == null)
				{
					r_ReleaseHandle = new(this, "ReleaseHandle", 0);
					r_ReleaseHandle.SetBelong(this.instance);
				}
				return r_ReleaseHandle;
			}
		}

		/// <summary>
		/// Void SetHandleAsInvalid()
		/// </summary>
		protected RMethod r_SetHandleAsInvalid;
		public virtual RMethod RSetHandleAsInvalid
		{
			get
			{
				if(r_SetHandleAsInvalid == null)
				{
					r_SetHandleAsInvalid = new(this, "SetHandleAsInvalid", 0);
					r_SetHandleAsInvalid.SetBelong(this.instance);
				}
				return r_SetHandleAsInvalid;
			}
		}

		/// <summary>
		/// Void DangerousAddRef(Boolean ByRef)
		/// </summary>
		protected RMethod r_DangerousAddRef_Ref_Boolean;
		public virtual RMethod RDangerousAddRef_Ref_Boolean
		{
			get
			{
				if(r_DangerousAddRef_Ref_Boolean == null)
				{
					r_DangerousAddRef_Ref_Boolean = new(this, "DangerousAddRef", 0, typeof(System.Boolean).MakeByRefType());
					r_DangerousAddRef_Ref_Boolean.SetBelong(this.instance);
				}
				return r_DangerousAddRef_Ref_Boolean;
			}
		}

		/// <summary>
		/// Void DangerousRelease()
		/// </summary>
		protected RMethod r_DangerousRelease;
		public virtual RMethod RDangerousRelease
		{
			get
			{
				if(r_DangerousRelease == null)
				{
					r_DangerousRelease = new(this, "DangerousRelease", 0);
					r_DangerousRelease.SetBelong(this.instance);
				}
				return r_DangerousRelease;
			}
		}

		/// <summary>
		/// Void InternalDispose()
		/// </summary>
		protected RMethod r_InternalDispose;
		public virtual RMethod RInternalDispose
		{
			get
			{
				if(r_InternalDispose == null)
				{
					r_InternalDispose = new(this, "InternalDispose", 0);
					r_InternalDispose.SetBelong(this.instance);
				}
				return r_InternalDispose;
			}
		}

		/// <summary>
		/// Void InternalFinalize()
		/// </summary>
		protected RMethod r_InternalFinalize;
		public virtual RMethod RInternalFinalize
		{
			get
			{
				if(r_InternalFinalize == null)
				{
					r_InternalFinalize = new(this, "InternalFinalize", 0);
					r_InternalFinalize.SetBelong(this.instance);
				}
				return r_InternalFinalize;
			}
		}

		/// <summary>
		/// Void DangerousReleaseInternal(Boolean)
		/// </summary>
		protected RMethod r_DangerousReleaseInternal_Boolean;
		public virtual RMethod RDangerousReleaseInternal_Boolean
		{
			get
			{
				if(r_DangerousReleaseInternal_Boolean == null)
				{
					r_DangerousReleaseInternal_Boolean = new(this, "DangerousReleaseInternal", 0, typeof(System.Boolean));
					r_DangerousReleaseInternal_Boolean.SetBelong(this.instance);
				}
				return r_DangerousReleaseInternal_Boolean;
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


        public RSafeHandle() : base("System.Runtime.InteropServices.SafeHandle")
        {
        }

        public RSafeHandle(System.Object instance) : base("System.Runtime.InteropServices.SafeHandle")
		{
            SetInstance(instance);
		}

        public RSafeHandle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSafeHandle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetHandle(System.IntPtr @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RSetHandle_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IntPtr DangerousGetHandle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDangerousGetHandle.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual void Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ReleaseHandle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReleaseHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetHandleAsInvalid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetHandleAsInvalid.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DangerousAddRef(ref System.Boolean @success)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@success};
            var ___result = RDangerousAddRef_Ref_Boolean.Invoke(___genericsType, ___parameters);
			@success = (System.Boolean)___parameters[0];

            
        }


        public virtual void DangerousRelease()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDangerousRelease.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalDispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalFinalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DangerousReleaseInternal(System.Boolean @dispose)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispose};
            var ___result = RDangerousReleaseInternal_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
