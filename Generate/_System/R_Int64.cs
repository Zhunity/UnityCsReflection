
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Int64
	/// </summary>
    public partial class RInt64 : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Int64);
            }
        }

        public RInt64() : base("System.Int64")
        {
        }

        public RInt64(System.Object instance) : base("System.Int64")
		{
            SetInstance(instance);
		}

        public RInt64(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RInt64(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int64 m_value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_Fm_value;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RFm_value
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
		/// System.Int64 MaxValue
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt64 r_FMaxValue;
		public static Hvak.Editor.Refleaction.RSystem.RInt64 RFMaxValue
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
		/// System.Int64 MinValue
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt64 r_FMinValue;
		public static Hvak.Editor.Refleaction.RSystem.RInt64 RFMinValue
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
		/// Int32 CompareTo(Int64)
		/// </summary>
		protected RMethod r_MCompareTo_Int64;
		public virtual RMethod RMCompareTo_Int64
		{
			get
			{
				if(r_MCompareTo_Int64 == null)
				{
					r_MCompareTo_Int64 = new(this, "CompareTo", 0, typeof(System.Int64));
				}
				return r_MCompareTo_Int64;
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
		/// Boolean Equals(Int64)
		/// </summary>
		protected RMethod r_MEquals_Int64;
		public virtual RMethod RMEquals_Int64
		{
			get
			{
				if(r_MEquals_Int64 == null)
				{
					r_MEquals_Int64 = new(this, "Equals", 0, typeof(System.Int64));
				}
				return r_MEquals_Int64;
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
		/// Int64 Parse(System.String)
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
		/// Int64 Parse(System.String, System.Globalization.NumberStyles)
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
		/// Int64 Parse(System.String, System.IFormatProvider)
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
		/// Int64 Parse(System.String, System.Globalization.NumberStyles, System.IFormatProvider)
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
		/// Int64 Parse(System.ReadOnlySpan`1[System.Char], System.Globalization.NumberStyles, System.IFormatProvider)
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
		/// Boolean TryParse(System.String, Int64 ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_String_Out_Int64;
		public static RMethod RMTryParse_String_Out_Int64
		{
			get
			{
				if(r_MTryParse_String_Out_Int64 == null)
				{
					r_MTryParse_String_Out_Int64 = new(Type, "TryParse", 0, typeof(System.String), typeof(System.Int64).MakeByRefType());
				}
				return r_MTryParse_String_Out_Int64;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], Int64 ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_ReadOnlySpan_d_Char_p__Out_Int64;
		public static RMethod RMTryParse_ReadOnlySpan_d_Char_p__Out_Int64
		{
			get
			{
				if(r_MTryParse_ReadOnlySpan_d_Char_p__Out_Int64 == null)
				{
					r_MTryParse_ReadOnlySpan_d_Char_p__Out_Int64 = new(Type, "TryParse", 0,  ReflectionUtils.GetType("System.ReadOnlySpan`1").MakeGenericType(typeof(System.Char)), typeof(System.Int64).MakeByRefType());
				}
				return r_MTryParse_ReadOnlySpan_d_Char_p__Out_Int64;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.String, System.Globalization.NumberStyles, System.IFormatProvider, Int64 ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_String_NumberStyles_IFormatProvider_Out_Int64;
		public static RMethod RMTryParse_String_NumberStyles_IFormatProvider_Out_Int64
		{
			get
			{
				if(r_MTryParse_String_NumberStyles_IFormatProvider_Out_Int64 == null)
				{
					r_MTryParse_String_NumberStyles_IFormatProvider_Out_Int64 = new(Type, "TryParse", 0, typeof(System.String), typeof(System.Globalization.NumberStyles), typeof(System.IFormatProvider), typeof(System.Int64).MakeByRefType());
				}
				return r_MTryParse_String_NumberStyles_IFormatProvider_Out_Int64;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], System.Globalization.NumberStyles, System.IFormatProvider, Int64 ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Int64;
		public static RMethod RMTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Int64
		{
			get
			{
				if(r_MTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Int64 == null)
				{
					r_MTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Int64 = new(Type, "TryParse", 0,  ReflectionUtils.GetType("System.ReadOnlySpan`1").MakeGenericType(typeof(System.Char)), typeof(System.Globalization.NumberStyles), typeof(System.IFormatProvider), typeof(System.Int64).MakeByRefType());
				}
				return r_MTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Int64;
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


        public virtual System.Int32 CompareTo(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 CompareTo(System.Int64 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMCompareTo_Int64.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(System.Int64 @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Int64.Invoke(___genericsType, ___parameters);

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


        public static System.Int64 Parse(System.String @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RMParse_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int64>(___result);
        }


        public static System.Int64 Parse(System.String @s, System.Globalization.NumberStyles @style)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @style};
            var ___result = RMParse_String_NumberStyles.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int64>(___result);
        }


        public static System.Int64 Parse(System.String @s, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @provider};
            var ___result = RMParse_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int64>(___result);
        }


        public static System.Int64 Parse(System.String @s, System.Globalization.NumberStyles @style, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @style, @provider};
            var ___result = RMParse_String_NumberStyles_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int64>(___result);
        }


        public static System.Int64 Parse(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @s, System.Globalization.NumberStyles @style, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @style, @provider};
            var ___result = RMParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int64>(___result);
        }


        public static System.Boolean TryParse(System.String @s, out System.Int64 @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @result};
            var ___result = RMTryParse_String_Out_Int64.Invoke(___genericsType, ___parameters);
			@result = ReflectionUtils.Convert<System.Int64>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean TryParse(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @s, out System.Int64 @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @result};
            var ___result = RMTryParse_ReadOnlySpan_d_Char_p__Out_Int64.Invoke(___genericsType, ___parameters);
			@result = ReflectionUtils.Convert<System.Int64>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean TryParse(System.String @s, System.Globalization.NumberStyles @style, System.IFormatProvider @provider, out System.Int64 @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @style, @provider, @result};
            var ___result = RMTryParse_String_NumberStyles_IFormatProvider_Out_Int64.Invoke(___genericsType, ___parameters);
			@result = ReflectionUtils.Convert<System.Int64>(___parameters[3]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean TryParse(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @s, System.Globalization.NumberStyles @style, System.IFormatProvider @provider, out System.Int64 @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value, @style, @provider, @result};
            var ___result = RMTryParse_ReadOnlySpan_d_Char_p__NumberStyles_IFormatProvider_Out_Int64.Invoke(___genericsType, ___parameters);
			@result = ReflectionUtils.Convert<System.Int64>(___parameters[3]);

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
