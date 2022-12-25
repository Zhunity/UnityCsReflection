using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography
{
	/// <summary>
	/// System.Security.Cryptography.DSA
	/// </summary>
    public partial class RDSA : RMember //
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
		/// System.Security.Cryptography.DSA Create()
		/// </summary>
		protected static RMethod r_RCreate;
		public static RMethod RCreate
		{
			get
			{
				if(r_RCreate == null)
				{
					r_RCreate = new(typeof(System.Security.Cryptography.DSA), "Create", 0);
					r_RCreate.SetBelong(null);
				}
				return r_RCreate;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.DSA Create(System.String)
		/// </summary>
		protected static RMethod r_RCreate_String;
		public static RMethod RCreate_String
		{
			get
			{
				if(r_RCreate_String == null)
				{
					r_RCreate_String = new(typeof(System.Security.Cryptography.DSA), "Create", 0, typeof(System.String));
					r_RCreate_String.SetBelong(null);
				}
				return r_RCreate_String;
			}
		}

		/// <summary>
		/// Byte[] CreateSignature(Byte[])
		/// </summary>
		protected RMethod r_RCreateSignature_ByteArray;
		public virtual RMethod RCreateSignature_ByteArray
		{
			get
			{
				if(r_RCreateSignature_ByteArray == null)
				{
					r_RCreateSignature_ByteArray = new(this, "CreateSignature", 0, typeof(System.Byte).MakeArrayType());
					r_RCreateSignature_ByteArray.SetBelong(this.instance);
				}
				return r_RCreateSignature_ByteArray;
			}
		}

		/// <summary>
		/// Boolean VerifySignature(Byte[], Byte[])
		/// </summary>
		protected RMethod r_RVerifySignature_ByteArray_ByteArray;
		public virtual RMethod RVerifySignature_ByteArray_ByteArray
		{
			get
			{
				if(r_RVerifySignature_ByteArray_ByteArray == null)
				{
					r_RVerifySignature_ByteArray_ByteArray = new(this, "VerifySignature", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType());
					r_RVerifySignature_ByteArray_ByteArray.SetBelong(this.instance);
				}
				return r_RVerifySignature_ByteArray_ByteArray;
			}
		}

		/// <summary>
		/// Byte[] HashData(Byte[], Int32, Int32, System.Security.Cryptography.HashAlgorithmName)
		/// </summary>
		protected RMethod r_RHashData_ByteArray_Int32_Int32_HashAlgorithmName;
		public virtual RMethod RHashData_ByteArray_Int32_Int32_HashAlgorithmName
		{
			get
			{
				if(r_RHashData_ByteArray_Int32_Int32_HashAlgorithmName == null)
				{
					r_RHashData_ByteArray_Int32_Int32_HashAlgorithmName = new(this, "HashData", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Security.Cryptography.HashAlgorithmName));
					r_RHashData_ByteArray_Int32_Int32_HashAlgorithmName.SetBelong(this.instance);
				}
				return r_RHashData_ByteArray_Int32_Int32_HashAlgorithmName;
			}
		}

		/// <summary>
		/// Byte[] HashData(System.IO.Stream, System.Security.Cryptography.HashAlgorithmName)
		/// </summary>
		protected RMethod r_RHashData_Stream_HashAlgorithmName;
		public virtual RMethod RHashData_Stream_HashAlgorithmName
		{
			get
			{
				if(r_RHashData_Stream_HashAlgorithmName == null)
				{
					r_RHashData_Stream_HashAlgorithmName = new(this, "HashData", 0, typeof(System.IO.Stream), typeof(System.Security.Cryptography.HashAlgorithmName));
					r_RHashData_Stream_HashAlgorithmName.SetBelong(this.instance);
				}
				return r_RHashData_Stream_HashAlgorithmName;
			}
		}

		/// <summary>
		/// Byte[] SignData(Byte[], System.Security.Cryptography.HashAlgorithmName)
		/// </summary>
		protected RMethod r_RSignData_ByteArray_HashAlgorithmName;
		public virtual RMethod RSignData_ByteArray_HashAlgorithmName
		{
			get
			{
				if(r_RSignData_ByteArray_HashAlgorithmName == null)
				{
					r_RSignData_ByteArray_HashAlgorithmName = new(this, "SignData", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Security.Cryptography.HashAlgorithmName));
					r_RSignData_ByteArray_HashAlgorithmName.SetBelong(this.instance);
				}
				return r_RSignData_ByteArray_HashAlgorithmName;
			}
		}

		/// <summary>
		/// Byte[] SignData(Byte[], Int32, Int32, System.Security.Cryptography.HashAlgorithmName)
		/// </summary>
		protected RMethod r_RSignData_ByteArray_Int32_Int32_HashAlgorithmName;
		public virtual RMethod RSignData_ByteArray_Int32_Int32_HashAlgorithmName
		{
			get
			{
				if(r_RSignData_ByteArray_Int32_Int32_HashAlgorithmName == null)
				{
					r_RSignData_ByteArray_Int32_Int32_HashAlgorithmName = new(this, "SignData", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Security.Cryptography.HashAlgorithmName));
					r_RSignData_ByteArray_Int32_Int32_HashAlgorithmName.SetBelong(this.instance);
				}
				return r_RSignData_ByteArray_Int32_Int32_HashAlgorithmName;
			}
		}

		/// <summary>
		/// Byte[] SignData(System.IO.Stream, System.Security.Cryptography.HashAlgorithmName)
		/// </summary>
		protected RMethod r_RSignData_Stream_HashAlgorithmName;
		public virtual RMethod RSignData_Stream_HashAlgorithmName
		{
			get
			{
				if(r_RSignData_Stream_HashAlgorithmName == null)
				{
					r_RSignData_Stream_HashAlgorithmName = new(this, "SignData", 0, typeof(System.IO.Stream), typeof(System.Security.Cryptography.HashAlgorithmName));
					r_RSignData_Stream_HashAlgorithmName.SetBelong(this.instance);
				}
				return r_RSignData_Stream_HashAlgorithmName;
			}
		}

		/// <summary>
		/// Boolean VerifyData(Byte[], Byte[], System.Security.Cryptography.HashAlgorithmName)
		/// </summary>
		protected RMethod r_RVerifyData_ByteArray_ByteArray_HashAlgorithmName;
		public virtual RMethod RVerifyData_ByteArray_ByteArray_HashAlgorithmName
		{
			get
			{
				if(r_RVerifyData_ByteArray_ByteArray_HashAlgorithmName == null)
				{
					r_RVerifyData_ByteArray_ByteArray_HashAlgorithmName = new(this, "VerifyData", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType(), typeof(System.Security.Cryptography.HashAlgorithmName));
					r_RVerifyData_ByteArray_ByteArray_HashAlgorithmName.SetBelong(this.instance);
				}
				return r_RVerifyData_ByteArray_ByteArray_HashAlgorithmName;
			}
		}

		/// <summary>
		/// Boolean VerifyData(Byte[], Int32, Int32, Byte[], System.Security.Cryptography.HashAlgorithmName)
		/// </summary>
		protected RMethod r_RVerifyData_ByteArray_Int32_Int32_ByteArray_HashAlgorithmName;
		public virtual RMethod RVerifyData_ByteArray_Int32_Int32_ByteArray_HashAlgorithmName
		{
			get
			{
				if(r_RVerifyData_ByteArray_Int32_Int32_ByteArray_HashAlgorithmName == null)
				{
					r_RVerifyData_ByteArray_Int32_Int32_ByteArray_HashAlgorithmName = new(this, "VerifyData", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Byte).MakeArrayType(), typeof(System.Security.Cryptography.HashAlgorithmName));
					r_RVerifyData_ByteArray_Int32_Int32_ByteArray_HashAlgorithmName.SetBelong(this.instance);
				}
				return r_RVerifyData_ByteArray_Int32_Int32_ByteArray_HashAlgorithmName;
			}
		}

		/// <summary>
		/// Boolean VerifyData(System.IO.Stream, Byte[], System.Security.Cryptography.HashAlgorithmName)
		/// </summary>
		protected RMethod r_RVerifyData_Stream_ByteArray_HashAlgorithmName;
		public virtual RMethod RVerifyData_Stream_ByteArray_HashAlgorithmName
		{
			get
			{
				if(r_RVerifyData_Stream_ByteArray_HashAlgorithmName == null)
				{
					r_RVerifyData_Stream_ByteArray_HashAlgorithmName = new(this, "VerifyData", 0, typeof(System.IO.Stream), typeof(System.Byte).MakeArrayType(), typeof(System.Security.Cryptography.HashAlgorithmName));
					r_RVerifyData_Stream_ByteArray_HashAlgorithmName.SetBelong(this.instance);
				}
				return r_RVerifyData_Stream_ByteArray_HashAlgorithmName;
			}
		}

		/// <summary>
		/// Void FromXmlString(System.String)
		/// </summary>
		protected RMethod r_RFromXmlString_String;
		public virtual RMethod RFromXmlString_String
		{
			get
			{
				if(r_RFromXmlString_String == null)
				{
					r_RFromXmlString_String = new(this, "FromXmlString", 0, typeof(System.String));
					r_RFromXmlString_String.SetBelong(this.instance);
				}
				return r_RFromXmlString_String;
			}
		}

		/// <summary>
		/// System.String ToXmlString(Boolean)
		/// </summary>
		protected RMethod r_RToXmlString_Boolean;
		public virtual RMethod RToXmlString_Boolean
		{
			get
			{
				if(r_RToXmlString_Boolean == null)
				{
					r_RToXmlString_Boolean = new(this, "ToXmlString", 0, typeof(System.Boolean));
					r_RToXmlString_Boolean.SetBelong(this.instance);
				}
				return r_RToXmlString_Boolean;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.DSAParameters ExportParameters(Boolean)
		/// </summary>
		protected RMethod r_RExportParameters_Boolean;
		public virtual RMethod RExportParameters_Boolean
		{
			get
			{
				if(r_RExportParameters_Boolean == null)
				{
					r_RExportParameters_Boolean = new(this, "ExportParameters", 0, typeof(System.Boolean));
					r_RExportParameters_Boolean.SetBelong(this.instance);
				}
				return r_RExportParameters_Boolean;
			}
		}

		/// <summary>
		/// Void ImportParameters(System.Security.Cryptography.DSAParameters)
		/// </summary>
		protected RMethod r_RImportParameters_DSAParameters;
		public virtual RMethod RImportParameters_DSAParameters
		{
			get
			{
				if(r_RImportParameters_DSAParameters == null)
				{
					r_RImportParameters_DSAParameters = new(this, "ImportParameters", 0, typeof(System.Security.Cryptography.DSAParameters));
					r_RImportParameters_DSAParameters.SetBelong(this.instance);
				}
				return r_RImportParameters_DSAParameters;
			}
		}

		/// <summary>
		/// System.Exception DerivedClassMustOverride()
		/// </summary>
		protected static RMethod r_RDerivedClassMustOverride;
		public static RMethod RDerivedClassMustOverride
		{
			get
			{
				if(r_RDerivedClassMustOverride == null)
				{
					r_RDerivedClassMustOverride = new(typeof(System.Security.Cryptography.DSA), "DerivedClassMustOverride", 0);
					r_RDerivedClassMustOverride.SetBelong(null);
				}
				return r_RDerivedClassMustOverride;
			}
		}

		/// <summary>
		/// System.Exception HashAlgorithmNameNullOrEmpty()
		/// </summary>
		protected static RMethod r_RHashAlgorithmNameNullOrEmpty;
		public static RMethod RHashAlgorithmNameNullOrEmpty
		{
			get
			{
				if(r_RHashAlgorithmNameNullOrEmpty == null)
				{
					r_RHashAlgorithmNameNullOrEmpty = new(typeof(System.Security.Cryptography.DSA), "HashAlgorithmNameNullOrEmpty", 0);
					r_RHashAlgorithmNameNullOrEmpty.SetBelong(null);
				}
				return r_RHashAlgorithmNameNullOrEmpty;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.DSA Create(Int32)
		/// </summary>
		protected static RMethod r_RCreate_Int32;
		public static RMethod RCreate_Int32
		{
			get
			{
				if(r_RCreate_Int32 == null)
				{
					r_RCreate_Int32 = new(typeof(System.Security.Cryptography.DSA), "Create", 0, typeof(System.Int32));
					r_RCreate_Int32.SetBelong(null);
				}
				return r_RCreate_Int32;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.DSA Create(System.Security.Cryptography.DSAParameters)
		/// </summary>
		protected static RMethod r_RCreate_DSAParameters;
		public static RMethod RCreate_DSAParameters
		{
			get
			{
				if(r_RCreate_DSAParameters == null)
				{
					r_RCreate_DSAParameters = new(typeof(System.Security.Cryptography.DSA), "Create", 0, typeof(System.Security.Cryptography.DSAParameters));
					r_RCreate_DSAParameters.SetBelong(null);
				}
				return r_RCreate_DSAParameters;
			}
		}

		/// <summary>
		/// Boolean TryCreateSignature(System.ReadOnlySpan`1[System.Byte], System.Span`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_RTryCreateSignature_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__Out_Int32;
		public virtual RMethod RTryCreateSignature_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_RTryCreateSignature_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__Out_Int32 == null)
				{
					r_RTryCreateSignature_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__Out_Int32 = new(this, "TryCreateSignature", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_RTryCreateSignature_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_RTryCreateSignature_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// Boolean TryHashData(System.ReadOnlySpan`1[System.Byte], System.Span`1[System.Byte], System.Security.Cryptography.HashAlgorithmName, Int32 ByRef)
		/// </summary>
		protected RMethod r_RTryHashData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_Out_Int32;
		public virtual RMethod RTryHashData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_Out_Int32
		{
			get
			{
				if(r_RTryHashData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_Out_Int32 == null)
				{
					r_RTryHashData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_Out_Int32 = new(this, "TryHashData", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Int32).MakeByRefType());
					r_RTryHashData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_Out_Int32.SetBelong(this.instance);
				}
				return r_RTryHashData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_Out_Int32;
			}
		}

		/// <summary>
		/// Boolean TrySignData(System.ReadOnlySpan`1[System.Byte], System.Span`1[System.Byte], System.Security.Cryptography.HashAlgorithmName, Int32 ByRef)
		/// </summary>
		protected RMethod r_RTrySignData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_Out_Int32;
		public virtual RMethod RTrySignData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_Out_Int32
		{
			get
			{
				if(r_RTrySignData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_Out_Int32 == null)
				{
					r_RTrySignData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_Out_Int32 = new(this, "TrySignData", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Int32).MakeByRefType());
					r_RTrySignData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_Out_Int32.SetBelong(this.instance);
				}
				return r_RTrySignData_ReadOnlySpan_d_Byte_p__Span_d_Byte_p__HashAlgorithmName_Out_Int32;
			}
		}

		/// <summary>
		/// Boolean VerifyData(System.ReadOnlySpan`1[System.Byte], System.ReadOnlySpan`1[System.Byte], System.Security.Cryptography.HashAlgorithmName)
		/// </summary>
		protected RMethod r_RVerifyData_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__HashAlgorithmName;
		public virtual RMethod RVerifyData_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__HashAlgorithmName
		{
			get
			{
				if(r_RVerifyData_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__HashAlgorithmName == null)
				{
					r_RVerifyData_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__HashAlgorithmName = new(this, "VerifyData", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Security.Cryptography.HashAlgorithmName));
					r_RVerifyData_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__HashAlgorithmName.SetBelong(this.instance);
				}
				return r_RVerifyData_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__HashAlgorithmName;
			}
		}

		/// <summary>
		/// Boolean VerifySignature(System.ReadOnlySpan`1[System.Byte], System.ReadOnlySpan`1[System.Byte])
		/// </summary>
		protected RMethod r_RVerifySignature_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p_;
		public virtual RMethod RVerifySignature_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p_
		{
			get
			{
				if(r_RVerifySignature_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p_ == null)
				{
					r_RVerifySignature_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p_ = new(this, "VerifySignature", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)));
					r_RVerifySignature_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p_.SetBelong(this.instance);
				}
				return r_RVerifySignature_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p_;
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
		/// Void Clear()
		/// </summary>
		protected RMethod r_RClear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_RClear == null)
				{
					r_RClear = new(this, "Clear", 0);
					r_RClear.SetBelong(this.instance);
				}
				return r_RClear;
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
		/// Byte[] ExportEncryptedPkcs8PrivateKey(System.ReadOnlySpan`1[System.Byte], System.Security.Cryptography.PbeParameters)
		/// </summary>
		protected RMethod r_RExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters;
		public virtual RMethod RExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters
		{
			get
			{
				if(r_RExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters == null)
				{
					r_RExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters = new(this, "ExportEncryptedPkcs8PrivateKey", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Security.Cryptography.PbeParameters));
					r_RExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters.SetBelong(this.instance);
				}
				return r_RExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters;
			}
		}

		/// <summary>
		/// Byte[] ExportEncryptedPkcs8PrivateKey(System.ReadOnlySpan`1[System.Char], System.Security.Cryptography.PbeParameters)
		/// </summary>
		protected RMethod r_RExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters;
		public virtual RMethod RExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters
		{
			get
			{
				if(r_RExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters == null)
				{
					r_RExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters = new(this, "ExportEncryptedPkcs8PrivateKey", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Security.Cryptography.PbeParameters));
					r_RExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters.SetBelong(this.instance);
				}
				return r_RExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters;
			}
		}

		/// <summary>
		/// Byte[] ExportPkcs8PrivateKey()
		/// </summary>
		protected RMethod r_RExportPkcs8PrivateKey;
		public virtual RMethod RExportPkcs8PrivateKey
		{
			get
			{
				if(r_RExportPkcs8PrivateKey == null)
				{
					r_RExportPkcs8PrivateKey = new(this, "ExportPkcs8PrivateKey", 0);
					r_RExportPkcs8PrivateKey.SetBelong(this.instance);
				}
				return r_RExportPkcs8PrivateKey;
			}
		}

		/// <summary>
		/// Byte[] ExportSubjectPublicKeyInfo()
		/// </summary>
		protected RMethod r_RExportSubjectPublicKeyInfo;
		public virtual RMethod RExportSubjectPublicKeyInfo
		{
			get
			{
				if(r_RExportSubjectPublicKeyInfo == null)
				{
					r_RExportSubjectPublicKeyInfo = new(this, "ExportSubjectPublicKeyInfo", 0);
					r_RExportSubjectPublicKeyInfo.SetBelong(this.instance);
				}
				return r_RExportSubjectPublicKeyInfo;
			}
		}

		/// <summary>
		/// Void ImportEncryptedPkcs8PrivateKey(System.ReadOnlySpan`1[System.Byte], System.ReadOnlySpan`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_RImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__Out_Int32;
		public virtual RMethod RImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_RImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__Out_Int32 == null)
				{
					r_RImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__Out_Int32 = new(this, "ImportEncryptedPkcs8PrivateKey", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_RImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_RImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__ReadOnlySpan_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// Void ImportEncryptedPkcs8PrivateKey(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_RImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Byte_p__Out_Int32;
		public virtual RMethod RImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_RImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Byte_p__Out_Int32 == null)
				{
					r_RImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Byte_p__Out_Int32 = new(this, "ImportEncryptedPkcs8PrivateKey", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_RImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_RImportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// Void ImportPkcs8PrivateKey(System.ReadOnlySpan`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_RImportPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__Out_Int32;
		public virtual RMethod RImportPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_RImportPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__Out_Int32 == null)
				{
					r_RImportPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__Out_Int32 = new(this, "ImportPkcs8PrivateKey", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_RImportPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_RImportPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// Void ImportSubjectPublicKeyInfo(System.ReadOnlySpan`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_RImportSubjectPublicKeyInfo_ReadOnlySpan_d_Byte_p__Out_Int32;
		public virtual RMethod RImportSubjectPublicKeyInfo_ReadOnlySpan_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_RImportSubjectPublicKeyInfo_ReadOnlySpan_d_Byte_p__Out_Int32 == null)
				{
					r_RImportSubjectPublicKeyInfo_ReadOnlySpan_d_Byte_p__Out_Int32 = new(this, "ImportSubjectPublicKeyInfo", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_RImportSubjectPublicKeyInfo_ReadOnlySpan_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_RImportSubjectPublicKeyInfo_ReadOnlySpan_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// Boolean TryExportEncryptedPkcs8PrivateKey(System.ReadOnlySpan`1[System.Byte], System.Security.Cryptography.PbeParameters, System.Span`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_RTryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters_Span_d_Byte_p__Out_Int32;
		public virtual RMethod RTryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters_Span_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_RTryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters_Span_d_Byte_p__Out_Int32 == null)
				{
					r_RTryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters_Span_d_Byte_p__Out_Int32 = new(this, "TryExportEncryptedPkcs8PrivateKey", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Security.Cryptography.PbeParameters), typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_RTryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters_Span_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_RTryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Byte_p__PbeParameters_Span_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// Boolean TryExportEncryptedPkcs8PrivateKey(System.ReadOnlySpan`1[System.Char], System.Security.Cryptography.PbeParameters, System.Span`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_RTryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters_Span_d_Byte_p__Out_Int32;
		public virtual RMethod RTryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters_Span_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_RTryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters_Span_d_Byte_p__Out_Int32 == null)
				{
					r_RTryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters_Span_d_Byte_p__Out_Int32 = new(this, "TryExportEncryptedPkcs8PrivateKey", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Security.Cryptography.PbeParameters), typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_RTryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters_Span_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_RTryExportEncryptedPkcs8PrivateKey_ReadOnlySpan_d_Char_p__PbeParameters_Span_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// Boolean TryExportPkcs8PrivateKey(System.Span`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_RTryExportPkcs8PrivateKey_Span_d_Byte_p__Out_Int32;
		public virtual RMethod RTryExportPkcs8PrivateKey_Span_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_RTryExportPkcs8PrivateKey_Span_d_Byte_p__Out_Int32 == null)
				{
					r_RTryExportPkcs8PrivateKey_Span_d_Byte_p__Out_Int32 = new(this, "TryExportPkcs8PrivateKey", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_RTryExportPkcs8PrivateKey_Span_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_RTryExportPkcs8PrivateKey_Span_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// Boolean TryExportSubjectPublicKeyInfo(System.Span`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_RTryExportSubjectPublicKeyInfo_Span_d_Byte_p__Out_Int32;
		public virtual RMethod RTryExportSubjectPublicKeyInfo_Span_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_RTryExportSubjectPublicKeyInfo_Span_d_Byte_p__Out_Int32 == null)
				{
					r_RTryExportSubjectPublicKeyInfo_Span_d_Byte_p__Out_Int32 = new(this, "TryExportSubjectPublicKeyInfo", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_RTryExportSubjectPublicKeyInfo_Span_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_RTryExportSubjectPublicKeyInfo_Span_d_Byte_p__Out_Int32;
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


        public RDSA() : base("System.Security.Cryptography.DSA")
        {
        }

        public RDSA(System.Object instance) : base("System.Security.Cryptography.DSA")
		{
            SetInstance(instance);
		}

        public RDSA(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDSA(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Security.Cryptography.DSA Create()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreate.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.DSA)___result;
        }


        public static System.Security.Cryptography.DSA Create(System.String  @algName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@algName};
            var ___result = RCreate_String.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.DSA)___result;
        }


        public virtual System.Byte[] CreateSignature(System.Byte[]  @rgbHash)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rgbHash};
            var ___result = RCreateSignature_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Boolean VerifySignature(System.Byte[]  @rgbHash, System.Byte[]  @rgbSignature)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rgbHash, @rgbSignature};
            var ___result = RVerifySignature_ByteArray_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Byte[] HashData(System.Byte[]  @data, System.Int32  @offset, System.Int32  @count, System.Security.Cryptography.HashAlgorithmName  @hashAlgorithm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @offset, @count, @hashAlgorithm};
            var ___result = RHashData_ByteArray_Int32_Int32_HashAlgorithmName.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] HashData(System.IO.Stream  @data, System.Security.Cryptography.HashAlgorithmName  @hashAlgorithm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @hashAlgorithm};
            var ___result = RHashData_Stream_HashAlgorithmName.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] SignData(System.Byte[]  @data, System.Security.Cryptography.HashAlgorithmName  @hashAlgorithm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @hashAlgorithm};
            var ___result = RSignData_ByteArray_HashAlgorithmName.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] SignData(System.Byte[]  @data, System.Int32  @offset, System.Int32  @count, System.Security.Cryptography.HashAlgorithmName  @hashAlgorithm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @offset, @count, @hashAlgorithm};
            var ___result = RSignData_ByteArray_Int32_Int32_HashAlgorithmName.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] SignData(System.IO.Stream  @data, System.Security.Cryptography.HashAlgorithmName  @hashAlgorithm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @hashAlgorithm};
            var ___result = RSignData_Stream_HashAlgorithmName.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Boolean VerifyData(System.Byte[]  @data, System.Byte[]  @signature, System.Security.Cryptography.HashAlgorithmName  @hashAlgorithm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @signature, @hashAlgorithm};
            var ___result = RVerifyData_ByteArray_ByteArray_HashAlgorithmName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean VerifyData(System.Byte[]  @data, System.Int32  @offset, System.Int32  @count, System.Byte[]  @signature, System.Security.Cryptography.HashAlgorithmName  @hashAlgorithm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @offset, @count, @signature, @hashAlgorithm};
            var ___result = RVerifyData_ByteArray_Int32_Int32_ByteArray_HashAlgorithmName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean VerifyData(System.IO.Stream  @data, System.Byte[]  @signature, System.Security.Cryptography.HashAlgorithmName  @hashAlgorithm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @signature, @hashAlgorithm};
            var ___result = RVerifyData_Stream_ByteArray_HashAlgorithmName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void FromXmlString(System.String  @xmlString)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xmlString};
            var ___result = RFromXmlString_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToXmlString(System.Boolean  @includePrivateParameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@includePrivateParameters};
            var ___result = RToXmlString_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Security.Cryptography.DSAParameters ExportParameters(System.Boolean  @includePrivateParameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@includePrivateParameters};
            var ___result = RExportParameters_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.DSAParameters)___result;
        }


        public virtual void ImportParameters(System.Security.Cryptography.DSAParameters  @parameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parameters};
            var ___result = RImportParameters_DSAParameters.Invoke(___genericsType, ___parameters);

            
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


        public static System.Security.Cryptography.DSA Create(System.Int32  @keySizeInBits)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keySizeInBits};
            var ___result = RCreate_Int32.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.DSA)___result;
        }


        public static System.Security.Cryptography.DSA Create(System.Security.Cryptography.DSAParameters  @parameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parameters};
            var ___result = RCreate_DSAParameters.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.DSA)___result;
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


        public virtual void Dispose(System.Boolean  @disposing)
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
