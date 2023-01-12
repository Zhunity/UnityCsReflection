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
		protected static RSystem.RSingle r_FkEpsilon;
		public static RSystem.RSingle RFkEpsilon
		{
			get
			{
				if(r_FkEpsilon == null)
				{
					r_FkEpsilon = new(typeof(UnityEngine.Vector3), "kEpsilon");
					r_FkEpsilon.SetBelong(null);
				}
				return r_FkEpsilon;
			}
		}

		/// <summary>
		/// System.Single kEpsilonNormalSqrt
		/// </summary>
		protected static RSystem.RSingle r_FkEpsilonNormalSqrt;
		public static RSystem.RSingle RFkEpsilonNormalSqrt
		{
			get
			{
				if(r_FkEpsilonNormalSqrt == null)
				{
					r_FkEpsilonNormalSqrt = new(typeof(UnityEngine.Vector3), "kEpsilonNormalSqrt");
					r_FkEpsilonNormalSqrt.SetBelong(null);
				}
				return r_FkEpsilonNormalSqrt;
			}
		}

		/// <summary>
		/// System.Single x
		/// </summary>
		protected RSystem.RSingle r_Fx;
		public virtual RSystem.RSingle RFx
		{
			get
			{
				if(r_Fx == null)
				{
					r_Fx = new(this, "x");
					r_Fx.SetBelong(this.instance);
				}
				return r_Fx;
			}
		}

		/// <summary>
		/// System.Single y
		/// </summary>
		protected RSystem.RSingle r_Fy;
		public virtual RSystem.RSingle RFy
		{
			get
			{
				if(r_Fy == null)
				{
					r_Fy = new(this, "y");
					r_Fy.SetBelong(this.instance);
				}
				return r_Fy;
			}
		}

		/// <summary>
		/// System.Single z
		/// </summary>
		protected RSystem.RSingle r_Fz;
		public virtual RSystem.RSingle RFz
		{
			get
			{
				if(r_Fz == null)
				{
					r_Fz = new(this, "z");
					r_Fz.SetBelong(this.instance);
				}
				return r_Fz;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 zeroVector
		/// </summary>
		protected static RUnityEngine.RVector3 r_FzeroVector;
		public static RUnityEngine.RVector3 RFzeroVector
		{
			get
			{
				if(r_FzeroVector == null)
				{
					r_FzeroVector = new(typeof(UnityEngine.Vector3), "zeroVector");
					r_FzeroVector.SetBelong(null);
				}
				return r_FzeroVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 oneVector
		/// </summary>
		protected static RUnityEngine.RVector3 r_FoneVector;
		public static RUnityEngine.RVector3 RFoneVector
		{
			get
			{
				if(r_FoneVector == null)
				{
					r_FoneVector = new(typeof(UnityEngine.Vector3), "oneVector");
					r_FoneVector.SetBelong(null);
				}
				return r_FoneVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 upVector
		/// </summary>
		protected static RUnityEngine.RVector3 r_FupVector;
		public static RUnityEngine.RVector3 RFupVector
		{
			get
			{
				if(r_FupVector == null)
				{
					r_FupVector = new(typeof(UnityEngine.Vector3), "upVector");
					r_FupVector.SetBelong(null);
				}
				return r_FupVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 downVector
		/// </summary>
		protected static RUnityEngine.RVector3 r_FdownVector;
		public static RUnityEngine.RVector3 RFdownVector
		{
			get
			{
				if(r_FdownVector == null)
				{
					r_FdownVector = new(typeof(UnityEngine.Vector3), "downVector");
					r_FdownVector.SetBelong(null);
				}
				return r_FdownVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 leftVector
		/// </summary>
		protected static RUnityEngine.RVector3 r_FleftVector;
		public static RUnityEngine.RVector3 RFleftVector
		{
			get
			{
				if(r_FleftVector == null)
				{
					r_FleftVector = new(typeof(UnityEngine.Vector3), "leftVector");
					r_FleftVector.SetBelong(null);
				}
				return r_FleftVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 rightVector
		/// </summary>
		protected static RUnityEngine.RVector3 r_FrightVector;
		public static RUnityEngine.RVector3 RFrightVector
		{
			get
			{
				if(r_FrightVector == null)
				{
					r_FrightVector = new(typeof(UnityEngine.Vector3), "rightVector");
					r_FrightVector.SetBelong(null);
				}
				return r_FrightVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 forwardVector
		/// </summary>
		protected static RUnityEngine.RVector3 r_FforwardVector;
		public static RUnityEngine.RVector3 RFforwardVector
		{
			get
			{
				if(r_FforwardVector == null)
				{
					r_FforwardVector = new(typeof(UnityEngine.Vector3), "forwardVector");
					r_FforwardVector.SetBelong(null);
				}
				return r_FforwardVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 backVector
		/// </summary>
		protected static RUnityEngine.RVector3 r_FbackVector;
		public static RUnityEngine.RVector3 RFbackVector
		{
			get
			{
				if(r_FbackVector == null)
				{
					r_FbackVector = new(typeof(UnityEngine.Vector3), "backVector");
					r_FbackVector.SetBelong(null);
				}
				return r_FbackVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 positiveInfinityVector
		/// </summary>
		protected static RUnityEngine.RVector3 r_FpositiveInfinityVector;
		public static RUnityEngine.RVector3 RFpositiveInfinityVector
		{
			get
			{
				if(r_FpositiveInfinityVector == null)
				{
					r_FpositiveInfinityVector = new(typeof(UnityEngine.Vector3), "positiveInfinityVector");
					r_FpositiveInfinityVector.SetBelong(null);
				}
				return r_FpositiveInfinityVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 negativeInfinityVector
		/// </summary>
		protected static RUnityEngine.RVector3 r_FnegativeInfinityVector;
		public static RUnityEngine.RVector3 RFnegativeInfinityVector
		{
			get
			{
				if(r_FnegativeInfinityVector == null)
				{
					r_FnegativeInfinityVector = new(typeof(UnityEngine.Vector3), "negativeInfinityVector");
					r_FnegativeInfinityVector.SetBelong(null);
				}
				return r_FnegativeInfinityVector;
			}
		}

		/// <summary>
		/// Single Item [Int32]
		/// </summary>
		protected RSystem.RSingle r_PItem_Int32;
		public virtual RSystem.RSingle RPItem_Int32
		{
			get
			{
				if(r_PItem_Int32 == null)
				{
					r_PItem_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_PItem_Int32.SetBelong(this.instance);
				}
				return r_PItem_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 normalized
		/// </summary>
		protected RUnityEngine.RVector3 r_Pnormalized;
		public virtual RUnityEngine.RVector3 RPnormalized
		{
			get
			{
				if(r_Pnormalized == null)
				{
					r_Pnormalized = new(this, "normalized", -1);
					r_Pnormalized.SetBelong(this.instance);
				}
				return r_Pnormalized;
			}
		}

		/// <summary>
		/// Single magnitude
		/// </summary>
		protected RSystem.RSingle r_Pmagnitude;
		public virtual RSystem.RSingle RPmagnitude
		{
			get
			{
				if(r_Pmagnitude == null)
				{
					r_Pmagnitude = new(this, "magnitude", -1);
					r_Pmagnitude.SetBelong(this.instance);
				}
				return r_Pmagnitude;
			}
		}

		/// <summary>
		/// Single sqrMagnitude
		/// </summary>
		protected RSystem.RSingle r_PsqrMagnitude;
		public virtual RSystem.RSingle RPsqrMagnitude
		{
			get
			{
				if(r_PsqrMagnitude == null)
				{
					r_PsqrMagnitude = new(this, "sqrMagnitude", -1);
					r_PsqrMagnitude.SetBelong(this.instance);
				}
				return r_PsqrMagnitude;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 zero
		/// </summary>
		protected static RUnityEngine.RVector3 r_Pzero;
		public static RUnityEngine.RVector3 RPzero
		{
			get
			{
				if(r_Pzero == null)
				{
					r_Pzero = new(typeof(UnityEngine.Vector3), "zero", -1);
					r_Pzero.SetBelong(null);
				}
				return r_Pzero;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 one
		/// </summary>
		protected static RUnityEngine.RVector3 r_Pone;
		public static RUnityEngine.RVector3 RPone
		{
			get
			{
				if(r_Pone == null)
				{
					r_Pone = new(typeof(UnityEngine.Vector3), "one", -1);
					r_Pone.SetBelong(null);
				}
				return r_Pone;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 forward
		/// </summary>
		protected static RUnityEngine.RVector3 r_Pforward;
		public static RUnityEngine.RVector3 RPforward
		{
			get
			{
				if(r_Pforward == null)
				{
					r_Pforward = new(typeof(UnityEngine.Vector3), "forward", -1);
					r_Pforward.SetBelong(null);
				}
				return r_Pforward;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 back
		/// </summary>
		protected static RUnityEngine.RVector3 r_Pback;
		public static RUnityEngine.RVector3 RPback
		{
			get
			{
				if(r_Pback == null)
				{
					r_Pback = new(typeof(UnityEngine.Vector3), "back", -1);
					r_Pback.SetBelong(null);
				}
				return r_Pback;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 up
		/// </summary>
		protected static RUnityEngine.RVector3 r_Pup;
		public static RUnityEngine.RVector3 RPup
		{
			get
			{
				if(r_Pup == null)
				{
					r_Pup = new(typeof(UnityEngine.Vector3), "up", -1);
					r_Pup.SetBelong(null);
				}
				return r_Pup;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 down
		/// </summary>
		protected static RUnityEngine.RVector3 r_Pdown;
		public static RUnityEngine.RVector3 RPdown
		{
			get
			{
				if(r_Pdown == null)
				{
					r_Pdown = new(typeof(UnityEngine.Vector3), "down", -1);
					r_Pdown.SetBelong(null);
				}
				return r_Pdown;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 left
		/// </summary>
		protected static RUnityEngine.RVector3 r_Pleft;
		public static RUnityEngine.RVector3 RPleft
		{
			get
			{
				if(r_Pleft == null)
				{
					r_Pleft = new(typeof(UnityEngine.Vector3), "left", -1);
					r_Pleft.SetBelong(null);
				}
				return r_Pleft;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 right
		/// </summary>
		protected static RUnityEngine.RVector3 r_Pright;
		public static RUnityEngine.RVector3 RPright
		{
			get
			{
				if(r_Pright == null)
				{
					r_Pright = new(typeof(UnityEngine.Vector3), "right", -1);
					r_Pright.SetBelong(null);
				}
				return r_Pright;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 positiveInfinity
		/// </summary>
		protected static RUnityEngine.RVector3 r_PpositiveInfinity;
		public static RUnityEngine.RVector3 RPpositiveInfinity
		{
			get
			{
				if(r_PpositiveInfinity == null)
				{
					r_PpositiveInfinity = new(typeof(UnityEngine.Vector3), "positiveInfinity", -1);
					r_PpositiveInfinity.SetBelong(null);
				}
				return r_PpositiveInfinity;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 negativeInfinity
		/// </summary>
		protected static RUnityEngine.RVector3 r_PnegativeInfinity;
		public static RUnityEngine.RVector3 RPnegativeInfinity
		{
			get
			{
				if(r_PnegativeInfinity == null)
				{
					r_PnegativeInfinity = new(typeof(UnityEngine.Vector3), "negativeInfinity", -1);
					r_PnegativeInfinity.SetBelong(null);
				}
				return r_PnegativeInfinity;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 fwd
		/// </summary>
		protected static RUnityEngine.RVector3 r_Pfwd;
		public static RUnityEngine.RVector3 RPfwd
		{
			get
			{
				if(r_Pfwd == null)
				{
					r_Pfwd = new(typeof(UnityEngine.Vector3), "fwd", -1);
					r_Pfwd.SetBelong(null);
				}
				return r_Pfwd;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 Slerp(UnityEngine.Vector3, UnityEngine.Vector3, Single)
		/// </summary>
		protected static RMethod r_MSlerp_Vector3_Vector3_Single;
		public static RMethod RMSlerp_Vector3_Vector3_Single
		{
			get
			{
				if(r_MSlerp_Vector3_Vector3_Single == null)
				{
					r_MSlerp_Vector3_Vector3_Single = new(typeof(UnityEngine.Vector3), "Slerp", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Single));
					r_MSlerp_Vector3_Vector3_Single.SetBelong(null);
				}
				return r_MSlerp_Vector3_Vector3_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 SlerpUnclamped(UnityEngine.Vector3, UnityEngine.Vector3, Single)
		/// </summary>
		protected static RMethod r_MSlerpUnclamped_Vector3_Vector3_Single;
		public static RMethod RMSlerpUnclamped_Vector3_Vector3_Single
		{
			get
			{
				if(r_MSlerpUnclamped_Vector3_Vector3_Single == null)
				{
					r_MSlerpUnclamped_Vector3_Vector3_Single = new(typeof(UnityEngine.Vector3), "SlerpUnclamped", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Single));
					r_MSlerpUnclamped_Vector3_Vector3_Single.SetBelong(null);
				}
				return r_MSlerpUnclamped_Vector3_Vector3_Single;
			}
		}

		/// <summary>
		/// Void OrthoNormalize2(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected static RMethod r_MOrthoNormalize2_Ref_Vector3_Ref_Vector3;
		public static RMethod RMOrthoNormalize2_Ref_Vector3_Ref_Vector3
		{
			get
			{
				if(r_MOrthoNormalize2_Ref_Vector3_Ref_Vector3 == null)
				{
					r_MOrthoNormalize2_Ref_Vector3_Ref_Vector3 = new(typeof(UnityEngine.Vector3), "OrthoNormalize2", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
					r_MOrthoNormalize2_Ref_Vector3_Ref_Vector3.SetBelong(null);
				}
				return r_MOrthoNormalize2_Ref_Vector3_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void OrthoNormalize(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected static RMethod r_MOrthoNormalize_Ref_Vector3_Ref_Vector3;
		public static RMethod RMOrthoNormalize_Ref_Vector3_Ref_Vector3
		{
			get
			{
				if(r_MOrthoNormalize_Ref_Vector3_Ref_Vector3 == null)
				{
					r_MOrthoNormalize_Ref_Vector3_Ref_Vector3 = new(typeof(UnityEngine.Vector3), "OrthoNormalize", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
					r_MOrthoNormalize_Ref_Vector3_Ref_Vector3.SetBelong(null);
				}
				return r_MOrthoNormalize_Ref_Vector3_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void OrthoNormalize3(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected static RMethod r_MOrthoNormalize3_Ref_Vector3_Ref_Vector3_Ref_Vector3;
		public static RMethod RMOrthoNormalize3_Ref_Vector3_Ref_Vector3_Ref_Vector3
		{
			get
			{
				if(r_MOrthoNormalize3_Ref_Vector3_Ref_Vector3_Ref_Vector3 == null)
				{
					r_MOrthoNormalize3_Ref_Vector3_Ref_Vector3_Ref_Vector3 = new(typeof(UnityEngine.Vector3), "OrthoNormalize3", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
					r_MOrthoNormalize3_Ref_Vector3_Ref_Vector3_Ref_Vector3.SetBelong(null);
				}
				return r_MOrthoNormalize3_Ref_Vector3_Ref_Vector3_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void OrthoNormalize(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected static RMethod r_MOrthoNormalize_Ref_Vector3_Ref_Vector3_Ref_Vector3;
		public static RMethod RMOrthoNormalize_Ref_Vector3_Ref_Vector3_Ref_Vector3
		{
			get
			{
				if(r_MOrthoNormalize_Ref_Vector3_Ref_Vector3_Ref_Vector3 == null)
				{
					r_MOrthoNormalize_Ref_Vector3_Ref_Vector3_Ref_Vector3 = new(typeof(UnityEngine.Vector3), "OrthoNormalize", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
					r_MOrthoNormalize_Ref_Vector3_Ref_Vector3_Ref_Vector3.SetBelong(null);
				}
				return r_MOrthoNormalize_Ref_Vector3_Ref_Vector3_Ref_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 RotateTowards(UnityEngine.Vector3, UnityEngine.Vector3, Single, Single)
		/// </summary>
		protected static RMethod r_MRotateTowards_Vector3_Vector3_Single_Single;
		public static RMethod RMRotateTowards_Vector3_Vector3_Single_Single
		{
			get
			{
				if(r_MRotateTowards_Vector3_Vector3_Single_Single == null)
				{
					r_MRotateTowards_Vector3_Vector3_Single_Single = new(typeof(UnityEngine.Vector3), "RotateTowards", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Single), typeof(System.Single));
					r_MRotateTowards_Vector3_Vector3_Single_Single.SetBelong(null);
				}
				return r_MRotateTowards_Vector3_Vector3_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 Lerp(UnityEngine.Vector3, UnityEngine.Vector3, Single)
		/// </summary>
		protected static RMethod r_MLerp_Vector3_Vector3_Single;
		public static RMethod RMLerp_Vector3_Vector3_Single
		{
			get
			{
				if(r_MLerp_Vector3_Vector3_Single == null)
				{
					r_MLerp_Vector3_Vector3_Single = new(typeof(UnityEngine.Vector3), "Lerp", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Single));
					r_MLerp_Vector3_Vector3_Single.SetBelong(null);
				}
				return r_MLerp_Vector3_Vector3_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 LerpUnclamped(UnityEngine.Vector3, UnityEngine.Vector3, Single)
		/// </summary>
		protected static RMethod r_MLerpUnclamped_Vector3_Vector3_Single;
		public static RMethod RMLerpUnclamped_Vector3_Vector3_Single
		{
			get
			{
				if(r_MLerpUnclamped_Vector3_Vector3_Single == null)
				{
					r_MLerpUnclamped_Vector3_Vector3_Single = new(typeof(UnityEngine.Vector3), "LerpUnclamped", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Single));
					r_MLerpUnclamped_Vector3_Vector3_Single.SetBelong(null);
				}
				return r_MLerpUnclamped_Vector3_Vector3_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 MoveTowards(UnityEngine.Vector3, UnityEngine.Vector3, Single)
		/// </summary>
		protected static RMethod r_MMoveTowards_Vector3_Vector3_Single;
		public static RMethod RMMoveTowards_Vector3_Vector3_Single
		{
			get
			{
				if(r_MMoveTowards_Vector3_Vector3_Single == null)
				{
					r_MMoveTowards_Vector3_Vector3_Single = new(typeof(UnityEngine.Vector3), "MoveTowards", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Single));
					r_MMoveTowards_Vector3_Vector3_Single.SetBelong(null);
				}
				return r_MMoveTowards_Vector3_Vector3_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 SmoothDamp(UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3 ByRef, Single, Single)
		/// </summary>
		protected static RMethod r_MSmoothDamp_Vector3_Vector3_Ref_Vector3_Single_Single;
		public static RMethod RMSmoothDamp_Vector3_Vector3_Ref_Vector3_Single_Single
		{
			get
			{
				if(r_MSmoothDamp_Vector3_Vector3_Ref_Vector3_Single_Single == null)
				{
					r_MSmoothDamp_Vector3_Vector3_Ref_Vector3_Single_Single = new(typeof(UnityEngine.Vector3), "SmoothDamp", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single), typeof(System.Single));
					r_MSmoothDamp_Vector3_Vector3_Ref_Vector3_Single_Single.SetBelong(null);
				}
				return r_MSmoothDamp_Vector3_Vector3_Ref_Vector3_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 SmoothDamp(UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3 ByRef, Single)
		/// </summary>
		protected static RMethod r_MSmoothDamp_Vector3_Vector3_Ref_Vector3_Single;
		public static RMethod RMSmoothDamp_Vector3_Vector3_Ref_Vector3_Single
		{
			get
			{
				if(r_MSmoothDamp_Vector3_Vector3_Ref_Vector3_Single == null)
				{
					r_MSmoothDamp_Vector3_Vector3_Ref_Vector3_Single = new(typeof(UnityEngine.Vector3), "SmoothDamp", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single));
					r_MSmoothDamp_Vector3_Vector3_Ref_Vector3_Single.SetBelong(null);
				}
				return r_MSmoothDamp_Vector3_Vector3_Ref_Vector3_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 SmoothDamp(UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3 ByRef, Single, Single, Single)
		/// </summary>
		protected static RMethod r_MSmoothDamp_Vector3_Vector3_Ref_Vector3_Single_Single_Single;
		public static RMethod RMSmoothDamp_Vector3_Vector3_Ref_Vector3_Single_Single_Single
		{
			get
			{
				if(r_MSmoothDamp_Vector3_Vector3_Ref_Vector3_Single_Single_Single == null)
				{
					r_MSmoothDamp_Vector3_Vector3_Ref_Vector3_Single_Single_Single = new(typeof(UnityEngine.Vector3), "SmoothDamp", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_MSmoothDamp_Vector3_Vector3_Ref_Vector3_Single_Single_Single.SetBelong(null);
				}
				return r_MSmoothDamp_Vector3_Vector3_Ref_Vector3_Single_Single_Single;
			}
		}

		/// <summary>
		/// Void Set(Single, Single, Single)
		/// </summary>
		protected RMethod r_MSet_Single_Single_Single;
		public virtual RMethod RMSet_Single_Single_Single
		{
			get
			{
				if(r_MSet_Single_Single_Single == null)
				{
					r_MSet_Single_Single_Single = new(this, "Set", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_MSet_Single_Single_Single.SetBelong(this.instance);
				}
				return r_MSet_Single_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 Scale(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_MScale_Vector3_Vector3;
		public static RMethod RMScale_Vector3_Vector3
		{
			get
			{
				if(r_MScale_Vector3_Vector3 == null)
				{
					r_MScale_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "Scale", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_MScale_Vector3_Vector3.SetBelong(null);
				}
				return r_MScale_Vector3_Vector3;
			}
		}

		/// <summary>
		/// Void Scale(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MScale_Vector3;
		public virtual RMethod RMScale_Vector3
		{
			get
			{
				if(r_MScale_Vector3 == null)
				{
					r_MScale_Vector3 = new(this, "Scale", 0, typeof(UnityEngine.Vector3));
					r_MScale_Vector3.SetBelong(this.instance);
				}
				return r_MScale_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 Cross(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_MCross_Vector3_Vector3;
		public static RMethod RMCross_Vector3_Vector3
		{
			get
			{
				if(r_MCross_Vector3_Vector3 == null)
				{
					r_MCross_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "Cross", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_MCross_Vector3_Vector3.SetBelong(null);
				}
				return r_MCross_Vector3_Vector3;
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_MEquals_Object.SetBelong(this.instance);
				}
				return r_MEquals_Object;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MEquals_Vector3;
		public virtual RMethod RMEquals_Vector3
		{
			get
			{
				if(r_MEquals_Vector3 == null)
				{
					r_MEquals_Vector3 = new(this, "Equals", 0, typeof(UnityEngine.Vector3));
					r_MEquals_Vector3.SetBelong(this.instance);
				}
				return r_MEquals_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 Reflect(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_MReflect_Vector3_Vector3;
		public static RMethod RMReflect_Vector3_Vector3
		{
			get
			{
				if(r_MReflect_Vector3_Vector3 == null)
				{
					r_MReflect_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "Reflect", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_MReflect_Vector3_Vector3.SetBelong(null);
				}
				return r_MReflect_Vector3_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 Normalize(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_MNormalize_Vector3;
		public static RMethod RMNormalize_Vector3
		{
			get
			{
				if(r_MNormalize_Vector3 == null)
				{
					r_MNormalize_Vector3 = new(typeof(UnityEngine.Vector3), "Normalize", 0, typeof(UnityEngine.Vector3));
					r_MNormalize_Vector3.SetBelong(null);
				}
				return r_MNormalize_Vector3;
			}
		}

		/// <summary>
		/// Void Normalize()
		/// </summary>
		protected RMethod r_MNormalize;
		public virtual RMethod RMNormalize
		{
			get
			{
				if(r_MNormalize == null)
				{
					r_MNormalize = new(this, "Normalize", 0);
					r_MNormalize.SetBelong(this.instance);
				}
				return r_MNormalize;
			}
		}

		/// <summary>
		/// Single Dot(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_MDot_Vector3_Vector3;
		public static RMethod RMDot_Vector3_Vector3
		{
			get
			{
				if(r_MDot_Vector3_Vector3 == null)
				{
					r_MDot_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "Dot", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_MDot_Vector3_Vector3.SetBelong(null);
				}
				return r_MDot_Vector3_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 Project(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_MProject_Vector3_Vector3;
		public static RMethod RMProject_Vector3_Vector3
		{
			get
			{
				if(r_MProject_Vector3_Vector3 == null)
				{
					r_MProject_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "Project", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_MProject_Vector3_Vector3.SetBelong(null);
				}
				return r_MProject_Vector3_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ProjectOnPlane(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_MProjectOnPlane_Vector3_Vector3;
		public static RMethod RMProjectOnPlane_Vector3_Vector3
		{
			get
			{
				if(r_MProjectOnPlane_Vector3_Vector3 == null)
				{
					r_MProjectOnPlane_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "ProjectOnPlane", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_MProjectOnPlane_Vector3_Vector3.SetBelong(null);
				}
				return r_MProjectOnPlane_Vector3_Vector3;
			}
		}

		/// <summary>
		/// Single Angle(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_MAngle_Vector3_Vector3;
		public static RMethod RMAngle_Vector3_Vector3
		{
			get
			{
				if(r_MAngle_Vector3_Vector3 == null)
				{
					r_MAngle_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "Angle", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_MAngle_Vector3_Vector3.SetBelong(null);
				}
				return r_MAngle_Vector3_Vector3;
			}
		}

		/// <summary>
		/// Single SignedAngle(UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_MSignedAngle_Vector3_Vector3_Vector3;
		public static RMethod RMSignedAngle_Vector3_Vector3_Vector3
		{
			get
			{
				if(r_MSignedAngle_Vector3_Vector3_Vector3 == null)
				{
					r_MSignedAngle_Vector3_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "SignedAngle", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_MSignedAngle_Vector3_Vector3_Vector3.SetBelong(null);
				}
				return r_MSignedAngle_Vector3_Vector3_Vector3;
			}
		}

		/// <summary>
		/// Single Distance(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_MDistance_Vector3_Vector3;
		public static RMethod RMDistance_Vector3_Vector3
		{
			get
			{
				if(r_MDistance_Vector3_Vector3 == null)
				{
					r_MDistance_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "Distance", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_MDistance_Vector3_Vector3.SetBelong(null);
				}
				return r_MDistance_Vector3_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ClampMagnitude(UnityEngine.Vector3, Single)
		/// </summary>
		protected static RMethod r_MClampMagnitude_Vector3_Single;
		public static RMethod RMClampMagnitude_Vector3_Single
		{
			get
			{
				if(r_MClampMagnitude_Vector3_Single == null)
				{
					r_MClampMagnitude_Vector3_Single = new(typeof(UnityEngine.Vector3), "ClampMagnitude", 0, typeof(UnityEngine.Vector3), typeof(System.Single));
					r_MClampMagnitude_Vector3_Single.SetBelong(null);
				}
				return r_MClampMagnitude_Vector3_Single;
			}
		}

		/// <summary>
		/// Single Magnitude(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_MMagnitude_Vector3;
		public static RMethod RMMagnitude_Vector3
		{
			get
			{
				if(r_MMagnitude_Vector3 == null)
				{
					r_MMagnitude_Vector3 = new(typeof(UnityEngine.Vector3), "Magnitude", 0, typeof(UnityEngine.Vector3));
					r_MMagnitude_Vector3.SetBelong(null);
				}
				return r_MMagnitude_Vector3;
			}
		}

		/// <summary>
		/// Single SqrMagnitude(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_MSqrMagnitude_Vector3;
		public static RMethod RMSqrMagnitude_Vector3
		{
			get
			{
				if(r_MSqrMagnitude_Vector3 == null)
				{
					r_MSqrMagnitude_Vector3 = new(typeof(UnityEngine.Vector3), "SqrMagnitude", 0, typeof(UnityEngine.Vector3));
					r_MSqrMagnitude_Vector3.SetBelong(null);
				}
				return r_MSqrMagnitude_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 Min(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_MMin_Vector3_Vector3;
		public static RMethod RMMin_Vector3_Vector3
		{
			get
			{
				if(r_MMin_Vector3_Vector3 == null)
				{
					r_MMin_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "Min", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_MMin_Vector3_Vector3.SetBelong(null);
				}
				return r_MMin_Vector3_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 Max(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_MMax_Vector3_Vector3;
		public static RMethod RMMax_Vector3_Vector3
		{
			get
			{
				if(r_MMax_Vector3_Vector3 == null)
				{
					r_MMax_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "Max", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_MMax_Vector3_Vector3.SetBelong(null);
				}
				return r_MMax_Vector3_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 op_Addition(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_Mop_Addition_Vector3_Vector3;
		public static RMethod RMop_Addition_Vector3_Vector3
		{
			get
			{
				if(r_Mop_Addition_Vector3_Vector3 == null)
				{
					r_Mop_Addition_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "op_Addition", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_Mop_Addition_Vector3_Vector3.SetBelong(null);
				}
				return r_Mop_Addition_Vector3_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 op_Subtraction(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_Mop_Subtraction_Vector3_Vector3;
		public static RMethod RMop_Subtraction_Vector3_Vector3
		{
			get
			{
				if(r_Mop_Subtraction_Vector3_Vector3 == null)
				{
					r_Mop_Subtraction_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "op_Subtraction", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_Mop_Subtraction_Vector3_Vector3.SetBelong(null);
				}
				return r_Mop_Subtraction_Vector3_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 op_UnaryNegation(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_Mop_UnaryNegation_Vector3;
		public static RMethod RMop_UnaryNegation_Vector3
		{
			get
			{
				if(r_Mop_UnaryNegation_Vector3 == null)
				{
					r_Mop_UnaryNegation_Vector3 = new(typeof(UnityEngine.Vector3), "op_UnaryNegation", 0, typeof(UnityEngine.Vector3));
					r_Mop_UnaryNegation_Vector3.SetBelong(null);
				}
				return r_Mop_UnaryNegation_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 op_Multiply(UnityEngine.Vector3, Single)
		/// </summary>
		protected static RMethod r_Mop_Multiply_Vector3_Single;
		public static RMethod RMop_Multiply_Vector3_Single
		{
			get
			{
				if(r_Mop_Multiply_Vector3_Single == null)
				{
					r_Mop_Multiply_Vector3_Single = new(typeof(UnityEngine.Vector3), "op_Multiply", 0, typeof(UnityEngine.Vector3), typeof(System.Single));
					r_Mop_Multiply_Vector3_Single.SetBelong(null);
				}
				return r_Mop_Multiply_Vector3_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 op_Multiply(Single, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_Mop_Multiply_Single_Vector3;
		public static RMethod RMop_Multiply_Single_Vector3
		{
			get
			{
				if(r_Mop_Multiply_Single_Vector3 == null)
				{
					r_Mop_Multiply_Single_Vector3 = new(typeof(UnityEngine.Vector3), "op_Multiply", 0, typeof(System.Single), typeof(UnityEngine.Vector3));
					r_Mop_Multiply_Single_Vector3.SetBelong(null);
				}
				return r_Mop_Multiply_Single_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 op_Division(UnityEngine.Vector3, Single)
		/// </summary>
		protected static RMethod r_Mop_Division_Vector3_Single;
		public static RMethod RMop_Division_Vector3_Single
		{
			get
			{
				if(r_Mop_Division_Vector3_Single == null)
				{
					r_Mop_Division_Vector3_Single = new(typeof(UnityEngine.Vector3), "op_Division", 0, typeof(UnityEngine.Vector3), typeof(System.Single));
					r_Mop_Division_Vector3_Single.SetBelong(null);
				}
				return r_Mop_Division_Vector3_Single;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_Mop_Equality_Vector3_Vector3;
		public static RMethod RMop_Equality_Vector3_Vector3
		{
			get
			{
				if(r_Mop_Equality_Vector3_Vector3 == null)
				{
					r_Mop_Equality_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "op_Equality", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_Mop_Equality_Vector3_Vector3.SetBelong(null);
				}
				return r_Mop_Equality_Vector3_Vector3;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_Mop_Inequality_Vector3_Vector3;
		public static RMethod RMop_Inequality_Vector3_Vector3
		{
			get
			{
				if(r_Mop_Inequality_Vector3_Vector3 == null)
				{
					r_Mop_Inequality_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "op_Inequality", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_Mop_Inequality_Vector3_Vector3.SetBelong(null);
				}
				return r_Mop_Inequality_Vector3_Vector3;
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
					r_MToString.SetBelong(this.instance);
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
					r_MToString_String.SetBelong(this.instance);
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
					r_MToString_String_IFormatProvider.SetBelong(this.instance);
				}
				return r_MToString_String_IFormatProvider;
			}
		}

		/// <summary>
		/// Single AngleBetween(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_MAngleBetween_Vector3_Vector3;
		public static RMethod RMAngleBetween_Vector3_Vector3
		{
			get
			{
				if(r_MAngleBetween_Vector3_Vector3 == null)
				{
					r_MAngleBetween_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "AngleBetween", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_MAngleBetween_Vector3_Vector3.SetBelong(null);
				}
				return r_MAngleBetween_Vector3_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 Exclude(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_MExclude_Vector3_Vector3;
		public static RMethod RMExclude_Vector3_Vector3
		{
			get
			{
				if(r_MExclude_Vector3_Vector3 == null)
				{
					r_MExclude_Vector3_Vector3 = new(typeof(UnityEngine.Vector3), "Exclude", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_MExclude_Vector3_Vector3.SetBelong(null);
				}
				return r_MExclude_Vector3_Vector3;
			}
		}

		/// <summary>
		/// Void Slerp_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef, Single, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected static RMethod r_MSlerp_Injected_Ref_Vector3_Ref_Vector3_Single_Out_Vector3;
		public static RMethod RMSlerp_Injected_Ref_Vector3_Ref_Vector3_Single_Out_Vector3
		{
			get
			{
				if(r_MSlerp_Injected_Ref_Vector3_Ref_Vector3_Single_Out_Vector3 == null)
				{
					r_MSlerp_Injected_Ref_Vector3_Ref_Vector3_Single_Out_Vector3 = new(typeof(UnityEngine.Vector3), "Slerp_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single), typeof(UnityEngine.Vector3).MakeByRefType());
					r_MSlerp_Injected_Ref_Vector3_Ref_Vector3_Single_Out_Vector3.SetBelong(null);
				}
				return r_MSlerp_Injected_Ref_Vector3_Ref_Vector3_Single_Out_Vector3;
			}
		}

		/// <summary>
		/// Void SlerpUnclamped_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef, Single, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected static RMethod r_MSlerpUnclamped_Injected_Ref_Vector3_Ref_Vector3_Single_Out_Vector3;
		public static RMethod RMSlerpUnclamped_Injected_Ref_Vector3_Ref_Vector3_Single_Out_Vector3
		{
			get
			{
				if(r_MSlerpUnclamped_Injected_Ref_Vector3_Ref_Vector3_Single_Out_Vector3 == null)
				{
					r_MSlerpUnclamped_Injected_Ref_Vector3_Ref_Vector3_Single_Out_Vector3 = new(typeof(UnityEngine.Vector3), "SlerpUnclamped_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single), typeof(UnityEngine.Vector3).MakeByRefType());
					r_MSlerpUnclamped_Injected_Ref_Vector3_Ref_Vector3_Single_Out_Vector3.SetBelong(null);
				}
				return r_MSlerpUnclamped_Injected_Ref_Vector3_Ref_Vector3_Single_Out_Vector3;
			}
		}

		/// <summary>
		/// Void RotateTowards_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef, Single, Single, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected static RMethod r_MRotateTowards_Injected_Ref_Vector3_Ref_Vector3_Single_Single_Out_Vector3;
		public static RMethod RMRotateTowards_Injected_Ref_Vector3_Ref_Vector3_Single_Single_Out_Vector3
		{
			get
			{
				if(r_MRotateTowards_Injected_Ref_Vector3_Ref_Vector3_Single_Single_Out_Vector3 == null)
				{
					r_MRotateTowards_Injected_Ref_Vector3_Ref_Vector3_Single_Single_Out_Vector3 = new(typeof(UnityEngine.Vector3), "RotateTowards_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.Vector3).MakeByRefType());
					r_MRotateTowards_Injected_Ref_Vector3_Ref_Vector3_Single_Single_Out_Vector3.SetBelong(null);
				}
				return r_MRotateTowards_Injected_Ref_Vector3_Ref_Vector3_Single_Single_Out_Vector3;
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
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

        public static UnityEngine.Vector3 Slerp(UnityEngine.Vector3 @a, UnityEngine.Vector3 @b, System.Single @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RMSlerp_Vector3_Vector3_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 SlerpUnclamped(UnityEngine.Vector3 @a, UnityEngine.Vector3 @b, System.Single @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RMSlerpUnclamped_Vector3_Vector3_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static void OrthoNormalize2(ref UnityEngine.Vector3 @a, ref UnityEngine.Vector3 @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMOrthoNormalize2_Ref_Vector3_Ref_Vector3.Invoke(___genericsType, ___parameters);
			@a = (UnityEngine.Vector3)___parameters[0];
			@b = (UnityEngine.Vector3)___parameters[1];

            
        }


        public static void OrthoNormalize(ref UnityEngine.Vector3 @normal, ref UnityEngine.Vector3 @tangent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@normal, @tangent};
            var ___result = RMOrthoNormalize_Ref_Vector3_Ref_Vector3.Invoke(___genericsType, ___parameters);
			@normal = (UnityEngine.Vector3)___parameters[0];
			@tangent = (UnityEngine.Vector3)___parameters[1];

            
        }


        public static void OrthoNormalize3(ref UnityEngine.Vector3 @a, ref UnityEngine.Vector3 @b, ref UnityEngine.Vector3 @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @c};
            var ___result = RMOrthoNormalize3_Ref_Vector3_Ref_Vector3_Ref_Vector3.Invoke(___genericsType, ___parameters);
			@a = (UnityEngine.Vector3)___parameters[0];
			@b = (UnityEngine.Vector3)___parameters[1];
			@c = (UnityEngine.Vector3)___parameters[2];

            
        }


        public static void OrthoNormalize(ref UnityEngine.Vector3 @normal, ref UnityEngine.Vector3 @tangent, ref UnityEngine.Vector3 @binormal)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@normal, @tangent, @binormal};
            var ___result = RMOrthoNormalize_Ref_Vector3_Ref_Vector3_Ref_Vector3.Invoke(___genericsType, ___parameters);
			@normal = (UnityEngine.Vector3)___parameters[0];
			@tangent = (UnityEngine.Vector3)___parameters[1];
			@binormal = (UnityEngine.Vector3)___parameters[2];

            
        }


        public static UnityEngine.Vector3 RotateTowards(UnityEngine.Vector3 @current, UnityEngine.Vector3 @target, System.Single @maxRadiansDelta, System.Single @maxMagnitudeDelta)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@current, @target, @maxRadiansDelta, @maxMagnitudeDelta};
            var ___result = RMRotateTowards_Vector3_Vector3_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 Lerp(UnityEngine.Vector3 @a, UnityEngine.Vector3 @b, System.Single @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RMLerp_Vector3_Vector3_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 LerpUnclamped(UnityEngine.Vector3 @a, UnityEngine.Vector3 @b, System.Single @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RMLerpUnclamped_Vector3_Vector3_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 MoveTowards(UnityEngine.Vector3 @current, UnityEngine.Vector3 @target, System.Single @maxDistanceDelta)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@current, @target, @maxDistanceDelta};
            var ___result = RMMoveTowards_Vector3_Vector3_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 SmoothDamp(UnityEngine.Vector3 @current, UnityEngine.Vector3 @target, ref UnityEngine.Vector3 @currentVelocity, System.Single @smoothTime, System.Single @maxSpeed)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@current, @target, @currentVelocity, @smoothTime, @maxSpeed};
            var ___result = RMSmoothDamp_Vector3_Vector3_Ref_Vector3_Single_Single.Invoke(___genericsType, ___parameters);
			@currentVelocity = (UnityEngine.Vector3)___parameters[2];

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 SmoothDamp(UnityEngine.Vector3 @current, UnityEngine.Vector3 @target, ref UnityEngine.Vector3 @currentVelocity, System.Single @smoothTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@current, @target, @currentVelocity, @smoothTime};
            var ___result = RMSmoothDamp_Vector3_Vector3_Ref_Vector3_Single.Invoke(___genericsType, ___parameters);
			@currentVelocity = (UnityEngine.Vector3)___parameters[2];

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 SmoothDamp(UnityEngine.Vector3 @current, UnityEngine.Vector3 @target, ref UnityEngine.Vector3 @currentVelocity, System.Single @smoothTime, System.Single @maxSpeed, System.Single @deltaTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@current, @target, @currentVelocity, @smoothTime, @maxSpeed, @deltaTime};
            var ___result = RMSmoothDamp_Vector3_Vector3_Ref_Vector3_Single_Single_Single.Invoke(___genericsType, ___parameters);
			@currentVelocity = (UnityEngine.Vector3)___parameters[2];

            return (UnityEngine.Vector3)___result;
        }


        public virtual void Set(System.Single @newX, System.Single @newY, System.Single @newZ)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newX, @newY, @newZ};
            var ___result = RMSet_Single_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Vector3 Scale(UnityEngine.Vector3 @a, UnityEngine.Vector3 @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMScale_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual void Scale(UnityEngine.Vector3 @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scale};
            var ___result = RMScale_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Vector3 Cross(UnityEngine.Vector3 @lhs, UnityEngine.Vector3 @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMCross_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.Vector3 @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.Vector3 Reflect(UnityEngine.Vector3 @inDirection, UnityEngine.Vector3 @inNormal)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inDirection, @inNormal};
            var ___result = RMReflect_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 Normalize(UnityEngine.Vector3 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMNormalize_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual void Normalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMNormalize.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Single Dot(UnityEngine.Vector3 @lhs, UnityEngine.Vector3 @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMDot_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static UnityEngine.Vector3 Project(UnityEngine.Vector3 @vector, UnityEngine.Vector3 @onNormal)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vector, @onNormal};
            var ___result = RMProject_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 ProjectOnPlane(UnityEngine.Vector3 @vector, UnityEngine.Vector3 @planeNormal)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vector, @planeNormal};
            var ___result = RMProjectOnPlane_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static System.Single Angle(UnityEngine.Vector3 @from, UnityEngine.Vector3 @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RMAngle_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Single SignedAngle(UnityEngine.Vector3 @from, UnityEngine.Vector3 @to, UnityEngine.Vector3 @axis)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @axis};
            var ___result = RMSignedAngle_Vector3_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Single Distance(UnityEngine.Vector3 @a, UnityEngine.Vector3 @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMDistance_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static UnityEngine.Vector3 ClampMagnitude(UnityEngine.Vector3 @vector, System.Single @maxLength)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vector, @maxLength};
            var ___result = RMClampMagnitude_Vector3_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static System.Single Magnitude(UnityEngine.Vector3 @vector)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vector};
            var ___result = RMMagnitude_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Single SqrMagnitude(UnityEngine.Vector3 @vector)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vector};
            var ___result = RMSqrMagnitude_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static UnityEngine.Vector3 Min(UnityEngine.Vector3 @lhs, UnityEngine.Vector3 @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMMin_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 Max(UnityEngine.Vector3 @lhs, UnityEngine.Vector3 @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMMax_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 op_Addition(UnityEngine.Vector3 @a, UnityEngine.Vector3 @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Addition_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 op_Subtraction(UnityEngine.Vector3 @a, UnityEngine.Vector3 @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Subtraction_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 op_UnaryNegation(UnityEngine.Vector3 @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RMop_UnaryNegation_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 op_Multiply(UnityEngine.Vector3 @a, System.Single @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @d};
            var ___result = RMop_Multiply_Vector3_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 op_Multiply(System.Single @d, UnityEngine.Vector3 @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d, @a};
            var ___result = RMop_Multiply_Single_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 op_Division(UnityEngine.Vector3 @a, System.Single @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @d};
            var ___result = RMop_Division_Vector3_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Vector3 @lhs, UnityEngine.Vector3 @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Vector3 @lhs, UnityEngine.Vector3 @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String @format, System.IFormatProvider @formatProvider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @formatProvider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Single AngleBetween(UnityEngine.Vector3 @from, UnityEngine.Vector3 @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RMAngleBetween_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static UnityEngine.Vector3 Exclude(UnityEngine.Vector3 @excludeThis, UnityEngine.Vector3 @fromThat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@excludeThis, @fromThat};
            var ___result = RMExclude_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static void Slerp_Injected(ref UnityEngine.Vector3 @a, ref UnityEngine.Vector3 @b, System.Single @t, out UnityEngine.Vector3 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t, @ret};
            var ___result = RMSlerp_Injected_Ref_Vector3_Ref_Vector3_Single_Out_Vector3.Invoke(___genericsType, ___parameters);
			@a = (UnityEngine.Vector3)___parameters[0];
			@b = (UnityEngine.Vector3)___parameters[1];
			@ret = (UnityEngine.Vector3)___parameters[3];

            
        }


        public static void SlerpUnclamped_Injected(ref UnityEngine.Vector3 @a, ref UnityEngine.Vector3 @b, System.Single @t, out UnityEngine.Vector3 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t, @ret};
            var ___result = RMSlerpUnclamped_Injected_Ref_Vector3_Ref_Vector3_Single_Out_Vector3.Invoke(___genericsType, ___parameters);
			@a = (UnityEngine.Vector3)___parameters[0];
			@b = (UnityEngine.Vector3)___parameters[1];
			@ret = (UnityEngine.Vector3)___parameters[3];

            
        }


        public static void RotateTowards_Injected(ref UnityEngine.Vector3 @current, ref UnityEngine.Vector3 @target, System.Single @maxRadiansDelta, System.Single @maxMagnitudeDelta, out UnityEngine.Vector3 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@current, @target, @maxRadiansDelta, @maxMagnitudeDelta, @ret};
            var ___result = RMRotateTowards_Injected_Ref_Vector3_Ref_Vector3_Single_Single_Out_Vector3.Invoke(___genericsType, ___parameters);
			@current = (UnityEngine.Vector3)___parameters[0];
			@target = (UnityEngine.Vector3)___parameters[1];
			@ret = (UnityEngine.Vector3)___parameters[4];

            
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
