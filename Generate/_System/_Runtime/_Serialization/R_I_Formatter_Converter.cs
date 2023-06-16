
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.Runtime.Serialization.IFormatterConverter
	/// </summary>
    public partial class RIFormatterConverter : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Runtime.Serialization.IFormatterConverter);
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


		/// <summary>
		/// System.Object Convert(System.Object, System.Type)
		/// </summary>
		protected RMethod r_MConvert_Object_Type;
		public virtual RMethod RMConvert_Object_Type
		{
			get
			{
				if(r_MConvert_Object_Type == null)
				{
					r_MConvert_Object_Type = new(this, "Convert", 0, typeof(System.Object), typeof(System.Type));
				}
				return r_MConvert_Object_Type;
			}
		}

		/// <summary>
		/// System.Object Convert(System.Object, System.TypeCode)
		/// </summary>
		protected RMethod r_MConvert_Object_TypeCode;
		public virtual RMethod RMConvert_Object_TypeCode
		{
			get
			{
				if(r_MConvert_Object_TypeCode == null)
				{
					r_MConvert_Object_TypeCode = new(this, "Convert", 0, typeof(System.Object), typeof(System.TypeCode));
				}
				return r_MConvert_Object_TypeCode;
			}
		}

		/// <summary>
		/// Boolean ToBoolean(System.Object)
		/// </summary>
		protected RMethod r_MToBoolean_Object;
		public virtual RMethod RMToBoolean_Object
		{
			get
			{
				if(r_MToBoolean_Object == null)
				{
					r_MToBoolean_Object = new(this, "ToBoolean", 0, typeof(System.Object));
				}
				return r_MToBoolean_Object;
			}
		}

		/// <summary>
		/// Char ToChar(System.Object)
		/// </summary>
		protected RMethod r_MToChar_Object;
		public virtual RMethod RMToChar_Object
		{
			get
			{
				if(r_MToChar_Object == null)
				{
					r_MToChar_Object = new(this, "ToChar", 0, typeof(System.Object));
				}
				return r_MToChar_Object;
			}
		}

		/// <summary>
		/// SByte ToSByte(System.Object)
		/// </summary>
		protected RMethod r_MToSByte_Object;
		public virtual RMethod RMToSByte_Object
		{
			get
			{
				if(r_MToSByte_Object == null)
				{
					r_MToSByte_Object = new(this, "ToSByte", 0, typeof(System.Object));
				}
				return r_MToSByte_Object;
			}
		}

		/// <summary>
		/// Byte ToByte(System.Object)
		/// </summary>
		protected RMethod r_MToByte_Object;
		public virtual RMethod RMToByte_Object
		{
			get
			{
				if(r_MToByte_Object == null)
				{
					r_MToByte_Object = new(this, "ToByte", 0, typeof(System.Object));
				}
				return r_MToByte_Object;
			}
		}

		/// <summary>
		/// Int16 ToInt16(System.Object)
		/// </summary>
		protected RMethod r_MToInt16_Object;
		public virtual RMethod RMToInt16_Object
		{
			get
			{
				if(r_MToInt16_Object == null)
				{
					r_MToInt16_Object = new(this, "ToInt16", 0, typeof(System.Object));
				}
				return r_MToInt16_Object;
			}
		}

		/// <summary>
		/// UInt16 ToUInt16(System.Object)
		/// </summary>
		protected RMethod r_MToUInt16_Object;
		public virtual RMethod RMToUInt16_Object
		{
			get
			{
				if(r_MToUInt16_Object == null)
				{
					r_MToUInt16_Object = new(this, "ToUInt16", 0, typeof(System.Object));
				}
				return r_MToUInt16_Object;
			}
		}

		/// <summary>
		/// Int32 ToInt32(System.Object)
		/// </summary>
		protected RMethod r_MToInt32_Object;
		public virtual RMethod RMToInt32_Object
		{
			get
			{
				if(r_MToInt32_Object == null)
				{
					r_MToInt32_Object = new(this, "ToInt32", 0, typeof(System.Object));
				}
				return r_MToInt32_Object;
			}
		}

		/// <summary>
		/// UInt32 ToUInt32(System.Object)
		/// </summary>
		protected RMethod r_MToUInt32_Object;
		public virtual RMethod RMToUInt32_Object
		{
			get
			{
				if(r_MToUInt32_Object == null)
				{
					r_MToUInt32_Object = new(this, "ToUInt32", 0, typeof(System.Object));
				}
				return r_MToUInt32_Object;
			}
		}

		/// <summary>
		/// Int64 ToInt64(System.Object)
		/// </summary>
		protected RMethod r_MToInt64_Object;
		public virtual RMethod RMToInt64_Object
		{
			get
			{
				if(r_MToInt64_Object == null)
				{
					r_MToInt64_Object = new(this, "ToInt64", 0, typeof(System.Object));
				}
				return r_MToInt64_Object;
			}
		}

		/// <summary>
		/// UInt64 ToUInt64(System.Object)
		/// </summary>
		protected RMethod r_MToUInt64_Object;
		public virtual RMethod RMToUInt64_Object
		{
			get
			{
				if(r_MToUInt64_Object == null)
				{
					r_MToUInt64_Object = new(this, "ToUInt64", 0, typeof(System.Object));
				}
				return r_MToUInt64_Object;
			}
		}

		/// <summary>
		/// Single ToSingle(System.Object)
		/// </summary>
		protected RMethod r_MToSingle_Object;
		public virtual RMethod RMToSingle_Object
		{
			get
			{
				if(r_MToSingle_Object == null)
				{
					r_MToSingle_Object = new(this, "ToSingle", 0, typeof(System.Object));
				}
				return r_MToSingle_Object;
			}
		}

		/// <summary>
		/// Double ToDouble(System.Object)
		/// </summary>
		protected RMethod r_MToDouble_Object;
		public virtual RMethod RMToDouble_Object
		{
			get
			{
				if(r_MToDouble_Object == null)
				{
					r_MToDouble_Object = new(this, "ToDouble", 0, typeof(System.Object));
				}
				return r_MToDouble_Object;
			}
		}

		/// <summary>
		/// System.Decimal ToDecimal(System.Object)
		/// </summary>
		protected RMethod r_MToDecimal_Object;
		public virtual RMethod RMToDecimal_Object
		{
			get
			{
				if(r_MToDecimal_Object == null)
				{
					r_MToDecimal_Object = new(this, "ToDecimal", 0, typeof(System.Object));
				}
				return r_MToDecimal_Object;
			}
		}

		/// <summary>
		/// System.DateTime ToDateTime(System.Object)
		/// </summary>
		protected RMethod r_MToDateTime_Object;
		public virtual RMethod RMToDateTime_Object
		{
			get
			{
				if(r_MToDateTime_Object == null)
				{
					r_MToDateTime_Object = new(this, "ToDateTime", 0, typeof(System.Object));
				}
				return r_MToDateTime_Object;
			}
		}

		/// <summary>
		/// System.String ToString(System.Object)
		/// </summary>
		protected RMethod r_MToString_Object;
		public virtual RMethod RMToString_Object
		{
			get
			{
				if(r_MToString_Object == null)
				{
					r_MToString_Object = new(this, "ToString", 0, typeof(System.Object));
				}
				return r_MToString_Object;
			}
		}


        public virtual System.Object Convert(System.Object @value, System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @type};
            var ___result = RMConvert_Object_Type.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Object Convert(System.Object @value, System.TypeCode @typeCode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @typeCode};
            var ___result = RMConvert_Object_TypeCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Boolean ToBoolean(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMToBoolean_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Char ToChar(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMToChar_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Char>(___result);
        }


        public virtual System.SByte ToSByte(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMToSByte_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.SByte>(___result);
        }


        public virtual System.Byte ToByte(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMToByte_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Byte>(___result);
        }


        public virtual System.Int16 ToInt16(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMToInt16_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int16>(___result);
        }


        public virtual System.UInt16 ToUInt16(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMToUInt16_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.UInt16>(___result);
        }


        public virtual System.Int32 ToInt32(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMToInt32_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.UInt32 ToUInt32(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMToUInt32_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.UInt32>(___result);
        }


        public virtual System.Int64 ToInt64(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMToInt64_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int64>(___result);
        }


        public virtual System.UInt64 ToUInt64(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMToUInt64_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.UInt64>(___result);
        }


        public virtual System.Single ToSingle(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMToSingle_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public virtual System.Double ToDouble(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMToDouble_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Double>(___result);
        }


        public virtual System.Decimal ToDecimal(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMToDecimal_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Decimal>(___result);
        }


        public virtual System.DateTime ToDateTime(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMToDateTime_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.DateTime>(___result);
        }


        public virtual System.String ToString(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMToString_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
