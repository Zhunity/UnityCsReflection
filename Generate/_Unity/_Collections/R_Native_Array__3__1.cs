
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnity.RCollections
{
	/// <summary>
	/// Unity.Collections.NativeArray`1
	/// </summary>
    public partial class RNativeArray<T> : RMember // where T : struct
    {
        public static Type Type
        {
            get
            {
                return typeof(Unity.Collections.NativeArray<>).MakeGenericType(ReflectionUtils.GetType(typeof(T)));
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


		/// <summary>
		/// System.Void* m_Buffer
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldPointer<Hvak.Editor.Refleaction.RField> r_Fm_Buffer;
		public virtual Hvak.Editor.Refleaction.RFieldPointer<Hvak.Editor.Refleaction.RField> RFm_Buffer
		{
			get
			{
				if(r_Fm_Buffer == null)
				{
					r_Fm_Buffer = new(this, "m_Buffer");
				}
				return r_Fm_Buffer;
			}
		}

		/// <summary>
		/// System.Int32 m_Length
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_Length;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_Length
		{
			get
			{
				if(r_Fm_Length == null)
				{
					r_Fm_Length = new(this, "m_Length");
				}
				return r_Fm_Length;
			}
		}

		/// <summary>
		/// System.Int32 m_MinIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_MinIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_MinIndex
		{
			get
			{
				if(r_Fm_MinIndex == null)
				{
					r_Fm_MinIndex = new(this, "m_MinIndex");
				}
				return r_Fm_MinIndex;
			}
		}

		/// <summary>
		/// System.Int32 m_MaxIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_MaxIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_MaxIndex
		{
			get
			{
				if(r_Fm_MaxIndex == null)
				{
					r_Fm_MaxIndex = new(this, "m_MaxIndex");
				}
				return r_Fm_MaxIndex;
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
		/// System.Int32 s_staticSafetyId
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fs_staticSafetyId;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFs_staticSafetyId
		{
			get
			{
				if(r_Fs_staticSafetyId == null)
				{
					r_Fs_staticSafetyId = new(typeof(Unity.Collections.NativeArray<>), "s_staticSafetyId");
				}
				return r_Fs_staticSafetyId;
			}
		}

		/// <summary>
		/// Unity.Collections.Allocator m_AllocatorLabel
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnity.RCollections.RAllocator r_Fm_AllocatorLabel;
		public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RAllocator RFm_AllocatorLabel
		{
			get
			{
				if(r_Fm_AllocatorLabel == null)
				{
					r_Fm_AllocatorLabel = new(this, "m_AllocatorLabel");
				}
				return r_Fm_AllocatorLabel;
			}
		}

		/// <summary>
		/// Dummy& m_DisposeSentinel
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnity.RCollections.RLowLevel.RUnsafe.RDisposeSentinel.RDummy r_Pm_DisposeSentinel;
		public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RLowLevel.RUnsafe.RDisposeSentinel.RDummy RPm_DisposeSentinel
		{
			get
			{
				if(r_Pm_DisposeSentinel == null)
				{
					r_Pm_DisposeSentinel = new(this, "m_DisposeSentinel", -1);
				}
				return r_Pm_DisposeSentinel;
			}
		}

		/// <summary>
		/// Int32 Length
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PLength;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPLength
		{
			get
			{
				if(r_PLength == null)
				{
					r_PLength = new(this, "Length", -1);
				}
				return r_PLength;
			}
		}

		/// <summary>
		/// T Item [Int32]
		/// </summary>
		protected Hvak.Editor.Refleaction.RProperty r_PItem_Int32;
		public virtual Hvak.Editor.Refleaction.RProperty RPItem_Int32
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
		/// Boolean IsCreated
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsCreated;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsCreated
		{
			get
			{
				if(r_PIsCreated == null)
				{
					r_PIsCreated = new(this, "IsCreated", -1);
				}
				return r_PIsCreated;
			}
		}

		/// <summary>
		/// Void InitStaticSafetyId(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_MInitStaticSafetyId_Ref_AtomicSafetyHandle;
		public static RMethod RMInitStaticSafetyId_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_MInitStaticSafetyId_Ref_AtomicSafetyHandle == null)
				{
					r_MInitStaticSafetyId_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.NativeArray<>), "InitStaticSafetyId", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
				}
				return r_MInitStaticSafetyId_Ref_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void CheckAllocateArguments(Int32, Unity.Collections.Allocator)
		/// </summary>
		protected static RMethod r_MCheckAllocateArguments_Int32_Allocator;
		public static RMethod RMCheckAllocateArguments_Int32_Allocator
		{
			get
			{
				if(r_MCheckAllocateArguments_Int32_Allocator == null)
				{
					r_MCheckAllocateArguments_Int32_Allocator = new(typeof(Unity.Collections.NativeArray<>), "CheckAllocateArguments", 0, typeof(System.Int32), typeof(Unity.Collections.Allocator));
				}
				return r_MCheckAllocateArguments_Int32_Allocator;
			}
		}

		/// <summary>
		/// Void Allocate(Int32, Unity.Collections.Allocator, Unity.Collections.NativeArray`1[T] ByRef)
		/// </summary>
		protected static RMethod r_MAllocate_Int32_Allocator_Out_NativeArray_d_T_p_;
		public static RMethod RMAllocate_Int32_Allocator_Out_NativeArray_d_T_p_
		{
			get
			{
				if(r_MAllocate_Int32_Allocator_Out_NativeArray_d_T_p_ == null)
				{
					r_MAllocate_Int32_Allocator_Out_NativeArray_d_T_p_ = new(typeof(Unity.Collections.NativeArray<>), "Allocate", 0, typeof(System.Int32), typeof(Unity.Collections.Allocator), typeof(Unity.Collections.NativeArray<>).MakeByRefType());
				}
				return r_MAllocate_Int32_Allocator_Out_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void InitNestedNativeContainer(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_MInitNestedNativeContainer_AtomicSafetyHandle;
		public static RMethod RMInitNestedNativeContainer_AtomicSafetyHandle
		{
			get
			{
				if(r_MInitNestedNativeContainer_AtomicSafetyHandle == null)
				{
					r_MInitNestedNativeContainer_AtomicSafetyHandle = new(typeof(Unity.Collections.NativeArray<>), "InitNestedNativeContainer", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
				}
				return r_MInitNestedNativeContainer_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void IsUnmanagedAndThrow()
		/// </summary>
		protected static RMethod r_MIsUnmanagedAndThrow;
		public static RMethod RMIsUnmanagedAndThrow
		{
			get
			{
				if(r_MIsUnmanagedAndThrow == null)
				{
					r_MIsUnmanagedAndThrow = new(typeof(Unity.Collections.NativeArray<>), "IsUnmanagedAndThrow", 0);
				}
				return r_MIsUnmanagedAndThrow;
			}
		}

		/// <summary>
		/// Void CheckElementReadAccess(Int32)
		/// </summary>
		protected RMethod r_MCheckElementReadAccess_Int32;
		public virtual RMethod RMCheckElementReadAccess_Int32
		{
			get
			{
				if(r_MCheckElementReadAccess_Int32 == null)
				{
					r_MCheckElementReadAccess_Int32 = new(this, "CheckElementReadAccess", 0, typeof(System.Int32));
				}
				return r_MCheckElementReadAccess_Int32;
			}
		}

		/// <summary>
		/// Void CheckElementWriteAccess(Int32)
		/// </summary>
		protected RMethod r_MCheckElementWriteAccess_Int32;
		public virtual RMethod RMCheckElementWriteAccess_Int32
		{
			get
			{
				if(r_MCheckElementWriteAccess_Int32 == null)
				{
					r_MCheckElementWriteAccess_Int32 = new(this, "CheckElementWriteAccess", 0, typeof(System.Int32));
				}
				return r_MCheckElementWriteAccess_Int32;
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
		/// Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle)
		/// </summary>
		protected RMethod r_MDispose_JobHandle;
		public virtual RMethod RMDispose_JobHandle
		{
			get
			{
				if(r_MDispose_JobHandle == null)
				{
					r_MDispose_JobHandle = new(this, "Dispose", 0, typeof(Unity.Jobs.JobHandle));
				}
				return r_MDispose_JobHandle;
			}
		}

		/// <summary>
		/// Void CopyFrom(T[])
		/// </summary>
		protected RMethod r_MCopyFrom_TArray;
		public virtual RMethod RMCopyFrom_TArray
		{
			get
			{
				if(r_MCopyFrom_TArray == null)
				{
					r_MCopyFrom_TArray = new(this, "CopyFrom", 0, Type.MakeGenericMethodParameter(0).MakeArrayType());
				}
				return r_MCopyFrom_TArray;
			}
		}

		/// <summary>
		/// Void CopyFrom(Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_MCopyFrom_NativeArray_d_T_p_;
		public virtual RMethod RMCopyFrom_NativeArray_d_T_p_
		{
			get
			{
				if(r_MCopyFrom_NativeArray_d_T_p_ == null)
				{
					r_MCopyFrom_NativeArray_d_T_p_ = new(this, "CopyFrom", 0, typeof(Unity.Collections.NativeArray<>));
				}
				return r_MCopyFrom_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void CopyTo(T[])
		/// </summary>
		protected RMethod r_MCopyTo_TArray;
		public virtual RMethod RMCopyTo_TArray
		{
			get
			{
				if(r_MCopyTo_TArray == null)
				{
					r_MCopyTo_TArray = new(this, "CopyTo", 0, Type.MakeGenericMethodParameter(0).MakeArrayType());
				}
				return r_MCopyTo_TArray;
			}
		}

		/// <summary>
		/// Void CopyTo(Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_MCopyTo_NativeArray_d_T_p_;
		public virtual RMethod RMCopyTo_NativeArray_d_T_p_
		{
			get
			{
				if(r_MCopyTo_NativeArray_d_T_p_ == null)
				{
					r_MCopyTo_NativeArray_d_T_p_ = new(this, "CopyTo", 0, typeof(Unity.Collections.NativeArray<>));
				}
				return r_MCopyTo_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// T[] ToArray()
		/// </summary>
		protected RMethod r_MToArray;
		public virtual RMethod RMToArray
		{
			get
			{
				if(r_MToArray == null)
				{
					r_MToArray = new(this, "ToArray", 0);
				}
				return r_MToArray;
			}
		}

		/// <summary>
		/// Void FailOutOfRangeError(Int32)
		/// </summary>
		protected RMethod r_MFailOutOfRangeError_Int32;
		public virtual RMethod RMFailOutOfRangeError_Int32
		{
			get
			{
				if(r_MFailOutOfRangeError_Int32 == null)
				{
					r_MFailOutOfRangeError_Int32 = new(this, "FailOutOfRangeError", 0, typeof(System.Int32));
				}
				return r_MFailOutOfRangeError_Int32;
			}
		}

		/// <summary>
		/// Enumerator GetEnumerator()
		/// </summary>
		protected RMethod r_MGetEnumerator;
		public virtual RMethod RMGetEnumerator
		{
			get
			{
				if(r_MGetEnumerator == null)
				{
					r_MGetEnumerator = new(this, "GetEnumerator", 0);
				}
				return r_MGetEnumerator;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerator`1[T] System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator == null)
				{
					r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator = new(this, "System.Collections.Generic.IEnumerable<T>.GetEnumerator", 0);
				}
				return r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator;
		public virtual RMethod RMSystem__2__Collections__2__IEnumerable__2__GetEnumerator
		{
			get
			{
				if(r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator == null)
				{
					r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator = new(this, "System.Collections.IEnumerable.GetEnumerator", 0);
				}
				return r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator;
			}
		}

		/// <summary>
		/// Boolean Equals(Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_MEquals_NativeArray_d_T_p_;
		public virtual RMethod RMEquals_NativeArray_d_T_p_
		{
			get
			{
				if(r_MEquals_NativeArray_d_T_p_ == null)
				{
					r_MEquals_NativeArray_d_T_p_ = new(this, "Equals", 0, typeof(Unity.Collections.NativeArray<>));
				}
				return r_MEquals_NativeArray_d_T_p_;
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
		/// Boolean op_Equality(Unity.Collections.NativeArray`1[T], Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected static RMethod r_Mop_Equality_NativeArray_d_T_p__NativeArray_d_T_p_;
		public static RMethod RMop_Equality_NativeArray_d_T_p__NativeArray_d_T_p_
		{
			get
			{
				if(r_Mop_Equality_NativeArray_d_T_p__NativeArray_d_T_p_ == null)
				{
					r_Mop_Equality_NativeArray_d_T_p__NativeArray_d_T_p_ = new(typeof(Unity.Collections.NativeArray<>), "op_Equality", 0, typeof(Unity.Collections.NativeArray<>), typeof(Unity.Collections.NativeArray<>));
				}
				return r_Mop_Equality_NativeArray_d_T_p__NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(Unity.Collections.NativeArray`1[T], Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected static RMethod r_Mop_Inequality_NativeArray_d_T_p__NativeArray_d_T_p_;
		public static RMethod RMop_Inequality_NativeArray_d_T_p__NativeArray_d_T_p_
		{
			get
			{
				if(r_Mop_Inequality_NativeArray_d_T_p__NativeArray_d_T_p_ == null)
				{
					r_Mop_Inequality_NativeArray_d_T_p__NativeArray_d_T_p_ = new(typeof(Unity.Collections.NativeArray<>), "op_Inequality", 0, typeof(Unity.Collections.NativeArray<>), typeof(Unity.Collections.NativeArray<>));
				}
				return r_Mop_Inequality_NativeArray_d_T_p__NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void Copy(Unity.Collections.NativeArray`1[T], Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected static RMethod r_MCopy_NativeArray_d_T_p__NativeArray_d_T_p_;
		public static RMethod RMCopy_NativeArray_d_T_p__NativeArray_d_T_p_
		{
			get
			{
				if(r_MCopy_NativeArray_d_T_p__NativeArray_d_T_p_ == null)
				{
					r_MCopy_NativeArray_d_T_p__NativeArray_d_T_p_ = new(typeof(Unity.Collections.NativeArray<>), "Copy", 0, typeof(Unity.Collections.NativeArray<>), typeof(Unity.Collections.NativeArray<>));
				}
				return r_MCopy_NativeArray_d_T_p__NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void Copy(ReadOnly, Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected static RMethod r_MCopy_ReadOnly_NativeArray_d_T_p_;
		public static RMethod RMCopy_ReadOnly_NativeArray_d_T_p_
		{
			get
			{
				if(r_MCopy_ReadOnly_NativeArray_d_T_p_ == null)
				{
					r_MCopy_ReadOnly_NativeArray_d_T_p_ = new(typeof(Unity.Collections.NativeArray<>), "Copy", 0,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1+ReadOnly").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(Unity.Collections.NativeArray<>));
				}
				return r_MCopy_ReadOnly_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void Copy(T[], Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected static RMethod r_MCopy_TArray_NativeArray_d_T_p_;
		public static RMethod RMCopy_TArray_NativeArray_d_T_p_
		{
			get
			{
				if(r_MCopy_TArray_NativeArray_d_T_p_ == null)
				{
					r_MCopy_TArray_NativeArray_d_T_p_ = new(typeof(Unity.Collections.NativeArray<>), "Copy", 0, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(Unity.Collections.NativeArray<>));
				}
				return r_MCopy_TArray_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void Copy(Unity.Collections.NativeArray`1[T], T[])
		/// </summary>
		protected static RMethod r_MCopy_NativeArray_d_T_p__TArray;
		public static RMethod RMCopy_NativeArray_d_T_p__TArray
		{
			get
			{
				if(r_MCopy_NativeArray_d_T_p__TArray == null)
				{
					r_MCopy_NativeArray_d_T_p__TArray = new(typeof(Unity.Collections.NativeArray<>), "Copy", 0, typeof(Unity.Collections.NativeArray<>), Type.MakeGenericMethodParameter(0).MakeArrayType());
				}
				return r_MCopy_NativeArray_d_T_p__TArray;
			}
		}

		/// <summary>
		/// Void Copy(ReadOnly, T[])
		/// </summary>
		protected static RMethod r_MCopy_ReadOnly_TArray;
		public static RMethod RMCopy_ReadOnly_TArray
		{
			get
			{
				if(r_MCopy_ReadOnly_TArray == null)
				{
					r_MCopy_ReadOnly_TArray = new(typeof(Unity.Collections.NativeArray<>), "Copy", 0,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1+ReadOnly").MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0).MakeArrayType());
				}
				return r_MCopy_ReadOnly_TArray;
			}
		}

		/// <summary>
		/// Void Copy(Unity.Collections.NativeArray`1[T], Unity.Collections.NativeArray`1[T], Int32)
		/// </summary>
		protected static RMethod r_MCopy_NativeArray_d_T_p__NativeArray_d_T_p__Int32;
		public static RMethod RMCopy_NativeArray_d_T_p__NativeArray_d_T_p__Int32
		{
			get
			{
				if(r_MCopy_NativeArray_d_T_p__NativeArray_d_T_p__Int32 == null)
				{
					r_MCopy_NativeArray_d_T_p__NativeArray_d_T_p__Int32 = new(typeof(Unity.Collections.NativeArray<>), "Copy", 0, typeof(Unity.Collections.NativeArray<>), typeof(Unity.Collections.NativeArray<>), typeof(System.Int32));
				}
				return r_MCopy_NativeArray_d_T_p__NativeArray_d_T_p__Int32;
			}
		}

		/// <summary>
		/// Void Copy(ReadOnly, Unity.Collections.NativeArray`1[T], Int32)
		/// </summary>
		protected static RMethod r_MCopy_ReadOnly_NativeArray_d_T_p__Int32;
		public static RMethod RMCopy_ReadOnly_NativeArray_d_T_p__Int32
		{
			get
			{
				if(r_MCopy_ReadOnly_NativeArray_d_T_p__Int32 == null)
				{
					r_MCopy_ReadOnly_NativeArray_d_T_p__Int32 = new(typeof(Unity.Collections.NativeArray<>), "Copy", 0,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1+ReadOnly").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(Unity.Collections.NativeArray<>), typeof(System.Int32));
				}
				return r_MCopy_ReadOnly_NativeArray_d_T_p__Int32;
			}
		}

		/// <summary>
		/// Void Copy(T[], Unity.Collections.NativeArray`1[T], Int32)
		/// </summary>
		protected static RMethod r_MCopy_TArray_NativeArray_d_T_p__Int32;
		public static RMethod RMCopy_TArray_NativeArray_d_T_p__Int32
		{
			get
			{
				if(r_MCopy_TArray_NativeArray_d_T_p__Int32 == null)
				{
					r_MCopy_TArray_NativeArray_d_T_p__Int32 = new(typeof(Unity.Collections.NativeArray<>), "Copy", 0, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(Unity.Collections.NativeArray<>), typeof(System.Int32));
				}
				return r_MCopy_TArray_NativeArray_d_T_p__Int32;
			}
		}

		/// <summary>
		/// Void Copy(Unity.Collections.NativeArray`1[T], T[], Int32)
		/// </summary>
		protected static RMethod r_MCopy_NativeArray_d_T_p__TArray_Int32;
		public static RMethod RMCopy_NativeArray_d_T_p__TArray_Int32
		{
			get
			{
				if(r_MCopy_NativeArray_d_T_p__TArray_Int32 == null)
				{
					r_MCopy_NativeArray_d_T_p__TArray_Int32 = new(typeof(Unity.Collections.NativeArray<>), "Copy", 0, typeof(Unity.Collections.NativeArray<>), Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32));
				}
				return r_MCopy_NativeArray_d_T_p__TArray_Int32;
			}
		}

		/// <summary>
		/// Void Copy(ReadOnly, T[], Int32)
		/// </summary>
		protected static RMethod r_MCopy_ReadOnly_TArray_Int32;
		public static RMethod RMCopy_ReadOnly_TArray_Int32
		{
			get
			{
				if(r_MCopy_ReadOnly_TArray_Int32 == null)
				{
					r_MCopy_ReadOnly_TArray_Int32 = new(typeof(Unity.Collections.NativeArray<>), "Copy", 0,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1+ReadOnly").MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32));
				}
				return r_MCopy_ReadOnly_TArray_Int32;
			}
		}

		/// <summary>
		/// Void Copy(Unity.Collections.NativeArray`1[T], Int32, Unity.Collections.NativeArray`1[T], Int32, Int32)
		/// </summary>
		protected static RMethod r_MCopy_NativeArray_d_T_p__Int32_NativeArray_d_T_p__Int32_Int32;
		public static RMethod RMCopy_NativeArray_d_T_p__Int32_NativeArray_d_T_p__Int32_Int32
		{
			get
			{
				if(r_MCopy_NativeArray_d_T_p__Int32_NativeArray_d_T_p__Int32_Int32 == null)
				{
					r_MCopy_NativeArray_d_T_p__Int32_NativeArray_d_T_p__Int32_Int32 = new(typeof(Unity.Collections.NativeArray<>), "Copy", 0, typeof(Unity.Collections.NativeArray<>), typeof(System.Int32), typeof(Unity.Collections.NativeArray<>), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MCopy_NativeArray_d_T_p__Int32_NativeArray_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void Copy(ReadOnly, Int32, Unity.Collections.NativeArray`1[T], Int32, Int32)
		/// </summary>
		protected static RMethod r_MCopy_ReadOnly_Int32_NativeArray_d_T_p__Int32_Int32;
		public static RMethod RMCopy_ReadOnly_Int32_NativeArray_d_T_p__Int32_Int32
		{
			get
			{
				if(r_MCopy_ReadOnly_Int32_NativeArray_d_T_p__Int32_Int32 == null)
				{
					r_MCopy_ReadOnly_Int32_NativeArray_d_T_p__Int32_Int32 = new(typeof(Unity.Collections.NativeArray<>), "Copy", 0,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1+ReadOnly").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(Unity.Collections.NativeArray<>), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MCopy_ReadOnly_Int32_NativeArray_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void Copy(T[], Int32, Unity.Collections.NativeArray`1[T], Int32, Int32)
		/// </summary>
		protected static RMethod r_MCopy_TArray_Int32_NativeArray_d_T_p__Int32_Int32;
		public static RMethod RMCopy_TArray_Int32_NativeArray_d_T_p__Int32_Int32
		{
			get
			{
				if(r_MCopy_TArray_Int32_NativeArray_d_T_p__Int32_Int32 == null)
				{
					r_MCopy_TArray_Int32_NativeArray_d_T_p__Int32_Int32 = new(typeof(Unity.Collections.NativeArray<>), "Copy", 0, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(Unity.Collections.NativeArray<>), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MCopy_TArray_Int32_NativeArray_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void Copy(Unity.Collections.NativeArray`1[T], Int32, T[], Int32, Int32)
		/// </summary>
		protected static RMethod r_MCopy_NativeArray_d_T_p__Int32_TArray_Int32_Int32;
		public static RMethod RMCopy_NativeArray_d_T_p__Int32_TArray_Int32_Int32
		{
			get
			{
				if(r_MCopy_NativeArray_d_T_p__Int32_TArray_Int32_Int32 == null)
				{
					r_MCopy_NativeArray_d_T_p__Int32_TArray_Int32_Int32 = new(typeof(Unity.Collections.NativeArray<>), "Copy", 0, typeof(Unity.Collections.NativeArray<>), typeof(System.Int32), Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MCopy_NativeArray_d_T_p__Int32_TArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Copy(ReadOnly, Int32, T[], Int32, Int32)
		/// </summary>
		protected static RMethod r_MCopy_ReadOnly_Int32_TArray_Int32_Int32;
		public static RMethod RMCopy_ReadOnly_Int32_TArray_Int32_Int32
		{
			get
			{
				if(r_MCopy_ReadOnly_Int32_TArray_Int32_Int32 == null)
				{
					r_MCopy_ReadOnly_Int32_TArray_Int32_Int32 = new(typeof(Unity.Collections.NativeArray<>), "Copy", 0,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1+ReadOnly").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MCopy_ReadOnly_Int32_TArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void CopySafe(Unity.Collections.NativeArray`1[T], Int32, Unity.Collections.NativeArray`1[T], Int32, Int32)
		/// </summary>
		protected static RMethod r_MCopySafe_NativeArray_d_T_p__Int32_NativeArray_d_T_p__Int32_Int32;
		public static RMethod RMCopySafe_NativeArray_d_T_p__Int32_NativeArray_d_T_p__Int32_Int32
		{
			get
			{
				if(r_MCopySafe_NativeArray_d_T_p__Int32_NativeArray_d_T_p__Int32_Int32 == null)
				{
					r_MCopySafe_NativeArray_d_T_p__Int32_NativeArray_d_T_p__Int32_Int32 = new(typeof(Unity.Collections.NativeArray<>), "CopySafe", 0, typeof(Unity.Collections.NativeArray<>), typeof(System.Int32), typeof(Unity.Collections.NativeArray<>), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MCopySafe_NativeArray_d_T_p__Int32_NativeArray_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void CopySafe(ReadOnly, Int32, Unity.Collections.NativeArray`1[T], Int32, Int32)
		/// </summary>
		protected static RMethod r_MCopySafe_ReadOnly_Int32_NativeArray_d_T_p__Int32_Int32;
		public static RMethod RMCopySafe_ReadOnly_Int32_NativeArray_d_T_p__Int32_Int32
		{
			get
			{
				if(r_MCopySafe_ReadOnly_Int32_NativeArray_d_T_p__Int32_Int32 == null)
				{
					r_MCopySafe_ReadOnly_Int32_NativeArray_d_T_p__Int32_Int32 = new(typeof(Unity.Collections.NativeArray<>), "CopySafe", 0,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1+ReadOnly").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(Unity.Collections.NativeArray<>), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MCopySafe_ReadOnly_Int32_NativeArray_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void CopySafe(T[], Int32, Unity.Collections.NativeArray`1[T], Int32, Int32)
		/// </summary>
		protected static RMethod r_MCopySafe_TArray_Int32_NativeArray_d_T_p__Int32_Int32;
		public static RMethod RMCopySafe_TArray_Int32_NativeArray_d_T_p__Int32_Int32
		{
			get
			{
				if(r_MCopySafe_TArray_Int32_NativeArray_d_T_p__Int32_Int32 == null)
				{
					r_MCopySafe_TArray_Int32_NativeArray_d_T_p__Int32_Int32 = new(typeof(Unity.Collections.NativeArray<>), "CopySafe", 0, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(Unity.Collections.NativeArray<>), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MCopySafe_TArray_Int32_NativeArray_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void CopySafe(Unity.Collections.NativeArray`1[T], Int32, T[], Int32, Int32)
		/// </summary>
		protected static RMethod r_MCopySafe_NativeArray_d_T_p__Int32_TArray_Int32_Int32;
		public static RMethod RMCopySafe_NativeArray_d_T_p__Int32_TArray_Int32_Int32
		{
			get
			{
				if(r_MCopySafe_NativeArray_d_T_p__Int32_TArray_Int32_Int32 == null)
				{
					r_MCopySafe_NativeArray_d_T_p__Int32_TArray_Int32_Int32 = new(typeof(Unity.Collections.NativeArray<>), "CopySafe", 0, typeof(Unity.Collections.NativeArray<>), typeof(System.Int32), Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MCopySafe_NativeArray_d_T_p__Int32_TArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void CopySafe(ReadOnly, Int32, T[], Int32, Int32)
		/// </summary>
		protected static RMethod r_MCopySafe_ReadOnly_Int32_TArray_Int32_Int32;
		public static RMethod RMCopySafe_ReadOnly_Int32_TArray_Int32_Int32
		{
			get
			{
				if(r_MCopySafe_ReadOnly_Int32_TArray_Int32_Int32 == null)
				{
					r_MCopySafe_ReadOnly_Int32_TArray_Int32_Int32 = new(typeof(Unity.Collections.NativeArray<>), "CopySafe", 0,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1+ReadOnly").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MCopySafe_ReadOnly_Int32_TArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void CheckCopyPtr(T[])
		/// </summary>
		protected static RMethod r_MCheckCopyPtr_TArray;
		public static RMethod RMCheckCopyPtr_TArray
		{
			get
			{
				if(r_MCheckCopyPtr_TArray == null)
				{
					r_MCheckCopyPtr_TArray = new(typeof(Unity.Collections.NativeArray<>), "CheckCopyPtr", 0, Type.MakeGenericMethodParameter(0).MakeArrayType());
				}
				return r_MCheckCopyPtr_TArray;
			}
		}

		/// <summary>
		/// Void CheckCopyLengths(Int32, Int32)
		/// </summary>
		protected static RMethod r_MCheckCopyLengths_Int32_Int32;
		public static RMethod RMCheckCopyLengths_Int32_Int32
		{
			get
			{
				if(r_MCheckCopyLengths_Int32_Int32 == null)
				{
					r_MCheckCopyLengths_Int32_Int32 = new(typeof(Unity.Collections.NativeArray<>), "CheckCopyLengths", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MCheckCopyLengths_Int32_Int32;
			}
		}

		/// <summary>
		/// Void CheckCopyArguments(Int32, Int32, Int32, Int32, Int32)
		/// </summary>
		protected static RMethod r_MCheckCopyArguments_Int32_Int32_Int32_Int32_Int32;
		public static RMethod RMCheckCopyArguments_Int32_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MCheckCopyArguments_Int32_Int32_Int32_Int32_Int32 == null)
				{
					r_MCheckCopyArguments_Int32_Int32_Int32_Int32_Int32 = new(typeof(Unity.Collections.NativeArray<>), "CheckCopyArguments", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MCheckCopyArguments_Int32_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void CheckReinterpretLoadRange[U](Int32)
		/// </summary>
		protected RMethod r_MCheckReinterpretLoadRange_GU_Int32;
		public virtual RMethod RMCheckReinterpretLoadRange_GU_Int32
		{
			get
			{
				if(r_MCheckReinterpretLoadRange_GU_Int32 == null)
				{
					r_MCheckReinterpretLoadRange_GU_Int32 = new(this, "CheckReinterpretLoadRange", 1, typeof(System.Int32));
				}
				return r_MCheckReinterpretLoadRange_GU_Int32;
			}
		}

		/// <summary>
		/// Void CheckReinterpretStoreRange[U](Int32)
		/// </summary>
		protected RMethod r_MCheckReinterpretStoreRange_GU_Int32;
		public virtual RMethod RMCheckReinterpretStoreRange_GU_Int32
		{
			get
			{
				if(r_MCheckReinterpretStoreRange_GU_Int32 == null)
				{
					r_MCheckReinterpretStoreRange_GU_Int32 = new(this, "CheckReinterpretStoreRange", 1, typeof(System.Int32));
				}
				return r_MCheckReinterpretStoreRange_GU_Int32;
			}
		}

		/// <summary>
		/// U ReinterpretLoad[U](Int32)
		/// </summary>
		protected RMethod r_MReinterpretLoad_GU_Int32;
		public virtual RMethod RMReinterpretLoad_GU_Int32
		{
			get
			{
				if(r_MReinterpretLoad_GU_Int32 == null)
				{
					r_MReinterpretLoad_GU_Int32 = new(this, "ReinterpretLoad", 1, typeof(System.Int32));
				}
				return r_MReinterpretLoad_GU_Int32;
			}
		}

		/// <summary>
		/// Void ReinterpretStore[U](Int32, U)
		/// </summary>
		protected RMethod r_MReinterpretStore_GU_Int32_U;
		public virtual RMethod RMReinterpretStore_GU_Int32_U
		{
			get
			{
				if(r_MReinterpretStore_GU_Int32_U == null)
				{
					r_MReinterpretStore_GU_Int32_U = new(this, "ReinterpretStore", 1, typeof(System.Int32), Type.MakeGenericMethodParameter(0));
				}
				return r_MReinterpretStore_GU_Int32_U;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[U] InternalReinterpret[U](Int32)
		/// </summary>
		protected RMethod r_MInternalReinterpret_GU_Int32;
		public virtual RMethod RMInternalReinterpret_GU_Int32
		{
			get
			{
				if(r_MInternalReinterpret_GU_Int32 == null)
				{
					r_MInternalReinterpret_GU_Int32 = new(this, "InternalReinterpret", 1, typeof(System.Int32));
				}
				return r_MInternalReinterpret_GU_Int32;
			}
		}

		/// <summary>
		/// Void CheckReinterpretSize[U]()
		/// </summary>
		protected static RMethod r_MCheckReinterpretSize_GU;
		public static RMethod RMCheckReinterpretSize_GU
		{
			get
			{
				if(r_MCheckReinterpretSize_GU == null)
				{
					r_MCheckReinterpretSize_GU = new(typeof(Unity.Collections.NativeArray<>), "CheckReinterpretSize", 1);
				}
				return r_MCheckReinterpretSize_GU;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[U] Reinterpret[U]()
		/// </summary>
		protected RMethod r_MReinterpret_GU;
		public virtual RMethod RMReinterpret_GU
		{
			get
			{
				if(r_MReinterpret_GU == null)
				{
					r_MReinterpret_GU = new(this, "Reinterpret", 1);
				}
				return r_MReinterpret_GU;
			}
		}

		/// <summary>
		/// Void CheckReinterpretSize[U](Int64, Int64, Int32, Int64, Int64)
		/// </summary>
		protected RMethod r_MCheckReinterpretSize_GU_Int64_Int64_Int32_Int64_Int64;
		public virtual RMethod RMCheckReinterpretSize_GU_Int64_Int64_Int32_Int64_Int64
		{
			get
			{
				if(r_MCheckReinterpretSize_GU_Int64_Int64_Int32_Int64_Int64 == null)
				{
					r_MCheckReinterpretSize_GU_Int64_Int64_Int32_Int64_Int64 = new(this, "CheckReinterpretSize", 1, typeof(System.Int64), typeof(System.Int64), typeof(System.Int32), typeof(System.Int64), typeof(System.Int64));
				}
				return r_MCheckReinterpretSize_GU_Int64_Int64_Int32_Int64_Int64;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[U] Reinterpret[U](Int32)
		/// </summary>
		protected RMethod r_MReinterpret_GU_Int32;
		public virtual RMethod RMReinterpret_GU_Int32
		{
			get
			{
				if(r_MReinterpret_GU_Int32 == null)
				{
					r_MReinterpret_GU_Int32 = new(this, "Reinterpret", 1, typeof(System.Int32));
				}
				return r_MReinterpret_GU_Int32;
			}
		}

		/// <summary>
		/// Void CheckGetSubArrayArguments(Int32, Int32)
		/// </summary>
		protected RMethod r_MCheckGetSubArrayArguments_Int32_Int32;
		public virtual RMethod RMCheckGetSubArrayArguments_Int32_Int32
		{
			get
			{
				if(r_MCheckGetSubArrayArguments_Int32_Int32 == null)
				{
					r_MCheckGetSubArrayArguments_Int32_Int32 = new(this, "CheckGetSubArrayArguments", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MCheckGetSubArrayArguments_Int32_Int32;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[T] GetSubArray(Int32, Int32)
		/// </summary>
		protected RMethod r_MGetSubArray_Int32_Int32;
		public virtual RMethod RMGetSubArray_Int32_Int32
		{
			get
			{
				if(r_MGetSubArray_Int32_Int32 == null)
				{
					r_MGetSubArray_Int32_Int32 = new(this, "GetSubArray", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MGetSubArray_Int32_Int32;
			}
		}

		/// <summary>
		/// ReadOnly AsReadOnly()
		/// </summary>
		protected RMethod r_MAsReadOnly;
		public virtual RMethod RMAsReadOnly
		{
			get
			{
				if(r_MAsReadOnly == null)
				{
					r_MAsReadOnly = new(this, "AsReadOnly", 0);
				}
				return r_MAsReadOnly;
			}
		}

		/// <summary>
		/// System.Span`1[T] AsSpan()
		/// </summary>
		protected RMethod r_MAsSpan;
		public virtual RMethod RMAsSpan
		{
			get
			{
				if(r_MAsSpan == null)
				{
					r_MAsSpan = new(this, "AsSpan", 0);
				}
				return r_MAsSpan;
			}
		}

		/// <summary>
		/// System.ReadOnlySpan`1[T] AsReadOnlySpan()
		/// </summary>
		protected RMethod r_MAsReadOnlySpan;
		public virtual RMethod RMAsReadOnlySpan
		{
			get
			{
				if(r_MAsReadOnlySpan == null)
				{
					r_MAsReadOnlySpan = new(this, "AsReadOnlySpan", 0);
				}
				return r_MAsReadOnlySpan;
			}
		}

		/// <summary>
		/// System.Span`1[T] op_Implicit(Unity.Collections.NativeArray`1[T] ByRef)
		/// </summary>
		protected static RMethod r_Mop_Implicit_In_NativeArray_d_T_p_;
		public static RMethod RMop_Implicit_In_NativeArray_d_T_p_
		{
			get
			{
				if(r_Mop_Implicit_In_NativeArray_d_T_p_ == null)
				{
					r_Mop_Implicit_In_NativeArray_d_T_p_ = new(typeof(Unity.Collections.NativeArray<>), "op_Implicit", 0, typeof(Unity.Collections.NativeArray<>).MakeByRefType());
				}
				return r_Mop_Implicit_In_NativeArray_d_T_p_;
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


        public static void InitStaticSafetyId(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMInitStaticSafetyId_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static void CheckAllocateArguments(System.Int32 @length, Unity.Collections.Allocator @allocator)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@length, @allocator};
            var ___result = RMCheckAllocateArguments_Int32_Allocator.Invoke(___genericsType, ___parameters);

            
        }


        public static void Allocate(System.Int32 @length, Unity.Collections.Allocator @allocator, out Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @array)
        {
			@array = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@length, @allocator, @array.Value};
            var ___result = RMAllocate_Int32_Allocator_Out_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);
			@array = new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>(___parameters[2]);

            
        }


        public static void InitNestedNativeContainer(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMInitNestedNativeContainer_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            
        }


        public static void IsUnmanagedAndThrow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsUnmanagedAndThrow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckElementReadAccess(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMCheckElementReadAccess_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckElementWriteAccess(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMCheckElementWriteAccess_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle @inputDeps)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inputDeps};
            var ___result = RMDispose_JobHandle.Invoke(___genericsType, ___parameters);

            return (Unity.Jobs.JobHandle)___result;
        }


        public virtual void CopyFrom(Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RType> @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array.Value};
            var ___result = RMCopyFrom_TArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyFrom(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array.Value};
            var ___result = RMCopyFrom_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RType> @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array.Value};
            var ___result = RMCopyTo_TArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array.Value};
            var ___result = RMCopyTo_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RType> ToArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToArray.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RType>(___result);
        }


        public virtual void FailOutOfRangeError(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMFailOutOfRangeError_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>.REnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>.REnumerator(___result);
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerator<Hvak.Editor.Refleaction.RType> System__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerator<Hvak.Editor.Refleaction.RType>(___result);
        }


        public virtual System.Collections.IEnumerator System__2__Collections__2__IEnumerable__2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__IEnumerable__2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Boolean Equals(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMEquals_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public static System.Boolean op_Equality(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @left, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = RMop_Equality_NativeArray_d_T_p__NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @left, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = RMop_Inequality_NativeArray_d_T_p__NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void Copy(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @src, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @dst)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @dst.Value};
            var ___result = RMCopy_NativeArray_d_T_p__NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>.RReadOnly @src, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @dst)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @dst.Value};
            var ___result = RMCopy_ReadOnly_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RType> @src, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @dst)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @dst.Value};
            var ___result = RMCopy_TArray_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @src, Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RType> @dst)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @dst.Value};
            var ___result = RMCopy_NativeArray_d_T_p__TArray.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>.RReadOnly @src, Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RType> @dst)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @dst.Value};
            var ___result = RMCopy_ReadOnly_TArray.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @src, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @dst, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @dst.Value, @length};
            var ___result = RMCopy_NativeArray_d_T_p__NativeArray_d_T_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>.RReadOnly @src, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @dst, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @dst.Value, @length};
            var ___result = RMCopy_ReadOnly_NativeArray_d_T_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RType> @src, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @dst, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @dst.Value, @length};
            var ___result = RMCopy_TArray_NativeArray_d_T_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @src, Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RType> @dst, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @dst.Value, @length};
            var ___result = RMCopy_NativeArray_d_T_p__TArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>.RReadOnly @src, Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RType> @dst, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @dst.Value, @length};
            var ___result = RMCopy_ReadOnly_TArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @src, System.Int32 @srcIndex, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @dst, System.Int32 @dstIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @srcIndex, @dst.Value, @dstIndex, @length};
            var ___result = RMCopy_NativeArray_d_T_p__Int32_NativeArray_d_T_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>.RReadOnly @src, System.Int32 @srcIndex, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @dst, System.Int32 @dstIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @srcIndex, @dst.Value, @dstIndex, @length};
            var ___result = RMCopy_ReadOnly_Int32_NativeArray_d_T_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RType> @src, System.Int32 @srcIndex, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @dst, System.Int32 @dstIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @srcIndex, @dst.Value, @dstIndex, @length};
            var ___result = RMCopy_TArray_Int32_NativeArray_d_T_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @src, System.Int32 @srcIndex, Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RType> @dst, System.Int32 @dstIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @srcIndex, @dst.Value, @dstIndex, @length};
            var ___result = RMCopy_NativeArray_d_T_p__Int32_TArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>.RReadOnly @src, System.Int32 @srcIndex, Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RType> @dst, System.Int32 @dstIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @srcIndex, @dst.Value, @dstIndex, @length};
            var ___result = RMCopy_ReadOnly_Int32_TArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void CopySafe(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @src, System.Int32 @srcIndex, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @dst, System.Int32 @dstIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @srcIndex, @dst.Value, @dstIndex, @length};
            var ___result = RMCopySafe_NativeArray_d_T_p__Int32_NativeArray_d_T_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void CopySafe(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>.RReadOnly @src, System.Int32 @srcIndex, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @dst, System.Int32 @dstIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @srcIndex, @dst.Value, @dstIndex, @length};
            var ___result = RMCopySafe_ReadOnly_Int32_NativeArray_d_T_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void CopySafe(Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RType> @src, System.Int32 @srcIndex, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @dst, System.Int32 @dstIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @srcIndex, @dst.Value, @dstIndex, @length};
            var ___result = RMCopySafe_TArray_Int32_NativeArray_d_T_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void CopySafe(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @src, System.Int32 @srcIndex, Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RType> @dst, System.Int32 @dstIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @srcIndex, @dst.Value, @dstIndex, @length};
            var ___result = RMCopySafe_NativeArray_d_T_p__Int32_TArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void CopySafe(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>.RReadOnly @src, System.Int32 @srcIndex, Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RType> @dst, System.Int32 @dstIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src.Value, @srcIndex, @dst.Value, @dstIndex, @length};
            var ___result = RMCopySafe_ReadOnly_Int32_TArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void CheckCopyPtr(Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RType> @ptr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ptr.Value};
            var ___result = RMCheckCopyPtr_TArray.Invoke(___genericsType, ___parameters);

            
        }


        public static void CheckCopyLengths(System.Int32 @srcLength, System.Int32 @dstLength)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@srcLength, @dstLength};
            var ___result = RMCheckCopyLengths_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void CheckCopyArguments(System.Int32 @srcLength, System.Int32 @srcIndex, System.Int32 @dstLength, System.Int32 @dstIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@srcLength, @srcIndex, @dstLength, @dstIndex, @length};
            var ___result = RMCheckCopyArguments_Int32_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckReinterpretLoadRange<U>(System.Int32 @sourceIndex) where U : struct
        {

            var ___genericsType = new Type[] {typeof(U)};
            var ___parameters = new object[]{@sourceIndex};
            var ___result = RMCheckReinterpretLoadRange_GU_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckReinterpretStoreRange<U>(System.Int32 @destIndex) where U : struct
        {

            var ___genericsType = new Type[] {typeof(U)};
            var ___parameters = new object[]{@destIndex};
            var ___result = RMCheckReinterpretStoreRange_GU_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RType ReinterpretLoad<U>(System.Int32 @sourceIndex) where U : struct
        {

            var ___genericsType = new Type[] {typeof(U)};
            var ___parameters = new object[]{@sourceIndex};
            var ___result = RMReinterpretLoad_GU_Int32.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RType(___result);
        }


        public virtual void ReinterpretStore<U>(System.Int32 @destIndex, Hvak.Editor.Refleaction.RType @data) where U : struct
        {

            var ___genericsType = new Type[] {typeof(U)};
            var ___parameters = new object[]{@destIndex, @data.Value};
            var ___result = RMReinterpretStore_GU_Int32_U.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> InternalReinterpret<U>(System.Int32 @length) where U : struct
        {

            var ___genericsType = new Type[] {typeof(U)};
            var ___parameters = new object[]{@length};
            var ___result = RMInternalReinterpret_GU_Int32.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>(___result);
        }


        public static void CheckReinterpretSize<U>() where U : struct
        {

            var ___genericsType = new Type[] {typeof(U)};
            var ___parameters = new object[]{};
            var ___result = RMCheckReinterpretSize_GU.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> Reinterpret<U>() where U : struct
        {

            var ___genericsType = new Type[] {typeof(U)};
            var ___parameters = new object[]{};
            var ___result = RMReinterpret_GU.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>(___result);
        }


        public virtual void CheckReinterpretSize<U>(System.Int64 @tSize, System.Int64 @uSize, System.Int32 @expectedTypeSize, System.Int64 @byteLen, System.Int64 @uLen)
        {

            var ___genericsType = new Type[] {typeof(U)};
            var ___parameters = new object[]{@tSize, @uSize, @expectedTypeSize, @byteLen, @uLen};
            var ___result = RMCheckReinterpretSize_GU_Int64_Int64_Int32_Int64_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> Reinterpret<U>(System.Int32 @expectedTypeSize) where U : struct
        {

            var ___genericsType = new Type[] {typeof(U)};
            var ___parameters = new object[]{@expectedTypeSize};
            var ___result = RMReinterpret_GU_Int32.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>(___result);
        }


        public virtual void CheckGetSubArrayArguments(System.Int32 @start, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @length};
            var ___result = RMCheckGetSubArrayArguments_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> GetSubArray(System.Int32 @start, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @length};
            var ___result = RMGetSubArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>.RReadOnly AsReadOnly()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAsReadOnly.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>.RReadOnly(___result);
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RType> AsSpan()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAsSpan.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RType>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RType> AsReadOnlySpan()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAsReadOnlySpan.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RType>(___result);
        }


        public static Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RType> op_Implicit(in Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @source)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source.Value};
            var ___result = RMop_Implicit_In_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RType>(___result);
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
