
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.ParameterAttributes
	/// </summary>
    public partial class RParameterAttributes : RMember //
    {

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
					r_Fvalue__.SetBelong(this.GetValue());
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterAttributes None
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RParameterAttributes r_FNone;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RParameterAttributes RFNone
		{
			get
			{
				if(r_FNone == null)
				{
					r_FNone = new(typeof(System.Reflection.ParameterAttributes), "None");
					r_FNone.SetBelong(null);
				}
				return r_FNone;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterAttributes In
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RParameterAttributes r_FIn;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RParameterAttributes RFIn
		{
			get
			{
				if(r_FIn == null)
				{
					r_FIn = new(typeof(System.Reflection.ParameterAttributes), "In");
					r_FIn.SetBelong(null);
				}
				return r_FIn;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterAttributes Out
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RParameterAttributes r_FOut;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RParameterAttributes RFOut
		{
			get
			{
				if(r_FOut == null)
				{
					r_FOut = new(typeof(System.Reflection.ParameterAttributes), "Out");
					r_FOut.SetBelong(null);
				}
				return r_FOut;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterAttributes Lcid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RParameterAttributes r_FLcid;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RParameterAttributes RFLcid
		{
			get
			{
				if(r_FLcid == null)
				{
					r_FLcid = new(typeof(System.Reflection.ParameterAttributes), "Lcid");
					r_FLcid.SetBelong(null);
				}
				return r_FLcid;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterAttributes Retval
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RParameterAttributes r_FRetval;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RParameterAttributes RFRetval
		{
			get
			{
				if(r_FRetval == null)
				{
					r_FRetval = new(typeof(System.Reflection.ParameterAttributes), "Retval");
					r_FRetval.SetBelong(null);
				}
				return r_FRetval;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterAttributes Optional
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RParameterAttributes r_FOptional;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RParameterAttributes RFOptional
		{
			get
			{
				if(r_FOptional == null)
				{
					r_FOptional = new(typeof(System.Reflection.ParameterAttributes), "Optional");
					r_FOptional.SetBelong(null);
				}
				return r_FOptional;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterAttributes HasDefault
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RParameterAttributes r_FHasDefault;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RParameterAttributes RFHasDefault
		{
			get
			{
				if(r_FHasDefault == null)
				{
					r_FHasDefault = new(typeof(System.Reflection.ParameterAttributes), "HasDefault");
					r_FHasDefault.SetBelong(null);
				}
				return r_FHasDefault;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterAttributes HasFieldMarshal
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RParameterAttributes r_FHasFieldMarshal;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RParameterAttributes RFHasFieldMarshal
		{
			get
			{
				if(r_FHasFieldMarshal == null)
				{
					r_FHasFieldMarshal = new(typeof(System.Reflection.ParameterAttributes), "HasFieldMarshal");
					r_FHasFieldMarshal.SetBelong(null);
				}
				return r_FHasFieldMarshal;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterAttributes Reserved3
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RParameterAttributes r_FReserved3;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RParameterAttributes RFReserved3
		{
			get
			{
				if(r_FReserved3 == null)
				{
					r_FReserved3 = new(typeof(System.Reflection.ParameterAttributes), "Reserved3");
					r_FReserved3.SetBelong(null);
				}
				return r_FReserved3;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterAttributes Reserved4
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RParameterAttributes r_FReserved4;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RParameterAttributes RFReserved4
		{
			get
			{
				if(r_FReserved4 == null)
				{
					r_FReserved4 = new(typeof(System.Reflection.ParameterAttributes), "Reserved4");
					r_FReserved4.SetBelong(null);
				}
				return r_FReserved4;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterAttributes ReservedMask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RParameterAttributes r_FReservedMask;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RParameterAttributes RFReservedMask
		{
			get
			{
				if(r_FReservedMask == null)
				{
					r_FReservedMask = new(typeof(System.Reflection.ParameterAttributes), "ReservedMask");
					r_FReservedMask.SetBelong(null);
				}
				return r_FReservedMask;
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
					r_MGetValue.SetBelong(this.GetValue());
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MGetHashCode.SetBelong(this.GetValue());
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
					r_MToString.SetBelong(this.GetValue());
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
					r_MToString_String_IFormatProvider.SetBelong(this.GetValue());
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
					r_MCompareTo_Object.SetBelong(this.GetValue());
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
					r_MToString_String.SetBelong(this.GetValue());
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
					r_MToString_IFormatProvider.SetBelong(this.GetValue());
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
					r_MHasFlag_Enum.SetBelong(this.GetValue());
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
					r_MGetTypeCode.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
				}
				return r_MMemberwiseClone;
			}
		}


        public RParameterAttributes() : base("System.Reflection.ParameterAttributes")
        {
        }

        public RParameterAttributes(System.Object instance) : base("System.Reflection.ParameterAttributes")
		{
            SetInstance(instance);
		}

        public RParameterAttributes(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RParameterAttributes(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
