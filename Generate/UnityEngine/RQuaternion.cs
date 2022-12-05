using SMFrame.Editor.Refleaction.RUnityEngine;
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
    public partial class RQuaternion : Member
    {
		public  Property Item_Int32; //System.Single
		public static RQuaternion identity; //UnityEngine.Quaternion
		public  RVector3 eulerAngles; //UnityEngine.Vector3
		public  RQuaternion normalized; //UnityEngine.Quaternion
		public  Field x; //System.Single
		public  Field y; //System.Single
		public  Field z; //System.Single
		public  Field w; //System.Single
		public static RQuaternion identityQuaternion; //UnityEngine.Quaternion
		public static Field kEpsilon; //System.Single
		public static Method RFromToRotation_Vector3_Vector3; //UnityEngine.Quaternion FromToRotation(UnityEngine.Vector3, UnityEngine.Vector3)
		public static Method RInverse_Quaternion; //UnityEngine.Quaternion Inverse(UnityEngine.Quaternion)
		public static Method RSlerp_Quaternion_Quaternion_Single; //UnityEngine.Quaternion Slerp(UnityEngine.Quaternion, UnityEngine.Quaternion, Single)
		public static Method RSlerpUnclamped_Quaternion_Quaternion_Single; //UnityEngine.Quaternion SlerpUnclamped(UnityEngine.Quaternion, UnityEngine.Quaternion, Single)
		public static Method RLerp_Quaternion_Quaternion_Single; //UnityEngine.Quaternion Lerp(UnityEngine.Quaternion, UnityEngine.Quaternion, Single)
		public static Method RLerpUnclamped_Quaternion_Quaternion_Single; //UnityEngine.Quaternion LerpUnclamped(UnityEngine.Quaternion, UnityEngine.Quaternion, Single)
		public static Method RInternal_FromEulerRad_Vector3; //UnityEngine.Quaternion Internal_FromEulerRad(UnityEngine.Vector3)
		public static Method RInternal_ToEulerRad_Quaternion; //UnityEngine.Vector3 Internal_ToEulerRad(UnityEngine.Quaternion)
		public static Method RInternal_ToAxisAngleRad_Quaternion_Out_Vector3_Out_Single; //Void Internal_ToAxisAngleRad(UnityEngine.Quaternion, UnityEngine.Vector3 ByRef, Single ByRef)
		public static Method RAngleAxis_Single_Vector3; //UnityEngine.Quaternion AngleAxis(Single, UnityEngine.Vector3)
		public static Method RLookRotation_Vector3_Vector3; //UnityEngine.Quaternion LookRotation(UnityEngine.Vector3, UnityEngine.Vector3)
		public static Method RLookRotation_Vector3; //UnityEngine.Quaternion LookRotation(UnityEngine.Vector3)
		public  Method RSet_Single_Single_Single_Single; //Void Set(Single, Single, Single, Single)
		public static Method Rop_Multiply_Quaternion_Quaternion; //UnityEngine.Quaternion op_Multiply(UnityEngine.Quaternion, UnityEngine.Quaternion)
		public static Method Rop_Multiply_Quaternion_Vector3; //UnityEngine.Vector3 op_Multiply(UnityEngine.Quaternion, UnityEngine.Vector3)
		public static Method RIsEqualUsingDot_Single; //Boolean IsEqualUsingDot(Single)
		public static Method Rop_Equality_Quaternion_Quaternion; //Boolean op_Equality(UnityEngine.Quaternion, UnityEngine.Quaternion)
		public static Method Rop_Inequality_Quaternion_Quaternion; //Boolean op_Inequality(UnityEngine.Quaternion, UnityEngine.Quaternion)
		public static Method RDot_Quaternion_Quaternion; //Single Dot(UnityEngine.Quaternion, UnityEngine.Quaternion)
		public  Method RSetLookRotation_Vector3; //Void SetLookRotation(UnityEngine.Vector3)
		public  Method RSetLookRotation_Vector3_Vector3; //Void SetLookRotation(UnityEngine.Vector3, UnityEngine.Vector3)
		public static Method RAngle_Quaternion_Quaternion; //Single Angle(UnityEngine.Quaternion, UnityEngine.Quaternion)
		public static Method RInternal_MakePositive_Vector3; //UnityEngine.Vector3 Internal_MakePositive(UnityEngine.Vector3)
		public static Method REuler_Single_Single_Single; //UnityEngine.Quaternion Euler(Single, Single, Single)
		public static Method REuler_Vector3; //UnityEngine.Quaternion Euler(UnityEngine.Vector3)
		public  Method RToAngleAxis_Out_Single_Out_Vector3; //Void ToAngleAxis(Single ByRef, UnityEngine.Vector3 ByRef)
		public  Method RSetFromToRotation_Vector3_Vector3; //Void SetFromToRotation(UnityEngine.Vector3, UnityEngine.Vector3)
		public static Method RRotateTowards_Quaternion_Quaternion_Single; //UnityEngine.Quaternion RotateTowards(UnityEngine.Quaternion, UnityEngine.Quaternion, Single)
		public static Method RNormalize_Quaternion; //UnityEngine.Quaternion Normalize(UnityEngine.Quaternion)
		public  Method RNormalize; //Void Normalize()
		public  Method RGetHashCode; //Int32 GetHashCode()
		public  Method REquals_Object; //Boolean Equals(System.Object)
		public  Method REquals_Quaternion; //Boolean Equals(UnityEngine.Quaternion)
		public  Method RToString; //System.String ToString()
		public  Method RToString_String; //System.String ToString(System.String)
		public  Method RToString_String_IFormatProvider; //System.String ToString(System.String, System.IFormatProvider)
		public static Method REulerRotation_Single_Single_Single; //UnityEngine.Quaternion EulerRotation(Single, Single, Single)
		public static Method REulerRotation_Vector3; //UnityEngine.Quaternion EulerRotation(UnityEngine.Vector3)
		public  Method RSetEulerRotation_Single_Single_Single; //Void SetEulerRotation(Single, Single, Single)
		public  Method RSetEulerRotation_Vector3; //Void SetEulerRotation(UnityEngine.Vector3)
		public  Method RToEuler; //UnityEngine.Vector3 ToEuler()
		public static Method REulerAngles_Single_Single_Single; //UnityEngine.Quaternion EulerAngles(Single, Single, Single)
		public static Method REulerAngles_Vector3; //UnityEngine.Quaternion EulerAngles(UnityEngine.Vector3)
		public  Method RToAxisAngle_Out_Vector3_Out_Single; //Void ToAxisAngle(UnityEngine.Vector3 ByRef, Single ByRef)
		public  Method RSetEulerAngles_Single_Single_Single; //Void SetEulerAngles(Single, Single, Single)
		public  Method RSetEulerAngles_Vector3; //Void SetEulerAngles(UnityEngine.Vector3)
		public static Method RToEulerAngles_Quaternion; //UnityEngine.Vector3 ToEulerAngles(UnityEngine.Quaternion)
		public  Method RToEulerAngles; //UnityEngine.Vector3 ToEulerAngles()
		public  Method RSetAxisAngle_Vector3_Single; //Void SetAxisAngle(UnityEngine.Vector3, Single)
		public static Method RAxisAngle_Vector3_Single; //UnityEngine.Quaternion AxisAngle(UnityEngine.Vector3, Single)
		public static Method RFromToRotation_Injected_Ref_Vector3_Ref_Vector3_Out_Quaternion; //Void FromToRotation_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef, UnityEngine.Quaternion ByRef)
		public static Method RInverse_Injected_Ref_Quaternion_Out_Quaternion; //Void Inverse_Injected(UnityEngine.Quaternion ByRef, UnityEngine.Quaternion ByRef)
		public static Method RSlerp_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion; //Void Slerp_Injected(UnityEngine.Quaternion ByRef, UnityEngine.Quaternion ByRef, Single, UnityEngine.Quaternion ByRef)
		public static Method RSlerpUnclamped_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion; //Void SlerpUnclamped_Injected(UnityEngine.Quaternion ByRef, UnityEngine.Quaternion ByRef, Single, UnityEngine.Quaternion ByRef)
		public static Method RLerp_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion; //Void Lerp_Injected(UnityEngine.Quaternion ByRef, UnityEngine.Quaternion ByRef, Single, UnityEngine.Quaternion ByRef)
		public static Method RLerpUnclamped_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion; //Void LerpUnclamped_Injected(UnityEngine.Quaternion ByRef, UnityEngine.Quaternion ByRef, Single, UnityEngine.Quaternion ByRef)
		public static Method RInternal_FromEulerRad_Injected_Ref_Vector3_Out_Quaternion; //Void Internal_FromEulerRad_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Quaternion ByRef)
		public static Method RInternal_ToEulerRad_Injected_Ref_Quaternion_Out_Vector3; //Void Internal_ToEulerRad_Injected(UnityEngine.Quaternion ByRef, UnityEngine.Vector3 ByRef)
		public static Method RInternal_ToAxisAngleRad_Injected_Ref_Quaternion_Out_Vector3_Out_Single; //Void Internal_ToAxisAngleRad_Injected(UnityEngine.Quaternion ByRef, UnityEngine.Vector3 ByRef, Single ByRef)
		public static Method RAngleAxis_Injected_Single_Ref_Vector3_Out_Quaternion; //Void AngleAxis_Injected(Single, UnityEngine.Vector3 ByRef, UnityEngine.Quaternion ByRef)
		public static Method RLookRotation_Injected_Ref_Vector3_Ref_Vector3_Out_Quaternion; //Void LookRotation_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef, UnityEngine.Quaternion ByRef)
		public  Method RFinalize; //Void Finalize()
		public  Method RGetType; //System.Type GetType()
		public  Method RMemberwiseClone; //System.Object MemberwiseClone()


        public RQuaternion() : base("UnityEngine.Quaternion")
        {
            NewMembers();
        }

        public RQuaternion(System.Object instance) : base("UnityEngine.Quaternion")
		{
			NewMembers();
            SetInstance(instance);
		}

        public RQuaternion(Member belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
            NewMembers();
	    }

        private void NewMembers()
        {
			Item_Int32 = new Property(this, "Item", -1, typeof(System.Int32));
			identity = new RQuaternion(this, "identity", -1);
			eulerAngles = new RVector3(this, "eulerAngles", -1);
			normalized = new RQuaternion(this, "normalized", -1);
			x = new Field(this, "x");
			y = new Field(this, "y");
			z = new Field(this, "z");
			w = new Field(this, "w");
			identityQuaternion = new RQuaternion(this, "identityQuaternion");
			kEpsilon = new Field(this, "kEpsilon");
			RFromToRotation_Vector3_Vector3 = new Method(this, "FromToRotation", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
			RInverse_Quaternion = new Method(this, "Inverse", 0, typeof(UnityEngine.Quaternion));
			RSlerp_Quaternion_Quaternion_Single = new Method(this, "Slerp", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion), typeof(System.Single));
			RSlerpUnclamped_Quaternion_Quaternion_Single = new Method(this, "SlerpUnclamped", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion), typeof(System.Single));
			RLerp_Quaternion_Quaternion_Single = new Method(this, "Lerp", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion), typeof(System.Single));
			RLerpUnclamped_Quaternion_Quaternion_Single = new Method(this, "LerpUnclamped", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion), typeof(System.Single));
			RInternal_FromEulerRad_Vector3 = new Method(this, "Internal_FromEulerRad", 0, typeof(UnityEngine.Vector3));
			RInternal_ToEulerRad_Quaternion = new Method(this, "Internal_ToEulerRad", 0, typeof(UnityEngine.Quaternion));
			RInternal_ToAxisAngleRad_Quaternion_Out_Vector3_Out_Single = new Method(this, "Internal_ToAxisAngleRad", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single).MakeByRefType());
			RAngleAxis_Single_Vector3 = new Method(this, "AngleAxis", 0, typeof(System.Single), typeof(UnityEngine.Vector3));
			RLookRotation_Vector3_Vector3 = new Method(this, "LookRotation", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
			RLookRotation_Vector3 = new Method(this, "LookRotation", 0, typeof(UnityEngine.Vector3));
			RSet_Single_Single_Single_Single = new Method(this, "Set", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single));
			Rop_Multiply_Quaternion_Quaternion = new Method(this, "op_Multiply", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion));
			Rop_Multiply_Quaternion_Vector3 = new Method(this, "op_Multiply", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Vector3));
			RIsEqualUsingDot_Single = new Method(this, "IsEqualUsingDot", 0, typeof(System.Single));
			Rop_Equality_Quaternion_Quaternion = new Method(this, "op_Equality", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion));
			Rop_Inequality_Quaternion_Quaternion = new Method(this, "op_Inequality", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion));
			RDot_Quaternion_Quaternion = new Method(this, "Dot", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion));
			RSetLookRotation_Vector3 = new Method(this, "SetLookRotation", 0, typeof(UnityEngine.Vector3));
			RSetLookRotation_Vector3_Vector3 = new Method(this, "SetLookRotation", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
			RAngle_Quaternion_Quaternion = new Method(this, "Angle", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion));
			RInternal_MakePositive_Vector3 = new Method(this, "Internal_MakePositive", 0, typeof(UnityEngine.Vector3));
			REuler_Single_Single_Single = new Method(this, "Euler", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
			REuler_Vector3 = new Method(this, "Euler", 0, typeof(UnityEngine.Vector3));
			RToAngleAxis_Out_Single_Out_Vector3 = new Method(this, "ToAngleAxis", 0, typeof(System.Single).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
			RSetFromToRotation_Vector3_Vector3 = new Method(this, "SetFromToRotation", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
			RRotateTowards_Quaternion_Quaternion_Single = new Method(this, "RotateTowards", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion), typeof(System.Single));
			RNormalize_Quaternion = new Method(this, "Normalize", 0, typeof(UnityEngine.Quaternion));
			RNormalize = new Method(this, "Normalize", 0);
			RGetHashCode = new Method(this, "GetHashCode", 0);
			REquals_Object = new Method(this, "Equals", 0, typeof(System.Object));
			REquals_Quaternion = new Method(this, "Equals", 0, typeof(UnityEngine.Quaternion));
			RToString = new Method(this, "ToString", 0);
			RToString_String = new Method(this, "ToString", 0, typeof(System.String));
			RToString_String_IFormatProvider = new Method(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
			REulerRotation_Single_Single_Single = new Method(this, "EulerRotation", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
			REulerRotation_Vector3 = new Method(this, "EulerRotation", 0, typeof(UnityEngine.Vector3));
			RSetEulerRotation_Single_Single_Single = new Method(this, "SetEulerRotation", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
			RSetEulerRotation_Vector3 = new Method(this, "SetEulerRotation", 0, typeof(UnityEngine.Vector3));
			RToEuler = new Method(this, "ToEuler", 0);
			REulerAngles_Single_Single_Single = new Method(this, "EulerAngles", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
			REulerAngles_Vector3 = new Method(this, "EulerAngles", 0, typeof(UnityEngine.Vector3));
			RToAxisAngle_Out_Vector3_Out_Single = new Method(this, "ToAxisAngle", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single).MakeByRefType());
			RSetEulerAngles_Single_Single_Single = new Method(this, "SetEulerAngles", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
			RSetEulerAngles_Vector3 = new Method(this, "SetEulerAngles", 0, typeof(UnityEngine.Vector3));
			RToEulerAngles_Quaternion = new Method(this, "ToEulerAngles", 0, typeof(UnityEngine.Quaternion));
			RToEulerAngles = new Method(this, "ToEulerAngles", 0);
			RSetAxisAngle_Vector3_Single = new Method(this, "SetAxisAngle", 0, typeof(UnityEngine.Vector3), typeof(System.Single));
			RAxisAngle_Vector3_Single = new Method(this, "AxisAngle", 0, typeof(UnityEngine.Vector3), typeof(System.Single));
			RFromToRotation_Injected_Ref_Vector3_Ref_Vector3_Out_Quaternion = new Method(this, "FromToRotation_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType());
			RInverse_Injected_Ref_Quaternion_Out_Quaternion = new Method(this, "Inverse_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType());
			RSlerp_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion = new Method(this, "Slerp_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(System.Single), typeof(UnityEngine.Quaternion).MakeByRefType());
			RSlerpUnclamped_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion = new Method(this, "SlerpUnclamped_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(System.Single), typeof(UnityEngine.Quaternion).MakeByRefType());
			RLerp_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion = new Method(this, "Lerp_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(System.Single), typeof(UnityEngine.Quaternion).MakeByRefType());
			RLerpUnclamped_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion = new Method(this, "LerpUnclamped_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(System.Single), typeof(UnityEngine.Quaternion).MakeByRefType());
			RInternal_FromEulerRad_Injected_Ref_Vector3_Out_Quaternion = new Method(this, "Internal_FromEulerRad_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType());
			RInternal_ToEulerRad_Injected_Ref_Quaternion_Out_Vector3 = new Method(this, "Internal_ToEulerRad_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
			RInternal_ToAxisAngleRad_Injected_Ref_Quaternion_Out_Vector3_Out_Single = new Method(this, "Internal_ToAxisAngleRad_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single).MakeByRefType());
			RAngleAxis_Injected_Single_Ref_Vector3_Out_Quaternion = new Method(this, "AngleAxis_Injected", 0, typeof(System.Single), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType());
			RLookRotation_Injected_Ref_Vector3_Ref_Vector3_Out_Quaternion = new Method(this, "LookRotation_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType());
			RFinalize = new Method(this, "Finalize", 0);
			RGetType = new Method(this, "GetType", 0);
			RMemberwiseClone = new Method(this, "MemberwiseClone", 0);

        }

        public static UnityEngine.Quaternion FromToRotation(UnityEngine.Vector3  @fromDirection, UnityEngine.Vector3  @toDirection)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromDirection, @toDirection};
            var ___result = RFromToRotation_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }

        public static UnityEngine.Quaternion Inverse(UnityEngine.Quaternion  @rotation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rotation};
            var ___result = RInverse_Quaternion.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }

        public static UnityEngine.Quaternion Slerp(UnityEngine.Quaternion  @a, UnityEngine.Quaternion  @b, System.Single  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RSlerp_Quaternion_Quaternion_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }

        public static UnityEngine.Quaternion SlerpUnclamped(UnityEngine.Quaternion  @a, UnityEngine.Quaternion  @b, System.Single  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RSlerpUnclamped_Quaternion_Quaternion_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }

        public static UnityEngine.Quaternion Lerp(UnityEngine.Quaternion  @a, UnityEngine.Quaternion  @b, System.Single  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RLerp_Quaternion_Quaternion_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }

        public static UnityEngine.Quaternion LerpUnclamped(UnityEngine.Quaternion  @a, UnityEngine.Quaternion  @b, System.Single  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RLerpUnclamped_Quaternion_Quaternion_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }

        public static UnityEngine.Quaternion Internal_FromEulerRad(UnityEngine.Vector3  @euler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@euler};
            var ___result = RInternal_FromEulerRad_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }

        public static UnityEngine.Vector3 Internal_ToEulerRad(UnityEngine.Quaternion  @rotation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rotation};
            var ___result = RInternal_ToEulerRad_Quaternion.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }

        public static void Internal_ToAxisAngleRad(UnityEngine.Quaternion  @q, out UnityEngine.Vector3  @axis, out System.Single  @angle)
        {
			axis = default;
			angle = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@q, @axis, @angle};
            var ___result = RInternal_ToAxisAngleRad_Quaternion_Out_Vector3_Out_Single.Invoke(___genericsType, ___parameters);
			axis = (UnityEngine.Vector3)___parameters[1];
			angle = (System.Single)___parameters[2];

            
        }

        public static UnityEngine.Quaternion AngleAxis(System.Single  @angle, UnityEngine.Vector3  @axis)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@angle, @axis};
            var ___result = RAngleAxis_Single_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }

        public static UnityEngine.Quaternion LookRotation(UnityEngine.Vector3  @forward, UnityEngine.Vector3  @upwards)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@forward, @upwards};
            var ___result = RLookRotation_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }

        public static UnityEngine.Quaternion LookRotation(UnityEngine.Vector3  @forward)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@forward};
            var ___result = RLookRotation_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }

        public virtual void Set(System.Single  @newX, System.Single  @newY, System.Single  @newZ, System.Single  @newW)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newX, @newY, @newZ, @newW};
            var ___result = RSet_Single_Single_Single_Single.Invoke(___genericsType, ___parameters);

            
        }

        public static UnityEngine.Quaternion op_Multiply(UnityEngine.Quaternion  @lhs, UnityEngine.Quaternion  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Multiply_Quaternion_Quaternion.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }

        public static UnityEngine.Vector3 op_Multiply(UnityEngine.Quaternion  @rotation, UnityEngine.Vector3  @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rotation, @point};
            var ___result = Rop_Multiply_Quaternion_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }

        public static System.Boolean IsEqualUsingDot(System.Single  @dot)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dot};
            var ___result = RIsEqualUsingDot_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }

        public static System.Boolean op_Equality(UnityEngine.Quaternion  @lhs, UnityEngine.Quaternion  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_Quaternion_Quaternion.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }

        public static System.Boolean op_Inequality(UnityEngine.Quaternion  @lhs, UnityEngine.Quaternion  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_Quaternion_Quaternion.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }

        public static System.Single Dot(UnityEngine.Quaternion  @a, UnityEngine.Quaternion  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RDot_Quaternion_Quaternion.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }

        public virtual void SetLookRotation(UnityEngine.Vector3  @view)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@view};
            var ___result = RSetLookRotation_Vector3.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void SetLookRotation(UnityEngine.Vector3  @view, UnityEngine.Vector3  @up)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@view, @up};
            var ___result = RSetLookRotation_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            
        }

        public static System.Single Angle(UnityEngine.Quaternion  @a, UnityEngine.Quaternion  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RAngle_Quaternion_Quaternion.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }

        public static UnityEngine.Vector3 Internal_MakePositive(UnityEngine.Vector3  @euler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@euler};
            var ___result = RInternal_MakePositive_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }

        public static UnityEngine.Quaternion Euler(System.Single  @x, System.Single  @y, System.Single  @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = REuler_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }

        public static UnityEngine.Quaternion Euler(UnityEngine.Vector3  @euler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@euler};
            var ___result = REuler_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }

        public virtual void ToAngleAxis(out System.Single  @angle, out UnityEngine.Vector3  @axis)
        {
			angle = default;
			axis = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@angle, @axis};
            var ___result = RToAngleAxis_Out_Single_Out_Vector3.Invoke(___genericsType, ___parameters);
			angle = (System.Single)___parameters[0];
			axis = (UnityEngine.Vector3)___parameters[1];

            
        }

        public virtual void SetFromToRotation(UnityEngine.Vector3  @fromDirection, UnityEngine.Vector3  @toDirection)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromDirection, @toDirection};
            var ___result = RSetFromToRotation_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            
        }

        public static UnityEngine.Quaternion RotateTowards(UnityEngine.Quaternion  @from, UnityEngine.Quaternion  @to, System.Single  @maxDegreesDelta)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @maxDegreesDelta};
            var ___result = RRotateTowards_Quaternion_Quaternion_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }

        public static UnityEngine.Quaternion Normalize(UnityEngine.Quaternion  @q)
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

        public virtual System.Boolean Equals(System.Object  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }

        public virtual System.Boolean Equals(UnityEngine.Quaternion  @other)
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

        public static UnityEngine.Quaternion EulerRotation(System.Single  @x, System.Single  @y, System.Single  @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = REulerRotation_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }

        public static UnityEngine.Quaternion EulerRotation(UnityEngine.Vector3  @euler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@euler};
            var ___result = REulerRotation_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }

        public virtual void SetEulerRotation(System.Single  @x, System.Single  @y, System.Single  @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = RSetEulerRotation_Single_Single_Single.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void SetEulerRotation(UnityEngine.Vector3  @euler)
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

        public static UnityEngine.Quaternion EulerAngles(System.Single  @x, System.Single  @y, System.Single  @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = REulerAngles_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }

        public static UnityEngine.Quaternion EulerAngles(UnityEngine.Vector3  @euler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@euler};
            var ___result = REulerAngles_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }

        public virtual void ToAxisAngle(out UnityEngine.Vector3  @axis, out System.Single  @angle)
        {
			axis = default;
			angle = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@axis, @angle};
            var ___result = RToAxisAngle_Out_Vector3_Out_Single.Invoke(___genericsType, ___parameters);
			axis = (UnityEngine.Vector3)___parameters[0];
			angle = (System.Single)___parameters[1];

            
        }

        public virtual void SetEulerAngles(System.Single  @x, System.Single  @y, System.Single  @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = RSetEulerAngles_Single_Single_Single.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void SetEulerAngles(UnityEngine.Vector3  @euler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@euler};
            var ___result = RSetEulerAngles_Vector3.Invoke(___genericsType, ___parameters);

            
        }

        public static UnityEngine.Vector3 ToEulerAngles(UnityEngine.Quaternion  @rotation)
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

        public virtual void SetAxisAngle(UnityEngine.Vector3  @axis, System.Single  @angle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@axis, @angle};
            var ___result = RSetAxisAngle_Vector3_Single.Invoke(___genericsType, ___parameters);

            
        }

        public static UnityEngine.Quaternion AxisAngle(UnityEngine.Vector3  @axis, System.Single  @angle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@axis, @angle};
            var ___result = RAxisAngle_Vector3_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }

        public static void FromToRotation_Injected(ref UnityEngine.Vector3  @fromDirection, ref UnityEngine.Vector3  @toDirection, out UnityEngine.Quaternion  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromDirection, @toDirection, @ret};
            var ___result = RFromToRotation_Injected_Ref_Vector3_Ref_Vector3_Out_Quaternion.Invoke(___genericsType, ___parameters);
			fromDirection = (UnityEngine.Vector3)___parameters[0];
			toDirection = (UnityEngine.Vector3)___parameters[1];
			ret = (UnityEngine.Quaternion)___parameters[2];

            
        }

        public static void Inverse_Injected(ref UnityEngine.Quaternion  @rotation, out UnityEngine.Quaternion  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rotation, @ret};
            var ___result = RInverse_Injected_Ref_Quaternion_Out_Quaternion.Invoke(___genericsType, ___parameters);
			rotation = (UnityEngine.Quaternion)___parameters[0];
			ret = (UnityEngine.Quaternion)___parameters[1];

            
        }

        public static void Slerp_Injected(ref UnityEngine.Quaternion  @a, ref UnityEngine.Quaternion  @b, System.Single  @t, out UnityEngine.Quaternion  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t, @ret};
            var ___result = RSlerp_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion.Invoke(___genericsType, ___parameters);
			a = (UnityEngine.Quaternion)___parameters[0];
			b = (UnityEngine.Quaternion)___parameters[1];
			ret = (UnityEngine.Quaternion)___parameters[3];

            
        }

        public static void SlerpUnclamped_Injected(ref UnityEngine.Quaternion  @a, ref UnityEngine.Quaternion  @b, System.Single  @t, out UnityEngine.Quaternion  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t, @ret};
            var ___result = RSlerpUnclamped_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion.Invoke(___genericsType, ___parameters);
			a = (UnityEngine.Quaternion)___parameters[0];
			b = (UnityEngine.Quaternion)___parameters[1];
			ret = (UnityEngine.Quaternion)___parameters[3];

            
        }

        public static void Lerp_Injected(ref UnityEngine.Quaternion  @a, ref UnityEngine.Quaternion  @b, System.Single  @t, out UnityEngine.Quaternion  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t, @ret};
            var ___result = RLerp_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion.Invoke(___genericsType, ___parameters);
			a = (UnityEngine.Quaternion)___parameters[0];
			b = (UnityEngine.Quaternion)___parameters[1];
			ret = (UnityEngine.Quaternion)___parameters[3];

            
        }

        public static void LerpUnclamped_Injected(ref UnityEngine.Quaternion  @a, ref UnityEngine.Quaternion  @b, System.Single  @t, out UnityEngine.Quaternion  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t, @ret};
            var ___result = RLerpUnclamped_Injected_Ref_Quaternion_Ref_Quaternion_Single_Out_Quaternion.Invoke(___genericsType, ___parameters);
			a = (UnityEngine.Quaternion)___parameters[0];
			b = (UnityEngine.Quaternion)___parameters[1];
			ret = (UnityEngine.Quaternion)___parameters[3];

            
        }

        public static void Internal_FromEulerRad_Injected(ref UnityEngine.Vector3  @euler, out UnityEngine.Quaternion  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@euler, @ret};
            var ___result = RInternal_FromEulerRad_Injected_Ref_Vector3_Out_Quaternion.Invoke(___genericsType, ___parameters);
			euler = (UnityEngine.Vector3)___parameters[0];
			ret = (UnityEngine.Quaternion)___parameters[1];

            
        }

        public static void Internal_ToEulerRad_Injected(ref UnityEngine.Quaternion  @rotation, out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rotation, @ret};
            var ___result = RInternal_ToEulerRad_Injected_Ref_Quaternion_Out_Vector3.Invoke(___genericsType, ___parameters);
			rotation = (UnityEngine.Quaternion)___parameters[0];
			ret = (UnityEngine.Vector3)___parameters[1];

            
        }

        public static void Internal_ToAxisAngleRad_Injected(ref UnityEngine.Quaternion  @q, out UnityEngine.Vector3  @axis, out System.Single  @angle)
        {
			axis = default;
			angle = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@q, @axis, @angle};
            var ___result = RInternal_ToAxisAngleRad_Injected_Ref_Quaternion_Out_Vector3_Out_Single.Invoke(___genericsType, ___parameters);
			q = (UnityEngine.Quaternion)___parameters[0];
			axis = (UnityEngine.Vector3)___parameters[1];
			angle = (System.Single)___parameters[2];

            
        }

        public static void AngleAxis_Injected(System.Single  @angle, ref UnityEngine.Vector3  @axis, out UnityEngine.Quaternion  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@angle, @axis, @ret};
            var ___result = RAngleAxis_Injected_Single_Ref_Vector3_Out_Quaternion.Invoke(___genericsType, ___parameters);
			axis = (UnityEngine.Vector3)___parameters[1];
			ret = (UnityEngine.Quaternion)___parameters[2];

            
        }

        public static void LookRotation_Injected(ref UnityEngine.Vector3  @forward, ref UnityEngine.Vector3  @upwards, out UnityEngine.Quaternion  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@forward, @upwards, @ret};
            var ___result = RLookRotation_Injected_Ref_Vector3_Ref_Vector3_Out_Quaternion.Invoke(___genericsType, ___parameters);
			forward = (UnityEngine.Vector3)___parameters[0];
			upwards = (UnityEngine.Vector3)___parameters[1];
			ret = (UnityEngine.Quaternion)___parameters[2];

            
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
