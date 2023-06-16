
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.ComputeBuffer
	/// </summary>
    public partial class RComputeBuffer : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.ComputeBuffer);
            }
        }

        public RComputeBuffer() : base("UnityEngine.ComputeBuffer")
        {
        }

        public RComputeBuffer(System.Object instance) : base("UnityEngine.ComputeBuffer")
		{
            SetInstance(instance);
		}

        public RComputeBuffer(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RComputeBuffer(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


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
		/// Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle m_Safety
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnity.RCollections.RLowLevel.RUnsafe.RAtomicSafetyHandle r_Fm_Safety;
		public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RLowLevel.RUnsafe.RAtomicSafetyHandle RFm_Safety
		{
			get
			{
				if(r_Fm_Safety == null)
				{
					r_Fm_Safety = new(this, "m_Safety");
				}
				return r_Fm_Safety;
			}
		}

		/// <summary>
		/// Int32 count
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Pcount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPcount
		{
			get
			{
				if(r_Pcount == null)
				{
					r_Pcount = new(this, "count", -1);
				}
				return r_Pcount;
			}
		}

		/// <summary>
		/// Int32 stride
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Pstride;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPstride
		{
			get
			{
				if(r_Pstride == null)
				{
					r_Pstride = new(this, "stride", -1);
				}
				return r_Pstride;
			}
		}

		/// <summary>
		/// UnityEngine.ComputeBufferMode usage
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RComputeBufferMode r_Pusage;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RComputeBufferMode RPusage
		{
			get
			{
				if(r_Pusage == null)
				{
					r_Pusage = new(this, "usage", -1);
				}
				return r_Pusage;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
				}
				return r_Pname;
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
		/// Void Dispose()
		/// </summary>
		protected RMethod r_MDispose;
		public virtual RMethod RMDispose
		{
			get
			{
				if(r_MDispose == null)
				{
					r_MDispose = new(this, "Dispose", 0);
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_MDispose_Boolean;
		public virtual RMethod RMDispose_Boolean
		{
			get
			{
				if(r_MDispose_Boolean == null)
				{
					r_MDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
				}
				return r_MDispose_Boolean;
			}
		}

		/// <summary>
		/// IntPtr InitBuffer(Int32, Int32, UnityEngine.ComputeBufferType, UnityEngine.ComputeBufferMode)
		/// </summary>
		protected static RMethod r_MInitBuffer_Int32_Int32_ComputeBufferType_ComputeBufferMode;
		public static RMethod RMInitBuffer_Int32_Int32_ComputeBufferType_ComputeBufferMode
		{
			get
			{
				if(r_MInitBuffer_Int32_Int32_ComputeBufferType_ComputeBufferMode == null)
				{
					r_MInitBuffer_Int32_Int32_ComputeBufferType_ComputeBufferMode = new(Type, "InitBuffer", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.ComputeBufferType), typeof(UnityEngine.ComputeBufferMode));
				}
				return r_MInitBuffer_Int32_Int32_ComputeBufferType_ComputeBufferMode;
			}
		}

		/// <summary>
		/// Void DestroyBuffer(UnityEngine.ComputeBuffer)
		/// </summary>
		protected static RMethod r_MDestroyBuffer_ComputeBuffer;
		public static RMethod RMDestroyBuffer_ComputeBuffer
		{
			get
			{
				if(r_MDestroyBuffer_ComputeBuffer == null)
				{
					r_MDestroyBuffer_ComputeBuffer = new(Type, "DestroyBuffer", 0, typeof(UnityEngine.ComputeBuffer));
				}
				return r_MDestroyBuffer_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void Release()
		/// </summary>
		protected RMethod r_MRelease;
		public virtual RMethod RMRelease
		{
			get
			{
				if(r_MRelease == null)
				{
					r_MRelease = new(this, "Release", 0);
				}
				return r_MRelease;
			}
		}

		/// <summary>
		/// Boolean IsValidBuffer(UnityEngine.ComputeBuffer)
		/// </summary>
		protected static RMethod r_MIsValidBuffer_ComputeBuffer;
		public static RMethod RMIsValidBuffer_ComputeBuffer
		{
			get
			{
				if(r_MIsValidBuffer_ComputeBuffer == null)
				{
					r_MIsValidBuffer_ComputeBuffer = new(Type, "IsValidBuffer", 0, typeof(UnityEngine.ComputeBuffer));
				}
				return r_MIsValidBuffer_ComputeBuffer;
			}
		}

		/// <summary>
		/// Boolean IsValid()
		/// </summary>
		protected RMethod r_MIsValid;
		public virtual RMethod RMIsValid
		{
			get
			{
				if(r_MIsValid == null)
				{
					r_MIsValid = new(this, "IsValid", 0);
				}
				return r_MIsValid;
			}
		}

		/// <summary>
		/// Void SetData(System.Array)
		/// </summary>
		protected RMethod r_MSetData_Array;
		public virtual RMethod RMSetData_Array
		{
			get
			{
				if(r_MSetData_Array == null)
				{
					r_MSetData_Array = new(this, "SetData", 0, typeof(System.Array));
				}
				return r_MSetData_Array;
			}
		}

		/// <summary>
		/// Void SetData[T](System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_MSetData_GT_List_d_T_p_;
		public virtual RMethod RMSetData_GT_List_d_T_p_
		{
			get
			{
				if(r_MSetData_GT_List_d_T_p_ == null)
				{
					r_MSetData_GT_List_d_T_p_ = new(this, "SetData", 1,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MSetData_GT_List_d_T_p_;
			}
		}

		/// <summary>
		/// Void SetData[T](Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_MSetData_GT_NativeArray_d_T_p_;
		public virtual RMethod RMSetData_GT_NativeArray_d_T_p_
		{
			get
			{
				if(r_MSetData_GT_NativeArray_d_T_p_ == null)
				{
					r_MSetData_GT_NativeArray_d_T_p_ = new(this, "SetData", 1,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MSetData_GT_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void SetData(System.Array, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetData_Array_Int32_Int32_Int32;
		public virtual RMethod RMSetData_Array_Int32_Int32_Int32
		{
			get
			{
				if(r_MSetData_Array_Int32_Int32_Int32 == null)
				{
					r_MSetData_Array_Int32_Int32_Int32 = new(this, "SetData", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetData_Array_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetData[T](System.Collections.Generic.List`1[T], Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetData_GT_List_d_T_p__Int32_Int32_Int32;
		public virtual RMethod RMSetData_GT_List_d_T_p__Int32_Int32_Int32
		{
			get
			{
				if(r_MSetData_GT_List_d_T_p__Int32_Int32_Int32 == null)
				{
					r_MSetData_GT_List_d_T_p__Int32_Int32_Int32 = new(this, "SetData", 1,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetData_GT_List_d_T_p__Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetData[T](Unity.Collections.NativeArray`1[T], Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetData_GT_NativeArray_d_T_p__Int32_Int32_Int32;
		public virtual RMethod RMSetData_GT_NativeArray_d_T_p__Int32_Int32_Int32
		{
			get
			{
				if(r_MSetData_GT_NativeArray_d_T_p__Int32_Int32_Int32 == null)
				{
					r_MSetData_GT_NativeArray_d_T_p__Int32_Int32_Int32 = new(this, "SetData", 1,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetData_GT_NativeArray_d_T_p__Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void InternalSetNativeData(IntPtr, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MInternalSetNativeData_IntPtr_Int32_Int32_Int32_Int32;
		public virtual RMethod RMInternalSetNativeData_IntPtr_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MInternalSetNativeData_IntPtr_Int32_Int32_Int32_Int32 == null)
				{
					r_MInternalSetNativeData_IntPtr_Int32_Int32_Int32_Int32 = new(this, "InternalSetNativeData", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MInternalSetNativeData_IntPtr_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void InternalSetData(System.Array, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MInternalSetData_Array_Int32_Int32_Int32_Int32;
		public virtual RMethod RMInternalSetData_Array_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MInternalSetData_Array_Int32_Int32_Int32_Int32 == null)
				{
					r_MInternalSetData_Array_Int32_Int32_Int32_Int32 = new(this, "InternalSetData", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MInternalSetData_Array_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void GetData(System.Array)
		/// </summary>
		protected RMethod r_MGetData_Array;
		public virtual RMethod RMGetData_Array
		{
			get
			{
				if(r_MGetData_Array == null)
				{
					r_MGetData_Array = new(this, "GetData", 0, typeof(System.Array));
				}
				return r_MGetData_Array;
			}
		}

		/// <summary>
		/// Void GetData(System.Array, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MGetData_Array_Int32_Int32_Int32;
		public virtual RMethod RMGetData_Array_Int32_Int32_Int32
		{
			get
			{
				if(r_MGetData_Array_Int32_Int32_Int32 == null)
				{
					r_MGetData_Array_Int32_Int32_Int32 = new(this, "GetData", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MGetData_Array_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void InternalGetData(System.Array, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MInternalGetData_Array_Int32_Int32_Int32_Int32;
		public virtual RMethod RMInternalGetData_Array_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MInternalGetData_Array_Int32_Int32_Int32_Int32 == null)
				{
					r_MInternalGetData_Array_Int32_Int32_Int32_Int32 = new(this, "InternalGetData", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MInternalGetData_Array_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void* BeginBufferWrite(Int32, Int32)
		/// </summary>
		protected RMethod r_MBeginBufferWrite_Int32_Int32;
		public virtual RMethod RMBeginBufferWrite_Int32_Int32
		{
			get
			{
				if(r_MBeginBufferWrite_Int32_Int32 == null)
				{
					r_MBeginBufferWrite_Int32_Int32 = new(this, "BeginBufferWrite", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MBeginBufferWrite_Int32_Int32;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[T] BeginWrite[T](Int32, Int32)
		/// </summary>
		protected RMethod r_MBeginWrite_GT_Int32_Int32;
		public virtual RMethod RMBeginWrite_GT_Int32_Int32
		{
			get
			{
				if(r_MBeginWrite_GT_Int32_Int32 == null)
				{
					r_MBeginWrite_GT_Int32_Int32 = new(this, "BeginWrite", 1, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MBeginWrite_GT_Int32_Int32;
			}
		}

		/// <summary>
		/// Void EndBufferWrite(Int32)
		/// </summary>
		protected RMethod r_MEndBufferWrite_Int32;
		public virtual RMethod RMEndBufferWrite_Int32
		{
			get
			{
				if(r_MEndBufferWrite_Int32 == null)
				{
					r_MEndBufferWrite_Int32 = new(this, "EndBufferWrite", 0, typeof(System.Int32));
				}
				return r_MEndBufferWrite_Int32;
			}
		}

		/// <summary>
		/// Void EndWrite[T](Int32)
		/// </summary>
		protected RMethod r_MEndWrite_GT_Int32;
		public virtual RMethod RMEndWrite_GT_Int32
		{
			get
			{
				if(r_MEndWrite_GT_Int32 == null)
				{
					r_MEndWrite_GT_Int32 = new(this, "EndWrite", 1, typeof(System.Int32));
				}
				return r_MEndWrite_GT_Int32;
			}
		}

		/// <summary>
		/// Void SetName(System.String)
		/// </summary>
		protected RMethod r_MSetName_String;
		public virtual RMethod RMSetName_String
		{
			get
			{
				if(r_MSetName_String == null)
				{
					r_MSetName_String = new(this, "SetName", 0, typeof(System.String));
				}
				return r_MSetName_String;
			}
		}

		/// <summary>
		/// Void SetCounterValue(UInt32)
		/// </summary>
		protected RMethod r_MSetCounterValue_UInt32;
		public virtual RMethod RMSetCounterValue_UInt32
		{
			get
			{
				if(r_MSetCounterValue_UInt32 == null)
				{
					r_MSetCounterValue_UInt32 = new(this, "SetCounterValue", 0, typeof(System.UInt32));
				}
				return r_MSetCounterValue_UInt32;
			}
		}

		/// <summary>
		/// Void CopyCount(UnityEngine.ComputeBuffer, UnityEngine.ComputeBuffer, Int32)
		/// </summary>
		protected static RMethod r_MCopyCount_ComputeBuffer_ComputeBuffer_Int32;
		public static RMethod RMCopyCount_ComputeBuffer_ComputeBuffer_Int32
		{
			get
			{
				if(r_MCopyCount_ComputeBuffer_ComputeBuffer_Int32 == null)
				{
					r_MCopyCount_ComputeBuffer_ComputeBuffer_Int32 = new(Type, "CopyCount", 0, typeof(UnityEngine.ComputeBuffer), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32));
				}
				return r_MCopyCount_ComputeBuffer_ComputeBuffer_Int32;
			}
		}

		/// <summary>
		/// IntPtr GetNativeBufferPtr()
		/// </summary>
		protected RMethod r_MGetNativeBufferPtr;
		public virtual RMethod RMGetNativeBufferPtr
		{
			get
			{
				if(r_MGetNativeBufferPtr == null)
				{
					r_MGetNativeBufferPtr = new(this, "GetNativeBufferPtr", 0);
				}
				return r_MGetNativeBufferPtr;
			}
		}

		/// <summary>
		/// Void AddBufferToLeakDetector()
		/// </summary>
		protected RMethod r_MAddBufferToLeakDetector;
		public virtual RMethod RMAddBufferToLeakDetector
		{
			get
			{
				if(r_MAddBufferToLeakDetector == null)
				{
					r_MAddBufferToLeakDetector = new(this, "AddBufferToLeakDetector", 0);
				}
				return r_MAddBufferToLeakDetector;
			}
		}

		/// <summary>
		/// Void RemoveBufferFromLeakDetector()
		/// </summary>
		protected RMethod r_MRemoveBufferFromLeakDetector;
		public virtual RMethod RMRemoveBufferFromLeakDetector
		{
			get
			{
				if(r_MRemoveBufferFromLeakDetector == null)
				{
					r_MRemoveBufferFromLeakDetector = new(this, "RemoveBufferFromLeakDetector", 0);
				}
				return r_MRemoveBufferFromLeakDetector;
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


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RMDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.IntPtr InitBuffer(System.Int32 @count, System.Int32 @stride, UnityEngine.ComputeBufferType @type, UnityEngine.ComputeBufferMode @usage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@count, @stride, @type, @usage};
            var ___result = RMInitBuffer_Int32_Int32_ComputeBufferType_ComputeBufferMode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IntPtr>(___result);
        }


        public static void DestroyBuffer(UnityEngine.ComputeBuffer @buf)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buf};
            var ___result = RMDestroyBuffer_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Release()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRelease.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsValidBuffer(UnityEngine.ComputeBuffer @buf)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buf};
            var ___result = RMIsValidBuffer_ComputeBuffer.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean IsValid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsValid.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void SetData(System.Array @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = RMSetData_Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetData<T>(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RType> @data) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data.Value};
            var ___result = RMSetData_GT_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetData<T>(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @data) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data.Value};
            var ___result = RMSetData_GT_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetData(System.Array @data, System.Int32 @managedBufferStartIndex, System.Int32 @computeBufferStartIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @managedBufferStartIndex, @computeBufferStartIndex, @count};
            var ___result = RMSetData_Array_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetData<T>(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RType> @data, System.Int32 @managedBufferStartIndex, System.Int32 @computeBufferStartIndex, System.Int32 @count) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data.Value, @managedBufferStartIndex, @computeBufferStartIndex, @count};
            var ___result = RMSetData_GT_List_d_T_p__Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetData<T>(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @data, System.Int32 @nativeBufferStartIndex, System.Int32 @computeBufferStartIndex, System.Int32 @count) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data.Value, @nativeBufferStartIndex, @computeBufferStartIndex, @count};
            var ___result = RMSetData_GT_NativeArray_d_T_p__Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalSetNativeData(System.IntPtr @data, System.Int32 @nativeBufferStartIndex, System.Int32 @computeBufferStartIndex, System.Int32 @count, System.Int32 @elemSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @nativeBufferStartIndex, @computeBufferStartIndex, @count, @elemSize};
            var ___result = RMInternalSetNativeData_IntPtr_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalSetData(System.Array @data, System.Int32 @managedBufferStartIndex, System.Int32 @computeBufferStartIndex, System.Int32 @count, System.Int32 @elemSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @managedBufferStartIndex, @computeBufferStartIndex, @count, @elemSize};
            var ___result = RMInternalSetData_Array_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetData(System.Array @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = RMGetData_Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetData(System.Array @data, System.Int32 @managedBufferStartIndex, System.Int32 @computeBufferStartIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @managedBufferStartIndex, @computeBufferStartIndex, @count};
            var ___result = RMGetData_Array_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalGetData(System.Array @data, System.Int32 @managedBufferStartIndex, System.Int32 @computeBufferStartIndex, System.Int32 @count, System.Int32 @elemSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @managedBufferStartIndex, @computeBufferStartIndex, @count, @elemSize};
            var ___result = RMInternalGetData_Array_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe virtual void* BeginBufferWrite(System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@offset, @size};
            var ___result = RMBeginBufferWrite_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (void*)Pointer.Unbox(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> BeginWrite<T>(System.Int32 @computeBufferStartIndex, System.Int32 @count) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@computeBufferStartIndex, @count};
            var ___result = RMBeginWrite_GT_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>>(___result);
        }


        public virtual void EndBufferWrite(System.Int32 @bytesWritten)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytesWritten};
            var ___result = RMEndBufferWrite_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EndWrite<T>(System.Int32 @countWritten) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@countWritten};
            var ___result = RMEndWrite_GT_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetName(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMSetName_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCounterValue(System.UInt32 @counterValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@counterValue};
            var ___result = RMSetCounterValue_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public static void CopyCount(UnityEngine.ComputeBuffer @src, UnityEngine.ComputeBuffer @dst, System.Int32 @dstOffsetBytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst, @dstOffsetBytes};
            var ___result = RMCopyCount_ComputeBuffer_ComputeBuffer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IntPtr GetNativeBufferPtr()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetNativeBufferPtr.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IntPtr>(___result);
        }


        public virtual void AddBufferToLeakDetector()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAddBufferToLeakDetector.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveBufferFromLeakDetector()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRemoveBufferFromLeakDetector.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
