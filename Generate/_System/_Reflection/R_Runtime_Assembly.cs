
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.Reflection.RuntimeAssembly
	/// </summary>
    public partial class RRuntimeAssembly : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Reflection.RuntimeAssembly");
            }
        }

        public RRuntimeAssembly() : base("System.Reflection.RuntimeAssembly")
        {
        }

        public RRuntimeAssembly(System.Object instance) : base("System.Reflection.RuntimeAssembly")
		{
            SetInstance(instance);
		}

        public RRuntimeAssembly(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRuntimeAssembly(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
		/// System.Reflection.Assembly+ResolveEventHolder resolve_event_holder
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RAssembly.RResolveEventHolder r_Fresolve_event_holder;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RAssembly.RResolveEventHolder RFresolve_event_holder
		{
			get
			{
				if(r_Fresolve_event_holder == null)
				{
					r_Fresolve_event_holder = new(this, "resolve_event_holder");
				}
				return r_Fresolve_event_holder;
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
		/// System.Boolean fromByteArray
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FfromByteArray;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFfromByteArray
		{
			get
			{
				if(r_FfromByteArray == null)
				{
					r_FfromByteArray = new(this, "fromByteArray");
				}
				return r_FfromByteArray;
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
		/// System.Reflection.RuntimeAssembly GetExecutingAssembly(System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected static RMethod r_MGetExecutingAssembly_Ref_StackCrawlMark;
		public static RMethod RMGetExecutingAssembly_Ref_StackCrawlMark
		{
			get
			{
				if(r_MGetExecutingAssembly_Ref_StackCrawlMark == null)
				{
					r_MGetExecutingAssembly_Ref_StackCrawlMark = new(Type, "GetExecutingAssembly", 0,  ReflectionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
				}
				return r_MGetExecutingAssembly_Ref_StackCrawlMark;
			}
		}

		/// <summary>
		/// System.Reflection.AssemblyName CreateAssemblyName(System.String, Boolean, System.Reflection.RuntimeAssembly ByRef)
		/// </summary>
		protected static RMethod r_MCreateAssemblyName_String_Boolean_Out_RuntimeAssembly;
		public static RMethod RMCreateAssemblyName_String_Boolean_Out_RuntimeAssembly
		{
			get
			{
				if(r_MCreateAssemblyName_String_Boolean_Out_RuntimeAssembly == null)
				{
					r_MCreateAssemblyName_String_Boolean_Out_RuntimeAssembly = new(Type, "CreateAssemblyName", 0, typeof(System.String), typeof(System.Boolean),  ReflectionUtils.GetType("System.Reflection.RuntimeAssembly").MakeByRefType());
				}
				return r_MCreateAssemblyName_String_Boolean_Out_RuntimeAssembly;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimeAssembly InternalLoadAssemblyName(System.Reflection.AssemblyName, System.Security.Policy.Evidence, System.Reflection.RuntimeAssembly, System.Threading.StackCrawlMark ByRef, Boolean, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_MInternalLoadAssemblyName_AssemblyName_Evidence_RuntimeAssembly_Ref_StackCrawlMark_Boolean_Boolean_Boolean;
		public static RMethod RMInternalLoadAssemblyName_AssemblyName_Evidence_RuntimeAssembly_Ref_StackCrawlMark_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_MInternalLoadAssemblyName_AssemblyName_Evidence_RuntimeAssembly_Ref_StackCrawlMark_Boolean_Boolean_Boolean == null)
				{
					r_MInternalLoadAssemblyName_AssemblyName_Evidence_RuntimeAssembly_Ref_StackCrawlMark_Boolean_Boolean_Boolean = new(Type, "InternalLoadAssemblyName", 0, typeof(System.Reflection.AssemblyName), typeof(System.Security.Policy.Evidence),  ReflectionUtils.GetType("System.Reflection.RuntimeAssembly"),  ReflectionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType(), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MInternalLoadAssemblyName_AssemblyName_Evidence_RuntimeAssembly_Ref_StackCrawlMark_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimeAssembly LoadWithPartialNameInternal(System.String, System.Security.Policy.Evidence, System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected static RMethod r_MLoadWithPartialNameInternal_String_Evidence_Ref_StackCrawlMark;
		public static RMethod RMLoadWithPartialNameInternal_String_Evidence_Ref_StackCrawlMark
		{
			get
			{
				if(r_MLoadWithPartialNameInternal_String_Evidence_Ref_StackCrawlMark == null)
				{
					r_MLoadWithPartialNameInternal_String_Evidence_Ref_StackCrawlMark = new(Type, "LoadWithPartialNameInternal", 0, typeof(System.String), typeof(System.Security.Policy.Evidence),  ReflectionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
				}
				return r_MLoadWithPartialNameInternal_String_Evidence_Ref_StackCrawlMark;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimeAssembly LoadWithPartialNameInternal(System.Reflection.AssemblyName, System.Security.Policy.Evidence, System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected static RMethod r_MLoadWithPartialNameInternal_AssemblyName_Evidence_Ref_StackCrawlMark;
		public static RMethod RMLoadWithPartialNameInternal_AssemblyName_Evidence_Ref_StackCrawlMark
		{
			get
			{
				if(r_MLoadWithPartialNameInternal_AssemblyName_Evidence_Ref_StackCrawlMark == null)
				{
					r_MLoadWithPartialNameInternal_AssemblyName_Evidence_Ref_StackCrawlMark = new(Type, "LoadWithPartialNameInternal", 0, typeof(System.Reflection.AssemblyName), typeof(System.Security.Policy.Evidence),  ReflectionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
				}
				return r_MLoadWithPartialNameInternal_AssemblyName_Evidence_Ref_StackCrawlMark;
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
		/// Byte[] GetAotId()
		/// </summary>
		protected static RMethod r_MGetAotId;
		public static RMethod RMGetAotId
		{
			get
			{
				if(r_MGetAotId == null)
				{
					r_MGetAotId = new(Type, "GetAotId", 0);
				}
				return r_MGetAotId;
			}
		}

		/// <summary>
		/// System.String get_code_base(System.Reflection.Assembly, Boolean)
		/// </summary>
		protected static RMethod r_Mget_code_base_Assembly_Boolean;
		public static RMethod RMget_code_base_Assembly_Boolean
		{
			get
			{
				if(r_Mget_code_base_Assembly_Boolean == null)
				{
					r_Mget_code_base_Assembly_Boolean = new(Type, "get_code_base", 0, typeof(System.Reflection.Assembly), typeof(System.Boolean));
				}
				return r_Mget_code_base_Assembly_Boolean;
			}
		}

		/// <summary>
		/// System.String get_location()
		/// </summary>
		protected RMethod r_Mget_location;
		public virtual RMethod RMget_location
		{
			get
			{
				if(r_Mget_location == null)
				{
					r_Mget_location = new(this, "get_location", 0);
				}
				return r_Mget_location;
			}
		}

		/// <summary>
		/// System.String get_fullname(System.Reflection.Assembly)
		/// </summary>
		protected static RMethod r_Mget_fullname_Assembly;
		public static RMethod RMget_fullname_Assembly
		{
			get
			{
				if(r_Mget_fullname_Assembly == null)
				{
					r_Mget_fullname_Assembly = new(Type, "get_fullname", 0, typeof(System.Reflection.Assembly));
				}
				return r_Mget_fullname_Assembly;
			}
		}

		/// <summary>
		/// Boolean GetAotIdInternal(Byte[])
		/// </summary>
		protected static RMethod r_MGetAotIdInternal_ByteArray;
		public static RMethod RMGetAotIdInternal_ByteArray
		{
			get
			{
				if(r_MGetAotIdInternal_ByteArray == null)
				{
					r_MGetAotIdInternal_ByteArray = new(Type, "GetAotIdInternal", 0, typeof(System.Byte).MakeArrayType());
				}
				return r_MGetAotIdInternal_ByteArray;
			}
		}

		/// <summary>
		/// System.String InternalImageRuntimeVersion(System.Reflection.Assembly)
		/// </summary>
		protected static RMethod r_MInternalImageRuntimeVersion_Assembly;
		public static RMethod RMInternalImageRuntimeVersion_Assembly
		{
			get
			{
				if(r_MInternalImageRuntimeVersion_Assembly == null)
				{
					r_MInternalImageRuntimeVersion_Assembly = new(Type, "InternalImageRuntimeVersion", 0, typeof(System.Reflection.Assembly));
				}
				return r_MInternalImageRuntimeVersion_Assembly;
			}
		}

		/// <summary>
		/// Boolean get_global_assembly_cache()
		/// </summary>
		protected RMethod r_Mget_global_assembly_cache;
		public virtual RMethod RMget_global_assembly_cache
		{
			get
			{
				if(r_Mget_global_assembly_cache == null)
				{
					r_Mget_global_assembly_cache = new(this, "get_global_assembly_cache", 0);
				}
				return r_Mget_global_assembly_cache;
			}
		}

		/// <summary>
		/// System.String GetCodeBase(System.Reflection.Assembly, Boolean)
		/// </summary>
		protected static RMethod r_MGetCodeBase_Assembly_Boolean;
		public static RMethod RMGetCodeBase_Assembly_Boolean
		{
			get
			{
				if(r_MGetCodeBase_Assembly_Boolean == null)
				{
					r_MGetCodeBase_Assembly_Boolean = new(Type, "GetCodeBase", 0, typeof(System.Reflection.Assembly), typeof(System.Boolean));
				}
				return r_MGetCodeBase_Assembly_Boolean;
			}
		}

		/// <summary>
		/// Boolean GetManifestResourceInfoInternal(System.String, System.Reflection.ManifestResourceInfo)
		/// </summary>
		protected RMethod r_MGetManifestResourceInfoInternal_String_ManifestResourceInfo;
		public virtual RMethod RMGetManifestResourceInfoInternal_String_ManifestResourceInfo
		{
			get
			{
				if(r_MGetManifestResourceInfoInternal_String_ManifestResourceInfo == null)
				{
					r_MGetManifestResourceInfoInternal_String_ManifestResourceInfo = new(this, "GetManifestResourceInfoInternal", 0, typeof(System.String), typeof(System.Reflection.ManifestResourceInfo));
				}
				return r_MGetManifestResourceInfoInternal_String_ManifestResourceInfo;
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
		/// IntPtr GetManifestResourceInternal(System.String, Int32 ByRef, System.Reflection.Module ByRef)
		/// </summary>
		protected RMethod r_MGetManifestResourceInternal_String_Out_Int32_Out_Module;
		public virtual RMethod RMGetManifestResourceInternal_String_Out_Int32_Out_Module
		{
			get
			{
				if(r_MGetManifestResourceInternal_String_Out_Int32_Out_Module == null)
				{
					r_MGetManifestResourceInternal_String_Out_Int32_Out_Module = new(this, "GetManifestResourceInternal", 0, typeof(System.String), typeof(System.Int32).MakeByRefType(), typeof(System.Reflection.Module).MakeByRefType());
				}
				return r_MGetManifestResourceInternal_String_Out_Int32_Out_Module;
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
		/// System.Reflection.Module GetManifestModuleInternal()
		/// </summary>
		protected RMethod r_MGetManifestModuleInternal;
		public virtual RMethod RMGetManifestModuleInternal
		{
			get
			{
				if(r_MGetManifestModuleInternal == null)
				{
					r_MGetManifestModuleInternal = new(this, "GetManifestModuleInternal", 0);
				}
				return r_MGetManifestModuleInternal;
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
		/// System.Object GetFilesInternal(System.String, Boolean)
		/// </summary>
		protected RMethod r_MGetFilesInternal_String_Boolean;
		public virtual RMethod RMGetFilesInternal_String_Boolean
		{
			get
			{
				if(r_MGetFilesInternal_String_Boolean == null)
				{
					r_MGetFilesInternal_String_Boolean = new(this, "GetFilesInternal", 0, typeof(System.String), typeof(System.Boolean));
				}
				return r_MGetFilesInternal_String_Boolean;
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
		/// Void Resolve()
		/// </summary>
		protected RMethod r_MResolve;
		public virtual RMethod RMResolve
		{
			get
			{
				if(r_MResolve == null)
				{
					r_MResolve = new(this, "Resolve", 0);
				}
				return r_MResolve;
			}
		}

		/// <summary>
		/// Boolean LoadPermissions(System.Reflection.Assembly, IntPtr ByRef, Int32 ByRef, IntPtr ByRef, Int32 ByRef, IntPtr ByRef, Int32 ByRef)
		/// </summary>
		protected static RMethod r_MLoadPermissions_Assembly_Ref_IntPtr_Ref_Int32_Ref_IntPtr_Ref_Int32_Ref_IntPtr_Ref_Int32;
		public static RMethod RMLoadPermissions_Assembly_Ref_IntPtr_Ref_Int32_Ref_IntPtr_Ref_Int32_Ref_IntPtr_Ref_Int32
		{
			get
			{
				if(r_MLoadPermissions_Assembly_Ref_IntPtr_Ref_Int32_Ref_IntPtr_Ref_Int32_Ref_IntPtr_Ref_Int32 == null)
				{
					r_MLoadPermissions_Assembly_Ref_IntPtr_Ref_Int32_Ref_IntPtr_Ref_Int32_Ref_IntPtr_Ref_Int32 = new(Type, "LoadPermissions", 0, typeof(System.Reflection.Assembly), typeof(System.IntPtr).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.IntPtr).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.IntPtr).MakeByRefType(), typeof(System.Int32).MakeByRefType());
				}
				return r_MLoadPermissions_Assembly_Ref_IntPtr_Ref_Int32_Ref_IntPtr_Ref_Int32_Ref_IntPtr_Ref_Int32;
			}
		}

		/// <summary>
		/// Void LoadAssemblyPermissions()
		/// </summary>
		protected RMethod r_MLoadAssemblyPermissions;
		public virtual RMethod RMLoadAssemblyPermissions
		{
			get
			{
				if(r_MLoadAssemblyPermissions == null)
				{
					r_MLoadAssemblyPermissions = new(this, "LoadAssemblyPermissions", 0);
				}
				return r_MLoadAssemblyPermissions;
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


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public static Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeAssembly GetExecutingAssembly(ref Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark @stackMark)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stackMark.Value};
            var ___result = RMGetExecutingAssembly_Ref_StackCrawlMark.Invoke(___genericsType, ___parameters);
			@stackMark = new Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark(___parameters[0]);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeAssembly>(___result);
        }


        public static System.Reflection.AssemblyName CreateAssemblyName(System.String @assemblyString, System.Boolean @forIntrospection, out Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeAssembly @assemblyFromResolveEvent)
        {
			@assemblyFromResolveEvent = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyString, @forIntrospection, @assemblyFromResolveEvent.Value};
            var ___result = RMCreateAssemblyName_String_Boolean_Out_RuntimeAssembly.Invoke(___genericsType, ___parameters);
			@assemblyFromResolveEvent = new Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeAssembly(___parameters[2]);

            return ReflectionUtils.Convert<System.Reflection.AssemblyName>(___result);
        }


        public static Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeAssembly InternalLoadAssemblyName(System.Reflection.AssemblyName @assemblyRef, System.Security.Policy.Evidence @assemblySecurity, Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeAssembly @reqAssembly, ref Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark @stackMark, System.Boolean @throwOnFileNotFound, System.Boolean @forIntrospection, System.Boolean @suppressSecurityChecks)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyRef, @assemblySecurity, @reqAssembly.Value, @stackMark.Value, @throwOnFileNotFound, @forIntrospection, @suppressSecurityChecks};
            var ___result = RMInternalLoadAssemblyName_AssemblyName_Evidence_RuntimeAssembly_Ref_StackCrawlMark_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);
			@stackMark = new Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark(___parameters[3]);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeAssembly>(___result);
        }


        public static Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeAssembly LoadWithPartialNameInternal(System.String @partialName, System.Security.Policy.Evidence @securityEvidence, ref Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark @stackMark)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@partialName, @securityEvidence, @stackMark.Value};
            var ___result = RMLoadWithPartialNameInternal_String_Evidence_Ref_StackCrawlMark.Invoke(___genericsType, ___parameters);
			@stackMark = new Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark(___parameters[2]);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeAssembly>(___result);
        }


        public static Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeAssembly LoadWithPartialNameInternal(System.Reflection.AssemblyName @an, System.Security.Policy.Evidence @securityEvidence, ref Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark @stackMark)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@an, @securityEvidence, @stackMark.Value};
            var ___result = RMLoadWithPartialNameInternal_AssemblyName_Evidence_Ref_StackCrawlMark.Invoke(___genericsType, ___parameters);
			@stackMark = new Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark(___parameters[2]);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeAssembly>(___result);
        }


        public virtual System.Reflection.AssemblyName GetName(System.Boolean @copiedName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@copiedName};
            var ___result = RMGetName_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.AssemblyName>(___result);
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


        public virtual System.Reflection.AssemblyName[] GetReferencedAssemblies()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetReferencedAssemblies.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.AssemblyName[]>(___result);
        }


        public virtual System.Reflection.Module[] GetModules(System.Boolean @getResourceModules)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@getResourceModules};
            var ___result = RMGetModules_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Module[]>(___result);
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


        public virtual System.Type[] GetExportedTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetExportedTypes.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type[]>(___result);
        }


        public static System.Byte[] GetAotId()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetAotId.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Byte[]>(___result);
        }


        public static System.String get_code_base(System.Reflection.Assembly @a, System.Boolean @escaped)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @escaped};
            var ___result = RMget_code_base_Assembly_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String get_location()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMget_location.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public static System.String get_fullname(System.Reflection.Assembly @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RMget_fullname_Assembly.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public static System.Boolean GetAotIdInternal(System.Byte[] @aotid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aotid};
            var ___result = RMGetAotIdInternal_ByteArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.String InternalImageRuntimeVersion(System.Reflection.Assembly @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RMInternalImageRuntimeVersion_Assembly.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean get_global_assembly_cache()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMget_global_assembly_cache.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.String GetCodeBase(System.Reflection.Assembly @a, System.Boolean @escaped)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @escaped};
            var ___result = RMGetCodeBase_Assembly_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean GetManifestResourceInfoInternal(System.String @name, System.Reflection.ManifestResourceInfo @info)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @info};
            var ___result = RMGetManifestResourceInfoInternal_String_ManifestResourceInfo.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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


        public virtual System.IntPtr GetManifestResourceInternal(System.String @name, out System.Int32 @size, out System.Reflection.Module @module)
        {
			@size = default;
			@module = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @size, @module};
            var ___result = RMGetManifestResourceInternal_String_Out_Int32_Out_Module.Invoke(___genericsType, ___parameters);
			@size = (System.Int32)___parameters[1];
			@module = (System.Reflection.Module)___parameters[2];

            return ReflectionUtils.Convert<System.IntPtr>(___result);
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


        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCustomAttributesData.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.Generic.IList<System.Reflection.CustomAttributeData>>(___result);
        }


        public virtual System.Reflection.Module GetManifestModule()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetManifestModule.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Module>(___result);
        }


        public virtual System.Reflection.Module GetManifestModuleInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetManifestModuleInternal.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Module>(___result);
        }


        public virtual System.Reflection.Module[] GetModulesInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetModulesInternal.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Module[]>(___result);
        }


        public virtual System.Object GetFilesInternal(System.String @name, System.Boolean @getResourceModules)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @getResourceModules};
            var ___result = RMGetFilesInternal_String_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.IO.FileStream[] GetFiles(System.Boolean @getResourceModules)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@getResourceModules};
            var ___result = RMGetFiles_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IO.FileStream[]>(___result);
        }


        public virtual System.IO.FileStream GetFile(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetFile_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IO.FileStream>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Equals(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Security.Policy.Evidence UnprotectedGetEvidence()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUnprotectedGetEvidence.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Security.Policy.Evidence>(___result);
        }


        public virtual void Resolve()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResolve.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean LoadPermissions(System.Reflection.Assembly @a, ref System.IntPtr @minimum, ref System.Int32 @minLength, ref System.IntPtr @optional, ref System.Int32 @optLength, ref System.IntPtr @refused, ref System.Int32 @refLength)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @minimum, @minLength, @optional, @optLength, @refused, @refLength};
            var ___result = RMLoadPermissions_Assembly_Ref_IntPtr_Ref_Int32_Ref_IntPtr_Ref_Int32_Ref_IntPtr_Ref_Int32.Invoke(___genericsType, ___parameters);
			@minimum = (System.IntPtr)___parameters[1];
			@minLength = (System.Int32)___parameters[2];
			@optional = (System.IntPtr)___parameters[3];
			@optLength = (System.Int32)___parameters[4];
			@refused = (System.IntPtr)___parameters[5];
			@refLength = (System.Int32)___parameters[6];

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void LoadAssemblyPermissions()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMLoadAssemblyPermissions.Invoke(___genericsType, ___parameters);

            
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
			@stackMark = new Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark(___parameters[3]);

            return ReflectionUtils.Convert<System.IO.Stream>(___result);
        }


        public virtual System.IO.Stream GetManifestResourceStream(System.String @name, ref Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark @stackMark, System.Boolean @skipSecurityCheck)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @stackMark.Value, @skipSecurityCheck};
            var ___result = RMGetManifestResourceStream_String_Ref_StackCrawlMark_Boolean.Invoke(___genericsType, ___parameters);
			@stackMark = new Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark(___parameters[1]);

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


        public virtual System.Type[] GetTypes(System.Boolean @exportedOnly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exportedOnly};
            var ___result = RMGetTypes_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type[]>(___result);
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
			@stackMark = new Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark(___parameters[3]);

            return ReflectionUtils.Convert<System.Reflection.Assembly>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeAssembly InternalGetSatelliteAssembly(System.String @name, System.Globalization.CultureInfo @culture, System.Version @version, System.Boolean @throwOnFileNotFound, ref Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark @stackMark)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @culture, @version, @throwOnFileNotFound, @stackMark.Value};
            var ___result = RMInternalGetSatelliteAssembly_String_CultureInfo_Version_Boolean_Ref_StackCrawlMark.Invoke(___genericsType, ___parameters);
			@stackMark = new Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark(___parameters[4]);

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
