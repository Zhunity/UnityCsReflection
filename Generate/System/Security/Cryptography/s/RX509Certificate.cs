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
		protected RMethod r_Reset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_Reset == null)
				{
					r_Reset = new(this, "Reset", 0);
					r_Reset.SetBelong(this.instance);
				}
				return r_Reset;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.X509Certificates.X509Certificate CreateFromCertFile(System.String)
		/// </summary>
		protected static RMethod r_CreateFromCertFile_String;
		public static RMethod RCreateFromCertFile_String
		{
			get
			{
				if(r_CreateFromCertFile_String == null)
				{
					r_CreateFromCertFile_String = new(typeof(System.Security.Cryptography.X509Certificates.X509Certificate), "CreateFromCertFile", 0, typeof(System.String));
					r_CreateFromCertFile_String.SetBelong(null);
				}
				return r_CreateFromCertFile_String;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.X509Certificates.X509Certificate CreateFromSignedFile(System.String)
		/// </summary>
		protected static RMethod r_CreateFromSignedFile_String;
		public static RMethod RCreateFromSignedFile_String
		{
			get
			{
				if(r_CreateFromSignedFile_String == null)
				{
					r_CreateFromSignedFile_String = new(typeof(System.Security.Cryptography.X509Certificates.X509Certificate), "CreateFromSignedFile", 0, typeof(System.String));
					r_CreateFromSignedFile_String.SetBelong(null);
				}
				return r_CreateFromSignedFile_String;
			}
		}

		/// <summary>
		/// Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext = new(this, "System.Runtime.Serialization.ISerializable.GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// Void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(System.Object)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object;
		public virtual RMethod RSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object
		{
			get
			{
				if(r_System__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object == null)
				{
					r_System__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object = new(this, "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", 0, typeof(System.Object));
					r_System__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_Dispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_Dispose == null)
				{
					r_Dispose = new(this, "Dispose", 0);
					r_Dispose.SetBelong(this.instance);
				}
				return r_Dispose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_Dispose_Boolean;
		public virtual RMethod RDispose_Boolean
		{
			get
			{
				if(r_Dispose_Boolean == null)
				{
					r_Dispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_Dispose_Boolean.SetBelong(this.instance);
				}
				return r_Dispose_Boolean;
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
		/// Boolean Equals(System.Security.Cryptography.X509Certificates.X509Certificate)
		/// </summary>
		protected RMethod r_Equals_X509Certificate;
		public virtual RMethod REquals_X509Certificate
		{
			get
			{
				if(r_Equals_X509Certificate == null)
				{
					r_Equals_X509Certificate = new(this, "Equals", 0, typeof(System.Security.Cryptography.X509Certificates.X509Certificate));
					r_Equals_X509Certificate.SetBelong(this.instance);
				}
				return r_Equals_X509Certificate;
			}
		}

		/// <summary>
		/// Byte[] Export(System.Security.Cryptography.X509Certificates.X509ContentType)
		/// </summary>
		protected RMethod r_Export_X509ContentType;
		public virtual RMethod RExport_X509ContentType
		{
			get
			{
				if(r_Export_X509ContentType == null)
				{
					r_Export_X509ContentType = new(this, "Export", 0, typeof(System.Security.Cryptography.X509Certificates.X509ContentType));
					r_Export_X509ContentType.SetBelong(this.instance);
				}
				return r_Export_X509ContentType;
			}
		}

		/// <summary>
		/// Byte[] Export(System.Security.Cryptography.X509Certificates.X509ContentType, System.String)
		/// </summary>
		protected RMethod r_Export_X509ContentType_String;
		public virtual RMethod RExport_X509ContentType_String
		{
			get
			{
				if(r_Export_X509ContentType_String == null)
				{
					r_Export_X509ContentType_String = new(this, "Export", 0, typeof(System.Security.Cryptography.X509Certificates.X509ContentType), typeof(System.String));
					r_Export_X509ContentType_String.SetBelong(this.instance);
				}
				return r_Export_X509ContentType_String;
			}
		}

		/// <summary>
		/// Byte[] Export(System.Security.Cryptography.X509Certificates.X509ContentType, System.Security.SecureString)
		/// </summary>
		protected RMethod r_Export_X509ContentType_SecureString;
		public virtual RMethod RExport_X509ContentType_SecureString
		{
			get
			{
				if(r_Export_X509ContentType_SecureString == null)
				{
					r_Export_X509ContentType_SecureString = new(this, "Export", 0, typeof(System.Security.Cryptography.X509Certificates.X509ContentType), typeof(System.Security.SecureString));
					r_Export_X509ContentType_SecureString.SetBelong(this.instance);
				}
				return r_Export_X509ContentType_SecureString;
			}
		}

		/// <summary>
		/// System.String GetRawCertDataString()
		/// </summary>
		protected RMethod r_GetRawCertDataString;
		public virtual RMethod RGetRawCertDataString
		{
			get
			{
				if(r_GetRawCertDataString == null)
				{
					r_GetRawCertDataString = new(this, "GetRawCertDataString", 0);
					r_GetRawCertDataString.SetBelong(this.instance);
				}
				return r_GetRawCertDataString;
			}
		}

		/// <summary>
		/// Byte[] GetCertHash()
		/// </summary>
		protected RMethod r_GetCertHash;
		public virtual RMethod RGetCertHash
		{
			get
			{
				if(r_GetCertHash == null)
				{
					r_GetCertHash = new(this, "GetCertHash", 0);
					r_GetCertHash.SetBelong(this.instance);
				}
				return r_GetCertHash;
			}
		}

		/// <summary>
		/// Byte[] GetCertHash(System.Security.Cryptography.HashAlgorithmName)
		/// </summary>
		protected RMethod r_GetCertHash_HashAlgorithmName;
		public virtual RMethod RGetCertHash_HashAlgorithmName
		{
			get
			{
				if(r_GetCertHash_HashAlgorithmName == null)
				{
					r_GetCertHash_HashAlgorithmName = new(this, "GetCertHash", 0, typeof(System.Security.Cryptography.HashAlgorithmName));
					r_GetCertHash_HashAlgorithmName.SetBelong(this.instance);
				}
				return r_GetCertHash_HashAlgorithmName;
			}
		}

		/// <summary>
		/// Boolean TryGetCertHash(System.Security.Cryptography.HashAlgorithmName, System.Span`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_TryGetCertHash_HashAlgorithmName_Span_d_Byte_p__Out_Int32;
		public virtual RMethod RTryGetCertHash_HashAlgorithmName_Span_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_TryGetCertHash_HashAlgorithmName_Span_d_Byte_p__Out_Int32 == null)
				{
					r_TryGetCertHash_HashAlgorithmName_Span_d_Byte_p__Out_Int32 = new(this, "TryGetCertHash", 0, typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_TryGetCertHash_HashAlgorithmName_Span_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_TryGetCertHash_HashAlgorithmName_Span_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// System.String GetCertHashString()
		/// </summary>
		protected RMethod r_GetCertHashString;
		public virtual RMethod RGetCertHashString
		{
			get
			{
				if(r_GetCertHashString == null)
				{
					r_GetCertHashString = new(this, "GetCertHashString", 0);
					r_GetCertHashString.SetBelong(this.instance);
				}
				return r_GetCertHashString;
			}
		}

		/// <summary>
		/// System.String GetCertHashString(System.Security.Cryptography.HashAlgorithmName)
		/// </summary>
		protected RMethod r_GetCertHashString_HashAlgorithmName;
		public virtual RMethod RGetCertHashString_HashAlgorithmName
		{
			get
			{
				if(r_GetCertHashString_HashAlgorithmName == null)
				{
					r_GetCertHashString_HashAlgorithmName = new(this, "GetCertHashString", 0, typeof(System.Security.Cryptography.HashAlgorithmName));
					r_GetCertHashString_HashAlgorithmName.SetBelong(this.instance);
				}
				return r_GetCertHashString_HashAlgorithmName;
			}
		}

		/// <summary>
		/// Byte[] GetRawCertHash()
		/// </summary>
		protected RMethod r_GetRawCertHash;
		public virtual RMethod RGetRawCertHash
		{
			get
			{
				if(r_GetRawCertHash == null)
				{
					r_GetRawCertHash = new(this, "GetRawCertHash", 0);
					r_GetRawCertHash.SetBelong(this.instance);
				}
				return r_GetRawCertHash;
			}
		}

		/// <summary>
		/// System.String GetEffectiveDateString()
		/// </summary>
		protected RMethod r_GetEffectiveDateString;
		public virtual RMethod RGetEffectiveDateString
		{
			get
			{
				if(r_GetEffectiveDateString == null)
				{
					r_GetEffectiveDateString = new(this, "GetEffectiveDateString", 0);
					r_GetEffectiveDateString.SetBelong(this.instance);
				}
				return r_GetEffectiveDateString;
			}
		}

		/// <summary>
		/// System.String GetExpirationDateString()
		/// </summary>
		protected RMethod r_GetExpirationDateString;
		public virtual RMethod RGetExpirationDateString
		{
			get
			{
				if(r_GetExpirationDateString == null)
				{
					r_GetExpirationDateString = new(this, "GetExpirationDateString", 0);
					r_GetExpirationDateString.SetBelong(this.instance);
				}
				return r_GetExpirationDateString;
			}
		}

		/// <summary>
		/// System.String GetFormat()
		/// </summary>
		protected RMethod r_GetFormat;
		public virtual RMethod RGetFormat
		{
			get
			{
				if(r_GetFormat == null)
				{
					r_GetFormat = new(this, "GetFormat", 0);
					r_GetFormat.SetBelong(this.instance);
				}
				return r_GetFormat;
			}
		}

		/// <summary>
		/// System.String GetPublicKeyString()
		/// </summary>
		protected RMethod r_GetPublicKeyString;
		public virtual RMethod RGetPublicKeyString
		{
			get
			{
				if(r_GetPublicKeyString == null)
				{
					r_GetPublicKeyString = new(this, "GetPublicKeyString", 0);
					r_GetPublicKeyString.SetBelong(this.instance);
				}
				return r_GetPublicKeyString;
			}
		}

		/// <summary>
		/// Byte[] GetRawCertData()
		/// </summary>
		protected RMethod r_GetRawCertData;
		public virtual RMethod RGetRawCertData
		{
			get
			{
				if(r_GetRawCertData == null)
				{
					r_GetRawCertData = new(this, "GetRawCertData", 0);
					r_GetRawCertData.SetBelong(this.instance);
				}
				return r_GetRawCertData;
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
		/// System.String GetKeyAlgorithm()
		/// </summary>
		protected RMethod r_GetKeyAlgorithm;
		public virtual RMethod RGetKeyAlgorithm
		{
			get
			{
				if(r_GetKeyAlgorithm == null)
				{
					r_GetKeyAlgorithm = new(this, "GetKeyAlgorithm", 0);
					r_GetKeyAlgorithm.SetBelong(this.instance);
				}
				return r_GetKeyAlgorithm;
			}
		}

		/// <summary>
		/// Byte[] GetKeyAlgorithmParameters()
		/// </summary>
		protected RMethod r_GetKeyAlgorithmParameters;
		public virtual RMethod RGetKeyAlgorithmParameters
		{
			get
			{
				if(r_GetKeyAlgorithmParameters == null)
				{
					r_GetKeyAlgorithmParameters = new(this, "GetKeyAlgorithmParameters", 0);
					r_GetKeyAlgorithmParameters.SetBelong(this.instance);
				}
				return r_GetKeyAlgorithmParameters;
			}
		}

		/// <summary>
		/// System.String GetKeyAlgorithmParametersString()
		/// </summary>
		protected RMethod r_GetKeyAlgorithmParametersString;
		public virtual RMethod RGetKeyAlgorithmParametersString
		{
			get
			{
				if(r_GetKeyAlgorithmParametersString == null)
				{
					r_GetKeyAlgorithmParametersString = new(this, "GetKeyAlgorithmParametersString", 0);
					r_GetKeyAlgorithmParametersString.SetBelong(this.instance);
				}
				return r_GetKeyAlgorithmParametersString;
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
		/// Byte[] GetSerialNumber()
		/// </summary>
		protected RMethod r_GetSerialNumber;
		public virtual RMethod RGetSerialNumber
		{
			get
			{
				if(r_GetSerialNumber == null)
				{
					r_GetSerialNumber = new(this, "GetSerialNumber", 0);
					r_GetSerialNumber.SetBelong(this.instance);
				}
				return r_GetSerialNumber;
			}
		}

		/// <summary>
		/// System.String GetSerialNumberString()
		/// </summary>
		protected RMethod r_GetSerialNumberString;
		public virtual RMethod RGetSerialNumberString
		{
			get
			{
				if(r_GetSerialNumberString == null)
				{
					r_GetSerialNumberString = new(this, "GetSerialNumberString", 0);
					r_GetSerialNumberString.SetBelong(this.instance);
				}
				return r_GetSerialNumberString;
			}
		}

		/// <summary>
		/// Byte[] GetRawSerialNumber()
		/// </summary>
		protected RMethod r_GetRawSerialNumber;
		public virtual RMethod RGetRawSerialNumber
		{
			get
			{
				if(r_GetRawSerialNumber == null)
				{
					r_GetRawSerialNumber = new(this, "GetRawSerialNumber", 0);
					r_GetRawSerialNumber.SetBelong(this.instance);
				}
				return r_GetRawSerialNumber;
			}
		}

		/// <summary>
		/// System.String GetName()
		/// </summary>
		protected RMethod r_GetName;
		public virtual RMethod RGetName
		{
			get
			{
				if(r_GetName == null)
				{
					r_GetName = new(this, "GetName", 0);
					r_GetName.SetBelong(this.instance);
				}
				return r_GetName;
			}
		}

		/// <summary>
		/// System.String GetIssuerName()
		/// </summary>
		protected RMethod r_GetIssuerName;
		public virtual RMethod RGetIssuerName
		{
			get
			{
				if(r_GetIssuerName == null)
				{
					r_GetIssuerName = new(this, "GetIssuerName", 0);
					r_GetIssuerName.SetBelong(this.instance);
				}
				return r_GetIssuerName;
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
		/// System.String ToString(Boolean)
		/// </summary>
		protected RMethod r_ToString_Boolean;
		public virtual RMethod RToString_Boolean
		{
			get
			{
				if(r_ToString_Boolean == null)
				{
					r_ToString_Boolean = new(this, "ToString", 0, typeof(System.Boolean));
					r_ToString_Boolean.SetBelong(this.instance);
				}
				return r_ToString_Boolean;
			}
		}

		/// <summary>
		/// Void Import(Byte[])
		/// </summary>
		protected RMethod r_Import_ByteArray;
		public virtual RMethod RImport_ByteArray
		{
			get
			{
				if(r_Import_ByteArray == null)
				{
					r_Import_ByteArray = new(this, "Import", 0, typeof(System.Byte).MakeArrayType());
					r_Import_ByteArray.SetBelong(this.instance);
				}
				return r_Import_ByteArray;
			}
		}

		/// <summary>
		/// Void Import(Byte[], System.String, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags)
		/// </summary>
		protected RMethod r_Import_ByteArray_String_X509KeyStorageFlags;
		public virtual RMethod RImport_ByteArray_String_X509KeyStorageFlags
		{
			get
			{
				if(r_Import_ByteArray_String_X509KeyStorageFlags == null)
				{
					r_Import_ByteArray_String_X509KeyStorageFlags = new(this, "Import", 0, typeof(System.Byte).MakeArrayType(), typeof(System.String), typeof(System.Security.Cryptography.X509Certificates.X509KeyStorageFlags));
					r_Import_ByteArray_String_X509KeyStorageFlags.SetBelong(this.instance);
				}
				return r_Import_ByteArray_String_X509KeyStorageFlags;
			}
		}

		/// <summary>
		/// Void Import(Byte[], System.Security.SecureString, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags)
		/// </summary>
		protected RMethod r_Import_ByteArray_SecureString_X509KeyStorageFlags;
		public virtual RMethod RImport_ByteArray_SecureString_X509KeyStorageFlags
		{
			get
			{
				if(r_Import_ByteArray_SecureString_X509KeyStorageFlags == null)
				{
					r_Import_ByteArray_SecureString_X509KeyStorageFlags = new(this, "Import", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Security.SecureString), typeof(System.Security.Cryptography.X509Certificates.X509KeyStorageFlags));
					r_Import_ByteArray_SecureString_X509KeyStorageFlags.SetBelong(this.instance);
				}
				return r_Import_ByteArray_SecureString_X509KeyStorageFlags;
			}
		}

		/// <summary>
		/// Void Import(System.String)
		/// </summary>
		protected RMethod r_Import_String;
		public virtual RMethod RImport_String
		{
			get
			{
				if(r_Import_String == null)
				{
					r_Import_String = new(this, "Import", 0, typeof(System.String));
					r_Import_String.SetBelong(this.instance);
				}
				return r_Import_String;
			}
		}

		/// <summary>
		/// Void Import(System.String, System.String, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags)
		/// </summary>
		protected RMethod r_Import_String_String_X509KeyStorageFlags;
		public virtual RMethod RImport_String_String_X509KeyStorageFlags
		{
			get
			{
				if(r_Import_String_String_X509KeyStorageFlags == null)
				{
					r_Import_String_String_X509KeyStorageFlags = new(this, "Import", 0, typeof(System.String), typeof(System.String), typeof(System.Security.Cryptography.X509Certificates.X509KeyStorageFlags));
					r_Import_String_String_X509KeyStorageFlags.SetBelong(this.instance);
				}
				return r_Import_String_String_X509KeyStorageFlags;
			}
		}

		/// <summary>
		/// Void Import(System.String, System.Security.SecureString, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags)
		/// </summary>
		protected RMethod r_Import_String_SecureString_X509KeyStorageFlags;
		public virtual RMethod RImport_String_SecureString_X509KeyStorageFlags
		{
			get
			{
				if(r_Import_String_SecureString_X509KeyStorageFlags == null)
				{
					r_Import_String_SecureString_X509KeyStorageFlags = new(this, "Import", 0, typeof(System.String), typeof(System.Security.SecureString), typeof(System.Security.Cryptography.X509Certificates.X509KeyStorageFlags));
					r_Import_String_SecureString_X509KeyStorageFlags.SetBelong(this.instance);
				}
				return r_Import_String_SecureString_X509KeyStorageFlags;
			}
		}

		/// <summary>
		/// System.DateTime GetNotAfter()
		/// </summary>
		protected RMethod r_GetNotAfter;
		public virtual RMethod RGetNotAfter
		{
			get
			{
				if(r_GetNotAfter == null)
				{
					r_GetNotAfter = new(this, "GetNotAfter", 0);
					r_GetNotAfter.SetBelong(this.instance);
				}
				return r_GetNotAfter;
			}
		}

		/// <summary>
		/// System.DateTime GetNotBefore()
		/// </summary>
		protected RMethod r_GetNotBefore;
		public virtual RMethod RGetNotBefore
		{
			get
			{
				if(r_GetNotBefore == null)
				{
					r_GetNotBefore = new(this, "GetNotBefore", 0);
					r_GetNotBefore.SetBelong(this.instance);
				}
				return r_GetNotBefore;
			}
		}

		/// <summary>
		/// System.String FormatDate(System.DateTime)
		/// </summary>
		protected static RMethod r_FormatDate_DateTime;
		public static RMethod RFormatDate_DateTime
		{
			get
			{
				if(r_FormatDate_DateTime == null)
				{
					r_FormatDate_DateTime = new(typeof(System.Security.Cryptography.X509Certificates.X509Certificate), "FormatDate", 0, typeof(System.DateTime));
					r_FormatDate_DateTime.SetBelong(null);
				}
				return r_FormatDate_DateTime;
			}
		}

		/// <summary>
		/// Void ValidateKeyStorageFlags(System.Security.Cryptography.X509Certificates.X509KeyStorageFlags)
		/// </summary>
		protected static RMethod r_ValidateKeyStorageFlags_X509KeyStorageFlags;
		public static RMethod RValidateKeyStorageFlags_X509KeyStorageFlags
		{
			get
			{
				if(r_ValidateKeyStorageFlags_X509KeyStorageFlags == null)
				{
					r_ValidateKeyStorageFlags_X509KeyStorageFlags = new(typeof(System.Security.Cryptography.X509Certificates.X509Certificate), "ValidateKeyStorageFlags", 0, typeof(System.Security.Cryptography.X509Certificates.X509KeyStorageFlags));
					r_ValidateKeyStorageFlags_X509KeyStorageFlags.SetBelong(null);
				}
				return r_ValidateKeyStorageFlags_X509KeyStorageFlags;
			}
		}

		/// <summary>
		/// Void VerifyContentType(System.Security.Cryptography.X509Certificates.X509ContentType)
		/// </summary>
		protected RMethod r_VerifyContentType_X509ContentType;
		public virtual RMethod RVerifyContentType_X509ContentType
		{
			get
			{
				if(r_VerifyContentType_X509ContentType == null)
				{
					r_VerifyContentType_X509ContentType = new(this, "VerifyContentType", 0, typeof(System.Security.Cryptography.X509Certificates.X509ContentType));
					r_VerifyContentType_X509ContentType.SetBelong(this.instance);
				}
				return r_VerifyContentType_X509ContentType;
			}
		}

		/// <summary>
		/// Void ImportHandle(System.Security.Cryptography.X509Certificates.X509CertificateImpl)
		/// </summary>
		protected RMethod r_ImportHandle_X509CertificateImpl;
		public virtual RMethod RImportHandle_X509CertificateImpl
		{
			get
			{
				if(r_ImportHandle_X509CertificateImpl == null)
				{
					r_ImportHandle_X509CertificateImpl = new(this, "ImportHandle", 0,  ReflectionUtils.GetType("System.Security.Cryptography.X509Certificates.X509CertificateImpl"));
					r_ImportHandle_X509CertificateImpl.SetBelong(this.instance);
				}
				return r_ImportHandle_X509CertificateImpl;
			}
		}

		/// <summary>
		/// Void ThrowIfInvalid()
		/// </summary>
		protected RMethod r_ThrowIfInvalid;
		public virtual RMethod RThrowIfInvalid
		{
			get
			{
				if(r_ThrowIfInvalid == null)
				{
					r_ThrowIfInvalid = new(this, "ThrowIfInvalid", 0);
					r_ThrowIfInvalid.SetBelong(this.instance);
				}
				return r_ThrowIfInvalid;
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


        public static System.Security.Cryptography.X509Certificates.X509Certificate CreateFromCertFile(System.String @filename)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filename};
            var ___result = RCreateFromCertFile_String.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.X509Certificates.X509Certificate)___result;
        }


        public static System.Security.Cryptography.X509Certificates.X509Certificate CreateFromSignedFile(System.String @filename)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filename};
            var ___result = RCreateFromSignedFile_String.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.X509Certificates.X509Certificate)___result;
        }


        public virtual void System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization(System.Object @sender)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender};
            var ___result = RSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Security.Cryptography.X509Certificates.X509Certificate @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_X509Certificate.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Byte[] Export(System.Security.Cryptography.X509Certificates.X509ContentType @contentType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@contentType};
            var ___result = RExport_X509ContentType.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] Export(System.Security.Cryptography.X509Certificates.X509ContentType @contentType, System.String @password)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@contentType, @password};
            var ___result = RExport_X509ContentType_String.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] Export(System.Security.Cryptography.X509Certificates.X509ContentType @contentType, System.Security.SecureString @password)
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


        public virtual System.Byte[] GetCertHash(System.Security.Cryptography.HashAlgorithmName @hashAlgorithm)
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


        public virtual System.String GetCertHashString(System.Security.Cryptography.HashAlgorithmName @hashAlgorithm)
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


        public virtual System.String ToString(System.Boolean @fVerbose)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fVerbose};
            var ___result = RToString_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Import(System.Byte[] @rawData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rawData};
            var ___result = RImport_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Import(System.Byte[] @rawData, System.String @password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags @keyStorageFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rawData, @password, @keyStorageFlags};
            var ___result = RImport_ByteArray_String_X509KeyStorageFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Import(System.Byte[] @rawData, System.Security.SecureString @password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags @keyStorageFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rawData, @password, @keyStorageFlags};
            var ___result = RImport_ByteArray_SecureString_X509KeyStorageFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Import(System.String @fileName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileName};
            var ___result = RImport_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Import(System.String @fileName, System.String @password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags @keyStorageFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileName, @password, @keyStorageFlags};
            var ___result = RImport_String_String_X509KeyStorageFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Import(System.String @fileName, System.Security.SecureString @password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags @keyStorageFlags)
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


        public static System.String FormatDate(System.DateTime @date)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@date};
            var ___result = RFormatDate_DateTime.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static void ValidateKeyStorageFlags(System.Security.Cryptography.X509Certificates.X509KeyStorageFlags @keyStorageFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyStorageFlags};
            var ___result = RValidateKeyStorageFlags_X509KeyStorageFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void VerifyContentType(System.Security.Cryptography.X509Certificates.X509ContentType @contentType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@contentType};
            var ___result = RVerifyContentType_X509ContentType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ImportHandle(RSystem.RSecurity.RCryptography.RX509Certificates.RX509CertificateImpl @impl)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@impl.Value};
            var ___result = RImportHandle_X509CertificateImpl.Invoke(___genericsType, ___parameters);

            
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
