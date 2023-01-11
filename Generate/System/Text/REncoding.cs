using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RText
{
	/// <summary>
	/// System.Text.Encoding
	/// </summary>
    public partial class REncoding : RMember //
    {

		/// <summary>
		/// System.Text.Encoding defaultEncoding
		/// </summary>
		protected static RSystem.RText.REncoding r_defaultEncoding;
		public static RSystem.RText.REncoding RdefaultEncoding
		{
			get
			{
				if(r_defaultEncoding == null)
				{
					r_defaultEncoding = new(typeof(System.Text.Encoding), "defaultEncoding");
					r_defaultEncoding.SetBelong(null);
				}
				return r_defaultEncoding;
			}
		}

		/// <summary>
		/// System.Text.Encoding unicodeEncoding
		/// </summary>
		protected static RSystem.RText.REncoding r_unicodeEncoding;
		public static RSystem.RText.REncoding RunicodeEncoding
		{
			get
			{
				if(r_unicodeEncoding == null)
				{
					r_unicodeEncoding = new(typeof(System.Text.Encoding), "unicodeEncoding");
					r_unicodeEncoding.SetBelong(null);
				}
				return r_unicodeEncoding;
			}
		}

		/// <summary>
		/// System.Text.Encoding bigEndianUnicode
		/// </summary>
		protected static RSystem.RText.REncoding r_bigEndianUnicode;
		public static RSystem.RText.REncoding RbigEndianUnicode
		{
			get
			{
				if(r_bigEndianUnicode == null)
				{
					r_bigEndianUnicode = new(typeof(System.Text.Encoding), "bigEndianUnicode");
					r_bigEndianUnicode.SetBelong(null);
				}
				return r_bigEndianUnicode;
			}
		}

		/// <summary>
		/// System.Text.Encoding utf7Encoding
		/// </summary>
		protected static RSystem.RText.REncoding r_utf7Encoding;
		public static RSystem.RText.REncoding Rutf7Encoding
		{
			get
			{
				if(r_utf7Encoding == null)
				{
					r_utf7Encoding = new(typeof(System.Text.Encoding), "utf7Encoding");
					r_utf7Encoding.SetBelong(null);
				}
				return r_utf7Encoding;
			}
		}

		/// <summary>
		/// System.Text.Encoding utf8Encoding
		/// </summary>
		protected static RSystem.RText.REncoding r_utf8Encoding;
		public static RSystem.RText.REncoding Rutf8Encoding
		{
			get
			{
				if(r_utf8Encoding == null)
				{
					r_utf8Encoding = new(typeof(System.Text.Encoding), "utf8Encoding");
					r_utf8Encoding.SetBelong(null);
				}
				return r_utf8Encoding;
			}
		}

		/// <summary>
		/// System.Text.Encoding utf32Encoding
		/// </summary>
		protected static RSystem.RText.REncoding r_utf32Encoding;
		public static RSystem.RText.REncoding Rutf32Encoding
		{
			get
			{
				if(r_utf32Encoding == null)
				{
					r_utf32Encoding = new(typeof(System.Text.Encoding), "utf32Encoding");
					r_utf32Encoding.SetBelong(null);
				}
				return r_utf32Encoding;
			}
		}

		/// <summary>
		/// System.Text.Encoding asciiEncoding
		/// </summary>
		protected static RSystem.RText.REncoding r_asciiEncoding;
		public static RSystem.RText.REncoding RasciiEncoding
		{
			get
			{
				if(r_asciiEncoding == null)
				{
					r_asciiEncoding = new(typeof(System.Text.Encoding), "asciiEncoding");
					r_asciiEncoding.SetBelong(null);
				}
				return r_asciiEncoding;
			}
		}

		/// <summary>
		/// System.Text.Encoding latin1Encoding
		/// </summary>
		protected static RSystem.RText.REncoding r_latin1Encoding;
		public static RSystem.RText.REncoding Rlatin1Encoding
		{
			get
			{
				if(r_latin1Encoding == null)
				{
					r_latin1Encoding = new(typeof(System.Text.Encoding), "latin1Encoding");
					r_latin1Encoding.SetBelong(null);
				}
				return r_latin1Encoding;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,System.Text.Encoding] encodings
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RSystem.RInt32, RSystem.RText.REncoding> r_encodings;
		public static RSystem.RCollections.RGeneric.RDictionary<RSystem.RInt32, RSystem.RText.REncoding> Rencodings
		{
			get
			{
				if(r_encodings == null)
				{
					r_encodings = new(typeof(System.Text.Encoding), "encodings");
					r_encodings.SetBelong(null);
				}
				return r_encodings;
			}
		}

		/// <summary>
		/// System.Int32 MIMECONTF_MAILNEWS
		/// </summary>
		protected static RSystem.RInt32 r_MIMECONTF_MAILNEWS;
		public static RSystem.RInt32 RMIMECONTF_MAILNEWS
		{
			get
			{
				if(r_MIMECONTF_MAILNEWS == null)
				{
					r_MIMECONTF_MAILNEWS = new(typeof(System.Text.Encoding), "MIMECONTF_MAILNEWS");
					r_MIMECONTF_MAILNEWS.SetBelong(null);
				}
				return r_MIMECONTF_MAILNEWS;
			}
		}

		/// <summary>
		/// System.Int32 MIMECONTF_BROWSER
		/// </summary>
		protected static RSystem.RInt32 r_MIMECONTF_BROWSER;
		public static RSystem.RInt32 RMIMECONTF_BROWSER
		{
			get
			{
				if(r_MIMECONTF_BROWSER == null)
				{
					r_MIMECONTF_BROWSER = new(typeof(System.Text.Encoding), "MIMECONTF_BROWSER");
					r_MIMECONTF_BROWSER.SetBelong(null);
				}
				return r_MIMECONTF_BROWSER;
			}
		}

		/// <summary>
		/// System.Int32 MIMECONTF_SAVABLE_MAILNEWS
		/// </summary>
		protected static RSystem.RInt32 r_MIMECONTF_SAVABLE_MAILNEWS;
		public static RSystem.RInt32 RMIMECONTF_SAVABLE_MAILNEWS
		{
			get
			{
				if(r_MIMECONTF_SAVABLE_MAILNEWS == null)
				{
					r_MIMECONTF_SAVABLE_MAILNEWS = new(typeof(System.Text.Encoding), "MIMECONTF_SAVABLE_MAILNEWS");
					r_MIMECONTF_SAVABLE_MAILNEWS.SetBelong(null);
				}
				return r_MIMECONTF_SAVABLE_MAILNEWS;
			}
		}

		/// <summary>
		/// System.Int32 MIMECONTF_SAVABLE_BROWSER
		/// </summary>
		protected static RSystem.RInt32 r_MIMECONTF_SAVABLE_BROWSER;
		public static RSystem.RInt32 RMIMECONTF_SAVABLE_BROWSER
		{
			get
			{
				if(r_MIMECONTF_SAVABLE_BROWSER == null)
				{
					r_MIMECONTF_SAVABLE_BROWSER = new(typeof(System.Text.Encoding), "MIMECONTF_SAVABLE_BROWSER");
					r_MIMECONTF_SAVABLE_BROWSER.SetBelong(null);
				}
				return r_MIMECONTF_SAVABLE_BROWSER;
			}
		}

		/// <summary>
		/// System.Int32 CodePageDefault
		/// </summary>
		protected static RSystem.RInt32 r_CodePageDefault;
		public static RSystem.RInt32 RCodePageDefault
		{
			get
			{
				if(r_CodePageDefault == null)
				{
					r_CodePageDefault = new(typeof(System.Text.Encoding), "CodePageDefault");
					r_CodePageDefault.SetBelong(null);
				}
				return r_CodePageDefault;
			}
		}

		/// <summary>
		/// System.Int32 CodePageNoOEM
		/// </summary>
		protected static RSystem.RInt32 r_CodePageNoOEM;
		public static RSystem.RInt32 RCodePageNoOEM
		{
			get
			{
				if(r_CodePageNoOEM == null)
				{
					r_CodePageNoOEM = new(typeof(System.Text.Encoding), "CodePageNoOEM");
					r_CodePageNoOEM.SetBelong(null);
				}
				return r_CodePageNoOEM;
			}
		}

		/// <summary>
		/// System.Int32 CodePageNoMac
		/// </summary>
		protected static RSystem.RInt32 r_CodePageNoMac;
		public static RSystem.RInt32 RCodePageNoMac
		{
			get
			{
				if(r_CodePageNoMac == null)
				{
					r_CodePageNoMac = new(typeof(System.Text.Encoding), "CodePageNoMac");
					r_CodePageNoMac.SetBelong(null);
				}
				return r_CodePageNoMac;
			}
		}

		/// <summary>
		/// System.Int32 CodePageNoThread
		/// </summary>
		protected static RSystem.RInt32 r_CodePageNoThread;
		public static RSystem.RInt32 RCodePageNoThread
		{
			get
			{
				if(r_CodePageNoThread == null)
				{
					r_CodePageNoThread = new(typeof(System.Text.Encoding), "CodePageNoThread");
					r_CodePageNoThread.SetBelong(null);
				}
				return r_CodePageNoThread;
			}
		}

		/// <summary>
		/// System.Int32 CodePageNoSymbol
		/// </summary>
		protected static RSystem.RInt32 r_CodePageNoSymbol;
		public static RSystem.RInt32 RCodePageNoSymbol
		{
			get
			{
				if(r_CodePageNoSymbol == null)
				{
					r_CodePageNoSymbol = new(typeof(System.Text.Encoding), "CodePageNoSymbol");
					r_CodePageNoSymbol.SetBelong(null);
				}
				return r_CodePageNoSymbol;
			}
		}

		/// <summary>
		/// System.Int32 CodePageUnicode
		/// </summary>
		protected static RSystem.RInt32 r_CodePageUnicode;
		public static RSystem.RInt32 RCodePageUnicode
		{
			get
			{
				if(r_CodePageUnicode == null)
				{
					r_CodePageUnicode = new(typeof(System.Text.Encoding), "CodePageUnicode");
					r_CodePageUnicode.SetBelong(null);
				}
				return r_CodePageUnicode;
			}
		}

		/// <summary>
		/// System.Int32 CodePageBigEndian
		/// </summary>
		protected static RSystem.RInt32 r_CodePageBigEndian;
		public static RSystem.RInt32 RCodePageBigEndian
		{
			get
			{
				if(r_CodePageBigEndian == null)
				{
					r_CodePageBigEndian = new(typeof(System.Text.Encoding), "CodePageBigEndian");
					r_CodePageBigEndian.SetBelong(null);
				}
				return r_CodePageBigEndian;
			}
		}

		/// <summary>
		/// System.Int32 CodePageWindows1252
		/// </summary>
		protected static RSystem.RInt32 r_CodePageWindows1252;
		public static RSystem.RInt32 RCodePageWindows1252
		{
			get
			{
				if(r_CodePageWindows1252 == null)
				{
					r_CodePageWindows1252 = new(typeof(System.Text.Encoding), "CodePageWindows1252");
					r_CodePageWindows1252.SetBelong(null);
				}
				return r_CodePageWindows1252;
			}
		}

		/// <summary>
		/// System.Int32 CodePageMacGB2312
		/// </summary>
		protected static RSystem.RInt32 r_CodePageMacGB2312;
		public static RSystem.RInt32 RCodePageMacGB2312
		{
			get
			{
				if(r_CodePageMacGB2312 == null)
				{
					r_CodePageMacGB2312 = new(typeof(System.Text.Encoding), "CodePageMacGB2312");
					r_CodePageMacGB2312.SetBelong(null);
				}
				return r_CodePageMacGB2312;
			}
		}

		/// <summary>
		/// System.Int32 CodePageGB2312
		/// </summary>
		protected static RSystem.RInt32 r_CodePageGB2312;
		public static RSystem.RInt32 RCodePageGB2312
		{
			get
			{
				if(r_CodePageGB2312 == null)
				{
					r_CodePageGB2312 = new(typeof(System.Text.Encoding), "CodePageGB2312");
					r_CodePageGB2312.SetBelong(null);
				}
				return r_CodePageGB2312;
			}
		}

		/// <summary>
		/// System.Int32 CodePageMacKorean
		/// </summary>
		protected static RSystem.RInt32 r_CodePageMacKorean;
		public static RSystem.RInt32 RCodePageMacKorean
		{
			get
			{
				if(r_CodePageMacKorean == null)
				{
					r_CodePageMacKorean = new(typeof(System.Text.Encoding), "CodePageMacKorean");
					r_CodePageMacKorean.SetBelong(null);
				}
				return r_CodePageMacKorean;
			}
		}

		/// <summary>
		/// System.Int32 CodePageDLLKorean
		/// </summary>
		protected static RSystem.RInt32 r_CodePageDLLKorean;
		public static RSystem.RInt32 RCodePageDLLKorean
		{
			get
			{
				if(r_CodePageDLLKorean == null)
				{
					r_CodePageDLLKorean = new(typeof(System.Text.Encoding), "CodePageDLLKorean");
					r_CodePageDLLKorean.SetBelong(null);
				}
				return r_CodePageDLLKorean;
			}
		}

		/// <summary>
		/// System.Int32 ISO2022JP
		/// </summary>
		protected static RSystem.RInt32 r_ISO2022JP;
		public static RSystem.RInt32 RISO2022JP
		{
			get
			{
				if(r_ISO2022JP == null)
				{
					r_ISO2022JP = new(typeof(System.Text.Encoding), "ISO2022JP");
					r_ISO2022JP.SetBelong(null);
				}
				return r_ISO2022JP;
			}
		}

		/// <summary>
		/// System.Int32 ISO2022JPESC
		/// </summary>
		protected static RSystem.RInt32 r_ISO2022JPESC;
		public static RSystem.RInt32 RISO2022JPESC
		{
			get
			{
				if(r_ISO2022JPESC == null)
				{
					r_ISO2022JPESC = new(typeof(System.Text.Encoding), "ISO2022JPESC");
					r_ISO2022JPESC.SetBelong(null);
				}
				return r_ISO2022JPESC;
			}
		}

		/// <summary>
		/// System.Int32 ISO2022JPSISO
		/// </summary>
		protected static RSystem.RInt32 r_ISO2022JPSISO;
		public static RSystem.RInt32 RISO2022JPSISO
		{
			get
			{
				if(r_ISO2022JPSISO == null)
				{
					r_ISO2022JPSISO = new(typeof(System.Text.Encoding), "ISO2022JPSISO");
					r_ISO2022JPSISO.SetBelong(null);
				}
				return r_ISO2022JPSISO;
			}
		}

		/// <summary>
		/// System.Int32 ISOKorean
		/// </summary>
		protected static RSystem.RInt32 r_ISOKorean;
		public static RSystem.RInt32 RISOKorean
		{
			get
			{
				if(r_ISOKorean == null)
				{
					r_ISOKorean = new(typeof(System.Text.Encoding), "ISOKorean");
					r_ISOKorean.SetBelong(null);
				}
				return r_ISOKorean;
			}
		}

		/// <summary>
		/// System.Int32 ISOSimplifiedCN
		/// </summary>
		protected static RSystem.RInt32 r_ISOSimplifiedCN;
		public static RSystem.RInt32 RISOSimplifiedCN
		{
			get
			{
				if(r_ISOSimplifiedCN == null)
				{
					r_ISOSimplifiedCN = new(typeof(System.Text.Encoding), "ISOSimplifiedCN");
					r_ISOSimplifiedCN.SetBelong(null);
				}
				return r_ISOSimplifiedCN;
			}
		}

		/// <summary>
		/// System.Int32 EUCJP
		/// </summary>
		protected static RSystem.RInt32 r_EUCJP;
		public static RSystem.RInt32 REUCJP
		{
			get
			{
				if(r_EUCJP == null)
				{
					r_EUCJP = new(typeof(System.Text.Encoding), "EUCJP");
					r_EUCJP.SetBelong(null);
				}
				return r_EUCJP;
			}
		}

		/// <summary>
		/// System.Int32 ChineseHZ
		/// </summary>
		protected static RSystem.RInt32 r_ChineseHZ;
		public static RSystem.RInt32 RChineseHZ
		{
			get
			{
				if(r_ChineseHZ == null)
				{
					r_ChineseHZ = new(typeof(System.Text.Encoding), "ChineseHZ");
					r_ChineseHZ.SetBelong(null);
				}
				return r_ChineseHZ;
			}
		}

		/// <summary>
		/// System.Int32 DuplicateEUCCN
		/// </summary>
		protected static RSystem.RInt32 r_DuplicateEUCCN;
		public static RSystem.RInt32 RDuplicateEUCCN
		{
			get
			{
				if(r_DuplicateEUCCN == null)
				{
					r_DuplicateEUCCN = new(typeof(System.Text.Encoding), "DuplicateEUCCN");
					r_DuplicateEUCCN.SetBelong(null);
				}
				return r_DuplicateEUCCN;
			}
		}

		/// <summary>
		/// System.Int32 EUCCN
		/// </summary>
		protected static RSystem.RInt32 r_EUCCN;
		public static RSystem.RInt32 REUCCN
		{
			get
			{
				if(r_EUCCN == null)
				{
					r_EUCCN = new(typeof(System.Text.Encoding), "EUCCN");
					r_EUCCN.SetBelong(null);
				}
				return r_EUCCN;
			}
		}

		/// <summary>
		/// System.Int32 EUCKR
		/// </summary>
		protected static RSystem.RInt32 r_EUCKR;
		public static RSystem.RInt32 REUCKR
		{
			get
			{
				if(r_EUCKR == null)
				{
					r_EUCKR = new(typeof(System.Text.Encoding), "EUCKR");
					r_EUCKR.SetBelong(null);
				}
				return r_EUCKR;
			}
		}

		/// <summary>
		/// System.Int32 CodePageASCII
		/// </summary>
		protected static RSystem.RInt32 r_CodePageASCII;
		public static RSystem.RInt32 RCodePageASCII
		{
			get
			{
				if(r_CodePageASCII == null)
				{
					r_CodePageASCII = new(typeof(System.Text.Encoding), "CodePageASCII");
					r_CodePageASCII.SetBelong(null);
				}
				return r_CodePageASCII;
			}
		}

		/// <summary>
		/// System.Int32 ISO_8859_1
		/// </summary>
		protected static RSystem.RInt32 r_ISO_8859_1;
		public static RSystem.RInt32 RISO_8859_1
		{
			get
			{
				if(r_ISO_8859_1 == null)
				{
					r_ISO_8859_1 = new(typeof(System.Text.Encoding), "ISO_8859_1");
					r_ISO_8859_1.SetBelong(null);
				}
				return r_ISO_8859_1;
			}
		}

		/// <summary>
		/// System.Int32 ISCIIAssemese
		/// </summary>
		protected static RSystem.RInt32 r_ISCIIAssemese;
		public static RSystem.RInt32 RISCIIAssemese
		{
			get
			{
				if(r_ISCIIAssemese == null)
				{
					r_ISCIIAssemese = new(typeof(System.Text.Encoding), "ISCIIAssemese");
					r_ISCIIAssemese.SetBelong(null);
				}
				return r_ISCIIAssemese;
			}
		}

		/// <summary>
		/// System.Int32 ISCIIBengali
		/// </summary>
		protected static RSystem.RInt32 r_ISCIIBengali;
		public static RSystem.RInt32 RISCIIBengali
		{
			get
			{
				if(r_ISCIIBengali == null)
				{
					r_ISCIIBengali = new(typeof(System.Text.Encoding), "ISCIIBengali");
					r_ISCIIBengali.SetBelong(null);
				}
				return r_ISCIIBengali;
			}
		}

		/// <summary>
		/// System.Int32 ISCIIDevanagari
		/// </summary>
		protected static RSystem.RInt32 r_ISCIIDevanagari;
		public static RSystem.RInt32 RISCIIDevanagari
		{
			get
			{
				if(r_ISCIIDevanagari == null)
				{
					r_ISCIIDevanagari = new(typeof(System.Text.Encoding), "ISCIIDevanagari");
					r_ISCIIDevanagari.SetBelong(null);
				}
				return r_ISCIIDevanagari;
			}
		}

		/// <summary>
		/// System.Int32 ISCIIGujarathi
		/// </summary>
		protected static RSystem.RInt32 r_ISCIIGujarathi;
		public static RSystem.RInt32 RISCIIGujarathi
		{
			get
			{
				if(r_ISCIIGujarathi == null)
				{
					r_ISCIIGujarathi = new(typeof(System.Text.Encoding), "ISCIIGujarathi");
					r_ISCIIGujarathi.SetBelong(null);
				}
				return r_ISCIIGujarathi;
			}
		}

		/// <summary>
		/// System.Int32 ISCIIKannada
		/// </summary>
		protected static RSystem.RInt32 r_ISCIIKannada;
		public static RSystem.RInt32 RISCIIKannada
		{
			get
			{
				if(r_ISCIIKannada == null)
				{
					r_ISCIIKannada = new(typeof(System.Text.Encoding), "ISCIIKannada");
					r_ISCIIKannada.SetBelong(null);
				}
				return r_ISCIIKannada;
			}
		}

		/// <summary>
		/// System.Int32 ISCIIMalayalam
		/// </summary>
		protected static RSystem.RInt32 r_ISCIIMalayalam;
		public static RSystem.RInt32 RISCIIMalayalam
		{
			get
			{
				if(r_ISCIIMalayalam == null)
				{
					r_ISCIIMalayalam = new(typeof(System.Text.Encoding), "ISCIIMalayalam");
					r_ISCIIMalayalam.SetBelong(null);
				}
				return r_ISCIIMalayalam;
			}
		}

		/// <summary>
		/// System.Int32 ISCIIOriya
		/// </summary>
		protected static RSystem.RInt32 r_ISCIIOriya;
		public static RSystem.RInt32 RISCIIOriya
		{
			get
			{
				if(r_ISCIIOriya == null)
				{
					r_ISCIIOriya = new(typeof(System.Text.Encoding), "ISCIIOriya");
					r_ISCIIOriya.SetBelong(null);
				}
				return r_ISCIIOriya;
			}
		}

		/// <summary>
		/// System.Int32 ISCIIPanjabi
		/// </summary>
		protected static RSystem.RInt32 r_ISCIIPanjabi;
		public static RSystem.RInt32 RISCIIPanjabi
		{
			get
			{
				if(r_ISCIIPanjabi == null)
				{
					r_ISCIIPanjabi = new(typeof(System.Text.Encoding), "ISCIIPanjabi");
					r_ISCIIPanjabi.SetBelong(null);
				}
				return r_ISCIIPanjabi;
			}
		}

		/// <summary>
		/// System.Int32 ISCIITamil
		/// </summary>
		protected static RSystem.RInt32 r_ISCIITamil;
		public static RSystem.RInt32 RISCIITamil
		{
			get
			{
				if(r_ISCIITamil == null)
				{
					r_ISCIITamil = new(typeof(System.Text.Encoding), "ISCIITamil");
					r_ISCIITamil.SetBelong(null);
				}
				return r_ISCIITamil;
			}
		}

		/// <summary>
		/// System.Int32 ISCIITelugu
		/// </summary>
		protected static RSystem.RInt32 r_ISCIITelugu;
		public static RSystem.RInt32 RISCIITelugu
		{
			get
			{
				if(r_ISCIITelugu == null)
				{
					r_ISCIITelugu = new(typeof(System.Text.Encoding), "ISCIITelugu");
					r_ISCIITelugu.SetBelong(null);
				}
				return r_ISCIITelugu;
			}
		}

		/// <summary>
		/// System.Int32 GB18030
		/// </summary>
		protected static RSystem.RInt32 r_GB18030;
		public static RSystem.RInt32 RGB18030
		{
			get
			{
				if(r_GB18030 == null)
				{
					r_GB18030 = new(typeof(System.Text.Encoding), "GB18030");
					r_GB18030.SetBelong(null);
				}
				return r_GB18030;
			}
		}

		/// <summary>
		/// System.Int32 ISO_8859_8I
		/// </summary>
		protected static RSystem.RInt32 r_ISO_8859_8I;
		public static RSystem.RInt32 RISO_8859_8I
		{
			get
			{
				if(r_ISO_8859_8I == null)
				{
					r_ISO_8859_8I = new(typeof(System.Text.Encoding), "ISO_8859_8I");
					r_ISO_8859_8I.SetBelong(null);
				}
				return r_ISO_8859_8I;
			}
		}

		/// <summary>
		/// System.Int32 ISO_8859_8_Visual
		/// </summary>
		protected static RSystem.RInt32 r_ISO_8859_8_Visual;
		public static RSystem.RInt32 RISO_8859_8_Visual
		{
			get
			{
				if(r_ISO_8859_8_Visual == null)
				{
					r_ISO_8859_8_Visual = new(typeof(System.Text.Encoding), "ISO_8859_8_Visual");
					r_ISO_8859_8_Visual.SetBelong(null);
				}
				return r_ISO_8859_8_Visual;
			}
		}

		/// <summary>
		/// System.Int32 ENC50229
		/// </summary>
		protected static RSystem.RInt32 r_ENC50229;
		public static RSystem.RInt32 RENC50229
		{
			get
			{
				if(r_ENC50229 == null)
				{
					r_ENC50229 = new(typeof(System.Text.Encoding), "ENC50229");
					r_ENC50229.SetBelong(null);
				}
				return r_ENC50229;
			}
		}

		/// <summary>
		/// System.Int32 CodePageUTF7
		/// </summary>
		protected static RSystem.RInt32 r_CodePageUTF7;
		public static RSystem.RInt32 RCodePageUTF7
		{
			get
			{
				if(r_CodePageUTF7 == null)
				{
					r_CodePageUTF7 = new(typeof(System.Text.Encoding), "CodePageUTF7");
					r_CodePageUTF7.SetBelong(null);
				}
				return r_CodePageUTF7;
			}
		}

		/// <summary>
		/// System.Int32 CodePageUTF8
		/// </summary>
		protected static RSystem.RInt32 r_CodePageUTF8;
		public static RSystem.RInt32 RCodePageUTF8
		{
			get
			{
				if(r_CodePageUTF8 == null)
				{
					r_CodePageUTF8 = new(typeof(System.Text.Encoding), "CodePageUTF8");
					r_CodePageUTF8.SetBelong(null);
				}
				return r_CodePageUTF8;
			}
		}

		/// <summary>
		/// System.Int32 CodePageUTF32
		/// </summary>
		protected static RSystem.RInt32 r_CodePageUTF32;
		public static RSystem.RInt32 RCodePageUTF32
		{
			get
			{
				if(r_CodePageUTF32 == null)
				{
					r_CodePageUTF32 = new(typeof(System.Text.Encoding), "CodePageUTF32");
					r_CodePageUTF32.SetBelong(null);
				}
				return r_CodePageUTF32;
			}
		}

		/// <summary>
		/// System.Int32 CodePageUTF32BE
		/// </summary>
		protected static RSystem.RInt32 r_CodePageUTF32BE;
		public static RSystem.RInt32 RCodePageUTF32BE
		{
			get
			{
				if(r_CodePageUTF32BE == null)
				{
					r_CodePageUTF32BE = new(typeof(System.Text.Encoding), "CodePageUTF32BE");
					r_CodePageUTF32BE.SetBelong(null);
				}
				return r_CodePageUTF32BE;
			}
		}

		/// <summary>
		/// System.Int32 m_codePage
		/// </summary>
		protected RSystem.RInt32 r_m_codePage;
		public virtual RSystem.RInt32 Rm_codePage
		{
			get
			{
				if(r_m_codePage == null)
				{
					r_m_codePage = new(this, "m_codePage");
					r_m_codePage.SetBelong(this.instance);
				}
				return r_m_codePage;
			}
		}

		/// <summary>
		/// System.Globalization.CodePageDataItem dataItem
		/// </summary>
		protected RSystem.RGlobalization.RCodePageDataItem r_dataItem;
		public virtual RSystem.RGlobalization.RCodePageDataItem RdataItem
		{
			get
			{
				if(r_dataItem == null)
				{
					r_dataItem = new(this, "dataItem");
					r_dataItem.SetBelong(this.instance);
				}
				return r_dataItem;
			}
		}

		/// <summary>
		/// System.Boolean m_deserializedFromEverett
		/// </summary>
		protected RSystem.RBoolean r_m_deserializedFromEverett;
		public virtual RSystem.RBoolean Rm_deserializedFromEverett
		{
			get
			{
				if(r_m_deserializedFromEverett == null)
				{
					r_m_deserializedFromEverett = new(this, "m_deserializedFromEverett");
					r_m_deserializedFromEverett.SetBelong(this.instance);
				}
				return r_m_deserializedFromEverett;
			}
		}

		/// <summary>
		/// System.Boolean m_isReadOnly
		/// </summary>
		protected RSystem.RBoolean r_m_isReadOnly;
		public virtual RSystem.RBoolean Rm_isReadOnly
		{
			get
			{
				if(r_m_isReadOnly == null)
				{
					r_m_isReadOnly = new(this, "m_isReadOnly");
					r_m_isReadOnly.SetBelong(this.instance);
				}
				return r_m_isReadOnly;
			}
		}

		/// <summary>
		/// System.Text.EncoderFallback encoderFallback
		/// </summary>
		protected RSystem.RText.REncoderFallback r_encoderFallback;
		public virtual RSystem.RText.REncoderFallback RencoderFallback
		{
			get
			{
				if(r_encoderFallback == null)
				{
					r_encoderFallback = new(this, "encoderFallback");
					r_encoderFallback.SetBelong(this.instance);
				}
				return r_encoderFallback;
			}
		}

		/// <summary>
		/// System.Text.DecoderFallback decoderFallback
		/// </summary>
		protected RSystem.RText.RDecoderFallback r_decoderFallback;
		public virtual RSystem.RText.RDecoderFallback RdecoderFallback
		{
			get
			{
				if(r_decoderFallback == null)
				{
					r_decoderFallback = new(this, "decoderFallback");
					r_decoderFallback.SetBelong(this.instance);
				}
				return r_decoderFallback;
			}
		}

		/// <summary>
		/// System.Object s_InternalSyncObject
		/// </summary>
		protected static RSystem.RObject r_s_InternalSyncObject;
		public static RSystem.RObject Rs_InternalSyncObject
		{
			get
			{
				if(r_s_InternalSyncObject == null)
				{
					r_s_InternalSyncObject = new(typeof(System.Text.Encoding), "s_InternalSyncObject");
					r_s_InternalSyncObject.SetBelong(null);
				}
				return r_s_InternalSyncObject;
			}
		}

		/// <summary>
		/// System.Object InternalSyncObject
		/// </summary>
		protected static RSystem.RObject r_InternalSyncObject;
		public static RSystem.RObject RInternalSyncObject
		{
			get
			{
				if(r_InternalSyncObject == null)
				{
					r_InternalSyncObject = new(typeof(System.Text.Encoding), "InternalSyncObject", -1);
					r_InternalSyncObject.SetBelong(null);
				}
				return r_InternalSyncObject;
			}
		}

		/// <summary>
		/// System.ReadOnlySpan`1[System.Byte] Preamble
		/// </summary>
		protected RSystem.RReadOnlySpan<RSystem.RByte> r_Preamble;
		public virtual RSystem.RReadOnlySpan<RSystem.RByte> RPreamble
		{
			get
			{
				if(r_Preamble == null)
				{
					r_Preamble = new(this, "Preamble", -1);
					r_Preamble.SetBelong(this.instance);
				}
				return r_Preamble;
			}
		}

		/// <summary>
		/// System.String BodyName
		/// </summary>
		protected RSystem.RString r_BodyName;
		public virtual RSystem.RString RBodyName
		{
			get
			{
				if(r_BodyName == null)
				{
					r_BodyName = new(this, "BodyName", -1);
					r_BodyName.SetBelong(this.instance);
				}
				return r_BodyName;
			}
		}

		/// <summary>
		/// System.String EncodingName
		/// </summary>
		protected RSystem.RString r_EncodingName;
		public virtual RSystem.RString REncodingName
		{
			get
			{
				if(r_EncodingName == null)
				{
					r_EncodingName = new(this, "EncodingName", -1);
					r_EncodingName.SetBelong(this.instance);
				}
				return r_EncodingName;
			}
		}

		/// <summary>
		/// System.String HeaderName
		/// </summary>
		protected RSystem.RString r_HeaderName;
		public virtual RSystem.RString RHeaderName
		{
			get
			{
				if(r_HeaderName == null)
				{
					r_HeaderName = new(this, "HeaderName", -1);
					r_HeaderName.SetBelong(this.instance);
				}
				return r_HeaderName;
			}
		}

		/// <summary>
		/// System.String WebName
		/// </summary>
		protected RSystem.RString r_WebName;
		public virtual RSystem.RString RWebName
		{
			get
			{
				if(r_WebName == null)
				{
					r_WebName = new(this, "WebName", -1);
					r_WebName.SetBelong(this.instance);
				}
				return r_WebName;
			}
		}

		/// <summary>
		/// Int32 WindowsCodePage
		/// </summary>
		protected RSystem.RInt32 r_WindowsCodePage;
		public virtual RSystem.RInt32 RWindowsCodePage
		{
			get
			{
				if(r_WindowsCodePage == null)
				{
					r_WindowsCodePage = new(this, "WindowsCodePage", -1);
					r_WindowsCodePage.SetBelong(this.instance);
				}
				return r_WindowsCodePage;
			}
		}

		/// <summary>
		/// Boolean IsBrowserDisplay
		/// </summary>
		protected RSystem.RBoolean r_IsBrowserDisplay;
		public virtual RSystem.RBoolean RIsBrowserDisplay
		{
			get
			{
				if(r_IsBrowserDisplay == null)
				{
					r_IsBrowserDisplay = new(this, "IsBrowserDisplay", -1);
					r_IsBrowserDisplay.SetBelong(this.instance);
				}
				return r_IsBrowserDisplay;
			}
		}

		/// <summary>
		/// Boolean IsBrowserSave
		/// </summary>
		protected RSystem.RBoolean r_IsBrowserSave;
		public virtual RSystem.RBoolean RIsBrowserSave
		{
			get
			{
				if(r_IsBrowserSave == null)
				{
					r_IsBrowserSave = new(this, "IsBrowserSave", -1);
					r_IsBrowserSave.SetBelong(this.instance);
				}
				return r_IsBrowserSave;
			}
		}

		/// <summary>
		/// Boolean IsMailNewsDisplay
		/// </summary>
		protected RSystem.RBoolean r_IsMailNewsDisplay;
		public virtual RSystem.RBoolean RIsMailNewsDisplay
		{
			get
			{
				if(r_IsMailNewsDisplay == null)
				{
					r_IsMailNewsDisplay = new(this, "IsMailNewsDisplay", -1);
					r_IsMailNewsDisplay.SetBelong(this.instance);
				}
				return r_IsMailNewsDisplay;
			}
		}

		/// <summary>
		/// Boolean IsMailNewsSave
		/// </summary>
		protected RSystem.RBoolean r_IsMailNewsSave;
		public virtual RSystem.RBoolean RIsMailNewsSave
		{
			get
			{
				if(r_IsMailNewsSave == null)
				{
					r_IsMailNewsSave = new(this, "IsMailNewsSave", -1);
					r_IsMailNewsSave.SetBelong(this.instance);
				}
				return r_IsMailNewsSave;
			}
		}

		/// <summary>
		/// Boolean IsSingleByte
		/// </summary>
		protected RSystem.RBoolean r_IsSingleByte;
		public virtual RSystem.RBoolean RIsSingleByte
		{
			get
			{
				if(r_IsSingleByte == null)
				{
					r_IsSingleByte = new(this, "IsSingleByte", -1);
					r_IsSingleByte.SetBelong(this.instance);
				}
				return r_IsSingleByte;
			}
		}

		/// <summary>
		/// System.Text.EncoderFallback EncoderFallback
		/// </summary>
		protected RSystem.RText.REncoderFallback r_EncoderFallback;
		public virtual RSystem.RText.REncoderFallback REncoderFallback
		{
			get
			{
				if(r_EncoderFallback == null)
				{
					r_EncoderFallback = new(this, "EncoderFallback", -1);
					r_EncoderFallback.SetBelong(this.instance);
				}
				return r_EncoderFallback;
			}
		}

		/// <summary>
		/// System.Text.DecoderFallback DecoderFallback
		/// </summary>
		protected RSystem.RText.RDecoderFallback r_DecoderFallback;
		public virtual RSystem.RText.RDecoderFallback RDecoderFallback
		{
			get
			{
				if(r_DecoderFallback == null)
				{
					r_DecoderFallback = new(this, "DecoderFallback", -1);
					r_DecoderFallback.SetBelong(this.instance);
				}
				return r_DecoderFallback;
			}
		}

		/// <summary>
		/// Boolean IsReadOnly
		/// </summary>
		protected RSystem.RBoolean r_IsReadOnly;
		public virtual RSystem.RBoolean RIsReadOnly
		{
			get
			{
				if(r_IsReadOnly == null)
				{
					r_IsReadOnly = new(this, "IsReadOnly", -1);
					r_IsReadOnly.SetBelong(this.instance);
				}
				return r_IsReadOnly;
			}
		}

		/// <summary>
		/// System.Text.Encoding ASCII
		/// </summary>
		protected static RSystem.RText.REncoding r_ASCII;
		public static RSystem.RText.REncoding RASCII
		{
			get
			{
				if(r_ASCII == null)
				{
					r_ASCII = new(typeof(System.Text.Encoding), "ASCII", -1);
					r_ASCII.SetBelong(null);
				}
				return r_ASCII;
			}
		}

		/// <summary>
		/// System.Text.Encoding Latin1
		/// </summary>
		protected static RSystem.RText.REncoding r_Latin1;
		public static RSystem.RText.REncoding RLatin1
		{
			get
			{
				if(r_Latin1 == null)
				{
					r_Latin1 = new(typeof(System.Text.Encoding), "Latin1", -1);
					r_Latin1.SetBelong(null);
				}
				return r_Latin1;
			}
		}

		/// <summary>
		/// Int32 CodePage
		/// </summary>
		protected RSystem.RInt32 r_CodePage;
		public virtual RSystem.RInt32 RCodePage
		{
			get
			{
				if(r_CodePage == null)
				{
					r_CodePage = new(this, "CodePage", -1);
					r_CodePage.SetBelong(this.instance);
				}
				return r_CodePage;
			}
		}

		/// <summary>
		/// System.Text.Encoding Default
		/// </summary>
		protected static RSystem.RText.REncoding r_Default;
		public static RSystem.RText.REncoding RDefault
		{
			get
			{
				if(r_Default == null)
				{
					r_Default = new(typeof(System.Text.Encoding), "Default", -1);
					r_Default.SetBelong(null);
				}
				return r_Default;
			}
		}

		/// <summary>
		/// System.Text.Encoding Unicode
		/// </summary>
		protected static RSystem.RText.REncoding r_Unicode;
		public static RSystem.RText.REncoding RUnicode
		{
			get
			{
				if(r_Unicode == null)
				{
					r_Unicode = new(typeof(System.Text.Encoding), "Unicode", -1);
					r_Unicode.SetBelong(null);
				}
				return r_Unicode;
			}
		}

		/// <summary>
		/// System.Text.Encoding BigEndianUnicode
		/// </summary>
		protected static RSystem.RText.REncoding r_BigEndianUnicode;
		public static RSystem.RText.REncoding RBigEndianUnicode
		{
			get
			{
				if(r_BigEndianUnicode == null)
				{
					r_BigEndianUnicode = new(typeof(System.Text.Encoding), "BigEndianUnicode", -1);
					r_BigEndianUnicode.SetBelong(null);
				}
				return r_BigEndianUnicode;
			}
		}

		/// <summary>
		/// System.Text.Encoding UTF7
		/// </summary>
		protected static RSystem.RText.REncoding r_UTF7;
		public static RSystem.RText.REncoding RUTF7
		{
			get
			{
				if(r_UTF7 == null)
				{
					r_UTF7 = new(typeof(System.Text.Encoding), "UTF7", -1);
					r_UTF7.SetBelong(null);
				}
				return r_UTF7;
			}
		}

		/// <summary>
		/// System.Text.Encoding UTF8
		/// </summary>
		protected static RSystem.RText.REncoding r_UTF8;
		public static RSystem.RText.REncoding RUTF8
		{
			get
			{
				if(r_UTF8 == null)
				{
					r_UTF8 = new(typeof(System.Text.Encoding), "UTF8", -1);
					r_UTF8.SetBelong(null);
				}
				return r_UTF8;
			}
		}

		/// <summary>
		/// System.Text.Encoding UTF32
		/// </summary>
		protected static RSystem.RText.REncoding r_UTF32;
		public static RSystem.RText.REncoding RUTF32
		{
			get
			{
				if(r_UTF32 == null)
				{
					r_UTF32 = new(typeof(System.Text.Encoding), "UTF32", -1);
					r_UTF32.SetBelong(null);
				}
				return r_UTF32;
			}
		}

		/// <summary>
		/// Void SetDefaultFallbacks()
		/// </summary>
		protected RMethod r_SetDefaultFallbacks;
		public virtual RMethod RSetDefaultFallbacks
		{
			get
			{
				if(r_SetDefaultFallbacks == null)
				{
					r_SetDefaultFallbacks = new(this, "SetDefaultFallbacks", 0);
					r_SetDefaultFallbacks.SetBelong(this.instance);
				}
				return r_SetDefaultFallbacks;
			}
		}

		/// <summary>
		/// Void OnDeserializing()
		/// </summary>
		protected RMethod r_OnDeserializing;
		public virtual RMethod ROnDeserializing
		{
			get
			{
				if(r_OnDeserializing == null)
				{
					r_OnDeserializing = new(this, "OnDeserializing", 0);
					r_OnDeserializing.SetBelong(this.instance);
				}
				return r_OnDeserializing;
			}
		}

		/// <summary>
		/// Void OnDeserialized()
		/// </summary>
		protected RMethod r_OnDeserialized;
		public virtual RMethod ROnDeserialized
		{
			get
			{
				if(r_OnDeserialized == null)
				{
					r_OnDeserialized = new(this, "OnDeserialized", 0);
					r_OnDeserialized.SetBelong(this.instance);
				}
				return r_OnDeserialized;
			}
		}

		/// <summary>
		/// Void OnDeserializing(System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_OnDeserializing_StreamingContext;
		public virtual RMethod ROnDeserializing_StreamingContext
		{
			get
			{
				if(r_OnDeserializing_StreamingContext == null)
				{
					r_OnDeserializing_StreamingContext = new(this, "OnDeserializing", 0, typeof(System.Runtime.Serialization.StreamingContext));
					r_OnDeserializing_StreamingContext.SetBelong(this.instance);
				}
				return r_OnDeserializing_StreamingContext;
			}
		}

		/// <summary>
		/// Void OnDeserialized(System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_OnDeserialized_StreamingContext;
		public virtual RMethod ROnDeserialized_StreamingContext
		{
			get
			{
				if(r_OnDeserialized_StreamingContext == null)
				{
					r_OnDeserialized_StreamingContext = new(this, "OnDeserialized", 0, typeof(System.Runtime.Serialization.StreamingContext));
					r_OnDeserialized_StreamingContext.SetBelong(this.instance);
				}
				return r_OnDeserialized_StreamingContext;
			}
		}

		/// <summary>
		/// Void OnSerializing(System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_OnSerializing_StreamingContext;
		public virtual RMethod ROnSerializing_StreamingContext
		{
			get
			{
				if(r_OnSerializing_StreamingContext == null)
				{
					r_OnSerializing_StreamingContext = new(this, "OnSerializing", 0, typeof(System.Runtime.Serialization.StreamingContext));
					r_OnSerializing_StreamingContext.SetBelong(this.instance);
				}
				return r_OnSerializing_StreamingContext;
			}
		}

		/// <summary>
		/// Void DeserializeEncoding(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_DeserializeEncoding_SerializationInfo_StreamingContext;
		public virtual RMethod RDeserializeEncoding_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_DeserializeEncoding_SerializationInfo_StreamingContext == null)
				{
					r_DeserializeEncoding_SerializationInfo_StreamingContext = new(this, "DeserializeEncoding", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_DeserializeEncoding_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_DeserializeEncoding_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// Void SerializeEncoding(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_SerializeEncoding_SerializationInfo_StreamingContext;
		public virtual RMethod RSerializeEncoding_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_SerializeEncoding_SerializationInfo_StreamingContext == null)
				{
					r_SerializeEncoding_SerializationInfo_StreamingContext = new(this, "SerializeEncoding", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_SerializeEncoding_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_SerializeEncoding_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// Byte[] Convert(System.Text.Encoding, System.Text.Encoding, Byte[])
		/// </summary>
		protected static RMethod r_Convert_Encoding_Encoding_ByteArray;
		public static RMethod RConvert_Encoding_Encoding_ByteArray
		{
			get
			{
				if(r_Convert_Encoding_Encoding_ByteArray == null)
				{
					r_Convert_Encoding_Encoding_ByteArray = new(typeof(System.Text.Encoding), "Convert", 0, typeof(System.Text.Encoding), typeof(System.Text.Encoding), typeof(System.Byte).MakeArrayType());
					r_Convert_Encoding_Encoding_ByteArray.SetBelong(null);
				}
				return r_Convert_Encoding_Encoding_ByteArray;
			}
		}

		/// <summary>
		/// Byte[] Convert(System.Text.Encoding, System.Text.Encoding, Byte[], Int32, Int32)
		/// </summary>
		protected static RMethod r_Convert_Encoding_Encoding_ByteArray_Int32_Int32;
		public static RMethod RConvert_Encoding_Encoding_ByteArray_Int32_Int32
		{
			get
			{
				if(r_Convert_Encoding_Encoding_ByteArray_Int32_Int32 == null)
				{
					r_Convert_Encoding_Encoding_ByteArray_Int32_Int32 = new(typeof(System.Text.Encoding), "Convert", 0, typeof(System.Text.Encoding), typeof(System.Text.Encoding), typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_Convert_Encoding_Encoding_ByteArray_Int32_Int32.SetBelong(null);
				}
				return r_Convert_Encoding_Encoding_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void RegisterProvider(System.Text.EncodingProvider)
		/// </summary>
		protected static RMethod r_RegisterProvider_EncodingProvider;
		public static RMethod RRegisterProvider_EncodingProvider
		{
			get
			{
				if(r_RegisterProvider_EncodingProvider == null)
				{
					r_RegisterProvider_EncodingProvider = new(typeof(System.Text.Encoding), "RegisterProvider", 0, typeof(System.Text.EncodingProvider));
					r_RegisterProvider_EncodingProvider.SetBelong(null);
				}
				return r_RegisterProvider_EncodingProvider;
			}
		}

		/// <summary>
		/// System.Text.Encoding GetEncoding(Int32)
		/// </summary>
		protected static RMethod r_GetEncoding_Int32;
		public static RMethod RGetEncoding_Int32
		{
			get
			{
				if(r_GetEncoding_Int32 == null)
				{
					r_GetEncoding_Int32 = new(typeof(System.Text.Encoding), "GetEncoding", 0, typeof(System.Int32));
					r_GetEncoding_Int32.SetBelong(null);
				}
				return r_GetEncoding_Int32;
			}
		}

		/// <summary>
		/// System.Text.Encoding GetEncoding(Int32, System.Text.EncoderFallback, System.Text.DecoderFallback)
		/// </summary>
		protected static RMethod r_GetEncoding_Int32_EncoderFallback_DecoderFallback;
		public static RMethod RGetEncoding_Int32_EncoderFallback_DecoderFallback
		{
			get
			{
				if(r_GetEncoding_Int32_EncoderFallback_DecoderFallback == null)
				{
					r_GetEncoding_Int32_EncoderFallback_DecoderFallback = new(typeof(System.Text.Encoding), "GetEncoding", 0, typeof(System.Int32), typeof(System.Text.EncoderFallback), typeof(System.Text.DecoderFallback));
					r_GetEncoding_Int32_EncoderFallback_DecoderFallback.SetBelong(null);
				}
				return r_GetEncoding_Int32_EncoderFallback_DecoderFallback;
			}
		}

		/// <summary>
		/// System.Text.Encoding GetEncoding(System.String)
		/// </summary>
		protected static RMethod r_GetEncoding_String;
		public static RMethod RGetEncoding_String
		{
			get
			{
				if(r_GetEncoding_String == null)
				{
					r_GetEncoding_String = new(typeof(System.Text.Encoding), "GetEncoding", 0, typeof(System.String));
					r_GetEncoding_String.SetBelong(null);
				}
				return r_GetEncoding_String;
			}
		}

		/// <summary>
		/// System.Text.Encoding GetEncoding(System.String, System.Text.EncoderFallback, System.Text.DecoderFallback)
		/// </summary>
		protected static RMethod r_GetEncoding_String_EncoderFallback_DecoderFallback;
		public static RMethod RGetEncoding_String_EncoderFallback_DecoderFallback
		{
			get
			{
				if(r_GetEncoding_String_EncoderFallback_DecoderFallback == null)
				{
					r_GetEncoding_String_EncoderFallback_DecoderFallback = new(typeof(System.Text.Encoding), "GetEncoding", 0, typeof(System.String), typeof(System.Text.EncoderFallback), typeof(System.Text.DecoderFallback));
					r_GetEncoding_String_EncoderFallback_DecoderFallback.SetBelong(null);
				}
				return r_GetEncoding_String_EncoderFallback_DecoderFallback;
			}
		}

		/// <summary>
		/// System.Text.EncodingInfo[] GetEncodings()
		/// </summary>
		protected static RMethod r_GetEncodings;
		public static RMethod RGetEncodings
		{
			get
			{
				if(r_GetEncodings == null)
				{
					r_GetEncodings = new(typeof(System.Text.Encoding), "GetEncodings", 0);
					r_GetEncodings.SetBelong(null);
				}
				return r_GetEncodings;
			}
		}

		/// <summary>
		/// Byte[] GetPreamble()
		/// </summary>
		protected RMethod r_GetPreamble;
		public virtual RMethod RGetPreamble
		{
			get
			{
				if(r_GetPreamble == null)
				{
					r_GetPreamble = new(this, "GetPreamble", 0);
					r_GetPreamble.SetBelong(this.instance);
				}
				return r_GetPreamble;
			}
		}

		/// <summary>
		/// Void GetDataItem()
		/// </summary>
		protected RMethod r_GetDataItem;
		public virtual RMethod RGetDataItem
		{
			get
			{
				if(r_GetDataItem == null)
				{
					r_GetDataItem = new(this, "GetDataItem", 0);
					r_GetDataItem.SetBelong(this.instance);
				}
				return r_GetDataItem;
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
		/// Int32 GetByteCount(Char[])
		/// </summary>
		protected RMethod r_GetByteCount_CharArray;
		public virtual RMethod RGetByteCount_CharArray
		{
			get
			{
				if(r_GetByteCount_CharArray == null)
				{
					r_GetByteCount_CharArray = new(this, "GetByteCount", 0, typeof(System.Char).MakeArrayType());
					r_GetByteCount_CharArray.SetBelong(this.instance);
				}
				return r_GetByteCount_CharArray;
			}
		}

		/// <summary>
		/// Int32 GetByteCount(System.String)
		/// </summary>
		protected RMethod r_GetByteCount_String;
		public virtual RMethod RGetByteCount_String
		{
			get
			{
				if(r_GetByteCount_String == null)
				{
					r_GetByteCount_String = new(this, "GetByteCount", 0, typeof(System.String));
					r_GetByteCount_String.SetBelong(this.instance);
				}
				return r_GetByteCount_String;
			}
		}

		/// <summary>
		/// Int32 GetByteCount(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_GetByteCount_CharArray_Int32_Int32;
		public virtual RMethod RGetByteCount_CharArray_Int32_Int32
		{
			get
			{
				if(r_GetByteCount_CharArray_Int32_Int32 == null)
				{
					r_GetByteCount_CharArray_Int32_Int32 = new(this, "GetByteCount", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_GetByteCount_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_GetByteCount_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetByteCount(System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_GetByteCount_String_Int32_Int32;
		public virtual RMethod RGetByteCount_String_Int32_Int32
		{
			get
			{
				if(r_GetByteCount_String_Int32_Int32 == null)
				{
					r_GetByteCount_String_Int32_Int32 = new(this, "GetByteCount", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_GetByteCount_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_GetByteCount_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetByteCount(Char*, Int32)
		/// </summary>
		protected RMethod r_GetByteCount_CharPointer_Int32;
		public virtual RMethod RGetByteCount_CharPointer_Int32
		{
			get
			{
				if(r_GetByteCount_CharPointer_Int32 == null)
				{
					r_GetByteCount_CharPointer_Int32 = new(this, "GetByteCount", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32));
					r_GetByteCount_CharPointer_Int32.SetBelong(this.instance);
				}
				return r_GetByteCount_CharPointer_Int32;
			}
		}

		/// <summary>
		/// Int32 GetByteCount(Char*, Int32, System.Text.EncoderNLS)
		/// </summary>
		protected RMethod r_GetByteCount_CharPointer_Int32_EncoderNLS;
		public virtual RMethod RGetByteCount_CharPointer_Int32_EncoderNLS
		{
			get
			{
				if(r_GetByteCount_CharPointer_Int32_EncoderNLS == null)
				{
					r_GetByteCount_CharPointer_Int32_EncoderNLS = new(this, "GetByteCount", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32),  ReflectionUtils.GetType("System.Text.EncoderNLS"));
					r_GetByteCount_CharPointer_Int32_EncoderNLS.SetBelong(this.instance);
				}
				return r_GetByteCount_CharPointer_Int32_EncoderNLS;
			}
		}

		/// <summary>
		/// Byte[] GetBytes(Char[])
		/// </summary>
		protected RMethod r_GetBytes_CharArray;
		public virtual RMethod RGetBytes_CharArray
		{
			get
			{
				if(r_GetBytes_CharArray == null)
				{
					r_GetBytes_CharArray = new(this, "GetBytes", 0, typeof(System.Char).MakeArrayType());
					r_GetBytes_CharArray.SetBelong(this.instance);
				}
				return r_GetBytes_CharArray;
			}
		}

		/// <summary>
		/// Byte[] GetBytes(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_GetBytes_CharArray_Int32_Int32;
		public virtual RMethod RGetBytes_CharArray_Int32_Int32
		{
			get
			{
				if(r_GetBytes_CharArray_Int32_Int32 == null)
				{
					r_GetBytes_CharArray_Int32_Int32 = new(this, "GetBytes", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_GetBytes_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_GetBytes_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetBytes(Char[], Int32, Int32, Byte[], Int32)
		/// </summary>
		protected RMethod r_GetBytes_CharArray_Int32_Int32_ByteArray_Int32;
		public virtual RMethod RGetBytes_CharArray_Int32_Int32_ByteArray_Int32
		{
			get
			{
				if(r_GetBytes_CharArray_Int32_Int32_ByteArray_Int32 == null)
				{
					r_GetBytes_CharArray_Int32_Int32_ByteArray_Int32 = new(this, "GetBytes", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_GetBytes_CharArray_Int32_Int32_ByteArray_Int32.SetBelong(this.instance);
				}
				return r_GetBytes_CharArray_Int32_Int32_ByteArray_Int32;
			}
		}

		/// <summary>
		/// Byte[] GetBytes(System.String)
		/// </summary>
		protected RMethod r_GetBytes_String;
		public virtual RMethod RGetBytes_String
		{
			get
			{
				if(r_GetBytes_String == null)
				{
					r_GetBytes_String = new(this, "GetBytes", 0, typeof(System.String));
					r_GetBytes_String.SetBelong(this.instance);
				}
				return r_GetBytes_String;
			}
		}

		/// <summary>
		/// Int32 GetBytes(System.String, Int32, Int32, Byte[], Int32)
		/// </summary>
		protected RMethod r_GetBytes_String_Int32_Int32_ByteArray_Int32;
		public virtual RMethod RGetBytes_String_Int32_Int32_ByteArray_Int32
		{
			get
			{
				if(r_GetBytes_String_Int32_Int32_ByteArray_Int32 == null)
				{
					r_GetBytes_String_Int32_Int32_ByteArray_Int32 = new(this, "GetBytes", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_GetBytes_String_Int32_Int32_ByteArray_Int32.SetBelong(this.instance);
				}
				return r_GetBytes_String_Int32_Int32_ByteArray_Int32;
			}
		}

		/// <summary>
		/// Int32 GetBytes(Char*, Int32, Byte*, Int32, System.Text.EncoderNLS)
		/// </summary>
		protected RMethod r_GetBytes_CharPointer_Int32_BytePointer_Int32_EncoderNLS;
		public virtual RMethod RGetBytes_CharPointer_Int32_BytePointer_Int32_EncoderNLS
		{
			get
			{
				if(r_GetBytes_CharPointer_Int32_BytePointer_Int32_EncoderNLS == null)
				{
					r_GetBytes_CharPointer_Int32_BytePointer_Int32_EncoderNLS = new(this, "GetBytes", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Byte).MakePointerType(), typeof(System.Int32),  ReflectionUtils.GetType("System.Text.EncoderNLS"));
					r_GetBytes_CharPointer_Int32_BytePointer_Int32_EncoderNLS.SetBelong(this.instance);
				}
				return r_GetBytes_CharPointer_Int32_BytePointer_Int32_EncoderNLS;
			}
		}

		/// <summary>
		/// Int32 GetBytes(Char*, Int32, Byte*, Int32)
		/// </summary>
		protected RMethod r_GetBytes_CharPointer_Int32_BytePointer_Int32;
		public virtual RMethod RGetBytes_CharPointer_Int32_BytePointer_Int32
		{
			get
			{
				if(r_GetBytes_CharPointer_Int32_BytePointer_Int32 == null)
				{
					r_GetBytes_CharPointer_Int32_BytePointer_Int32 = new(this, "GetBytes", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_GetBytes_CharPointer_Int32_BytePointer_Int32.SetBelong(this.instance);
				}
				return r_GetBytes_CharPointer_Int32_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Int32 GetCharCount(Byte[])
		/// </summary>
		protected RMethod r_GetCharCount_ByteArray;
		public virtual RMethod RGetCharCount_ByteArray
		{
			get
			{
				if(r_GetCharCount_ByteArray == null)
				{
					r_GetCharCount_ByteArray = new(this, "GetCharCount", 0, typeof(System.Byte).MakeArrayType());
					r_GetCharCount_ByteArray.SetBelong(this.instance);
				}
				return r_GetCharCount_ByteArray;
			}
		}

		/// <summary>
		/// Int32 GetCharCount(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_GetCharCount_ByteArray_Int32_Int32;
		public virtual RMethod RGetCharCount_ByteArray_Int32_Int32
		{
			get
			{
				if(r_GetCharCount_ByteArray_Int32_Int32 == null)
				{
					r_GetCharCount_ByteArray_Int32_Int32 = new(this, "GetCharCount", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_GetCharCount_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_GetCharCount_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetCharCount(Byte*, Int32)
		/// </summary>
		protected RMethod r_GetCharCount_BytePointer_Int32;
		public virtual RMethod RGetCharCount_BytePointer_Int32
		{
			get
			{
				if(r_GetCharCount_BytePointer_Int32 == null)
				{
					r_GetCharCount_BytePointer_Int32 = new(this, "GetCharCount", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_GetCharCount_BytePointer_Int32.SetBelong(this.instance);
				}
				return r_GetCharCount_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Int32 GetCharCount(Byte*, Int32, System.Text.DecoderNLS)
		/// </summary>
		protected RMethod r_GetCharCount_BytePointer_Int32_DecoderNLS;
		public virtual RMethod RGetCharCount_BytePointer_Int32_DecoderNLS
		{
			get
			{
				if(r_GetCharCount_BytePointer_Int32_DecoderNLS == null)
				{
					r_GetCharCount_BytePointer_Int32_DecoderNLS = new(this, "GetCharCount", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32),  ReflectionUtils.GetType("System.Text.DecoderNLS"));
					r_GetCharCount_BytePointer_Int32_DecoderNLS.SetBelong(this.instance);
				}
				return r_GetCharCount_BytePointer_Int32_DecoderNLS;
			}
		}

		/// <summary>
		/// Char[] GetChars(Byte[])
		/// </summary>
		protected RMethod r_GetChars_ByteArray;
		public virtual RMethod RGetChars_ByteArray
		{
			get
			{
				if(r_GetChars_ByteArray == null)
				{
					r_GetChars_ByteArray = new(this, "GetChars", 0, typeof(System.Byte).MakeArrayType());
					r_GetChars_ByteArray.SetBelong(this.instance);
				}
				return r_GetChars_ByteArray;
			}
		}

		/// <summary>
		/// Char[] GetChars(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_GetChars_ByteArray_Int32_Int32;
		public virtual RMethod RGetChars_ByteArray_Int32_Int32
		{
			get
			{
				if(r_GetChars_ByteArray_Int32_Int32 == null)
				{
					r_GetChars_ByteArray_Int32_Int32 = new(this, "GetChars", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_GetChars_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_GetChars_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetChars(Byte[], Int32, Int32, Char[], Int32)
		/// </summary>
		protected RMethod r_GetChars_ByteArray_Int32_Int32_CharArray_Int32;
		public virtual RMethod RGetChars_ByteArray_Int32_Int32_CharArray_Int32
		{
			get
			{
				if(r_GetChars_ByteArray_Int32_Int32_CharArray_Int32 == null)
				{
					r_GetChars_ByteArray_Int32_Int32_CharArray_Int32 = new(this, "GetChars", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Char).MakeArrayType(), typeof(System.Int32));
					r_GetChars_ByteArray_Int32_Int32_CharArray_Int32.SetBelong(this.instance);
				}
				return r_GetChars_ByteArray_Int32_Int32_CharArray_Int32;
			}
		}

		/// <summary>
		/// Int32 GetChars(Byte*, Int32, Char*, Int32)
		/// </summary>
		protected RMethod r_GetChars_BytePointer_Int32_CharPointer_Int32;
		public virtual RMethod RGetChars_BytePointer_Int32_CharPointer_Int32
		{
			get
			{
				if(r_GetChars_BytePointer_Int32_CharPointer_Int32 == null)
				{
					r_GetChars_BytePointer_Int32_CharPointer_Int32 = new(this, "GetChars", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32), typeof(System.Char).MakePointerType(), typeof(System.Int32));
					r_GetChars_BytePointer_Int32_CharPointer_Int32.SetBelong(this.instance);
				}
				return r_GetChars_BytePointer_Int32_CharPointer_Int32;
			}
		}

		/// <summary>
		/// Int32 GetChars(Byte*, Int32, Char*, Int32, System.Text.DecoderNLS)
		/// </summary>
		protected RMethod r_GetChars_BytePointer_Int32_CharPointer_Int32_DecoderNLS;
		public virtual RMethod RGetChars_BytePointer_Int32_CharPointer_Int32_DecoderNLS
		{
			get
			{
				if(r_GetChars_BytePointer_Int32_CharPointer_Int32_DecoderNLS == null)
				{
					r_GetChars_BytePointer_Int32_CharPointer_Int32_DecoderNLS = new(this, "GetChars", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32), typeof(System.Char).MakePointerType(), typeof(System.Int32),  ReflectionUtils.GetType("System.Text.DecoderNLS"));
					r_GetChars_BytePointer_Int32_CharPointer_Int32_DecoderNLS.SetBelong(this.instance);
				}
				return r_GetChars_BytePointer_Int32_CharPointer_Int32_DecoderNLS;
			}
		}

		/// <summary>
		/// System.String GetString(Byte*, Int32)
		/// </summary>
		protected RMethod r_GetString_BytePointer_Int32;
		public virtual RMethod RGetString_BytePointer_Int32
		{
			get
			{
				if(r_GetString_BytePointer_Int32 == null)
				{
					r_GetString_BytePointer_Int32 = new(this, "GetString", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_GetString_BytePointer_Int32.SetBelong(this.instance);
				}
				return r_GetString_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Int32 GetChars(System.ReadOnlySpan`1[System.Byte], System.Span`1[System.Char])
		/// </summary>
		protected RMethod r_GetChars_ReadOnlySpan_d_Byte_p__Span_d_Char_p_;
		public virtual RMethod RGetChars_ReadOnlySpan_d_Byte_p__Span_d_Char_p_
		{
			get
			{
				if(r_GetChars_ReadOnlySpan_d_Byte_p__Span_d_Char_p_ == null)
				{
					r_GetChars_ReadOnlySpan_d_Byte_p__Span_d_Char_p_ = new(this, "GetChars", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Span<>).MakeGenericType(typeof(System.Char)));
					r_GetChars_ReadOnlySpan_d_Byte_p__Span_d_Char_p_.SetBelong(this.instance);
				}
				return r_GetChars_ReadOnlySpan_d_Byte_p__Span_d_Char_p_;
			}
		}

		/// <summary>
		/// System.String GetString(System.ReadOnlySpan`1[System.Byte])
		/// </summary>
		protected RMethod r_GetString_ReadOnlySpan_d_Byte_p_;
		public virtual RMethod RGetString_ReadOnlySpan_d_Byte_p_
		{
			get
			{
				if(r_GetString_ReadOnlySpan_d_Byte_p_ == null)
				{
					r_GetString_ReadOnlySpan_d_Byte_p_ = new(this, "GetString", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)));
					r_GetString_ReadOnlySpan_d_Byte_p_.SetBelong(this.instance);
				}
				return r_GetString_ReadOnlySpan_d_Byte_p_;
			}
		}

		/// <summary>
		/// Boolean IsAlwaysNormalized()
		/// </summary>
		protected RMethod r_IsAlwaysNormalized;
		public virtual RMethod RIsAlwaysNormalized
		{
			get
			{
				if(r_IsAlwaysNormalized == null)
				{
					r_IsAlwaysNormalized = new(this, "IsAlwaysNormalized", 0);
					r_IsAlwaysNormalized.SetBelong(this.instance);
				}
				return r_IsAlwaysNormalized;
			}
		}

		/// <summary>
		/// Boolean IsAlwaysNormalized(System.Text.NormalizationForm)
		/// </summary>
		protected RMethod r_IsAlwaysNormalized_NormalizationForm;
		public virtual RMethod RIsAlwaysNormalized_NormalizationForm
		{
			get
			{
				if(r_IsAlwaysNormalized_NormalizationForm == null)
				{
					r_IsAlwaysNormalized_NormalizationForm = new(this, "IsAlwaysNormalized", 0, typeof(System.Text.NormalizationForm));
					r_IsAlwaysNormalized_NormalizationForm.SetBelong(this.instance);
				}
				return r_IsAlwaysNormalized_NormalizationForm;
			}
		}

		/// <summary>
		/// System.Text.Decoder GetDecoder()
		/// </summary>
		protected RMethod r_GetDecoder;
		public virtual RMethod RGetDecoder
		{
			get
			{
				if(r_GetDecoder == null)
				{
					r_GetDecoder = new(this, "GetDecoder", 0);
					r_GetDecoder.SetBelong(this.instance);
				}
				return r_GetDecoder;
			}
		}

		/// <summary>
		/// System.Text.Encoding CreateDefaultEncoding()
		/// </summary>
		protected static RMethod r_CreateDefaultEncoding;
		public static RMethod RCreateDefaultEncoding
		{
			get
			{
				if(r_CreateDefaultEncoding == null)
				{
					r_CreateDefaultEncoding = new(typeof(System.Text.Encoding), "CreateDefaultEncoding", 0);
					r_CreateDefaultEncoding.SetBelong(null);
				}
				return r_CreateDefaultEncoding;
			}
		}

		/// <summary>
		/// Void setReadOnly(Boolean)
		/// </summary>
		protected RMethod r_setReadOnly_Boolean;
		public virtual RMethod RsetReadOnly_Boolean
		{
			get
			{
				if(r_setReadOnly_Boolean == null)
				{
					r_setReadOnly_Boolean = new(this, "setReadOnly", 0, typeof(System.Boolean));
					r_setReadOnly_Boolean.SetBelong(this.instance);
				}
				return r_setReadOnly_Boolean;
			}
		}

		/// <summary>
		/// System.Text.Encoder GetEncoder()
		/// </summary>
		protected RMethod r_GetEncoder;
		public virtual RMethod RGetEncoder
		{
			get
			{
				if(r_GetEncoder == null)
				{
					r_GetEncoder = new(this, "GetEncoder", 0);
					r_GetEncoder.SetBelong(this.instance);
				}
				return r_GetEncoder;
			}
		}

		/// <summary>
		/// Int32 GetMaxByteCount(Int32)
		/// </summary>
		protected RMethod r_GetMaxByteCount_Int32;
		public virtual RMethod RGetMaxByteCount_Int32
		{
			get
			{
				if(r_GetMaxByteCount_Int32 == null)
				{
					r_GetMaxByteCount_Int32 = new(this, "GetMaxByteCount", 0, typeof(System.Int32));
					r_GetMaxByteCount_Int32.SetBelong(this.instance);
				}
				return r_GetMaxByteCount_Int32;
			}
		}

		/// <summary>
		/// Int32 GetMaxCharCount(Int32)
		/// </summary>
		protected RMethod r_GetMaxCharCount_Int32;
		public virtual RMethod RGetMaxCharCount_Int32
		{
			get
			{
				if(r_GetMaxCharCount_Int32 == null)
				{
					r_GetMaxCharCount_Int32 = new(this, "GetMaxCharCount", 0, typeof(System.Int32));
					r_GetMaxCharCount_Int32.SetBelong(this.instance);
				}
				return r_GetMaxCharCount_Int32;
			}
		}

		/// <summary>
		/// System.String GetString(Byte[])
		/// </summary>
		protected RMethod r_GetString_ByteArray;
		public virtual RMethod RGetString_ByteArray
		{
			get
			{
				if(r_GetString_ByteArray == null)
				{
					r_GetString_ByteArray = new(this, "GetString", 0, typeof(System.Byte).MakeArrayType());
					r_GetString_ByteArray.SetBelong(this.instance);
				}
				return r_GetString_ByteArray;
			}
		}

		/// <summary>
		/// System.String GetString(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_GetString_ByteArray_Int32_Int32;
		public virtual RMethod RGetString_ByteArray_Int32_Int32
		{
			get
			{
				if(r_GetString_ByteArray_Int32_Int32 == null)
				{
					r_GetString_ByteArray_Int32_Int32 = new(this, "GetString", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_GetString_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_GetString_ByteArray_Int32_Int32;
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
		/// Char[] GetBestFitUnicodeToBytesData()
		/// </summary>
		protected RMethod r_GetBestFitUnicodeToBytesData;
		public virtual RMethod RGetBestFitUnicodeToBytesData
		{
			get
			{
				if(r_GetBestFitUnicodeToBytesData == null)
				{
					r_GetBestFitUnicodeToBytesData = new(this, "GetBestFitUnicodeToBytesData", 0);
					r_GetBestFitUnicodeToBytesData.SetBelong(this.instance);
				}
				return r_GetBestFitUnicodeToBytesData;
			}
		}

		/// <summary>
		/// Char[] GetBestFitBytesToUnicodeData()
		/// </summary>
		protected RMethod r_GetBestFitBytesToUnicodeData;
		public virtual RMethod RGetBestFitBytesToUnicodeData
		{
			get
			{
				if(r_GetBestFitBytesToUnicodeData == null)
				{
					r_GetBestFitBytesToUnicodeData = new(this, "GetBestFitBytesToUnicodeData", 0);
					r_GetBestFitBytesToUnicodeData.SetBelong(this.instance);
				}
				return r_GetBestFitBytesToUnicodeData;
			}
		}

		/// <summary>
		/// Void ThrowBytesOverflow()
		/// </summary>
		protected RMethod r_ThrowBytesOverflow;
		public virtual RMethod RThrowBytesOverflow
		{
			get
			{
				if(r_ThrowBytesOverflow == null)
				{
					r_ThrowBytesOverflow = new(this, "ThrowBytesOverflow", 0);
					r_ThrowBytesOverflow.SetBelong(this.instance);
				}
				return r_ThrowBytesOverflow;
			}
		}

		/// <summary>
		/// Void ThrowBytesOverflow(System.Text.EncoderNLS, Boolean)
		/// </summary>
		protected RMethod r_ThrowBytesOverflow_EncoderNLS_Boolean;
		public virtual RMethod RThrowBytesOverflow_EncoderNLS_Boolean
		{
			get
			{
				if(r_ThrowBytesOverflow_EncoderNLS_Boolean == null)
				{
					r_ThrowBytesOverflow_EncoderNLS_Boolean = new(this, "ThrowBytesOverflow", 0,  ReflectionUtils.GetType("System.Text.EncoderNLS"), typeof(System.Boolean));
					r_ThrowBytesOverflow_EncoderNLS_Boolean.SetBelong(this.instance);
				}
				return r_ThrowBytesOverflow_EncoderNLS_Boolean;
			}
		}

		/// <summary>
		/// Void ThrowCharsOverflow()
		/// </summary>
		protected RMethod r_ThrowCharsOverflow;
		public virtual RMethod RThrowCharsOverflow
		{
			get
			{
				if(r_ThrowCharsOverflow == null)
				{
					r_ThrowCharsOverflow = new(this, "ThrowCharsOverflow", 0);
					r_ThrowCharsOverflow.SetBelong(this.instance);
				}
				return r_ThrowCharsOverflow;
			}
		}

		/// <summary>
		/// Void ThrowCharsOverflow(System.Text.DecoderNLS, Boolean)
		/// </summary>
		protected RMethod r_ThrowCharsOverflow_DecoderNLS_Boolean;
		public virtual RMethod RThrowCharsOverflow_DecoderNLS_Boolean
		{
			get
			{
				if(r_ThrowCharsOverflow_DecoderNLS_Boolean == null)
				{
					r_ThrowCharsOverflow_DecoderNLS_Boolean = new(this, "ThrowCharsOverflow", 0,  ReflectionUtils.GetType("System.Text.DecoderNLS"), typeof(System.Boolean));
					r_ThrowCharsOverflow_DecoderNLS_Boolean.SetBelong(this.instance);
				}
				return r_ThrowCharsOverflow_DecoderNLS_Boolean;
			}
		}

		/// <summary>
		/// Int32 GetCharCount(System.ReadOnlySpan`1[System.Byte])
		/// </summary>
		protected RMethod r_GetCharCount_ReadOnlySpan_d_Byte_p_;
		public virtual RMethod RGetCharCount_ReadOnlySpan_d_Byte_p_
		{
			get
			{
				if(r_GetCharCount_ReadOnlySpan_d_Byte_p_ == null)
				{
					r_GetCharCount_ReadOnlySpan_d_Byte_p_ = new(this, "GetCharCount", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)));
					r_GetCharCount_ReadOnlySpan_d_Byte_p_.SetBelong(this.instance);
				}
				return r_GetCharCount_ReadOnlySpan_d_Byte_p_;
			}
		}

		/// <summary>
		/// Int32 GetByteCount(System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected RMethod r_GetByteCount_ReadOnlySpan_d_Char_p_;
		public virtual RMethod RGetByteCount_ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_GetByteCount_ReadOnlySpan_d_Char_p_ == null)
				{
					r_GetByteCount_ReadOnlySpan_d_Char_p_ = new(this, "GetByteCount", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_GetByteCount_ReadOnlySpan_d_Char_p_.SetBelong(this.instance);
				}
				return r_GetByteCount_ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// Int32 GetBytes(System.ReadOnlySpan`1[System.Char], System.Span`1[System.Byte])
		/// </summary>
		protected RMethod r_GetBytes_ReadOnlySpan_d_Char_p__Span_d_Byte_p_;
		public virtual RMethod RGetBytes_ReadOnlySpan_d_Char_p__Span_d_Byte_p_
		{
			get
			{
				if(r_GetBytes_ReadOnlySpan_d_Char_p__Span_d_Byte_p_ == null)
				{
					r_GetBytes_ReadOnlySpan_d_Char_p__Span_d_Byte_p_ = new(this, "GetBytes", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Span<>).MakeGenericType(typeof(System.Byte)));
					r_GetBytes_ReadOnlySpan_d_Char_p__Span_d_Byte_p_.SetBelong(this.instance);
				}
				return r_GetBytes_ReadOnlySpan_d_Char_p__Span_d_Byte_p_;
			}
		}

		/// <summary>
		/// Byte[] GetBytes(System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_GetBytes_String_Int32_Int32;
		public virtual RMethod RGetBytes_String_Int32_Int32
		{
			get
			{
				if(r_GetBytes_String_Int32_Int32 == null)
				{
					r_GetBytes_String_Int32_Int32 = new(this, "GetBytes", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_GetBytes_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_GetBytes_String_Int32_Int32;
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


        public REncoding() : base("System.Text.Encoding")
        {
        }

        public REncoding(System.Object instance) : base("System.Text.Encoding")
		{
            SetInstance(instance);
		}

        public REncoding(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REncoding(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetDefaultFallbacks()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetDefaultFallbacks.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDeserializing()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnDeserializing.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDeserialized()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnDeserialized.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDeserializing(System.Runtime.Serialization.StreamingContext @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx};
            var ___result = ROnDeserializing_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDeserialized(System.Runtime.Serialization.StreamingContext @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx};
            var ___result = ROnDeserialized_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnSerializing(System.Runtime.Serialization.StreamingContext @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx};
            var ___result = ROnSerializing_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DeserializeEncoding(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RDeserializeEncoding_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SerializeEncoding(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RSerializeEncoding_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Byte[] Convert(System.Text.Encoding @srcEncoding, System.Text.Encoding @dstEncoding, System.Byte[] @bytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@srcEncoding, @dstEncoding, @bytes};
            var ___result = RConvert_Encoding_Encoding_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public static System.Byte[] Convert(System.Text.Encoding @srcEncoding, System.Text.Encoding @dstEncoding, System.Byte[] @bytes, System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@srcEncoding, @dstEncoding, @bytes, @index, @count};
            var ___result = RConvert_Encoding_Encoding_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public static void RegisterProvider(System.Text.EncodingProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RRegisterProvider_EncodingProvider.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Text.Encoding GetEncoding(System.Int32 @codepage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@codepage};
            var ___result = RGetEncoding_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoding)___result;
        }


        public static System.Text.Encoding GetEncoding(System.Int32 @codepage, System.Text.EncoderFallback @encoderFallback, System.Text.DecoderFallback @decoderFallback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@codepage, @encoderFallback, @decoderFallback};
            var ___result = RGetEncoding_Int32_EncoderFallback_DecoderFallback.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoding)___result;
        }


        public static System.Text.Encoding GetEncoding(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetEncoding_String.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoding)___result;
        }


        public static System.Text.Encoding GetEncoding(System.String @name, System.Text.EncoderFallback @encoderFallback, System.Text.DecoderFallback @decoderFallback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @encoderFallback, @decoderFallback};
            var ___result = RGetEncoding_String_EncoderFallback_DecoderFallback.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoding)___result;
        }


        public static System.Text.EncodingInfo[] GetEncodings()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEncodings.Invoke(___genericsType, ___parameters);

            return (System.Text.EncodingInfo[])___result;
        }


        public virtual System.Byte[] GetPreamble()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPreamble.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual void GetDataItem()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDataItem.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Int32 GetByteCount(System.Char[] @chars)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars};
            var ___result = RGetByteCount_CharArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetByteCount(System.String @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RGetByteCount_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetByteCount(System.Char[] @chars, System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars, @index, @count};
            var ___result = RGetByteCount_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetByteCount(System.String @str, System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str, @index, @count};
            var ___result = RGetByteCount_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe virtual System.Int32 GetByteCount(System.Char* @chars, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@chars, typeof(System.Char)), @count};
            var ___result = RGetByteCount_CharPointer_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe virtual System.Int32 GetByteCount(System.Char* @chars, System.Int32 @count, RSystem.RText.REncoderNLS @encoder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@chars, typeof(System.Char)), @count, @encoder.Value};
            var ___result = RGetByteCount_CharPointer_Int32_EncoderNLS.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Byte[] GetBytes(System.Char[] @chars)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars};
            var ___result = RGetBytes_CharArray.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] GetBytes(System.Char[] @chars, System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars, @index, @count};
            var ___result = RGetBytes_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Int32 GetBytes(System.Char[] @chars, System.Int32 @charIndex, System.Int32 @charCount, System.Byte[] @bytes, System.Int32 @byteIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars, @charIndex, @charCount, @bytes, @byteIndex};
            var ___result = RGetBytes_CharArray_Int32_Int32_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Byte[] GetBytes(System.String @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RGetBytes_String.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Int32 GetBytes(System.String @s, System.Int32 @charIndex, System.Int32 @charCount, System.Byte[] @bytes, System.Int32 @byteIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @charIndex, @charCount, @bytes, @byteIndex};
            var ___result = RGetBytes_String_Int32_Int32_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe virtual System.Int32 GetBytes(System.Char* @chars, System.Int32 @charCount, System.Byte* @bytes, System.Int32 @byteCount, RSystem.RText.REncoderNLS @encoder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@chars, typeof(System.Char)), @charCount, Pointer.Box(@bytes, typeof(System.Byte)), @byteCount, @encoder.Value};
            var ___result = RGetBytes_CharPointer_Int32_BytePointer_Int32_EncoderNLS.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe virtual System.Int32 GetBytes(System.Char* @chars, System.Int32 @charCount, System.Byte* @bytes, System.Int32 @byteCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@chars, typeof(System.Char)), @charCount, Pointer.Box(@bytes, typeof(System.Byte)), @byteCount};
            var ___result = RGetBytes_CharPointer_Int32_BytePointer_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetCharCount(System.Byte[] @bytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes};
            var ___result = RGetCharCount_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetCharCount(System.Byte[] @bytes, System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes, @index, @count};
            var ___result = RGetCharCount_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe virtual System.Int32 GetCharCount(System.Byte* @bytes, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@bytes, typeof(System.Byte)), @count};
            var ___result = RGetCharCount_BytePointer_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe virtual System.Int32 GetCharCount(System.Byte* @bytes, System.Int32 @count, RSystem.RText.RDecoderNLS @decoder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@bytes, typeof(System.Byte)), @count, @decoder.Value};
            var ___result = RGetCharCount_BytePointer_Int32_DecoderNLS.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Char[] GetChars(System.Byte[] @bytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes};
            var ___result = RGetChars_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Char[])___result;
        }


        public virtual System.Char[] GetChars(System.Byte[] @bytes, System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes, @index, @count};
            var ___result = RGetChars_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Char[])___result;
        }


        public virtual System.Int32 GetChars(System.Byte[] @bytes, System.Int32 @byteIndex, System.Int32 @byteCount, System.Char[] @chars, System.Int32 @charIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes, @byteIndex, @byteCount, @chars, @charIndex};
            var ___result = RGetChars_ByteArray_Int32_Int32_CharArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe virtual System.Int32 GetChars(System.Byte* @bytes, System.Int32 @byteCount, System.Char* @chars, System.Int32 @charCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@bytes, typeof(System.Byte)), @byteCount, Pointer.Box(@chars, typeof(System.Char)), @charCount};
            var ___result = RGetChars_BytePointer_Int32_CharPointer_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe virtual System.Int32 GetChars(System.Byte* @bytes, System.Int32 @byteCount, System.Char* @chars, System.Int32 @charCount, RSystem.RText.RDecoderNLS @decoder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@bytes, typeof(System.Byte)), @byteCount, Pointer.Box(@chars, typeof(System.Char)), @charCount, @decoder.Value};
            var ___result = RGetChars_BytePointer_Int32_CharPointer_Int32_DecoderNLS.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe virtual System.String GetString(System.Byte* @bytes, System.Int32 @byteCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@bytes, typeof(System.Byte)), @byteCount};
            var ___result = RGetString_BytePointer_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 GetChars(RSystem.RReadOnlySpan<RSystem.RByte> @bytes, RSystem.RSpan<RSystem.RChar> @chars)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes.Value, @chars.Value};
            var ___result = RGetChars_ReadOnlySpan_d_Byte_p__Span_d_Char_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String GetString(RSystem.RReadOnlySpan<RSystem.RByte> @bytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes.Value};
            var ___result = RGetString_ReadOnlySpan_d_Byte_p_.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean IsAlwaysNormalized()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsAlwaysNormalized.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsAlwaysNormalized(System.Text.NormalizationForm @form)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@form};
            var ___result = RIsAlwaysNormalized_NormalizationForm.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Text.Decoder GetDecoder()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDecoder.Invoke(___genericsType, ___parameters);

            return (System.Text.Decoder)___result;
        }


        public static System.Text.Encoding CreateDefaultEncoding()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateDefaultEncoding.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoding)___result;
        }


        public virtual void setReadOnly(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RsetReadOnly_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Text.Encoder GetEncoder()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEncoder.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoder)___result;
        }


        public virtual System.Int32 GetMaxByteCount(System.Int32 @charCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@charCount};
            var ___result = RGetMaxByteCount_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetMaxCharCount(System.Int32 @byteCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@byteCount};
            var ___result = RGetMaxCharCount_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String GetString(System.Byte[] @bytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes};
            var ___result = RGetString_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetString(System.Byte[] @bytes, System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes, @index, @count};
            var ___result = RGetString_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean Equals(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Char[] GetBestFitUnicodeToBytesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetBestFitUnicodeToBytesData.Invoke(___genericsType, ___parameters);

            return (System.Char[])___result;
        }


        public virtual System.Char[] GetBestFitBytesToUnicodeData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetBestFitBytesToUnicodeData.Invoke(___genericsType, ___parameters);

            return (System.Char[])___result;
        }


        public virtual void ThrowBytesOverflow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RThrowBytesOverflow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ThrowBytesOverflow(RSystem.RText.REncoderNLS @encoder, System.Boolean @nothingEncoded)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@encoder.Value, @nothingEncoded};
            var ___result = RThrowBytesOverflow_EncoderNLS_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ThrowCharsOverflow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RThrowCharsOverflow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ThrowCharsOverflow(RSystem.RText.RDecoderNLS @decoder, System.Boolean @nothingDecoded)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@decoder.Value, @nothingDecoded};
            var ___result = RThrowCharsOverflow_DecoderNLS_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetCharCount(RSystem.RReadOnlySpan<RSystem.RByte> @bytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes.Value};
            var ___result = RGetCharCount_ReadOnlySpan_d_Byte_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetByteCount(RSystem.RReadOnlySpan<RSystem.RChar> @chars)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars.Value};
            var ___result = RGetByteCount_ReadOnlySpan_d_Char_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetBytes(RSystem.RReadOnlySpan<RSystem.RChar> @chars, RSystem.RSpan<RSystem.RByte> @bytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars.Value, @bytes.Value};
            var ___result = RGetBytes_ReadOnlySpan_d_Char_p__Span_d_Byte_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Byte[] GetBytes(System.String @s, System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index, @count};
            var ___result = RGetBytes_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
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
