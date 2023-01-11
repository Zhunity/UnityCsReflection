using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.Char
	/// </summary>
    public partial class RChar : RMember //
    {

		/// <summary>
		/// System.Char m_value
		/// </summary>
		protected RSystem.RChar r_m_value;
		public virtual RSystem.RChar Rm_value
		{
			get
			{
				if(r_m_value == null)
				{
					r_m_value = new(this, "m_value");
					r_m_value.SetBelong(this.instance);
				}
				return r_m_value;
			}
		}

		/// <summary>
		/// System.Char MaxValue
		/// </summary>
		protected static RSystem.RChar r_MaxValue;
		public static RSystem.RChar RMaxValue
		{
			get
			{
				if(r_MaxValue == null)
				{
					r_MaxValue = new(typeof(System.Char), "MaxValue");
					r_MaxValue.SetBelong(null);
				}
				return r_MaxValue;
			}
		}

		/// <summary>
		/// System.Char MinValue
		/// </summary>
		protected static RSystem.RChar r_MinValue;
		public static RSystem.RChar RMinValue
		{
			get
			{
				if(r_MinValue == null)
				{
					r_MinValue = new(typeof(System.Char), "MinValue");
					r_MinValue.SetBelong(null);
				}
				return r_MinValue;
			}
		}

		/// <summary>
		/// System.Byte[] s_categoryForLatin1
		/// </summary>
		protected static RFieldArray<RSystem.RByte> r_s_categoryForLatin1;
		public static RFieldArray<RSystem.RByte> Rs_categoryForLatin1
		{
			get
			{
				if(r_s_categoryForLatin1 == null)
				{
					r_s_categoryForLatin1 = new(typeof(System.Char), "s_categoryForLatin1");
					r_s_categoryForLatin1.SetBelong(null);
				}
				return r_s_categoryForLatin1;
			}
		}

		/// <summary>
		/// System.Int32 UNICODE_PLANE00_END
		/// </summary>
		protected static RSystem.RInt32 r_UNICODE_PLANE00_END;
		public static RSystem.RInt32 RUNICODE_PLANE00_END
		{
			get
			{
				if(r_UNICODE_PLANE00_END == null)
				{
					r_UNICODE_PLANE00_END = new(typeof(System.Char), "UNICODE_PLANE00_END");
					r_UNICODE_PLANE00_END.SetBelong(null);
				}
				return r_UNICODE_PLANE00_END;
			}
		}

		/// <summary>
		/// System.Int32 UNICODE_PLANE01_START
		/// </summary>
		protected static RSystem.RInt32 r_UNICODE_PLANE01_START;
		public static RSystem.RInt32 RUNICODE_PLANE01_START
		{
			get
			{
				if(r_UNICODE_PLANE01_START == null)
				{
					r_UNICODE_PLANE01_START = new(typeof(System.Char), "UNICODE_PLANE01_START");
					r_UNICODE_PLANE01_START.SetBelong(null);
				}
				return r_UNICODE_PLANE01_START;
			}
		}

		/// <summary>
		/// System.Int32 UNICODE_PLANE16_END
		/// </summary>
		protected static RSystem.RInt32 r_UNICODE_PLANE16_END;
		public static RSystem.RInt32 RUNICODE_PLANE16_END
		{
			get
			{
				if(r_UNICODE_PLANE16_END == null)
				{
					r_UNICODE_PLANE16_END = new(typeof(System.Char), "UNICODE_PLANE16_END");
					r_UNICODE_PLANE16_END.SetBelong(null);
				}
				return r_UNICODE_PLANE16_END;
			}
		}

		/// <summary>
		/// System.Int32 HIGH_SURROGATE_START
		/// </summary>
		protected static RSystem.RInt32 r_HIGH_SURROGATE_START;
		public static RSystem.RInt32 RHIGH_SURROGATE_START
		{
			get
			{
				if(r_HIGH_SURROGATE_START == null)
				{
					r_HIGH_SURROGATE_START = new(typeof(System.Char), "HIGH_SURROGATE_START");
					r_HIGH_SURROGATE_START.SetBelong(null);
				}
				return r_HIGH_SURROGATE_START;
			}
		}

		/// <summary>
		/// System.Int32 LOW_SURROGATE_END
		/// </summary>
		protected static RSystem.RInt32 r_LOW_SURROGATE_END;
		public static RSystem.RInt32 RLOW_SURROGATE_END
		{
			get
			{
				if(r_LOW_SURROGATE_END == null)
				{
					r_LOW_SURROGATE_END = new(typeof(System.Char), "LOW_SURROGATE_END");
					r_LOW_SURROGATE_END.SetBelong(null);
				}
				return r_LOW_SURROGATE_END;
			}
		}

		/// <summary>
		/// Boolean IsLatin1(Char)
		/// </summary>
		protected static RMethod r_IsLatin1_Char;
		public static RMethod RIsLatin1_Char
		{
			get
			{
				if(r_IsLatin1_Char == null)
				{
					r_IsLatin1_Char = new(typeof(System.Char), "IsLatin1", 0, typeof(System.Char));
					r_IsLatin1_Char.SetBelong(null);
				}
				return r_IsLatin1_Char;
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
					r_IsAscii_Char = new(typeof(System.Char), "IsAscii", 0, typeof(System.Char));
					r_IsAscii_Char.SetBelong(null);
				}
				return r_IsAscii_Char;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory GetLatin1UnicodeCategory(Char)
		/// </summary>
		protected static RMethod r_GetLatin1UnicodeCategory_Char;
		public static RMethod RGetLatin1UnicodeCategory_Char
		{
			get
			{
				if(r_GetLatin1UnicodeCategory_Char == null)
				{
					r_GetLatin1UnicodeCategory_Char = new(typeof(System.Char), "GetLatin1UnicodeCategory", 0, typeof(System.Char));
					r_GetLatin1UnicodeCategory_Char.SetBelong(null);
				}
				return r_GetLatin1UnicodeCategory_Char;
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
		/// Boolean Equals(Char)
		/// </summary>
		protected RMethod r_Equals_Char;
		public virtual RMethod REquals_Char
		{
			get
			{
				if(r_Equals_Char == null)
				{
					r_Equals_Char = new(this, "Equals", 0, typeof(System.Char));
					r_Equals_Char.SetBelong(this.instance);
				}
				return r_Equals_Char;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Object)
		/// </summary>
		protected RMethod r_CompareTo_Object;
		public virtual RMethod RCompareTo_Object
		{
			get
			{
				if(r_CompareTo_Object == null)
				{
					r_CompareTo_Object = new(this, "CompareTo", 0, typeof(System.Object));
					r_CompareTo_Object.SetBelong(this.instance);
				}
				return r_CompareTo_Object;
			}
		}

		/// <summary>
		/// Int32 CompareTo(Char)
		/// </summary>
		protected RMethod r_CompareTo_Char;
		public virtual RMethod RCompareTo_Char
		{
			get
			{
				if(r_CompareTo_Char == null)
				{
					r_CompareTo_Char = new(this, "CompareTo", 0, typeof(System.Char));
					r_CompareTo_Char.SetBelong(this.instance);
				}
				return r_CompareTo_Char;
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
		/// System.String ToString(System.IFormatProvider)
		/// </summary>
		protected RMethod r_ToString_IFormatProvider;
		public virtual RMethod RToString_IFormatProvider
		{
			get
			{
				if(r_ToString_IFormatProvider == null)
				{
					r_ToString_IFormatProvider = new(this, "ToString", 0, typeof(System.IFormatProvider));
					r_ToString_IFormatProvider.SetBelong(this.instance);
				}
				return r_ToString_IFormatProvider;
			}
		}

		/// <summary>
		/// System.String ToString(Char)
		/// </summary>
		protected static RMethod r_ToString_Char;
		public static RMethod RToString_Char
		{
			get
			{
				if(r_ToString_Char == null)
				{
					r_ToString_Char = new(typeof(System.Char), "ToString", 0, typeof(System.Char));
					r_ToString_Char.SetBelong(null);
				}
				return r_ToString_Char;
			}
		}

		/// <summary>
		/// Char Parse(System.String)
		/// </summary>
		protected static RMethod r_Parse_String;
		public static RMethod RParse_String
		{
			get
			{
				if(r_Parse_String == null)
				{
					r_Parse_String = new(typeof(System.Char), "Parse", 0, typeof(System.String));
					r_Parse_String.SetBelong(null);
				}
				return r_Parse_String;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.String, Char ByRef)
		/// </summary>
		protected static RMethod r_TryParse_String_Out_Char;
		public static RMethod RTryParse_String_Out_Char
		{
			get
			{
				if(r_TryParse_String_Out_Char == null)
				{
					r_TryParse_String_Out_Char = new(typeof(System.Char), "TryParse", 0, typeof(System.String), typeof(System.Char).MakeByRefType());
					r_TryParse_String_Out_Char.SetBelong(null);
				}
				return r_TryParse_String_Out_Char;
			}
		}

		/// <summary>
		/// Boolean IsDigit(Char)
		/// </summary>
		protected static RMethod r_IsDigit_Char;
		public static RMethod RIsDigit_Char
		{
			get
			{
				if(r_IsDigit_Char == null)
				{
					r_IsDigit_Char = new(typeof(System.Char), "IsDigit", 0, typeof(System.Char));
					r_IsDigit_Char.SetBelong(null);
				}
				return r_IsDigit_Char;
			}
		}

		/// <summary>
		/// Boolean CheckLetter(System.Globalization.UnicodeCategory)
		/// </summary>
		protected static RMethod r_CheckLetter_UnicodeCategory;
		public static RMethod RCheckLetter_UnicodeCategory
		{
			get
			{
				if(r_CheckLetter_UnicodeCategory == null)
				{
					r_CheckLetter_UnicodeCategory = new(typeof(System.Char), "CheckLetter", 0, typeof(System.Globalization.UnicodeCategory));
					r_CheckLetter_UnicodeCategory.SetBelong(null);
				}
				return r_CheckLetter_UnicodeCategory;
			}
		}

		/// <summary>
		/// Boolean IsLetter(Char)
		/// </summary>
		protected static RMethod r_IsLetter_Char;
		public static RMethod RIsLetter_Char
		{
			get
			{
				if(r_IsLetter_Char == null)
				{
					r_IsLetter_Char = new(typeof(System.Char), "IsLetter", 0, typeof(System.Char));
					r_IsLetter_Char.SetBelong(null);
				}
				return r_IsLetter_Char;
			}
		}

		/// <summary>
		/// Boolean IsWhiteSpaceLatin1(Char)
		/// </summary>
		protected static RMethod r_IsWhiteSpaceLatin1_Char;
		public static RMethod RIsWhiteSpaceLatin1_Char
		{
			get
			{
				if(r_IsWhiteSpaceLatin1_Char == null)
				{
					r_IsWhiteSpaceLatin1_Char = new(typeof(System.Char), "IsWhiteSpaceLatin1", 0, typeof(System.Char));
					r_IsWhiteSpaceLatin1_Char.SetBelong(null);
				}
				return r_IsWhiteSpaceLatin1_Char;
			}
		}

		/// <summary>
		/// Boolean IsWhiteSpace(Char)
		/// </summary>
		protected static RMethod r_IsWhiteSpace_Char;
		public static RMethod RIsWhiteSpace_Char
		{
			get
			{
				if(r_IsWhiteSpace_Char == null)
				{
					r_IsWhiteSpace_Char = new(typeof(System.Char), "IsWhiteSpace", 0, typeof(System.Char));
					r_IsWhiteSpace_Char.SetBelong(null);
				}
				return r_IsWhiteSpace_Char;
			}
		}

		/// <summary>
		/// Boolean IsUpper(Char)
		/// </summary>
		protected static RMethod r_IsUpper_Char;
		public static RMethod RIsUpper_Char
		{
			get
			{
				if(r_IsUpper_Char == null)
				{
					r_IsUpper_Char = new(typeof(System.Char), "IsUpper", 0, typeof(System.Char));
					r_IsUpper_Char.SetBelong(null);
				}
				return r_IsUpper_Char;
			}
		}

		/// <summary>
		/// Boolean IsLower(Char)
		/// </summary>
		protected static RMethod r_IsLower_Char;
		public static RMethod RIsLower_Char
		{
			get
			{
				if(r_IsLower_Char == null)
				{
					r_IsLower_Char = new(typeof(System.Char), "IsLower", 0, typeof(System.Char));
					r_IsLower_Char.SetBelong(null);
				}
				return r_IsLower_Char;
			}
		}

		/// <summary>
		/// Boolean CheckPunctuation(System.Globalization.UnicodeCategory)
		/// </summary>
		protected static RMethod r_CheckPunctuation_UnicodeCategory;
		public static RMethod RCheckPunctuation_UnicodeCategory
		{
			get
			{
				if(r_CheckPunctuation_UnicodeCategory == null)
				{
					r_CheckPunctuation_UnicodeCategory = new(typeof(System.Char), "CheckPunctuation", 0, typeof(System.Globalization.UnicodeCategory));
					r_CheckPunctuation_UnicodeCategory.SetBelong(null);
				}
				return r_CheckPunctuation_UnicodeCategory;
			}
		}

		/// <summary>
		/// Boolean IsPunctuation(Char)
		/// </summary>
		protected static RMethod r_IsPunctuation_Char;
		public static RMethod RIsPunctuation_Char
		{
			get
			{
				if(r_IsPunctuation_Char == null)
				{
					r_IsPunctuation_Char = new(typeof(System.Char), "IsPunctuation", 0, typeof(System.Char));
					r_IsPunctuation_Char.SetBelong(null);
				}
				return r_IsPunctuation_Char;
			}
		}

		/// <summary>
		/// Boolean CheckLetterOrDigit(System.Globalization.UnicodeCategory)
		/// </summary>
		protected static RMethod r_CheckLetterOrDigit_UnicodeCategory;
		public static RMethod RCheckLetterOrDigit_UnicodeCategory
		{
			get
			{
				if(r_CheckLetterOrDigit_UnicodeCategory == null)
				{
					r_CheckLetterOrDigit_UnicodeCategory = new(typeof(System.Char), "CheckLetterOrDigit", 0, typeof(System.Globalization.UnicodeCategory));
					r_CheckLetterOrDigit_UnicodeCategory.SetBelong(null);
				}
				return r_CheckLetterOrDigit_UnicodeCategory;
			}
		}

		/// <summary>
		/// Boolean IsLetterOrDigit(Char)
		/// </summary>
		protected static RMethod r_IsLetterOrDigit_Char;
		public static RMethod RIsLetterOrDigit_Char
		{
			get
			{
				if(r_IsLetterOrDigit_Char == null)
				{
					r_IsLetterOrDigit_Char = new(typeof(System.Char), "IsLetterOrDigit", 0, typeof(System.Char));
					r_IsLetterOrDigit_Char.SetBelong(null);
				}
				return r_IsLetterOrDigit_Char;
			}
		}

		/// <summary>
		/// Char ToUpper(Char, System.Globalization.CultureInfo)
		/// </summary>
		protected static RMethod r_ToUpper_Char_CultureInfo;
		public static RMethod RToUpper_Char_CultureInfo
		{
			get
			{
				if(r_ToUpper_Char_CultureInfo == null)
				{
					r_ToUpper_Char_CultureInfo = new(typeof(System.Char), "ToUpper", 0, typeof(System.Char), typeof(System.Globalization.CultureInfo));
					r_ToUpper_Char_CultureInfo.SetBelong(null);
				}
				return r_ToUpper_Char_CultureInfo;
			}
		}

		/// <summary>
		/// Char ToUpper(Char)
		/// </summary>
		protected static RMethod r_ToUpper_Char;
		public static RMethod RToUpper_Char
		{
			get
			{
				if(r_ToUpper_Char == null)
				{
					r_ToUpper_Char = new(typeof(System.Char), "ToUpper", 0, typeof(System.Char));
					r_ToUpper_Char.SetBelong(null);
				}
				return r_ToUpper_Char;
			}
		}

		/// <summary>
		/// Char ToUpperInvariant(Char)
		/// </summary>
		protected static RMethod r_ToUpperInvariant_Char;
		public static RMethod RToUpperInvariant_Char
		{
			get
			{
				if(r_ToUpperInvariant_Char == null)
				{
					r_ToUpperInvariant_Char = new(typeof(System.Char), "ToUpperInvariant", 0, typeof(System.Char));
					r_ToUpperInvariant_Char.SetBelong(null);
				}
				return r_ToUpperInvariant_Char;
			}
		}

		/// <summary>
		/// Char ToLower(Char, System.Globalization.CultureInfo)
		/// </summary>
		protected static RMethod r_ToLower_Char_CultureInfo;
		public static RMethod RToLower_Char_CultureInfo
		{
			get
			{
				if(r_ToLower_Char_CultureInfo == null)
				{
					r_ToLower_Char_CultureInfo = new(typeof(System.Char), "ToLower", 0, typeof(System.Char), typeof(System.Globalization.CultureInfo));
					r_ToLower_Char_CultureInfo.SetBelong(null);
				}
				return r_ToLower_Char_CultureInfo;
			}
		}

		/// <summary>
		/// Char ToLower(Char)
		/// </summary>
		protected static RMethod r_ToLower_Char;
		public static RMethod RToLower_Char
		{
			get
			{
				if(r_ToLower_Char == null)
				{
					r_ToLower_Char = new(typeof(System.Char), "ToLower", 0, typeof(System.Char));
					r_ToLower_Char.SetBelong(null);
				}
				return r_ToLower_Char;
			}
		}

		/// <summary>
		/// Char ToLowerInvariant(Char)
		/// </summary>
		protected static RMethod r_ToLowerInvariant_Char;
		public static RMethod RToLowerInvariant_Char
		{
			get
			{
				if(r_ToLowerInvariant_Char == null)
				{
					r_ToLowerInvariant_Char = new(typeof(System.Char), "ToLowerInvariant", 0, typeof(System.Char));
					r_ToLowerInvariant_Char.SetBelong(null);
				}
				return r_ToLowerInvariant_Char;
			}
		}

		/// <summary>
		/// System.TypeCode GetTypeCode()
		/// </summary>
		protected RMethod r_GetTypeCode;
		public virtual RMethod RGetTypeCode
		{
			get
			{
				if(r_GetTypeCode == null)
				{
					r_GetTypeCode = new(this, "GetTypeCode", 0);
					r_GetTypeCode.SetBelong(this.instance);
				}
				return r_GetTypeCode;
			}
		}

		/// <summary>
		/// Boolean System.IConvertible.ToBoolean(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToBoolean_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToBoolean_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToBoolean_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToBoolean_IFormatProvider = new(this, "System.IConvertible.ToBoolean", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToBoolean_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToBoolean_IFormatProvider;
			}
		}

		/// <summary>
		/// Char System.IConvertible.ToChar(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToChar_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToChar_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToChar_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToChar_IFormatProvider = new(this, "System.IConvertible.ToChar", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToChar_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToChar_IFormatProvider;
			}
		}

		/// <summary>
		/// SByte System.IConvertible.ToSByte(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToSByte_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToSByte_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToSByte_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToSByte_IFormatProvider = new(this, "System.IConvertible.ToSByte", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToSByte_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToSByte_IFormatProvider;
			}
		}

		/// <summary>
		/// Byte System.IConvertible.ToByte(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToByte_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToByte_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToByte_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToByte_IFormatProvider = new(this, "System.IConvertible.ToByte", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToByte_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToByte_IFormatProvider;
			}
		}

		/// <summary>
		/// Int16 System.IConvertible.ToInt16(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToInt16_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToInt16_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToInt16_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToInt16_IFormatProvider = new(this, "System.IConvertible.ToInt16", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToInt16_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToInt16_IFormatProvider;
			}
		}

		/// <summary>
		/// UInt16 System.IConvertible.ToUInt16(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToUInt16_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToUInt16_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToUInt16_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToUInt16_IFormatProvider = new(this, "System.IConvertible.ToUInt16", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToUInt16_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToUInt16_IFormatProvider;
			}
		}

		/// <summary>
		/// Int32 System.IConvertible.ToInt32(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToInt32_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToInt32_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToInt32_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToInt32_IFormatProvider = new(this, "System.IConvertible.ToInt32", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToInt32_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToInt32_IFormatProvider;
			}
		}

		/// <summary>
		/// UInt32 System.IConvertible.ToUInt32(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToUInt32_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToUInt32_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToUInt32_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToUInt32_IFormatProvider = new(this, "System.IConvertible.ToUInt32", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToUInt32_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToUInt32_IFormatProvider;
			}
		}

		/// <summary>
		/// Int64 System.IConvertible.ToInt64(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToInt64_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToInt64_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToInt64_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToInt64_IFormatProvider = new(this, "System.IConvertible.ToInt64", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToInt64_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToInt64_IFormatProvider;
			}
		}

		/// <summary>
		/// UInt64 System.IConvertible.ToUInt64(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToUInt64_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToUInt64_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToUInt64_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToUInt64_IFormatProvider = new(this, "System.IConvertible.ToUInt64", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToUInt64_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToUInt64_IFormatProvider;
			}
		}

		/// <summary>
		/// Single System.IConvertible.ToSingle(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToSingle_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToSingle_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToSingle_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToSingle_IFormatProvider = new(this, "System.IConvertible.ToSingle", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToSingle_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToSingle_IFormatProvider;
			}
		}

		/// <summary>
		/// Double System.IConvertible.ToDouble(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToDouble_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToDouble_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToDouble_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToDouble_IFormatProvider = new(this, "System.IConvertible.ToDouble", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToDouble_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToDouble_IFormatProvider;
			}
		}

		/// <summary>
		/// System.Decimal System.IConvertible.ToDecimal(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToDecimal_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToDecimal_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToDecimal_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToDecimal_IFormatProvider = new(this, "System.IConvertible.ToDecimal", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToDecimal_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToDecimal_IFormatProvider;
			}
		}

		/// <summary>
		/// System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToDateTime_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToDateTime_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToDateTime_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToDateTime_IFormatProvider = new(this, "System.IConvertible.ToDateTime", 0, typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToDateTime_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToDateTime_IFormatProvider;
			}
		}

		/// <summary>
		/// System.Object System.IConvertible.ToType(System.Type, System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__IConvertible__2__ToType_Type_IFormatProvider;
		public virtual RMethod RSystem__2__IConvertible__2__ToType_Type_IFormatProvider
		{
			get
			{
				if(r_System__2__IConvertible__2__ToType_Type_IFormatProvider == null)
				{
					r_System__2__IConvertible__2__ToType_Type_IFormatProvider = new(this, "System.IConvertible.ToType", 0, typeof(System.Type), typeof(System.IFormatProvider));
					r_System__2__IConvertible__2__ToType_Type_IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__IConvertible__2__ToType_Type_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean IsControl(Char)
		/// </summary>
		protected static RMethod r_IsControl_Char;
		public static RMethod RIsControl_Char
		{
			get
			{
				if(r_IsControl_Char == null)
				{
					r_IsControl_Char = new(typeof(System.Char), "IsControl", 0, typeof(System.Char));
					r_IsControl_Char.SetBelong(null);
				}
				return r_IsControl_Char;
			}
		}

		/// <summary>
		/// Boolean IsControl(System.String, Int32)
		/// </summary>
		protected static RMethod r_IsControl_String_Int32;
		public static RMethod RIsControl_String_Int32
		{
			get
			{
				if(r_IsControl_String_Int32 == null)
				{
					r_IsControl_String_Int32 = new(typeof(System.Char), "IsControl", 0, typeof(System.String), typeof(System.Int32));
					r_IsControl_String_Int32.SetBelong(null);
				}
				return r_IsControl_String_Int32;
			}
		}

		/// <summary>
		/// Boolean IsDigit(System.String, Int32)
		/// </summary>
		protected static RMethod r_IsDigit_String_Int32;
		public static RMethod RIsDigit_String_Int32
		{
			get
			{
				if(r_IsDigit_String_Int32 == null)
				{
					r_IsDigit_String_Int32 = new(typeof(System.Char), "IsDigit", 0, typeof(System.String), typeof(System.Int32));
					r_IsDigit_String_Int32.SetBelong(null);
				}
				return r_IsDigit_String_Int32;
			}
		}

		/// <summary>
		/// Boolean IsLetter(System.String, Int32)
		/// </summary>
		protected static RMethod r_IsLetter_String_Int32;
		public static RMethod RIsLetter_String_Int32
		{
			get
			{
				if(r_IsLetter_String_Int32 == null)
				{
					r_IsLetter_String_Int32 = new(typeof(System.Char), "IsLetter", 0, typeof(System.String), typeof(System.Int32));
					r_IsLetter_String_Int32.SetBelong(null);
				}
				return r_IsLetter_String_Int32;
			}
		}

		/// <summary>
		/// Boolean IsLetterOrDigit(System.String, Int32)
		/// </summary>
		protected static RMethod r_IsLetterOrDigit_String_Int32;
		public static RMethod RIsLetterOrDigit_String_Int32
		{
			get
			{
				if(r_IsLetterOrDigit_String_Int32 == null)
				{
					r_IsLetterOrDigit_String_Int32 = new(typeof(System.Char), "IsLetterOrDigit", 0, typeof(System.String), typeof(System.Int32));
					r_IsLetterOrDigit_String_Int32.SetBelong(null);
				}
				return r_IsLetterOrDigit_String_Int32;
			}
		}

		/// <summary>
		/// Boolean IsLower(System.String, Int32)
		/// </summary>
		protected static RMethod r_IsLower_String_Int32;
		public static RMethod RIsLower_String_Int32
		{
			get
			{
				if(r_IsLower_String_Int32 == null)
				{
					r_IsLower_String_Int32 = new(typeof(System.Char), "IsLower", 0, typeof(System.String), typeof(System.Int32));
					r_IsLower_String_Int32.SetBelong(null);
				}
				return r_IsLower_String_Int32;
			}
		}

		/// <summary>
		/// Boolean CheckNumber(System.Globalization.UnicodeCategory)
		/// </summary>
		protected static RMethod r_CheckNumber_UnicodeCategory;
		public static RMethod RCheckNumber_UnicodeCategory
		{
			get
			{
				if(r_CheckNumber_UnicodeCategory == null)
				{
					r_CheckNumber_UnicodeCategory = new(typeof(System.Char), "CheckNumber", 0, typeof(System.Globalization.UnicodeCategory));
					r_CheckNumber_UnicodeCategory.SetBelong(null);
				}
				return r_CheckNumber_UnicodeCategory;
			}
		}

		/// <summary>
		/// Boolean IsNumber(Char)
		/// </summary>
		protected static RMethod r_IsNumber_Char;
		public static RMethod RIsNumber_Char
		{
			get
			{
				if(r_IsNumber_Char == null)
				{
					r_IsNumber_Char = new(typeof(System.Char), "IsNumber", 0, typeof(System.Char));
					r_IsNumber_Char.SetBelong(null);
				}
				return r_IsNumber_Char;
			}
		}

		/// <summary>
		/// Boolean IsNumber(System.String, Int32)
		/// </summary>
		protected static RMethod r_IsNumber_String_Int32;
		public static RMethod RIsNumber_String_Int32
		{
			get
			{
				if(r_IsNumber_String_Int32 == null)
				{
					r_IsNumber_String_Int32 = new(typeof(System.Char), "IsNumber", 0, typeof(System.String), typeof(System.Int32));
					r_IsNumber_String_Int32.SetBelong(null);
				}
				return r_IsNumber_String_Int32;
			}
		}

		/// <summary>
		/// Boolean IsPunctuation(System.String, Int32)
		/// </summary>
		protected static RMethod r_IsPunctuation_String_Int32;
		public static RMethod RIsPunctuation_String_Int32
		{
			get
			{
				if(r_IsPunctuation_String_Int32 == null)
				{
					r_IsPunctuation_String_Int32 = new(typeof(System.Char), "IsPunctuation", 0, typeof(System.String), typeof(System.Int32));
					r_IsPunctuation_String_Int32.SetBelong(null);
				}
				return r_IsPunctuation_String_Int32;
			}
		}

		/// <summary>
		/// Boolean CheckSeparator(System.Globalization.UnicodeCategory)
		/// </summary>
		protected static RMethod r_CheckSeparator_UnicodeCategory;
		public static RMethod RCheckSeparator_UnicodeCategory
		{
			get
			{
				if(r_CheckSeparator_UnicodeCategory == null)
				{
					r_CheckSeparator_UnicodeCategory = new(typeof(System.Char), "CheckSeparator", 0, typeof(System.Globalization.UnicodeCategory));
					r_CheckSeparator_UnicodeCategory.SetBelong(null);
				}
				return r_CheckSeparator_UnicodeCategory;
			}
		}

		/// <summary>
		/// Boolean IsSeparatorLatin1(Char)
		/// </summary>
		protected static RMethod r_IsSeparatorLatin1_Char;
		public static RMethod RIsSeparatorLatin1_Char
		{
			get
			{
				if(r_IsSeparatorLatin1_Char == null)
				{
					r_IsSeparatorLatin1_Char = new(typeof(System.Char), "IsSeparatorLatin1", 0, typeof(System.Char));
					r_IsSeparatorLatin1_Char.SetBelong(null);
				}
				return r_IsSeparatorLatin1_Char;
			}
		}

		/// <summary>
		/// Boolean IsSeparator(Char)
		/// </summary>
		protected static RMethod r_IsSeparator_Char;
		public static RMethod RIsSeparator_Char
		{
			get
			{
				if(r_IsSeparator_Char == null)
				{
					r_IsSeparator_Char = new(typeof(System.Char), "IsSeparator", 0, typeof(System.Char));
					r_IsSeparator_Char.SetBelong(null);
				}
				return r_IsSeparator_Char;
			}
		}

		/// <summary>
		/// Boolean IsSeparator(System.String, Int32)
		/// </summary>
		protected static RMethod r_IsSeparator_String_Int32;
		public static RMethod RIsSeparator_String_Int32
		{
			get
			{
				if(r_IsSeparator_String_Int32 == null)
				{
					r_IsSeparator_String_Int32 = new(typeof(System.Char), "IsSeparator", 0, typeof(System.String), typeof(System.Int32));
					r_IsSeparator_String_Int32.SetBelong(null);
				}
				return r_IsSeparator_String_Int32;
			}
		}

		/// <summary>
		/// Boolean IsSurrogate(Char)
		/// </summary>
		protected static RMethod r_IsSurrogate_Char;
		public static RMethod RIsSurrogate_Char
		{
			get
			{
				if(r_IsSurrogate_Char == null)
				{
					r_IsSurrogate_Char = new(typeof(System.Char), "IsSurrogate", 0, typeof(System.Char));
					r_IsSurrogate_Char.SetBelong(null);
				}
				return r_IsSurrogate_Char;
			}
		}

		/// <summary>
		/// Boolean IsSurrogate(System.String, Int32)
		/// </summary>
		protected static RMethod r_IsSurrogate_String_Int32;
		public static RMethod RIsSurrogate_String_Int32
		{
			get
			{
				if(r_IsSurrogate_String_Int32 == null)
				{
					r_IsSurrogate_String_Int32 = new(typeof(System.Char), "IsSurrogate", 0, typeof(System.String), typeof(System.Int32));
					r_IsSurrogate_String_Int32.SetBelong(null);
				}
				return r_IsSurrogate_String_Int32;
			}
		}

		/// <summary>
		/// Boolean CheckSymbol(System.Globalization.UnicodeCategory)
		/// </summary>
		protected static RMethod r_CheckSymbol_UnicodeCategory;
		public static RMethod RCheckSymbol_UnicodeCategory
		{
			get
			{
				if(r_CheckSymbol_UnicodeCategory == null)
				{
					r_CheckSymbol_UnicodeCategory = new(typeof(System.Char), "CheckSymbol", 0, typeof(System.Globalization.UnicodeCategory));
					r_CheckSymbol_UnicodeCategory.SetBelong(null);
				}
				return r_CheckSymbol_UnicodeCategory;
			}
		}

		/// <summary>
		/// Boolean IsSymbol(Char)
		/// </summary>
		protected static RMethod r_IsSymbol_Char;
		public static RMethod RIsSymbol_Char
		{
			get
			{
				if(r_IsSymbol_Char == null)
				{
					r_IsSymbol_Char = new(typeof(System.Char), "IsSymbol", 0, typeof(System.Char));
					r_IsSymbol_Char.SetBelong(null);
				}
				return r_IsSymbol_Char;
			}
		}

		/// <summary>
		/// Boolean IsSymbol(System.String, Int32)
		/// </summary>
		protected static RMethod r_IsSymbol_String_Int32;
		public static RMethod RIsSymbol_String_Int32
		{
			get
			{
				if(r_IsSymbol_String_Int32 == null)
				{
					r_IsSymbol_String_Int32 = new(typeof(System.Char), "IsSymbol", 0, typeof(System.String), typeof(System.Int32));
					r_IsSymbol_String_Int32.SetBelong(null);
				}
				return r_IsSymbol_String_Int32;
			}
		}

		/// <summary>
		/// Boolean IsUpper(System.String, Int32)
		/// </summary>
		protected static RMethod r_IsUpper_String_Int32;
		public static RMethod RIsUpper_String_Int32
		{
			get
			{
				if(r_IsUpper_String_Int32 == null)
				{
					r_IsUpper_String_Int32 = new(typeof(System.Char), "IsUpper", 0, typeof(System.String), typeof(System.Int32));
					r_IsUpper_String_Int32.SetBelong(null);
				}
				return r_IsUpper_String_Int32;
			}
		}

		/// <summary>
		/// Boolean IsWhiteSpace(System.String, Int32)
		/// </summary>
		protected static RMethod r_IsWhiteSpace_String_Int32;
		public static RMethod RIsWhiteSpace_String_Int32
		{
			get
			{
				if(r_IsWhiteSpace_String_Int32 == null)
				{
					r_IsWhiteSpace_String_Int32 = new(typeof(System.Char), "IsWhiteSpace", 0, typeof(System.String), typeof(System.Int32));
					r_IsWhiteSpace_String_Int32.SetBelong(null);
				}
				return r_IsWhiteSpace_String_Int32;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory GetUnicodeCategory(Char)
		/// </summary>
		protected static RMethod r_GetUnicodeCategory_Char;
		public static RMethod RGetUnicodeCategory_Char
		{
			get
			{
				if(r_GetUnicodeCategory_Char == null)
				{
					r_GetUnicodeCategory_Char = new(typeof(System.Char), "GetUnicodeCategory", 0, typeof(System.Char));
					r_GetUnicodeCategory_Char.SetBelong(null);
				}
				return r_GetUnicodeCategory_Char;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory GetUnicodeCategory(System.String, Int32)
		/// </summary>
		protected static RMethod r_GetUnicodeCategory_String_Int32;
		public static RMethod RGetUnicodeCategory_String_Int32
		{
			get
			{
				if(r_GetUnicodeCategory_String_Int32 == null)
				{
					r_GetUnicodeCategory_String_Int32 = new(typeof(System.Char), "GetUnicodeCategory", 0, typeof(System.String), typeof(System.Int32));
					r_GetUnicodeCategory_String_Int32.SetBelong(null);
				}
				return r_GetUnicodeCategory_String_Int32;
			}
		}

		/// <summary>
		/// Double GetNumericValue(Char)
		/// </summary>
		protected static RMethod r_GetNumericValue_Char;
		public static RMethod RGetNumericValue_Char
		{
			get
			{
				if(r_GetNumericValue_Char == null)
				{
					r_GetNumericValue_Char = new(typeof(System.Char), "GetNumericValue", 0, typeof(System.Char));
					r_GetNumericValue_Char.SetBelong(null);
				}
				return r_GetNumericValue_Char;
			}
		}

		/// <summary>
		/// Double GetNumericValue(System.String, Int32)
		/// </summary>
		protected static RMethod r_GetNumericValue_String_Int32;
		public static RMethod RGetNumericValue_String_Int32
		{
			get
			{
				if(r_GetNumericValue_String_Int32 == null)
				{
					r_GetNumericValue_String_Int32 = new(typeof(System.Char), "GetNumericValue", 0, typeof(System.String), typeof(System.Int32));
					r_GetNumericValue_String_Int32.SetBelong(null);
				}
				return r_GetNumericValue_String_Int32;
			}
		}

		/// <summary>
		/// Boolean IsHighSurrogate(Char)
		/// </summary>
		protected static RMethod r_IsHighSurrogate_Char;
		public static RMethod RIsHighSurrogate_Char
		{
			get
			{
				if(r_IsHighSurrogate_Char == null)
				{
					r_IsHighSurrogate_Char = new(typeof(System.Char), "IsHighSurrogate", 0, typeof(System.Char));
					r_IsHighSurrogate_Char.SetBelong(null);
				}
				return r_IsHighSurrogate_Char;
			}
		}

		/// <summary>
		/// Boolean IsHighSurrogate(System.String, Int32)
		/// </summary>
		protected static RMethod r_IsHighSurrogate_String_Int32;
		public static RMethod RIsHighSurrogate_String_Int32
		{
			get
			{
				if(r_IsHighSurrogate_String_Int32 == null)
				{
					r_IsHighSurrogate_String_Int32 = new(typeof(System.Char), "IsHighSurrogate", 0, typeof(System.String), typeof(System.Int32));
					r_IsHighSurrogate_String_Int32.SetBelong(null);
				}
				return r_IsHighSurrogate_String_Int32;
			}
		}

		/// <summary>
		/// Boolean IsLowSurrogate(Char)
		/// </summary>
		protected static RMethod r_IsLowSurrogate_Char;
		public static RMethod RIsLowSurrogate_Char
		{
			get
			{
				if(r_IsLowSurrogate_Char == null)
				{
					r_IsLowSurrogate_Char = new(typeof(System.Char), "IsLowSurrogate", 0, typeof(System.Char));
					r_IsLowSurrogate_Char.SetBelong(null);
				}
				return r_IsLowSurrogate_Char;
			}
		}

		/// <summary>
		/// Boolean IsLowSurrogate(System.String, Int32)
		/// </summary>
		protected static RMethod r_IsLowSurrogate_String_Int32;
		public static RMethod RIsLowSurrogate_String_Int32
		{
			get
			{
				if(r_IsLowSurrogate_String_Int32 == null)
				{
					r_IsLowSurrogate_String_Int32 = new(typeof(System.Char), "IsLowSurrogate", 0, typeof(System.String), typeof(System.Int32));
					r_IsLowSurrogate_String_Int32.SetBelong(null);
				}
				return r_IsLowSurrogate_String_Int32;
			}
		}

		/// <summary>
		/// Boolean IsSurrogatePair(System.String, Int32)
		/// </summary>
		protected static RMethod r_IsSurrogatePair_String_Int32;
		public static RMethod RIsSurrogatePair_String_Int32
		{
			get
			{
				if(r_IsSurrogatePair_String_Int32 == null)
				{
					r_IsSurrogatePair_String_Int32 = new(typeof(System.Char), "IsSurrogatePair", 0, typeof(System.String), typeof(System.Int32));
					r_IsSurrogatePair_String_Int32.SetBelong(null);
				}
				return r_IsSurrogatePair_String_Int32;
			}
		}

		/// <summary>
		/// Boolean IsSurrogatePair(Char, Char)
		/// </summary>
		protected static RMethod r_IsSurrogatePair_Char_Char;
		public static RMethod RIsSurrogatePair_Char_Char
		{
			get
			{
				if(r_IsSurrogatePair_Char_Char == null)
				{
					r_IsSurrogatePair_Char_Char = new(typeof(System.Char), "IsSurrogatePair", 0, typeof(System.Char), typeof(System.Char));
					r_IsSurrogatePair_Char_Char.SetBelong(null);
				}
				return r_IsSurrogatePair_Char_Char;
			}
		}

		/// <summary>
		/// System.String ConvertFromUtf32(Int32)
		/// </summary>
		protected static RMethod r_ConvertFromUtf32_Int32;
		public static RMethod RConvertFromUtf32_Int32
		{
			get
			{
				if(r_ConvertFromUtf32_Int32 == null)
				{
					r_ConvertFromUtf32_Int32 = new(typeof(System.Char), "ConvertFromUtf32", 0, typeof(System.Int32));
					r_ConvertFromUtf32_Int32.SetBelong(null);
				}
				return r_ConvertFromUtf32_Int32;
			}
		}

		/// <summary>
		/// Int32 ConvertToUtf32(Char, Char)
		/// </summary>
		protected static RMethod r_ConvertToUtf32_Char_Char;
		public static RMethod RConvertToUtf32_Char_Char
		{
			get
			{
				if(r_ConvertToUtf32_Char_Char == null)
				{
					r_ConvertToUtf32_Char_Char = new(typeof(System.Char), "ConvertToUtf32", 0, typeof(System.Char), typeof(System.Char));
					r_ConvertToUtf32_Char_Char.SetBelong(null);
				}
				return r_ConvertToUtf32_Char_Char;
			}
		}

		/// <summary>
		/// Int32 ConvertToUtf32(System.String, Int32)
		/// </summary>
		protected static RMethod r_ConvertToUtf32_String_Int32;
		public static RMethod RConvertToUtf32_String_Int32
		{
			get
			{
				if(r_ConvertToUtf32_String_Int32 == null)
				{
					r_ConvertToUtf32_String_Int32 = new(typeof(System.Char), "ConvertToUtf32", 0, typeof(System.String), typeof(System.Int32));
					r_ConvertToUtf32_String_Int32.SetBelong(null);
				}
				return r_ConvertToUtf32_String_Int32;
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


        public RChar() : base("System.Char")
        {
        }

        public RChar(System.Object instance) : base("System.Char")
		{
            SetInstance(instance);
		}

        public RChar(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RChar(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean IsLatin1(System.Char @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RIsLatin1_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsAscii(System.Char @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RIsAscii_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Globalization.UnicodeCategory GetLatin1UnicodeCategory(System.Char @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RGetLatin1UnicodeCategory_Char.Invoke(___genericsType, ___parameters);

            return (System.Globalization.UnicodeCategory)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Char @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 CompareTo(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareTo(System.Char @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RCompareTo_Char.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String ToString(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RToString_Char.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Char Parse(System.String @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RParse_String.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public static System.Boolean TryParse(System.String @s, out System.Char @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @result};
            var ___result = RTryParse_String_Out_Char.Invoke(___genericsType, ___parameters);
			@result = (System.Char)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.Boolean IsDigit(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RIsDigit_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean CheckLetter(System.Globalization.UnicodeCategory @uc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uc};
            var ___result = RCheckLetter_UnicodeCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsLetter(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RIsLetter_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsWhiteSpaceLatin1(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RIsWhiteSpaceLatin1_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsWhiteSpace(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RIsWhiteSpace_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsUpper(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RIsUpper_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsLower(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RIsLower_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean CheckPunctuation(System.Globalization.UnicodeCategory @uc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uc};
            var ___result = RCheckPunctuation_UnicodeCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsPunctuation(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RIsPunctuation_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean CheckLetterOrDigit(System.Globalization.UnicodeCategory @uc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uc};
            var ___result = RCheckLetterOrDigit_UnicodeCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsLetterOrDigit(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RIsLetterOrDigit_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Char ToUpper(System.Char @c, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c, @culture};
            var ___result = RToUpper_Char_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public static System.Char ToUpper(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RToUpper_Char.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public static System.Char ToUpperInvariant(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RToUpperInvariant_Char.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public static System.Char ToLower(System.Char @c, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c, @culture};
            var ___result = RToLower_Char_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public static System.Char ToLower(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RToLower_Char.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public static System.Char ToLowerInvariant(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RToLowerInvariant_Char.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTypeCode.Invoke(___genericsType, ___parameters);

            return (System.TypeCode)___result;
        }


        public virtual System.Boolean System__2__IConvertible__2__ToBoolean(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToBoolean_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Char System__2__IConvertible__2__ToChar(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToChar_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public virtual System.SByte System__2__IConvertible__2__ToSByte(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToSByte_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.SByte)___result;
        }


        public virtual System.Byte System__2__IConvertible__2__ToByte(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToByte_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Byte)___result;
        }


        public virtual System.Int16 System__2__IConvertible__2__ToInt16(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToInt16_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Int16)___result;
        }


        public virtual System.UInt16 System__2__IConvertible__2__ToUInt16(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToUInt16_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.UInt16)___result;
        }


        public virtual System.Int32 System__2__IConvertible__2__ToInt32(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToInt32_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.UInt32 System__2__IConvertible__2__ToUInt32(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToUInt32_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual System.Int64 System__2__IConvertible__2__ToInt64(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToInt64_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.UInt64 System__2__IConvertible__2__ToUInt64(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToUInt64_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public virtual System.Single System__2__IConvertible__2__ToSingle(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToSingle_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Double System__2__IConvertible__2__ToDouble(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToDouble_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Decimal System__2__IConvertible__2__ToDecimal(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToDecimal_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public virtual System.DateTime System__2__IConvertible__2__ToDateTime(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__2__IConvertible__2__ToDateTime_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.Object System__2__IConvertible__2__ToType(System.Type @type, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @provider};
            var ___result = RSystem__2__IConvertible__2__ToType_Type_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Boolean IsControl(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RIsControl_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsControl(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RIsControl_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsDigit(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RIsDigit_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsLetter(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RIsLetter_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsLetterOrDigit(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RIsLetterOrDigit_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsLower(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RIsLower_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean CheckNumber(System.Globalization.UnicodeCategory @uc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uc};
            var ___result = RCheckNumber_UnicodeCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsNumber(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RIsNumber_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsNumber(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RIsNumber_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsPunctuation(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RIsPunctuation_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean CheckSeparator(System.Globalization.UnicodeCategory @uc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uc};
            var ___result = RCheckSeparator_UnicodeCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsSeparatorLatin1(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RIsSeparatorLatin1_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsSeparator(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RIsSeparator_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsSeparator(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RIsSeparator_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsSurrogate(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RIsSurrogate_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsSurrogate(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RIsSurrogate_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean CheckSymbol(System.Globalization.UnicodeCategory @uc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uc};
            var ___result = RCheckSymbol_UnicodeCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsSymbol(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RIsSymbol_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsSymbol(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RIsSymbol_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsUpper(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RIsUpper_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsWhiteSpace(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RIsWhiteSpace_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Globalization.UnicodeCategory GetUnicodeCategory(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RGetUnicodeCategory_Char.Invoke(___genericsType, ___parameters);

            return (System.Globalization.UnicodeCategory)___result;
        }


        public static System.Globalization.UnicodeCategory GetUnicodeCategory(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RGetUnicodeCategory_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Globalization.UnicodeCategory)___result;
        }


        public static System.Double GetNumericValue(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RGetNumericValue_Char.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public static System.Double GetNumericValue(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RGetNumericValue_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public static System.Boolean IsHighSurrogate(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RIsHighSurrogate_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsHighSurrogate(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RIsHighSurrogate_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsLowSurrogate(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RIsLowSurrogate_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsLowSurrogate(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RIsLowSurrogate_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsSurrogatePair(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RIsSurrogatePair_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsSurrogatePair(System.Char @highSurrogate, System.Char @lowSurrogate)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@highSurrogate, @lowSurrogate};
            var ___result = RIsSurrogatePair_Char_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.String ConvertFromUtf32(System.Int32 @utf32)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@utf32};
            var ___result = RConvertFromUtf32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Int32 ConvertToUtf32(System.Char @highSurrogate, System.Char @lowSurrogate)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@highSurrogate, @lowSurrogate};
            var ___result = RConvertToUtf32_Char_Char.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 ConvertToUtf32(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RConvertToUtf32_String_Int32.Invoke(___genericsType, ___parameters);

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
