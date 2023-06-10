
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.Assembly
	/// </summary>
    public partial class RAssembly : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Reflection.Assembly);
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
		/// System.Reflection.AssemblyNameFlags GetFlags()
		/// </summary>
		protected RMethod r_MGetFlags;
		public virtual RMethod RMGetFlags
		{
			get
			{
				if(r_MGetFlags == null)
				{
					r_MGetFlags = new(this, "GetFlags", 0);
				}
				return r_MGetFlags;
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
		/// Void InternalGetAssemblyName(System.String, Mono.MonoAssemblyName ByRef, System.String ByRef)
		/// </summary>
		protected static RMethod r_MInternalGetAssemblyName_String_Out_MonoAssemblyName_Out_String;
		public static RMethod RMInternalGetAssemblyName_String_Out_MonoAssemblyName_Out_String
		{
			get
			{
				if(r_MInternalGetAssemblyName_String_Out_MonoAssemblyName_Out_String == null)
				{
					r_MInternalGetAssemblyName_String_Out_MonoAssemblyName_Out_String = new(typeof(System.Reflection.Assembly), "InternalGetAssemblyName", 0, typeof(System.String),  ReflectionUtils.GetType("Mono.MonoAssemblyName").MakeByRefType(), typeof(System.String).MakeByRefType());
				}
				return r_MInternalGetAssemblyName_String_Out_MonoAssemblyName_Out_String;
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
		/// System.String CreateQualifiedName(System.String, System.String)
		/// </summary>
		protected static RMethod r_MCreateQualifiedName_String_String;
		public static RMethod RMCreateQualifiedName_String_String
		{
			get
			{
				if(r_MCreateQualifiedName_String_String == null)
				{
					r_MCreateQualifiedName_String_String = new(typeof(System.Reflection.Assembly), "CreateQualifiedName", 0, typeof(System.String), typeof(System.String));
				}
				return r_MCreateQualifiedName_String_String;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly GetAssembly(System.Type)
		/// </summary>
		protected static RMethod r_MGetAssembly_Type;
		public static RMethod RMGetAssembly_Type
		{
			get
			{
				if(r_MGetAssembly_Type == null)
				{
					r_MGetAssembly_Type = new(typeof(System.Reflection.Assembly), "GetAssembly", 0, typeof(System.Type));
				}
				return r_MGetAssembly_Type;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly GetEntryAssembly()
		/// </summary>
		protected static RMethod r_MGetEntryAssembly;
		public static RMethod RMGetEntryAssembly
		{
			get
			{
				if(r_MGetEntryAssembly == null)
				{
					r_MGetEntryAssembly = new(typeof(System.Reflection.Assembly), "GetEntryAssembly", 0);
				}
				return r_MGetEntryAssembly;
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
		/// System.Type System.Runtime.InteropServices._Assembly.GetType()
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___Assembly__2__GetType;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___Assembly__2__GetType
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___Assembly__2__GetType == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___Assembly__2__GetType = new(this, "System.Runtime.InteropServices._Assembly.GetType", 0);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___Assembly__2__GetType;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly LoadFrom(System.String, Boolean, System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected static RMethod r_MLoadFrom_String_Boolean_Ref_StackCrawlMark;
		public static RMethod RMLoadFrom_String_Boolean_Ref_StackCrawlMark
		{
			get
			{
				if(r_MLoadFrom_String_Boolean_Ref_StackCrawlMark == null)
				{
					r_MLoadFrom_String_Boolean_Ref_StackCrawlMark = new(typeof(System.Reflection.Assembly), "LoadFrom", 0, typeof(System.String), typeof(System.Boolean),  ReflectionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
				}
				return r_MLoadFrom_String_Boolean_Ref_StackCrawlMark;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly LoadFile_internal(System.String, System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected static RMethod r_MLoadFile_internal_String_Ref_StackCrawlMark;
		public static RMethod RMLoadFile_internal_String_Ref_StackCrawlMark
		{
			get
			{
				if(r_MLoadFile_internal_String_Ref_StackCrawlMark == null)
				{
					r_MLoadFile_internal_String_Ref_StackCrawlMark = new(typeof(System.Reflection.Assembly), "LoadFile_internal", 0, typeof(System.String),  ReflectionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
				}
				return r_MLoadFile_internal_String_Ref_StackCrawlMark;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly LoadFrom(System.String)
		/// </summary>
		protected static RMethod r_MLoadFrom_String;
		public static RMethod RMLoadFrom_String
		{
			get
			{
				if(r_MLoadFrom_String == null)
				{
					r_MLoadFrom_String = new(typeof(System.Reflection.Assembly), "LoadFrom", 0, typeof(System.String));
				}
				return r_MLoadFrom_String;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly LoadFrom(System.String, System.Security.Policy.Evidence)
		/// </summary>
		protected static RMethod r_MLoadFrom_String_Evidence;
		public static RMethod RMLoadFrom_String_Evidence
		{
			get
			{
				if(r_MLoadFrom_String_Evidence == null)
				{
					r_MLoadFrom_String_Evidence = new(typeof(System.Reflection.Assembly), "LoadFrom", 0, typeof(System.String), typeof(System.Security.Policy.Evidence));
				}
				return r_MLoadFrom_String_Evidence;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly LoadFrom(System.String, System.Security.Policy.Evidence, Byte[], System.Configuration.Assemblies.AssemblyHashAlgorithm)
		/// </summary>
		protected static RMethod r_MLoadFrom_String_Evidence_ByteArray_AssemblyHashAlgorithm;
		public static RMethod RMLoadFrom_String_Evidence_ByteArray_AssemblyHashAlgorithm
		{
			get
			{
				if(r_MLoadFrom_String_Evidence_ByteArray_AssemblyHashAlgorithm == null)
				{
					r_MLoadFrom_String_Evidence_ByteArray_AssemblyHashAlgorithm = new(typeof(System.Reflection.Assembly), "LoadFrom", 0, typeof(System.String), typeof(System.Security.Policy.Evidence), typeof(System.Byte).MakeArrayType(), typeof(System.Configuration.Assemblies.AssemblyHashAlgorithm));
				}
				return r_MLoadFrom_String_Evidence_ByteArray_AssemblyHashAlgorithm;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly LoadFrom(System.String, Byte[], System.Configuration.Assemblies.AssemblyHashAlgorithm)
		/// </summary>
		protected static RMethod r_MLoadFrom_String_ByteArray_AssemblyHashAlgorithm;
		public static RMethod RMLoadFrom_String_ByteArray_AssemblyHashAlgorithm
		{
			get
			{
				if(r_MLoadFrom_String_ByteArray_AssemblyHashAlgorithm == null)
				{
					r_MLoadFrom_String_ByteArray_AssemblyHashAlgorithm = new(typeof(System.Reflection.Assembly), "LoadFrom", 0, typeof(System.String), typeof(System.Byte).MakeArrayType(), typeof(System.Configuration.Assemblies.AssemblyHashAlgorithm));
				}
				return r_MLoadFrom_String_ByteArray_AssemblyHashAlgorithm;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly UnsafeLoadFrom(System.String)
		/// </summary>
		protected static RMethod r_MUnsafeLoadFrom_String;
		public static RMethod RMUnsafeLoadFrom_String
		{
			get
			{
				if(r_MUnsafeLoadFrom_String == null)
				{
					r_MUnsafeLoadFrom_String = new(typeof(System.Reflection.Assembly), "UnsafeLoadFrom", 0, typeof(System.String));
				}
				return r_MUnsafeLoadFrom_String;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly LoadFile(System.String, System.Security.Policy.Evidence)
		/// </summary>
		protected static RMethod r_MLoadFile_String_Evidence;
		public static RMethod RMLoadFile_String_Evidence
		{
			get
			{
				if(r_MLoadFile_String_Evidence == null)
				{
					r_MLoadFile_String_Evidence = new(typeof(System.Reflection.Assembly), "LoadFile", 0, typeof(System.String), typeof(System.Security.Policy.Evidence));
				}
				return r_MLoadFile_String_Evidence;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly LoadFile(System.String)
		/// </summary>
		protected static RMethod r_MLoadFile_String;
		public static RMethod RMLoadFile_String
		{
			get
			{
				if(r_MLoadFile_String == null)
				{
					r_MLoadFile_String = new(typeof(System.Reflection.Assembly), "LoadFile", 0, typeof(System.String));
				}
				return r_MLoadFile_String;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(System.String)
		/// </summary>
		protected static RMethod r_MLoad_String;
		public static RMethod RMLoad_String
		{
			get
			{
				if(r_MLoad_String == null)
				{
					r_MLoad_String = new(typeof(System.Reflection.Assembly), "Load", 0, typeof(System.String));
				}
				return r_MLoad_String;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(System.String, System.Security.Policy.Evidence)
		/// </summary>
		protected static RMethod r_MLoad_String_Evidence;
		public static RMethod RMLoad_String_Evidence
		{
			get
			{
				if(r_MLoad_String_Evidence == null)
				{
					r_MLoad_String_Evidence = new(typeof(System.Reflection.Assembly), "Load", 0, typeof(System.String), typeof(System.Security.Policy.Evidence));
				}
				return r_MLoad_String_Evidence;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(System.Reflection.AssemblyName)
		/// </summary>
		protected static RMethod r_MLoad_AssemblyName;
		public static RMethod RMLoad_AssemblyName
		{
			get
			{
				if(r_MLoad_AssemblyName == null)
				{
					r_MLoad_AssemblyName = new(typeof(System.Reflection.Assembly), "Load", 0, typeof(System.Reflection.AssemblyName));
				}
				return r_MLoad_AssemblyName;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(System.Reflection.AssemblyName, System.Security.Policy.Evidence)
		/// </summary>
		protected static RMethod r_MLoad_AssemblyName_Evidence;
		public static RMethod RMLoad_AssemblyName_Evidence
		{
			get
			{
				if(r_MLoad_AssemblyName_Evidence == null)
				{
					r_MLoad_AssemblyName_Evidence = new(typeof(System.Reflection.Assembly), "Load", 0, typeof(System.Reflection.AssemblyName), typeof(System.Security.Policy.Evidence));
				}
				return r_MLoad_AssemblyName_Evidence;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(Byte[])
		/// </summary>
		protected static RMethod r_MLoad_ByteArray;
		public static RMethod RMLoad_ByteArray
		{
			get
			{
				if(r_MLoad_ByteArray == null)
				{
					r_MLoad_ByteArray = new(typeof(System.Reflection.Assembly), "Load", 0, typeof(System.Byte).MakeArrayType());
				}
				return r_MLoad_ByteArray;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(Byte[], Byte[])
		/// </summary>
		protected static RMethod r_MLoad_ByteArray_ByteArray;
		public static RMethod RMLoad_ByteArray_ByteArray
		{
			get
			{
				if(r_MLoad_ByteArray_ByteArray == null)
				{
					r_MLoad_ByteArray_ByteArray = new(typeof(System.Reflection.Assembly), "Load", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType());
				}
				return r_MLoad_ByteArray_ByteArray;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(Byte[], Byte[], System.Security.Policy.Evidence)
		/// </summary>
		protected static RMethod r_MLoad_ByteArray_ByteArray_Evidence;
		public static RMethod RMLoad_ByteArray_ByteArray_Evidence
		{
			get
			{
				if(r_MLoad_ByteArray_ByteArray_Evidence == null)
				{
					r_MLoad_ByteArray_ByteArray_Evidence = new(typeof(System.Reflection.Assembly), "Load", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType(), typeof(System.Security.Policy.Evidence));
				}
				return r_MLoad_ByteArray_ByteArray_Evidence;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(Byte[], Byte[], System.Security.SecurityContextSource)
		/// </summary>
		protected static RMethod r_MLoad_ByteArray_ByteArray_SecurityContextSource;
		public static RMethod RMLoad_ByteArray_ByteArray_SecurityContextSource
		{
			get
			{
				if(r_MLoad_ByteArray_ByteArray_SecurityContextSource == null)
				{
					r_MLoad_ByteArray_ByteArray_SecurityContextSource = new(typeof(System.Reflection.Assembly), "Load", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType(), typeof(System.Security.SecurityContextSource));
				}
				return r_MLoad_ByteArray_ByteArray_SecurityContextSource;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly ReflectionOnlyLoad(Byte[])
		/// </summary>
		protected static RMethod r_MReflectionOnlyLoad_ByteArray;
		public static RMethod RMReflectionOnlyLoad_ByteArray
		{
			get
			{
				if(r_MReflectionOnlyLoad_ByteArray == null)
				{
					r_MReflectionOnlyLoad_ByteArray = new(typeof(System.Reflection.Assembly), "ReflectionOnlyLoad", 0, typeof(System.Byte).MakeArrayType());
				}
				return r_MReflectionOnlyLoad_ByteArray;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly ReflectionOnlyLoad(System.String)
		/// </summary>
		protected static RMethod r_MReflectionOnlyLoad_String;
		public static RMethod RMReflectionOnlyLoad_String
		{
			get
			{
				if(r_MReflectionOnlyLoad_String == null)
				{
					r_MReflectionOnlyLoad_String = new(typeof(System.Reflection.Assembly), "ReflectionOnlyLoad", 0, typeof(System.String));
				}
				return r_MReflectionOnlyLoad_String;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly ReflectionOnlyLoadFrom(System.String)
		/// </summary>
		protected static RMethod r_MReflectionOnlyLoadFrom_String;
		public static RMethod RMReflectionOnlyLoadFrom_String
		{
			get
			{
				if(r_MReflectionOnlyLoadFrom_String == null)
				{
					r_MReflectionOnlyLoadFrom_String = new(typeof(System.Reflection.Assembly), "ReflectionOnlyLoadFrom", 0, typeof(System.String));
				}
				return r_MReflectionOnlyLoadFrom_String;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly LoadWithPartialName(System.String)
		/// </summary>
		protected static RMethod r_MLoadWithPartialName_String;
		public static RMethod RMLoadWithPartialName_String
		{
			get
			{
				if(r_MLoadWithPartialName_String == null)
				{
					r_MLoadWithPartialName_String = new(typeof(System.Reflection.Assembly), "LoadWithPartialName", 0, typeof(System.String));
				}
				return r_MLoadWithPartialName_String;
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
		/// System.Reflection.Assembly load_with_partial_name(System.String, System.Security.Policy.Evidence)
		/// </summary>
		protected static RMethod r_Mload_with_partial_name_String_Evidence;
		public static RMethod RMload_with_partial_name_String_Evidence
		{
			get
			{
				if(r_Mload_with_partial_name_String_Evidence == null)
				{
					r_Mload_with_partial_name_String_Evidence = new(typeof(System.Reflection.Assembly), "load_with_partial_name", 0, typeof(System.String), typeof(System.Security.Policy.Evidence));
				}
				return r_Mload_with_partial_name_String_Evidence;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly LoadWithPartialName(System.String, System.Security.Policy.Evidence)
		/// </summary>
		protected static RMethod r_MLoadWithPartialName_String_Evidence;
		public static RMethod RMLoadWithPartialName_String_Evidence
		{
			get
			{
				if(r_MLoadWithPartialName_String_Evidence == null)
				{
					r_MLoadWithPartialName_String_Evidence = new(typeof(System.Reflection.Assembly), "LoadWithPartialName", 0, typeof(System.String), typeof(System.Security.Policy.Evidence));
				}
				return r_MLoadWithPartialName_String_Evidence;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly LoadWithPartialName(System.String, System.Security.Policy.Evidence, Boolean)
		/// </summary>
		protected static RMethod r_MLoadWithPartialName_String_Evidence_Boolean;
		public static RMethod RMLoadWithPartialName_String_Evidence_Boolean
		{
			get
			{
				if(r_MLoadWithPartialName_String_Evidence_Boolean == null)
				{
					r_MLoadWithPartialName_String_Evidence_Boolean = new(typeof(System.Reflection.Assembly), "LoadWithPartialName", 0, typeof(System.String), typeof(System.Security.Policy.Evidence), typeof(System.Boolean));
				}
				return r_MLoadWithPartialName_String_Evidence_Boolean;
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
		/// System.Reflection.Assembly GetExecutingAssembly()
		/// </summary>
		protected static RMethod r_MGetExecutingAssembly;
		public static RMethod RMGetExecutingAssembly
		{
			get
			{
				if(r_MGetExecutingAssembly == null)
				{
					r_MGetExecutingAssembly = new(typeof(System.Reflection.Assembly), "GetExecutingAssembly", 0);
				}
				return r_MGetExecutingAssembly;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly GetCallingAssembly()
		/// </summary>
		protected static RMethod r_MGetCallingAssembly;
		public static RMethod RMGetCallingAssembly
		{
			get
			{
				if(r_MGetCallingAssembly == null)
				{
					r_MGetCallingAssembly = new(typeof(System.Reflection.Assembly), "GetCallingAssembly", 0);
				}
				return r_MGetCallingAssembly;
			}
		}

		/// <summary>
		/// IntPtr InternalGetReferencedAssemblies(System.Reflection.Assembly)
		/// </summary>
		protected static RMethod r_MInternalGetReferencedAssemblies_Assembly;
		public static RMethod RMInternalGetReferencedAssemblies_Assembly
		{
			get
			{
				if(r_MInternalGetReferencedAssemblies_Assembly == null)
				{
					r_MInternalGetReferencedAssemblies_Assembly = new(typeof(System.Reflection.Assembly), "InternalGetReferencedAssemblies", 0, typeof(System.Reflection.Assembly));
				}
				return r_MInternalGetReferencedAssemblies_Assembly;
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
		/// System.Reflection.AssemblyName[] GetReferencedAssemblies(System.Reflection.Assembly)
		/// </summary>
		protected static RMethod r_MGetReferencedAssemblies_Assembly;
		public static RMethod RMGetReferencedAssemblies_Assembly
		{
			get
			{
				if(r_MGetReferencedAssemblies_Assembly == null)
				{
					r_MGetReferencedAssemblies_Assembly = new(typeof(System.Reflection.Assembly), "GetReferencedAssemblies", 0, typeof(System.Reflection.Assembly));
				}
				return r_MGetReferencedAssemblies_Assembly;
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
		/// System.Exception CreateNIE()
		/// </summary>
		protected static RMethod r_MCreateNIE;
		public static RMethod RMCreateNIE
		{
			get
			{
				if(r_MCreateNIE == null)
				{
					r_MCreateNIE = new(typeof(System.Reflection.Assembly), "CreateNIE", 0);
				}
				return r_MCreateNIE;
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
		/// Boolean op_Equality(System.Reflection.Assembly, System.Reflection.Assembly)
		/// </summary>
		protected static RMethod r_Mop_Equality_Assembly_Assembly;
		public static RMethod RMop_Equality_Assembly_Assembly
		{
			get
			{
				if(r_Mop_Equality_Assembly_Assembly == null)
				{
					r_Mop_Equality_Assembly_Assembly = new(typeof(System.Reflection.Assembly), "op_Equality", 0, typeof(System.Reflection.Assembly), typeof(System.Reflection.Assembly));
				}
				return r_Mop_Equality_Assembly_Assembly;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Reflection.Assembly, System.Reflection.Assembly)
		/// </summary>
		protected static RMethod r_Mop_Inequality_Assembly_Assembly;
		public static RMethod RMop_Inequality_Assembly_Assembly
		{
			get
			{
				if(r_Mop_Inequality_Assembly_Assembly == null)
				{
					r_Mop_Inequality_Assembly_Assembly = new(typeof(System.Reflection.Assembly), "op_Inequality", 0, typeof(System.Reflection.Assembly), typeof(System.Reflection.Assembly));
				}
				return r_Mop_Inequality_Assembly_Assembly;
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


        public virtual System.Security.Policy.Evidence UnprotectedGetEvidence()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUnprotectedGetEvidence.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.Evidence)___result;
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsDefined(System.Type @attributeType, System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RMIsDefined_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object[] GetCustomAttributes(System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inherit};
            var ___result = RMGetCustomAttributes_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual System.Object[] GetCustomAttributes(System.Type @attributeType, System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RMGetCustomAttributes_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual System.IO.FileStream[] GetFiles()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetFiles.Invoke(___genericsType, ___parameters);

            return (System.IO.FileStream[])___result;
        }


        public virtual System.IO.FileStream[] GetFiles(System.Boolean @getResourceModules)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@getResourceModules};
            var ___result = RMGetFiles_Boolean.Invoke(___genericsType, ___parameters);

            return (System.IO.FileStream[])___result;
        }


        public virtual System.IO.FileStream GetFile(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetFile_String.Invoke(___genericsType, ___parameters);

            return (System.IO.FileStream)___result;
        }


        public virtual System.IO.Stream GetManifestResourceStream(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetManifestResourceStream_String.Invoke(___genericsType, ___parameters);

            return (System.IO.Stream)___result;
        }


        public virtual System.IO.Stream GetManifestResourceStream(System.Type @type, System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @name};
            var ___result = RMGetManifestResourceStream_Type_String.Invoke(___genericsType, ___parameters);

            return (System.IO.Stream)___result;
        }


        public virtual System.IO.Stream GetManifestResourceStream(System.Type @type, System.String @name, System.Boolean @skipSecurityCheck, ref Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark @stackMark)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @name, @skipSecurityCheck, @stackMark.Value};
            var ___result = RMGetManifestResourceStream_Type_String_Boolean_Ref_StackCrawlMark.Invoke(___genericsType, ___parameters);
			@stackMark = new Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark(___parameters[3]);

            return (System.IO.Stream)___result;
        }


        public virtual System.IO.Stream GetManifestResourceStream(System.String @name, ref Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark @stackMark, System.Boolean @skipSecurityCheck)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @stackMark.Value, @skipSecurityCheck};
            var ___result = RMGetManifestResourceStream_String_Ref_StackCrawlMark_Boolean.Invoke(___genericsType, ___parameters);
			@stackMark = new Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark(___parameters[1]);

            return (System.IO.Stream)___result;
        }


        public virtual System.String GetSimpleName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSimpleName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Byte[] GetPublicKey()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPublicKey.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Version GetVersion()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetVersion.Invoke(___genericsType, ___parameters);

            return (System.Version)___result;
        }


        public virtual System.Reflection.AssemblyNameFlags GetFlags()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.AssemblyNameFlags)___result;
        }


        public virtual System.Type[] GetTypes(System.Boolean @exportedOnly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exportedOnly};
            var ___result = RMGetTypes_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Type[] GetTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypes.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Type[] GetExportedTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetExportedTypes.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Type GetType(System.String @name, System.Boolean @throwOnError)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @throwOnError};
            var ___result = RMGetType_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type GetType(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetType_String.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type InternalGetType(System.Reflection.Module @module, System.String @name, System.Boolean @throwOnError, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module, @name, @throwOnError, @ignoreCase};
            var ___result = RMInternalGetType_Module_String_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static void InternalGetAssemblyName(System.String @assemblyFile, out Hvak.Editor.Refleaction.RMono.RMonoAssemblyName @aname, out System.String @codebase)
        {
			@aname = default;
			@codebase = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile, @aname.Value, @codebase};
            var ___result = RMInternalGetAssemblyName_String_Out_MonoAssemblyName_Out_String.Invoke(___genericsType, ___parameters);
			@aname = new Hvak.Editor.Refleaction.RMono.RMonoAssemblyName(___parameters[1]);
			@codebase = (System.String)___parameters[2];

            
        }


        public virtual System.Reflection.AssemblyName GetName(System.Boolean @copiedName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@copiedName};
            var ___result = RMGetName_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.AssemblyName)___result;
        }


        public virtual System.Reflection.AssemblyName GetName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetName.Invoke(___genericsType, ___parameters);

            return (System.Reflection.AssemblyName)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String CreateQualifiedName(System.String @assemblyName, System.String @typeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName};
            var ___result = RMCreateQualifiedName_String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Reflection.Assembly GetAssembly(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMGetAssembly_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly GetEntryAssembly()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEntryAssembly.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public virtual System.Reflection.Assembly GetSatelliteAssembly(System.Globalization.CultureInfo @culture, System.Version @version, System.Boolean @throwOnError, ref Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark @stackMark)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@culture, @version, @throwOnError, @stackMark.Value};
            var ___result = RMGetSatelliteAssembly_CultureInfo_Version_Boolean_Ref_StackCrawlMark.Invoke(___genericsType, ___parameters);
			@stackMark = new Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark(___parameters[3]);

            return (System.Reflection.Assembly)___result;
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeAssembly InternalGetSatelliteAssembly(System.String @name, System.Globalization.CultureInfo @culture, System.Version @version, System.Boolean @throwOnFileNotFound, ref Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark @stackMark)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @culture, @version, @throwOnFileNotFound, @stackMark.Value};
            var ___result = RMInternalGetSatelliteAssembly_String_CultureInfo_Version_Boolean_Ref_StackCrawlMark.Invoke(___genericsType, ___parameters);
			@stackMark = new Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark(___parameters[4]);

            return new Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeAssembly(___result);
        }


        public virtual System.Type System__2__Runtime__2__InteropServices__2___Assembly__2__GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___Assembly__2__GetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Reflection.Assembly LoadFrom(System.String @assemblyFile, System.Boolean @refOnly, ref Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark @stackMark)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile, @refOnly, @stackMark.Value};
            var ___result = RMLoadFrom_String_Boolean_Ref_StackCrawlMark.Invoke(___genericsType, ___parameters);
			@stackMark = new Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark(___parameters[2]);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly LoadFile_internal(System.String @assemblyFile, ref Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark @stackMark)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile, @stackMark.Value};
            var ___result = RMLoadFile_internal_String_Ref_StackCrawlMark.Invoke(___genericsType, ___parameters);
			@stackMark = new Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark(___parameters[1]);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly LoadFrom(System.String @assemblyFile)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile};
            var ___result = RMLoadFrom_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly LoadFrom(System.String @assemblyFile, System.Security.Policy.Evidence @securityEvidence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile, @securityEvidence};
            var ___result = RMLoadFrom_String_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly LoadFrom(System.String @assemblyFile, System.Security.Policy.Evidence @securityEvidence, System.Byte[] @hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm @hashAlgorithm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile, @securityEvidence, @hashValue, @hashAlgorithm};
            var ___result = RMLoadFrom_String_Evidence_ByteArray_AssemblyHashAlgorithm.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly LoadFrom(System.String @assemblyFile, System.Byte[] @hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm @hashAlgorithm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile, @hashValue, @hashAlgorithm};
            var ___result = RMLoadFrom_String_ByteArray_AssemblyHashAlgorithm.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly UnsafeLoadFrom(System.String @assemblyFile)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile};
            var ___result = RMUnsafeLoadFrom_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly LoadFile(System.String @path, System.Security.Policy.Evidence @securityEvidence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path, @securityEvidence};
            var ___result = RMLoadFile_String_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly LoadFile(System.String @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path};
            var ___result = RMLoadFile_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly Load(System.String @assemblyString)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyString};
            var ___result = RMLoad_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly Load(System.String @assemblyString, System.Security.Policy.Evidence @assemblySecurity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyString, @assemblySecurity};
            var ___result = RMLoad_String_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly Load(System.Reflection.AssemblyName @assemblyRef)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyRef};
            var ___result = RMLoad_AssemblyName.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly Load(System.Reflection.AssemblyName @assemblyRef, System.Security.Policy.Evidence @assemblySecurity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyRef, @assemblySecurity};
            var ___result = RMLoad_AssemblyName_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly Load(System.Byte[] @rawAssembly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rawAssembly};
            var ___result = RMLoad_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly Load(System.Byte[] @rawAssembly, System.Byte[] @rawSymbolStore)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rawAssembly, @rawSymbolStore};
            var ___result = RMLoad_ByteArray_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly Load(System.Byte[] @rawAssembly, System.Byte[] @rawSymbolStore, System.Security.Policy.Evidence @securityEvidence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rawAssembly, @rawSymbolStore, @securityEvidence};
            var ___result = RMLoad_ByteArray_ByteArray_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly Load(System.Byte[] @rawAssembly, System.Byte[] @rawSymbolStore, System.Security.SecurityContextSource @securityContextSource)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rawAssembly, @rawSymbolStore, @securityContextSource};
            var ___result = RMLoad_ByteArray_ByteArray_SecurityContextSource.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly ReflectionOnlyLoad(System.Byte[] @rawAssembly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rawAssembly};
            var ___result = RMReflectionOnlyLoad_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly ReflectionOnlyLoad(System.String @assemblyString)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyString};
            var ___result = RMReflectionOnlyLoad_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly ReflectionOnlyLoadFrom(System.String @assemblyFile)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile};
            var ___result = RMReflectionOnlyLoadFrom_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly LoadWithPartialName(System.String @partialName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@partialName};
            var ___result = RMLoadWithPartialName_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public virtual System.Reflection.Module LoadModule(System.String @moduleName, System.Byte[] @rawModule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@moduleName, @rawModule};
            var ___result = RMLoadModule_String_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module)___result;
        }


        public virtual System.Reflection.Module LoadModule(System.String @moduleName, System.Byte[] @rawModule, System.Byte[] @rawSymbolStore)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@moduleName, @rawModule, @rawSymbolStore};
            var ___result = RMLoadModule_String_ByteArray_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module)___result;
        }


        public static System.Reflection.Assembly load_with_partial_name(System.String @name, System.Security.Policy.Evidence @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @e};
            var ___result = RMload_with_partial_name_String_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly LoadWithPartialName(System.String @partialName, System.Security.Policy.Evidence @securityEvidence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@partialName, @securityEvidence};
            var ___result = RMLoadWithPartialName_String_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly LoadWithPartialName(System.String @partialName, System.Security.Policy.Evidence @securityEvidence, System.Boolean @oldBehavior)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@partialName, @securityEvidence, @oldBehavior};
            var ___result = RMLoadWithPartialName_String_Evidence_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public virtual System.Object CreateInstance(System.String @typeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName};
            var ___result = RMCreateInstance_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object CreateInstance(System.String @typeName, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName, @ignoreCase};
            var ___result = RMCreateInstance_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object CreateInstance(System.String @typeName, System.Boolean @ignoreCase, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Object[] @args, System.Globalization.CultureInfo @culture, System.Object[] @activationAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName, @ignoreCase, @bindingAttr, @binder, @args, @culture, @activationAttributes};
            var ___result = RMCreateInstance_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Reflection.Module[] GetLoadedModules()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetLoadedModules.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module[])___result;
        }


        public virtual System.Reflection.Module[] GetModules()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetModules.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module[])___result;
        }


        public virtual System.Reflection.Module[] GetModulesInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetModulesInternal.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module[])___result;
        }


        public static System.Reflection.Assembly GetExecutingAssembly()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetExecutingAssembly.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Reflection.Assembly GetCallingAssembly()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCallingAssembly.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.IntPtr InternalGetReferencedAssemblies(System.Reflection.Assembly @module)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module};
            var ___result = RMInternalGetReferencedAssemblies_Assembly.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual System.String[] GetManifestResourceNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetManifestResourceNames.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public static System.Reflection.AssemblyName[] GetReferencedAssemblies(System.Reflection.Assembly @module)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module};
            var ___result = RMGetReferencedAssemblies_Assembly.Invoke(___genericsType, ___parameters);

            return (System.Reflection.AssemblyName[])___result;
        }


        public virtual System.Reflection.ManifestResourceInfo GetManifestResourceInfo(System.String @resourceName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resourceName};
            var ___result = RMGetManifestResourceInfo_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ManifestResourceInfo)___result;
        }


        public virtual System.Reflection.Module GetManifestModule()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetManifestModule.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Exception CreateNIE()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateNIE.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCustomAttributesData.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
        }


        public virtual System.Type GetType(System.String @name, System.Boolean @throwOnError, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @throwOnError, @ignoreCase};
            var ___result = RMGetType_String_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Reflection.Module GetModule(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetModule_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module)___result;
        }


        public virtual System.Reflection.AssemblyName[] GetReferencedAssemblies()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetReferencedAssemblies.Invoke(___genericsType, ___parameters);

            return (System.Reflection.AssemblyName[])___result;
        }


        public virtual System.Reflection.Module[] GetModules(System.Boolean @getResourceModules)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@getResourceModules};
            var ___result = RMGetModules_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module[])___result;
        }


        public virtual System.Reflection.Module[] GetLoadedModules(System.Boolean @getResourceModules)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@getResourceModules};
            var ___result = RMGetLoadedModules_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module[])___result;
        }


        public virtual System.Reflection.Assembly GetSatelliteAssembly(System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@culture};
            var ___result = RMGetSatelliteAssembly_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public virtual System.Reflection.Assembly GetSatelliteAssembly(System.Globalization.CultureInfo @culture, System.Version @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@culture, @version};
            var ___result = RMGetSatelliteAssembly_CultureInfo_Version.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public static System.Boolean op_Equality(System.Reflection.Assembly @left, System.Reflection.Assembly @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Equality_Assembly_Assembly.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Reflection.Assembly @left, System.Reflection.Assembly @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Inequality_Assembly_Assembly.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Type[] GetForwardedTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetForwardedTypes.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
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

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
