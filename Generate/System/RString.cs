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
		protected static RSystem.RInt32 r_FStackallocIntBufferSizeLimit;
		public static RSystem.RInt32 RFStackallocIntBufferSizeLimit
		{
			get
			{
				if(r_FStackallocIntBufferSizeLimit == null)
				{
					r_FStackallocIntBufferSizeLimit = new(typeof(System.String), "StackallocIntBufferSizeLimit");
					r_FStackallocIntBufferSizeLimit.SetBelong(null);
				}
				return r_FStackallocIntBufferSizeLimit;
			}
		}

		/// <summary>
		/// System.Int32 PROBABILISTICMAP_BLOCK_INDEX_MASK
		/// </summary>
		protected static RSystem.RInt32 r_FPROBABILISTICMAP_BLOCK_INDEX_MASK;
		public static RSystem.RInt32 RFPROBABILISTICMAP_BLOCK_INDEX_MASK
		{
			get
			{
				if(r_FPROBABILISTICMAP_BLOCK_INDEX_MASK == null)
				{
					r_FPROBABILISTICMAP_BLOCK_INDEX_MASK = new(typeof(System.String), "PROBABILISTICMAP_BLOCK_INDEX_MASK");
					r_FPROBABILISTICMAP_BLOCK_INDEX_MASK.SetBelong(null);
				}
				return r_FPROBABILISTICMAP_BLOCK_INDEX_MASK;
			}
		}

		/// <summary>
		/// System.Int32 PROBABILISTICMAP_BLOCK_INDEX_SHIFT
		/// </summary>
		protected static RSystem.RInt32 r_FPROBABILISTICMAP_BLOCK_INDEX_SHIFT;
		public static RSystem.RInt32 RFPROBABILISTICMAP_BLOCK_INDEX_SHIFT
		{
			get
			{
				if(r_FPROBABILISTICMAP_BLOCK_INDEX_SHIFT == null)
				{
					r_FPROBABILISTICMAP_BLOCK_INDEX_SHIFT = new(typeof(System.String), "PROBABILISTICMAP_BLOCK_INDEX_SHIFT");
					r_FPROBABILISTICMAP_BLOCK_INDEX_SHIFT.SetBelong(null);
				}
				return r_FPROBABILISTICMAP_BLOCK_INDEX_SHIFT;
			}
		}

		/// <summary>
		/// System.Int32 PROBABILISTICMAP_SIZE
		/// </summary>
		protected static RSystem.RInt32 r_FPROBABILISTICMAP_SIZE;
		public static RSystem.RInt32 RFPROBABILISTICMAP_SIZE
		{
			get
			{
				if(r_FPROBABILISTICMAP_SIZE == null)
				{
					r_FPROBABILISTICMAP_SIZE = new(typeof(System.String), "PROBABILISTICMAP_SIZE");
					r_FPROBABILISTICMAP_SIZE.SetBelong(null);
				}
				return r_FPROBABILISTICMAP_SIZE;
			}
		}

		/// <summary>
		/// System.Int32 _stringLength
		/// </summary>
		protected RSystem.RInt32 r_F_stringLength;
		public virtual RSystem.RInt32 RF_stringLength
		{
			get
			{
				if(r_F_stringLength == null)
				{
					r_F_stringLength = new(this, "_stringLength");
					r_F_stringLength.SetBelong(this.instance);
				}
				return r_F_stringLength;
			}
		}

		/// <summary>
		/// System.Char _firstChar
		/// </summary>
		protected RSystem.RChar r_F_firstChar;
		public virtual RSystem.RChar RF_firstChar
		{
			get
			{
				if(r_F_firstChar == null)
				{
					r_F_firstChar = new(this, "_firstChar");
					r_F_firstChar.SetBelong(this.instance);
				}
				return r_F_firstChar;
			}
		}

		/// <summary>
		/// System.String Empty
		/// </summary>
		protected static RSystem.RString r_FEmpty;
		public static RSystem.RString RFEmpty
		{
			get
			{
				if(r_FEmpty == null)
				{
					r_FEmpty = new(typeof(System.String), "Empty");
					r_FEmpty.SetBelong(null);
				}
				return r_FEmpty;
			}
		}

		/// <summary>
		/// Int32 Length
		/// </summary>
		protected RSystem.RInt32 r_PLength;
		public virtual RSystem.RInt32 RPLength
		{
			get
			{
				if(r_PLength == null)
				{
					r_PLength = new(this, "Length", -1);
					r_PLength.SetBelong(this.instance);
				}
				return r_PLength;
			}
		}

		/// <summary>
		/// Char Chars [Int32]
		/// </summary>
		protected RSystem.RChar r_PChars_Int32;
		public virtual RSystem.RChar RPChars_Int32
		{
			get
			{
				if(r_PChars_Int32 == null)
				{
					r_PChars_Int32 = new(this, "Chars", -1, typeof(System.Int32));
					r_PChars_Int32.SetBelong(this.instance);
				}
				return r_PChars_Int32;
			}
		}

		/// <summary>
		/// Int32 CompareOrdinalIgnoreCaseHelper(System.String, System.String)
		/// </summary>
		protected static RMethod r_MCompareOrdinalIgnoreCaseHelper_String_String;
		public static RMethod RMCompareOrdinalIgnoreCaseHelper_String_String
		{
			get
			{
				if(r_MCompareOrdinalIgnoreCaseHelper_String_String == null)
				{
					r_MCompareOrdinalIgnoreCaseHelper_String_String = new(typeof(System.String), "CompareOrdinalIgnoreCaseHelper", 0, typeof(System.String), typeof(System.String));
					r_MCompareOrdinalIgnoreCaseHelper_String_String.SetBelong(null);
				}
				return r_MCompareOrdinalIgnoreCaseHelper_String_String;
			}
		}

		/// <summary>
		/// Boolean EqualsHelper(System.String, System.String)
		/// </summary>
		protected static RMethod r_MEqualsHelper_String_String;
		public static RMethod RMEqualsHelper_String_String
		{
			get
			{
				if(r_MEqualsHelper_String_String == null)
				{
					r_MEqualsHelper_String_String = new(typeof(System.String), "EqualsHelper", 0, typeof(System.String), typeof(System.String));
					r_MEqualsHelper_String_String.SetBelong(null);
				}
				return r_MEqualsHelper_String_String;
			}
		}

		/// <summary>
		/// Int32 CompareOrdinalHelper(System.String, Int32, Int32, System.String, Int32, Int32)
		/// </summary>
		protected static RMethod r_MCompareOrdinalHelper_String_Int32_Int32_String_Int32_Int32;
		public static RMethod RMCompareOrdinalHelper_String_Int32_Int32_String_Int32_Int32
		{
			get
			{
				if(r_MCompareOrdinalHelper_String_Int32_Int32_String_Int32_Int32 == null)
				{
					r_MCompareOrdinalHelper_String_Int32_Int32_String_Int32_Int32 = new(typeof(System.String), "CompareOrdinalHelper", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_MCompareOrdinalHelper_String_Int32_Int32_String_Int32_Int32.SetBelong(null);
				}
				return r_MCompareOrdinalHelper_String_Int32_Int32_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean EqualsIgnoreCaseAsciiHelper(System.String, System.String)
		/// </summary>
		protected static RMethod r_MEqualsIgnoreCaseAsciiHelper_String_String;
		public static RMethod RMEqualsIgnoreCaseAsciiHelper_String_String
		{
			get
			{
				if(r_MEqualsIgnoreCaseAsciiHelper_String_String == null)
				{
					r_MEqualsIgnoreCaseAsciiHelper_String_String = new(typeof(System.String), "EqualsIgnoreCaseAsciiHelper", 0, typeof(System.String), typeof(System.String));
					r_MEqualsIgnoreCaseAsciiHelper_String_String.SetBelong(null);
				}
				return r_MEqualsIgnoreCaseAsciiHelper_String_String;
			}
		}

		/// <summary>
		/// Int32 CompareOrdinalHelper(System.String, System.String)
		/// </summary>
		protected static RMethod r_MCompareOrdinalHelper_String_String;
		public static RMethod RMCompareOrdinalHelper_String_String
		{
			get
			{
				if(r_MCompareOrdinalHelper_String_String == null)
				{
					r_MCompareOrdinalHelper_String_String = new(typeof(System.String), "CompareOrdinalHelper", 0, typeof(System.String), typeof(System.String));
					r_MCompareOrdinalHelper_String_String.SetBelong(null);
				}
				return r_MCompareOrdinalHelper_String_String;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, System.String)
		/// </summary>
		protected static RMethod r_MCompare_String_String;
		public static RMethod RMCompare_String_String
		{
			get
			{
				if(r_MCompare_String_String == null)
				{
					r_MCompare_String_String = new(typeof(System.String), "Compare", 0, typeof(System.String), typeof(System.String));
					r_MCompare_String_String.SetBelong(null);
				}
				return r_MCompare_String_String;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, System.String, Boolean)
		/// </summary>
		protected static RMethod r_MCompare_String_String_Boolean;
		public static RMethod RMCompare_String_String_Boolean
		{
			get
			{
				if(r_MCompare_String_String_Boolean == null)
				{
					r_MCompare_String_String_Boolean = new(typeof(System.String), "Compare", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean));
					r_MCompare_String_String_Boolean.SetBelong(null);
				}
				return r_MCompare_String_String_Boolean;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, System.String, System.StringComparison)
		/// </summary>
		protected static RMethod r_MCompare_String_String_StringComparison;
		public static RMethod RMCompare_String_String_StringComparison
		{
			get
			{
				if(r_MCompare_String_String_StringComparison == null)
				{
					r_MCompare_String_String_StringComparison = new(typeof(System.String), "Compare", 0, typeof(System.String), typeof(System.String), typeof(System.StringComparison));
					r_MCompare_String_String_StringComparison.SetBelong(null);
				}
				return r_MCompare_String_String_StringComparison;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, System.String, System.Globalization.CultureInfo, System.Globalization.CompareOptions)
		/// </summary>
		protected static RMethod r_MCompare_String_String_CultureInfo_CompareOptions;
		public static RMethod RMCompare_String_String_CultureInfo_CompareOptions
		{
			get
			{
				if(r_MCompare_String_String_CultureInfo_CompareOptions == null)
				{
					r_MCompare_String_String_CultureInfo_CompareOptions = new(typeof(System.String), "Compare", 0, typeof(System.String), typeof(System.String), typeof(System.Globalization.CultureInfo), typeof(System.Globalization.CompareOptions));
					r_MCompare_String_String_CultureInfo_CompareOptions.SetBelong(null);
				}
				return r_MCompare_String_String_CultureInfo_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, System.String, Boolean, System.Globalization.CultureInfo)
		/// </summary>
		protected static RMethod r_MCompare_String_String_Boolean_CultureInfo;
		public static RMethod RMCompare_String_String_Boolean_CultureInfo
		{
			get
			{
				if(r_MCompare_String_String_Boolean_CultureInfo == null)
				{
					r_MCompare_String_String_Boolean_CultureInfo = new(typeof(System.String), "Compare", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.Globalization.CultureInfo));
					r_MCompare_String_String_Boolean_CultureInfo.SetBelong(null);
				}
				return r_MCompare_String_String_Boolean_CultureInfo;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, Int32, System.String, Int32, Int32)
		/// </summary>
		protected static RMethod r_MCompare_String_Int32_String_Int32_Int32;
		public static RMethod RMCompare_String_Int32_String_Int32_Int32
		{
			get
			{
				if(r_MCompare_String_Int32_String_Int32_Int32 == null)
				{
					r_MCompare_String_Int32_String_Int32_Int32 = new(typeof(System.String), "Compare", 0, typeof(System.String), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_MCompare_String_Int32_String_Int32_Int32.SetBelong(null);
				}
				return r_MCompare_String_Int32_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, Int32, System.String, Int32, Int32, Boolean)
		/// </summary>
		protected static RMethod r_MCompare_String_Int32_String_Int32_Int32_Boolean;
		public static RMethod RMCompare_String_Int32_String_Int32_Int32_Boolean
		{
			get
			{
				if(r_MCompare_String_Int32_String_Int32_Int32_Boolean == null)
				{
					r_MCompare_String_Int32_String_Int32_Int32_Boolean = new(typeof(System.String), "Compare", 0, typeof(System.String), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_MCompare_String_Int32_String_Int32_Int32_Boolean.SetBelong(null);
				}
				return r_MCompare_String_Int32_String_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, Int32, System.String, Int32, Int32, Boolean, System.Globalization.CultureInfo)
		/// </summary>
		protected static RMethod r_MCompare_String_Int32_String_Int32_Int32_Boolean_CultureInfo;
		public static RMethod RMCompare_String_Int32_String_Int32_Int32_Boolean_CultureInfo
		{
			get
			{
				if(r_MCompare_String_Int32_String_Int32_Int32_Boolean_CultureInfo == null)
				{
					r_MCompare_String_Int32_String_Int32_Int32_Boolean_CultureInfo = new(typeof(System.String), "Compare", 0, typeof(System.String), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.Globalization.CultureInfo));
					r_MCompare_String_Int32_String_Int32_Int32_Boolean_CultureInfo.SetBelong(null);
				}
				return r_MCompare_String_Int32_String_Int32_Int32_Boolean_CultureInfo;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, Int32, System.String, Int32, Int32, System.Globalization.CultureInfo, System.Globalization.CompareOptions)
		/// </summary>
		protected static RMethod r_MCompare_String_Int32_String_Int32_Int32_CultureInfo_CompareOptions;
		public static RMethod RMCompare_String_Int32_String_Int32_Int32_CultureInfo_CompareOptions
		{
			get
			{
				if(r_MCompare_String_Int32_String_Int32_Int32_CultureInfo_CompareOptions == null)
				{
					r_MCompare_String_Int32_String_Int32_Int32_CultureInfo_CompareOptions = new(typeof(System.String), "Compare", 0, typeof(System.String), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CultureInfo), typeof(System.Globalization.CompareOptions));
					r_MCompare_String_Int32_String_Int32_Int32_CultureInfo_CompareOptions.SetBelong(null);
				}
				return r_MCompare_String_Int32_String_Int32_Int32_CultureInfo_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
		/// </summary>
		protected static RMethod r_MCompare_String_Int32_String_Int32_Int32_StringComparison;
		public static RMethod RMCompare_String_Int32_String_Int32_Int32_StringComparison
		{
			get
			{
				if(r_MCompare_String_Int32_String_Int32_Int32_StringComparison == null)
				{
					r_MCompare_String_Int32_String_Int32_Int32_StringComparison = new(typeof(System.String), "Compare", 0, typeof(System.String), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.StringComparison));
					r_MCompare_String_Int32_String_Int32_Int32_StringComparison.SetBelong(null);
				}
				return r_MCompare_String_Int32_String_Int32_Int32_StringComparison;
			}
		}

		/// <summary>
		/// Int32 CompareOrdinal(System.String, System.String)
		/// </summary>
		protected static RMethod r_MCompareOrdinal_String_String;
		public static RMethod RMCompareOrdinal_String_String
		{
			get
			{
				if(r_MCompareOrdinal_String_String == null)
				{
					r_MCompareOrdinal_String_String = new(typeof(System.String), "CompareOrdinal", 0, typeof(System.String), typeof(System.String));
					r_MCompareOrdinal_String_String.SetBelong(null);
				}
				return r_MCompareOrdinal_String_String;
			}
		}

		/// <summary>
		/// Int32 CompareOrdinal(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected static RMethod r_MCompareOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_;
		public static RMethod RMCompareOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_MCompareOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_ == null)
				{
					r_MCompareOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_ = new(typeof(System.String), "CompareOrdinal", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_MCompareOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_.SetBelong(null);
				}
				return r_MCompareOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// Int32 CompareOrdinal(System.String, Int32, System.String, Int32, Int32)
		/// </summary>
		protected static RMethod r_MCompareOrdinal_String_Int32_String_Int32_Int32;
		public static RMethod RMCompareOrdinal_String_Int32_String_Int32_Int32
		{
			get
			{
				if(r_MCompareOrdinal_String_Int32_String_Int32_Int32 == null)
				{
					r_MCompareOrdinal_String_Int32_String_Int32_Int32 = new(typeof(System.String), "CompareOrdinal", 0, typeof(System.String), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_MCompareOrdinal_String_Int32_String_Int32_Int32.SetBelong(null);
				}
				return r_MCompareOrdinal_String_Int32_String_Int32_Int32;
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
		/// Int32 CompareTo(System.String)
		/// </summary>
		protected RMethod r_MCompareTo_String;
		public virtual RMethod RMCompareTo_String
		{
			get
			{
				if(r_MCompareTo_String == null)
				{
					r_MCompareTo_String = new(this, "CompareTo", 0, typeof(System.String));
					r_MCompareTo_String.SetBelong(this.instance);
				}
				return r_MCompareTo_String;
			}
		}

		/// <summary>
		/// Boolean EndsWith(System.String)
		/// </summary>
		protected RMethod r_MEndsWith_String;
		public virtual RMethod RMEndsWith_String
		{
			get
			{
				if(r_MEndsWith_String == null)
				{
					r_MEndsWith_String = new(this, "EndsWith", 0, typeof(System.String));
					r_MEndsWith_String.SetBelong(this.instance);
				}
				return r_MEndsWith_String;
			}
		}

		/// <summary>
		/// Boolean EndsWith(System.String, System.StringComparison)
		/// </summary>
		protected RMethod r_MEndsWith_String_StringComparison;
		public virtual RMethod RMEndsWith_String_StringComparison
		{
			get
			{
				if(r_MEndsWith_String_StringComparison == null)
				{
					r_MEndsWith_String_StringComparison = new(this, "EndsWith", 0, typeof(System.String), typeof(System.StringComparison));
					r_MEndsWith_String_StringComparison.SetBelong(this.instance);
				}
				return r_MEndsWith_String_StringComparison;
			}
		}

		/// <summary>
		/// Boolean EndsWith(System.String, Boolean, System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_MEndsWith_String_Boolean_CultureInfo;
		public virtual RMethod RMEndsWith_String_Boolean_CultureInfo
		{
			get
			{
				if(r_MEndsWith_String_Boolean_CultureInfo == null)
				{
					r_MEndsWith_String_Boolean_CultureInfo = new(this, "EndsWith", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Globalization.CultureInfo));
					r_MEndsWith_String_Boolean_CultureInfo.SetBelong(this.instance);
				}
				return r_MEndsWith_String_Boolean_CultureInfo;
			}
		}

		/// <summary>
		/// Boolean EndsWith(Char)
		/// </summary>
		protected RMethod r_MEndsWith_Char;
		public virtual RMethod RMEndsWith_Char
		{
			get
			{
				if(r_MEndsWith_Char == null)
				{
					r_MEndsWith_Char = new(this, "EndsWith", 0, typeof(System.Char));
					r_MEndsWith_Char.SetBelong(this.instance);
				}
				return r_MEndsWith_Char;
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
		/// Boolean Equals(System.String)
		/// </summary>
		protected RMethod r_MEquals_String;
		public virtual RMethod RMEquals_String
		{
			get
			{
				if(r_MEquals_String == null)
				{
					r_MEquals_String = new(this, "Equals", 0, typeof(System.String));
					r_MEquals_String.SetBelong(this.instance);
				}
				return r_MEquals_String;
			}
		}

		/// <summary>
		/// Boolean Equals(System.String, System.StringComparison)
		/// </summary>
		protected RMethod r_MEquals_String_StringComparison;
		public virtual RMethod RMEquals_String_StringComparison
		{
			get
			{
				if(r_MEquals_String_StringComparison == null)
				{
					r_MEquals_String_StringComparison = new(this, "Equals", 0, typeof(System.String), typeof(System.StringComparison));
					r_MEquals_String_StringComparison.SetBelong(this.instance);
				}
				return r_MEquals_String_StringComparison;
			}
		}

		/// <summary>
		/// Boolean Equals(System.String, System.String)
		/// </summary>
		protected static RMethod r_MEquals_String_String;
		public static RMethod RMEquals_String_String
		{
			get
			{
				if(r_MEquals_String_String == null)
				{
					r_MEquals_String_String = new(typeof(System.String), "Equals", 0, typeof(System.String), typeof(System.String));
					r_MEquals_String_String.SetBelong(null);
				}
				return r_MEquals_String_String;
			}
		}

		/// <summary>
		/// Boolean Equals(System.String, System.String, System.StringComparison)
		/// </summary>
		protected static RMethod r_MEquals_String_String_StringComparison;
		public static RMethod RMEquals_String_String_StringComparison
		{
			get
			{
				if(r_MEquals_String_String_StringComparison == null)
				{
					r_MEquals_String_String_StringComparison = new(typeof(System.String), "Equals", 0, typeof(System.String), typeof(System.String), typeof(System.StringComparison));
					r_MEquals_String_String_StringComparison.SetBelong(null);
				}
				return r_MEquals_String_String_StringComparison;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.String, System.String)
		/// </summary>
		protected static RMethod r_Mop_Equality_String_String;
		public static RMethod RMop_Equality_String_String
		{
			get
			{
				if(r_Mop_Equality_String_String == null)
				{
					r_Mop_Equality_String_String = new(typeof(System.String), "op_Equality", 0, typeof(System.String), typeof(System.String));
					r_Mop_Equality_String_String.SetBelong(null);
				}
				return r_Mop_Equality_String_String;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.String, System.String)
		/// </summary>
		protected static RMethod r_Mop_Inequality_String_String;
		public static RMethod RMop_Inequality_String_String
		{
			get
			{
				if(r_Mop_Inequality_String_String == null)
				{
					r_Mop_Inequality_String_String = new(typeof(System.String), "op_Inequality", 0, typeof(System.String), typeof(System.String));
					r_Mop_Inequality_String_String.SetBelong(null);
				}
				return r_Mop_Inequality_String_String;
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
		/// Int32 GetHashCode(System.StringComparison)
		/// </summary>
		protected RMethod r_MGetHashCode_StringComparison;
		public virtual RMethod RMGetHashCode_StringComparison
		{
			get
			{
				if(r_MGetHashCode_StringComparison == null)
				{
					r_MGetHashCode_StringComparison = new(this, "GetHashCode", 0, typeof(System.StringComparison));
					r_MGetHashCode_StringComparison.SetBelong(this.instance);
				}
				return r_MGetHashCode_StringComparison;
			}
		}

		/// <summary>
		/// Int32 GetLegacyNonRandomizedHashCode()
		/// </summary>
		protected RMethod r_MGetLegacyNonRandomizedHashCode;
		public virtual RMethod RMGetLegacyNonRandomizedHashCode
		{
			get
			{
				if(r_MGetLegacyNonRandomizedHashCode == null)
				{
					r_MGetLegacyNonRandomizedHashCode = new(this, "GetLegacyNonRandomizedHashCode", 0);
					r_MGetLegacyNonRandomizedHashCode.SetBelong(this.instance);
				}
				return r_MGetLegacyNonRandomizedHashCode;
			}
		}

		/// <summary>
		/// Boolean StartsWith(System.String)
		/// </summary>
		protected RMethod r_MStartsWith_String;
		public virtual RMethod RMStartsWith_String
		{
			get
			{
				if(r_MStartsWith_String == null)
				{
					r_MStartsWith_String = new(this, "StartsWith", 0, typeof(System.String));
					r_MStartsWith_String.SetBelong(this.instance);
				}
				return r_MStartsWith_String;
			}
		}

		/// <summary>
		/// Boolean StartsWith(System.String, System.StringComparison)
		/// </summary>
		protected RMethod r_MStartsWith_String_StringComparison;
		public virtual RMethod RMStartsWith_String_StringComparison
		{
			get
			{
				if(r_MStartsWith_String_StringComparison == null)
				{
					r_MStartsWith_String_StringComparison = new(this, "StartsWith", 0, typeof(System.String), typeof(System.StringComparison));
					r_MStartsWith_String_StringComparison.SetBelong(this.instance);
				}
				return r_MStartsWith_String_StringComparison;
			}
		}

		/// <summary>
		/// Boolean StartsWith(System.String, Boolean, System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_MStartsWith_String_Boolean_CultureInfo;
		public virtual RMethod RMStartsWith_String_Boolean_CultureInfo
		{
			get
			{
				if(r_MStartsWith_String_Boolean_CultureInfo == null)
				{
					r_MStartsWith_String_Boolean_CultureInfo = new(this, "StartsWith", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Globalization.CultureInfo));
					r_MStartsWith_String_Boolean_CultureInfo.SetBelong(this.instance);
				}
				return r_MStartsWith_String_Boolean_CultureInfo;
			}
		}

		/// <summary>
		/// Boolean StartsWith(Char)
		/// </summary>
		protected RMethod r_MStartsWith_Char;
		public virtual RMethod RMStartsWith_Char
		{
			get
			{
				if(r_MStartsWith_Char == null)
				{
					r_MStartsWith_Char = new(this, "StartsWith", 0, typeof(System.Char));
					r_MStartsWith_Char.SetBelong(this.instance);
				}
				return r_MStartsWith_Char;
			}
		}

		/// <summary>
		/// Void CheckStringComparison(System.StringComparison)
		/// </summary>
		protected static RMethod r_MCheckStringComparison_StringComparison;
		public static RMethod RMCheckStringComparison_StringComparison
		{
			get
			{
				if(r_MCheckStringComparison_StringComparison == null)
				{
					r_MCheckStringComparison_StringComparison = new(typeof(System.String), "CheckStringComparison", 0, typeof(System.StringComparison));
					r_MCheckStringComparison_StringComparison.SetBelong(null);
				}
				return r_MCheckStringComparison_StringComparison;
			}
		}

		/// <summary>
		/// Void FillStringChecked(System.String, Int32, System.String)
		/// </summary>
		protected static RMethod r_MFillStringChecked_String_Int32_String;
		public static RMethod RMFillStringChecked_String_Int32_String
		{
			get
			{
				if(r_MFillStringChecked_String_Int32_String == null)
				{
					r_MFillStringChecked_String_Int32_String = new(typeof(System.String), "FillStringChecked", 0, typeof(System.String), typeof(System.Int32), typeof(System.String));
					r_MFillStringChecked_String_Int32_String.SetBelong(null);
				}
				return r_MFillStringChecked_String_Int32_String;
			}
		}

		/// <summary>
		/// System.String Concat(System.Object)
		/// </summary>
		protected static RMethod r_MConcat_Object;
		public static RMethod RMConcat_Object
		{
			get
			{
				if(r_MConcat_Object == null)
				{
					r_MConcat_Object = new(typeof(System.String), "Concat", 0, typeof(System.Object));
					r_MConcat_Object.SetBelong(null);
				}
				return r_MConcat_Object;
			}
		}

		/// <summary>
		/// System.String Concat(System.Object, System.Object)
		/// </summary>
		protected static RMethod r_MConcat_Object_Object;
		public static RMethod RMConcat_Object_Object
		{
			get
			{
				if(r_MConcat_Object_Object == null)
				{
					r_MConcat_Object_Object = new(typeof(System.String), "Concat", 0, typeof(System.Object), typeof(System.Object));
					r_MConcat_Object_Object.SetBelong(null);
				}
				return r_MConcat_Object_Object;
			}
		}

		/// <summary>
		/// System.String Concat(System.Object, System.Object, System.Object)
		/// </summary>
		protected static RMethod r_MConcat_Object_Object_Object;
		public static RMethod RMConcat_Object_Object_Object
		{
			get
			{
				if(r_MConcat_Object_Object_Object == null)
				{
					r_MConcat_Object_Object_Object = new(typeof(System.String), "Concat", 0, typeof(System.Object), typeof(System.Object), typeof(System.Object));
					r_MConcat_Object_Object_Object.SetBelong(null);
				}
				return r_MConcat_Object_Object_Object;
			}
		}

		/// <summary>
		/// System.String Concat(System.Object[])
		/// </summary>
		protected static RMethod r_MConcat_ObjectArray;
		public static RMethod RMConcat_ObjectArray
		{
			get
			{
				if(r_MConcat_ObjectArray == null)
				{
					r_MConcat_ObjectArray = new(typeof(System.String), "Concat", 0, typeof(System.Object).MakeArrayType());
					r_MConcat_ObjectArray.SetBelong(null);
				}
				return r_MConcat_ObjectArray;
			}
		}

		/// <summary>
		/// System.String Concat[T](System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected static RMethod r_MConcat_GT_IEnumerable_d_T_p_;
		public static RMethod RMConcat_GT_IEnumerable_d_T_p_
		{
			get
			{
				if(r_MConcat_GT_IEnumerable_d_T_p_ == null)
				{
					r_MConcat_GT_IEnumerable_d_T_p_ = new(typeof(System.String), "Concat", 1, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MConcat_GT_IEnumerable_d_T_p_.SetBelong(null);
				}
				return r_MConcat_GT_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// System.String Concat(System.Collections.Generic.IEnumerable`1[System.String])
		/// </summary>
		protected static RMethod r_MConcat_IEnumerable_d_String_p_;
		public static RMethod RMConcat_IEnumerable_d_String_p_
		{
			get
			{
				if(r_MConcat_IEnumerable_d_String_p_ == null)
				{
					r_MConcat_IEnumerable_d_String_p_ = new(typeof(System.String), "Concat", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.String)));
					r_MConcat_IEnumerable_d_String_p_.SetBelong(null);
				}
				return r_MConcat_IEnumerable_d_String_p_;
			}
		}

		/// <summary>
		/// System.String Concat(System.String, System.String)
		/// </summary>
		protected static RMethod r_MConcat_String_String;
		public static RMethod RMConcat_String_String
		{
			get
			{
				if(r_MConcat_String_String == null)
				{
					r_MConcat_String_String = new(typeof(System.String), "Concat", 0, typeof(System.String), typeof(System.String));
					r_MConcat_String_String.SetBelong(null);
				}
				return r_MConcat_String_String;
			}
		}

		/// <summary>
		/// System.String Concat(System.String, System.String, System.String)
		/// </summary>
		protected static RMethod r_MConcat_String_String_String;
		public static RMethod RMConcat_String_String_String
		{
			get
			{
				if(r_MConcat_String_String_String == null)
				{
					r_MConcat_String_String_String = new(typeof(System.String), "Concat", 0, typeof(System.String), typeof(System.String), typeof(System.String));
					r_MConcat_String_String_String.SetBelong(null);
				}
				return r_MConcat_String_String_String;
			}
		}

		/// <summary>
		/// System.String Concat(System.String, System.String, System.String, System.String)
		/// </summary>
		protected static RMethod r_MConcat_String_String_String_String;
		public static RMethod RMConcat_String_String_String_String
		{
			get
			{
				if(r_MConcat_String_String_String_String == null)
				{
					r_MConcat_String_String_String_String = new(typeof(System.String), "Concat", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.String));
					r_MConcat_String_String_String_String.SetBelong(null);
				}
				return r_MConcat_String_String_String_String;
			}
		}

		/// <summary>
		/// System.String Concat(System.String[])
		/// </summary>
		protected static RMethod r_MConcat_StringArray;
		public static RMethod RMConcat_StringArray
		{
			get
			{
				if(r_MConcat_StringArray == null)
				{
					r_MConcat_StringArray = new(typeof(System.String), "Concat", 0, typeof(System.String).MakeArrayType());
					r_MConcat_StringArray.SetBelong(null);
				}
				return r_MConcat_StringArray;
			}
		}

		/// <summary>
		/// System.String Format(System.String, System.Object)
		/// </summary>
		protected static RMethod r_MFormat_String_Object;
		public static RMethod RMFormat_String_Object
		{
			get
			{
				if(r_MFormat_String_Object == null)
				{
					r_MFormat_String_Object = new(typeof(System.String), "Format", 0, typeof(System.String), typeof(System.Object));
					r_MFormat_String_Object.SetBelong(null);
				}
				return r_MFormat_String_Object;
			}
		}

		/// <summary>
		/// System.String Format(System.String, System.Object, System.Object)
		/// </summary>
		protected static RMethod r_MFormat_String_Object_Object;
		public static RMethod RMFormat_String_Object_Object
		{
			get
			{
				if(r_MFormat_String_Object_Object == null)
				{
					r_MFormat_String_Object_Object = new(typeof(System.String), "Format", 0, typeof(System.String), typeof(System.Object), typeof(System.Object));
					r_MFormat_String_Object_Object.SetBelong(null);
				}
				return r_MFormat_String_Object_Object;
			}
		}

		/// <summary>
		/// System.String Format(System.String, System.Object, System.Object, System.Object)
		/// </summary>
		protected static RMethod r_MFormat_String_Object_Object_Object;
		public static RMethod RMFormat_String_Object_Object_Object
		{
			get
			{
				if(r_MFormat_String_Object_Object_Object == null)
				{
					r_MFormat_String_Object_Object_Object = new(typeof(System.String), "Format", 0, typeof(System.String), typeof(System.Object), typeof(System.Object), typeof(System.Object));
					r_MFormat_String_Object_Object_Object.SetBelong(null);
				}
				return r_MFormat_String_Object_Object_Object;
			}
		}

		/// <summary>
		/// System.String Format(System.String, System.Object[])
		/// </summary>
		protected static RMethod r_MFormat_String_ObjectArray;
		public static RMethod RMFormat_String_ObjectArray
		{
			get
			{
				if(r_MFormat_String_ObjectArray == null)
				{
					r_MFormat_String_ObjectArray = new(typeof(System.String), "Format", 0, typeof(System.String), typeof(System.Object).MakeArrayType());
					r_MFormat_String_ObjectArray.SetBelong(null);
				}
				return r_MFormat_String_ObjectArray;
			}
		}

		/// <summary>
		/// System.String Format(System.IFormatProvider, System.String, System.Object)
		/// </summary>
		protected static RMethod r_MFormat_IFormatProvider_String_Object;
		public static RMethod RMFormat_IFormatProvider_String_Object
		{
			get
			{
				if(r_MFormat_IFormatProvider_String_Object == null)
				{
					r_MFormat_IFormatProvider_String_Object = new(typeof(System.String), "Format", 0, typeof(System.IFormatProvider), typeof(System.String), typeof(System.Object));
					r_MFormat_IFormatProvider_String_Object.SetBelong(null);
				}
				return r_MFormat_IFormatProvider_String_Object;
			}
		}

		/// <summary>
		/// System.String Format(System.IFormatProvider, System.String, System.Object, System.Object)
		/// </summary>
		protected static RMethod r_MFormat_IFormatProvider_String_Object_Object;
		public static RMethod RMFormat_IFormatProvider_String_Object_Object
		{
			get
			{
				if(r_MFormat_IFormatProvider_String_Object_Object == null)
				{
					r_MFormat_IFormatProvider_String_Object_Object = new(typeof(System.String), "Format", 0, typeof(System.IFormatProvider), typeof(System.String), typeof(System.Object), typeof(System.Object));
					r_MFormat_IFormatProvider_String_Object_Object.SetBelong(null);
				}
				return r_MFormat_IFormatProvider_String_Object_Object;
			}
		}

		/// <summary>
		/// System.String Format(System.IFormatProvider, System.String, System.Object, System.Object, System.Object)
		/// </summary>
		protected static RMethod r_MFormat_IFormatProvider_String_Object_Object_Object;
		public static RMethod RMFormat_IFormatProvider_String_Object_Object_Object
		{
			get
			{
				if(r_MFormat_IFormatProvider_String_Object_Object_Object == null)
				{
					r_MFormat_IFormatProvider_String_Object_Object_Object = new(typeof(System.String), "Format", 0, typeof(System.IFormatProvider), typeof(System.String), typeof(System.Object), typeof(System.Object), typeof(System.Object));
					r_MFormat_IFormatProvider_String_Object_Object_Object.SetBelong(null);
				}
				return r_MFormat_IFormatProvider_String_Object_Object_Object;
			}
		}

		/// <summary>
		/// System.String Format(System.IFormatProvider, System.String, System.Object[])
		/// </summary>
		protected static RMethod r_MFormat_IFormatProvider_String_ObjectArray;
		public static RMethod RMFormat_IFormatProvider_String_ObjectArray
		{
			get
			{
				if(r_MFormat_IFormatProvider_String_ObjectArray == null)
				{
					r_MFormat_IFormatProvider_String_ObjectArray = new(typeof(System.String), "Format", 0, typeof(System.IFormatProvider), typeof(System.String), typeof(System.Object).MakeArrayType());
					r_MFormat_IFormatProvider_String_ObjectArray.SetBelong(null);
				}
				return r_MFormat_IFormatProvider_String_ObjectArray;
			}
		}

		/// <summary>
		/// System.String FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
		/// </summary>
		protected static RMethod r_MFormatHelper_IFormatProvider_String_ParamsArray;
		public static RMethod RMFormatHelper_IFormatProvider_String_ParamsArray
		{
			get
			{
				if(r_MFormatHelper_IFormatProvider_String_ParamsArray == null)
				{
					r_MFormatHelper_IFormatProvider_String_ParamsArray = new(typeof(System.String), "FormatHelper", 0, typeof(System.IFormatProvider), typeof(System.String),  ReflectionUtils.GetType("System.ParamsArray"));
					r_MFormatHelper_IFormatProvider_String_ParamsArray.SetBelong(null);
				}
				return r_MFormatHelper_IFormatProvider_String_ParamsArray;
			}
		}

		/// <summary>
		/// System.String Insert(Int32, System.String)
		/// </summary>
		protected RMethod r_MInsert_Int32_String;
		public virtual RMethod RMInsert_Int32_String
		{
			get
			{
				if(r_MInsert_Int32_String == null)
				{
					r_MInsert_Int32_String = new(this, "Insert", 0, typeof(System.Int32), typeof(System.String));
					r_MInsert_Int32_String.SetBelong(this.instance);
				}
				return r_MInsert_Int32_String;
			}
		}

		/// <summary>
		/// System.String Join(Char, System.String[])
		/// </summary>
		protected static RMethod r_MJoin_Char_StringArray;
		public static RMethod RMJoin_Char_StringArray
		{
			get
			{
				if(r_MJoin_Char_StringArray == null)
				{
					r_MJoin_Char_StringArray = new(typeof(System.String), "Join", 0, typeof(System.Char), typeof(System.String).MakeArrayType());
					r_MJoin_Char_StringArray.SetBelong(null);
				}
				return r_MJoin_Char_StringArray;
			}
		}

		/// <summary>
		/// System.String Join(Char, System.Object[])
		/// </summary>
		protected static RMethod r_MJoin_Char_ObjectArray;
		public static RMethod RMJoin_Char_ObjectArray
		{
			get
			{
				if(r_MJoin_Char_ObjectArray == null)
				{
					r_MJoin_Char_ObjectArray = new(typeof(System.String), "Join", 0, typeof(System.Char), typeof(System.Object).MakeArrayType());
					r_MJoin_Char_ObjectArray.SetBelong(null);
				}
				return r_MJoin_Char_ObjectArray;
			}
		}

		/// <summary>
		/// System.String Join[T](Char, System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected static RMethod r_MJoin_GT_Char_IEnumerable_d_T_p_;
		public static RMethod RMJoin_GT_Char_IEnumerable_d_T_p_
		{
			get
			{
				if(r_MJoin_GT_Char_IEnumerable_d_T_p_ == null)
				{
					r_MJoin_GT_Char_IEnumerable_d_T_p_ = new(typeof(System.String), "Join", 1, typeof(System.Char), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MJoin_GT_Char_IEnumerable_d_T_p_.SetBelong(null);
				}
				return r_MJoin_GT_Char_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// System.String Join(Char, System.String[], Int32, Int32)
		/// </summary>
		protected static RMethod r_MJoin_Char_StringArray_Int32_Int32;
		public static RMethod RMJoin_Char_StringArray_Int32_Int32
		{
			get
			{
				if(r_MJoin_Char_StringArray_Int32_Int32 == null)
				{
					r_MJoin_Char_StringArray_Int32_Int32 = new(typeof(System.String), "Join", 0, typeof(System.Char), typeof(System.String).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MJoin_Char_StringArray_Int32_Int32.SetBelong(null);
				}
				return r_MJoin_Char_StringArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String Join(System.String, System.String[])
		/// </summary>
		protected static RMethod r_MJoin_String_StringArray;
		public static RMethod RMJoin_String_StringArray
		{
			get
			{
				if(r_MJoin_String_StringArray == null)
				{
					r_MJoin_String_StringArray = new(typeof(System.String), "Join", 0, typeof(System.String), typeof(System.String).MakeArrayType());
					r_MJoin_String_StringArray.SetBelong(null);
				}
				return r_MJoin_String_StringArray;
			}
		}

		/// <summary>
		/// System.String Join(System.String, System.Object[])
		/// </summary>
		protected static RMethod r_MJoin_String_ObjectArray;
		public static RMethod RMJoin_String_ObjectArray
		{
			get
			{
				if(r_MJoin_String_ObjectArray == null)
				{
					r_MJoin_String_ObjectArray = new(typeof(System.String), "Join", 0, typeof(System.String), typeof(System.Object).MakeArrayType());
					r_MJoin_String_ObjectArray.SetBelong(null);
				}
				return r_MJoin_String_ObjectArray;
			}
		}

		/// <summary>
		/// System.String Join[T](System.String, System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected static RMethod r_MJoin_GT_String_IEnumerable_d_T_p_;
		public static RMethod RMJoin_GT_String_IEnumerable_d_T_p_
		{
			get
			{
				if(r_MJoin_GT_String_IEnumerable_d_T_p_ == null)
				{
					r_MJoin_GT_String_IEnumerable_d_T_p_ = new(typeof(System.String), "Join", 1, typeof(System.String), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MJoin_GT_String_IEnumerable_d_T_p_.SetBelong(null);
				}
				return r_MJoin_GT_String_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// System.String Join(System.String, System.Collections.Generic.IEnumerable`1[System.String])
		/// </summary>
		protected static RMethod r_MJoin_String_IEnumerable_d_String_p_;
		public static RMethod RMJoin_String_IEnumerable_d_String_p_
		{
			get
			{
				if(r_MJoin_String_IEnumerable_d_String_p_ == null)
				{
					r_MJoin_String_IEnumerable_d_String_p_ = new(typeof(System.String), "Join", 0, typeof(System.String), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.String)));
					r_MJoin_String_IEnumerable_d_String_p_.SetBelong(null);
				}
				return r_MJoin_String_IEnumerable_d_String_p_;
			}
		}

		/// <summary>
		/// System.String Join(System.String, System.String[], Int32, Int32)
		/// </summary>
		protected static RMethod r_MJoin_String_StringArray_Int32_Int32;
		public static RMethod RMJoin_String_StringArray_Int32_Int32
		{
			get
			{
				if(r_MJoin_String_StringArray_Int32_Int32 == null)
				{
					r_MJoin_String_StringArray_Int32_Int32 = new(typeof(System.String), "Join", 0, typeof(System.String), typeof(System.String).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MJoin_String_StringArray_Int32_Int32.SetBelong(null);
				}
				return r_MJoin_String_StringArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String JoinCore(Char*, Int32, System.Object[])
		/// </summary>
		protected static RMethod r_MJoinCore_CharPointer_Int32_ObjectArray;
		public static RMethod RMJoinCore_CharPointer_Int32_ObjectArray
		{
			get
			{
				if(r_MJoinCore_CharPointer_Int32_ObjectArray == null)
				{
					r_MJoinCore_CharPointer_Int32_ObjectArray = new(typeof(System.String), "JoinCore", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Object).MakeArrayType());
					r_MJoinCore_CharPointer_Int32_ObjectArray.SetBelong(null);
				}
				return r_MJoinCore_CharPointer_Int32_ObjectArray;
			}
		}

		/// <summary>
		/// System.String JoinCore[T](Char*, Int32, System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected static RMethod r_MJoinCore_GT_CharPointer_Int32_IEnumerable_d_T_p_;
		public static RMethod RMJoinCore_GT_CharPointer_Int32_IEnumerable_d_T_p_
		{
			get
			{
				if(r_MJoinCore_GT_CharPointer_Int32_IEnumerable_d_T_p_ == null)
				{
					r_MJoinCore_GT_CharPointer_Int32_IEnumerable_d_T_p_ = new(typeof(System.String), "JoinCore", 1, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MJoinCore_GT_CharPointer_Int32_IEnumerable_d_T_p_.SetBelong(null);
				}
				return r_MJoinCore_GT_CharPointer_Int32_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// System.String JoinCore(Char*, Int32, System.String[], Int32, Int32)
		/// </summary>
		protected static RMethod r_MJoinCore_CharPointer_Int32_StringArray_Int32_Int32;
		public static RMethod RMJoinCore_CharPointer_Int32_StringArray_Int32_Int32
		{
			get
			{
				if(r_MJoinCore_CharPointer_Int32_StringArray_Int32_Int32 == null)
				{
					r_MJoinCore_CharPointer_Int32_StringArray_Int32_Int32 = new(typeof(System.String), "JoinCore", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.String).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MJoinCore_CharPointer_Int32_StringArray_Int32_Int32.SetBelong(null);
				}
				return r_MJoinCore_CharPointer_Int32_StringArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String PadLeft(Int32)
		/// </summary>
		protected RMethod r_MPadLeft_Int32;
		public virtual RMethod RMPadLeft_Int32
		{
			get
			{
				if(r_MPadLeft_Int32 == null)
				{
					r_MPadLeft_Int32 = new(this, "PadLeft", 0, typeof(System.Int32));
					r_MPadLeft_Int32.SetBelong(this.instance);
				}
				return r_MPadLeft_Int32;
			}
		}

		/// <summary>
		/// System.String PadLeft(Int32, Char)
		/// </summary>
		protected RMethod r_MPadLeft_Int32_Char;
		public virtual RMethod RMPadLeft_Int32_Char
		{
			get
			{
				if(r_MPadLeft_Int32_Char == null)
				{
					r_MPadLeft_Int32_Char = new(this, "PadLeft", 0, typeof(System.Int32), typeof(System.Char));
					r_MPadLeft_Int32_Char.SetBelong(this.instance);
				}
				return r_MPadLeft_Int32_Char;
			}
		}

		/// <summary>
		/// System.String PadRight(Int32)
		/// </summary>
		protected RMethod r_MPadRight_Int32;
		public virtual RMethod RMPadRight_Int32
		{
			get
			{
				if(r_MPadRight_Int32 == null)
				{
					r_MPadRight_Int32 = new(this, "PadRight", 0, typeof(System.Int32));
					r_MPadRight_Int32.SetBelong(this.instance);
				}
				return r_MPadRight_Int32;
			}
		}

		/// <summary>
		/// System.String PadRight(Int32, Char)
		/// </summary>
		protected RMethod r_MPadRight_Int32_Char;
		public virtual RMethod RMPadRight_Int32_Char
		{
			get
			{
				if(r_MPadRight_Int32_Char == null)
				{
					r_MPadRight_Int32_Char = new(this, "PadRight", 0, typeof(System.Int32), typeof(System.Char));
					r_MPadRight_Int32_Char.SetBelong(this.instance);
				}
				return r_MPadRight_Int32_Char;
			}
		}

		/// <summary>
		/// System.String Remove(Int32, Int32)
		/// </summary>
		protected RMethod r_MRemove_Int32_Int32;
		public virtual RMethod RMRemove_Int32_Int32
		{
			get
			{
				if(r_MRemove_Int32_Int32 == null)
				{
					r_MRemove_Int32_Int32 = new(this, "Remove", 0, typeof(System.Int32), typeof(System.Int32));
					r_MRemove_Int32_Int32.SetBelong(this.instance);
				}
				return r_MRemove_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String Remove(Int32)
		/// </summary>
		protected RMethod r_MRemove_Int32;
		public virtual RMethod RMRemove_Int32
		{
			get
			{
				if(r_MRemove_Int32 == null)
				{
					r_MRemove_Int32 = new(this, "Remove", 0, typeof(System.Int32));
					r_MRemove_Int32.SetBelong(this.instance);
				}
				return r_MRemove_Int32;
			}
		}

		/// <summary>
		/// System.String Replace(System.String, System.String, Boolean, System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_MReplace_String_String_Boolean_CultureInfo;
		public virtual RMethod RMReplace_String_String_Boolean_CultureInfo
		{
			get
			{
				if(r_MReplace_String_String_Boolean_CultureInfo == null)
				{
					r_MReplace_String_String_Boolean_CultureInfo = new(this, "Replace", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.Globalization.CultureInfo));
					r_MReplace_String_String_Boolean_CultureInfo.SetBelong(this.instance);
				}
				return r_MReplace_String_String_Boolean_CultureInfo;
			}
		}

		/// <summary>
		/// System.String Replace(System.String, System.String, System.StringComparison)
		/// </summary>
		protected RMethod r_MReplace_String_String_StringComparison;
		public virtual RMethod RMReplace_String_String_StringComparison
		{
			get
			{
				if(r_MReplace_String_String_StringComparison == null)
				{
					r_MReplace_String_String_StringComparison = new(this, "Replace", 0, typeof(System.String), typeof(System.String), typeof(System.StringComparison));
					r_MReplace_String_String_StringComparison.SetBelong(this.instance);
				}
				return r_MReplace_String_String_StringComparison;
			}
		}

		/// <summary>
		/// System.String ReplaceCore(System.String, System.String, System.Globalization.CultureInfo, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MReplaceCore_String_String_CultureInfo_CompareOptions;
		public virtual RMethod RMReplaceCore_String_String_CultureInfo_CompareOptions
		{
			get
			{
				if(r_MReplaceCore_String_String_CultureInfo_CompareOptions == null)
				{
					r_MReplaceCore_String_String_CultureInfo_CompareOptions = new(this, "ReplaceCore", 0, typeof(System.String), typeof(System.String), typeof(System.Globalization.CultureInfo), typeof(System.Globalization.CompareOptions));
					r_MReplaceCore_String_String_CultureInfo_CompareOptions.SetBelong(this.instance);
				}
				return r_MReplaceCore_String_String_CultureInfo_CompareOptions;
			}
		}

		/// <summary>
		/// System.String Replace(Char, Char)
		/// </summary>
		protected RMethod r_MReplace_Char_Char;
		public virtual RMethod RMReplace_Char_Char
		{
			get
			{
				if(r_MReplace_Char_Char == null)
				{
					r_MReplace_Char_Char = new(this, "Replace", 0, typeof(System.Char), typeof(System.Char));
					r_MReplace_Char_Char.SetBelong(this.instance);
				}
				return r_MReplace_Char_Char;
			}
		}

		/// <summary>
		/// System.String Replace(System.String, System.String)
		/// </summary>
		protected RMethod r_MReplace_String_String;
		public virtual RMethod RMReplace_String_String
		{
			get
			{
				if(r_MReplace_String_String == null)
				{
					r_MReplace_String_String = new(this, "Replace", 0, typeof(System.String), typeof(System.String));
					r_MReplace_String_String.SetBelong(this.instance);
				}
				return r_MReplace_String_String;
			}
		}

		/// <summary>
		/// System.String ReplaceHelper(Int32, System.String, System.ReadOnlySpan`1[System.Int32])
		/// </summary>
		protected RMethod r_MReplaceHelper_Int32_String_ReadOnlySpan_d_Int32_p_;
		public virtual RMethod RMReplaceHelper_Int32_String_ReadOnlySpan_d_Int32_p_
		{
			get
			{
				if(r_MReplaceHelper_Int32_String_ReadOnlySpan_d_Int32_p_ == null)
				{
					r_MReplaceHelper_Int32_String_ReadOnlySpan_d_Int32_p_ = new(this, "ReplaceHelper", 0, typeof(System.Int32), typeof(System.String), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Int32)));
					r_MReplaceHelper_Int32_String_ReadOnlySpan_d_Int32_p_.SetBelong(this.instance);
				}
				return r_MReplaceHelper_Int32_String_ReadOnlySpan_d_Int32_p_;
			}
		}

		/// <summary>
		/// System.String[] Split(Char, System.StringSplitOptions)
		/// </summary>
		protected RMethod r_MSplit_Char_StringSplitOptions;
		public virtual RMethod RMSplit_Char_StringSplitOptions
		{
			get
			{
				if(r_MSplit_Char_StringSplitOptions == null)
				{
					r_MSplit_Char_StringSplitOptions = new(this, "Split", 0, typeof(System.Char), typeof(System.StringSplitOptions));
					r_MSplit_Char_StringSplitOptions.SetBelong(this.instance);
				}
				return r_MSplit_Char_StringSplitOptions;
			}
		}

		/// <summary>
		/// System.String[] Split(Char, Int32, System.StringSplitOptions)
		/// </summary>
		protected RMethod r_MSplit_Char_Int32_StringSplitOptions;
		public virtual RMethod RMSplit_Char_Int32_StringSplitOptions
		{
			get
			{
				if(r_MSplit_Char_Int32_StringSplitOptions == null)
				{
					r_MSplit_Char_Int32_StringSplitOptions = new(this, "Split", 0, typeof(System.Char), typeof(System.Int32), typeof(System.StringSplitOptions));
					r_MSplit_Char_Int32_StringSplitOptions.SetBelong(this.instance);
				}
				return r_MSplit_Char_Int32_StringSplitOptions;
			}
		}

		/// <summary>
		/// System.String[] Split(Char[])
		/// </summary>
		protected RMethod r_MSplit_CharArray;
		public virtual RMethod RMSplit_CharArray
		{
			get
			{
				if(r_MSplit_CharArray == null)
				{
					r_MSplit_CharArray = new(this, "Split", 0, typeof(System.Char).MakeArrayType());
					r_MSplit_CharArray.SetBelong(this.instance);
				}
				return r_MSplit_CharArray;
			}
		}

		/// <summary>
		/// System.String[] Split(Char[], Int32)
		/// </summary>
		protected RMethod r_MSplit_CharArray_Int32;
		public virtual RMethod RMSplit_CharArray_Int32
		{
			get
			{
				if(r_MSplit_CharArray_Int32 == null)
				{
					r_MSplit_CharArray_Int32 = new(this, "Split", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32));
					r_MSplit_CharArray_Int32.SetBelong(this.instance);
				}
				return r_MSplit_CharArray_Int32;
			}
		}

		/// <summary>
		/// System.String[] Split(Char[], System.StringSplitOptions)
		/// </summary>
		protected RMethod r_MSplit_CharArray_StringSplitOptions;
		public virtual RMethod RMSplit_CharArray_StringSplitOptions
		{
			get
			{
				if(r_MSplit_CharArray_StringSplitOptions == null)
				{
					r_MSplit_CharArray_StringSplitOptions = new(this, "Split", 0, typeof(System.Char).MakeArrayType(), typeof(System.StringSplitOptions));
					r_MSplit_CharArray_StringSplitOptions.SetBelong(this.instance);
				}
				return r_MSplit_CharArray_StringSplitOptions;
			}
		}

		/// <summary>
		/// System.String[] Split(Char[], Int32, System.StringSplitOptions)
		/// </summary>
		protected RMethod r_MSplit_CharArray_Int32_StringSplitOptions;
		public virtual RMethod RMSplit_CharArray_Int32_StringSplitOptions
		{
			get
			{
				if(r_MSplit_CharArray_Int32_StringSplitOptions == null)
				{
					r_MSplit_CharArray_Int32_StringSplitOptions = new(this, "Split", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.StringSplitOptions));
					r_MSplit_CharArray_Int32_StringSplitOptions.SetBelong(this.instance);
				}
				return r_MSplit_CharArray_Int32_StringSplitOptions;
			}
		}

		/// <summary>
		/// System.String[] SplitInternal(System.ReadOnlySpan`1[System.Char], Int32, System.StringSplitOptions)
		/// </summary>
		protected RMethod r_MSplitInternal_ReadOnlySpan_d_Char_p__Int32_StringSplitOptions;
		public virtual RMethod RMSplitInternal_ReadOnlySpan_d_Char_p__Int32_StringSplitOptions
		{
			get
			{
				if(r_MSplitInternal_ReadOnlySpan_d_Char_p__Int32_StringSplitOptions == null)
				{
					r_MSplitInternal_ReadOnlySpan_d_Char_p__Int32_StringSplitOptions = new(this, "SplitInternal", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Int32), typeof(System.StringSplitOptions));
					r_MSplitInternal_ReadOnlySpan_d_Char_p__Int32_StringSplitOptions.SetBelong(this.instance);
				}
				return r_MSplitInternal_ReadOnlySpan_d_Char_p__Int32_StringSplitOptions;
			}
		}

		/// <summary>
		/// System.String[] Split(System.String, System.StringSplitOptions)
		/// </summary>
		protected RMethod r_MSplit_String_StringSplitOptions;
		public virtual RMethod RMSplit_String_StringSplitOptions
		{
			get
			{
				if(r_MSplit_String_StringSplitOptions == null)
				{
					r_MSplit_String_StringSplitOptions = new(this, "Split", 0, typeof(System.String), typeof(System.StringSplitOptions));
					r_MSplit_String_StringSplitOptions.SetBelong(this.instance);
				}
				return r_MSplit_String_StringSplitOptions;
			}
		}

		/// <summary>
		/// System.String[] Split(System.String, Int32, System.StringSplitOptions)
		/// </summary>
		protected RMethod r_MSplit_String_Int32_StringSplitOptions;
		public virtual RMethod RMSplit_String_Int32_StringSplitOptions
		{
			get
			{
				if(r_MSplit_String_Int32_StringSplitOptions == null)
				{
					r_MSplit_String_Int32_StringSplitOptions = new(this, "Split", 0, typeof(System.String), typeof(System.Int32), typeof(System.StringSplitOptions));
					r_MSplit_String_Int32_StringSplitOptions.SetBelong(this.instance);
				}
				return r_MSplit_String_Int32_StringSplitOptions;
			}
		}

		/// <summary>
		/// System.String[] Split(System.String[], System.StringSplitOptions)
		/// </summary>
		protected RMethod r_MSplit_StringArray_StringSplitOptions;
		public virtual RMethod RMSplit_StringArray_StringSplitOptions
		{
			get
			{
				if(r_MSplit_StringArray_StringSplitOptions == null)
				{
					r_MSplit_StringArray_StringSplitOptions = new(this, "Split", 0, typeof(System.String).MakeArrayType(), typeof(System.StringSplitOptions));
					r_MSplit_StringArray_StringSplitOptions.SetBelong(this.instance);
				}
				return r_MSplit_StringArray_StringSplitOptions;
			}
		}

		/// <summary>
		/// System.String[] Split(System.String[], Int32, System.StringSplitOptions)
		/// </summary>
		protected RMethod r_MSplit_StringArray_Int32_StringSplitOptions;
		public virtual RMethod RMSplit_StringArray_Int32_StringSplitOptions
		{
			get
			{
				if(r_MSplit_StringArray_Int32_StringSplitOptions == null)
				{
					r_MSplit_StringArray_Int32_StringSplitOptions = new(this, "Split", 0, typeof(System.String).MakeArrayType(), typeof(System.Int32), typeof(System.StringSplitOptions));
					r_MSplit_StringArray_Int32_StringSplitOptions.SetBelong(this.instance);
				}
				return r_MSplit_StringArray_Int32_StringSplitOptions;
			}
		}

		/// <summary>
		/// System.String[] SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
		/// </summary>
		protected RMethod r_MSplitInternal_String_StringArray_Int32_StringSplitOptions;
		public virtual RMethod RMSplitInternal_String_StringArray_Int32_StringSplitOptions
		{
			get
			{
				if(r_MSplitInternal_String_StringArray_Int32_StringSplitOptions == null)
				{
					r_MSplitInternal_String_StringArray_Int32_StringSplitOptions = new(this, "SplitInternal", 0, typeof(System.String), typeof(System.String).MakeArrayType(), typeof(System.Int32), typeof(System.StringSplitOptions));
					r_MSplitInternal_String_StringArray_Int32_StringSplitOptions.SetBelong(this.instance);
				}
				return r_MSplitInternal_String_StringArray_Int32_StringSplitOptions;
			}
		}

		/// <summary>
		/// System.String[] SplitInternal(System.String, Int32, System.StringSplitOptions)
		/// </summary>
		protected RMethod r_MSplitInternal_String_Int32_StringSplitOptions;
		public virtual RMethod RMSplitInternal_String_Int32_StringSplitOptions
		{
			get
			{
				if(r_MSplitInternal_String_Int32_StringSplitOptions == null)
				{
					r_MSplitInternal_String_Int32_StringSplitOptions = new(this, "SplitInternal", 0, typeof(System.String), typeof(System.Int32), typeof(System.StringSplitOptions));
					r_MSplitInternal_String_Int32_StringSplitOptions.SetBelong(this.instance);
				}
				return r_MSplitInternal_String_Int32_StringSplitOptions;
			}
		}

		/// <summary>
		/// System.String[] SplitKeepEmptyEntries(System.ReadOnlySpan`1[System.Int32], System.ReadOnlySpan`1[System.Int32], Int32, Int32)
		/// </summary>
		protected RMethod r_MSplitKeepEmptyEntries_ReadOnlySpan_d_Int32_p__ReadOnlySpan_d_Int32_p__Int32_Int32;
		public virtual RMethod RMSplitKeepEmptyEntries_ReadOnlySpan_d_Int32_p__ReadOnlySpan_d_Int32_p__Int32_Int32
		{
			get
			{
				if(r_MSplitKeepEmptyEntries_ReadOnlySpan_d_Int32_p__ReadOnlySpan_d_Int32_p__Int32_Int32 == null)
				{
					r_MSplitKeepEmptyEntries_ReadOnlySpan_d_Int32_p__ReadOnlySpan_d_Int32_p__Int32_Int32 = new(this, "SplitKeepEmptyEntries", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Int32)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Int32)), typeof(System.Int32), typeof(System.Int32));
					r_MSplitKeepEmptyEntries_ReadOnlySpan_d_Int32_p__ReadOnlySpan_d_Int32_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_MSplitKeepEmptyEntries_ReadOnlySpan_d_Int32_p__ReadOnlySpan_d_Int32_p__Int32_Int32;
			}
		}

		/// <summary>
		/// System.String[] SplitOmitEmptyEntries(System.ReadOnlySpan`1[System.Int32], System.ReadOnlySpan`1[System.Int32], Int32, Int32)
		/// </summary>
		protected RMethod r_MSplitOmitEmptyEntries_ReadOnlySpan_d_Int32_p__ReadOnlySpan_d_Int32_p__Int32_Int32;
		public virtual RMethod RMSplitOmitEmptyEntries_ReadOnlySpan_d_Int32_p__ReadOnlySpan_d_Int32_p__Int32_Int32
		{
			get
			{
				if(r_MSplitOmitEmptyEntries_ReadOnlySpan_d_Int32_p__ReadOnlySpan_d_Int32_p__Int32_Int32 == null)
				{
					r_MSplitOmitEmptyEntries_ReadOnlySpan_d_Int32_p__ReadOnlySpan_d_Int32_p__Int32_Int32 = new(this, "SplitOmitEmptyEntries", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Int32)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Int32)), typeof(System.Int32), typeof(System.Int32));
					r_MSplitOmitEmptyEntries_ReadOnlySpan_d_Int32_p__ReadOnlySpan_d_Int32_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_MSplitOmitEmptyEntries_ReadOnlySpan_d_Int32_p__ReadOnlySpan_d_Int32_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void MakeSeparatorList(System.ReadOnlySpan`1[System.Char], System.Collections.Generic.ValueListBuilder`1[System.Int32] ByRef)
		/// </summary>
		protected RMethod r_MMakeSeparatorList_ReadOnlySpan_d_Char_p__Ref_ValueListBuilder_d_Int32_p_;
		public virtual RMethod RMMakeSeparatorList_ReadOnlySpan_d_Char_p__Ref_ValueListBuilder_d_Int32_p_
		{
			get
			{
				if(r_MMakeSeparatorList_ReadOnlySpan_d_Char_p__Ref_ValueListBuilder_d_Int32_p_ == null)
				{
					r_MMakeSeparatorList_ReadOnlySpan_d_Char_p__Ref_ValueListBuilder_d_Int32_p_ = new(this, "MakeSeparatorList", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)),  ReflectionUtils.GetType("System.Collections.Generic.ValueListBuilder`1").MakeGenericType(typeof(System.Int32)).MakeByRefType());
					r_MMakeSeparatorList_ReadOnlySpan_d_Char_p__Ref_ValueListBuilder_d_Int32_p_.SetBelong(this.instance);
				}
				return r_MMakeSeparatorList_ReadOnlySpan_d_Char_p__Ref_ValueListBuilder_d_Int32_p_;
			}
		}

		/// <summary>
		/// Void MakeSeparatorList(System.String, System.Collections.Generic.ValueListBuilder`1[System.Int32] ByRef)
		/// </summary>
		protected RMethod r_MMakeSeparatorList_String_Ref_ValueListBuilder_d_Int32_p_;
		public virtual RMethod RMMakeSeparatorList_String_Ref_ValueListBuilder_d_Int32_p_
		{
			get
			{
				if(r_MMakeSeparatorList_String_Ref_ValueListBuilder_d_Int32_p_ == null)
				{
					r_MMakeSeparatorList_String_Ref_ValueListBuilder_d_Int32_p_ = new(this, "MakeSeparatorList", 0, typeof(System.String),  ReflectionUtils.GetType("System.Collections.Generic.ValueListBuilder`1").MakeGenericType(typeof(System.Int32)).MakeByRefType());
					r_MMakeSeparatorList_String_Ref_ValueListBuilder_d_Int32_p_.SetBelong(this.instance);
				}
				return r_MMakeSeparatorList_String_Ref_ValueListBuilder_d_Int32_p_;
			}
		}

		/// <summary>
		/// Void MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1[System.Int32] ByRef, System.Collections.Generic.ValueListBuilder`1[System.Int32] ByRef)
		/// </summary>
		protected RMethod r_MMakeSeparatorList_StringArray_Ref_ValueListBuilder_d_Int32_p__Ref_ValueListBuilder_d_Int32_p_;
		public virtual RMethod RMMakeSeparatorList_StringArray_Ref_ValueListBuilder_d_Int32_p__Ref_ValueListBuilder_d_Int32_p_
		{
			get
			{
				if(r_MMakeSeparatorList_StringArray_Ref_ValueListBuilder_d_Int32_p__Ref_ValueListBuilder_d_Int32_p_ == null)
				{
					r_MMakeSeparatorList_StringArray_Ref_ValueListBuilder_d_Int32_p__Ref_ValueListBuilder_d_Int32_p_ = new(this, "MakeSeparatorList", 0, typeof(System.String).MakeArrayType(),  ReflectionUtils.GetType("System.Collections.Generic.ValueListBuilder`1").MakeGenericType(typeof(System.Int32)).MakeByRefType(),  ReflectionUtils.GetType("System.Collections.Generic.ValueListBuilder`1").MakeGenericType(typeof(System.Int32)).MakeByRefType());
					r_MMakeSeparatorList_StringArray_Ref_ValueListBuilder_d_Int32_p__Ref_ValueListBuilder_d_Int32_p_.SetBelong(this.instance);
				}
				return r_MMakeSeparatorList_StringArray_Ref_ValueListBuilder_d_Int32_p__Ref_ValueListBuilder_d_Int32_p_;
			}
		}

		/// <summary>
		/// System.String Substring(Int32)
		/// </summary>
		protected RMethod r_MSubstring_Int32;
		public virtual RMethod RMSubstring_Int32
		{
			get
			{
				if(r_MSubstring_Int32 == null)
				{
					r_MSubstring_Int32 = new(this, "Substring", 0, typeof(System.Int32));
					r_MSubstring_Int32.SetBelong(this.instance);
				}
				return r_MSubstring_Int32;
			}
		}

		/// <summary>
		/// System.String Substring(Int32, Int32)
		/// </summary>
		protected RMethod r_MSubstring_Int32_Int32;
		public virtual RMethod RMSubstring_Int32_Int32
		{
			get
			{
				if(r_MSubstring_Int32_Int32 == null)
				{
					r_MSubstring_Int32_Int32 = new(this, "Substring", 0, typeof(System.Int32), typeof(System.Int32));
					r_MSubstring_Int32_Int32.SetBelong(this.instance);
				}
				return r_MSubstring_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String InternalSubString(Int32, Int32)
		/// </summary>
		protected RMethod r_MInternalSubString_Int32_Int32;
		public virtual RMethod RMInternalSubString_Int32_Int32
		{
			get
			{
				if(r_MInternalSubString_Int32_Int32 == null)
				{
					r_MInternalSubString_Int32_Int32 = new(this, "InternalSubString", 0, typeof(System.Int32), typeof(System.Int32));
					r_MInternalSubString_Int32_Int32.SetBelong(this.instance);
				}
				return r_MInternalSubString_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String ToLower()
		/// </summary>
		protected RMethod r_MToLower;
		public virtual RMethod RMToLower
		{
			get
			{
				if(r_MToLower == null)
				{
					r_MToLower = new(this, "ToLower", 0);
					r_MToLower.SetBelong(this.instance);
				}
				return r_MToLower;
			}
		}

		/// <summary>
		/// System.String ToLower(System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_MToLower_CultureInfo;
		public virtual RMethod RMToLower_CultureInfo
		{
			get
			{
				if(r_MToLower_CultureInfo == null)
				{
					r_MToLower_CultureInfo = new(this, "ToLower", 0, typeof(System.Globalization.CultureInfo));
					r_MToLower_CultureInfo.SetBelong(this.instance);
				}
				return r_MToLower_CultureInfo;
			}
		}

		/// <summary>
		/// System.String ToLowerInvariant()
		/// </summary>
		protected RMethod r_MToLowerInvariant;
		public virtual RMethod RMToLowerInvariant
		{
			get
			{
				if(r_MToLowerInvariant == null)
				{
					r_MToLowerInvariant = new(this, "ToLowerInvariant", 0);
					r_MToLowerInvariant.SetBelong(this.instance);
				}
				return r_MToLowerInvariant;
			}
		}

		/// <summary>
		/// System.String ToUpper()
		/// </summary>
		protected RMethod r_MToUpper;
		public virtual RMethod RMToUpper
		{
			get
			{
				if(r_MToUpper == null)
				{
					r_MToUpper = new(this, "ToUpper", 0);
					r_MToUpper.SetBelong(this.instance);
				}
				return r_MToUpper;
			}
		}

		/// <summary>
		/// System.String ToUpper(System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_MToUpper_CultureInfo;
		public virtual RMethod RMToUpper_CultureInfo
		{
			get
			{
				if(r_MToUpper_CultureInfo == null)
				{
					r_MToUpper_CultureInfo = new(this, "ToUpper", 0, typeof(System.Globalization.CultureInfo));
					r_MToUpper_CultureInfo.SetBelong(this.instance);
				}
				return r_MToUpper_CultureInfo;
			}
		}

		/// <summary>
		/// System.String ToUpperInvariant()
		/// </summary>
		protected RMethod r_MToUpperInvariant;
		public virtual RMethod RMToUpperInvariant
		{
			get
			{
				if(r_MToUpperInvariant == null)
				{
					r_MToUpperInvariant = new(this, "ToUpperInvariant", 0);
					r_MToUpperInvariant.SetBelong(this.instance);
				}
				return r_MToUpperInvariant;
			}
		}

		/// <summary>
		/// System.String Trim()
		/// </summary>
		protected RMethod r_MTrim;
		public virtual RMethod RMTrim
		{
			get
			{
				if(r_MTrim == null)
				{
					r_MTrim = new(this, "Trim", 0);
					r_MTrim.SetBelong(this.instance);
				}
				return r_MTrim;
			}
		}

		/// <summary>
		/// System.String Trim(Char)
		/// </summary>
		protected RMethod r_MTrim_Char;
		public virtual RMethod RMTrim_Char
		{
			get
			{
				if(r_MTrim_Char == null)
				{
					r_MTrim_Char = new(this, "Trim", 0, typeof(System.Char));
					r_MTrim_Char.SetBelong(this.instance);
				}
				return r_MTrim_Char;
			}
		}

		/// <summary>
		/// System.String Trim(Char[])
		/// </summary>
		protected RMethod r_MTrim_CharArray;
		public virtual RMethod RMTrim_CharArray
		{
			get
			{
				if(r_MTrim_CharArray == null)
				{
					r_MTrim_CharArray = new(this, "Trim", 0, typeof(System.Char).MakeArrayType());
					r_MTrim_CharArray.SetBelong(this.instance);
				}
				return r_MTrim_CharArray;
			}
		}

		/// <summary>
		/// System.String TrimStart()
		/// </summary>
		protected RMethod r_MTrimStart;
		public virtual RMethod RMTrimStart
		{
			get
			{
				if(r_MTrimStart == null)
				{
					r_MTrimStart = new(this, "TrimStart", 0);
					r_MTrimStart.SetBelong(this.instance);
				}
				return r_MTrimStart;
			}
		}

		/// <summary>
		/// System.String TrimStart(Char)
		/// </summary>
		protected RMethod r_MTrimStart_Char;
		public virtual RMethod RMTrimStart_Char
		{
			get
			{
				if(r_MTrimStart_Char == null)
				{
					r_MTrimStart_Char = new(this, "TrimStart", 0, typeof(System.Char));
					r_MTrimStart_Char.SetBelong(this.instance);
				}
				return r_MTrimStart_Char;
			}
		}

		/// <summary>
		/// System.String TrimStart(Char[])
		/// </summary>
		protected RMethod r_MTrimStart_CharArray;
		public virtual RMethod RMTrimStart_CharArray
		{
			get
			{
				if(r_MTrimStart_CharArray == null)
				{
					r_MTrimStart_CharArray = new(this, "TrimStart", 0, typeof(System.Char).MakeArrayType());
					r_MTrimStart_CharArray.SetBelong(this.instance);
				}
				return r_MTrimStart_CharArray;
			}
		}

		/// <summary>
		/// System.String TrimEnd()
		/// </summary>
		protected RMethod r_MTrimEnd;
		public virtual RMethod RMTrimEnd
		{
			get
			{
				if(r_MTrimEnd == null)
				{
					r_MTrimEnd = new(this, "TrimEnd", 0);
					r_MTrimEnd.SetBelong(this.instance);
				}
				return r_MTrimEnd;
			}
		}

		/// <summary>
		/// System.String TrimEnd(Char)
		/// </summary>
		protected RMethod r_MTrimEnd_Char;
		public virtual RMethod RMTrimEnd_Char
		{
			get
			{
				if(r_MTrimEnd_Char == null)
				{
					r_MTrimEnd_Char = new(this, "TrimEnd", 0, typeof(System.Char));
					r_MTrimEnd_Char.SetBelong(this.instance);
				}
				return r_MTrimEnd_Char;
			}
		}

		/// <summary>
		/// System.String TrimEnd(Char[])
		/// </summary>
		protected RMethod r_MTrimEnd_CharArray;
		public virtual RMethod RMTrimEnd_CharArray
		{
			get
			{
				if(r_MTrimEnd_CharArray == null)
				{
					r_MTrimEnd_CharArray = new(this, "TrimEnd", 0, typeof(System.Char).MakeArrayType());
					r_MTrimEnd_CharArray.SetBelong(this.instance);
				}
				return r_MTrimEnd_CharArray;
			}
		}

		/// <summary>
		/// System.String TrimWhiteSpaceHelper(TrimType)
		/// </summary>
		protected RMethod r_MTrimWhiteSpaceHelper_TrimType;
		public virtual RMethod RMTrimWhiteSpaceHelper_TrimType
		{
			get
			{
				if(r_MTrimWhiteSpaceHelper_TrimType == null)
				{
					r_MTrimWhiteSpaceHelper_TrimType = new(this, "TrimWhiteSpaceHelper", 0,  ReflectionUtils.GetType("System.String+TrimType"));
					r_MTrimWhiteSpaceHelper_TrimType.SetBelong(this.instance);
				}
				return r_MTrimWhiteSpaceHelper_TrimType;
			}
		}

		/// <summary>
		/// System.String TrimHelper(Char*, Int32, TrimType)
		/// </summary>
		protected RMethod r_MTrimHelper_CharPointer_Int32_TrimType;
		public virtual RMethod RMTrimHelper_CharPointer_Int32_TrimType
		{
			get
			{
				if(r_MTrimHelper_CharPointer_Int32_TrimType == null)
				{
					r_MTrimHelper_CharPointer_Int32_TrimType = new(this, "TrimHelper", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32),  ReflectionUtils.GetType("System.String+TrimType"));
					r_MTrimHelper_CharPointer_Int32_TrimType.SetBelong(this.instance);
				}
				return r_MTrimHelper_CharPointer_Int32_TrimType;
			}
		}

		/// <summary>
		/// System.String CreateTrimmedString(Int32, Int32)
		/// </summary>
		protected RMethod r_MCreateTrimmedString_Int32_Int32;
		public virtual RMethod RMCreateTrimmedString_Int32_Int32
		{
			get
			{
				if(r_MCreateTrimmedString_Int32_Int32 == null)
				{
					r_MCreateTrimmedString_Int32_Int32 = new(this, "CreateTrimmedString", 0, typeof(System.Int32), typeof(System.Int32));
					r_MCreateTrimmedString_Int32_Int32.SetBelong(this.instance);
				}
				return r_MCreateTrimmedString_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean Contains(System.String)
		/// </summary>
		protected RMethod r_MContains_String;
		public virtual RMethod RMContains_String
		{
			get
			{
				if(r_MContains_String == null)
				{
					r_MContains_String = new(this, "Contains", 0, typeof(System.String));
					r_MContains_String.SetBelong(this.instance);
				}
				return r_MContains_String;
			}
		}

		/// <summary>
		/// Boolean Contains(System.String, System.StringComparison)
		/// </summary>
		protected RMethod r_MContains_String_StringComparison;
		public virtual RMethod RMContains_String_StringComparison
		{
			get
			{
				if(r_MContains_String_StringComparison == null)
				{
					r_MContains_String_StringComparison = new(this, "Contains", 0, typeof(System.String), typeof(System.StringComparison));
					r_MContains_String_StringComparison.SetBelong(this.instance);
				}
				return r_MContains_String_StringComparison;
			}
		}

		/// <summary>
		/// Boolean Contains(Char)
		/// </summary>
		protected RMethod r_MContains_Char;
		public virtual RMethod RMContains_Char
		{
			get
			{
				if(r_MContains_Char == null)
				{
					r_MContains_Char = new(this, "Contains", 0, typeof(System.Char));
					r_MContains_Char.SetBelong(this.instance);
				}
				return r_MContains_Char;
			}
		}

		/// <summary>
		/// Boolean Contains(Char, System.StringComparison)
		/// </summary>
		protected RMethod r_MContains_Char_StringComparison;
		public virtual RMethod RMContains_Char_StringComparison
		{
			get
			{
				if(r_MContains_Char_StringComparison == null)
				{
					r_MContains_Char_StringComparison = new(this, "Contains", 0, typeof(System.Char), typeof(System.StringComparison));
					r_MContains_Char_StringComparison.SetBelong(this.instance);
				}
				return r_MContains_Char_StringComparison;
			}
		}

		/// <summary>
		/// Int32 IndexOf(Char)
		/// </summary>
		protected RMethod r_MIndexOf_Char;
		public virtual RMethod RMIndexOf_Char
		{
			get
			{
				if(r_MIndexOf_Char == null)
				{
					r_MIndexOf_Char = new(this, "IndexOf", 0, typeof(System.Char));
					r_MIndexOf_Char.SetBelong(this.instance);
				}
				return r_MIndexOf_Char;
			}
		}

		/// <summary>
		/// Int32 IndexOf(Char, Int32)
		/// </summary>
		protected RMethod r_MIndexOf_Char_Int32;
		public virtual RMethod RMIndexOf_Char_Int32
		{
			get
			{
				if(r_MIndexOf_Char_Int32 == null)
				{
					r_MIndexOf_Char_Int32 = new(this, "IndexOf", 0, typeof(System.Char), typeof(System.Int32));
					r_MIndexOf_Char_Int32.SetBelong(this.instance);
				}
				return r_MIndexOf_Char_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(Char, System.StringComparison)
		/// </summary>
		protected RMethod r_MIndexOf_Char_StringComparison;
		public virtual RMethod RMIndexOf_Char_StringComparison
		{
			get
			{
				if(r_MIndexOf_Char_StringComparison == null)
				{
					r_MIndexOf_Char_StringComparison = new(this, "IndexOf", 0, typeof(System.Char), typeof(System.StringComparison));
					r_MIndexOf_Char_StringComparison.SetBelong(this.instance);
				}
				return r_MIndexOf_Char_StringComparison;
			}
		}

		/// <summary>
		/// Int32 IndexOf(Char, Int32, Int32)
		/// </summary>
		protected RMethod r_MIndexOf_Char_Int32_Int32;
		public virtual RMethod RMIndexOf_Char_Int32_Int32
		{
			get
			{
				if(r_MIndexOf_Char_Int32_Int32 == null)
				{
					r_MIndexOf_Char_Int32_Int32 = new(this, "IndexOf", 0, typeof(System.Char), typeof(System.Int32), typeof(System.Int32));
					r_MIndexOf_Char_Int32_Int32.SetBelong(this.instance);
				}
				return r_MIndexOf_Char_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOfAny(Char[])
		/// </summary>
		protected RMethod r_MIndexOfAny_CharArray;
		public virtual RMethod RMIndexOfAny_CharArray
		{
			get
			{
				if(r_MIndexOfAny_CharArray == null)
				{
					r_MIndexOfAny_CharArray = new(this, "IndexOfAny", 0, typeof(System.Char).MakeArrayType());
					r_MIndexOfAny_CharArray.SetBelong(this.instance);
				}
				return r_MIndexOfAny_CharArray;
			}
		}

		/// <summary>
		/// Int32 IndexOfAny(Char[], Int32)
		/// </summary>
		protected RMethod r_MIndexOfAny_CharArray_Int32;
		public virtual RMethod RMIndexOfAny_CharArray_Int32
		{
			get
			{
				if(r_MIndexOfAny_CharArray_Int32 == null)
				{
					r_MIndexOfAny_CharArray_Int32 = new(this, "IndexOfAny", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32));
					r_MIndexOfAny_CharArray_Int32.SetBelong(this.instance);
				}
				return r_MIndexOfAny_CharArray_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOfAny(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_MIndexOfAny_CharArray_Int32_Int32;
		public virtual RMethod RMIndexOfAny_CharArray_Int32_Int32
		{
			get
			{
				if(r_MIndexOfAny_CharArray_Int32_Int32 == null)
				{
					r_MIndexOfAny_CharArray_Int32_Int32 = new(this, "IndexOfAny", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MIndexOfAny_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_MIndexOfAny_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOfAny(Char, Char, Int32, Int32)
		/// </summary>
		protected RMethod r_MIndexOfAny_Char_Char_Int32_Int32;
		public virtual RMethod RMIndexOfAny_Char_Char_Int32_Int32
		{
			get
			{
				if(r_MIndexOfAny_Char_Char_Int32_Int32 == null)
				{
					r_MIndexOfAny_Char_Char_Int32_Int32 = new(this, "IndexOfAny", 0, typeof(System.Char), typeof(System.Char), typeof(System.Int32), typeof(System.Int32));
					r_MIndexOfAny_Char_Char_Int32_Int32.SetBelong(this.instance);
				}
				return r_MIndexOfAny_Char_Char_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOfAny(Char, Char, Char, Int32, Int32)
		/// </summary>
		protected RMethod r_MIndexOfAny_Char_Char_Char_Int32_Int32;
		public virtual RMethod RMIndexOfAny_Char_Char_Char_Int32_Int32
		{
			get
			{
				if(r_MIndexOfAny_Char_Char_Char_Int32_Int32 == null)
				{
					r_MIndexOfAny_Char_Char_Char_Int32_Int32 = new(this, "IndexOfAny", 0, typeof(System.Char), typeof(System.Char), typeof(System.Char), typeof(System.Int32), typeof(System.Int32));
					r_MIndexOfAny_Char_Char_Char_Int32_Int32.SetBelong(this.instance);
				}
				return r_MIndexOfAny_Char_Char_Char_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOfCharArray(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_MIndexOfCharArray_CharArray_Int32_Int32;
		public virtual RMethod RMIndexOfCharArray_CharArray_Int32_Int32
		{
			get
			{
				if(r_MIndexOfCharArray_CharArray_Int32_Int32 == null)
				{
					r_MIndexOfCharArray_CharArray_Int32_Int32 = new(this, "IndexOfCharArray", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MIndexOfCharArray_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_MIndexOfCharArray_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void InitializeProbabilisticMap(UInt32*, System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected static RMethod r_MInitializeProbabilisticMap_UInt32Pointer_ReadOnlySpan_d_Char_p_;
		public static RMethod RMInitializeProbabilisticMap_UInt32Pointer_ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_MInitializeProbabilisticMap_UInt32Pointer_ReadOnlySpan_d_Char_p_ == null)
				{
					r_MInitializeProbabilisticMap_UInt32Pointer_ReadOnlySpan_d_Char_p_ = new(typeof(System.String), "InitializeProbabilisticMap", 0, typeof(System.UInt32).MakePointerType(), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_MInitializeProbabilisticMap_UInt32Pointer_ReadOnlySpan_d_Char_p_.SetBelong(null);
				}
				return r_MInitializeProbabilisticMap_UInt32Pointer_ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// Boolean ArrayContains(Char, Char[])
		/// </summary>
		protected static RMethod r_MArrayContains_Char_CharArray;
		public static RMethod RMArrayContains_Char_CharArray
		{
			get
			{
				if(r_MArrayContains_Char_CharArray == null)
				{
					r_MArrayContains_Char_CharArray = new(typeof(System.String), "ArrayContains", 0, typeof(System.Char), typeof(System.Char).MakeArrayType());
					r_MArrayContains_Char_CharArray.SetBelong(null);
				}
				return r_MArrayContains_Char_CharArray;
			}
		}

		/// <summary>
		/// Boolean IsCharBitSet(UInt32*, Byte)
		/// </summary>
		protected static RMethod r_MIsCharBitSet_UInt32Pointer_Byte;
		public static RMethod RMIsCharBitSet_UInt32Pointer_Byte
		{
			get
			{
				if(r_MIsCharBitSet_UInt32Pointer_Byte == null)
				{
					r_MIsCharBitSet_UInt32Pointer_Byte = new(typeof(System.String), "IsCharBitSet", 0, typeof(System.UInt32).MakePointerType(), typeof(System.Byte));
					r_MIsCharBitSet_UInt32Pointer_Byte.SetBelong(null);
				}
				return r_MIsCharBitSet_UInt32Pointer_Byte;
			}
		}

		/// <summary>
		/// Void SetCharBit(UInt32*, Byte)
		/// </summary>
		protected static RMethod r_MSetCharBit_UInt32Pointer_Byte;
		public static RMethod RMSetCharBit_UInt32Pointer_Byte
		{
			get
			{
				if(r_MSetCharBit_UInt32Pointer_Byte == null)
				{
					r_MSetCharBit_UInt32Pointer_Byte = new(typeof(System.String), "SetCharBit", 0, typeof(System.UInt32).MakePointerType(), typeof(System.Byte));
					r_MSetCharBit_UInt32Pointer_Byte.SetBelong(null);
				}
				return r_MSetCharBit_UInt32Pointer_Byte;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String)
		/// </summary>
		protected RMethod r_MIndexOf_String;
		public virtual RMethod RMIndexOf_String
		{
			get
			{
				if(r_MIndexOf_String == null)
				{
					r_MIndexOf_String = new(this, "IndexOf", 0, typeof(System.String));
					r_MIndexOf_String.SetBelong(this.instance);
				}
				return r_MIndexOf_String;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, Int32)
		/// </summary>
		protected RMethod r_MIndexOf_String_Int32;
		public virtual RMethod RMIndexOf_String_Int32
		{
			get
			{
				if(r_MIndexOf_String_Int32 == null)
				{
					r_MIndexOf_String_Int32 = new(this, "IndexOf", 0, typeof(System.String), typeof(System.Int32));
					r_MIndexOf_String_Int32.SetBelong(this.instance);
				}
				return r_MIndexOf_String_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_MIndexOf_String_Int32_Int32;
		public virtual RMethod RMIndexOf_String_Int32_Int32
		{
			get
			{
				if(r_MIndexOf_String_Int32_Int32 == null)
				{
					r_MIndexOf_String_Int32_Int32 = new(this, "IndexOf", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_MIndexOf_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_MIndexOf_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, System.StringComparison)
		/// </summary>
		protected RMethod r_MIndexOf_String_StringComparison;
		public virtual RMethod RMIndexOf_String_StringComparison
		{
			get
			{
				if(r_MIndexOf_String_StringComparison == null)
				{
					r_MIndexOf_String_StringComparison = new(this, "IndexOf", 0, typeof(System.String), typeof(System.StringComparison));
					r_MIndexOf_String_StringComparison.SetBelong(this.instance);
				}
				return r_MIndexOf_String_StringComparison;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, Int32, System.StringComparison)
		/// </summary>
		protected RMethod r_MIndexOf_String_Int32_StringComparison;
		public virtual RMethod RMIndexOf_String_Int32_StringComparison
		{
			get
			{
				if(r_MIndexOf_String_Int32_StringComparison == null)
				{
					r_MIndexOf_String_Int32_StringComparison = new(this, "IndexOf", 0, typeof(System.String), typeof(System.Int32), typeof(System.StringComparison));
					r_MIndexOf_String_Int32_StringComparison.SetBelong(this.instance);
				}
				return r_MIndexOf_String_Int32_StringComparison;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, Int32, Int32, System.StringComparison)
		/// </summary>
		protected RMethod r_MIndexOf_String_Int32_Int32_StringComparison;
		public virtual RMethod RMIndexOf_String_Int32_Int32_StringComparison
		{
			get
			{
				if(r_MIndexOf_String_Int32_Int32_StringComparison == null)
				{
					r_MIndexOf_String_Int32_Int32_StringComparison = new(this, "IndexOf", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.StringComparison));
					r_MIndexOf_String_Int32_Int32_StringComparison.SetBelong(this.instance);
				}
				return r_MIndexOf_String_Int32_Int32_StringComparison;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(Char)
		/// </summary>
		protected RMethod r_MLastIndexOf_Char;
		public virtual RMethod RMLastIndexOf_Char
		{
			get
			{
				if(r_MLastIndexOf_Char == null)
				{
					r_MLastIndexOf_Char = new(this, "LastIndexOf", 0, typeof(System.Char));
					r_MLastIndexOf_Char.SetBelong(this.instance);
				}
				return r_MLastIndexOf_Char;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(Char, Int32)
		/// </summary>
		protected RMethod r_MLastIndexOf_Char_Int32;
		public virtual RMethod RMLastIndexOf_Char_Int32
		{
			get
			{
				if(r_MLastIndexOf_Char_Int32 == null)
				{
					r_MLastIndexOf_Char_Int32 = new(this, "LastIndexOf", 0, typeof(System.Char), typeof(System.Int32));
					r_MLastIndexOf_Char_Int32.SetBelong(this.instance);
				}
				return r_MLastIndexOf_Char_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(Char, Int32, Int32)
		/// </summary>
		protected RMethod r_MLastIndexOf_Char_Int32_Int32;
		public virtual RMethod RMLastIndexOf_Char_Int32_Int32
		{
			get
			{
				if(r_MLastIndexOf_Char_Int32_Int32 == null)
				{
					r_MLastIndexOf_Char_Int32_Int32 = new(this, "LastIndexOf", 0, typeof(System.Char), typeof(System.Int32), typeof(System.Int32));
					r_MLastIndexOf_Char_Int32_Int32.SetBelong(this.instance);
				}
				return r_MLastIndexOf_Char_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOfAny(Char[])
		/// </summary>
		protected RMethod r_MLastIndexOfAny_CharArray;
		public virtual RMethod RMLastIndexOfAny_CharArray
		{
			get
			{
				if(r_MLastIndexOfAny_CharArray == null)
				{
					r_MLastIndexOfAny_CharArray = new(this, "LastIndexOfAny", 0, typeof(System.Char).MakeArrayType());
					r_MLastIndexOfAny_CharArray.SetBelong(this.instance);
				}
				return r_MLastIndexOfAny_CharArray;
			}
		}

		/// <summary>
		/// Int32 LastIndexOfAny(Char[], Int32)
		/// </summary>
		protected RMethod r_MLastIndexOfAny_CharArray_Int32;
		public virtual RMethod RMLastIndexOfAny_CharArray_Int32
		{
			get
			{
				if(r_MLastIndexOfAny_CharArray_Int32 == null)
				{
					r_MLastIndexOfAny_CharArray_Int32 = new(this, "LastIndexOfAny", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32));
					r_MLastIndexOfAny_CharArray_Int32.SetBelong(this.instance);
				}
				return r_MLastIndexOfAny_CharArray_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOfAny(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_MLastIndexOfAny_CharArray_Int32_Int32;
		public virtual RMethod RMLastIndexOfAny_CharArray_Int32_Int32
		{
			get
			{
				if(r_MLastIndexOfAny_CharArray_Int32_Int32 == null)
				{
					r_MLastIndexOfAny_CharArray_Int32_Int32 = new(this, "LastIndexOfAny", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MLastIndexOfAny_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_MLastIndexOfAny_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOfCharArray(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_MLastIndexOfCharArray_CharArray_Int32_Int32;
		public virtual RMethod RMLastIndexOfCharArray_CharArray_Int32_Int32
		{
			get
			{
				if(r_MLastIndexOfCharArray_CharArray_Int32_Int32 == null)
				{
					r_MLastIndexOfCharArray_CharArray_Int32_Int32 = new(this, "LastIndexOfCharArray", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MLastIndexOfCharArray_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_MLastIndexOfCharArray_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String)
		/// </summary>
		protected RMethod r_MLastIndexOf_String;
		public virtual RMethod RMLastIndexOf_String
		{
			get
			{
				if(r_MLastIndexOf_String == null)
				{
					r_MLastIndexOf_String = new(this, "LastIndexOf", 0, typeof(System.String));
					r_MLastIndexOf_String.SetBelong(this.instance);
				}
				return r_MLastIndexOf_String;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, Int32)
		/// </summary>
		protected RMethod r_MLastIndexOf_String_Int32;
		public virtual RMethod RMLastIndexOf_String_Int32
		{
			get
			{
				if(r_MLastIndexOf_String_Int32 == null)
				{
					r_MLastIndexOf_String_Int32 = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.Int32));
					r_MLastIndexOf_String_Int32.SetBelong(this.instance);
				}
				return r_MLastIndexOf_String_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_MLastIndexOf_String_Int32_Int32;
		public virtual RMethod RMLastIndexOf_String_Int32_Int32
		{
			get
			{
				if(r_MLastIndexOf_String_Int32_Int32 == null)
				{
					r_MLastIndexOf_String_Int32_Int32 = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_MLastIndexOf_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_MLastIndexOf_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, System.StringComparison)
		/// </summary>
		protected RMethod r_MLastIndexOf_String_StringComparison;
		public virtual RMethod RMLastIndexOf_String_StringComparison
		{
			get
			{
				if(r_MLastIndexOf_String_StringComparison == null)
				{
					r_MLastIndexOf_String_StringComparison = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.StringComparison));
					r_MLastIndexOf_String_StringComparison.SetBelong(this.instance);
				}
				return r_MLastIndexOf_String_StringComparison;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, Int32, System.StringComparison)
		/// </summary>
		protected RMethod r_MLastIndexOf_String_Int32_StringComparison;
		public virtual RMethod RMLastIndexOf_String_Int32_StringComparison
		{
			get
			{
				if(r_MLastIndexOf_String_Int32_StringComparison == null)
				{
					r_MLastIndexOf_String_Int32_StringComparison = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.Int32), typeof(System.StringComparison));
					r_MLastIndexOf_String_Int32_StringComparison.SetBelong(this.instance);
				}
				return r_MLastIndexOf_String_Int32_StringComparison;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, Int32, Int32, System.StringComparison)
		/// </summary>
		protected RMethod r_MLastIndexOf_String_Int32_Int32_StringComparison;
		public virtual RMethod RMLastIndexOf_String_Int32_Int32_StringComparison
		{
			get
			{
				if(r_MLastIndexOf_String_Int32_Int32_StringComparison == null)
				{
					r_MLastIndexOf_String_Int32_Int32_StringComparison = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.StringComparison));
					r_MLastIndexOf_String_Int32_Int32_StringComparison.SetBelong(this.instance);
				}
				return r_MLastIndexOf_String_Int32_Int32_StringComparison;
			}
		}

		/// <summary>
		/// System.String Ctor(Char[])
		/// </summary>
		protected static RMethod r_MCtor_CharArray;
		public static RMethod RMCtor_CharArray
		{
			get
			{
				if(r_MCtor_CharArray == null)
				{
					r_MCtor_CharArray = new(typeof(System.String), "Ctor", 0, typeof(System.Char).MakeArrayType());
					r_MCtor_CharArray.SetBelong(null);
				}
				return r_MCtor_CharArray;
			}
		}

		/// <summary>
		/// System.String Ctor(Char[], Int32, Int32)
		/// </summary>
		protected static RMethod r_MCtor_CharArray_Int32_Int32;
		public static RMethod RMCtor_CharArray_Int32_Int32
		{
			get
			{
				if(r_MCtor_CharArray_Int32_Int32 == null)
				{
					r_MCtor_CharArray_Int32_Int32 = new(typeof(System.String), "Ctor", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MCtor_CharArray_Int32_Int32.SetBelong(null);
				}
				return r_MCtor_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String Ctor(Char*)
		/// </summary>
		protected static RMethod r_MCtor_CharPointer;
		public static RMethod RMCtor_CharPointer
		{
			get
			{
				if(r_MCtor_CharPointer == null)
				{
					r_MCtor_CharPointer = new(typeof(System.String), "Ctor", 0, typeof(System.Char).MakePointerType());
					r_MCtor_CharPointer.SetBelong(null);
				}
				return r_MCtor_CharPointer;
			}
		}

		/// <summary>
		/// System.String Ctor(Char*, Int32, Int32)
		/// </summary>
		protected static RMethod r_MCtor_CharPointer_Int32_Int32;
		public static RMethod RMCtor_CharPointer_Int32_Int32
		{
			get
			{
				if(r_MCtor_CharPointer_Int32_Int32 == null)
				{
					r_MCtor_CharPointer_Int32_Int32 = new(typeof(System.String), "Ctor", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Int32));
					r_MCtor_CharPointer_Int32_Int32.SetBelong(null);
				}
				return r_MCtor_CharPointer_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String Ctor(SByte*)
		/// </summary>
		protected static RMethod r_MCtor_SBytePointer;
		public static RMethod RMCtor_SBytePointer
		{
			get
			{
				if(r_MCtor_SBytePointer == null)
				{
					r_MCtor_SBytePointer = new(typeof(System.String), "Ctor", 0, typeof(System.SByte).MakePointerType());
					r_MCtor_SBytePointer.SetBelong(null);
				}
				return r_MCtor_SBytePointer;
			}
		}

		/// <summary>
		/// System.String Ctor(SByte*, Int32, Int32)
		/// </summary>
		protected static RMethod r_MCtor_SBytePointer_Int32_Int32;
		public static RMethod RMCtor_SBytePointer_Int32_Int32
		{
			get
			{
				if(r_MCtor_SBytePointer_Int32_Int32 == null)
				{
					r_MCtor_SBytePointer_Int32_Int32 = new(typeof(System.String), "Ctor", 0, typeof(System.SByte).MakePointerType(), typeof(System.Int32), typeof(System.Int32));
					r_MCtor_SBytePointer_Int32_Int32.SetBelong(null);
				}
				return r_MCtor_SBytePointer_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String CreateStringForSByteConstructor(Byte*, Int32)
		/// </summary>
		protected static RMethod r_MCreateStringForSByteConstructor_BytePointer_Int32;
		public static RMethod RMCreateStringForSByteConstructor_BytePointer_Int32
		{
			get
			{
				if(r_MCreateStringForSByteConstructor_BytePointer_Int32 == null)
				{
					r_MCreateStringForSByteConstructor_BytePointer_Int32 = new(typeof(System.String), "CreateStringForSByteConstructor", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_MCreateStringForSByteConstructor_BytePointer_Int32.SetBelong(null);
				}
				return r_MCreateStringForSByteConstructor_BytePointer_Int32;
			}
		}

		/// <summary>
		/// System.String Ctor(SByte*, Int32, Int32, System.Text.Encoding)
		/// </summary>
		protected static RMethod r_MCtor_SBytePointer_Int32_Int32_Encoding;
		public static RMethod RMCtor_SBytePointer_Int32_Int32_Encoding
		{
			get
			{
				if(r_MCtor_SBytePointer_Int32_Int32_Encoding == null)
				{
					r_MCtor_SBytePointer_Int32_Int32_Encoding = new(typeof(System.String), "Ctor", 0, typeof(System.SByte).MakePointerType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Text.Encoding));
					r_MCtor_SBytePointer_Int32_Int32_Encoding.SetBelong(null);
				}
				return r_MCtor_SBytePointer_Int32_Int32_Encoding;
			}
		}

		/// <summary>
		/// System.String Ctor(Char, Int32)
		/// </summary>
		protected static RMethod r_MCtor_Char_Int32;
		public static RMethod RMCtor_Char_Int32
		{
			get
			{
				if(r_MCtor_Char_Int32 == null)
				{
					r_MCtor_Char_Int32 = new(typeof(System.String), "Ctor", 0, typeof(System.Char), typeof(System.Int32));
					r_MCtor_Char_Int32.SetBelong(null);
				}
				return r_MCtor_Char_Int32;
			}
		}

		/// <summary>
		/// System.String Ctor(System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected static RMethod r_MCtor_ReadOnlySpan_d_Char_p_;
		public static RMethod RMCtor_ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_MCtor_ReadOnlySpan_d_Char_p_ == null)
				{
					r_MCtor_ReadOnlySpan_d_Char_p_ = new(typeof(System.String), "Ctor", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_MCtor_ReadOnlySpan_d_Char_p_.SetBelong(null);
				}
				return r_MCtor_ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// System.String Create[TState](Int32, TState, System.Buffers.SpanAction`2[System.Char,TState])
		/// </summary>
		protected static RMethod r_MCreate_GTState_Int32_TState_SpanAction_d_Char_TState_p_;
		public static RMethod RMCreate_GTState_Int32_TState_SpanAction_d_Char_TState_p_
		{
			get
			{
				if(r_MCreate_GTState_Int32_TState_SpanAction_d_Char_TState_p_ == null)
				{
					r_MCreate_GTState_Int32_TState_SpanAction_d_Char_TState_p_ = new(typeof(System.String), "Create", 1, typeof(System.Int32), Type.MakeGenericMethodParameter(0), typeof(System.Buffers.SpanAction<, >).MakeGenericType(typeof(System.Char), Type.MakeGenericMethodParameter(0)));
					r_MCreate_GTState_Int32_TState_SpanAction_d_Char_TState_p_.SetBelong(null);
				}
				return r_MCreate_GTState_Int32_TState_SpanAction_d_Char_TState_p_;
			}
		}

		/// <summary>
		/// System.ReadOnlySpan`1[System.Char] op_Implicit(System.String)
		/// </summary>
		protected static RMethod r_Mop_Implicit_String;
		public static RMethod RMop_Implicit_String
		{
			get
			{
				if(r_Mop_Implicit_String == null)
				{
					r_Mop_Implicit_String = new(typeof(System.String), "op_Implicit", 0, typeof(System.String));
					r_Mop_Implicit_String.SetBelong(null);
				}
				return r_Mop_Implicit_String;
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
		/// System.String Copy(System.String)
		/// </summary>
		protected static RMethod r_MCopy_String;
		public static RMethod RMCopy_String
		{
			get
			{
				if(r_MCopy_String == null)
				{
					r_MCopy_String = new(typeof(System.String), "Copy", 0, typeof(System.String));
					r_MCopy_String.SetBelong(null);
				}
				return r_MCopy_String;
			}
		}

		/// <summary>
		/// Void CopyTo(Int32, Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_MCopyTo_Int32_CharArray_Int32_Int32;
		public virtual RMethod RMCopyTo_Int32_CharArray_Int32_Int32
		{
			get
			{
				if(r_MCopyTo_Int32_CharArray_Int32_Int32 == null)
				{
					r_MCopyTo_Int32_CharArray_Int32_Int32 = new(this, "CopyTo", 0, typeof(System.Int32), typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MCopyTo_Int32_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_MCopyTo_Int32_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Char[] ToCharArray()
		/// </summary>
		protected RMethod r_MToCharArray;
		public virtual RMethod RMToCharArray
		{
			get
			{
				if(r_MToCharArray == null)
				{
					r_MToCharArray = new(this, "ToCharArray", 0);
					r_MToCharArray.SetBelong(this.instance);
				}
				return r_MToCharArray;
			}
		}

		/// <summary>
		/// Char[] ToCharArray(Int32, Int32)
		/// </summary>
		protected RMethod r_MToCharArray_Int32_Int32;
		public virtual RMethod RMToCharArray_Int32_Int32
		{
			get
			{
				if(r_MToCharArray_Int32_Int32 == null)
				{
					r_MToCharArray_Int32_Int32 = new(this, "ToCharArray", 0, typeof(System.Int32), typeof(System.Int32));
					r_MToCharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_MToCharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean IsNullOrEmpty(System.String)
		/// </summary>
		protected static RMethod r_MIsNullOrEmpty_String;
		public static RMethod RMIsNullOrEmpty_String
		{
			get
			{
				if(r_MIsNullOrEmpty_String == null)
				{
					r_MIsNullOrEmpty_String = new(typeof(System.String), "IsNullOrEmpty", 0, typeof(System.String));
					r_MIsNullOrEmpty_String.SetBelong(null);
				}
				return r_MIsNullOrEmpty_String;
			}
		}

		/// <summary>
		/// Boolean IsNullOrWhiteSpace(System.String)
		/// </summary>
		protected static RMethod r_MIsNullOrWhiteSpace_String;
		public static RMethod RMIsNullOrWhiteSpace_String
		{
			get
			{
				if(r_MIsNullOrWhiteSpace_String == null)
				{
					r_MIsNullOrWhiteSpace_String = new(typeof(System.String), "IsNullOrWhiteSpace", 0, typeof(System.String));
					r_MIsNullOrWhiteSpace_String.SetBelong(null);
				}
				return r_MIsNullOrWhiteSpace_String;
			}
		}

		/// <summary>
		/// Char& GetRawStringData()
		/// </summary>
		protected RMethod r_MGetRawStringData;
		public virtual RMethod RMGetRawStringData
		{
			get
			{
				if(r_MGetRawStringData == null)
				{
					r_MGetRawStringData = new(this, "GetRawStringData", 0);
					r_MGetRawStringData.SetBelong(this.instance);
				}
				return r_MGetRawStringData;
			}
		}

		/// <summary>
		/// System.String CreateStringFromEncoding(Byte*, Int32, System.Text.Encoding)
		/// </summary>
		protected static RMethod r_MCreateStringFromEncoding_BytePointer_Int32_Encoding;
		public static RMethod RMCreateStringFromEncoding_BytePointer_Int32_Encoding
		{
			get
			{
				if(r_MCreateStringFromEncoding_BytePointer_Int32_Encoding == null)
				{
					r_MCreateStringFromEncoding_BytePointer_Int32_Encoding = new(typeof(System.String), "CreateStringFromEncoding", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32), typeof(System.Text.Encoding));
					r_MCreateStringFromEncoding_BytePointer_Int32_Encoding.SetBelong(null);
				}
				return r_MCreateStringFromEncoding_BytePointer_Int32_Encoding;
			}
		}

		/// <summary>
		/// System.String CreateFromChar(Char)
		/// </summary>
		protected static RMethod r_MCreateFromChar_Char;
		public static RMethod RMCreateFromChar_Char
		{
			get
			{
				if(r_MCreateFromChar_Char == null)
				{
					r_MCreateFromChar_Char = new(typeof(System.String), "CreateFromChar", 0, typeof(System.Char));
					r_MCreateFromChar_Char.SetBelong(null);
				}
				return r_MCreateFromChar_Char;
			}
		}

		/// <summary>
		/// Void wstrcpy(Char*, Char*, Int32)
		/// </summary>
		protected static RMethod r_Mwstrcpy_CharPointer_CharPointer_Int32;
		public static RMethod RMwstrcpy_CharPointer_CharPointer_Int32
		{
			get
			{
				if(r_Mwstrcpy_CharPointer_CharPointer_Int32 == null)
				{
					r_Mwstrcpy_CharPointer_CharPointer_Int32 = new(typeof(System.String), "wstrcpy", 0, typeof(System.Char).MakePointerType(), typeof(System.Char).MakePointerType(), typeof(System.Int32));
					r_Mwstrcpy_CharPointer_CharPointer_Int32.SetBelong(null);
				}
				return r_Mwstrcpy_CharPointer_CharPointer_Int32;
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
		/// System.CharEnumerator GetEnumerator()
		/// </summary>
		protected RMethod r_MGetEnumerator;
		public virtual RMethod RMGetEnumerator
		{
			get
			{
				if(r_MGetEnumerator == null)
				{
					r_MGetEnumerator = new(this, "GetEnumerator", 0);
					r_MGetEnumerator.SetBelong(this.instance);
				}
				return r_MGetEnumerator;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerator`1[System.Char] System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator()
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Char__1____2__GetEnumerator;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Char__1____2__GetEnumerator
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Char__1____2__GetEnumerator == null)
				{
					r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Char__1____2__GetEnumerator = new(this, "System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator", 0);
					r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Char__1____2__GetEnumerator.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Char__1____2__GetEnumerator;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator;
		public virtual RMethod RMSystem__2__Collections__2__IEnumerable__2__GetEnumerator
		{
			get
			{
				if(r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator == null)
				{
					r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator = new(this, "System.Collections.IEnumerable.GetEnumerator", 0);
					r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator;
			}
		}

		/// <summary>
		/// Int32 wcslen(Char*)
		/// </summary>
		protected static RMethod r_Mwcslen_CharPointer;
		public static RMethod RMwcslen_CharPointer
		{
			get
			{
				if(r_Mwcslen_CharPointer == null)
				{
					r_Mwcslen_CharPointer = new(typeof(System.String), "wcslen", 0, typeof(System.Char).MakePointerType());
					r_Mwcslen_CharPointer.SetBelong(null);
				}
				return r_Mwcslen_CharPointer;
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
		/// Boolean IsNormalized()
		/// </summary>
		protected RMethod r_MIsNormalized;
		public virtual RMethod RMIsNormalized
		{
			get
			{
				if(r_MIsNormalized == null)
				{
					r_MIsNormalized = new(this, "IsNormalized", 0);
					r_MIsNormalized.SetBelong(this.instance);
				}
				return r_MIsNormalized;
			}
		}

		/// <summary>
		/// Boolean IsNormalized(System.Text.NormalizationForm)
		/// </summary>
		protected RMethod r_MIsNormalized_NormalizationForm;
		public virtual RMethod RMIsNormalized_NormalizationForm
		{
			get
			{
				if(r_MIsNormalized_NormalizationForm == null)
				{
					r_MIsNormalized_NormalizationForm = new(this, "IsNormalized", 0, typeof(System.Text.NormalizationForm));
					r_MIsNormalized_NormalizationForm.SetBelong(this.instance);
				}
				return r_MIsNormalized_NormalizationForm;
			}
		}

		/// <summary>
		/// System.String Normalize()
		/// </summary>
		protected RMethod r_MNormalize;
		public virtual RMethod RMNormalize
		{
			get
			{
				if(r_MNormalize == null)
				{
					r_MNormalize = new(this, "Normalize", 0);
					r_MNormalize.SetBelong(this.instance);
				}
				return r_MNormalize;
			}
		}

		/// <summary>
		/// System.String Normalize(System.Text.NormalizationForm)
		/// </summary>
		protected RMethod r_MNormalize_NormalizationForm;
		public virtual RMethod RMNormalize_NormalizationForm
		{
			get
			{
				if(r_MNormalize_NormalizationForm == null)
				{
					r_MNormalize_NormalizationForm = new(this, "Normalize", 0, typeof(System.Text.NormalizationForm));
					r_MNormalize_NormalizationForm.SetBelong(this.instance);
				}
				return r_MNormalize_NormalizationForm;
			}
		}

		/// <summary>
		/// Int32 IndexOfUnchecked(System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_MIndexOfUnchecked_String_Int32_Int32;
		public virtual RMethod RMIndexOfUnchecked_String_Int32_Int32
		{
			get
			{
				if(r_MIndexOfUnchecked_String_Int32_Int32 == null)
				{
					r_MIndexOfUnchecked_String_Int32_Int32 = new(this, "IndexOfUnchecked", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_MIndexOfUnchecked_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_MIndexOfUnchecked_String_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String Concat(System.Object, System.Object, System.Object, System.Object, ...)
		/// </summary>
		protected static RMethod r_MConcat_Object_Object_Object_Object;
		public static RMethod RMConcat_Object_Object_Object_Object
		{
			get
			{
				if(r_MConcat_Object_Object_Object_Object == null)
				{
					r_MConcat_Object_Object_Object_Object = new(typeof(System.String), "Concat", 0, typeof(System.Object), typeof(System.Object), typeof(System.Object), typeof(System.Object));
					r_MConcat_Object_Object_Object_Object.SetBelong(null);
				}
				return r_MConcat_Object_Object_Object_Object;
			}
		}

		/// <summary>
		/// Int32 IndexOfUncheckedIgnoreCase(System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_MIndexOfUncheckedIgnoreCase_String_Int32_Int32;
		public virtual RMethod RMIndexOfUncheckedIgnoreCase_String_Int32_Int32
		{
			get
			{
				if(r_MIndexOfUncheckedIgnoreCase_String_Int32_Int32 == null)
				{
					r_MIndexOfUncheckedIgnoreCase_String_Int32_Int32 = new(this, "IndexOfUncheckedIgnoreCase", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_MIndexOfUncheckedIgnoreCase_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_MIndexOfUncheckedIgnoreCase_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOfUnchecked(System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_MLastIndexOfUnchecked_String_Int32_Int32;
		public virtual RMethod RMLastIndexOfUnchecked_String_Int32_Int32
		{
			get
			{
				if(r_MLastIndexOfUnchecked_String_Int32_Int32 == null)
				{
					r_MLastIndexOfUnchecked_String_Int32_Int32 = new(this, "LastIndexOfUnchecked", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_MLastIndexOfUnchecked_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_MLastIndexOfUnchecked_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOfUncheckedIgnoreCase(System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_MLastIndexOfUncheckedIgnoreCase_String_Int32_Int32;
		public virtual RMethod RMLastIndexOfUncheckedIgnoreCase_String_Int32_Int32
		{
			get
			{
				if(r_MLastIndexOfUncheckedIgnoreCase_String_Int32_Int32 == null)
				{
					r_MLastIndexOfUncheckedIgnoreCase_String_Int32_Int32 = new(this, "LastIndexOfUncheckedIgnoreCase", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_MLastIndexOfUncheckedIgnoreCase_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_MLastIndexOfUncheckedIgnoreCase_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean StartsWithOrdinalUnchecked(System.String)
		/// </summary>
		protected RMethod r_MStartsWithOrdinalUnchecked_String;
		public virtual RMethod RMStartsWithOrdinalUnchecked_String
		{
			get
			{
				if(r_MStartsWithOrdinalUnchecked_String == null)
				{
					r_MStartsWithOrdinalUnchecked_String = new(this, "StartsWithOrdinalUnchecked", 0, typeof(System.String));
					r_MStartsWithOrdinalUnchecked_String.SetBelong(this.instance);
				}
				return r_MStartsWithOrdinalUnchecked_String;
			}
		}

		/// <summary>
		/// System.String FastAllocateString(Int32)
		/// </summary>
		protected static RMethod r_MFastAllocateString_Int32;
		public static RMethod RMFastAllocateString_Int32
		{
			get
			{
				if(r_MFastAllocateString_Int32 == null)
				{
					r_MFastAllocateString_Int32 = new(typeof(System.String), "FastAllocateString", 0, typeof(System.Int32));
					r_MFastAllocateString_Int32.SetBelong(null);
				}
				return r_MFastAllocateString_Int32;
			}
		}

		/// <summary>
		/// System.String InternalIsInterned(System.String)
		/// </summary>
		protected static RMethod r_MInternalIsInterned_String;
		public static RMethod RMInternalIsInterned_String
		{
			get
			{
				if(r_MInternalIsInterned_String == null)
				{
					r_MInternalIsInterned_String = new(typeof(System.String), "InternalIsInterned", 0, typeof(System.String));
					r_MInternalIsInterned_String.SetBelong(null);
				}
				return r_MInternalIsInterned_String;
			}
		}

		/// <summary>
		/// System.String InternalIntern(System.String)
		/// </summary>
		protected static RMethod r_MInternalIntern_String;
		public static RMethod RMInternalIntern_String
		{
			get
			{
				if(r_MInternalIntern_String == null)
				{
					r_MInternalIntern_String = new(typeof(System.String), "InternalIntern", 0, typeof(System.String));
					r_MInternalIntern_String.SetBelong(null);
				}
				return r_MInternalIntern_String;
			}
		}

		/// <summary>
		/// Int32 FastCompareStringHelper(UInt32*, Int32, UInt32*, Int32)
		/// </summary>
		protected static RMethod r_MFastCompareStringHelper_UInt32Pointer_Int32_UInt32Pointer_Int32;
		public static RMethod RMFastCompareStringHelper_UInt32Pointer_Int32_UInt32Pointer_Int32
		{
			get
			{
				if(r_MFastCompareStringHelper_UInt32Pointer_Int32_UInt32Pointer_Int32 == null)
				{
					r_MFastCompareStringHelper_UInt32Pointer_Int32_UInt32Pointer_Int32 = new(typeof(System.String), "FastCompareStringHelper", 0, typeof(System.UInt32).MakePointerType(), typeof(System.Int32), typeof(System.UInt32).MakePointerType(), typeof(System.Int32));
					r_MFastCompareStringHelper_UInt32Pointer_Int32_UInt32Pointer_Int32.SetBelong(null);
				}
				return r_MFastCompareStringHelper_UInt32Pointer_Int32_UInt32Pointer_Int32;
			}
		}

		/// <summary>
		/// Void memset(Byte*, Int32, Int32)
		/// </summary>
		protected static RMethod r_Mmemset_BytePointer_Int32_Int32;
		public static RMethod RMmemset_BytePointer_Int32_Int32
		{
			get
			{
				if(r_Mmemset_BytePointer_Int32_Int32 == null)
				{
					r_Mmemset_BytePointer_Int32_Int32 = new(typeof(System.String), "memset", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32), typeof(System.Int32));
					r_Mmemset_BytePointer_Int32_Int32.SetBelong(null);
				}
				return r_Mmemset_BytePointer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void memcpy(Byte*, Byte*, Int32)
		/// </summary>
		protected static RMethod r_Mmemcpy_BytePointer_BytePointer_Int32;
		public static RMethod RMmemcpy_BytePointer_BytePointer_Int32
		{
			get
			{
				if(r_Mmemcpy_BytePointer_BytePointer_Int32 == null)
				{
					r_Mmemcpy_BytePointer_BytePointer_Int32 = new(typeof(System.String), "memcpy", 0, typeof(System.Byte).MakePointerType(), typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_Mmemcpy_BytePointer_BytePointer_Int32.SetBelong(null);
				}
				return r_Mmemcpy_BytePointer_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Void bzero(Byte*, Int32)
		/// </summary>
		protected static RMethod r_Mbzero_BytePointer_Int32;
		public static RMethod RMbzero_BytePointer_Int32
		{
			get
			{
				if(r_Mbzero_BytePointer_Int32 == null)
				{
					r_Mbzero_BytePointer_Int32 = new(typeof(System.String), "bzero", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_Mbzero_BytePointer_Int32.SetBelong(null);
				}
				return r_Mbzero_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Void bzero_aligned_1(Byte*, Int32)
		/// </summary>
		protected static RMethod r_Mbzero_aligned_1_BytePointer_Int32;
		public static RMethod RMbzero_aligned_1_BytePointer_Int32
		{
			get
			{
				if(r_Mbzero_aligned_1_BytePointer_Int32 == null)
				{
					r_Mbzero_aligned_1_BytePointer_Int32 = new(typeof(System.String), "bzero_aligned_1", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_Mbzero_aligned_1_BytePointer_Int32.SetBelong(null);
				}
				return r_Mbzero_aligned_1_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Void bzero_aligned_2(Byte*, Int32)
		/// </summary>
		protected static RMethod r_Mbzero_aligned_2_BytePointer_Int32;
		public static RMethod RMbzero_aligned_2_BytePointer_Int32
		{
			get
			{
				if(r_Mbzero_aligned_2_BytePointer_Int32 == null)
				{
					r_Mbzero_aligned_2_BytePointer_Int32 = new(typeof(System.String), "bzero_aligned_2", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_Mbzero_aligned_2_BytePointer_Int32.SetBelong(null);
				}
				return r_Mbzero_aligned_2_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Void bzero_aligned_4(Byte*, Int32)
		/// </summary>
		protected static RMethod r_Mbzero_aligned_4_BytePointer_Int32;
		public static RMethod RMbzero_aligned_4_BytePointer_Int32
		{
			get
			{
				if(r_Mbzero_aligned_4_BytePointer_Int32 == null)
				{
					r_Mbzero_aligned_4_BytePointer_Int32 = new(typeof(System.String), "bzero_aligned_4", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_Mbzero_aligned_4_BytePointer_Int32.SetBelong(null);
				}
				return r_Mbzero_aligned_4_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Void bzero_aligned_8(Byte*, Int32)
		/// </summary>
		protected static RMethod r_Mbzero_aligned_8_BytePointer_Int32;
		public static RMethod RMbzero_aligned_8_BytePointer_Int32
		{
			get
			{
				if(r_Mbzero_aligned_8_BytePointer_Int32 == null)
				{
					r_Mbzero_aligned_8_BytePointer_Int32 = new(typeof(System.String), "bzero_aligned_8", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_Mbzero_aligned_8_BytePointer_Int32.SetBelong(null);
				}
				return r_Mbzero_aligned_8_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Void memcpy_aligned_1(Byte*, Byte*, Int32)
		/// </summary>
		protected static RMethod r_Mmemcpy_aligned_1_BytePointer_BytePointer_Int32;
		public static RMethod RMmemcpy_aligned_1_BytePointer_BytePointer_Int32
		{
			get
			{
				if(r_Mmemcpy_aligned_1_BytePointer_BytePointer_Int32 == null)
				{
					r_Mmemcpy_aligned_1_BytePointer_BytePointer_Int32 = new(typeof(System.String), "memcpy_aligned_1", 0, typeof(System.Byte).MakePointerType(), typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_Mmemcpy_aligned_1_BytePointer_BytePointer_Int32.SetBelong(null);
				}
				return r_Mmemcpy_aligned_1_BytePointer_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Void memcpy_aligned_2(Byte*, Byte*, Int32)
		/// </summary>
		protected static RMethod r_Mmemcpy_aligned_2_BytePointer_BytePointer_Int32;
		public static RMethod RMmemcpy_aligned_2_BytePointer_BytePointer_Int32
		{
			get
			{
				if(r_Mmemcpy_aligned_2_BytePointer_BytePointer_Int32 == null)
				{
					r_Mmemcpy_aligned_2_BytePointer_BytePointer_Int32 = new(typeof(System.String), "memcpy_aligned_2", 0, typeof(System.Byte).MakePointerType(), typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_Mmemcpy_aligned_2_BytePointer_BytePointer_Int32.SetBelong(null);
				}
				return r_Mmemcpy_aligned_2_BytePointer_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Void memcpy_aligned_4(Byte*, Byte*, Int32)
		/// </summary>
		protected static RMethod r_Mmemcpy_aligned_4_BytePointer_BytePointer_Int32;
		public static RMethod RMmemcpy_aligned_4_BytePointer_BytePointer_Int32
		{
			get
			{
				if(r_Mmemcpy_aligned_4_BytePointer_BytePointer_Int32 == null)
				{
					r_Mmemcpy_aligned_4_BytePointer_BytePointer_Int32 = new(typeof(System.String), "memcpy_aligned_4", 0, typeof(System.Byte).MakePointerType(), typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_Mmemcpy_aligned_4_BytePointer_BytePointer_Int32.SetBelong(null);
				}
				return r_Mmemcpy_aligned_4_BytePointer_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Void memcpy_aligned_8(Byte*, Byte*, Int32)
		/// </summary>
		protected static RMethod r_Mmemcpy_aligned_8_BytePointer_BytePointer_Int32;
		public static RMethod RMmemcpy_aligned_8_BytePointer_BytePointer_Int32
		{
			get
			{
				if(r_Mmemcpy_aligned_8_BytePointer_BytePointer_Int32 == null)
				{
					r_Mmemcpy_aligned_8_BytePointer_BytePointer_Int32 = new(typeof(System.String), "memcpy_aligned_8", 0, typeof(System.Byte).MakePointerType(), typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_Mmemcpy_aligned_8_BytePointer_BytePointer_Int32.SetBelong(null);
				}
				return r_Mmemcpy_aligned_8_BytePointer_BytePointer_Int32;
			}
		}

		/// <summary>
		/// System.String CreateString(SByte*)
		/// </summary>
		protected RMethod r_MCreateString_SBytePointer;
		public virtual RMethod RMCreateString_SBytePointer
		{
			get
			{
				if(r_MCreateString_SBytePointer == null)
				{
					r_MCreateString_SBytePointer = new(this, "CreateString", 0, typeof(System.SByte).MakePointerType());
					r_MCreateString_SBytePointer.SetBelong(this.instance);
				}
				return r_MCreateString_SBytePointer;
			}
		}

		/// <summary>
		/// System.String CreateString(SByte*, Int32, Int32)
		/// </summary>
		protected RMethod r_MCreateString_SBytePointer_Int32_Int32;
		public virtual RMethod RMCreateString_SBytePointer_Int32_Int32
		{
			get
			{
				if(r_MCreateString_SBytePointer_Int32_Int32 == null)
				{
					r_MCreateString_SBytePointer_Int32_Int32 = new(this, "CreateString", 0, typeof(System.SByte).MakePointerType(), typeof(System.Int32), typeof(System.Int32));
					r_MCreateString_SBytePointer_Int32_Int32.SetBelong(this.instance);
				}
				return r_MCreateString_SBytePointer_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String CreateString(Char*)
		/// </summary>
		protected RMethod r_MCreateString_CharPointer;
		public virtual RMethod RMCreateString_CharPointer
		{
			get
			{
				if(r_MCreateString_CharPointer == null)
				{
					r_MCreateString_CharPointer = new(this, "CreateString", 0, typeof(System.Char).MakePointerType());
					r_MCreateString_CharPointer.SetBelong(this.instance);
				}
				return r_MCreateString_CharPointer;
			}
		}

		/// <summary>
		/// System.String CreateString(Char*, Int32, Int32)
		/// </summary>
		protected RMethod r_MCreateString_CharPointer_Int32_Int32;
		public virtual RMethod RMCreateString_CharPointer_Int32_Int32
		{
			get
			{
				if(r_MCreateString_CharPointer_Int32_Int32 == null)
				{
					r_MCreateString_CharPointer_Int32_Int32 = new(this, "CreateString", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Int32));
					r_MCreateString_CharPointer_Int32_Int32.SetBelong(this.instance);
				}
				return r_MCreateString_CharPointer_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String CreateString(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_MCreateString_CharArray_Int32_Int32;
		public virtual RMethod RMCreateString_CharArray_Int32_Int32
		{
			get
			{
				if(r_MCreateString_CharArray_Int32_Int32 == null)
				{
					r_MCreateString_CharArray_Int32_Int32 = new(this, "CreateString", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MCreateString_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_MCreateString_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String CreateString(Char[])
		/// </summary>
		protected RMethod r_MCreateString_CharArray;
		public virtual RMethod RMCreateString_CharArray
		{
			get
			{
				if(r_MCreateString_CharArray == null)
				{
					r_MCreateString_CharArray = new(this, "CreateString", 0, typeof(System.Char).MakeArrayType());
					r_MCreateString_CharArray.SetBelong(this.instance);
				}
				return r_MCreateString_CharArray;
			}
		}

		/// <summary>
		/// System.String CreateString(Char, Int32)
		/// </summary>
		protected RMethod r_MCreateString_Char_Int32;
		public virtual RMethod RMCreateString_Char_Int32
		{
			get
			{
				if(r_MCreateString_Char_Int32 == null)
				{
					r_MCreateString_Char_Int32 = new(this, "CreateString", 0, typeof(System.Char), typeof(System.Int32));
					r_MCreateString_Char_Int32.SetBelong(this.instance);
				}
				return r_MCreateString_Char_Int32;
			}
		}

		/// <summary>
		/// System.String CreateString(SByte*, Int32, Int32, System.Text.Encoding)
		/// </summary>
		protected RMethod r_MCreateString_SBytePointer_Int32_Int32_Encoding;
		public virtual RMethod RMCreateString_SBytePointer_Int32_Int32_Encoding
		{
			get
			{
				if(r_MCreateString_SBytePointer_Int32_Int32_Encoding == null)
				{
					r_MCreateString_SBytePointer_Int32_Int32_Encoding = new(this, "CreateString", 0, typeof(System.SByte).MakePointerType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Text.Encoding));
					r_MCreateString_SBytePointer_Int32_Int32_Encoding.SetBelong(this.instance);
				}
				return r_MCreateString_SBytePointer_Int32_Int32_Encoding;
			}
		}

		/// <summary>
		/// System.String CreateString(System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected RMethod r_MCreateString_ReadOnlySpan_d_Char_p_;
		public virtual RMethod RMCreateString_ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_MCreateString_ReadOnlySpan_d_Char_p_ == null)
				{
					r_MCreateString_ReadOnlySpan_d_Char_p_ = new(this, "CreateString", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_MCreateString_ReadOnlySpan_d_Char_p_.SetBelong(this.instance);
				}
				return r_MCreateString_ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// System.String Intern(System.String)
		/// </summary>
		protected static RMethod r_MIntern_String;
		public static RMethod RMIntern_String
		{
			get
			{
				if(r_MIntern_String == null)
				{
					r_MIntern_String = new(typeof(System.String), "Intern", 0, typeof(System.String));
					r_MIntern_String.SetBelong(null);
				}
				return r_MIntern_String;
			}
		}

		/// <summary>
		/// System.String IsInterned(System.String)
		/// </summary>
		protected static RMethod r_MIsInterned_String;
		public static RMethod RMIsInterned_String
		{
			get
			{
				if(r_MIsInterned_String == null)
				{
					r_MIsInterned_String = new(typeof(System.String), "IsInterned", 0, typeof(System.String));
					r_MIsInterned_String.SetBelong(null);
				}
				return r_MIsInterned_String;
			}
		}

		/// <summary>
		/// Int32 LegacyStringGetHashCode()
		/// </summary>
		protected RMethod r_MLegacyStringGetHashCode;
		public virtual RMethod RMLegacyStringGetHashCode
		{
			get
			{
				if(r_MLegacyStringGetHashCode == null)
				{
					r_MLegacyStringGetHashCode = new(this, "LegacyStringGetHashCode", 0);
					r_MLegacyStringGetHashCode.SetBelong(this.instance);
				}
				return r_MLegacyStringGetHashCode;
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
            var ___result = RMCompareOrdinalIgnoreCaseHelper_String_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean EqualsHelper(System.String @strA, System.String @strB)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @strB};
            var ___result = RMEqualsHelper_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Int32 CompareOrdinalHelper(System.String @strA, System.Int32 @indexA, System.Int32 @countA, System.String @strB, System.Int32 @indexB, System.Int32 @countB)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @indexA, @countA, @strB, @indexB, @countB};
            var ___result = RMCompareOrdinalHelper_String_Int32_Int32_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean EqualsIgnoreCaseAsciiHelper(System.String @strA, System.String @strB)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @strB};
            var ___result = RMEqualsIgnoreCaseAsciiHelper_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Int32 CompareOrdinalHelper(System.String @strA, System.String @strB)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @strB};
            var ___result = RMCompareOrdinalHelper_String_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 Compare(System.String @strA, System.String @strB)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @strB};
            var ___result = RMCompare_String_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 Compare(System.String @strA, System.String @strB, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @strB, @ignoreCase};
            var ___result = RMCompare_String_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 Compare(System.String @strA, System.String @strB, System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @strB, @comparisonType};
            var ___result = RMCompare_String_String_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 Compare(System.String @strA, System.String @strB, System.Globalization.CultureInfo @culture, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @strB, @culture, @options};
            var ___result = RMCompare_String_String_CultureInfo_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 Compare(System.String @strA, System.String @strB, System.Boolean @ignoreCase, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @strB, @ignoreCase, @culture};
            var ___result = RMCompare_String_String_Boolean_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 Compare(System.String @strA, System.Int32 @indexA, System.String @strB, System.Int32 @indexB, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @indexA, @strB, @indexB, @length};
            var ___result = RMCompare_String_Int32_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 Compare(System.String @strA, System.Int32 @indexA, System.String @strB, System.Int32 @indexB, System.Int32 @length, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @indexA, @strB, @indexB, @length, @ignoreCase};
            var ___result = RMCompare_String_Int32_String_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 Compare(System.String @strA, System.Int32 @indexA, System.String @strB, System.Int32 @indexB, System.Int32 @length, System.Boolean @ignoreCase, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @indexA, @strB, @indexB, @length, @ignoreCase, @culture};
            var ___result = RMCompare_String_Int32_String_Int32_Int32_Boolean_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 Compare(System.String @strA, System.Int32 @indexA, System.String @strB, System.Int32 @indexB, System.Int32 @length, System.Globalization.CultureInfo @culture, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @indexA, @strB, @indexB, @length, @culture, @options};
            var ___result = RMCompare_String_Int32_String_Int32_Int32_CultureInfo_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 Compare(System.String @strA, System.Int32 @indexA, System.String @strB, System.Int32 @indexB, System.Int32 @length, System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @indexA, @strB, @indexB, @length, @comparisonType};
            var ___result = RMCompare_String_Int32_String_Int32_Int32_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 CompareOrdinal(System.String @strA, System.String @strB)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @strB};
            var ___result = RMCompareOrdinal_String_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 CompareOrdinal(RSystem.RReadOnlySpan<RSystem.RChar> @strA, RSystem.RReadOnlySpan<RSystem.RChar> @strB)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA.Value, @strB.Value};
            var ___result = RMCompareOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 CompareOrdinal(System.String @strA, System.Int32 @indexA, System.String @strB, System.Int32 @indexB, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @indexA, @strB, @indexB, @length};
            var ___result = RMCompareOrdinal_String_Int32_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareTo(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareTo(System.String @strB)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strB};
            var ___result = RMCompareTo_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean EndsWith(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMEndsWith_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean EndsWith(System.String @value, System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @comparisonType};
            var ___result = RMEndsWith_String_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean EndsWith(System.String @value, System.Boolean @ignoreCase, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @ignoreCase, @culture};
            var ___result = RMEndsWith_String_Boolean_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean EndsWith(System.Char @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMEndsWith_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMEquals_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.String @value, System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @comparisonType};
            var ___result = RMEquals_String_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean Equals(System.String @a, System.String @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMEquals_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean Equals(System.String @a, System.String @b, System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @comparisonType};
            var ___result = RMEquals_String_String_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(System.String @a, System.String @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Equality_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.String @a, System.String @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Inequality_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode(System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@comparisonType};
            var ___result = RMGetHashCode_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetLegacyNonRandomizedHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetLegacyNonRandomizedHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean StartsWith(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMStartsWith_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean StartsWith(System.String @value, System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @comparisonType};
            var ___result = RMStartsWith_String_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean StartsWith(System.String @value, System.Boolean @ignoreCase, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @ignoreCase, @culture};
            var ___result = RMStartsWith_String_Boolean_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean StartsWith(System.Char @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMStartsWith_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void CheckStringComparison(System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@comparisonType};
            var ___result = RMCheckStringComparison_StringComparison.Invoke(___genericsType, ___parameters);

            
        }


        public static void FillStringChecked(System.String @dest, System.Int32 @destPos, System.String @src)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dest, @destPos, @src};
            var ___result = RMFillStringChecked_String_Int32_String.Invoke(___genericsType, ___parameters);

            
        }


        public static System.String Concat(System.Object @arg0)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arg0};
            var ___result = RMConcat_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Concat(System.Object @arg0, System.Object @arg1)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arg0, @arg1};
            var ___result = RMConcat_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Concat(System.Object @arg0, System.Object @arg1, System.Object @arg2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arg0, @arg1, @arg2};
            var ___result = RMConcat_Object_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Concat(System.Object[] @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RMConcat_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Concat<T>(System.Collections.Generic.IEnumerable<T> @values)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@values};
            var ___result = RMConcat_GT_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Concat(System.Collections.Generic.IEnumerable<System.String> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@values};
            var ___result = RMConcat_IEnumerable_d_String_p_.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Concat(System.String @str0, System.String @str1)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str0, @str1};
            var ___result = RMConcat_String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Concat(System.String @str0, System.String @str1, System.String @str2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str0, @str1, @str2};
            var ___result = RMConcat_String_String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Concat(System.String @str0, System.String @str1, System.String @str2, System.String @str3)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str0, @str1, @str2, @str3};
            var ___result = RMConcat_String_String_String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Concat(System.String[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@values};
            var ___result = RMConcat_StringArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Format(System.String @format, System.Object @arg0)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @arg0};
            var ___result = RMFormat_String_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Format(System.String @format, System.Object @arg0, System.Object @arg1)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @arg0, @arg1};
            var ___result = RMFormat_String_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Format(System.String @format, System.Object @arg0, System.Object @arg1, System.Object @arg2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @arg0, @arg1, @arg2};
            var ___result = RMFormat_String_Object_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Format(System.String @format, System.Object[] @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @args};
            var ___result = RMFormat_String_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Format(System.IFormatProvider @provider, System.String @format, System.Object @arg0)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider, @format, @arg0};
            var ___result = RMFormat_IFormatProvider_String_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Format(System.IFormatProvider @provider, System.String @format, System.Object @arg0, System.Object @arg1)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider, @format, @arg0, @arg1};
            var ___result = RMFormat_IFormatProvider_String_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Format(System.IFormatProvider @provider, System.String @format, System.Object @arg0, System.Object @arg1, System.Object @arg2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider, @format, @arg0, @arg1, @arg2};
            var ___result = RMFormat_IFormatProvider_String_Object_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Format(System.IFormatProvider @provider, System.String @format, System.Object[] @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider, @format, @args};
            var ___result = RMFormat_IFormatProvider_String_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String FormatHelper(System.IFormatProvider @provider, System.String @format, RSystem.RParamsArray @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider, @format, @args.Value};
            var ___result = RMFormatHelper_IFormatProvider_String_ParamsArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Insert(System.Int32 @startIndex, System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex, @value};
            var ___result = RMInsert_Int32_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Join(System.Char @separator, System.String[] @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @value};
            var ___result = RMJoin_Char_StringArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Join(System.Char @separator, System.Object[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @values};
            var ___result = RMJoin_Char_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Join<T>(System.Char @separator, System.Collections.Generic.IEnumerable<T> @values)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@separator, @values};
            var ___result = RMJoin_GT_Char_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Join(System.Char @separator, System.String[] @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @value, @startIndex, @count};
            var ___result = RMJoin_Char_StringArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Join(System.String @separator, System.String[] @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @value};
            var ___result = RMJoin_String_StringArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Join(System.String @separator, System.Object[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @values};
            var ___result = RMJoin_String_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Join<T>(System.String @separator, System.Collections.Generic.IEnumerable<T> @values)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@separator, @values};
            var ___result = RMJoin_GT_String_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Join(System.String @separator, System.Collections.Generic.IEnumerable<System.String> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @values};
            var ___result = RMJoin_String_IEnumerable_d_String_p_.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Join(System.String @separator, System.String[] @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @value, @startIndex, @count};
            var ___result = RMJoin_String_StringArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe static System.String JoinCore(System.Char* @separator, System.Int32 @separatorLength, System.Object[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@separator, typeof(System.Char)), @separatorLength, @values};
            var ___result = RMJoinCore_CharPointer_Int32_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe static System.String JoinCore<T>(System.Char* @separator, System.Int32 @separatorLength, System.Collections.Generic.IEnumerable<T> @values)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{Pointer.Box(@separator, typeof(System.Char)), @separatorLength, @values};
            var ___result = RMJoinCore_GT_CharPointer_Int32_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe static System.String JoinCore(System.Char* @separator, System.Int32 @separatorLength, System.String[] @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@separator, typeof(System.Char)), @separatorLength, @value, @startIndex, @count};
            var ___result = RMJoinCore_CharPointer_Int32_StringArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String PadLeft(System.Int32 @totalWidth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@totalWidth};
            var ___result = RMPadLeft_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String PadLeft(System.Int32 @totalWidth, System.Char @paddingChar)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@totalWidth, @paddingChar};
            var ___result = RMPadLeft_Int32_Char.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String PadRight(System.Int32 @totalWidth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@totalWidth};
            var ___result = RMPadRight_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String PadRight(System.Int32 @totalWidth, System.Char @paddingChar)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@totalWidth, @paddingChar};
            var ___result = RMPadRight_Int32_Char.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Remove(System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex, @count};
            var ___result = RMRemove_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Remove(System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex};
            var ___result = RMRemove_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Replace(System.String @oldValue, System.String @newValue, System.Boolean @ignoreCase, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue, @ignoreCase, @culture};
            var ___result = RMReplace_String_String_Boolean_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Replace(System.String @oldValue, System.String @newValue, System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue, @comparisonType};
            var ___result = RMReplace_String_String_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ReplaceCore(System.String @oldValue, System.String @newValue, System.Globalization.CultureInfo @culture, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue, @culture, @options};
            var ___result = RMReplaceCore_String_String_CultureInfo_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Replace(System.Char @oldChar, System.Char @newChar)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldChar, @newChar};
            var ___result = RMReplace_Char_Char.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Replace(System.String @oldValue, System.String @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = RMReplace_String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ReplaceHelper(System.Int32 @oldValueLength, System.String @newValue, RSystem.RReadOnlySpan<RSystem.RInt32> @indices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValueLength, @newValue, @indices.Value};
            var ___result = RMReplaceHelper_Int32_String_ReadOnlySpan_d_Int32_p_.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String[] Split(System.Char @separator, System.StringSplitOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @options};
            var ___result = RMSplit_Char_StringSplitOptions.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] Split(System.Char @separator, System.Int32 @count, System.StringSplitOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @count, @options};
            var ___result = RMSplit_Char_Int32_StringSplitOptions.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] Split(System.Char[] @separator)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator};
            var ___result = RMSplit_CharArray.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] Split(System.Char[] @separator, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @count};
            var ___result = RMSplit_CharArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] Split(System.Char[] @separator, System.StringSplitOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @options};
            var ___result = RMSplit_CharArray_StringSplitOptions.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] Split(System.Char[] @separator, System.Int32 @count, System.StringSplitOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @count, @options};
            var ___result = RMSplit_CharArray_Int32_StringSplitOptions.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] SplitInternal(RSystem.RReadOnlySpan<RSystem.RChar> @separators, System.Int32 @count, System.StringSplitOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separators.Value, @count, @options};
            var ___result = RMSplitInternal_ReadOnlySpan_d_Char_p__Int32_StringSplitOptions.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] Split(System.String @separator, System.StringSplitOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @options};
            var ___result = RMSplit_String_StringSplitOptions.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] Split(System.String @separator, System.Int32 @count, System.StringSplitOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @count, @options};
            var ___result = RMSplit_String_Int32_StringSplitOptions.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] Split(System.String[] @separator, System.StringSplitOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @options};
            var ___result = RMSplit_StringArray_StringSplitOptions.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] Split(System.String[] @separator, System.Int32 @count, System.StringSplitOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @count, @options};
            var ___result = RMSplit_StringArray_Int32_StringSplitOptions.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] SplitInternal(System.String @separator, System.String[] @separators, System.Int32 @count, System.StringSplitOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @separators, @count, @options};
            var ___result = RMSplitInternal_String_StringArray_Int32_StringSplitOptions.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] SplitInternal(System.String @separator, System.Int32 @count, System.StringSplitOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @count, @options};
            var ___result = RMSplitInternal_String_Int32_StringSplitOptions.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] SplitKeepEmptyEntries(RSystem.RReadOnlySpan<RSystem.RInt32> @sepList, RSystem.RReadOnlySpan<RSystem.RInt32> @lengthList, System.Int32 @defaultLength, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sepList.Value, @lengthList.Value, @defaultLength, @count};
            var ___result = RMSplitKeepEmptyEntries_ReadOnlySpan_d_Int32_p__ReadOnlySpan_d_Int32_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] SplitOmitEmptyEntries(RSystem.RReadOnlySpan<RSystem.RInt32> @sepList, RSystem.RReadOnlySpan<RSystem.RInt32> @lengthList, System.Int32 @defaultLength, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sepList.Value, @lengthList.Value, @defaultLength, @count};
            var ___result = RMSplitOmitEmptyEntries_ReadOnlySpan_d_Int32_p__ReadOnlySpan_d_Int32_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual void MakeSeparatorList(RSystem.RReadOnlySpan<RSystem.RChar> @separators, ref RSystem.RCollections.RGeneric.RValueListBuilder<RSystem.RInt32> @sepListBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separators.Value, @sepListBuilder.Value};
            var ___result = RMMakeSeparatorList_ReadOnlySpan_d_Char_p__Ref_ValueListBuilder_d_Int32_p_.Invoke(___genericsType, ___parameters);
			@sepListBuilder = new RSystem.RCollections.RGeneric.RValueListBuilder<RSystem.RInt32>(___parameters[1]);

            
        }


        public virtual void MakeSeparatorList(System.String @separator, ref RSystem.RCollections.RGeneric.RValueListBuilder<RSystem.RInt32> @sepListBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @sepListBuilder.Value};
            var ___result = RMMakeSeparatorList_String_Ref_ValueListBuilder_d_Int32_p_.Invoke(___genericsType, ___parameters);
			@sepListBuilder = new RSystem.RCollections.RGeneric.RValueListBuilder<RSystem.RInt32>(___parameters[1]);

            
        }


        public virtual void MakeSeparatorList(System.String[] @separators, ref RSystem.RCollections.RGeneric.RValueListBuilder<RSystem.RInt32> @sepListBuilder, ref RSystem.RCollections.RGeneric.RValueListBuilder<RSystem.RInt32> @lengthListBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separators, @sepListBuilder.Value, @lengthListBuilder.Value};
            var ___result = RMMakeSeparatorList_StringArray_Ref_ValueListBuilder_d_Int32_p__Ref_ValueListBuilder_d_Int32_p_.Invoke(___genericsType, ___parameters);
			@sepListBuilder = new RSystem.RCollections.RGeneric.RValueListBuilder<RSystem.RInt32>(___parameters[1]);
			@lengthListBuilder = new RSystem.RCollections.RGeneric.RValueListBuilder<RSystem.RInt32>(___parameters[2]);

            
        }


        public virtual System.String Substring(System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex};
            var ___result = RMSubstring_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Substring(System.Int32 @startIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex, @length};
            var ___result = RMSubstring_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String InternalSubString(System.Int32 @startIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex, @length};
            var ___result = RMInternalSubString_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToLower()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToLower.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToLower(System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@culture};
            var ___result = RMToLower_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToLowerInvariant()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToLowerInvariant.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToUpper()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToUpper.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToUpper(System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@culture};
            var ___result = RMToUpper_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToUpperInvariant()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToUpperInvariant.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Trim()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMTrim.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Trim(System.Char @trimChar)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@trimChar};
            var ___result = RMTrim_Char.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Trim(System.Char[] @trimChars)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@trimChars};
            var ___result = RMTrim_CharArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String TrimStart()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMTrimStart.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String TrimStart(System.Char @trimChar)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@trimChar};
            var ___result = RMTrimStart_Char.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String TrimStart(System.Char[] @trimChars)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@trimChars};
            var ___result = RMTrimStart_CharArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String TrimEnd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMTrimEnd.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String TrimEnd(System.Char @trimChar)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@trimChar};
            var ___result = RMTrimEnd_Char.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String TrimEnd(System.Char[] @trimChars)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@trimChars};
            var ___result = RMTrimEnd_CharArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String TrimWhiteSpaceHelper(RSystem.RString.RTrimType @trimType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@trimType.Value};
            var ___result = RMTrimWhiteSpaceHelper_TrimType.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe virtual System.String TrimHelper(System.Char* @trimChars, System.Int32 @trimCharsLength, RSystem.RString.RTrimType @trimType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@trimChars, typeof(System.Char)), @trimCharsLength, @trimType.Value};
            var ___result = RMTrimHelper_CharPointer_Int32_TrimType.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String CreateTrimmedString(System.Int32 @start, System.Int32 @end)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @end};
            var ___result = RMCreateTrimmedString_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean Contains(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMContains_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Contains(System.String @value, System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @comparisonType};
            var ___result = RMContains_String_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Contains(System.Char @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMContains_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Contains(System.Char @value, System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @comparisonType};
            var ___result = RMContains_Char_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 IndexOf(System.Char @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMIndexOf_Char.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.Char @value, System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex};
            var ___result = RMIndexOf_Char_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.Char @value, System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @comparisonType};
            var ___result = RMIndexOf_Char_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.Char @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @count};
            var ___result = RMIndexOf_Char_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOfAny(System.Char[] @anyOf)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anyOf};
            var ___result = RMIndexOfAny_CharArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOfAny(System.Char[] @anyOf, System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anyOf, @startIndex};
            var ___result = RMIndexOfAny_CharArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOfAny(System.Char[] @anyOf, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anyOf, @startIndex, @count};
            var ___result = RMIndexOfAny_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOfAny(System.Char @value1, System.Char @value2, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value1, @value2, @startIndex, @count};
            var ___result = RMIndexOfAny_Char_Char_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOfAny(System.Char @value1, System.Char @value2, System.Char @value3, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value1, @value2, @value3, @startIndex, @count};
            var ___result = RMIndexOfAny_Char_Char_Char_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOfCharArray(System.Char[] @anyOf, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anyOf, @startIndex, @count};
            var ___result = RMIndexOfCharArray_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe static void InitializeProbabilisticMap(System.UInt32* @charMap, RSystem.RReadOnlySpan<RSystem.RChar> @anyOf)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@charMap, typeof(System.UInt32)), @anyOf.Value};
            var ___result = RMInitializeProbabilisticMap_UInt32Pointer_ReadOnlySpan_d_Char_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean ArrayContains(System.Char @searchChar, System.Char[] @anyOf)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@searchChar, @anyOf};
            var ___result = RMArrayContains_Char_CharArray.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public unsafe static System.Boolean IsCharBitSet(System.UInt32* @charMap, System.Byte @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@charMap, typeof(System.UInt32)), @value};
            var ___result = RMIsCharBitSet_UInt32Pointer_Byte.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public unsafe static void SetCharBit(System.UInt32* @charMap, System.Byte @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@charMap, typeof(System.UInt32)), @value};
            var ___result = RMSetCharBit_UInt32Pointer_Byte.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 IndexOf(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMIndexOf_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String @value, System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex};
            var ___result = RMIndexOf_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @count};
            var ___result = RMIndexOf_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String @value, System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @comparisonType};
            var ___result = RMIndexOf_String_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String @value, System.Int32 @startIndex, System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @comparisonType};
            var ___result = RMIndexOf_String_Int32_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String @value, System.Int32 @startIndex, System.Int32 @count, System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @count, @comparisonType};
            var ___result = RMIndexOf_String_Int32_Int32_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.Char @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMLastIndexOf_Char.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.Char @value, System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex};
            var ___result = RMLastIndexOf_Char_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.Char @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @count};
            var ___result = RMLastIndexOf_Char_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOfAny(System.Char[] @anyOf)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anyOf};
            var ___result = RMLastIndexOfAny_CharArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOfAny(System.Char[] @anyOf, System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anyOf, @startIndex};
            var ___result = RMLastIndexOfAny_CharArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOfAny(System.Char[] @anyOf, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anyOf, @startIndex, @count};
            var ___result = RMLastIndexOfAny_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOfCharArray(System.Char[] @anyOf, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anyOf, @startIndex, @count};
            var ___result = RMLastIndexOfCharArray_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMLastIndexOf_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @value, System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex};
            var ___result = RMLastIndexOf_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @count};
            var ___result = RMLastIndexOf_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @value, System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @comparisonType};
            var ___result = RMLastIndexOf_String_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @value, System.Int32 @startIndex, System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @comparisonType};
            var ___result = RMLastIndexOf_String_Int32_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @value, System.Int32 @startIndex, System.Int32 @count, System.StringComparison @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @count, @comparisonType};
            var ___result = RMLastIndexOf_String_Int32_Int32_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.String Ctor(System.Char[] @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMCtor_CharArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Ctor(System.Char[] @value, System.Int32 @startIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @length};
            var ___result = RMCtor_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe static System.String Ctor(System.Char* @ptr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@ptr, typeof(System.Char))};
            var ___result = RMCtor_CharPointer.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe static System.String Ctor(System.Char* @ptr, System.Int32 @startIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@ptr, typeof(System.Char)), @startIndex, @length};
            var ___result = RMCtor_CharPointer_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe static System.String Ctor(System.SByte* @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@value, typeof(System.SByte))};
            var ___result = RMCtor_SBytePointer.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe static System.String Ctor(System.SByte* @value, System.Int32 @startIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@value, typeof(System.SByte)), @startIndex, @length};
            var ___result = RMCtor_SBytePointer_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe static System.String CreateStringForSByteConstructor(System.Byte* @pb, System.Int32 @numBytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@pb, typeof(System.Byte)), @numBytes};
            var ___result = RMCreateStringForSByteConstructor_BytePointer_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe static System.String Ctor(System.SByte* @value, System.Int32 @startIndex, System.Int32 @length, System.Text.Encoding @enc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@value, typeof(System.SByte)), @startIndex, @length, @enc};
            var ___result = RMCtor_SBytePointer_Int32_Int32_Encoding.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Ctor(System.Char @c, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c, @count};
            var ___result = RMCtor_Char_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Ctor(RSystem.RReadOnlySpan<RSystem.RChar> @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value.Value};
            var ___result = RMCtor_ReadOnlySpan_d_Char_p_.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Create<TState>(System.Int32 @length, TState @state, System.Buffers.SpanAction<System.Char, TState> @action)
        {

            var ___genericsType = new Type[] {typeof(TState)};
            var ___parameters = new object[]{@length, @state, @action};
            var ___result = RMCreate_GTState_Int32_TState_SpanAction_d_Char_TState_p_.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static RSystem.RReadOnlySpan<RSystem.RChar> op_Implicit(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMop_Implicit_String.Invoke(___genericsType, ___parameters);

            return new RSystem.RReadOnlySpan<RSystem.RChar>(___result);
        }


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.String Copy(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RMCopy_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void CopyTo(System.Int32 @sourceIndex, System.Char[] @destination, System.Int32 @destinationIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sourceIndex, @destination, @destinationIndex, @count};
            var ___result = RMCopyTo_Int32_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Char[] ToCharArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToCharArray.Invoke(___genericsType, ___parameters);

            return (System.Char[])___result;
        }


        public virtual System.Char[] ToCharArray(System.Int32 @startIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex, @length};
            var ___result = RMToCharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Char[])___result;
        }


        public static System.Boolean IsNullOrEmpty(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMIsNullOrEmpty_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsNullOrWhiteSpace(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMIsNullOrWhiteSpace_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Char GetRawStringData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRawStringData.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public unsafe static System.String CreateStringFromEncoding(System.Byte* @bytes, System.Int32 @byteLength, System.Text.Encoding @encoding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@bytes, typeof(System.Byte)), @byteLength, @encoding};
            var ___result = RMCreateStringFromEncoding_BytePointer_Int32_Encoding.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String CreateFromChar(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMCreateFromChar_Char.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe static void wstrcpy(System.Char* @dmem, System.Char* @smem, System.Int32 @charCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@dmem, typeof(System.Char)), Pointer.Box(@smem, typeof(System.Char)), @charCount};
            var ___result = RMwstrcpy_CharPointer_CharPointer_Int32.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.CharEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.CharEnumerator)___result;
        }


        public virtual System.Collections.Generic.IEnumerator<System.Char> System__2__Collections__2__Generic__2__IEnumerable__0__System__2__Char__1____2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Char__1____2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerator<System.Char>)___result;
        }


        public virtual System.Collections.IEnumerator System__2__Collections__2__IEnumerable__2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__IEnumerable__2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public unsafe static System.Int32 wcslen(System.Char* @ptr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@ptr, typeof(System.Char))};
            var ___result = RMwcslen_CharPointer.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.Boolean IsNormalized()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsNormalized.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsNormalized(System.Text.NormalizationForm @normalizationForm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@normalizationForm};
            var ___result = RMIsNormalized_NormalizationForm.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String Normalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMNormalize.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Normalize(System.Text.NormalizationForm @normalizationForm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@normalizationForm};
            var ___result = RMNormalize_NormalizationForm.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 IndexOfUnchecked(System.String @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @count};
            var ___result = RMIndexOfUnchecked_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.String Concat(System.Object @arg0, System.Object @arg1, System.Object @arg2, System.Object @arg3)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arg0, @arg1, @arg2, @arg3};
            var ___result = RMConcat_Object_Object_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 IndexOfUncheckedIgnoreCase(System.String @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @count};
            var ___result = RMIndexOfUncheckedIgnoreCase_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOfUnchecked(System.String @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @count};
            var ___result = RMLastIndexOfUnchecked_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOfUncheckedIgnoreCase(System.String @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @count};
            var ___result = RMLastIndexOfUncheckedIgnoreCase_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean StartsWithOrdinalUnchecked(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMStartsWithOrdinalUnchecked_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.String FastAllocateString(System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@length};
            var ___result = RMFastAllocateString_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String InternalIsInterned(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RMInternalIsInterned_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String InternalIntern(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RMInternalIntern_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe static System.Int32 FastCompareStringHelper(System.UInt32* @strAChars, System.Int32 @countA, System.UInt32* @strBChars, System.Int32 @countB)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@strAChars, typeof(System.UInt32)), @countA, Pointer.Box(@strBChars, typeof(System.UInt32)), @countB};
            var ___result = RMFastCompareStringHelper_UInt32Pointer_Int32_UInt32Pointer_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe static void memset(System.Byte* @dest, System.Int32 @val, System.Int32 @len)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@dest, typeof(System.Byte)), @val, @len};
            var ___result = RMmemset_BytePointer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe static void memcpy(System.Byte* @dest, System.Byte* @src, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@dest, typeof(System.Byte)), Pointer.Box(@src, typeof(System.Byte)), @size};
            var ___result = RMmemcpy_BytePointer_BytePointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe static void bzero(System.Byte* @dest, System.Int32 @len)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@dest, typeof(System.Byte)), @len};
            var ___result = RMbzero_BytePointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe static void bzero_aligned_1(System.Byte* @dest, System.Int32 @len)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@dest, typeof(System.Byte)), @len};
            var ___result = RMbzero_aligned_1_BytePointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe static void bzero_aligned_2(System.Byte* @dest, System.Int32 @len)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@dest, typeof(System.Byte)), @len};
            var ___result = RMbzero_aligned_2_BytePointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe static void bzero_aligned_4(System.Byte* @dest, System.Int32 @len)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@dest, typeof(System.Byte)), @len};
            var ___result = RMbzero_aligned_4_BytePointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe static void bzero_aligned_8(System.Byte* @dest, System.Int32 @len)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@dest, typeof(System.Byte)), @len};
            var ___result = RMbzero_aligned_8_BytePointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe static void memcpy_aligned_1(System.Byte* @dest, System.Byte* @src, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@dest, typeof(System.Byte)), Pointer.Box(@src, typeof(System.Byte)), @size};
            var ___result = RMmemcpy_aligned_1_BytePointer_BytePointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe static void memcpy_aligned_2(System.Byte* @dest, System.Byte* @src, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@dest, typeof(System.Byte)), Pointer.Box(@src, typeof(System.Byte)), @size};
            var ___result = RMmemcpy_aligned_2_BytePointer_BytePointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe static void memcpy_aligned_4(System.Byte* @dest, System.Byte* @src, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@dest, typeof(System.Byte)), Pointer.Box(@src, typeof(System.Byte)), @size};
            var ___result = RMmemcpy_aligned_4_BytePointer_BytePointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe static void memcpy_aligned_8(System.Byte* @dest, System.Byte* @src, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@dest, typeof(System.Byte)), Pointer.Box(@src, typeof(System.Byte)), @size};
            var ___result = RMmemcpy_aligned_8_BytePointer_BytePointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe virtual System.String CreateString(System.SByte* @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@value, typeof(System.SByte))};
            var ___result = RMCreateString_SBytePointer.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe virtual System.String CreateString(System.SByte* @value, System.Int32 @startIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@value, typeof(System.SByte)), @startIndex, @length};
            var ___result = RMCreateString_SBytePointer_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe virtual System.String CreateString(System.Char* @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@value, typeof(System.Char))};
            var ___result = RMCreateString_CharPointer.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe virtual System.String CreateString(System.Char* @value, System.Int32 @startIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@value, typeof(System.Char)), @startIndex, @length};
            var ___result = RMCreateString_CharPointer_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String CreateString(System.Char[] @val, System.Int32 @startIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@val, @startIndex, @length};
            var ___result = RMCreateString_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String CreateString(System.Char[] @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@val};
            var ___result = RMCreateString_CharArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String CreateString(System.Char @c, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c, @count};
            var ___result = RMCreateString_Char_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe virtual System.String CreateString(System.SByte* @value, System.Int32 @startIndex, System.Int32 @length, System.Text.Encoding @enc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@value, typeof(System.SByte)), @startIndex, @length, @enc};
            var ___result = RMCreateString_SBytePointer_Int32_Int32_Encoding.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String CreateString(RSystem.RReadOnlySpan<RSystem.RChar> @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value.Value};
            var ___result = RMCreateString_ReadOnlySpan_d_Char_p_.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Intern(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RMIntern_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String IsInterned(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RMIsInterned_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 LegacyStringGetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMLegacyStringGetHashCode.Invoke(___genericsType, ___parameters);

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
