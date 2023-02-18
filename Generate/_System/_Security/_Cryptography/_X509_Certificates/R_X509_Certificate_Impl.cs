
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RX509Certificates
{
	/// <summary>
	/// System.Security.Cryptography.X509Certificates.X509CertificateImpl
	/// </summary>
    public partial class RX509CertificateImpl : RMember //
    {

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
					r_PIsValid.SetBelong(this.GetValue());
				}
				return r_PIsValid;
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
					r_PHandle.SetBelong(this.GetValue());
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
					r_PIssuer.SetBelong(this.GetValue());
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
					r_PSubject.SetBelong(this.GetValue());
				}
				return r_PSubject;
			}
		}

		/// <summary>
		/// System.String LegacyIssuer
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PLegacyIssuer;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPLegacyIssuer
		{
			get
			{
				if(r_PLegacyIssuer == null)
				{
					r_PLegacyIssuer = new(this, "LegacyIssuer", -1);
					r_PLegacyIssuer.SetBelong(this.GetValue());
				}
				return r_PLegacyIssuer;
			}
		}

		/// <summary>
		/// System.String LegacySubject
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PLegacySubject;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPLegacySubject
		{
			get
			{
				if(r_PLegacySubject == null)
				{
					r_PLegacySubject = new(this, "LegacySubject", -1);
					r_PLegacySubject.SetBelong(this.GetValue());
				}
				return r_PLegacySubject;
			}
		}

		/// <summary>
		/// Byte[] RawData
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RByte> r_PRawData;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RByte> RPRawData
		{
			get
			{
				if(r_PRawData == null)
				{
					r_PRawData = new(this, "RawData", -1);
					r_PRawData.SetBelong(this.GetValue());
				}
				return r_PRawData;
			}
		}

		/// <summary>
		/// System.DateTime NotAfter
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RDateTime r_PNotAfter;
		public virtual Hvak.Editor.Refleaction.RSystem.RDateTime RPNotAfter
		{
			get
			{
				if(r_PNotAfter == null)
				{
					r_PNotAfter = new(this, "NotAfter", -1);
					r_PNotAfter.SetBelong(this.GetValue());
				}
				return r_PNotAfter;
			}
		}

		/// <summary>
		/// System.DateTime NotBefore
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RDateTime r_PNotBefore;
		public virtual Hvak.Editor.Refleaction.RSystem.RDateTime RPNotBefore
		{
			get
			{
				if(r_PNotBefore == null)
				{
					r_PNotBefore = new(this, "NotBefore", -1);
					r_PNotBefore.SetBelong(this.GetValue());
				}
				return r_PNotBefore;
			}
		}

		/// <summary>
		/// Byte[] Thumbprint
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RByte> r_PThumbprint;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RByte> RPThumbprint
		{
			get
			{
				if(r_PThumbprint == null)
				{
					r_PThumbprint = new(this, "Thumbprint", -1);
					r_PThumbprint.SetBelong(this.GetValue());
				}
				return r_PThumbprint;
			}
		}

		/// <summary>
		/// System.String KeyAlgorithm
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PKeyAlgorithm;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPKeyAlgorithm
		{
			get
			{
				if(r_PKeyAlgorithm == null)
				{
					r_PKeyAlgorithm = new(this, "KeyAlgorithm", -1);
					r_PKeyAlgorithm.SetBelong(this.GetValue());
				}
				return r_PKeyAlgorithm;
			}
		}

		/// <summary>
		/// Byte[] KeyAlgorithmParameters
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RByte> r_PKeyAlgorithmParameters;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RByte> RPKeyAlgorithmParameters
		{
			get
			{
				if(r_PKeyAlgorithmParameters == null)
				{
					r_PKeyAlgorithmParameters = new(this, "KeyAlgorithmParameters", -1);
					r_PKeyAlgorithmParameters.SetBelong(this.GetValue());
				}
				return r_PKeyAlgorithmParameters;
			}
		}

		/// <summary>
		/// Byte[] PublicKeyValue
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RByte> r_PPublicKeyValue;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RByte> RPPublicKeyValue
		{
			get
			{
				if(r_PPublicKeyValue == null)
				{
					r_PPublicKeyValue = new(this, "PublicKeyValue", -1);
					r_PPublicKeyValue.SetBelong(this.GetValue());
				}
				return r_PPublicKeyValue;
			}
		}

		/// <summary>
		/// Byte[] SerialNumber
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RByte> r_PSerialNumber;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RByte> RPSerialNumber
		{
			get
			{
				if(r_PSerialNumber == null)
				{
					r_PSerialNumber = new(this, "SerialNumber", -1);
					r_PSerialNumber.SetBelong(this.GetValue());
				}
				return r_PSerialNumber;
			}
		}

		/// <summary>
		/// Boolean HasPrivateKey
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PHasPrivateKey;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPHasPrivateKey
		{
			get
			{
				if(r_PHasPrivateKey == null)
				{
					r_PHasPrivateKey = new(this, "HasPrivateKey", -1);
					r_PHasPrivateKey.SetBelong(this.GetValue());
				}
				return r_PHasPrivateKey;
			}
		}

		/// <summary>
		/// IntPtr GetNativeAppleCertificate()
		/// </summary>
		protected RMethod r_MGetNativeAppleCertificate;
		public virtual RMethod RMGetNativeAppleCertificate
		{
			get
			{
				if(r_MGetNativeAppleCertificate == null)
				{
					r_MGetNativeAppleCertificate = new(this, "GetNativeAppleCertificate", 0);
					r_MGetNativeAppleCertificate.SetBelong(this.GetValue());
				}
				return r_MGetNativeAppleCertificate;
			}
		}

		/// <summary>
		/// Void ThrowIfContextInvalid()
		/// </summary>
		protected RMethod r_MThrowIfContextInvalid;
		public virtual RMethod RMThrowIfContextInvalid
		{
			get
			{
				if(r_MThrowIfContextInvalid == null)
				{
					r_MThrowIfContextInvalid = new(this, "ThrowIfContextInvalid", 0);
					r_MThrowIfContextInvalid.SetBelong(this.GetValue());
				}
				return r_MThrowIfContextInvalid;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.X509Certificates.X509CertificateImpl Clone()
		/// </summary>
		protected RMethod r_MClone;
		public virtual RMethod RMClone
		{
			get
			{
				if(r_MClone == null)
				{
					r_MClone = new(this, "Clone", 0);
					r_MClone.SetBelong(this.GetValue());
				}
				return r_MClone;
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
					r_MGetHashCode.SetBelong(this.GetValue());
				}
				return r_MGetHashCode;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Security.Cryptography.X509Certificates.X509CertificateImpl, Boolean ByRef)
		/// </summary>
		protected RMethod r_MEquals_X509CertificateImpl_Out_Boolean;
		public virtual RMethod RMEquals_X509CertificateImpl_Out_Boolean
		{
			get
			{
				if(r_MEquals_X509CertificateImpl_Out_Boolean == null)
				{
					r_MEquals_X509CertificateImpl_Out_Boolean = new(this, "Equals", 0,  ReflectionUtils.GetType("System.Security.Cryptography.X509Certificates.X509CertificateImpl"), typeof(System.Boolean).MakeByRefType());
					r_MEquals_X509CertificateImpl_Out_Boolean.SetBelong(this.GetValue());
				}
				return r_MEquals_X509CertificateImpl_Out_Boolean;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSA GetRSAPrivateKey()
		/// </summary>
		protected RMethod r_MGetRSAPrivateKey;
		public virtual RMethod RMGetRSAPrivateKey
		{
			get
			{
				if(r_MGetRSAPrivateKey == null)
				{
					r_MGetRSAPrivateKey = new(this, "GetRSAPrivateKey", 0);
					r_MGetRSAPrivateKey.SetBelong(this.GetValue());
				}
				return r_MGetRSAPrivateKey;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.DSA GetDSAPrivateKey()
		/// </summary>
		protected RMethod r_MGetDSAPrivateKey;
		public virtual RMethod RMGetDSAPrivateKey
		{
			get
			{
				if(r_MGetDSAPrivateKey == null)
				{
					r_MGetDSAPrivateKey = new(this, "GetDSAPrivateKey", 0);
					r_MGetDSAPrivateKey.SetBelong(this.GetValue());
				}
				return r_MGetDSAPrivateKey;
			}
		}

		/// <summary>
		/// Byte[] Export(System.Security.Cryptography.X509Certificates.X509ContentType, Microsoft.Win32.SafeHandles.SafePasswordHandle)
		/// </summary>
		protected RMethod r_MExport_X509ContentType_SafePasswordHandle;
		public virtual RMethod RMExport_X509ContentType_SafePasswordHandle
		{
			get
			{
				if(r_MExport_X509ContentType_SafePasswordHandle == null)
				{
					r_MExport_X509ContentType_SafePasswordHandle = new(this, "Export", 0, typeof(System.Security.Cryptography.X509Certificates.X509ContentType),  ReflectionUtils.GetType("Microsoft.Win32.SafeHandles.SafePasswordHandle"));
					r_MExport_X509ContentType_SafePasswordHandle.SetBelong(this.GetValue());
				}
				return r_MExport_X509ContentType_SafePasswordHandle;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.X509Certificates.X509CertificateImpl CopyWithPrivateKey(System.Security.Cryptography.RSA)
		/// </summary>
		protected RMethod r_MCopyWithPrivateKey_RSA;
		public virtual RMethod RMCopyWithPrivateKey_RSA
		{
			get
			{
				if(r_MCopyWithPrivateKey_RSA == null)
				{
					r_MCopyWithPrivateKey_RSA = new(this, "CopyWithPrivateKey", 0, typeof(System.Security.Cryptography.RSA));
					r_MCopyWithPrivateKey_RSA.SetBelong(this.GetValue());
				}
				return r_MCopyWithPrivateKey_RSA;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.X509Certificates.X509Certificate CreateCertificate()
		/// </summary>
		protected RMethod r_MCreateCertificate;
		public virtual RMethod RMCreateCertificate
		{
			get
			{
				if(r_MCreateCertificate == null)
				{
					r_MCreateCertificate = new(this, "CreateCertificate", 0);
					r_MCreateCertificate.SetBelong(this.GetValue());
				}
				return r_MCreateCertificate;
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
					r_MEquals_Object.SetBelong(this.GetValue());
				}
				return r_MEquals_Object;
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
					r_MDispose.SetBelong(this.GetValue());
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
					r_MDispose_Boolean.SetBelong(this.GetValue());
				}
				return r_MDispose_Boolean;
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
				}
				return r_MMemberwiseClone;
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
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
            var ___result = RMGetNativeAppleCertificate.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual void ThrowIfContextInvalid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMThrowIfContextInvalid.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RX509Certificates.RX509CertificateImpl Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClone.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RX509Certificates.RX509CertificateImpl(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RX509Certificates.RX509CertificateImpl @other, out System.Boolean @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value, @result};
            var ___result = RMEquals_X509CertificateImpl_Out_Boolean.Invoke(___genericsType, ___parameters);
			@result = (System.Boolean)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Security.Cryptography.RSA GetRSAPrivateKey()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRSAPrivateKey.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.RSA)___result;
        }


        public virtual System.Security.Cryptography.DSA GetDSAPrivateKey()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDSAPrivateKey.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.DSA)___result;
        }


        public virtual System.Byte[] Export(System.Security.Cryptography.X509Certificates.X509ContentType @contentType, Hvak.Editor.Refleaction.RMicrosoft.RWin32.RSafeHandles.RSafePasswordHandle @password)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@contentType, @password.Value};
            var ___result = RMExport_X509ContentType_SafePasswordHandle.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RX509Certificates.RX509CertificateImpl CopyWithPrivateKey(System.Security.Cryptography.RSA @privateKey)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@privateKey};
            var ___result = RMCopyWithPrivateKey_RSA.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RX509Certificates.RX509CertificateImpl(___result);
        }


        public virtual System.Security.Cryptography.X509Certificates.X509Certificate CreateCertificate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateCertificate.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.X509Certificates.X509Certificate)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
