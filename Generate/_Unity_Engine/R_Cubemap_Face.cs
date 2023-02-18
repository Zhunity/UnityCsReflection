
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.CubemapFace
	/// </summary>
    public partial class RCubemapFace : RMember //
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
		/// UnityEngine.CubemapFace Unknown
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RCubemapFace r_FUnknown;
		public static Hvak.Editor.Refleaction.RUnityEngine.RCubemapFace RFUnknown
		{
			get
			{
				if(r_FUnknown == null)
				{
					r_FUnknown = new(typeof(UnityEngine.CubemapFace), "Unknown");
					r_FUnknown.SetBelong(null);
				}
				return r_FUnknown;
			}
		}

		/// <summary>
		/// UnityEngine.CubemapFace PositiveX
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RCubemapFace r_FPositiveX;
		public static Hvak.Editor.Refleaction.RUnityEngine.RCubemapFace RFPositiveX
		{
			get
			{
				if(r_FPositiveX == null)
				{
					r_FPositiveX = new(typeof(UnityEngine.CubemapFace), "PositiveX");
					r_FPositiveX.SetBelong(null);
				}
				return r_FPositiveX;
			}
		}

		/// <summary>
		/// UnityEngine.CubemapFace NegativeX
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RCubemapFace r_FNegativeX;
		public static Hvak.Editor.Refleaction.RUnityEngine.RCubemapFace RFNegativeX
		{
			get
			{
				if(r_FNegativeX == null)
				{
					r_FNegativeX = new(typeof(UnityEngine.CubemapFace), "NegativeX");
					r_FNegativeX.SetBelong(null);
				}
				return r_FNegativeX;
			}
		}

		/// <summary>
		/// UnityEngine.CubemapFace PositiveY
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RCubemapFace r_FPositiveY;
		public static Hvak.Editor.Refleaction.RUnityEngine.RCubemapFace RFPositiveY
		{
			get
			{
				if(r_FPositiveY == null)
				{
					r_FPositiveY = new(typeof(UnityEngine.CubemapFace), "PositiveY");
					r_FPositiveY.SetBelong(null);
				}
				return r_FPositiveY;
			}
		}

		/// <summary>
		/// UnityEngine.CubemapFace NegativeY
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RCubemapFace r_FNegativeY;
		public static Hvak.Editor.Refleaction.RUnityEngine.RCubemapFace RFNegativeY
		{
			get
			{
				if(r_FNegativeY == null)
				{
					r_FNegativeY = new(typeof(UnityEngine.CubemapFace), "NegativeY");
					r_FNegativeY.SetBelong(null);
				}
				return r_FNegativeY;
			}
		}

		/// <summary>
		/// UnityEngine.CubemapFace PositiveZ
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RCubemapFace r_FPositiveZ;
		public static Hvak.Editor.Refleaction.RUnityEngine.RCubemapFace RFPositiveZ
		{
			get
			{
				if(r_FPositiveZ == null)
				{
					r_FPositiveZ = new(typeof(UnityEngine.CubemapFace), "PositiveZ");
					r_FPositiveZ.SetBelong(null);
				}
				return r_FPositiveZ;
			}
		}

		/// <summary>
		/// UnityEngine.CubemapFace NegativeZ
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RCubemapFace r_FNegativeZ;
		public static Hvak.Editor.Refleaction.RUnityEngine.RCubemapFace RFNegativeZ
		{
			get
			{
				if(r_FNegativeZ == null)
				{
					r_FNegativeZ = new(typeof(UnityEngine.CubemapFace), "NegativeZ");
					r_FNegativeZ.SetBelong(null);
				}
				return r_FNegativeZ;
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


        public RCubemapFace() : base("UnityEngine.CubemapFace")
        {
        }

        public RCubemapFace(System.Object instance) : base("UnityEngine.CubemapFace")
		{
            SetInstance(instance);
		}

        public RCubemapFace(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCubemapFace(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
