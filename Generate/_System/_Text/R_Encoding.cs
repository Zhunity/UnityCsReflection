
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RText
{
	/// <summary>
	/// System.Text.Encoding
	/// </summary>
    public partial class REncoding : RMember //
    {

		/// <summary>
		/// System.Text.Encoding defaultEncoding
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RText.REncoding r_FdefaultEncoding;
		public static Hvak.Editor.Refleaction.RSystem.RText.REncoding RFdefaultEncoding
		{
			get
			{
				if(r_FdefaultEncoding == null)
				{
					r_FdefaultEncoding = new(typeof(System.Text.Encoding), "defaultEncoding");
					r_FdefaultEncoding.SetBelong(null);
				}
				return r_FdefaultEncoding;
			}
		}

		/// <summary>
		/// System.Text.Encoding unicodeEncoding
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RText.REncoding r_FunicodeEncoding;
		public static Hvak.Editor.Refleaction.RSystem.RText.REncoding RFunicodeEncoding
		{
			get
			{
				if(r_FunicodeEncoding == null)
				{
					r_FunicodeEncoding = new(typeof(System.Text.Encoding), "unicodeEncoding");
					r_FunicodeEncoding.SetBelong(null);
				}
				return r_FunicodeEncoding;
			}
		}

		/// <summary>
		/// System.Text.Encoding bigEndianUnicode
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RText.REncoding r_FbigEndianUnicode;
		public static Hvak.Editor.Refleaction.RSystem.RText.REncoding RFbigEndianUnicode
		{
			get
			{
				if(r_FbigEndianUnicode == null)
				{
					r_FbigEndianUnicode = new(typeof(System.Text.Encoding), "bigEndianUnicode");
					r_FbigEndianUnicode.SetBelong(null);
				}
				return r_FbigEndianUnicode;
			}
		}

		/// <summary>
		/// System.Text.Encoding utf7Encoding
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RText.REncoding r_Futf7Encoding;
		public static Hvak.Editor.Refleaction.RSystem.RText.REncoding RFutf7Encoding
		{
			get
			{
				if(r_Futf7Encoding == null)
				{
					r_Futf7Encoding = new(typeof(System.Text.Encoding), "utf7Encoding");
					r_Futf7Encoding.SetBelong(null);
				}
				return r_Futf7Encoding;
			}
		}

		/// <summary>
		/// System.Text.Encoding utf8Encoding
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RText.REncoding r_Futf8Encoding;
		public static Hvak.Editor.Refleaction.RSystem.RText.REncoding RFutf8Encoding
		{
			get
			{
				if(r_Futf8Encoding == null)
				{
					r_Futf8Encoding = new(typeof(System.Text.Encoding), "utf8Encoding");
					r_Futf8Encoding.SetBelong(null);
				}
				return r_Futf8Encoding;
			}
		}

		/// <summary>
		/// System.Text.Encoding utf32Encoding
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RText.REncoding r_Futf32Encoding;
		public static Hvak.Editor.Refleaction.RSystem.RText.REncoding RFutf32Encoding
		{
			get
			{
				if(r_Futf32Encoding == null)
				{
					r_Futf32Encoding = new(typeof(System.Text.Encoding), "utf32Encoding");
					r_Futf32Encoding.SetBelong(null);
				}
				return r_Futf32Encoding;
			}
		}

		/// <summary>
		/// System.Text.Encoding asciiEncoding
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RText.REncoding r_FasciiEncoding;
		public static Hvak.Editor.Refleaction.RSystem.RText.REncoding RFasciiEncoding
		{
			get
			{
				if(r_FasciiEncoding == null)
				{
					r_FasciiEncoding = new(typeof(System.Text.Encoding), "asciiEncoding");
					r_FasciiEncoding.SetBelong(null);
				}
				return r_FasciiEncoding;
			}
		}

		/// <summary>
		/// System.Text.Encoding latin1Encoding
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RText.REncoding r_Flatin1Encoding;
		public static Hvak.Editor.Refleaction.RSystem.RText.REncoding RFlatin1Encoding
		{
			get
			{
				if(r_Flatin1Encoding == null)
				{
					r_Flatin1Encoding = new(typeof(System.Text.Encoding), "latin1Encoding");
					r_Flatin1Encoding.SetBelong(null);
				}
				return r_Flatin1Encoding;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,System.Text.Encoding] encodings
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RInt32, Hvak.Editor.Refleaction.RSystem.RText.REncoding> r_Fencodings;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RInt32, Hvak.Editor.Refleaction.RSystem.RText.REncoding> RFencodings
		{
			get
			{
				if(r_Fencodings == null)
				{
					r_Fencodings = new(typeof(System.Text.Encoding), "encodings");
					r_Fencodings.SetBelong(null);
				}
				return r_Fencodings;
			}
		}

		/// <summary>
		/// System.Int32 MIMECONTF_MAILNEWS
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FMIMECONTF_MAILNEWS;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFMIMECONTF_MAILNEWS
		{
			get
			{
				if(r_FMIMECONTF_MAILNEWS == null)
				{
					r_FMIMECONTF_MAILNEWS = new(typeof(System.Text.Encoding), "MIMECONTF_MAILNEWS");
					r_FMIMECONTF_MAILNEWS.SetBelong(null);
				}
				return r_FMIMECONTF_MAILNEWS;
			}
		}

		/// <summary>
		/// System.Int32 MIMECONTF_BROWSER
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FMIMECONTF_BROWSER;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFMIMECONTF_BROWSER
		{
			get
			{
				if(r_FMIMECONTF_BROWSER == null)
				{
					r_FMIMECONTF_BROWSER = new(typeof(System.Text.Encoding), "MIMECONTF_BROWSER");
					r_FMIMECONTF_BROWSER.SetBelong(null);
				}
				return r_FMIMECONTF_BROWSER;
			}
		}

		/// <summary>
		/// System.Int32 MIMECONTF_SAVABLE_MAILNEWS
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FMIMECONTF_SAVABLE_MAILNEWS;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFMIMECONTF_SAVABLE_MAILNEWS
		{
			get
			{
				if(r_FMIMECONTF_SAVABLE_MAILNEWS == null)
				{
					r_FMIMECONTF_SAVABLE_MAILNEWS = new(typeof(System.Text.Encoding), "MIMECONTF_SAVABLE_MAILNEWS");
					r_FMIMECONTF_SAVABLE_MAILNEWS.SetBelong(null);
				}
				return r_FMIMECONTF_SAVABLE_MAILNEWS;
			}
		}

		/// <summary>
		/// System.Int32 MIMECONTF_SAVABLE_BROWSER
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FMIMECONTF_SAVABLE_BROWSER;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFMIMECONTF_SAVABLE_BROWSER
		{
			get
			{
				if(r_FMIMECONTF_SAVABLE_BROWSER == null)
				{
					r_FMIMECONTF_SAVABLE_BROWSER = new(typeof(System.Text.Encoding), "MIMECONTF_SAVABLE_BROWSER");
					r_FMIMECONTF_SAVABLE_BROWSER.SetBelong(null);
				}
				return r_FMIMECONTF_SAVABLE_BROWSER;
			}
		}

		/// <summary>
		/// System.Int32 CodePageDefault
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCodePageDefault;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCodePageDefault
		{
			get
			{
				if(r_FCodePageDefault == null)
				{
					r_FCodePageDefault = new(typeof(System.Text.Encoding), "CodePageDefault");
					r_FCodePageDefault.SetBelong(null);
				}
				return r_FCodePageDefault;
			}
		}

		/// <summary>
		/// System.Int32 CodePageNoOEM
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCodePageNoOEM;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCodePageNoOEM
		{
			get
			{
				if(r_FCodePageNoOEM == null)
				{
					r_FCodePageNoOEM = new(typeof(System.Text.Encoding), "CodePageNoOEM");
					r_FCodePageNoOEM.SetBelong(null);
				}
				return r_FCodePageNoOEM;
			}
		}

		/// <summary>
		/// System.Int32 CodePageNoMac
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCodePageNoMac;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCodePageNoMac
		{
			get
			{
				if(r_FCodePageNoMac == null)
				{
					r_FCodePageNoMac = new(typeof(System.Text.Encoding), "CodePageNoMac");
					r_FCodePageNoMac.SetBelong(null);
				}
				return r_FCodePageNoMac;
			}
		}

		/// <summary>
		/// System.Int32 CodePageNoThread
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCodePageNoThread;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCodePageNoThread
		{
			get
			{
				if(r_FCodePageNoThread == null)
				{
					r_FCodePageNoThread = new(typeof(System.Text.Encoding), "CodePageNoThread");
					r_FCodePageNoThread.SetBelong(null);
				}
				return r_FCodePageNoThread;
			}
		}

		/// <summary>
		/// System.Int32 CodePageNoSymbol
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCodePageNoSymbol;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCodePageNoSymbol
		{
			get
			{
				if(r_FCodePageNoSymbol == null)
				{
					r_FCodePageNoSymbol = new(typeof(System.Text.Encoding), "CodePageNoSymbol");
					r_FCodePageNoSymbol.SetBelong(null);
				}
				return r_FCodePageNoSymbol;
			}
		}

		/// <summary>
		/// System.Int32 CodePageUnicode
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCodePageUnicode;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCodePageUnicode
		{
			get
			{
				if(r_FCodePageUnicode == null)
				{
					r_FCodePageUnicode = new(typeof(System.Text.Encoding), "CodePageUnicode");
					r_FCodePageUnicode.SetBelong(null);
				}
				return r_FCodePageUnicode;
			}
		}

		/// <summary>
		/// System.Int32 CodePageBigEndian
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCodePageBigEndian;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCodePageBigEndian
		{
			get
			{
				if(r_FCodePageBigEndian == null)
				{
					r_FCodePageBigEndian = new(typeof(System.Text.Encoding), "CodePageBigEndian");
					r_FCodePageBigEndian.SetBelong(null);
				}
				return r_FCodePageBigEndian;
			}
		}

		/// <summary>
		/// System.Int32 CodePageWindows1252
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCodePageWindows1252;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCodePageWindows1252
		{
			get
			{
				if(r_FCodePageWindows1252 == null)
				{
					r_FCodePageWindows1252 = new(typeof(System.Text.Encoding), "CodePageWindows1252");
					r_FCodePageWindows1252.SetBelong(null);
				}
				return r_FCodePageWindows1252;
			}
		}

		/// <summary>
		/// System.Int32 CodePageMacGB2312
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCodePageMacGB2312;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCodePageMacGB2312
		{
			get
			{
				if(r_FCodePageMacGB2312 == null)
				{
					r_FCodePageMacGB2312 = new(typeof(System.Text.Encoding), "CodePageMacGB2312");
					r_FCodePageMacGB2312.SetBelong(null);
				}
				return r_FCodePageMacGB2312;
			}
		}

		/// <summary>
		/// System.Int32 CodePageGB2312
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCodePageGB2312;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCodePageGB2312
		{
			get
			{
				if(r_FCodePageGB2312 == null)
				{
					r_FCodePageGB2312 = new(typeof(System.Text.Encoding), "CodePageGB2312");
					r_FCodePageGB2312.SetBelong(null);
				}
				return r_FCodePageGB2312;
			}
		}

		/// <summary>
		/// System.Int32 CodePageMacKorean
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCodePageMacKorean;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCodePageMacKorean
		{
			get
			{
				if(r_FCodePageMacKorean == null)
				{
					r_FCodePageMacKorean = new(typeof(System.Text.Encoding), "CodePageMacKorean");
					r_FCodePageMacKorean.SetBelong(null);
				}
				return r_FCodePageMacKorean;
			}
		}

		/// <summary>
		/// System.Int32 CodePageDLLKorean
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCodePageDLLKorean;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCodePageDLLKorean
		{
			get
			{
				if(r_FCodePageDLLKorean == null)
				{
					r_FCodePageDLLKorean = new(typeof(System.Text.Encoding), "CodePageDLLKorean");
					r_FCodePageDLLKorean.SetBelong(null);
				}
				return r_FCodePageDLLKorean;
			}
		}

		/// <summary>
		/// System.Int32 ISO2022JP
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FISO2022JP;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFISO2022JP
		{
			get
			{
				if(r_FISO2022JP == null)
				{
					r_FISO2022JP = new(typeof(System.Text.Encoding), "ISO2022JP");
					r_FISO2022JP.SetBelong(null);
				}
				return r_FISO2022JP;
			}
		}

		/// <summary>
		/// System.Int32 ISO2022JPESC
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FISO2022JPESC;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFISO2022JPESC
		{
			get
			{
				if(r_FISO2022JPESC == null)
				{
					r_FISO2022JPESC = new(typeof(System.Text.Encoding), "ISO2022JPESC");
					r_FISO2022JPESC.SetBelong(null);
				}
				return r_FISO2022JPESC;
			}
		}

		/// <summary>
		/// System.Int32 ISO2022JPSISO
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FISO2022JPSISO;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFISO2022JPSISO
		{
			get
			{
				if(r_FISO2022JPSISO == null)
				{
					r_FISO2022JPSISO = new(typeof(System.Text.Encoding), "ISO2022JPSISO");
					r_FISO2022JPSISO.SetBelong(null);
				}
				return r_FISO2022JPSISO;
			}
		}

		/// <summary>
		/// System.Int32 ISOKorean
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FISOKorean;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFISOKorean
		{
			get
			{
				if(r_FISOKorean == null)
				{
					r_FISOKorean = new(typeof(System.Text.Encoding), "ISOKorean");
					r_FISOKorean.SetBelong(null);
				}
				return r_FISOKorean;
			}
		}

		/// <summary>
		/// System.Int32 ISOSimplifiedCN
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FISOSimplifiedCN;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFISOSimplifiedCN
		{
			get
			{
				if(r_FISOSimplifiedCN == null)
				{
					r_FISOSimplifiedCN = new(typeof(System.Text.Encoding), "ISOSimplifiedCN");
					r_FISOSimplifiedCN.SetBelong(null);
				}
				return r_FISOSimplifiedCN;
			}
		}

		/// <summary>
		/// System.Int32 EUCJP
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FEUCJP;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFEUCJP
		{
			get
			{
				if(r_FEUCJP == null)
				{
					r_FEUCJP = new(typeof(System.Text.Encoding), "EUCJP");
					r_FEUCJP.SetBelong(null);
				}
				return r_FEUCJP;
			}
		}

		/// <summary>
		/// System.Int32 ChineseHZ
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FChineseHZ;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFChineseHZ
		{
			get
			{
				if(r_FChineseHZ == null)
				{
					r_FChineseHZ = new(typeof(System.Text.Encoding), "ChineseHZ");
					r_FChineseHZ.SetBelong(null);
				}
				return r_FChineseHZ;
			}
		}

		/// <summary>
		/// System.Int32 DuplicateEUCCN
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FDuplicateEUCCN;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFDuplicateEUCCN
		{
			get
			{
				if(r_FDuplicateEUCCN == null)
				{
					r_FDuplicateEUCCN = new(typeof(System.Text.Encoding), "DuplicateEUCCN");
					r_FDuplicateEUCCN.SetBelong(null);
				}
				return r_FDuplicateEUCCN;
			}
		}

		/// <summary>
		/// System.Int32 EUCCN
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FEUCCN;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFEUCCN
		{
			get
			{
				if(r_FEUCCN == null)
				{
					r_FEUCCN = new(typeof(System.Text.Encoding), "EUCCN");
					r_FEUCCN.SetBelong(null);
				}
				return r_FEUCCN;
			}
		}

		/// <summary>
		/// System.Int32 EUCKR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FEUCKR;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFEUCKR
		{
			get
			{
				if(r_FEUCKR == null)
				{
					r_FEUCKR = new(typeof(System.Text.Encoding), "EUCKR");
					r_FEUCKR.SetBelong(null);
				}
				return r_FEUCKR;
			}
		}

		/// <summary>
		/// System.Int32 CodePageASCII
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCodePageASCII;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCodePageASCII
		{
			get
			{
				if(r_FCodePageASCII == null)
				{
					r_FCodePageASCII = new(typeof(System.Text.Encoding), "CodePageASCII");
					r_FCodePageASCII.SetBelong(null);
				}
				return r_FCodePageASCII;
			}
		}

		/// <summary>
		/// System.Int32 ISO_8859_1
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FISO_8859_1;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFISO_8859_1
		{
			get
			{
				if(r_FISO_8859_1 == null)
				{
					r_FISO_8859_1 = new(typeof(System.Text.Encoding), "ISO_8859_1");
					r_FISO_8859_1.SetBelong(null);
				}
				return r_FISO_8859_1;
			}
		}

		/// <summary>
		/// System.Int32 ISCIIAssemese
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FISCIIAssemese;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFISCIIAssemese
		{
			get
			{
				if(r_FISCIIAssemese == null)
				{
					r_FISCIIAssemese = new(typeof(System.Text.Encoding), "ISCIIAssemese");
					r_FISCIIAssemese.SetBelong(null);
				}
				return r_FISCIIAssemese;
			}
		}

		/// <summary>
		/// System.Int32 ISCIIBengali
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FISCIIBengali;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFISCIIBengali
		{
			get
			{
				if(r_FISCIIBengali == null)
				{
					r_FISCIIBengali = new(typeof(System.Text.Encoding), "ISCIIBengali");
					r_FISCIIBengali.SetBelong(null);
				}
				return r_FISCIIBengali;
			}
		}

		/// <summary>
		/// System.Int32 ISCIIDevanagari
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FISCIIDevanagari;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFISCIIDevanagari
		{
			get
			{
				if(r_FISCIIDevanagari == null)
				{
					r_FISCIIDevanagari = new(typeof(System.Text.Encoding), "ISCIIDevanagari");
					r_FISCIIDevanagari.SetBelong(null);
				}
				return r_FISCIIDevanagari;
			}
		}

		/// <summary>
		/// System.Int32 ISCIIGujarathi
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FISCIIGujarathi;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFISCIIGujarathi
		{
			get
			{
				if(r_FISCIIGujarathi == null)
				{
					r_FISCIIGujarathi = new(typeof(System.Text.Encoding), "ISCIIGujarathi");
					r_FISCIIGujarathi.SetBelong(null);
				}
				return r_FISCIIGujarathi;
			}
		}

		/// <summary>
		/// System.Int32 ISCIIKannada
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FISCIIKannada;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFISCIIKannada
		{
			get
			{
				if(r_FISCIIKannada == null)
				{
					r_FISCIIKannada = new(typeof(System.Text.Encoding), "ISCIIKannada");
					r_FISCIIKannada.SetBelong(null);
				}
				return r_FISCIIKannada;
			}
		}

		/// <summary>
		/// System.Int32 ISCIIMalayalam
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FISCIIMalayalam;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFISCIIMalayalam
		{
			get
			{
				if(r_FISCIIMalayalam == null)
				{
					r_FISCIIMalayalam = new(typeof(System.Text.Encoding), "ISCIIMalayalam");
					r_FISCIIMalayalam.SetBelong(null);
				}
				return r_FISCIIMalayalam;
			}
		}

		/// <summary>
		/// System.Int32 ISCIIOriya
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FISCIIOriya;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFISCIIOriya
		{
			get
			{
				if(r_FISCIIOriya == null)
				{
					r_FISCIIOriya = new(typeof(System.Text.Encoding), "ISCIIOriya");
					r_FISCIIOriya.SetBelong(null);
				}
				return r_FISCIIOriya;
			}
		}

		/// <summary>
		/// System.Int32 ISCIIPanjabi
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FISCIIPanjabi;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFISCIIPanjabi
		{
			get
			{
				if(r_FISCIIPanjabi == null)
				{
					r_FISCIIPanjabi = new(typeof(System.Text.Encoding), "ISCIIPanjabi");
					r_FISCIIPanjabi.SetBelong(null);
				}
				return r_FISCIIPanjabi;
			}
		}

		/// <summary>
		/// System.Int32 ISCIITamil
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FISCIITamil;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFISCIITamil
		{
			get
			{
				if(r_FISCIITamil == null)
				{
					r_FISCIITamil = new(typeof(System.Text.Encoding), "ISCIITamil");
					r_FISCIITamil.SetBelong(null);
				}
				return r_FISCIITamil;
			}
		}

		/// <summary>
		/// System.Int32 ISCIITelugu
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FISCIITelugu;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFISCIITelugu
		{
			get
			{
				if(r_FISCIITelugu == null)
				{
					r_FISCIITelugu = new(typeof(System.Text.Encoding), "ISCIITelugu");
					r_FISCIITelugu.SetBelong(null);
				}
				return r_FISCIITelugu;
			}
		}

		/// <summary>
		/// System.Int32 GB18030
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FGB18030;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFGB18030
		{
			get
			{
				if(r_FGB18030 == null)
				{
					r_FGB18030 = new(typeof(System.Text.Encoding), "GB18030");
					r_FGB18030.SetBelong(null);
				}
				return r_FGB18030;
			}
		}

		/// <summary>
		/// System.Int32 ISO_8859_8I
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FISO_8859_8I;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFISO_8859_8I
		{
			get
			{
				if(r_FISO_8859_8I == null)
				{
					r_FISO_8859_8I = new(typeof(System.Text.Encoding), "ISO_8859_8I");
					r_FISO_8859_8I.SetBelong(null);
				}
				return r_FISO_8859_8I;
			}
		}

		/// <summary>
		/// System.Int32 ISO_8859_8_Visual
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FISO_8859_8_Visual;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFISO_8859_8_Visual
		{
			get
			{
				if(r_FISO_8859_8_Visual == null)
				{
					r_FISO_8859_8_Visual = new(typeof(System.Text.Encoding), "ISO_8859_8_Visual");
					r_FISO_8859_8_Visual.SetBelong(null);
				}
				return r_FISO_8859_8_Visual;
			}
		}

		/// <summary>
		/// System.Int32 ENC50229
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FENC50229;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFENC50229
		{
			get
			{
				if(r_FENC50229 == null)
				{
					r_FENC50229 = new(typeof(System.Text.Encoding), "ENC50229");
					r_FENC50229.SetBelong(null);
				}
				return r_FENC50229;
			}
		}

		/// <summary>
		/// System.Int32 CodePageUTF7
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCodePageUTF7;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCodePageUTF7
		{
			get
			{
				if(r_FCodePageUTF7 == null)
				{
					r_FCodePageUTF7 = new(typeof(System.Text.Encoding), "CodePageUTF7");
					r_FCodePageUTF7.SetBelong(null);
				}
				return r_FCodePageUTF7;
			}
		}

		/// <summary>
		/// System.Int32 CodePageUTF8
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCodePageUTF8;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCodePageUTF8
		{
			get
			{
				if(r_FCodePageUTF8 == null)
				{
					r_FCodePageUTF8 = new(typeof(System.Text.Encoding), "CodePageUTF8");
					r_FCodePageUTF8.SetBelong(null);
				}
				return r_FCodePageUTF8;
			}
		}

		/// <summary>
		/// System.Int32 CodePageUTF32
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCodePageUTF32;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCodePageUTF32
		{
			get
			{
				if(r_FCodePageUTF32 == null)
				{
					r_FCodePageUTF32 = new(typeof(System.Text.Encoding), "CodePageUTF32");
					r_FCodePageUTF32.SetBelong(null);
				}
				return r_FCodePageUTF32;
			}
		}

		/// <summary>
		/// System.Int32 CodePageUTF32BE
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCodePageUTF32BE;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCodePageUTF32BE
		{
			get
			{
				if(r_FCodePageUTF32BE == null)
				{
					r_FCodePageUTF32BE = new(typeof(System.Text.Encoding), "CodePageUTF32BE");
					r_FCodePageUTF32BE.SetBelong(null);
				}
				return r_FCodePageUTF32BE;
			}
		}

		/// <summary>
		/// System.Int32 m_codePage
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_codePage;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_codePage
		{
			get
			{
				if(r_Fm_codePage == null)
				{
					r_Fm_codePage = new(this, "m_codePage");
					r_Fm_codePage.SetBelong(this.GetValue());
				}
				return r_Fm_codePage;
			}
		}

		/// <summary>
		/// System.Globalization.CodePageDataItem dataItem
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RCodePageDataItem r_FdataItem;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RCodePageDataItem RFdataItem
		{
			get
			{
				if(r_FdataItem == null)
				{
					r_FdataItem = new(this, "dataItem");
					r_FdataItem.SetBelong(this.GetValue());
				}
				return r_FdataItem;
			}
		}

		/// <summary>
		/// System.Boolean m_deserializedFromEverett
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_deserializedFromEverett;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_deserializedFromEverett
		{
			get
			{
				if(r_Fm_deserializedFromEverett == null)
				{
					r_Fm_deserializedFromEverett = new(this, "m_deserializedFromEverett");
					r_Fm_deserializedFromEverett.SetBelong(this.GetValue());
				}
				return r_Fm_deserializedFromEverett;
			}
		}

		/// <summary>
		/// System.Boolean m_isReadOnly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_isReadOnly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_isReadOnly
		{
			get
			{
				if(r_Fm_isReadOnly == null)
				{
					r_Fm_isReadOnly = new(this, "m_isReadOnly");
					r_Fm_isReadOnly.SetBelong(this.GetValue());
				}
				return r_Fm_isReadOnly;
			}
		}

		/// <summary>
		/// System.Text.EncoderFallback encoderFallback
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.REncoderFallback r_FencoderFallback;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.REncoderFallback RFencoderFallback
		{
			get
			{
				if(r_FencoderFallback == null)
				{
					r_FencoderFallback = new(this, "encoderFallback");
					r_FencoderFallback.SetBelong(this.GetValue());
				}
				return r_FencoderFallback;
			}
		}

		/// <summary>
		/// System.Text.DecoderFallback decoderFallback
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.RDecoderFallback r_FdecoderFallback;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.RDecoderFallback RFdecoderFallback
		{
			get
			{
				if(r_FdecoderFallback == null)
				{
					r_FdecoderFallback = new(this, "decoderFallback");
					r_FdecoderFallback.SetBelong(this.GetValue());
				}
				return r_FdecoderFallback;
			}
		}

		/// <summary>
		/// System.Object s_InternalSyncObject
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RObject r_Fs_InternalSyncObject;
		public static Hvak.Editor.Refleaction.RSystem.RObject RFs_InternalSyncObject
		{
			get
			{
				if(r_Fs_InternalSyncObject == null)
				{
					r_Fs_InternalSyncObject = new(typeof(System.Text.Encoding), "s_InternalSyncObject");
					r_Fs_InternalSyncObject.SetBelong(null);
				}
				return r_Fs_InternalSyncObject;
			}
		}

		/// <summary>
		/// System.Object InternalSyncObject
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RObject r_PInternalSyncObject;
		public static Hvak.Editor.Refleaction.RSystem.RObject RPInternalSyncObject
		{
			get
			{
				if(r_PInternalSyncObject == null)
				{
					r_PInternalSyncObject = new(typeof(System.Text.Encoding), "InternalSyncObject", -1);
					r_PInternalSyncObject.SetBelong(null);
				}
				return r_PInternalSyncObject;
			}
		}

		/// <summary>
		/// System.ReadOnlySpan`1[System.Byte] Preamble
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RByte> r_PPreamble;
		public virtual Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RByte> RPPreamble
		{
			get
			{
				if(r_PPreamble == null)
				{
					r_PPreamble = new(this, "Preamble", -1);
					r_PPreamble.SetBelong(this.GetValue());
				}
				return r_PPreamble;
			}
		}

		/// <summary>
		/// System.String BodyName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PBodyName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPBodyName
		{
			get
			{
				if(r_PBodyName == null)
				{
					r_PBodyName = new(this, "BodyName", -1);
					r_PBodyName.SetBelong(this.GetValue());
				}
				return r_PBodyName;
			}
		}

		/// <summary>
		/// System.String EncodingName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PEncodingName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPEncodingName
		{
			get
			{
				if(r_PEncodingName == null)
				{
					r_PEncodingName = new(this, "EncodingName", -1);
					r_PEncodingName.SetBelong(this.GetValue());
				}
				return r_PEncodingName;
			}
		}

		/// <summary>
		/// System.String HeaderName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PHeaderName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPHeaderName
		{
			get
			{
				if(r_PHeaderName == null)
				{
					r_PHeaderName = new(this, "HeaderName", -1);
					r_PHeaderName.SetBelong(this.GetValue());
				}
				return r_PHeaderName;
			}
		}

		/// <summary>
		/// System.String WebName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PWebName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPWebName
		{
			get
			{
				if(r_PWebName == null)
				{
					r_PWebName = new(this, "WebName", -1);
					r_PWebName.SetBelong(this.GetValue());
				}
				return r_PWebName;
			}
		}

		/// <summary>
		/// Int32 WindowsCodePage
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PWindowsCodePage;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPWindowsCodePage
		{
			get
			{
				if(r_PWindowsCodePage == null)
				{
					r_PWindowsCodePage = new(this, "WindowsCodePage", -1);
					r_PWindowsCodePage.SetBelong(this.GetValue());
				}
				return r_PWindowsCodePage;
			}
		}

		/// <summary>
		/// Boolean IsBrowserDisplay
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsBrowserDisplay;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsBrowserDisplay
		{
			get
			{
				if(r_PIsBrowserDisplay == null)
				{
					r_PIsBrowserDisplay = new(this, "IsBrowserDisplay", -1);
					r_PIsBrowserDisplay.SetBelong(this.GetValue());
				}
				return r_PIsBrowserDisplay;
			}
		}

		/// <summary>
		/// Boolean IsBrowserSave
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsBrowserSave;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsBrowserSave
		{
			get
			{
				if(r_PIsBrowserSave == null)
				{
					r_PIsBrowserSave = new(this, "IsBrowserSave", -1);
					r_PIsBrowserSave.SetBelong(this.GetValue());
				}
				return r_PIsBrowserSave;
			}
		}

		/// <summary>
		/// Boolean IsMailNewsDisplay
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsMailNewsDisplay;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsMailNewsDisplay
		{
			get
			{
				if(r_PIsMailNewsDisplay == null)
				{
					r_PIsMailNewsDisplay = new(this, "IsMailNewsDisplay", -1);
					r_PIsMailNewsDisplay.SetBelong(this.GetValue());
				}
				return r_PIsMailNewsDisplay;
			}
		}

		/// <summary>
		/// Boolean IsMailNewsSave
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsMailNewsSave;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsMailNewsSave
		{
			get
			{
				if(r_PIsMailNewsSave == null)
				{
					r_PIsMailNewsSave = new(this, "IsMailNewsSave", -1);
					r_PIsMailNewsSave.SetBelong(this.GetValue());
				}
				return r_PIsMailNewsSave;
			}
		}

		/// <summary>
		/// Boolean IsSingleByte
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsSingleByte;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsSingleByte
		{
			get
			{
				if(r_PIsSingleByte == null)
				{
					r_PIsSingleByte = new(this, "IsSingleByte", -1);
					r_PIsSingleByte.SetBelong(this.GetValue());
				}
				return r_PIsSingleByte;
			}
		}

		/// <summary>
		/// System.Text.EncoderFallback EncoderFallback
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.REncoderFallback r_PEncoderFallback;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.REncoderFallback RPEncoderFallback
		{
			get
			{
				if(r_PEncoderFallback == null)
				{
					r_PEncoderFallback = new(this, "EncoderFallback", -1);
					r_PEncoderFallback.SetBelong(this.GetValue());
				}
				return r_PEncoderFallback;
			}
		}

		/// <summary>
		/// System.Text.DecoderFallback DecoderFallback
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.RDecoderFallback r_PDecoderFallback;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.RDecoderFallback RPDecoderFallback
		{
			get
			{
				if(r_PDecoderFallback == null)
				{
					r_PDecoderFallback = new(this, "DecoderFallback", -1);
					r_PDecoderFallback.SetBelong(this.GetValue());
				}
				return r_PDecoderFallback;
			}
		}

		/// <summary>
		/// Boolean IsReadOnly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsReadOnly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsReadOnly
		{
			get
			{
				if(r_PIsReadOnly == null)
				{
					r_PIsReadOnly = new(this, "IsReadOnly", -1);
					r_PIsReadOnly.SetBelong(this.GetValue());
				}
				return r_PIsReadOnly;
			}
		}

		/// <summary>
		/// System.Text.Encoding ASCII
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RText.REncoding r_PASCII;
		public static Hvak.Editor.Refleaction.RSystem.RText.REncoding RPASCII
		{
			get
			{
				if(r_PASCII == null)
				{
					r_PASCII = new(typeof(System.Text.Encoding), "ASCII", -1);
					r_PASCII.SetBelong(null);
				}
				return r_PASCII;
			}
		}

		/// <summary>
		/// System.Text.Encoding Latin1
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RText.REncoding r_PLatin1;
		public static Hvak.Editor.Refleaction.RSystem.RText.REncoding RPLatin1
		{
			get
			{
				if(r_PLatin1 == null)
				{
					r_PLatin1 = new(typeof(System.Text.Encoding), "Latin1", -1);
					r_PLatin1.SetBelong(null);
				}
				return r_PLatin1;
			}
		}

		/// <summary>
		/// Int32 CodePage
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PCodePage;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPCodePage
		{
			get
			{
				if(r_PCodePage == null)
				{
					r_PCodePage = new(this, "CodePage", -1);
					r_PCodePage.SetBelong(this.GetValue());
				}
				return r_PCodePage;
			}
		}

		/// <summary>
		/// System.Text.Encoding Default
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RText.REncoding r_PDefault;
		public static Hvak.Editor.Refleaction.RSystem.RText.REncoding RPDefault
		{
			get
			{
				if(r_PDefault == null)
				{
					r_PDefault = new(typeof(System.Text.Encoding), "Default", -1);
					r_PDefault.SetBelong(null);
				}
				return r_PDefault;
			}
		}

		/// <summary>
		/// System.Text.Encoding Unicode
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RText.REncoding r_PUnicode;
		public static Hvak.Editor.Refleaction.RSystem.RText.REncoding RPUnicode
		{
			get
			{
				if(r_PUnicode == null)
				{
					r_PUnicode = new(typeof(System.Text.Encoding), "Unicode", -1);
					r_PUnicode.SetBelong(null);
				}
				return r_PUnicode;
			}
		}

		/// <summary>
		/// System.Text.Encoding BigEndianUnicode
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RText.REncoding r_PBigEndianUnicode;
		public static Hvak.Editor.Refleaction.RSystem.RText.REncoding RPBigEndianUnicode
		{
			get
			{
				if(r_PBigEndianUnicode == null)
				{
					r_PBigEndianUnicode = new(typeof(System.Text.Encoding), "BigEndianUnicode", -1);
					r_PBigEndianUnicode.SetBelong(null);
				}
				return r_PBigEndianUnicode;
			}
		}

		/// <summary>
		/// System.Text.Encoding UTF7
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RText.REncoding r_PUTF7;
		public static Hvak.Editor.Refleaction.RSystem.RText.REncoding RPUTF7
		{
			get
			{
				if(r_PUTF7 == null)
				{
					r_PUTF7 = new(typeof(System.Text.Encoding), "UTF7", -1);
					r_PUTF7.SetBelong(null);
				}
				return r_PUTF7;
			}
		}

		/// <summary>
		/// System.Text.Encoding UTF8
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RText.REncoding r_PUTF8;
		public static Hvak.Editor.Refleaction.RSystem.RText.REncoding RPUTF8
		{
			get
			{
				if(r_PUTF8 == null)
				{
					r_PUTF8 = new(typeof(System.Text.Encoding), "UTF8", -1);
					r_PUTF8.SetBelong(null);
				}
				return r_PUTF8;
			}
		}

		/// <summary>
		/// System.Text.Encoding UTF32
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RText.REncoding r_PUTF32;
		public static Hvak.Editor.Refleaction.RSystem.RText.REncoding RPUTF32
		{
			get
			{
				if(r_PUTF32 == null)
				{
					r_PUTF32 = new(typeof(System.Text.Encoding), "UTF32", -1);
					r_PUTF32.SetBelong(null);
				}
				return r_PUTF32;
			}
		}

		/// <summary>
		/// Void SetDefaultFallbacks()
		/// </summary>
		protected RMethod r_MSetDefaultFallbacks;
		public virtual RMethod RMSetDefaultFallbacks
		{
			get
			{
				if(r_MSetDefaultFallbacks == null)
				{
					r_MSetDefaultFallbacks = new(this, "SetDefaultFallbacks", 0);
					r_MSetDefaultFallbacks.SetBelong(this.GetValue());
				}
				return r_MSetDefaultFallbacks;
			}
		}

		/// <summary>
		/// Void OnDeserializing()
		/// </summary>
		protected RMethod r_MOnDeserializing;
		public virtual RMethod RMOnDeserializing
		{
			get
			{
				if(r_MOnDeserializing == null)
				{
					r_MOnDeserializing = new(this, "OnDeserializing", 0);
					r_MOnDeserializing.SetBelong(this.GetValue());
				}
				return r_MOnDeserializing;
			}
		}

		/// <summary>
		/// Void OnDeserialized()
		/// </summary>
		protected RMethod r_MOnDeserialized;
		public virtual RMethod RMOnDeserialized
		{
			get
			{
				if(r_MOnDeserialized == null)
				{
					r_MOnDeserialized = new(this, "OnDeserialized", 0);
					r_MOnDeserialized.SetBelong(this.GetValue());
				}
				return r_MOnDeserialized;
			}
		}

		/// <summary>
		/// Void OnDeserializing(System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MOnDeserializing_StreamingContext;
		public virtual RMethod RMOnDeserializing_StreamingContext
		{
			get
			{
				if(r_MOnDeserializing_StreamingContext == null)
				{
					r_MOnDeserializing_StreamingContext = new(this, "OnDeserializing", 0, typeof(System.Runtime.Serialization.StreamingContext));
					r_MOnDeserializing_StreamingContext.SetBelong(this.GetValue());
				}
				return r_MOnDeserializing_StreamingContext;
			}
		}

		/// <summary>
		/// Void OnDeserialized(System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MOnDeserialized_StreamingContext;
		public virtual RMethod RMOnDeserialized_StreamingContext
		{
			get
			{
				if(r_MOnDeserialized_StreamingContext == null)
				{
					r_MOnDeserialized_StreamingContext = new(this, "OnDeserialized", 0, typeof(System.Runtime.Serialization.StreamingContext));
					r_MOnDeserialized_StreamingContext.SetBelong(this.GetValue());
				}
				return r_MOnDeserialized_StreamingContext;
			}
		}

		/// <summary>
		/// Void OnSerializing(System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MOnSerializing_StreamingContext;
		public virtual RMethod RMOnSerializing_StreamingContext
		{
			get
			{
				if(r_MOnSerializing_StreamingContext == null)
				{
					r_MOnSerializing_StreamingContext = new(this, "OnSerializing", 0, typeof(System.Runtime.Serialization.StreamingContext));
					r_MOnSerializing_StreamingContext.SetBelong(this.GetValue());
				}
				return r_MOnSerializing_StreamingContext;
			}
		}

		/// <summary>
		/// Void DeserializeEncoding(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MDeserializeEncoding_SerializationInfo_StreamingContext;
		public virtual RMethod RMDeserializeEncoding_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_MDeserializeEncoding_SerializationInfo_StreamingContext == null)
				{
					r_MDeserializeEncoding_SerializationInfo_StreamingContext = new(this, "DeserializeEncoding", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_MDeserializeEncoding_SerializationInfo_StreamingContext.SetBelong(this.GetValue());
				}
				return r_MDeserializeEncoding_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// Void SerializeEncoding(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MSerializeEncoding_SerializationInfo_StreamingContext;
		public virtual RMethod RMSerializeEncoding_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_MSerializeEncoding_SerializationInfo_StreamingContext == null)
				{
					r_MSerializeEncoding_SerializationInfo_StreamingContext = new(this, "SerializeEncoding", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_MSerializeEncoding_SerializationInfo_StreamingContext.SetBelong(this.GetValue());
				}
				return r_MSerializeEncoding_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// Byte[] Convert(System.Text.Encoding, System.Text.Encoding, Byte[])
		/// </summary>
		protected static RMethod r_MConvert_Encoding_Encoding_ByteArray;
		public static RMethod RMConvert_Encoding_Encoding_ByteArray
		{
			get
			{
				if(r_MConvert_Encoding_Encoding_ByteArray == null)
				{
					r_MConvert_Encoding_Encoding_ByteArray = new(typeof(System.Text.Encoding), "Convert", 0, typeof(System.Text.Encoding), typeof(System.Text.Encoding), typeof(System.Byte).MakeArrayType());
					r_MConvert_Encoding_Encoding_ByteArray.SetBelong(null);
				}
				return r_MConvert_Encoding_Encoding_ByteArray;
			}
		}

		/// <summary>
		/// Byte[] Convert(System.Text.Encoding, System.Text.Encoding, Byte[], Int32, Int32)
		/// </summary>
		protected static RMethod r_MConvert_Encoding_Encoding_ByteArray_Int32_Int32;
		public static RMethod RMConvert_Encoding_Encoding_ByteArray_Int32_Int32
		{
			get
			{
				if(r_MConvert_Encoding_Encoding_ByteArray_Int32_Int32 == null)
				{
					r_MConvert_Encoding_Encoding_ByteArray_Int32_Int32 = new(typeof(System.Text.Encoding), "Convert", 0, typeof(System.Text.Encoding), typeof(System.Text.Encoding), typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MConvert_Encoding_Encoding_ByteArray_Int32_Int32.SetBelong(null);
				}
				return r_MConvert_Encoding_Encoding_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void RegisterProvider(System.Text.EncodingProvider)
		/// </summary>
		protected static RMethod r_MRegisterProvider_EncodingProvider;
		public static RMethod RMRegisterProvider_EncodingProvider
		{
			get
			{
				if(r_MRegisterProvider_EncodingProvider == null)
				{
					r_MRegisterProvider_EncodingProvider = new(typeof(System.Text.Encoding), "RegisterProvider", 0, typeof(System.Text.EncodingProvider));
					r_MRegisterProvider_EncodingProvider.SetBelong(null);
				}
				return r_MRegisterProvider_EncodingProvider;
			}
		}

		/// <summary>
		/// System.Text.Encoding GetEncoding(Int32)
		/// </summary>
		protected static RMethod r_MGetEncoding_Int32;
		public static RMethod RMGetEncoding_Int32
		{
			get
			{
				if(r_MGetEncoding_Int32 == null)
				{
					r_MGetEncoding_Int32 = new(typeof(System.Text.Encoding), "GetEncoding", 0, typeof(System.Int32));
					r_MGetEncoding_Int32.SetBelong(null);
				}
				return r_MGetEncoding_Int32;
			}
		}

		/// <summary>
		/// System.Text.Encoding GetEncoding(Int32, System.Text.EncoderFallback, System.Text.DecoderFallback)
		/// </summary>
		protected static RMethod r_MGetEncoding_Int32_EncoderFallback_DecoderFallback;
		public static RMethod RMGetEncoding_Int32_EncoderFallback_DecoderFallback
		{
			get
			{
				if(r_MGetEncoding_Int32_EncoderFallback_DecoderFallback == null)
				{
					r_MGetEncoding_Int32_EncoderFallback_DecoderFallback = new(typeof(System.Text.Encoding), "GetEncoding", 0, typeof(System.Int32), typeof(System.Text.EncoderFallback), typeof(System.Text.DecoderFallback));
					r_MGetEncoding_Int32_EncoderFallback_DecoderFallback.SetBelong(null);
				}
				return r_MGetEncoding_Int32_EncoderFallback_DecoderFallback;
			}
		}

		/// <summary>
		/// System.Text.Encoding GetEncoding(System.String)
		/// </summary>
		protected static RMethod r_MGetEncoding_String;
		public static RMethod RMGetEncoding_String
		{
			get
			{
				if(r_MGetEncoding_String == null)
				{
					r_MGetEncoding_String = new(typeof(System.Text.Encoding), "GetEncoding", 0, typeof(System.String));
					r_MGetEncoding_String.SetBelong(null);
				}
				return r_MGetEncoding_String;
			}
		}

		/// <summary>
		/// System.Text.Encoding GetEncoding(System.String, System.Text.EncoderFallback, System.Text.DecoderFallback)
		/// </summary>
		protected static RMethod r_MGetEncoding_String_EncoderFallback_DecoderFallback;
		public static RMethod RMGetEncoding_String_EncoderFallback_DecoderFallback
		{
			get
			{
				if(r_MGetEncoding_String_EncoderFallback_DecoderFallback == null)
				{
					r_MGetEncoding_String_EncoderFallback_DecoderFallback = new(typeof(System.Text.Encoding), "GetEncoding", 0, typeof(System.String), typeof(System.Text.EncoderFallback), typeof(System.Text.DecoderFallback));
					r_MGetEncoding_String_EncoderFallback_DecoderFallback.SetBelong(null);
				}
				return r_MGetEncoding_String_EncoderFallback_DecoderFallback;
			}
		}

		/// <summary>
		/// System.Text.EncodingInfo[] GetEncodings()
		/// </summary>
		protected static RMethod r_MGetEncodings;
		public static RMethod RMGetEncodings
		{
			get
			{
				if(r_MGetEncodings == null)
				{
					r_MGetEncodings = new(typeof(System.Text.Encoding), "GetEncodings", 0);
					r_MGetEncodings.SetBelong(null);
				}
				return r_MGetEncodings;
			}
		}

		/// <summary>
		/// Byte[] GetPreamble()
		/// </summary>
		protected RMethod r_MGetPreamble;
		public virtual RMethod RMGetPreamble
		{
			get
			{
				if(r_MGetPreamble == null)
				{
					r_MGetPreamble = new(this, "GetPreamble", 0);
					r_MGetPreamble.SetBelong(this.GetValue());
				}
				return r_MGetPreamble;
			}
		}

		/// <summary>
		/// Void GetDataItem()
		/// </summary>
		protected RMethod r_MGetDataItem;
		public virtual RMethod RMGetDataItem
		{
			get
			{
				if(r_MGetDataItem == null)
				{
					r_MGetDataItem = new(this, "GetDataItem", 0);
					r_MGetDataItem.SetBelong(this.GetValue());
				}
				return r_MGetDataItem;
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
					r_MClone.SetBelong(this.GetValue());
				}
				return r_MClone;
			}
		}

		/// <summary>
		/// Int32 GetByteCount(Char[])
		/// </summary>
		protected RMethod r_MGetByteCount_CharArray;
		public virtual RMethod RMGetByteCount_CharArray
		{
			get
			{
				if(r_MGetByteCount_CharArray == null)
				{
					r_MGetByteCount_CharArray = new(this, "GetByteCount", 0, typeof(System.Char).MakeArrayType());
					r_MGetByteCount_CharArray.SetBelong(this.GetValue());
				}
				return r_MGetByteCount_CharArray;
			}
		}

		/// <summary>
		/// Int32 GetByteCount(System.String)
		/// </summary>
		protected RMethod r_MGetByteCount_String;
		public virtual RMethod RMGetByteCount_String
		{
			get
			{
				if(r_MGetByteCount_String == null)
				{
					r_MGetByteCount_String = new(this, "GetByteCount", 0, typeof(System.String));
					r_MGetByteCount_String.SetBelong(this.GetValue());
				}
				return r_MGetByteCount_String;
			}
		}

		/// <summary>
		/// Int32 GetByteCount(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_MGetByteCount_CharArray_Int32_Int32;
		public virtual RMethod RMGetByteCount_CharArray_Int32_Int32
		{
			get
			{
				if(r_MGetByteCount_CharArray_Int32_Int32 == null)
				{
					r_MGetByteCount_CharArray_Int32_Int32 = new(this, "GetByteCount", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MGetByteCount_CharArray_Int32_Int32.SetBelong(this.GetValue());
				}
				return r_MGetByteCount_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetByteCount(System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_MGetByteCount_String_Int32_Int32;
		public virtual RMethod RMGetByteCount_String_Int32_Int32
		{
			get
			{
				if(r_MGetByteCount_String_Int32_Int32 == null)
				{
					r_MGetByteCount_String_Int32_Int32 = new(this, "GetByteCount", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_MGetByteCount_String_Int32_Int32.SetBelong(this.GetValue());
				}
				return r_MGetByteCount_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetByteCount(Char*, Int32)
		/// </summary>
		protected RMethod r_MGetByteCount_CharPointer_Int32;
		public virtual RMethod RMGetByteCount_CharPointer_Int32
		{
			get
			{
				if(r_MGetByteCount_CharPointer_Int32 == null)
				{
					r_MGetByteCount_CharPointer_Int32 = new(this, "GetByteCount", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32));
					r_MGetByteCount_CharPointer_Int32.SetBelong(this.GetValue());
				}
				return r_MGetByteCount_CharPointer_Int32;
			}
		}

		/// <summary>
		/// Int32 GetByteCount(Char*, Int32, System.Text.EncoderNLS)
		/// </summary>
		protected RMethod r_MGetByteCount_CharPointer_Int32_EncoderNLS;
		public virtual RMethod RMGetByteCount_CharPointer_Int32_EncoderNLS
		{
			get
			{
				if(r_MGetByteCount_CharPointer_Int32_EncoderNLS == null)
				{
					r_MGetByteCount_CharPointer_Int32_EncoderNLS = new(this, "GetByteCount", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32),  ReflectionUtils.GetType("System.Text.EncoderNLS"));
					r_MGetByteCount_CharPointer_Int32_EncoderNLS.SetBelong(this.GetValue());
				}
				return r_MGetByteCount_CharPointer_Int32_EncoderNLS;
			}
		}

		/// <summary>
		/// Byte[] GetBytes(Char[])
		/// </summary>
		protected RMethod r_MGetBytes_CharArray;
		public virtual RMethod RMGetBytes_CharArray
		{
			get
			{
				if(r_MGetBytes_CharArray == null)
				{
					r_MGetBytes_CharArray = new(this, "GetBytes", 0, typeof(System.Char).MakeArrayType());
					r_MGetBytes_CharArray.SetBelong(this.GetValue());
				}
				return r_MGetBytes_CharArray;
			}
		}

		/// <summary>
		/// Byte[] GetBytes(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_MGetBytes_CharArray_Int32_Int32;
		public virtual RMethod RMGetBytes_CharArray_Int32_Int32
		{
			get
			{
				if(r_MGetBytes_CharArray_Int32_Int32 == null)
				{
					r_MGetBytes_CharArray_Int32_Int32 = new(this, "GetBytes", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MGetBytes_CharArray_Int32_Int32.SetBelong(this.GetValue());
				}
				return r_MGetBytes_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetBytes(Char[], Int32, Int32, Byte[], Int32)
		/// </summary>
		protected RMethod r_MGetBytes_CharArray_Int32_Int32_ByteArray_Int32;
		public virtual RMethod RMGetBytes_CharArray_Int32_Int32_ByteArray_Int32
		{
			get
			{
				if(r_MGetBytes_CharArray_Int32_Int32_ByteArray_Int32 == null)
				{
					r_MGetBytes_CharArray_Int32_Int32_ByteArray_Int32 = new(this, "GetBytes", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_MGetBytes_CharArray_Int32_Int32_ByteArray_Int32.SetBelong(this.GetValue());
				}
				return r_MGetBytes_CharArray_Int32_Int32_ByteArray_Int32;
			}
		}

		/// <summary>
		/// Byte[] GetBytes(System.String)
		/// </summary>
		protected RMethod r_MGetBytes_String;
		public virtual RMethod RMGetBytes_String
		{
			get
			{
				if(r_MGetBytes_String == null)
				{
					r_MGetBytes_String = new(this, "GetBytes", 0, typeof(System.String));
					r_MGetBytes_String.SetBelong(this.GetValue());
				}
				return r_MGetBytes_String;
			}
		}

		/// <summary>
		/// Int32 GetBytes(System.String, Int32, Int32, Byte[], Int32)
		/// </summary>
		protected RMethod r_MGetBytes_String_Int32_Int32_ByteArray_Int32;
		public virtual RMethod RMGetBytes_String_Int32_Int32_ByteArray_Int32
		{
			get
			{
				if(r_MGetBytes_String_Int32_Int32_ByteArray_Int32 == null)
				{
					r_MGetBytes_String_Int32_Int32_ByteArray_Int32 = new(this, "GetBytes", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_MGetBytes_String_Int32_Int32_ByteArray_Int32.SetBelong(this.GetValue());
				}
				return r_MGetBytes_String_Int32_Int32_ByteArray_Int32;
			}
		}

		/// <summary>
		/// Int32 GetBytes(Char*, Int32, Byte*, Int32, System.Text.EncoderNLS)
		/// </summary>
		protected RMethod r_MGetBytes_CharPointer_Int32_BytePointer_Int32_EncoderNLS;
		public virtual RMethod RMGetBytes_CharPointer_Int32_BytePointer_Int32_EncoderNLS
		{
			get
			{
				if(r_MGetBytes_CharPointer_Int32_BytePointer_Int32_EncoderNLS == null)
				{
					r_MGetBytes_CharPointer_Int32_BytePointer_Int32_EncoderNLS = new(this, "GetBytes", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Byte).MakePointerType(), typeof(System.Int32),  ReflectionUtils.GetType("System.Text.EncoderNLS"));
					r_MGetBytes_CharPointer_Int32_BytePointer_Int32_EncoderNLS.SetBelong(this.GetValue());
				}
				return r_MGetBytes_CharPointer_Int32_BytePointer_Int32_EncoderNLS;
			}
		}

		/// <summary>
		/// Int32 GetBytes(Char*, Int32, Byte*, Int32)
		/// </summary>
		protected RMethod r_MGetBytes_CharPointer_Int32_BytePointer_Int32;
		public virtual RMethod RMGetBytes_CharPointer_Int32_BytePointer_Int32
		{
			get
			{
				if(r_MGetBytes_CharPointer_Int32_BytePointer_Int32 == null)
				{
					r_MGetBytes_CharPointer_Int32_BytePointer_Int32 = new(this, "GetBytes", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_MGetBytes_CharPointer_Int32_BytePointer_Int32.SetBelong(this.GetValue());
				}
				return r_MGetBytes_CharPointer_Int32_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Int32 GetCharCount(Byte[])
		/// </summary>
		protected RMethod r_MGetCharCount_ByteArray;
		public virtual RMethod RMGetCharCount_ByteArray
		{
			get
			{
				if(r_MGetCharCount_ByteArray == null)
				{
					r_MGetCharCount_ByteArray = new(this, "GetCharCount", 0, typeof(System.Byte).MakeArrayType());
					r_MGetCharCount_ByteArray.SetBelong(this.GetValue());
				}
				return r_MGetCharCount_ByteArray;
			}
		}

		/// <summary>
		/// Int32 GetCharCount(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_MGetCharCount_ByteArray_Int32_Int32;
		public virtual RMethod RMGetCharCount_ByteArray_Int32_Int32
		{
			get
			{
				if(r_MGetCharCount_ByteArray_Int32_Int32 == null)
				{
					r_MGetCharCount_ByteArray_Int32_Int32 = new(this, "GetCharCount", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MGetCharCount_ByteArray_Int32_Int32.SetBelong(this.GetValue());
				}
				return r_MGetCharCount_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetCharCount(Byte*, Int32)
		/// </summary>
		protected RMethod r_MGetCharCount_BytePointer_Int32;
		public virtual RMethod RMGetCharCount_BytePointer_Int32
		{
			get
			{
				if(r_MGetCharCount_BytePointer_Int32 == null)
				{
					r_MGetCharCount_BytePointer_Int32 = new(this, "GetCharCount", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_MGetCharCount_BytePointer_Int32.SetBelong(this.GetValue());
				}
				return r_MGetCharCount_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Int32 GetCharCount(Byte*, Int32, System.Text.DecoderNLS)
		/// </summary>
		protected RMethod r_MGetCharCount_BytePointer_Int32_DecoderNLS;
		public virtual RMethod RMGetCharCount_BytePointer_Int32_DecoderNLS
		{
			get
			{
				if(r_MGetCharCount_BytePointer_Int32_DecoderNLS == null)
				{
					r_MGetCharCount_BytePointer_Int32_DecoderNLS = new(this, "GetCharCount", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32),  ReflectionUtils.GetType("System.Text.DecoderNLS"));
					r_MGetCharCount_BytePointer_Int32_DecoderNLS.SetBelong(this.GetValue());
				}
				return r_MGetCharCount_BytePointer_Int32_DecoderNLS;
			}
		}

		/// <summary>
		/// Char[] GetChars(Byte[])
		/// </summary>
		protected RMethod r_MGetChars_ByteArray;
		public virtual RMethod RMGetChars_ByteArray
		{
			get
			{
				if(r_MGetChars_ByteArray == null)
				{
					r_MGetChars_ByteArray = new(this, "GetChars", 0, typeof(System.Byte).MakeArrayType());
					r_MGetChars_ByteArray.SetBelong(this.GetValue());
				}
				return r_MGetChars_ByteArray;
			}
		}

		/// <summary>
		/// Char[] GetChars(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_MGetChars_ByteArray_Int32_Int32;
		public virtual RMethod RMGetChars_ByteArray_Int32_Int32
		{
			get
			{
				if(r_MGetChars_ByteArray_Int32_Int32 == null)
				{
					r_MGetChars_ByteArray_Int32_Int32 = new(this, "GetChars", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MGetChars_ByteArray_Int32_Int32.SetBelong(this.GetValue());
				}
				return r_MGetChars_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetChars(Byte[], Int32, Int32, Char[], Int32)
		/// </summary>
		protected RMethod r_MGetChars_ByteArray_Int32_Int32_CharArray_Int32;
		public virtual RMethod RMGetChars_ByteArray_Int32_Int32_CharArray_Int32
		{
			get
			{
				if(r_MGetChars_ByteArray_Int32_Int32_CharArray_Int32 == null)
				{
					r_MGetChars_ByteArray_Int32_Int32_CharArray_Int32 = new(this, "GetChars", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Char).MakeArrayType(), typeof(System.Int32));
					r_MGetChars_ByteArray_Int32_Int32_CharArray_Int32.SetBelong(this.GetValue());
				}
				return r_MGetChars_ByteArray_Int32_Int32_CharArray_Int32;
			}
		}

		/// <summary>
		/// Int32 GetChars(Byte*, Int32, Char*, Int32)
		/// </summary>
		protected RMethod r_MGetChars_BytePointer_Int32_CharPointer_Int32;
		public virtual RMethod RMGetChars_BytePointer_Int32_CharPointer_Int32
		{
			get
			{
				if(r_MGetChars_BytePointer_Int32_CharPointer_Int32 == null)
				{
					r_MGetChars_BytePointer_Int32_CharPointer_Int32 = new(this, "GetChars", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32), typeof(System.Char).MakePointerType(), typeof(System.Int32));
					r_MGetChars_BytePointer_Int32_CharPointer_Int32.SetBelong(this.GetValue());
				}
				return r_MGetChars_BytePointer_Int32_CharPointer_Int32;
			}
		}

		/// <summary>
		/// Int32 GetChars(Byte*, Int32, Char*, Int32, System.Text.DecoderNLS)
		/// </summary>
		protected RMethod r_MGetChars_BytePointer_Int32_CharPointer_Int32_DecoderNLS;
		public virtual RMethod RMGetChars_BytePointer_Int32_CharPointer_Int32_DecoderNLS
		{
			get
			{
				if(r_MGetChars_BytePointer_Int32_CharPointer_Int32_DecoderNLS == null)
				{
					r_MGetChars_BytePointer_Int32_CharPointer_Int32_DecoderNLS = new(this, "GetChars", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32), typeof(System.Char).MakePointerType(), typeof(System.Int32),  ReflectionUtils.GetType("System.Text.DecoderNLS"));
					r_MGetChars_BytePointer_Int32_CharPointer_Int32_DecoderNLS.SetBelong(this.GetValue());
				}
				return r_MGetChars_BytePointer_Int32_CharPointer_Int32_DecoderNLS;
			}
		}

		/// <summary>
		/// System.String GetString(Byte*, Int32)
		/// </summary>
		protected RMethod r_MGetString_BytePointer_Int32;
		public virtual RMethod RMGetString_BytePointer_Int32
		{
			get
			{
				if(r_MGetString_BytePointer_Int32 == null)
				{
					r_MGetString_BytePointer_Int32 = new(this, "GetString", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_MGetString_BytePointer_Int32.SetBelong(this.GetValue());
				}
				return r_MGetString_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Int32 GetChars(System.ReadOnlySpan`1[System.Byte], System.Span`1[System.Char])
		/// </summary>
		protected RMethod r_MGetChars_ReadOnlySpan_d_Byte_p__Span_d_Char_p_;
		public virtual RMethod RMGetChars_ReadOnlySpan_d_Byte_p__Span_d_Char_p_
		{
			get
			{
				if(r_MGetChars_ReadOnlySpan_d_Byte_p__Span_d_Char_p_ == null)
				{
					r_MGetChars_ReadOnlySpan_d_Byte_p__Span_d_Char_p_ = new(this, "GetChars", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Span<>).MakeGenericType(typeof(System.Char)));
					r_MGetChars_ReadOnlySpan_d_Byte_p__Span_d_Char_p_.SetBelong(this.GetValue());
				}
				return r_MGetChars_ReadOnlySpan_d_Byte_p__Span_d_Char_p_;
			}
		}

		/// <summary>
		/// System.String GetString(System.ReadOnlySpan`1[System.Byte])
		/// </summary>
		protected RMethod r_MGetString_ReadOnlySpan_d_Byte_p_;
		public virtual RMethod RMGetString_ReadOnlySpan_d_Byte_p_
		{
			get
			{
				if(r_MGetString_ReadOnlySpan_d_Byte_p_ == null)
				{
					r_MGetString_ReadOnlySpan_d_Byte_p_ = new(this, "GetString", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)));
					r_MGetString_ReadOnlySpan_d_Byte_p_.SetBelong(this.GetValue());
				}
				return r_MGetString_ReadOnlySpan_d_Byte_p_;
			}
		}

		/// <summary>
		/// Boolean IsAlwaysNormalized()
		/// </summary>
		protected RMethod r_MIsAlwaysNormalized;
		public virtual RMethod RMIsAlwaysNormalized
		{
			get
			{
				if(r_MIsAlwaysNormalized == null)
				{
					r_MIsAlwaysNormalized = new(this, "IsAlwaysNormalized", 0);
					r_MIsAlwaysNormalized.SetBelong(this.GetValue());
				}
				return r_MIsAlwaysNormalized;
			}
		}

		/// <summary>
		/// Boolean IsAlwaysNormalized(System.Text.NormalizationForm)
		/// </summary>
		protected RMethod r_MIsAlwaysNormalized_NormalizationForm;
		public virtual RMethod RMIsAlwaysNormalized_NormalizationForm
		{
			get
			{
				if(r_MIsAlwaysNormalized_NormalizationForm == null)
				{
					r_MIsAlwaysNormalized_NormalizationForm = new(this, "IsAlwaysNormalized", 0, typeof(System.Text.NormalizationForm));
					r_MIsAlwaysNormalized_NormalizationForm.SetBelong(this.GetValue());
				}
				return r_MIsAlwaysNormalized_NormalizationForm;
			}
		}

		/// <summary>
		/// System.Text.Decoder GetDecoder()
		/// </summary>
		protected RMethod r_MGetDecoder;
		public virtual RMethod RMGetDecoder
		{
			get
			{
				if(r_MGetDecoder == null)
				{
					r_MGetDecoder = new(this, "GetDecoder", 0);
					r_MGetDecoder.SetBelong(this.GetValue());
				}
				return r_MGetDecoder;
			}
		}

		/// <summary>
		/// System.Text.Encoding CreateDefaultEncoding()
		/// </summary>
		protected static RMethod r_MCreateDefaultEncoding;
		public static RMethod RMCreateDefaultEncoding
		{
			get
			{
				if(r_MCreateDefaultEncoding == null)
				{
					r_MCreateDefaultEncoding = new(typeof(System.Text.Encoding), "CreateDefaultEncoding", 0);
					r_MCreateDefaultEncoding.SetBelong(null);
				}
				return r_MCreateDefaultEncoding;
			}
		}

		/// <summary>
		/// Void setReadOnly(Boolean)
		/// </summary>
		protected RMethod r_MsetReadOnly_Boolean;
		public virtual RMethod RMsetReadOnly_Boolean
		{
			get
			{
				if(r_MsetReadOnly_Boolean == null)
				{
					r_MsetReadOnly_Boolean = new(this, "setReadOnly", 0, typeof(System.Boolean));
					r_MsetReadOnly_Boolean.SetBelong(this.GetValue());
				}
				return r_MsetReadOnly_Boolean;
			}
		}

		/// <summary>
		/// System.Text.Encoder GetEncoder()
		/// </summary>
		protected RMethod r_MGetEncoder;
		public virtual RMethod RMGetEncoder
		{
			get
			{
				if(r_MGetEncoder == null)
				{
					r_MGetEncoder = new(this, "GetEncoder", 0);
					r_MGetEncoder.SetBelong(this.GetValue());
				}
				return r_MGetEncoder;
			}
		}

		/// <summary>
		/// Int32 GetMaxByteCount(Int32)
		/// </summary>
		protected RMethod r_MGetMaxByteCount_Int32;
		public virtual RMethod RMGetMaxByteCount_Int32
		{
			get
			{
				if(r_MGetMaxByteCount_Int32 == null)
				{
					r_MGetMaxByteCount_Int32 = new(this, "GetMaxByteCount", 0, typeof(System.Int32));
					r_MGetMaxByteCount_Int32.SetBelong(this.GetValue());
				}
				return r_MGetMaxByteCount_Int32;
			}
		}

		/// <summary>
		/// Int32 GetMaxCharCount(Int32)
		/// </summary>
		protected RMethod r_MGetMaxCharCount_Int32;
		public virtual RMethod RMGetMaxCharCount_Int32
		{
			get
			{
				if(r_MGetMaxCharCount_Int32 == null)
				{
					r_MGetMaxCharCount_Int32 = new(this, "GetMaxCharCount", 0, typeof(System.Int32));
					r_MGetMaxCharCount_Int32.SetBelong(this.GetValue());
				}
				return r_MGetMaxCharCount_Int32;
			}
		}

		/// <summary>
		/// System.String GetString(Byte[])
		/// </summary>
		protected RMethod r_MGetString_ByteArray;
		public virtual RMethod RMGetString_ByteArray
		{
			get
			{
				if(r_MGetString_ByteArray == null)
				{
					r_MGetString_ByteArray = new(this, "GetString", 0, typeof(System.Byte).MakeArrayType());
					r_MGetString_ByteArray.SetBelong(this.GetValue());
				}
				return r_MGetString_ByteArray;
			}
		}

		/// <summary>
		/// System.String GetString(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_MGetString_ByteArray_Int32_Int32;
		public virtual RMethod RMGetString_ByteArray_Int32_Int32
		{
			get
			{
				if(r_MGetString_ByteArray_Int32_Int32 == null)
				{
					r_MGetString_ByteArray_Int32_Int32 = new(this, "GetString", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MGetString_ByteArray_Int32_Int32.SetBelong(this.GetValue());
				}
				return r_MGetString_ByteArray_Int32_Int32;
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
		/// Char[] GetBestFitUnicodeToBytesData()
		/// </summary>
		protected RMethod r_MGetBestFitUnicodeToBytesData;
		public virtual RMethod RMGetBestFitUnicodeToBytesData
		{
			get
			{
				if(r_MGetBestFitUnicodeToBytesData == null)
				{
					r_MGetBestFitUnicodeToBytesData = new(this, "GetBestFitUnicodeToBytesData", 0);
					r_MGetBestFitUnicodeToBytesData.SetBelong(this.GetValue());
				}
				return r_MGetBestFitUnicodeToBytesData;
			}
		}

		/// <summary>
		/// Char[] GetBestFitBytesToUnicodeData()
		/// </summary>
		protected RMethod r_MGetBestFitBytesToUnicodeData;
		public virtual RMethod RMGetBestFitBytesToUnicodeData
		{
			get
			{
				if(r_MGetBestFitBytesToUnicodeData == null)
				{
					r_MGetBestFitBytesToUnicodeData = new(this, "GetBestFitBytesToUnicodeData", 0);
					r_MGetBestFitBytesToUnicodeData.SetBelong(this.GetValue());
				}
				return r_MGetBestFitBytesToUnicodeData;
			}
		}

		/// <summary>
		/// Void ThrowBytesOverflow()
		/// </summary>
		protected RMethod r_MThrowBytesOverflow;
		public virtual RMethod RMThrowBytesOverflow
		{
			get
			{
				if(r_MThrowBytesOverflow == null)
				{
					r_MThrowBytesOverflow = new(this, "ThrowBytesOverflow", 0);
					r_MThrowBytesOverflow.SetBelong(this.GetValue());
				}
				return r_MThrowBytesOverflow;
			}
		}

		/// <summary>
		/// Void ThrowBytesOverflow(System.Text.EncoderNLS, Boolean)
		/// </summary>
		protected RMethod r_MThrowBytesOverflow_EncoderNLS_Boolean;
		public virtual RMethod RMThrowBytesOverflow_EncoderNLS_Boolean
		{
			get
			{
				if(r_MThrowBytesOverflow_EncoderNLS_Boolean == null)
				{
					r_MThrowBytesOverflow_EncoderNLS_Boolean = new(this, "ThrowBytesOverflow", 0,  ReflectionUtils.GetType("System.Text.EncoderNLS"), typeof(System.Boolean));
					r_MThrowBytesOverflow_EncoderNLS_Boolean.SetBelong(this.GetValue());
				}
				return r_MThrowBytesOverflow_EncoderNLS_Boolean;
			}
		}

		/// <summary>
		/// Void ThrowCharsOverflow()
		/// </summary>
		protected RMethod r_MThrowCharsOverflow;
		public virtual RMethod RMThrowCharsOverflow
		{
			get
			{
				if(r_MThrowCharsOverflow == null)
				{
					r_MThrowCharsOverflow = new(this, "ThrowCharsOverflow", 0);
					r_MThrowCharsOverflow.SetBelong(this.GetValue());
				}
				return r_MThrowCharsOverflow;
			}
		}

		/// <summary>
		/// Void ThrowCharsOverflow(System.Text.DecoderNLS, Boolean)
		/// </summary>
		protected RMethod r_MThrowCharsOverflow_DecoderNLS_Boolean;
		public virtual RMethod RMThrowCharsOverflow_DecoderNLS_Boolean
		{
			get
			{
				if(r_MThrowCharsOverflow_DecoderNLS_Boolean == null)
				{
					r_MThrowCharsOverflow_DecoderNLS_Boolean = new(this, "ThrowCharsOverflow", 0,  ReflectionUtils.GetType("System.Text.DecoderNLS"), typeof(System.Boolean));
					r_MThrowCharsOverflow_DecoderNLS_Boolean.SetBelong(this.GetValue());
				}
				return r_MThrowCharsOverflow_DecoderNLS_Boolean;
			}
		}

		/// <summary>
		/// Int32 GetCharCount(System.ReadOnlySpan`1[System.Byte])
		/// </summary>
		protected RMethod r_MGetCharCount_ReadOnlySpan_d_Byte_p_;
		public virtual RMethod RMGetCharCount_ReadOnlySpan_d_Byte_p_
		{
			get
			{
				if(r_MGetCharCount_ReadOnlySpan_d_Byte_p_ == null)
				{
					r_MGetCharCount_ReadOnlySpan_d_Byte_p_ = new(this, "GetCharCount", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)));
					r_MGetCharCount_ReadOnlySpan_d_Byte_p_.SetBelong(this.GetValue());
				}
				return r_MGetCharCount_ReadOnlySpan_d_Byte_p_;
			}
		}

		/// <summary>
		/// Int32 GetByteCount(System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected RMethod r_MGetByteCount_ReadOnlySpan_d_Char_p_;
		public virtual RMethod RMGetByteCount_ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_MGetByteCount_ReadOnlySpan_d_Char_p_ == null)
				{
					r_MGetByteCount_ReadOnlySpan_d_Char_p_ = new(this, "GetByteCount", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_MGetByteCount_ReadOnlySpan_d_Char_p_.SetBelong(this.GetValue());
				}
				return r_MGetByteCount_ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// Int32 GetBytes(System.ReadOnlySpan`1[System.Char], System.Span`1[System.Byte])
		/// </summary>
		protected RMethod r_MGetBytes_ReadOnlySpan_d_Char_p__Span_d_Byte_p_;
		public virtual RMethod RMGetBytes_ReadOnlySpan_d_Char_p__Span_d_Byte_p_
		{
			get
			{
				if(r_MGetBytes_ReadOnlySpan_d_Char_p__Span_d_Byte_p_ == null)
				{
					r_MGetBytes_ReadOnlySpan_d_Char_p__Span_d_Byte_p_ = new(this, "GetBytes", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Span<>).MakeGenericType(typeof(System.Byte)));
					r_MGetBytes_ReadOnlySpan_d_Char_p__Span_d_Byte_p_.SetBelong(this.GetValue());
				}
				return r_MGetBytes_ReadOnlySpan_d_Char_p__Span_d_Byte_p_;
			}
		}

		/// <summary>
		/// Byte[] GetBytes(System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_MGetBytes_String_Int32_Int32;
		public virtual RMethod RMGetBytes_String_Int32_Int32
		{
			get
			{
				if(r_MGetBytes_String_Int32_Int32 == null)
				{
					r_MGetBytes_String_Int32_Int32 = new(this, "GetBytes", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_MGetBytes_String_Int32_Int32.SetBelong(this.GetValue());
				}
				return r_MGetBytes_String_Int32_Int32;
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
            var ___result = RMSetDefaultFallbacks.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDeserializing()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnDeserializing.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDeserialized()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnDeserialized.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDeserializing(System.Runtime.Serialization.StreamingContext @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx};
            var ___result = RMOnDeserializing_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDeserialized(System.Runtime.Serialization.StreamingContext @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx};
            var ___result = RMOnDeserialized_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnSerializing(System.Runtime.Serialization.StreamingContext @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx};
            var ___result = RMOnSerializing_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DeserializeEncoding(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMDeserializeEncoding_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SerializeEncoding(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMSerializeEncoding_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Byte[] Convert(System.Text.Encoding @srcEncoding, System.Text.Encoding @dstEncoding, System.Byte[] @bytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@srcEncoding, @dstEncoding, @bytes};
            var ___result = RMConvert_Encoding_Encoding_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public static System.Byte[] Convert(System.Text.Encoding @srcEncoding, System.Text.Encoding @dstEncoding, System.Byte[] @bytes, System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@srcEncoding, @dstEncoding, @bytes, @index, @count};
            var ___result = RMConvert_Encoding_Encoding_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public static void RegisterProvider(System.Text.EncodingProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMRegisterProvider_EncodingProvider.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Text.Encoding GetEncoding(System.Int32 @codepage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@codepage};
            var ___result = RMGetEncoding_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoding)___result;
        }


        public static System.Text.Encoding GetEncoding(System.Int32 @codepage, System.Text.EncoderFallback @encoderFallback, System.Text.DecoderFallback @decoderFallback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@codepage, @encoderFallback, @decoderFallback};
            var ___result = RMGetEncoding_Int32_EncoderFallback_DecoderFallback.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoding)___result;
        }


        public static System.Text.Encoding GetEncoding(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetEncoding_String.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoding)___result;
        }


        public static System.Text.Encoding GetEncoding(System.String @name, System.Text.EncoderFallback @encoderFallback, System.Text.DecoderFallback @decoderFallback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @encoderFallback, @decoderFallback};
            var ___result = RMGetEncoding_String_EncoderFallback_DecoderFallback.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoding)___result;
        }


        public static System.Text.EncodingInfo[] GetEncodings()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEncodings.Invoke(___genericsType, ___parameters);

            return (System.Text.EncodingInfo[])___result;
        }


        public virtual System.Byte[] GetPreamble()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPreamble.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual void GetDataItem()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDataItem.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Int32 GetByteCount(System.Char[] @chars)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars};
            var ___result = RMGetByteCount_CharArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetByteCount(System.String @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RMGetByteCount_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetByteCount(System.Char[] @chars, System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars, @index, @count};
            var ___result = RMGetByteCount_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetByteCount(System.String @str, System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str, @index, @count};
            var ___result = RMGetByteCount_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe virtual System.Int32 GetByteCount(System.Char* @chars, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@chars, typeof(System.Char)), @count};
            var ___result = RMGetByteCount_CharPointer_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe virtual System.Int32 GetByteCount(System.Char* @chars, System.Int32 @count, Hvak.Editor.Refleaction.RSystem.RText.REncoderNLS @encoder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@chars, typeof(System.Char)), @count, @encoder.Value};
            var ___result = RMGetByteCount_CharPointer_Int32_EncoderNLS.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Byte[] GetBytes(System.Char[] @chars)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars};
            var ___result = RMGetBytes_CharArray.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] GetBytes(System.Char[] @chars, System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars, @index, @count};
            var ___result = RMGetBytes_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Int32 GetBytes(System.Char[] @chars, System.Int32 @charIndex, System.Int32 @charCount, System.Byte[] @bytes, System.Int32 @byteIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars, @charIndex, @charCount, @bytes, @byteIndex};
            var ___result = RMGetBytes_CharArray_Int32_Int32_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Byte[] GetBytes(System.String @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RMGetBytes_String.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Int32 GetBytes(System.String @s, System.Int32 @charIndex, System.Int32 @charCount, System.Byte[] @bytes, System.Int32 @byteIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @charIndex, @charCount, @bytes, @byteIndex};
            var ___result = RMGetBytes_String_Int32_Int32_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe virtual System.Int32 GetBytes(System.Char* @chars, System.Int32 @charCount, System.Byte* @bytes, System.Int32 @byteCount, Hvak.Editor.Refleaction.RSystem.RText.REncoderNLS @encoder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@chars, typeof(System.Char)), @charCount, Pointer.Box(@bytes, typeof(System.Byte)), @byteCount, @encoder.Value};
            var ___result = RMGetBytes_CharPointer_Int32_BytePointer_Int32_EncoderNLS.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe virtual System.Int32 GetBytes(System.Char* @chars, System.Int32 @charCount, System.Byte* @bytes, System.Int32 @byteCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@chars, typeof(System.Char)), @charCount, Pointer.Box(@bytes, typeof(System.Byte)), @byteCount};
            var ___result = RMGetBytes_CharPointer_Int32_BytePointer_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetCharCount(System.Byte[] @bytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes};
            var ___result = RMGetCharCount_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetCharCount(System.Byte[] @bytes, System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes, @index, @count};
            var ___result = RMGetCharCount_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe virtual System.Int32 GetCharCount(System.Byte* @bytes, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@bytes, typeof(System.Byte)), @count};
            var ___result = RMGetCharCount_BytePointer_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe virtual System.Int32 GetCharCount(System.Byte* @bytes, System.Int32 @count, Hvak.Editor.Refleaction.RSystem.RText.RDecoderNLS @decoder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@bytes, typeof(System.Byte)), @count, @decoder.Value};
            var ___result = RMGetCharCount_BytePointer_Int32_DecoderNLS.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Char[] GetChars(System.Byte[] @bytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes};
            var ___result = RMGetChars_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Char[])___result;
        }


        public virtual System.Char[] GetChars(System.Byte[] @bytes, System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes, @index, @count};
            var ___result = RMGetChars_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Char[])___result;
        }


        public virtual System.Int32 GetChars(System.Byte[] @bytes, System.Int32 @byteIndex, System.Int32 @byteCount, System.Char[] @chars, System.Int32 @charIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes, @byteIndex, @byteCount, @chars, @charIndex};
            var ___result = RMGetChars_ByteArray_Int32_Int32_CharArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe virtual System.Int32 GetChars(System.Byte* @bytes, System.Int32 @byteCount, System.Char* @chars, System.Int32 @charCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@bytes, typeof(System.Byte)), @byteCount, Pointer.Box(@chars, typeof(System.Char)), @charCount};
            var ___result = RMGetChars_BytePointer_Int32_CharPointer_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe virtual System.Int32 GetChars(System.Byte* @bytes, System.Int32 @byteCount, System.Char* @chars, System.Int32 @charCount, Hvak.Editor.Refleaction.RSystem.RText.RDecoderNLS @decoder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@bytes, typeof(System.Byte)), @byteCount, Pointer.Box(@chars, typeof(System.Char)), @charCount, @decoder.Value};
            var ___result = RMGetChars_BytePointer_Int32_CharPointer_Int32_DecoderNLS.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe virtual System.String GetString(System.Byte* @bytes, System.Int32 @byteCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@bytes, typeof(System.Byte)), @byteCount};
            var ___result = RMGetString_BytePointer_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 GetChars(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RByte> @bytes, Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RSystem.RChar> @chars)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes.Value, @chars.Value};
            var ___result = RMGetChars_ReadOnlySpan_d_Byte_p__Span_d_Char_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String GetString(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RByte> @bytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes.Value};
            var ___result = RMGetString_ReadOnlySpan_d_Byte_p_.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean IsAlwaysNormalized()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsAlwaysNormalized.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsAlwaysNormalized(System.Text.NormalizationForm @form)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@form};
            var ___result = RMIsAlwaysNormalized_NormalizationForm.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Text.Decoder GetDecoder()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDecoder.Invoke(___genericsType, ___parameters);

            return (System.Text.Decoder)___result;
        }


        public static System.Text.Encoding CreateDefaultEncoding()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateDefaultEncoding.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoding)___result;
        }


        public virtual void setReadOnly(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMsetReadOnly_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Text.Encoder GetEncoder()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEncoder.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoder)___result;
        }


        public virtual System.Int32 GetMaxByteCount(System.Int32 @charCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@charCount};
            var ___result = RMGetMaxByteCount_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetMaxCharCount(System.Int32 @byteCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@byteCount};
            var ___result = RMGetMaxCharCount_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String GetString(System.Byte[] @bytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes};
            var ___result = RMGetString_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetString(System.Byte[] @bytes, System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes, @index, @count};
            var ___result = RMGetString_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean Equals(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Char[] GetBestFitUnicodeToBytesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetBestFitUnicodeToBytesData.Invoke(___genericsType, ___parameters);

            return (System.Char[])___result;
        }


        public virtual System.Char[] GetBestFitBytesToUnicodeData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetBestFitBytesToUnicodeData.Invoke(___genericsType, ___parameters);

            return (System.Char[])___result;
        }


        public virtual void ThrowBytesOverflow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMThrowBytesOverflow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ThrowBytesOverflow(Hvak.Editor.Refleaction.RSystem.RText.REncoderNLS @encoder, System.Boolean @nothingEncoded)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@encoder.Value, @nothingEncoded};
            var ___result = RMThrowBytesOverflow_EncoderNLS_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ThrowCharsOverflow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMThrowCharsOverflow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ThrowCharsOverflow(Hvak.Editor.Refleaction.RSystem.RText.RDecoderNLS @decoder, System.Boolean @nothingDecoded)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@decoder.Value, @nothingDecoded};
            var ___result = RMThrowCharsOverflow_DecoderNLS_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetCharCount(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RByte> @bytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes.Value};
            var ___result = RMGetCharCount_ReadOnlySpan_d_Byte_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetByteCount(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @chars)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars.Value};
            var ___result = RMGetByteCount_ReadOnlySpan_d_Char_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetBytes(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @chars, Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RSystem.RByte> @bytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars.Value, @bytes.Value};
            var ___result = RMGetBytes_ReadOnlySpan_d_Char_p__Span_d_Byte_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Byte[] GetBytes(System.String @s, System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index, @count};
            var ___result = RMGetBytes_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
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
