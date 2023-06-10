
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RGlobalization
{public partial class RCultureData
{
	
	/// <summary>
	/// System.Globalization.CultureData+NumberFormatEntryManaged
	/// </summary>
    public partial class RNumberFormatEntryManaged : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Globalization.CultureData+NumberFormatEntryManaged");
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


		/// <summary>
		/// System.Int32 currency_decimal_digits
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fcurrency_decimal_digits;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFcurrency_decimal_digits
		{
			get
			{
				if(r_Fcurrency_decimal_digits == null)
				{
					r_Fcurrency_decimal_digits = new(this, "currency_decimal_digits");
				}
				return r_Fcurrency_decimal_digits;
			}
		}

		/// <summary>
		/// System.Int32 currency_decimal_separator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fcurrency_decimal_separator;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFcurrency_decimal_separator
		{
			get
			{
				if(r_Fcurrency_decimal_separator == null)
				{
					r_Fcurrency_decimal_separator = new(this, "currency_decimal_separator");
				}
				return r_Fcurrency_decimal_separator;
			}
		}

		/// <summary>
		/// System.Int32 currency_group_separator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fcurrency_group_separator;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFcurrency_group_separator
		{
			get
			{
				if(r_Fcurrency_group_separator == null)
				{
					r_Fcurrency_group_separator = new(this, "currency_group_separator");
				}
				return r_Fcurrency_group_separator;
			}
		}

		/// <summary>
		/// System.Int32 currency_group_sizes0
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fcurrency_group_sizes0;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFcurrency_group_sizes0
		{
			get
			{
				if(r_Fcurrency_group_sizes0 == null)
				{
					r_Fcurrency_group_sizes0 = new(this, "currency_group_sizes0");
				}
				return r_Fcurrency_group_sizes0;
			}
		}

		/// <summary>
		/// System.Int32 currency_group_sizes1
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fcurrency_group_sizes1;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFcurrency_group_sizes1
		{
			get
			{
				if(r_Fcurrency_group_sizes1 == null)
				{
					r_Fcurrency_group_sizes1 = new(this, "currency_group_sizes1");
				}
				return r_Fcurrency_group_sizes1;
			}
		}

		/// <summary>
		/// System.Int32 currency_negative_pattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fcurrency_negative_pattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFcurrency_negative_pattern
		{
			get
			{
				if(r_Fcurrency_negative_pattern == null)
				{
					r_Fcurrency_negative_pattern = new(this, "currency_negative_pattern");
				}
				return r_Fcurrency_negative_pattern;
			}
		}

		/// <summary>
		/// System.Int32 currency_positive_pattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fcurrency_positive_pattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFcurrency_positive_pattern
		{
			get
			{
				if(r_Fcurrency_positive_pattern == null)
				{
					r_Fcurrency_positive_pattern = new(this, "currency_positive_pattern");
				}
				return r_Fcurrency_positive_pattern;
			}
		}

		/// <summary>
		/// System.Int32 currency_symbol
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fcurrency_symbol;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFcurrency_symbol
		{
			get
			{
				if(r_Fcurrency_symbol == null)
				{
					r_Fcurrency_symbol = new(this, "currency_symbol");
				}
				return r_Fcurrency_symbol;
			}
		}

		/// <summary>
		/// System.Int32 nan_symbol
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fnan_symbol;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFnan_symbol
		{
			get
			{
				if(r_Fnan_symbol == null)
				{
					r_Fnan_symbol = new(this, "nan_symbol");
				}
				return r_Fnan_symbol;
			}
		}

		/// <summary>
		/// System.Int32 negative_infinity_symbol
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fnegative_infinity_symbol;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFnegative_infinity_symbol
		{
			get
			{
				if(r_Fnegative_infinity_symbol == null)
				{
					r_Fnegative_infinity_symbol = new(this, "negative_infinity_symbol");
				}
				return r_Fnegative_infinity_symbol;
			}
		}

		/// <summary>
		/// System.Int32 negative_sign
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fnegative_sign;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFnegative_sign
		{
			get
			{
				if(r_Fnegative_sign == null)
				{
					r_Fnegative_sign = new(this, "negative_sign");
				}
				return r_Fnegative_sign;
			}
		}

		/// <summary>
		/// System.Int32 number_decimal_digits
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fnumber_decimal_digits;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFnumber_decimal_digits
		{
			get
			{
				if(r_Fnumber_decimal_digits == null)
				{
					r_Fnumber_decimal_digits = new(this, "number_decimal_digits");
				}
				return r_Fnumber_decimal_digits;
			}
		}

		/// <summary>
		/// System.Int32 number_decimal_separator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fnumber_decimal_separator;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFnumber_decimal_separator
		{
			get
			{
				if(r_Fnumber_decimal_separator == null)
				{
					r_Fnumber_decimal_separator = new(this, "number_decimal_separator");
				}
				return r_Fnumber_decimal_separator;
			}
		}

		/// <summary>
		/// System.Int32 number_group_separator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fnumber_group_separator;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFnumber_group_separator
		{
			get
			{
				if(r_Fnumber_group_separator == null)
				{
					r_Fnumber_group_separator = new(this, "number_group_separator");
				}
				return r_Fnumber_group_separator;
			}
		}

		/// <summary>
		/// System.Int32 number_group_sizes0
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fnumber_group_sizes0;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFnumber_group_sizes0
		{
			get
			{
				if(r_Fnumber_group_sizes0 == null)
				{
					r_Fnumber_group_sizes0 = new(this, "number_group_sizes0");
				}
				return r_Fnumber_group_sizes0;
			}
		}

		/// <summary>
		/// System.Int32 number_group_sizes1
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fnumber_group_sizes1;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFnumber_group_sizes1
		{
			get
			{
				if(r_Fnumber_group_sizes1 == null)
				{
					r_Fnumber_group_sizes1 = new(this, "number_group_sizes1");
				}
				return r_Fnumber_group_sizes1;
			}
		}

		/// <summary>
		/// System.Int32 number_negative_pattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fnumber_negative_pattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFnumber_negative_pattern
		{
			get
			{
				if(r_Fnumber_negative_pattern == null)
				{
					r_Fnumber_negative_pattern = new(this, "number_negative_pattern");
				}
				return r_Fnumber_negative_pattern;
			}
		}

		/// <summary>
		/// System.Int32 per_mille_symbol
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fper_mille_symbol;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFper_mille_symbol
		{
			get
			{
				if(r_Fper_mille_symbol == null)
				{
					r_Fper_mille_symbol = new(this, "per_mille_symbol");
				}
				return r_Fper_mille_symbol;
			}
		}

		/// <summary>
		/// System.Int32 percent_negative_pattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fpercent_negative_pattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFpercent_negative_pattern
		{
			get
			{
				if(r_Fpercent_negative_pattern == null)
				{
					r_Fpercent_negative_pattern = new(this, "percent_negative_pattern");
				}
				return r_Fpercent_negative_pattern;
			}
		}

		/// <summary>
		/// System.Int32 percent_positive_pattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fpercent_positive_pattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFpercent_positive_pattern
		{
			get
			{
				if(r_Fpercent_positive_pattern == null)
				{
					r_Fpercent_positive_pattern = new(this, "percent_positive_pattern");
				}
				return r_Fpercent_positive_pattern;
			}
		}

		/// <summary>
		/// System.Int32 percent_symbol
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fpercent_symbol;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFpercent_symbol
		{
			get
			{
				if(r_Fpercent_symbol == null)
				{
					r_Fpercent_symbol = new(this, "percent_symbol");
				}
				return r_Fpercent_symbol;
			}
		}

		/// <summary>
		/// System.Int32 positive_infinity_symbol
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fpositive_infinity_symbol;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFpositive_infinity_symbol
		{
			get
			{
				if(r_Fpositive_infinity_symbol == null)
				{
					r_Fpositive_infinity_symbol = new(this, "positive_infinity_symbol");
				}
				return r_Fpositive_infinity_symbol;
			}
		}

		/// <summary>
		/// System.Int32 positive_sign
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fpositive_sign;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFpositive_sign
		{
			get
			{
				if(r_Fpositive_sign == null)
				{
					r_Fpositive_sign = new(this, "positive_sign");
				}
				return r_Fpositive_sign;
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
}