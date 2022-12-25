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
		protected RFieldPointer<RField> r_nativeArrayBuffer;
		public virtual RFieldPointer<RField> RnativeArrayBuffer
		{
			get
			{
				if(r_nativeArrayBuffer == null)
				{
					r_nativeArrayBuffer = new(this, "nativeArrayBuffer");
					r_nativeArrayBuffer.SetBelong(this.instance);
				}
				return r_nativeArrayBuffer;
			}
		}

		/// <summary>
		/// System.Int64 lengthInBytes
		/// </summary>
		protected RField r_lengthInBytes;
		public virtual RField RlengthInBytes
		{
			get
			{
				if(r_lengthInBytes == null)
				{
					r_lengthInBytes = new(this, "lengthInBytes");
					r_lengthInBytes.SetBelong(this.instance);
				}
				return r_lengthInBytes;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle safetyHandle
		/// </summary>
		protected RUnity.RCollections.RLowLevel.RUnsafe.RAtomicSafetyHandle r_safetyHandle;
		public virtual RUnity.RCollections.RLowLevel.RUnsafe.RAtomicSafetyHandle RsafetyHandle
		{
			get
			{
				if(r_safetyHandle == null)
				{
					r_safetyHandle = new(this, "safetyHandle");
					r_safetyHandle.SetBelong(this.instance);
				}
				return r_safetyHandle;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.AsyncRequestNativeArrayData CreateAndCheckAccess[T](Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected static RMethod r_RCreateAndCheckAccess_GT_NativeArray_d_T_p_;
		public static RMethod RCreateAndCheckAccess_GT_NativeArray_d_T_p_
		{
			get
			{
				if(r_RCreateAndCheckAccess_GT_NativeArray_d_T_p_ == null)
				{
					r_RCreateAndCheckAccess_GT_NativeArray_d_T_p_ = new( ReleactionUtils.GetType("UnityEngine.Rendering.AsyncRequestNativeArrayData"), "CreateAndCheckAccess", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RCreateAndCheckAccess_GT_NativeArray_d_T_p_.SetBelong(null);
				}
				return r_RCreateAndCheckAccess_GT_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.AsyncRequestNativeArrayData CreateAndCheckAccess[T](Unity.Collections.NativeSlice`1[T])
		/// </summary>
		protected static RMethod r_RCreateAndCheckAccess_GT_NativeSlice_d_T_p_;
		public static RMethod RCreateAndCheckAccess_GT_NativeSlice_d_T_p_
		{
			get
			{
				if(r_RCreateAndCheckAccess_GT_NativeSlice_d_T_p_ == null)
				{
					r_RCreateAndCheckAccess_GT_NativeSlice_d_T_p_ = new( ReleactionUtils.GetType("UnityEngine.Rendering.AsyncRequestNativeArrayData"), "CreateAndCheckAccess", 1, typeof(Unity.Collections.NativeSlice<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RCreateAndCheckAccess_GT_NativeSlice_d_T_p_.SetBelong(null);
				}
				return r_RCreateAndCheckAccess_GT_NativeSlice_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
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



        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
