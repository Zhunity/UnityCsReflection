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
		protected RFieldArray<RField> r_numberGroupSizes;
		public virtual RFieldArray<RField> RnumberGroupSizes
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
		protected RFieldArray<RField> r_currencyGroupSizes;
		public virtual RFieldArray<RField> RcurrencyGroupSizes
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
		protected RFieldArray<RField> r_percentGroupSizes;
		public virtual RFieldArray<RField> RpercentGroupSizes
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
		protected RField r_positiveSign;
		public virtual RField RpositiveSign
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
		protected RField r_negativeSign;
		public virtual RField RnegativeSign
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
		protected RField r_numberDecimalSeparator;
		public virtual RField RnumberDecimalSeparator
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
		protected RField r_numberGroupSeparator;
		public virtual RField RnumberGroupSeparator
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
		protected RField r_currencyGroupSeparator;
		public virtual RField RcurrencyGroupSeparator
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
		protected RField r_currencyDecimalSeparator;
		public virtual RField RcurrencyDecimalSeparator
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
		protected RField r_currencySymbol;
		public virtual RField RcurrencySymbol
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
		protected RField r_ansiCurrencySymbol;
		public virtual RField RansiCurrencySymbol
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
		protected RField r_nanSymbol;
		public virtual RField RnanSymbol
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
		protected RField r_positiveInfinitySymbol;
		public virtual RField RpositiveInfinitySymbol
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
		protected RField r_negativeInfinitySymbol;
		public virtual RField RnegativeInfinitySymbol
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
		protected RField r_percentDecimalSeparator;
		public virtual RField RpercentDecimalSeparator
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
		protected RField r_percentGroupSeparator;
		public virtual RField RpercentGroupSeparator
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
		protected RField r_percentSymbol;
		public virtual RField RpercentSymbol
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
		protected RField r_perMilleSymbol;
		public virtual RField RperMilleSymbol
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
		protected RFieldArray<RField> r_nativeDigits;
		public virtual RFieldArray<RField> RnativeDigits
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
		protected RField r_m_dataItem;
		public virtual RField Rm_dataItem
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
		protected RField r_numberDecimalDigits;
		public virtual RField RnumberDecimalDigits
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
		protected RField r_currencyDecimalDigits;
		public virtual RField RcurrencyDecimalDigits
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
		protected RField r_currencyPositivePattern;
		public virtual RField RcurrencyPositivePattern
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
		protected RField r_currencyNegativePattern;
		public virtual RField RcurrencyNegativePattern
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
		protected RField r_numberNegativePattern;
		public virtual RField RnumberNegativePattern
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
		protected RField r_percentPositivePattern;
		public virtual RField RpercentPositivePattern
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
		protected RField r_percentNegativePattern;
		public virtual RField RpercentNegativePattern
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
		protected RField r_percentDecimalDigits;
		public virtual RField RpercentDecimalDigits
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
		protected RField r_digitSubstitution;
		public virtual RField RdigitSubstitution
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
		protected RField r_isReadOnly;
		public virtual RField RisReadOnly
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
		protected RField r_m_useUserOverride;
		public virtual RField Rm_useUserOverride
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
		protected RField r_m_isInvariant;
		public virtual RField Rm_isInvariant
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
		protected RField r_validForParseAsNumber;
		public virtual RField RvalidForParseAsNumber
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
		protected RField r_validForParseAsCurrency;
		public virtual RField RvalidForParseAsCurrency
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
		protected RProperty r_CurrencyDecimalDigits;
		public virtual RProperty RCurrencyDecimalDigits
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
		protected RProperty r_CurrencyDecimalSeparator;
		public virtual RProperty RCurrencyDecimalSeparator
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
		protected RProperty r_IsReadOnly;
		public virtual RProperty RIsReadOnly
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
		protected RPropertyArray<RProperty> r_CurrencyGroupSizes;
		public virtual RPropertyArray<RProperty> RCurrencyGroupSizes
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
		protected RPropertyArray<RProperty> r_NumberGroupSizes;
		public virtual RPropertyArray<RProperty> RNumberGroupSizes
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
		protected RPropertyArray<RProperty> r_PercentGroupSizes;
		public virtual RPropertyArray<RProperty> RPercentGroupSizes
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
		protected RProperty r_CurrencyGroupSeparator;
		public virtual RProperty RCurrencyGroupSeparator
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
		protected RProperty r_CurrencySymbol;
		public virtual RProperty RCurrencySymbol
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
		protected RProperty r_NaNSymbol;
		public virtual RProperty RNaNSymbol
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
		protected RProperty r_CurrencyNegativePattern;
		public virtual RProperty RCurrencyNegativePattern
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
		protected RProperty r_NumberNegativePattern;
		public virtual RProperty RNumberNegativePattern
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
		protected RProperty r_PercentPositivePattern;
		public virtual RProperty RPercentPositivePattern
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
		protected RProperty r_PercentNegativePattern;
		public virtual RProperty RPercentNegativePattern
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
		protected RProperty r_NegativeInfinitySymbol;
		public virtual RProperty RNegativeInfinitySymbol
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
		protected RProperty r_NegativeSign;
		public virtual RProperty RNegativeSign
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
		protected RProperty r_NumberDecimalDigits;
		public virtual RProperty RNumberDecimalDigits
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
		protected RProperty r_NumberDecimalSeparator;
		public virtual RProperty RNumberDecimalSeparator
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
		protected RProperty r_NumberGroupSeparator;
		public virtual RProperty RNumberGroupSeparator
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
		protected RProperty r_CurrencyPositivePattern;
		public virtual RProperty RCurrencyPositivePattern
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
		protected RProperty r_PositiveInfinitySymbol;
		public virtual RProperty RPositiveInfinitySymbol
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
		protected RProperty r_PositiveSign;
		public virtual RProperty RPositiveSign
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
		protected RProperty r_PercentDecimalDigits;
		public virtual RProperty RPercentDecimalDigits
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
		protected RProperty r_PercentDecimalSeparator;
		public virtual RProperty RPercentDecimalSeparator
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
		protected RProperty r_PercentGroupSeparator;
		public virtual RProperty RPercentGroupSeparator
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
		protected RProperty r_PercentSymbol;
		public virtual RProperty RPercentSymbol
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
		protected RProperty r_PerMilleSymbol;
		public virtual RProperty RPerMilleSymbol
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
		protected RPropertyArray<RProperty> r_NativeDigits;
		public virtual RPropertyArray<RProperty> RNativeDigits
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
		protected RMethod r_ROnSerializing_StreamingContext;
		public virtual RMethod ROnSerializing_StreamingContext
		{
			get
			{
				if(r_ROnSerializing_StreamingContext == null)
				{
					r_ROnSerializing_StreamingContext = new(this, "OnSerializing", 0, typeof(System.Runtime.Serialization.StreamingContext));
					r_ROnSerializing_StreamingContext.SetBelong(this.instance);
				}
				return r_ROnSerializing_StreamingContext;
			}
		}

		/// <summary>
		/// Void OnDeserializing(System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_ROnDeserializing_StreamingContext;
		public virtual RMethod ROnDeserializing_StreamingContext
		{
			get
			{
				if(r_ROnDeserializing_StreamingContext == null)
				{
					r_ROnDeserializing_StreamingContext = new(this, "OnDeserializing", 0, typeof(System.Runtime.Serialization.StreamingContext));
					r_ROnDeserializing_StreamingContext.SetBelong(this.instance);
				}
				return r_ROnDeserializing_StreamingContext;
			}
		}

		/// <summary>
		/// Void OnDeserialized(System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_ROnDeserialized_StreamingContext;
		public virtual RMethod ROnDeserialized_StreamingContext
		{
			get
			{
				if(r_ROnDeserialized_StreamingContext == null)
				{
					r_ROnDeserialized_StreamingContext = new(this, "OnDeserialized", 0, typeof(System.Runtime.Serialization.StreamingContext));
					r_ROnDeserialized_StreamingContext.SetBelong(this.instance);
				}
				return r_ROnDeserialized_StreamingContext;
			}
		}

		/// <summary>
		/// Void VerifyDecimalSeparator(System.String, System.String)
		/// </summary>
		protected static RMethod r_RVerifyDecimalSeparator_String_String;
		public static RMethod RVerifyDecimalSeparator_String_String
		{
			get
			{
				if(r_RVerifyDecimalSeparator_String_String == null)
				{
					r_RVerifyDecimalSeparator_String_String = new(typeof(System.Globalization.NumberFormatInfo), "VerifyDecimalSeparator", 0, typeof(System.String), typeof(System.String));
					r_RVerifyDecimalSeparator_String_String.SetBelong(null);
				}
				return r_RVerifyDecimalSeparator_String_String;
			}
		}

		/// <summary>
		/// Void VerifyGroupSeparator(System.String, System.String)
		/// </summary>
		protected static RMethod r_RVerifyGroupSeparator_String_String;
		public static RMethod RVerifyGroupSeparator_String_String
		{
			get
			{
				if(r_RVerifyGroupSeparator_String_String == null)
				{
					r_RVerifyGroupSeparator_String_String = new(typeof(System.Globalization.NumberFormatInfo), "VerifyGroupSeparator", 0, typeof(System.String), typeof(System.String));
					r_RVerifyGroupSeparator_String_String.SetBelong(null);
				}
				return r_RVerifyGroupSeparator_String_String;
			}
		}

		/// <summary>
		/// Void VerifyNativeDigits(System.String[], System.String)
		/// </summary>
		protected static RMethod r_RVerifyNativeDigits_StringArray_String;
		public static RMethod RVerifyNativeDigits_StringArray_String
		{
			get
			{
				if(r_RVerifyNativeDigits_StringArray_String == null)
				{
					r_RVerifyNativeDigits_StringArray_String = new(typeof(System.Globalization.NumberFormatInfo), "VerifyNativeDigits", 0, typeof(System.String).MakeArrayType(), typeof(System.String));
					r_RVerifyNativeDigits_StringArray_String.SetBelong(null);
				}
				return r_RVerifyNativeDigits_StringArray_String;
			}
		}

		/// <summary>
		/// Void VerifyDigitSubstitution(System.Globalization.DigitShapes, System.String)
		/// </summary>
		protected static RMethod r_RVerifyDigitSubstitution_DigitShapes_String;
		public static RMethod RVerifyDigitSubstitution_DigitShapes_String
		{
			get
			{
				if(r_RVerifyDigitSubstitution_DigitShapes_String == null)
				{
					r_RVerifyDigitSubstitution_DigitShapes_String = new(typeof(System.Globalization.NumberFormatInfo), "VerifyDigitSubstitution", 0, typeof(System.Globalization.DigitShapes), typeof(System.String));
					r_RVerifyDigitSubstitution_DigitShapes_String.SetBelong(null);
				}
				return r_RVerifyDigitSubstitution_DigitShapes_String;
			}
		}

		/// <summary>
		/// Void VerifyWritable()
		/// </summary>
		protected RMethod r_RVerifyWritable;
		public virtual RMethod RVerifyWritable
		{
			get
			{
				if(r_RVerifyWritable == null)
				{
					r_RVerifyWritable = new(this, "VerifyWritable", 0);
					r_RVerifyWritable.SetBelong(this.instance);
				}
				return r_RVerifyWritable;
			}
		}

		/// <summary>
		/// System.Globalization.NumberFormatInfo GetInstance(System.IFormatProvider)
		/// </summary>
		protected static RMethod r_RGetInstance_IFormatProvider;
		public static RMethod RGetInstance_IFormatProvider
		{
			get
			{
				if(r_RGetInstance_IFormatProvider == null)
				{
					r_RGetInstance_IFormatProvider = new(typeof(System.Globalization.NumberFormatInfo), "GetInstance", 0, typeof(System.IFormatProvider));
					r_RGetInstance_IFormatProvider.SetBelong(null);
				}
				return r_RGetInstance_IFormatProvider;
			}
		}

		/// <summary>
		/// System.Object Clone()
		/// </summary>
		protected RMethod r_RClone;
		public virtual RMethod RClone
		{
			get
			{
				if(r_RClone == null)
				{
					r_RClone = new(this, "Clone", 0);
					r_RClone.SetBelong(this.instance);
				}
				return r_RClone;
			}
		}

		/// <summary>
		/// Void CheckGroupSize(System.String, Int32[])
		/// </summary>
		protected static RMethod r_RCheckGroupSize_String_Int32Array;
		public static RMethod RCheckGroupSize_String_Int32Array
		{
			get
			{
				if(r_RCheckGroupSize_String_Int32Array == null)
				{
					r_RCheckGroupSize_String_Int32Array = new(typeof(System.Globalization.NumberFormatInfo), "CheckGroupSize", 0, typeof(System.String), typeof(System.Int32).MakeArrayType());
					r_RCheckGroupSize_String_Int32Array.SetBelong(null);
				}
				return r_RCheckGroupSize_String_Int32Array;
			}
		}

		/// <summary>
		/// System.Object GetFormat(System.Type)
		/// </summary>
		protected RMethod r_RGetFormat_Type;
		public virtual RMethod RGetFormat_Type
		{
			get
			{
				if(r_RGetFormat_Type == null)
				{
					r_RGetFormat_Type = new(this, "GetFormat", 0, typeof(System.Type));
					r_RGetFormat_Type.SetBelong(this.instance);
				}
				return r_RGetFormat_Type;
			}
		}

		/// <summary>
		/// System.Globalization.NumberFormatInfo ReadOnly(System.Globalization.NumberFormatInfo)
		/// </summary>
		protected static RMethod r_RReadOnly_NumberFormatInfo;
		public static RMethod RReadOnly_NumberFormatInfo
		{
			get
			{
				if(r_RReadOnly_NumberFormatInfo == null)
				{
					r_RReadOnly_NumberFormatInfo = new(typeof(System.Globalization.NumberFormatInfo), "ReadOnly", 0, typeof(System.Globalization.NumberFormatInfo));
					r_RReadOnly_NumberFormatInfo.SetBelong(null);
				}
				return r_RReadOnly_NumberFormatInfo;
			}
		}

		/// <summary>
		/// Void ValidateParseStyleInteger(System.Globalization.NumberStyles)
		/// </summary>
		protected static RMethod r_RValidateParseStyleInteger_NumberStyles;
		public static RMethod RValidateParseStyleInteger_NumberStyles
		{
			get
			{
				if(r_RValidateParseStyleInteger_NumberStyles == null)
				{
					r_RValidateParseStyleInteger_NumberStyles = new(typeof(System.Globalization.NumberFormatInfo), "ValidateParseStyleInteger", 0, typeof(System.Globalization.NumberStyles));
					r_RValidateParseStyleInteger_NumberStyles.SetBelong(null);
				}
				return r_RValidateParseStyleInteger_NumberStyles;
			}
		}

		/// <summary>
		/// Void ValidateParseStyleFloatingPoint(System.Globalization.NumberStyles)
		/// </summary>
		protected static RMethod r_RValidateParseStyleFloatingPoint_NumberStyles;
		public static RMethod RValidateParseStyleFloatingPoint_NumberStyles
		{
			get
			{
				if(r_RValidateParseStyleFloatingPoint_NumberStyles == null)
				{
					r_RValidateParseStyleFloatingPoint_NumberStyles = new(typeof(System.Globalization.NumberFormatInfo), "ValidateParseStyleFloatingPoint", 0, typeof(System.Globalization.NumberStyles));
					r_RValidateParseStyleFloatingPoint_NumberStyles.SetBelong(null);
				}
				return r_RValidateParseStyleFloatingPoint_NumberStyles;
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

        public virtual void OnSerializing(System.Runtime.Serialization.StreamingContext  @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx};
            var ___result = ROnSerializing_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDeserializing(System.Runtime.Serialization.StreamingContext  @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx};
            var ___result = ROnDeserializing_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDeserialized(System.Runtime.Serialization.StreamingContext  @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx};
            var ___result = ROnDeserialized_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public static void VerifyDecimalSeparator(System.String  @decSep, System.String  @propertyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@decSep, @propertyName};
            var ___result = RVerifyDecimalSeparator_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public static void VerifyGroupSeparator(System.String  @groupSep, System.String  @propertyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@groupSep, @propertyName};
            var ___result = RVerifyGroupSeparator_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public static void VerifyNativeDigits(System.String[]  @nativeDig, System.String  @propertyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nativeDig, @propertyName};
            var ___result = RVerifyNativeDigits_StringArray_String.Invoke(___genericsType, ___parameters);

            
        }


        public static void VerifyDigitSubstitution(System.Globalization.DigitShapes  @digitSub, System.String  @propertyName)
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


        public static System.Globalization.NumberFormatInfo GetInstance(System.IFormatProvider  @formatProvider)
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


        public static void CheckGroupSize(System.String  @propName, System.Int32[]  @groupSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propName, @groupSize};
            var ___result = RCheckGroupSize_String_Int32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetFormat(System.Type  @formatType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@formatType};
            var ___result = RGetFormat_Type.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Globalization.NumberFormatInfo ReadOnly(System.Globalization.NumberFormatInfo  @nfi)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nfi};
            var ___result = RReadOnly_NumberFormatInfo.Invoke(___genericsType, ___parameters);

            return (System.Globalization.NumberFormatInfo)___result;
        }


        public static void ValidateParseStyleInteger(System.Globalization.NumberStyles  @style)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style};
            var ___result = RValidateParseStyleInteger_NumberStyles.Invoke(___genericsType, ___parameters);

            
        }


        public static void ValidateParseStyleFloatingPoint(System.Globalization.NumberStyles  @style)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style};
            var ___result = RValidateParseStyleFloatingPoint_NumberStyles.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object  @obj)
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
