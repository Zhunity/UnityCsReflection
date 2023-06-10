
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Quaternion
	/// </summary>
    public partial class RQuaternion : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.Quaternion);
            }
        }

        public RQuaternion() : base("UnityEngine.Quaternion")
        {
        }

        public RQuaternion(System.Object instance) : base("UnityEngine.Quaternion")
		{
            SetInstance(instance);
		}

        public RQuaternion(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RQuaternion(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
		/// UnityEngine.Quaternion identityQuaternion
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RQuaternion r_FidentityQuaternion;
		public static Hvak.Editor.Refleaction.RUnityEngine.RQuaternion RFidentityQuaternion
		{
			get
			{
				if(r_FidentityQuaternion == null)
				{
					r_FidentityQuaternion = new(typeof(UnityEngine.Quaternion), "identityQuaternion");
				}
				return r_FidentityQuaternion;
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
					r_FkEpsilon = new(typeof(UnityEngine.Quaternion), "kEpsilon");
				}
				return r_FkEpsilon;
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
		/// UnityEngine.Quaternion identity
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RQuaternion r_Pidentity;
		public static Hvak.Editor.Refleaction.RUnityEngine.RQuaternion RPidentity
		{
			get
			{
				if(r_Pidentity == null)
				{
					r_Pidentity = new(typeof(UnityEngine.Quaternion), "identity", -1);
				}
				return r_Pidentity;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 eulerAngles
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_PeulerAngles;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPeulerAngles
		{
			get
			{
				if(r_PeulerAngles == null)
				{
					r_PeulerAngles = new(this, "eulerAngles", -1);
				}
				return r_PeulerAngles;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion normalized
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RQuaternion r_Pnormalized;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RQuaternion RPnormalized
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
		/// UnityEngine.Quaternion FromToRotation(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_MFromToRotation_Vector3_Vector3;
		public static RMethod RMFromToRotation_Vector3_Vector3
		{
			get
			{
				if(r_MFromToRotation_Vector3_Vector3 == null)
				{
					r_MFromToRotation_Vector3_Vector3 = new(typeof(UnityEngine.Quaternion), "FromToRotation", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
				}
				return r_MFromToRotation_Vector3_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion Inverse(UnityEngine.Quaternion)
		/// </summary>
		protected static RMethod r_MInverse_Quaternion;
		public static RMethod RMInverse_Quaternion
		{
			get
			{
				if(r_MInverse_Quaternion == null)
				{
					r_MInverse_Quaternion = new(typeof(UnityEngine.Quaternion), "Inverse", 0, typeof(UnityEngine.Quaternion));
				}
				return r_MInverse_Quaternion;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion Slerp(UnityEngine.Quaternion, UnityEngine.Quaternion, Single)
		/// </summary>
		protected static RMethod r_MSlerp_Quaternion_Quaternion_Single;
		public static RMethod RMSlerp_Quaternion_Quaternion_Single
		{
			get
			{
				if(r_MSlerp_Quaternion_Quaternion_Single == null)
				{
					r_MSlerp_Quaternion_Quaternion_Single = new(typeof(UnityEngine.Quaternion), "Slerp", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion), typeof(System.Single));
				}
				return r_MSlerp_Quaternion_Quaternion_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion SlerpUnclamped(UnityEngine.Quaternion, UnityEngine.Quaternion, Single)
		/// </summary>
		protected static RMethod r_MSlerpUnclamped_Quaternion_Quaternion_Single;
		public static RMethod RMSlerpUnclamped_Quaternion_Quaternion_Single
		{
			get
			{
				if(r_MSlerpUnclamped_Quaternion_Quaternion_Single == null)
				{
					r_MSlerpUnclamped_Quaternion_Quaternion_Single = new(typeof(UnityEngine.Quaternion), "SlerpUnclamped", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion), typeof(System.Single));
				}
				return r_MSlerpUnclamped_Quaternion_Quaternion_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion Lerp(UnityEngine.Quaternion, UnityEngine.Quaternion, Single)
		/// </summary>
		protected static RMethod r_MLerp_Quaternion_Quaternion_Single;
		public static RMethod RMLerp_Quaternion_Quaternion_Single
		{
			get
			{
				if(r_MLerp_Quaternion_Quaternion_Single == null)
				{
					r_MLerp_Quaternion_Quaternion_Single = new(typeof(UnityEngine.Quaternion), "Lerp", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion), typeof(System.Single));
				}
				return r_MLerp_Quaternion_Quaternion_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion LerpUnclamped(UnityEngine.Quaternion, UnityEngine.Quaternion, Single)
		/// </summary>
		protected static RMethod r_MLerpUnclamped_Quaternion_Quaternion_Single;
		public static RMethod RMLerpUnclamped_Quaternion_Quaternion_Single
		{
			get
			{
				if(r_MLerpUnclamped_Quaternion_Quaternion_Single == null)
				{
					r_MLerpUnclamped_Quaternion_Quaternion_Single = new(typeof(UnityEngine.Quaternion), "LerpUnclamped", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion), typeof(System.Single));
				}
				return r_MLerpUnclamped_Quaternion_Quaternion_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion Internal_FromEulerRad(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_MInternal_FromEulerRad_Vector3;
		public static RMethod RMInternal_FromEulerRad_Vector3
		{
			get
			{
				if(r_MInternal_FromEulerRad_Vector3 == null)
				{
					r_MInternal_FromEulerRad_Vector3 = new(typeof(UnityEngine.Quaternion), "Internal_FromEulerRad", 0, typeof(UnityEngine.Vector3));
				}
				return r_MInternal_FromEulerRad_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 Internal_ToEulerRad(UnityEngine.Quaternion)
		/// </summary>
		protected static RMethod r_MInternal_ToEulerRad_Quaternion;
		public static RMethod RMInternal_ToEulerRad_Quaternion
		{
			get
			{
				if(r_MInternal_ToEulerRad_Quaternion == null)
				{
					r_MInternal_ToEulerRad_Quaternion = new(typeof(UnityEngine.Quaternion), "Internal_ToEulerRad", 0, typeof(UnityEngine.Quaternion));
				}
				return r_MInternal_ToEulerRad_Quaternion;
			}
		}

		/// <summary>
		/// Void Internal_ToAxisAngleRad(UnityEngine.Quaternion, UnityEngine.Vector3 ByRef, Single ByRef)
		/// </summary>
		protected static RMethod r_MInternal_ToAxisAngleRad_Quaternion_Out_Vector3_Out_Single;
		public static RMethod RMInternal_ToAxisAngleRad_Quaternion_Out_Vector3_Out_Single
		{
			get
			{
				if(r_MInternal_ToAxisAngleRad_Quaternion_Out_Vector3_Out_Single == null)
				{
					r_MInternal_ToAxisAngleRad_Quaternion_Out_Vector3_Out_Single = new(typeof(UnityEngine.Quaternion), "Internal_ToAxisAngleRad", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single).MakeByRefType());
				}
				return r_MInternal_ToAxisAngleRad_Quaternion_Out_Vector3_Out_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion AngleAxis(Single, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_MAngleAxis_Single_Vector3;
		public static RMethod RMAngleAxis_Single_Vector3
		{
			get
			{
				if(r_MAngleAxis_Single_Vector3 == null)
				{
					r_MAngleAxis_Single_Vector3 = new(typeof(UnityEngine.Quaternion), "AngleAxis", 0, typeof(System.Single), typeof(UnityEngine.Vector3));
				}
				return r_MAngleAxis_Single_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion LookRotation(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_MLookRotation_Vector3_Vector3;
		public static RMethod RMLookRotation_Vector3_Vector3
		{
			get
			{
				if(r_MLookRotation_Vector3_Vector3 == null)
				{
					r_MLookRotation_Vector3_Vector3 = new(typeof(UnityEngine.Quaternion), "LookRotation", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
				}
				return r_MLookRotation_Vector3_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion LookRotation(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_MLookRotation_Vector3;
		public static RMethod RMLookRotation_Vector3
		{
			get
			{
				if(r_MLookRotation_Vector3 == null)
				{
					r_MLookRotation_Vector3 = new(typeof(UnityEngine.Quaternion), "LookRotation", 0, typeof(UnityEngine.Vector3));
				}
				return r_MLookRotation_Vector3;
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
		/// UnityEngine.Quaternion op_Multiply(UnityEngine.Quaternion, UnityEngine.Quaternion)
		/// </summary>
		protected static RMethod r_Mop_Multiply_Quaternion_Quaternion;
		public static RMethod RMop_Multiply_Quaternion_Quaternion
		{
			get
			{
				if(r_Mop_Multiply_Quaternion_Quaternion == null)
				{
					r_Mop_Multiply_Quaternion_Quaternion = new(typeof(UnityEngine.Quaternion), "op_Multiply", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion));
				}
				return r_Mop_Multiply_Quaternion_Quaternion;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 op_Multiply(UnityEngine.Quaternion, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_Mop_Multiply_Quaternion_Vector3;
		public static RMethod RMop_Multiply_Quaternion_Vector3
		{
			get
			{
				if(r_Mop_Multiply_Quaternion_Vector3 == null)
				{
					r_Mop_Multiply_Quaternion_Vector3 = new(typeof(UnityEngine.Quaternion), "op_Multiply", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Vector3));
				}
				return r_Mop_Multiply_Quaternion_Vector3;
			}
		}

		/// <summary>
		/// Boolean IsEqualUsingDot(Single)
		/// </summary>
		protected static RMethod r_MIsEqualUsingDot_Single;
		public static RMethod RMIsEqualUsingDot_Single
		{
			get
			{
				if(r_MIsEqualUsingDot_Single == null)
				{
					r_MIsEqualUsingDot_Single = new(typeof(UnityEngine.Quaternion), "IsEqualUsingDot", 0, typeof(System.Single));
				}
				return r_MIsEqualUsingDot_Single;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Quaternion, UnityEngine.Quaternion)
		/// </summary>
		protected static RMethod r_Mop_Equality_Quaternion_Quaternion;
		public static RMethod RMop_Equality_Quaternion_Quaternion
		{
			get
			{
				if(r_Mop_Equality_Quaternion_Quaternion == null)
				{
					r_Mop_Equality_Quaternion_Quaternion = new(typeof(UnityEngine.Quaternion), "op_Equality", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion));
				}
				return r_Mop_Equality_Quaternion_Quaternion;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Quaternion, UnityEngine.Quaternion)
		/// </summary>
		protected static RMethod r_Mop_Inequality_Quaternion_Quaternion;
		public static RMethod RMop_Inequality_Quaternion_Quaternion
		{
			get
			{
				if(r_Mop_Inequality_Quaternion_Quaternion == null)
				{
					r_Mop_Inequality_Quaternion_Quaternion = new(typeof(UnityEngine.Quaternion), "op_Inequality", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion));
				}
				return r_Mop_Inequality_Quaternion_Quaternion;
			}
		}

		/// <summary>
		/// Single Dot(UnityEngine.Quaternion, UnityEngine.Quaternion)
		/// </summary>
		protected static RMethod r_MDot_Quaternion_Quaternion;
		public static RMethod RMDot_Quaternion_Quaternion
		{
			get
			{
				if(r_MDot_Quaternion_Quaternion == null)
				{
					r_MDot_Quaternion_Quaternion = new(typeof(UnityEngine.Quaternion), "Dot", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion));
				}
				return r_MDot_Quaternion_Quaternion;
			}
		}

		/// <summary>
		/// Void SetLookRotation(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MSetLookRotation_Vector3;
		public virtual RMethod RMSetLookRotation_Vector3
		{
			get
			{
				if(r_MSetLookRotation_Vector3 == null)
				{
					r_MSetLookRotation_Vector3 = new(this, "SetLookRotation", 0, typeof(UnityEngine.Vector3));
				}
				return r_MSetLookRotation_Vector3;
			}
		}

		/// <summary>
		/// Void SetLookRotation(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MSetLookRotation_Vector3_Vector3;
		public virtual RMethod RMSetLookRotation_Vector3_Vector3
		{
			get
			{
				if(r_MSetLookRotation_Vector3_Vector3 == null)
				{
					r_MSetLookRotation_Vector3_Vector3 = new(this, "SetLookRotation", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
				}
				return r_MSetLookRotation_Vector3_Vector3;
			}
		}

		/// <summary>
		/// Single Angle(UnityEngine.Quaternion, UnityEngine.Quaternion)
		/// </summary>
		protected static RMethod r_MAngle_Quaternion_Quaternion;
		public static RMethod RMAngle_Quaternion_Quaternion
		{
			get
			{
				if(r_MAngle_Quaternion_Quaternion == null)
				{
					r_MAngle_Quaternion_Quaternion = new(typeof(UnityEngine.Quaternion), "Angle", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion));
				}
				return r_MAngle_Quaternion_Quaternion;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 Internal_MakePositive(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_MInternal_MakePositive_Vector3;
		public static RMethod RMInternal_MakePositive_Vector3
		{
			get
			{
				if(r_MInternal_MakePositive_Vector3 == null)
				{
					r_MInternal_MakePositive_Vector3 = new(typeof(UnityEngine.Quaternion), "Internal_MakePositive", 0, typeof(UnityEngine.Vector3));
				}
				return r_MInternal_MakePositive_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion Euler(Single, Single, Single)
		/// </summary>
		protected static RMethod r_MEuler_Single_Single_Single;
		public static RMethod RMEuler_Single_Single_Single
		{
			get
			{
				if(r_MEuler_Single_Single_Single == null)
				{
					r_MEuler_Single_Single_Single = new(typeof(UnityEngine.Quaternion), "Euler", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
				}
				return r_MEuler_Single_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion Euler(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_MEuler_Vector3;
		public static RMethod RMEuler_Vector3
		{
			get
			{
				if(r_MEuler_Vector3 == null)
				{
					r_MEuler_Vector3 = new(typeof(UnityEngine.Quaternion), "Euler", 0, typeof(UnityEngine.Vector3));
				}
				return r_MEuler_Vector3;
			}
		}

		/// <summary>
		/// Void ToAngleAxis(Single ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_MToAngleAxis_Out_Single_Out_Vector3;
		public virtual RMethod RMToAngleAxis_Out_Single_Out_Vector3
		{
			get
			{
				if(r_MToAngleAxis_Out_Single_Out_Vector3 == null)
				{
					r_MToAngleAxis_Out_Single_Out_Vector3 = new(this, "ToAngleAxis", 0, typeof(System.Single).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
				}
				return r_MToAngleAxis_Out_Single_Out_Vector3;
			}
		}

		/// <summary>
		/// Void SetFromToRotation(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MSetFromToRotation_Vector3_Vector3;
		public virtual RMethod RMSetFromToRotation_Vector3_Vector3
		{
			get
			{
				if(r_MSetFromToRotation_Vector3_Vector3 == null)
				{
					r_MSetFromToRotation_Vector3_Vector3 = new(this, "SetFromToRotation", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
				}
				return r_MSetFromToRotation_Vector3_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion RotateTowards(UnityEngine.Quaternion, UnityEngine.Quaternion, Single)
		/// </summary>
		protected static RMethod r_MRotateTowards_Quaternion_Quaternion_Single;
		public static RMethod RMRotateTowards_Quaternion_Quaternion_Single
		{
			get
			{
				if(r_MRotateTowards_Quaternion_Quaternion_Single == null)
				{
					r_MRotateTowards_Quaternion_Quaternion_Single = new(typeof(UnityEngine.Quaternion), "RotateTowards", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion), typeof(System.Single));
				}
				return r_MRotateTowards_Quaternion_Quaternion_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion Normalize(UnityEngine.Quaternion)
		/// </summary>
		protected static RMethod r_MNormalize_Quaternion;
		public static RMethod RMNormalize_Quaternion
		{
			get
			{
				if(r_MNormalize_Quaternion == null)
				{
					r_MNormalize_Quaternion = new(typeof(UnityEngine.Quaternion), "Normalize", 0, typeof(UnityEngine.Quaternion));
				}
				return r_MNormalize_Quaternion;
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
		/// Boolean Equals(UnityEngine.Quaternion)
		/// </summary>
		protected RMethod r_MEquals_Quaternion;
		public virtual RMethod RMEquals_Quaternion
		{
			get
			{
				if(r_MEquals_Quaternion == null)
				{
					r_MEquals_Quaternion = new(this, "Equals", 0, typeof(UnityEngine.Quaternion));
				}
				return r_MEquals_Quaternion;
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
		/// UnityEngine.Quaternion EulerRotation(Single, Single, Single)
		/// </summary>
		protected static RMethod r_MEulerRotation_Single_Single_Single;
		public static RMethod RMEulerRotation_Single_Single_Single
		{
			get
			{
				if(r_MEulerRotation_Single_Single_Single == null)
				{
					r_MEulerRotation_Single_Single_Single = new(typeof(UnityEngine.Quaternion), "EulerRotation", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
				}
				return r_MEulerRotation_Single_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion EulerRotation(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_MEulerRotation_Vector3;
		public static RMethod RMEulerRotation_Vector3
		{
			get
			{
				if(r_MEulerRotation_Vector3 == null)
				{
					r_MEulerRotation_Vector3 = new(typeof(UnityEngine.Quaternion), "EulerRotation", 0, typeof(UnityEngine.Vector3));
				}
				return r_MEulerRotation_Vector3;
			}
		}

		/// <summary>
		/// Void SetEulerRotation(Single, Single, Single)
		/// </summary>
		protected RMethod r_MSetEulerRotation_Single_Single_Single;
		public virtual RMethod RMSetEulerRotation_Single_Single_Single
		{
			get
			{
				if(r_MSetEulerRotation_Single_Single_Single == null)
				{
					r_MSetEulerRotation_Single_Single_Single = new(this, "SetEulerRotation", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
				}
				return r_MSetEulerRotation_Single_Single_Single;
			}
		}

		/// <summary>
		/// Void SetEulerRotation(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MSetEulerRotation_Vector3;
		public virtual RMethod RMSetEulerRotation_Vector3
		{
			get
			{
				if(r_MSetEulerRotation_Vector3 == null)
				{
					r_MSetEulerRotation_Vector3 = new(this, "SetEulerRotation", 0, typeof(UnityEngine.Vector3));
				}
				return r_MSetEulerRotation_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ToEuler()
		/// </summary>
		protected RMethod r_MToEuler;
		public virtual RMethod RMToEuler
		{
			get
			{
				if(r_MToEuler == null)
				{
					r_MToEuler = new(this, "ToEuler", 0);
				}
				return r_MToEuler;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion EulerAngles(Single, Single, Single)
		/// </summary>
		protected static RMethod r_MEulerAngles_Single_Single_Single;
		public static RMethod RMEulerAngles_Single_Single_Single
		{
			get
			{
				if(r_MEulerAngles_Single_Single_Single == null)
				{
					r_MEulerAngles_Single_Single_Single = new(typeof(UnityEngine.Quaternion), "EulerAngles", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
				}
				return r_MEulerAngles_Single_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion EulerAngles(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_MEulerAngles_Vector3;
		public static RMethod RMEulerAngles_Vector3
		{
			get
			{
				if(r_MEulerAngles_Vector3 == null)
				{
					r_MEulerAngles_Vector3 = new(typeof(UnityEngine.Quaternion), "EulerAngles", 0, typeof(UnityEngine.Vector3));
				}
				return r_MEulerAngles_Vector3;
			}
		}

		/// <summary>
		/// Void ToAxisAngle(UnityEngine.Vector3 ByRef, Single ByRef)
		/// </summary>
		protected RMethod r_MToAxisAngle_Out_Vector3_Out_Single;
		public virtual RMethod RMToAxisAngle_Out_Vector3_Out_Single
		{
			get
			{
				if(r_MToAxisAngle_Out_Vector3_Out_Single == null)
				{
					r_MToAxisAngle_Out_Vector3_Out_Single = new(this, "ToAxisAngle", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single).MakeByRefType());
				}
				return r_MToAxisAngle_Out_Vector3_Out_Single;
			}
		}

		/// <summary>
		/// Void SetEulerAngles(Single, Single, Single)
		/// </summary>
		protected RMethod r_MSetEulerAngles_Single_Single_Single;
		public virtual RMethod RMSetEulerAngles_Single_Single_Single
		{
			get
			{
				if(r_MSetEulerAngles_Single_Single_Single == null)
				{
					r_MSetEulerAngles_Single_Single_Single = new(this, "SetEulerAngles", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
				}
				return r_MSetEulerAngles_Single_Single_Single;
			}
		}

		/// <summary>
		/// Void SetEulerAngles(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MSetEulerAngles_Vector3;
		public virtual RMethod RMSetEulerAngles_Vector3
		{
			get
			{
				if(r_MSetEulerAngles_Vector3 == null)
				{
					r_MSetEulerAngles_Vector3 = new(this, "SetEulerAngles", 0, typeof(UnityEngine.Vector3));
				}
				return r_MSetEulerAngles_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ToEulerAngles(UnityEngine.Quaternion)
		/// </summary>
		protected static RMethod r_MToEulerAngles_Quaternion;
		public static RMethod RMToEulerAngles_Quaternion
		{
			get
			{
				if(r_MToEulerAngles_Quaternion == null)
				{
					r_MToEulerAngles_Quaternion = new(typeof(UnityEngine.Quaternion), "ToEulerAngles", 0, typeof(UnityEngine.Quaternion));
				}
				return r_MToEulerAngles_Quaternion;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ToEulerAngles()
		/// </summary>
		protected RMethod r_MToEulerAngles;
		public virtual RMethod RMToEulerAngles
		{
			get
			{
				if(r_MToEulerAngles == null)
				{
					r_MToEulerAngles = new(this, "ToEulerAngles", 0);
				}
				return r_MToEulerAngles;
			}
		}

		/// <summary>
		/// Void SetAxisAngle(UnityEngine.Vector3, Single)
		/// </summary>
		protected RMethod r_MSetAxisAngle_Vector3_Single;
		public virtual RMethod RMSetAxisAngle_Vector3_Single
		{
			get
			{
				if(r_MSetAxisAngle_Vector3_Single == null)
				{
					r_MSetAxisAngle_Vector3_Single = new(this, "SetAxisAngle", 0, typeof(UnityEngine.Vector3), typeof(System.Single));
				}
				return r_MSetAxisAngle_Vector3_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion AxisAngle(UnityEngine.Vector3, Single)
		/// </summary>
		protected static RMethod r_MAxisAngle_Vector3_Single;
		public static RMethod RMAxisAngle_Vector3_Single
		{
			get
			{
				if(r_MAxisAngle_Vector3_Single == null)
				{
					r_MAxisAngle_Vector3_Single = new(typeof(UnityEngine.Quaternion), "AxisAngle", 0, typeof(UnityEngine.Vector3), typeof(System.Single));
				}
				return r_MAxisAngle_Vector3_Single;
			}
		}

		/// <summary>
		/// Void FromToRotation_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef, UnityEngine.Quaternion ByRef)
		/// </summary>
		protected static RMethod r_MFromToRotation_Injected_Ref_Vector3_Ref_Vector3_Out_Quaternion;
		public static RMethod RMFromToRotation_Injected_Ref_Vector3_Ref_Vector3_Out_Quaternion
		{
			get
			{
				if(r_MFromToRotation_Injected_Ref_Vector3_Ref_Vector3_Out_Quaternion == null)
				{
					r_MFromToRotation_Injected_Ref_Vector3_Ref_Vector3_Out_Quaternion = new(typeof(UnityEngine.Quaternion), "FromToRotation_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType());
				}
				return r_MFromToRotation_Injected_Ref_Vector3_Ref_Vector3_Out_Quaternion;
			}
		}

		/// <summary>
		/// Void Inverse_Injected(UnityEngine.Quaternion ByRef, UnityEngine.Quaternion ByRef)
		/// </summary>
		protected static RMethod r_MInverse_Injected_Ref_Quaternion_Out_Quaternion;
		public static RMethod RMInverse_Injected_Ref_Quaternion_Out_Quaternion
		{
			get
			{
				if(r_MInverse_Injected_Ref_Quaternion_Out_Quaternion == null)
				{
					r_MInverse_Injected_Ref_Quaternion_Out_Quaternion = new(typeof(UnityEngine.Quaternion), "Inverse_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType());
				}
				return r_MInverse_Injected_Ref_Quaternion_Out_Quaternion;
			}
		}

		/// <summary>
		/// Void Slerp_Injected(UnityEngine.Quaternion ByRef, UnityEngine.Quaternion ByRef, Single, UnityEngine.Quaternion ByRef)
		/// </summary>
		protected static RMethod r_MSlerp_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion;
		public static RMethod RMSlerp_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion
		{
			get
			{
				if(r_MSlerp_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion == null)
				{
					r_MSlerp_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion = new(typeof(UnityEngine.Quaternion), "Slerp_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(System.Single), typeof(UnityEngine.Quaternion).MakeByRefType());
				}
				return r_MSlerp_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion;
			}
		}

		/// <summary>
		/// Void SlerpUnclamped_Injected(UnityEngine.Quaternion ByRef, UnityEngine.Quaternion ByRef, Single, UnityEngine.Quaternion ByRef)
		/// </summary>
		protected static RMethod r_MSlerpUnclamped_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion;
		public static RMethod RMSlerpUnclamped_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion
		{
			get
			{
				if(r_MSlerpUnclamped_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion == null)
				{
					r_MSlerpUnclamped_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion = new(typeof(UnityEngine.Quaternion), "SlerpUnclamped_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(System.Single), typeof(UnityEngine.Quaternion).MakeByRefType());
				}
				return r_MSlerpUnclamped_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion;
			}
		}

		/// <summary>
		/// Void Lerp_Injected(UnityEngine.Quaternion ByRef, UnityEngine.Quaternion ByRef, Single, UnityEngine.Quaternion ByRef)
		/// </summary>
		protected static RMethod r_MLerp_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion;
		public static RMethod RMLerp_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion
		{
			get
			{
				if(r_MLerp_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion == null)
				{
					r_MLerp_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion = new(typeof(UnityEngine.Quaternion), "Lerp_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(System.Single), typeof(UnityEngine.Quaternion).MakeByRefType());
				}
				return r_MLerp_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion;
			}
		}

		/// <summary>
		/// Void LerpUnclamped_Injected(UnityEngine.Quaternion ByRef, UnityEngine.Quaternion ByRef, Single, UnityEngine.Quaternion ByRef)
		/// </summary>
		protected static RMethod r_MLerpUnclamped_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion;
		public static RMethod RMLerpUnclamped_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion
		{
			get
			{
				if(r_MLerpUnclamped_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion == null)
				{
					r_MLerpUnclamped_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion = new(typeof(UnityEngine.Quaternion), "LerpUnclamped_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(System.Single), typeof(UnityEngine.Quaternion).MakeByRefType());
				}
				return r_MLerpUnclamped_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion;
			}
		}

		/// <summary>
		/// Void Internal_FromEulerRad_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Quaternion ByRef)
		/// </summary>
		protected static RMethod r_MInternal_FromEulerRad_Injected_Ref_Vector3_Out_Quaternion;
		public static RMethod RMInternal_FromEulerRad_Injected_Ref_Vector3_Out_Quaternion
		{
			get
			{
				if(r_MInternal_FromEulerRad_Injected_Ref_Vector3_Out_Quaternion == null)
				{
					r_MInternal_FromEulerRad_Injected_Ref_Vector3_Out_Quaternion = new(typeof(UnityEngine.Quaternion), "Internal_FromEulerRad_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType());
				}
				return r_MInternal_FromEulerRad_Injected_Ref_Vector3_Out_Quaternion;
			}
		}

		/// <summary>
		/// Void Internal_ToEulerRad_Injected(UnityEngine.Quaternion ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected static RMethod r_MInternal_ToEulerRad_Injected_Ref_Quaternion_Out_Vector3;
		public static RMethod RMInternal_ToEulerRad_Injected_Ref_Quaternion_Out_Vector3
		{
			get
			{
				if(r_MInternal_ToEulerRad_Injected_Ref_Quaternion_Out_Vector3 == null)
				{
					r_MInternal_ToEulerRad_Injected_Ref_Quaternion_Out_Vector3 = new(typeof(UnityEngine.Quaternion), "Internal_ToEulerRad_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
				}
				return r_MInternal_ToEulerRad_Injected_Ref_Quaternion_Out_Vector3;
			}
		}

		/// <summary>
		/// Void Internal_ToAxisAngleRad_Injected(UnityEngine.Quaternion ByRef, UnityEngine.Vector3 ByRef, Single ByRef)
		/// </summary>
		protected static RMethod r_MInternal_ToAxisAngleRad_Injected_Ref_Quaternion_Out_Vector3_Out_Single;
		public static RMethod RMInternal_ToAxisAngleRad_Injected_Ref_Quaternion_Out_Vector3_Out_Single
		{
			get
			{
				if(r_MInternal_ToAxisAngleRad_Injected_Ref_Quaternion_Out_Vector3_Out_Single == null)
				{
					r_MInternal_ToAxisAngleRad_Injected_Ref_Quaternion_Out_Vector3_Out_Single = new(typeof(UnityEngine.Quaternion), "Internal_ToAxisAngleRad_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single).MakeByRefType());
				}
				return r_MInternal_ToAxisAngleRad_Injected_Ref_Quaternion_Out_Vector3_Out_Single;
			}
		}

		/// <summary>
		/// Void AngleAxis_Injected(Single, UnityEngine.Vector3 ByRef, UnityEngine.Quaternion ByRef)
		/// </summary>
		protected static RMethod r_MAngleAxis_Injected_Single_Ref_Vector3_Out_Quaternion;
		public static RMethod RMAngleAxis_Injected_Single_Ref_Vector3_Out_Quaternion
		{
			get
			{
				if(r_MAngleAxis_Injected_Single_Ref_Vector3_Out_Quaternion == null)
				{
					r_MAngleAxis_Injected_Single_Ref_Vector3_Out_Quaternion = new(typeof(UnityEngine.Quaternion), "AngleAxis_Injected", 0, typeof(System.Single), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType());
				}
				return r_MAngleAxis_Injected_Single_Ref_Vector3_Out_Quaternion;
			}
		}

		/// <summary>
		/// Void LookRotation_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef, UnityEngine.Quaternion ByRef)
		/// </summary>
		protected static RMethod r_MLookRotation_Injected_Ref_Vector3_Ref_Vector3_Out_Quaternion;
		public static RMethod RMLookRotation_Injected_Ref_Vector3_Ref_Vector3_Out_Quaternion
		{
			get
			{
				if(r_MLookRotation_Injected_Ref_Vector3_Ref_Vector3_Out_Quaternion == null)
				{
					r_MLookRotation_Injected_Ref_Vector3_Ref_Vector3_Out_Quaternion = new(typeof(UnityEngine.Quaternion), "LookRotation_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType());
				}
				return r_MLookRotation_Injected_Ref_Vector3_Ref_Vector3_Out_Quaternion;
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


        public static UnityEngine.Quaternion FromToRotation(UnityEngine.Vector3 @fromDirection, UnityEngine.Vector3 @toDirection)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromDirection, @toDirection};
            var ___result = RMFromToRotation_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static UnityEngine.Quaternion Inverse(UnityEngine.Quaternion @rotation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rotation};
            var ___result = RMInverse_Quaternion.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static UnityEngine.Quaternion Slerp(UnityEngine.Quaternion @a, UnityEngine.Quaternion @b, System.Single @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RMSlerp_Quaternion_Quaternion_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static UnityEngine.Quaternion SlerpUnclamped(UnityEngine.Quaternion @a, UnityEngine.Quaternion @b, System.Single @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RMSlerpUnclamped_Quaternion_Quaternion_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static UnityEngine.Quaternion Lerp(UnityEngine.Quaternion @a, UnityEngine.Quaternion @b, System.Single @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RMLerp_Quaternion_Quaternion_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static UnityEngine.Quaternion LerpUnclamped(UnityEngine.Quaternion @a, UnityEngine.Quaternion @b, System.Single @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RMLerpUnclamped_Quaternion_Quaternion_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static UnityEngine.Quaternion Internal_FromEulerRad(UnityEngine.Vector3 @euler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@euler};
            var ___result = RMInternal_FromEulerRad_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static UnityEngine.Vector3 Internal_ToEulerRad(UnityEngine.Quaternion @rotation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rotation};
            var ___result = RMInternal_ToEulerRad_Quaternion.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static void Internal_ToAxisAngleRad(UnityEngine.Quaternion @q, out UnityEngine.Vector3 @axis, out System.Single @angle)
        {
			@axis = default;
			@angle = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@q, @axis, @angle};
            var ___result = RMInternal_ToAxisAngleRad_Quaternion_Out_Vector3_Out_Single.Invoke(___genericsType, ___parameters);
			@axis = (UnityEngine.Vector3)___parameters[1];
			@angle = (System.Single)___parameters[2];

            
        }


        public static UnityEngine.Quaternion AngleAxis(System.Single @angle, UnityEngine.Vector3 @axis)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@angle, @axis};
            var ___result = RMAngleAxis_Single_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static UnityEngine.Quaternion LookRotation(UnityEngine.Vector3 @forward, UnityEngine.Vector3 @upwards)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@forward, @upwards};
            var ___result = RMLookRotation_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static UnityEngine.Quaternion LookRotation(UnityEngine.Vector3 @forward)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@forward};
            var ___result = RMLookRotation_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public virtual void Set(System.Single @newX, System.Single @newY, System.Single @newZ, System.Single @newW)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newX, @newY, @newZ, @newW};
            var ___result = RMSet_Single_Single_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Quaternion op_Multiply(UnityEngine.Quaternion @lhs, UnityEngine.Quaternion @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Multiply_Quaternion_Quaternion.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static UnityEngine.Vector3 op_Multiply(UnityEngine.Quaternion @rotation, UnityEngine.Vector3 @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rotation, @point};
            var ___result = RMop_Multiply_Quaternion_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static System.Boolean IsEqualUsingDot(System.Single @dot)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dot};
            var ___result = RMIsEqualUsingDot_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Quaternion @lhs, UnityEngine.Quaternion @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_Quaternion_Quaternion.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Quaternion @lhs, UnityEngine.Quaternion @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_Quaternion_Quaternion.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Single Dot(UnityEngine.Quaternion @a, UnityEngine.Quaternion @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMDot_Quaternion_Quaternion.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual void SetLookRotation(UnityEngine.Vector3 @view)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@view};
            var ___result = RMSetLookRotation_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetLookRotation(UnityEngine.Vector3 @view, UnityEngine.Vector3 @up)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@view, @up};
            var ___result = RMSetLookRotation_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Single Angle(UnityEngine.Quaternion @a, UnityEngine.Quaternion @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMAngle_Quaternion_Quaternion.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static UnityEngine.Vector3 Internal_MakePositive(UnityEngine.Vector3 @euler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@euler};
            var ___result = RMInternal_MakePositive_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Quaternion Euler(System.Single @x, System.Single @y, System.Single @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = RMEuler_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static UnityEngine.Quaternion Euler(UnityEngine.Vector3 @euler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@euler};
            var ___result = RMEuler_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public virtual void ToAngleAxis(out System.Single @angle, out UnityEngine.Vector3 @axis)
        {
			@angle = default;
			@axis = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@angle, @axis};
            var ___result = RMToAngleAxis_Out_Single_Out_Vector3.Invoke(___genericsType, ___parameters);
			@angle = (System.Single)___parameters[0];
			@axis = (UnityEngine.Vector3)___parameters[1];

            
        }


        public virtual void SetFromToRotation(UnityEngine.Vector3 @fromDirection, UnityEngine.Vector3 @toDirection)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromDirection, @toDirection};
            var ___result = RMSetFromToRotation_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Quaternion RotateTowards(UnityEngine.Quaternion @from, UnityEngine.Quaternion @to, System.Single @maxDegreesDelta)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @maxDegreesDelta};
            var ___result = RMRotateTowards_Quaternion_Quaternion_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static UnityEngine.Quaternion Normalize(UnityEngine.Quaternion @q)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@q};
            var ___result = RMNormalize_Quaternion.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public virtual void Normalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMNormalize.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Boolean Equals(UnityEngine.Quaternion @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Quaternion.Invoke(___genericsType, ___parameters);

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


        public static UnityEngine.Quaternion EulerRotation(System.Single @x, System.Single @y, System.Single @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = RMEulerRotation_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static UnityEngine.Quaternion EulerRotation(UnityEngine.Vector3 @euler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@euler};
            var ___result = RMEulerRotation_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public virtual void SetEulerRotation(System.Single @x, System.Single @y, System.Single @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = RMSetEulerRotation_Single_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetEulerRotation(UnityEngine.Vector3 @euler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@euler};
            var ___result = RMSetEulerRotation_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector3 ToEuler()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToEuler.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Quaternion EulerAngles(System.Single @x, System.Single @y, System.Single @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = RMEulerAngles_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static UnityEngine.Quaternion EulerAngles(UnityEngine.Vector3 @euler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@euler};
            var ___result = RMEulerAngles_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public virtual void ToAxisAngle(out UnityEngine.Vector3 @axis, out System.Single @angle)
        {
			@axis = default;
			@angle = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@axis, @angle};
            var ___result = RMToAxisAngle_Out_Vector3_Out_Single.Invoke(___genericsType, ___parameters);
			@axis = (UnityEngine.Vector3)___parameters[0];
			@angle = (System.Single)___parameters[1];

            
        }


        public virtual void SetEulerAngles(System.Single @x, System.Single @y, System.Single @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = RMSetEulerAngles_Single_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetEulerAngles(UnityEngine.Vector3 @euler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@euler};
            var ___result = RMSetEulerAngles_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Vector3 ToEulerAngles(UnityEngine.Quaternion @rotation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rotation};
            var ___result = RMToEulerAngles_Quaternion.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual UnityEngine.Vector3 ToEulerAngles()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToEulerAngles.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual void SetAxisAngle(UnityEngine.Vector3 @axis, System.Single @angle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@axis, @angle};
            var ___result = RMSetAxisAngle_Vector3_Single.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Quaternion AxisAngle(UnityEngine.Vector3 @axis, System.Single @angle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@axis, @angle};
            var ___result = RMAxisAngle_Vector3_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static void FromToRotation_Injected(ref UnityEngine.Vector3 @fromDirection, ref UnityEngine.Vector3 @toDirection, out UnityEngine.Quaternion @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromDirection, @toDirection, @ret};
            var ___result = RMFromToRotation_Injected_Ref_Vector3_Ref_Vector3_Out_Quaternion.Invoke(___genericsType, ___parameters);
			@fromDirection = (UnityEngine.Vector3)___parameters[0];
			@toDirection = (UnityEngine.Vector3)___parameters[1];
			@ret = (UnityEngine.Quaternion)___parameters[2];

            
        }


        public static void Inverse_Injected(ref UnityEngine.Quaternion @rotation, out UnityEngine.Quaternion @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rotation, @ret};
            var ___result = RMInverse_Injected_Ref_Quaternion_Out_Quaternion.Invoke(___genericsType, ___parameters);
			@rotation = (UnityEngine.Quaternion)___parameters[0];
			@ret = (UnityEngine.Quaternion)___parameters[1];

            
        }


        public static void Slerp_Injected(ref UnityEngine.Quaternion @a, ref UnityEngine.Quaternion @b, System.Single @t, out UnityEngine.Quaternion @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t, @ret};
            var ___result = RMSlerp_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion.Invoke(___genericsType, ___parameters);
			@a = (UnityEngine.Quaternion)___parameters[0];
			@b = (UnityEngine.Quaternion)___parameters[1];
			@ret = (UnityEngine.Quaternion)___parameters[3];

            
        }


        public static void SlerpUnclamped_Injected(ref UnityEngine.Quaternion @a, ref UnityEngine.Quaternion @b, System.Single @t, out UnityEngine.Quaternion @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t, @ret};
            var ___result = RMSlerpUnclamped_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion.Invoke(___genericsType, ___parameters);
			@a = (UnityEngine.Quaternion)___parameters[0];
			@b = (UnityEngine.Quaternion)___parameters[1];
			@ret = (UnityEngine.Quaternion)___parameters[3];

            
        }


        public static void Lerp_Injected(ref UnityEngine.Quaternion @a, ref UnityEngine.Quaternion @b, System.Single @t, out UnityEngine.Quaternion @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t, @ret};
            var ___result = RMLerp_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion.Invoke(___genericsType, ___parameters);
			@a = (UnityEngine.Quaternion)___parameters[0];
			@b = (UnityEngine.Quaternion)___parameters[1];
			@ret = (UnityEngine.Quaternion)___parameters[3];

            
        }


        public static void LerpUnclamped_Injected(ref UnityEngine.Quaternion @a, ref UnityEngine.Quaternion @b, System.Single @t, out UnityEngine.Quaternion @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t, @ret};
            var ___result = RMLerpUnclamped_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion.Invoke(___genericsType, ___parameters);
			@a = (UnityEngine.Quaternion)___parameters[0];
			@b = (UnityEngine.Quaternion)___parameters[1];
			@ret = (UnityEngine.Quaternion)___parameters[3];

            
        }


        public static void Internal_FromEulerRad_Injected(ref UnityEngine.Vector3 @euler, out UnityEngine.Quaternion @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@euler, @ret};
            var ___result = RMInternal_FromEulerRad_Injected_Ref_Vector3_Out_Quaternion.Invoke(___genericsType, ___parameters);
			@euler = (UnityEngine.Vector3)___parameters[0];
			@ret = (UnityEngine.Quaternion)___parameters[1];

            
        }


        public static void Internal_ToEulerRad_Injected(ref UnityEngine.Quaternion @rotation, out UnityEngine.Vector3 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rotation, @ret};
            var ___result = RMInternal_ToEulerRad_Injected_Ref_Quaternion_Out_Vector3.Invoke(___genericsType, ___parameters);
			@rotation = (UnityEngine.Quaternion)___parameters[0];
			@ret = (UnityEngine.Vector3)___parameters[1];

            
        }


        public static void Internal_ToAxisAngleRad_Injected(ref UnityEngine.Quaternion @q, out UnityEngine.Vector3 @axis, out System.Single @angle)
        {
			@axis = default;
			@angle = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@q, @axis, @angle};
            var ___result = RMInternal_ToAxisAngleRad_Injected_Ref_Quaternion_Out_Vector3_Out_Single.Invoke(___genericsType, ___parameters);
			@q = (UnityEngine.Quaternion)___parameters[0];
			@axis = (UnityEngine.Vector3)___parameters[1];
			@angle = (System.Single)___parameters[2];

            
        }


        public static void AngleAxis_Injected(System.Single @angle, ref UnityEngine.Vector3 @axis, out UnityEngine.Quaternion @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@angle, @axis, @ret};
            var ___result = RMAngleAxis_Injected_Single_Ref_Vector3_Out_Quaternion.Invoke(___genericsType, ___parameters);
			@axis = (UnityEngine.Vector3)___parameters[1];
			@ret = (UnityEngine.Quaternion)___parameters[2];

            
        }


        public static void LookRotation_Injected(ref UnityEngine.Vector3 @forward, ref UnityEngine.Vector3 @upwards, out UnityEngine.Quaternion @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@forward, @upwards, @ret};
            var ___result = RMLookRotation_Injected_Ref_Vector3_Ref_Vector3_Out_Quaternion.Invoke(___genericsType, ___parameters);
			@forward = (UnityEngine.Vector3)___parameters[0];
			@upwards = (UnityEngine.Vector3)___parameters[1];
			@ret = (UnityEngine.Quaternion)___parameters[2];

            
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
