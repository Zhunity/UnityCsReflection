
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.AssemblyName
	/// </summary>
    public partial class RAssemblyName : RMember //
    {

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
					r_Fname.SetBelong(this.instance);
				}
				return r_Fname;
			}
		}

		/// <summary>
		/// System.String codebase
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fcodebase;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFcodebase
		{
			get
			{
				if(r_Fcodebase == null)
				{
					r_Fcodebase = new(this, "codebase");
					r_Fcodebase.SetBelong(this.instance);
				}
				return r_Fcodebase;
			}
		}

		/// <summary>
		/// System.Int32 major
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fmajor;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFmajor
		{
			get
			{
				if(r_Fmajor == null)
				{
					r_Fmajor = new(this, "major");
					r_Fmajor.SetBelong(this.instance);
				}
				return r_Fmajor;
			}
		}

		/// <summary>
		/// System.Int32 minor
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fminor;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFminor
		{
			get
			{
				if(r_Fminor == null)
				{
					r_Fminor = new(this, "minor");
					r_Fminor.SetBelong(this.instance);
				}
				return r_Fminor;
			}
		}

		/// <summary>
		/// System.Int32 build
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fbuild;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFbuild
		{
			get
			{
				if(r_Fbuild == null)
				{
					r_Fbuild = new(this, "build");
					r_Fbuild.SetBelong(this.instance);
				}
				return r_Fbuild;
			}
		}

		/// <summary>
		/// System.Int32 revision
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Frevision;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFrevision
		{
			get
			{
				if(r_Frevision == null)
				{
					r_Frevision = new(this, "revision");
					r_Frevision.SetBelong(this.instance);
				}
				return r_Frevision;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo cultureinfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo r_Fcultureinfo;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo RFcultureinfo
		{
			get
			{
				if(r_Fcultureinfo == null)
				{
					r_Fcultureinfo = new(this, "cultureinfo");
					r_Fcultureinfo.SetBelong(this.instance);
				}
				return r_Fcultureinfo;
			}
		}

		/// <summary>
		/// System.Reflection.AssemblyNameFlags flags
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RAssemblyNameFlags r_Fflags;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RAssemblyNameFlags RFflags
		{
			get
			{
				if(r_Fflags == null)
				{
					r_Fflags = new(this, "flags");
					r_Fflags.SetBelong(this.instance);
				}
				return r_Fflags;
			}
		}

		/// <summary>
		/// System.Configuration.Assemblies.AssemblyHashAlgorithm hashalg
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RConfiguration.RAssemblies.RAssemblyHashAlgorithm r_Fhashalg;
		public virtual Hvak.Editor.Refleaction.RSystem.RConfiguration.RAssemblies.RAssemblyHashAlgorithm RFhashalg
		{
			get
			{
				if(r_Fhashalg == null)
				{
					r_Fhashalg = new(this, "hashalg");
					r_Fhashalg.SetBelong(this.instance);
				}
				return r_Fhashalg;
			}
		}

		/// <summary>
		/// System.Reflection.StrongNameKeyPair keypair
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RStrongNameKeyPair r_Fkeypair;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RStrongNameKeyPair RFkeypair
		{
			get
			{
				if(r_Fkeypair == null)
				{
					r_Fkeypair = new(this, "keypair");
					r_Fkeypair.SetBelong(this.instance);
				}
				return r_Fkeypair;
			}
		}

		/// <summary>
		/// System.Byte[] publicKey
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> r_FpublicKey;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> RFpublicKey
		{
			get
			{
				if(r_FpublicKey == null)
				{
					r_FpublicKey = new(this, "publicKey");
					r_FpublicKey.SetBelong(this.instance);
				}
				return r_FpublicKey;
			}
		}

		/// <summary>
		/// System.Byte[] keyToken
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> r_FkeyToken;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> RFkeyToken
		{
			get
			{
				if(r_FkeyToken == null)
				{
					r_FkeyToken = new(this, "keyToken");
					r_FkeyToken.SetBelong(this.instance);
				}
				return r_FkeyToken;
			}
		}

		/// <summary>
		/// System.Configuration.Assemblies.AssemblyVersionCompatibility versioncompat
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RConfiguration.RAssemblies.RAssemblyVersionCompatibility r_Fversioncompat;
		public virtual Hvak.Editor.Refleaction.RSystem.RConfiguration.RAssemblies.RAssemblyVersionCompatibility RFversioncompat
		{
			get
			{
				if(r_Fversioncompat == null)
				{
					r_Fversioncompat = new(this, "versioncompat");
					r_Fversioncompat.SetBelong(this.instance);
				}
				return r_Fversioncompat;
			}
		}

		/// <summary>
		/// System.Version version
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RVersion r_Fversion;
		public virtual Hvak.Editor.Refleaction.RSystem.RVersion RFversion
		{
			get
			{
				if(r_Fversion == null)
				{
					r_Fversion = new(this, "version");
					r_Fversion.SetBelong(this.instance);
				}
				return r_Fversion;
			}
		}

		/// <summary>
		/// System.Reflection.ProcessorArchitecture processor_architecture
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RProcessorArchitecture r_Fprocessor_architecture;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RProcessorArchitecture RFprocessor_architecture
		{
			get
			{
				if(r_Fprocessor_architecture == null)
				{
					r_Fprocessor_architecture = new(this, "processor_architecture");
					r_Fprocessor_architecture.SetBelong(this.instance);
				}
				return r_Fprocessor_architecture;
			}
		}

		/// <summary>
		/// System.Reflection.AssemblyContentType contentType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RAssemblyContentType r_FcontentType;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RAssemblyContentType RFcontentType
		{
			get
			{
				if(r_FcontentType == null)
				{
					r_FcontentType = new(this, "contentType");
					r_FcontentType.SetBelong(this.instance);
				}
				return r_FcontentType;
			}
		}

		/// <summary>
		/// System.Reflection.ProcessorArchitecture ProcessorArchitecture
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RProcessorArchitecture r_PProcessorArchitecture;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RProcessorArchitecture RPProcessorArchitecture
		{
			get
			{
				if(r_PProcessorArchitecture == null)
				{
					r_PProcessorArchitecture = new(this, "ProcessorArchitecture", -1);
					r_PProcessorArchitecture.SetBelong(this.instance);
				}
				return r_PProcessorArchitecture;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPName
		{
			get
			{
				if(r_PName == null)
				{
					r_PName = new(this, "Name", -1);
					r_PName.SetBelong(this.instance);
				}
				return r_PName;
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
					r_PCodeBase.SetBelong(this.instance);
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
					r_PEscapedCodeBase.SetBelong(this.instance);
				}
				return r_PEscapedCodeBase;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo CultureInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo r_PCultureInfo;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo RPCultureInfo
		{
			get
			{
				if(r_PCultureInfo == null)
				{
					r_PCultureInfo = new(this, "CultureInfo", -1);
					r_PCultureInfo.SetBelong(this.instance);
				}
				return r_PCultureInfo;
			}
		}

		/// <summary>
		/// System.Reflection.AssemblyNameFlags Flags
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RAssemblyNameFlags r_PFlags;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RAssemblyNameFlags RPFlags
		{
			get
			{
				if(r_PFlags == null)
				{
					r_PFlags = new(this, "Flags", -1);
					r_PFlags.SetBelong(this.instance);
				}
				return r_PFlags;
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
					r_PFullName.SetBelong(this.instance);
				}
				return r_PFullName;
			}
		}

		/// <summary>
		/// System.Configuration.Assemblies.AssemblyHashAlgorithm HashAlgorithm
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RConfiguration.RAssemblies.RAssemblyHashAlgorithm r_PHashAlgorithm;
		public virtual Hvak.Editor.Refleaction.RSystem.RConfiguration.RAssemblies.RAssemblyHashAlgorithm RPHashAlgorithm
		{
			get
			{
				if(r_PHashAlgorithm == null)
				{
					r_PHashAlgorithm = new(this, "HashAlgorithm", -1);
					r_PHashAlgorithm.SetBelong(this.instance);
				}
				return r_PHashAlgorithm;
			}
		}

		/// <summary>
		/// System.Reflection.StrongNameKeyPair KeyPair
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RStrongNameKeyPair r_PKeyPair;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RStrongNameKeyPair RPKeyPair
		{
			get
			{
				if(r_PKeyPair == null)
				{
					r_PKeyPair = new(this, "KeyPair", -1);
					r_PKeyPair.SetBelong(this.instance);
				}
				return r_PKeyPair;
			}
		}

		/// <summary>
		/// System.Version Version
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RVersion r_PVersion;
		public virtual Hvak.Editor.Refleaction.RSystem.RVersion RPVersion
		{
			get
			{
				if(r_PVersion == null)
				{
					r_PVersion = new(this, "Version", -1);
					r_PVersion.SetBelong(this.instance);
				}
				return r_PVersion;
			}
		}

		/// <summary>
		/// System.Configuration.Assemblies.AssemblyVersionCompatibility VersionCompatibility
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RConfiguration.RAssemblies.RAssemblyVersionCompatibility r_PVersionCompatibility;
		public virtual Hvak.Editor.Refleaction.RSystem.RConfiguration.RAssemblies.RAssemblyVersionCompatibility RPVersionCompatibility
		{
			get
			{
				if(r_PVersionCompatibility == null)
				{
					r_PVersionCompatibility = new(this, "VersionCompatibility", -1);
					r_PVersionCompatibility.SetBelong(this.instance);
				}
				return r_PVersionCompatibility;
			}
		}

		/// <summary>
		/// Boolean IsPublicKeyValid
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsPublicKeyValid;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsPublicKeyValid
		{
			get
			{
				if(r_PIsPublicKeyValid == null)
				{
					r_PIsPublicKeyValid = new(this, "IsPublicKeyValid", -1);
					r_PIsPublicKeyValid.SetBelong(this.instance);
				}
				return r_PIsPublicKeyValid;
			}
		}

		/// <summary>
		/// System.String CultureName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PCultureName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPCultureName
		{
			get
			{
				if(r_PCultureName == null)
				{
					r_PCultureName = new(this, "CultureName", -1);
					r_PCultureName.SetBelong(this.instance);
				}
				return r_PCultureName;
			}
		}

		/// <summary>
		/// System.Reflection.AssemblyContentType ContentType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RAssemblyContentType r_PContentType;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RAssemblyContentType RPContentType
		{
			get
			{
				if(r_PContentType == null)
				{
					r_PContentType = new(this, "ContentType", -1);
					r_PContentType.SetBelong(this.instance);
				}
				return r_PContentType;
			}
		}

		/// <summary>
		/// Boolean ParseAssemblyName(IntPtr, Mono.MonoAssemblyName ByRef, Boolean ByRef, Boolean ByRef)
		/// </summary>
		protected static RMethod r_MParseAssemblyName_IntPtr_Out_MonoAssemblyName_Out_Boolean_Out_Boolean;
		public static RMethod RMParseAssemblyName_IntPtr_Out_MonoAssemblyName_Out_Boolean_Out_Boolean
		{
			get
			{
				if(r_MParseAssemblyName_IntPtr_Out_MonoAssemblyName_Out_Boolean_Out_Boolean == null)
				{
					r_MParseAssemblyName_IntPtr_Out_MonoAssemblyName_Out_Boolean_Out_Boolean = new(typeof(System.Reflection.AssemblyName), "ParseAssemblyName", 0, typeof(System.IntPtr),  ReflectionUtils.GetType("Mono.MonoAssemblyName").MakeByRefType(), typeof(System.Boolean).MakeByRefType(), typeof(System.Boolean).MakeByRefType());
					r_MParseAssemblyName_IntPtr_Out_MonoAssemblyName_Out_Boolean_Out_Boolean.SetBelong(null);
				}
				return r_MParseAssemblyName_IntPtr_Out_MonoAssemblyName_Out_Boolean_Out_Boolean;
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
					r_MToString.SetBelong(this.instance);
				}
				return r_MToString;
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
					r_MGetPublicKey.SetBelong(this.instance);
				}
				return r_MGetPublicKey;
			}
		}

		/// <summary>
		/// Byte[] GetPublicKeyToken()
		/// </summary>
		protected RMethod r_MGetPublicKeyToken;
		public virtual RMethod RMGetPublicKeyToken
		{
			get
			{
				if(r_MGetPublicKeyToken == null)
				{
					r_MGetPublicKeyToken = new(this, "GetPublicKeyToken", 0);
					r_MGetPublicKeyToken.SetBelong(this.instance);
				}
				return r_MGetPublicKeyToken;
			}
		}

		/// <summary>
		/// Byte[] InternalGetPublicKeyToken()
		/// </summary>
		protected RMethod r_MInternalGetPublicKeyToken;
		public virtual RMethod RMInternalGetPublicKeyToken
		{
			get
			{
				if(r_MInternalGetPublicKeyToken == null)
				{
					r_MInternalGetPublicKeyToken = new(this, "InternalGetPublicKeyToken", 0);
					r_MInternalGetPublicKeyToken.SetBelong(this.instance);
				}
				return r_MInternalGetPublicKeyToken;
			}
		}

		/// <summary>
		/// Void get_public_token(Byte*, Byte*, Int32)
		/// </summary>
		protected static RMethod r_Mget_public_token_BytePointer_BytePointer_Int32;
		public static RMethod RMget_public_token_BytePointer_BytePointer_Int32
		{
			get
			{
				if(r_Mget_public_token_BytePointer_BytePointer_Int32 == null)
				{
					r_Mget_public_token_BytePointer_BytePointer_Int32 = new(typeof(System.Reflection.AssemblyName), "get_public_token", 0, typeof(System.Byte).MakePointerType(), typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_Mget_public_token_BytePointer_BytePointer_Int32.SetBelong(null);
				}
				return r_Mget_public_token_BytePointer_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Byte[] ComputePublicKeyToken()
		/// </summary>
		protected RMethod r_MComputePublicKeyToken;
		public virtual RMethod RMComputePublicKeyToken
		{
			get
			{
				if(r_MComputePublicKeyToken == null)
				{
					r_MComputePublicKeyToken = new(this, "ComputePublicKeyToken", 0);
					r_MComputePublicKeyToken.SetBelong(this.instance);
				}
				return r_MComputePublicKeyToken;
			}
		}

		/// <summary>
		/// Boolean ReferenceMatchesDefinition(System.Reflection.AssemblyName, System.Reflection.AssemblyName)
		/// </summary>
		protected static RMethod r_MReferenceMatchesDefinition_AssemblyName_AssemblyName;
		public static RMethod RMReferenceMatchesDefinition_AssemblyName_AssemblyName
		{
			get
			{
				if(r_MReferenceMatchesDefinition_AssemblyName_AssemblyName == null)
				{
					r_MReferenceMatchesDefinition_AssemblyName_AssemblyName = new(typeof(System.Reflection.AssemblyName), "ReferenceMatchesDefinition", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.AssemblyName));
					r_MReferenceMatchesDefinition_AssemblyName_AssemblyName.SetBelong(null);
				}
				return r_MReferenceMatchesDefinition_AssemblyName_AssemblyName;
			}
		}

		/// <summary>
		/// Void SetPublicKey(Byte[])
		/// </summary>
		protected RMethod r_MSetPublicKey_ByteArray;
		public virtual RMethod RMSetPublicKey_ByteArray
		{
			get
			{
				if(r_MSetPublicKey_ByteArray == null)
				{
					r_MSetPublicKey_ByteArray = new(this, "SetPublicKey", 0, typeof(System.Byte).MakeArrayType());
					r_MSetPublicKey_ByteArray.SetBelong(this.instance);
				}
				return r_MSetPublicKey_ByteArray;
			}
		}

		/// <summary>
		/// Void SetPublicKeyToken(Byte[])
		/// </summary>
		protected RMethod r_MSetPublicKeyToken_ByteArray;
		public virtual RMethod RMSetPublicKeyToken_ByteArray
		{
			get
			{
				if(r_MSetPublicKeyToken_ByteArray == null)
				{
					r_MSetPublicKeyToken_ByteArray = new(this, "SetPublicKeyToken", 0, typeof(System.Byte).MakeArrayType());
					r_MSetPublicKeyToken_ByteArray.SetBelong(this.instance);
				}
				return r_MSetPublicKeyToken_ByteArray;
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
					r_MGetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_MGetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// System.Object Clone()
		/// </summary>
		protected RMethod r_MClone;
		public virtual RMethod RMClone
		{
			get
			{
				if(r_MClone == null)
				{
					r_MClone = new(this, "Clone", 0);
					r_MClone.SetBelong(this.instance);
				}
				return r_MClone;
			}
		}

		/// <summary>
		/// Void OnDeserialization(System.Object)
		/// </summary>
		protected RMethod r_MOnDeserialization_Object;
		public virtual RMethod RMOnDeserialization_Object
		{
			get
			{
				if(r_MOnDeserialization_Object == null)
				{
					r_MOnDeserialization_Object = new(this, "OnDeserialization", 0, typeof(System.Object));
					r_MOnDeserialization_Object.SetBelong(this.instance);
				}
				return r_MOnDeserialization_Object;
			}
		}

		/// <summary>
		/// System.Reflection.AssemblyName GetAssemblyName(System.String)
		/// </summary>
		protected static RMethod r_MGetAssemblyName_String;
		public static RMethod RMGetAssemblyName_String
		{
			get
			{
				if(r_MGetAssemblyName_String == null)
				{
					r_MGetAssemblyName_String = new(typeof(System.Reflection.AssemblyName), "GetAssemblyName", 0, typeof(System.String));
					r_MGetAssemblyName_String.SetBelong(null);
				}
				return r_MGetAssemblyName_String;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._AssemblyName.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._AssemblyName.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_MSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._AssemblyName.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._AssemblyName.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_MSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__GetTypeInfo_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._AssemblyName.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._AssemblyName.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
					r_MSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__GetTypeInfoCount_Out_UInt32.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._AssemblyName.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._AssemblyName.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
					r_MSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// Mono.MonoAssemblyName* GetNativeName(IntPtr)
		/// </summary>
		protected static RMethod r_MGetNativeName_IntPtr;
		public static RMethod RMGetNativeName_IntPtr
		{
			get
			{
				if(r_MGetNativeName_IntPtr == null)
				{
					r_MGetNativeName_IntPtr = new(typeof(System.Reflection.AssemblyName), "GetNativeName", 0, typeof(System.IntPtr));
					r_MGetNativeName_IntPtr.SetBelong(null);
				}
				return r_MGetNativeName_IntPtr;
			}
		}

		/// <summary>
		/// Void FillName(Mono.MonoAssemblyName*, System.String, Boolean, Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MFillName_MonoAssemblyNamePointer_String_Boolean_Boolean_Boolean_Boolean;
		public virtual RMethod RMFillName_MonoAssemblyNamePointer_String_Boolean_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_MFillName_MonoAssemblyNamePointer_String_Boolean_Boolean_Boolean_Boolean == null)
				{
					r_MFillName_MonoAssemblyNamePointer_String_Boolean_Boolean_Boolean_Boolean = new(this, "FillName", 0,  ReflectionUtils.GetType("Mono.MonoAssemblyName").MakePointerType(), typeof(System.String), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_MFillName_MonoAssemblyNamePointer_String_Boolean_Boolean_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_MFillName_MonoAssemblyNamePointer_String_Boolean_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.AssemblyName Create(System.Reflection.Assembly, Boolean)
		/// </summary>
		protected static RMethod r_MCreate_Assembly_Boolean;
		public static RMethod RMCreate_Assembly_Boolean
		{
			get
			{
				if(r_MCreate_Assembly_Boolean == null)
				{
					r_MCreate_Assembly_Boolean = new(typeof(System.Reflection.AssemblyName), "Create", 0, typeof(System.Reflection.Assembly), typeof(System.Boolean));
					r_MCreate_Assembly_Boolean.SetBelong(null);
				}
				return r_MCreate_Assembly_Boolean;
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
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

        public static System.Boolean ParseAssemblyName(System.IntPtr @name, out Hvak.Editor.Refleaction.RMono.RMonoAssemblyName @aname, out System.Boolean @is_version_definited, out System.Boolean @is_token_defined)
        {
			@aname = default;
			@is_version_definited = default;
			@is_token_defined = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @aname.Value, @is_version_definited, @is_token_defined};
            var ___result = RMParseAssemblyName_IntPtr_Out_MonoAssemblyName_Out_Boolean_Out_Boolean.Invoke(___genericsType, ___parameters);
			@aname = new Hvak.Editor.Refleaction.RMono.RMonoAssemblyName(___parameters[1]);
			@is_version_definited = (System.Boolean)___parameters[2];
			@is_token_defined = (System.Boolean)___parameters[3];

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Byte[] GetPublicKey()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPublicKey.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] GetPublicKeyToken()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPublicKeyToken.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] InternalGetPublicKeyToken()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternalGetPublicKeyToken.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public unsafe static void get_public_token(System.Byte* @token, System.Byte* @pubkey, System.Int32 @len)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@token, typeof(System.Byte)), Pointer.Box(@pubkey, typeof(System.Byte)), @len};
            var ___result = RMget_public_token_BytePointer_BytePointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Byte[] ComputePublicKeyToken()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMComputePublicKeyToken.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public static System.Boolean ReferenceMatchesDefinition(System.Reflection.AssemblyName @reference, System.Reflection.AssemblyName @definition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reference, @definition};
            var ___result = RMReferenceMatchesDefinition_AssemblyName_AssemblyName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetPublicKey(System.Byte[] @publicKey)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@publicKey};
            var ___result = RMSetPublicKey_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPublicKeyToken(System.Byte[] @publicKeyToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@publicKeyToken};
            var ___result = RMSetPublicKeyToken_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void OnDeserialization(System.Object @sender)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender};
            var ___result = RMOnDeserialization_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Reflection.AssemblyName GetAssemblyName(System.String @assemblyFile)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile};
            var ___result = RMGetAssemblyName_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.AssemblyName)___result;
        }


        public virtual void System__2__Runtime__2__InteropServices__2___AssemblyName__2__GetIDsOfNames(in System.Guid @riid, System.IntPtr @rgszNames, System.UInt32 @cNames, System.UInt32 @lcid, System.IntPtr @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___AssemblyName__2__GetTypeInfo(System.UInt32 @iTInfo, System.UInt32 @lcid, System.IntPtr @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___AssemblyName__2__GetTypeInfoCount(out System.UInt32 @pcTInfo)
        {
			@pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			@pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___AssemblyName__2__Invoke(System.UInt32 @dispIdMember, in System.Guid @riid, System.UInt32 @lcid, System.Int16 @wFlags, System.IntPtr @pDispParams, System.IntPtr @pVarResult, System.IntPtr @pExcepInfo, System.IntPtr @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___AssemblyName__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe static Hvak.Editor.Refleaction.RTypePointer<Hvak.Editor.Refleaction.RMono.RMonoAssemblyName> GetNativeName(System.IntPtr @assembly_ptr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assembly_ptr};
            var ___result = RMGetNativeName_IntPtr.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RTypePointer<Hvak.Editor.Refleaction.RMono.RMonoAssemblyName>(___result);
        }


        public unsafe virtual void FillName(Hvak.Editor.Refleaction.RTypePointer<Hvak.Editor.Refleaction.RMono.RMonoAssemblyName> @native, System.String @codeBase, System.Boolean @addVersion, System.Boolean @addPublickey, System.Boolean @defaultToken, System.Boolean @assemblyRef)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@native.Value, @codeBase, @addVersion, @addPublickey, @defaultToken, @assemblyRef};
            var ___result = RMFillName_MonoAssemblyNamePointer_String_Boolean_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Reflection.AssemblyName Create(System.Reflection.Assembly @assembly, System.Boolean @fillCodebase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assembly, @fillCodebase};
            var ___result = RMCreate_Assembly_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.AssemblyName)___result;
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


    }
}
