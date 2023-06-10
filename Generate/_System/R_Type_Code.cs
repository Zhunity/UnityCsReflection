
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.TypeCode
	/// </summary>
    public partial class RTypeCode : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.TypeCode);
            }
        }

        public RTypeCode() : base("System.TypeCode")
        {
        }

        public RTypeCode(System.Object instance) : base("System.TypeCode")
		{
            SetInstance(instance);
		}

        public RTypeCode(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTypeCode(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 value__
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fvalue__;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFvalue__
		{
			get
			{
				if(r_Fvalue__ == null)
				{
					r_Fvalue__ = new(this, "value__");
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// System.TypeCode Empty
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RTypeCode r_FEmpty;
		public static Hvak.Editor.Refleaction.RSystem.RTypeCode RFEmpty
		{
			get
			{
				if(r_FEmpty == null)
				{
					r_FEmpty = new(typeof(System.TypeCode), "Empty");
				}
				return r_FEmpty;
			}
		}

		/// <summary>
		/// System.TypeCode Object
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RTypeCode r_FObject;
		public static Hvak.Editor.Refleaction.RSystem.RTypeCode RFObject
		{
			get
			{
				if(r_FObject == null)
				{
					r_FObject = new(typeof(System.TypeCode), "Object");
				}
				return r_FObject;
			}
		}

		/// <summary>
		/// System.TypeCode DBNull
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RTypeCode r_FDBNull;
		public static Hvak.Editor.Refleaction.RSystem.RTypeCode RFDBNull
		{
			get
			{
				if(r_FDBNull == null)
				{
					r_FDBNull = new(typeof(System.TypeCode), "DBNull");
				}
				return r_FDBNull;
			}
		}

		/// <summary>
		/// System.TypeCode Boolean
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RTypeCode r_FBoolean;
		public static Hvak.Editor.Refleaction.RSystem.RTypeCode RFBoolean
		{
			get
			{
				if(r_FBoolean == null)
				{
					r_FBoolean = new(typeof(System.TypeCode), "Boolean");
				}
				return r_FBoolean;
			}
		}

		/// <summary>
		/// System.TypeCode Char
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RTypeCode r_FChar;
		public static Hvak.Editor.Refleaction.RSystem.RTypeCode RFChar
		{
			get
			{
				if(r_FChar == null)
				{
					r_FChar = new(typeof(System.TypeCode), "Char");
				}
				return r_FChar;
			}
		}

		/// <summary>
		/// System.TypeCode SByte
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RTypeCode r_FSByte;
		public static Hvak.Editor.Refleaction.RSystem.RTypeCode RFSByte
		{
			get
			{
				if(r_FSByte == null)
				{
					r_FSByte = new(typeof(System.TypeCode), "SByte");
				}
				return r_FSByte;
			}
		}

		/// <summary>
		/// System.TypeCode Byte
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RTypeCode r_FByte;
		public static Hvak.Editor.Refleaction.RSystem.RTypeCode RFByte
		{
			get
			{
				if(r_FByte == null)
				{
					r_FByte = new(typeof(System.TypeCode), "Byte");
				}
				return r_FByte;
			}
		}

		/// <summary>
		/// System.TypeCode Int16
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RTypeCode r_FInt16;
		public static Hvak.Editor.Refleaction.RSystem.RTypeCode RFInt16
		{
			get
			{
				if(r_FInt16 == null)
				{
					r_FInt16 = new(typeof(System.TypeCode), "Int16");
				}
				return r_FInt16;
			}
		}

		/// <summary>
		/// System.TypeCode UInt16
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RTypeCode r_FUInt16;
		public static Hvak.Editor.Refleaction.RSystem.RTypeCode RFUInt16
		{
			get
			{
				if(r_FUInt16 == null)
				{
					r_FUInt16 = new(typeof(System.TypeCode), "UInt16");
				}
				return r_FUInt16;
			}
		}

		/// <summary>
		/// System.TypeCode Int32
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RTypeCode r_FInt32;
		public static Hvak.Editor.Refleaction.RSystem.RTypeCode RFInt32
		{
			get
			{
				if(r_FInt32 == null)
				{
					r_FInt32 = new(typeof(System.TypeCode), "Int32");
				}
				return r_FInt32;
			}
		}

		/// <summary>
		/// System.TypeCode UInt32
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RTypeCode r_FUInt32;
		public static Hvak.Editor.Refleaction.RSystem.RTypeCode RFUInt32
		{
			get
			{
				if(r_FUInt32 == null)
				{
					r_FUInt32 = new(typeof(System.TypeCode), "UInt32");
				}
				return r_FUInt32;
			}
		}

		/// <summary>
		/// System.TypeCode Int64
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RTypeCode r_FInt64;
		public static Hvak.Editor.Refleaction.RSystem.RTypeCode RFInt64
		{
			get
			{
				if(r_FInt64 == null)
				{
					r_FInt64 = new(typeof(System.TypeCode), "Int64");
				}
				return r_FInt64;
			}
		}

		/// <summary>
		/// System.TypeCode UInt64
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RTypeCode r_FUInt64;
		public static Hvak.Editor.Refleaction.RSystem.RTypeCode RFUInt64
		{
			get
			{
				if(r_FUInt64 == null)
				{
					r_FUInt64 = new(typeof(System.TypeCode), "UInt64");
				}
				return r_FUInt64;
			}
		}

		/// <summary>
		/// System.TypeCode Single
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RTypeCode r_FSingle;
		public static Hvak.Editor.Refleaction.RSystem.RTypeCode RFSingle
		{
			get
			{
				if(r_FSingle == null)
				{
					r_FSingle = new(typeof(System.TypeCode), "Single");
				}
				return r_FSingle;
			}
		}

		/// <summary>
		/// System.TypeCode Double
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RTypeCode r_FDouble;
		public static Hvak.Editor.Refleaction.RSystem.RTypeCode RFDouble
		{
			get
			{
				if(r_FDouble == null)
				{
					r_FDouble = new(typeof(System.TypeCode), "Double");
				}
				return r_FDouble;
			}
		}

		/// <summary>
		/// System.TypeCode Decimal
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RTypeCode r_FDecimal;
		public static Hvak.Editor.Refleaction.RSystem.RTypeCode RFDecimal
		{
			get
			{
				if(r_FDecimal == null)
				{
					r_FDecimal = new(typeof(System.TypeCode), "Decimal");
				}
				return r_FDecimal;
			}
		}

		/// <summary>
		/// System.TypeCode DateTime
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RTypeCode r_FDateTime;
		public static Hvak.Editor.Refleaction.RSystem.RTypeCode RFDateTime
		{
			get
			{
				if(r_FDateTime == null)
				{
					r_FDateTime = new(typeof(System.TypeCode), "DateTime");
				}
				return r_FDateTime;
			}
		}

		/// <summary>
		/// System.TypeCode String
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RTypeCode r_FString;
		public static Hvak.Editor.Refleaction.RSystem.RTypeCode RFString
		{
			get
			{
				if(r_FString == null)
				{
					r_FString = new(typeof(System.TypeCode), "String");
				}
				return r_FString;
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
