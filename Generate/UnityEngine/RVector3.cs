using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Vector3
	/// </summary>
    public partial class RVector3 : RMember //
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
					r_kEpsilon = new(typeof(UnityEngine.Vector3), "kEpsilon");
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
					r_kEpsilonNormalSqrt = new(typeof(UnityEngine.Vector3), "kEpsilonNormalSqrt");
					r_kEpsilonNormalSqrt.SetBelong(null);
				}
				return r_kEpsilonNormalSqrt;
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
		/// UnityEngine.Vector3 zeroVector
		/// </summary>
		protected static RUnityEngine.RVector3 r_zeroVector;
		public static RUnityEngine.RVector3 RzeroVector
		{
			get
			{
				if(r_zeroVector == null)
				{
					r_zeroVector = new(typeof(UnityEngine.Vector3), "zeroVector");
					r_zeroVector.SetBelong(null);
				}
				return r_zeroVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 oneVector
		/// </summary>
		protected static RUnityEngine.RVector3 r_oneVector;
		public static RUnityEngine.RVector3 RoneVector
		{
			get
			{
				if(r_oneVector == null)
				{
					r_oneVector = new(typeof(UnityEngine.Vector3), "oneVector");
					r_oneVector.SetBelong(null);
				}
				return r_oneVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 upVector
		/// </summary>
		protected static RUnityEngine.RVector3 r_upVector;
		public static RUnityEngine.RVector3 RupVector
		{
			get
			{
				if(r_upVector == null)
				{
					r_upVector = new(typeof(UnityEngine.Vector3), "upVector");
					r_upVector.SetBelong(null);
				}
				return r_upVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 downVector
		/// </summary>
		protected static RUnityEngine.RVector3 r_downVector;
		public static RUnityEngine.RVector3 RdownVector
		{
			get
			{
				if(r_downVector == null)
				{
					r_downVector = new(typeof(UnityEngine.Vector3), "downVector");
					r_downVector.SetBelong(null);
				}
				return r_downVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 leftVector
		/// </summary>
		protected static RUnityEngine.RVector3 r_leftVector;
		public static RUnityEngine.RVector3 RleftVector
		{
			get
			{
				if(r_leftVector == null)
				{
					r_leftVector = new(typeof(UnityEngine.Vector3), "leftVector");
					r_leftVector.SetBelong(null);
				}
				return r_leftVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 rightVector
		/// </summary>
		protected static RUnityEngine.RVector3 r_rightVector;
		public static RUnityEngine.RVector3 RrightVector
		{
			get
			{
				if(r_rightVector == null)
				{
					r_rightVector = new(typeof(UnityEngine.Vector3), "rightVector");
					r_rightVector.SetBelong(null);
				}
				return r_rightVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 forwardVector
		/// </summary>
		protected static RUnityEngine.RVector3 r_forwardVector;
		public static RUnityEngine.RVector3 RforwardVector
		{
			get
			{
				if(r_forwardVector == null)
				{
					r_forwardVector = new(typeof(UnityEngine.Vector3), "forwardVector");
					r_forwardVector.SetBelong(null);
				}
				return r_forwardVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 backVector
		/// </summary>
		protected static RUnityEngine.RVector3 r_backVector;
		public static RUnityEngine.RVector3 RbackVector
		{
			get
			{
				if(r_backVector == null)
				{
					r_backVector = new(typeof(UnityEngine.Vector3), "backVector");
					r_backVector.SetBelong(null);
				}
				return r_backVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 positiveInfinityVector
		/// </summary>
		protected static RUnityEngine.RVector3 r_positiveInfinityVector;
		public static RUnityEngine.RVector3 RpositiveInfinityVector
		{
			get
			{
				if(r_positiveInfinityVector == null)
				{
					r_positiveInfinityVector = new(typeof(UnityEngine.Vector3), "positiveInfinityVector");
					r_positiveInfinityVector.SetBelong(null);
				}
				return r_positiveInfinityVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 negativeInfinityVector
		/// </summary>
		protected static RUnityEngine.RVector3 r_negativeInfinityVector;
		public static RUnityEngine.RVector3 RnegativeInfinityVector
		{
			get
			{
				if(r_negativeInfinityVector == null)
				{
					r_negativeInfinityVector = new(typeof(UnityEngine.Vector3), "negativeInfinityVector");
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
		/// UnityEngine.Vector3 normalized
		/// </summary>
		protected RUnityEngine.RVector3 r_normalized;
		public virtual RUnityEngine.RVector3 Rnormalized
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
		/// UnityEngine.Vector3 zero
		/// </summary>
		protected static RUnityEngine.RVector3 r_zero;
		public static RUnityEngine.RVector3 Rzero
		{
			get
			{
				if(r_zero == null)
				{
					r_zero = new(typeof(UnityEngine.Vector3), "zero", -1);
					r_zero.SetBelong(null);
				}
				return r_zero;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 one
		/// </summary>
		protected static RUnityEngine.RVector3 r_one;
		public static RUnityEngine.RVector3 Rone
		{
			get
			{
				if(r_one == null)
				{
					r_one = new(typeof(UnityEngine.Vector3), "one", -1);
					r_one.SetBelong(null);
				}
				return r_one;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 forward
		/// </summary>
		protected static RUnityEngine.RVector3 r_forward;
		public static RUnityEngine.RVector3 Rforward
		{
			get
			{
				if(r_forward == null)
				{
					r_forward = new(typeof(UnityEngine.Vector3), "forward", -1);
					r_forward.SetBelong(null);
				}
				return r_forward;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 back
		/// </summary>
		protected static RUnityEngine.RVector3 r_back;
		public static RUnityEngine.RVector3 Rback
		{
			get
			{
				if(r_back == null)
				{
					r_back = new(typeof(UnityEngine.Vector3), "back", -1);
					r_back.SetBelong(null);
				}
				return r_back;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 up
		/// </summary>
		protected static RUnityEngine.RVector3 r_up;
		public static RUnityEngine.RVector3 Rup
		{
			get
			{
				if(r_up == null)
				{
					r_up = new(typeof(UnityEngine.Vector3), "up", -1);
					r_up.SetBelong(null);
				}
				return r_up;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 down
		/// </summary>
		protected static RUnityEngine.RVector3 r_down;
		public static RUnityEngine.RVector3 Rdown
		{
			get
			{
				if(r_down == null)
				{
					r_down = new(typeof(UnityEngine.Vector3), "down", -1);
					r_down.SetBelong(null);
				}
				return r_down;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 left
		/// </summary>
		protected static RUnityEngine.RVector3 r_left;
		public static RUnityEngine.RVector3 Rleft
		{
			get
			{
				if(r_left == null)
				{
					r_left = new(typeof(UnityEngine.Vector3), "left", -1);
					r_left.SetBelong(null);
				}
				return r_left;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 right
		/// </summary>
		protected static RUnityEngine.RVector3 r_right;
		public static RUnityEngine.RVector3 Rright
		{
			get
			{
				if(r_right == null)
				{
					r_right = new(typeof(UnityEngine.Vector3), "right", -1);
					r_right.SetBelong(null);
				}
				return r_right;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 positiveInfinity
		/// </summary>
		protected static RUnityEngine.RVector3 r_positiveInfinity;
		public static RUnityEngine.RVector3 RpositiveInfinity
		{
			get
			{
				if(r_positiveInfinity == null)
				{
					r_positiveInfinity = new(typeof(UnityEngine.Vector3), "positiveInfinity", -1);
					r_positiveInfinity.SetBelong(null);
				}
				return r_positiveInfinity;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 negativeInfinity
		/// </summary>
		protected static RUnityEngine.RVector3 r_negativeInfinity;
		public static RUnityEngine.RVector3 RnegativeInfinity
		{
			get
			{
				if(r_negativeInfinity == null)
				{
					r_negativeInfinity = new(typeof(UnityEngine.Vector3), "negativeInfinity", -1);
					r_negativeInfinity.SetBelong(null);
				}
				return r_negativeInfinity;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 fwd
		/// </summary>
		protected static RUnityEngine.RVector3 r_fwd;
		public static RUnityEngine.RVector3 Rfwd
		{
			get
			{
				if(r_fwd == null)
				{
					r_fwd = new(typeof(UnityEngine.Vector3), "fwd", -1);
					r_fwd.SetBelong(null);
				}
				return r_fwd;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 Slerp(UnityEngine.Vector3, UnityEngine.Vector3, Single)
		/// </summary>
		protected static RMethod r_RSlerp_Vector3_Vector3_Single;
		public static RMethod RSlerp_Vector3_Vector3_Single
		{
			get
			{
				if(r_RSlerp_Vector3_Vector3_Single == null)
				{
					r_RSlerp_Vector3_Vector3_Single = new(typeof(UnityEngine.Vector3), "Slerp", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Single));
					r_RSlerp_Vector3_Vector3_Single.SetBelong(null);
				}
				return r_RSlerp_Vector3_Vector3_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 SlerpUnclamped(UnityEngine.Vector3, UnityEngine.Vector3, Single)
		/// </summary>
		protected static RMethod r_RSlerpUnclamped_Vector3_Vector3_Single;
		public static RMethod RSlerpUnclamped_Vector3_Vector3_Single
		{
			get
			{
				if(r_RSlerpUnclamped_Vector3_Vector3_Single == null)
				{
					r_RSlerpUnclamped_Vector3_Vector3_Single = new(typeof(UnityEngine.Vector3), "SlerpUnclamped", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Single));
					r_RSlerpUnclamped_Vector3_Vector3_Single.SetBelong(null);
				}
				return r_RSlerpUnclamped_Vector3_Vector3_Single;
			}
		}

		/// <summary>
		/// Void OrthoNormalize2(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected static RMethod r_ROrthoNormalize2_Ref_Vector3_Ref_Vector3;
		public static RMethod ROrthoNormalize2_Ref_Vector3_Ref_Vector3
		{
			get
			{
				if(r_ROrthoNormalize2_Ref_Vector3_Ref_Vector3 == null)
				{
					r_ROrthoNormalize2_Ref_Vector3_Ref_Vector3 = new(typeof(UnityEngine.Vector3), "OrthoNormalize2", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
					r_ROrthoNormalize2_Ref_Vector3_Ref_Vector3.SetBelong(null);
				}
				return r_ROrthoNormalize2_Ref_Vector3_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void OrthoNormalize(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected static RMethod r_ROrthoNormalize_Ref_Vector3_Ref_Vector3;
		public static RMethod ROrthoNormalize_Ref_Vector3_Ref_Vector3
		{
			get
			{
				if(r_ROrthoNormalize_Ref_Vector3_Ref_Vector3 == null)
				{
					r_ROrthoNormalize_Ref_Vector3_Ref_Vector3 = new(typeof(UnityEngine.Vector3), "OrthoNormalize", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
					r_ROrthoNormalize_Ref_Vector3_Ref_Vector3.SetBelong(null);
				}
				return r_ROrthoNormalize_Ref_Vector3_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void OrthoNormalize3(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected static RMethod r_ROrthoNormalize3_Ref_Vector3_Ref_Vector3_Ref_Vector3;
		public static RMethod ROrthoNormalize3_Ref_Vector3_Ref_Vector3_Ref_Vector3
		{
			get
			{
				if(r_ROrthoNormalize3_Ref_Vector3_Ref_Vector3_Ref_Vector3 == null)
				{
					r_ROrthoNormalize3_Ref_Vector3_Ref_Vector3_Ref_Vector3 = new(typeof(UnityEngine.Vector3), "OrthoNormalize3", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
					r_ROrthoNormalize3_Ref_Vector3_Ref_Vector3_Ref_Vector3.SetBelong(null);
				}
				return r_ROrthoNormalize3_Ref_Vector3_Ref_Vector3_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void OrthoNormalize(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected static RMethod r_ROrthoNormalize_Ref_Vector3_Ref_Vector3_Ref_Vector3;
		public static RMethod ROrthoNormalize_Ref_Vector3_Ref_Vector3_Ref_Vector3
		{
			get
			{
				if(r_ROrthoNormalize_Ref_Vector3_Ref_Vector3_Ref_Vector3 == null)
				{
					r_ROrthoNormalize_Ref_Vector3_Ref_Vector3_Ref_Vector3 = new(typeof(UnityEngine.Vector3), "OrthoNormalize", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
					r_ROrthoNormalize_Ref_Vector3_Ref_Vector3_Ref_Vector3.SetBelong(null);
				}
				return r_ROrthoNormalize_Ref_Vector3_Ref_Vector3_Ref_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 RotateTowards(UnityEngine.Vector3, UnityEngine.Vector3, Single, Single)
		/// </summary>
		protected static RMethod r_RRotateTowards_Vector3_Vector3_Single_Single;
		public static RMethod RRotateTowards_Vector3_Vector3_Single_Single
		{
			get
			{
				if(r_RRotateTowards_Vector3_Vector3_Single_Single == null)
				{
					r_RRotateTowards_Vector3_Vector3_Single_Single = new(typeof(UnityEngine.Vector3), "RotateTowards", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Single), typeof(System.Single));
					r_RRotateTowards_Vector3_Vector3_Single_Single.SetBelong(null);
				}
				return r_RRotateTowards_Vector3_Vector3_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 Lerp(UnityEngine.Vector3, UnityEngine.Vector3, Single)
		/// </summary>
		protected static RMethod r_RLerp_Vector3_Vector3_Single;
		public static RMethod RLerp_Vector3_Vector3_Single
		{
			get
			{
				if(r_RLerp_Vector3_Vector3_Single == null)
				{
					r_RLerp_Vector3_Vector3_Single = new(typeof(UnityEngine.Vector3), "Lerp", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Single));
					r_RLerp_Vector3_Vector3_Single.SetBelong(null);
				}
				return r_RLerp_Vector3_Vector3_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 LerpUnclamped(UnityEngine.Vector3, UnityEngine.Vector3, Single)
		/// </summary>
		protected static RMethod r_RLerpUnclamped_Vector3_Vector3_Single;
		public static RMethod RLerpUnclamped_Vector3_Vector3_Single
		{
			get
			{
				if(r_RLerpUnclamped_Vector3_Vector3_Single == null)
				{
					r_RLerpUnclamped_Vector3_Vector3_Single = new(typeof(UnityEngine.Vector3), "LerpUnclamped", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Single));
					r_RLerpUnclamped_Vector3_Vector3_Single.SetBelong(null);
				}
				return r_RLerpUnclamped_Vector3_Vector3_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 MoveTowards(UnityEngine.Vector3, UnityEngine.Vector3, Single)
		/// </summary>
		protected static RMethod r_RMoveTowards_Vector3_Vector3_Single;
		public static RMethod RMoveTowards_Vector3_Vector3_Single
		{
			get
			{
				if(r_RMoveTowards_Vector3_Vector3_Single == null)
				{
					r_RMoveTowards_Vector3_Vector3_Single = new(typeof(UnityEngine.Vector3), "MoveTowards", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Single));
					r_RMoveTowards_Vector3_Vector3_Single.SetBelong(null);
				}
				return r_RMoveTowards_Vector3_Vector3_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 SmoothDamp(UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3 ByRef, Single, Single)
		/// </summary>
		protected static RMethod r_RSmoothDamp_Vector3_Vector3_Ref_Vector3_Single_Single;
		public static RMethod RSmoothDamp_Vector3_Vector3_Ref_Vector3_Single_Single
		{
			get
			{
				if(r_RSmoothDamp_Vector3_Vector3_Ref_Vector3_Single_Single == null)
				{
					r_RSmoothDamp_Vector3_Vector3_Ref_Vector3_Single_Single = new(typeof(UnityEngine.Vector3), "SmoothDamp", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single), typeof(System.Single));
					r_RSmoothDamp_Vector3_Vector3_Ref_Vector3_Single_Single.SetBelong(null);
				}
				return r_RSmoothDamp_Vector3_Vector3_Ref_Vector3_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 SmoothDamp(UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3 ByRef, Single)
		/// </summary>
		protected static RMethod r_RSmoothDamp_Vector3_Vector3_Ref_Vector3_Single;
		public static RMethod RSmoothDamp_Vector3_Vector3_Ref_Vector3_Single
		{
			get
			{
				if(r_RSmoothDamp_Vector3_Vector3_Ref_Vector3_Single == null)
				{
					r_RSmoothDamp_Vector3_Vector3_Ref_Vector3_Single = new(typeof(UnityEngine.Vector3), "SmoothDamp", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single));
					r_RSmoothDamp_Vector3_Vector3_Ref_Vector3_Single.SetBelong(null);
				}
				return r_RSmoothDamp_Vector3_Vector3_Ref_Vector3_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 SmoothDamp(UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3 ByRef, Single, Single, Single)
		/// </summary>
		protected static RMethod r_RSmoothDamp_Vector3_Vector3_Ref_Vector3_Single_Single_Single;
		public static RMethod RSmoothDamp_Vector3_Vector3_Ref_Vector3_Single_Single_Single
		{
			get
			{
				if(r_RSmoothDamp_Vector3_Vector3_Ref_Vector3_Single_Single_Single == null)
				{
					r_RSmoothDamp_Vector3_Vector3_Ref_Vector3_Single_Single_Single = new(typeof(UnityEngine.Vector3), "SmoothDamp", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_RSmoothDamp_Vector3_Vector3_Ref_Vector3_Single_Single_Single.SetBelong(null);
				}
				return r_RSmoothDamp_Vector3_Vector3_Ref_Vector3_Single_Single_Single;
			}
		}

		/// <summary>
		/// Void Set(Single, Single, Single)
		/// </summary>
		protected RMethod r_RSet_Single_Single_Single;
		public virtual RMethod RSet_Single_Single_Single
		{
			get
			{
				if(r_RSet_Single_Single_Single == null)
				{
					r_RSet_Single_Single_Single = new(this, "Set", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_RSet_Single_Single_Single.SetBelong(this.instance);
				}
				return r_RSet_Single_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 Scale(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_RScale_Vector3_Vector3;
		public static RMethod RScale_Vector3_Vector3
		{
			get
			{
				if(r_RScale_Vector3_Vector3 == null)
				{
					r_RScale_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "Scale", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_RScale_Vector3_Vector3.SetBelong(null);
				}
				return r_RScale_Vector3_Vector3;
			}
		}

		/// <summary>
		/// Void Scale(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RScale_Vector3;
		public virtual RMethod RScale_Vector3
		{
			get
			{
				if(r_RScale_Vector3 == null)
				{
					r_RScale_Vector3 = new(this, "Scale", 0, typeof(UnityEngine.Vector3));
					r_RScale_Vector3.SetBelong(this.instance);
				}
				return r_RScale_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 Cross(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_RCross_Vector3_Vector3;
		public static RMethod RCross_Vector3_Vector3
		{
			get
			{
				if(r_RCross_Vector3_Vector3 == null)
				{
					r_RCross_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "Cross", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_RCross_Vector3_Vector3.SetBelong(null);
				}
				return r_RCross_Vector3_Vector3;
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
		/// Boolean Equals(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_REquals_Vector3;
		public virtual RMethod REquals_Vector3
		{
			get
			{
				if(r_REquals_Vector3 == null)
				{
					r_REquals_Vector3 = new(this, "Equals", 0, typeof(UnityEngine.Vector3));
					r_REquals_Vector3.SetBelong(this.instance);
				}
				return r_REquals_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 Reflect(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_RReflect_Vector3_Vector3;
		public static RMethod RReflect_Vector3_Vector3
		{
			get
			{
				if(r_RReflect_Vector3_Vector3 == null)
				{
					r_RReflect_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "Reflect", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_RReflect_Vector3_Vector3.SetBelong(null);
				}
				return r_RReflect_Vector3_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 Normalize(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_RNormalize_Vector3;
		public static RMethod RNormalize_Vector3
		{
			get
			{
				if(r_RNormalize_Vector3 == null)
				{
					r_RNormalize_Vector3 = new(typeof(UnityEngine.Vector3), "Normalize", 0, typeof(UnityEngine.Vector3));
					r_RNormalize_Vector3.SetBelong(null);
				}
				return r_RNormalize_Vector3;
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
		/// Single Dot(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_RDot_Vector3_Vector3;
		public static RMethod RDot_Vector3_Vector3
		{
			get
			{
				if(r_RDot_Vector3_Vector3 == null)
				{
					r_RDot_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "Dot", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_RDot_Vector3_Vector3.SetBelong(null);
				}
				return r_RDot_Vector3_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 Project(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_RProject_Vector3_Vector3;
		public static RMethod RProject_Vector3_Vector3
		{
			get
			{
				if(r_RProject_Vector3_Vector3 == null)
				{
					r_RProject_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "Project", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_RProject_Vector3_Vector3.SetBelong(null);
				}
				return r_RProject_Vector3_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ProjectOnPlane(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_RProjectOnPlane_Vector3_Vector3;
		public static RMethod RProjectOnPlane_Vector3_Vector3
		{
			get
			{
				if(r_RProjectOnPlane_Vector3_Vector3 == null)
				{
					r_RProjectOnPlane_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "ProjectOnPlane", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_RProjectOnPlane_Vector3_Vector3.SetBelong(null);
				}
				return r_RProjectOnPlane_Vector3_Vector3;
			}
		}

		/// <summary>
		/// Single Angle(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_RAngle_Vector3_Vector3;
		public static RMethod RAngle_Vector3_Vector3
		{
			get
			{
				if(r_RAngle_Vector3_Vector3 == null)
				{
					r_RAngle_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "Angle", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_RAngle_Vector3_Vector3.SetBelong(null);
				}
				return r_RAngle_Vector3_Vector3;
			}
		}

		/// <summary>
		/// Single SignedAngle(UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_RSignedAngle_Vector3_Vector3_Vector3;
		public static RMethod RSignedAngle_Vector3_Vector3_Vector3
		{
			get
			{
				if(r_RSignedAngle_Vector3_Vector3_Vector3 == null)
				{
					r_RSignedAngle_Vector3_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "SignedAngle", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_RSignedAngle_Vector3_Vector3_Vector3.SetBelong(null);
				}
				return r_RSignedAngle_Vector3_Vector3_Vector3;
			}
		}

		/// <summary>
		/// Single Distance(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_RDistance_Vector3_Vector3;
		public static RMethod RDistance_Vector3_Vector3
		{
			get
			{
				if(r_RDistance_Vector3_Vector3 == null)
				{
					r_RDistance_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "Distance", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_RDistance_Vector3_Vector3.SetBelong(null);
				}
				return r_RDistance_Vector3_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ClampMagnitude(UnityEngine.Vector3, Single)
		/// </summary>
		protected static RMethod r_RClampMagnitude_Vector3_Single;
		public static RMethod RClampMagnitude_Vector3_Single
		{
			get
			{
				if(r_RClampMagnitude_Vector3_Single == null)
				{
					r_RClampMagnitude_Vector3_Single = new(typeof(UnityEngine.Vector3), "ClampMagnitude", 0, typeof(UnityEngine.Vector3), typeof(System.Single));
					r_RClampMagnitude_Vector3_Single.SetBelong(null);
				}
				return r_RClampMagnitude_Vector3_Single;
			}
		}

		/// <summary>
		/// Single Magnitude(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_RMagnitude_Vector3;
		public static RMethod RMagnitude_Vector3
		{
			get
			{
				if(r_RMagnitude_Vector3 == null)
				{
					r_RMagnitude_Vector3 = new(typeof(UnityEngine.Vector3), "Magnitude", 0, typeof(UnityEngine.Vector3));
					r_RMagnitude_Vector3.SetBelong(null);
				}
				return r_RMagnitude_Vector3;
			}
		}

		/// <summary>
		/// Single SqrMagnitude(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_RSqrMagnitude_Vector3;
		public static RMethod RSqrMagnitude_Vector3
		{
			get
			{
				if(r_RSqrMagnitude_Vector3 == null)
				{
					r_RSqrMagnitude_Vector3 = new(typeof(UnityEngine.Vector3), "SqrMagnitude", 0, typeof(UnityEngine.Vector3));
					r_RSqrMagnitude_Vector3.SetBelong(null);
				}
				return r_RSqrMagnitude_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 Min(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_RMin_Vector3_Vector3;
		public static RMethod RMin_Vector3_Vector3
		{
			get
			{
				if(r_RMin_Vector3_Vector3 == null)
				{
					r_RMin_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "Min", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_RMin_Vector3_Vector3.SetBelong(null);
				}
				return r_RMin_Vector3_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 Max(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_RMax_Vector3_Vector3;
		public static RMethod RMax_Vector3_Vector3
		{
			get
			{
				if(r_RMax_Vector3_Vector3 == null)
				{
					r_RMax_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "Max", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_RMax_Vector3_Vector3.SetBelong(null);
				}
				return r_RMax_Vector3_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 op_Addition(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_Rop_Addition_Vector3_Vector3;
		public static RMethod Rop_Addition_Vector3_Vector3
		{
			get
			{
				if(r_Rop_Addition_Vector3_Vector3 == null)
				{
					r_Rop_Addition_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "op_Addition", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_Rop_Addition_Vector3_Vector3.SetBelong(null);
				}
				return r_Rop_Addition_Vector3_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 op_Subtraction(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_Rop_Subtraction_Vector3_Vector3;
		public static RMethod Rop_Subtraction_Vector3_Vector3
		{
			get
			{
				if(r_Rop_Subtraction_Vector3_Vector3 == null)
				{
					r_Rop_Subtraction_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "op_Subtraction", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_Rop_Subtraction_Vector3_Vector3.SetBelong(null);
				}
				return r_Rop_Subtraction_Vector3_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 op_UnaryNegation(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_Rop_UnaryNegation_Vector3;
		public static RMethod Rop_UnaryNegation_Vector3
		{
			get
			{
				if(r_Rop_UnaryNegation_Vector3 == null)
				{
					r_Rop_UnaryNegation_Vector3 = new(typeof(UnityEngine.Vector3), "op_UnaryNegation", 0, typeof(UnityEngine.Vector3));
					r_Rop_UnaryNegation_Vector3.SetBelong(null);
				}
				return r_Rop_UnaryNegation_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 op_Multiply(UnityEngine.Vector3, Single)
		/// </summary>
		protected static RMethod r_Rop_Multiply_Vector3_Single;
		public static RMethod Rop_Multiply_Vector3_Single
		{
			get
			{
				if(r_Rop_Multiply_Vector3_Single == null)
				{
					r_Rop_Multiply_Vector3_Single = new(typeof(UnityEngine.Vector3), "op_Multiply", 0, typeof(UnityEngine.Vector3), typeof(System.Single));
					r_Rop_Multiply_Vector3_Single.SetBelong(null);
				}
				return r_Rop_Multiply_Vector3_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 op_Multiply(Single, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_Rop_Multiply_Single_Vector3;
		public static RMethod Rop_Multiply_Single_Vector3
		{
			get
			{
				if(r_Rop_Multiply_Single_Vector3 == null)
				{
					r_Rop_Multiply_Single_Vector3 = new(typeof(UnityEngine.Vector3), "op_Multiply", 0, typeof(System.Single), typeof(UnityEngine.Vector3));
					r_Rop_Multiply_Single_Vector3.SetBelong(null);
				}
				return r_Rop_Multiply_Single_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 op_Division(UnityEngine.Vector3, Single)
		/// </summary>
		protected static RMethod r_Rop_Division_Vector3_Single;
		public static RMethod Rop_Division_Vector3_Single
		{
			get
			{
				if(r_Rop_Division_Vector3_Single == null)
				{
					r_Rop_Division_Vector3_Single = new(typeof(UnityEngine.Vector3), "op_Division", 0, typeof(UnityEngine.Vector3), typeof(System.Single));
					r_Rop_Division_Vector3_Single.SetBelong(null);
				}
				return r_Rop_Division_Vector3_Single;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_Rop_Equality_Vector3_Vector3;
		public static RMethod Rop_Equality_Vector3_Vector3
		{
			get
			{
				if(r_Rop_Equality_Vector3_Vector3 == null)
				{
					r_Rop_Equality_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "op_Equality", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_Rop_Equality_Vector3_Vector3.SetBelong(null);
				}
				return r_Rop_Equality_Vector3_Vector3;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_Rop_Inequality_Vector3_Vector3;
		public static RMethod Rop_Inequality_Vector3_Vector3
		{
			get
			{
				if(r_Rop_Inequality_Vector3_Vector3 == null)
				{
					r_Rop_Inequality_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "op_Inequality", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_Rop_Inequality_Vector3_Vector3.SetBelong(null);
				}
				return r_Rop_Inequality_Vector3_Vector3;
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
		/// Single AngleBetween(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_RAngleBetween_Vector3_Vector3;
		public static RMethod RAngleBetween_Vector3_Vector3
		{
			get
			{
				if(r_RAngleBetween_Vector3_Vector3 == null)
				{
					r_RAngleBetween_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "AngleBetween", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_RAngleBetween_Vector3_Vector3.SetBelong(null);
				}
				return r_RAngleBetween_Vector3_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 Exclude(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_RExclude_Vector3_Vector3;
		public static RMethod RExclude_Vector3_Vector3
		{
			get
			{
				if(r_RExclude_Vector3_Vector3 == null)
				{
					r_RExclude_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "Exclude", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_RExclude_Vector3_Vector3.SetBelong(null);
				}
				return r_RExclude_Vector3_Vector3;
			}
		}

		/// <summary>
		/// Void Slerp_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef, Single, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected static RMethod r_RSlerp_Injected_Ref_Vector3_Ref_Vector3_Single_Out_Vector3;
		public static RMethod RSlerp_Injected_Ref_Vector3_Ref_Vector3_Single_Out_Vector3
		{
			get
			{
				if(r_RSlerp_Injected_Ref_Vector3_Ref_Vector3_Single_Out_Vector3 == null)
				{
					r_RSlerp_Injected_Ref_Vector3_Ref_Vector3_Single_Out_Vector3 = new(typeof(UnityEngine.Vector3), "Slerp_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single), typeof(UnityEngine.Vector3).MakeByRefType());
					r_RSlerp_Injected_Ref_Vector3_Ref_Vector3_Single_Out_Vector3.SetBelong(null);
				}
				return r_RSlerp_Injected_Ref_Vector3_Ref_Vector3_Single_Out_Vector3;
			}
		}

		/// <summary>
		/// Void SlerpUnclamped_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef, Single, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected static RMethod r_RSlerpUnclamped_Injected_Ref_Vector3_Ref_Vector3_Single_Out_Vector3;
		public static RMethod RSlerpUnclamped_Injected_Ref_Vector3_Ref_Vector3_Single_Out_Vector3
		{
			get
			{
				if(r_RSlerpUnclamped_Injected_Ref_Vector3_Ref_Vector3_Single_Out_Vector3 == null)
				{
					r_RSlerpUnclamped_Injected_Ref_Vector3_Ref_Vector3_Single_Out_Vector3 = new(typeof(UnityEngine.Vector3), "SlerpUnclamped_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single), typeof(UnityEngine.Vector3).MakeByRefType());
					r_RSlerpUnclamped_Injected_Ref_Vector3_Ref_Vector3_Single_Out_Vector3.SetBelong(null);
				}
				return r_RSlerpUnclamped_Injected_Ref_Vector3_Ref_Vector3_Single_Out_Vector3;
			}
		}

		/// <summary>
		/// Void RotateTowards_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef, Single, Single, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected static RMethod r_RRotateTowards_Injected_Ref_Vector3_Ref_Vector3_Single_Single_Out_Vector3;
		public static RMethod RRotateTowards_Injected_Ref_Vector3_Ref_Vector3_Single_Single_Out_Vector3
		{
			get
			{
				if(r_RRotateTowards_Injected_Ref_Vector3_Ref_Vector3_Single_Single_Out_Vector3 == null)
				{
					r_RRotateTowards_Injected_Ref_Vector3_Ref_Vector3_Single_Single_Out_Vector3 = new(typeof(UnityEngine.Vector3), "RotateTowards_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.Vector3).MakeByRefType());
					r_RRotateTowards_Injected_Ref_Vector3_Ref_Vector3_Single_Single_Out_Vector3.SetBelong(null);
				}
				return r_RRotateTowards_Injected_Ref_Vector3_Ref_Vector3_Single_Single_Out_Vector3;
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


        public RVector3() : base("UnityEngine.Vector3")
        {
        }

        public RVector3(System.Object instance) : base("UnityEngine.Vector3")
		{
            SetInstance(instance);
		}

        public RVector3(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RVector3(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEngine.Vector3 Slerp(UnityEngine.Vector3  @a, UnityEngine.Vector3  @b, System.Single  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RSlerp_Vector3_Vector3_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 SlerpUnclamped(UnityEngine.Vector3  @a, UnityEngine.Vector3  @b, System.Single  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RSlerpUnclamped_Vector3_Vector3_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static void OrthoNormalize2(ref UnityEngine.Vector3  @a, ref UnityEngine.Vector3  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = ROrthoNormalize2_Ref_Vector3_Ref_Vector3.Invoke(___genericsType, ___parameters);
			a = (UnityEngine.Vector3)___parameters[0];
			b = (UnityEngine.Vector3)___parameters[1];

            
        }


        public static void OrthoNormalize(ref UnityEngine.Vector3  @normal, ref UnityEngine.Vector3  @tangent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@normal, @tangent};
            var ___result = ROrthoNormalize_Ref_Vector3_Ref_Vector3.Invoke(___genericsType, ___parameters);
			normal = (UnityEngine.Vector3)___parameters[0];
			tangent = (UnityEngine.Vector3)___parameters[1];

            
        }


        public static void OrthoNormalize3(ref UnityEngine.Vector3  @a, ref UnityEngine.Vector3  @b, ref UnityEngine.Vector3  @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @c};
            var ___result = ROrthoNormalize3_Ref_Vector3_Ref_Vector3_Ref_Vector3.Invoke(___genericsType, ___parameters);
			a = (UnityEngine.Vector3)___parameters[0];
			b = (UnityEngine.Vector3)___parameters[1];
			c = (UnityEngine.Vector3)___parameters[2];

            
        }


        public static void OrthoNormalize(ref UnityEngine.Vector3  @normal, ref UnityEngine.Vector3  @tangent, ref UnityEngine.Vector3  @binormal)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@normal, @tangent, @binormal};
            var ___result = ROrthoNormalize_Ref_Vector3_Ref_Vector3_Ref_Vector3.Invoke(___genericsType, ___parameters);
			normal = (UnityEngine.Vector3)___parameters[0];
			tangent = (UnityEngine.Vector3)___parameters[1];
			binormal = (UnityEngine.Vector3)___parameters[2];

            
        }


        public static UnityEngine.Vector3 RotateTowards(UnityEngine.Vector3  @current, UnityEngine.Vector3  @target, System.Single  @maxRadiansDelta, System.Single  @maxMagnitudeDelta)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@current, @target, @maxRadiansDelta, @maxMagnitudeDelta};
            var ___result = RRotateTowards_Vector3_Vector3_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 Lerp(UnityEngine.Vector3  @a, UnityEngine.Vector3  @b, System.Single  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RLerp_Vector3_Vector3_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 LerpUnclamped(UnityEngine.Vector3  @a, UnityEngine.Vector3  @b, System.Single  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RLerpUnclamped_Vector3_Vector3_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 MoveTowards(UnityEngine.Vector3  @current, UnityEngine.Vector3  @target, System.Single  @maxDistanceDelta)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@current, @target, @maxDistanceDelta};
            var ___result = RMoveTowards_Vector3_Vector3_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 SmoothDamp(UnityEngine.Vector3  @current, UnityEngine.Vector3  @target, ref UnityEngine.Vector3  @currentVelocity, System.Single  @smoothTime, System.Single  @maxSpeed)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@current, @target, @currentVelocity, @smoothTime, @maxSpeed};
            var ___result = RSmoothDamp_Vector3_Vector3_Ref_Vector3_Single_Single.Invoke(___genericsType, ___parameters);
			currentVelocity = (UnityEngine.Vector3)___parameters[2];

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 SmoothDamp(UnityEngine.Vector3  @current, UnityEngine.Vector3  @target, ref UnityEngine.Vector3  @currentVelocity, System.Single  @smoothTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@current, @target, @currentVelocity, @smoothTime};
            var ___result = RSmoothDamp_Vector3_Vector3_Ref_Vector3_Single.Invoke(___genericsType, ___parameters);
			currentVelocity = (UnityEngine.Vector3)___parameters[2];

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 SmoothDamp(UnityEngine.Vector3  @current, UnityEngine.Vector3  @target, ref UnityEngine.Vector3  @currentVelocity, System.Single  @smoothTime, System.Single  @maxSpeed, System.Single  @deltaTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@current, @target, @currentVelocity, @smoothTime, @maxSpeed, @deltaTime};
            var ___result = RSmoothDamp_Vector3_Vector3_Ref_Vector3_Single_Single_Single.Invoke(___genericsType, ___parameters);
			currentVelocity = (UnityEngine.Vector3)___parameters[2];

            return (UnityEngine.Vector3)___result;
        }


        public virtual void Set(System.Single  @newX, System.Single  @newY, System.Single  @newZ)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newX, @newY, @newZ};
            var ___result = RSet_Single_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Vector3 Scale(UnityEngine.Vector3  @a, UnityEngine.Vector3  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RScale_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual void Scale(UnityEngine.Vector3  @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scale};
            var ___result = RScale_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Vector3 Cross(UnityEngine.Vector3  @lhs, UnityEngine.Vector3  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RCross_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
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


        public virtual System.Boolean Equals(UnityEngine.Vector3  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.Vector3 Reflect(UnityEngine.Vector3  @inDirection, UnityEngine.Vector3  @inNormal)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inDirection, @inNormal};
            var ___result = RReflect_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 Normalize(UnityEngine.Vector3  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RNormalize_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual void Normalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RNormalize.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Single Dot(UnityEngine.Vector3  @lhs, UnityEngine.Vector3  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RDot_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static UnityEngine.Vector3 Project(UnityEngine.Vector3  @vector, UnityEngine.Vector3  @onNormal)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vector, @onNormal};
            var ___result = RProject_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 ProjectOnPlane(UnityEngine.Vector3  @vector, UnityEngine.Vector3  @planeNormal)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vector, @planeNormal};
            var ___result = RProjectOnPlane_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static System.Single Angle(UnityEngine.Vector3  @from, UnityEngine.Vector3  @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RAngle_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Single SignedAngle(UnityEngine.Vector3  @from, UnityEngine.Vector3  @to, UnityEngine.Vector3  @axis)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @axis};
            var ___result = RSignedAngle_Vector3_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Single Distance(UnityEngine.Vector3  @a, UnityEngine.Vector3  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RDistance_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static UnityEngine.Vector3 ClampMagnitude(UnityEngine.Vector3  @vector, System.Single  @maxLength)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vector, @maxLength};
            var ___result = RClampMagnitude_Vector3_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static System.Single Magnitude(UnityEngine.Vector3  @vector)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vector};
            var ___result = RMagnitude_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Single SqrMagnitude(UnityEngine.Vector3  @vector)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vector};
            var ___result = RSqrMagnitude_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static UnityEngine.Vector3 Min(UnityEngine.Vector3  @lhs, UnityEngine.Vector3  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMin_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 Max(UnityEngine.Vector3  @lhs, UnityEngine.Vector3  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMax_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 op_Addition(UnityEngine.Vector3  @a, UnityEngine.Vector3  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Addition_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 op_Subtraction(UnityEngine.Vector3  @a, UnityEngine.Vector3  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Subtraction_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 op_UnaryNegation(UnityEngine.Vector3  @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = Rop_UnaryNegation_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 op_Multiply(UnityEngine.Vector3  @a, System.Single  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @d};
            var ___result = Rop_Multiply_Vector3_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 op_Multiply(System.Single  @d, UnityEngine.Vector3  @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d, @a};
            var ___result = Rop_Multiply_Single_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 op_Division(UnityEngine.Vector3  @a, System.Single  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @d};
            var ___result = Rop_Division_Vector3_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Vector3  @lhs, UnityEngine.Vector3  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Vector3  @lhs, UnityEngine.Vector3  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public static System.Single AngleBetween(UnityEngine.Vector3  @from, UnityEngine.Vector3  @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RAngleBetween_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static UnityEngine.Vector3 Exclude(UnityEngine.Vector3  @excludeThis, UnityEngine.Vector3  @fromThat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@excludeThis, @fromThat};
            var ___result = RExclude_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static void Slerp_Injected(ref UnityEngine.Vector3  @a, ref UnityEngine.Vector3  @b, System.Single  @t, out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t, @ret};
            var ___result = RSlerp_Injected_Ref_Vector3_Ref_Vector3_Single_Out_Vector3.Invoke(___genericsType, ___parameters);
			a = (UnityEngine.Vector3)___parameters[0];
			b = (UnityEngine.Vector3)___parameters[1];
			ret = (UnityEngine.Vector3)___parameters[3];

            
        }


        public static void SlerpUnclamped_Injected(ref UnityEngine.Vector3  @a, ref UnityEngine.Vector3  @b, System.Single  @t, out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t, @ret};
            var ___result = RSlerpUnclamped_Injected_Ref_Vector3_Ref_Vector3_Single_Out_Vector3.Invoke(___genericsType, ___parameters);
			a = (UnityEngine.Vector3)___parameters[0];
			b = (UnityEngine.Vector3)___parameters[1];
			ret = (UnityEngine.Vector3)___parameters[3];

            
        }


        public static void RotateTowards_Injected(ref UnityEngine.Vector3  @current, ref UnityEngine.Vector3  @target, System.Single  @maxRadiansDelta, System.Single  @maxMagnitudeDelta, out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@current, @target, @maxRadiansDelta, @maxMagnitudeDelta, @ret};
            var ___result = RRotateTowards_Injected_Ref_Vector3_Ref_Vector3_Single_Single_Out_Vector3.Invoke(___genericsType, ___parameters);
			current = (UnityEngine.Vector3)___parameters[0];
			target = (UnityEngine.Vector3)___parameters[1];
			ret = (UnityEngine.Vector3)___parameters[4];

            
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
