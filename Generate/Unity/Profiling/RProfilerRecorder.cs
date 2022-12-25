using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnity.RProfiling
{
	/// <summary>
	/// Unity.Profiling.ProfilerRecorder
	/// </summary>
    public partial class RProfilerRecorder : RMember //
    {

		/// <summary>
		/// System.UInt64 handle
		/// </summary>
		protected RField r_handle;
		public virtual RField Rhandle
		{
			get
			{
				if(r_handle == null)
				{
					r_handle = new(this, "handle");
					r_handle.SetBelong(this.instance);
				}
				return r_handle;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerRecorderOptions SharedRecorder
		/// </summary>
		protected static RField r_SharedRecorder;
		public static RField RSharedRecorder
		{
			get
			{
				if(r_SharedRecorder == null)
				{
					r_SharedRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "SharedRecorder");
					r_SharedRecorder.SetBelong(null);
				}
				return r_SharedRecorder;
			}
		}

		/// <summary>
		/// Boolean Valid
		/// </summary>
		protected RProperty r_Valid;
		public virtual RProperty RValid
		{
			get
			{
				if(r_Valid == null)
				{
					r_Valid = new(this, "Valid", -1);
					r_Valid.SetBelong(this.instance);
				}
				return r_Valid;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.ProfilerMarkerDataType DataType
		/// </summary>
		protected RProperty r_DataType;
		public virtual RProperty RDataType
		{
			get
			{
				if(r_DataType == null)
				{
					r_DataType = new(this, "DataType", -1);
					r_DataType.SetBelong(this.instance);
				}
				return r_DataType;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarkerDataUnit UnitType
		/// </summary>
		protected RProperty r_UnitType;
		public virtual RProperty RUnitType
		{
			get
			{
				if(r_UnitType == null)
				{
					r_UnitType = new(this, "UnitType", -1);
					r_UnitType.SetBelong(this.instance);
				}
				return r_UnitType;
			}
		}

		/// <summary>
		/// Int64 CurrentValue
		/// </summary>
		protected RProperty r_CurrentValue;
		public virtual RProperty RCurrentValue
		{
			get
			{
				if(r_CurrentValue == null)
				{
					r_CurrentValue = new(this, "CurrentValue", -1);
					r_CurrentValue.SetBelong(this.instance);
				}
				return r_CurrentValue;
			}
		}

		/// <summary>
		/// Double CurrentValueAsDouble
		/// </summary>
		protected RProperty r_CurrentValueAsDouble;
		public virtual RProperty RCurrentValueAsDouble
		{
			get
			{
				if(r_CurrentValueAsDouble == null)
				{
					r_CurrentValueAsDouble = new(this, "CurrentValueAsDouble", -1);
					r_CurrentValueAsDouble.SetBelong(this.instance);
				}
				return r_CurrentValueAsDouble;
			}
		}

		/// <summary>
		/// Int64 LastValue
		/// </summary>
		protected RProperty r_LastValue;
		public virtual RProperty RLastValue
		{
			get
			{
				if(r_LastValue == null)
				{
					r_LastValue = new(this, "LastValue", -1);
					r_LastValue.SetBelong(this.instance);
				}
				return r_LastValue;
			}
		}

		/// <summary>
		/// Double LastValueAsDouble
		/// </summary>
		protected RProperty r_LastValueAsDouble;
		public virtual RProperty RLastValueAsDouble
		{
			get
			{
				if(r_LastValueAsDouble == null)
				{
					r_LastValueAsDouble = new(this, "LastValueAsDouble", -1);
					r_LastValueAsDouble.SetBelong(this.instance);
				}
				return r_LastValueAsDouble;
			}
		}

		/// <summary>
		/// Int32 Capacity
		/// </summary>
		protected RProperty r_Capacity;
		public virtual RProperty RCapacity
		{
			get
			{
				if(r_Capacity == null)
				{
					r_Capacity = new(this, "Capacity", -1);
					r_Capacity.SetBelong(this.instance);
				}
				return r_Capacity;
			}
		}

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected RProperty r_Count;
		public virtual RProperty RCount
		{
			get
			{
				if(r_Count == null)
				{
					r_Count = new(this, "Count", -1);
					r_Count.SetBelong(this.instance);
				}
				return r_Count;
			}
		}

		/// <summary>
		/// Boolean IsRunning
		/// </summary>
		protected RProperty r_IsRunning;
		public virtual RProperty RIsRunning
		{
			get
			{
				if(r_IsRunning == null)
				{
					r_IsRunning = new(this, "IsRunning", -1);
					r_IsRunning.SetBelong(this.instance);
				}
				return r_IsRunning;
			}
		}

		/// <summary>
		/// Boolean WrappedAround
		/// </summary>
		protected RProperty r_WrappedAround;
		public virtual RProperty RWrappedAround
		{
			get
			{
				if(r_WrappedAround == null)
				{
					r_WrappedAround = new(this, "WrappedAround", -1);
					r_WrappedAround.SetBelong(this.instance);
				}
				return r_WrappedAround;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerRecorder StartNew(Unity.Profiling.ProfilerCategory, System.String, Int32, Unity.Profiling.ProfilerRecorderOptions)
		/// </summary>
		protected static RMethod r_RStartNew_ProfilerCategory_String_Int32_ProfilerRecorderOptions;
		public static RMethod RStartNew_ProfilerCategory_String_Int32_ProfilerRecorderOptions
		{
			get
			{
				if(r_RStartNew_ProfilerCategory_String_Int32_ProfilerRecorderOptions == null)
				{
					r_RStartNew_ProfilerCategory_String_Int32_ProfilerRecorderOptions = new(typeof(Unity.Profiling.ProfilerRecorder), "StartNew", 0, typeof(Unity.Profiling.ProfilerCategory), typeof(System.String), typeof(System.Int32), typeof(Unity.Profiling.ProfilerRecorderOptions));
					r_RStartNew_ProfilerCategory_String_Int32_ProfilerRecorderOptions.SetBelong(null);
				}
				return r_RStartNew_ProfilerCategory_String_Int32_ProfilerRecorderOptions;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerRecorder StartNew(Unity.Profiling.ProfilerMarker, Int32, Unity.Profiling.ProfilerRecorderOptions)
		/// </summary>
		protected static RMethod r_RStartNew_ProfilerMarker_Int32_ProfilerRecorderOptions;
		public static RMethod RStartNew_ProfilerMarker_Int32_ProfilerRecorderOptions
		{
			get
			{
				if(r_RStartNew_ProfilerMarker_Int32_ProfilerRecorderOptions == null)
				{
					r_RStartNew_ProfilerMarker_Int32_ProfilerRecorderOptions = new(typeof(Unity.Profiling.ProfilerRecorder), "StartNew", 0, typeof(Unity.Profiling.ProfilerMarker), typeof(System.Int32), typeof(Unity.Profiling.ProfilerRecorderOptions));
					r_RStartNew_ProfilerMarker_Int32_ProfilerRecorderOptions.SetBelong(null);
				}
				return r_RStartNew_ProfilerMarker_Int32_ProfilerRecorderOptions;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerRecorder StartNew()
		/// </summary>
		protected static RMethod r_RStartNew;
		public static RMethod RStartNew
		{
			get
			{
				if(r_RStartNew == null)
				{
					r_RStartNew = new(typeof(Unity.Profiling.ProfilerRecorder), "StartNew", 0);
					r_RStartNew.SetBelong(null);
				}
				return r_RStartNew;
			}
		}

		/// <summary>
		/// Void Start()
		/// </summary>
		protected RMethod r_RStart;
		public virtual RMethod RStart
		{
			get
			{
				if(r_RStart == null)
				{
					r_RStart = new(this, "Start", 0);
					r_RStart.SetBelong(this.instance);
				}
				return r_RStart;
			}
		}

		/// <summary>
		/// Void Stop()
		/// </summary>
		protected RMethod r_RStop;
		public virtual RMethod RStop
		{
			get
			{
				if(r_RStop == null)
				{
					r_RStop = new(this, "Stop", 0);
					r_RStop.SetBelong(this.instance);
				}
				return r_RStop;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_RReset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_RReset == null)
				{
					r_RReset = new(this, "Reset", 0);
					r_RReset.SetBelong(this.instance);
				}
				return r_RReset;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerRecorderSample GetSample(Int32)
		/// </summary>
		protected RMethod r_RGetSample_Int32;
		public virtual RMethod RGetSample_Int32
		{
			get
			{
				if(r_RGetSample_Int32 == null)
				{
					r_RGetSample_Int32 = new(this, "GetSample", 0, typeof(System.Int32));
					r_RGetSample_Int32.SetBelong(this.instance);
				}
				return r_RGetSample_Int32;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Collections.Generic.List`1[Unity.Profiling.ProfilerRecorderSample], Boolean)
		/// </summary>
		protected RMethod r_RCopyTo_List_d_ProfilerRecorderSample_p__Boolean;
		public virtual RMethod RCopyTo_List_d_ProfilerRecorderSample_p__Boolean
		{
			get
			{
				if(r_RCopyTo_List_d_ProfilerRecorderSample_p__Boolean == null)
				{
					r_RCopyTo_List_d_ProfilerRecorderSample_p__Boolean = new(this, "CopyTo", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(Unity.Profiling.ProfilerRecorderSample)), typeof(System.Boolean));
					r_RCopyTo_List_d_ProfilerRecorderSample_p__Boolean.SetBelong(this.instance);
				}
				return r_RCopyTo_List_d_ProfilerRecorderSample_p__Boolean;
			}
		}

		/// <summary>
		/// Int32 CopyTo(Unity.Profiling.ProfilerRecorderSample*, Int32, Boolean)
		/// </summary>
		protected RMethod r_RCopyTo_ProfilerRecorderSamplePointer_Int32_Boolean;
		public virtual RMethod RCopyTo_ProfilerRecorderSamplePointer_Int32_Boolean
		{
			get
			{
				if(r_RCopyTo_ProfilerRecorderSamplePointer_Int32_Boolean == null)
				{
					r_RCopyTo_ProfilerRecorderSamplePointer_Int32_Boolean = new(this, "CopyTo", 0, typeof(Unity.Profiling.ProfilerRecorderSample).MakePointerType(), typeof(System.Int32), typeof(System.Boolean));
					r_RCopyTo_ProfilerRecorderSamplePointer_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RCopyTo_ProfilerRecorderSamplePointer_Int32_Boolean;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerRecorderSample[] ToArray()
		/// </summary>
		protected RMethod r_RToArray;
		public virtual RMethod RToArray
		{
			get
			{
				if(r_RToArray == null)
				{
					r_RToArray = new(this, "ToArray", 0);
					r_RToArray.SetBelong(this.instance);
				}
				return r_RToArray;
			}
		}

		/// <summary>
		/// Void FilterToCurrentThread()
		/// </summary>
		protected RMethod r_RFilterToCurrentThread;
		public virtual RMethod RFilterToCurrentThread
		{
			get
			{
				if(r_RFilterToCurrentThread == null)
				{
					r_RFilterToCurrentThread = new(this, "FilterToCurrentThread", 0);
					r_RFilterToCurrentThread.SetBelong(this.instance);
				}
				return r_RFilterToCurrentThread;
			}
		}

		/// <summary>
		/// Void CollectFromAllThreads()
		/// </summary>
		protected RMethod r_RCollectFromAllThreads;
		public virtual RMethod RCollectFromAllThreads
		{
			get
			{
				if(r_RCollectFromAllThreads == null)
				{
					r_RCollectFromAllThreads = new(this, "CollectFromAllThreads", 0);
					r_RCollectFromAllThreads.SetBelong(this.instance);
				}
				return r_RCollectFromAllThreads;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerRecorder Create(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle, Int32, Unity.Profiling.ProfilerRecorderOptions)
		/// </summary>
		protected static RMethod r_RCreate_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions;
		public static RMethod RCreate_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions
		{
			get
			{
				if(r_RCreate_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions == null)
				{
					r_RCreate_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions = new(typeof(Unity.Profiling.ProfilerRecorder), "Create", 0, typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), typeof(System.Int32), typeof(Unity.Profiling.ProfilerRecorderOptions));
					r_RCreate_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions.SetBelong(null);
				}
				return r_RCreate_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions;
			}
		}

		/// <summary>
		/// Void Control(Unity.Profiling.ProfilerRecorder, ControlOptions)
		/// </summary>
		protected static RMethod r_RControl_ProfilerRecorder_ControlOptions;
		public static RMethod RControl_ProfilerRecorder_ControlOptions
		{
			get
			{
				if(r_RControl_ProfilerRecorder_ControlOptions == null)
				{
					r_RControl_ProfilerRecorder_ControlOptions = new(typeof(Unity.Profiling.ProfilerRecorder), "Control", 0, typeof(Unity.Profiling.ProfilerRecorder),  ReleactionUtils.GetType("Unity.Profiling.ProfilerRecorder+ControlOptions"));
					r_RControl_ProfilerRecorder_ControlOptions.SetBelong(null);
				}
				return r_RControl_ProfilerRecorder_ControlOptions;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarkerDataUnit GetValueUnitType(Unity.Profiling.ProfilerRecorder)
		/// </summary>
		protected static RMethod r_RGetValueUnitType_ProfilerRecorder;
		public static RMethod RGetValueUnitType_ProfilerRecorder
		{
			get
			{
				if(r_RGetValueUnitType_ProfilerRecorder == null)
				{
					r_RGetValueUnitType_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetValueUnitType", 0, typeof(Unity.Profiling.ProfilerRecorder));
					r_RGetValueUnitType_ProfilerRecorder.SetBelong(null);
				}
				return r_RGetValueUnitType_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.ProfilerMarkerDataType GetValueDataType(Unity.Profiling.ProfilerRecorder)
		/// </summary>
		protected static RMethod r_RGetValueDataType_ProfilerRecorder;
		public static RMethod RGetValueDataType_ProfilerRecorder
		{
			get
			{
				if(r_RGetValueDataType_ProfilerRecorder == null)
				{
					r_RGetValueDataType_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetValueDataType", 0, typeof(Unity.Profiling.ProfilerRecorder));
					r_RGetValueDataType_ProfilerRecorder.SetBelong(null);
				}
				return r_RGetValueDataType_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Int64 GetCurrentValue(Unity.Profiling.ProfilerRecorder)
		/// </summary>
		protected static RMethod r_RGetCurrentValue_ProfilerRecorder;
		public static RMethod RGetCurrentValue_ProfilerRecorder
		{
			get
			{
				if(r_RGetCurrentValue_ProfilerRecorder == null)
				{
					r_RGetCurrentValue_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetCurrentValue", 0, typeof(Unity.Profiling.ProfilerRecorder));
					r_RGetCurrentValue_ProfilerRecorder.SetBelong(null);
				}
				return r_RGetCurrentValue_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Double GetCurrentValueAsDouble(Unity.Profiling.ProfilerRecorder)
		/// </summary>
		protected static RMethod r_RGetCurrentValueAsDouble_ProfilerRecorder;
		public static RMethod RGetCurrentValueAsDouble_ProfilerRecorder
		{
			get
			{
				if(r_RGetCurrentValueAsDouble_ProfilerRecorder == null)
				{
					r_RGetCurrentValueAsDouble_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetCurrentValueAsDouble", 0, typeof(Unity.Profiling.ProfilerRecorder));
					r_RGetCurrentValueAsDouble_ProfilerRecorder.SetBelong(null);
				}
				return r_RGetCurrentValueAsDouble_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Int64 GetLastValue(Unity.Profiling.ProfilerRecorder)
		/// </summary>
		protected static RMethod r_RGetLastValue_ProfilerRecorder;
		public static RMethod RGetLastValue_ProfilerRecorder
		{
			get
			{
				if(r_RGetLastValue_ProfilerRecorder == null)
				{
					r_RGetLastValue_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetLastValue", 0, typeof(Unity.Profiling.ProfilerRecorder));
					r_RGetLastValue_ProfilerRecorder.SetBelong(null);
				}
				return r_RGetLastValue_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Double GetLastValueAsDouble(Unity.Profiling.ProfilerRecorder)
		/// </summary>
		protected static RMethod r_RGetLastValueAsDouble_ProfilerRecorder;
		public static RMethod RGetLastValueAsDouble_ProfilerRecorder
		{
			get
			{
				if(r_RGetLastValueAsDouble_ProfilerRecorder == null)
				{
					r_RGetLastValueAsDouble_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetLastValueAsDouble", 0, typeof(Unity.Profiling.ProfilerRecorder));
					r_RGetLastValueAsDouble_ProfilerRecorder.SetBelong(null);
				}
				return r_RGetLastValueAsDouble_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Int32 GetCount(Unity.Profiling.ProfilerRecorder, CountOptions)
		/// </summary>
		protected static RMethod r_RGetCount_ProfilerRecorder_CountOptions;
		public static RMethod RGetCount_ProfilerRecorder_CountOptions
		{
			get
			{
				if(r_RGetCount_ProfilerRecorder_CountOptions == null)
				{
					r_RGetCount_ProfilerRecorder_CountOptions = new(typeof(Unity.Profiling.ProfilerRecorder), "GetCount", 0, typeof(Unity.Profiling.ProfilerRecorder),  ReleactionUtils.GetType("Unity.Profiling.ProfilerRecorder+CountOptions"));
					r_RGetCount_ProfilerRecorder_CountOptions.SetBelong(null);
				}
				return r_RGetCount_ProfilerRecorder_CountOptions;
			}
		}

		/// <summary>
		/// Boolean GetValid(Unity.Profiling.ProfilerRecorder)
		/// </summary>
		protected static RMethod r_RGetValid_ProfilerRecorder;
		public static RMethod RGetValid_ProfilerRecorder
		{
			get
			{
				if(r_RGetValid_ProfilerRecorder == null)
				{
					r_RGetValid_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetValid", 0, typeof(Unity.Profiling.ProfilerRecorder));
					r_RGetValid_ProfilerRecorder.SetBelong(null);
				}
				return r_RGetValid_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Boolean GetWrapped(Unity.Profiling.ProfilerRecorder)
		/// </summary>
		protected static RMethod r_RGetWrapped_ProfilerRecorder;
		public static RMethod RGetWrapped_ProfilerRecorder
		{
			get
			{
				if(r_RGetWrapped_ProfilerRecorder == null)
				{
					r_RGetWrapped_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetWrapped", 0, typeof(Unity.Profiling.ProfilerRecorder));
					r_RGetWrapped_ProfilerRecorder.SetBelong(null);
				}
				return r_RGetWrapped_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Boolean GetRunning(Unity.Profiling.ProfilerRecorder)
		/// </summary>
		protected static RMethod r_RGetRunning_ProfilerRecorder;
		public static RMethod RGetRunning_ProfilerRecorder
		{
			get
			{
				if(r_RGetRunning_ProfilerRecorder == null)
				{
					r_RGetRunning_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetRunning", 0, typeof(Unity.Profiling.ProfilerRecorder));
					r_RGetRunning_ProfilerRecorder.SetBelong(null);
				}
				return r_RGetRunning_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerRecorderSample GetSampleInternal(Unity.Profiling.ProfilerRecorder, Int32)
		/// </summary>
		protected static RMethod r_RGetSampleInternal_ProfilerRecorder_Int32;
		public static RMethod RGetSampleInternal_ProfilerRecorder_Int32
		{
			get
			{
				if(r_RGetSampleInternal_ProfilerRecorder_Int32 == null)
				{
					r_RGetSampleInternal_ProfilerRecorder_Int32 = new(typeof(Unity.Profiling.ProfilerRecorder), "GetSampleInternal", 0, typeof(Unity.Profiling.ProfilerRecorder), typeof(System.Int32));
					r_RGetSampleInternal_ProfilerRecorder_Int32.SetBelong(null);
				}
				return r_RGetSampleInternal_ProfilerRecorder_Int32;
			}
		}

		/// <summary>
		/// Void CopyTo_List(Unity.Profiling.ProfilerRecorder, System.Collections.Generic.List`1[Unity.Profiling.ProfilerRecorderSample], Boolean)
		/// </summary>
		protected static RMethod r_RCopyTo_List_ProfilerRecorder_List_d_ProfilerRecorderSample_p__Boolean;
		public static RMethod RCopyTo_List_ProfilerRecorder_List_d_ProfilerRecorderSample_p__Boolean
		{
			get
			{
				if(r_RCopyTo_List_ProfilerRecorder_List_d_ProfilerRecorderSample_p__Boolean == null)
				{
					r_RCopyTo_List_ProfilerRecorder_List_d_ProfilerRecorderSample_p__Boolean = new(typeof(Unity.Profiling.ProfilerRecorder), "CopyTo_List", 0, typeof(Unity.Profiling.ProfilerRecorder), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(Unity.Profiling.ProfilerRecorderSample)), typeof(System.Boolean));
					r_RCopyTo_List_ProfilerRecorder_List_d_ProfilerRecorderSample_p__Boolean.SetBelong(null);
				}
				return r_RCopyTo_List_ProfilerRecorder_List_d_ProfilerRecorderSample_p__Boolean;
			}
		}

		/// <summary>
		/// Int32 CopyTo_Pointer(Unity.Profiling.ProfilerRecorder, Unity.Profiling.ProfilerRecorderSample*, Int32, Boolean)
		/// </summary>
		protected static RMethod r_RCopyTo_Pointer_ProfilerRecorder_ProfilerRecorderSamplePointer_Int32_Boolean;
		public static RMethod RCopyTo_Pointer_ProfilerRecorder_ProfilerRecorderSamplePointer_Int32_Boolean
		{
			get
			{
				if(r_RCopyTo_Pointer_ProfilerRecorder_ProfilerRecorderSamplePointer_Int32_Boolean == null)
				{
					r_RCopyTo_Pointer_ProfilerRecorder_ProfilerRecorderSamplePointer_Int32_Boolean = new(typeof(Unity.Profiling.ProfilerRecorder), "CopyTo_Pointer", 0, typeof(Unity.Profiling.ProfilerRecorder), typeof(Unity.Profiling.ProfilerRecorderSample).MakePointerType(), typeof(System.Int32), typeof(System.Boolean));
					r_RCopyTo_Pointer_ProfilerRecorder_ProfilerRecorderSamplePointer_Int32_Boolean.SetBelong(null);
				}
				return r_RCopyTo_Pointer_ProfilerRecorder_ProfilerRecorderSamplePointer_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_RDispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_RDispose == null)
				{
					r_RDispose = new(this, "Dispose", 0);
					r_RDispose.SetBelong(this.instance);
				}
				return r_RDispose;
			}
		}

		/// <summary>
		/// Void CheckInitializedWithParamsAndThrow(Unity.Profiling.ProfilerRecorderSample*)
		/// </summary>
		protected RMethod r_RCheckInitializedWithParamsAndThrow_ProfilerRecorderSamplePointer;
		public virtual RMethod RCheckInitializedWithParamsAndThrow_ProfilerRecorderSamplePointer
		{
			get
			{
				if(r_RCheckInitializedWithParamsAndThrow_ProfilerRecorderSamplePointer == null)
				{
					r_RCheckInitializedWithParamsAndThrow_ProfilerRecorderSamplePointer = new(this, "CheckInitializedWithParamsAndThrow", 0, typeof(Unity.Profiling.ProfilerRecorderSample).MakePointerType());
					r_RCheckInitializedWithParamsAndThrow_ProfilerRecorderSamplePointer.SetBelong(this.instance);
				}
				return r_RCheckInitializedWithParamsAndThrow_ProfilerRecorderSamplePointer;
			}
		}

		/// <summary>
		/// Void CheckInitializedAndThrow()
		/// </summary>
		protected RMethod r_RCheckInitializedAndThrow;
		public virtual RMethod RCheckInitializedAndThrow
		{
			get
			{
				if(r_RCheckInitializedAndThrow == null)
				{
					r_RCheckInitializedAndThrow = new(this, "CheckInitializedAndThrow", 0);
					r_RCheckInitializedAndThrow.SetBelong(this.instance);
				}
				return r_RCheckInitializedAndThrow;
			}
		}

		/// <summary>
		/// Void Create_Injected(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle ByRef, Int32, Unity.Profiling.ProfilerRecorderOptions, Unity.Profiling.ProfilerRecorder ByRef)
		/// </summary>
		protected static RMethod r_RCreate_Injected_Ref_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_Out_ProfilerRecorder;
		public static RMethod RCreate_Injected_Ref_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_Out_ProfilerRecorder
		{
			get
			{
				if(r_RCreate_Injected_Ref_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_Out_ProfilerRecorder == null)
				{
					r_RCreate_Injected_Ref_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_Out_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "Create_Injected", 0, typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle).MakeByRefType(), typeof(System.Int32), typeof(Unity.Profiling.ProfilerRecorderOptions), typeof(Unity.Profiling.ProfilerRecorder).MakeByRefType());
					r_RCreate_Injected_Ref_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_Out_ProfilerRecorder.SetBelong(null);
				}
				return r_RCreate_Injected_Ref_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_Out_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Void Control_Injected(Unity.Profiling.ProfilerRecorder ByRef, ControlOptions)
		/// </summary>
		protected static RMethod r_RControl_Injected_Ref_ProfilerRecorder_ControlOptions;
		public static RMethod RControl_Injected_Ref_ProfilerRecorder_ControlOptions
		{
			get
			{
				if(r_RControl_Injected_Ref_ProfilerRecorder_ControlOptions == null)
				{
					r_RControl_Injected_Ref_ProfilerRecorder_ControlOptions = new(typeof(Unity.Profiling.ProfilerRecorder), "Control_Injected", 0, typeof(Unity.Profiling.ProfilerRecorder).MakeByRefType(),  ReleactionUtils.GetType("Unity.Profiling.ProfilerRecorder+ControlOptions"));
					r_RControl_Injected_Ref_ProfilerRecorder_ControlOptions.SetBelong(null);
				}
				return r_RControl_Injected_Ref_ProfilerRecorder_ControlOptions;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarkerDataUnit GetValueUnitType_Injected(Unity.Profiling.ProfilerRecorder ByRef)
		/// </summary>
		protected static RMethod r_RGetValueUnitType_Injected_Ref_ProfilerRecorder;
		public static RMethod RGetValueUnitType_Injected_Ref_ProfilerRecorder
		{
			get
			{
				if(r_RGetValueUnitType_Injected_Ref_ProfilerRecorder == null)
				{
					r_RGetValueUnitType_Injected_Ref_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetValueUnitType_Injected", 0, typeof(Unity.Profiling.ProfilerRecorder).MakeByRefType());
					r_RGetValueUnitType_Injected_Ref_ProfilerRecorder.SetBelong(null);
				}
				return r_RGetValueUnitType_Injected_Ref_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.ProfilerMarkerDataType GetValueDataType_Injected(Unity.Profiling.ProfilerRecorder ByRef)
		/// </summary>
		protected static RMethod r_RGetValueDataType_Injected_Ref_ProfilerRecorder;
		public static RMethod RGetValueDataType_Injected_Ref_ProfilerRecorder
		{
			get
			{
				if(r_RGetValueDataType_Injected_Ref_ProfilerRecorder == null)
				{
					r_RGetValueDataType_Injected_Ref_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetValueDataType_Injected", 0, typeof(Unity.Profiling.ProfilerRecorder).MakeByRefType());
					r_RGetValueDataType_Injected_Ref_ProfilerRecorder.SetBelong(null);
				}
				return r_RGetValueDataType_Injected_Ref_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Int64 GetCurrentValue_Injected(Unity.Profiling.ProfilerRecorder ByRef)
		/// </summary>
		protected static RMethod r_RGetCurrentValue_Injected_Ref_ProfilerRecorder;
		public static RMethod RGetCurrentValue_Injected_Ref_ProfilerRecorder
		{
			get
			{
				if(r_RGetCurrentValue_Injected_Ref_ProfilerRecorder == null)
				{
					r_RGetCurrentValue_Injected_Ref_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetCurrentValue_Injected", 0, typeof(Unity.Profiling.ProfilerRecorder).MakeByRefType());
					r_RGetCurrentValue_Injected_Ref_ProfilerRecorder.SetBelong(null);
				}
				return r_RGetCurrentValue_Injected_Ref_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Double GetCurrentValueAsDouble_Injected(Unity.Profiling.ProfilerRecorder ByRef)
		/// </summary>
		protected static RMethod r_RGetCurrentValueAsDouble_Injected_Ref_ProfilerRecorder;
		public static RMethod RGetCurrentValueAsDouble_Injected_Ref_ProfilerRecorder
		{
			get
			{
				if(r_RGetCurrentValueAsDouble_Injected_Ref_ProfilerRecorder == null)
				{
					r_RGetCurrentValueAsDouble_Injected_Ref_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetCurrentValueAsDouble_Injected", 0, typeof(Unity.Profiling.ProfilerRecorder).MakeByRefType());
					r_RGetCurrentValueAsDouble_Injected_Ref_ProfilerRecorder.SetBelong(null);
				}
				return r_RGetCurrentValueAsDouble_Injected_Ref_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Int64 GetLastValue_Injected(Unity.Profiling.ProfilerRecorder ByRef)
		/// </summary>
		protected static RMethod r_RGetLastValue_Injected_Ref_ProfilerRecorder;
		public static RMethod RGetLastValue_Injected_Ref_ProfilerRecorder
		{
			get
			{
				if(r_RGetLastValue_Injected_Ref_ProfilerRecorder == null)
				{
					r_RGetLastValue_Injected_Ref_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetLastValue_Injected", 0, typeof(Unity.Profiling.ProfilerRecorder).MakeByRefType());
					r_RGetLastValue_Injected_Ref_ProfilerRecorder.SetBelong(null);
				}
				return r_RGetLastValue_Injected_Ref_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Double GetLastValueAsDouble_Injected(Unity.Profiling.ProfilerRecorder ByRef)
		/// </summary>
		protected static RMethod r_RGetLastValueAsDouble_Injected_Ref_ProfilerRecorder;
		public static RMethod RGetLastValueAsDouble_Injected_Ref_ProfilerRecorder
		{
			get
			{
				if(r_RGetLastValueAsDouble_Injected_Ref_ProfilerRecorder == null)
				{
					r_RGetLastValueAsDouble_Injected_Ref_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetLastValueAsDouble_Injected", 0, typeof(Unity.Profiling.ProfilerRecorder).MakeByRefType());
					r_RGetLastValueAsDouble_Injected_Ref_ProfilerRecorder.SetBelong(null);
				}
				return r_RGetLastValueAsDouble_Injected_Ref_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Int32 GetCount_Injected(Unity.Profiling.ProfilerRecorder ByRef, CountOptions)
		/// </summary>
		protected static RMethod r_RGetCount_Injected_Ref_ProfilerRecorder_CountOptions;
		public static RMethod RGetCount_Injected_Ref_ProfilerRecorder_CountOptions
		{
			get
			{
				if(r_RGetCount_Injected_Ref_ProfilerRecorder_CountOptions == null)
				{
					r_RGetCount_Injected_Ref_ProfilerRecorder_CountOptions = new(typeof(Unity.Profiling.ProfilerRecorder), "GetCount_Injected", 0, typeof(Unity.Profiling.ProfilerRecorder).MakeByRefType(),  ReleactionUtils.GetType("Unity.Profiling.ProfilerRecorder+CountOptions"));
					r_RGetCount_Injected_Ref_ProfilerRecorder_CountOptions.SetBelong(null);
				}
				return r_RGetCount_Injected_Ref_ProfilerRecorder_CountOptions;
			}
		}

		/// <summary>
		/// Boolean GetValid_Injected(Unity.Profiling.ProfilerRecorder ByRef)
		/// </summary>
		protected static RMethod r_RGetValid_Injected_Ref_ProfilerRecorder;
		public static RMethod RGetValid_Injected_Ref_ProfilerRecorder
		{
			get
			{
				if(r_RGetValid_Injected_Ref_ProfilerRecorder == null)
				{
					r_RGetValid_Injected_Ref_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetValid_Injected", 0, typeof(Unity.Profiling.ProfilerRecorder).MakeByRefType());
					r_RGetValid_Injected_Ref_ProfilerRecorder.SetBelong(null);
				}
				return r_RGetValid_Injected_Ref_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Boolean GetWrapped_Injected(Unity.Profiling.ProfilerRecorder ByRef)
		/// </summary>
		protected static RMethod r_RGetWrapped_Injected_Ref_ProfilerRecorder;
		public static RMethod RGetWrapped_Injected_Ref_ProfilerRecorder
		{
			get
			{
				if(r_RGetWrapped_Injected_Ref_ProfilerRecorder == null)
				{
					r_RGetWrapped_Injected_Ref_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetWrapped_Injected", 0, typeof(Unity.Profiling.ProfilerRecorder).MakeByRefType());
					r_RGetWrapped_Injected_Ref_ProfilerRecorder.SetBelong(null);
				}
				return r_RGetWrapped_Injected_Ref_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Boolean GetRunning_Injected(Unity.Profiling.ProfilerRecorder ByRef)
		/// </summary>
		protected static RMethod r_RGetRunning_Injected_Ref_ProfilerRecorder;
		public static RMethod RGetRunning_Injected_Ref_ProfilerRecorder
		{
			get
			{
				if(r_RGetRunning_Injected_Ref_ProfilerRecorder == null)
				{
					r_RGetRunning_Injected_Ref_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetRunning_Injected", 0, typeof(Unity.Profiling.ProfilerRecorder).MakeByRefType());
					r_RGetRunning_Injected_Ref_ProfilerRecorder.SetBelong(null);
				}
				return r_RGetRunning_Injected_Ref_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Void GetSampleInternal_Injected(Unity.Profiling.ProfilerRecorder ByRef, Int32, Unity.Profiling.ProfilerRecorderSample ByRef)
		/// </summary>
		protected static RMethod r_RGetSampleInternal_Injected_Ref_ProfilerRecorder_Int32_Out_ProfilerRecorderSample;
		public static RMethod RGetSampleInternal_Injected_Ref_ProfilerRecorder_Int32_Out_ProfilerRecorderSample
		{
			get
			{
				if(r_RGetSampleInternal_Injected_Ref_ProfilerRecorder_Int32_Out_ProfilerRecorderSample == null)
				{
					r_RGetSampleInternal_Injected_Ref_ProfilerRecorder_Int32_Out_ProfilerRecorderSample = new(typeof(Unity.Profiling.ProfilerRecorder), "GetSampleInternal_Injected", 0, typeof(Unity.Profiling.ProfilerRecorder).MakeByRefType(), typeof(System.Int32), typeof(Unity.Profiling.ProfilerRecorderSample).MakeByRefType());
					r_RGetSampleInternal_Injected_Ref_ProfilerRecorder_Int32_Out_ProfilerRecorderSample.SetBelong(null);
				}
				return r_RGetSampleInternal_Injected_Ref_ProfilerRecorder_Int32_Out_ProfilerRecorderSample;
			}
		}

		/// <summary>
		/// Void CopyTo_List_Injected(Unity.Profiling.ProfilerRecorder ByRef, System.Collections.Generic.List`1[Unity.Profiling.ProfilerRecorderSample], Boolean)
		/// </summary>
		protected static RMethod r_RCopyTo_List_Injected_Ref_ProfilerRecorder_List_d_ProfilerRecorderSample_p__Boolean;
		public static RMethod RCopyTo_List_Injected_Ref_ProfilerRecorder_List_d_ProfilerRecorderSample_p__Boolean
		{
			get
			{
				if(r_RCopyTo_List_Injected_Ref_ProfilerRecorder_List_d_ProfilerRecorderSample_p__Boolean == null)
				{
					r_RCopyTo_List_Injected_Ref_ProfilerRecorder_List_d_ProfilerRecorderSample_p__Boolean = new(typeof(Unity.Profiling.ProfilerRecorder), "CopyTo_List_Injected", 0, typeof(Unity.Profiling.ProfilerRecorder).MakeByRefType(), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(Unity.Profiling.ProfilerRecorderSample)), typeof(System.Boolean));
					r_RCopyTo_List_Injected_Ref_ProfilerRecorder_List_d_ProfilerRecorderSample_p__Boolean.SetBelong(null);
				}
				return r_RCopyTo_List_Injected_Ref_ProfilerRecorder_List_d_ProfilerRecorderSample_p__Boolean;
			}
		}

		/// <summary>
		/// Int32 CopyTo_Pointer_Injected(Unity.Profiling.ProfilerRecorder ByRef, Unity.Profiling.ProfilerRecorderSample*, Int32, Boolean)
		/// </summary>
		protected static RMethod r_RCopyTo_Pointer_Injected_Ref_ProfilerRecorder_ProfilerRecorderSamplePointer_Int32_Boolean;
		public static RMethod RCopyTo_Pointer_Injected_Ref_ProfilerRecorder_ProfilerRecorderSamplePointer_Int32_Boolean
		{
			get
			{
				if(r_RCopyTo_Pointer_Injected_Ref_ProfilerRecorder_ProfilerRecorderSamplePointer_Int32_Boolean == null)
				{
					r_RCopyTo_Pointer_Injected_Ref_ProfilerRecorder_ProfilerRecorderSamplePointer_Int32_Boolean = new(typeof(Unity.Profiling.ProfilerRecorder), "CopyTo_Pointer_Injected", 0, typeof(Unity.Profiling.ProfilerRecorder).MakeByRefType(), typeof(Unity.Profiling.ProfilerRecorderSample).MakePointerType(), typeof(System.Int32), typeof(System.Boolean));
					r_RCopyTo_Pointer_Injected_Ref_ProfilerRecorder_ProfilerRecorderSamplePointer_Int32_Boolean.SetBelong(null);
				}
				return r_RCopyTo_Pointer_Injected_Ref_ProfilerRecorder_ProfilerRecorderSamplePointer_Int32_Boolean;
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


        public RProfilerRecorder() : base("Unity.Profiling.ProfilerRecorder")
        {
        }

        public RProfilerRecorder(System.Object instance) : base("Unity.Profiling.ProfilerRecorder")
		{
            SetInstance(instance);
		}

        public RProfilerRecorder(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RProfilerRecorder(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static Unity.Profiling.ProfilerRecorder StartNew(Unity.Profiling.ProfilerCategory  @category, System.String  @statName, System.Int32  @capacity, Unity.Profiling.ProfilerRecorderOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@category, @statName, @capacity, @options};
            var ___result = RStartNew_ProfilerCategory_String_Int32_ProfilerRecorderOptions.Invoke(___genericsType, ___parameters);

            return (Unity.Profiling.ProfilerRecorder)___result;
        }


        public static Unity.Profiling.ProfilerRecorder StartNew(Unity.Profiling.ProfilerMarker  @marker, System.Int32  @capacity, Unity.Profiling.ProfilerRecorderOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@marker, @capacity, @options};
            var ___result = RStartNew_ProfilerMarker_Int32_ProfilerRecorderOptions.Invoke(___genericsType, ___parameters);

            return (Unity.Profiling.ProfilerRecorder)___result;
        }


        public static Unity.Profiling.ProfilerRecorder StartNew()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStartNew.Invoke(___genericsType, ___parameters);

            return (Unity.Profiling.ProfilerRecorder)___result;
        }


        public virtual void Start()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStart.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Stop()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStop.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Unity.Profiling.ProfilerRecorderSample GetSample(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetSample_Int32.Invoke(___genericsType, ___parameters);

            return (Unity.Profiling.ProfilerRecorderSample)___result;
        }


        public virtual void CopyTo(System.Collections.Generic.List<Unity.Profiling.ProfilerRecorderSample>  @outSamples, System.Boolean  @reset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outSamples, @reset};
            var ___result = RCopyTo_List_d_ProfilerRecorderSample_p__Boolean.Invoke(___genericsType, ___parameters);

            
        }



        public virtual Unity.Profiling.ProfilerRecorderSample[] ToArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToArray.Invoke(___genericsType, ___parameters);

            return (Unity.Profiling.ProfilerRecorderSample[])___result;
        }


        public virtual void FilterToCurrentThread()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFilterToCurrentThread.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CollectFromAllThreads()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCollectFromAllThreads.Invoke(___genericsType, ___parameters);

            
        }


        public static Unity.Profiling.ProfilerRecorder Create(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle  @statHandle, System.Int32  @maxSampleCount, Unity.Profiling.ProfilerRecorderOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@statHandle, @maxSampleCount, @options};
            var ___result = RCreate_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions.Invoke(___genericsType, ___parameters);

            return (Unity.Profiling.ProfilerRecorder)___result;
        }



        public static Unity.Profiling.ProfilerMarkerDataUnit GetValueUnitType(Unity.Profiling.ProfilerRecorder  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetValueUnitType_ProfilerRecorder.Invoke(___genericsType, ___parameters);

            return (Unity.Profiling.ProfilerMarkerDataUnit)___result;
        }


        public static Unity.Profiling.LowLevel.ProfilerMarkerDataType GetValueDataType(Unity.Profiling.ProfilerRecorder  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetValueDataType_ProfilerRecorder.Invoke(___genericsType, ___parameters);

            return (Unity.Profiling.LowLevel.ProfilerMarkerDataType)___result;
        }


        public static System.Int64 GetCurrentValue(Unity.Profiling.ProfilerRecorder  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetCurrentValue_ProfilerRecorder.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public static System.Double GetCurrentValueAsDouble(Unity.Profiling.ProfilerRecorder  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetCurrentValueAsDouble_ProfilerRecorder.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public static System.Int64 GetLastValue(Unity.Profiling.ProfilerRecorder  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetLastValue_ProfilerRecorder.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public static System.Double GetLastValueAsDouble(Unity.Profiling.ProfilerRecorder  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetLastValueAsDouble_ProfilerRecorder.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }



        public static System.Boolean GetValid(Unity.Profiling.ProfilerRecorder  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetValid_ProfilerRecorder.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean GetWrapped(Unity.Profiling.ProfilerRecorder  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetWrapped_ProfilerRecorder.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean GetRunning(Unity.Profiling.ProfilerRecorder  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetRunning_ProfilerRecorder.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static Unity.Profiling.ProfilerRecorderSample GetSampleInternal(Unity.Profiling.ProfilerRecorder  @handle, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @index};
            var ___result = RGetSampleInternal_ProfilerRecorder_Int32.Invoke(___genericsType, ___parameters);

            return (Unity.Profiling.ProfilerRecorderSample)___result;
        }


        public static void CopyTo_List(Unity.Profiling.ProfilerRecorder  @handle, System.Collections.Generic.List<Unity.Profiling.ProfilerRecorderSample>  @outSamples, System.Boolean  @reset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @outSamples, @reset};
            var ___result = RCopyTo_List_ProfilerRecorder_List_d_ProfilerRecorderSample_p__Boolean.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void CheckInitializedAndThrow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckInitializedAndThrow.Invoke(___genericsType, ___parameters);

            
        }


        public static void Create_Injected(ref Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle  @statHandle, System.Int32  @maxSampleCount, Unity.Profiling.ProfilerRecorderOptions  @options, out Unity.Profiling.ProfilerRecorder  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@statHandle, @maxSampleCount, @options, @ret};
            var ___result = RCreate_Injected_Ref_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_Out_ProfilerRecorder.Invoke(___genericsType, ___parameters);
			statHandle = (Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle)___parameters[0];
			ret = (Unity.Profiling.ProfilerRecorder)___parameters[3];

            
        }



        public static Unity.Profiling.ProfilerMarkerDataUnit GetValueUnitType_Injected(ref Unity.Profiling.ProfilerRecorder  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetValueUnitType_Injected_Ref_ProfilerRecorder.Invoke(___genericsType, ___parameters);
			handle = (Unity.Profiling.ProfilerRecorder)___parameters[0];

            return (Unity.Profiling.ProfilerMarkerDataUnit)___result;
        }


        public static Unity.Profiling.LowLevel.ProfilerMarkerDataType GetValueDataType_Injected(ref Unity.Profiling.ProfilerRecorder  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetValueDataType_Injected_Ref_ProfilerRecorder.Invoke(___genericsType, ___parameters);
			handle = (Unity.Profiling.ProfilerRecorder)___parameters[0];

            return (Unity.Profiling.LowLevel.ProfilerMarkerDataType)___result;
        }


        public static System.Int64 GetCurrentValue_Injected(ref Unity.Profiling.ProfilerRecorder  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetCurrentValue_Injected_Ref_ProfilerRecorder.Invoke(___genericsType, ___parameters);
			handle = (Unity.Profiling.ProfilerRecorder)___parameters[0];

            return (System.Int64)___result;
        }


        public static System.Double GetCurrentValueAsDouble_Injected(ref Unity.Profiling.ProfilerRecorder  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetCurrentValueAsDouble_Injected_Ref_ProfilerRecorder.Invoke(___genericsType, ___parameters);
			handle = (Unity.Profiling.ProfilerRecorder)___parameters[0];

            return (System.Double)___result;
        }


        public static System.Int64 GetLastValue_Injected(ref Unity.Profiling.ProfilerRecorder  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetLastValue_Injected_Ref_ProfilerRecorder.Invoke(___genericsType, ___parameters);
			handle = (Unity.Profiling.ProfilerRecorder)___parameters[0];

            return (System.Int64)___result;
        }


        public static System.Double GetLastValueAsDouble_Injected(ref Unity.Profiling.ProfilerRecorder  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetLastValueAsDouble_Injected_Ref_ProfilerRecorder.Invoke(___genericsType, ___parameters);
			handle = (Unity.Profiling.ProfilerRecorder)___parameters[0];

            return (System.Double)___result;
        }



        public static System.Boolean GetValid_Injected(ref Unity.Profiling.ProfilerRecorder  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetValid_Injected_Ref_ProfilerRecorder.Invoke(___genericsType, ___parameters);
			handle = (Unity.Profiling.ProfilerRecorder)___parameters[0];

            return (System.Boolean)___result;
        }


        public static System.Boolean GetWrapped_Injected(ref Unity.Profiling.ProfilerRecorder  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetWrapped_Injected_Ref_ProfilerRecorder.Invoke(___genericsType, ___parameters);
			handle = (Unity.Profiling.ProfilerRecorder)___parameters[0];

            return (System.Boolean)___result;
        }


        public static System.Boolean GetRunning_Injected(ref Unity.Profiling.ProfilerRecorder  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetRunning_Injected_Ref_ProfilerRecorder.Invoke(___genericsType, ___parameters);
			handle = (Unity.Profiling.ProfilerRecorder)___parameters[0];

            return (System.Boolean)___result;
        }


        public static void GetSampleInternal_Injected(ref Unity.Profiling.ProfilerRecorder  @handle, System.Int32  @index, out Unity.Profiling.ProfilerRecorderSample  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @index, @ret};
            var ___result = RGetSampleInternal_Injected_Ref_ProfilerRecorder_Int32_Out_ProfilerRecorderSample.Invoke(___genericsType, ___parameters);
			handle = (Unity.Profiling.ProfilerRecorder)___parameters[0];
			ret = (Unity.Profiling.ProfilerRecorderSample)___parameters[2];

            
        }


        public static void CopyTo_List_Injected(ref Unity.Profiling.ProfilerRecorder  @handle, System.Collections.Generic.List<Unity.Profiling.ProfilerRecorderSample>  @outSamples, System.Boolean  @reset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @outSamples, @reset};
            var ___result = RCopyTo_List_Injected_Ref_ProfilerRecorder_List_d_ProfilerRecorderSample_p__Boolean.Invoke(___genericsType, ___parameters);
			handle = (Unity.Profiling.ProfilerRecorder)___parameters[0];

            
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
