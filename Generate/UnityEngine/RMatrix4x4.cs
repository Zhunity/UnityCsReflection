using SMFrame.Editor.Refleaction.RUnityEngine;
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
    public partial class RMatrix4x4 : RMember
    {
		public  RQuaternion rotation; //UnityEngine.Quaternion
		public  RVector3 lossyScale; //UnityEngine.Vector3
		public  RProperty isIdentity; //System.Boolean
		public  RProperty determinant; //System.Single
		public  RFrustumPlanes decomposeProjection; //UnityEngine.FrustumPlanes
		public  RMatrix4x4 inverse; //UnityEngine.Matrix4x4
		public  RMatrix4x4 transpose; //UnityEngine.Matrix4x4
		public  RProperty Item_Int32_Int32; //System.Single
		public  RProperty Item_Int32; //System.Single
		public static RMatrix4x4 zero; //UnityEngine.Matrix4x4
		public static RMatrix4x4 identity; //UnityEngine.Matrix4x4
		public  RField m00; //System.Single
		public  RField m10; //System.Single
		public  RField m20; //System.Single
		public  RField m30; //System.Single
		public  RField m01; //System.Single
		public  RField m11; //System.Single
		public  RField m21; //System.Single
		public  RField m31; //System.Single
		public  RField m02; //System.Single
		public  RField m12; //System.Single
		public  RField m22; //System.Single
		public  RField m32; //System.Single
		public  RField m03; //System.Single
		public  RField m13; //System.Single
		public  RField m23; //System.Single
		public  RField m33; //System.Single
		public static RMatrix4x4 zeroMatrix; //UnityEngine.Matrix4x4
		public static RMatrix4x4 identityMatrix; //UnityEngine.Matrix4x4
		public  RMethod RGetRotation; //UnityEngine.Quaternion GetRotation()
		public  RMethod RGetLossyScale; //UnityEngine.Vector3 GetLossyScale()
		public  RMethod RIsIdentity; //Boolean IsIdentity()
		public  RMethod RGetDeterminant; //Single GetDeterminant()
		public  RMethod RDecomposeProjection; //UnityEngine.FrustumPlanes DecomposeProjection()
		public  RMethod RValidTRS; //Boolean ValidTRS()
		public static RMethod RDeterminant_Matrix4x4; //Single Determinant(UnityEngine.Matrix4x4)
		public static RMethod RTRS_Vector3_Quaternion_Vector3; //UnityEngine.Matrix4x4 TRS(UnityEngine.Vector3, UnityEngine.Quaternion, UnityEngine.Vector3)
		public  RMethod RSetTRS_Vector3_Quaternion_Vector3; //Void SetTRS(UnityEngine.Vector3, UnityEngine.Quaternion, UnityEngine.Vector3)
		public static RMethod RInverse3DAffine_Matrix4x4_Ref_Matrix4x4; //Boolean Inverse3DAffine(UnityEngine.Matrix4x4, UnityEngine.Matrix4x4 ByRef)
		public static RMethod RInverse_Matrix4x4; //UnityEngine.Matrix4x4 Inverse(UnityEngine.Matrix4x4)
		public static RMethod RTranspose_Matrix4x4; //UnityEngine.Matrix4x4 Transpose(UnityEngine.Matrix4x4)
		public static RMethod ROrtho_Single_Single_Single_Single_Single_Single; //UnityEngine.Matrix4x4 Ortho(Single, Single, Single, Single, Single, Single)
		public static RMethod RPerspective_Single_Single_Single_Single; //UnityEngine.Matrix4x4 Perspective(Single, Single, Single, Single)
		public static RMethod RLookAt_Vector3_Vector3_Vector3; //UnityEngine.Matrix4x4 LookAt(UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3)
		public static RMethod RFrustum_Single_Single_Single_Single_Single_Single; //UnityEngine.Matrix4x4 Frustum(Single, Single, Single, Single, Single, Single)
		public static RMethod RFrustum_FrustumPlanes; //UnityEngine.Matrix4x4 Frustum(UnityEngine.FrustumPlanes)
		public  RMethod RGetHashCode; //Int32 GetHashCode()
		public  RMethod REquals_Object; //Boolean Equals(System.Object)
		public  RMethod REquals_Matrix4x4; //Boolean Equals(UnityEngine.Matrix4x4)
		public static RMethod Rop_Multiply_Matrix4x4_Matrix4x4; //UnityEngine.Matrix4x4 op_Multiply(UnityEngine.Matrix4x4, UnityEngine.Matrix4x4)
		public static RMethod Rop_Multiply_Matrix4x4_Vector4; //UnityEngine.Vector4 op_Multiply(UnityEngine.Matrix4x4, UnityEngine.Vector4)
		public static RMethod Rop_Equality_Matrix4x4_Matrix4x4; //Boolean op_Equality(UnityEngine.Matrix4x4, UnityEngine.Matrix4x4)
		public static RMethod Rop_Inequality_Matrix4x4_Matrix4x4; //Boolean op_Inequality(UnityEngine.Matrix4x4, UnityEngine.Matrix4x4)
		public  RMethod RGetColumn_Int32; //UnityEngine.Vector4 GetColumn(Int32)
		public  RMethod RGetRow_Int32; //UnityEngine.Vector4 GetRow(Int32)
		public  RMethod RGetPosition; //UnityEngine.Vector3 GetPosition()
		public  RMethod RSetColumn_Int32_Vector4; //Void SetColumn(Int32, UnityEngine.Vector4)
		public  RMethod RSetRow_Int32_Vector4; //Void SetRow(Int32, UnityEngine.Vector4)
		public  RMethod RMultiplyPoint_Vector3; //UnityEngine.Vector3 MultiplyPoint(UnityEngine.Vector3)
		public  RMethod RMultiplyPoint3x4_Vector3; //UnityEngine.Vector3 MultiplyPoint3x4(UnityEngine.Vector3)
		public  RMethod RMultiplyVector_Vector3; //UnityEngine.Vector3 MultiplyVector(UnityEngine.Vector3)
		public  RMethod RTransformPlane_Plane; //UnityEngine.Plane TransformPlane(UnityEngine.Plane)
		public static RMethod RScale_Vector3; //UnityEngine.Matrix4x4 Scale(UnityEngine.Vector3)
		public static RMethod RTranslate_Vector3; //UnityEngine.Matrix4x4 Translate(UnityEngine.Vector3)
		public static RMethod RRotate_Quaternion; //UnityEngine.Matrix4x4 Rotate(UnityEngine.Quaternion)
		public  RMethod RToString; //System.String ToString()
		public  RMethod RToString_String; //System.String ToString(System.String)
		public  RMethod RToString_String_IFormatProvider; //System.String ToString(System.String, System.IFormatProvider)
		public static RMethod RGetRotation_Injected_Ref_Matrix4x4_Out_Quaternion; //Void GetRotation_Injected(UnityEngine.Matrix4x4 ByRef, UnityEngine.Quaternion ByRef)
		public static RMethod RGetLossyScale_Injected_Ref_Matrix4x4_Out_Vector3; //Void GetLossyScale_Injected(UnityEngine.Matrix4x4 ByRef, UnityEngine.Vector3 ByRef)
		public static RMethod RIsIdentity_Injected_Ref_Matrix4x4; //Boolean IsIdentity_Injected(UnityEngine.Matrix4x4 ByRef)
		public static RMethod RGetDeterminant_Injected_Ref_Matrix4x4; //Single GetDeterminant_Injected(UnityEngine.Matrix4x4 ByRef)
		public static RMethod RDecomposeProjection_Injected_Ref_Matrix4x4_Out_FrustumPlanes; //Void DecomposeProjection_Injected(UnityEngine.Matrix4x4 ByRef, UnityEngine.FrustumPlanes ByRef)
		public static RMethod RValidTRS_Injected_Ref_Matrix4x4; //Boolean ValidTRS_Injected(UnityEngine.Matrix4x4 ByRef)
		public static RMethod RTRS_Injected_Ref_Vector3_Ref_Quaternion_Ref_Vector3_Out_Matrix4x4; //Void TRS_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Quaternion ByRef, UnityEngine.Vector3 ByRef, UnityEngine.Matrix4x4 ByRef)
		public static RMethod RInverse3DAffine_Injected_Ref_Matrix4x4_Ref_Matrix4x4; //Boolean Inverse3DAffine_Injected(UnityEngine.Matrix4x4 ByRef, UnityEngine.Matrix4x4 ByRef)
		public static RMethod RInverse_Injected_Ref_Matrix4x4_Out_Matrix4x4; //Void Inverse_Injected(UnityEngine.Matrix4x4 ByRef, UnityEngine.Matrix4x4 ByRef)
		public static RMethod RTranspose_Injected_Ref_Matrix4x4_Out_Matrix4x4; //Void Transpose_Injected(UnityEngine.Matrix4x4 ByRef, UnityEngine.Matrix4x4 ByRef)
		public static RMethod ROrtho_Injected_Single_Single_Single_Single_Single_Single_Out_Matrix4x4; //Void Ortho_Injected(Single, Single, Single, Single, Single, Single, UnityEngine.Matrix4x4 ByRef)
		public static RMethod RPerspective_Injected_Single_Single_Single_Single_Out_Matrix4x4; //Void Perspective_Injected(Single, Single, Single, Single, UnityEngine.Matrix4x4 ByRef)
		public static RMethod RLookAt_Injected_Ref_Vector3_Ref_Vector3_Ref_Vector3_Out_Matrix4x4; //Void LookAt_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef, UnityEngine.Matrix4x4 ByRef)
		public static RMethod RFrustum_Injected_Single_Single_Single_Single_Single_Single_Out_Matrix4x4; //Void Frustum_Injected(Single, Single, Single, Single, Single, Single, UnityEngine.Matrix4x4 ByRef)
		public  RMethod RFinalize; //Void Finalize()
		public  RMethod RGetType; //System.Type GetType()
		public  RMethod RMemberwiseClone; //System.Object MemberwiseClone()


        public RMatrix4x4() : base("UnityEngine.Matrix4x4")
        {
            NewMembers();
        }

        public RMatrix4x4(System.Object instance) : base("UnityEngine.Matrix4x4")
		{
			NewMembers();
            SetInstance(instance);
		}

        public RMatrix4x4(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
            NewMembers();
	    }

        private void NewMembers()
        {
			rotation = new RQuaternion(this, "rotation", -1);
			lossyScale = new RVector3(this, "lossyScale", -1);
			isIdentity = new RProperty(this, "isIdentity", -1);
			determinant = new RProperty(this, "determinant", -1);
			decomposeProjection = new RFrustumPlanes(this, "decomposeProjection", -1);
			inverse = new RMatrix4x4(this, "inverse", -1);
			transpose = new RMatrix4x4(this, "transpose", -1);
			Item_Int32_Int32 = new RProperty(this, "Item", -1, typeof(System.Int32), typeof(System.Int32));
			Item_Int32 = new RProperty(this, "Item", -1, typeof(System.Int32));
			zero = new RMatrix4x4(this, "zero", -1);
			identity = new RMatrix4x4(this, "identity", -1);
			m00 = new RField(this, "m00");
			m10 = new RField(this, "m10");
			m20 = new RField(this, "m20");
			m30 = new RField(this, "m30");
			m01 = new RField(this, "m01");
			m11 = new RField(this, "m11");
			m21 = new RField(this, "m21");
			m31 = new RField(this, "m31");
			m02 = new RField(this, "m02");
			m12 = new RField(this, "m12");
			m22 = new RField(this, "m22");
			m32 = new RField(this, "m32");
			m03 = new RField(this, "m03");
			m13 = new RField(this, "m13");
			m23 = new RField(this, "m23");
			m33 = new RField(this, "m33");
			zeroMatrix = new RMatrix4x4(this, "zeroMatrix");
			identityMatrix = new RMatrix4x4(this, "identityMatrix");
			RGetRotation = new RMethod(this, "GetRotation", 0);
			RGetLossyScale = new RMethod(this, "GetLossyScale", 0);
			RIsIdentity = new RMethod(this, "IsIdentity", 0);
			RGetDeterminant = new RMethod(this, "GetDeterminant", 0);
			RDecomposeProjection = new RMethod(this, "DecomposeProjection", 0);
			RValidTRS = new RMethod(this, "ValidTRS", 0);
			RDeterminant_Matrix4x4 = new RMethod(this, "Determinant", 0, typeof(UnityEngine.Matrix4x4));
			RTRS_Vector3_Quaternion_Vector3 = new RMethod(this, "TRS", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Vector3));
			RSetTRS_Vector3_Quaternion_Vector3 = new RMethod(this, "SetTRS", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Vector3));
			RInverse3DAffine_Matrix4x4_Ref_Matrix4x4 = new RMethod(this, "Inverse3DAffine", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Matrix4x4).MakeByRefType());
			RInverse_Matrix4x4 = new RMethod(this, "Inverse", 0, typeof(UnityEngine.Matrix4x4));
			RTranspose_Matrix4x4 = new RMethod(this, "Transpose", 0, typeof(UnityEngine.Matrix4x4));
			ROrtho_Single_Single_Single_Single_Single_Single = new RMethod(this, "Ortho", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single));
			RPerspective_Single_Single_Single_Single = new RMethod(this, "Perspective", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single));
			RLookAt_Vector3_Vector3_Vector3 = new RMethod(this, "LookAt", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
			RFrustum_Single_Single_Single_Single_Single_Single = new RMethod(this, "Frustum", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single));
			RFrustum_FrustumPlanes = new RMethod(this, "Frustum", 0, typeof(UnityEngine.FrustumPlanes));
			RGetHashCode = new RMethod(this, "GetHashCode", 0);
			REquals_Object = new RMethod(this, "Equals", 0, typeof(System.Object));
			REquals_Matrix4x4 = new RMethod(this, "Equals", 0, typeof(UnityEngine.Matrix4x4));
			Rop_Multiply_Matrix4x4_Matrix4x4 = new RMethod(this, "op_Multiply", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Matrix4x4));
			Rop_Multiply_Matrix4x4_Vector4 = new RMethod(this, "op_Multiply", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Vector4));
			Rop_Equality_Matrix4x4_Matrix4x4 = new RMethod(this, "op_Equality", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Matrix4x4));
			Rop_Inequality_Matrix4x4_Matrix4x4 = new RMethod(this, "op_Inequality", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Matrix4x4));
			RGetColumn_Int32 = new RMethod(this, "GetColumn", 0, typeof(System.Int32));
			RGetRow_Int32 = new RMethod(this, "GetRow", 0, typeof(System.Int32));
			RGetPosition = new RMethod(this, "GetPosition", 0);
			RSetColumn_Int32_Vector4 = new RMethod(this, "SetColumn", 0, typeof(System.Int32), typeof(UnityEngine.Vector4));
			RSetRow_Int32_Vector4 = new RMethod(this, "SetRow", 0, typeof(System.Int32), typeof(UnityEngine.Vector4));
			RMultiplyPoint_Vector3 = new RMethod(this, "MultiplyPoint", 0, typeof(UnityEngine.Vector3));
			RMultiplyPoint3x4_Vector3 = new RMethod(this, "MultiplyPoint3x4", 0, typeof(UnityEngine.Vector3));
			RMultiplyVector_Vector3 = new RMethod(this, "MultiplyVector", 0, typeof(UnityEngine.Vector3));
			RTransformPlane_Plane = new RMethod(this, "TransformPlane", 0, typeof(UnityEngine.Plane));
			RScale_Vector3 = new RMethod(this, "Scale", 0, typeof(UnityEngine.Vector3));
			RTranslate_Vector3 = new RMethod(this, "Translate", 0, typeof(UnityEngine.Vector3));
			RRotate_Quaternion = new RMethod(this, "Rotate", 0, typeof(UnityEngine.Quaternion));
			RToString = new RMethod(this, "ToString", 0);
			RToString_String = new RMethod(this, "ToString", 0, typeof(System.String));
			RToString_String_IFormatProvider = new RMethod(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
			RGetRotation_Injected_Ref_Matrix4x4_Out_Quaternion = new RMethod(this, "GetRotation_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType());
			RGetLossyScale_Injected_Ref_Matrix4x4_Out_Vector3 = new RMethod(this, "GetLossyScale_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
			RIsIdentity_Injected_Ref_Matrix4x4 = new RMethod(this, "IsIdentity_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
			RGetDeterminant_Injected_Ref_Matrix4x4 = new RMethod(this, "GetDeterminant_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
			RDecomposeProjection_Injected_Ref_Matrix4x4_Out_FrustumPlanes = new RMethod(this, "DecomposeProjection_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.FrustumPlanes).MakeByRefType());
			RValidTRS_Injected_Ref_Matrix4x4 = new RMethod(this, "ValidTRS_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
			RTRS_Injected_Ref_Vector3_Ref_Quaternion_Ref_Vector3_Out_Matrix4x4 = new RMethod(this, "TRS_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Matrix4x4).MakeByRefType());
			RInverse3DAffine_Injected_Ref_Matrix4x4_Ref_Matrix4x4 = new RMethod(this, "Inverse3DAffine_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Matrix4x4).MakeByRefType());
			RInverse_Injected_Ref_Matrix4x4_Out_Matrix4x4 = new RMethod(this, "Inverse_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Matrix4x4).MakeByRefType());
			RTranspose_Injected_Ref_Matrix4x4_Out_Matrix4x4 = new RMethod(this, "Transpose_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Matrix4x4).MakeByRefType());
			ROrtho_Injected_Single_Single_Single_Single_Single_Single_Out_Matrix4x4 = new RMethod(this, "Ortho_Injected", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.Matrix4x4).MakeByRefType());
			RPerspective_Injected_Single_Single_Single_Single_Out_Matrix4x4 = new RMethod(this, "Perspective_Injected", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.Matrix4x4).MakeByRefType());
			RLookAt_Injected_Ref_Vector3_Ref_Vector3_Ref_Vector3_Out_Matrix4x4 = new RMethod(this, "LookAt_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Matrix4x4).MakeByRefType());
			RFrustum_Injected_Single_Single_Single_Single_Single_Single_Out_Matrix4x4 = new RMethod(this, "Frustum_Injected", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.Matrix4x4).MakeByRefType());
			RFinalize = new RMethod(this, "Finalize", 0);
			RGetType = new RMethod(this, "GetType", 0);
			RMemberwiseClone = new RMethod(this, "MemberwiseClone", 0);

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
