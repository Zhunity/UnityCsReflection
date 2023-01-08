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
		protected RMethod r_GetTypeCode;
		public virtual RMethod RGetTypeCode
		{
			get
			{
				if(r_GetTypeCode == null)
				{
					r_GetTypeCode = new(this, "GetTypeCode", 0);
					r_GetTypeCode.SetBelong(this.instance);
				}
				return r_GetTypeCode;
			}
		}

		/// <summary>
		/// Boolean ToBoolean(System.IFormatProvider)
		/// </summary>
		protected RMethod r_ToBoolean_IFormatProvider;
		public virtual RMethod RToBoolean_IFormatProvider
		{
			get
			{
				if(r_ToBoolean_IFormatProvider == null)
				{
					r_ToBoolean_IFormatProvider = new(this, "ToBoolean", 0, typeof(System.IFormatProvider));
					r_ToBoolean_IFormatProvider.SetBelong(this.instance);
				}
				return r_ToBoolean_IFormatProvider;
			}
		}

		/// <summary>
		/// Char ToChar(System.IFormatProvider)
		/// </summary>
		protected RMethod r_ToChar_IFormatProvider;
		public virtual RMethod RToChar_IFormatProvider
		{
			get
			{
				if(r_ToChar_IFormatProvider == null)
				{
					r_ToChar_IFormatProvider = new(this, "ToChar", 0, typeof(System.IFormatProvider));
					r_ToChar_IFormatProvider.SetBelong(this.instance);
				}
				return r_ToChar_IFormatProvider;
			}
		}

		/// <summary>
		/// SByte ToSByte(System.IFormatProvider)
		/// </summary>
		protected RMethod r_ToSByte_IFormatProvider;
		public virtual RMethod RToSByte_IFormatProvider
		{
			get
			{
				if(r_ToSByte_IFormatProvider == null)
				{
					r_ToSByte_IFormatProvider = new(this, "ToSByte", 0, typeof(System.IFormatProvider));
					r_ToSByte_IFormatProvider.SetBelong(this.instance);
				}
				return r_ToSByte_IFormatProvider;
			}
		}

		/// <summary>
		/// Byte ToByte(System.IFormatProvider)
		/// </summary>
		protected RMethod r_ToByte_IFormatProvider;
		public virtual RMethod RToByte_IFormatProvider
		{
			get
			{
				if(r_ToByte_IFormatProvider == null)
				{
					r_ToByte_IFormatProvider = new(this, "ToByte", 0, typeof(System.IFormatProvider));
					r_ToByte_IFormatProvider.SetBelong(this.instance);
				}
				return r_ToByte_IFormatProvider;
			}
		}

		/// <summary>
		/// Int16 ToInt16(System.IFormatProvider)
		/// </summary>
		protected RMethod r_ToInt16_IFormatProvider;
		public virtual RMethod RToInt16_IFormatProvider
		{
			get
			{
				if(r_ToInt16_IFormatProvider == null)
				{
					r_ToInt16_IFormatProvider = new(this, "ToInt16", 0, typeof(System.IFormatProvider));
					r_ToInt16_IFormatProvider.SetBelong(this.instance);
				}
				return r_ToInt16_IFormatProvider;
			}
		}

		/// <summary>
		/// UInt16 ToUInt16(System.IFormatProvider)
		/// </summary>
		protected RMethod r_ToUInt16_IFormatProvider;
		public virtual RMethod RToUInt16_IFormatProvider
		{
			get
			{
				if(r_ToUInt16_IFormatProvider == null)
				{
					r_ToUInt16_IFormatProvider = new(this, "ToUInt16", 0, typeof(System.IFormatProvider));
					r_ToUInt16_IFormatProvider.SetBelong(this.instance);
				}
				return r_ToUInt16_IFormatProvider;
			}
		}

		/// <summary>
		/// Int32 ToInt32(System.IFormatProvider)
		/// </summary>
		protected RMethod r_ToInt32_IFormatProvider;
		public virtual RMethod RToInt32_IFormatProvider
		{
			get
			{
				if(r_ToInt32_IFormatProvider == null)
				{
					r_ToInt32_IFormatProvider = new(this, "ToInt32", 0, typeof(System.IFormatProvider));
					r_ToInt32_IFormatProvider.SetBelong(this.instance);
				}
				return r_ToInt32_IFormatProvider;
			}
		}

		/// <summary>
		/// UInt32 ToUInt32(System.IFormatProvider)
		/// </summary>
		protected RMethod r_ToUInt32_IFormatProvider;
		public virtual RMethod RToUInt32_IFormatProvider
		{
			get
			{
				if(r_ToUInt32_IFormatProvider == null)
				{
					r_ToUInt32_IFormatProvider = new(this, "ToUInt32", 0, typeof(System.IFormatProvider));
					r_ToUInt32_IFormatProvider.SetBelong(this.instance);
				}
				return r_ToUInt32_IFormatProvider;
			}
		}

		/// <summary>
		/// Int64 ToInt64(System.IFormatProvider)
		/// </summary>
		protected RMethod r_ToInt64_IFormatProvider;
		public virtual RMethod RToInt64_IFormatProvider
		{
			get
			{
				if(r_ToInt64_IFormatProvider == null)
				{
					r_ToInt64_IFormatProvider = new(this, "ToInt64", 0, typeof(System.IFormatProvider));
					r_ToInt64_IFormatProvider.SetBelong(this.instance);
				}
				return r_ToInt64_IFormatProvider;
			}
		}

		/// <summary>
		/// UInt64 ToUInt64(System.IFormatProvider)
		/// </summary>
		protected RMethod r_ToUInt64_IFormatProvider;
		public virtual RMethod RToUInt64_IFormatProvider
		{
			get
			{
				if(r_ToUInt64_IFormatProvider == null)
				{
					r_ToUInt64_IFormatProvider = new(this, "ToUInt64", 0, typeof(System.IFormatProvider));
					r_ToUInt64_IFormatProvider.SetBelong(this.instance);
				}
				return r_ToUInt64_IFormatProvider;
			}
		}

		/// <summary>
		/// Single ToSingle(System.IFormatProvider)
		/// </summary>
		protected RMethod r_ToSingle_IFormatProvider;
		public virtual RMethod RToSingle_IFormatProvider
		{
			get
			{
				if(r_ToSingle_IFormatProvider == null)
				{
					r_ToSingle_IFormatProvider = new(this, "ToSingle", 0, typeof(System.IFormatProvider));
					r_ToSingle_IFormatProvider.SetBelong(this.instance);
				}
				return r_ToSingle_IFormatProvider;
			}
		}

		/// <summary>
		/// Double ToDouble(System.IFormatProvider)
		/// </summary>
		protected RMethod r_ToDouble_IFormatProvider;
		public virtual RMethod RToDouble_IFormatProvider
		{
			get
			{
				if(r_ToDouble_IFormatProvider == null)
				{
					r_ToDouble_IFormatProvider = new(this, "ToDouble", 0, typeof(System.IFormatProvider));
					r_ToDouble_IFormatProvider.SetBelong(this.instance);
				}
				return r_ToDouble_IFormatProvider;
			}
		}

		/// <summary>
		/// System.Decimal ToDecimal(System.IFormatProvider)
		/// </summary>
		protected RMethod r_ToDecimal_IFormatProvider;
		public virtual RMethod RToDecimal_IFormatProvider
		{
			get
			{
				if(r_ToDecimal_IFormatProvider == null)
				{
					r_ToDecimal_IFormatProvider = new(this, "ToDecimal", 0, typeof(System.IFormatProvider));
					r_ToDecimal_IFormatProvider.SetBelong(this.instance);
				}
				return r_ToDecimal_IFormatProvider;
			}
		}

		/// <summary>
		/// System.DateTime ToDateTime(System.IFormatProvider)
		/// </summary>
		protected RMethod r_ToDateTime_IFormatProvider;
		public virtual RMethod RToDateTime_IFormatProvider
		{
			get
			{
				if(r_ToDateTime_IFormatProvider == null)
				{
					r_ToDateTime_IFormatProvider = new(this, "ToDateTime", 0, typeof(System.IFormatProvider));
					r_ToDateTime_IFormatProvider.SetBelong(this.instance);
				}
				return r_ToDateTime_IFormatProvider;
			}
		}

		/// <summary>
		/// System.String ToString(System.IFormatProvider)
		/// </summary>
		protected RMethod r_ToString_IFormatProvider;
		public virtual RMethod RToString_IFormatProvider
		{
			get
			{
				if(r_ToString_IFormatProvider == null)
				{
					r_ToString_IFormatProvider = new(this, "ToString", 0, typeof(System.IFormatProvider));
					r_ToString_IFormatProvider.SetBelong(this.instance);
				}
				return r_ToString_IFormatProvider;
			}
		}

		/// <summary>
		/// System.Object ToType(System.Type, System.IFormatProvider)
		/// </summary>
		protected RMethod r_ToType_Type_IFormatProvider;
		public virtual RMethod RToType_Type_IFormatProvider
		{
			get
			{
				if(r_ToType_Type_IFormatProvider == null)
				{
					r_ToType_Type_IFormatProvider = new(this, "ToType", 0, typeof(System.Type), typeof(System.IFormatProvider));
					r_ToType_Type_IFormatProvider.SetBelong(this.instance);
				}
				return r_ToType_Type_IFormatProvider;
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
            var ___result = RGetTypeCode.Invoke(___genericsType, ___parameters);

            return (System.TypeCode)___result;
        }


        public virtual System.Boolean ToBoolean(System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RToBoolean_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Char ToChar(System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RToChar_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public virtual System.SByte ToSByte(System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RToSByte_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.SByte)___result;
        }


        public virtual System.Byte ToByte(System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RToByte_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Byte)___result;
        }


        public virtual System.Int16 ToInt16(System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RToInt16_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Int16)___result;
        }


        public virtual System.UInt16 ToUInt16(System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RToUInt16_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.UInt16)___result;
        }


        public virtual System.Int32 ToInt32(System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RToInt32_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.UInt32 ToUInt32(System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RToUInt32_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual System.Int64 ToInt64(System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RToInt64_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.UInt64 ToUInt64(System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RToUInt64_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public virtual System.Single ToSingle(System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RToSingle_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Double ToDouble(System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RToDouble_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Decimal ToDecimal(System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RToDecimal_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public virtual System.DateTime ToDateTime(System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RToDateTime_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.String ToString(System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Object ToType(System.Type  @conversionType, System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@conversionType, @provider};
            var ___result = RToType_Type_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
