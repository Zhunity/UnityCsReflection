using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Quaternion
	/// </summary>
    public partial class RQuaternion : RMember //
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
		/// UnityEngine.Quaternion identityQuaternion
		/// </summary>
		protected static RUnityEngine.RQuaternion r_identityQuaternion;
		public static RUnityEngine.RQuaternion RidentityQuaternion
		{
			get
			{
				if(r_identityQuaternion == null)
				{
					r_identityQuaternion = new(typeof(UnityEngine.Quaternion), "identityQuaternion");
					r_identityQuaternion.SetBelong(null);
				}
				return r_identityQuaternion;
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
					r_kEpsilon = new(typeof(UnityEngine.Quaternion), "kEpsilon");
					r_kEpsilon.SetBelong(null);
				}
				return r_kEpsilon;
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
		/// UnityEngine.Quaternion identity
		/// </summary>
		protected static RUnityEngine.RQuaternion r_identity;
		public static RUnityEngine.RQuaternion Ridentity
		{
			get
			{
				if(r_identity == null)
				{
					r_identity = new(typeof(UnityEngine.Quaternion), "identity", -1);
					r_identity.SetBelong(null);
				}
				return r_identity;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 eulerAngles
		/// </summary>
		protected RUnityEngine.RVector3 r_eulerAngles;
		public virtual RUnityEngine.RVector3 ReulerAngles
		{
			get
			{
				if(r_eulerAngles == null)
				{
					r_eulerAngles = new(this, "eulerAngles", -1);
					r_eulerAngles.SetBelong(this.instance);
				}
				return r_eulerAngles;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion normalized
		/// </summary>
		protected RUnityEngine.RQuaternion r_normalized;
		public virtual RUnityEngine.RQuaternion Rnormalized
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
		/// UnityEngine.Quaternion FromToRotation(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_FromToRotation_Vector3_Vector3;
		public static RMethod RFromToRotation_Vector3_Vector3
		{
			get
			{
				if(r_FromToRotation_Vector3_Vector3 == null)
				{
					r_FromToRotation_Vector3_Vector3 = new(typeof(UnityEngine.Quaternion), "FromToRotation", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_FromToRotation_Vector3_Vector3.SetBelong(null);
				}
				return r_FromToRotation_Vector3_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion Inverse(UnityEngine.Quaternion)
		/// </summary>
		protected static RMethod r_Inverse_Quaternion;
		public static RMethod RInverse_Quaternion
		{
			get
			{
				if(r_Inverse_Quaternion == null)
				{
					r_Inverse_Quaternion = new(typeof(UnityEngine.Quaternion), "Inverse", 0, typeof(UnityEngine.Quaternion));
					r_Inverse_Quaternion.SetBelong(null);
				}
				return r_Inverse_Quaternion;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion Slerp(UnityEngine.Quaternion, UnityEngine.Quaternion, Single)
		/// </summary>
		protected static RMethod r_Slerp_Quaternion_Quaternion_Single;
		public static RMethod RSlerp_Quaternion_Quaternion_Single
		{
			get
			{
				if(r_Slerp_Quaternion_Quaternion_Single == null)
				{
					r_Slerp_Quaternion_Quaternion_Single = new(typeof(UnityEngine.Quaternion), "Slerp", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion), typeof(System.Single));
					r_Slerp_Quaternion_Quaternion_Single.SetBelong(null);
				}
				return r_Slerp_Quaternion_Quaternion_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion SlerpUnclamped(UnityEngine.Quaternion, UnityEngine.Quaternion, Single)
		/// </summary>
		protected static RMethod r_SlerpUnclamped_Quaternion_Quaternion_Single;
		public static RMethod RSlerpUnclamped_Quaternion_Quaternion_Single
		{
			get
			{
				if(r_SlerpUnclamped_Quaternion_Quaternion_Single == null)
				{
					r_SlerpUnclamped_Quaternion_Quaternion_Single = new(typeof(UnityEngine.Quaternion), "SlerpUnclamped", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion), typeof(System.Single));
					r_SlerpUnclamped_Quaternion_Quaternion_Single.SetBelong(null);
				}
				return r_SlerpUnclamped_Quaternion_Quaternion_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion Lerp(UnityEngine.Quaternion, UnityEngine.Quaternion, Single)
		/// </summary>
		protected static RMethod r_Lerp_Quaternion_Quaternion_Single;
		public static RMethod RLerp_Quaternion_Quaternion_Single
		{
			get
			{
				if(r_Lerp_Quaternion_Quaternion_Single == null)
				{
					r_Lerp_Quaternion_Quaternion_Single = new(typeof(UnityEngine.Quaternion), "Lerp", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion), typeof(System.Single));
					r_Lerp_Quaternion_Quaternion_Single.SetBelong(null);
				}
				return r_Lerp_Quaternion_Quaternion_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion LerpUnclamped(UnityEngine.Quaternion, UnityEngine.Quaternion, Single)
		/// </summary>
		protected static RMethod r_LerpUnclamped_Quaternion_Quaternion_Single;
		public static RMethod RLerpUnclamped_Quaternion_Quaternion_Single
		{
			get
			{
				if(r_LerpUnclamped_Quaternion_Quaternion_Single == null)
				{
					r_LerpUnclamped_Quaternion_Quaternion_Single = new(typeof(UnityEngine.Quaternion), "LerpUnclamped", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion), typeof(System.Single));
					r_LerpUnclamped_Quaternion_Quaternion_Single.SetBelong(null);
				}
				return r_LerpUnclamped_Quaternion_Quaternion_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion Internal_FromEulerRad(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_Internal_FromEulerRad_Vector3;
		public static RMethod RInternal_FromEulerRad_Vector3
		{
			get
			{
				if(r_Internal_FromEulerRad_Vector3 == null)
				{
					r_Internal_FromEulerRad_Vector3 = new(typeof(UnityEngine.Quaternion), "Internal_FromEulerRad", 0, typeof(UnityEngine.Vector3));
					r_Internal_FromEulerRad_Vector3.SetBelong(null);
				}
				return r_Internal_FromEulerRad_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 Internal_ToEulerRad(UnityEngine.Quaternion)
		/// </summary>
		protected static RMethod r_Internal_ToEulerRad_Quaternion;
		public static RMethod RInternal_ToEulerRad_Quaternion
		{
			get
			{
				if(r_Internal_ToEulerRad_Quaternion == null)
				{
					r_Internal_ToEulerRad_Quaternion = new(typeof(UnityEngine.Quaternion), "Internal_ToEulerRad", 0, typeof(UnityEngine.Quaternion));
					r_Internal_ToEulerRad_Quaternion.SetBelong(null);
				}
				return r_Internal_ToEulerRad_Quaternion;
			}
		}

		/// <summary>
		/// Void Internal_ToAxisAngleRad(UnityEngine.Quaternion, UnityEngine.Vector3 ByRef, Single ByRef)
		/// </summary>
		protected static RMethod r_Internal_ToAxisAngleRad_Quaternion_Out_Vector3_Out_Single;
		public static RMethod RInternal_ToAxisAngleRad_Quaternion_Out_Vector3_Out_Single
		{
			get
			{
				if(r_Internal_ToAxisAngleRad_Quaternion_Out_Vector3_Out_Single == null)
				{
					r_Internal_ToAxisAngleRad_Quaternion_Out_Vector3_Out_Single = new(typeof(UnityEngine.Quaternion), "Internal_ToAxisAngleRad", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single).MakeByRefType());
					r_Internal_ToAxisAngleRad_Quaternion_Out_Vector3_Out_Single.SetBelong(null);
				}
				return r_Internal_ToAxisAngleRad_Quaternion_Out_Vector3_Out_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion AngleAxis(Single, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_AngleAxis_Single_Vector3;
		public static RMethod RAngleAxis_Single_Vector3
		{
			get
			{
				if(r_AngleAxis_Single_Vector3 == null)
				{
					r_AngleAxis_Single_Vector3 = new(typeof(UnityEngine.Quaternion), "AngleAxis", 0, typeof(System.Single), typeof(UnityEngine.Vector3));
					r_AngleAxis_Single_Vector3.SetBelong(null);
				}
				return r_AngleAxis_Single_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion LookRotation(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_LookRotation_Vector3_Vector3;
		public static RMethod RLookRotation_Vector3_Vector3
		{
			get
			{
				if(r_LookRotation_Vector3_Vector3 == null)
				{
					r_LookRotation_Vector3_Vector3 = new(typeof(UnityEngine.Quaternion), "LookRotation", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_LookRotation_Vector3_Vector3.SetBelong(null);
				}
				return r_LookRotation_Vector3_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion LookRotation(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_LookRotation_Vector3;
		public static RMethod RLookRotation_Vector3
		{
			get
			{
				if(r_LookRotation_Vector3 == null)
				{
					r_LookRotation_Vector3 = new(typeof(UnityEngine.Quaternion), "LookRotation", 0, typeof(UnityEngine.Vector3));
					r_LookRotation_Vector3.SetBelong(null);
				}
				return r_LookRotation_Vector3;
			}
		}

		/// <summary>
		/// Void Set(Single, Single, Single, Single)
		/// </summary>
		protected RMethod r_Set_Single_Single_Single_Single;
		public virtual RMethod RSet_Single_Single_Single_Single
		{
			get
			{
				if(r_Set_Single_Single_Single_Single == null)
				{
					r_Set_Single_Single_Single_Single = new(this, "Set", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_Set_Single_Single_Single_Single.SetBelong(this.instance);
				}
				return r_Set_Single_Single_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion op_Multiply(UnityEngine.Quaternion, UnityEngine.Quaternion)
		/// </summary>
		protected static RMethod r_op_Multiply_Quaternion_Quaternion;
		public static RMethod Rop_Multiply_Quaternion_Quaternion
		{
			get
			{
				if(r_op_Multiply_Quaternion_Quaternion == null)
				{
					r_op_Multiply_Quaternion_Quaternion = new(typeof(UnityEngine.Quaternion), "op_Multiply", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion));
					r_op_Multiply_Quaternion_Quaternion.SetBelong(null);
				}
				return r_op_Multiply_Quaternion_Quaternion;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 op_Multiply(UnityEngine.Quaternion, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_op_Multiply_Quaternion_Vector3;
		public static RMethod Rop_Multiply_Quaternion_Vector3
		{
			get
			{
				if(r_op_Multiply_Quaternion_Vector3 == null)
				{
					r_op_Multiply_Quaternion_Vector3 = new(typeof(UnityEngine.Quaternion), "op_Multiply", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Vector3));
					r_op_Multiply_Quaternion_Vector3.SetBelong(null);
				}
				return r_op_Multiply_Quaternion_Vector3;
			}
		}

		/// <summary>
		/// Boolean IsEqualUsingDot(Single)
		/// </summary>
		protected static RMethod r_IsEqualUsingDot_Single;
		public static RMethod RIsEqualUsingDot_Single
		{
			get
			{
				if(r_IsEqualUsingDot_Single == null)
				{
					r_IsEqualUsingDot_Single = new(typeof(UnityEngine.Quaternion), "IsEqualUsingDot", 0, typeof(System.Single));
					r_IsEqualUsingDot_Single.SetBelong(null);
				}
				return r_IsEqualUsingDot_Single;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Quaternion, UnityEngine.Quaternion)
		/// </summary>
		protected static RMethod r_op_Equality_Quaternion_Quaternion;
		public static RMethod Rop_Equality_Quaternion_Quaternion
		{
			get
			{
				if(r_op_Equality_Quaternion_Quaternion == null)
				{
					r_op_Equality_Quaternion_Quaternion = new(typeof(UnityEngine.Quaternion), "op_Equality", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion));
					r_op_Equality_Quaternion_Quaternion.SetBelong(null);
				}
				return r_op_Equality_Quaternion_Quaternion;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Quaternion, UnityEngine.Quaternion)
		/// </summary>
		protected static RMethod r_op_Inequality_Quaternion_Quaternion;
		public static RMethod Rop_Inequality_Quaternion_Quaternion
		{
			get
			{
				if(r_op_Inequality_Quaternion_Quaternion == null)
				{
					r_op_Inequality_Quaternion_Quaternion = new(typeof(UnityEngine.Quaternion), "op_Inequality", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion));
					r_op_Inequality_Quaternion_Quaternion.SetBelong(null);
				}
				return r_op_Inequality_Quaternion_Quaternion;
			}
		}

		/// <summary>
		/// Single Dot(UnityEngine.Quaternion, UnityEngine.Quaternion)
		/// </summary>
		protected static RMethod r_Dot_Quaternion_Quaternion;
		public static RMethod RDot_Quaternion_Quaternion
		{
			get
			{
				if(r_Dot_Quaternion_Quaternion == null)
				{
					r_Dot_Quaternion_Quaternion = new(typeof(UnityEngine.Quaternion), "Dot", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion));
					r_Dot_Quaternion_Quaternion.SetBelong(null);
				}
				return r_Dot_Quaternion_Quaternion;
			}
		}

		/// <summary>
		/// Void SetLookRotation(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_SetLookRotation_Vector3;
		public virtual RMethod RSetLookRotation_Vector3
		{
			get
			{
				if(r_SetLookRotation_Vector3 == null)
				{
					r_SetLookRotation_Vector3 = new(this, "SetLookRotation", 0, typeof(UnityEngine.Vector3));
					r_SetLookRotation_Vector3.SetBelong(this.instance);
				}
				return r_SetLookRotation_Vector3;
			}
		}

		/// <summary>
		/// Void SetLookRotation(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_SetLookRotation_Vector3_Vector3;
		public virtual RMethod RSetLookRotation_Vector3_Vector3
		{
			get
			{
				if(r_SetLookRotation_Vector3_Vector3 == null)
				{
					r_SetLookRotation_Vector3_Vector3 = new(this, "SetLookRotation", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_SetLookRotation_Vector3_Vector3.SetBelong(this.instance);
				}
				return r_SetLookRotation_Vector3_Vector3;
			}
		}

		/// <summary>
		/// Single Angle(UnityEngine.Quaternion, UnityEngine.Quaternion)
		/// </summary>
		protected static RMethod r_Angle_Quaternion_Quaternion;
		public static RMethod RAngle_Quaternion_Quaternion
		{
			get
			{
				if(r_Angle_Quaternion_Quaternion == null)
				{
					r_Angle_Quaternion_Quaternion = new(typeof(UnityEngine.Quaternion), "Angle", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion));
					r_Angle_Quaternion_Quaternion.SetBelong(null);
				}
				return r_Angle_Quaternion_Quaternion;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 Internal_MakePositive(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_Internal_MakePositive_Vector3;
		public static RMethod RInternal_MakePositive_Vector3
		{
			get
			{
				if(r_Internal_MakePositive_Vector3 == null)
				{
					r_Internal_MakePositive_Vector3 = new(typeof(UnityEngine.Quaternion), "Internal_MakePositive", 0, typeof(UnityEngine.Vector3));
					r_Internal_MakePositive_Vector3.SetBelong(null);
				}
				return r_Internal_MakePositive_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion Euler(Single, Single, Single)
		/// </summary>
		protected static RMethod r_Euler_Single_Single_Single;
		public static RMethod REuler_Single_Single_Single
		{
			get
			{
				if(r_Euler_Single_Single_Single == null)
				{
					r_Euler_Single_Single_Single = new(typeof(UnityEngine.Quaternion), "Euler", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_Euler_Single_Single_Single.SetBelong(null);
				}
				return r_Euler_Single_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion Euler(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_Euler_Vector3;
		public static RMethod REuler_Vector3
		{
			get
			{
				if(r_Euler_Vector3 == null)
				{
					r_Euler_Vector3 = new(typeof(UnityEngine.Quaternion), "Euler", 0, typeof(UnityEngine.Vector3));
					r_Euler_Vector3.SetBelong(null);
				}
				return r_Euler_Vector3;
			}
		}

		/// <summary>
		/// Void ToAngleAxis(Single ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_ToAngleAxis_Out_Single_Out_Vector3;
		public virtual RMethod RToAngleAxis_Out_Single_Out_Vector3
		{
			get
			{
				if(r_ToAngleAxis_Out_Single_Out_Vector3 == null)
				{
					r_ToAngleAxis_Out_Single_Out_Vector3 = new(this, "ToAngleAxis", 0, typeof(System.Single).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
					r_ToAngleAxis_Out_Single_Out_Vector3.SetBelong(this.instance);
				}
				return r_ToAngleAxis_Out_Single_Out_Vector3;
			}
		}

		/// <summary>
		/// Void SetFromToRotation(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_SetFromToRotation_Vector3_Vector3;
		public virtual RMethod RSetFromToRotation_Vector3_Vector3
		{
			get
			{
				if(r_SetFromToRotation_Vector3_Vector3 == null)
				{
					r_SetFromToRotation_Vector3_Vector3 = new(this, "SetFromToRotation", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_SetFromToRotation_Vector3_Vector3.SetBelong(this.instance);
				}
				return r_SetFromToRotation_Vector3_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion RotateTowards(UnityEngine.Quaternion, UnityEngine.Quaternion, Single)
		/// </summary>
		protected static RMethod r_RotateTowards_Quaternion_Quaternion_Single;
		public static RMethod RRotateTowards_Quaternion_Quaternion_Single
		{
			get
			{
				if(r_RotateTowards_Quaternion_Quaternion_Single == null)
				{
					r_RotateTowards_Quaternion_Quaternion_Single = new(typeof(UnityEngine.Quaternion), "RotateTowards", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion), typeof(System.Single));
					r_RotateTowards_Quaternion_Quaternion_Single.SetBelong(null);
				}
				return r_RotateTowards_Quaternion_Quaternion_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion Normalize(UnityEngine.Quaternion)
		/// </summary>
		protected static RMethod r_Normalize_Quaternion;
		public static RMethod RNormalize_Quaternion
		{
			get
			{
				if(r_Normalize_Quaternion == null)
				{
					r_Normalize_Quaternion = new(typeof(UnityEngine.Quaternion), "Normalize", 0, typeof(UnityEngine.Quaternion));
					r_Normalize_Quaternion.SetBelong(null);
				}
				return r_Normalize_Quaternion;
			}
		}

		/// <summary>
		/// Void Normalize()
		/// </summary>
		protected RMethod r_Normalize;
		public virtual RMethod RNormalize
		{
			get
			{
				if(r_Normalize == null)
				{
					r_Normalize = new(this, "Normalize", 0);
					r_Normalize.SetBelong(this.instance);
				}
				return r_Normalize;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_GetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_GetHashCode == null)
				{
					r_GetHashCode = new(this, "GetHashCode", 0);
					r_GetHashCode.SetBelong(this.instance);
				}
				return r_GetHashCode;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_Equals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_Equals_Object == null)
				{
					r_Equals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_Equals_Object.SetBelong(this.instance);
				}
				return r_Equals_Object;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.Quaternion)
		/// </summary>
		protected RMethod r_Equals_Quaternion;
		public virtual RMethod REquals_Quaternion
		{
			get
			{
				if(r_Equals_Quaternion == null)
				{
					r_Equals_Quaternion = new(this, "Equals", 0, typeof(UnityEngine.Quaternion));
					r_Equals_Quaternion.SetBelong(this.instance);
				}
				return r_Equals_Quaternion;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_ToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_ToString == null)
				{
					r_ToString = new(this, "ToString", 0);
					r_ToString.SetBelong(this.instance);
				}
				return r_ToString;
			}
		}

		/// <summary>
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_ToString_String;
		public virtual RMethod RToString_String
		{
			get
			{
				if(r_ToString_String == null)
				{
					r_ToString_String = new(this, "ToString", 0, typeof(System.String));
					r_ToString_String.SetBelong(this.instance);
				}
				return r_ToString_String;
			}
		}

		/// <summary>
		/// System.String ToString(System.String, System.IFormatProvider)
		/// </summary>
		protected RMethod r_ToString_String_IFormatProvider;
		public virtual RMethod RToString_String_IFormatProvider
		{
			get
			{
				if(r_ToString_String_IFormatProvider == null)
				{
					r_ToString_String_IFormatProvider = new(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
					r_ToString_String_IFormatProvider.SetBelong(this.instance);
				}
				return r_ToString_String_IFormatProvider;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion EulerRotation(Single, Single, Single)
		/// </summary>
		protected static RMethod r_EulerRotation_Single_Single_Single;
		public static RMethod REulerRotation_Single_Single_Single
		{
			get
			{
				if(r_EulerRotation_Single_Single_Single == null)
				{
					r_EulerRotation_Single_Single_Single = new(typeof(UnityEngine.Quaternion), "EulerRotation", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_EulerRotation_Single_Single_Single.SetBelong(null);
				}
				return r_EulerRotation_Single_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion EulerRotation(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_EulerRotation_Vector3;
		public static RMethod REulerRotation_Vector3
		{
			get
			{
				if(r_EulerRotation_Vector3 == null)
				{
					r_EulerRotation_Vector3 = new(typeof(UnityEngine.Quaternion), "EulerRotation", 0, typeof(UnityEngine.Vector3));
					r_EulerRotation_Vector3.SetBelong(null);
				}
				return r_EulerRotation_Vector3;
			}
		}

		/// <summary>
		/// Void SetEulerRotation(Single, Single, Single)
		/// </summary>
		protected RMethod r_SetEulerRotation_Single_Single_Single;
		public virtual RMethod RSetEulerRotation_Single_Single_Single
		{
			get
			{
				if(r_SetEulerRotation_Single_Single_Single == null)
				{
					r_SetEulerRotation_Single_Single_Single = new(this, "SetEulerRotation", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_SetEulerRotation_Single_Single_Single.SetBelong(this.instance);
				}
				return r_SetEulerRotation_Single_Single_Single;
			}
		}

		/// <summary>
		/// Void SetEulerRotation(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_SetEulerRotation_Vector3;
		public virtual RMethod RSetEulerRotation_Vector3
		{
			get
			{
				if(r_SetEulerRotation_Vector3 == null)
				{
					r_SetEulerRotation_Vector3 = new(this, "SetEulerRotation", 0, typeof(UnityEngine.Vector3));
					r_SetEulerRotation_Vector3.SetBelong(this.instance);
				}
				return r_SetEulerRotation_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ToEuler()
		/// </summary>
		protected RMethod r_ToEuler;
		public virtual RMethod RToEuler
		{
			get
			{
				if(r_ToEuler == null)
				{
					r_ToEuler = new(this, "ToEuler", 0);
					r_ToEuler.SetBelong(this.instance);
				}
				return r_ToEuler;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion EulerAngles(Single, Single, Single)
		/// </summary>
		protected static RMethod r_EulerAngles_Single_Single_Single;
		public static RMethod REulerAngles_Single_Single_Single
		{
			get
			{
				if(r_EulerAngles_Single_Single_Single == null)
				{
					r_EulerAngles_Single_Single_Single = new(typeof(UnityEngine.Quaternion), "EulerAngles", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_EulerAngles_Single_Single_Single.SetBelong(null);
				}
				return r_EulerAngles_Single_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion EulerAngles(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_EulerAngles_Vector3;
		public static RMethod REulerAngles_Vector3
		{
			get
			{
				if(r_EulerAngles_Vector3 == null)
				{
					r_EulerAngles_Vector3 = new(typeof(UnityEngine.Quaternion), "EulerAngles", 0, typeof(UnityEngine.Vector3));
					r_EulerAngles_Vector3.SetBelong(null);
				}
				return r_EulerAngles_Vector3;
			}
		}

		/// <summary>
		/// Void ToAxisAngle(UnityEngine.Vector3 ByRef, Single ByRef)
		/// </summary>
		protected RMethod r_ToAxisAngle_Out_Vector3_Out_Single;
		public virtual RMethod RToAxisAngle_Out_Vector3_Out_Single
		{
			get
			{
				if(r_ToAxisAngle_Out_Vector3_Out_Single == null)
				{
					r_ToAxisAngle_Out_Vector3_Out_Single = new(this, "ToAxisAngle", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single).MakeByRefType());
					r_ToAxisAngle_Out_Vector3_Out_Single.SetBelong(this.instance);
				}
				return r_ToAxisAngle_Out_Vector3_Out_Single;
			}
		}

		/// <summary>
		/// Void SetEulerAngles(Single, Single, Single)
		/// </summary>
		protected RMethod r_SetEulerAngles_Single_Single_Single;
		public virtual RMethod RSetEulerAngles_Single_Single_Single
		{
			get
			{
				if(r_SetEulerAngles_Single_Single_Single == null)
				{
					r_SetEulerAngles_Single_Single_Single = new(this, "SetEulerAngles", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_SetEulerAngles_Single_Single_Single.SetBelong(this.instance);
				}
				return r_SetEulerAngles_Single_Single_Single;
			}
		}

		/// <summary>
		/// Void SetEulerAngles(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_SetEulerAngles_Vector3;
		public virtual RMethod RSetEulerAngles_Vector3
		{
			get
			{
				if(r_SetEulerAngles_Vector3 == null)
				{
					r_SetEulerAngles_Vector3 = new(this, "SetEulerAngles", 0, typeof(UnityEngine.Vector3));
					r_SetEulerAngles_Vector3.SetBelong(this.instance);
				}
				return r_SetEulerAngles_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ToEulerAngles(UnityEngine.Quaternion)
		/// </summary>
		protected static RMethod r_ToEulerAngles_Quaternion;
		public static RMethod RToEulerAngles_Quaternion
		{
			get
			{
				if(r_ToEulerAngles_Quaternion == null)
				{
					r_ToEulerAngles_Quaternion = new(typeof(UnityEngine.Quaternion), "ToEulerAngles", 0, typeof(UnityEngine.Quaternion));
					r_ToEulerAngles_Quaternion.SetBelong(null);
				}
				return r_ToEulerAngles_Quaternion;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ToEulerAngles()
		/// </summary>
		protected RMethod r_ToEulerAngles;
		public virtual RMethod RToEulerAngles
		{
			get
			{
				if(r_ToEulerAngles == null)
				{
					r_ToEulerAngles = new(this, "ToEulerAngles", 0);
					r_ToEulerAngles.SetBelong(this.instance);
				}
				return r_ToEulerAngles;
			}
		}

		/// <summary>
		/// Void SetAxisAngle(UnityEngine.Vector3, Single)
		/// </summary>
		protected RMethod r_SetAxisAngle_Vector3_Single;
		public virtual RMethod RSetAxisAngle_Vector3_Single
		{
			get
			{
				if(r_SetAxisAngle_Vector3_Single == null)
				{
					r_SetAxisAngle_Vector3_Single = new(this, "SetAxisAngle", 0, typeof(UnityEngine.Vector3), typeof(System.Single));
					r_SetAxisAngle_Vector3_Single.SetBelong(this.instance);
				}
				return r_SetAxisAngle_Vector3_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion AxisAngle(UnityEngine.Vector3, Single)
		/// </summary>
		protected static RMethod r_AxisAngle_Vector3_Single;
		public static RMethod RAxisAngle_Vector3_Single
		{
			get
			{
				if(r_AxisAngle_Vector3_Single == null)
				{
					r_AxisAngle_Vector3_Single = new(typeof(UnityEngine.Quaternion), "AxisAngle", 0, typeof(UnityEngine.Vector3), typeof(System.Single));
					r_AxisAngle_Vector3_Single.SetBelong(null);
				}
				return r_AxisAngle_Vector3_Single;
			}
		}

		/// <summary>
		/// Void FromToRotation_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef, UnityEngine.Quaternion ByRef)
		/// </summary>
		protected static RMethod r_FromToRotation_Injected_Ref_Vector3_Ref_Vector3_Out_Quaternion;
		public static RMethod RFromToRotation_Injected_Ref_Vector3_Ref_Vector3_Out_Quaternion
		{
			get
			{
				if(r_FromToRotation_Injected_Ref_Vector3_Ref_Vector3_Out_Quaternion == null)
				{
					r_FromToRotation_Injected_Ref_Vector3_Ref_Vector3_Out_Quaternion = new(typeof(UnityEngine.Quaternion), "FromToRotation_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType());
					r_FromToRotation_Injected_Ref_Vector3_Ref_Vector3_Out_Quaternion.SetBelong(null);
				}
				return r_FromToRotation_Injected_Ref_Vector3_Ref_Vector3_Out_Quaternion;
			}
		}

		/// <summary>
		/// Void Inverse_Injected(UnityEngine.Quaternion ByRef, UnityEngine.Quaternion ByRef)
		/// </summary>
		protected static RMethod r_Inverse_Injected_Ref_Quaternion_Out_Quaternion;
		public static RMethod RInverse_Injected_Ref_Quaternion_Out_Quaternion
		{
			get
			{
				if(r_Inverse_Injected_Ref_Quaternion_Out_Quaternion == null)
				{
					r_Inverse_Injected_Ref_Quaternion_Out_Quaternion = new(typeof(UnityEngine.Quaternion), "Inverse_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType());
					r_Inverse_Injected_Ref_Quaternion_Out_Quaternion.SetBelong(null);
				}
				return r_Inverse_Injected_Ref_Quaternion_Out_Quaternion;
			}
		}

		/// <summary>
		/// Void Slerp_Injected(UnityEngine.Quaternion ByRef, UnityEngine.Quaternion ByRef, Single, UnityEngine.Quaternion ByRef)
		/// </summary>
		protected static RMethod r_Slerp_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion;
		public static RMethod RSlerp_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion
		{
			get
			{
				if(r_Slerp_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion == null)
				{
					r_Slerp_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion = new(typeof(UnityEngine.Quaternion), "Slerp_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(System.Single), typeof(UnityEngine.Quaternion).MakeByRefType());
					r_Slerp_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion.SetBelong(null);
				}
				return r_Slerp_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion;
			}
		}

		/// <summary>
		/// Void SlerpUnclamped_Injected(UnityEngine.Quaternion ByRef, UnityEngine.Quaternion ByRef, Single, UnityEngine.Quaternion ByRef)
		/// </summary>
		protected static RMethod r_SlerpUnclamped_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion;
		public static RMethod RSlerpUnclamped_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion
		{
			get
			{
				if(r_SlerpUnclamped_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion == null)
				{
					r_SlerpUnclamped_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion = new(typeof(UnityEngine.Quaternion), "SlerpUnclamped_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(System.Single), typeof(UnityEngine.Quaternion).MakeByRefType());
					r_SlerpUnclamped_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion.SetBelong(null);
				}
				return r_SlerpUnclamped_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion;
			}
		}

		/// <summary>
		/// Void Lerp_Injected(UnityEngine.Quaternion ByRef, UnityEngine.Quaternion ByRef, Single, UnityEngine.Quaternion ByRef)
		/// </summary>
		protected static RMethod r_Lerp_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion;
		public static RMethod RLerp_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion
		{
			get
			{
				if(r_Lerp_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion == null)
				{
					r_Lerp_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion = new(typeof(UnityEngine.Quaternion), "Lerp_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(System.Single), typeof(UnityEngine.Quaternion).MakeByRefType());
					r_Lerp_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion.SetBelong(null);
				}
				return r_Lerp_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion;
			}
		}

		/// <summary>
		/// Void LerpUnclamped_Injected(UnityEngine.Quaternion ByRef, UnityEngine.Quaternion ByRef, Single, UnityEngine.Quaternion ByRef)
		/// </summary>
		protected static RMethod r_LerpUnclamped_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion;
		public static RMethod RLerpUnclamped_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion
		{
			get
			{
				if(r_LerpUnclamped_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion == null)
				{
					r_LerpUnclamped_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion = new(typeof(UnityEngine.Quaternion), "LerpUnclamped_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(System.Single), typeof(UnityEngine.Quaternion).MakeByRefType());
					r_LerpUnclamped_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion.SetBelong(null);
				}
				return r_LerpUnclamped_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion;
			}
		}

		/// <summary>
		/// Void Internal_FromEulerRad_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Quaternion ByRef)
		/// </summary>
		protected static RMethod r_Internal_FromEulerRad_Injected_Ref_Vector3_Out_Quaternion;
		public static RMethod RInternal_FromEulerRad_Injected_Ref_Vector3_Out_Quaternion
		{
			get
			{
				if(r_Internal_FromEulerRad_Injected_Ref_Vector3_Out_Quaternion == null)
				{
					r_Internal_FromEulerRad_Injected_Ref_Vector3_Out_Quaternion = new(typeof(UnityEngine.Quaternion), "Internal_FromEulerRad_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType());
					r_Internal_FromEulerRad_Injected_Ref_Vector3_Out_Quaternion.SetBelong(null);
				}
				return r_Internal_FromEulerRad_Injected_Ref_Vector3_Out_Quaternion;
			}
		}

		/// <summary>
		/// Void Internal_ToEulerRad_Injected(UnityEngine.Quaternion ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected static RMethod r_Internal_ToEulerRad_Injected_Ref_Quaternion_Out_Vector3;
		public static RMethod RInternal_ToEulerRad_Injected_Ref_Quaternion_Out_Vector3
		{
			get
			{
				if(r_Internal_ToEulerRad_Injected_Ref_Quaternion_Out_Vector3 == null)
				{
					r_Internal_ToEulerRad_Injected_Ref_Quaternion_Out_Vector3 = new(typeof(UnityEngine.Quaternion), "Internal_ToEulerRad_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
					r_Internal_ToEulerRad_Injected_Ref_Quaternion_Out_Vector3.SetBelong(null);
				}
				return r_Internal_ToEulerRad_Injected_Ref_Quaternion_Out_Vector3;
			}
		}

		/// <summary>
		/// Void Internal_ToAxisAngleRad_Injected(UnityEngine.Quaternion ByRef, UnityEngine.Vector3 ByRef, Single ByRef)
		/// </summary>
		protected static RMethod r_Internal_ToAxisAngleRad_Injected_Ref_Quaternion_Out_Vector3_Out_Single;
		public static RMethod RInternal_ToAxisAngleRad_Injected_Ref_Quaternion_Out_Vector3_Out_Single
		{
			get
			{
				if(r_Internal_ToAxisAngleRad_Injected_Ref_Quaternion_Out_Vector3_Out_Single == null)
				{
					r_Internal_ToAxisAngleRad_Injected_Ref_Quaternion_Out_Vector3_Out_Single = new(typeof(UnityEngine.Quaternion), "Internal_ToAxisAngleRad_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single).MakeByRefType());
					r_Internal_ToAxisAngleRad_Injected_Ref_Quaternion_Out_Vector3_Out_Single.SetBelong(null);
				}
				return r_Internal_ToAxisAngleRad_Injected_Ref_Quaternion_Out_Vector3_Out_Single;
			}
		}

		/// <summary>
		/// Void AngleAxis_Injected(Single, UnityEngine.Vector3 ByRef, UnityEngine.Quaternion ByRef)
		/// </summary>
		protected static RMethod r_AngleAxis_Injected_Single_Ref_Vector3_Out_Quaternion;
		public static RMethod RAngleAxis_Injected_Single_Ref_Vector3_Out_Quaternion
		{
			get
			{
				if(r_AngleAxis_Injected_Single_Ref_Vector3_Out_Quaternion == null)
				{
					r_AngleAxis_Injected_Single_Ref_Vector3_Out_Quaternion = new(typeof(UnityEngine.Quaternion), "AngleAxis_Injected", 0, typeof(System.Single), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType());
					r_AngleAxis_Injected_Single_Ref_Vector3_Out_Quaternion.SetBelong(null);
				}
				return r_AngleAxis_Injected_Single_Ref_Vector3_Out_Quaternion;
			}
		}

		/// <summary>
		/// Void LookRotation_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef, UnityEngine.Quaternion ByRef)
		/// </summary>
		protected static RMethod r_LookRotation_Injected_Ref_Vector3_Ref_Vector3_Out_Quaternion;
		public static RMethod RLookRotation_Injected_Ref_Vector3_Ref_Vector3_Out_Quaternion
		{
			get
			{
				if(r_LookRotation_Injected_Ref_Vector3_Ref_Vector3_Out_Quaternion == null)
				{
					r_LookRotation_Injected_Ref_Vector3_Ref_Vector3_Out_Quaternion = new(typeof(UnityEngine.Quaternion), "LookRotation_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType());
					r_LookRotation_Injected_Ref_Vector3_Ref_Vector3_Out_Quaternion.SetBelong(null);
				}
				return r_LookRotation_Injected_Ref_Vector3_Ref_Vector3_Out_Quaternion;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_Finalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_Finalize == null)
				{
					r_Finalize = new(this, "Finalize", 0);
					r_Finalize.SetBelong(this.instance);
				}
				return r_Finalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_GetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_GetType == null)
				{
					r_GetType = new(this, "GetType", 0);
					r_GetType.SetBelong(this.instance);
				}
				return r_GetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_MemberwiseClone == null)
				{
					r_MemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MemberwiseClone.SetBelong(this.instance);
				}
				return r_MemberwiseClone;
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

        public static UnityEngine.Quaternion FromToRotation(UnityEngine.Vector3 @fromDirection, UnityEngine.Vector3 @toDirection)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromDirection, @toDirection};
            var ___result = RFromToRotation_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static UnityEngine.Quaternion Inverse(UnityEngine.Quaternion @rotation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rotation};
            var ___result = RInverse_Quaternion.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static UnityEngine.Quaternion Slerp(UnityEngine.Quaternion @a, UnityEngine.Quaternion @b, System.Single @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RSlerp_Quaternion_Quaternion_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static UnityEngine.Quaternion SlerpUnclamped(UnityEngine.Quaternion @a, UnityEngine.Quaternion @b, System.Single @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RSlerpUnclamped_Quaternion_Quaternion_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static UnityEngine.Quaternion Lerp(UnityEngine.Quaternion @a, UnityEngine.Quaternion @b, System.Single @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RLerp_Quaternion_Quaternion_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static UnityEngine.Quaternion LerpUnclamped(UnityEngine.Quaternion @a, UnityEngine.Quaternion @b, System.Single @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RLerpUnclamped_Quaternion_Quaternion_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static UnityEngine.Quaternion Internal_FromEulerRad(UnityEngine.Vector3 @euler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@euler};
            var ___result = RInternal_FromEulerRad_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static UnityEngine.Vector3 Internal_ToEulerRad(UnityEngine.Quaternion @rotation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rotation};
            var ___result = RInternal_ToEulerRad_Quaternion.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static void Internal_ToAxisAngleRad(UnityEngine.Quaternion @q, out UnityEngine.Vector3 @axis, out System.Single @angle)
        {
			@axis = default;
			@angle = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@q, @axis, @angle};
            var ___result = RInternal_ToAxisAngleRad_Quaternion_Out_Vector3_Out_Single.Invoke(___genericsType, ___parameters);
			@axis = (UnityEngine.Vector3)___parameters[1];
			@angle = (System.Single)___parameters[2];

            
        }


        public static UnityEngine.Quaternion AngleAxis(System.Single @angle, UnityEngine.Vector3 @axis)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@angle, @axis};
            var ___result = RAngleAxis_Single_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static UnityEngine.Quaternion LookRotation(UnityEngine.Vector3 @forward, UnityEngine.Vector3 @upwards)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@forward, @upwards};
            var ___result = RLookRotation_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static UnityEngine.Quaternion LookRotation(UnityEngine.Vector3 @forward)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@forward};
            var ___result = RLookRotation_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public virtual void Set(System.Single @newX, System.Single @newY, System.Single @newZ, System.Single @newW)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newX, @newY, @newZ, @newW};
            var ___result = RSet_Single_Single_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Quaternion op_Multiply(UnityEngine.Quaternion @lhs, UnityEngine.Quaternion @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Multiply_Quaternion_Quaternion.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static UnityEngine.Vector3 op_Multiply(UnityEngine.Quaternion @rotation, UnityEngine.Vector3 @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rotation, @point};
            var ___result = Rop_Multiply_Quaternion_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static System.Boolean IsEqualUsingDot(System.Single @dot)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dot};
            var ___result = RIsEqualUsingDot_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Quaternion @lhs, UnityEngine.Quaternion @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_Quaternion_Quaternion.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Quaternion @lhs, UnityEngine.Quaternion @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_Quaternion_Quaternion.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Single Dot(UnityEngine.Quaternion @a, UnityEngine.Quaternion @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RDot_Quaternion_Quaternion.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual void SetLookRotation(UnityEngine.Vector3 @view)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@view};
            var ___result = RSetLookRotation_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetLookRotation(UnityEngine.Vector3 @view, UnityEngine.Vector3 @up)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@view, @up};
            var ___result = RSetLookRotation_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Single Angle(UnityEngine.Quaternion @a, UnityEngine.Quaternion @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RAngle_Quaternion_Quaternion.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static UnityEngine.Vector3 Internal_MakePositive(UnityEngine.Vector3 @euler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@euler};
            var ___result = RInternal_MakePositive_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Quaternion Euler(System.Single @x, System.Single @y, System.Single @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = REuler_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static UnityEngine.Quaternion Euler(UnityEngine.Vector3 @euler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@euler};
            var ___result = REuler_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public virtual void ToAngleAxis(out System.Single @angle, out UnityEngine.Vector3 @axis)
        {
			@angle = default;
			@axis = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@angle, @axis};
            var ___result = RToAngleAxis_Out_Single_Out_Vector3.Invoke(___genericsType, ___parameters);
			@angle = (System.Single)___parameters[0];
			@axis = (UnityEngine.Vector3)___parameters[1];

            
        }


        public virtual void SetFromToRotation(UnityEngine.Vector3 @fromDirection, UnityEngine.Vector3 @toDirection)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromDirection, @toDirection};
            var ___result = RSetFromToRotation_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Quaternion RotateTowards(UnityEngine.Quaternion @from, UnityEngine.Quaternion @to, System.Single @maxDegreesDelta)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @maxDegreesDelta};
            var ___result = RRotateTowards_Quaternion_Quaternion_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static UnityEngine.Quaternion Normalize(UnityEngine.Quaternion @q)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@q};
            var ___result = RNormalize_Quaternion.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public virtual void Normalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RNormalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.Quaternion @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Quaternion.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String @format, System.IFormatProvider @formatProvider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @formatProvider};
            var ___result = RToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static UnityEngine.Quaternion EulerRotation(System.Single @x, System.Single @y, System.Single @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = REulerRotation_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static UnityEngine.Quaternion EulerRotation(UnityEngine.Vector3 @euler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@euler};
            var ___result = REulerRotation_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public virtual void SetEulerRotation(System.Single @x, System.Single @y, System.Single @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = RSetEulerRotation_Single_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetEulerRotation(UnityEngine.Vector3 @euler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@euler};
            var ___result = RSetEulerRotation_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector3 ToEuler()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToEuler.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Quaternion EulerAngles(System.Single @x, System.Single @y, System.Single @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = REulerAngles_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static UnityEngine.Quaternion EulerAngles(UnityEngine.Vector3 @euler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@euler};
            var ___result = REulerAngles_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public virtual void ToAxisAngle(out UnityEngine.Vector3 @axis, out System.Single @angle)
        {
			@axis = default;
			@angle = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@axis, @angle};
            var ___result = RToAxisAngle_Out_Vector3_Out_Single.Invoke(___genericsType, ___parameters);
			@axis = (UnityEngine.Vector3)___parameters[0];
			@angle = (System.Single)___parameters[1];

            
        }


        public virtual void SetEulerAngles(System.Single @x, System.Single @y, System.Single @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = RSetEulerAngles_Single_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetEulerAngles(UnityEngine.Vector3 @euler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@euler};
            var ___result = RSetEulerAngles_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Vector3 ToEulerAngles(UnityEngine.Quaternion @rotation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rotation};
            var ___result = RToEulerAngles_Quaternion.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual UnityEngine.Vector3 ToEulerAngles()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToEulerAngles.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual void SetAxisAngle(UnityEngine.Vector3 @axis, System.Single @angle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@axis, @angle};
            var ___result = RSetAxisAngle_Vector3_Single.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Quaternion AxisAngle(UnityEngine.Vector3 @axis, System.Single @angle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@axis, @angle};
            var ___result = RAxisAngle_Vector3_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public static void FromToRotation_Injected(ref UnityEngine.Vector3 @fromDirection, ref UnityEngine.Vector3 @toDirection, out UnityEngine.Quaternion @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromDirection, @toDirection, @ret};
            var ___result = RFromToRotation_Injected_Ref_Vector3_Ref_Vector3_Out_Quaternion.Invoke(___genericsType, ___parameters);
			@fromDirection = (UnityEngine.Vector3)___parameters[0];
			@toDirection = (UnityEngine.Vector3)___parameters[1];
			@ret = (UnityEngine.Quaternion)___parameters[2];

            
        }


        public static void Inverse_Injected(ref UnityEngine.Quaternion @rotation, out UnityEngine.Quaternion @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rotation, @ret};
            var ___result = RInverse_Injected_Ref_Quaternion_Out_Quaternion.Invoke(___genericsType, ___parameters);
			@rotation = (UnityEngine.Quaternion)___parameters[0];
			@ret = (UnityEngine.Quaternion)___parameters[1];

            
        }


        public static void Slerp_Injected(ref UnityEngine.Quaternion @a, ref UnityEngine.Quaternion @b, System.Single @t, out UnityEngine.Quaternion @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t, @ret};
            var ___result = RSlerp_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion.Invoke(___genericsType, ___parameters);
			@a = (UnityEngine.Quaternion)___parameters[0];
			@b = (UnityEngine.Quaternion)___parameters[1];
			@ret = (UnityEngine.Quaternion)___parameters[3];

            
        }


        public static void SlerpUnclamped_Injected(ref UnityEngine.Quaternion @a, ref UnityEngine.Quaternion @b, System.Single @t, out UnityEngine.Quaternion @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t, @ret};
            var ___result = RSlerpUnclamped_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion.Invoke(___genericsType, ___parameters);
			@a = (UnityEngine.Quaternion)___parameters[0];
			@b = (UnityEngine.Quaternion)___parameters[1];
			@ret = (UnityEngine.Quaternion)___parameters[3];

            
        }


        public static void Lerp_Injected(ref UnityEngine.Quaternion @a, ref UnityEngine.Quaternion @b, System.Single @t, out UnityEngine.Quaternion @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t, @ret};
            var ___result = RLerp_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion.Invoke(___genericsType, ___parameters);
			@a = (UnityEngine.Quaternion)___parameters[0];
			@b = (UnityEngine.Quaternion)___parameters[1];
			@ret = (UnityEngine.Quaternion)___parameters[3];

            
        }


        public static void LerpUnclamped_Injected(ref UnityEngine.Quaternion @a, ref UnityEngine.Quaternion @b, System.Single @t, out UnityEngine.Quaternion @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t, @ret};
            var ___result = RLerpUnclamped_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion.Invoke(___genericsType, ___parameters);
			@a = (UnityEngine.Quaternion)___parameters[0];
			@b = (UnityEngine.Quaternion)___parameters[1];
			@ret = (UnityEngine.Quaternion)___parameters[3];

            
        }


        public static void Internal_FromEulerRad_Injected(ref UnityEngine.Vector3 @euler, out UnityEngine.Quaternion @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@euler, @ret};
            var ___result = RInternal_FromEulerRad_Injected_Ref_Vector3_Out_Quaternion.Invoke(___genericsType, ___parameters);
			@euler = (UnityEngine.Vector3)___parameters[0];
			@ret = (UnityEngine.Quaternion)___parameters[1];

            
        }


        public static void Internal_ToEulerRad_Injected(ref UnityEngine.Quaternion @rotation, out UnityEngine.Vector3 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rotation, @ret};
            var ___result = RInternal_ToEulerRad_Injected_Ref_Quaternion_Out_Vector3.Invoke(___genericsType, ___parameters);
			@rotation = (UnityEngine.Quaternion)___parameters[0];
			@ret = (UnityEngine.Vector3)___parameters[1];

            
        }


        public static void Internal_ToAxisAngleRad_Injected(ref UnityEngine.Quaternion @q, out UnityEngine.Vector3 @axis, out System.Single @angle)
        {
			@axis = default;
			@angle = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@q, @axis, @angle};
            var ___result = RInternal_ToAxisAngleRad_Injected_Ref_Quaternion_Out_Vector3_Out_Single.Invoke(___genericsType, ___parameters);
			@q = (UnityEngine.Quaternion)___parameters[0];
			@axis = (UnityEngine.Vector3)___parameters[1];
			@angle = (System.Single)___parameters[2];

            
        }


        public static void AngleAxis_Injected(System.Single @angle, ref UnityEngine.Vector3 @axis, out UnityEngine.Quaternion @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@angle, @axis, @ret};
            var ___result = RAngleAxis_Injected_Single_Ref_Vector3_Out_Quaternion.Invoke(___genericsType, ___parameters);
			@axis = (UnityEngine.Vector3)___parameters[1];
			@ret = (UnityEngine.Quaternion)___parameters[2];

            
        }


        public static void LookRotation_Injected(ref UnityEngine.Vector3 @forward, ref UnityEngine.Vector3 @upwards, out UnityEngine.Quaternion @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@forward, @upwards, @ret};
            var ___result = RLookRotation_Injected_Ref_Vector3_Ref_Vector3_Out_Quaternion.Invoke(___genericsType, ___parameters);
			@forward = (UnityEngine.Vector3)___parameters[0];
			@upwards = (UnityEngine.Vector3)___parameters[1];
			@ret = (UnityEngine.Quaternion)___parameters[2];

            
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
