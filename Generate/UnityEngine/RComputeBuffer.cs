using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.ComputeBuffer
	/// </summary>
    public partial class RComputeBuffer : RMember //
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
		/// Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle m_Safety
		/// </summary>
		protected RUnity.RCollections.RLowLevel.RUnsafe.RAtomicSafetyHandle r_m_Safety;
		public virtual RUnity.RCollections.RLowLevel.RUnsafe.RAtomicSafetyHandle Rm_Safety
		{
			get
			{
				if(r_m_Safety == null)
				{
					r_m_Safety = new(this, "m_Safety");
					r_m_Safety.SetBelong(this.instance);
				}
				return r_m_Safety;
			}
		}

		/// <summary>
		/// Int32 count
		/// </summary>
		protected RProperty r_count;
		public virtual RProperty Rcount
		{
			get
			{
				if(r_count == null)
				{
					r_count = new(this, "count", -1);
					r_count.SetBelong(this.instance);
				}
				return r_count;
			}
		}

		/// <summary>
		/// Int32 stride
		/// </summary>
		protected RProperty r_stride;
		public virtual RProperty Rstride
		{
			get
			{
				if(r_stride == null)
				{
					r_stride = new(this, "stride", -1);
					r_stride.SetBelong(this.instance);
				}
				return r_stride;
			}
		}

		/// <summary>
		/// UnityEngine.ComputeBufferMode usage
		/// </summary>
		protected RProperty r_usage;
		public virtual RProperty Rusage
		{
			get
			{
				if(r_usage == null)
				{
					r_usage = new(this, "usage", -1);
					r_usage.SetBelong(this.instance);
				}
				return r_usage;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RProperty r_name;
		public virtual RProperty Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name", -1, typeof(System.String));
					r_name.SetBelong(this.instance);
				}
				return r_name;
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
		/// Void Dispose()
		/// </summary>
		protected RMethod r_Dispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_Dispose == null)
				{
					r_Dispose = new(this, "Dispose", 0);
					r_Dispose.SetBelong(this.instance);
				}
				return r_Dispose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_Dispose_Boolean;
		public virtual RMethod RDispose_Boolean
		{
			get
			{
				if(r_Dispose_Boolean == null)
				{
					r_Dispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_Dispose_Boolean.SetBelong(this.instance);
				}
				return r_Dispose_Boolean;
			}
		}

		/// <summary>
		/// IntPtr InitBuffer(Int32, Int32, UnityEngine.ComputeBufferType, UnityEngine.ComputeBufferMode)
		/// </summary>
		protected static RMethod r_InitBuffer_Int32_Int32_ComputeBufferType_ComputeBufferMode;
		public static RMethod RInitBuffer_Int32_Int32_ComputeBufferType_ComputeBufferMode
		{
			get
			{
				if(r_InitBuffer_Int32_Int32_ComputeBufferType_ComputeBufferMode == null)
				{
					r_InitBuffer_Int32_Int32_ComputeBufferType_ComputeBufferMode = new(typeof(UnityEngine.ComputeBuffer), "InitBuffer", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.ComputeBufferType), typeof(UnityEngine.ComputeBufferMode));
					r_InitBuffer_Int32_Int32_ComputeBufferType_ComputeBufferMode.SetBelong(null);
				}
				return r_InitBuffer_Int32_Int32_ComputeBufferType_ComputeBufferMode;
			}
		}

		/// <summary>
		/// Void DestroyBuffer(UnityEngine.ComputeBuffer)
		/// </summary>
		protected static RMethod r_DestroyBuffer_ComputeBuffer;
		public static RMethod RDestroyBuffer_ComputeBuffer
		{
			get
			{
				if(r_DestroyBuffer_ComputeBuffer == null)
				{
					r_DestroyBuffer_ComputeBuffer = new(typeof(UnityEngine.ComputeBuffer), "DestroyBuffer", 0, typeof(UnityEngine.ComputeBuffer));
					r_DestroyBuffer_ComputeBuffer.SetBelong(null);
				}
				return r_DestroyBuffer_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void Release()
		/// </summary>
		protected RMethod r_Release;
		public virtual RMethod RRelease
		{
			get
			{
				if(r_Release == null)
				{
					r_Release = new(this, "Release", 0);
					r_Release.SetBelong(this.instance);
				}
				return r_Release;
			}
		}

		/// <summary>
		/// Boolean IsValidBuffer(UnityEngine.ComputeBuffer)
		/// </summary>
		protected static RMethod r_IsValidBuffer_ComputeBuffer;
		public static RMethod RIsValidBuffer_ComputeBuffer
		{
			get
			{
				if(r_IsValidBuffer_ComputeBuffer == null)
				{
					r_IsValidBuffer_ComputeBuffer = new(typeof(UnityEngine.ComputeBuffer), "IsValidBuffer", 0, typeof(UnityEngine.ComputeBuffer));
					r_IsValidBuffer_ComputeBuffer.SetBelong(null);
				}
				return r_IsValidBuffer_ComputeBuffer;
			}
		}

		/// <summary>
		/// Boolean IsValid()
		/// </summary>
		protected RMethod r_IsValid;
		public virtual RMethod RIsValid
		{
			get
			{
				if(r_IsValid == null)
				{
					r_IsValid = new(this, "IsValid", 0);
					r_IsValid.SetBelong(this.instance);
				}
				return r_IsValid;
			}
		}

		/// <summary>
		/// Void SetData(System.Array)
		/// </summary>
		protected RMethod r_SetData_Array;
		public virtual RMethod RSetData_Array
		{
			get
			{
				if(r_SetData_Array == null)
				{
					r_SetData_Array = new(this, "SetData", 0, typeof(System.Array));
					r_SetData_Array.SetBelong(this.instance);
				}
				return r_SetData_Array;
			}
		}

		/// <summary>
		/// Void SetData[T](System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_SetData_GT_List_d_T_p_;
		public virtual RMethod RSetData_GT_List_d_T_p_
		{
			get
			{
				if(r_SetData_GT_List_d_T_p_ == null)
				{
					r_SetData_GT_List_d_T_p_ = new(this, "SetData", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_SetData_GT_List_d_T_p_.SetBelong(this.instance);
				}
				return r_SetData_GT_List_d_T_p_;
			}
		}

		/// <summary>
		/// Void SetData[T](Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_SetData_GT_NativeArray_d_T_p_;
		public virtual RMethod RSetData_GT_NativeArray_d_T_p_
		{
			get
			{
				if(r_SetData_GT_NativeArray_d_T_p_ == null)
				{
					r_SetData_GT_NativeArray_d_T_p_ = new(this, "SetData", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_SetData_GT_NativeArray_d_T_p_.SetBelong(this.instance);
				}
				return r_SetData_GT_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void SetData(System.Array, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_SetData_Array_Int32_Int32_Int32;
		public virtual RMethod RSetData_Array_Int32_Int32_Int32
		{
			get
			{
				if(r_SetData_Array_Int32_Int32_Int32 == null)
				{
					r_SetData_Array_Int32_Int32_Int32 = new(this, "SetData", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_SetData_Array_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_SetData_Array_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetData[T](System.Collections.Generic.List`1[T], Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_SetData_GT_List_d_T_p__Int32_Int32_Int32;
		public virtual RMethod RSetData_GT_List_d_T_p__Int32_Int32_Int32
		{
			get
			{
				if(r_SetData_GT_List_d_T_p__Int32_Int32_Int32 == null)
				{
					r_SetData_GT_List_d_T_p__Int32_Int32_Int32 = new(this, "SetData", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_SetData_GT_List_d_T_p__Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_SetData_GT_List_d_T_p__Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetData[T](Unity.Collections.NativeArray`1[T], Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_SetData_GT_NativeArray_d_T_p__Int32_Int32_Int32;
		public virtual RMethod RSetData_GT_NativeArray_d_T_p__Int32_Int32_Int32
		{
			get
			{
				if(r_SetData_GT_NativeArray_d_T_p__Int32_Int32_Int32 == null)
				{
					r_SetData_GT_NativeArray_d_T_p__Int32_Int32_Int32 = new(this, "SetData", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_SetData_GT_NativeArray_d_T_p__Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_SetData_GT_NativeArray_d_T_p__Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void InternalSetNativeData(IntPtr, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_InternalSetNativeData_IntPtr_Int32_Int32_Int32_Int32;
		public virtual RMethod RInternalSetNativeData_IntPtr_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_InternalSetNativeData_IntPtr_Int32_Int32_Int32_Int32 == null)
				{
					r_InternalSetNativeData_IntPtr_Int32_Int32_Int32_Int32 = new(this, "InternalSetNativeData", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_InternalSetNativeData_IntPtr_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_InternalSetNativeData_IntPtr_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void InternalSetData(System.Array, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_InternalSetData_Array_Int32_Int32_Int32_Int32;
		public virtual RMethod RInternalSetData_Array_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_InternalSetData_Array_Int32_Int32_Int32_Int32 == null)
				{
					r_InternalSetData_Array_Int32_Int32_Int32_Int32 = new(this, "InternalSetData", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_InternalSetData_Array_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_InternalSetData_Array_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void GetData(System.Array)
		/// </summary>
		protected RMethod r_GetData_Array;
		public virtual RMethod RGetData_Array
		{
			get
			{
				if(r_GetData_Array == null)
				{
					r_GetData_Array = new(this, "GetData", 0, typeof(System.Array));
					r_GetData_Array.SetBelong(this.instance);
				}
				return r_GetData_Array;
			}
		}

		/// <summary>
		/// Void GetData(System.Array, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_GetData_Array_Int32_Int32_Int32;
		public virtual RMethod RGetData_Array_Int32_Int32_Int32
		{
			get
			{
				if(r_GetData_Array_Int32_Int32_Int32 == null)
				{
					r_GetData_Array_Int32_Int32_Int32 = new(this, "GetData", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_GetData_Array_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_GetData_Array_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void InternalGetData(System.Array, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_InternalGetData_Array_Int32_Int32_Int32_Int32;
		public virtual RMethod RInternalGetData_Array_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_InternalGetData_Array_Int32_Int32_Int32_Int32 == null)
				{
					r_InternalGetData_Array_Int32_Int32_Int32_Int32 = new(this, "InternalGetData", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_InternalGetData_Array_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_InternalGetData_Array_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void* BeginBufferWrite(Int32, Int32)
		/// </summary>
		protected RMethod r_BeginBufferWrite_Int32_Int32;
		public virtual RMethod RBeginBufferWrite_Int32_Int32
		{
			get
			{
				if(r_BeginBufferWrite_Int32_Int32 == null)
				{
					r_BeginBufferWrite_Int32_Int32 = new(this, "BeginBufferWrite", 0, typeof(System.Int32), typeof(System.Int32));
					r_BeginBufferWrite_Int32_Int32.SetBelong(this.instance);
				}
				return r_BeginBufferWrite_Int32_Int32;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[T] BeginWrite[T](Int32, Int32)
		/// </summary>
		protected RMethod r_BeginWrite_GT_Int32_Int32;
		public virtual RMethod RBeginWrite_GT_Int32_Int32
		{
			get
			{
				if(r_BeginWrite_GT_Int32_Int32 == null)
				{
					r_BeginWrite_GT_Int32_Int32 = new(this, "BeginWrite", 1, typeof(System.Int32), typeof(System.Int32));
					r_BeginWrite_GT_Int32_Int32.SetBelong(this.instance);
				}
				return r_BeginWrite_GT_Int32_Int32;
			}
		}

		/// <summary>
		/// Void EndBufferWrite(Int32)
		/// </summary>
		protected RMethod r_EndBufferWrite_Int32;
		public virtual RMethod REndBufferWrite_Int32
		{
			get
			{
				if(r_EndBufferWrite_Int32 == null)
				{
					r_EndBufferWrite_Int32 = new(this, "EndBufferWrite", 0, typeof(System.Int32));
					r_EndBufferWrite_Int32.SetBelong(this.instance);
				}
				return r_EndBufferWrite_Int32;
			}
		}

		/// <summary>
		/// Void EndWrite[T](Int32)
		/// </summary>
		protected RMethod r_EndWrite_GT_Int32;
		public virtual RMethod REndWrite_GT_Int32
		{
			get
			{
				if(r_EndWrite_GT_Int32 == null)
				{
					r_EndWrite_GT_Int32 = new(this, "EndWrite", 1, typeof(System.Int32));
					r_EndWrite_GT_Int32.SetBelong(this.instance);
				}
				return r_EndWrite_GT_Int32;
			}
		}

		/// <summary>
		/// Void SetName(System.String)
		/// </summary>
		protected RMethod r_SetName_String;
		public virtual RMethod RSetName_String
		{
			get
			{
				if(r_SetName_String == null)
				{
					r_SetName_String = new(this, "SetName", 0, typeof(System.String));
					r_SetName_String.SetBelong(this.instance);
				}
				return r_SetName_String;
			}
		}

		/// <summary>
		/// Void SetCounterValue(UInt32)
		/// </summary>
		protected RMethod r_SetCounterValue_UInt32;
		public virtual RMethod RSetCounterValue_UInt32
		{
			get
			{
				if(r_SetCounterValue_UInt32 == null)
				{
					r_SetCounterValue_UInt32 = new(this, "SetCounterValue", 0, typeof(System.UInt32));
					r_SetCounterValue_UInt32.SetBelong(this.instance);
				}
				return r_SetCounterValue_UInt32;
			}
		}

		/// <summary>
		/// Void CopyCount(UnityEngine.ComputeBuffer, UnityEngine.ComputeBuffer, Int32)
		/// </summary>
		protected static RMethod r_CopyCount_ComputeBuffer_ComputeBuffer_Int32;
		public static RMethod RCopyCount_ComputeBuffer_ComputeBuffer_Int32
		{
			get
			{
				if(r_CopyCount_ComputeBuffer_ComputeBuffer_Int32 == null)
				{
					r_CopyCount_ComputeBuffer_ComputeBuffer_Int32 = new(typeof(UnityEngine.ComputeBuffer), "CopyCount", 0, typeof(UnityEngine.ComputeBuffer), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32));
					r_CopyCount_ComputeBuffer_ComputeBuffer_Int32.SetBelong(null);
				}
				return r_CopyCount_ComputeBuffer_ComputeBuffer_Int32;
			}
		}

		/// <summary>
		/// IntPtr GetNativeBufferPtr()
		/// </summary>
		protected RMethod r_GetNativeBufferPtr;
		public virtual RMethod RGetNativeBufferPtr
		{
			get
			{
				if(r_GetNativeBufferPtr == null)
				{
					r_GetNativeBufferPtr = new(this, "GetNativeBufferPtr", 0);
					r_GetNativeBufferPtr.SetBelong(this.instance);
				}
				return r_GetNativeBufferPtr;
			}
		}

		/// <summary>
		/// Void AddBufferToLeakDetector()
		/// </summary>
		protected RMethod r_AddBufferToLeakDetector;
		public virtual RMethod RAddBufferToLeakDetector
		{
			get
			{
				if(r_AddBufferToLeakDetector == null)
				{
					r_AddBufferToLeakDetector = new(this, "AddBufferToLeakDetector", 0);
					r_AddBufferToLeakDetector.SetBelong(this.instance);
				}
				return r_AddBufferToLeakDetector;
			}
		}

		/// <summary>
		/// Void RemoveBufferFromLeakDetector()
		/// </summary>
		protected RMethod r_RemoveBufferFromLeakDetector;
		public virtual RMethod RRemoveBufferFromLeakDetector
		{
			get
			{
				if(r_RemoveBufferFromLeakDetector == null)
				{
					r_RemoveBufferFromLeakDetector = new(this, "RemoveBufferFromLeakDetector", 0);
					r_RemoveBufferFromLeakDetector.SetBelong(this.instance);
				}
				return r_RemoveBufferFromLeakDetector;
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

        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean  @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.IntPtr InitBuffer(System.Int32  @count, System.Int32  @stride, UnityEngine.ComputeBufferType  @type, UnityEngine.ComputeBufferMode  @usage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@count, @stride, @type, @usage};
            var ___result = RInitBuffer_Int32_Int32_ComputeBufferType_ComputeBufferMode.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static void DestroyBuffer(UnityEngine.ComputeBuffer  @buf)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buf};
            var ___result = RDestroyBuffer_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Release()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRelease.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsValidBuffer(UnityEngine.ComputeBuffer  @buf)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buf};
            var ___result = RIsValidBuffer_ComputeBuffer.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsValid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsValid.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetData(System.Array  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = RSetData_Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetData<T>(System.Collections.Generic.List<T>  @data) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data};
            var ___result = RSetData_GT_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void SetData(System.Array  @data, System.Int32  @managedBufferStartIndex, System.Int32  @computeBufferStartIndex, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @managedBufferStartIndex, @computeBufferStartIndex, @count};
            var ___result = RSetData_Array_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetData<T>(System.Collections.Generic.List<T>  @data, System.Int32  @managedBufferStartIndex, System.Int32  @computeBufferStartIndex, System.Int32  @count) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data, @managedBufferStartIndex, @computeBufferStartIndex, @count};
            var ___result = RSetData_GT_List_d_T_p__Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void InternalSetNativeData(System.IntPtr  @data, System.Int32  @nativeBufferStartIndex, System.Int32  @computeBufferStartIndex, System.Int32  @count, System.Int32  @elemSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @nativeBufferStartIndex, @computeBufferStartIndex, @count, @elemSize};
            var ___result = RInternalSetNativeData_IntPtr_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalSetData(System.Array  @data, System.Int32  @managedBufferStartIndex, System.Int32  @computeBufferStartIndex, System.Int32  @count, System.Int32  @elemSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @managedBufferStartIndex, @computeBufferStartIndex, @count, @elemSize};
            var ___result = RInternalSetData_Array_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetData(System.Array  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = RGetData_Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetData(System.Array  @data, System.Int32  @managedBufferStartIndex, System.Int32  @computeBufferStartIndex, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @managedBufferStartIndex, @computeBufferStartIndex, @count};
            var ___result = RGetData_Array_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalGetData(System.Array  @data, System.Int32  @managedBufferStartIndex, System.Int32  @computeBufferStartIndex, System.Int32  @count, System.Int32  @elemSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @managedBufferStartIndex, @computeBufferStartIndex, @count, @elemSize};
            var ___result = RInternalGetData_Array_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Object BeginWrite<T>(System.Int32  @computeBufferStartIndex, System.Int32  @count) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@computeBufferStartIndex, @count};
            var ___result = RBeginWrite_GT_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void EndBufferWrite(System.Int32  @bytesWritten)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytesWritten};
            var ___result = REndBufferWrite_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EndWrite<T>(System.Int32  @countWritten) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@countWritten};
            var ___result = REndWrite_GT_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetName(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RSetName_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCounterValue(System.UInt32  @counterValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@counterValue};
            var ___result = RSetCounterValue_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public static void CopyCount(UnityEngine.ComputeBuffer  @src, UnityEngine.ComputeBuffer  @dst, System.Int32  @dstOffsetBytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst, @dstOffsetBytes};
            var ___result = RCopyCount_ComputeBuffer_ComputeBuffer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IntPtr GetNativeBufferPtr()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetNativeBufferPtr.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual void AddBufferToLeakDetector()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAddBufferToLeakDetector.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveBufferFromLeakDetector()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRemoveBufferFromLeakDetector.Invoke(___genericsType, ___parameters);

            
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
