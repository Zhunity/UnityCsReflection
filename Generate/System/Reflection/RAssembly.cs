using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.Assembly
	/// </summary>
    public partial class RAssembly : RMember //
    {

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
		/// System.Reflection.AssemblyNameFlags GetFlags()
		/// </summary>
		protected RMethod r_RGetFlags;
		public virtual RMethod RGetFlags
		{
			get
			{
				if(r_RGetFlags == null)
				{
					r_RGetFlags = new(this, "GetFlags", 0);
					r_RGetFlags.SetBelong(this.instance);
				}
				return r_RGetFlags;
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
		/// Void InternalGetAssemblyName(System.String, Mono.MonoAssemblyName ByRef, System.String ByRef)
		/// </summary>
		protected static RMethod r_RInternalGetAssemblyName_String_Out_MonoAssemblyName_Out_String;
		public static RMethod RInternalGetAssemblyName_String_Out_MonoAssemblyName_Out_String
		{
			get
			{
				if(r_RInternalGetAssemblyName_String_Out_MonoAssemblyName_Out_String == null)
				{
					r_RInternalGetAssemblyName_String_Out_MonoAssemblyName_Out_String = new(typeof(System.Reflection.Assembly), "InternalGetAssemblyName", 0, typeof(System.String),  ReleactionUtils.GetType("Mono.MonoAssemblyName").MakeByRefType(), typeof(System.String).MakeByRefType());
					r_RInternalGetAssemblyName_String_Out_MonoAssemblyName_Out_String.SetBelong(null);
				}
				return r_RInternalGetAssemblyName_String_Out_MonoAssemblyName_Out_String;
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
		/// System.String CreateQualifiedName(System.String, System.String)
		/// </summary>
		protected static RMethod r_RCreateQualifiedName_String_String;
		public static RMethod RCreateQualifiedName_String_String
		{
			get
			{
				if(r_RCreateQualifiedName_String_String == null)
				{
					r_RCreateQualifiedName_String_String = new(typeof(System.Reflection.Assembly), "CreateQualifiedName", 0, typeof(System.String), typeof(System.String));
					r_RCreateQualifiedName_String_String.SetBelong(null);
				}
				return r_RCreateQualifiedName_String_String;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly GetAssembly(System.Type)
		/// </summary>
		protected static RMethod r_RGetAssembly_Type;
		public static RMethod RGetAssembly_Type
		{
			get
			{
				if(r_RGetAssembly_Type == null)
				{
					r_RGetAssembly_Type = new(typeof(System.Reflection.Assembly), "GetAssembly", 0, typeof(System.Type));
					r_RGetAssembly_Type.SetBelong(null);
				}
				return r_RGetAssembly_Type;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly GetEntryAssembly()
		/// </summary>
		protected static RMethod r_RGetEntryAssembly;
		public static RMethod RGetEntryAssembly
		{
			get
			{
				if(r_RGetEntryAssembly == null)
				{
					r_RGetEntryAssembly = new(typeof(System.Reflection.Assembly), "GetEntryAssembly", 0);
					r_RGetEntryAssembly.SetBelong(null);
				}
				return r_RGetEntryAssembly;
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
		/// System.Type System.Runtime.InteropServices._Assembly.GetType()
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__InteropServices__0___Assembly__0__GetType;
		public virtual RMethod RSystem__0__Runtime__0__InteropServices__0___Assembly__0__GetType
		{
			get
			{
				if(r_RSystem__0__Runtime__0__InteropServices__0___Assembly__0__GetType == null)
				{
					r_RSystem__0__Runtime__0__InteropServices__0___Assembly__0__GetType = new(this, "System.Runtime.InteropServices._Assembly.GetType", 0);
					r_RSystem__0__Runtime__0__InteropServices__0___Assembly__0__GetType.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__InteropServices__0___Assembly__0__GetType;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly LoadFrom(System.String, Boolean, System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected static RMethod r_RLoadFrom_String_Boolean_Ref_StackCrawlMark;
		public static RMethod RLoadFrom_String_Boolean_Ref_StackCrawlMark
		{
			get
			{
				if(r_RLoadFrom_String_Boolean_Ref_StackCrawlMark == null)
				{
					r_RLoadFrom_String_Boolean_Ref_StackCrawlMark = new(typeof(System.Reflection.Assembly), "LoadFrom", 0, typeof(System.String), typeof(System.Boolean),  ReleactionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
					r_RLoadFrom_String_Boolean_Ref_StackCrawlMark.SetBelong(null);
				}
				return r_RLoadFrom_String_Boolean_Ref_StackCrawlMark;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly LoadFile_internal(System.String, System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected static RMethod r_RLoadFile_internal_String_Ref_StackCrawlMark;
		public static RMethod RLoadFile_internal_String_Ref_StackCrawlMark
		{
			get
			{
				if(r_RLoadFile_internal_String_Ref_StackCrawlMark == null)
				{
					r_RLoadFile_internal_String_Ref_StackCrawlMark = new(typeof(System.Reflection.Assembly), "LoadFile_internal", 0, typeof(System.String),  ReleactionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
					r_RLoadFile_internal_String_Ref_StackCrawlMark.SetBelong(null);
				}
				return r_RLoadFile_internal_String_Ref_StackCrawlMark;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly LoadFrom(System.String)
		/// </summary>
		protected static RMethod r_RLoadFrom_String;
		public static RMethod RLoadFrom_String
		{
			get
			{
				if(r_RLoadFrom_String == null)
				{
					r_RLoadFrom_String = new(typeof(System.Reflection.Assembly), "LoadFrom", 0, typeof(System.String));
					r_RLoadFrom_String.SetBelong(null);
				}
				return r_RLoadFrom_String;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly LoadFrom(System.String, System.Security.Policy.Evidence)
		/// </summary>
		protected static RMethod r_RLoadFrom_String_Evidence;
		public static RMethod RLoadFrom_String_Evidence
		{
			get
			{
				if(r_RLoadFrom_String_Evidence == null)
				{
					r_RLoadFrom_String_Evidence = new(typeof(System.Reflection.Assembly), "LoadFrom", 0, typeof(System.String), typeof(System.Security.Policy.Evidence));
					r_RLoadFrom_String_Evidence.SetBelong(null);
				}
				return r_RLoadFrom_String_Evidence;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly LoadFrom(System.String, System.Security.Policy.Evidence, Byte[], System.Configuration.Assemblies.AssemblyHashAlgorithm)
		/// </summary>
		protected static RMethod r_RLoadFrom_String_Evidence_ByteArray_AssemblyHashAlgorithm;
		public static RMethod RLoadFrom_String_Evidence_ByteArray_AssemblyHashAlgorithm
		{
			get
			{
				if(r_RLoadFrom_String_Evidence_ByteArray_AssemblyHashAlgorithm == null)
				{
					r_RLoadFrom_String_Evidence_ByteArray_AssemblyHashAlgorithm = new(typeof(System.Reflection.Assembly), "LoadFrom", 0, typeof(System.String), typeof(System.Security.Policy.Evidence), typeof(System.Byte).MakeArrayType(), typeof(System.Configuration.Assemblies.AssemblyHashAlgorithm));
					r_RLoadFrom_String_Evidence_ByteArray_AssemblyHashAlgorithm.SetBelong(null);
				}
				return r_RLoadFrom_String_Evidence_ByteArray_AssemblyHashAlgorithm;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly LoadFrom(System.String, Byte[], System.Configuration.Assemblies.AssemblyHashAlgorithm)
		/// </summary>
		protected static RMethod r_RLoadFrom_String_ByteArray_AssemblyHashAlgorithm;
		public static RMethod RLoadFrom_String_ByteArray_AssemblyHashAlgorithm
		{
			get
			{
				if(r_RLoadFrom_String_ByteArray_AssemblyHashAlgorithm == null)
				{
					r_RLoadFrom_String_ByteArray_AssemblyHashAlgorithm = new(typeof(System.Reflection.Assembly), "LoadFrom", 0, typeof(System.String), typeof(System.Byte).MakeArrayType(), typeof(System.Configuration.Assemblies.AssemblyHashAlgorithm));
					r_RLoadFrom_String_ByteArray_AssemblyHashAlgorithm.SetBelong(null);
				}
				return r_RLoadFrom_String_ByteArray_AssemblyHashAlgorithm;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly UnsafeLoadFrom(System.String)
		/// </summary>
		protected static RMethod r_RUnsafeLoadFrom_String;
		public static RMethod RUnsafeLoadFrom_String
		{
			get
			{
				if(r_RUnsafeLoadFrom_String == null)
				{
					r_RUnsafeLoadFrom_String = new(typeof(System.Reflection.Assembly), "UnsafeLoadFrom", 0, typeof(System.String));
					r_RUnsafeLoadFrom_String.SetBelong(null);
				}
				return r_RUnsafeLoadFrom_String;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly LoadFile(System.String, System.Security.Policy.Evidence)
		/// </summary>
		protected static RMethod r_RLoadFile_String_Evidence;
		public static RMethod RLoadFile_String_Evidence
		{
			get
			{
				if(r_RLoadFile_String_Evidence == null)
				{
					r_RLoadFile_String_Evidence = new(typeof(System.Reflection.Assembly), "LoadFile", 0, typeof(System.String), typeof(System.Security.Policy.Evidence));
					r_RLoadFile_String_Evidence.SetBelong(null);
				}
				return r_RLoadFile_String_Evidence;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly LoadFile(System.String)
		/// </summary>
		protected static RMethod r_RLoadFile_String;
		public static RMethod RLoadFile_String
		{
			get
			{
				if(r_RLoadFile_String == null)
				{
					r_RLoadFile_String = new(typeof(System.Reflection.Assembly), "LoadFile", 0, typeof(System.String));
					r_RLoadFile_String.SetBelong(null);
				}
				return r_RLoadFile_String;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(System.String)
		/// </summary>
		protected static RMethod r_RLoad_String;
		public static RMethod RLoad_String
		{
			get
			{
				if(r_RLoad_String == null)
				{
					r_RLoad_String = new(typeof(System.Reflection.Assembly), "Load", 0, typeof(System.String));
					r_RLoad_String.SetBelong(null);
				}
				return r_RLoad_String;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(System.String, System.Security.Policy.Evidence)
		/// </summary>
		protected static RMethod r_RLoad_String_Evidence;
		public static RMethod RLoad_String_Evidence
		{
			get
			{
				if(r_RLoad_String_Evidence == null)
				{
					r_RLoad_String_Evidence = new(typeof(System.Reflection.Assembly), "Load", 0, typeof(System.String), typeof(System.Security.Policy.Evidence));
					r_RLoad_String_Evidence.SetBelong(null);
				}
				return r_RLoad_String_Evidence;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(System.Reflection.AssemblyName)
		/// </summary>
		protected static RMethod r_RLoad_AssemblyName;
		public static RMethod RLoad_AssemblyName
		{
			get
			{
				if(r_RLoad_AssemblyName == null)
				{
					r_RLoad_AssemblyName = new(typeof(System.Reflection.Assembly), "Load", 0, typeof(System.Reflection.AssemblyName));
					r_RLoad_AssemblyName.SetBelong(null);
				}
				return r_RLoad_AssemblyName;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(System.Reflection.AssemblyName, System.Security.Policy.Evidence)
		/// </summary>
		protected static RMethod r_RLoad_AssemblyName_Evidence;
		public static RMethod RLoad_AssemblyName_Evidence
		{
			get
			{
				if(r_RLoad_AssemblyName_Evidence == null)
				{
					r_RLoad_AssemblyName_Evidence = new(typeof(System.Reflection.Assembly), "Load", 0, typeof(System.Reflection.AssemblyName), typeof(System.Security.Policy.Evidence));
					r_RLoad_AssemblyName_Evidence.SetBelong(null);
				}
				return r_RLoad_AssemblyName_Evidence;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(Byte[])
		/// </summary>
		protected static RMethod r_RLoad_ByteArray;
		public static RMethod RLoad_ByteArray
		{
			get
			{
				if(r_RLoad_ByteArray == null)
				{
					r_RLoad_ByteArray = new(typeof(System.Reflection.Assembly), "Load", 0, typeof(System.Byte).MakeArrayType());
					r_RLoad_ByteArray.SetBelong(null);
				}
				return r_RLoad_ByteArray;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(Byte[], Byte[])
		/// </summary>
		protected static RMethod r_RLoad_ByteArray_ByteArray;
		public static RMethod RLoad_ByteArray_ByteArray
		{
			get
			{
				if(r_RLoad_ByteArray_ByteArray == null)
				{
					r_RLoad_ByteArray_ByteArray = new(typeof(System.Reflection.Assembly), "Load", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType());
					r_RLoad_ByteArray_ByteArray.SetBelong(null);
				}
				return r_RLoad_ByteArray_ByteArray;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(Byte[], Byte[], System.Security.Policy.Evidence)
		/// </summary>
		protected static RMethod r_RLoad_ByteArray_ByteArray_Evidence;
		public static RMethod RLoad_ByteArray_ByteArray_Evidence
		{
			get
			{
				if(r_RLoad_ByteArray_ByteArray_Evidence == null)
				{
					r_RLoad_ByteArray_ByteArray_Evidence = new(typeof(System.Reflection.Assembly), "Load", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType(), typeof(System.Security.Policy.Evidence));
					r_RLoad_ByteArray_ByteArray_Evidence.SetBelong(null);
				}
				return r_RLoad_ByteArray_ByteArray_Evidence;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(Byte[], Byte[], System.Security.SecurityContextSource)
		/// </summary>
		protected static RMethod r_RLoad_ByteArray_ByteArray_SecurityContextSource;
		public static RMethod RLoad_ByteArray_ByteArray_SecurityContextSource
		{
			get
			{
				if(r_RLoad_ByteArray_ByteArray_SecurityContextSource == null)
				{
					r_RLoad_ByteArray_ByteArray_SecurityContextSource = new(typeof(System.Reflection.Assembly), "Load", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType(), typeof(System.Security.SecurityContextSource));
					r_RLoad_ByteArray_ByteArray_SecurityContextSource.SetBelong(null);
				}
				return r_RLoad_ByteArray_ByteArray_SecurityContextSource;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly ReflectionOnlyLoad(Byte[])
		/// </summary>
		protected static RMethod r_RReflectionOnlyLoad_ByteArray;
		public static RMethod RReflectionOnlyLoad_ByteArray
		{
			get
			{
				if(r_RReflectionOnlyLoad_ByteArray == null)
				{
					r_RReflectionOnlyLoad_ByteArray = new(typeof(System.Reflection.Assembly), "ReflectionOnlyLoad", 0, typeof(System.Byte).MakeArrayType());
					r_RReflectionOnlyLoad_ByteArray.SetBelong(null);
				}
				return r_RReflectionOnlyLoad_ByteArray;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly ReflectionOnlyLoad(System.String)
		/// </summary>
		protected static RMethod r_RReflectionOnlyLoad_String;
		public static RMethod RReflectionOnlyLoad_String
		{
			get
			{
				if(r_RReflectionOnlyLoad_String == null)
				{
					r_RReflectionOnlyLoad_String = new(typeof(System.Reflection.Assembly), "ReflectionOnlyLoad", 0, typeof(System.String));
					r_RReflectionOnlyLoad_String.SetBelong(null);
				}
				return r_RReflectionOnlyLoad_String;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly ReflectionOnlyLoadFrom(System.String)
		/// </summary>
		protected static RMethod r_RReflectionOnlyLoadFrom_String;
		public static RMethod RReflectionOnlyLoadFrom_String
		{
			get
			{
				if(r_RReflectionOnlyLoadFrom_String == null)
				{
					r_RReflectionOnlyLoadFrom_String = new(typeof(System.Reflection.Assembly), "ReflectionOnlyLoadFrom", 0, typeof(System.String));
					r_RReflectionOnlyLoadFrom_String.SetBelong(null);
				}
				return r_RReflectionOnlyLoadFrom_String;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly LoadWithPartialName(System.String)
		/// </summary>
		protected static RMethod r_RLoadWithPartialName_String;
		public static RMethod RLoadWithPartialName_String
		{
			get
			{
				if(r_RLoadWithPartialName_String == null)
				{
					r_RLoadWithPartialName_String = new(typeof(System.Reflection.Assembly), "LoadWithPartialName", 0, typeof(System.String));
					r_RLoadWithPartialName_String.SetBelong(null);
				}
				return r_RLoadWithPartialName_String;
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
		/// System.Reflection.Assembly load_with_partial_name(System.String, System.Security.Policy.Evidence)
		/// </summary>
		protected static RMethod r_Rload_with_partial_name_String_Evidence;
		public static RMethod Rload_with_partial_name_String_Evidence
		{
			get
			{
				if(r_Rload_with_partial_name_String_Evidence == null)
				{
					r_Rload_with_partial_name_String_Evidence = new(typeof(System.Reflection.Assembly), "load_with_partial_name", 0, typeof(System.String), typeof(System.Security.Policy.Evidence));
					r_Rload_with_partial_name_String_Evidence.SetBelong(null);
				}
				return r_Rload_with_partial_name_String_Evidence;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly LoadWithPartialName(System.String, System.Security.Policy.Evidence)
		/// </summary>
		protected static RMethod r_RLoadWithPartialName_String_Evidence;
		public static RMethod RLoadWithPartialName_String_Evidence
		{
			get
			{
				if(r_RLoadWithPartialName_String_Evidence == null)
				{
					r_RLoadWithPartialName_String_Evidence = new(typeof(System.Reflection.Assembly), "LoadWithPartialName", 0, typeof(System.String), typeof(System.Security.Policy.Evidence));
					r_RLoadWithPartialName_String_Evidence.SetBelong(null);
				}
				return r_RLoadWithPartialName_String_Evidence;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly LoadWithPartialName(System.String, System.Security.Policy.Evidence, Boolean)
		/// </summary>
		protected static RMethod r_RLoadWithPartialName_String_Evidence_Boolean;
		public static RMethod RLoadWithPartialName_String_Evidence_Boolean
		{
			get
			{
				if(r_RLoadWithPartialName_String_Evidence_Boolean == null)
				{
					r_RLoadWithPartialName_String_Evidence_Boolean = new(typeof(System.Reflection.Assembly), "LoadWithPartialName", 0, typeof(System.String), typeof(System.Security.Policy.Evidence), typeof(System.Boolean));
					r_RLoadWithPartialName_String_Evidence_Boolean.SetBelong(null);
				}
				return r_RLoadWithPartialName_String_Evidence_Boolean;
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
		/// System.Reflection.Assembly GetExecutingAssembly()
		/// </summary>
		protected static RMethod r_RGetExecutingAssembly;
		public static RMethod RGetExecutingAssembly
		{
			get
			{
				if(r_RGetExecutingAssembly == null)
				{
					r_RGetExecutingAssembly = new(typeof(System.Reflection.Assembly), "GetExecutingAssembly", 0);
					r_RGetExecutingAssembly.SetBelong(null);
				}
				return r_RGetExecutingAssembly;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly GetCallingAssembly()
		/// </summary>
		protected static RMethod r_RGetCallingAssembly;
		public static RMethod RGetCallingAssembly
		{
			get
			{
				if(r_RGetCallingAssembly == null)
				{
					r_RGetCallingAssembly = new(typeof(System.Reflection.Assembly), "GetCallingAssembly", 0);
					r_RGetCallingAssembly.SetBelong(null);
				}
				return r_RGetCallingAssembly;
			}
		}

		/// <summary>
		/// IntPtr InternalGetReferencedAssemblies(System.Reflection.Assembly)
		/// </summary>
		protected static RMethod r_RInternalGetReferencedAssemblies_Assembly;
		public static RMethod RInternalGetReferencedAssemblies_Assembly
		{
			get
			{
				if(r_RInternalGetReferencedAssemblies_Assembly == null)
				{
					r_RInternalGetReferencedAssemblies_Assembly = new(typeof(System.Reflection.Assembly), "InternalGetReferencedAssemblies", 0, typeof(System.Reflection.Assembly));
					r_RInternalGetReferencedAssemblies_Assembly.SetBelong(null);
				}
				return r_RInternalGetReferencedAssemblies_Assembly;
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
		/// System.Reflection.AssemblyName[] GetReferencedAssemblies(System.Reflection.Assembly)
		/// </summary>
		protected static RMethod r_RGetReferencedAssemblies_Assembly;
		public static RMethod RGetReferencedAssemblies_Assembly
		{
			get
			{
				if(r_RGetReferencedAssemblies_Assembly == null)
				{
					r_RGetReferencedAssemblies_Assembly = new(typeof(System.Reflection.Assembly), "GetReferencedAssemblies", 0, typeof(System.Reflection.Assembly));
					r_RGetReferencedAssemblies_Assembly.SetBelong(null);
				}
				return r_RGetReferencedAssemblies_Assembly;
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
		/// System.Exception CreateNIE()
		/// </summary>
		protected static RMethod r_RCreateNIE;
		public static RMethod RCreateNIE
		{
			get
			{
				if(r_RCreateNIE == null)
				{
					r_RCreateNIE = new(typeof(System.Reflection.Assembly), "CreateNIE", 0);
					r_RCreateNIE.SetBelong(null);
				}
				return r_RCreateNIE;
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
		/// Boolean op_Equality(System.Reflection.Assembly, System.Reflection.Assembly)
		/// </summary>
		protected static RMethod r_Rop_Equality_Assembly_Assembly;
		public static RMethod Rop_Equality_Assembly_Assembly
		{
			get
			{
				if(r_Rop_Equality_Assembly_Assembly == null)
				{
					r_Rop_Equality_Assembly_Assembly = new(typeof(System.Reflection.Assembly), "op_Equality", 0, typeof(System.Reflection.Assembly), typeof(System.Reflection.Assembly));
					r_Rop_Equality_Assembly_Assembly.SetBelong(null);
				}
				return r_Rop_Equality_Assembly_Assembly;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Reflection.Assembly, System.Reflection.Assembly)
		/// </summary>
		protected static RMethod r_Rop_Inequality_Assembly_Assembly;
		public static RMethod Rop_Inequality_Assembly_Assembly
		{
			get
			{
				if(r_Rop_Inequality_Assembly_Assembly == null)
				{
					r_Rop_Inequality_Assembly_Assembly = new(typeof(System.Reflection.Assembly), "op_Inequality", 0, typeof(System.Reflection.Assembly), typeof(System.Reflection.Assembly));
					r_Rop_Inequality_Assembly_Assembly.SetBelong(null);
				}
				return r_Rop_Inequality_Assembly_Assembly;
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


        public RAssembly() : base("System.Reflection.Assembly")
        {
        }

        public RAssembly(System.Object instance) : base("System.Reflection.Assembly")
		{
            SetInstance(instance);
		}

        public RAssembly(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAssembly(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Security.Policy.Evidence UnprotectedGetEvidence()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUnprotectedGetEvidence.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.Evidence)___result;
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo  @info, System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.IO.FileStream[] GetFiles()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetFiles.Invoke(___genericsType, ___parameters);

            return (System.IO.FileStream[])___result;
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


        public virtual System.Reflection.AssemblyNameFlags GetFlags()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.AssemblyNameFlags)___result;
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


        public virtual System.Type[] GetExportedTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetExportedTypes.Invoke(___genericsType, ___parameters);

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



        public virtual System.Reflection.AssemblyName GetName(System.Boolean  @copiedName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@copiedName};
            var ___result = RGetName_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.AssemblyName)___result;
        }


        public virtual System.Reflection.AssemblyName GetName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetName.Invoke(___genericsType, ___parameters);

            return (System.Reflection.AssemblyName)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String CreateQualifiedName(System.String  @assemblyName, System.String  @typeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName};
            var ___result = RCreateQualifiedName_String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Reflection.Assembly GetAssembly(System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetAssembly_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly GetEntryAssembly()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEntryAssembly.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }




        public virtual System.Type System__0__Runtime__0__InteropServices__0___Assembly__0__GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__0__Runtime__0__InteropServices__0___Assembly__0__GetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }




        public static System.Reflection.Assembly LoadFrom(System.String  @assemblyFile)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile};
            var ___result = RLoadFrom_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly LoadFrom(System.String  @assemblyFile, System.Security.Policy.Evidence  @securityEvidence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile, @securityEvidence};
            var ___result = RLoadFrom_String_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly LoadFrom(System.String  @assemblyFile, System.Security.Policy.Evidence  @securityEvidence, System.Byte[]  @hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm  @hashAlgorithm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile, @securityEvidence, @hashValue, @hashAlgorithm};
            var ___result = RLoadFrom_String_Evidence_ByteArray_AssemblyHashAlgorithm.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly LoadFrom(System.String  @assemblyFile, System.Byte[]  @hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm  @hashAlgorithm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile, @hashValue, @hashAlgorithm};
            var ___result = RLoadFrom_String_ByteArray_AssemblyHashAlgorithm.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly UnsafeLoadFrom(System.String  @assemblyFile)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile};
            var ___result = RUnsafeLoadFrom_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly LoadFile(System.String  @path, System.Security.Policy.Evidence  @securityEvidence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path, @securityEvidence};
            var ___result = RLoadFile_String_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly LoadFile(System.String  @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path};
            var ___result = RLoadFile_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly Load(System.String  @assemblyString)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyString};
            var ___result = RLoad_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly Load(System.String  @assemblyString, System.Security.Policy.Evidence  @assemblySecurity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyString, @assemblySecurity};
            var ___result = RLoad_String_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly Load(System.Reflection.AssemblyName  @assemblyRef)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyRef};
            var ___result = RLoad_AssemblyName.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly Load(System.Reflection.AssemblyName  @assemblyRef, System.Security.Policy.Evidence  @assemblySecurity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyRef, @assemblySecurity};
            var ___result = RLoad_AssemblyName_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly Load(System.Byte[]  @rawAssembly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rawAssembly};
            var ___result = RLoad_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly Load(System.Byte[]  @rawAssembly, System.Byte[]  @rawSymbolStore)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rawAssembly, @rawSymbolStore};
            var ___result = RLoad_ByteArray_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly Load(System.Byte[]  @rawAssembly, System.Byte[]  @rawSymbolStore, System.Security.Policy.Evidence  @securityEvidence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rawAssembly, @rawSymbolStore, @securityEvidence};
            var ___result = RLoad_ByteArray_ByteArray_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly Load(System.Byte[]  @rawAssembly, System.Byte[]  @rawSymbolStore, System.Security.SecurityContextSource  @securityContextSource)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rawAssembly, @rawSymbolStore, @securityContextSource};
            var ___result = RLoad_ByteArray_ByteArray_SecurityContextSource.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly ReflectionOnlyLoad(System.Byte[]  @rawAssembly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rawAssembly};
            var ___result = RReflectionOnlyLoad_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly ReflectionOnlyLoad(System.String  @assemblyString)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyString};
            var ___result = RReflectionOnlyLoad_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly ReflectionOnlyLoadFrom(System.String  @assemblyFile)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile};
            var ___result = RReflectionOnlyLoadFrom_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly LoadWithPartialName(System.String  @partialName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@partialName};
            var ___result = RLoadWithPartialName_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
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


        public static System.Reflection.Assembly load_with_partial_name(System.String  @name, System.Security.Policy.Evidence  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @e};
            var ___result = Rload_with_partial_name_String_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly LoadWithPartialName(System.String  @partialName, System.Security.Policy.Evidence  @securityEvidence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@partialName, @securityEvidence};
            var ___result = RLoadWithPartialName_String_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly LoadWithPartialName(System.String  @partialName, System.Security.Policy.Evidence  @securityEvidence, System.Boolean  @oldBehavior)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@partialName, @securityEvidence, @oldBehavior};
            var ___result = RLoadWithPartialName_String_Evidence_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
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


        public virtual System.Reflection.Module[] GetModulesInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetModulesInternal.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module[])___result;
        }


        public static System.Reflection.Assembly GetExecutingAssembly()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetExecutingAssembly.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly GetCallingAssembly()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCallingAssembly.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.IntPtr InternalGetReferencedAssemblies(System.Reflection.Assembly  @module)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module};
            var ___result = RInternalGetReferencedAssemblies_Assembly.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual System.String[] GetManifestResourceNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetManifestResourceNames.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public static System.Reflection.AssemblyName[] GetReferencedAssemblies(System.Reflection.Assembly  @module)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module};
            var ___result = RGetReferencedAssemblies_Assembly.Invoke(___genericsType, ___parameters);

            return (System.Reflection.AssemblyName[])___result;
        }


        public virtual System.Reflection.ManifestResourceInfo GetManifestResourceInfo(System.String  @resourceName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resourceName};
            var ___result = RGetManifestResourceInfo_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ManifestResourceInfo)___result;
        }


        public virtual System.Reflection.Module GetManifestModule()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetManifestModule.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module)___result;
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


        public static System.Exception CreateNIE()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateNIE.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCustomAttributesData.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
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


        public static System.Boolean op_Equality(System.Reflection.Assembly  @left, System.Reflection.Assembly  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Equality_Assembly_Assembly.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Reflection.Assembly  @left, System.Reflection.Assembly  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Inequality_Assembly_Assembly.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
