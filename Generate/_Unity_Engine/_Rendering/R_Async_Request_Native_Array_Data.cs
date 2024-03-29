
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.Rendering.AsyncRequestNativeArrayData
	/// </summary>
    public partial class RAsyncRequestNativeArrayData : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.Rendering.AsyncRequestNativeArrayData");
            }
        }

        public RAsyncRequestNativeArrayData() : base("UnityEngine.Rendering.AsyncRequestNativeArrayData")
        {
        }

        public RAsyncRequestNativeArrayData(System.Object instance) : base("UnityEngine.Rendering.AsyncRequestNativeArrayData")
		{
            SetInstance(instance);
		}

        public RAsyncRequestNativeArrayData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAsyncRequestNativeArrayData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Void* nativeArrayBuffer
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldPointer<Hvak.Editor.Refleaction.RField> r_FnativeArrayBuffer;
		public virtual Hvak.Editor.Refleaction.RFieldPointer<Hvak.Editor.Refleaction.RField> RFnativeArrayBuffer
		{
			get
			{
				if(r_FnativeArrayBuffer == null)
				{
					r_FnativeArrayBuffer = new(this, "nativeArrayBuffer");
				}
				return r_FnativeArrayBuffer;
			}
		}

		/// <summary>
		/// System.Int64 lengthInBytes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_FlengthInBytes;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RFlengthInBytes
		{
			get
			{
				if(r_FlengthInBytes == null)
				{
					r_FlengthInBytes = new(this, "lengthInBytes");
				}
				return r_FlengthInBytes;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle safetyHandle
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnity.RCollections.RLowLevel.RUnsafe.RAtomicSafetyHandle r_FsafetyHandle;
		public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RLowLevel.RUnsafe.RAtomicSafetyHandle RFsafetyHandle
		{
			get
			{
				if(r_FsafetyHandle == null)
				{
					r_FsafetyHandle = new(this, "safetyHandle");
				}
				return r_FsafetyHandle;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.AsyncRequestNativeArrayData CreateAndCheckAccess[T](Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected static RMethod r_MCreateAndCheckAccess_GT_NativeArray_d_T_p_;
		public static RMethod RMCreateAndCheckAccess_GT_NativeArray_d_T_p_
		{
			get
			{
				if(r_MCreateAndCheckAccess_GT_NativeArray_d_T_p_ == null)
				{
					r_MCreateAndCheckAccess_GT_NativeArray_d_T_p_ = new(Type, "CreateAndCheckAccess", 1,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MCreateAndCheckAccess_GT_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.AsyncRequestNativeArrayData CreateAndCheckAccess[T](Unity.Collections.NativeSlice`1[T])
		/// </summary>
		protected static RMethod r_MCreateAndCheckAccess_GT_NativeSlice_d_T_p_;
		public static RMethod RMCreateAndCheckAccess_GT_NativeSlice_d_T_p_
		{
			get
			{
				if(r_MCreateAndCheckAccess_GT_NativeSlice_d_T_p_ == null)
				{
					r_MCreateAndCheckAccess_GT_NativeSlice_d_T_p_ = new(Type, "CreateAndCheckAccess", 1,  ReflectionUtils.GetType("Unity.Collections.NativeSlice`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MCreateAndCheckAccess_GT_NativeSlice_d_T_p_;
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


        public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RAsyncRequestNativeArrayData CreateAndCheckAccess<T>(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @array) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array.Value};
            var ___result = RMCreateAndCheckAccess_GT_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RRendering.RAsyncRequestNativeArrayData>(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RAsyncRequestNativeArrayData CreateAndCheckAccess<T>(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType> @array) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array.Value};
            var ___result = RMCreateAndCheckAccess_GT_NativeSlice_d_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RRendering.RAsyncRequestNativeArrayData>(___result);
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
