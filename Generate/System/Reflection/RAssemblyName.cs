using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.AssemblyName
	/// </summary>
    public partial class RAssemblyName : RMember //
    {

		/// <summary>
		/// System.String name
		/// </summary>
		protected RField r_name;
		public virtual RField Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name");
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// System.String codebase
		/// </summary>
		protected RField r_codebase;
		public virtual RField Rcodebase
		{
			get
			{
				if(r_codebase == null)
				{
					r_codebase = new(this, "codebase");
					r_codebase.SetBelong(this.instance);
				}
				return r_codebase;
			}
		}

		/// <summary>
		/// System.Int32 major
		/// </summary>
		protected RField r_major;
		public virtual RField Rmajor
		{
			get
			{
				if(r_major == null)
				{
					r_major = new(this, "major");
					r_major.SetBelong(this.instance);
				}
				return r_major;
			}
		}

		/// <summary>
		/// System.Int32 minor
		/// </summary>
		protected RField r_minor;
		public virtual RField Rminor
		{
			get
			{
				if(r_minor == null)
				{
					r_minor = new(this, "minor");
					r_minor.SetBelong(this.instance);
				}
				return r_minor;
			}
		}

		/// <summary>
		/// System.Int32 build
		/// </summary>
		protected RField r_build;
		public virtual RField Rbuild
		{
			get
			{
				if(r_build == null)
				{
					r_build = new(this, "build");
					r_build.SetBelong(this.instance);
				}
				return r_build;
			}
		}

		/// <summary>
		/// System.Int32 revision
		/// </summary>
		protected RField r_revision;
		public virtual RField Rrevision
		{
			get
			{
				if(r_revision == null)
				{
					r_revision = new(this, "revision");
					r_revision.SetBelong(this.instance);
				}
				return r_revision;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo cultureinfo
		/// </summary>
		protected RSystem.RGlobalization.RCultureInfo r_cultureinfo;
		public virtual RSystem.RGlobalization.RCultureInfo Rcultureinfo
		{
			get
			{
				if(r_cultureinfo == null)
				{
					r_cultureinfo = new(this, "cultureinfo");
					r_cultureinfo.SetBelong(this.instance);
				}
				return r_cultureinfo;
			}
		}

		/// <summary>
		/// System.Reflection.AssemblyNameFlags flags
		/// </summary>
		protected RField r_flags;
		public virtual RField Rflags
		{
			get
			{
				if(r_flags == null)
				{
					r_flags = new(this, "flags");
					r_flags.SetBelong(this.instance);
				}
				return r_flags;
			}
		}

		/// <summary>
		/// System.Configuration.Assemblies.AssemblyHashAlgorithm hashalg
		/// </summary>
		protected RField r_hashalg;
		public virtual RField Rhashalg
		{
			get
			{
				if(r_hashalg == null)
				{
					r_hashalg = new(this, "hashalg");
					r_hashalg.SetBelong(this.instance);
				}
				return r_hashalg;
			}
		}

		/// <summary>
		/// System.Reflection.StrongNameKeyPair keypair
		/// </summary>
		protected RSystem.RReflection.RStrongNameKeyPair r_keypair;
		public virtual RSystem.RReflection.RStrongNameKeyPair Rkeypair
		{
			get
			{
				if(r_keypair == null)
				{
					r_keypair = new(this, "keypair");
					r_keypair.SetBelong(this.instance);
				}
				return r_keypair;
			}
		}

		/// <summary>
		/// System.Byte[] publicKey
		/// </summary>
		protected RFieldArray<RField> r_publicKey;
		public virtual RFieldArray<RField> RpublicKey
		{
			get
			{
				if(r_publicKey == null)
				{
					r_publicKey = new(this, "publicKey");
					r_publicKey.SetBelong(this.instance);
				}
				return r_publicKey;
			}
		}

		/// <summary>
		/// System.Byte[] keyToken
		/// </summary>
		protected RFieldArray<RField> r_keyToken;
		public virtual RFieldArray<RField> RkeyToken
		{
			get
			{
				if(r_keyToken == null)
				{
					r_keyToken = new(this, "keyToken");
					r_keyToken.SetBelong(this.instance);
				}
				return r_keyToken;
			}
		}

		/// <summary>
		/// System.Configuration.Assemblies.AssemblyVersionCompatibility versioncompat
		/// </summary>
		protected RField r_versioncompat;
		public virtual RField Rversioncompat
		{
			get
			{
				if(r_versioncompat == null)
				{
					r_versioncompat = new(this, "versioncompat");
					r_versioncompat.SetBelong(this.instance);
				}
				return r_versioncompat;
			}
		}

		/// <summary>
		/// System.Version version
		/// </summary>
		protected RSystem.RVersion r_version;
		public virtual RSystem.RVersion Rversion
		{
			get
			{
				if(r_version == null)
				{
					r_version = new(this, "version");
					r_version.SetBelong(this.instance);
				}
				return r_version;
			}
		}

		/// <summary>
		/// System.Reflection.ProcessorArchitecture processor_architecture
		/// </summary>
		protected RField r_processor_architecture;
		public virtual RField Rprocessor_architecture
		{
			get
			{
				if(r_processor_architecture == null)
				{
					r_processor_architecture = new(this, "processor_architecture");
					r_processor_architecture.SetBelong(this.instance);
				}
				return r_processor_architecture;
			}
		}

		/// <summary>
		/// System.Reflection.AssemblyContentType contentType
		/// </summary>
		protected RField r_contentType;
		public virtual RField RcontentType
		{
			get
			{
				if(r_contentType == null)
				{
					r_contentType = new(this, "contentType");
					r_contentType.SetBelong(this.instance);
				}
				return r_contentType;
			}
		}

		/// <summary>
		/// System.Reflection.ProcessorArchitecture ProcessorArchitecture
		/// </summary>
		protected RProperty r_ProcessorArchitecture;
		public virtual RProperty RProcessorArchitecture
		{
			get
			{
				if(r_ProcessorArchitecture == null)
				{
					r_ProcessorArchitecture = new(this, "ProcessorArchitecture", -1);
					r_ProcessorArchitecture.SetBelong(this.instance);
				}
				return r_ProcessorArchitecture;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected RProperty r_Name;
		public virtual RProperty RName
		{
			get
			{
				if(r_Name == null)
				{
					r_Name = new(this, "Name", -1);
					r_Name.SetBelong(this.instance);
				}
				return r_Name;
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
		/// System.Globalization.CultureInfo CultureInfo
		/// </summary>
		protected RSystem.RGlobalization.RCultureInfo r_CultureInfo;
		public virtual RSystem.RGlobalization.RCultureInfo RCultureInfo
		{
			get
			{
				if(r_CultureInfo == null)
				{
					r_CultureInfo = new(this, "CultureInfo", -1);
					r_CultureInfo.SetBelong(this.instance);
				}
				return r_CultureInfo;
			}
		}

		/// <summary>
		/// System.Reflection.AssemblyNameFlags Flags
		/// </summary>
		protected RProperty r_Flags;
		public virtual RProperty RFlags
		{
			get
			{
				if(r_Flags == null)
				{
					r_Flags = new(this, "Flags", -1);
					r_Flags.SetBelong(this.instance);
				}
				return r_Flags;
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
		/// System.Configuration.Assemblies.AssemblyHashAlgorithm HashAlgorithm
		/// </summary>
		protected RProperty r_HashAlgorithm;
		public virtual RProperty RHashAlgorithm
		{
			get
			{
				if(r_HashAlgorithm == null)
				{
					r_HashAlgorithm = new(this, "HashAlgorithm", -1);
					r_HashAlgorithm.SetBelong(this.instance);
				}
				return r_HashAlgorithm;
			}
		}

		/// <summary>
		/// System.Reflection.StrongNameKeyPair KeyPair
		/// </summary>
		protected RSystem.RReflection.RStrongNameKeyPair r_KeyPair;
		public virtual RSystem.RReflection.RStrongNameKeyPair RKeyPair
		{
			get
			{
				if(r_KeyPair == null)
				{
					r_KeyPair = new(this, "KeyPair", -1);
					r_KeyPair.SetBelong(this.instance);
				}
				return r_KeyPair;
			}
		}

		/// <summary>
		/// System.Version Version
		/// </summary>
		protected RSystem.RVersion r_Version;
		public virtual RSystem.RVersion RVersion
		{
			get
			{
				if(r_Version == null)
				{
					r_Version = new(this, "Version", -1);
					r_Version.SetBelong(this.instance);
				}
				return r_Version;
			}
		}

		/// <summary>
		/// System.Configuration.Assemblies.AssemblyVersionCompatibility VersionCompatibility
		/// </summary>
		protected RProperty r_VersionCompatibility;
		public virtual RProperty RVersionCompatibility
		{
			get
			{
				if(r_VersionCompatibility == null)
				{
					r_VersionCompatibility = new(this, "VersionCompatibility", -1);
					r_VersionCompatibility.SetBelong(this.instance);
				}
				return r_VersionCompatibility;
			}
		}

		/// <summary>
		/// Boolean IsPublicKeyValid
		/// </summary>
		protected RProperty r_IsPublicKeyValid;
		public virtual RProperty RIsPublicKeyValid
		{
			get
			{
				if(r_IsPublicKeyValid == null)
				{
					r_IsPublicKeyValid = new(this, "IsPublicKeyValid", -1);
					r_IsPublicKeyValid.SetBelong(this.instance);
				}
				return r_IsPublicKeyValid;
			}
		}

		/// <summary>
		/// System.String CultureName
		/// </summary>
		protected RProperty r_CultureName;
		public virtual RProperty RCultureName
		{
			get
			{
				if(r_CultureName == null)
				{
					r_CultureName = new(this, "CultureName", -1);
					r_CultureName.SetBelong(this.instance);
				}
				return r_CultureName;
			}
		}

		/// <summary>
		/// System.Reflection.AssemblyContentType ContentType
		/// </summary>
		protected RProperty r_ContentType;
		public virtual RProperty RContentType
		{
			get
			{
				if(r_ContentType == null)
				{
					r_ContentType = new(this, "ContentType", -1);
					r_ContentType.SetBelong(this.instance);
				}
				return r_ContentType;
			}
		}

		/// <summary>
		/// Boolean ParseAssemblyName(IntPtr, Mono.MonoAssemblyName ByRef, Boolean ByRef, Boolean ByRef)
		/// </summary>
		protected static RMethod r_ParseAssemblyName_IntPtr_Out_MonoAssemblyName_Out_Boolean_Out_Boolean;
		public static RMethod RParseAssemblyName_IntPtr_Out_MonoAssemblyName_Out_Boolean_Out_Boolean
		{
			get
			{
				if(r_ParseAssemblyName_IntPtr_Out_MonoAssemblyName_Out_Boolean_Out_Boolean == null)
				{
					r_ParseAssemblyName_IntPtr_Out_MonoAssemblyName_Out_Boolean_Out_Boolean = new(typeof(System.Reflection.AssemblyName), "ParseAssemblyName", 0, typeof(System.IntPtr),  ReleactionUtils.GetType("Mono.MonoAssemblyName").MakeByRefType(), typeof(System.Boolean).MakeByRefType(), typeof(System.Boolean).MakeByRefType());
					r_ParseAssemblyName_IntPtr_Out_MonoAssemblyName_Out_Boolean_Out_Boolean.SetBelong(null);
				}
				return r_ParseAssemblyName_IntPtr_Out_MonoAssemblyName_Out_Boolean_Out_Boolean;
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

		/// <summary>
		/// Byte[] GetPublicKey()
		/// </summary>
		protected RMethod r_GetPublicKey;
		public virtual RMethod RGetPublicKey
		{
			get
			{
				if(r_GetPublicKey == null)
				{
					r_GetPublicKey = new(this, "GetPublicKey", 0);
					r_GetPublicKey.SetBelong(this.instance);
				}
				return r_GetPublicKey;
			}
		}

		/// <summary>
		/// Byte[] GetPublicKeyToken()
		/// </summary>
		protected RMethod r_GetPublicKeyToken;
		public virtual RMethod RGetPublicKeyToken
		{
			get
			{
				if(r_GetPublicKeyToken == null)
				{
					r_GetPublicKeyToken = new(this, "GetPublicKeyToken", 0);
					r_GetPublicKeyToken.SetBelong(this.instance);
				}
				return r_GetPublicKeyToken;
			}
		}

		/// <summary>
		/// Byte[] InternalGetPublicKeyToken()
		/// </summary>
		protected RMethod r_InternalGetPublicKeyToken;
		public virtual RMethod RInternalGetPublicKeyToken
		{
			get
			{
				if(r_InternalGetPublicKeyToken == null)
				{
					r_InternalGetPublicKeyToken = new(this, "InternalGetPublicKeyToken", 0);
					r_InternalGetPublicKeyToken.SetBelong(this.instance);
				}
				return r_InternalGetPublicKeyToken;
			}
		}

		/// <summary>
		/// Void get_public_token(Byte*, Byte*, Int32)
		/// </summary>
		protected static RMethod r_get_public_token_BytePointer_BytePointer_Int32;
		public static RMethod Rget_public_token_BytePointer_BytePointer_Int32
		{
			get
			{
				if(r_get_public_token_BytePointer_BytePointer_Int32 == null)
				{
					r_get_public_token_BytePointer_BytePointer_Int32 = new(typeof(System.Reflection.AssemblyName), "get_public_token", 0, typeof(System.Byte).MakePointerType(), typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_get_public_token_BytePointer_BytePointer_Int32.SetBelong(null);
				}
				return r_get_public_token_BytePointer_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Byte[] ComputePublicKeyToken()
		/// </summary>
		protected RMethod r_ComputePublicKeyToken;
		public virtual RMethod RComputePublicKeyToken
		{
			get
			{
				if(r_ComputePublicKeyToken == null)
				{
					r_ComputePublicKeyToken = new(this, "ComputePublicKeyToken", 0);
					r_ComputePublicKeyToken.SetBelong(this.instance);
				}
				return r_ComputePublicKeyToken;
			}
		}

		/// <summary>
		/// Boolean ReferenceMatchesDefinition(System.Reflection.AssemblyName, System.Reflection.AssemblyName)
		/// </summary>
		protected static RMethod r_ReferenceMatchesDefinition_AssemblyName_AssemblyName;
		public static RMethod RReferenceMatchesDefinition_AssemblyName_AssemblyName
		{
			get
			{
				if(r_ReferenceMatchesDefinition_AssemblyName_AssemblyName == null)
				{
					r_ReferenceMatchesDefinition_AssemblyName_AssemblyName = new(typeof(System.Reflection.AssemblyName), "ReferenceMatchesDefinition", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.AssemblyName));
					r_ReferenceMatchesDefinition_AssemblyName_AssemblyName.SetBelong(null);
				}
				return r_ReferenceMatchesDefinition_AssemblyName_AssemblyName;
			}
		}

		/// <summary>
		/// Void SetPublicKey(Byte[])
		/// </summary>
		protected RMethod r_SetPublicKey_ByteArray;
		public virtual RMethod RSetPublicKey_ByteArray
		{
			get
			{
				if(r_SetPublicKey_ByteArray == null)
				{
					r_SetPublicKey_ByteArray = new(this, "SetPublicKey", 0, typeof(System.Byte).MakeArrayType());
					r_SetPublicKey_ByteArray.SetBelong(this.instance);
				}
				return r_SetPublicKey_ByteArray;
			}
		}

		/// <summary>
		/// Void SetPublicKeyToken(Byte[])
		/// </summary>
		protected RMethod r_SetPublicKeyToken_ByteArray;
		public virtual RMethod RSetPublicKeyToken_ByteArray
		{
			get
			{
				if(r_SetPublicKeyToken_ByteArray == null)
				{
					r_SetPublicKeyToken_ByteArray = new(this, "SetPublicKeyToken", 0, typeof(System.Byte).MakeArrayType());
					r_SetPublicKeyToken_ByteArray.SetBelong(this.instance);
				}
				return r_SetPublicKeyToken_ByteArray;
			}
		}

		/// <summary>
		/// Void GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_GetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RGetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_GetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_GetObjectData_SerializationInfo_StreamingContext = new(this, "GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_GetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_GetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// System.Object Clone()
		/// </summary>
		protected RMethod r_Clone;
		public virtual RMethod RClone
		{
			get
			{
				if(r_Clone == null)
				{
					r_Clone = new(this, "Clone", 0);
					r_Clone.SetBelong(this.instance);
				}
				return r_Clone;
			}
		}

		/// <summary>
		/// Void OnDeserialization(System.Object)
		/// </summary>
		protected RMethod r_OnDeserialization_Object;
		public virtual RMethod ROnDeserialization_Object
		{
			get
			{
				if(r_OnDeserialization_Object == null)
				{
					r_OnDeserialization_Object = new(this, "OnDeserialization", 0, typeof(System.Object));
					r_OnDeserialization_Object.SetBelong(this.instance);
				}
				return r_OnDeserialization_Object;
			}
		}

		/// <summary>
		/// System.Reflection.AssemblyName GetAssemblyName(System.String)
		/// </summary>
		protected static RMethod r_GetAssemblyName_String;
		public static RMethod RGetAssemblyName_String
		{
			get
			{
				if(r_GetAssemblyName_String == null)
				{
					r_GetAssemblyName_String = new(typeof(System.Reflection.AssemblyName), "GetAssemblyName", 0, typeof(System.String));
					r_GetAssemblyName_String.SetBelong(null);
				}
				return r_GetAssemblyName_String;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._AssemblyName.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___AssemblyName__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___AssemblyName__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_System__2__Runtime__2__InteropServices__2___AssemblyName__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._AssemblyName.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_System__2__Runtime__2__InteropServices__2___AssemblyName__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___AssemblyName__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._AssemblyName.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___AssemblyName__2__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___AssemblyName__2__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_System__2__Runtime__2__InteropServices__2___AssemblyName__2__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._AssemblyName.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_System__2__Runtime__2__InteropServices__2___AssemblyName__2__GetTypeInfo_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___AssemblyName__2__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._AssemblyName.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___AssemblyName__2__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___AssemblyName__2__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_System__2__Runtime__2__InteropServices__2___AssemblyName__2__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._AssemblyName.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
					r_System__2__Runtime__2__InteropServices__2___AssemblyName__2__GetTypeInfoCount_Out_UInt32.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___AssemblyName__2__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._AssemblyName.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___AssemblyName__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___AssemblyName__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_System__2__Runtime__2__InteropServices__2___AssemblyName__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._AssemblyName.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
					r_System__2__Runtime__2__InteropServices__2___AssemblyName__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___AssemblyName__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// Mono.MonoAssemblyName* GetNativeName(IntPtr)
		/// </summary>
		protected static RMethod r_GetNativeName_IntPtr;
		public static RMethod RGetNativeName_IntPtr
		{
			get
			{
				if(r_GetNativeName_IntPtr == null)
				{
					r_GetNativeName_IntPtr = new(typeof(System.Reflection.AssemblyName), "GetNativeName", 0, typeof(System.IntPtr));
					r_GetNativeName_IntPtr.SetBelong(null);
				}
				return r_GetNativeName_IntPtr;
			}
		}

		/// <summary>
		/// Void FillName(Mono.MonoAssemblyName*, System.String, Boolean, Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_FillName_MonoAssemblyNamePointer_String_Boolean_Boolean_Boolean_Boolean;
		public virtual RMethod RFillName_MonoAssemblyNamePointer_String_Boolean_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_FillName_MonoAssemblyNamePointer_String_Boolean_Boolean_Boolean_Boolean == null)
				{
					r_FillName_MonoAssemblyNamePointer_String_Boolean_Boolean_Boolean_Boolean = new(this, "FillName", 0,  ReleactionUtils.GetType("Mono.MonoAssemblyName").MakePointerType(), typeof(System.String), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_FillName_MonoAssemblyNamePointer_String_Boolean_Boolean_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_FillName_MonoAssemblyNamePointer_String_Boolean_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.AssemblyName Create(System.Reflection.Assembly, Boolean)
		/// </summary>
		protected static RMethod r_Create_Assembly_Boolean;
		public static RMethod RCreate_Assembly_Boolean
		{
			get
			{
				if(r_Create_Assembly_Boolean == null)
				{
					r_Create_Assembly_Boolean = new(typeof(System.Reflection.AssemblyName), "Create", 0, typeof(System.Reflection.Assembly), typeof(System.Boolean));
					r_Create_Assembly_Boolean.SetBelong(null);
				}
				return r_Create_Assembly_Boolean;
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


        public RAssemblyName() : base("System.Reflection.AssemblyName")
        {
        }

        public RAssemblyName(System.Object instance) : base("System.Reflection.AssemblyName")
		{
            SetInstance(instance);
		}

        public RAssemblyName(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAssemblyName(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Byte[] GetPublicKey()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPublicKey.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] GetPublicKeyToken()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPublicKeyToken.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] InternalGetPublicKeyToken()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalGetPublicKeyToken.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }



        public virtual System.Byte[] ComputePublicKeyToken()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RComputePublicKeyToken.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public static System.Boolean ReferenceMatchesDefinition(System.Reflection.AssemblyName  @reference, System.Reflection.AssemblyName  @definition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reference, @definition};
            var ___result = RReferenceMatchesDefinition_AssemblyName_AssemblyName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetPublicKey(System.Byte[]  @publicKey)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@publicKey};
            var ___result = RSetPublicKey_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPublicKeyToken(System.Byte[]  @publicKeyToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@publicKeyToken};
            var ___result = RSetPublicKeyToken_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo  @info, System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void OnDeserialization(System.Object  @sender)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender};
            var ___result = ROnDeserialization_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Reflection.AssemblyName GetAssemblyName(System.String  @assemblyFile)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile};
            var ___result = RGetAssemblyName_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.AssemblyName)___result;
        }


        public virtual void System__2__Runtime__2__InteropServices__2___AssemblyName__2__GetIDsOfNames(in System.Guid  @riid, System.IntPtr  @rgszNames, System.UInt32  @cNames, System.UInt32  @lcid, System.IntPtr  @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___AssemblyName__2__GetTypeInfo(System.UInt32  @iTInfo, System.UInt32  @lcid, System.IntPtr  @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___AssemblyName__2__GetTypeInfoCount(out System.UInt32  @pcTInfo)
        {
			pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___AssemblyName__2__Invoke(System.UInt32  @dispIdMember, in System.Guid  @riid, System.UInt32  @lcid, System.Int16  @wFlags, System.IntPtr  @pDispParams, System.IntPtr  @pVarResult, System.IntPtr  @pExcepInfo, System.IntPtr  @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }




        public static System.Reflection.AssemblyName Create(System.Reflection.Assembly  @assembly, System.Boolean  @fillCodebase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assembly, @fillCodebase};
            var ___result = RCreate_Assembly_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.AssemblyName)___result;
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


    }
}
