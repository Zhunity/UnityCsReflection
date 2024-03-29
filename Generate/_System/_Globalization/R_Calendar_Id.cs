
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RGlobalization
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Globalization.CalendarId
	/// </summary>
    public partial class RCalendarId : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Globalization.CalendarId");
            }
        }

        public RCalendarId() : base("System.Globalization.CalendarId")
        {
        }

        public RCalendarId(System.Object instance) : base("System.Globalization.CalendarId")
		{
            SetInstance(instance);
		}

        public RCalendarId(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCalendarId(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.UInt16 value__
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt16 r_Fvalue__;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt16 RFvalue__
		{
			get
			{
				if(r_Fvalue__ == null)
				{
					r_Fvalue__ = new(this, "value__");
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarId UNINITIALIZED_VALUE
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId r_FUNINITIALIZED_VALUE;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId RFUNINITIALIZED_VALUE
		{
			get
			{
				if(r_FUNINITIALIZED_VALUE == null)
				{
					r_FUNINITIALIZED_VALUE = new(Type, "UNINITIALIZED_VALUE");
				}
				return r_FUNINITIALIZED_VALUE;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarId GREGORIAN
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId r_FGREGORIAN;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId RFGREGORIAN
		{
			get
			{
				if(r_FGREGORIAN == null)
				{
					r_FGREGORIAN = new(Type, "GREGORIAN");
				}
				return r_FGREGORIAN;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarId GREGORIAN_US
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId r_FGREGORIAN_US;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId RFGREGORIAN_US
		{
			get
			{
				if(r_FGREGORIAN_US == null)
				{
					r_FGREGORIAN_US = new(Type, "GREGORIAN_US");
				}
				return r_FGREGORIAN_US;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarId JAPAN
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId r_FJAPAN;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId RFJAPAN
		{
			get
			{
				if(r_FJAPAN == null)
				{
					r_FJAPAN = new(Type, "JAPAN");
				}
				return r_FJAPAN;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarId TAIWAN
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId r_FTAIWAN;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId RFTAIWAN
		{
			get
			{
				if(r_FTAIWAN == null)
				{
					r_FTAIWAN = new(Type, "TAIWAN");
				}
				return r_FTAIWAN;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarId KOREA
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId r_FKOREA;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId RFKOREA
		{
			get
			{
				if(r_FKOREA == null)
				{
					r_FKOREA = new(Type, "KOREA");
				}
				return r_FKOREA;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarId HIJRI
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId r_FHIJRI;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId RFHIJRI
		{
			get
			{
				if(r_FHIJRI == null)
				{
					r_FHIJRI = new(Type, "HIJRI");
				}
				return r_FHIJRI;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarId THAI
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId r_FTHAI;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId RFTHAI
		{
			get
			{
				if(r_FTHAI == null)
				{
					r_FTHAI = new(Type, "THAI");
				}
				return r_FTHAI;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarId HEBREW
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId r_FHEBREW;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId RFHEBREW
		{
			get
			{
				if(r_FHEBREW == null)
				{
					r_FHEBREW = new(Type, "HEBREW");
				}
				return r_FHEBREW;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarId GREGORIAN_ME_FRENCH
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId r_FGREGORIAN_ME_FRENCH;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId RFGREGORIAN_ME_FRENCH
		{
			get
			{
				if(r_FGREGORIAN_ME_FRENCH == null)
				{
					r_FGREGORIAN_ME_FRENCH = new(Type, "GREGORIAN_ME_FRENCH");
				}
				return r_FGREGORIAN_ME_FRENCH;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarId GREGORIAN_ARABIC
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId r_FGREGORIAN_ARABIC;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId RFGREGORIAN_ARABIC
		{
			get
			{
				if(r_FGREGORIAN_ARABIC == null)
				{
					r_FGREGORIAN_ARABIC = new(Type, "GREGORIAN_ARABIC");
				}
				return r_FGREGORIAN_ARABIC;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarId GREGORIAN_XLIT_ENGLISH
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId r_FGREGORIAN_XLIT_ENGLISH;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId RFGREGORIAN_XLIT_ENGLISH
		{
			get
			{
				if(r_FGREGORIAN_XLIT_ENGLISH == null)
				{
					r_FGREGORIAN_XLIT_ENGLISH = new(Type, "GREGORIAN_XLIT_ENGLISH");
				}
				return r_FGREGORIAN_XLIT_ENGLISH;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarId GREGORIAN_XLIT_FRENCH
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId r_FGREGORIAN_XLIT_FRENCH;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId RFGREGORIAN_XLIT_FRENCH
		{
			get
			{
				if(r_FGREGORIAN_XLIT_FRENCH == null)
				{
					r_FGREGORIAN_XLIT_FRENCH = new(Type, "GREGORIAN_XLIT_FRENCH");
				}
				return r_FGREGORIAN_XLIT_FRENCH;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarId JULIAN
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId r_FJULIAN;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId RFJULIAN
		{
			get
			{
				if(r_FJULIAN == null)
				{
					r_FJULIAN = new(Type, "JULIAN");
				}
				return r_FJULIAN;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarId JAPANESELUNISOLAR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId r_FJAPANESELUNISOLAR;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId RFJAPANESELUNISOLAR
		{
			get
			{
				if(r_FJAPANESELUNISOLAR == null)
				{
					r_FJAPANESELUNISOLAR = new(Type, "JAPANESELUNISOLAR");
				}
				return r_FJAPANESELUNISOLAR;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarId CHINESELUNISOLAR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId r_FCHINESELUNISOLAR;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId RFCHINESELUNISOLAR
		{
			get
			{
				if(r_FCHINESELUNISOLAR == null)
				{
					r_FCHINESELUNISOLAR = new(Type, "CHINESELUNISOLAR");
				}
				return r_FCHINESELUNISOLAR;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarId SAKA
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId r_FSAKA;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId RFSAKA
		{
			get
			{
				if(r_FSAKA == null)
				{
					r_FSAKA = new(Type, "SAKA");
				}
				return r_FSAKA;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarId LUNAR_ETO_CHN
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId r_FLUNAR_ETO_CHN;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId RFLUNAR_ETO_CHN
		{
			get
			{
				if(r_FLUNAR_ETO_CHN == null)
				{
					r_FLUNAR_ETO_CHN = new(Type, "LUNAR_ETO_CHN");
				}
				return r_FLUNAR_ETO_CHN;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarId LUNAR_ETO_KOR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId r_FLUNAR_ETO_KOR;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId RFLUNAR_ETO_KOR
		{
			get
			{
				if(r_FLUNAR_ETO_KOR == null)
				{
					r_FLUNAR_ETO_KOR = new(Type, "LUNAR_ETO_KOR");
				}
				return r_FLUNAR_ETO_KOR;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarId LUNAR_ETO_ROKUYOU
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId r_FLUNAR_ETO_ROKUYOU;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId RFLUNAR_ETO_ROKUYOU
		{
			get
			{
				if(r_FLUNAR_ETO_ROKUYOU == null)
				{
					r_FLUNAR_ETO_ROKUYOU = new(Type, "LUNAR_ETO_ROKUYOU");
				}
				return r_FLUNAR_ETO_ROKUYOU;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarId KOREANLUNISOLAR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId r_FKOREANLUNISOLAR;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId RFKOREANLUNISOLAR
		{
			get
			{
				if(r_FKOREANLUNISOLAR == null)
				{
					r_FKOREANLUNISOLAR = new(Type, "KOREANLUNISOLAR");
				}
				return r_FKOREANLUNISOLAR;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarId TAIWANLUNISOLAR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId r_FTAIWANLUNISOLAR;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId RFTAIWANLUNISOLAR
		{
			get
			{
				if(r_FTAIWANLUNISOLAR == null)
				{
					r_FTAIWANLUNISOLAR = new(Type, "TAIWANLUNISOLAR");
				}
				return r_FTAIWANLUNISOLAR;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarId PERSIAN
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId r_FPERSIAN;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId RFPERSIAN
		{
			get
			{
				if(r_FPERSIAN == null)
				{
					r_FPERSIAN = new(Type, "PERSIAN");
				}
				return r_FPERSIAN;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarId UMALQURA
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId r_FUMALQURA;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId RFUMALQURA
		{
			get
			{
				if(r_FUMALQURA == null)
				{
					r_FUMALQURA = new(Type, "UMALQURA");
				}
				return r_FUMALQURA;
			}
		}

		/// <summary>
		/// System.Globalization.CalendarId LAST_CALENDAR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId r_FLAST_CALENDAR;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendarId RFLAST_CALENDAR
		{
			get
			{
				if(r_FLAST_CALENDAR == null)
				{
					r_FLAST_CALENDAR = new(Type, "LAST_CALENDAR");
				}
				return r_FLAST_CALENDAR;
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
				}
				return r_MGetValue;
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
				}
				return r_MGetTypeCode;
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


        public virtual System.Object GetValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValue.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

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


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Int32 CompareTo(System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean HasFlag(System.Enum @flag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flag};
            var ___result = RMHasFlag_Enum.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.TypeCode>(___result);
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
