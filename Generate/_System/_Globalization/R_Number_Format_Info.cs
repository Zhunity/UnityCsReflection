
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RGlobalization
{
	/// <summary>
	/// System.Globalization.NumberFormatInfo
	/// </summary>
    public partial class RNumberFormatInfo : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Globalization.NumberFormatInfo);
            }
        }

        public RNumberFormatInfo() : base("System.Globalization.NumberFormatInfo")
        {
        }

        public RNumberFormatInfo(System.Object instance) : base("System.Globalization.NumberFormatInfo")
		{
            SetInstance(instance);
		}

        public RNumberFormatInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RNumberFormatInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Globalization.NumberFormatInfo invariantInfo
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberFormatInfo r_FinvariantInfo;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberFormatInfo RFinvariantInfo
		{
			get
			{
				if(r_FinvariantInfo == null)
				{
					r_FinvariantInfo = new(typeof(System.Globalization.NumberFormatInfo), "invariantInfo");
				}
				return r_FinvariantInfo;
			}
		}

		/// <summary>
		/// System.Int32[] numberGroupSizes
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_FnumberGroupSizes;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> RFnumberGroupSizes
		{
			get
			{
				if(r_FnumberGroupSizes == null)
				{
					r_FnumberGroupSizes = new(this, "numberGroupSizes");
				}
				return r_FnumberGroupSizes;
			}
		}

		/// <summary>
		/// System.Int32[] currencyGroupSizes
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_FcurrencyGroupSizes;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> RFcurrencyGroupSizes
		{
			get
			{
				if(r_FcurrencyGroupSizes == null)
				{
					r_FcurrencyGroupSizes = new(this, "currencyGroupSizes");
				}
				return r_FcurrencyGroupSizes;
			}
		}

		/// <summary>
		/// System.Int32[] percentGroupSizes
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_FpercentGroupSizes;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> RFpercentGroupSizes
		{
			get
			{
				if(r_FpercentGroupSizes == null)
				{
					r_FpercentGroupSizes = new(this, "percentGroupSizes");
				}
				return r_FpercentGroupSizes;
			}
		}

		/// <summary>
		/// System.String positiveSign
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FpositiveSign;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFpositiveSign
		{
			get
			{
				if(r_FpositiveSign == null)
				{
					r_FpositiveSign = new(this, "positiveSign");
				}
				return r_FpositiveSign;
			}
		}

		/// <summary>
		/// System.String negativeSign
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FnegativeSign;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFnegativeSign
		{
			get
			{
				if(r_FnegativeSign == null)
				{
					r_FnegativeSign = new(this, "negativeSign");
				}
				return r_FnegativeSign;
			}
		}

		/// <summary>
		/// System.String numberDecimalSeparator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FnumberDecimalSeparator;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFnumberDecimalSeparator
		{
			get
			{
				if(r_FnumberDecimalSeparator == null)
				{
					r_FnumberDecimalSeparator = new(this, "numberDecimalSeparator");
				}
				return r_FnumberDecimalSeparator;
			}
		}

		/// <summary>
		/// System.String numberGroupSeparator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FnumberGroupSeparator;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFnumberGroupSeparator
		{
			get
			{
				if(r_FnumberGroupSeparator == null)
				{
					r_FnumberGroupSeparator = new(this, "numberGroupSeparator");
				}
				return r_FnumberGroupSeparator;
			}
		}

		/// <summary>
		/// System.String currencyGroupSeparator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FcurrencyGroupSeparator;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFcurrencyGroupSeparator
		{
			get
			{
				if(r_FcurrencyGroupSeparator == null)
				{
					r_FcurrencyGroupSeparator = new(this, "currencyGroupSeparator");
				}
				return r_FcurrencyGroupSeparator;
			}
		}

		/// <summary>
		/// System.String currencyDecimalSeparator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FcurrencyDecimalSeparator;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFcurrencyDecimalSeparator
		{
			get
			{
				if(r_FcurrencyDecimalSeparator == null)
				{
					r_FcurrencyDecimalSeparator = new(this, "currencyDecimalSeparator");
				}
				return r_FcurrencyDecimalSeparator;
			}
		}

		/// <summary>
		/// System.String currencySymbol
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FcurrencySymbol;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFcurrencySymbol
		{
			get
			{
				if(r_FcurrencySymbol == null)
				{
					r_FcurrencySymbol = new(this, "currencySymbol");
				}
				return r_FcurrencySymbol;
			}
		}

		/// <summary>
		/// System.String ansiCurrencySymbol
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FansiCurrencySymbol;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFansiCurrencySymbol
		{
			get
			{
				if(r_FansiCurrencySymbol == null)
				{
					r_FansiCurrencySymbol = new(this, "ansiCurrencySymbol");
				}
				return r_FansiCurrencySymbol;
			}
		}

		/// <summary>
		/// System.String nanSymbol
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FnanSymbol;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFnanSymbol
		{
			get
			{
				if(r_FnanSymbol == null)
				{
					r_FnanSymbol = new(this, "nanSymbol");
				}
				return r_FnanSymbol;
			}
		}

		/// <summary>
		/// System.String positiveInfinitySymbol
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FpositiveInfinitySymbol;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFpositiveInfinitySymbol
		{
			get
			{
				if(r_FpositiveInfinitySymbol == null)
				{
					r_FpositiveInfinitySymbol = new(this, "positiveInfinitySymbol");
				}
				return r_FpositiveInfinitySymbol;
			}
		}

		/// <summary>
		/// System.String negativeInfinitySymbol
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FnegativeInfinitySymbol;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFnegativeInfinitySymbol
		{
			get
			{
				if(r_FnegativeInfinitySymbol == null)
				{
					r_FnegativeInfinitySymbol = new(this, "negativeInfinitySymbol");
				}
				return r_FnegativeInfinitySymbol;
			}
		}

		/// <summary>
		/// System.String percentDecimalSeparator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FpercentDecimalSeparator;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFpercentDecimalSeparator
		{
			get
			{
				if(r_FpercentDecimalSeparator == null)
				{
					r_FpercentDecimalSeparator = new(this, "percentDecimalSeparator");
				}
				return r_FpercentDecimalSeparator;
			}
		}

		/// <summary>
		/// System.String percentGroupSeparator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FpercentGroupSeparator;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFpercentGroupSeparator
		{
			get
			{
				if(r_FpercentGroupSeparator == null)
				{
					r_FpercentGroupSeparator = new(this, "percentGroupSeparator");
				}
				return r_FpercentGroupSeparator;
			}
		}

		/// <summary>
		/// System.String percentSymbol
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FpercentSymbol;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFpercentSymbol
		{
			get
			{
				if(r_FpercentSymbol == null)
				{
					r_FpercentSymbol = new(this, "percentSymbol");
				}
				return r_FpercentSymbol;
			}
		}

		/// <summary>
		/// System.String perMilleSymbol
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FperMilleSymbol;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFperMilleSymbol
		{
			get
			{
				if(r_FperMilleSymbol == null)
				{
					r_FperMilleSymbol = new(this, "perMilleSymbol");
				}
				return r_FperMilleSymbol;
			}
		}

		/// <summary>
		/// System.String[] nativeDigits
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FnativeDigits;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFnativeDigits
		{
			get
			{
				if(r_FnativeDigits == null)
				{
					r_FnativeDigits = new(this, "nativeDigits");
				}
				return r_FnativeDigits;
			}
		}

		/// <summary>
		/// System.Int32 m_dataItem
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_dataItem;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_dataItem
		{
			get
			{
				if(r_Fm_dataItem == null)
				{
					r_Fm_dataItem = new(this, "m_dataItem");
				}
				return r_Fm_dataItem;
			}
		}

		/// <summary>
		/// System.Int32 numberDecimalDigits
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FnumberDecimalDigits;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFnumberDecimalDigits
		{
			get
			{
				if(r_FnumberDecimalDigits == null)
				{
					r_FnumberDecimalDigits = new(this, "numberDecimalDigits");
				}
				return r_FnumberDecimalDigits;
			}
		}

		/// <summary>
		/// System.Int32 currencyDecimalDigits
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FcurrencyDecimalDigits;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFcurrencyDecimalDigits
		{
			get
			{
				if(r_FcurrencyDecimalDigits == null)
				{
					r_FcurrencyDecimalDigits = new(this, "currencyDecimalDigits");
				}
				return r_FcurrencyDecimalDigits;
			}
		}

		/// <summary>
		/// System.Int32 currencyPositivePattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FcurrencyPositivePattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFcurrencyPositivePattern
		{
			get
			{
				if(r_FcurrencyPositivePattern == null)
				{
					r_FcurrencyPositivePattern = new(this, "currencyPositivePattern");
				}
				return r_FcurrencyPositivePattern;
			}
		}

		/// <summary>
		/// System.Int32 currencyNegativePattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FcurrencyNegativePattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFcurrencyNegativePattern
		{
			get
			{
				if(r_FcurrencyNegativePattern == null)
				{
					r_FcurrencyNegativePattern = new(this, "currencyNegativePattern");
				}
				return r_FcurrencyNegativePattern;
			}
		}

		/// <summary>
		/// System.Int32 numberNegativePattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FnumberNegativePattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFnumberNegativePattern
		{
			get
			{
				if(r_FnumberNegativePattern == null)
				{
					r_FnumberNegativePattern = new(this, "numberNegativePattern");
				}
				return r_FnumberNegativePattern;
			}
		}

		/// <summary>
		/// System.Int32 percentPositivePattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FpercentPositivePattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFpercentPositivePattern
		{
			get
			{
				if(r_FpercentPositivePattern == null)
				{
					r_FpercentPositivePattern = new(this, "percentPositivePattern");
				}
				return r_FpercentPositivePattern;
			}
		}

		/// <summary>
		/// System.Int32 percentNegativePattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FpercentNegativePattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFpercentNegativePattern
		{
			get
			{
				if(r_FpercentNegativePattern == null)
				{
					r_FpercentNegativePattern = new(this, "percentNegativePattern");
				}
				return r_FpercentNegativePattern;
			}
		}

		/// <summary>
		/// System.Int32 percentDecimalDigits
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FpercentDecimalDigits;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFpercentDecimalDigits
		{
			get
			{
				if(r_FpercentDecimalDigits == null)
				{
					r_FpercentDecimalDigits = new(this, "percentDecimalDigits");
				}
				return r_FpercentDecimalDigits;
			}
		}

		/// <summary>
		/// System.Int32 digitSubstitution
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FdigitSubstitution;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFdigitSubstitution
		{
			get
			{
				if(r_FdigitSubstitution == null)
				{
					r_FdigitSubstitution = new(this, "digitSubstitution");
				}
				return r_FdigitSubstitution;
			}
		}

		/// <summary>
		/// System.Boolean isReadOnly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FisReadOnly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFisReadOnly
		{
			get
			{
				if(r_FisReadOnly == null)
				{
					r_FisReadOnly = new(this, "isReadOnly");
				}
				return r_FisReadOnly;
			}
		}

		/// <summary>
		/// System.Boolean m_useUserOverride
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_useUserOverride;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_useUserOverride
		{
			get
			{
				if(r_Fm_useUserOverride == null)
				{
					r_Fm_useUserOverride = new(this, "m_useUserOverride");
				}
				return r_Fm_useUserOverride;
			}
		}

		/// <summary>
		/// System.Boolean m_isInvariant
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_isInvariant;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_isInvariant
		{
			get
			{
				if(r_Fm_isInvariant == null)
				{
					r_Fm_isInvariant = new(this, "m_isInvariant");
				}
				return r_Fm_isInvariant;
			}
		}

		/// <summary>
		/// System.Boolean validForParseAsNumber
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FvalidForParseAsNumber;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFvalidForParseAsNumber
		{
			get
			{
				if(r_FvalidForParseAsNumber == null)
				{
					r_FvalidForParseAsNumber = new(this, "validForParseAsNumber");
				}
				return r_FvalidForParseAsNumber;
			}
		}

		/// <summary>
		/// System.Boolean validForParseAsCurrency
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FvalidForParseAsCurrency;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFvalidForParseAsCurrency
		{
			get
			{
				if(r_FvalidForParseAsCurrency == null)
				{
					r_FvalidForParseAsCurrency = new(this, "validForParseAsCurrency");
				}
				return r_FvalidForParseAsCurrency;
			}
		}

		/// <summary>
		/// System.Globalization.NumberStyles InvalidNumberStyles
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles r_FInvalidNumberStyles;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberStyles RFInvalidNumberStyles
		{
			get
			{
				if(r_FInvalidNumberStyles == null)
				{
					r_FInvalidNumberStyles = new(typeof(System.Globalization.NumberFormatInfo), "InvalidNumberStyles");
				}
				return r_FInvalidNumberStyles;
			}
		}

		/// <summary>
		/// System.Globalization.NumberFormatInfo InvariantInfo
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberFormatInfo r_PInvariantInfo;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberFormatInfo RPInvariantInfo
		{
			get
			{
				if(r_PInvariantInfo == null)
				{
					r_PInvariantInfo = new(typeof(System.Globalization.NumberFormatInfo), "InvariantInfo", -1);
				}
				return r_PInvariantInfo;
			}
		}

		/// <summary>
		/// Int32 CurrencyDecimalDigits
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PCurrencyDecimalDigits;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPCurrencyDecimalDigits
		{
			get
			{
				if(r_PCurrencyDecimalDigits == null)
				{
					r_PCurrencyDecimalDigits = new(this, "CurrencyDecimalDigits", -1);
				}
				return r_PCurrencyDecimalDigits;
			}
		}

		/// <summary>
		/// System.String CurrencyDecimalSeparator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PCurrencyDecimalSeparator;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPCurrencyDecimalSeparator
		{
			get
			{
				if(r_PCurrencyDecimalSeparator == null)
				{
					r_PCurrencyDecimalSeparator = new(this, "CurrencyDecimalSeparator", -1);
				}
				return r_PCurrencyDecimalSeparator;
			}
		}

		/// <summary>
		/// Boolean IsReadOnly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsReadOnly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsReadOnly
		{
			get
			{
				if(r_PIsReadOnly == null)
				{
					r_PIsReadOnly = new(this, "IsReadOnly", -1);
				}
				return r_PIsReadOnly;
			}
		}

		/// <summary>
		/// Int32[] CurrencyGroupSizes
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_PCurrencyGroupSizes;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RInt32> RPCurrencyGroupSizes
		{
			get
			{
				if(r_PCurrencyGroupSizes == null)
				{
					r_PCurrencyGroupSizes = new(this, "CurrencyGroupSizes", -1);
				}
				return r_PCurrencyGroupSizes;
			}
		}

		/// <summary>
		/// Int32[] NumberGroupSizes
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_PNumberGroupSizes;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RInt32> RPNumberGroupSizes
		{
			get
			{
				if(r_PNumberGroupSizes == null)
				{
					r_PNumberGroupSizes = new(this, "NumberGroupSizes", -1);
				}
				return r_PNumberGroupSizes;
			}
		}

		/// <summary>
		/// Int32[] PercentGroupSizes
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_PPercentGroupSizes;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RInt32> RPPercentGroupSizes
		{
			get
			{
				if(r_PPercentGroupSizes == null)
				{
					r_PPercentGroupSizes = new(this, "PercentGroupSizes", -1);
				}
				return r_PPercentGroupSizes;
			}
		}

		/// <summary>
		/// System.String CurrencyGroupSeparator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PCurrencyGroupSeparator;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPCurrencyGroupSeparator
		{
			get
			{
				if(r_PCurrencyGroupSeparator == null)
				{
					r_PCurrencyGroupSeparator = new(this, "CurrencyGroupSeparator", -1);
				}
				return r_PCurrencyGroupSeparator;
			}
		}

		/// <summary>
		/// System.String CurrencySymbol
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PCurrencySymbol;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPCurrencySymbol
		{
			get
			{
				if(r_PCurrencySymbol == null)
				{
					r_PCurrencySymbol = new(this, "CurrencySymbol", -1);
				}
				return r_PCurrencySymbol;
			}
		}

		/// <summary>
		/// System.Globalization.NumberFormatInfo CurrentInfo
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberFormatInfo r_PCurrentInfo;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberFormatInfo RPCurrentInfo
		{
			get
			{
				if(r_PCurrentInfo == null)
				{
					r_PCurrentInfo = new(typeof(System.Globalization.NumberFormatInfo), "CurrentInfo", -1);
				}
				return r_PCurrentInfo;
			}
		}

		/// <summary>
		/// System.String NaNSymbol
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PNaNSymbol;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPNaNSymbol
		{
			get
			{
				if(r_PNaNSymbol == null)
				{
					r_PNaNSymbol = new(this, "NaNSymbol", -1);
				}
				return r_PNaNSymbol;
			}
		}

		/// <summary>
		/// Int32 CurrencyNegativePattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PCurrencyNegativePattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPCurrencyNegativePattern
		{
			get
			{
				if(r_PCurrencyNegativePattern == null)
				{
					r_PCurrencyNegativePattern = new(this, "CurrencyNegativePattern", -1);
				}
				return r_PCurrencyNegativePattern;
			}
		}

		/// <summary>
		/// Int32 NumberNegativePattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PNumberNegativePattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPNumberNegativePattern
		{
			get
			{
				if(r_PNumberNegativePattern == null)
				{
					r_PNumberNegativePattern = new(this, "NumberNegativePattern", -1);
				}
				return r_PNumberNegativePattern;
			}
		}

		/// <summary>
		/// Int32 PercentPositivePattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PPercentPositivePattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPPercentPositivePattern
		{
			get
			{
				if(r_PPercentPositivePattern == null)
				{
					r_PPercentPositivePattern = new(this, "PercentPositivePattern", -1);
				}
				return r_PPercentPositivePattern;
			}
		}

		/// <summary>
		/// Int32 PercentNegativePattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PPercentNegativePattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPPercentNegativePattern
		{
			get
			{
				if(r_PPercentNegativePattern == null)
				{
					r_PPercentNegativePattern = new(this, "PercentNegativePattern", -1);
				}
				return r_PPercentNegativePattern;
			}
		}

		/// <summary>
		/// System.String NegativeInfinitySymbol
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PNegativeInfinitySymbol;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPNegativeInfinitySymbol
		{
			get
			{
				if(r_PNegativeInfinitySymbol == null)
				{
					r_PNegativeInfinitySymbol = new(this, "NegativeInfinitySymbol", -1);
				}
				return r_PNegativeInfinitySymbol;
			}
		}

		/// <summary>
		/// System.String NegativeSign
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PNegativeSign;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPNegativeSign
		{
			get
			{
				if(r_PNegativeSign == null)
				{
					r_PNegativeSign = new(this, "NegativeSign", -1);
				}
				return r_PNegativeSign;
			}
		}

		/// <summary>
		/// Int32 NumberDecimalDigits
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PNumberDecimalDigits;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPNumberDecimalDigits
		{
			get
			{
				if(r_PNumberDecimalDigits == null)
				{
					r_PNumberDecimalDigits = new(this, "NumberDecimalDigits", -1);
				}
				return r_PNumberDecimalDigits;
			}
		}

		/// <summary>
		/// System.String NumberDecimalSeparator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PNumberDecimalSeparator;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPNumberDecimalSeparator
		{
			get
			{
				if(r_PNumberDecimalSeparator == null)
				{
					r_PNumberDecimalSeparator = new(this, "NumberDecimalSeparator", -1);
				}
				return r_PNumberDecimalSeparator;
			}
		}

		/// <summary>
		/// System.String NumberGroupSeparator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PNumberGroupSeparator;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPNumberGroupSeparator
		{
			get
			{
				if(r_PNumberGroupSeparator == null)
				{
					r_PNumberGroupSeparator = new(this, "NumberGroupSeparator", -1);
				}
				return r_PNumberGroupSeparator;
			}
		}

		/// <summary>
		/// Int32 CurrencyPositivePattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PCurrencyPositivePattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPCurrencyPositivePattern
		{
			get
			{
				if(r_PCurrencyPositivePattern == null)
				{
					r_PCurrencyPositivePattern = new(this, "CurrencyPositivePattern", -1);
				}
				return r_PCurrencyPositivePattern;
			}
		}

		/// <summary>
		/// System.String PositiveInfinitySymbol
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PPositiveInfinitySymbol;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPPositiveInfinitySymbol
		{
			get
			{
				if(r_PPositiveInfinitySymbol == null)
				{
					r_PPositiveInfinitySymbol = new(this, "PositiveInfinitySymbol", -1);
				}
				return r_PPositiveInfinitySymbol;
			}
		}

		/// <summary>
		/// System.String PositiveSign
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PPositiveSign;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPPositiveSign
		{
			get
			{
				if(r_PPositiveSign == null)
				{
					r_PPositiveSign = new(this, "PositiveSign", -1);
				}
				return r_PPositiveSign;
			}
		}

		/// <summary>
		/// Int32 PercentDecimalDigits
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PPercentDecimalDigits;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPPercentDecimalDigits
		{
			get
			{
				if(r_PPercentDecimalDigits == null)
				{
					r_PPercentDecimalDigits = new(this, "PercentDecimalDigits", -1);
				}
				return r_PPercentDecimalDigits;
			}
		}

		/// <summary>
		/// System.String PercentDecimalSeparator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PPercentDecimalSeparator;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPPercentDecimalSeparator
		{
			get
			{
				if(r_PPercentDecimalSeparator == null)
				{
					r_PPercentDecimalSeparator = new(this, "PercentDecimalSeparator", -1);
				}
				return r_PPercentDecimalSeparator;
			}
		}

		/// <summary>
		/// System.String PercentGroupSeparator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PPercentGroupSeparator;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPPercentGroupSeparator
		{
			get
			{
				if(r_PPercentGroupSeparator == null)
				{
					r_PPercentGroupSeparator = new(this, "PercentGroupSeparator", -1);
				}
				return r_PPercentGroupSeparator;
			}
		}

		/// <summary>
		/// System.String PercentSymbol
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PPercentSymbol;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPPercentSymbol
		{
			get
			{
				if(r_PPercentSymbol == null)
				{
					r_PPercentSymbol = new(this, "PercentSymbol", -1);
				}
				return r_PPercentSymbol;
			}
		}

		/// <summary>
		/// System.String PerMilleSymbol
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PPerMilleSymbol;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPPerMilleSymbol
		{
			get
			{
				if(r_PPerMilleSymbol == null)
				{
					r_PPerMilleSymbol = new(this, "PerMilleSymbol", -1);
				}
				return r_PPerMilleSymbol;
			}
		}

		/// <summary>
		/// System.String[] NativeDigits
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_PNativeDigits;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPNativeDigits
		{
			get
			{
				if(r_PNativeDigits == null)
				{
					r_PNativeDigits = new(this, "NativeDigits", -1);
				}
				return r_PNativeDigits;
			}
		}

		/// <summary>
		/// System.Globalization.DigitShapes DigitSubstitution
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RDigitShapes r_PDigitSubstitution;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RDigitShapes RPDigitSubstitution
		{
			get
			{
				if(r_PDigitSubstitution == null)
				{
					r_PDigitSubstitution = new(this, "DigitSubstitution", -1);
				}
				return r_PDigitSubstitution;
			}
		}

		/// <summary>
		/// Void OnSerializing(System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MOnSerializing_StreamingContext;
		public virtual RMethod RMOnSerializing_StreamingContext
		{
			get
			{
				if(r_MOnSerializing_StreamingContext == null)
				{
					r_MOnSerializing_StreamingContext = new(this, "OnSerializing", 0, typeof(System.Runtime.Serialization.StreamingContext));
				}
				return r_MOnSerializing_StreamingContext;
			}
		}

		/// <summary>
		/// Void OnDeserializing(System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MOnDeserializing_StreamingContext;
		public virtual RMethod RMOnDeserializing_StreamingContext
		{
			get
			{
				if(r_MOnDeserializing_StreamingContext == null)
				{
					r_MOnDeserializing_StreamingContext = new(this, "OnDeserializing", 0, typeof(System.Runtime.Serialization.StreamingContext));
				}
				return r_MOnDeserializing_StreamingContext;
			}
		}

		/// <summary>
		/// Void OnDeserialized(System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MOnDeserialized_StreamingContext;
		public virtual RMethod RMOnDeserialized_StreamingContext
		{
			get
			{
				if(r_MOnDeserialized_StreamingContext == null)
				{
					r_MOnDeserialized_StreamingContext = new(this, "OnDeserialized", 0, typeof(System.Runtime.Serialization.StreamingContext));
				}
				return r_MOnDeserialized_StreamingContext;
			}
		}

		/// <summary>
		/// Void VerifyDecimalSeparator(System.String, System.String)
		/// </summary>
		protected static RMethod r_MVerifyDecimalSeparator_String_String;
		public static RMethod RMVerifyDecimalSeparator_String_String
		{
			get
			{
				if(r_MVerifyDecimalSeparator_String_String == null)
				{
					r_MVerifyDecimalSeparator_String_String = new(typeof(System.Globalization.NumberFormatInfo), "VerifyDecimalSeparator", 0, typeof(System.String), typeof(System.String));
				}
				return r_MVerifyDecimalSeparator_String_String;
			}
		}

		/// <summary>
		/// Void VerifyGroupSeparator(System.String, System.String)
		/// </summary>
		protected static RMethod r_MVerifyGroupSeparator_String_String;
		public static RMethod RMVerifyGroupSeparator_String_String
		{
			get
			{
				if(r_MVerifyGroupSeparator_String_String == null)
				{
					r_MVerifyGroupSeparator_String_String = new(typeof(System.Globalization.NumberFormatInfo), "VerifyGroupSeparator", 0, typeof(System.String), typeof(System.String));
				}
				return r_MVerifyGroupSeparator_String_String;
			}
		}

		/// <summary>
		/// Void VerifyNativeDigits(System.String[], System.String)
		/// </summary>
		protected static RMethod r_MVerifyNativeDigits_StringArray_String;
		public static RMethod RMVerifyNativeDigits_StringArray_String
		{
			get
			{
				if(r_MVerifyNativeDigits_StringArray_String == null)
				{
					r_MVerifyNativeDigits_StringArray_String = new(typeof(System.Globalization.NumberFormatInfo), "VerifyNativeDigits", 0, typeof(System.String).MakeArrayType(), typeof(System.String));
				}
				return r_MVerifyNativeDigits_StringArray_String;
			}
		}

		/// <summary>
		/// Void VerifyDigitSubstitution(System.Globalization.DigitShapes, System.String)
		/// </summary>
		protected static RMethod r_MVerifyDigitSubstitution_DigitShapes_String;
		public static RMethod RMVerifyDigitSubstitution_DigitShapes_String
		{
			get
			{
				if(r_MVerifyDigitSubstitution_DigitShapes_String == null)
				{
					r_MVerifyDigitSubstitution_DigitShapes_String = new(typeof(System.Globalization.NumberFormatInfo), "VerifyDigitSubstitution", 0, typeof(System.Globalization.DigitShapes), typeof(System.String));
				}
				return r_MVerifyDigitSubstitution_DigitShapes_String;
			}
		}

		/// <summary>
		/// Void VerifyWritable()
		/// </summary>
		protected RMethod r_MVerifyWritable;
		public virtual RMethod RMVerifyWritable
		{
			get
			{
				if(r_MVerifyWritable == null)
				{
					r_MVerifyWritable = new(this, "VerifyWritable", 0);
				}
				return r_MVerifyWritable;
			}
		}

		/// <summary>
		/// System.Globalization.NumberFormatInfo GetInstance(System.IFormatProvider)
		/// </summary>
		protected static RMethod r_MGetInstance_IFormatProvider;
		public static RMethod RMGetInstance_IFormatProvider
		{
			get
			{
				if(r_MGetInstance_IFormatProvider == null)
				{
					r_MGetInstance_IFormatProvider = new(typeof(System.Globalization.NumberFormatInfo), "GetInstance", 0, typeof(System.IFormatProvider));
				}
				return r_MGetInstance_IFormatProvider;
			}
		}

		/// <summary>
		/// System.Object Clone()
		/// </summary>
		protected RMethod r_MClone;
		public virtual RMethod RMClone
		{
			get
			{
				if(r_MClone == null)
				{
					r_MClone = new(this, "Clone", 0);
				}
				return r_MClone;
			}
		}

		/// <summary>
		/// Void CheckGroupSize(System.String, Int32[])
		/// </summary>
		protected static RMethod r_MCheckGroupSize_String_Int32Array;
		public static RMethod RMCheckGroupSize_String_Int32Array
		{
			get
			{
				if(r_MCheckGroupSize_String_Int32Array == null)
				{
					r_MCheckGroupSize_String_Int32Array = new(typeof(System.Globalization.NumberFormatInfo), "CheckGroupSize", 0, typeof(System.String), typeof(System.Int32).MakeArrayType());
				}
				return r_MCheckGroupSize_String_Int32Array;
			}
		}

		/// <summary>
		/// System.Object GetFormat(System.Type)
		/// </summary>
		protected RMethod r_MGetFormat_Type;
		public virtual RMethod RMGetFormat_Type
		{
			get
			{
				if(r_MGetFormat_Type == null)
				{
					r_MGetFormat_Type = new(this, "GetFormat", 0, typeof(System.Type));
				}
				return r_MGetFormat_Type;
			}
		}

		/// <summary>
		/// System.Globalization.NumberFormatInfo ReadOnly(System.Globalization.NumberFormatInfo)
		/// </summary>
		protected static RMethod r_MReadOnly_NumberFormatInfo;
		public static RMethod RMReadOnly_NumberFormatInfo
		{
			get
			{
				if(r_MReadOnly_NumberFormatInfo == null)
				{
					r_MReadOnly_NumberFormatInfo = new(typeof(System.Globalization.NumberFormatInfo), "ReadOnly", 0, typeof(System.Globalization.NumberFormatInfo));
				}
				return r_MReadOnly_NumberFormatInfo;
			}
		}

		/// <summary>
		/// Void ValidateParseStyleInteger(System.Globalization.NumberStyles)
		/// </summary>
		protected static RMethod r_MValidateParseStyleInteger_NumberStyles;
		public static RMethod RMValidateParseStyleInteger_NumberStyles
		{
			get
			{
				if(r_MValidateParseStyleInteger_NumberStyles == null)
				{
					r_MValidateParseStyleInteger_NumberStyles = new(typeof(System.Globalization.NumberFormatInfo), "ValidateParseStyleInteger", 0, typeof(System.Globalization.NumberStyles));
				}
				return r_MValidateParseStyleInteger_NumberStyles;
			}
		}

		/// <summary>
		/// Void ValidateParseStyleFloatingPoint(System.Globalization.NumberStyles)
		/// </summary>
		protected static RMethod r_MValidateParseStyleFloatingPoint_NumberStyles;
		public static RMethod RMValidateParseStyleFloatingPoint_NumberStyles
		{
			get
			{
				if(r_MValidateParseStyleFloatingPoint_NumberStyles == null)
				{
					r_MValidateParseStyleFloatingPoint_NumberStyles = new(typeof(System.Globalization.NumberFormatInfo), "ValidateParseStyleFloatingPoint", 0, typeof(System.Globalization.NumberStyles));
				}
				return r_MValidateParseStyleFloatingPoint_NumberStyles;
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


        public virtual void OnSerializing(System.Runtime.Serialization.StreamingContext @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx};
            var ___result = RMOnSerializing_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDeserializing(System.Runtime.Serialization.StreamingContext @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx};
            var ___result = RMOnDeserializing_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDeserialized(System.Runtime.Serialization.StreamingContext @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx};
            var ___result = RMOnDeserialized_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public static void VerifyDecimalSeparator(System.String @decSep, System.String @propertyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@decSep, @propertyName};
            var ___result = RMVerifyDecimalSeparator_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public static void VerifyGroupSeparator(System.String @groupSep, System.String @propertyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@groupSep, @propertyName};
            var ___result = RMVerifyGroupSeparator_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public static void VerifyNativeDigits(System.String[] @nativeDig, System.String @propertyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nativeDig, @propertyName};
            var ___result = RMVerifyNativeDigits_StringArray_String.Invoke(___genericsType, ___parameters);

            
        }


        public static void VerifyDigitSubstitution(System.Globalization.DigitShapes @digitSub, System.String @propertyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@digitSub, @propertyName};
            var ___result = RMVerifyDigitSubstitution_DigitShapes_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void VerifyWritable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMVerifyWritable.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Globalization.NumberFormatInfo GetInstance(System.IFormatProvider @formatProvider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@formatProvider};
            var ___result = RMGetInstance_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Globalization.NumberFormatInfo)___result;
        }


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static void CheckGroupSize(System.String @propName, System.Int32[] @groupSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propName, @groupSize};
            var ___result = RMCheckGroupSize_String_Int32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetFormat(System.Type @formatType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@formatType};
            var ___result = RMGetFormat_Type.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Globalization.NumberFormatInfo ReadOnly(System.Globalization.NumberFormatInfo @nfi)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nfi};
            var ___result = RMReadOnly_NumberFormatInfo.Invoke(___genericsType, ___parameters);

            return (System.Globalization.NumberFormatInfo)___result;
        }


        public static void ValidateParseStyleInteger(System.Globalization.NumberStyles @style)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style};
            var ___result = RMValidateParseStyleInteger_NumberStyles.Invoke(___genericsType, ___parameters);

            
        }


        public static void ValidateParseStyleFloatingPoint(System.Globalization.NumberStyles @style)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style};
            var ___result = RMValidateParseStyleFloatingPoint_NumberStyles.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
