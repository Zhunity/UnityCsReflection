
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.Char
	/// </summary>
    public partial class RChar : RMember //
    {

		/// <summary>
		/// System.Char m_value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RChar r_Fm_value;
		public virtual Hvak.Editor.Refleaction.RSystem.RChar RFm_value
		{
			get
			{
				if(r_Fm_value == null)
				{
					r_Fm_value = new(this, "m_value");
					r_Fm_value.SetBelong(this.instance);
				}
				return r_Fm_value;
			}
		}

		/// <summary>
		/// System.Char MaxValue
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RChar r_FMaxValue;
		public static Hvak.Editor.Refleaction.RSystem.RChar RFMaxValue
		{
			get
			{
				if(r_FMaxValue == null)
				{
					r_FMaxValue = new(typeof(System.Char), "MaxValue");
					r_FMaxValue.SetBelong(null);
				}
				return r_FMaxValue;
			}
		}

		/// <summary>
		/// System.Char MinValue
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RChar r_FMinValue;
		public static Hvak.Editor.Refleaction.RSystem.RChar RFMinValue
		{
			get
			{
				if(r_FMinValue == null)
				{
					r_FMinValue = new(typeof(System.Char), "MinValue");
					r_FMinValue.SetBelong(null);
				}
				return r_FMinValue;
			}
		}

		/// <summary>
		/// System.Byte[] s_categoryForLatin1
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> r_Fs_categoryForLatin1;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> RFs_categoryForLatin1
		{
			get
			{
				if(r_Fs_categoryForLatin1 == null)
				{
					r_Fs_categoryForLatin1 = new(typeof(System.Char), "s_categoryForLatin1");
					r_Fs_categoryForLatin1.SetBelong(null);
				}
				return r_Fs_categoryForLatin1;
			}
		}

		/// <summary>
		/// System.Int32 UNICODE_PLANE00_END
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FUNICODE_PLANE00_END;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFUNICODE_PLANE00_END
		{
			get
			{
				if(r_FUNICODE_PLANE00_END == null)
				{
					r_FUNICODE_PLANE00_END = new(typeof(System.Char), "UNICODE_PLANE00_END");
					r_FUNICODE_PLANE00_END.SetBelong(null);
				}
				return r_FUNICODE_PLANE00_END;
			}
		}

		/// <summary>
		/// System.Int32 UNICODE_PLANE01_START
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FUNICODE_PLANE01_START;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFUNICODE_PLANE01_START
		{
			get
			{
				if(r_FUNICODE_PLANE01_START == null)
				{
					r_FUNICODE_PLANE01_START = new(typeof(System.Char), "UNICODE_PLANE01_START");
					r_FUNICODE_PLANE01_START.SetBelong(null);
				}
				return r_FUNICODE_PLANE01_START;
			}
		}

		/// <summary>
		/// System.Int32 UNICODE_PLANE16_END
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FUNICODE_PLANE16_END;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFUNICODE_PLANE16_END
		{
			get
			{
				if(r_FUNICODE_PLANE16_END == null)
				{
					r_FUNICODE_PLANE16_END = new(typeof(System.Char), "UNICODE_PLANE16_END");
					r_FUNICODE_PLANE16_END.SetBelong(null);
				}
				return r_FUNICODE_PLANE16_END;
			}
		}

		/// <summary>
		/// System.Int32 HIGH_SURROGATE_START
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FHIGH_SURROGATE_START;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFHIGH_SURROGATE_START
		{
			get
			{
				if(r_FHIGH_SURROGATE_START == null)
				{
					r_FHIGH_SURROGATE_START = new(typeof(System.Char), "HIGH_SURROGATE_START");
					r_FHIGH_SURROGATE_START.SetBelong(null);
				}
				return r_FHIGH_SURROGATE_START;
			}
		}

		/// <summary>
		/// System.Int32 LOW_SURROGATE_END
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FLOW_SURROGATE_END;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFLOW_SURROGATE_END
		{
			get
			{
				if(r_FLOW_SURROGATE_END == null)
				{
					r_FLOW_SURROGATE_END = new(typeof(System.Char), "LOW_SURROGATE_END");
					r_FLOW_SURROGATE_END.SetBelong(null);
				}
				return r_FLOW_SURROGATE_END;
			}
		}

		/// <summary>
		/// Boolean IsLatin1(Char)
		/// </summary>
		protected static RMethod r_MIsLatin1_Char;
		public static RMethod RMIsLatin1_Char
		{
			get
			{
				if(r_MIsLatin1_Char == null)
				{
					r_MIsLatin1_Char = new(typeof(System.Char), "IsLatin1", 0, typeof(System.Char));
					r_MIsLatin1_Char.SetBelong(null);
				}
				return r_MIsLatin1_Char;
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
					r_MIsAscii_Char = new(typeof(System.Char), "IsAscii", 0, typeof(System.Char));
					r_MIsAscii_Char.SetBelong(null);
				}
				return r_MIsAscii_Char;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory GetLatin1UnicodeCategory(Char)
		/// </summary>
		protected static RMethod r_MGetLatin1UnicodeCategory_Char;
		public static RMethod RMGetLatin1UnicodeCategory_Char
		{
			get
			{
				if(r_MGetLatin1UnicodeCategory_Char == null)
				{
					r_MGetLatin1UnicodeCategory_Char = new(typeof(System.Char), "GetLatin1UnicodeCategory", 0, typeof(System.Char));
					r_MGetLatin1UnicodeCategory_Char.SetBelong(null);
				}
				return r_MGetLatin1UnicodeCategory_Char;
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
		/// Boolean Equals(Char)
		/// </summary>
		protected RMethod r_MEquals_Char;
		public virtual RMethod RMEquals_Char
		{
			get
			{
				if(r_MEquals_Char == null)
				{
					r_MEquals_Char = new(this, "Equals", 0, typeof(System.Char));
					r_MEquals_Char.SetBelong(this.instance);
				}
				return r_MEquals_Char;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Object)
		/// </summary>
		protected RMethod r_MCompareTo_Object;
		public virtual RMethod RMCompareTo_Object
		{
			get
			{
				if(r_MCompareTo_Object == null)
				{
					r_MCompareTo_Object = new(this, "CompareTo", 0, typeof(System.Object));
					r_MCompareTo_Object.SetBelong(this.instance);
				}
				return r_MCompareTo_Object;
			}
		}

		/// <summary>
		/// Int32 CompareTo(Char)
		/// </summary>
		protected RMethod r_MCompareTo_Char;
		public virtual RMethod RMCompareTo_Char
		{
			get
			{
				if(r_MCompareTo_Char == null)
				{
					r_MCompareTo_Char = new(this, "CompareTo", 0, typeof(System.Char));
					r_MCompareTo_Char.SetBelong(this.instance);
				}
				return r_MCompareTo_Char;
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
		/// System.String ToString(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_IFormatProvider;
		public virtual RMethod RMToString_IFormatProvider
		{
			get
			{
				if(r_MToString_IFormatProvider == null)
				{
					r_MToString_IFormatProvider = new(this, "ToString", 0, typeof(System.IFormatProvider));
					r_MToString_IFormatProvider.SetBelong(this.instance);
				}
				return r_MToString_IFormatProvider;
			}
		}

		/// <summary>
		/// System.String ToString(Char)
		/// </summary>
		protected static RMethod r_MToString_Char;
		public static RMethod RMToString_Char
		{
			get
			{
				if(r_MToString_Char == null)
				{
					r_MToString_Char = new(typeof(System.Char), "ToString", 0, typeof(System.Char));
					r_MToString_Char.SetBelong(null);
				}
				return r_MToString_Char;
			}
		}

		/// <summary>
		/// Char Parse(System.String)
		/// </summary>
		protected static RMethod r_MParse_String;
		public static RMethod RMParse_String
		{
			get
			{
				if(r_MParse_String == null)
				{
					r_MParse_String = new(typeof(System.Char), "Parse", 0, typeof(System.String));
					r_MParse_String.SetBelong(null);
				}
				return r_MParse_String;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.String, Char ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_String_Out_Char;
		public static RMethod RMTryParse_String_Out_Char
		{
			get
			{
				if(r_MTryParse_String_Out_Char == null)
				{
					r_MTryParse_String_Out_Char = new(typeof(System.Char), "TryParse", 0, typeof(System.String), typeof(System.Char).MakeByRefType());
					r_MTryParse_String_Out_Char.SetBelong(null);
				}
				return r_MTryParse_String_Out_Char;
			}
		}

		/// <summary>
		/// Boolean IsDigit(Char)
		/// </summary>
		protected static RMethod r_MIsDigit_Char;
		public static RMethod RMIsDigit_Char
		{
			get
			{
				if(r_MIsDigit_Char == null)
				{
					r_MIsDigit_Char = new(typeof(System.Char), "IsDigit", 0, typeof(System.Char));
					r_MIsDigit_Char.SetBelong(null);
				}
				return r_MIsDigit_Char;
			}
		}

		/// <summary>
		/// Boolean CheckLetter(System.Globalization.UnicodeCategory)
		/// </summary>
		protected static RMethod r_MCheckLetter_UnicodeCategory;
		public static RMethod RMCheckLetter_UnicodeCategory
		{
			get
			{
				if(r_MCheckLetter_UnicodeCategory == null)
				{
					r_MCheckLetter_UnicodeCategory = new(typeof(System.Char), "CheckLetter", 0, typeof(System.Globalization.UnicodeCategory));
					r_MCheckLetter_UnicodeCategory.SetBelong(null);
				}
				return r_MCheckLetter_UnicodeCategory;
			}
		}

		/// <summary>
		/// Boolean IsLetter(Char)
		/// </summary>
		protected static RMethod r_MIsLetter_Char;
		public static RMethod RMIsLetter_Char
		{
			get
			{
				if(r_MIsLetter_Char == null)
				{
					r_MIsLetter_Char = new(typeof(System.Char), "IsLetter", 0, typeof(System.Char));
					r_MIsLetter_Char.SetBelong(null);
				}
				return r_MIsLetter_Char;
			}
		}

		/// <summary>
		/// Boolean IsWhiteSpaceLatin1(Char)
		/// </summary>
		protected static RMethod r_MIsWhiteSpaceLatin1_Char;
		public static RMethod RMIsWhiteSpaceLatin1_Char
		{
			get
			{
				if(r_MIsWhiteSpaceLatin1_Char == null)
				{
					r_MIsWhiteSpaceLatin1_Char = new(typeof(System.Char), "IsWhiteSpaceLatin1", 0, typeof(System.Char));
					r_MIsWhiteSpaceLatin1_Char.SetBelong(null);
				}
				return r_MIsWhiteSpaceLatin1_Char;
			}
		}

		/// <summary>
		/// Boolean IsWhiteSpace(Char)
		/// </summary>
		protected static RMethod r_MIsWhiteSpace_Char;
		public static RMethod RMIsWhiteSpace_Char
		{
			get
			{
				if(r_MIsWhiteSpace_Char == null)
				{
					r_MIsWhiteSpace_Char = new(typeof(System.Char), "IsWhiteSpace", 0, typeof(System.Char));
					r_MIsWhiteSpace_Char.SetBelong(null);
				}
				return r_MIsWhiteSpace_Char;
			}
		}

		/// <summary>
		/// Boolean IsUpper(Char)
		/// </summary>
		protected static RMethod r_MIsUpper_Char;
		public static RMethod RMIsUpper_Char
		{
			get
			{
				if(r_MIsUpper_Char == null)
				{
					r_MIsUpper_Char = new(typeof(System.Char), "IsUpper", 0, typeof(System.Char));
					r_MIsUpper_Char.SetBelong(null);
				}
				return r_MIsUpper_Char;
			}
		}

		/// <summary>
		/// Boolean IsLower(Char)
		/// </summary>
		protected static RMethod r_MIsLower_Char;
		public static RMethod RMIsLower_Char
		{
			get
			{
				if(r_MIsLower_Char == null)
				{
					r_MIsLower_Char = new(typeof(System.Char), "IsLower", 0, typeof(System.Char));
					r_MIsLower_Char.SetBelong(null);
				}
				return r_MIsLower_Char;
			}
		}

		/// <summary>
		/// Boolean CheckPunctuation(System.Globalization.UnicodeCategory)
		/// </summary>
		protected static RMethod r_MCheckPunctuation_UnicodeCategory;
		public static RMethod RMCheckPunctuation_UnicodeCategory
		{
			get
			{
				if(r_MCheckPunctuation_UnicodeCategory == null)
				{
					r_MCheckPunctuation_UnicodeCategory = new(typeof(System.Char), "CheckPunctuation", 0, typeof(System.Globalization.UnicodeCategory));
					r_MCheckPunctuation_UnicodeCategory.SetBelong(null);
				}
				return r_MCheckPunctuation_UnicodeCategory;
			}
		}

		/// <summary>
		/// Boolean IsPunctuation(Char)
		/// </summary>
		protected static RMethod r_MIsPunctuation_Char;
		public static RMethod RMIsPunctuation_Char
		{
			get
			{
				if(r_MIsPunctuation_Char == null)
				{
					r_MIsPunctuation_Char = new(typeof(System.Char), "IsPunctuation", 0, typeof(System.Char));
					r_MIsPunctuation_Char.SetBelong(null);
				}
				return r_MIsPunctuation_Char;
			}
		}

		/// <summary>
		/// Boolean CheckLetterOrDigit(System.Globalization.UnicodeCategory)
		/// </summary>
		protected static RMethod r_MCheckLetterOrDigit_UnicodeCategory;
		public static RMethod RMCheckLetterOrDigit_UnicodeCategory
		{
			get
			{
				if(r_MCheckLetterOrDigit_UnicodeCategory == null)
				{
					r_MCheckLetterOrDigit_UnicodeCategory = new(typeof(System.Char), "CheckLetterOrDigit", 0, typeof(System.Globalization.UnicodeCategory));
					r_MCheckLetterOrDigit_UnicodeCategory.SetBelong(null);
				}
				return r_MCheckLetterOrDigit_UnicodeCategory;
			}
		}

		/// <summary>
		/// Boolean IsLetterOrDigit(Char)
		/// </summary>
		protected static RMethod r_MIsLetterOrDigit_Char;
		public static RMethod RMIsLetterOrDigit_Char
		{
			get
			{
				if(r_MIsLetterOrDigit_Char == null)
				{
					r_MIsLetterOrDigit_Char = new(typeof(System.Char), "IsLetterOrDigit", 0, typeof(System.Char));
					r_MIsLetterOrDigit_Char.SetBelong(null);
				}
				return r_MIsLetterOrDigit_Char;
			}
		}

		/// <summary>
		/// Char ToUpper(Char, System.Globalization.CultureInfo)
		/// </summary>
		protected static RMethod r_MToUpper_Char_CultureInfo;
		public static RMethod RMToUpper_Char_CultureInfo
		{
			get
			{
				if(r_MToUpper_Char_CultureInfo == null)
				{
					r_MToUpper_Char_CultureInfo = new(typeof(System.Char), "ToUpper", 0, typeof(System.Char), typeof(System.Globalization.CultureInfo));
					r_MToUpper_Char_CultureInfo.SetBelong(null);
				}
				return r_MToUpper_Char_CultureInfo;
			}
		}

		/// <summary>
		/// Char ToUpper(Char)
		/// </summary>
		protected static RMethod r_MToUpper_Char;
		public static RMethod RMToUpper_Char
		{
			get
			{
				if(r_MToUpper_Char == null)
				{
					r_MToUpper_Char = new(typeof(System.Char), "ToUpper", 0, typeof(System.Char));
					r_MToUpper_Char.SetBelong(null);
				}
				return r_MToUpper_Char;
			}
		}

		/// <summary>
		/// Char ToUpperInvariant(Char)
		/// </summary>
		protected static RMethod r_MToUpperInvariant_Char;
		public static RMethod RMToUpperInvariant_Char
		{
			get
			{
				if(r_MToUpperInvariant_Char == null)
				{
					r_MToUpperInvariant_Char = new(typeof(System.Char), "ToUpperInvariant", 0, typeof(System.Char));
					r_MToUpperInvariant_Char.SetBelong(null);
				}
				return r_MToUpperInvariant_Char;
			}
		}

		/// <summary>
		/// Char ToLower(Char, System.Globalization.CultureInfo)
		/// </summary>
		protected static RMethod r_MToLower_Char_CultureInfo;
		public static RMethod RMToLower_Char_CultureInfo
		{
			get
			{
				if(r_MToLower_Char_CultureInfo == null)
				{
					r_MToLower_Char_CultureInfo = new(typeof(System.Char), "ToLower", 0, typeof(System.Char), typeof(System.Globalization.CultureInfo));
					r_MToLower_Char_CultureInfo.SetBelong(null);
				}
				return r_MToLower_Char_CultureInfo;
			}
		}

		/// <summary>
		/// Char ToLower(Char)
		/// </summary>
		protected static RMethod r_MToLower_Char;
		public static RMethod RMToLower_Char
		{
			get
			{
				if(r_MToLower_Char == null)
				{
					r_MToLower_Char = new(typeof(System.Char), "ToLower", 0, typeof(System.Char));
					r_MToLower_Char.SetBelong(null);
				}
				return r_MToLower_Char;
			}
		}

		/// <summary>
		/// Char ToLowerInvariant(Char)
		/// </summary>
		protected static RMethod r_MToLowerInvariant_Char;
		public static RMethod RMToLowerInvariant_Char
		{
			get
			{
				if(r_MToLowerInvariant_Char == null)
				{
					r_MToLowerInvariant_Char = new(typeof(System.Char), "ToLowerInvariant", 0, typeof(System.Char));
					r_MToLowerInvariant_Char.SetBelong(null);
				}
				return r_MToLowerInvariant_Char;
			}
		}

		/// <summary>
		/// System.TypeCode GetTypeCode()
		/// </summary>
		protected RMethod r_MGetTypeCode;
		public virtual RMethod RMGetTypeCode
		{
			get
			{
				if(r_MGetTypeCode == null)
				{
					r_MGetTypeCode = new(this, "GetTypeCode", 0);
					r_MGetTypeCode.SetBelong(this.instance);
				}
				return r_MGetTypeCode;
			}
		}

		/// <summary>
		/// Boolean System.IConvertible.ToBoolean(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MSystem__2__IConvertible__2__ToBoolean_IFormatProvider;
		public virtual RMethod RMSystem__2__IConvertible__2__ToBoolean_IFormatProvider
		{
			get
			{
				if(r_MSystem__2__IConvertible__2__ToBoolean_IFormatProvider == null)
				{
					r_MSystem__2__IConvertible__2__ToBoolean_IFormatProvider = new(this, "System.IConvertible.ToBoolean", 0, typeof(System.IFormatProvider));
					r_MSystem__2__IConvertible__2__ToBoolean_IFormatProvider.SetBelong(this.instance);
				}
				return r_MSystem__2__IConvertible__2__ToBoolean_IFormatProvider;
			}
		}

		/// <summary>
		/// Char System.IConvertible.ToChar(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MSystem__2__IConvertible__2__ToChar_IFormatProvider;
		public virtual RMethod RMSystem__2__IConvertible__2__ToChar_IFormatProvider
		{
			get
			{
				if(r_MSystem__2__IConvertible__2__ToChar_IFormatProvider == null)
				{
					r_MSystem__2__IConvertible__2__ToChar_IFormatProvider = new(this, "System.IConvertible.ToChar", 0, typeof(System.IFormatProvider));
					r_MSystem__2__IConvertible__2__ToChar_IFormatProvider.SetBelong(this.instance);
				}
				return r_MSystem__2__IConvertible__2__ToChar_IFormatProvider;
			}
		}

		/// <summary>
		/// SByte System.IConvertible.ToSByte(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MSystem__2__IConvertible__2__ToSByte_IFormatProvider;
		public virtual RMethod RMSystem__2__IConvertible__2__ToSByte_IFormatProvider
		{
			get
			{
				if(r_MSystem__2__IConvertible__2__ToSByte_IFormatProvider == null)
				{
					r_MSystem__2__IConvertible__2__ToSByte_IFormatProvider = new(this, "System.IConvertible.ToSByte", 0, typeof(System.IFormatProvider));
					r_MSystem__2__IConvertible__2__ToSByte_IFormatProvider.SetBelong(this.instance);
				}
				return r_MSystem__2__IConvertible__2__ToSByte_IFormatProvider;
			}
		}

		/// <summary>
		/// Byte System.IConvertible.ToByte(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MSystem__2__IConvertible__2__ToByte_IFormatProvider;
		public virtual RMethod RMSystem__2__IConvertible__2__ToByte_IFormatProvider
		{
			get
			{
				if(r_MSystem__2__IConvertible__2__ToByte_IFormatProvider == null)
				{
					r_MSystem__2__IConvertible__2__ToByte_IFormatProvider = new(this, "System.IConvertible.ToByte", 0, typeof(System.IFormatProvider));
					r_MSystem__2__IConvertible__2__ToByte_IFormatProvider.SetBelong(this.instance);
				}
				return r_MSystem__2__IConvertible__2__ToByte_IFormatProvider;
			}
		}

		/// <summary>
		/// Int16 System.IConvertible.ToInt16(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MSystem__2__IConvertible__2__ToInt16_IFormatProvider;
		public virtual RMethod RMSystem__2__IConvertible__2__ToInt16_IFormatProvider
		{
			get
			{
				if(r_MSystem__2__IConvertible__2__ToInt16_IFormatProvider == null)
				{
					r_MSystem__2__IConvertible__2__ToInt16_IFormatProvider = new(this, "System.IConvertible.ToInt16", 0, typeof(System.IFormatProvider));
					r_MSystem__2__IConvertible__2__ToInt16_IFormatProvider.SetBelong(this.instance);
				}
				return r_MSystem__2__IConvertible__2__ToInt16_IFormatProvider;
			}
		}

		/// <summary>
		/// UInt16 System.IConvertible.ToUInt16(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MSystem__2__IConvertible__2__ToUInt16_IFormatProvider;
		public virtual RMethod RMSystem__2__IConvertible__2__ToUInt16_IFormatProvider
		{
			get
			{
				if(r_MSystem__2__IConvertible__2__ToUInt16_IFormatProvider == null)
				{
					r_MSystem__2__IConvertible__2__ToUInt16_IFormatProvider = new(this, "System.IConvertible.ToUInt16", 0, typeof(System.IFormatProvider));
					r_MSystem__2__IConvertible__2__ToUInt16_IFormatProvider.SetBelong(this.instance);
				}
				return r_MSystem__2__IConvertible__2__ToUInt16_IFormatProvider;
			}
		}

		/// <summary>
		/// Int32 System.IConvertible.ToInt32(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MSystem__2__IConvertible__2__ToInt32_IFormatProvider;
		public virtual RMethod RMSystem__2__IConvertible__2__ToInt32_IFormatProvider
		{
			get
			{
				if(r_MSystem__2__IConvertible__2__ToInt32_IFormatProvider == null)
				{
					r_MSystem__2__IConvertible__2__ToInt32_IFormatProvider = new(this, "System.IConvertible.ToInt32", 0, typeof(System.IFormatProvider));
					r_MSystem__2__IConvertible__2__ToInt32_IFormatProvider.SetBelong(this.instance);
				}
				return r_MSystem__2__IConvertible__2__ToInt32_IFormatProvider;
			}
		}

		/// <summary>
		/// UInt32 System.IConvertible.ToUInt32(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MSystem__2__IConvertible__2__ToUInt32_IFormatProvider;
		public virtual RMethod RMSystem__2__IConvertible__2__ToUInt32_IFormatProvider
		{
			get
			{
				if(r_MSystem__2__IConvertible__2__ToUInt32_IFormatProvider == null)
				{
					r_MSystem__2__IConvertible__2__ToUInt32_IFormatProvider = new(this, "System.IConvertible.ToUInt32", 0, typeof(System.IFormatProvider));
					r_MSystem__2__IConvertible__2__ToUInt32_IFormatProvider.SetBelong(this.instance);
				}
				return r_MSystem__2__IConvertible__2__ToUInt32_IFormatProvider;
			}
		}

		/// <summary>
		/// Int64 System.IConvertible.ToInt64(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MSystem__2__IConvertible__2__ToInt64_IFormatProvider;
		public virtual RMethod RMSystem__2__IConvertible__2__ToInt64_IFormatProvider
		{
			get
			{
				if(r_MSystem__2__IConvertible__2__ToInt64_IFormatProvider == null)
				{
					r_MSystem__2__IConvertible__2__ToInt64_IFormatProvider = new(this, "System.IConvertible.ToInt64", 0, typeof(System.IFormatProvider));
					r_MSystem__2__IConvertible__2__ToInt64_IFormatProvider.SetBelong(this.instance);
				}
				return r_MSystem__2__IConvertible__2__ToInt64_IFormatProvider;
			}
		}

		/// <summary>
		/// UInt64 System.IConvertible.ToUInt64(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MSystem__2__IConvertible__2__ToUInt64_IFormatProvider;
		public virtual RMethod RMSystem__2__IConvertible__2__ToUInt64_IFormatProvider
		{
			get
			{
				if(r_MSystem__2__IConvertible__2__ToUInt64_IFormatProvider == null)
				{
					r_MSystem__2__IConvertible__2__ToUInt64_IFormatProvider = new(this, "System.IConvertible.ToUInt64", 0, typeof(System.IFormatProvider));
					r_MSystem__2__IConvertible__2__ToUInt64_IFormatProvider.SetBelong(this.instance);
				}
				return r_MSystem__2__IConvertible__2__ToUInt64_IFormatProvider;
			}
		}

		/// <summary>
		/// Single System.IConvertible.ToSingle(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MSystem__2__IConvertible__2__ToSingle_IFormatProvider;
		public virtual RMethod RMSystem__2__IConvertible__2__ToSingle_IFormatProvider
		{
			get
			{
				if(r_MSystem__2__IConvertible__2__ToSingle_IFormatProvider == null)
				{
					r_MSystem__2__IConvertible__2__ToSingle_IFormatProvider = new(this, "System.IConvertible.ToSingle", 0, typeof(System.IFormatProvider));
					r_MSystem__2__IConvertible__2__ToSingle_IFormatProvider.SetBelong(this.instance);
				}
				return r_MSystem__2__IConvertible__2__ToSingle_IFormatProvider;
			}
		}

		/// <summary>
		/// Double System.IConvertible.ToDouble(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MSystem__2__IConvertible__2__ToDouble_IFormatProvider;
		public virtual RMethod RMSystem__2__IConvertible__2__ToDouble_IFormatProvider
		{
			get
			{
				if(r_MSystem__2__IConvertible__2__ToDouble_IFormatProvider == null)
				{
					r_MSystem__2__IConvertible__2__ToDouble_IFormatProvider = new(this, "System.IConvertible.ToDouble", 0, typeof(System.IFormatProvider));
					r_MSystem__2__IConvertible__2__ToDouble_IFormatProvider.SetBelong(this.instance);
				}
				return r_MSystem__2__IConvertible__2__ToDouble_IFormatProvider;
			}
		}

		/// <summary>
		/// System.Decimal System.IConvertible.ToDecimal(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MSystem__2__IConvertible__2__ToDecimal_IFormatProvider;
		public virtual RMethod RMSystem__2__IConvertible__2__ToDecimal_IFormatProvider
		{
			get
			{
				if(r_MSystem__2__IConvertible__2__ToDecimal_IFormatProvider == null)
				{
					r_MSystem__2__IConvertible__2__ToDecimal_IFormatProvider = new(this, "System.IConvertible.ToDecimal", 0, typeof(System.IFormatProvider));
					r_MSystem__2__IConvertible__2__ToDecimal_IFormatProvider.SetBelong(this.instance);
				}
				return r_MSystem__2__IConvertible__2__ToDecimal_IFormatProvider;
			}
		}

		/// <summary>
		/// System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MSystem__2__IConvertible__2__ToDateTime_IFormatProvider;
		public virtual RMethod RMSystem__2__IConvertible__2__ToDateTime_IFormatProvider
		{
			get
			{
				if(r_MSystem__2__IConvertible__2__ToDateTime_IFormatProvider == null)
				{
					r_MSystem__2__IConvertible__2__ToDateTime_IFormatProvider = new(this, "System.IConvertible.ToDateTime", 0, typeof(System.IFormatProvider));
					r_MSystem__2__IConvertible__2__ToDateTime_IFormatProvider.SetBelong(this.instance);
				}
				return r_MSystem__2__IConvertible__2__ToDateTime_IFormatProvider;
			}
		}

		/// <summary>
		/// System.Object System.IConvertible.ToType(System.Type, System.IFormatProvider)
		/// </summary>
		protected RMethod r_MSystem__2__IConvertible__2__ToType_Type_IFormatProvider;
		public virtual RMethod RMSystem__2__IConvertible__2__ToType_Type_IFormatProvider
		{
			get
			{
				if(r_MSystem__2__IConvertible__2__ToType_Type_IFormatProvider == null)
				{
					r_MSystem__2__IConvertible__2__ToType_Type_IFormatProvider = new(this, "System.IConvertible.ToType", 0, typeof(System.Type), typeof(System.IFormatProvider));
					r_MSystem__2__IConvertible__2__ToType_Type_IFormatProvider.SetBelong(this.instance);
				}
				return r_MSystem__2__IConvertible__2__ToType_Type_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean IsControl(Char)
		/// </summary>
		protected static RMethod r_MIsControl_Char;
		public static RMethod RMIsControl_Char
		{
			get
			{
				if(r_MIsControl_Char == null)
				{
					r_MIsControl_Char = new(typeof(System.Char), "IsControl", 0, typeof(System.Char));
					r_MIsControl_Char.SetBelong(null);
				}
				return r_MIsControl_Char;
			}
		}

		/// <summary>
		/// Boolean IsControl(System.String, Int32)
		/// </summary>
		protected static RMethod r_MIsControl_String_Int32;
		public static RMethod RMIsControl_String_Int32
		{
			get
			{
				if(r_MIsControl_String_Int32 == null)
				{
					r_MIsControl_String_Int32 = new(typeof(System.Char), "IsControl", 0, typeof(System.String), typeof(System.Int32));
					r_MIsControl_String_Int32.SetBelong(null);
				}
				return r_MIsControl_String_Int32;
			}
		}

		/// <summary>
		/// Boolean IsDigit(System.String, Int32)
		/// </summary>
		protected static RMethod r_MIsDigit_String_Int32;
		public static RMethod RMIsDigit_String_Int32
		{
			get
			{
				if(r_MIsDigit_String_Int32 == null)
				{
					r_MIsDigit_String_Int32 = new(typeof(System.Char), "IsDigit", 0, typeof(System.String), typeof(System.Int32));
					r_MIsDigit_String_Int32.SetBelong(null);
				}
				return r_MIsDigit_String_Int32;
			}
		}

		/// <summary>
		/// Boolean IsLetter(System.String, Int32)
		/// </summary>
		protected static RMethod r_MIsLetter_String_Int32;
		public static RMethod RMIsLetter_String_Int32
		{
			get
			{
				if(r_MIsLetter_String_Int32 == null)
				{
					r_MIsLetter_String_Int32 = new(typeof(System.Char), "IsLetter", 0, typeof(System.String), typeof(System.Int32));
					r_MIsLetter_String_Int32.SetBelong(null);
				}
				return r_MIsLetter_String_Int32;
			}
		}

		/// <summary>
		/// Boolean IsLetterOrDigit(System.String, Int32)
		/// </summary>
		protected static RMethod r_MIsLetterOrDigit_String_Int32;
		public static RMethod RMIsLetterOrDigit_String_Int32
		{
			get
			{
				if(r_MIsLetterOrDigit_String_Int32 == null)
				{
					r_MIsLetterOrDigit_String_Int32 = new(typeof(System.Char), "IsLetterOrDigit", 0, typeof(System.String), typeof(System.Int32));
					r_MIsLetterOrDigit_String_Int32.SetBelong(null);
				}
				return r_MIsLetterOrDigit_String_Int32;
			}
		}

		/// <summary>
		/// Boolean IsLower(System.String, Int32)
		/// </summary>
		protected static RMethod r_MIsLower_String_Int32;
		public static RMethod RMIsLower_String_Int32
		{
			get
			{
				if(r_MIsLower_String_Int32 == null)
				{
					r_MIsLower_String_Int32 = new(typeof(System.Char), "IsLower", 0, typeof(System.String), typeof(System.Int32));
					r_MIsLower_String_Int32.SetBelong(null);
				}
				return r_MIsLower_String_Int32;
			}
		}

		/// <summary>
		/// Boolean CheckNumber(System.Globalization.UnicodeCategory)
		/// </summary>
		protected static RMethod r_MCheckNumber_UnicodeCategory;
		public static RMethod RMCheckNumber_UnicodeCategory
		{
			get
			{
				if(r_MCheckNumber_UnicodeCategory == null)
				{
					r_MCheckNumber_UnicodeCategory = new(typeof(System.Char), "CheckNumber", 0, typeof(System.Globalization.UnicodeCategory));
					r_MCheckNumber_UnicodeCategory.SetBelong(null);
				}
				return r_MCheckNumber_UnicodeCategory;
			}
		}

		/// <summary>
		/// Boolean IsNumber(Char)
		/// </summary>
		protected static RMethod r_MIsNumber_Char;
		public static RMethod RMIsNumber_Char
		{
			get
			{
				if(r_MIsNumber_Char == null)
				{
					r_MIsNumber_Char = new(typeof(System.Char), "IsNumber", 0, typeof(System.Char));
					r_MIsNumber_Char.SetBelong(null);
				}
				return r_MIsNumber_Char;
			}
		}

		/// <summary>
		/// Boolean IsNumber(System.String, Int32)
		/// </summary>
		protected static RMethod r_MIsNumber_String_Int32;
		public static RMethod RMIsNumber_String_Int32
		{
			get
			{
				if(r_MIsNumber_String_Int32 == null)
				{
					r_MIsNumber_String_Int32 = new(typeof(System.Char), "IsNumber", 0, typeof(System.String), typeof(System.Int32));
					r_MIsNumber_String_Int32.SetBelong(null);
				}
				return r_MIsNumber_String_Int32;
			}
		}

		/// <summary>
		/// Boolean IsPunctuation(System.String, Int32)
		/// </summary>
		protected static RMethod r_MIsPunctuation_String_Int32;
		public static RMethod RMIsPunctuation_String_Int32
		{
			get
			{
				if(r_MIsPunctuation_String_Int32 == null)
				{
					r_MIsPunctuation_String_Int32 = new(typeof(System.Char), "IsPunctuation", 0, typeof(System.String), typeof(System.Int32));
					r_MIsPunctuation_String_Int32.SetBelong(null);
				}
				return r_MIsPunctuation_String_Int32;
			}
		}

		/// <summary>
		/// Boolean CheckSeparator(System.Globalization.UnicodeCategory)
		/// </summary>
		protected static RMethod r_MCheckSeparator_UnicodeCategory;
		public static RMethod RMCheckSeparator_UnicodeCategory
		{
			get
			{
				if(r_MCheckSeparator_UnicodeCategory == null)
				{
					r_MCheckSeparator_UnicodeCategory = new(typeof(System.Char), "CheckSeparator", 0, typeof(System.Globalization.UnicodeCategory));
					r_MCheckSeparator_UnicodeCategory.SetBelong(null);
				}
				return r_MCheckSeparator_UnicodeCategory;
			}
		}

		/// <summary>
		/// Boolean IsSeparatorLatin1(Char)
		/// </summary>
		protected static RMethod r_MIsSeparatorLatin1_Char;
		public static RMethod RMIsSeparatorLatin1_Char
		{
			get
			{
				if(r_MIsSeparatorLatin1_Char == null)
				{
					r_MIsSeparatorLatin1_Char = new(typeof(System.Char), "IsSeparatorLatin1", 0, typeof(System.Char));
					r_MIsSeparatorLatin1_Char.SetBelong(null);
				}
				return r_MIsSeparatorLatin1_Char;
			}
		}

		/// <summary>
		/// Boolean IsSeparator(Char)
		/// </summary>
		protected static RMethod r_MIsSeparator_Char;
		public static RMethod RMIsSeparator_Char
		{
			get
			{
				if(r_MIsSeparator_Char == null)
				{
					r_MIsSeparator_Char = new(typeof(System.Char), "IsSeparator", 0, typeof(System.Char));
					r_MIsSeparator_Char.SetBelong(null);
				}
				return r_MIsSeparator_Char;
			}
		}

		/// <summary>
		/// Boolean IsSeparator(System.String, Int32)
		/// </summary>
		protected static RMethod r_MIsSeparator_String_Int32;
		public static RMethod RMIsSeparator_String_Int32
		{
			get
			{
				if(r_MIsSeparator_String_Int32 == null)
				{
					r_MIsSeparator_String_Int32 = new(typeof(System.Char), "IsSeparator", 0, typeof(System.String), typeof(System.Int32));
					r_MIsSeparator_String_Int32.SetBelong(null);
				}
				return r_MIsSeparator_String_Int32;
			}
		}

		/// <summary>
		/// Boolean IsSurrogate(Char)
		/// </summary>
		protected static RMethod r_MIsSurrogate_Char;
		public static RMethod RMIsSurrogate_Char
		{
			get
			{
				if(r_MIsSurrogate_Char == null)
				{
					r_MIsSurrogate_Char = new(typeof(System.Char), "IsSurrogate", 0, typeof(System.Char));
					r_MIsSurrogate_Char.SetBelong(null);
				}
				return r_MIsSurrogate_Char;
			}
		}

		/// <summary>
		/// Boolean IsSurrogate(System.String, Int32)
		/// </summary>
		protected static RMethod r_MIsSurrogate_String_Int32;
		public static RMethod RMIsSurrogate_String_Int32
		{
			get
			{
				if(r_MIsSurrogate_String_Int32 == null)
				{
					r_MIsSurrogate_String_Int32 = new(typeof(System.Char), "IsSurrogate", 0, typeof(System.String), typeof(System.Int32));
					r_MIsSurrogate_String_Int32.SetBelong(null);
				}
				return r_MIsSurrogate_String_Int32;
			}
		}

		/// <summary>
		/// Boolean CheckSymbol(System.Globalization.UnicodeCategory)
		/// </summary>
		protected static RMethod r_MCheckSymbol_UnicodeCategory;
		public static RMethod RMCheckSymbol_UnicodeCategory
		{
			get
			{
				if(r_MCheckSymbol_UnicodeCategory == null)
				{
					r_MCheckSymbol_UnicodeCategory = new(typeof(System.Char), "CheckSymbol", 0, typeof(System.Globalization.UnicodeCategory));
					r_MCheckSymbol_UnicodeCategory.SetBelong(null);
				}
				return r_MCheckSymbol_UnicodeCategory;
			}
		}

		/// <summary>
		/// Boolean IsSymbol(Char)
		/// </summary>
		protected static RMethod r_MIsSymbol_Char;
		public static RMethod RMIsSymbol_Char
		{
			get
			{
				if(r_MIsSymbol_Char == null)
				{
					r_MIsSymbol_Char = new(typeof(System.Char), "IsSymbol", 0, typeof(System.Char));
					r_MIsSymbol_Char.SetBelong(null);
				}
				return r_MIsSymbol_Char;
			}
		}

		/// <summary>
		/// Boolean IsSymbol(System.String, Int32)
		/// </summary>
		protected static RMethod r_MIsSymbol_String_Int32;
		public static RMethod RMIsSymbol_String_Int32
		{
			get
			{
				if(r_MIsSymbol_String_Int32 == null)
				{
					r_MIsSymbol_String_Int32 = new(typeof(System.Char), "IsSymbol", 0, typeof(System.String), typeof(System.Int32));
					r_MIsSymbol_String_Int32.SetBelong(null);
				}
				return r_MIsSymbol_String_Int32;
			}
		}

		/// <summary>
		/// Boolean IsUpper(System.String, Int32)
		/// </summary>
		protected static RMethod r_MIsUpper_String_Int32;
		public static RMethod RMIsUpper_String_Int32
		{
			get
			{
				if(r_MIsUpper_String_Int32 == null)
				{
					r_MIsUpper_String_Int32 = new(typeof(System.Char), "IsUpper", 0, typeof(System.String), typeof(System.Int32));
					r_MIsUpper_String_Int32.SetBelong(null);
				}
				return r_MIsUpper_String_Int32;
			}
		}

		/// <summary>
		/// Boolean IsWhiteSpace(System.String, Int32)
		/// </summary>
		protected static RMethod r_MIsWhiteSpace_String_Int32;
		public static RMethod RMIsWhiteSpace_String_Int32
		{
			get
			{
				if(r_MIsWhiteSpace_String_Int32 == null)
				{
					r_MIsWhiteSpace_String_Int32 = new(typeof(System.Char), "IsWhiteSpace", 0, typeof(System.String), typeof(System.Int32));
					r_MIsWhiteSpace_String_Int32.SetBelong(null);
				}
				return r_MIsWhiteSpace_String_Int32;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory GetUnicodeCategory(Char)
		/// </summary>
		protected static RMethod r_MGetUnicodeCategory_Char;
		public static RMethod RMGetUnicodeCategory_Char
		{
			get
			{
				if(r_MGetUnicodeCategory_Char == null)
				{
					r_MGetUnicodeCategory_Char = new(typeof(System.Char), "GetUnicodeCategory", 0, typeof(System.Char));
					r_MGetUnicodeCategory_Char.SetBelong(null);
				}
				return r_MGetUnicodeCategory_Char;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory GetUnicodeCategory(System.String, Int32)
		/// </summary>
		protected static RMethod r_MGetUnicodeCategory_String_Int32;
		public static RMethod RMGetUnicodeCategory_String_Int32
		{
			get
			{
				if(r_MGetUnicodeCategory_String_Int32 == null)
				{
					r_MGetUnicodeCategory_String_Int32 = new(typeof(System.Char), "GetUnicodeCategory", 0, typeof(System.String), typeof(System.Int32));
					r_MGetUnicodeCategory_String_Int32.SetBelong(null);
				}
				return r_MGetUnicodeCategory_String_Int32;
			}
		}

		/// <summary>
		/// Double GetNumericValue(Char)
		/// </summary>
		protected static RMethod r_MGetNumericValue_Char;
		public static RMethod RMGetNumericValue_Char
		{
			get
			{
				if(r_MGetNumericValue_Char == null)
				{
					r_MGetNumericValue_Char = new(typeof(System.Char), "GetNumericValue", 0, typeof(System.Char));
					r_MGetNumericValue_Char.SetBelong(null);
				}
				return r_MGetNumericValue_Char;
			}
		}

		/// <summary>
		/// Double GetNumericValue(System.String, Int32)
		/// </summary>
		protected static RMethod r_MGetNumericValue_String_Int32;
		public static RMethod RMGetNumericValue_String_Int32
		{
			get
			{
				if(r_MGetNumericValue_String_Int32 == null)
				{
					r_MGetNumericValue_String_Int32 = new(typeof(System.Char), "GetNumericValue", 0, typeof(System.String), typeof(System.Int32));
					r_MGetNumericValue_String_Int32.SetBelong(null);
				}
				return r_MGetNumericValue_String_Int32;
			}
		}

		/// <summary>
		/// Boolean IsHighSurrogate(Char)
		/// </summary>
		protected static RMethod r_MIsHighSurrogate_Char;
		public static RMethod RMIsHighSurrogate_Char
		{
			get
			{
				if(r_MIsHighSurrogate_Char == null)
				{
					r_MIsHighSurrogate_Char = new(typeof(System.Char), "IsHighSurrogate", 0, typeof(System.Char));
					r_MIsHighSurrogate_Char.SetBelong(null);
				}
				return r_MIsHighSurrogate_Char;
			}
		}

		/// <summary>
		/// Boolean IsHighSurrogate(System.String, Int32)
		/// </summary>
		protected static RMethod r_MIsHighSurrogate_String_Int32;
		public static RMethod RMIsHighSurrogate_String_Int32
		{
			get
			{
				if(r_MIsHighSurrogate_String_Int32 == null)
				{
					r_MIsHighSurrogate_String_Int32 = new(typeof(System.Char), "IsHighSurrogate", 0, typeof(System.String), typeof(System.Int32));
					r_MIsHighSurrogate_String_Int32.SetBelong(null);
				}
				return r_MIsHighSurrogate_String_Int32;
			}
		}

		/// <summary>
		/// Boolean IsLowSurrogate(Char)
		/// </summary>
		protected static RMethod r_MIsLowSurrogate_Char;
		public static RMethod RMIsLowSurrogate_Char
		{
			get
			{
				if(r_MIsLowSurrogate_Char == null)
				{
					r_MIsLowSurrogate_Char = new(typeof(System.Char), "IsLowSurrogate", 0, typeof(System.Char));
					r_MIsLowSurrogate_Char.SetBelong(null);
				}
				return r_MIsLowSurrogate_Char;
			}
		}

		/// <summary>
		/// Boolean IsLowSurrogate(System.String, Int32)
		/// </summary>
		protected static RMethod r_MIsLowSurrogate_String_Int32;
		public static RMethod RMIsLowSurrogate_String_Int32
		{
			get
			{
				if(r_MIsLowSurrogate_String_Int32 == null)
				{
					r_MIsLowSurrogate_String_Int32 = new(typeof(System.Char), "IsLowSurrogate", 0, typeof(System.String), typeof(System.Int32));
					r_MIsLowSurrogate_String_Int32.SetBelong(null);
				}
				return r_MIsLowSurrogate_String_Int32;
			}
		}

		/// <summary>
		/// Boolean IsSurrogatePair(System.String, Int32)
		/// </summary>
		protected static RMethod r_MIsSurrogatePair_String_Int32;
		public static RMethod RMIsSurrogatePair_String_Int32
		{
			get
			{
				if(r_MIsSurrogatePair_String_Int32 == null)
				{
					r_MIsSurrogatePair_String_Int32 = new(typeof(System.Char), "IsSurrogatePair", 0, typeof(System.String), typeof(System.Int32));
					r_MIsSurrogatePair_String_Int32.SetBelong(null);
				}
				return r_MIsSurrogatePair_String_Int32;
			}
		}

		/// <summary>
		/// Boolean IsSurrogatePair(Char, Char)
		/// </summary>
		protected static RMethod r_MIsSurrogatePair_Char_Char;
		public static RMethod RMIsSurrogatePair_Char_Char
		{
			get
			{
				if(r_MIsSurrogatePair_Char_Char == null)
				{
					r_MIsSurrogatePair_Char_Char = new(typeof(System.Char), "IsSurrogatePair", 0, typeof(System.Char), typeof(System.Char));
					r_MIsSurrogatePair_Char_Char.SetBelong(null);
				}
				return r_MIsSurrogatePair_Char_Char;
			}
		}

		/// <summary>
		/// System.String ConvertFromUtf32(Int32)
		/// </summary>
		protected static RMethod r_MConvertFromUtf32_Int32;
		public static RMethod RMConvertFromUtf32_Int32
		{
			get
			{
				if(r_MConvertFromUtf32_Int32 == null)
				{
					r_MConvertFromUtf32_Int32 = new(typeof(System.Char), "ConvertFromUtf32", 0, typeof(System.Int32));
					r_MConvertFromUtf32_Int32.SetBelong(null);
				}
				return r_MConvertFromUtf32_Int32;
			}
		}

		/// <summary>
		/// Int32 ConvertToUtf32(Char, Char)
		/// </summary>
		protected static RMethod r_MConvertToUtf32_Char_Char;
		public static RMethod RMConvertToUtf32_Char_Char
		{
			get
			{
				if(r_MConvertToUtf32_Char_Char == null)
				{
					r_MConvertToUtf32_Char_Char = new(typeof(System.Char), "ConvertToUtf32", 0, typeof(System.Char), typeof(System.Char));
					r_MConvertToUtf32_Char_Char.SetBelong(null);
				}
				return r_MConvertToUtf32_Char_Char;
			}
		}

		/// <summary>
		/// Int32 ConvertToUtf32(System.String, Int32)
		/// </summary>
		protected static RMethod r_MConvertToUtf32_String_Int32;
		public static RMethod RMConvertToUtf32_String_Int32
		{
			get
			{
				if(r_MConvertToUtf32_String_Int32 == null)
				{
					r_MConvertToUtf32_String_Int32 = new(typeof(System.Char), "ConvertToUtf32", 0, typeof(System.String), typeof(System.Int32));
					r_MConvertToUtf32_String_Int32.SetBelong(null);
				}
				return r_MConvertToUtf32_String_Int32;
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
            var ___result = RMIsLatin1_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsAscii(System.Char @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RMIsAscii_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Globalization.UnicodeCategory GetLatin1UnicodeCategory(System.Char @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RMGetLatin1UnicodeCategory_Char.Invoke(___genericsType, ___parameters);

            return (System.Globalization.UnicodeCategory)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Char @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 CompareTo(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareTo(System.Char @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMCompareTo_Char.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String ToString(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMToString_Char.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Char Parse(System.String @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RMParse_String.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public static System.Boolean TryParse(System.String @s, out System.Char @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @result};
            var ___result = RMTryParse_String_Out_Char.Invoke(___genericsType, ___parameters);
			@result = (System.Char)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.Boolean IsDigit(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMIsDigit_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean CheckLetter(System.Globalization.UnicodeCategory @uc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uc};
            var ___result = RMCheckLetter_UnicodeCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsLetter(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMIsLetter_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsWhiteSpaceLatin1(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMIsWhiteSpaceLatin1_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsWhiteSpace(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMIsWhiteSpace_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsUpper(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMIsUpper_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsLower(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMIsLower_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean CheckPunctuation(System.Globalization.UnicodeCategory @uc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uc};
            var ___result = RMCheckPunctuation_UnicodeCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsPunctuation(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMIsPunctuation_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean CheckLetterOrDigit(System.Globalization.UnicodeCategory @uc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uc};
            var ___result = RMCheckLetterOrDigit_UnicodeCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsLetterOrDigit(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMIsLetterOrDigit_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Char ToUpper(System.Char @c, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c, @culture};
            var ___result = RMToUpper_Char_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public static System.Char ToUpper(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMToUpper_Char.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public static System.Char ToUpperInvariant(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMToUpperInvariant_Char.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public static System.Char ToLower(System.Char @c, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c, @culture};
            var ___result = RMToLower_Char_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public static System.Char ToLower(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMToLower_Char.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public static System.Char ToLowerInvariant(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMToLowerInvariant_Char.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCode.Invoke(___genericsType, ___parameters);

            return (System.TypeCode)___result;
        }


        public virtual System.Boolean System__2__IConvertible__2__ToBoolean(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToBoolean_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Char System__2__IConvertible__2__ToChar(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToChar_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public virtual System.SByte System__2__IConvertible__2__ToSByte(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToSByte_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.SByte)___result;
        }


        public virtual System.Byte System__2__IConvertible__2__ToByte(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToByte_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Byte)___result;
        }


        public virtual System.Int16 System__2__IConvertible__2__ToInt16(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToInt16_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Int16)___result;
        }


        public virtual System.UInt16 System__2__IConvertible__2__ToUInt16(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToUInt16_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.UInt16)___result;
        }


        public virtual System.Int32 System__2__IConvertible__2__ToInt32(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToInt32_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.UInt32 System__2__IConvertible__2__ToUInt32(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToUInt32_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual System.Int64 System__2__IConvertible__2__ToInt64(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToInt64_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.UInt64 System__2__IConvertible__2__ToUInt64(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToUInt64_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public virtual System.Single System__2__IConvertible__2__ToSingle(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToSingle_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Double System__2__IConvertible__2__ToDouble(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToDouble_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Decimal System__2__IConvertible__2__ToDecimal(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToDecimal_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public virtual System.DateTime System__2__IConvertible__2__ToDateTime(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToDateTime_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.Object System__2__IConvertible__2__ToType(System.Type @type, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @provider};
            var ___result = RMSystem__2__IConvertible__2__ToType_Type_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Boolean IsControl(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMIsControl_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsControl(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RMIsControl_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsDigit(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RMIsDigit_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsLetter(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RMIsLetter_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsLetterOrDigit(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RMIsLetterOrDigit_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsLower(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RMIsLower_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean CheckNumber(System.Globalization.UnicodeCategory @uc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uc};
            var ___result = RMCheckNumber_UnicodeCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsNumber(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMIsNumber_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsNumber(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RMIsNumber_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsPunctuation(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RMIsPunctuation_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean CheckSeparator(System.Globalization.UnicodeCategory @uc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uc};
            var ___result = RMCheckSeparator_UnicodeCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsSeparatorLatin1(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMIsSeparatorLatin1_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsSeparator(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMIsSeparator_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsSeparator(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RMIsSeparator_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsSurrogate(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMIsSurrogate_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsSurrogate(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RMIsSurrogate_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean CheckSymbol(System.Globalization.UnicodeCategory @uc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uc};
            var ___result = RMCheckSymbol_UnicodeCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsSymbol(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMIsSymbol_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsSymbol(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RMIsSymbol_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsUpper(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RMIsUpper_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsWhiteSpace(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RMIsWhiteSpace_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Globalization.UnicodeCategory GetUnicodeCategory(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMGetUnicodeCategory_Char.Invoke(___genericsType, ___parameters);

            return (System.Globalization.UnicodeCategory)___result;
        }


        public static System.Globalization.UnicodeCategory GetUnicodeCategory(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RMGetUnicodeCategory_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Globalization.UnicodeCategory)___result;
        }


        public static System.Double GetNumericValue(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMGetNumericValue_Char.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public static System.Double GetNumericValue(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RMGetNumericValue_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public static System.Boolean IsHighSurrogate(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMIsHighSurrogate_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsHighSurrogate(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RMIsHighSurrogate_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsLowSurrogate(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMIsLowSurrogate_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsLowSurrogate(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RMIsLowSurrogate_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsSurrogatePair(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RMIsSurrogatePair_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsSurrogatePair(System.Char @highSurrogate, System.Char @lowSurrogate)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@highSurrogate, @lowSurrogate};
            var ___result = RMIsSurrogatePair_Char_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.String ConvertFromUtf32(System.Int32 @utf32)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@utf32};
            var ___result = RMConvertFromUtf32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Int32 ConvertToUtf32(System.Char @highSurrogate, System.Char @lowSurrogate)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@highSurrogate, @lowSurrogate};
            var ___result = RMConvertToUtf32_Char_Char.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 ConvertToUtf32(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RMConvertToUtf32_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
