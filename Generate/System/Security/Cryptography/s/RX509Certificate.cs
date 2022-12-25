using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RX509Certificates
{
	/// <summary>
	/// System.Security.Cryptography.X509Certificates.X509Certificate
	/// </summary>
    public partial class RX509Certificate : RMember //
    {

		/// <summary>
		/// System.Security.Cryptography.X509Certificates.X509CertificateImpl impl
		/// </summary>
		protected RSystem.RSecurity.RCryptography.RX509Certificates.RX509CertificateImpl r_impl;
		public virtual RSystem.RSecurity.RCryptography.RX509Certificates.RX509CertificateImpl Rimpl
		{
			get
			{
				if(r_impl == null)
				{
					r_impl = new(this, "impl");
					r_impl.SetBelong(this.instance);
				}
				return r_impl;
			}
		}

		/// <summary>
		/// System.Byte[] lazyCertHash
		/// </summary>
		protected RFieldArray<RField> r_lazyCertHash;
		public virtual RFieldArray<RField> RlazyCertHash
		{
			get
			{
				if(r_lazyCertHash == null)
				{
					r_lazyCertHash = new(this, "lazyCertHash");
					r_lazyCertHash.SetBelong(this.instance);
				}
				return r_lazyCertHash;
			}
		}

		/// <summary>
		/// System.Byte[] lazySerialNumber
		/// </summary>
		protected RFieldArray<RField> r_lazySerialNumber;
		public virtual RFieldArray<RField> RlazySerialNumber
		{
			get
			{
				if(r_lazySerialNumber == null)
				{
					r_lazySerialNumber = new(this, "lazySerialNumber");
					r_lazySerialNumber.SetBelong(this.instance);
				}
				return r_lazySerialNumber;
			}
		}

		/// <summary>
		/// System.String lazyIssuer
		/// </summary>
		protected RField r_lazyIssuer;
		public virtual RField RlazyIssuer
		{
			get
			{
				if(r_lazyIssuer == null)
				{
					r_lazyIssuer = new(this, "lazyIssuer");
					r_lazyIssuer.SetBelong(this.instance);
				}
				return r_lazyIssuer;
			}
		}

		/// <summary>
		/// System.String lazySubject
		/// </summary>
		protected RField r_lazySubject;
		public virtual RField RlazySubject
		{
			get
			{
				if(r_lazySubject == null)
				{
					r_lazySubject = new(this, "lazySubject");
					r_lazySubject.SetBelong(this.instance);
				}
				return r_lazySubject;
			}
		}

		/// <summary>
		/// System.String lazyKeyAlgorithm
		/// </summary>
		protected RField r_lazyKeyAlgorithm;
		public virtual RField RlazyKeyAlgorithm
		{
			get
			{
				if(r_lazyKeyAlgorithm == null)
				{
					r_lazyKeyAlgorithm = new(this, "lazyKeyAlgorithm");
					r_lazyKeyAlgorithm.SetBelong(this.instance);
				}
				return r_lazyKeyAlgorithm;
			}
		}

		/// <summary>
		/// System.Byte[] lazyKeyAlgorithmParameters
		/// </summary>
		protected RFieldArray<RField> r_lazyKeyAlgorithmParameters;
		public virtual RFieldArray<RField> RlazyKeyAlgorithmParameters
		{
			get
			{
				if(r_lazyKeyAlgorithmParameters == null)
				{
					r_lazyKeyAlgorithmParameters = new(this, "lazyKeyAlgorithmParameters");
					r_lazyKeyAlgorithmParameters.SetBelong(this.instance);
				}
				return r_lazyKeyAlgorithmParameters;
			}
		}

		/// <summary>
		/// System.Byte[] lazyPublicKey
		/// </summary>
		protected RFieldArray<RField> r_lazyPublicKey;
		public virtual RFieldArray<RField> RlazyPublicKey
		{
			get
			{
				if(r_lazyPublicKey == null)
				{
					r_lazyPublicKey = new(this, "lazyPublicKey");
					r_lazyPublicKey.SetBelong(this.instance);
				}
				return r_lazyPublicKey;
			}
		}

		/// <summary>
		/// System.DateTime lazyNotBefore
		/// </summary>
		protected RSystem.RDateTime r_lazyNotBefore;
		public virtual RSystem.RDateTime RlazyNotBefore
		{
			get
			{
				if(r_lazyNotBefore == null)
				{
					r_lazyNotBefore = new(this, "lazyNotBefore");
					r_lazyNotBefore.SetBelong(this.instance);
				}
				return r_lazyNotBefore;
			}
		}

		/// <summary>
		/// System.DateTime lazyNotAfter
		/// </summary>
		protected RSystem.RDateTime r_lazyNotAfter;
		public virtual RSystem.RDateTime RlazyNotAfter
		{
			get
			{
				if(r_lazyNotAfter == null)
				{
					r_lazyNotAfter = new(this, "lazyNotAfter");
					r_lazyNotAfter.SetBelong(this.instance);
				}
				return r_lazyNotAfter;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.X509Certificates.X509KeyStorageFlags KeyStorageFlagsAll
		/// </summary>
		protected static RField r_KeyStorageFlagsAll;
		public static RField RKeyStorageFlagsAll
		{
			get
			{
				if(r_KeyStorageFlagsAll == null)
				{
					r_KeyStorageFlagsAll = new(typeof(System.Security.Cryptography.X509Certificates.X509Certificate), "KeyStorageFlagsAll");
					r_KeyStorageFlagsAll.SetBelong(null);
				}
				return r_KeyStorageFlagsAll;
			}
		}

		/// <summary>
		/// IntPtr Handle
		/// </summary>
		protected RProperty r_Handle;
		public virtual RProperty RHandle
		{
			get
			{
				if(r_Handle == null)
				{
					r_Handle = new(this, "Handle", -1);
					r_Handle.SetBelong(this.instance);
				}
				return r_Handle;
			}
		}

		/// <summary>
		/// System.String Issuer
		/// </summary>
		protected RProperty r_Issuer;
		public virtual RProperty RIssuer
		{
			get
			{
				if(r_Issuer == null)
				{
					r_Issuer = new(this, "Issuer", -1);
					r_Issuer.SetBelong(this.instance);
				}
				return r_Issuer;
			}
		}

		/// <summary>
		/// System.String Subject
		/// </summary>
		protected RProperty r_Subject;
		public virtual RProperty RSubject
		{
			get
			{
				if(r_Subject == null)
				{
					r_Subject = new(this, "Subject", -1);
					r_Subject.SetBelong(this.instance);
				}
				return r_Subject;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.X509Certificates.X509CertificateImpl Impl
		/// </summary>
		protected RSystem.RSecurity.RCryptography.RX509Certificates.RX509CertificateImpl r_Impl;
		public virtual RSystem.RSecurity.RCryptography.RX509Certificates.RX509CertificateImpl RImpl
		{
			get
			{
				if(r_Impl == null)
				{
					r_Impl = new(this, "Impl", -1);
					r_Impl.SetBelong(this.instance);
				}
				return r_Impl;
			}
		}

		/// <summary>
		/// Boolean IsValid
		/// </summary>
		protected RProperty r_IsValid;
		public virtual RProperty RIsValid
		{
			get
			{
				if(r_IsValid == null)
				{
					r_IsValid = new(this, "IsValid", -1);
					r_IsValid.SetBelong(this.instance);
				}
				return r_IsValid;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_RReset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_RReset == null)
				{
					r_RReset = new(this, "Reset", 0);
					r_RReset.SetBelong(this.instance);
				}
				return r_RReset;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.X509Certificates.X509Certificate CreateFromCertFile(System.String)
		/// </summary>
		protected static RMethod r_RCreateFromCertFile_String;
		public static RMethod RCreateFromCertFile_String
		{
			get
			{
				if(r_RCreateFromCertFile_String == null)
				{
					r_RCreateFromCertFile_String = new(typeof(System.Security.Cryptography.X509Certificates.X509Certificate), "CreateFromCertFile", 0, typeof(System.String));
					r_RCreateFromCertFile_String.SetBelong(null);
				}
				return r_RCreateFromCertFile_String;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.X509Certificates.X509Certificate CreateFromSignedFile(System.String)
		/// </summary>
		protected static RMethod r_RCreateFromSignedFile_String;
		public static RMethod RCreateFromSignedFile_String
		{
			get
			{
				if(r_RCreateFromSignedFile_String == null)
				{
					r_RCreateFromSignedFile_String = new(typeof(System.Security.Cryptography.X509Certificates.X509Certificate), "CreateFromSignedFile", 0, typeof(System.String));
					r_RCreateFromSignedFile_String.SetBelong(null);
				}
				return r_RCreateFromSignedFile_String;
			}
		}

		/// <summary>
		/// Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext = new(this, "System.Runtime.Serialization.ISerializable.GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// Void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(System.Object)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__Serialization__0__IDeserializationCallback__0__OnDeserialization_Object;
		public virtual RMethod RSystem__0__Runtime__0__Serialization__0__IDeserializationCallback__0__OnDeserialization_Object
		{
			get
			{
				if(r_RSystem__0__Runtime__0__Serialization__0__IDeserializationCallback__0__OnDeserialization_Object == null)
				{
					r_RSystem__0__Runtime__0__Serialization__0__IDeserializationCallback__0__OnDeserialization_Object = new(this, "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", 0, typeof(System.Object));
					r_RSystem__0__Runtime__0__Serialization__0__IDeserializationCallback__0__OnDeserialization_Object.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__Serialization__0__IDeserializationCallback__0__OnDeserialization_Object;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_RDispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_RDispose == null)
				{
					r_RDispose = new(this, "Dispose", 0);
					r_RDispose.SetBelong(this.instance);
				}
				return r_RDispose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_RDispose_Boolean;
		public virtual RMethod RDispose_Boolean
		{
			get
			{
				if(r_RDispose_Boolean == null)
				{
					r_RDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_RDispose_Boolean.SetBelong(this.instance);
				}
				return r_RDispose_Boolean;
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
		/// Boolean Equals(System.Security.Cryptography.X509Certificates.X509Certificate)
		/// </summary>
		protected RMethod r_REquals_X509Certificate;
		public virtual RMethod REquals_X509Certificate
		{
			get
			{
				if(r_REquals_X509Certificate == null)
				{
					r_REquals_X509Certificate = new(this, "Equals", 0, typeof(System.Security.Cryptography.X509Certificates.X509Certificate));
					r_REquals_X509Certificate.SetBelong(this.instance);
				}
				return r_REquals_X509Certificate;
			}
		}

		/// <summary>
		/// Byte[] Export(System.Security.Cryptography.X509Certificates.X509ContentType)
		/// </summary>
		protected RMethod r_RExport_X509ContentType;
		public virtual RMethod RExport_X509ContentType
		{
			get
			{
				if(r_RExport_X509ContentType == null)
				{
					r_RExport_X509ContentType = new(this, "Export", 0, typeof(System.Security.Cryptography.X509Certificates.X509ContentType));
					r_RExport_X509ContentType.SetBelong(this.instance);
				}
				return r_RExport_X509ContentType;
			}
		}

		/// <summary>
		/// Byte[] Export(System.Security.Cryptography.X509Certificates.X509ContentType, System.String)
		/// </summary>
		protected RMethod r_RExport_X509ContentType_String;
		public virtual RMethod RExport_X509ContentType_String
		{
			get
			{
				if(r_RExport_X509ContentType_String == null)
				{
					r_RExport_X509ContentType_String = new(this, "Export", 0, typeof(System.Security.Cryptography.X509Certificates.X509ContentType), typeof(System.String));
					r_RExport_X509ContentType_String.SetBelong(this.instance);
				}
				return r_RExport_X509ContentType_String;
			}
		}

		/// <summary>
		/// Byte[] Export(System.Security.Cryptography.X509Certificates.X509ContentType, System.Security.SecureString)
		/// </summary>
		protected RMethod r_RExport_X509ContentType_SecureString;
		public virtual RMethod RExport_X509ContentType_SecureString
		{
			get
			{
				if(r_RExport_X509ContentType_SecureString == null)
				{
					r_RExport_X509ContentType_SecureString = new(this, "Export", 0, typeof(System.Security.Cryptography.X509Certificates.X509ContentType), typeof(System.Security.SecureString));
					r_RExport_X509ContentType_SecureString.SetBelong(this.instance);
				}
				return r_RExport_X509ContentType_SecureString;
			}
		}

		/// <summary>
		/// System.String GetRawCertDataString()
		/// </summary>
		protected RMethod r_RGetRawCertDataString;
		public virtual RMethod RGetRawCertDataString
		{
			get
			{
				if(r_RGetRawCertDataString == null)
				{
					r_RGetRawCertDataString = new(this, "GetRawCertDataString", 0);
					r_RGetRawCertDataString.SetBelong(this.instance);
				}
				return r_RGetRawCertDataString;
			}
		}

		/// <summary>
		/// Byte[] GetCertHash()
		/// </summary>
		protected RMethod r_RGetCertHash;
		public virtual RMethod RGetCertHash
		{
			get
			{
				if(r_RGetCertHash == null)
				{
					r_RGetCertHash = new(this, "GetCertHash", 0);
					r_RGetCertHash.SetBelong(this.instance);
				}
				return r_RGetCertHash;
			}
		}

		/// <summary>
		/// Byte[] GetCertHash(System.Security.Cryptography.HashAlgorithmName)
		/// </summary>
		protected RMethod r_RGetCertHash_HashAlgorithmName;
		public virtual RMethod RGetCertHash_HashAlgorithmName
		{
			get
			{
				if(r_RGetCertHash_HashAlgorithmName == null)
				{
					r_RGetCertHash_HashAlgorithmName = new(this, "GetCertHash", 0, typeof(System.Security.Cryptography.HashAlgorithmName));
					r_RGetCertHash_HashAlgorithmName.SetBelong(this.instance);
				}
				return r_RGetCertHash_HashAlgorithmName;
			}
		}

		/// <summary>
		/// Boolean TryGetCertHash(System.Security.Cryptography.HashAlgorithmName, System.Span`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_RTryGetCertHash_HashAlgorithmName_Span_d_Byte_p__Out_Int32;
		public virtual RMethod RTryGetCertHash_HashAlgorithmName_Span_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_RTryGetCertHash_HashAlgorithmName_Span_d_Byte_p__Out_Int32 == null)
				{
					r_RTryGetCertHash_HashAlgorithmName_Span_d_Byte_p__Out_Int32 = new(this, "TryGetCertHash", 0, typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_RTryGetCertHash_HashAlgorithmName_Span_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_RTryGetCertHash_HashAlgorithmName_Span_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// System.String GetCertHashString()
		/// </summary>
		protected RMethod r_RGetCertHashString;
		public virtual RMethod RGetCertHashString
		{
			get
			{
				if(r_RGetCertHashString == null)
				{
					r_RGetCertHashString = new(this, "GetCertHashString", 0);
					r_RGetCertHashString.SetBelong(this.instance);
				}
				return r_RGetCertHashString;
			}
		}

		/// <summary>
		/// System.String GetCertHashString(System.Security.Cryptography.HashAlgorithmName)
		/// </summary>
		protected RMethod r_RGetCertHashString_HashAlgorithmName;
		public virtual RMethod RGetCertHashString_HashAlgorithmName
		{
			get
			{
				if(r_RGetCertHashString_HashAlgorithmName == null)
				{
					r_RGetCertHashString_HashAlgorithmName = new(this, "GetCertHashString", 0, typeof(System.Security.Cryptography.HashAlgorithmName));
					r_RGetCertHashString_HashAlgorithmName.SetBelong(this.instance);
				}
				return r_RGetCertHashString_HashAlgorithmName;
			}
		}

		/// <summary>
		/// Byte[] GetRawCertHash()
		/// </summary>
		protected RMethod r_RGetRawCertHash;
		public virtual RMethod RGetRawCertHash
		{
			get
			{
				if(r_RGetRawCertHash == null)
				{
					r_RGetRawCertHash = new(this, "GetRawCertHash", 0);
					r_RGetRawCertHash.SetBelong(this.instance);
				}
				return r_RGetRawCertHash;
			}
		}

		/// <summary>
		/// System.String GetEffectiveDateString()
		/// </summary>
		protected RMethod r_RGetEffectiveDateString;
		public virtual RMethod RGetEffectiveDateString
		{
			get
			{
				if(r_RGetEffectiveDateString == null)
				{
					r_RGetEffectiveDateString = new(this, "GetEffectiveDateString", 0);
					r_RGetEffectiveDateString.SetBelong(this.instance);
				}
				return r_RGetEffectiveDateString;
			}
		}

		/// <summary>
		/// System.String GetExpirationDateString()
		/// </summary>
		protected RMethod r_RGetExpirationDateString;
		public virtual RMethod RGetExpirationDateString
		{
			get
			{
				if(r_RGetExpirationDateString == null)
				{
					r_RGetExpirationDateString = new(this, "GetExpirationDateString", 0);
					r_RGetExpirationDateString.SetBelong(this.instance);
				}
				return r_RGetExpirationDateString;
			}
		}

		/// <summary>
		/// System.String GetFormat()
		/// </summary>
		protected RMethod r_RGetFormat;
		public virtual RMethod RGetFormat
		{
			get
			{
				if(r_RGetFormat == null)
				{
					r_RGetFormat = new(this, "GetFormat", 0);
					r_RGetFormat.SetBelong(this.instance);
				}
				return r_RGetFormat;
			}
		}

		/// <summary>
		/// System.String GetPublicKeyString()
		/// </summary>
		protected RMethod r_RGetPublicKeyString;
		public virtual RMethod RGetPublicKeyString
		{
			get
			{
				if(r_RGetPublicKeyString == null)
				{
					r_RGetPublicKeyString = new(this, "GetPublicKeyString", 0);
					r_RGetPublicKeyString.SetBelong(this.instance);
				}
				return r_RGetPublicKeyString;
			}
		}

		/// <summary>
		/// Byte[] GetRawCertData()
		/// </summary>
		protected RMethod r_RGetRawCertData;
		public virtual RMethod RGetRawCertData
		{
			get
			{
				if(r_RGetRawCertData == null)
				{
					r_RGetRawCertData = new(this, "GetRawCertData", 0);
					r_RGetRawCertData.SetBelong(this.instance);
				}
				return r_RGetRawCertData;
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
		/// System.String GetKeyAlgorithm()
		/// </summary>
		protected RMethod r_RGetKeyAlgorithm;
		public virtual RMethod RGetKeyAlgorithm
		{
			get
			{
				if(r_RGetKeyAlgorithm == null)
				{
					r_RGetKeyAlgorithm = new(this, "GetKeyAlgorithm", 0);
					r_RGetKeyAlgorithm.SetBelong(this.instance);
				}
				return r_RGetKeyAlgorithm;
			}
		}

		/// <summary>
		/// Byte[] GetKeyAlgorithmParameters()
		/// </summary>
		protected RMethod r_RGetKeyAlgorithmParameters;
		public virtual RMethod RGetKeyAlgorithmParameters
		{
			get
			{
				if(r_RGetKeyAlgorithmParameters == null)
				{
					r_RGetKeyAlgorithmParameters = new(this, "GetKeyAlgorithmParameters", 0);
					r_RGetKeyAlgorithmParameters.SetBelong(this.instance);
				}
				return r_RGetKeyAlgorithmParameters;
			}
		}

		/// <summary>
		/// System.String GetKeyAlgorithmParametersString()
		/// </summary>
		protected RMethod r_RGetKeyAlgorithmParametersString;
		public virtual RMethod RGetKeyAlgorithmParametersString
		{
			get
			{
				if(r_RGetKeyAlgorithmParametersString == null)
				{
					r_RGetKeyAlgorithmParametersString = new(this, "GetKeyAlgorithmParametersString", 0);
					r_RGetKeyAlgorithmParametersString.SetBelong(this.instance);
				}
				return r_RGetKeyAlgorithmParametersString;
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
		/// Byte[] GetSerialNumber()
		/// </summary>
		protected RMethod r_RGetSerialNumber;
		public virtual RMethod RGetSerialNumber
		{
			get
			{
				if(r_RGetSerialNumber == null)
				{
					r_RGetSerialNumber = new(this, "GetSerialNumber", 0);
					r_RGetSerialNumber.SetBelong(this.instance);
				}
				return r_RGetSerialNumber;
			}
		}

		/// <summary>
		/// System.String GetSerialNumberString()
		/// </summary>
		protected RMethod r_RGetSerialNumberString;
		public virtual RMethod RGetSerialNumberString
		{
			get
			{
				if(r_RGetSerialNumberString == null)
				{
					r_RGetSerialNumberString = new(this, "GetSerialNumberString", 0);
					r_RGetSerialNumberString.SetBelong(this.instance);
				}
				return r_RGetSerialNumberString;
			}
		}

		/// <summary>
		/// Byte[] GetRawSerialNumber()
		/// </summary>
		protected RMethod r_RGetRawSerialNumber;
		public virtual RMethod RGetRawSerialNumber
		{
			get
			{
				if(r_RGetRawSerialNumber == null)
				{
					r_RGetRawSerialNumber = new(this, "GetRawSerialNumber", 0);
					r_RGetRawSerialNumber.SetBelong(this.instance);
				}
				return r_RGetRawSerialNumber;
			}
		}

		/// <summary>
		/// System.String GetName()
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
		/// System.String GetIssuerName()
		/// </summary>
		protected RMethod r_RGetIssuerName;
		public virtual RMethod RGetIssuerName
		{
			get
			{
				if(r_RGetIssuerName == null)
				{
					r_RGetIssuerName = new(this, "GetIssuerName", 0);
					r_RGetIssuerName.SetBelong(this.instance);
				}
				return r_RGetIssuerName;
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
		/// System.String ToString(Boolean)
		/// </summary>
		protected RMethod r_RToString_Boolean;
		public virtual RMethod RToString_Boolean
		{
			get
			{
				if(r_RToString_Boolean == null)
				{
					r_RToString_Boolean = new(this, "ToString", 0, typeof(System.Boolean));
					r_RToString_Boolean.SetBelong(this.instance);
				}
				return r_RToString_Boolean;
			}
		}

		/// <summary>
		/// Void Import(Byte[])
		/// </summary>
		protected RMethod r_RImport_ByteArray;
		public virtual RMethod RImport_ByteArray
		{
			get
			{
				if(r_RImport_ByteArray == null)
				{
					r_RImport_ByteArray = new(this, "Import", 0, typeof(System.Byte).MakeArrayType());
					r_RImport_ByteArray.SetBelong(this.instance);
				}
				return r_RImport_ByteArray;
			}
		}

		/// <summary>
		/// Void Import(Byte[], System.String, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags)
		/// </summary>
		protected RMethod r_RImport_ByteArray_String_X509KeyStorageFlags;
		public virtual RMethod RImport_ByteArray_String_X509KeyStorageFlags
		{
			get
			{
				if(r_RImport_ByteArray_String_X509KeyStorageFlags == null)
				{
					r_RImport_ByteArray_String_X509KeyStorageFlags = new(this, "Import", 0, typeof(System.Byte).MakeArrayType(), typeof(System.String), typeof(System.Security.Cryptography.X509Certificates.X509KeyStorageFlags));
					r_RImport_ByteArray_String_X509KeyStorageFlags.SetBelong(this.instance);
				}
				return r_RImport_ByteArray_String_X509KeyStorageFlags;
			}
		}

		/// <summary>
		/// Void Import(Byte[], System.Security.SecureString, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags)
		/// </summary>
		protected RMethod r_RImport_ByteArray_SecureString_X509KeyStorageFlags;
		public virtual RMethod RImport_ByteArray_SecureString_X509KeyStorageFlags
		{
			get
			{
				if(r_RImport_ByteArray_SecureString_X509KeyStorageFlags == null)
				{
					r_RImport_ByteArray_SecureString_X509KeyStorageFlags = new(this, "Import", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Security.SecureString), typeof(System.Security.Cryptography.X509Certificates.X509KeyStorageFlags));
					r_RImport_ByteArray_SecureString_X509KeyStorageFlags.SetBelong(this.instance);
				}
				return r_RImport_ByteArray_SecureString_X509KeyStorageFlags;
			}
		}

		/// <summary>
		/// Void Import(System.String)
		/// </summary>
		protected RMethod r_RImport_String;
		public virtual RMethod RImport_String
		{
			get
			{
				if(r_RImport_String == null)
				{
					r_RImport_String = new(this, "Import", 0, typeof(System.String));
					r_RImport_String.SetBelong(this.instance);
				}
				return r_RImport_String;
			}
		}

		/// <summary>
		/// Void Import(System.String, System.String, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags)
		/// </summary>
		protected RMethod r_RImport_String_String_X509KeyStorageFlags;
		public virtual RMethod RImport_String_String_X509KeyStorageFlags
		{
			get
			{
				if(r_RImport_String_String_X509KeyStorageFlags == null)
				{
					r_RImport_String_String_X509KeyStorageFlags = new(this, "Import", 0, typeof(System.String), typeof(System.String), typeof(System.Security.Cryptography.X509Certificates.X509KeyStorageFlags));
					r_RImport_String_String_X509KeyStorageFlags.SetBelong(this.instance);
				}
				return r_RImport_String_String_X509KeyStorageFlags;
			}
		}

		/// <summary>
		/// Void Import(System.String, System.Security.SecureString, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags)
		/// </summary>
		protected RMethod r_RImport_String_SecureString_X509KeyStorageFlags;
		public virtual RMethod RImport_String_SecureString_X509KeyStorageFlags
		{
			get
			{
				if(r_RImport_String_SecureString_X509KeyStorageFlags == null)
				{
					r_RImport_String_SecureString_X509KeyStorageFlags = new(this, "Import", 0, typeof(System.String), typeof(System.Security.SecureString), typeof(System.Security.Cryptography.X509Certificates.X509KeyStorageFlags));
					r_RImport_String_SecureString_X509KeyStorageFlags.SetBelong(this.instance);
				}
				return r_RImport_String_SecureString_X509KeyStorageFlags;
			}
		}

		/// <summary>
		/// System.DateTime GetNotAfter()
		/// </summary>
		protected RMethod r_RGetNotAfter;
		public virtual RMethod RGetNotAfter
		{
			get
			{
				if(r_RGetNotAfter == null)
				{
					r_RGetNotAfter = new(this, "GetNotAfter", 0);
					r_RGetNotAfter.SetBelong(this.instance);
				}
				return r_RGetNotAfter;
			}
		}

		/// <summary>
		/// System.DateTime GetNotBefore()
		/// </summary>
		protected RMethod r_RGetNotBefore;
		public virtual RMethod RGetNotBefore
		{
			get
			{
				if(r_RGetNotBefore == null)
				{
					r_RGetNotBefore = new(this, "GetNotBefore", 0);
					r_RGetNotBefore.SetBelong(this.instance);
				}
				return r_RGetNotBefore;
			}
		}

		/// <summary>
		/// System.String FormatDate(System.DateTime)
		/// </summary>
		protected static RMethod r_RFormatDate_DateTime;
		public static RMethod RFormatDate_DateTime
		{
			get
			{
				if(r_RFormatDate_DateTime == null)
				{
					r_RFormatDate_DateTime = new(typeof(System.Security.Cryptography.X509Certificates.X509Certificate), "FormatDate", 0, typeof(System.DateTime));
					r_RFormatDate_DateTime.SetBelong(null);
				}
				return r_RFormatDate_DateTime;
			}
		}

		/// <summary>
		/// Void ValidateKeyStorageFlags(System.Security.Cryptography.X509Certificates.X509KeyStorageFlags)
		/// </summary>
		protected static RMethod r_RValidateKeyStorageFlags_X509KeyStorageFlags;
		public static RMethod RValidateKeyStorageFlags_X509KeyStorageFlags
		{
			get
			{
				if(r_RValidateKeyStorageFlags_X509KeyStorageFlags == null)
				{
					r_RValidateKeyStorageFlags_X509KeyStorageFlags = new(typeof(System.Security.Cryptography.X509Certificates.X509Certificate), "ValidateKeyStorageFlags", 0, typeof(System.Security.Cryptography.X509Certificates.X509KeyStorageFlags));
					r_RValidateKeyStorageFlags_X509KeyStorageFlags.SetBelong(null);
				}
				return r_RValidateKeyStorageFlags_X509KeyStorageFlags;
			}
		}

		/// <summary>
		/// Void VerifyContentType(System.Security.Cryptography.X509Certificates.X509ContentType)
		/// </summary>
		protected RMethod r_RVerifyContentType_X509ContentType;
		public virtual RMethod RVerifyContentType_X509ContentType
		{
			get
			{
				if(r_RVerifyContentType_X509ContentType == null)
				{
					r_RVerifyContentType_X509ContentType = new(this, "VerifyContentType", 0, typeof(System.Security.Cryptography.X509Certificates.X509ContentType));
					r_RVerifyContentType_X509ContentType.SetBelong(this.instance);
				}
				return r_RVerifyContentType_X509ContentType;
			}
		}

		/// <summary>
		/// Void ImportHandle(System.Security.Cryptography.X509Certificates.X509CertificateImpl)
		/// </summary>
		protected RMethod r_RImportHandle_X509CertificateImpl;
		public virtual RMethod RImportHandle_X509CertificateImpl
		{
			get
			{
				if(r_RImportHandle_X509CertificateImpl == null)
				{
					r_RImportHandle_X509CertificateImpl = new(this, "ImportHandle", 0,  ReleactionUtils.GetType("System.Security.Cryptography.X509Certificates.X509CertificateImpl"));
					r_RImportHandle_X509CertificateImpl.SetBelong(this.instance);
				}
				return r_RImportHandle_X509CertificateImpl;
			}
		}

		/// <summary>
		/// Void ThrowIfInvalid()
		/// </summary>
		protected RMethod r_RThrowIfInvalid;
		public virtual RMethod RThrowIfInvalid
		{
			get
			{
				if(r_RThrowIfInvalid == null)
				{
					r_RThrowIfInvalid = new(this, "ThrowIfInvalid", 0);
					r_RThrowIfInvalid.SetBelong(this.instance);
				}
				return r_RThrowIfInvalid;
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

        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Security.Cryptography.X509Certificates.X509Certificate CreateFromCertFile(System.String  @filename)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filename};
            var ___result = RCreateFromCertFile_String.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.X509Certificates.X509Certificate)___result;
        }


        public static System.Security.Cryptography.X509Certificates.X509Certificate CreateFromSignedFile(System.String  @filename)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filename};
            var ___result = RCreateFromSignedFile_String.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.X509Certificates.X509Certificate)___result;
        }


        public virtual void System__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData(System.Runtime.Serialization.SerializationInfo  @info, System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Runtime__0__Serialization__0__IDeserializationCallback__0__OnDeserialization(System.Object  @sender)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender};
            var ___result = RSystem__0__Runtime__0__Serialization__0__IDeserializationCallback__0__OnDeserialization_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean  @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Security.Cryptography.X509Certificates.X509Certificate  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_X509Certificate.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Byte[] Export(System.Security.Cryptography.X509Certificates.X509ContentType  @contentType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@contentType};
            var ___result = RExport_X509ContentType.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] Export(System.Security.Cryptography.X509Certificates.X509ContentType  @contentType, System.String  @password)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@contentType, @password};
            var ___result = RExport_X509ContentType_String.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] Export(System.Security.Cryptography.X509Certificates.X509ContentType  @contentType, System.Security.SecureString  @password)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@contentType, @password};
            var ___result = RExport_X509ContentType_SecureString.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.String GetRawCertDataString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRawCertDataString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Byte[] GetCertHash()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCertHash.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] GetCertHash(System.Security.Cryptography.HashAlgorithmName  @hashAlgorithm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hashAlgorithm};
            var ___result = RGetCertHash_HashAlgorithmName.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }



        public virtual System.String GetCertHashString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCertHashString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetCertHashString(System.Security.Cryptography.HashAlgorithmName  @hashAlgorithm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hashAlgorithm};
            var ___result = RGetCertHashString_HashAlgorithmName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Byte[] GetRawCertHash()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRawCertHash.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.String GetEffectiveDateString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEffectiveDateString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetExpirationDateString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetExpirationDateString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetFormat()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetFormat.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetPublicKeyString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPublicKeyString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Byte[] GetRawCertData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRawCertData.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String GetKeyAlgorithm()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetKeyAlgorithm.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Byte[] GetKeyAlgorithmParameters()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetKeyAlgorithmParameters.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.String GetKeyAlgorithmParametersString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetKeyAlgorithmParametersString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Byte[] GetPublicKey()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPublicKey.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] GetSerialNumber()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSerialNumber.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.String GetSerialNumberString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSerialNumberString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Byte[] GetRawSerialNumber()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRawSerialNumber.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.String GetName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetIssuerName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetIssuerName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.Boolean  @fVerbose)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fVerbose};
            var ___result = RToString_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Import(System.Byte[]  @rawData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rawData};
            var ___result = RImport_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Import(System.Byte[]  @rawData, System.String  @password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags  @keyStorageFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rawData, @password, @keyStorageFlags};
            var ___result = RImport_ByteArray_String_X509KeyStorageFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Import(System.Byte[]  @rawData, System.Security.SecureString  @password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags  @keyStorageFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rawData, @password, @keyStorageFlags};
            var ___result = RImport_ByteArray_SecureString_X509KeyStorageFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Import(System.String  @fileName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileName};
            var ___result = RImport_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Import(System.String  @fileName, System.String  @password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags  @keyStorageFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileName, @password, @keyStorageFlags};
            var ___result = RImport_String_String_X509KeyStorageFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Import(System.String  @fileName, System.Security.SecureString  @password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags  @keyStorageFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileName, @password, @keyStorageFlags};
            var ___result = RImport_String_SecureString_X509KeyStorageFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.DateTime GetNotAfter()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetNotAfter.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime GetNotBefore()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetNotBefore.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.String FormatDate(System.DateTime  @date)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@date};
            var ___result = RFormatDate_DateTime.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static void ValidateKeyStorageFlags(System.Security.Cryptography.X509Certificates.X509KeyStorageFlags  @keyStorageFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyStorageFlags};
            var ___result = RValidateKeyStorageFlags_X509KeyStorageFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void VerifyContentType(System.Security.Cryptography.X509Certificates.X509ContentType  @contentType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@contentType};
            var ___result = RVerifyContentType_X509ContentType.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void ThrowIfInvalid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RThrowIfInvalid.Invoke(___genericsType, ___parameters);

            
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
