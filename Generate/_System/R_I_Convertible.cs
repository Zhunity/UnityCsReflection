
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.IConvertible
	/// </summary>
    public partial class RIConvertible : RMember //
    {

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
		/// Boolean ToBoolean(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToBoolean_IFormatProvider;
		public virtual RMethod RMToBoolean_IFormatProvider
		{
			get
			{
				if(r_MToBoolean_IFormatProvider == null)
				{
					r_MToBoolean_IFormatProvider = new(this, "ToBoolean", 0, typeof(System.IFormatProvider));
					r_MToBoolean_IFormatProvider.SetBelong(this.instance);
				}
				return r_MToBoolean_IFormatProvider;
			}
		}

		/// <summary>
		/// Char ToChar(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToChar_IFormatProvider;
		public virtual RMethod RMToChar_IFormatProvider
		{
			get
			{
				if(r_MToChar_IFormatProvider == null)
				{
					r_MToChar_IFormatProvider = new(this, "ToChar", 0, typeof(System.IFormatProvider));
					r_MToChar_IFormatProvider.SetBelong(this.instance);
				}
				return r_MToChar_IFormatProvider;
			}
		}

		/// <summary>
		/// SByte ToSByte(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToSByte_IFormatProvider;
		public virtual RMethod RMToSByte_IFormatProvider
		{
			get
			{
				if(r_MToSByte_IFormatProvider == null)
				{
					r_MToSByte_IFormatProvider = new(this, "ToSByte", 0, typeof(System.IFormatProvider));
					r_MToSByte_IFormatProvider.SetBelong(this.instance);
				}
				return r_MToSByte_IFormatProvider;
			}
		}

		/// <summary>
		/// Byte ToByte(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToByte_IFormatProvider;
		public virtual RMethod RMToByte_IFormatProvider
		{
			get
			{
				if(r_MToByte_IFormatProvider == null)
				{
					r_MToByte_IFormatProvider = new(this, "ToByte", 0, typeof(System.IFormatProvider));
					r_MToByte_IFormatProvider.SetBelong(this.instance);
				}
				return r_MToByte_IFormatProvider;
			}
		}

		/// <summary>
		/// Int16 ToInt16(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToInt16_IFormatProvider;
		public virtual RMethod RMToInt16_IFormatProvider
		{
			get
			{
				if(r_MToInt16_IFormatProvider == null)
				{
					r_MToInt16_IFormatProvider = new(this, "ToInt16", 0, typeof(System.IFormatProvider));
					r_MToInt16_IFormatProvider.SetBelong(this.instance);
				}
				return r_MToInt16_IFormatProvider;
			}
		}

		/// <summary>
		/// UInt16 ToUInt16(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToUInt16_IFormatProvider;
		public virtual RMethod RMToUInt16_IFormatProvider
		{
			get
			{
				if(r_MToUInt16_IFormatProvider == null)
				{
					r_MToUInt16_IFormatProvider = new(this, "ToUInt16", 0, typeof(System.IFormatProvider));
					r_MToUInt16_IFormatProvider.SetBelong(this.instance);
				}
				return r_MToUInt16_IFormatProvider;
			}
		}

		/// <summary>
		/// Int32 ToInt32(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToInt32_IFormatProvider;
		public virtual RMethod RMToInt32_IFormatProvider
		{
			get
			{
				if(r_MToInt32_IFormatProvider == null)
				{
					r_MToInt32_IFormatProvider = new(this, "ToInt32", 0, typeof(System.IFormatProvider));
					r_MToInt32_IFormatProvider.SetBelong(this.instance);
				}
				return r_MToInt32_IFormatProvider;
			}
		}

		/// <summary>
		/// UInt32 ToUInt32(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToUInt32_IFormatProvider;
		public virtual RMethod RMToUInt32_IFormatProvider
		{
			get
			{
				if(r_MToUInt32_IFormatProvider == null)
				{
					r_MToUInt32_IFormatProvider = new(this, "ToUInt32", 0, typeof(System.IFormatProvider));
					r_MToUInt32_IFormatProvider.SetBelong(this.instance);
				}
				return r_MToUInt32_IFormatProvider;
			}
		}

		/// <summary>
		/// Int64 ToInt64(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToInt64_IFormatProvider;
		public virtual RMethod RMToInt64_IFormatProvider
		{
			get
			{
				if(r_MToInt64_IFormatProvider == null)
				{
					r_MToInt64_IFormatProvider = new(this, "ToInt64", 0, typeof(System.IFormatProvider));
					r_MToInt64_IFormatProvider.SetBelong(this.instance);
				}
				return r_MToInt64_IFormatProvider;
			}
		}

		/// <summary>
		/// UInt64 ToUInt64(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToUInt64_IFormatProvider;
		public virtual RMethod RMToUInt64_IFormatProvider
		{
			get
			{
				if(r_MToUInt64_IFormatProvider == null)
				{
					r_MToUInt64_IFormatProvider = new(this, "ToUInt64", 0, typeof(System.IFormatProvider));
					r_MToUInt64_IFormatProvider.SetBelong(this.instance);
				}
				return r_MToUInt64_IFormatProvider;
			}
		}

		/// <summary>
		/// Single ToSingle(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToSingle_IFormatProvider;
		public virtual RMethod RMToSingle_IFormatProvider
		{
			get
			{
				if(r_MToSingle_IFormatProvider == null)
				{
					r_MToSingle_IFormatProvider = new(this, "ToSingle", 0, typeof(System.IFormatProvider));
					r_MToSingle_IFormatProvider.SetBelong(this.instance);
				}
				return r_MToSingle_IFormatProvider;
			}
		}

		/// <summary>
		/// Double ToDouble(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToDouble_IFormatProvider;
		public virtual RMethod RMToDouble_IFormatProvider
		{
			get
			{
				if(r_MToDouble_IFormatProvider == null)
				{
					r_MToDouble_IFormatProvider = new(this, "ToDouble", 0, typeof(System.IFormatProvider));
					r_MToDouble_IFormatProvider.SetBelong(this.instance);
				}
				return r_MToDouble_IFormatProvider;
			}
		}

		/// <summary>
		/// System.Decimal ToDecimal(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToDecimal_IFormatProvider;
		public virtual RMethod RMToDecimal_IFormatProvider
		{
			get
			{
				if(r_MToDecimal_IFormatProvider == null)
				{
					r_MToDecimal_IFormatProvider = new(this, "ToDecimal", 0, typeof(System.IFormatProvider));
					r_MToDecimal_IFormatProvider.SetBelong(this.instance);
				}
				return r_MToDecimal_IFormatProvider;
			}
		}

		/// <summary>
		/// System.DateTime ToDateTime(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToDateTime_IFormatProvider;
		public virtual RMethod RMToDateTime_IFormatProvider
		{
			get
			{
				if(r_MToDateTime_IFormatProvider == null)
				{
					r_MToDateTime_IFormatProvider = new(this, "ToDateTime", 0, typeof(System.IFormatProvider));
					r_MToDateTime_IFormatProvider.SetBelong(this.instance);
				}
				return r_MToDateTime_IFormatProvider;
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
		/// System.Object ToType(System.Type, System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToType_Type_IFormatProvider;
		public virtual RMethod RMToType_Type_IFormatProvider
		{
			get
			{
				if(r_MToType_Type_IFormatProvider == null)
				{
					r_MToType_Type_IFormatProvider = new(this, "ToType", 0, typeof(System.Type), typeof(System.IFormatProvider));
					r_MToType_Type_IFormatProvider.SetBelong(this.instance);
				}
				return r_MToType_Type_IFormatProvider;
			}
		}


        public RIConvertible() : base("System.IConvertible")
        {
        }

        public RIConvertible(System.Object instance) : base("System.IConvertible")
		{
            SetInstance(instance);
		}

        public RIConvertible(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIConvertible(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCode.Invoke(___genericsType, ___parameters);

            return (System.TypeCode)___result;
        }


        public virtual System.Boolean ToBoolean(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToBoolean_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Char ToChar(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToChar_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public virtual System.SByte ToSByte(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToSByte_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.SByte)___result;
        }


        public virtual System.Byte ToByte(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToByte_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Byte)___result;
        }


        public virtual System.Int16 ToInt16(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToInt16_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Int16)___result;
        }


        public virtual System.UInt16 ToUInt16(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToUInt16_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.UInt16)___result;
        }


        public virtual System.Int32 ToInt32(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToInt32_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.UInt32 ToUInt32(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToUInt32_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual System.Int64 ToInt64(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToInt64_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.UInt64 ToUInt64(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToUInt64_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public virtual System.Single ToSingle(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToSingle_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Double ToDouble(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToDouble_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Decimal ToDecimal(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToDecimal_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public virtual System.DateTime ToDateTime(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToDateTime_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Object ToType(System.Type @conversionType, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@conversionType, @provider};
            var ___result = RMToType_Type_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
