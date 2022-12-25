using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RGlobalization
{public partial class RCultureData
{
	
	/// <summary>
	/// System.Globalization.CultureData+NumberFormatEntryManaged
	/// </summary>
    public partial class RNumberFormatEntryManaged : RMember //
    {

		/// <summary>
		/// System.Int32 currency_decimal_digits
		/// </summary>
		protected RField r_currency_decimal_digits;
		public virtual RField Rcurrency_decimal_digits
		{
			get
			{
				if(r_currency_decimal_digits == null)
				{
					r_currency_decimal_digits = new(this, "currency_decimal_digits");
					r_currency_decimal_digits.SetBelong(this.instance);
				}
				return r_currency_decimal_digits;
			}
		}

		/// <summary>
		/// System.Int32 currency_decimal_separator
		/// </summary>
		protected RField r_currency_decimal_separator;
		public virtual RField Rcurrency_decimal_separator
		{
			get
			{
				if(r_currency_decimal_separator == null)
				{
					r_currency_decimal_separator = new(this, "currency_decimal_separator");
					r_currency_decimal_separator.SetBelong(this.instance);
				}
				return r_currency_decimal_separator;
			}
		}

		/// <summary>
		/// System.Int32 currency_group_separator
		/// </summary>
		protected RField r_currency_group_separator;
		public virtual RField Rcurrency_group_separator
		{
			get
			{
				if(r_currency_group_separator == null)
				{
					r_currency_group_separator = new(this, "currency_group_separator");
					r_currency_group_separator.SetBelong(this.instance);
				}
				return r_currency_group_separator;
			}
		}

		/// <summary>
		/// System.Int32 currency_group_sizes0
		/// </summary>
		protected RField r_currency_group_sizes0;
		public virtual RField Rcurrency_group_sizes0
		{
			get
			{
				if(r_currency_group_sizes0 == null)
				{
					r_currency_group_sizes0 = new(this, "currency_group_sizes0");
					r_currency_group_sizes0.SetBelong(this.instance);
				}
				return r_currency_group_sizes0;
			}
		}

		/// <summary>
		/// System.Int32 currency_group_sizes1
		/// </summary>
		protected RField r_currency_group_sizes1;
		public virtual RField Rcurrency_group_sizes1
		{
			get
			{
				if(r_currency_group_sizes1 == null)
				{
					r_currency_group_sizes1 = new(this, "currency_group_sizes1");
					r_currency_group_sizes1.SetBelong(this.instance);
				}
				return r_currency_group_sizes1;
			}
		}

		/// <summary>
		/// System.Int32 currency_negative_pattern
		/// </summary>
		protected RField r_currency_negative_pattern;
		public virtual RField Rcurrency_negative_pattern
		{
			get
			{
				if(r_currency_negative_pattern == null)
				{
					r_currency_negative_pattern = new(this, "currency_negative_pattern");
					r_currency_negative_pattern.SetBelong(this.instance);
				}
				return r_currency_negative_pattern;
			}
		}

		/// <summary>
		/// System.Int32 currency_positive_pattern
		/// </summary>
		protected RField r_currency_positive_pattern;
		public virtual RField Rcurrency_positive_pattern
		{
			get
			{
				if(r_currency_positive_pattern == null)
				{
					r_currency_positive_pattern = new(this, "currency_positive_pattern");
					r_currency_positive_pattern.SetBelong(this.instance);
				}
				return r_currency_positive_pattern;
			}
		}

		/// <summary>
		/// System.Int32 currency_symbol
		/// </summary>
		protected RField r_currency_symbol;
		public virtual RField Rcurrency_symbol
		{
			get
			{
				if(r_currency_symbol == null)
				{
					r_currency_symbol = new(this, "currency_symbol");
					r_currency_symbol.SetBelong(this.instance);
				}
				return r_currency_symbol;
			}
		}

		/// <summary>
		/// System.Int32 nan_symbol
		/// </summary>
		protected RField r_nan_symbol;
		public virtual RField Rnan_symbol
		{
			get
			{
				if(r_nan_symbol == null)
				{
					r_nan_symbol = new(this, "nan_symbol");
					r_nan_symbol.SetBelong(this.instance);
				}
				return r_nan_symbol;
			}
		}

		/// <summary>
		/// System.Int32 negative_infinity_symbol
		/// </summary>
		protected RField r_negative_infinity_symbol;
		public virtual RField Rnegative_infinity_symbol
		{
			get
			{
				if(r_negative_infinity_symbol == null)
				{
					r_negative_infinity_symbol = new(this, "negative_infinity_symbol");
					r_negative_infinity_symbol.SetBelong(this.instance);
				}
				return r_negative_infinity_symbol;
			}
		}

		/// <summary>
		/// System.Int32 negative_sign
		/// </summary>
		protected RField r_negative_sign;
		public virtual RField Rnegative_sign
		{
			get
			{
				if(r_negative_sign == null)
				{
					r_negative_sign = new(this, "negative_sign");
					r_negative_sign.SetBelong(this.instance);
				}
				return r_negative_sign;
			}
		}

		/// <summary>
		/// System.Int32 number_decimal_digits
		/// </summary>
		protected RField r_number_decimal_digits;
		public virtual RField Rnumber_decimal_digits
		{
			get
			{
				if(r_number_decimal_digits == null)
				{
					r_number_decimal_digits = new(this, "number_decimal_digits");
					r_number_decimal_digits.SetBelong(this.instance);
				}
				return r_number_decimal_digits;
			}
		}

		/// <summary>
		/// System.Int32 number_decimal_separator
		/// </summary>
		protected RField r_number_decimal_separator;
		public virtual RField Rnumber_decimal_separator
		{
			get
			{
				if(r_number_decimal_separator == null)
				{
					r_number_decimal_separator = new(this, "number_decimal_separator");
					r_number_decimal_separator.SetBelong(this.instance);
				}
				return r_number_decimal_separator;
			}
		}

		/// <summary>
		/// System.Int32 number_group_separator
		/// </summary>
		protected RField r_number_group_separator;
		public virtual RField Rnumber_group_separator
		{
			get
			{
				if(r_number_group_separator == null)
				{
					r_number_group_separator = new(this, "number_group_separator");
					r_number_group_separator.SetBelong(this.instance);
				}
				return r_number_group_separator;
			}
		}

		/// <summary>
		/// System.Int32 number_group_sizes0
		/// </summary>
		protected RField r_number_group_sizes0;
		public virtual RField Rnumber_group_sizes0
		{
			get
			{
				if(r_number_group_sizes0 == null)
				{
					r_number_group_sizes0 = new(this, "number_group_sizes0");
					r_number_group_sizes0.SetBelong(this.instance);
				}
				return r_number_group_sizes0;
			}
		}

		/// <summary>
		/// System.Int32 number_group_sizes1
		/// </summary>
		protected RField r_number_group_sizes1;
		public virtual RField Rnumber_group_sizes1
		{
			get
			{
				if(r_number_group_sizes1 == null)
				{
					r_number_group_sizes1 = new(this, "number_group_sizes1");
					r_number_group_sizes1.SetBelong(this.instance);
				}
				return r_number_group_sizes1;
			}
		}

		/// <summary>
		/// System.Int32 number_negative_pattern
		/// </summary>
		protected RField r_number_negative_pattern;
		public virtual RField Rnumber_negative_pattern
		{
			get
			{
				if(r_number_negative_pattern == null)
				{
					r_number_negative_pattern = new(this, "number_negative_pattern");
					r_number_negative_pattern.SetBelong(this.instance);
				}
				return r_number_negative_pattern;
			}
		}

		/// <summary>
		/// System.Int32 per_mille_symbol
		/// </summary>
		protected RField r_per_mille_symbol;
		public virtual RField Rper_mille_symbol
		{
			get
			{
				if(r_per_mille_symbol == null)
				{
					r_per_mille_symbol = new(this, "per_mille_symbol");
					r_per_mille_symbol.SetBelong(this.instance);
				}
				return r_per_mille_symbol;
			}
		}

		/// <summary>
		/// System.Int32 percent_negative_pattern
		/// </summary>
		protected RField r_percent_negative_pattern;
		public virtual RField Rpercent_negative_pattern
		{
			get
			{
				if(r_percent_negative_pattern == null)
				{
					r_percent_negative_pattern = new(this, "percent_negative_pattern");
					r_percent_negative_pattern.SetBelong(this.instance);
				}
				return r_percent_negative_pattern;
			}
		}

		/// <summary>
		/// System.Int32 percent_positive_pattern
		/// </summary>
		protected RField r_percent_positive_pattern;
		public virtual RField Rpercent_positive_pattern
		{
			get
			{
				if(r_percent_positive_pattern == null)
				{
					r_percent_positive_pattern = new(this, "percent_positive_pattern");
					r_percent_positive_pattern.SetBelong(this.instance);
				}
				return r_percent_positive_pattern;
			}
		}

		/// <summary>
		/// System.Int32 percent_symbol
		/// </summary>
		protected RField r_percent_symbol;
		public virtual RField Rpercent_symbol
		{
			get
			{
				if(r_percent_symbol == null)
				{
					r_percent_symbol = new(this, "percent_symbol");
					r_percent_symbol.SetBelong(this.instance);
				}
				return r_percent_symbol;
			}
		}

		/// <summary>
		/// System.Int32 positive_infinity_symbol
		/// </summary>
		protected RField r_positive_infinity_symbol;
		public virtual RField Rpositive_infinity_symbol
		{
			get
			{
				if(r_positive_infinity_symbol == null)
				{
					r_positive_infinity_symbol = new(this, "positive_infinity_symbol");
					r_positive_infinity_symbol.SetBelong(this.instance);
				}
				return r_positive_infinity_symbol;
			}
		}

		/// <summary>
		/// System.Int32 positive_sign
		/// </summary>
		protected RField r_positive_sign;
		public virtual RField Rpositive_sign
		{
			get
			{
				if(r_positive_sign == null)
				{
					r_positive_sign = new(this, "positive_sign");
					r_positive_sign.SetBelong(this.instance);
				}
				return r_positive_sign;
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


        public RNumberFormatEntryManaged() : base("System.Globalization.CultureData+NumberFormatEntryManaged")
        {
        }

        public RNumberFormatEntryManaged(System.Object instance) : base("System.Globalization.CultureData+NumberFormatEntryManaged")
		{
            SetInstance(instance);
		}

        public RNumberFormatEntryManaged(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RNumberFormatEntryManaged(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
}