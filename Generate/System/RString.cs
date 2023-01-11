using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.String
	/// </summary>
    public partial class RString : RMember //
    {

		/// <summary>
		/// System.Int32 StackallocIntBufferSizeLimit
		/// </summary>
		protected static RSystem.RInt32 r_StackallocIntBufferSizeLimit;
		public static RSystem.RInt32 RStackallocIntBufferSizeLimit
		{
			get
			{
				if(r_StackallocIntBufferSizeLimit == null)
				{
					r_StackallocIntBufferSizeLimit = new(typeof(System.String), "StackallocIntBufferSizeLimit");
					r_StackallocIntBufferSizeLimit.SetBelong(null);
				}
				return r_StackallocIntBufferSizeLimit;
			}
		}

		/// <summary>
		/// System.Int32 PROBABILISTICMAP_BLOCK_INDEX_MASK
		/// </summary>
		protected static RSystem.RInt32 r_PROBABILISTICMAP_BLOCK_INDEX_MASK;
		public static RSystem.RInt32 RPROBABILISTICMAP_BLOCK_INDEX_MASK
		{
			get
			{
				if(r_PROBABILISTICMAP_BLOCK_INDEX_MASK == null)
				{
					r_PROBABILISTICMAP_BLOCK_INDEX_MASK = new(typeof(System.String), "PROBABILISTICMAP_BLOCK_INDEX_MASK");
					r_PROBABILISTICMAP_BLOCK_INDEX_MASK.SetBelong(null);
				}
				return r_PROBABILISTICMAP_BLOCK_INDEX_MASK;
			}
		}

		/// <summary>
		/// System.Int32 PROBABILISTICMAP_BLOCK_INDEX_SHIFT
		/// </summary>
		protected static RSystem.RInt32 r_PROBABILISTICMAP_BLOCK_INDEX_SHIFT;
		public static RSystem.RInt32 RPROBABILISTICMAP_BLOCK_INDEX_SHIFT
		{
			get
			{
				if(r_PROBABILISTICMAP_BLOCK_INDEX_SHIFT == null)
				{
					r_PROBABILISTICMAP_BLOCK_INDEX_SHIFT = new(typeof(System.String), "PROBABILISTICMAP_BLOCK_INDEX_SHIFT");
					r_PROBABILISTICMAP_BLOCK_INDEX_SHIFT.SetBelong(null);
				}
				return r_PROBABILISTICMAP_BLOCK_INDEX_SHIFT;
			}
		}

		/// <summary>
		/// System.Int32 PROBABILISTICMAP_SIZE
		/// </summary>
		protected static RSystem.RInt32 r_PROBABILISTICMAP_SIZE;
		public static RSystem.RInt32 RPROBABILISTICMAP_SIZE
		{
			get
			{
				if(r_PROBABILISTICMAP_SIZE == null)
				{
					r_PROBABILISTICMAP_SIZE = new(typeof(System.String), "PROBABILISTICMAP_SIZE");
					r_PROBABILISTICMAP_SIZE.SetBelong(null);
				}
				return r_PROBABILISTICMAP_SIZE;
			}
		}

		/// <summary>
		/// System.Int32 _stringLength
		/// </summary>
		protected RSystem.RInt32 r__stringLength;
		public virtual RSystem.RInt32 R_stringLength
		{
			get
			{
				if(r__stringLength == null)
				{
					r__stringLength = new(this, "_stringLength");
					r__stringLength.SetBelong(this.instance);
				}
				return r__stringLength;
			}
		}

		/// <summary>
		/// System.Char _firstChar
		/// </summary>
		protected RSystem.RChar r__firstChar;
		public virtual RSystem.RChar R_firstChar
		{
			get
			{
				if(r__firstChar == null)
				{
					r__firstChar = new(this, "_firstChar");
					r__firstChar.SetBelong(this.instance);
				}
				return r__firstChar;
			}
		}

		/// <summary>
		/// System.String Empty
		/// </summary>
		protected static RSystem.RString r_Empty;
		public static RSystem.RString REmpty
		{
			get
			{
				if(r_Empty == null)
				{
					r_Empty = new(typeof(System.String), "Empty");
					r_Empty.SetBelong(null);
				}
				return r_Empty;
			}
		}

		/// <summary>
		/// Int32 Length
		/// </summary>
		protected RSystem.RInt32 r_Length;
		public virtual RSystem.RInt32 RLength
		{
			get
			{
				if(r_Length == null)
				{
					r_Length = new(this, "Length", -1);
					r_Length.SetBelong(this.instance);
				}
				return r_Length;
			}
		}

		/// <summary>
		/// Char Chars [Int32]
		/// </summary>
		protected RSystem.RChar r_Chars_Int32;
		public virtual RSystem.RChar RChars_Int32
		{
			get
			{
				if(r_Chars_Int32 == null)
				{
					r_Chars_Int32 = new(this, "Chars", -1, typeof(System.Int32));
					r_Chars_Int32.SetBelong(this.instance);
				}
				return r_Chars_Int32;
			}
		}

		/// <summary>
		/// Int32 CompareOrdinalIgnoreCaseHelper(System.String, System.String)
		/// </summary>
		protected static RMethod r_CompareOrdinalIgnoreCaseHelper_String_String;
		public static RMethod RCompareOrdinalIgnoreCaseHelper_String_String
		{
			get
			{
				if(r_CompareOrdinalIgnoreCaseHelper_String_String == null)
				{
					r_CompareOrdinalIgnoreCaseHelper_String_String = new(typeof(System.String), "CompareOrdinalIgnoreCaseHelper", 0, typeof(System.String), typeof(System.String));
					r_CompareOrdinalIgnoreCaseHelper_String_String.SetBelong(null);
				}
				return r_CompareOrdinalIgnoreCaseHelper_String_String;
			}
		}

		/// <summary>
		/// Boolean EqualsHelper(System.String, System.String)
		/// </summary>
		protected static RMethod r_EqualsHelper_String_String;
		public static RMethod REqualsHelper_String_String
		{
			get
			{
				if(r_EqualsHelper_String_String == null)
				{
					r_EqualsHelper_String_String = new(typeof(System.String), "EqualsHelper", 0, typeof(System.String), typeof(System.String));
					r_EqualsHelper_String_String.SetBelong(null);
				}
				return r_EqualsHelper_String_String;
			}
		}

		/// <summary>
		/// Int32 CompareOrdinalHelper(System.String, Int32, Int32, System.String, Int32, Int32)
		/// </summary>
		protected static RMethod r_CompareOrdinalHelper_String_Int32_Int32_String_Int32_Int32;
		public static RMethod RCompareOrdinalHelper_String_Int32_Int32_String_Int32_Int32
		{
			get
			{
				if(r_CompareOrdinalHelper_String_Int32_Int32_String_Int32_Int32 == null)
				{
					r_CompareOrdinalHelper_String_Int32_Int32_String_Int32_Int32 = new(typeof(System.String), "CompareOrdinalHelper", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_CompareOrdinalHelper_String_Int32_Int32_String_Int32_Int32.SetBelong(null);
				}
				return r_CompareOrdinalHelper_String_Int32_Int32_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean EqualsIgnoreCaseAsciiHelper(System.String, System.String)
		/// </summary>
		protected static RMethod r_EqualsIgnoreCaseAsciiHelper_String_String;
		public static RMethod REqualsIgnoreCaseAsciiHelper_String_String
		{
			get
			{
				if(r_EqualsIgnoreCaseAsciiHelper_String_String == null)
				{
					r_EqualsIgnoreCaseAsciiHelper_String_String = new(typeof(System.String), "EqualsIgnoreCaseAsciiHelper", 0, typeof(System.String), typeof(System.String));
					r_EqualsIgnoreCaseAsciiHelper_String_String.SetBelong(null);
				}
				return r_EqualsIgnoreCaseAsciiHelper_String_String;
			}
		}

		/// <summary>
		/// Int32 CompareOrdinalHelper(System.String, System.String)
		/// </summary>
		protected static RMethod r_CompareOrdinalHelper_String_String;
		public static RMethod RCompareOrdinalHelper_String_String
		{
			get
			{
				if(r_CompareOrdinalHelper_String_String == null)
				{
					r_CompareOrdinalHelper_String_String = new(typeof(System.String), "CompareOrdinalHelper", 0, typeof(System.String), typeof(System.String));
					r_CompareOrdinalHelper_String_String.SetBelong(null);
				}
				return r_CompareOrdinalHelper_String_String;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, System.String)
		/// </summary>
		protected static RMethod r_Compare_String_String;
		public static RMethod RCompare_String_String
		{
			get
			{
				if(r_Compare_String_String == null)
				{
					r_Compare_String_String = new(typeof(System.String), "Compare", 0, typeof(System.String), typeof(System.String));
					r_Compare_String_String.SetBelong(null);
				}
				return r_Compare_String_String;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, System.String, Boolean)
		/// </summary>
		protected static RMethod r_Compare_String_String_Boolean;
		public static RMethod RCompare_String_String_Boolean
		{
			get
			{
				if(r_Compare_String_String_Boolean == null)
				{
					r_Compare_String_String_Boolean = new(typeof(System.String), "Compare", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean));
					r_Compare_String_String_Boolean.SetBelong(null);
				}
				return r_Compare_String_String_Boolean;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, System.String, System.StringComparison)
		/// </summary>
		protected static RMethod r_Compare_String_String_StringComparison;
		public static RMethod RCompare_String_String_StringComparison
		{
			get
			{
				if(r_Compare_String_String_StringComparison == null)
				{
					r_Compare_String_String_StringComparison = new(typeof(System.String), "Compare", 0, typeof(System.String), typeof(System.String), typeof(System.StringComparison));
					r_Compare_String_String_StringComparison.SetBelong(null);
				}
				return r_Compare_String_String_StringComparison;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, System.String, System.Globalization.CultureInfo, System.Globalization.CompareOptions)
		/// </summary>
		protected static RMethod r_Compare_String_String_CultureInfo_CompareOptions;
		public static RMethod RCompare_String_String_CultureInfo_CompareOptions
		{
			get
			{
				if(r_Compare_String_String_CultureInfo_CompareOptions == null)
				{
					r_Compare_String_String_CultureInfo_CompareOptions = new(typeof(System.String), "Compare", 0, typeof(System.String), typeof(System.String), typeof(System.Globalization.CultureInfo), typeof(System.Globalization.CompareOptions));
					r_Compare_String_String_CultureInfo_CompareOptions.SetBelong(null);
				}
				return r_Compare_String_String_CultureInfo_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, System.String, Boolean, System.Globalization.CultureInfo)
		/// </summary>
		protected static RMethod r_Compare_String_String_Boolean_CultureInfo;
		public static RMethod RCompare_String_String_Boolean_CultureInfo
		{
			get
			{
				if(r_Compare_String_String_Boolean_CultureInfo == null)
				{
					r_Compare_String_String_Boolean_CultureInfo = new(typeof(System.String), "Compare", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.Globalization.CultureInfo));
					r_Compare_String_String_Boolean_CultureInfo.SetBelong(null);
				}
				return r_Compare_String_String_Boolean_CultureInfo;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, Int32, System.String, Int32, Int32)
		/// </summary>
		protected static RMethod r_Compare_String_Int32_String_Int32_Int32;
		public static RMethod RCompare_String_Int32_String_Int32_Int32
		{
			get
			{
				if(r_Compare_String_Int32_String_Int32_Int32 == null)
				{
					r_Compare_String_Int32_String_Int32_Int32 = new(typeof(System.String), "Compare", 0, typeof(System.String), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_Compare_String_Int32_String_Int32_Int32.SetBelong(null);
				}
				return r_Compare_String_Int32_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, Int32, System.String, Int32, Int32, Boolean)
		/// </summary>
		protected static RMethod r_Compare_String_Int32_String_Int32_Int32_Boolean;
		public static RMethod RCompare_String_Int32_String_Int32_Int32_Boolean
		{
			get
			{
				if(r_Compare_String_Int32_String_Int32_Int32_Boolean == null)
				{
					r_Compare_String_Int32_String_Int32_Int32_Boolean = new(typeof(System.String), "Compare", 0, typeof(System.String), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_Compare_String_Int32_String_Int32_Int32_Boolean.SetBelong(null);
				}
				return r_Compare_String_Int32_String_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, Int32, System.String, Int32, Int32, Boolean, System.Globalization.CultureInfo)
		/// </summary>
		protected static RMethod r_Compare_String_Int32_String_Int32_Int32_Boolean_CultureInfo;
		public static RMethod RCompare_String_Int32_String_Int32_Int32_Boolean_CultureInfo
		{
			get
			{
				if(r_Compare_String_Int32_String_Int32_Int32_Boolean_CultureInfo == null)
				{
					r_Compare_String_Int32_String_Int32_Int32_Boolean_CultureInfo = new(typeof(System.String), "Compare", 0, typeof(System.String), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.Globalization.CultureInfo));
					r_Compare_String_Int32_String_Int32_Int32_Boolean_CultureInfo.SetBelong(null);
				}
				return r_Compare_String_Int32_String_Int32_Int32_Boolean_CultureInfo;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, Int32, System.String, Int32, Int32, System.Globalization.CultureInfo, System.Globalization.CompareOptions)
		/// </summary>
		protected static RMethod r_Compare_String_Int32_String_Int32_Int32_CultureInfo_CompareOptions;
		public static RMethod RCompare_String_Int32_String_Int32_Int32_CultureInfo_CompareOptions
		{
			get
			{
				if(r_Compare_String_Int32_String_Int32_Int32_CultureInfo_CompareOptions == null)
				{
					r_Compare_String_Int32_String_Int32_Int32_CultureInfo_CompareOptions = new(typeof(System.String), "Compare", 0, typeof(System.String), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CultureInfo), typeof(System.Globalization.CompareOptions));
					r_Compare_String_Int32_String_Int32_Int32_CultureInfo_CompareOptions.SetBelong(null);
				}
				return r_Compare_String_Int32_String_Int32_Int32_CultureInfo_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
		/// </summary>
		protected static RMethod r_Compare_String_Int32_String_Int32_Int32_StringComparison;
		public static RMethod RCompare_String_Int32_String_Int32_Int32_StringComparison
		{
			get
			{
				if(r_Compare_String_Int32_String_Int32_Int32_StringComparison == null)
				{
					r_Compare_String_Int32_String_Int32_Int32_StringComparison = new(typeof(System.String), "Compare", 0, typeof(System.String), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.StringComparison));
					r_Compare_String_Int32_String_Int32_Int32_StringComparison.SetBelong(null);
				}
				return r_Compare_String_Int32_String_Int32_Int32_StringComparison;
			}
		}

		/// <summary>
		/// Int32 CompareOrdinal(System.String, System.String)
		/// </summary>
		protected static RMethod r_CompareOrdinal_String_String;
		public static RMethod RCompareOrdinal_String_String
		{
			get
			{
				if(r_CompareOrdinal_String_String == null)
				{
					r_CompareOrdinal_String_String = new(typeof(System.String), "CompareOrdinal", 0, typeof(System.String), typeof(System.String));
					r_CompareOrdinal_String_String.SetBelong(null);
				}
				return r_CompareOrdinal_String_String;
			}
		}

		/// <summary>
		/// Int32 CompareOrdinal(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected static RMethod r_CompareOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_;
		public static RMethod RCompareOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_CompareOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_ == null)
				{
					r_CompareOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_ = new(typeof(System.String), "CompareOrdinal", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_CompareOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_.SetBelong(null);
				}
				return r_CompareOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// Int32 CompareOrdinal(System.String, Int32, System.String, Int32, Int32)
		/// </summary>
		protected static RMethod r_CompareOrdinal_String_Int32_String_Int32_Int32;
		public static RMethod RCompareOrdinal_String_Int32_String_Int32_Int32
		{
			get
			{
				if(r_CompareOrdinal_String_Int32_String_Int32_Int32 == null)
				{
					r_CompareOrdinal_String_Int32_String_Int32_Int32 = new(typeof(System.String), "CompareOrdinal", 0, typeof(System.String), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_CompareOrdinal_String_Int32_String_Int32_Int32.SetBelong(null);
				}
				return r_CompareOrdinal_String_Int32_String_Int32_Int32;
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
		/// Int32 CompareTo(System.String)
		/// </summary>
		protected RMethod r_CompareTo_String;
		public virtual RMethod RCompareTo_String
		{
			get
			{
				if(r_CompareTo_String == null)
				{
					r_CompareTo_String = new(this, "CompareTo", 0, typeof(System.String));
					r_CompareTo_String.SetBelong(this.instance);
				}
				return r_CompareTo_String;
			}
		}

		/// <summary>
		/// Boolean EndsWith(System.String)
		/// </summary>
		protected RMethod r_EndsWith_String;
		public virtual RMethod REndsWith_String
		{
			get
			{
				if(r_EndsWith_String == null)
				{
					r_EndsWith_String = new(this, "EndsWith", 0, typeof(System.String));
					r_EndsWith_String.SetBelong(this.instance);
				}
				return r_EndsWith_String;
			}
		}

		/// <summary>
		/// Boolean EndsWith(System.String, System.StringComparison)
		/// </summary>
		protected RMethod r_EndsWith_String_StringComparison;
		public virtual RMethod REndsWith_String_StringComparison
		{
			get
			{
				if(r_EndsWith_String_StringComparison == null)
				{
					r_EndsWith_String_StringComparison = new(this, "EndsWith", 0, typeof(System.String), typeof(System.StringComparison));
					r_EndsWith_String_StringComparison.SetBelong(this.instance);
				}
				return r_EndsWith_String_StringComparison;
			}
		}

		/// <summary>
		/// Boolean EndsWith(System.String, Boolean, System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_EndsWith_String_Boolean_CultureInfo;
		public virtual RMethod REndsWith_String_Boolean_CultureInfo
		{
			get
			{
				if(r_EndsWith_String_Boolean_CultureInfo == null)
				{
					r_EndsWith_String_Boolean_CultureInfo = new(this, "EndsWith", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Globalization.CultureInfo));
					r_EndsWith_String_Boolean_CultureInfo.SetBelong(this.instance);
				}
				return r_EndsWith_String_Boolean_CultureInfo;
			}
		}

		/// <summary>
		/// Boolean EndsWith(Char)
		/// </summary>
		protected RMethod r_EndsWith_Char;
		public virtual RMethod REndsWith_Char
		{
			get
			{
				if(r_EndsWith_Char == null)
				{
					r_EndsWith_Char = new(this, "EndsWith", 0, typeof(System.Char));
					r_EndsWith_Char.SetBelong(this.instance);
				}
				return r_EndsWith_Char;
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
		/// Boolean Equals(System.String)
		/// </summary>
		protected RMethod r_Equals_String;
		public virtual RMethod REquals_String
		{
			get
			{
				if(r_Equals_String == null)
				{
					r_Equals_String = new(this, "Equals", 0, typeof(System.String));
					r_Equals_String.SetBelong(this.instance);
				}
				return r_Equals_String;
			}
		}

		/// <summary>
		/// Boolean Equals(System.String, System.StringComparison)
		/// </summary>
		protected RMethod r_Equals_String_StringComparison;
		public virtual RMethod REquals_String_StringComparison
		{
			get
			{
				if(r_Equals_String_StringComparison == null)
				{
					r_Equals_String_StringComparison = new(this, "Equals", 0, typeof(System.String), typeof(System.StringComparison));
					r_Equals_String_StringComparison.SetBelong(this.instance);
				}
				return r_Equals_String_StringComparison;
			}
		}

		/// <summary>
		/// Boolean Equals(System.String, System.String)
		/// </summary>
		protected static RMethod r_Equals_String_String;
		public static RMethod REquals_String_String
		{
			get
			{
				if(r_Equals_String_String == null)
				{
					r_Equals_String_String = new(typeof(System.String), "Equals", 0, typeof(System.String), typeof(System.String));
					r_Equals_String_String.SetBelong(null);
				}
				return r_Equals_String_String;
			}
		}

		/// <summary>
		/// Boolean Equals(System.String, System.String, System.StringComparison)
		/// </summary>
		protected static RMethod r_Equals_String_String_StringComparison;
		public static RMethod REquals_String_String_StringComparison
		{
			get
			{
				if(r_Equals_String_String_StringComparison == null)
				{
					r_Equals_String_String_StringComparison = new(typeof(System.String), "Equals", 0, typeof(System.String), typeof(System.String), typeof(System.StringComparison));
					r_Equals_String_String_StringComparison.SetBelong(null);
				}
				return r_Equals_String_String_StringComparison;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.String, System.String)
		/// </summary>
		protected static RMethod r_op_Equality_String_String;
		public static RMethod Rop_Equality_String_String
		{
			get
			{
				if(r_op_Equality_String_String == null)
				{
					r_op_Equality_String_String = new(typeof(System.String), "op_Equality", 0, typeof(System.String), typeof(System.String));
					r_op_Equality_String_String.SetBelong(null);
				}
				return r_op_Equality_String_String;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.String, System.String)
		/// </summary>
		protected static RMethod r_op_Inequality_String_String;
		public static RMethod Rop_Inequality_String_String
		{
			get
			{
				if(r_op_Inequality_String_String == null)
				{
					r_op_Inequality_String_String = new(typeof(System.String), "op_Inequality", 0, typeof(System.String), typeof(System.String));
					r_op_Inequality_String_String.SetBelong(null);
				}
				return r_op_Inequality_String_String;
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
		/// Int32 GetHashCode(System.StringComparison)
		/// </summary>
		protected RMethod r_GetHashCode_StringComparison;
		public virtual RMethod RGetHashCode_StringComparison
		{
			get
			{
				if(r_GetHashCode_StringComparison == null)
				{
					r_GetHashCode_StringComparison = new(this, "GetHashCode", 0, typeof(System.StringComparison));
					r_GetHashCode_StringComparison.SetBelong(this.instance);
				}
				return r_GetHashCode_StringComparison;
			}
		}

		/// <summary>
		/// Int32 GetLegacyNonRandomizedHashCode()
		/// </summary>
		protected RMethod r_GetLegacyNonRandomizedHashCode;
		public virtual RMethod RGetLegacyNonRandomizedHashCode
		{
			get
			{
				if(r_GetLegacyNonRandomizedHashCode == null)
				{
					r_GetLegacyNonRandomizedHashCode = new(this, "GetLegacyNonRandomizedHashCode", 0);
					r_GetLegacyNonRandomizedHashCode.SetBelong(this.instance);
				}
				return r_GetLegacyNonRandomizedHashCode;
			}
		}

		/// <summary>
		/// Boolean StartsWith(System.String)
		/// </summary>
		protected RMethod r_StartsWith_String;
		public virtual RMethod RStartsWith_String
		{
			get
			{
				if(r_StartsWith_String == null)
				{
					r_StartsWith_String = new(this, "StartsWith", 0, typeof(System.String));
					r_StartsWith_String.SetBelong(this.instance);
				}
				return r_StartsWith_String;
			}
		}

		/// <summary>
		/// Boolean StartsWith(System.String, System.StringComparison)
		/// </summary>
		protected RMethod r_StartsWith_String_StringComparison;
		public virtual RMethod RStartsWith_String_StringComparison
		{
			get
			{
				if(r_StartsWith_String_StringComparison == null)
				{
					r_StartsWith_String_StringComparison = new(this, "StartsWith", 0, typeof(System.String), typeof(System.StringComparison));
					r_StartsWith_String_StringComparison.SetBelong(this.instance);
				}
				return r_StartsWith_String_StringComparison;
			}
		}

		/// <summary>
		/// Boolean StartsWith(System.String, Boolean, System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_StartsWith_String_Boolean_CultureInfo;
		public virtual RMethod RStartsWith_String_Boolean_CultureInfo
		{
			get
			{
				if(r_StartsWith_String_Boolean_CultureInfo == null)
				{
					r_StartsWith_String_Boolean_CultureInfo = new(this, "StartsWith", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Globalization.CultureInfo));
					r_StartsWith_String_Boolean_CultureInfo.SetBelong(this.instance);
				}
				return r_StartsWith_String_Boolean_CultureInfo;
			}
		}

		/// <summary>
		/// Boolean StartsWith(Char)
		/// </summary>
		protected RMethod r_StartsWith_Char;
		public virtual RMethod RStartsWith_Char
		{
			get
			{
				if(r_StartsWith_Char == null)
				{
					r_StartsWith_Char = new(this, "StartsWith", 0, typeof(System.Char));
					r_StartsWith_Char.SetBelong(this.instance);
				}
				return r_StartsWith_Char;
			}
		}

		/// <summary>
		/// Void CheckStringComparison(System.StringComparison)
		/// </summary>
		protected static RMethod r_CheckStringComparison_StringComparison;
		public static RMethod RCheckStringComparison_StringComparison
		{
			get
			{
				if(r_CheckStringComparison_StringComparison == null)
				{
					r_CheckStringComparison_StringComparison = new(typeof(System.String), "CheckStringComparison", 0, typeof(System.StringComparison));
					r_CheckStringComparison_StringComparison.SetBelong(null);
				}
				return r_CheckStringComparison_StringComparison;
			}
		}

		/// <summary>
		/// Void FillStringChecked(System.String, Int32, System.String)
		/// </summary>
		protected static RMethod r_FillStringChecked_String_Int32_String;
		public static RMethod RFillStringChecked_String_Int32_String
		{
			get
			{
				if(r_FillStringChecked_String_Int32_String == null)
				{
					r_FillStringChecked_String_Int32_String = new(typeof(System.String), "FillStringChecked", 0, typeof(System.String), typeof(System.Int32), typeof(System.String));
					r_FillStringChecked_String_Int32_String.SetBelong(null);
				}
				return r_FillStringChecked_String_Int32_String;
			}
		}

		/// <summary>
		/// System.String Concat(System.Object)
		/// </summary>
		protected static RMethod r_Concat_Object;
		public static RMethod RConcat_Object
		{
			get
			{
				if(r_Concat_Object == null)
				{
					r_Concat_Object = new(typeof(System.String), "Concat", 0, typeof(System.Object));
					r_Concat_Object.SetBelong(null);
				}
				return r_Concat_Object;
			}
		}

		/// <summary>
		/// System.String Concat(System.Object, System.Object)
		/// </summary>
		protected static RMethod r_Concat_Object_Object;
		public static RMethod RConcat_Object_Object
		{
			get
			{
				if(r_Concat_Object_Object == null)
				{
					r_Concat_Object_Object = new(typeof(System.String), "Concat", 0, typeof(System.Object), typeof(System.Object));
					r_Concat_Object_Object.SetBelong(null);
				}
				return r_Concat_Object_Object;
			}
		}

		/// <summary>
		/// System.String Concat(System.Object, System.Object, System.Object)
		/// </summary>
		protected static RMethod r_Concat_Object_Object_Object;
		public static RMethod RConcat_Object_Object_Object
		{
			get
			{
				if(r_Concat_Object_Object_Object == null)
				{
					r_Concat_Object_Object_Object = new(typeof(System.String), "Concat", 0, typeof(System.Object), typeof(System.Object), typeof(System.Object));
					r_Concat_Object_Object_Object.SetBelong(null);
				}
				return r_Concat_Object_Object_Object;
			}
		}

		/// <summary>
		/// System.String Concat(System.Object[])
		/// </summary>
		protected static RMethod r_Concat_ObjectArray;
		public static RMethod RConcat_ObjectArray
		{
			get
			{
				if(r_Concat_ObjectArray == null)
				{
					r_Concat_ObjectArray = new(typeof(System.String), "Concat", 0, typeof(System.Object).MakeArrayType());
					r_Concat_ObjectArray.SetBelong(null);
				}
				return r_Concat_ObjectArray;
			}
		}

		/// <summary>
		/// System.String Concat[T](System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected static RMethod r_Concat_GT_IEnumerable_d_T_p_;
		public static RMethod RConcat_GT_IEnumerable_d_T_p_
		{
			get
			{
				if(r_Concat_GT_IEnumerable_d_T_p_ == null)
				{
					r_Concat_GT_IEnumerable_d_T_p_ = new(typeof(System.String), "Concat", 1, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_Concat_GT_IEnumerable_d_T_p_.SetBelong(null);
				}
				return r_Concat_GT_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// System.String Concat(System.Collections.Generic.IEnumerable`1[System.String])
		/// </summary>
		protected static RMethod r_Concat_IEnumerable_d_String_p_;
		public static RMethod RConcat_IEnumerable_d_String_p_
		{
			get
			{
				if(r_Concat_IEnumerable_d_String_p_ == null)
				{
					r_Concat_IEnumerable_d_String_p_ = new(typeof(System.String), "Concat", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.String)));
					r_Concat_IEnumerable_d_String_p_.SetBelong(null);
				}
				return r_Concat_IEnumerable_d_String_p_;
			}
		}

		/// <summary>
		/// System.String Concat(System.String, System.String)
		/// </summary>
		protected static RMethod r_Concat_String_String;
		public static RMethod RConcat_String_String
		{
			get
			{
				if(r_Concat_String_String == null)
				{
					r_Concat_String_String = new(typeof(System.String), "Concat", 0, typeof(System.String), typeof(System.String));
					r_Concat_String_String.SetBelong(null);
				}
				return r_Concat_String_String;
			}
		}

		/// <summary>
		/// System.String Concat(System.String, System.String, System.String)
		/// </summary>
		protected static RMethod r_Concat_String_String_String;
		public static RMethod RConcat_String_String_String
		{
			get
			{
				if(r_Concat_String_String_String == null)
				{
					r_Concat_String_String_String = new(typeof(System.String), "Concat", 0, typeof(System.String), typeof(System.String), typeof(System.String));
					r_Concat_String_String_String.SetBelong(null);
				}
				return r_Concat_String_String_String;
			}
		}

		/// <summary>
		/// System.String Concat(System.String, System.String, System.String, System.String)
		/// </summary>
		protected static RMethod r_Concat_String_String_String_String;
		public static RMethod RConcat_String_String_String_String
		{
			get
			{
				if(r_Concat_String_String_String_String == null)
				{
					r_Concat_String_String_String_String = new(typeof(System.String), "Concat", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.String));
					r_Concat_String_String_String_String.SetBelong(null);
				}
				return r_Concat_String_String_String_String;
			}
		}

		/// <summary>
		/// System.String Concat(System.String[])
		/// </summary>
		protected static RMethod r_Concat_StringArray;
		public static RMethod RConcat_StringArray
		{
			get
			{
				if(r_Concat_StringArray == null)
				{
					r_Concat_StringArray = new(typeof(System.String), "Concat", 0, typeof(System.String).MakeArrayType());
					r_Concat_StringArray.SetBelong(null);
				}
				return r_Concat_StringArray;
			}
		}

		/// <summary>
		/// System.String Format(System.String, System.Object)
		/// </summary>
		protected static RMethod r_Format_String_Object;
		public static RMethod RFormat_String_Object
		{
			get
			{
				if(r_Format_String_Object == null)
				{
					r_Format_String_Object = new(typeof(System.String), "Format", 0, typeof(System.String), typeof(System.Object));
					r_Format_String_Object.SetBelong(null);
				}
				return r_Format_String_Object;
			}
		}

		/// <summary>
		/// System.String Format(System.String, System.Object, System.Object)
		/// </summary>
		protected static RMethod r_Format_String_Object_Object;
		public static RMethod RFormat_String_Object_Object
		{
			get
			{
				if(r_Format_String_Object_Object == null)
				{
					r_Format_String_Object_Object = new(typeof(System.String), "Format", 0, typeof(System.String), typeof(System.Object), typeof(System.Object));
					r_Format_String_Object_Object.SetBelong(null);
				}
				return r_Format_String_Object_Object;
			}
		}

		/// <summary>
		/// System.String Format(System.String, System.Object, System.Object, System.Object)
		/// </summary>
		protected static RMethod r_Format_String_Object_Object_Object;
		public static RMethod RFormat_String_Object_Object_Object
		{
			get
			{
				if(r_Format_String_Object_Object_Object == null)
				{
					r_Format_String_Object_Object_Object = new(typeof(System.String), "Format", 0, typeof(System.String), typeof(System.Object), typeof(System.Object), typeof(System.Object));
					r_Format_String_Object_Object_Object.SetBelong(null);
				}
				return r_Format_String_Object_Object_Object;
			}
		}

		/// <summary>
		/// System.String Format(System.String, System.Object[])
		/// </summary>
		protected static RMethod r_Format_String_ObjectArray;
		public static RMethod RFormat_String_ObjectArray
		{
			get
			{
				if(r_Format_String_ObjectArray == null)
				{
					r_Format_String_ObjectArray = new(typeof(System.String), "Format", 0, typeof(System.String), typeof(System.Object).MakeArrayType());
					r_Format_String_ObjectArray.SetBelong(null);
				}
				return r_Format_String_ObjectArray;
			}
		}

		/// <summary>
		/// System.String Format(System.IFormatProvider, System.String, System.Object)
		/// </summary>
		protected static RMethod r_Format_IFormatProvider_String_Object;
		public static RMethod RFormat_IFormatProvider_String_Object
		{
			get
			{
				if(r_Format_IFormatProvider_String_Object == null)
				{
					r_Format_IFormatProvider_String_Object = new(typeof(System.String), "Format", 0, typeof(System.IFormatProvider), typeof(System.String), typeof(System.Object));
					r_Format_IFormatProvider_String_Object.SetBelong(null);
				}
				return r_Format_IFormatProvider_String_Object;
			}
		}

		/// <summary>
		/// System.String Format(System.IFormatProvider, System.String, System.Object, System.Object)
		/// </summary>
		protected static RMethod r_Format_IFormatProvider_String_Object_Object;
		public static RMethod RFormat_IFormatProvider_String_Object_Object
		{
			get
			{
				if(r_Format_IFormatProvider_String_Object_Object == null)
				{
					r_Format_IFormatProvider_String_Object_Object = new(typeof(System.String), "Format", 0, typeof(System.IFormatProvider), typeof(System.String), typeof(System.Object), typeof(System.Object));
					r_Format_IFormatProvider_String_Object_Object.SetBelong(null);
				}
				return r_Format_IFormatProvider_String_Object_Object;
			}
		}

		/// <summary>
		/// System.String Format(System.IFormatProvider, System.String, System.Object, System.Object, System.Object)
		/// </summary>
		protected static RMethod r_Format_IFormatProvider_String_Object_Object_Object;
		public static RMethod RFormat_IFormatProvider_String_Object_Object_Object
		{
			get
			{
				if(r_Format_IFormatProvider_String_Object_Object_Object == null)
				{
					r_Format_IFormatProvider_String_Object_Object_Object = new(typeof(System.String), "Format", 0, typeof(System.IFormatProvider), typeof(System.String), typeof(System.Object), typeof(System.Object), typeof(System.Object));
					r_Format_IFormatProvider_String_Object_Object_Object.SetBelong(null);
				}
				return r_Format_IFormatProvider_String_Object_Object_Object;
			}
		}

		/// <summary>
		/// System.String Format(System.IFormatProvider, System.String, System.Object[])
		/// </summary>
		protected static RMethod r_Format_IFormatProvider_String_ObjectArray;
		public static RMethod RFormat_IFormatProvider_String_ObjectArray
		{
			get
			{
				if(r_Format_IFormatProvider_String_ObjectArray == null)
				{
					r_Format_IFormatProvider_String_ObjectArray = new(typeof(System.String), "Format", 0, typeof(System.IFormatProvider), typeof(System.String), typeof(System.Object).MakeArrayType());
					r_Format_IFormatProvider_String_ObjectArray.SetBelong(null);
				}
				return r_Format_IFormatProvider_String_ObjectArray;
			}
		}

		/// <summary>
		/// System.String FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
		/// </summary>
		protected static RMethod r_FormatHelper_IFormatProvider_String_ParamsArray;
		public static RMethod RFormatHelper_IFormatProvider_String_ParamsArray
		{
			get
			{
				if(r_FormatHelper_IFormatProvider_String_ParamsArray == null)
				{
					r_FormatHelper_IFormatProvider_String_ParamsArray = new(typeof(System.String), "FormatHelper", 0, typeof(System.IFormatProvider), typeof(System.String),  ReflectionUtils.GetType("System.ParamsArray"));
					r_FormatHelper_IFormatProvider_String_ParamsArray.SetBelong(null);
				}
				return r_FormatHelper_IFormatProvider_String_ParamsArray;
			}
		}

		/// <summary>
		/// System.String Insert(Int32, System.String)
		/// </summary>
		protected RMethod r_Insert_Int32_String;
		public virtual RMethod RInsert_Int32_String
		{
			get
			{
				if(r_Insert_Int32_String == null)
				{
					r_Insert_Int32_String = new(this, "Insert", 0, typeof(System.Int32), typeof(System.String));
					r_Insert_Int32_String.SetBelong(this.instance);
				}
				return r_Insert_Int32_String;
			}
		}

		/// <summary>
		/// System.String Join(Char, System.String[])
		/// </summary>
		protected static RMethod r_Join_Char_StringArray;
		public static RMethod RJoin_Char_StringArray
		{
			get
			{
				if(r_Join_Char_StringArray == null)
				{
					r_Join_Char_StringArray = new(typeof(System.String), "Join", 0, typeof(System.Char), typeof(System.String).MakeArrayType());
					r_Join_Char_StringArray.SetBelong(null);
				}
				return r_Join_Char_StringArray;
			}
		}

		/// <summary>
		/// System.String Join(Char, System.Object[])
		/// </summary>
		protected static RMethod r_Join_Char_ObjectArray;
		public static RMethod RJoin_Char_ObjectArray
		{
			get
			{
				if(r_Join_Char_ObjectArray == null)
				{
					r_Join_Char_ObjectArray = new(typeof(System.String), "Join", 0, typeof(System.Char), typeof(System.Object).MakeArrayType());
					r_Join_Char_ObjectArray.SetBelong(null);
				}
				return r_Join_Char_ObjectArray;
			}
		}

		/// <summary>
		/// System.String Join[T](Char, System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected static RMethod r_Join_GT_Char_IEnumerable_d_T_p_;
		public static RMethod RJoin_GT_Char_IEnumerable_d_T_p_
		{
			get
			{
				if(r_Join_GT_Char_IEnumerable_d_T_p_ == null)
				{
					r_Join_GT_Char_IEnumerable_d_T_p_ = new(typeof(System.String), "Join", 1, typeof(System.Char), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_Join_GT_Char_IEnumerable_d_T_p_.SetBelong(null);
				}
				return r_Join_GT_Char_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// System.String Join(Char, System.String[], Int32, Int32)
		/// </summary>
		protected static RMethod r_Join_Char_StringArray_Int32_Int32;
		public static RMethod RJoin_Char_StringArray_Int32_Int32
		{
			get
			{
				if(r_Join_Char_StringArray_Int32_Int32 == null)
				{
					r_Join_Char_StringArray_Int32_Int32 = new(typeof(System.String), "Join", 0, typeof(System.Char), typeof(System.String).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_Join_Char_StringArray_Int32_Int32.SetBelong(null);
				}
				return r_Join_Char_StringArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String Join(System.String, System.String[])
		/// </summary>
		protected static RMethod r_Join_String_StringArray;
		public static RMethod RJoin_String_StringArray
		{
			get
			{
				if(r_Join_String_StringArray == null)
				{
					r_Join_String_StringArray = new(typeof(System.String), "Join", 0, typeof(System.String), typeof(System.String).MakeArrayType());
					r_Join_String_StringArray.SetBelong(null);
				}
				return r_Join_String_StringArray;
			}
		}

		/// <summary>
		/// System.String Join(System.String, System.Object[])
		/// </summary>
		protected static RMethod r_Join_String_ObjectArray;
		public static RMethod RJoin_String_ObjectArray
		{
			get
			{
				if(r_Join_String_ObjectArray == null)
				{
					r_Join_String_ObjectArray = new(typeof(System.String), "Join", 0, typeof(System.String), typeof(System.Object).MakeArrayType());
					r_Join_String_ObjectArray.SetBelong(null);
				}
				return r_Join_String_ObjectArray;
			}
		}

		/// <summary>
		/// System.String Join[T](System.String, System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected static RMethod r_Join_GT_String_IEnumerable_d_T_p_;
		public static RMethod RJoin_GT_String_IEnumerable_d_T_p_
		{
			get
			{
				if(r_Join_GT_String_IEnumerable_d_T_p_ == null)
				{
					r_Join_GT_String_IEnumerable_d_T_p_ = new(typeof(System.String), "Join", 1, typeof(System.String), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_Join_GT_String_IEnumerable_d_T_p_.SetBelong(null);
				}
				return r_Join_GT_String_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// System.String Join(System.String, System.Collections.Generic.IEnumerable`1[System.String])
		/// </summary>
		protected static RMethod r_Join_String_IEnumerable_d_String_p_;
		public static RMethod RJoin_String_IEnumerable_d_String_p_
		{
			get
			{
				if(r_Join_String_IEnumerable_d_String_p_ == null)
				{
					r_Join_String_IEnumerable_d_String_p_ = new(typeof(System.String), "Join", 0, typeof(System.String), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.String)));
					r_Join_String_IEnumerable_d_String_p_.SetBelong(null);
				}
				return r_Join_String_IEnumerable_d_String_p_;
			}
		}

		/// <summary>
		/// System.String Join(System.String, System.String[], Int32, Int32)
		/// </summary>
		protected static RMethod r_Join_String_StringArray_Int32_Int32;
		public static RMethod RJoin_String_StringArray_Int32_Int32
		{
			get
			{
				if(r_Join_String_StringArray_Int32_Int32 == null)
				{
					r_Join_String_StringArray_Int32_Int32 = new(typeof(System.String), "Join", 0, typeof(System.String), typeof(System.String).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_Join_String_StringArray_Int32_Int32.SetBelong(null);
				}
				return r_Join_String_StringArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String JoinCore(Char*, Int32, System.Object[])
		/// </summary>
		protected static RMethod r_JoinCore_CharPointer_Int32_ObjectArray;
		public static RMethod RJoinCore_CharPointer_Int32_ObjectArray
		{
			get
			{
				if(r_JoinCore_CharPointer_Int32_ObjectArray == null)
				{
					r_JoinCore_CharPointer_Int32_ObjectArray = new(typeof(System.String), "JoinCore", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Object).MakeArrayType());
					r_JoinCore_CharPointer_Int32_ObjectArray.SetBelong(null);
				}
				return r_JoinCore_CharPointer_Int32_ObjectArray;
			}
		}

		/// <summary>
		/// System.String JoinCore[T](Char*, Int32, System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected static RMethod r_JoinCore_GT_CharPointer_Int32_IEnumerable_d_T_p_;
		public static RMethod RJoinCore_GT_CharPointer_Int32_IEnumerable_d_T_p_
		{
			get
			{
				if(r_JoinCore_GT_CharPointer_Int32_IEnumerable_d_T_p_ == null)
				{
					r_JoinCore_GT_CharPointer_Int32_IEnumerable_d_T_p_ = new(typeof(System.String), "JoinCore", 1, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_JoinCore_GT_CharPointer_Int32_IEnumerable_d_T_p_.SetBelong(null);
				}
				return r_JoinCore_GT_CharPointer_Int32_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// System.String JoinCore(Char*, Int32, System.String[], Int32, Int32)
		/// </summary>
		protected static RMethod r_JoinCore_CharPointer_Int32_StringArray_Int32_Int32;
		public static RMethod RJoinCore_CharPointer_Int32_StringArray_Int32_Int32
		{
			get
			{
				if(r_JoinCore_CharPointer_Int32_StringArray_Int32_Int32 == null)
				{
					r_JoinCore_CharPointer_Int32_StringArray_Int32_Int32 = new(typeof(System.String), "JoinCore", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.String).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_JoinCore_CharPointer_Int32_StringArray_Int32_Int32.SetBelong(null);
				}
				return r_JoinCore_CharPointer_Int32_StringArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String PadLeft(Int32)
		/// </summary>
		protected RMethod r_PadLeft_Int32;
		public virtual RMethod RPadLeft_Int32
		{
			get
			{
				if(r_PadLeft_Int32 == null)
				{
					r_PadLeft_Int32 = new(this, "PadLeft", 0, typeof(System.Int32));
					r_PadLeft_Int32.SetBelong(this.instance);
				}
				return r_PadLeft_Int32;
			}
		}

		/// <summary>
		/// System.String PadLeft(Int32, Char)
		/// </summary>
		protected RMethod r_PadLeft_Int32_Char;
		public virtual RMethod RPadLeft_Int32_Char
		{
			get
			{
				if(r_PadLeft_Int32_Char == null)
				{
					r_PadLeft_Int32_Char = new(this, "PadLeft", 0, typeof(System.Int32), typeof(System.Char));
					r_PadLeft_Int32_Char.SetBelong(this.instance);
				}
				return r_PadLeft_Int32_Char;
			}
		}

		/// <summary>
		/// System.String PadRight(Int32)
		/// </summary>
		protected RMethod r_PadRight_Int32;
		public virtual RMethod RPadRight_Int32
		{
			get
			{
				if(r_PadRight_Int32 == null)
				{
					r_PadRight_Int32 = new(this, "PadRight", 0, typeof(System.Int32));
					r_PadRight_Int32.SetBelong(this.instance);
				}
				return r_PadRight_Int32;
			}
		}

		/// <summary>
		/// System.String PadRight(Int32, Char)
		/// </summary>
		protected RMethod r_PadRight_Int32_Char;
		public virtual RMethod RPadRight_Int32_Char
		{
			get
			{
				if(r_PadRight_Int32_Char == null)
				{
					r_PadRight_Int32_Char = new(this, "PadRight", 0, typeof(System.Int32), typeof(System.Char));
					r_PadRight_Int32_Char.SetBelong(this.instance);
				}
				return r_PadRight_Int32_Char;
			}
		}

		/// <summary>
		/// System.String Remove(Int32, Int32)
		/// </summary>
		protected RMethod r_Remove_Int32_Int32;
		public virtual RMethod RRemove_Int32_Int32
		{
			get
			{
				if(r_Remove_Int32_Int32 == null)
				{
					r_Remove_Int32_Int32 = new(this, "Remove", 0, typeof(System.Int32), typeof(System.Int32));
					r_Remove_Int32_Int32.SetBelong(this.instance);
				}
				return r_Remove_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String Remove(Int32)
		/// </summary>
		protected RMethod r_Remove_Int32;
		public virtual RMethod RRemove_Int32
		{
			get
			{
				if(r_Remove_Int32 == null)
				{
					r_Remove_Int32 = new(this, "Remove", 0, typeof(System.Int32));
					r_Remove_Int32.SetBelong(this.instance);
				}
				return r_Remove_Int32;
			}
		}

		/// <summary>
		/// System.String Replace(System.String, System.String, Boolean, System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_Replace_String_String_Boolean_CultureInfo;
		public virtual RMethod RReplace_String_String_Boolean_CultureInfo
		{
			get
			{
				if(r_Replace_String_String_Boolean_CultureInfo == null)
				{
					r_Replace_String_String_Boolean_CultureInfo = new(this, "Replace", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.Globalization.CultureInfo));
					r_Replace_String_String_Boolean_CultureInfo.SetBelong(this.instance);
				}
				return r_Replace_String_String_Boolean_CultureInfo;
			}
		}

		/// <summary>
		/// System.String Replace(System.String, System.String, System.StringComparison)
		/// </summary>
		protected RMethod r_Replace_String_String_StringComparison;
		public virtual RMethod RReplace_String_String_StringComparison
		{
			get
			{
				if(r_Replace_String_String_StringComparison == null)
				{
					r_Replace_String_String_StringComparison = new(this, "Replace", 0, typeof(System.String), typeof(System.String), typeof(System.StringComparison));
					r_Replace_String_String_StringComparison.SetBelong(this.instance);
				}
				return r_Replace_String_String_StringComparison;
			}
		}

		/// <summary>
		/// System.String ReplaceCore(System.String, System.String, System.Globalization.CultureInfo, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_ReplaceCore_String_String_CultureInfo_CompareOptions;
		public virtual RMethod RReplaceCore_String_String_CultureInfo_CompareOptions
		{
			get
			{
				if(r_ReplaceCore_String_String_CultureInfo_CompareOptions == null)
				{
					r_ReplaceCore_String_String_CultureInfo_CompareOptions = new(this, "ReplaceCore", 0, typeof(System.String), typeof(System.String), typeof(System.Globalization.CultureInfo), typeof(System.Globalization.CompareOptions));
					r_ReplaceCore_String_String_CultureInfo_CompareOptions.SetBelong(this.instance);
				}
				return r_ReplaceCore_String_String_CultureInfo_CompareOptions;
			}
		}

		/// <summary>
		/// System.String Replace(Char, Char)
		/// </summary>
		protected RMethod r_Replace_Char_Char;
		public virtual RMethod RReplace_Char_Char
		{
			get
			{
				if(r_Replace_Char_Char == null)
				{
					r_Replace_Char_Char = new(this, "Replace", 0, typeof(System.Char), typeof(System.Char));
					r_Replace_Char_Char.SetBelong(this.instance);
				}
				return r_Replace_Char_Char;
			}
		}

		/// <summary>
		/// System.String Replace(System.String, System.String)
		/// </summary>
		protected RMethod r_Replace_String_String;
		public virtual RMethod RReplace_String_String
		{
			get
			{
				if(r_Replace_String_String == null)
				{
					r_Replace_String_String = new(this, "Replace", 0, typeof(System.String), typeof(System.String));
					r_Replace_String_String.SetBelong(this.instance);
				}
				return r_Replace_String_String;
			}
		}

		/// <summary>
		/// System.String ReplaceHelper(Int32, System.String, System.ReadOnlySpan`1[System.Int32])
		/// </summary>
		protected RMethod r_ReplaceHelper_Int32_String_ReadOnlySpan_d_Int32_p_;
		public virtual RMethod RReplaceHelper_Int32_String_ReadOnlySpan_d_Int32_p_
		{
			get
			{
				if(r_ReplaceHelper_Int32_String_ReadOnlySpan_d_Int32_p_ == null)
				{
					r_ReplaceHelper_Int32_String_ReadOnlySpan_d_Int32_p_ = new(this, "ReplaceHelper", 0, typeof(System.Int32), typeof(System.String), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Int32)));
					r_ReplaceHelper_Int32_String_ReadOnlySpan_d_Int32_p_.SetBelong(this.instance);
				}
				return r_ReplaceHelper_Int32_String_ReadOnlySpan_d_Int32_p_;
			}
		}

		/// <summary>
		/// System.String[] Split(Char, System.StringSplitOptions)
		/// </summary>
		protected RMethod r_Split_Char_StringSplitOptions;
		public virtual RMethod RSplit_Char_StringSplitOptions
		{
			get
			{
				if(r_Split_Char_StringSplitOptions == null)
				{
					r_Split_Char_StringSplitOptions = new(this, "Split", 0, typeof(System.Char), typeof(System.StringSplitOptions));
					r_Split_Char_StringSplitOptions.SetBelong(this.instance);
				}
				return r_Split_Char_StringSplitOptions;
			}
		}

		/// <summary>
		/// System.String[] Split(Char, Int32, System.StringSplitOptions)
		/// </summary>
		protected RMethod r_Split_Char_Int32_StringSplitOptions;
		public virtual RMethod RSplit_Char_Int32_StringSplitOptions
		{
			get
			{
				if(r_Split_Char_Int32_StringSplitOptions == null)
				{
					r_Split_Char_Int32_StringSplitOptions = new(this, "Split", 0, typeof(System.Char), typeof(System.Int32), typeof(System.StringSplitOptions));
					r_Split_Char_Int32_StringSplitOptions.SetBelong(this.instance);
				}
				return r_Split_Char_Int32_StringSplitOptions;
			}
		}

		/// <summary>
		/// System.String[] Split(Char[])
		/// </summary>
		protected RMethod r_Split_CharArray;
		public virtual RMethod RSplit_CharArray
		{
			get
			{
				if(r_Split_CharArray == null)
				{
					r_Split_CharArray = new(this, "Split", 0, typeof(System.Char).MakeArrayType());
					r_Split_CharArray.SetBelong(this.instance);
				}
				return r_Split_CharArray;
			}
		}

		/// <summary>
		/// System.String[] Split(Char[], Int32)
		/// </summary>
		protected RMethod r_Split_CharArray_Int32;
		public virtual RMethod RSplit_CharArray_Int32
		{
			get
			{
				if(r_Split_CharArray_Int32 == null)
				{
					r_Split_CharArray_Int32 = new(this, "Split", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32));
					r_Split_CharArray_Int32.SetBelong(this.instance);
				}
				return r_Split_CharArray_Int32;
			}
		}

		/// <summary>
		/// System.String[] Split(Char[], System.StringSplitOptions)
		/// </summary>
		protected RMethod r_Split_CharArray_StringSplitOptions;
		public virtual RMethod RSplit_CharArray_StringSplitOptions
		{
			get
			{
				if(r_Split_CharArray_StringSplitOptions == null)
				{
					r_Split_CharArray_StringSplitOptions = new(this, "Split", 0, typeof(System.Char).MakeArrayType(), typeof(System.StringSplitOptions));
					r_Split_CharArray_StringSplitOptions.SetBelong(this.instance);
				}
				return r_Split_CharArray_StringSplitOptions;
			}
		}

		/// <summary>
		/// System.String[] Split(Char[], Int32, System.StringSplitOptions)
		/// </summary>
		protected RMethod r_Split_CharArray_Int32_StringSplitOptions;
		public virtual RMethod RSplit_CharArray_Int32_StringSplitOptions
		{
			get
			{
				if(r_Split_CharArray_Int32_StringSplitOptions == null)
				{
					r_Split_CharArray_Int32_StringSplitOptions = new(this, "Split", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.StringSplitOptions));
					r_Split_CharArray_Int32_StringSplitOptions.SetBelong(this.instance);
				}
				return r_Split_CharArray_Int32_StringSplitOptions;
			}
		}

		/// <summary>
		/// System.String[] SplitInternal(System.ReadOnlySpan`1[System.Char], Int32, System.StringSplitOptions)
		/// </summary>
		protected RMethod r_SplitInternal_ReadOnlySpan_d_Char_p__Int32_StringSplitOptions;
		public virtual RMethod RSplitInternal_ReadOnlySpan_d_Char_p__Int32_StringSplitOptions
		{
			get
			{
				if(r_SplitInternal_ReadOnlySpan_d_Char_p__Int32_StringSplitOptions == null)
				{
					r_SplitInternal_ReadOnlySpan_d_Char_p__Int32_StringSplitOptions = new(this, "SplitInternal", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Int32), typeof(System.StringSplitOptions));
					r_SplitInternal_ReadOnlySpan_d_Char_p__Int32_StringSplitOptions.SetBelong(this.instance);
				}
				return r_SplitInternal_ReadOnlySpan_d_Char_p__Int32_StringSplitOptions;
			}
		}

		/// <summary>
		/// System.String[] Split(System.String, System.StringSplitOptions)
		/// </summary>
		protected RMethod r_Split_String_StringSplitOptions;
		public virtual RMethod RSplit_String_StringSplitOptions
		{
			get
			{
				if(r_Split_String_StringSplitOptions == null)
				{
					r_Split_String_StringSplitOptions = new(this, "Split", 0, typeof(System.String), typeof(System.StringSplitOptions));
					r_Split_String_StringSplitOptions.SetBelong(this.instance);
				}
				return r_Split_String_StringSplitOptions;
			}
		}

		/// <summary>
		/// System.String[] Split(System.String, Int32, System.StringSplitOptions)
		/// </summary>
		protected RMethod r_Split_String_Int32_StringSplitOptions;
		public virtual RMethod RSplit_String_Int32_StringSplitOptions
		{
			get
			{
				if(r_Split_String_Int32_StringSplitOptions == null)
				{
					r_Split_String_Int32_StringSplitOptions = new(this, "Split", 0, typeof(System.String), typeof(System.Int32), typeof(System.StringSplitOptions));
					r_Split_String_Int32_StringSplitOptions.SetBelong(this.instance);
				}
				return r_Split_String_Int32_StringSplitOptions;
			}
		}

		/// <summary>
		/// System.String[] Split(System.String[], System.StringSplitOptions)
		/// </summary>
		protected RMethod r_Split_StringArray_StringSplitOptions;
		public virtual RMethod RSplit_StringArray_StringSplitOptions
		{
			get
			{
				if(r_Split_StringArray_StringSplitOptions == null)
				{
					r_Split_StringArray_StringSplitOptions = new(this, "Split", 0, typeof(System.String).MakeArrayType(), typeof(System.StringSplitOptions));
					r_Split_StringArray_StringSplitOptions.SetBelong(this.instance);
				}
				return r_Split_StringArray_StringSplitOptions;
			}
		}

		/// <summary>
		/// System.String[] Split(System.String[], Int32, System.StringSplitOptions)
		/// </summary>
		protected RMethod r_Split_StringArray_Int32_StringSplitOptions;
		public virtual RMethod RSplit_StringArray_Int32_StringSplitOptions
		{
			get
			{
				if(r_Split_StringArray_Int32_StringSplitOptions == null)
				{
					r_Split_StringArray_Int32_StringSplitOptions = new(this, "Split", 0, typeof(System.String).MakeArrayType(), typeof(System.Int32), typeof(System.StringSplitOptions));
					r_Split_StringArray_Int32_StringSplitOptions.SetBelong(this.instance);
				}
				return r_Split_StringArray_Int32_StringSplitOptions;
			}
		}

		/// <summary>
		/// System.String[] SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
		/// </summary>
		protected RMethod r_SplitInternal_String_StringArray_Int32_StringSplitOptions;
		public virtual RMethod RSplitInternal_String_StringArray_Int32_StringSplitOptions
		{
			get
			{
				if(r_SplitInternal_String_StringArray_Int32_StringSplitOptions == null)
				{
					r_SplitInternal_String_StringArray_Int32_StringSplitOptions = new(this, "SplitInternal", 0, typeof(System.String), typeof(System.String).MakeArrayType(), typeof(System.Int32), typeof(System.StringSplitOptions));
					r_SplitInternal_String_StringArray_Int32_StringSplitOptions.SetBelong(this.instance);
				}
				return r_SplitInternal_String_StringArray_Int32_StringSplitOptions;
			}
		}

		/// <summary>
		/// System.String[] SplitInternal(System.String, Int32, System.StringSplitOptions)
		/// </summary>
		protected RMethod r_SplitInternal_String_Int32_StringSplitOptions;
		public virtual RMethod RSplitInternal_String_Int32_StringSplitOptions
		{
			get
			{
				if(r_SplitInternal_String_Int32_StringSplitOptions == null)
				{
					r_SplitInternal_String_Int32_StringSplitOptions = new(this, "SplitInternal", 0, typeof(System.String), typeof(System.Int32), typeof(System.StringSplitOptions));
					r_SplitInternal_String_Int32_StringSplitOptions.SetBelong(this.instance);
				}
				return r_SplitInternal_String_Int32_StringSplitOptions;
			}
		}

		/// <summary>
		/// System.String[] SplitKeepEmptyEntries(System.ReadOnlySpan`1[System.Int32], System.ReadOnlySpan`1[System.Int32], Int32, Int32)
		/// </summary>
		protected RMethod r_SplitKeepEmptyEntries_ReadOnlySpan_d_Int32_p__ReadOnlySpan_d_Int32_p__Int32_Int32;
		public virtual RMethod RSplitKeepEmptyEntries_ReadOnlySpan_d_Int32_p__ReadOnlySpan_d_Int32_p__Int32_Int32
		{
			get
			{
				if(r_SplitKeepEmptyEntries_ReadOnlySpan_d_Int32_p__ReadOnlySpan_d_Int32_p__Int32_Int32 == null)
				{
					r_SplitKeepEmptyEntries_ReadOnlySpan_d_Int32_p__ReadOnlySpan_d_Int32_p__Int32_Int32 = new(this, "SplitKeepEmptyEntries", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Int32)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Int32)), typeof(System.Int32), typeof(System.Int32));
					r_SplitKeepEmptyEntries_ReadOnlySpan_d_Int32_p__ReadOnlySpan_d_Int32_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_SplitKeepEmptyEntries_ReadOnlySpan_d_Int32_p__ReadOnlySpan_d_Int32_p__Int32_Int32;
			}
		}

		/// <summary>
		/// System.String[] SplitOmitEmptyEntries(System.ReadOnlySpan`1[System.Int32], System.ReadOnlySpan`1[System.Int32], Int32, Int32)
		/// </summary>
		protected RMethod r_SplitOmitEmptyEntries_ReadOnlySpan_d_Int32_p__ReadOnlySpan_d_Int32_p__Int32_Int32;
		public virtual RMethod RSplitOmitEmptyEntries_ReadOnlySpan_d_Int32_p__ReadOnlySpan_d_Int32_p__Int32_Int32
		{
			get
			{
				if(r_SplitOmitEmptyEntries_ReadOnlySpan_d_Int32_p__ReadOnlySpan_d_Int32_p__Int32_Int32 == null)
				{
					r_SplitOmitEmptyEntries_ReadOnlySpan_d_Int32_p__ReadOnlySpan_d_Int32_p__Int32_Int32 = new(this, "SplitOmitEmptyEntries", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Int32)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Int32)), typeof(System.Int32), typeof(System.Int32));
					r_SplitOmitEmptyEntries_ReadOnlySpan_d_Int32_p__ReadOnlySpan_d_Int32_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_SplitOmitEmptyEntries_ReadOnlySpan_d_Int32_p__ReadOnlySpan_d_Int32_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void MakeSeparatorList(System.ReadOnlySpan`1[System.Char], System.Collections.Generic.ValueListBuilder`1[System.Int32] ByRef)
		/// </summary>
		protected RMethod r_MakeSeparatorList_ReadOnlySpan_d_Char_p__Ref_ValueListBuilder_d_Int32_p_;
		public virtual RMethod RMakeSeparatorList_ReadOnlySpan_d_Char_p__Ref_ValueListBuilder_d_Int32_p_
		{
			get
			{
				if(r_MakeSeparatorList_ReadOnlySpan_d_Char_p__Ref_ValueListBuilder_d_Int32_p_ == null)
				{
					r_MakeSeparatorList_ReadOnlySpan_d_Char_p__Ref_ValueListBuilder_d_Int32_p_ = new(this, "MakeSeparatorList", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)),  ReflectionUtils.GetType("System.Collections.Generic.ValueListBuilder`1").MakeGenericType(typeof(System.Int32)).MakeByRefType());
					r_MakeSeparatorList_ReadOnlySpan_d_Char_p__Ref_ValueListBuilder_d_Int32_p_.SetBelong(this.instance);
				}
				return r_MakeSeparatorList_ReadOnlySpan_d_Char_p__Ref_ValueListBuilder_d_Int32_p_;
			}
		}

		/// <summary>
		/// Void MakeSeparatorList(System.String, System.Collections.Generic.ValueListBuilder`1[System.Int32] ByRef)
		/// </summary>
		protected RMethod r_MakeSeparatorList_String_Ref_ValueListBuilder_d_Int32_p_;
		public virtual RMethod RMakeSeparatorList_String_Ref_ValueListBuilder_d_Int32_p_
		{
			get
			{
				if(r_MakeSeparatorList_String_Ref_ValueListBuilder_d_Int32_p_ == null)
				{
					r_MakeSeparatorList_String_Ref_ValueListBuilder_d_Int32_p_ = new(this, "MakeSeparatorList", 0, typeof(System.String),  ReflectionUtils.GetType("System.Collections.Generic.ValueListBuilder`1").MakeGenericType(typeof(System.Int32)).MakeByRefType());
					r_MakeSeparatorList_String_Ref_ValueListBuilder_d_Int32_p_.SetBelong(this.instance);
				}
				return r_MakeSeparatorList_String_Ref_ValueListBuilder_d_Int32_p_;
			}
		}

		/// <summary>
		/// Void MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1[System.Int32] ByRef, System.Collections.Generic.ValueListBuilder`1[System.Int32] ByRef)
		/// </summary>
		protected RMethod r_MakeSeparatorList_StringArray_Ref_ValueListBuilder_d_Int32_p__Ref_ValueListBuilder_d_Int32_p_;
		public virtual RMethod RMakeSeparatorList_StringArray_Ref_ValueListBuilder_d_Int32_p__Ref_ValueListBuilder_d_Int32_p_
		{
			get
			{
				if(r_MakeSeparatorList_StringArray_Ref_ValueListBuilder_d_Int32_p__Ref_ValueListBuilder_d_Int32_p_ == null)
				{
					r_MakeSeparatorList_StringArray_Ref_ValueListBuilder_d_Int32_p__Ref_ValueListBuilder_d_Int32_p_ = new(this, "MakeSeparatorList", 0, typeof(System.String).MakeArrayType(),  ReflectionUtils.GetType("System.Collections.Generic.ValueListBuilder`1").MakeGenericType(typeof(System.Int32)).MakeByRefType(),  ReflectionUtils.GetType("System.Collections.Generic.ValueListBuilder`1").MakeGenericType(typeof(System.Int32)).MakeByRefType());
					r_MakeSeparatorList_StringArray_Ref_ValueListBuilder_d_Int32_p__Ref_ValueListBuilder_d_Int32_p_.SetBelong(this.instance);
				}
				return r_MakeSeparatorList_StringArray_Ref_ValueListBuilder_d_Int32_p__Ref_ValueListBuilder_d_Int32_p_;
			}
		}

		/// <summary>
		/// System.String Substring(Int32)
		/// </summary>
		protected RMethod r_Substring_Int32;
		public virtual RMethod RSubstring_Int32
		{
			get
			{
				if(r_Substring_Int32 == null)
				{
					r_Substring_Int32 = new(this, "Substring", 0, typeof(System.Int32));
					r_Substring_Int32.SetBelong(this.instance);
				}
				return r_Substring_Int32;
			}
		}

		/// <summary>
		/// System.String Substring(Int32, Int32)
		/// </summary>
		protected RMethod r_Substring_Int32_Int32;
		public virtual RMethod RSubstring_Int32_Int32
		{
			get
			{
				if(r_Substring_Int32_Int32 == null)
				{
					r_Substring_Int32_Int32 = new(this, "Substring", 0, typeof(System.Int32), typeof(System.Int32));
					r_Substring_Int32_Int32.SetBelong(this.instance);
				}
				return r_Substring_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String InternalSubString(Int32, Int32)
		/// </summary>
		protected RMethod r_InternalSubString_Int32_Int32;
		public virtual RMethod RInternalSubString_Int32_Int32
		{
			get
			{
				if(r_InternalSubString_Int32_Int32 == null)
				{
					r_InternalSubString_Int32_Int32 = new(this, "InternalSubString", 0, typeof(System.Int32), typeof(System.Int32));
					r_InternalSubString_Int32_Int32.SetBelong(this.instance);
				}
				return r_InternalSubString_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String ToLower()
		/// </summary>
		protected RMethod r_ToLower;
		public virtual RMethod RToLower
		{
			get
			{
				if(r_ToLower == null)
				{
					r_ToLower = new(this, "ToLower", 0);
					r_ToLower.SetBelong(this.instance);
				}
				return r_ToLower;
			}
		}

		/// <summary>
		/// System.String ToLower(System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_ToLower_CultureInfo;
		public virtual RMethod RToLower_CultureInfo
		{
			get
			{
				if(r_ToLower_CultureInfo == null)
				{
					r_ToLower_CultureInfo = new(this, "ToLower", 0, typeof(System.Globalization.CultureInfo));
					r_ToLower_CultureInfo.SetBelong(this.instance);
				}
				return r_ToLower_CultureInfo;
			}
		}

		/// <summary>
		/// System.String ToLowerInvariant()
		/// </summary>
		protected RMethod r_ToLowerInvariant;
		public virtual RMethod RToLowerInvariant
		{
			get
			{
				if(r_ToLowerInvariant == null)
				{
					r_ToLowerInvariant = new(this, "ToLowerInvariant", 0);
					r_ToLowerInvariant.SetBelong(this.instance);
				}
				return r_ToLowerInvariant;
			}
		}

		/// <summary>
		/// System.String ToUpper()
		/// </summary>
		protected RMethod r_ToUpper;
		public virtual RMethod RToUpper
		{
			get
			{
				if(r_ToUpper == null)
				{
					r_ToUpper = new(this, "ToUpper", 0);
					r_ToUpper.SetBelong(this.instance);
				}
				return r_ToUpper;
			}
		}

		/// <summary>
		/// System.String ToUpper(System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_ToUpper_CultureInfo;
		public virtual RMethod RToUpper_CultureInfo
		{
			get
			{
				if(r_ToUpper_CultureInfo == null)
				{
					r_ToUpper_CultureInfo = new(this, "ToUpper", 0, typeof(System.Globalization.CultureInfo));
					r_ToUpper_CultureInfo.SetBelong(this.instance);
				}
				return r_ToUpper_CultureInfo;
			}
		}

		/// <summary>
		/// System.String ToUpperInvariant()
		/// </summary>
		protected RMethod r_ToUpperInvariant;
		public virtual RMethod RToUpperInvariant
		{
			get
			{
				if(r_ToUpperInvariant == null)
				{
					r_ToUpperInvariant = new(this, "ToUpperInvariant", 0);
					r_ToUpperInvariant.SetBelong(this.instance);
				}
				return r_ToUpperInvariant;
			}
		}

		/// <summary>
		/// System.String Trim()
		/// </summary>
		protected RMethod r_Trim;
		public virtual RMethod RTrim
		{
			get
			{
				if(r_Trim == null)
				{
					r_Trim = new(this, "Trim", 0);
					r_Trim.SetBelong(this.instance);
				}
				return r_Trim;
			}
		}

		/// <summary>
		/// System.String Trim(Char)
		/// </summary>
		protected RMethod r_Trim_Char;
		public virtual RMethod RTrim_Char
		{
			get
			{
				if(r_Trim_Char == null)
				{
					r_Trim_Char = new(this, "Trim", 0, typeof(System.Char));
					r_Trim_Char.SetBelong(this.instance);
				}
				return r_Trim_Char;
			}
		}

		/// <summary>
		/// System.String Trim(Char[])
		/// </summary>
		protected RMethod r_Trim_CharArray;
		public virtual RMethod RTrim_CharArray
		{
			get
			{
				if(r_Trim_CharArray == null)
				{
					r_Trim_CharArray = new(this, "Trim", 0, typeof(System.Char).MakeArrayType());
					r_Trim_CharArray.SetBelong(this.instance);
				}
				return r_Trim_CharArray;
			}
		}

		/// <summary>
		/// System.String TrimStart()
		/// </summary>
		protected RMethod r_TrimStart;
		public virtual RMethod RTrimStart
		{
			get
			{
				if(r_TrimStart == null)
				{
					r_TrimStart = new(this, "TrimStart", 0);
					r_TrimStart.SetBelong(this.instance);
				}
				return r_TrimStart;
			}
		}

		/// <summary>
		/// System.String TrimStart(Char)
		/// </summary>
		protected RMethod r_TrimStart_Char;
		public virtual RMethod RTrimStart_Char
		{
			get
			{
				if(r_TrimStart_Char == null)
				{
					r_TrimStart_Char = new(this, "TrimStart", 0, typeof(System.Char));
					r_TrimStart_Char.SetBelong(this.instance);
				}
				return r_TrimStart_Char;
			}
		}

		/// <summary>
		/// System.String TrimStart(Char[])
		/// </summary>
		protected RMethod r_TrimStart_CharArray;
		public virtual RMethod RTrimStart_CharArray
		{
			get
			{
				if(r_TrimStart_CharArray == null)
				{
					r_TrimStart_CharArray = new(this, "TrimStart", 0, typeof(System.Char).MakeArrayType());
					r_TrimStart_CharArray.SetBelong(this.instance);
				}
				return r_TrimStart_CharArray;
			}
		}

		/// <summary>
		/// System.String TrimEnd()
		/// </summary>
		protected RMethod r_TrimEnd;
		public virtual RMethod RTrimEnd
		{
			get
			{
				if(r_TrimEnd == null)
				{
					r_TrimEnd = new(this, "TrimEnd", 0);
					r_TrimEnd.SetBelong(this.instance);
				}
				return r_TrimEnd;
			}
		}

		/// <summary>
		/// System.String TrimEnd(Char)
		/// </summary>
		protected RMethod r_TrimEnd_Char;
		public virtual RMethod RTrimEnd_Char
		{
			get
			{
				if(r_TrimEnd_Char == null)
				{
					r_TrimEnd_Char = new(this, "TrimEnd", 0, typeof(System.Char));
					r_TrimEnd_Char.SetBelong(this.instance);
				}
				return r_TrimEnd_Char;
			}
		}

		/// <summary>
		/// System.String TrimEnd(Char[])
		/// </summary>
		protected RMethod r_TrimEnd_CharArray;
		public virtual RMethod RTrimEnd_CharArray
		{
			get
			{
				if(r_TrimEnd_CharArray == null)
				{
					r_TrimEnd_CharArray = new(this, "TrimEnd", 0, typeof(System.Char).MakeArrayType());
					r_TrimEnd_CharArray.SetBelong(this.instance);
				}
				return r_TrimEnd_CharArray;
			}
		}

		/// <summary>
		/// System.String TrimWhiteSpaceHelper(TrimType)
		/// </summary>
		protected RMethod r_TrimWhiteSpaceHelper_TrimType;
		public virtual RMethod RTrimWhiteSpaceHelper_TrimType
		{
			get
			{
				if(r_TrimWhiteSpaceHelper_TrimType == null)
				{
					r_TrimWhiteSpaceHelper_TrimType = new(this, "TrimWhiteSpaceHelper", 0,  ReflectionUtils.GetType("System.String+TrimType"));
					r_TrimWhiteSpaceHelper_TrimType.SetBelong(this.instance);
				}
				return r_TrimWhiteSpaceHelper_TrimType;
			}
		}

		/// <summary>
		/// System.String TrimHelper(Char*, Int32, TrimType)
		/// </summary>
		protected RMethod r_TrimHelper_CharPointer_Int32_TrimType;
		public virtual RMethod RTrimHelper_CharPointer_Int32_TrimType
		{
			get
			{
				if(r_TrimHelper_CharPointer_Int32_TrimType == null)
				{
					r_TrimHelper_CharPointer_Int32_TrimType = new(this, "TrimHelper", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32),  ReflectionUtils.GetType("System.String+TrimType"));
					r_TrimHelper_CharPointer_Int32_TrimType.SetBelong(this.instance);
				}
				return r_TrimHelper_CharPointer_Int32_TrimType;
			}
		}

		/// <summary>
		/// System.String CreateTrimmedString(Int32, Int32)
		/// </summary>
		protected RMethod r_CreateTrimmedString_Int32_Int32;
		public virtual RMethod RCreateTrimmedString_Int32_Int32
		{
			get
			{
				if(r_CreateTrimmedString_Int32_Int32 == null)
				{
					r_CreateTrimmedString_Int32_Int32 = new(this, "CreateTrimmedString", 0, typeof(System.Int32), typeof(System.Int32));
					r_CreateTrimmedString_Int32_Int32.SetBelong(this.instance);
				}
				return r_CreateTrimmedString_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean Contains(System.String)
		/// </summary>
		protected RMethod r_Contains_String;
		public virtual RMethod RContains_String
		{
			get
			{
				if(r_Contains_String == null)
				{
					r_Contains_String = new(this, "Contains", 0, typeof(System.String));
					r_Contains_String.SetBelong(this.instance);
				}
				return r_Contains_String;
			}
		}

		/// <summary>
		/// Boolean Contains(System.String, System.StringComparison)
		/// </summary>
		protected RMethod r_Contains_String_StringComparison;
		public virtual RMethod RContains_String_StringComparison
		{
			get
			{
				if(r_Contains_String_StringComparison == null)
				{
					r_Contains_String_StringComparison = new(this, "Contains", 0, typeof(System.String), typeof(System.StringComparison));
					r_Contains_String_StringComparison.SetBelong(this.instance);
				}
				return r_Contains_String_StringComparison;
			}
		}

		/// <summary>
		/// Boolean Contains(Char)
		/// </summary>
		protected RMethod r_Contains_Char;
		public virtual RMethod RContains_Char
		{
			get
			{
				if(r_Contains_Char == null)
				{
					r_Contains_Char = new(this, "Contains", 0, typeof(System.Char));
					r_Contains_Char.SetBelong(this.instance);
				}
				return r_Contains_Char;
			}
		}

		/// <summary>
		/// Boolean Contains(Char, System.StringComparison)
		/// </summary>
		protected RMethod r_Contains_Char_StringComparison;
		public virtual RMethod RContains_Char_StringComparison
		{
			get
			{
				if(r_Contains_Char_StringComparison == null)
				{
					r_Contains_Char_StringComparison = new(this, "Contains", 0, typeof(System.Char), typeof(System.StringComparison));
					r_Contains_Char_StringComparison.SetBelong(this.instance);
				}
				return r_Contains_Char_StringComparison;
			}
		}

		/// <summary>
		/// Int32 IndexOf(Char)
		/// </summary>
		protected RMethod r_IndexOf_Char;
		public virtual RMethod RIndexOf_Char
		{
			get
			{
				if(r_IndexOf_Char == null)
				{
					r_IndexOf_Char = new(this, "IndexOf", 0, typeof(System.Char));
					r_IndexOf_Char.SetBelong(this.instance);
				}
				return r_IndexOf_Char;
			}
		}

		/// <summary>
		/// Int32 IndexOf(Char, Int32)
		/// </summary>
		protected RMethod r_IndexOf_Char_Int32;
		public virtual RMethod RIndexOf_Char_Int32
		{
			get
			{
				if(r_IndexOf_Char_Int32 == null)
				{
					r_IndexOf_Char_Int32 = new(this, "IndexOf", 0, typeof(System.Char), typeof(System.Int32));
					r_IndexOf_Char_Int32.SetBelong(this.instance);
				}
				return r_IndexOf_Char_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(Char, System.StringComparison)
		/// </summary>
		protected RMethod r_IndexOf_Char_StringComparison;
		public virtual RMethod RIndexOf_Char_StringComparison
		{
			get
			{
				if(r_IndexOf_Char_StringComparison == null)
				{
					r_IndexOf_Char_StringComparison = new(this, "IndexOf", 0, typeof(System.Char), typeof(System.StringComparison));
					r_IndexOf_Char_StringComparison.SetBelong(this.instance);
				}
				return r_IndexOf_Char_StringComparison;
			}
		}

		/// <summary>
		/// Int32 IndexOf(Char, Int32, Int32)
		/// </summary>
		protected RMethod r_IndexOf_Char_Int32_Int32;
		public virtual RMethod RIndexOf_Char_Int32_Int32
		{
			get
			{
				if(r_IndexOf_Char_Int32_Int32 == null)
				{
					r_IndexOf_Char_Int32_Int32 = new(this, "IndexOf", 0, typeof(System.Char), typeof(System.Int32), typeof(System.Int32));
					r_IndexOf_Char_Int32_Int32.SetBelong(this.instance);
				}
				return r_IndexOf_Char_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOfAny(Char[])
		/// </summary>
		protected RMethod r_IndexOfAny_CharArray;
		public virtual RMethod RIndexOfAny_CharArray
		{
			get
			{
				if(r_IndexOfAny_CharArray == null)
				{
					r_IndexOfAny_CharArray = new(this, "IndexOfAny", 0, typeof(System.Char).MakeArrayType());
					r_IndexOfAny_CharArray.SetBelong(this.instance);
				}
				return r_IndexOfAny_CharArray;
			}
		}

		/// <summary>
		/// Int32 IndexOfAny(Char[], Int32)
		/// </summary>
		protected RMethod r_IndexOfAny_CharArray_Int32;
		public virtual RMethod RIndexOfAny_CharArray_Int32
		{
			get
			{
				if(r_IndexOfAny_CharArray_Int32 == null)
				{
					r_IndexOfAny_CharArray_Int32 = new(this, "IndexOfAny", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32));
					r_IndexOfAny_CharArray_Int32.SetBelong(this.instance);
				}
				return r_IndexOfAny_CharArray_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOfAny(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_IndexOfAny_CharArray_Int32_Int32;
		public virtual RMethod RIndexOfAny_CharArray_Int32_Int32
		{
			get
			{
				if(r_IndexOfAny_CharArray_Int32_Int32 == null)
				{
					r_IndexOfAny_CharArray_Int32_Int32 = new(this, "IndexOfAny", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_IndexOfAny_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_IndexOfAny_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOfAny(Char, Char, Int32, Int32)
		/// </summary>
		protected RMethod r_IndexOfAny_Char_Char_Int32_Int32;
		public virtual RMethod RIndexOfAny_Char_Char_Int32_Int32
		{
			get
			{
				if(r_IndexOfAny_Char_Char_Int32_Int32 == null)
				{
					r_IndexOfAny_Char_Char_Int32_Int32 = new(this, "IndexOfAny", 0, typeof(System.Char), typeof(System.Char), typeof(System.Int32), typeof(System.Int32));
					r_IndexOfAny_Char_Char_Int32_Int32.SetBelong(this.instance);
				}
				return r_IndexOfAny_Char_Char_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOfAny(Char, Char, Char, Int32, Int32)
		/// </summary>
		protected RMethod r_IndexOfAny_Char_Char_Char_Int32_Int32;
		public virtual RMethod RIndexOfAny_Char_Char_Char_Int32_Int32
		{
			get
			{
				if(r_IndexOfAny_Char_Char_Char_Int32_Int32 == null)
				{
					r_IndexOfAny_Char_Char_Char_Int32_Int32 = new(this, "IndexOfAny", 0, typeof(System.Char), typeof(System.Char), typeof(System.Char), typeof(System.Int32), typeof(System.Int32));
					r_IndexOfAny_Char_Char_Char_Int32_Int32.SetBelong(this.instance);
				}
				return r_IndexOfAny_Char_Char_Char_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOfCharArray(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_IndexOfCharArray_CharArray_Int32_Int32;
		public virtual RMethod RIndexOfCharArray_CharArray_Int32_Int32
		{
			get
			{
				if(r_IndexOfCharArray_CharArray_Int32_Int32 == null)
				{
					r_IndexOfCharArray_CharArray_Int32_Int32 = new(this, "IndexOfCharArray", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_IndexOfCharArray_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_IndexOfCharArray_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void InitializeProbabilisticMap(UInt32*, System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected static RMethod r_InitializeProbabilisticMap_UInt32Pointer_ReadOnlySpan_d_Char_p_;
		public static RMethod RInitializeProbabilisticMap_UInt32Pointer_ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_InitializeProbabilisticMap_UInt32Pointer_ReadOnlySpan_d_Char_p_ == null)
				{
					r_InitializeProbabilisticMap_UInt32Pointer_ReadOnlySpan_d_Char_p_ = new(typeof(System.String), "InitializeProbabilisticMap", 0, typeof(System.UInt32).MakePointerType(), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_InitializeProbabilisticMap_UInt32Pointer_ReadOnlySpan_d_Char_p_.SetBelong(null);
				}
				return r_InitializeProbabilisticMap_UInt32Pointer_ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// Boolean ArrayContains(Char, Char[])
		/// </summary>
		protected static RMethod r_ArrayContains_Char_CharArray;
		public static RMethod RArrayContains_Char_CharArray
		{
			get
			{
				if(r_ArrayContains_Char_CharArray == null)
				{
					r_ArrayContains_Char_CharArray = new(typeof(System.String), "ArrayContains", 0, typeof(System.Char), typeof(System.Char).MakeArrayType());
					r_ArrayContains_Char_CharArray.SetBelong(null);
				}
				return r_ArrayContains_Char_CharArray;
			}
		}

		/// <summary>
		/// Boolean IsCharBitSet(UInt32*, Byte)
		/// </summary>
		protected static RMethod r_IsCharBitSet_UInt32Pointer_Byte;
		public static RMethod RIsCharBitSet_UInt32Pointer_Byte
		{
			get
			{
				if(r_IsCharBitSet_UInt32Pointer_Byte == null)
				{
					r_IsCharBitSet_UInt32Pointer_Byte = new(typeof(System.String), "IsCharBitSet", 0, typeof(System.UInt32).MakePointerType(), typeof(System.Byte));
					r_IsCharBitSet_UInt32Pointer_Byte.SetBelong(null);
				}
				return r_IsCharBitSet_UInt32Pointer_Byte;
			}
		}

		/// <summary>
		/// Void SetCharBit(UInt32*, Byte)
		/// </summary>
		protected static RMethod r_SetCharBit_UInt32Pointer_Byte;
		public static RMethod RSetCharBit_UInt32Pointer_Byte
		{
			get
			{
				if(r_SetCharBit_UInt32Pointer_Byte == null)
				{
					r_SetCharBit_UInt32Pointer_Byte = new(typeof(System.String), "SetCharBit", 0, typeof(System.UInt32).MakePointerType(), typeof(System.Byte));
					r_SetCharBit_UInt32Pointer_Byte.SetBelong(null);
				}
				return r_SetCharBit_UInt32Pointer_Byte;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String)
		/// </summary>
		protected RMethod r_IndexOf_String;
		public virtual RMethod RIndexOf_String
		{
			get
			{
				if(r_IndexOf_String == null)
				{
					r_IndexOf_String = new(this, "IndexOf", 0, typeof(System.String));
					r_IndexOf_String.SetBelong(this.instance);
				}
				return r_IndexOf_String;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, Int32)
		/// </summary>
		protected RMethod r_IndexOf_String_Int32;
		public virtual RMethod RIndexOf_String_Int32
		{
			get
			{
				if(r_IndexOf_String_Int32 == null)
				{
					r_IndexOf_String_Int32 = new(this, "IndexOf", 0, typeof(System.String), typeof(System.Int32));
					r_IndexOf_String_Int32.SetBelong(this.instance);
				}
				return r_IndexOf_String_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_IndexOf_String_Int32_Int32;
		public virtual RMethod RIndexOf_String_Int32_Int32
		{
			get
			{
				if(r_IndexOf_String_Int32_Int32 == null)
				{
					r_IndexOf_String_Int32_Int32 = new(this, "IndexOf", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_IndexOf_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_IndexOf_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, System.StringComparison)
		/// </summary>
		protected RMethod r_IndexOf_String_StringComparison;
		public virtual RMethod RIndexOf_String_StringComparison
		{
			get
			{
				if(r_IndexOf_String_StringComparison == null)
				{
					r_IndexOf_String_StringComparison = new(this, "IndexOf", 0, typeof(System.String), typeof(System.StringComparison));
					r_IndexOf_String_StringComparison.SetBelong(this.instance);
				}
				return r_IndexOf_String_StringComparison;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, Int32, System.StringComparison)
		/// </summary>
		protected RMethod r_IndexOf_String_Int32_StringComparison;
		public virtual RMethod RIndexOf_String_Int32_StringComparison
		{
			get
			{
				if(r_IndexOf_String_Int32_StringComparison == null)
				{
					r_IndexOf_String_Int32_StringComparison = new(this, "IndexOf", 0, typeof(System.String), typeof(System.Int32), typeof(System.StringComparison));
					r_IndexOf_String_Int32_StringComparison.SetBelong(this.instance);
				}
				return r_IndexOf_String_Int32_StringComparison;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, Int32, Int32, System.StringComparison)
		/// </summary>
		protected RMethod r_IndexOf_String_Int32_Int32_StringComparison;
		public virtual RMethod RIndexOf_String_Int32_Int32_StringComparison
		{
			get
			{
				if(r_IndexOf_String_Int32_Int32_StringComparison == null)
				{
					r_IndexOf_String_Int32_Int32_StringComparison = new(this, "IndexOf", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.StringComparison));
					r_IndexOf_String_Int32_Int32_StringComparison.SetBelong(this.instance);
				}
				return r_IndexOf_String_Int32_Int32_StringComparison;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(Char)
		/// </summary>
		protected RMethod r_LastIndexOf_Char;
		public virtual RMethod RLastIndexOf_Char
		{
			get
			{
				if(r_LastIndexOf_Char == null)
				{
					r_LastIndexOf_Char = new(this, "LastIndexOf", 0, typeof(System.Char));
					r_LastIndexOf_Char.SetBelong(this.instance);
				}
				return r_LastIndexOf_Char;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(Char, Int32)
		/// </summary>
		protected RMethod r_LastIndexOf_Char_Int32;
		public virtual RMethod RLastIndexOf_Char_Int32
		{
			get
			{
				if(r_LastIndexOf_Char_Int32 == null)
				{
					r_LastIndexOf_Char_Int32 = new(this, "LastIndexOf", 0, typeof(System.Char), typeof(System.Int32));
					r_LastIndexOf_Char_Int32.SetBelong(this.instance);
				}
				return r_LastIndexOf_Char_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(Char, Int32, Int32)
		/// </summary>
		protected RMethod r_LastIndexOf_Char_Int32_Int32;
		public virtual RMethod RLastIndexOf_Char_Int32_Int32
		{
			get
			{
				if(r_LastIndexOf_Char_Int32_Int32 == null)
				{
					r_LastIndexOf_Char_Int32_Int32 = new(this, "LastIndexOf", 0, typeof(System.Char), typeof(System.Int32), typeof(System.Int32));
					r_LastIndexOf_Char_Int32_Int32.SetBelong(this.instance);
				}
				return r_LastIndexOf_Char_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOfAny(Char[])
		/// </summary>
		protected RMethod r_LastIndexOfAny_CharArray;
		public virtual RMethod RLastIndexOfAny_CharArray
		{
			get
			{
				if(r_LastIndexOfAny_CharArray == null)
				{
					r_LastIndexOfAny_CharArray = new(this, "LastIndexOfAny", 0, typeof(System.Char).MakeArrayType());
					r_LastIndexOfAny_CharArray.SetBelong(this.instance);
				}
				return r_LastIndexOfAny_CharArray;
			}
		}

		/// <summary>
		/// Int32 LastIndexOfAny(Char[], Int32)
		/// </summary>
		protected RMethod r_LastIndexOfAny_CharArray_Int32;
		public virtual RMethod RLastIndexOfAny_CharArray_Int32
		{
			get
			{
				if(r_LastIndexOfAny_CharArray_Int32 == null)
				{
					r_LastIndexOfAny_CharArray_Int32 = new(this, "LastIndexOfAny", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32));
					r_LastIndexOfAny_CharArray_Int32.SetBelong(this.instance);
				}
				return r_LastIndexOfAny_CharArray_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOfAny(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_LastIndexOfAny_CharArray_Int32_Int32;
		public virtual RMethod RLastIndexOfAny_CharArray_Int32_Int32
		{
			get
			{
				if(r_LastIndexOfAny_CharArray_Int32_Int32 == null)
				{
					r_LastIndexOfAny_CharArray_Int32_Int32 = new(this, "LastIndexOfAny", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_LastIndexOfAny_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_LastIndexOfAny_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOfCharArray(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_LastIndexOfCharArray_CharArray_Int32_Int32;
		public virtual RMethod RLastIndexOfCharArray_CharArray_Int32_Int32
		{
			get
			{
				if(r_LastIndexOfCharArray_CharArray_Int32_Int32 == null)
				{
					r_LastIndexOfCharArray_CharArray_Int32_Int32 = new(this, "LastIndexOfCharArray", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_LastIndexOfCharArray_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_LastIndexOfCharArray_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String)
		/// </summary>
		protected RMethod r_LastIndexOf_String;
		public virtual RMethod RLastIndexOf_String
		{
			get
			{
				if(r_LastIndexOf_String == null)
				{
					r_LastIndexOf_String = new(this, "LastIndexOf", 0, typeof(System.String));
					r_LastIndexOf_String.SetBelong(this.instance);
				}
				return r_LastIndexOf_String;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, Int32)
		/// </summary>
		protected RMethod r_LastIndexOf_String_Int32;
		public virtual RMethod RLastIndexOf_String_Int32
		{
			get
			{
				if(r_LastIndexOf_String_Int32 == null)
				{
					r_LastIndexOf_String_Int32 = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.Int32));
					r_LastIndexOf_String_Int32.SetBelong(this.instance);
				}
				return r_LastIndexOf_String_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_LastIndexOf_String_Int32_Int32;
		public virtual RMethod RLastIndexOf_String_Int32_Int32
		{
			get
			{
				if(r_LastIndexOf_String_Int32_Int32 == null)
				{
					r_LastIndexOf_String_Int32_Int32 = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_LastIndexOf_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_LastIndexOf_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, System.StringComparison)
		/// </summary>
		protected RMethod r_LastIndexOf_String_StringComparison;
		public virtual RMethod RLastIndexOf_String_StringComparison
		{
			get
			{
				if(r_LastIndexOf_String_StringComparison == null)
				{
					r_LastIndexOf_String_StringComparison = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.StringComparison));
					r_LastIndexOf_String_StringComparison.SetBelong(this.instance);
				}
				return r_LastIndexOf_String_StringComparison;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, Int32, System.StringComparison)
		/// </summary>
		protected RMethod r_LastIndexOf_String_Int32_StringComparison;
		public virtual RMethod RLastIndexOf_String_Int32_StringComparison
		{
			get
			{
				if(r_LastIndexOf_String_Int32_StringComparison == null)
				{
					r_LastIndexOf_String_Int32_StringComparison = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.Int32), typeof(System.StringComparison));
					r_LastIndexOf_String_Int32_StringComparison.SetBelong(this.instance);
				}
				return r_LastIndexOf_String_Int32_StringComparison;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, Int32, Int32, System.StringComparison)
		/// </summary>
		protected RMethod r_LastIndexOf_String_Int32_Int32_StringComparison;
		public virtual RMethod RLastIndexOf_String_Int32_Int32_StringComparison
		{
			get
			{
				if(r_LastIndexOf_String_Int32_Int32_StringComparison == null)
				{
					r_LastIndexOf_String_Int32_Int32_StringComparison = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.StringComparison));
					r_LastIndexOf_String_Int32_Int32_StringComparison.SetBelong(this.instance);
				}
				return r_LastIndexOf_String_Int32_Int32_StringComparison;
			}
		}

		/// <summary>
		/// System.String Ctor(Char[])
		/// </summary>
		protected static RMethod r_Ctor_CharArray;
		public static RMethod RCtor_CharArray
		{
			get
			{
				if(r_Ctor_CharArray == null)
				{
					r_Ctor_CharArray = new(typeof(System.String), "Ctor", 0, typeof(System.Char).MakeArrayType());
					r_Ctor_CharArray.SetBelong(null);
				}
				return r_Ctor_CharArray;
			}
		}

		/// <summary>
		/// System.String Ctor(Char[], Int32, Int32)
		/// </summary>
		protected static RMethod r_Ctor_CharArray_Int32_Int32;
		public static RMethod RCtor_CharArray_Int32_Int32
		{
			get
			{
				if(r_Ctor_CharArray_Int32_Int32 == null)
				{
					r_Ctor_CharArray_Int32_Int32 = new(typeof(System.String), "Ctor", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_Ctor_CharArray_Int32_Int32.SetBelong(null);
				}
				return r_Ctor_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String Ctor(Char*)
		/// </summary>
		protected static RMethod r_Ctor_CharPointer;
		public static RMethod RCtor_CharPointer
		{
			get
			{
				if(r_Ctor_CharPointer == null)
				{
					r_Ctor_CharPointer = new(typeof(System.String), "Ctor", 0, typeof(System.Char).MakePointerType());
					r_Ctor_CharPointer.SetBelong(null);
				}
				return r_Ctor_CharPointer;
			}
		}

		/// <summary>
		/// System.String Ctor(Char*, Int32, Int32)
		/// </summary>
		protected static RMethod r_Ctor_CharPointer_Int32_Int32;
		public static RMethod RCtor_CharPointer_Int32_Int32
		{
			get
			{
				if(r_Ctor_CharPointer_Int32_Int32 == null)
				{
					r_Ctor_CharPointer_Int32_Int32 = new(typeof(System.String), "Ctor", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Int32));
					r_Ctor_CharPointer_Int32_Int32.SetBelong(null);
				}
				return r_Ctor_CharPointer_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String Ctor(SByte*)
		/// </summary>
		protected static RMethod r_Ctor_SBytePointer;
		public static RMethod RCtor_SBytePointer
		{
			get
			{
				if(r_Ctor_SBytePointer == null)
				{
					r_Ctor_SBytePointer = new(typeof(System.String), "Ctor", 0, typeof(System.SByte).MakePointerType());
					r_Ctor_SBytePointer.SetBelong(null);
				}
				return r_Ctor_SBytePointer;
			}
		}

		/// <summary>
		/// System.String Ctor(SByte*, Int32, Int32)
		/// </summary>
		protected static RMethod r_Ctor_SBytePointer_Int32_Int32;
		public static RMethod RCtor_SBytePointer_Int32_Int32
		{
			get
			{
				if(r_Ctor_SBytePointer_Int32_Int32 == null)
				{
					r_Ctor_SBytePointer_Int32_Int32 = new(typeof(System.String), "Ctor", 0, typeof(System.SByte).MakePointerType(), typeof(System.Int32), typeof(System.Int32));
					r_Ctor_SBytePointer_Int32_Int32.SetBelong(null);
				}
				return r_Ctor_SBytePointer_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String CreateStringForSByteConstructor(Byte*, Int32)
		/// </summary>
		protected static RMethod r_CreateStringForSByteConstructor_BytePointer_Int32;
		public static RMethod RCreateStringForSByteConstructor_BytePointer_Int32
		{
			get
			{
				if(r_CreateStringForSByteConstructor_BytePointer_Int32 == null)
				{
					r_CreateStringForSByteConstructor_BytePointer_Int32 = new(typeof(System.String), "CreateStringForSByteConstructor", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_CreateStringForSByteConstructor_BytePointer_Int32.SetBelong(null);
				}
				return r_CreateStringForSByteConstructor_BytePointer_Int32;
			}
		}

		/// <summary>
		/// System.String Ctor(SByte*, Int32, Int32, System.Text.Encoding)
		/// </summary>
		protected static RMethod r_Ctor_SBytePointer_Int32_Int32_Encoding;
		public static RMethod RCtor_SBytePointer_Int32_Int32_Encoding
		{
			get
			{
				if(r_Ctor_SBytePointer_Int32_Int32_Encoding == null)
				{
					r_Ctor_SBytePointer_Int32_Int32_Encoding = new(typeof(System.String), "Ctor", 0, typeof(System.SByte).MakePointerType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Text.Encoding));
					r_Ctor_SBytePointer_Int32_Int32_Encoding.SetBelong(null);
				}
				return r_Ctor_SBytePointer_Int32_Int32_Encoding;
			}
		}

		/// <summary>
		/// System.String Ctor(Char, Int32)
		/// </summary>
		protected static RMethod r_Ctor_Char_Int32;
		public static RMethod RCtor_Char_Int32
		{
			get
			{
				if(r_Ctor_Char_Int32 == null)
				{
					r_Ctor_Char_Int32 = new(typeof(System.String), "Ctor", 0, typeof(System.Char), typeof(System.Int32));
					r_Ctor_Char_Int32.SetBelong(null);
				}
				return r_Ctor_Char_Int32;
			}
		}

		/// <summary>
		/// System.String Ctor(System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected static RMethod r_Ctor_ReadOnlySpan_d_Char_p_;
		public static RMethod RCtor_ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_Ctor_ReadOnlySpan_d_Char_p_ == null)
				{
					r_Ctor_ReadOnlySpan_d_Char_p_ = new(typeof(System.String), "Ctor", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_Ctor_ReadOnlySpan_d_Char_p_.SetBelong(null);
				}
				return r_Ctor_ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// System.String Create[TState](Int32, TState, System.Buffers.SpanAction`2[System.Char,TState])
		/// </summary>
		protected static RMethod r_Create_GTState_Int32_TState_SpanAction_d_Char_TState_p_;
		public static RMethod RCreate_GTState_Int32_TState_SpanAction_d_Char_TState_p_
		{
			get
			{
				if(r_Create_GTState_Int32_TState_SpanAction_d_Char_TState_p_ == null)
				{
					r_Create_GTState_Int32_TState_SpanAction_d_Char_TState_p_ = new(typeof(System.String), "Create", 1, typeof(System.Int32), Type.MakeGenericMethodParameter(0), typeof(System.Buffers.SpanAction<, >).MakeGenericType(typeof(System.Char), Type.MakeGenericMethodParameter(0)));
					r_Create_GTState_Int32_TState_SpanAction_d_Char_TState_p_.SetBelong(null);
				}
				return r_Create_GTState_Int32_TState_SpanAction_d_Char_TState_p_;
			}
		}

		/// <summary>
		/// System.ReadOnlySpan`1[System.Char] op_Implicit(System.String)
		/// </summary>
		protected static RMethod r_op_Implicit_String;
		public static RMethod Rop_Implicit_String
		{
			get
			{
				if(r_op_Implicit_String == null)
				{
					r_op_Implicit_String = new(typeof(System.String), "op_Implicit", 0, typeof(System.String));
					r_op_Implicit_String.SetBelong(null);
				}
				return r_op_Implicit_String;
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
		/// System.String Copy(System.String)
		/// </summary>
		protected static RMethod r_Copy_String;
		public static RMethod RCopy_String
		{
			get
			{
				if(r_Copy_String == null)
				{
					r_Copy_String = new(typeof(System.String), "Copy", 0, typeof(System.String));
					r_Copy_String.SetBelong(null);
				}
				return r_Copy_String;
			}
		}

		/// <summary>
		/// Void CopyTo(Int32, Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_CopyTo_Int32_CharArray_Int32_Int32;
		public virtual RMethod RCopyTo_Int32_CharArray_Int32_Int32
		{
			get
			{
				if(r_CopyTo_Int32_CharArray_Int32_Int32 == null)
				{
					r_CopyTo_Int32_CharArray_Int32_Int32 = new(this, "CopyTo", 0, typeof(System.Int32), typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_CopyTo_Int32_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_CopyTo_Int32_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Char[] ToCharArray()
		/// </summary>
		protected RMethod r_ToCharArray;
		public virtual RMethod RToCharArray
		{
			get
			{
				if(r_ToCharArray == null)
				{
					r_ToCharArray = new(this, "ToCharArray", 0);
					r_ToCharArray.SetBelong(this.instance);
				}
				return r_ToCharArray;
			}
		}

		/// <summary>
		/// Char[] ToCharArray(Int32, Int32)
		/// </summary>
		protected RMethod r_ToCharArray_Int32_Int32;
		public virtual RMethod RToCharArray_Int32_Int32
		{
			get
			{
				if(r_ToCharArray_Int32_Int32 == null)
				{
					r_ToCharArray_Int32_Int32 = new(this, "ToCharArray", 0, typeof(System.Int32), typeof(System.Int32));
					r_ToCharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_ToCharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean IsNullOrEmpty(System.String)
		/// </summary>
		protected static RMethod r_IsNullOrEmpty_String;
		public static RMethod RIsNullOrEmpty_String
		{
			get
			{
				if(r_IsNullOrEmpty_String == null)
				{
					r_IsNullOrEmpty_String = new(typeof(System.String), "IsNullOrEmpty", 0, typeof(System.String));
					r_IsNullOrEmpty_String.SetBelong(null);
				}
				return r_IsNullOrEmpty_String;
			}
		}

		/// <summary>
		/// Boolean IsNullOrWhiteSpace(System.String)
		/// </summary>
		protected static RMethod r_IsNullOrWhiteSpace_String;
		public static RMethod RIsNullOrWhiteSpace_String
		{
			get
			{
				if(r_IsNullOrWhiteSpace_String == null)
				{
					r_IsNullOrWhiteSpace_String = new(typeof(System.String), "IsNullOrWhiteSpace", 0, typeof(System.String));
					r_IsNullOrWhiteSpace_String.SetBelong(null);
				}
				return r_IsNullOrWhiteSpace_String;
			}
		}

		/// <summary>
		/// Char& GetRawStringData()
		/// </summary>
		protected RMethod r_GetRawStringData;
		public virtual RMethod RGetRawStringData
		{
			get
			{
				if(r_GetRawStringData == null)
				{
					r_GetRawStringData = new(this, "GetRawStringData", 0);
					r_GetRawStringData.SetBelong(this.instance);
				}
				return r_GetRawStringData;
			}
		}

		/// <summary>
		/// System.String CreateStringFromEncoding(Byte*, Int32, System.Text.Encoding)
		/// </summary>
		protected static RMethod r_CreateStringFromEncoding_BytePointer_Int32_Encoding;
		public static RMethod RCreateStringFromEncoding_BytePointer_Int32_Encoding
		{
			get
			{
				if(r_CreateStringFromEncoding_BytePointer_Int32_Encoding == null)
				{
					r_CreateStringFromEncoding_BytePointer_Int32_Encoding = new(typeof(System.String), "CreateStringFromEncoding", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32), typeof(System.Text.Encoding));
					r_CreateStringFromEncoding_BytePointer_Int32_Encoding.SetBelong(null);
				}
				return r_CreateStringFromEncoding_BytePointer_Int32_Encoding;
			}
		}

		/// <summary>
		/// System.String CreateFromChar(Char)
		/// </summary>
		protected static RMethod r_CreateFromChar_Char;
		public static RMethod RCreateFromChar_Char
		{
			get
			{
				if(r_CreateFromChar_Char == null)
				{
					r_CreateFromChar_Char = new(typeof(System.String), "CreateFromChar", 0, typeof(System.Char));
					r_CreateFromChar_Char.SetBelong(null);
				}
				return r_CreateFromChar_Char;
			}
		}

		/// <summary>
		/// Void wstrcpy(Char*, Char*, Int32)
		/// </summary>
		protected static RMethod r_wstrcpy_CharPointer_CharPointer_Int32;
		public static RMethod Rwstrcpy_CharPointer_CharPointer_Int32
		{
			get
			{
				if(r_wstrcpy_CharPointer_CharPointer_Int32 == null)
				{
					r_wstrcpy_CharPointer_CharPointer_Int32 = new(typeof(System.String), "wstrcpy", 0, typeof(System.Char).MakePointerType(), typeof(System.Char).MakePointerType(), typeof(System.Int32));
					r_wstrcpy_CharPointer_CharPointer_Int32.SetBelong(null);
				}
				return r_wstrcpy_CharPointer_CharPointer_Int32;
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
		/// System.CharEnumerator GetEnumerator()
		/// </summary>
		protected RMethod r_GetEnumerator;
		public virtual RMethod RGetEnumerator
		{
			get
			{
				if(r_GetEnumerator == null)
				{
					r_GetEnumerator = new(this, "GetEnumerator", 0);
					r_GetEnumerator.SetBelong(this.instance);
				}
				return r_GetEnumerator;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerator`1[System.Char] System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator()
		/// </summary>
		protected RMethod r_System__2__Collections__2__Generic__2__IEnumerable__0__System__2__Char__1____2__GetEnumerator;
		public virtual RMethod RSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Char__1____2__GetEnumerator
		{
			get
			{
				if(r_System__2__Collections__2__Generic__2__IEnumerable__0__System__2__Char__1____2__GetEnumerator == null)
				{
					r_System__2__Collections__2__Generic__2__IEnumerable__0__System__2__Char__1____2__GetEnumerator = new(this, "System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator", 0);
					r_System__2__Collections__2__Generic__2__IEnumerable__0__System__2__Char__1____2__GetEnumerator.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__Generic__2__IEnumerable__0__System__2__Char__1____2__GetEnumerator;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		/// </summary>
		protected RMethod r_System__2__Collections__2__IEnumerable__2__GetEnumerator;
		public virtual RMethod RSystem__2__Collections__2__IEnumerable__2__GetEnumerator
		{
			get
			{
				if(r_System__2__Collections__2__IEnumerable__2__GetEnumerator == null)
				{
					r_System__2__Collections__2__IEnumerable__2__GetEnumerator = new(this, "System.Collections.IEnumerable.GetEnumerator", 0);
					r_System__2__Collections__2__IEnumerable__2__GetEnumerator.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__IEnumerable__2__GetEnumerator;
			}
		}

		/// <summary>
		/// Int32 wcslen(Char*)
		/// </summary>
		protected static RMethod r_wcslen_CharPointer;
		public static RMethod Rwcslen_CharPointer
		{
			get
			{
				if(r_wcslen_CharPointer == null)
				{
					r_wcslen_CharPointer = new(typeof(System.String), "wcslen", 0, typeof(System.Char).MakePointerType());
					r_wcslen_CharPointer.SetBelong(null);
				}
				return r_wcslen_CharPointer;
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
		/// Boolean IsNormalized()
		/// </summary>
		protected RMethod r_IsNormalized;
		public virtual RMethod RIsNormalized
		{
			get
			{
				if(r_IsNormalized == null)
				{
					r_IsNormalized = new(this, "IsNormalized", 0);
					r_IsNormalized.SetBelong(this.instance);
				}
				return r_IsNormalized;
			}
		}

		/// <summary>
		/// Boolean IsNormalized(System.Text.NormalizationForm)
		/// </summary>
		protected RMethod r_IsNormalized_NormalizationForm;
		public virtual RMethod RIsNormalized_NormalizationForm
		{
			get
			{
				if(r_IsNormalized_NormalizationForm == null)
				{
					r_IsNormalized_NormalizationForm = new(this, "IsNormalized", 0, typeof(System.Text.NormalizationForm));
					r_IsNormalized_NormalizationForm.SetBelong(this.instance);
				}
				return r_IsNormalized_NormalizationForm;
			}
		}

		/// <summary>
		/// System.String Normalize()
		/// </summary>
		protected RMethod r_Normalize;
		public virtual RMethod RNormalize
		{
			get
			{
				if(r_Normalize == null)
				{
					r_Normalize = new(this, "Normalize", 0);
					r_Normalize.SetBelong(this.instance);
				}
				return r_Normalize;
			}
		}

		/// <summary>
		/// System.String Normalize(System.Text.NormalizationForm)
		/// </summary>
		protected RMethod r_Normalize_NormalizationForm;
		public virtual RMethod RNormalize_NormalizationForm
		{
			get
			{
				if(r_Normalize_NormalizationForm == null)
				{
					r_Normalize_NormalizationForm = new(this, "Normalize", 0, typeof(System.Text.NormalizationForm));
					r_Normalize_NormalizationForm.SetBelong(this.instance);
				}
				return r_Normalize_NormalizationForm;
			}
		}

		/// <summary>
		/// Int32 IndexOfUnchecked(System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_IndexOfUnchecked_String_Int32_Int32;
		public virtual RMethod RIndexOfUnchecked_String_Int32_Int32
		{
			get
			{
				if(r_IndexOfUnchecked_String_Int32_Int32 == null)
				{
					r_IndexOfUnchecked_String_Int32_Int32 = new(this, "IndexOfUnchecked", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_IndexOfUnchecked_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_IndexOfUnchecked_String_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String Concat(System.Object, System.Object, System.Object, System.Object, ...)
		/// </summary>
		protected static RMethod r_Concat_Object_Object_Object_Object;
		public static RMethod RConcat_Object_Object_Object_Object
		{
			get
			{
				if(r_Concat_Object_Object_Object_Object == null)
				{
					r_Concat_Object_Object_Object_Object = new(typeof(System.String), "Concat", 0, typeof(System.Object), typeof(System.Object), typeof(System.Object), typeof(System.Object));
					r_Concat_Object_Object_Object_Object.SetBelong(null);
				}
				return r_Concat_Object_Object_Object_Object;
			}
		}

		/// <summary>
		/// Int32 IndexOfUncheckedIgnoreCase(System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_IndexOfUncheckedIgnoreCase_String_Int32_Int32;
		public virtual RMethod RIndexOfUncheckedIgnoreCase_String_Int32_Int32
		{
			get
			{
				if(r_IndexOfUncheckedIgnoreCase_String_Int32_Int32 == null)
				{
					r_IndexOfUncheckedIgnoreCase_String_Int32_Int32 = new(this, "IndexOfUncheckedIgnoreCase", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_IndexOfUncheckedIgnoreCase_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_IndexOfUncheckedIgnoreCase_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOfUnchecked(System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_LastIndexOfUnchecked_String_Int32_Int32;
		public virtual RMethod RLastIndexOfUnchecked_String_Int32_Int32
		{
			get
			{
				if(r_LastIndexOfUnchecked_String_Int32_Int32 == null)
				{
					r_LastIndexOfUnchecked_String_Int32_Int32 = new(this, "LastIndexOfUnchecked", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_LastIndexOfUnchecked_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_LastIndexOfUnchecked_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOfUncheckedIgnoreCase(System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_LastIndexOfUncheckedIgnoreCase_String_Int32_Int32;
		public virtual RMethod RLastIndexOfUncheckedIgnoreCase_String_Int32_Int32
		{
			get
			{
				if(r_LastIndexOfUncheckedIgnoreCase_String_Int32_Int32 == null)
				{
					r_LastIndexOfUncheckedIgnoreCase_String_Int32_Int32 = new(this, "LastIndexOfUncheckedIgnoreCase", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_LastIndexOfUncheckedIgnoreCase_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_LastIndexOfUncheckedIgnoreCase_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean StartsWithOrdinalUnchecked(System.String)
		/// </summary>
		protected RMethod r_StartsWithOrdinalUnchecked_String;
		public virtual RMethod RStartsWithOrdinalUnchecked_String
		{
			get
			{
				if(r_StartsWithOrdinalUnchecked_String == null)
				{
					r_StartsWithOrdinalUnchecked_String = new(this, "StartsWithOrdinalUnchecked", 0, typeof(System.String));
					r_StartsWithOrdinalUnchecked_String.SetBelong(this.instance);
				}
				return r_StartsWithOrdinalUnchecked_String;
			}
		}

		/// <summary>
		/// System.String FastAllocateString(Int32)
		/// </summary>
		protected static RMethod r_FastAllocateString_Int32;
		public static RMethod RFastAllocateString_Int32
		{
			get
			{
				if(r_FastAllocateString_Int32 == null)
				{
					r_FastAllocateString_Int32 = new(typeof(System.String), "FastAllocateString", 0, typeof(System.Int32));
					r_FastAllocateString_Int32.SetBelong(null);
				}
				return r_FastAllocateString_Int32;
			}
		}

		/// <summary>
		/// System.String InternalIsInterned(System.String)
		/// </summary>
		protected static RMethod r_InternalIsInterned_String;
		public static RMethod RInternalIsInterned_String
		{
			get
			{
				if(r_InternalIsInterned_String == null)
				{
					r_InternalIsInterned_String = new(typeof(System.String), "InternalIsInterned", 0, typeof(System.String));
					r_InternalIsInterned_String.SetBelong(null);
				}
				return r_InternalIsInterned_String;
			}
		}

		/// <summary>
		/// System.String InternalIntern(System.String)
		/// </summary>
		protected static RMethod r_InternalIntern_String;
		public static RMethod RInternalIntern_String
		{
			get
			{
				if(r_InternalIntern_String == null)
				{
					r_InternalIntern_String = new(typeof(System.String), "InternalIntern", 0, typeof(System.String));
					r_InternalIntern_String.SetBelong(null);
				}
				return r_InternalIntern_String;
			}
		}

		/// <summary>
		/// Int32 FastCompareStringHelper(UInt32*, Int32, UInt32*, Int32)
		/// </summary>
		protected static RMethod r_FastCompareStringHelper_UInt32Pointer_Int32_UInt32Pointer_Int32;
		public static RMethod RFastCompareStringHelper_UInt32Pointer_Int32_UInt32Pointer_Int32
		{
			get
			{
				if(r_FastCompareStringHelper_UInt32Pointer_Int32_UInt32Pointer_Int32 == null)
				{
					r_FastCompareStringHelper_UInt32Pointer_Int32_UInt32Pointer_Int32 = new(typeof(System.String), "FastCompareStringHelper", 0, typeof(System.UInt32).MakePointerType(), typeof(System.Int32), typeof(System.UInt32).MakePointerType(), typeof(System.Int32));
					r_FastCompareStringHelper_UInt32Pointer_Int32_UInt32Pointer_Int32.SetBelong(null);
				}
				return r_FastCompareStringHelper_UInt32Pointer_Int32_UInt32Pointer_Int32;
			}
		}

		/// <summary>
		/// Void memset(Byte*, Int32, Int32)
		/// </summary>
		protected static RMethod r_memset_BytePointer_Int32_Int32;
		public static RMethod Rmemset_BytePointer_Int32_Int32
		{
			get
			{
				if(r_memset_BytePointer_Int32_Int32 == null)
				{
					r_memset_BytePointer_Int32_Int32 = new(typeof(System.String), "memset", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32), typeof(System.Int32));
					r_memset_BytePointer_Int32_Int32.SetBelong(null);
				}
				return r_memset_BytePointer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void memcpy(Byte*, Byte*, Int32)
		/// </summary>
		protected static RMethod r_memcpy_BytePointer_BytePointer_Int32;
		public static RMethod Rmemcpy_BytePointer_BytePointer_Int32
		{
			get
			{
				if(r_memcpy_BytePointer_BytePointer_Int32 == null)
				{
					r_memcpy_BytePointer_BytePointer_Int32 = new(typeof(System.String), "memcpy", 0, typeof(System.Byte).MakePointerType(), typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_memcpy_BytePointer_BytePointer_Int32.SetBelong(null);
				}
				return r_memcpy_BytePointer_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Void bzero(Byte*, Int32)
		/// </summary>
		protected static RMethod r_bzero_BytePointer_Int32;
		public static RMethod Rbzero_BytePointer_Int32
		{
			get
			{
				if(r_bzero_BytePointer_Int32 == null)
				{
					r_bzero_BytePointer_Int32 = new(typeof(System.String), "bzero", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_bzero_BytePointer_Int32.SetBelong(null);
				}
				return r_bzero_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Void bzero_aligned_1(Byte*, Int32)
		/// </summary>
		protected static RMethod r_bzero_aligned_1_BytePointer_Int32;
		public static RMethod Rbzero_aligned_1_BytePointer_Int32
		{
			get
			{
				if(r_bzero_aligned_1_BytePointer_Int32 == null)
				{
					r_bzero_aligned_1_BytePointer_Int32 = new(typeof(System.String), "bzero_aligned_1", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_bzero_aligned_1_BytePointer_Int32.SetBelong(null);
				}
				return r_bzero_aligned_1_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Void bzero_aligned_2(Byte*, Int32)
		/// </summary>
		protected static RMethod r_bzero_aligned_2_BytePointer_Int32;
		public static RMethod Rbzero_aligned_2_BytePointer_Int32
		{
			get
			{
				if(r_bzero_aligned_2_BytePointer_Int32 == null)
				{
					r_bzero_aligned_2_BytePointer_Int32 = new(typeof(System.String), "bzero_aligned_2", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_bzero_aligned_2_BytePointer_Int32.SetBelong(null);
				}
				return r_bzero_aligned_2_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Void bzero_aligned_4(Byte*, Int32)
		/// </summary>
		protected static RMethod r_bzero_aligned_4_BytePointer_Int32;
		public static RMethod Rbzero_aligned_4_BytePointer_Int32
		{
			get
			{
				if(r_bzero_aligned_4_BytePointer_Int32 == null)
				{
					r_bzero_aligned_4_BytePointer_Int32 = new(typeof(System.String), "bzero_aligned_4", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_bzero_aligned_4_BytePointer_Int32.SetBelong(null);
				}
				return r_bzero_aligned_4_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Void bzero_aligned_8(Byte*, Int32)
		/// </summary>
		protected static RMethod r_bzero_aligned_8_BytePointer_Int32;
		public static RMethod Rbzero_aligned_8_BytePointer_Int32
		{
			get
			{
				if(r_bzero_aligned_8_BytePointer_Int32 == null)
				{
					r_bzero_aligned_8_BytePointer_Int32 = new(typeof(System.String), "bzero_aligned_8", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_bzero_aligned_8_BytePointer_Int32.SetBelong(null);
				}
				return r_bzero_aligned_8_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Void memcpy_aligned_1(Byte*, Byte*, Int32)
		/// </summary>
		protected static RMethod r_memcpy_aligned_1_BytePointer_BytePointer_Int32;
		public static RMethod Rmemcpy_aligned_1_BytePointer_BytePointer_Int32
		{
			get
			{
				if(r_memcpy_aligned_1_BytePointer_BytePointer_Int32 == null)
				{
					r_memcpy_aligned_1_BytePointer_BytePointer_Int32 = new(typeof(System.String), "memcpy_aligned_1", 0, typeof(System.Byte).MakePointerType(), typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_memcpy_aligned_1_BytePointer_BytePointer_Int32.SetBelong(null);
				}
				return r_memcpy_aligned_1_BytePointer_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Void memcpy_aligned_2(Byte*, Byte*, Int32)
		/// </summary>
		protected static RMethod r_memcpy_aligned_2_BytePointer_BytePointer_Int32;
		public static RMethod Rmemcpy_aligned_2_BytePointer_BytePointer_Int32
		{
			get
			{
				if(r_memcpy_aligned_2_BytePointer_BytePointer_Int32 == null)
				{
					r_memcpy_aligned_2_BytePointer_BytePointer_Int32 = new(typeof(System.String), "memcpy_aligned_2", 0, typeof(System.Byte).MakePointerType(), typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_memcpy_aligned_2_BytePointer_BytePointer_Int32.SetBelong(null);
				}
				return r_memcpy_aligned_2_BytePointer_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Void memcpy_aligned_4(Byte*, Byte*, Int32)
		/// </summary>
		protected static RMethod r_memcpy_aligned_4_BytePointer_BytePointer_Int32;
		public static RMethod Rmemcpy_aligned_4_BytePointer_BytePointer_Int32
		{
			get
			{
				if(r_memcpy_aligned_4_BytePointer_BytePointer_Int32 == null)
				{
					r_memcpy_aligned_4_BytePointer_BytePointer_Int32 = new(typeof(System.String), "memcpy_aligned_4", 0, typeof(System.Byte).MakePointerType(), typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_memcpy_aligned_4_BytePointer_BytePointer_Int32.SetBelong(null);
				}
				return r_memcpy_aligned_4_BytePointer_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Void memcpy_aligned_8(Byte*, Byte*, Int32)
		/// </summary>
		protected static RMethod r_memcpy_aligned_8_BytePointer_BytePointer_Int32;
		public static RMethod Rmemcpy_aligned_8_BytePointer_BytePointer_Int32
		{
			get
			{
				if(r_memcpy_aligned_8_BytePointer_BytePointer_Int32 == null)
				{
					r_memcpy_aligned_8_BytePointer_BytePointer_Int32 = new(typeof(System.String), "memcpy_aligned_8", 0, typeof(System.Byte).MakePointerType(), typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_memcpy_aligned_8_BytePointer_BytePointer_Int32.SetBelong(null);
				}
				return r_memcpy_aligned_8_BytePointer_BytePointer_Int32;
			}
		}

		/// <summary>
		/// System.String CreateString(SByte*)
		/// </summary>
		protected RMethod r_CreateString_SBytePointer;
		public virtual RMethod RCreateString_SBytePointer
		{
			get
			{
				if(r_CreateString_SBytePointer == null)
				{
					r_CreateString_SBytePointer = new(this, "CreateString", 0, typeof(System.SByte).MakePointerType());
					r_CreateString_SBytePointer.SetBelong(this.instance);
				}
				return r_CreateString_SBytePointer;
			}
		}

		/// <summary>
		/// System.String CreateString(SByte*, Int32, Int32)
		/// </summary>
		protected RMethod r_CreateString_SBytePointer_Int32_Int32;
		public virtual RMethod RCreateString_SBytePointer_Int32_Int32
		{
			get
			{
				if(r_CreateString_SBytePointer_Int32_Int32 == null)
				{
					r_CreateString_SBytePointer_Int32_Int32 = new(this, "CreateString", 0, typeof(System.SByte).MakePointerType(), typeof(System.Int32), typeof(System.Int32));
					r_CreateString_SBytePointer_Int32_Int32.SetBelong(this.instance);
				}
				return r_CreateString_SBytePointer_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String CreateString(Char*)
		/// </summary>
		protected RMethod r_CreateString_CharPointer;
		public virtual RMethod RCreateString_CharPointer
		{
			get
			{
				if(r_CreateString_CharPointer == null)
				{
					r_CreateString_CharPointer = new(this, "CreateString", 0, typeof(System.Char).MakePointerType());
					r_CreateString_CharPointer.SetBelong(this.instance);
				}
				return r_CreateString_CharPointer;
			}
		}

		/// <summary>
		/// System.String CreateString(Char*, Int32, Int32)
		/// </summary>
		protected RMethod r_CreateString_CharPointer_Int32_Int32;
		public virtual RMethod RCreateString_CharPointer_Int32_Int32
		{
			get
			{
				if(r_CreateString_CharPointer_Int32_Int32 == null)
				{
					r_CreateString_CharPointer_Int32_Int32 = new(this, "CreateString", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Int32));
					r_CreateString_CharPointer_Int32_Int32.SetBelong(this.instance);
				}
				return r_CreateString_CharPointer_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String CreateString(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_CreateString_CharArray_Int32_Int32;
		public virtual RMethod RCreateString_CharArray_Int32_Int32
		{
			get
			{
				if(r_CreateString_CharArray_Int32_Int32 == null)
				{
					r_CreateString_CharArray_Int32_Int32 = new(this, "CreateString", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_CreateString_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_CreateString_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String CreateString(Char[])
		/// </summary>
		protected RMethod r_CreateString_CharArray;
		public virtual RMethod RCreateString_CharArray
		{
			get
			{
				if(r_CreateString_CharArray == null)
				{
					r_CreateString_CharArray = new(this, "CreateString", 0, typeof(System.Char).MakeArrayType());
					r_CreateString_CharArray.SetBelong(this.instance);
				}
				return r_CreateString_CharArray;
			}
		}

		/// <summary>
		/// System.String CreateString(Char, Int32)
		/// </summary>
		protected RMethod r_CreateString_Char_Int32;
		public virtual RMethod RCreateString_Char_Int32
		{
			get
			{
				if(r_CreateString_Char_Int32 == null)
				{
					r_CreateString_Char_Int32 = new(this, "CreateString", 0, typeof(System.Char), typeof(System.Int32));
					r_CreateString_Char_Int32.SetBelong(this.instance);
				}
				return r_CreateString_Char_Int32;
			}
		}

		/// <summary>
		/// System.String CreateString(SByte*, Int32, Int32, System.Text.Encoding)
		/// </summary>
		protected RMethod r_CreateString_SBytePointer_Int32_Int32_Encoding;
		public virtual RMethod RCreateString_SBytePointer_Int32_Int32_Encoding
		{
			get
			{
				if(r_CreateString_SBytePointer_Int32_Int32_Encoding == null)
				{
					r_CreateString_SBytePointer_Int32_Int32_Encoding = new(this, "CreateString", 0, typeof(System.SByte).MakePointerType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Text.Encoding));
					r_CreateString_SBytePointer_Int32_Int32_Encoding.SetBelong(this.instance);
				}
				return r_CreateString_SBytePointer_Int32_Int32_Encoding;
			}
		}

		/// <summary>
		/// System.String CreateString(System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected RMethod r_CreateString_ReadOnlySpan_d_Char_p_;
		public virtual RMethod RCreateString_ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_CreateString_ReadOnlySpan_d_Char_p_ == null)
				{
					r_CreateString_ReadOnlySpan_d_Char_p_ = new(this, "CreateString", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_CreateString_ReadOnlySpan_d_Char_p_.SetBelong(this.instance);
				}
				return r_CreateString_ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// System.String Intern(System.String)
		/// </summary>
		protected static RMethod r_Intern_String;
		public static RMethod RIntern_String
		{
			get
			{
				if(r_Intern_String == null)
				{
					r_Intern_String = new(typeof(System.String), "Intern", 0, typeof(System.String));
					r_Intern_String.SetBelong(null);
				}
				return r_Intern_String;
			}
		}

		/// <summary>
		/// System.String IsInterned(System.String)
		/// </summary>
		protected static RMethod r_IsInterned_String;
		public static RMethod RIsInterned_String
		{
			get
			{
				if(r_IsInterned_String == null)
				{
					r_IsInterned_String = new(typeof(System.String), "IsInterned", 0, typeof(System.String));
					r_IsInterned_String.SetBelong(null);
				}
				return r_IsInterned_String;
			}
		}

		/// <summary>
		/// Int32 LegacyStringGetHashCode()
		/// </summary>
		protected RMethod r_LegacyStringGetHashCode;
		public virtual RMethod RLegacyStringGetHashCode
		{
			get
			{
				if(r_LegacyStringGetHashCode == null)
				{
					r_LegacyStringGetHashCode = new(this, "LegacyStringGetHashCode", 0);
					r_LegacyStringGetHashCode.SetBelong(this.instance);
				}
				return r_LegacyStringGetHashCode;
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


        public RString() : base("System.String")
        {
        }

        public RString(System.Object instance) : base("System.String")
		{
            SetInstance(instance);
		}

        public RString(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RString(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Int32 CompareOrdinalIgnoreCaseHelper(System.String @strA, System.String @strB)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @strB};
            var ___result = RCompareOrdinalIgnoreCaseHelper_String_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean EqualsHelper(System.String @strA, System.String @strB)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @strB};
            var ___result = REqualsHelper_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Int32 CompareOrdinalHelper(System.String @strA, System.Int32 @indexA, System.Int32 @countA, System.String @strB, System.Int32 @indexB, System.Int32 @countB)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @indexA, @countA, @strB, @indexB, @countB};
            var ___result = RCompareOrdinalHelper_String_Int32_Int32_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean EqualsIgnoreCaseAsciiHelper(System.String @strA, System.String @strB)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @strB};
            var ___result = REqualsIgnoreCaseAsciiHelper_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Int32 CompareOrdinalHelper(System.String @strA, System.String @strB)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @strB};
            var ___result = RCompareOrdinalHelper_String_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 Compare(System.String @strA, System.String @strB)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @strB};
            var ___result = RCompare_String_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 Compare(System.String @strA, System.String @strB, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @strB, @ignoreCase};
            var ___result = RCompare_String_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 Compare(System.String @strA, System.String @strB, System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @strB, @comparisonType};
            var ___result = RCompare_String_String_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 Compare(System.String @strA, System.String @strB, System.Globalization.CultureInfo @culture, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @strB, @culture, @options};
            var ___result = RCompare_String_String_CultureInfo_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 Compare(System.String @strA, System.String @strB, System.Boolean @ignoreCase, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @strB, @ignoreCase, @culture};
            var ___result = RCompare_String_String_Boolean_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 Compare(System.String @strA, System.Int32 @indexA, System.String @strB, System.Int32 @indexB, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @indexA, @strB, @indexB, @length};
            var ___result = RCompare_String_Int32_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 Compare(System.String @strA, System.Int32 @indexA, System.String @strB, System.Int32 @indexB, System.Int32 @length, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @indexA, @strB, @indexB, @length, @ignoreCase};
            var ___result = RCompare_String_Int32_String_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 Compare(System.String @strA, System.Int32 @indexA, System.String @strB, System.Int32 @indexB, System.Int32 @length, System.Boolean @ignoreCase, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @indexA, @strB, @indexB, @length, @ignoreCase, @culture};
            var ___result = RCompare_String_Int32_String_Int32_Int32_Boolean_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 Compare(System.String @strA, System.Int32 @indexA, System.String @strB, System.Int32 @indexB, System.Int32 @length, System.Globalization.CultureInfo @culture, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @indexA, @strB, @indexB, @length, @culture, @options};
            var ___result = RCompare_String_Int32_String_Int32_Int32_CultureInfo_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 Compare(System.String @strA, System.Int32 @indexA, System.String @strB, System.Int32 @indexB, System.Int32 @length, System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @indexA, @strB, @indexB, @length, @comparisonType};
            var ___result = RCompare_String_Int32_String_Int32_Int32_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 CompareOrdinal(System.String @strA, System.String @strB)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @strB};
            var ___result = RCompareOrdinal_String_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 CompareOrdinal(RSystem.RReadOnlySpan<RSystem.RChar> @strA, RSystem.RReadOnlySpan<RSystem.RChar> @strB)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA.Value, @strB.Value};
            var ___result = RCompareOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 CompareOrdinal(System.String @strA, System.Int32 @indexA, System.String @strB, System.Int32 @indexB, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @indexA, @strB, @indexB, @length};
            var ___result = RCompareOrdinal_String_Int32_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareTo(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareTo(System.String @strB)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strB};
            var ___result = RCompareTo_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean EndsWith(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = REndsWith_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean EndsWith(System.String @value, System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @comparisonType};
            var ___result = REndsWith_String_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean EndsWith(System.String @value, System.Boolean @ignoreCase, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @ignoreCase, @culture};
            var ___result = REndsWith_String_Boolean_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean EndsWith(System.Char @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = REndsWith_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = REquals_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.String @value, System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @comparisonType};
            var ___result = REquals_String_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean Equals(System.String @a, System.String @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = REquals_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean Equals(System.String @a, System.String @b, System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @comparisonType};
            var ___result = REquals_String_String_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(System.String @a, System.String @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Equality_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.String @a, System.String @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Inequality_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode(System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@comparisonType};
            var ___result = RGetHashCode_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetLegacyNonRandomizedHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLegacyNonRandomizedHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean StartsWith(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RStartsWith_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean StartsWith(System.String @value, System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @comparisonType};
            var ___result = RStartsWith_String_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean StartsWith(System.String @value, System.Boolean @ignoreCase, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @ignoreCase, @culture};
            var ___result = RStartsWith_String_Boolean_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean StartsWith(System.Char @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RStartsWith_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void CheckStringComparison(System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@comparisonType};
            var ___result = RCheckStringComparison_StringComparison.Invoke(___genericsType, ___parameters);

            
        }


        public static void FillStringChecked(System.String @dest, System.Int32 @destPos, System.String @src)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dest, @destPos, @src};
            var ___result = RFillStringChecked_String_Int32_String.Invoke(___genericsType, ___parameters);

            
        }


        public static System.String Concat(System.Object @arg0)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arg0};
            var ___result = RConcat_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Concat(System.Object @arg0, System.Object @arg1)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arg0, @arg1};
            var ___result = RConcat_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Concat(System.Object @arg0, System.Object @arg1, System.Object @arg2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arg0, @arg1, @arg2};
            var ___result = RConcat_Object_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Concat(System.Object[] @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RConcat_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Concat<T>(System.Collections.Generic.IEnumerable<T> @values)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@values};
            var ___result = RConcat_GT_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Concat(System.Collections.Generic.IEnumerable<System.String> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@values};
            var ___result = RConcat_IEnumerable_d_String_p_.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Concat(System.String @str0, System.String @str1)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str0, @str1};
            var ___result = RConcat_String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Concat(System.String @str0, System.String @str1, System.String @str2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str0, @str1, @str2};
            var ___result = RConcat_String_String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Concat(System.String @str0, System.String @str1, System.String @str2, System.String @str3)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str0, @str1, @str2, @str3};
            var ___result = RConcat_String_String_String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Concat(System.String[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@values};
            var ___result = RConcat_StringArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Format(System.String @format, System.Object @arg0)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @arg0};
            var ___result = RFormat_String_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Format(System.String @format, System.Object @arg0, System.Object @arg1)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @arg0, @arg1};
            var ___result = RFormat_String_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Format(System.String @format, System.Object @arg0, System.Object @arg1, System.Object @arg2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @arg0, @arg1, @arg2};
            var ___result = RFormat_String_Object_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Format(System.String @format, System.Object[] @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @args};
            var ___result = RFormat_String_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Format(System.IFormatProvider @provider, System.String @format, System.Object @arg0)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider, @format, @arg0};
            var ___result = RFormat_IFormatProvider_String_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Format(System.IFormatProvider @provider, System.String @format, System.Object @arg0, System.Object @arg1)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider, @format, @arg0, @arg1};
            var ___result = RFormat_IFormatProvider_String_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Format(System.IFormatProvider @provider, System.String @format, System.Object @arg0, System.Object @arg1, System.Object @arg2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider, @format, @arg0, @arg1, @arg2};
            var ___result = RFormat_IFormatProvider_String_Object_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Format(System.IFormatProvider @provider, System.String @format, System.Object[] @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider, @format, @args};
            var ___result = RFormat_IFormatProvider_String_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String FormatHelper(System.IFormatProvider @provider, System.String @format, RSystem.RParamsArray @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider, @format, @args.Value};
            var ___result = RFormatHelper_IFormatProvider_String_ParamsArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Insert(System.Int32 @startIndex, System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex, @value};
            var ___result = RInsert_Int32_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Join(System.Char @separator, System.String[] @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @value};
            var ___result = RJoin_Char_StringArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Join(System.Char @separator, System.Object[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @values};
            var ___result = RJoin_Char_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Join<T>(System.Char @separator, System.Collections.Generic.IEnumerable<T> @values)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@separator, @values};
            var ___result = RJoin_GT_Char_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Join(System.Char @separator, System.String[] @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @value, @startIndex, @count};
            var ___result = RJoin_Char_StringArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Join(System.String @separator, System.String[] @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @value};
            var ___result = RJoin_String_StringArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Join(System.String @separator, System.Object[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @values};
            var ___result = RJoin_String_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Join<T>(System.String @separator, System.Collections.Generic.IEnumerable<T> @values)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@separator, @values};
            var ___result = RJoin_GT_String_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Join(System.String @separator, System.Collections.Generic.IEnumerable<System.String> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @values};
            var ___result = RJoin_String_IEnumerable_d_String_p_.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Join(System.String @separator, System.String[] @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @value, @startIndex, @count};
            var ___result = RJoin_String_StringArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe static System.String JoinCore(System.Char* @separator, System.Int32 @separatorLength, System.Object[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@separator, typeof(System.Char)), @separatorLength, @values};
            var ___result = RJoinCore_CharPointer_Int32_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe static System.String JoinCore<T>(System.Char* @separator, System.Int32 @separatorLength, System.Collections.Generic.IEnumerable<T> @values)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{Pointer.Box(@separator, typeof(System.Char)), @separatorLength, @values};
            var ___result = RJoinCore_GT_CharPointer_Int32_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe static System.String JoinCore(System.Char* @separator, System.Int32 @separatorLength, System.String[] @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@separator, typeof(System.Char)), @separatorLength, @value, @startIndex, @count};
            var ___result = RJoinCore_CharPointer_Int32_StringArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String PadLeft(System.Int32 @totalWidth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@totalWidth};
            var ___result = RPadLeft_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String PadLeft(System.Int32 @totalWidth, System.Char @paddingChar)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@totalWidth, @paddingChar};
            var ___result = RPadLeft_Int32_Char.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String PadRight(System.Int32 @totalWidth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@totalWidth};
            var ___result = RPadRight_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String PadRight(System.Int32 @totalWidth, System.Char @paddingChar)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@totalWidth, @paddingChar};
            var ___result = RPadRight_Int32_Char.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Remove(System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex, @count};
            var ___result = RRemove_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Remove(System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex};
            var ___result = RRemove_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Replace(System.String @oldValue, System.String @newValue, System.Boolean @ignoreCase, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue, @ignoreCase, @culture};
            var ___result = RReplace_String_String_Boolean_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Replace(System.String @oldValue, System.String @newValue, System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue, @comparisonType};
            var ___result = RReplace_String_String_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ReplaceCore(System.String @oldValue, System.String @newValue, System.Globalization.CultureInfo @culture, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue, @culture, @options};
            var ___result = RReplaceCore_String_String_CultureInfo_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Replace(System.Char @oldChar, System.Char @newChar)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldChar, @newChar};
            var ___result = RReplace_Char_Char.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Replace(System.String @oldValue, System.String @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = RReplace_String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ReplaceHelper(System.Int32 @oldValueLength, System.String @newValue, RSystem.RReadOnlySpan<RSystem.RInt32> @indices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValueLength, @newValue, @indices.Value};
            var ___result = RReplaceHelper_Int32_String_ReadOnlySpan_d_Int32_p_.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String[] Split(System.Char @separator, System.StringSplitOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @options};
            var ___result = RSplit_Char_StringSplitOptions.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] Split(System.Char @separator, System.Int32 @count, System.StringSplitOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @count, @options};
            var ___result = RSplit_Char_Int32_StringSplitOptions.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] Split(System.Char[] @separator)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator};
            var ___result = RSplit_CharArray.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] Split(System.Char[] @separator, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @count};
            var ___result = RSplit_CharArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] Split(System.Char[] @separator, System.StringSplitOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @options};
            var ___result = RSplit_CharArray_StringSplitOptions.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] Split(System.Char[] @separator, System.Int32 @count, System.StringSplitOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @count, @options};
            var ___result = RSplit_CharArray_Int32_StringSplitOptions.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] SplitInternal(RSystem.RReadOnlySpan<RSystem.RChar> @separators, System.Int32 @count, System.StringSplitOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separators.Value, @count, @options};
            var ___result = RSplitInternal_ReadOnlySpan_d_Char_p__Int32_StringSplitOptions.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] Split(System.String @separator, System.StringSplitOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @options};
            var ___result = RSplit_String_StringSplitOptions.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] Split(System.String @separator, System.Int32 @count, System.StringSplitOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @count, @options};
            var ___result = RSplit_String_Int32_StringSplitOptions.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] Split(System.String[] @separator, System.StringSplitOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @options};
            var ___result = RSplit_StringArray_StringSplitOptions.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] Split(System.String[] @separator, System.Int32 @count, System.StringSplitOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @count, @options};
            var ___result = RSplit_StringArray_Int32_StringSplitOptions.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] SplitInternal(System.String @separator, System.String[] @separators, System.Int32 @count, System.StringSplitOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @separators, @count, @options};
            var ___result = RSplitInternal_String_StringArray_Int32_StringSplitOptions.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] SplitInternal(System.String @separator, System.Int32 @count, System.StringSplitOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @count, @options};
            var ___result = RSplitInternal_String_Int32_StringSplitOptions.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] SplitKeepEmptyEntries(RSystem.RReadOnlySpan<RSystem.RInt32> @sepList, RSystem.RReadOnlySpan<RSystem.RInt32> @lengthList, System.Int32 @defaultLength, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sepList.Value, @lengthList.Value, @defaultLength, @count};
            var ___result = RSplitKeepEmptyEntries_ReadOnlySpan_d_Int32_p__ReadOnlySpan_d_Int32_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] SplitOmitEmptyEntries(RSystem.RReadOnlySpan<RSystem.RInt32> @sepList, RSystem.RReadOnlySpan<RSystem.RInt32> @lengthList, System.Int32 @defaultLength, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sepList.Value, @lengthList.Value, @defaultLength, @count};
            var ___result = RSplitOmitEmptyEntries_ReadOnlySpan_d_Int32_p__ReadOnlySpan_d_Int32_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual void MakeSeparatorList(RSystem.RReadOnlySpan<RSystem.RChar> @separators, ref RSystem.RCollections.RGeneric.RValueListBuilder<RSystem.RInt32> @sepListBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separators.Value, @sepListBuilder.Value};
            var ___result = RMakeSeparatorList_ReadOnlySpan_d_Char_p__Ref_ValueListBuilder_d_Int32_p_.Invoke(___genericsType, ___parameters);
			@sepListBuilder = new RSystem.RCollections.RGeneric.RValueListBuilder<RSystem.RInt32>(___parameters[1]);

            
        }


        public virtual void MakeSeparatorList(System.String @separator, ref RSystem.RCollections.RGeneric.RValueListBuilder<RSystem.RInt32> @sepListBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @sepListBuilder.Value};
            var ___result = RMakeSeparatorList_String_Ref_ValueListBuilder_d_Int32_p_.Invoke(___genericsType, ___parameters);
			@sepListBuilder = new RSystem.RCollections.RGeneric.RValueListBuilder<RSystem.RInt32>(___parameters[1]);

            
        }


        public virtual void MakeSeparatorList(System.String[] @separators, ref RSystem.RCollections.RGeneric.RValueListBuilder<RSystem.RInt32> @sepListBuilder, ref RSystem.RCollections.RGeneric.RValueListBuilder<RSystem.RInt32> @lengthListBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separators, @sepListBuilder.Value, @lengthListBuilder.Value};
            var ___result = RMakeSeparatorList_StringArray_Ref_ValueListBuilder_d_Int32_p__Ref_ValueListBuilder_d_Int32_p_.Invoke(___genericsType, ___parameters);
			@sepListBuilder = new RSystem.RCollections.RGeneric.RValueListBuilder<RSystem.RInt32>(___parameters[1]);
			@lengthListBuilder = new RSystem.RCollections.RGeneric.RValueListBuilder<RSystem.RInt32>(___parameters[2]);

            
        }


        public virtual System.String Substring(System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex};
            var ___result = RSubstring_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Substring(System.Int32 @startIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex, @length};
            var ___result = RSubstring_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String InternalSubString(System.Int32 @startIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex, @length};
            var ___result = RInternalSubString_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToLower()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToLower.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToLower(System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@culture};
            var ___result = RToLower_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToLowerInvariant()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToLowerInvariant.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToUpper()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToUpper.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToUpper(System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@culture};
            var ___result = RToUpper_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToUpperInvariant()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToUpperInvariant.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Trim()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RTrim.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Trim(System.Char @trimChar)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@trimChar};
            var ___result = RTrim_Char.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Trim(System.Char[] @trimChars)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@trimChars};
            var ___result = RTrim_CharArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String TrimStart()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RTrimStart.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String TrimStart(System.Char @trimChar)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@trimChar};
            var ___result = RTrimStart_Char.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String TrimStart(System.Char[] @trimChars)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@trimChars};
            var ___result = RTrimStart_CharArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String TrimEnd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RTrimEnd.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String TrimEnd(System.Char @trimChar)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@trimChar};
            var ___result = RTrimEnd_Char.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String TrimEnd(System.Char[] @trimChars)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@trimChars};
            var ___result = RTrimEnd_CharArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String TrimWhiteSpaceHelper(RType @trimType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@trimType.Value};
            var ___result = RTrimWhiteSpaceHelper_TrimType.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe virtual System.String TrimHelper(System.Char* @trimChars, System.Int32 @trimCharsLength, RType @trimType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@trimChars, typeof(System.Char)), @trimCharsLength, @trimType.Value};
            var ___result = RTrimHelper_CharPointer_Int32_TrimType.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String CreateTrimmedString(System.Int32 @start, System.Int32 @end)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @end};
            var ___result = RCreateTrimmedString_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean Contains(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RContains_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Contains(System.String @value, System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @comparisonType};
            var ___result = RContains_String_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Contains(System.Char @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RContains_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Contains(System.Char @value, System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @comparisonType};
            var ___result = RContains_Char_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 IndexOf(System.Char @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RIndexOf_Char.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.Char @value, System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex};
            var ___result = RIndexOf_Char_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.Char @value, System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @comparisonType};
            var ___result = RIndexOf_Char_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.Char @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @count};
            var ___result = RIndexOf_Char_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOfAny(System.Char[] @anyOf)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anyOf};
            var ___result = RIndexOfAny_CharArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOfAny(System.Char[] @anyOf, System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anyOf, @startIndex};
            var ___result = RIndexOfAny_CharArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOfAny(System.Char[] @anyOf, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anyOf, @startIndex, @count};
            var ___result = RIndexOfAny_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOfAny(System.Char @value1, System.Char @value2, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value1, @value2, @startIndex, @count};
            var ___result = RIndexOfAny_Char_Char_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOfAny(System.Char @value1, System.Char @value2, System.Char @value3, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value1, @value2, @value3, @startIndex, @count};
            var ___result = RIndexOfAny_Char_Char_Char_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOfCharArray(System.Char[] @anyOf, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anyOf, @startIndex, @count};
            var ___result = RIndexOfCharArray_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe static void InitializeProbabilisticMap(System.UInt32* @charMap, RSystem.RReadOnlySpan<RSystem.RChar> @anyOf)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@charMap, typeof(System.UInt32)), @anyOf.Value};
            var ___result = RInitializeProbabilisticMap_UInt32Pointer_ReadOnlySpan_d_Char_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean ArrayContains(System.Char @searchChar, System.Char[] @anyOf)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@searchChar, @anyOf};
            var ___result = RArrayContains_Char_CharArray.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public unsafe static System.Boolean IsCharBitSet(System.UInt32* @charMap, System.Byte @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@charMap, typeof(System.UInt32)), @value};
            var ___result = RIsCharBitSet_UInt32Pointer_Byte.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public unsafe static void SetCharBit(System.UInt32* @charMap, System.Byte @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@charMap, typeof(System.UInt32)), @value};
            var ___result = RSetCharBit_UInt32Pointer_Byte.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 IndexOf(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RIndexOf_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String @value, System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex};
            var ___result = RIndexOf_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @count};
            var ___result = RIndexOf_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String @value, System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @comparisonType};
            var ___result = RIndexOf_String_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String @value, System.Int32 @startIndex, System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @comparisonType};
            var ___result = RIndexOf_String_Int32_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String @value, System.Int32 @startIndex, System.Int32 @count, System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @count, @comparisonType};
            var ___result = RIndexOf_String_Int32_Int32_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.Char @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RLastIndexOf_Char.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.Char @value, System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex};
            var ___result = RLastIndexOf_Char_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.Char @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @count};
            var ___result = RLastIndexOf_Char_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOfAny(System.Char[] @anyOf)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anyOf};
            var ___result = RLastIndexOfAny_CharArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOfAny(System.Char[] @anyOf, System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anyOf, @startIndex};
            var ___result = RLastIndexOfAny_CharArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOfAny(System.Char[] @anyOf, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anyOf, @startIndex, @count};
            var ___result = RLastIndexOfAny_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOfCharArray(System.Char[] @anyOf, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anyOf, @startIndex, @count};
            var ___result = RLastIndexOfCharArray_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RLastIndexOf_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @value, System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex};
            var ___result = RLastIndexOf_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @count};
            var ___result = RLastIndexOf_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @value, System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @comparisonType};
            var ___result = RLastIndexOf_String_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @value, System.Int32 @startIndex, System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @comparisonType};
            var ___result = RLastIndexOf_String_Int32_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @value, System.Int32 @startIndex, System.Int32 @count, System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @count, @comparisonType};
            var ___result = RLastIndexOf_String_Int32_Int32_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.String Ctor(System.Char[] @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RCtor_CharArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Ctor(System.Char[] @value, System.Int32 @startIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @length};
            var ___result = RCtor_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe static System.String Ctor(System.Char* @ptr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@ptr, typeof(System.Char))};
            var ___result = RCtor_CharPointer.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe static System.String Ctor(System.Char* @ptr, System.Int32 @startIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@ptr, typeof(System.Char)), @startIndex, @length};
            var ___result = RCtor_CharPointer_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe static System.String Ctor(System.SByte* @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@value, typeof(System.SByte))};
            var ___result = RCtor_SBytePointer.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe static System.String Ctor(System.SByte* @value, System.Int32 @startIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@value, typeof(System.SByte)), @startIndex, @length};
            var ___result = RCtor_SBytePointer_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe static System.String CreateStringForSByteConstructor(System.Byte* @pb, System.Int32 @numBytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@pb, typeof(System.Byte)), @numBytes};
            var ___result = RCreateStringForSByteConstructor_BytePointer_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe static System.String Ctor(System.SByte* @value, System.Int32 @startIndex, System.Int32 @length, System.Text.Encoding @enc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@value, typeof(System.SByte)), @startIndex, @length, @enc};
            var ___result = RCtor_SBytePointer_Int32_Int32_Encoding.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Ctor(System.Char @c, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c, @count};
            var ___result = RCtor_Char_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Ctor(RSystem.RReadOnlySpan<RSystem.RChar> @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value.Value};
            var ___result = RCtor_ReadOnlySpan_d_Char_p_.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Create<TState>(System.Int32 @length, TState @state, System.Buffers.SpanAction<System.Char, TState> @action)
        {

            var ___genericsType = new Type[] {typeof(TState)};
            var ___parameters = new object[]{@length, @state, @action};
            var ___result = RCreate_GTState_Int32_TState_SpanAction_d_Char_TState_p_.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static RSystem.RReadOnlySpan<RSystem.RChar> op_Implicit(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rop_Implicit_String.Invoke(___genericsType, ___parameters);

            return new RSystem.RReadOnlySpan<RSystem.RChar>(___result);
        }


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.String Copy(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RCopy_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void CopyTo(System.Int32 @sourceIndex, System.Char[] @destination, System.Int32 @destinationIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sourceIndex, @destination, @destinationIndex, @count};
            var ___result = RCopyTo_Int32_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Char[] ToCharArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToCharArray.Invoke(___genericsType, ___parameters);

            return (System.Char[])___result;
        }


        public virtual System.Char[] ToCharArray(System.Int32 @startIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex, @length};
            var ___result = RToCharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Char[])___result;
        }


        public static System.Boolean IsNullOrEmpty(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RIsNullOrEmpty_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsNullOrWhiteSpace(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RIsNullOrWhiteSpace_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Char GetRawStringData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRawStringData.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public unsafe static System.String CreateStringFromEncoding(System.Byte* @bytes, System.Int32 @byteLength, System.Text.Encoding @encoding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@bytes, typeof(System.Byte)), @byteLength, @encoding};
            var ___result = RCreateStringFromEncoding_BytePointer_Int32_Encoding.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String CreateFromChar(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RCreateFromChar_Char.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe static void wstrcpy(System.Char* @dmem, System.Char* @smem, System.Int32 @charCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@dmem, typeof(System.Char)), Pointer.Box(@smem, typeof(System.Char)), @charCount};
            var ___result = Rwstrcpy_CharPointer_CharPointer_Int32.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.CharEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.CharEnumerator)___result;
        }


        public virtual System.Collections.Generic.IEnumerator<System.Char> System__2__Collections__2__Generic__2__IEnumerable__0__System__2__Char__1____2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Char__1____2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerator<System.Char>)___result;
        }


        public virtual System.Collections.IEnumerator System__2__Collections__2__IEnumerable__2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__2__Collections__2__IEnumerable__2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public unsafe static System.Int32 wcslen(System.Char* @ptr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@ptr, typeof(System.Char))};
            var ___result = Rwcslen_CharPointer.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.Boolean IsNormalized()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsNormalized.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsNormalized(System.Text.NormalizationForm @normalizationForm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@normalizationForm};
            var ___result = RIsNormalized_NormalizationForm.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String Normalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RNormalize.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Normalize(System.Text.NormalizationForm @normalizationForm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@normalizationForm};
            var ___result = RNormalize_NormalizationForm.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 IndexOfUnchecked(System.String @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @count};
            var ___result = RIndexOfUnchecked_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.String Concat(System.Object @arg0, System.Object @arg1, System.Object @arg2, System.Object @arg3)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arg0, @arg1, @arg2, @arg3};
            var ___result = RConcat_Object_Object_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 IndexOfUncheckedIgnoreCase(System.String @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @count};
            var ___result = RIndexOfUncheckedIgnoreCase_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOfUnchecked(System.String @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @count};
            var ___result = RLastIndexOfUnchecked_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOfUncheckedIgnoreCase(System.String @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @count};
            var ___result = RLastIndexOfUncheckedIgnoreCase_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean StartsWithOrdinalUnchecked(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RStartsWithOrdinalUnchecked_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.String FastAllocateString(System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@length};
            var ___result = RFastAllocateString_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String InternalIsInterned(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RInternalIsInterned_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String InternalIntern(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RInternalIntern_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe static System.Int32 FastCompareStringHelper(System.UInt32* @strAChars, System.Int32 @countA, System.UInt32* @strBChars, System.Int32 @countB)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@strAChars, typeof(System.UInt32)), @countA, Pointer.Box(@strBChars, typeof(System.UInt32)), @countB};
            var ___result = RFastCompareStringHelper_UInt32Pointer_Int32_UInt32Pointer_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe static void memset(System.Byte* @dest, System.Int32 @val, System.Int32 @len)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@dest, typeof(System.Byte)), @val, @len};
            var ___result = Rmemset_BytePointer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe static void memcpy(System.Byte* @dest, System.Byte* @src, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@dest, typeof(System.Byte)), Pointer.Box(@src, typeof(System.Byte)), @size};
            var ___result = Rmemcpy_BytePointer_BytePointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe static void bzero(System.Byte* @dest, System.Int32 @len)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@dest, typeof(System.Byte)), @len};
            var ___result = Rbzero_BytePointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe static void bzero_aligned_1(System.Byte* @dest, System.Int32 @len)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@dest, typeof(System.Byte)), @len};
            var ___result = Rbzero_aligned_1_BytePointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe static void bzero_aligned_2(System.Byte* @dest, System.Int32 @len)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@dest, typeof(System.Byte)), @len};
            var ___result = Rbzero_aligned_2_BytePointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe static void bzero_aligned_4(System.Byte* @dest, System.Int32 @len)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@dest, typeof(System.Byte)), @len};
            var ___result = Rbzero_aligned_4_BytePointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe static void bzero_aligned_8(System.Byte* @dest, System.Int32 @len)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@dest, typeof(System.Byte)), @len};
            var ___result = Rbzero_aligned_8_BytePointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe static void memcpy_aligned_1(System.Byte* @dest, System.Byte* @src, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@dest, typeof(System.Byte)), Pointer.Box(@src, typeof(System.Byte)), @size};
            var ___result = Rmemcpy_aligned_1_BytePointer_BytePointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe static void memcpy_aligned_2(System.Byte* @dest, System.Byte* @src, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@dest, typeof(System.Byte)), Pointer.Box(@src, typeof(System.Byte)), @size};
            var ___result = Rmemcpy_aligned_2_BytePointer_BytePointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe static void memcpy_aligned_4(System.Byte* @dest, System.Byte* @src, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@dest, typeof(System.Byte)), Pointer.Box(@src, typeof(System.Byte)), @size};
            var ___result = Rmemcpy_aligned_4_BytePointer_BytePointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe static void memcpy_aligned_8(System.Byte* @dest, System.Byte* @src, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@dest, typeof(System.Byte)), Pointer.Box(@src, typeof(System.Byte)), @size};
            var ___result = Rmemcpy_aligned_8_BytePointer_BytePointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe virtual System.String CreateString(System.SByte* @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@value, typeof(System.SByte))};
            var ___result = RCreateString_SBytePointer.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe virtual System.String CreateString(System.SByte* @value, System.Int32 @startIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@value, typeof(System.SByte)), @startIndex, @length};
            var ___result = RCreateString_SBytePointer_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe virtual System.String CreateString(System.Char* @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@value, typeof(System.Char))};
            var ___result = RCreateString_CharPointer.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe virtual System.String CreateString(System.Char* @value, System.Int32 @startIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@value, typeof(System.Char)), @startIndex, @length};
            var ___result = RCreateString_CharPointer_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String CreateString(System.Char[] @val, System.Int32 @startIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@val, @startIndex, @length};
            var ___result = RCreateString_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String CreateString(System.Char[] @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@val};
            var ___result = RCreateString_CharArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String CreateString(System.Char @c, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c, @count};
            var ___result = RCreateString_Char_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe virtual System.String CreateString(System.SByte* @value, System.Int32 @startIndex, System.Int32 @length, System.Text.Encoding @enc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@value, typeof(System.SByte)), @startIndex, @length, @enc};
            var ___result = RCreateString_SBytePointer_Int32_Int32_Encoding.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String CreateString(RSystem.RReadOnlySpan<RSystem.RChar> @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value.Value};
            var ___result = RCreateString_ReadOnlySpan_d_Char_p_.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Intern(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RIntern_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String IsInterned(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RIsInterned_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 LegacyStringGetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RLegacyStringGetHashCode.Invoke(___genericsType, ___parameters);

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
