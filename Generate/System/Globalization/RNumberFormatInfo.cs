using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RGlobalization
{
	/// <summary>
	/// System.Globalization.NumberFormatInfo
	/// </summary>
    public partial class RNumberFormatInfo : RMember //
    {

		/// <summary>
		/// System.Globalization.NumberFormatInfo invariantInfo
		/// </summary>
		protected static RSystem.RGlobalization.RNumberFormatInfo r_invariantInfo;
		public static RSystem.RGlobalization.RNumberFormatInfo RinvariantInfo
		{
			get
			{
				if(r_invariantInfo == null)
				{
					r_invariantInfo = new(typeof(System.Globalization.NumberFormatInfo), "invariantInfo");
					r_invariantInfo.SetBelong(null);
				}
				return r_invariantInfo;
			}
		}

		/// <summary>
		/// System.Int32[] numberGroupSizes
		/// </summary>
		protected RFieldArray<RSystem.RInt32> r_numberGroupSizes;
		public virtual RFieldArray<RSystem.RInt32> RnumberGroupSizes
		{
			get
			{
				if(r_numberGroupSizes == null)
				{
					r_numberGroupSizes = new(this, "numberGroupSizes");
					r_numberGroupSizes.SetBelong(this.instance);
				}
				return r_numberGroupSizes;
			}
		}

		/// <summary>
		/// System.Int32[] currencyGroupSizes
		/// </summary>
		protected RFieldArray<RSystem.RInt32> r_currencyGroupSizes;
		public virtual RFieldArray<RSystem.RInt32> RcurrencyGroupSizes
		{
			get
			{
				if(r_currencyGroupSizes == null)
				{
					r_currencyGroupSizes = new(this, "currencyGroupSizes");
					r_currencyGroupSizes.SetBelong(this.instance);
				}
				return r_currencyGroupSizes;
			}
		}

		/// <summary>
		/// System.Int32[] percentGroupSizes
		/// </summary>
		protected RFieldArray<RSystem.RInt32> r_percentGroupSizes;
		public virtual RFieldArray<RSystem.RInt32> RpercentGroupSizes
		{
			get
			{
				if(r_percentGroupSizes == null)
				{
					r_percentGroupSizes = new(this, "percentGroupSizes");
					r_percentGroupSizes.SetBelong(this.instance);
				}
				return r_percentGroupSizes;
			}
		}

		/// <summary>
		/// System.String positiveSign
		/// </summary>
		protected RSystem.RString r_positiveSign;
		public virtual RSystem.RString RpositiveSign
		{
			get
			{
				if(r_positiveSign == null)
				{
					r_positiveSign = new(this, "positiveSign");
					r_positiveSign.SetBelong(this.instance);
				}
				return r_positiveSign;
			}
		}

		/// <summary>
		/// System.String negativeSign
		/// </summary>
		protected RSystem.RString r_negativeSign;
		public virtual RSystem.RString RnegativeSign
		{
			get
			{
				if(r_negativeSign == null)
				{
					r_negativeSign = new(this, "negativeSign");
					r_negativeSign.SetBelong(this.instance);
				}
				return r_negativeSign;
			}
		}

		/// <summary>
		/// System.String numberDecimalSeparator
		/// </summary>
		protected RSystem.RString r_numberDecimalSeparator;
		public virtual RSystem.RString RnumberDecimalSeparator
		{
			get
			{
				if(r_numberDecimalSeparator == null)
				{
					r_numberDecimalSeparator = new(this, "numberDecimalSeparator");
					r_numberDecimalSeparator.SetBelong(this.instance);
				}
				return r_numberDecimalSeparator;
			}
		}

		/// <summary>
		/// System.String numberGroupSeparator
		/// </summary>
		protected RSystem.RString r_numberGroupSeparator;
		public virtual RSystem.RString RnumberGroupSeparator
		{
			get
			{
				if(r_numberGroupSeparator == null)
				{
					r_numberGroupSeparator = new(this, "numberGroupSeparator");
					r_numberGroupSeparator.SetBelong(this.instance);
				}
				return r_numberGroupSeparator;
			}
		}

		/// <summary>
		/// System.String currencyGroupSeparator
		/// </summary>
		protected RSystem.RString r_currencyGroupSeparator;
		public virtual RSystem.RString RcurrencyGroupSeparator
		{
			get
			{
				if(r_currencyGroupSeparator == null)
				{
					r_currencyGroupSeparator = new(this, "currencyGroupSeparator");
					r_currencyGroupSeparator.SetBelong(this.instance);
				}
				return r_currencyGroupSeparator;
			}
		}

		/// <summary>
		/// System.String currencyDecimalSeparator
		/// </summary>
		protected RSystem.RString r_currencyDecimalSeparator;
		public virtual RSystem.RString RcurrencyDecimalSeparator
		{
			get
			{
				if(r_currencyDecimalSeparator == null)
				{
					r_currencyDecimalSeparator = new(this, "currencyDecimalSeparator");
					r_currencyDecimalSeparator.SetBelong(this.instance);
				}
				return r_currencyDecimalSeparator;
			}
		}

		/// <summary>
		/// System.String currencySymbol
		/// </summary>
		protected RSystem.RString r_currencySymbol;
		public virtual RSystem.RString RcurrencySymbol
		{
			get
			{
				if(r_currencySymbol == null)
				{
					r_currencySymbol = new(this, "currencySymbol");
					r_currencySymbol.SetBelong(this.instance);
				}
				return r_currencySymbol;
			}
		}

		/// <summary>
		/// System.String ansiCurrencySymbol
		/// </summary>
		protected RSystem.RString r_ansiCurrencySymbol;
		public virtual RSystem.RString RansiCurrencySymbol
		{
			get
			{
				if(r_ansiCurrencySymbol == null)
				{
					r_ansiCurrencySymbol = new(this, "ansiCurrencySymbol");
					r_ansiCurrencySymbol.SetBelong(this.instance);
				}
				return r_ansiCurrencySymbol;
			}
		}

		/// <summary>
		/// System.String nanSymbol
		/// </summary>
		protected RSystem.RString r_nanSymbol;
		public virtual RSystem.RString RnanSymbol
		{
			get
			{
				if(r_nanSymbol == null)
				{
					r_nanSymbol = new(this, "nanSymbol");
					r_nanSymbol.SetBelong(this.instance);
				}
				return r_nanSymbol;
			}
		}

		/// <summary>
		/// System.String positiveInfinitySymbol
		/// </summary>
		protected RSystem.RString r_positiveInfinitySymbol;
		public virtual RSystem.RString RpositiveInfinitySymbol
		{
			get
			{
				if(r_positiveInfinitySymbol == null)
				{
					r_positiveInfinitySymbol = new(this, "positiveInfinitySymbol");
					r_positiveInfinitySymbol.SetBelong(this.instance);
				}
				return r_positiveInfinitySymbol;
			}
		}

		/// <summary>
		/// System.String negativeInfinitySymbol
		/// </summary>
		protected RSystem.RString r_negativeInfinitySymbol;
		public virtual RSystem.RString RnegativeInfinitySymbol
		{
			get
			{
				if(r_negativeInfinitySymbol == null)
				{
					r_negativeInfinitySymbol = new(this, "negativeInfinitySymbol");
					r_negativeInfinitySymbol.SetBelong(this.instance);
				}
				return r_negativeInfinitySymbol;
			}
		}

		/// <summary>
		/// System.String percentDecimalSeparator
		/// </summary>
		protected RSystem.RString r_percentDecimalSeparator;
		public virtual RSystem.RString RpercentDecimalSeparator
		{
			get
			{
				if(r_percentDecimalSeparator == null)
				{
					r_percentDecimalSeparator = new(this, "percentDecimalSeparator");
					r_percentDecimalSeparator.SetBelong(this.instance);
				}
				return r_percentDecimalSeparator;
			}
		}

		/// <summary>
		/// System.String percentGroupSeparator
		/// </summary>
		protected RSystem.RString r_percentGroupSeparator;
		public virtual RSystem.RString RpercentGroupSeparator
		{
			get
			{
				if(r_percentGroupSeparator == null)
				{
					r_percentGroupSeparator = new(this, "percentGroupSeparator");
					r_percentGroupSeparator.SetBelong(this.instance);
				}
				return r_percentGroupSeparator;
			}
		}

		/// <summary>
		/// System.String percentSymbol
		/// </summary>
		protected RSystem.RString r_percentSymbol;
		public virtual RSystem.RString RpercentSymbol
		{
			get
			{
				if(r_percentSymbol == null)
				{
					r_percentSymbol = new(this, "percentSymbol");
					r_percentSymbol.SetBelong(this.instance);
				}
				return r_percentSymbol;
			}
		}

		/// <summary>
		/// System.String perMilleSymbol
		/// </summary>
		protected RSystem.RString r_perMilleSymbol;
		public virtual RSystem.RString RperMilleSymbol
		{
			get
			{
				if(r_perMilleSymbol == null)
				{
					r_perMilleSymbol = new(this, "perMilleSymbol");
					r_perMilleSymbol.SetBelong(this.instance);
				}
				return r_perMilleSymbol;
			}
		}

		/// <summary>
		/// System.String[] nativeDigits
		/// </summary>
		protected RFieldArray<RSystem.RString> r_nativeDigits;
		public virtual RFieldArray<RSystem.RString> RnativeDigits
		{
			get
			{
				if(r_nativeDigits == null)
				{
					r_nativeDigits = new(this, "nativeDigits");
					r_nativeDigits.SetBelong(this.instance);
				}
				return r_nativeDigits;
			}
		}

		/// <summary>
		/// System.Int32 m_dataItem
		/// </summary>
		protected RSystem.RInt32 r_m_dataItem;
		public virtual RSystem.RInt32 Rm_dataItem
		{
			get
			{
				if(r_m_dataItem == null)
				{
					r_m_dataItem = new(this, "m_dataItem");
					r_m_dataItem.SetBelong(this.instance);
				}
				return r_m_dataItem;
			}
		}

		/// <summary>
		/// System.Int32 numberDecimalDigits
		/// </summary>
		protected RSystem.RInt32 r_numberDecimalDigits;
		public virtual RSystem.RInt32 RnumberDecimalDigits
		{
			get
			{
				if(r_numberDecimalDigits == null)
				{
					r_numberDecimalDigits = new(this, "numberDecimalDigits");
					r_numberDecimalDigits.SetBelong(this.instance);
				}
				return r_numberDecimalDigits;
			}
		}

		/// <summary>
		/// System.Int32 currencyDecimalDigits
		/// </summary>
		protected RSystem.RInt32 r_currencyDecimalDigits;
		public virtual RSystem.RInt32 RcurrencyDecimalDigits
		{
			get
			{
				if(r_currencyDecimalDigits == null)
				{
					r_currencyDecimalDigits = new(this, "currencyDecimalDigits");
					r_currencyDecimalDigits.SetBelong(this.instance);
				}
				return r_currencyDecimalDigits;
			}
		}

		/// <summary>
		/// System.Int32 currencyPositivePattern
		/// </summary>
		protected RSystem.RInt32 r_currencyPositivePattern;
		public virtual RSystem.RInt32 RcurrencyPositivePattern
		{
			get
			{
				if(r_currencyPositivePattern == null)
				{
					r_currencyPositivePattern = new(this, "currencyPositivePattern");
					r_currencyPositivePattern.SetBelong(this.instance);
				}
				return r_currencyPositivePattern;
			}
		}

		/// <summary>
		/// System.Int32 currencyNegativePattern
		/// </summary>
		protected RSystem.RInt32 r_currencyNegativePattern;
		public virtual RSystem.RInt32 RcurrencyNegativePattern
		{
			get
			{
				if(r_currencyNegativePattern == null)
				{
					r_currencyNegativePattern = new(this, "currencyNegativePattern");
					r_currencyNegativePattern.SetBelong(this.instance);
				}
				return r_currencyNegativePattern;
			}
		}

		/// <summary>
		/// System.Int32 numberNegativePattern
		/// </summary>
		protected RSystem.RInt32 r_numberNegativePattern;
		public virtual RSystem.RInt32 RnumberNegativePattern
		{
			get
			{
				if(r_numberNegativePattern == null)
				{
					r_numberNegativePattern = new(this, "numberNegativePattern");
					r_numberNegativePattern.SetBelong(this.instance);
				}
				return r_numberNegativePattern;
			}
		}

		/// <summary>
		/// System.Int32 percentPositivePattern
		/// </summary>
		protected RSystem.RInt32 r_percentPositivePattern;
		public virtual RSystem.RInt32 RpercentPositivePattern
		{
			get
			{
				if(r_percentPositivePattern == null)
				{
					r_percentPositivePattern = new(this, "percentPositivePattern");
					r_percentPositivePattern.SetBelong(this.instance);
				}
				return r_percentPositivePattern;
			}
		}

		/// <summary>
		/// System.Int32 percentNegativePattern
		/// </summary>
		protected RSystem.RInt32 r_percentNegativePattern;
		public virtual RSystem.RInt32 RpercentNegativePattern
		{
			get
			{
				if(r_percentNegativePattern == null)
				{
					r_percentNegativePattern = new(this, "percentNegativePattern");
					r_percentNegativePattern.SetBelong(this.instance);
				}
				return r_percentNegativePattern;
			}
		}

		/// <summary>
		/// System.Int32 percentDecimalDigits
		/// </summary>
		protected RSystem.RInt32 r_percentDecimalDigits;
		public virtual RSystem.RInt32 RpercentDecimalDigits
		{
			get
			{
				if(r_percentDecimalDigits == null)
				{
					r_percentDecimalDigits = new(this, "percentDecimalDigits");
					r_percentDecimalDigits.SetBelong(this.instance);
				}
				return r_percentDecimalDigits;
			}
		}

		/// <summary>
		/// System.Int32 digitSubstitution
		/// </summary>
		protected RSystem.RInt32 r_digitSubstitution;
		public virtual RSystem.RInt32 RdigitSubstitution
		{
			get
			{
				if(r_digitSubstitution == null)
				{
					r_digitSubstitution = new(this, "digitSubstitution");
					r_digitSubstitution.SetBelong(this.instance);
				}
				return r_digitSubstitution;
			}
		}

		/// <summary>
		/// System.Boolean isReadOnly
		/// </summary>
		protected RSystem.RBoolean r_isReadOnly;
		public virtual RSystem.RBoolean RisReadOnly
		{
			get
			{
				if(r_isReadOnly == null)
				{
					r_isReadOnly = new(this, "isReadOnly");
					r_isReadOnly.SetBelong(this.instance);
				}
				return r_isReadOnly;
			}
		}

		/// <summary>
		/// System.Boolean m_useUserOverride
		/// </summary>
		protected RSystem.RBoolean r_m_useUserOverride;
		public virtual RSystem.RBoolean Rm_useUserOverride
		{
			get
			{
				if(r_m_useUserOverride == null)
				{
					r_m_useUserOverride = new(this, "m_useUserOverride");
					r_m_useUserOverride.SetBelong(this.instance);
				}
				return r_m_useUserOverride;
			}
		}

		/// <summary>
		/// System.Boolean m_isInvariant
		/// </summary>
		protected RSystem.RBoolean r_m_isInvariant;
		public virtual RSystem.RBoolean Rm_isInvariant
		{
			get
			{
				if(r_m_isInvariant == null)
				{
					r_m_isInvariant = new(this, "m_isInvariant");
					r_m_isInvariant.SetBelong(this.instance);
				}
				return r_m_isInvariant;
			}
		}

		/// <summary>
		/// System.Boolean validForParseAsNumber
		/// </summary>
		protected RSystem.RBoolean r_validForParseAsNumber;
		public virtual RSystem.RBoolean RvalidForParseAsNumber
		{
			get
			{
				if(r_validForParseAsNumber == null)
				{
					r_validForParseAsNumber = new(this, "validForParseAsNumber");
					r_validForParseAsNumber.SetBelong(this.instance);
				}
				return r_validForParseAsNumber;
			}
		}

		/// <summary>
		/// System.Boolean validForParseAsCurrency
		/// </summary>
		protected RSystem.RBoolean r_validForParseAsCurrency;
		public virtual RSystem.RBoolean RvalidForParseAsCurrency
		{
			get
			{
				if(r_validForParseAsCurrency == null)
				{
					r_validForParseAsCurrency = new(this, "validForParseAsCurrency");
					r_validForParseAsCurrency.SetBelong(this.instance);
				}
				return r_validForParseAsCurrency;
			}
		}

		/// <summary>
		/// System.Globalization.NumberStyles InvalidNumberStyles
		/// </summary>
		protected static RField r_InvalidNumberStyles;
		public static RField RInvalidNumberStyles
		{
			get
			{
				if(r_InvalidNumberStyles == null)
				{
					r_InvalidNumberStyles = new(typeof(System.Globalization.NumberFormatInfo), "InvalidNumberStyles");
					r_InvalidNumberStyles.SetBelong(null);
				}
				return r_InvalidNumberStyles;
			}
		}

		/// <summary>
		/// System.Globalization.NumberFormatInfo InvariantInfo
		/// </summary>
		protected static RSystem.RGlobalization.RNumberFormatInfo r_InvariantInfo;
		public static RSystem.RGlobalization.RNumberFormatInfo RInvariantInfo
		{
			get
			{
				if(r_InvariantInfo == null)
				{
					r_InvariantInfo = new(typeof(System.Globalization.NumberFormatInfo), "InvariantInfo", -1);
					r_InvariantInfo.SetBelong(null);
				}
				return r_InvariantInfo;
			}
		}

		/// <summary>
		/// Int32 CurrencyDecimalDigits
		/// </summary>
		protected RSystem.RInt32 r_CurrencyDecimalDigits;
		public virtual RSystem.RInt32 RCurrencyDecimalDigits
		{
			get
			{
				if(r_CurrencyDecimalDigits == null)
				{
					r_CurrencyDecimalDigits = new(this, "CurrencyDecimalDigits", -1);
					r_CurrencyDecimalDigits.SetBelong(this.instance);
				}
				return r_CurrencyDecimalDigits;
			}
		}

		/// <summary>
		/// System.String CurrencyDecimalSeparator
		/// </summary>
		protected RSystem.RString r_CurrencyDecimalSeparator;
		public virtual RSystem.RString RCurrencyDecimalSeparator
		{
			get
			{
				if(r_CurrencyDecimalSeparator == null)
				{
					r_CurrencyDecimalSeparator = new(this, "CurrencyDecimalSeparator", -1);
					r_CurrencyDecimalSeparator.SetBelong(this.instance);
				}
				return r_CurrencyDecimalSeparator;
			}
		}

		/// <summary>
		/// Boolean IsReadOnly
		/// </summary>
		protected RSystem.RBoolean r_IsReadOnly;
		public virtual RSystem.RBoolean RIsReadOnly
		{
			get
			{
				if(r_IsReadOnly == null)
				{
					r_IsReadOnly = new(this, "IsReadOnly", -1);
					r_IsReadOnly.SetBelong(this.instance);
				}
				return r_IsReadOnly;
			}
		}

		/// <summary>
		/// Int32[] CurrencyGroupSizes
		/// </summary>
		protected RPropertyArray<RSystem.RInt32> r_CurrencyGroupSizes;
		public virtual RPropertyArray<RSystem.RInt32> RCurrencyGroupSizes
		{
			get
			{
				if(r_CurrencyGroupSizes == null)
				{
					r_CurrencyGroupSizes = new(this, "CurrencyGroupSizes", -1);
					r_CurrencyGroupSizes.SetBelong(this.instance);
				}
				return r_CurrencyGroupSizes;
			}
		}

		/// <summary>
		/// Int32[] NumberGroupSizes
		/// </summary>
		protected RPropertyArray<RSystem.RInt32> r_NumberGroupSizes;
		public virtual RPropertyArray<RSystem.RInt32> RNumberGroupSizes
		{
			get
			{
				if(r_NumberGroupSizes == null)
				{
					r_NumberGroupSizes = new(this, "NumberGroupSizes", -1);
					r_NumberGroupSizes.SetBelong(this.instance);
				}
				return r_NumberGroupSizes;
			}
		}

		/// <summary>
		/// Int32[] PercentGroupSizes
		/// </summary>
		protected RPropertyArray<RSystem.RInt32> r_PercentGroupSizes;
		public virtual RPropertyArray<RSystem.RInt32> RPercentGroupSizes
		{
			get
			{
				if(r_PercentGroupSizes == null)
				{
					r_PercentGroupSizes = new(this, "PercentGroupSizes", -1);
					r_PercentGroupSizes.SetBelong(this.instance);
				}
				return r_PercentGroupSizes;
			}
		}

		/// <summary>
		/// System.String CurrencyGroupSeparator
		/// </summary>
		protected RSystem.RString r_CurrencyGroupSeparator;
		public virtual RSystem.RString RCurrencyGroupSeparator
		{
			get
			{
				if(r_CurrencyGroupSeparator == null)
				{
					r_CurrencyGroupSeparator = new(this, "CurrencyGroupSeparator", -1);
					r_CurrencyGroupSeparator.SetBelong(this.instance);
				}
				return r_CurrencyGroupSeparator;
			}
		}

		/// <summary>
		/// System.String CurrencySymbol
		/// </summary>
		protected RSystem.RString r_CurrencySymbol;
		public virtual RSystem.RString RCurrencySymbol
		{
			get
			{
				if(r_CurrencySymbol == null)
				{
					r_CurrencySymbol = new(this, "CurrencySymbol", -1);
					r_CurrencySymbol.SetBelong(this.instance);
				}
				return r_CurrencySymbol;
			}
		}

		/// <summary>
		/// System.Globalization.NumberFormatInfo CurrentInfo
		/// </summary>
		protected static RSystem.RGlobalization.RNumberFormatInfo r_CurrentInfo;
		public static RSystem.RGlobalization.RNumberFormatInfo RCurrentInfo
		{
			get
			{
				if(r_CurrentInfo == null)
				{
					r_CurrentInfo = new(typeof(System.Globalization.NumberFormatInfo), "CurrentInfo", -1);
					r_CurrentInfo.SetBelong(null);
				}
				return r_CurrentInfo;
			}
		}

		/// <summary>
		/// System.String NaNSymbol
		/// </summary>
		protected RSystem.RString r_NaNSymbol;
		public virtual RSystem.RString RNaNSymbol
		{
			get
			{
				if(r_NaNSymbol == null)
				{
					r_NaNSymbol = new(this, "NaNSymbol", -1);
					r_NaNSymbol.SetBelong(this.instance);
				}
				return r_NaNSymbol;
			}
		}

		/// <summary>
		/// Int32 CurrencyNegativePattern
		/// </summary>
		protected RSystem.RInt32 r_CurrencyNegativePattern;
		public virtual RSystem.RInt32 RCurrencyNegativePattern
		{
			get
			{
				if(r_CurrencyNegativePattern == null)
				{
					r_CurrencyNegativePattern = new(this, "CurrencyNegativePattern", -1);
					r_CurrencyNegativePattern.SetBelong(this.instance);
				}
				return r_CurrencyNegativePattern;
			}
		}

		/// <summary>
		/// Int32 NumberNegativePattern
		/// </summary>
		protected RSystem.RInt32 r_NumberNegativePattern;
		public virtual RSystem.RInt32 RNumberNegativePattern
		{
			get
			{
				if(r_NumberNegativePattern == null)
				{
					r_NumberNegativePattern = new(this, "NumberNegativePattern", -1);
					r_NumberNegativePattern.SetBelong(this.instance);
				}
				return r_NumberNegativePattern;
			}
		}

		/// <summary>
		/// Int32 PercentPositivePattern
		/// </summary>
		protected RSystem.RInt32 r_PercentPositivePattern;
		public virtual RSystem.RInt32 RPercentPositivePattern
		{
			get
			{
				if(r_PercentPositivePattern == null)
				{
					r_PercentPositivePattern = new(this, "PercentPositivePattern", -1);
					r_PercentPositivePattern.SetBelong(this.instance);
				}
				return r_PercentPositivePattern;
			}
		}

		/// <summary>
		/// Int32 PercentNegativePattern
		/// </summary>
		protected RSystem.RInt32 r_PercentNegativePattern;
		public virtual RSystem.RInt32 RPercentNegativePattern
		{
			get
			{
				if(r_PercentNegativePattern == null)
				{
					r_PercentNegativePattern = new(this, "PercentNegativePattern", -1);
					r_PercentNegativePattern.SetBelong(this.instance);
				}
				return r_PercentNegativePattern;
			}
		}

		/// <summary>
		/// System.String NegativeInfinitySymbol
		/// </summary>
		protected RSystem.RString r_NegativeInfinitySymbol;
		public virtual RSystem.RString RNegativeInfinitySymbol
		{
			get
			{
				if(r_NegativeInfinitySymbol == null)
				{
					r_NegativeInfinitySymbol = new(this, "NegativeInfinitySymbol", -1);
					r_NegativeInfinitySymbol.SetBelong(this.instance);
				}
				return r_NegativeInfinitySymbol;
			}
		}

		/// <summary>
		/// System.String NegativeSign
		/// </summary>
		protected RSystem.RString r_NegativeSign;
		public virtual RSystem.RString RNegativeSign
		{
			get
			{
				if(r_NegativeSign == null)
				{
					r_NegativeSign = new(this, "NegativeSign", -1);
					r_NegativeSign.SetBelong(this.instance);
				}
				return r_NegativeSign;
			}
		}

		/// <summary>
		/// Int32 NumberDecimalDigits
		/// </summary>
		protected RSystem.RInt32 r_NumberDecimalDigits;
		public virtual RSystem.RInt32 RNumberDecimalDigits
		{
			get
			{
				if(r_NumberDecimalDigits == null)
				{
					r_NumberDecimalDigits = new(this, "NumberDecimalDigits", -1);
					r_NumberDecimalDigits.SetBelong(this.instance);
				}
				return r_NumberDecimalDigits;
			}
		}

		/// <summary>
		/// System.String NumberDecimalSeparator
		/// </summary>
		protected RSystem.RString r_NumberDecimalSeparator;
		public virtual RSystem.RString RNumberDecimalSeparator
		{
			get
			{
				if(r_NumberDecimalSeparator == null)
				{
					r_NumberDecimalSeparator = new(this, "NumberDecimalSeparator", -1);
					r_NumberDecimalSeparator.SetBelong(this.instance);
				}
				return r_NumberDecimalSeparator;
			}
		}

		/// <summary>
		/// System.String NumberGroupSeparator
		/// </summary>
		protected RSystem.RString r_NumberGroupSeparator;
		public virtual RSystem.RString RNumberGroupSeparator
		{
			get
			{
				if(r_NumberGroupSeparator == null)
				{
					r_NumberGroupSeparator = new(this, "NumberGroupSeparator", -1);
					r_NumberGroupSeparator.SetBelong(this.instance);
				}
				return r_NumberGroupSeparator;
			}
		}

		/// <summary>
		/// Int32 CurrencyPositivePattern
		/// </summary>
		protected RSystem.RInt32 r_CurrencyPositivePattern;
		public virtual RSystem.RInt32 RCurrencyPositivePattern
		{
			get
			{
				if(r_CurrencyPositivePattern == null)
				{
					r_CurrencyPositivePattern = new(this, "CurrencyPositivePattern", -1);
					r_CurrencyPositivePattern.SetBelong(this.instance);
				}
				return r_CurrencyPositivePattern;
			}
		}

		/// <summary>
		/// System.String PositiveInfinitySymbol
		/// </summary>
		protected RSystem.RString r_PositiveInfinitySymbol;
		public virtual RSystem.RString RPositiveInfinitySymbol
		{
			get
			{
				if(r_PositiveInfinitySymbol == null)
				{
					r_PositiveInfinitySymbol = new(this, "PositiveInfinitySymbol", -1);
					r_PositiveInfinitySymbol.SetBelong(this.instance);
				}
				return r_PositiveInfinitySymbol;
			}
		}

		/// <summary>
		/// System.String PositiveSign
		/// </summary>
		protected RSystem.RString r_PositiveSign;
		public virtual RSystem.RString RPositiveSign
		{
			get
			{
				if(r_PositiveSign == null)
				{
					r_PositiveSign = new(this, "PositiveSign", -1);
					r_PositiveSign.SetBelong(this.instance);
				}
				return r_PositiveSign;
			}
		}

		/// <summary>
		/// Int32 PercentDecimalDigits
		/// </summary>
		protected RSystem.RInt32 r_PercentDecimalDigits;
		public virtual RSystem.RInt32 RPercentDecimalDigits
		{
			get
			{
				if(r_PercentDecimalDigits == null)
				{
					r_PercentDecimalDigits = new(this, "PercentDecimalDigits", -1);
					r_PercentDecimalDigits.SetBelong(this.instance);
				}
				return r_PercentDecimalDigits;
			}
		}

		/// <summary>
		/// System.String PercentDecimalSeparator
		/// </summary>
		protected RSystem.RString r_PercentDecimalSeparator;
		public virtual RSystem.RString RPercentDecimalSeparator
		{
			get
			{
				if(r_PercentDecimalSeparator == null)
				{
					r_PercentDecimalSeparator = new(this, "PercentDecimalSeparator", -1);
					r_PercentDecimalSeparator.SetBelong(this.instance);
				}
				return r_PercentDecimalSeparator;
			}
		}

		/// <summary>
		/// System.String PercentGroupSeparator
		/// </summary>
		protected RSystem.RString r_PercentGroupSeparator;
		public virtual RSystem.RString RPercentGroupSeparator
		{
			get
			{
				if(r_PercentGroupSeparator == null)
				{
					r_PercentGroupSeparator = new(this, "PercentGroupSeparator", -1);
					r_PercentGroupSeparator.SetBelong(this.instance);
				}
				return r_PercentGroupSeparator;
			}
		}

		/// <summary>
		/// System.String PercentSymbol
		/// </summary>
		protected RSystem.RString r_PercentSymbol;
		public virtual RSystem.RString RPercentSymbol
		{
			get
			{
				if(r_PercentSymbol == null)
				{
					r_PercentSymbol = new(this, "PercentSymbol", -1);
					r_PercentSymbol.SetBelong(this.instance);
				}
				return r_PercentSymbol;
			}
		}

		/// <summary>
		/// System.String PerMilleSymbol
		/// </summary>
		protected RSystem.RString r_PerMilleSymbol;
		public virtual RSystem.RString RPerMilleSymbol
		{
			get
			{
				if(r_PerMilleSymbol == null)
				{
					r_PerMilleSymbol = new(this, "PerMilleSymbol", -1);
					r_PerMilleSymbol.SetBelong(this.instance);
				}
				return r_PerMilleSymbol;
			}
		}

		/// <summary>
		/// System.String[] NativeDigits
		/// </summary>
		protected RPropertyArray<RSystem.RString> r_NativeDigits;
		public virtual RPropertyArray<RSystem.RString> RNativeDigits
		{
			get
			{
				if(r_NativeDigits == null)
				{
					r_NativeDigits = new(this, "NativeDigits", -1);
					r_NativeDigits.SetBelong(this.instance);
				}
				return r_NativeDigits;
			}
		}

		/// <summary>
		/// System.Globalization.DigitShapes DigitSubstitution
		/// </summary>
		protected RProperty r_DigitSubstitution;
		public virtual RProperty RDigitSubstitution
		{
			get
			{
				if(r_DigitSubstitution == null)
				{
					r_DigitSubstitution = new(this, "DigitSubstitution", -1);
					r_DigitSubstitution.SetBelong(this.instance);
				}
				return r_DigitSubstitution;
			}
		}

		/// <summary>
		/// Void OnSerializing(System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_OnSerializing_StreamingContext;
		public virtual RMethod ROnSerializing_StreamingContext
		{
			get
			{
				if(r_OnSerializing_StreamingContext == null)
				{
					r_OnSerializing_StreamingContext = new(this, "OnSerializing", 0, typeof(System.Runtime.Serialization.StreamingContext));
					r_OnSerializing_StreamingContext.SetBelong(this.instance);
				}
				return r_OnSerializing_StreamingContext;
			}
		}

		/// <summary>
		/// Void OnDeserializing(System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_OnDeserializing_StreamingContext;
		public virtual RMethod ROnDeserializing_StreamingContext
		{
			get
			{
				if(r_OnDeserializing_StreamingContext == null)
				{
					r_OnDeserializing_StreamingContext = new(this, "OnDeserializing", 0, typeof(System.Runtime.Serialization.StreamingContext));
					r_OnDeserializing_StreamingContext.SetBelong(this.instance);
				}
				return r_OnDeserializing_StreamingContext;
			}
		}

		/// <summary>
		/// Void OnDeserialized(System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_OnDeserialized_StreamingContext;
		public virtual RMethod ROnDeserialized_StreamingContext
		{
			get
			{
				if(r_OnDeserialized_StreamingContext == null)
				{
					r_OnDeserialized_StreamingContext = new(this, "OnDeserialized", 0, typeof(System.Runtime.Serialization.StreamingContext));
					r_OnDeserialized_StreamingContext.SetBelong(this.instance);
				}
				return r_OnDeserialized_StreamingContext;
			}
		}

		/// <summary>
		/// Void VerifyDecimalSeparator(System.String, System.String)
		/// </summary>
		protected static RMethod r_VerifyDecimalSeparator_String_String;
		public static RMethod RVerifyDecimalSeparator_String_String
		{
			get
			{
				if(r_VerifyDecimalSeparator_String_String == null)
				{
					r_VerifyDecimalSeparator_String_String = new(typeof(System.Globalization.NumberFormatInfo), "VerifyDecimalSeparator", 0, typeof(System.String), typeof(System.String));
					r_VerifyDecimalSeparator_String_String.SetBelong(null);
				}
				return r_VerifyDecimalSeparator_String_String;
			}
		}

		/// <summary>
		/// Void VerifyGroupSeparator(System.String, System.String)
		/// </summary>
		protected static RMethod r_VerifyGroupSeparator_String_String;
		public static RMethod RVerifyGroupSeparator_String_String
		{
			get
			{
				if(r_VerifyGroupSeparator_String_String == null)
				{
					r_VerifyGroupSeparator_String_String = new(typeof(System.Globalization.NumberFormatInfo), "VerifyGroupSeparator", 0, typeof(System.String), typeof(System.String));
					r_VerifyGroupSeparator_String_String.SetBelong(null);
				}
				return r_VerifyGroupSeparator_String_String;
			}
		}

		/// <summary>
		/// Void VerifyNativeDigits(System.String[], System.String)
		/// </summary>
		protected static RMethod r_VerifyNativeDigits_StringArray_String;
		public static RMethod RVerifyNativeDigits_StringArray_String
		{
			get
			{
				if(r_VerifyNativeDigits_StringArray_String == null)
				{
					r_VerifyNativeDigits_StringArray_String = new(typeof(System.Globalization.NumberFormatInfo), "VerifyNativeDigits", 0, typeof(System.String).MakeArrayType(), typeof(System.String));
					r_VerifyNativeDigits_StringArray_String.SetBelong(null);
				}
				return r_VerifyNativeDigits_StringArray_String;
			}
		}

		/// <summary>
		/// Void VerifyDigitSubstitution(System.Globalization.DigitShapes, System.String)
		/// </summary>
		protected static RMethod r_VerifyDigitSubstitution_DigitShapes_String;
		public static RMethod RVerifyDigitSubstitution_DigitShapes_String
		{
			get
			{
				if(r_VerifyDigitSubstitution_DigitShapes_String == null)
				{
					r_VerifyDigitSubstitution_DigitShapes_String = new(typeof(System.Globalization.NumberFormatInfo), "VerifyDigitSubstitution", 0, typeof(System.Globalization.DigitShapes), typeof(System.String));
					r_VerifyDigitSubstitution_DigitShapes_String.SetBelong(null);
				}
				return r_VerifyDigitSubstitution_DigitShapes_String;
			}
		}

		/// <summary>
		/// Void VerifyWritable()
		/// </summary>
		protected RMethod r_VerifyWritable;
		public virtual RMethod RVerifyWritable
		{
			get
			{
				if(r_VerifyWritable == null)
				{
					r_VerifyWritable = new(this, "VerifyWritable", 0);
					r_VerifyWritable.SetBelong(this.instance);
				}
				return r_VerifyWritable;
			}
		}

		/// <summary>
		/// System.Globalization.NumberFormatInfo GetInstance(System.IFormatProvider)
		/// </summary>
		protected static RMethod r_GetInstance_IFormatProvider;
		public static RMethod RGetInstance_IFormatProvider
		{
			get
			{
				if(r_GetInstance_IFormatProvider == null)
				{
					r_GetInstance_IFormatProvider = new(typeof(System.Globalization.NumberFormatInfo), "GetInstance", 0, typeof(System.IFormatProvider));
					r_GetInstance_IFormatProvider.SetBelong(null);
				}
				return r_GetInstance_IFormatProvider;
			}
		}

		/// <summary>
		/// System.Object Clone()
		/// </summary>
		protected RMethod r_Clone;
		public virtual RMethod RClone
		{
			get
			{
				if(r_Clone == null)
				{
					r_Clone = new(this, "Clone", 0);
					r_Clone.SetBelong(this.instance);
				}
				return r_Clone;
			}
		}

		/// <summary>
		/// Void CheckGroupSize(System.String, Int32[])
		/// </summary>
		protected static RMethod r_CheckGroupSize_String_Int32Array;
		public static RMethod RCheckGroupSize_String_Int32Array
		{
			get
			{
				if(r_CheckGroupSize_String_Int32Array == null)
				{
					r_CheckGroupSize_String_Int32Array = new(typeof(System.Globalization.NumberFormatInfo), "CheckGroupSize", 0, typeof(System.String), typeof(System.Int32).MakeArrayType());
					r_CheckGroupSize_String_Int32Array.SetBelong(null);
				}
				return r_CheckGroupSize_String_Int32Array;
			}
		}

		/// <summary>
		/// System.Object GetFormat(System.Type)
		/// </summary>
		protected RMethod r_GetFormat_Type;
		public virtual RMethod RGetFormat_Type
		{
			get
			{
				if(r_GetFormat_Type == null)
				{
					r_GetFormat_Type = new(this, "GetFormat", 0, typeof(System.Type));
					r_GetFormat_Type.SetBelong(this.instance);
				}
				return r_GetFormat_Type;
			}
		}

		/// <summary>
		/// System.Globalization.NumberFormatInfo ReadOnly(System.Globalization.NumberFormatInfo)
		/// </summary>
		protected static RMethod r_ReadOnly_NumberFormatInfo;
		public static RMethod RReadOnly_NumberFormatInfo
		{
			get
			{
				if(r_ReadOnly_NumberFormatInfo == null)
				{
					r_ReadOnly_NumberFormatInfo = new(typeof(System.Globalization.NumberFormatInfo), "ReadOnly", 0, typeof(System.Globalization.NumberFormatInfo));
					r_ReadOnly_NumberFormatInfo.SetBelong(null);
				}
				return r_ReadOnly_NumberFormatInfo;
			}
		}

		/// <summary>
		/// Void ValidateParseStyleInteger(System.Globalization.NumberStyles)
		/// </summary>
		protected static RMethod r_ValidateParseStyleInteger_NumberStyles;
		public static RMethod RValidateParseStyleInteger_NumberStyles
		{
			get
			{
				if(r_ValidateParseStyleInteger_NumberStyles == null)
				{
					r_ValidateParseStyleInteger_NumberStyles = new(typeof(System.Globalization.NumberFormatInfo), "ValidateParseStyleInteger", 0, typeof(System.Globalization.NumberStyles));
					r_ValidateParseStyleInteger_NumberStyles.SetBelong(null);
				}
				return r_ValidateParseStyleInteger_NumberStyles;
			}
		}

		/// <summary>
		/// Void ValidateParseStyleFloatingPoint(System.Globalization.NumberStyles)
		/// </summary>
		protected static RMethod r_ValidateParseStyleFloatingPoint_NumberStyles;
		public static RMethod RValidateParseStyleFloatingPoint_NumberStyles
		{
			get
			{
				if(r_ValidateParseStyleFloatingPoint_NumberStyles == null)
				{
					r_ValidateParseStyleFloatingPoint_NumberStyles = new(typeof(System.Globalization.NumberFormatInfo), "ValidateParseStyleFloatingPoint", 0, typeof(System.Globalization.NumberStyles));
					r_ValidateParseStyleFloatingPoint_NumberStyles.SetBelong(null);
				}
				return r_ValidateParseStyleFloatingPoint_NumberStyles;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_Equals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_Equals_Object == null)
				{
					r_Equals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_Equals_Object.SetBelong(this.instance);
				}
				return r_Equals_Object;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_Finalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_Finalize == null)
				{
					r_Finalize = new(this, "Finalize", 0);
					r_Finalize.SetBelong(this.instance);
				}
				return r_Finalize;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_GetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_GetHashCode == null)
				{
					r_GetHashCode = new(this, "GetHashCode", 0);
					r_GetHashCode.SetBelong(this.instance);
				}
				return r_GetHashCode;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_GetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_GetType == null)
				{
					r_GetType = new(this, "GetType", 0);
					r_GetType.SetBelong(this.instance);
				}
				return r_GetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_MemberwiseClone == null)
				{
					r_MemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MemberwiseClone.SetBelong(this.instance);
				}
				return r_MemberwiseClone;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_ToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_ToString == null)
				{
					r_ToString = new(this, "ToString", 0);
					r_ToString.SetBelong(this.instance);
				}
				return r_ToString;
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

        public virtual void OnSerializing(System.Runtime.Serialization.StreamingContext @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx};
            var ___result = ROnSerializing_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDeserializing(System.Runtime.Serialization.StreamingContext @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx};
            var ___result = ROnDeserializing_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDeserialized(System.Runtime.Serialization.StreamingContext @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx};
            var ___result = ROnDeserialized_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public static void VerifyDecimalSeparator(System.String @decSep, System.String @propertyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@decSep, @propertyName};
            var ___result = RVerifyDecimalSeparator_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public static void VerifyGroupSeparator(System.String @groupSep, System.String @propertyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@groupSep, @propertyName};
            var ___result = RVerifyGroupSeparator_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public static void VerifyNativeDigits(System.String[] @nativeDig, System.String @propertyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nativeDig, @propertyName};
            var ___result = RVerifyNativeDigits_StringArray_String.Invoke(___genericsType, ___parameters);

            
        }


        public static void VerifyDigitSubstitution(System.Globalization.DigitShapes @digitSub, System.String @propertyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@digitSub, @propertyName};
            var ___result = RVerifyDigitSubstitution_DigitShapes_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void VerifyWritable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RVerifyWritable.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Globalization.NumberFormatInfo GetInstance(System.IFormatProvider @formatProvider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@formatProvider};
            var ___result = RGetInstance_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Globalization.NumberFormatInfo)___result;
        }


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static void CheckGroupSize(System.String @propName, System.Int32[] @groupSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propName, @groupSize};
            var ___result = RCheckGroupSize_String_Int32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetFormat(System.Type @formatType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@formatType};
            var ___result = RGetFormat_Type.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Globalization.NumberFormatInfo ReadOnly(System.Globalization.NumberFormatInfo @nfi)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nfi};
            var ___result = RReadOnly_NumberFormatInfo.Invoke(___genericsType, ___parameters);

            return (System.Globalization.NumberFormatInfo)___result;
        }


        public static void ValidateParseStyleInteger(System.Globalization.NumberStyles @style)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style};
            var ___result = RValidateParseStyleInteger_NumberStyles.Invoke(___genericsType, ___parameters);

            
        }


        public static void ValidateParseStyleFloatingPoint(System.Globalization.NumberStyles @style)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style};
            var ___result = RValidateParseStyleFloatingPoint_NumberStyles.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
