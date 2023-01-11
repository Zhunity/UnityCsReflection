using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.Double
	/// </summary>
    public partial class RDouble : RMember //
    {

		/// <summary>
		/// System.Double m_value
		/// </summary>
		protected RSystem.RDouble r_m_value;
		public virtual RSystem.RDouble Rm_value
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
		/// System.Double MinValue
		/// </summary>
		protected static RSystem.RDouble r_MinValue;
		public static RSystem.RDouble RMinValue
		{
			get
			{
				if(r_MinValue == null)
				{
					r_MinValue = new(typeof(System.Double), "MinValue");
					r_MinValue.SetBelong(null);
				}
				return r_MinValue;
			}
		}

		/// <summary>
		/// System.Double MaxValue
		/// </summary>
		protected static RSystem.RDouble r_MaxValue;
		public static RSystem.RDouble RMaxValue
		{
			get
			{
				if(r_MaxValue == null)
				{
					r_MaxValue = new(typeof(System.Double), "MaxValue");
					r_MaxValue.SetBelong(null);
				}
				return r_MaxValue;
			}
		}

		/// <summary>
		/// System.Double Epsilon
		/// </summary>
		protected static RSystem.RDouble r_Epsilon;
		public static RSystem.RDouble REpsilon
		{
			get
			{
				if(r_Epsilon == null)
				{
					r_Epsilon = new(typeof(System.Double), "Epsilon");
					r_Epsilon.SetBelong(null);
				}
				return r_Epsilon;
			}
		}

		/// <summary>
		/// System.Double NegativeInfinity
		/// </summary>
		protected static RSystem.RDouble r_NegativeInfinity;
		public static RSystem.RDouble RNegativeInfinity
		{
			get
			{
				if(r_NegativeInfinity == null)
				{
					r_NegativeInfinity = new(typeof(System.Double), "NegativeInfinity");
					r_NegativeInfinity.SetBelong(null);
				}
				return r_NegativeInfinity;
			}
		}

		/// <summary>
		/// System.Double PositiveInfinity
		/// </summary>
		protected static RSystem.RDouble r_PositiveInfinity;
		public static RSystem.RDouble RPositiveInfinity
		{
			get
			{
				if(r_PositiveInfinity == null)
				{
					r_PositiveInfinity = new(typeof(System.Double), "PositiveInfinity");
					r_PositiveInfinity.SetBelong(null);
				}
				return r_PositiveInfinity;
			}
		}

		/// <summary>
		/// System.Double NaN
		/// </summary>
		protected static RSystem.RDouble r_NaN;
		public static RSystem.RDouble RNaN
		{
			get
			{
				if(r_NaN == null)
				{
					r_NaN = new(typeof(System.Double), "NaN");
					r_NaN.SetBelong(null);
				}
				return r_NaN;
			}
		}

		/// <summary>
		/// System.Double NegativeZero
		/// </summary>
		protected static RSystem.RDouble r_NegativeZero;
		public static RSystem.RDouble RNegativeZero
		{
			get
			{
				if(r_NegativeZero == null)
				{
					r_NegativeZero = new(typeof(System.Double), "NegativeZero");
					r_NegativeZero.SetBelong(null);
				}
				return r_NegativeZero;
			}
		}

		/// <summary>
		/// Boolean IsFinite(Double)
		/// </summary>
		protected static RMethod r_IsFinite_Double;
		public static RMethod RIsFinite_Double
		{
			get
			{
				if(r_IsFinite_Double == null)
				{
					r_IsFinite_Double = new(typeof(System.Double), "IsFinite", 0, typeof(System.Double));
					r_IsFinite_Double.SetBelong(null);
				}
				return r_IsFinite_Double;
			}
		}

		/// <summary>
		/// Boolean IsInfinity(Double)
		/// </summary>
		protected static RMethod r_IsInfinity_Double;
		public static RMethod RIsInfinity_Double
		{
			get
			{
				if(r_IsInfinity_Double == null)
				{
					r_IsInfinity_Double = new(typeof(System.Double), "IsInfinity", 0, typeof(System.Double));
					r_IsInfinity_Double.SetBelong(null);
				}
				return r_IsInfinity_Double;
			}
		}

		/// <summary>
		/// Boolean IsNaN(Double)
		/// </summary>
		protected static RMethod r_IsNaN_Double;
		public static RMethod RIsNaN_Double
		{
			get
			{
				if(r_IsNaN_Double == null)
				{
					r_IsNaN_Double = new(typeof(System.Double), "IsNaN", 0, typeof(System.Double));
					r_IsNaN_Double.SetBelong(null);
				}
				return r_IsNaN_Double;
			}
		}

		/// <summary>
		/// Boolean IsNegative(Double)
		/// </summary>
		protected static RMethod r_IsNegative_Double;
		public static RMethod RIsNegative_Double
		{
			get
			{
				if(r_IsNegative_Double == null)
				{
					r_IsNegative_Double = new(typeof(System.Double), "IsNegative", 0, typeof(System.Double));
					r_IsNegative_Double.SetBelong(null);
				}
				return r_IsNegative_Double;
			}
		}

		/// <summary>
		/// Boolean IsNegativeInfinity(Double)
		/// </summary>
		protected static RMethod r_IsNegativeInfinity_Double;
		public static RMethod RIsNegativeInfinity_Double
		{
			get
			{
				if(r_IsNegativeInfinity_Double == null)
				{
					r_IsNegativeInfinity_Double = new(typeof(System.Double), "IsNegativeInfinity", 0, typeof(System.Double));
					r_IsNegativeInfinity_Double.SetBelong(null);
				}
				return r_IsNegativeInfinity_Double;
			}
		}

		/// <summary>
		/// Boolean IsNormal(Double)
		/// </summary>
		protected static RMethod r_IsNormal_Double;
		public static RMethod RIsNormal_Double
		{
			get
			{
				if(r_IsNormal_Double == null)
				{
					r_IsNormal_Double = new(typeof(System.Double), "IsNormal", 0, typeof(System.Double));
					r_IsNormal_Double.SetBelong(null);
				}
				return r_IsNormal_Double;
			}
		}

		/// <summary>
		/// Boolean IsPositiveInfinity(Double)
		/// </summary>
		protected static RMethod r_IsPositiveInfinity_Double;
		public static RMethod RIsPositiveInfinity_Double
		{
			get
			{
				if(r_IsPositiveInfinity_Double == null)
				{
					r_IsPositiveInfinity_Double = new(typeof(System.Double), "IsPositiveInfinity", 0, typeof(System.Double));
					r_IsPositiveInfinity_Double.SetBelong(null);
				}
				return r_IsPositiveInfinity_Double;
			}
		}

		/// <summary>
		/// Boolean IsSubnormal(Double)
		/// </summary>
		protected static RMethod r_IsSubnormal_Double;
		public static RMethod RIsSubnormal_Double
		{
			get
			{
				if(r_IsSubnormal_Double == null)
				{
					r_IsSubnormal_Double = new(typeof(System.Double), "IsSubnormal", 0, typeof(System.Double));
					r_IsSubnormal_Double.SetBelong(null);
				}
				return r_IsSubnormal_Double;
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
		/// Int32 CompareTo(Double)
		/// </summary>
		protected RMethod r_CompareTo_Double;
		public virtual RMethod RCompareTo_Double
		{
			get
			{
				if(r_CompareTo_Double == null)
				{
					r_CompareTo_Double = new(this, "CompareTo", 0, typeof(System.Double));
					r_CompareTo_Double.SetBelong(this.instance);
				}
				return r_CompareTo_Double;
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
		/// Boolean op_Equality(Double, Double)
		/// </summary>
		protected static RMethod r_op_Equality_Double_Double;
		public static RMethod Rop_Equality_Double_Double
		{
			get
			{
				if(r_op_Equality_Double_Double == null)
				{
					r_op_Equality_Double_Double = new(typeof(System.Double), "op_Equality", 0, typeof(System.Double), typeof(System.Double));
					r_op_Equality_Double_Double.SetBelong(null);
				}
				return r_op_Equality_Double_Double;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(Double, Double)
		/// </summary>
		protected static RMethod r_op_Inequality_Double_Double;
		public static RMethod Rop_Inequality_Double_Double
		{
			get
			{
				if(r_op_Inequality_Double_Double == null)
				{
					r_op_Inequality_Double_Double = new(typeof(System.Double), "op_Inequality", 0, typeof(System.Double), typeof(System.Double));
					r_op_Inequality_Double_Double.SetBelong(null);
				}
				return r_op_Inequality_Double_Double;
			}
		}

		/// <summary>
		/// Boolean op_LessThan(Double, Double)
		/// </summary>
		protected static RMethod r_op_LessThan_Double_Double;
		public static RMethod Rop_LessThan_Double_Double
		{
			get
			{
				if(r_op_LessThan_Double_Double == null)
				{
					r_op_LessThan_Double_Double = new(typeof(System.Double), "op_LessThan", 0, typeof(System.Double), typeof(System.Double));
					r_op_LessThan_Double_Double.SetBelong(null);
				}
				return r_op_LessThan_Double_Double;
			}
		}

		/// <summary>
		/// Boolean op_GreaterThan(Double, Double)
		/// </summary>
		protected static RMethod r_op_GreaterThan_Double_Double;
		public static RMethod Rop_GreaterThan_Double_Double
		{
			get
			{
				if(r_op_GreaterThan_Double_Double == null)
				{
					r_op_GreaterThan_Double_Double = new(typeof(System.Double), "op_GreaterThan", 0, typeof(System.Double), typeof(System.Double));
					r_op_GreaterThan_Double_Double.SetBelong(null);
				}
				return r_op_GreaterThan_Double_Double;
			}
		}

		/// <summary>
		/// Boolean op_LessThanOrEqual(Double, Double)
		/// </summary>
		protected static RMethod r_op_LessThanOrEqual_Double_Double;
		public static RMethod Rop_LessThanOrEqual_Double_Double
		{
			get
			{
				if(r_op_LessThanOrEqual_Double_Double == null)
				{
					r_op_LessThanOrEqual_Double_Double = new(typeof(System.Double), "op_LessThanOrEqual", 0, typeof(System.Double), typeof(System.Double));
					r_op_LessThanOrEqual_Double_Double.SetBelong(null);
				}
				return r_op_LessThanOrEqual_Double_Double;
			}
		}

		/// <summary>
		/// Boolean op_GreaterThanOrEqual(Double, Double)
		/// </summary>
		protected static RMethod r_op_GreaterThanOrEqual_Double_Double;
		public static RMethod Rop_GreaterThanOrEqual_Double_Double
		{
			get
			{
				if(r_op_GreaterThanOrEqual_Double_Double == null)
				{
					r_op_GreaterThanOrEqual_Double_Double = new(typeof(System.Double), "op_GreaterThanOrEqual", 0, typeof(System.Double), typeof(System.Double));
					r_op_GreaterThanOrEqual_Double_Double.SetBelong(null);
				}
				return r_op_GreaterThanOrEqual_Double_Double;
			}
		}

		/// <summary>
		/// Boolean Equals(Double)
		/// </summary>
		protected RMethod r_Equals_Double;
		public virtual RMethod REquals_Double
		{
			get
			{
				if(r_Equals_Double == null)
				{
					r_Equals_Double = new(this, "Equals", 0, typeof(System.Double));
					r_Equals_Double.SetBelong(this.instance);
				}
				return r_Equals_Double;
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
		/// Double Parse(System.String)
		/// </summary>
		protected static RMethod r_Parse_String;
		public static RMethod RParse_String
		{
			get
			{
				if(r_Parse_String == null)
				{
					r_Parse_String = new(typeof(System.Double), "Parse", 0, typeof(System.String));
					r_Parse_String.SetBelong(null);
				}
				return r_Parse_String;
			}
		}

		/// <summary>
		/// Double Parse(System.String, System.Globalization.NumberStyles)
		/// </summary>
		protected static RMethod r_Parse_String_NumberStyles;
		public static RMethod RParse_String_NumberStyles
		{
			get
			{
				if(r_Parse_String_NumberStyles == null)
				{
					r_Parse_String_NumberStyles = new(typeof(System.Double), "Parse", 0, typeof(System.String), typeof(System.Globalization.NumberStyles));
					r_Parse_String_NumberStyles.SetBelong(null);
				}
				return r_Parse_String_NumberStyles;
			}
		}

		/// <summary>
		/// Double Parse(System.String, System.IFormatProvider)
		/// </summary>
		protected static RMethod r_Parse_String_IFormatProvider;
		public static RMethod RParse_String_IFormatProvider
		{
			get
			{
				if(r_Parse_String_IFormatProvider == null)
				{
					r_Parse_String_IFormatProvider = new(typeof(System.Double), "Parse", 0, typeof(System.String), typeof(System.IFormatProvider));
					r_Parse_String_IFormatProvider.SetBelong(null);
				}
				return r_Parse_String_IFormatProvider;
			}
		}

		/// <summary>
		/// Double Parse(System.String, System.Globalization.NumberStyles, System.IFormatProvider)
		/// </summary>
		protected static RMethod r_Parse_String_NumberStyles_IFormatProvider;
		public static RMethod RParse_String_NumberStyles_IFormatProvider
		{
			get
			{
				if(r_Parse_String_NumberStyles_IFormatProvider == null)
				{
					r_Parse_String_NumberStyles_IFormatProvider = new(typeof(System.Double), "Parse", 0, typeof(System.String), typeof(System.Globalization.NumberStyles), typeof(System.IFormatProvider));
					r_Parse_String_NumberStyles_IFormatProvider.SetBelong(null);
				}
				return r_Parse_String_NumberStyles_IFormatProvider;
			}
		}

		/// <summary>
		/// Double Parse(System.ReadOnlySpan`1[System.Char], System.Globalization.NumberStyles, System.IFormatProvider)
		/// </summary>
		protected static RMethod r_Parse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider;
		public static RMethod RParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider
		{
			get
			{
				if(r_Parse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider == null)
				{
					r_Parse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider = new(typeof(System.Double), "Parse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.NumberStyles), typeof(System.IFormatProvider));
					r_Parse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider.SetBelong(null);
				}
				return r_Parse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.String, Double ByRef)
		/// </summary>
		protected static RMethod r_TryParse_String_Out_Double;
		public static RMethod RTryParse_String_Out_Double
		{
			get
			{
				if(r_TryParse_String_Out_Double == null)
				{
					r_TryParse_String_Out_Double = new(typeof(System.Double), "TryParse", 0, typeof(System.String), typeof(System.Double).MakeByRefType());
					r_TryParse_String_Out_Double.SetBelong(null);
				}
				return r_TryParse_String_Out_Double;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], Double ByRef)
		/// </summary>
		protected static RMethod r_TryParse_ReadOnlySpan_d_Char_p__Out_Double;
		public static RMethod RTryParse_ReadOnlySpan_d_Char_p__Out_Double
		{
			get
			{
				if(r_TryParse_ReadOnlySpan_d_Char_p__Out_Double == null)
				{
					r_TryParse_ReadOnlySpan_d_Char_p__Out_Double = new(typeof(System.Double), "TryParse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Double).MakeByRefType());
					r_TryParse_ReadOnlySpan_d_Char_p__Out_Double.SetBelong(null);
				}
				return r_TryParse_ReadOnlySpan_d_Char_p__Out_Double;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.String, System.Globalization.NumberStyles, System.IFormatProvider, Double ByRef)
		/// </summary>
		protected static RMethod r_TryParse_String_NumberStyles_IFormatProvider_Out_Double;
		public static RMethod RTryParse_String_NumberStyles_IFormatProvider_Out_Double
		{
			get
			{
				if(r_TryParse_String_NumberStyles_IFormatProvider_Out_Double == null)
				{
					r_TryParse_String_NumberStyles_IFormatProvider_Out_Double = new(typeof(System.Double), "TryParse", 0, typeof(System.String), typeof(System.Globalization.NumberStyles), typeof(System.IFormatProvider), typeof(System.Double).MakeByRefType());
					r_TryParse_String_NumberStyles_IFormatProvider_Out_Double.SetBelong(null);
				}
				return r_TryParse_String_NumberStyles_IFormatProvider_Out_Double;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], System.Globalization.NumberStyles, System.IFormatProvider, Double ByRef)
		/// </summary>
		protected static RMethod r_TryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Double;
		public static RMethod RTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Double
		{
			get
			{
				if(r_TryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Double == null)
				{
					r_TryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Double = new(typeof(System.Double), "TryParse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.NumberStyles), typeof(System.IFormatProvider), typeof(System.Double).MakeByRefType());
					r_TryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Double.SetBelong(null);
				}
				return r_TryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Double;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], System.Globalization.NumberStyles, System.Globalization.NumberFormatInfo, Double ByRef)
		/// </summary>
		protected static RMethod r_TryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_Double;
		public static RMethod RTryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_Double
		{
			get
			{
				if(r_TryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_Double == null)
				{
					r_TryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_Double = new(typeof(System.Double), "TryParse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.NumberStyles), typeof(System.Globalization.NumberFormatInfo), typeof(System.Double).MakeByRefType());
					r_TryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_Double.SetBelong(null);
				}
				return r_TryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_Double;
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


        public RDouble() : base("System.Double")
        {
        }

        public RDouble(System.Object instance) : base("System.Double")
		{
            SetInstance(instance);
		}

        public RDouble(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDouble(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean IsFinite(System.Double @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RIsFinite_Double.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsInfinity(System.Double @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RIsInfinity_Double.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsNaN(System.Double @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RIsNaN_Double.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsNegative(System.Double @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RIsNegative_Double.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsNegativeInfinity(System.Double @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RIsNegativeInfinity_Double.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsNormal(System.Double @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RIsNormal_Double.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsPositiveInfinity(System.Double @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RIsPositiveInfinity_Double.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsSubnormal(System.Double @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RIsSubnormal_Double.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 CompareTo(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareTo(System.Double @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RCompareTo_Double.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(System.Double @left, System.Double @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Equality_Double_Double.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Double @left, System.Double @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Inequality_Double_Double.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_LessThan(System.Double @left, System.Double @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_LessThan_Double_Double.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_GreaterThan(System.Double @left, System.Double @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_GreaterThan_Double_Double.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_LessThanOrEqual(System.Double @left, System.Double @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_LessThanOrEqual_Double_Double.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_GreaterThanOrEqual(System.Double @left, System.Double @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_GreaterThanOrEqual_Double_Double.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Double @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Double.Invoke(___genericsType, ___parameters);

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


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RToString_IFormatProvider.Invoke(___genericsType, ___parameters);

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


        public static System.Double Parse(System.String @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RParse_String.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public static System.Double Parse(System.String @s, System.Globalization.NumberStyles @style)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @style};
            var ___result = RParse_String_NumberStyles.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public static System.Double Parse(System.String @s, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @provider};
            var ___result = RParse_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public static System.Double Parse(System.String @s, System.Globalization.NumberStyles @style, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @style, @provider};
            var ___result = RParse_String_NumberStyles_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public static System.Double Parse(RSystem.RReadOnlySpan<RSystem.RChar> @s, System.Globalization.NumberStyles @style, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @style, @provider};
            var ___result = RParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public static System.Boolean TryParse(System.String @s, out System.Double @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @result};
            var ___result = RTryParse_String_Out_Double.Invoke(___genericsType, ___parameters);
			@result = (System.Double)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParse(RSystem.RReadOnlySpan<RSystem.RChar> @s, out System.Double @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @result};
            var ___result = RTryParse_ReadOnlySpan_d_Char_p__Out_Double.Invoke(___genericsType, ___parameters);
			@result = (System.Double)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParse(System.String @s, System.Globalization.NumberStyles @style, System.IFormatProvider @provider, out System.Double @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @style, @provider, @result};
            var ___result = RTryParse_String_NumberStyles_IFormatProvider_Out_Double.Invoke(___genericsType, ___parameters);
			@result = (System.Double)___parameters[3];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParse(RSystem.RReadOnlySpan<RSystem.RChar> @s, System.Globalization.NumberStyles @style, System.IFormatProvider @provider, out System.Double @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @style, @provider, @result};
            var ___result = RTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Double.Invoke(___genericsType, ___parameters);
			@result = (System.Double)___parameters[3];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParse(RSystem.RReadOnlySpan<RSystem.RChar> @s, System.Globalization.NumberStyles @style, System.Globalization.NumberFormatInfo @info, out System.Double @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @style, @info, @result};
            var ___result = RTryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_Double.Invoke(___genericsType, ___parameters);
			@result = (System.Double)___parameters[3];

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
