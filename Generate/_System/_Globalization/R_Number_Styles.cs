
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RGlobalization
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Globalization.NumberStyles
	/// </summary>
    public partial class RNumberStyles : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Globalization.NumberStyles);
            }
        }

        public RNumberStyles() : base("System.Globalization.NumberStyles")
        {
        }

        public RNumberStyles(System.Object instance) : base("System.Globalization.NumberStyles")
		{
            SetInstance(instance);
		}

        public RNumberStyles(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RNumberStyles(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 value__
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fvalue__;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFvalue__
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
		/// System.Globalization.NumberStyles None
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles r_FNone;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles RFNone
		{
			get
			{
				if(r_FNone == null)
				{
					r_FNone = new(Type, "None");
				}
				return r_FNone;
			}
		}

		/// <summary>
		/// System.Globalization.NumberStyles AllowLeadingWhite
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles r_FAllowLeadingWhite;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles RFAllowLeadingWhite
		{
			get
			{
				if(r_FAllowLeadingWhite == null)
				{
					r_FAllowLeadingWhite = new(Type, "AllowLeadingWhite");
				}
				return r_FAllowLeadingWhite;
			}
		}

		/// <summary>
		/// System.Globalization.NumberStyles AllowTrailingWhite
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles r_FAllowTrailingWhite;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles RFAllowTrailingWhite
		{
			get
			{
				if(r_FAllowTrailingWhite == null)
				{
					r_FAllowTrailingWhite = new(Type, "AllowTrailingWhite");
				}
				return r_FAllowTrailingWhite;
			}
		}

		/// <summary>
		/// System.Globalization.NumberStyles AllowLeadingSign
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles r_FAllowLeadingSign;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles RFAllowLeadingSign
		{
			get
			{
				if(r_FAllowLeadingSign == null)
				{
					r_FAllowLeadingSign = new(Type, "AllowLeadingSign");
				}
				return r_FAllowLeadingSign;
			}
		}

		/// <summary>
		/// System.Globalization.NumberStyles AllowTrailingSign
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles r_FAllowTrailingSign;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles RFAllowTrailingSign
		{
			get
			{
				if(r_FAllowTrailingSign == null)
				{
					r_FAllowTrailingSign = new(Type, "AllowTrailingSign");
				}
				return r_FAllowTrailingSign;
			}
		}

		/// <summary>
		/// System.Globalization.NumberStyles AllowParentheses
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles r_FAllowParentheses;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles RFAllowParentheses
		{
			get
			{
				if(r_FAllowParentheses == null)
				{
					r_FAllowParentheses = new(Type, "AllowParentheses");
				}
				return r_FAllowParentheses;
			}
		}

		/// <summary>
		/// System.Globalization.NumberStyles AllowDecimalPoint
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles r_FAllowDecimalPoint;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles RFAllowDecimalPoint
		{
			get
			{
				if(r_FAllowDecimalPoint == null)
				{
					r_FAllowDecimalPoint = new(Type, "AllowDecimalPoint");
				}
				return r_FAllowDecimalPoint;
			}
		}

		/// <summary>
		/// System.Globalization.NumberStyles AllowThousands
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles r_FAllowThousands;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles RFAllowThousands
		{
			get
			{
				if(r_FAllowThousands == null)
				{
					r_FAllowThousands = new(Type, "AllowThousands");
				}
				return r_FAllowThousands;
			}
		}

		/// <summary>
		/// System.Globalization.NumberStyles AllowExponent
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles r_FAllowExponent;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles RFAllowExponent
		{
			get
			{
				if(r_FAllowExponent == null)
				{
					r_FAllowExponent = new(Type, "AllowExponent");
				}
				return r_FAllowExponent;
			}
		}

		/// <summary>
		/// System.Globalization.NumberStyles AllowCurrencySymbol
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles r_FAllowCurrencySymbol;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles RFAllowCurrencySymbol
		{
			get
			{
				if(r_FAllowCurrencySymbol == null)
				{
					r_FAllowCurrencySymbol = new(Type, "AllowCurrencySymbol");
				}
				return r_FAllowCurrencySymbol;
			}
		}

		/// <summary>
		/// System.Globalization.NumberStyles AllowHexSpecifier
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles r_FAllowHexSpecifier;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles RFAllowHexSpecifier
		{
			get
			{
				if(r_FAllowHexSpecifier == null)
				{
					r_FAllowHexSpecifier = new(Type, "AllowHexSpecifier");
				}
				return r_FAllowHexSpecifier;
			}
		}

		/// <summary>
		/// System.Globalization.NumberStyles Integer
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles r_FInteger;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles RFInteger
		{
			get
			{
				if(r_FInteger == null)
				{
					r_FInteger = new(Type, "Integer");
				}
				return r_FInteger;
			}
		}

		/// <summary>
		/// System.Globalization.NumberStyles HexNumber
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles r_FHexNumber;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles RFHexNumber
		{
			get
			{
				if(r_FHexNumber == null)
				{
					r_FHexNumber = new(Type, "HexNumber");
				}
				return r_FHexNumber;
			}
		}

		/// <summary>
		/// System.Globalization.NumberStyles Number
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles r_FNumber;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles RFNumber
		{
			get
			{
				if(r_FNumber == null)
				{
					r_FNumber = new(Type, "Number");
				}
				return r_FNumber;
			}
		}

		/// <summary>
		/// System.Globalization.NumberStyles Float
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles r_FFloat;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles RFFloat
		{
			get
			{
				if(r_FFloat == null)
				{
					r_FFloat = new(Type, "Float");
				}
				return r_FFloat;
			}
		}

		/// <summary>
		/// System.Globalization.NumberStyles Currency
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles r_FCurrency;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles RFCurrency
		{
			get
			{
				if(r_FCurrency == null)
				{
					r_FCurrency = new(Type, "Currency");
				}
				return r_FCurrency;
			}
		}

		/// <summary>
		/// System.Globalization.NumberStyles Any
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles r_FAny;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles RFAny
		{
			get
			{
				if(r_FAny == null)
				{
					r_FAny = new(Type, "Any");
				}
				return r_FAny;
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
