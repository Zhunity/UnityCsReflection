
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.AppDomainSetup
	/// </summary>
    public partial class RAppDomainSetup : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.AppDomainSetup);
            }
        }

        public RAppDomainSetup() : base("System.AppDomainSetup")
        {
        }

        public RAppDomainSetup(System.Object instance) : base("System.AppDomainSetup")
		{
            SetInstance(instance);
		}

        public RAppDomainSetup(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAppDomainSetup(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.String application_base
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fapplication_base;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFapplication_base
		{
			get
			{
				if(r_Fapplication_base == null)
				{
					r_Fapplication_base = new(this, "application_base");
				}
				return r_Fapplication_base;
			}
		}

		/// <summary>
		/// System.String application_name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fapplication_name;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFapplication_name
		{
			get
			{
				if(r_Fapplication_name == null)
				{
					r_Fapplication_name = new(this, "application_name");
				}
				return r_Fapplication_name;
			}
		}

		/// <summary>
		/// System.String cache_path
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fcache_path;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFcache_path
		{
			get
			{
				if(r_Fcache_path == null)
				{
					r_Fcache_path = new(this, "cache_path");
				}
				return r_Fcache_path;
			}
		}

		/// <summary>
		/// System.String configuration_file
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fconfiguration_file;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFconfiguration_file
		{
			get
			{
				if(r_Fconfiguration_file == null)
				{
					r_Fconfiguration_file = new(this, "configuration_file");
				}
				return r_Fconfiguration_file;
			}
		}

		/// <summary>
		/// System.String dynamic_base
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fdynamic_base;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFdynamic_base
		{
			get
			{
				if(r_Fdynamic_base == null)
				{
					r_Fdynamic_base = new(this, "dynamic_base");
				}
				return r_Fdynamic_base;
			}
		}

		/// <summary>
		/// System.String license_file
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Flicense_file;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFlicense_file
		{
			get
			{
				if(r_Flicense_file == null)
				{
					r_Flicense_file = new(this, "license_file");
				}
				return r_Flicense_file;
			}
		}

		/// <summary>
		/// System.String private_bin_path
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fprivate_bin_path;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFprivate_bin_path
		{
			get
			{
				if(r_Fprivate_bin_path == null)
				{
					r_Fprivate_bin_path = new(this, "private_bin_path");
				}
				return r_Fprivate_bin_path;
			}
		}

		/// <summary>
		/// System.String private_bin_path_probe
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fprivate_bin_path_probe;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFprivate_bin_path_probe
		{
			get
			{
				if(r_Fprivate_bin_path_probe == null)
				{
					r_Fprivate_bin_path_probe = new(this, "private_bin_path_probe");
				}
				return r_Fprivate_bin_path_probe;
			}
		}

		/// <summary>
		/// System.String shadow_copy_directories
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fshadow_copy_directories;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFshadow_copy_directories
		{
			get
			{
				if(r_Fshadow_copy_directories == null)
				{
					r_Fshadow_copy_directories = new(this, "shadow_copy_directories");
				}
				return r_Fshadow_copy_directories;
			}
		}

		/// <summary>
		/// System.String shadow_copy_files
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fshadow_copy_files;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFshadow_copy_files
		{
			get
			{
				if(r_Fshadow_copy_files == null)
				{
					r_Fshadow_copy_files = new(this, "shadow_copy_files");
				}
				return r_Fshadow_copy_files;
			}
		}

		/// <summary>
		/// System.Boolean publisher_policy
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fpublisher_policy;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFpublisher_policy
		{
			get
			{
				if(r_Fpublisher_policy == null)
				{
					r_Fpublisher_policy = new(this, "publisher_policy");
				}
				return r_Fpublisher_policy;
			}
		}

		/// <summary>
		/// System.Boolean path_changed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fpath_changed;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFpath_changed
		{
			get
			{
				if(r_Fpath_changed == null)
				{
					r_Fpath_changed = new(this, "path_changed");
				}
				return r_Fpath_changed;
			}
		}

		/// <summary>
		/// System.LoaderOptimization loader_optimization
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RLoaderOptimization r_Floader_optimization;
		public virtual Hvak.Editor.Refleaction.RSystem.RLoaderOptimization RFloader_optimization
		{
			get
			{
				if(r_Floader_optimization == null)
				{
					r_Floader_optimization = new(this, "loader_optimization");
				}
				return r_Floader_optimization;
			}
		}

		/// <summary>
		/// System.Boolean disallow_binding_redirects
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fdisallow_binding_redirects;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFdisallow_binding_redirects
		{
			get
			{
				if(r_Fdisallow_binding_redirects == null)
				{
					r_Fdisallow_binding_redirects = new(this, "disallow_binding_redirects");
				}
				return r_Fdisallow_binding_redirects;
			}
		}

		/// <summary>
		/// System.Boolean disallow_code_downloads
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fdisallow_code_downloads;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFdisallow_code_downloads
		{
			get
			{
				if(r_Fdisallow_code_downloads == null)
				{
					r_Fdisallow_code_downloads = new(this, "disallow_code_downloads");
				}
				return r_Fdisallow_code_downloads;
			}
		}

		/// <summary>
		/// System.Runtime.Hosting.ActivationArguments _activationArguments
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RHosting.RActivationArguments r_F_activationArguments;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RHosting.RActivationArguments RF_activationArguments
		{
			get
			{
				if(r_F_activationArguments == null)
				{
					r_F_activationArguments = new(this, "_activationArguments");
				}
				return r_F_activationArguments;
			}
		}

		/// <summary>
		/// System.AppDomainInitializer domain_initializer
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAppDomainInitializer r_Fdomain_initializer;
		public virtual Hvak.Editor.Refleaction.RSystem.RAppDomainInitializer RFdomain_initializer
		{
			get
			{
				if(r_Fdomain_initializer == null)
				{
					r_Fdomain_initializer = new(this, "domain_initializer");
				}
				return r_Fdomain_initializer;
			}
		}

		/// <summary>
		/// System.Security.Policy.ApplicationTrust application_trust
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.RApplicationTrust r_Fapplication_trust;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.RApplicationTrust RFapplication_trust
		{
			get
			{
				if(r_Fapplication_trust == null)
				{
					r_Fapplication_trust = new(this, "application_trust");
				}
				return r_Fapplication_trust;
			}
		}

		/// <summary>
		/// System.String[] domain_initializer_args
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fdomain_initializer_args;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFdomain_initializer_args
		{
			get
			{
				if(r_Fdomain_initializer_args == null)
				{
					r_Fdomain_initializer_args = new(this, "domain_initializer_args");
				}
				return r_Fdomain_initializer_args;
			}
		}

		/// <summary>
		/// System.Boolean disallow_appbase_probe
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fdisallow_appbase_probe;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFdisallow_appbase_probe
		{
			get
			{
				if(r_Fdisallow_appbase_probe == null)
				{
					r_Fdisallow_appbase_probe = new(this, "disallow_appbase_probe");
				}
				return r_Fdisallow_appbase_probe;
			}
		}

		/// <summary>
		/// System.Byte[] configuration_bytes
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> r_Fconfiguration_bytes;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> RFconfiguration_bytes
		{
			get
			{
				if(r_Fconfiguration_bytes == null)
				{
					r_Fconfiguration_bytes = new(this, "configuration_bytes");
				}
				return r_Fconfiguration_bytes;
			}
		}

		/// <summary>
		/// System.Byte[] serialized_non_primitives
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> r_Fserialized_non_primitives;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> RFserialized_non_primitives
		{
			get
			{
				if(r_Fserialized_non_primitives == null)
				{
					r_Fserialized_non_primitives = new(this, "serialized_non_primitives");
				}
				return r_Fserialized_non_primitives;
			}
		}

		/// <summary>
		/// System.String manager_assembly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fmanager_assembly;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFmanager_assembly
		{
			get
			{
				if(r_Fmanager_assembly == null)
				{
					r_Fmanager_assembly = new(this, "manager_assembly");
				}
				return r_Fmanager_assembly;
			}
		}

		/// <summary>
		/// System.String manager_type
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fmanager_type;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFmanager_type
		{
			get
			{
				if(r_Fmanager_type == null)
				{
					r_Fmanager_type = new(this, "manager_type");
				}
				return r_Fmanager_type;
			}
		}

		/// <summary>
		/// System.String[] partial_visible_assemblies
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fpartial_visible_assemblies;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFpartial_visible_assemblies
		{
			get
			{
				if(r_Fpartial_visible_assemblies == null)
				{
					r_Fpartial_visible_assemblies = new(this, "partial_visible_assemblies");
				}
				return r_Fpartial_visible_assemblies;
			}
		}

		/// <summary>
		/// System.String <TargetFrameworkName>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F__0__TargetFrameworkName__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF__0__TargetFrameworkName__1__k__BackingField
		{
			get
			{
				if(r_F__0__TargetFrameworkName__1__k__BackingField == null)
				{
					r_F__0__TargetFrameworkName__1__k__BackingField = new(this, "<TargetFrameworkName>k__BackingField");
				}
				return r_F__0__TargetFrameworkName__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String ApplicationBase
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PApplicationBase;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPApplicationBase
		{
			get
			{
				if(r_PApplicationBase == null)
				{
					r_PApplicationBase = new(this, "ApplicationBase", -1);
				}
				return r_PApplicationBase;
			}
		}

		/// <summary>
		/// System.String ApplicationName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PApplicationName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPApplicationName
		{
			get
			{
				if(r_PApplicationName == null)
				{
					r_PApplicationName = new(this, "ApplicationName", -1);
				}
				return r_PApplicationName;
			}
		}

		/// <summary>
		/// System.String CachePath
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PCachePath;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPCachePath
		{
			get
			{
				if(r_PCachePath == null)
				{
					r_PCachePath = new(this, "CachePath", -1);
				}
				return r_PCachePath;
			}
		}

		/// <summary>
		/// System.String ConfigurationFile
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PConfigurationFile;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPConfigurationFile
		{
			get
			{
				if(r_PConfigurationFile == null)
				{
					r_PConfigurationFile = new(this, "ConfigurationFile", -1);
				}
				return r_PConfigurationFile;
			}
		}

		/// <summary>
		/// Boolean DisallowPublisherPolicy
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PDisallowPublisherPolicy;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPDisallowPublisherPolicy
		{
			get
			{
				if(r_PDisallowPublisherPolicy == null)
				{
					r_PDisallowPublisherPolicy = new(this, "DisallowPublisherPolicy", -1);
				}
				return r_PDisallowPublisherPolicy;
			}
		}

		/// <summary>
		/// System.String DynamicBase
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PDynamicBase;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPDynamicBase
		{
			get
			{
				if(r_PDynamicBase == null)
				{
					r_PDynamicBase = new(this, "DynamicBase", -1);
				}
				return r_PDynamicBase;
			}
		}

		/// <summary>
		/// System.String LicenseFile
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PLicenseFile;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPLicenseFile
		{
			get
			{
				if(r_PLicenseFile == null)
				{
					r_PLicenseFile = new(this, "LicenseFile", -1);
				}
				return r_PLicenseFile;
			}
		}

		/// <summary>
		/// System.LoaderOptimization LoaderOptimization
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RLoaderOptimization r_PLoaderOptimization;
		public virtual Hvak.Editor.Refleaction.RSystem.RLoaderOptimization RPLoaderOptimization
		{
			get
			{
				if(r_PLoaderOptimization == null)
				{
					r_PLoaderOptimization = new(this, "LoaderOptimization", -1);
				}
				return r_PLoaderOptimization;
			}
		}

		/// <summary>
		/// System.String AppDomainManagerAssembly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PAppDomainManagerAssembly;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPAppDomainManagerAssembly
		{
			get
			{
				if(r_PAppDomainManagerAssembly == null)
				{
					r_PAppDomainManagerAssembly = new(this, "AppDomainManagerAssembly", -1);
				}
				return r_PAppDomainManagerAssembly;
			}
		}

		/// <summary>
		/// System.String AppDomainManagerType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PAppDomainManagerType;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPAppDomainManagerType
		{
			get
			{
				if(r_PAppDomainManagerType == null)
				{
					r_PAppDomainManagerType = new(this, "AppDomainManagerType", -1);
				}
				return r_PAppDomainManagerType;
			}
		}

		/// <summary>
		/// System.String[] PartialTrustVisibleAssemblies
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_PPartialTrustVisibleAssemblies;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPPartialTrustVisibleAssemblies
		{
			get
			{
				if(r_PPartialTrustVisibleAssemblies == null)
				{
					r_PPartialTrustVisibleAssemblies = new(this, "PartialTrustVisibleAssemblies", -1);
				}
				return r_PPartialTrustVisibleAssemblies;
			}
		}

		/// <summary>
		/// System.String PrivateBinPath
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PPrivateBinPath;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPPrivateBinPath
		{
			get
			{
				if(r_PPrivateBinPath == null)
				{
					r_PPrivateBinPath = new(this, "PrivateBinPath", -1);
				}
				return r_PPrivateBinPath;
			}
		}

		/// <summary>
		/// System.String PrivateBinPathProbe
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PPrivateBinPathProbe;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPPrivateBinPathProbe
		{
			get
			{
				if(r_PPrivateBinPathProbe == null)
				{
					r_PPrivateBinPathProbe = new(this, "PrivateBinPathProbe", -1);
				}
				return r_PPrivateBinPathProbe;
			}
		}

		/// <summary>
		/// System.String ShadowCopyDirectories
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PShadowCopyDirectories;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPShadowCopyDirectories
		{
			get
			{
				if(r_PShadowCopyDirectories == null)
				{
					r_PShadowCopyDirectories = new(this, "ShadowCopyDirectories", -1);
				}
				return r_PShadowCopyDirectories;
			}
		}

		/// <summary>
		/// System.String ShadowCopyFiles
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PShadowCopyFiles;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPShadowCopyFiles
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
		/// Boolean DisallowBindingRedirects
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PDisallowBindingRedirects;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPDisallowBindingRedirects
		{
			get
			{
				if(r_PDisallowBindingRedirects == null)
				{
					r_PDisallowBindingRedirects = new(this, "DisallowBindingRedirects", -1);
				}
				return r_PDisallowBindingRedirects;
			}
		}

		/// <summary>
		/// Boolean DisallowCodeDownload
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PDisallowCodeDownload;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPDisallowCodeDownload
		{
			get
			{
				if(r_PDisallowCodeDownload == null)
				{
					r_PDisallowCodeDownload = new(this, "DisallowCodeDownload", -1);
				}
				return r_PDisallowCodeDownload;
			}
		}

		/// <summary>
		/// System.String TargetFrameworkName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PTargetFrameworkName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPTargetFrameworkName
		{
			get
			{
				if(r_PTargetFrameworkName == null)
				{
					r_PTargetFrameworkName = new(this, "TargetFrameworkName", -1);
				}
				return r_PTargetFrameworkName;
			}
		}

		/// <summary>
		/// System.Runtime.Hosting.ActivationArguments ActivationArguments
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RHosting.RActivationArguments r_PActivationArguments;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RHosting.RActivationArguments RPActivationArguments
		{
			get
			{
				if(r_PActivationArguments == null)
				{
					r_PActivationArguments = new(this, "ActivationArguments", -1);
				}
				return r_PActivationArguments;
			}
		}

		/// <summary>
		/// System.AppDomainInitializer AppDomainInitializer
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAppDomainInitializer r_PAppDomainInitializer;
		public virtual Hvak.Editor.Refleaction.RSystem.RAppDomainInitializer RPAppDomainInitializer
		{
			get
			{
				if(r_PAppDomainInitializer == null)
				{
					r_PAppDomainInitializer = new(this, "AppDomainInitializer", -1);
				}
				return r_PAppDomainInitializer;
			}
		}

		/// <summary>
		/// System.String[] AppDomainInitializerArguments
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_PAppDomainInitializerArguments;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPAppDomainInitializerArguments
		{
			get
			{
				if(r_PAppDomainInitializerArguments == null)
				{
					r_PAppDomainInitializerArguments = new(this, "AppDomainInitializerArguments", -1);
				}
				return r_PAppDomainInitializerArguments;
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
		/// Boolean DisallowApplicationBaseProbing
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PDisallowApplicationBaseProbing;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPDisallowApplicationBaseProbing
		{
			get
			{
				if(r_PDisallowApplicationBaseProbing == null)
				{
					r_PDisallowApplicationBaseProbing = new(this, "DisallowApplicationBaseProbing", -1);
				}
				return r_PDisallowApplicationBaseProbing;
			}
		}

		/// <summary>
		/// Boolean SandboxInterop
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PSandboxInterop;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPSandboxInterop
		{
			get
			{
				if(r_PSandboxInterop == null)
				{
					r_PSandboxInterop = new(this, "SandboxInterop", -1);
				}
				return r_PSandboxInterop;
			}
		}

		/// <summary>
		/// System.String GetAppBase(System.String)
		/// </summary>
		protected static RMethod r_MGetAppBase_String;
		public static RMethod RMGetAppBase_String
		{
			get
			{
				if(r_MGetAppBase_String == null)
				{
					r_MGetAppBase_String = new(Type, "GetAppBase", 0, typeof(System.String));
				}
				return r_MGetAppBase_String;
			}
		}

		/// <summary>
		/// Byte[] GetConfigurationBytes()
		/// </summary>
		protected RMethod r_MGetConfigurationBytes;
		public virtual RMethod RMGetConfigurationBytes
		{
			get
			{
				if(r_MGetConfigurationBytes == null)
				{
					r_MGetConfigurationBytes = new(this, "GetConfigurationBytes", 0);
				}
				return r_MGetConfigurationBytes;
			}
		}

		/// <summary>
		/// Void SetConfigurationBytes(Byte[])
		/// </summary>
		protected RMethod r_MSetConfigurationBytes_ByteArray;
		public virtual RMethod RMSetConfigurationBytes_ByteArray
		{
			get
			{
				if(r_MSetConfigurationBytes_ByteArray == null)
				{
					r_MSetConfigurationBytes_ByteArray = new(this, "SetConfigurationBytes", 0, typeof(System.Byte).MakeArrayType());
				}
				return r_MSetConfigurationBytes_ByteArray;
			}
		}

		/// <summary>
		/// Void DeserializeNonPrimitives()
		/// </summary>
		protected RMethod r_MDeserializeNonPrimitives;
		public virtual RMethod RMDeserializeNonPrimitives
		{
			get
			{
				if(r_MDeserializeNonPrimitives == null)
				{
					r_MDeserializeNonPrimitives = new(this, "DeserializeNonPrimitives", 0);
				}
				return r_MDeserializeNonPrimitives;
			}
		}

		/// <summary>
		/// Void SerializeNonPrimitives()
		/// </summary>
		protected RMethod r_MSerializeNonPrimitives;
		public virtual RMethod RMSerializeNonPrimitives
		{
			get
			{
				if(r_MSerializeNonPrimitives == null)
				{
					r_MSerializeNonPrimitives = new(this, "SerializeNonPrimitives", 0);
				}
				return r_MSerializeNonPrimitives;
			}
		}

		/// <summary>
		/// Void SetCompatibilitySwitches(System.Collections.Generic.IEnumerable`1[System.String])
		/// </summary>
		protected RMethod r_MSetCompatibilitySwitches_IEnumerable_d_String_p_;
		public virtual RMethod RMSetCompatibilitySwitches_IEnumerable_d_String_p_
		{
			get
			{
				if(r_MSetCompatibilitySwitches_IEnumerable_d_String_p_ == null)
				{
					r_MSetCompatibilitySwitches_IEnumerable_d_String_p_ = new(this, "SetCompatibilitySwitches", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType(typeof(System.String)));
				}
				return r_MSetCompatibilitySwitches_IEnumerable_d_String_p_;
			}
		}

		/// <summary>
		/// Void SetNativeFunction(System.String, Int32, IntPtr)
		/// </summary>
		protected RMethod r_MSetNativeFunction_String_Int32_IntPtr;
		public virtual RMethod RMSetNativeFunction_String_Int32_IntPtr
		{
			get
			{
				if(r_MSetNativeFunction_String_Int32_IntPtr == null)
				{
					r_MSetNativeFunction_String_Int32_IntPtr = new(this, "SetNativeFunction", 0, typeof(System.String), typeof(System.Int32), typeof(System.IntPtr));
				}
				return r_MSetNativeFunction_String_Int32_IntPtr;
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


        public static System.String GetAppBase(System.String @appBase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@appBase};
            var ___result = RMGetAppBase_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Byte[] GetConfigurationBytes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetConfigurationBytes.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Byte[]>(___result);
        }


        public virtual void SetConfigurationBytes(System.Byte[] @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetConfigurationBytes_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DeserializeNonPrimitives()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDeserializeNonPrimitives.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SerializeNonPrimitives()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSerializeNonPrimitives.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCompatibilitySwitches(System.Collections.Generic.IEnumerable<System.String> @switches)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@switches};
            var ___result = RMSetCompatibilitySwitches_IEnumerable_d_String_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetNativeFunction(System.String @functionName, System.Int32 @functionVersion, System.IntPtr @functionPointer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@functionName, @functionVersion, @functionPointer};
            var ___result = RMSetNativeFunction_String_Int32_IntPtr.Invoke(___genericsType, ___parameters);

            
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
