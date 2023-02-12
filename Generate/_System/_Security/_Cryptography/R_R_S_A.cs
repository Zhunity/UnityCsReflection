
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography
{
	/// <summary>
	/// System.Security.Cryptography.RSA
	/// </summary>
    public partial class RRSA : RMember //
    {

		/// <summary>
		/// System.Int32 KeySizeValue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FKeySizeValue;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFKeySizeValue
		{
			get
			{
				if(r_FKeySizeValue == null)
				{
					r_FKeySizeValue = new(this, "KeySizeValue");
					r_FKeySizeValue.SetBelong(this.instance);
				}
				return r_FKeySizeValue;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.KeySizes[] LegalKeySizesValue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RKeySizes> r_FLegalKeySizesValue;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RKeySizes> RFLegalKeySizesValue
		{
			get
			{
				if(r_FLegalKeySizesValue == null)
				{
					r_FLegalKeySizesValue = new(this, "LegalKeySizesValue");
					r_FLegalKeySizesValue.SetBelong(this.instance);
				}
				return r_FLegalKeySizesValue;
			}
		}

		/// <summary>
		/// System.String KeyExchangeAlgorithm
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PKeyExchangeAlgorithm;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPKeyExchangeAlgorithm
		{
			get
			{
				if(r_PKeyExchangeAlgorithm == null)
				{
					r_PKeyExchangeAlgorithm = new(this, "KeyExchangeAlgorithm", -1);
					r_PKeyExchangeAlgorithm.SetBelong(this.instance);
				}
				return r_PKeyExchangeAlgorithm;
			}
		}

		/// <summary>
		/// System.String SignatureAlgorithm
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PSignatureAlgorithm;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPSignatureAlgorithm
		{
			get
			{
				if(r_PSignatureAlgorithm == null)
				{
					r_PSignatureAlgorithm = new(this, "SignatureAlgorithm", -1);
					r_PSignatureAlgorithm.SetBelong(this.instance);
				}
				return r_PSignatureAlgorithm;
			}
		}

		/// <summary>
		/// Int32 KeySize
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PKeySize;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPKeySize
		{
			get
			{
				if(r_PKeySize == null)
				{
					r_PKeySize = new(this, "KeySize", -1);
					r_PKeySize.SetBelong(this.instance);
				}
				return r_PKeySize;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.KeySizes[] LegalKeySizes
		/// </summary>
		protected SMFrame.Editor.Refleaction.RPropertyArray<SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RKeySizes> r_PLegalKeySizes;
		public virtual SMFrame.Editor.Refleaction.RPropertyArray<SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RKeySizes> RPLegalKeySizes
		{
			get
			{
				if(r_PLegalKeySizes == null)
				{
					r_PLegalKeySizes = new(this, "LegalKeySizes", -1);
					r_PLegalKeySizes.SetBelong(this.instance);
				}
				return r_PLegalKeySizes;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSA Create()
		/// </summary>
		protected static RMethod r_MCreate;
		public static RMethod RMCreate
		{
			get
			{
				if(r_MCreate == null)
				{
					r_MCreate = new(typeof(System.Security.Cryptography.RSA), "Create", 0);
					r_MCreate.SetBelong(null);
				}
				return r_MCreate;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSA Create(System.String)
		/// </summary>
		protected static RMethod r_MCreate_String;
		public static RMethod RMCreate_String
		{
			get
			{
				if(r_MCreate_String == null)
				{
					r_MCreate_String = new(typeof(System.Security.Cryptography.RSA), "Create", 0, typeof(System.String));
					r_MCreate_String.SetBelong(null);
				}
				return r_MCreate_String;
			}
		}

		/// <summary>
		/// Byte[] Encrypt(Byte[], System.Security.Cryptography.RSAEncryptionPadding)
		/// </summary>
		protected RMethod r_MEncrypt_ByteArray_RSAEncryptionPadding;
		public virtual RMethod RMEncrypt_ByteArray_RSAEncryptionPadding
		{
			get
			{
				if(r_MEncrypt_ByteArray_RSAEncryptionPadding == null)
				{
					r_MEncrypt_ByteArray_RSAEncryptionPadding = new(this, "Encrypt", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Security.Cryptography.RSAEncryptionPadding));
					r_MEncrypt_ByteArray_RSAEncryptionPadding.SetBelong(this.instance);
				}
				return r_MEncrypt_ByteArray_RSAEncryptionPadding;
			}
		}

		/// <summary>
		/// Byte[] Decrypt(Byte[], System.Security.Cryptography.RSAEncryptionPadding)
		/// </summary>
		protected RMethod r_MDecrypt_ByteArray_RSAEncryptionPadding;
		public virtual RMethod RMDecrypt_ByteArray_RSAEncryptionPadding
		{
			get
			{
				if(r_MDecrypt_ByteArray_RSAEncryptionPadding == null)
				{
					r_MDecrypt_ByteArray_RSAEncryptionPadding = new(this, "Decrypt", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Security.Cryptography.RSAEncryptionPadding));
					r_MDecrypt_ByteArray_RSAEncryptionPadding.SetBelong(this.instance);
				}
				return r_MDecrypt_ByteArray_RSAEncryptionPadding;
			}
		}

		/// <summary>
		/// Byte[] SignHash(Byte[], System.Security.Cryptography.HashAlgorithmName, System.Security.Cryptography.RSASignaturePadding)
		/// </summary>
		protected RMethod r_MSignHash_ByteArray_HashAlgorithmName_RSASignaturePadding;
		public virtual RMethod RMSignHash_ByteArray_HashAlgorithmName_RSASignaturePadding
		{
			get
			{
				if(r_MSignHash_ByteArray_HashAlgorithmName_RSASignaturePadding == null)
				{
					r_MSignHash_ByteArray_HashAlgorithmName_RSASignaturePadding = new(this, "SignHash", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Security.Cryptography.RSASignaturePadding));
					r_MSignHash_ByteArray_HashAlgorithmName_RSASignaturePadding.SetBelong(this.instance);
				}
				return r_MSignHash_ByteArray_HashAlgorithmName_RSASignaturePadding;
			}
		}

		/// <summary>
		/// Boolean VerifyHash(Byte[], Byte[], System.Security.Cryptography.HashAlgorithmName, System.Security.Cryptography.RSASignaturePadding)
		/// </summary>
		protected RMethod r_MVerifyHash_ByteArray_ByteArray_HashAlgorithmName_RSASignaturePadding;
		public virtual RMethod RMVerifyHash_ByteArray_ByteArray_HashAlgorithmName_RSASignaturePadding
		{
			get
			{
				if(r_MVerifyHash_ByteArray_ByteArray_HashAlgorithmName_RSASignaturePadding == null)
				{
					r_MVerifyHash_ByteArray_ByteArray_HashAlgorithmName_RSASignaturePadding = new(this, "VerifyHash", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType(), typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Security.Cryptography.RSASignaturePadding));
					r_MVerifyHash_ByteArray_ByteArray_HashAlgorithmName_RSASignaturePadding.SetBelong(this.instance);
				}
				return r_MVerifyHash_ByteArray_ByteArray_HashAlgorithmName_RSASignaturePadding;
			}
		}

		/// <summary>
		/// Byte[] HashData(Byte[], Int32, Int32, System.Security.Cryptography.HashAlgorithmName)
		/// </summary>
		protected RMethod r_MHashData_ByteArray_Int32_Int32_HashAlgorithmName;
		public virtual RMethod RMHashData_ByteArray_Int32_Int32_HashAlgorithmName
		{
			get
			{
				if(r_MHashData_ByteArray_Int32_Int32_HashAlgorithmName == null)
				{
					r_MHashData_ByteArray_Int32_Int32_HashAlgorithmName = new(this, "HashData", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Security.Cryptography.HashAlgorithmName));
					r_MHashData_ByteArray_Int32_Int32_HashAlgorithmName.SetBelong(this.instance);
				}
				return r_MHashData_ByteArray_Int32_Int32_HashAlgorithmName;
			}
		}

		/// <summary>
		/// Byte[] HashData(System.IO.Stream, System.Security.Cryptography.HashAlgorithmName)
		/// </summary>
		protected RMethod r_MHashData_Stream_HashAlgorithmName;
		public virtual RMethod RMHashData_Stream_HashAlgorithmName
		{
			get
			{
				if(r_MHashData_Stream_HashAlgorithmName == null)
				{
					r_MHashData_Stream_HashAlgorithmName = new(this, "HashData", 0, typeof(System.IO.Stream), typeof(System.Security.Cryptography.HashAlgorithmName));
					r_MHashData_Stream_HashAlgorithmName.SetBelong(this.instance);
				}
				return r_MHashData_Stream_HashAlgorithmName;
			}
		}

		/// <summary>
		/// Byte[] SignData(Byte[], System.Security.Cryptography.HashAlgorithmName, System.Security.Cryptography.RSASignaturePadding)
		/// </summary>
		protected RMethod r_MSignData_ByteArray_HashAlgorithmName_RSASignaturePadding;
		public virtual RMethod RMSignData_ByteArray_HashAlgorithmName_RSASignaturePadding
		{
			get
			{
				if(r_MSignData_ByteArray_HashAlgorithmName_RSASignaturePadding == null)
				{
					r_MSignData_ByteArray_HashAlgorithmName_RSASignaturePadding = new(this, "SignData", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Security.Cryptography.RSASignaturePadding));
					r_MSignData_ByteArray_HashAlgorithmName_RSASignaturePadding.SetBelong(this.instance);
				}
				return r_MSignData_ByteArray_HashAlgorithmName_RSASignaturePadding;
			}
		}

		/// <summary>
		/// Byte[] SignData(Byte[], Int32, Int32, System.Security.Cryptography.HashAlgorithmName, System.Security.Cryptography.RSASignaturePadding)
		/// </summary>
		protected RMethod r_MSignData_ByteArray_Int32_Int32_HashAlgorithmName_RSASignaturePadding;
		public virtual RMethod RMSignData_ByteArray_Int32_Int32_HashAlgorithmName_RSASignaturePadding
		{
			get
			{
				if(r_MSignData_ByteArray_Int32_Int32_HashAlgorithmName_RSASignaturePadding == null)
				{
					r_MSignData_ByteArray_Int32_Int32_HashAlgorithmName_RSASignaturePadding = new(this, "SignData", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Security.Cryptography.RSASignaturePadding));
					r_MSignData_ByteArray_Int32_Int32_HashAlgorithmName_RSASignaturePadding.SetBelong(this.instance);
				}
				return r_MSignData_ByteArray_Int32_Int32_HashAlgorithmName_RSASignaturePadding;
			}
		}

		/// <summary>
		/// Byte[] SignData(System.IO.Stream, System.Security.Cryptography.HashAlgorithmName, System.Security.Cryptography.RSASignaturePadding)
		/// </summary>
		protected RMethod r_MSignData_Stream_HashAlgorithmName_RSASignaturePadding;
		public virtual RMethod RMSignData_Stream_HashAlgorithmName_RSASignaturePadding
		{
			get
			{
				if(r_MSignData_Stream_HashAlgorithmName_RSASignaturePadding == null)
				{
					r_MSignData_Stream_HashAlgorithmName_RSASignaturePadding = new(this, "SignData", 0, typeof(System.IO.Stream), typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Security.Cryptography.RSASignaturePadding));
					r_MSignData_Stream_HashAlgorithmName_RSASignaturePadding.SetBelong(this.instance);
				}
				return r_MSignData_Stream_HashAlgorithmName_RSASignaturePadding;
			}
		}

		/// <summary>
		/// Boolean VerifyData(Byte[], Byte[], System.Security.Cryptography.HashAlgorithmName, System.Security.Cryptography.RSASignaturePadding)
		/// </summary>
		protected RMethod r_MVerifyData_ByteArray_ByteArray_HashAlgorithmName_RSASignaturePadding;
		public virtual RMethod RMVerifyData_ByteArray_ByteArray_HashAlgorithmName_RSASignaturePadding
		{
			get
			{
				if(r_MVerifyData_ByteArray_ByteArray_HashAlgorithmName_RSASignaturePadding == null)
				{
					r_MVerifyData_ByteArray_ByteArray_HashAlgorithmName_RSASignaturePadding = new(this, "VerifyData", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType(), typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Security.Cryptography.RSASignaturePadding));
					r_MVerifyData_ByteArray_ByteArray_HashAlgorithmName_RSASignaturePadding.SetBelong(this.instance);
				}
				return r_MVerifyData_ByteArray_ByteArray_HashAlgorithmName_RSASignaturePadding;
			}
		}

		/// <summary>
		/// Boolean VerifyData(Byte[], Int32, Int32, Byte[], System.Security.Cryptography.HashAlgorithmName, System.Security.Cryptography.RSASignaturePadding)
		/// </summary>
		protected RMethod r_MVerifyData_ByteArray_Int32_Int32_ByteArray_HashAlgorithmName_RSASignaturePadding;
		public virtual RMethod RMVerifyData_ByteArray_Int32_Int32_ByteArray_HashAlgorithmName_RSASignaturePadding
		{
			get
			{
				if(r_MVerifyData_ByteArray_Int32_Int32_ByteArray_HashAlgorithmName_RSASignaturePadding == null)
				{
					r_MVerifyData_ByteArray_Int32_Int32_ByteArray_HashAlgorithmName_RSASignaturePadding = new(this, "VerifyData", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Byte).MakeArrayType(), typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Security.Cryptography.RSASignaturePadding));
					r_MVerifyData_ByteArray_Int32_Int32_ByteArray_HashAlgorithmName_RSASignaturePadding.SetBelong(this.instance);
				}
				return r_MVerifyData_ByteArray_Int32_Int32_ByteArray_HashAlgorithmName_RSASignaturePadding;
			}
		}

		/// <summary>
		/// Boolean VerifyData(System.IO.Stream, Byte[], System.Security.Cryptography.HashAlgorithmName, System.Security.Cryptography.RSASignaturePadding)
		/// </summary>
		protected RMethod r_MVerifyData_Stream_ByteArray_HashAlgorithmName_RSASignaturePadding;
		public virtual RMethod RMVerifyData_Stream_ByteArray_HashAlgorithmName_RSASignaturePadding
		{
			get
			{
				if(r_MVerifyData_Stream_ByteArray_HashAlgorithmName_RSASignaturePadding == null)
				{
					r_MVerifyData_Stream_ByteArray_HashAlgorithmName_RSASignaturePadding = new(this, "VerifyData", 0, typeof(System.IO.Stream), typeof(System.Byte).MakeArrayType(), typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Security.Cryptography.RSASignaturePadding));
					r_MVerifyData_Stream_ByteArray_HashAlgorithmName_RSASignaturePadding.SetBelong(this.instance);
				}
				return r_MVerifyData_Stream_ByteArray_HashAlgorithmName_RSASignaturePadding;
			}
		}

		/// <summary>
		/// System.Exception DerivedClassMustOverride()
		/// </summary>
		protected static RMethod r_MDerivedClassMustOverride;
		public static RMethod RMDerivedClassMustOverride
		{
			get
			{
				if(r_MDerivedClassMustOverride == null)
				{
					r_MDerivedClassMustOverride = new(typeof(System.Security.Cryptography.RSA), "DerivedClassMustOverride", 0);
					r_MDerivedClassMustOverride.SetBelong(null);
				}
				return r_MDerivedClassMustOverride;
			}
		}

		/// <summary>
		/// System.Exception HashAlgorithmNameNullOrEmpty()
		/// </summary>
		protected static RMethod r_MHashAlgorithmNameNullOrEmpty;
		public static RMethod RMHashAlgorithmNameNullOrEmpty
		{
			get
			{
				if(r_MHashAlgorithmNameNullOrEmpty == null)
				{
					r_MHashAlgorithmNameNullOrEmpty = new(typeof(System.Security.Cryptography.RSA), "HashAlgorithmNameNullOrEmpty", 0);
					r_MHashAlgorithmNameNullOrEmpty.SetBelong(null);
				}
				return r_MHashAlgorithmNameNullOrEmpty;
			}
		}

		/// <summary>
		/// Byte[] DecryptValue(Byte[])
		/// </summary>
		protected RMethod r_MDecryptValue_ByteArray;
		public virtual RMethod RMDecryptValue_ByteArray
		{
			get
			{
				if(r_MDecryptValue_ByteArray == null)
				{
					r_MDecryptValue_ByteArray = new(this, "DecryptValue", 0, typeof(System.Byte).MakeArrayType());
					r_MDecryptValue_ByteArray.SetBelong(this.instance);
				}
				return r_MDecryptValue_ByteArray;
			}
		}

		/// <summary>
		/// Byte[] EncryptValue(Byte[])
		/// </summary>
		protected RMethod r_MEncryptValue_ByteArray;
		public virtual RMethod RMEncryptValue_ByteArray
		{
			get
			{
				if(r_MEncryptValue_ByteArray == null)
				{
					r_MEncryptValue_ByteArray = new(this, "EncryptValue", 0, typeof(System.Byte).MakeArrayType());
					r_MEncryptValue_ByteArray.SetBelong(this.instance);
				}
				return r_MEncryptValue_ByteArray;
			}
		}

		/// <summary>
		/// Void FromXmlString(System.String)
		/// </summary>
		protected RMethod r_MFromXmlString_String;
		public virtual RMethod RMFromXmlString_String
		{
			get
			{
				if(r_MFromXmlString_String == null)
				{
					r_MFromXmlString_String = new(this, "FromXmlString", 0, typeof(System.String));
					r_MFromXmlString_String.SetBelong(this.instance);
				}
				return r_MFromXmlString_String;
			}
		}

		/// <summary>
		/// System.String ToXmlString(Boolean)
		/// </summary>
		protected RMethod r_MToXmlString_Boolean;
		public virtual RMethod RMToXmlString_Boolean
		{
			get
			{
				if(r_MToXmlString_Boolean == null)
				{
					r_MToXmlString_Boolean = new(this, "ToXmlString", 0, typeof(System.Boolean));
					r_MToXmlString_Boolean.SetBelong(this.instance);
				}
				return r_MToXmlString_Boolean;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSAParameters ExportParameters(Boolean)
		/// </summary>
		protected RMethod r_MExportParameters_Boolean;
		public virtual RMethod RMExportParameters_Boolean
		{
			get
			{
				if(r_MExportParameters_Boolean == null)
				{
					r_MExportParameters_Boolean = new(this, "ExportParameters", 0, typeof(System.Boolean));
					r_MExportParameters_Boolean.SetBelong(this.instance);
				}
				return r_MExportParameters_Boolean;
			}
		}

		/// <summary>
		/// Void ImportParameters(System.Security.Cryptography.RSAParameters)
		/// </summary>
		protected RMethod r_MImportParameters_RSAParameters;
		public virtual RMethod RMImportParameters_RSAParameters
		{
			get
			{
				if(r_MImportParameters_RSAParameters == null)
				{
					r_MImportParameters_RSAParameters = new(this, "ImportParameters", 0, typeof(System.Security.Cryptography.RSAParameters));
					r_MImportParameters_RSAParameters.SetBelong(this.instance);
				}
				return r_MImportParameters_RSAParameters;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSA Create(Int32)
		/// </summary>
		protected static RMethod r_MCreate_Int32;
		public static RMethod RMCreate_Int32
		{
			get
			{
				if(r_MCreate_Int32 == null)
				{
					r_MCreate_Int32 = new(typeof(System.Security.Cryptography.RSA), "Create", 0, typeof(System.Int32));
					r_MCreate_Int32.SetBelong(null);
				}
				return r_MCreate_Int32;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSA Create(System.Security.Cryptography.RSAParameters)
		/// </summary>
		protected static RMethod r_MCreate_RSAParameters;
		public static RMethod RMCreate_RSAParameters
		{
			get
			{
				if(r_MCreate_RSAParameters == null)
				{
					r_MCreate_RSAParameters = new(typeof(System.Security.Cryptography.RSA), "Create", 0, typeof(System.Security.Cryptography.RSAParameters));
					r_MCreate_RSAParameters.SetBelong(null);
				}
				return r_MCreate_RSAParameters;
			}
		}

		/// <summary>
		/// Boolean TryDecrypt(System.ReadOnlySpan`1[System.Byte], System.Span`1[System.Byte], System.Security.Cryptography.RSAEncryptionPadding, Int32 ByRef)
		/// </summary>
		protected RMethod r_MTryDecrypt_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__RSAEncryptionPadding_Out_Int32;
		public virtual RMethod RMTryDecrypt_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__RSAEncryptionPadding_Out_Int32
		{
			get
			{
				if(r_MTryDecrypt_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__RSAEncryptionPadding_Out_Int32 == null)
				{
					r_MTryDecrypt_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__RSAEncryptionPadding_Out_Int32 = new(this, "TryDecrypt", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Security.Cryptography.RSAEncryptionPadding), typeof(System.Int32).MakeByRefType());
					r_MTryDecrypt_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__RSAEncryptionPadding_Out_Int32.SetBelong(this.instance);
				}
				return r_MTryDecrypt_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__RSAEncryptionPadding_Out_Int32;
			}
		}

		/// <summary>
		/// Boolean TryEncrypt(System.ReadOnlySpan`1[System.Byte], System.Span`1[System.Byte], System.Security.Cryptography.RSAEncryptionPadding, Int32 ByRef)
		/// </summary>
		protected RMethod r_MTryEncrypt_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__RSAEncryptionPadding_Out_Int32;
		public virtual RMethod RMTryEncrypt_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__RSAEncryptionPadding_Out_Int32
		{
			get
			{
				if(r_MTryEncrypt_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__RSAEncryptionPadding_Out_Int32 == null)
				{
					r_MTryEncrypt_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__RSAEncryptionPadding_Out_Int32 = new(this, "TryEncrypt", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Security.Cryptography.RSAEncryptionPadding), typeof(System.Int32).MakeByRefType());
					r_MTryEncrypt_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__RSAEncryptionPadding_Out_Int32.SetBelong(this.instance);
				}
				return r_MTryEncrypt_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__RSAEncryptionPadding_Out_Int32;
			}
		}

		/// <summary>
		/// Boolean TryHashData(System.ReadOnlySpan`1[System.Byte], System.Span`1[System.Byte], System.Security.Cryptography.HashAlgorithmName, Int32 ByRef)
		/// </summary>
		protected RMethod r_MTryHashData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_Out_Int32;
		public virtual RMethod RMTryHashData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_Out_Int32
		{
			get
			{
				if(r_MTryHashData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_Out_Int32 == null)
				{
					r_MTryHashData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_Out_Int32 = new(this, "TryHashData", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Int32).MakeByRefType());
					r_MTryHashData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_Out_Int32.SetBelong(this.instance);
				}
				return r_MTryHashData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_Out_Int32;
			}
		}

		/// <summary>
		/// Boolean TrySignHash(System.ReadOnlySpan`1[System.Byte], System.Span`1[System.Byte], System.Security.Cryptography.HashAlgorithmName, System.Security.Cryptography.RSASignaturePadding, Int32 ByRef)
		/// </summary>
		protected RMethod r_MTrySignHash_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_RSASignaturePadding_Out_Int32;
		public virtual RMethod RMTrySignHash_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_RSASignaturePadding_Out_Int32
		{
			get
			{
				if(r_MTrySignHash_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_RSASignaturePadding_Out_Int32 == null)
				{
					r_MTrySignHash_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_RSASignaturePadding_Out_Int32 = new(this, "TrySignHash", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Security.Cryptography.RSASignaturePadding), typeof(System.Int32).MakeByRefType());
					r_MTrySignHash_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_RSASignaturePadding_Out_Int32.SetBelong(this.instance);
				}
				return r_MTrySignHash_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_RSASignaturePadding_Out_Int32;
			}
		}

		/// <summary>
		/// Boolean TrySignData(System.ReadOnlySpan`1[System.Byte], System.Span`1[System.Byte], System.Security.Cryptography.HashAlgorithmName, System.Security.Cryptography.RSASignaturePadding, Int32 ByRef)
		/// </summary>
		protected RMethod r_MTrySignData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_RSASignaturePadding_Out_Int32;
		public virtual RMethod RMTrySignData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_RSASignaturePadding_Out_Int32
		{
			get
			{
				if(r_MTrySignData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_RSASignaturePadding_Out_Int32 == null)
				{
					r_MTrySignData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_RSASignaturePadding_Out_Int32 = new(this, "TrySignData", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Security.Cryptography.RSASignaturePadding), typeof(System.Int32).MakeByRefType());
					r_MTrySignData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_RSASignaturePadding_Out_Int32.SetBelong(this.instance);
				}
				return r_MTrySignData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_RSASignaturePadding_Out_Int32;
			}
		}

		/// <summary>
		/// Boolean VerifyData(System.ReadOnlySpan`1[System.Byte], System.ReadOnlySpan`1[System.Byte], System.Security.Cryptography.HashAlgorithmName, System.Security.Cryptography.RSASignaturePadding)
		/// </summary>
		protected RMethod r_MVerifyData_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__HashAlgorithmName_RSASignaturePadding;
		public virtual RMethod RMVerifyData_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__HashAlgorithmName_RSASignaturePadding
		{
			get
			{
				if(r_MVerifyData_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__HashAlgorithmName_RSASignaturePadding == null)
				{
					r_MVerifyData_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__HashAlgorithmName_RSASignaturePadding = new(this, "VerifyData", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Security.Cryptography.RSASignaturePadding));
					r_MVerifyData_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__HashAlgorithmName_RSASignaturePadding.SetBelong(this.instance);
				}
				return r_MVerifyData_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__HashAlgorithmName_RSASignaturePadding;
			}
		}

		/// <summary>
		/// Boolean VerifyHash(System.ReadOnlySpan`1[System.Byte], System.ReadOnlySpan`1[System.Byte], System.Security.Cryptography.HashAlgorithmName, System.Security.Cryptography.RSASignaturePadding)
		/// </summary>
		protected RMethod r_MVerifyHash_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__HashAlgorithmName_RSASignaturePadding;
		public virtual RMethod RMVerifyHash_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__HashAlgorithmName_RSASignaturePadding
		{
			get
			{
				if(r_MVerifyHash_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__HashAlgorithmName_RSASignaturePadding == null)
				{
					r_MVerifyHash_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__HashAlgorithmName_RSASignaturePadding = new(this, "VerifyHash", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Security.Cryptography.RSASignaturePadding));
					r_MVerifyHash_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__HashAlgorithmName_RSASignaturePadding.SetBelong(this.instance);
				}
				return r_MVerifyHash_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__HashAlgorithmName_RSASignaturePadding;
			}
		}

		/// <summary>
		/// Byte[] ExportRSAPrivateKey()
		/// </summary>
		protected RMethod r_MExportRSAPrivateKey;
		public virtual RMethod RMExportRSAPrivateKey
		{
			get
			{
				if(r_MExportRSAPrivateKey == null)
				{
					r_MExportRSAPrivateKey = new(this, "ExportRSAPrivateKey", 0);
					r_MExportRSAPrivateKey.SetBelong(this.instance);
				}
				return r_MExportRSAPrivateKey;
			}
		}

		/// <summary>
		/// Byte[] ExportRSAPublicKey()
		/// </summary>
		protected RMethod r_MExportRSAPublicKey;
		public virtual RMethod RMExportRSAPublicKey
		{
			get
			{
				if(r_MExportRSAPublicKey == null)
				{
					r_MExportRSAPublicKey = new(this, "ExportRSAPublicKey", 0);
					r_MExportRSAPublicKey.SetBelong(this.instance);
				}
				return r_MExportRSAPublicKey;
			}
		}

		/// <summary>
		/// Void ImportRSAPrivateKey(System.ReadOnlySpan`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_MImportRSAPrivateKey_ReadOnlySpan_d_Byte_p__Out_Int32;
		public virtual RMethod RMImportRSAPrivateKey_ReadOnlySpan_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_MImportRSAPrivateKey_ReadOnlySpan_d_Byte_p__Out_Int32 == null)
				{
					r_MImportRSAPrivateKey_ReadOnlySpan_d_Byte_p__Out_Int32 = new(this, "ImportRSAPrivateKey", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_MImportRSAPrivateKey_ReadOnlySpan_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_MImportRSAPrivateKey_ReadOnlySpan_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// Void ImportRSAPublicKey(System.ReadOnlySpan`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_MImportRSAPublicKey_ReadOnlySpan_d_Byte_p__Out_Int32;
		public virtual RMethod RMImportRSAPublicKey_ReadOnlySpan_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_MImportRSAPublicKey_ReadOnlySpan_d_Byte_p__Out_Int32 == null)
				{
					r_MImportRSAPublicKey_ReadOnlySpan_d_Byte_p__Out_Int32 = new(this, "ImportRSAPublicKey", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_MImportRSAPublicKey_ReadOnlySpan_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_MImportRSAPublicKey_ReadOnlySpan_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// Boolean TryExportRSAPrivateKey(System.Span`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_MTryExportRSAPrivateKey_Span_d_Byte_p__Out_Int32;
		public virtual RMethod RMTryExportRSAPrivateKey_Span_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_MTryExportRSAPrivateKey_Span_d_Byte_p__Out_Int32 == null)
				{
					r_MTryExportRSAPrivateKey_Span_d_Byte_p__Out_Int32 = new(this, "TryExportRSAPrivateKey", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_MTryExportRSAPrivateKey_Span_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_MTryExportRSAPrivateKey_Span_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// Boolean TryExportRSAPublicKey(System.Span`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_MTryExportRSAPublicKey_Span_d_Byte_p__Out_Int32;
		public virtual RMethod RMTryExportRSAPublicKey_Span_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_MTryExportRSAPublicKey_Span_d_Byte_p__Out_Int32 == null)
				{
					r_MTryExportRSAPublicKey_Span_d_Byte_p__Out_Int32 = new(this, "TryExportRSAPublicKey", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_MTryExportRSAPublicKey_Span_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_MTryExportRSAPublicKey_Span_d_Byte_p__Out_Int32;
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
					r_MDispose.SetBelong(this.instance);
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_MClear;
		public virtual RMethod RMClear
		{
			get
			{
				if(r_MClear == null)
				{
					r_MClear = new(this, "Clear", 0);
					r_MClear.SetBelong(this.instance);
				}
				return r_MClear;
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
					r_MDispose_Boolean.SetBelong(this.instance);
				}
				return r_MDispose_Boolean;
			}
		}

		/// <summary>
		/// Byte[] ExportEncryptedPkcs8PrivateKey(System.ReadOnlySpan`1[System.Byte], System.Security.Cryptography.PbeParameters)
		/// </summary>
		protected RMethod r_MExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters;
		public virtual RMethod RMExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters
		{
			get
			{
				if(r_MExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters == null)
				{
					r_MExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters = new(this, "ExportEncryptedPkcs8PrivateKey", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Security.Cryptography.PbeParameters));
					r_MExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters.SetBelong(this.instance);
				}
				return r_MExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters;
			}
		}

		/// <summary>
		/// Byte[] ExportEncryptedPkcs8PrivateKey(System.ReadOnlySpan`1[System.Char], System.Security.Cryptography.PbeParameters)
		/// </summary>
		protected RMethod r_MExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters;
		public virtual RMethod RMExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters
		{
			get
			{
				if(r_MExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters == null)
				{
					r_MExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters = new(this, "ExportEncryptedPkcs8PrivateKey", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Security.Cryptography.PbeParameters));
					r_MExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters.SetBelong(this.instance);
				}
				return r_MExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters;
			}
		}

		/// <summary>
		/// Byte[] ExportPkcs8PrivateKey()
		/// </summary>
		protected RMethod r_MExportPkcs8PrivateKey;
		public virtual RMethod RMExportPkcs8PrivateKey
		{
			get
			{
				if(r_MExportPkcs8PrivateKey == null)
				{
					r_MExportPkcs8PrivateKey = new(this, "ExportPkcs8PrivateKey", 0);
					r_MExportPkcs8PrivateKey.SetBelong(this.instance);
				}
				return r_MExportPkcs8PrivateKey;
			}
		}

		/// <summary>
		/// Byte[] ExportSubjectPublicKeyInfo()
		/// </summary>
		protected RMethod r_MExportSubjectPublicKeyInfo;
		public virtual RMethod RMExportSubjectPublicKeyInfo
		{
			get
			{
				if(r_MExportSubjectPublicKeyInfo == null)
				{
					r_MExportSubjectPublicKeyInfo = new(this, "ExportSubjectPublicKeyInfo", 0);
					r_MExportSubjectPublicKeyInfo.SetBelong(this.instance);
				}
				return r_MExportSubjectPublicKeyInfo;
			}
		}

		/// <summary>
		/// Void ImportEncryptedPkcs8PrivateKey(System.ReadOnlySpan`1[System.Byte], System.ReadOnlySpan`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_MImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__Out_Int32;
		public virtual RMethod RMImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_MImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__Out_Int32 == null)
				{
					r_MImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__Out_Int32 = new(this, "ImportEncryptedPkcs8PrivateKey", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_MImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_MImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// Void ImportEncryptedPkcs8PrivateKey(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_MImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Byte_p__Out_Int32;
		public virtual RMethod RMImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_MImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Byte_p__Out_Int32 == null)
				{
					r_MImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Byte_p__Out_Int32 = new(this, "ImportEncryptedPkcs8PrivateKey", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_MImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_MImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// Void ImportPkcs8PrivateKey(System.ReadOnlySpan`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_MImportPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__Out_Int32;
		public virtual RMethod RMImportPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_MImportPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__Out_Int32 == null)
				{
					r_MImportPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__Out_Int32 = new(this, "ImportPkcs8PrivateKey", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_MImportPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_MImportPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// Void ImportSubjectPublicKeyInfo(System.ReadOnlySpan`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_MImportSubjectPublicKeyInfo_ReadOnlySpan_d_Byte_p__Out_Int32;
		public virtual RMethod RMImportSubjectPublicKeyInfo_ReadOnlySpan_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_MImportSubjectPublicKeyInfo_ReadOnlySpan_d_Byte_p__Out_Int32 == null)
				{
					r_MImportSubjectPublicKeyInfo_ReadOnlySpan_d_Byte_p__Out_Int32 = new(this, "ImportSubjectPublicKeyInfo", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_MImportSubjectPublicKeyInfo_ReadOnlySpan_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_MImportSubjectPublicKeyInfo_ReadOnlySpan_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// Boolean TryExportEncryptedPkcs8PrivateKey(System.ReadOnlySpan`1[System.Byte], System.Security.Cryptography.PbeParameters, System.Span`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_MTryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters_Span_d_Byte_p__Out_Int32;
		public virtual RMethod RMTryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters_Span_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_MTryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters_Span_d_Byte_p__Out_Int32 == null)
				{
					r_MTryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters_Span_d_Byte_p__Out_Int32 = new(this, "TryExportEncryptedPkcs8PrivateKey", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Security.Cryptography.PbeParameters), typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_MTryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters_Span_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_MTryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters_Span_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// Boolean TryExportEncryptedPkcs8PrivateKey(System.ReadOnlySpan`1[System.Char], System.Security.Cryptography.PbeParameters, System.Span`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_MTryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters_Span_d_Byte_p__Out_Int32;
		public virtual RMethod RMTryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters_Span_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_MTryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters_Span_d_Byte_p__Out_Int32 == null)
				{
					r_MTryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters_Span_d_Byte_p__Out_Int32 = new(this, "TryExportEncryptedPkcs8PrivateKey", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Security.Cryptography.PbeParameters), typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_MTryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters_Span_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_MTryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters_Span_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// Boolean TryExportPkcs8PrivateKey(System.Span`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_MTryExportPkcs8PrivateKey_Span_d_Byte_p__Out_Int32;
		public virtual RMethod RMTryExportPkcs8PrivateKey_Span_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_MTryExportPkcs8PrivateKey_Span_d_Byte_p__Out_Int32 == null)
				{
					r_MTryExportPkcs8PrivateKey_Span_d_Byte_p__Out_Int32 = new(this, "TryExportPkcs8PrivateKey", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_MTryExportPkcs8PrivateKey_Span_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_MTryExportPkcs8PrivateKey_Span_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// Boolean TryExportSubjectPublicKeyInfo(System.Span`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_MTryExportSubjectPublicKeyInfo_Span_d_Byte_p__Out_Int32;
		public virtual RMethod RMTryExportSubjectPublicKeyInfo_Span_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_MTryExportSubjectPublicKeyInfo_Span_d_Byte_p__Out_Int32 == null)
				{
					r_MTryExportSubjectPublicKeyInfo_Span_d_Byte_p__Out_Int32 = new(this, "TryExportSubjectPublicKeyInfo", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_MTryExportSubjectPublicKeyInfo_Span_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_MTryExportSubjectPublicKeyInfo_Span_d_Byte_p__Out_Int32;
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


        public RRSA() : base("System.Security.Cryptography.RSA")
        {
        }

        public RRSA(System.Object instance) : base("System.Security.Cryptography.RSA")
		{
            SetInstance(instance);
		}

        public RRSA(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRSA(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Security.Cryptography.RSA Create()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreate.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.RSA)___result;
        }


        public static System.Security.Cryptography.RSA Create(System.String @algName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@algName};
            var ___result = RMCreate_String.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.RSA)___result;
        }


        public virtual System.Byte[] Encrypt(System.Byte[] @data, System.Security.Cryptography.RSAEncryptionPadding @padding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @padding};
            var ___result = RMEncrypt_ByteArray_RSAEncryptionPadding.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] Decrypt(System.Byte[] @data, System.Security.Cryptography.RSAEncryptionPadding @padding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @padding};
            var ___result = RMDecrypt_ByteArray_RSAEncryptionPadding.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] SignHash(System.Byte[] @hash, System.Security.Cryptography.HashAlgorithmName @hashAlgorithm, System.Security.Cryptography.RSASignaturePadding @padding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hash, @hashAlgorithm, @padding};
            var ___result = RMSignHash_ByteArray_HashAlgorithmName_RSASignaturePadding.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Boolean VerifyHash(System.Byte[] @hash, System.Byte[] @signature, System.Security.Cryptography.HashAlgorithmName @hashAlgorithm, System.Security.Cryptography.RSASignaturePadding @padding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hash, @signature, @hashAlgorithm, @padding};
            var ___result = RMVerifyHash_ByteArray_ByteArray_HashAlgorithmName_RSASignaturePadding.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Byte[] HashData(System.Byte[] @data, System.Int32 @offset, System.Int32 @count, System.Security.Cryptography.HashAlgorithmName @hashAlgorithm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @offset, @count, @hashAlgorithm};
            var ___result = RMHashData_ByteArray_Int32_Int32_HashAlgorithmName.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] HashData(System.IO.Stream @data, System.Security.Cryptography.HashAlgorithmName @hashAlgorithm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @hashAlgorithm};
            var ___result = RMHashData_Stream_HashAlgorithmName.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] SignData(System.Byte[] @data, System.Security.Cryptography.HashAlgorithmName @hashAlgorithm, System.Security.Cryptography.RSASignaturePadding @padding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @hashAlgorithm, @padding};
            var ___result = RMSignData_ByteArray_HashAlgorithmName_RSASignaturePadding.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] SignData(System.Byte[] @data, System.Int32 @offset, System.Int32 @count, System.Security.Cryptography.HashAlgorithmName @hashAlgorithm, System.Security.Cryptography.RSASignaturePadding @padding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @offset, @count, @hashAlgorithm, @padding};
            var ___result = RMSignData_ByteArray_Int32_Int32_HashAlgorithmName_RSASignaturePadding.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] SignData(System.IO.Stream @data, System.Security.Cryptography.HashAlgorithmName @hashAlgorithm, System.Security.Cryptography.RSASignaturePadding @padding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @hashAlgorithm, @padding};
            var ___result = RMSignData_Stream_HashAlgorithmName_RSASignaturePadding.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Boolean VerifyData(System.Byte[] @data, System.Byte[] @signature, System.Security.Cryptography.HashAlgorithmName @hashAlgorithm, System.Security.Cryptography.RSASignaturePadding @padding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @signature, @hashAlgorithm, @padding};
            var ___result = RMVerifyData_ByteArray_ByteArray_HashAlgorithmName_RSASignaturePadding.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean VerifyData(System.Byte[] @data, System.Int32 @offset, System.Int32 @count, System.Byte[] @signature, System.Security.Cryptography.HashAlgorithmName @hashAlgorithm, System.Security.Cryptography.RSASignaturePadding @padding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @offset, @count, @signature, @hashAlgorithm, @padding};
            var ___result = RMVerifyData_ByteArray_Int32_Int32_ByteArray_HashAlgorithmName_RSASignaturePadding.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean VerifyData(System.IO.Stream @data, System.Byte[] @signature, System.Security.Cryptography.HashAlgorithmName @hashAlgorithm, System.Security.Cryptography.RSASignaturePadding @padding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @signature, @hashAlgorithm, @padding};
            var ___result = RMVerifyData_Stream_ByteArray_HashAlgorithmName_RSASignaturePadding.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Exception DerivedClassMustOverride()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDerivedClassMustOverride.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public static System.Exception HashAlgorithmNameNullOrEmpty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHashAlgorithmNameNullOrEmpty.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual System.Byte[] DecryptValue(System.Byte[] @rgb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rgb};
            var ___result = RMDecryptValue_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] EncryptValue(System.Byte[] @rgb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rgb};
            var ___result = RMEncryptValue_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual void FromXmlString(System.String @xmlString)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xmlString};
            var ___result = RMFromXmlString_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToXmlString(System.Boolean @includePrivateParameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@includePrivateParameters};
            var ___result = RMToXmlString_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Security.Cryptography.RSAParameters ExportParameters(System.Boolean @includePrivateParameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@includePrivateParameters};
            var ___result = RMExportParameters_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.RSAParameters)___result;
        }


        public virtual void ImportParameters(System.Security.Cryptography.RSAParameters @parameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parameters};
            var ___result = RMImportParameters_RSAParameters.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Security.Cryptography.RSA Create(System.Int32 @keySizeInBits)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keySizeInBits};
            var ___result = RMCreate_Int32.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.RSA)___result;
        }


        public static System.Security.Cryptography.RSA Create(System.Security.Cryptography.RSAParameters @parameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parameters};
            var ___result = RMCreate_RSAParameters.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.RSA)___result;
        }


        public virtual System.Boolean TryDecrypt(SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RSystem.RByte> @data, SMFrame.Editor.Refleaction.RSystem.RSpan<SMFrame.Editor.Refleaction.RSystem.RByte> @destination, System.Security.Cryptography.RSAEncryptionPadding @padding, out System.Int32 @bytesWritten)
        {
			@bytesWritten = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data.Value, @destination.Value, @padding, @bytesWritten};
            var ___result = RMTryDecrypt_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__RSAEncryptionPadding_Out_Int32.Invoke(___genericsType, ___parameters);
			@bytesWritten = (System.Int32)___parameters[3];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryEncrypt(SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RSystem.RByte> @data, SMFrame.Editor.Refleaction.RSystem.RSpan<SMFrame.Editor.Refleaction.RSystem.RByte> @destination, System.Security.Cryptography.RSAEncryptionPadding @padding, out System.Int32 @bytesWritten)
        {
			@bytesWritten = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data.Value, @destination.Value, @padding, @bytesWritten};
            var ___result = RMTryEncrypt_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__RSAEncryptionPadding_Out_Int32.Invoke(___genericsType, ___parameters);
			@bytesWritten = (System.Int32)___parameters[3];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryHashData(SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RSystem.RByte> @data, SMFrame.Editor.Refleaction.RSystem.RSpan<SMFrame.Editor.Refleaction.RSystem.RByte> @destination, System.Security.Cryptography.HashAlgorithmName @hashAlgorithm, out System.Int32 @bytesWritten)
        {
			@bytesWritten = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data.Value, @destination.Value, @hashAlgorithm, @bytesWritten};
            var ___result = RMTryHashData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_Out_Int32.Invoke(___genericsType, ___parameters);
			@bytesWritten = (System.Int32)___parameters[3];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TrySignHash(SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RSystem.RByte> @hash, SMFrame.Editor.Refleaction.RSystem.RSpan<SMFrame.Editor.Refleaction.RSystem.RByte> @destination, System.Security.Cryptography.HashAlgorithmName @hashAlgorithm, System.Security.Cryptography.RSASignaturePadding @padding, out System.Int32 @bytesWritten)
        {
			@bytesWritten = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hash.Value, @destination.Value, @hashAlgorithm, @padding, @bytesWritten};
            var ___result = RMTrySignHash_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_RSASignaturePadding_Out_Int32.Invoke(___genericsType, ___parameters);
			@bytesWritten = (System.Int32)___parameters[4];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TrySignData(SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RSystem.RByte> @data, SMFrame.Editor.Refleaction.RSystem.RSpan<SMFrame.Editor.Refleaction.RSystem.RByte> @destination, System.Security.Cryptography.HashAlgorithmName @hashAlgorithm, System.Security.Cryptography.RSASignaturePadding @padding, out System.Int32 @bytesWritten)
        {
			@bytesWritten = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data.Value, @destination.Value, @hashAlgorithm, @padding, @bytesWritten};
            var ___result = RMTrySignData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_RSASignaturePadding_Out_Int32.Invoke(___genericsType, ___parameters);
			@bytesWritten = (System.Int32)___parameters[4];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean VerifyData(SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RSystem.RByte> @data, SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RSystem.RByte> @signature, System.Security.Cryptography.HashAlgorithmName @hashAlgorithm, System.Security.Cryptography.RSASignaturePadding @padding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data.Value, @signature.Value, @hashAlgorithm, @padding};
            var ___result = RMVerifyData_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__HashAlgorithmName_RSASignaturePadding.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean VerifyHash(SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RSystem.RByte> @hash, SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RSystem.RByte> @signature, System.Security.Cryptography.HashAlgorithmName @hashAlgorithm, System.Security.Cryptography.RSASignaturePadding @padding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hash.Value, @signature.Value, @hashAlgorithm, @padding};
            var ___result = RMVerifyHash_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__HashAlgorithmName_RSASignaturePadding.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Byte[] ExportRSAPrivateKey()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMExportRSAPrivateKey.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] ExportRSAPublicKey()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMExportRSAPublicKey.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual void ImportRSAPrivateKey(SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RSystem.RByte> @source, out System.Int32 @bytesRead)
        {
			@bytesRead = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source.Value, @bytesRead};
            var ___result = RMImportRSAPrivateKey_ReadOnlySpan_d_Byte_p__Out_Int32.Invoke(___genericsType, ___parameters);
			@bytesRead = (System.Int32)___parameters[1];

            
        }


        public virtual void ImportRSAPublicKey(SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RSystem.RByte> @source, out System.Int32 @bytesRead)
        {
			@bytesRead = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source.Value, @bytesRead};
            var ___result = RMImportRSAPublicKey_ReadOnlySpan_d_Byte_p__Out_Int32.Invoke(___genericsType, ___parameters);
			@bytesRead = (System.Int32)___parameters[1];

            
        }


        public virtual System.Boolean TryExportRSAPrivateKey(SMFrame.Editor.Refleaction.RSystem.RSpan<SMFrame.Editor.Refleaction.RSystem.RByte> @destination, out System.Int32 @bytesWritten)
        {
			@bytesWritten = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination.Value, @bytesWritten};
            var ___result = RMTryExportRSAPrivateKey_Span_d_Byte_p__Out_Int32.Invoke(___genericsType, ___parameters);
			@bytesWritten = (System.Int32)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryExportRSAPublicKey(SMFrame.Editor.Refleaction.RSystem.RSpan<SMFrame.Editor.Refleaction.RSystem.RByte> @destination, out System.Int32 @bytesWritten)
        {
			@bytesWritten = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination.Value, @bytesWritten};
            var ___result = RMTryExportRSAPublicKey_Span_d_Byte_p__Out_Int32.Invoke(___genericsType, ___parameters);
			@bytesWritten = (System.Int32)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RMDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Byte[] ExportEncryptedPkcs8PrivateKey(SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RSystem.RByte> @passwordBytes, System.Security.Cryptography.PbeParameters @pbeParameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@passwordBytes.Value, @pbeParameters};
            var ___result = RMExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] ExportEncryptedPkcs8PrivateKey(SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RSystem.RChar> @password, System.Security.Cryptography.PbeParameters @pbeParameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@password.Value, @pbeParameters};
            var ___result = RMExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] ExportPkcs8PrivateKey()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMExportPkcs8PrivateKey.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] ExportSubjectPublicKeyInfo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMExportSubjectPublicKeyInfo.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual void ImportEncryptedPkcs8PrivateKey(SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RSystem.RByte> @passwordBytes, SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RSystem.RByte> @source, out System.Int32 @bytesRead)
        {
			@bytesRead = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@passwordBytes.Value, @source.Value, @bytesRead};
            var ___result = RMImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__Out_Int32.Invoke(___genericsType, ___parameters);
			@bytesRead = (System.Int32)___parameters[2];

            
        }


        public virtual void ImportEncryptedPkcs8PrivateKey(SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RSystem.RChar> @password, SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RSystem.RByte> @source, out System.Int32 @bytesRead)
        {
			@bytesRead = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@password.Value, @source.Value, @bytesRead};
            var ___result = RMImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Byte_p__Out_Int32.Invoke(___genericsType, ___parameters);
			@bytesRead = (System.Int32)___parameters[2];

            
        }


        public virtual void ImportPkcs8PrivateKey(SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RSystem.RByte> @source, out System.Int32 @bytesRead)
        {
			@bytesRead = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source.Value, @bytesRead};
            var ___result = RMImportPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__Out_Int32.Invoke(___genericsType, ___parameters);
			@bytesRead = (System.Int32)___parameters[1];

            
        }


        public virtual void ImportSubjectPublicKeyInfo(SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RSystem.RByte> @source, out System.Int32 @bytesRead)
        {
			@bytesRead = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source.Value, @bytesRead};
            var ___result = RMImportSubjectPublicKeyInfo_ReadOnlySpan_d_Byte_p__Out_Int32.Invoke(___genericsType, ___parameters);
			@bytesRead = (System.Int32)___parameters[1];

            
        }


        public virtual System.Boolean TryExportEncryptedPkcs8PrivateKey(SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RSystem.RByte> @passwordBytes, System.Security.Cryptography.PbeParameters @pbeParameters, SMFrame.Editor.Refleaction.RSystem.RSpan<SMFrame.Editor.Refleaction.RSystem.RByte> @destination, out System.Int32 @bytesWritten)
        {
			@bytesWritten = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@passwordBytes.Value, @pbeParameters, @destination.Value, @bytesWritten};
            var ___result = RMTryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters_Span_d_Byte_p__Out_Int32.Invoke(___genericsType, ___parameters);
			@bytesWritten = (System.Int32)___parameters[3];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryExportEncryptedPkcs8PrivateKey(SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RSystem.RChar> @password, System.Security.Cryptography.PbeParameters @pbeParameters, SMFrame.Editor.Refleaction.RSystem.RSpan<SMFrame.Editor.Refleaction.RSystem.RByte> @destination, out System.Int32 @bytesWritten)
        {
			@bytesWritten = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@password.Value, @pbeParameters, @destination.Value, @bytesWritten};
            var ___result = RMTryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters_Span_d_Byte_p__Out_Int32.Invoke(___genericsType, ___parameters);
			@bytesWritten = (System.Int32)___parameters[3];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryExportPkcs8PrivateKey(SMFrame.Editor.Refleaction.RSystem.RSpan<SMFrame.Editor.Refleaction.RSystem.RByte> @destination, out System.Int32 @bytesWritten)
        {
			@bytesWritten = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination.Value, @bytesWritten};
            var ___result = RMTryExportPkcs8PrivateKey_Span_d_Byte_p__Out_Int32.Invoke(___genericsType, ___parameters);
			@bytesWritten = (System.Int32)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryExportSubjectPublicKeyInfo(SMFrame.Editor.Refleaction.RSystem.RSpan<SMFrame.Editor.Refleaction.RSystem.RByte> @destination, out System.Int32 @bytesWritten)
        {
			@bytesWritten = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination.Value, @bytesWritten};
            var ___result = RMTryExportSubjectPublicKeyInfo_Span_d_Byte_p__Out_Int32.Invoke(___genericsType, ___parameters);
			@bytesWritten = (System.Int32)___parameters[1];

            return (System.Boolean)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}