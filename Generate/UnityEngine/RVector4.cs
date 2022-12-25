using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Vector4
	/// </summary>
    public partial class RVector4 : RMember //
    {

		/// <summary>
		/// System.Single kEpsilon
		/// </summary>
		protected static RField r_kEpsilon;
		public static RField RkEpsilon
		{
			get
			{
				if(r_kEpsilon == null)
				{
					r_kEpsilon = new(typeof(UnityEngine.Vector4), "kEpsilon");
					r_kEpsilon.SetBelong(null);
				}
				return r_kEpsilon;
			}
		}

		/// <summary>
		/// System.Single x
		/// </summary>
		protected RField r_x;
		public virtual RField Rx
		{
			get
			{
				if(r_x == null)
				{
					r_x = new(this, "x");
					r_x.SetBelong(this.instance);
				}
				return r_x;
			}
		}

		/// <summary>
		/// System.Single y
		/// </summary>
		protected RField r_y;
		public virtual RField Ry
		{
			get
			{
				if(r_y == null)
				{
					r_y = new(this, "y");
					r_y.SetBelong(this.instance);
				}
				return r_y;
			}
		}

		/// <summary>
		/// System.Single z
		/// </summary>
		protected RField r_z;
		public virtual RField Rz
		{
			get
			{
				if(r_z == null)
				{
					r_z = new(this, "z");
					r_z.SetBelong(this.instance);
				}
				return r_z;
			}
		}

		/// <summary>
		/// System.Single w
		/// </summary>
		protected RField r_w;
		public virtual RField Rw
		{
			get
			{
				if(r_w == null)
				{
					r_w = new(this, "w");
					r_w.SetBelong(this.instance);
				}
				return r_w;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 zeroVector
		/// </summary>
		protected static RUnityEngine.RVector4 r_zeroVector;
		public static RUnityEngine.RVector4 RzeroVector
		{
			get
			{
				if(r_zeroVector == null)
				{
					r_zeroVector = new(typeof(UnityEngine.Vector4), "zeroVector");
					r_zeroVector.SetBelong(null);
				}
				return r_zeroVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 oneVector
		/// </summary>
		protected static RUnityEngine.RVector4 r_oneVector;
		public static RUnityEngine.RVector4 RoneVector
		{
			get
			{
				if(r_oneVector == null)
				{
					r_oneVector = new(typeof(UnityEngine.Vector4), "oneVector");
					r_oneVector.SetBelong(null);
				}
				return r_oneVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 positiveInfinityVector
		/// </summary>
		protected static RUnityEngine.RVector4 r_positiveInfinityVector;
		public static RUnityEngine.RVector4 RpositiveInfinityVector
		{
			get
			{
				if(r_positiveInfinityVector == null)
				{
					r_positiveInfinityVector = new(typeof(UnityEngine.Vector4), "positiveInfinityVector");
					r_positiveInfinityVector.SetBelong(null);
				}
				return r_positiveInfinityVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 negativeInfinityVector
		/// </summary>
		protected static RUnityEngine.RVector4 r_negativeInfinityVector;
		public static RUnityEngine.RVector4 RnegativeInfinityVector
		{
			get
			{
				if(r_negativeInfinityVector == null)
				{
					r_negativeInfinityVector = new(typeof(UnityEngine.Vector4), "negativeInfinityVector");
					r_negativeInfinityVector.SetBelong(null);
				}
				return r_negativeInfinityVector;
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
		/// UnityEngine.Vector4 normalized
		/// </summary>
		protected RUnityEngine.RVector4 r_normalized;
		public virtual RUnityEngine.RVector4 Rnormalized
		{
			get
			{
				if(r_normalized == null)
				{
					r_normalized = new(this, "normalized", -1);
					r_normalized.SetBelong(this.instance);
				}
				return r_normalized;
			}
		}

		/// <summary>
		/// Single magnitude
		/// </summary>
		protected RProperty r_magnitude;
		public virtual RProperty Rmagnitude
		{
			get
			{
				if(r_magnitude == null)
				{
					r_magnitude = new(this, "magnitude", -1);
					r_magnitude.SetBelong(this.instance);
				}
				return r_magnitude;
			}
		}

		/// <summary>
		/// Single sqrMagnitude
		/// </summary>
		protected RProperty r_sqrMagnitude;
		public virtual RProperty RsqrMagnitude
		{
			get
			{
				if(r_sqrMagnitude == null)
				{
					r_sqrMagnitude = new(this, "sqrMagnitude", -1);
					r_sqrMagnitude.SetBelong(this.instance);
				}
				return r_sqrMagnitude;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 zero
		/// </summary>
		protected static RUnityEngine.RVector4 r_zero;
		public static RUnityEngine.RVector4 Rzero
		{
			get
			{
				if(r_zero == null)
				{
					r_zero = new(typeof(UnityEngine.Vector4), "zero", -1);
					r_zero.SetBelong(null);
				}
				return r_zero;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 one
		/// </summary>
		protected static RUnityEngine.RVector4 r_one;
		public static RUnityEngine.RVector4 Rone
		{
			get
			{
				if(r_one == null)
				{
					r_one = new(typeof(UnityEngine.Vector4), "one", -1);
					r_one.SetBelong(null);
				}
				return r_one;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 positiveInfinity
		/// </summary>
		protected static RUnityEngine.RVector4 r_positiveInfinity;
		public static RUnityEngine.RVector4 RpositiveInfinity
		{
			get
			{
				if(r_positiveInfinity == null)
				{
					r_positiveInfinity = new(typeof(UnityEngine.Vector4), "positiveInfinity", -1);
					r_positiveInfinity.SetBelong(null);
				}
				return r_positiveInfinity;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 negativeInfinity
		/// </summary>
		protected static RUnityEngine.RVector4 r_negativeInfinity;
		public static RUnityEngine.RVector4 RnegativeInfinity
		{
			get
			{
				if(r_negativeInfinity == null)
				{
					r_negativeInfinity = new(typeof(UnityEngine.Vector4), "negativeInfinity", -1);
					r_negativeInfinity.SetBelong(null);
				}
				return r_negativeInfinity;
			}
		}

		/// <summary>
		/// Void Set(Single, Single, Single, Single)
		/// </summary>
		protected RMethod r_RSet_Single_Single_Single_Single;
		public virtual RMethod RSet_Single_Single_Single_Single
		{
			get
			{
				if(r_RSet_Single_Single_Single_Single == null)
				{
					r_RSet_Single_Single_Single_Single = new(this, "Set", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_RSet_Single_Single_Single_Single.SetBelong(this.instance);
				}
				return r_RSet_Single_Single_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 Lerp(UnityEngine.Vector4, UnityEngine.Vector4, Single)
		/// </summary>
		protected static RMethod r_RLerp_Vector4_Vector4_Single;
		public static RMethod RLerp_Vector4_Vector4_Single
		{
			get
			{
				if(r_RLerp_Vector4_Vector4_Single == null)
				{
					r_RLerp_Vector4_Vector4_Single = new(typeof(UnityEngine.Vector4), "Lerp", 0, typeof(UnityEngine.Vector4), typeof(UnityEngine.Vector4), typeof(System.Single));
					r_RLerp_Vector4_Vector4_Single.SetBelong(null);
				}
				return r_RLerp_Vector4_Vector4_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 LerpUnclamped(UnityEngine.Vector4, UnityEngine.Vector4, Single)
		/// </summary>
		protected static RMethod r_RLerpUnclamped_Vector4_Vector4_Single;
		public static RMethod RLerpUnclamped_Vector4_Vector4_Single
		{
			get
			{
				if(r_RLerpUnclamped_Vector4_Vector4_Single == null)
				{
					r_RLerpUnclamped_Vector4_Vector4_Single = new(typeof(UnityEngine.Vector4), "LerpUnclamped", 0, typeof(UnityEngine.Vector4), typeof(UnityEngine.Vector4), typeof(System.Single));
					r_RLerpUnclamped_Vector4_Vector4_Single.SetBelong(null);
				}
				return r_RLerpUnclamped_Vector4_Vector4_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 MoveTowards(UnityEngine.Vector4, UnityEngine.Vector4, Single)
		/// </summary>
		protected static RMethod r_RMoveTowards_Vector4_Vector4_Single;
		public static RMethod RMoveTowards_Vector4_Vector4_Single
		{
			get
			{
				if(r_RMoveTowards_Vector4_Vector4_Single == null)
				{
					r_RMoveTowards_Vector4_Vector4_Single = new(typeof(UnityEngine.Vector4), "MoveTowards", 0, typeof(UnityEngine.Vector4), typeof(UnityEngine.Vector4), typeof(System.Single));
					r_RMoveTowards_Vector4_Vector4_Single.SetBelong(null);
				}
				return r_RMoveTowards_Vector4_Vector4_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 Scale(UnityEngine.Vector4, UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_RScale_Vector4_Vector4;
		public static RMethod RScale_Vector4_Vector4
		{
			get
			{
				if(r_RScale_Vector4_Vector4 == null)
				{
					r_RScale_Vector4_Vector4 = new(typeof(UnityEngine.Vector4), "Scale", 0, typeof(UnityEngine.Vector4), typeof(UnityEngine.Vector4));
					r_RScale_Vector4_Vector4.SetBelong(null);
				}
				return r_RScale_Vector4_Vector4;
			}
		}

		/// <summary>
		/// Void Scale(UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_RScale_Vector4;
		public virtual RMethod RScale_Vector4
		{
			get
			{
				if(r_RScale_Vector4 == null)
				{
					r_RScale_Vector4 = new(this, "Scale", 0, typeof(UnityEngine.Vector4));
					r_RScale_Vector4.SetBelong(this.instance);
				}
				return r_RScale_Vector4;
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
		/// Boolean Equals(UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_REquals_Vector4;
		public virtual RMethod REquals_Vector4
		{
			get
			{
				if(r_REquals_Vector4 == null)
				{
					r_REquals_Vector4 = new(this, "Equals", 0, typeof(UnityEngine.Vector4));
					r_REquals_Vector4.SetBelong(this.instance);
				}
				return r_REquals_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 Normalize(UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_RNormalize_Vector4;
		public static RMethod RNormalize_Vector4
		{
			get
			{
				if(r_RNormalize_Vector4 == null)
				{
					r_RNormalize_Vector4 = new(typeof(UnityEngine.Vector4), "Normalize", 0, typeof(UnityEngine.Vector4));
					r_RNormalize_Vector4.SetBelong(null);
				}
				return r_RNormalize_Vector4;
			}
		}

		/// <summary>
		/// Void Normalize()
		/// </summary>
		protected RMethod r_RNormalize;
		public virtual RMethod RNormalize
		{
			get
			{
				if(r_RNormalize == null)
				{
					r_RNormalize = new(this, "Normalize", 0);
					r_RNormalize.SetBelong(this.instance);
				}
				return r_RNormalize;
			}
		}

		/// <summary>
		/// Single Dot(UnityEngine.Vector4, UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_RDot_Vector4_Vector4;
		public static RMethod RDot_Vector4_Vector4
		{
			get
			{
				if(r_RDot_Vector4_Vector4 == null)
				{
					r_RDot_Vector4_Vector4 = new(typeof(UnityEngine.Vector4), "Dot", 0, typeof(UnityEngine.Vector4), typeof(UnityEngine.Vector4));
					r_RDot_Vector4_Vector4.SetBelong(null);
				}
				return r_RDot_Vector4_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 Project(UnityEngine.Vector4, UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_RProject_Vector4_Vector4;
		public static RMethod RProject_Vector4_Vector4
		{
			get
			{
				if(r_RProject_Vector4_Vector4 == null)
				{
					r_RProject_Vector4_Vector4 = new(typeof(UnityEngine.Vector4), "Project", 0, typeof(UnityEngine.Vector4), typeof(UnityEngine.Vector4));
					r_RProject_Vector4_Vector4.SetBelong(null);
				}
				return r_RProject_Vector4_Vector4;
			}
		}

		/// <summary>
		/// Single Distance(UnityEngine.Vector4, UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_RDistance_Vector4_Vector4;
		public static RMethod RDistance_Vector4_Vector4
		{
			get
			{
				if(r_RDistance_Vector4_Vector4 == null)
				{
					r_RDistance_Vector4_Vector4 = new(typeof(UnityEngine.Vector4), "Distance", 0, typeof(UnityEngine.Vector4), typeof(UnityEngine.Vector4));
					r_RDistance_Vector4_Vector4.SetBelong(null);
				}
				return r_RDistance_Vector4_Vector4;
			}
		}

		/// <summary>
		/// Single Magnitude(UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_RMagnitude_Vector4;
		public static RMethod RMagnitude_Vector4
		{
			get
			{
				if(r_RMagnitude_Vector4 == null)
				{
					r_RMagnitude_Vector4 = new(typeof(UnityEngine.Vector4), "Magnitude", 0, typeof(UnityEngine.Vector4));
					r_RMagnitude_Vector4.SetBelong(null);
				}
				return r_RMagnitude_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 Min(UnityEngine.Vector4, UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_RMin_Vector4_Vector4;
		public static RMethod RMin_Vector4_Vector4
		{
			get
			{
				if(r_RMin_Vector4_Vector4 == null)
				{
					r_RMin_Vector4_Vector4 = new(typeof(UnityEngine.Vector4), "Min", 0, typeof(UnityEngine.Vector4), typeof(UnityEngine.Vector4));
					r_RMin_Vector4_Vector4.SetBelong(null);
				}
				return r_RMin_Vector4_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 Max(UnityEngine.Vector4, UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_RMax_Vector4_Vector4;
		public static RMethod RMax_Vector4_Vector4
		{
			get
			{
				if(r_RMax_Vector4_Vector4 == null)
				{
					r_RMax_Vector4_Vector4 = new(typeof(UnityEngine.Vector4), "Max", 0, typeof(UnityEngine.Vector4), typeof(UnityEngine.Vector4));
					r_RMax_Vector4_Vector4.SetBelong(null);
				}
				return r_RMax_Vector4_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 op_Addition(UnityEngine.Vector4, UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_Rop_Addition_Vector4_Vector4;
		public static RMethod Rop_Addition_Vector4_Vector4
		{
			get
			{
				if(r_Rop_Addition_Vector4_Vector4 == null)
				{
					r_Rop_Addition_Vector4_Vector4 = new(typeof(UnityEngine.Vector4), "op_Addition", 0, typeof(UnityEngine.Vector4), typeof(UnityEngine.Vector4));
					r_Rop_Addition_Vector4_Vector4.SetBelong(null);
				}
				return r_Rop_Addition_Vector4_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 op_Subtraction(UnityEngine.Vector4, UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_Rop_Subtraction_Vector4_Vector4;
		public static RMethod Rop_Subtraction_Vector4_Vector4
		{
			get
			{
				if(r_Rop_Subtraction_Vector4_Vector4 == null)
				{
					r_Rop_Subtraction_Vector4_Vector4 = new(typeof(UnityEngine.Vector4), "op_Subtraction", 0, typeof(UnityEngine.Vector4), typeof(UnityEngine.Vector4));
					r_Rop_Subtraction_Vector4_Vector4.SetBelong(null);
				}
				return r_Rop_Subtraction_Vector4_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 op_UnaryNegation(UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_Rop_UnaryNegation_Vector4;
		public static RMethod Rop_UnaryNegation_Vector4
		{
			get
			{
				if(r_Rop_UnaryNegation_Vector4 == null)
				{
					r_Rop_UnaryNegation_Vector4 = new(typeof(UnityEngine.Vector4), "op_UnaryNegation", 0, typeof(UnityEngine.Vector4));
					r_Rop_UnaryNegation_Vector4.SetBelong(null);
				}
				return r_Rop_UnaryNegation_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 op_Multiply(UnityEngine.Vector4, Single)
		/// </summary>
		protected static RMethod r_Rop_Multiply_Vector4_Single;
		public static RMethod Rop_Multiply_Vector4_Single
		{
			get
			{
				if(r_Rop_Multiply_Vector4_Single == null)
				{
					r_Rop_Multiply_Vector4_Single = new(typeof(UnityEngine.Vector4), "op_Multiply", 0, typeof(UnityEngine.Vector4), typeof(System.Single));
					r_Rop_Multiply_Vector4_Single.SetBelong(null);
				}
				return r_Rop_Multiply_Vector4_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 op_Multiply(Single, UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_Rop_Multiply_Single_Vector4;
		public static RMethod Rop_Multiply_Single_Vector4
		{
			get
			{
				if(r_Rop_Multiply_Single_Vector4 == null)
				{
					r_Rop_Multiply_Single_Vector4 = new(typeof(UnityEngine.Vector4), "op_Multiply", 0, typeof(System.Single), typeof(UnityEngine.Vector4));
					r_Rop_Multiply_Single_Vector4.SetBelong(null);
				}
				return r_Rop_Multiply_Single_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 op_Division(UnityEngine.Vector4, Single)
		/// </summary>
		protected static RMethod r_Rop_Division_Vector4_Single;
		public static RMethod Rop_Division_Vector4_Single
		{
			get
			{
				if(r_Rop_Division_Vector4_Single == null)
				{
					r_Rop_Division_Vector4_Single = new(typeof(UnityEngine.Vector4), "op_Division", 0, typeof(UnityEngine.Vector4), typeof(System.Single));
					r_Rop_Division_Vector4_Single.SetBelong(null);
				}
				return r_Rop_Division_Vector4_Single;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Vector4, UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_Rop_Equality_Vector4_Vector4;
		public static RMethod Rop_Equality_Vector4_Vector4
		{
			get
			{
				if(r_Rop_Equality_Vector4_Vector4 == null)
				{
					r_Rop_Equality_Vector4_Vector4 = new(typeof(UnityEngine.Vector4), "op_Equality", 0, typeof(UnityEngine.Vector4), typeof(UnityEngine.Vector4));
					r_Rop_Equality_Vector4_Vector4.SetBelong(null);
				}
				return r_Rop_Equality_Vector4_Vector4;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Vector4, UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_Rop_Inequality_Vector4_Vector4;
		public static RMethod Rop_Inequality_Vector4_Vector4
		{
			get
			{
				if(r_Rop_Inequality_Vector4_Vector4 == null)
				{
					r_Rop_Inequality_Vector4_Vector4 = new(typeof(UnityEngine.Vector4), "op_Inequality", 0, typeof(UnityEngine.Vector4), typeof(UnityEngine.Vector4));
					r_Rop_Inequality_Vector4_Vector4.SetBelong(null);
				}
				return r_Rop_Inequality_Vector4_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 op_Implicit(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_Rop_Implicit_Vector3;
		public static RMethod Rop_Implicit_Vector3
		{
			get
			{
				if(r_Rop_Implicit_Vector3 == null)
				{
					r_Rop_Implicit_Vector3 = new(typeof(UnityEngine.Vector4), "op_Implicit", 0, typeof(UnityEngine.Vector3));
					r_Rop_Implicit_Vector3.SetBelong(null);
				}
				return r_Rop_Implicit_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 op_Implicit(UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_Rop_Implicit_Vector4;
		public static RMethod Rop_Implicit_Vector4
		{
			get
			{
				if(r_Rop_Implicit_Vector4 == null)
				{
					r_Rop_Implicit_Vector4 = new(typeof(UnityEngine.Vector4), "op_Implicit", 0, typeof(UnityEngine.Vector4));
					r_Rop_Implicit_Vector4.SetBelong(null);
				}
				return r_Rop_Implicit_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 op_Implicit(UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_Rop_Implicit_Vector2;
		public static RMethod Rop_Implicit_Vector2
		{
			get
			{
				if(r_Rop_Implicit_Vector2 == null)
				{
					r_Rop_Implicit_Vector2 = new(typeof(UnityEngine.Vector4), "op_Implicit", 0, typeof(UnityEngine.Vector2));
					r_Rop_Implicit_Vector2.SetBelong(null);
				}
				return r_Rop_Implicit_Vector2;
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
		/// Single SqrMagnitude(UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_RSqrMagnitude_Vector4;
		public static RMethod RSqrMagnitude_Vector4
		{
			get
			{
				if(r_RSqrMagnitude_Vector4 == null)
				{
					r_RSqrMagnitude_Vector4 = new(typeof(UnityEngine.Vector4), "SqrMagnitude", 0, typeof(UnityEngine.Vector4));
					r_RSqrMagnitude_Vector4.SetBelong(null);
				}
				return r_RSqrMagnitude_Vector4;
			}
		}

		/// <summary>
		/// Single SqrMagnitude()
		/// </summary>
		protected RMethod r_RSqrMagnitude;
		public virtual RMethod RSqrMagnitude
		{
			get
			{
				if(r_RSqrMagnitude == null)
				{
					r_RSqrMagnitude = new(this, "SqrMagnitude", 0);
					r_RSqrMagnitude.SetBelong(this.instance);
				}
				return r_RSqrMagnitude;
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


        public RVector4() : base("UnityEngine.Vector4")
        {
        }

        public RVector4(System.Object instance) : base("UnityEngine.Vector4")
		{
            SetInstance(instance);
		}

        public RVector4(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RVector4(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Set(System.Single  @newX, System.Single  @newY, System.Single  @newZ, System.Single  @newW)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newX, @newY, @newZ, @newW};
            var ___result = RSet_Single_Single_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Vector4 Lerp(UnityEngine.Vector4  @a, UnityEngine.Vector4  @b, System.Single  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RLerp_Vector4_Vector4_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Vector4 LerpUnclamped(UnityEngine.Vector4  @a, UnityEngine.Vector4  @b, System.Single  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RLerpUnclamped_Vector4_Vector4_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Vector4 MoveTowards(UnityEngine.Vector4  @current, UnityEngine.Vector4  @target, System.Single  @maxDistanceDelta)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@current, @target, @maxDistanceDelta};
            var ___result = RMoveTowards_Vector4_Vector4_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Vector4 Scale(UnityEngine.Vector4  @a, UnityEngine.Vector4  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RScale_Vector4_Vector4.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public virtual void Scale(UnityEngine.Vector4  @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scale};
            var ___result = RScale_Vector4.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Boolean Equals(UnityEngine.Vector4  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Vector4.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.Vector4 Normalize(UnityEngine.Vector4  @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RNormalize_Vector4.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public virtual void Normalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RNormalize.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Single Dot(UnityEngine.Vector4  @a, UnityEngine.Vector4  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RDot_Vector4_Vector4.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static UnityEngine.Vector4 Project(UnityEngine.Vector4  @a, UnityEngine.Vector4  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RProject_Vector4_Vector4.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static System.Single Distance(UnityEngine.Vector4  @a, UnityEngine.Vector4  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RDistance_Vector4_Vector4.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Single Magnitude(UnityEngine.Vector4  @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RMagnitude_Vector4.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static UnityEngine.Vector4 Min(UnityEngine.Vector4  @lhs, UnityEngine.Vector4  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMin_Vector4_Vector4.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Vector4 Max(UnityEngine.Vector4  @lhs, UnityEngine.Vector4  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMax_Vector4_Vector4.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Vector4 op_Addition(UnityEngine.Vector4  @a, UnityEngine.Vector4  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Addition_Vector4_Vector4.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Vector4 op_Subtraction(UnityEngine.Vector4  @a, UnityEngine.Vector4  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Subtraction_Vector4_Vector4.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Vector4 op_UnaryNegation(UnityEngine.Vector4  @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = Rop_UnaryNegation_Vector4.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Vector4 op_Multiply(UnityEngine.Vector4  @a, System.Single  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @d};
            var ___result = Rop_Multiply_Vector4_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Vector4 op_Multiply(System.Single  @d, UnityEngine.Vector4  @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d, @a};
            var ___result = Rop_Multiply_Single_Vector4.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Vector4 op_Division(UnityEngine.Vector4  @a, System.Single  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @d};
            var ___result = Rop_Division_Vector4_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Vector4  @lhs, UnityEngine.Vector4  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_Vector4_Vector4.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Vector4  @lhs, UnityEngine.Vector4  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_Vector4_Vector4.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.Vector4 op_Implicit(UnityEngine.Vector3  @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = Rop_Implicit_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Vector3 op_Implicit(UnityEngine.Vector4  @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = Rop_Implicit_Vector4.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector4 op_Implicit(UnityEngine.Vector2  @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = Rop_Implicit_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
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


        public static System.Single SqrMagnitude(UnityEngine.Vector4  @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RSqrMagnitude_Vector4.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single SqrMagnitude()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSqrMagnitude.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
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
