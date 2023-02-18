
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnity.RProfiling
{
	/// <summary>
	/// Unity.Profiling.ProfilerRecorder
	/// </summary>
    public partial class RProfilerRecorder : RMember //
    {

		/// <summary>
		/// System.UInt64 handle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt64 r_Fhandle;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt64 RFhandle
		{
			get
			{
				if(r_Fhandle == null)
				{
					r_Fhandle = new(this, "handle");
				}
				return r_Fhandle;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerRecorderOptions SharedRecorder
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerRecorderOptions r_FSharedRecorder;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerRecorderOptions RFSharedRecorder
		{
			get
			{
				if(r_FSharedRecorder == null)
				{
					r_FSharedRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "SharedRecorder");
				}
				return r_FSharedRecorder;
			}
		}

		/// <summary>
		/// Boolean Valid
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PValid;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPValid
		{
			get
			{
				if(r_PValid == null)
				{
					r_PValid = new(this, "Valid", -1);
				}
				return r_PValid;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.ProfilerMarkerDataType DataType
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnity.RProfiling.RLowLevel.RProfilerMarkerDataType r_PDataType;
		public virtual Hvak.Editor.Refleaction.RUnity.RProfiling.RLowLevel.RProfilerMarkerDataType RPDataType
		{
			get
			{
				if(r_PDataType == null)
				{
					r_PDataType = new(this, "DataType", -1);
				}
				return r_PDataType;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarkerDataUnit UnitType
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarkerDataUnit r_PUnitType;
		public virtual Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarkerDataUnit RPUnitType
		{
			get
			{
				if(r_PUnitType == null)
				{
					r_PUnitType = new(this, "UnitType", -1);
				}
				return r_PUnitType;
			}
		}

		/// <summary>
		/// Int64 CurrentValue
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_PCurrentValue;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RPCurrentValue
		{
			get
			{
				if(r_PCurrentValue == null)
				{
					r_PCurrentValue = new(this, "CurrentValue", -1);
				}
				return r_PCurrentValue;
			}
		}

		/// <summary>
		/// Double CurrentValueAsDouble
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RDouble r_PCurrentValueAsDouble;
		public virtual Hvak.Editor.Refleaction.RSystem.RDouble RPCurrentValueAsDouble
		{
			get
			{
				if(r_PCurrentValueAsDouble == null)
				{
					r_PCurrentValueAsDouble = new(this, "CurrentValueAsDouble", -1);
				}
				return r_PCurrentValueAsDouble;
			}
		}

		/// <summary>
		/// Int64 LastValue
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_PLastValue;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RPLastValue
		{
			get
			{
				if(r_PLastValue == null)
				{
					r_PLastValue = new(this, "LastValue", -1);
				}
				return r_PLastValue;
			}
		}

		/// <summary>
		/// Double LastValueAsDouble
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RDouble r_PLastValueAsDouble;
		public virtual Hvak.Editor.Refleaction.RSystem.RDouble RPLastValueAsDouble
		{
			get
			{
				if(r_PLastValueAsDouble == null)
				{
					r_PLastValueAsDouble = new(this, "LastValueAsDouble", -1);
				}
				return r_PLastValueAsDouble;
			}
		}

		/// <summary>
		/// Int32 Capacity
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PCapacity;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPCapacity
		{
			get
			{
				if(r_PCapacity == null)
				{
					r_PCapacity = new(this, "Capacity", -1);
				}
				return r_PCapacity;
			}
		}

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPCount
		{
			get
			{
				if(r_PCount == null)
				{
					r_PCount = new(this, "Count", -1);
				}
				return r_PCount;
			}
		}

		/// <summary>
		/// Boolean IsRunning
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsRunning;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsRunning
		{
			get
			{
				if(r_PIsRunning == null)
				{
					r_PIsRunning = new(this, "IsRunning", -1);
				}
				return r_PIsRunning;
			}
		}

		/// <summary>
		/// Boolean WrappedAround
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PWrappedAround;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPWrappedAround
		{
			get
			{
				if(r_PWrappedAround == null)
				{
					r_PWrappedAround = new(this, "WrappedAround", -1);
				}
				return r_PWrappedAround;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerRecorder StartNew(Unity.Profiling.ProfilerCategory, System.String, Int32, Unity.Profiling.ProfilerRecorderOptions)
		/// </summary>
		protected static RMethod r_MStartNew_ProfilerCategory_String_Int32_ProfilerRecorderOptions;
		public static RMethod RMStartNew_ProfilerCategory_String_Int32_ProfilerRecorderOptions
		{
			get
			{
				if(r_MStartNew_ProfilerCategory_String_Int32_ProfilerRecorderOptions == null)
				{
					r_MStartNew_ProfilerCategory_String_Int32_ProfilerRecorderOptions = new(typeof(Unity.Profiling.ProfilerRecorder), "StartNew", 0, typeof(Unity.Profiling.ProfilerCategory), typeof(System.String), typeof(System.Int32), typeof(Unity.Profiling.ProfilerRecorderOptions));
				}
				return r_MStartNew_ProfilerCategory_String_Int32_ProfilerRecorderOptions;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerRecorder StartNew(Unity.Profiling.ProfilerMarker, Int32, Unity.Profiling.ProfilerRecorderOptions)
		/// </summary>
		protected static RMethod r_MStartNew_ProfilerMarker_Int32_ProfilerRecorderOptions;
		public static RMethod RMStartNew_ProfilerMarker_Int32_ProfilerRecorderOptions
		{
			get
			{
				if(r_MStartNew_ProfilerMarker_Int32_ProfilerRecorderOptions == null)
				{
					r_MStartNew_ProfilerMarker_Int32_ProfilerRecorderOptions = new(typeof(Unity.Profiling.ProfilerRecorder), "StartNew", 0, typeof(Unity.Profiling.ProfilerMarker), typeof(System.Int32), typeof(Unity.Profiling.ProfilerRecorderOptions));
				}
				return r_MStartNew_ProfilerMarker_Int32_ProfilerRecorderOptions;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerRecorder StartNew()
		/// </summary>
		protected static RMethod r_MStartNew;
		public static RMethod RMStartNew
		{
			get
			{
				if(r_MStartNew == null)
				{
					r_MStartNew = new(typeof(Unity.Profiling.ProfilerRecorder), "StartNew", 0);
				}
				return r_MStartNew;
			}
		}

		/// <summary>
		/// Void Start()
		/// </summary>
		protected RMethod r_MStart;
		public virtual RMethod RMStart
		{
			get
			{
				if(r_MStart == null)
				{
					r_MStart = new(this, "Start", 0);
				}
				return r_MStart;
			}
		}

		/// <summary>
		/// Void Stop()
		/// </summary>
		protected RMethod r_MStop;
		public virtual RMethod RMStop
		{
			get
			{
				if(r_MStop == null)
				{
					r_MStop = new(this, "Stop", 0);
				}
				return r_MStop;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_MReset;
		public virtual RMethod RMReset
		{
			get
			{
				if(r_MReset == null)
				{
					r_MReset = new(this, "Reset", 0);
				}
				return r_MReset;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerRecorderSample GetSample(Int32)
		/// </summary>
		protected RMethod r_MGetSample_Int32;
		public virtual RMethod RMGetSample_Int32
		{
			get
			{
				if(r_MGetSample_Int32 == null)
				{
					r_MGetSample_Int32 = new(this, "GetSample", 0, typeof(System.Int32));
				}
				return r_MGetSample_Int32;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Collections.Generic.List`1[Unity.Profiling.ProfilerRecorderSample], Boolean)
		/// </summary>
		protected RMethod r_MCopyTo_List_d_ProfilerRecorderSample_p__Boolean;
		public virtual RMethod RMCopyTo_List_d_ProfilerRecorderSample_p__Boolean
		{
			get
			{
				if(r_MCopyTo_List_d_ProfilerRecorderSample_p__Boolean == null)
				{
					r_MCopyTo_List_d_ProfilerRecorderSample_p__Boolean = new(this, "CopyTo", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(Unity.Profiling.ProfilerRecorderSample)), typeof(System.Boolean));
				}
				return r_MCopyTo_List_d_ProfilerRecorderSample_p__Boolean;
			}
		}

		/// <summary>
		/// Int32 CopyTo(Unity.Profiling.ProfilerRecorderSample*, Int32, Boolean)
		/// </summary>
		protected RMethod r_MCopyTo_ProfilerRecorderSamplePointer_Int32_Boolean;
		public virtual RMethod RMCopyTo_ProfilerRecorderSamplePointer_Int32_Boolean
		{
			get
			{
				if(r_MCopyTo_ProfilerRecorderSamplePointer_Int32_Boolean == null)
				{
					r_MCopyTo_ProfilerRecorderSamplePointer_Int32_Boolean = new(this, "CopyTo", 0, typeof(Unity.Profiling.ProfilerRecorderSample).MakePointerType(), typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MCopyTo_ProfilerRecorderSamplePointer_Int32_Boolean;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerRecorderSample[] ToArray()
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
		/// Void FilterToCurrentThread()
		/// </summary>
		protected RMethod r_MFilterToCurrentThread;
		public virtual RMethod RMFilterToCurrentThread
		{
			get
			{
				if(r_MFilterToCurrentThread == null)
				{
					r_MFilterToCurrentThread = new(this, "FilterToCurrentThread", 0);
				}
				return r_MFilterToCurrentThread;
			}
		}

		/// <summary>
		/// Void CollectFromAllThreads()
		/// </summary>
		protected RMethod r_MCollectFromAllThreads;
		public virtual RMethod RMCollectFromAllThreads
		{
			get
			{
				if(r_MCollectFromAllThreads == null)
				{
					r_MCollectFromAllThreads = new(this, "CollectFromAllThreads", 0);
				}
				return r_MCollectFromAllThreads;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerRecorder Create(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle, Int32, Unity.Profiling.ProfilerRecorderOptions)
		/// </summary>
		protected static RMethod r_MCreate_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions;
		public static RMethod RMCreate_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions
		{
			get
			{
				if(r_MCreate_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions == null)
				{
					r_MCreate_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions = new(typeof(Unity.Profiling.ProfilerRecorder), "Create", 0, typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), typeof(System.Int32), typeof(Unity.Profiling.ProfilerRecorderOptions));
				}
				return r_MCreate_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions;
			}
		}

		/// <summary>
		/// Void Control(Unity.Profiling.ProfilerRecorder, ControlOptions)
		/// </summary>
		protected static RMethod r_MControl_ProfilerRecorder_ControlOptions;
		public static RMethod RMControl_ProfilerRecorder_ControlOptions
		{
			get
			{
				if(r_MControl_ProfilerRecorder_ControlOptions == null)
				{
					r_MControl_ProfilerRecorder_ControlOptions = new(typeof(Unity.Profiling.ProfilerRecorder), "Control", 0, typeof(Unity.Profiling.ProfilerRecorder),  ReflectionUtils.GetType("Unity.Profiling.ProfilerRecorder+ControlOptions"));
				}
				return r_MControl_ProfilerRecorder_ControlOptions;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarkerDataUnit GetValueUnitType(Unity.Profiling.ProfilerRecorder)
		/// </summary>
		protected static RMethod r_MGetValueUnitType_ProfilerRecorder;
		public static RMethod RMGetValueUnitType_ProfilerRecorder
		{
			get
			{
				if(r_MGetValueUnitType_ProfilerRecorder == null)
				{
					r_MGetValueUnitType_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetValueUnitType", 0, typeof(Unity.Profiling.ProfilerRecorder));
				}
				return r_MGetValueUnitType_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.ProfilerMarkerDataType GetValueDataType(Unity.Profiling.ProfilerRecorder)
		/// </summary>
		protected static RMethod r_MGetValueDataType_ProfilerRecorder;
		public static RMethod RMGetValueDataType_ProfilerRecorder
		{
			get
			{
				if(r_MGetValueDataType_ProfilerRecorder == null)
				{
					r_MGetValueDataType_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetValueDataType", 0, typeof(Unity.Profiling.ProfilerRecorder));
				}
				return r_MGetValueDataType_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Int64 GetCurrentValue(Unity.Profiling.ProfilerRecorder)
		/// </summary>
		protected static RMethod r_MGetCurrentValue_ProfilerRecorder;
		public static RMethod RMGetCurrentValue_ProfilerRecorder
		{
			get
			{
				if(r_MGetCurrentValue_ProfilerRecorder == null)
				{
					r_MGetCurrentValue_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetCurrentValue", 0, typeof(Unity.Profiling.ProfilerRecorder));
				}
				return r_MGetCurrentValue_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Double GetCurrentValueAsDouble(Unity.Profiling.ProfilerRecorder)
		/// </summary>
		protected static RMethod r_MGetCurrentValueAsDouble_ProfilerRecorder;
		public static RMethod RMGetCurrentValueAsDouble_ProfilerRecorder
		{
			get
			{
				if(r_MGetCurrentValueAsDouble_ProfilerRecorder == null)
				{
					r_MGetCurrentValueAsDouble_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetCurrentValueAsDouble", 0, typeof(Unity.Profiling.ProfilerRecorder));
				}
				return r_MGetCurrentValueAsDouble_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Int64 GetLastValue(Unity.Profiling.ProfilerRecorder)
		/// </summary>
		protected static RMethod r_MGetLastValue_ProfilerRecorder;
		public static RMethod RMGetLastValue_ProfilerRecorder
		{
			get
			{
				if(r_MGetLastValue_ProfilerRecorder == null)
				{
					r_MGetLastValue_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetLastValue", 0, typeof(Unity.Profiling.ProfilerRecorder));
				}
				return r_MGetLastValue_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Double GetLastValueAsDouble(Unity.Profiling.ProfilerRecorder)
		/// </summary>
		protected static RMethod r_MGetLastValueAsDouble_ProfilerRecorder;
		public static RMethod RMGetLastValueAsDouble_ProfilerRecorder
		{
			get
			{
				if(r_MGetLastValueAsDouble_ProfilerRecorder == null)
				{
					r_MGetLastValueAsDouble_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetLastValueAsDouble", 0, typeof(Unity.Profiling.ProfilerRecorder));
				}
				return r_MGetLastValueAsDouble_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Int32 GetCount(Unity.Profiling.ProfilerRecorder, CountOptions)
		/// </summary>
		protected static RMethod r_MGetCount_ProfilerRecorder_CountOptions;
		public static RMethod RMGetCount_ProfilerRecorder_CountOptions
		{
			get
			{
				if(r_MGetCount_ProfilerRecorder_CountOptions == null)
				{
					r_MGetCount_ProfilerRecorder_CountOptions = new(typeof(Unity.Profiling.ProfilerRecorder), "GetCount", 0, typeof(Unity.Profiling.ProfilerRecorder),  ReflectionUtils.GetType("Unity.Profiling.ProfilerRecorder+CountOptions"));
				}
				return r_MGetCount_ProfilerRecorder_CountOptions;
			}
		}

		/// <summary>
		/// Boolean GetValid(Unity.Profiling.ProfilerRecorder)
		/// </summary>
		protected static RMethod r_MGetValid_ProfilerRecorder;
		public static RMethod RMGetValid_ProfilerRecorder
		{
			get
			{
				if(r_MGetValid_ProfilerRecorder == null)
				{
					r_MGetValid_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetValid", 0, typeof(Unity.Profiling.ProfilerRecorder));
				}
				return r_MGetValid_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Boolean GetWrapped(Unity.Profiling.ProfilerRecorder)
		/// </summary>
		protected static RMethod r_MGetWrapped_ProfilerRecorder;
		public static RMethod RMGetWrapped_ProfilerRecorder
		{
			get
			{
				if(r_MGetWrapped_ProfilerRecorder == null)
				{
					r_MGetWrapped_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetWrapped", 0, typeof(Unity.Profiling.ProfilerRecorder));
				}
				return r_MGetWrapped_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Boolean GetRunning(Unity.Profiling.ProfilerRecorder)
		/// </summary>
		protected static RMethod r_MGetRunning_ProfilerRecorder;
		public static RMethod RMGetRunning_ProfilerRecorder
		{
			get
			{
				if(r_MGetRunning_ProfilerRecorder == null)
				{
					r_MGetRunning_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetRunning", 0, typeof(Unity.Profiling.ProfilerRecorder));
				}
				return r_MGetRunning_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerRecorderSample GetSampleInternal(Unity.Profiling.ProfilerRecorder, Int32)
		/// </summary>
		protected static RMethod r_MGetSampleInternal_ProfilerRecorder_Int32;
		public static RMethod RMGetSampleInternal_ProfilerRecorder_Int32
		{
			get
			{
				if(r_MGetSampleInternal_ProfilerRecorder_Int32 == null)
				{
					r_MGetSampleInternal_ProfilerRecorder_Int32 = new(typeof(Unity.Profiling.ProfilerRecorder), "GetSampleInternal", 0, typeof(Unity.Profiling.ProfilerRecorder), typeof(System.Int32));
				}
				return r_MGetSampleInternal_ProfilerRecorder_Int32;
			}
		}

		/// <summary>
		/// Void CopyTo_List(Unity.Profiling.ProfilerRecorder, System.Collections.Generic.List`1[Unity.Profiling.ProfilerRecorderSample], Boolean)
		/// </summary>
		protected static RMethod r_MCopyTo_List_ProfilerRecorder_List_d_ProfilerRecorderSample_p__Boolean;
		public static RMethod RMCopyTo_List_ProfilerRecorder_List_d_ProfilerRecorderSample_p__Boolean
		{
			get
			{
				if(r_MCopyTo_List_ProfilerRecorder_List_d_ProfilerRecorderSample_p__Boolean == null)
				{
					r_MCopyTo_List_ProfilerRecorder_List_d_ProfilerRecorderSample_p__Boolean = new(typeof(Unity.Profiling.ProfilerRecorder), "CopyTo_List", 0, typeof(Unity.Profiling.ProfilerRecorder), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(Unity.Profiling.ProfilerRecorderSample)), typeof(System.Boolean));
				}
				return r_MCopyTo_List_ProfilerRecorder_List_d_ProfilerRecorderSample_p__Boolean;
			}
		}

		/// <summary>
		/// Int32 CopyTo_Pointer(Unity.Profiling.ProfilerRecorder, Unity.Profiling.ProfilerRecorderSample*, Int32, Boolean)
		/// </summary>
		protected static RMethod r_MCopyTo_Pointer_ProfilerRecorder_ProfilerRecorderSamplePointer_Int32_Boolean;
		public static RMethod RMCopyTo_Pointer_ProfilerRecorder_ProfilerRecorderSamplePointer_Int32_Boolean
		{
			get
			{
				if(r_MCopyTo_Pointer_ProfilerRecorder_ProfilerRecorderSamplePointer_Int32_Boolean == null)
				{
					r_MCopyTo_Pointer_ProfilerRecorder_ProfilerRecorderSamplePointer_Int32_Boolean = new(typeof(Unity.Profiling.ProfilerRecorder), "CopyTo_Pointer", 0, typeof(Unity.Profiling.ProfilerRecorder), typeof(Unity.Profiling.ProfilerRecorderSample).MakePointerType(), typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MCopyTo_Pointer_ProfilerRecorder_ProfilerRecorderSamplePointer_Int32_Boolean;
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
		/// Void CheckInitializedWithParamsAndThrow(Unity.Profiling.ProfilerRecorderSample*)
		/// </summary>
		protected RMethod r_MCheckInitializedWithParamsAndThrow_ProfilerRecorderSamplePointer;
		public virtual RMethod RMCheckInitializedWithParamsAndThrow_ProfilerRecorderSamplePointer
		{
			get
			{
				if(r_MCheckInitializedWithParamsAndThrow_ProfilerRecorderSamplePointer == null)
				{
					r_MCheckInitializedWithParamsAndThrow_ProfilerRecorderSamplePointer = new(this, "CheckInitializedWithParamsAndThrow", 0, typeof(Unity.Profiling.ProfilerRecorderSample).MakePointerType());
				}
				return r_MCheckInitializedWithParamsAndThrow_ProfilerRecorderSamplePointer;
			}
		}

		/// <summary>
		/// Void CheckInitializedAndThrow()
		/// </summary>
		protected RMethod r_MCheckInitializedAndThrow;
		public virtual RMethod RMCheckInitializedAndThrow
		{
			get
			{
				if(r_MCheckInitializedAndThrow == null)
				{
					r_MCheckInitializedAndThrow = new(this, "CheckInitializedAndThrow", 0);
				}
				return r_MCheckInitializedAndThrow;
			}
		}

		/// <summary>
		/// Void Create_Injected(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle ByRef, Int32, Unity.Profiling.ProfilerRecorderOptions, Unity.Profiling.ProfilerRecorder ByRef)
		/// </summary>
		protected static RMethod r_MCreate_Injected_Ref_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_Out_ProfilerRecorder;
		public static RMethod RMCreate_Injected_Ref_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_Out_ProfilerRecorder
		{
			get
			{
				if(r_MCreate_Injected_Ref_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_Out_ProfilerRecorder == null)
				{
					r_MCreate_Injected_Ref_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_Out_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "Create_Injected", 0, typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle).MakeByRefType(), typeof(System.Int32), typeof(Unity.Profiling.ProfilerRecorderOptions), typeof(Unity.Profiling.ProfilerRecorder).MakeByRefType());
				}
				return r_MCreate_Injected_Ref_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_Out_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Void Control_Injected(Unity.Profiling.ProfilerRecorder ByRef, ControlOptions)
		/// </summary>
		protected static RMethod r_MControl_Injected_Ref_ProfilerRecorder_ControlOptions;
		public static RMethod RMControl_Injected_Ref_ProfilerRecorder_ControlOptions
		{
			get
			{
				if(r_MControl_Injected_Ref_ProfilerRecorder_ControlOptions == null)
				{
					r_MControl_Injected_Ref_ProfilerRecorder_ControlOptions = new(typeof(Unity.Profiling.ProfilerRecorder), "Control_Injected", 0, typeof(Unity.Profiling.ProfilerRecorder).MakeByRefType(),  ReflectionUtils.GetType("Unity.Profiling.ProfilerRecorder+ControlOptions"));
				}
				return r_MControl_Injected_Ref_ProfilerRecorder_ControlOptions;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarkerDataUnit GetValueUnitType_Injected(Unity.Profiling.ProfilerRecorder ByRef)
		/// </summary>
		protected static RMethod r_MGetValueUnitType_Injected_Ref_ProfilerRecorder;
		public static RMethod RMGetValueUnitType_Injected_Ref_ProfilerRecorder
		{
			get
			{
				if(r_MGetValueUnitType_Injected_Ref_ProfilerRecorder == null)
				{
					r_MGetValueUnitType_Injected_Ref_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetValueUnitType_Injected", 0, typeof(Unity.Profiling.ProfilerRecorder).MakeByRefType());
				}
				return r_MGetValueUnitType_Injected_Ref_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.ProfilerMarkerDataType GetValueDataType_Injected(Unity.Profiling.ProfilerRecorder ByRef)
		/// </summary>
		protected static RMethod r_MGetValueDataType_Injected_Ref_ProfilerRecorder;
		public static RMethod RMGetValueDataType_Injected_Ref_ProfilerRecorder
		{
			get
			{
				if(r_MGetValueDataType_Injected_Ref_ProfilerRecorder == null)
				{
					r_MGetValueDataType_Injected_Ref_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetValueDataType_Injected", 0, typeof(Unity.Profiling.ProfilerRecorder).MakeByRefType());
				}
				return r_MGetValueDataType_Injected_Ref_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Int64 GetCurrentValue_Injected(Unity.Profiling.ProfilerRecorder ByRef)
		/// </summary>
		protected static RMethod r_MGetCurrentValue_Injected_Ref_ProfilerRecorder;
		public static RMethod RMGetCurrentValue_Injected_Ref_ProfilerRecorder
		{
			get
			{
				if(r_MGetCurrentValue_Injected_Ref_ProfilerRecorder == null)
				{
					r_MGetCurrentValue_Injected_Ref_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetCurrentValue_Injected", 0, typeof(Unity.Profiling.ProfilerRecorder).MakeByRefType());
				}
				return r_MGetCurrentValue_Injected_Ref_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Double GetCurrentValueAsDouble_Injected(Unity.Profiling.ProfilerRecorder ByRef)
		/// </summary>
		protected static RMethod r_MGetCurrentValueAsDouble_Injected_Ref_ProfilerRecorder;
		public static RMethod RMGetCurrentValueAsDouble_Injected_Ref_ProfilerRecorder
		{
			get
			{
				if(r_MGetCurrentValueAsDouble_Injected_Ref_ProfilerRecorder == null)
				{
					r_MGetCurrentValueAsDouble_Injected_Ref_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetCurrentValueAsDouble_Injected", 0, typeof(Unity.Profiling.ProfilerRecorder).MakeByRefType());
				}
				return r_MGetCurrentValueAsDouble_Injected_Ref_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Int64 GetLastValue_Injected(Unity.Profiling.ProfilerRecorder ByRef)
		/// </summary>
		protected static RMethod r_MGetLastValue_Injected_Ref_ProfilerRecorder;
		public static RMethod RMGetLastValue_Injected_Ref_ProfilerRecorder
		{
			get
			{
				if(r_MGetLastValue_Injected_Ref_ProfilerRecorder == null)
				{
					r_MGetLastValue_Injected_Ref_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetLastValue_Injected", 0, typeof(Unity.Profiling.ProfilerRecorder).MakeByRefType());
				}
				return r_MGetLastValue_Injected_Ref_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Double GetLastValueAsDouble_Injected(Unity.Profiling.ProfilerRecorder ByRef)
		/// </summary>
		protected static RMethod r_MGetLastValueAsDouble_Injected_Ref_ProfilerRecorder;
		public static RMethod RMGetLastValueAsDouble_Injected_Ref_ProfilerRecorder
		{
			get
			{
				if(r_MGetLastValueAsDouble_Injected_Ref_ProfilerRecorder == null)
				{
					r_MGetLastValueAsDouble_Injected_Ref_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetLastValueAsDouble_Injected", 0, typeof(Unity.Profiling.ProfilerRecorder).MakeByRefType());
				}
				return r_MGetLastValueAsDouble_Injected_Ref_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Int32 GetCount_Injected(Unity.Profiling.ProfilerRecorder ByRef, CountOptions)
		/// </summary>
		protected static RMethod r_MGetCount_Injected_Ref_ProfilerRecorder_CountOptions;
		public static RMethod RMGetCount_Injected_Ref_ProfilerRecorder_CountOptions
		{
			get
			{
				if(r_MGetCount_Injected_Ref_ProfilerRecorder_CountOptions == null)
				{
					r_MGetCount_Injected_Ref_ProfilerRecorder_CountOptions = new(typeof(Unity.Profiling.ProfilerRecorder), "GetCount_Injected", 0, typeof(Unity.Profiling.ProfilerRecorder).MakeByRefType(),  ReflectionUtils.GetType("Unity.Profiling.ProfilerRecorder+CountOptions"));
				}
				return r_MGetCount_Injected_Ref_ProfilerRecorder_CountOptions;
			}
		}

		/// <summary>
		/// Boolean GetValid_Injected(Unity.Profiling.ProfilerRecorder ByRef)
		/// </summary>
		protected static RMethod r_MGetValid_Injected_Ref_ProfilerRecorder;
		public static RMethod RMGetValid_Injected_Ref_ProfilerRecorder
		{
			get
			{
				if(r_MGetValid_Injected_Ref_ProfilerRecorder == null)
				{
					r_MGetValid_Injected_Ref_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetValid_Injected", 0, typeof(Unity.Profiling.ProfilerRecorder).MakeByRefType());
				}
				return r_MGetValid_Injected_Ref_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Boolean GetWrapped_Injected(Unity.Profiling.ProfilerRecorder ByRef)
		/// </summary>
		protected static RMethod r_MGetWrapped_Injected_Ref_ProfilerRecorder;
		public static RMethod RMGetWrapped_Injected_Ref_ProfilerRecorder
		{
			get
			{
				if(r_MGetWrapped_Injected_Ref_ProfilerRecorder == null)
				{
					r_MGetWrapped_Injected_Ref_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetWrapped_Injected", 0, typeof(Unity.Profiling.ProfilerRecorder).MakeByRefType());
				}
				return r_MGetWrapped_Injected_Ref_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Boolean GetRunning_Injected(Unity.Profiling.ProfilerRecorder ByRef)
		/// </summary>
		protected static RMethod r_MGetRunning_Injected_Ref_ProfilerRecorder;
		public static RMethod RMGetRunning_Injected_Ref_ProfilerRecorder
		{
			get
			{
				if(r_MGetRunning_Injected_Ref_ProfilerRecorder == null)
				{
					r_MGetRunning_Injected_Ref_ProfilerRecorder = new(typeof(Unity.Profiling.ProfilerRecorder), "GetRunning_Injected", 0, typeof(Unity.Profiling.ProfilerRecorder).MakeByRefType());
				}
				return r_MGetRunning_Injected_Ref_ProfilerRecorder;
			}
		}

		/// <summary>
		/// Void GetSampleInternal_Injected(Unity.Profiling.ProfilerRecorder ByRef, Int32, Unity.Profiling.ProfilerRecorderSample ByRef)
		/// </summary>
		protected static RMethod r_MGetSampleInternal_Injected_Ref_ProfilerRecorder_Int32_Out_ProfilerRecorderSample;
		public static RMethod RMGetSampleInternal_Injected_Ref_ProfilerRecorder_Int32_Out_ProfilerRecorderSample
		{
			get
			{
				if(r_MGetSampleInternal_Injected_Ref_ProfilerRecorder_Int32_Out_ProfilerRecorderSample == null)
				{
					r_MGetSampleInternal_Injected_Ref_ProfilerRecorder_Int32_Out_ProfilerRecorderSample = new(typeof(Unity.Profiling.ProfilerRecorder), "GetSampleInternal_Injected", 0, typeof(Unity.Profiling.ProfilerRecorder).MakeByRefType(), typeof(System.Int32), typeof(Unity.Profiling.ProfilerRecorderSample).MakeByRefType());
				}
				return r_MGetSampleInternal_Injected_Ref_ProfilerRecorder_Int32_Out_ProfilerRecorderSample;
			}
		}

		/// <summary>
		/// Void CopyTo_List_Injected(Unity.Profiling.ProfilerRecorder ByRef, System.Collections.Generic.List`1[Unity.Profiling.ProfilerRecorderSample], Boolean)
		/// </summary>
		protected static RMethod r_MCopyTo_List_Injected_Ref_ProfilerRecorder_List_d_ProfilerRecorderSample_p__Boolean;
		public static RMethod RMCopyTo_List_Injected_Ref_ProfilerRecorder_List_d_ProfilerRecorderSample_p__Boolean
		{
			get
			{
				if(r_MCopyTo_List_Injected_Ref_ProfilerRecorder_List_d_ProfilerRecorderSample_p__Boolean == null)
				{
					r_MCopyTo_List_Injected_Ref_ProfilerRecorder_List_d_ProfilerRecorderSample_p__Boolean = new(typeof(Unity.Profiling.ProfilerRecorder), "CopyTo_List_Injected", 0, typeof(Unity.Profiling.ProfilerRecorder).MakeByRefType(), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(Unity.Profiling.ProfilerRecorderSample)), typeof(System.Boolean));
				}
				return r_MCopyTo_List_Injected_Ref_ProfilerRecorder_List_d_ProfilerRecorderSample_p__Boolean;
			}
		}

		/// <summary>
		/// Int32 CopyTo_Pointer_Injected(Unity.Profiling.ProfilerRecorder ByRef, Unity.Profiling.ProfilerRecorderSample*, Int32, Boolean)
		/// </summary>
		protected static RMethod r_MCopyTo_Pointer_Injected_Ref_ProfilerRecorder_ProfilerRecorderSamplePointer_Int32_Boolean;
		public static RMethod RMCopyTo_Pointer_Injected_Ref_ProfilerRecorder_ProfilerRecorderSamplePointer_Int32_Boolean
		{
			get
			{
				if(r_MCopyTo_Pointer_Injected_Ref_ProfilerRecorder_ProfilerRecorderSamplePointer_Int32_Boolean == null)
				{
					r_MCopyTo_Pointer_Injected_Ref_ProfilerRecorder_ProfilerRecorderSamplePointer_Int32_Boolean = new(typeof(Unity.Profiling.ProfilerRecorder), "CopyTo_Pointer_Injected", 0, typeof(Unity.Profiling.ProfilerRecorder).MakeByRefType(), typeof(Unity.Profiling.ProfilerRecorderSample).MakePointerType(), typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MCopyTo_Pointer_Injected_Ref_ProfilerRecorder_ProfilerRecorderSamplePointer_Int32_Boolean;
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

        public static Unity.Profiling.ProfilerRecorder StartNew(Unity.Profiling.ProfilerCategory @category, System.String @statName, System.Int32 @capacity, Unity.Profiling.ProfilerRecorderOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@category, @statName, @capacity, @options};
            var ___result = RMStartNew_ProfilerCategory_String_Int32_ProfilerRecorderOptions.Invoke(___genericsType, ___parameters);

            return (Unity.Profiling.ProfilerRecorder)___result;
        }


        public static Unity.Profiling.ProfilerRecorder StartNew(Unity.Profiling.ProfilerMarker @marker, System.Int32 @capacity, Unity.Profiling.ProfilerRecorderOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@marker, @capacity, @options};
            var ___result = RMStartNew_ProfilerMarker_Int32_ProfilerRecorderOptions.Invoke(___genericsType, ___parameters);

            return (Unity.Profiling.ProfilerRecorder)___result;
        }


        public static Unity.Profiling.ProfilerRecorder StartNew()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMStartNew.Invoke(___genericsType, ___parameters);

            return (Unity.Profiling.ProfilerRecorder)___result;
        }


        public virtual void Start()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMStart.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Stop()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMStop.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Unity.Profiling.ProfilerRecorderSample GetSample(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetSample_Int32.Invoke(___genericsType, ___parameters);

            return (Unity.Profiling.ProfilerRecorderSample)___result;
        }


        public virtual void CopyTo(System.Collections.Generic.List<Unity.Profiling.ProfilerRecorderSample> @outSamples, System.Boolean @reset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outSamples, @reset};
            var ___result = RMCopyTo_List_d_ProfilerRecorderSample_p__Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe virtual System.Int32 CopyTo(Unity.Profiling.ProfilerRecorderSample* @dest, System.Int32 @destSize, System.Boolean @reset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@dest, typeof(Unity.Profiling.ProfilerRecorderSample)), @destSize, @reset};
            var ___result = RMCopyTo_ProfilerRecorderSamplePointer_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual Unity.Profiling.ProfilerRecorderSample[] ToArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToArray.Invoke(___genericsType, ___parameters);

            return (Unity.Profiling.ProfilerRecorderSample[])___result;
        }


        public virtual void FilterToCurrentThread()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFilterToCurrentThread.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CollectFromAllThreads()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCollectFromAllThreads.Invoke(___genericsType, ___parameters);

            
        }


        public static Unity.Profiling.ProfilerRecorder Create(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle @statHandle, System.Int32 @maxSampleCount, Unity.Profiling.ProfilerRecorderOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@statHandle, @maxSampleCount, @options};
            var ___result = RMCreate_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions.Invoke(___genericsType, ___parameters);

            return (Unity.Profiling.ProfilerRecorder)___result;
        }


        public static void Control(Unity.Profiling.ProfilerRecorder @handle, Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerRecorder.RControlOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @options.Value};
            var ___result = RMControl_ProfilerRecorder_ControlOptions.Invoke(___genericsType, ___parameters);

            
        }


        public static Unity.Profiling.ProfilerMarkerDataUnit GetValueUnitType(Unity.Profiling.ProfilerRecorder @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetValueUnitType_ProfilerRecorder.Invoke(___genericsType, ___parameters);

            return (Unity.Profiling.ProfilerMarkerDataUnit)___result;
        }


        public static Unity.Profiling.LowLevel.ProfilerMarkerDataType GetValueDataType(Unity.Profiling.ProfilerRecorder @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetValueDataType_ProfilerRecorder.Invoke(___genericsType, ___parameters);

            return (Unity.Profiling.LowLevel.ProfilerMarkerDataType)___result;
        }


        public static System.Int64 GetCurrentValue(Unity.Profiling.ProfilerRecorder @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetCurrentValue_ProfilerRecorder.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public static System.Double GetCurrentValueAsDouble(Unity.Profiling.ProfilerRecorder @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetCurrentValueAsDouble_ProfilerRecorder.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public static System.Int64 GetLastValue(Unity.Profiling.ProfilerRecorder @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetLastValue_ProfilerRecorder.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public static System.Double GetLastValueAsDouble(Unity.Profiling.ProfilerRecorder @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetLastValueAsDouble_ProfilerRecorder.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public static System.Int32 GetCount(Unity.Profiling.ProfilerRecorder @handle, Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerRecorder.RCountOptions @countOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @countOptions.Value};
            var ___result = RMGetCount_ProfilerRecorder_CountOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean GetValid(Unity.Profiling.ProfilerRecorder @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetValid_ProfilerRecorder.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean GetWrapped(Unity.Profiling.ProfilerRecorder @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetWrapped_ProfilerRecorder.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean GetRunning(Unity.Profiling.ProfilerRecorder @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetRunning_ProfilerRecorder.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static Unity.Profiling.ProfilerRecorderSample GetSampleInternal(Unity.Profiling.ProfilerRecorder @handle, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @index};
            var ___result = RMGetSampleInternal_ProfilerRecorder_Int32.Invoke(___genericsType, ___parameters);

            return (Unity.Profiling.ProfilerRecorderSample)___result;
        }


        public static void CopyTo_List(Unity.Profiling.ProfilerRecorder @handle, System.Collections.Generic.List<Unity.Profiling.ProfilerRecorderSample> @outSamples, System.Boolean @reset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @outSamples, @reset};
            var ___result = RMCopyTo_List_ProfilerRecorder_List_d_ProfilerRecorderSample_p__Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe static System.Int32 CopyTo_Pointer(Unity.Profiling.ProfilerRecorder @handle, Unity.Profiling.ProfilerRecorderSample* @outSamples, System.Int32 @outSamplesSize, System.Boolean @reset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, Pointer.Box(@outSamples, typeof(Unity.Profiling.ProfilerRecorderSample)), @outSamplesSize, @reset};
            var ___result = RMCopyTo_Pointer_ProfilerRecorder_ProfilerRecorderSamplePointer_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe virtual void CheckInitializedWithParamsAndThrow(Unity.Profiling.ProfilerRecorderSample* @dest)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@dest, typeof(Unity.Profiling.ProfilerRecorderSample))};
            var ___result = RMCheckInitializedWithParamsAndThrow_ProfilerRecorderSamplePointer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckInitializedAndThrow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCheckInitializedAndThrow.Invoke(___genericsType, ___parameters);

            
        }


        public static void Create_Injected(ref Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle @statHandle, System.Int32 @maxSampleCount, Unity.Profiling.ProfilerRecorderOptions @options, out Unity.Profiling.ProfilerRecorder @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@statHandle, @maxSampleCount, @options, @ret};
            var ___result = RMCreate_Injected_Ref_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_Out_ProfilerRecorder.Invoke(___genericsType, ___parameters);
			@statHandle = (Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle)___parameters[0];
			@ret = (Unity.Profiling.ProfilerRecorder)___parameters[3];

            
        }


        public static void Control_Injected(ref Unity.Profiling.ProfilerRecorder @handle, Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerRecorder.RControlOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @options.Value};
            var ___result = RMControl_Injected_Ref_ProfilerRecorder_ControlOptions.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Profiling.ProfilerRecorder)___parameters[0];

            
        }


        public static Unity.Profiling.ProfilerMarkerDataUnit GetValueUnitType_Injected(ref Unity.Profiling.ProfilerRecorder @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetValueUnitType_Injected_Ref_ProfilerRecorder.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Profiling.ProfilerRecorder)___parameters[0];

            return (Unity.Profiling.ProfilerMarkerDataUnit)___result;
        }


        public static Unity.Profiling.LowLevel.ProfilerMarkerDataType GetValueDataType_Injected(ref Unity.Profiling.ProfilerRecorder @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetValueDataType_Injected_Ref_ProfilerRecorder.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Profiling.ProfilerRecorder)___parameters[0];

            return (Unity.Profiling.LowLevel.ProfilerMarkerDataType)___result;
        }


        public static System.Int64 GetCurrentValue_Injected(ref Unity.Profiling.ProfilerRecorder @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetCurrentValue_Injected_Ref_ProfilerRecorder.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Profiling.ProfilerRecorder)___parameters[0];

            return (System.Int64)___result;
        }


        public static System.Double GetCurrentValueAsDouble_Injected(ref Unity.Profiling.ProfilerRecorder @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetCurrentValueAsDouble_Injected_Ref_ProfilerRecorder.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Profiling.ProfilerRecorder)___parameters[0];

            return (System.Double)___result;
        }


        public static System.Int64 GetLastValue_Injected(ref Unity.Profiling.ProfilerRecorder @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetLastValue_Injected_Ref_ProfilerRecorder.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Profiling.ProfilerRecorder)___parameters[0];

            return (System.Int64)___result;
        }


        public static System.Double GetLastValueAsDouble_Injected(ref Unity.Profiling.ProfilerRecorder @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetLastValueAsDouble_Injected_Ref_ProfilerRecorder.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Profiling.ProfilerRecorder)___parameters[0];

            return (System.Double)___result;
        }


        public static System.Int32 GetCount_Injected(ref Unity.Profiling.ProfilerRecorder @handle, Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerRecorder.RCountOptions @countOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @countOptions.Value};
            var ___result = RMGetCount_Injected_Ref_ProfilerRecorder_CountOptions.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Profiling.ProfilerRecorder)___parameters[0];

            return (System.Int32)___result;
        }


        public static System.Boolean GetValid_Injected(ref Unity.Profiling.ProfilerRecorder @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetValid_Injected_Ref_ProfilerRecorder.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Profiling.ProfilerRecorder)___parameters[0];

            return (System.Boolean)___result;
        }


        public static System.Boolean GetWrapped_Injected(ref Unity.Profiling.ProfilerRecorder @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetWrapped_Injected_Ref_ProfilerRecorder.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Profiling.ProfilerRecorder)___parameters[0];

            return (System.Boolean)___result;
        }


        public static System.Boolean GetRunning_Injected(ref Unity.Profiling.ProfilerRecorder @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetRunning_Injected_Ref_ProfilerRecorder.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Profiling.ProfilerRecorder)___parameters[0];

            return (System.Boolean)___result;
        }


        public static void GetSampleInternal_Injected(ref Unity.Profiling.ProfilerRecorder @handle, System.Int32 @index, out Unity.Profiling.ProfilerRecorderSample @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @index, @ret};
            var ___result = RMGetSampleInternal_Injected_Ref_ProfilerRecorder_Int32_Out_ProfilerRecorderSample.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Profiling.ProfilerRecorder)___parameters[0];
			@ret = (Unity.Profiling.ProfilerRecorderSample)___parameters[2];

            
        }


        public static void CopyTo_List_Injected(ref Unity.Profiling.ProfilerRecorder @handle, System.Collections.Generic.List<Unity.Profiling.ProfilerRecorderSample> @outSamples, System.Boolean @reset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @outSamples, @reset};
            var ___result = RMCopyTo_List_Injected_Ref_ProfilerRecorder_List_d_ProfilerRecorderSample_p__Boolean.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Profiling.ProfilerRecorder)___parameters[0];

            
        }


        public unsafe static System.Int32 CopyTo_Pointer_Injected(ref Unity.Profiling.ProfilerRecorder @handle, Unity.Profiling.ProfilerRecorderSample* @outSamples, System.Int32 @outSamplesSize, System.Boolean @reset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, Pointer.Box(@outSamples, typeof(Unity.Profiling.ProfilerRecorderSample)), @outSamplesSize, @reset};
            var ___result = RMCopyTo_Pointer_Injected_Ref_ProfilerRecorder_ProfilerRecorderSamplePointer_Int32_Boolean.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Profiling.ProfilerRecorder)___parameters[0];

            return (System.Int32)___result;
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
