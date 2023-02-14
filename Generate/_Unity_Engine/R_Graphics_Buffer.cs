
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.GraphicsBuffer
	/// </summary>
    public partial class RGraphicsBuffer : RMember //
    {

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
					r_Fm_Ptr.SetBelong(this.instance);
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
					r_Fm_Safety.SetBelong(this.instance);
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
					r_Pcount.SetBelong(this.instance);
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
					r_Pstride.SetBelong(this.instance);
				}
				return r_Pstride;
			}
		}

		/// <summary>
		/// Target target
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGraphicsBuffer.RTarget r_Ptarget;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGraphicsBuffer.RTarget RPtarget
		{
			get
			{
				if(r_Ptarget == null)
				{
					r_Ptarget = new(this, "target", -1);
					r_Ptarget.SetBelong(this.instance);
				}
				return r_Ptarget;
			}
		}

		/// <summary>
		/// UsageFlags usageFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGraphicsBuffer.RUsageFlags r_PusageFlags;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGraphicsBuffer.RUsageFlags RPusageFlags
		{
			get
			{
				if(r_PusageFlags == null)
				{
					r_PusageFlags = new(this, "usageFlags", -1);
					r_PusageFlags.SetBelong(this.instance);
				}
				return r_PusageFlags;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBufferHandle bufferHandle
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGraphicsBufferHandle r_PbufferHandle;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGraphicsBufferHandle RPbufferHandle
		{
			get
			{
				if(r_PbufferHandle == null)
				{
					r_PbufferHandle = new(this, "bufferHandle", -1);
					r_PbufferHandle.SetBelong(this.instance);
				}
				return r_PbufferHandle;
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
					r_Pname.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MDispose.SetBelong(this.instance);
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
					r_MDispose_Boolean.SetBelong(this.instance);
				}
				return r_MDispose_Boolean;
			}
		}

		/// <summary>
		/// Boolean RequiresCompute(Target)
		/// </summary>
		protected static RMethod r_MRequiresCompute_Target;
		public static RMethod RMRequiresCompute_Target
		{
			get
			{
				if(r_MRequiresCompute_Target == null)
				{
					r_MRequiresCompute_Target = new(typeof(UnityEngine.GraphicsBuffer), "RequiresCompute", 0,  ReflectionUtils.GetType("UnityEngine.GraphicsBuffer+Target"));
					r_MRequiresCompute_Target.SetBelong(null);
				}
				return r_MRequiresCompute_Target;
			}
		}

		/// <summary>
		/// Boolean IsVertexIndexOrCopyOnly(Target)
		/// </summary>
		protected static RMethod r_MIsVertexIndexOrCopyOnly_Target;
		public static RMethod RMIsVertexIndexOrCopyOnly_Target
		{
			get
			{
				if(r_MIsVertexIndexOrCopyOnly_Target == null)
				{
					r_MIsVertexIndexOrCopyOnly_Target = new(typeof(UnityEngine.GraphicsBuffer), "IsVertexIndexOrCopyOnly", 0,  ReflectionUtils.GetType("UnityEngine.GraphicsBuffer+Target"));
					r_MIsVertexIndexOrCopyOnly_Target.SetBelong(null);
				}
				return r_MIsVertexIndexOrCopyOnly_Target;
			}
		}

		/// <summary>
		/// IntPtr InitBuffer(Target, UsageFlags, Int32, Int32)
		/// </summary>
		protected static RMethod r_MInitBuffer_Target_UsageFlags_Int32_Int32;
		public static RMethod RMInitBuffer_Target_UsageFlags_Int32_Int32
		{
			get
			{
				if(r_MInitBuffer_Target_UsageFlags_Int32_Int32 == null)
				{
					r_MInitBuffer_Target_UsageFlags_Int32_Int32 = new(typeof(UnityEngine.GraphicsBuffer), "InitBuffer", 0,  ReflectionUtils.GetType("UnityEngine.GraphicsBuffer+Target"),  ReflectionUtils.GetType("UnityEngine.GraphicsBuffer+UsageFlags"), typeof(System.Int32), typeof(System.Int32));
					r_MInitBuffer_Target_UsageFlags_Int32_Int32.SetBelong(null);
				}
				return r_MInitBuffer_Target_UsageFlags_Int32_Int32;
			}
		}

		/// <summary>
		/// Void DestroyBuffer(UnityEngine.GraphicsBuffer)
		/// </summary>
		protected static RMethod r_MDestroyBuffer_GraphicsBuffer;
		public static RMethod RMDestroyBuffer_GraphicsBuffer
		{
			get
			{
				if(r_MDestroyBuffer_GraphicsBuffer == null)
				{
					r_MDestroyBuffer_GraphicsBuffer = new(typeof(UnityEngine.GraphicsBuffer), "DestroyBuffer", 0, typeof(UnityEngine.GraphicsBuffer));
					r_MDestroyBuffer_GraphicsBuffer.SetBelong(null);
				}
				return r_MDestroyBuffer_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void InternalInitialization(Target, UsageFlags, Int32, Int32)
		/// </summary>
		protected RMethod r_MInternalInitialization_Target_UsageFlags_Int32_Int32;
		public virtual RMethod RMInternalInitialization_Target_UsageFlags_Int32_Int32
		{
			get
			{
				if(r_MInternalInitialization_Target_UsageFlags_Int32_Int32 == null)
				{
					r_MInternalInitialization_Target_UsageFlags_Int32_Int32 = new(this, "InternalInitialization", 0,  ReflectionUtils.GetType("UnityEngine.GraphicsBuffer+Target"),  ReflectionUtils.GetType("UnityEngine.GraphicsBuffer+UsageFlags"), typeof(System.Int32), typeof(System.Int32));
					r_MInternalInitialization_Target_UsageFlags_Int32_Int32.SetBelong(this.instance);
				}
				return r_MInternalInitialization_Target_UsageFlags_Int32_Int32;
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
					r_MRelease.SetBelong(this.instance);
				}
				return r_MRelease;
			}
		}

		/// <summary>
		/// Boolean IsValidBuffer(UnityEngine.GraphicsBuffer)
		/// </summary>
		protected static RMethod r_MIsValidBuffer_GraphicsBuffer;
		public static RMethod RMIsValidBuffer_GraphicsBuffer
		{
			get
			{
				if(r_MIsValidBuffer_GraphicsBuffer == null)
				{
					r_MIsValidBuffer_GraphicsBuffer = new(typeof(UnityEngine.GraphicsBuffer), "IsValidBuffer", 0, typeof(UnityEngine.GraphicsBuffer));
					r_MIsValidBuffer_GraphicsBuffer.SetBelong(null);
				}
				return r_MIsValidBuffer_GraphicsBuffer;
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
					r_MIsValid.SetBelong(this.instance);
				}
				return r_MIsValid;
			}
		}

		/// <summary>
		/// UsageFlags GetUsageFlags()
		/// </summary>
		protected RMethod r_MGetUsageFlags;
		public virtual RMethod RMGetUsageFlags
		{
			get
			{
				if(r_MGetUsageFlags == null)
				{
					r_MGetUsageFlags = new(this, "GetUsageFlags", 0);
					r_MGetUsageFlags.SetBelong(this.instance);
				}
				return r_MGetUsageFlags;
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
					r_MSetData_Array.SetBelong(this.instance);
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
					r_MSetData_GT_List_d_T_p_ = new(this, "SetData", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MSetData_GT_List_d_T_p_.SetBelong(this.instance);
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
					r_MSetData_GT_NativeArray_d_T_p_ = new(this, "SetData", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MSetData_GT_NativeArray_d_T_p_.SetBelong(this.instance);
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
					r_MSetData_Array_Int32_Int32_Int32.SetBelong(this.instance);
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
					r_MSetData_GT_List_d_T_p__Int32_Int32_Int32 = new(this, "SetData", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_MSetData_GT_List_d_T_p__Int32_Int32_Int32.SetBelong(this.instance);
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
					r_MSetData_GT_NativeArray_d_T_p__Int32_Int32_Int32 = new(this, "SetData", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_MSetData_GT_NativeArray_d_T_p__Int32_Int32_Int32.SetBelong(this.instance);
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
					r_MInternalSetNativeData_IntPtr_Int32_Int32_Int32_Int32.SetBelong(this.instance);
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
					r_MInternalSetData_Array_Int32_Int32_Int32_Int32.SetBelong(this.instance);
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
					r_MGetData_Array.SetBelong(this.instance);
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
					r_MGetData_Array_Int32_Int32_Int32.SetBelong(this.instance);
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
					r_MInternalGetData_Array_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_MInternalGetData_Array_Int32_Int32_Int32_Int32;
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
					r_MGetNativeBufferPtr.SetBelong(this.instance);
				}
				return r_MGetNativeBufferPtr;
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
					r_MBeginBufferWrite_Int32_Int32.SetBelong(this.instance);
				}
				return r_MBeginBufferWrite_Int32_Int32;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[T] LockBufferForWrite[T](Int32, Int32)
		/// </summary>
		protected RMethod r_MLockBufferForWrite_GT_Int32_Int32;
		public virtual RMethod RMLockBufferForWrite_GT_Int32_Int32
		{
			get
			{
				if(r_MLockBufferForWrite_GT_Int32_Int32 == null)
				{
					r_MLockBufferForWrite_GT_Int32_Int32 = new(this, "LockBufferForWrite", 1, typeof(System.Int32), typeof(System.Int32));
					r_MLockBufferForWrite_GT_Int32_Int32.SetBelong(this.instance);
				}
				return r_MLockBufferForWrite_GT_Int32_Int32;
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
					r_MEndBufferWrite_Int32.SetBelong(this.instance);
				}
				return r_MEndBufferWrite_Int32;
			}
		}

		/// <summary>
		/// Void UnlockBufferAfterWrite[T](Int32)
		/// </summary>
		protected RMethod r_MUnlockBufferAfterWrite_GT_Int32;
		public virtual RMethod RMUnlockBufferAfterWrite_GT_Int32
		{
			get
			{
				if(r_MUnlockBufferAfterWrite_GT_Int32 == null)
				{
					r_MUnlockBufferAfterWrite_GT_Int32 = new(this, "UnlockBufferAfterWrite", 1, typeof(System.Int32));
					r_MUnlockBufferAfterWrite_GT_Int32.SetBelong(this.instance);
				}
				return r_MUnlockBufferAfterWrite_GT_Int32;
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
					r_MSetName_String.SetBelong(this.instance);
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
					r_MSetCounterValue_UInt32.SetBelong(this.instance);
				}
				return r_MSetCounterValue_UInt32;
			}
		}

		/// <summary>
		/// Void CopyCountCC(UnityEngine.ComputeBuffer, UnityEngine.ComputeBuffer, Int32)
		/// </summary>
		protected static RMethod r_MCopyCountCC_ComputeBuffer_ComputeBuffer_Int32;
		public static RMethod RMCopyCountCC_ComputeBuffer_ComputeBuffer_Int32
		{
			get
			{
				if(r_MCopyCountCC_ComputeBuffer_ComputeBuffer_Int32 == null)
				{
					r_MCopyCountCC_ComputeBuffer_ComputeBuffer_Int32 = new(typeof(UnityEngine.GraphicsBuffer), "CopyCountCC", 0, typeof(UnityEngine.ComputeBuffer), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32));
					r_MCopyCountCC_ComputeBuffer_ComputeBuffer_Int32.SetBelong(null);
				}
				return r_MCopyCountCC_ComputeBuffer_ComputeBuffer_Int32;
			}
		}

		/// <summary>
		/// Void CopyCountGC(UnityEngine.GraphicsBuffer, UnityEngine.ComputeBuffer, Int32)
		/// </summary>
		protected static RMethod r_MCopyCountGC_GraphicsBuffer_ComputeBuffer_Int32;
		public static RMethod RMCopyCountGC_GraphicsBuffer_ComputeBuffer_Int32
		{
			get
			{
				if(r_MCopyCountGC_GraphicsBuffer_ComputeBuffer_Int32 == null)
				{
					r_MCopyCountGC_GraphicsBuffer_ComputeBuffer_Int32 = new(typeof(UnityEngine.GraphicsBuffer), "CopyCountGC", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32));
					r_MCopyCountGC_GraphicsBuffer_ComputeBuffer_Int32.SetBelong(null);
				}
				return r_MCopyCountGC_GraphicsBuffer_ComputeBuffer_Int32;
			}
		}

		/// <summary>
		/// Void CopyCountCG(UnityEngine.ComputeBuffer, UnityEngine.GraphicsBuffer, Int32)
		/// </summary>
		protected static RMethod r_MCopyCountCG_ComputeBuffer_GraphicsBuffer_Int32;
		public static RMethod RMCopyCountCG_ComputeBuffer_GraphicsBuffer_Int32
		{
			get
			{
				if(r_MCopyCountCG_ComputeBuffer_GraphicsBuffer_Int32 == null)
				{
					r_MCopyCountCG_ComputeBuffer_GraphicsBuffer_Int32 = new(typeof(UnityEngine.GraphicsBuffer), "CopyCountCG", 0, typeof(UnityEngine.ComputeBuffer), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32));
					r_MCopyCountCG_ComputeBuffer_GraphicsBuffer_Int32.SetBelong(null);
				}
				return r_MCopyCountCG_ComputeBuffer_GraphicsBuffer_Int32;
			}
		}

		/// <summary>
		/// Void CopyCountGG(UnityEngine.GraphicsBuffer, UnityEngine.GraphicsBuffer, Int32)
		/// </summary>
		protected static RMethod r_MCopyCountGG_GraphicsBuffer_GraphicsBuffer_Int32;
		public static RMethod RMCopyCountGG_GraphicsBuffer_GraphicsBuffer_Int32
		{
			get
			{
				if(r_MCopyCountGG_GraphicsBuffer_GraphicsBuffer_Int32 == null)
				{
					r_MCopyCountGG_GraphicsBuffer_GraphicsBuffer_Int32 = new(typeof(UnityEngine.GraphicsBuffer), "CopyCountGG", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32));
					r_MCopyCountGG_GraphicsBuffer_GraphicsBuffer_Int32.SetBelong(null);
				}
				return r_MCopyCountGG_GraphicsBuffer_GraphicsBuffer_Int32;
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
					r_MCopyCount_ComputeBuffer_ComputeBuffer_Int32 = new(typeof(UnityEngine.GraphicsBuffer), "CopyCount", 0, typeof(UnityEngine.ComputeBuffer), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32));
					r_MCopyCount_ComputeBuffer_ComputeBuffer_Int32.SetBelong(null);
				}
				return r_MCopyCount_ComputeBuffer_ComputeBuffer_Int32;
			}
		}

		/// <summary>
		/// Void CopyCount(UnityEngine.GraphicsBuffer, UnityEngine.ComputeBuffer, Int32)
		/// </summary>
		protected static RMethod r_MCopyCount_GraphicsBuffer_ComputeBuffer_Int32;
		public static RMethod RMCopyCount_GraphicsBuffer_ComputeBuffer_Int32
		{
			get
			{
				if(r_MCopyCount_GraphicsBuffer_ComputeBuffer_Int32 == null)
				{
					r_MCopyCount_GraphicsBuffer_ComputeBuffer_Int32 = new(typeof(UnityEngine.GraphicsBuffer), "CopyCount", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32));
					r_MCopyCount_GraphicsBuffer_ComputeBuffer_Int32.SetBelong(null);
				}
				return r_MCopyCount_GraphicsBuffer_ComputeBuffer_Int32;
			}
		}

		/// <summary>
		/// Void CopyCount(UnityEngine.ComputeBuffer, UnityEngine.GraphicsBuffer, Int32)
		/// </summary>
		protected static RMethod r_MCopyCount_ComputeBuffer_GraphicsBuffer_Int32;
		public static RMethod RMCopyCount_ComputeBuffer_GraphicsBuffer_Int32
		{
			get
			{
				if(r_MCopyCount_ComputeBuffer_GraphicsBuffer_Int32 == null)
				{
					r_MCopyCount_ComputeBuffer_GraphicsBuffer_Int32 = new(typeof(UnityEngine.GraphicsBuffer), "CopyCount", 0, typeof(UnityEngine.ComputeBuffer), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32));
					r_MCopyCount_ComputeBuffer_GraphicsBuffer_Int32.SetBelong(null);
				}
				return r_MCopyCount_ComputeBuffer_GraphicsBuffer_Int32;
			}
		}

		/// <summary>
		/// Void CopyCount(UnityEngine.GraphicsBuffer, UnityEngine.GraphicsBuffer, Int32)
		/// </summary>
		protected static RMethod r_MCopyCount_GraphicsBuffer_GraphicsBuffer_Int32;
		public static RMethod RMCopyCount_GraphicsBuffer_GraphicsBuffer_Int32
		{
			get
			{
				if(r_MCopyCount_GraphicsBuffer_GraphicsBuffer_Int32 == null)
				{
					r_MCopyCount_GraphicsBuffer_GraphicsBuffer_Int32 = new(typeof(UnityEngine.GraphicsBuffer), "CopyCount", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32));
					r_MCopyCount_GraphicsBuffer_GraphicsBuffer_Int32.SetBelong(null);
				}
				return r_MCopyCount_GraphicsBuffer_GraphicsBuffer_Int32;
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
					r_MAddBufferToLeakDetector.SetBelong(this.instance);
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
					r_MRemoveBufferFromLeakDetector.SetBelong(this.instance);
				}
				return r_MRemoveBufferFromLeakDetector;
			}
		}

		/// <summary>
		/// Void get_bufferHandle_Injected(UnityEngine.GraphicsBufferHandle ByRef)
		/// </summary>
		protected RMethod r_Mget_bufferHandle_Injected_Out_GraphicsBufferHandle;
		public virtual RMethod RMget_bufferHandle_Injected_Out_GraphicsBufferHandle
		{
			get
			{
				if(r_Mget_bufferHandle_Injected_Out_GraphicsBufferHandle == null)
				{
					r_Mget_bufferHandle_Injected_Out_GraphicsBufferHandle = new(this, "get_bufferHandle_Injected", 0, typeof(UnityEngine.GraphicsBufferHandle).MakeByRefType());
					r_Mget_bufferHandle_Injected_Out_GraphicsBufferHandle.SetBelong(this.instance);
				}
				return r_Mget_bufferHandle_Injected_Out_GraphicsBufferHandle;
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


        public RGraphicsBuffer() : base("UnityEngine.GraphicsBuffer")
        {
        }

        public RGraphicsBuffer(System.Object instance) : base("UnityEngine.GraphicsBuffer")
		{
            SetInstance(instance);
		}

        public RGraphicsBuffer(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGraphicsBuffer(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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


        public static System.Boolean RequiresCompute(Hvak.Editor.Refleaction.RUnityEngine.RGraphicsBuffer.RTarget @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target.Value};
            var ___result = RMRequiresCompute_Target.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsVertexIndexOrCopyOnly(Hvak.Editor.Refleaction.RUnityEngine.RGraphicsBuffer.RTarget @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target.Value};
            var ___result = RMIsVertexIndexOrCopyOnly_Target.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.IntPtr InitBuffer(Hvak.Editor.Refleaction.RUnityEngine.RGraphicsBuffer.RTarget @target, Hvak.Editor.Refleaction.RUnityEngine.RGraphicsBuffer.RUsageFlags @usageFlags, System.Int32 @count, System.Int32 @stride)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target.Value, @usageFlags.Value, @count, @stride};
            var ___result = RMInitBuffer_Target_UsageFlags_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static void DestroyBuffer(UnityEngine.GraphicsBuffer @buf)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buf};
            var ___result = RMDestroyBuffer_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalInitialization(Hvak.Editor.Refleaction.RUnityEngine.RGraphicsBuffer.RTarget @target, Hvak.Editor.Refleaction.RUnityEngine.RGraphicsBuffer.RUsageFlags @usageFlags, System.Int32 @count, System.Int32 @stride)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target.Value, @usageFlags.Value, @count, @stride};
            var ___result = RMInternalInitialization_Target_UsageFlags_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Release()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRelease.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsValidBuffer(UnityEngine.GraphicsBuffer @buf)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buf};
            var ___result = RMIsValidBuffer_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsValid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsValid.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RGraphicsBuffer.RUsageFlags GetUsageFlags()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetUsageFlags.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RGraphicsBuffer.RUsageFlags(___result);
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


        public virtual void SetData(System.Array @data, System.Int32 @managedBufferStartIndex, System.Int32 @graphicsBufferStartIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @managedBufferStartIndex, @graphicsBufferStartIndex, @count};
            var ___result = RMSetData_Array_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetData<T>(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RType> @data, System.Int32 @managedBufferStartIndex, System.Int32 @graphicsBufferStartIndex, System.Int32 @count) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data.Value, @managedBufferStartIndex, @graphicsBufferStartIndex, @count};
            var ___result = RMSetData_GT_List_d_T_p__Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetData<T>(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @data, System.Int32 @nativeBufferStartIndex, System.Int32 @graphicsBufferStartIndex, System.Int32 @count) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data.Value, @nativeBufferStartIndex, @graphicsBufferStartIndex, @count};
            var ___result = RMSetData_GT_NativeArray_d_T_p__Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalSetNativeData(System.IntPtr @data, System.Int32 @nativeBufferStartIndex, System.Int32 @graphicsBufferStartIndex, System.Int32 @count, System.Int32 @elemSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @nativeBufferStartIndex, @graphicsBufferStartIndex, @count, @elemSize};
            var ___result = RMInternalSetNativeData_IntPtr_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalSetData(System.Array @data, System.Int32 @managedBufferStartIndex, System.Int32 @graphicsBufferStartIndex, System.Int32 @count, System.Int32 @elemSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @managedBufferStartIndex, @graphicsBufferStartIndex, @count, @elemSize};
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


        public virtual System.IntPtr GetNativeBufferPtr()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetNativeBufferPtr.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public unsafe virtual void* BeginBufferWrite(System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@offset, @size};
            var ___result = RMBeginBufferWrite_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (void*)Pointer.Unbox(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> LockBufferForWrite<T>(System.Int32 @bufferStartIndex, System.Int32 @count) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@bufferStartIndex, @count};
            var ___result = RMLockBufferForWrite_GT_Int32_Int32.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>(___result);
        }


        public virtual void EndBufferWrite(System.Int32 @bytesWritten)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytesWritten};
            var ___result = RMEndBufferWrite_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnlockBufferAfterWrite<T>(System.Int32 @countWritten) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@countWritten};
            var ___result = RMUnlockBufferAfterWrite_GT_Int32.Invoke(___genericsType, ___parameters);

            
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


        public static void CopyCountCC(UnityEngine.ComputeBuffer @src, UnityEngine.ComputeBuffer @dst, System.Int32 @dstOffsetBytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst, @dstOffsetBytes};
            var ___result = RMCopyCountCC_ComputeBuffer_ComputeBuffer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void CopyCountGC(UnityEngine.GraphicsBuffer @src, UnityEngine.ComputeBuffer @dst, System.Int32 @dstOffsetBytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst, @dstOffsetBytes};
            var ___result = RMCopyCountGC_GraphicsBuffer_ComputeBuffer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void CopyCountCG(UnityEngine.ComputeBuffer @src, UnityEngine.GraphicsBuffer @dst, System.Int32 @dstOffsetBytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst, @dstOffsetBytes};
            var ___result = RMCopyCountCG_ComputeBuffer_GraphicsBuffer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void CopyCountGG(UnityEngine.GraphicsBuffer @src, UnityEngine.GraphicsBuffer @dst, System.Int32 @dstOffsetBytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst, @dstOffsetBytes};
            var ___result = RMCopyCountGG_GraphicsBuffer_GraphicsBuffer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void CopyCount(UnityEngine.ComputeBuffer @src, UnityEngine.ComputeBuffer @dst, System.Int32 @dstOffsetBytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst, @dstOffsetBytes};
            var ___result = RMCopyCount_ComputeBuffer_ComputeBuffer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void CopyCount(UnityEngine.GraphicsBuffer @src, UnityEngine.ComputeBuffer @dst, System.Int32 @dstOffsetBytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst, @dstOffsetBytes};
            var ___result = RMCopyCount_GraphicsBuffer_ComputeBuffer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void CopyCount(UnityEngine.ComputeBuffer @src, UnityEngine.GraphicsBuffer @dst, System.Int32 @dstOffsetBytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst, @dstOffsetBytes};
            var ___result = RMCopyCount_ComputeBuffer_GraphicsBuffer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void CopyCount(UnityEngine.GraphicsBuffer @src, UnityEngine.GraphicsBuffer @dst, System.Int32 @dstOffsetBytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst, @dstOffsetBytes};
            var ___result = RMCopyCount_GraphicsBuffer_GraphicsBuffer_Int32.Invoke(___genericsType, ___parameters);

            
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


        public virtual void get_bufferHandle_Injected(out UnityEngine.GraphicsBufferHandle @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_bufferHandle_Injected_Out_GraphicsBufferHandle.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.GraphicsBufferHandle)___parameters[0];

            
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
