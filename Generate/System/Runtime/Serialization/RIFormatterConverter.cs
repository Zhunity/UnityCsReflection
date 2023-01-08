using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RSerialization
{
	/// <summary>
	/// System.Runtime.Serialization.IFormatterConverter
	/// </summary>
    public partial class RIFormatterConverter : RMember //
    {

		/// <summary>
		/// System.Object Convert(System.Object, System.Type)
		/// </summary>
		protected RMethod r_Convert_Object_Type;
		public virtual RMethod RConvert_Object_Type
		{
			get
			{
				if(r_Convert_Object_Type == null)
				{
					r_Convert_Object_Type = new(this, "Convert", 0, typeof(System.Object), typeof(System.Type));
					r_Convert_Object_Type.SetBelong(this.instance);
				}
				return r_Convert_Object_Type;
			}
		}

		/// <summary>
		/// System.Object Convert(System.Object, System.TypeCode)
		/// </summary>
		protected RMethod r_Convert_Object_TypeCode;
		public virtual RMethod RConvert_Object_TypeCode
		{
			get
			{
				if(r_Convert_Object_TypeCode == null)
				{
					r_Convert_Object_TypeCode = new(this, "Convert", 0, typeof(System.Object), typeof(System.TypeCode));
					r_Convert_Object_TypeCode.SetBelong(this.instance);
				}
				return r_Convert_Object_TypeCode;
			}
		}

		/// <summary>
		/// Boolean ToBoolean(System.Object)
		/// </summary>
		protected RMethod r_ToBoolean_Object;
		public virtual RMethod RToBoolean_Object
		{
			get
			{
				if(r_ToBoolean_Object == null)
				{
					r_ToBoolean_Object = new(this, "ToBoolean", 0, typeof(System.Object));
					r_ToBoolean_Object.SetBelong(this.instance);
				}
				return r_ToBoolean_Object;
			}
		}

		/// <summary>
		/// Char ToChar(System.Object)
		/// </summary>
		protected RMethod r_ToChar_Object;
		public virtual RMethod RToChar_Object
		{
			get
			{
				if(r_ToChar_Object == null)
				{
					r_ToChar_Object = new(this, "ToChar", 0, typeof(System.Object));
					r_ToChar_Object.SetBelong(this.instance);
				}
				return r_ToChar_Object;
			}
		}

		/// <summary>
		/// SByte ToSByte(System.Object)
		/// </summary>
		protected RMethod r_ToSByte_Object;
		public virtual RMethod RToSByte_Object
		{
			get
			{
				if(r_ToSByte_Object == null)
				{
					r_ToSByte_Object = new(this, "ToSByte", 0, typeof(System.Object));
					r_ToSByte_Object.SetBelong(this.instance);
				}
				return r_ToSByte_Object;
			}
		}

		/// <summary>
		/// Byte ToByte(System.Object)
		/// </summary>
		protected RMethod r_ToByte_Object;
		public virtual RMethod RToByte_Object
		{
			get
			{
				if(r_ToByte_Object == null)
				{
					r_ToByte_Object = new(this, "ToByte", 0, typeof(System.Object));
					r_ToByte_Object.SetBelong(this.instance);
				}
				return r_ToByte_Object;
			}
		}

		/// <summary>
		/// Int16 ToInt16(System.Object)
		/// </summary>
		protected RMethod r_ToInt16_Object;
		public virtual RMethod RToInt16_Object
		{
			get
			{
				if(r_ToInt16_Object == null)
				{
					r_ToInt16_Object = new(this, "ToInt16", 0, typeof(System.Object));
					r_ToInt16_Object.SetBelong(this.instance);
				}
				return r_ToInt16_Object;
			}
		}

		/// <summary>
		/// UInt16 ToUInt16(System.Object)
		/// </summary>
		protected RMethod r_ToUInt16_Object;
		public virtual RMethod RToUInt16_Object
		{
			get
			{
				if(r_ToUInt16_Object == null)
				{
					r_ToUInt16_Object = new(this, "ToUInt16", 0, typeof(System.Object));
					r_ToUInt16_Object.SetBelong(this.instance);
				}
				return r_ToUInt16_Object;
			}
		}

		/// <summary>
		/// Int32 ToInt32(System.Object)
		/// </summary>
		protected RMethod r_ToInt32_Object;
		public virtual RMethod RToInt32_Object
		{
			get
			{
				if(r_ToInt32_Object == null)
				{
					r_ToInt32_Object = new(this, "ToInt32", 0, typeof(System.Object));
					r_ToInt32_Object.SetBelong(this.instance);
				}
				return r_ToInt32_Object;
			}
		}

		/// <summary>
		/// UInt32 ToUInt32(System.Object)
		/// </summary>
		protected RMethod r_ToUInt32_Object;
		public virtual RMethod RToUInt32_Object
		{
			get
			{
				if(r_ToUInt32_Object == null)
				{
					r_ToUInt32_Object = new(this, "ToUInt32", 0, typeof(System.Object));
					r_ToUInt32_Object.SetBelong(this.instance);
				}
				return r_ToUInt32_Object;
			}
		}

		/// <summary>
		/// Int64 ToInt64(System.Object)
		/// </summary>
		protected RMethod r_ToInt64_Object;
		public virtual RMethod RToInt64_Object
		{
			get
			{
				if(r_ToInt64_Object == null)
				{
					r_ToInt64_Object = new(this, "ToInt64", 0, typeof(System.Object));
					r_ToInt64_Object.SetBelong(this.instance);
				}
				return r_ToInt64_Object;
			}
		}

		/// <summary>
		/// UInt64 ToUInt64(System.Object)
		/// </summary>
		protected RMethod r_ToUInt64_Object;
		public virtual RMethod RToUInt64_Object
		{
			get
			{
				if(r_ToUInt64_Object == null)
				{
					r_ToUInt64_Object = new(this, "ToUInt64", 0, typeof(System.Object));
					r_ToUInt64_Object.SetBelong(this.instance);
				}
				return r_ToUInt64_Object;
			}
		}

		/// <summary>
		/// Single ToSingle(System.Object)
		/// </summary>
		protected RMethod r_ToSingle_Object;
		public virtual RMethod RToSingle_Object
		{
			get
			{
				if(r_ToSingle_Object == null)
				{
					r_ToSingle_Object = new(this, "ToSingle", 0, typeof(System.Object));
					r_ToSingle_Object.SetBelong(this.instance);
				}
				return r_ToSingle_Object;
			}
		}

		/// <summary>
		/// Double ToDouble(System.Object)
		/// </summary>
		protected RMethod r_ToDouble_Object;
		public virtual RMethod RToDouble_Object
		{
			get
			{
				if(r_ToDouble_Object == null)
				{
					r_ToDouble_Object = new(this, "ToDouble", 0, typeof(System.Object));
					r_ToDouble_Object.SetBelong(this.instance);
				}
				return r_ToDouble_Object;
			}
		}

		/// <summary>
		/// System.Decimal ToDecimal(System.Object)
		/// </summary>
		protected RMethod r_ToDecimal_Object;
		public virtual RMethod RToDecimal_Object
		{
			get
			{
				if(r_ToDecimal_Object == null)
				{
					r_ToDecimal_Object = new(this, "ToDecimal", 0, typeof(System.Object));
					r_ToDecimal_Object.SetBelong(this.instance);
				}
				return r_ToDecimal_Object;
			}
		}

		/// <summary>
		/// System.DateTime ToDateTime(System.Object)
		/// </summary>
		protected RMethod r_ToDateTime_Object;
		public virtual RMethod RToDateTime_Object
		{
			get
			{
				if(r_ToDateTime_Object == null)
				{
					r_ToDateTime_Object = new(this, "ToDateTime", 0, typeof(System.Object));
					r_ToDateTime_Object.SetBelong(this.instance);
				}
				return r_ToDateTime_Object;
			}
		}

		/// <summary>
		/// System.String ToString(System.Object)
		/// </summary>
		protected RMethod r_ToString_Object;
		public virtual RMethod RToString_Object
		{
			get
			{
				if(r_ToString_Object == null)
				{
					r_ToString_Object = new(this, "ToString", 0, typeof(System.Object));
					r_ToString_Object.SetBelong(this.instance);
				}
				return r_ToString_Object;
			}
		}


        public RIFormatterConverter() : base("System.Runtime.Serialization.IFormatterConverter")
        {
        }

        public RIFormatterConverter(System.Object instance) : base("System.Runtime.Serialization.IFormatterConverter")
		{
            SetInstance(instance);
		}

        public RIFormatterConverter(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIFormatterConverter(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object Convert(System.Object @value, System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @type};
            var ___result = RConvert_Object_Type.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object Convert(System.Object @value, System.TypeCode @typeCode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @typeCode};
            var ___result = RConvert_Object_TypeCode.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean ToBoolean(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToBoolean_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Char ToChar(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToChar_Object.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public virtual System.SByte ToSByte(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToSByte_Object.Invoke(___genericsType, ___parameters);

            return (System.SByte)___result;
        }


        public virtual System.Byte ToByte(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToByte_Object.Invoke(___genericsType, ___parameters);

            return (System.Byte)___result;
        }


        public virtual System.Int16 ToInt16(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToInt16_Object.Invoke(___genericsType, ___parameters);

            return (System.Int16)___result;
        }


        public virtual System.UInt16 ToUInt16(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToUInt16_Object.Invoke(___genericsType, ___parameters);

            return (System.UInt16)___result;
        }


        public virtual System.Int32 ToInt32(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToInt32_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.UInt32 ToUInt32(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToUInt32_Object.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual System.Int64 ToInt64(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToInt64_Object.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.UInt64 ToUInt64(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToUInt64_Object.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public virtual System.Single ToSingle(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToSingle_Object.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Double ToDouble(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDouble_Object.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Decimal ToDecimal(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDecimal_Object.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public virtual System.DateTime ToDateTime(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDateTime_Object.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.String ToString(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToString_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
