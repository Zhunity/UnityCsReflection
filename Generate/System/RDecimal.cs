using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.Decimal
	/// </summary>
    public partial class RDecimal : RMember //
    {

		/// <summary>
		/// System.Int32 SignMask
		/// </summary>
		protected static RField r_SignMask;
		public static RField RSignMask
		{
			get
			{
				if(r_SignMask == null)
				{
					r_SignMask = new(typeof(System.Decimal), "SignMask");
					r_SignMask.SetBelong(null);
				}
				return r_SignMask;
			}
		}

		/// <summary>
		/// System.Int32 ScaleMask
		/// </summary>
		protected static RField r_ScaleMask;
		public static RField RScaleMask
		{
			get
			{
				if(r_ScaleMask == null)
				{
					r_ScaleMask = new(typeof(System.Decimal), "ScaleMask");
					r_ScaleMask.SetBelong(null);
				}
				return r_ScaleMask;
			}
		}

		/// <summary>
		/// System.Int32 ScaleShift
		/// </summary>
		protected static RField r_ScaleShift;
		public static RField RScaleShift
		{
			get
			{
				if(r_ScaleShift == null)
				{
					r_ScaleShift = new(typeof(System.Decimal), "ScaleShift");
					r_ScaleShift.SetBelong(null);
				}
				return r_ScaleShift;
			}
		}

		/// <summary>
		/// System.Decimal Zero
		/// </summary>
		protected static RSystem.RDecimal r_Zero;
		public static RSystem.RDecimal RZero
		{
			get
			{
				if(r_Zero == null)
				{
					r_Zero = new(typeof(System.Decimal), "Zero");
					r_Zero.SetBelong(null);
				}
				return r_Zero;
			}
		}

		/// <summary>
		/// System.Decimal One
		/// </summary>
		protected static RSystem.RDecimal r_One;
		public static RSystem.RDecimal ROne
		{
			get
			{
				if(r_One == null)
				{
					r_One = new(typeof(System.Decimal), "One");
					r_One.SetBelong(null);
				}
				return r_One;
			}
		}

		/// <summary>
		/// System.Decimal MinusOne
		/// </summary>
		protected static RSystem.RDecimal r_MinusOne;
		public static RSystem.RDecimal RMinusOne
		{
			get
			{
				if(r_MinusOne == null)
				{
					r_MinusOne = new(typeof(System.Decimal), "MinusOne");
					r_MinusOne.SetBelong(null);
				}
				return r_MinusOne;
			}
		}

		/// <summary>
		/// System.Decimal MaxValue
		/// </summary>
		protected static RSystem.RDecimal r_MaxValue;
		public static RSystem.RDecimal RMaxValue
		{
			get
			{
				if(r_MaxValue == null)
				{
					r_MaxValue = new(typeof(System.Decimal), "MaxValue");
					r_MaxValue.SetBelong(null);
				}
				return r_MaxValue;
			}
		}

		/// <summary>
		/// System.Decimal MinValue
		/// </summary>
		protected static RSystem.RDecimal r_MinValue;
		public static RSystem.RDecimal RMinValue
		{
			get
			{
				if(r_MinValue == null)
				{
					r_MinValue = new(typeof(System.Decimal), "MinValue");
					r_MinValue.SetBelong(null);
				}
				return r_MinValue;
			}
		}

		/// <summary>
		/// System.Int32 flags
		/// </summary>
		protected RField r_flags;
		public virtual RField Rflags
		{
			get
			{
				if(r_flags == null)
				{
					r_flags = new(this, "flags");
					r_flags.SetBelong(this.instance);
				}
				return r_flags;
			}
		}

		/// <summary>
		/// System.Int32 hi
		/// </summary>
		protected RField r_hi;
		public virtual RField Rhi
		{
			get
			{
				if(r_hi == null)
				{
					r_hi = new(this, "hi");
					r_hi.SetBelong(this.instance);
				}
				return r_hi;
			}
		}

		/// <summary>
		/// System.Int32 lo
		/// </summary>
		protected RField r_lo;
		public virtual RField Rlo
		{
			get
			{
				if(r_lo == null)
				{
					r_lo = new(this, "lo");
					r_lo.SetBelong(this.instance);
				}
				return r_lo;
			}
		}

		/// <summary>
		/// System.Int32 mid
		/// </summary>
		protected RField r_mid;
		public virtual RField Rmid
		{
			get
			{
				if(r_mid == null)
				{
					r_mid = new(this, "mid");
					r_mid.SetBelong(this.instance);
				}
				return r_mid;
			}
		}

		/// <summary>
		/// System.UInt64 ulomidLE
		/// </summary>
		protected RField r_ulomidLE;
		public virtual RField RulomidLE
		{
			get
			{
				if(r_ulomidLE == null)
				{
					r_ulomidLE = new(this, "ulomidLE");
					r_ulomidLE.SetBelong(this.instance);
				}
				return r_ulomidLE;
			}
		}

		/// <summary>
		/// UInt32 High
		/// </summary>
		protected RProperty r_High;
		public virtual RProperty RHigh
		{
			get
			{
				if(r_High == null)
				{
					r_High = new(this, "High", -1);
					r_High.SetBelong(this.instance);
				}
				return r_High;
			}
		}

		/// <summary>
		/// UInt32 Low
		/// </summary>
		protected RProperty r_Low;
		public virtual RProperty RLow
		{
			get
			{
				if(r_Low == null)
				{
					r_Low = new(this, "Low", -1);
					r_Low.SetBelong(this.instance);
				}
				return r_Low;
			}
		}

		/// <summary>
		/// UInt32 Mid
		/// </summary>
		protected RProperty r_Mid;
		public virtual RProperty RMid
		{
			get
			{
				if(r_Mid == null)
				{
					r_Mid = new(this, "Mid", -1);
					r_Mid.SetBelong(this.instance);
				}
				return r_Mid;
			}
		}

		/// <summary>
		/// Boolean IsNegative
		/// </summary>
		protected RProperty r_IsNegative;
		public virtual RProperty RIsNegative
		{
			get
			{
				if(r_IsNegative == null)
				{
					r_IsNegative = new(this, "IsNegative", -1);
					r_IsNegative.SetBelong(this.instance);
				}
				return r_IsNegative;
			}
		}

		/// <summary>
		/// Int32 Scale
		/// </summary>
		protected RProperty r_Scale;
		public virtual RProperty RScale
		{
			get
			{
				if(r_Scale == null)
				{
					r_Scale = new(this, "Scale", -1);
					r_Scale.SetBelong(this.instance);
				}
				return r_Scale;
			}
		}

		/// <summary>
		/// UInt64 Low64
		/// </summary>
		protected RProperty r_Low64;
		public virtual RProperty RLow64
		{
			get
			{
				if(r_Low64 == null)
				{
					r_Low64 = new(this, "Low64", -1);
					r_Low64.SetBelong(this.instance);
				}
				return r_Low64;
			}
		}

		/// <summary>
		/// DecCalc& AsMutable(System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_RAsMutable_Ref_Decimal;
		public static RMethod RAsMutable_Ref_Decimal
		{
			get
			{
				if(r_RAsMutable_Ref_Decimal == null)
				{
					r_RAsMutable_Ref_Decimal = new(typeof(System.Decimal), "AsMutable", 0, typeof(System.Decimal).MakeByRefType());
					r_RAsMutable_Ref_Decimal.SetBelong(null);
				}
				return r_RAsMutable_Ref_Decimal;
			}
		}

		/// <summary>
		/// UInt32 DecDivMod1E9(System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_RDecDivMod1E9_Ref_Decimal;
		public static RMethod RDecDivMod1E9_Ref_Decimal
		{
			get
			{
				if(r_RDecDivMod1E9_Ref_Decimal == null)
				{
					r_RDecDivMod1E9_Ref_Decimal = new(typeof(System.Decimal), "DecDivMod1E9", 0, typeof(System.Decimal).MakeByRefType());
					r_RDecDivMod1E9_Ref_Decimal.SetBelong(null);
				}
				return r_RDecDivMod1E9_Ref_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal FromOACurrency(Int64)
		/// </summary>
		protected static RMethod r_RFromOACurrency_Int64;
		public static RMethod RFromOACurrency_Int64
		{
			get
			{
				if(r_RFromOACurrency_Int64 == null)
				{
					r_RFromOACurrency_Int64 = new(typeof(System.Decimal), "FromOACurrency", 0, typeof(System.Int64));
					r_RFromOACurrency_Int64.SetBelong(null);
				}
				return r_RFromOACurrency_Int64;
			}
		}

		/// <summary>
		/// Int64 ToOACurrency(System.Decimal)
		/// </summary>
		protected static RMethod r_RToOACurrency_Decimal;
		public static RMethod RToOACurrency_Decimal
		{
			get
			{
				if(r_RToOACurrency_Decimal == null)
				{
					r_RToOACurrency_Decimal = new(typeof(System.Decimal), "ToOACurrency", 0, typeof(System.Decimal));
					r_RToOACurrency_Decimal.SetBelong(null);
				}
				return r_RToOACurrency_Decimal;
			}
		}

		/// <summary>
		/// Boolean IsValid(Int32)
		/// </summary>
		protected static RMethod r_RIsValid_Int32;
		public static RMethod RIsValid_Int32
		{
			get
			{
				if(r_RIsValid_Int32 == null)
				{
					r_RIsValid_Int32 = new(typeof(System.Decimal), "IsValid", 0, typeof(System.Int32));
					r_RIsValid_Int32.SetBelong(null);
				}
				return r_RIsValid_Int32;
			}
		}

		/// <summary>
		/// Void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(System.Object)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__Serialization__0__IDeserializationCallback__0__OnDeserialization_Object;
		public virtual RMethod RSystem__0__Runtime__0__Serialization__0__IDeserializationCallback__0__OnDeserialization_Object
		{
			get
			{
				if(r_RSystem__0__Runtime__0__Serialization__0__IDeserializationCallback__0__OnDeserialization_Object == null)
				{
					r_RSystem__0__Runtime__0__Serialization__0__IDeserializationCallback__0__OnDeserialization_Object = new(this, "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", 0, typeof(System.Object));
					r_RSystem__0__Runtime__0__Serialization__0__IDeserializationCallback__0__OnDeserialization_Object.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__Serialization__0__IDeserializationCallback__0__OnDeserialization_Object;
			}
		}

		/// <summary>
		/// System.Decimal Abs(System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_RAbs_Ref_Decimal;
		public static RMethod RAbs_Ref_Decimal
		{
			get
			{
				if(r_RAbs_Ref_Decimal == null)
				{
					r_RAbs_Ref_Decimal = new(typeof(System.Decimal), "Abs", 0, typeof(System.Decimal).MakeByRefType());
					r_RAbs_Ref_Decimal.SetBelong(null);
				}
				return r_RAbs_Ref_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal Add(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_RAdd_Decimal_Decimal;
		public static RMethod RAdd_Decimal_Decimal
		{
			get
			{
				if(r_RAdd_Decimal_Decimal == null)
				{
					r_RAdd_Decimal_Decimal = new(typeof(System.Decimal), "Add", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_RAdd_Decimal_Decimal.SetBelong(null);
				}
				return r_RAdd_Decimal_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal Ceiling(System.Decimal)
		/// </summary>
		protected static RMethod r_RCeiling_Decimal;
		public static RMethod RCeiling_Decimal
		{
			get
			{
				if(r_RCeiling_Decimal == null)
				{
					r_RCeiling_Decimal = new(typeof(System.Decimal), "Ceiling", 0, typeof(System.Decimal));
					r_RCeiling_Decimal.SetBelong(null);
				}
				return r_RCeiling_Decimal;
			}
		}

		/// <summary>
		/// Int32 Compare(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_RCompare_Decimal_Decimal;
		public static RMethod RCompare_Decimal_Decimal
		{
			get
			{
				if(r_RCompare_Decimal_Decimal == null)
				{
					r_RCompare_Decimal_Decimal = new(typeof(System.Decimal), "Compare", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_RCompare_Decimal_Decimal.SetBelong(null);
				}
				return r_RCompare_Decimal_Decimal;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Object)
		/// </summary>
		protected RMethod r_RCompareTo_Object;
		public virtual RMethod RCompareTo_Object
		{
			get
			{
				if(r_RCompareTo_Object == null)
				{
					r_RCompareTo_Object = new(this, "CompareTo", 0, typeof(System.Object));
					r_RCompareTo_Object.SetBelong(this.instance);
				}
				return r_RCompareTo_Object;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Decimal)
		/// </summary>
		protected RMethod r_RCompareTo_Decimal;
		public virtual RMethod RCompareTo_Decimal
		{
			get
			{
				if(r_RCompareTo_Decimal == null)
				{
					r_RCompareTo_Decimal = new(this, "CompareTo", 0, typeof(System.Decimal));
					r_RCompareTo_Decimal.SetBelong(this.instance);
				}
				return r_RCompareTo_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal Divide(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_RDivide_Decimal_Decimal;
		public static RMethod RDivide_Decimal_Decimal
		{
			get
			{
				if(r_RDivide_Decimal_Decimal == null)
				{
					r_RDivide_Decimal_Decimal = new(typeof(System.Decimal), "Divide", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_RDivide_Decimal_Decimal.SetBelong(null);
				}
				return r_RDivide_Decimal_Decimal;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Decimal)
		/// </summary>
		protected RMethod r_REquals_Decimal;
		public virtual RMethod REquals_Decimal
		{
			get
			{
				if(r_REquals_Decimal == null)
				{
					r_REquals_Decimal = new(this, "Equals", 0, typeof(System.Decimal));
					r_REquals_Decimal.SetBelong(this.instance);
				}
				return r_REquals_Decimal;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_REquals_Decimal_Decimal;
		public static RMethod REquals_Decimal_Decimal
		{
			get
			{
				if(r_REquals_Decimal_Decimal == null)
				{
					r_REquals_Decimal_Decimal = new(typeof(System.Decimal), "Equals", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_REquals_Decimal_Decimal.SetBelong(null);
				}
				return r_REquals_Decimal_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal Floor(System.Decimal)
		/// </summary>
		protected static RMethod r_RFloor_Decimal;
		public static RMethod RFloor_Decimal
		{
			get
			{
				if(r_RFloor_Decimal == null)
				{
					r_RFloor_Decimal = new(typeof(System.Decimal), "Floor", 0, typeof(System.Decimal));
					r_RFloor_Decimal.SetBelong(null);
				}
				return r_RFloor_Decimal;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
			}
		}

		/// <summary>
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_RToString_String;
		public virtual RMethod RToString_String
		{
			get
			{
				if(r_RToString_String == null)
				{
					r_RToString_String = new(this, "ToString", 0, typeof(System.String));
					r_RToString_String.SetBelong(this.instance);
				}
				return r_RToString_String;
			}
		}

		/// <summary>
		/// System.String ToString(System.IFormatProvider)
		/// </summary>
		protected RMethod r_RToString_IFormatProvider;
		public virtual RMethod RToString_IFormatProvider
		{
			get
			{
				if(r_RToString_IFormatProvider == null)
				{
					r_RToString_IFormatProvider = new(this, "ToString", 0, typeof(System.IFormatProvider));
					r_RToString_IFormatProvider.SetBelong(this.instance);
				}
				return r_RToString_IFormatProvider;
			}
		}

		/// <summary>
		/// System.String ToString(System.String, System.IFormatProvider)
		/// </summary>
		protected RMethod r_RToString_String_IFormatProvider;
		public virtual RMethod RToString_String_IFormatProvider
		{
			get
			{
				if(r_RToString_String_IFormatProvider == null)
				{
					r_RToString_String_IFormatProvider = new(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
					r_RToString_String_IFormatProvider.SetBelong(this.instance);
				}
				return r_RToString_String_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean TryFormat(System.Span`1[System.Char], Int32 ByRef, System.ReadOnlySpan`1[System.Char], System.IFormatProvider)
		/// </summary>
		protected RMethod r_RTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider;
		public virtual RMethod RTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider
		{
			get
			{
				if(r_RTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider == null)
				{
					r_RTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider = new(this, "TryFormat", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Char)), typeof(System.Int32).MakeByRefType(), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider));
					r_RTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider.SetBelong(this.instance);
				}
				return r_RTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider;
			}
		}

		/// <summary>
		/// System.Decimal Parse(System.String)
		/// </summary>
		protected static RMethod r_RParse_String;
		public static RMethod RParse_String
		{
			get
			{
				if(r_RParse_String == null)
				{
					r_RParse_String = new(typeof(System.Decimal), "Parse", 0, typeof(System.String));
					r_RParse_String.SetBelong(null);
				}
				return r_RParse_String;
			}
		}

		/// <summary>
		/// System.Decimal Parse(System.String, System.Globalization.NumberStyles)
		/// </summary>
		protected static RMethod r_RParse_String_NumberStyles;
		public static RMethod RParse_String_NumberStyles
		{
			get
			{
				if(r_RParse_String_NumberStyles == null)
				{
					r_RParse_String_NumberStyles = new(typeof(System.Decimal), "Parse", 0, typeof(System.String), typeof(System.Globalization.NumberStyles));
					r_RParse_String_NumberStyles.SetBelong(null);
				}
				return r_RParse_String_NumberStyles;
			}
		}

		/// <summary>
		/// System.Decimal Parse(System.String, System.IFormatProvider)
		/// </summary>
		protected static RMethod r_RParse_String_IFormatProvider;
		public static RMethod RParse_String_IFormatProvider
		{
			get
			{
				if(r_RParse_String_IFormatProvider == null)
				{
					r_RParse_String_IFormatProvider = new(typeof(System.Decimal), "Parse", 0, typeof(System.String), typeof(System.IFormatProvider));
					r_RParse_String_IFormatProvider.SetBelong(null);
				}
				return r_RParse_String_IFormatProvider;
			}
		}

		/// <summary>
		/// System.Decimal Parse(System.String, System.Globalization.NumberStyles, System.IFormatProvider)
		/// </summary>
		protected static RMethod r_RParse_String_NumberStyles_IFormatProvider;
		public static RMethod RParse_String_NumberStyles_IFormatProvider
		{
			get
			{
				if(r_RParse_String_NumberStyles_IFormatProvider == null)
				{
					r_RParse_String_NumberStyles_IFormatProvider = new(typeof(System.Decimal), "Parse", 0, typeof(System.String), typeof(System.Globalization.NumberStyles), typeof(System.IFormatProvider));
					r_RParse_String_NumberStyles_IFormatProvider.SetBelong(null);
				}
				return r_RParse_String_NumberStyles_IFormatProvider;
			}
		}

		/// <summary>
		/// System.Decimal Parse(System.ReadOnlySpan`1[System.Char], System.Globalization.NumberStyles, System.IFormatProvider)
		/// </summary>
		protected static RMethod r_RParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider;
		public static RMethod RParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider
		{
			get
			{
				if(r_RParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider == null)
				{
					r_RParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider = new(typeof(System.Decimal), "Parse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.NumberStyles), typeof(System.IFormatProvider));
					r_RParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider.SetBelong(null);
				}
				return r_RParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.String, System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_RTryParse_String_Out_Decimal;
		public static RMethod RTryParse_String_Out_Decimal
		{
			get
			{
				if(r_RTryParse_String_Out_Decimal == null)
				{
					r_RTryParse_String_Out_Decimal = new(typeof(System.Decimal), "TryParse", 0, typeof(System.String), typeof(System.Decimal).MakeByRefType());
					r_RTryParse_String_Out_Decimal.SetBelong(null);
				}
				return r_RTryParse_String_Out_Decimal;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_RTryParse_ReadOnlySpan_d_Char_p__Out_Decimal;
		public static RMethod RTryParse_ReadOnlySpan_d_Char_p__Out_Decimal
		{
			get
			{
				if(r_RTryParse_ReadOnlySpan_d_Char_p__Out_Decimal == null)
				{
					r_RTryParse_ReadOnlySpan_d_Char_p__Out_Decimal = new(typeof(System.Decimal), "TryParse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Decimal).MakeByRefType());
					r_RTryParse_ReadOnlySpan_d_Char_p__Out_Decimal.SetBelong(null);
				}
				return r_RTryParse_ReadOnlySpan_d_Char_p__Out_Decimal;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.String, System.Globalization.NumberStyles, System.IFormatProvider, System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_RTryParse_String_NumberStyles_IFormatProvider_Out_Decimal;
		public static RMethod RTryParse_String_NumberStyles_IFormatProvider_Out_Decimal
		{
			get
			{
				if(r_RTryParse_String_NumberStyles_IFormatProvider_Out_Decimal == null)
				{
					r_RTryParse_String_NumberStyles_IFormatProvider_Out_Decimal = new(typeof(System.Decimal), "TryParse", 0, typeof(System.String), typeof(System.Globalization.NumberStyles), typeof(System.IFormatProvider), typeof(System.Decimal).MakeByRefType());
					r_RTryParse_String_NumberStyles_IFormatProvider_Out_Decimal.SetBelong(null);
				}
				return r_RTryParse_String_NumberStyles_IFormatProvider_Out_Decimal;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], System.Globalization.NumberStyles, System.IFormatProvider, System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_RTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Decimal;
		public static RMethod RTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Decimal
		{
			get
			{
				if(r_RTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Decimal == null)
				{
					r_RTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Decimal = new(typeof(System.Decimal), "TryParse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.NumberStyles), typeof(System.IFormatProvider), typeof(System.Decimal).MakeByRefType());
					r_RTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Decimal.SetBelong(null);
				}
				return r_RTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Decimal;
			}
		}

		/// <summary>
		/// Int32[] GetBits(System.Decimal)
		/// </summary>
		protected static RMethod r_RGetBits_Decimal;
		public static RMethod RGetBits_Decimal
		{
			get
			{
				if(r_RGetBits_Decimal == null)
				{
					r_RGetBits_Decimal = new(typeof(System.Decimal), "GetBits", 0, typeof(System.Decimal));
					r_RGetBits_Decimal.SetBelong(null);
				}
				return r_RGetBits_Decimal;
			}
		}

		/// <summary>
		/// Void GetBytes(System.Decimal ByRef, Byte[])
		/// </summary>
		protected static RMethod r_RGetBytes_In_Decimal_ByteArray;
		public static RMethod RGetBytes_In_Decimal_ByteArray
		{
			get
			{
				if(r_RGetBytes_In_Decimal_ByteArray == null)
				{
					r_RGetBytes_In_Decimal_ByteArray = new(typeof(System.Decimal), "GetBytes", 0, typeof(System.Decimal).MakeByRefType(), typeof(System.Byte).MakeArrayType());
					r_RGetBytes_In_Decimal_ByteArray.SetBelong(null);
				}
				return r_RGetBytes_In_Decimal_ByteArray;
			}
		}

		/// <summary>
		/// System.Decimal ToDecimal(Byte[])
		/// </summary>
		protected static RMethod r_RToDecimal_ByteArray;
		public static RMethod RToDecimal_ByteArray
		{
			get
			{
				if(r_RToDecimal_ByteArray == null)
				{
					r_RToDecimal_ByteArray = new(typeof(System.Decimal), "ToDecimal", 0, typeof(System.Byte).MakeArrayType());
					r_RToDecimal_ByteArray.SetBelong(null);
				}
				return r_RToDecimal_ByteArray;
			}
		}

		/// <summary>
		/// System.Decimal& Max(System.Decimal ByRef, System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_RMax_Ref_Decimal_Ref_Decimal;
		public static RMethod RMax_Ref_Decimal_Ref_Decimal
		{
			get
			{
				if(r_RMax_Ref_Decimal_Ref_Decimal == null)
				{
					r_RMax_Ref_Decimal_Ref_Decimal = new(typeof(System.Decimal), "Max", 0, typeof(System.Decimal).MakeByRefType(), typeof(System.Decimal).MakeByRefType());
					r_RMax_Ref_Decimal_Ref_Decimal.SetBelong(null);
				}
				return r_RMax_Ref_Decimal_Ref_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal& Min(System.Decimal ByRef, System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_RMin_Ref_Decimal_Ref_Decimal;
		public static RMethod RMin_Ref_Decimal_Ref_Decimal
		{
			get
			{
				if(r_RMin_Ref_Decimal_Ref_Decimal == null)
				{
					r_RMin_Ref_Decimal_Ref_Decimal = new(typeof(System.Decimal), "Min", 0, typeof(System.Decimal).MakeByRefType(), typeof(System.Decimal).MakeByRefType());
					r_RMin_Ref_Decimal_Ref_Decimal.SetBelong(null);
				}
				return r_RMin_Ref_Decimal_Ref_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal Remainder(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_RRemainder_Decimal_Decimal;
		public static RMethod RRemainder_Decimal_Decimal
		{
			get
			{
				if(r_RRemainder_Decimal_Decimal == null)
				{
					r_RRemainder_Decimal_Decimal = new(typeof(System.Decimal), "Remainder", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_RRemainder_Decimal_Decimal.SetBelong(null);
				}
				return r_RRemainder_Decimal_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal Multiply(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_RMultiply_Decimal_Decimal;
		public static RMethod RMultiply_Decimal_Decimal
		{
			get
			{
				if(r_RMultiply_Decimal_Decimal == null)
				{
					r_RMultiply_Decimal_Decimal = new(typeof(System.Decimal), "Multiply", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_RMultiply_Decimal_Decimal.SetBelong(null);
				}
				return r_RMultiply_Decimal_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal Negate(System.Decimal)
		/// </summary>
		protected static RMethod r_RNegate_Decimal;
		public static RMethod RNegate_Decimal
		{
			get
			{
				if(r_RNegate_Decimal == null)
				{
					r_RNegate_Decimal = new(typeof(System.Decimal), "Negate", 0, typeof(System.Decimal));
					r_RNegate_Decimal.SetBelong(null);
				}
				return r_RNegate_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal Round(System.Decimal)
		/// </summary>
		protected static RMethod r_RRound_Decimal;
		public static RMethod RRound_Decimal
		{
			get
			{
				if(r_RRound_Decimal == null)
				{
					r_RRound_Decimal = new(typeof(System.Decimal), "Round", 0, typeof(System.Decimal));
					r_RRound_Decimal.SetBelong(null);
				}
				return r_RRound_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal Round(System.Decimal, Int32)
		/// </summary>
		protected static RMethod r_RRound_Decimal_Int32;
		public static RMethod RRound_Decimal_Int32
		{
			get
			{
				if(r_RRound_Decimal_Int32 == null)
				{
					r_RRound_Decimal_Int32 = new(typeof(System.Decimal), "Round", 0, typeof(System.Decimal), typeof(System.Int32));
					r_RRound_Decimal_Int32.SetBelong(null);
				}
				return r_RRound_Decimal_Int32;
			}
		}

		/// <summary>
		/// System.Decimal Round(System.Decimal, System.MidpointRounding)
		/// </summary>
		protected static RMethod r_RRound_Decimal_MidpointRounding;
		public static RMethod RRound_Decimal_MidpointRounding
		{
			get
			{
				if(r_RRound_Decimal_MidpointRounding == null)
				{
					r_RRound_Decimal_MidpointRounding = new(typeof(System.Decimal), "Round", 0, typeof(System.Decimal), typeof(System.MidpointRounding));
					r_RRound_Decimal_MidpointRounding.SetBelong(null);
				}
				return r_RRound_Decimal_MidpointRounding;
			}
		}

		/// <summary>
		/// System.Decimal Round(System.Decimal, Int32, System.MidpointRounding)
		/// </summary>
		protected static RMethod r_RRound_Decimal_Int32_MidpointRounding;
		public static RMethod RRound_Decimal_Int32_MidpointRounding
		{
			get
			{
				if(r_RRound_Decimal_Int32_MidpointRounding == null)
				{
					r_RRound_Decimal_Int32_MidpointRounding = new(typeof(System.Decimal), "Round", 0, typeof(System.Decimal), typeof(System.Int32), typeof(System.MidpointRounding));
					r_RRound_Decimal_Int32_MidpointRounding.SetBelong(null);
				}
				return r_RRound_Decimal_Int32_MidpointRounding;
			}
		}

		/// <summary>
		/// System.Decimal Round(System.Decimal ByRef, Int32, System.MidpointRounding)
		/// </summary>
		protected static RMethod r_RRound_Ref_Decimal_Int32_MidpointRounding;
		public static RMethod RRound_Ref_Decimal_Int32_MidpointRounding
		{
			get
			{
				if(r_RRound_Ref_Decimal_Int32_MidpointRounding == null)
				{
					r_RRound_Ref_Decimal_Int32_MidpointRounding = new(typeof(System.Decimal), "Round", 0, typeof(System.Decimal).MakeByRefType(), typeof(System.Int32), typeof(System.MidpointRounding));
					r_RRound_Ref_Decimal_Int32_MidpointRounding.SetBelong(null);
				}
				return r_RRound_Ref_Decimal_Int32_MidpointRounding;
			}
		}

		/// <summary>
		/// Int32 Sign(System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_RSign_Ref_Decimal;
		public static RMethod RSign_Ref_Decimal
		{
			get
			{
				if(r_RSign_Ref_Decimal == null)
				{
					r_RSign_Ref_Decimal = new(typeof(System.Decimal), "Sign", 0, typeof(System.Decimal).MakeByRefType());
					r_RSign_Ref_Decimal.SetBelong(null);
				}
				return r_RSign_Ref_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal Subtract(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_RSubtract_Decimal_Decimal;
		public static RMethod RSubtract_Decimal_Decimal
		{
			get
			{
				if(r_RSubtract_Decimal_Decimal == null)
				{
					r_RSubtract_Decimal_Decimal = new(typeof(System.Decimal), "Subtract", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_RSubtract_Decimal_Decimal.SetBelong(null);
				}
				return r_RSubtract_Decimal_Decimal;
			}
		}

		/// <summary>
		/// Byte ToByte(System.Decimal)
		/// </summary>
		protected static RMethod r_RToByte_Decimal;
		public static RMethod RToByte_Decimal
		{
			get
			{
				if(r_RToByte_Decimal == null)
				{
					r_RToByte_Decimal = new(typeof(System.Decimal), "ToByte", 0, typeof(System.Decimal));
					r_RToByte_Decimal.SetBelong(null);
				}
				return r_RToByte_Decimal;
			}
		}

		/// <summary>
		/// SByte ToSByte(System.Decimal)
		/// </summary>
		protected static RMethod r_RToSByte_Decimal;
		public static RMethod RToSByte_Decimal
		{
			get
			{
				if(r_RToSByte_Decimal == null)
				{
					r_RToSByte_Decimal = new(typeof(System.Decimal), "ToSByte", 0, typeof(System.Decimal));
					r_RToSByte_Decimal.SetBelong(null);
				}
				return r_RToSByte_Decimal;
			}
		}

		/// <summary>
		/// Int16 ToInt16(System.Decimal)
		/// </summary>
		protected static RMethod r_RToInt16_Decimal;
		public static RMethod RToInt16_Decimal
		{
			get
			{
				if(r_RToInt16_Decimal == null)
				{
					r_RToInt16_Decimal = new(typeof(System.Decimal), "ToInt16", 0, typeof(System.Decimal));
					r_RToInt16_Decimal.SetBelong(null);
				}
				return r_RToInt16_Decimal;
			}
		}

		/// <summary>
		/// Double ToDouble(System.Decimal)
		/// </summary>
		protected static RMethod r_RToDouble_Decimal;
		public static RMethod RToDouble_Decimal
		{
			get
			{
				if(r_RToDouble_Decimal == null)
				{
					r_RToDouble_Decimal = new(typeof(System.Decimal), "ToDouble", 0, typeof(System.Decimal));
					r_RToDouble_Decimal.SetBelong(null);
				}
				return r_RToDouble_Decimal;
			}
		}

		/// <summary>
		/// Int32 ToInt32(System.Decimal)
		/// </summary>
		protected static RMethod r_RToInt32_Decimal;
		public static RMethod RToInt32_Decimal
		{
			get
			{
				if(r_RToInt32_Decimal == null)
				{
					r_RToInt32_Decimal = new(typeof(System.Decimal), "ToInt32", 0, typeof(System.Decimal));
					r_RToInt32_Decimal.SetBelong(null);
				}
				return r_RToInt32_Decimal;
			}
		}

		/// <summary>
		/// Int64 ToInt64(System.Decimal)
		/// </summary>
		protected static RMethod r_RToInt64_Decimal;
		public static RMethod RToInt64_Decimal
		{
			get
			{
				if(r_RToInt64_Decimal == null)
				{
					r_RToInt64_Decimal = new(typeof(System.Decimal), "ToInt64", 0, typeof(System.Decimal));
					r_RToInt64_Decimal.SetBelong(null);
				}
				return r_RToInt64_Decimal;
			}
		}

		/// <summary>
		/// UInt16 ToUInt16(System.Decimal)
		/// </summary>
		protected static RMethod r_RToUInt16_Decimal;
		public static RMethod RToUInt16_Decimal
		{
			get
			{
				if(r_RToUInt16_Decimal == null)
				{
					r_RToUInt16_Decimal = new(typeof(System.Decimal), "ToUInt16", 0, typeof(System.Decimal));
					r_RToUInt16_Decimal.SetBelong(null);
				}
				return r_RToUInt16_Decimal;
			}
		}

		/// <summary>
		/// UInt32 ToUInt32(System.Decimal)
		/// </summary>
		protected static RMethod r_RToUInt32_Decimal;
		public static RMethod RToUInt32_Decimal
		{
			get
			{
				if(r_RToUInt32_Decimal == null)
				{
					r_RToUInt32_Decimal = new(typeof(System.Decimal), "ToUInt32", 0, typeof(System.Decimal));
					r_RToUInt32_Decimal.SetBelong(null);
				}
				return r_RToUInt32_Decimal;
			}
		}

		/// <summary>
		/// UInt64 ToUInt64(System.Decimal)
		/// </summary>
		protected static RMethod r_RToUInt64_Decimal;
		public static RMethod RToUInt64_Decimal
		{
			get
			{
				if(r_RToUInt64_Decimal == null)
				{
					r_RToUInt64_Decimal = new(typeof(System.Decimal), "ToUInt64", 0, typeof(System.Decimal));
					r_RToUInt64_Decimal.SetBelong(null);
				}
				return r_RToUInt64_Decimal;
			}
		}

		/// <summary>
		/// Single ToSingle(System.Decimal)
		/// </summary>
		protected static RMethod r_RToSingle_Decimal;
		public static RMethod RToSingle_Decimal
		{
			get
			{
				if(r_RToSingle_Decimal == null)
				{
					r_RToSingle_Decimal = new(typeof(System.Decimal), "ToSingle", 0, typeof(System.Decimal));
					r_RToSingle_Decimal.SetBelong(null);
				}
				return r_RToSingle_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal Truncate(System.Decimal)
		/// </summary>
		protected static RMethod r_RTruncate_Decimal;
		public static RMethod RTruncate_Decimal
		{
			get
			{
				if(r_RTruncate_Decimal == null)
				{
					r_RTruncate_Decimal = new(typeof(System.Decimal), "Truncate", 0, typeof(System.Decimal));
					r_RTruncate_Decimal.SetBelong(null);
				}
				return r_RTruncate_Decimal;
			}
		}

		/// <summary>
		/// Void Truncate(System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_RTruncate_Ref_Decimal;
		public static RMethod RTruncate_Ref_Decimal
		{
			get
			{
				if(r_RTruncate_Ref_Decimal == null)
				{
					r_RTruncate_Ref_Decimal = new(typeof(System.Decimal), "Truncate", 0, typeof(System.Decimal).MakeByRefType());
					r_RTruncate_Ref_Decimal.SetBelong(null);
				}
				return r_RTruncate_Ref_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal op_Implicit(Byte)
		/// </summary>
		protected static RMethod r_Rop_Implicit_Byte;
		public static RMethod Rop_Implicit_Byte
		{
			get
			{
				if(r_Rop_Implicit_Byte == null)
				{
					r_Rop_Implicit_Byte = new(typeof(System.Decimal), "op_Implicit", 0, typeof(System.Byte));
					r_Rop_Implicit_Byte.SetBelong(null);
				}
				return r_Rop_Implicit_Byte;
			}
		}

		/// <summary>
		/// System.Decimal op_Implicit(SByte)
		/// </summary>
		protected static RMethod r_Rop_Implicit_SByte;
		public static RMethod Rop_Implicit_SByte
		{
			get
			{
				if(r_Rop_Implicit_SByte == null)
				{
					r_Rop_Implicit_SByte = new(typeof(System.Decimal), "op_Implicit", 0, typeof(System.SByte));
					r_Rop_Implicit_SByte.SetBelong(null);
				}
				return r_Rop_Implicit_SByte;
			}
		}

		/// <summary>
		/// System.Decimal op_Implicit(Int16)
		/// </summary>
		protected static RMethod r_Rop_Implicit_Int16;
		public static RMethod Rop_Implicit_Int16
		{
			get
			{
				if(r_Rop_Implicit_Int16 == null)
				{
					r_Rop_Implicit_Int16 = new(typeof(System.Decimal), "op_Implicit", 0, typeof(System.Int16));
					r_Rop_Implicit_Int16.SetBelong(null);
				}
				return r_Rop_Implicit_Int16;
			}
		}

		/// <summary>
		/// System.Decimal op_Implicit(UInt16)
		/// </summary>
		protected static RMethod r_Rop_Implicit_UInt16;
		public static RMethod Rop_Implicit_UInt16
		{
			get
			{
				if(r_Rop_Implicit_UInt16 == null)
				{
					r_Rop_Implicit_UInt16 = new(typeof(System.Decimal), "op_Implicit", 0, typeof(System.UInt16));
					r_Rop_Implicit_UInt16.SetBelong(null);
				}
				return r_Rop_Implicit_UInt16;
			}
		}

		/// <summary>
		/// System.Decimal op_Implicit(Char)
		/// </summary>
		protected static RMethod r_Rop_Implicit_Char;
		public static RMethod Rop_Implicit_Char
		{
			get
			{
				if(r_Rop_Implicit_Char == null)
				{
					r_Rop_Implicit_Char = new(typeof(System.Decimal), "op_Implicit", 0, typeof(System.Char));
					r_Rop_Implicit_Char.SetBelong(null);
				}
				return r_Rop_Implicit_Char;
			}
		}

		/// <summary>
		/// System.Decimal op_Implicit(Int32)
		/// </summary>
		protected static RMethod r_Rop_Implicit_Int32;
		public static RMethod Rop_Implicit_Int32
		{
			get
			{
				if(r_Rop_Implicit_Int32 == null)
				{
					r_Rop_Implicit_Int32 = new(typeof(System.Decimal), "op_Implicit", 0, typeof(System.Int32));
					r_Rop_Implicit_Int32.SetBelong(null);
				}
				return r_Rop_Implicit_Int32;
			}
		}

		/// <summary>
		/// System.Decimal op_Implicit(UInt32)
		/// </summary>
		protected static RMethod r_Rop_Implicit_UInt32;
		public static RMethod Rop_Implicit_UInt32
		{
			get
			{
				if(r_Rop_Implicit_UInt32 == null)
				{
					r_Rop_Implicit_UInt32 = new(typeof(System.Decimal), "op_Implicit", 0, typeof(System.UInt32));
					r_Rop_Implicit_UInt32.SetBelong(null);
				}
				return r_Rop_Implicit_UInt32;
			}
		}

		/// <summary>
		/// System.Decimal op_Implicit(Int64)
		/// </summary>
		protected static RMethod r_Rop_Implicit_Int64;
		public static RMethod Rop_Implicit_Int64
		{
			get
			{
				if(r_Rop_Implicit_Int64 == null)
				{
					r_Rop_Implicit_Int64 = new(typeof(System.Decimal), "op_Implicit", 0, typeof(System.Int64));
					r_Rop_Implicit_Int64.SetBelong(null);
				}
				return r_Rop_Implicit_Int64;
			}
		}

		/// <summary>
		/// System.Decimal op_Implicit(UInt64)
		/// </summary>
		protected static RMethod r_Rop_Implicit_UInt64;
		public static RMethod Rop_Implicit_UInt64
		{
			get
			{
				if(r_Rop_Implicit_UInt64 == null)
				{
					r_Rop_Implicit_UInt64 = new(typeof(System.Decimal), "op_Implicit", 0, typeof(System.UInt64));
					r_Rop_Implicit_UInt64.SetBelong(null);
				}
				return r_Rop_Implicit_UInt64;
			}
		}

		/// <summary>
		/// System.Decimal op_Explicit(Single)
		/// </summary>
		protected static RMethod r_Rop_Explicit_Single;
		public static RMethod Rop_Explicit_Single
		{
			get
			{
				if(r_Rop_Explicit_Single == null)
				{
					r_Rop_Explicit_Single = new(typeof(System.Decimal), "op_Explicit", 0, typeof(System.Single));
					r_Rop_Explicit_Single.SetBelong(null);
				}
				return r_Rop_Explicit_Single;
			}
		}

		/// <summary>
		/// System.Decimal op_Explicit(Double)
		/// </summary>
		protected static RMethod r_Rop_Explicit_Double;
		public static RMethod Rop_Explicit_Double
		{
			get
			{
				if(r_Rop_Explicit_Double == null)
				{
					r_Rop_Explicit_Double = new(typeof(System.Decimal), "op_Explicit", 0, typeof(System.Double));
					r_Rop_Explicit_Double.SetBelong(null);
				}
				return r_Rop_Explicit_Double;
			}
		}

		/// <summary>
		/// Byte op_Explicit(System.Decimal)
		/// </summary>
		protected static RMethod r_Rop_Explicit_Decimal;
		public static RMethod Rop_Explicit_Decimal
		{
			get
			{
				if(r_Rop_Explicit_Decimal == null)
				{
					r_Rop_Explicit_Decimal = new(typeof(System.Decimal), "op_Explicit", 0, typeof(System.Decimal));
					r_Rop_Explicit_Decimal.SetBelong(null);
				}
				return r_Rop_Explicit_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal op_UnaryPlus(System.Decimal)
		/// </summary>
		protected static RMethod r_Rop_UnaryPlus_Decimal;
		public static RMethod Rop_UnaryPlus_Decimal
		{
			get
			{
				if(r_Rop_UnaryPlus_Decimal == null)
				{
					r_Rop_UnaryPlus_Decimal = new(typeof(System.Decimal), "op_UnaryPlus", 0, typeof(System.Decimal));
					r_Rop_UnaryPlus_Decimal.SetBelong(null);
				}
				return r_Rop_UnaryPlus_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal op_UnaryNegation(System.Decimal)
		/// </summary>
		protected static RMethod r_Rop_UnaryNegation_Decimal;
		public static RMethod Rop_UnaryNegation_Decimal
		{
			get
			{
				if(r_Rop_UnaryNegation_Decimal == null)
				{
					r_Rop_UnaryNegation_Decimal = new(typeof(System.Decimal), "op_UnaryNegation", 0, typeof(System.Decimal));
					r_Rop_UnaryNegation_Decimal.SetBelong(null);
				}
				return r_Rop_UnaryNegation_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal op_Increment(System.Decimal)
		/// </summary>
		protected static RMethod r_Rop_Increment_Decimal;
		public static RMethod Rop_Increment_Decimal
		{
			get
			{
				if(r_Rop_Increment_Decimal == null)
				{
					r_Rop_Increment_Decimal = new(typeof(System.Decimal), "op_Increment", 0, typeof(System.Decimal));
					r_Rop_Increment_Decimal.SetBelong(null);
				}
				return r_Rop_Increment_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal op_Decrement(System.Decimal)
		/// </summary>
		protected static RMethod r_Rop_Decrement_Decimal;
		public static RMethod Rop_Decrement_Decimal
		{
			get
			{
				if(r_Rop_Decrement_Decimal == null)
				{
					r_Rop_Decrement_Decimal = new(typeof(System.Decimal), "op_Decrement", 0, typeof(System.Decimal));
					r_Rop_Decrement_Decimal.SetBelong(null);
				}
				return r_Rop_Decrement_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal op_Addition(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_Rop_Addition_Decimal_Decimal;
		public static RMethod Rop_Addition_Decimal_Decimal
		{
			get
			{
				if(r_Rop_Addition_Decimal_Decimal == null)
				{
					r_Rop_Addition_Decimal_Decimal = new(typeof(System.Decimal), "op_Addition", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_Rop_Addition_Decimal_Decimal.SetBelong(null);
				}
				return r_Rop_Addition_Decimal_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal op_Subtraction(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_Rop_Subtraction_Decimal_Decimal;
		public static RMethod Rop_Subtraction_Decimal_Decimal
		{
			get
			{
				if(r_Rop_Subtraction_Decimal_Decimal == null)
				{
					r_Rop_Subtraction_Decimal_Decimal = new(typeof(System.Decimal), "op_Subtraction", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_Rop_Subtraction_Decimal_Decimal.SetBelong(null);
				}
				return r_Rop_Subtraction_Decimal_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal op_Multiply(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_Rop_Multiply_Decimal_Decimal;
		public static RMethod Rop_Multiply_Decimal_Decimal
		{
			get
			{
				if(r_Rop_Multiply_Decimal_Decimal == null)
				{
					r_Rop_Multiply_Decimal_Decimal = new(typeof(System.Decimal), "op_Multiply", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_Rop_Multiply_Decimal_Decimal.SetBelong(null);
				}
				return r_Rop_Multiply_Decimal_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal op_Division(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_Rop_Division_Decimal_Decimal;
		public static RMethod Rop_Division_Decimal_Decimal
		{
			get
			{
				if(r_Rop_Division_Decimal_Decimal == null)
				{
					r_Rop_Division_Decimal_Decimal = new(typeof(System.Decimal), "op_Division", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_Rop_Division_Decimal_Decimal.SetBelong(null);
				}
				return r_Rop_Division_Decimal_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal op_Modulus(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_Rop_Modulus_Decimal_Decimal;
		public static RMethod Rop_Modulus_Decimal_Decimal
		{
			get
			{
				if(r_Rop_Modulus_Decimal_Decimal == null)
				{
					r_Rop_Modulus_Decimal_Decimal = new(typeof(System.Decimal), "op_Modulus", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_Rop_Modulus_Decimal_Decimal.SetBelong(null);
				}
				return r_Rop_Modulus_Decimal_Decimal;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_Rop_Equality_Decimal_Decimal;
		public static RMethod Rop_Equality_Decimal_Decimal
		{
			get
			{
				if(r_Rop_Equality_Decimal_Decimal == null)
				{
					r_Rop_Equality_Decimal_Decimal = new(typeof(System.Decimal), "op_Equality", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_Rop_Equality_Decimal_Decimal.SetBelong(null);
				}
				return r_Rop_Equality_Decimal_Decimal;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_Rop_Inequality_Decimal_Decimal;
		public static RMethod Rop_Inequality_Decimal_Decimal
		{
			get
			{
				if(r_Rop_Inequality_Decimal_Decimal == null)
				{
					r_Rop_Inequality_Decimal_Decimal = new(typeof(System.Decimal), "op_Inequality", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_Rop_Inequality_Decimal_Decimal.SetBelong(null);
				}
				return r_Rop_Inequality_Decimal_Decimal;
			}
		}

		/// <summary>
		/// Boolean op_LessThan(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_Rop_LessThan_Decimal_Decimal;
		public static RMethod Rop_LessThan_Decimal_Decimal
		{
			get
			{
				if(r_Rop_LessThan_Decimal_Decimal == null)
				{
					r_Rop_LessThan_Decimal_Decimal = new(typeof(System.Decimal), "op_LessThan", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_Rop_LessThan_Decimal_Decimal.SetBelong(null);
				}
				return r_Rop_LessThan_Decimal_Decimal;
			}
		}

		/// <summary>
		/// Boolean op_LessThanOrEqual(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_Rop_LessThanOrEqual_Decimal_Decimal;
		public static RMethod Rop_LessThanOrEqual_Decimal_Decimal
		{
			get
			{
				if(r_Rop_LessThanOrEqual_Decimal_Decimal == null)
				{
					r_Rop_LessThanOrEqual_Decimal_Decimal = new(typeof(System.Decimal), "op_LessThanOrEqual", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_Rop_LessThanOrEqual_Decimal_Decimal.SetBelong(null);
				}
				return r_Rop_LessThanOrEqual_Decimal_Decimal;
			}
		}

		/// <summary>
		/// Boolean op_GreaterThan(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_Rop_GreaterThan_Decimal_Decimal;
		public static RMethod Rop_GreaterThan_Decimal_Decimal
		{
			get
			{
				if(r_Rop_GreaterThan_Decimal_Decimal == null)
				{
					r_Rop_GreaterThan_Decimal_Decimal = new(typeof(System.Decimal), "op_GreaterThan", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_Rop_GreaterThan_Decimal_Decimal.SetBelong(null);
				}
				return r_Rop_GreaterThan_Decimal_Decimal;
			}
		}

		/// <summary>
		/// Boolean op_GreaterThanOrEqual(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_Rop_GreaterThanOrEqual_Decimal_Decimal;
		public static RMethod Rop_GreaterThanOrEqual_Decimal_Decimal
		{
			get
			{
				if(r_Rop_GreaterThanOrEqual_Decimal_Decimal == null)
				{
					r_Rop_GreaterThanOrEqual_Decimal_Decimal = new(typeof(System.Decimal), "op_GreaterThanOrEqual", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_Rop_GreaterThanOrEqual_Decimal_Decimal.SetBelong(null);
				}
				return r_Rop_GreaterThanOrEqual_Decimal_Decimal;
			}
		}

		/// <summary>
		/// System.TypeCode GetTypeCode()
		/// </summary>
		protected RMethod r_RGetTypeCode;
		public virtual RMethod RGetTypeCode
		{
			get
			{
				if(r_RGetTypeCode == null)
				{
					r_RGetTypeCode = new(this, "GetTypeCode", 0);
					r_RGetTypeCode.SetBelong(this.instance);
				}
				return r_RGetTypeCode;
			}
		}

		/// <summary>
		/// Boolean System.IConvertible.ToBoolean(System.IFormatProvider)
		/// </summary>
		protected RMethod r_RSystem__0__IConvertible__0__ToBoolean_IFormatProvider;
		public virtual RMethod RSystem__0__IConvertible__0__ToBoolean_IFormatProvider
		{
			get
			{
				if(r_RSystem__0__IConvertible__0__ToBoolean_IFormatProvider == null)
				{
					r_RSystem__0__IConvertible__0__ToBoolean_IFormatProvider = new(this, "System.IConvertible.ToBoolean", 0, typeof(System.IFormatProvider));
					r_RSystem__0__IConvertible__0__ToBoolean_IFormatProvider.SetBelong(this.instance);
				}
				return r_RSystem__0__IConvertible__0__ToBoolean_IFormatProvider;
			}
		}

		/// <summary>
		/// Char System.IConvertible.ToChar(System.IFormatProvider)
		/// </summary>
		protected RMethod r_RSystem__0__IConvertible__0__ToChar_IFormatProvider;
		public virtual RMethod RSystem__0__IConvertible__0__ToChar_IFormatProvider
		{
			get
			{
				if(r_RSystem__0__IConvertible__0__ToChar_IFormatProvider == null)
				{
					r_RSystem__0__IConvertible__0__ToChar_IFormatProvider = new(this, "System.IConvertible.ToChar", 0, typeof(System.IFormatProvider));
					r_RSystem__0__IConvertible__0__ToChar_IFormatProvider.SetBelong(this.instance);
				}
				return r_RSystem__0__IConvertible__0__ToChar_IFormatProvider;
			}
		}

		/// <summary>
		/// SByte System.IConvertible.ToSByte(System.IFormatProvider)
		/// </summary>
		protected RMethod r_RSystem__0__IConvertible__0__ToSByte_IFormatProvider;
		public virtual RMethod RSystem__0__IConvertible__0__ToSByte_IFormatProvider
		{
			get
			{
				if(r_RSystem__0__IConvertible__0__ToSByte_IFormatProvider == null)
				{
					r_RSystem__0__IConvertible__0__ToSByte_IFormatProvider = new(this, "System.IConvertible.ToSByte", 0, typeof(System.IFormatProvider));
					r_RSystem__0__IConvertible__0__ToSByte_IFormatProvider.SetBelong(this.instance);
				}
				return r_RSystem__0__IConvertible__0__ToSByte_IFormatProvider;
			}
		}

		/// <summary>
		/// Byte System.IConvertible.ToByte(System.IFormatProvider)
		/// </summary>
		protected RMethod r_RSystem__0__IConvertible__0__ToByte_IFormatProvider;
		public virtual RMethod RSystem__0__IConvertible__0__ToByte_IFormatProvider
		{
			get
			{
				if(r_RSystem__0__IConvertible__0__ToByte_IFormatProvider == null)
				{
					r_RSystem__0__IConvertible__0__ToByte_IFormatProvider = new(this, "System.IConvertible.ToByte", 0, typeof(System.IFormatProvider));
					r_RSystem__0__IConvertible__0__ToByte_IFormatProvider.SetBelong(this.instance);
				}
				return r_RSystem__0__IConvertible__0__ToByte_IFormatProvider;
			}
		}

		/// <summary>
		/// Int16 System.IConvertible.ToInt16(System.IFormatProvider)
		/// </summary>
		protected RMethod r_RSystem__0__IConvertible__0__ToInt16_IFormatProvider;
		public virtual RMethod RSystem__0__IConvertible__0__ToInt16_IFormatProvider
		{
			get
			{
				if(r_RSystem__0__IConvertible__0__ToInt16_IFormatProvider == null)
				{
					r_RSystem__0__IConvertible__0__ToInt16_IFormatProvider = new(this, "System.IConvertible.ToInt16", 0, typeof(System.IFormatProvider));
					r_RSystem__0__IConvertible__0__ToInt16_IFormatProvider.SetBelong(this.instance);
				}
				return r_RSystem__0__IConvertible__0__ToInt16_IFormatProvider;
			}
		}

		/// <summary>
		/// UInt16 System.IConvertible.ToUInt16(System.IFormatProvider)
		/// </summary>
		protected RMethod r_RSystem__0__IConvertible__0__ToUInt16_IFormatProvider;
		public virtual RMethod RSystem__0__IConvertible__0__ToUInt16_IFormatProvider
		{
			get
			{
				if(r_RSystem__0__IConvertible__0__ToUInt16_IFormatProvider == null)
				{
					r_RSystem__0__IConvertible__0__ToUInt16_IFormatProvider = new(this, "System.IConvertible.ToUInt16", 0, typeof(System.IFormatProvider));
					r_RSystem__0__IConvertible__0__ToUInt16_IFormatProvider.SetBelong(this.instance);
				}
				return r_RSystem__0__IConvertible__0__ToUInt16_IFormatProvider;
			}
		}

		/// <summary>
		/// Int32 System.IConvertible.ToInt32(System.IFormatProvider)
		/// </summary>
		protected RMethod r_RSystem__0__IConvertible__0__ToInt32_IFormatProvider;
		public virtual RMethod RSystem__0__IConvertible__0__ToInt32_IFormatProvider
		{
			get
			{
				if(r_RSystem__0__IConvertible__0__ToInt32_IFormatProvider == null)
				{
					r_RSystem__0__IConvertible__0__ToInt32_IFormatProvider = new(this, "System.IConvertible.ToInt32", 0, typeof(System.IFormatProvider));
					r_RSystem__0__IConvertible__0__ToInt32_IFormatProvider.SetBelong(this.instance);
				}
				return r_RSystem__0__IConvertible__0__ToInt32_IFormatProvider;
			}
		}

		/// <summary>
		/// UInt32 System.IConvertible.ToUInt32(System.IFormatProvider)
		/// </summary>
		protected RMethod r_RSystem__0__IConvertible__0__ToUInt32_IFormatProvider;
		public virtual RMethod RSystem__0__IConvertible__0__ToUInt32_IFormatProvider
		{
			get
			{
				if(r_RSystem__0__IConvertible__0__ToUInt32_IFormatProvider == null)
				{
					r_RSystem__0__IConvertible__0__ToUInt32_IFormatProvider = new(this, "System.IConvertible.ToUInt32", 0, typeof(System.IFormatProvider));
					r_RSystem__0__IConvertible__0__ToUInt32_IFormatProvider.SetBelong(this.instance);
				}
				return r_RSystem__0__IConvertible__0__ToUInt32_IFormatProvider;
			}
		}

		/// <summary>
		/// Int64 System.IConvertible.ToInt64(System.IFormatProvider)
		/// </summary>
		protected RMethod r_RSystem__0__IConvertible__0__ToInt64_IFormatProvider;
		public virtual RMethod RSystem__0__IConvertible__0__ToInt64_IFormatProvider
		{
			get
			{
				if(r_RSystem__0__IConvertible__0__ToInt64_IFormatProvider == null)
				{
					r_RSystem__0__IConvertible__0__ToInt64_IFormatProvider = new(this, "System.IConvertible.ToInt64", 0, typeof(System.IFormatProvider));
					r_RSystem__0__IConvertible__0__ToInt64_IFormatProvider.SetBelong(this.instance);
				}
				return r_RSystem__0__IConvertible__0__ToInt64_IFormatProvider;
			}
		}

		/// <summary>
		/// UInt64 System.IConvertible.ToUInt64(System.IFormatProvider)
		/// </summary>
		protected RMethod r_RSystem__0__IConvertible__0__ToUInt64_IFormatProvider;
		public virtual RMethod RSystem__0__IConvertible__0__ToUInt64_IFormatProvider
		{
			get
			{
				if(r_RSystem__0__IConvertible__0__ToUInt64_IFormatProvider == null)
				{
					r_RSystem__0__IConvertible__0__ToUInt64_IFormatProvider = new(this, "System.IConvertible.ToUInt64", 0, typeof(System.IFormatProvider));
					r_RSystem__0__IConvertible__0__ToUInt64_IFormatProvider.SetBelong(this.instance);
				}
				return r_RSystem__0__IConvertible__0__ToUInt64_IFormatProvider;
			}
		}

		/// <summary>
		/// Single System.IConvertible.ToSingle(System.IFormatProvider)
		/// </summary>
		protected RMethod r_RSystem__0__IConvertible__0__ToSingle_IFormatProvider;
		public virtual RMethod RSystem__0__IConvertible__0__ToSingle_IFormatProvider
		{
			get
			{
				if(r_RSystem__0__IConvertible__0__ToSingle_IFormatProvider == null)
				{
					r_RSystem__0__IConvertible__0__ToSingle_IFormatProvider = new(this, "System.IConvertible.ToSingle", 0, typeof(System.IFormatProvider));
					r_RSystem__0__IConvertible__0__ToSingle_IFormatProvider.SetBelong(this.instance);
				}
				return r_RSystem__0__IConvertible__0__ToSingle_IFormatProvider;
			}
		}

		/// <summary>
		/// Double System.IConvertible.ToDouble(System.IFormatProvider)
		/// </summary>
		protected RMethod r_RSystem__0__IConvertible__0__ToDouble_IFormatProvider;
		public virtual RMethod RSystem__0__IConvertible__0__ToDouble_IFormatProvider
		{
			get
			{
				if(r_RSystem__0__IConvertible__0__ToDouble_IFormatProvider == null)
				{
					r_RSystem__0__IConvertible__0__ToDouble_IFormatProvider = new(this, "System.IConvertible.ToDouble", 0, typeof(System.IFormatProvider));
					r_RSystem__0__IConvertible__0__ToDouble_IFormatProvider.SetBelong(this.instance);
				}
				return r_RSystem__0__IConvertible__0__ToDouble_IFormatProvider;
			}
		}

		/// <summary>
		/// System.Decimal System.IConvertible.ToDecimal(System.IFormatProvider)
		/// </summary>
		protected RMethod r_RSystem__0__IConvertible__0__ToDecimal_IFormatProvider;
		public virtual RMethod RSystem__0__IConvertible__0__ToDecimal_IFormatProvider
		{
			get
			{
				if(r_RSystem__0__IConvertible__0__ToDecimal_IFormatProvider == null)
				{
					r_RSystem__0__IConvertible__0__ToDecimal_IFormatProvider = new(this, "System.IConvertible.ToDecimal", 0, typeof(System.IFormatProvider));
					r_RSystem__0__IConvertible__0__ToDecimal_IFormatProvider.SetBelong(this.instance);
				}
				return r_RSystem__0__IConvertible__0__ToDecimal_IFormatProvider;
			}
		}

		/// <summary>
		/// System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider)
		/// </summary>
		protected RMethod r_RSystem__0__IConvertible__0__ToDateTime_IFormatProvider;
		public virtual RMethod RSystem__0__IConvertible__0__ToDateTime_IFormatProvider
		{
			get
			{
				if(r_RSystem__0__IConvertible__0__ToDateTime_IFormatProvider == null)
				{
					r_RSystem__0__IConvertible__0__ToDateTime_IFormatProvider = new(this, "System.IConvertible.ToDateTime", 0, typeof(System.IFormatProvider));
					r_RSystem__0__IConvertible__0__ToDateTime_IFormatProvider.SetBelong(this.instance);
				}
				return r_RSystem__0__IConvertible__0__ToDateTime_IFormatProvider;
			}
		}

		/// <summary>
		/// System.Object System.IConvertible.ToType(System.Type, System.IFormatProvider)
		/// </summary>
		protected RMethod r_RSystem__0__IConvertible__0__ToType_Type_IFormatProvider;
		public virtual RMethod RSystem__0__IConvertible__0__ToType_Type_IFormatProvider
		{
			get
			{
				if(r_RSystem__0__IConvertible__0__ToType_Type_IFormatProvider == null)
				{
					r_RSystem__0__IConvertible__0__ToType_Type_IFormatProvider = new(this, "System.IConvertible.ToType", 0, typeof(System.Type), typeof(System.IFormatProvider));
					r_RSystem__0__IConvertible__0__ToType_Type_IFormatProvider.SetBelong(this.instance);
				}
				return r_RSystem__0__IConvertible__0__ToType_Type_IFormatProvider;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
			}
		}


        public RDecimal() : base("System.Decimal")
        {
        }

        public RDecimal(System.Object instance) : base("System.Decimal")
		{
            SetInstance(instance);
		}

        public RDecimal(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDecimal(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Object AsMutable(ref System.Decimal  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RAsMutable_Ref_Decimal.Invoke(___genericsType, ___parameters);
			d = (System.Decimal)___parameters[0];

            return (System.Object)___result;
        }


        public static System.UInt32 DecDivMod1E9(ref System.Decimal  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RDecDivMod1E9_Ref_Decimal.Invoke(___genericsType, ___parameters);
			value = (System.Decimal)___parameters[0];

            return (System.UInt32)___result;
        }


        public static System.Decimal FromOACurrency(System.Int64  @cy)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cy};
            var ___result = RFromOACurrency_Int64.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Int64 ToOACurrency(System.Decimal  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToOACurrency_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public static System.Boolean IsValid(System.Int32  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flags};
            var ___result = RIsValid_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void System__0__Runtime__0__Serialization__0__IDeserializationCallback__0__OnDeserialization(System.Object  @sender)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender};
            var ___result = RSystem__0__Runtime__0__Serialization__0__IDeserializationCallback__0__OnDeserialization_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Decimal Abs(ref System.Decimal  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RAbs_Ref_Decimal.Invoke(___genericsType, ___parameters);
			d = (System.Decimal)___parameters[0];

            return (System.Decimal)___result;
        }


        public static System.Decimal Add(System.Decimal  @d1, System.Decimal  @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RAdd_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal Ceiling(System.Decimal  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RCeiling_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Int32 Compare(System.Decimal  @d1, System.Decimal  @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RCompare_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareTo(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareTo(System.Decimal  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RCompareTo_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Decimal Divide(System.Decimal  @d1, System.Decimal  @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RDivide_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public virtual System.Boolean Equals(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Decimal  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = REquals_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean Equals(System.Decimal  @d1, System.Decimal  @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = REquals_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Decimal Floor(System.Decimal  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RFloor_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String  @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String  @format, System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }



        public static System.Decimal Parse(System.String  @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RParse_String.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal Parse(System.String  @s, System.Globalization.NumberStyles  @style)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @style};
            var ___result = RParse_String_NumberStyles.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal Parse(System.String  @s, System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @provider};
            var ___result = RParse_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal Parse(System.String  @s, System.Globalization.NumberStyles  @style, System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @style, @provider};
            var ___result = RParse_String_NumberStyles_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }



        public static System.Boolean TryParse(System.String  @s, out System.Decimal  @result)
        {
			result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @result};
            var ___result = RTryParse_String_Out_Decimal.Invoke(___genericsType, ___parameters);
			result = (System.Decimal)___parameters[1];

            return (System.Boolean)___result;
        }



        public static System.Boolean TryParse(System.String  @s, System.Globalization.NumberStyles  @style, System.IFormatProvider  @provider, out System.Decimal  @result)
        {
			result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @style, @provider, @result};
            var ___result = RTryParse_String_NumberStyles_IFormatProvider_Out_Decimal.Invoke(___genericsType, ___parameters);
			result = (System.Decimal)___parameters[3];

            return (System.Boolean)___result;
        }



        public static System.Int32[] GetBits(System.Decimal  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RGetBits_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Int32[])___result;
        }


        public static void GetBytes(in System.Decimal  @d, System.Byte[]  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d, @buffer};
            var ___result = RGetBytes_In_Decimal_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Decimal ToDecimal(System.Byte[]  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer};
            var ___result = RToDecimal_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal Max(ref System.Decimal  @d1, ref System.Decimal  @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RMax_Ref_Decimal_Ref_Decimal.Invoke(___genericsType, ___parameters);
			d1 = (System.Decimal)___parameters[0];
			d2 = (System.Decimal)___parameters[1];

            return (System.Decimal)___result;
        }


        public static System.Decimal Min(ref System.Decimal  @d1, ref System.Decimal  @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RMin_Ref_Decimal_Ref_Decimal.Invoke(___genericsType, ___parameters);
			d1 = (System.Decimal)___parameters[0];
			d2 = (System.Decimal)___parameters[1];

            return (System.Decimal)___result;
        }


        public static System.Decimal Remainder(System.Decimal  @d1, System.Decimal  @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RRemainder_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal Multiply(System.Decimal  @d1, System.Decimal  @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RMultiply_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal Negate(System.Decimal  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RNegate_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal Round(System.Decimal  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RRound_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal Round(System.Decimal  @d, System.Int32  @decimals)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d, @decimals};
            var ___result = RRound_Decimal_Int32.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal Round(System.Decimal  @d, System.MidpointRounding  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d, @mode};
            var ___result = RRound_Decimal_MidpointRounding.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal Round(System.Decimal  @d, System.Int32  @decimals, System.MidpointRounding  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d, @decimals, @mode};
            var ___result = RRound_Decimal_Int32_MidpointRounding.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal Round(ref System.Decimal  @d, System.Int32  @decimals, System.MidpointRounding  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d, @decimals, @mode};
            var ___result = RRound_Ref_Decimal_Int32_MidpointRounding.Invoke(___genericsType, ___parameters);
			d = (System.Decimal)___parameters[0];

            return (System.Decimal)___result;
        }


        public static System.Int32 Sign(ref System.Decimal  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RSign_Ref_Decimal.Invoke(___genericsType, ___parameters);
			d = (System.Decimal)___parameters[0];

            return (System.Int32)___result;
        }


        public static System.Decimal Subtract(System.Decimal  @d1, System.Decimal  @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RSubtract_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Byte ToByte(System.Decimal  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToByte_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Byte)___result;
        }


        public static System.SByte ToSByte(System.Decimal  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToSByte_Decimal.Invoke(___genericsType, ___parameters);

            return (System.SByte)___result;
        }


        public static System.Int16 ToInt16(System.Decimal  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToInt16_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Int16)___result;
        }


        public static System.Double ToDouble(System.Decimal  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RToDouble_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public static System.Int32 ToInt32(System.Decimal  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RToInt32_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int64 ToInt64(System.Decimal  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RToInt64_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public static System.UInt16 ToUInt16(System.Decimal  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToUInt16_Decimal.Invoke(___genericsType, ___parameters);

            return (System.UInt16)___result;
        }


        public static System.UInt32 ToUInt32(System.Decimal  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RToUInt32_Decimal.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public static System.UInt64 ToUInt64(System.Decimal  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RToUInt64_Decimal.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public static System.Single ToSingle(System.Decimal  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RToSingle_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Decimal Truncate(System.Decimal  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RTruncate_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static void Truncate(ref System.Decimal  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RTruncate_Ref_Decimal.Invoke(___genericsType, ___parameters);
			d = (System.Decimal)___parameters[0];

            
        }


        public static System.Decimal op_Implicit(System.Byte  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rop_Implicit_Byte.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Implicit(System.SByte  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rop_Implicit_SByte.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Implicit(System.Int16  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rop_Implicit_Int16.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Implicit(System.UInt16  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rop_Implicit_UInt16.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Implicit(System.Char  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rop_Implicit_Char.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Implicit(System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rop_Implicit_Int32.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Implicit(System.UInt32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rop_Implicit_UInt32.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Implicit(System.Int64  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rop_Implicit_Int64.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Implicit(System.UInt64  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rop_Implicit_UInt64.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Explicit(System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rop_Explicit_Single.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Explicit(System.Double  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rop_Explicit_Double.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Byte op_Explicit(System.Decimal  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rop_Explicit_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Byte)___result;
        }


        public static System.Decimal op_UnaryPlus(System.Decimal  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = Rop_UnaryPlus_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_UnaryNegation(System.Decimal  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = Rop_UnaryNegation_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Increment(System.Decimal  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = Rop_Increment_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Decrement(System.Decimal  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = Rop_Decrement_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Addition(System.Decimal  @d1, System.Decimal  @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = Rop_Addition_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Subtraction(System.Decimal  @d1, System.Decimal  @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = Rop_Subtraction_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Multiply(System.Decimal  @d1, System.Decimal  @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = Rop_Multiply_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Division(System.Decimal  @d1, System.Decimal  @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = Rop_Division_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Modulus(System.Decimal  @d1, System.Decimal  @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = Rop_Modulus_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Boolean op_Equality(System.Decimal  @d1, System.Decimal  @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = Rop_Equality_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Decimal  @d1, System.Decimal  @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = Rop_Inequality_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_LessThan(System.Decimal  @d1, System.Decimal  @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = Rop_LessThan_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_LessThanOrEqual(System.Decimal  @d1, System.Decimal  @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = Rop_LessThanOrEqual_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_GreaterThan(System.Decimal  @d1, System.Decimal  @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = Rop_GreaterThan_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_GreaterThanOrEqual(System.Decimal  @d1, System.Decimal  @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = Rop_GreaterThanOrEqual_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTypeCode.Invoke(___genericsType, ___parameters);

            return (System.TypeCode)___result;
        }


        public virtual System.Boolean System__0__IConvertible__0__ToBoolean(System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__0__IConvertible__0__ToBoolean_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Char System__0__IConvertible__0__ToChar(System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__0__IConvertible__0__ToChar_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public virtual System.SByte System__0__IConvertible__0__ToSByte(System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__0__IConvertible__0__ToSByte_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.SByte)___result;
        }


        public virtual System.Byte System__0__IConvertible__0__ToByte(System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__0__IConvertible__0__ToByte_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Byte)___result;
        }


        public virtual System.Int16 System__0__IConvertible__0__ToInt16(System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__0__IConvertible__0__ToInt16_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Int16)___result;
        }


        public virtual System.UInt16 System__0__IConvertible__0__ToUInt16(System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__0__IConvertible__0__ToUInt16_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.UInt16)___result;
        }


        public virtual System.Int32 System__0__IConvertible__0__ToInt32(System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__0__IConvertible__0__ToInt32_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.UInt32 System__0__IConvertible__0__ToUInt32(System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__0__IConvertible__0__ToUInt32_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual System.Int64 System__0__IConvertible__0__ToInt64(System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__0__IConvertible__0__ToInt64_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.UInt64 System__0__IConvertible__0__ToUInt64(System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__0__IConvertible__0__ToUInt64_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public virtual System.Single System__0__IConvertible__0__ToSingle(System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__0__IConvertible__0__ToSingle_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Double System__0__IConvertible__0__ToDouble(System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__0__IConvertible__0__ToDouble_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Decimal System__0__IConvertible__0__ToDecimal(System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__0__IConvertible__0__ToDecimal_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public virtual System.DateTime System__0__IConvertible__0__ToDateTime(System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RSystem__0__IConvertible__0__ToDateTime_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.Object System__0__IConvertible__0__ToType(System.Type  @type, System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @provider};
            var ___result = RSystem__0__IConvertible__0__ToType_Type_IFormatProvider.Invoke(___genericsType, ___parameters);

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
