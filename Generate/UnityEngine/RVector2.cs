using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Vector2
	/// </summary>
    public partial class RVector2 : RMember //
    {

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
		/// UnityEngine.Vector2 zeroVector
		/// </summary>
		protected static RUnityEngine.RVector2 r_zeroVector;
		public static RUnityEngine.RVector2 RzeroVector
		{
			get
			{
				if(r_zeroVector == null)
				{
					r_zeroVector = new(typeof(UnityEngine.Vector2), "zeroVector");
					r_zeroVector.SetBelong(null);
				}
				return r_zeroVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 oneVector
		/// </summary>
		protected static RUnityEngine.RVector2 r_oneVector;
		public static RUnityEngine.RVector2 RoneVector
		{
			get
			{
				if(r_oneVector == null)
				{
					r_oneVector = new(typeof(UnityEngine.Vector2), "oneVector");
					r_oneVector.SetBelong(null);
				}
				return r_oneVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 upVector
		/// </summary>
		protected static RUnityEngine.RVector2 r_upVector;
		public static RUnityEngine.RVector2 RupVector
		{
			get
			{
				if(r_upVector == null)
				{
					r_upVector = new(typeof(UnityEngine.Vector2), "upVector");
					r_upVector.SetBelong(null);
				}
				return r_upVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 downVector
		/// </summary>
		protected static RUnityEngine.RVector2 r_downVector;
		public static RUnityEngine.RVector2 RdownVector
		{
			get
			{
				if(r_downVector == null)
				{
					r_downVector = new(typeof(UnityEngine.Vector2), "downVector");
					r_downVector.SetBelong(null);
				}
				return r_downVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 leftVector
		/// </summary>
		protected static RUnityEngine.RVector2 r_leftVector;
		public static RUnityEngine.RVector2 RleftVector
		{
			get
			{
				if(r_leftVector == null)
				{
					r_leftVector = new(typeof(UnityEngine.Vector2), "leftVector");
					r_leftVector.SetBelong(null);
				}
				return r_leftVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 rightVector
		/// </summary>
		protected static RUnityEngine.RVector2 r_rightVector;
		public static RUnityEngine.RVector2 RrightVector
		{
			get
			{
				if(r_rightVector == null)
				{
					r_rightVector = new(typeof(UnityEngine.Vector2), "rightVector");
					r_rightVector.SetBelong(null);
				}
				return r_rightVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 positiveInfinityVector
		/// </summary>
		protected static RUnityEngine.RVector2 r_positiveInfinityVector;
		public static RUnityEngine.RVector2 RpositiveInfinityVector
		{
			get
			{
				if(r_positiveInfinityVector == null)
				{
					r_positiveInfinityVector = new(typeof(UnityEngine.Vector2), "positiveInfinityVector");
					r_positiveInfinityVector.SetBelong(null);
				}
				return r_positiveInfinityVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 negativeInfinityVector
		/// </summary>
		protected static RUnityEngine.RVector2 r_negativeInfinityVector;
		public static RUnityEngine.RVector2 RnegativeInfinityVector
		{
			get
			{
				if(r_negativeInfinityVector == null)
				{
					r_negativeInfinityVector = new(typeof(UnityEngine.Vector2), "negativeInfinityVector");
					r_negativeInfinityVector.SetBelong(null);
				}
				return r_negativeInfinityVector;
			}
		}

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
					r_kEpsilon = new(typeof(UnityEngine.Vector2), "kEpsilon");
					r_kEpsilon.SetBelong(null);
				}
				return r_kEpsilon;
			}
		}

		/// <summary>
		/// System.Single kEpsilonNormalSqrt
		/// </summary>
		protected static RField r_kEpsilonNormalSqrt;
		public static RField RkEpsilonNormalSqrt
		{
			get
			{
				if(r_kEpsilonNormalSqrt == null)
				{
					r_kEpsilonNormalSqrt = new(typeof(UnityEngine.Vector2), "kEpsilonNormalSqrt");
					r_kEpsilonNormalSqrt.SetBelong(null);
				}
				return r_kEpsilonNormalSqrt;
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
		/// UnityEngine.Vector2 normalized
		/// </summary>
		protected RUnityEngine.RVector2 r_normalized;
		public virtual RUnityEngine.RVector2 Rnormalized
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
		/// UnityEngine.Vector2 zero
		/// </summary>
		protected static RUnityEngine.RVector2 r_zero;
		public static RUnityEngine.RVector2 Rzero
		{
			get
			{
				if(r_zero == null)
				{
					r_zero = new(typeof(UnityEngine.Vector2), "zero", -1);
					r_zero.SetBelong(null);
				}
				return r_zero;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 one
		/// </summary>
		protected static RUnityEngine.RVector2 r_one;
		public static RUnityEngine.RVector2 Rone
		{
			get
			{
				if(r_one == null)
				{
					r_one = new(typeof(UnityEngine.Vector2), "one", -1);
					r_one.SetBelong(null);
				}
				return r_one;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 up
		/// </summary>
		protected static RUnityEngine.RVector2 r_up;
		public static RUnityEngine.RVector2 Rup
		{
			get
			{
				if(r_up == null)
				{
					r_up = new(typeof(UnityEngine.Vector2), "up", -1);
					r_up.SetBelong(null);
				}
				return r_up;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 down
		/// </summary>
		protected static RUnityEngine.RVector2 r_down;
		public static RUnityEngine.RVector2 Rdown
		{
			get
			{
				if(r_down == null)
				{
					r_down = new(typeof(UnityEngine.Vector2), "down", -1);
					r_down.SetBelong(null);
				}
				return r_down;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 left
		/// </summary>
		protected static RUnityEngine.RVector2 r_left;
		public static RUnityEngine.RVector2 Rleft
		{
			get
			{
				if(r_left == null)
				{
					r_left = new(typeof(UnityEngine.Vector2), "left", -1);
					r_left.SetBelong(null);
				}
				return r_left;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 right
		/// </summary>
		protected static RUnityEngine.RVector2 r_right;
		public static RUnityEngine.RVector2 Rright
		{
			get
			{
				if(r_right == null)
				{
					r_right = new(typeof(UnityEngine.Vector2), "right", -1);
					r_right.SetBelong(null);
				}
				return r_right;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 positiveInfinity
		/// </summary>
		protected static RUnityEngine.RVector2 r_positiveInfinity;
		public static RUnityEngine.RVector2 RpositiveInfinity
		{
			get
			{
				if(r_positiveInfinity == null)
				{
					r_positiveInfinity = new(typeof(UnityEngine.Vector2), "positiveInfinity", -1);
					r_positiveInfinity.SetBelong(null);
				}
				return r_positiveInfinity;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 negativeInfinity
		/// </summary>
		protected static RUnityEngine.RVector2 r_negativeInfinity;
		public static RUnityEngine.RVector2 RnegativeInfinity
		{
			get
			{
				if(r_negativeInfinity == null)
				{
					r_negativeInfinity = new(typeof(UnityEngine.Vector2), "negativeInfinity", -1);
					r_negativeInfinity.SetBelong(null);
				}
				return r_negativeInfinity;
			}
		}

		/// <summary>
		/// Void Set(Single, Single)
		/// </summary>
		protected RMethod r_RSet_Single_Single;
		public virtual RMethod RSet_Single_Single
		{
			get
			{
				if(r_RSet_Single_Single == null)
				{
					r_RSet_Single_Single = new(this, "Set", 0, typeof(System.Single), typeof(System.Single));
					r_RSet_Single_Single.SetBelong(this.instance);
				}
				return r_RSet_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 Lerp(UnityEngine.Vector2, UnityEngine.Vector2, Single)
		/// </summary>
		protected static RMethod r_RLerp_Vector2_Vector2_Single;
		public static RMethod RLerp_Vector2_Vector2_Single
		{
			get
			{
				if(r_RLerp_Vector2_Vector2_Single == null)
				{
					r_RLerp_Vector2_Vector2_Single = new(typeof(UnityEngine.Vector2), "Lerp", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single));
					r_RLerp_Vector2_Vector2_Single.SetBelong(null);
				}
				return r_RLerp_Vector2_Vector2_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 LerpUnclamped(UnityEngine.Vector2, UnityEngine.Vector2, Single)
		/// </summary>
		protected static RMethod r_RLerpUnclamped_Vector2_Vector2_Single;
		public static RMethod RLerpUnclamped_Vector2_Vector2_Single
		{
			get
			{
				if(r_RLerpUnclamped_Vector2_Vector2_Single == null)
				{
					r_RLerpUnclamped_Vector2_Vector2_Single = new(typeof(UnityEngine.Vector2), "LerpUnclamped", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single));
					r_RLerpUnclamped_Vector2_Vector2_Single.SetBelong(null);
				}
				return r_RLerpUnclamped_Vector2_Vector2_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 MoveTowards(UnityEngine.Vector2, UnityEngine.Vector2, Single)
		/// </summary>
		protected static RMethod r_RMoveTowards_Vector2_Vector2_Single;
		public static RMethod RMoveTowards_Vector2_Vector2_Single
		{
			get
			{
				if(r_RMoveTowards_Vector2_Vector2_Single == null)
				{
					r_RMoveTowards_Vector2_Vector2_Single = new(typeof(UnityEngine.Vector2), "MoveTowards", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single));
					r_RMoveTowards_Vector2_Vector2_Single.SetBelong(null);
				}
				return r_RMoveTowards_Vector2_Vector2_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 Scale(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_RScale_Vector2_Vector2;
		public static RMethod RScale_Vector2_Vector2
		{
			get
			{
				if(r_RScale_Vector2_Vector2 == null)
				{
					r_RScale_Vector2_Vector2 = new(typeof(UnityEngine.Vector2), "Scale", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_RScale_Vector2_Vector2.SetBelong(null);
				}
				return r_RScale_Vector2_Vector2;
			}
		}

		/// <summary>
		/// Void Scale(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RScale_Vector2;
		public virtual RMethod RScale_Vector2
		{
			get
			{
				if(r_RScale_Vector2 == null)
				{
					r_RScale_Vector2 = new(this, "Scale", 0, typeof(UnityEngine.Vector2));
					r_RScale_Vector2.SetBelong(this.instance);
				}
				return r_RScale_Vector2;
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
		/// Boolean Equals(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_REquals_Vector2;
		public virtual RMethod REquals_Vector2
		{
			get
			{
				if(r_REquals_Vector2 == null)
				{
					r_REquals_Vector2 = new(this, "Equals", 0, typeof(UnityEngine.Vector2));
					r_REquals_Vector2.SetBelong(this.instance);
				}
				return r_REquals_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 Reflect(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_RReflect_Vector2_Vector2;
		public static RMethod RReflect_Vector2_Vector2
		{
			get
			{
				if(r_RReflect_Vector2_Vector2 == null)
				{
					r_RReflect_Vector2_Vector2 = new(typeof(UnityEngine.Vector2), "Reflect", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_RReflect_Vector2_Vector2.SetBelong(null);
				}
				return r_RReflect_Vector2_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 Perpendicular(UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_RPerpendicular_Vector2;
		public static RMethod RPerpendicular_Vector2
		{
			get
			{
				if(r_RPerpendicular_Vector2 == null)
				{
					r_RPerpendicular_Vector2 = new(typeof(UnityEngine.Vector2), "Perpendicular", 0, typeof(UnityEngine.Vector2));
					r_RPerpendicular_Vector2.SetBelong(null);
				}
				return r_RPerpendicular_Vector2;
			}
		}

		/// <summary>
		/// Single Dot(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_RDot_Vector2_Vector2;
		public static RMethod RDot_Vector2_Vector2
		{
			get
			{
				if(r_RDot_Vector2_Vector2 == null)
				{
					r_RDot_Vector2_Vector2 = new(typeof(UnityEngine.Vector2), "Dot", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_RDot_Vector2_Vector2.SetBelong(null);
				}
				return r_RDot_Vector2_Vector2;
			}
		}

		/// <summary>
		/// Single Angle(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_RAngle_Vector2_Vector2;
		public static RMethod RAngle_Vector2_Vector2
		{
			get
			{
				if(r_RAngle_Vector2_Vector2 == null)
				{
					r_RAngle_Vector2_Vector2 = new(typeof(UnityEngine.Vector2), "Angle", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_RAngle_Vector2_Vector2.SetBelong(null);
				}
				return r_RAngle_Vector2_Vector2;
			}
		}

		/// <summary>
		/// Single SignedAngle(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_RSignedAngle_Vector2_Vector2;
		public static RMethod RSignedAngle_Vector2_Vector2
		{
			get
			{
				if(r_RSignedAngle_Vector2_Vector2 == null)
				{
					r_RSignedAngle_Vector2_Vector2 = new(typeof(UnityEngine.Vector2), "SignedAngle", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_RSignedAngle_Vector2_Vector2.SetBelong(null);
				}
				return r_RSignedAngle_Vector2_Vector2;
			}
		}

		/// <summary>
		/// Single Distance(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_RDistance_Vector2_Vector2;
		public static RMethod RDistance_Vector2_Vector2
		{
			get
			{
				if(r_RDistance_Vector2_Vector2 == null)
				{
					r_RDistance_Vector2_Vector2 = new(typeof(UnityEngine.Vector2), "Distance", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_RDistance_Vector2_Vector2.SetBelong(null);
				}
				return r_RDistance_Vector2_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 ClampMagnitude(UnityEngine.Vector2, Single)
		/// </summary>
		protected static RMethod r_RClampMagnitude_Vector2_Single;
		public static RMethod RClampMagnitude_Vector2_Single
		{
			get
			{
				if(r_RClampMagnitude_Vector2_Single == null)
				{
					r_RClampMagnitude_Vector2_Single = new(typeof(UnityEngine.Vector2), "ClampMagnitude", 0, typeof(UnityEngine.Vector2), typeof(System.Single));
					r_RClampMagnitude_Vector2_Single.SetBelong(null);
				}
				return r_RClampMagnitude_Vector2_Single;
			}
		}

		/// <summary>
		/// Single SqrMagnitude(UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_RSqrMagnitude_Vector2;
		public static RMethod RSqrMagnitude_Vector2
		{
			get
			{
				if(r_RSqrMagnitude_Vector2 == null)
				{
					r_RSqrMagnitude_Vector2 = new(typeof(UnityEngine.Vector2), "SqrMagnitude", 0, typeof(UnityEngine.Vector2));
					r_RSqrMagnitude_Vector2.SetBelong(null);
				}
				return r_RSqrMagnitude_Vector2;
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
		/// UnityEngine.Vector2 Min(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_RMin_Vector2_Vector2;
		public static RMethod RMin_Vector2_Vector2
		{
			get
			{
				if(r_RMin_Vector2_Vector2 == null)
				{
					r_RMin_Vector2_Vector2 = new(typeof(UnityEngine.Vector2), "Min", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_RMin_Vector2_Vector2.SetBelong(null);
				}
				return r_RMin_Vector2_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 Max(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_RMax_Vector2_Vector2;
		public static RMethod RMax_Vector2_Vector2
		{
			get
			{
				if(r_RMax_Vector2_Vector2 == null)
				{
					r_RMax_Vector2_Vector2 = new(typeof(UnityEngine.Vector2), "Max", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_RMax_Vector2_Vector2.SetBelong(null);
				}
				return r_RMax_Vector2_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 SmoothDamp(UnityEngine.Vector2, UnityEngine.Vector2, UnityEngine.Vector2 ByRef, Single, Single)
		/// </summary>
		protected static RMethod r_RSmoothDamp_Vector2_Vector2_Ref_Vector2_Single_Single;
		public static RMethod RSmoothDamp_Vector2_Vector2_Ref_Vector2_Single_Single
		{
			get
			{
				if(r_RSmoothDamp_Vector2_Vector2_Ref_Vector2_Single_Single == null)
				{
					r_RSmoothDamp_Vector2_Vector2_Ref_Vector2_Single_Single = new(typeof(UnityEngine.Vector2), "SmoothDamp", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2).MakeByRefType(), typeof(System.Single), typeof(System.Single));
					r_RSmoothDamp_Vector2_Vector2_Ref_Vector2_Single_Single.SetBelong(null);
				}
				return r_RSmoothDamp_Vector2_Vector2_Ref_Vector2_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 SmoothDamp(UnityEngine.Vector2, UnityEngine.Vector2, UnityEngine.Vector2 ByRef, Single)
		/// </summary>
		protected static RMethod r_RSmoothDamp_Vector2_Vector2_Ref_Vector2_Single;
		public static RMethod RSmoothDamp_Vector2_Vector2_Ref_Vector2_Single
		{
			get
			{
				if(r_RSmoothDamp_Vector2_Vector2_Ref_Vector2_Single == null)
				{
					r_RSmoothDamp_Vector2_Vector2_Ref_Vector2_Single = new(typeof(UnityEngine.Vector2), "SmoothDamp", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2).MakeByRefType(), typeof(System.Single));
					r_RSmoothDamp_Vector2_Vector2_Ref_Vector2_Single.SetBelong(null);
				}
				return r_RSmoothDamp_Vector2_Vector2_Ref_Vector2_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 SmoothDamp(UnityEngine.Vector2, UnityEngine.Vector2, UnityEngine.Vector2 ByRef, Single, Single, Single)
		/// </summary>
		protected static RMethod r_RSmoothDamp_Vector2_Vector2_Ref_Vector2_Single_Single_Single;
		public static RMethod RSmoothDamp_Vector2_Vector2_Ref_Vector2_Single_Single_Single
		{
			get
			{
				if(r_RSmoothDamp_Vector2_Vector2_Ref_Vector2_Single_Single_Single == null)
				{
					r_RSmoothDamp_Vector2_Vector2_Ref_Vector2_Single_Single_Single = new(typeof(UnityEngine.Vector2), "SmoothDamp", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2).MakeByRefType(), typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_RSmoothDamp_Vector2_Vector2_Ref_Vector2_Single_Single_Single.SetBelong(null);
				}
				return r_RSmoothDamp_Vector2_Vector2_Ref_Vector2_Single_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 op_Addition(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_Rop_Addition_Vector2_Vector2;
		public static RMethod Rop_Addition_Vector2_Vector2
		{
			get
			{
				if(r_Rop_Addition_Vector2_Vector2 == null)
				{
					r_Rop_Addition_Vector2_Vector2 = new(typeof(UnityEngine.Vector2), "op_Addition", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_Rop_Addition_Vector2_Vector2.SetBelong(null);
				}
				return r_Rop_Addition_Vector2_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 op_Subtraction(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_Rop_Subtraction_Vector2_Vector2;
		public static RMethod Rop_Subtraction_Vector2_Vector2
		{
			get
			{
				if(r_Rop_Subtraction_Vector2_Vector2 == null)
				{
					r_Rop_Subtraction_Vector2_Vector2 = new(typeof(UnityEngine.Vector2), "op_Subtraction", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_Rop_Subtraction_Vector2_Vector2.SetBelong(null);
				}
				return r_Rop_Subtraction_Vector2_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 op_Multiply(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_Rop_Multiply_Vector2_Vector2;
		public static RMethod Rop_Multiply_Vector2_Vector2
		{
			get
			{
				if(r_Rop_Multiply_Vector2_Vector2 == null)
				{
					r_Rop_Multiply_Vector2_Vector2 = new(typeof(UnityEngine.Vector2), "op_Multiply", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_Rop_Multiply_Vector2_Vector2.SetBelong(null);
				}
				return r_Rop_Multiply_Vector2_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 op_Division(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_Rop_Division_Vector2_Vector2;
		public static RMethod Rop_Division_Vector2_Vector2
		{
			get
			{
				if(r_Rop_Division_Vector2_Vector2 == null)
				{
					r_Rop_Division_Vector2_Vector2 = new(typeof(UnityEngine.Vector2), "op_Division", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_Rop_Division_Vector2_Vector2.SetBelong(null);
				}
				return r_Rop_Division_Vector2_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 op_UnaryNegation(UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_Rop_UnaryNegation_Vector2;
		public static RMethod Rop_UnaryNegation_Vector2
		{
			get
			{
				if(r_Rop_UnaryNegation_Vector2 == null)
				{
					r_Rop_UnaryNegation_Vector2 = new(typeof(UnityEngine.Vector2), "op_UnaryNegation", 0, typeof(UnityEngine.Vector2));
					r_Rop_UnaryNegation_Vector2.SetBelong(null);
				}
				return r_Rop_UnaryNegation_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 op_Multiply(UnityEngine.Vector2, Single)
		/// </summary>
		protected static RMethod r_Rop_Multiply_Vector2_Single;
		public static RMethod Rop_Multiply_Vector2_Single
		{
			get
			{
				if(r_Rop_Multiply_Vector2_Single == null)
				{
					r_Rop_Multiply_Vector2_Single = new(typeof(UnityEngine.Vector2), "op_Multiply", 0, typeof(UnityEngine.Vector2), typeof(System.Single));
					r_Rop_Multiply_Vector2_Single.SetBelong(null);
				}
				return r_Rop_Multiply_Vector2_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 op_Multiply(Single, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_Rop_Multiply_Single_Vector2;
		public static RMethod Rop_Multiply_Single_Vector2
		{
			get
			{
				if(r_Rop_Multiply_Single_Vector2 == null)
				{
					r_Rop_Multiply_Single_Vector2 = new(typeof(UnityEngine.Vector2), "op_Multiply", 0, typeof(System.Single), typeof(UnityEngine.Vector2));
					r_Rop_Multiply_Single_Vector2.SetBelong(null);
				}
				return r_Rop_Multiply_Single_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 op_Division(UnityEngine.Vector2, Single)
		/// </summary>
		protected static RMethod r_Rop_Division_Vector2_Single;
		public static RMethod Rop_Division_Vector2_Single
		{
			get
			{
				if(r_Rop_Division_Vector2_Single == null)
				{
					r_Rop_Division_Vector2_Single = new(typeof(UnityEngine.Vector2), "op_Division", 0, typeof(UnityEngine.Vector2), typeof(System.Single));
					r_Rop_Division_Vector2_Single.SetBelong(null);
				}
				return r_Rop_Division_Vector2_Single;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_Rop_Equality_Vector2_Vector2;
		public static RMethod Rop_Equality_Vector2_Vector2
		{
			get
			{
				if(r_Rop_Equality_Vector2_Vector2 == null)
				{
					r_Rop_Equality_Vector2_Vector2 = new(typeof(UnityEngine.Vector2), "op_Equality", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_Rop_Equality_Vector2_Vector2.SetBelong(null);
				}
				return r_Rop_Equality_Vector2_Vector2;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_Rop_Inequality_Vector2_Vector2;
		public static RMethod Rop_Inequality_Vector2_Vector2
		{
			get
			{
				if(r_Rop_Inequality_Vector2_Vector2 == null)
				{
					r_Rop_Inequality_Vector2_Vector2 = new(typeof(UnityEngine.Vector2), "op_Inequality", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_Rop_Inequality_Vector2_Vector2.SetBelong(null);
				}
				return r_Rop_Inequality_Vector2_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 op_Implicit(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_Rop_Implicit_Vector3;
		public static RMethod Rop_Implicit_Vector3
		{
			get
			{
				if(r_Rop_Implicit_Vector3 == null)
				{
					r_Rop_Implicit_Vector3 = new(typeof(UnityEngine.Vector2), "op_Implicit", 0, typeof(UnityEngine.Vector3));
					r_Rop_Implicit_Vector3.SetBelong(null);
				}
				return r_Rop_Implicit_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 op_Implicit(UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_Rop_Implicit_Vector2;
		public static RMethod Rop_Implicit_Vector2
		{
			get
			{
				if(r_Rop_Implicit_Vector2 == null)
				{
					r_Rop_Implicit_Vector2 = new(typeof(UnityEngine.Vector2), "op_Implicit", 0, typeof(UnityEngine.Vector2));
					r_Rop_Implicit_Vector2.SetBelong(null);
				}
				return r_Rop_Implicit_Vector2;
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


        public RVector2() : base("UnityEngine.Vector2")
        {
        }

        public RVector2(System.Object instance) : base("UnityEngine.Vector2")
		{
            SetInstance(instance);
		}

        public RVector2(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RVector2(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Set(System.Single  @newX, System.Single  @newY)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newX, @newY};
            var ___result = RSet_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Vector2 Lerp(UnityEngine.Vector2  @a, UnityEngine.Vector2  @b, System.Single  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RLerp_Vector2_Vector2_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 LerpUnclamped(UnityEngine.Vector2  @a, UnityEngine.Vector2  @b, System.Single  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RLerpUnclamped_Vector2_Vector2_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 MoveTowards(UnityEngine.Vector2  @current, UnityEngine.Vector2  @target, System.Single  @maxDistanceDelta)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@current, @target, @maxDistanceDelta};
            var ___result = RMoveTowards_Vector2_Vector2_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 Scale(UnityEngine.Vector2  @a, UnityEngine.Vector2  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RScale_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual void Scale(UnityEngine.Vector2  @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scale};
            var ___result = RScale_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Normalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RNormalize.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Boolean Equals(UnityEngine.Vector2  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.Vector2 Reflect(UnityEngine.Vector2  @inDirection, UnityEngine.Vector2  @inNormal)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inDirection, @inNormal};
            var ___result = RReflect_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 Perpendicular(UnityEngine.Vector2  @inDirection)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inDirection};
            var ___result = RPerpendicular_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static System.Single Dot(UnityEngine.Vector2  @lhs, UnityEngine.Vector2  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RDot_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Single Angle(UnityEngine.Vector2  @from, UnityEngine.Vector2  @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RAngle_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Single SignedAngle(UnityEngine.Vector2  @from, UnityEngine.Vector2  @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RSignedAngle_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Single Distance(UnityEngine.Vector2  @a, UnityEngine.Vector2  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RDistance_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static UnityEngine.Vector2 ClampMagnitude(UnityEngine.Vector2  @vector, System.Single  @maxLength)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vector, @maxLength};
            var ___result = RClampMagnitude_Vector2_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static System.Single SqrMagnitude(UnityEngine.Vector2  @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RSqrMagnitude_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single SqrMagnitude()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSqrMagnitude.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static UnityEngine.Vector2 Min(UnityEngine.Vector2  @lhs, UnityEngine.Vector2  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMin_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 Max(UnityEngine.Vector2  @lhs, UnityEngine.Vector2  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMax_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 SmoothDamp(UnityEngine.Vector2  @current, UnityEngine.Vector2  @target, ref UnityEngine.Vector2  @currentVelocity, System.Single  @smoothTime, System.Single  @maxSpeed)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@current, @target, @currentVelocity, @smoothTime, @maxSpeed};
            var ___result = RSmoothDamp_Vector2_Vector2_Ref_Vector2_Single_Single.Invoke(___genericsType, ___parameters);
			currentVelocity = (UnityEngine.Vector2)___parameters[2];

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 SmoothDamp(UnityEngine.Vector2  @current, UnityEngine.Vector2  @target, ref UnityEngine.Vector2  @currentVelocity, System.Single  @smoothTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@current, @target, @currentVelocity, @smoothTime};
            var ___result = RSmoothDamp_Vector2_Vector2_Ref_Vector2_Single.Invoke(___genericsType, ___parameters);
			currentVelocity = (UnityEngine.Vector2)___parameters[2];

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 SmoothDamp(UnityEngine.Vector2  @current, UnityEngine.Vector2  @target, ref UnityEngine.Vector2  @currentVelocity, System.Single  @smoothTime, System.Single  @maxSpeed, System.Single  @deltaTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@current, @target, @currentVelocity, @smoothTime, @maxSpeed, @deltaTime};
            var ___result = RSmoothDamp_Vector2_Vector2_Ref_Vector2_Single_Single_Single.Invoke(___genericsType, ___parameters);
			currentVelocity = (UnityEngine.Vector2)___parameters[2];

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 op_Addition(UnityEngine.Vector2  @a, UnityEngine.Vector2  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Addition_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 op_Subtraction(UnityEngine.Vector2  @a, UnityEngine.Vector2  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Subtraction_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 op_Multiply(UnityEngine.Vector2  @a, UnityEngine.Vector2  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Multiply_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 op_Division(UnityEngine.Vector2  @a, UnityEngine.Vector2  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Division_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 op_UnaryNegation(UnityEngine.Vector2  @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = Rop_UnaryNegation_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 op_Multiply(UnityEngine.Vector2  @a, System.Single  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @d};
            var ___result = Rop_Multiply_Vector2_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 op_Multiply(System.Single  @d, UnityEngine.Vector2  @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d, @a};
            var ___result = Rop_Multiply_Single_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 op_Division(UnityEngine.Vector2  @a, System.Single  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @d};
            var ___result = Rop_Division_Vector2_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Vector2  @lhs, UnityEngine.Vector2  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Vector2  @lhs, UnityEngine.Vector2  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.Vector2 op_Implicit(UnityEngine.Vector3  @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = Rop_Implicit_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector3 op_Implicit(UnityEngine.Vector2  @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = Rop_Implicit_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
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
