
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.AppDomainManager
	/// </summary>
    public partial class RAppDomainManager : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.AppDomainManager);
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


		/// <summary>
		/// System.Runtime.Hosting.ApplicationActivator _activator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RHosting.RApplicationActivator r_F_activator;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RHosting.RApplicationActivator RF_activator
		{
			get
			{
				if(r_F_activator == null)
				{
					r_F_activator = new(this, "_activator");
				}
				return r_F_activator;
			}
		}

		/// <summary>
		/// System.AppDomainManagerInitializationOptions _flags
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAppDomainManagerInitializationOptions r_F_flags;
		public virtual Hvak.Editor.Refleaction.RSystem.RAppDomainManagerInitializationOptions RF_flags
		{
			get
			{
				if(r_F_flags == null)
				{
					r_F_flags = new(this, "_flags");
				}
				return r_F_flags;
			}
		}

		/// <summary>
		/// System.Runtime.Hosting.ApplicationActivator ApplicationActivator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RHosting.RApplicationActivator r_PApplicationActivator;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RHosting.RApplicationActivator RPApplicationActivator
		{
			get
			{
				if(r_PApplicationActivator == null)
				{
					r_PApplicationActivator = new(this, "ApplicationActivator", -1);
				}
				return r_PApplicationActivator;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly EntryAssembly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RAssembly r_PEntryAssembly;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RAssembly RPEntryAssembly
		{
			get
			{
				if(r_PEntryAssembly == null)
				{
					r_PEntryAssembly = new(this, "EntryAssembly", -1);
				}
				return r_PEntryAssembly;
			}
		}

		/// <summary>
		/// System.Threading.HostExecutionContextManager HostExecutionContextManager
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RHostExecutionContextManager r_PHostExecutionContextManager;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RHostExecutionContextManager RPHostExecutionContextManager
		{
			get
			{
				if(r_PHostExecutionContextManager == null)
				{
					r_PHostExecutionContextManager = new(this, "HostExecutionContextManager", -1);
				}
				return r_PHostExecutionContextManager;
			}
		}

		/// <summary>
		/// System.Security.HostSecurityManager HostSecurityManager
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RHostSecurityManager r_PHostSecurityManager;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RHostSecurityManager RPHostSecurityManager
		{
			get
			{
				if(r_PHostSecurityManager == null)
				{
					r_PHostSecurityManager = new(this, "HostSecurityManager", -1);
				}
				return r_PHostSecurityManager;
			}
		}

		/// <summary>
		/// System.AppDomainManagerInitializationOptions InitializationFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAppDomainManagerInitializationOptions r_PInitializationFlags;
		public virtual Hvak.Editor.Refleaction.RSystem.RAppDomainManagerInitializationOptions RPInitializationFlags
		{
			get
			{
				if(r_PInitializationFlags == null)
				{
					r_PInitializationFlags = new(this, "InitializationFlags", -1);
				}
				return r_PInitializationFlags;
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
		/// System.AppDomain CreateDomain(System.String, System.Security.Policy.Evidence, System.AppDomainSetup)
		/// </summary>
		protected RMethod r_MCreateDomain_String_Evidence_AppDomainSetup;
		public virtual RMethod RMCreateDomain_String_Evidence_AppDomainSetup
		{
			get
			{
				if(r_MCreateDomain_String_Evidence_AppDomainSetup == null)
				{
					r_MCreateDomain_String_Evidence_AppDomainSetup = new(this, "CreateDomain", 0, typeof(System.String), typeof(System.Security.Policy.Evidence), typeof(System.AppDomainSetup));
				}
				return r_MCreateDomain_String_Evidence_AppDomainSetup;
			}
		}

		/// <summary>
		/// Void InitializeNewDomain(System.AppDomainSetup)
		/// </summary>
		protected RMethod r_MInitializeNewDomain_AppDomainSetup;
		public virtual RMethod RMInitializeNewDomain_AppDomainSetup
		{
			get
			{
				if(r_MInitializeNewDomain_AppDomainSetup == null)
				{
					r_MInitializeNewDomain_AppDomainSetup = new(this, "InitializeNewDomain", 0, typeof(System.AppDomainSetup));
				}
				return r_MInitializeNewDomain_AppDomainSetup;
			}
		}

		/// <summary>
		/// Boolean CheckSecuritySettings(System.Security.SecurityState)
		/// </summary>
		protected RMethod r_MCheckSecuritySettings_SecurityState;
		public virtual RMethod RMCheckSecuritySettings_SecurityState
		{
			get
			{
				if(r_MCheckSecuritySettings_SecurityState == null)
				{
					r_MCheckSecuritySettings_SecurityState = new(this, "CheckSecuritySettings", 0, typeof(System.Security.SecurityState));
				}
				return r_MCheckSecuritySettings_SecurityState;
			}
		}

		/// <summary>
		/// System.AppDomain CreateDomainHelper(System.String, System.Security.Policy.Evidence, System.AppDomainSetup)
		/// </summary>
		protected static RMethod r_MCreateDomainHelper_String_Evidence_AppDomainSetup;
		public static RMethod RMCreateDomainHelper_String_Evidence_AppDomainSetup
		{
			get
			{
				if(r_MCreateDomainHelper_String_Evidence_AppDomainSetup == null)
				{
					r_MCreateDomainHelper_String_Evidence_AppDomainSetup = new(typeof(System.AppDomainManager), "CreateDomainHelper", 0, typeof(System.String), typeof(System.Security.Policy.Evidence), typeof(System.AppDomainSetup));
				}
				return r_MCreateDomainHelper_String_Evidence_AppDomainSetup;
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


        public virtual System.AppDomain CreateDomain(System.String @friendlyName, System.Security.Policy.Evidence @securityInfo, System.AppDomainSetup @appDomainInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@friendlyName, @securityInfo, @appDomainInfo};
            var ___result = RMCreateDomain_String_Evidence_AppDomainSetup.Invoke(___genericsType, ___parameters);

            return (System.AppDomain)___result;
        }


        public virtual void InitializeNewDomain(System.AppDomainSetup @appDomainInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@appDomainInfo};
            var ___result = RMInitializeNewDomain_AppDomainSetup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CheckSecuritySettings(System.Security.SecurityState @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state};
            var ___result = RMCheckSecuritySettings_SecurityState.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.AppDomain CreateDomainHelper(System.String @friendlyName, System.Security.Policy.Evidence @securityInfo, System.AppDomainSetup @appDomainInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@friendlyName, @securityInfo, @appDomainInfo};
            var ___result = RMCreateDomainHelper_String_Evidence_AppDomainSetup.Invoke(___genericsType, ___parameters);

            return (System.AppDomain)___result;
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RIdentity GetObjectIdentity(System.MarshalByRefObject @obj, out System.Boolean @IsClient)
        {
			@IsClient = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @IsClient};
            var ___result = RMGetObjectIdentity_MarshalByRefObject_Out_Boolean.Invoke(___genericsType, ___parameters);
			@IsClient = (System.Boolean)___parameters[1];

            return new Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RIdentity(___result);
        }


        public virtual System.Runtime.Remoting.ObjRef CreateObjRef(System.Type @requestedType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@requestedType};
            var ___result = RMCreateObjRef_Type.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjRef)___result;
        }


        public virtual System.Object GetLifetimeService()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetLifetimeService.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object InitializeLifetimeService()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitializeLifetimeService.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.MarshalByRefObject MemberwiseClone(System.Boolean @cloneIdentity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cloneIdentity};
            var ___result = RMMemberwiseClone_Boolean.Invoke(___genericsType, ___parameters);

            return (System.MarshalByRefObject)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
