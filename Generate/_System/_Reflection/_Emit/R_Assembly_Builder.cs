
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Reflection.Emit.AssemblyBuilder
	/// </summary>
    public partial class RAssemblyBuilder : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Reflection.Emit.AssemblyBuilder);
            }
        }

        public RAssemblyBuilder() : base("System.Reflection.Emit.AssemblyBuilder")
        {
        }

        public RAssemblyBuilder(System.Object instance) : base("System.Reflection.Emit.AssemblyBuilder")
		{
            SetInstance(instance);
		}

        public RAssemblyBuilder(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAssemblyBuilder(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Reflection.ModuleResolveEventHandler ModuleResolve
		/// </summary>
		protected REvent r_EModuleResolve;
		public virtual REvent REModuleResolve
		{
			get
			{
				if(r_EModuleResolve == null)
				{
					r_EModuleResolve = new(this, "ModuleResolve");
				}
				return r_EModuleResolve;
			}
		}

		/// <summary>
		/// System.IntPtr _mono_assembly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_F_mono_assembly;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RF_mono_assembly
		{
			get
			{
				if(r_F_mono_assembly == null)
				{
					r_F_mono_assembly = new(this, "_mono_assembly");
				}
				return r_F_mono_assembly;
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
		/// System.UIntPtr dynamic_assembly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUIntPtr r_Fdynamic_assembly;
		public virtual Hvak.Editor.Refleaction.RSystem.RUIntPtr RFdynamic_assembly
		{
			get
			{
				if(r_Fdynamic_assembly == null)
				{
					r_Fdynamic_assembly = new(this, "dynamic_assembly");
				}
				return r_Fdynamic_assembly;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo entry_point
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RMethodInfo r_Fentry_point;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RMethodInfo RFentry_point
		{
			get
			{
				if(r_Fentry_point == null)
				{
					r_Fentry_point = new(this, "entry_point");
				}
				return r_Fentry_point;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ModuleBuilder[] modules
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RModuleBuilder> r_Fmodules;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RModuleBuilder> RFmodules
		{
			get
			{
				if(r_Fmodules == null)
				{
					r_Fmodules = new(this, "modules");
				}
				return r_Fmodules;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFname
		{
			get
			{
				if(r_Fname == null)
				{
					r_Fname = new(this, "name");
				}
				return r_Fname;
			}
		}

		/// <summary>
		/// System.String dir
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fdir;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFdir
		{
			get
			{
				if(r_Fdir == null)
				{
					r_Fdir = new(this, "dir");
				}
				return r_Fdir;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.CustomAttributeBuilder[] cattrs
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RCustomAttributeBuilder> r_Fcattrs;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RCustomAttributeBuilder> RFcattrs
		{
			get
			{
				if(r_Fcattrs == null)
				{
					r_Fcattrs = new(this, "cattrs");
				}
				return r_Fcattrs;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MonoResource[] resources
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RMonoResource> r_Fresources;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RMonoResource> RFresources
		{
			get
			{
				if(r_Fresources == null)
				{
					r_Fresources = new(this, "resources");
				}
				return r_Fresources;
			}
		}

		/// <summary>
		/// System.Byte[] public_key
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> r_Fpublic_key;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> RFpublic_key
		{
			get
			{
				if(r_Fpublic_key == null)
				{
					r_Fpublic_key = new(this, "public_key");
				}
				return r_Fpublic_key;
			}
		}

		/// <summary>
		/// System.String version
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fversion;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFversion
		{
			get
			{
				if(r_Fversion == null)
				{
					r_Fversion = new(this, "version");
				}
				return r_Fversion;
			}
		}

		/// <summary>
		/// System.String culture
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fculture;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFculture
		{
			get
			{
				if(r_Fculture == null)
				{
					r_Fculture = new(this, "culture");
				}
				return r_Fculture;
			}
		}

		/// <summary>
		/// System.UInt32 algid
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Falgid;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFalgid
		{
			get
			{
				if(r_Falgid == null)
				{
					r_Falgid = new(this, "algid");
				}
				return r_Falgid;
			}
		}

		/// <summary>
		/// System.UInt32 flags
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fflags;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFflags
		{
			get
			{
				if(r_Fflags == null)
				{
					r_Fflags = new(this, "flags");
				}
				return r_Fflags;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.PEFileKinds pekind
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RPEFileKinds r_Fpekind;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RPEFileKinds RFpekind
		{
			get
			{
				if(r_Fpekind == null)
				{
					r_Fpekind = new(this, "pekind");
				}
				return r_Fpekind;
			}
		}

		/// <summary>
		/// System.Boolean delay_sign
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fdelay_sign;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFdelay_sign
		{
			get
			{
				if(r_Fdelay_sign == null)
				{
					r_Fdelay_sign = new(this, "delay_sign");
				}
				return r_Fdelay_sign;
			}
		}

		/// <summary>
		/// System.UInt32 access
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Faccess;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFaccess
		{
			get
			{
				if(r_Faccess == null)
				{
					r_Faccess = new(this, "access");
				}
				return r_Faccess;
			}
		}

		/// <summary>
		/// System.Reflection.Module[] loaded_modules
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.RModule> r_Floaded_modules;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.RModule> RFloaded_modules
		{
			get
			{
				if(r_Floaded_modules == null)
				{
					r_Floaded_modules = new(this, "loaded_modules");
				}
				return r_Floaded_modules;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MonoWin32Resource[] win32_resources
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RMonoWin32Resource> r_Fwin32_resources;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RMonoWin32Resource> RFwin32_resources
		{
			get
			{
				if(r_Fwin32_resources == null)
				{
					r_Fwin32_resources = new(this, "win32_resources");
				}
				return r_Fwin32_resources;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.RefEmitPermissionSet[] permissions_minimum
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RRefEmitPermissionSet> r_Fpermissions_minimum;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RRefEmitPermissionSet> RFpermissions_minimum
		{
			get
			{
				if(r_Fpermissions_minimum == null)
				{
					r_Fpermissions_minimum = new(this, "permissions_minimum");
				}
				return r_Fpermissions_minimum;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.RefEmitPermissionSet[] permissions_optional
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RRefEmitPermissionSet> r_Fpermissions_optional;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RRefEmitPermissionSet> RFpermissions_optional
		{
			get
			{
				if(r_Fpermissions_optional == null)
				{
					r_Fpermissions_optional = new(this, "permissions_optional");
				}
				return r_Fpermissions_optional;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.RefEmitPermissionSet[] permissions_refused
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RRefEmitPermissionSet> r_Fpermissions_refused;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RRefEmitPermissionSet> RFpermissions_refused
		{
			get
			{
				if(r_Fpermissions_refused == null)
				{
					r_Fpermissions_refused = new(this, "permissions_refused");
				}
				return r_Fpermissions_refused;
			}
		}

		/// <summary>
		/// System.Reflection.PortableExecutableKinds peKind
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RPortableExecutableKinds r_FpeKind;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RPortableExecutableKinds RFpeKind
		{
			get
			{
				if(r_FpeKind == null)
				{
					r_FpeKind = new(this, "peKind");
				}
				return r_FpeKind;
			}
		}

		/// <summary>
		/// System.Reflection.ImageFileMachine machine
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RImageFileMachine r_Fmachine;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RImageFileMachine RFmachine
		{
			get
			{
				if(r_Fmachine == null)
				{
					r_Fmachine = new(this, "machine");
				}
				return r_Fmachine;
			}
		}

		/// <summary>
		/// System.Boolean corlib_internal
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fcorlib_internal;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFcorlib_internal
		{
			get
			{
				if(r_Fcorlib_internal == null)
				{
					r_Fcorlib_internal = new(this, "corlib_internal");
				}
				return r_Fcorlib_internal;
			}
		}

		/// <summary>
		/// System.Type[] type_forwarders
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RType> r_Ftype_forwarders;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RType> RFtype_forwarders
		{
			get
			{
				if(r_Ftype_forwarders == null)
				{
					r_Ftype_forwarders = new(this, "type_forwarders");
				}
				return r_Ftype_forwarders;
			}
		}

		/// <summary>
		/// System.Byte[] pktoken
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> r_Fpktoken;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> RFpktoken
		{
			get
			{
				if(r_Fpktoken == null)
				{
					r_Fpktoken = new(this, "pktoken");
				}
				return r_Fpktoken;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet _minimum
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPermissionSet r_F_minimum;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPermissionSet RF_minimum
		{
			get
			{
				if(r_F_minimum == null)
				{
					r_F_minimum = new(this, "_minimum");
				}
				return r_F_minimum;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet _optional
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPermissionSet r_F_optional;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPermissionSet RF_optional
		{
			get
			{
				if(r_F_optional == null)
				{
					r_F_optional = new(this, "_optional");
				}
				return r_F_optional;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet _refuse
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPermissionSet r_F_refuse;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPermissionSet RF_refuse
		{
			get
			{
				if(r_F_refuse == null)
				{
					r_F_refuse = new(this, "_refuse");
				}
				return r_F_refuse;
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
		/// System.Security.PermissionSet _denied
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPermissionSet r_F_denied;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPermissionSet RF_denied
		{
			get
			{
				if(r_F_denied == null)
				{
					r_F_denied = new(this, "_denied");
				}
				return r_F_denied;
			}
		}

		/// <summary>
		/// System.String assemblyName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FassemblyName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFassemblyName
		{
			get
			{
				if(r_FassemblyName == null)
				{
					r_FassemblyName = new(this, "assemblyName");
				}
				return r_FassemblyName;
			}
		}

		/// <summary>
		/// System.Type corlib_object_type
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_Fcorlib_object_type;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RFcorlib_object_type
		{
			get
			{
				if(r_Fcorlib_object_type == null)
				{
					r_Fcorlib_object_type = new(this, "corlib_object_type");
				}
				return r_Fcorlib_object_type;
			}
		}

		/// <summary>
		/// System.Type corlib_value_type
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_Fcorlib_value_type;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RFcorlib_value_type
		{
			get
			{
				if(r_Fcorlib_value_type == null)
				{
					r_Fcorlib_value_type = new(this, "corlib_value_type");
				}
				return r_Fcorlib_value_type;
			}
		}

		/// <summary>
		/// System.Type corlib_enum_type
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_Fcorlib_enum_type;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RFcorlib_enum_type
		{
			get
			{
				if(r_Fcorlib_enum_type == null)
				{
					r_Fcorlib_enum_type = new(this, "corlib_enum_type");
				}
				return r_Fcorlib_enum_type;
			}
		}

		/// <summary>
		/// System.Type corlib_void_type
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_Fcorlib_void_type;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RFcorlib_void_type
		{
			get
			{
				if(r_Fcorlib_void_type == null)
				{
					r_Fcorlib_void_type = new(this, "corlib_void_type");
				}
				return r_Fcorlib_void_type;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList resource_writers
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RArrayList r_Fresource_writers;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RArrayList RFresource_writers
		{
			get
			{
				if(r_Fresource_writers == null)
				{
					r_Fresource_writers = new(this, "resource_writers");
				}
				return r_Fresource_writers;
			}
		}

		/// <summary>
		/// System.Resources.Win32VersionResource version_res
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RResources.RWin32VersionResource r_Fversion_res;
		public virtual Hvak.Editor.Refleaction.RSystem.RResources.RWin32VersionResource RFversion_res
		{
			get
			{
				if(r_Fversion_res == null)
				{
					r_Fversion_res = new(this, "version_res");
				}
				return r_Fversion_res;
			}
		}

		/// <summary>
		/// System.Boolean created
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fcreated;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFcreated
		{
			get
			{
				if(r_Fcreated == null)
				{
					r_Fcreated = new(this, "created");
				}
				return r_Fcreated;
			}
		}

		/// <summary>
		/// System.Boolean is_module_only
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fis_module_only;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFis_module_only
		{
			get
			{
				if(r_Fis_module_only == null)
				{
					r_Fis_module_only = new(this, "is_module_only");
				}
				return r_Fis_module_only;
			}
		}

		/// <summary>
		/// Mono.Security.StrongName sn
		/// </summary>
		protected Hvak.Editor.Refleaction.RMono.RSecurity.RStrongName r_Fsn;
		public virtual Hvak.Editor.Refleaction.RMono.RSecurity.RStrongName RFsn
		{
			get
			{
				if(r_Fsn == null)
				{
					r_Fsn = new(this, "sn");
				}
				return r_Fsn;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.NativeResourceType native_resource
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RNativeResourceType r_Fnative_resource;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RNativeResourceType RFnative_resource
		{
			get
			{
				if(r_Fnative_resource == null)
				{
					r_Fnative_resource = new(this, "native_resource");
				}
				return r_Fnative_resource;
			}
		}

		/// <summary>
		/// System.String versioninfo_culture
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fversioninfo_culture;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFversioninfo_culture
		{
			get
			{
				if(r_Fversioninfo_culture == null)
				{
					r_Fversioninfo_culture = new(this, "versioninfo_culture");
				}
				return r_Fversioninfo_culture;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilderAccess COMPILER_ACCESS
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RAssemblyBuilderAccess r_FCOMPILER_ACCESS;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RAssemblyBuilderAccess RFCOMPILER_ACCESS
		{
			get
			{
				if(r_FCOMPILER_ACCESS == null)
				{
					r_FCOMPILER_ACCESS = new(Type, "COMPILER_ACCESS");
				}
				return r_FCOMPILER_ACCESS;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ModuleBuilder manifest_module
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RModuleBuilder r_Fmanifest_module;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RModuleBuilder RFmanifest_module
		{
			get
			{
				if(r_Fmanifest_module == null)
				{
					r_Fmanifest_module = new(this, "manifest_module");
				}
				return r_Fmanifest_module;
			}
		}

		/// <summary>
		/// System.String CodeBase
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PCodeBase;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPCodeBase
		{
			get
			{
				if(r_PCodeBase == null)
				{
					r_PCodeBase = new(this, "CodeBase", -1);
				}
				return r_PCodeBase;
			}
		}

		/// <summary>
		/// System.String EscapedCodeBase
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PEscapedCodeBase;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPEscapedCodeBase
		{
			get
			{
				if(r_PEscapedCodeBase == null)
				{
					r_PEscapedCodeBase = new(this, "EscapedCodeBase", -1);
				}
				return r_PEscapedCodeBase;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo EntryPoint
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RMethodInfo r_PEntryPoint;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RMethodInfo RPEntryPoint
		{
			get
			{
				if(r_PEntryPoint == null)
				{
					r_PEntryPoint = new(this, "EntryPoint", -1);
				}
				return r_PEntryPoint;
			}
		}

		/// <summary>
		/// System.String Location
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PLocation;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPLocation
		{
			get
			{
				if(r_PLocation == null)
				{
					r_PLocation = new(this, "Location", -1);
				}
				return r_PLocation;
			}
		}

		/// <summary>
		/// System.String ImageRuntimeVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PImageRuntimeVersion;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPImageRuntimeVersion
		{
			get
			{
				if(r_PImageRuntimeVersion == null)
				{
					r_PImageRuntimeVersion = new(this, "ImageRuntimeVersion", -1);
				}
				return r_PImageRuntimeVersion;
			}
		}

		/// <summary>
		/// Boolean ReflectionOnly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PReflectionOnly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPReflectionOnly
		{
			get
			{
				if(r_PReflectionOnly == null)
				{
					r_PReflectionOnly = new(this, "ReflectionOnly", -1);
				}
				return r_PReflectionOnly;
			}
		}

		/// <summary>
		/// Boolean IsSave
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsSave;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsSave
		{
			get
			{
				if(r_PIsSave == null)
				{
					r_PIsSave = new(this, "IsSave", -1);
				}
				return r_PIsSave;
			}
		}

		/// <summary>
		/// Boolean IsRun
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsRun;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsRun
		{
			get
			{
				if(r_PIsRun == null)
				{
					r_PIsRun = new(this, "IsRun", -1);
				}
				return r_PIsRun;
			}
		}

		/// <summary>
		/// System.String AssemblyDir
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PAssemblyDir;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPAssemblyDir
		{
			get
			{
				if(r_PAssemblyDir == null)
				{
					r_PAssemblyDir = new(this, "AssemblyDir", -1);
				}
				return r_PAssemblyDir;
			}
		}

		/// <summary>
		/// Boolean IsModuleOnly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsModuleOnly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsModuleOnly
		{
			get
			{
				if(r_PIsModuleOnly == null)
				{
					r_PIsModuleOnly = new(this, "IsModuleOnly", -1);
				}
				return r_PIsModuleOnly;
			}
		}

		/// <summary>
		/// System.Reflection.Module ManifestModule
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RModule r_PManifestModule;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RModule RPManifestModule
		{
			get
			{
				if(r_PManifestModule == null)
				{
					r_PManifestModule = new(this, "ManifestModule", -1);
				}
				return r_PManifestModule;
			}
		}

		/// <summary>
		/// Boolean GlobalAssemblyCache
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PGlobalAssemblyCache;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPGlobalAssemblyCache
		{
			get
			{
				if(r_PGlobalAssemblyCache == null)
				{
					r_PGlobalAssemblyCache = new(this, "GlobalAssemblyCache", -1);
				}
				return r_PGlobalAssemblyCache;
			}
		}

		/// <summary>
		/// Boolean IsDynamic
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsDynamic;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsDynamic
		{
			get
			{
				if(r_PIsDynamic == null)
				{
					r_PIsDynamic = new(this, "IsDynamic", -1);
				}
				return r_PIsDynamic;
			}
		}

		/// <summary>
		/// System.String FullName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PFullName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPFullName
		{
			get
			{
				if(r_PFullName == null)
				{
					r_PFullName = new(this, "FullName", -1);
				}
				return r_PFullName;
			}
		}

		/// <summary>
		/// IntPtr MonoAssembly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_PMonoAssembly;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RPMonoAssembly
		{
			get
			{
				if(r_PMonoAssembly == null)
				{
					r_PMonoAssembly = new(this, "MonoAssembly", -1);
				}
				return r_PMonoAssembly;
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
		/// Boolean FromByteArray
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PFromByteArray;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPFromByteArray
		{
			get
			{
				if(r_PFromByteArray == null)
				{
					r_PFromByteArray = new(this, "FromByteArray", -1);
				}
				return r_PFromByteArray;
			}
		}

		/// <summary>
		/// Int64 HostContext
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_PHostContext;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RPHostContext
		{
			get
			{
				if(r_PHostContext == null)
				{
					r_PHostContext = new(this, "HostContext", -1);
				}
				return r_PHostContext;
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
		/// System.Security.PermissionSet DeniedPermissionSet
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPermissionSet r_PDeniedPermissionSet;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPermissionSet RPDeniedPermissionSet
		{
			get
			{
				if(r_PDeniedPermissionSet == null)
				{
					r_PDeniedPermissionSet = new(this, "DeniedPermissionSet", -1);
				}
				return r_PDeniedPermissionSet;
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
		/// System.Security.SecurityRuleSet SecurityRuleSet
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RSecurityRuleSet r_PSecurityRuleSet;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RSecurityRuleSet RPSecurityRuleSet
		{
			get
			{
				if(r_PSecurityRuleSet == null)
				{
					r_PSecurityRuleSet = new(this, "SecurityRuleSet", -1);
				}
				return r_PSecurityRuleSet;
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
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.TypeInfo] DefinedTypes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RReflection.RTypeInfo> r_PDefinedTypes;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RReflection.RTypeInfo> RPDefinedTypes
		{
			get
			{
				if(r_PDefinedTypes == null)
				{
					r_PDefinedTypes = new(this, "DefinedTypes", -1);
				}
				return r_PDefinedTypes;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Type] ExportedTypes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RType> r_PExportedTypes;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RType> RPExportedTypes
		{
			get
			{
				if(r_PExportedTypes == null)
				{
					r_PExportedTypes = new(this, "ExportedTypes", -1);
				}
				return r_PExportedTypes;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.Module] Modules
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RReflection.RModule> r_PModules;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RReflection.RModule> RPModules
		{
			get
			{
				if(r_PModules == null)
				{
					r_PModules = new(this, "Modules", -1);
				}
				return r_PModules;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.CustomAttributeData] CustomAttributes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RReflection.RCustomAttributeData> r_PCustomAttributes;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RReflection.RCustomAttributeData> RPCustomAttributes
		{
			get
			{
				if(r_PCustomAttributes == null)
				{
					r_PCustomAttributes = new(this, "CustomAttributes", -1);
				}
				return r_PCustomAttributes;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._AssemblyBuilder.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___AssemblyBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___AssemblyBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___AssemblyBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___AssemblyBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._AssemblyBuilder.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___AssemblyBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._AssemblyBuilder.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___AssemblyBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___AssemblyBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___AssemblyBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___AssemblyBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._AssemblyBuilder.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___AssemblyBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._AssemblyBuilder.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___AssemblyBuilder__2__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___AssemblyBuilder__2__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___AssemblyBuilder__2__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___AssemblyBuilder__2__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._AssemblyBuilder.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___AssemblyBuilder__2__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._AssemblyBuilder.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___AssemblyBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___AssemblyBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___AssemblyBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___AssemblyBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._AssemblyBuilder.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___AssemblyBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// Void basic_init(System.Reflection.Emit.AssemblyBuilder)
		/// </summary>
		protected static RMethod r_Mbasic_init_AssemblyBuilder;
		public static RMethod RMbasic_init_AssemblyBuilder
		{
			get
			{
				if(r_Mbasic_init_AssemblyBuilder == null)
				{
					r_Mbasic_init_AssemblyBuilder = new(Type, "basic_init", 0, typeof(System.Reflection.Emit.AssemblyBuilder));
				}
				return r_Mbasic_init_AssemblyBuilder;
			}
		}

		/// <summary>
		/// Void UpdateNativeCustomAttributes(System.Reflection.Emit.AssemblyBuilder)
		/// </summary>
		protected static RMethod r_MUpdateNativeCustomAttributes_AssemblyBuilder;
		public static RMethod RMUpdateNativeCustomAttributes_AssemblyBuilder
		{
			get
			{
				if(r_MUpdateNativeCustomAttributes_AssemblyBuilder == null)
				{
					r_MUpdateNativeCustomAttributes_AssemblyBuilder = new(Type, "UpdateNativeCustomAttributes", 0, typeof(System.Reflection.Emit.AssemblyBuilder));
				}
				return r_MUpdateNativeCustomAttributes_AssemblyBuilder;
			}
		}

		/// <summary>
		/// Void AddResourceFile(System.String, System.String)
		/// </summary>
		protected RMethod r_MAddResourceFile_String_String;
		public virtual RMethod RMAddResourceFile_String_String
		{
			get
			{
				if(r_MAddResourceFile_String_String == null)
				{
					r_MAddResourceFile_String_String = new(this, "AddResourceFile", 0, typeof(System.String), typeof(System.String));
				}
				return r_MAddResourceFile_String_String;
			}
		}

		/// <summary>
		/// Void AddResourceFile(System.String, System.String, System.Reflection.ResourceAttributes)
		/// </summary>
		protected RMethod r_MAddResourceFile_String_String_ResourceAttributes;
		public virtual RMethod RMAddResourceFile_String_String_ResourceAttributes
		{
			get
			{
				if(r_MAddResourceFile_String_String_ResourceAttributes == null)
				{
					r_MAddResourceFile_String_String_ResourceAttributes = new(this, "AddResourceFile", 0, typeof(System.String), typeof(System.String), typeof(System.Reflection.ResourceAttributes));
				}
				return r_MAddResourceFile_String_String_ResourceAttributes;
			}
		}

		/// <summary>
		/// Void AddResourceFile(System.String, System.String, System.Reflection.ResourceAttributes, Boolean)
		/// </summary>
		protected RMethod r_MAddResourceFile_String_String_ResourceAttributes_Boolean;
		public virtual RMethod RMAddResourceFile_String_String_ResourceAttributes_Boolean
		{
			get
			{
				if(r_MAddResourceFile_String_String_ResourceAttributes_Boolean == null)
				{
					r_MAddResourceFile_String_String_ResourceAttributes_Boolean = new(this, "AddResourceFile", 0, typeof(System.String), typeof(System.String), typeof(System.Reflection.ResourceAttributes), typeof(System.Boolean));
				}
				return r_MAddResourceFile_String_String_ResourceAttributes_Boolean;
			}
		}

		/// <summary>
		/// Void AddPermissionRequests(System.Security.PermissionSet, System.Security.PermissionSet, System.Security.PermissionSet)
		/// </summary>
		protected RMethod r_MAddPermissionRequests_PermissionSet_PermissionSet_PermissionSet;
		public virtual RMethod RMAddPermissionRequests_PermissionSet_PermissionSet_PermissionSet
		{
			get
			{
				if(r_MAddPermissionRequests_PermissionSet_PermissionSet_PermissionSet == null)
				{
					r_MAddPermissionRequests_PermissionSet_PermissionSet_PermissionSet = new(this, "AddPermissionRequests", 0, typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet));
				}
				return r_MAddPermissionRequests_PermissionSet_PermissionSet_PermissionSet;
			}
		}

		/// <summary>
		/// Void EmbedResourceFile(System.String, System.String)
		/// </summary>
		protected RMethod r_MEmbedResourceFile_String_String;
		public virtual RMethod RMEmbedResourceFile_String_String
		{
			get
			{
				if(r_MEmbedResourceFile_String_String == null)
				{
					r_MEmbedResourceFile_String_String = new(this, "EmbedResourceFile", 0, typeof(System.String), typeof(System.String));
				}
				return r_MEmbedResourceFile_String_String;
			}
		}

		/// <summary>
		/// Void EmbedResourceFile(System.String, System.String, System.Reflection.ResourceAttributes)
		/// </summary>
		protected RMethod r_MEmbedResourceFile_String_String_ResourceAttributes;
		public virtual RMethod RMEmbedResourceFile_String_String_ResourceAttributes
		{
			get
			{
				if(r_MEmbedResourceFile_String_String_ResourceAttributes == null)
				{
					r_MEmbedResourceFile_String_String_ResourceAttributes = new(this, "EmbedResourceFile", 0, typeof(System.String), typeof(System.String), typeof(System.Reflection.ResourceAttributes));
				}
				return r_MEmbedResourceFile_String_String_ResourceAttributes;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName, System.Reflection.Emit.AssemblyBuilderAccess)
		/// </summary>
		protected static RMethod r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess;
		public static RMethod RMDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess
		{
			get
			{
				if(r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess == null)
				{
					r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess = new(Type, "DefineDynamicAssembly", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.AssemblyBuilderAccess));
				}
				return r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName, System.Reflection.Emit.AssemblyBuilderAccess, System.Collections.Generic.IEnumerable`1[System.Reflection.Emit.CustomAttributeBuilder])
		/// </summary>
		protected static RMethod r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p_;
		public static RMethod RMDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p_
		{
			get
			{
				if(r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p_ == null)
				{
					r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p_ = new(Type, "DefineDynamicAssembly", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.AssemblyBuilderAccess),  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType(typeof(System.Reflection.Emit.CustomAttributeBuilder)));
				}
				return r_MDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p_;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ModuleBuilder DefineDynamicModule(System.String)
		/// </summary>
		protected RMethod r_MDefineDynamicModule_String;
		public virtual RMethod RMDefineDynamicModule_String
		{
			get
			{
				if(r_MDefineDynamicModule_String == null)
				{
					r_MDefineDynamicModule_String = new(this, "DefineDynamicModule", 0, typeof(System.String));
				}
				return r_MDefineDynamicModule_String;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ModuleBuilder DefineDynamicModule(System.String, Boolean)
		/// </summary>
		protected RMethod r_MDefineDynamicModule_String_Boolean;
		public virtual RMethod RMDefineDynamicModule_String_Boolean
		{
			get
			{
				if(r_MDefineDynamicModule_String_Boolean == null)
				{
					r_MDefineDynamicModule_String_Boolean = new(this, "DefineDynamicModule", 0, typeof(System.String), typeof(System.Boolean));
				}
				return r_MDefineDynamicModule_String_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ModuleBuilder DefineDynamicModule(System.String, System.String)
		/// </summary>
		protected RMethod r_MDefineDynamicModule_String_String;
		public virtual RMethod RMDefineDynamicModule_String_String
		{
			get
			{
				if(r_MDefineDynamicModule_String_String == null)
				{
					r_MDefineDynamicModule_String_String = new(this, "DefineDynamicModule", 0, typeof(System.String), typeof(System.String));
				}
				return r_MDefineDynamicModule_String_String;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ModuleBuilder DefineDynamicModule(System.String, System.String, Boolean)
		/// </summary>
		protected RMethod r_MDefineDynamicModule_String_String_Boolean;
		public virtual RMethod RMDefineDynamicModule_String_String_Boolean
		{
			get
			{
				if(r_MDefineDynamicModule_String_String_Boolean == null)
				{
					r_MDefineDynamicModule_String_String_Boolean = new(this, "DefineDynamicModule", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean));
				}
				return r_MDefineDynamicModule_String_String_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ModuleBuilder DefineDynamicModule(System.String, System.String, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MDefineDynamicModule_String_String_Boolean_Boolean;
		public virtual RMethod RMDefineDynamicModule_String_String_Boolean_Boolean
		{
			get
			{
				if(r_MDefineDynamicModule_String_String_Boolean_Boolean == null)
				{
					r_MDefineDynamicModule_String_String_Boolean_Boolean = new(this, "DefineDynamicModule", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MDefineDynamicModule_String_String_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Resources.IResourceWriter DefineResource(System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_MDefineResource_String_String_String;
		public virtual RMethod RMDefineResource_String_String_String
		{
			get
			{
				if(r_MDefineResource_String_String_String == null)
				{
					r_MDefineResource_String_String_String = new(this, "DefineResource", 0, typeof(System.String), typeof(System.String), typeof(System.String));
				}
				return r_MDefineResource_String_String_String;
			}
		}

		/// <summary>
		/// System.Resources.IResourceWriter DefineResource(System.String, System.String, System.String, System.Reflection.ResourceAttributes)
		/// </summary>
		protected RMethod r_MDefineResource_String_String_String_ResourceAttributes;
		public virtual RMethod RMDefineResource_String_String_String_ResourceAttributes
		{
			get
			{
				if(r_MDefineResource_String_String_String_ResourceAttributes == null)
				{
					r_MDefineResource_String_String_String_ResourceAttributes = new(this, "DefineResource", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.Reflection.ResourceAttributes));
				}
				return r_MDefineResource_String_String_String_ResourceAttributes;
			}
		}

		/// <summary>
		/// Void AddUnmanagedResource(System.Resources.Win32Resource)
		/// </summary>
		protected RMethod r_MAddUnmanagedResource_Win32Resource;
		public virtual RMethod RMAddUnmanagedResource_Win32Resource
		{
			get
			{
				if(r_MAddUnmanagedResource_Win32Resource == null)
				{
					r_MAddUnmanagedResource_Win32Resource = new(this, "AddUnmanagedResource", 0,  ReflectionUtils.GetType("System.Resources.Win32Resource"));
				}
				return r_MAddUnmanagedResource_Win32Resource;
			}
		}

		/// <summary>
		/// Void DefineUnmanagedResource(Byte[])
		/// </summary>
		protected RMethod r_MDefineUnmanagedResource_ByteArray;
		public virtual RMethod RMDefineUnmanagedResource_ByteArray
		{
			get
			{
				if(r_MDefineUnmanagedResource_ByteArray == null)
				{
					r_MDefineUnmanagedResource_ByteArray = new(this, "DefineUnmanagedResource", 0, typeof(System.Byte).MakeArrayType());
				}
				return r_MDefineUnmanagedResource_ByteArray;
			}
		}

		/// <summary>
		/// Void DefineUnmanagedResource(System.String)
		/// </summary>
		protected RMethod r_MDefineUnmanagedResource_String;
		public virtual RMethod RMDefineUnmanagedResource_String
		{
			get
			{
				if(r_MDefineUnmanagedResource_String == null)
				{
					r_MDefineUnmanagedResource_String = new(this, "DefineUnmanagedResource", 0, typeof(System.String));
				}
				return r_MDefineUnmanagedResource_String;
			}
		}

		/// <summary>
		/// Void DefineVersionInfoResource()
		/// </summary>
		protected RMethod r_MDefineVersionInfoResource;
		public virtual RMethod RMDefineVersionInfoResource
		{
			get
			{
				if(r_MDefineVersionInfoResource == null)
				{
					r_MDefineVersionInfoResource = new(this, "DefineVersionInfoResource", 0);
				}
				return r_MDefineVersionInfoResource;
			}
		}

		/// <summary>
		/// Void DefineVersionInfoResource(System.String, System.String, System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_MDefineVersionInfoResource_String_String_String_String_String;
		public virtual RMethod RMDefineVersionInfoResource_String_String_String_String_String
		{
			get
			{
				if(r_MDefineVersionInfoResource_String_String_String_String_String == null)
				{
					r_MDefineVersionInfoResource_String_String_String_String_String = new(this, "DefineVersionInfoResource", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.String));
				}
				return r_MDefineVersionInfoResource_String_String_String_String_String;
			}
		}

		/// <summary>
		/// Void DefineVersionInfoResourceImpl(System.String)
		/// </summary>
		protected RMethod r_MDefineVersionInfoResourceImpl_String;
		public virtual RMethod RMDefineVersionInfoResourceImpl_String
		{
			get
			{
				if(r_MDefineVersionInfoResourceImpl_String == null)
				{
					r_MDefineVersionInfoResourceImpl_String = new(this, "DefineVersionInfoResourceImpl", 0, typeof(System.String));
				}
				return r_MDefineVersionInfoResourceImpl_String;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ModuleBuilder GetDynamicModule(System.String)
		/// </summary>
		protected RMethod r_MGetDynamicModule_String;
		public virtual RMethod RMGetDynamicModule_String
		{
			get
			{
				if(r_MGetDynamicModule_String == null)
				{
					r_MGetDynamicModule_String = new(this, "GetDynamicModule", 0, typeof(System.String));
				}
				return r_MGetDynamicModule_String;
			}
		}

		/// <summary>
		/// System.Type[] GetExportedTypes()
		/// </summary>
		protected RMethod r_MGetExportedTypes;
		public virtual RMethod RMGetExportedTypes
		{
			get
			{
				if(r_MGetExportedTypes == null)
				{
					r_MGetExportedTypes = new(this, "GetExportedTypes", 0);
				}
				return r_MGetExportedTypes;
			}
		}

		/// <summary>
		/// System.IO.FileStream GetFile(System.String)
		/// </summary>
		protected RMethod r_MGetFile_String;
		public virtual RMethod RMGetFile_String
		{
			get
			{
				if(r_MGetFile_String == null)
				{
					r_MGetFile_String = new(this, "GetFile", 0, typeof(System.String));
				}
				return r_MGetFile_String;
			}
		}

		/// <summary>
		/// System.IO.FileStream[] GetFiles(Boolean)
		/// </summary>
		protected RMethod r_MGetFiles_Boolean;
		public virtual RMethod RMGetFiles_Boolean
		{
			get
			{
				if(r_MGetFiles_Boolean == null)
				{
					r_MGetFiles_Boolean = new(this, "GetFiles", 0, typeof(System.Boolean));
				}
				return r_MGetFiles_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.Module[] GetModulesInternal()
		/// </summary>
		protected RMethod r_MGetModulesInternal;
		public virtual RMethod RMGetModulesInternal
		{
			get
			{
				if(r_MGetModulesInternal == null)
				{
					r_MGetModulesInternal = new(this, "GetModulesInternal", 0);
				}
				return r_MGetModulesInternal;
			}
		}

		/// <summary>
		/// System.Type[] GetTypes(Boolean)
		/// </summary>
		protected RMethod r_MGetTypes_Boolean;
		public virtual RMethod RMGetTypes_Boolean
		{
			get
			{
				if(r_MGetTypes_Boolean == null)
				{
					r_MGetTypes_Boolean = new(this, "GetTypes", 0, typeof(System.Boolean));
				}
				return r_MGetTypes_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.ManifestResourceInfo GetManifestResourceInfo(System.String)
		/// </summary>
		protected RMethod r_MGetManifestResourceInfo_String;
		public virtual RMethod RMGetManifestResourceInfo_String
		{
			get
			{
				if(r_MGetManifestResourceInfo_String == null)
				{
					r_MGetManifestResourceInfo_String = new(this, "GetManifestResourceInfo", 0, typeof(System.String));
				}
				return r_MGetManifestResourceInfo_String;
			}
		}

		/// <summary>
		/// System.String[] GetManifestResourceNames()
		/// </summary>
		protected RMethod r_MGetManifestResourceNames;
		public virtual RMethod RMGetManifestResourceNames
		{
			get
			{
				if(r_MGetManifestResourceNames == null)
				{
					r_MGetManifestResourceNames = new(this, "GetManifestResourceNames", 0);
				}
				return r_MGetManifestResourceNames;
			}
		}

		/// <summary>
		/// System.IO.Stream GetManifestResourceStream(System.String)
		/// </summary>
		protected RMethod r_MGetManifestResourceStream_String;
		public virtual RMethod RMGetManifestResourceStream_String
		{
			get
			{
				if(r_MGetManifestResourceStream_String == null)
				{
					r_MGetManifestResourceStream_String = new(this, "GetManifestResourceStream", 0, typeof(System.String));
				}
				return r_MGetManifestResourceStream_String;
			}
		}

		/// <summary>
		/// System.IO.Stream GetManifestResourceStream(System.Type, System.String)
		/// </summary>
		protected RMethod r_MGetManifestResourceStream_Type_String;
		public virtual RMethod RMGetManifestResourceStream_Type_String
		{
			get
			{
				if(r_MGetManifestResourceStream_Type_String == null)
				{
					r_MGetManifestResourceStream_Type_String = new(this, "GetManifestResourceStream", 0, typeof(System.Type), typeof(System.String));
				}
				return r_MGetManifestResourceStream_Type_String;
			}
		}

		/// <summary>
		/// System.Reflection.Module GetManifestModule()
		/// </summary>
		protected RMethod r_MGetManifestModule;
		public virtual RMethod RMGetManifestModule
		{
			get
			{
				if(r_MGetManifestModule == null)
				{
					r_MGetManifestModule = new(this, "GetManifestModule", 0);
				}
				return r_MGetManifestModule;
			}
		}

		/// <summary>
		/// Void Save(System.String, System.Reflection.PortableExecutableKinds, System.Reflection.ImageFileMachine)
		/// </summary>
		protected RMethod r_MSave_String_PortableExecutableKinds_ImageFileMachine;
		public virtual RMethod RMSave_String_PortableExecutableKinds_ImageFileMachine
		{
			get
			{
				if(r_MSave_String_PortableExecutableKinds_ImageFileMachine == null)
				{
					r_MSave_String_PortableExecutableKinds_ImageFileMachine = new(this, "Save", 0, typeof(System.String), typeof(System.Reflection.PortableExecutableKinds), typeof(System.Reflection.ImageFileMachine));
				}
				return r_MSave_String_PortableExecutableKinds_ImageFileMachine;
			}
		}

		/// <summary>
		/// Void Save(System.String)
		/// </summary>
		protected RMethod r_MSave_String;
		public virtual RMethod RMSave_String
		{
			get
			{
				if(r_MSave_String == null)
				{
					r_MSave_String = new(this, "Save", 0, typeof(System.String));
				}
				return r_MSave_String;
			}
		}

		/// <summary>
		/// Void SetEntryPoint(System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_MSetEntryPoint_MethodInfo;
		public virtual RMethod RMSetEntryPoint_MethodInfo
		{
			get
			{
				if(r_MSetEntryPoint_MethodInfo == null)
				{
					r_MSetEntryPoint_MethodInfo = new(this, "SetEntryPoint", 0, typeof(System.Reflection.MethodInfo));
				}
				return r_MSetEntryPoint_MethodInfo;
			}
		}

		/// <summary>
		/// Void SetEntryPoint(System.Reflection.MethodInfo, System.Reflection.Emit.PEFileKinds)
		/// </summary>
		protected RMethod r_MSetEntryPoint_MethodInfo_PEFileKinds;
		public virtual RMethod RMSetEntryPoint_MethodInfo_PEFileKinds
		{
			get
			{
				if(r_MSetEntryPoint_MethodInfo_PEFileKinds == null)
				{
					r_MSetEntryPoint_MethodInfo_PEFileKinds = new(this, "SetEntryPoint", 0, typeof(System.Reflection.MethodInfo), typeof(System.Reflection.Emit.PEFileKinds));
				}
				return r_MSetEntryPoint_MethodInfo_PEFileKinds;
			}
		}

		/// <summary>
		/// Void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder)
		/// </summary>
		protected RMethod r_MSetCustomAttribute_CustomAttributeBuilder;
		public virtual RMethod RMSetCustomAttribute_CustomAttributeBuilder
		{
			get
			{
				if(r_MSetCustomAttribute_CustomAttributeBuilder == null)
				{
					r_MSetCustomAttribute_CustomAttributeBuilder = new(this, "SetCustomAttribute", 0, typeof(System.Reflection.Emit.CustomAttributeBuilder));
				}
				return r_MSetCustomAttribute_CustomAttributeBuilder;
			}
		}

		/// <summary>
		/// Void SetCustomAttribute(System.Reflection.ConstructorInfo, Byte[])
		/// </summary>
		protected RMethod r_MSetCustomAttribute_ConstructorInfo_ByteArray;
		public virtual RMethod RMSetCustomAttribute_ConstructorInfo_ByteArray
		{
			get
			{
				if(r_MSetCustomAttribute_ConstructorInfo_ByteArray == null)
				{
					r_MSetCustomAttribute_ConstructorInfo_ByteArray = new(this, "SetCustomAttribute", 0, typeof(System.Reflection.ConstructorInfo), typeof(System.Byte).MakeArrayType());
				}
				return r_MSetCustomAttribute_ConstructorInfo_ByteArray;
			}
		}

		/// <summary>
		/// System.Exception not_supported()
		/// </summary>
		protected RMethod r_Mnot_supported;
		public virtual RMethod RMnot_supported
		{
			get
			{
				if(r_Mnot_supported == null)
				{
					r_Mnot_supported = new(this, "not_supported", 0);
				}
				return r_Mnot_supported;
			}
		}

		/// <summary>
		/// Void check_name_and_filename(System.String, System.String, Boolean)
		/// </summary>
		protected RMethod r_Mcheck_name_and_filename_String_String_Boolean;
		public virtual RMethod RMcheck_name_and_filename_String_String_Boolean
		{
			get
			{
				if(r_Mcheck_name_and_filename_String_String_Boolean == null)
				{
					r_Mcheck_name_and_filename_String_String_Boolean = new(this, "check_name_and_filename", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean));
				}
				return r_Mcheck_name_and_filename_String_String_Boolean;
			}
		}

		/// <summary>
		/// System.String create_assembly_version(System.String)
		/// </summary>
		protected RMethod r_Mcreate_assembly_version_String;
		public virtual RMethod RMcreate_assembly_version_String
		{
			get
			{
				if(r_Mcreate_assembly_version_String == null)
				{
					r_Mcreate_assembly_version_String = new(this, "create_assembly_version", 0, typeof(System.String));
				}
				return r_Mcreate_assembly_version_String;
			}
		}

		/// <summary>
		/// System.String GetCultureString(System.String)
		/// </summary>
		protected RMethod r_MGetCultureString_String;
		public virtual RMethod RMGetCultureString_String
		{
			get
			{
				if(r_MGetCultureString_String == null)
				{
					r_MGetCultureString_String = new(this, "GetCultureString", 0, typeof(System.String));
				}
				return r_MGetCultureString_String;
			}
		}

		/// <summary>
		/// System.Type MakeGenericType(System.Type, System.Type[])
		/// </summary>
		protected RMethod r_MMakeGenericType_Type_TypeArray;
		public virtual RMethod RMMakeGenericType_Type_TypeArray
		{
			get
			{
				if(r_MMakeGenericType_Type_TypeArray == null)
				{
					r_MMakeGenericType_Type_TypeArray = new(this, "MakeGenericType", 0, typeof(System.Type), typeof(System.Type).MakeArrayType());
				}
				return r_MMakeGenericType_Type_TypeArray;
			}
		}

		/// <summary>
		/// System.Type GetType(System.String, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MGetType_String_Boolean_Boolean;
		public virtual RMethod RMGetType_String_Boolean_Boolean
		{
			get
			{
				if(r_MGetType_String_Boolean_Boolean == null)
				{
					r_MGetType_String_Boolean_Boolean = new(this, "GetType", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MGetType_String_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.Module GetModule(System.String)
		/// </summary>
		protected RMethod r_MGetModule_String;
		public virtual RMethod RMGetModule_String
		{
			get
			{
				if(r_MGetModule_String == null)
				{
					r_MGetModule_String = new(this, "GetModule", 0, typeof(System.String));
				}
				return r_MGetModule_String;
			}
		}

		/// <summary>
		/// System.Reflection.Module[] GetModules(Boolean)
		/// </summary>
		protected RMethod r_MGetModules_Boolean;
		public virtual RMethod RMGetModules_Boolean
		{
			get
			{
				if(r_MGetModules_Boolean == null)
				{
					r_MGetModules_Boolean = new(this, "GetModules", 0, typeof(System.Boolean));
				}
				return r_MGetModules_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.AssemblyName GetName(Boolean)
		/// </summary>
		protected RMethod r_MGetName_Boolean;
		public virtual RMethod RMGetName_Boolean
		{
			get
			{
				if(r_MGetName_Boolean == null)
				{
					r_MGetName_Boolean = new(this, "GetName", 0, typeof(System.Boolean));
				}
				return r_MGetName_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.AssemblyName[] GetReferencedAssemblies()
		/// </summary>
		protected RMethod r_MGetReferencedAssemblies;
		public virtual RMethod RMGetReferencedAssemblies
		{
			get
			{
				if(r_MGetReferencedAssemblies == null)
				{
					r_MGetReferencedAssemblies = new(this, "GetReferencedAssemblies", 0);
				}
				return r_MGetReferencedAssemblies;
			}
		}

		/// <summary>
		/// System.Reflection.Module[] GetLoadedModules(Boolean)
		/// </summary>
		protected RMethod r_MGetLoadedModules_Boolean;
		public virtual RMethod RMGetLoadedModules_Boolean
		{
			get
			{
				if(r_MGetLoadedModules_Boolean == null)
				{
					r_MGetLoadedModules_Boolean = new(this, "GetLoadedModules", 0, typeof(System.Boolean));
				}
				return r_MGetLoadedModules_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly GetSatelliteAssembly(System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_MGetSatelliteAssembly_CultureInfo;
		public virtual RMethod RMGetSatelliteAssembly_CultureInfo
		{
			get
			{
				if(r_MGetSatelliteAssembly_CultureInfo == null)
				{
					r_MGetSatelliteAssembly_CultureInfo = new(this, "GetSatelliteAssembly", 0, typeof(System.Globalization.CultureInfo));
				}
				return r_MGetSatelliteAssembly_CultureInfo;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly GetSatelliteAssembly(System.Globalization.CultureInfo, System.Version)
		/// </summary>
		protected RMethod r_MGetSatelliteAssembly_CultureInfo_Version;
		public virtual RMethod RMGetSatelliteAssembly_CultureInfo_Version
		{
			get
			{
				if(r_MGetSatelliteAssembly_CultureInfo_Version == null)
				{
					r_MGetSatelliteAssembly_CultureInfo_Version = new(this, "GetSatelliteAssembly", 0, typeof(System.Globalization.CultureInfo), typeof(System.Version));
				}
				return r_MGetSatelliteAssembly_CultureInfo_Version;
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
		/// Boolean IsDefined(System.Type, Boolean)
		/// </summary>
		protected RMethod r_MIsDefined_Type_Boolean;
		public virtual RMethod RMIsDefined_Type_Boolean
		{
			get
			{
				if(r_MIsDefined_Type_Boolean == null)
				{
					r_MIsDefined_Type_Boolean = new(this, "IsDefined", 0, typeof(System.Type), typeof(System.Boolean));
				}
				return r_MIsDefined_Type_Boolean;
			}
		}

		/// <summary>
		/// System.Object[] GetCustomAttributes(Boolean)
		/// </summary>
		protected RMethod r_MGetCustomAttributes_Boolean;
		public virtual RMethod RMGetCustomAttributes_Boolean
		{
			get
			{
				if(r_MGetCustomAttributes_Boolean == null)
				{
					r_MGetCustomAttributes_Boolean = new(this, "GetCustomAttributes", 0, typeof(System.Boolean));
				}
				return r_MGetCustomAttributes_Boolean;
			}
		}

		/// <summary>
		/// System.Object[] GetCustomAttributes(System.Type, Boolean)
		/// </summary>
		protected RMethod r_MGetCustomAttributes_Type_Boolean;
		public virtual RMethod RMGetCustomAttributes_Type_Boolean
		{
			get
			{
				if(r_MGetCustomAttributes_Type_Boolean == null)
				{
					r_MGetCustomAttributes_Type_Boolean = new(this, "GetCustomAttributes", 0, typeof(System.Type), typeof(System.Boolean));
				}
				return r_MGetCustomAttributes_Type_Boolean;
			}
		}

		/// <summary>
		/// System.Security.Policy.Evidence UnprotectedGetEvidence()
		/// </summary>
		protected RMethod r_MUnprotectedGetEvidence;
		public virtual RMethod RMUnprotectedGetEvidence
		{
			get
			{
				if(r_MUnprotectedGetEvidence == null)
				{
					r_MUnprotectedGetEvidence = new(this, "UnprotectedGetEvidence", 0);
				}
				return r_MUnprotectedGetEvidence;
			}
		}

		/// <summary>
		/// Void GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MGetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RMGetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_MGetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_MGetObjectData_SerializationInfo_StreamingContext = new(this, "GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
				}
				return r_MGetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// System.IO.FileStream[] GetFiles()
		/// </summary>
		protected RMethod r_MGetFiles;
		public virtual RMethod RMGetFiles
		{
			get
			{
				if(r_MGetFiles == null)
				{
					r_MGetFiles = new(this, "GetFiles", 0);
				}
				return r_MGetFiles;
			}
		}

		/// <summary>
		/// System.IO.Stream GetManifestResourceStream(System.Type, System.String, Boolean, System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected RMethod r_MGetManifestResourceStream_Type_String_Boolean_Ref_StackCrawlMark;
		public virtual RMethod RMGetManifestResourceStream_Type_String_Boolean_Ref_StackCrawlMark
		{
			get
			{
				if(r_MGetManifestResourceStream_Type_String_Boolean_Ref_StackCrawlMark == null)
				{
					r_MGetManifestResourceStream_Type_String_Boolean_Ref_StackCrawlMark = new(this, "GetManifestResourceStream", 0, typeof(System.Type), typeof(System.String), typeof(System.Boolean),  ReflectionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
				}
				return r_MGetManifestResourceStream_Type_String_Boolean_Ref_StackCrawlMark;
			}
		}

		/// <summary>
		/// System.IO.Stream GetManifestResourceStream(System.String, System.Threading.StackCrawlMark ByRef, Boolean)
		/// </summary>
		protected RMethod r_MGetManifestResourceStream_String_Ref_StackCrawlMark_Boolean;
		public virtual RMethod RMGetManifestResourceStream_String_Ref_StackCrawlMark_Boolean
		{
			get
			{
				if(r_MGetManifestResourceStream_String_Ref_StackCrawlMark_Boolean == null)
				{
					r_MGetManifestResourceStream_String_Ref_StackCrawlMark_Boolean = new(this, "GetManifestResourceStream", 0, typeof(System.String),  ReflectionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType(), typeof(System.Boolean));
				}
				return r_MGetManifestResourceStream_String_Ref_StackCrawlMark_Boolean;
			}
		}

		/// <summary>
		/// System.String GetSimpleName()
		/// </summary>
		protected RMethod r_MGetSimpleName;
		public virtual RMethod RMGetSimpleName
		{
			get
			{
				if(r_MGetSimpleName == null)
				{
					r_MGetSimpleName = new(this, "GetSimpleName", 0);
				}
				return r_MGetSimpleName;
			}
		}

		/// <summary>
		/// Byte[] GetPublicKey()
		/// </summary>
		protected RMethod r_MGetPublicKey;
		public virtual RMethod RMGetPublicKey
		{
			get
			{
				if(r_MGetPublicKey == null)
				{
					r_MGetPublicKey = new(this, "GetPublicKey", 0);
				}
				return r_MGetPublicKey;
			}
		}

		/// <summary>
		/// System.Version GetVersion()
		/// </summary>
		protected RMethod r_MGetVersion;
		public virtual RMethod RMGetVersion
		{
			get
			{
				if(r_MGetVersion == null)
				{
					r_MGetVersion = new(this, "GetVersion", 0);
				}
				return r_MGetVersion;
			}
		}

		/// <summary>
		/// System.Type[] GetTypes()
		/// </summary>
		protected RMethod r_MGetTypes;
		public virtual RMethod RMGetTypes
		{
			get
			{
				if(r_MGetTypes == null)
				{
					r_MGetTypes = new(this, "GetTypes", 0);
				}
				return r_MGetTypes;
			}
		}

		/// <summary>
		/// System.Type GetType(System.String, Boolean)
		/// </summary>
		protected RMethod r_MGetType_String_Boolean;
		public virtual RMethod RMGetType_String_Boolean
		{
			get
			{
				if(r_MGetType_String_Boolean == null)
				{
					r_MGetType_String_Boolean = new(this, "GetType", 0, typeof(System.String), typeof(System.Boolean));
				}
				return r_MGetType_String_Boolean;
			}
		}

		/// <summary>
		/// System.Type GetType(System.String)
		/// </summary>
		protected RMethod r_MGetType_String;
		public virtual RMethod RMGetType_String
		{
			get
			{
				if(r_MGetType_String == null)
				{
					r_MGetType_String = new(this, "GetType", 0, typeof(System.String));
				}
				return r_MGetType_String;
			}
		}

		/// <summary>
		/// System.Type InternalGetType(System.Reflection.Module, System.String, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MInternalGetType_Module_String_Boolean_Boolean;
		public virtual RMethod RMInternalGetType_Module_String_Boolean_Boolean
		{
			get
			{
				if(r_MInternalGetType_Module_String_Boolean_Boolean == null)
				{
					r_MInternalGetType_Module_String_Boolean_Boolean = new(this, "InternalGetType", 0, typeof(System.Reflection.Module), typeof(System.String), typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MInternalGetType_Module_String_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.AssemblyName GetName()
		/// </summary>
		protected RMethod r_MGetName;
		public virtual RMethod RMGetName
		{
			get
			{
				if(r_MGetName == null)
				{
					r_MGetName = new(this, "GetName", 0);
				}
				return r_MGetName;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly GetSatelliteAssembly(System.Globalization.CultureInfo, System.Version, Boolean, System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected RMethod r_MGetSatelliteAssembly_CultureInfo_Version_Boolean_Ref_StackCrawlMark;
		public virtual RMethod RMGetSatelliteAssembly_CultureInfo_Version_Boolean_Ref_StackCrawlMark
		{
			get
			{
				if(r_MGetSatelliteAssembly_CultureInfo_Version_Boolean_Ref_StackCrawlMark == null)
				{
					r_MGetSatelliteAssembly_CultureInfo_Version_Boolean_Ref_StackCrawlMark = new(this, "GetSatelliteAssembly", 0, typeof(System.Globalization.CultureInfo), typeof(System.Version), typeof(System.Boolean),  ReflectionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
				}
				return r_MGetSatelliteAssembly_CultureInfo_Version_Boolean_Ref_StackCrawlMark;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimeAssembly InternalGetSatelliteAssembly(System.String, System.Globalization.CultureInfo, System.Version, Boolean, System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected RMethod r_MInternalGetSatelliteAssembly_String_CultureInfo_Version_Boolean_Ref_StackCrawlMark;
		public virtual RMethod RMInternalGetSatelliteAssembly_String_CultureInfo_Version_Boolean_Ref_StackCrawlMark
		{
			get
			{
				if(r_MInternalGetSatelliteAssembly_String_CultureInfo_Version_Boolean_Ref_StackCrawlMark == null)
				{
					r_MInternalGetSatelliteAssembly_String_CultureInfo_Version_Boolean_Ref_StackCrawlMark = new(this, "InternalGetSatelliteAssembly", 0, typeof(System.String), typeof(System.Globalization.CultureInfo), typeof(System.Version), typeof(System.Boolean),  ReflectionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
				}
				return r_MInternalGetSatelliteAssembly_String_CultureInfo_Version_Boolean_Ref_StackCrawlMark;
			}
		}

		/// <summary>
		/// System.Reflection.Module LoadModule(System.String, Byte[])
		/// </summary>
		protected RMethod r_MLoadModule_String_ByteArray;
		public virtual RMethod RMLoadModule_String_ByteArray
		{
			get
			{
				if(r_MLoadModule_String_ByteArray == null)
				{
					r_MLoadModule_String_ByteArray = new(this, "LoadModule", 0, typeof(System.String), typeof(System.Byte).MakeArrayType());
				}
				return r_MLoadModule_String_ByteArray;
			}
		}

		/// <summary>
		/// System.Reflection.Module LoadModule(System.String, Byte[], Byte[])
		/// </summary>
		protected RMethod r_MLoadModule_String_ByteArray_ByteArray;
		public virtual RMethod RMLoadModule_String_ByteArray_ByteArray
		{
			get
			{
				if(r_MLoadModule_String_ByteArray_ByteArray == null)
				{
					r_MLoadModule_String_ByteArray_ByteArray = new(this, "LoadModule", 0, typeof(System.String), typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType());
				}
				return r_MLoadModule_String_ByteArray_ByteArray;
			}
		}

		/// <summary>
		/// System.Object CreateInstance(System.String)
		/// </summary>
		protected RMethod r_MCreateInstance_String;
		public virtual RMethod RMCreateInstance_String
		{
			get
			{
				if(r_MCreateInstance_String == null)
				{
					r_MCreateInstance_String = new(this, "CreateInstance", 0, typeof(System.String));
				}
				return r_MCreateInstance_String;
			}
		}

		/// <summary>
		/// System.Object CreateInstance(System.String, Boolean)
		/// </summary>
		protected RMethod r_MCreateInstance_String_Boolean;
		public virtual RMethod RMCreateInstance_String_Boolean
		{
			get
			{
				if(r_MCreateInstance_String_Boolean == null)
				{
					r_MCreateInstance_String_Boolean = new(this, "CreateInstance", 0, typeof(System.String), typeof(System.Boolean));
				}
				return r_MCreateInstance_String_Boolean;
			}
		}

		/// <summary>
		/// System.Object CreateInstance(System.String, Boolean, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo, System.Object[])
		/// </summary>
		protected RMethod r_MCreateInstance_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray;
		public virtual RMethod RMCreateInstance_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray
		{
			get
			{
				if(r_MCreateInstance_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray == null)
				{
					r_MCreateInstance_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray = new(this, "CreateInstance", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.Object).MakeArrayType());
				}
				return r_MCreateInstance_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray;
			}
		}

		/// <summary>
		/// System.Reflection.Module[] GetLoadedModules()
		/// </summary>
		protected RMethod r_MGetLoadedModules;
		public virtual RMethod RMGetLoadedModules
		{
			get
			{
				if(r_MGetLoadedModules == null)
				{
					r_MGetLoadedModules = new(this, "GetLoadedModules", 0);
				}
				return r_MGetLoadedModules;
			}
		}

		/// <summary>
		/// System.Reflection.Module[] GetModules()
		/// </summary>
		protected RMethod r_MGetModules;
		public virtual RMethod RMGetModules
		{
			get
			{
				if(r_MGetModules == null)
				{
					r_MGetModules = new(this, "GetModules", 0);
				}
				return r_MGetModules;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.CustomAttributeData] GetCustomAttributesData()
		/// </summary>
		protected RMethod r_MGetCustomAttributesData;
		public virtual RMethod RMGetCustomAttributesData
		{
			get
			{
				if(r_MGetCustomAttributesData == null)
				{
					r_MGetCustomAttributesData = new(this, "GetCustomAttributesData", 0);
				}
				return r_MGetCustomAttributesData;
			}
		}

		/// <summary>
		/// System.Type[] GetForwardedTypes()
		/// </summary>
		protected RMethod r_MGetForwardedTypes;
		public virtual RMethod RMGetForwardedTypes
		{
			get
			{
				if(r_MGetForwardedTypes == null)
				{
					r_MGetForwardedTypes = new(this, "GetForwardedTypes", 0);
				}
				return r_MGetForwardedTypes;
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


        public virtual void System__2__Runtime__2__InteropServices__2___AssemblyBuilder__2__GetIDsOfNames(in System.Guid @riid, System.IntPtr @rgszNames, System.UInt32 @cNames, System.UInt32 @lcid, System.IntPtr @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___AssemblyBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___AssemblyBuilder__2__GetTypeInfo(System.UInt32 @iTInfo, System.UInt32 @lcid, System.IntPtr @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___AssemblyBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___AssemblyBuilder__2__GetTypeInfoCount(out System.UInt32 @pcTInfo)
        {
			@pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___AssemblyBuilder__2__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			@pcTInfo = ReflectionUtils.Convert<System.UInt32>(___parameters[0]);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___AssemblyBuilder__2__Invoke(System.UInt32 @dispIdMember, in System.Guid @riid, System.UInt32 @lcid, System.Int16 @wFlags, System.IntPtr @pDispParams, System.IntPtr @pVarResult, System.IntPtr @pExcepInfo, System.IntPtr @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___AssemblyBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public static void basic_init(System.Reflection.Emit.AssemblyBuilder @ab)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ab};
            var ___result = RMbasic_init_AssemblyBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public static void UpdateNativeCustomAttributes(System.Reflection.Emit.AssemblyBuilder @ab)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ab};
            var ___result = RMUpdateNativeCustomAttributes_AssemblyBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddResourceFile(System.String @name, System.String @fileName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @fileName};
            var ___result = RMAddResourceFile_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddResourceFile(System.String @name, System.String @fileName, System.Reflection.ResourceAttributes @attribute)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @fileName, @attribute};
            var ___result = RMAddResourceFile_String_String_ResourceAttributes.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddResourceFile(System.String @name, System.String @fileName, System.Reflection.ResourceAttributes @attribute, System.Boolean @fileNeedsToExists)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @fileName, @attribute, @fileNeedsToExists};
            var ___result = RMAddResourceFile_String_String_ResourceAttributes_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddPermissionRequests(System.Security.PermissionSet @required, System.Security.PermissionSet @optional, System.Security.PermissionSet @refused)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@required, @optional, @refused};
            var ___result = RMAddPermissionRequests_PermissionSet_PermissionSet_PermissionSet.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EmbedResourceFile(System.String @name, System.String @fileName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @fileName};
            var ___result = RMEmbedResourceFile_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EmbedResourceFile(System.String @name, System.String @fileName, System.Reflection.ResourceAttributes @attribute)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @fileName, @attribute};
            var ___result = RMEmbedResourceFile_String_String_ResourceAttributes.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName @name, System.Reflection.Emit.AssemblyBuilderAccess @access)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @access};
            var ___result = RMDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.AssemblyBuilder>(___result);
        }


        public static System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName @name, System.Reflection.Emit.AssemblyBuilderAccess @access, System.Collections.Generic.IEnumerable<System.Reflection.Emit.CustomAttributeBuilder> @assemblyAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @access, @assemblyAttributes};
            var ___result = RMDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.AssemblyBuilder>(___result);
        }


        public virtual System.Reflection.Emit.ModuleBuilder DefineDynamicModule(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMDefineDynamicModule_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.ModuleBuilder>(___result);
        }


        public virtual System.Reflection.Emit.ModuleBuilder DefineDynamicModule(System.String @name, System.Boolean @emitSymbolInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @emitSymbolInfo};
            var ___result = RMDefineDynamicModule_String_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.ModuleBuilder>(___result);
        }


        public virtual System.Reflection.Emit.ModuleBuilder DefineDynamicModule(System.String @name, System.String @fileName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @fileName};
            var ___result = RMDefineDynamicModule_String_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.ModuleBuilder>(___result);
        }


        public virtual System.Reflection.Emit.ModuleBuilder DefineDynamicModule(System.String @name, System.String @fileName, System.Boolean @emitSymbolInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @fileName, @emitSymbolInfo};
            var ___result = RMDefineDynamicModule_String_String_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.ModuleBuilder>(___result);
        }


        public virtual System.Reflection.Emit.ModuleBuilder DefineDynamicModule(System.String @name, System.String @fileName, System.Boolean @emitSymbolInfo, System.Boolean @transient)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @fileName, @emitSymbolInfo, @transient};
            var ___result = RMDefineDynamicModule_String_String_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.ModuleBuilder>(___result);
        }


        public virtual System.Resources.IResourceWriter DefineResource(System.String @name, System.String @description, System.String @fileName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @description, @fileName};
            var ___result = RMDefineResource_String_String_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Resources.IResourceWriter>(___result);
        }


        public virtual System.Resources.IResourceWriter DefineResource(System.String @name, System.String @description, System.String @fileName, System.Reflection.ResourceAttributes @attribute)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @description, @fileName, @attribute};
            var ___result = RMDefineResource_String_String_String_ResourceAttributes.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Resources.IResourceWriter>(___result);
        }


        public virtual void AddUnmanagedResource(Hvak.Editor.Refleaction.RSystem.RResources.RWin32Resource @res)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@res.Value};
            var ___result = RMAddUnmanagedResource_Win32Resource.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DefineUnmanagedResource(System.Byte[] @resource)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resource};
            var ___result = RMDefineUnmanagedResource_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DefineUnmanagedResource(System.String @resourceFileName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resourceFileName};
            var ___result = RMDefineUnmanagedResource_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DefineVersionInfoResource()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDefineVersionInfoResource.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DefineVersionInfoResource(System.String @product, System.String @productVersion, System.String @company, System.String @copyright, System.String @trademark)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@product, @productVersion, @company, @copyright, @trademark};
            var ___result = RMDefineVersionInfoResource_String_String_String_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DefineVersionInfoResourceImpl(System.String @fileName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileName};
            var ___result = RMDefineVersionInfoResourceImpl_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.Emit.ModuleBuilder GetDynamicModule(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetDynamicModule_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.ModuleBuilder>(___result);
        }


        public virtual System.Type[] GetExportedTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetExportedTypes.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type[]>(___result);
        }


        public virtual System.IO.FileStream GetFile(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetFile_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IO.FileStream>(___result);
        }


        public virtual System.IO.FileStream[] GetFiles(System.Boolean @getResourceModules)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@getResourceModules};
            var ___result = RMGetFiles_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IO.FileStream[]>(___result);
        }


        public virtual System.Reflection.Module[] GetModulesInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetModulesInternal.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Module[]>(___result);
        }


        public virtual System.Type[] GetTypes(System.Boolean @exportedOnly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exportedOnly};
            var ___result = RMGetTypes_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type[]>(___result);
        }


        public virtual System.Reflection.ManifestResourceInfo GetManifestResourceInfo(System.String @resourceName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resourceName};
            var ___result = RMGetManifestResourceInfo_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.ManifestResourceInfo>(___result);
        }


        public virtual System.String[] GetManifestResourceNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetManifestResourceNames.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String[]>(___result);
        }


        public virtual System.IO.Stream GetManifestResourceStream(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetManifestResourceStream_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IO.Stream>(___result);
        }


        public virtual System.IO.Stream GetManifestResourceStream(System.Type @type, System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @name};
            var ___result = RMGetManifestResourceStream_Type_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IO.Stream>(___result);
        }


        public virtual System.Reflection.Module GetManifestModule()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetManifestModule.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Module>(___result);
        }


        public virtual void Save(System.String @assemblyFileName, System.Reflection.PortableExecutableKinds @portableExecutableKind, System.Reflection.ImageFileMachine @imageFileMachine)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFileName, @portableExecutableKind, @imageFileMachine};
            var ___result = RMSave_String_PortableExecutableKinds_ImageFileMachine.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Save(System.String @assemblyFileName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFileName};
            var ___result = RMSave_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetEntryPoint(System.Reflection.MethodInfo @entryMethod)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@entryMethod};
            var ___result = RMSetEntryPoint_MethodInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetEntryPoint(System.Reflection.MethodInfo @entryMethod, System.Reflection.Emit.PEFileKinds @fileKind)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@entryMethod, @fileKind};
            var ___result = RMSetEntryPoint_MethodInfo_PEFileKinds.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder @customBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@customBuilder};
            var ___result = RMSetCustomAttribute_CustomAttributeBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCustomAttribute(System.Reflection.ConstructorInfo @con, System.Byte[] @binaryAttribute)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@con, @binaryAttribute};
            var ___result = RMSetCustomAttribute_ConstructorInfo_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Exception not_supported()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMnot_supported.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Exception>(___result);
        }


        public virtual void check_name_and_filename(System.String @name, System.String @fileName, System.Boolean @fileNeedsToExists)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @fileName, @fileNeedsToExists};
            var ___result = RMcheck_name_and_filename_String_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String create_assembly_version(System.String @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version};
            var ___result = RMcreate_assembly_version_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String GetCultureString(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RMGetCultureString_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Type MakeGenericType(System.Type @gtd, System.Type[] @typeArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@gtd, @typeArguments};
            var ___result = RMMakeGenericType_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Type GetType(System.String @name, System.Boolean @throwOnError, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @throwOnError, @ignoreCase};
            var ___result = RMGetType_String_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Reflection.Module GetModule(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetModule_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Module>(___result);
        }


        public virtual System.Reflection.Module[] GetModules(System.Boolean @getResourceModules)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@getResourceModules};
            var ___result = RMGetModules_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Module[]>(___result);
        }


        public virtual System.Reflection.AssemblyName GetName(System.Boolean @copiedName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@copiedName};
            var ___result = RMGetName_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.AssemblyName>(___result);
        }


        public virtual System.Reflection.AssemblyName[] GetReferencedAssemblies()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetReferencedAssemblies.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.AssemblyName[]>(___result);
        }


        public virtual System.Reflection.Module[] GetLoadedModules(System.Boolean @getResourceModules)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@getResourceModules};
            var ___result = RMGetLoadedModules_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Module[]>(___result);
        }


        public virtual System.Reflection.Assembly GetSatelliteAssembly(System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@culture};
            var ___result = RMGetSatelliteAssembly_CultureInfo.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Assembly>(___result);
        }


        public virtual System.Reflection.Assembly GetSatelliteAssembly(System.Globalization.CultureInfo @culture, System.Version @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@culture, @version};
            var ___result = RMGetSatelliteAssembly_CultureInfo_Version.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Assembly>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean IsDefined(System.Type @attributeType, System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RMIsDefined_Type_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Object[] GetCustomAttributes(System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inherit};
            var ___result = RMGetCustomAttributes_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object[]>(___result);
        }


        public virtual System.Object[] GetCustomAttributes(System.Type @attributeType, System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RMGetCustomAttributes_Type_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object[]>(___result);
        }


        public virtual System.Security.Policy.Evidence UnprotectedGetEvidence()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUnprotectedGetEvidence.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Security.Policy.Evidence>(___result);
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IO.FileStream[] GetFiles()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetFiles.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IO.FileStream[]>(___result);
        }


        public virtual System.IO.Stream GetManifestResourceStream(System.Type @type, System.String @name, System.Boolean @skipSecurityCheck, ref Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark @stackMark)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @name, @skipSecurityCheck, @stackMark.Value};
            var ___result = RMGetManifestResourceStream_Type_String_Boolean_Ref_StackCrawlMark.Invoke(___genericsType, ___parameters);
			@stackMark = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark>(___parameters[3]);

            return ReflectionUtils.Convert<System.IO.Stream>(___result);
        }


        public virtual System.IO.Stream GetManifestResourceStream(System.String @name, ref Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark @stackMark, System.Boolean @skipSecurityCheck)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @stackMark.Value, @skipSecurityCheck};
            var ___result = RMGetManifestResourceStream_String_Ref_StackCrawlMark_Boolean.Invoke(___genericsType, ___parameters);
			@stackMark = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark>(___parameters[1]);

            return ReflectionUtils.Convert<System.IO.Stream>(___result);
        }


        public virtual System.String GetSimpleName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSimpleName.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Byte[] GetPublicKey()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPublicKey.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Byte[]>(___result);
        }


        public virtual System.Version GetVersion()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetVersion.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Version>(___result);
        }


        public virtual System.Type[] GetTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypes.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type[]>(___result);
        }


        public virtual System.Type GetType(System.String @name, System.Boolean @throwOnError)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @throwOnError};
            var ___result = RMGetType_String_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Type GetType(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetType_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Type InternalGetType(System.Reflection.Module @module, System.String @name, System.Boolean @throwOnError, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module, @name, @throwOnError, @ignoreCase};
            var ___result = RMInternalGetType_Module_String_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Reflection.AssemblyName GetName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetName.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.AssemblyName>(___result);
        }


        public virtual System.Reflection.Assembly GetSatelliteAssembly(System.Globalization.CultureInfo @culture, System.Version @version, System.Boolean @throwOnError, ref Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark @stackMark)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@culture, @version, @throwOnError, @stackMark.Value};
            var ___result = RMGetSatelliteAssembly_CultureInfo_Version_Boolean_Ref_StackCrawlMark.Invoke(___genericsType, ___parameters);
			@stackMark = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark>(___parameters[3]);

            return ReflectionUtils.Convert<System.Reflection.Assembly>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeAssembly InternalGetSatelliteAssembly(System.String @name, System.Globalization.CultureInfo @culture, System.Version @version, System.Boolean @throwOnFileNotFound, ref Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark @stackMark)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @culture, @version, @throwOnFileNotFound, @stackMark.Value};
            var ___result = RMInternalGetSatelliteAssembly_String_CultureInfo_Version_Boolean_Ref_StackCrawlMark.Invoke(___genericsType, ___parameters);
			@stackMark = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark>(___parameters[4]);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeAssembly>(___result);
        }


        public virtual System.Reflection.Module LoadModule(System.String @moduleName, System.Byte[] @rawModule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@moduleName, @rawModule};
            var ___result = RMLoadModule_String_ByteArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Module>(___result);
        }


        public virtual System.Reflection.Module LoadModule(System.String @moduleName, System.Byte[] @rawModule, System.Byte[] @rawSymbolStore)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@moduleName, @rawModule, @rawSymbolStore};
            var ___result = RMLoadModule_String_ByteArray_ByteArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Module>(___result);
        }


        public virtual System.Object CreateInstance(System.String @typeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName};
            var ___result = RMCreateInstance_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Object CreateInstance(System.String @typeName, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName, @ignoreCase};
            var ___result = RMCreateInstance_String_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Object CreateInstance(System.String @typeName, System.Boolean @ignoreCase, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Object[] @args, System.Globalization.CultureInfo @culture, System.Object[] @activationAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName, @ignoreCase, @bindingAttr, @binder, @args, @culture, @activationAttributes};
            var ___result = RMCreateInstance_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Reflection.Module[] GetLoadedModules()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetLoadedModules.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Module[]>(___result);
        }


        public virtual System.Reflection.Module[] GetModules()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetModules.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Module[]>(___result);
        }


        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCustomAttributesData.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.Generic.IList<System.Reflection.CustomAttributeData>>(___result);
        }


        public virtual System.Type[] GetForwardedTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetForwardedTypes.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type[]>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
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
