using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.AnimationCurve
	/// </summary>
    public partial class RAnimationCurve : RMember //
    {

		/// <summary>
		/// System.IntPtr m_Ptr
		/// </summary>
		protected RField r_m_Ptr;
		public virtual RField Rm_Ptr
		{
			get
			{
				if(r_m_Ptr == null)
				{
					r_m_Ptr = new(this, "m_Ptr");
					r_m_Ptr.SetBelong(this.instance);
				}
				return r_m_Ptr;
			}
		}

		/// <summary>
		/// UnityEngine.Keyframe[] keys
		/// </summary>
		protected RPropertyArray<RUnityEngine.RKeyframe> r_keys;
		public virtual RPropertyArray<RUnityEngine.RKeyframe> Rkeys
		{
			get
			{
				if(r_keys == null)
				{
					r_keys = new(this, "keys", -1);
					r_keys.SetBelong(this.instance);
				}
				return r_keys;
			}
		}

		/// <summary>
		/// UnityEngine.Keyframe Item [Int32]
		/// </summary>
		protected RUnityEngine.RKeyframe r_Item_Int32;
		public virtual RUnityEngine.RKeyframe RItem_Int32
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
		/// Int32 length
		/// </summary>
		protected RProperty r_length;
		public virtual RProperty Rlength
		{
			get
			{
				if(r_length == null)
				{
					r_length = new(this, "length", -1);
					r_length.SetBelong(this.instance);
				}
				return r_length;
			}
		}

		/// <summary>
		/// UnityEngine.WrapMode preWrapMode
		/// </summary>
		protected RProperty r_preWrapMode;
		public virtual RProperty RpreWrapMode
		{
			get
			{
				if(r_preWrapMode == null)
				{
					r_preWrapMode = new(this, "preWrapMode", -1);
					r_preWrapMode.SetBelong(this.instance);
				}
				return r_preWrapMode;
			}
		}

		/// <summary>
		/// UnityEngine.WrapMode postWrapMode
		/// </summary>
		protected RProperty r_postWrapMode;
		public virtual RProperty RpostWrapMode
		{
			get
			{
				if(r_postWrapMode == null)
				{
					r_postWrapMode = new(this, "postWrapMode", -1);
					r_postWrapMode.SetBelong(this.instance);
				}
				return r_postWrapMode;
			}
		}

		/// <summary>
		/// Void Internal_Destroy(IntPtr)
		/// </summary>
		protected static RMethod r_Internal_Destroy_IntPtr;
		public static RMethod RInternal_Destroy_IntPtr
		{
			get
			{
				if(r_Internal_Destroy_IntPtr == null)
				{
					r_Internal_Destroy_IntPtr = new(typeof(UnityEngine.AnimationCurve), "Internal_Destroy", 0, typeof(System.IntPtr));
					r_Internal_Destroy_IntPtr.SetBelong(null);
				}
				return r_Internal_Destroy_IntPtr;
			}
		}

		/// <summary>
		/// IntPtr Internal_Create(UnityEngine.Keyframe[])
		/// </summary>
		protected static RMethod r_Internal_Create_KeyframeArray;
		public static RMethod RInternal_Create_KeyframeArray
		{
			get
			{
				if(r_Internal_Create_KeyframeArray == null)
				{
					r_Internal_Create_KeyframeArray = new(typeof(UnityEngine.AnimationCurve), "Internal_Create", 0, typeof(UnityEngine.Keyframe).MakeArrayType());
					r_Internal_Create_KeyframeArray.SetBelong(null);
				}
				return r_Internal_Create_KeyframeArray;
			}
		}

		/// <summary>
		/// Boolean Internal_Equals(IntPtr)
		/// </summary>
		protected RMethod r_Internal_Equals_IntPtr;
		public virtual RMethod RInternal_Equals_IntPtr
		{
			get
			{
				if(r_Internal_Equals_IntPtr == null)
				{
					r_Internal_Equals_IntPtr = new(this, "Internal_Equals", 0, typeof(System.IntPtr));
					r_Internal_Equals_IntPtr.SetBelong(this.instance);
				}
				return r_Internal_Equals_IntPtr;
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
		/// Single Evaluate(Single)
		/// </summary>
		protected RMethod r_Evaluate_Single;
		public virtual RMethod REvaluate_Single
		{
			get
			{
				if(r_Evaluate_Single == null)
				{
					r_Evaluate_Single = new(this, "Evaluate", 0, typeof(System.Single));
					r_Evaluate_Single.SetBelong(this.instance);
				}
				return r_Evaluate_Single;
			}
		}

		/// <summary>
		/// Int32 AddKey(Single, Single)
		/// </summary>
		protected RMethod r_AddKey_Single_Single;
		public virtual RMethod RAddKey_Single_Single
		{
			get
			{
				if(r_AddKey_Single_Single == null)
				{
					r_AddKey_Single_Single = new(this, "AddKey", 0, typeof(System.Single), typeof(System.Single));
					r_AddKey_Single_Single.SetBelong(this.instance);
				}
				return r_AddKey_Single_Single;
			}
		}

		/// <summary>
		/// Int32 AddKey(UnityEngine.Keyframe)
		/// </summary>
		protected RMethod r_AddKey_Keyframe;
		public virtual RMethod RAddKey_Keyframe
		{
			get
			{
				if(r_AddKey_Keyframe == null)
				{
					r_AddKey_Keyframe = new(this, "AddKey", 0, typeof(UnityEngine.Keyframe));
					r_AddKey_Keyframe.SetBelong(this.instance);
				}
				return r_AddKey_Keyframe;
			}
		}

		/// <summary>
		/// Int32 AddKey_Internal(UnityEngine.Keyframe)
		/// </summary>
		protected RMethod r_AddKey_Internal_Keyframe;
		public virtual RMethod RAddKey_Internal_Keyframe
		{
			get
			{
				if(r_AddKey_Internal_Keyframe == null)
				{
					r_AddKey_Internal_Keyframe = new(this, "AddKey_Internal", 0, typeof(UnityEngine.Keyframe));
					r_AddKey_Internal_Keyframe.SetBelong(this.instance);
				}
				return r_AddKey_Internal_Keyframe;
			}
		}

		/// <summary>
		/// Int32 MoveKey(Int32, UnityEngine.Keyframe)
		/// </summary>
		protected RMethod r_MoveKey_Int32_Keyframe;
		public virtual RMethod RMoveKey_Int32_Keyframe
		{
			get
			{
				if(r_MoveKey_Int32_Keyframe == null)
				{
					r_MoveKey_Int32_Keyframe = new(this, "MoveKey", 0, typeof(System.Int32), typeof(UnityEngine.Keyframe));
					r_MoveKey_Int32_Keyframe.SetBelong(this.instance);
				}
				return r_MoveKey_Int32_Keyframe;
			}
		}

		/// <summary>
		/// Void RemoveKey(Int32)
		/// </summary>
		protected RMethod r_RemoveKey_Int32;
		public virtual RMethod RRemoveKey_Int32
		{
			get
			{
				if(r_RemoveKey_Int32 == null)
				{
					r_RemoveKey_Int32 = new(this, "RemoveKey", 0, typeof(System.Int32));
					r_RemoveKey_Int32.SetBelong(this.instance);
				}
				return r_RemoveKey_Int32;
			}
		}

		/// <summary>
		/// Void SetKeys(UnityEngine.Keyframe[])
		/// </summary>
		protected RMethod r_SetKeys_KeyframeArray;
		public virtual RMethod RSetKeys_KeyframeArray
		{
			get
			{
				if(r_SetKeys_KeyframeArray == null)
				{
					r_SetKeys_KeyframeArray = new(this, "SetKeys", 0, typeof(UnityEngine.Keyframe).MakeArrayType());
					r_SetKeys_KeyframeArray.SetBelong(this.instance);
				}
				return r_SetKeys_KeyframeArray;
			}
		}

		/// <summary>
		/// UnityEngine.Keyframe GetKey(Int32)
		/// </summary>
		protected RMethod r_GetKey_Int32;
		public virtual RMethod RGetKey_Int32
		{
			get
			{
				if(r_GetKey_Int32 == null)
				{
					r_GetKey_Int32 = new(this, "GetKey", 0, typeof(System.Int32));
					r_GetKey_Int32.SetBelong(this.instance);
				}
				return r_GetKey_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Keyframe[] GetKeys()
		/// </summary>
		protected RMethod r_GetKeys;
		public virtual RMethod RGetKeys
		{
			get
			{
				if(r_GetKeys == null)
				{
					r_GetKeys = new(this, "GetKeys", 0);
					r_GetKeys.SetBelong(this.instance);
				}
				return r_GetKeys;
			}
		}

		/// <summary>
		/// Void SmoothTangents(Int32, Single)
		/// </summary>
		protected RMethod r_SmoothTangents_Int32_Single;
		public virtual RMethod RSmoothTangents_Int32_Single
		{
			get
			{
				if(r_SmoothTangents_Int32_Single == null)
				{
					r_SmoothTangents_Int32_Single = new(this, "SmoothTangents", 0, typeof(System.Int32), typeof(System.Single));
					r_SmoothTangents_Int32_Single.SetBelong(this.instance);
				}
				return r_SmoothTangents_Int32_Single;
			}
		}

		/// <summary>
		/// UnityEngine.AnimationCurve Constant(Single, Single, Single)
		/// </summary>
		protected static RMethod r_Constant_Single_Single_Single;
		public static RMethod RConstant_Single_Single_Single
		{
			get
			{
				if(r_Constant_Single_Single_Single == null)
				{
					r_Constant_Single_Single_Single = new(typeof(UnityEngine.AnimationCurve), "Constant", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_Constant_Single_Single_Single.SetBelong(null);
				}
				return r_Constant_Single_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.AnimationCurve Linear(Single, Single, Single, Single)
		/// </summary>
		protected static RMethod r_Linear_Single_Single_Single_Single;
		public static RMethod RLinear_Single_Single_Single_Single
		{
			get
			{
				if(r_Linear_Single_Single_Single_Single == null)
				{
					r_Linear_Single_Single_Single_Single = new(typeof(UnityEngine.AnimationCurve), "Linear", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_Linear_Single_Single_Single_Single.SetBelong(null);
				}
				return r_Linear_Single_Single_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.AnimationCurve EaseInOut(Single, Single, Single, Single)
		/// </summary>
		protected static RMethod r_EaseInOut_Single_Single_Single_Single;
		public static RMethod REaseInOut_Single_Single_Single_Single
		{
			get
			{
				if(r_EaseInOut_Single_Single_Single_Single == null)
				{
					r_EaseInOut_Single_Single_Single_Single = new(typeof(UnityEngine.AnimationCurve), "EaseInOut", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_EaseInOut_Single_Single_Single_Single.SetBelong(null);
				}
				return r_EaseInOut_Single_Single_Single_Single;
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
		/// Boolean Equals(UnityEngine.AnimationCurve)
		/// </summary>
		protected RMethod r_Equals_AnimationCurve;
		public virtual RMethod REquals_AnimationCurve
		{
			get
			{
				if(r_Equals_AnimationCurve == null)
				{
					r_Equals_AnimationCurve = new(this, "Equals", 0, typeof(UnityEngine.AnimationCurve));
					r_Equals_AnimationCurve.SetBelong(this.instance);
				}
				return r_Equals_AnimationCurve;
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
		/// Int32 AddKey_Internal_Injected(UnityEngine.Keyframe ByRef)
		/// </summary>
		protected RMethod r_AddKey_Internal_Injected_Ref_Keyframe;
		public virtual RMethod RAddKey_Internal_Injected_Ref_Keyframe
		{
			get
			{
				if(r_AddKey_Internal_Injected_Ref_Keyframe == null)
				{
					r_AddKey_Internal_Injected_Ref_Keyframe = new(this, "AddKey_Internal_Injected", 0, typeof(UnityEngine.Keyframe).MakeByRefType());
					r_AddKey_Internal_Injected_Ref_Keyframe.SetBelong(this.instance);
				}
				return r_AddKey_Internal_Injected_Ref_Keyframe;
			}
		}

		/// <summary>
		/// Int32 MoveKey_Injected(Int32, UnityEngine.Keyframe ByRef)
		/// </summary>
		protected RMethod r_MoveKey_Injected_Int32_Ref_Keyframe;
		public virtual RMethod RMoveKey_Injected_Int32_Ref_Keyframe
		{
			get
			{
				if(r_MoveKey_Injected_Int32_Ref_Keyframe == null)
				{
					r_MoveKey_Injected_Int32_Ref_Keyframe = new(this, "MoveKey_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Keyframe).MakeByRefType());
					r_MoveKey_Injected_Int32_Ref_Keyframe.SetBelong(this.instance);
				}
				return r_MoveKey_Injected_Int32_Ref_Keyframe;
			}
		}

		/// <summary>
		/// Void GetKey_Injected(Int32, UnityEngine.Keyframe ByRef)
		/// </summary>
		protected RMethod r_GetKey_Injected_Int32_Out_Keyframe;
		public virtual RMethod RGetKey_Injected_Int32_Out_Keyframe
		{
			get
			{
				if(r_GetKey_Injected_Int32_Out_Keyframe == null)
				{
					r_GetKey_Injected_Int32_Out_Keyframe = new(this, "GetKey_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Keyframe).MakeByRefType());
					r_GetKey_Injected_Int32_Out_Keyframe.SetBelong(this.instance);
				}
				return r_GetKey_Injected_Int32_Out_Keyframe;
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

        public static void Internal_Destroy(System.IntPtr  @ptr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ptr};
            var ___result = RInternal_Destroy_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public static System.IntPtr Internal_Create(UnityEngine.Keyframe[]  @keys)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keys};
            var ___result = RInternal_Create_KeyframeArray.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual System.Boolean Internal_Equals(System.IntPtr  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RInternal_Equals_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Single Evaluate(System.Single  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time};
            var ___result = REvaluate_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Int32 AddKey(System.Single  @time, System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time, @value};
            var ___result = RAddKey_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 AddKey(UnityEngine.Keyframe  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RAddKey_Keyframe.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 AddKey_Internal(UnityEngine.Keyframe  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RAddKey_Internal_Keyframe.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 MoveKey(System.Int32  @index, UnityEngine.Keyframe  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @key};
            var ___result = RMoveKey_Int32_Keyframe.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void RemoveKey(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RRemoveKey_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetKeys(UnityEngine.Keyframe[]  @keys)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keys};
            var ___result = RSetKeys_KeyframeArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Keyframe GetKey(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetKey_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Keyframe)___result;
        }


        public virtual UnityEngine.Keyframe[] GetKeys()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetKeys.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Keyframe[])___result;
        }


        public virtual void SmoothTangents(System.Int32  @index, System.Single  @weight)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @weight};
            var ___result = RSmoothTangents_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.AnimationCurve Constant(System.Single  @timeStart, System.Single  @timeEnd, System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeStart, @timeEnd, @value};
            var ___result = RConstant_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AnimationCurve)___result;
        }


        public static UnityEngine.AnimationCurve Linear(System.Single  @timeStart, System.Single  @valueStart, System.Single  @timeEnd, System.Single  @valueEnd)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeStart, @valueStart, @timeEnd, @valueEnd};
            var ___result = RLinear_Single_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AnimationCurve)___result;
        }


        public static UnityEngine.AnimationCurve EaseInOut(System.Single  @timeStart, System.Single  @valueStart, System.Single  @timeEnd, System.Single  @valueEnd)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeStart, @valueStart, @timeEnd, @valueEnd};
            var ___result = REaseInOut_Single_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AnimationCurve)___result;
        }


        public virtual System.Boolean Equals(System.Object  @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.AnimationCurve  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_AnimationCurve.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 AddKey_Internal_Injected(ref UnityEngine.Keyframe  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RAddKey_Internal_Injected_Ref_Keyframe.Invoke(___genericsType, ___parameters);
			key = (UnityEngine.Keyframe)___parameters[0];

            return (System.Int32)___result;
        }


        public virtual System.Int32 MoveKey_Injected(System.Int32  @index, ref UnityEngine.Keyframe  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @key};
            var ___result = RMoveKey_Injected_Int32_Ref_Keyframe.Invoke(___genericsType, ___parameters);
			key = (UnityEngine.Keyframe)___parameters[1];

            return (System.Int32)___result;
        }


        public virtual void GetKey_Injected(System.Int32  @index, out UnityEngine.Keyframe  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @ret};
            var ___result = RGetKey_Injected_Int32_Out_Keyframe.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Keyframe)___parameters[1];

            
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
