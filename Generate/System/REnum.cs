using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.Enum
	/// </summary>
    public partial class REnum : RMember //
    {

		/// <summary>
		/// System.Char[] enumSeperatorCharArray
		/// </summary>
		protected static RFieldArray<RSystem.RChar> r_FenumSeperatorCharArray;
		public static RFieldArray<RSystem.RChar> RFenumSeperatorCharArray
		{
			get
			{
				if(r_FenumSeperatorCharArray == null)
				{
					r_FenumSeperatorCharArray = new(typeof(System.Enum), "enumSeperatorCharArray");
					r_FenumSeperatorCharArray.SetBelong(null);
				}
				return r_FenumSeperatorCharArray;
			}
		}

		/// <summary>
		/// System.String enumSeperator
		/// </summary>
		protected static RSystem.RString r_FenumSeperator;
		public static RSystem.RString RFenumSeperator
		{
			get
			{
				if(r_FenumSeperator == null)
				{
					r_FenumSeperator = new(typeof(System.Enum), "enumSeperator");
					r_FenumSeperator.SetBelong(null);
				}
				return r_FenumSeperator;
			}
		}

		/// <summary>
		/// ValuesAndNames GetCachedValuesAndNames(System.RuntimeType, Boolean)
		/// </summary>
		protected static RMethod r_MGetCachedValuesAndNames_RuntimeType_Boolean;
		public static RMethod RMGetCachedValuesAndNames_RuntimeType_Boolean
		{
			get
			{
				if(r_MGetCachedValuesAndNames_RuntimeType_Boolean == null)
				{
					r_MGetCachedValuesAndNames_RuntimeType_Boolean = new(typeof(System.Enum), "GetCachedValuesAndNames", 0,  ReflectionUtils.GetType("System.RuntimeType"), typeof(System.Boolean));
					r_MGetCachedValuesAndNames_RuntimeType_Boolean.SetBelong(null);
				}
				return r_MGetCachedValuesAndNames_RuntimeType_Boolean;
			}
		}

		/// <summary>
		/// System.String InternalFormattedHexString(System.Object)
		/// </summary>
		protected static RMethod r_MInternalFormattedHexString_Object;
		public static RMethod RMInternalFormattedHexString_Object
		{
			get
			{
				if(r_MInternalFormattedHexString_Object == null)
				{
					r_MInternalFormattedHexString_Object = new(typeof(System.Enum), "InternalFormattedHexString", 0, typeof(System.Object));
					r_MInternalFormattedHexString_Object.SetBelong(null);
				}
				return r_MInternalFormattedHexString_Object;
			}
		}

		/// <summary>
		/// System.String InternalFormat(System.RuntimeType, System.Object)
		/// </summary>
		protected static RMethod r_MInternalFormat_RuntimeType_Object;
		public static RMethod RMInternalFormat_RuntimeType_Object
		{
			get
			{
				if(r_MInternalFormat_RuntimeType_Object == null)
				{
					r_MInternalFormat_RuntimeType_Object = new(typeof(System.Enum), "InternalFormat", 0,  ReflectionUtils.GetType("System.RuntimeType"), typeof(System.Object));
					r_MInternalFormat_RuntimeType_Object.SetBelong(null);
				}
				return r_MInternalFormat_RuntimeType_Object;
			}
		}

		/// <summary>
		/// System.String InternalFlagsFormat(System.RuntimeType, System.Object)
		/// </summary>
		protected static RMethod r_MInternalFlagsFormat_RuntimeType_Object;
		public static RMethod RMInternalFlagsFormat_RuntimeType_Object
		{
			get
			{
				if(r_MInternalFlagsFormat_RuntimeType_Object == null)
				{
					r_MInternalFlagsFormat_RuntimeType_Object = new(typeof(System.Enum), "InternalFlagsFormat", 0,  ReflectionUtils.GetType("System.RuntimeType"), typeof(System.Object));
					r_MInternalFlagsFormat_RuntimeType_Object.SetBelong(null);
				}
				return r_MInternalFlagsFormat_RuntimeType_Object;
			}
		}

		/// <summary>
		/// UInt64 ToUInt64(System.Object)
		/// </summary>
		protected static RMethod r_MToUInt64_Object;
		public static RMethod RMToUInt64_Object
		{
			get
			{
				if(r_MToUInt64_Object == null)
				{
					r_MToUInt64_Object = new(typeof(System.Enum), "ToUInt64", 0, typeof(System.Object));
					r_MToUInt64_Object.SetBelong(null);
				}
				return r_MToUInt64_Object;
			}
		}

		/// <summary>
		/// Int32 InternalCompareTo(System.Object, System.Object)
		/// </summary>
		protected static RMethod r_MInternalCompareTo_Object_Object;
		public static RMethod RMInternalCompareTo_Object_Object
		{
			get
			{
				if(r_MInternalCompareTo_Object_Object == null)
				{
					r_MInternalCompareTo_Object_Object = new(typeof(System.Enum), "InternalCompareTo", 0, typeof(System.Object), typeof(System.Object));
					r_MInternalCompareTo_Object_Object.SetBelong(null);
				}
				return r_MInternalCompareTo_Object_Object;
			}
		}

		/// <summary>
		/// System.RuntimeType InternalGetUnderlyingType(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MInternalGetUnderlyingType_RuntimeType;
		public static RMethod RMInternalGetUnderlyingType_RuntimeType
		{
			get
			{
				if(r_MInternalGetUnderlyingType_RuntimeType == null)
				{
					r_MInternalGetUnderlyingType_RuntimeType = new(typeof(System.Enum), "InternalGetUnderlyingType", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_MInternalGetUnderlyingType_RuntimeType.SetBelong(null);
				}
				return r_MInternalGetUnderlyingType_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean GetEnumValuesAndNames(System.RuntimeType, UInt64[] ByRef, System.String[] ByRef)
		/// </summary>
		protected static RMethod r_MGetEnumValuesAndNames_RuntimeType_Out_UInt64Array_Out_StringArray;
		public static RMethod RMGetEnumValuesAndNames_RuntimeType_Out_UInt64Array_Out_StringArray
		{
			get
			{
				if(r_MGetEnumValuesAndNames_RuntimeType_Out_UInt64Array_Out_StringArray == null)
				{
					r_MGetEnumValuesAndNames_RuntimeType_Out_UInt64Array_Out_StringArray = new(typeof(System.Enum), "GetEnumValuesAndNames", 0,  ReflectionUtils.GetType("System.RuntimeType"), typeof(System.UInt64).MakeArrayType().MakeByRefType(), typeof(System.String).MakeArrayType().MakeByRefType());
					r_MGetEnumValuesAndNames_RuntimeType_Out_UInt64Array_Out_StringArray.SetBelong(null);
				}
				return r_MGetEnumValuesAndNames_RuntimeType_Out_UInt64Array_Out_StringArray;
			}
		}

		/// <summary>
		/// System.Object InternalBoxEnum(System.RuntimeType, Int64)
		/// </summary>
		protected static RMethod r_MInternalBoxEnum_RuntimeType_Int64;
		public static RMethod RMInternalBoxEnum_RuntimeType_Int64
		{
			get
			{
				if(r_MInternalBoxEnum_RuntimeType_Int64 == null)
				{
					r_MInternalBoxEnum_RuntimeType_Int64 = new(typeof(System.Enum), "InternalBoxEnum", 0,  ReflectionUtils.GetType("System.RuntimeType"), typeof(System.Int64));
					r_MInternalBoxEnum_RuntimeType_Int64.SetBelong(null);
				}
				return r_MInternalBoxEnum_RuntimeType_Int64;
			}
		}

		/// <summary>
		/// Boolean TryParse[TEnum](System.String, TEnum ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_GTEnum_String_Out_TEnum;
		public static RMethod RMTryParse_GTEnum_String_Out_TEnum
		{
			get
			{
				if(r_MTryParse_GTEnum_String_Out_TEnum == null)
				{
					r_MTryParse_GTEnum_String_Out_TEnum = new(typeof(System.Enum), "TryParse", 1, typeof(System.String), Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_MTryParse_GTEnum_String_Out_TEnum.SetBelong(null);
				}
				return r_MTryParse_GTEnum_String_Out_TEnum;
			}
		}

		/// <summary>
		/// Boolean TryParse[TEnum](System.String, Boolean, TEnum ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_GTEnum_String_Boolean_Out_TEnum;
		public static RMethod RMTryParse_GTEnum_String_Boolean_Out_TEnum
		{
			get
			{
				if(r_MTryParse_GTEnum_String_Boolean_Out_TEnum == null)
				{
					r_MTryParse_GTEnum_String_Boolean_Out_TEnum = new(typeof(System.Enum), "TryParse", 1, typeof(System.String), typeof(System.Boolean), Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_MTryParse_GTEnum_String_Boolean_Out_TEnum.SetBelong(null);
				}
				return r_MTryParse_GTEnum_String_Boolean_Out_TEnum;
			}
		}

		/// <summary>
		/// System.Object Parse(System.Type, System.String)
		/// </summary>
		protected static RMethod r_MParse_Type_String;
		public static RMethod RMParse_Type_String
		{
			get
			{
				if(r_MParse_Type_String == null)
				{
					r_MParse_Type_String = new(typeof(System.Enum), "Parse", 0, typeof(System.Type), typeof(System.String));
					r_MParse_Type_String.SetBelong(null);
				}
				return r_MParse_Type_String;
			}
		}

		/// <summary>
		/// System.Object Parse(System.Type, System.String, Boolean)
		/// </summary>
		protected static RMethod r_MParse_Type_String_Boolean;
		public static RMethod RMParse_Type_String_Boolean
		{
			get
			{
				if(r_MParse_Type_String_Boolean == null)
				{
					r_MParse_Type_String_Boolean = new(typeof(System.Enum), "Parse", 0, typeof(System.Type), typeof(System.String), typeof(System.Boolean));
					r_MParse_Type_String_Boolean.SetBelong(null);
				}
				return r_MParse_Type_String_Boolean;
			}
		}

		/// <summary>
		/// Boolean TryParseEnum(System.Type, System.String, Boolean, EnumResult ByRef)
		/// </summary>
		protected static RMethod r_MTryParseEnum_Type_String_Boolean_Ref_EnumResult;
		public static RMethod RMTryParseEnum_Type_String_Boolean_Ref_EnumResult
		{
			get
			{
				if(r_MTryParseEnum_Type_String_Boolean_Ref_EnumResult == null)
				{
					r_MTryParseEnum_Type_String_Boolean_Ref_EnumResult = new(typeof(System.Enum), "TryParseEnum", 0, typeof(System.Type), typeof(System.String), typeof(System.Boolean),  ReflectionUtils.GetType("System.Enum+EnumResult").MakeByRefType());
					r_MTryParseEnum_Type_String_Boolean_Ref_EnumResult.SetBelong(null);
				}
				return r_MTryParseEnum_Type_String_Boolean_Ref_EnumResult;
			}
		}

		/// <summary>
		/// System.Type GetUnderlyingType(System.Type)
		/// </summary>
		protected static RMethod r_MGetUnderlyingType_Type;
		public static RMethod RMGetUnderlyingType_Type
		{
			get
			{
				if(r_MGetUnderlyingType_Type == null)
				{
					r_MGetUnderlyingType_Type = new(typeof(System.Enum), "GetUnderlyingType", 0, typeof(System.Type));
					r_MGetUnderlyingType_Type.SetBelong(null);
				}
				return r_MGetUnderlyingType_Type;
			}
		}

		/// <summary>
		/// System.Array GetValues(System.Type)
		/// </summary>
		protected static RMethod r_MGetValues_Type;
		public static RMethod RMGetValues_Type
		{
			get
			{
				if(r_MGetValues_Type == null)
				{
					r_MGetValues_Type = new(typeof(System.Enum), "GetValues", 0, typeof(System.Type));
					r_MGetValues_Type.SetBelong(null);
				}
				return r_MGetValues_Type;
			}
		}

		/// <summary>
		/// UInt64[] InternalGetValues(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MInternalGetValues_RuntimeType;
		public static RMethod RMInternalGetValues_RuntimeType
		{
			get
			{
				if(r_MInternalGetValues_RuntimeType == null)
				{
					r_MInternalGetValues_RuntimeType = new(typeof(System.Enum), "InternalGetValues", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_MInternalGetValues_RuntimeType.SetBelong(null);
				}
				return r_MInternalGetValues_RuntimeType;
			}
		}

		/// <summary>
		/// System.String GetName(System.Type, System.Object)
		/// </summary>
		protected static RMethod r_MGetName_Type_Object;
		public static RMethod RMGetName_Type_Object
		{
			get
			{
				if(r_MGetName_Type_Object == null)
				{
					r_MGetName_Type_Object = new(typeof(System.Enum), "GetName", 0, typeof(System.Type), typeof(System.Object));
					r_MGetName_Type_Object.SetBelong(null);
				}
				return r_MGetName_Type_Object;
			}
		}

		/// <summary>
		/// System.String[] GetNames(System.Type)
		/// </summary>
		protected static RMethod r_MGetNames_Type;
		public static RMethod RMGetNames_Type
		{
			get
			{
				if(r_MGetNames_Type == null)
				{
					r_MGetNames_Type = new(typeof(System.Enum), "GetNames", 0, typeof(System.Type));
					r_MGetNames_Type.SetBelong(null);
				}
				return r_MGetNames_Type;
			}
		}

		/// <summary>
		/// System.String[] InternalGetNames(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MInternalGetNames_RuntimeType;
		public static RMethod RMInternalGetNames_RuntimeType
		{
			get
			{
				if(r_MInternalGetNames_RuntimeType == null)
				{
					r_MInternalGetNames_RuntimeType = new(typeof(System.Enum), "InternalGetNames", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_MInternalGetNames_RuntimeType.SetBelong(null);
				}
				return r_MInternalGetNames_RuntimeType;
			}
		}

		/// <summary>
		/// System.Object ToObject(System.Type, System.Object)
		/// </summary>
		protected static RMethod r_MToObject_Type_Object;
		public static RMethod RMToObject_Type_Object
		{
			get
			{
				if(r_MToObject_Type_Object == null)
				{
					r_MToObject_Type_Object = new(typeof(System.Enum), "ToObject", 0, typeof(System.Type), typeof(System.Object));
					r_MToObject_Type_Object.SetBelong(null);
				}
				return r_MToObject_Type_Object;
			}
		}

		/// <summary>
		/// Boolean IsDefined(System.Type, System.Object)
		/// </summary>
		protected static RMethod r_MIsDefined_Type_Object;
		public static RMethod RMIsDefined_Type_Object
		{
			get
			{
				if(r_MIsDefined_Type_Object == null)
				{
					r_MIsDefined_Type_Object = new(typeof(System.Enum), "IsDefined", 0, typeof(System.Type), typeof(System.Object));
					r_MIsDefined_Type_Object.SetBelong(null);
				}
				return r_MIsDefined_Type_Object;
			}
		}

		/// <summary>
		/// System.String Format(System.Type, System.Object, System.String)
		/// </summary>
		protected static RMethod r_MFormat_Type_Object_String;
		public static RMethod RMFormat_Type_Object_String
		{
			get
			{
				if(r_MFormat_Type_Object_String == null)
				{
					r_MFormat_Type_Object_String = new(typeof(System.Enum), "Format", 0, typeof(System.Type), typeof(System.Object), typeof(System.String));
					r_MFormat_Type_Object_String.SetBelong(null);
				}
				return r_MFormat_Type_Object_String;
			}
		}

		/// <summary>
		/// System.Object get_value()
		/// </summary>
		protected RMethod r_Mget_value;
		public virtual RMethod RMget_value
		{
			get
			{
				if(r_Mget_value == null)
				{
					r_Mget_value = new(this, "get_value", 0);
					r_Mget_value.SetBelong(this.instance);
				}
				return r_Mget_value;
			}
		}

		/// <summary>
		/// System.Object GetValue()
		/// </summary>
		protected RMethod r_MGetValue;
		public virtual RMethod RMGetValue
		{
			get
			{
				if(r_MGetValue == null)
				{
					r_MGetValue = new(this, "GetValue", 0);
					r_MGetValue.SetBelong(this.instance);
				}
				return r_MGetValue;
			}
		}

		/// <summary>
		/// Boolean InternalHasFlag(System.Enum)
		/// </summary>
		protected RMethod r_MInternalHasFlag_Enum;
		public virtual RMethod RMInternalHasFlag_Enum
		{
			get
			{
				if(r_MInternalHasFlag_Enum == null)
				{
					r_MInternalHasFlag_Enum = new(this, "InternalHasFlag", 0, typeof(System.Enum));
					r_MInternalHasFlag_Enum.SetBelong(this.instance);
				}
				return r_MInternalHasFlag_Enum;
			}
		}

		/// <summary>
		/// Int32 get_hashcode()
		/// </summary>
		protected RMethod r_Mget_hashcode;
		public virtual RMethod RMget_hashcode
		{
			get
			{
				if(r_Mget_hashcode == null)
				{
					r_Mget_hashcode = new(this, "get_hashcode", 0);
					r_Mget_hashcode.SetBelong(this.instance);
				}
				return r_Mget_hashcode;
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
		/// Boolean HasFlag(System.Enum)
		/// </summary>
		protected RMethod r_MHasFlag_Enum;
		public virtual RMethod RMHasFlag_Enum
		{
			get
			{
				if(r_MHasFlag_Enum == null)
				{
					r_MHasFlag_Enum = new(this, "HasFlag", 0, typeof(System.Enum));
					r_MHasFlag_Enum.SetBelong(this.instance);
				}
				return r_MHasFlag_Enum;
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
		/// System.Object ToObject(System.Type, SByte)
		/// </summary>
		protected static RMethod r_MToObject_Type_SByte;
		public static RMethod RMToObject_Type_SByte
		{
			get
			{
				if(r_MToObject_Type_SByte == null)
				{
					r_MToObject_Type_SByte = new(typeof(System.Enum), "ToObject", 0, typeof(System.Type), typeof(System.SByte));
					r_MToObject_Type_SByte.SetBelong(null);
				}
				return r_MToObject_Type_SByte;
			}
		}

		/// <summary>
		/// System.Object ToObject(System.Type, Int16)
		/// </summary>
		protected static RMethod r_MToObject_Type_Int16;
		public static RMethod RMToObject_Type_Int16
		{
			get
			{
				if(r_MToObject_Type_Int16 == null)
				{
					r_MToObject_Type_Int16 = new(typeof(System.Enum), "ToObject", 0, typeof(System.Type), typeof(System.Int16));
					r_MToObject_Type_Int16.SetBelong(null);
				}
				return r_MToObject_Type_Int16;
			}
		}

		/// <summary>
		/// System.Object ToObject(System.Type, Int32)
		/// </summary>
		protected static RMethod r_MToObject_Type_Int32;
		public static RMethod RMToObject_Type_Int32
		{
			get
			{
				if(r_MToObject_Type_Int32 == null)
				{
					r_MToObject_Type_Int32 = new(typeof(System.Enum), "ToObject", 0, typeof(System.Type), typeof(System.Int32));
					r_MToObject_Type_Int32.SetBelong(null);
				}
				return r_MToObject_Type_Int32;
			}
		}

		/// <summary>
		/// System.Object ToObject(System.Type, Byte)
		/// </summary>
		protected static RMethod r_MToObject_Type_Byte;
		public static RMethod RMToObject_Type_Byte
		{
			get
			{
				if(r_MToObject_Type_Byte == null)
				{
					r_MToObject_Type_Byte = new(typeof(System.Enum), "ToObject", 0, typeof(System.Type), typeof(System.Byte));
					r_MToObject_Type_Byte.SetBelong(null);
				}
				return r_MToObject_Type_Byte;
			}
		}

		/// <summary>
		/// System.Object ToObject(System.Type, UInt16)
		/// </summary>
		protected static RMethod r_MToObject_Type_UInt16;
		public static RMethod RMToObject_Type_UInt16
		{
			get
			{
				if(r_MToObject_Type_UInt16 == null)
				{
					r_MToObject_Type_UInt16 = new(typeof(System.Enum), "ToObject", 0, typeof(System.Type), typeof(System.UInt16));
					r_MToObject_Type_UInt16.SetBelong(null);
				}
				return r_MToObject_Type_UInt16;
			}
		}

		/// <summary>
		/// System.Object ToObject(System.Type, UInt32)
		/// </summary>
		protected static RMethod r_MToObject_Type_UInt32;
		public static RMethod RMToObject_Type_UInt32
		{
			get
			{
				if(r_MToObject_Type_UInt32 == null)
				{
					r_MToObject_Type_UInt32 = new(typeof(System.Enum), "ToObject", 0, typeof(System.Type), typeof(System.UInt32));
					r_MToObject_Type_UInt32.SetBelong(null);
				}
				return r_MToObject_Type_UInt32;
			}
		}

		/// <summary>
		/// System.Object ToObject(System.Type, Int64)
		/// </summary>
		protected static RMethod r_MToObject_Type_Int64;
		public static RMethod RMToObject_Type_Int64
		{
			get
			{
				if(r_MToObject_Type_Int64 == null)
				{
					r_MToObject_Type_Int64 = new(typeof(System.Enum), "ToObject", 0, typeof(System.Type), typeof(System.Int64));
					r_MToObject_Type_Int64.SetBelong(null);
				}
				return r_MToObject_Type_Int64;
			}
		}

		/// <summary>
		/// System.Object ToObject(System.Type, UInt64)
		/// </summary>
		protected static RMethod r_MToObject_Type_UInt64;
		public static RMethod RMToObject_Type_UInt64
		{
			get
			{
				if(r_MToObject_Type_UInt64 == null)
				{
					r_MToObject_Type_UInt64 = new(typeof(System.Enum), "ToObject", 0, typeof(System.Type), typeof(System.UInt64));
					r_MToObject_Type_UInt64.SetBelong(null);
				}
				return r_MToObject_Type_UInt64;
			}
		}

		/// <summary>
		/// System.Object ToObject(System.Type, Char)
		/// </summary>
		protected static RMethod r_MToObject_Type_Char;
		public static RMethod RMToObject_Type_Char
		{
			get
			{
				if(r_MToObject_Type_Char == null)
				{
					r_MToObject_Type_Char = new(typeof(System.Enum), "ToObject", 0, typeof(System.Type), typeof(System.Char));
					r_MToObject_Type_Char.SetBelong(null);
				}
				return r_MToObject_Type_Char;
			}
		}

		/// <summary>
		/// System.Object ToObject(System.Type, Boolean)
		/// </summary>
		protected static RMethod r_MToObject_Type_Boolean;
		public static RMethod RMToObject_Type_Boolean
		{
			get
			{
				if(r_MToObject_Type_Boolean == null)
				{
					r_MToObject_Type_Boolean = new(typeof(System.Enum), "ToObject", 0, typeof(System.Type), typeof(System.Boolean));
					r_MToObject_Type_Boolean.SetBelong(null);
				}
				return r_MToObject_Type_Boolean;
			}
		}

		/// <summary>
		/// TEnum Parse[TEnum](System.String)
		/// </summary>
		protected static RMethod r_MParse_GTEnum_String;
		public static RMethod RMParse_GTEnum_String
		{
			get
			{
				if(r_MParse_GTEnum_String == null)
				{
					r_MParse_GTEnum_String = new(typeof(System.Enum), "Parse", 1, typeof(System.String));
					r_MParse_GTEnum_String.SetBelong(null);
				}
				return r_MParse_GTEnum_String;
			}
		}

		/// <summary>
		/// TEnum Parse[TEnum](System.String, Boolean)
		/// </summary>
		protected static RMethod r_MParse_GTEnum_String_Boolean;
		public static RMethod RMParse_GTEnum_String_Boolean
		{
			get
			{
				if(r_MParse_GTEnum_String_Boolean == null)
				{
					r_MParse_GTEnum_String_Boolean = new(typeof(System.Enum), "Parse", 1, typeof(System.String), typeof(System.Boolean));
					r_MParse_GTEnum_String_Boolean.SetBelong(null);
				}
				return r_MParse_GTEnum_String_Boolean;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.Type, System.String, Boolean, System.Object ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_Type_String_Boolean_Out_Object;
		public static RMethod RMTryParse_Type_String_Boolean_Out_Object
		{
			get
			{
				if(r_MTryParse_Type_String_Boolean_Out_Object == null)
				{
					r_MTryParse_Type_String_Boolean_Out_Object = new(typeof(System.Enum), "TryParse", 0, typeof(System.Type), typeof(System.String), typeof(System.Boolean), typeof(System.Object).MakeByRefType());
					r_MTryParse_Type_String_Boolean_Out_Object.SetBelong(null);
				}
				return r_MTryParse_Type_String_Boolean_Out_Object;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.Type, System.String, System.Object ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_Type_String_Out_Object;
		public static RMethod RMTryParse_Type_String_Out_Object
		{
			get
			{
				if(r_MTryParse_Type_String_Out_Object == null)
				{
					r_MTryParse_Type_String_Out_Object = new(typeof(System.Enum), "TryParse", 0, typeof(System.Type), typeof(System.String), typeof(System.Object).MakeByRefType());
					r_MTryParse_Type_String_Out_Object.SetBelong(null);
				}
				return r_MTryParse_Type_String_Out_Object;
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


        public REnum() : base("System.Enum")
        {
        }

        public REnum(System.Object instance) : base("System.Enum")
		{
            SetInstance(instance);
		}

        public REnum(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REnum(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static RSystem.REnum.RValuesAndNames GetCachedValuesAndNames(RSystem.RRuntimeType @enumType, System.Boolean @getNames)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType.Value, @getNames};
            var ___result = RMGetCachedValuesAndNames_RuntimeType_Boolean.Invoke(___genericsType, ___parameters);

            return new RSystem.REnum.RValuesAndNames(___result);
        }


        public static System.String InternalFormattedHexString(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMInternalFormattedHexString_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String InternalFormat(RSystem.RRuntimeType @eT, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eT.Value, @value};
            var ___result = RMInternalFormat_RuntimeType_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String InternalFlagsFormat(RSystem.RRuntimeType @eT, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eT.Value, @value};
            var ___result = RMInternalFlagsFormat_RuntimeType_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.UInt64 ToUInt64(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMToUInt64_Object.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public static System.Int32 InternalCompareTo(System.Object @o1, System.Object @o2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o1, @o2};
            var ___result = RMInternalCompareTo_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static RSystem.RRuntimeType InternalGetUnderlyingType(RSystem.RRuntimeType @enumType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType.Value};
            var ___result = RMInternalGetUnderlyingType_RuntimeType.Invoke(___genericsType, ___parameters);

            return new RSystem.RRuntimeType(___result);
        }


        public static System.Boolean GetEnumValuesAndNames(RSystem.RRuntimeType @enumType, out System.UInt64[] @values, out System.String[] @names)
        {
			@values = default;
			@names = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType.Value, @values, @names};
            var ___result = RMGetEnumValuesAndNames_RuntimeType_Out_UInt64Array_Out_StringArray.Invoke(___genericsType, ___parameters);
			@values = (System.UInt64[])___parameters[1];
			@names = (System.String[])___parameters[2];

            return (System.Boolean)___result;
        }


        public static System.Object InternalBoxEnum(RSystem.RRuntimeType @enumType, System.Int64 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType.Value, @value};
            var ___result = RMInternalBoxEnum_RuntimeType_Int64.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Boolean TryParse<TEnum>(System.String @value, out RType @result) where TEnum : struct
        {
			@result = default;

            var ___genericsType = new Type[] {typeof(TEnum)};
            var ___parameters = new object[]{@value, @result.Value};
            var ___result = RMTryParse_GTEnum_String_Out_TEnum.Invoke(___genericsType, ___parameters);
			@result = new RType(___parameters[1]);

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParse<TEnum>(System.String @value, System.Boolean @ignoreCase, out RType @result) where TEnum : struct
        {
			@result = default;

            var ___genericsType = new Type[] {typeof(TEnum)};
            var ___parameters = new object[]{@value, @ignoreCase, @result.Value};
            var ___result = RMTryParse_GTEnum_String_Boolean_Out_TEnum.Invoke(___genericsType, ___parameters);
			@result = new RType(___parameters[2]);

            return (System.Boolean)___result;
        }


        public static System.Object Parse(System.Type @enumType, System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType, @value};
            var ___result = RMParse_Type_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object Parse(System.Type @enumType, System.String @value, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType, @value, @ignoreCase};
            var ___result = RMParse_Type_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Boolean TryParseEnum(System.Type @enumType, System.String @value, System.Boolean @ignoreCase, ref RSystem.REnum.REnumResult @parseResult)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType, @value, @ignoreCase, @parseResult.Value};
            var ___result = RMTryParseEnum_Type_String_Boolean_Ref_EnumResult.Invoke(___genericsType, ___parameters);
			@parseResult = new RSystem.REnum.REnumResult(___parameters[3]);

            return (System.Boolean)___result;
        }


        public static System.Type GetUnderlyingType(System.Type @enumType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType};
            var ___result = RMGetUnderlyingType_Type.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Array GetValues(System.Type @enumType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType};
            var ___result = RMGetValues_Type.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public static System.UInt64[] InternalGetValues(RSystem.RRuntimeType @enumType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType.Value};
            var ___result = RMInternalGetValues_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.UInt64[])___result;
        }


        public static System.String GetName(System.Type @enumType, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType, @value};
            var ___result = RMGetName_Type_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String[] GetNames(System.Type @enumType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType};
            var ___result = RMGetNames_Type.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public static System.String[] InternalGetNames(RSystem.RRuntimeType @enumType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType.Value};
            var ___result = RMInternalGetNames_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public static System.Object ToObject(System.Type @enumType, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType, @value};
            var ___result = RMToObject_Type_Object.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Boolean IsDefined(System.Type @enumType, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType, @value};
            var ___result = RMIsDefined_Type_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.String Format(System.Type @enumType, System.Object @value, System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType, @value, @format};
            var ___result = RMFormat_Type_Object_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Object get_value()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMget_value.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValue.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean InternalHasFlag(System.Enum @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flags};
            var ___result = RMInternalHasFlag_Enum.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 get_hashcode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMget_hashcode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

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


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 CompareTo(System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.Boolean HasFlag(System.Enum @flag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flag};
            var ___result = RMHasFlag_Enum.Invoke(___genericsType, ___parameters);

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


        public static System.Object ToObject(System.Type @enumType, System.SByte @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType, @value};
            var ___result = RMToObject_Type_SByte.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object ToObject(System.Type @enumType, System.Int16 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType, @value};
            var ___result = RMToObject_Type_Int16.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object ToObject(System.Type @enumType, System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType, @value};
            var ___result = RMToObject_Type_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object ToObject(System.Type @enumType, System.Byte @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType, @value};
            var ___result = RMToObject_Type_Byte.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object ToObject(System.Type @enumType, System.UInt16 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType, @value};
            var ___result = RMToObject_Type_UInt16.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object ToObject(System.Type @enumType, System.UInt32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType, @value};
            var ___result = RMToObject_Type_UInt32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object ToObject(System.Type @enumType, System.Int64 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType, @value};
            var ___result = RMToObject_Type_Int64.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object ToObject(System.Type @enumType, System.UInt64 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType, @value};
            var ___result = RMToObject_Type_UInt64.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object ToObject(System.Type @enumType, System.Char @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType, @value};
            var ___result = RMToObject_Type_Char.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object ToObject(System.Type @enumType, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType, @value};
            var ___result = RMToObject_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static RType Parse<TEnum>(System.String @value) where TEnum : struct
        {

            var ___genericsType = new Type[] {typeof(TEnum)};
            var ___parameters = new object[]{@value};
            var ___result = RMParse_GTEnum_String.Invoke(___genericsType, ___parameters);

            return new RType(___result);
        }


        public static RType Parse<TEnum>(System.String @value, System.Boolean @ignoreCase) where TEnum : struct
        {

            var ___genericsType = new Type[] {typeof(TEnum)};
            var ___parameters = new object[]{@value, @ignoreCase};
            var ___result = RMParse_GTEnum_String_Boolean.Invoke(___genericsType, ___parameters);

            return new RType(___result);
        }


        public static System.Boolean TryParse(System.Type @enumType, System.String @value, System.Boolean @ignoreCase, out System.Object @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType, @value, @ignoreCase, @result};
            var ___result = RMTryParse_Type_String_Boolean_Out_Object.Invoke(___genericsType, ___parameters);
			@result = (System.Object)___parameters[3];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParse(System.Type @enumType, System.String @value, out System.Object @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType, @value, @result};
            var ___result = RMTryParse_Type_String_Out_Object.Invoke(___genericsType, ___parameters);
			@result = (System.Object)___parameters[2];

            return (System.Boolean)___result;
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
