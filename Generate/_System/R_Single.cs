
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Single
	/// </summary>
    public partial class RSingle : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Single);
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


		/// <summary>
		/// System.Single m_value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_value;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_value
		{
			get
			{
				if(r_Fm_value == null)
				{
					r_Fm_value = new(this, "m_value");
				}
				return r_Fm_value;
			}
		}

		/// <summary>
		/// System.Single MinValue
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_FMinValue;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFMinValue
		{
			get
			{
				if(r_FMinValue == null)
				{
					r_FMinValue = new(Type, "MinValue");
				}
				return r_FMinValue;
			}
		}

		/// <summary>
		/// System.Single Epsilon
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_FEpsilon;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFEpsilon
		{
			get
			{
				if(r_FEpsilon == null)
				{
					r_FEpsilon = new(Type, "Epsilon");
				}
				return r_FEpsilon;
			}
		}

		/// <summary>
		/// System.Single MaxValue
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_FMaxValue;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFMaxValue
		{
			get
			{
				if(r_FMaxValue == null)
				{
					r_FMaxValue = new(Type, "MaxValue");
				}
				return r_FMaxValue;
			}
		}

		/// <summary>
		/// System.Single PositiveInfinity
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_FPositiveInfinity;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFPositiveInfinity
		{
			get
			{
				if(r_FPositiveInfinity == null)
				{
					r_FPositiveInfinity = new(Type, "PositiveInfinity");
				}
				return r_FPositiveInfinity;
			}
		}

		/// <summary>
		/// System.Single NegativeInfinity
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_FNegativeInfinity;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFNegativeInfinity
		{
			get
			{
				if(r_FNegativeInfinity == null)
				{
					r_FNegativeInfinity = new(Type, "NegativeInfinity");
				}
				return r_FNegativeInfinity;
			}
		}

		/// <summary>
		/// System.Single NaN
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_FNaN;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFNaN
		{
			get
			{
				if(r_FNaN == null)
				{
					r_FNaN = new(Type, "NaN");
				}
				return r_FNaN;
			}
		}

		/// <summary>
		/// System.Single NegativeZero
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_FNegativeZero;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFNegativeZero
		{
			get
			{
				if(r_FNegativeZero == null)
				{
					r_FNegativeZero = new(Type, "NegativeZero");
				}
				return r_FNegativeZero;
			}
		}

		/// <summary>
		/// Boolean IsFinite(Single)
		/// </summary>
		protected static RMethod r_MIsFinite_Single;
		public static RMethod RMIsFinite_Single
		{
			get
			{
				if(r_MIsFinite_Single == null)
				{
					r_MIsFinite_Single = new(Type, "IsFinite", 0, typeof(System.Single));
				}
				return r_MIsFinite_Single;
			}
		}

		/// <summary>
		/// Boolean IsInfinity(Single)
		/// </summary>
		protected static RMethod r_MIsInfinity_Single;
		public static RMethod RMIsInfinity_Single
		{
			get
			{
				if(r_MIsInfinity_Single == null)
				{
					r_MIsInfinity_Single = new(Type, "IsInfinity", 0, typeof(System.Single));
				}
				return r_MIsInfinity_Single;
			}
		}

		/// <summary>
		/// Boolean IsNaN(Single)
		/// </summary>
		protected static RMethod r_MIsNaN_Single;
		public static RMethod RMIsNaN_Single
		{
			get
			{
				if(r_MIsNaN_Single == null)
				{
					r_MIsNaN_Single = new(Type, "IsNaN", 0, typeof(System.Single));
				}
				return r_MIsNaN_Single;
			}
		}

		/// <summary>
		/// Boolean IsNegative(Single)
		/// </summary>
		protected static RMethod r_MIsNegative_Single;
		public static RMethod RMIsNegative_Single
		{
			get
			{
				if(r_MIsNegative_Single == null)
				{
					r_MIsNegative_Single = new(Type, "IsNegative", 0, typeof(System.Single));
				}
				return r_MIsNegative_Single;
			}
		}

		/// <summary>
		/// Boolean IsNegativeInfinity(Single)
		/// </summary>
		protected static RMethod r_MIsNegativeInfinity_Single;
		public static RMethod RMIsNegativeInfinity_Single
		{
			get
			{
				if(r_MIsNegativeInfinity_Single == null)
				{
					r_MIsNegativeInfinity_Single = new(Type, "IsNegativeInfinity", 0, typeof(System.Single));
				}
				return r_MIsNegativeInfinity_Single;
			}
		}

		/// <summary>
		/// Boolean IsNormal(Single)
		/// </summary>
		protected static RMethod r_MIsNormal_Single;
		public static RMethod RMIsNormal_Single
		{
			get
			{
				if(r_MIsNormal_Single == null)
				{
					r_MIsNormal_Single = new(Type, "IsNormal", 0, typeof(System.Single));
				}
				return r_MIsNormal_Single;
			}
		}

		/// <summary>
		/// Boolean IsPositiveInfinity(Single)
		/// </summary>
		protected static RMethod r_MIsPositiveInfinity_Single;
		public static RMethod RMIsPositiveInfinity_Single
		{
			get
			{
				if(r_MIsPositiveInfinity_Single == null)
				{
					r_MIsPositiveInfinity_Single = new(Type, "IsPositiveInfinity", 0, typeof(System.Single));
				}
				return r_MIsPositiveInfinity_Single;
			}
		}

		/// <summary>
		/// Boolean IsSubnormal(Single)
		/// </summary>
		protected static RMethod r_MIsSubnormal_Single;
		public static RMethod RMIsSubnormal_Single
		{
			get
			{
				if(r_MIsSubnormal_Single == null)
				{
					r_MIsSubnormal_Single = new(Type, "IsSubnormal", 0, typeof(System.Single));
				}
				return r_MIsSubnormal_Single;
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
				}
				return r_MCompareTo_Object;
			}
		}

		/// <summary>
		/// Int32 CompareTo(Single)
		/// </summary>
		protected RMethod r_MCompareTo_Single;
		public virtual RMethod RMCompareTo_Single
		{
			get
			{
				if(r_MCompareTo_Single == null)
				{
					r_MCompareTo_Single = new(this, "CompareTo", 0, typeof(System.Single));
				}
				return r_MCompareTo_Single;
			}
		}

		/// <summary>
		/// Boolean op_Equality(Single, Single)
		/// </summary>
		protected static RMethod r_Mop_Equality_Single_Single;
		public static RMethod RMop_Equality_Single_Single
		{
			get
			{
				if(r_Mop_Equality_Single_Single == null)
				{
					r_Mop_Equality_Single_Single = new(Type, "op_Equality", 0, typeof(System.Single), typeof(System.Single));
				}
				return r_Mop_Equality_Single_Single;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(Single, Single)
		/// </summary>
		protected static RMethod r_Mop_Inequality_Single_Single;
		public static RMethod RMop_Inequality_Single_Single
		{
			get
			{
				if(r_Mop_Inequality_Single_Single == null)
				{
					r_Mop_Inequality_Single_Single = new(Type, "op_Inequality", 0, typeof(System.Single), typeof(System.Single));
				}
				return r_Mop_Inequality_Single_Single;
			}
		}

		/// <summary>
		/// Boolean op_LessThan(Single, Single)
		/// </summary>
		protected static RMethod r_Mop_LessThan_Single_Single;
		public static RMethod RMop_LessThan_Single_Single
		{
			get
			{
				if(r_Mop_LessThan_Single_Single == null)
				{
					r_Mop_LessThan_Single_Single = new(Type, "op_LessThan", 0, typeof(System.Single), typeof(System.Single));
				}
				return r_Mop_LessThan_Single_Single;
			}
		}

		/// <summary>
		/// Boolean op_GreaterThan(Single, Single)
		/// </summary>
		protected static RMethod r_Mop_GreaterThan_Single_Single;
		public static RMethod RMop_GreaterThan_Single_Single
		{
			get
			{
				if(r_Mop_GreaterThan_Single_Single == null)
				{
					r_Mop_GreaterThan_Single_Single = new(Type, "op_GreaterThan", 0, typeof(System.Single), typeof(System.Single));
				}
				return r_Mop_GreaterThan_Single_Single;
			}
		}

		/// <summary>
		/// Boolean op_LessThanOrEqual(Single, Single)
		/// </summary>
		protected static RMethod r_Mop_LessThanOrEqual_Single_Single;
		public static RMethod RMop_LessThanOrEqual_Single_Single
		{
			get
			{
				if(r_Mop_LessThanOrEqual_Single_Single == null)
				{
					r_Mop_LessThanOrEqual_Single_Single = new(Type, "op_LessThanOrEqual", 0, typeof(System.Single), typeof(System.Single));
				}
				return r_Mop_LessThanOrEqual_Single_Single;
			}
		}

		/// <summary>
		/// Boolean op_GreaterThanOrEqual(Single, Single)
		/// </summary>
		protected static RMethod r_Mop_GreaterThanOrEqual_Single_Single;
		public static RMethod RMop_GreaterThanOrEqual_Single_Single
		{
			get
			{
				if(r_Mop_GreaterThanOrEqual_Single_Single == null)
				{
					r_Mop_GreaterThanOrEqual_Single_Single = new(Type, "op_GreaterThanOrEqual", 0, typeof(System.Single), typeof(System.Single));
				}
				return r_Mop_GreaterThanOrEqual_Single_Single;
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
				}
				return r_MEquals_Object;
			}
		}

		/// <summary>
		/// Boolean Equals(Single)
		/// </summary>
		protected RMethod r_MEquals_Single;
		public virtual RMethod RMEquals_Single
		{
			get
			{
				if(r_MEquals_Single == null)
				{
					r_MEquals_Single = new(this, "Equals", 0, typeof(System.Single));
				}
				return r_MEquals_Single;
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
				}
				return r_MToString_IFormatProvider;
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
				}
				return r_MToString_String;
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
					r_MTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider = new(this, "TryFormat", 0,  ReflectionUtils.GetType("System.Span`1").MakeGenericType(typeof(System.Char)), typeof(System.Int32).MakeByRefType(),  ReflectionUtils.GetType("System.ReadOnlySpan`1").MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider));
				}
				return r_MTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider;
			}
		}

		/// <summary>
		/// Single Parse(System.String)
		/// </summary>
		protected static RMethod r_MParse_String;
		public static RMethod RMParse_String
		{
			get
			{
				if(r_MParse_String == null)
				{
					r_MParse_String = new(Type, "Parse", 0, typeof(System.String));
				}
				return r_MParse_String;
			}
		}

		/// <summary>
		/// Single Parse(System.String, System.Globalization.NumberStyles)
		/// </summary>
		protected static RMethod r_MParse_String_NumberStyles;
		public static RMethod RMParse_String_NumberStyles
		{
			get
			{
				if(r_MParse_String_NumberStyles == null)
				{
					r_MParse_String_NumberStyles = new(Type, "Parse", 0, typeof(System.String), typeof(System.Globalization.NumberStyles));
				}
				return r_MParse_String_NumberStyles;
			}
		}

		/// <summary>
		/// Single Parse(System.String, System.IFormatProvider)
		/// </summary>
		protected static RMethod r_MParse_String_IFormatProvider;
		public static RMethod RMParse_String_IFormatProvider
		{
			get
			{
				if(r_MParse_String_IFormatProvider == null)
				{
					r_MParse_String_IFormatProvider = new(Type, "Parse", 0, typeof(System.String), typeof(System.IFormatProvider));
				}
				return r_MParse_String_IFormatProvider;
			}
		}

		/// <summary>
		/// Single Parse(System.String, System.Globalization.NumberStyles, System.IFormatProvider)
		/// </summary>
		protected static RMethod r_MParse_String_NumberStyles_IFormatProvider;
		public static RMethod RMParse_String_NumberStyles_IFormatProvider
		{
			get
			{
				if(r_MParse_String_NumberStyles_IFormatProvider == null)
				{
					r_MParse_String_NumberStyles_IFormatProvider = new(Type, "Parse", 0, typeof(System.String), typeof(System.Globalization.NumberStyles), typeof(System.IFormatProvider));
				}
				return r_MParse_String_NumberStyles_IFormatProvider;
			}
		}

		/// <summary>
		/// Single Parse(System.ReadOnlySpan`1[System.Char], System.Globalization.NumberStyles, System.IFormatProvider)
		/// </summary>
		protected static RMethod r_MParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider;
		public static RMethod RMParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider
		{
			get
			{
				if(r_MParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider == null)
				{
					r_MParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider = new(Type, "Parse", 0,  ReflectionUtils.GetType("System.ReadOnlySpan`1").MakeGenericType(typeof(System.Char)), typeof(System.Globalization.NumberStyles), typeof(System.IFormatProvider));
				}
				return r_MParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.String, Single ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_String_Out_Single;
		public static RMethod RMTryParse_String_Out_Single
		{
			get
			{
				if(r_MTryParse_String_Out_Single == null)
				{
					r_MTryParse_String_Out_Single = new(Type, "TryParse", 0, typeof(System.String), typeof(System.Single).MakeByRefType());
				}
				return r_MTryParse_String_Out_Single;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], Single ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_ReadOnlySpan_d_Char_p__Out_Single;
		public static RMethod RMTryParse_ReadOnlySpan_d_Char_p__Out_Single
		{
			get
			{
				if(r_MTryParse_ReadOnlySpan_d_Char_p__Out_Single == null)
				{
					r_MTryParse_ReadOnlySpan_d_Char_p__Out_Single = new(Type, "TryParse", 0,  ReflectionUtils.GetType("System.ReadOnlySpan`1").MakeGenericType(typeof(System.Char)), typeof(System.Single).MakeByRefType());
				}
				return r_MTryParse_ReadOnlySpan_d_Char_p__Out_Single;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.String, System.Globalization.NumberStyles, System.IFormatProvider, Single ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_String_NumberStyles_IFormatProvider_Out_Single;
		public static RMethod RMTryParse_String_NumberStyles_IFormatProvider_Out_Single
		{
			get
			{
				if(r_MTryParse_String_NumberStyles_IFormatProvider_Out_Single == null)
				{
					r_MTryParse_String_NumberStyles_IFormatProvider_Out_Single = new(Type, "TryParse", 0, typeof(System.String), typeof(System.Globalization.NumberStyles), typeof(System.IFormatProvider), typeof(System.Single).MakeByRefType());
				}
				return r_MTryParse_String_NumberStyles_IFormatProvider_Out_Single;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], System.Globalization.NumberStyles, System.IFormatProvider, Single ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Single;
		public static RMethod RMTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Single
		{
			get
			{
				if(r_MTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Single == null)
				{
					r_MTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Single = new(Type, "TryParse", 0,  ReflectionUtils.GetType("System.ReadOnlySpan`1").MakeGenericType(typeof(System.Char)), typeof(System.Globalization.NumberStyles), typeof(System.IFormatProvider), typeof(System.Single).MakeByRefType());
				}
				return r_MTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Single;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], System.Globalization.NumberStyles, System.Globalization.NumberFormatInfo, Single ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_Single;
		public static RMethod RMTryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_Single
		{
			get
			{
				if(r_MTryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_Single == null)
				{
					r_MTryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_Single = new(Type, "TryParse", 0,  ReflectionUtils.GetType("System.ReadOnlySpan`1").MakeGenericType(typeof(System.Char)), typeof(System.Globalization.NumberStyles), typeof(System.Globalization.NumberFormatInfo), typeof(System.Single).MakeByRefType());
				}
				return r_MTryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_Single;
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
				}
				return r_MMemberwiseClone;
			}
		}


        public static System.Boolean IsFinite(System.Single @f)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f};
            var ___result = RMIsFinite_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean IsInfinity(System.Single @f)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f};
            var ___result = RMIsInfinity_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean IsNaN(System.Single @f)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f};
            var ___result = RMIsNaN_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean IsNegative(System.Single @f)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f};
            var ___result = RMIsNegative_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean IsNegativeInfinity(System.Single @f)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f};
            var ___result = RMIsNegativeInfinity_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean IsNormal(System.Single @f)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f};
            var ___result = RMIsNormal_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean IsPositiveInfinity(System.Single @f)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f};
            var ___result = RMIsPositiveInfinity_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean IsSubnormal(System.Single @f)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f};
            var ___result = RMIsSubnormal_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 CompareTo(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 CompareTo(System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMCompareTo_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.Boolean op_Equality(System.Single @left, System.Single @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Equality_Single_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(System.Single @left, System.Single @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Inequality_Single_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_LessThan(System.Single @left, System.Single @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_LessThan_Single_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_GreaterThan(System.Single @left, System.Single @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_GreaterThan_Single_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_LessThanOrEqual(System.Single @left, System.Single @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_LessThanOrEqual_Single_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_GreaterThanOrEqual(System.Single @left, System.Single @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_GreaterThanOrEqual_Single_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(System.Single @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean TryFormat(Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RSystem.RChar> @destination, out System.Int32 @charsWritten, Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @format, System.IFormatProvider @provider)
        {
			@charsWritten = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination.Value, @charsWritten, @format.Value, @provider};
            var ___result = RMTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider.Invoke(___genericsType, ___parameters);
			@charsWritten = ReflectionUtils.Convert<System.Int32>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Single Parse(System.String @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RMParse_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public static System.Single Parse(System.String @s, System.Globalization.NumberStyles @style)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @style};
            var ___result = RMParse_String_NumberStyles.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public static System.Single Parse(System.String @s, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @provider};
            var ___result = RMParse_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public static System.Single Parse(System.String @s, System.Globalization.NumberStyles @style, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @style, @provider};
            var ___result = RMParse_String_NumberStyles_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public static System.Single Parse(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @s, System.Globalization.NumberStyles @style, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @style, @provider};
            var ___result = RMParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public static System.Boolean TryParse(System.String @s, out System.Single @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @result};
            var ___result = RMTryParse_String_Out_Single.Invoke(___genericsType, ___parameters);
			@result = ReflectionUtils.Convert<System.Single>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean TryParse(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @s, out System.Single @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @result};
            var ___result = RMTryParse_ReadOnlySpan_d_Char_p__Out_Single.Invoke(___genericsType, ___parameters);
			@result = ReflectionUtils.Convert<System.Single>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean TryParse(System.String @s, System.Globalization.NumberStyles @style, System.IFormatProvider @provider, out System.Single @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @style, @provider, @result};
            var ___result = RMTryParse_String_NumberStyles_IFormatProvider_Out_Single.Invoke(___genericsType, ___parameters);
			@result = ReflectionUtils.Convert<System.Single>(___parameters[3]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean TryParse(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @s, System.Globalization.NumberStyles @style, System.IFormatProvider @provider, out System.Single @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @style, @provider, @result};
            var ___result = RMTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Single.Invoke(___genericsType, ___parameters);
			@result = ReflectionUtils.Convert<System.Single>(___parameters[3]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean TryParse(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @s, System.Globalization.NumberStyles @style, System.Globalization.NumberFormatInfo @info, out System.Single @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @style, @info, @result};
            var ___result = RMTryParse_ReadOnlySpan_d_Char_p__NumberStyles_NumberFormatInfo_Out_Single.Invoke(___genericsType, ___parameters);
			@result = ReflectionUtils.Convert<System.Single>(___parameters[3]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.TypeCode>(___result);
        }


        public virtual System.Boolean System__2__IConvertible__2__ToBoolean(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToBoolean_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Char System__2__IConvertible__2__ToChar(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToChar_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Char>(___result);
        }


        public virtual System.SByte System__2__IConvertible__2__ToSByte(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToSByte_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.SByte>(___result);
        }


        public virtual System.Byte System__2__IConvertible__2__ToByte(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToByte_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Byte>(___result);
        }


        public virtual System.Int16 System__2__IConvertible__2__ToInt16(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToInt16_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int16>(___result);
        }


        public virtual System.UInt16 System__2__IConvertible__2__ToUInt16(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToUInt16_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.UInt16>(___result);
        }


        public virtual System.Int32 System__2__IConvertible__2__ToInt32(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToInt32_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.UInt32 System__2__IConvertible__2__ToUInt32(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToUInt32_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.UInt32>(___result);
        }


        public virtual System.Int64 System__2__IConvertible__2__ToInt64(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToInt64_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int64>(___result);
        }


        public virtual System.UInt64 System__2__IConvertible__2__ToUInt64(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToUInt64_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.UInt64>(___result);
        }


        public virtual System.Single System__2__IConvertible__2__ToSingle(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToSingle_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public virtual System.Double System__2__IConvertible__2__ToDouble(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToDouble_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Double>(___result);
        }


        public virtual System.Decimal System__2__IConvertible__2__ToDecimal(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToDecimal_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Decimal>(___result);
        }


        public virtual System.DateTime System__2__IConvertible__2__ToDateTime(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMSystem__2__IConvertible__2__ToDateTime_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.DateTime>(___result);
        }


        public virtual System.Object System__2__IConvertible__2__ToType(System.Type @type, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @provider};
            var ___result = RMSystem__2__IConvertible__2__ToType_Type_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
