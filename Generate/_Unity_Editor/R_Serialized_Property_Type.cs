
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.SerializedPropertyType
	/// </summary>
    public partial class RSerializedPropertyType : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEditor.SerializedPropertyType);
            }
        }

        public RSerializedPropertyType() : base("UnityEditor.SerializedPropertyType")
        {
        }

        public RSerializedPropertyType(System.Object instance) : base("UnityEditor.SerializedPropertyType")
		{
            SetInstance(instance);
		}

        public RSerializedPropertyType(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSerializedPropertyType(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 value__
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fvalue__;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFvalue__
		{
			get
			{
				if(r_Fvalue__ == null)
				{
					r_Fvalue__ = new(this, "value__");
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedPropertyType Generic
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType r_FGeneric;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType RFGeneric
		{
			get
			{
				if(r_FGeneric == null)
				{
					r_FGeneric = new(Type, "Generic");
				}
				return r_FGeneric;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedPropertyType Integer
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType r_FInteger;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType RFInteger
		{
			get
			{
				if(r_FInteger == null)
				{
					r_FInteger = new(Type, "Integer");
				}
				return r_FInteger;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedPropertyType Boolean
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType r_FBoolean;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType RFBoolean
		{
			get
			{
				if(r_FBoolean == null)
				{
					r_FBoolean = new(Type, "Boolean");
				}
				return r_FBoolean;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedPropertyType Float
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType r_FFloat;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType RFFloat
		{
			get
			{
				if(r_FFloat == null)
				{
					r_FFloat = new(Type, "Float");
				}
				return r_FFloat;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedPropertyType String
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType r_FString;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType RFString
		{
			get
			{
				if(r_FString == null)
				{
					r_FString = new(Type, "String");
				}
				return r_FString;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedPropertyType Color
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType r_FColor;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType RFColor
		{
			get
			{
				if(r_FColor == null)
				{
					r_FColor = new(Type, "Color");
				}
				return r_FColor;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedPropertyType ObjectReference
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType r_FObjectReference;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType RFObjectReference
		{
			get
			{
				if(r_FObjectReference == null)
				{
					r_FObjectReference = new(Type, "ObjectReference");
				}
				return r_FObjectReference;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedPropertyType LayerMask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType r_FLayerMask;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType RFLayerMask
		{
			get
			{
				if(r_FLayerMask == null)
				{
					r_FLayerMask = new(Type, "LayerMask");
				}
				return r_FLayerMask;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedPropertyType Enum
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType r_FEnum;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType RFEnum
		{
			get
			{
				if(r_FEnum == null)
				{
					r_FEnum = new(Type, "Enum");
				}
				return r_FEnum;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedPropertyType Vector2
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType r_FVector2;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType RFVector2
		{
			get
			{
				if(r_FVector2 == null)
				{
					r_FVector2 = new(Type, "Vector2");
				}
				return r_FVector2;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedPropertyType Vector3
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType r_FVector3;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType RFVector3
		{
			get
			{
				if(r_FVector3 == null)
				{
					r_FVector3 = new(Type, "Vector3");
				}
				return r_FVector3;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedPropertyType Vector4
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType r_FVector4;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType RFVector4
		{
			get
			{
				if(r_FVector4 == null)
				{
					r_FVector4 = new(Type, "Vector4");
				}
				return r_FVector4;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedPropertyType Rect
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType r_FRect;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType RFRect
		{
			get
			{
				if(r_FRect == null)
				{
					r_FRect = new(Type, "Rect");
				}
				return r_FRect;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedPropertyType ArraySize
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType r_FArraySize;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType RFArraySize
		{
			get
			{
				if(r_FArraySize == null)
				{
					r_FArraySize = new(Type, "ArraySize");
				}
				return r_FArraySize;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedPropertyType Character
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType r_FCharacter;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType RFCharacter
		{
			get
			{
				if(r_FCharacter == null)
				{
					r_FCharacter = new(Type, "Character");
				}
				return r_FCharacter;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedPropertyType AnimationCurve
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType r_FAnimationCurve;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType RFAnimationCurve
		{
			get
			{
				if(r_FAnimationCurve == null)
				{
					r_FAnimationCurve = new(Type, "AnimationCurve");
				}
				return r_FAnimationCurve;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedPropertyType Bounds
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType r_FBounds;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType RFBounds
		{
			get
			{
				if(r_FBounds == null)
				{
					r_FBounds = new(Type, "Bounds");
				}
				return r_FBounds;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedPropertyType Gradient
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType r_FGradient;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType RFGradient
		{
			get
			{
				if(r_FGradient == null)
				{
					r_FGradient = new(Type, "Gradient");
				}
				return r_FGradient;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedPropertyType Quaternion
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType r_FQuaternion;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType RFQuaternion
		{
			get
			{
				if(r_FQuaternion == null)
				{
					r_FQuaternion = new(Type, "Quaternion");
				}
				return r_FQuaternion;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedPropertyType ExposedReference
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType r_FExposedReference;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType RFExposedReference
		{
			get
			{
				if(r_FExposedReference == null)
				{
					r_FExposedReference = new(Type, "ExposedReference");
				}
				return r_FExposedReference;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedPropertyType FixedBufferSize
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType r_FFixedBufferSize;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType RFFixedBufferSize
		{
			get
			{
				if(r_FFixedBufferSize == null)
				{
					r_FFixedBufferSize = new(Type, "FixedBufferSize");
				}
				return r_FFixedBufferSize;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedPropertyType Vector2Int
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType r_FVector2Int;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType RFVector2Int
		{
			get
			{
				if(r_FVector2Int == null)
				{
					r_FVector2Int = new(Type, "Vector2Int");
				}
				return r_FVector2Int;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedPropertyType Vector3Int
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType r_FVector3Int;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType RFVector3Int
		{
			get
			{
				if(r_FVector3Int == null)
				{
					r_FVector3Int = new(Type, "Vector3Int");
				}
				return r_FVector3Int;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedPropertyType RectInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType r_FRectInt;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType RFRectInt
		{
			get
			{
				if(r_FRectInt == null)
				{
					r_FRectInt = new(Type, "RectInt");
				}
				return r_FRectInt;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedPropertyType BoundsInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType r_FBoundsInt;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType RFBoundsInt
		{
			get
			{
				if(r_FBoundsInt == null)
				{
					r_FBoundsInt = new(Type, "BoundsInt");
				}
				return r_FBoundsInt;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedPropertyType ManagedReference
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType r_FManagedReference;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType RFManagedReference
		{
			get
			{
				if(r_FManagedReference == null)
				{
					r_FManagedReference = new(Type, "ManagedReference");
				}
				return r_FManagedReference;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedPropertyType Hash128
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType r_FHash128;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSerializedPropertyType RFHash128
		{
			get
			{
				if(r_FHash128 == null)
				{
					r_FHash128 = new(Type, "Hash128");
				}
				return r_FHash128;
			}
		}

		/// <summary>
		/// System.Object GetValue()
		/// </summary>
		protected RMethod r_MGetValue;
		public virtual RMethod RMGetValue
		{
			get
			{
				if(r_MGetValue == null)
				{
					r_MGetValue = new(this, "GetValue", 0);
				}
				return r_MGetValue;
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
		/// Int32 CompareTo(System.Object)
		/// </summary>
		protected RMethod r_MCompareTo_Object;
		public virtual RMethod RMCompareTo_Object
		{
			get
			{
				if(r_MCompareTo_Object == null)
				{
					r_MCompareTo_Object = new(this, "CompareTo", 0, typeof(System.Object));
				}
				return r_MCompareTo_Object;
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
		/// System.String ToString(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_IFormatProvider;
		public virtual RMethod RMToString_IFormatProvider
		{
			get
			{
				if(r_MToString_IFormatProvider == null)
				{
					r_MToString_IFormatProvider = new(this, "ToString", 0, typeof(System.IFormatProvider));
				}
				return r_MToString_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean HasFlag(System.Enum)
		/// </summary>
		protected RMethod r_MHasFlag_Enum;
		public virtual RMethod RMHasFlag_Enum
		{
			get
			{
				if(r_MHasFlag_Enum == null)
				{
					r_MHasFlag_Enum = new(this, "HasFlag", 0, typeof(System.Enum));
				}
				return r_MHasFlag_Enum;
			}
		}

		/// <summary>
		/// System.TypeCode GetTypeCode()
		/// </summary>
		protected RMethod r_MGetTypeCode;
		public virtual RMethod RMGetTypeCode
		{
			get
			{
				if(r_MGetTypeCode == null)
				{
					r_MGetTypeCode = new(this, "GetTypeCode", 0);
				}
				return r_MGetTypeCode;
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


        public virtual System.Object GetValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValue.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Int32 CompareTo(System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean HasFlag(System.Enum @flag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flag};
            var ___result = RMHasFlag_Enum.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.TypeCode>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
