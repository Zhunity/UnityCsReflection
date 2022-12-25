using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Color
	/// </summary>
    public partial class RColor : RMember //
    {

		/// <summary>
		/// System.Single r
		/// </summary>
		protected RField r_r;
		public virtual RField Rr
		{
			get
			{
				if(r_r == null)
				{
					r_r = new(this, "r");
					r_r.SetBelong(this.instance);
				}
				return r_r;
			}
		}

		/// <summary>
		/// System.Single g
		/// </summary>
		protected RField r_g;
		public virtual RField Rg
		{
			get
			{
				if(r_g == null)
				{
					r_g = new(this, "g");
					r_g.SetBelong(this.instance);
				}
				return r_g;
			}
		}

		/// <summary>
		/// System.Single b
		/// </summary>
		protected RField r_b;
		public virtual RField Rb
		{
			get
			{
				if(r_b == null)
				{
					r_b = new(this, "b");
					r_b.SetBelong(this.instance);
				}
				return r_b;
			}
		}

		/// <summary>
		/// System.Single a
		/// </summary>
		protected RField r_a;
		public virtual RField Ra
		{
			get
			{
				if(r_a == null)
				{
					r_a = new(this, "a");
					r_a.SetBelong(this.instance);
				}
				return r_a;
			}
		}

		/// <summary>
		/// UnityEngine.Color red
		/// </summary>
		protected static RUnityEngine.RColor r_red;
		public static RUnityEngine.RColor Rred
		{
			get
			{
				if(r_red == null)
				{
					r_red = new(typeof(UnityEngine.Color), "red", -1);
					r_red.SetBelong(null);
				}
				return r_red;
			}
		}

		/// <summary>
		/// UnityEngine.Color green
		/// </summary>
		protected static RUnityEngine.RColor r_green;
		public static RUnityEngine.RColor Rgreen
		{
			get
			{
				if(r_green == null)
				{
					r_green = new(typeof(UnityEngine.Color), "green", -1);
					r_green.SetBelong(null);
				}
				return r_green;
			}
		}

		/// <summary>
		/// UnityEngine.Color blue
		/// </summary>
		protected static RUnityEngine.RColor r_blue;
		public static RUnityEngine.RColor Rblue
		{
			get
			{
				if(r_blue == null)
				{
					r_blue = new(typeof(UnityEngine.Color), "blue", -1);
					r_blue.SetBelong(null);
				}
				return r_blue;
			}
		}

		/// <summary>
		/// UnityEngine.Color white
		/// </summary>
		protected static RUnityEngine.RColor r_white;
		public static RUnityEngine.RColor Rwhite
		{
			get
			{
				if(r_white == null)
				{
					r_white = new(typeof(UnityEngine.Color), "white", -1);
					r_white.SetBelong(null);
				}
				return r_white;
			}
		}

		/// <summary>
		/// UnityEngine.Color black
		/// </summary>
		protected static RUnityEngine.RColor r_black;
		public static RUnityEngine.RColor Rblack
		{
			get
			{
				if(r_black == null)
				{
					r_black = new(typeof(UnityEngine.Color), "black", -1);
					r_black.SetBelong(null);
				}
				return r_black;
			}
		}

		/// <summary>
		/// UnityEngine.Color yellow
		/// </summary>
		protected static RUnityEngine.RColor r_yellow;
		public static RUnityEngine.RColor Ryellow
		{
			get
			{
				if(r_yellow == null)
				{
					r_yellow = new(typeof(UnityEngine.Color), "yellow", -1);
					r_yellow.SetBelong(null);
				}
				return r_yellow;
			}
		}

		/// <summary>
		/// UnityEngine.Color cyan
		/// </summary>
		protected static RUnityEngine.RColor r_cyan;
		public static RUnityEngine.RColor Rcyan
		{
			get
			{
				if(r_cyan == null)
				{
					r_cyan = new(typeof(UnityEngine.Color), "cyan", -1);
					r_cyan.SetBelong(null);
				}
				return r_cyan;
			}
		}

		/// <summary>
		/// UnityEngine.Color magenta
		/// </summary>
		protected static RUnityEngine.RColor r_magenta;
		public static RUnityEngine.RColor Rmagenta
		{
			get
			{
				if(r_magenta == null)
				{
					r_magenta = new(typeof(UnityEngine.Color), "magenta", -1);
					r_magenta.SetBelong(null);
				}
				return r_magenta;
			}
		}

		/// <summary>
		/// UnityEngine.Color gray
		/// </summary>
		protected static RUnityEngine.RColor r_gray;
		public static RUnityEngine.RColor Rgray
		{
			get
			{
				if(r_gray == null)
				{
					r_gray = new(typeof(UnityEngine.Color), "gray", -1);
					r_gray.SetBelong(null);
				}
				return r_gray;
			}
		}

		/// <summary>
		/// UnityEngine.Color grey
		/// </summary>
		protected static RUnityEngine.RColor r_grey;
		public static RUnityEngine.RColor Rgrey
		{
			get
			{
				if(r_grey == null)
				{
					r_grey = new(typeof(UnityEngine.Color), "grey", -1);
					r_grey.SetBelong(null);
				}
				return r_grey;
			}
		}

		/// <summary>
		/// UnityEngine.Color clear
		/// </summary>
		protected static RUnityEngine.RColor r_clear;
		public static RUnityEngine.RColor Rclear
		{
			get
			{
				if(r_clear == null)
				{
					r_clear = new(typeof(UnityEngine.Color), "clear", -1);
					r_clear.SetBelong(null);
				}
				return r_clear;
			}
		}

		/// <summary>
		/// Single grayscale
		/// </summary>
		protected RProperty r_grayscale;
		public virtual RProperty Rgrayscale
		{
			get
			{
				if(r_grayscale == null)
				{
					r_grayscale = new(this, "grayscale", -1);
					r_grayscale.SetBelong(this.instance);
				}
				return r_grayscale;
			}
		}

		/// <summary>
		/// UnityEngine.Color linear
		/// </summary>
		protected RUnityEngine.RColor r_linear;
		public virtual RUnityEngine.RColor Rlinear
		{
			get
			{
				if(r_linear == null)
				{
					r_linear = new(this, "linear", -1);
					r_linear.SetBelong(this.instance);
				}
				return r_linear;
			}
		}

		/// <summary>
		/// UnityEngine.Color gamma
		/// </summary>
		protected RUnityEngine.RColor r_gamma;
		public virtual RUnityEngine.RColor Rgamma
		{
			get
			{
				if(r_gamma == null)
				{
					r_gamma = new(this, "gamma", -1);
					r_gamma.SetBelong(this.instance);
				}
				return r_gamma;
			}
		}

		/// <summary>
		/// Single maxColorComponent
		/// </summary>
		protected RProperty r_maxColorComponent;
		public virtual RProperty RmaxColorComponent
		{
			get
			{
				if(r_maxColorComponent == null)
				{
					r_maxColorComponent = new(this, "maxColorComponent", -1);
					r_maxColorComponent.SetBelong(this.instance);
				}
				return r_maxColorComponent;
			}
		}

		/// <summary>
		/// Single Item [Int32]
		/// </summary>
		protected RProperty r_Item_Int32;
		public virtual RProperty RItem_Int32
		{
			get
			{
				if(r_Item_Int32 == null)
				{
					r_Item_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_Item_Int32.SetBelong(this.instance);
				}
				return r_Item_Int32;
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
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_RToString_String;
		public virtual RMethod RToString_String
		{
			get
			{
				if(r_RToString_String == null)
				{
					r_RToString_String = new(this, "ToString", 0, typeof(System.String));
					r_RToString_String.SetBelong(this.instance);
				}
				return r_RToString_String;
			}
		}

		/// <summary>
		/// System.String ToString(System.String, System.IFormatProvider)
		/// </summary>
		protected RMethod r_RToString_String_IFormatProvider;
		public virtual RMethod RToString_String_IFormatProvider
		{
			get
			{
				if(r_RToString_String_IFormatProvider == null)
				{
					r_RToString_String_IFormatProvider = new(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
					r_RToString_String_IFormatProvider.SetBelong(this.instance);
				}
				return r_RToString_String_IFormatProvider;
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
		/// Boolean Equals(UnityEngine.Color)
		/// </summary>
		protected RMethod r_REquals_Color;
		public virtual RMethod REquals_Color
		{
			get
			{
				if(r_REquals_Color == null)
				{
					r_REquals_Color = new(this, "Equals", 0, typeof(UnityEngine.Color));
					r_REquals_Color.SetBelong(this.instance);
				}
				return r_REquals_Color;
			}
		}

		/// <summary>
		/// UnityEngine.Color op_Addition(UnityEngine.Color, UnityEngine.Color)
		/// </summary>
		protected static RMethod r_Rop_Addition_Color_Color;
		public static RMethod Rop_Addition_Color_Color
		{
			get
			{
				if(r_Rop_Addition_Color_Color == null)
				{
					r_Rop_Addition_Color_Color = new(typeof(UnityEngine.Color), "op_Addition", 0, typeof(UnityEngine.Color), typeof(UnityEngine.Color));
					r_Rop_Addition_Color_Color.SetBelong(null);
				}
				return r_Rop_Addition_Color_Color;
			}
		}

		/// <summary>
		/// UnityEngine.Color op_Subtraction(UnityEngine.Color, UnityEngine.Color)
		/// </summary>
		protected static RMethod r_Rop_Subtraction_Color_Color;
		public static RMethod Rop_Subtraction_Color_Color
		{
			get
			{
				if(r_Rop_Subtraction_Color_Color == null)
				{
					r_Rop_Subtraction_Color_Color = new(typeof(UnityEngine.Color), "op_Subtraction", 0, typeof(UnityEngine.Color), typeof(UnityEngine.Color));
					r_Rop_Subtraction_Color_Color.SetBelong(null);
				}
				return r_Rop_Subtraction_Color_Color;
			}
		}

		/// <summary>
		/// UnityEngine.Color op_Multiply(UnityEngine.Color, UnityEngine.Color)
		/// </summary>
		protected static RMethod r_Rop_Multiply_Color_Color;
		public static RMethod Rop_Multiply_Color_Color
		{
			get
			{
				if(r_Rop_Multiply_Color_Color == null)
				{
					r_Rop_Multiply_Color_Color = new(typeof(UnityEngine.Color), "op_Multiply", 0, typeof(UnityEngine.Color), typeof(UnityEngine.Color));
					r_Rop_Multiply_Color_Color.SetBelong(null);
				}
				return r_Rop_Multiply_Color_Color;
			}
		}

		/// <summary>
		/// UnityEngine.Color op_Multiply(UnityEngine.Color, Single)
		/// </summary>
		protected static RMethod r_Rop_Multiply_Color_Single;
		public static RMethod Rop_Multiply_Color_Single
		{
			get
			{
				if(r_Rop_Multiply_Color_Single == null)
				{
					r_Rop_Multiply_Color_Single = new(typeof(UnityEngine.Color), "op_Multiply", 0, typeof(UnityEngine.Color), typeof(System.Single));
					r_Rop_Multiply_Color_Single.SetBelong(null);
				}
				return r_Rop_Multiply_Color_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Color op_Multiply(Single, UnityEngine.Color)
		/// </summary>
		protected static RMethod r_Rop_Multiply_Single_Color;
		public static RMethod Rop_Multiply_Single_Color
		{
			get
			{
				if(r_Rop_Multiply_Single_Color == null)
				{
					r_Rop_Multiply_Single_Color = new(typeof(UnityEngine.Color), "op_Multiply", 0, typeof(System.Single), typeof(UnityEngine.Color));
					r_Rop_Multiply_Single_Color.SetBelong(null);
				}
				return r_Rop_Multiply_Single_Color;
			}
		}

		/// <summary>
		/// UnityEngine.Color op_Division(UnityEngine.Color, Single)
		/// </summary>
		protected static RMethod r_Rop_Division_Color_Single;
		public static RMethod Rop_Division_Color_Single
		{
			get
			{
				if(r_Rop_Division_Color_Single == null)
				{
					r_Rop_Division_Color_Single = new(typeof(UnityEngine.Color), "op_Division", 0, typeof(UnityEngine.Color), typeof(System.Single));
					r_Rop_Division_Color_Single.SetBelong(null);
				}
				return r_Rop_Division_Color_Single;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Color, UnityEngine.Color)
		/// </summary>
		protected static RMethod r_Rop_Equality_Color_Color;
		public static RMethod Rop_Equality_Color_Color
		{
			get
			{
				if(r_Rop_Equality_Color_Color == null)
				{
					r_Rop_Equality_Color_Color = new(typeof(UnityEngine.Color), "op_Equality", 0, typeof(UnityEngine.Color), typeof(UnityEngine.Color));
					r_Rop_Equality_Color_Color.SetBelong(null);
				}
				return r_Rop_Equality_Color_Color;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Color, UnityEngine.Color)
		/// </summary>
		protected static RMethod r_Rop_Inequality_Color_Color;
		public static RMethod Rop_Inequality_Color_Color
		{
			get
			{
				if(r_Rop_Inequality_Color_Color == null)
				{
					r_Rop_Inequality_Color_Color = new(typeof(UnityEngine.Color), "op_Inequality", 0, typeof(UnityEngine.Color), typeof(UnityEngine.Color));
					r_Rop_Inequality_Color_Color.SetBelong(null);
				}
				return r_Rop_Inequality_Color_Color;
			}
		}

		/// <summary>
		/// UnityEngine.Color Lerp(UnityEngine.Color, UnityEngine.Color, Single)
		/// </summary>
		protected static RMethod r_RLerp_Color_Color_Single;
		public static RMethod RLerp_Color_Color_Single
		{
			get
			{
				if(r_RLerp_Color_Color_Single == null)
				{
					r_RLerp_Color_Color_Single = new(typeof(UnityEngine.Color), "Lerp", 0, typeof(UnityEngine.Color), typeof(UnityEngine.Color), typeof(System.Single));
					r_RLerp_Color_Color_Single.SetBelong(null);
				}
				return r_RLerp_Color_Color_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Color LerpUnclamped(UnityEngine.Color, UnityEngine.Color, Single)
		/// </summary>
		protected static RMethod r_RLerpUnclamped_Color_Color_Single;
		public static RMethod RLerpUnclamped_Color_Color_Single
		{
			get
			{
				if(r_RLerpUnclamped_Color_Color_Single == null)
				{
					r_RLerpUnclamped_Color_Color_Single = new(typeof(UnityEngine.Color), "LerpUnclamped", 0, typeof(UnityEngine.Color), typeof(UnityEngine.Color), typeof(System.Single));
					r_RLerpUnclamped_Color_Color_Single.SetBelong(null);
				}
				return r_RLerpUnclamped_Color_Color_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Color RGBMultiplied(Single)
		/// </summary>
		protected RMethod r_RRGBMultiplied_Single;
		public virtual RMethod RRGBMultiplied_Single
		{
			get
			{
				if(r_RRGBMultiplied_Single == null)
				{
					r_RRGBMultiplied_Single = new(this, "RGBMultiplied", 0, typeof(System.Single));
					r_RRGBMultiplied_Single.SetBelong(this.instance);
				}
				return r_RRGBMultiplied_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Color AlphaMultiplied(Single)
		/// </summary>
		protected RMethod r_RAlphaMultiplied_Single;
		public virtual RMethod RAlphaMultiplied_Single
		{
			get
			{
				if(r_RAlphaMultiplied_Single == null)
				{
					r_RAlphaMultiplied_Single = new(this, "AlphaMultiplied", 0, typeof(System.Single));
					r_RAlphaMultiplied_Single.SetBelong(this.instance);
				}
				return r_RAlphaMultiplied_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Color RGBMultiplied(UnityEngine.Color)
		/// </summary>
		protected RMethod r_RRGBMultiplied_Color;
		public virtual RMethod RRGBMultiplied_Color
		{
			get
			{
				if(r_RRGBMultiplied_Color == null)
				{
					r_RRGBMultiplied_Color = new(this, "RGBMultiplied", 0, typeof(UnityEngine.Color));
					r_RRGBMultiplied_Color.SetBelong(this.instance);
				}
				return r_RRGBMultiplied_Color;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 op_Implicit(UnityEngine.Color)
		/// </summary>
		protected static RMethod r_Rop_Implicit_Color;
		public static RMethod Rop_Implicit_Color
		{
			get
			{
				if(r_Rop_Implicit_Color == null)
				{
					r_Rop_Implicit_Color = new(typeof(UnityEngine.Color), "op_Implicit", 0, typeof(UnityEngine.Color));
					r_Rop_Implicit_Color.SetBelong(null);
				}
				return r_Rop_Implicit_Color;
			}
		}

		/// <summary>
		/// UnityEngine.Color op_Implicit(UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_Rop_Implicit_Vector4;
		public static RMethod Rop_Implicit_Vector4
		{
			get
			{
				if(r_Rop_Implicit_Vector4 == null)
				{
					r_Rop_Implicit_Vector4 = new(typeof(UnityEngine.Color), "op_Implicit", 0, typeof(UnityEngine.Vector4));
					r_Rop_Implicit_Vector4.SetBelong(null);
				}
				return r_Rop_Implicit_Vector4;
			}
		}

		/// <summary>
		/// Void RGBToHSV(UnityEngine.Color, Single ByRef, Single ByRef, Single ByRef)
		/// </summary>
		protected static RMethod r_RRGBToHSV_Color_Out_Single_Out_Single_Out_Single;
		public static RMethod RRGBToHSV_Color_Out_Single_Out_Single_Out_Single
		{
			get
			{
				if(r_RRGBToHSV_Color_Out_Single_Out_Single_Out_Single == null)
				{
					r_RRGBToHSV_Color_Out_Single_Out_Single_Out_Single = new(typeof(UnityEngine.Color), "RGBToHSV", 0, typeof(UnityEngine.Color), typeof(System.Single).MakeByRefType(), typeof(System.Single).MakeByRefType(), typeof(System.Single).MakeByRefType());
					r_RRGBToHSV_Color_Out_Single_Out_Single_Out_Single.SetBelong(null);
				}
				return r_RRGBToHSV_Color_Out_Single_Out_Single_Out_Single;
			}
		}

		/// <summary>
		/// Void RGBToHSVHelper(Single, Single, Single, Single, Single ByRef, Single ByRef, Single ByRef)
		/// </summary>
		protected static RMethod r_RRGBToHSVHelper_Single_Single_Single_Single_Out_Single_Out_Single_Out_Single;
		public static RMethod RRGBToHSVHelper_Single_Single_Single_Single_Out_Single_Out_Single_Out_Single
		{
			get
			{
				if(r_RRGBToHSVHelper_Single_Single_Single_Single_Out_Single_Out_Single_Out_Single == null)
				{
					r_RRGBToHSVHelper_Single_Single_Single_Single_Out_Single_Out_Single_Out_Single = new(typeof(UnityEngine.Color), "RGBToHSVHelper", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single).MakeByRefType(), typeof(System.Single).MakeByRefType(), typeof(System.Single).MakeByRefType());
					r_RRGBToHSVHelper_Single_Single_Single_Single_Out_Single_Out_Single_Out_Single.SetBelong(null);
				}
				return r_RRGBToHSVHelper_Single_Single_Single_Single_Out_Single_Out_Single_Out_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Color HSVToRGB(Single, Single, Single)
		/// </summary>
		protected static RMethod r_RHSVToRGB_Single_Single_Single;
		public static RMethod RHSVToRGB_Single_Single_Single
		{
			get
			{
				if(r_RHSVToRGB_Single_Single_Single == null)
				{
					r_RHSVToRGB_Single_Single_Single = new(typeof(UnityEngine.Color), "HSVToRGB", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_RHSVToRGB_Single_Single_Single.SetBelong(null);
				}
				return r_RHSVToRGB_Single_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Color HSVToRGB(Single, Single, Single, Boolean)
		/// </summary>
		protected static RMethod r_RHSVToRGB_Single_Single_Single_Boolean;
		public static RMethod RHSVToRGB_Single_Single_Single_Boolean
		{
			get
			{
				if(r_RHSVToRGB_Single_Single_Single_Boolean == null)
				{
					r_RHSVToRGB_Single_Single_Single_Boolean = new(typeof(UnityEngine.Color), "HSVToRGB", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Boolean));
					r_RHSVToRGB_Single_Single_Single_Boolean.SetBelong(null);
				}
				return r_RHSVToRGB_Single_Single_Single_Boolean;
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


        public RColor() : base("UnityEngine.Color")
        {
        }

        public RColor(System.Object instance) : base("UnityEngine.Color")
		{
            SetInstance(instance);
		}

        public RColor(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RColor(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String  @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String  @format, System.IFormatProvider  @formatProvider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @formatProvider};
            var ___result = RToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.Color  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Color.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.Color op_Addition(UnityEngine.Color  @a, UnityEngine.Color  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Addition_Color_Color.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public static UnityEngine.Color op_Subtraction(UnityEngine.Color  @a, UnityEngine.Color  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Subtraction_Color_Color.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public static UnityEngine.Color op_Multiply(UnityEngine.Color  @a, UnityEngine.Color  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Multiply_Color_Color.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public static UnityEngine.Color op_Multiply(UnityEngine.Color  @a, System.Single  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Multiply_Color_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public static UnityEngine.Color op_Multiply(System.Single  @b, UnityEngine.Color  @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@b, @a};
            var ___result = Rop_Multiply_Single_Color.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public static UnityEngine.Color op_Division(UnityEngine.Color  @a, System.Single  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Division_Color_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Color  @lhs, UnityEngine.Color  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_Color_Color.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Color  @lhs, UnityEngine.Color  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_Color_Color.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.Color Lerp(UnityEngine.Color  @a, UnityEngine.Color  @b, System.Single  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RLerp_Color_Color_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public static UnityEngine.Color LerpUnclamped(UnityEngine.Color  @a, UnityEngine.Color  @b, System.Single  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RLerpUnclamped_Color_Color_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual UnityEngine.Color RGBMultiplied(System.Single  @multiplier)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@multiplier};
            var ___result = RRGBMultiplied_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual UnityEngine.Color AlphaMultiplied(System.Single  @multiplier)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@multiplier};
            var ___result = RAlphaMultiplied_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual UnityEngine.Color RGBMultiplied(UnityEngine.Color  @multiplier)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@multiplier};
            var ___result = RRGBMultiplied_Color.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public static UnityEngine.Vector4 op_Implicit(UnityEngine.Color  @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = Rop_Implicit_Color.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Color op_Implicit(UnityEngine.Vector4  @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = Rop_Implicit_Vector4.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public static void RGBToHSV(UnityEngine.Color  @rgbColor, out System.Single  @H, out System.Single  @S, out System.Single  @V)
        {
			H = default;
			S = default;
			V = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rgbColor, @H, @S, @V};
            var ___result = RRGBToHSV_Color_Out_Single_Out_Single_Out_Single.Invoke(___genericsType, ___parameters);
			H = (System.Single)___parameters[1];
			S = (System.Single)___parameters[2];
			V = (System.Single)___parameters[3];

            
        }


        public static void RGBToHSVHelper(System.Single  @offset, System.Single  @dominantcolor, System.Single  @colorone, System.Single  @colortwo, out System.Single  @H, out System.Single  @S, out System.Single  @V)
        {
			H = default;
			S = default;
			V = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@offset, @dominantcolor, @colorone, @colortwo, @H, @S, @V};
            var ___result = RRGBToHSVHelper_Single_Single_Single_Single_Out_Single_Out_Single_Out_Single.Invoke(___genericsType, ___parameters);
			H = (System.Single)___parameters[4];
			S = (System.Single)___parameters[5];
			V = (System.Single)___parameters[6];

            
        }


        public static UnityEngine.Color HSVToRGB(System.Single  @H, System.Single  @S, System.Single  @V)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@H, @S, @V};
            var ___result = RHSVToRGB_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public static UnityEngine.Color HSVToRGB(System.Single  @H, System.Single  @S, System.Single  @V, System.Boolean  @hdr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@H, @S, @V, @hdr};
            var ___result = RHSVToRGB_Single_Single_Single_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
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
