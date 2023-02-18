
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Vector2
	/// </summary>
    public partial class RVector2 : RMember //
    {

		/// <summary>
		/// System.Single x
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fx;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFx
		{
			get
			{
				if(r_Fx == null)
				{
					r_Fx = new(this, "x");
				}
				return r_Fx;
			}
		}

		/// <summary>
		/// System.Single y
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fy;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFy
		{
			get
			{
				if(r_Fy == null)
				{
					r_Fy = new(this, "y");
				}
				return r_Fy;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 zeroVector
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_FzeroVector;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFzeroVector
		{
			get
			{
				if(r_FzeroVector == null)
				{
					r_FzeroVector = new(typeof(UnityEngine.Vector2), "zeroVector");
				}
				return r_FzeroVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 oneVector
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_FoneVector;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFoneVector
		{
			get
			{
				if(r_FoneVector == null)
				{
					r_FoneVector = new(typeof(UnityEngine.Vector2), "oneVector");
				}
				return r_FoneVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 upVector
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_FupVector;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFupVector
		{
			get
			{
				if(r_FupVector == null)
				{
					r_FupVector = new(typeof(UnityEngine.Vector2), "upVector");
				}
				return r_FupVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 downVector
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_FdownVector;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFdownVector
		{
			get
			{
				if(r_FdownVector == null)
				{
					r_FdownVector = new(typeof(UnityEngine.Vector2), "downVector");
				}
				return r_FdownVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 leftVector
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_FleftVector;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFleftVector
		{
			get
			{
				if(r_FleftVector == null)
				{
					r_FleftVector = new(typeof(UnityEngine.Vector2), "leftVector");
				}
				return r_FleftVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 rightVector
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_FrightVector;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFrightVector
		{
			get
			{
				if(r_FrightVector == null)
				{
					r_FrightVector = new(typeof(UnityEngine.Vector2), "rightVector");
				}
				return r_FrightVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 positiveInfinityVector
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_FpositiveInfinityVector;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFpositiveInfinityVector
		{
			get
			{
				if(r_FpositiveInfinityVector == null)
				{
					r_FpositiveInfinityVector = new(typeof(UnityEngine.Vector2), "positiveInfinityVector");
				}
				return r_FpositiveInfinityVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 negativeInfinityVector
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_FnegativeInfinityVector;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFnegativeInfinityVector
		{
			get
			{
				if(r_FnegativeInfinityVector == null)
				{
					r_FnegativeInfinityVector = new(typeof(UnityEngine.Vector2), "negativeInfinityVector");
				}
				return r_FnegativeInfinityVector;
			}
		}

		/// <summary>
		/// System.Single kEpsilon
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_FkEpsilon;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFkEpsilon
		{
			get
			{
				if(r_FkEpsilon == null)
				{
					r_FkEpsilon = new(typeof(UnityEngine.Vector2), "kEpsilon");
				}
				return r_FkEpsilon;
			}
		}

		/// <summary>
		/// System.Single kEpsilonNormalSqrt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_FkEpsilonNormalSqrt;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFkEpsilonNormalSqrt
		{
			get
			{
				if(r_FkEpsilonNormalSqrt == null)
				{
					r_FkEpsilonNormalSqrt = new(typeof(UnityEngine.Vector2), "kEpsilonNormalSqrt");
				}
				return r_FkEpsilonNormalSqrt;
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
		/// UnityEngine.Vector2 normalized
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Pnormalized;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPnormalized
		{
			get
			{
				if(r_Pnormalized == null)
				{
					r_Pnormalized = new(this, "normalized", -1);
				}
				return r_Pnormalized;
			}
		}

		/// <summary>
		/// Single magnitude
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pmagnitude;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPmagnitude
		{
			get
			{
				if(r_Pmagnitude == null)
				{
					r_Pmagnitude = new(this, "magnitude", -1);
				}
				return r_Pmagnitude;
			}
		}

		/// <summary>
		/// Single sqrMagnitude
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PsqrMagnitude;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPsqrMagnitude
		{
			get
			{
				if(r_PsqrMagnitude == null)
				{
					r_PsqrMagnitude = new(this, "sqrMagnitude", -1);
				}
				return r_PsqrMagnitude;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 zero
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Pzero;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPzero
		{
			get
			{
				if(r_Pzero == null)
				{
					r_Pzero = new(typeof(UnityEngine.Vector2), "zero", -1);
				}
				return r_Pzero;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 one
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Pone;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPone
		{
			get
			{
				if(r_Pone == null)
				{
					r_Pone = new(typeof(UnityEngine.Vector2), "one", -1);
				}
				return r_Pone;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 up
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Pup;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPup
		{
			get
			{
				if(r_Pup == null)
				{
					r_Pup = new(typeof(UnityEngine.Vector2), "up", -1);
				}
				return r_Pup;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 down
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Pdown;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPdown
		{
			get
			{
				if(r_Pdown == null)
				{
					r_Pdown = new(typeof(UnityEngine.Vector2), "down", -1);
				}
				return r_Pdown;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 left
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Pleft;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPleft
		{
			get
			{
				if(r_Pleft == null)
				{
					r_Pleft = new(typeof(UnityEngine.Vector2), "left", -1);
				}
				return r_Pleft;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 right
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Pright;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPright
		{
			get
			{
				if(r_Pright == null)
				{
					r_Pright = new(typeof(UnityEngine.Vector2), "right", -1);
				}
				return r_Pright;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 positiveInfinity
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PpositiveInfinity;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPpositiveInfinity
		{
			get
			{
				if(r_PpositiveInfinity == null)
				{
					r_PpositiveInfinity = new(typeof(UnityEngine.Vector2), "positiveInfinity", -1);
				}
				return r_PpositiveInfinity;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 negativeInfinity
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PnegativeInfinity;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPnegativeInfinity
		{
			get
			{
				if(r_PnegativeInfinity == null)
				{
					r_PnegativeInfinity = new(typeof(UnityEngine.Vector2), "negativeInfinity", -1);
				}
				return r_PnegativeInfinity;
			}
		}

		/// <summary>
		/// Void Set(Single, Single)
		/// </summary>
		protected RMethod r_MSet_Single_Single;
		public virtual RMethod RMSet_Single_Single
		{
			get
			{
				if(r_MSet_Single_Single == null)
				{
					r_MSet_Single_Single = new(this, "Set", 0, typeof(System.Single), typeof(System.Single));
				}
				return r_MSet_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 Lerp(UnityEngine.Vector2, UnityEngine.Vector2, Single)
		/// </summary>
		protected static RMethod r_MLerp_Vector2_Vector2_Single;
		public static RMethod RMLerp_Vector2_Vector2_Single
		{
			get
			{
				if(r_MLerp_Vector2_Vector2_Single == null)
				{
					r_MLerp_Vector2_Vector2_Single = new(typeof(UnityEngine.Vector2), "Lerp", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single));
				}
				return r_MLerp_Vector2_Vector2_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 LerpUnclamped(UnityEngine.Vector2, UnityEngine.Vector2, Single)
		/// </summary>
		protected static RMethod r_MLerpUnclamped_Vector2_Vector2_Single;
		public static RMethod RMLerpUnclamped_Vector2_Vector2_Single
		{
			get
			{
				if(r_MLerpUnclamped_Vector2_Vector2_Single == null)
				{
					r_MLerpUnclamped_Vector2_Vector2_Single = new(typeof(UnityEngine.Vector2), "LerpUnclamped", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single));
				}
				return r_MLerpUnclamped_Vector2_Vector2_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 MoveTowards(UnityEngine.Vector2, UnityEngine.Vector2, Single)
		/// </summary>
		protected static RMethod r_MMoveTowards_Vector2_Vector2_Single;
		public static RMethod RMMoveTowards_Vector2_Vector2_Single
		{
			get
			{
				if(r_MMoveTowards_Vector2_Vector2_Single == null)
				{
					r_MMoveTowards_Vector2_Vector2_Single = new(typeof(UnityEngine.Vector2), "MoveTowards", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single));
				}
				return r_MMoveTowards_Vector2_Vector2_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 Scale(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_MScale_Vector2_Vector2;
		public static RMethod RMScale_Vector2_Vector2
		{
			get
			{
				if(r_MScale_Vector2_Vector2 == null)
				{
					r_MScale_Vector2_Vector2 = new(typeof(UnityEngine.Vector2), "Scale", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
				}
				return r_MScale_Vector2_Vector2;
			}
		}

		/// <summary>
		/// Void Scale(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MScale_Vector2;
		public virtual RMethod RMScale_Vector2
		{
			get
			{
				if(r_MScale_Vector2 == null)
				{
					r_MScale_Vector2 = new(this, "Scale", 0, typeof(UnityEngine.Vector2));
				}
				return r_MScale_Vector2;
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
				}
				return r_MNormalize;
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
		/// Boolean Equals(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MEquals_Vector2;
		public virtual RMethod RMEquals_Vector2
		{
			get
			{
				if(r_MEquals_Vector2 == null)
				{
					r_MEquals_Vector2 = new(this, "Equals", 0, typeof(UnityEngine.Vector2));
				}
				return r_MEquals_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 Reflect(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_MReflect_Vector2_Vector2;
		public static RMethod RMReflect_Vector2_Vector2
		{
			get
			{
				if(r_MReflect_Vector2_Vector2 == null)
				{
					r_MReflect_Vector2_Vector2 = new(typeof(UnityEngine.Vector2), "Reflect", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
				}
				return r_MReflect_Vector2_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 Perpendicular(UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_MPerpendicular_Vector2;
		public static RMethod RMPerpendicular_Vector2
		{
			get
			{
				if(r_MPerpendicular_Vector2 == null)
				{
					r_MPerpendicular_Vector2 = new(typeof(UnityEngine.Vector2), "Perpendicular", 0, typeof(UnityEngine.Vector2));
				}
				return r_MPerpendicular_Vector2;
			}
		}

		/// <summary>
		/// Single Dot(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_MDot_Vector2_Vector2;
		public static RMethod RMDot_Vector2_Vector2
		{
			get
			{
				if(r_MDot_Vector2_Vector2 == null)
				{
					r_MDot_Vector2_Vector2 = new(typeof(UnityEngine.Vector2), "Dot", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
				}
				return r_MDot_Vector2_Vector2;
			}
		}

		/// <summary>
		/// Single Angle(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_MAngle_Vector2_Vector2;
		public static RMethod RMAngle_Vector2_Vector2
		{
			get
			{
				if(r_MAngle_Vector2_Vector2 == null)
				{
					r_MAngle_Vector2_Vector2 = new(typeof(UnityEngine.Vector2), "Angle", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
				}
				return r_MAngle_Vector2_Vector2;
			}
		}

		/// <summary>
		/// Single SignedAngle(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_MSignedAngle_Vector2_Vector2;
		public static RMethod RMSignedAngle_Vector2_Vector2
		{
			get
			{
				if(r_MSignedAngle_Vector2_Vector2 == null)
				{
					r_MSignedAngle_Vector2_Vector2 = new(typeof(UnityEngine.Vector2), "SignedAngle", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
				}
				return r_MSignedAngle_Vector2_Vector2;
			}
		}

		/// <summary>
		/// Single Distance(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_MDistance_Vector2_Vector2;
		public static RMethod RMDistance_Vector2_Vector2
		{
			get
			{
				if(r_MDistance_Vector2_Vector2 == null)
				{
					r_MDistance_Vector2_Vector2 = new(typeof(UnityEngine.Vector2), "Distance", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
				}
				return r_MDistance_Vector2_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 ClampMagnitude(UnityEngine.Vector2, Single)
		/// </summary>
		protected static RMethod r_MClampMagnitude_Vector2_Single;
		public static RMethod RMClampMagnitude_Vector2_Single
		{
			get
			{
				if(r_MClampMagnitude_Vector2_Single == null)
				{
					r_MClampMagnitude_Vector2_Single = new(typeof(UnityEngine.Vector2), "ClampMagnitude", 0, typeof(UnityEngine.Vector2), typeof(System.Single));
				}
				return r_MClampMagnitude_Vector2_Single;
			}
		}

		/// <summary>
		/// Single SqrMagnitude(UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_MSqrMagnitude_Vector2;
		public static RMethod RMSqrMagnitude_Vector2
		{
			get
			{
				if(r_MSqrMagnitude_Vector2 == null)
				{
					r_MSqrMagnitude_Vector2 = new(typeof(UnityEngine.Vector2), "SqrMagnitude", 0, typeof(UnityEngine.Vector2));
				}
				return r_MSqrMagnitude_Vector2;
			}
		}

		/// <summary>
		/// Single SqrMagnitude()
		/// </summary>
		protected RMethod r_MSqrMagnitude;
		public virtual RMethod RMSqrMagnitude
		{
			get
			{
				if(r_MSqrMagnitude == null)
				{
					r_MSqrMagnitude = new(this, "SqrMagnitude", 0);
				}
				return r_MSqrMagnitude;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 Min(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_MMin_Vector2_Vector2;
		public static RMethod RMMin_Vector2_Vector2
		{
			get
			{
				if(r_MMin_Vector2_Vector2 == null)
				{
					r_MMin_Vector2_Vector2 = new(typeof(UnityEngine.Vector2), "Min", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
				}
				return r_MMin_Vector2_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 Max(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_MMax_Vector2_Vector2;
		public static RMethod RMMax_Vector2_Vector2
		{
			get
			{
				if(r_MMax_Vector2_Vector2 == null)
				{
					r_MMax_Vector2_Vector2 = new(typeof(UnityEngine.Vector2), "Max", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
				}
				return r_MMax_Vector2_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 SmoothDamp(UnityEngine.Vector2, UnityEngine.Vector2, UnityEngine.Vector2 ByRef, Single, Single)
		/// </summary>
		protected static RMethod r_MSmoothDamp_Vector2_Vector2_Ref_Vector2_Single_Single;
		public static RMethod RMSmoothDamp_Vector2_Vector2_Ref_Vector2_Single_Single
		{
			get
			{
				if(r_MSmoothDamp_Vector2_Vector2_Ref_Vector2_Single_Single == null)
				{
					r_MSmoothDamp_Vector2_Vector2_Ref_Vector2_Single_Single = new(typeof(UnityEngine.Vector2), "SmoothDamp", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2).MakeByRefType(), typeof(System.Single), typeof(System.Single));
				}
				return r_MSmoothDamp_Vector2_Vector2_Ref_Vector2_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 SmoothDamp(UnityEngine.Vector2, UnityEngine.Vector2, UnityEngine.Vector2 ByRef, Single)
		/// </summary>
		protected static RMethod r_MSmoothDamp_Vector2_Vector2_Ref_Vector2_Single;
		public static RMethod RMSmoothDamp_Vector2_Vector2_Ref_Vector2_Single
		{
			get
			{
				if(r_MSmoothDamp_Vector2_Vector2_Ref_Vector2_Single == null)
				{
					r_MSmoothDamp_Vector2_Vector2_Ref_Vector2_Single = new(typeof(UnityEngine.Vector2), "SmoothDamp", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2).MakeByRefType(), typeof(System.Single));
				}
				return r_MSmoothDamp_Vector2_Vector2_Ref_Vector2_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 SmoothDamp(UnityEngine.Vector2, UnityEngine.Vector2, UnityEngine.Vector2 ByRef, Single, Single, Single)
		/// </summary>
		protected static RMethod r_MSmoothDamp_Vector2_Vector2_Ref_Vector2_Single_Single_Single;
		public static RMethod RMSmoothDamp_Vector2_Vector2_Ref_Vector2_Single_Single_Single
		{
			get
			{
				if(r_MSmoothDamp_Vector2_Vector2_Ref_Vector2_Single_Single_Single == null)
				{
					r_MSmoothDamp_Vector2_Vector2_Ref_Vector2_Single_Single_Single = new(typeof(UnityEngine.Vector2), "SmoothDamp", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2).MakeByRefType(), typeof(System.Single), typeof(System.Single), typeof(System.Single));
				}
				return r_MSmoothDamp_Vector2_Vector2_Ref_Vector2_Single_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 op_Addition(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_Mop_Addition_Vector2_Vector2;
		public static RMethod RMop_Addition_Vector2_Vector2
		{
			get
			{
				if(r_Mop_Addition_Vector2_Vector2 == null)
				{
					r_Mop_Addition_Vector2_Vector2 = new(typeof(UnityEngine.Vector2), "op_Addition", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
				}
				return r_Mop_Addition_Vector2_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 op_Subtraction(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_Mop_Subtraction_Vector2_Vector2;
		public static RMethod RMop_Subtraction_Vector2_Vector2
		{
			get
			{
				if(r_Mop_Subtraction_Vector2_Vector2 == null)
				{
					r_Mop_Subtraction_Vector2_Vector2 = new(typeof(UnityEngine.Vector2), "op_Subtraction", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
				}
				return r_Mop_Subtraction_Vector2_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 op_Multiply(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_Mop_Multiply_Vector2_Vector2;
		public static RMethod RMop_Multiply_Vector2_Vector2
		{
			get
			{
				if(r_Mop_Multiply_Vector2_Vector2 == null)
				{
					r_Mop_Multiply_Vector2_Vector2 = new(typeof(UnityEngine.Vector2), "op_Multiply", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
				}
				return r_Mop_Multiply_Vector2_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 op_Division(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_Mop_Division_Vector2_Vector2;
		public static RMethod RMop_Division_Vector2_Vector2
		{
			get
			{
				if(r_Mop_Division_Vector2_Vector2 == null)
				{
					r_Mop_Division_Vector2_Vector2 = new(typeof(UnityEngine.Vector2), "op_Division", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
				}
				return r_Mop_Division_Vector2_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 op_UnaryNegation(UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_Mop_UnaryNegation_Vector2;
		public static RMethod RMop_UnaryNegation_Vector2
		{
			get
			{
				if(r_Mop_UnaryNegation_Vector2 == null)
				{
					r_Mop_UnaryNegation_Vector2 = new(typeof(UnityEngine.Vector2), "op_UnaryNegation", 0, typeof(UnityEngine.Vector2));
				}
				return r_Mop_UnaryNegation_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 op_Multiply(UnityEngine.Vector2, Single)
		/// </summary>
		protected static RMethod r_Mop_Multiply_Vector2_Single;
		public static RMethod RMop_Multiply_Vector2_Single
		{
			get
			{
				if(r_Mop_Multiply_Vector2_Single == null)
				{
					r_Mop_Multiply_Vector2_Single = new(typeof(UnityEngine.Vector2), "op_Multiply", 0, typeof(UnityEngine.Vector2), typeof(System.Single));
				}
				return r_Mop_Multiply_Vector2_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 op_Multiply(Single, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_Mop_Multiply_Single_Vector2;
		public static RMethod RMop_Multiply_Single_Vector2
		{
			get
			{
				if(r_Mop_Multiply_Single_Vector2 == null)
				{
					r_Mop_Multiply_Single_Vector2 = new(typeof(UnityEngine.Vector2), "op_Multiply", 0, typeof(System.Single), typeof(UnityEngine.Vector2));
				}
				return r_Mop_Multiply_Single_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 op_Division(UnityEngine.Vector2, Single)
		/// </summary>
		protected static RMethod r_Mop_Division_Vector2_Single;
		public static RMethod RMop_Division_Vector2_Single
		{
			get
			{
				if(r_Mop_Division_Vector2_Single == null)
				{
					r_Mop_Division_Vector2_Single = new(typeof(UnityEngine.Vector2), "op_Division", 0, typeof(UnityEngine.Vector2), typeof(System.Single));
				}
				return r_Mop_Division_Vector2_Single;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_Mop_Equality_Vector2_Vector2;
		public static RMethod RMop_Equality_Vector2_Vector2
		{
			get
			{
				if(r_Mop_Equality_Vector2_Vector2 == null)
				{
					r_Mop_Equality_Vector2_Vector2 = new(typeof(UnityEngine.Vector2), "op_Equality", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
				}
				return r_Mop_Equality_Vector2_Vector2;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_Mop_Inequality_Vector2_Vector2;
		public static RMethod RMop_Inequality_Vector2_Vector2
		{
			get
			{
				if(r_Mop_Inequality_Vector2_Vector2 == null)
				{
					r_Mop_Inequality_Vector2_Vector2 = new(typeof(UnityEngine.Vector2), "op_Inequality", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
				}
				return r_Mop_Inequality_Vector2_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 op_Implicit(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_Mop_Implicit_Vector3;
		public static RMethod RMop_Implicit_Vector3
		{
			get
			{
				if(r_Mop_Implicit_Vector3 == null)
				{
					r_Mop_Implicit_Vector3 = new(typeof(UnityEngine.Vector2), "op_Implicit", 0, typeof(UnityEngine.Vector3));
				}
				return r_Mop_Implicit_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 op_Implicit(UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_Mop_Implicit_Vector2;
		public static RMethod RMop_Implicit_Vector2
		{
			get
			{
				if(r_Mop_Implicit_Vector2 == null)
				{
					r_Mop_Implicit_Vector2 = new(typeof(UnityEngine.Vector2), "op_Implicit", 0, typeof(UnityEngine.Vector2));
				}
				return r_Mop_Implicit_Vector2;
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

        public virtual void Set(System.Single @newX, System.Single @newY)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newX, @newY};
            var ___result = RMSet_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Vector2 Lerp(UnityEngine.Vector2 @a, UnityEngine.Vector2 @b, System.Single @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RMLerp_Vector2_Vector2_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 LerpUnclamped(UnityEngine.Vector2 @a, UnityEngine.Vector2 @b, System.Single @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RMLerpUnclamped_Vector2_Vector2_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 MoveTowards(UnityEngine.Vector2 @current, UnityEngine.Vector2 @target, System.Single @maxDistanceDelta)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@current, @target, @maxDistanceDelta};
            var ___result = RMMoveTowards_Vector2_Vector2_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 Scale(UnityEngine.Vector2 @a, UnityEngine.Vector2 @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMScale_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual void Scale(UnityEngine.Vector2 @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scale};
            var ___result = RMScale_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Normalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMNormalize.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Boolean Equals(UnityEngine.Vector2 @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.Vector2 Reflect(UnityEngine.Vector2 @inDirection, UnityEngine.Vector2 @inNormal)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inDirection, @inNormal};
            var ___result = RMReflect_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 Perpendicular(UnityEngine.Vector2 @inDirection)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inDirection};
            var ___result = RMPerpendicular_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static System.Single Dot(UnityEngine.Vector2 @lhs, UnityEngine.Vector2 @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMDot_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Single Angle(UnityEngine.Vector2 @from, UnityEngine.Vector2 @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RMAngle_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Single SignedAngle(UnityEngine.Vector2 @from, UnityEngine.Vector2 @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RMSignedAngle_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Single Distance(UnityEngine.Vector2 @a, UnityEngine.Vector2 @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMDistance_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static UnityEngine.Vector2 ClampMagnitude(UnityEngine.Vector2 @vector, System.Single @maxLength)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vector, @maxLength};
            var ___result = RMClampMagnitude_Vector2_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static System.Single SqrMagnitude(UnityEngine.Vector2 @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RMSqrMagnitude_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single SqrMagnitude()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSqrMagnitude.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static UnityEngine.Vector2 Min(UnityEngine.Vector2 @lhs, UnityEngine.Vector2 @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMMin_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 Max(UnityEngine.Vector2 @lhs, UnityEngine.Vector2 @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMMax_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 SmoothDamp(UnityEngine.Vector2 @current, UnityEngine.Vector2 @target, ref UnityEngine.Vector2 @currentVelocity, System.Single @smoothTime, System.Single @maxSpeed)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@current, @target, @currentVelocity, @smoothTime, @maxSpeed};
            var ___result = RMSmoothDamp_Vector2_Vector2_Ref_Vector2_Single_Single.Invoke(___genericsType, ___parameters);
			@currentVelocity = (UnityEngine.Vector2)___parameters[2];

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 SmoothDamp(UnityEngine.Vector2 @current, UnityEngine.Vector2 @target, ref UnityEngine.Vector2 @currentVelocity, System.Single @smoothTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@current, @target, @currentVelocity, @smoothTime};
            var ___result = RMSmoothDamp_Vector2_Vector2_Ref_Vector2_Single.Invoke(___genericsType, ___parameters);
			@currentVelocity = (UnityEngine.Vector2)___parameters[2];

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 SmoothDamp(UnityEngine.Vector2 @current, UnityEngine.Vector2 @target, ref UnityEngine.Vector2 @currentVelocity, System.Single @smoothTime, System.Single @maxSpeed, System.Single @deltaTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@current, @target, @currentVelocity, @smoothTime, @maxSpeed, @deltaTime};
            var ___result = RMSmoothDamp_Vector2_Vector2_Ref_Vector2_Single_Single_Single.Invoke(___genericsType, ___parameters);
			@currentVelocity = (UnityEngine.Vector2)___parameters[2];

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 op_Addition(UnityEngine.Vector2 @a, UnityEngine.Vector2 @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Addition_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 op_Subtraction(UnityEngine.Vector2 @a, UnityEngine.Vector2 @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Subtraction_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 op_Multiply(UnityEngine.Vector2 @a, UnityEngine.Vector2 @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Multiply_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 op_Division(UnityEngine.Vector2 @a, UnityEngine.Vector2 @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Division_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 op_UnaryNegation(UnityEngine.Vector2 @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RMop_UnaryNegation_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 op_Multiply(UnityEngine.Vector2 @a, System.Single @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @d};
            var ___result = RMop_Multiply_Vector2_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 op_Multiply(System.Single @d, UnityEngine.Vector2 @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d, @a};
            var ___result = RMop_Multiply_Single_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 op_Division(UnityEngine.Vector2 @a, System.Single @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @d};
            var ___result = RMop_Division_Vector2_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Vector2 @lhs, UnityEngine.Vector2 @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Vector2 @lhs, UnityEngine.Vector2 @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.Vector2 op_Implicit(UnityEngine.Vector3 @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = RMop_Implicit_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector3 op_Implicit(UnityEngine.Vector2 @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = RMop_Implicit_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
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
