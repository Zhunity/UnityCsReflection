using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnity.RCollections.RLowLevel.RUnsafe
{
	/// <summary>
	/// Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle
	/// </summary>
    public partial class RAtomicSafetyHandle : RMember //
    {

		/// <summary>
		/// System.Int32 Read
		/// </summary>
		protected static RField r_Read;
		public static RField Read
		{
			get
			{
				if(r_Read == null)
				{
					r_Read = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "Read");
					r_Read.SetBelong(null);
				}
				return r_Read;
			}
		}

		/// <summary>
		/// System.Int32 Write
		/// </summary>
		protected static RField r_Write;
		public static RField RWrite
		{
			get
			{
				if(r_Write == null)
				{
					r_Write = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "Write");
					r_Write.SetBelong(null);
				}
				return r_Write;
			}
		}

		/// <summary>
		/// System.Int32 Dispose
		/// </summary>
		protected static RField r_Dispose;
		public static RField RDispose
		{
			get
			{
				if(r_Dispose == null)
				{
					r_Dispose = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "Dispose");
					r_Dispose.SetBelong(null);
				}
				return r_Dispose;
			}
		}

		/// <summary>
		/// System.Int32 ReadCheck
		/// </summary>
		protected static RField r_ReadCheck;
		public static RField ReadCheck
		{
			get
			{
				if(r_ReadCheck == null)
				{
					r_ReadCheck = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "ReadCheck");
					r_ReadCheck.SetBelong(null);
				}
				return r_ReadCheck;
			}
		}

		/// <summary>
		/// System.Int32 WriteCheck
		/// </summary>
		protected static RField r_WriteCheck;
		public static RField RWriteCheck
		{
			get
			{
				if(r_WriteCheck == null)
				{
					r_WriteCheck = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "WriteCheck");
					r_WriteCheck.SetBelong(null);
				}
				return r_WriteCheck;
			}
		}

		/// <summary>
		/// System.Int32 DisposeCheck
		/// </summary>
		protected static RField r_DisposeCheck;
		public static RField RDisposeCheck
		{
			get
			{
				if(r_DisposeCheck == null)
				{
					r_DisposeCheck = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "DisposeCheck");
					r_DisposeCheck.SetBelong(null);
				}
				return r_DisposeCheck;
			}
		}

		/// <summary>
		/// System.Int32 ReadWriteDisposeCheck
		/// </summary>
		protected static RField r_ReadWriteDisposeCheck;
		public static RField ReadWriteDisposeCheck
		{
			get
			{
				if(r_ReadWriteDisposeCheck == null)
				{
					r_ReadWriteDisposeCheck = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "ReadWriteDisposeCheck");
					r_ReadWriteDisposeCheck.SetBelong(null);
				}
				return r_ReadWriteDisposeCheck;
			}
		}

		/// <summary>
		/// System.IntPtr versionNode
		/// </summary>
		protected RField r_versionNode;
		public virtual RField RversionNode
		{
			get
			{
				if(r_versionNode == null)
				{
					r_versionNode = new(this, "versionNode");
					r_versionNode.SetBelong(this.instance);
				}
				return r_versionNode;
			}
		}

		/// <summary>
		/// System.Int32 version
		/// </summary>
		protected RField r_version;
		public virtual RField Rversion
		{
			get
			{
				if(r_version == null)
				{
					r_version = new(this, "version");
					r_version.SetBelong(this.instance);
				}
				return r_version;
			}
		}

		/// <summary>
		/// System.Int32 staticSafetyId
		/// </summary>
		protected RField r_staticSafetyId;
		public virtual RField RstaticSafetyId
		{
			get
			{
				if(r_staticSafetyId == null)
				{
					r_staticSafetyId = new(this, "staticSafetyId");
					r_staticSafetyId.SetBelong(this.instance);
				}
				return r_staticSafetyId;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle Create()
		/// </summary>
		protected static RMethod r_RCreate;
		public static RMethod RCreate
		{
			get
			{
				if(r_RCreate == null)
				{
					r_RCreate = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "Create", 0);
					r_RCreate.SetBelong(null);
				}
				return r_RCreate;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetTempUnsafePtrSliceHandle()
		/// </summary>
		protected static RMethod r_RGetTempUnsafePtrSliceHandle;
		public static RMethod RGetTempUnsafePtrSliceHandle
		{
			get
			{
				if(r_RGetTempUnsafePtrSliceHandle == null)
				{
					r_RGetTempUnsafePtrSliceHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetTempUnsafePtrSliceHandle", 0);
					r_RGetTempUnsafePtrSliceHandle.SetBelong(null);
				}
				return r_RGetTempUnsafePtrSliceHandle;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetTempMemoryHandle()
		/// </summary>
		protected static RMethod r_RGetTempMemoryHandle;
		public static RMethod RGetTempMemoryHandle
		{
			get
			{
				if(r_RGetTempMemoryHandle == null)
				{
					r_RGetTempMemoryHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetTempMemoryHandle", 0);
					r_RGetTempMemoryHandle.SetBelong(null);
				}
				return r_RGetTempMemoryHandle;
			}
		}

		/// <summary>
		/// Boolean IsTempMemoryHandle(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_RIsTempMemoryHandle_AtomicSafetyHandle;
		public static RMethod RIsTempMemoryHandle_AtomicSafetyHandle
		{
			get
			{
				if(r_RIsTempMemoryHandle_AtomicSafetyHandle == null)
				{
					r_RIsTempMemoryHandle_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "IsTempMemoryHandle", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
					r_RIsTempMemoryHandle_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RIsTempMemoryHandle_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void Release(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_RRelease_AtomicSafetyHandle;
		public static RMethod RRelease_AtomicSafetyHandle
		{
			get
			{
				if(r_RRelease_AtomicSafetyHandle == null)
				{
					r_RRelease_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "Release", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
					r_RRelease_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RRelease_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Boolean IsDefaultValue(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_RIsDefaultValue_In_AtomicSafetyHandle;
		public static RMethod RIsDefaultValue_In_AtomicSafetyHandle
		{
			get
			{
				if(r_RIsDefaultValue_In_AtomicSafetyHandle == null)
				{
					r_RIsDefaultValue_In_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "IsDefaultValue", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_RIsDefaultValue_In_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RIsDefaultValue_In_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void SetExclusiveWeak(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef, Boolean)
		/// </summary>
		protected static RMethod r_RSetExclusiveWeak_Ref_AtomicSafetyHandle_Boolean;
		public static RMethod RSetExclusiveWeak_Ref_AtomicSafetyHandle_Boolean
		{
			get
			{
				if(r_RSetExclusiveWeak_Ref_AtomicSafetyHandle_Boolean == null)
				{
					r_RSetExclusiveWeak_Ref_AtomicSafetyHandle_Boolean = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "SetExclusiveWeak", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType(), typeof(System.Boolean));
					r_RSetExclusiveWeak_Ref_AtomicSafetyHandle_Boolean.SetBelong(null);
				}
				return r_RSetExclusiveWeak_Ref_AtomicSafetyHandle_Boolean;
			}
		}

		/// <summary>
		/// Boolean GetExclusiveWeak(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_RGetExclusiveWeak_In_AtomicSafetyHandle;
		public static RMethod RGetExclusiveWeak_In_AtomicSafetyHandle
		{
			get
			{
				if(r_RGetExclusiveWeak_In_AtomicSafetyHandle == null)
				{
					r_RGetExclusiveWeak_In_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetExclusiveWeak", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_RGetExclusiveWeak_In_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RGetExclusiveWeak_In_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void PrepareUndisposable(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_RPrepareUndisposable_Ref_AtomicSafetyHandle;
		public static RMethod RPrepareUndisposable_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_RPrepareUndisposable_Ref_AtomicSafetyHandle == null)
				{
					r_RPrepareUndisposable_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "PrepareUndisposable", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_RPrepareUndisposable_Ref_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RPrepareUndisposable_Ref_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void UseSecondaryVersion(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_RUseSecondaryVersion_Ref_AtomicSafetyHandle;
		public static RMethod RUseSecondaryVersion_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_RUseSecondaryVersion_Ref_AtomicSafetyHandle == null)
				{
					r_RUseSecondaryVersion_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "UseSecondaryVersion", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_RUseSecondaryVersion_Ref_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RUseSecondaryVersion_Ref_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void SetAllowSecondaryVersionWriting(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle, Boolean)
		/// </summary>
		protected static RMethod r_RSetAllowSecondaryVersionWriting_AtomicSafetyHandle_Boolean;
		public static RMethod RSetAllowSecondaryVersionWriting_AtomicSafetyHandle_Boolean
		{
			get
			{
				if(r_RSetAllowSecondaryVersionWriting_AtomicSafetyHandle_Boolean == null)
				{
					r_RSetAllowSecondaryVersionWriting_AtomicSafetyHandle_Boolean = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "SetAllowSecondaryVersionWriting", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), typeof(System.Boolean));
					r_RSetAllowSecondaryVersionWriting_AtomicSafetyHandle_Boolean.SetBelong(null);
				}
				return r_RSetAllowSecondaryVersionWriting_AtomicSafetyHandle_Boolean;
			}
		}

		/// <summary>
		/// Void SetBumpSecondaryVersionOnScheduleWrite(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle, Boolean)
		/// </summary>
		protected static RMethod r_RSetBumpSecondaryVersionOnScheduleWrite_AtomicSafetyHandle_Boolean;
		public static RMethod RSetBumpSecondaryVersionOnScheduleWrite_AtomicSafetyHandle_Boolean
		{
			get
			{
				if(r_RSetBumpSecondaryVersionOnScheduleWrite_AtomicSafetyHandle_Boolean == null)
				{
					r_RSetBumpSecondaryVersionOnScheduleWrite_AtomicSafetyHandle_Boolean = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "SetBumpSecondaryVersionOnScheduleWrite", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), typeof(System.Boolean));
					r_RSetBumpSecondaryVersionOnScheduleWrite_AtomicSafetyHandle_Boolean.SetBelong(null);
				}
				return r_RSetBumpSecondaryVersionOnScheduleWrite_AtomicSafetyHandle_Boolean;
			}
		}

		/// <summary>
		/// Void SetAllowReadOrWriteAccess(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle, Boolean)
		/// </summary>
		protected static RMethod r_RSetAllowReadOrWriteAccess_AtomicSafetyHandle_Boolean;
		public static RMethod RSetAllowReadOrWriteAccess_AtomicSafetyHandle_Boolean
		{
			get
			{
				if(r_RSetAllowReadOrWriteAccess_AtomicSafetyHandle_Boolean == null)
				{
					r_RSetAllowReadOrWriteAccess_AtomicSafetyHandle_Boolean = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "SetAllowReadOrWriteAccess", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), typeof(System.Boolean));
					r_RSetAllowReadOrWriteAccess_AtomicSafetyHandle_Boolean.SetBelong(null);
				}
				return r_RSetAllowReadOrWriteAccess_AtomicSafetyHandle_Boolean;
			}
		}

		/// <summary>
		/// Boolean GetAllowReadOrWriteAccess(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_RGetAllowReadOrWriteAccess_AtomicSafetyHandle;
		public static RMethod RGetAllowReadOrWriteAccess_AtomicSafetyHandle
		{
			get
			{
				if(r_RGetAllowReadOrWriteAccess_AtomicSafetyHandle == null)
				{
					r_RGetAllowReadOrWriteAccess_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetAllowReadOrWriteAccess", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
					r_RGetAllowReadOrWriteAccess_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RGetAllowReadOrWriteAccess_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void SetNestedContainer(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle, Boolean)
		/// </summary>
		protected static RMethod r_RSetNestedContainer_AtomicSafetyHandle_Boolean;
		public static RMethod RSetNestedContainer_AtomicSafetyHandle_Boolean
		{
			get
			{
				if(r_RSetNestedContainer_AtomicSafetyHandle_Boolean == null)
				{
					r_RSetNestedContainer_AtomicSafetyHandle_Boolean = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "SetNestedContainer", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), typeof(System.Boolean));
					r_RSetNestedContainer_AtomicSafetyHandle_Boolean.SetBelong(null);
				}
				return r_RSetNestedContainer_AtomicSafetyHandle_Boolean;
			}
		}

		/// <summary>
		/// Boolean GetNestedContainer(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_RGetNestedContainer_AtomicSafetyHandle;
		public static RMethod RGetNestedContainer_AtomicSafetyHandle
		{
			get
			{
				if(r_RGetNestedContainer_AtomicSafetyHandle == null)
				{
					r_RGetNestedContainer_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetNestedContainer", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
					r_RGetNestedContainer_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RGetNestedContainer_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void CheckWriteAndBumpSecondaryVersion(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_RCheckWriteAndBumpSecondaryVersion_AtomicSafetyHandle;
		public static RMethod RCheckWriteAndBumpSecondaryVersion_AtomicSafetyHandle
		{
			get
			{
				if(r_RCheckWriteAndBumpSecondaryVersion_AtomicSafetyHandle == null)
				{
					r_RCheckWriteAndBumpSecondaryVersion_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "CheckWriteAndBumpSecondaryVersion", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
					r_RCheckWriteAndBumpSecondaryVersion_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RCheckWriteAndBumpSecondaryVersion_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.EnforceJobResult EnforceAllBufferJobsHaveCompleted(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_REnforceAllBufferJobsHaveCompleted_AtomicSafetyHandle;
		public static RMethod REnforceAllBufferJobsHaveCompleted_AtomicSafetyHandle
		{
			get
			{
				if(r_REnforceAllBufferJobsHaveCompleted_AtomicSafetyHandle == null)
				{
					r_REnforceAllBufferJobsHaveCompleted_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "EnforceAllBufferJobsHaveCompleted", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
					r_REnforceAllBufferJobsHaveCompleted_AtomicSafetyHandle.SetBelong(null);
				}
				return r_REnforceAllBufferJobsHaveCompleted_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.EnforceJobResult EnforceAllBufferJobsHaveCompletedAndRelease(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_REnforceAllBufferJobsHaveCompletedAndRelease_AtomicSafetyHandle;
		public static RMethod REnforceAllBufferJobsHaveCompletedAndRelease_AtomicSafetyHandle
		{
			get
			{
				if(r_REnforceAllBufferJobsHaveCompletedAndRelease_AtomicSafetyHandle == null)
				{
					r_REnforceAllBufferJobsHaveCompletedAndRelease_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "EnforceAllBufferJobsHaveCompletedAndRelease", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
					r_REnforceAllBufferJobsHaveCompletedAndRelease_AtomicSafetyHandle.SetBelong(null);
				}
				return r_REnforceAllBufferJobsHaveCompletedAndRelease_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.EnforceJobResult EnforceAllBufferJobsHaveCompletedAndDisableReadWrite(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_REnforceAllBufferJobsHaveCompletedAndDisableReadWrite_AtomicSafetyHandle;
		public static RMethod REnforceAllBufferJobsHaveCompletedAndDisableReadWrite_AtomicSafetyHandle
		{
			get
			{
				if(r_REnforceAllBufferJobsHaveCompletedAndDisableReadWrite_AtomicSafetyHandle == null)
				{
					r_REnforceAllBufferJobsHaveCompletedAndDisableReadWrite_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "EnforceAllBufferJobsHaveCompletedAndDisableReadWrite", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
					r_REnforceAllBufferJobsHaveCompletedAndDisableReadWrite_AtomicSafetyHandle.SetBelong(null);
				}
				return r_REnforceAllBufferJobsHaveCompletedAndDisableReadWrite_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void CheckReadAndThrowNoEarlyOut(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_RCheckReadAndThrowNoEarlyOut_AtomicSafetyHandle;
		public static RMethod RCheckReadAndThrowNoEarlyOut_AtomicSafetyHandle
		{
			get
			{
				if(r_RCheckReadAndThrowNoEarlyOut_AtomicSafetyHandle == null)
				{
					r_RCheckReadAndThrowNoEarlyOut_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "CheckReadAndThrowNoEarlyOut", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
					r_RCheckReadAndThrowNoEarlyOut_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RCheckReadAndThrowNoEarlyOut_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void CheckWriteAndThrowNoEarlyOut(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_RCheckWriteAndThrowNoEarlyOut_AtomicSafetyHandle;
		public static RMethod RCheckWriteAndThrowNoEarlyOut_AtomicSafetyHandle
		{
			get
			{
				if(r_RCheckWriteAndThrowNoEarlyOut_AtomicSafetyHandle == null)
				{
					r_RCheckWriteAndThrowNoEarlyOut_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "CheckWriteAndThrowNoEarlyOut", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
					r_RCheckWriteAndThrowNoEarlyOut_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RCheckWriteAndThrowNoEarlyOut_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void CheckDeallocateAndThrow(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_RCheckDeallocateAndThrow_AtomicSafetyHandle;
		public static RMethod RCheckDeallocateAndThrow_AtomicSafetyHandle
		{
			get
			{
				if(r_RCheckDeallocateAndThrow_AtomicSafetyHandle == null)
				{
					r_RCheckDeallocateAndThrow_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "CheckDeallocateAndThrow", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
					r_RCheckDeallocateAndThrow_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RCheckDeallocateAndThrow_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void CheckGetSecondaryDataPointerAndThrow(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_RCheckGetSecondaryDataPointerAndThrow_AtomicSafetyHandle;
		public static RMethod RCheckGetSecondaryDataPointerAndThrow_AtomicSafetyHandle
		{
			get
			{
				if(r_RCheckGetSecondaryDataPointerAndThrow_AtomicSafetyHandle == null)
				{
					r_RCheckGetSecondaryDataPointerAndThrow_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "CheckGetSecondaryDataPointerAndThrow", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
					r_RCheckGetSecondaryDataPointerAndThrow_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RCheckGetSecondaryDataPointerAndThrow_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Int32 GetReaderArray(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle, Int32, IntPtr)
		/// </summary>
		protected static RMethod r_RGetReaderArray_AtomicSafetyHandle_Int32_IntPtr;
		public static RMethod RGetReaderArray_AtomicSafetyHandle_Int32_IntPtr
		{
			get
			{
				if(r_RGetReaderArray_AtomicSafetyHandle_Int32_IntPtr == null)
				{
					r_RGetReaderArray_AtomicSafetyHandle_Int32_IntPtr = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetReaderArray", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), typeof(System.Int32), typeof(System.IntPtr));
					r_RGetReaderArray_AtomicSafetyHandle_Int32_IntPtr.SetBelong(null);
				}
				return r_RGetReaderArray_AtomicSafetyHandle_Int32_IntPtr;
			}
		}

		/// <summary>
		/// Unity.Jobs.JobHandle GetWriter(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_RGetWriter_AtomicSafetyHandle;
		public static RMethod RGetWriter_AtomicSafetyHandle
		{
			get
			{
				if(r_RGetWriter_AtomicSafetyHandle == null)
				{
					r_RGetWriter_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetWriter", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
					r_RGetWriter_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RGetWriter_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void CheckReadAndThrow(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_RCheckReadAndThrow_AtomicSafetyHandle;
		public static RMethod RCheckReadAndThrow_AtomicSafetyHandle
		{
			get
			{
				if(r_RCheckReadAndThrow_AtomicSafetyHandle == null)
				{
					r_RCheckReadAndThrow_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "CheckReadAndThrow", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
					r_RCheckReadAndThrow_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RCheckReadAndThrow_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void CheckWriteAndThrow(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_RCheckWriteAndThrow_AtomicSafetyHandle;
		public static RMethod RCheckWriteAndThrow_AtomicSafetyHandle
		{
			get
			{
				if(r_RCheckWriteAndThrow_AtomicSafetyHandle == null)
				{
					r_RCheckWriteAndThrow_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "CheckWriteAndThrow", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
					r_RCheckWriteAndThrow_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RCheckWriteAndThrow_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void ValidateNonDefaultHandle(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_RValidateNonDefaultHandle_In_AtomicSafetyHandle;
		public static RMethod RValidateNonDefaultHandle_In_AtomicSafetyHandle
		{
			get
			{
				if(r_RValidateNonDefaultHandle_In_AtomicSafetyHandle == null)
				{
					r_RValidateNonDefaultHandle_In_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "ValidateNonDefaultHandle", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_RValidateNonDefaultHandle_In_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RValidateNonDefaultHandle_In_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Boolean IsValidNonDefaultHandle(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_RIsValidNonDefaultHandle_In_AtomicSafetyHandle;
		public static RMethod RIsValidNonDefaultHandle_In_AtomicSafetyHandle
		{
			get
			{
				if(r_RIsValidNonDefaultHandle_In_AtomicSafetyHandle == null)
				{
					r_RIsValidNonDefaultHandle_In_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "IsValidNonDefaultHandle", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_RIsValidNonDefaultHandle_In_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RIsValidNonDefaultHandle_In_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void CheckExistsAndThrow(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_RCheckExistsAndThrow_In_AtomicSafetyHandle;
		public static RMethod RCheckExistsAndThrow_In_AtomicSafetyHandle
		{
			get
			{
				if(r_RCheckExistsAndThrow_In_AtomicSafetyHandle == null)
				{
					r_RCheckExistsAndThrow_In_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "CheckExistsAndThrow", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_RCheckExistsAndThrow_In_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RCheckExistsAndThrow_In_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Boolean IsHandleValid(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_RIsHandleValid_In_AtomicSafetyHandle;
		public static RMethod RIsHandleValid_In_AtomicSafetyHandle
		{
			get
			{
				if(r_RIsHandleValid_In_AtomicSafetyHandle == null)
				{
					r_RIsHandleValid_In_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "IsHandleValid", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_RIsHandleValid_In_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RIsHandleValid_In_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// System.String GetReaderName(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle, Int32)
		/// </summary>
		protected static RMethod r_RGetReaderName_AtomicSafetyHandle_Int32;
		public static RMethod RGetReaderName_AtomicSafetyHandle_Int32
		{
			get
			{
				if(r_RGetReaderName_AtomicSafetyHandle_Int32 == null)
				{
					r_RGetReaderName_AtomicSafetyHandle_Int32 = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetReaderName", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), typeof(System.Int32));
					r_RGetReaderName_AtomicSafetyHandle_Int32.SetBelong(null);
				}
				return r_RGetReaderName_AtomicSafetyHandle_Int32;
			}
		}

		/// <summary>
		/// System.String GetWriterName(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)
		/// </summary>
		protected static RMethod r_RGetWriterName_AtomicSafetyHandle;
		public static RMethod RGetWriterName_AtomicSafetyHandle
		{
			get
			{
				if(r_RGetWriterName_AtomicSafetyHandle == null)
				{
					r_RGetWriterName_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetWriterName", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle));
					r_RGetWriterName_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RGetWriterName_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Int32 NewStaticSafetyId(Byte*, Int32)
		/// </summary>
		protected static RMethod r_RNewStaticSafetyId_BytePointer_Int32;
		public static RMethod RNewStaticSafetyId_BytePointer_Int32
		{
			get
			{
				if(r_RNewStaticSafetyId_BytePointer_Int32 == null)
				{
					r_RNewStaticSafetyId_BytePointer_Int32 = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "NewStaticSafetyId", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_RNewStaticSafetyId_BytePointer_Int32.SetBelong(null);
				}
				return r_RNewStaticSafetyId_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Int32 NewStaticSafetyId[T]()
		/// </summary>
		protected static RMethod r_RNewStaticSafetyId_GT;
		public static RMethod RNewStaticSafetyId_GT
		{
			get
			{
				if(r_RNewStaticSafetyId_GT == null)
				{
					r_RNewStaticSafetyId_GT = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "NewStaticSafetyId", 1);
					r_RNewStaticSafetyId_GT.SetBelong(null);
				}
				return r_RNewStaticSafetyId_GT;
			}
		}

		/// <summary>
		/// Void SetCustomErrorMessage(Int32, Unity.Collections.LowLevel.Unsafe.AtomicSafetyErrorType, Byte*, Int32)
		/// </summary>
		protected static RMethod r_RSetCustomErrorMessage_Int32_AtomicSafetyErrorType_BytePointer_Int32;
		public static RMethod RSetCustomErrorMessage_Int32_AtomicSafetyErrorType_BytePointer_Int32
		{
			get
			{
				if(r_RSetCustomErrorMessage_Int32_AtomicSafetyErrorType_BytePointer_Int32 == null)
				{
					r_RSetCustomErrorMessage_Int32_AtomicSafetyErrorType_BytePointer_Int32 = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "SetCustomErrorMessage", 0, typeof(System.Int32), typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyErrorType), typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_RSetCustomErrorMessage_Int32_AtomicSafetyErrorType_BytePointer_Int32.SetBelong(null);
				}
				return r_RSetCustomErrorMessage_Int32_AtomicSafetyErrorType_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Void SetStaticSafetyId(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef, Int32)
		/// </summary>
		protected static RMethod r_RSetStaticSafetyId_Ref_AtomicSafetyHandle_Int32;
		public static RMethod RSetStaticSafetyId_Ref_AtomicSafetyHandle_Int32
		{
			get
			{
				if(r_RSetStaticSafetyId_Ref_AtomicSafetyHandle_Int32 == null)
				{
					r_RSetStaticSafetyId_Ref_AtomicSafetyHandle_Int32 = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "SetStaticSafetyId", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType(), typeof(System.Int32));
					r_RSetStaticSafetyId_Ref_AtomicSafetyHandle_Int32.SetBelong(null);
				}
				return r_RSetStaticSafetyId_Ref_AtomicSafetyHandle_Int32;
			}
		}

		/// <summary>
		/// Void CreateHandle(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef, Unity.Collections.Allocator)
		/// </summary>
		protected static RMethod r_RCreateHandle_Out_AtomicSafetyHandle_Allocator;
		public static RMethod RCreateHandle_Out_AtomicSafetyHandle_Allocator
		{
			get
			{
				if(r_RCreateHandle_Out_AtomicSafetyHandle_Allocator == null)
				{
					r_RCreateHandle_Out_AtomicSafetyHandle_Allocator = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "CreateHandle", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType(), typeof(Unity.Collections.Allocator));
					r_RCreateHandle_Out_AtomicSafetyHandle_Allocator.SetBelong(null);
				}
				return r_RCreateHandle_Out_AtomicSafetyHandle_Allocator;
			}
		}

		/// <summary>
		/// Void DisposeHandle(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_RDisposeHandle_Ref_AtomicSafetyHandle;
		public static RMethod RDisposeHandle_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_RDisposeHandle_Ref_AtomicSafetyHandle == null)
				{
					r_RDisposeHandle_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "DisposeHandle", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_RDisposeHandle_Ref_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RDisposeHandle_Ref_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void Create_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_RCreate_Injected_Out_AtomicSafetyHandle;
		public static RMethod RCreate_Injected_Out_AtomicSafetyHandle
		{
			get
			{
				if(r_RCreate_Injected_Out_AtomicSafetyHandle == null)
				{
					r_RCreate_Injected_Out_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "Create_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_RCreate_Injected_Out_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RCreate_Injected_Out_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void GetTempUnsafePtrSliceHandle_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_RGetTempUnsafePtrSliceHandle_Injected_Out_AtomicSafetyHandle;
		public static RMethod RGetTempUnsafePtrSliceHandle_Injected_Out_AtomicSafetyHandle
		{
			get
			{
				if(r_RGetTempUnsafePtrSliceHandle_Injected_Out_AtomicSafetyHandle == null)
				{
					r_RGetTempUnsafePtrSliceHandle_Injected_Out_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetTempUnsafePtrSliceHandle_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_RGetTempUnsafePtrSliceHandle_Injected_Out_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RGetTempUnsafePtrSliceHandle_Injected_Out_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void GetTempMemoryHandle_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_RGetTempMemoryHandle_Injected_Out_AtomicSafetyHandle;
		public static RMethod RGetTempMemoryHandle_Injected_Out_AtomicSafetyHandle
		{
			get
			{
				if(r_RGetTempMemoryHandle_Injected_Out_AtomicSafetyHandle == null)
				{
					r_RGetTempMemoryHandle_Injected_Out_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetTempMemoryHandle_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_RGetTempMemoryHandle_Injected_Out_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RGetTempMemoryHandle_Injected_Out_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Boolean IsTempMemoryHandle_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_RIsTempMemoryHandle_Injected_Ref_AtomicSafetyHandle;
		public static RMethod RIsTempMemoryHandle_Injected_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_RIsTempMemoryHandle_Injected_Ref_AtomicSafetyHandle == null)
				{
					r_RIsTempMemoryHandle_Injected_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "IsTempMemoryHandle_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_RIsTempMemoryHandle_Injected_Ref_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RIsTempMemoryHandle_Injected_Ref_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void Release_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_RRelease_Injected_Ref_AtomicSafetyHandle;
		public static RMethod RRelease_Injected_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_RRelease_Injected_Ref_AtomicSafetyHandle == null)
				{
					r_RRelease_Injected_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "Release_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_RRelease_Injected_Ref_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RRelease_Injected_Ref_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void SetAllowSecondaryVersionWriting_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef, Boolean)
		/// </summary>
		protected static RMethod r_RSetAllowSecondaryVersionWriting_Injected_Ref_AtomicSafetyHandle_Boolean;
		public static RMethod RSetAllowSecondaryVersionWriting_Injected_Ref_AtomicSafetyHandle_Boolean
		{
			get
			{
				if(r_RSetAllowSecondaryVersionWriting_Injected_Ref_AtomicSafetyHandle_Boolean == null)
				{
					r_RSetAllowSecondaryVersionWriting_Injected_Ref_AtomicSafetyHandle_Boolean = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "SetAllowSecondaryVersionWriting_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType(), typeof(System.Boolean));
					r_RSetAllowSecondaryVersionWriting_Injected_Ref_AtomicSafetyHandle_Boolean.SetBelong(null);
				}
				return r_RSetAllowSecondaryVersionWriting_Injected_Ref_AtomicSafetyHandle_Boolean;
			}
		}

		/// <summary>
		/// Void SetBumpSecondaryVersionOnScheduleWrite_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef, Boolean)
		/// </summary>
		protected static RMethod r_RSetBumpSecondaryVersionOnScheduleWrite_Injected_Ref_AtomicSafetyHandle_Boolean;
		public static RMethod RSetBumpSecondaryVersionOnScheduleWrite_Injected_Ref_AtomicSafetyHandle_Boolean
		{
			get
			{
				if(r_RSetBumpSecondaryVersionOnScheduleWrite_Injected_Ref_AtomicSafetyHandle_Boolean == null)
				{
					r_RSetBumpSecondaryVersionOnScheduleWrite_Injected_Ref_AtomicSafetyHandle_Boolean = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "SetBumpSecondaryVersionOnScheduleWrite_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType(), typeof(System.Boolean));
					r_RSetBumpSecondaryVersionOnScheduleWrite_Injected_Ref_AtomicSafetyHandle_Boolean.SetBelong(null);
				}
				return r_RSetBumpSecondaryVersionOnScheduleWrite_Injected_Ref_AtomicSafetyHandle_Boolean;
			}
		}

		/// <summary>
		/// Void SetAllowReadOrWriteAccess_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef, Boolean)
		/// </summary>
		protected static RMethod r_RSetAllowReadOrWriteAccess_Injected_Ref_AtomicSafetyHandle_Boolean;
		public static RMethod RSetAllowReadOrWriteAccess_Injected_Ref_AtomicSafetyHandle_Boolean
		{
			get
			{
				if(r_RSetAllowReadOrWriteAccess_Injected_Ref_AtomicSafetyHandle_Boolean == null)
				{
					r_RSetAllowReadOrWriteAccess_Injected_Ref_AtomicSafetyHandle_Boolean = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "SetAllowReadOrWriteAccess_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType(), typeof(System.Boolean));
					r_RSetAllowReadOrWriteAccess_Injected_Ref_AtomicSafetyHandle_Boolean.SetBelong(null);
				}
				return r_RSetAllowReadOrWriteAccess_Injected_Ref_AtomicSafetyHandle_Boolean;
			}
		}

		/// <summary>
		/// Boolean GetAllowReadOrWriteAccess_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_RGetAllowReadOrWriteAccess_Injected_Ref_AtomicSafetyHandle;
		public static RMethod RGetAllowReadOrWriteAccess_Injected_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_RGetAllowReadOrWriteAccess_Injected_Ref_AtomicSafetyHandle == null)
				{
					r_RGetAllowReadOrWriteAccess_Injected_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetAllowReadOrWriteAccess_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_RGetAllowReadOrWriteAccess_Injected_Ref_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RGetAllowReadOrWriteAccess_Injected_Ref_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void SetNestedContainer_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef, Boolean)
		/// </summary>
		protected static RMethod r_RSetNestedContainer_Injected_Ref_AtomicSafetyHandle_Boolean;
		public static RMethod RSetNestedContainer_Injected_Ref_AtomicSafetyHandle_Boolean
		{
			get
			{
				if(r_RSetNestedContainer_Injected_Ref_AtomicSafetyHandle_Boolean == null)
				{
					r_RSetNestedContainer_Injected_Ref_AtomicSafetyHandle_Boolean = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "SetNestedContainer_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType(), typeof(System.Boolean));
					r_RSetNestedContainer_Injected_Ref_AtomicSafetyHandle_Boolean.SetBelong(null);
				}
				return r_RSetNestedContainer_Injected_Ref_AtomicSafetyHandle_Boolean;
			}
		}

		/// <summary>
		/// Boolean GetNestedContainer_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_RGetNestedContainer_Injected_Ref_AtomicSafetyHandle;
		public static RMethod RGetNestedContainer_Injected_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_RGetNestedContainer_Injected_Ref_AtomicSafetyHandle == null)
				{
					r_RGetNestedContainer_Injected_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetNestedContainer_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_RGetNestedContainer_Injected_Ref_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RGetNestedContainer_Injected_Ref_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void CheckWriteAndBumpSecondaryVersion_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_RCheckWriteAndBumpSecondaryVersion_Injected_Ref_AtomicSafetyHandle;
		public static RMethod RCheckWriteAndBumpSecondaryVersion_Injected_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_RCheckWriteAndBumpSecondaryVersion_Injected_Ref_AtomicSafetyHandle == null)
				{
					r_RCheckWriteAndBumpSecondaryVersion_Injected_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "CheckWriteAndBumpSecondaryVersion_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_RCheckWriteAndBumpSecondaryVersion_Injected_Ref_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RCheckWriteAndBumpSecondaryVersion_Injected_Ref_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.EnforceJobResult EnforceAllBufferJobsHaveCompleted_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_REnforceAllBufferJobsHaveCompleted_Injected_Ref_AtomicSafetyHandle;
		public static RMethod REnforceAllBufferJobsHaveCompleted_Injected_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_REnforceAllBufferJobsHaveCompleted_Injected_Ref_AtomicSafetyHandle == null)
				{
					r_REnforceAllBufferJobsHaveCompleted_Injected_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "EnforceAllBufferJobsHaveCompleted_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_REnforceAllBufferJobsHaveCompleted_Injected_Ref_AtomicSafetyHandle.SetBelong(null);
				}
				return r_REnforceAllBufferJobsHaveCompleted_Injected_Ref_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.EnforceJobResult EnforceAllBufferJobsHaveCompletedAndRelease_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_REnforceAllBufferJobsHaveCompletedAndRelease_Injected_Ref_AtomicSafetyHandle;
		public static RMethod REnforceAllBufferJobsHaveCompletedAndRelease_Injected_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_REnforceAllBufferJobsHaveCompletedAndRelease_Injected_Ref_AtomicSafetyHandle == null)
				{
					r_REnforceAllBufferJobsHaveCompletedAndRelease_Injected_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "EnforceAllBufferJobsHaveCompletedAndRelease_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_REnforceAllBufferJobsHaveCompletedAndRelease_Injected_Ref_AtomicSafetyHandle.SetBelong(null);
				}
				return r_REnforceAllBufferJobsHaveCompletedAndRelease_Injected_Ref_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.EnforceJobResult EnforceAllBufferJobsHaveCompletedAndDisableReadWrite_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_REnforceAllBufferJobsHaveCompletedAndDisableReadWrite_Injected_Ref_AtomicSafetyHandle;
		public static RMethod REnforceAllBufferJobsHaveCompletedAndDisableReadWrite_Injected_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_REnforceAllBufferJobsHaveCompletedAndDisableReadWrite_Injected_Ref_AtomicSafetyHandle == null)
				{
					r_REnforceAllBufferJobsHaveCompletedAndDisableReadWrite_Injected_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "EnforceAllBufferJobsHaveCompletedAndDisableReadWrite_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_REnforceAllBufferJobsHaveCompletedAndDisableReadWrite_Injected_Ref_AtomicSafetyHandle.SetBelong(null);
				}
				return r_REnforceAllBufferJobsHaveCompletedAndDisableReadWrite_Injected_Ref_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void CheckReadAndThrowNoEarlyOut_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_RCheckReadAndThrowNoEarlyOut_Injected_Ref_AtomicSafetyHandle;
		public static RMethod RCheckReadAndThrowNoEarlyOut_Injected_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_RCheckReadAndThrowNoEarlyOut_Injected_Ref_AtomicSafetyHandle == null)
				{
					r_RCheckReadAndThrowNoEarlyOut_Injected_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "CheckReadAndThrowNoEarlyOut_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_RCheckReadAndThrowNoEarlyOut_Injected_Ref_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RCheckReadAndThrowNoEarlyOut_Injected_Ref_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void CheckWriteAndThrowNoEarlyOut_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_RCheckWriteAndThrowNoEarlyOut_Injected_Ref_AtomicSafetyHandle;
		public static RMethod RCheckWriteAndThrowNoEarlyOut_Injected_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_RCheckWriteAndThrowNoEarlyOut_Injected_Ref_AtomicSafetyHandle == null)
				{
					r_RCheckWriteAndThrowNoEarlyOut_Injected_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "CheckWriteAndThrowNoEarlyOut_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_RCheckWriteAndThrowNoEarlyOut_Injected_Ref_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RCheckWriteAndThrowNoEarlyOut_Injected_Ref_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void CheckDeallocateAndThrow_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_RCheckDeallocateAndThrow_Injected_Ref_AtomicSafetyHandle;
		public static RMethod RCheckDeallocateAndThrow_Injected_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_RCheckDeallocateAndThrow_Injected_Ref_AtomicSafetyHandle == null)
				{
					r_RCheckDeallocateAndThrow_Injected_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "CheckDeallocateAndThrow_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_RCheckDeallocateAndThrow_Injected_Ref_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RCheckDeallocateAndThrow_Injected_Ref_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void CheckGetSecondaryDataPointerAndThrow_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_RCheckGetSecondaryDataPointerAndThrow_Injected_Ref_AtomicSafetyHandle;
		public static RMethod RCheckGetSecondaryDataPointerAndThrow_Injected_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_RCheckGetSecondaryDataPointerAndThrow_Injected_Ref_AtomicSafetyHandle == null)
				{
					r_RCheckGetSecondaryDataPointerAndThrow_Injected_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "CheckGetSecondaryDataPointerAndThrow_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_RCheckGetSecondaryDataPointerAndThrow_Injected_Ref_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RCheckGetSecondaryDataPointerAndThrow_Injected_Ref_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Int32 GetReaderArray_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef, Int32, IntPtr)
		/// </summary>
		protected static RMethod r_RGetReaderArray_Injected_Ref_AtomicSafetyHandle_Int32_IntPtr;
		public static RMethod RGetReaderArray_Injected_Ref_AtomicSafetyHandle_Int32_IntPtr
		{
			get
			{
				if(r_RGetReaderArray_Injected_Ref_AtomicSafetyHandle_Int32_IntPtr == null)
				{
					r_RGetReaderArray_Injected_Ref_AtomicSafetyHandle_Int32_IntPtr = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetReaderArray_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType(), typeof(System.Int32), typeof(System.IntPtr));
					r_RGetReaderArray_Injected_Ref_AtomicSafetyHandle_Int32_IntPtr.SetBelong(null);
				}
				return r_RGetReaderArray_Injected_Ref_AtomicSafetyHandle_Int32_IntPtr;
			}
		}

		/// <summary>
		/// Void GetWriter_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef, Unity.Jobs.JobHandle ByRef)
		/// </summary>
		protected static RMethod r_RGetWriter_Injected_Ref_AtomicSafetyHandle_Out_JobHandle;
		public static RMethod RGetWriter_Injected_Ref_AtomicSafetyHandle_Out_JobHandle
		{
			get
			{
				if(r_RGetWriter_Injected_Ref_AtomicSafetyHandle_Out_JobHandle == null)
				{
					r_RGetWriter_Injected_Ref_AtomicSafetyHandle_Out_JobHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetWriter_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType(), typeof(Unity.Jobs.JobHandle).MakeByRefType());
					r_RGetWriter_Injected_Ref_AtomicSafetyHandle_Out_JobHandle.SetBelong(null);
				}
				return r_RGetWriter_Injected_Ref_AtomicSafetyHandle_Out_JobHandle;
			}
		}

		/// <summary>
		/// System.String GetReaderName_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef, Int32)
		/// </summary>
		protected static RMethod r_RGetReaderName_Injected_Ref_AtomicSafetyHandle_Int32;
		public static RMethod RGetReaderName_Injected_Ref_AtomicSafetyHandle_Int32
		{
			get
			{
				if(r_RGetReaderName_Injected_Ref_AtomicSafetyHandle_Int32 == null)
				{
					r_RGetReaderName_Injected_Ref_AtomicSafetyHandle_Int32 = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetReaderName_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType(), typeof(System.Int32));
					r_RGetReaderName_Injected_Ref_AtomicSafetyHandle_Int32.SetBelong(null);
				}
				return r_RGetReaderName_Injected_Ref_AtomicSafetyHandle_Int32;
			}
		}

		/// <summary>
		/// System.String GetWriterName_Injected(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_RGetWriterName_Injected_Ref_AtomicSafetyHandle;
		public static RMethod RGetWriterName_Injected_Ref_AtomicSafetyHandle
		{
			get
			{
				if(r_RGetWriterName_Injected_Ref_AtomicSafetyHandle == null)
				{
					r_RGetWriterName_Injected_Ref_AtomicSafetyHandle = new(typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle), "GetWriterName_Injected", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_RGetWriterName_Injected_Ref_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RGetWriterName_Injected_Ref_AtomicSafetyHandle;
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

        public static Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle Create()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreate.Invoke(___genericsType, ___parameters);

            return (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___result;
        }


        public static Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetTempUnsafePtrSliceHandle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTempUnsafePtrSliceHandle.Invoke(___genericsType, ___parameters);

            return (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___result;
        }


        public static Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetTempMemoryHandle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTempMemoryHandle.Invoke(___genericsType, ___parameters);

            return (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___result;
        }


        public static System.Boolean IsTempMemoryHandle(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RIsTempMemoryHandle_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void Release(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RRelease_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsDefaultValue(in Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RIsDefaultValue_In_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void SetExclusiveWeak(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle, System.Boolean  @enabled)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @enabled};
            var ___result = RSetExclusiveWeak_Ref_AtomicSafetyHandle_Boolean.Invoke(___genericsType, ___parameters);
			handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static System.Boolean GetExclusiveWeak(in Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetExclusiveWeak_In_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void PrepareUndisposable(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RPrepareUndisposable_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static void UseSecondaryVersion(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RUseSecondaryVersion_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static void SetAllowSecondaryVersionWriting(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle, System.Boolean  @allowWriting)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @allowWriting};
            var ___result = RSetAllowSecondaryVersionWriting_AtomicSafetyHandle_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetBumpSecondaryVersionOnScheduleWrite(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle, System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @value};
            var ___result = RSetBumpSecondaryVersionOnScheduleWrite_AtomicSafetyHandle_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetAllowReadOrWriteAccess(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle, System.Boolean  @allowReadWriteAccess)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @allowReadWriteAccess};
            var ___result = RSetAllowReadOrWriteAccess_AtomicSafetyHandle_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean GetAllowReadOrWriteAccess(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetAllowReadOrWriteAccess_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void SetNestedContainer(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle, System.Boolean  @isNestedContainer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @isNestedContainer};
            var ___result = RSetNestedContainer_AtomicSafetyHandle_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean GetNestedContainer(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetNestedContainer_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void CheckWriteAndBumpSecondaryVersion(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RCheckWriteAndBumpSecondaryVersion_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            
        }


        public static Unity.Collections.LowLevel.Unsafe.EnforceJobResult EnforceAllBufferJobsHaveCompleted(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = REnforceAllBufferJobsHaveCompleted_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            return (Unity.Collections.LowLevel.Unsafe.EnforceJobResult)___result;
        }


        public static Unity.Collections.LowLevel.Unsafe.EnforceJobResult EnforceAllBufferJobsHaveCompletedAndRelease(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = REnforceAllBufferJobsHaveCompletedAndRelease_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            return (Unity.Collections.LowLevel.Unsafe.EnforceJobResult)___result;
        }


        public static Unity.Collections.LowLevel.Unsafe.EnforceJobResult EnforceAllBufferJobsHaveCompletedAndDisableReadWrite(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = REnforceAllBufferJobsHaveCompletedAndDisableReadWrite_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            return (Unity.Collections.LowLevel.Unsafe.EnforceJobResult)___result;
        }


        public static void CheckReadAndThrowNoEarlyOut(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RCheckReadAndThrowNoEarlyOut_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            
        }


        public static void CheckWriteAndThrowNoEarlyOut(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RCheckWriteAndThrowNoEarlyOut_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            
        }


        public static void CheckDeallocateAndThrow(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RCheckDeallocateAndThrow_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            
        }


        public static void CheckGetSecondaryDataPointerAndThrow(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RCheckGetSecondaryDataPointerAndThrow_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 GetReaderArray(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle, System.Int32  @maxCount, System.IntPtr  @output)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @maxCount, @output};
            var ___result = RGetReaderArray_AtomicSafetyHandle_Int32_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static Unity.Jobs.JobHandle GetWriter(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetWriter_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            return (Unity.Jobs.JobHandle)___result;
        }


        public static void CheckReadAndThrow(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RCheckReadAndThrow_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            
        }


        public static void CheckWriteAndThrow(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RCheckWriteAndThrow_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            
        }


        public static void ValidateNonDefaultHandle(in Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RValidateNonDefaultHandle_In_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsValidNonDefaultHandle(in Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RIsValidNonDefaultHandle_In_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void CheckExistsAndThrow(in Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RCheckExistsAndThrow_In_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsHandleValid(in Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RIsHandleValid_In_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.String GetReaderName(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle, System.Int32  @readerIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @readerIndex};
            var ___result = RGetReaderName_AtomicSafetyHandle_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String GetWriterName(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetWriterName_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }



        public static System.Int32 NewStaticSafetyId<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RNewStaticSafetyId_GT.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }



        public static void SetStaticSafetyId(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle, System.Int32  @staticSafetyId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @staticSafetyId};
            var ___result = RSetStaticSafetyId_Ref_AtomicSafetyHandle_Int32.Invoke(___genericsType, ___parameters);
			handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static void CreateHandle(out Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @safety, Unity.Collections.Allocator  @allocator)
        {
			safety = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@safety, @allocator};
            var ___result = RCreateHandle_Out_AtomicSafetyHandle_Allocator.Invoke(___genericsType, ___parameters);
			safety = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static void DisposeHandle(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @safety)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@safety};
            var ___result = RDisposeHandle_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			safety = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static void Create_Injected(out Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RCreate_Injected_Out_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			ret = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static void GetTempUnsafePtrSliceHandle_Injected(out Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RGetTempUnsafePtrSliceHandle_Injected_Out_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			ret = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static void GetTempMemoryHandle_Injected(out Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RGetTempMemoryHandle_Injected_Out_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			ret = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static System.Boolean IsTempMemoryHandle_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RIsTempMemoryHandle_Injected_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            return (System.Boolean)___result;
        }


        public static void Release_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RRelease_Injected_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static void SetAllowSecondaryVersionWriting_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle, System.Boolean  @allowWriting)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @allowWriting};
            var ___result = RSetAllowSecondaryVersionWriting_Injected_Ref_AtomicSafetyHandle_Boolean.Invoke(___genericsType, ___parameters);
			handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static void SetBumpSecondaryVersionOnScheduleWrite_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle, System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @value};
            var ___result = RSetBumpSecondaryVersionOnScheduleWrite_Injected_Ref_AtomicSafetyHandle_Boolean.Invoke(___genericsType, ___parameters);
			handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static void SetAllowReadOrWriteAccess_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle, System.Boolean  @allowReadWriteAccess)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @allowReadWriteAccess};
            var ___result = RSetAllowReadOrWriteAccess_Injected_Ref_AtomicSafetyHandle_Boolean.Invoke(___genericsType, ___parameters);
			handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static System.Boolean GetAllowReadOrWriteAccess_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetAllowReadOrWriteAccess_Injected_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            return (System.Boolean)___result;
        }


        public static void SetNestedContainer_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle, System.Boolean  @isNestedContainer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @isNestedContainer};
            var ___result = RSetNestedContainer_Injected_Ref_AtomicSafetyHandle_Boolean.Invoke(___genericsType, ___parameters);
			handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static System.Boolean GetNestedContainer_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetNestedContainer_Injected_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            return (System.Boolean)___result;
        }


        public static void CheckWriteAndBumpSecondaryVersion_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RCheckWriteAndBumpSecondaryVersion_Injected_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static Unity.Collections.LowLevel.Unsafe.EnforceJobResult EnforceAllBufferJobsHaveCompleted_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = REnforceAllBufferJobsHaveCompleted_Injected_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            return (Unity.Collections.LowLevel.Unsafe.EnforceJobResult)___result;
        }


        public static Unity.Collections.LowLevel.Unsafe.EnforceJobResult EnforceAllBufferJobsHaveCompletedAndRelease_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = REnforceAllBufferJobsHaveCompletedAndRelease_Injected_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            return (Unity.Collections.LowLevel.Unsafe.EnforceJobResult)___result;
        }


        public static Unity.Collections.LowLevel.Unsafe.EnforceJobResult EnforceAllBufferJobsHaveCompletedAndDisableReadWrite_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = REnforceAllBufferJobsHaveCompletedAndDisableReadWrite_Injected_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            return (Unity.Collections.LowLevel.Unsafe.EnforceJobResult)___result;
        }


        public static void CheckReadAndThrowNoEarlyOut_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RCheckReadAndThrowNoEarlyOut_Injected_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static void CheckWriteAndThrowNoEarlyOut_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RCheckWriteAndThrowNoEarlyOut_Injected_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static void CheckDeallocateAndThrow_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RCheckDeallocateAndThrow_Injected_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static void CheckGetSecondaryDataPointerAndThrow_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RCheckGetSecondaryDataPointerAndThrow_Injected_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            
        }


        public static System.Int32 GetReaderArray_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle, System.Int32  @maxCount, System.IntPtr  @output)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @maxCount, @output};
            var ___result = RGetReaderArray_Injected_Ref_AtomicSafetyHandle_Int32_IntPtr.Invoke(___genericsType, ___parameters);
			handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            return (System.Int32)___result;
        }


        public static void GetWriter_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle, out Unity.Jobs.JobHandle  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @ret};
            var ___result = RGetWriter_Injected_Ref_AtomicSafetyHandle_Out_JobHandle.Invoke(___genericsType, ___parameters);
			handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];
			ret = (Unity.Jobs.JobHandle)___parameters[1];

            
        }


        public static System.String GetReaderName_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle, System.Int32  @readerIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @readerIndex};
            var ___result = RGetReaderName_Injected_Ref_AtomicSafetyHandle_Int32.Invoke(___genericsType, ___parameters);
			handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            return (System.String)___result;
        }


        public static System.String GetWriterName_Injected(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetWriterName_Injected_Ref_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			handle = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[0];

            return (System.String)___result;
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
