
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.Threading.ManualResetEvent
	/// </summary>
    public partial class RManualResetEvent : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Threading.ManualResetEvent);
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


		/// <summary>
		/// Microsoft.Win32.SafeHandles.SafeWaitHandle safeWaitHandle
		/// </summary>
		protected Hvak.Editor.Refleaction.RMicrosoft.RWin32.RSafeHandles.RSafeWaitHandle r_FsafeWaitHandle;
		public virtual Hvak.Editor.Refleaction.RMicrosoft.RWin32.RSafeHandles.RSafeWaitHandle RFsafeWaitHandle
		{
			get
			{
				if(r_FsafeWaitHandle == null)
				{
					r_FsafeWaitHandle = new(this, "safeWaitHandle");
				}
				return r_FsafeWaitHandle;
			}
		}

		/// <summary>
		/// System.Boolean hasThreadAffinity
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FhasThreadAffinity;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFhasThreadAffinity
		{
			get
			{
				if(r_FhasThreadAffinity == null)
				{
					r_FhasThreadAffinity = new(this, "hasThreadAffinity");
				}
				return r_FhasThreadAffinity;
			}
		}

		/// <summary>
		/// IntPtr Handle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_PHandle;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RPHandle
		{
			get
			{
				if(r_PHandle == null)
				{
					r_PHandle = new(this, "Handle", -1);
				}
				return r_PHandle;
			}
		}

		/// <summary>
		/// Microsoft.Win32.SafeHandles.SafeWaitHandle SafeWaitHandle
		/// </summary>
		protected Hvak.Editor.Refleaction.RMicrosoft.RWin32.RSafeHandles.RSafeWaitHandle r_PSafeWaitHandle;
		public virtual Hvak.Editor.Refleaction.RMicrosoft.RWin32.RSafeHandles.RSafeWaitHandle RPSafeWaitHandle
		{
			get
			{
				if(r_PSafeWaitHandle == null)
				{
					r_PSafeWaitHandle = new(this, "SafeWaitHandle", -1);
				}
				return r_PSafeWaitHandle;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ServerIdentity ObjectIdentity
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RServerIdentity r_PObjectIdentity;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RServerIdentity RPObjectIdentity
		{
			get
			{
				if(r_PObjectIdentity == null)
				{
					r_PObjectIdentity = new(this, "ObjectIdentity", -1);
				}
				return r_PObjectIdentity;
			}
		}

		/// <summary>
		/// Boolean Reset()
		/// </summary>
		protected RMethod r_MReset;
		public virtual RMethod RMReset
		{
			get
			{
				if(r_MReset == null)
				{
					r_MReset = new(this, "Reset", 0);
				}
				return r_MReset;
			}
		}

		/// <summary>
		/// Boolean Set()
		/// </summary>
		protected RMethod r_MSet;
		public virtual RMethod RMSet
		{
			get
			{
				if(r_MSet == null)
				{
					r_MSet = new(this, "Set", 0);
				}
				return r_MSet;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.EventWaitHandleSecurity GetAccessControl()
		/// </summary>
		protected RMethod r_MGetAccessControl;
		public virtual RMethod RMGetAccessControl
		{
			get
			{
				if(r_MGetAccessControl == null)
				{
					r_MGetAccessControl = new(this, "GetAccessControl", 0);
				}
				return r_MGetAccessControl;
			}
		}

		/// <summary>
		/// Void SetAccessControl(System.Security.AccessControl.EventWaitHandleSecurity)
		/// </summary>
		protected RMethod r_MSetAccessControl_EventWaitHandleSecurity;
		public virtual RMethod RMSetAccessControl_EventWaitHandleSecurity
		{
			get
			{
				if(r_MSetAccessControl_EventWaitHandleSecurity == null)
				{
					r_MSetAccessControl_EventWaitHandleSecurity = new(this, "SetAccessControl", 0, typeof(System.Security.AccessControl.EventWaitHandleSecurity));
				}
				return r_MSetAccessControl_EventWaitHandleSecurity;
			}
		}

		/// <summary>
		/// Void SetHandleInternal(Microsoft.Win32.SafeHandles.SafeWaitHandle)
		/// </summary>
		protected RMethod r_MSetHandleInternal_SafeWaitHandle;
		public virtual RMethod RMSetHandleInternal_SafeWaitHandle
		{
			get
			{
				if(r_MSetHandleInternal_SafeWaitHandle == null)
				{
					r_MSetHandleInternal_SafeWaitHandle = new(this, "SetHandleInternal", 0, typeof(Microsoft.Win32.SafeHandles.SafeWaitHandle));
				}
				return r_MSetHandleInternal_SafeWaitHandle;
			}
		}

		/// <summary>
		/// Boolean WaitOne(Int32, Boolean)
		/// </summary>
		protected RMethod r_MWaitOne_Int32_Boolean;
		public virtual RMethod RMWaitOne_Int32_Boolean
		{
			get
			{
				if(r_MWaitOne_Int32_Boolean == null)
				{
					r_MWaitOne_Int32_Boolean = new(this, "WaitOne", 0, typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MWaitOne_Int32_Boolean;
			}
		}

		/// <summary>
		/// Boolean WaitOne(System.TimeSpan, Boolean)
		/// </summary>
		protected RMethod r_MWaitOne_TimeSpan_Boolean;
		public virtual RMethod RMWaitOne_TimeSpan_Boolean
		{
			get
			{
				if(r_MWaitOne_TimeSpan_Boolean == null)
				{
					r_MWaitOne_TimeSpan_Boolean = new(this, "WaitOne", 0, typeof(System.TimeSpan), typeof(System.Boolean));
				}
				return r_MWaitOne_TimeSpan_Boolean;
			}
		}

		/// <summary>
		/// Boolean WaitOne()
		/// </summary>
		protected RMethod r_MWaitOne;
		public virtual RMethod RMWaitOne
		{
			get
			{
				if(r_MWaitOne == null)
				{
					r_MWaitOne = new(this, "WaitOne", 0);
				}
				return r_MWaitOne;
			}
		}

		/// <summary>
		/// Boolean WaitOne(Int32)
		/// </summary>
		protected RMethod r_MWaitOne_Int32;
		public virtual RMethod RMWaitOne_Int32
		{
			get
			{
				if(r_MWaitOne_Int32 == null)
				{
					r_MWaitOne_Int32 = new(this, "WaitOne", 0, typeof(System.Int32));
				}
				return r_MWaitOne_Int32;
			}
		}

		/// <summary>
		/// Boolean WaitOne(System.TimeSpan)
		/// </summary>
		protected RMethod r_MWaitOne_TimeSpan;
		public virtual RMethod RMWaitOne_TimeSpan
		{
			get
			{
				if(r_MWaitOne_TimeSpan == null)
				{
					r_MWaitOne_TimeSpan = new(this, "WaitOne", 0, typeof(System.TimeSpan));
				}
				return r_MWaitOne_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean WaitOneWithoutFAS()
		/// </summary>
		protected RMethod r_MWaitOneWithoutFAS;
		public virtual RMethod RMWaitOneWithoutFAS
		{
			get
			{
				if(r_MWaitOneWithoutFAS == null)
				{
					r_MWaitOneWithoutFAS = new(this, "WaitOneWithoutFAS", 0);
				}
				return r_MWaitOneWithoutFAS;
			}
		}

		/// <summary>
		/// Void Close()
		/// </summary>
		protected RMethod r_MClose;
		public virtual RMethod RMClose
		{
			get
			{
				if(r_MClose == null)
				{
					r_MClose = new(this, "Close", 0);
				}
				return r_MClose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_MDispose_Boolean;
		public virtual RMethod RMDispose_Boolean
		{
			get
			{
				if(r_MDispose_Boolean == null)
				{
					r_MDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
				}
				return r_MDispose_Boolean;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_MDispose;
		public virtual RMethod RMDispose
		{
			get
			{
				if(r_MDispose == null)
				{
					r_MDispose = new(this, "Dispose", 0);
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Identity GetObjectIdentity(System.MarshalByRefObject, Boolean ByRef)
		/// </summary>
		protected RMethod r_MGetObjectIdentity_MarshalByRefObject_Out_Boolean;
		public virtual RMethod RMGetObjectIdentity_MarshalByRefObject_Out_Boolean
		{
			get
			{
				if(r_MGetObjectIdentity_MarshalByRefObject_Out_Boolean == null)
				{
					r_MGetObjectIdentity_MarshalByRefObject_Out_Boolean = new(this, "GetObjectIdentity", 0, typeof(System.MarshalByRefObject), typeof(System.Boolean).MakeByRefType());
				}
				return r_MGetObjectIdentity_MarshalByRefObject_Out_Boolean;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjRef CreateObjRef(System.Type)
		/// </summary>
		protected RMethod r_MCreateObjRef_Type;
		public virtual RMethod RMCreateObjRef_Type
		{
			get
			{
				if(r_MCreateObjRef_Type == null)
				{
					r_MCreateObjRef_Type = new(this, "CreateObjRef", 0, typeof(System.Type));
				}
				return r_MCreateObjRef_Type;
			}
		}

		/// <summary>
		/// System.Object GetLifetimeService()
		/// </summary>
		protected RMethod r_MGetLifetimeService;
		public virtual RMethod RMGetLifetimeService
		{
			get
			{
				if(r_MGetLifetimeService == null)
				{
					r_MGetLifetimeService = new(this, "GetLifetimeService", 0);
				}
				return r_MGetLifetimeService;
			}
		}

		/// <summary>
		/// System.Object InitializeLifetimeService()
		/// </summary>
		protected RMethod r_MInitializeLifetimeService;
		public virtual RMethod RMInitializeLifetimeService
		{
			get
			{
				if(r_MInitializeLifetimeService == null)
				{
					r_MInitializeLifetimeService = new(this, "InitializeLifetimeService", 0);
				}
				return r_MInitializeLifetimeService;
			}
		}

		/// <summary>
		/// System.MarshalByRefObject MemberwiseClone(Boolean)
		/// </summary>
		protected RMethod r_MMemberwiseClone_Boolean;
		public virtual RMethod RMMemberwiseClone_Boolean
		{
			get
			{
				if(r_MMemberwiseClone_Boolean == null)
				{
					r_MMemberwiseClone_Boolean = new(this, "MemberwiseClone", 0, typeof(System.Boolean));
				}
				return r_MMemberwiseClone_Boolean;
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


        public virtual System.Boolean Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReset.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Set()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSet.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Security.AccessControl.EventWaitHandleSecurity GetAccessControl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetAccessControl.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Security.AccessControl.EventWaitHandleSecurity>(___result);
        }


        public virtual void SetAccessControl(System.Security.AccessControl.EventWaitHandleSecurity @eventSecurity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventSecurity};
            var ___result = RMSetAccessControl_EventWaitHandleSecurity.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetHandleInternal(Microsoft.Win32.SafeHandles.SafeWaitHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMSetHandleInternal_SafeWaitHandle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean WaitOne(System.Int32 @millisecondsTimeout, System.Boolean @exitContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout, @exitContext};
            var ___result = RMWaitOne_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean WaitOne(System.TimeSpan @timeout, System.Boolean @exitContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout, @exitContext};
            var ___result = RMWaitOne_TimeSpan_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean WaitOne()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMWaitOne.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean WaitOne(System.Int32 @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout};
            var ___result = RMWaitOne_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean WaitOne(System.TimeSpan @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout};
            var ___result = RMWaitOne_TimeSpan.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean WaitOneWithoutFAS()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMWaitOneWithoutFAS.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean @explicitDisposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@explicitDisposing};
            var ___result = RMDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RIdentity GetObjectIdentity(System.MarshalByRefObject @obj, out System.Boolean @IsClient)
        {
			@IsClient = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @IsClient};
            var ___result = RMGetObjectIdentity_MarshalByRefObject_Out_Boolean.Invoke(___genericsType, ___parameters);
			@IsClient = (System.Boolean)___parameters[1];

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RIdentity>(___result);
        }


        public virtual System.Runtime.Remoting.ObjRef CreateObjRef(System.Type @requestedType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@requestedType};
            var ___result = RMCreateObjRef_Type.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Runtime.Remoting.ObjRef>(___result);
        }


        public virtual System.Object GetLifetimeService()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetLifetimeService.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Object InitializeLifetimeService()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitializeLifetimeService.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.MarshalByRefObject MemberwiseClone(System.Boolean @cloneIdentity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cloneIdentity};
            var ___result = RMMemberwiseClone_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.MarshalByRefObject>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
