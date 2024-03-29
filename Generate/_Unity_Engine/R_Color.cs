
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.Color
	/// </summary>
    public partial class RColor : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.Color);
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


		/// <summary>
		/// System.Single r
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fr;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFr
		{
			get
			{
				if(r_Fr == null)
				{
					r_Fr = new(this, "r");
				}
				return r_Fr;
			}
		}

		/// <summary>
		/// System.Single g
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fg;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFg
		{
			get
			{
				if(r_Fg == null)
				{
					r_Fg = new(this, "g");
				}
				return r_Fg;
			}
		}

		/// <summary>
		/// System.Single b
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fb;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFb
		{
			get
			{
				if(r_Fb == null)
				{
					r_Fb = new(this, "b");
				}
				return r_Fb;
			}
		}

		/// <summary>
		/// System.Single a
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fa;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFa
		{
			get
			{
				if(r_Fa == null)
				{
					r_Fa = new(this, "a");
				}
				return r_Fa;
			}
		}

		/// <summary>
		/// UnityEngine.Color red
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RColor r_Pred;
		public static Hvak.Editor.Refleaction.RUnityEngine.RColor RPred
		{
			get
			{
				if(r_Pred == null)
				{
					r_Pred = new(Type, "red", -1);
				}
				return r_Pred;
			}
		}

		/// <summary>
		/// UnityEngine.Color green
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RColor r_Pgreen;
		public static Hvak.Editor.Refleaction.RUnityEngine.RColor RPgreen
		{
			get
			{
				if(r_Pgreen == null)
				{
					r_Pgreen = new(Type, "green", -1);
				}
				return r_Pgreen;
			}
		}

		/// <summary>
		/// UnityEngine.Color blue
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RColor r_Pblue;
		public static Hvak.Editor.Refleaction.RUnityEngine.RColor RPblue
		{
			get
			{
				if(r_Pblue == null)
				{
					r_Pblue = new(Type, "blue", -1);
				}
				return r_Pblue;
			}
		}

		/// <summary>
		/// UnityEngine.Color white
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RColor r_Pwhite;
		public static Hvak.Editor.Refleaction.RUnityEngine.RColor RPwhite
		{
			get
			{
				if(r_Pwhite == null)
				{
					r_Pwhite = new(Type, "white", -1);
				}
				return r_Pwhite;
			}
		}

		/// <summary>
		/// UnityEngine.Color black
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RColor r_Pblack;
		public static Hvak.Editor.Refleaction.RUnityEngine.RColor RPblack
		{
			get
			{
				if(r_Pblack == null)
				{
					r_Pblack = new(Type, "black", -1);
				}
				return r_Pblack;
			}
		}

		/// <summary>
		/// UnityEngine.Color yellow
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RColor r_Pyellow;
		public static Hvak.Editor.Refleaction.RUnityEngine.RColor RPyellow
		{
			get
			{
				if(r_Pyellow == null)
				{
					r_Pyellow = new(Type, "yellow", -1);
				}
				return r_Pyellow;
			}
		}

		/// <summary>
		/// UnityEngine.Color cyan
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RColor r_Pcyan;
		public static Hvak.Editor.Refleaction.RUnityEngine.RColor RPcyan
		{
			get
			{
				if(r_Pcyan == null)
				{
					r_Pcyan = new(Type, "cyan", -1);
				}
				return r_Pcyan;
			}
		}

		/// <summary>
		/// UnityEngine.Color magenta
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RColor r_Pmagenta;
		public static Hvak.Editor.Refleaction.RUnityEngine.RColor RPmagenta
		{
			get
			{
				if(r_Pmagenta == null)
				{
					r_Pmagenta = new(Type, "magenta", -1);
				}
				return r_Pmagenta;
			}
		}

		/// <summary>
		/// UnityEngine.Color gray
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RColor r_Pgray;
		public static Hvak.Editor.Refleaction.RUnityEngine.RColor RPgray
		{
			get
			{
				if(r_Pgray == null)
				{
					r_Pgray = new(Type, "gray", -1);
				}
				return r_Pgray;
			}
		}

		/// <summary>
		/// UnityEngine.Color grey
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RColor r_Pgrey;
		public static Hvak.Editor.Refleaction.RUnityEngine.RColor RPgrey
		{
			get
			{
				if(r_Pgrey == null)
				{
					r_Pgrey = new(Type, "grey", -1);
				}
				return r_Pgrey;
			}
		}

		/// <summary>
		/// UnityEngine.Color clear
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RColor r_Pclear;
		public static Hvak.Editor.Refleaction.RUnityEngine.RColor RPclear
		{
			get
			{
				if(r_Pclear == null)
				{
					r_Pclear = new(Type, "clear", -1);
				}
				return r_Pclear;
			}
		}

		/// <summary>
		/// Single grayscale
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pgrayscale;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPgrayscale
		{
			get
			{
				if(r_Pgrayscale == null)
				{
					r_Pgrayscale = new(this, "grayscale", -1);
				}
				return r_Pgrayscale;
			}
		}

		/// <summary>
		/// UnityEngine.Color linear
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_Plinear;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RPlinear
		{
			get
			{
				if(r_Plinear == null)
				{
					r_Plinear = new(this, "linear", -1);
				}
				return r_Plinear;
			}
		}

		/// <summary>
		/// UnityEngine.Color gamma
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_Pgamma;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RPgamma
		{
			get
			{
				if(r_Pgamma == null)
				{
					r_Pgamma = new(this, "gamma", -1);
				}
				return r_Pgamma;
			}
		}

		/// <summary>
		/// Single maxColorComponent
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PmaxColorComponent;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPmaxColorComponent
		{
			get
			{
				if(r_PmaxColorComponent == null)
				{
					r_PmaxColorComponent = new(this, "maxColorComponent", -1);
				}
				return r_PmaxColorComponent;
			}
		}

		/// <summary>
		/// Single Item [Int32]
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PItem_Int32;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPItem_Int32
		{
			get
			{
				if(r_PItem_Int32 == null)
				{
					r_PItem_Int32 = new(this, "Item", -1, typeof(System.Int32));
				}
				return r_PItem_Int32;
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
		/// Boolean Equals(UnityEngine.Color)
		/// </summary>
		protected RMethod r_MEquals_Color;
		public virtual RMethod RMEquals_Color
		{
			get
			{
				if(r_MEquals_Color == null)
				{
					r_MEquals_Color = new(this, "Equals", 0, typeof(UnityEngine.Color));
				}
				return r_MEquals_Color;
			}
		}

		/// <summary>
		/// UnityEngine.Color op_Addition(UnityEngine.Color, UnityEngine.Color)
		/// </summary>
		protected static RMethod r_Mop_Addition_Color_Color;
		public static RMethod RMop_Addition_Color_Color
		{
			get
			{
				if(r_Mop_Addition_Color_Color == null)
				{
					r_Mop_Addition_Color_Color = new(Type, "op_Addition", 0, typeof(UnityEngine.Color), typeof(UnityEngine.Color));
				}
				return r_Mop_Addition_Color_Color;
			}
		}

		/// <summary>
		/// UnityEngine.Color op_Subtraction(UnityEngine.Color, UnityEngine.Color)
		/// </summary>
		protected static RMethod r_Mop_Subtraction_Color_Color;
		public static RMethod RMop_Subtraction_Color_Color
		{
			get
			{
				if(r_Mop_Subtraction_Color_Color == null)
				{
					r_Mop_Subtraction_Color_Color = new(Type, "op_Subtraction", 0, typeof(UnityEngine.Color), typeof(UnityEngine.Color));
				}
				return r_Mop_Subtraction_Color_Color;
			}
		}

		/// <summary>
		/// UnityEngine.Color op_Multiply(UnityEngine.Color, UnityEngine.Color)
		/// </summary>
		protected static RMethod r_Mop_Multiply_Color_Color;
		public static RMethod RMop_Multiply_Color_Color
		{
			get
			{
				if(r_Mop_Multiply_Color_Color == null)
				{
					r_Mop_Multiply_Color_Color = new(Type, "op_Multiply", 0, typeof(UnityEngine.Color), typeof(UnityEngine.Color));
				}
				return r_Mop_Multiply_Color_Color;
			}
		}

		/// <summary>
		/// UnityEngine.Color op_Multiply(UnityEngine.Color, Single)
		/// </summary>
		protected static RMethod r_Mop_Multiply_Color_Single;
		public static RMethod RMop_Multiply_Color_Single
		{
			get
			{
				if(r_Mop_Multiply_Color_Single == null)
				{
					r_Mop_Multiply_Color_Single = new(Type, "op_Multiply", 0, typeof(UnityEngine.Color), typeof(System.Single));
				}
				return r_Mop_Multiply_Color_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Color op_Multiply(Single, UnityEngine.Color)
		/// </summary>
		protected static RMethod r_Mop_Multiply_Single_Color;
		public static RMethod RMop_Multiply_Single_Color
		{
			get
			{
				if(r_Mop_Multiply_Single_Color == null)
				{
					r_Mop_Multiply_Single_Color = new(Type, "op_Multiply", 0, typeof(System.Single), typeof(UnityEngine.Color));
				}
				return r_Mop_Multiply_Single_Color;
			}
		}

		/// <summary>
		/// UnityEngine.Color op_Division(UnityEngine.Color, Single)
		/// </summary>
		protected static RMethod r_Mop_Division_Color_Single;
		public static RMethod RMop_Division_Color_Single
		{
			get
			{
				if(r_Mop_Division_Color_Single == null)
				{
					r_Mop_Division_Color_Single = new(Type, "op_Division", 0, typeof(UnityEngine.Color), typeof(System.Single));
				}
				return r_Mop_Division_Color_Single;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Color, UnityEngine.Color)
		/// </summary>
		protected static RMethod r_Mop_Equality_Color_Color;
		public static RMethod RMop_Equality_Color_Color
		{
			get
			{
				if(r_Mop_Equality_Color_Color == null)
				{
					r_Mop_Equality_Color_Color = new(Type, "op_Equality", 0, typeof(UnityEngine.Color), typeof(UnityEngine.Color));
				}
				return r_Mop_Equality_Color_Color;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Color, UnityEngine.Color)
		/// </summary>
		protected static RMethod r_Mop_Inequality_Color_Color;
		public static RMethod RMop_Inequality_Color_Color
		{
			get
			{
				if(r_Mop_Inequality_Color_Color == null)
				{
					r_Mop_Inequality_Color_Color = new(Type, "op_Inequality", 0, typeof(UnityEngine.Color), typeof(UnityEngine.Color));
				}
				return r_Mop_Inequality_Color_Color;
			}
		}

		/// <summary>
		/// UnityEngine.Color Lerp(UnityEngine.Color, UnityEngine.Color, Single)
		/// </summary>
		protected static RMethod r_MLerp_Color_Color_Single;
		public static RMethod RMLerp_Color_Color_Single
		{
			get
			{
				if(r_MLerp_Color_Color_Single == null)
				{
					r_MLerp_Color_Color_Single = new(Type, "Lerp", 0, typeof(UnityEngine.Color), typeof(UnityEngine.Color), typeof(System.Single));
				}
				return r_MLerp_Color_Color_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Color LerpUnclamped(UnityEngine.Color, UnityEngine.Color, Single)
		/// </summary>
		protected static RMethod r_MLerpUnclamped_Color_Color_Single;
		public static RMethod RMLerpUnclamped_Color_Color_Single
		{
			get
			{
				if(r_MLerpUnclamped_Color_Color_Single == null)
				{
					r_MLerpUnclamped_Color_Color_Single = new(Type, "LerpUnclamped", 0, typeof(UnityEngine.Color), typeof(UnityEngine.Color), typeof(System.Single));
				}
				return r_MLerpUnclamped_Color_Color_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Color RGBMultiplied(Single)
		/// </summary>
		protected RMethod r_MRGBMultiplied_Single;
		public virtual RMethod RMRGBMultiplied_Single
		{
			get
			{
				if(r_MRGBMultiplied_Single == null)
				{
					r_MRGBMultiplied_Single = new(this, "RGBMultiplied", 0, typeof(System.Single));
				}
				return r_MRGBMultiplied_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Color AlphaMultiplied(Single)
		/// </summary>
		protected RMethod r_MAlphaMultiplied_Single;
		public virtual RMethod RMAlphaMultiplied_Single
		{
			get
			{
				if(r_MAlphaMultiplied_Single == null)
				{
					r_MAlphaMultiplied_Single = new(this, "AlphaMultiplied", 0, typeof(System.Single));
				}
				return r_MAlphaMultiplied_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Color RGBMultiplied(UnityEngine.Color)
		/// </summary>
		protected RMethod r_MRGBMultiplied_Color;
		public virtual RMethod RMRGBMultiplied_Color
		{
			get
			{
				if(r_MRGBMultiplied_Color == null)
				{
					r_MRGBMultiplied_Color = new(this, "RGBMultiplied", 0, typeof(UnityEngine.Color));
				}
				return r_MRGBMultiplied_Color;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 op_Implicit(UnityEngine.Color)
		/// </summary>
		protected static RMethod r_Mop_Implicit_Color;
		public static RMethod RMop_Implicit_Color
		{
			get
			{
				if(r_Mop_Implicit_Color == null)
				{
					r_Mop_Implicit_Color = new(Type, "op_Implicit", 0, typeof(UnityEngine.Color));
				}
				return r_Mop_Implicit_Color;
			}
		}

		/// <summary>
		/// UnityEngine.Color op_Implicit(UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_Mop_Implicit_Vector4;
		public static RMethod RMop_Implicit_Vector4
		{
			get
			{
				if(r_Mop_Implicit_Vector4 == null)
				{
					r_Mop_Implicit_Vector4 = new(Type, "op_Implicit", 0, typeof(UnityEngine.Vector4));
				}
				return r_Mop_Implicit_Vector4;
			}
		}

		/// <summary>
		/// Void RGBToHSV(UnityEngine.Color, Single ByRef, Single ByRef, Single ByRef)
		/// </summary>
		protected static RMethod r_MRGBToHSV_Color_Out_Single_Out_Single_Out_Single;
		public static RMethod RMRGBToHSV_Color_Out_Single_Out_Single_Out_Single
		{
			get
			{
				if(r_MRGBToHSV_Color_Out_Single_Out_Single_Out_Single == null)
				{
					r_MRGBToHSV_Color_Out_Single_Out_Single_Out_Single = new(Type, "RGBToHSV", 0, typeof(UnityEngine.Color), typeof(System.Single).MakeByRefType(), typeof(System.Single).MakeByRefType(), typeof(System.Single).MakeByRefType());
				}
				return r_MRGBToHSV_Color_Out_Single_Out_Single_Out_Single;
			}
		}

		/// <summary>
		/// Void RGBToHSVHelper(Single, Single, Single, Single, Single ByRef, Single ByRef, Single ByRef)
		/// </summary>
		protected static RMethod r_MRGBToHSVHelper_Single_Single_Single_Single_Out_Single_Out_Single_Out_Single;
		public static RMethod RMRGBToHSVHelper_Single_Single_Single_Single_Out_Single_Out_Single_Out_Single
		{
			get
			{
				if(r_MRGBToHSVHelper_Single_Single_Single_Single_Out_Single_Out_Single_Out_Single == null)
				{
					r_MRGBToHSVHelper_Single_Single_Single_Single_Out_Single_Out_Single_Out_Single = new(Type, "RGBToHSVHelper", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single).MakeByRefType(), typeof(System.Single).MakeByRefType(), typeof(System.Single).MakeByRefType());
				}
				return r_MRGBToHSVHelper_Single_Single_Single_Single_Out_Single_Out_Single_Out_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Color HSVToRGB(Single, Single, Single)
		/// </summary>
		protected static RMethod r_MHSVToRGB_Single_Single_Single;
		public static RMethod RMHSVToRGB_Single_Single_Single
		{
			get
			{
				if(r_MHSVToRGB_Single_Single_Single == null)
				{
					r_MHSVToRGB_Single_Single_Single = new(Type, "HSVToRGB", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
				}
				return r_MHSVToRGB_Single_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Color HSVToRGB(Single, Single, Single, Boolean)
		/// </summary>
		protected static RMethod r_MHSVToRGB_Single_Single_Single_Boolean;
		public static RMethod RMHSVToRGB_Single_Single_Single_Boolean
		{
			get
			{
				if(r_MHSVToRGB_Single_Single_Single_Boolean == null)
				{
					r_MHSVToRGB_Single_Single_Single_Boolean = new(Type, "HSVToRGB", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Boolean));
				}
				return r_MHSVToRGB_Single_Single_Single_Boolean;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(System.String @format, System.IFormatProvider @formatProvider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @formatProvider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(UnityEngine.Color @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Color.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static UnityEngine.Color op_Addition(UnityEngine.Color @a, UnityEngine.Color @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Addition_Color_Color.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Color>(___result);
        }


        public static UnityEngine.Color op_Subtraction(UnityEngine.Color @a, UnityEngine.Color @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Subtraction_Color_Color.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Color>(___result);
        }


        public static UnityEngine.Color op_Multiply(UnityEngine.Color @a, UnityEngine.Color @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Multiply_Color_Color.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Color>(___result);
        }


        public static UnityEngine.Color op_Multiply(UnityEngine.Color @a, System.Single @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Multiply_Color_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Color>(___result);
        }


        public static UnityEngine.Color op_Multiply(System.Single @b, UnityEngine.Color @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@b, @a};
            var ___result = RMop_Multiply_Single_Color.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Color>(___result);
        }


        public static UnityEngine.Color op_Division(UnityEngine.Color @a, System.Single @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Division_Color_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Color>(___result);
        }


        public static System.Boolean op_Equality(UnityEngine.Color @lhs, UnityEngine.Color @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_Color_Color.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(UnityEngine.Color @lhs, UnityEngine.Color @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_Color_Color.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static UnityEngine.Color Lerp(UnityEngine.Color @a, UnityEngine.Color @b, System.Single @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RMLerp_Color_Color_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Color>(___result);
        }


        public static UnityEngine.Color LerpUnclamped(UnityEngine.Color @a, UnityEngine.Color @b, System.Single @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RMLerpUnclamped_Color_Color_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Color>(___result);
        }


        public virtual UnityEngine.Color RGBMultiplied(System.Single @multiplier)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@multiplier};
            var ___result = RMRGBMultiplied_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Color>(___result);
        }


        public virtual UnityEngine.Color AlphaMultiplied(System.Single @multiplier)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@multiplier};
            var ___result = RMAlphaMultiplied_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Color>(___result);
        }


        public virtual UnityEngine.Color RGBMultiplied(UnityEngine.Color @multiplier)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@multiplier};
            var ___result = RMRGBMultiplied_Color.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Color>(___result);
        }


        public static UnityEngine.Vector4 op_Implicit(UnityEngine.Color @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMop_Implicit_Color.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector4>(___result);
        }


        public static UnityEngine.Color op_Implicit(UnityEngine.Vector4 @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = RMop_Implicit_Vector4.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Color>(___result);
        }


        public static void RGBToHSV(UnityEngine.Color @rgbColor, out System.Single @H, out System.Single @S, out System.Single @V)
        {
			@H = default;
			@S = default;
			@V = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rgbColor, @H, @S, @V};
            var ___result = RMRGBToHSV_Color_Out_Single_Out_Single_Out_Single.Invoke(___genericsType, ___parameters);
			@H = ReflectionUtils.Convert<System.Single>(___parameters[1]);
			@S = ReflectionUtils.Convert<System.Single>(___parameters[2]);
			@V = ReflectionUtils.Convert<System.Single>(___parameters[3]);

            
        }


        public static void RGBToHSVHelper(System.Single @offset, System.Single @dominantcolor, System.Single @colorone, System.Single @colortwo, out System.Single @H, out System.Single @S, out System.Single @V)
        {
			@H = default;
			@S = default;
			@V = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@offset, @dominantcolor, @colorone, @colortwo, @H, @S, @V};
            var ___result = RMRGBToHSVHelper_Single_Single_Single_Single_Out_Single_Out_Single_Out_Single.Invoke(___genericsType, ___parameters);
			@H = ReflectionUtils.Convert<System.Single>(___parameters[4]);
			@S = ReflectionUtils.Convert<System.Single>(___parameters[5]);
			@V = ReflectionUtils.Convert<System.Single>(___parameters[6]);

            
        }


        public static UnityEngine.Color HSVToRGB(System.Single @H, System.Single @S, System.Single @V)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@H, @S, @V};
            var ___result = RMHSVToRGB_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Color>(___result);
        }


        public static UnityEngine.Color HSVToRGB(System.Single @H, System.Single @S, System.Single @V, System.Boolean @hdr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@H, @S, @V, @hdr};
            var ___result = RMHSVToRGB_Single_Single_Single_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Color>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
