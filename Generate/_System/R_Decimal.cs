
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
		protected static SMFrame.Editor.Refleaction.RSystem.RInt32 r_FSignMask;
		public static SMFrame.Editor.Refleaction.RSystem.RInt32 RFSignMask
		{
			get
			{
				if(r_FSignMask == null)
				{
					r_FSignMask = new(typeof(System.Decimal), "SignMask");
					r_FSignMask.SetBelong(null);
				}
				return r_FSignMask;
			}
		}

		/// <summary>
		/// System.Int32 ScaleMask
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RInt32 r_FScaleMask;
		public static SMFrame.Editor.Refleaction.RSystem.RInt32 RFScaleMask
		{
			get
			{
				if(r_FScaleMask == null)
				{
					r_FScaleMask = new(typeof(System.Decimal), "ScaleMask");
					r_FScaleMask.SetBelong(null);
				}
				return r_FScaleMask;
			}
		}

		/// <summary>
		/// System.Int32 ScaleShift
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RInt32 r_FScaleShift;
		public static SMFrame.Editor.Refleaction.RSystem.RInt32 RFScaleShift
		{
			get
			{
				if(r_FScaleShift == null)
				{
					r_FScaleShift = new(typeof(System.Decimal), "ScaleShift");
					r_FScaleShift.SetBelong(null);
				}
				return r_FScaleShift;
			}
		}

		/// <summary>
		/// System.Decimal Zero
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RDecimal r_FZero;
		public static SMFrame.Editor.Refleaction.RSystem.RDecimal RFZero
		{
			get
			{
				if(r_FZero == null)
				{
					r_FZero = new(typeof(System.Decimal), "Zero");
					r_FZero.SetBelong(null);
				}
				return r_FZero;
			}
		}

		/// <summary>
		/// System.Decimal One
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RDecimal r_FOne;
		public static SMFrame.Editor.Refleaction.RSystem.RDecimal RFOne
		{
			get
			{
				if(r_FOne == null)
				{
					r_FOne = new(typeof(System.Decimal), "One");
					r_FOne.SetBelong(null);
				}
				return r_FOne;
			}
		}

		/// <summary>
		/// System.Decimal MinusOne
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RDecimal r_FMinusOne;
		public static SMFrame.Editor.Refleaction.RSystem.RDecimal RFMinusOne
		{
			get
			{
				if(r_FMinusOne == null)
				{
					r_FMinusOne = new(typeof(System.Decimal), "MinusOne");
					r_FMinusOne.SetBelong(null);
				}
				return r_FMinusOne;
			}
		}

		/// <summary>
		/// System.Decimal MaxValue
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RDecimal r_FMaxValue;
		public static SMFrame.Editor.Refleaction.RSystem.RDecimal RFMaxValue
		{
			get
			{
				if(r_FMaxValue == null)
				{
					r_FMaxValue = new(typeof(System.Decimal), "MaxValue");
					r_FMaxValue.SetBelong(null);
				}
				return r_FMaxValue;
			}
		}

		/// <summary>
		/// System.Decimal MinValue
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RDecimal r_FMinValue;
		public static SMFrame.Editor.Refleaction.RSystem.RDecimal RFMinValue
		{
			get
			{
				if(r_FMinValue == null)
				{
					r_FMinValue = new(typeof(System.Decimal), "MinValue");
					r_FMinValue.SetBelong(null);
				}
				return r_FMinValue;
			}
		}

		/// <summary>
		/// System.Int32 flags
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fflags;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFflags
		{
			get
			{
				if(r_Fflags == null)
				{
					r_Fflags = new(this, "flags");
					r_Fflags.SetBelong(this.instance);
				}
				return r_Fflags;
			}
		}

		/// <summary>
		/// System.Int32 hi
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fhi;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFhi
		{
			get
			{
				if(r_Fhi == null)
				{
					r_Fhi = new(this, "hi");
					r_Fhi.SetBelong(this.instance);
				}
				return r_Fhi;
			}
		}

		/// <summary>
		/// System.Int32 lo
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Flo;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFlo
		{
			get
			{
				if(r_Flo == null)
				{
					r_Flo = new(this, "lo");
					r_Flo.SetBelong(this.instance);
				}
				return r_Flo;
			}
		}

		/// <summary>
		/// System.Int32 mid
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fmid;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFmid
		{
			get
			{
				if(r_Fmid == null)
				{
					r_Fmid = new(this, "mid");
					r_Fmid.SetBelong(this.instance);
				}
				return r_Fmid;
			}
		}

		/// <summary>
		/// System.UInt64 ulomidLE
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt64 r_FulomidLE;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt64 RFulomidLE
		{
			get
			{
				if(r_FulomidLE == null)
				{
					r_FulomidLE = new(this, "ulomidLE");
					r_FulomidLE.SetBelong(this.instance);
				}
				return r_FulomidLE;
			}
		}

		/// <summary>
		/// UInt32 High
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_PHigh;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RPHigh
		{
			get
			{
				if(r_PHigh == null)
				{
					r_PHigh = new(this, "High", -1);
					r_PHigh.SetBelong(this.instance);
				}
				return r_PHigh;
			}
		}

		/// <summary>
		/// UInt32 Low
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_PLow;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RPLow
		{
			get
			{
				if(r_PLow == null)
				{
					r_PLow = new(this, "Low", -1);
					r_PLow.SetBelong(this.instance);
				}
				return r_PLow;
			}
		}

		/// <summary>
		/// UInt32 Mid
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_PMid;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RPMid
		{
			get
			{
				if(r_PMid == null)
				{
					r_PMid = new(this, "Mid", -1);
					r_PMid.SetBelong(this.instance);
				}
				return r_PMid;
			}
		}

		/// <summary>
		/// Boolean IsNegative
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsNegative;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsNegative
		{
			get
			{
				if(r_PIsNegative == null)
				{
					r_PIsNegative = new(this, "IsNegative", -1);
					r_PIsNegative.SetBelong(this.instance);
				}
				return r_PIsNegative;
			}
		}

		/// <summary>
		/// Int32 Scale
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PScale;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPScale
		{
			get
			{
				if(r_PScale == null)
				{
					r_PScale = new(this, "Scale", -1);
					r_PScale.SetBelong(this.instance);
				}
				return r_PScale;
			}
		}

		/// <summary>
		/// UInt64 Low64
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt64 r_PLow64;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt64 RPLow64
		{
			get
			{
				if(r_PLow64 == null)
				{
					r_PLow64 = new(this, "Low64", -1);
					r_PLow64.SetBelong(this.instance);
				}
				return r_PLow64;
			}
		}

		/// <summary>
		/// DecCalc& AsMutable(System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_MAsMutable_Ref_Decimal;
		public static RMethod RMAsMutable_Ref_Decimal
		{
			get
			{
				if(r_MAsMutable_Ref_Decimal == null)
				{
					r_MAsMutable_Ref_Decimal = new(typeof(System.Decimal), "AsMutable", 0, typeof(System.Decimal).MakeByRefType());
					r_MAsMutable_Ref_Decimal.SetBelong(null);
				}
				return r_MAsMutable_Ref_Decimal;
			}
		}

		/// <summary>
		/// UInt32 DecDivMod1E9(System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_MDecDivMod1E9_Ref_Decimal;
		public static RMethod RMDecDivMod1E9_Ref_Decimal
		{
			get
			{
				if(r_MDecDivMod1E9_Ref_Decimal == null)
				{
					r_MDecDivMod1E9_Ref_Decimal = new(typeof(System.Decimal), "DecDivMod1E9", 0, typeof(System.Decimal).MakeByRefType());
					r_MDecDivMod1E9_Ref_Decimal.SetBelong(null);
				}
				return r_MDecDivMod1E9_Ref_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal FromOACurrency(Int64)
		/// </summary>
		protected static RMethod r_MFromOACurrency_Int64;
		public static RMethod RMFromOACurrency_Int64
		{
			get
			{
				if(r_MFromOACurrency_Int64 == null)
				{
					r_MFromOACurrency_Int64 = new(typeof(System.Decimal), "FromOACurrency", 0, typeof(System.Int64));
					r_MFromOACurrency_Int64.SetBelong(null);
				}
				return r_MFromOACurrency_Int64;
			}
		}

		/// <summary>
		/// Int64 ToOACurrency(System.Decimal)
		/// </summary>
		protected static RMethod r_MToOACurrency_Decimal;
		public static RMethod RMToOACurrency_Decimal
		{
			get
			{
				if(r_MToOACurrency_Decimal == null)
				{
					r_MToOACurrency_Decimal = new(typeof(System.Decimal), "ToOACurrency", 0, typeof(System.Decimal));
					r_MToOACurrency_Decimal.SetBelong(null);
				}
				return r_MToOACurrency_Decimal;
			}
		}

		/// <summary>
		/// Boolean IsValid(Int32)
		/// </summary>
		protected static RMethod r_MIsValid_Int32;
		public static RMethod RMIsValid_Int32
		{
			get
			{
				if(r_MIsValid_Int32 == null)
				{
					r_MIsValid_Int32 = new(typeof(System.Decimal), "IsValid", 0, typeof(System.Int32));
					r_MIsValid_Int32.SetBelong(null);
				}
				return r_MIsValid_Int32;
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
		/// System.Decimal Abs(System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_MAbs_Ref_Decimal;
		public static RMethod RMAbs_Ref_Decimal
		{
			get
			{
				if(r_MAbs_Ref_Decimal == null)
				{
					r_MAbs_Ref_Decimal = new(typeof(System.Decimal), "Abs", 0, typeof(System.Decimal).MakeByRefType());
					r_MAbs_Ref_Decimal.SetBelong(null);
				}
				return r_MAbs_Ref_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal Add(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_MAdd_Decimal_Decimal;
		public static RMethod RMAdd_Decimal_Decimal
		{
			get
			{
				if(r_MAdd_Decimal_Decimal == null)
				{
					r_MAdd_Decimal_Decimal = new(typeof(System.Decimal), "Add", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_MAdd_Decimal_Decimal.SetBelong(null);
				}
				return r_MAdd_Decimal_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal Ceiling(System.Decimal)
		/// </summary>
		protected static RMethod r_MCeiling_Decimal;
		public static RMethod RMCeiling_Decimal
		{
			get
			{
				if(r_MCeiling_Decimal == null)
				{
					r_MCeiling_Decimal = new(typeof(System.Decimal), "Ceiling", 0, typeof(System.Decimal));
					r_MCeiling_Decimal.SetBelong(null);
				}
				return r_MCeiling_Decimal;
			}
		}

		/// <summary>
		/// Int32 Compare(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_MCompare_Decimal_Decimal;
		public static RMethod RMCompare_Decimal_Decimal
		{
			get
			{
				if(r_MCompare_Decimal_Decimal == null)
				{
					r_MCompare_Decimal_Decimal = new(typeof(System.Decimal), "Compare", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_MCompare_Decimal_Decimal.SetBelong(null);
				}
				return r_MCompare_Decimal_Decimal;
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
		/// Int32 CompareTo(System.Decimal)
		/// </summary>
		protected RMethod r_MCompareTo_Decimal;
		public virtual RMethod RMCompareTo_Decimal
		{
			get
			{
				if(r_MCompareTo_Decimal == null)
				{
					r_MCompareTo_Decimal = new(this, "CompareTo", 0, typeof(System.Decimal));
					r_MCompareTo_Decimal.SetBelong(this.instance);
				}
				return r_MCompareTo_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal Divide(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_MDivide_Decimal_Decimal;
		public static RMethod RMDivide_Decimal_Decimal
		{
			get
			{
				if(r_MDivide_Decimal_Decimal == null)
				{
					r_MDivide_Decimal_Decimal = new(typeof(System.Decimal), "Divide", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_MDivide_Decimal_Decimal.SetBelong(null);
				}
				return r_MDivide_Decimal_Decimal;
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
		/// Boolean Equals(System.Decimal)
		/// </summary>
		protected RMethod r_MEquals_Decimal;
		public virtual RMethod RMEquals_Decimal
		{
			get
			{
				if(r_MEquals_Decimal == null)
				{
					r_MEquals_Decimal = new(this, "Equals", 0, typeof(System.Decimal));
					r_MEquals_Decimal.SetBelong(this.instance);
				}
				return r_MEquals_Decimal;
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
		/// Boolean Equals(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_MEquals_Decimal_Decimal;
		public static RMethod RMEquals_Decimal_Decimal
		{
			get
			{
				if(r_MEquals_Decimal_Decimal == null)
				{
					r_MEquals_Decimal_Decimal = new(typeof(System.Decimal), "Equals", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_MEquals_Decimal_Decimal.SetBelong(null);
				}
				return r_MEquals_Decimal_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal Floor(System.Decimal)
		/// </summary>
		protected static RMethod r_MFloor_Decimal;
		public static RMethod RMFloor_Decimal
		{
			get
			{
				if(r_MFloor_Decimal == null)
				{
					r_MFloor_Decimal = new(typeof(System.Decimal), "Floor", 0, typeof(System.Decimal));
					r_MFloor_Decimal.SetBelong(null);
				}
				return r_MFloor_Decimal;
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
		/// System.Decimal Parse(System.String)
		/// </summary>
		protected static RMethod r_MParse_String;
		public static RMethod RMParse_String
		{
			get
			{
				if(r_MParse_String == null)
				{
					r_MParse_String = new(typeof(System.Decimal), "Parse", 0, typeof(System.String));
					r_MParse_String.SetBelong(null);
				}
				return r_MParse_String;
			}
		}

		/// <summary>
		/// System.Decimal Parse(System.String, System.Globalization.NumberStyles)
		/// </summary>
		protected static RMethod r_MParse_String_NumberStyles;
		public static RMethod RMParse_String_NumberStyles
		{
			get
			{
				if(r_MParse_String_NumberStyles == null)
				{
					r_MParse_String_NumberStyles = new(typeof(System.Decimal), "Parse", 0, typeof(System.String), typeof(System.Globalization.NumberStyles));
					r_MParse_String_NumberStyles.SetBelong(null);
				}
				return r_MParse_String_NumberStyles;
			}
		}

		/// <summary>
		/// System.Decimal Parse(System.String, System.IFormatProvider)
		/// </summary>
		protected static RMethod r_MParse_String_IFormatProvider;
		public static RMethod RMParse_String_IFormatProvider
		{
			get
			{
				if(r_MParse_String_IFormatProvider == null)
				{
					r_MParse_String_IFormatProvider = new(typeof(System.Decimal), "Parse", 0, typeof(System.String), typeof(System.IFormatProvider));
					r_MParse_String_IFormatProvider.SetBelong(null);
				}
				return r_MParse_String_IFormatProvider;
			}
		}

		/// <summary>
		/// System.Decimal Parse(System.String, System.Globalization.NumberStyles, System.IFormatProvider)
		/// </summary>
		protected static RMethod r_MParse_String_NumberStyles_IFormatProvider;
		public static RMethod RMParse_String_NumberStyles_IFormatProvider
		{
			get
			{
				if(r_MParse_String_NumberStyles_IFormatProvider == null)
				{
					r_MParse_String_NumberStyles_IFormatProvider = new(typeof(System.Decimal), "Parse", 0, typeof(System.String), typeof(System.Globalization.NumberStyles), typeof(System.IFormatProvider));
					r_MParse_String_NumberStyles_IFormatProvider.SetBelong(null);
				}
				return r_MParse_String_NumberStyles_IFormatProvider;
			}
		}

		/// <summary>
		/// System.Decimal Parse(System.ReadOnlySpan`1[System.Char], System.Globalization.NumberStyles, System.IFormatProvider)
		/// </summary>
		protected static RMethod r_MParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider;
		public static RMethod RMParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider
		{
			get
			{
				if(r_MParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider == null)
				{
					r_MParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider = new(typeof(System.Decimal), "Parse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.NumberStyles), typeof(System.IFormatProvider));
					r_MParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider.SetBelong(null);
				}
				return r_MParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.String, System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_String_Out_Decimal;
		public static RMethod RMTryParse_String_Out_Decimal
		{
			get
			{
				if(r_MTryParse_String_Out_Decimal == null)
				{
					r_MTryParse_String_Out_Decimal = new(typeof(System.Decimal), "TryParse", 0, typeof(System.String), typeof(System.Decimal).MakeByRefType());
					r_MTryParse_String_Out_Decimal.SetBelong(null);
				}
				return r_MTryParse_String_Out_Decimal;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_ReadOnlySpan_d_Char_p__Out_Decimal;
		public static RMethod RMTryParse_ReadOnlySpan_d_Char_p__Out_Decimal
		{
			get
			{
				if(r_MTryParse_ReadOnlySpan_d_Char_p__Out_Decimal == null)
				{
					r_MTryParse_ReadOnlySpan_d_Char_p__Out_Decimal = new(typeof(System.Decimal), "TryParse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Decimal).MakeByRefType());
					r_MTryParse_ReadOnlySpan_d_Char_p__Out_Decimal.SetBelong(null);
				}
				return r_MTryParse_ReadOnlySpan_d_Char_p__Out_Decimal;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.String, System.Globalization.NumberStyles, System.IFormatProvider, System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_String_NumberStyles_IFormatProvider_Out_Decimal;
		public static RMethod RMTryParse_String_NumberStyles_IFormatProvider_Out_Decimal
		{
			get
			{
				if(r_MTryParse_String_NumberStyles_IFormatProvider_Out_Decimal == null)
				{
					r_MTryParse_String_NumberStyles_IFormatProvider_Out_Decimal = new(typeof(System.Decimal), "TryParse", 0, typeof(System.String), typeof(System.Globalization.NumberStyles), typeof(System.IFormatProvider), typeof(System.Decimal).MakeByRefType());
					r_MTryParse_String_NumberStyles_IFormatProvider_Out_Decimal.SetBelong(null);
				}
				return r_MTryParse_String_NumberStyles_IFormatProvider_Out_Decimal;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], System.Globalization.NumberStyles, System.IFormatProvider, System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Decimal;
		public static RMethod RMTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Decimal
		{
			get
			{
				if(r_MTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Decimal == null)
				{
					r_MTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Decimal = new(typeof(System.Decimal), "TryParse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.NumberStyles), typeof(System.IFormatProvider), typeof(System.Decimal).MakeByRefType());
					r_MTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Decimal.SetBelong(null);
				}
				return r_MTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Decimal;
			}
		}

		/// <summary>
		/// Int32[] GetBits(System.Decimal)
		/// </summary>
		protected static RMethod r_MGetBits_Decimal;
		public static RMethod RMGetBits_Decimal
		{
			get
			{
				if(r_MGetBits_Decimal == null)
				{
					r_MGetBits_Decimal = new(typeof(System.Decimal), "GetBits", 0, typeof(System.Decimal));
					r_MGetBits_Decimal.SetBelong(null);
				}
				return r_MGetBits_Decimal;
			}
		}

		/// <summary>
		/// Void GetBytes(System.Decimal ByRef, Byte[])
		/// </summary>
		protected static RMethod r_MGetBytes_In_Decimal_ByteArray;
		public static RMethod RMGetBytes_In_Decimal_ByteArray
		{
			get
			{
				if(r_MGetBytes_In_Decimal_ByteArray == null)
				{
					r_MGetBytes_In_Decimal_ByteArray = new(typeof(System.Decimal), "GetBytes", 0, typeof(System.Decimal).MakeByRefType(), typeof(System.Byte).MakeArrayType());
					r_MGetBytes_In_Decimal_ByteArray.SetBelong(null);
				}
				return r_MGetBytes_In_Decimal_ByteArray;
			}
		}

		/// <summary>
		/// System.Decimal ToDecimal(Byte[])
		/// </summary>
		protected static RMethod r_MToDecimal_ByteArray;
		public static RMethod RMToDecimal_ByteArray
		{
			get
			{
				if(r_MToDecimal_ByteArray == null)
				{
					r_MToDecimal_ByteArray = new(typeof(System.Decimal), "ToDecimal", 0, typeof(System.Byte).MakeArrayType());
					r_MToDecimal_ByteArray.SetBelong(null);
				}
				return r_MToDecimal_ByteArray;
			}
		}

		/// <summary>
		/// System.Decimal& Max(System.Decimal ByRef, System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_MMax_Ref_Decimal_Ref_Decimal;
		public static RMethod RMMax_Ref_Decimal_Ref_Decimal
		{
			get
			{
				if(r_MMax_Ref_Decimal_Ref_Decimal == null)
				{
					r_MMax_Ref_Decimal_Ref_Decimal = new(typeof(System.Decimal), "Max", 0, typeof(System.Decimal).MakeByRefType(), typeof(System.Decimal).MakeByRefType());
					r_MMax_Ref_Decimal_Ref_Decimal.SetBelong(null);
				}
				return r_MMax_Ref_Decimal_Ref_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal& Min(System.Decimal ByRef, System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_MMin_Ref_Decimal_Ref_Decimal;
		public static RMethod RMMin_Ref_Decimal_Ref_Decimal
		{
			get
			{
				if(r_MMin_Ref_Decimal_Ref_Decimal == null)
				{
					r_MMin_Ref_Decimal_Ref_Decimal = new(typeof(System.Decimal), "Min", 0, typeof(System.Decimal).MakeByRefType(), typeof(System.Decimal).MakeByRefType());
					r_MMin_Ref_Decimal_Ref_Decimal.SetBelong(null);
				}
				return r_MMin_Ref_Decimal_Ref_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal Remainder(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_MRemainder_Decimal_Decimal;
		public static RMethod RMRemainder_Decimal_Decimal
		{
			get
			{
				if(r_MRemainder_Decimal_Decimal == null)
				{
					r_MRemainder_Decimal_Decimal = new(typeof(System.Decimal), "Remainder", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_MRemainder_Decimal_Decimal.SetBelong(null);
				}
				return r_MRemainder_Decimal_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal Multiply(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_MMultiply_Decimal_Decimal;
		public static RMethod RMMultiply_Decimal_Decimal
		{
			get
			{
				if(r_MMultiply_Decimal_Decimal == null)
				{
					r_MMultiply_Decimal_Decimal = new(typeof(System.Decimal), "Multiply", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_MMultiply_Decimal_Decimal.SetBelong(null);
				}
				return r_MMultiply_Decimal_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal Negate(System.Decimal)
		/// </summary>
		protected static RMethod r_MNegate_Decimal;
		public static RMethod RMNegate_Decimal
		{
			get
			{
				if(r_MNegate_Decimal == null)
				{
					r_MNegate_Decimal = new(typeof(System.Decimal), "Negate", 0, typeof(System.Decimal));
					r_MNegate_Decimal.SetBelong(null);
				}
				return r_MNegate_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal Round(System.Decimal)
		/// </summary>
		protected static RMethod r_MRound_Decimal;
		public static RMethod RMRound_Decimal
		{
			get
			{
				if(r_MRound_Decimal == null)
				{
					r_MRound_Decimal = new(typeof(System.Decimal), "Round", 0, typeof(System.Decimal));
					r_MRound_Decimal.SetBelong(null);
				}
				return r_MRound_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal Round(System.Decimal, Int32)
		/// </summary>
		protected static RMethod r_MRound_Decimal_Int32;
		public static RMethod RMRound_Decimal_Int32
		{
			get
			{
				if(r_MRound_Decimal_Int32 == null)
				{
					r_MRound_Decimal_Int32 = new(typeof(System.Decimal), "Round", 0, typeof(System.Decimal), typeof(System.Int32));
					r_MRound_Decimal_Int32.SetBelong(null);
				}
				return r_MRound_Decimal_Int32;
			}
		}

		/// <summary>
		/// System.Decimal Round(System.Decimal, System.MidpointRounding)
		/// </summary>
		protected static RMethod r_MRound_Decimal_MidpointRounding;
		public static RMethod RMRound_Decimal_MidpointRounding
		{
			get
			{
				if(r_MRound_Decimal_MidpointRounding == null)
				{
					r_MRound_Decimal_MidpointRounding = new(typeof(System.Decimal), "Round", 0, typeof(System.Decimal), typeof(System.MidpointRounding));
					r_MRound_Decimal_MidpointRounding.SetBelong(null);
				}
				return r_MRound_Decimal_MidpointRounding;
			}
		}

		/// <summary>
		/// System.Decimal Round(System.Decimal, Int32, System.MidpointRounding)
		/// </summary>
		protected static RMethod r_MRound_Decimal_Int32_MidpointRounding;
		public static RMethod RMRound_Decimal_Int32_MidpointRounding
		{
			get
			{
				if(r_MRound_Decimal_Int32_MidpointRounding == null)
				{
					r_MRound_Decimal_Int32_MidpointRounding = new(typeof(System.Decimal), "Round", 0, typeof(System.Decimal), typeof(System.Int32), typeof(System.MidpointRounding));
					r_MRound_Decimal_Int32_MidpointRounding.SetBelong(null);
				}
				return r_MRound_Decimal_Int32_MidpointRounding;
			}
		}

		/// <summary>
		/// System.Decimal Round(System.Decimal ByRef, Int32, System.MidpointRounding)
		/// </summary>
		protected static RMethod r_MRound_Ref_Decimal_Int32_MidpointRounding;
		public static RMethod RMRound_Ref_Decimal_Int32_MidpointRounding
		{
			get
			{
				if(r_MRound_Ref_Decimal_Int32_MidpointRounding == null)
				{
					r_MRound_Ref_Decimal_Int32_MidpointRounding = new(typeof(System.Decimal), "Round", 0, typeof(System.Decimal).MakeByRefType(), typeof(System.Int32), typeof(System.MidpointRounding));
					r_MRound_Ref_Decimal_Int32_MidpointRounding.SetBelong(null);
				}
				return r_MRound_Ref_Decimal_Int32_MidpointRounding;
			}
		}

		/// <summary>
		/// Int32 Sign(System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_MSign_Ref_Decimal;
		public static RMethod RMSign_Ref_Decimal
		{
			get
			{
				if(r_MSign_Ref_Decimal == null)
				{
					r_MSign_Ref_Decimal = new(typeof(System.Decimal), "Sign", 0, typeof(System.Decimal).MakeByRefType());
					r_MSign_Ref_Decimal.SetBelong(null);
				}
				return r_MSign_Ref_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal Subtract(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_MSubtract_Decimal_Decimal;
		public static RMethod RMSubtract_Decimal_Decimal
		{
			get
			{
				if(r_MSubtract_Decimal_Decimal == null)
				{
					r_MSubtract_Decimal_Decimal = new(typeof(System.Decimal), "Subtract", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_MSubtract_Decimal_Decimal.SetBelong(null);
				}
				return r_MSubtract_Decimal_Decimal;
			}
		}

		/// <summary>
		/// Byte ToByte(System.Decimal)
		/// </summary>
		protected static RMethod r_MToByte_Decimal;
		public static RMethod RMToByte_Decimal
		{
			get
			{
				if(r_MToByte_Decimal == null)
				{
					r_MToByte_Decimal = new(typeof(System.Decimal), "ToByte", 0, typeof(System.Decimal));
					r_MToByte_Decimal.SetBelong(null);
				}
				return r_MToByte_Decimal;
			}
		}

		/// <summary>
		/// SByte ToSByte(System.Decimal)
		/// </summary>
		protected static RMethod r_MToSByte_Decimal;
		public static RMethod RMToSByte_Decimal
		{
			get
			{
				if(r_MToSByte_Decimal == null)
				{
					r_MToSByte_Decimal = new(typeof(System.Decimal), "ToSByte", 0, typeof(System.Decimal));
					r_MToSByte_Decimal.SetBelong(null);
				}
				return r_MToSByte_Decimal;
			}
		}

		/// <summary>
		/// Int16 ToInt16(System.Decimal)
		/// </summary>
		protected static RMethod r_MToInt16_Decimal;
		public static RMethod RMToInt16_Decimal
		{
			get
			{
				if(r_MToInt16_Decimal == null)
				{
					r_MToInt16_Decimal = new(typeof(System.Decimal), "ToInt16", 0, typeof(System.Decimal));
					r_MToInt16_Decimal.SetBelong(null);
				}
				return r_MToInt16_Decimal;
			}
		}

		/// <summary>
		/// Double ToDouble(System.Decimal)
		/// </summary>
		protected static RMethod r_MToDouble_Decimal;
		public static RMethod RMToDouble_Decimal
		{
			get
			{
				if(r_MToDouble_Decimal == null)
				{
					r_MToDouble_Decimal = new(typeof(System.Decimal), "ToDouble", 0, typeof(System.Decimal));
					r_MToDouble_Decimal.SetBelong(null);
				}
				return r_MToDouble_Decimal;
			}
		}

		/// <summary>
		/// Int32 ToInt32(System.Decimal)
		/// </summary>
		protected static RMethod r_MToInt32_Decimal;
		public static RMethod RMToInt32_Decimal
		{
			get
			{
				if(r_MToInt32_Decimal == null)
				{
					r_MToInt32_Decimal = new(typeof(System.Decimal), "ToInt32", 0, typeof(System.Decimal));
					r_MToInt32_Decimal.SetBelong(null);
				}
				return r_MToInt32_Decimal;
			}
		}

		/// <summary>
		/// Int64 ToInt64(System.Decimal)
		/// </summary>
		protected static RMethod r_MToInt64_Decimal;
		public static RMethod RMToInt64_Decimal
		{
			get
			{
				if(r_MToInt64_Decimal == null)
				{
					r_MToInt64_Decimal = new(typeof(System.Decimal), "ToInt64", 0, typeof(System.Decimal));
					r_MToInt64_Decimal.SetBelong(null);
				}
				return r_MToInt64_Decimal;
			}
		}

		/// <summary>
		/// UInt16 ToUInt16(System.Decimal)
		/// </summary>
		protected static RMethod r_MToUInt16_Decimal;
		public static RMethod RMToUInt16_Decimal
		{
			get
			{
				if(r_MToUInt16_Decimal == null)
				{
					r_MToUInt16_Decimal = new(typeof(System.Decimal), "ToUInt16", 0, typeof(System.Decimal));
					r_MToUInt16_Decimal.SetBelong(null);
				}
				return r_MToUInt16_Decimal;
			}
		}

		/// <summary>
		/// UInt32 ToUInt32(System.Decimal)
		/// </summary>
		protected static RMethod r_MToUInt32_Decimal;
		public static RMethod RMToUInt32_Decimal
		{
			get
			{
				if(r_MToUInt32_Decimal == null)
				{
					r_MToUInt32_Decimal = new(typeof(System.Decimal), "ToUInt32", 0, typeof(System.Decimal));
					r_MToUInt32_Decimal.SetBelong(null);
				}
				return r_MToUInt32_Decimal;
			}
		}

		/// <summary>
		/// UInt64 ToUInt64(System.Decimal)
		/// </summary>
		protected static RMethod r_MToUInt64_Decimal;
		public static RMethod RMToUInt64_Decimal
		{
			get
			{
				if(r_MToUInt64_Decimal == null)
				{
					r_MToUInt64_Decimal = new(typeof(System.Decimal), "ToUInt64", 0, typeof(System.Decimal));
					r_MToUInt64_Decimal.SetBelong(null);
				}
				return r_MToUInt64_Decimal;
			}
		}

		/// <summary>
		/// Single ToSingle(System.Decimal)
		/// </summary>
		protected static RMethod r_MToSingle_Decimal;
		public static RMethod RMToSingle_Decimal
		{
			get
			{
				if(r_MToSingle_Decimal == null)
				{
					r_MToSingle_Decimal = new(typeof(System.Decimal), "ToSingle", 0, typeof(System.Decimal));
					r_MToSingle_Decimal.SetBelong(null);
				}
				return r_MToSingle_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal Truncate(System.Decimal)
		/// </summary>
		protected static RMethod r_MTruncate_Decimal;
		public static RMethod RMTruncate_Decimal
		{
			get
			{
				if(r_MTruncate_Decimal == null)
				{
					r_MTruncate_Decimal = new(typeof(System.Decimal), "Truncate", 0, typeof(System.Decimal));
					r_MTruncate_Decimal.SetBelong(null);
				}
				return r_MTruncate_Decimal;
			}
		}

		/// <summary>
		/// Void Truncate(System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_MTruncate_Ref_Decimal;
		public static RMethod RMTruncate_Ref_Decimal
		{
			get
			{
				if(r_MTruncate_Ref_Decimal == null)
				{
					r_MTruncate_Ref_Decimal = new(typeof(System.Decimal), "Truncate", 0, typeof(System.Decimal).MakeByRefType());
					r_MTruncate_Ref_Decimal.SetBelong(null);
				}
				return r_MTruncate_Ref_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal op_Implicit(Byte)
		/// </summary>
		protected static RMethod r_Mop_Implicit_Byte;
		public static RMethod RMop_Implicit_Byte
		{
			get
			{
				if(r_Mop_Implicit_Byte == null)
				{
					r_Mop_Implicit_Byte = new(typeof(System.Decimal), "op_Implicit", 0, typeof(System.Byte));
					r_Mop_Implicit_Byte.SetBelong(null);
				}
				return r_Mop_Implicit_Byte;
			}
		}

		/// <summary>
		/// System.Decimal op_Implicit(SByte)
		/// </summary>
		protected static RMethod r_Mop_Implicit_SByte;
		public static RMethod RMop_Implicit_SByte
		{
			get
			{
				if(r_Mop_Implicit_SByte == null)
				{
					r_Mop_Implicit_SByte = new(typeof(System.Decimal), "op_Implicit", 0, typeof(System.SByte));
					r_Mop_Implicit_SByte.SetBelong(null);
				}
				return r_Mop_Implicit_SByte;
			}
		}

		/// <summary>
		/// System.Decimal op_Implicit(Int16)
		/// </summary>
		protected static RMethod r_Mop_Implicit_Int16;
		public static RMethod RMop_Implicit_Int16
		{
			get
			{
				if(r_Mop_Implicit_Int16 == null)
				{
					r_Mop_Implicit_Int16 = new(typeof(System.Decimal), "op_Implicit", 0, typeof(System.Int16));
					r_Mop_Implicit_Int16.SetBelong(null);
				}
				return r_Mop_Implicit_Int16;
			}
		}

		/// <summary>
		/// System.Decimal op_Implicit(UInt16)
		/// </summary>
		protected static RMethod r_Mop_Implicit_UInt16;
		public static RMethod RMop_Implicit_UInt16
		{
			get
			{
				if(r_Mop_Implicit_UInt16 == null)
				{
					r_Mop_Implicit_UInt16 = new(typeof(System.Decimal), "op_Implicit", 0, typeof(System.UInt16));
					r_Mop_Implicit_UInt16.SetBelong(null);
				}
				return r_Mop_Implicit_UInt16;
			}
		}

		/// <summary>
		/// System.Decimal op_Implicit(Char)
		/// </summary>
		protected static RMethod r_Mop_Implicit_Char;
		public static RMethod RMop_Implicit_Char
		{
			get
			{
				if(r_Mop_Implicit_Char == null)
				{
					r_Mop_Implicit_Char = new(typeof(System.Decimal), "op_Implicit", 0, typeof(System.Char));
					r_Mop_Implicit_Char.SetBelong(null);
				}
				return r_Mop_Implicit_Char;
			}
		}

		/// <summary>
		/// System.Decimal op_Implicit(Int32)
		/// </summary>
		protected static RMethod r_Mop_Implicit_Int32;
		public static RMethod RMop_Implicit_Int32
		{
			get
			{
				if(r_Mop_Implicit_Int32 == null)
				{
					r_Mop_Implicit_Int32 = new(typeof(System.Decimal), "op_Implicit", 0, typeof(System.Int32));
					r_Mop_Implicit_Int32.SetBelong(null);
				}
				return r_Mop_Implicit_Int32;
			}
		}

		/// <summary>
		/// System.Decimal op_Implicit(UInt32)
		/// </summary>
		protected static RMethod r_Mop_Implicit_UInt32;
		public static RMethod RMop_Implicit_UInt32
		{
			get
			{
				if(r_Mop_Implicit_UInt32 == null)
				{
					r_Mop_Implicit_UInt32 = new(typeof(System.Decimal), "op_Implicit", 0, typeof(System.UInt32));
					r_Mop_Implicit_UInt32.SetBelong(null);
				}
				return r_Mop_Implicit_UInt32;
			}
		}

		/// <summary>
		/// System.Decimal op_Implicit(Int64)
		/// </summary>
		protected static RMethod r_Mop_Implicit_Int64;
		public static RMethod RMop_Implicit_Int64
		{
			get
			{
				if(r_Mop_Implicit_Int64 == null)
				{
					r_Mop_Implicit_Int64 = new(typeof(System.Decimal), "op_Implicit", 0, typeof(System.Int64));
					r_Mop_Implicit_Int64.SetBelong(null);
				}
				return r_Mop_Implicit_Int64;
			}
		}

		/// <summary>
		/// System.Decimal op_Implicit(UInt64)
		/// </summary>
		protected static RMethod r_Mop_Implicit_UInt64;
		public static RMethod RMop_Implicit_UInt64
		{
			get
			{
				if(r_Mop_Implicit_UInt64 == null)
				{
					r_Mop_Implicit_UInt64 = new(typeof(System.Decimal), "op_Implicit", 0, typeof(System.UInt64));
					r_Mop_Implicit_UInt64.SetBelong(null);
				}
				return r_Mop_Implicit_UInt64;
			}
		}

		/// <summary>
		/// System.Decimal op_Explicit(Single)
		/// </summary>
		protected static RMethod r_Mop_Explicit_Single;
		public static RMethod RMop_Explicit_Single
		{
			get
			{
				if(r_Mop_Explicit_Single == null)
				{
					r_Mop_Explicit_Single = new(typeof(System.Decimal), "op_Explicit", 0, typeof(System.Single));
					r_Mop_Explicit_Single.SetBelong(null);
				}
				return r_Mop_Explicit_Single;
			}
		}

		/// <summary>
		/// System.Decimal op_Explicit(Double)
		/// </summary>
		protected static RMethod r_Mop_Explicit_Double;
		public static RMethod RMop_Explicit_Double
		{
			get
			{
				if(r_Mop_Explicit_Double == null)
				{
					r_Mop_Explicit_Double = new(typeof(System.Decimal), "op_Explicit", 0, typeof(System.Double));
					r_Mop_Explicit_Double.SetBelong(null);
				}
				return r_Mop_Explicit_Double;
			}
		}

		/// <summary>
		/// Byte op_Explicit(System.Decimal)
		/// </summary>
		protected static RMethod r_Mop_Explicit_Decimal;
		public static RMethod RMop_Explicit_Decimal
		{
			get
			{
				if(r_Mop_Explicit_Decimal == null)
				{
					r_Mop_Explicit_Decimal = new(typeof(System.Decimal), "op_Explicit", 0, typeof(System.Decimal));
					r_Mop_Explicit_Decimal.SetBelong(null);
				}
				return r_Mop_Explicit_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal op_UnaryPlus(System.Decimal)
		/// </summary>
		protected static RMethod r_Mop_UnaryPlus_Decimal;
		public static RMethod RMop_UnaryPlus_Decimal
		{
			get
			{
				if(r_Mop_UnaryPlus_Decimal == null)
				{
					r_Mop_UnaryPlus_Decimal = new(typeof(System.Decimal), "op_UnaryPlus", 0, typeof(System.Decimal));
					r_Mop_UnaryPlus_Decimal.SetBelong(null);
				}
				return r_Mop_UnaryPlus_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal op_UnaryNegation(System.Decimal)
		/// </summary>
		protected static RMethod r_Mop_UnaryNegation_Decimal;
		public static RMethod RMop_UnaryNegation_Decimal
		{
			get
			{
				if(r_Mop_UnaryNegation_Decimal == null)
				{
					r_Mop_UnaryNegation_Decimal = new(typeof(System.Decimal), "op_UnaryNegation", 0, typeof(System.Decimal));
					r_Mop_UnaryNegation_Decimal.SetBelong(null);
				}
				return r_Mop_UnaryNegation_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal op_Increment(System.Decimal)
		/// </summary>
		protected static RMethod r_Mop_Increment_Decimal;
		public static RMethod RMop_Increment_Decimal
		{
			get
			{
				if(r_Mop_Increment_Decimal == null)
				{
					r_Mop_Increment_Decimal = new(typeof(System.Decimal), "op_Increment", 0, typeof(System.Decimal));
					r_Mop_Increment_Decimal.SetBelong(null);
				}
				return r_Mop_Increment_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal op_Decrement(System.Decimal)
		/// </summary>
		protected static RMethod r_Mop_Decrement_Decimal;
		public static RMethod RMop_Decrement_Decimal
		{
			get
			{
				if(r_Mop_Decrement_Decimal == null)
				{
					r_Mop_Decrement_Decimal = new(typeof(System.Decimal), "op_Decrement", 0, typeof(System.Decimal));
					r_Mop_Decrement_Decimal.SetBelong(null);
				}
				return r_Mop_Decrement_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal op_Addition(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_Mop_Addition_Decimal_Decimal;
		public static RMethod RMop_Addition_Decimal_Decimal
		{
			get
			{
				if(r_Mop_Addition_Decimal_Decimal == null)
				{
					r_Mop_Addition_Decimal_Decimal = new(typeof(System.Decimal), "op_Addition", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_Mop_Addition_Decimal_Decimal.SetBelong(null);
				}
				return r_Mop_Addition_Decimal_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal op_Subtraction(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_Mop_Subtraction_Decimal_Decimal;
		public static RMethod RMop_Subtraction_Decimal_Decimal
		{
			get
			{
				if(r_Mop_Subtraction_Decimal_Decimal == null)
				{
					r_Mop_Subtraction_Decimal_Decimal = new(typeof(System.Decimal), "op_Subtraction", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_Mop_Subtraction_Decimal_Decimal.SetBelong(null);
				}
				return r_Mop_Subtraction_Decimal_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal op_Multiply(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_Mop_Multiply_Decimal_Decimal;
		public static RMethod RMop_Multiply_Decimal_Decimal
		{
			get
			{
				if(r_Mop_Multiply_Decimal_Decimal == null)
				{
					r_Mop_Multiply_Decimal_Decimal = new(typeof(System.Decimal), "op_Multiply", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_Mop_Multiply_Decimal_Decimal.SetBelong(null);
				}
				return r_Mop_Multiply_Decimal_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal op_Division(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_Mop_Division_Decimal_Decimal;
		public static RMethod RMop_Division_Decimal_Decimal
		{
			get
			{
				if(r_Mop_Division_Decimal_Decimal == null)
				{
					r_Mop_Division_Decimal_Decimal = new(typeof(System.Decimal), "op_Division", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_Mop_Division_Decimal_Decimal.SetBelong(null);
				}
				return r_Mop_Division_Decimal_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal op_Modulus(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_Mop_Modulus_Decimal_Decimal;
		public static RMethod RMop_Modulus_Decimal_Decimal
		{
			get
			{
				if(r_Mop_Modulus_Decimal_Decimal == null)
				{
					r_Mop_Modulus_Decimal_Decimal = new(typeof(System.Decimal), "op_Modulus", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_Mop_Modulus_Decimal_Decimal.SetBelong(null);
				}
				return r_Mop_Modulus_Decimal_Decimal;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_Mop_Equality_Decimal_Decimal;
		public static RMethod RMop_Equality_Decimal_Decimal
		{
			get
			{
				if(r_Mop_Equality_Decimal_Decimal == null)
				{
					r_Mop_Equality_Decimal_Decimal = new(typeof(System.Decimal), "op_Equality", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_Mop_Equality_Decimal_Decimal.SetBelong(null);
				}
				return r_Mop_Equality_Decimal_Decimal;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_Mop_Inequality_Decimal_Decimal;
		public static RMethod RMop_Inequality_Decimal_Decimal
		{
			get
			{
				if(r_Mop_Inequality_Decimal_Decimal == null)
				{
					r_Mop_Inequality_Decimal_Decimal = new(typeof(System.Decimal), "op_Inequality", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_Mop_Inequality_Decimal_Decimal.SetBelong(null);
				}
				return r_Mop_Inequality_Decimal_Decimal;
			}
		}

		/// <summary>
		/// Boolean op_LessThan(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_Mop_LessThan_Decimal_Decimal;
		public static RMethod RMop_LessThan_Decimal_Decimal
		{
			get
			{
				if(r_Mop_LessThan_Decimal_Decimal == null)
				{
					r_Mop_LessThan_Decimal_Decimal = new(typeof(System.Decimal), "op_LessThan", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_Mop_LessThan_Decimal_Decimal.SetBelong(null);
				}
				return r_Mop_LessThan_Decimal_Decimal;
			}
		}

		/// <summary>
		/// Boolean op_LessThanOrEqual(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_Mop_LessThanOrEqual_Decimal_Decimal;
		public static RMethod RMop_LessThanOrEqual_Decimal_Decimal
		{
			get
			{
				if(r_Mop_LessThanOrEqual_Decimal_Decimal == null)
				{
					r_Mop_LessThanOrEqual_Decimal_Decimal = new(typeof(System.Decimal), "op_LessThanOrEqual", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_Mop_LessThanOrEqual_Decimal_Decimal.SetBelong(null);
				}
				return r_Mop_LessThanOrEqual_Decimal_Decimal;
			}
		}

		/// <summary>
		/// Boolean op_GreaterThan(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_Mop_GreaterThan_Decimal_Decimal;
		public static RMethod RMop_GreaterThan_Decimal_Decimal
		{
			get
			{
				if(r_Mop_GreaterThan_Decimal_Decimal == null)
				{
					r_Mop_GreaterThan_Decimal_Decimal = new(typeof(System.Decimal), "op_GreaterThan", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_Mop_GreaterThan_Decimal_Decimal.SetBelong(null);
				}
				return r_Mop_GreaterThan_Decimal_Decimal;
			}
		}

		/// <summary>
		/// Boolean op_GreaterThanOrEqual(System.Decimal, System.Decimal)
		/// </summary>
		protected static RMethod r_Mop_GreaterThanOrEqual_Decimal_Decimal;
		public static RMethod RMop_GreaterThanOrEqual_Decimal_Decimal
		{
			get
			{
				if(r_Mop_GreaterThanOrEqual_Decimal_Decimal == null)
				{
					r_Mop_GreaterThanOrEqual_Decimal_Decimal = new(typeof(System.Decimal), "op_GreaterThanOrEqual", 0, typeof(System.Decimal), typeof(System.Decimal));
					r_Mop_GreaterThanOrEqual_Decimal_Decimal.SetBelong(null);
				}
				return r_Mop_GreaterThanOrEqual_Decimal_Decimal;
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

        public static SMFrame.Editor.Refleaction.RSystem.RDecimal.RDecCalc AsMutable(ref System.Decimal @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMAsMutable_Ref_Decimal.Invoke(___genericsType, ___parameters);
			@d = (System.Decimal)___parameters[0];

            return new SMFrame.Editor.Refleaction.RSystem.RDecimal.RDecCalc(___result);
        }


        public static System.UInt32 DecDivMod1E9(ref System.Decimal @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMDecDivMod1E9_Ref_Decimal.Invoke(___genericsType, ___parameters);
			@value = (System.Decimal)___parameters[0];

            return (System.UInt32)___result;
        }


        public static System.Decimal FromOACurrency(System.Int64 @cy)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cy};
            var ___result = RMFromOACurrency_Int64.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Int64 ToOACurrency(System.Decimal @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMToOACurrency_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public static System.Boolean IsValid(System.Int32 @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flags};
            var ___result = RMIsValid_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void System__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization(System.Object @sender)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender};
            var ___result = RMSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Decimal Abs(ref System.Decimal @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMAbs_Ref_Decimal.Invoke(___genericsType, ___parameters);
			@d = (System.Decimal)___parameters[0];

            return (System.Decimal)___result;
        }


        public static System.Decimal Add(System.Decimal @d1, System.Decimal @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RMAdd_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal Ceiling(System.Decimal @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMCeiling_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Int32 Compare(System.Decimal @d1, System.Decimal @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RMCompare_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareTo(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareTo(System.Decimal @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMCompareTo_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Decimal Divide(System.Decimal @d1, System.Decimal @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RMDivide_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public virtual System.Boolean Equals(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Decimal @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMEquals_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean Equals(System.Decimal @d1, System.Decimal @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RMEquals_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Decimal Floor(System.Decimal @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMFloor_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
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


        public virtual System.Boolean TryFormat(SMFrame.Editor.Refleaction.RSystem.RSpan<SMFrame.Editor.Refleaction.RSystem.RChar> @destination, out System.Int32 @charsWritten, SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RSystem.RChar> @format, System.IFormatProvider @provider)
        {
			@charsWritten = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination.Value, @charsWritten, @format.Value, @provider};
            var ___result = RMTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider.Invoke(___genericsType, ___parameters);
			@charsWritten = (System.Int32)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.Decimal Parse(System.String @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RMParse_String.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal Parse(System.String @s, System.Globalization.NumberStyles @style)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @style};
            var ___result = RMParse_String_NumberStyles.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal Parse(System.String @s, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @provider};
            var ___result = RMParse_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal Parse(System.String @s, System.Globalization.NumberStyles @style, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @style, @provider};
            var ___result = RMParse_String_NumberStyles_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal Parse(SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RSystem.RChar> @s, System.Globalization.NumberStyles @style, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @style, @provider};
            var ___result = RMParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Boolean TryParse(System.String @s, out System.Decimal @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @result};
            var ___result = RMTryParse_String_Out_Decimal.Invoke(___genericsType, ___parameters);
			@result = (System.Decimal)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParse(SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RSystem.RChar> @s, out System.Decimal @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @result};
            var ___result = RMTryParse_ReadOnlySpan_d_Char_p__Out_Decimal.Invoke(___genericsType, ___parameters);
			@result = (System.Decimal)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParse(System.String @s, System.Globalization.NumberStyles @style, System.IFormatProvider @provider, out System.Decimal @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @style, @provider, @result};
            var ___result = RMTryParse_String_NumberStyles_IFormatProvider_Out_Decimal.Invoke(___genericsType, ___parameters);
			@result = (System.Decimal)___parameters[3];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParse(SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RSystem.RChar> @s, System.Globalization.NumberStyles @style, System.IFormatProvider @provider, out System.Decimal @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @style, @provider, @result};
            var ___result = RMTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Decimal.Invoke(___genericsType, ___parameters);
			@result = (System.Decimal)___parameters[3];

            return (System.Boolean)___result;
        }


        public static System.Int32[] GetBits(System.Decimal @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMGetBits_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Int32[])___result;
        }


        public static void GetBytes(in System.Decimal @d, System.Byte[] @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d, @buffer};
            var ___result = RMGetBytes_In_Decimal_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Decimal ToDecimal(System.Byte[] @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer};
            var ___result = RMToDecimal_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal Max(ref System.Decimal @d1, ref System.Decimal @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RMMax_Ref_Decimal_Ref_Decimal.Invoke(___genericsType, ___parameters);
			@d1 = (System.Decimal)___parameters[0];
			@d2 = (System.Decimal)___parameters[1];

            return (System.Decimal)___result;
        }


        public static System.Decimal Min(ref System.Decimal @d1, ref System.Decimal @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RMMin_Ref_Decimal_Ref_Decimal.Invoke(___genericsType, ___parameters);
			@d1 = (System.Decimal)___parameters[0];
			@d2 = (System.Decimal)___parameters[1];

            return (System.Decimal)___result;
        }


        public static System.Decimal Remainder(System.Decimal @d1, System.Decimal @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RMRemainder_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal Multiply(System.Decimal @d1, System.Decimal @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RMMultiply_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal Negate(System.Decimal @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMNegate_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal Round(System.Decimal @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMRound_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal Round(System.Decimal @d, System.Int32 @decimals)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d, @decimals};
            var ___result = RMRound_Decimal_Int32.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal Round(System.Decimal @d, System.MidpointRounding @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d, @mode};
            var ___result = RMRound_Decimal_MidpointRounding.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal Round(System.Decimal @d, System.Int32 @decimals, System.MidpointRounding @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d, @decimals, @mode};
            var ___result = RMRound_Decimal_Int32_MidpointRounding.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal Round(ref System.Decimal @d, System.Int32 @decimals, System.MidpointRounding @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d, @decimals, @mode};
            var ___result = RMRound_Ref_Decimal_Int32_MidpointRounding.Invoke(___genericsType, ___parameters);
			@d = (System.Decimal)___parameters[0];

            return (System.Decimal)___result;
        }


        public static System.Int32 Sign(ref System.Decimal @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMSign_Ref_Decimal.Invoke(___genericsType, ___parameters);
			@d = (System.Decimal)___parameters[0];

            return (System.Int32)___result;
        }


        public static System.Decimal Subtract(System.Decimal @d1, System.Decimal @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RMSubtract_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Byte ToByte(System.Decimal @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMToByte_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Byte)___result;
        }


        public static System.SByte ToSByte(System.Decimal @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMToSByte_Decimal.Invoke(___genericsType, ___parameters);

            return (System.SByte)___result;
        }


        public static System.Int16 ToInt16(System.Decimal @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMToInt16_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Int16)___result;
        }


        public static System.Double ToDouble(System.Decimal @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMToDouble_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public static System.Int32 ToInt32(System.Decimal @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMToInt32_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int64 ToInt64(System.Decimal @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMToInt64_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public static System.UInt16 ToUInt16(System.Decimal @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMToUInt16_Decimal.Invoke(___genericsType, ___parameters);

            return (System.UInt16)___result;
        }


        public static System.UInt32 ToUInt32(System.Decimal @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMToUInt32_Decimal.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public static System.UInt64 ToUInt64(System.Decimal @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMToUInt64_Decimal.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public static System.Single ToSingle(System.Decimal @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMToSingle_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Decimal Truncate(System.Decimal @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMTruncate_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static void Truncate(ref System.Decimal @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMTruncate_Ref_Decimal.Invoke(___genericsType, ___parameters);
			@d = (System.Decimal)___parameters[0];

            
        }


        public static System.Decimal op_Implicit(System.Byte @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMop_Implicit_Byte.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Implicit(System.SByte @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMop_Implicit_SByte.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Implicit(System.Int16 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMop_Implicit_Int16.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Implicit(System.UInt16 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMop_Implicit_UInt16.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Implicit(System.Char @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMop_Implicit_Char.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Implicit(System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMop_Implicit_Int32.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Implicit(System.UInt32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMop_Implicit_UInt32.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Implicit(System.Int64 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMop_Implicit_Int64.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Implicit(System.UInt64 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMop_Implicit_UInt64.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Explicit(System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMop_Explicit_Single.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Explicit(System.Double @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMop_Explicit_Double.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Byte op_Explicit(System.Decimal @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMop_Explicit_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Byte)___result;
        }


        public static System.Decimal op_UnaryPlus(System.Decimal @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMop_UnaryPlus_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_UnaryNegation(System.Decimal @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMop_UnaryNegation_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Increment(System.Decimal @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMop_Increment_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Decrement(System.Decimal @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMop_Decrement_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Addition(System.Decimal @d1, System.Decimal @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RMop_Addition_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Subtraction(System.Decimal @d1, System.Decimal @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RMop_Subtraction_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Multiply(System.Decimal @d1, System.Decimal @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RMop_Multiply_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Division(System.Decimal @d1, System.Decimal @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RMop_Division_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Decimal op_Modulus(System.Decimal @d1, System.Decimal @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RMop_Modulus_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public static System.Boolean op_Equality(System.Decimal @d1, System.Decimal @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RMop_Equality_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Decimal @d1, System.Decimal @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RMop_Inequality_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_LessThan(System.Decimal @d1, System.Decimal @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RMop_LessThan_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_LessThanOrEqual(System.Decimal @d1, System.Decimal @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RMop_LessThanOrEqual_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_GreaterThan(System.Decimal @d1, System.Decimal @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RMop_GreaterThan_Decimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_GreaterThanOrEqual(System.Decimal @d1, System.Decimal @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RMop_GreaterThanOrEqual_Decimal_Decimal.Invoke(___genericsType, ___parameters);

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
