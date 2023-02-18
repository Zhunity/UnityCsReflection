
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Vector4
	/// </summary>
    public partial class RVector4 : RMember //
    {

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
					r_FkEpsilon = new(typeof(UnityEngine.Vector4), "kEpsilon");
				}
				return r_FkEpsilon;
			}
		}

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
		/// System.Single z
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fz;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFz
		{
			get
			{
				if(r_Fz == null)
				{
					r_Fz = new(this, "z");
				}
				return r_Fz;
			}
		}

		/// <summary>
		/// System.Single w
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fw;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFw
		{
			get
			{
				if(r_Fw == null)
				{
					r_Fw = new(this, "w");
				}
				return r_Fw;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 zeroVector
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector4 r_FzeroVector;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector4 RFzeroVector
		{
			get
			{
				if(r_FzeroVector == null)
				{
					r_FzeroVector = new(typeof(UnityEngine.Vector4), "zeroVector");
				}
				return r_FzeroVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 oneVector
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector4 r_FoneVector;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector4 RFoneVector
		{
			get
			{
				if(r_FoneVector == null)
				{
					r_FoneVector = new(typeof(UnityEngine.Vector4), "oneVector");
				}
				return r_FoneVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 positiveInfinityVector
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector4 r_FpositiveInfinityVector;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector4 RFpositiveInfinityVector
		{
			get
			{
				if(r_FpositiveInfinityVector == null)
				{
					r_FpositiveInfinityVector = new(typeof(UnityEngine.Vector4), "positiveInfinityVector");
				}
				return r_FpositiveInfinityVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 negativeInfinityVector
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector4 r_FnegativeInfinityVector;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector4 RFnegativeInfinityVector
		{
			get
			{
				if(r_FnegativeInfinityVector == null)
				{
					r_FnegativeInfinityVector = new(typeof(UnityEngine.Vector4), "negativeInfinityVector");
				}
				return r_FnegativeInfinityVector;
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
		/// UnityEngine.Vector4 normalized
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector4 r_Pnormalized;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector4 RPnormalized
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
		/// UnityEngine.Vector4 zero
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector4 r_Pzero;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector4 RPzero
		{
			get
			{
				if(r_Pzero == null)
				{
					r_Pzero = new(typeof(UnityEngine.Vector4), "zero", -1);
				}
				return r_Pzero;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 one
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector4 r_Pone;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector4 RPone
		{
			get
			{
				if(r_Pone == null)
				{
					r_Pone = new(typeof(UnityEngine.Vector4), "one", -1);
				}
				return r_Pone;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 positiveInfinity
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector4 r_PpositiveInfinity;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector4 RPpositiveInfinity
		{
			get
			{
				if(r_PpositiveInfinity == null)
				{
					r_PpositiveInfinity = new(typeof(UnityEngine.Vector4), "positiveInfinity", -1);
				}
				return r_PpositiveInfinity;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 negativeInfinity
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector4 r_PnegativeInfinity;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector4 RPnegativeInfinity
		{
			get
			{
				if(r_PnegativeInfinity == null)
				{
					r_PnegativeInfinity = new(typeof(UnityEngine.Vector4), "negativeInfinity", -1);
				}
				return r_PnegativeInfinity;
			}
		}

		/// <summary>
		/// Void Set(Single, Single, Single, Single)
		/// </summary>
		protected RMethod r_MSet_Single_Single_Single_Single;
		public virtual RMethod RMSet_Single_Single_Single_Single
		{
			get
			{
				if(r_MSet_Single_Single_Single_Single == null)
				{
					r_MSet_Single_Single_Single_Single = new(this, "Set", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single));
				}
				return r_MSet_Single_Single_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 Lerp(UnityEngine.Vector4, UnityEngine.Vector4, Single)
		/// </summary>
		protected static RMethod r_MLerp_Vector4_Vector4_Single;
		public static RMethod RMLerp_Vector4_Vector4_Single
		{
			get
			{
				if(r_MLerp_Vector4_Vector4_Single == null)
				{
					r_MLerp_Vector4_Vector4_Single = new(typeof(UnityEngine.Vector4), "Lerp", 0, typeof(UnityEngine.Vector4), typeof(UnityEngine.Vector4), typeof(System.Single));
				}
				return r_MLerp_Vector4_Vector4_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 LerpUnclamped(UnityEngine.Vector4, UnityEngine.Vector4, Single)
		/// </summary>
		protected static RMethod r_MLerpUnclamped_Vector4_Vector4_Single;
		public static RMethod RMLerpUnclamped_Vector4_Vector4_Single
		{
			get
			{
				if(r_MLerpUnclamped_Vector4_Vector4_Single == null)
				{
					r_MLerpUnclamped_Vector4_Vector4_Single = new(typeof(UnityEngine.Vector4), "LerpUnclamped", 0, typeof(UnityEngine.Vector4), typeof(UnityEngine.Vector4), typeof(System.Single));
				}
				return r_MLerpUnclamped_Vector4_Vector4_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 MoveTowards(UnityEngine.Vector4, UnityEngine.Vector4, Single)
		/// </summary>
		protected static RMethod r_MMoveTowards_Vector4_Vector4_Single;
		public static RMethod RMMoveTowards_Vector4_Vector4_Single
		{
			get
			{
				if(r_MMoveTowards_Vector4_Vector4_Single == null)
				{
					r_MMoveTowards_Vector4_Vector4_Single = new(typeof(UnityEngine.Vector4), "MoveTowards", 0, typeof(UnityEngine.Vector4), typeof(UnityEngine.Vector4), typeof(System.Single));
				}
				return r_MMoveTowards_Vector4_Vector4_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 Scale(UnityEngine.Vector4, UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_MScale_Vector4_Vector4;
		public static RMethod RMScale_Vector4_Vector4
		{
			get
			{
				if(r_MScale_Vector4_Vector4 == null)
				{
					r_MScale_Vector4_Vector4 = new(typeof(UnityEngine.Vector4), "Scale", 0, typeof(UnityEngine.Vector4), typeof(UnityEngine.Vector4));
				}
				return r_MScale_Vector4_Vector4;
			}
		}

		/// <summary>
		/// Void Scale(UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_MScale_Vector4;
		public virtual RMethod RMScale_Vector4
		{
			get
			{
				if(r_MScale_Vector4 == null)
				{
					r_MScale_Vector4 = new(this, "Scale", 0, typeof(UnityEngine.Vector4));
				}
				return r_MScale_Vector4;
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
		/// Boolean Equals(UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_MEquals_Vector4;
		public virtual RMethod RMEquals_Vector4
		{
			get
			{
				if(r_MEquals_Vector4 == null)
				{
					r_MEquals_Vector4 = new(this, "Equals", 0, typeof(UnityEngine.Vector4));
				}
				return r_MEquals_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 Normalize(UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_MNormalize_Vector4;
		public static RMethod RMNormalize_Vector4
		{
			get
			{
				if(r_MNormalize_Vector4 == null)
				{
					r_MNormalize_Vector4 = new(typeof(UnityEngine.Vector4), "Normalize", 0, typeof(UnityEngine.Vector4));
				}
				return r_MNormalize_Vector4;
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
		/// Single Dot(UnityEngine.Vector4, UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_MDot_Vector4_Vector4;
		public static RMethod RMDot_Vector4_Vector4
		{
			get
			{
				if(r_MDot_Vector4_Vector4 == null)
				{
					r_MDot_Vector4_Vector4 = new(typeof(UnityEngine.Vector4), "Dot", 0, typeof(UnityEngine.Vector4), typeof(UnityEngine.Vector4));
				}
				return r_MDot_Vector4_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 Project(UnityEngine.Vector4, UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_MProject_Vector4_Vector4;
		public static RMethod RMProject_Vector4_Vector4
		{
			get
			{
				if(r_MProject_Vector4_Vector4 == null)
				{
					r_MProject_Vector4_Vector4 = new(typeof(UnityEngine.Vector4), "Project", 0, typeof(UnityEngine.Vector4), typeof(UnityEngine.Vector4));
				}
				return r_MProject_Vector4_Vector4;
			}
		}

		/// <summary>
		/// Single Distance(UnityEngine.Vector4, UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_MDistance_Vector4_Vector4;
		public static RMethod RMDistance_Vector4_Vector4
		{
			get
			{
				if(r_MDistance_Vector4_Vector4 == null)
				{
					r_MDistance_Vector4_Vector4 = new(typeof(UnityEngine.Vector4), "Distance", 0, typeof(UnityEngine.Vector4), typeof(UnityEngine.Vector4));
				}
				return r_MDistance_Vector4_Vector4;
			}
		}

		/// <summary>
		/// Single Magnitude(UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_MMagnitude_Vector4;
		public static RMethod RMMagnitude_Vector4
		{
			get
			{
				if(r_MMagnitude_Vector4 == null)
				{
					r_MMagnitude_Vector4 = new(typeof(UnityEngine.Vector4), "Magnitude", 0, typeof(UnityEngine.Vector4));
				}
				return r_MMagnitude_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 Min(UnityEngine.Vector4, UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_MMin_Vector4_Vector4;
		public static RMethod RMMin_Vector4_Vector4
		{
			get
			{
				if(r_MMin_Vector4_Vector4 == null)
				{
					r_MMin_Vector4_Vector4 = new(typeof(UnityEngine.Vector4), "Min", 0, typeof(UnityEngine.Vector4), typeof(UnityEngine.Vector4));
				}
				return r_MMin_Vector4_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 Max(UnityEngine.Vector4, UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_MMax_Vector4_Vector4;
		public static RMethod RMMax_Vector4_Vector4
		{
			get
			{
				if(r_MMax_Vector4_Vector4 == null)
				{
					r_MMax_Vector4_Vector4 = new(typeof(UnityEngine.Vector4), "Max", 0, typeof(UnityEngine.Vector4), typeof(UnityEngine.Vector4));
				}
				return r_MMax_Vector4_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 op_Addition(UnityEngine.Vector4, UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_Mop_Addition_Vector4_Vector4;
		public static RMethod RMop_Addition_Vector4_Vector4
		{
			get
			{
				if(r_Mop_Addition_Vector4_Vector4 == null)
				{
					r_Mop_Addition_Vector4_Vector4 = new(typeof(UnityEngine.Vector4), "op_Addition", 0, typeof(UnityEngine.Vector4), typeof(UnityEngine.Vector4));
				}
				return r_Mop_Addition_Vector4_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 op_Subtraction(UnityEngine.Vector4, UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_Mop_Subtraction_Vector4_Vector4;
		public static RMethod RMop_Subtraction_Vector4_Vector4
		{
			get
			{
				if(r_Mop_Subtraction_Vector4_Vector4 == null)
				{
					r_Mop_Subtraction_Vector4_Vector4 = new(typeof(UnityEngine.Vector4), "op_Subtraction", 0, typeof(UnityEngine.Vector4), typeof(UnityEngine.Vector4));
				}
				return r_Mop_Subtraction_Vector4_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 op_UnaryNegation(UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_Mop_UnaryNegation_Vector4;
		public static RMethod RMop_UnaryNegation_Vector4
		{
			get
			{
				if(r_Mop_UnaryNegation_Vector4 == null)
				{
					r_Mop_UnaryNegation_Vector4 = new(typeof(UnityEngine.Vector4), "op_UnaryNegation", 0, typeof(UnityEngine.Vector4));
				}
				return r_Mop_UnaryNegation_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 op_Multiply(UnityEngine.Vector4, Single)
		/// </summary>
		protected static RMethod r_Mop_Multiply_Vector4_Single;
		public static RMethod RMop_Multiply_Vector4_Single
		{
			get
			{
				if(r_Mop_Multiply_Vector4_Single == null)
				{
					r_Mop_Multiply_Vector4_Single = new(typeof(UnityEngine.Vector4), "op_Multiply", 0, typeof(UnityEngine.Vector4), typeof(System.Single));
				}
				return r_Mop_Multiply_Vector4_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 op_Multiply(Single, UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_Mop_Multiply_Single_Vector4;
		public static RMethod RMop_Multiply_Single_Vector4
		{
			get
			{
				if(r_Mop_Multiply_Single_Vector4 == null)
				{
					r_Mop_Multiply_Single_Vector4 = new(typeof(UnityEngine.Vector4), "op_Multiply", 0, typeof(System.Single), typeof(UnityEngine.Vector4));
				}
				return r_Mop_Multiply_Single_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 op_Division(UnityEngine.Vector4, Single)
		/// </summary>
		protected static RMethod r_Mop_Division_Vector4_Single;
		public static RMethod RMop_Division_Vector4_Single
		{
			get
			{
				if(r_Mop_Division_Vector4_Single == null)
				{
					r_Mop_Division_Vector4_Single = new(typeof(UnityEngine.Vector4), "op_Division", 0, typeof(UnityEngine.Vector4), typeof(System.Single));
				}
				return r_Mop_Division_Vector4_Single;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Vector4, UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_Mop_Equality_Vector4_Vector4;
		public static RMethod RMop_Equality_Vector4_Vector4
		{
			get
			{
				if(r_Mop_Equality_Vector4_Vector4 == null)
				{
					r_Mop_Equality_Vector4_Vector4 = new(typeof(UnityEngine.Vector4), "op_Equality", 0, typeof(UnityEngine.Vector4), typeof(UnityEngine.Vector4));
				}
				return r_Mop_Equality_Vector4_Vector4;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Vector4, UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_Mop_Inequality_Vector4_Vector4;
		public static RMethod RMop_Inequality_Vector4_Vector4
		{
			get
			{
				if(r_Mop_Inequality_Vector4_Vector4 == null)
				{
					r_Mop_Inequality_Vector4_Vector4 = new(typeof(UnityEngine.Vector4), "op_Inequality", 0, typeof(UnityEngine.Vector4), typeof(UnityEngine.Vector4));
				}
				return r_Mop_Inequality_Vector4_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 op_Implicit(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_Mop_Implicit_Vector3;
		public static RMethod RMop_Implicit_Vector3
		{
			get
			{
				if(r_Mop_Implicit_Vector3 == null)
				{
					r_Mop_Implicit_Vector3 = new(typeof(UnityEngine.Vector4), "op_Implicit", 0, typeof(UnityEngine.Vector3));
				}
				return r_Mop_Implicit_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 op_Implicit(UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_Mop_Implicit_Vector4;
		public static RMethod RMop_Implicit_Vector4
		{
			get
			{
				if(r_Mop_Implicit_Vector4 == null)
				{
					r_Mop_Implicit_Vector4 = new(typeof(UnityEngine.Vector4), "op_Implicit", 0, typeof(UnityEngine.Vector4));
				}
				return r_Mop_Implicit_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 op_Implicit(UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_Mop_Implicit_Vector2;
		public static RMethod RMop_Implicit_Vector2
		{
			get
			{
				if(r_Mop_Implicit_Vector2 == null)
				{
					r_Mop_Implicit_Vector2 = new(typeof(UnityEngine.Vector4), "op_Implicit", 0, typeof(UnityEngine.Vector2));
				}
				return r_Mop_Implicit_Vector2;
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
		/// Single SqrMagnitude(UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_MSqrMagnitude_Vector4;
		public static RMethod RMSqrMagnitude_Vector4
		{
			get
			{
				if(r_MSqrMagnitude_Vector4 == null)
				{
					r_MSqrMagnitude_Vector4 = new(typeof(UnityEngine.Vector4), "SqrMagnitude", 0, typeof(UnityEngine.Vector4));
				}
				return r_MSqrMagnitude_Vector4;
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

        public virtual void Set(System.Single @newX, System.Single @newY, System.Single @newZ, System.Single @newW)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newX, @newY, @newZ, @newW};
            var ___result = RMSet_Single_Single_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Vector4 Lerp(UnityEngine.Vector4 @a, UnityEngine.Vector4 @b, System.Single @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RMLerp_Vector4_Vector4_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Vector4 LerpUnclamped(UnityEngine.Vector4 @a, UnityEngine.Vector4 @b, System.Single @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RMLerpUnclamped_Vector4_Vector4_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Vector4 MoveTowards(UnityEngine.Vector4 @current, UnityEngine.Vector4 @target, System.Single @maxDistanceDelta)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@current, @target, @maxDistanceDelta};
            var ___result = RMMoveTowards_Vector4_Vector4_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Vector4 Scale(UnityEngine.Vector4 @a, UnityEngine.Vector4 @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMScale_Vector4_Vector4.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public virtual void Scale(UnityEngine.Vector4 @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scale};
            var ___result = RMScale_Vector4.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Boolean Equals(UnityEngine.Vector4 @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Vector4.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.Vector4 Normalize(UnityEngine.Vector4 @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RMNormalize_Vector4.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public virtual void Normalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMNormalize.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Single Dot(UnityEngine.Vector4 @a, UnityEngine.Vector4 @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMDot_Vector4_Vector4.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static UnityEngine.Vector4 Project(UnityEngine.Vector4 @a, UnityEngine.Vector4 @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMProject_Vector4_Vector4.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static System.Single Distance(UnityEngine.Vector4 @a, UnityEngine.Vector4 @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMDistance_Vector4_Vector4.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Single Magnitude(UnityEngine.Vector4 @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RMMagnitude_Vector4.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static UnityEngine.Vector4 Min(UnityEngine.Vector4 @lhs, UnityEngine.Vector4 @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMMin_Vector4_Vector4.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Vector4 Max(UnityEngine.Vector4 @lhs, UnityEngine.Vector4 @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMMax_Vector4_Vector4.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Vector4 op_Addition(UnityEngine.Vector4 @a, UnityEngine.Vector4 @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Addition_Vector4_Vector4.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Vector4 op_Subtraction(UnityEngine.Vector4 @a, UnityEngine.Vector4 @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Subtraction_Vector4_Vector4.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Vector4 op_UnaryNegation(UnityEngine.Vector4 @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RMop_UnaryNegation_Vector4.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Vector4 op_Multiply(UnityEngine.Vector4 @a, System.Single @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @d};
            var ___result = RMop_Multiply_Vector4_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Vector4 op_Multiply(System.Single @d, UnityEngine.Vector4 @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d, @a};
            var ___result = RMop_Multiply_Single_Vector4.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Vector4 op_Division(UnityEngine.Vector4 @a, System.Single @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @d};
            var ___result = RMop_Division_Vector4_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Vector4 @lhs, UnityEngine.Vector4 @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_Vector4_Vector4.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Vector4 @lhs, UnityEngine.Vector4 @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_Vector4_Vector4.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.Vector4 op_Implicit(UnityEngine.Vector3 @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = RMop_Implicit_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Vector3 op_Implicit(UnityEngine.Vector4 @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = RMop_Implicit_Vector4.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector4 op_Implicit(UnityEngine.Vector2 @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = RMop_Implicit_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
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


        public static System.Single SqrMagnitude(UnityEngine.Vector4 @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RMSqrMagnitude_Vector4.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single SqrMagnitude()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSqrMagnitude.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
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
