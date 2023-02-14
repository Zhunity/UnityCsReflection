
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.Double
	/// </summary>
    public partial class RDouble : RMember //
    {

		/// <summary>
		/// System.Double m_value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RDouble r_Fm_value;
		public virtual Hvak.Editor.Refleaction.RSystem.RDouble RFm_value
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
		/// System.Double MinValue
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RDouble r_FMinValue;
		public static Hvak.Editor.Refleaction.RSystem.RDouble RFMinValue
		{
			get
			{
				if(r_FMinValue == null)
				{
					r_FMinValue = new(typeof(System.Double), "MinValue");
					r_FMinValue.SetBelong(null);
				}
				return r_FMinValue;
			}
		}

		/// <summary>
		/// System.Double MaxValue
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RDouble r_FMaxValue;
		public static Hvak.Editor.Refleaction.RSystem.RDouble RFMaxValue
		{
			get
			{
				if(r_FMaxValue == null)
				{
					r_FMaxValue = new(typeof(System.Double), "MaxValue");
					r_FMaxValue.SetBelong(null);
				}
				return r_FMaxValue;
			}
		}

		/// <summary>
		/// System.Double Epsilon
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RDouble r_FEpsilon;
		public static Hvak.Editor.Refleaction.RSystem.RDouble RFEpsilon
		{
			get
			{
				if(r_FEpsilon == null)
				{
					r_FEpsilon = new(typeof(System.Double), "Epsilon");
					r_FEpsilon.SetBelong(null);
				}
				return r_FEpsilon;
			}
		}

		/// <summary>
		/// System.Double NegativeInfinity
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RDouble r_FNegativeInfinity;
		public static Hvak.Editor.Refleaction.RSystem.RDouble RFNegativeInfinity
		{
			get
			{
				if(r_FNegativeInfinity == null)
				{
					r_FNegativeInfinity = new(typeof(System.Double), "NegativeInfinity");
					r_FNegativeInfinity.SetBelong(null);
				}
				return r_FNegativeInfinity;
			}
		}

		/// <summary>
		/// System.Double PositiveInfinity
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RDouble r_FPositiveInfinity;
		public static Hvak.Editor.Refleaction.RSystem.RDouble RFPositiveInfinity
		{
			get
			{
				if(r_FPositiveInfinity == null)
				{
					r_FPositiveInfinity = new(typeof(System.Double), "PositiveInfinity");
					r_FPositiveInfinity.SetBelong(null);
				}
				return r_FPositiveInfinity;
			}
		}

		/// <summary>
		/// System.Double NaN
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RDouble r_FNaN;
		public static Hvak.Editor.Refleaction.RSystem.RDouble RFNaN
		{
			get
			{
				if(r_FNaN == null)
				{
					r_FNaN = new(typeof(System.Double), "NaN");
					r_FNaN.SetBelong(null);
				}
				return r_FNaN;
			}
		}

		/// <summary>
		/// System.Double NegativeZero
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RDouble r_FNegativeZero;
		public static Hvak.Editor.Refleaction.RSystem.RDouble RFNegativeZero
		{
			get
			{
				if(r_FNegativeZero == null)
				{
					r_FNegativeZero = new(typeof(System.Double), "NegativeZero");
					r_FNegativeZero.SetBelong(null);
				}
				return r_FNegativeZero;
			}
		}

		/// <summary>
		/// Boolean IsFinite(Double)
		/// </summary>
		protected static RMethod r_MIsFinite_Double;
		public static RMethod RMIsFinite_Double
		{
			get
			{
				if(r_MIsFinite_Double == null)
				{
					r_MIsFinite_Double = new(typeof(System.Double), "IsFinite", 0, typeof(System.Double));
					r_MIsFinite_Double.SetBelong(null);
				}
				return r_MIsFinite_Double;
			}
		}

		/// <summary>
		/// Boolean IsInfinity(Double)
		/// </summary>
		protected static RMethod r_MIsInfinity_Double;
		public static RMethod RMIsInfinity_Double
		{
			get
			{
				if(r_MIsInfinity_Double == null)
				{
					r_MIsInfinity_Double = new(typeof(System.Double), "IsInfinity", 0, typeof(System.Double));
					r_MIsInfinity_Double.SetBelong(null);
				}
				return r_MIsInfinity_Double;
			}
		}

		/// <summary>
		/// Boolean IsNaN(Double)
		/// </summary>
		protected static RMethod r_MIsNaN_Double;
		public static RMethod RMIsNaN_Double
		{
			get
			{
				if(r_MIsNaN_Double == null)
				{
					r_MIsNaN_Double = new(typeof(System.Double), "IsNaN", 0, typeof(System.Double));
					r_MIsNaN_Double.SetBelong(null);
				}
				return r_MIsNaN_Double;
			}
		}

		/// <summary>
		/// Boolean IsNegative(Double)
		/// </summary>
		protected static RMethod r_MIsNegative_Double;
		public static RMethod RMIsNegative_Double
		{
			get
			{
				if(r_MIsNegative_Double == null)
				{
					r_MIsNegative_Double = new(typeof(System.Double), "IsNegative", 0, typeof(System.Double));
					r_MIsNegative_Double.SetBelong(null);
				}
				return r_MIsNegative_Double;
			}
		}

		/// <summary>
		/// Boolean IsNegativeInfinity(Double)
		/// </summary>
		protected static RMethod r_MIsNegativeInfinity_Double;
		public static RMethod RMIsNegativeInfinity_Double
		{
			get
			{
				if(r_MIsNegativeInfinity_Double == null)
				{
					r_MIsNegativeInfinity_Double = new(typeof(System.Double), "IsNegativeInfinity", 0, typeof(System.Double));
					r_MIsNegativeInfinity_Double.SetBelong(null);
				}
				return r_MIsNegativeInfinity_Double;
			}
		}

		/// <summary>
		/// Boolean IsNormal(Double)
		/// </summary>
		protected static RMethod r_MIsNormal_Double;
		public static RMethod RMIsNormal_Double
		{
			get
			{
				if(r_MIsNormal_Double == null)
				{
					r_MIsNormal_Double = new(typeof(System.Double), "IsNormal", 0, typeof(System.Double));
					r_MIsNormal_Double.SetBelong(null);
				}
				return r_MIsNormal_Double;
			}
		}

		/// <summary>
		/// Boolean IsPositiveInfinity(Double)
		/// </summary>
		protected static RMethod r_MIsPositiveInfinity_Double;
		public static RMethod RMIsPositiveInfinity_Double
		{
			get
			{
				if(r_MIsPositiveInfinity_Double == null)
				{
					r_MIsPositiveInfinity_Double = new(typeof(System.Double), "IsPositiveInfinity", 0, typeof(System.Double));
					r_MIsPositiveInfinity_Double.SetBelong(null);
				}
				return r_MIsPositiveInfinity_Double;
			}
		}

		/// <summary>
		/// Boolean IsSubnormal(Double)
		/// </summary>
		protected static RMethod r_MIsSubnormal_Double;
		public static RMethod RMIsSubnormal_Double
		{
			get
			{
				if(r_MIsSubnormal_Double == null)
				{
					r_MIsSubnormal_Double = new(typeof(System.Double), "IsSubnormal", 0, typeof(System.Double));
					r_MIsSubnormal_Double.SetBelong(null);
				}
				return r_MIsSubnormal_Double;
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
		/// Int32 CompareTo(Double)
		/// </summary>
		protected RMethod r_MCompareTo_Double;
		public virtual RMethod RMCompareTo_Double
		{
			get
			{
				if(r_MCompareTo_Double == null)
				{
					r_MCompareTo_Double = new(this, "CompareTo", 0, typeof(System.Double));
					r_MCompareTo_Double.SetBelong(this.instance);
				}
				return r_MCompareTo_Double;
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
		/// Boolean op_Equality(Double, Double)
		/// </summary>
		protected static RMethod r_Mop_Equality_Double_Double;
		public static RMethod RMop_Equality_Double_Double
		{
			get
			{
				if(r_Mop_Equality_Double_Double == null)
				{
					r_Mop_Equality_Double_Double = new(typeof(System.Double), "op_Equality", 0, typeof(System.Double), typeof(System.Double));
					r_Mop_Equality_Double_Double.SetBelong(null);
				}
				return r_Mop_Equality_Double_Double;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(Double, Double)
		/// </summary>
		protected static RMethod r_Mop_Inequality_Double_Double;
		public static RMethod RMop_Inequality_Double_Double
		{
			get
			{
				if(r_Mop_Inequality_Double_Double == null)
				{
					r_Mop_Inequality_Double_Double = new(typeof(System.Double), "op_Inequality", 0, typeof(System.Double), typeof(System.Double));
					r_Mop_Inequality_Double_Double.SetBelong(null);
				}
				return r_Mop_Inequality_Double_Double;
			}
		}

		/// <summary>
		/// Boolean op_LessThan(Double, Double)
		/// </summary>
		protected static RMethod r_Mop_LessThan_Double_Double;
		public static RMethod RMop_LessThan_Double_Double
		{
			get
			{
				if(r_Mop_LessThan_Double_Double == null)
				{
					r_Mop_LessThan_Double_Double = new(typeof(System.Double), "op_LessThan", 0, typeof(System.Double), typeof(System.Double));
					r_Mop_LessThan_Double_Double.SetBelong(null);
				}
				return r_Mop_LessThan_Double_Double;
			}
		}

		/// <summary>
		/// Boolean op_GreaterThan(Double, Double)
		/// </summary>
		protected static RMethod r_Mop_GreaterThan_Double_Double;
		public static RMethod RMop_GreaterThan_Double_Double
		{
			get
			{
				if(r_Mop_GreaterThan_Double_Double == null)
				{
					r_Mop_GreaterThan_Double_Double = new(typeof(System.Double), "op_GreaterThan", 0, typeof(System.Double), typeof(System.Double));
					r_Mop_GreaterThan_Double_Double.SetBelong(null);
				}
				return r_Mop_GreaterThan_Double_Double;
			}
		}

		/// <summary>
		/// Boolean op_LessThanOrEqual(Double, Double)
		/// </summary>
		protected static RMethod r_Mop_LessThanOrEqual_Double_Double;
		public static RMethod RMop_LessThanOrEqual_Double_Double
		{
			get
			{
				if(r_Mop_LessThanOrEqual_Double_Double == null)
				{
					r_Mop_LessThanOrEqual_Double_Double = new(typeof(System.Double), "op_LessThanOrEqual", 0, typeof(System.Double), typeof(System.Double));
					r_Mop_LessThanOrEqual_Double_Double.SetBelong(null);
				}
				return r_Mop_LessThanOrEqual_Double_Double;
			}
		}

		/// <summary>
		/// Boolean op_GreaterThanOrEqual(Double, Double)
		/// </summary>
		protected static RMethod r_Mop_GreaterThanOrEqual_Double_Double;
		public static RMethod RMop_GreaterThanOrEqual_Double_Double
		{
			get
			{
				if(r_Mop_GreaterThanOrEqual_Double_Double == null)
				{
					r_Mop_GreaterThanOrEqual_Double_Double = new(typeof(System.Double), "op_GreaterThanOrEqual", 0, typeof(System.Double), typeof(System.Double));
					r_Mop_GreaterThanOrEqual_Double_Double.SetBelong(null);
				}
				return r_Mop_GreaterThanOrEqual_Double_Double;
			}
		}

		/// <summary>
		/// Boolean Equals(Double)
		/// </summary>
		protected RMethod r_MEquals_Double;
		public virtual RMethod RMEquals_Double
		{
			get
			{
				if(r_MEquals_Double == null)
				{
					r_MEquals_Double = new(this, "Equals", 0, typeof(System.Double));
					r_MEquals_Double.SetBelong(this.instance);
				}
				return r_MEquals_Double;
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
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_MToString_String;
		public virtual RMethod RMToString_String
		{
			get
			{
				if(r_MToString_String == null)
				{
					r_MToString_String = new(this, "ToString", 0, typeof(System.String));
					r_MToString_String.SetBelong(this.instance);
				}
				return r_MToString_String;
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
		/// System.String ToString(System.String, System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_String_IFormatProvider;
		public virtual RMethod RMToString_String_IFormatProvider
		{
			get
			{
				if(r_MToString_String_IFormatProvider == null)
				{
					r_MToString_String_IFormatProvider = new(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
					r_MToString_String_IFormatProvider.SetBelong(this.instance);
				}
				return r_MToString_String_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean TryFormat(System.Span`1[System.Char], Int32 ByRef, System.ReadOnlySpan`1[System.Char], System.IFormatProvider)
		/// </summary>
		protected RMethod r_MTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider;
		public virtual RMethod RMTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider
		{
			get
			{
				if(r_MTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider == null)
				{
					r_MTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider = new(this, "TryFormat", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Char)), typeof(System.Int32).MakeByRefType(), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider));
					r_MTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider.SetBelong(this.instance);
				}
				return r_MTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider;
			}
		}

		/// <summary>
		/// Double Parse(System.String)
		/// </summary>
		protected static RMethod r_MParse_String;
		public static RMethod RMParse_String
		{
			get
			{
				if(r_MParse_String == null)
				{
					r_MParse_String = new(typeof(System.Double), "Parse", 0, typeof(System.String));
					r_MParse_String.SetBelong(null);
				}
				return r_MParse_String;
			}
		}

		/// <summary>
		/// Double Parse(System.String, System.Globalization.NumberStyles)
		/// </summary>
		protected static RMethod r_MParse_String_NumberStyles;
		public static RMethod RMParse_String_NumberStyles
		{
			get
			{
				if(r_MParse_String_NumberStyles == null)
				{
					r_MParse_String_NumberStyles = new(typeof(System.Double), "Parse", 0, typeof(System.String), typeof(System.Globalization.NumberStyles));
					r_MParse_String_NumberStyles.SetBelong(null);
				}
				return r_MParse_String_NumberStyles;
			}
		}

		/// <summary>
		/// Double Parse(System.String, System.IFormatProvider)
		/// </summary>
		protected static RMethod r_MParse_String_IFormatProvider;
		public static RMethod RMParse_String_IFormatProvider
		{
			get
			{
				if(r_MParse_String_IFormatProvider == null)
				{
					r_MParse_String_IFormatProvider = new(typeof(System.Double), "Parse", 0, typeof(System.String), typeof(System.IFormatProvider));
					r_MParse_String_IFormatProvider.SetBelong(null);
				}
				return r_MParse_String_IFormatProvider;
			}
		}

		/// <summary>
		/// Double Parse(System.String, System.Globalization.NumberStyles, System.IFormatProvider)
		/// </summary>
		protected static RMethod r_MParse_String_NumberStyles_IFormatProvider;
		public static RMethod RMParse_String_NumberStyles_IFormatProvider
		{
			get
			{
				if(r_MParse_String_NumberStyles_IFormatProvider == null)
				{
					r_MParse_String_NumberStyles_IFormatProvider = new(typeof(System.Double), "Parse", 0, typeof(System.String), typeof(System.Globalization.NumberStyles), typeof(System.IFormatProvider));
					r_MParse_String_NumberStyles_IFormatProvider.SetBelong(null);
				}
				return r_MParse_String_NumberStyles_IFormatProvider;
			}
		}

		/// <summary>
		/// Double Parse(System.ReadOnlySpan`1[System.Char], System.Globalization.NumberStyles, System.IFormatProvider)
		/// </summary>
		protected static RMethod r_MParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider;
		public static RMethod RMParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider
		{
			get
			{
				if(r_MParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider == null)
				{
					r_MParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider = new(typeof(System.Double), "Parse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.NumberStyles), typeof(System.IFormatProvider));
					r_MParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider.SetBelong(null);
				}
				return r_MParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.String, Double ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_String_Out_Double;
		public static RMethod RMTryParse_String_Out_Double
		{
			get
			{
				if(r_MTryParse_String_Out_Double == null)
				{
					r_MTryParse_String_Out_Double = new(typeof(System.Double), "TryParse", 0, typeof(System.String), typeof(System.Double).MakeByRefType());
					r_MTryParse_String_Out_Double.SetBelong(null);
				}
				return r_MTryParse_String_Out_Double;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], Double ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_ReadOnlySpan_d_Char_p__Out_Double;
		public static RMethod RMTryParse_ReadOnlySpan_d_Char_p__Out_Double
		{
			get
			{
				if(r_MTryParse_ReadOnlySpan_d_Char_p__Out_Double == null)
				{
					r_MTryParse_ReadOnlySpan_d_Char_p__Out_Double = new(typeof(System.Double), "TryParse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Double).MakeByRefType());
					r_MTryParse_ReadOnlySpan_d_Char_p__Out_Double.SetBelong(null);
				}
				return r_MTryParse_ReadOnlySpan_d_Char_p__Out_Double;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.String, System.Globalization.NumberStyles, System.IFormatProvider, Double ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_String_NumberStyles_IFormatProvider_Out_Double;
		public static RMethod RMTryParse_String_NumberStyles_IFormatProvider_Out_Double
		{
			get
			{
				if(r_MTryParse_String_NumberStyles_IFormatProvider_Out_Double == null)
				{
					r_MTryParse_String_NumberStyles_IFormatProvider_Out_Double = new(typeof(System.Double), "TryParse", 0, typeof(System.String), typeof(System.Globalization.NumberStyles), typeof(System.IFormatProvider), typeof(System.Double).MakeByRefType());
					r_MTryParse_String_NumberStyles_IFormatProvider_Out_Double.SetBelong(null);
				}
				return r_MTryParse_String_NumberStyles_IFormatProvider_Out_Double;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], System.Globalization.NumberStyles, System.IFormatProvider, Double ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Double;
		public static RMethod RMTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Double
		{
			get
			{
				if(r_MTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Double == null)
				{
					r_MTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Double = new(typeof(System.Double), "TryParse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.NumberStyles), typeof(System.IFormatProvider), typeof(System.Double).MakeByRefType());
					r_MTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Double.SetBelong(null);
				}
				return r_MTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Double;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], System.Globalization.NumberStyles, System.Globalization.NumberFormatInfo, Double ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_Double;
		public static RMethod RMTryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_Double
		{
			get
			{
				if(r_MTryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_Double == null)
				{
					r_MTryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_Double = new(typeof(System.Double), "TryParse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.NumberStyles), typeof(System.Globalization.NumberFormatInfo), typeof(System.Double).MakeByRefType());
					r_MTryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_Double.SetBelong(null);
				}
				return r_MTryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_Double;
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
            var ___result = RMIsFinite_Double.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsInfinity(System.Double @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMIsInfinity_Double.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsNaN(System.Double @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMIsNaN_Double.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsNegative(System.Double @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMIsNegative_Double.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsNegativeInfinity(System.Double @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMIsNegativeInfinity_Double.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsNormal(System.Double @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMIsNormal_Double.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsPositiveInfinity(System.Double @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMIsPositiveInfinity_Double.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsSubnormal(System.Double @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMIsSubnormal_Double.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 CompareTo(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareTo(System.Double @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMCompareTo_Double.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(System.Double @left, System.Double @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Equality_Double_Double.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Double @left, System.Double @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Inequality_Double_Double.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_LessThan(System.Double @left, System.Double @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_LessThan_Double_Double.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_GreaterThan(System.Double @left, System.Double @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_GreaterThan_Double_Double.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_LessThanOrEqual(System.Double @left, System.Double @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_LessThanOrEqual_Double_Double.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_GreaterThanOrEqual(System.Double @left, System.Double @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_GreaterThanOrEqual_Double_Double.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Double @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Double.Invoke(___genericsType, ___parameters);

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


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean TryFormat(Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RSystem.RChar> @destination, out System.Int32 @charsWritten, Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @format, System.IFormatProvider @provider)
        {
			@charsWritten = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination.Value, @charsWritten, @format.Value, @provider};
            var ___result = RMTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider.Invoke(___genericsType, ___parameters);
			@charsWritten = (System.Int32)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.Double Parse(System.String @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RMParse_String.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public static System.Double Parse(System.String @s, System.Globalization.NumberStyles @style)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @style};
            var ___result = RMParse_String_NumberStyles.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public static System.Double Parse(System.String @s, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @provider};
            var ___result = RMParse_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public static System.Double Parse(System.String @s, System.Globalization.NumberStyles @style, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @style, @provider};
            var ___result = RMParse_String_NumberStyles_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public static System.Double Parse(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @s, System.Globalization.NumberStyles @style, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @style, @provider};
            var ___result = RMParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public static System.Boolean TryParse(System.String @s, out System.Double @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @result};
            var ___result = RMTryParse_String_Out_Double.Invoke(___genericsType, ___parameters);
			@result = (System.Double)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParse(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @s, out System.Double @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @result};
            var ___result = RMTryParse_ReadOnlySpan_d_Char_p__Out_Double.Invoke(___genericsType, ___parameters);
			@result = (System.Double)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParse(System.String @s, System.Globalization.NumberStyles @style, System.IFormatProvider @provider, out System.Double @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @style, @provider, @result};
            var ___result = RMTryParse_String_NumberStyles_IFormatProvider_Out_Double.Invoke(___genericsType, ___parameters);
			@result = (System.Double)___parameters[3];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParse(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @s, System.Globalization.NumberStyles @style, System.IFormatProvider @provider, out System.Double @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @style, @provider, @result};
            var ___result = RMTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Double.Invoke(___genericsType, ___parameters);
			@result = (System.Double)___parameters[3];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParse(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @s, System.Globalization.NumberStyles @style, System.Globalization.NumberFormatInfo @info, out System.Double @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @style, @info, @result};
            var ___result = RMTryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_Double.Invoke(___genericsType, ___parameters);
			@result = (System.Double)___parameters[3];

            return (System.Boolean)___result;
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
