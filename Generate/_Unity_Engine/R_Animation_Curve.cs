
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.AnimationCurve
	/// </summary>
    public partial class RAnimationCurve : RMember //
    {

		/// <summary>
		/// System.IntPtr m_Ptr
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fm_Ptr;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFm_Ptr
		{
			get
			{
				if(r_Fm_Ptr == null)
				{
					r_Fm_Ptr = new(this, "m_Ptr");
				}
				return r_Fm_Ptr;
			}
		}

		/// <summary>
		/// UnityEngine.Keyframe[] keys
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RKeyframe> r_Pkeys;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RKeyframe> RPkeys
		{
			get
			{
				if(r_Pkeys == null)
				{
					r_Pkeys = new(this, "keys", -1);
				}
				return r_Pkeys;
			}
		}

		/// <summary>
		/// UnityEngine.Keyframe Item [Int32]
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RKeyframe r_PItem_Int32;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RKeyframe RPItem_Int32
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
		/// Int32 length
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Plength;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPlength
		{
			get
			{
				if(r_Plength == null)
				{
					r_Plength = new(this, "length", -1);
				}
				return r_Plength;
			}
		}

		/// <summary>
		/// UnityEngine.WrapMode preWrapMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RWrapMode r_PpreWrapMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RWrapMode RPpreWrapMode
		{
			get
			{
				if(r_PpreWrapMode == null)
				{
					r_PpreWrapMode = new(this, "preWrapMode", -1);
				}
				return r_PpreWrapMode;
			}
		}

		/// <summary>
		/// UnityEngine.WrapMode postWrapMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RWrapMode r_PpostWrapMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RWrapMode RPpostWrapMode
		{
			get
			{
				if(r_PpostWrapMode == null)
				{
					r_PpostWrapMode = new(this, "postWrapMode", -1);
				}
				return r_PpostWrapMode;
			}
		}

		/// <summary>
		/// Void Internal_Destroy(IntPtr)
		/// </summary>
		protected static RMethod r_MInternal_Destroy_IntPtr;
		public static RMethod RMInternal_Destroy_IntPtr
		{
			get
			{
				if(r_MInternal_Destroy_IntPtr == null)
				{
					r_MInternal_Destroy_IntPtr = new(typeof(UnityEngine.AnimationCurve), "Internal_Destroy", 0, typeof(System.IntPtr));
				}
				return r_MInternal_Destroy_IntPtr;
			}
		}

		/// <summary>
		/// IntPtr Internal_Create(UnityEngine.Keyframe[])
		/// </summary>
		protected static RMethod r_MInternal_Create_KeyframeArray;
		public static RMethod RMInternal_Create_KeyframeArray
		{
			get
			{
				if(r_MInternal_Create_KeyframeArray == null)
				{
					r_MInternal_Create_KeyframeArray = new(typeof(UnityEngine.AnimationCurve), "Internal_Create", 0, typeof(UnityEngine.Keyframe).MakeArrayType());
				}
				return r_MInternal_Create_KeyframeArray;
			}
		}

		/// <summary>
		/// Boolean Internal_Equals(IntPtr)
		/// </summary>
		protected RMethod r_MInternal_Equals_IntPtr;
		public virtual RMethod RMInternal_Equals_IntPtr
		{
			get
			{
				if(r_MInternal_Equals_IntPtr == null)
				{
					r_MInternal_Equals_IntPtr = new(this, "Internal_Equals", 0, typeof(System.IntPtr));
				}
				return r_MInternal_Equals_IntPtr;
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
		/// Single Evaluate(Single)
		/// </summary>
		protected RMethod r_MEvaluate_Single;
		public virtual RMethod RMEvaluate_Single
		{
			get
			{
				if(r_MEvaluate_Single == null)
				{
					r_MEvaluate_Single = new(this, "Evaluate", 0, typeof(System.Single));
				}
				return r_MEvaluate_Single;
			}
		}

		/// <summary>
		/// Int32 AddKey(Single, Single)
		/// </summary>
		protected RMethod r_MAddKey_Single_Single;
		public virtual RMethod RMAddKey_Single_Single
		{
			get
			{
				if(r_MAddKey_Single_Single == null)
				{
					r_MAddKey_Single_Single = new(this, "AddKey", 0, typeof(System.Single), typeof(System.Single));
				}
				return r_MAddKey_Single_Single;
			}
		}

		/// <summary>
		/// Int32 AddKey(UnityEngine.Keyframe)
		/// </summary>
		protected RMethod r_MAddKey_Keyframe;
		public virtual RMethod RMAddKey_Keyframe
		{
			get
			{
				if(r_MAddKey_Keyframe == null)
				{
					r_MAddKey_Keyframe = new(this, "AddKey", 0, typeof(UnityEngine.Keyframe));
				}
				return r_MAddKey_Keyframe;
			}
		}

		/// <summary>
		/// Int32 AddKey_Internal(UnityEngine.Keyframe)
		/// </summary>
		protected RMethod r_MAddKey_Internal_Keyframe;
		public virtual RMethod RMAddKey_Internal_Keyframe
		{
			get
			{
				if(r_MAddKey_Internal_Keyframe == null)
				{
					r_MAddKey_Internal_Keyframe = new(this, "AddKey_Internal", 0, typeof(UnityEngine.Keyframe));
				}
				return r_MAddKey_Internal_Keyframe;
			}
		}

		/// <summary>
		/// Int32 MoveKey(Int32, UnityEngine.Keyframe)
		/// </summary>
		protected RMethod r_MMoveKey_Int32_Keyframe;
		public virtual RMethod RMMoveKey_Int32_Keyframe
		{
			get
			{
				if(r_MMoveKey_Int32_Keyframe == null)
				{
					r_MMoveKey_Int32_Keyframe = new(this, "MoveKey", 0, typeof(System.Int32), typeof(UnityEngine.Keyframe));
				}
				return r_MMoveKey_Int32_Keyframe;
			}
		}

		/// <summary>
		/// Void RemoveKey(Int32)
		/// </summary>
		protected RMethod r_MRemoveKey_Int32;
		public virtual RMethod RMRemoveKey_Int32
		{
			get
			{
				if(r_MRemoveKey_Int32 == null)
				{
					r_MRemoveKey_Int32 = new(this, "RemoveKey", 0, typeof(System.Int32));
				}
				return r_MRemoveKey_Int32;
			}
		}

		/// <summary>
		/// Void SetKeys(UnityEngine.Keyframe[])
		/// </summary>
		protected RMethod r_MSetKeys_KeyframeArray;
		public virtual RMethod RMSetKeys_KeyframeArray
		{
			get
			{
				if(r_MSetKeys_KeyframeArray == null)
				{
					r_MSetKeys_KeyframeArray = new(this, "SetKeys", 0, typeof(UnityEngine.Keyframe).MakeArrayType());
				}
				return r_MSetKeys_KeyframeArray;
			}
		}

		/// <summary>
		/// UnityEngine.Keyframe GetKey(Int32)
		/// </summary>
		protected RMethod r_MGetKey_Int32;
		public virtual RMethod RMGetKey_Int32
		{
			get
			{
				if(r_MGetKey_Int32 == null)
				{
					r_MGetKey_Int32 = new(this, "GetKey", 0, typeof(System.Int32));
				}
				return r_MGetKey_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Keyframe[] GetKeys()
		/// </summary>
		protected RMethod r_MGetKeys;
		public virtual RMethod RMGetKeys
		{
			get
			{
				if(r_MGetKeys == null)
				{
					r_MGetKeys = new(this, "GetKeys", 0);
				}
				return r_MGetKeys;
			}
		}

		/// <summary>
		/// Void SmoothTangents(Int32, Single)
		/// </summary>
		protected RMethod r_MSmoothTangents_Int32_Single;
		public virtual RMethod RMSmoothTangents_Int32_Single
		{
			get
			{
				if(r_MSmoothTangents_Int32_Single == null)
				{
					r_MSmoothTangents_Int32_Single = new(this, "SmoothTangents", 0, typeof(System.Int32), typeof(System.Single));
				}
				return r_MSmoothTangents_Int32_Single;
			}
		}

		/// <summary>
		/// UnityEngine.AnimationCurve Constant(Single, Single, Single)
		/// </summary>
		protected static RMethod r_MConstant_Single_Single_Single;
		public static RMethod RMConstant_Single_Single_Single
		{
			get
			{
				if(r_MConstant_Single_Single_Single == null)
				{
					r_MConstant_Single_Single_Single = new(typeof(UnityEngine.AnimationCurve), "Constant", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
				}
				return r_MConstant_Single_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.AnimationCurve Linear(Single, Single, Single, Single)
		/// </summary>
		protected static RMethod r_MLinear_Single_Single_Single_Single;
		public static RMethod RMLinear_Single_Single_Single_Single
		{
			get
			{
				if(r_MLinear_Single_Single_Single_Single == null)
				{
					r_MLinear_Single_Single_Single_Single = new(typeof(UnityEngine.AnimationCurve), "Linear", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single));
				}
				return r_MLinear_Single_Single_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.AnimationCurve EaseInOut(Single, Single, Single, Single)
		/// </summary>
		protected static RMethod r_MEaseInOut_Single_Single_Single_Single;
		public static RMethod RMEaseInOut_Single_Single_Single_Single
		{
			get
			{
				if(r_MEaseInOut_Single_Single_Single_Single == null)
				{
					r_MEaseInOut_Single_Single_Single_Single = new(typeof(UnityEngine.AnimationCurve), "EaseInOut", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single));
				}
				return r_MEaseInOut_Single_Single_Single_Single;
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
		/// Boolean Equals(UnityEngine.AnimationCurve)
		/// </summary>
		protected RMethod r_MEquals_AnimationCurve;
		public virtual RMethod RMEquals_AnimationCurve
		{
			get
			{
				if(r_MEquals_AnimationCurve == null)
				{
					r_MEquals_AnimationCurve = new(this, "Equals", 0, typeof(UnityEngine.AnimationCurve));
				}
				return r_MEquals_AnimationCurve;
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
		/// Int32 AddKey_Internal_Injected(UnityEngine.Keyframe ByRef)
		/// </summary>
		protected RMethod r_MAddKey_Internal_Injected_Ref_Keyframe;
		public virtual RMethod RMAddKey_Internal_Injected_Ref_Keyframe
		{
			get
			{
				if(r_MAddKey_Internal_Injected_Ref_Keyframe == null)
				{
					r_MAddKey_Internal_Injected_Ref_Keyframe = new(this, "AddKey_Internal_Injected", 0, typeof(UnityEngine.Keyframe).MakeByRefType());
				}
				return r_MAddKey_Internal_Injected_Ref_Keyframe;
			}
		}

		/// <summary>
		/// Int32 MoveKey_Injected(Int32, UnityEngine.Keyframe ByRef)
		/// </summary>
		protected RMethod r_MMoveKey_Injected_Int32_Ref_Keyframe;
		public virtual RMethod RMMoveKey_Injected_Int32_Ref_Keyframe
		{
			get
			{
				if(r_MMoveKey_Injected_Int32_Ref_Keyframe == null)
				{
					r_MMoveKey_Injected_Int32_Ref_Keyframe = new(this, "MoveKey_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Keyframe).MakeByRefType());
				}
				return r_MMoveKey_Injected_Int32_Ref_Keyframe;
			}
		}

		/// <summary>
		/// Void GetKey_Injected(Int32, UnityEngine.Keyframe ByRef)
		/// </summary>
		protected RMethod r_MGetKey_Injected_Int32_Out_Keyframe;
		public virtual RMethod RMGetKey_Injected_Int32_Out_Keyframe
		{
			get
			{
				if(r_MGetKey_Injected_Int32_Out_Keyframe == null)
				{
					r_MGetKey_Injected_Int32_Out_Keyframe = new(this, "GetKey_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Keyframe).MakeByRefType());
				}
				return r_MGetKey_Injected_Int32_Out_Keyframe;
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


        public RAnimationCurve() : base("UnityEngine.AnimationCurve")
        {
        }

        public RAnimationCurve(System.Object instance) : base("UnityEngine.AnimationCurve")
		{
            SetInstance(instance);
		}

        public RAnimationCurve(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAnimationCurve(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static void Internal_Destroy(System.IntPtr @ptr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ptr};
            var ___result = RMInternal_Destroy_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public static System.IntPtr Internal_Create(UnityEngine.Keyframe[] @keys)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keys};
            var ___result = RMInternal_Create_KeyframeArray.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual System.Boolean Internal_Equals(System.IntPtr @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMInternal_Equals_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Single Evaluate(System.Single @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time};
            var ___result = RMEvaluate_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Int32 AddKey(System.Single @time, System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time, @value};
            var ___result = RMAddKey_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 AddKey(UnityEngine.Keyframe @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMAddKey_Keyframe.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 AddKey_Internal(UnityEngine.Keyframe @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMAddKey_Internal_Keyframe.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 MoveKey(System.Int32 @index, UnityEngine.Keyframe @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @key};
            var ___result = RMMoveKey_Int32_Keyframe.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void RemoveKey(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMRemoveKey_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetKeys(UnityEngine.Keyframe[] @keys)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keys};
            var ___result = RMSetKeys_KeyframeArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Keyframe GetKey(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetKey_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Keyframe)___result;
        }


        public virtual UnityEngine.Keyframe[] GetKeys()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetKeys.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Keyframe[])___result;
        }


        public virtual void SmoothTangents(System.Int32 @index, System.Single @weight)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @weight};
            var ___result = RMSmoothTangents_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.AnimationCurve Constant(System.Single @timeStart, System.Single @timeEnd, System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeStart, @timeEnd, @value};
            var ___result = RMConstant_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AnimationCurve)___result;
        }


        public static UnityEngine.AnimationCurve Linear(System.Single @timeStart, System.Single @valueStart, System.Single @timeEnd, System.Single @valueEnd)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeStart, @valueStart, @timeEnd, @valueEnd};
            var ___result = RMLinear_Single_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AnimationCurve)___result;
        }


        public static UnityEngine.AnimationCurve EaseInOut(System.Single @timeStart, System.Single @valueStart, System.Single @timeEnd, System.Single @valueEnd)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeStart, @valueStart, @timeEnd, @valueEnd};
            var ___result = RMEaseInOut_Single_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AnimationCurve)___result;
        }


        public virtual System.Boolean Equals(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.AnimationCurve @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_AnimationCurve.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 AddKey_Internal_Injected(ref UnityEngine.Keyframe @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMAddKey_Internal_Injected_Ref_Keyframe.Invoke(___genericsType, ___parameters);
			@key = (UnityEngine.Keyframe)___parameters[0];

            return (System.Int32)___result;
        }


        public virtual System.Int32 MoveKey_Injected(System.Int32 @index, ref UnityEngine.Keyframe @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @key};
            var ___result = RMMoveKey_Injected_Int32_Ref_Keyframe.Invoke(___genericsType, ___parameters);
			@key = (UnityEngine.Keyframe)___parameters[1];

            return (System.Int32)___result;
        }


        public virtual void GetKey_Injected(System.Int32 @index, out UnityEngine.Keyframe @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @ret};
            var ___result = RMGetKey_Injected_Int32_Out_Keyframe.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Keyframe)___parameters[1];

            
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
