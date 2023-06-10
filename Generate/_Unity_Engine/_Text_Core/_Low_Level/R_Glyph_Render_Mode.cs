
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel
{
	/// <summary>
	/// UnityEngine.TextCore.LowLevel.GlyphRenderMode
	/// </summary>
    public partial class RGlyphRenderMode : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.TextCore.LowLevel.GlyphRenderMode);
            }
        }

        public RGlyphRenderMode() : base("UnityEngine.TextCore.LowLevel.GlyphRenderMode")
        {
        }

        public RGlyphRenderMode(System.Object instance) : base("UnityEngine.TextCore.LowLevel.GlyphRenderMode")
		{
            SetInstance(instance);
		}

        public RGlyphRenderMode(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGlyphRenderMode(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
		/// UnityEngine.TextCore.LowLevel.GlyphRenderMode SMOOTH_HINTED
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphRenderMode r_FSMOOTH_HINTED;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphRenderMode RFSMOOTH_HINTED
		{
			get
			{
				if(r_FSMOOTH_HINTED == null)
				{
					r_FSMOOTH_HINTED = new(typeof(UnityEngine.TextCore.LowLevel.GlyphRenderMode), "SMOOTH_HINTED");
				}
				return r_FSMOOTH_HINTED;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphRenderMode SMOOTH
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphRenderMode r_FSMOOTH;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphRenderMode RFSMOOTH
		{
			get
			{
				if(r_FSMOOTH == null)
				{
					r_FSMOOTH = new(typeof(UnityEngine.TextCore.LowLevel.GlyphRenderMode), "SMOOTH");
				}
				return r_FSMOOTH;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphRenderMode COLOR_HINTED
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphRenderMode r_FCOLOR_HINTED;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphRenderMode RFCOLOR_HINTED
		{
			get
			{
				if(r_FCOLOR_HINTED == null)
				{
					r_FCOLOR_HINTED = new(typeof(UnityEngine.TextCore.LowLevel.GlyphRenderMode), "COLOR_HINTED");
				}
				return r_FCOLOR_HINTED;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphRenderMode COLOR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphRenderMode r_FCOLOR;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphRenderMode RFCOLOR
		{
			get
			{
				if(r_FCOLOR == null)
				{
					r_FCOLOR = new(typeof(UnityEngine.TextCore.LowLevel.GlyphRenderMode), "COLOR");
				}
				return r_FCOLOR;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphRenderMode RASTER_HINTED
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphRenderMode r_FRASTER_HINTED;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphRenderMode RFRASTER_HINTED
		{
			get
			{
				if(r_FRASTER_HINTED == null)
				{
					r_FRASTER_HINTED = new(typeof(UnityEngine.TextCore.LowLevel.GlyphRenderMode), "RASTER_HINTED");
				}
				return r_FRASTER_HINTED;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphRenderMode RASTER
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphRenderMode r_FRASTER;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphRenderMode RFRASTER
		{
			get
			{
				if(r_FRASTER == null)
				{
					r_FRASTER = new(typeof(UnityEngine.TextCore.LowLevel.GlyphRenderMode), "RASTER");
				}
				return r_FRASTER;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphRenderMode SDF
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphRenderMode r_FSDF;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphRenderMode RFSDF
		{
			get
			{
				if(r_FSDF == null)
				{
					r_FSDF = new(typeof(UnityEngine.TextCore.LowLevel.GlyphRenderMode), "SDF");
				}
				return r_FSDF;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphRenderMode SDF8
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphRenderMode r_FSDF8;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphRenderMode RFSDF8
		{
			get
			{
				if(r_FSDF8 == null)
				{
					r_FSDF8 = new(typeof(UnityEngine.TextCore.LowLevel.GlyphRenderMode), "SDF8");
				}
				return r_FSDF8;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphRenderMode SDF16
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphRenderMode r_FSDF16;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphRenderMode RFSDF16
		{
			get
			{
				if(r_FSDF16 == null)
				{
					r_FSDF16 = new(typeof(UnityEngine.TextCore.LowLevel.GlyphRenderMode), "SDF16");
				}
				return r_FSDF16;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphRenderMode SDF32
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphRenderMode r_FSDF32;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphRenderMode RFSDF32
		{
			get
			{
				if(r_FSDF32 == null)
				{
					r_FSDF32 = new(typeof(UnityEngine.TextCore.LowLevel.GlyphRenderMode), "SDF32");
				}
				return r_FSDF32;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphRenderMode SDFAA_HINTED
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphRenderMode r_FSDFAA_HINTED;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphRenderMode RFSDFAA_HINTED
		{
			get
			{
				if(r_FSDFAA_HINTED == null)
				{
					r_FSDFAA_HINTED = new(typeof(UnityEngine.TextCore.LowLevel.GlyphRenderMode), "SDFAA_HINTED");
				}
				return r_FSDFAA_HINTED;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphRenderMode SDFAA
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphRenderMode r_FSDFAA;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphRenderMode RFSDFAA
		{
			get
			{
				if(r_FSDFAA == null)
				{
					r_FSDFAA = new(typeof(UnityEngine.TextCore.LowLevel.GlyphRenderMode), "SDFAA");
				}
				return r_FSDFAA;
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
