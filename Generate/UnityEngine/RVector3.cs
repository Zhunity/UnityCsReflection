using SMFrame.Editor.Refleaction.RUnityEngine;
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
    public partial class RVector3 : Member
    {

        private RVector3 m_rVector3;
        public RVector3 normalized //UnityEngine.Vector3
        {
            get
            {
                if(m_rVector3 == null)
                {
					m_rVector3 = new RVector3(this, "normalized", -1);
                    m_rVector3.SetBelong(this.instance);
				}
                return m_rVector3;

			}
        }



		public static Field kEpsilon; //System.Single
		public static Field kEpsilonNormalSqrt; //System.Single
		public  Field x; //System.Single
		public  Field y; //System.Single
		public  Field z; //System.Single
	
		public static Method RSlerp_Vector3_Vector3_Single; //UnityEngine.Vector3 Slerp(UnityEngine.Vector3, UnityEngine.Vector3, Single)
		public static Method RSlerpUnclamped_Vector3_Vector3_Single; //UnityEngine.Vector3 SlerpUnclamped(UnityEngine.Vector3, UnityEngine.Vector3, Single)
		public static Method ROrthoNormalize2_Ref_Vector3_Ref_Vector3; //Void OrthoNormalize2(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		public static Method ROrthoNormalize_Ref_Vector3_Ref_Vector3; //Void OrthoNormalize(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		public static Method ROrthoNormalize3_Ref_Vector3_Ref_Vector3_Ref_Vector3; //Void OrthoNormalize3(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		public static Method ROrthoNormalize_Ref_Vector3_Ref_Vector3_Ref_Vector3; //Void OrthoNormalize(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		public static Method RRotateTowards_Vector3_Vector3_Single_Single; //UnityEngine.Vector3 RotateTowards(UnityEngine.Vector3, UnityEngine.Vector3, Single, Single)
		public static Method RLerp_Vector3_Vector3_Single; //UnityEngine.Vector3 Lerp(UnityEngine.Vector3, UnityEngine.Vector3, Single)
		public static Method RLerpUnclamped_Vector3_Vector3_Single; //UnityEngine.Vector3 LerpUnclamped(UnityEngine.Vector3, UnityEngine.Vector3, Single)
		public static Method RMoveTowards_Vector3_Vector3_Single; //UnityEngine.Vector3 MoveTowards(UnityEngine.Vector3, UnityEngine.Vector3, Single)
		public static Method RSmoothDamp_Vector3_Vector3_Ref_Vector3_Single_Single; //UnityEngine.Vector3 SmoothDamp(UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3 ByRef, Single, Single)
		public static Method RSmoothDamp_Vector3_Vector3_Ref_Vector3_Single; //UnityEngine.Vector3 SmoothDamp(UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3 ByRef, Single)
		public static Method RSmoothDamp_Vector3_Vector3_Ref_Vector3_Single_Single_Single; //UnityEngine.Vector3 SmoothDamp(UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3 ByRef, Single, Single, Single)
		public  Method RSet_Single_Single_Single; //Void Set(Single, Single, Single)
		public static Method RScale_Vector3_Vector3; //UnityEngine.Vector3 Scale(UnityEngine.Vector3, UnityEngine.Vector3)
		public  Method RScale_Vector3; //Void Scale(UnityEngine.Vector3)
		public static Method RCross_Vector3_Vector3; //UnityEngine.Vector3 Cross(UnityEngine.Vector3, UnityEngine.Vector3)
		public  Method RGetHashCode; //Int32 GetHashCode()
		public  Method REquals_Object; //Boolean Equals(System.Object)
		public  Method REquals_Vector3; //Boolean Equals(UnityEngine.Vector3)
		public static Method RReflect_Vector3_Vector3; //UnityEngine.Vector3 Reflect(UnityEngine.Vector3, UnityEngine.Vector3)
		public static Method RNormalize_Vector3; //UnityEngine.Vector3 Normalize(UnityEngine.Vector3)
		public  Method RNormalize; //Void Normalize()
		public static Method RDot_Vector3_Vector3; //Single Dot(UnityEngine.Vector3, UnityEngine.Vector3)
		public static Method RProject_Vector3_Vector3; //UnityEngine.Vector3 Project(UnityEngine.Vector3, UnityEngine.Vector3)
		public static Method RProjectOnPlane_Vector3_Vector3; //UnityEngine.Vector3 ProjectOnPlane(UnityEngine.Vector3, UnityEngine.Vector3)
		public static Method RAngle_Vector3_Vector3; //Single Angle(UnityEngine.Vector3, UnityEngine.Vector3)
		public static Method RSignedAngle_Vector3_Vector3_Vector3; //Single SignedAngle(UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3)
		public static Method RDistance_Vector3_Vector3; //Single Distance(UnityEngine.Vector3, UnityEngine.Vector3)
		public static Method RClampMagnitude_Vector3_Single; //UnityEngine.Vector3 ClampMagnitude(UnityEngine.Vector3, Single)
		public static Method RMagnitude_Vector3; //Single Magnitude(UnityEngine.Vector3)
		public static Method RSqrMagnitude_Vector3; //Single SqrMagnitude(UnityEngine.Vector3)
		public static Method RMin_Vector3_Vector3; //UnityEngine.Vector3 Min(UnityEngine.Vector3, UnityEngine.Vector3)
		public static Method RMax_Vector3_Vector3; //UnityEngine.Vector3 Max(UnityEngine.Vector3, UnityEngine.Vector3)
		public static Method Rop_Addition_Vector3_Vector3; //UnityEngine.Vector3 op_Addition(UnityEngine.Vector3, UnityEngine.Vector3)
		public static Method Rop_Subtraction_Vector3_Vector3; //UnityEngine.Vector3 op_Subtraction(UnityEngine.Vector3, UnityEngine.Vector3)
		public static Method Rop_UnaryNegation_Vector3; //UnityEngine.Vector3 op_UnaryNegation(UnityEngine.Vector3)
		public static Method Rop_Multiply_Vector3_Single; //UnityEngine.Vector3 op_Multiply(UnityEngine.Vector3, Single)
		public static Method Rop_Multiply_Single_Vector3; //UnityEngine.Vector3 op_Multiply(Single, UnityEngine.Vector3)
		public static Method Rop_Division_Vector3_Single; //UnityEngine.Vector3 op_Division(UnityEngine.Vector3, Single)
		public static Method Rop_Equality_Vector3_Vector3; //Boolean op_Equality(UnityEngine.Vector3, UnityEngine.Vector3)
		public static Method Rop_Inequality_Vector3_Vector3; //Boolean op_Inequality(UnityEngine.Vector3, UnityEngine.Vector3)
		public  Method RToString; //System.String ToString()
		public  Method RToString_String; //System.String ToString(System.String)
		public  Method RToString_String_IFormatProvider; //System.String ToString(System.String, System.IFormatProvider)
		public static Method RAngleBetween_Vector3_Vector3; //Single AngleBetween(UnityEngine.Vector3, UnityEngine.Vector3)
		public static Method RExclude_Vector3_Vector3; //UnityEngine.Vector3 Exclude(UnityEngine.Vector3, UnityEngine.Vector3)
		public static Method RSlerp_Injected_Ref_Vector3_Ref_Vector3_Single_Out_Vector3; //Void Slerp_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef, Single, UnityEngine.Vector3 ByRef)
		public static Method RSlerpUnclamped_Injected_Ref_Vector3_Ref_Vector3_Single_Out_Vector3; //Void SlerpUnclamped_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef, Single, UnityEngine.Vector3 ByRef)
		public static Method RRotateTowards_Injected_Ref_Vector3_Ref_Vector3_Single_Single_Out_Vector3; //Void RotateTowards_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef, Single, Single, UnityEngine.Vector3 ByRef)
		public  Method RFinalize; //Void Finalize()
		public  Method RGetType; //System.Type GetType()
		public  Method RMemberwiseClone; //System.Object MemberwiseClone()


        public RVector3() : base("UnityEngine.Vector3")
        {
            //NewMembers();
        }

        public RVector3(System.Object instance) : base("UnityEngine.Vector3")
		{
			NewMembers();
            SetInstance(instance);
		}

        public RVector3(Member belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
           // NewMembers();
	    }

        private void NewMembers()
        {
			
			
			RSlerp_Vector3_Vector3_Single = new Method(this, "Slerp", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Single));
			RSlerpUnclamped_Vector3_Vector3_Single = new Method(this, "SlerpUnclamped", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Single));
			ROrthoNormalize2_Ref_Vector3_Ref_Vector3 = new Method(this, "OrthoNormalize2", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
			ROrthoNormalize_Ref_Vector3_Ref_Vector3 = new Method(this, "OrthoNormalize", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
			ROrthoNormalize3_Ref_Vector3_Ref_Vector3_Ref_Vector3 = new Method(this, "OrthoNormalize3", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
			ROrthoNormalize_Ref_Vector3_Ref_Vector3_Ref_Vector3 = new Method(this, "OrthoNormalize", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
			RRotateTowards_Vector3_Vector3_Single_Single = new Method(this, "RotateTowards", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Single), typeof(System.Single));
			RLerp_Vector3_Vector3_Single = new Method(this, "Lerp", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Single));
			RLerpUnclamped_Vector3_Vector3_Single = new Method(this, "LerpUnclamped", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Single));
			RMoveTowards_Vector3_Vector3_Single = new Method(this, "MoveTowards", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Single));
			RSmoothDamp_Vector3_Vector3_Ref_Vector3_Single_Single = new Method(this, "SmoothDamp", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single), typeof(System.Single));
			RSmoothDamp_Vector3_Vector3_Ref_Vector3_Single = new Method(this, "SmoothDamp", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single));
			RSmoothDamp_Vector3_Vector3_Ref_Vector3_Single_Single_Single = new Method(this, "SmoothDamp", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single), typeof(System.Single), typeof(System.Single));
			RSet_Single_Single_Single = new Method(this, "Set", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
			RScale_Vector3_Vector3 = new Method(this, "Scale", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
			RScale_Vector3 = new Method(this, "Scale", 0, typeof(UnityEngine.Vector3));
			RCross_Vector3_Vector3 = new Method(this, "Cross", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
			RGetHashCode = new Method(this, "GetHashCode", 0);
			REquals_Object = new Method(this, "Equals", 0, typeof(System.Object));
			REquals_Vector3 = new Method(this, "Equals", 0, typeof(UnityEngine.Vector3));
			RReflect_Vector3_Vector3 = new Method(this, "Reflect", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
			RNormalize_Vector3 = new Method(this, "Normalize", 0, typeof(UnityEngine.Vector3));
			RNormalize = new Method(this, "Normalize", 0);
			RDot_Vector3_Vector3 = new Method(this, "Dot", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
			RProject_Vector3_Vector3 = new Method(this, "Project", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
			RProjectOnPlane_Vector3_Vector3 = new Method(this, "ProjectOnPlane", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
			RAngle_Vector3_Vector3 = new Method(this, "Angle", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
			RSignedAngle_Vector3_Vector3_Vector3 = new Method(this, "SignedAngle", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
			RDistance_Vector3_Vector3 = new Method(this, "Distance", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
			RClampMagnitude_Vector3_Single = new Method(this, "ClampMagnitude", 0, typeof(UnityEngine.Vector3), typeof(System.Single));
			RMagnitude_Vector3 = new Method(this, "Magnitude", 0, typeof(UnityEngine.Vector3));
			RSqrMagnitude_Vector3 = new Method(this, "SqrMagnitude", 0, typeof(UnityEngine.Vector3));
			RMin_Vector3_Vector3 = new Method(this, "Min", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
			RMax_Vector3_Vector3 = new Method(this, "Max", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
			Rop_Addition_Vector3_Vector3 = new Method(this, "op_Addition", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
			Rop_Subtraction_Vector3_Vector3 = new Method(this, "op_Subtraction", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
			Rop_UnaryNegation_Vector3 = new Method(this, "op_UnaryNegation", 0, typeof(UnityEngine.Vector3));
			Rop_Multiply_Vector3_Single = new Method(this, "op_Multiply", 0, typeof(UnityEngine.Vector3), typeof(System.Single));
			Rop_Multiply_Single_Vector3 = new Method(this, "op_Multiply", 0, typeof(System.Single), typeof(UnityEngine.Vector3));
			Rop_Division_Vector3_Single = new Method(this, "op_Division", 0, typeof(UnityEngine.Vector3), typeof(System.Single));
			Rop_Equality_Vector3_Vector3 = new Method(this, "op_Equality", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
			Rop_Inequality_Vector3_Vector3 = new Method(this, "op_Inequality", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
			RToString = new Method(this, "ToString", 0);
			RToString_String = new Method(this, "ToString", 0, typeof(System.String));
			RToString_String_IFormatProvider = new Method(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
			RAngleBetween_Vector3_Vector3 = new Method(this, "AngleBetween", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
			RExclude_Vector3_Vector3 = new Method(this, "Exclude", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
			RSlerp_Injected_Ref_Vector3_Ref_Vector3_Single_Out_Vector3 = new Method(this, "Slerp_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single), typeof(UnityEngine.Vector3).MakeByRefType());
			RSlerpUnclamped_Injected_Ref_Vector3_Ref_Vector3_Single_Out_Vector3 = new Method(this, "SlerpUnclamped_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single), typeof(UnityEngine.Vector3).MakeByRefType());
			RRotateTowards_Injected_Ref_Vector3_Ref_Vector3_Single_Single_Out_Vector3 = new Method(this, "RotateTowards_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.Vector3).MakeByRefType());
			RFinalize = new Method(this, "Finalize", 0);
			RGetType = new Method(this, "GetType", 0);
			RMemberwiseClone = new Method(this, "MemberwiseClone", 0);

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
