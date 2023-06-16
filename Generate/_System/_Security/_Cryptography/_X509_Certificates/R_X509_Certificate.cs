
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RX509Certificates
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Security.Cryptography.X509Certificates.X509Certificate
	/// </summary>
    public partial class RX509Certificate : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Security.Cryptography.X509Certificates.X509Certificate);
            }
        }

        public RX509Certificate() : base("System.Security.Cryptography.X509Certificates.X509Certificate")
        {
        }

        public RX509Certificate(System.Object instance) : base("System.Security.Cryptography.X509Certificates.X509Certificate")
		{
            SetInstance(instance);
		}

        public RX509Certificate(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RX509Certificate(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Security.Cryptography.X509Certificates.X509CertificateImpl impl
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RX509Certificates.RX509CertificateImpl r_Fimpl;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RX509Certificates.RX509CertificateImpl RFimpl
		{
			get
			{
				if(r_Fimpl == null)
				{
					r_Fimpl = new(this, "impl");
				}
				return r_Fimpl;
			}
		}

		/// <summary>
		/// System.Byte[] lazyCertHash
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> r_FlazyCertHash;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> RFlazyCertHash
		{
			get
			{
				if(r_FlazyCertHash == null)
				{
					r_FlazyCertHash = new(this, "lazyCertHash");
				}
				return r_FlazyCertHash;
			}
		}

		/// <summary>
		/// System.Byte[] lazySerialNumber
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> r_FlazySerialNumber;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> RFlazySerialNumber
		{
			get
			{
				if(r_FlazySerialNumber == null)
				{
					r_FlazySerialNumber = new(this, "lazySerialNumber");
				}
				return r_FlazySerialNumber;
			}
		}

		/// <summary>
		/// System.String lazyIssuer
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FlazyIssuer;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFlazyIssuer
		{
			get
			{
				if(r_FlazyIssuer == null)
				{
					r_FlazyIssuer = new(this, "lazyIssuer");
				}
				return r_FlazyIssuer;
			}
		}

		/// <summary>
		/// System.String lazySubject
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FlazySubject;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFlazySubject
		{
			get
			{
				if(r_FlazySubject == null)
				{
					r_FlazySubject = new(this, "lazySubject");
				}
				return r_FlazySubject;
			}
		}

		/// <summary>
		/// System.String lazyKeyAlgorithm
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FlazyKeyAlgorithm;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFlazyKeyAlgorithm
		{
			get
			{
				if(r_FlazyKeyAlgorithm == null)
				{
					r_FlazyKeyAlgorithm = new(this, "lazyKeyAlgorithm");
				}
				return r_FlazyKeyAlgorithm;
			}
		}

		/// <summary>
		/// System.Byte[] lazyKeyAlgorithmParameters
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> r_FlazyKeyAlgorithmParameters;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> RFlazyKeyAlgorithmParameters
		{
			get
			{
				if(r_FlazyKeyAlgorithmParameters == null)
				{
					r_FlazyKeyAlgorithmParameters = new(this, "lazyKeyAlgorithmParameters");
				}
				return r_FlazyKeyAlgorithmParameters;
			}
		}

		/// <summary>
		/// System.Byte[] lazyPublicKey
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> r_FlazyPublicKey;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> RFlazyPublicKey
		{
			get
			{
				if(r_FlazyPublicKey == null)
				{
					r_FlazyPublicKey = new(this, "lazyPublicKey");
				}
				return r_FlazyPublicKey;
			}
		}

		/// <summary>
		/// System.DateTime lazyNotBefore
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RDateTime r_FlazyNotBefore;
		public virtual Hvak.Editor.Refleaction.RSystem.RDateTime RFlazyNotBefore
		{
			get
			{
				if(r_FlazyNotBefore == null)
				{
					r_FlazyNotBefore = new(this, "lazyNotBefore");
				}
				return r_FlazyNotBefore;
			}
		}

		/// <summary>
		/// System.DateTime lazyNotAfter
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RDateTime r_FlazyNotAfter;
		public virtual Hvak.Editor.Refleaction.RSystem.RDateTime RFlazyNotAfter
		{
			get
			{
				if(r_FlazyNotAfter == null)
				{
					r_FlazyNotAfter = new(this, "lazyNotAfter");
				}
				return r_FlazyNotAfter;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.X509Certificates.X509KeyStorageFlags KeyStorageFlagsAll
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RX509Certificates.RX509KeyStorageFlags r_FKeyStorageFlagsAll;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RX509Certificates.RX509KeyStorageFlags RFKeyStorageFlagsAll
		{
			get
			{
				if(r_FKeyStorageFlagsAll == null)
				{
					r_FKeyStorageFlagsAll = new(Type, "KeyStorageFlagsAll");
				}
				return r_FKeyStorageFlagsAll;
			}
		}

		/// <summary>
		/// IntPtr Handle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_PHandle;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RPHandle
		{
			get
			{
				if(r_PHandle == null)
				{
					r_PHandle = new(this, "Handle", -1);
				}
				return r_PHandle;
			}
		}

		/// <summary>
		/// System.String Issuer
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PIssuer;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPIssuer
		{
			get
			{
				if(r_PIssuer == null)
				{
					r_PIssuer = new(this, "Issuer", -1);
				}
				return r_PIssuer;
			}
		}

		/// <summary>
		/// System.String Subject
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PSubject;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPSubject
		{
			get
			{
				if(r_PSubject == null)
				{
					r_PSubject = new(this, "Subject", -1);
				}
				return r_PSubject;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.X509Certificates.X509CertificateImpl Impl
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RX509Certificates.RX509CertificateImpl r_PImpl;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RX509Certificates.RX509CertificateImpl RPImpl
		{
			get
			{
				if(r_PImpl == null)
				{
					r_PImpl = new(this, "Impl", -1);
				}
				return r_PImpl;
			}
		}

		/// <summary>
		/// Boolean IsValid
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsValid;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsValid
		{
			get
			{
				if(r_PIsValid == null)
				{
					r_PIsValid = new(this, "IsValid", -1);
				}
				return r_PIsValid;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_MReset;
		public virtual RMethod RMReset
		{
			get
			{
				if(r_MReset == null)
				{
					r_MReset = new(this, "Reset", 0);
				}
				return r_MReset;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.X509Certificates.X509Certificate CreateFromCertFile(System.String)
		/// </summary>
		protected static RMethod r_MCreateFromCertFile_String;
		public static RMethod RMCreateFromCertFile_String
		{
			get
			{
				if(r_MCreateFromCertFile_String == null)
				{
					r_MCreateFromCertFile_String = new(Type, "CreateFromCertFile", 0, typeof(System.String));
				}
				return r_MCreateFromCertFile_String;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.X509Certificates.X509Certificate CreateFromSignedFile(System.String)
		/// </summary>
		protected static RMethod r_MCreateFromSignedFile_String;
		public static RMethod RMCreateFromSignedFile_String
		{
			get
			{
				if(r_MCreateFromSignedFile_String == null)
				{
					r_MCreateFromSignedFile_String = new(Type, "CreateFromSignedFile", 0, typeof(System.String));
				}
				return r_MCreateFromSignedFile_String;
			}
		}

		/// <summary>
		/// Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RMSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext = new(this, "System.Runtime.Serialization.ISerializable.GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
				}
				return r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// Void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(System.Object)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object;
		public virtual RMethod RMSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object
		{
			get
			{
				if(r_MSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object == null)
				{
					r_MSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object = new(this, "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", 0, typeof(System.Object));
				}
				return r_MSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_MDispose;
		public virtual RMethod RMDispose
		{
			get
			{
				if(r_MDispose == null)
				{
					r_MDispose = new(this, "Dispose", 0);
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_MDispose_Boolean;
		public virtual RMethod RMDispose_Boolean
		{
			get
			{
				if(r_MDispose_Boolean == null)
				{
					r_MDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
				}
				return r_MDispose_Boolean;
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
		/// Boolean Equals(System.Security.Cryptography.X509Certificates.X509Certificate)
		/// </summary>
		protected RMethod r_MEquals_X509Certificate;
		public virtual RMethod RMEquals_X509Certificate
		{
			get
			{
				if(r_MEquals_X509Certificate == null)
				{
					r_MEquals_X509Certificate = new(this, "Equals", 0, typeof(System.Security.Cryptography.X509Certificates.X509Certificate));
				}
				return r_MEquals_X509Certificate;
			}
		}

		/// <summary>
		/// Byte[] Export(System.Security.Cryptography.X509Certificates.X509ContentType)
		/// </summary>
		protected RMethod r_MExport_X509ContentType;
		public virtual RMethod RMExport_X509ContentType
		{
			get
			{
				if(r_MExport_X509ContentType == null)
				{
					r_MExport_X509ContentType = new(this, "Export", 0, typeof(System.Security.Cryptography.X509Certificates.X509ContentType));
				}
				return r_MExport_X509ContentType;
			}
		}

		/// <summary>
		/// Byte[] Export(System.Security.Cryptography.X509Certificates.X509ContentType, System.String)
		/// </summary>
		protected RMethod r_MExport_X509ContentType_String;
		public virtual RMethod RMExport_X509ContentType_String
		{
			get
			{
				if(r_MExport_X509ContentType_String == null)
				{
					r_MExport_X509ContentType_String = new(this, "Export", 0, typeof(System.Security.Cryptography.X509Certificates.X509ContentType), typeof(System.String));
				}
				return r_MExport_X509ContentType_String;
			}
		}

		/// <summary>
		/// Byte[] Export(System.Security.Cryptography.X509Certificates.X509ContentType, System.Security.SecureString)
		/// </summary>
		protected RMethod r_MExport_X509ContentType_SecureString;
		public virtual RMethod RMExport_X509ContentType_SecureString
		{
			get
			{
				if(r_MExport_X509ContentType_SecureString == null)
				{
					r_MExport_X509ContentType_SecureString = new(this, "Export", 0, typeof(System.Security.Cryptography.X509Certificates.X509ContentType), typeof(System.Security.SecureString));
				}
				return r_MExport_X509ContentType_SecureString;
			}
		}

		/// <summary>
		/// System.String GetRawCertDataString()
		/// </summary>
		protected RMethod r_MGetRawCertDataString;
		public virtual RMethod RMGetRawCertDataString
		{
			get
			{
				if(r_MGetRawCertDataString == null)
				{
					r_MGetRawCertDataString = new(this, "GetRawCertDataString", 0);
				}
				return r_MGetRawCertDataString;
			}
		}

		/// <summary>
		/// Byte[] GetCertHash()
		/// </summary>
		protected RMethod r_MGetCertHash;
		public virtual RMethod RMGetCertHash
		{
			get
			{
				if(r_MGetCertHash == null)
				{
					r_MGetCertHash = new(this, "GetCertHash", 0);
				}
				return r_MGetCertHash;
			}
		}

		/// <summary>
		/// Byte[] GetCertHash(System.Security.Cryptography.HashAlgorithmName)
		/// </summary>
		protected RMethod r_MGetCertHash_HashAlgorithmName;
		public virtual RMethod RMGetCertHash_HashAlgorithmName
		{
			get
			{
				if(r_MGetCertHash_HashAlgorithmName == null)
				{
					r_MGetCertHash_HashAlgorithmName = new(this, "GetCertHash", 0, typeof(System.Security.Cryptography.HashAlgorithmName));
				}
				return r_MGetCertHash_HashAlgorithmName;
			}
		}

		/// <summary>
		/// Boolean TryGetCertHash(System.Security.Cryptography.HashAlgorithmName, System.Span`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_MTryGetCertHash_HashAlgorithmName_Span_d_Byte_p__Out_Int32;
		public virtual RMethod RMTryGetCertHash_HashAlgorithmName_Span_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_MTryGetCertHash_HashAlgorithmName_Span_d_Byte_p__Out_Int32 == null)
				{
					r_MTryGetCertHash_HashAlgorithmName_Span_d_Byte_p__Out_Int32 = new(this, "TryGetCertHash", 0, typeof(System.Security.Cryptography.HashAlgorithmName),  ReflectionUtils.GetType("System.Span`1").MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
				}
				return r_MTryGetCertHash_HashAlgorithmName_Span_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// System.String GetCertHashString()
		/// </summary>
		protected RMethod r_MGetCertHashString;
		public virtual RMethod RMGetCertHashString
		{
			get
			{
				if(r_MGetCertHashString == null)
				{
					r_MGetCertHashString = new(this, "GetCertHashString", 0);
				}
				return r_MGetCertHashString;
			}
		}

		/// <summary>
		/// System.String GetCertHashString(System.Security.Cryptography.HashAlgorithmName)
		/// </summary>
		protected RMethod r_MGetCertHashString_HashAlgorithmName;
		public virtual RMethod RMGetCertHashString_HashAlgorithmName
		{
			get
			{
				if(r_MGetCertHashString_HashAlgorithmName == null)
				{
					r_MGetCertHashString_HashAlgorithmName = new(this, "GetCertHashString", 0, typeof(System.Security.Cryptography.HashAlgorithmName));
				}
				return r_MGetCertHashString_HashAlgorithmName;
			}
		}

		/// <summary>
		/// Byte[] GetRawCertHash()
		/// </summary>
		protected RMethod r_MGetRawCertHash;
		public virtual RMethod RMGetRawCertHash
		{
			get
			{
				if(r_MGetRawCertHash == null)
				{
					r_MGetRawCertHash = new(this, "GetRawCertHash", 0);
				}
				return r_MGetRawCertHash;
			}
		}

		/// <summary>
		/// System.String GetEffectiveDateString()
		/// </summary>
		protected RMethod r_MGetEffectiveDateString;
		public virtual RMethod RMGetEffectiveDateString
		{
			get
			{
				if(r_MGetEffectiveDateString == null)
				{
					r_MGetEffectiveDateString = new(this, "GetEffectiveDateString", 0);
				}
				return r_MGetEffectiveDateString;
			}
		}

		/// <summary>
		/// System.String GetExpirationDateString()
		/// </summary>
		protected RMethod r_MGetExpirationDateString;
		public virtual RMethod RMGetExpirationDateString
		{
			get
			{
				if(r_MGetExpirationDateString == null)
				{
					r_MGetExpirationDateString = new(this, "GetExpirationDateString", 0);
				}
				return r_MGetExpirationDateString;
			}
		}

		/// <summary>
		/// System.String GetFormat()
		/// </summary>
		protected RMethod r_MGetFormat;
		public virtual RMethod RMGetFormat
		{
			get
			{
				if(r_MGetFormat == null)
				{
					r_MGetFormat = new(this, "GetFormat", 0);
				}
				return r_MGetFormat;
			}
		}

		/// <summary>
		/// System.String GetPublicKeyString()
		/// </summary>
		protected RMethod r_MGetPublicKeyString;
		public virtual RMethod RMGetPublicKeyString
		{
			get
			{
				if(r_MGetPublicKeyString == null)
				{
					r_MGetPublicKeyString = new(this, "GetPublicKeyString", 0);
				}
				return r_MGetPublicKeyString;
			}
		}

		/// <summary>
		/// Byte[] GetRawCertData()
		/// </summary>
		protected RMethod r_MGetRawCertData;
		public virtual RMethod RMGetRawCertData
		{
			get
			{
				if(r_MGetRawCertData == null)
				{
					r_MGetRawCertData = new(this, "GetRawCertData", 0);
				}
				return r_MGetRawCertData;
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
		/// System.String GetKeyAlgorithm()
		/// </summary>
		protected RMethod r_MGetKeyAlgorithm;
		public virtual RMethod RMGetKeyAlgorithm
		{
			get
			{
				if(r_MGetKeyAlgorithm == null)
				{
					r_MGetKeyAlgorithm = new(this, "GetKeyAlgorithm", 0);
				}
				return r_MGetKeyAlgorithm;
			}
		}

		/// <summary>
		/// Byte[] GetKeyAlgorithmParameters()
		/// </summary>
		protected RMethod r_MGetKeyAlgorithmParameters;
		public virtual RMethod RMGetKeyAlgorithmParameters
		{
			get
			{
				if(r_MGetKeyAlgorithmParameters == null)
				{
					r_MGetKeyAlgorithmParameters = new(this, "GetKeyAlgorithmParameters", 0);
				}
				return r_MGetKeyAlgorithmParameters;
			}
		}

		/// <summary>
		/// System.String GetKeyAlgorithmParametersString()
		/// </summary>
		protected RMethod r_MGetKeyAlgorithmParametersString;
		public virtual RMethod RMGetKeyAlgorithmParametersString
		{
			get
			{
				if(r_MGetKeyAlgorithmParametersString == null)
				{
					r_MGetKeyAlgorithmParametersString = new(this, "GetKeyAlgorithmParametersString", 0);
				}
				return r_MGetKeyAlgorithmParametersString;
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
		/// Byte[] GetSerialNumber()
		/// </summary>
		protected RMethod r_MGetSerialNumber;
		public virtual RMethod RMGetSerialNumber
		{
			get
			{
				if(r_MGetSerialNumber == null)
				{
					r_MGetSerialNumber = new(this, "GetSerialNumber", 0);
				}
				return r_MGetSerialNumber;
			}
		}

		/// <summary>
		/// System.String GetSerialNumberString()
		/// </summary>
		protected RMethod r_MGetSerialNumberString;
		public virtual RMethod RMGetSerialNumberString
		{
			get
			{
				if(r_MGetSerialNumberString == null)
				{
					r_MGetSerialNumberString = new(this, "GetSerialNumberString", 0);
				}
				return r_MGetSerialNumberString;
			}
		}

		/// <summary>
		/// Byte[] GetRawSerialNumber()
		/// </summary>
		protected RMethod r_MGetRawSerialNumber;
		public virtual RMethod RMGetRawSerialNumber
		{
			get
			{
				if(r_MGetRawSerialNumber == null)
				{
					r_MGetRawSerialNumber = new(this, "GetRawSerialNumber", 0);
				}
				return r_MGetRawSerialNumber;
			}
		}

		/// <summary>
		/// System.String GetName()
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
		/// System.String GetIssuerName()
		/// </summary>
		protected RMethod r_MGetIssuerName;
		public virtual RMethod RMGetIssuerName
		{
			get
			{
				if(r_MGetIssuerName == null)
				{
					r_MGetIssuerName = new(this, "GetIssuerName", 0);
				}
				return r_MGetIssuerName;
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
		/// System.String ToString(Boolean)
		/// </summary>
		protected RMethod r_MToString_Boolean;
		public virtual RMethod RMToString_Boolean
		{
			get
			{
				if(r_MToString_Boolean == null)
				{
					r_MToString_Boolean = new(this, "ToString", 0, typeof(System.Boolean));
				}
				return r_MToString_Boolean;
			}
		}

		/// <summary>
		/// Void Import(Byte[])
		/// </summary>
		protected RMethod r_MImport_ByteArray;
		public virtual RMethod RMImport_ByteArray
		{
			get
			{
				if(r_MImport_ByteArray == null)
				{
					r_MImport_ByteArray = new(this, "Import", 0, typeof(System.Byte).MakeArrayType());
				}
				return r_MImport_ByteArray;
			}
		}

		/// <summary>
		/// Void Import(Byte[], System.String, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags)
		/// </summary>
		protected RMethod r_MImport_ByteArray_String_X509KeyStorageFlags;
		public virtual RMethod RMImport_ByteArray_String_X509KeyStorageFlags
		{
			get
			{
				if(r_MImport_ByteArray_String_X509KeyStorageFlags == null)
				{
					r_MImport_ByteArray_String_X509KeyStorageFlags = new(this, "Import", 0, typeof(System.Byte).MakeArrayType(), typeof(System.String), typeof(System.Security.Cryptography.X509Certificates.X509KeyStorageFlags));
				}
				return r_MImport_ByteArray_String_X509KeyStorageFlags;
			}
		}

		/// <summary>
		/// Void Import(Byte[], System.Security.SecureString, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags)
		/// </summary>
		protected RMethod r_MImport_ByteArray_SecureString_X509KeyStorageFlags;
		public virtual RMethod RMImport_ByteArray_SecureString_X509KeyStorageFlags
		{
			get
			{
				if(r_MImport_ByteArray_SecureString_X509KeyStorageFlags == null)
				{
					r_MImport_ByteArray_SecureString_X509KeyStorageFlags = new(this, "Import", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Security.SecureString), typeof(System.Security.Cryptography.X509Certificates.X509KeyStorageFlags));
				}
				return r_MImport_ByteArray_SecureString_X509KeyStorageFlags;
			}
		}

		/// <summary>
		/// Void Import(System.String)
		/// </summary>
		protected RMethod r_MImport_String;
		public virtual RMethod RMImport_String
		{
			get
			{
				if(r_MImport_String == null)
				{
					r_MImport_String = new(this, "Import", 0, typeof(System.String));
				}
				return r_MImport_String;
			}
		}

		/// <summary>
		/// Void Import(System.String, System.String, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags)
		/// </summary>
		protected RMethod r_MImport_String_String_X509KeyStorageFlags;
		public virtual RMethod RMImport_String_String_X509KeyStorageFlags
		{
			get
			{
				if(r_MImport_String_String_X509KeyStorageFlags == null)
				{
					r_MImport_String_String_X509KeyStorageFlags = new(this, "Import", 0, typeof(System.String), typeof(System.String), typeof(System.Security.Cryptography.X509Certificates.X509KeyStorageFlags));
				}
				return r_MImport_String_String_X509KeyStorageFlags;
			}
		}

		/// <summary>
		/// Void Import(System.String, System.Security.SecureString, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags)
		/// </summary>
		protected RMethod r_MImport_String_SecureString_X509KeyStorageFlags;
		public virtual RMethod RMImport_String_SecureString_X509KeyStorageFlags
		{
			get
			{
				if(r_MImport_String_SecureString_X509KeyStorageFlags == null)
				{
					r_MImport_String_SecureString_X509KeyStorageFlags = new(this, "Import", 0, typeof(System.String), typeof(System.Security.SecureString), typeof(System.Security.Cryptography.X509Certificates.X509KeyStorageFlags));
				}
				return r_MImport_String_SecureString_X509KeyStorageFlags;
			}
		}

		/// <summary>
		/// System.DateTime GetNotAfter()
		/// </summary>
		protected RMethod r_MGetNotAfter;
		public virtual RMethod RMGetNotAfter
		{
			get
			{
				if(r_MGetNotAfter == null)
				{
					r_MGetNotAfter = new(this, "GetNotAfter", 0);
				}
				return r_MGetNotAfter;
			}
		}

		/// <summary>
		/// System.DateTime GetNotBefore()
		/// </summary>
		protected RMethod r_MGetNotBefore;
		public virtual RMethod RMGetNotBefore
		{
			get
			{
				if(r_MGetNotBefore == null)
				{
					r_MGetNotBefore = new(this, "GetNotBefore", 0);
				}
				return r_MGetNotBefore;
			}
		}

		/// <summary>
		/// System.String FormatDate(System.DateTime)
		/// </summary>
		protected static RMethod r_MFormatDate_DateTime;
		public static RMethod RMFormatDate_DateTime
		{
			get
			{
				if(r_MFormatDate_DateTime == null)
				{
					r_MFormatDate_DateTime = new(Type, "FormatDate", 0, typeof(System.DateTime));
				}
				return r_MFormatDate_DateTime;
			}
		}

		/// <summary>
		/// Void ValidateKeyStorageFlags(System.Security.Cryptography.X509Certificates.X509KeyStorageFlags)
		/// </summary>
		protected static RMethod r_MValidateKeyStorageFlags_X509KeyStorageFlags;
		public static RMethod RMValidateKeyStorageFlags_X509KeyStorageFlags
		{
			get
			{
				if(r_MValidateKeyStorageFlags_X509KeyStorageFlags == null)
				{
					r_MValidateKeyStorageFlags_X509KeyStorageFlags = new(Type, "ValidateKeyStorageFlags", 0, typeof(System.Security.Cryptography.X509Certificates.X509KeyStorageFlags));
				}
				return r_MValidateKeyStorageFlags_X509KeyStorageFlags;
			}
		}

		/// <summary>
		/// Void VerifyContentType(System.Security.Cryptography.X509Certificates.X509ContentType)
		/// </summary>
		protected RMethod r_MVerifyContentType_X509ContentType;
		public virtual RMethod RMVerifyContentType_X509ContentType
		{
			get
			{
				if(r_MVerifyContentType_X509ContentType == null)
				{
					r_MVerifyContentType_X509ContentType = new(this, "VerifyContentType", 0, typeof(System.Security.Cryptography.X509Certificates.X509ContentType));
				}
				return r_MVerifyContentType_X509ContentType;
			}
		}

		/// <summary>
		/// Void ImportHandle(System.Security.Cryptography.X509Certificates.X509CertificateImpl)
		/// </summary>
		protected RMethod r_MImportHandle_X509CertificateImpl;
		public virtual RMethod RMImportHandle_X509CertificateImpl
		{
			get
			{
				if(r_MImportHandle_X509CertificateImpl == null)
				{
					r_MImportHandle_X509CertificateImpl = new(this, "ImportHandle", 0,  ReflectionUtils.GetType("System.Security.Cryptography.X509Certificates.X509CertificateImpl"));
				}
				return r_MImportHandle_X509CertificateImpl;
			}
		}

		/// <summary>
		/// Void ThrowIfInvalid()
		/// </summary>
		protected RMethod r_MThrowIfInvalid;
		public virtual RMethod RMThrowIfInvalid
		{
			get
			{
				if(r_MThrowIfInvalid == null)
				{
					r_MThrowIfInvalid = new(this, "ThrowIfInvalid", 0);
				}
				return r_MThrowIfInvalid;
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


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReset.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Security.Cryptography.X509Certificates.X509Certificate CreateFromCertFile(System.String @filename)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filename};
            var ___result = RMCreateFromCertFile_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Security.Cryptography.X509Certificates.X509Certificate>(___result);
        }


        public static System.Security.Cryptography.X509Certificates.X509Certificate CreateFromSignedFile(System.String @filename)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filename};
            var ___result = RMCreateFromSignedFile_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Security.Cryptography.X509Certificates.X509Certificate>(___result);
        }


        public virtual void System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization(System.Object @sender)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender};
            var ___result = RMSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RMDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(System.Security.Cryptography.X509Certificates.X509Certificate @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_X509Certificate.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Byte[] Export(System.Security.Cryptography.X509Certificates.X509ContentType @contentType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@contentType};
            var ___result = RMExport_X509ContentType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Byte[]>(___result);
        }


        public virtual System.Byte[] Export(System.Security.Cryptography.X509Certificates.X509ContentType @contentType, System.String @password)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@contentType, @password};
            var ___result = RMExport_X509ContentType_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Byte[]>(___result);
        }


        public virtual System.Byte[] Export(System.Security.Cryptography.X509Certificates.X509ContentType @contentType, System.Security.SecureString @password)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@contentType, @password};
            var ___result = RMExport_X509ContentType_SecureString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Byte[]>(___result);
        }


        public virtual System.String GetRawCertDataString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRawCertDataString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Byte[] GetCertHash()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCertHash.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Byte[]>(___result);
        }


        public virtual System.Byte[] GetCertHash(System.Security.Cryptography.HashAlgorithmName @hashAlgorithm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hashAlgorithm};
            var ___result = RMGetCertHash_HashAlgorithmName.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Byte[]>(___result);
        }


        public virtual System.Boolean TryGetCertHash(System.Security.Cryptography.HashAlgorithmName @hashAlgorithm, Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RSystem.RByte> @destination, out System.Int32 @bytesWritten)
        {
			@bytesWritten = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hashAlgorithm, @destination.Value, @bytesWritten};
            var ___result = RMTryGetCertHash_HashAlgorithmName_Span_d_Byte_p__Out_Int32.Invoke(___genericsType, ___parameters);
			@bytesWritten = ReflectionUtils.Convert<System.Int32>(___parameters[2]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.String GetCertHashString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCertHashString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String GetCertHashString(System.Security.Cryptography.HashAlgorithmName @hashAlgorithm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hashAlgorithm};
            var ___result = RMGetCertHashString_HashAlgorithmName.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Byte[] GetRawCertHash()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRawCertHash.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Byte[]>(___result);
        }


        public virtual System.String GetEffectiveDateString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEffectiveDateString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String GetExpirationDateString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetExpirationDateString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String GetFormat()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetFormat.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String GetPublicKeyString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPublicKeyString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Byte[] GetRawCertData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRawCertData.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Byte[]>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String GetKeyAlgorithm()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetKeyAlgorithm.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Byte[] GetKeyAlgorithmParameters()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetKeyAlgorithmParameters.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Byte[]>(___result);
        }


        public virtual System.String GetKeyAlgorithmParametersString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetKeyAlgorithmParametersString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Byte[] GetPublicKey()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPublicKey.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Byte[]>(___result);
        }


        public virtual System.Byte[] GetSerialNumber()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSerialNumber.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Byte[]>(___result);
        }


        public virtual System.String GetSerialNumberString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSerialNumberString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Byte[] GetRawSerialNumber()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRawSerialNumber.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Byte[]>(___result);
        }


        public virtual System.String GetName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetName.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String GetIssuerName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetIssuerName.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(System.Boolean @fVerbose)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fVerbose};
            var ___result = RMToString_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual void Import(System.Byte[] @rawData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rawData};
            var ___result = RMImport_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Import(System.Byte[] @rawData, System.String @password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags @keyStorageFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rawData, @password, @keyStorageFlags};
            var ___result = RMImport_ByteArray_String_X509KeyStorageFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Import(System.Byte[] @rawData, System.Security.SecureString @password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags @keyStorageFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rawData, @password, @keyStorageFlags};
            var ___result = RMImport_ByteArray_SecureString_X509KeyStorageFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Import(System.String @fileName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileName};
            var ___result = RMImport_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Import(System.String @fileName, System.String @password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags @keyStorageFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileName, @password, @keyStorageFlags};
            var ___result = RMImport_String_String_X509KeyStorageFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Import(System.String @fileName, System.Security.SecureString @password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags @keyStorageFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileName, @password, @keyStorageFlags};
            var ___result = RMImport_String_SecureString_X509KeyStorageFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.DateTime GetNotAfter()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetNotAfter.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.DateTime>(___result);
        }


        public virtual System.DateTime GetNotBefore()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetNotBefore.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.DateTime>(___result);
        }


        public static System.String FormatDate(System.DateTime @date)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@date};
            var ___result = RMFormatDate_DateTime.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public static void ValidateKeyStorageFlags(System.Security.Cryptography.X509Certificates.X509KeyStorageFlags @keyStorageFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyStorageFlags};
            var ___result = RMValidateKeyStorageFlags_X509KeyStorageFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void VerifyContentType(System.Security.Cryptography.X509Certificates.X509ContentType @contentType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@contentType};
            var ___result = RMVerifyContentType_X509ContentType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ImportHandle(Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RX509Certificates.RX509CertificateImpl @impl)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@impl.Value};
            var ___result = RMImportHandle_X509CertificateImpl.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ThrowIfInvalid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMThrowIfInvalid.Invoke(___genericsType, ___parameters);

            
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
