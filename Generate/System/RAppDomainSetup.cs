using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.AppDomainSetup
	/// </summary>
    public partial class RAppDomainSetup : RMember //
    {

		/// <summary>
		/// System.String application_base
		/// </summary>
		protected RField r_application_base;
		public virtual RField Rapplication_base
		{
			get
			{
				if(r_application_base == null)
				{
					r_application_base = new(this, "application_base");
					r_application_base.SetBelong(this.instance);
				}
				return r_application_base;
			}
		}

		/// <summary>
		/// System.String application_name
		/// </summary>
		protected RField r_application_name;
		public virtual RField Rapplication_name
		{
			get
			{
				if(r_application_name == null)
				{
					r_application_name = new(this, "application_name");
					r_application_name.SetBelong(this.instance);
				}
				return r_application_name;
			}
		}

		/// <summary>
		/// System.String cache_path
		/// </summary>
		protected RField r_cache_path;
		public virtual RField Rcache_path
		{
			get
			{
				if(r_cache_path == null)
				{
					r_cache_path = new(this, "cache_path");
					r_cache_path.SetBelong(this.instance);
				}
				return r_cache_path;
			}
		}

		/// <summary>
		/// System.String configuration_file
		/// </summary>
		protected RField r_configuration_file;
		public virtual RField Rconfiguration_file
		{
			get
			{
				if(r_configuration_file == null)
				{
					r_configuration_file = new(this, "configuration_file");
					r_configuration_file.SetBelong(this.instance);
				}
				return r_configuration_file;
			}
		}

		/// <summary>
		/// System.String dynamic_base
		/// </summary>
		protected RField r_dynamic_base;
		public virtual RField Rdynamic_base
		{
			get
			{
				if(r_dynamic_base == null)
				{
					r_dynamic_base = new(this, "dynamic_base");
					r_dynamic_base.SetBelong(this.instance);
				}
				return r_dynamic_base;
			}
		}

		/// <summary>
		/// System.String license_file
		/// </summary>
		protected RField r_license_file;
		public virtual RField Rlicense_file
		{
			get
			{
				if(r_license_file == null)
				{
					r_license_file = new(this, "license_file");
					r_license_file.SetBelong(this.instance);
				}
				return r_license_file;
			}
		}

		/// <summary>
		/// System.String private_bin_path
		/// </summary>
		protected RField r_private_bin_path;
		public virtual RField Rprivate_bin_path
		{
			get
			{
				if(r_private_bin_path == null)
				{
					r_private_bin_path = new(this, "private_bin_path");
					r_private_bin_path.SetBelong(this.instance);
				}
				return r_private_bin_path;
			}
		}

		/// <summary>
		/// System.String private_bin_path_probe
		/// </summary>
		protected RField r_private_bin_path_probe;
		public virtual RField Rprivate_bin_path_probe
		{
			get
			{
				if(r_private_bin_path_probe == null)
				{
					r_private_bin_path_probe = new(this, "private_bin_path_probe");
					r_private_bin_path_probe.SetBelong(this.instance);
				}
				return r_private_bin_path_probe;
			}
		}

		/// <summary>
		/// System.String shadow_copy_directories
		/// </summary>
		protected RField r_shadow_copy_directories;
		public virtual RField Rshadow_copy_directories
		{
			get
			{
				if(r_shadow_copy_directories == null)
				{
					r_shadow_copy_directories = new(this, "shadow_copy_directories");
					r_shadow_copy_directories.SetBelong(this.instance);
				}
				return r_shadow_copy_directories;
			}
		}

		/// <summary>
		/// System.String shadow_copy_files
		/// </summary>
		protected RField r_shadow_copy_files;
		public virtual RField Rshadow_copy_files
		{
			get
			{
				if(r_shadow_copy_files == null)
				{
					r_shadow_copy_files = new(this, "shadow_copy_files");
					r_shadow_copy_files.SetBelong(this.instance);
				}
				return r_shadow_copy_files;
			}
		}

		/// <summary>
		/// System.Boolean publisher_policy
		/// </summary>
		protected RField r_publisher_policy;
		public virtual RField Rpublisher_policy
		{
			get
			{
				if(r_publisher_policy == null)
				{
					r_publisher_policy = new(this, "publisher_policy");
					r_publisher_policy.SetBelong(this.instance);
				}
				return r_publisher_policy;
			}
		}

		/// <summary>
		/// System.Boolean path_changed
		/// </summary>
		protected RField r_path_changed;
		public virtual RField Rpath_changed
		{
			get
			{
				if(r_path_changed == null)
				{
					r_path_changed = new(this, "path_changed");
					r_path_changed.SetBelong(this.instance);
				}
				return r_path_changed;
			}
		}

		/// <summary>
		/// System.LoaderOptimization loader_optimization
		/// </summary>
		protected RField r_loader_optimization;
		public virtual RField Rloader_optimization
		{
			get
			{
				if(r_loader_optimization == null)
				{
					r_loader_optimization = new(this, "loader_optimization");
					r_loader_optimization.SetBelong(this.instance);
				}
				return r_loader_optimization;
			}
		}

		/// <summary>
		/// System.Boolean disallow_binding_redirects
		/// </summary>
		protected RField r_disallow_binding_redirects;
		public virtual RField Rdisallow_binding_redirects
		{
			get
			{
				if(r_disallow_binding_redirects == null)
				{
					r_disallow_binding_redirects = new(this, "disallow_binding_redirects");
					r_disallow_binding_redirects.SetBelong(this.instance);
				}
				return r_disallow_binding_redirects;
			}
		}

		/// <summary>
		/// System.Boolean disallow_code_downloads
		/// </summary>
		protected RField r_disallow_code_downloads;
		public virtual RField Rdisallow_code_downloads
		{
			get
			{
				if(r_disallow_code_downloads == null)
				{
					r_disallow_code_downloads = new(this, "disallow_code_downloads");
					r_disallow_code_downloads.SetBelong(this.instance);
				}
				return r_disallow_code_downloads;
			}
		}

		/// <summary>
		/// System.Runtime.Hosting.ActivationArguments _activationArguments
		/// </summary>
		protected RSystem.RRuntime.RHosting.RActivationArguments r__activationArguments;
		public virtual RSystem.RRuntime.RHosting.RActivationArguments R_activationArguments
		{
			get
			{
				if(r__activationArguments == null)
				{
					r__activationArguments = new(this, "_activationArguments");
					r__activationArguments.SetBelong(this.instance);
				}
				return r__activationArguments;
			}
		}

		/// <summary>
		/// System.AppDomainInitializer domain_initializer
		/// </summary>
		protected RSystem.RAppDomainInitializer r_domain_initializer;
		public virtual RSystem.RAppDomainInitializer Rdomain_initializer
		{
			get
			{
				if(r_domain_initializer == null)
				{
					r_domain_initializer = new(this, "domain_initializer");
					r_domain_initializer.SetBelong(this.instance);
				}
				return r_domain_initializer;
			}
		}

		/// <summary>
		/// System.Security.Policy.ApplicationTrust application_trust
		/// </summary>
		protected RSystem.RSecurity.RPolicy.RApplicationTrust r_application_trust;
		public virtual RSystem.RSecurity.RPolicy.RApplicationTrust Rapplication_trust
		{
			get
			{
				if(r_application_trust == null)
				{
					r_application_trust = new(this, "application_trust");
					r_application_trust.SetBelong(this.instance);
				}
				return r_application_trust;
			}
		}

		/// <summary>
		/// System.String[] domain_initializer_args
		/// </summary>
		protected RFieldArray<RField> r_domain_initializer_args;
		public virtual RFieldArray<RField> Rdomain_initializer_args
		{
			get
			{
				if(r_domain_initializer_args == null)
				{
					r_domain_initializer_args = new(this, "domain_initializer_args");
					r_domain_initializer_args.SetBelong(this.instance);
				}
				return r_domain_initializer_args;
			}
		}

		/// <summary>
		/// System.Boolean disallow_appbase_probe
		/// </summary>
		protected RField r_disallow_appbase_probe;
		public virtual RField Rdisallow_appbase_probe
		{
			get
			{
				if(r_disallow_appbase_probe == null)
				{
					r_disallow_appbase_probe = new(this, "disallow_appbase_probe");
					r_disallow_appbase_probe.SetBelong(this.instance);
				}
				return r_disallow_appbase_probe;
			}
		}

		/// <summary>
		/// System.Byte[] configuration_bytes
		/// </summary>
		protected RFieldArray<RField> r_configuration_bytes;
		public virtual RFieldArray<RField> Rconfiguration_bytes
		{
			get
			{
				if(r_configuration_bytes == null)
				{
					r_configuration_bytes = new(this, "configuration_bytes");
					r_configuration_bytes.SetBelong(this.instance);
				}
				return r_configuration_bytes;
			}
		}

		/// <summary>
		/// System.Byte[] serialized_non_primitives
		/// </summary>
		protected RFieldArray<RField> r_serialized_non_primitives;
		public virtual RFieldArray<RField> Rserialized_non_primitives
		{
			get
			{
				if(r_serialized_non_primitives == null)
				{
					r_serialized_non_primitives = new(this, "serialized_non_primitives");
					r_serialized_non_primitives.SetBelong(this.instance);
				}
				return r_serialized_non_primitives;
			}
		}

		/// <summary>
		/// System.String manager_assembly
		/// </summary>
		protected RField r_manager_assembly;
		public virtual RField Rmanager_assembly
		{
			get
			{
				if(r_manager_assembly == null)
				{
					r_manager_assembly = new(this, "manager_assembly");
					r_manager_assembly.SetBelong(this.instance);
				}
				return r_manager_assembly;
			}
		}

		/// <summary>
		/// System.String manager_type
		/// </summary>
		protected RField r_manager_type;
		public virtual RField Rmanager_type
		{
			get
			{
				if(r_manager_type == null)
				{
					r_manager_type = new(this, "manager_type");
					r_manager_type.SetBelong(this.instance);
				}
				return r_manager_type;
			}
		}

		/// <summary>
		/// System.String[] partial_visible_assemblies
		/// </summary>
		protected RFieldArray<RField> r_partial_visible_assemblies;
		public virtual RFieldArray<RField> Rpartial_visible_assemblies
		{
			get
			{
				if(r_partial_visible_assemblies == null)
				{
					r_partial_visible_assemblies = new(this, "partial_visible_assemblies");
					r_partial_visible_assemblies.SetBelong(this.instance);
				}
				return r_partial_visible_assemblies;
			}
		}

		/// <summary>
		/// System.String <TargetFrameworkName>k__BackingField
		/// </summary>
		protected RField r___0__TargetFrameworkName__1__k__BackingField;
		public virtual RField R__0__TargetFrameworkName__1__k__BackingField
		{
			get
			{
				if(r___0__TargetFrameworkName__1__k__BackingField == null)
				{
					r___0__TargetFrameworkName__1__k__BackingField = new(this, "<TargetFrameworkName>k__BackingField");
					r___0__TargetFrameworkName__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__TargetFrameworkName__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String ApplicationBase
		/// </summary>
		protected RProperty r_ApplicationBase;
		public virtual RProperty RApplicationBase
		{
			get
			{
				if(r_ApplicationBase == null)
				{
					r_ApplicationBase = new(this, "ApplicationBase", -1);
					r_ApplicationBase.SetBelong(this.instance);
				}
				return r_ApplicationBase;
			}
		}

		/// <summary>
		/// System.String ApplicationName
		/// </summary>
		protected RProperty r_ApplicationName;
		public virtual RProperty RApplicationName
		{
			get
			{
				if(r_ApplicationName == null)
				{
					r_ApplicationName = new(this, "ApplicationName", -1);
					r_ApplicationName.SetBelong(this.instance);
				}
				return r_ApplicationName;
			}
		}

		/// <summary>
		/// System.String CachePath
		/// </summary>
		protected RProperty r_CachePath;
		public virtual RProperty RCachePath
		{
			get
			{
				if(r_CachePath == null)
				{
					r_CachePath = new(this, "CachePath", -1);
					r_CachePath.SetBelong(this.instance);
				}
				return r_CachePath;
			}
		}

		/// <summary>
		/// System.String ConfigurationFile
		/// </summary>
		protected RProperty r_ConfigurationFile;
		public virtual RProperty RConfigurationFile
		{
			get
			{
				if(r_ConfigurationFile == null)
				{
					r_ConfigurationFile = new(this, "ConfigurationFile", -1);
					r_ConfigurationFile.SetBelong(this.instance);
				}
				return r_ConfigurationFile;
			}
		}

		/// <summary>
		/// Boolean DisallowPublisherPolicy
		/// </summary>
		protected RProperty r_DisallowPublisherPolicy;
		public virtual RProperty RDisallowPublisherPolicy
		{
			get
			{
				if(r_DisallowPublisherPolicy == null)
				{
					r_DisallowPublisherPolicy = new(this, "DisallowPublisherPolicy", -1);
					r_DisallowPublisherPolicy.SetBelong(this.instance);
				}
				return r_DisallowPublisherPolicy;
			}
		}

		/// <summary>
		/// System.String DynamicBase
		/// </summary>
		protected RProperty r_DynamicBase;
		public virtual RProperty RDynamicBase
		{
			get
			{
				if(r_DynamicBase == null)
				{
					r_DynamicBase = new(this, "DynamicBase", -1);
					r_DynamicBase.SetBelong(this.instance);
				}
				return r_DynamicBase;
			}
		}

		/// <summary>
		/// System.String LicenseFile
		/// </summary>
		protected RProperty r_LicenseFile;
		public virtual RProperty RLicenseFile
		{
			get
			{
				if(r_LicenseFile == null)
				{
					r_LicenseFile = new(this, "LicenseFile", -1);
					r_LicenseFile.SetBelong(this.instance);
				}
				return r_LicenseFile;
			}
		}

		/// <summary>
		/// System.LoaderOptimization LoaderOptimization
		/// </summary>
		protected RProperty r_LoaderOptimization;
		public virtual RProperty RLoaderOptimization
		{
			get
			{
				if(r_LoaderOptimization == null)
				{
					r_LoaderOptimization = new(this, "LoaderOptimization", -1);
					r_LoaderOptimization.SetBelong(this.instance);
				}
				return r_LoaderOptimization;
			}
		}

		/// <summary>
		/// System.String AppDomainManagerAssembly
		/// </summary>
		protected RProperty r_AppDomainManagerAssembly;
		public virtual RProperty RAppDomainManagerAssembly
		{
			get
			{
				if(r_AppDomainManagerAssembly == null)
				{
					r_AppDomainManagerAssembly = new(this, "AppDomainManagerAssembly", -1);
					r_AppDomainManagerAssembly.SetBelong(this.instance);
				}
				return r_AppDomainManagerAssembly;
			}
		}

		/// <summary>
		/// System.String AppDomainManagerType
		/// </summary>
		protected RProperty r_AppDomainManagerType;
		public virtual RProperty RAppDomainManagerType
		{
			get
			{
				if(r_AppDomainManagerType == null)
				{
					r_AppDomainManagerType = new(this, "AppDomainManagerType", -1);
					r_AppDomainManagerType.SetBelong(this.instance);
				}
				return r_AppDomainManagerType;
			}
		}

		/// <summary>
		/// System.String[] PartialTrustVisibleAssemblies
		/// </summary>
		protected RPropertyArray<RProperty> r_PartialTrustVisibleAssemblies;
		public virtual RPropertyArray<RProperty> RPartialTrustVisibleAssemblies
		{
			get
			{
				if(r_PartialTrustVisibleAssemblies == null)
				{
					r_PartialTrustVisibleAssemblies = new(this, "PartialTrustVisibleAssemblies", -1);
					r_PartialTrustVisibleAssemblies.SetBelong(this.instance);
				}
				return r_PartialTrustVisibleAssemblies;
			}
		}

		/// <summary>
		/// System.String PrivateBinPath
		/// </summary>
		protected RProperty r_PrivateBinPath;
		public virtual RProperty RPrivateBinPath
		{
			get
			{
				if(r_PrivateBinPath == null)
				{
					r_PrivateBinPath = new(this, "PrivateBinPath", -1);
					r_PrivateBinPath.SetBelong(this.instance);
				}
				return r_PrivateBinPath;
			}
		}

		/// <summary>
		/// System.String PrivateBinPathProbe
		/// </summary>
		protected RProperty r_PrivateBinPathProbe;
		public virtual RProperty RPrivateBinPathProbe
		{
			get
			{
				if(r_PrivateBinPathProbe == null)
				{
					r_PrivateBinPathProbe = new(this, "PrivateBinPathProbe", -1);
					r_PrivateBinPathProbe.SetBelong(this.instance);
				}
				return r_PrivateBinPathProbe;
			}
		}

		/// <summary>
		/// System.String ShadowCopyDirectories
		/// </summary>
		protected RProperty r_ShadowCopyDirectories;
		public virtual RProperty RShadowCopyDirectories
		{
			get
			{
				if(r_ShadowCopyDirectories == null)
				{
					r_ShadowCopyDirectories = new(this, "ShadowCopyDirectories", -1);
					r_ShadowCopyDirectories.SetBelong(this.instance);
				}
				return r_ShadowCopyDirectories;
			}
		}

		/// <summary>
		/// System.String ShadowCopyFiles
		/// </summary>
		protected RProperty r_ShadowCopyFiles;
		public virtual RProperty RShadowCopyFiles
		{
			get
			{
				if(r_ShadowCopyFiles == null)
				{
					r_ShadowCopyFiles = new(this, "ShadowCopyFiles", -1);
					r_ShadowCopyFiles.SetBelong(this.instance);
				}
				return r_ShadowCopyFiles;
			}
		}

		/// <summary>
		/// Boolean DisallowBindingRedirects
		/// </summary>
		protected RProperty r_DisallowBindingRedirects;
		public virtual RProperty RDisallowBindingRedirects
		{
			get
			{
				if(r_DisallowBindingRedirects == null)
				{
					r_DisallowBindingRedirects = new(this, "DisallowBindingRedirects", -1);
					r_DisallowBindingRedirects.SetBelong(this.instance);
				}
				return r_DisallowBindingRedirects;
			}
		}

		/// <summary>
		/// Boolean DisallowCodeDownload
		/// </summary>
		protected RProperty r_DisallowCodeDownload;
		public virtual RProperty RDisallowCodeDownload
		{
			get
			{
				if(r_DisallowCodeDownload == null)
				{
					r_DisallowCodeDownload = new(this, "DisallowCodeDownload", -1);
					r_DisallowCodeDownload.SetBelong(this.instance);
				}
				return r_DisallowCodeDownload;
			}
		}

		/// <summary>
		/// System.String TargetFrameworkName
		/// </summary>
		protected RProperty r_TargetFrameworkName;
		public virtual RProperty RTargetFrameworkName
		{
			get
			{
				if(r_TargetFrameworkName == null)
				{
					r_TargetFrameworkName = new(this, "TargetFrameworkName", -1);
					r_TargetFrameworkName.SetBelong(this.instance);
				}
				return r_TargetFrameworkName;
			}
		}

		/// <summary>
		/// System.Runtime.Hosting.ActivationArguments ActivationArguments
		/// </summary>
		protected RSystem.RRuntime.RHosting.RActivationArguments r_ActivationArguments;
		public virtual RSystem.RRuntime.RHosting.RActivationArguments RActivationArguments
		{
			get
			{
				if(r_ActivationArguments == null)
				{
					r_ActivationArguments = new(this, "ActivationArguments", -1);
					r_ActivationArguments.SetBelong(this.instance);
				}
				return r_ActivationArguments;
			}
		}

		/// <summary>
		/// System.AppDomainInitializer AppDomainInitializer
		/// </summary>
		protected RSystem.RAppDomainInitializer r_AppDomainInitializer;
		public virtual RSystem.RAppDomainInitializer RAppDomainInitializer
		{
			get
			{
				if(r_AppDomainInitializer == null)
				{
					r_AppDomainInitializer = new(this, "AppDomainInitializer", -1);
					r_AppDomainInitializer.SetBelong(this.instance);
				}
				return r_AppDomainInitializer;
			}
		}

		/// <summary>
		/// System.String[] AppDomainInitializerArguments
		/// </summary>
		protected RPropertyArray<RProperty> r_AppDomainInitializerArguments;
		public virtual RPropertyArray<RProperty> RAppDomainInitializerArguments
		{
			get
			{
				if(r_AppDomainInitializerArguments == null)
				{
					r_AppDomainInitializerArguments = new(this, "AppDomainInitializerArguments", -1);
					r_AppDomainInitializerArguments.SetBelong(this.instance);
				}
				return r_AppDomainInitializerArguments;
			}
		}

		/// <summary>
		/// System.Security.Policy.ApplicationTrust ApplicationTrust
		/// </summary>
		protected RSystem.RSecurity.RPolicy.RApplicationTrust r_ApplicationTrust;
		public virtual RSystem.RSecurity.RPolicy.RApplicationTrust RApplicationTrust
		{
			get
			{
				if(r_ApplicationTrust == null)
				{
					r_ApplicationTrust = new(this, "ApplicationTrust", -1);
					r_ApplicationTrust.SetBelong(this.instance);
				}
				return r_ApplicationTrust;
			}
		}

		/// <summary>
		/// Boolean DisallowApplicationBaseProbing
		/// </summary>
		protected RProperty r_DisallowApplicationBaseProbing;
		public virtual RProperty RDisallowApplicationBaseProbing
		{
			get
			{
				if(r_DisallowApplicationBaseProbing == null)
				{
					r_DisallowApplicationBaseProbing = new(this, "DisallowApplicationBaseProbing", -1);
					r_DisallowApplicationBaseProbing.SetBelong(this.instance);
				}
				return r_DisallowApplicationBaseProbing;
			}
		}

		/// <summary>
		/// Boolean SandboxInterop
		/// </summary>
		protected RProperty r_SandboxInterop;
		public virtual RProperty RSandboxInterop
		{
			get
			{
				if(r_SandboxInterop == null)
				{
					r_SandboxInterop = new(this, "SandboxInterop", -1);
					r_SandboxInterop.SetBelong(this.instance);
				}
				return r_SandboxInterop;
			}
		}

		/// <summary>
		/// System.String GetAppBase(System.String)
		/// </summary>
		protected static RMethod r_GetAppBase_String;
		public static RMethod RGetAppBase_String
		{
			get
			{
				if(r_GetAppBase_String == null)
				{
					r_GetAppBase_String = new(typeof(System.AppDomainSetup), "GetAppBase", 0, typeof(System.String));
					r_GetAppBase_String.SetBelong(null);
				}
				return r_GetAppBase_String;
			}
		}

		/// <summary>
		/// Byte[] GetConfigurationBytes()
		/// </summary>
		protected RMethod r_GetConfigurationBytes;
		public virtual RMethod RGetConfigurationBytes
		{
			get
			{
				if(r_GetConfigurationBytes == null)
				{
					r_GetConfigurationBytes = new(this, "GetConfigurationBytes", 0);
					r_GetConfigurationBytes.SetBelong(this.instance);
				}
				return r_GetConfigurationBytes;
			}
		}

		/// <summary>
		/// Void SetConfigurationBytes(Byte[])
		/// </summary>
		protected RMethod r_SetConfigurationBytes_ByteArray;
		public virtual RMethod RSetConfigurationBytes_ByteArray
		{
			get
			{
				if(r_SetConfigurationBytes_ByteArray == null)
				{
					r_SetConfigurationBytes_ByteArray = new(this, "SetConfigurationBytes", 0, typeof(System.Byte).MakeArrayType());
					r_SetConfigurationBytes_ByteArray.SetBelong(this.instance);
				}
				return r_SetConfigurationBytes_ByteArray;
			}
		}

		/// <summary>
		/// Void DeserializeNonPrimitives()
		/// </summary>
		protected RMethod r_DeserializeNonPrimitives;
		public virtual RMethod RDeserializeNonPrimitives
		{
			get
			{
				if(r_DeserializeNonPrimitives == null)
				{
					r_DeserializeNonPrimitives = new(this, "DeserializeNonPrimitives", 0);
					r_DeserializeNonPrimitives.SetBelong(this.instance);
				}
				return r_DeserializeNonPrimitives;
			}
		}

		/// <summary>
		/// Void SerializeNonPrimitives()
		/// </summary>
		protected RMethod r_SerializeNonPrimitives;
		public virtual RMethod RSerializeNonPrimitives
		{
			get
			{
				if(r_SerializeNonPrimitives == null)
				{
					r_SerializeNonPrimitives = new(this, "SerializeNonPrimitives", 0);
					r_SerializeNonPrimitives.SetBelong(this.instance);
				}
				return r_SerializeNonPrimitives;
			}
		}

		/// <summary>
		/// Void SetCompatibilitySwitches(System.Collections.Generic.IEnumerable`1[System.String])
		/// </summary>
		protected RMethod r_SetCompatibilitySwitches_IEnumerable_d_String_p_;
		public virtual RMethod RSetCompatibilitySwitches_IEnumerable_d_String_p_
		{
			get
			{
				if(r_SetCompatibilitySwitches_IEnumerable_d_String_p_ == null)
				{
					r_SetCompatibilitySwitches_IEnumerable_d_String_p_ = new(this, "SetCompatibilitySwitches", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.String)));
					r_SetCompatibilitySwitches_IEnumerable_d_String_p_.SetBelong(this.instance);
				}
				return r_SetCompatibilitySwitches_IEnumerable_d_String_p_;
			}
		}

		/// <summary>
		/// Void SetNativeFunction(System.String, Int32, IntPtr)
		/// </summary>
		protected RMethod r_SetNativeFunction_String_Int32_IntPtr;
		public virtual RMethod RSetNativeFunction_String_Int32_IntPtr
		{
			get
			{
				if(r_SetNativeFunction_String_Int32_IntPtr == null)
				{
					r_SetNativeFunction_String_Int32_IntPtr = new(this, "SetNativeFunction", 0, typeof(System.String), typeof(System.Int32), typeof(System.IntPtr));
					r_SetNativeFunction_String_Int32_IntPtr.SetBelong(this.instance);
				}
				return r_SetNativeFunction_String_Int32_IntPtr;
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

        public static System.String GetAppBase(System.String @appBase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@appBase};
            var ___result = RGetAppBase_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Byte[] GetConfigurationBytes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetConfigurationBytes.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual void SetConfigurationBytes(System.Byte[] @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetConfigurationBytes_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DeserializeNonPrimitives()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDeserializeNonPrimitives.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SerializeNonPrimitives()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSerializeNonPrimitives.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCompatibilitySwitches(System.Collections.Generic.IEnumerable<System.String> @switches)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@switches};
            var ___result = RSetCompatibilitySwitches_IEnumerable_d_String_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetNativeFunction(System.String @functionName, System.Int32 @functionVersion, System.IntPtr @functionPointer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@functionName, @functionVersion, @functionPointer};
            var ___result = RSetNativeFunction_String_Int32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
