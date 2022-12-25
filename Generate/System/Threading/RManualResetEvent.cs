using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.ManualResetEvent
	/// </summary>
    public partial class RManualResetEvent : RMember //
    {

		/// <summary>
		/// Microsoft.Win32.SafeHandles.SafeWaitHandle safeWaitHandle
		/// </summary>
		protected RMicrosoft.RWin32.RSafeHandles.RSafeWaitHandle r_safeWaitHandle;
		public virtual RMicrosoft.RWin32.RSafeHandles.RSafeWaitHandle RsafeWaitHandle
		{
			get
			{
				if(r_safeWaitHandle == null)
				{
					r_safeWaitHandle = new(this, "safeWaitHandle");
					r_safeWaitHandle.SetBelong(this.instance);
				}
				return r_safeWaitHandle;
			}
		}

		/// <summary>
		/// System.Boolean hasThreadAffinity
		/// </summary>
		protected RField r_hasThreadAffinity;
		public virtual RField RhasThreadAffinity
		{
			get
			{
				if(r_hasThreadAffinity == null)
				{
					r_hasThreadAffinity = new(this, "hasThreadAffinity");
					r_hasThreadAffinity.SetBelong(this.instance);
				}
				return r_hasThreadAffinity;
			}
		}

		/// <summary>
		/// IntPtr Handle
		/// </summary>
		protected RProperty r_Handle;
		public virtual RProperty RHandle
		{
			get
			{
				if(r_Handle == null)
				{
					r_Handle = new(this, "Handle", -1);
					r_Handle.SetBelong(this.instance);
				}
				return r_Handle;
			}
		}

		/// <summary>
		/// Microsoft.Win32.SafeHandles.SafeWaitHandle SafeWaitHandle
		/// </summary>
		protected RMicrosoft.RWin32.RSafeHandles.RSafeWaitHandle r_SafeWaitHandle;
		public virtual RMicrosoft.RWin32.RSafeHandles.RSafeWaitHandle RSafeWaitHandle
		{
			get
			{
				if(r_SafeWaitHandle == null)
				{
					r_SafeWaitHandle = new(this, "SafeWaitHandle", -1);
					r_SafeWaitHandle.SetBelong(this.instance);
				}
				return r_SafeWaitHandle;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ServerIdentity ObjectIdentity
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RServerIdentity r_ObjectIdentity;
		public virtual RSystem.RRuntime.RRemoting.RServerIdentity RObjectIdentity
		{
			get
			{
				if(r_ObjectIdentity == null)
				{
					r_ObjectIdentity = new(this, "ObjectIdentity", -1);
					r_ObjectIdentity.SetBelong(this.instance);
				}
				return r_ObjectIdentity;
			}
		}

		/// <summary>
		/// Boolean Reset()
		/// </summary>
		protected RMethod r_RReset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_RReset == null)
				{
					r_RReset = new(this, "Reset", 0);
					r_RReset.SetBelong(this.instance);
				}
				return r_RReset;
			}
		}

		/// <summary>
		/// Boolean Set()
		/// </summary>
		protected RMethod r_RSet;
		public virtual RMethod RSet
		{
			get
			{
				if(r_RSet == null)
				{
					r_RSet = new(this, "Set", 0);
					r_RSet.SetBelong(this.instance);
				}
				return r_RSet;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.EventWaitHandleSecurity GetAccessControl()
		/// </summary>
		protected RMethod r_RGetAccessControl;
		public virtual RMethod RGetAccessControl
		{
			get
			{
				if(r_RGetAccessControl == null)
				{
					r_RGetAccessControl = new(this, "GetAccessControl", 0);
					r_RGetAccessControl.SetBelong(this.instance);
				}
				return r_RGetAccessControl;
			}
		}

		/// <summary>
		/// Void SetAccessControl(System.Security.AccessControl.EventWaitHandleSecurity)
		/// </summary>
		protected RMethod r_RSetAccessControl_EventWaitHandleSecurity;
		public virtual RMethod RSetAccessControl_EventWaitHandleSecurity
		{
			get
			{
				if(r_RSetAccessControl_EventWaitHandleSecurity == null)
				{
					r_RSetAccessControl_EventWaitHandleSecurity = new(this, "SetAccessControl", 0, typeof(System.Security.AccessControl.EventWaitHandleSecurity));
					r_RSetAccessControl_EventWaitHandleSecurity.SetBelong(this.instance);
				}
				return r_RSetAccessControl_EventWaitHandleSecurity;
			}
		}

		/// <summary>
		/// Void SetHandleInternal(Microsoft.Win32.SafeHandles.SafeWaitHandle)
		/// </summary>
		protected RMethod r_RSetHandleInternal_SafeWaitHandle;
		public virtual RMethod RSetHandleInternal_SafeWaitHandle
		{
			get
			{
				if(r_RSetHandleInternal_SafeWaitHandle == null)
				{
					r_RSetHandleInternal_SafeWaitHandle = new(this, "SetHandleInternal", 0, typeof(Microsoft.Win32.SafeHandles.SafeWaitHandle));
					r_RSetHandleInternal_SafeWaitHandle.SetBelong(this.instance);
				}
				return r_RSetHandleInternal_SafeWaitHandle;
			}
		}

		/// <summary>
		/// Boolean WaitOne(Int32, Boolean)
		/// </summary>
		protected RMethod r_RWaitOne_Int32_Boolean;
		public virtual RMethod RWaitOne_Int32_Boolean
		{
			get
			{
				if(r_RWaitOne_Int32_Boolean == null)
				{
					r_RWaitOne_Int32_Boolean = new(this, "WaitOne", 0, typeof(System.Int32), typeof(System.Boolean));
					r_RWaitOne_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RWaitOne_Int32_Boolean;
			}
		}

		/// <summary>
		/// Boolean WaitOne(System.TimeSpan, Boolean)
		/// </summary>
		protected RMethod r_RWaitOne_TimeSpan_Boolean;
		public virtual RMethod RWaitOne_TimeSpan_Boolean
		{
			get
			{
				if(r_RWaitOne_TimeSpan_Boolean == null)
				{
					r_RWaitOne_TimeSpan_Boolean = new(this, "WaitOne", 0, typeof(System.TimeSpan), typeof(System.Boolean));
					r_RWaitOne_TimeSpan_Boolean.SetBelong(this.instance);
				}
				return r_RWaitOne_TimeSpan_Boolean;
			}
		}

		/// <summary>
		/// Boolean WaitOne()
		/// </summary>
		protected RMethod r_RWaitOne;
		public virtual RMethod RWaitOne
		{
			get
			{
				if(r_RWaitOne == null)
				{
					r_RWaitOne = new(this, "WaitOne", 0);
					r_RWaitOne.SetBelong(this.instance);
				}
				return r_RWaitOne;
			}
		}

		/// <summary>
		/// Boolean WaitOne(Int32)
		/// </summary>
		protected RMethod r_RWaitOne_Int32;
		public virtual RMethod RWaitOne_Int32
		{
			get
			{
				if(r_RWaitOne_Int32 == null)
				{
					r_RWaitOne_Int32 = new(this, "WaitOne", 0, typeof(System.Int32));
					r_RWaitOne_Int32.SetBelong(this.instance);
				}
				return r_RWaitOne_Int32;
			}
		}

		/// <summary>
		/// Boolean WaitOne(System.TimeSpan)
		/// </summary>
		protected RMethod r_RWaitOne_TimeSpan;
		public virtual RMethod RWaitOne_TimeSpan
		{
			get
			{
				if(r_RWaitOne_TimeSpan == null)
				{
					r_RWaitOne_TimeSpan = new(this, "WaitOne", 0, typeof(System.TimeSpan));
					r_RWaitOne_TimeSpan.SetBelong(this.instance);
				}
				return r_RWaitOne_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean WaitOneWithoutFAS()
		/// </summary>
		protected RMethod r_RWaitOneWithoutFAS;
		public virtual RMethod RWaitOneWithoutFAS
		{
			get
			{
				if(r_RWaitOneWithoutFAS == null)
				{
					r_RWaitOneWithoutFAS = new(this, "WaitOneWithoutFAS", 0);
					r_RWaitOneWithoutFAS.SetBelong(this.instance);
				}
				return r_RWaitOneWithoutFAS;
			}
		}

		/// <summary>
		/// Void Close()
		/// </summary>
		protected RMethod r_RClose;
		public virtual RMethod RClose
		{
			get
			{
				if(r_RClose == null)
				{
					r_RClose = new(this, "Close", 0);
					r_RClose.SetBelong(this.instance);
				}
				return r_RClose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_RDispose_Boolean;
		public virtual RMethod RDispose_Boolean
		{
			get
			{
				if(r_RDispose_Boolean == null)
				{
					r_RDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_RDispose_Boolean.SetBelong(this.instance);
				}
				return r_RDispose_Boolean;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_RDispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_RDispose == null)
				{
					r_RDispose = new(this, "Dispose", 0);
					r_RDispose.SetBelong(this.instance);
				}
				return r_RDispose;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Identity GetObjectIdentity(System.MarshalByRefObject, Boolean ByRef)
		/// </summary>
		protected RMethod r_RGetObjectIdentity_MarshalByRefObject_Out_Boolean;
		public virtual RMethod RGetObjectIdentity_MarshalByRefObject_Out_Boolean
		{
			get
			{
				if(r_RGetObjectIdentity_MarshalByRefObject_Out_Boolean == null)
				{
					r_RGetObjectIdentity_MarshalByRefObject_Out_Boolean = new(this, "GetObjectIdentity", 0, typeof(System.MarshalByRefObject), typeof(System.Boolean).MakeByRefType());
					r_RGetObjectIdentity_MarshalByRefObject_Out_Boolean.SetBelong(this.instance);
				}
				return r_RGetObjectIdentity_MarshalByRefObject_Out_Boolean;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjRef CreateObjRef(System.Type)
		/// </summary>
		protected RMethod r_RCreateObjRef_Type;
		public virtual RMethod RCreateObjRef_Type
		{
			get
			{
				if(r_RCreateObjRef_Type == null)
				{
					r_RCreateObjRef_Type = new(this, "CreateObjRef", 0, typeof(System.Type));
					r_RCreateObjRef_Type.SetBelong(this.instance);
				}
				return r_RCreateObjRef_Type;
			}
		}

		/// <summary>
		/// System.Object GetLifetimeService()
		/// </summary>
		protected RMethod r_RGetLifetimeService;
		public virtual RMethod RGetLifetimeService
		{
			get
			{
				if(r_RGetLifetimeService == null)
				{
					r_RGetLifetimeService = new(this, "GetLifetimeService", 0);
					r_RGetLifetimeService.SetBelong(this.instance);
				}
				return r_RGetLifetimeService;
			}
		}

		/// <summary>
		/// System.Object InitializeLifetimeService()
		/// </summary>
		protected RMethod r_RInitializeLifetimeService;
		public virtual RMethod RInitializeLifetimeService
		{
			get
			{
				if(r_RInitializeLifetimeService == null)
				{
					r_RInitializeLifetimeService = new(this, "InitializeLifetimeService", 0);
					r_RInitializeLifetimeService.SetBelong(this.instance);
				}
				return r_RInitializeLifetimeService;
			}
		}

		/// <summary>
		/// System.MarshalByRefObject MemberwiseClone(Boolean)
		/// </summary>
		protected RMethod r_RMemberwiseClone_Boolean;
		public virtual RMethod RMemberwiseClone_Boolean
		{
			get
			{
				if(r_RMemberwiseClone_Boolean == null)
				{
					r_RMemberwiseClone_Boolean = new(this, "MemberwiseClone", 0, typeof(System.Boolean));
					r_RMemberwiseClone_Boolean.SetBelong(this.instance);
				}
				return r_RMemberwiseClone_Boolean;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
			}
		}


        public RManualResetEvent() : base("System.Threading.ManualResetEvent")
        {
        }

        public RManualResetEvent(System.Object instance) : base("System.Threading.ManualResetEvent")
		{
            SetInstance(instance);
		}

        public RManualResetEvent(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RManualResetEvent(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Set()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSet.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Security.AccessControl.EventWaitHandleSecurity GetAccessControl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAccessControl.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.EventWaitHandleSecurity)___result;
        }


        public virtual void SetAccessControl(System.Security.AccessControl.EventWaitHandleSecurity  @eventSecurity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventSecurity};
            var ___result = RSetAccessControl_EventWaitHandleSecurity.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetHandleInternal(Microsoft.Win32.SafeHandles.SafeWaitHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RSetHandleInternal_SafeWaitHandle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean WaitOne(System.Int32  @millisecondsTimeout, System.Boolean  @exitContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout, @exitContext};
            var ___result = RWaitOne_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean WaitOne(System.TimeSpan  @timeout, System.Boolean  @exitContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout, @exitContext};
            var ___result = RWaitOne_TimeSpan_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean WaitOne()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWaitOne.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean WaitOne(System.Int32  @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout};
            var ___result = RWaitOne_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean WaitOne(System.TimeSpan  @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout};
            var ___result = RWaitOne_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean WaitOneWithoutFAS()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWaitOneWithoutFAS.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean  @explicitDisposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@explicitDisposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetObjectIdentity(System.MarshalByRefObject  @obj, out System.Boolean  @IsClient)
        {
			IsClient = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @IsClient};
            var ___result = RGetObjectIdentity_MarshalByRefObject_Out_Boolean.Invoke(___genericsType, ___parameters);
			IsClient = (System.Boolean)___parameters[1];

            return (System.Object)___result;
        }


        public virtual System.Runtime.Remoting.ObjRef CreateObjRef(System.Type  @requestedType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@requestedType};
            var ___result = RCreateObjRef_Type.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjRef)___result;
        }


        public virtual System.Object GetLifetimeService()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLifetimeService.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object InitializeLifetimeService()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitializeLifetimeService.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.MarshalByRefObject MemberwiseClone(System.Boolean  @cloneIdentity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cloneIdentity};
            var ___result = RMemberwiseClone_Boolean.Invoke(___genericsType, ___parameters);

            return (System.MarshalByRefObject)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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
