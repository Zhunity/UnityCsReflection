using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Matrix4x4
	/// </summary>
    public partial class RMatrix4x4 : RMember //
    {

		/// <summary>
		/// System.Single m00
		/// </summary>
		protected RField r_m00;
		public virtual RField Rm00
		{
			get
			{
				if(r_m00 == null)
				{
					r_m00 = new(this, "m00");
					r_m00.SetBelong(this.instance);
				}
				return r_m00;
			}
		}

		/// <summary>
		/// System.Single m10
		/// </summary>
		protected RField r_m10;
		public virtual RField Rm10
		{
			get
			{
				if(r_m10 == null)
				{
					r_m10 = new(this, "m10");
					r_m10.SetBelong(this.instance);
				}
				return r_m10;
			}
		}

		/// <summary>
		/// System.Single m20
		/// </summary>
		protected RField r_m20;
		public virtual RField Rm20
		{
			get
			{
				if(r_m20 == null)
				{
					r_m20 = new(this, "m20");
					r_m20.SetBelong(this.instance);
				}
				return r_m20;
			}
		}

		/// <summary>
		/// System.Single m30
		/// </summary>
		protected RField r_m30;
		public virtual RField Rm30
		{
			get
			{
				if(r_m30 == null)
				{
					r_m30 = new(this, "m30");
					r_m30.SetBelong(this.instance);
				}
				return r_m30;
			}
		}

		/// <summary>
		/// System.Single m01
		/// </summary>
		protected RField r_m01;
		public virtual RField Rm01
		{
			get
			{
				if(r_m01 == null)
				{
					r_m01 = new(this, "m01");
					r_m01.SetBelong(this.instance);
				}
				return r_m01;
			}
		}

		/// <summary>
		/// System.Single m11
		/// </summary>
		protected RField r_m11;
		public virtual RField Rm11
		{
			get
			{
				if(r_m11 == null)
				{
					r_m11 = new(this, "m11");
					r_m11.SetBelong(this.instance);
				}
				return r_m11;
			}
		}

		/// <summary>
		/// System.Single m21
		/// </summary>
		protected RField r_m21;
		public virtual RField Rm21
		{
			get
			{
				if(r_m21 == null)
				{
					r_m21 = new(this, "m21");
					r_m21.SetBelong(this.instance);
				}
				return r_m21;
			}
		}

		/// <summary>
		/// System.Single m31
		/// </summary>
		protected RField r_m31;
		public virtual RField Rm31
		{
			get
			{
				if(r_m31 == null)
				{
					r_m31 = new(this, "m31");
					r_m31.SetBelong(this.instance);
				}
				return r_m31;
			}
		}

		/// <summary>
		/// System.Single m02
		/// </summary>
		protected RField r_m02;
		public virtual RField Rm02
		{
			get
			{
				if(r_m02 == null)
				{
					r_m02 = new(this, "m02");
					r_m02.SetBelong(this.instance);
				}
				return r_m02;
			}
		}

		/// <summary>
		/// System.Single m12
		/// </summary>
		protected RField r_m12;
		public virtual RField Rm12
		{
			get
			{
				if(r_m12 == null)
				{
					r_m12 = new(this, "m12");
					r_m12.SetBelong(this.instance);
				}
				return r_m12;
			}
		}

		/// <summary>
		/// System.Single m22
		/// </summary>
		protected RField r_m22;
		public virtual RField Rm22
		{
			get
			{
				if(r_m22 == null)
				{
					r_m22 = new(this, "m22");
					r_m22.SetBelong(this.instance);
				}
				return r_m22;
			}
		}

		/// <summary>
		/// System.Single m32
		/// </summary>
		protected RField r_m32;
		public virtual RField Rm32
		{
			get
			{
				if(r_m32 == null)
				{
					r_m32 = new(this, "m32");
					r_m32.SetBelong(this.instance);
				}
				return r_m32;
			}
		}

		/// <summary>
		/// System.Single m03
		/// </summary>
		protected RField r_m03;
		public virtual RField Rm03
		{
			get
			{
				if(r_m03 == null)
				{
					r_m03 = new(this, "m03");
					r_m03.SetBelong(this.instance);
				}
				return r_m03;
			}
		}

		/// <summary>
		/// System.Single m13
		/// </summary>
		protected RField r_m13;
		public virtual RField Rm13
		{
			get
			{
				if(r_m13 == null)
				{
					r_m13 = new(this, "m13");
					r_m13.SetBelong(this.instance);
				}
				return r_m13;
			}
		}

		/// <summary>
		/// System.Single m23
		/// </summary>
		protected RField r_m23;
		public virtual RField Rm23
		{
			get
			{
				if(r_m23 == null)
				{
					r_m23 = new(this, "m23");
					r_m23.SetBelong(this.instance);
				}
				return r_m23;
			}
		}

		/// <summary>
		/// System.Single m33
		/// </summary>
		protected RField r_m33;
		public virtual RField Rm33
		{
			get
			{
				if(r_m33 == null)
				{
					r_m33 = new(this, "m33");
					r_m33.SetBelong(this.instance);
				}
				return r_m33;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 zeroMatrix
		/// </summary>
		protected static RUnityEngine.RMatrix4x4 r_zeroMatrix;
		public static RUnityEngine.RMatrix4x4 RzeroMatrix
		{
			get
			{
				if(r_zeroMatrix == null)
				{
					r_zeroMatrix = new(typeof(UnityEngine.Matrix4x4), "zeroMatrix");
					r_zeroMatrix.SetBelong(null);
				}
				return r_zeroMatrix;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 identityMatrix
		/// </summary>
		protected static RUnityEngine.RMatrix4x4 r_identityMatrix;
		public static RUnityEngine.RMatrix4x4 RidentityMatrix
		{
			get
			{
				if(r_identityMatrix == null)
				{
					r_identityMatrix = new(typeof(UnityEngine.Matrix4x4), "identityMatrix");
					r_identityMatrix.SetBelong(null);
				}
				return r_identityMatrix;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion rotation
		/// </summary>
		protected RUnityEngine.RQuaternion r_rotation;
		public virtual RUnityEngine.RQuaternion Rrotation
		{
			get
			{
				if(r_rotation == null)
				{
					r_rotation = new(this, "rotation", -1);
					r_rotation.SetBelong(this.instance);
				}
				return r_rotation;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 lossyScale
		/// </summary>
		protected RUnityEngine.RVector3 r_lossyScale;
		public virtual RUnityEngine.RVector3 RlossyScale
		{
			get
			{
				if(r_lossyScale == null)
				{
					r_lossyScale = new(this, "lossyScale", -1);
					r_lossyScale.SetBelong(this.instance);
				}
				return r_lossyScale;
			}
		}

		/// <summary>
		/// Boolean isIdentity
		/// </summary>
		protected RProperty r_isIdentity;
		public virtual RProperty RisIdentity
		{
			get
			{
				if(r_isIdentity == null)
				{
					r_isIdentity = new(this, "isIdentity", -1);
					r_isIdentity.SetBelong(this.instance);
				}
				return r_isIdentity;
			}
		}

		/// <summary>
		/// Single determinant
		/// </summary>
		protected RProperty r_determinant;
		public virtual RProperty Rdeterminant
		{
			get
			{
				if(r_determinant == null)
				{
					r_determinant = new(this, "determinant", -1);
					r_determinant.SetBelong(this.instance);
				}
				return r_determinant;
			}
		}

		/// <summary>
		/// UnityEngine.FrustumPlanes decomposeProjection
		/// </summary>
		protected RUnityEngine.RFrustumPlanes r_decomposeProjection;
		public virtual RUnityEngine.RFrustumPlanes RdecomposeProjection
		{
			get
			{
				if(r_decomposeProjection == null)
				{
					r_decomposeProjection = new(this, "decomposeProjection", -1);
					r_decomposeProjection.SetBelong(this.instance);
				}
				return r_decomposeProjection;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 inverse
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_inverse;
		public virtual RUnityEngine.RMatrix4x4 Rinverse
		{
			get
			{
				if(r_inverse == null)
				{
					r_inverse = new(this, "inverse", -1);
					r_inverse.SetBelong(this.instance);
				}
				return r_inverse;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 transpose
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_transpose;
		public virtual RUnityEngine.RMatrix4x4 Rtranspose
		{
			get
			{
				if(r_transpose == null)
				{
					r_transpose = new(this, "transpose", -1);
					r_transpose.SetBelong(this.instance);
				}
				return r_transpose;
			}
		}

		/// <summary>
		/// Single Item [Int32, Int32]
		/// </summary>
		protected RProperty r_Item_Int32_Int32;
		public virtual RProperty RItem_Int32_Int32
		{
			get
			{
				if(r_Item_Int32_Int32 == null)
				{
					r_Item_Int32_Int32 = new(this, "Item", -1, typeof(System.Int32), typeof(System.Int32));
					r_Item_Int32_Int32.SetBelong(this.instance);
				}
				return r_Item_Int32_Int32;
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
		/// UnityEngine.Matrix4x4 zero
		/// </summary>
		protected static RUnityEngine.RMatrix4x4 r_zero;
		public static RUnityEngine.RMatrix4x4 Rzero
		{
			get
			{
				if(r_zero == null)
				{
					r_zero = new(typeof(UnityEngine.Matrix4x4), "zero", -1);
					r_zero.SetBelong(null);
				}
				return r_zero;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 identity
		/// </summary>
		protected static RUnityEngine.RMatrix4x4 r_identity;
		public static RUnityEngine.RMatrix4x4 Ridentity
		{
			get
			{
				if(r_identity == null)
				{
					r_identity = new(typeof(UnityEngine.Matrix4x4), "identity", -1);
					r_identity.SetBelong(null);
				}
				return r_identity;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion GetRotation()
		/// </summary>
		protected RMethod r_GetRotation;
		public virtual RMethod RGetRotation
		{
			get
			{
				if(r_GetRotation == null)
				{
					r_GetRotation = new(this, "GetRotation", 0);
					r_GetRotation.SetBelong(this.instance);
				}
				return r_GetRotation;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 GetLossyScale()
		/// </summary>
		protected RMethod r_GetLossyScale;
		public virtual RMethod RGetLossyScale
		{
			get
			{
				if(r_GetLossyScale == null)
				{
					r_GetLossyScale = new(this, "GetLossyScale", 0);
					r_GetLossyScale.SetBelong(this.instance);
				}
				return r_GetLossyScale;
			}
		}

		/// <summary>
		/// Boolean IsIdentity()
		/// </summary>
		protected RMethod r_IsIdentity;
		public virtual RMethod RIsIdentity
		{
			get
			{
				if(r_IsIdentity == null)
				{
					r_IsIdentity = new(this, "IsIdentity", 0);
					r_IsIdentity.SetBelong(this.instance);
				}
				return r_IsIdentity;
			}
		}

		/// <summary>
		/// Single GetDeterminant()
		/// </summary>
		protected RMethod r_GetDeterminant;
		public virtual RMethod RGetDeterminant
		{
			get
			{
				if(r_GetDeterminant == null)
				{
					r_GetDeterminant = new(this, "GetDeterminant", 0);
					r_GetDeterminant.SetBelong(this.instance);
				}
				return r_GetDeterminant;
			}
		}

		/// <summary>
		/// UnityEngine.FrustumPlanes DecomposeProjection()
		/// </summary>
		protected RMethod r_DecomposeProjection;
		public virtual RMethod RDecomposeProjection
		{
			get
			{
				if(r_DecomposeProjection == null)
				{
					r_DecomposeProjection = new(this, "DecomposeProjection", 0);
					r_DecomposeProjection.SetBelong(this.instance);
				}
				return r_DecomposeProjection;
			}
		}

		/// <summary>
		/// Boolean ValidTRS()
		/// </summary>
		protected RMethod r_ValidTRS;
		public virtual RMethod RValidTRS
		{
			get
			{
				if(r_ValidTRS == null)
				{
					r_ValidTRS = new(this, "ValidTRS", 0);
					r_ValidTRS.SetBelong(this.instance);
				}
				return r_ValidTRS;
			}
		}

		/// <summary>
		/// Single Determinant(UnityEngine.Matrix4x4)
		/// </summary>
		protected static RMethod r_Determinant_Matrix4x4;
		public static RMethod RDeterminant_Matrix4x4
		{
			get
			{
				if(r_Determinant_Matrix4x4 == null)
				{
					r_Determinant_Matrix4x4 = new(typeof(UnityEngine.Matrix4x4), "Determinant", 0, typeof(UnityEngine.Matrix4x4));
					r_Determinant_Matrix4x4.SetBelong(null);
				}
				return r_Determinant_Matrix4x4;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 TRS(UnityEngine.Vector3, UnityEngine.Quaternion, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_TRS_Vector3_Quaternion_Vector3;
		public static RMethod RTRS_Vector3_Quaternion_Vector3
		{
			get
			{
				if(r_TRS_Vector3_Quaternion_Vector3 == null)
				{
					r_TRS_Vector3_Quaternion_Vector3 = new(typeof(UnityEngine.Matrix4x4), "TRS", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Vector3));
					r_TRS_Vector3_Quaternion_Vector3.SetBelong(null);
				}
				return r_TRS_Vector3_Quaternion_Vector3;
			}
		}

		/// <summary>
		/// Void SetTRS(UnityEngine.Vector3, UnityEngine.Quaternion, UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_SetTRS_Vector3_Quaternion_Vector3;
		public virtual RMethod RSetTRS_Vector3_Quaternion_Vector3
		{
			get
			{
				if(r_SetTRS_Vector3_Quaternion_Vector3 == null)
				{
					r_SetTRS_Vector3_Quaternion_Vector3 = new(this, "SetTRS", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Vector3));
					r_SetTRS_Vector3_Quaternion_Vector3.SetBelong(this.instance);
				}
				return r_SetTRS_Vector3_Quaternion_Vector3;
			}
		}

		/// <summary>
		/// Boolean Inverse3DAffine(UnityEngine.Matrix4x4, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected static RMethod r_Inverse3DAffine_Matrix4x4_Ref_Matrix4x4;
		public static RMethod RInverse3DAffine_Matrix4x4_Ref_Matrix4x4
		{
			get
			{
				if(r_Inverse3DAffine_Matrix4x4_Ref_Matrix4x4 == null)
				{
					r_Inverse3DAffine_Matrix4x4_Ref_Matrix4x4 = new(typeof(UnityEngine.Matrix4x4), "Inverse3DAffine", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_Inverse3DAffine_Matrix4x4_Ref_Matrix4x4.SetBelong(null);
				}
				return r_Inverse3DAffine_Matrix4x4_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 Inverse(UnityEngine.Matrix4x4)
		/// </summary>
		protected static RMethod r_Inverse_Matrix4x4;
		public static RMethod RInverse_Matrix4x4
		{
			get
			{
				if(r_Inverse_Matrix4x4 == null)
				{
					r_Inverse_Matrix4x4 = new(typeof(UnityEngine.Matrix4x4), "Inverse", 0, typeof(UnityEngine.Matrix4x4));
					r_Inverse_Matrix4x4.SetBelong(null);
				}
				return r_Inverse_Matrix4x4;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 Transpose(UnityEngine.Matrix4x4)
		/// </summary>
		protected static RMethod r_Transpose_Matrix4x4;
		public static RMethod RTranspose_Matrix4x4
		{
			get
			{
				if(r_Transpose_Matrix4x4 == null)
				{
					r_Transpose_Matrix4x4 = new(typeof(UnityEngine.Matrix4x4), "Transpose", 0, typeof(UnityEngine.Matrix4x4));
					r_Transpose_Matrix4x4.SetBelong(null);
				}
				return r_Transpose_Matrix4x4;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 Ortho(Single, Single, Single, Single, Single, Single)
		/// </summary>
		protected static RMethod r_Ortho_Single_Single_Single_Single_Single_Single;
		public static RMethod ROrtho_Single_Single_Single_Single_Single_Single
		{
			get
			{
				if(r_Ortho_Single_Single_Single_Single_Single_Single == null)
				{
					r_Ortho_Single_Single_Single_Single_Single_Single = new(typeof(UnityEngine.Matrix4x4), "Ortho", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_Ortho_Single_Single_Single_Single_Single_Single.SetBelong(null);
				}
				return r_Ortho_Single_Single_Single_Single_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 Perspective(Single, Single, Single, Single)
		/// </summary>
		protected static RMethod r_Perspective_Single_Single_Single_Single;
		public static RMethod RPerspective_Single_Single_Single_Single
		{
			get
			{
				if(r_Perspective_Single_Single_Single_Single == null)
				{
					r_Perspective_Single_Single_Single_Single = new(typeof(UnityEngine.Matrix4x4), "Perspective", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_Perspective_Single_Single_Single_Single.SetBelong(null);
				}
				return r_Perspective_Single_Single_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 LookAt(UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_LookAt_Vector3_Vector3_Vector3;
		public static RMethod RLookAt_Vector3_Vector3_Vector3
		{
			get
			{
				if(r_LookAt_Vector3_Vector3_Vector3 == null)
				{
					r_LookAt_Vector3_Vector3_Vector3 = new(typeof(UnityEngine.Matrix4x4), "LookAt", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_LookAt_Vector3_Vector3_Vector3.SetBelong(null);
				}
				return r_LookAt_Vector3_Vector3_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 Frustum(Single, Single, Single, Single, Single, Single)
		/// </summary>
		protected static RMethod r_Frustum_Single_Single_Single_Single_Single_Single;
		public static RMethod RFrustum_Single_Single_Single_Single_Single_Single
		{
			get
			{
				if(r_Frustum_Single_Single_Single_Single_Single_Single == null)
				{
					r_Frustum_Single_Single_Single_Single_Single_Single = new(typeof(UnityEngine.Matrix4x4), "Frustum", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_Frustum_Single_Single_Single_Single_Single_Single.SetBelong(null);
				}
				return r_Frustum_Single_Single_Single_Single_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 Frustum(UnityEngine.FrustumPlanes)
		/// </summary>
		protected static RMethod r_Frustum_FrustumPlanes;
		public static RMethod RFrustum_FrustumPlanes
		{
			get
			{
				if(r_Frustum_FrustumPlanes == null)
				{
					r_Frustum_FrustumPlanes = new(typeof(UnityEngine.Matrix4x4), "Frustum", 0, typeof(UnityEngine.FrustumPlanes));
					r_Frustum_FrustumPlanes.SetBelong(null);
				}
				return r_Frustum_FrustumPlanes;
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
		/// Boolean Equals(UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_Equals_Matrix4x4;
		public virtual RMethod REquals_Matrix4x4
		{
			get
			{
				if(r_Equals_Matrix4x4 == null)
				{
					r_Equals_Matrix4x4 = new(this, "Equals", 0, typeof(UnityEngine.Matrix4x4));
					r_Equals_Matrix4x4.SetBelong(this.instance);
				}
				return r_Equals_Matrix4x4;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 op_Multiply(UnityEngine.Matrix4x4, UnityEngine.Matrix4x4)
		/// </summary>
		protected static RMethod r_op_Multiply_Matrix4x4_Matrix4x4;
		public static RMethod Rop_Multiply_Matrix4x4_Matrix4x4
		{
			get
			{
				if(r_op_Multiply_Matrix4x4_Matrix4x4 == null)
				{
					r_op_Multiply_Matrix4x4_Matrix4x4 = new(typeof(UnityEngine.Matrix4x4), "op_Multiply", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Matrix4x4));
					r_op_Multiply_Matrix4x4_Matrix4x4.SetBelong(null);
				}
				return r_op_Multiply_Matrix4x4_Matrix4x4;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 op_Multiply(UnityEngine.Matrix4x4, UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_op_Multiply_Matrix4x4_Vector4;
		public static RMethod Rop_Multiply_Matrix4x4_Vector4
		{
			get
			{
				if(r_op_Multiply_Matrix4x4_Vector4 == null)
				{
					r_op_Multiply_Matrix4x4_Vector4 = new(typeof(UnityEngine.Matrix4x4), "op_Multiply", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Vector4));
					r_op_Multiply_Matrix4x4_Vector4.SetBelong(null);
				}
				return r_op_Multiply_Matrix4x4_Vector4;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Matrix4x4, UnityEngine.Matrix4x4)
		/// </summary>
		protected static RMethod r_op_Equality_Matrix4x4_Matrix4x4;
		public static RMethod Rop_Equality_Matrix4x4_Matrix4x4
		{
			get
			{
				if(r_op_Equality_Matrix4x4_Matrix4x4 == null)
				{
					r_op_Equality_Matrix4x4_Matrix4x4 = new(typeof(UnityEngine.Matrix4x4), "op_Equality", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Matrix4x4));
					r_op_Equality_Matrix4x4_Matrix4x4.SetBelong(null);
				}
				return r_op_Equality_Matrix4x4_Matrix4x4;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Matrix4x4, UnityEngine.Matrix4x4)
		/// </summary>
		protected static RMethod r_op_Inequality_Matrix4x4_Matrix4x4;
		public static RMethod Rop_Inequality_Matrix4x4_Matrix4x4
		{
			get
			{
				if(r_op_Inequality_Matrix4x4_Matrix4x4 == null)
				{
					r_op_Inequality_Matrix4x4_Matrix4x4 = new(typeof(UnityEngine.Matrix4x4), "op_Inequality", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Matrix4x4));
					r_op_Inequality_Matrix4x4_Matrix4x4.SetBelong(null);
				}
				return r_op_Inequality_Matrix4x4_Matrix4x4;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 GetColumn(Int32)
		/// </summary>
		protected RMethod r_GetColumn_Int32;
		public virtual RMethod RGetColumn_Int32
		{
			get
			{
				if(r_GetColumn_Int32 == null)
				{
					r_GetColumn_Int32 = new(this, "GetColumn", 0, typeof(System.Int32));
					r_GetColumn_Int32.SetBelong(this.instance);
				}
				return r_GetColumn_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 GetRow(Int32)
		/// </summary>
		protected RMethod r_GetRow_Int32;
		public virtual RMethod RGetRow_Int32
		{
			get
			{
				if(r_GetRow_Int32 == null)
				{
					r_GetRow_Int32 = new(this, "GetRow", 0, typeof(System.Int32));
					r_GetRow_Int32.SetBelong(this.instance);
				}
				return r_GetRow_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 GetPosition()
		/// </summary>
		protected RMethod r_GetPosition;
		public virtual RMethod RGetPosition
		{
			get
			{
				if(r_GetPosition == null)
				{
					r_GetPosition = new(this, "GetPosition", 0);
					r_GetPosition.SetBelong(this.instance);
				}
				return r_GetPosition;
			}
		}

		/// <summary>
		/// Void SetColumn(Int32, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_SetColumn_Int32_Vector4;
		public virtual RMethod RSetColumn_Int32_Vector4
		{
			get
			{
				if(r_SetColumn_Int32_Vector4 == null)
				{
					r_SetColumn_Int32_Vector4 = new(this, "SetColumn", 0, typeof(System.Int32), typeof(UnityEngine.Vector4));
					r_SetColumn_Int32_Vector4.SetBelong(this.instance);
				}
				return r_SetColumn_Int32_Vector4;
			}
		}

		/// <summary>
		/// Void SetRow(Int32, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_SetRow_Int32_Vector4;
		public virtual RMethod RSetRow_Int32_Vector4
		{
			get
			{
				if(r_SetRow_Int32_Vector4 == null)
				{
					r_SetRow_Int32_Vector4 = new(this, "SetRow", 0, typeof(System.Int32), typeof(UnityEngine.Vector4));
					r_SetRow_Int32_Vector4.SetBelong(this.instance);
				}
				return r_SetRow_Int32_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 MultiplyPoint(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MultiplyPoint_Vector3;
		public virtual RMethod RMultiplyPoint_Vector3
		{
			get
			{
				if(r_MultiplyPoint_Vector3 == null)
				{
					r_MultiplyPoint_Vector3 = new(this, "MultiplyPoint", 0, typeof(UnityEngine.Vector3));
					r_MultiplyPoint_Vector3.SetBelong(this.instance);
				}
				return r_MultiplyPoint_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 MultiplyPoint3x4(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MultiplyPoint3x4_Vector3;
		public virtual RMethod RMultiplyPoint3x4_Vector3
		{
			get
			{
				if(r_MultiplyPoint3x4_Vector3 == null)
				{
					r_MultiplyPoint3x4_Vector3 = new(this, "MultiplyPoint3x4", 0, typeof(UnityEngine.Vector3));
					r_MultiplyPoint3x4_Vector3.SetBelong(this.instance);
				}
				return r_MultiplyPoint3x4_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 MultiplyVector(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MultiplyVector_Vector3;
		public virtual RMethod RMultiplyVector_Vector3
		{
			get
			{
				if(r_MultiplyVector_Vector3 == null)
				{
					r_MultiplyVector_Vector3 = new(this, "MultiplyVector", 0, typeof(UnityEngine.Vector3));
					r_MultiplyVector_Vector3.SetBelong(this.instance);
				}
				return r_MultiplyVector_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Plane TransformPlane(UnityEngine.Plane)
		/// </summary>
		protected RMethod r_TransformPlane_Plane;
		public virtual RMethod RTransformPlane_Plane
		{
			get
			{
				if(r_TransformPlane_Plane == null)
				{
					r_TransformPlane_Plane = new(this, "TransformPlane", 0, typeof(UnityEngine.Plane));
					r_TransformPlane_Plane.SetBelong(this.instance);
				}
				return r_TransformPlane_Plane;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 Scale(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_Scale_Vector3;
		public static RMethod RScale_Vector3
		{
			get
			{
				if(r_Scale_Vector3 == null)
				{
					r_Scale_Vector3 = new(typeof(UnityEngine.Matrix4x4), "Scale", 0, typeof(UnityEngine.Vector3));
					r_Scale_Vector3.SetBelong(null);
				}
				return r_Scale_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 Translate(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_Translate_Vector3;
		public static RMethod RTranslate_Vector3
		{
			get
			{
				if(r_Translate_Vector3 == null)
				{
					r_Translate_Vector3 = new(typeof(UnityEngine.Matrix4x4), "Translate", 0, typeof(UnityEngine.Vector3));
					r_Translate_Vector3.SetBelong(null);
				}
				return r_Translate_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 Rotate(UnityEngine.Quaternion)
		/// </summary>
		protected static RMethod r_Rotate_Quaternion;
		public static RMethod RRotate_Quaternion
		{
			get
			{
				if(r_Rotate_Quaternion == null)
				{
					r_Rotate_Quaternion = new(typeof(UnityEngine.Matrix4x4), "Rotate", 0, typeof(UnityEngine.Quaternion));
					r_Rotate_Quaternion.SetBelong(null);
				}
				return r_Rotate_Quaternion;
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
		/// Void GetRotation_Injected(UnityEngine.Matrix4x4 ByRef, UnityEngine.Quaternion ByRef)
		/// </summary>
		protected static RMethod r_GetRotation_Injected_Ref_Matrix4x4_Out_Quaternion;
		public static RMethod RGetRotation_Injected_Ref_Matrix4x4_Out_Quaternion
		{
			get
			{
				if(r_GetRotation_Injected_Ref_Matrix4x4_Out_Quaternion == null)
				{
					r_GetRotation_Injected_Ref_Matrix4x4_Out_Quaternion = new(typeof(UnityEngine.Matrix4x4), "GetRotation_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType());
					r_GetRotation_Injected_Ref_Matrix4x4_Out_Quaternion.SetBelong(null);
				}
				return r_GetRotation_Injected_Ref_Matrix4x4_Out_Quaternion;
			}
		}

		/// <summary>
		/// Void GetLossyScale_Injected(UnityEngine.Matrix4x4 ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected static RMethod r_GetLossyScale_Injected_Ref_Matrix4x4_Out_Vector3;
		public static RMethod RGetLossyScale_Injected_Ref_Matrix4x4_Out_Vector3
		{
			get
			{
				if(r_GetLossyScale_Injected_Ref_Matrix4x4_Out_Vector3 == null)
				{
					r_GetLossyScale_Injected_Ref_Matrix4x4_Out_Vector3 = new(typeof(UnityEngine.Matrix4x4), "GetLossyScale_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
					r_GetLossyScale_Injected_Ref_Matrix4x4_Out_Vector3.SetBelong(null);
				}
				return r_GetLossyScale_Injected_Ref_Matrix4x4_Out_Vector3;
			}
		}

		/// <summary>
		/// Boolean IsIdentity_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected static RMethod r_IsIdentity_Injected_Ref_Matrix4x4;
		public static RMethod RIsIdentity_Injected_Ref_Matrix4x4
		{
			get
			{
				if(r_IsIdentity_Injected_Ref_Matrix4x4 == null)
				{
					r_IsIdentity_Injected_Ref_Matrix4x4 = new(typeof(UnityEngine.Matrix4x4), "IsIdentity_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_IsIdentity_Injected_Ref_Matrix4x4.SetBelong(null);
				}
				return r_IsIdentity_Injected_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Single GetDeterminant_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected static RMethod r_GetDeterminant_Injected_Ref_Matrix4x4;
		public static RMethod RGetDeterminant_Injected_Ref_Matrix4x4
		{
			get
			{
				if(r_GetDeterminant_Injected_Ref_Matrix4x4 == null)
				{
					r_GetDeterminant_Injected_Ref_Matrix4x4 = new(typeof(UnityEngine.Matrix4x4), "GetDeterminant_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_GetDeterminant_Injected_Ref_Matrix4x4.SetBelong(null);
				}
				return r_GetDeterminant_Injected_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Void DecomposeProjection_Injected(UnityEngine.Matrix4x4 ByRef, UnityEngine.FrustumPlanes ByRef)
		/// </summary>
		protected static RMethod r_DecomposeProjection_Injected_Ref_Matrix4x4_Out_FrustumPlanes;
		public static RMethod RDecomposeProjection_Injected_Ref_Matrix4x4_Out_FrustumPlanes
		{
			get
			{
				if(r_DecomposeProjection_Injected_Ref_Matrix4x4_Out_FrustumPlanes == null)
				{
					r_DecomposeProjection_Injected_Ref_Matrix4x4_Out_FrustumPlanes = new(typeof(UnityEngine.Matrix4x4), "DecomposeProjection_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.FrustumPlanes).MakeByRefType());
					r_DecomposeProjection_Injected_Ref_Matrix4x4_Out_FrustumPlanes.SetBelong(null);
				}
				return r_DecomposeProjection_Injected_Ref_Matrix4x4_Out_FrustumPlanes;
			}
		}

		/// <summary>
		/// Boolean ValidTRS_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected static RMethod r_ValidTRS_Injected_Ref_Matrix4x4;
		public static RMethod RValidTRS_Injected_Ref_Matrix4x4
		{
			get
			{
				if(r_ValidTRS_Injected_Ref_Matrix4x4 == null)
				{
					r_ValidTRS_Injected_Ref_Matrix4x4 = new(typeof(UnityEngine.Matrix4x4), "ValidTRS_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_ValidTRS_Injected_Ref_Matrix4x4.SetBelong(null);
				}
				return r_ValidTRS_Injected_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Void TRS_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Quaternion ByRef, UnityEngine.Vector3 ByRef, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected static RMethod r_TRS_Injected_Ref_Vector3_Ref_Quaternion_Ref_Vector3_Out_Matrix4x4;
		public static RMethod RTRS_Injected_Ref_Vector3_Ref_Quaternion_Ref_Vector3_Out_Matrix4x4
		{
			get
			{
				if(r_TRS_Injected_Ref_Vector3_Ref_Quaternion_Ref_Vector3_Out_Matrix4x4 == null)
				{
					r_TRS_Injected_Ref_Vector3_Ref_Quaternion_Ref_Vector3_Out_Matrix4x4 = new(typeof(UnityEngine.Matrix4x4), "TRS_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_TRS_Injected_Ref_Vector3_Ref_Quaternion_Ref_Vector3_Out_Matrix4x4.SetBelong(null);
				}
				return r_TRS_Injected_Ref_Vector3_Ref_Quaternion_Ref_Vector3_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Boolean Inverse3DAffine_Injected(UnityEngine.Matrix4x4 ByRef, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected static RMethod r_Inverse3DAffine_Injected_Ref_Matrix4x4_Ref_Matrix4x4;
		public static RMethod RInverse3DAffine_Injected_Ref_Matrix4x4_Ref_Matrix4x4
		{
			get
			{
				if(r_Inverse3DAffine_Injected_Ref_Matrix4x4_Ref_Matrix4x4 == null)
				{
					r_Inverse3DAffine_Injected_Ref_Matrix4x4_Ref_Matrix4x4 = new(typeof(UnityEngine.Matrix4x4), "Inverse3DAffine_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_Inverse3DAffine_Injected_Ref_Matrix4x4_Ref_Matrix4x4.SetBelong(null);
				}
				return r_Inverse3DAffine_Injected_Ref_Matrix4x4_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Void Inverse_Injected(UnityEngine.Matrix4x4 ByRef, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected static RMethod r_Inverse_Injected_Ref_Matrix4x4_Out_Matrix4x4;
		public static RMethod RInverse_Injected_Ref_Matrix4x4_Out_Matrix4x4
		{
			get
			{
				if(r_Inverse_Injected_Ref_Matrix4x4_Out_Matrix4x4 == null)
				{
					r_Inverse_Injected_Ref_Matrix4x4_Out_Matrix4x4 = new(typeof(UnityEngine.Matrix4x4), "Inverse_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_Inverse_Injected_Ref_Matrix4x4_Out_Matrix4x4.SetBelong(null);
				}
				return r_Inverse_Injected_Ref_Matrix4x4_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void Transpose_Injected(UnityEngine.Matrix4x4 ByRef, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected static RMethod r_Transpose_Injected_Ref_Matrix4x4_Out_Matrix4x4;
		public static RMethod RTranspose_Injected_Ref_Matrix4x4_Out_Matrix4x4
		{
			get
			{
				if(r_Transpose_Injected_Ref_Matrix4x4_Out_Matrix4x4 == null)
				{
					r_Transpose_Injected_Ref_Matrix4x4_Out_Matrix4x4 = new(typeof(UnityEngine.Matrix4x4), "Transpose_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_Transpose_Injected_Ref_Matrix4x4_Out_Matrix4x4.SetBelong(null);
				}
				return r_Transpose_Injected_Ref_Matrix4x4_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void Ortho_Injected(Single, Single, Single, Single, Single, Single, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected static RMethod r_Ortho_Injected_Single_Single_Single_Single_Single_Single_Out_Matrix4x4;
		public static RMethod ROrtho_Injected_Single_Single_Single_Single_Single_Single_Out_Matrix4x4
		{
			get
			{
				if(r_Ortho_Injected_Single_Single_Single_Single_Single_Single_Out_Matrix4x4 == null)
				{
					r_Ortho_Injected_Single_Single_Single_Single_Single_Single_Out_Matrix4x4 = new(typeof(UnityEngine.Matrix4x4), "Ortho_Injected", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_Ortho_Injected_Single_Single_Single_Single_Single_Single_Out_Matrix4x4.SetBelong(null);
				}
				return r_Ortho_Injected_Single_Single_Single_Single_Single_Single_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void Perspective_Injected(Single, Single, Single, Single, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected static RMethod r_Perspective_Injected_Single_Single_Single_Single_Out_Matrix4x4;
		public static RMethod RPerspective_Injected_Single_Single_Single_Single_Out_Matrix4x4
		{
			get
			{
				if(r_Perspective_Injected_Single_Single_Single_Single_Out_Matrix4x4 == null)
				{
					r_Perspective_Injected_Single_Single_Single_Single_Out_Matrix4x4 = new(typeof(UnityEngine.Matrix4x4), "Perspective_Injected", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_Perspective_Injected_Single_Single_Single_Single_Out_Matrix4x4.SetBelong(null);
				}
				return r_Perspective_Injected_Single_Single_Single_Single_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void LookAt_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected static RMethod r_LookAt_Injected_Ref_Vector3_Ref_Vector3_Ref_Vector3_Out_Matrix4x4;
		public static RMethod RLookAt_Injected_Ref_Vector3_Ref_Vector3_Ref_Vector3_Out_Matrix4x4
		{
			get
			{
				if(r_LookAt_Injected_Ref_Vector3_Ref_Vector3_Ref_Vector3_Out_Matrix4x4 == null)
				{
					r_LookAt_Injected_Ref_Vector3_Ref_Vector3_Ref_Vector3_Out_Matrix4x4 = new(typeof(UnityEngine.Matrix4x4), "LookAt_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_LookAt_Injected_Ref_Vector3_Ref_Vector3_Ref_Vector3_Out_Matrix4x4.SetBelong(null);
				}
				return r_LookAt_Injected_Ref_Vector3_Ref_Vector3_Ref_Vector3_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void Frustum_Injected(Single, Single, Single, Single, Single, Single, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected static RMethod r_Frustum_Injected_Single_Single_Single_Single_Single_Single_Out_Matrix4x4;
		public static RMethod RFrustum_Injected_Single_Single_Single_Single_Single_Single_Out_Matrix4x4
		{
			get
			{
				if(r_Frustum_Injected_Single_Single_Single_Single_Single_Single_Out_Matrix4x4 == null)
				{
					r_Frustum_Injected_Single_Single_Single_Single_Single_Single_Out_Matrix4x4 = new(typeof(UnityEngine.Matrix4x4), "Frustum_Injected", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_Frustum_Injected_Single_Single_Single_Single_Single_Single_Out_Matrix4x4.SetBelong(null);
				}
				return r_Frustum_Injected_Single_Single_Single_Single_Single_Single_Out_Matrix4x4;
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


        public RMatrix4x4() : base("UnityEngine.Matrix4x4")
        {
        }

        public RMatrix4x4(System.Object instance) : base("UnityEngine.Matrix4x4")
		{
            SetInstance(instance);
		}

        public RMatrix4x4(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMatrix4x4(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual UnityEngine.Quaternion GetRotation()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRotation.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public virtual UnityEngine.Vector3 GetLossyScale()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLossyScale.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual System.Boolean IsIdentity()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsIdentity.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Single GetDeterminant()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDeterminant.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual UnityEngine.FrustumPlanes DecomposeProjection()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDecomposeProjection.Invoke(___genericsType, ___parameters);

            return (UnityEngine.FrustumPlanes)___result;
        }


        public virtual System.Boolean ValidTRS()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RValidTRS.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Single Determinant(UnityEngine.Matrix4x4  @m)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@m};
            var ___result = RDeterminant_Matrix4x4.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static UnityEngine.Matrix4x4 TRS(UnityEngine.Vector3  @pos, UnityEngine.Quaternion  @q, UnityEngine.Vector3  @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos, @q, @s};
            var ___result = RTRS_Vector3_Quaternion_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4)___result;
        }


        public virtual void SetTRS(UnityEngine.Vector3  @pos, UnityEngine.Quaternion  @q, UnityEngine.Vector3  @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos, @q, @s};
            var ___result = RSetTRS_Vector3_Quaternion_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean Inverse3DAffine(UnityEngine.Matrix4x4  @input, ref UnityEngine.Matrix4x4  @result)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @result};
            var ___result = RInverse3DAffine_Matrix4x4_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			result = (UnityEngine.Matrix4x4)___parameters[1];

            return (System.Boolean)___result;
        }


        public static UnityEngine.Matrix4x4 Inverse(UnityEngine.Matrix4x4  @m)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@m};
            var ___result = RInverse_Matrix4x4.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4)___result;
        }


        public static UnityEngine.Matrix4x4 Transpose(UnityEngine.Matrix4x4  @m)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@m};
            var ___result = RTranspose_Matrix4x4.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4)___result;
        }


        public static UnityEngine.Matrix4x4 Ortho(System.Single  @left, System.Single  @right, System.Single  @bottom, System.Single  @top, System.Single  @zNear, System.Single  @zFar)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right, @bottom, @top, @zNear, @zFar};
            var ___result = ROrtho_Single_Single_Single_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4)___result;
        }


        public static UnityEngine.Matrix4x4 Perspective(System.Single  @fov, System.Single  @aspect, System.Single  @zNear, System.Single  @zFar)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fov, @aspect, @zNear, @zFar};
            var ___result = RPerspective_Single_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4)___result;
        }


        public static UnityEngine.Matrix4x4 LookAt(UnityEngine.Vector3  @from, UnityEngine.Vector3  @to, UnityEngine.Vector3  @up)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @up};
            var ___result = RLookAt_Vector3_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4)___result;
        }


        public static UnityEngine.Matrix4x4 Frustum(System.Single  @left, System.Single  @right, System.Single  @bottom, System.Single  @top, System.Single  @zNear, System.Single  @zFar)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right, @bottom, @top, @zNear, @zFar};
            var ___result = RFrustum_Single_Single_Single_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4)___result;
        }


        public static UnityEngine.Matrix4x4 Frustum(UnityEngine.FrustumPlanes  @fp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fp};
            var ___result = RFrustum_FrustumPlanes.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4)___result;
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


        public virtual System.Boolean Equals(UnityEngine.Matrix4x4  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Matrix4x4.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.Matrix4x4 op_Multiply(UnityEngine.Matrix4x4  @lhs, UnityEngine.Matrix4x4  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Multiply_Matrix4x4_Matrix4x4.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4)___result;
        }


        public static UnityEngine.Vector4 op_Multiply(UnityEngine.Matrix4x4  @lhs, UnityEngine.Vector4  @vector)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @vector};
            var ___result = Rop_Multiply_Matrix4x4_Vector4.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Matrix4x4  @lhs, UnityEngine.Matrix4x4  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_Matrix4x4_Matrix4x4.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Matrix4x4  @lhs, UnityEngine.Matrix4x4  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_Matrix4x4_Matrix4x4.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Vector4 GetColumn(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetColumn_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public virtual UnityEngine.Vector4 GetRow(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetRow_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public virtual UnityEngine.Vector3 GetPosition()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPosition.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual void SetColumn(System.Int32  @index, UnityEngine.Vector4  @column)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @column};
            var ___result = RSetColumn_Int32_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRow(System.Int32  @index, UnityEngine.Vector4  @row)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @row};
            var ___result = RSetRow_Int32_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector3 MultiplyPoint(UnityEngine.Vector3  @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point};
            var ___result = RMultiplyPoint_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual UnityEngine.Vector3 MultiplyPoint3x4(UnityEngine.Vector3  @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point};
            var ___result = RMultiplyPoint3x4_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual UnityEngine.Vector3 MultiplyVector(UnityEngine.Vector3  @vector)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vector};
            var ___result = RMultiplyVector_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual UnityEngine.Plane TransformPlane(UnityEngine.Plane  @plane)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@plane};
            var ___result = RTransformPlane_Plane.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Plane)___result;
        }


        public static UnityEngine.Matrix4x4 Scale(UnityEngine.Vector3  @vector)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vector};
            var ___result = RScale_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4)___result;
        }


        public static UnityEngine.Matrix4x4 Translate(UnityEngine.Vector3  @vector)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vector};
            var ___result = RTranslate_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4)___result;
        }


        public static UnityEngine.Matrix4x4 Rotate(UnityEngine.Quaternion  @q)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@q};
            var ___result = RRotate_Quaternion.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4)___result;
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


        public static void GetRotation_Injected(ref UnityEngine.Matrix4x4  @_unity_self, out UnityEngine.Quaternion  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self, @ret};
            var ___result = RGetRotation_Injected_Ref_Matrix4x4_Out_Quaternion.Invoke(___genericsType, ___parameters);
			_unity_self = (UnityEngine.Matrix4x4)___parameters[0];
			ret = (UnityEngine.Quaternion)___parameters[1];

            
        }


        public static void GetLossyScale_Injected(ref UnityEngine.Matrix4x4  @_unity_self, out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self, @ret};
            var ___result = RGetLossyScale_Injected_Ref_Matrix4x4_Out_Vector3.Invoke(___genericsType, ___parameters);
			_unity_self = (UnityEngine.Matrix4x4)___parameters[0];
			ret = (UnityEngine.Vector3)___parameters[1];

            
        }


        public static System.Boolean IsIdentity_Injected(ref UnityEngine.Matrix4x4  @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RIsIdentity_Injected_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			_unity_self = (UnityEngine.Matrix4x4)___parameters[0];

            return (System.Boolean)___result;
        }


        public static System.Single GetDeterminant_Injected(ref UnityEngine.Matrix4x4  @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RGetDeterminant_Injected_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			_unity_self = (UnityEngine.Matrix4x4)___parameters[0];

            return (System.Single)___result;
        }


        public static void DecomposeProjection_Injected(ref UnityEngine.Matrix4x4  @_unity_self, out UnityEngine.FrustumPlanes  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self, @ret};
            var ___result = RDecomposeProjection_Injected_Ref_Matrix4x4_Out_FrustumPlanes.Invoke(___genericsType, ___parameters);
			_unity_self = (UnityEngine.Matrix4x4)___parameters[0];
			ret = (UnityEngine.FrustumPlanes)___parameters[1];

            
        }


        public static System.Boolean ValidTRS_Injected(ref UnityEngine.Matrix4x4  @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RValidTRS_Injected_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			_unity_self = (UnityEngine.Matrix4x4)___parameters[0];

            return (System.Boolean)___result;
        }


        public static void TRS_Injected(ref UnityEngine.Vector3  @pos, ref UnityEngine.Quaternion  @q, ref UnityEngine.Vector3  @s, out UnityEngine.Matrix4x4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos, @q, @s, @ret};
            var ___result = RTRS_Injected_Ref_Vector3_Ref_Quaternion_Ref_Vector3_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			pos = (UnityEngine.Vector3)___parameters[0];
			q = (UnityEngine.Quaternion)___parameters[1];
			s = (UnityEngine.Vector3)___parameters[2];
			ret = (UnityEngine.Matrix4x4)___parameters[3];

            
        }


        public static System.Boolean Inverse3DAffine_Injected(ref UnityEngine.Matrix4x4  @input, ref UnityEngine.Matrix4x4  @result)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @result};
            var ___result = RInverse3DAffine_Injected_Ref_Matrix4x4_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			input = (UnityEngine.Matrix4x4)___parameters[0];
			result = (UnityEngine.Matrix4x4)___parameters[1];

            return (System.Boolean)___result;
        }


        public static void Inverse_Injected(ref UnityEngine.Matrix4x4  @m, out UnityEngine.Matrix4x4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@m, @ret};
            var ___result = RInverse_Injected_Ref_Matrix4x4_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			m = (UnityEngine.Matrix4x4)___parameters[0];
			ret = (UnityEngine.Matrix4x4)___parameters[1];

            
        }


        public static void Transpose_Injected(ref UnityEngine.Matrix4x4  @m, out UnityEngine.Matrix4x4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@m, @ret};
            var ___result = RTranspose_Injected_Ref_Matrix4x4_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			m = (UnityEngine.Matrix4x4)___parameters[0];
			ret = (UnityEngine.Matrix4x4)___parameters[1];

            
        }


        public static void Ortho_Injected(System.Single  @left, System.Single  @right, System.Single  @bottom, System.Single  @top, System.Single  @zNear, System.Single  @zFar, out UnityEngine.Matrix4x4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right, @bottom, @top, @zNear, @zFar, @ret};
            var ___result = ROrtho_Injected_Single_Single_Single_Single_Single_Single_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Matrix4x4)___parameters[6];

            
        }


        public static void Perspective_Injected(System.Single  @fov, System.Single  @aspect, System.Single  @zNear, System.Single  @zFar, out UnityEngine.Matrix4x4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fov, @aspect, @zNear, @zFar, @ret};
            var ___result = RPerspective_Injected_Single_Single_Single_Single_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Matrix4x4)___parameters[4];

            
        }


        public static void LookAt_Injected(ref UnityEngine.Vector3  @from, ref UnityEngine.Vector3  @to, ref UnityEngine.Vector3  @up, out UnityEngine.Matrix4x4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @up, @ret};
            var ___result = RLookAt_Injected_Ref_Vector3_Ref_Vector3_Ref_Vector3_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			from = (UnityEngine.Vector3)___parameters[0];
			to = (UnityEngine.Vector3)___parameters[1];
			up = (UnityEngine.Vector3)___parameters[2];
			ret = (UnityEngine.Matrix4x4)___parameters[3];

            
        }


        public static void Frustum_Injected(System.Single  @left, System.Single  @right, System.Single  @bottom, System.Single  @top, System.Single  @zNear, System.Single  @zFar, out UnityEngine.Matrix4x4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right, @bottom, @top, @zNear, @zFar, @ret};
            var ___result = RFrustum_Injected_Single_Single_Single_Single_Single_Single_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Matrix4x4)___parameters[6];

            
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
