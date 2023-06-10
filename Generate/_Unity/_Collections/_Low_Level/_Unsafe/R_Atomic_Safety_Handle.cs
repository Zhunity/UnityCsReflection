
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnity.RCollections.RLowLevel.RUnsafe
{
	/// <summary>
	/// Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle
	/// </summary>
    public partial class RAtomicSafetyHandle : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle);
            }
        }

        public RAtomicSafetyHandle() : base("Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle")
        {
        }

        public RAtomicSafetyHandle(System.Object instance) : base("Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle")
		{
            SetInstance(instance);
		}

        public RAtomicSafetyHandle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAtomicSafetyHandle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 Read
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FRead;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFRead
		{
			get
			{
				if(r_FRead == null)
				{
					r_FRead = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "Read");
				}
				return r_FRead;
			}
		}

		/// <summary>
		/// System.Int32 Write
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FWrite;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFWrite
		{
			get
			{
				if(r_FWrite == null)
				{
					r_FWrite = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "Write");
				}
				return r_FWrite;
			}
		}

		/// <summary>
		/// System.Int32 Dispose
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FDispose;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFDispose
		{
			get
			{
				if(r_FDispose == null)
				{
					r_FDispose = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "Dispose");
				}
				return r_FDispose;
			}
		}

		/// <summary>
		/// System.Int32 ReadCheck
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FReadCheck;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFReadCheck
		{
			get
			{
				if(r_FReadCheck == null)
				{
					r_FReadCheck = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "ReadCheck");
				}
				return r_FReadCheck;
			}
		}

		/// <summary>
		/// System.Int32 WriteCheck
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FWriteCheck;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFWriteCheck
		{
			get
			{
				if(r_FWriteCheck == null)
				{
					r_FWriteCheck = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "WriteCheck");
				}
				return r_FWriteCheck;
			}
		}

		/// <summary>
		/// System.Int32 DisposeCheck
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FDisposeCheck;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFDisposeCheck
		{
			get
			{
				if(r_FDisposeCheck == null)
				{
					r_FDisposeCheck = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "DisposeCheck");
				}
				return r_FDisposeCheck;
			}
		}

		/// <summary>
		/// System.Int32 ReadWriteDisposeCheck
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FReadWriteDisposeCheck;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFReadWriteDisposeCheck
		{
			get
			{
				if(r_FReadWriteDisposeCheck == null)
				{
					r_FReadWriteDisposeCheck = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "ReadWriteDisposeCheck");
				}
				return r_FReadWriteDisposeCheck;
			}
		}

		/// <summary>
		/// System.IntPtr versionNode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_FversionNode;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFversionNode
		{
			get
			{
				if(r_FversionNode == null)
				{
					r_FversionNode = new(this, "versionNode");
				}
				return r_FversionNode;
			}
		}

		/// <summary>
		/// System.Int32 version
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fversion;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFversion
		{
			get
			{
				if(r_Fversion == null)
				{
					r_Fversion = new(this, "version");
				}
				return r_Fversion;
			}
		}

		/// <summary>
		/// System.Int32 staticSafetyId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FstaticSafetyId;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFstaticSafetyId
		{
			get
			{
				if(r_FstaticSafetyId == null)
				{
					r_FstaticSafetyId = new(this, "staticSafetyId");
				}
				return r_FstaticSafetyId;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle Create()
		/// </summary>
		protected static RMethod r_MCreate;
		public static RMethod RMCreate
		{
			get
			{
				if(r_MCreate == null)
				{
					r_MCreate = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "Create", 0);
				}
				return r_MCreate;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetTempUnsafePtrSliceHandle()
		/// </summary>
		protected static RMethod r_MGetTempUnsafePtrSliceHandle;
		public static RMethod RMGetTempUnsafePtrSliceHandle
		{
			get
			{
				if(r_MGetTempUnsafePtrSliceHandle == null)
				{
					r_MGetTempUnsafePtrSliceHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetTempUnsafePtrSliceHandle", 0);
				}
				return r_MGetTempUnsafePtrSliceHandle;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetTempMemoryHandle()
		/// </summary>
		protected static RMethod r_MGetTempMemoryHandle;
		public static RMethod RMGetTempMemoryHandle
		{
			get
			{
				if(r_MGetTempMemoryHandle == null)
				{
					r_MGetTempMemoryHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetTempMemoryHandle", 0);
				}
				return r_MGetTempMemoryHandle;
			}
		}

		/// <summary>
		/// Boolean IsTempMemoryHandle(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_MIsTempMemoryHandle_AtomicSafetyHandle;
		public static RMethod RMIsTempMemoryHandle_AtomicSafetyHandle
		{
			get
			{
				if(r_MIsTempMemoryHandle_AtomicSafetyHandle == null)
				{
					r_MIsTempMemoryHandle_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "IsTempMemoryHandle", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
				}
				return r_MIsTempMemoryHandle_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void Release(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_MRelease_AtomicSafetyHandle;
		public static RMethod RMRelease_AtomicSafetyHandle
		{
			get
			{
				if(r_MRelease_AtomicSafetyHandle == null)
				{
					r_MRelease_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "Release", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
				}
				return r_MRelease_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Boolean IsDefaultValue(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_MIsDefaultValue_In_AtomicSafetyHandle;
		public static RMethod RMIsDefaultValue_In_AtomicSafetyHandle
		{
			get
			{
				if(r_MIsDefaultValue_In_AtomicSafetyHandle == null)
				{
					r_MIsDefaultValue_In_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "IsDefaultValue", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
				}
				return r_MIsDefaultValue_In_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void SetExclusiveWeak(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef, Boolean)
		/// </summary>
		protected static RMethod r_MSetExclusiveWeak_Ref_AtomicSafetyHandle_Boolean;
		public static RMethod RMSetExclusiveWeak_Ref_AtomicSafetyHandle_Boolean
		{
			get
			{
				if(r_MSetExclusiveWeak_Ref_AtomicSafetyHandle_Boolean == null)
				{
					r_MSetExclusiveWeak_Ref_AtomicSafetyHandle_Boolean = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "SetExclusiveWeak", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType(), typeof(System.Boolean));
				}
				return r_MSetExclusiveWeak_Ref_AtomicSafetyHandle_Boolean;
			}
		}

		/// <summary>
		/// Boolean GetExclusiveWeak(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_MGetExclusiveWeak_In_AtomicSafetyHandle;
		public static RMethod RMGetExclusiveWeak_In_AtomicSafetyHandle
		{
			get
			{
				if(r_MGetExclusiveWeak_In_AtomicSafetyHandle == null)
				{
					r_MGetExclusiveWeak_In_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetExclusiveWeak", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
				}
				return r_MGetExclusiveWeak_In_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void PrepareUndisposable(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_MPrepareUndisposable_Ref_AtomicSafetyHandle;
		public static RMethod RMPrepareUndisposable_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_MPrepareUndisposable_Ref_AtomicSafetyHandle == null)
				{
					r_MPrepareUndisposable_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "PrepareUndisposable", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
				}
				return r_MPrepareUndisposable_Ref_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void UseSecondaryVersion(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_MUseSecondaryVersion_Ref_AtomicSafetyHandle;
		public static RMethod RMUseSecondaryVersion_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_MUseSecondaryVersion_Ref_AtomicSafetyHandle == null)
				{
					r_MUseSecondaryVersion_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "UseSecondaryVersion", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
				}
				return r_MUseSecondaryVersion_Ref_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void SetAllowSecondaryVersionWriting(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle, Boolean)
		/// </summary>
		protected static RMethod r_MSetAllowSecondaryVersionWriting_AtomicSafetyHandle_Boolean;
		public static RMethod RMSetAllowSecondaryVersionWriting_AtomicSafetyHandle_Boolean
		{
			get
			{
				if(r_MSetAllowSecondaryVersionWriting_AtomicSafetyHandle_Boolean == null)
				{
					r_MSetAllowSecondaryVersionWriting_AtomicSafetyHandle_Boolean = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "SetAllowSecondaryVersionWriting", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), typeof(System.Boolean));
				}
				return r_MSetAllowSecondaryVersionWriting_AtomicSafetyHandle_Boolean;
			}
		}

		/// <summary>
		/// Void SetBumpSecondaryVersionOnScheduleWrite(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle, Boolean)
		/// </summary>
		protected static RMethod r_MSetBumpSecondaryVersionOnScheduleWrite_AtomicSafetyHandle_Boolean;
		public static RMethod RMSetBumpSecondaryVersionOnScheduleWrite_AtomicSafetyHandle_Boolean
		{
			get
			{
				if(r_MSetBumpSecondaryVersionOnScheduleWrite_AtomicSafetyHandle_Boolean == null)
				{
					r_MSetBumpSecondaryVersionOnScheduleWrite_AtomicSafetyHandle_Boolean = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "SetBumpSecondaryVersionOnScheduleWrite", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), typeof(System.Boolean));
				}
				return r_MSetBumpSecondaryVersionOnScheduleWrite_AtomicSafetyHandle_Boolean;
			}
		}

		/// <summary>
		/// Void SetAllowReadOrWriteAccess(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle, Boolean)
		/// </summary>
		protected static RMethod r_MSetAllowReadOrWriteAccess_AtomicSafetyHandle_Boolean;
		public static RMethod RMSetAllowReadOrWriteAccess_AtomicSafetyHandle_Boolean
		{
			get
			{
				if(r_MSetAllowReadOrWriteAccess_AtomicSafetyHandle_Boolean == null)
				{
					r_MSetAllowReadOrWriteAccess_AtomicSafetyHandle_Boolean = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "SetAllowReadOrWriteAccess", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), typeof(System.Boolean));
				}
				return r_MSetAllowReadOrWriteAccess_AtomicSafetyHandle_Boolean;
			}
		}

		/// <summary>
		/// Boolean GetAllowReadOrWriteAccess(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_MGetAllowReadOrWriteAccess_AtomicSafetyHandle;
		public static RMethod RMGetAllowReadOrWriteAccess_AtomicSafetyHandle
		{
			get
			{
				if(r_MGetAllowReadOrWriteAccess_AtomicSafetyHandle == null)
				{
					r_MGetAllowReadOrWriteAccess_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetAllowReadOrWriteAccess", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
				}
				return r_MGetAllowReadOrWriteAccess_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void SetNestedContainer(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle, Boolean)
		/// </summary>
		protected static RMethod r_MSetNestedContainer_AtomicSafetyHandle_Boolean;
		public static RMethod RMSetNestedContainer_AtomicSafetyHandle_Boolean
		{
			get
			{
				if(r_MSetNestedContainer_AtomicSafetyHandle_Boolean == null)
				{
					r_MSetNestedContainer_AtomicSafetyHandle_Boolean = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "SetNestedContainer", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), typeof(System.Boolean));
				}
				return r_MSetNestedContainer_AtomicSafetyHandle_Boolean;
			}
		}

		/// <summary>
		/// Boolean GetNestedContainer(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_MGetNestedContainer_AtomicSafetyHandle;
		public static RMethod RMGetNestedContainer_AtomicSafetyHandle
		{
			get
			{
				if(r_MGetNestedContainer_AtomicSafetyHandle == null)
				{
					r_MGetNestedContainer_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetNestedContainer", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
				}
				return r_MGetNestedContainer_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void CheckWriteAndBumpSecondaryVersion(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_MCheckWriteAndBumpSecondaryVersion_AtomicSafetyHandle;
		public static RMethod RMCheckWriteAndBumpSecondaryVersion_AtomicSafetyHandle
		{
			get
			{
				if(r_MCheckWriteAndBumpSecondaryVersion_AtomicSafetyHandle == null)
				{
					r_MCheckWriteAndBumpSecondaryVersion_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "CheckWriteAndBumpSecondaryVersion", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
				}
				return r_MCheckWriteAndBumpSecondaryVersion_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.EnforceJobResult EnforceAllBufferJobsHaveCompleted(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_MEnforceAllBufferJobsHaveCompleted_AtomicSafetyHandle;
		public static RMethod RMEnforceAllBufferJobsHaveCompleted_AtomicSafetyHandle
		{
			get
			{
				if(r_MEnforceAllBufferJobsHaveCompleted_AtomicSafetyHandle == null)
				{
					r_MEnforceAllBufferJobsHaveCompleted_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "EnforceAllBufferJobsHaveCompleted", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
				}
				return r_MEnforceAllBufferJobsHaveCompleted_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.EnforceJobResult EnforceAllBufferJobsHaveCompletedAndRelease(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_MEnforceAllBufferJobsHaveCompletedAndRelease_AtomicSafetyHandle;
		public static RMethod RMEnforceAllBufferJobsHaveCompletedAndRelease_AtomicSafetyHandle
		{
			get
			{
				if(r_MEnforceAllBufferJobsHaveCompletedAndRelease_AtomicSafetyHandle == null)
				{
					r_MEnforceAllBufferJobsHaveCompletedAndRelease_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "EnforceAllBufferJobsHaveCompletedAndRelease", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
				}
				return r_MEnforceAllBufferJobsHaveCompletedAndRelease_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.EnforceJobResult EnforceAllBufferJobsHaveCompletedAndDisableReadWrite(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_MEnforceAllBufferJobsHaveCompletedAndDisableReadWrite_AtomicSafetyHandle;
		public static RMethod RMEnforceAllBufferJobsHaveCompletedAndDisableReadWrite_AtomicSafetyHandle
		{
			get
			{
				if(r_MEnforceAllBufferJobsHaveCompletedAndDisableReadWrite_AtomicSafetyHandle == null)
				{
					r_MEnforceAllBufferJobsHaveCompletedAndDisableReadWrite_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "EnforceAllBufferJobsHaveCompletedAndDisableReadWrite", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
				}
				return r_MEnforceAllBufferJobsHaveCompletedAndDisableReadWrite_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void CheckReadAndThrowNoEarlyOut(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_MCheckReadAndThrowNoEarlyOut_AtomicSafetyHandle;
		public static RMethod RMCheckReadAndThrowNoEarlyOut_AtomicSafetyHandle
		{
			get
			{
				if(r_MCheckReadAndThrowNoEarlyOut_AtomicSafetyHandle == null)
				{
					r_MCheckReadAndThrowNoEarlyOut_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "CheckReadAndThrowNoEarlyOut", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
				}
				return r_MCheckReadAndThrowNoEarlyOut_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void CheckWriteAndThrowNoEarlyOut(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_MCheckWriteAndThrowNoEarlyOut_AtomicSafetyHandle;
		public static RMethod RMCheckWriteAndThrowNoEarlyOut_AtomicSafetyHandle
		{
			get
			{
				if(r_MCheckWriteAndThrowNoEarlyOut_AtomicSafetyHandle == null)
				{
					r_MCheckWriteAndThrowNoEarlyOut_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "CheckWriteAndThrowNoEarlyOut", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
				}
				return r_MCheckWriteAndThrowNoEarlyOut_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void CheckDeallocateAndThrow(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_MCheckDeallocateAndThrow_AtomicSafetyHandle;
		public static RMethod RMCheckDeallocateAndThrow_AtomicSafetyHandle
		{
			get
			{
				if(r_MCheckDeallocateAndThrow_AtomicSafetyHandle == null)
				{
					r_MCheckDeallocateAndThrow_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "CheckDeallocateAndThrow", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
				}
				return r_MCheckDeallocateAndThrow_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void CheckGetSecondaryDataPointerAndThrow(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_MCheckGetSecondaryDataPointerAndThrow_AtomicSafetyHandle;
		public static RMethod RMCheckGetSecondaryDataPointerAndThrow_AtomicSafetyHandle
		{
			get
			{
				if(r_MCheckGetSecondaryDataPointerAndThrow_AtomicSafetyHandle == null)
				{
					r_MCheckGetSecondaryDataPointerAndThrow_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "CheckGetSecondaryDataPointerAndThrow", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
				}
				return r_MCheckGetSecondaryDataPointerAndThrow_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Int32 GetReaderArray(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle, Int32, IntPtr)
		/// </summary>
		protected static RMethod r_MGetReaderArray_AtomicSafetyHandle_Int32_IntPtr;
		public static RMethod RMGetReaderArray_AtomicSafetyHandle_Int32_IntPtr
		{
			get
			{
				if(r_MGetReaderArray_AtomicSafetyHandle_Int32_IntPtr == null)
				{
					r_MGetReaderArray_AtomicSafetyHandle_Int32_IntPtr = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetReaderArray", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), typeof(System.Int32), typeof(System.IntPtr));
				}
				return r_MGetReaderArray_AtomicSafetyHandle_Int32_IntPtr;
			}
		}

		/// <summary>
		/// Unity.Jobs.JobHandle GetWriter(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_MGetWriter_AtomicSafetyHandle;
		public static RMethod RMGetWriter_AtomicSafetyHandle
		{
			get
			{
				if(r_MGetWriter_AtomicSafetyHandle == null)
				{
					r_MGetWriter_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetWriter", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
				}
				return r_MGetWriter_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void CheckReadAndThrow(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_MCheckReadAndThrow_AtomicSafetyHandle;
		public static RMethod RMCheckReadAndThrow_AtomicSafetyHandle
		{
			get
			{
				if(r_MCheckReadAndThrow_AtomicSafetyHandle == null)
				{
					r_MCheckReadAndThrow_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "CheckReadAndThrow", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
				}
				return r_MCheckReadAndThrow_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void CheckWriteAndThrow(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_MCheckWriteAndThrow_AtomicSafetyHandle;
		public static RMethod RMCheckWriteAndThrow_AtomicSafetyHandle
		{
			get
			{
				if(r_MCheckWriteAndThrow_AtomicSafetyHandle == null)
				{
					r_MCheckWriteAndThrow_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "CheckWriteAndThrow", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
				}
				return r_MCheckWriteAndThrow_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void ValidateNonDefaultHandle(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_MValidateNonDefaultHandle_In_AtomicSafetyHandle;
		public static RMethod RMValidateNonDefaultHandle_In_AtomicSafetyHandle
		{
			get
			{
				if(r_MValidateNonDefaultHandle_In_AtomicSafetyHandle == null)
				{
					r_MValidateNonDefaultHandle_In_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "ValidateNonDefaultHandle", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
				}
				return r_MValidateNonDefaultHandle_In_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Boolean IsValidNonDefaultHandle(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_MIsValidNonDefaultHandle_In_AtomicSafetyHandle;
		public static RMethod RMIsValidNonDefaultHandle_In_AtomicSafetyHandle
		{
			get
			{
				if(r_MIsValidNonDefaultHandle_In_AtomicSafetyHandle == null)
				{
					r_MIsValidNonDefaultHandle_In_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "IsValidNonDefaultHandle", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
				}
				return r_MIsValidNonDefaultHandle_In_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void CheckExistsAndThrow(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_MCheckExistsAndThrow_In_AtomicSafetyHandle;
		public static RMethod RMCheckExistsAndThrow_In_AtomicSafetyHandle
		{
			get
			{
				if(r_MCheckExistsAndThrow_In_AtomicSafetyHandle == null)
				{
					r_MCheckExistsAndThrow_In_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "CheckExistsAndThrow", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
				}
				return r_MCheckExistsAndThrow_In_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Boolean IsHandleValid(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_MIsHandleValid_In_AtomicSafetyHandle;
		public static RMethod RMIsHandleValid_In_AtomicSafetyHandle
		{
			get
			{
				if(r_MIsHandleValid_In_AtomicSafetyHandle == null)
				{
					r_MIsHandleValid_In_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "IsHandleValid", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
				}
				return r_MIsHandleValid_In_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// System.String GetReaderName(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle, Int32)
		/// </summary>
		protected static RMethod r_MGetReaderName_AtomicSafetyHandle_Int32;
		public static RMethod RMGetReaderName_AtomicSafetyHandle_Int32
		{
			get
			{
				if(r_MGetReaderName_AtomicSafetyHandle_Int32 == null)
				{
					r_MGetReaderName_AtomicSafetyHandle_Int32 = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetReaderName", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), typeof(System.Int32));
				}
				return r_MGetReaderName_AtomicSafetyHandle_Int32;
			}
		}

		/// <summary>
		/// System.String GetWriterName(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_MGetWriterName_AtomicSafetyHandle;
		public static RMethod RMGetWriterName_AtomicSafetyHandle
		{
			get
			{
				if(r_MGetWriterName_AtomicSafetyHandle == null)
				{
					r_MGetWriterName_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetWriterName", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
				}
				return r_MGetWriterName_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Int32 NewStaticSafetyId(Byte*, Int32)
		/// </summary>
		protected static RMethod r_MNewStaticSafetyId_BytePointer_Int32;
		public static RMethod RMNewStaticSafetyId_BytePointer_Int32
		{
			get
			{
				if(r_MNewStaticSafetyId_BytePointer_Int32 == null)
				{
					r_MNewStaticSafetyId_BytePointer_Int32 = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "NewStaticSafetyId", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32));
				}
				return r_MNewStaticSafetyId_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Int32 NewStaticSafetyId[T]()
		/// </summary>
		protected static RMethod r_MNewStaticSafetyId_GT;
		public static RMethod RMNewStaticSafetyId_GT
		{
			get
			{
				if(r_MNewStaticSafetyId_GT == null)
				{
					r_MNewStaticSafetyId_GT = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "NewStaticSafetyId", 1);
				}
				return r_MNewStaticSafetyId_GT;
			}
		}

		/// <summary>
		/// Void SetCustomErrorMessage(Int32, Unity.Collections.LowLevel.Unsafe.AtomicSafetyErrorType, Byte*, Int32)
		/// </summary>
		protected static RMethod r_MSetCustomErrorMessage_Int32_AtomicSafetyErrorType_BytePointer_Int32;
		public static RMethod RMSetCustomErrorMessage_Int32_AtomicSafetyErrorType_BytePointer_Int32
		{
			get
			{
				if(r_MSetCustomErrorMessage_Int32_AtomicSafetyErrorType_BytePointer_Int32 == null)
				{
					r_MSetCustomErrorMessage_Int32_AtomicSafetyErrorType_BytePointer_Int32 = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "SetCustomErrorMessage", 0, typeof(System.Int32), typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyErrorType), typeof(System.Byte).MakePointerType(), typeof(System.Int32));
				}
				return r_MSetCustomErrorMessage_Int32_AtomicSafetyErrorType_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Void SetStaticSafetyId(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef, Int32)
		/// </summary>
		protected static RMethod r_MSetStaticSafetyId_Ref_AtomicSafetyHandle_Int32;
		public static RMethod RMSetStaticSafetyId_Ref_AtomicSafetyHandle_Int32
		{
			get
			{
				if(r_MSetStaticSafetyId_Ref_AtomicSafetyHandle_Int32 == null)
				{
					r_MSetStaticSafetyId_Ref_AtomicSafetyHandle_Int32 = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "SetStaticSafetyId", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType(), typeof(System.Int32));
				}
				return r_MSetStaticSafetyId_Ref_AtomicSafetyHandle_Int32;
			}
		}

		/// <summary>
		/// Void CreateHandle(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef, Unity.Collections.Allocator)
		/// </summary>
		protected static RMethod r_MCreateHandle_Out_AtomicSafetyHandle_Allocator;
		public static RMethod RMCreateHandle_Out_AtomicSafetyHandle_Allocator
		{
			get
			{
				if(r_MCreateHandle_Out_AtomicSafetyHandle_Allocator == null)
				{
					r_MCreateHandle_Out_AtomicSafetyHandle_Allocator = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "CreateHandle", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType(), typeof(Unity.Collections.Allocator));
				}
				return r_MCreateHandle_Out_AtomicSafetyHandle_Allocator;
			}
		}

		/// <summary>
		/// Void DisposeHandle(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_MDisposeHandle_Ref_AtomicSafetyHandle;
		public static RMethod RMDisposeHandle_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_MDisposeHandle_Ref_AtomicSafetyHandle == null)
				{
					r_MDisposeHandle_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "DisposeHandle", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
				}
				return r_MDisposeHandle_Ref_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void Create_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_MCreate_Injected_Out_AtomicSafetyHandle;
		public static RMethod RMCreate_Injected_Out_AtomicSafetyHandle
		{
			get
			{
				if(r_MCreate_Injected_Out_AtomicSafetyHandle == null)
				{
					r_MCreate_Injected_Out_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "Create_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
				}
				return r_MCreate_Injected_Out_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void GetTempUnsafePtrSliceHandle_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_MGetTempUnsafePtrSliceHandle_Injected_Out_AtomicSafetyHandle;
		public static RMethod RMGetTempUnsafePtrSliceHandle_Injected_Out_AtomicSafetyHandle
		{
			get
			{
				if(r_MGetTempUnsafePtrSliceHandle_Injected_Out_AtomicSafetyHandle == null)
				{
					r_MGetTempUnsafePtrSliceHandle_Injected_Out_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetTempUnsafePtrSliceHandle_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
				}
				return r_MGetTempUnsafePtrSliceHandle_Injected_Out_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void GetTempMemoryHandle_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_MGetTempMemoryHandle_Injected_Out_AtomicSafetyHandle;
		public static RMethod RMGetTempMemoryHandle_Injected_Out_AtomicSafetyHandle
		{
			get
			{
				if(r_MGetTempMemoryHandle_Injected_Out_AtomicSafetyHandle == null)
				{
					r_MGetTempMemoryHandle_Injected_Out_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetTempMemoryHandle_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
				}
				return r_MGetTempMemoryHandle_Injected_Out_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Boolean IsTempMemoryHandle_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_MIsTempMemoryHandle_Injected_Ref_AtomicSafetyHandle;
		public static RMethod RMIsTempMemoryHandle_Injected_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_MIsTempMemoryHandle_Injected_Ref_AtomicSafetyHandle == null)
				{
					r_MIsTempMemoryHandle_Injected_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "IsTempMemoryHandle_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
				}
				return r_MIsTempMemoryHandle_Injected_Ref_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void Release_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_MRelease_Injected_Ref_AtomicSafetyHandle;
		public static RMethod RMRelease_Injected_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_MRelease_Injected_Ref_AtomicSafetyHandle == null)
				{
					r_MRelease_Injected_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "Release_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
				}
				return r_MRelease_Injected_Ref_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void SetAllowSecondaryVersionWriting_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef, Boolean)
		/// </summary>
		protected static RMethod r_MSetAllowSecondaryVersionWriting_Injected_Ref_AtomicSafetyHandle_Boolean;
		public static RMethod RMSetAllowSecondaryVersionWriting_Injected_Ref_AtomicSafetyHandle_Boolean
		{
			get
			{
				if(r_MSetAllowSecondaryVersionWriting_Injected_Ref_AtomicSafetyHandle_Boolean == null)
				{
					r_MSetAllowSecondaryVersionWriting_Injected_Ref_AtomicSafetyHandle_Boolean = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "SetAllowSecondaryVersionWriting_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType(), typeof(System.Boolean));
				}
				return r_MSetAllowSecondaryVersionWriting_Injected_Ref_AtomicSafetyHandle_Boolean;
			}
		}

		/// <summary>
		/// Void SetBumpSecondaryVersionOnScheduleWrite_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef, Boolean)
		/// </summary>
		protected static RMethod r_MSetBumpSecondaryVersionOnScheduleWrite_Injected_Ref_AtomicSafetyHandle_Boolean;
		public static RMethod RMSetBumpSecondaryVersionOnScheduleWrite_Injected_Ref_AtomicSafetyHandle_Boolean
		{
			get
			{
				if(r_MSetBumpSecondaryVersionOnScheduleWrite_Injected_Ref_AtomicSafetyHandle_Boolean == null)
				{
					r_MSetBumpSecondaryVersionOnScheduleWrite_Injected_Ref_AtomicSafetyHandle_Boolean = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "SetBumpSecondaryVersionOnScheduleWrite_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType(), typeof(System.Boolean));
				}
				return r_MSetBumpSecondaryVersionOnScheduleWrite_Injected_Ref_AtomicSafetyHandle_Boolean;
			}
		}

		/// <summary>
		/// Void SetAllowReadOrWriteAccess_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef, Boolean)
		/// </summary>
		protected static RMethod r_MSetAllowReadOrWriteAccess_Injected_Ref_AtomicSafetyHandle_Boolean;
		public static RMethod RMSetAllowReadOrWriteAccess_Injected_Ref_AtomicSafetyHandle_Boolean
		{
			get
			{
				if(r_MSetAllowReadOrWriteAccess_Injected_Ref_AtomicSafetyHandle_Boolean == null)
				{
					r_MSetAllowReadOrWriteAccess_Injected_Ref_AtomicSafetyHandle_Boolean = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "SetAllowReadOrWriteAccess_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType(), typeof(System.Boolean));
				}
				return r_MSetAllowReadOrWriteAccess_Injected_Ref_AtomicSafetyHandle_Boolean;
			}
		}

		/// <summary>
		/// Boolean GetAllowReadOrWriteAccess_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_MGetAllowReadOrWriteAccess_Injected_Ref_AtomicSafetyHandle;
		public static RMethod RMGetAllowReadOrWriteAccess_Injected_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_MGetAllowReadOrWriteAccess_Injected_Ref_AtomicSafetyHandle == null)
				{
					r_MGetAllowReadOrWriteAccess_Injected_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetAllowReadOrWriteAccess_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
				}
				return r_MGetAllowReadOrWriteAccess_Injected_Ref_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void SetNestedContainer_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef, Boolean)
		/// </summary>
		protected static RMethod r_MSetNestedContainer_Injected_Ref_AtomicSafetyHandle_Boolean;
		public static RMethod RMSetNestedContainer_Injected_Ref_AtomicSafetyHandle_Boolean
		{
			get
			{
				if(r_MSetNestedContainer_Injected_Ref_AtomicSafetyHandle_Boolean == null)
				{
					r_MSetNestedContainer_Injected_Ref_AtomicSafetyHandle_Boolean = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "SetNestedContainer_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType(), typeof(System.Boolean));
				}
				return r_MSetNestedContainer_Injected_Ref_AtomicSafetyHandle_Boolean;
			}
		}

		/// <summary>
		/// Boolean GetNestedContainer_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_MGetNestedContainer_Injected_Ref_AtomicSafetyHandle;
		public static RMethod RMGetNestedContainer_Injected_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_MGetNestedContainer_Injected_Ref_AtomicSafetyHandle == null)
				{
					r_MGetNestedContainer_Injected_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetNestedContainer_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
				}
				return r_MGetNestedContainer_Injected_Ref_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void CheckWriteAndBumpSecondaryVersion_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_MCheckWriteAndBumpSecondaryVersion_Injected_Ref_AtomicSafetyHandle;
		public static RMethod RMCheckWriteAndBumpSecondaryVersion_Injected_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_MCheckWriteAndBumpSecondaryVersion_Injected_Ref_AtomicSafetyHandle == null)
				{
					r_MCheckWriteAndBumpSecondaryVersion_Injected_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "CheckWriteAndBumpSecondaryVersion_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
				}
				return r_MCheckWriteAndBumpSecondaryVersion_Injected_Ref_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.EnforceJobResult EnforceAllBufferJobsHaveCompleted_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_MEnforceAllBufferJobsHaveCompleted_Injected_Ref_AtomicSafetyHandle;
		public static RMethod RMEnforceAllBufferJobsHaveCompleted_Injected_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_MEnforceAllBufferJobsHaveCompleted_Injected_Ref_AtomicSafetyHandle == null)
				{
					r_MEnforceAllBufferJobsHaveCompleted_Injected_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "EnforceAllBufferJobsHaveCompleted_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
				}
				return r_MEnforceAllBufferJobsHaveCompleted_Injected_Ref_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.EnforceJobResult EnforceAllBufferJobsHaveCompletedAndRelease_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_MEnforceAllBufferJobsHaveCompletedAndRelease_Injected_Ref_AtomicSafetyHandle;
		public static RMethod RMEnforceAllBufferJobsHaveCompletedAndRelease_Injected_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_MEnforceAllBufferJobsHaveCompletedAndRelease_Injected_Ref_AtomicSafetyHandle == null)
				{
					r_MEnforceAllBufferJobsHaveCompletedAndRelease_Injected_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "EnforceAllBufferJobsHaveCompletedAndRelease_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
				}
				return r_MEnforceAllBufferJobsHaveCompletedAndRelease_Injected_Ref_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.EnforceJobResult EnforceAllBufferJobsHaveCompletedAndDisableReadWrite_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_MEnforceAllBufferJobsHaveCompletedAndDisableReadWrite_Injected_Ref_AtomicSafetyHandle;
		public static RMethod RMEnforceAllBufferJobsHaveCompletedAndDisableReadWrite_Injected_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_MEnforceAllBufferJobsHaveCompletedAndDisableReadWrite_Injected_Ref_AtomicSafetyHandle == null)
				{
					r_MEnforceAllBufferJobsHaveCompletedAndDisableReadWrite_Injected_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "EnforceAllBufferJobsHaveCompletedAndDisableReadWrite_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
				}
				return r_MEnforceAllBufferJobsHaveCompletedAndDisableReadWrite_Injected_Ref_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void CheckReadAndThrowNoEarlyOut_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_MCheckReadAndThrowNoEarlyOut_Injected_Ref_AtomicSafetyHandle;
		public static RMethod RMCheckReadAndThrowNoEarlyOut_Injected_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_MCheckReadAndThrowNoEarlyOut_Injected_Ref_AtomicSafetyHandle == null)
				{
					r_MCheckReadAndThrowNoEarlyOut_Injected_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "CheckReadAndThrowNoEarlyOut_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
				}
				return r_MCheckReadAndThrowNoEarlyOut_Injected_Ref_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void CheckWriteAndThrowNoEarlyOut_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_MCheckWriteAndThrowNoEarlyOut_Injected_Ref_AtomicSafetyHandle;
		public static RMethod RMCheckWriteAndThrowNoEarlyOut_Injected_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_MCheckWriteAndThrowNoEarlyOut_Injected_Ref_AtomicSafetyHandle == null)
				{
					r_MCheckWriteAndThrowNoEarlyOut_Injected_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "CheckWriteAndThrowNoEarlyOut_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
				}
				return r_MCheckWriteAndThrowNoEarlyOut_Injected_Ref_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void CheckDeallocateAndThrow_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_MCheckDeallocateAndThrow_Injected_Ref_AtomicSafetyHandle;
		public static RMethod RMCheckDeallocateAndThrow_Injected_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_MCheckDeallocateAndThrow_Injected_Ref_AtomicSafetyHandle == null)
				{
					r_MCheckDeallocateAndThrow_Injected_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "CheckDeallocateAndThrow_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
				}
				return r_MCheckDeallocateAndThrow_Injected_Ref_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void CheckGetSecondaryDataPointerAndThrow_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_MCheckGetSecondaryDataPointerAndThrow_Injected_Ref_AtomicSafetyHandle;
		public static RMethod RMCheckGetSecondaryDataPointerAndThrow_Injected_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_MCheckGetSecondaryDataPointerAndThrow_Injected_Ref_AtomicSafetyHandle == null)
				{
					r_MCheckGetSecondaryDataPointerAndThrow_Injected_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "CheckGetSecondaryDataPointerAndThrow_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
				}
				return r_MCheckGetSecondaryDataPointerAndThrow_Injected_Ref_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Int32 GetReaderArray_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef, Int32, IntPtr)
		/// </summary>
		protected static RMethod r_MGetReaderArray_Injected_Ref_AtomicSafetyHandle_Int32_IntPtr;
		public static RMethod RMGetReaderArray_Injected_Ref_AtomicSafetyHandle_Int32_IntPtr
		{
			get
			{
				if(r_MGetReaderArray_Injected_Ref_AtomicSafetyHandle_Int32_IntPtr == null)
				{
					r_MGetReaderArray_Injected_Ref_AtomicSafetyHandle_Int32_IntPtr = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetReaderArray_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType(), typeof(System.Int32), typeof(System.IntPtr));
				}
				return r_MGetReaderArray_Injected_Ref_AtomicSafetyHandle_Int32_IntPtr;
			}
		}

		/// <summary>
		/// Void GetWriter_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef, Unity.Jobs.JobHandle ByRef)
		/// </summary>
		protected static RMethod r_MGetWriter_Injected_Ref_AtomicSafetyHandle_Out_JobHandle;
		public static RMethod RMGetWriter_Injected_Ref_AtomicSafetyHandle_Out_JobHandle
		{
			get
			{
				if(r_MGetWriter_Injected_Ref_AtomicSafetyHandle_Out_JobHandle == null)
				{
					r_MGetWriter_Injected_Ref_AtomicSafetyHandle_Out_JobHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetWriter_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType(), typeof(Unity.Jobs.JobHandle).MakeByRefType());
				}
				return r_MGetWriter_Injected_Ref_AtomicSafetyHandle_Out_JobHandle;
			}
		}

		/// <summary>
		/// System.String GetReaderName_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef, Int32)
		/// </summary>
		protected static RMethod r_MGetReaderName_Injected_Ref_AtomicSafetyHandle_Int32;
		public static RMethod RMGetReaderName_Injected_Ref_AtomicSafetyHandle_Int32
		{
			get
			{
				if(r_MGetReaderName_Injected_Ref_AtomicSafetyHandle_Int32 == null)
				{
					r_MGetReaderName_Injected_Ref_AtomicSafetyHandle_Int32 = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetReaderName_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType(), typeof(System.Int32));
				}
				return r_MGetReaderName_Injected_Ref_AtomicSafetyHandle_Int32;
			}
		}

		/// <summary>
		/// System.String GetWriterName_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_MGetWriterName_Injected_Ref_AtomicSafetyHandle;
		public static RMethod RMGetWriterName_Injected_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_MGetWriterName_Injected_Ref_AtomicSafetyHandle == null)
				{
					r_MGetWriterName_Injected_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetWriterName_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
				}
				return r_MGetWriterName_Injected_Ref_AtomicSafetyHandle;
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


        public static Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle Create()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreate.Invoke(___genericsType, ___parameters);

            return (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___result;
        }


        public static Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetTempUnsafePtrSliceHandle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTempUnsafePtrSliceHandle.Invoke(___genericsType, ___parameters);

            return (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___result;
        }


        public static Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetTempMemoryHandle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTempMemoryHandle.Invoke(___genericsType, ___parameters);

            return (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___result;
        }


        public static System.Boolean IsTempMemoryHandle(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMIsTempMemoryHandle_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void Release(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMRelease_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsDefaultValue(in Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMIsDefaultValue_In_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void SetExclusiveWeak(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle, System.Boolean @enabled)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @enabled};
            var ___result = RMSetExclusiveWeak_Ref_AtomicSafetyHandle_Boolean.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static System.Boolean GetExclusiveWeak(in Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetExclusiveWeak_In_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void PrepareUndisposable(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMPrepareUndisposable_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static void UseSecondaryVersion(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMUseSecondaryVersion_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static void SetAllowSecondaryVersionWriting(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle, System.Boolean @allowWriting)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @allowWriting};
            var ___result = RMSetAllowSecondaryVersionWriting_AtomicSafetyHandle_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetBumpSecondaryVersionOnScheduleWrite(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @value};
            var ___result = RMSetBumpSecondaryVersionOnScheduleWrite_AtomicSafetyHandle_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetAllowReadOrWriteAccess(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle, System.Boolean @allowReadWriteAccess)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @allowReadWriteAccess};
            var ___result = RMSetAllowReadOrWriteAccess_AtomicSafetyHandle_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean GetAllowReadOrWriteAccess(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetAllowReadOrWriteAccess_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void SetNestedContainer(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle, System.Boolean @isNestedContainer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @isNestedContainer};
            var ___result = RMSetNestedContainer_AtomicSafetyHandle_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean GetNestedContainer(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetNestedContainer_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void CheckWriteAndBumpSecondaryVersion(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMCheckWriteAndBumpSecondaryVersion_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            
        }


        public static Unity.Collections.LowLevel.Unsafe.EnforceJobResult EnforceAllBufferJobsHaveCompleted(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMEnforceAllBufferJobsHaveCompleted_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            return (Unity.Collections.LowLevel.Unsafe.EnforceJobResult)___result;
        }


        public static Unity.Collections.LowLevel.Unsafe.EnforceJobResult EnforceAllBufferJobsHaveCompletedAndRelease(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMEnforceAllBufferJobsHaveCompletedAndRelease_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            return (Unity.Collections.LowLevel.Unsafe.EnforceJobResult)___result;
        }


        public static Unity.Collections.LowLevel.Unsafe.EnforceJobResult EnforceAllBufferJobsHaveCompletedAndDisableReadWrite(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMEnforceAllBufferJobsHaveCompletedAndDisableReadWrite_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            return (Unity.Collections.LowLevel.Unsafe.EnforceJobResult)___result;
        }


        public static void CheckReadAndThrowNoEarlyOut(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMCheckReadAndThrowNoEarlyOut_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            
        }


        public static void CheckWriteAndThrowNoEarlyOut(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMCheckWriteAndThrowNoEarlyOut_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            
        }


        public static void CheckDeallocateAndThrow(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMCheckDeallocateAndThrow_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            
        }


        public static void CheckGetSecondaryDataPointerAndThrow(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMCheckGetSecondaryDataPointerAndThrow_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 GetReaderArray(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle, System.Int32 @maxCount, System.IntPtr @output)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @maxCount, @output};
            var ___result = RMGetReaderArray_AtomicSafetyHandle_Int32_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static Unity.Jobs.JobHandle GetWriter(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetWriter_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            return (Unity.Jobs.JobHandle)___result;
        }


        public static void CheckReadAndThrow(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMCheckReadAndThrow_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            
        }


        public static void CheckWriteAndThrow(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMCheckWriteAndThrow_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            
        }


        public static void ValidateNonDefaultHandle(in Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMValidateNonDefaultHandle_In_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsValidNonDefaultHandle(in Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMIsValidNonDefaultHandle_In_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void CheckExistsAndThrow(in Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMCheckExistsAndThrow_In_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsHandleValid(in Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMIsHandleValid_In_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.String GetReaderName(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle, System.Int32 @readerIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @readerIndex};
            var ___result = RMGetReaderName_AtomicSafetyHandle_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String GetWriterName(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetWriterName_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public unsafe static System.Int32 NewStaticSafetyId(System.Byte* @ownerTypeNameBytes, System.Int32 @byteCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@ownerTypeNameBytes, typeof(System.Byte)), @byteCount};
            var ___result = RMNewStaticSafetyId_BytePointer_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 NewStaticSafetyId<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMNewStaticSafetyId_GT.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe static void SetCustomErrorMessage(System.Int32 @staticSafetyId, Unity.Collections.LowLevel.Unsafe.AtomicSafetyErrorType @errorType, System.Byte* @messageBytes, System.Int32 @byteCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@staticSafetyId, @errorType, Pointer.Box(@messageBytes, typeof(System.Byte)), @byteCount};
            var ___result = RMSetCustomErrorMessage_Int32_AtomicSafetyErrorType_BytePointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetStaticSafetyId(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle, System.Int32 @staticSafetyId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @staticSafetyId};
            var ___result = RMSetStaticSafetyId_Ref_AtomicSafetyHandle_Int32.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static void CreateHandle(out Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @safety, Unity.Collections.Allocator @allocator)
        {
			@safety = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@safety, @allocator};
            var ___result = RMCreateHandle_Out_AtomicSafetyHandle_Allocator.Invoke(___genericsType, ___parameters);
			@safety = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static void DisposeHandle(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @safety)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@safety};
            var ___result = RMDisposeHandle_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			@safety = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static void Create_Injected(out Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMCreate_Injected_Out_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			@ret = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static void GetTempUnsafePtrSliceHandle_Injected(out Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMGetTempUnsafePtrSliceHandle_Injected_Out_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			@ret = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static void GetTempMemoryHandle_Injected(out Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMGetTempMemoryHandle_Injected_Out_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			@ret = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static System.Boolean IsTempMemoryHandle_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMIsTempMemoryHandle_Injected_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            return (System.Boolean)___result;
        }


        public static void Release_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMRelease_Injected_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static void SetAllowSecondaryVersionWriting_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle, System.Boolean @allowWriting)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @allowWriting};
            var ___result = RMSetAllowSecondaryVersionWriting_Injected_Ref_AtomicSafetyHandle_Boolean.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static void SetBumpSecondaryVersionOnScheduleWrite_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @value};
            var ___result = RMSetBumpSecondaryVersionOnScheduleWrite_Injected_Ref_AtomicSafetyHandle_Boolean.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static void SetAllowReadOrWriteAccess_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle, System.Boolean @allowReadWriteAccess)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @allowReadWriteAccess};
            var ___result = RMSetAllowReadOrWriteAccess_Injected_Ref_AtomicSafetyHandle_Boolean.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static System.Boolean GetAllowReadOrWriteAccess_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetAllowReadOrWriteAccess_Injected_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            return (System.Boolean)___result;
        }


        public static void SetNestedContainer_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle, System.Boolean @isNestedContainer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @isNestedContainer};
            var ___result = RMSetNestedContainer_Injected_Ref_AtomicSafetyHandle_Boolean.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static System.Boolean GetNestedContainer_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetNestedContainer_Injected_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            return (System.Boolean)___result;
        }


        public static void CheckWriteAndBumpSecondaryVersion_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMCheckWriteAndBumpSecondaryVersion_Injected_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static Unity.Collections.LowLevel.Unsafe.EnforceJobResult EnforceAllBufferJobsHaveCompleted_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMEnforceAllBufferJobsHaveCompleted_Injected_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            return (Unity.Collections.LowLevel.Unsafe.EnforceJobResult)___result;
        }


        public static Unity.Collections.LowLevel.Unsafe.EnforceJobResult EnforceAllBufferJobsHaveCompletedAndRelease_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMEnforceAllBufferJobsHaveCompletedAndRelease_Injected_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            return (Unity.Collections.LowLevel.Unsafe.EnforceJobResult)___result;
        }


        public static Unity.Collections.LowLevel.Unsafe.EnforceJobResult EnforceAllBufferJobsHaveCompletedAndDisableReadWrite_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMEnforceAllBufferJobsHaveCompletedAndDisableReadWrite_Injected_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            return (Unity.Collections.LowLevel.Unsafe.EnforceJobResult)___result;
        }


        public static void CheckReadAndThrowNoEarlyOut_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMCheckReadAndThrowNoEarlyOut_Injected_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static void CheckWriteAndThrowNoEarlyOut_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMCheckWriteAndThrowNoEarlyOut_Injected_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static void CheckDeallocateAndThrow_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMCheckDeallocateAndThrow_Injected_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static void CheckGetSecondaryDataPointerAndThrow_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMCheckGetSecondaryDataPointerAndThrow_Injected_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static System.Int32 GetReaderArray_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle, System.Int32 @maxCount, System.IntPtr @output)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @maxCount, @output};
            var ___result = RMGetReaderArray_Injected_Ref_AtomicSafetyHandle_Int32_IntPtr.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            return (System.Int32)___result;
        }


        public static void GetWriter_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle, out Unity.Jobs.JobHandle @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @ret};
            var ___result = RMGetWriter_Injected_Ref_AtomicSafetyHandle_Out_JobHandle.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];
			@ret = (Unity.Jobs.JobHandle)___parameters[1];

            
        }


        public static System.String GetReaderName_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle, System.Int32 @readerIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @readerIndex};
            var ___result = RMGetReaderName_Injected_Ref_AtomicSafetyHandle_Int32.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            return (System.String)___result;
        }


        public static System.String GetWriterName_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetWriterName_Injected_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            return (System.String)___result;
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
