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
		protected RField r_m_listSeparator;
		public virtual RField Rm_listSeparator
		{
			get
			{
				if(r_m_listSeparator == null)
				{
					r_m_listSeparator = new(this, "m_listSeparator");
					r_m_listSeparator.SetBelong(this.instance);
				}
				return r_m_listSeparator;
			}
		}

		/// <summary>
		/// System.Boolean m_isReadOnly
		/// </summary>
		protected RField r_m_isReadOnly;
		public virtual RField Rm_isReadOnly
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
		/// System.String m_cultureName
		/// </summary>
		protected RField r_m_cultureName;
		public virtual RField Rm_cultureName
		{
			get
			{
				if(r_m_cultureName == null)
				{
					r_m_cultureName = new(this, "m_cultureName");
					r_m_cultureName.SetBelong(this.instance);
				}
				return r_m_cultureName;
			}
		}

		/// <summary>
		/// System.Globalization.CultureData m_cultureData
		/// </summary>
		protected RSystem.RGlobalization.RCultureData r_m_cultureData;
		public virtual RSystem.RGlobalization.RCultureData Rm_cultureData
		{
			get
			{
				if(r_m_cultureData == null)
				{
					r_m_cultureData = new(this, "m_cultureData");
					r_m_cultureData.SetBelong(this.instance);
				}
				return r_m_cultureData;
			}
		}

		/// <summary>
		/// System.String m_textInfoName
		/// </summary>
		protected RField r_m_textInfoName;
		public virtual RField Rm_textInfoName
		{
			get
			{
				if(r_m_textInfoName == null)
				{
					r_m_textInfoName = new(this, "m_textInfoName");
					r_m_textInfoName.SetBelong(this.instance);
				}
				return r_m_textInfoName;
			}
		}

		/// <summary>
		/// System.Nullable`1[System.Boolean] m_IsAsciiCasingSameAsInvariant
		/// </summary>
		protected RField r_m_IsAsciiCasingSameAsInvariant;
		public virtual RField Rm_IsAsciiCasingSameAsInvariant
		{
			get
			{
				if(r_m_IsAsciiCasingSameAsInvariant == null)
				{
					r_m_IsAsciiCasingSameAsInvariant = new(this, "m_IsAsciiCasingSameAsInvariant");
					r_m_IsAsciiCasingSameAsInvariant.SetBelong(this.instance);
				}
				return r_m_IsAsciiCasingSameAsInvariant;
			}
		}

		/// <summary>
		/// System.Globalization.TextInfo s_Invariant
		/// </summary>
		protected static RSystem.RGlobalization.RTextInfo r_s_Invariant;
		public static RSystem.RGlobalization.RTextInfo Rs_Invariant
		{
			get
			{
				if(r_s_Invariant == null)
				{
					r_s_Invariant = new(typeof(System.Globalization.TextInfo), "s_Invariant");
					r_s_Invariant.SetBelong(null);
				}
				return r_s_Invariant;
			}
		}

		/// <summary>
		/// System.String customCultureName
		/// </summary>
		protected RField r_customCultureName;
		public virtual RField RcustomCultureName
		{
			get
			{
				if(r_customCultureName == null)
				{
					r_customCultureName = new(this, "customCultureName");
					r_customCultureName.SetBelong(this.instance);
				}
				return r_customCultureName;
			}
		}

		/// <summary>
		/// System.Int32 m_nDataItem
		/// </summary>
		protected RField r_m_nDataItem;
		public virtual RField Rm_nDataItem
		{
			get
			{
				if(r_m_nDataItem == null)
				{
					r_m_nDataItem = new(this, "m_nDataItem");
					r_m_nDataItem.SetBelong(this.instance);
				}
				return r_m_nDataItem;
			}
		}

		/// <summary>
		/// System.Boolean m_useUserOverride
		/// </summary>
		protected RField r_m_useUserOverride;
		public virtual RField Rm_useUserOverride
		{
			get
			{
				if(r_m_useUserOverride == null)
				{
					r_m_useUserOverride = new(this, "m_useUserOverride");
					r_m_useUserOverride.SetBelong(this.instance);
				}
				return r_m_useUserOverride;
			}
		}

		/// <summary>
		/// System.Int32 m_win32LangID
		/// </summary>
		protected RField r_m_win32LangID;
		public virtual RField Rm_win32LangID
		{
			get
			{
				if(r_m_win32LangID == null)
				{
					r_m_win32LangID = new(this, "m_win32LangID");
					r_m_win32LangID.SetBelong(this.instance);
				}
				return r_m_win32LangID;
			}
		}

		/// <summary>
		/// System.Int32 wordSeparatorMask
		/// </summary>
		protected static RField r_wordSeparatorMask;
		public static RField RwordSeparatorMask
		{
			get
			{
				if(r_wordSeparatorMask == null)
				{
					r_wordSeparatorMask = new(typeof(System.Globalization.TextInfo), "wordSeparatorMask");
					r_wordSeparatorMask.SetBelong(null);
				}
				return r_wordSeparatorMask;
			}
		}

		/// <summary>
		/// System.Globalization.TextInfo Invariant
		/// </summary>
		protected static RSystem.RGlobalization.RTextInfo r_Invariant;
		public static RSystem.RGlobalization.RTextInfo RInvariant
		{
			get
			{
				if(r_Invariant == null)
				{
					r_Invariant = new(typeof(System.Globalization.TextInfo), "Invariant", -1);
					r_Invariant.SetBelong(null);
				}
				return r_Invariant;
			}
		}

		/// <summary>
		/// Int32 ANSICodePage
		/// </summary>
		protected RProperty r_ANSICodePage;
		public virtual RProperty RANSICodePage
		{
			get
			{
				if(r_ANSICodePage == null)
				{
					r_ANSICodePage = new(this, "ANSICodePage", -1);
					r_ANSICodePage.SetBelong(this.instance);
				}
				return r_ANSICodePage;
			}
		}

		/// <summary>
		/// Int32 OEMCodePage
		/// </summary>
		protected RProperty r_OEMCodePage;
		public virtual RProperty ROEMCodePage
		{
			get
			{
				if(r_OEMCodePage == null)
				{
					r_OEMCodePage = new(this, "OEMCodePage", -1);
					r_OEMCodePage.SetBelong(this.instance);
				}
				return r_OEMCodePage;
			}
		}

		/// <summary>
		/// Int32 MacCodePage
		/// </summary>
		protected RProperty r_MacCodePage;
		public virtual RProperty RMacCodePage
		{
			get
			{
				if(r_MacCodePage == null)
				{
					r_MacCodePage = new(this, "MacCodePage", -1);
					r_MacCodePage.SetBelong(this.instance);
				}
				return r_MacCodePage;
			}
		}

		/// <summary>
		/// Int32 EBCDICCodePage
		/// </summary>
		protected RProperty r_EBCDICCodePage;
		public virtual RProperty REBCDICCodePage
		{
			get
			{
				if(r_EBCDICCodePage == null)
				{
					r_EBCDICCodePage = new(this, "EBCDICCodePage", -1);
					r_EBCDICCodePage.SetBelong(this.instance);
				}
				return r_EBCDICCodePage;
			}
		}

		/// <summary>
		/// Int32 LCID
		/// </summary>
		protected RProperty r_LCID;
		public virtual RProperty RLCID
		{
			get
			{
				if(r_LCID == null)
				{
					r_LCID = new(this, "LCID", -1);
					r_LCID.SetBelong(this.instance);
				}
				return r_LCID;
			}
		}

		/// <summary>
		/// System.String CultureName
		/// </summary>
		protected RProperty r_CultureName;
		public virtual RProperty RCultureName
		{
			get
			{
				if(r_CultureName == null)
				{
					r_CultureName = new(this, "CultureName", -1);
					r_CultureName.SetBelong(this.instance);
				}
				return r_CultureName;
			}
		}

		/// <summary>
		/// Boolean IsReadOnly
		/// </summary>
		protected RProperty r_IsReadOnly;
		public virtual RProperty RIsReadOnly
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
		/// System.String ListSeparator
		/// </summary>
		protected RProperty r_ListSeparator;
		public virtual RProperty RListSeparator
		{
			get
			{
				if(r_ListSeparator == null)
				{
					r_ListSeparator = new(this, "ListSeparator", -1);
					r_ListSeparator.SetBelong(this.instance);
				}
				return r_ListSeparator;
			}
		}

		/// <summary>
		/// Boolean IsAsciiCasingSameAsInvariant
		/// </summary>
		protected RProperty r_IsAsciiCasingSameAsInvariant;
		public virtual RProperty RIsAsciiCasingSameAsInvariant
		{
			get
			{
				if(r_IsAsciiCasingSameAsInvariant == null)
				{
					r_IsAsciiCasingSameAsInvariant = new(this, "IsAsciiCasingSameAsInvariant", -1);
					r_IsAsciiCasingSameAsInvariant.SetBelong(this.instance);
				}
				return r_IsAsciiCasingSameAsInvariant;
			}
		}

		/// <summary>
		/// Boolean IsRightToLeft
		/// </summary>
		protected RProperty r_IsRightToLeft;
		public virtual RProperty RIsRightToLeft
		{
			get
			{
				if(r_IsRightToLeft == null)
				{
					r_IsRightToLeft = new(this, "IsRightToLeft", -1);
					r_IsRightToLeft.SetBelong(this.instance);
				}
				return r_IsRightToLeft;
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
		/// Int32 GetHashCodeOrdinalIgnoreCase(System.String)
		/// </summary>
		protected static RMethod r_GetHashCodeOrdinalIgnoreCase_String;
		public static RMethod RGetHashCodeOrdinalIgnoreCase_String
		{
			get
			{
				if(r_GetHashCodeOrdinalIgnoreCase_String == null)
				{
					r_GetHashCodeOrdinalIgnoreCase_String = new(typeof(System.Globalization.TextInfo), "GetHashCodeOrdinalIgnoreCase", 0, typeof(System.String));
					r_GetHashCodeOrdinalIgnoreCase_String.SetBelong(null);
				}
				return r_GetHashCodeOrdinalIgnoreCase_String;
			}
		}

		/// <summary>
		/// Int32 GetHashCodeOrdinalIgnoreCase(System.String, Boolean, Int64)
		/// </summary>
		protected static RMethod r_GetHashCodeOrdinalIgnoreCase_String_Boolean_Int64;
		public static RMethod RGetHashCodeOrdinalIgnoreCase_String_Boolean_Int64
		{
			get
			{
				if(r_GetHashCodeOrdinalIgnoreCase_String_Boolean_Int64 == null)
				{
					r_GetHashCodeOrdinalIgnoreCase_String_Boolean_Int64 = new(typeof(System.Globalization.TextInfo), "GetHashCodeOrdinalIgnoreCase", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Int64));
					r_GetHashCodeOrdinalIgnoreCase_String_Boolean_Int64.SetBelong(null);
				}
				return r_GetHashCodeOrdinalIgnoreCase_String_Boolean_Int64;
			}
		}

		/// <summary>
		/// Int32 CompareOrdinalIgnoreCaseEx(System.String, Int32, System.String, Int32, Int32, Int32)
		/// </summary>
		protected static RMethod r_CompareOrdinalIgnoreCaseEx_String_Int32_String_Int32_Int32_Int32;
		public static RMethod RCompareOrdinalIgnoreCaseEx_String_Int32_String_Int32_Int32_Int32
		{
			get
			{
				if(r_CompareOrdinalIgnoreCaseEx_String_Int32_String_Int32_Int32_Int32 == null)
				{
					r_CompareOrdinalIgnoreCaseEx_String_Int32_String_Int32_Int32_Int32 = new(typeof(System.Globalization.TextInfo), "CompareOrdinalIgnoreCaseEx", 0, typeof(System.String), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_CompareOrdinalIgnoreCaseEx_String_Int32_String_Int32_Int32_Int32.SetBelong(null);
				}
				return r_CompareOrdinalIgnoreCaseEx_String_Int32_String_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOfStringOrdinalIgnoreCase(System.String, System.String, Int32, Int32)
		/// </summary>
		protected static RMethod r_IndexOfStringOrdinalIgnoreCase_String_String_Int32_Int32;
		public static RMethod RIndexOfStringOrdinalIgnoreCase_String_String_Int32_Int32
		{
			get
			{
				if(r_IndexOfStringOrdinalIgnoreCase_String_String_Int32_Int32 == null)
				{
					r_IndexOfStringOrdinalIgnoreCase_String_String_Int32_Int32 = new(typeof(System.Globalization.TextInfo), "IndexOfStringOrdinalIgnoreCase", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_IndexOfStringOrdinalIgnoreCase_String_String_Int32_Int32.SetBelong(null);
				}
				return r_IndexOfStringOrdinalIgnoreCase_String_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOfStringOrdinalIgnoreCase(System.String, System.String, Int32, Int32)
		/// </summary>
		protected static RMethod r_LastIndexOfStringOrdinalIgnoreCase_String_String_Int32_Int32;
		public static RMethod RLastIndexOfStringOrdinalIgnoreCase_String_String_Int32_Int32
		{
			get
			{
				if(r_LastIndexOfStringOrdinalIgnoreCase_String_String_Int32_Int32 == null)
				{
					r_LastIndexOfStringOrdinalIgnoreCase_String_String_Int32_Int32 = new(typeof(System.Globalization.TextInfo), "LastIndexOfStringOrdinalIgnoreCase", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_LastIndexOfStringOrdinalIgnoreCase_String_String_Int32_Int32.SetBelong(null);
				}
				return r_LastIndexOfStringOrdinalIgnoreCase_String_String_Int32_Int32;
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
		/// System.Globalization.TextInfo ReadOnly(System.Globalization.TextInfo)
		/// </summary>
		protected static RMethod r_ReadOnly_TextInfo;
		public static RMethod RReadOnly_TextInfo
		{
			get
			{
				if(r_ReadOnly_TextInfo == null)
				{
					r_ReadOnly_TextInfo = new(typeof(System.Globalization.TextInfo), "ReadOnly", 0, typeof(System.Globalization.TextInfo));
					r_ReadOnly_TextInfo.SetBelong(null);
				}
				return r_ReadOnly_TextInfo;
			}
		}

		/// <summary>
		/// Void VerifyWritable()
		/// </summary>
		protected RMethod r_VerifyWritable;
		public virtual RMethod RVerifyWritable
		{
			get
			{
				if(r_VerifyWritable == null)
				{
					r_VerifyWritable = new(this, "VerifyWritable", 0);
					r_VerifyWritable.SetBelong(this.instance);
				}
				return r_VerifyWritable;
			}
		}

		/// <summary>
		/// Void SetReadOnlyState(Boolean)
		/// </summary>
		protected RMethod r_SetReadOnlyState_Boolean;
		public virtual RMethod RSetReadOnlyState_Boolean
		{
			get
			{
				if(r_SetReadOnlyState_Boolean == null)
				{
					r_SetReadOnlyState_Boolean = new(this, "SetReadOnlyState", 0, typeof(System.Boolean));
					r_SetReadOnlyState_Boolean.SetBelong(this.instance);
				}
				return r_SetReadOnlyState_Boolean;
			}
		}

		/// <summary>
		/// Char ToLower(Char)
		/// </summary>
		protected RMethod r_ToLower_Char;
		public virtual RMethod RToLower_Char
		{
			get
			{
				if(r_ToLower_Char == null)
				{
					r_ToLower_Char = new(this, "ToLower", 0, typeof(System.Char));
					r_ToLower_Char.SetBelong(this.instance);
				}
				return r_ToLower_Char;
			}
		}

		/// <summary>
		/// System.String ToLower(System.String)
		/// </summary>
		protected RMethod r_ToLower_String;
		public virtual RMethod RToLower_String
		{
			get
			{
				if(r_ToLower_String == null)
				{
					r_ToLower_String = new(this, "ToLower", 0, typeof(System.String));
					r_ToLower_String.SetBelong(this.instance);
				}
				return r_ToLower_String;
			}
		}

		/// <summary>
		/// Char ToLowerAsciiInvariant(Char)
		/// </summary>
		protected static RMethod r_ToLowerAsciiInvariant_Char;
		public static RMethod RToLowerAsciiInvariant_Char
		{
			get
			{
				if(r_ToLowerAsciiInvariant_Char == null)
				{
					r_ToLowerAsciiInvariant_Char = new(typeof(System.Globalization.TextInfo), "ToLowerAsciiInvariant", 0, typeof(System.Char));
					r_ToLowerAsciiInvariant_Char.SetBelong(null);
				}
				return r_ToLowerAsciiInvariant_Char;
			}
		}

		/// <summary>
		/// Char ToUpper(Char)
		/// </summary>
		protected RMethod r_ToUpper_Char;
		public virtual RMethod RToUpper_Char
		{
			get
			{
				if(r_ToUpper_Char == null)
				{
					r_ToUpper_Char = new(this, "ToUpper", 0, typeof(System.Char));
					r_ToUpper_Char.SetBelong(this.instance);
				}
				return r_ToUpper_Char;
			}
		}

		/// <summary>
		/// System.String ToUpper(System.String)
		/// </summary>
		protected RMethod r_ToUpper_String;
		public virtual RMethod RToUpper_String
		{
			get
			{
				if(r_ToUpper_String == null)
				{
					r_ToUpper_String = new(this, "ToUpper", 0, typeof(System.String));
					r_ToUpper_String.SetBelong(this.instance);
				}
				return r_ToUpper_String;
			}
		}

		/// <summary>
		/// Char ToUpperAsciiInvariant(Char)
		/// </summary>
		protected static RMethod r_ToUpperAsciiInvariant_Char;
		public static RMethod RToUpperAsciiInvariant_Char
		{
			get
			{
				if(r_ToUpperAsciiInvariant_Char == null)
				{
					r_ToUpperAsciiInvariant_Char = new(typeof(System.Globalization.TextInfo), "ToUpperAsciiInvariant", 0, typeof(System.Char));
					r_ToUpperAsciiInvariant_Char.SetBelong(null);
				}
				return r_ToUpperAsciiInvariant_Char;
			}
		}

		/// <summary>
		/// Boolean IsAscii(Char)
		/// </summary>
		protected static RMethod r_IsAscii_Char;
		public static RMethod RIsAscii_Char
		{
			get
			{
				if(r_IsAscii_Char == null)
				{
					r_IsAscii_Char = new(typeof(System.Globalization.TextInfo), "IsAscii", 0, typeof(System.Char));
					r_IsAscii_Char.SetBelong(null);
				}
				return r_IsAscii_Char;
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
		/// System.String ToTitleCase(System.String)
		/// </summary>
		protected RMethod r_ToTitleCase_String;
		public virtual RMethod RToTitleCase_String
		{
			get
			{
				if(r_ToTitleCase_String == null)
				{
					r_ToTitleCase_String = new(this, "ToTitleCase", 0, typeof(System.String));
					r_ToTitleCase_String.SetBelong(this.instance);
				}
				return r_ToTitleCase_String;
			}
		}

		/// <summary>
		/// Int32 AddNonLetter(System.Text.StringBuilder ByRef, System.String ByRef, Int32, Int32)
		/// </summary>
		protected static RMethod r_AddNonLetter_Ref_StringBuilder_Ref_String_Int32_Int32;
		public static RMethod RAddNonLetter_Ref_StringBuilder_Ref_String_Int32_Int32
		{
			get
			{
				if(r_AddNonLetter_Ref_StringBuilder_Ref_String_Int32_Int32 == null)
				{
					r_AddNonLetter_Ref_StringBuilder_Ref_String_Int32_Int32 = new(typeof(System.Globalization.TextInfo), "AddNonLetter", 0, typeof(System.Text.StringBuilder).MakeByRefType(), typeof(System.String).MakeByRefType(), typeof(System.Int32), typeof(System.Int32));
					r_AddNonLetter_Ref_StringBuilder_Ref_String_Int32_Int32.SetBelong(null);
				}
				return r_AddNonLetter_Ref_StringBuilder_Ref_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 AddTitlecaseLetter(System.Text.StringBuilder ByRef, System.String ByRef, Int32, Int32)
		/// </summary>
		protected RMethod r_AddTitlecaseLetter_Ref_StringBuilder_Ref_String_Int32_Int32;
		public virtual RMethod RAddTitlecaseLetter_Ref_StringBuilder_Ref_String_Int32_Int32
		{
			get
			{
				if(r_AddTitlecaseLetter_Ref_StringBuilder_Ref_String_Int32_Int32 == null)
				{
					r_AddTitlecaseLetter_Ref_StringBuilder_Ref_String_Int32_Int32 = new(this, "AddTitlecaseLetter", 0, typeof(System.Text.StringBuilder).MakeByRefType(), typeof(System.String).MakeByRefType(), typeof(System.Int32), typeof(System.Int32));
					r_AddTitlecaseLetter_Ref_StringBuilder_Ref_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_AddTitlecaseLetter_Ref_StringBuilder_Ref_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean IsWordSeparator(System.Globalization.UnicodeCategory)
		/// </summary>
		protected static RMethod r_IsWordSeparator_UnicodeCategory;
		public static RMethod RIsWordSeparator_UnicodeCategory
		{
			get
			{
				if(r_IsWordSeparator_UnicodeCategory == null)
				{
					r_IsWordSeparator_UnicodeCategory = new(typeof(System.Globalization.TextInfo), "IsWordSeparator", 0, typeof(System.Globalization.UnicodeCategory));
					r_IsWordSeparator_UnicodeCategory.SetBelong(null);
				}
				return r_IsWordSeparator_UnicodeCategory;
			}
		}

		/// <summary>
		/// Boolean IsLetterCategory(System.Globalization.UnicodeCategory)
		/// </summary>
		protected static RMethod r_IsLetterCategory_UnicodeCategory;
		public static RMethod RIsLetterCategory_UnicodeCategory
		{
			get
			{
				if(r_IsLetterCategory_UnicodeCategory == null)
				{
					r_IsLetterCategory_UnicodeCategory = new(typeof(System.Globalization.TextInfo), "IsLetterCategory", 0, typeof(System.Globalization.UnicodeCategory));
					r_IsLetterCategory_UnicodeCategory.SetBelong(null);
				}
				return r_IsLetterCategory_UnicodeCategory;
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
		/// Int32 GetCaseInsensitiveHashCode(System.String)
		/// </summary>
		protected RMethod r_GetCaseInsensitiveHashCode_String;
		public virtual RMethod RGetCaseInsensitiveHashCode_String
		{
			get
			{
				if(r_GetCaseInsensitiveHashCode_String == null)
				{
					r_GetCaseInsensitiveHashCode_String = new(this, "GetCaseInsensitiveHashCode", 0, typeof(System.String));
					r_GetCaseInsensitiveHashCode_String.SetBelong(this.instance);
				}
				return r_GetCaseInsensitiveHashCode_String;
			}
		}

		/// <summary>
		/// Int32 GetCaseInsensitiveHashCode(System.String, Boolean, Int64)
		/// </summary>
		protected RMethod r_GetCaseInsensitiveHashCode_String_Boolean_Int64;
		public virtual RMethod RGetCaseInsensitiveHashCode_String_Boolean_Int64
		{
			get
			{
				if(r_GetCaseInsensitiveHashCode_String_Boolean_Int64 == null)
				{
					r_GetCaseInsensitiveHashCode_String_Boolean_Int64 = new(this, "GetCaseInsensitiveHashCode", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Int64));
					r_GetCaseInsensitiveHashCode_String_Boolean_Int64.SetBelong(this.instance);
				}
				return r_GetCaseInsensitiveHashCode_String_Boolean_Int64;
			}
		}

		/// <summary>
		/// Int32 GetInvariantCaseInsensitiveHashCode(System.String)
		/// </summary>
		protected RMethod r_GetInvariantCaseInsensitiveHashCode_String;
		public virtual RMethod RGetInvariantCaseInsensitiveHashCode_String
		{
			get
			{
				if(r_GetInvariantCaseInsensitiveHashCode_String == null)
				{
					r_GetInvariantCaseInsensitiveHashCode_String = new(this, "GetInvariantCaseInsensitiveHashCode", 0, typeof(System.String));
					r_GetInvariantCaseInsensitiveHashCode_String.SetBelong(this.instance);
				}
				return r_GetInvariantCaseInsensitiveHashCode_String;
			}
		}

		/// <summary>
		/// System.String ToUpperInternal(System.String)
		/// </summary>
		protected RMethod r_ToUpperInternal_String;
		public virtual RMethod RToUpperInternal_String
		{
			get
			{
				if(r_ToUpperInternal_String == null)
				{
					r_ToUpperInternal_String = new(this, "ToUpperInternal", 0, typeof(System.String));
					r_ToUpperInternal_String.SetBelong(this.instance);
				}
				return r_ToUpperInternal_String;
			}
		}

		/// <summary>
		/// System.String ToLowerInternal(System.String)
		/// </summary>
		protected RMethod r_ToLowerInternal_String;
		public virtual RMethod RToLowerInternal_String
		{
			get
			{
				if(r_ToLowerInternal_String == null)
				{
					r_ToLowerInternal_String = new(this, "ToLowerInternal", 0, typeof(System.String));
					r_ToLowerInternal_String.SetBelong(this.instance);
				}
				return r_ToLowerInternal_String;
			}
		}

		/// <summary>
		/// Char ToUpperInternal(Char)
		/// </summary>
		protected RMethod r_ToUpperInternal_Char;
		public virtual RMethod RToUpperInternal_Char
		{
			get
			{
				if(r_ToUpperInternal_Char == null)
				{
					r_ToUpperInternal_Char = new(this, "ToUpperInternal", 0, typeof(System.Char));
					r_ToUpperInternal_Char.SetBelong(this.instance);
				}
				return r_ToUpperInternal_Char;
			}
		}

		/// <summary>
		/// Char ToLowerInternal(Char)
		/// </summary>
		protected RMethod r_ToLowerInternal_Char;
		public virtual RMethod RToLowerInternal_Char
		{
			get
			{
				if(r_ToLowerInternal_Char == null)
				{
					r_ToLowerInternal_Char = new(this, "ToLowerInternal", 0, typeof(System.Char));
					r_ToLowerInternal_Char.SetBelong(this.instance);
				}
				return r_ToLowerInternal_Char;
			}
		}

		/// <summary>
		/// Int32 InternalCompareStringOrdinalIgnoreCase(System.String, Int32, System.String, Int32, Int32, Int32)
		/// </summary>
		protected static RMethod r_InternalCompareStringOrdinalIgnoreCase_String_Int32_String_Int32_Int32_Int32;
		public static RMethod RInternalCompareStringOrdinalIgnoreCase_String_Int32_String_Int32_Int32_Int32
		{
			get
			{
				if(r_InternalCompareStringOrdinalIgnoreCase_String_Int32_String_Int32_Int32_Int32 == null)
				{
					r_InternalCompareStringOrdinalIgnoreCase_String_Int32_String_Int32_Int32_Int32 = new(typeof(System.Globalization.TextInfo), "InternalCompareStringOrdinalIgnoreCase", 0, typeof(System.String), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_InternalCompareStringOrdinalIgnoreCase_String_Int32_String_Int32_Int32_Int32.SetBelong(null);
				}
				return r_InternalCompareStringOrdinalIgnoreCase_String_Int32_String_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void ToLowerAsciiInvariant(System.ReadOnlySpan`1[System.Char], System.Span`1[System.Char])
		/// </summary>
		protected RMethod r_ToLowerAsciiInvariant_ReadOnlySpan_d_Char_p__Span_d_Char_p_;
		public virtual RMethod RToLowerAsciiInvariant_ReadOnlySpan_d_Char_p__Span_d_Char_p_
		{
			get
			{
				if(r_ToLowerAsciiInvariant_ReadOnlySpan_d_Char_p__Span_d_Char_p_ == null)
				{
					r_ToLowerAsciiInvariant_ReadOnlySpan_d_Char_p__Span_d_Char_p_ = new(this, "ToLowerAsciiInvariant", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Span<>).MakeGenericType(typeof(System.Char)));
					r_ToLowerAsciiInvariant_ReadOnlySpan_d_Char_p__Span_d_Char_p_.SetBelong(this.instance);
				}
				return r_ToLowerAsciiInvariant_ReadOnlySpan_d_Char_p__Span_d_Char_p_;
			}
		}

		/// <summary>
		/// Void ToUpperAsciiInvariant(System.ReadOnlySpan`1[System.Char], System.Span`1[System.Char])
		/// </summary>
		protected RMethod r_ToUpperAsciiInvariant_ReadOnlySpan_d_Char_p__Span_d_Char_p_;
		public virtual RMethod RToUpperAsciiInvariant_ReadOnlySpan_d_Char_p__Span_d_Char_p_
		{
			get
			{
				if(r_ToUpperAsciiInvariant_ReadOnlySpan_d_Char_p__Span_d_Char_p_ == null)
				{
					r_ToUpperAsciiInvariant_ReadOnlySpan_d_Char_p__Span_d_Char_p_ = new(this, "ToUpperAsciiInvariant", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Span<>).MakeGenericType(typeof(System.Char)));
					r_ToUpperAsciiInvariant_ReadOnlySpan_d_Char_p__Span_d_Char_p_.SetBelong(this.instance);
				}
				return r_ToUpperAsciiInvariant_ReadOnlySpan_d_Char_p__Span_d_Char_p_;
			}
		}

		/// <summary>
		/// Void ChangeCase(System.ReadOnlySpan`1[System.Char], System.Span`1[System.Char], Boolean)
		/// </summary>
		protected RMethod r_ChangeCase_ReadOnlySpan_d_Char_p__Span_d_Char_p__Boolean;
		public virtual RMethod RChangeCase_ReadOnlySpan_d_Char_p__Span_d_Char_p__Boolean
		{
			get
			{
				if(r_ChangeCase_ReadOnlySpan_d_Char_p__Span_d_Char_p__Boolean == null)
				{
					r_ChangeCase_ReadOnlySpan_d_Char_p__Span_d_Char_p__Boolean = new(this, "ChangeCase", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Span<>).MakeGenericType(typeof(System.Char)), typeof(System.Boolean));
					r_ChangeCase_ReadOnlySpan_d_Char_p__Span_d_Char_p__Boolean.SetBelong(this.instance);
				}
				return r_ChangeCase_ReadOnlySpan_d_Char_p__Span_d_Char_p__Boolean;
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

        public virtual void OnDeserializing(System.Runtime.Serialization.StreamingContext  @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx};
            var ___result = ROnDeserializing_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDeserialized()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnDeserialized.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDeserialized(System.Runtime.Serialization.StreamingContext  @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx};
            var ___result = ROnDeserialized_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnSerializing(System.Runtime.Serialization.StreamingContext  @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx};
            var ___result = ROnSerializing_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 GetHashCodeOrdinalIgnoreCase(System.String  @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RGetHashCodeOrdinalIgnoreCase_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 GetHashCodeOrdinalIgnoreCase(System.String  @s, System.Boolean  @forceRandomizedHashing, System.Int64  @additionalEntropy)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @forceRandomizedHashing, @additionalEntropy};
            var ___result = RGetHashCodeOrdinalIgnoreCase_String_Boolean_Int64.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 CompareOrdinalIgnoreCaseEx(System.String  @strA, System.Int32  @indexA, System.String  @strB, System.Int32  @indexB, System.Int32  @lengthA, System.Int32  @lengthB)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @indexA, @strB, @indexB, @lengthA, @lengthB};
            var ___result = RCompareOrdinalIgnoreCaseEx_String_Int32_String_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 IndexOfStringOrdinalIgnoreCase(System.String  @source, System.String  @value, System.Int32  @startIndex, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count};
            var ___result = RIndexOfStringOrdinalIgnoreCase_String_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 LastIndexOfStringOrdinalIgnoreCase(System.String  @source, System.String  @value, System.Int32  @startIndex, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count};
            var ___result = RLastIndexOfStringOrdinalIgnoreCase_String_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Globalization.TextInfo ReadOnly(System.Globalization.TextInfo  @textInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textInfo};
            var ___result = RReadOnly_TextInfo.Invoke(___genericsType, ___parameters);

            return (System.Globalization.TextInfo)___result;
        }


        public virtual void VerifyWritable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RVerifyWritable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetReadOnlyState(System.Boolean  @readOnly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@readOnly};
            var ___result = RSetReadOnlyState_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Char ToLower(System.Char  @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RToLower_Char.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public virtual System.String ToLower(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RToLower_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Char ToLowerAsciiInvariant(System.Char  @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RToLowerAsciiInvariant_Char.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public virtual System.Char ToUpper(System.Char  @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RToUpper_Char.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public virtual System.String ToUpper(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RToUpper_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Char ToUpperAsciiInvariant(System.Char  @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RToUpperAsciiInvariant_Char.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public static System.Boolean IsAscii(System.Char  @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RIsAscii_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToTitleCase(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RToTitleCase_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Int32 AddNonLetter(ref System.Text.StringBuilder  @result, ref System.String  @input, System.Int32  @inputIndex, System.Int32  @charLen)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@result, @input, @inputIndex, @charLen};
            var ___result = RAddNonLetter_Ref_StringBuilder_Ref_String_Int32_Int32.Invoke(___genericsType, ___parameters);
			result = (System.Text.StringBuilder)___parameters[0];
			input = (System.String)___parameters[1];

            return (System.Int32)___result;
        }


        public virtual System.Int32 AddTitlecaseLetter(ref System.Text.StringBuilder  @result, ref System.String  @input, System.Int32  @inputIndex, System.Int32  @charLen)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@result, @input, @inputIndex, @charLen};
            var ___result = RAddTitlecaseLetter_Ref_StringBuilder_Ref_String_Int32_Int32.Invoke(___genericsType, ___parameters);
			result = (System.Text.StringBuilder)___parameters[0];
			input = (System.String)___parameters[1];

            return (System.Int32)___result;
        }


        public static System.Boolean IsWordSeparator(System.Globalization.UnicodeCategory  @category)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@category};
            var ___result = RIsWordSeparator_UnicodeCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsLetterCategory(System.Globalization.UnicodeCategory  @uc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uc};
            var ___result = RIsLetterCategory_UnicodeCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void System__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization(System.Object  @sender)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender};
            var ___result = RSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetCaseInsensitiveHashCode(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RGetCaseInsensitiveHashCode_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetCaseInsensitiveHashCode(System.String  @str, System.Boolean  @forceRandomizedHashing, System.Int64  @additionalEntropy)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str, @forceRandomizedHashing, @additionalEntropy};
            var ___result = RGetCaseInsensitiveHashCode_String_Boolean_Int64.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetInvariantCaseInsensitiveHashCode(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RGetInvariantCaseInsensitiveHashCode_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToUpperInternal(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RToUpperInternal_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToLowerInternal(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RToLowerInternal_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Char ToUpperInternal(System.Char  @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RToUpperInternal_Char.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public virtual System.Char ToLowerInternal(System.Char  @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RToLowerInternal_Char.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public static System.Int32 InternalCompareStringOrdinalIgnoreCase(System.String  @strA, System.Int32  @indexA, System.String  @strB, System.Int32  @indexB, System.Int32  @lenA, System.Int32  @lenB)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @indexA, @strB, @indexB, @lenA, @lenB};
            var ___result = RInternalCompareStringOrdinalIgnoreCase_String_Int32_String_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
