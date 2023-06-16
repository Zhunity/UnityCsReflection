
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.AppDomain
	/// </summary>
    public partial class RAppDomain : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.AppDomain);
            }
        }

        public RAppDomain() : base("System.AppDomain")
        {
        }

        public RAppDomain(System.Object instance) : base("System.AppDomain")
		{
            SetInstance(instance);
		}

        public RAppDomain(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAppDomain(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.AssemblyLoadEventHandler AssemblyLoad
		/// </summary>
		protected REvent r_EAssemblyLoad;
		public virtual REvent REAssemblyLoad
		{
			get
			{
				if(r_EAssemblyLoad == null)
				{
					r_EAssemblyLoad = new(this, "AssemblyLoad");
				}
				return r_EAssemblyLoad;
			}
		}

		/// <summary>
		/// System.ResolveEventHandler AssemblyResolve
		/// </summary>
		protected REvent r_EAssemblyResolve;
		public virtual REvent REAssemblyResolve
		{
			get
			{
				if(r_EAssemblyResolve == null)
				{
					r_EAssemblyResolve = new(this, "AssemblyResolve");
				}
				return r_EAssemblyResolve;
			}
		}

		/// <summary>
		/// System.EventHandler DomainUnload
		/// </summary>
		protected REvent r_EDomainUnload;
		public virtual REvent REDomainUnload
		{
			get
			{
				if(r_EDomainUnload == null)
				{
					r_EDomainUnload = new(this, "DomainUnload");
				}
				return r_EDomainUnload;
			}
		}

		/// <summary>
		/// System.EventHandler ProcessExit
		/// </summary>
		protected REvent r_EProcessExit;
		public virtual REvent REProcessExit
		{
			get
			{
				if(r_EProcessExit == null)
				{
					r_EProcessExit = new(this, "ProcessExit");
				}
				return r_EProcessExit;
			}
		}

		/// <summary>
		/// System.ResolveEventHandler ResourceResolve
		/// </summary>
		protected REvent r_EResourceResolve;
		public virtual REvent REResourceResolve
		{
			get
			{
				if(r_EResourceResolve == null)
				{
					r_EResourceResolve = new(this, "ResourceResolve");
				}
				return r_EResourceResolve;
			}
		}

		/// <summary>
		/// System.ResolveEventHandler TypeResolve
		/// </summary>
		protected REvent r_ETypeResolve;
		public virtual REvent RETypeResolve
		{
			get
			{
				if(r_ETypeResolve == null)
				{
					r_ETypeResolve = new(this, "TypeResolve");
				}
				return r_ETypeResolve;
			}
		}

		/// <summary>
		/// System.UnhandledExceptionEventHandler UnhandledException
		/// </summary>
		protected REvent r_EUnhandledException;
		public virtual REvent REUnhandledException
		{
			get
			{
				if(r_EUnhandledException == null)
				{
					r_EUnhandledException = new(this, "UnhandledException");
				}
				return r_EUnhandledException;
			}
		}

		/// <summary>
		/// System.EventHandler`1[System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs] FirstChanceException
		/// </summary>
		protected REvent r_EFirstChanceException;
		public virtual REvent REFirstChanceException
		{
			get
			{
				if(r_EFirstChanceException == null)
				{
					r_EFirstChanceException = new(this, "FirstChanceException");
				}
				return r_EFirstChanceException;
			}
		}

		/// <summary>
		/// System.ResolveEventHandler ReflectionOnlyAssemblyResolve
		/// </summary>
		protected REvent r_EReflectionOnlyAssemblyResolve;
		public virtual REvent REReflectionOnlyAssemblyResolve
		{
			get
			{
				if(r_EReflectionOnlyAssemblyResolve == null)
				{
					r_EReflectionOnlyAssemblyResolve = new(this, "ReflectionOnlyAssemblyResolve");
				}
				return r_EReflectionOnlyAssemblyResolve;
			}
		}

		/// <summary>
		/// System.IntPtr _mono_app_domain
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_F_mono_app_domain;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RF_mono_app_domain
		{
			get
			{
				if(r_F_mono_app_domain == null)
				{
					r_F_mono_app_domain = new(this, "_mono_app_domain");
				}
				return r_F_mono_app_domain;
			}
		}

		/// <summary>
		/// System.String _process_guid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_F_process_guid;
		public static Hvak.Editor.Refleaction.RSystem.RString RF_process_guid
		{
			get
			{
				if(r_F_process_guid == null)
				{
					r_F_process_guid = new(Type, "_process_guid");
				}
				return r_F_process_guid;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Object] type_resolve_in_progress
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RObject> r_Ftype_resolve_in_progress;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RObject> RFtype_resolve_in_progress
		{
			get
			{
				if(r_Ftype_resolve_in_progress == null)
				{
					r_Ftype_resolve_in_progress = new(Type, "type_resolve_in_progress");
				}
				return r_Ftype_resolve_in_progress;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Object] assembly_resolve_in_progress
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RObject> r_Fassembly_resolve_in_progress;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RObject> RFassembly_resolve_in_progress
		{
			get
			{
				if(r_Fassembly_resolve_in_progress == null)
				{
					r_Fassembly_resolve_in_progress = new(Type, "assembly_resolve_in_progress");
				}
				return r_Fassembly_resolve_in_progress;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Object] assembly_resolve_in_progress_refonly
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RObject> r_Fassembly_resolve_in_progress_refonly;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RObject> RFassembly_resolve_in_progress_refonly
		{
			get
			{
				if(r_Fassembly_resolve_in_progress_refonly == null)
				{
					r_Fassembly_resolve_in_progress_refonly = new(Type, "assembly_resolve_in_progress_refonly");
				}
				return r_Fassembly_resolve_in_progress_refonly;
			}
		}

		/// <summary>
		/// System.Security.Policy.Evidence _evidence
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.REvidence r_F_evidence;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.REvidence RF_evidence
		{
			get
			{
				if(r_F_evidence == null)
				{
					r_F_evidence = new(this, "_evidence");
				}
				return r_F_evidence;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet _granted
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPermissionSet r_F_granted;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPermissionSet RF_granted
		{
			get
			{
				if(r_F_granted == null)
				{
					r_F_granted = new(this, "_granted");
				}
				return r_F_granted;
			}
		}

		/// <summary>
		/// System.Security.Principal.PrincipalPolicy _principalPolicy
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RPrincipalPolicy r_F_principalPolicy;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RPrincipalPolicy RF_principalPolicy
		{
			get
			{
				if(r_F_principalPolicy == null)
				{
					r_F_principalPolicy = new(this, "_principalPolicy");
				}
				return r_F_principalPolicy;
			}
		}

		/// <summary>
		/// System.Security.Principal.IPrincipal _principal
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RIPrincipal r_F_principal;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RIPrincipal RF_principal
		{
			get
			{
				if(r_F_principal == null)
				{
					r_F_principal = new(Type, "_principal");
				}
				return r_F_principal;
			}
		}

		/// <summary>
		/// System.AppDomain default_domain
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RAppDomain r_Fdefault_domain;
		public static Hvak.Editor.Refleaction.RSystem.RAppDomain RFdefault_domain
		{
			get
			{
				if(r_Fdefault_domain == null)
				{
					r_Fdefault_domain = new(Type, "default_domain");
				}
				return r_Fdefault_domain;
			}
		}

		/// <summary>
		/// System.AssemblyLoadEventHandler AssemblyLoad
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAssemblyLoadEventHandler r_FAssemblyLoad;
		public virtual Hvak.Editor.Refleaction.RSystem.RAssemblyLoadEventHandler RFAssemblyLoad
		{
			get
			{
				if(r_FAssemblyLoad == null)
				{
					r_FAssemblyLoad = new(this, "AssemblyLoad");
				}
				return r_FAssemblyLoad;
			}
		}

		/// <summary>
		/// System.ResolveEventHandler AssemblyResolve
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RResolveEventHandler r_FAssemblyResolve;
		public virtual Hvak.Editor.Refleaction.RSystem.RResolveEventHandler RFAssemblyResolve
		{
			get
			{
				if(r_FAssemblyResolve == null)
				{
					r_FAssemblyResolve = new(this, "AssemblyResolve");
				}
				return r_FAssemblyResolve;
			}
		}

		/// <summary>
		/// System.EventHandler DomainUnload
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.REventHandler r_FDomainUnload;
		public virtual Hvak.Editor.Refleaction.RSystem.REventHandler RFDomainUnload
		{
			get
			{
				if(r_FDomainUnload == null)
				{
					r_FDomainUnload = new(this, "DomainUnload");
				}
				return r_FDomainUnload;
			}
		}

		/// <summary>
		/// System.EventHandler ProcessExit
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.REventHandler r_FProcessExit;
		public virtual Hvak.Editor.Refleaction.RSystem.REventHandler RFProcessExit
		{
			get
			{
				if(r_FProcessExit == null)
				{
					r_FProcessExit = new(this, "ProcessExit");
				}
				return r_FProcessExit;
			}
		}

		/// <summary>
		/// System.ResolveEventHandler ResourceResolve
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RResolveEventHandler r_FResourceResolve;
		public virtual Hvak.Editor.Refleaction.RSystem.RResolveEventHandler RFResourceResolve
		{
			get
			{
				if(r_FResourceResolve == null)
				{
					r_FResourceResolve = new(this, "ResourceResolve");
				}
				return r_FResourceResolve;
			}
		}

		/// <summary>
		/// System.ResolveEventHandler TypeResolve
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RResolveEventHandler r_FTypeResolve;
		public virtual Hvak.Editor.Refleaction.RSystem.RResolveEventHandler RFTypeResolve
		{
			get
			{
				if(r_FTypeResolve == null)
				{
					r_FTypeResolve = new(this, "TypeResolve");
				}
				return r_FTypeResolve;
			}
		}

		/// <summary>
		/// System.UnhandledExceptionEventHandler UnhandledException
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUnhandledExceptionEventHandler r_FUnhandledException;
		public virtual Hvak.Editor.Refleaction.RSystem.RUnhandledExceptionEventHandler RFUnhandledException
		{
			get
			{
				if(r_FUnhandledException == null)
				{
					r_FUnhandledException = new(this, "UnhandledException");
				}
				return r_FUnhandledException;
			}
		}

		/// <summary>
		/// System.EventHandler`1[System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs] FirstChanceException
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.REventHandler<Hvak.Editor.Refleaction.RSystem.RRuntime.RExceptionServices.RFirstChanceExceptionEventArgs> r_FFirstChanceException;
		public virtual Hvak.Editor.Refleaction.RSystem.REventHandler<Hvak.Editor.Refleaction.RSystem.RRuntime.RExceptionServices.RFirstChanceExceptionEventArgs> RFFirstChanceException
		{
			get
			{
				if(r_FFirstChanceException == null)
				{
					r_FFirstChanceException = new(this, "FirstChanceException");
				}
				return r_FFirstChanceException;
			}
		}

		/// <summary>
		/// System.AppDomainManager _domain_manager
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAppDomainManager r_F_domain_manager;
		public virtual Hvak.Editor.Refleaction.RSystem.RAppDomainManager RF_domain_manager
		{
			get
			{
				if(r_F_domain_manager == null)
				{
					r_F_domain_manager = new(this, "_domain_manager");
				}
				return r_F_domain_manager;
			}
		}

		/// <summary>
		/// System.ResolveEventHandler ReflectionOnlyAssemblyResolve
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RResolveEventHandler r_FReflectionOnlyAssemblyResolve;
		public virtual Hvak.Editor.Refleaction.RSystem.RResolveEventHandler RFReflectionOnlyAssemblyResolve
		{
			get
			{
				if(r_FReflectionOnlyAssemblyResolve == null)
				{
					r_FReflectionOnlyAssemblyResolve = new(this, "ReflectionOnlyAssemblyResolve");
				}
				return r_FReflectionOnlyAssemblyResolve;
			}
		}

		/// <summary>
		/// System.ActivationContext _activation
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RActivationContext r_F_activation;
		public virtual Hvak.Editor.Refleaction.RSystem.RActivationContext RF_activation
		{
			get
			{
				if(r_F_activation == null)
				{
					r_F_activation = new(this, "_activation");
				}
				return r_F_activation;
			}
		}

		/// <summary>
		/// System.ApplicationIdentity _applicationIdentity
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RApplicationIdentity r_F_applicationIdentity;
		public virtual Hvak.Editor.Refleaction.RSystem.RApplicationIdentity RF_applicationIdentity
		{
			get
			{
				if(r_F_applicationIdentity == null)
				{
					r_F_applicationIdentity = new(this, "_applicationIdentity");
				}
				return r_F_applicationIdentity;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] compatibility_switch
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> r_Fcompatibility_switch;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> RFcompatibility_switch
		{
			get
			{
				if(r_Fcompatibility_switch == null)
				{
					r_Fcompatibility_switch = new(this, "compatibility_switch");
				}
				return r_Fcompatibility_switch;
			}
		}

		/// <summary>
		/// System.AppDomainSetup SetupInformationNoCopy
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAppDomainSetup r_PSetupInformationNoCopy;
		public virtual Hvak.Editor.Refleaction.RSystem.RAppDomainSetup RPSetupInformationNoCopy
		{
			get
			{
				if(r_PSetupInformationNoCopy == null)
				{
					r_PSetupInformationNoCopy = new(this, "SetupInformationNoCopy", -1);
				}
				return r_PSetupInformationNoCopy;
			}
		}

		/// <summary>
		/// System.AppDomainSetup SetupInformation
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAppDomainSetup r_PSetupInformation;
		public virtual Hvak.Editor.Refleaction.RSystem.RAppDomainSetup RPSetupInformation
		{
			get
			{
				if(r_PSetupInformation == null)
				{
					r_PSetupInformation = new(this, "SetupInformation", -1);
				}
				return r_PSetupInformation;
			}
		}

		/// <summary>
		/// System.Security.Policy.ApplicationTrust ApplicationTrust
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.RApplicationTrust r_PApplicationTrust;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.RApplicationTrust RPApplicationTrust
		{
			get
			{
				if(r_PApplicationTrust == null)
				{
					r_PApplicationTrust = new(this, "ApplicationTrust", -1);
				}
				return r_PApplicationTrust;
			}
		}

		/// <summary>
		/// System.String BaseDirectory
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PBaseDirectory;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPBaseDirectory
		{
			get
			{
				if(r_PBaseDirectory == null)
				{
					r_PBaseDirectory = new(this, "BaseDirectory", -1);
				}
				return r_PBaseDirectory;
			}
		}

		/// <summary>
		/// System.String RelativeSearchPath
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PRelativeSearchPath;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPRelativeSearchPath
		{
			get
			{
				if(r_PRelativeSearchPath == null)
				{
					r_PRelativeSearchPath = new(this, "RelativeSearchPath", -1);
				}
				return r_PRelativeSearchPath;
			}
		}

		/// <summary>
		/// System.String DynamicDirectory
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PDynamicDirectory;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPDynamicDirectory
		{
			get
			{
				if(r_PDynamicDirectory == null)
				{
					r_PDynamicDirectory = new(this, "DynamicDirectory", -1);
				}
				return r_PDynamicDirectory;
			}
		}

		/// <summary>
		/// Boolean ShadowCopyFiles
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PShadowCopyFiles;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPShadowCopyFiles
		{
			get
			{
				if(r_PShadowCopyFiles == null)
				{
					r_PShadowCopyFiles = new(this, "ShadowCopyFiles", -1);
				}
				return r_PShadowCopyFiles;
			}
		}

		/// <summary>
		/// System.String FriendlyName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PFriendlyName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPFriendlyName
		{
			get
			{
				if(r_PFriendlyName == null)
				{
					r_PFriendlyName = new(this, "FriendlyName", -1);
				}
				return r_PFriendlyName;
			}
		}

		/// <summary>
		/// System.Security.Policy.Evidence Evidence
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.REvidence r_PEvidence;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.REvidence RPEvidence
		{
			get
			{
				if(r_PEvidence == null)
				{
					r_PEvidence = new(this, "Evidence", -1);
				}
				return r_PEvidence;
			}
		}

		/// <summary>
		/// System.Security.Principal.IPrincipal DefaultPrincipal
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RIPrincipal r_PDefaultPrincipal;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RIPrincipal RPDefaultPrincipal
		{
			get
			{
				if(r_PDefaultPrincipal == null)
				{
					r_PDefaultPrincipal = new(this, "DefaultPrincipal", -1);
				}
				return r_PDefaultPrincipal;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet GrantedPermissionSet
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPermissionSet r_PGrantedPermissionSet;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPermissionSet RPGrantedPermissionSet
		{
			get
			{
				if(r_PGrantedPermissionSet == null)
				{
					r_PGrantedPermissionSet = new(this, "GrantedPermissionSet", -1);
				}
				return r_PGrantedPermissionSet;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet PermissionSet
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPermissionSet r_PPermissionSet;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPermissionSet RPPermissionSet
		{
			get
			{
				if(r_PPermissionSet == null)
				{
					r_PPermissionSet = new(this, "PermissionSet", -1);
				}
				return r_PPermissionSet;
			}
		}

		/// <summary>
		/// System.AppDomain CurrentDomain
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RAppDomain r_PCurrentDomain;
		public static Hvak.Editor.Refleaction.RSystem.RAppDomain RPCurrentDomain
		{
			get
			{
				if(r_PCurrentDomain == null)
				{
					r_PCurrentDomain = new(Type, "CurrentDomain", -1);
				}
				return r_PCurrentDomain;
			}
		}

		/// <summary>
		/// System.AppDomain DefaultDomain
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RAppDomain r_PDefaultDomain;
		public static Hvak.Editor.Refleaction.RSystem.RAppDomain RPDefaultDomain
		{
			get
			{
				if(r_PDefaultDomain == null)
				{
					r_PDefaultDomain = new(Type, "DefaultDomain", -1);
				}
				return r_PDefaultDomain;
			}
		}

		/// <summary>
		/// Boolean IsHomogenous
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsHomogenous;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsHomogenous
		{
			get
			{
				if(r_PIsHomogenous == null)
				{
					r_PIsHomogenous = new(this, "IsHomogenous", -1);
				}
				return r_PIsHomogenous;
			}
		}

		/// <summary>
		/// Boolean IsFullyTrusted
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsFullyTrusted;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsFullyTrusted
		{
			get
			{
				if(r_PIsFullyTrusted == null)
				{
					r_PIsFullyTrusted = new(this, "IsFullyTrusted", -1);
				}
				return r_PIsFullyTrusted;
			}
		}

		/// <summary>
		/// System.AppDomainManager DomainManager
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAppDomainManager r_PDomainManager;
		public virtual Hvak.Editor.Refleaction.RSystem.RAppDomainManager RPDomainManager
		{
			get
			{
				if(r_PDomainManager == null)
				{
					r_PDomainManager = new(this, "DomainManager", -1);
				}
				return r_PDomainManager;
			}
		}

		/// <summary>
		/// System.ActivationContext ActivationContext
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RActivationContext r_PActivationContext;
		public virtual Hvak.Editor.Refleaction.RSystem.RActivationContext RPActivationContext
		{
			get
			{
				if(r_PActivationContext == null)
				{
					r_PActivationContext = new(this, "ActivationContext", -1);
				}
				return r_PActivationContext;
			}
		}

		/// <summary>
		/// System.ApplicationIdentity ApplicationIdentity
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RApplicationIdentity r_PApplicationIdentity;
		public virtual Hvak.Editor.Refleaction.RSystem.RApplicationIdentity RPApplicationIdentity
		{
			get
			{
				if(r_PApplicationIdentity == null)
				{
					r_PApplicationIdentity = new(this, "ApplicationIdentity", -1);
				}
				return r_PApplicationIdentity;
			}
		}

		/// <summary>
		/// Int32 Id
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PId;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPId
		{
			get
			{
				if(r_PId == null)
				{
					r_PId = new(this, "Id", -1);
				}
				return r_PId;
			}
		}

		/// <summary>
		/// Boolean MonitoringIsEnabled
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RBoolean r_PMonitoringIsEnabled;
		public static Hvak.Editor.Refleaction.RSystem.RBoolean RPMonitoringIsEnabled
		{
			get
			{
				if(r_PMonitoringIsEnabled == null)
				{
					r_PMonitoringIsEnabled = new(Type, "MonitoringIsEnabled", -1);
				}
				return r_PMonitoringIsEnabled;
			}
		}

		/// <summary>
		/// Int64 MonitoringSurvivedMemorySize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_PMonitoringSurvivedMemorySize;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RPMonitoringSurvivedMemorySize
		{
			get
			{
				if(r_PMonitoringSurvivedMemorySize == null)
				{
					r_PMonitoringSurvivedMemorySize = new(this, "MonitoringSurvivedMemorySize", -1);
				}
				return r_PMonitoringSurvivedMemorySize;
			}
		}

		/// <summary>
		/// Int64 MonitoringSurvivedProcessMemorySize
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt64 r_PMonitoringSurvivedProcessMemorySize;
		public static Hvak.Editor.Refleaction.RSystem.RInt64 RPMonitoringSurvivedProcessMemorySize
		{
			get
			{
				if(r_PMonitoringSurvivedProcessMemorySize == null)
				{
					r_PMonitoringSurvivedProcessMemorySize = new(Type, "MonitoringSurvivedProcessMemorySize", -1);
				}
				return r_PMonitoringSurvivedProcessMemorySize;
			}
		}

		/// <summary>
		/// Int64 MonitoringTotalAllocatedMemorySize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_PMonitoringTotalAllocatedMemorySize;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RPMonitoringTotalAllocatedMemorySize
		{
			get
			{
				if(r_PMonitoringTotalAllocatedMemorySize == null)
				{
					r_PMonitoringTotalAllocatedMemorySize = new(this, "MonitoringTotalAllocatedMemorySize", -1);
				}
				return r_PMonitoringTotalAllocatedMemorySize;
			}
		}

		/// <summary>
		/// System.TimeSpan MonitoringTotalProcessorTime
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RTimeSpan r_PMonitoringTotalProcessorTime;
		public virtual Hvak.Editor.Refleaction.RSystem.RTimeSpan RPMonitoringTotalProcessorTime
		{
			get
			{
				if(r_PMonitoringTotalProcessorTime == null)
				{
					r_PMonitoringTotalProcessorTime = new(this, "MonitoringTotalProcessorTime", -1);
				}
				return r_PMonitoringTotalProcessorTime;
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
		/// Boolean IsAppXModel()
		/// </summary>
		protected static RMethod r_MIsAppXModel;
		public static RMethod RMIsAppXModel
		{
			get
			{
				if(r_MIsAppXModel == null)
				{
					r_MIsAppXModel = new(Type, "IsAppXModel", 0);
				}
				return r_MIsAppXModel;
			}
		}

		/// <summary>
		/// Boolean IsAppXDesignMode()
		/// </summary>
		protected static RMethod r_MIsAppXDesignMode;
		public static RMethod RMIsAppXDesignMode
		{
			get
			{
				if(r_MIsAppXDesignMode == null)
				{
					r_MIsAppXDesignMode = new(Type, "IsAppXDesignMode", 0);
				}
				return r_MIsAppXDesignMode;
			}
		}

		/// <summary>
		/// Void CheckReflectionOnlyLoadSupported()
		/// </summary>
		protected static RMethod r_MCheckReflectionOnlyLoadSupported;
		public static RMethod RMCheckReflectionOnlyLoadSupported
		{
			get
			{
				if(r_MCheckReflectionOnlyLoadSupported == null)
				{
					r_MCheckReflectionOnlyLoadSupported = new(Type, "CheckReflectionOnlyLoadSupported", 0);
				}
				return r_MCheckReflectionOnlyLoadSupported;
			}
		}

		/// <summary>
		/// Void CheckLoadFromSupported()
		/// </summary>
		protected static RMethod r_MCheckLoadFromSupported;
		public static RMethod RMCheckLoadFromSupported
		{
			get
			{
				if(r_MCheckLoadFromSupported == null)
				{
					r_MCheckLoadFromSupported = new(Type, "CheckLoadFromSupported", 0);
				}
				return r_MCheckLoadFromSupported;
			}
		}

		/// <summary>
		/// System.AppDomainSetup getSetup()
		/// </summary>
		protected RMethod r_MgetSetup;
		public virtual RMethod RMgetSetup
		{
			get
			{
				if(r_MgetSetup == null)
				{
					r_MgetSetup = new(this, "getSetup", 0);
				}
				return r_MgetSetup;
			}
		}

		/// <summary>
		/// System.String getFriendlyName()
		/// </summary>
		protected RMethod r_MgetFriendlyName;
		public virtual RMethod RMgetFriendlyName
		{
			get
			{
				if(r_MgetFriendlyName == null)
				{
					r_MgetFriendlyName = new(this, "getFriendlyName", 0);
				}
				return r_MgetFriendlyName;
			}
		}

		/// <summary>
		/// System.AppDomain getCurDomain()
		/// </summary>
		protected static RMethod r_MgetCurDomain;
		public static RMethod RMgetCurDomain
		{
			get
			{
				if(r_MgetCurDomain == null)
				{
					r_MgetCurDomain = new(Type, "getCurDomain", 0);
				}
				return r_MgetCurDomain;
			}
		}

		/// <summary>
		/// System.AppDomain getRootDomain()
		/// </summary>
		protected static RMethod r_MgetRootDomain;
		public static RMethod RMgetRootDomain
		{
			get
			{
				if(r_MgetRootDomain == null)
				{
					r_MgetRootDomain = new(Type, "getRootDomain", 0);
				}
				return r_MgetRootDomain;
			}
		}

		/// <summary>
		/// Void AppendPrivatePath(System.String)
		/// </summary>
		protected RMethod r_MAppendPrivatePath_String;
		public virtual RMethod RMAppendPrivatePath_String
		{
			get
			{
				if(r_MAppendPrivatePath_String == null)
				{
					r_MAppendPrivatePath_String = new(this, "AppendPrivatePath", 0, typeof(System.String));
				}
				return r_MAppendPrivatePath_String;
			}
		}

		/// <summary>
		/// Void ClearPrivatePath()
		/// </summary>
		protected RMethod r_MClearPrivatePath;
		public virtual RMethod RMClearPrivatePath
		{
			get
			{
				if(r_MClearPrivatePath == null)
				{
					r_MClearPrivatePath = new(this, "ClearPrivatePath", 0);
				}
				return r_MClearPrivatePath;
			}
		}

		/// <summary>
		/// Void ClearShadowCopyPath()
		/// </summary>
		protected RMethod r_MClearShadowCopyPath;
		public virtual RMethod RMClearShadowCopyPath
		{
			get
			{
				if(r_MClearShadowCopyPath == null)
				{
					r_MClearShadowCopyPath = new(this, "ClearShadowCopyPath", 0);
				}
				return r_MClearShadowCopyPath;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle CreateComInstanceFrom(System.String, System.String)
		/// </summary>
		protected RMethod r_MCreateComInstanceFrom_String_String;
		public virtual RMethod RMCreateComInstanceFrom_String_String
		{
			get
			{
				if(r_MCreateComInstanceFrom_String_String == null)
				{
					r_MCreateComInstanceFrom_String_String = new(this, "CreateComInstanceFrom", 0, typeof(System.String), typeof(System.String));
				}
				return r_MCreateComInstanceFrom_String_String;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle CreateComInstanceFrom(System.String, System.String, Byte[], System.Configuration.Assemblies.AssemblyHashAlgorithm)
		/// </summary>
		protected RMethod r_MCreateComInstanceFrom_String_String_ByteArray_AssemblyHashAlgorithm;
		public virtual RMethod RMCreateComInstanceFrom_String_String_ByteArray_AssemblyHashAlgorithm
		{
			get
			{
				if(r_MCreateComInstanceFrom_String_String_ByteArray_AssemblyHashAlgorithm == null)
				{
					r_MCreateComInstanceFrom_String_String_ByteArray_AssemblyHashAlgorithm = new(this, "CreateComInstanceFrom", 0, typeof(System.String), typeof(System.String), typeof(System.Byte).MakeArrayType(), typeof(System.Configuration.Assemblies.AssemblyHashAlgorithm));
				}
				return r_MCreateComInstanceFrom_String_String_ByteArray_AssemblyHashAlgorithm;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle InternalCreateInstanceWithNoSecurity(System.String, System.String)
		/// </summary>
		protected RMethod r_MInternalCreateInstanceWithNoSecurity_String_String;
		public virtual RMethod RMInternalCreateInstanceWithNoSecurity_String_String
		{
			get
			{
				if(r_MInternalCreateInstanceWithNoSecurity_String_String == null)
				{
					r_MInternalCreateInstanceWithNoSecurity_String_String = new(this, "InternalCreateInstanceWithNoSecurity", 0, typeof(System.String), typeof(System.String));
				}
				return r_MInternalCreateInstanceWithNoSecurity_String_String;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle InternalCreateInstanceWithNoSecurity(System.String, System.String, Boolean, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo, System.Object[], System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_MInternalCreateInstanceWithNoSecurity_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence;
		public virtual RMethod RMInternalCreateInstanceWithNoSecurity_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence
		{
			get
			{
				if(r_MInternalCreateInstanceWithNoSecurity_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence == null)
				{
					r_MInternalCreateInstanceWithNoSecurity_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence = new(this, "InternalCreateInstanceWithNoSecurity", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.Object).MakeArrayType(), typeof(System.Security.Policy.Evidence));
				}
				return r_MInternalCreateInstanceWithNoSecurity_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle InternalCreateInstanceFromWithNoSecurity(System.String, System.String)
		/// </summary>
		protected RMethod r_MInternalCreateInstanceFromWithNoSecurity_String_String;
		public virtual RMethod RMInternalCreateInstanceFromWithNoSecurity_String_String
		{
			get
			{
				if(r_MInternalCreateInstanceFromWithNoSecurity_String_String == null)
				{
					r_MInternalCreateInstanceFromWithNoSecurity_String_String = new(this, "InternalCreateInstanceFromWithNoSecurity", 0, typeof(System.String), typeof(System.String));
				}
				return r_MInternalCreateInstanceFromWithNoSecurity_String_String;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle InternalCreateInstanceFromWithNoSecurity(System.String, System.String, Boolean, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo, System.Object[], System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_MInternalCreateInstanceFromWithNoSecurity_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence;
		public virtual RMethod RMInternalCreateInstanceFromWithNoSecurity_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence
		{
			get
			{
				if(r_MInternalCreateInstanceFromWithNoSecurity_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence == null)
				{
					r_MInternalCreateInstanceFromWithNoSecurity_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence = new(this, "InternalCreateInstanceFromWithNoSecurity", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.Object).MakeArrayType(), typeof(System.Security.Policy.Evidence));
				}
				return r_MInternalCreateInstanceFromWithNoSecurity_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle CreateInstance(System.String, System.String)
		/// </summary>
		protected RMethod r_MCreateInstance_String_String;
		public virtual RMethod RMCreateInstance_String_String
		{
			get
			{
				if(r_MCreateInstance_String_String == null)
				{
					r_MCreateInstance_String_String = new(this, "CreateInstance", 0, typeof(System.String), typeof(System.String));
				}
				return r_MCreateInstance_String_String;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle CreateInstance(System.String, System.String, System.Object[])
		/// </summary>
		protected RMethod r_MCreateInstance_String_String_ObjectArray;
		public virtual RMethod RMCreateInstance_String_String_ObjectArray
		{
			get
			{
				if(r_MCreateInstance_String_String_ObjectArray == null)
				{
					r_MCreateInstance_String_String_ObjectArray = new(this, "CreateInstance", 0, typeof(System.String), typeof(System.String), typeof(System.Object).MakeArrayType());
				}
				return r_MCreateInstance_String_String_ObjectArray;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle CreateInstance(System.String, System.String, Boolean, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo, System.Object[], System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_MCreateInstance_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence;
		public virtual RMethod RMCreateInstance_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence
		{
			get
			{
				if(r_MCreateInstance_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence == null)
				{
					r_MCreateInstance_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence = new(this, "CreateInstance", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.Object).MakeArrayType(), typeof(System.Security.Policy.Evidence));
				}
				return r_MCreateInstance_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence;
			}
		}

		/// <summary>
		/// System.Object CreateInstanceAndUnwrap(System.String, System.String)
		/// </summary>
		protected RMethod r_MCreateInstanceAndUnwrap_String_String;
		public virtual RMethod RMCreateInstanceAndUnwrap_String_String
		{
			get
			{
				if(r_MCreateInstanceAndUnwrap_String_String == null)
				{
					r_MCreateInstanceAndUnwrap_String_String = new(this, "CreateInstanceAndUnwrap", 0, typeof(System.String), typeof(System.String));
				}
				return r_MCreateInstanceAndUnwrap_String_String;
			}
		}

		/// <summary>
		/// System.Object CreateInstanceAndUnwrap(System.String, System.String, System.Object[])
		/// </summary>
		protected RMethod r_MCreateInstanceAndUnwrap_String_String_ObjectArray;
		public virtual RMethod RMCreateInstanceAndUnwrap_String_String_ObjectArray
		{
			get
			{
				if(r_MCreateInstanceAndUnwrap_String_String_ObjectArray == null)
				{
					r_MCreateInstanceAndUnwrap_String_String_ObjectArray = new(this, "CreateInstanceAndUnwrap", 0, typeof(System.String), typeof(System.String), typeof(System.Object).MakeArrayType());
				}
				return r_MCreateInstanceAndUnwrap_String_String_ObjectArray;
			}
		}

		/// <summary>
		/// System.Object CreateInstanceAndUnwrap(System.String, System.String, Boolean, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo, System.Object[], System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_MCreateInstanceAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence;
		public virtual RMethod RMCreateInstanceAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence
		{
			get
			{
				if(r_MCreateInstanceAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence == null)
				{
					r_MCreateInstanceAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence = new(this, "CreateInstanceAndUnwrap", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.Object).MakeArrayType(), typeof(System.Security.Policy.Evidence));
				}
				return r_MCreateInstanceAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle CreateInstance(System.String, System.String, Boolean, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo, System.Object[])
		/// </summary>
		protected RMethod r_MCreateInstance_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray;
		public virtual RMethod RMCreateInstance_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray
		{
			get
			{
				if(r_MCreateInstance_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray == null)
				{
					r_MCreateInstance_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray = new(this, "CreateInstance", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.Object).MakeArrayType());
				}
				return r_MCreateInstance_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray;
			}
		}

		/// <summary>
		/// System.Object CreateInstanceAndUnwrap(System.String, System.String, Boolean, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo, System.Object[])
		/// </summary>
		protected RMethod r_MCreateInstanceAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray;
		public virtual RMethod RMCreateInstanceAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray
		{
			get
			{
				if(r_MCreateInstanceAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray == null)
				{
					r_MCreateInstanceAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray = new(this, "CreateInstanceAndUnwrap", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.Object).MakeArrayType());
				}
				return r_MCreateInstanceAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(System.String, System.String, Boolean, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo, System.Object[])
		/// </summary>
		protected RMethod r_MCreateInstanceFrom_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray;
		public virtual RMethod RMCreateInstanceFrom_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray
		{
			get
			{
				if(r_MCreateInstanceFrom_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray == null)
				{
					r_MCreateInstanceFrom_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray = new(this, "CreateInstanceFrom", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.Object).MakeArrayType());
				}
				return r_MCreateInstanceFrom_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray;
			}
		}

		/// <summary>
		/// System.Object CreateInstanceFromAndUnwrap(System.String, System.String, Boolean, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo, System.Object[])
		/// </summary>
		protected RMethod r_MCreateInstanceFromAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray;
		public virtual RMethod RMCreateInstanceFromAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray
		{
			get
			{
				if(r_MCreateInstanceFromAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray == null)
				{
					r_MCreateInstanceFromAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray = new(this, "CreateInstanceFromAndUnwrap", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.Object).MakeArrayType());
				}
				return r_MCreateInstanceFromAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(System.String, System.String)
		/// </summary>
		protected RMethod r_MCreateInstanceFrom_String_String;
		public virtual RMethod RMCreateInstanceFrom_String_String
		{
			get
			{
				if(r_MCreateInstanceFrom_String_String == null)
				{
					r_MCreateInstanceFrom_String_String = new(this, "CreateInstanceFrom", 0, typeof(System.String), typeof(System.String));
				}
				return r_MCreateInstanceFrom_String_String;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(System.String, System.String, System.Object[])
		/// </summary>
		protected RMethod r_MCreateInstanceFrom_String_String_ObjectArray;
		public virtual RMethod RMCreateInstanceFrom_String_String_ObjectArray
		{
			get
			{
				if(r_MCreateInstanceFrom_String_String_ObjectArray == null)
				{
					r_MCreateInstanceFrom_String_String_ObjectArray = new(this, "CreateInstanceFrom", 0, typeof(System.String), typeof(System.String), typeof(System.Object).MakeArrayType());
				}
				return r_MCreateInstanceFrom_String_String_ObjectArray;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(System.String, System.String, Boolean, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo, System.Object[], System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_MCreateInstanceFrom_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence;
		public virtual RMethod RMCreateInstanceFrom_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence
		{
			get
			{
				if(r_MCreateInstanceFrom_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence == null)
				{
					r_MCreateInstanceFrom_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence = new(this, "CreateInstanceFrom", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.Object).MakeArrayType(), typeof(System.Security.Policy.Evidence));
				}
				return r_MCreateInstanceFrom_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence;
			}
		}

		/// <summary>
		/// System.Object CreateInstanceFromAndUnwrap(System.String, System.String)
		/// </summary>
		protected RMethod r_MCreateInstanceFromAndUnwrap_String_String;
		public virtual RMethod RMCreateInstanceFromAndUnwrap_String_String
		{
			get
			{
				if(r_MCreateInstanceFromAndUnwrap_String_String == null)
				{
					r_MCreateInstanceFromAndUnwrap_String_String = new(this, "CreateInstanceFromAndUnwrap", 0, typeof(System.String), typeof(System.String));
				}
				return r_MCreateInstanceFromAndUnwrap_String_String;
			}
		}

		/// <summary>
		/// System.Object CreateInstanceFromAndUnwrap(System.String, System.String, System.Object[])
		/// </summary>
		protected RMethod r_MCreateInstanceFromAndUnwrap_String_String_ObjectArray;
		public virtual RMethod RMCreateInstanceFromAndUnwrap_String_String_ObjectArray
		{
			get
			{
				if(r_MCreateInstanceFromAndUnwrap_String_String_ObjectArray == null)
				{
					r_MCreateInstanceFromAndUnwrap_String_String_ObjectArray = new(this, "CreateInstanceFromAndUnwrap", 0, typeof(System.String), typeof(System.String), typeof(System.Object).MakeArrayType());
				}
				return r_MCreateInstanceFromAndUnwrap_String_String_ObjectArray;
			}
		}

		/// <summary>
		/// System.Object CreateInstanceFromAndUnwrap(System.String, System.String, Boolean, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo, System.Object[], System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_MCreateInstanceFromAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence;
		public virtual RMethod RMCreateInstanceFromAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence
		{
			get
			{
				if(r_MCreateInstanceFromAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence == null)
				{
					r_MCreateInstanceFromAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence = new(this, "CreateInstanceFromAndUnwrap", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.Object).MakeArrayType(), typeof(System.Security.Policy.Evidence));
				}
				return r_MCreateInstanceFromAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName, System.Reflection.Emit.AssemblyBuilderAccess)
		/// </summary>
		protected RMethod r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess;
		public virtual RMethod RMDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess
		{
			get
			{
				if(r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess == null)
				{
					r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess = new(this, "DefineDynamicAssembly", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.AssemblyBuilderAccess));
				}
				return r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName, System.Reflection.Emit.AssemblyBuilderAccess, System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_Evidence;
		public virtual RMethod RMDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_Evidence
		{
			get
			{
				if(r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_Evidence == null)
				{
					r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_Evidence = new(this, "DefineDynamicAssembly", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.AssemblyBuilderAccess), typeof(System.Security.Policy.Evidence));
				}
				return r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_Evidence;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName, System.Reflection.Emit.AssemblyBuilderAccess, System.String)
		/// </summary>
		protected RMethod r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String;
		public virtual RMethod RMDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String
		{
			get
			{
				if(r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String == null)
				{
					r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String = new(this, "DefineDynamicAssembly", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.AssemblyBuilderAccess), typeof(System.String));
				}
				return r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName, System.Reflection.Emit.AssemblyBuilderAccess, System.String, System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence;
		public virtual RMethod RMDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence
		{
			get
			{
				if(r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence == null)
				{
					r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence = new(this, "DefineDynamicAssembly", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.AssemblyBuilderAccess), typeof(System.String), typeof(System.Security.Policy.Evidence));
				}
				return r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName, System.Reflection.Emit.AssemblyBuilderAccess, System.Security.PermissionSet, System.Security.PermissionSet, System.Security.PermissionSet)
		/// </summary>
		protected RMethod r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_PermissionSet_PermissionSet_PermissionSet;
		public virtual RMethod RMDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_PermissionSet_PermissionSet_PermissionSet
		{
			get
			{
				if(r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_PermissionSet_PermissionSet_PermissionSet == null)
				{
					r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_PermissionSet_PermissionSet_PermissionSet = new(this, "DefineDynamicAssembly", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.AssemblyBuilderAccess), typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet));
				}
				return r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_PermissionSet_PermissionSet_PermissionSet;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName, System.Reflection.Emit.AssemblyBuilderAccess, System.Security.Policy.Evidence, System.Security.PermissionSet, System.Security.PermissionSet, System.Security.PermissionSet)
		/// </summary>
		protected RMethod r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_Evidence_PermissionSet_PermissionSet_PermissionSet;
		public virtual RMethod RMDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_Evidence_PermissionSet_PermissionSet_PermissionSet
		{
			get
			{
				if(r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_Evidence_PermissionSet_PermissionSet_PermissionSet == null)
				{
					r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_Evidence_PermissionSet_PermissionSet_PermissionSet = new(this, "DefineDynamicAssembly", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.AssemblyBuilderAccess), typeof(System.Security.Policy.Evidence), typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet));
				}
				return r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_Evidence_PermissionSet_PermissionSet_PermissionSet;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName, System.Reflection.Emit.AssemblyBuilderAccess, System.String, System.Security.PermissionSet, System.Security.PermissionSet, System.Security.PermissionSet)
		/// </summary>
		protected RMethod r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_PermissionSet_PermissionSet_PermissionSet;
		public virtual RMethod RMDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_PermissionSet_PermissionSet_PermissionSet
		{
			get
			{
				if(r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_PermissionSet_PermissionSet_PermissionSet == null)
				{
					r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_PermissionSet_PermissionSet_PermissionSet = new(this, "DefineDynamicAssembly", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.AssemblyBuilderAccess), typeof(System.String), typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet));
				}
				return r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_PermissionSet_PermissionSet_PermissionSet;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName, System.Reflection.Emit.AssemblyBuilderAccess, System.String, System.Security.Policy.Evidence, System.Security.PermissionSet, System.Security.PermissionSet, System.Security.PermissionSet)
		/// </summary>
		protected RMethod r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet;
		public virtual RMethod RMDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet
		{
			get
			{
				if(r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet == null)
				{
					r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet = new(this, "DefineDynamicAssembly", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.AssemblyBuilderAccess), typeof(System.String), typeof(System.Security.Policy.Evidence), typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet));
				}
				return r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName, System.Reflection.Emit.AssemblyBuilderAccess, System.String, System.Security.Policy.Evidence, System.Security.PermissionSet, System.Security.PermissionSet, System.Security.PermissionSet, Boolean)
		/// </summary>
		protected RMethod r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet_Boolean;
		public virtual RMethod RMDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet_Boolean
		{
			get
			{
				if(r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet_Boolean == null)
				{
					r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet_Boolean = new(this, "DefineDynamicAssembly", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.AssemblyBuilderAccess), typeof(System.String), typeof(System.Security.Policy.Evidence), typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet), typeof(System.Boolean));
				}
				return r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName, System.Reflection.Emit.AssemblyBuilderAccess, System.String, System.Security.Policy.Evidence, System.Security.PermissionSet, System.Security.PermissionSet, System.Security.PermissionSet, Boolean, System.Collections.Generic.IEnumerable`1[System.Reflection.Emit.CustomAttributeBuilder])
		/// </summary>
		protected RMethod r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet_Boolean_IEnumerable_d_CustomAttributeBuilder_p_;
		public virtual RMethod RMDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet_Boolean_IEnumerable_d_CustomAttributeBuilder_p_
		{
			get
			{
				if(r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet_Boolean_IEnumerable_d_CustomAttributeBuilder_p_ == null)
				{
					r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet_Boolean_IEnumerable_d_CustomAttributeBuilder_p_ = new(this, "DefineDynamicAssembly", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.AssemblyBuilderAccess), typeof(System.String), typeof(System.Security.Policy.Evidence), typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet), typeof(System.Boolean),  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType(typeof(System.Reflection.Emit.CustomAttributeBuilder)));
				}
				return r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet_Boolean_IEnumerable_d_CustomAttributeBuilder_p_;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName, System.Reflection.Emit.AssemblyBuilderAccess, System.Collections.Generic.IEnumerable`1[System.Reflection.Emit.CustomAttributeBuilder])
		/// </summary>
		protected RMethod r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p_;
		public virtual RMethod RMDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p_
		{
			get
			{
				if(r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p_ == null)
				{
					r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p_ = new(this, "DefineDynamicAssembly", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.AssemblyBuilderAccess),  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType(typeof(System.Reflection.Emit.CustomAttributeBuilder)));
				}
				return r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p_;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName, System.Reflection.Emit.AssemblyBuilderAccess, System.String, Boolean, System.Collections.Generic.IEnumerable`1[System.Reflection.Emit.CustomAttributeBuilder])
		/// </summary>
		protected RMethod r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Boolean_IEnumerable_d_CustomAttributeBuilder_p_;
		public virtual RMethod RMDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Boolean_IEnumerable_d_CustomAttributeBuilder_p_
		{
			get
			{
				if(r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Boolean_IEnumerable_d_CustomAttributeBuilder_p_ == null)
				{
					r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Boolean_IEnumerable_d_CustomAttributeBuilder_p_ = new(this, "DefineDynamicAssembly", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.AssemblyBuilderAccess), typeof(System.String), typeof(System.Boolean),  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType(typeof(System.Reflection.Emit.CustomAttributeBuilder)));
				}
				return r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Boolean_IEnumerable_d_CustomAttributeBuilder_p_;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName, System.Reflection.Emit.AssemblyBuilderAccess, System.Collections.Generic.IEnumerable`1[System.Reflection.Emit.CustomAttributeBuilder], System.Security.SecurityContextSource)
		/// </summary>
		protected RMethod r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p__SecurityContextSource;
		public virtual RMethod RMDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p__SecurityContextSource
		{
			get
			{
				if(r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p__SecurityContextSource == null)
				{
					r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p__SecurityContextSource = new(this, "DefineDynamicAssembly", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.AssemblyBuilderAccess),  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType(typeof(System.Reflection.Emit.CustomAttributeBuilder)), typeof(System.Security.SecurityContextSource));
				}
				return r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p__SecurityContextSource;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder DefineInternalDynamicAssembly(System.Reflection.AssemblyName, System.Reflection.Emit.AssemblyBuilderAccess)
		/// </summary>
		protected RMethod r_MDefineInternalDynamicAssembly_AssemblyName_AssemblyBuilderAccess;
		public virtual RMethod RMDefineInternalDynamicAssembly_AssemblyName_AssemblyBuilderAccess
		{
			get
			{
				if(r_MDefineInternalDynamicAssembly_AssemblyName_AssemblyBuilderAccess == null)
				{
					r_MDefineInternalDynamicAssembly_AssemblyName_AssemblyBuilderAccess = new(this, "DefineInternalDynamicAssembly", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.AssemblyBuilderAccess));
				}
				return r_MDefineInternalDynamicAssembly_AssemblyName_AssemblyBuilderAccess;
			}
		}

		/// <summary>
		/// Void DoCallBack(System.CrossAppDomainDelegate)
		/// </summary>
		protected RMethod r_MDoCallBack_CrossAppDomainDelegate;
		public virtual RMethod RMDoCallBack_CrossAppDomainDelegate
		{
			get
			{
				if(r_MDoCallBack_CrossAppDomainDelegate == null)
				{
					r_MDoCallBack_CrossAppDomainDelegate = new(this, "DoCallBack", 0, typeof(System.CrossAppDomainDelegate));
				}
				return r_MDoCallBack_CrossAppDomainDelegate;
			}
		}

		/// <summary>
		/// Int32 ExecuteAssembly(System.String)
		/// </summary>
		protected RMethod r_MExecuteAssembly_String;
		public virtual RMethod RMExecuteAssembly_String
		{
			get
			{
				if(r_MExecuteAssembly_String == null)
				{
					r_MExecuteAssembly_String = new(this, "ExecuteAssembly", 0, typeof(System.String));
				}
				return r_MExecuteAssembly_String;
			}
		}

		/// <summary>
		/// Int32 ExecuteAssembly(System.String, System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_MExecuteAssembly_String_Evidence;
		public virtual RMethod RMExecuteAssembly_String_Evidence
		{
			get
			{
				if(r_MExecuteAssembly_String_Evidence == null)
				{
					r_MExecuteAssembly_String_Evidence = new(this, "ExecuteAssembly", 0, typeof(System.String), typeof(System.Security.Policy.Evidence));
				}
				return r_MExecuteAssembly_String_Evidence;
			}
		}

		/// <summary>
		/// Int32 ExecuteAssembly(System.String, System.Security.Policy.Evidence, System.String[])
		/// </summary>
		protected RMethod r_MExecuteAssembly_String_Evidence_StringArray;
		public virtual RMethod RMExecuteAssembly_String_Evidence_StringArray
		{
			get
			{
				if(r_MExecuteAssembly_String_Evidence_StringArray == null)
				{
					r_MExecuteAssembly_String_Evidence_StringArray = new(this, "ExecuteAssembly", 0, typeof(System.String), typeof(System.Security.Policy.Evidence), typeof(System.String).MakeArrayType());
				}
				return r_MExecuteAssembly_String_Evidence_StringArray;
			}
		}

		/// <summary>
		/// Int32 ExecuteAssembly(System.String, System.Security.Policy.Evidence, System.String[], Byte[], System.Configuration.Assemblies.AssemblyHashAlgorithm)
		/// </summary>
		protected RMethod r_MExecuteAssembly_String_Evidence_StringArray_ByteArray_AssemblyHashAlgorithm;
		public virtual RMethod RMExecuteAssembly_String_Evidence_StringArray_ByteArray_AssemblyHashAlgorithm
		{
			get
			{
				if(r_MExecuteAssembly_String_Evidence_StringArray_ByteArray_AssemblyHashAlgorithm == null)
				{
					r_MExecuteAssembly_String_Evidence_StringArray_ByteArray_AssemblyHashAlgorithm = new(this, "ExecuteAssembly", 0, typeof(System.String), typeof(System.Security.Policy.Evidence), typeof(System.String).MakeArrayType(), typeof(System.Byte).MakeArrayType(), typeof(System.Configuration.Assemblies.AssemblyHashAlgorithm));
				}
				return r_MExecuteAssembly_String_Evidence_StringArray_ByteArray_AssemblyHashAlgorithm;
			}
		}

		/// <summary>
		/// Int32 ExecuteAssembly(System.String, System.String[])
		/// </summary>
		protected RMethod r_MExecuteAssembly_String_StringArray;
		public virtual RMethod RMExecuteAssembly_String_StringArray
		{
			get
			{
				if(r_MExecuteAssembly_String_StringArray == null)
				{
					r_MExecuteAssembly_String_StringArray = new(this, "ExecuteAssembly", 0, typeof(System.String), typeof(System.String).MakeArrayType());
				}
				return r_MExecuteAssembly_String_StringArray;
			}
		}

		/// <summary>
		/// Int32 ExecuteAssembly(System.String, System.String[], Byte[], System.Configuration.Assemblies.AssemblyHashAlgorithm)
		/// </summary>
		protected RMethod r_MExecuteAssembly_String_StringArray_ByteArray_AssemblyHashAlgorithm;
		public virtual RMethod RMExecuteAssembly_String_StringArray_ByteArray_AssemblyHashAlgorithm
		{
			get
			{
				if(r_MExecuteAssembly_String_StringArray_ByteArray_AssemblyHashAlgorithm == null)
				{
					r_MExecuteAssembly_String_StringArray_ByteArray_AssemblyHashAlgorithm = new(this, "ExecuteAssembly", 0, typeof(System.String), typeof(System.String).MakeArrayType(), typeof(System.Byte).MakeArrayType(), typeof(System.Configuration.Assemblies.AssemblyHashAlgorithm));
				}
				return r_MExecuteAssembly_String_StringArray_ByteArray_AssemblyHashAlgorithm;
			}
		}

		/// <summary>
		/// Int32 ExecuteAssemblyInternal(System.Reflection.Assembly, System.String[])
		/// </summary>
		protected RMethod r_MExecuteAssemblyInternal_Assembly_StringArray;
		public virtual RMethod RMExecuteAssemblyInternal_Assembly_StringArray
		{
			get
			{
				if(r_MExecuteAssemblyInternal_Assembly_StringArray == null)
				{
					r_MExecuteAssemblyInternal_Assembly_StringArray = new(this, "ExecuteAssemblyInternal", 0, typeof(System.Reflection.Assembly), typeof(System.String).MakeArrayType());
				}
				return r_MExecuteAssemblyInternal_Assembly_StringArray;
			}
		}

		/// <summary>
		/// Int32 ExecuteAssembly(System.Reflection.Assembly, System.String[])
		/// </summary>
		protected RMethod r_MExecuteAssembly_Assembly_StringArray;
		public virtual RMethod RMExecuteAssembly_Assembly_StringArray
		{
			get
			{
				if(r_MExecuteAssembly_Assembly_StringArray == null)
				{
					r_MExecuteAssembly_Assembly_StringArray = new(this, "ExecuteAssembly", 0, typeof(System.Reflection.Assembly), typeof(System.String).MakeArrayType());
				}
				return r_MExecuteAssembly_Assembly_StringArray;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly[] GetAssemblies(Boolean)
		/// </summary>
		protected RMethod r_MGetAssemblies_Boolean;
		public virtual RMethod RMGetAssemblies_Boolean
		{
			get
			{
				if(r_MGetAssemblies_Boolean == null)
				{
					r_MGetAssemblies_Boolean = new(this, "GetAssemblies", 0, typeof(System.Boolean));
				}
				return r_MGetAssemblies_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly[] GetAssemblies()
		/// </summary>
		protected RMethod r_MGetAssemblies;
		public virtual RMethod RMGetAssemblies
		{
			get
			{
				if(r_MGetAssemblies == null)
				{
					r_MGetAssemblies = new(this, "GetAssemblies", 0);
				}
				return r_MGetAssemblies;
			}
		}

		/// <summary>
		/// System.Object GetData(System.String)
		/// </summary>
		protected RMethod r_MGetData_String;
		public virtual RMethod RMGetData_String
		{
			get
			{
				if(r_MGetData_String == null)
				{
					r_MGetData_String = new(this, "GetData", 0, typeof(System.String));
				}
				return r_MGetData_String;
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
		/// System.Reflection.Assembly LoadAssembly(System.String, System.Security.Policy.Evidence, Boolean, System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected RMethod r_MLoadAssembly_String_Evidence_Boolean_Ref_StackCrawlMark;
		public virtual RMethod RMLoadAssembly_String_Evidence_Boolean_Ref_StackCrawlMark
		{
			get
			{
				if(r_MLoadAssembly_String_Evidence_Boolean_Ref_StackCrawlMark == null)
				{
					r_MLoadAssembly_String_Evidence_Boolean_Ref_StackCrawlMark = new(this, "LoadAssembly", 0, typeof(System.String), typeof(System.Security.Policy.Evidence), typeof(System.Boolean),  ReflectionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
				}
				return r_MLoadAssembly_String_Evidence_Boolean_Ref_StackCrawlMark;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(System.Reflection.AssemblyName)
		/// </summary>
		protected RMethod r_MLoad_AssemblyName;
		public virtual RMethod RMLoad_AssemblyName
		{
			get
			{
				if(r_MLoad_AssemblyName == null)
				{
					r_MLoad_AssemblyName = new(this, "Load", 0, typeof(System.Reflection.AssemblyName));
				}
				return r_MLoad_AssemblyName;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly LoadSatellite(System.Reflection.AssemblyName, Boolean, System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected RMethod r_MLoadSatellite_AssemblyName_Boolean_Ref_StackCrawlMark;
		public virtual RMethod RMLoadSatellite_AssemblyName_Boolean_Ref_StackCrawlMark
		{
			get
			{
				if(r_MLoadSatellite_AssemblyName_Boolean_Ref_StackCrawlMark == null)
				{
					r_MLoadSatellite_AssemblyName_Boolean_Ref_StackCrawlMark = new(this, "LoadSatellite", 0, typeof(System.Reflection.AssemblyName), typeof(System.Boolean),  ReflectionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
				}
				return r_MLoadSatellite_AssemblyName_Boolean_Ref_StackCrawlMark;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(System.Reflection.AssemblyName, System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_MLoad_AssemblyName_Evidence;
		public virtual RMethod RMLoad_AssemblyName_Evidence
		{
			get
			{
				if(r_MLoad_AssemblyName_Evidence == null)
				{
					r_MLoad_AssemblyName_Evidence = new(this, "Load", 0, typeof(System.Reflection.AssemblyName), typeof(System.Security.Policy.Evidence));
				}
				return r_MLoad_AssemblyName_Evidence;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(System.String)
		/// </summary>
		protected RMethod r_MLoad_String;
		public virtual RMethod RMLoad_String
		{
			get
			{
				if(r_MLoad_String == null)
				{
					r_MLoad_String = new(this, "Load", 0, typeof(System.String));
				}
				return r_MLoad_String;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(System.String, System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_MLoad_String_Evidence;
		public virtual RMethod RMLoad_String_Evidence
		{
			get
			{
				if(r_MLoad_String_Evidence == null)
				{
					r_MLoad_String_Evidence = new(this, "Load", 0, typeof(System.String), typeof(System.Security.Policy.Evidence));
				}
				return r_MLoad_String_Evidence;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(System.String, System.Security.Policy.Evidence, Boolean, System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected RMethod r_MLoad_String_Evidence_Boolean_Ref_StackCrawlMark;
		public virtual RMethod RMLoad_String_Evidence_Boolean_Ref_StackCrawlMark
		{
			get
			{
				if(r_MLoad_String_Evidence_Boolean_Ref_StackCrawlMark == null)
				{
					r_MLoad_String_Evidence_Boolean_Ref_StackCrawlMark = new(this, "Load", 0, typeof(System.String), typeof(System.Security.Policy.Evidence), typeof(System.Boolean),  ReflectionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
				}
				return r_MLoad_String_Evidence_Boolean_Ref_StackCrawlMark;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(Byte[])
		/// </summary>
		protected RMethod r_MLoad_ByteArray;
		public virtual RMethod RMLoad_ByteArray
		{
			get
			{
				if(r_MLoad_ByteArray == null)
				{
					r_MLoad_ByteArray = new(this, "Load", 0, typeof(System.Byte).MakeArrayType());
				}
				return r_MLoad_ByteArray;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(Byte[], Byte[])
		/// </summary>
		protected RMethod r_MLoad_ByteArray_ByteArray;
		public virtual RMethod RMLoad_ByteArray_ByteArray
		{
			get
			{
				if(r_MLoad_ByteArray_ByteArray == null)
				{
					r_MLoad_ByteArray_ByteArray = new(this, "Load", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType());
				}
				return r_MLoad_ByteArray_ByteArray;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly LoadAssemblyRaw(Byte[], Byte[], System.Security.Policy.Evidence, Boolean)
		/// </summary>
		protected RMethod r_MLoadAssemblyRaw_ByteArray_ByteArray_Evidence_Boolean;
		public virtual RMethod RMLoadAssemblyRaw_ByteArray_ByteArray_Evidence_Boolean
		{
			get
			{
				if(r_MLoadAssemblyRaw_ByteArray_ByteArray_Evidence_Boolean == null)
				{
					r_MLoadAssemblyRaw_ByteArray_ByteArray_Evidence_Boolean = new(this, "LoadAssemblyRaw", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType(), typeof(System.Security.Policy.Evidence), typeof(System.Boolean));
				}
				return r_MLoadAssemblyRaw_ByteArray_ByteArray_Evidence_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(Byte[], Byte[], System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_MLoad_ByteArray_ByteArray_Evidence;
		public virtual RMethod RMLoad_ByteArray_ByteArray_Evidence
		{
			get
			{
				if(r_MLoad_ByteArray_ByteArray_Evidence == null)
				{
					r_MLoad_ByteArray_ByteArray_Evidence = new(this, "Load", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType(), typeof(System.Security.Policy.Evidence));
				}
				return r_MLoad_ByteArray_ByteArray_Evidence;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(Byte[], Byte[], System.Security.Policy.Evidence, Boolean)
		/// </summary>
		protected RMethod r_MLoad_ByteArray_ByteArray_Evidence_Boolean;
		public virtual RMethod RMLoad_ByteArray_ByteArray_Evidence_Boolean
		{
			get
			{
				if(r_MLoad_ByteArray_ByteArray_Evidence_Boolean == null)
				{
					r_MLoad_ByteArray_ByteArray_Evidence_Boolean = new(this, "Load", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType(), typeof(System.Security.Policy.Evidence), typeof(System.Boolean));
				}
				return r_MLoad_ByteArray_ByteArray_Evidence_Boolean;
			}
		}

		/// <summary>
		/// Void SetAppDomainPolicy(System.Security.Policy.PolicyLevel)
		/// </summary>
		protected RMethod r_MSetAppDomainPolicy_PolicyLevel;
		public virtual RMethod RMSetAppDomainPolicy_PolicyLevel
		{
			get
			{
				if(r_MSetAppDomainPolicy_PolicyLevel == null)
				{
					r_MSetAppDomainPolicy_PolicyLevel = new(this, "SetAppDomainPolicy", 0, typeof(System.Security.Policy.PolicyLevel));
				}
				return r_MSetAppDomainPolicy_PolicyLevel;
			}
		}

		/// <summary>
		/// Void SetCachePath(System.String)
		/// </summary>
		protected RMethod r_MSetCachePath_String;
		public virtual RMethod RMSetCachePath_String
		{
			get
			{
				if(r_MSetCachePath_String == null)
				{
					r_MSetCachePath_String = new(this, "SetCachePath", 0, typeof(System.String));
				}
				return r_MSetCachePath_String;
			}
		}

		/// <summary>
		/// Void SetPrincipalPolicy(System.Security.Principal.PrincipalPolicy)
		/// </summary>
		protected RMethod r_MSetPrincipalPolicy_PrincipalPolicy;
		public virtual RMethod RMSetPrincipalPolicy_PrincipalPolicy
		{
			get
			{
				if(r_MSetPrincipalPolicy_PrincipalPolicy == null)
				{
					r_MSetPrincipalPolicy_PrincipalPolicy = new(this, "SetPrincipalPolicy", 0, typeof(System.Security.Principal.PrincipalPolicy));
				}
				return r_MSetPrincipalPolicy_PrincipalPolicy;
			}
		}

		/// <summary>
		/// Void SetShadowCopyFiles()
		/// </summary>
		protected RMethod r_MSetShadowCopyFiles;
		public virtual RMethod RMSetShadowCopyFiles
		{
			get
			{
				if(r_MSetShadowCopyFiles == null)
				{
					r_MSetShadowCopyFiles = new(this, "SetShadowCopyFiles", 0);
				}
				return r_MSetShadowCopyFiles;
			}
		}

		/// <summary>
		/// Void SetShadowCopyPath(System.String)
		/// </summary>
		protected RMethod r_MSetShadowCopyPath_String;
		public virtual RMethod RMSetShadowCopyPath_String
		{
			get
			{
				if(r_MSetShadowCopyPath_String == null)
				{
					r_MSetShadowCopyPath_String = new(this, "SetShadowCopyPath", 0, typeof(System.String));
				}
				return r_MSetShadowCopyPath_String;
			}
		}

		/// <summary>
		/// Void SetThreadPrincipal(System.Security.Principal.IPrincipal)
		/// </summary>
		protected RMethod r_MSetThreadPrincipal_IPrincipal;
		public virtual RMethod RMSetThreadPrincipal_IPrincipal
		{
			get
			{
				if(r_MSetThreadPrincipal_IPrincipal == null)
				{
					r_MSetThreadPrincipal_IPrincipal = new(this, "SetThreadPrincipal", 0, typeof(System.Security.Principal.IPrincipal));
				}
				return r_MSetThreadPrincipal_IPrincipal;
			}
		}

		/// <summary>
		/// System.AppDomain InternalSetDomainByID(Int32)
		/// </summary>
		protected static RMethod r_MInternalSetDomainByID_Int32;
		public static RMethod RMInternalSetDomainByID_Int32
		{
			get
			{
				if(r_MInternalSetDomainByID_Int32 == null)
				{
					r_MInternalSetDomainByID_Int32 = new(Type, "InternalSetDomainByID", 0, typeof(System.Int32));
				}
				return r_MInternalSetDomainByID_Int32;
			}
		}

		/// <summary>
		/// System.AppDomain InternalSetDomain(System.AppDomain)
		/// </summary>
		protected static RMethod r_MInternalSetDomain_AppDomain;
		public static RMethod RMInternalSetDomain_AppDomain
		{
			get
			{
				if(r_MInternalSetDomain_AppDomain == null)
				{
					r_MInternalSetDomain_AppDomain = new(Type, "InternalSetDomain", 0, typeof(System.AppDomain));
				}
				return r_MInternalSetDomain_AppDomain;
			}
		}

		/// <summary>
		/// Void InternalPushDomainRef(System.AppDomain)
		/// </summary>
		protected static RMethod r_MInternalPushDomainRef_AppDomain;
		public static RMethod RMInternalPushDomainRef_AppDomain
		{
			get
			{
				if(r_MInternalPushDomainRef_AppDomain == null)
				{
					r_MInternalPushDomainRef_AppDomain = new(Type, "InternalPushDomainRef", 0, typeof(System.AppDomain));
				}
				return r_MInternalPushDomainRef_AppDomain;
			}
		}

		/// <summary>
		/// Void InternalPushDomainRefByID(Int32)
		/// </summary>
		protected static RMethod r_MInternalPushDomainRefByID_Int32;
		public static RMethod RMInternalPushDomainRefByID_Int32
		{
			get
			{
				if(r_MInternalPushDomainRefByID_Int32 == null)
				{
					r_MInternalPushDomainRefByID_Int32 = new(Type, "InternalPushDomainRefByID", 0, typeof(System.Int32));
				}
				return r_MInternalPushDomainRefByID_Int32;
			}
		}

		/// <summary>
		/// Void InternalPopDomainRef()
		/// </summary>
		protected static RMethod r_MInternalPopDomainRef;
		public static RMethod RMInternalPopDomainRef
		{
			get
			{
				if(r_MInternalPopDomainRef == null)
				{
					r_MInternalPopDomainRef = new(Type, "InternalPopDomainRef", 0);
				}
				return r_MInternalPopDomainRef;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.Context InternalSetContext(System.Runtime.Remoting.Contexts.Context)
		/// </summary>
		protected static RMethod r_MInternalSetContext_Context;
		public static RMethod RMInternalSetContext_Context
		{
			get
			{
				if(r_MInternalSetContext_Context == null)
				{
					r_MInternalSetContext_Context = new(Type, "InternalSetContext", 0, typeof(System.Runtime.Remoting.Contexts.Context));
				}
				return r_MInternalSetContext_Context;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.Context InternalGetContext()
		/// </summary>
		protected static RMethod r_MInternalGetContext;
		public static RMethod RMInternalGetContext
		{
			get
			{
				if(r_MInternalGetContext == null)
				{
					r_MInternalGetContext = new(Type, "InternalGetContext", 0);
				}
				return r_MInternalGetContext;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.Context InternalGetDefaultContext()
		/// </summary>
		protected static RMethod r_MInternalGetDefaultContext;
		public static RMethod RMInternalGetDefaultContext
		{
			get
			{
				if(r_MInternalGetDefaultContext == null)
				{
					r_MInternalGetDefaultContext = new(Type, "InternalGetDefaultContext", 0);
				}
				return r_MInternalGetDefaultContext;
			}
		}

		/// <summary>
		/// System.String InternalGetProcessGuid(System.String)
		/// </summary>
		protected static RMethod r_MInternalGetProcessGuid_String;
		public static RMethod RMInternalGetProcessGuid_String
		{
			get
			{
				if(r_MInternalGetProcessGuid_String == null)
				{
					r_MInternalGetProcessGuid_String = new(Type, "InternalGetProcessGuid", 0, typeof(System.String));
				}
				return r_MInternalGetProcessGuid_String;
			}
		}

		/// <summary>
		/// System.Object InvokeInDomain(System.AppDomain, System.Reflection.MethodInfo, System.Object, System.Object[])
		/// </summary>
		protected static RMethod r_MInvokeInDomain_AppDomain_MethodInfo_Object_ObjectArray;
		public static RMethod RMInvokeInDomain_AppDomain_MethodInfo_Object_ObjectArray
		{
			get
			{
				if(r_MInvokeInDomain_AppDomain_MethodInfo_Object_ObjectArray == null)
				{
					r_MInvokeInDomain_AppDomain_MethodInfo_Object_ObjectArray = new(Type, "InvokeInDomain", 0, typeof(System.AppDomain), typeof(System.Reflection.MethodInfo), typeof(System.Object), typeof(System.Object).MakeArrayType());
				}
				return r_MInvokeInDomain_AppDomain_MethodInfo_Object_ObjectArray;
			}
		}

		/// <summary>
		/// System.Object InvokeInDomainByID(Int32, System.Reflection.MethodInfo, System.Object, System.Object[])
		/// </summary>
		protected static RMethod r_MInvokeInDomainByID_Int32_MethodInfo_Object_ObjectArray;
		public static RMethod RMInvokeInDomainByID_Int32_MethodInfo_Object_ObjectArray
		{
			get
			{
				if(r_MInvokeInDomainByID_Int32_MethodInfo_Object_ObjectArray == null)
				{
					r_MInvokeInDomainByID_Int32_MethodInfo_Object_ObjectArray = new(Type, "InvokeInDomainByID", 0, typeof(System.Int32), typeof(System.Reflection.MethodInfo), typeof(System.Object), typeof(System.Object).MakeArrayType());
				}
				return r_MInvokeInDomainByID_Int32_MethodInfo_Object_ObjectArray;
			}
		}

		/// <summary>
		/// System.String GetProcessGuid()
		/// </summary>
		protected static RMethod r_MGetProcessGuid;
		public static RMethod RMGetProcessGuid
		{
			get
			{
				if(r_MGetProcessGuid == null)
				{
					r_MGetProcessGuid = new(Type, "GetProcessGuid", 0);
				}
				return r_MGetProcessGuid;
			}
		}

		/// <summary>
		/// System.AppDomain CreateDomain(System.String)
		/// </summary>
		protected static RMethod r_MCreateDomain_String;
		public static RMethod RMCreateDomain_String
		{
			get
			{
				if(r_MCreateDomain_String == null)
				{
					r_MCreateDomain_String = new(Type, "CreateDomain", 0, typeof(System.String));
				}
				return r_MCreateDomain_String;
			}
		}

		/// <summary>
		/// System.AppDomain CreateDomain(System.String, System.Security.Policy.Evidence)
		/// </summary>
		protected static RMethod r_MCreateDomain_String_Evidence;
		public static RMethod RMCreateDomain_String_Evidence
		{
			get
			{
				if(r_MCreateDomain_String_Evidence == null)
				{
					r_MCreateDomain_String_Evidence = new(Type, "CreateDomain", 0, typeof(System.String), typeof(System.Security.Policy.Evidence));
				}
				return r_MCreateDomain_String_Evidence;
			}
		}

		/// <summary>
		/// System.AppDomain createDomain(System.String, System.AppDomainSetup)
		/// </summary>
		protected static RMethod r_McreateDomain_String_AppDomainSetup;
		public static RMethod RMcreateDomain_String_AppDomainSetup
		{
			get
			{
				if(r_McreateDomain_String_AppDomainSetup == null)
				{
					r_McreateDomain_String_AppDomainSetup = new(Type, "createDomain", 0, typeof(System.String), typeof(System.AppDomainSetup));
				}
				return r_McreateDomain_String_AppDomainSetup;
			}
		}

		/// <summary>
		/// System.AppDomain CreateDomain(System.String, System.Security.Policy.Evidence, System.AppDomainSetup)
		/// </summary>
		protected static RMethod r_MCreateDomain_String_Evidence_AppDomainSetup;
		public static RMethod RMCreateDomain_String_Evidence_AppDomainSetup
		{
			get
			{
				if(r_MCreateDomain_String_Evidence_AppDomainSetup == null)
				{
					r_MCreateDomain_String_Evidence_AppDomainSetup = new(Type, "CreateDomain", 0, typeof(System.String), typeof(System.Security.Policy.Evidence), typeof(System.AppDomainSetup));
				}
				return r_MCreateDomain_String_Evidence_AppDomainSetup;
			}
		}

		/// <summary>
		/// System.AppDomain CreateDomain(System.String, System.Security.Policy.Evidence, System.String, System.String, Boolean)
		/// </summary>
		protected static RMethod r_MCreateDomain_String_Evidence_String_String_Boolean;
		public static RMethod RMCreateDomain_String_Evidence_String_String_Boolean
		{
			get
			{
				if(r_MCreateDomain_String_Evidence_String_String_Boolean == null)
				{
					r_MCreateDomain_String_Evidence_String_String_Boolean = new(Type, "CreateDomain", 0, typeof(System.String), typeof(System.Security.Policy.Evidence), typeof(System.String), typeof(System.String), typeof(System.Boolean));
				}
				return r_MCreateDomain_String_Evidence_String_String_Boolean;
			}
		}

		/// <summary>
		/// System.AppDomain CreateDomain(System.String, System.Security.Policy.Evidence, System.AppDomainSetup, System.Security.PermissionSet, System.Security.Policy.StrongName[])
		/// </summary>
		protected static RMethod r_MCreateDomain_String_Evidence_AppDomainSetup_PermissionSet_StrongNameArray;
		public static RMethod RMCreateDomain_String_Evidence_AppDomainSetup_PermissionSet_StrongNameArray
		{
			get
			{
				if(r_MCreateDomain_String_Evidence_AppDomainSetup_PermissionSet_StrongNameArray == null)
				{
					r_MCreateDomain_String_Evidence_AppDomainSetup_PermissionSet_StrongNameArray = new(Type, "CreateDomain", 0, typeof(System.String), typeof(System.Security.Policy.Evidence), typeof(System.AppDomainSetup), typeof(System.Security.PermissionSet), typeof(System.Security.Policy.StrongName).MakeArrayType());
				}
				return r_MCreateDomain_String_Evidence_AppDomainSetup_PermissionSet_StrongNameArray;
			}
		}

		/// <summary>
		/// System.AppDomainSetup CreateDomainSetup(System.String, System.String, Boolean)
		/// </summary>
		protected static RMethod r_MCreateDomainSetup_String_String_Boolean;
		public static RMethod RMCreateDomainSetup_String_String_Boolean
		{
			get
			{
				if(r_MCreateDomainSetup_String_String_Boolean == null)
				{
					r_MCreateDomainSetup_String_String_Boolean = new(Type, "CreateDomainSetup", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean));
				}
				return r_MCreateDomainSetup_String_String_Boolean;
			}
		}

		/// <summary>
		/// Boolean InternalIsFinalizingForUnload(Int32)
		/// </summary>
		protected static RMethod r_MInternalIsFinalizingForUnload_Int32;
		public static RMethod RMInternalIsFinalizingForUnload_Int32
		{
			get
			{
				if(r_MInternalIsFinalizingForUnload_Int32 == null)
				{
					r_MInternalIsFinalizingForUnload_Int32 = new(Type, "InternalIsFinalizingForUnload", 0, typeof(System.Int32));
				}
				return r_MInternalIsFinalizingForUnload_Int32;
			}
		}

		/// <summary>
		/// Boolean IsFinalizingForUnload()
		/// </summary>
		protected RMethod r_MIsFinalizingForUnload;
		public virtual RMethod RMIsFinalizingForUnload
		{
			get
			{
				if(r_MIsFinalizingForUnload == null)
				{
					r_MIsFinalizingForUnload = new(this, "IsFinalizingForUnload", 0);
				}
				return r_MIsFinalizingForUnload;
			}
		}

		/// <summary>
		/// Void InternalUnload(Int32)
		/// </summary>
		protected static RMethod r_MInternalUnload_Int32;
		public static RMethod RMInternalUnload_Int32
		{
			get
			{
				if(r_MInternalUnload_Int32 == null)
				{
					r_MInternalUnload_Int32 = new(Type, "InternalUnload", 0, typeof(System.Int32));
				}
				return r_MInternalUnload_Int32;
			}
		}

		/// <summary>
		/// Int32 getDomainID()
		/// </summary>
		protected RMethod r_MgetDomainID;
		public virtual RMethod RMgetDomainID
		{
			get
			{
				if(r_MgetDomainID == null)
				{
					r_MgetDomainID = new(this, "getDomainID", 0);
				}
				return r_MgetDomainID;
			}
		}

		/// <summary>
		/// Void Unload(System.AppDomain)
		/// </summary>
		protected static RMethod r_MUnload_AppDomain;
		public static RMethod RMUnload_AppDomain
		{
			get
			{
				if(r_MUnload_AppDomain == null)
				{
					r_MUnload_AppDomain = new(Type, "Unload", 0, typeof(System.AppDomain));
				}
				return r_MUnload_AppDomain;
			}
		}

		/// <summary>
		/// Void SetData(System.String, System.Object)
		/// </summary>
		protected RMethod r_MSetData_String_Object;
		public virtual RMethod RMSetData_String_Object
		{
			get
			{
				if(r_MSetData_String_Object == null)
				{
					r_MSetData_String_Object = new(this, "SetData", 0, typeof(System.String), typeof(System.Object));
				}
				return r_MSetData_String_Object;
			}
		}

		/// <summary>
		/// Void SetData(System.String, System.Object, System.Security.IPermission)
		/// </summary>
		protected RMethod r_MSetData_String_Object_IPermission;
		public virtual RMethod RMSetData_String_Object_IPermission
		{
			get
			{
				if(r_MSetData_String_Object_IPermission == null)
				{
					r_MSetData_String_Object_IPermission = new(this, "SetData", 0, typeof(System.String), typeof(System.Object), typeof(System.Security.IPermission));
				}
				return r_MSetData_String_Object_IPermission;
			}
		}

		/// <summary>
		/// Void SetDynamicBase(System.String)
		/// </summary>
		protected RMethod r_MSetDynamicBase_String;
		public virtual RMethod RMSetDynamicBase_String
		{
			get
			{
				if(r_MSetDynamicBase_String == null)
				{
					r_MSetDynamicBase_String = new(this, "SetDynamicBase", 0, typeof(System.String));
				}
				return r_MSetDynamicBase_String;
			}
		}

		/// <summary>
		/// Int32 GetCurrentThreadId()
		/// </summary>
		protected static RMethod r_MGetCurrentThreadId;
		public static RMethod RMGetCurrentThreadId
		{
			get
			{
				if(r_MGetCurrentThreadId == null)
				{
					r_MGetCurrentThreadId = new(Type, "GetCurrentThreadId", 0);
				}
				return r_MGetCurrentThreadId;
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
		/// Void ValidateAssemblyName(System.String)
		/// </summary>
		protected static RMethod r_MValidateAssemblyName_String;
		public static RMethod RMValidateAssemblyName_String
		{
			get
			{
				if(r_MValidateAssemblyName_String == null)
				{
					r_MValidateAssemblyName_String = new(Type, "ValidateAssemblyName", 0, typeof(System.String));
				}
				return r_MValidateAssemblyName_String;
			}
		}

		/// <summary>
		/// Void DoAssemblyLoad(System.Reflection.Assembly)
		/// </summary>
		protected RMethod r_MDoAssemblyLoad_Assembly;
		public virtual RMethod RMDoAssemblyLoad_Assembly
		{
			get
			{
				if(r_MDoAssemblyLoad_Assembly == null)
				{
					r_MDoAssemblyLoad_Assembly = new(this, "DoAssemblyLoad", 0, typeof(System.Reflection.Assembly));
				}
				return r_MDoAssemblyLoad_Assembly;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly DoAssemblyResolve(System.String, System.Reflection.Assembly, Boolean)
		/// </summary>
		protected RMethod r_MDoAssemblyResolve_String_Assembly_Boolean;
		public virtual RMethod RMDoAssemblyResolve_String_Assembly_Boolean
		{
			get
			{
				if(r_MDoAssemblyResolve_String_Assembly_Boolean == null)
				{
					r_MDoAssemblyResolve_String_Assembly_Boolean = new(this, "DoAssemblyResolve", 0, typeof(System.String), typeof(System.Reflection.Assembly), typeof(System.Boolean));
				}
				return r_MDoAssemblyResolve_String_Assembly_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly DoTypeBuilderResolve(System.Reflection.Emit.TypeBuilder)
		/// </summary>
		protected RMethod r_MDoTypeBuilderResolve_TypeBuilder;
		public virtual RMethod RMDoTypeBuilderResolve_TypeBuilder
		{
			get
			{
				if(r_MDoTypeBuilderResolve_TypeBuilder == null)
				{
					r_MDoTypeBuilderResolve_TypeBuilder = new(this, "DoTypeBuilderResolve", 0, typeof(System.Reflection.Emit.TypeBuilder));
				}
				return r_MDoTypeBuilderResolve_TypeBuilder;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly DoTypeResolve(System.String)
		/// </summary>
		protected RMethod r_MDoTypeResolve_String;
		public virtual RMethod RMDoTypeResolve_String
		{
			get
			{
				if(r_MDoTypeResolve_String == null)
				{
					r_MDoTypeResolve_String = new(this, "DoTypeResolve", 0, typeof(System.String));
				}
				return r_MDoTypeResolve_String;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly DoResourceResolve(System.String, System.Reflection.Assembly)
		/// </summary>
		protected RMethod r_MDoResourceResolve_String_Assembly;
		public virtual RMethod RMDoResourceResolve_String_Assembly
		{
			get
			{
				if(r_MDoResourceResolve_String_Assembly == null)
				{
					r_MDoResourceResolve_String_Assembly = new(this, "DoResourceResolve", 0, typeof(System.String), typeof(System.Reflection.Assembly));
				}
				return r_MDoResourceResolve_String_Assembly;
			}
		}

		/// <summary>
		/// Void DoDomainUnload()
		/// </summary>
		protected RMethod r_MDoDomainUnload;
		public virtual RMethod RMDoDomainUnload
		{
			get
			{
				if(r_MDoDomainUnload == null)
				{
					r_MDoDomainUnload = new(this, "DoDomainUnload", 0);
				}
				return r_MDoDomainUnload;
			}
		}

		/// <summary>
		/// Void DoUnhandledException(System.Exception)
		/// </summary>
		protected RMethod r_MDoUnhandledException_Exception;
		public virtual RMethod RMDoUnhandledException_Exception
		{
			get
			{
				if(r_MDoUnhandledException_Exception == null)
				{
					r_MDoUnhandledException_Exception = new(this, "DoUnhandledException", 0, typeof(System.Exception));
				}
				return r_MDoUnhandledException_Exception;
			}
		}

		/// <summary>
		/// Void DoUnhandledException(System.UnhandledExceptionEventArgs)
		/// </summary>
		protected RMethod r_MDoUnhandledException_UnhandledExceptionEventArgs;
		public virtual RMethod RMDoUnhandledException_UnhandledExceptionEventArgs
		{
			get
			{
				if(r_MDoUnhandledException_UnhandledExceptionEventArgs == null)
				{
					r_MDoUnhandledException_UnhandledExceptionEventArgs = new(this, "DoUnhandledException", 0, typeof(System.UnhandledExceptionEventArgs));
				}
				return r_MDoUnhandledException_UnhandledExceptionEventArgs;
			}
		}

		/// <summary>
		/// Byte[] GetMarshalledDomainObjRef()
		/// </summary>
		protected RMethod r_MGetMarshalledDomainObjRef;
		public virtual RMethod RMGetMarshalledDomainObjRef
		{
			get
			{
				if(r_MGetMarshalledDomainObjRef == null)
				{
					r_MGetMarshalledDomainObjRef = new(this, "GetMarshalledDomainObjRef", 0);
				}
				return r_MGetMarshalledDomainObjRef;
			}
		}

		/// <summary>
		/// Void ProcessMessageInDomain(Byte[], System.Runtime.Remoting.Messaging.CADMethodCallMessage, Byte[] ByRef, System.Runtime.Remoting.Messaging.CADMethodReturnMessage ByRef)
		/// </summary>
		protected RMethod r_MProcessMessageInDomain_ByteArray_CADMethodCallMessage_Out_ByteArray_Out_CADMethodReturnMessage;
		public virtual RMethod RMProcessMessageInDomain_ByteArray_CADMethodCallMessage_Out_ByteArray_Out_CADMethodReturnMessage
		{
			get
			{
				if(r_MProcessMessageInDomain_ByteArray_CADMethodCallMessage_Out_ByteArray_Out_CADMethodReturnMessage == null)
				{
					r_MProcessMessageInDomain_ByteArray_CADMethodCallMessage_Out_ByteArray_Out_CADMethodReturnMessage = new(this, "ProcessMessageInDomain", 0, typeof(System.Byte).MakeArrayType(),  ReflectionUtils.GetType("System.Runtime.Remoting.Messaging.CADMethodCallMessage"), typeof(System.Byte).MakeArrayType().MakeByRefType(),  ReflectionUtils.GetType("System.Runtime.Remoting.Messaging.CADMethodReturnMessage").MakeByRefType());
				}
				return r_MProcessMessageInDomain_ByteArray_CADMethodCallMessage_Out_ByteArray_Out_CADMethodReturnMessage;
			}
		}

		/// <summary>
		/// System.String ApplyPolicy(System.String)
		/// </summary>
		protected RMethod r_MApplyPolicy_String;
		public virtual RMethod RMApplyPolicy_String
		{
			get
			{
				if(r_MApplyPolicy_String == null)
				{
					r_MApplyPolicy_String = new(this, "ApplyPolicy", 0, typeof(System.String));
				}
				return r_MApplyPolicy_String;
			}
		}

		/// <summary>
		/// System.AppDomain CreateDomain(System.String, System.Security.Policy.Evidence, System.String, System.String, Boolean, System.AppDomainInitializer, System.String[])
		/// </summary>
		protected static RMethod r_MCreateDomain_String_Evidence_String_String_Boolean_AppDomainInitializer_StringArray;
		public static RMethod RMCreateDomain_String_Evidence_String_String_Boolean_AppDomainInitializer_StringArray
		{
			get
			{
				if(r_MCreateDomain_String_Evidence_String_String_Boolean_AppDomainInitializer_StringArray == null)
				{
					r_MCreateDomain_String_Evidence_String_String_Boolean_AppDomainInitializer_StringArray = new(Type, "CreateDomain", 0, typeof(System.String), typeof(System.Security.Policy.Evidence), typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.AppDomainInitializer), typeof(System.String).MakeArrayType());
				}
				return r_MCreateDomain_String_Evidence_String_String_Boolean_AppDomainInitializer_StringArray;
			}
		}

		/// <summary>
		/// Int32 ExecuteAssemblyByName(System.String)
		/// </summary>
		protected RMethod r_MExecuteAssemblyByName_String;
		public virtual RMethod RMExecuteAssemblyByName_String
		{
			get
			{
				if(r_MExecuteAssemblyByName_String == null)
				{
					r_MExecuteAssemblyByName_String = new(this, "ExecuteAssemblyByName", 0, typeof(System.String));
				}
				return r_MExecuteAssemblyByName_String;
			}
		}

		/// <summary>
		/// Int32 ExecuteAssemblyByName(System.String, System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_MExecuteAssemblyByName_String_Evidence;
		public virtual RMethod RMExecuteAssemblyByName_String_Evidence
		{
			get
			{
				if(r_MExecuteAssemblyByName_String_Evidence == null)
				{
					r_MExecuteAssemblyByName_String_Evidence = new(this, "ExecuteAssemblyByName", 0, typeof(System.String), typeof(System.Security.Policy.Evidence));
				}
				return r_MExecuteAssemblyByName_String_Evidence;
			}
		}

		/// <summary>
		/// Int32 ExecuteAssemblyByName(System.String, System.Security.Policy.Evidence, System.String[])
		/// </summary>
		protected RMethod r_MExecuteAssemblyByName_String_Evidence_StringArray;
		public virtual RMethod RMExecuteAssemblyByName_String_Evidence_StringArray
		{
			get
			{
				if(r_MExecuteAssemblyByName_String_Evidence_StringArray == null)
				{
					r_MExecuteAssemblyByName_String_Evidence_StringArray = new(this, "ExecuteAssemblyByName", 0, typeof(System.String), typeof(System.Security.Policy.Evidence), typeof(System.String).MakeArrayType());
				}
				return r_MExecuteAssemblyByName_String_Evidence_StringArray;
			}
		}

		/// <summary>
		/// Int32 ExecuteAssemblyByName(System.Reflection.AssemblyName, System.Security.Policy.Evidence, System.String[])
		/// </summary>
		protected RMethod r_MExecuteAssemblyByName_AssemblyName_Evidence_StringArray;
		public virtual RMethod RMExecuteAssemblyByName_AssemblyName_Evidence_StringArray
		{
			get
			{
				if(r_MExecuteAssemblyByName_AssemblyName_Evidence_StringArray == null)
				{
					r_MExecuteAssemblyByName_AssemblyName_Evidence_StringArray = new(this, "ExecuteAssemblyByName", 0, typeof(System.Reflection.AssemblyName), typeof(System.Security.Policy.Evidence), typeof(System.String).MakeArrayType());
				}
				return r_MExecuteAssemblyByName_AssemblyName_Evidence_StringArray;
			}
		}

		/// <summary>
		/// Int32 ExecuteAssemblyByName(System.String, System.String[])
		/// </summary>
		protected RMethod r_MExecuteAssemblyByName_String_StringArray;
		public virtual RMethod RMExecuteAssemblyByName_String_StringArray
		{
			get
			{
				if(r_MExecuteAssemblyByName_String_StringArray == null)
				{
					r_MExecuteAssemblyByName_String_StringArray = new(this, "ExecuteAssemblyByName", 0, typeof(System.String), typeof(System.String).MakeArrayType());
				}
				return r_MExecuteAssemblyByName_String_StringArray;
			}
		}

		/// <summary>
		/// Int32 ExecuteAssemblyByName(System.Reflection.AssemblyName, System.String[])
		/// </summary>
		protected RMethod r_MExecuteAssemblyByName_AssemblyName_StringArray;
		public virtual RMethod RMExecuteAssemblyByName_AssemblyName_StringArray
		{
			get
			{
				if(r_MExecuteAssemblyByName_AssemblyName_StringArray == null)
				{
					r_MExecuteAssemblyByName_AssemblyName_StringArray = new(this, "ExecuteAssemblyByName", 0, typeof(System.Reflection.AssemblyName), typeof(System.String).MakeArrayType());
				}
				return r_MExecuteAssemblyByName_AssemblyName_StringArray;
			}
		}

		/// <summary>
		/// Boolean IsDefaultAppDomain()
		/// </summary>
		protected RMethod r_MIsDefaultAppDomain;
		public virtual RMethod RMIsDefaultAppDomain
		{
			get
			{
				if(r_MIsDefaultAppDomain == null)
				{
					r_MIsDefaultAppDomain = new(this, "IsDefaultAppDomain", 0);
				}
				return r_MIsDefaultAppDomain;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly[] ReflectionOnlyGetAssemblies()
		/// </summary>
		protected RMethod r_MReflectionOnlyGetAssemblies;
		public virtual RMethod RMReflectionOnlyGetAssemblies
		{
			get
			{
				if(r_MReflectionOnlyGetAssemblies == null)
				{
					r_MReflectionOnlyGetAssemblies = new(this, "ReflectionOnlyGetAssemblies", 0);
				}
				return r_MReflectionOnlyGetAssemblies;
			}
		}

		/// <summary>
		/// Void System._AppDomain.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2___AppDomain__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2___AppDomain__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2___AppDomain__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2___AppDomain__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System._AppDomain.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
				}
				return r_MSystem__2___AppDomain__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System._AppDomain.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2___AppDomain__2__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2___AppDomain__2__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2___AppDomain__2__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2___AppDomain__2__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System._AppDomain.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
				}
				return r_MSystem__2___AppDomain__2__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System._AppDomain.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_MSystem__2___AppDomain__2__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RMSystem__2___AppDomain__2__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_MSystem__2___AppDomain__2__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_MSystem__2___AppDomain__2__GetTypeInfoCount_Out_UInt32 = new(this, "System._AppDomain.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
				}
				return r_MSystem__2___AppDomain__2__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System._AppDomain.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2___AppDomain__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RMSystem__2___AppDomain__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_MSystem__2___AppDomain__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_MSystem__2___AppDomain__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System._AppDomain.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
				}
				return r_MSystem__2___AppDomain__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// System.Nullable`1[System.Boolean] IsCompatibilitySwitchSet(System.String)
		/// </summary>
		protected RMethod r_MIsCompatibilitySwitchSet_String;
		public virtual RMethod RMIsCompatibilitySwitchSet_String
		{
			get
			{
				if(r_MIsCompatibilitySwitchSet_String == null)
				{
					r_MIsCompatibilitySwitchSet_String = new(this, "IsCompatibilitySwitchSet", 0, typeof(System.String));
				}
				return r_MIsCompatibilitySwitchSet_String;
			}
		}

		/// <summary>
		/// Void SetCompatibilitySwitch(System.String)
		/// </summary>
		protected RMethod r_MSetCompatibilitySwitch_String;
		public virtual RMethod RMSetCompatibilitySwitch_String
		{
			get
			{
				if(r_MSetCompatibilitySwitch_String == null)
				{
					r_MSetCompatibilitySwitch_String = new(this, "SetCompatibilitySwitch", 0, typeof(System.String));
				}
				return r_MSetCompatibilitySwitch_String;
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


        public static System.Boolean IsAppXModel()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsAppXModel.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean IsAppXDesignMode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsAppXDesignMode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static void CheckReflectionOnlyLoadSupported()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCheckReflectionOnlyLoadSupported.Invoke(___genericsType, ___parameters);

            
        }


        public static void CheckLoadFromSupported()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCheckLoadFromSupported.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.AppDomainSetup getSetup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMgetSetup.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.AppDomainSetup>(___result);
        }


        public virtual System.String getFriendlyName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMgetFriendlyName.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public static System.AppDomain getCurDomain()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMgetCurDomain.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.AppDomain>(___result);
        }


        public static System.AppDomain getRootDomain()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMgetRootDomain.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.AppDomain>(___result);
        }


        public virtual void AppendPrivatePath(System.String @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path};
            var ___result = RMAppendPrivatePath_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearPrivatePath()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearPrivatePath.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearShadowCopyPath()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearShadowCopyPath.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Runtime.Remoting.ObjectHandle CreateComInstanceFrom(System.String @assemblyName, System.String @typeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName};
            var ___result = RMCreateComInstanceFrom_String_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Runtime.Remoting.ObjectHandle>(___result);
        }


        public virtual System.Runtime.Remoting.ObjectHandle CreateComInstanceFrom(System.String @assemblyFile, System.String @typeName, System.Byte[] @hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm @hashAlgorithm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile, @typeName, @hashValue, @hashAlgorithm};
            var ___result = RMCreateComInstanceFrom_String_String_ByteArray_AssemblyHashAlgorithm.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Runtime.Remoting.ObjectHandle>(___result);
        }


        public virtual System.Runtime.Remoting.ObjectHandle InternalCreateInstanceWithNoSecurity(System.String @assemblyName, System.String @typeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName};
            var ___result = RMInternalCreateInstanceWithNoSecurity_String_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Runtime.Remoting.ObjectHandle>(___result);
        }


        public virtual System.Runtime.Remoting.ObjectHandle InternalCreateInstanceWithNoSecurity(System.String @assemblyName, System.String @typeName, System.Boolean @ignoreCase, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Object[] @args, System.Globalization.CultureInfo @culture, System.Object[] @activationAttributes, System.Security.Policy.Evidence @securityAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName, @ignoreCase, @bindingAttr, @binder, @args, @culture, @activationAttributes, @securityAttributes};
            var ___result = RMInternalCreateInstanceWithNoSecurity_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Runtime.Remoting.ObjectHandle>(___result);
        }


        public virtual System.Runtime.Remoting.ObjectHandle InternalCreateInstanceFromWithNoSecurity(System.String @assemblyName, System.String @typeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName};
            var ___result = RMInternalCreateInstanceFromWithNoSecurity_String_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Runtime.Remoting.ObjectHandle>(___result);
        }


        public virtual System.Runtime.Remoting.ObjectHandle InternalCreateInstanceFromWithNoSecurity(System.String @assemblyName, System.String @typeName, System.Boolean @ignoreCase, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Object[] @args, System.Globalization.CultureInfo @culture, System.Object[] @activationAttributes, System.Security.Policy.Evidence @securityAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName, @ignoreCase, @bindingAttr, @binder, @args, @culture, @activationAttributes, @securityAttributes};
            var ___result = RMInternalCreateInstanceFromWithNoSecurity_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Runtime.Remoting.ObjectHandle>(___result);
        }


        public virtual System.Runtime.Remoting.ObjectHandle CreateInstance(System.String @assemblyName, System.String @typeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName};
            var ___result = RMCreateInstance_String_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Runtime.Remoting.ObjectHandle>(___result);
        }


        public virtual System.Runtime.Remoting.ObjectHandle CreateInstance(System.String @assemblyName, System.String @typeName, System.Object[] @activationAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName, @activationAttributes};
            var ___result = RMCreateInstance_String_String_ObjectArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Runtime.Remoting.ObjectHandle>(___result);
        }


        public virtual System.Runtime.Remoting.ObjectHandle CreateInstance(System.String @assemblyName, System.String @typeName, System.Boolean @ignoreCase, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Object[] @args, System.Globalization.CultureInfo @culture, System.Object[] @activationAttributes, System.Security.Policy.Evidence @securityAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName, @ignoreCase, @bindingAttr, @binder, @args, @culture, @activationAttributes, @securityAttributes};
            var ___result = RMCreateInstance_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Runtime.Remoting.ObjectHandle>(___result);
        }


        public virtual System.Object CreateInstanceAndUnwrap(System.String @assemblyName, System.String @typeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName};
            var ___result = RMCreateInstanceAndUnwrap_String_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Object CreateInstanceAndUnwrap(System.String @assemblyName, System.String @typeName, System.Object[] @activationAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName, @activationAttributes};
            var ___result = RMCreateInstanceAndUnwrap_String_String_ObjectArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Object CreateInstanceAndUnwrap(System.String @assemblyName, System.String @typeName, System.Boolean @ignoreCase, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Object[] @args, System.Globalization.CultureInfo @culture, System.Object[] @activationAttributes, System.Security.Policy.Evidence @securityAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName, @ignoreCase, @bindingAttr, @binder, @args, @culture, @activationAttributes, @securityAttributes};
            var ___result = RMCreateInstanceAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Runtime.Remoting.ObjectHandle CreateInstance(System.String @assemblyName, System.String @typeName, System.Boolean @ignoreCase, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Object[] @args, System.Globalization.CultureInfo @culture, System.Object[] @activationAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName, @ignoreCase, @bindingAttr, @binder, @args, @culture, @activationAttributes};
            var ___result = RMCreateInstance_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Runtime.Remoting.ObjectHandle>(___result);
        }


        public virtual System.Object CreateInstanceAndUnwrap(System.String @assemblyName, System.String @typeName, System.Boolean @ignoreCase, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Object[] @args, System.Globalization.CultureInfo @culture, System.Object[] @activationAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName, @ignoreCase, @bindingAttr, @binder, @args, @culture, @activationAttributes};
            var ___result = RMCreateInstanceAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(System.String @assemblyFile, System.String @typeName, System.Boolean @ignoreCase, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Object[] @args, System.Globalization.CultureInfo @culture, System.Object[] @activationAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile, @typeName, @ignoreCase, @bindingAttr, @binder, @args, @culture, @activationAttributes};
            var ___result = RMCreateInstanceFrom_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Runtime.Remoting.ObjectHandle>(___result);
        }


        public virtual System.Object CreateInstanceFromAndUnwrap(System.String @assemblyFile, System.String @typeName, System.Boolean @ignoreCase, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Object[] @args, System.Globalization.CultureInfo @culture, System.Object[] @activationAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile, @typeName, @ignoreCase, @bindingAttr, @binder, @args, @culture, @activationAttributes};
            var ___result = RMCreateInstanceFromAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(System.String @assemblyFile, System.String @typeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile, @typeName};
            var ___result = RMCreateInstanceFrom_String_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Runtime.Remoting.ObjectHandle>(___result);
        }


        public virtual System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(System.String @assemblyFile, System.String @typeName, System.Object[] @activationAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile, @typeName, @activationAttributes};
            var ___result = RMCreateInstanceFrom_String_String_ObjectArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Runtime.Remoting.ObjectHandle>(___result);
        }


        public virtual System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(System.String @assemblyFile, System.String @typeName, System.Boolean @ignoreCase, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Object[] @args, System.Globalization.CultureInfo @culture, System.Object[] @activationAttributes, System.Security.Policy.Evidence @securityAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile, @typeName, @ignoreCase, @bindingAttr, @binder, @args, @culture, @activationAttributes, @securityAttributes};
            var ___result = RMCreateInstanceFrom_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Runtime.Remoting.ObjectHandle>(___result);
        }


        public virtual System.Object CreateInstanceFromAndUnwrap(System.String @assemblyName, System.String @typeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName};
            var ___result = RMCreateInstanceFromAndUnwrap_String_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Object CreateInstanceFromAndUnwrap(System.String @assemblyName, System.String @typeName, System.Object[] @activationAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName, @activationAttributes};
            var ___result = RMCreateInstanceFromAndUnwrap_String_String_ObjectArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Object CreateInstanceFromAndUnwrap(System.String @assemblyName, System.String @typeName, System.Boolean @ignoreCase, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Object[] @args, System.Globalization.CultureInfo @culture, System.Object[] @activationAttributes, System.Security.Policy.Evidence @securityAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName, @ignoreCase, @bindingAttr, @binder, @args, @culture, @activationAttributes, @securityAttributes};
            var ___result = RMCreateInstanceFromAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName @name, System.Reflection.Emit.AssemblyBuilderAccess @access)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @access};
            var ___result = RMDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.AssemblyBuilder>(___result);
        }


        public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName @name, System.Reflection.Emit.AssemblyBuilderAccess @access, System.Security.Policy.Evidence @evidence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @access, @evidence};
            var ___result = RMDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_Evidence.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.AssemblyBuilder>(___result);
        }


        public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName @name, System.Reflection.Emit.AssemblyBuilderAccess @access, System.String @dir)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @access, @dir};
            var ___result = RMDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.AssemblyBuilder>(___result);
        }


        public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName @name, System.Reflection.Emit.AssemblyBuilderAccess @access, System.String @dir, System.Security.Policy.Evidence @evidence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @access, @dir, @evidence};
            var ___result = RMDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.AssemblyBuilder>(___result);
        }


        public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName @name, System.Reflection.Emit.AssemblyBuilderAccess @access, System.Security.PermissionSet @requiredPermissions, System.Security.PermissionSet @optionalPermissions, System.Security.PermissionSet @refusedPermissions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @access, @requiredPermissions, @optionalPermissions, @refusedPermissions};
            var ___result = RMDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_PermissionSet_PermissionSet_PermissionSet.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.AssemblyBuilder>(___result);
        }


        public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName @name, System.Reflection.Emit.AssemblyBuilderAccess @access, System.Security.Policy.Evidence @evidence, System.Security.PermissionSet @requiredPermissions, System.Security.PermissionSet @optionalPermissions, System.Security.PermissionSet @refusedPermissions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @access, @evidence, @requiredPermissions, @optionalPermissions, @refusedPermissions};
            var ___result = RMDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_Evidence_PermissionSet_PermissionSet_PermissionSet.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.AssemblyBuilder>(___result);
        }


        public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName @name, System.Reflection.Emit.AssemblyBuilderAccess @access, System.String @dir, System.Security.PermissionSet @requiredPermissions, System.Security.PermissionSet @optionalPermissions, System.Security.PermissionSet @refusedPermissions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @access, @dir, @requiredPermissions, @optionalPermissions, @refusedPermissions};
            var ___result = RMDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_PermissionSet_PermissionSet_PermissionSet.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.AssemblyBuilder>(___result);
        }


        public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName @name, System.Reflection.Emit.AssemblyBuilderAccess @access, System.String @dir, System.Security.Policy.Evidence @evidence, System.Security.PermissionSet @requiredPermissions, System.Security.PermissionSet @optionalPermissions, System.Security.PermissionSet @refusedPermissions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @access, @dir, @evidence, @requiredPermissions, @optionalPermissions, @refusedPermissions};
            var ___result = RMDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.AssemblyBuilder>(___result);
        }


        public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName @name, System.Reflection.Emit.AssemblyBuilderAccess @access, System.String @dir, System.Security.Policy.Evidence @evidence, System.Security.PermissionSet @requiredPermissions, System.Security.PermissionSet @optionalPermissions, System.Security.PermissionSet @refusedPermissions, System.Boolean @isSynchronized)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @access, @dir, @evidence, @requiredPermissions, @optionalPermissions, @refusedPermissions, @isSynchronized};
            var ___result = RMDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.AssemblyBuilder>(___result);
        }


        public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName @name, System.Reflection.Emit.AssemblyBuilderAccess @access, System.String @dir, System.Security.Policy.Evidence @evidence, System.Security.PermissionSet @requiredPermissions, System.Security.PermissionSet @optionalPermissions, System.Security.PermissionSet @refusedPermissions, System.Boolean @isSynchronized, System.Collections.Generic.IEnumerable<System.Reflection.Emit.CustomAttributeBuilder> @assemblyAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @access, @dir, @evidence, @requiredPermissions, @optionalPermissions, @refusedPermissions, @isSynchronized, @assemblyAttributes};
            var ___result = RMDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet_Boolean_IEnumerable_d_CustomAttributeBuilder_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.AssemblyBuilder>(___result);
        }


        public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName @name, System.Reflection.Emit.AssemblyBuilderAccess @access, System.Collections.Generic.IEnumerable<System.Reflection.Emit.CustomAttributeBuilder> @assemblyAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @access, @assemblyAttributes};
            var ___result = RMDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.AssemblyBuilder>(___result);
        }


        public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName @name, System.Reflection.Emit.AssemblyBuilderAccess @access, System.String @dir, System.Boolean @isSynchronized, System.Collections.Generic.IEnumerable<System.Reflection.Emit.CustomAttributeBuilder> @assemblyAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @access, @dir, @isSynchronized, @assemblyAttributes};
            var ___result = RMDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Boolean_IEnumerable_d_CustomAttributeBuilder_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.AssemblyBuilder>(___result);
        }


        public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName @name, System.Reflection.Emit.AssemblyBuilderAccess @access, System.Collections.Generic.IEnumerable<System.Reflection.Emit.CustomAttributeBuilder> @assemblyAttributes, System.Security.SecurityContextSource @securityContextSource)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @access, @assemblyAttributes, @securityContextSource};
            var ___result = RMDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p__SecurityContextSource.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.AssemblyBuilder>(___result);
        }


        public virtual System.Reflection.Emit.AssemblyBuilder DefineInternalDynamicAssembly(System.Reflection.AssemblyName @name, System.Reflection.Emit.AssemblyBuilderAccess @access)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @access};
            var ___result = RMDefineInternalDynamicAssembly_AssemblyName_AssemblyBuilderAccess.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.AssemblyBuilder>(___result);
        }


        public virtual void DoCallBack(System.CrossAppDomainDelegate @callBackDelegate)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callBackDelegate};
            var ___result = RMDoCallBack_CrossAppDomainDelegate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 ExecuteAssembly(System.String @assemblyFile)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile};
            var ___result = RMExecuteAssembly_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 ExecuteAssembly(System.String @assemblyFile, System.Security.Policy.Evidence @assemblySecurity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile, @assemblySecurity};
            var ___result = RMExecuteAssembly_String_Evidence.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 ExecuteAssembly(System.String @assemblyFile, System.Security.Policy.Evidence @assemblySecurity, System.String[] @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile, @assemblySecurity, @args};
            var ___result = RMExecuteAssembly_String_Evidence_StringArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 ExecuteAssembly(System.String @assemblyFile, System.Security.Policy.Evidence @assemblySecurity, System.String[] @args, System.Byte[] @hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm @hashAlgorithm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile, @assemblySecurity, @args, @hashValue, @hashAlgorithm};
            var ___result = RMExecuteAssembly_String_Evidence_StringArray_ByteArray_AssemblyHashAlgorithm.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 ExecuteAssembly(System.String @assemblyFile, System.String[] @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile, @args};
            var ___result = RMExecuteAssembly_String_StringArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 ExecuteAssembly(System.String @assemblyFile, System.String[] @args, System.Byte[] @hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm @hashAlgorithm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile, @args, @hashValue, @hashAlgorithm};
            var ___result = RMExecuteAssembly_String_StringArray_ByteArray_AssemblyHashAlgorithm.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 ExecuteAssemblyInternal(System.Reflection.Assembly @a, System.String[] @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @args};
            var ___result = RMExecuteAssemblyInternal_Assembly_StringArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 ExecuteAssembly(System.Reflection.Assembly @a, System.String[] @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @args};
            var ___result = RMExecuteAssembly_Assembly_StringArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Reflection.Assembly[] GetAssemblies(System.Boolean @refOnly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@refOnly};
            var ___result = RMGetAssemblies_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Assembly[]>(___result);
        }


        public virtual System.Reflection.Assembly[] GetAssemblies()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetAssemblies.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Assembly[]>(___result);
        }


        public virtual System.Object GetData(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetData_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object InitializeLifetimeService()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitializeLifetimeService.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Reflection.Assembly LoadAssembly(System.String @assemblyRef, System.Security.Policy.Evidence @securityEvidence, System.Boolean @refOnly, ref Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark @stackMark)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyRef, @securityEvidence, @refOnly, @stackMark.Value};
            var ___result = RMLoadAssembly_String_Evidence_Boolean_Ref_StackCrawlMark.Invoke(___genericsType, ___parameters);
			@stackMark = new Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark(___parameters[3]);

            return ReflectionUtils.Convert<System.Reflection.Assembly>(___result);
        }


        public virtual System.Reflection.Assembly Load(System.Reflection.AssemblyName @assemblyRef)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyRef};
            var ___result = RMLoad_AssemblyName.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Assembly>(___result);
        }


        public virtual System.Reflection.Assembly LoadSatellite(System.Reflection.AssemblyName @assemblyRef, System.Boolean @throwOnError, ref Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark @stackMark)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyRef, @throwOnError, @stackMark.Value};
            var ___result = RMLoadSatellite_AssemblyName_Boolean_Ref_StackCrawlMark.Invoke(___genericsType, ___parameters);
			@stackMark = new Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark(___parameters[2]);

            return ReflectionUtils.Convert<System.Reflection.Assembly>(___result);
        }


        public virtual System.Reflection.Assembly Load(System.Reflection.AssemblyName @assemblyRef, System.Security.Policy.Evidence @assemblySecurity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyRef, @assemblySecurity};
            var ___result = RMLoad_AssemblyName_Evidence.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Assembly>(___result);
        }


        public virtual System.Reflection.Assembly Load(System.String @assemblyString)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyString};
            var ___result = RMLoad_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Assembly>(___result);
        }


        public virtual System.Reflection.Assembly Load(System.String @assemblyString, System.Security.Policy.Evidence @assemblySecurity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyString, @assemblySecurity};
            var ___result = RMLoad_String_Evidence.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Assembly>(___result);
        }


        public virtual System.Reflection.Assembly Load(System.String @assemblyString, System.Security.Policy.Evidence @assemblySecurity, System.Boolean @refonly, ref Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark @stackMark)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyString, @assemblySecurity, @refonly, @stackMark.Value};
            var ___result = RMLoad_String_Evidence_Boolean_Ref_StackCrawlMark.Invoke(___genericsType, ___parameters);
			@stackMark = new Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark(___parameters[3]);

            return ReflectionUtils.Convert<System.Reflection.Assembly>(___result);
        }


        public virtual System.Reflection.Assembly Load(System.Byte[] @rawAssembly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rawAssembly};
            var ___result = RMLoad_ByteArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Assembly>(___result);
        }


        public virtual System.Reflection.Assembly Load(System.Byte[] @rawAssembly, System.Byte[] @rawSymbolStore)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rawAssembly, @rawSymbolStore};
            var ___result = RMLoad_ByteArray_ByteArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Assembly>(___result);
        }


        public virtual System.Reflection.Assembly LoadAssemblyRaw(System.Byte[] @rawAssembly, System.Byte[] @rawSymbolStore, System.Security.Policy.Evidence @securityEvidence, System.Boolean @refonly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rawAssembly, @rawSymbolStore, @securityEvidence, @refonly};
            var ___result = RMLoadAssemblyRaw_ByteArray_ByteArray_Evidence_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Assembly>(___result);
        }


        public virtual System.Reflection.Assembly Load(System.Byte[] @rawAssembly, System.Byte[] @rawSymbolStore, System.Security.Policy.Evidence @securityEvidence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rawAssembly, @rawSymbolStore, @securityEvidence};
            var ___result = RMLoad_ByteArray_ByteArray_Evidence.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Assembly>(___result);
        }


        public virtual System.Reflection.Assembly Load(System.Byte[] @rawAssembly, System.Byte[] @rawSymbolStore, System.Security.Policy.Evidence @securityEvidence, System.Boolean @refonly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rawAssembly, @rawSymbolStore, @securityEvidence, @refonly};
            var ___result = RMLoad_ByteArray_ByteArray_Evidence_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Assembly>(___result);
        }


        public virtual void SetAppDomainPolicy(System.Security.Policy.PolicyLevel @domainPolicy)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@domainPolicy};
            var ___result = RMSetAppDomainPolicy_PolicyLevel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCachePath(System.String @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path};
            var ___result = RMSetCachePath_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPrincipalPolicy(System.Security.Principal.PrincipalPolicy @policy)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@policy};
            var ___result = RMSetPrincipalPolicy_PrincipalPolicy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetShadowCopyFiles()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetShadowCopyFiles.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetShadowCopyPath(System.String @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path};
            var ___result = RMSetShadowCopyPath_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetThreadPrincipal(System.Security.Principal.IPrincipal @principal)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@principal};
            var ___result = RMSetThreadPrincipal_IPrincipal.Invoke(___genericsType, ___parameters);

            
        }


        public static System.AppDomain InternalSetDomainByID(System.Int32 @domain_id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@domain_id};
            var ___result = RMInternalSetDomainByID_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.AppDomain>(___result);
        }


        public static System.AppDomain InternalSetDomain(System.AppDomain @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@context};
            var ___result = RMInternalSetDomain_AppDomain.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.AppDomain>(___result);
        }


        public static void InternalPushDomainRef(System.AppDomain @domain)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@domain};
            var ___result = RMInternalPushDomainRef_AppDomain.Invoke(___genericsType, ___parameters);

            
        }


        public static void InternalPushDomainRefByID(System.Int32 @domain_id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@domain_id};
            var ___result = RMInternalPushDomainRefByID_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void InternalPopDomainRef()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternalPopDomainRef.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Runtime.Remoting.Contexts.Context InternalSetContext(System.Runtime.Remoting.Contexts.Context @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@context};
            var ___result = RMInternalSetContext_Context.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Runtime.Remoting.Contexts.Context>(___result);
        }


        public static System.Runtime.Remoting.Contexts.Context InternalGetContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternalGetContext.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Runtime.Remoting.Contexts.Context>(___result);
        }


        public static System.Runtime.Remoting.Contexts.Context InternalGetDefaultContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternalGetDefaultContext.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Runtime.Remoting.Contexts.Context>(___result);
        }


        public static System.String InternalGetProcessGuid(System.String @newguid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newguid};
            var ___result = RMInternalGetProcessGuid_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public static System.Object InvokeInDomain(System.AppDomain @domain, System.Reflection.MethodInfo @method, System.Object @obj, System.Object[] @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@domain, @method, @obj, @args};
            var ___result = RMInvokeInDomain_AppDomain_MethodInfo_Object_ObjectArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public static System.Object InvokeInDomainByID(System.Int32 @domain_id, System.Reflection.MethodInfo @method, System.Object @obj, System.Object[] @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@domain_id, @method, @obj, @args};
            var ___result = RMInvokeInDomainByID_Int32_MethodInfo_Object_ObjectArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public static System.String GetProcessGuid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetProcessGuid.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public static System.AppDomain CreateDomain(System.String @friendlyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@friendlyName};
            var ___result = RMCreateDomain_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.AppDomain>(___result);
        }


        public static System.AppDomain CreateDomain(System.String @friendlyName, System.Security.Policy.Evidence @securityInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@friendlyName, @securityInfo};
            var ___result = RMCreateDomain_String_Evidence.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.AppDomain>(___result);
        }


        public static System.AppDomain createDomain(System.String @friendlyName, System.AppDomainSetup @info)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@friendlyName, @info};
            var ___result = RMcreateDomain_String_AppDomainSetup.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.AppDomain>(___result);
        }


        public static System.AppDomain CreateDomain(System.String @friendlyName, System.Security.Policy.Evidence @securityInfo, System.AppDomainSetup @info)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@friendlyName, @securityInfo, @info};
            var ___result = RMCreateDomain_String_Evidence_AppDomainSetup.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.AppDomain>(___result);
        }


        public static System.AppDomain CreateDomain(System.String @friendlyName, System.Security.Policy.Evidence @securityInfo, System.String @appBasePath, System.String @appRelativeSearchPath, System.Boolean @shadowCopyFiles)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@friendlyName, @securityInfo, @appBasePath, @appRelativeSearchPath, @shadowCopyFiles};
            var ___result = RMCreateDomain_String_Evidence_String_String_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.AppDomain>(___result);
        }


        public static System.AppDomain CreateDomain(System.String @friendlyName, System.Security.Policy.Evidence @securityInfo, System.AppDomainSetup @info, System.Security.PermissionSet @grantSet, System.Security.Policy.StrongName[] @fullTrustAssemblies)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@friendlyName, @securityInfo, @info, @grantSet, @fullTrustAssemblies};
            var ___result = RMCreateDomain_String_Evidence_AppDomainSetup_PermissionSet_StrongNameArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.AppDomain>(___result);
        }


        public static System.AppDomainSetup CreateDomainSetup(System.String @appBasePath, System.String @appRelativeSearchPath, System.Boolean @shadowCopyFiles)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@appBasePath, @appRelativeSearchPath, @shadowCopyFiles};
            var ___result = RMCreateDomainSetup_String_String_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.AppDomainSetup>(___result);
        }


        public static System.Boolean InternalIsFinalizingForUnload(System.Int32 @domain_id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@domain_id};
            var ___result = RMInternalIsFinalizingForUnload_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean IsFinalizingForUnload()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsFinalizingForUnload.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static void InternalUnload(System.Int32 @domain_id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@domain_id};
            var ___result = RMInternalUnload_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 getDomainID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMgetDomainID.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static void Unload(System.AppDomain @domain)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@domain};
            var ___result = RMUnload_AppDomain.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetData(System.String @name, System.Object @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @data};
            var ___result = RMSetData_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetData(System.String @name, System.Object @data, System.Security.IPermission @permission)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @data, @permission};
            var ___result = RMSetData_String_Object_IPermission.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetDynamicBase(System.String @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path};
            var ___result = RMSetDynamicBase_String.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 GetCurrentThreadId()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCurrentThreadId.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public static void ValidateAssemblyName(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMValidateAssemblyName_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DoAssemblyLoad(System.Reflection.Assembly @assembly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assembly};
            var ___result = RMDoAssemblyLoad_Assembly.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.Assembly DoAssemblyResolve(System.String @name, System.Reflection.Assembly @requestingAssembly, System.Boolean @refonly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @requestingAssembly, @refonly};
            var ___result = RMDoAssemblyResolve_String_Assembly_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Assembly>(___result);
        }


        public virtual System.Reflection.Assembly DoTypeBuilderResolve(System.Reflection.Emit.TypeBuilder @tb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tb};
            var ___result = RMDoTypeBuilderResolve_TypeBuilder.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Assembly>(___result);
        }


        public virtual System.Reflection.Assembly DoTypeResolve(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMDoTypeResolve_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Assembly>(___result);
        }


        public virtual System.Reflection.Assembly DoResourceResolve(System.String @name, System.Reflection.Assembly @requesting)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @requesting};
            var ___result = RMDoResourceResolve_String_Assembly.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Assembly>(___result);
        }


        public virtual void DoDomainUnload()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDoDomainUnload.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DoUnhandledException(System.Exception @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMDoUnhandledException_Exception.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DoUnhandledException(System.UnhandledExceptionEventArgs @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RMDoUnhandledException_UnhandledExceptionEventArgs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Byte[] GetMarshalledDomainObjRef()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetMarshalledDomainObjRef.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Byte[]>(___result);
        }


        public virtual void ProcessMessageInDomain(System.Byte[] @arrRequest, Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RCADMethodCallMessage @cadMsg, out System.Byte[] @arrResponse, out Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RCADMethodReturnMessage @cadMrm)
        {
			@arrResponse = default;
			@cadMrm = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arrRequest, @cadMsg.Value, @arrResponse, @cadMrm.Value};
            var ___result = RMProcessMessageInDomain_ByteArray_CADMethodCallMessage_Out_ByteArray_Out_CADMethodReturnMessage.Invoke(___genericsType, ___parameters);
			@arrResponse = (System.Byte[])___parameters[2];
			@cadMrm = new Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RCADMethodReturnMessage(___parameters[3]);

            
        }


        public virtual System.String ApplyPolicy(System.String @assemblyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName};
            var ___result = RMApplyPolicy_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public static System.AppDomain CreateDomain(System.String @friendlyName, System.Security.Policy.Evidence @securityInfo, System.String @appBasePath, System.String @appRelativeSearchPath, System.Boolean @shadowCopyFiles, System.AppDomainInitializer @adInit, System.String[] @adInitArgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@friendlyName, @securityInfo, @appBasePath, @appRelativeSearchPath, @shadowCopyFiles, @adInit, @adInitArgs};
            var ___result = RMCreateDomain_String_Evidence_String_String_Boolean_AppDomainInitializer_StringArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.AppDomain>(___result);
        }


        public virtual System.Int32 ExecuteAssemblyByName(System.String @assemblyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName};
            var ___result = RMExecuteAssemblyByName_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 ExecuteAssemblyByName(System.String @assemblyName, System.Security.Policy.Evidence @assemblySecurity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @assemblySecurity};
            var ___result = RMExecuteAssemblyByName_String_Evidence.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 ExecuteAssemblyByName(System.String @assemblyName, System.Security.Policy.Evidence @assemblySecurity, System.String[] @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @assemblySecurity, @args};
            var ___result = RMExecuteAssemblyByName_String_Evidence_StringArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 ExecuteAssemblyByName(System.Reflection.AssemblyName @assemblyName, System.Security.Policy.Evidence @assemblySecurity, System.String[] @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @assemblySecurity, @args};
            var ___result = RMExecuteAssemblyByName_AssemblyName_Evidence_StringArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 ExecuteAssemblyByName(System.String @assemblyName, System.String[] @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @args};
            var ___result = RMExecuteAssemblyByName_String_StringArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 ExecuteAssemblyByName(System.Reflection.AssemblyName @assemblyName, System.String[] @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @args};
            var ___result = RMExecuteAssemblyByName_AssemblyName_StringArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean IsDefaultAppDomain()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsDefaultAppDomain.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Reflection.Assembly[] ReflectionOnlyGetAssemblies()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReflectionOnlyGetAssemblies.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Assembly[]>(___result);
        }


        public virtual void System__2___AppDomain__2__GetIDsOfNames(in System.Guid @riid, System.IntPtr @rgszNames, System.UInt32 @cNames, System.UInt32 @lcid, System.IntPtr @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RMSystem__2___AppDomain__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2___AppDomain__2__GetTypeInfo(System.UInt32 @iTInfo, System.UInt32 @lcid, System.IntPtr @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RMSystem__2___AppDomain__2__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2___AppDomain__2__GetTypeInfoCount(out System.UInt32 @pcTInfo)
        {
			@pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RMSystem__2___AppDomain__2__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			@pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__2___AppDomain__2__Invoke(System.UInt32 @dispIdMember, in System.Guid @riid, System.UInt32 @lcid, System.Int16 @wFlags, System.IntPtr @pDispParams, System.IntPtr @pVarResult, System.IntPtr @pExcepInfo, System.IntPtr @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RMSystem__2___AppDomain__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RSystem.RBoolean> IsCompatibilitySwitchSet(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMIsCompatibilitySwitchSet_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RSystem.RBoolean>>(___result);
        }


        public virtual void SetCompatibilitySwitch(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetCompatibilitySwitch_String.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
