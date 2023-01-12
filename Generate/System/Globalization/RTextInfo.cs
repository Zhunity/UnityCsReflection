using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RGlobalization
{
	/// <summary>
	/// System.Globalization.TextInfo
	/// </summary>
    public partial class RTextInfo : RMember //
    {

		/// <summary>
		/// System.String m_listSeparator
		/// </summary>
		protected RSystem.RString r_Fm_listSeparator;
		public virtual RSystem.RString RFm_listSeparator
		{
			get
			{
				if(r_Fm_listSeparator == null)
				{
					r_Fm_listSeparator = new(this, "m_listSeparator");
					r_Fm_listSeparator.SetBelong(this.instance);
				}
				return r_Fm_listSeparator;
			}
		}

		/// <summary>
		/// System.Boolean m_isReadOnly
		/// </summary>
		protected RSystem.RBoolean r_Fm_isReadOnly;
		public virtual RSystem.RBoolean RFm_isReadOnly
		{
			get
			{
				if(r_Fm_isReadOnly == null)
				{
					r_Fm_isReadOnly = new(this, "m_isReadOnly");
					r_Fm_isReadOnly.SetBelong(this.instance);
				}
				return r_Fm_isReadOnly;
			}
		}

		/// <summary>
		/// System.String m_cultureName
		/// </summary>
		protected RSystem.RString r_Fm_cultureName;
		public virtual RSystem.RString RFm_cultureName
		{
			get
			{
				if(r_Fm_cultureName == null)
				{
					r_Fm_cultureName = new(this, "m_cultureName");
					r_Fm_cultureName.SetBelong(this.instance);
				}
				return r_Fm_cultureName;
			}
		}

		/// <summary>
		/// System.Globalization.CultureData m_cultureData
		/// </summary>
		protected RSystem.RGlobalization.RCultureData r_Fm_cultureData;
		public virtual RSystem.RGlobalization.RCultureData RFm_cultureData
		{
			get
			{
				if(r_Fm_cultureData == null)
				{
					r_Fm_cultureData = new(this, "m_cultureData");
					r_Fm_cultureData.SetBelong(this.instance);
				}
				return r_Fm_cultureData;
			}
		}

		/// <summary>
		/// System.String m_textInfoName
		/// </summary>
		protected RSystem.RString r_Fm_textInfoName;
		public virtual RSystem.RString RFm_textInfoName
		{
			get
			{
				if(r_Fm_textInfoName == null)
				{
					r_Fm_textInfoName = new(this, "m_textInfoName");
					r_Fm_textInfoName.SetBelong(this.instance);
				}
				return r_Fm_textInfoName;
			}
		}

		/// <summary>
		/// System.Nullable`1[System.Boolean] m_IsAsciiCasingSameAsInvariant
		/// </summary>
		protected RSystem.RNullable<RSystem.RBoolean> r_Fm_IsAsciiCasingSameAsInvariant;
		public virtual RSystem.RNullable<RSystem.RBoolean> RFm_IsAsciiCasingSameAsInvariant
		{
			get
			{
				if(r_Fm_IsAsciiCasingSameAsInvariant == null)
				{
					r_Fm_IsAsciiCasingSameAsInvariant = new(this, "m_IsAsciiCasingSameAsInvariant");
					r_Fm_IsAsciiCasingSameAsInvariant.SetBelong(this.instance);
				}
				return r_Fm_IsAsciiCasingSameAsInvariant;
			}
		}

		/// <summary>
		/// System.Globalization.TextInfo s_Invariant
		/// </summary>
		protected static RSystem.RGlobalization.RTextInfo r_Fs_Invariant;
		public static RSystem.RGlobalization.RTextInfo RFs_Invariant
		{
			get
			{
				if(r_Fs_Invariant == null)
				{
					r_Fs_Invariant = new(typeof(System.Globalization.TextInfo), "s_Invariant");
					r_Fs_Invariant.SetBelong(null);
				}
				return r_Fs_Invariant;
			}
		}

		/// <summary>
		/// System.String customCultureName
		/// </summary>
		protected RSystem.RString r_FcustomCultureName;
		public virtual RSystem.RString RFcustomCultureName
		{
			get
			{
				if(r_FcustomCultureName == null)
				{
					r_FcustomCultureName = new(this, "customCultureName");
					r_FcustomCultureName.SetBelong(this.instance);
				}
				return r_FcustomCultureName;
			}
		}

		/// <summary>
		/// System.Int32 m_nDataItem
		/// </summary>
		protected RSystem.RInt32 r_Fm_nDataItem;
		public virtual RSystem.RInt32 RFm_nDataItem
		{
			get
			{
				if(r_Fm_nDataItem == null)
				{
					r_Fm_nDataItem = new(this, "m_nDataItem");
					r_Fm_nDataItem.SetBelong(this.instance);
				}
				return r_Fm_nDataItem;
			}
		}

		/// <summary>
		/// System.Boolean m_useUserOverride
		/// </summary>
		protected RSystem.RBoolean r_Fm_useUserOverride;
		public virtual RSystem.RBoolean RFm_useUserOverride
		{
			get
			{
				if(r_Fm_useUserOverride == null)
				{
					r_Fm_useUserOverride = new(this, "m_useUserOverride");
					r_Fm_useUserOverride.SetBelong(this.instance);
				}
				return r_Fm_useUserOverride;
			}
		}

		/// <summary>
		/// System.Int32 m_win32LangID
		/// </summary>
		protected RSystem.RInt32 r_Fm_win32LangID;
		public virtual RSystem.RInt32 RFm_win32LangID
		{
			get
			{
				if(r_Fm_win32LangID == null)
				{
					r_Fm_win32LangID = new(this, "m_win32LangID");
					r_Fm_win32LangID.SetBelong(this.instance);
				}
				return r_Fm_win32LangID;
			}
		}

		/// <summary>
		/// System.Int32 wordSeparatorMask
		/// </summary>
		protected static RSystem.RInt32 r_FwordSeparatorMask;
		public static RSystem.RInt32 RFwordSeparatorMask
		{
			get
			{
				if(r_FwordSeparatorMask == null)
				{
					r_FwordSeparatorMask = new(typeof(System.Globalization.TextInfo), "wordSeparatorMask");
					r_FwordSeparatorMask.SetBelong(null);
				}
				return r_FwordSeparatorMask;
			}
		}

		/// <summary>
		/// System.Globalization.TextInfo Invariant
		/// </summary>
		protected static RSystem.RGlobalization.RTextInfo r_PInvariant;
		public static RSystem.RGlobalization.RTextInfo RPInvariant
		{
			get
			{
				if(r_PInvariant == null)
				{
					r_PInvariant = new(typeof(System.Globalization.TextInfo), "Invariant", -1);
					r_PInvariant.SetBelong(null);
				}
				return r_PInvariant;
			}
		}

		/// <summary>
		/// Int32 ANSICodePage
		/// </summary>
		protected RSystem.RInt32 r_PANSICodePage;
		public virtual RSystem.RInt32 RPANSICodePage
		{
			get
			{
				if(r_PANSICodePage == null)
				{
					r_PANSICodePage = new(this, "ANSICodePage", -1);
					r_PANSICodePage.SetBelong(this.instance);
				}
				return r_PANSICodePage;
			}
		}

		/// <summary>
		/// Int32 OEMCodePage
		/// </summary>
		protected RSystem.RInt32 r_POEMCodePage;
		public virtual RSystem.RInt32 RPOEMCodePage
		{
			get
			{
				if(r_POEMCodePage == null)
				{
					r_POEMCodePage = new(this, "OEMCodePage", -1);
					r_POEMCodePage.SetBelong(this.instance);
				}
				return r_POEMCodePage;
			}
		}

		/// <summary>
		/// Int32 MacCodePage
		/// </summary>
		protected RSystem.RInt32 r_PMacCodePage;
		public virtual RSystem.RInt32 RPMacCodePage
		{
			get
			{
				if(r_PMacCodePage == null)
				{
					r_PMacCodePage = new(this, "MacCodePage", -1);
					r_PMacCodePage.SetBelong(this.instance);
				}
				return r_PMacCodePage;
			}
		}

		/// <summary>
		/// Int32 EBCDICCodePage
		/// </summary>
		protected RSystem.RInt32 r_PEBCDICCodePage;
		public virtual RSystem.RInt32 RPEBCDICCodePage
		{
			get
			{
				if(r_PEBCDICCodePage == null)
				{
					r_PEBCDICCodePage = new(this, "EBCDICCodePage", -1);
					r_PEBCDICCodePage.SetBelong(this.instance);
				}
				return r_PEBCDICCodePage;
			}
		}

		/// <summary>
		/// Int32 LCID
		/// </summary>
		protected RSystem.RInt32 r_PLCID;
		public virtual RSystem.RInt32 RPLCID
		{
			get
			{
				if(r_PLCID == null)
				{
					r_PLCID = new(this, "LCID", -1);
					r_PLCID.SetBelong(this.instance);
				}
				return r_PLCID;
			}
		}

		/// <summary>
		/// System.String CultureName
		/// </summary>
		protected RSystem.RString r_PCultureName;
		public virtual RSystem.RString RPCultureName
		{
			get
			{
				if(r_PCultureName == null)
				{
					r_PCultureName = new(this, "CultureName", -1);
					r_PCultureName.SetBelong(this.instance);
				}
				return r_PCultureName;
			}
		}

		/// <summary>
		/// Boolean IsReadOnly
		/// </summary>
		protected RSystem.RBoolean r_PIsReadOnly;
		public virtual RSystem.RBoolean RPIsReadOnly
		{
			get
			{
				if(r_PIsReadOnly == null)
				{
					r_PIsReadOnly = new(this, "IsReadOnly", -1);
					r_PIsReadOnly.SetBelong(this.instance);
				}
				return r_PIsReadOnly;
			}
		}

		/// <summary>
		/// System.String ListSeparator
		/// </summary>
		protected RSystem.RString r_PListSeparator;
		public virtual RSystem.RString RPListSeparator
		{
			get
			{
				if(r_PListSeparator == null)
				{
					r_PListSeparator = new(this, "ListSeparator", -1);
					r_PListSeparator.SetBelong(this.instance);
				}
				return r_PListSeparator;
			}
		}

		/// <summary>
		/// Boolean IsAsciiCasingSameAsInvariant
		/// </summary>
		protected RSystem.RBoolean r_PIsAsciiCasingSameAsInvariant;
		public virtual RSystem.RBoolean RPIsAsciiCasingSameAsInvariant
		{
			get
			{
				if(r_PIsAsciiCasingSameAsInvariant == null)
				{
					r_PIsAsciiCasingSameAsInvariant = new(this, "IsAsciiCasingSameAsInvariant", -1);
					r_PIsAsciiCasingSameAsInvariant.SetBelong(this.instance);
				}
				return r_PIsAsciiCasingSameAsInvariant;
			}
		}

		/// <summary>
		/// Boolean IsRightToLeft
		/// </summary>
		protected RSystem.RBoolean r_PIsRightToLeft;
		public virtual RSystem.RBoolean RPIsRightToLeft
		{
			get
			{
				if(r_PIsRightToLeft == null)
				{
					r_PIsRightToLeft = new(this, "IsRightToLeft", -1);
					r_PIsRightToLeft.SetBelong(this.instance);
				}
				return r_PIsRightToLeft;
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
					r_MOnDeserializing_StreamingContext.SetBelong(this.instance);
				}
				return r_MOnDeserializing_StreamingContext;
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
					r_MOnDeserialized.SetBelong(this.instance);
				}
				return r_MOnDeserialized;
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
					r_MOnDeserialized_StreamingContext.SetBelong(this.instance);
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
					r_MOnSerializing_StreamingContext.SetBelong(this.instance);
				}
				return r_MOnSerializing_StreamingContext;
			}
		}

		/// <summary>
		/// Int32 GetHashCodeOrdinalIgnoreCase(System.String)
		/// </summary>
		protected static RMethod r_MGetHashCodeOrdinalIgnoreCase_String;
		public static RMethod RMGetHashCodeOrdinalIgnoreCase_String
		{
			get
			{
				if(r_MGetHashCodeOrdinalIgnoreCase_String == null)
				{
					r_MGetHashCodeOrdinalIgnoreCase_String = new(typeof(System.Globalization.TextInfo), "GetHashCodeOrdinalIgnoreCase", 0, typeof(System.String));
					r_MGetHashCodeOrdinalIgnoreCase_String.SetBelong(null);
				}
				return r_MGetHashCodeOrdinalIgnoreCase_String;
			}
		}

		/// <summary>
		/// Int32 GetHashCodeOrdinalIgnoreCase(System.String, Boolean, Int64)
		/// </summary>
		protected static RMethod r_MGetHashCodeOrdinalIgnoreCase_String_Boolean_Int64;
		public static RMethod RMGetHashCodeOrdinalIgnoreCase_String_Boolean_Int64
		{
			get
			{
				if(r_MGetHashCodeOrdinalIgnoreCase_String_Boolean_Int64 == null)
				{
					r_MGetHashCodeOrdinalIgnoreCase_String_Boolean_Int64 = new(typeof(System.Globalization.TextInfo), "GetHashCodeOrdinalIgnoreCase", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Int64));
					r_MGetHashCodeOrdinalIgnoreCase_String_Boolean_Int64.SetBelong(null);
				}
				return r_MGetHashCodeOrdinalIgnoreCase_String_Boolean_Int64;
			}
		}

		/// <summary>
		/// Int32 CompareOrdinalIgnoreCaseEx(System.String, Int32, System.String, Int32, Int32, Int32)
		/// </summary>
		protected static RMethod r_MCompareOrdinalIgnoreCaseEx_String_Int32_String_Int32_Int32_Int32;
		public static RMethod RMCompareOrdinalIgnoreCaseEx_String_Int32_String_Int32_Int32_Int32
		{
			get
			{
				if(r_MCompareOrdinalIgnoreCaseEx_String_Int32_String_Int32_Int32_Int32 == null)
				{
					r_MCompareOrdinalIgnoreCaseEx_String_Int32_String_Int32_Int32_Int32 = new(typeof(System.Globalization.TextInfo), "CompareOrdinalIgnoreCaseEx", 0, typeof(System.String), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_MCompareOrdinalIgnoreCaseEx_String_Int32_String_Int32_Int32_Int32.SetBelong(null);
				}
				return r_MCompareOrdinalIgnoreCaseEx_String_Int32_String_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOfStringOrdinalIgnoreCase(System.String, System.String, Int32, Int32)
		/// </summary>
		protected static RMethod r_MIndexOfStringOrdinalIgnoreCase_String_String_Int32_Int32;
		public static RMethod RMIndexOfStringOrdinalIgnoreCase_String_String_Int32_Int32
		{
			get
			{
				if(r_MIndexOfStringOrdinalIgnoreCase_String_String_Int32_Int32 == null)
				{
					r_MIndexOfStringOrdinalIgnoreCase_String_String_Int32_Int32 = new(typeof(System.Globalization.TextInfo), "IndexOfStringOrdinalIgnoreCase", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_MIndexOfStringOrdinalIgnoreCase_String_String_Int32_Int32.SetBelong(null);
				}
				return r_MIndexOfStringOrdinalIgnoreCase_String_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOfStringOrdinalIgnoreCase(System.String, System.String, Int32, Int32)
		/// </summary>
		protected static RMethod r_MLastIndexOfStringOrdinalIgnoreCase_String_String_Int32_Int32;
		public static RMethod RMLastIndexOfStringOrdinalIgnoreCase_String_String_Int32_Int32
		{
			get
			{
				if(r_MLastIndexOfStringOrdinalIgnoreCase_String_String_Int32_Int32 == null)
				{
					r_MLastIndexOfStringOrdinalIgnoreCase_String_String_Int32_Int32 = new(typeof(System.Globalization.TextInfo), "LastIndexOfStringOrdinalIgnoreCase", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_MLastIndexOfStringOrdinalIgnoreCase_String_String_Int32_Int32.SetBelong(null);
				}
				return r_MLastIndexOfStringOrdinalIgnoreCase_String_String_Int32_Int32;
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
					r_MClone.SetBelong(this.instance);
				}
				return r_MClone;
			}
		}

		/// <summary>
		/// System.Globalization.TextInfo ReadOnly(System.Globalization.TextInfo)
		/// </summary>
		protected static RMethod r_MReadOnly_TextInfo;
		public static RMethod RMReadOnly_TextInfo
		{
			get
			{
				if(r_MReadOnly_TextInfo == null)
				{
					r_MReadOnly_TextInfo = new(typeof(System.Globalization.TextInfo), "ReadOnly", 0, typeof(System.Globalization.TextInfo));
					r_MReadOnly_TextInfo.SetBelong(null);
				}
				return r_MReadOnly_TextInfo;
			}
		}

		/// <summary>
		/// Void VerifyWritable()
		/// </summary>
		protected RMethod r_MVerifyWritable;
		public virtual RMethod RMVerifyWritable
		{
			get
			{
				if(r_MVerifyWritable == null)
				{
					r_MVerifyWritable = new(this, "VerifyWritable", 0);
					r_MVerifyWritable.SetBelong(this.instance);
				}
				return r_MVerifyWritable;
			}
		}

		/// <summary>
		/// Void SetReadOnlyState(Boolean)
		/// </summary>
		protected RMethod r_MSetReadOnlyState_Boolean;
		public virtual RMethod RMSetReadOnlyState_Boolean
		{
			get
			{
				if(r_MSetReadOnlyState_Boolean == null)
				{
					r_MSetReadOnlyState_Boolean = new(this, "SetReadOnlyState", 0, typeof(System.Boolean));
					r_MSetReadOnlyState_Boolean.SetBelong(this.instance);
				}
				return r_MSetReadOnlyState_Boolean;
			}
		}

		/// <summary>
		/// Char ToLower(Char)
		/// </summary>
		protected RMethod r_MToLower_Char;
		public virtual RMethod RMToLower_Char
		{
			get
			{
				if(r_MToLower_Char == null)
				{
					r_MToLower_Char = new(this, "ToLower", 0, typeof(System.Char));
					r_MToLower_Char.SetBelong(this.instance);
				}
				return r_MToLower_Char;
			}
		}

		/// <summary>
		/// System.String ToLower(System.String)
		/// </summary>
		protected RMethod r_MToLower_String;
		public virtual RMethod RMToLower_String
		{
			get
			{
				if(r_MToLower_String == null)
				{
					r_MToLower_String = new(this, "ToLower", 0, typeof(System.String));
					r_MToLower_String.SetBelong(this.instance);
				}
				return r_MToLower_String;
			}
		}

		/// <summary>
		/// Char ToLowerAsciiInvariant(Char)
		/// </summary>
		protected static RMethod r_MToLowerAsciiInvariant_Char;
		public static RMethod RMToLowerAsciiInvariant_Char
		{
			get
			{
				if(r_MToLowerAsciiInvariant_Char == null)
				{
					r_MToLowerAsciiInvariant_Char = new(typeof(System.Globalization.TextInfo), "ToLowerAsciiInvariant", 0, typeof(System.Char));
					r_MToLowerAsciiInvariant_Char.SetBelong(null);
				}
				return r_MToLowerAsciiInvariant_Char;
			}
		}

		/// <summary>
		/// Char ToUpper(Char)
		/// </summary>
		protected RMethod r_MToUpper_Char;
		public virtual RMethod RMToUpper_Char
		{
			get
			{
				if(r_MToUpper_Char == null)
				{
					r_MToUpper_Char = new(this, "ToUpper", 0, typeof(System.Char));
					r_MToUpper_Char.SetBelong(this.instance);
				}
				return r_MToUpper_Char;
			}
		}

		/// <summary>
		/// System.String ToUpper(System.String)
		/// </summary>
		protected RMethod r_MToUpper_String;
		public virtual RMethod RMToUpper_String
		{
			get
			{
				if(r_MToUpper_String == null)
				{
					r_MToUpper_String = new(this, "ToUpper", 0, typeof(System.String));
					r_MToUpper_String.SetBelong(this.instance);
				}
				return r_MToUpper_String;
			}
		}

		/// <summary>
		/// Char ToUpperAsciiInvariant(Char)
		/// </summary>
		protected static RMethod r_MToUpperAsciiInvariant_Char;
		public static RMethod RMToUpperAsciiInvariant_Char
		{
			get
			{
				if(r_MToUpperAsciiInvariant_Char == null)
				{
					r_MToUpperAsciiInvariant_Char = new(typeof(System.Globalization.TextInfo), "ToUpperAsciiInvariant", 0, typeof(System.Char));
					r_MToUpperAsciiInvariant_Char.SetBelong(null);
				}
				return r_MToUpperAsciiInvariant_Char;
			}
		}

		/// <summary>
		/// Boolean IsAscii(Char)
		/// </summary>
		protected static RMethod r_MIsAscii_Char;
		public static RMethod RMIsAscii_Char
		{
			get
			{
				if(r_MIsAscii_Char == null)
				{
					r_MIsAscii_Char = new(typeof(System.Globalization.TextInfo), "IsAscii", 0, typeof(System.Char));
					r_MIsAscii_Char.SetBelong(null);
				}
				return r_MIsAscii_Char;
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

		/// <summary>
		/// System.String ToTitleCase(System.String)
		/// </summary>
		protected RMethod r_MToTitleCase_String;
		public virtual RMethod RMToTitleCase_String
		{
			get
			{
				if(r_MToTitleCase_String == null)
				{
					r_MToTitleCase_String = new(this, "ToTitleCase", 0, typeof(System.String));
					r_MToTitleCase_String.SetBelong(this.instance);
				}
				return r_MToTitleCase_String;
			}
		}

		/// <summary>
		/// Int32 AddNonLetter(System.Text.StringBuilder ByRef, System.String ByRef, Int32, Int32)
		/// </summary>
		protected static RMethod r_MAddNonLetter_Ref_StringBuilder_Ref_String_Int32_Int32;
		public static RMethod RMAddNonLetter_Ref_StringBuilder_Ref_String_Int32_Int32
		{
			get
			{
				if(r_MAddNonLetter_Ref_StringBuilder_Ref_String_Int32_Int32 == null)
				{
					r_MAddNonLetter_Ref_StringBuilder_Ref_String_Int32_Int32 = new(typeof(System.Globalization.TextInfo), "AddNonLetter", 0, typeof(System.Text.StringBuilder).MakeByRefType(), typeof(System.String).MakeByRefType(), typeof(System.Int32), typeof(System.Int32));
					r_MAddNonLetter_Ref_StringBuilder_Ref_String_Int32_Int32.SetBelong(null);
				}
				return r_MAddNonLetter_Ref_StringBuilder_Ref_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 AddTitlecaseLetter(System.Text.StringBuilder ByRef, System.String ByRef, Int32, Int32)
		/// </summary>
		protected RMethod r_MAddTitlecaseLetter_Ref_StringBuilder_Ref_String_Int32_Int32;
		public virtual RMethod RMAddTitlecaseLetter_Ref_StringBuilder_Ref_String_Int32_Int32
		{
			get
			{
				if(r_MAddTitlecaseLetter_Ref_StringBuilder_Ref_String_Int32_Int32 == null)
				{
					r_MAddTitlecaseLetter_Ref_StringBuilder_Ref_String_Int32_Int32 = new(this, "AddTitlecaseLetter", 0, typeof(System.Text.StringBuilder).MakeByRefType(), typeof(System.String).MakeByRefType(), typeof(System.Int32), typeof(System.Int32));
					r_MAddTitlecaseLetter_Ref_StringBuilder_Ref_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_MAddTitlecaseLetter_Ref_StringBuilder_Ref_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean IsWordSeparator(System.Globalization.UnicodeCategory)
		/// </summary>
		protected static RMethod r_MIsWordSeparator_UnicodeCategory;
		public static RMethod RMIsWordSeparator_UnicodeCategory
		{
			get
			{
				if(r_MIsWordSeparator_UnicodeCategory == null)
				{
					r_MIsWordSeparator_UnicodeCategory = new(typeof(System.Globalization.TextInfo), "IsWordSeparator", 0, typeof(System.Globalization.UnicodeCategory));
					r_MIsWordSeparator_UnicodeCategory.SetBelong(null);
				}
				return r_MIsWordSeparator_UnicodeCategory;
			}
		}

		/// <summary>
		/// Boolean IsLetterCategory(System.Globalization.UnicodeCategory)
		/// </summary>
		protected static RMethod r_MIsLetterCategory_UnicodeCategory;
		public static RMethod RMIsLetterCategory_UnicodeCategory
		{
			get
			{
				if(r_MIsLetterCategory_UnicodeCategory == null)
				{
					r_MIsLetterCategory_UnicodeCategory = new(typeof(System.Globalization.TextInfo), "IsLetterCategory", 0, typeof(System.Globalization.UnicodeCategory));
					r_MIsLetterCategory_UnicodeCategory.SetBelong(null);
				}
				return r_MIsLetterCategory_UnicodeCategory;
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
					r_MSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object;
			}
		}

		/// <summary>
		/// Int32 GetCaseInsensitiveHashCode(System.String)
		/// </summary>
		protected RMethod r_MGetCaseInsensitiveHashCode_String;
		public virtual RMethod RMGetCaseInsensitiveHashCode_String
		{
			get
			{
				if(r_MGetCaseInsensitiveHashCode_String == null)
				{
					r_MGetCaseInsensitiveHashCode_String = new(this, "GetCaseInsensitiveHashCode", 0, typeof(System.String));
					r_MGetCaseInsensitiveHashCode_String.SetBelong(this.instance);
				}
				return r_MGetCaseInsensitiveHashCode_String;
			}
		}

		/// <summary>
		/// Int32 GetCaseInsensitiveHashCode(System.String, Boolean, Int64)
		/// </summary>
		protected RMethod r_MGetCaseInsensitiveHashCode_String_Boolean_Int64;
		public virtual RMethod RMGetCaseInsensitiveHashCode_String_Boolean_Int64
		{
			get
			{
				if(r_MGetCaseInsensitiveHashCode_String_Boolean_Int64 == null)
				{
					r_MGetCaseInsensitiveHashCode_String_Boolean_Int64 = new(this, "GetCaseInsensitiveHashCode", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Int64));
					r_MGetCaseInsensitiveHashCode_String_Boolean_Int64.SetBelong(this.instance);
				}
				return r_MGetCaseInsensitiveHashCode_String_Boolean_Int64;
			}
		}

		/// <summary>
		/// Int32 GetInvariantCaseInsensitiveHashCode(System.String)
		/// </summary>
		protected RMethod r_MGetInvariantCaseInsensitiveHashCode_String;
		public virtual RMethod RMGetInvariantCaseInsensitiveHashCode_String
		{
			get
			{
				if(r_MGetInvariantCaseInsensitiveHashCode_String == null)
				{
					r_MGetInvariantCaseInsensitiveHashCode_String = new(this, "GetInvariantCaseInsensitiveHashCode", 0, typeof(System.String));
					r_MGetInvariantCaseInsensitiveHashCode_String.SetBelong(this.instance);
				}
				return r_MGetInvariantCaseInsensitiveHashCode_String;
			}
		}

		/// <summary>
		/// System.String ToUpperInternal(System.String)
		/// </summary>
		protected RMethod r_MToUpperInternal_String;
		public virtual RMethod RMToUpperInternal_String
		{
			get
			{
				if(r_MToUpperInternal_String == null)
				{
					r_MToUpperInternal_String = new(this, "ToUpperInternal", 0, typeof(System.String));
					r_MToUpperInternal_String.SetBelong(this.instance);
				}
				return r_MToUpperInternal_String;
			}
		}

		/// <summary>
		/// System.String ToLowerInternal(System.String)
		/// </summary>
		protected RMethod r_MToLowerInternal_String;
		public virtual RMethod RMToLowerInternal_String
		{
			get
			{
				if(r_MToLowerInternal_String == null)
				{
					r_MToLowerInternal_String = new(this, "ToLowerInternal", 0, typeof(System.String));
					r_MToLowerInternal_String.SetBelong(this.instance);
				}
				return r_MToLowerInternal_String;
			}
		}

		/// <summary>
		/// Char ToUpperInternal(Char)
		/// </summary>
		protected RMethod r_MToUpperInternal_Char;
		public virtual RMethod RMToUpperInternal_Char
		{
			get
			{
				if(r_MToUpperInternal_Char == null)
				{
					r_MToUpperInternal_Char = new(this, "ToUpperInternal", 0, typeof(System.Char));
					r_MToUpperInternal_Char.SetBelong(this.instance);
				}
				return r_MToUpperInternal_Char;
			}
		}

		/// <summary>
		/// Char ToLowerInternal(Char)
		/// </summary>
		protected RMethod r_MToLowerInternal_Char;
		public virtual RMethod RMToLowerInternal_Char
		{
			get
			{
				if(r_MToLowerInternal_Char == null)
				{
					r_MToLowerInternal_Char = new(this, "ToLowerInternal", 0, typeof(System.Char));
					r_MToLowerInternal_Char.SetBelong(this.instance);
				}
				return r_MToLowerInternal_Char;
			}
		}

		/// <summary>
		/// Int32 InternalCompareStringOrdinalIgnoreCase(System.String, Int32, System.String, Int32, Int32, Int32)
		/// </summary>
		protected static RMethod r_MInternalCompareStringOrdinalIgnoreCase_String_Int32_String_Int32_Int32_Int32;
		public static RMethod RMInternalCompareStringOrdinalIgnoreCase_String_Int32_String_Int32_Int32_Int32
		{
			get
			{
				if(r_MInternalCompareStringOrdinalIgnoreCase_String_Int32_String_Int32_Int32_Int32 == null)
				{
					r_MInternalCompareStringOrdinalIgnoreCase_String_Int32_String_Int32_Int32_Int32 = new(typeof(System.Globalization.TextInfo), "InternalCompareStringOrdinalIgnoreCase", 0, typeof(System.String), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_MInternalCompareStringOrdinalIgnoreCase_String_Int32_String_Int32_Int32_Int32.SetBelong(null);
				}
				return r_MInternalCompareStringOrdinalIgnoreCase_String_Int32_String_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void ToLowerAsciiInvariant(System.ReadOnlySpan`1[System.Char], System.Span`1[System.Char])
		/// </summary>
		protected RMethod r_MToLowerAsciiInvariant_ReadOnlySpan_d_Char_p__Span_d_Char_p_;
		public virtual RMethod RMToLowerAsciiInvariant_ReadOnlySpan_d_Char_p__Span_d_Char_p_
		{
			get
			{
				if(r_MToLowerAsciiInvariant_ReadOnlySpan_d_Char_p__Span_d_Char_p_ == null)
				{
					r_MToLowerAsciiInvariant_ReadOnlySpan_d_Char_p__Span_d_Char_p_ = new(this, "ToLowerAsciiInvariant", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Span<>).MakeGenericType(typeof(System.Char)));
					r_MToLowerAsciiInvariant_ReadOnlySpan_d_Char_p__Span_d_Char_p_.SetBelong(this.instance);
				}
				return r_MToLowerAsciiInvariant_ReadOnlySpan_d_Char_p__Span_d_Char_p_;
			}
		}

		/// <summary>
		/// Void ToUpperAsciiInvariant(System.ReadOnlySpan`1[System.Char], System.Span`1[System.Char])
		/// </summary>
		protected RMethod r_MToUpperAsciiInvariant_ReadOnlySpan_d_Char_p__Span_d_Char_p_;
		public virtual RMethod RMToUpperAsciiInvariant_ReadOnlySpan_d_Char_p__Span_d_Char_p_
		{
			get
			{
				if(r_MToUpperAsciiInvariant_ReadOnlySpan_d_Char_p__Span_d_Char_p_ == null)
				{
					r_MToUpperAsciiInvariant_ReadOnlySpan_d_Char_p__Span_d_Char_p_ = new(this, "ToUpperAsciiInvariant", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Span<>).MakeGenericType(typeof(System.Char)));
					r_MToUpperAsciiInvariant_ReadOnlySpan_d_Char_p__Span_d_Char_p_.SetBelong(this.instance);
				}
				return r_MToUpperAsciiInvariant_ReadOnlySpan_d_Char_p__Span_d_Char_p_;
			}
		}

		/// <summary>
		/// Void ChangeCase(System.ReadOnlySpan`1[System.Char], System.Span`1[System.Char], Boolean)
		/// </summary>
		protected RMethod r_MChangeCase_ReadOnlySpan_d_Char_p__Span_d_Char_p__Boolean;
		public virtual RMethod RMChangeCase_ReadOnlySpan_d_Char_p__Span_d_Char_p__Boolean
		{
			get
			{
				if(r_MChangeCase_ReadOnlySpan_d_Char_p__Span_d_Char_p__Boolean == null)
				{
					r_MChangeCase_ReadOnlySpan_d_Char_p__Span_d_Char_p__Boolean = new(this, "ChangeCase", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Span<>).MakeGenericType(typeof(System.Char)), typeof(System.Boolean));
					r_MChangeCase_ReadOnlySpan_d_Char_p__Span_d_Char_p__Boolean.SetBelong(this.instance);
				}
				return r_MChangeCase_ReadOnlySpan_d_Char_p__Span_d_Char_p__Boolean;
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


        public RTextInfo() : base("System.Globalization.TextInfo")
        {
        }

        public RTextInfo(System.Object instance) : base("System.Globalization.TextInfo")
		{
            SetInstance(instance);
		}

        public RTextInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnDeserializing(System.Runtime.Serialization.StreamingContext @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx};
            var ___result = RMOnDeserializing_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDeserialized()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnDeserialized.Invoke(___genericsType, ___parameters);

            
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


        public static System.Int32 GetHashCodeOrdinalIgnoreCase(System.String @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RMGetHashCodeOrdinalIgnoreCase_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 GetHashCodeOrdinalIgnoreCase(System.String @s, System.Boolean @forceRandomizedHashing, System.Int64 @additionalEntropy)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @forceRandomizedHashing, @additionalEntropy};
            var ___result = RMGetHashCodeOrdinalIgnoreCase_String_Boolean_Int64.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 CompareOrdinalIgnoreCaseEx(System.String @strA, System.Int32 @indexA, System.String @strB, System.Int32 @indexB, System.Int32 @lengthA, System.Int32 @lengthB)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @indexA, @strB, @indexB, @lengthA, @lengthB};
            var ___result = RMCompareOrdinalIgnoreCaseEx_String_Int32_String_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 IndexOfStringOrdinalIgnoreCase(System.String @source, System.String @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count};
            var ___result = RMIndexOfStringOrdinalIgnoreCase_String_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 LastIndexOfStringOrdinalIgnoreCase(System.String @source, System.String @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count};
            var ___result = RMLastIndexOfStringOrdinalIgnoreCase_String_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Globalization.TextInfo ReadOnly(System.Globalization.TextInfo @textInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textInfo};
            var ___result = RMReadOnly_TextInfo.Invoke(___genericsType, ___parameters);

            return (System.Globalization.TextInfo)___result;
        }


        public virtual void VerifyWritable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMVerifyWritable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetReadOnlyState(System.Boolean @readOnly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@readOnly};
            var ___result = RMSetReadOnlyState_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Char ToLower(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMToLower_Char.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public virtual System.String ToLower(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RMToLower_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Char ToLowerAsciiInvariant(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMToLowerAsciiInvariant_Char.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public virtual System.Char ToUpper(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMToUpper_Char.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public virtual System.String ToUpper(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RMToUpper_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Char ToUpperAsciiInvariant(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMToUpperAsciiInvariant_Char.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public static System.Boolean IsAscii(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMIsAscii_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToTitleCase(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RMToTitleCase_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Int32 AddNonLetter(ref System.Text.StringBuilder @result, ref System.String @input, System.Int32 @inputIndex, System.Int32 @charLen)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@result, @input, @inputIndex, @charLen};
            var ___result = RMAddNonLetter_Ref_StringBuilder_Ref_String_Int32_Int32.Invoke(___genericsType, ___parameters);
			@result = (System.Text.StringBuilder)___parameters[0];
			@input = (System.String)___parameters[1];

            return (System.Int32)___result;
        }


        public virtual System.Int32 AddTitlecaseLetter(ref System.Text.StringBuilder @result, ref System.String @input, System.Int32 @inputIndex, System.Int32 @charLen)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@result, @input, @inputIndex, @charLen};
            var ___result = RMAddTitlecaseLetter_Ref_StringBuilder_Ref_String_Int32_Int32.Invoke(___genericsType, ___parameters);
			@result = (System.Text.StringBuilder)___parameters[0];
			@input = (System.String)___parameters[1];

            return (System.Int32)___result;
        }


        public static System.Boolean IsWordSeparator(System.Globalization.UnicodeCategory @category)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@category};
            var ___result = RMIsWordSeparator_UnicodeCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsLetterCategory(System.Globalization.UnicodeCategory @uc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uc};
            var ___result = RMIsLetterCategory_UnicodeCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void System__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization(System.Object @sender)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender};
            var ___result = RMSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetCaseInsensitiveHashCode(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RMGetCaseInsensitiveHashCode_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetCaseInsensitiveHashCode(System.String @str, System.Boolean @forceRandomizedHashing, System.Int64 @additionalEntropy)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str, @forceRandomizedHashing, @additionalEntropy};
            var ___result = RMGetCaseInsensitiveHashCode_String_Boolean_Int64.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetInvariantCaseInsensitiveHashCode(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RMGetInvariantCaseInsensitiveHashCode_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToUpperInternal(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RMToUpperInternal_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToLowerInternal(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RMToLowerInternal_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Char ToUpperInternal(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMToUpperInternal_Char.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public virtual System.Char ToLowerInternal(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMToLowerInternal_Char.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public static System.Int32 InternalCompareStringOrdinalIgnoreCase(System.String @strA, System.Int32 @indexA, System.String @strB, System.Int32 @indexB, System.Int32 @lenA, System.Int32 @lenB)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @indexA, @strB, @indexB, @lenA, @lenB};
            var ___result = RMInternalCompareStringOrdinalIgnoreCase_String_Int32_String_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void ToLowerAsciiInvariant(RSystem.RReadOnlySpan<RSystem.RChar> @source, RSystem.RSpan<RSystem.RChar> @destination)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source.Value, @destination.Value};
            var ___result = RMToLowerAsciiInvariant_ReadOnlySpan_d_Char_p__Span_d_Char_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ToUpperAsciiInvariant(RSystem.RReadOnlySpan<RSystem.RChar> @source, RSystem.RSpan<RSystem.RChar> @destination)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source.Value, @destination.Value};
            var ___result = RMToUpperAsciiInvariant_ReadOnlySpan_d_Char_p__Span_d_Char_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ChangeCase(RSystem.RReadOnlySpan<RSystem.RChar> @source, RSystem.RSpan<RSystem.RChar> @destination, System.Boolean @toUpper)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source.Value, @destination.Value, @toUpper};
            var ___result = RMChangeCase_ReadOnlySpan_d_Char_p__Span_d_Char_p__Boolean.Invoke(___genericsType, ___parameters);

            
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


    }
}
