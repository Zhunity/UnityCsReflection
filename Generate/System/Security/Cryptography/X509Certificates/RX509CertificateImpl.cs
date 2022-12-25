using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RX509Certificates
{
	/// <summary>
	/// System.Security.Cryptography.X509Certificates.X509CertificateImpl
	/// </summary>
    public partial class RX509CertificateImpl : RMember //
    {

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
		/// System.String LegacyIssuer
		/// </summary>
		protected RProperty r_LegacyIssuer;
		public virtual RProperty RLegacyIssuer
		{
			get
			{
				if(r_LegacyIssuer == null)
				{
					r_LegacyIssuer = new(this, "LegacyIssuer", -1);
					r_LegacyIssuer.SetBelong(this.instance);
				}
				return r_LegacyIssuer;
			}
		}

		/// <summary>
		/// System.String LegacySubject
		/// </summary>
		protected RProperty r_LegacySubject;
		public virtual RProperty RLegacySubject
		{
			get
			{
				if(r_LegacySubject == null)
				{
					r_LegacySubject = new(this, "LegacySubject", -1);
					r_LegacySubject.SetBelong(this.instance);
				}
				return r_LegacySubject;
			}
		}

		/// <summary>
		/// Byte[] RawData
		/// </summary>
		protected RPropertyArray<RProperty> r_RawData;
		public virtual RPropertyArray<RProperty> RawData
		{
			get
			{
				if(r_RawData == null)
				{
					r_RawData = new(this, "RawData", -1);
					r_RawData.SetBelong(this.instance);
				}
				return r_RawData;
			}
		}

		/// <summary>
		/// System.DateTime NotAfter
		/// </summary>
		protected RSystem.RDateTime r_NotAfter;
		public virtual RSystem.RDateTime RNotAfter
		{
			get
			{
				if(r_NotAfter == null)
				{
					r_NotAfter = new(this, "NotAfter", -1);
					r_NotAfter.SetBelong(this.instance);
				}
				return r_NotAfter;
			}
		}

		/// <summary>
		/// System.DateTime NotBefore
		/// </summary>
		protected RSystem.RDateTime r_NotBefore;
		public virtual RSystem.RDateTime RNotBefore
		{
			get
			{
				if(r_NotBefore == null)
				{
					r_NotBefore = new(this, "NotBefore", -1);
					r_NotBefore.SetBelong(this.instance);
				}
				return r_NotBefore;
			}
		}

		/// <summary>
		/// Byte[] Thumbprint
		/// </summary>
		protected RPropertyArray<RProperty> r_Thumbprint;
		public virtual RPropertyArray<RProperty> RThumbprint
		{
			get
			{
				if(r_Thumbprint == null)
				{
					r_Thumbprint = new(this, "Thumbprint", -1);
					r_Thumbprint.SetBelong(this.instance);
				}
				return r_Thumbprint;
			}
		}

		/// <summary>
		/// System.String KeyAlgorithm
		/// </summary>
		protected RProperty r_KeyAlgorithm;
		public virtual RProperty RKeyAlgorithm
		{
			get
			{
				if(r_KeyAlgorithm == null)
				{
					r_KeyAlgorithm = new(this, "KeyAlgorithm", -1);
					r_KeyAlgorithm.SetBelong(this.instance);
				}
				return r_KeyAlgorithm;
			}
		}

		/// <summary>
		/// Byte[] KeyAlgorithmParameters
		/// </summary>
		protected RPropertyArray<RProperty> r_KeyAlgorithmParameters;
		public virtual RPropertyArray<RProperty> RKeyAlgorithmParameters
		{
			get
			{
				if(r_KeyAlgorithmParameters == null)
				{
					r_KeyAlgorithmParameters = new(this, "KeyAlgorithmParameters", -1);
					r_KeyAlgorithmParameters.SetBelong(this.instance);
				}
				return r_KeyAlgorithmParameters;
			}
		}

		/// <summary>
		/// Byte[] PublicKeyValue
		/// </summary>
		protected RPropertyArray<RProperty> r_PublicKeyValue;
		public virtual RPropertyArray<RProperty> RPublicKeyValue
		{
			get
			{
				if(r_PublicKeyValue == null)
				{
					r_PublicKeyValue = new(this, "PublicKeyValue", -1);
					r_PublicKeyValue.SetBelong(this.instance);
				}
				return r_PublicKeyValue;
			}
		}

		/// <summary>
		/// Byte[] SerialNumber
		/// </summary>
		protected RPropertyArray<RProperty> r_SerialNumber;
		public virtual RPropertyArray<RProperty> RSerialNumber
		{
			get
			{
				if(r_SerialNumber == null)
				{
					r_SerialNumber = new(this, "SerialNumber", -1);
					r_SerialNumber.SetBelong(this.instance);
				}
				return r_SerialNumber;
			}
		}

		/// <summary>
		/// Boolean HasPrivateKey
		/// </summary>
		protected RProperty r_HasPrivateKey;
		public virtual RProperty RHasPrivateKey
		{
			get
			{
				if(r_HasPrivateKey == null)
				{
					r_HasPrivateKey = new(this, "HasPrivateKey", -1);
					r_HasPrivateKey.SetBelong(this.instance);
				}
				return r_HasPrivateKey;
			}
		}

		/// <summary>
		/// IntPtr GetNativeAppleCertificate()
		/// </summary>
		protected RMethod r_RGetNativeAppleCertificate;
		public virtual RMethod RGetNativeAppleCertificate
		{
			get
			{
				if(r_RGetNativeAppleCertificate == null)
				{
					r_RGetNativeAppleCertificate = new(this, "GetNativeAppleCertificate", 0);
					r_RGetNativeAppleCertificate.SetBelong(this.instance);
				}
				return r_RGetNativeAppleCertificate;
			}
		}

		/// <summary>
		/// Void ThrowIfContextInvalid()
		/// </summary>
		protected RMethod r_RThrowIfContextInvalid;
		public virtual RMethod RThrowIfContextInvalid
		{
			get
			{
				if(r_RThrowIfContextInvalid == null)
				{
					r_RThrowIfContextInvalid = new(this, "ThrowIfContextInvalid", 0);
					r_RThrowIfContextInvalid.SetBelong(this.instance);
				}
				return r_RThrowIfContextInvalid;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.X509Certificates.X509CertificateImpl Clone()
		/// </summary>
		protected RMethod r_RClone;
		public virtual RMethod RClone
		{
			get
			{
				if(r_RClone == null)
				{
					r_RClone = new(this, "Clone", 0);
					r_RClone.SetBelong(this.instance);
				}
				return r_RClone;
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
		/// Boolean Equals(System.Security.Cryptography.X509Certificates.X509CertificateImpl, Boolean ByRef)
		/// </summary>
		protected RMethod r_REquals_X509CertificateImpl_Out_Boolean;
		public virtual RMethod REquals_X509CertificateImpl_Out_Boolean
		{
			get
			{
				if(r_REquals_X509CertificateImpl_Out_Boolean == null)
				{
					r_REquals_X509CertificateImpl_Out_Boolean = new(this, "Equals", 0,  ReleactionUtils.GetType("System.Security.Cryptography.X509Certificates.X509CertificateImpl"), typeof(System.Boolean).MakeByRefType());
					r_REquals_X509CertificateImpl_Out_Boolean.SetBelong(this.instance);
				}
				return r_REquals_X509CertificateImpl_Out_Boolean;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSA GetRSAPrivateKey()
		/// </summary>
		protected RMethod r_RGetRSAPrivateKey;
		public virtual RMethod RGetRSAPrivateKey
		{
			get
			{
				if(r_RGetRSAPrivateKey == null)
				{
					r_RGetRSAPrivateKey = new(this, "GetRSAPrivateKey", 0);
					r_RGetRSAPrivateKey.SetBelong(this.instance);
				}
				return r_RGetRSAPrivateKey;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.DSA GetDSAPrivateKey()
		/// </summary>
		protected RMethod r_RGetDSAPrivateKey;
		public virtual RMethod RGetDSAPrivateKey
		{
			get
			{
				if(r_RGetDSAPrivateKey == null)
				{
					r_RGetDSAPrivateKey = new(this, "GetDSAPrivateKey", 0);
					r_RGetDSAPrivateKey.SetBelong(this.instance);
				}
				return r_RGetDSAPrivateKey;
			}
		}

		/// <summary>
		/// Byte[] Export(System.Security.Cryptography.X509Certificates.X509ContentType, Microsoft.Win32.SafeHandles.SafePasswordHandle)
		/// </summary>
		protected RMethod r_RExport_X509ContentType_SafePasswordHandle;
		public virtual RMethod RExport_X509ContentType_SafePasswordHandle
		{
			get
			{
				if(r_RExport_X509ContentType_SafePasswordHandle == null)
				{
					r_RExport_X509ContentType_SafePasswordHandle = new(this, "Export", 0, typeof(System.Security.Cryptography.X509Certificates.X509ContentType),  ReleactionUtils.GetType("Microsoft.Win32.SafeHandles.SafePasswordHandle"));
					r_RExport_X509ContentType_SafePasswordHandle.SetBelong(this.instance);
				}
				return r_RExport_X509ContentType_SafePasswordHandle;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.X509Certificates.X509CertificateImpl CopyWithPrivateKey(System.Security.Cryptography.RSA)
		/// </summary>
		protected RMethod r_RCopyWithPrivateKey_RSA;
		public virtual RMethod RCopyWithPrivateKey_RSA
		{
			get
			{
				if(r_RCopyWithPrivateKey_RSA == null)
				{
					r_RCopyWithPrivateKey_RSA = new(this, "CopyWithPrivateKey", 0, typeof(System.Security.Cryptography.RSA));
					r_RCopyWithPrivateKey_RSA.SetBelong(this.instance);
				}
				return r_RCopyWithPrivateKey_RSA;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.X509Certificates.X509Certificate CreateCertificate()
		/// </summary>
		protected RMethod r_RCreateCertificate;
		public virtual RMethod RCreateCertificate
		{
			get
			{
				if(r_RCreateCertificate == null)
				{
					r_RCreateCertificate = new(this, "CreateCertificate", 0);
					r_RCreateCertificate.SetBelong(this.instance);
				}
				return r_RCreateCertificate;
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


        public RX509CertificateImpl() : base("System.Security.Cryptography.X509Certificates.X509CertificateImpl")
        {
        }

        public RX509CertificateImpl(System.Object instance) : base("System.Security.Cryptography.X509Certificates.X509CertificateImpl")
		{
            SetInstance(instance);
		}

        public RX509CertificateImpl(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RX509CertificateImpl(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.IntPtr GetNativeAppleCertificate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetNativeAppleCertificate.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual void ThrowIfContextInvalid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RThrowIfContextInvalid.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }



        public virtual System.Security.Cryptography.RSA GetRSAPrivateKey()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRSAPrivateKey.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.RSA)___result;
        }


        public virtual System.Security.Cryptography.DSA GetDSAPrivateKey()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDSAPrivateKey.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.DSA)___result;
        }



        public virtual System.Object CopyWithPrivateKey(System.Security.Cryptography.RSA  @privateKey)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@privateKey};
            var ___result = RCopyWithPrivateKey_RSA.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Security.Cryptography.X509Certificates.X509Certificate CreateCertificate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateCertificate.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.X509Certificates.X509Certificate)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
