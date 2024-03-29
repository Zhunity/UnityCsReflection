
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.TouchScreenKeyboardType
	/// </summary>
    public partial class RTouchScreenKeyboardType : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.TouchScreenKeyboardType);
            }
        }

        public RTouchScreenKeyboardType() : base("UnityEngine.TouchScreenKeyboardType")
        {
        }

        public RTouchScreenKeyboardType(System.Object instance) : base("UnityEngine.TouchScreenKeyboardType")
		{
            SetInstance(instance);
		}

        public RTouchScreenKeyboardType(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTouchScreenKeyboardType(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
		/// UnityEngine.TouchScreenKeyboardType Default
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboardType r_FDefault;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboardType RFDefault
		{
			get
			{
				if(r_FDefault == null)
				{
					r_FDefault = new(Type, "Default");
				}
				return r_FDefault;
			}
		}

		/// <summary>
		/// UnityEngine.TouchScreenKeyboardType ASCIICapable
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboardType r_FASCIICapable;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboardType RFASCIICapable
		{
			get
			{
				if(r_FASCIICapable == null)
				{
					r_FASCIICapable = new(Type, "ASCIICapable");
				}
				return r_FASCIICapable;
			}
		}

		/// <summary>
		/// UnityEngine.TouchScreenKeyboardType NumbersAndPunctuation
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboardType r_FNumbersAndPunctuation;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboardType RFNumbersAndPunctuation
		{
			get
			{
				if(r_FNumbersAndPunctuation == null)
				{
					r_FNumbersAndPunctuation = new(Type, "NumbersAndPunctuation");
				}
				return r_FNumbersAndPunctuation;
			}
		}

		/// <summary>
		/// UnityEngine.TouchScreenKeyboardType URL
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboardType r_FURL;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboardType RFURL
		{
			get
			{
				if(r_FURL == null)
				{
					r_FURL = new(Type, "URL");
				}
				return r_FURL;
			}
		}

		/// <summary>
		/// UnityEngine.TouchScreenKeyboardType NumberPad
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboardType r_FNumberPad;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboardType RFNumberPad
		{
			get
			{
				if(r_FNumberPad == null)
				{
					r_FNumberPad = new(Type, "NumberPad");
				}
				return r_FNumberPad;
			}
		}

		/// <summary>
		/// UnityEngine.TouchScreenKeyboardType PhonePad
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboardType r_FPhonePad;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboardType RFPhonePad
		{
			get
			{
				if(r_FPhonePad == null)
				{
					r_FPhonePad = new(Type, "PhonePad");
				}
				return r_FPhonePad;
			}
		}

		/// <summary>
		/// UnityEngine.TouchScreenKeyboardType NamePhonePad
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboardType r_FNamePhonePad;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboardType RFNamePhonePad
		{
			get
			{
				if(r_FNamePhonePad == null)
				{
					r_FNamePhonePad = new(Type, "NamePhonePad");
				}
				return r_FNamePhonePad;
			}
		}

		/// <summary>
		/// UnityEngine.TouchScreenKeyboardType EmailAddress
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboardType r_FEmailAddress;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboardType RFEmailAddress
		{
			get
			{
				if(r_FEmailAddress == null)
				{
					r_FEmailAddress = new(Type, "EmailAddress");
				}
				return r_FEmailAddress;
			}
		}

		/// <summary>
		/// UnityEngine.TouchScreenKeyboardType NintendoNetworkAccount
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboardType r_FNintendoNetworkAccount;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboardType RFNintendoNetworkAccount
		{
			get
			{
				if(r_FNintendoNetworkAccount == null)
				{
					r_FNintendoNetworkAccount = new(Type, "NintendoNetworkAccount");
				}
				return r_FNintendoNetworkAccount;
			}
		}

		/// <summary>
		/// UnityEngine.TouchScreenKeyboardType Social
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboardType r_FSocial;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboardType RFSocial
		{
			get
			{
				if(r_FSocial == null)
				{
					r_FSocial = new(Type, "Social");
				}
				return r_FSocial;
			}
		}

		/// <summary>
		/// UnityEngine.TouchScreenKeyboardType Search
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboardType r_FSearch;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboardType RFSearch
		{
			get
			{
				if(r_FSearch == null)
				{
					r_FSearch = new(Type, "Search");
				}
				return r_FSearch;
			}
		}

		/// <summary>
		/// UnityEngine.TouchScreenKeyboardType DecimalPad
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboardType r_FDecimalPad;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboardType RFDecimalPad
		{
			get
			{
				if(r_FDecimalPad == null)
				{
					r_FDecimalPad = new(Type, "DecimalPad");
				}
				return r_FDecimalPad;
			}
		}

		/// <summary>
		/// UnityEngine.TouchScreenKeyboardType OneTimeCode
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboardType r_FOneTimeCode;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboardType RFOneTimeCode
		{
			get
			{
				if(r_FOneTimeCode == null)
				{
					r_FOneTimeCode = new(Type, "OneTimeCode");
				}
				return r_FOneTimeCode;
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
