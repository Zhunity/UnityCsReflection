using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnity.RCollections
{
	/// <summary>
	/// Unity.Collections.NativeArray`1
	/// </summary>
    public partial class RNativeArray<T> : RMember // where T : struct
    {

		/// <summary>
		/// System.Void* m_Buffer
		/// </summary>
		protected RFieldPointer<RField> r_m_Buffer;
		public virtual RFieldPointer<RField> Rm_Buffer
		{
			get
			{
				if(r_m_Buffer == null)
				{
					r_m_Buffer = new(this, "m_Buffer");
					r_m_Buffer.SetBelong(this.instance);
				}
				return r_m_Buffer;
			}
		}

		/// <summary>
		/// System.Int32 m_Length
		/// </summary>
		protected RSystem.RInt32 r_m_Length;
		public virtual RSystem.RInt32 Rm_Length
		{
			get
			{
				if(r_m_Length == null)
				{
					r_m_Length = new(this, "m_Length");
					r_m_Length.SetBelong(this.instance);
				}
				return r_m_Length;
			}
		}

		/// <summary>
		/// System.Int32 m_MinIndex
		/// </summary>
		protected RSystem.RInt32 r_m_MinIndex;
		public virtual RSystem.RInt32 Rm_MinIndex
		{
			get
			{
				if(r_m_MinIndex == null)
				{
					r_m_MinIndex = new(this, "m_MinIndex");
					r_m_MinIndex.SetBelong(this.instance);
				}
				return r_m_MinIndex;
			}
		}

		/// <summary>
		/// System.Int32 m_MaxIndex
		/// </summary>
		protected RSystem.RInt32 r_m_MaxIndex;
		public virtual RSystem.RInt32 Rm_MaxIndex
		{
			get
			{
				if(r_m_MaxIndex == null)
				{
					r_m_MaxIndex = new(this, "m_MaxIndex");
					r_m_MaxIndex.SetBelong(this.instance);
				}
				return r_m_MaxIndex;
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
		/// System.Int32 s_staticSafetyId
		/// </summary>
		protected static RSystem.RInt32 r_s_staticSafetyId;
		public static RSystem.RInt32 Rs_staticSafetyId
		{
			get
			{
				if(r_s_staticSafetyId == null)
				{
					r_s_staticSafetyId = new(typeof(Unity.Collections.NativeArray<>), "s_staticSafetyId");
					r_s_staticSafetyId.SetBelong(null);
				}
				return r_s_staticSafetyId;
			}
		}

		/// <summary>
		/// Unity.Collections.Allocator m_AllocatorLabel
		/// </summary>
		protected RField r_m_AllocatorLabel;
		public virtual RField Rm_AllocatorLabel
		{
			get
			{
				if(r_m_AllocatorLabel == null)
				{
					r_m_AllocatorLabel = new(this, "m_AllocatorLabel");
					r_m_AllocatorLabel.SetBelong(this.instance);
				}
				return r_m_AllocatorLabel;
			}
		}

		/// <summary>
		/// Dummy& m_DisposeSentinel
		/// </summary>
		protected RUnity.RCollections.RLowLevel.RUnsafe.RDisposeSentinel.RDummy r_m_DisposeSentinel;
		public virtual RUnity.RCollections.RLowLevel.RUnsafe.RDisposeSentinel.RDummy Rm_DisposeSentinel
		{
			get
			{
				if(r_m_DisposeSentinel == null)
				{
					r_m_DisposeSentinel = new(this, "m_DisposeSentinel", -1);
					r_m_DisposeSentinel.SetBelong(this.instance);
				}
				return r_m_DisposeSentinel;
			}
		}

		/// <summary>
		/// Int32 Length
		/// </summary>
		protected RSystem.RInt32 r_Length;
		public virtual RSystem.RInt32 RLength
		{
			get
			{
				if(r_Length == null)
				{
					r_Length = new(this, "Length", -1);
					r_Length.SetBelong(this.instance);
				}
				return r_Length;
			}
		}

		/// <summary>
		/// T Item [Int32]
		/// </summary>
		protected RProperty r_Item_Int32;
		public virtual RProperty RItem_Int32
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
		/// Boolean IsCreated
		/// </summary>
		protected RSystem.RBoolean r_IsCreated;
		public virtual RSystem.RBoolean RIsCreated
		{
			get
			{
				if(r_IsCreated == null)
				{
					r_IsCreated = new(this, "IsCreated", -1);
					r_IsCreated.SetBelong(this.instance);
				}
				return r_IsCreated;
			}
		}

		/// <summary>
		/// Void InitStaticSafetyId(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_InitStaticSafetyId_Ref_AtomicSafetyHandle;
		public static RMethod RInitStaticSafetyId_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_InitStaticSafetyId_Ref_AtomicSafetyHandle == null)
				{
					r_InitStaticSafetyId_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.NativeArray<>), "InitStaticSafetyId", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_InitStaticSafetyId_Ref_AtomicSafetyHandle.SetBelong(null);
				}
				return r_InitStaticSafetyId_Ref_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void CheckAllocateArguments(Int32, Unity.Collections.Allocator)
		/// </summary>
		protected static RMethod r_CheckAllocateArguments_Int32_Allocator;
		public static RMethod RCheckAllocateArguments_Int32_Allocator
		{
			get
			{
				if(r_CheckAllocateArguments_Int32_Allocator == null)
				{
					r_CheckAllocateArguments_Int32_Allocator = new(typeof(Unity.Collections.NativeArray<>), "CheckAllocateArguments", 0, typeof(System.Int32), typeof(Unity.Collections.Allocator));
					r_CheckAllocateArguments_Int32_Allocator.SetBelong(null);
				}
				return r_CheckAllocateArguments_Int32_Allocator;
			}
		}

		/// <summary>
		/// Void Allocate(Int32, Unity.Collections.Allocator, Unity.Collections.NativeArray`1[T] ByRef)
		/// </summary>
		protected static RMethod r_Allocate_Int32_Allocator_Out_NativeArray_d_T_p_;
		public static RMethod RAllocate_Int32_Allocator_Out_NativeArray_d_T_p_
		{
			get
			{
				if(r_Allocate_Int32_Allocator_Out_NativeArray_d_T_p_ == null)
				{
					r_Allocate_Int32_Allocator_Out_NativeArray_d_T_p_ = new(typeof(Unity.Collections.NativeArray<>), "Allocate", 0, typeof(System.Int32), typeof(Unity.Collections.Allocator), typeof(Unity.Collections.NativeArray<>).MakeByRefType());
					r_Allocate_Int32_Allocator_Out_NativeArray_d_T_p_.SetBelong(null);
				}
				return r_Allocate_Int32_Allocator_Out_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void InitNestedNativeContainer(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_InitNestedNativeContainer_AtomicSafetyHandle;
		public static RMethod RInitNestedNativeContainer_AtomicSafetyHandle
		{
			get
			{
				if(r_InitNestedNativeContainer_AtomicSafetyHandle == null)
				{
					r_InitNestedNativeContainer_AtomicSafetyHandle = new(typeof(Unity.Collections.NativeArray<>), "InitNestedNativeContainer", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
					r_InitNestedNativeContainer_AtomicSafetyHandle.SetBelong(null);
				}
				return r_InitNestedNativeContainer_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void IsUnmanagedAndThrow()
		/// </summary>
		protected static RMethod r_IsUnmanagedAndThrow;
		public static RMethod RIsUnmanagedAndThrow
		{
			get
			{
				if(r_IsUnmanagedAndThrow == null)
				{
					r_IsUnmanagedAndThrow = new(typeof(Unity.Collections.NativeArray<>), "IsUnmanagedAndThrow", 0);
					r_IsUnmanagedAndThrow.SetBelong(null);
				}
				return r_IsUnmanagedAndThrow;
			}
		}

		/// <summary>
		/// Void CheckElementReadAccess(Int32)
		/// </summary>
		protected RMethod r_CheckElementReadAccess_Int32;
		public virtual RMethod RCheckElementReadAccess_Int32
		{
			get
			{
				if(r_CheckElementReadAccess_Int32 == null)
				{
					r_CheckElementReadAccess_Int32 = new(this, "CheckElementReadAccess", 0, typeof(System.Int32));
					r_CheckElementReadAccess_Int32.SetBelong(this.instance);
				}
				return r_CheckElementReadAccess_Int32;
			}
		}

		/// <summary>
		/// Void CheckElementWriteAccess(Int32)
		/// </summary>
		protected RMethod r_CheckElementWriteAccess_Int32;
		public virtual RMethod RCheckElementWriteAccess_Int32
		{
			get
			{
				if(r_CheckElementWriteAccess_Int32 == null)
				{
					r_CheckElementWriteAccess_Int32 = new(this, "CheckElementWriteAccess", 0, typeof(System.Int32));
					r_CheckElementWriteAccess_Int32.SetBelong(this.instance);
				}
				return r_CheckElementWriteAccess_Int32;
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
		/// Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle)
		/// </summary>
		protected RMethod r_Dispose_JobHandle;
		public virtual RMethod RDispose_JobHandle
		{
			get
			{
				if(r_Dispose_JobHandle == null)
				{
					r_Dispose_JobHandle = new(this, "Dispose", 0, typeof(Unity.Jobs.JobHandle));
					r_Dispose_JobHandle.SetBelong(this.instance);
				}
				return r_Dispose_JobHandle;
			}
		}

		/// <summary>
		/// Void CopyFrom(T[])
		/// </summary>
		protected RMethod r_CopyFrom_TArray;
		public virtual RMethod RCopyFrom_TArray
		{
			get
			{
				if(r_CopyFrom_TArray == null)
				{
					r_CopyFrom_TArray = new(this, "CopyFrom", 0, Type.MakeGenericMethodParameter(0).MakeArrayType());
					r_CopyFrom_TArray.SetBelong(this.instance);
				}
				return r_CopyFrom_TArray;
			}
		}

		/// <summary>
		/// Void CopyFrom(Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_CopyFrom_NativeArray_d_T_p_;
		public virtual RMethod RCopyFrom_NativeArray_d_T_p_
		{
			get
			{
				if(r_CopyFrom_NativeArray_d_T_p_ == null)
				{
					r_CopyFrom_NativeArray_d_T_p_ = new(this, "CopyFrom", 0, typeof(Unity.Collections.NativeArray<>));
					r_CopyFrom_NativeArray_d_T_p_.SetBelong(this.instance);
				}
				return r_CopyFrom_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void CopyTo(T[])
		/// </summary>
		protected RMethod r_CopyTo_TArray;
		public virtual RMethod RCopyTo_TArray
		{
			get
			{
				if(r_CopyTo_TArray == null)
				{
					r_CopyTo_TArray = new(this, "CopyTo", 0, Type.MakeGenericMethodParameter(0).MakeArrayType());
					r_CopyTo_TArray.SetBelong(this.instance);
				}
				return r_CopyTo_TArray;
			}
		}

		/// <summary>
		/// Void CopyTo(Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_CopyTo_NativeArray_d_T_p_;
		public virtual RMethod RCopyTo_NativeArray_d_T_p_
		{
			get
			{
				if(r_CopyTo_NativeArray_d_T_p_ == null)
				{
					r_CopyTo_NativeArray_d_T_p_ = new(this, "CopyTo", 0, typeof(Unity.Collections.NativeArray<>));
					r_CopyTo_NativeArray_d_T_p_.SetBelong(this.instance);
				}
				return r_CopyTo_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// T[] ToArray()
		/// </summary>
		protected RMethod r_ToArray;
		public virtual RMethod RToArray
		{
			get
			{
				if(r_ToArray == null)
				{
					r_ToArray = new(this, "ToArray", 0);
					r_ToArray.SetBelong(this.instance);
				}
				return r_ToArray;
			}
		}

		/// <summary>
		/// Void FailOutOfRangeError(Int32)
		/// </summary>
		protected RMethod r_FailOutOfRangeError_Int32;
		public virtual RMethod RFailOutOfRangeError_Int32
		{
			get
			{
				if(r_FailOutOfRangeError_Int32 == null)
				{
					r_FailOutOfRangeError_Int32 = new(this, "FailOutOfRangeError", 0, typeof(System.Int32));
					r_FailOutOfRangeError_Int32.SetBelong(this.instance);
				}
				return r_FailOutOfRangeError_Int32;
			}
		}

		/// <summary>
		/// Enumerator GetEnumerator()
		/// </summary>
		protected RMethod r_GetEnumerator;
		public virtual RMethod RGetEnumerator
		{
			get
			{
				if(r_GetEnumerator == null)
				{
					r_GetEnumerator = new(this, "GetEnumerator", 0);
					r_GetEnumerator.SetBelong(this.instance);
				}
				return r_GetEnumerator;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerator`1[T] System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		/// </summary>
		protected RMethod r_System__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator;
		public virtual RMethod RSystem__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator
		{
			get
			{
				if(r_System__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator == null)
				{
					r_System__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator = new(this, "System.Collections.Generic.IEnumerable<T>.GetEnumerator", 0);
					r_System__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		/// </summary>
		protected RMethod r_System__2__Collections__2__IEnumerable__2__GetEnumerator;
		public virtual RMethod RSystem__2__Collections__2__IEnumerable__2__GetEnumerator
		{
			get
			{
				if(r_System__2__Collections__2__IEnumerable__2__GetEnumerator == null)
				{
					r_System__2__Collections__2__IEnumerable__2__GetEnumerator = new(this, "System.Collections.IEnumerable.GetEnumerator", 0);
					r_System__2__Collections__2__IEnumerable__2__GetEnumerator.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__IEnumerable__2__GetEnumerator;
			}
		}

		/// <summary>
		/// Boolean Equals(Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_Equals_NativeArray_d_T_p_;
		public virtual RMethod REquals_NativeArray_d_T_p_
		{
			get
			{
				if(r_Equals_NativeArray_d_T_p_ == null)
				{
					r_Equals_NativeArray_d_T_p_ = new(this, "Equals", 0, typeof(Unity.Collections.NativeArray<>));
					r_Equals_NativeArray_d_T_p_.SetBelong(this.instance);
				}
				return r_Equals_NativeArray_d_T_p_;
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
		/// Boolean op_Equality(Unity.Collections.NativeArray`1[T], Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected static RMethod r_op_Equality_NativeArray_d_T_p__NativeArray_d_T_p_;
		public static RMethod Rop_Equality_NativeArray_d_T_p__NativeArray_d_T_p_
		{
			get
			{
				if(r_op_Equality_NativeArray_d_T_p__NativeArray_d_T_p_ == null)
				{
					r_op_Equality_NativeArray_d_T_p__NativeArray_d_T_p_ = new(typeof(Unity.Collections.NativeArray<>), "op_Equality", 0, typeof(Unity.Collections.NativeArray<>), typeof(Unity.Collections.NativeArray<>));
					r_op_Equality_NativeArray_d_T_p__NativeArray_d_T_p_.SetBelong(null);
				}
				return r_op_Equality_NativeArray_d_T_p__NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(Unity.Collections.NativeArray`1[T], Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected static RMethod r_op_Inequality_NativeArray_d_T_p__NativeArray_d_T_p_;
		public static RMethod Rop_Inequality_NativeArray_d_T_p__NativeArray_d_T_p_
		{
			get
			{
				if(r_op_Inequality_NativeArray_d_T_p__NativeArray_d_T_p_ == null)
				{
					r_op_Inequality_NativeArray_d_T_p__NativeArray_d_T_p_ = new(typeof(Unity.Collections.NativeArray<>), "op_Inequality", 0, typeof(Unity.Collections.NativeArray<>), typeof(Unity.Collections.NativeArray<>));
					r_op_Inequality_NativeArray_d_T_p__NativeArray_d_T_p_.SetBelong(null);
				}
				return r_op_Inequality_NativeArray_d_T_p__NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void Copy(Unity.Collections.NativeArray`1[T], Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected static RMethod r_Copy_NativeArray_d_T_p__NativeArray_d_T_p_;
		public static RMethod RCopy_NativeArray_d_T_p__NativeArray_d_T_p_
		{
			get
			{
				if(r_Copy_NativeArray_d_T_p__NativeArray_d_T_p_ == null)
				{
					r_Copy_NativeArray_d_T_p__NativeArray_d_T_p_ = new(typeof(Unity.Collections.NativeArray<>), "Copy", 0, typeof(Unity.Collections.NativeArray<>), typeof(Unity.Collections.NativeArray<>));
					r_Copy_NativeArray_d_T_p__NativeArray_d_T_p_.SetBelong(null);
				}
				return r_Copy_NativeArray_d_T_p__NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void Copy(ReadOnly, Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected static RMethod r_Copy_ReadOnly_NativeArray_d_T_p_;
		public static RMethod RCopy_ReadOnly_NativeArray_d_T_p_
		{
			get
			{
				if(r_Copy_ReadOnly_NativeArray_d_T_p_ == null)
				{
					r_Copy_ReadOnly_NativeArray_d_T_p_ = new(typeof(Unity.Collections.NativeArray<>), "Copy", 0,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1+ReadOnly").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(Unity.Collections.NativeArray<>));
					r_Copy_ReadOnly_NativeArray_d_T_p_.SetBelong(null);
				}
				return r_Copy_ReadOnly_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void Copy(T[], Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected static RMethod r_Copy_TArray_NativeArray_d_T_p_;
		public static RMethod RCopy_TArray_NativeArray_d_T_p_
		{
			get
			{
				if(r_Copy_TArray_NativeArray_d_T_p_ == null)
				{
					r_Copy_TArray_NativeArray_d_T_p_ = new(typeof(Unity.Collections.NativeArray<>), "Copy", 0, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(Unity.Collections.NativeArray<>));
					r_Copy_TArray_NativeArray_d_T_p_.SetBelong(null);
				}
				return r_Copy_TArray_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void Copy(Unity.Collections.NativeArray`1[T], T[])
		/// </summary>
		protected static RMethod r_Copy_NativeArray_d_T_p__TArray;
		public static RMethod RCopy_NativeArray_d_T_p__TArray
		{
			get
			{
				if(r_Copy_NativeArray_d_T_p__TArray == null)
				{
					r_Copy_NativeArray_d_T_p__TArray = new(typeof(Unity.Collections.NativeArray<>), "Copy", 0, typeof(Unity.Collections.NativeArray<>), Type.MakeGenericMethodParameter(0).MakeArrayType());
					r_Copy_NativeArray_d_T_p__TArray.SetBelong(null);
				}
				return r_Copy_NativeArray_d_T_p__TArray;
			}
		}

		/// <summary>
		/// Void Copy(ReadOnly, T[])
		/// </summary>
		protected static RMethod r_Copy_ReadOnly_TArray;
		public static RMethod RCopy_ReadOnly_TArray
		{
			get
			{
				if(r_Copy_ReadOnly_TArray == null)
				{
					r_Copy_ReadOnly_TArray = new(typeof(Unity.Collections.NativeArray<>), "Copy", 0,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1+ReadOnly").MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0).MakeArrayType());
					r_Copy_ReadOnly_TArray.SetBelong(null);
				}
				return r_Copy_ReadOnly_TArray;
			}
		}

		/// <summary>
		/// Void Copy(Unity.Collections.NativeArray`1[T], Unity.Collections.NativeArray`1[T], Int32)
		/// </summary>
		protected static RMethod r_Copy_NativeArray_d_T_p__NativeArray_d_T_p__Int32;
		public static RMethod RCopy_NativeArray_d_T_p__NativeArray_d_T_p__Int32
		{
			get
			{
				if(r_Copy_NativeArray_d_T_p__NativeArray_d_T_p__Int32 == null)
				{
					r_Copy_NativeArray_d_T_p__NativeArray_d_T_p__Int32 = new(typeof(Unity.Collections.NativeArray<>), "Copy", 0, typeof(Unity.Collections.NativeArray<>), typeof(Unity.Collections.NativeArray<>), typeof(System.Int32));
					r_Copy_NativeArray_d_T_p__NativeArray_d_T_p__Int32.SetBelong(null);
				}
				return r_Copy_NativeArray_d_T_p__NativeArray_d_T_p__Int32;
			}
		}

		/// <summary>
		/// Void Copy(ReadOnly, Unity.Collections.NativeArray`1[T], Int32)
		/// </summary>
		protected static RMethod r_Copy_ReadOnly_NativeArray_d_T_p__Int32;
		public static RMethod RCopy_ReadOnly_NativeArray_d_T_p__Int32
		{
			get
			{
				if(r_Copy_ReadOnly_NativeArray_d_T_p__Int32 == null)
				{
					r_Copy_ReadOnly_NativeArray_d_T_p__Int32 = new(typeof(Unity.Collections.NativeArray<>), "Copy", 0,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1+ReadOnly").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(Unity.Collections.NativeArray<>), typeof(System.Int32));
					r_Copy_ReadOnly_NativeArray_d_T_p__Int32.SetBelong(null);
				}
				return r_Copy_ReadOnly_NativeArray_d_T_p__Int32;
			}
		}

		/// <summary>
		/// Void Copy(T[], Unity.Collections.NativeArray`1[T], Int32)
		/// </summary>
		protected static RMethod r_Copy_TArray_NativeArray_d_T_p__Int32;
		public static RMethod RCopy_TArray_NativeArray_d_T_p__Int32
		{
			get
			{
				if(r_Copy_TArray_NativeArray_d_T_p__Int32 == null)
				{
					r_Copy_TArray_NativeArray_d_T_p__Int32 = new(typeof(Unity.Collections.NativeArray<>), "Copy", 0, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(Unity.Collections.NativeArray<>), typeof(System.Int32));
					r_Copy_TArray_NativeArray_d_T_p__Int32.SetBelong(null);
				}
				return r_Copy_TArray_NativeArray_d_T_p__Int32;
			}
		}

		/// <summary>
		/// Void Copy(Unity.Collections.NativeArray`1[T], T[], Int32)
		/// </summary>
		protected static RMethod r_Copy_NativeArray_d_T_p__TArray_Int32;
		public static RMethod RCopy_NativeArray_d_T_p__TArray_Int32
		{
			get
			{
				if(r_Copy_NativeArray_d_T_p__TArray_Int32 == null)
				{
					r_Copy_NativeArray_d_T_p__TArray_Int32 = new(typeof(Unity.Collections.NativeArray<>), "Copy", 0, typeof(Unity.Collections.NativeArray<>), Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32));
					r_Copy_NativeArray_d_T_p__TArray_Int32.SetBelong(null);
				}
				return r_Copy_NativeArray_d_T_p__TArray_Int32;
			}
		}

		/// <summary>
		/// Void Copy(ReadOnly, T[], Int32)
		/// </summary>
		protected static RMethod r_Copy_ReadOnly_TArray_Int32;
		public static RMethod RCopy_ReadOnly_TArray_Int32
		{
			get
			{
				if(r_Copy_ReadOnly_TArray_Int32 == null)
				{
					r_Copy_ReadOnly_TArray_Int32 = new(typeof(Unity.Collections.NativeArray<>), "Copy", 0,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1+ReadOnly").MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32));
					r_Copy_ReadOnly_TArray_Int32.SetBelong(null);
				}
				return r_Copy_ReadOnly_TArray_Int32;
			}
		}

		/// <summary>
		/// Void Copy(Unity.Collections.NativeArray`1[T], Int32, Unity.Collections.NativeArray`1[T], Int32, Int32)
		/// </summary>
		protected static RMethod r_Copy_NativeArray_d_T_p__Int32_NativeArray_d_T_p__Int32_Int32;
		public static RMethod RCopy_NativeArray_d_T_p__Int32_NativeArray_d_T_p__Int32_Int32
		{
			get
			{
				if(r_Copy_NativeArray_d_T_p__Int32_NativeArray_d_T_p__Int32_Int32 == null)
				{
					r_Copy_NativeArray_d_T_p__Int32_NativeArray_d_T_p__Int32_Int32 = new(typeof(Unity.Collections.NativeArray<>), "Copy", 0, typeof(Unity.Collections.NativeArray<>), typeof(System.Int32), typeof(Unity.Collections.NativeArray<>), typeof(System.Int32), typeof(System.Int32));
					r_Copy_NativeArray_d_T_p__Int32_NativeArray_d_T_p__Int32_Int32.SetBelong(null);
				}
				return r_Copy_NativeArray_d_T_p__Int32_NativeArray_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void Copy(ReadOnly, Int32, Unity.Collections.NativeArray`1[T], Int32, Int32)
		/// </summary>
		protected static RMethod r_Copy_ReadOnly_Int32_NativeArray_d_T_p__Int32_Int32;
		public static RMethod RCopy_ReadOnly_Int32_NativeArray_d_T_p__Int32_Int32
		{
			get
			{
				if(r_Copy_ReadOnly_Int32_NativeArray_d_T_p__Int32_Int32 == null)
				{
					r_Copy_ReadOnly_Int32_NativeArray_d_T_p__Int32_Int32 = new(typeof(Unity.Collections.NativeArray<>), "Copy", 0,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1+ReadOnly").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(Unity.Collections.NativeArray<>), typeof(System.Int32), typeof(System.Int32));
					r_Copy_ReadOnly_Int32_NativeArray_d_T_p__Int32_Int32.SetBelong(null);
				}
				return r_Copy_ReadOnly_Int32_NativeArray_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void Copy(T[], Int32, Unity.Collections.NativeArray`1[T], Int32, Int32)
		/// </summary>
		protected static RMethod r_Copy_TArray_Int32_NativeArray_d_T_p__Int32_Int32;
		public static RMethod RCopy_TArray_Int32_NativeArray_d_T_p__Int32_Int32
		{
			get
			{
				if(r_Copy_TArray_Int32_NativeArray_d_T_p__Int32_Int32 == null)
				{
					r_Copy_TArray_Int32_NativeArray_d_T_p__Int32_Int32 = new(typeof(Unity.Collections.NativeArray<>), "Copy", 0, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(Unity.Collections.NativeArray<>), typeof(System.Int32), typeof(System.Int32));
					r_Copy_TArray_Int32_NativeArray_d_T_p__Int32_Int32.SetBelong(null);
				}
				return r_Copy_TArray_Int32_NativeArray_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void Copy(Unity.Collections.NativeArray`1[T], Int32, T[], Int32, Int32)
		/// </summary>
		protected static RMethod r_Copy_NativeArray_d_T_p__Int32_TArray_Int32_Int32;
		public static RMethod RCopy_NativeArray_d_T_p__Int32_TArray_Int32_Int32
		{
			get
			{
				if(r_Copy_NativeArray_d_T_p__Int32_TArray_Int32_Int32 == null)
				{
					r_Copy_NativeArray_d_T_p__Int32_TArray_Int32_Int32 = new(typeof(Unity.Collections.NativeArray<>), "Copy", 0, typeof(Unity.Collections.NativeArray<>), typeof(System.Int32), Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_Copy_NativeArray_d_T_p__Int32_TArray_Int32_Int32.SetBelong(null);
				}
				return r_Copy_NativeArray_d_T_p__Int32_TArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Copy(ReadOnly, Int32, T[], Int32, Int32)
		/// </summary>
		protected static RMethod r_Copy_ReadOnly_Int32_TArray_Int32_Int32;
		public static RMethod RCopy_ReadOnly_Int32_TArray_Int32_Int32
		{
			get
			{
				if(r_Copy_ReadOnly_Int32_TArray_Int32_Int32 == null)
				{
					r_Copy_ReadOnly_Int32_TArray_Int32_Int32 = new(typeof(Unity.Collections.NativeArray<>), "Copy", 0,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1+ReadOnly").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_Copy_ReadOnly_Int32_TArray_Int32_Int32.SetBelong(null);
				}
				return r_Copy_ReadOnly_Int32_TArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void CopySafe(Unity.Collections.NativeArray`1[T], Int32, Unity.Collections.NativeArray`1[T], Int32, Int32)
		/// </summary>
		protected static RMethod r_CopySafe_NativeArray_d_T_p__Int32_NativeArray_d_T_p__Int32_Int32;
		public static RMethod RCopySafe_NativeArray_d_T_p__Int32_NativeArray_d_T_p__Int32_Int32
		{
			get
			{
				if(r_CopySafe_NativeArray_d_T_p__Int32_NativeArray_d_T_p__Int32_Int32 == null)
				{
					r_CopySafe_NativeArray_d_T_p__Int32_NativeArray_d_T_p__Int32_Int32 = new(typeof(Unity.Collections.NativeArray<>), "CopySafe", 0, typeof(Unity.Collections.NativeArray<>), typeof(System.Int32), typeof(Unity.Collections.NativeArray<>), typeof(System.Int32), typeof(System.Int32));
					r_CopySafe_NativeArray_d_T_p__Int32_NativeArray_d_T_p__Int32_Int32.SetBelong(null);
				}
				return r_CopySafe_NativeArray_d_T_p__Int32_NativeArray_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void CopySafe(ReadOnly, Int32, Unity.Collections.NativeArray`1[T], Int32, Int32)
		/// </summary>
		protected static RMethod r_CopySafe_ReadOnly_Int32_NativeArray_d_T_p__Int32_Int32;
		public static RMethod RCopySafe_ReadOnly_Int32_NativeArray_d_T_p__Int32_Int32
		{
			get
			{
				if(r_CopySafe_ReadOnly_Int32_NativeArray_d_T_p__Int32_Int32 == null)
				{
					r_CopySafe_ReadOnly_Int32_NativeArray_d_T_p__Int32_Int32 = new(typeof(Unity.Collections.NativeArray<>), "CopySafe", 0,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1+ReadOnly").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(Unity.Collections.NativeArray<>), typeof(System.Int32), typeof(System.Int32));
					r_CopySafe_ReadOnly_Int32_NativeArray_d_T_p__Int32_Int32.SetBelong(null);
				}
				return r_CopySafe_ReadOnly_Int32_NativeArray_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void CopySafe(T[], Int32, Unity.Collections.NativeArray`1[T], Int32, Int32)
		/// </summary>
		protected static RMethod r_CopySafe_TArray_Int32_NativeArray_d_T_p__Int32_Int32;
		public static RMethod RCopySafe_TArray_Int32_NativeArray_d_T_p__Int32_Int32
		{
			get
			{
				if(r_CopySafe_TArray_Int32_NativeArray_d_T_p__Int32_Int32 == null)
				{
					r_CopySafe_TArray_Int32_NativeArray_d_T_p__Int32_Int32 = new(typeof(Unity.Collections.NativeArray<>), "CopySafe", 0, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(Unity.Collections.NativeArray<>), typeof(System.Int32), typeof(System.Int32));
					r_CopySafe_TArray_Int32_NativeArray_d_T_p__Int32_Int32.SetBelong(null);
				}
				return r_CopySafe_TArray_Int32_NativeArray_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void CopySafe(Unity.Collections.NativeArray`1[T], Int32, T[], Int32, Int32)
		/// </summary>
		protected static RMethod r_CopySafe_NativeArray_d_T_p__Int32_TArray_Int32_Int32;
		public static RMethod RCopySafe_NativeArray_d_T_p__Int32_TArray_Int32_Int32
		{
			get
			{
				if(r_CopySafe_NativeArray_d_T_p__Int32_TArray_Int32_Int32 == null)
				{
					r_CopySafe_NativeArray_d_T_p__Int32_TArray_Int32_Int32 = new(typeof(Unity.Collections.NativeArray<>), "CopySafe", 0, typeof(Unity.Collections.NativeArray<>), typeof(System.Int32), Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_CopySafe_NativeArray_d_T_p__Int32_TArray_Int32_Int32.SetBelong(null);
				}
				return r_CopySafe_NativeArray_d_T_p__Int32_TArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void CopySafe(ReadOnly, Int32, T[], Int32, Int32)
		/// </summary>
		protected static RMethod r_CopySafe_ReadOnly_Int32_TArray_Int32_Int32;
		public static RMethod RCopySafe_ReadOnly_Int32_TArray_Int32_Int32
		{
			get
			{
				if(r_CopySafe_ReadOnly_Int32_TArray_Int32_Int32 == null)
				{
					r_CopySafe_ReadOnly_Int32_TArray_Int32_Int32 = new(typeof(Unity.Collections.NativeArray<>), "CopySafe", 0,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1+ReadOnly").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_CopySafe_ReadOnly_Int32_TArray_Int32_Int32.SetBelong(null);
				}
				return r_CopySafe_ReadOnly_Int32_TArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void CheckCopyPtr(T[])
		/// </summary>
		protected static RMethod r_CheckCopyPtr_TArray;
		public static RMethod RCheckCopyPtr_TArray
		{
			get
			{
				if(r_CheckCopyPtr_TArray == null)
				{
					r_CheckCopyPtr_TArray = new(typeof(Unity.Collections.NativeArray<>), "CheckCopyPtr", 0, Type.MakeGenericMethodParameter(0).MakeArrayType());
					r_CheckCopyPtr_TArray.SetBelong(null);
				}
				return r_CheckCopyPtr_TArray;
			}
		}

		/// <summary>
		/// Void CheckCopyLengths(Int32, Int32)
		/// </summary>
		protected static RMethod r_CheckCopyLengths_Int32_Int32;
		public static RMethod RCheckCopyLengths_Int32_Int32
		{
			get
			{
				if(r_CheckCopyLengths_Int32_Int32 == null)
				{
					r_CheckCopyLengths_Int32_Int32 = new(typeof(Unity.Collections.NativeArray<>), "CheckCopyLengths", 0, typeof(System.Int32), typeof(System.Int32));
					r_CheckCopyLengths_Int32_Int32.SetBelong(null);
				}
				return r_CheckCopyLengths_Int32_Int32;
			}
		}

		/// <summary>
		/// Void CheckCopyArguments(Int32, Int32, Int32, Int32, Int32)
		/// </summary>
		protected static RMethod r_CheckCopyArguments_Int32_Int32_Int32_Int32_Int32;
		public static RMethod RCheckCopyArguments_Int32_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_CheckCopyArguments_Int32_Int32_Int32_Int32_Int32 == null)
				{
					r_CheckCopyArguments_Int32_Int32_Int32_Int32_Int32 = new(typeof(Unity.Collections.NativeArray<>), "CheckCopyArguments", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_CheckCopyArguments_Int32_Int32_Int32_Int32_Int32.SetBelong(null);
				}
				return r_CheckCopyArguments_Int32_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void CheckReinterpretLoadRange[U](Int32)
		/// </summary>
		protected RMethod r_CheckReinterpretLoadRange_GU_Int32;
		public virtual RMethod RCheckReinterpretLoadRange_GU_Int32
		{
			get
			{
				if(r_CheckReinterpretLoadRange_GU_Int32 == null)
				{
					r_CheckReinterpretLoadRange_GU_Int32 = new(this, "CheckReinterpretLoadRange", 1, typeof(System.Int32));
					r_CheckReinterpretLoadRange_GU_Int32.SetBelong(this.instance);
				}
				return r_CheckReinterpretLoadRange_GU_Int32;
			}
		}

		/// <summary>
		/// Void CheckReinterpretStoreRange[U](Int32)
		/// </summary>
		protected RMethod r_CheckReinterpretStoreRange_GU_Int32;
		public virtual RMethod RCheckReinterpretStoreRange_GU_Int32
		{
			get
			{
				if(r_CheckReinterpretStoreRange_GU_Int32 == null)
				{
					r_CheckReinterpretStoreRange_GU_Int32 = new(this, "CheckReinterpretStoreRange", 1, typeof(System.Int32));
					r_CheckReinterpretStoreRange_GU_Int32.SetBelong(this.instance);
				}
				return r_CheckReinterpretStoreRange_GU_Int32;
			}
		}

		/// <summary>
		/// U ReinterpretLoad[U](Int32)
		/// </summary>
		protected RMethod r_ReinterpretLoad_GU_Int32;
		public virtual RMethod RReinterpretLoad_GU_Int32
		{
			get
			{
				if(r_ReinterpretLoad_GU_Int32 == null)
				{
					r_ReinterpretLoad_GU_Int32 = new(this, "ReinterpretLoad", 1, typeof(System.Int32));
					r_ReinterpretLoad_GU_Int32.SetBelong(this.instance);
				}
				return r_ReinterpretLoad_GU_Int32;
			}
		}

		/// <summary>
		/// Void ReinterpretStore[U](Int32, U)
		/// </summary>
		protected RMethod r_ReinterpretStore_GU_Int32_U;
		public virtual RMethod RReinterpretStore_GU_Int32_U
		{
			get
			{
				if(r_ReinterpretStore_GU_Int32_U == null)
				{
					r_ReinterpretStore_GU_Int32_U = new(this, "ReinterpretStore", 1, typeof(System.Int32), Type.MakeGenericMethodParameter(0));
					r_ReinterpretStore_GU_Int32_U.SetBelong(this.instance);
				}
				return r_ReinterpretStore_GU_Int32_U;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[U] InternalReinterpret[U](Int32)
		/// </summary>
		protected RMethod r_InternalReinterpret_GU_Int32;
		public virtual RMethod RInternalReinterpret_GU_Int32
		{
			get
			{
				if(r_InternalReinterpret_GU_Int32 == null)
				{
					r_InternalReinterpret_GU_Int32 = new(this, "InternalReinterpret", 1, typeof(System.Int32));
					r_InternalReinterpret_GU_Int32.SetBelong(this.instance);
				}
				return r_InternalReinterpret_GU_Int32;
			}
		}

		/// <summary>
		/// Void CheckReinterpretSize[U]()
		/// </summary>
		protected static RMethod r_CheckReinterpretSize_GU;
		public static RMethod RCheckReinterpretSize_GU
		{
			get
			{
				if(r_CheckReinterpretSize_GU == null)
				{
					r_CheckReinterpretSize_GU = new(typeof(Unity.Collections.NativeArray<>), "CheckReinterpretSize", 1);
					r_CheckReinterpretSize_GU.SetBelong(null);
				}
				return r_CheckReinterpretSize_GU;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[U] Reinterpret[U]()
		/// </summary>
		protected RMethod r_Reinterpret_GU;
		public virtual RMethod RReinterpret_GU
		{
			get
			{
				if(r_Reinterpret_GU == null)
				{
					r_Reinterpret_GU = new(this, "Reinterpret", 1);
					r_Reinterpret_GU.SetBelong(this.instance);
				}
				return r_Reinterpret_GU;
			}
		}

		/// <summary>
		/// Void CheckReinterpretSize[U](Int64, Int64, Int32, Int64, Int64)
		/// </summary>
		protected RMethod r_CheckReinterpretSize_GU_Int64_Int64_Int32_Int64_Int64;
		public virtual RMethod RCheckReinterpretSize_GU_Int64_Int64_Int32_Int64_Int64
		{
			get
			{
				if(r_CheckReinterpretSize_GU_Int64_Int64_Int32_Int64_Int64 == null)
				{
					r_CheckReinterpretSize_GU_Int64_Int64_Int32_Int64_Int64 = new(this, "CheckReinterpretSize", 1, typeof(System.Int64), typeof(System.Int64), typeof(System.Int32), typeof(System.Int64), typeof(System.Int64));
					r_CheckReinterpretSize_GU_Int64_Int64_Int32_Int64_Int64.SetBelong(this.instance);
				}
				return r_CheckReinterpretSize_GU_Int64_Int64_Int32_Int64_Int64;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[U] Reinterpret[U](Int32)
		/// </summary>
		protected RMethod r_Reinterpret_GU_Int32;
		public virtual RMethod RReinterpret_GU_Int32
		{
			get
			{
				if(r_Reinterpret_GU_Int32 == null)
				{
					r_Reinterpret_GU_Int32 = new(this, "Reinterpret", 1, typeof(System.Int32));
					r_Reinterpret_GU_Int32.SetBelong(this.instance);
				}
				return r_Reinterpret_GU_Int32;
			}
		}

		/// <summary>
		/// Void CheckGetSubArrayArguments(Int32, Int32)
		/// </summary>
		protected RMethod r_CheckGetSubArrayArguments_Int32_Int32;
		public virtual RMethod RCheckGetSubArrayArguments_Int32_Int32
		{
			get
			{
				if(r_CheckGetSubArrayArguments_Int32_Int32 == null)
				{
					r_CheckGetSubArrayArguments_Int32_Int32 = new(this, "CheckGetSubArrayArguments", 0, typeof(System.Int32), typeof(System.Int32));
					r_CheckGetSubArrayArguments_Int32_Int32.SetBelong(this.instance);
				}
				return r_CheckGetSubArrayArguments_Int32_Int32;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[T] GetSubArray(Int32, Int32)
		/// </summary>
		protected RMethod r_GetSubArray_Int32_Int32;
		public virtual RMethod RGetSubArray_Int32_Int32
		{
			get
			{
				if(r_GetSubArray_Int32_Int32 == null)
				{
					r_GetSubArray_Int32_Int32 = new(this, "GetSubArray", 0, typeof(System.Int32), typeof(System.Int32));
					r_GetSubArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_GetSubArray_Int32_Int32;
			}
		}

		/// <summary>
		/// ReadOnly AsReadOnly()
		/// </summary>
		protected RMethod r_AsReadOnly;
		public virtual RMethod RAsReadOnly
		{
			get
			{
				if(r_AsReadOnly == null)
				{
					r_AsReadOnly = new(this, "AsReadOnly", 0);
					r_AsReadOnly.SetBelong(this.instance);
				}
				return r_AsReadOnly;
			}
		}

		/// <summary>
		/// System.Span`1[T] AsSpan()
		/// </summary>
		protected RMethod r_AsSpan;
		public virtual RMethod RAsSpan
		{
			get
			{
				if(r_AsSpan == null)
				{
					r_AsSpan = new(this, "AsSpan", 0);
					r_AsSpan.SetBelong(this.instance);
				}
				return r_AsSpan;
			}
		}

		/// <summary>
		/// System.ReadOnlySpan`1[T] AsReadOnlySpan()
		/// </summary>
		protected RMethod r_AsReadOnlySpan;
		public virtual RMethod RAsReadOnlySpan
		{
			get
			{
				if(r_AsReadOnlySpan == null)
				{
					r_AsReadOnlySpan = new(this, "AsReadOnlySpan", 0);
					r_AsReadOnlySpan.SetBelong(this.instance);
				}
				return r_AsReadOnlySpan;
			}
		}

		/// <summary>
		/// System.Span`1[T] op_Implicit(Unity.Collections.NativeArray`1[T] ByRef)
		/// </summary>
		protected static RMethod r_op_Implicit_In_NativeArray_d_T_p_;
		public static RMethod Rop_Implicit_In_NativeArray_d_T_p_
		{
			get
			{
				if(r_op_Implicit_In_NativeArray_d_T_p_ == null)
				{
					r_op_Implicit_In_NativeArray_d_T_p_ = new(typeof(Unity.Collections.NativeArray<>), "op_Implicit", 0, typeof(Unity.Collections.NativeArray<>).MakeByRefType());
					r_op_Implicit_In_NativeArray_d_T_p_.SetBelong(null);
				}
				return r_op_Implicit_In_NativeArray_d_T_p_;
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


        public RNativeArray() : base("Unity.Collections.NativeArray`1")
        {
        }

        public RNativeArray(System.Object instance) : base("Unity.Collections.NativeArray`1")
		{
            SetInstance(instance);
		}

        public RNativeArray(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RNativeArray(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static void InitStaticSafetyId(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RInitStaticSafetyId_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static void CheckAllocateArguments(System.Int32 @length, Unity.Collections.Allocator @allocator)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@length, @allocator};
            var ___result = RCheckAllocateArguments_Int32_Allocator.Invoke(___genericsType, ___parameters);

            
        }


        public static void Allocate(System.Int32 @length, Unity.Collections.Allocator @allocator, out RUnity.RCollections.RNativeArray<RType> @array)
        {
			@array = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@length, @allocator, @array.Value};
            var ___result = RAllocate_Int32_Allocator_Out_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);
			@array = new RUnity.RCollections.RNativeArray<RType>(___parameters[2]);

            
        }


        public static void InitNestedNativeContainer(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RInitNestedNativeContainer_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            
        }


        public static void IsUnmanagedAndThrow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsUnmanagedAndThrow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckElementReadAccess(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RCheckElementReadAccess_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckElementWriteAccess(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RCheckElementWriteAccess_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle @inputDeps)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inputDeps};
            var ___result = RDispose_JobHandle.Invoke(___genericsType, ___parameters);

            return (Unity.Jobs.JobHandle)___result;
        }


        public virtual void CopyFrom(RTypeArray<RType> @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array.Value};
            var ___result = RCopyFrom_TArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyFrom(RUnity.RCollections.RNativeArray<RType> @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array.Value};
            var ___result = RCopyFrom_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(RTypeArray<RType> @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array.Value};
            var ___result = RCopyTo_TArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(RUnity.RCollections.RNativeArray<RType> @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array.Value};
            var ___result = RCopyTo_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RTypeArray<RType> ToArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToArray.Invoke(___genericsType, ___parameters);

            return new RTypeArray<RType>(___result);
        }


        public virtual void FailOutOfRangeError(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RFailOutOfRangeError_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RUnity.RCollections.RNativeArray<RType>.REnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return new RUnity.RCollections.RNativeArray<RType>.REnumerator(___result);
        }


        public virtual RSystem.RCollections.RGeneric.RIEnumerator<RType> System__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return new RSystem.RCollections.RGeneric.RIEnumerator<RType>(___result);
        }


        public virtual System.Collections.IEnumerator System__2__Collections__2__IEnumerable__2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__2__Collections__2__IEnumerable__2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Boolean Equals(RUnity.RCollections.RNativeArray<RType> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = REquals_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
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


        public static System.Boolean op_Equality(RUnity.RCollections.RNativeArray<RType> @left, RUnity.RCollections.RNativeArray<RType> @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = Rop_Equality_NativeArray_d_T_p__NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(RUnity.RCollections.RNativeArray<RType> @left, RUnity.RCollections.RNativeArray<RType> @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = Rop_Inequality_NativeArray_d_T_p__NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void Copy(RUnity.RCollections.RNativeArray<RType> @src, RUnity.RCollections.RNativeArray<RType> @dst)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @dst.Value};
            var ___result = RCopy_NativeArray_d_T_p__NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(RUnity.RCollections.RNativeArray<RType>.RReadOnly @src, RUnity.RCollections.RNativeArray<RType> @dst)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @dst.Value};
            var ___result = RCopy_ReadOnly_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(RTypeArray<RType> @src, RUnity.RCollections.RNativeArray<RType> @dst)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @dst.Value};
            var ___result = RCopy_TArray_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(RUnity.RCollections.RNativeArray<RType> @src, RTypeArray<RType> @dst)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @dst.Value};
            var ___result = RCopy_NativeArray_d_T_p__TArray.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(RUnity.RCollections.RNativeArray<RType>.RReadOnly @src, RTypeArray<RType> @dst)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @dst.Value};
            var ___result = RCopy_ReadOnly_TArray.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(RUnity.RCollections.RNativeArray<RType> @src, RUnity.RCollections.RNativeArray<RType> @dst, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @dst.Value, @length};
            var ___result = RCopy_NativeArray_d_T_p__NativeArray_d_T_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(RUnity.RCollections.RNativeArray<RType>.RReadOnly @src, RUnity.RCollections.RNativeArray<RType> @dst, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @dst.Value, @length};
            var ___result = RCopy_ReadOnly_NativeArray_d_T_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(RTypeArray<RType> @src, RUnity.RCollections.RNativeArray<RType> @dst, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @dst.Value, @length};
            var ___result = RCopy_TArray_NativeArray_d_T_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(RUnity.RCollections.RNativeArray<RType> @src, RTypeArray<RType> @dst, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @dst.Value, @length};
            var ___result = RCopy_NativeArray_d_T_p__TArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(RUnity.RCollections.RNativeArray<RType>.RReadOnly @src, RTypeArray<RType> @dst, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @dst.Value, @length};
            var ___result = RCopy_ReadOnly_TArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(RUnity.RCollections.RNativeArray<RType> @src, System.Int32 @srcIndex, RUnity.RCollections.RNativeArray<RType> @dst, System.Int32 @dstIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @srcIndex, @dst.Value, @dstIndex, @length};
            var ___result = RCopy_NativeArray_d_T_p__Int32_NativeArray_d_T_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(RUnity.RCollections.RNativeArray<RType>.RReadOnly @src, System.Int32 @srcIndex, RUnity.RCollections.RNativeArray<RType> @dst, System.Int32 @dstIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @srcIndex, @dst.Value, @dstIndex, @length};
            var ___result = RCopy_ReadOnly_Int32_NativeArray_d_T_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(RTypeArray<RType> @src, System.Int32 @srcIndex, RUnity.RCollections.RNativeArray<RType> @dst, System.Int32 @dstIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @srcIndex, @dst.Value, @dstIndex, @length};
            var ___result = RCopy_TArray_Int32_NativeArray_d_T_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(RUnity.RCollections.RNativeArray<RType> @src, System.Int32 @srcIndex, RTypeArray<RType> @dst, System.Int32 @dstIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @srcIndex, @dst.Value, @dstIndex, @length};
            var ___result = RCopy_NativeArray_d_T_p__Int32_TArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(RUnity.RCollections.RNativeArray<RType>.RReadOnly @src, System.Int32 @srcIndex, RTypeArray<RType> @dst, System.Int32 @dstIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @srcIndex, @dst.Value, @dstIndex, @length};
            var ___result = RCopy_ReadOnly_Int32_TArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void CopySafe(RUnity.RCollections.RNativeArray<RType> @src, System.Int32 @srcIndex, RUnity.RCollections.RNativeArray<RType> @dst, System.Int32 @dstIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @srcIndex, @dst.Value, @dstIndex, @length};
            var ___result = RCopySafe_NativeArray_d_T_p__Int32_NativeArray_d_T_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void CopySafe(RUnity.RCollections.RNativeArray<RType>.RReadOnly @src, System.Int32 @srcIndex, RUnity.RCollections.RNativeArray<RType> @dst, System.Int32 @dstIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @srcIndex, @dst.Value, @dstIndex, @length};
            var ___result = RCopySafe_ReadOnly_Int32_NativeArray_d_T_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void CopySafe(RTypeArray<RType> @src, System.Int32 @srcIndex, RUnity.RCollections.RNativeArray<RType> @dst, System.Int32 @dstIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @srcIndex, @dst.Value, @dstIndex, @length};
            var ___result = RCopySafe_TArray_Int32_NativeArray_d_T_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void CopySafe(RUnity.RCollections.RNativeArray<RType> @src, System.Int32 @srcIndex, RTypeArray<RType> @dst, System.Int32 @dstIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @srcIndex, @dst.Value, @dstIndex, @length};
            var ___result = RCopySafe_NativeArray_d_T_p__Int32_TArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void CopySafe(RUnity.RCollections.RNativeArray<RType>.RReadOnly @src, System.Int32 @srcIndex, RTypeArray<RType> @dst, System.Int32 @dstIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @srcIndex, @dst.Value, @dstIndex, @length};
            var ___result = RCopySafe_ReadOnly_Int32_TArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void CheckCopyPtr(RTypeArray<RType> @ptr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ptr.Value};
            var ___result = RCheckCopyPtr_TArray.Invoke(___genericsType, ___parameters);

            
        }


        public static void CheckCopyLengths(System.Int32 @srcLength, System.Int32 @dstLength)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@srcLength, @dstLength};
            var ___result = RCheckCopyLengths_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void CheckCopyArguments(System.Int32 @srcLength, System.Int32 @srcIndex, System.Int32 @dstLength, System.Int32 @dstIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@srcLength, @srcIndex, @dstLength, @dstIndex, @length};
            var ___result = RCheckCopyArguments_Int32_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckReinterpretLoadRange<U>(System.Int32 @sourceIndex) where U : struct
        {

            var ___genericsType = new Type[] {typeof(U)};
            var ___parameters = new object[]{@sourceIndex};
            var ___result = RCheckReinterpretLoadRange_GU_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckReinterpretStoreRange<U>(System.Int32 @destIndex) where U : struct
        {

            var ___genericsType = new Type[] {typeof(U)};
            var ___parameters = new object[]{@destIndex};
            var ___result = RCheckReinterpretStoreRange_GU_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RType ReinterpretLoad<U>(System.Int32 @sourceIndex) where U : struct
        {

            var ___genericsType = new Type[] {typeof(U)};
            var ___parameters = new object[]{@sourceIndex};
            var ___result = RReinterpretLoad_GU_Int32.Invoke(___genericsType, ___parameters);

            return new RType(___result);
        }


        public virtual void ReinterpretStore<U>(System.Int32 @destIndex, RType @data) where U : struct
        {

            var ___genericsType = new Type[] {typeof(U)};
            var ___parameters = new object[]{@destIndex, @data.Value};
            var ___result = RReinterpretStore_GU_Int32_U.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RUnity.RCollections.RNativeArray<RType> InternalReinterpret<U>(System.Int32 @length) where U : struct
        {

            var ___genericsType = new Type[] {typeof(U)};
            var ___parameters = new object[]{@length};
            var ___result = RInternalReinterpret_GU_Int32.Invoke(___genericsType, ___parameters);

            return new RUnity.RCollections.RNativeArray<RType>(___result);
        }


        public static void CheckReinterpretSize<U>() where U : struct
        {

            var ___genericsType = new Type[] {typeof(U)};
            var ___parameters = new object[]{};
            var ___result = RCheckReinterpretSize_GU.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RUnity.RCollections.RNativeArray<RType> Reinterpret<U>() where U : struct
        {

            var ___genericsType = new Type[] {typeof(U)};
            var ___parameters = new object[]{};
            var ___result = RReinterpret_GU.Invoke(___genericsType, ___parameters);

            return new RUnity.RCollections.RNativeArray<RType>(___result);
        }


        public virtual void CheckReinterpretSize<U>(System.Int64 @tSize, System.Int64 @uSize, System.Int32 @expectedTypeSize, System.Int64 @byteLen, System.Int64 @uLen)
        {

            var ___genericsType = new Type[] {typeof(U)};
            var ___parameters = new object[]{@tSize, @uSize, @expectedTypeSize, @byteLen, @uLen};
            var ___result = RCheckReinterpretSize_GU_Int64_Int64_Int32_Int64_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RUnity.RCollections.RNativeArray<RType> Reinterpret<U>(System.Int32 @expectedTypeSize) where U : struct
        {

            var ___genericsType = new Type[] {typeof(U)};
            var ___parameters = new object[]{@expectedTypeSize};
            var ___result = RReinterpret_GU_Int32.Invoke(___genericsType, ___parameters);

            return new RUnity.RCollections.RNativeArray<RType>(___result);
        }


        public virtual void CheckGetSubArrayArguments(System.Int32 @start, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @length};
            var ___result = RCheckGetSubArrayArguments_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RUnity.RCollections.RNativeArray<RType> GetSubArray(System.Int32 @start, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @length};
            var ___result = RGetSubArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return new RUnity.RCollections.RNativeArray<RType>(___result);
        }


        public virtual RUnity.RCollections.RNativeArray<RType>.RReadOnly AsReadOnly()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAsReadOnly.Invoke(___genericsType, ___parameters);

            return new RUnity.RCollections.RNativeArray<RType>.RReadOnly(___result);
        }


        public virtual RSystem.RSpan<RType> AsSpan()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAsSpan.Invoke(___genericsType, ___parameters);

            return new RSystem.RSpan<RType>(___result);
        }


        public virtual RSystem.RReadOnlySpan<RType> AsReadOnlySpan()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAsReadOnlySpan.Invoke(___genericsType, ___parameters);

            return new RSystem.RReadOnlySpan<RType>(___result);
        }


        public static RSystem.RSpan<RType> op_Implicit(in RUnity.RCollections.RNativeArray<RType> @source)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source.Value};
            var ___result = Rop_Implicit_In_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            return new RSystem.RSpan<RType>(___result);
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
