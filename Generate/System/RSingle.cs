using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.Single
	/// </summary>
    public partial class RSingle : RMember //
    {

		/// <summary>
		/// System.Single m_value
		/// </summary>
		protected RSystem.RSingle r_m_value;
		public virtual RSystem.RSingle Rm_value
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
		/// System.Single MinValue
		/// </summary>
		protected static RSystem.RSingle r_MinValue;
		public static RSystem.RSingle RMinValue
		{
			get
			{
				if(r_MinValue == null)
				{
					r_MinValue = new(typeof(System.Single), "MinValue");
					r_MinValue.SetBelong(null);
				}
				return r_MinValue;
			}
		}

		/// <summary>
		/// System.Single Epsilon
		/// </summary>
		protected static RSystem.RSingle r_Epsilon;
		public static RSystem.RSingle REpsilon
		{
			get
			{
				if(r_Epsilon == null)
				{
					r_Epsilon = new(typeof(System.Single), "Epsilon");
					r_Epsilon.SetBelong(null);
				}
				return r_Epsilon;
			}
		}

		/// <summary>
		/// System.Single MaxValue
		/// </summary>
		protected static RSystem.RSingle r_MaxValue;
		public static RSystem.RSingle RMaxValue
		{
			get
			{
				if(r_MaxValue == null)
				{
					r_MaxValue = new(typeof(System.Single), "MaxValue");
					r_MaxValue.SetBelong(null);
				}
				return r_MaxValue;
			}
		}

		/// <summary>
		/// System.Single PositiveInfinity
		/// </summary>
		protected static RSystem.RSingle r_PositiveInfinity;
		public static RSystem.RSingle RPositiveInfinity
		{
			get
			{
				if(r_PositiveInfinity == null)
				{
					r_PositiveInfinity = new(typeof(System.Single), "PositiveInfinity");
					r_PositiveInfinity.SetBelong(null);
				}
				return r_PositiveInfinity;
			}
		}

		/// <summary>
		/// System.Single NegativeInfinity
		/// </summary>
		protected static RSystem.RSingle r_NegativeInfinity;
		public static RSystem.RSingle RNegativeInfinity
		{
			get
			{
				if(r_NegativeInfinity == null)
				{
					r_NegativeInfinity = new(typeof(System.Single), "NegativeInfinity");
					r_NegativeInfinity.SetBelong(null);
				}
				return r_NegativeInfinity;
			}
		}

		/// <summary>
		/// System.Single NaN
		/// </summary>
		protected static RSystem.RSingle r_NaN;
		public static RSystem.RSingle RNaN
		{
			get
			{
				if(r_NaN == null)
				{
					r_NaN = new(typeof(System.Single), "NaN");
					r_NaN.SetBelong(null);
				}
				return r_NaN;
			}
		}

		/// <summary>
		/// System.Single NegativeZero
		/// </summary>
		protected static RSystem.RSingle r_NegativeZero;
		public static RSystem.RSingle RNegativeZero
		{
			get
			{
				if(r_NegativeZero == null)
				{
					r_NegativeZero = new(typeof(System.Single), "NegativeZero");
					r_NegativeZero.SetBelong(null);
				}
				return r_NegativeZero;
			}
		}

		/// <summary>
		/// Boolean IsFinite(Single)
		/// </summary>
		protected static RMethod r_IsFinite_Single;
		public static RMethod RIsFinite_Single
		{
			get
			{
				if(r_IsFinite_Single == null)
				{
					r_IsFinite_Single = new(typeof(System.Single), "IsFinite", 0, typeof(System.Single));
					r_IsFinite_Single.SetBelong(null);
				}
				return r_IsFinite_Single;
			}
		}

		/// <summary>
		/// Boolean IsInfinity(Single)
		/// </summary>
		protected static RMethod r_IsInfinity_Single;
		public static RMethod RIsInfinity_Single
		{
			get
			{
				if(r_IsInfinity_Single == null)
				{
					r_IsInfinity_Single = new(typeof(System.Single), "IsInfinity", 0, typeof(System.Single));
					r_IsInfinity_Single.SetBelong(null);
				}
				return r_IsInfinity_Single;
			}
		}

		/// <summary>
		/// Boolean IsNaN(Single)
		/// </summary>
		protected static RMethod r_IsNaN_Single;
		public static RMethod RIsNaN_Single
		{
			get
			{
				if(r_IsNaN_Single == null)
				{
					r_IsNaN_Single = new(typeof(System.Single), "IsNaN", 0, typeof(System.Single));
					r_IsNaN_Single.SetBelong(null);
				}
				return r_IsNaN_Single;
			}
		}

		/// <summary>
		/// Boolean IsNegative(Single)
		/// </summary>
		protected static RMethod r_IsNegative_Single;
		public static RMethod RIsNegative_Single
		{
			get
			{
				if(r_IsNegative_Single == null)
				{
					r_IsNegative_Single = new(typeof(System.Single), "IsNegative", 0, typeof(System.Single));
					r_IsNegative_Single.SetBelong(null);
				}
				return r_IsNegative_Single;
			}
		}

		/// <summary>
		/// Boolean IsNegativeInfinity(Single)
		/// </summary>
		protected static RMethod r_IsNegativeInfinity_Single;
		public static RMethod RIsNegativeInfinity_Single
		{
			get
			{
				if(r_IsNegativeInfinity_Single == null)
				{
					r_IsNegativeInfinity_Single = new(typeof(System.Single), "IsNegativeInfinity", 0, typeof(System.Single));
					r_IsNegativeInfinity_Single.SetBelong(null);
				}
				return r_IsNegativeInfinity_Single;
			}
		}

		/// <summary>
		/// Boolean IsNormal(Single)
		/// </summary>
		protected static RMethod r_IsNormal_Single;
		public static RMethod RIsNormal_Single
		{
			get
			{
				if(r_IsNormal_Single == null)
				{
					r_IsNormal_Single = new(typeof(System.Single), "IsNormal", 0, typeof(System.Single));
					r_IsNormal_Single.SetBelong(null);
				}
				return r_IsNormal_Single;
			}
		}

		/// <summary>
		/// Boolean IsPositiveInfinity(Single)
		/// </summary>
		protected static RMethod r_IsPositiveInfinity_Single;
		public static RMethod RIsPositiveInfinity_Single
		{
			get
			{
				if(r_IsPositiveInfinity_Single == null)
				{
					r_IsPositiveInfinity_Single = new(typeof(System.Single), "IsPositiveInfinity", 0, typeof(System.Single));
					r_IsPositiveInfinity_Single.SetBelong(null);
				}
				return r_IsPositiveInfinity_Single;
			}
		}

		/// <summary>
		/// Boolean IsSubnormal(Single)
		/// </summary>
		protected static RMethod r_IsSubnormal_Single;
		public static RMethod RIsSubnormal_Single
		{
			get
			{
				if(r_IsSubnormal_Single == null)
				{
					r_IsSubnormal_Single = new(typeof(System.Single), "IsSubnormal", 0, typeof(System.Single));
					r_IsSubnormal_Single.SetBelong(null);
				}
				return r_IsSubnormal_Single;
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
		/// Int32 CompareTo(Single)
		/// </summary>
		protected RMethod r_CompareTo_Single;
		public virtual RMethod RCompareTo_Single
		{
			get
			{
				if(r_CompareTo_Single == null)
				{
					r_CompareTo_Single = new(this, "CompareTo", 0, typeof(System.Single));
					r_CompareTo_Single.SetBelong(this.instance);
				}
				return r_CompareTo_Single;
			}
		}

		/// <summary>
		/// Boolean op_Equality(Single, Single)
		/// </summary>
		protected static RMethod r_op_Equality_Single_Single;
		public static RMethod Rop_Equality_Single_Single
		{
			get
			{
				if(r_op_Equality_Single_Single == null)
				{
					r_op_Equality_Single_Single = new(typeof(System.Single), "op_Equality", 0, typeof(System.Single), typeof(System.Single));
					r_op_Equality_Single_Single.SetBelong(null);
				}
				return r_op_Equality_Single_Single;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(Single, Single)
		/// </summary>
		protected static RMethod r_op_Inequality_Single_Single;
		public static RMethod Rop_Inequality_Single_Single
		{
			get
			{
				if(r_op_Inequality_Single_Single == null)
				{
					r_op_Inequality_Single_Single = new(typeof(System.Single), "op_Inequality", 0, typeof(System.Single), typeof(System.Single));
					r_op_Inequality_Single_Single.SetBelong(null);
				}
				return r_op_Inequality_Single_Single;
			}
		}

		/// <summary>
		/// Boolean op_LessThan(Single, Single)
		/// </summary>
		protected static RMethod r_op_LessThan_Single_Single;
		public static RMethod Rop_LessThan_Single_Single
		{
			get
			{
				if(r_op_LessThan_Single_Single == null)
				{
					r_op_LessThan_Single_Single = new(typeof(System.Single), "op_LessThan", 0, typeof(System.Single), typeof(System.Single));
					r_op_LessThan_Single_Single.SetBelong(null);
				}
				return r_op_LessThan_Single_Single;
			}
		}

		/// <summary>
		/// Boolean op_GreaterThan(Single, Single)
		/// </summary>
		protected static RMethod r_op_GreaterThan_Single_Single;
		public static RMethod Rop_GreaterThan_Single_Single
		{
			get
			{
				if(r_op_GreaterThan_Single_Single == null)
				{
					r_op_GreaterThan_Single_Single = new(typeof(System.Single), "op_GreaterThan", 0, typeof(System.Single), typeof(System.Single));
					r_op_GreaterThan_Single_Single.SetBelong(null);
				}
				return r_op_GreaterThan_Single_Single;
			}
		}

		/// <summary>
		/// Boolean op_LessThanOrEqual(Single, Single)
		/// </summary>
		protected static RMethod r_op_LessThanOrEqual_Single_Single;
		public static RMethod Rop_LessThanOrEqual_Single_Single
		{
			get
			{
				if(r_op_LessThanOrEqual_Single_Single == null)
				{
					r_op_LessThanOrEqual_Single_Single = new(typeof(System.Single), "op_LessThanOrEqual", 0, typeof(System.Single), typeof(System.Single));
					r_op_LessThanOrEqual_Single_Single.SetBelong(null);
				}
				return r_op_LessThanOrEqual_Single_Single;
			}
		}

		/// <summary>
		/// Boolean op_GreaterThanOrEqual(Single, Single)
		/// </summary>
		protected static RMethod r_op_GreaterThanOrEqual_Single_Single;
		public static RMethod Rop_GreaterThanOrEqual_Single_Single
		{
			get
			{
				if(r_op_GreaterThanOrEqual_Single_Single == null)
				{
					r_op_GreaterThanOrEqual_Single_Single = new(typeof(System.Single), "op_GreaterThanOrEqual", 0, typeof(System.Single), typeof(System.Single));
					r_op_GreaterThanOrEqual_Single_Single.SetBelong(null);
				}
				return r_op_GreaterThanOrEqual_Single_Single;
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
		/// Boolean Equals(Single)
		/// </summary>
		protected RMethod r_Equals_Single;
		public virtual RMethod REquals_Single
		{
			get
			{
				if(r_Equals_Single == null)
				{
					r_Equals_Single = new(this, "Equals", 0, typeof(System.Single));
					r_Equals_Single.SetBelong(this.instance);
				}
				return r_Equals_Single;
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
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_ToString_String;
		public virtual RMethod RToString_String
		{
			get
			{
				if(r_ToString_String == null)
				{
					r_ToString_String = new(this, "ToString", 0, typeof(System.String));
					r_ToString_String.SetBelong(this.instance);
				}
				return r_ToString_String;
			}
		}

		/// <summary>
		/// System.String ToString(System.String, System.IFormatProvider)
		/// </summary>
		protected RMethod r_ToString_String_IFormatProvider;
		public virtual RMethod RToString_String_IFormatProvider
		{
			get
			{
				if(r_ToString_String_IFormatProvider == null)
				{
					r_ToString_String_IFormatProvider = new(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
					r_ToString_String_IFormatProvider.SetBelong(this.instance);
				}
				return r_ToString_String_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean TryFormat(System.Span`1[System.Char], Int32 ByRef, System.ReadOnlySpan`1[System.Char], System.IFormatProvider)
		/// </summary>
		protected RMethod r_TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider;
		public virtual RMethod RTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider
		{
			get
			{
				if(r_TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider == null)
				{
					r_TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider = new(this, "TryFormat", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Char)), typeof(System.Int32).MakeByRefType(), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider));
					r_TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider.SetBelong(this.instance);
				}
				return r_TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider;
			}
		}

		/// <summary>
		/// Single Parse(System.String)
		/// </summary>
		protected static RMethod r_Parse_String;
		public static RMethod RParse_String
		{
			get
			{
				if(r_Parse_String == null)
				{
					r_Parse_String = new(typeof(System.Single), "Parse", 0, typeof(System.String));
					r_Parse_String.SetBelong(null);
				}
				return r_Parse_String;
			}
		}

		/// <summary>
		/// Single Parse(System.String, System.Globalization.NumberStyles)
		/// </summary>
		protected static RMethod r_Parse_String_NumberStyles;
		public static RMethod RParse_String_NumberStyles
		{
			get
			{
				if(r_Parse_String_NumberStyles == null)
				{
					r_Parse_String_NumberStyles = new(typeof(System.Single), "Parse", 0, typeof(System.String), typeof(System.Globalization.NumberStyles));
					r_Parse_String_NumberStyles.SetBelong(null);
				}
				return r_Parse_String_NumberStyles;
			}
		}

		/// <summary>
		/// Single Parse(System.String, System.IFormatProvider)
		/// </summary>
		protected static RMethod r_Parse_String_IFormatProvider;
		public static RMethod RParse_String_IFormatProvider
		{
			get
			{
				if(r_Parse_String_IFormatProvider == null)
				{
					r_Parse_String_IFormatProvider = new(typeof(System.Single), "Parse", 0, typeof(System.String), typeof(System.IFormatProvider));
					r_Parse_String_IFormatProvider.SetBelong(null);
				}
				return r_Parse_String_IFormatProvider;
			}
		}

		/// <summary>
		/// Single Parse(System.String, System.Globalization.NumberStyles, System.IFormatProvider)
		/// </summary>
		protected static RMethod r_Parse_String_NumberStyles_IFormatProvider;
		public static RMethod RParse_String_NumberStyles_IFormatProvider
		{
			get
			{
				if(r_Parse_String_NumberStyles_IFormatProvider == null)
				{
					r_Parse_String_NumberStyles_IFormatProvider = new(typeof(System.Single), "Parse", 0, typeof(System.String), typeof(System.Globalization.NumberStyles), typeof(System.IFormatProvider));
					r_Parse_String_NumberStyles_IFormatProvider.SetBelong(null);
				}
				return r_Parse_String_NumberStyles_IFormatProvider;
			}
		}

		/// <summary>
		/// Single Parse(System.ReadOnlySpan`1[System.Char], System.Globalization.NumberStyles, System.IFormatProvider)
		/// </summary>
		protected static RMethod r_Parse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider;
		public static RMethod RParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider
		{
			get
			{
				if(r_Parse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider == null)
				{
					r_Parse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider = new(typeof(System.Single), "Parse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.NumberStyles), typeof(System.IFormatProvider));
					r_Parse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider.SetBelong(null);
				}
				return r_Parse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.String, Single ByRef)
		/// </summary>
		protected static RMethod r_TryParse_String_Out_Single;
		public static RMethod RTryParse_String_Out_Single
		{
			get
			{
				if(r_TryParse_String_Out_Single == null)
				{
					r_TryParse_String_Out_Single = new(typeof(System.Single), "TryParse", 0, typeof(System.String), typeof(System.Single).MakeByRefType());
					r_TryParse_String_Out_Single.SetBelong(null);
				}
				return r_TryParse_String_Out_Single;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], Single ByRef)
		/// </summary>
		protected static RMethod r_TryParse_ReadOnlySpan_d_Char_p__Out_Single;
		public static RMethod RTryParse_ReadOnlySpan_d_Char_p__Out_Single
		{
			get
			{
				if(r_TryParse_ReadOnlySpan_d_Char_p__Out_Single == null)
				{
					r_TryParse_ReadOnlySpan_d_Char_p__Out_Single = new(typeof(System.Single), "TryParse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Single).MakeByRefType());
					r_TryParse_ReadOnlySpan_d_Char_p__Out_Single.SetBelong(null);
				}
				return r_TryParse_ReadOnlySpan_d_Char_p__Out_Single;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.String, System.Globalization.NumberStyles, System.IFormatProvider, Single ByRef)
		/// </summary>
		protected static RMethod r_TryParse_String_NumberStyles_IFormatProvider_Out_Single;
		public static RMethod RTryParse_String_NumberStyles_IFormatProvider_Out_Single
		{
			get
			{
				if(r_TryParse_String_NumberStyles_IFormatProvider_Out_Single == null)
				{
					r_TryParse_String_NumberStyles_IFormatProvider_Out_Single = new(typeof(System.Single), "TryParse", 0, typeof(System.String), typeof(System.Globalization.NumberStyles), typeof(System.IFormatProvider), typeof(System.Single).MakeByRefType());
					r_TryParse_String_NumberStyles_IFormatProvider_Out_Single.SetBelong(null);
				}
				return r_TryParse_String_NumberStyles_IFormatProvider_Out_Single;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], System.Globalization.NumberStyles, System.IFormatProvider, Single ByRef)
		/// </summary>
		protected static RMethod r_TryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Single;
		public static RMethod RTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Single
		{
			get
			{
				if(r_TryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Single == null)
				{
					r_TryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Single = new(typeof(System.Single), "TryParse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.NumberStyles), typeof(System.IFormatProvider), typeof(System.Single).MakeByRefType());
					r_TryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Single.SetBelong(null);
				}
				return r_TryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Single;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], System.Globalization.NumberStyles, System.Globalization.NumberFormatInfo, Single ByRef)
		/// </summary>
		protected static RMethod r_TryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_Single;
		public static RMethod RTryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_Single
		{
			get
			{
				if(r_TryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_Single == null)
				{
					r_TryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_Single = new(typeof(System.Single), "TryParse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.NumberStyles), typeof(System.Globalization.NumberFormatInfo), typeof(System.Single).MakeByRefType());
					r_TryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_Single.SetBelong(null);
				}
				return r_TryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_Single;
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


        public RSingle() : base("System.Single")
        {
        }

        public RSingle(System.Object instance) : base("System.Single")
		{
            SetInstance(instance);
		}

        public RSingle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSingle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean IsFinite(System.Single @f)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f};
            var ___result = RIsFinite_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsInfinity(System.Single @f)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f};
            var ___result = RIsInfinity_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsNaN(System.Single @f)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f};
            var ___result = RIsNaN_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsNegative(System.Single @f)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f};
            var ___result = RIsNegative_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsNegativeInfinity(System.Single @f)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f};
            var ___result = RIsNegativeInfinity_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsNormal(System.Single @f)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f};
            var ___result = RIsNormal_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsPositiveInfinity(System.Single @f)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f};
            var ___result = RIsPositiveInfinity_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsSubnormal(System.Single @f)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f};
            var ___result = RIsSubnormal_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 CompareTo(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareTo(System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RCompareTo_Single.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(System.Single @left, System.Single @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Equality_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Single @left, System.Single @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Inequality_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_LessThan(System.Single @left, System.Single @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_LessThan_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_GreaterThan(System.Single @left, System.Single @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_GreaterThan_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_LessThanOrEqual(System.Single @left, System.Single @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_LessThanOrEqual_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_GreaterThanOrEqual(System.Single @left, System.Single @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_GreaterThanOrEqual_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Single @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Single.Invoke(___genericsType, ___parameters);

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


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean TryFormat(RSystem.RSpan<RSystem.RChar> @destination, out System.Int32 @charsWritten, RSystem.RReadOnlySpan<RSystem.RChar> @format, System.IFormatProvider @provider)
        {
			@charsWritten = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination.Value, @charsWritten, @format.Value, @provider};
            var ___result = RTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider.Invoke(___genericsType, ___parameters);
			@charsWritten = (System.Int32)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.Single Parse(System.String @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RParse_String.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Single Parse(System.String @s, System.Globalization.NumberStyles @style)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @style};
            var ___result = RParse_String_NumberStyles.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Single Parse(System.String @s, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @provider};
            var ___result = RParse_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Single Parse(System.String @s, System.Globalization.NumberStyles @style, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @style, @provider};
            var ___result = RParse_String_NumberStyles_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Single Parse(RSystem.RReadOnlySpan<RSystem.RChar> @s, System.Globalization.NumberStyles @style, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @style, @provider};
            var ___result = RParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Boolean TryParse(System.String @s, out System.Single @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @result};
            var ___result = RTryParse_String_Out_Single.Invoke(___genericsType, ___parameters);
			@result = (System.Single)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParse(RSystem.RReadOnlySpan<RSystem.RChar> @s, out System.Single @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @result};
            var ___result = RTryParse_ReadOnlySpan_d_Char_p__Out_Single.Invoke(___genericsType, ___parameters);
			@result = (System.Single)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParse(System.String @s, System.Globalization.NumberStyles @style, System.IFormatProvider @provider, out System.Single @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @style, @provider, @result};
            var ___result = RTryParse_String_NumberStyles_IFormatProvider_Out_Single.Invoke(___genericsType, ___parameters);
			@result = (System.Single)___parameters[3];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParse(RSystem.RReadOnlySpan<RSystem.RChar> @s, System.Globalization.NumberStyles @style, System.IFormatProvider @provider, out System.Single @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @style, @provider, @result};
            var ___result = RTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Single.Invoke(___genericsType, ___parameters);
			@result = (System.Single)___parameters[3];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParse(RSystem.RReadOnlySpan<RSystem.RChar> @s, System.Globalization.NumberStyles @style, System.Globalization.NumberFormatInfo @info, out System.Single @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @style, @info, @result};
            var ___result = RTryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_Single.Invoke(___genericsType, ___parameters);
			@result = (System.Single)___parameters[3];

            return (System.Boolean)___result;
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
