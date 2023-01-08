using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.AppDomainManager
	/// </summary>
    public partial class RAppDomainManager : RMember //
    {

		/// <summary>
		/// System.Runtime.Hosting.ApplicationActivator _activator
		/// </summary>
		protected RSystem.RRuntime.RHosting.RApplicationActivator r__activator;
		public virtual RSystem.RRuntime.RHosting.RApplicationActivator R_activator
		{
			get
			{
				if(r__activator == null)
				{
					r__activator = new(this, "_activator");
					r__activator.SetBelong(this.instance);
				}
				return r__activator;
			}
		}

		/// <summary>
		/// System.AppDomainManagerInitializationOptions _flags
		/// </summary>
		protected RField r__flags;
		public virtual RField R_flags
		{
			get
			{
				if(r__flags == null)
				{
					r__flags = new(this, "_flags");
					r__flags.SetBelong(this.instance);
				}
				return r__flags;
			}
		}

		/// <summary>
		/// System.Runtime.Hosting.ApplicationActivator ApplicationActivator
		/// </summary>
		protected RSystem.RRuntime.RHosting.RApplicationActivator r_ApplicationActivator;
		public virtual RSystem.RRuntime.RHosting.RApplicationActivator RApplicationActivator
		{
			get
			{
				if(r_ApplicationActivator == null)
				{
					r_ApplicationActivator = new(this, "ApplicationActivator", -1);
					r_ApplicationActivator.SetBelong(this.instance);
				}
				return r_ApplicationActivator;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly EntryAssembly
		/// </summary>
		protected RSystem.RReflection.RAssembly r_EntryAssembly;
		public virtual RSystem.RReflection.RAssembly REntryAssembly
		{
			get
			{
				if(r_EntryAssembly == null)
				{
					r_EntryAssembly = new(this, "EntryAssembly", -1);
					r_EntryAssembly.SetBelong(this.instance);
				}
				return r_EntryAssembly;
			}
		}

		/// <summary>
		/// System.Threading.HostExecutionContextManager HostExecutionContextManager
		/// </summary>
		protected RSystem.RThreading.RHostExecutionContextManager r_HostExecutionContextManager;
		public virtual RSystem.RThreading.RHostExecutionContextManager RHostExecutionContextManager
		{
			get
			{
				if(r_HostExecutionContextManager == null)
				{
					r_HostExecutionContextManager = new(this, "HostExecutionContextManager", -1);
					r_HostExecutionContextManager.SetBelong(this.instance);
				}
				return r_HostExecutionContextManager;
			}
		}

		/// <summary>
		/// System.Security.HostSecurityManager HostSecurityManager
		/// </summary>
		protected RSystem.RSecurity.RHostSecurityManager r_HostSecurityManager;
		public virtual RSystem.RSecurity.RHostSecurityManager RHostSecurityManager
		{
			get
			{
				if(r_HostSecurityManager == null)
				{
					r_HostSecurityManager = new(this, "HostSecurityManager", -1);
					r_HostSecurityManager.SetBelong(this.instance);
				}
				return r_HostSecurityManager;
			}
		}

		/// <summary>
		/// System.AppDomainManagerInitializationOptions InitializationFlags
		/// </summary>
		protected RProperty r_InitializationFlags;
		public virtual RProperty RInitializationFlags
		{
			get
			{
				if(r_InitializationFlags == null)
				{
					r_InitializationFlags = new(this, "InitializationFlags", -1);
					r_InitializationFlags.SetBelong(this.instance);
				}
				return r_InitializationFlags;
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
		/// System.AppDomain CreateDomain(System.String, System.Security.Policy.Evidence, System.AppDomainSetup)
		/// </summary>
		protected RMethod r_CreateDomain_String_Evidence_AppDomainSetup;
		public virtual RMethod RCreateDomain_String_Evidence_AppDomainSetup
		{
			get
			{
				if(r_CreateDomain_String_Evidence_AppDomainSetup == null)
				{
					r_CreateDomain_String_Evidence_AppDomainSetup = new(this, "CreateDomain", 0, typeof(System.String), typeof(System.Security.Policy.Evidence), typeof(System.AppDomainSetup));
					r_CreateDomain_String_Evidence_AppDomainSetup.SetBelong(this.instance);
				}
				return r_CreateDomain_String_Evidence_AppDomainSetup;
			}
		}

		/// <summary>
		/// Void InitializeNewDomain(System.AppDomainSetup)
		/// </summary>
		protected RMethod r_InitializeNewDomain_AppDomainSetup;
		public virtual RMethod RInitializeNewDomain_AppDomainSetup
		{
			get
			{
				if(r_InitializeNewDomain_AppDomainSetup == null)
				{
					r_InitializeNewDomain_AppDomainSetup = new(this, "InitializeNewDomain", 0, typeof(System.AppDomainSetup));
					r_InitializeNewDomain_AppDomainSetup.SetBelong(this.instance);
				}
				return r_InitializeNewDomain_AppDomainSetup;
			}
		}

		/// <summary>
		/// Boolean CheckSecuritySettings(System.Security.SecurityState)
		/// </summary>
		protected RMethod r_CheckSecuritySettings_SecurityState;
		public virtual RMethod RCheckSecuritySettings_SecurityState
		{
			get
			{
				if(r_CheckSecuritySettings_SecurityState == null)
				{
					r_CheckSecuritySettings_SecurityState = new(this, "CheckSecuritySettings", 0, typeof(System.Security.SecurityState));
					r_CheckSecuritySettings_SecurityState.SetBelong(this.instance);
				}
				return r_CheckSecuritySettings_SecurityState;
			}
		}

		/// <summary>
		/// System.AppDomain CreateDomainHelper(System.String, System.Security.Policy.Evidence, System.AppDomainSetup)
		/// </summary>
		protected static RMethod r_CreateDomainHelper_String_Evidence_AppDomainSetup;
		public static RMethod RCreateDomainHelper_String_Evidence_AppDomainSetup
		{
			get
			{
				if(r_CreateDomainHelper_String_Evidence_AppDomainSetup == null)
				{
					r_CreateDomainHelper_String_Evidence_AppDomainSetup = new(typeof(System.AppDomainManager), "CreateDomainHelper", 0, typeof(System.String), typeof(System.Security.Policy.Evidence), typeof(System.AppDomainSetup));
					r_CreateDomainHelper_String_Evidence_AppDomainSetup.SetBelong(null);
				}
				return r_CreateDomainHelper_String_Evidence_AppDomainSetup;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Identity GetObjectIdentity(System.MarshalByRefObject, Boolean ByRef)
		/// </summary>
		protected RMethod r_GetObjectIdentity_MarshalByRefObject_Out_Boolean;
		public virtual RMethod RGetObjectIdentity_MarshalByRefObject_Out_Boolean
		{
			get
			{
				if(r_GetObjectIdentity_MarshalByRefObject_Out_Boolean == null)
				{
					r_GetObjectIdentity_MarshalByRefObject_Out_Boolean = new(this, "GetObjectIdentity", 0, typeof(System.MarshalByRefObject), typeof(System.Boolean).MakeByRefType());
					r_GetObjectIdentity_MarshalByRefObject_Out_Boolean.SetBelong(this.instance);
				}
				return r_GetObjectIdentity_MarshalByRefObject_Out_Boolean;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjRef CreateObjRef(System.Type)
		/// </summary>
		protected RMethod r_CreateObjRef_Type;
		public virtual RMethod RCreateObjRef_Type
		{
			get
			{
				if(r_CreateObjRef_Type == null)
				{
					r_CreateObjRef_Type = new(this, "CreateObjRef", 0, typeof(System.Type));
					r_CreateObjRef_Type.SetBelong(this.instance);
				}
				return r_CreateObjRef_Type;
			}
		}

		/// <summary>
		/// System.Object GetLifetimeService()
		/// </summary>
		protected RMethod r_GetLifetimeService;
		public virtual RMethod RGetLifetimeService
		{
			get
			{
				if(r_GetLifetimeService == null)
				{
					r_GetLifetimeService = new(this, "GetLifetimeService", 0);
					r_GetLifetimeService.SetBelong(this.instance);
				}
				return r_GetLifetimeService;
			}
		}

		/// <summary>
		/// System.Object InitializeLifetimeService()
		/// </summary>
		protected RMethod r_InitializeLifetimeService;
		public virtual RMethod RInitializeLifetimeService
		{
			get
			{
				if(r_InitializeLifetimeService == null)
				{
					r_InitializeLifetimeService = new(this, "InitializeLifetimeService", 0);
					r_InitializeLifetimeService.SetBelong(this.instance);
				}
				return r_InitializeLifetimeService;
			}
		}

		/// <summary>
		/// System.MarshalByRefObject MemberwiseClone(Boolean)
		/// </summary>
		protected RMethod r_MemberwiseClone_Boolean;
		public virtual RMethod RMemberwiseClone_Boolean
		{
			get
			{
				if(r_MemberwiseClone_Boolean == null)
				{
					r_MemberwiseClone_Boolean = new(this, "MemberwiseClone", 0, typeof(System.Boolean));
					r_MemberwiseClone_Boolean.SetBelong(this.instance);
				}
				return r_MemberwiseClone_Boolean;
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


        public RAppDomainManager() : base("System.AppDomainManager")
        {
        }

        public RAppDomainManager(System.Object instance) : base("System.AppDomainManager")
		{
            SetInstance(instance);
		}

        public RAppDomainManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAppDomainManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.AppDomain CreateDomain(System.String  @friendlyName, System.Security.Policy.Evidence  @securityInfo, System.AppDomainSetup  @appDomainInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@friendlyName, @securityInfo, @appDomainInfo};
            var ___result = RCreateDomain_String_Evidence_AppDomainSetup.Invoke(___genericsType, ___parameters);

            return (System.AppDomain)___result;
        }


        public virtual void InitializeNewDomain(System.AppDomainSetup  @appDomainInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@appDomainInfo};
            var ___result = RInitializeNewDomain_AppDomainSetup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CheckSecuritySettings(System.Security.SecurityState  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state};
            var ___result = RCheckSecuritySettings_SecurityState.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.AppDomain CreateDomainHelper(System.String  @friendlyName, System.Security.Policy.Evidence  @securityInfo, System.AppDomainSetup  @appDomainInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@friendlyName, @securityInfo, @appDomainInfo};
            var ___result = RCreateDomainHelper_String_Evidence_AppDomainSetup.Invoke(___genericsType, ___parameters);

            return (System.AppDomain)___result;
        }


        public virtual System.Object GetObjectIdentity(System.MarshalByRefObject  @obj, out System.Boolean  @IsClient)
        {
			@IsClient = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @IsClient};
            var ___result = RGetObjectIdentity_MarshalByRefObject_Out_Boolean.Invoke(___genericsType, ___parameters);
			@IsClient = (System.Boolean)___parameters[1];

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
