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
		protected RField r_KeySizeValue;
		public virtual RField RKeySizeValue
		{
			get
			{
				if(r_KeySizeValue == null)
				{
					r_KeySizeValue = new(this, "KeySizeValue");
					r_KeySizeValue.SetBelong(this.instance);
				}
				return r_KeySizeValue;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.KeySizes[] LegalKeySizesValue
		/// </summary>
		protected RFieldArray<RSystem.RSecurity.RCryptography.RKeySizes> r_LegalKeySizesValue;
		public virtual RFieldArray<RSystem.RSecurity.RCryptography.RKeySizes> RLegalKeySizesValue
		{
			get
			{
				if(r_LegalKeySizesValue == null)
				{
					r_LegalKeySizesValue = new(this, "LegalKeySizesValue");
					r_LegalKeySizesValue.SetBelong(this.instance);
				}
				return r_LegalKeySizesValue;
			}
		}

		/// <summary>
		/// System.String KeyExchangeAlgorithm
		/// </summary>
		protected RProperty r_KeyExchangeAlgorithm;
		public virtual RProperty RKeyExchangeAlgorithm
		{
			get
			{
				if(r_KeyExchangeAlgorithm == null)
				{
					r_KeyExchangeAlgorithm = new(this, "KeyExchangeAlgorithm", -1);
					r_KeyExchangeAlgorithm.SetBelong(this.instance);
				}
				return r_KeyExchangeAlgorithm;
			}
		}

		/// <summary>
		/// System.String SignatureAlgorithm
		/// </summary>
		protected RProperty r_SignatureAlgorithm;
		public virtual RProperty RSignatureAlgorithm
		{
			get
			{
				if(r_SignatureAlgorithm == null)
				{
					r_SignatureAlgorithm = new(this, "SignatureAlgorithm", -1);
					r_SignatureAlgorithm.SetBelong(this.instance);
				}
				return r_SignatureAlgorithm;
			}
		}

		/// <summary>
		/// Int32 KeySize
		/// </summary>
		protected RProperty r_KeySize;
		public virtual RProperty RKeySize
		{
			get
			{
				if(r_KeySize == null)
				{
					r_KeySize = new(this, "KeySize", -1);
					r_KeySize.SetBelong(this.instance);
				}
				return r_KeySize;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.KeySizes[] LegalKeySizes
		/// </summary>
		protected RPropertyArray<RSystem.RSecurity.RCryptography.RKeySizes> r_LegalKeySizes;
		public virtual RPropertyArray<RSystem.RSecurity.RCryptography.RKeySizes> RLegalKeySizes
		{
			get
			{
				if(r_LegalKeySizes == null)
				{
					r_LegalKeySizes = new(this, "LegalKeySizes", -1);
					r_LegalKeySizes.SetBelong(this.instance);
				}
				return r_LegalKeySizes;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSA Create()
		/// </summary>
		protected static RMethod r_Create;
		public static RMethod RCreate
		{
			get
			{
				if(r_Create == null)
				{
					r_Create = new(typeof(System.Security.Cryptography.RSA), "Create", 0);
					r_Create.SetBelong(null);
				}
				return r_Create;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSA Create(System.String)
		/// </summary>
		protected static RMethod r_Create_String;
		public static RMethod RCreate_String
		{
			get
			{
				if(r_Create_String == null)
				{
					r_Create_String = new(typeof(System.Security.Cryptography.RSA), "Create", 0, typeof(System.String));
					r_Create_String.SetBelong(null);
				}
				return r_Create_String;
			}
		}

		/// <summary>
		/// Byte[] Encrypt(Byte[], System.Security.Cryptography.RSAEncryptionPadding)
		/// </summary>
		protected RMethod r_Encrypt_ByteArray_RSAEncryptionPadding;
		public virtual RMethod REncrypt_ByteArray_RSAEncryptionPadding
		{
			get
			{
				if(r_Encrypt_ByteArray_RSAEncryptionPadding == null)
				{
					r_Encrypt_ByteArray_RSAEncryptionPadding = new(this, "Encrypt", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Security.Cryptography.RSAEncryptionPadding));
					r_Encrypt_ByteArray_RSAEncryptionPadding.SetBelong(this.instance);
				}
				return r_Encrypt_ByteArray_RSAEncryptionPadding;
			}
		}

		/// <summary>
		/// Byte[] Decrypt(Byte[], System.Security.Cryptography.RSAEncryptionPadding)
		/// </summary>
		protected RMethod r_Decrypt_ByteArray_RSAEncryptionPadding;
		public virtual RMethod RDecrypt_ByteArray_RSAEncryptionPadding
		{
			get
			{
				if(r_Decrypt_ByteArray_RSAEncryptionPadding == null)
				{
					r_Decrypt_ByteArray_RSAEncryptionPadding = new(this, "Decrypt", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Security.Cryptography.RSAEncryptionPadding));
					r_Decrypt_ByteArray_RSAEncryptionPadding.SetBelong(this.instance);
				}
				return r_Decrypt_ByteArray_RSAEncryptionPadding;
			}
		}

		/// <summary>
		/// Byte[] SignHash(Byte[], System.Security.Cryptography.HashAlgorithmName, System.Security.Cryptography.RSASignaturePadding)
		/// </summary>
		protected RMethod r_SignHash_ByteArray_HashAlgorithmName_RSASignaturePadding;
		public virtual RMethod RSignHash_ByteArray_HashAlgorithmName_RSASignaturePadding
		{
			get
			{
				if(r_SignHash_ByteArray_HashAlgorithmName_RSASignaturePadding == null)
				{
					r_SignHash_ByteArray_HashAlgorithmName_RSASignaturePadding = new(this, "SignHash", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Security.Cryptography.RSASignaturePadding));
					r_SignHash_ByteArray_HashAlgorithmName_RSASignaturePadding.SetBelong(this.instance);
				}
				return r_SignHash_ByteArray_HashAlgorithmName_RSASignaturePadding;
			}
		}

		/// <summary>
		/// Boolean VerifyHash(Byte[], Byte[], System.Security.Cryptography.HashAlgorithmName, System.Security.Cryptography.RSASignaturePadding)
		/// </summary>
		protected RMethod r_VerifyHash_ByteArray_ByteArray_HashAlgorithmName_RSASignaturePadding;
		public virtual RMethod RVerifyHash_ByteArray_ByteArray_HashAlgorithmName_RSASignaturePadding
		{
			get
			{
				if(r_VerifyHash_ByteArray_ByteArray_HashAlgorithmName_RSASignaturePadding == null)
				{
					r_VerifyHash_ByteArray_ByteArray_HashAlgorithmName_RSASignaturePadding = new(this, "VerifyHash", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType(), typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Security.Cryptography.RSASignaturePadding));
					r_VerifyHash_ByteArray_ByteArray_HashAlgorithmName_RSASignaturePadding.SetBelong(this.instance);
				}
				return r_VerifyHash_ByteArray_ByteArray_HashAlgorithmName_RSASignaturePadding;
			}
		}

		/// <summary>
		/// Byte[] HashData(Byte[], Int32, Int32, System.Security.Cryptography.HashAlgorithmName)
		/// </summary>
		protected RMethod r_HashData_ByteArray_Int32_Int32_HashAlgorithmName;
		public virtual RMethod RHashData_ByteArray_Int32_Int32_HashAlgorithmName
		{
			get
			{
				if(r_HashData_ByteArray_Int32_Int32_HashAlgorithmName == null)
				{
					r_HashData_ByteArray_Int32_Int32_HashAlgorithmName = new(this, "HashData", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Security.Cryptography.HashAlgorithmName));
					r_HashData_ByteArray_Int32_Int32_HashAlgorithmName.SetBelong(this.instance);
				}
				return r_HashData_ByteArray_Int32_Int32_HashAlgorithmName;
			}
		}

		/// <summary>
		/// Byte[] HashData(System.IO.Stream, System.Security.Cryptography.HashAlgorithmName)
		/// </summary>
		protected RMethod r_HashData_Stream_HashAlgorithmName;
		public virtual RMethod RHashData_Stream_HashAlgorithmName
		{
			get
			{
				if(r_HashData_Stream_HashAlgorithmName == null)
				{
					r_HashData_Stream_HashAlgorithmName = new(this, "HashData", 0, typeof(System.IO.Stream), typeof(System.Security.Cryptography.HashAlgorithmName));
					r_HashData_Stream_HashAlgorithmName.SetBelong(this.instance);
				}
				return r_HashData_Stream_HashAlgorithmName;
			}
		}

		/// <summary>
		/// Byte[] SignData(Byte[], System.Security.Cryptography.HashAlgorithmName, System.Security.Cryptography.RSASignaturePadding)
		/// </summary>
		protected RMethod r_SignData_ByteArray_HashAlgorithmName_RSASignaturePadding;
		public virtual RMethod RSignData_ByteArray_HashAlgorithmName_RSASignaturePadding
		{
			get
			{
				if(r_SignData_ByteArray_HashAlgorithmName_RSASignaturePadding == null)
				{
					r_SignData_ByteArray_HashAlgorithmName_RSASignaturePadding = new(this, "SignData", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Security.Cryptography.RSASignaturePadding));
					r_SignData_ByteArray_HashAlgorithmName_RSASignaturePadding.SetBelong(this.instance);
				}
				return r_SignData_ByteArray_HashAlgorithmName_RSASignaturePadding;
			}
		}

		/// <summary>
		/// Byte[] SignData(Byte[], Int32, Int32, System.Security.Cryptography.HashAlgorithmName, System.Security.Cryptography.RSASignaturePadding)
		/// </summary>
		protected RMethod r_SignData_ByteArray_Int32_Int32_HashAlgorithmName_RSASignaturePadding;
		public virtual RMethod RSignData_ByteArray_Int32_Int32_HashAlgorithmName_RSASignaturePadding
		{
			get
			{
				if(r_SignData_ByteArray_Int32_Int32_HashAlgorithmName_RSASignaturePadding == null)
				{
					r_SignData_ByteArray_Int32_Int32_HashAlgorithmName_RSASignaturePadding = new(this, "SignData", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Security.Cryptography.RSASignaturePadding));
					r_SignData_ByteArray_Int32_Int32_HashAlgorithmName_RSASignaturePadding.SetBelong(this.instance);
				}
				return r_SignData_ByteArray_Int32_Int32_HashAlgorithmName_RSASignaturePadding;
			}
		}

		/// <summary>
		/// Byte[] SignData(System.IO.Stream, System.Security.Cryptography.HashAlgorithmName, System.Security.Cryptography.RSASignaturePadding)
		/// </summary>
		protected RMethod r_SignData_Stream_HashAlgorithmName_RSASignaturePadding;
		public virtual RMethod RSignData_Stream_HashAlgorithmName_RSASignaturePadding
		{
			get
			{
				if(r_SignData_Stream_HashAlgorithmName_RSASignaturePadding == null)
				{
					r_SignData_Stream_HashAlgorithmName_RSASignaturePadding = new(this, "SignData", 0, typeof(System.IO.Stream), typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Security.Cryptography.RSASignaturePadding));
					r_SignData_Stream_HashAlgorithmName_RSASignaturePadding.SetBelong(this.instance);
				}
				return r_SignData_Stream_HashAlgorithmName_RSASignaturePadding;
			}
		}

		/// <summary>
		/// Boolean VerifyData(Byte[], Byte[], System.Security.Cryptography.HashAlgorithmName, System.Security.Cryptography.RSASignaturePadding)
		/// </summary>
		protected RMethod r_VerifyData_ByteArray_ByteArray_HashAlgorithmName_RSASignaturePadding;
		public virtual RMethod RVerifyData_ByteArray_ByteArray_HashAlgorithmName_RSASignaturePadding
		{
			get
			{
				if(r_VerifyData_ByteArray_ByteArray_HashAlgorithmName_RSASignaturePadding == null)
				{
					r_VerifyData_ByteArray_ByteArray_HashAlgorithmName_RSASignaturePadding = new(this, "VerifyData", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType(), typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Security.Cryptography.RSASignaturePadding));
					r_VerifyData_ByteArray_ByteArray_HashAlgorithmName_RSASignaturePadding.SetBelong(this.instance);
				}
				return r_VerifyData_ByteArray_ByteArray_HashAlgorithmName_RSASignaturePadding;
			}
		}

		/// <summary>
		/// Boolean VerifyData(Byte[], Int32, Int32, Byte[], System.Security.Cryptography.HashAlgorithmName, System.Security.Cryptography.RSASignaturePadding)
		/// </summary>
		protected RMethod r_VerifyData_ByteArray_Int32_Int32_ByteArray_HashAlgorithmName_RSASignaturePadding;
		public virtual RMethod RVerifyData_ByteArray_Int32_Int32_ByteArray_HashAlgorithmName_RSASignaturePadding
		{
			get
			{
				if(r_VerifyData_ByteArray_Int32_Int32_ByteArray_HashAlgorithmName_RSASignaturePadding == null)
				{
					r_VerifyData_ByteArray_Int32_Int32_ByteArray_HashAlgorithmName_RSASignaturePadding = new(this, "VerifyData", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Byte).MakeArrayType(), typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Security.Cryptography.RSASignaturePadding));
					r_VerifyData_ByteArray_Int32_Int32_ByteArray_HashAlgorithmName_RSASignaturePadding.SetBelong(this.instance);
				}
				return r_VerifyData_ByteArray_Int32_Int32_ByteArray_HashAlgorithmName_RSASignaturePadding;
			}
		}

		/// <summary>
		/// Boolean VerifyData(System.IO.Stream, Byte[], System.Security.Cryptography.HashAlgorithmName, System.Security.Cryptography.RSASignaturePadding)
		/// </summary>
		protected RMethod r_VerifyData_Stream_ByteArray_HashAlgorithmName_RSASignaturePadding;
		public virtual RMethod RVerifyData_Stream_ByteArray_HashAlgorithmName_RSASignaturePadding
		{
			get
			{
				if(r_VerifyData_Stream_ByteArray_HashAlgorithmName_RSASignaturePadding == null)
				{
					r_VerifyData_Stream_ByteArray_HashAlgorithmName_RSASignaturePadding = new(this, "VerifyData", 0, typeof(System.IO.Stream), typeof(System.Byte).MakeArrayType(), typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Security.Cryptography.RSASignaturePadding));
					r_VerifyData_Stream_ByteArray_HashAlgorithmName_RSASignaturePadding.SetBelong(this.instance);
				}
				return r_VerifyData_Stream_ByteArray_HashAlgorithmName_RSASignaturePadding;
			}
		}

		/// <summary>
		/// System.Exception DerivedClassMustOverride()
		/// </summary>
		protected static RMethod r_DerivedClassMustOverride;
		public static RMethod RDerivedClassMustOverride
		{
			get
			{
				if(r_DerivedClassMustOverride == null)
				{
					r_DerivedClassMustOverride = new(typeof(System.Security.Cryptography.RSA), "DerivedClassMustOverride", 0);
					r_DerivedClassMustOverride.SetBelong(null);
				}
				return r_DerivedClassMustOverride;
			}
		}

		/// <summary>
		/// System.Exception HashAlgorithmNameNullOrEmpty()
		/// </summary>
		protected static RMethod r_HashAlgorithmNameNullOrEmpty;
		public static RMethod RHashAlgorithmNameNullOrEmpty
		{
			get
			{
				if(r_HashAlgorithmNameNullOrEmpty == null)
				{
					r_HashAlgorithmNameNullOrEmpty = new(typeof(System.Security.Cryptography.RSA), "HashAlgorithmNameNullOrEmpty", 0);
					r_HashAlgorithmNameNullOrEmpty.SetBelong(null);
				}
				return r_HashAlgorithmNameNullOrEmpty;
			}
		}

		/// <summary>
		/// Byte[] DecryptValue(Byte[])
		/// </summary>
		protected RMethod r_DecryptValue_ByteArray;
		public virtual RMethod RDecryptValue_ByteArray
		{
			get
			{
				if(r_DecryptValue_ByteArray == null)
				{
					r_DecryptValue_ByteArray = new(this, "DecryptValue", 0, typeof(System.Byte).MakeArrayType());
					r_DecryptValue_ByteArray.SetBelong(this.instance);
				}
				return r_DecryptValue_ByteArray;
			}
		}

		/// <summary>
		/// Byte[] EncryptValue(Byte[])
		/// </summary>
		protected RMethod r_EncryptValue_ByteArray;
		public virtual RMethod REncryptValue_ByteArray
		{
			get
			{
				if(r_EncryptValue_ByteArray == null)
				{
					r_EncryptValue_ByteArray = new(this, "EncryptValue", 0, typeof(System.Byte).MakeArrayType());
					r_EncryptValue_ByteArray.SetBelong(this.instance);
				}
				return r_EncryptValue_ByteArray;
			}
		}

		/// <summary>
		/// Void FromXmlString(System.String)
		/// </summary>
		protected RMethod r_FromXmlString_String;
		public virtual RMethod RFromXmlString_String
		{
			get
			{
				if(r_FromXmlString_String == null)
				{
					r_FromXmlString_String = new(this, "FromXmlString", 0, typeof(System.String));
					r_FromXmlString_String.SetBelong(this.instance);
				}
				return r_FromXmlString_String;
			}
		}

		/// <summary>
		/// System.String ToXmlString(Boolean)
		/// </summary>
		protected RMethod r_ToXmlString_Boolean;
		public virtual RMethod RToXmlString_Boolean
		{
			get
			{
				if(r_ToXmlString_Boolean == null)
				{
					r_ToXmlString_Boolean = new(this, "ToXmlString", 0, typeof(System.Boolean));
					r_ToXmlString_Boolean.SetBelong(this.instance);
				}
				return r_ToXmlString_Boolean;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSAParameters ExportParameters(Boolean)
		/// </summary>
		protected RMethod r_ExportParameters_Boolean;
		public virtual RMethod RExportParameters_Boolean
		{
			get
			{
				if(r_ExportParameters_Boolean == null)
				{
					r_ExportParameters_Boolean = new(this, "ExportParameters", 0, typeof(System.Boolean));
					r_ExportParameters_Boolean.SetBelong(this.instance);
				}
				return r_ExportParameters_Boolean;
			}
		}

		/// <summary>
		/// Void ImportParameters(System.Security.Cryptography.RSAParameters)
		/// </summary>
		protected RMethod r_ImportParameters_RSAParameters;
		public virtual RMethod RImportParameters_RSAParameters
		{
			get
			{
				if(r_ImportParameters_RSAParameters == null)
				{
					r_ImportParameters_RSAParameters = new(this, "ImportParameters", 0, typeof(System.Security.Cryptography.RSAParameters));
					r_ImportParameters_RSAParameters.SetBelong(this.instance);
				}
				return r_ImportParameters_RSAParameters;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSA Create(Int32)
		/// </summary>
		protected static RMethod r_Create_Int32;
		public static RMethod RCreate_Int32
		{
			get
			{
				if(r_Create_Int32 == null)
				{
					r_Create_Int32 = new(typeof(System.Security.Cryptography.RSA), "Create", 0, typeof(System.Int32));
					r_Create_Int32.SetBelong(null);
				}
				return r_Create_Int32;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSA Create(System.Security.Cryptography.RSAParameters)
		/// </summary>
		protected static RMethod r_Create_RSAParameters;
		public static RMethod RCreate_RSAParameters
		{
			get
			{
				if(r_Create_RSAParameters == null)
				{
					r_Create_RSAParameters = new(typeof(System.Security.Cryptography.RSA), "Create", 0, typeof(System.Security.Cryptography.RSAParameters));
					r_Create_RSAParameters.SetBelong(null);
				}
				return r_Create_RSAParameters;
			}
		}

		/// <summary>
		/// Boolean TryDecrypt(System.ReadOnlySpan`1[System.Byte], System.Span`1[System.Byte], System.Security.Cryptography.RSAEncryptionPadding, Int32 ByRef)
		/// </summary>
		protected RMethod r_TryDecrypt_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__RSAEncryptionPadding_Out_Int32;
		public virtual RMethod RTryDecrypt_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__RSAEncryptionPadding_Out_Int32
		{
			get
			{
				if(r_TryDecrypt_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__RSAEncryptionPadding_Out_Int32 == null)
				{
					r_TryDecrypt_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__RSAEncryptionPadding_Out_Int32 = new(this, "TryDecrypt", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Security.Cryptography.RSAEncryptionPadding), typeof(System.Int32).MakeByRefType());
					r_TryDecrypt_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__RSAEncryptionPadding_Out_Int32.SetBelong(this.instance);
				}
				return r_TryDecrypt_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__RSAEncryptionPadding_Out_Int32;
			}
		}

		/// <summary>
		/// Boolean TryEncrypt(System.ReadOnlySpan`1[System.Byte], System.Span`1[System.Byte], System.Security.Cryptography.RSAEncryptionPadding, Int32 ByRef)
		/// </summary>
		protected RMethod r_TryEncrypt_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__RSAEncryptionPadding_Out_Int32;
		public virtual RMethod RTryEncrypt_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__RSAEncryptionPadding_Out_Int32
		{
			get
			{
				if(r_TryEncrypt_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__RSAEncryptionPadding_Out_Int32 == null)
				{
					r_TryEncrypt_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__RSAEncryptionPadding_Out_Int32 = new(this, "TryEncrypt", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Security.Cryptography.RSAEncryptionPadding), typeof(System.Int32).MakeByRefType());
					r_TryEncrypt_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__RSAEncryptionPadding_Out_Int32.SetBelong(this.instance);
				}
				return r_TryEncrypt_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__RSAEncryptionPadding_Out_Int32;
			}
		}

		/// <summary>
		/// Boolean TryHashData(System.ReadOnlySpan`1[System.Byte], System.Span`1[System.Byte], System.Security.Cryptography.HashAlgorithmName, Int32 ByRef)
		/// </summary>
		protected RMethod r_TryHashData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_Out_Int32;
		public virtual RMethod RTryHashData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_Out_Int32
		{
			get
			{
				if(r_TryHashData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_Out_Int32 == null)
				{
					r_TryHashData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_Out_Int32 = new(this, "TryHashData", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Int32).MakeByRefType());
					r_TryHashData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_Out_Int32.SetBelong(this.instance);
				}
				return r_TryHashData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_Out_Int32;
			}
		}

		/// <summary>
		/// Boolean TrySignHash(System.ReadOnlySpan`1[System.Byte], System.Span`1[System.Byte], System.Security.Cryptography.HashAlgorithmName, System.Security.Cryptography.RSASignaturePadding, Int32 ByRef)
		/// </summary>
		protected RMethod r_TrySignHash_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_RSASignaturePadding_Out_Int32;
		public virtual RMethod RTrySignHash_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_RSASignaturePadding_Out_Int32
		{
			get
			{
				if(r_TrySignHash_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_RSASignaturePadding_Out_Int32 == null)
				{
					r_TrySignHash_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_RSASignaturePadding_Out_Int32 = new(this, "TrySignHash", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Security.Cryptography.RSASignaturePadding), typeof(System.Int32).MakeByRefType());
					r_TrySignHash_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_RSASignaturePadding_Out_Int32.SetBelong(this.instance);
				}
				return r_TrySignHash_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_RSASignaturePadding_Out_Int32;
			}
		}

		/// <summary>
		/// Boolean TrySignData(System.ReadOnlySpan`1[System.Byte], System.Span`1[System.Byte], System.Security.Cryptography.HashAlgorithmName, System.Security.Cryptography.RSASignaturePadding, Int32 ByRef)
		/// </summary>
		protected RMethod r_TrySignData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_RSASignaturePadding_Out_Int32;
		public virtual RMethod RTrySignData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_RSASignaturePadding_Out_Int32
		{
			get
			{
				if(r_TrySignData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_RSASignaturePadding_Out_Int32 == null)
				{
					r_TrySignData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_RSASignaturePadding_Out_Int32 = new(this, "TrySignData", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Security.Cryptography.RSASignaturePadding), typeof(System.Int32).MakeByRefType());
					r_TrySignData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_RSASignaturePadding_Out_Int32.SetBelong(this.instance);
				}
				return r_TrySignData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_RSASignaturePadding_Out_Int32;
			}
		}

		/// <summary>
		/// Boolean VerifyData(System.ReadOnlySpan`1[System.Byte], System.ReadOnlySpan`1[System.Byte], System.Security.Cryptography.HashAlgorithmName, System.Security.Cryptography.RSASignaturePadding)
		/// </summary>
		protected RMethod r_VerifyData_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__HashAlgorithmName_RSASignaturePadding;
		public virtual RMethod RVerifyData_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__HashAlgorithmName_RSASignaturePadding
		{
			get
			{
				if(r_VerifyData_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__HashAlgorithmName_RSASignaturePadding == null)
				{
					r_VerifyData_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__HashAlgorithmName_RSASignaturePadding = new(this, "VerifyData", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Security.Cryptography.RSASignaturePadding));
					r_VerifyData_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__HashAlgorithmName_RSASignaturePadding.SetBelong(this.instance);
				}
				return r_VerifyData_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__HashAlgorithmName_RSASignaturePadding;
			}
		}

		/// <summary>
		/// Boolean VerifyHash(System.ReadOnlySpan`1[System.Byte], System.ReadOnlySpan`1[System.Byte], System.Security.Cryptography.HashAlgorithmName, System.Security.Cryptography.RSASignaturePadding)
		/// </summary>
		protected RMethod r_VerifyHash_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__HashAlgorithmName_RSASignaturePadding;
		public virtual RMethod RVerifyHash_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__HashAlgorithmName_RSASignaturePadding
		{
			get
			{
				if(r_VerifyHash_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__HashAlgorithmName_RSASignaturePadding == null)
				{
					r_VerifyHash_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__HashAlgorithmName_RSASignaturePadding = new(this, "VerifyHash", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Security.Cryptography.RSASignaturePadding));
					r_VerifyHash_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__HashAlgorithmName_RSASignaturePadding.SetBelong(this.instance);
				}
				return r_VerifyHash_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__HashAlgorithmName_RSASignaturePadding;
			}
		}

		/// <summary>
		/// Byte[] ExportRSAPrivateKey()
		/// </summary>
		protected RMethod r_ExportRSAPrivateKey;
		public virtual RMethod RExportRSAPrivateKey
		{
			get
			{
				if(r_ExportRSAPrivateKey == null)
				{
					r_ExportRSAPrivateKey = new(this, "ExportRSAPrivateKey", 0);
					r_ExportRSAPrivateKey.SetBelong(this.instance);
				}
				return r_ExportRSAPrivateKey;
			}
		}

		/// <summary>
		/// Byte[] ExportRSAPublicKey()
		/// </summary>
		protected RMethod r_ExportRSAPublicKey;
		public virtual RMethod RExportRSAPublicKey
		{
			get
			{
				if(r_ExportRSAPublicKey == null)
				{
					r_ExportRSAPublicKey = new(this, "ExportRSAPublicKey", 0);
					r_ExportRSAPublicKey.SetBelong(this.instance);
				}
				return r_ExportRSAPublicKey;
			}
		}

		/// <summary>
		/// Void ImportRSAPrivateKey(System.ReadOnlySpan`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_ImportRSAPrivateKey_ReadOnlySpan_d_Byte_p__Out_Int32;
		public virtual RMethod RImportRSAPrivateKey_ReadOnlySpan_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_ImportRSAPrivateKey_ReadOnlySpan_d_Byte_p__Out_Int32 == null)
				{
					r_ImportRSAPrivateKey_ReadOnlySpan_d_Byte_p__Out_Int32 = new(this, "ImportRSAPrivateKey", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_ImportRSAPrivateKey_ReadOnlySpan_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_ImportRSAPrivateKey_ReadOnlySpan_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// Void ImportRSAPublicKey(System.ReadOnlySpan`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_ImportRSAPublicKey_ReadOnlySpan_d_Byte_p__Out_Int32;
		public virtual RMethod RImportRSAPublicKey_ReadOnlySpan_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_ImportRSAPublicKey_ReadOnlySpan_d_Byte_p__Out_Int32 == null)
				{
					r_ImportRSAPublicKey_ReadOnlySpan_d_Byte_p__Out_Int32 = new(this, "ImportRSAPublicKey", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_ImportRSAPublicKey_ReadOnlySpan_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_ImportRSAPublicKey_ReadOnlySpan_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// Boolean TryExportRSAPrivateKey(System.Span`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_TryExportRSAPrivateKey_Span_d_Byte_p__Out_Int32;
		public virtual RMethod RTryExportRSAPrivateKey_Span_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_TryExportRSAPrivateKey_Span_d_Byte_p__Out_Int32 == null)
				{
					r_TryExportRSAPrivateKey_Span_d_Byte_p__Out_Int32 = new(this, "TryExportRSAPrivateKey", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_TryExportRSAPrivateKey_Span_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_TryExportRSAPrivateKey_Span_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// Boolean TryExportRSAPublicKey(System.Span`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_TryExportRSAPublicKey_Span_d_Byte_p__Out_Int32;
		public virtual RMethod RTryExportRSAPublicKey_Span_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_TryExportRSAPublicKey_Span_d_Byte_p__Out_Int32 == null)
				{
					r_TryExportRSAPublicKey_Span_d_Byte_p__Out_Int32 = new(this, "TryExportRSAPublicKey", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_TryExportRSAPublicKey_Span_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_TryExportRSAPublicKey_Span_d_Byte_p__Out_Int32;
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
		/// Void Clear()
		/// </summary>
		protected RMethod r_Clear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_Clear == null)
				{
					r_Clear = new(this, "Clear", 0);
					r_Clear.SetBelong(this.instance);
				}
				return r_Clear;
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
		/// Byte[] ExportEncryptedPkcs8PrivateKey(System.ReadOnlySpan`1[System.Byte], System.Security.Cryptography.PbeParameters)
		/// </summary>
		protected RMethod r_ExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters;
		public virtual RMethod RExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters
		{
			get
			{
				if(r_ExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters == null)
				{
					r_ExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters = new(this, "ExportEncryptedPkcs8PrivateKey", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Security.Cryptography.PbeParameters));
					r_ExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters.SetBelong(this.instance);
				}
				return r_ExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters;
			}
		}

		/// <summary>
		/// Byte[] ExportEncryptedPkcs8PrivateKey(System.ReadOnlySpan`1[System.Char], System.Security.Cryptography.PbeParameters)
		/// </summary>
		protected RMethod r_ExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters;
		public virtual RMethod RExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters
		{
			get
			{
				if(r_ExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters == null)
				{
					r_ExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters = new(this, "ExportEncryptedPkcs8PrivateKey", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Security.Cryptography.PbeParameters));
					r_ExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters.SetBelong(this.instance);
				}
				return r_ExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters;
			}
		}

		/// <summary>
		/// Byte[] ExportPkcs8PrivateKey()
		/// </summary>
		protected RMethod r_ExportPkcs8PrivateKey;
		public virtual RMethod RExportPkcs8PrivateKey
		{
			get
			{
				if(r_ExportPkcs8PrivateKey == null)
				{
					r_ExportPkcs8PrivateKey = new(this, "ExportPkcs8PrivateKey", 0);
					r_ExportPkcs8PrivateKey.SetBelong(this.instance);
				}
				return r_ExportPkcs8PrivateKey;
			}
		}

		/// <summary>
		/// Byte[] ExportSubjectPublicKeyInfo()
		/// </summary>
		protected RMethod r_ExportSubjectPublicKeyInfo;
		public virtual RMethod RExportSubjectPublicKeyInfo
		{
			get
			{
				if(r_ExportSubjectPublicKeyInfo == null)
				{
					r_ExportSubjectPublicKeyInfo = new(this, "ExportSubjectPublicKeyInfo", 0);
					r_ExportSubjectPublicKeyInfo.SetBelong(this.instance);
				}
				return r_ExportSubjectPublicKeyInfo;
			}
		}

		/// <summary>
		/// Void ImportEncryptedPkcs8PrivateKey(System.ReadOnlySpan`1[System.Byte], System.ReadOnlySpan`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_ImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__Out_Int32;
		public virtual RMethod RImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_ImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__Out_Int32 == null)
				{
					r_ImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__Out_Int32 = new(this, "ImportEncryptedPkcs8PrivateKey", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_ImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_ImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// Void ImportEncryptedPkcs8PrivateKey(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_ImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Byte_p__Out_Int32;
		public virtual RMethod RImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_ImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Byte_p__Out_Int32 == null)
				{
					r_ImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Byte_p__Out_Int32 = new(this, "ImportEncryptedPkcs8PrivateKey", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_ImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_ImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// Void ImportPkcs8PrivateKey(System.ReadOnlySpan`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_ImportPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__Out_Int32;
		public virtual RMethod RImportPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_ImportPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__Out_Int32 == null)
				{
					r_ImportPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__Out_Int32 = new(this, "ImportPkcs8PrivateKey", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_ImportPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_ImportPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// Void ImportSubjectPublicKeyInfo(System.ReadOnlySpan`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_ImportSubjectPublicKeyInfo_ReadOnlySpan_d_Byte_p__Out_Int32;
		public virtual RMethod RImportSubjectPublicKeyInfo_ReadOnlySpan_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_ImportSubjectPublicKeyInfo_ReadOnlySpan_d_Byte_p__Out_Int32 == null)
				{
					r_ImportSubjectPublicKeyInfo_ReadOnlySpan_d_Byte_p__Out_Int32 = new(this, "ImportSubjectPublicKeyInfo", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_ImportSubjectPublicKeyInfo_ReadOnlySpan_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_ImportSubjectPublicKeyInfo_ReadOnlySpan_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// Boolean TryExportEncryptedPkcs8PrivateKey(System.ReadOnlySpan`1[System.Byte], System.Security.Cryptography.PbeParameters, System.Span`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_TryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters_Span_d_Byte_p__Out_Int32;
		public virtual RMethod RTryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters_Span_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_TryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters_Span_d_Byte_p__Out_Int32 == null)
				{
					r_TryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters_Span_d_Byte_p__Out_Int32 = new(this, "TryExportEncryptedPkcs8PrivateKey", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Security.Cryptography.PbeParameters), typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_TryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters_Span_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_TryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters_Span_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// Boolean TryExportEncryptedPkcs8PrivateKey(System.ReadOnlySpan`1[System.Char], System.Security.Cryptography.PbeParameters, System.Span`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_TryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters_Span_d_Byte_p__Out_Int32;
		public virtual RMethod RTryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters_Span_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_TryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters_Span_d_Byte_p__Out_Int32 == null)
				{
					r_TryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters_Span_d_Byte_p__Out_Int32 = new(this, "TryExportEncryptedPkcs8PrivateKey", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Security.Cryptography.PbeParameters), typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_TryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters_Span_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_TryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters_Span_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// Boolean TryExportPkcs8PrivateKey(System.Span`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_TryExportPkcs8PrivateKey_Span_d_Byte_p__Out_Int32;
		public virtual RMethod RTryExportPkcs8PrivateKey_Span_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_TryExportPkcs8PrivateKey_Span_d_Byte_p__Out_Int32 == null)
				{
					r_TryExportPkcs8PrivateKey_Span_d_Byte_p__Out_Int32 = new(this, "TryExportPkcs8PrivateKey", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_TryExportPkcs8PrivateKey_Span_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_TryExportPkcs8PrivateKey_Span_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// Boolean TryExportSubjectPublicKeyInfo(System.Span`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_TryExportSubjectPublicKeyInfo_Span_d_Byte_p__Out_Int32;
		public virtual RMethod RTryExportSubjectPublicKeyInfo_Span_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_TryExportSubjectPublicKeyInfo_Span_d_Byte_p__Out_Int32 == null)
				{
					r_TryExportSubjectPublicKeyInfo_Span_d_Byte_p__Out_Int32 = new(this, "TryExportSubjectPublicKeyInfo", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_TryExportSubjectPublicKeyInfo_Span_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_TryExportSubjectPublicKeyInfo_Span_d_Byte_p__Out_Int32;
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
            var ___result = RCreate.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.RSA)___result;
        }


        public static System.Security.Cryptography.RSA Create(System.String @algName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@algName};
            var ___result = RCreate_String.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.RSA)___result;
        }


        public virtual System.Byte[] Encrypt(System.Byte[] @data, System.Security.Cryptography.RSAEncryptionPadding @padding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @padding};
            var ___result = REncrypt_ByteArray_RSAEncryptionPadding.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] Decrypt(System.Byte[] @data, System.Security.Cryptography.RSAEncryptionPadding @padding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @padding};
            var ___result = RDecrypt_ByteArray_RSAEncryptionPadding.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] SignHash(System.Byte[] @hash, System.Security.Cryptography.HashAlgorithmName @hashAlgorithm, System.Security.Cryptography.RSASignaturePadding @padding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hash, @hashAlgorithm, @padding};
            var ___result = RSignHash_ByteArray_HashAlgorithmName_RSASignaturePadding.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Boolean VerifyHash(System.Byte[] @hash, System.Byte[] @signature, System.Security.Cryptography.HashAlgorithmName @hashAlgorithm, System.Security.Cryptography.RSASignaturePadding @padding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hash, @signature, @hashAlgorithm, @padding};
            var ___result = RVerifyHash_ByteArray_ByteArray_HashAlgorithmName_RSASignaturePadding.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Byte[] HashData(System.Byte[] @data, System.Int32 @offset, System.Int32 @count, System.Security.Cryptography.HashAlgorithmName @hashAlgorithm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @offset, @count, @hashAlgorithm};
            var ___result = RHashData_ByteArray_Int32_Int32_HashAlgorithmName.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] HashData(System.IO.Stream @data, System.Security.Cryptography.HashAlgorithmName @hashAlgorithm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @hashAlgorithm};
            var ___result = RHashData_Stream_HashAlgorithmName.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] SignData(System.Byte[] @data, System.Security.Cryptography.HashAlgorithmName @hashAlgorithm, System.Security.Cryptography.RSASignaturePadding @padding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @hashAlgorithm, @padding};
            var ___result = RSignData_ByteArray_HashAlgorithmName_RSASignaturePadding.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] SignData(System.Byte[] @data, System.Int32 @offset, System.Int32 @count, System.Security.Cryptography.HashAlgorithmName @hashAlgorithm, System.Security.Cryptography.RSASignaturePadding @padding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @offset, @count, @hashAlgorithm, @padding};
            var ___result = RSignData_ByteArray_Int32_Int32_HashAlgorithmName_RSASignaturePadding.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] SignData(System.IO.Stream @data, System.Security.Cryptography.HashAlgorithmName @hashAlgorithm, System.Security.Cryptography.RSASignaturePadding @padding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @hashAlgorithm, @padding};
            var ___result = RSignData_Stream_HashAlgorithmName_RSASignaturePadding.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Boolean VerifyData(System.Byte[] @data, System.Byte[] @signature, System.Security.Cryptography.HashAlgorithmName @hashAlgorithm, System.Security.Cryptography.RSASignaturePadding @padding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @signature, @hashAlgorithm, @padding};
            var ___result = RVerifyData_ByteArray_ByteArray_HashAlgorithmName_RSASignaturePadding.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean VerifyData(System.Byte[] @data, System.Int32 @offset, System.Int32 @count, System.Byte[] @signature, System.Security.Cryptography.HashAlgorithmName @hashAlgorithm, System.Security.Cryptography.RSASignaturePadding @padding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @offset, @count, @signature, @hashAlgorithm, @padding};
            var ___result = RVerifyData_ByteArray_Int32_Int32_ByteArray_HashAlgorithmName_RSASignaturePadding.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean VerifyData(System.IO.Stream @data, System.Byte[] @signature, System.Security.Cryptography.HashAlgorithmName @hashAlgorithm, System.Security.Cryptography.RSASignaturePadding @padding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @signature, @hashAlgorithm, @padding};
            var ___result = RVerifyData_Stream_ByteArray_HashAlgorithmName_RSASignaturePadding.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Exception DerivedClassMustOverride()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDerivedClassMustOverride.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public static System.Exception HashAlgorithmNameNullOrEmpty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHashAlgorithmNameNullOrEmpty.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual System.Byte[] DecryptValue(System.Byte[] @rgb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rgb};
            var ___result = RDecryptValue_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] EncryptValue(System.Byte[] @rgb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rgb};
            var ___result = REncryptValue_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual void FromXmlString(System.String @xmlString)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xmlString};
            var ___result = RFromXmlString_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToXmlString(System.Boolean @includePrivateParameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@includePrivateParameters};
            var ___result = RToXmlString_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Security.Cryptography.RSAParameters ExportParameters(System.Boolean @includePrivateParameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@includePrivateParameters};
            var ___result = RExportParameters_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.RSAParameters)___result;
        }


        public virtual void ImportParameters(System.Security.Cryptography.RSAParameters @parameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parameters};
            var ___result = RImportParameters_RSAParameters.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Security.Cryptography.RSA Create(System.Int32 @keySizeInBits)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keySizeInBits};
            var ___result = RCreate_Int32.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.RSA)___result;
        }


        public static System.Security.Cryptography.RSA Create(System.Security.Cryptography.RSAParameters @parameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parameters};
            var ___result = RCreate_RSAParameters.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.RSA)___result;
        }









        public virtual System.Byte[] ExportRSAPrivateKey()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RExportRSAPrivateKey.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] ExportRSAPublicKey()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RExportRSAPublicKey.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }






        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }




        public virtual System.Byte[] ExportPkcs8PrivateKey()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RExportPkcs8PrivateKey.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] ExportSubjectPublicKeyInfo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RExportSubjectPublicKeyInfo.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }










        public virtual System.Boolean Equals(System.Object @obj)
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
