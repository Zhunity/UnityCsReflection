
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
	/// UnityEngine.Rendering.AsyncRequestNativeArrayData
	/// </summary>
    public partial class RAsyncRequestNativeArrayData : RMember //
    {

		/// <summary>
		/// System.Void* nativeArrayBuffer
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldPointer<SMFrame.Editor.Refleaction.RField> r_FnativeArrayBuffer;
		public virtual SMFrame.Editor.Refleaction.RFieldPointer<SMFrame.Editor.Refleaction.RField> RFnativeArrayBuffer
		{
			get
			{
				if(r_FnativeArrayBuffer == null)
				{
					r_FnativeArrayBuffer = new(this, "nativeArrayBuffer");
					r_FnativeArrayBuffer.SetBelong(this.instance);
				}
				return r_FnativeArrayBuffer;
			}
		}

		/// <summary>
		/// System.Int64 lengthInBytes
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt64 r_FlengthInBytes;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt64 RFlengthInBytes
		{
			get
			{
				if(r_FlengthInBytes == null)
				{
					r_FlengthInBytes = new(this, "lengthInBytes");
					r_FlengthInBytes.SetBelong(this.instance);
				}
				return r_FlengthInBytes;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle safetyHandle
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnity.RCollections.RLowLevel.RUnsafe.RAtomicSafetyHandle r_FsafetyHandle;
		public virtual SMFrame.Editor.Refleaction.RUnity.RCollections.RLowLevel.RUnsafe.RAtomicSafetyHandle RFsafetyHandle
		{
			get
			{
				if(r_FsafetyHandle == null)
				{
					r_FsafetyHandle = new(this, "safetyHandle");
					r_FsafetyHandle.SetBelong(this.instance);
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
					r_MCreateAndCheckAccess_GT_NativeArray_d_T_p_ = new( ReflectionUtils.GetType("UnityEngine.Rendering.AsyncRequestNativeArrayData"), "CreateAndCheckAccess", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MCreateAndCheckAccess_GT_NativeArray_d_T_p_.SetBelong(null);
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
					r_MCreateAndCheckAccess_GT_NativeSlice_d_T_p_ = new( ReflectionUtils.GetType("UnityEngine.Rendering.AsyncRequestNativeArrayData"), "CreateAndCheckAccess", 1, typeof(Unity.Collections.NativeSlice<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MCreateAndCheckAccess_GT_NativeSlice_d_T_p_.SetBelong(null);
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_MToString.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
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

        public static SMFrame.Editor.Refleaction.RUnityEngine.RRendering.RAsyncRequestNativeArrayData CreateAndCheckAccess<T>(SMFrame.Editor.Refleaction.RUnity.RCollections.RNativeArray<SMFrame.Editor.Refleaction.RType> @array) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array.Value};
            var ___result = RMCreateAndCheckAccess_GT_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnityEngine.RRendering.RAsyncRequestNativeArrayData(___result);
        }


        public static SMFrame.Editor.Refleaction.RUnityEngine.RRendering.RAsyncRequestNativeArrayData CreateAndCheckAccess<T>(SMFrame.Editor.Refleaction.RUnity.RCollections.RNativeSlice<SMFrame.Editor.Refleaction.RType> @array) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array.Value};
            var ___result = RMCreateAndCheckAccess_GT_NativeSlice_d_T_p_.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnityEngine.RRendering.RAsyncRequestNativeArrayData(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
