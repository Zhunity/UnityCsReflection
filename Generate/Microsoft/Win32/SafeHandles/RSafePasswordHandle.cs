using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RMicrosoft.RWin32.RSafeHandles
{
	/// <summary>
	/// Microsoft.Win32.SafeHandles.SafePasswordHandle
	/// </summary>
    public partial class RSafePasswordHandle : RMember //
    {

		/// <summary>
		/// System.IntPtr handle
		/// </summary>
		protected RSystem.RIntPtr r_handle;
		public virtual RSystem.RIntPtr Rhandle
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
		/// Boolean IsInvalid
		/// </summary>
		protected RSystem.RBoolean r_IsInvalid;
		public virtual RSystem.RBoolean RIsInvalid
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
		/// Microsoft.Win32.SafeHandles.SafePasswordHandle InvalidHandle
		/// </summary>
		protected static RMicrosoft.RWin32.RSafeHandles.RSafePasswordHandle r_InvalidHandle;
		public static RMicrosoft.RWin32.RSafeHandles.RSafePasswordHandle RInvalidHandle
		{
			get
			{
				if(r_InvalidHandle == null)
				{
					r_InvalidHandle = new( ReflectionUtils.GetType("Microsoft.Win32.SafeHandles.SafePasswordHandle"), "InvalidHandle", -1);
					r_InvalidHandle.SetBelong(null);
				}
				return r_InvalidHandle;
			}
		}

		/// <summary>
		/// Boolean IsClosed
		/// </summary>
		protected RSystem.RBoolean r_IsClosed;
		public virtual RSystem.RBoolean RIsClosed
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
		/// IntPtr CreateHandle(System.String)
		/// </summary>
		protected RMethod r_CreateHandle_String;
		public virtual RMethod RCreateHandle_String
		{
			get
			{
				if(r_CreateHandle_String == null)
				{
					r_CreateHandle_String = new(this, "CreateHandle", 0, typeof(System.String));
					r_CreateHandle_String.SetBelong(this.instance);
				}
				return r_CreateHandle_String;
			}
		}

		/// <summary>
		/// IntPtr CreateHandle(System.Security.SecureString)
		/// </summary>
		protected RMethod r_CreateHandle_SecureString;
		public virtual RMethod RCreateHandle_SecureString
		{
			get
			{
				if(r_CreateHandle_SecureString == null)
				{
					r_CreateHandle_SecureString = new(this, "CreateHandle", 0, typeof(System.Security.SecureString));
					r_CreateHandle_SecureString.SetBelong(this.instance);
				}
				return r_CreateHandle_SecureString;
			}
		}

		/// <summary>
		/// Void FreeHandle()
		/// </summary>
		protected RMethod r_FreeHandle;
		public virtual RMethod RFreeHandle
		{
			get
			{
				if(r_FreeHandle == null)
				{
					r_FreeHandle = new(this, "FreeHandle", 0);
					r_FreeHandle.SetBelong(this.instance);
				}
				return r_FreeHandle;
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
		/// System.String Mono_DangerousGetString()
		/// </summary>
		protected RMethod r_Mono_DangerousGetString;
		public virtual RMethod RMono_DangerousGetString
		{
			get
			{
				if(r_Mono_DangerousGetString == null)
				{
					r_Mono_DangerousGetString = new(this, "Mono_DangerousGetString", 0);
					r_Mono_DangerousGetString.SetBelong(this.instance);
				}
				return r_Mono_DangerousGetString;
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


        public RSafePasswordHandle() : base("Microsoft.Win32.SafeHandles.SafePasswordHandle")
        {
        }

        public RSafePasswordHandle(System.Object instance) : base("Microsoft.Win32.SafeHandles.SafePasswordHandle")
		{
            SetInstance(instance);
		}

        public RSafePasswordHandle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSafePasswordHandle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.IntPtr CreateHandle(System.String @password)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@password};
            var ___result = RCreateHandle_String.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual System.IntPtr CreateHandle(System.Security.SecureString @password)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@password};
            var ___result = RCreateHandle_SecureString.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual void FreeHandle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFreeHandle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ReleaseHandle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReleaseHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Dispose(System.Boolean @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String Mono_DangerousGetString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMono_DangerousGetString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
