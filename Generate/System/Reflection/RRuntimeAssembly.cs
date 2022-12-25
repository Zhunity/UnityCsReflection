using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.RuntimeAssembly
	/// </summary>
    public partial class RRuntimeAssembly : RMember //
    {

		/// <summary>
		/// System.IntPtr _mono_assembly
		/// </summary>
		protected RField r__mono_assembly;
		public virtual RField R_mono_assembly
		{
			get
			{
				if(r__mono_assembly == null)
				{
					r__mono_assembly = new(this, "_mono_assembly");
					r__mono_assembly.SetBelong(this.instance);
				}
				return r__mono_assembly;
			}
		}

		/// <summary>
		/// System.Security.Policy.Evidence _evidence
		/// </summary>
		protected RSystem.RSecurity.RPolicy.REvidence r__evidence;
		public virtual RSystem.RSecurity.RPolicy.REvidence R_evidence
		{
			get
			{
				if(r__evidence == null)
				{
					r__evidence = new(this, "_evidence");
					r__evidence.SetBelong(this.instance);
				}
				return r__evidence;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly+ResolveEventHolder resolve_event_holder
		/// </summary>
		protected RSystem.RReflection.RAssembly.RResolveEventHolder r_resolve_event_holder;
		public virtual RSystem.RReflection.RAssembly.RResolveEventHolder Rresolve_event_holder
		{
			get
			{
				if(r_resolve_event_holder == null)
				{
					r_resolve_event_holder = new(this, "resolve_event_holder");
					r_resolve_event_holder.SetBelong(this.instance);
				}
				return r_resolve_event_holder;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet _minimum
		/// </summary>
		protected RSystem.RSecurity.RPermissionSet r__minimum;
		public virtual RSystem.RSecurity.RPermissionSet R_minimum
		{
			get
			{
				if(r__minimum == null)
				{
					r__minimum = new(this, "_minimum");
					r__minimum.SetBelong(this.instance);
				}
				return r__minimum;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet _optional
		/// </summary>
		protected RSystem.RSecurity.RPermissionSet r__optional;
		public virtual RSystem.RSecurity.RPermissionSet R_optional
		{
			get
			{
				if(r__optional == null)
				{
					r__optional = new(this, "_optional");
					r__optional.SetBelong(this.instance);
				}
				return r__optional;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet _refuse
		/// </summary>
		protected RSystem.RSecurity.RPermissionSet r__refuse;
		public virtual RSystem.RSecurity.RPermissionSet R_refuse
		{
			get
			{
				if(r__refuse == null)
				{
					r__refuse = new(this, "_refuse");
					r__refuse.SetBelong(this.instance);
				}
				return r__refuse;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet _granted
		/// </summary>
		protected RSystem.RSecurity.RPermissionSet r__granted;
		public virtual RSystem.RSecurity.RPermissionSet R_granted
		{
			get
			{
				if(r__granted == null)
				{
					r__granted = new(this, "_granted");
					r__granted.SetBelong(this.instance);
				}
				return r__granted;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet _denied
		/// </summary>
		protected RSystem.RSecurity.RPermissionSet r__denied;
		public virtual RSystem.RSecurity.RPermissionSet R_denied
		{
			get
			{
				if(r__denied == null)
				{
					r__denied = new(this, "_denied");
					r__denied.SetBelong(this.instance);
				}
				return r__denied;
			}
		}

		/// <summary>
		/// System.Boolean fromByteArray
		/// </summary>
		protected RField r_fromByteArray;
		public virtual RField RfromByteArray
		{
			get
			{
				if(r_fromByteArray == null)
				{
					r_fromByteArray = new(this, "fromByteArray");
					r_fromByteArray.SetBelong(this.instance);
				}
				return r_fromByteArray;
			}
		}

		/// <summary>
		/// System.String assemblyName
		/// </summary>
		protected RField r_assemblyName;
		public virtual RField RassemblyName
		{
			get
			{
				if(r_assemblyName == null)
				{
					r_assemblyName = new(this, "assemblyName");
					r_assemblyName.SetBelong(this.instance);
				}
				return r_assemblyName;
			}
		}

		/// <summary>
		/// System.Reflection.Module ManifestModule
		/// </summary>
		protected RSystem.RReflection.RModule r_ManifestModule;
		public virtual RSystem.RReflection.RModule RManifestModule
		{
			get
			{
				if(r_ManifestModule == null)
				{
					r_ManifestModule = new(this, "ManifestModule", -1);
					r_ManifestModule.SetBelong(this.instance);
				}
				return r_ManifestModule;
			}
		}

		/// <summary>
		/// Boolean GlobalAssemblyCache
		/// </summary>
		protected RProperty r_GlobalAssemblyCache;
		public virtual RProperty RGlobalAssemblyCache
		{
			get
			{
				if(r_GlobalAssemblyCache == null)
				{
					r_GlobalAssemblyCache = new(this, "GlobalAssemblyCache", -1);
					r_GlobalAssemblyCache.SetBelong(this.instance);
				}
				return r_GlobalAssemblyCache;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo EntryPoint
		/// </summary>
		protected RSystem.RReflection.RMethodInfo r_EntryPoint;
		public virtual RSystem.RReflection.RMethodInfo REntryPoint
		{
			get
			{
				if(r_EntryPoint == null)
				{
					r_EntryPoint = new(this, "EntryPoint", -1);
					r_EntryPoint.SetBelong(this.instance);
				}
				return r_EntryPoint;
			}
		}

		/// <summary>
		/// Boolean ReflectionOnly
		/// </summary>
		protected RProperty r_ReflectionOnly;
		public virtual RProperty ReflectionOnly
		{
			get
			{
				if(r_ReflectionOnly == null)
				{
					r_ReflectionOnly = new(this, "ReflectionOnly", -1);
					r_ReflectionOnly.SetBelong(this.instance);
				}
				return r_ReflectionOnly;
			}
		}

		/// <summary>
		/// System.String CodeBase
		/// </summary>
		protected RProperty r_CodeBase;
		public virtual RProperty RCodeBase
		{
			get
			{
				if(r_CodeBase == null)
				{
					r_CodeBase = new(this, "CodeBase", -1);
					r_CodeBase.SetBelong(this.instance);
				}
				return r_CodeBase;
			}
		}

		/// <summary>
		/// System.String EscapedCodeBase
		/// </summary>
		protected RProperty r_EscapedCodeBase;
		public virtual RProperty REscapedCodeBase
		{
			get
			{
				if(r_EscapedCodeBase == null)
				{
					r_EscapedCodeBase = new(this, "EscapedCodeBase", -1);
					r_EscapedCodeBase.SetBelong(this.instance);
				}
				return r_EscapedCodeBase;
			}
		}

		/// <summary>
		/// System.String FullName
		/// </summary>
		protected RProperty r_FullName;
		public virtual RProperty RFullName
		{
			get
			{
				if(r_FullName == null)
				{
					r_FullName = new(this, "FullName", -1);
					r_FullName.SetBelong(this.instance);
				}
				return r_FullName;
			}
		}

		/// <summary>
		/// System.String ImageRuntimeVersion
		/// </summary>
		protected RProperty r_ImageRuntimeVersion;
		public virtual RProperty RImageRuntimeVersion
		{
			get
			{
				if(r_ImageRuntimeVersion == null)
				{
					r_ImageRuntimeVersion = new(this, "ImageRuntimeVersion", -1);
					r_ImageRuntimeVersion.SetBelong(this.instance);
				}
				return r_ImageRuntimeVersion;
			}
		}

		/// <summary>
		/// IntPtr MonoAssembly
		/// </summary>
		protected RProperty r_MonoAssembly;
		public virtual RProperty RMonoAssembly
		{
			get
			{
				if(r_MonoAssembly == null)
				{
					r_MonoAssembly = new(this, "MonoAssembly", -1);
					r_MonoAssembly.SetBelong(this.instance);
				}
				return r_MonoAssembly;
			}
		}

		/// <summary>
		/// Boolean FromByteArray
		/// </summary>
		protected RProperty r_FromByteArray_Boolean;
		public virtual RProperty RFromByteArray_Boolean
		{
			get
			{
				if(r_FromByteArray_Boolean == null)
				{
					r_FromByteArray_Boolean = new(this, "FromByteArray", -1, typeof(System.Boolean));
					r_FromByteArray_Boolean.SetBelong(this.instance);
				}
				return r_FromByteArray_Boolean;
			}
		}

		/// <summary>
		/// System.String Location
		/// </summary>
		protected RProperty r_Location;
		public virtual RProperty RLocation
		{
			get
			{
				if(r_Location == null)
				{
					r_Location = new(this, "Location", -1);
					r_Location.SetBelong(this.instance);
				}
				return r_Location;
			}
		}

		/// <summary>
		/// System.Security.Policy.Evidence Evidence
		/// </summary>
		protected RSystem.RSecurity.RPolicy.REvidence r_Evidence;
		public virtual RSystem.RSecurity.RPolicy.REvidence REvidence
		{
			get
			{
				if(r_Evidence == null)
				{
					r_Evidence = new(this, "Evidence", -1);
					r_Evidence.SetBelong(this.instance);
				}
				return r_Evidence;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet GrantedPermissionSet
		/// </summary>
		protected RSystem.RSecurity.RPermissionSet r_GrantedPermissionSet;
		public virtual RSystem.RSecurity.RPermissionSet RGrantedPermissionSet
		{
			get
			{
				if(r_GrantedPermissionSet == null)
				{
					r_GrantedPermissionSet = new(this, "GrantedPermissionSet", -1);
					r_GrantedPermissionSet.SetBelong(this.instance);
				}
				return r_GrantedPermissionSet;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet DeniedPermissionSet
		/// </summary>
		protected RSystem.RSecurity.RPermissionSet r_DeniedPermissionSet;
		public virtual RSystem.RSecurity.RPermissionSet RDeniedPermissionSet
		{
			get
			{
				if(r_DeniedPermissionSet == null)
				{
					r_DeniedPermissionSet = new(this, "DeniedPermissionSet", -1);
					r_DeniedPermissionSet.SetBelong(this.instance);
				}
				return r_DeniedPermissionSet;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet PermissionSet
		/// </summary>
		protected RSystem.RSecurity.RPermissionSet r_PermissionSet;
		public virtual RSystem.RSecurity.RPermissionSet RPermissionSet
		{
			get
			{
				if(r_PermissionSet == null)
				{
					r_PermissionSet = new(this, "PermissionSet", -1);
					r_PermissionSet.SetBelong(this.instance);
				}
				return r_PermissionSet;
			}
		}

		/// <summary>
		/// Int64 HostContext
		/// </summary>
		protected RProperty r_HostContext;
		public virtual RProperty RHostContext
		{
			get
			{
				if(r_HostContext == null)
				{
					r_HostContext = new(this, "HostContext", -1);
					r_HostContext.SetBelong(this.instance);
				}
				return r_HostContext;
			}
		}

		/// <summary>
		/// System.Security.SecurityRuleSet SecurityRuleSet
		/// </summary>
		protected RProperty r_SecurityRuleSet;
		public virtual RProperty RSecurityRuleSet
		{
			get
			{
				if(r_SecurityRuleSet == null)
				{
					r_SecurityRuleSet = new(this, "SecurityRuleSet", -1);
					r_SecurityRuleSet.SetBelong(this.instance);
				}
				return r_SecurityRuleSet;
			}
		}

		/// <summary>
		/// Boolean IsFullyTrusted
		/// </summary>
		protected RProperty r_IsFullyTrusted;
		public virtual RProperty RIsFullyTrusted
		{
			get
			{
				if(r_IsFullyTrusted == null)
				{
					r_IsFullyTrusted = new(this, "IsFullyTrusted", -1);
					r_IsFullyTrusted.SetBelong(this.instance);
				}
				return r_IsFullyTrusted;
			}
		}

		/// <summary>
		/// Boolean IsDynamic
		/// </summary>
		protected RProperty r_IsDynamic;
		public virtual RProperty RIsDynamic
		{
			get
			{
				if(r_IsDynamic == null)
				{
					r_IsDynamic = new(this, "IsDynamic", -1);
					r_IsDynamic.SetBelong(this.instance);
				}
				return r_IsDynamic;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.TypeInfo] DefinedTypes
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RTypeInfo> r_DefinedTypes;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RTypeInfo> RDefinedTypes
		{
			get
			{
				if(r_DefinedTypes == null)
				{
					r_DefinedTypes = new(this, "DefinedTypes", -1);
					r_DefinedTypes.SetBelong(this.instance);
				}
				return r_DefinedTypes;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Type] ExportedTypes
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RType> r_ExportedTypes;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RType> RExportedTypes
		{
			get
			{
				if(r_ExportedTypes == null)
				{
					r_ExportedTypes = new(this, "ExportedTypes", -1);
					r_ExportedTypes.SetBelong(this.instance);
				}
				return r_ExportedTypes;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.Module] Modules
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RModule> r_Modules;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RModule> RModules
		{
			get
			{
				if(r_Modules == null)
				{
					r_Modules = new(this, "Modules", -1);
					r_Modules.SetBelong(this.instance);
				}
				return r_Modules;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.CustomAttributeData] CustomAttributes
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RCustomAttributeData> r_CustomAttributes;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RCustomAttributeData> RCustomAttributes
		{
			get
			{
				if(r_CustomAttributes == null)
				{
					r_CustomAttributes = new(this, "CustomAttributes", -1);
					r_CustomAttributes.SetBelong(this.instance);
				}
				return r_CustomAttributes;
			}
		}

		/// <summary>
		/// System.Reflection.ModuleResolveEventHandler ModuleResolve
		/// </summary>
		protected REvent r_ModuleResolve;
		public virtual REvent RModuleResolve
		{
			get
			{
				if(r_ModuleResolve == null)
				{
					r_ModuleResolve = new(this, "ModuleResolve");
					r_ModuleResolve.SetBelong(this.instance);
				}
				return r_ModuleResolve;
			}
		}

		/// <summary>
		/// Void GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_RGetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RGetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_RGetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_RGetObjectData_SerializationInfo_StreamingContext = new(this, "GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_RGetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_RGetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimeAssembly GetExecutingAssembly(System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected static RMethod r_RGetExecutingAssembly_Ref_StackCrawlMark;
		public static RMethod RGetExecutingAssembly_Ref_StackCrawlMark
		{
			get
			{
				if(r_RGetExecutingAssembly_Ref_StackCrawlMark == null)
				{
					r_RGetExecutingAssembly_Ref_StackCrawlMark = new( ReleactionUtils.GetType("System.Reflection.RuntimeAssembly"), "GetExecutingAssembly", 0,  ReleactionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
					r_RGetExecutingAssembly_Ref_StackCrawlMark.SetBelong(null);
				}
				return r_RGetExecutingAssembly_Ref_StackCrawlMark;
			}
		}

		/// <summary>
		/// System.Reflection.AssemblyName CreateAssemblyName(System.String, Boolean, System.Reflection.RuntimeAssembly ByRef)
		/// </summary>
		protected static RMethod r_RCreateAssemblyName_String_Boolean_Out_RuntimeAssembly;
		public static RMethod RCreateAssemblyName_String_Boolean_Out_RuntimeAssembly
		{
			get
			{
				if(r_RCreateAssemblyName_String_Boolean_Out_RuntimeAssembly == null)
				{
					r_RCreateAssemblyName_String_Boolean_Out_RuntimeAssembly = new( ReleactionUtils.GetType("System.Reflection.RuntimeAssembly"), "CreateAssemblyName", 0, typeof(System.String), typeof(System.Boolean),  ReleactionUtils.GetType("System.Reflection.RuntimeAssembly").MakeByRefType());
					r_RCreateAssemblyName_String_Boolean_Out_RuntimeAssembly.SetBelong(null);
				}
				return r_RCreateAssemblyName_String_Boolean_Out_RuntimeAssembly;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimeAssembly InternalLoadAssemblyName(System.Reflection.AssemblyName, System.Security.Policy.Evidence, System.Reflection.RuntimeAssembly, System.Threading.StackCrawlMark ByRef, Boolean, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_RInternalLoadAssemblyName_AssemblyName_Evidence_RuntimeAssembly_Ref_StackCrawlMark_Boolean_Boolean_Boolean;
		public static RMethod RInternalLoadAssemblyName_AssemblyName_Evidence_RuntimeAssembly_Ref_StackCrawlMark_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_RInternalLoadAssemblyName_AssemblyName_Evidence_RuntimeAssembly_Ref_StackCrawlMark_Boolean_Boolean_Boolean == null)
				{
					r_RInternalLoadAssemblyName_AssemblyName_Evidence_RuntimeAssembly_Ref_StackCrawlMark_Boolean_Boolean_Boolean = new( ReleactionUtils.GetType("System.Reflection.RuntimeAssembly"), "InternalLoadAssemblyName", 0, typeof(System.Reflection.AssemblyName), typeof(System.Security.Policy.Evidence),  ReleactionUtils.GetType("System.Reflection.RuntimeAssembly"),  ReleactionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType(), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_RInternalLoadAssemblyName_AssemblyName_Evidence_RuntimeAssembly_Ref_StackCrawlMark_Boolean_Boolean_Boolean.SetBelong(null);
				}
				return r_RInternalLoadAssemblyName_AssemblyName_Evidence_RuntimeAssembly_Ref_StackCrawlMark_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimeAssembly LoadWithPartialNameInternal(System.String, System.Security.Policy.Evidence, System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected static RMethod r_RLoadWithPartialNameInternal_String_Evidence_Ref_StackCrawlMark;
		public static RMethod RLoadWithPartialNameInternal_String_Evidence_Ref_StackCrawlMark
		{
			get
			{
				if(r_RLoadWithPartialNameInternal_String_Evidence_Ref_StackCrawlMark == null)
				{
					r_RLoadWithPartialNameInternal_String_Evidence_Ref_StackCrawlMark = new( ReleactionUtils.GetType("System.Reflection.RuntimeAssembly"), "LoadWithPartialNameInternal", 0, typeof(System.String), typeof(System.Security.Policy.Evidence),  ReleactionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
					r_RLoadWithPartialNameInternal_String_Evidence_Ref_StackCrawlMark.SetBelong(null);
				}
				return r_RLoadWithPartialNameInternal_String_Evidence_Ref_StackCrawlMark;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimeAssembly LoadWithPartialNameInternal(System.Reflection.AssemblyName, System.Security.Policy.Evidence, System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected static RMethod r_RLoadWithPartialNameInternal_AssemblyName_Evidence_Ref_StackCrawlMark;
		public static RMethod RLoadWithPartialNameInternal_AssemblyName_Evidence_Ref_StackCrawlMark
		{
			get
			{
				if(r_RLoadWithPartialNameInternal_AssemblyName_Evidence_Ref_StackCrawlMark == null)
				{
					r_RLoadWithPartialNameInternal_AssemblyName_Evidence_Ref_StackCrawlMark = new( ReleactionUtils.GetType("System.Reflection.RuntimeAssembly"), "LoadWithPartialNameInternal", 0, typeof(System.Reflection.AssemblyName), typeof(System.Security.Policy.Evidence),  ReleactionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
					r_RLoadWithPartialNameInternal_AssemblyName_Evidence_Ref_StackCrawlMark.SetBelong(null);
				}
				return r_RLoadWithPartialNameInternal_AssemblyName_Evidence_Ref_StackCrawlMark;
			}
		}

		/// <summary>
		/// System.Reflection.AssemblyName GetName(Boolean)
		/// </summary>
		protected RMethod r_RGetName_Boolean;
		public virtual RMethod RGetName_Boolean
		{
			get
			{
				if(r_RGetName_Boolean == null)
				{
					r_RGetName_Boolean = new(this, "GetName", 0, typeof(System.Boolean));
					r_RGetName_Boolean.SetBelong(this.instance);
				}
				return r_RGetName_Boolean;
			}
		}

		/// <summary>
		/// System.Type GetType(System.String, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RGetType_String_Boolean_Boolean;
		public virtual RMethod RGetType_String_Boolean_Boolean
		{
			get
			{
				if(r_RGetType_String_Boolean_Boolean == null)
				{
					r_RGetType_String_Boolean_Boolean = new(this, "GetType", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Boolean));
					r_RGetType_String_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RGetType_String_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.Module GetModule(System.String)
		/// </summary>
		protected RMethod r_RGetModule_String;
		public virtual RMethod RGetModule_String
		{
			get
			{
				if(r_RGetModule_String == null)
				{
					r_RGetModule_String = new(this, "GetModule", 0, typeof(System.String));
					r_RGetModule_String.SetBelong(this.instance);
				}
				return r_RGetModule_String;
			}
		}

		/// <summary>
		/// System.Reflection.AssemblyName[] GetReferencedAssemblies()
		/// </summary>
		protected RMethod r_RGetReferencedAssemblies;
		public virtual RMethod RGetReferencedAssemblies
		{
			get
			{
				if(r_RGetReferencedAssemblies == null)
				{
					r_RGetReferencedAssemblies = new(this, "GetReferencedAssemblies", 0);
					r_RGetReferencedAssemblies.SetBelong(this.instance);
				}
				return r_RGetReferencedAssemblies;
			}
		}

		/// <summary>
		/// System.Reflection.Module[] GetModules(Boolean)
		/// </summary>
		protected RMethod r_RGetModules_Boolean;
		public virtual RMethod RGetModules_Boolean
		{
			get
			{
				if(r_RGetModules_Boolean == null)
				{
					r_RGetModules_Boolean = new(this, "GetModules", 0, typeof(System.Boolean));
					r_RGetModules_Boolean.SetBelong(this.instance);
				}
				return r_RGetModules_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.Module[] GetLoadedModules(Boolean)
		/// </summary>
		protected RMethod r_RGetLoadedModules_Boolean;
		public virtual RMethod RGetLoadedModules_Boolean
		{
			get
			{
				if(r_RGetLoadedModules_Boolean == null)
				{
					r_RGetLoadedModules_Boolean = new(this, "GetLoadedModules", 0, typeof(System.Boolean));
					r_RGetLoadedModules_Boolean.SetBelong(this.instance);
				}
				return r_RGetLoadedModules_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly GetSatelliteAssembly(System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_RGetSatelliteAssembly_CultureInfo;
		public virtual RMethod RGetSatelliteAssembly_CultureInfo
		{
			get
			{
				if(r_RGetSatelliteAssembly_CultureInfo == null)
				{
					r_RGetSatelliteAssembly_CultureInfo = new(this, "GetSatelliteAssembly", 0, typeof(System.Globalization.CultureInfo));
					r_RGetSatelliteAssembly_CultureInfo.SetBelong(this.instance);
				}
				return r_RGetSatelliteAssembly_CultureInfo;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly GetSatelliteAssembly(System.Globalization.CultureInfo, System.Version)
		/// </summary>
		protected RMethod r_RGetSatelliteAssembly_CultureInfo_Version;
		public virtual RMethod RGetSatelliteAssembly_CultureInfo_Version
		{
			get
			{
				if(r_RGetSatelliteAssembly_CultureInfo_Version == null)
				{
					r_RGetSatelliteAssembly_CultureInfo_Version = new(this, "GetSatelliteAssembly", 0, typeof(System.Globalization.CultureInfo), typeof(System.Version));
					r_RGetSatelliteAssembly_CultureInfo_Version.SetBelong(this.instance);
				}
				return r_RGetSatelliteAssembly_CultureInfo_Version;
			}
		}

		/// <summary>
		/// System.Type[] GetExportedTypes()
		/// </summary>
		protected RMethod r_RGetExportedTypes;
		public virtual RMethod RGetExportedTypes
		{
			get
			{
				if(r_RGetExportedTypes == null)
				{
					r_RGetExportedTypes = new(this, "GetExportedTypes", 0);
					r_RGetExportedTypes.SetBelong(this.instance);
				}
				return r_RGetExportedTypes;
			}
		}

		/// <summary>
		/// Byte[] GetAotId()
		/// </summary>
		protected static RMethod r_RGetAotId;
		public static RMethod RGetAotId
		{
			get
			{
				if(r_RGetAotId == null)
				{
					r_RGetAotId = new( ReleactionUtils.GetType("System.Reflection.RuntimeAssembly"), "GetAotId", 0);
					r_RGetAotId.SetBelong(null);
				}
				return r_RGetAotId;
			}
		}

		/// <summary>
		/// System.String get_code_base(System.Reflection.Assembly, Boolean)
		/// </summary>
		protected static RMethod r_Rget_code_base_Assembly_Boolean;
		public static RMethod Rget_code_base_Assembly_Boolean
		{
			get
			{
				if(r_Rget_code_base_Assembly_Boolean == null)
				{
					r_Rget_code_base_Assembly_Boolean = new( ReleactionUtils.GetType("System.Reflection.RuntimeAssembly"), "get_code_base", 0, typeof(System.Reflection.Assembly), typeof(System.Boolean));
					r_Rget_code_base_Assembly_Boolean.SetBelong(null);
				}
				return r_Rget_code_base_Assembly_Boolean;
			}
		}

		/// <summary>
		/// System.String get_location()
		/// </summary>
		protected RMethod r_Rget_location;
		public virtual RMethod Rget_location
		{
			get
			{
				if(r_Rget_location == null)
				{
					r_Rget_location = new(this, "get_location", 0);
					r_Rget_location.SetBelong(this.instance);
				}
				return r_Rget_location;
			}
		}

		/// <summary>
		/// System.String get_fullname(System.Reflection.Assembly)
		/// </summary>
		protected static RMethod r_Rget_fullname_Assembly;
		public static RMethod Rget_fullname_Assembly
		{
			get
			{
				if(r_Rget_fullname_Assembly == null)
				{
					r_Rget_fullname_Assembly = new( ReleactionUtils.GetType("System.Reflection.RuntimeAssembly"), "get_fullname", 0, typeof(System.Reflection.Assembly));
					r_Rget_fullname_Assembly.SetBelong(null);
				}
				return r_Rget_fullname_Assembly;
			}
		}

		/// <summary>
		/// Boolean GetAotIdInternal(Byte[])
		/// </summary>
		protected static RMethod r_RGetAotIdInternal_ByteArray;
		public static RMethod RGetAotIdInternal_ByteArray
		{
			get
			{
				if(r_RGetAotIdInternal_ByteArray == null)
				{
					r_RGetAotIdInternal_ByteArray = new( ReleactionUtils.GetType("System.Reflection.RuntimeAssembly"), "GetAotIdInternal", 0, typeof(System.Byte).MakeArrayType());
					r_RGetAotIdInternal_ByteArray.SetBelong(null);
				}
				return r_RGetAotIdInternal_ByteArray;
			}
		}

		/// <summary>
		/// System.String InternalImageRuntimeVersion(System.Reflection.Assembly)
		/// </summary>
		protected static RMethod r_RInternalImageRuntimeVersion_Assembly;
		public static RMethod RInternalImageRuntimeVersion_Assembly
		{
			get
			{
				if(r_RInternalImageRuntimeVersion_Assembly == null)
				{
					r_RInternalImageRuntimeVersion_Assembly = new( ReleactionUtils.GetType("System.Reflection.RuntimeAssembly"), "InternalImageRuntimeVersion", 0, typeof(System.Reflection.Assembly));
					r_RInternalImageRuntimeVersion_Assembly.SetBelong(null);
				}
				return r_RInternalImageRuntimeVersion_Assembly;
			}
		}

		/// <summary>
		/// Boolean get_global_assembly_cache()
		/// </summary>
		protected RMethod r_Rget_global_assembly_cache;
		public virtual RMethod Rget_global_assembly_cache
		{
			get
			{
				if(r_Rget_global_assembly_cache == null)
				{
					r_Rget_global_assembly_cache = new(this, "get_global_assembly_cache", 0);
					r_Rget_global_assembly_cache.SetBelong(this.instance);
				}
				return r_Rget_global_assembly_cache;
			}
		}

		/// <summary>
		/// System.String GetCodeBase(System.Reflection.Assembly, Boolean)
		/// </summary>
		protected static RMethod r_RGetCodeBase_Assembly_Boolean;
		public static RMethod RGetCodeBase_Assembly_Boolean
		{
			get
			{
				if(r_RGetCodeBase_Assembly_Boolean == null)
				{
					r_RGetCodeBase_Assembly_Boolean = new( ReleactionUtils.GetType("System.Reflection.RuntimeAssembly"), "GetCodeBase", 0, typeof(System.Reflection.Assembly), typeof(System.Boolean));
					r_RGetCodeBase_Assembly_Boolean.SetBelong(null);
				}
				return r_RGetCodeBase_Assembly_Boolean;
			}
		}

		/// <summary>
		/// Boolean GetManifestResourceInfoInternal(System.String, System.Reflection.ManifestResourceInfo)
		/// </summary>
		protected RMethod r_RGetManifestResourceInfoInternal_String_ManifestResourceInfo;
		public virtual RMethod RGetManifestResourceInfoInternal_String_ManifestResourceInfo
		{
			get
			{
				if(r_RGetManifestResourceInfoInternal_String_ManifestResourceInfo == null)
				{
					r_RGetManifestResourceInfoInternal_String_ManifestResourceInfo = new(this, "GetManifestResourceInfoInternal", 0, typeof(System.String), typeof(System.Reflection.ManifestResourceInfo));
					r_RGetManifestResourceInfoInternal_String_ManifestResourceInfo.SetBelong(this.instance);
				}
				return r_RGetManifestResourceInfoInternal_String_ManifestResourceInfo;
			}
		}

		/// <summary>
		/// System.Reflection.ManifestResourceInfo GetManifestResourceInfo(System.String)
		/// </summary>
		protected RMethod r_RGetManifestResourceInfo_String;
		public virtual RMethod RGetManifestResourceInfo_String
		{
			get
			{
				if(r_RGetManifestResourceInfo_String == null)
				{
					r_RGetManifestResourceInfo_String = new(this, "GetManifestResourceInfo", 0, typeof(System.String));
					r_RGetManifestResourceInfo_String.SetBelong(this.instance);
				}
				return r_RGetManifestResourceInfo_String;
			}
		}

		/// <summary>
		/// System.String[] GetManifestResourceNames()
		/// </summary>
		protected RMethod r_RGetManifestResourceNames;
		public virtual RMethod RGetManifestResourceNames
		{
			get
			{
				if(r_RGetManifestResourceNames == null)
				{
					r_RGetManifestResourceNames = new(this, "GetManifestResourceNames", 0);
					r_RGetManifestResourceNames.SetBelong(this.instance);
				}
				return r_RGetManifestResourceNames;
			}
		}

		/// <summary>
		/// IntPtr GetManifestResourceInternal(System.String, Int32 ByRef, System.Reflection.Module ByRef)
		/// </summary>
		protected RMethod r_RGetManifestResourceInternal_String_Out_Int32_Out_Module;
		public virtual RMethod RGetManifestResourceInternal_String_Out_Int32_Out_Module
		{
			get
			{
				if(r_RGetManifestResourceInternal_String_Out_Int32_Out_Module == null)
				{
					r_RGetManifestResourceInternal_String_Out_Int32_Out_Module = new(this, "GetManifestResourceInternal", 0, typeof(System.String), typeof(System.Int32).MakeByRefType(), typeof(System.Reflection.Module).MakeByRefType());
					r_RGetManifestResourceInternal_String_Out_Int32_Out_Module.SetBelong(this.instance);
				}
				return r_RGetManifestResourceInternal_String_Out_Int32_Out_Module;
			}
		}

		/// <summary>
		/// System.IO.Stream GetManifestResourceStream(System.String)
		/// </summary>
		protected RMethod r_RGetManifestResourceStream_String;
		public virtual RMethod RGetManifestResourceStream_String
		{
			get
			{
				if(r_RGetManifestResourceStream_String == null)
				{
					r_RGetManifestResourceStream_String = new(this, "GetManifestResourceStream", 0, typeof(System.String));
					r_RGetManifestResourceStream_String.SetBelong(this.instance);
				}
				return r_RGetManifestResourceStream_String;
			}
		}

		/// <summary>
		/// System.IO.Stream GetManifestResourceStream(System.Type, System.String)
		/// </summary>
		protected RMethod r_RGetManifestResourceStream_Type_String;
		public virtual RMethod RGetManifestResourceStream_Type_String
		{
			get
			{
				if(r_RGetManifestResourceStream_Type_String == null)
				{
					r_RGetManifestResourceStream_Type_String = new(this, "GetManifestResourceStream", 0, typeof(System.Type), typeof(System.String));
					r_RGetManifestResourceStream_Type_String.SetBelong(this.instance);
				}
				return r_RGetManifestResourceStream_Type_String;
			}
		}

		/// <summary>
		/// Boolean IsDefined(System.Type, Boolean)
		/// </summary>
		protected RMethod r_RIsDefined_Type_Boolean;
		public virtual RMethod RIsDefined_Type_Boolean
		{
			get
			{
				if(r_RIsDefined_Type_Boolean == null)
				{
					r_RIsDefined_Type_Boolean = new(this, "IsDefined", 0, typeof(System.Type), typeof(System.Boolean));
					r_RIsDefined_Type_Boolean.SetBelong(this.instance);
				}
				return r_RIsDefined_Type_Boolean;
			}
		}

		/// <summary>
		/// System.Object[] GetCustomAttributes(Boolean)
		/// </summary>
		protected RMethod r_RGetCustomAttributes_Boolean;
		public virtual RMethod RGetCustomAttributes_Boolean
		{
			get
			{
				if(r_RGetCustomAttributes_Boolean == null)
				{
					r_RGetCustomAttributes_Boolean = new(this, "GetCustomAttributes", 0, typeof(System.Boolean));
					r_RGetCustomAttributes_Boolean.SetBelong(this.instance);
				}
				return r_RGetCustomAttributes_Boolean;
			}
		}

		/// <summary>
		/// System.Object[] GetCustomAttributes(System.Type, Boolean)
		/// </summary>
		protected RMethod r_RGetCustomAttributes_Type_Boolean;
		public virtual RMethod RGetCustomAttributes_Type_Boolean
		{
			get
			{
				if(r_RGetCustomAttributes_Type_Boolean == null)
				{
					r_RGetCustomAttributes_Type_Boolean = new(this, "GetCustomAttributes", 0, typeof(System.Type), typeof(System.Boolean));
					r_RGetCustomAttributes_Type_Boolean.SetBelong(this.instance);
				}
				return r_RGetCustomAttributes_Type_Boolean;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.CustomAttributeData] GetCustomAttributesData()
		/// </summary>
		protected RMethod r_RGetCustomAttributesData;
		public virtual RMethod RGetCustomAttributesData
		{
			get
			{
				if(r_RGetCustomAttributesData == null)
				{
					r_RGetCustomAttributesData = new(this, "GetCustomAttributesData", 0);
					r_RGetCustomAttributesData.SetBelong(this.instance);
				}
				return r_RGetCustomAttributesData;
			}
		}

		/// <summary>
		/// System.Reflection.Module GetManifestModule()
		/// </summary>
		protected RMethod r_RGetManifestModule;
		public virtual RMethod RGetManifestModule
		{
			get
			{
				if(r_RGetManifestModule == null)
				{
					r_RGetManifestModule = new(this, "GetManifestModule", 0);
					r_RGetManifestModule.SetBelong(this.instance);
				}
				return r_RGetManifestModule;
			}
		}

		/// <summary>
		/// System.Reflection.Module GetManifestModuleInternal()
		/// </summary>
		protected RMethod r_RGetManifestModuleInternal;
		public virtual RMethod RGetManifestModuleInternal
		{
			get
			{
				if(r_RGetManifestModuleInternal == null)
				{
					r_RGetManifestModuleInternal = new(this, "GetManifestModuleInternal", 0);
					r_RGetManifestModuleInternal.SetBelong(this.instance);
				}
				return r_RGetManifestModuleInternal;
			}
		}

		/// <summary>
		/// System.Reflection.Module[] GetModulesInternal()
		/// </summary>
		protected RMethod r_RGetModulesInternal;
		public virtual RMethod RGetModulesInternal
		{
			get
			{
				if(r_RGetModulesInternal == null)
				{
					r_RGetModulesInternal = new(this, "GetModulesInternal", 0);
					r_RGetModulesInternal.SetBelong(this.instance);
				}
				return r_RGetModulesInternal;
			}
		}

		/// <summary>
		/// System.Object GetFilesInternal(System.String, Boolean)
		/// </summary>
		protected RMethod r_RGetFilesInternal_String_Boolean;
		public virtual RMethod RGetFilesInternal_String_Boolean
		{
			get
			{
				if(r_RGetFilesInternal_String_Boolean == null)
				{
					r_RGetFilesInternal_String_Boolean = new(this, "GetFilesInternal", 0, typeof(System.String), typeof(System.Boolean));
					r_RGetFilesInternal_String_Boolean.SetBelong(this.instance);
				}
				return r_RGetFilesInternal_String_Boolean;
			}
		}

		/// <summary>
		/// System.IO.FileStream[] GetFiles(Boolean)
		/// </summary>
		protected RMethod r_RGetFiles_Boolean;
		public virtual RMethod RGetFiles_Boolean
		{
			get
			{
				if(r_RGetFiles_Boolean == null)
				{
					r_RGetFiles_Boolean = new(this, "GetFiles", 0, typeof(System.Boolean));
					r_RGetFiles_Boolean.SetBelong(this.instance);
				}
				return r_RGetFiles_Boolean;
			}
		}

		/// <summary>
		/// System.IO.FileStream GetFile(System.String)
		/// </summary>
		protected RMethod r_RGetFile_String;
		public virtual RMethod RGetFile_String
		{
			get
			{
				if(r_RGetFile_String == null)
				{
					r_RGetFile_String = new(this, "GetFile", 0, typeof(System.String));
					r_RGetFile_String.SetBelong(this.instance);
				}
				return r_RGetFile_String;
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

		/// <summary>
		/// System.Security.Policy.Evidence UnprotectedGetEvidence()
		/// </summary>
		protected RMethod r_RUnprotectedGetEvidence;
		public virtual RMethod RUnprotectedGetEvidence
		{
			get
			{
				if(r_RUnprotectedGetEvidence == null)
				{
					r_RUnprotectedGetEvidence = new(this, "UnprotectedGetEvidence", 0);
					r_RUnprotectedGetEvidence.SetBelong(this.instance);
				}
				return r_RUnprotectedGetEvidence;
			}
		}

		/// <summary>
		/// Void Resolve()
		/// </summary>
		protected RMethod r_RResolve;
		public virtual RMethod RResolve
		{
			get
			{
				if(r_RResolve == null)
				{
					r_RResolve = new(this, "Resolve", 0);
					r_RResolve.SetBelong(this.instance);
				}
				return r_RResolve;
			}
		}

		/// <summary>
		/// Boolean LoadPermissions(System.Reflection.Assembly, IntPtr ByRef, Int32 ByRef, IntPtr ByRef, Int32 ByRef, IntPtr ByRef, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RLoadPermissions_Assembly_Ref_IntPtr_Ref_Int32_Ref_IntPtr_Ref_Int32_Ref_IntPtr_Ref_Int32;
		public static RMethod RLoadPermissions_Assembly_Ref_IntPtr_Ref_Int32_Ref_IntPtr_Ref_Int32_Ref_IntPtr_Ref_Int32
		{
			get
			{
				if(r_RLoadPermissions_Assembly_Ref_IntPtr_Ref_Int32_Ref_IntPtr_Ref_Int32_Ref_IntPtr_Ref_Int32 == null)
				{
					r_RLoadPermissions_Assembly_Ref_IntPtr_Ref_Int32_Ref_IntPtr_Ref_Int32_Ref_IntPtr_Ref_Int32 = new( ReleactionUtils.GetType("System.Reflection.RuntimeAssembly"), "LoadPermissions", 0, typeof(System.Reflection.Assembly), typeof(System.IntPtr).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.IntPtr).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.IntPtr).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_RLoadPermissions_Assembly_Ref_IntPtr_Ref_Int32_Ref_IntPtr_Ref_Int32_Ref_IntPtr_Ref_Int32.SetBelong(null);
				}
				return r_RLoadPermissions_Assembly_Ref_IntPtr_Ref_Int32_Ref_IntPtr_Ref_Int32_Ref_IntPtr_Ref_Int32;
			}
		}

		/// <summary>
		/// Void LoadAssemblyPermissions()
		/// </summary>
		protected RMethod r_RLoadAssemblyPermissions;
		public virtual RMethod RLoadAssemblyPermissions
		{
			get
			{
				if(r_RLoadAssemblyPermissions == null)
				{
					r_RLoadAssemblyPermissions = new(this, "LoadAssemblyPermissions", 0);
					r_RLoadAssemblyPermissions.SetBelong(this.instance);
				}
				return r_RLoadAssemblyPermissions;
			}
		}

		/// <summary>
		/// System.IO.FileStream[] GetFiles()
		/// </summary>
		protected RMethod r_RGetFiles;
		public virtual RMethod RGetFiles
		{
			get
			{
				if(r_RGetFiles == null)
				{
					r_RGetFiles = new(this, "GetFiles", 0);
					r_RGetFiles.SetBelong(this.instance);
				}
				return r_RGetFiles;
			}
		}

		/// <summary>
		/// System.IO.Stream GetManifestResourceStream(System.Type, System.String, Boolean, System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected RMethod r_RGetManifestResourceStream_Type_String_Boolean_Ref_StackCrawlMark;
		public virtual RMethod RGetManifestResourceStream_Type_String_Boolean_Ref_StackCrawlMark
		{
			get
			{
				if(r_RGetManifestResourceStream_Type_String_Boolean_Ref_StackCrawlMark == null)
				{
					r_RGetManifestResourceStream_Type_String_Boolean_Ref_StackCrawlMark = new(this, "GetManifestResourceStream", 0, typeof(System.Type), typeof(System.String), typeof(System.Boolean),  ReleactionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
					r_RGetManifestResourceStream_Type_String_Boolean_Ref_StackCrawlMark.SetBelong(this.instance);
				}
				return r_RGetManifestResourceStream_Type_String_Boolean_Ref_StackCrawlMark;
			}
		}

		/// <summary>
		/// System.IO.Stream GetManifestResourceStream(System.String, System.Threading.StackCrawlMark ByRef, Boolean)
		/// </summary>
		protected RMethod r_RGetManifestResourceStream_String_Ref_StackCrawlMark_Boolean;
		public virtual RMethod RGetManifestResourceStream_String_Ref_StackCrawlMark_Boolean
		{
			get
			{
				if(r_RGetManifestResourceStream_String_Ref_StackCrawlMark_Boolean == null)
				{
					r_RGetManifestResourceStream_String_Ref_StackCrawlMark_Boolean = new(this, "GetManifestResourceStream", 0, typeof(System.String),  ReleactionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType(), typeof(System.Boolean));
					r_RGetManifestResourceStream_String_Ref_StackCrawlMark_Boolean.SetBelong(this.instance);
				}
				return r_RGetManifestResourceStream_String_Ref_StackCrawlMark_Boolean;
			}
		}

		/// <summary>
		/// System.String GetSimpleName()
		/// </summary>
		protected RMethod r_RGetSimpleName;
		public virtual RMethod RGetSimpleName
		{
			get
			{
				if(r_RGetSimpleName == null)
				{
					r_RGetSimpleName = new(this, "GetSimpleName", 0);
					r_RGetSimpleName.SetBelong(this.instance);
				}
				return r_RGetSimpleName;
			}
		}

		/// <summary>
		/// Byte[] GetPublicKey()
		/// </summary>
		protected RMethod r_RGetPublicKey;
		public virtual RMethod RGetPublicKey
		{
			get
			{
				if(r_RGetPublicKey == null)
				{
					r_RGetPublicKey = new(this, "GetPublicKey", 0);
					r_RGetPublicKey.SetBelong(this.instance);
				}
				return r_RGetPublicKey;
			}
		}

		/// <summary>
		/// System.Version GetVersion()
		/// </summary>
		protected RMethod r_RGetVersion;
		public virtual RMethod RGetVersion
		{
			get
			{
				if(r_RGetVersion == null)
				{
					r_RGetVersion = new(this, "GetVersion", 0);
					r_RGetVersion.SetBelong(this.instance);
				}
				return r_RGetVersion;
			}
		}

		/// <summary>
		/// System.Type[] GetTypes(Boolean)
		/// </summary>
		protected RMethod r_RGetTypes_Boolean;
		public virtual RMethod RGetTypes_Boolean
		{
			get
			{
				if(r_RGetTypes_Boolean == null)
				{
					r_RGetTypes_Boolean = new(this, "GetTypes", 0, typeof(System.Boolean));
					r_RGetTypes_Boolean.SetBelong(this.instance);
				}
				return r_RGetTypes_Boolean;
			}
		}

		/// <summary>
		/// System.Type[] GetTypes()
		/// </summary>
		protected RMethod r_RGetTypes;
		public virtual RMethod RGetTypes
		{
			get
			{
				if(r_RGetTypes == null)
				{
					r_RGetTypes = new(this, "GetTypes", 0);
					r_RGetTypes.SetBelong(this.instance);
				}
				return r_RGetTypes;
			}
		}

		/// <summary>
		/// System.Type GetType(System.String, Boolean)
		/// </summary>
		protected RMethod r_RGetType_String_Boolean;
		public virtual RMethod RGetType_String_Boolean
		{
			get
			{
				if(r_RGetType_String_Boolean == null)
				{
					r_RGetType_String_Boolean = new(this, "GetType", 0, typeof(System.String), typeof(System.Boolean));
					r_RGetType_String_Boolean.SetBelong(this.instance);
				}
				return r_RGetType_String_Boolean;
			}
		}

		/// <summary>
		/// System.Type GetType(System.String)
		/// </summary>
		protected RMethod r_RGetType_String;
		public virtual RMethod RGetType_String
		{
			get
			{
				if(r_RGetType_String == null)
				{
					r_RGetType_String = new(this, "GetType", 0, typeof(System.String));
					r_RGetType_String.SetBelong(this.instance);
				}
				return r_RGetType_String;
			}
		}

		/// <summary>
		/// System.Type InternalGetType(System.Reflection.Module, System.String, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RInternalGetType_Module_String_Boolean_Boolean;
		public virtual RMethod RInternalGetType_Module_String_Boolean_Boolean
		{
			get
			{
				if(r_RInternalGetType_Module_String_Boolean_Boolean == null)
				{
					r_RInternalGetType_Module_String_Boolean_Boolean = new(this, "InternalGetType", 0, typeof(System.Reflection.Module), typeof(System.String), typeof(System.Boolean), typeof(System.Boolean));
					r_RInternalGetType_Module_String_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RInternalGetType_Module_String_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.AssemblyName GetName()
		/// </summary>
		protected RMethod r_RGetName;
		public virtual RMethod RGetName
		{
			get
			{
				if(r_RGetName == null)
				{
					r_RGetName = new(this, "GetName", 0);
					r_RGetName.SetBelong(this.instance);
				}
				return r_RGetName;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly GetSatelliteAssembly(System.Globalization.CultureInfo, System.Version, Boolean, System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected RMethod r_RGetSatelliteAssembly_CultureInfo_Version_Boolean_Ref_StackCrawlMark;
		public virtual RMethod RGetSatelliteAssembly_CultureInfo_Version_Boolean_Ref_StackCrawlMark
		{
			get
			{
				if(r_RGetSatelliteAssembly_CultureInfo_Version_Boolean_Ref_StackCrawlMark == null)
				{
					r_RGetSatelliteAssembly_CultureInfo_Version_Boolean_Ref_StackCrawlMark = new(this, "GetSatelliteAssembly", 0, typeof(System.Globalization.CultureInfo), typeof(System.Version), typeof(System.Boolean),  ReleactionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
					r_RGetSatelliteAssembly_CultureInfo_Version_Boolean_Ref_StackCrawlMark.SetBelong(this.instance);
				}
				return r_RGetSatelliteAssembly_CultureInfo_Version_Boolean_Ref_StackCrawlMark;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimeAssembly InternalGetSatelliteAssembly(System.String, System.Globalization.CultureInfo, System.Version, Boolean, System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected RMethod r_RInternalGetSatelliteAssembly_String_CultureInfo_Version_Boolean_Ref_StackCrawlMark;
		public virtual RMethod RInternalGetSatelliteAssembly_String_CultureInfo_Version_Boolean_Ref_StackCrawlMark
		{
			get
			{
				if(r_RInternalGetSatelliteAssembly_String_CultureInfo_Version_Boolean_Ref_StackCrawlMark == null)
				{
					r_RInternalGetSatelliteAssembly_String_CultureInfo_Version_Boolean_Ref_StackCrawlMark = new(this, "InternalGetSatelliteAssembly", 0, typeof(System.String), typeof(System.Globalization.CultureInfo), typeof(System.Version), typeof(System.Boolean),  ReleactionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
					r_RInternalGetSatelliteAssembly_String_CultureInfo_Version_Boolean_Ref_StackCrawlMark.SetBelong(this.instance);
				}
				return r_RInternalGetSatelliteAssembly_String_CultureInfo_Version_Boolean_Ref_StackCrawlMark;
			}
		}

		/// <summary>
		/// System.Reflection.Module LoadModule(System.String, Byte[])
		/// </summary>
		protected RMethod r_RLoadModule_String_ByteArray;
		public virtual RMethod RLoadModule_String_ByteArray
		{
			get
			{
				if(r_RLoadModule_String_ByteArray == null)
				{
					r_RLoadModule_String_ByteArray = new(this, "LoadModule", 0, typeof(System.String), typeof(System.Byte).MakeArrayType());
					r_RLoadModule_String_ByteArray.SetBelong(this.instance);
				}
				return r_RLoadModule_String_ByteArray;
			}
		}

		/// <summary>
		/// System.Reflection.Module LoadModule(System.String, Byte[], Byte[])
		/// </summary>
		protected RMethod r_RLoadModule_String_ByteArray_ByteArray;
		public virtual RMethod RLoadModule_String_ByteArray_ByteArray
		{
			get
			{
				if(r_RLoadModule_String_ByteArray_ByteArray == null)
				{
					r_RLoadModule_String_ByteArray_ByteArray = new(this, "LoadModule", 0, typeof(System.String), typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType());
					r_RLoadModule_String_ByteArray_ByteArray.SetBelong(this.instance);
				}
				return r_RLoadModule_String_ByteArray_ByteArray;
			}
		}

		/// <summary>
		/// System.Object CreateInstance(System.String)
		/// </summary>
		protected RMethod r_RCreateInstance_String;
		public virtual RMethod RCreateInstance_String
		{
			get
			{
				if(r_RCreateInstance_String == null)
				{
					r_RCreateInstance_String = new(this, "CreateInstance", 0, typeof(System.String));
					r_RCreateInstance_String.SetBelong(this.instance);
				}
				return r_RCreateInstance_String;
			}
		}

		/// <summary>
		/// System.Object CreateInstance(System.String, Boolean)
		/// </summary>
		protected RMethod r_RCreateInstance_String_Boolean;
		public virtual RMethod RCreateInstance_String_Boolean
		{
			get
			{
				if(r_RCreateInstance_String_Boolean == null)
				{
					r_RCreateInstance_String_Boolean = new(this, "CreateInstance", 0, typeof(System.String), typeof(System.Boolean));
					r_RCreateInstance_String_Boolean.SetBelong(this.instance);
				}
				return r_RCreateInstance_String_Boolean;
			}
		}

		/// <summary>
		/// System.Object CreateInstance(System.String, Boolean, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo, System.Object[])
		/// </summary>
		protected RMethod r_RCreateInstance_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray;
		public virtual RMethod RCreateInstance_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray
		{
			get
			{
				if(r_RCreateInstance_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray == null)
				{
					r_RCreateInstance_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray = new(this, "CreateInstance", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.Object).MakeArrayType());
					r_RCreateInstance_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray.SetBelong(this.instance);
				}
				return r_RCreateInstance_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray;
			}
		}

		/// <summary>
		/// System.Reflection.Module[] GetLoadedModules()
		/// </summary>
		protected RMethod r_RGetLoadedModules;
		public virtual RMethod RGetLoadedModules
		{
			get
			{
				if(r_RGetLoadedModules == null)
				{
					r_RGetLoadedModules = new(this, "GetLoadedModules", 0);
					r_RGetLoadedModules.SetBelong(this.instance);
				}
				return r_RGetLoadedModules;
			}
		}

		/// <summary>
		/// System.Reflection.Module[] GetModules()
		/// </summary>
		protected RMethod r_RGetModules;
		public virtual RMethod RGetModules
		{
			get
			{
				if(r_RGetModules == null)
				{
					r_RGetModules = new(this, "GetModules", 0);
					r_RGetModules.SetBelong(this.instance);
				}
				return r_RGetModules;
			}
		}

		/// <summary>
		/// System.Type[] GetForwardedTypes()
		/// </summary>
		protected RMethod r_RGetForwardedTypes;
		public virtual RMethod RGetForwardedTypes
		{
			get
			{
				if(r_RGetForwardedTypes == null)
				{
					r_RGetForwardedTypes = new(this, "GetForwardedTypes", 0);
					r_RGetForwardedTypes.SetBelong(this.instance);
				}
				return r_RGetForwardedTypes;
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

        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo  @info, System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }







        public virtual System.Reflection.AssemblyName GetName(System.Boolean  @copiedName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@copiedName};
            var ___result = RGetName_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.AssemblyName)___result;
        }


        public virtual System.Type GetType(System.String  @name, System.Boolean  @throwOnError, System.Boolean  @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @throwOnError, @ignoreCase};
            var ___result = RGetType_String_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Reflection.Module GetModule(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetModule_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module)___result;
        }


        public virtual System.Reflection.AssemblyName[] GetReferencedAssemblies()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetReferencedAssemblies.Invoke(___genericsType, ___parameters);

            return (System.Reflection.AssemblyName[])___result;
        }


        public virtual System.Reflection.Module[] GetModules(System.Boolean  @getResourceModules)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@getResourceModules};
            var ___result = RGetModules_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module[])___result;
        }


        public virtual System.Reflection.Module[] GetLoadedModules(System.Boolean  @getResourceModules)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@getResourceModules};
            var ___result = RGetLoadedModules_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module[])___result;
        }


        public virtual System.Reflection.Assembly GetSatelliteAssembly(System.Globalization.CultureInfo  @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@culture};
            var ___result = RGetSatelliteAssembly_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public virtual System.Reflection.Assembly GetSatelliteAssembly(System.Globalization.CultureInfo  @culture, System.Version  @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@culture, @version};
            var ___result = RGetSatelliteAssembly_CultureInfo_Version.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public virtual System.Type[] GetExportedTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetExportedTypes.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public static System.Byte[] GetAotId()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAotId.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public static System.String get_code_base(System.Reflection.Assembly  @a, System.Boolean  @escaped)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @escaped};
            var ___result = Rget_code_base_Assembly_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String get_location()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = Rget_location.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String get_fullname(System.Reflection.Assembly  @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = Rget_fullname_Assembly.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Boolean GetAotIdInternal(System.Byte[]  @aotid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aotid};
            var ___result = RGetAotIdInternal_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.String InternalImageRuntimeVersion(System.Reflection.Assembly  @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RInternalImageRuntimeVersion_Assembly.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean get_global_assembly_cache()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = Rget_global_assembly_cache.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.String GetCodeBase(System.Reflection.Assembly  @a, System.Boolean  @escaped)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @escaped};
            var ___result = RGetCodeBase_Assembly_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean GetManifestResourceInfoInternal(System.String  @name, System.Reflection.ManifestResourceInfo  @info)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @info};
            var ___result = RGetManifestResourceInfoInternal_String_ManifestResourceInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Reflection.ManifestResourceInfo GetManifestResourceInfo(System.String  @resourceName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resourceName};
            var ___result = RGetManifestResourceInfo_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ManifestResourceInfo)___result;
        }


        public virtual System.String[] GetManifestResourceNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetManifestResourceNames.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.IntPtr GetManifestResourceInternal(System.String  @name, out System.Int32  @size, out System.Reflection.Module  @module)
        {
			size = default;
			module = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @size, @module};
            var ___result = RGetManifestResourceInternal_String_Out_Int32_Out_Module.Invoke(___genericsType, ___parameters);
			size = (System.Int32)___parameters[1];
			module = (System.Reflection.Module)___parameters[2];

            return (System.IntPtr)___result;
        }


        public virtual System.IO.Stream GetManifestResourceStream(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetManifestResourceStream_String.Invoke(___genericsType, ___parameters);

            return (System.IO.Stream)___result;
        }


        public virtual System.IO.Stream GetManifestResourceStream(System.Type  @type, System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @name};
            var ___result = RGetManifestResourceStream_Type_String.Invoke(___genericsType, ___parameters);

            return (System.IO.Stream)___result;
        }


        public virtual System.Boolean IsDefined(System.Type  @attributeType, System.Boolean  @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RIsDefined_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object[] GetCustomAttributes(System.Boolean  @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inherit};
            var ___result = RGetCustomAttributes_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual System.Object[] GetCustomAttributes(System.Type  @attributeType, System.Boolean  @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RGetCustomAttributes_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCustomAttributesData.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
        }


        public virtual System.Reflection.Module GetManifestModule()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetManifestModule.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module)___result;
        }


        public virtual System.Reflection.Module GetManifestModuleInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetManifestModuleInternal.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module)___result;
        }


        public virtual System.Reflection.Module[] GetModulesInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetModulesInternal.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module[])___result;
        }


        public virtual System.Object GetFilesInternal(System.String  @name, System.Boolean  @getResourceModules)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @getResourceModules};
            var ___result = RGetFilesInternal_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.IO.FileStream[] GetFiles(System.Boolean  @getResourceModules)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@getResourceModules};
            var ___result = RGetFiles_Boolean.Invoke(___genericsType, ___parameters);

            return (System.IO.FileStream[])___result;
        }


        public virtual System.IO.FileStream GetFile(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetFile_String.Invoke(___genericsType, ___parameters);

            return (System.IO.FileStream)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Security.Policy.Evidence UnprotectedGetEvidence()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUnprotectedGetEvidence.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.Evidence)___result;
        }


        public virtual void Resolve()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResolve.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean LoadPermissions(System.Reflection.Assembly  @a, ref System.IntPtr  @minimum, ref System.Int32  @minLength, ref System.IntPtr  @optional, ref System.Int32  @optLength, ref System.IntPtr  @refused, ref System.Int32  @refLength)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @minimum, @minLength, @optional, @optLength, @refused, @refLength};
            var ___result = RLoadPermissions_Assembly_Ref_IntPtr_Ref_Int32_Ref_IntPtr_Ref_Int32_Ref_IntPtr_Ref_Int32.Invoke(___genericsType, ___parameters);
			minimum = (System.IntPtr)___parameters[1];
			minLength = (System.Int32)___parameters[2];
			optional = (System.IntPtr)___parameters[3];
			optLength = (System.Int32)___parameters[4];
			refused = (System.IntPtr)___parameters[5];
			refLength = (System.Int32)___parameters[6];

            return (System.Boolean)___result;
        }


        public virtual void LoadAssemblyPermissions()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RLoadAssemblyPermissions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IO.FileStream[] GetFiles()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetFiles.Invoke(___genericsType, ___parameters);

            return (System.IO.FileStream[])___result;
        }




        public virtual System.String GetSimpleName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSimpleName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Byte[] GetPublicKey()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPublicKey.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Version GetVersion()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetVersion.Invoke(___genericsType, ___parameters);

            return (System.Version)___result;
        }


        public virtual System.Type[] GetTypes(System.Boolean  @exportedOnly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exportedOnly};
            var ___result = RGetTypes_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Type[] GetTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTypes.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Type GetType(System.String  @name, System.Boolean  @throwOnError)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @throwOnError};
            var ___result = RGetType_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type GetType(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetType_String.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type InternalGetType(System.Reflection.Module  @module, System.String  @name, System.Boolean  @throwOnError, System.Boolean  @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module, @name, @throwOnError, @ignoreCase};
            var ___result = RInternalGetType_Module_String_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Reflection.AssemblyName GetName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetName.Invoke(___genericsType, ___parameters);

            return (System.Reflection.AssemblyName)___result;
        }




        public virtual System.Reflection.Module LoadModule(System.String  @moduleName, System.Byte[]  @rawModule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@moduleName, @rawModule};
            var ___result = RLoadModule_String_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module)___result;
        }


        public virtual System.Reflection.Module LoadModule(System.String  @moduleName, System.Byte[]  @rawModule, System.Byte[]  @rawSymbolStore)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@moduleName, @rawModule, @rawSymbolStore};
            var ___result = RLoadModule_String_ByteArray_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module)___result;
        }


        public virtual System.Object CreateInstance(System.String  @typeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName};
            var ___result = RCreateInstance_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object CreateInstance(System.String  @typeName, System.Boolean  @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName, @ignoreCase};
            var ___result = RCreateInstance_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object CreateInstance(System.String  @typeName, System.Boolean  @ignoreCase, System.Reflection.BindingFlags  @bindingAttr, System.Reflection.Binder  @binder, System.Object[]  @args, System.Globalization.CultureInfo  @culture, System.Object[]  @activationAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName, @ignoreCase, @bindingAttr, @binder, @args, @culture, @activationAttributes};
            var ___result = RCreateInstance_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Reflection.Module[] GetLoadedModules()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLoadedModules.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module[])___result;
        }


        public virtual System.Reflection.Module[] GetModules()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetModules.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module[])___result;
        }


        public virtual System.Type[] GetForwardedTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetForwardedTypes.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
