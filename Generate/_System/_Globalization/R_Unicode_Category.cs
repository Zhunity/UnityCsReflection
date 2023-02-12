
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RGlobalization
{
	/// <summary>
	/// System.Globalization.UnicodeCategory
	/// </summary>
    public partial class RUnicodeCategory : RMember //
    {

		/// <summary>
		/// System.Int32 value__
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fvalue__;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFvalue__
		{
			get
			{
				if(r_Fvalue__ == null)
				{
					r_Fvalue__ = new(this, "value__");
					r_Fvalue__.SetBelong(this.instance);
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory UppercaseLetter
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory r_FUppercaseLetter;
		public static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory RFUppercaseLetter
		{
			get
			{
				if(r_FUppercaseLetter == null)
				{
					r_FUppercaseLetter = new(typeof(System.Globalization.UnicodeCategory), "UppercaseLetter");
					r_FUppercaseLetter.SetBelong(null);
				}
				return r_FUppercaseLetter;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory LowercaseLetter
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory r_FLowercaseLetter;
		public static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory RFLowercaseLetter
		{
			get
			{
				if(r_FLowercaseLetter == null)
				{
					r_FLowercaseLetter = new(typeof(System.Globalization.UnicodeCategory), "LowercaseLetter");
					r_FLowercaseLetter.SetBelong(null);
				}
				return r_FLowercaseLetter;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory TitlecaseLetter
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory r_FTitlecaseLetter;
		public static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory RFTitlecaseLetter
		{
			get
			{
				if(r_FTitlecaseLetter == null)
				{
					r_FTitlecaseLetter = new(typeof(System.Globalization.UnicodeCategory), "TitlecaseLetter");
					r_FTitlecaseLetter.SetBelong(null);
				}
				return r_FTitlecaseLetter;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory ModifierLetter
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory r_FModifierLetter;
		public static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory RFModifierLetter
		{
			get
			{
				if(r_FModifierLetter == null)
				{
					r_FModifierLetter = new(typeof(System.Globalization.UnicodeCategory), "ModifierLetter");
					r_FModifierLetter.SetBelong(null);
				}
				return r_FModifierLetter;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory OtherLetter
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory r_FOtherLetter;
		public static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory RFOtherLetter
		{
			get
			{
				if(r_FOtherLetter == null)
				{
					r_FOtherLetter = new(typeof(System.Globalization.UnicodeCategory), "OtherLetter");
					r_FOtherLetter.SetBelong(null);
				}
				return r_FOtherLetter;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory NonSpacingMark
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory r_FNonSpacingMark;
		public static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory RFNonSpacingMark
		{
			get
			{
				if(r_FNonSpacingMark == null)
				{
					r_FNonSpacingMark = new(typeof(System.Globalization.UnicodeCategory), "NonSpacingMark");
					r_FNonSpacingMark.SetBelong(null);
				}
				return r_FNonSpacingMark;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory SpacingCombiningMark
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory r_FSpacingCombiningMark;
		public static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory RFSpacingCombiningMark
		{
			get
			{
				if(r_FSpacingCombiningMark == null)
				{
					r_FSpacingCombiningMark = new(typeof(System.Globalization.UnicodeCategory), "SpacingCombiningMark");
					r_FSpacingCombiningMark.SetBelong(null);
				}
				return r_FSpacingCombiningMark;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory EnclosingMark
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory r_FEnclosingMark;
		public static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory RFEnclosingMark
		{
			get
			{
				if(r_FEnclosingMark == null)
				{
					r_FEnclosingMark = new(typeof(System.Globalization.UnicodeCategory), "EnclosingMark");
					r_FEnclosingMark.SetBelong(null);
				}
				return r_FEnclosingMark;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory DecimalDigitNumber
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory r_FDecimalDigitNumber;
		public static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory RFDecimalDigitNumber
		{
			get
			{
				if(r_FDecimalDigitNumber == null)
				{
					r_FDecimalDigitNumber = new(typeof(System.Globalization.UnicodeCategory), "DecimalDigitNumber");
					r_FDecimalDigitNumber.SetBelong(null);
				}
				return r_FDecimalDigitNumber;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory LetterNumber
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory r_FLetterNumber;
		public static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory RFLetterNumber
		{
			get
			{
				if(r_FLetterNumber == null)
				{
					r_FLetterNumber = new(typeof(System.Globalization.UnicodeCategory), "LetterNumber");
					r_FLetterNumber.SetBelong(null);
				}
				return r_FLetterNumber;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory OtherNumber
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory r_FOtherNumber;
		public static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory RFOtherNumber
		{
			get
			{
				if(r_FOtherNumber == null)
				{
					r_FOtherNumber = new(typeof(System.Globalization.UnicodeCategory), "OtherNumber");
					r_FOtherNumber.SetBelong(null);
				}
				return r_FOtherNumber;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory SpaceSeparator
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory r_FSpaceSeparator;
		public static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory RFSpaceSeparator
		{
			get
			{
				if(r_FSpaceSeparator == null)
				{
					r_FSpaceSeparator = new(typeof(System.Globalization.UnicodeCategory), "SpaceSeparator");
					r_FSpaceSeparator.SetBelong(null);
				}
				return r_FSpaceSeparator;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory LineSeparator
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory r_FLineSeparator;
		public static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory RFLineSeparator
		{
			get
			{
				if(r_FLineSeparator == null)
				{
					r_FLineSeparator = new(typeof(System.Globalization.UnicodeCategory), "LineSeparator");
					r_FLineSeparator.SetBelong(null);
				}
				return r_FLineSeparator;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory ParagraphSeparator
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory r_FParagraphSeparator;
		public static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory RFParagraphSeparator
		{
			get
			{
				if(r_FParagraphSeparator == null)
				{
					r_FParagraphSeparator = new(typeof(System.Globalization.UnicodeCategory), "ParagraphSeparator");
					r_FParagraphSeparator.SetBelong(null);
				}
				return r_FParagraphSeparator;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory Control
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory r_FControl;
		public static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory RFControl
		{
			get
			{
				if(r_FControl == null)
				{
					r_FControl = new(typeof(System.Globalization.UnicodeCategory), "Control");
					r_FControl.SetBelong(null);
				}
				return r_FControl;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory Format
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory r_FFormat;
		public static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory RFFormat
		{
			get
			{
				if(r_FFormat == null)
				{
					r_FFormat = new(typeof(System.Globalization.UnicodeCategory), "Format");
					r_FFormat.SetBelong(null);
				}
				return r_FFormat;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory Surrogate
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory r_FSurrogate;
		public static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory RFSurrogate
		{
			get
			{
				if(r_FSurrogate == null)
				{
					r_FSurrogate = new(typeof(System.Globalization.UnicodeCategory), "Surrogate");
					r_FSurrogate.SetBelong(null);
				}
				return r_FSurrogate;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory PrivateUse
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory r_FPrivateUse;
		public static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory RFPrivateUse
		{
			get
			{
				if(r_FPrivateUse == null)
				{
					r_FPrivateUse = new(typeof(System.Globalization.UnicodeCategory), "PrivateUse");
					r_FPrivateUse.SetBelong(null);
				}
				return r_FPrivateUse;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory ConnectorPunctuation
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory r_FConnectorPunctuation;
		public static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory RFConnectorPunctuation
		{
			get
			{
				if(r_FConnectorPunctuation == null)
				{
					r_FConnectorPunctuation = new(typeof(System.Globalization.UnicodeCategory), "ConnectorPunctuation");
					r_FConnectorPunctuation.SetBelong(null);
				}
				return r_FConnectorPunctuation;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory DashPunctuation
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory r_FDashPunctuation;
		public static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory RFDashPunctuation
		{
			get
			{
				if(r_FDashPunctuation == null)
				{
					r_FDashPunctuation = new(typeof(System.Globalization.UnicodeCategory), "DashPunctuation");
					r_FDashPunctuation.SetBelong(null);
				}
				return r_FDashPunctuation;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory OpenPunctuation
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory r_FOpenPunctuation;
		public static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory RFOpenPunctuation
		{
			get
			{
				if(r_FOpenPunctuation == null)
				{
					r_FOpenPunctuation = new(typeof(System.Globalization.UnicodeCategory), "OpenPunctuation");
					r_FOpenPunctuation.SetBelong(null);
				}
				return r_FOpenPunctuation;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory ClosePunctuation
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory r_FClosePunctuation;
		public static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory RFClosePunctuation
		{
			get
			{
				if(r_FClosePunctuation == null)
				{
					r_FClosePunctuation = new(typeof(System.Globalization.UnicodeCategory), "ClosePunctuation");
					r_FClosePunctuation.SetBelong(null);
				}
				return r_FClosePunctuation;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory InitialQuotePunctuation
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory r_FInitialQuotePunctuation;
		public static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory RFInitialQuotePunctuation
		{
			get
			{
				if(r_FInitialQuotePunctuation == null)
				{
					r_FInitialQuotePunctuation = new(typeof(System.Globalization.UnicodeCategory), "InitialQuotePunctuation");
					r_FInitialQuotePunctuation.SetBelong(null);
				}
				return r_FInitialQuotePunctuation;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory FinalQuotePunctuation
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory r_FFinalQuotePunctuation;
		public static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory RFFinalQuotePunctuation
		{
			get
			{
				if(r_FFinalQuotePunctuation == null)
				{
					r_FFinalQuotePunctuation = new(typeof(System.Globalization.UnicodeCategory), "FinalQuotePunctuation");
					r_FFinalQuotePunctuation.SetBelong(null);
				}
				return r_FFinalQuotePunctuation;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory OtherPunctuation
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory r_FOtherPunctuation;
		public static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory RFOtherPunctuation
		{
			get
			{
				if(r_FOtherPunctuation == null)
				{
					r_FOtherPunctuation = new(typeof(System.Globalization.UnicodeCategory), "OtherPunctuation");
					r_FOtherPunctuation.SetBelong(null);
				}
				return r_FOtherPunctuation;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory MathSymbol
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory r_FMathSymbol;
		public static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory RFMathSymbol
		{
			get
			{
				if(r_FMathSymbol == null)
				{
					r_FMathSymbol = new(typeof(System.Globalization.UnicodeCategory), "MathSymbol");
					r_FMathSymbol.SetBelong(null);
				}
				return r_FMathSymbol;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory CurrencySymbol
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory r_FCurrencySymbol;
		public static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory RFCurrencySymbol
		{
			get
			{
				if(r_FCurrencySymbol == null)
				{
					r_FCurrencySymbol = new(typeof(System.Globalization.UnicodeCategory), "CurrencySymbol");
					r_FCurrencySymbol.SetBelong(null);
				}
				return r_FCurrencySymbol;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory ModifierSymbol
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory r_FModifierSymbol;
		public static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory RFModifierSymbol
		{
			get
			{
				if(r_FModifierSymbol == null)
				{
					r_FModifierSymbol = new(typeof(System.Globalization.UnicodeCategory), "ModifierSymbol");
					r_FModifierSymbol.SetBelong(null);
				}
				return r_FModifierSymbol;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory OtherSymbol
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory r_FOtherSymbol;
		public static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory RFOtherSymbol
		{
			get
			{
				if(r_FOtherSymbol == null)
				{
					r_FOtherSymbol = new(typeof(System.Globalization.UnicodeCategory), "OtherSymbol");
					r_FOtherSymbol.SetBelong(null);
				}
				return r_FOtherSymbol;
			}
		}

		/// <summary>
		/// System.Globalization.UnicodeCategory OtherNotAssigned
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory r_FOtherNotAssigned;
		public static SMFrame.Editor.Refleaction.RSystem.RGlobalization.RUnicodeCategory RFOtherNotAssigned
		{
			get
			{
				if(r_FOtherNotAssigned == null)
				{
					r_FOtherNotAssigned = new(typeof(System.Globalization.UnicodeCategory), "OtherNotAssigned");
					r_FOtherNotAssigned.SetBelong(null);
				}
				return r_FOtherNotAssigned;
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


        public RUnicodeCategory() : base("System.Globalization.UnicodeCategory")
        {
        }

        public RUnicodeCategory(System.Object instance) : base("System.Globalization.UnicodeCategory")
		{
            SetInstance(instance);
		}

        public RUnicodeCategory(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUnicodeCategory(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object GetValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValue.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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
