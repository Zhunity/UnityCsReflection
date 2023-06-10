
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
	/// UnityEngine.Rendering.AsyncGPUReadbackRequest
	/// </summary>
    public partial class RAsyncGPUReadbackRequest : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest);
            }
        }

        public RAsyncGPUReadbackRequest() : base("UnityEngine.Rendering.AsyncGPUReadbackRequest")
        {
        }

        public RAsyncGPUReadbackRequest(System.Object instance) : base("UnityEngine.Rendering.AsyncGPUReadbackRequest")
		{
            SetInstance(instance);
		}

        public RAsyncGPUReadbackRequest(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAsyncGPUReadbackRequest(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
		/// System.Int32 m_Version
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_Version;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_Version
		{
			get
			{
				if(r_Fm_Version == null)
				{
					r_Fm_Version = new(this, "m_Version");
				}
				return r_Fm_Version;
			}
		}

		/// <summary>
		/// Boolean done
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pdone;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPdone
		{
			get
			{
				if(r_Pdone == null)
				{
					r_Pdone = new(this, "done", -1);
				}
				return r_Pdone;
			}
		}

		/// <summary>
		/// Boolean hasError
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasError;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasError
		{
			get
			{
				if(r_PhasError == null)
				{
					r_PhasError = new(this, "hasError", -1);
				}
				return r_PhasError;
			}
		}

		/// <summary>
		/// Int32 layerCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PlayerCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPlayerCount
		{
			get
			{
				if(r_PlayerCount == null)
				{
					r_PlayerCount = new(this, "layerCount", -1);
				}
				return r_PlayerCount;
			}
		}

		/// <summary>
		/// Int32 layerDataSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PlayerDataSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPlayerDataSize
		{
			get
			{
				if(r_PlayerDataSize == null)
				{
					r_PlayerDataSize = new(this, "layerDataSize", -1);
				}
				return r_PlayerDataSize;
			}
		}

		/// <summary>
		/// Int32 width
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Pwidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPwidth
		{
			get
			{
				if(r_Pwidth == null)
				{
					r_Pwidth = new(this, "width", -1);
				}
				return r_Pwidth;
			}
		}

		/// <summary>
		/// Int32 height
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Pheight;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPheight
		{
			get
			{
				if(r_Pheight == null)
				{
					r_Pheight = new(this, "height", -1);
				}
				return r_Pheight;
			}
		}

		/// <summary>
		/// Int32 depth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Pdepth;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPdepth
		{
			get
			{
				if(r_Pdepth == null)
				{
					r_Pdepth = new(this, "depth", -1);
				}
				return r_Pdepth;
			}
		}

		/// <summary>
		/// Void Update()
		/// </summary>
		protected RMethod r_MUpdate;
		public virtual RMethod RMUpdate
		{
			get
			{
				if(r_MUpdate == null)
				{
					r_MUpdate = new(this, "Update", 0);
				}
				return r_MUpdate;
			}
		}

		/// <summary>
		/// Void WaitForCompletion()
		/// </summary>
		protected RMethod r_MWaitForCompletion;
		public virtual RMethod RMWaitForCompletion
		{
			get
			{
				if(r_MWaitForCompletion == null)
				{
					r_MWaitForCompletion = new(this, "WaitForCompletion", 0);
				}
				return r_MWaitForCompletion;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[T] GetData[T](Int32)
		/// </summary>
		protected RMethod r_MGetData_GT_Int32;
		public virtual RMethod RMGetData_GT_Int32
		{
			get
			{
				if(r_MGetData_GT_Int32 == null)
				{
					r_MGetData_GT_Int32 = new(this, "GetData", 1, typeof(System.Int32));
				}
				return r_MGetData_GT_Int32;
			}
		}

		/// <summary>
		/// Boolean IsDone()
		/// </summary>
		protected RMethod r_MIsDone;
		public virtual RMethod RMIsDone
		{
			get
			{
				if(r_MIsDone == null)
				{
					r_MIsDone = new(this, "IsDone", 0);
				}
				return r_MIsDone;
			}
		}

		/// <summary>
		/// Boolean HasError()
		/// </summary>
		protected RMethod r_MHasError;
		public virtual RMethod RMHasError
		{
			get
			{
				if(r_MHasError == null)
				{
					r_MHasError = new(this, "HasError", 0);
				}
				return r_MHasError;
			}
		}

		/// <summary>
		/// Int32 GetLayerCount()
		/// </summary>
		protected RMethod r_MGetLayerCount;
		public virtual RMethod RMGetLayerCount
		{
			get
			{
				if(r_MGetLayerCount == null)
				{
					r_MGetLayerCount = new(this, "GetLayerCount", 0);
				}
				return r_MGetLayerCount;
			}
		}

		/// <summary>
		/// Int32 GetLayerDataSize()
		/// </summary>
		protected RMethod r_MGetLayerDataSize;
		public virtual RMethod RMGetLayerDataSize
		{
			get
			{
				if(r_MGetLayerDataSize == null)
				{
					r_MGetLayerDataSize = new(this, "GetLayerDataSize", 0);
				}
				return r_MGetLayerDataSize;
			}
		}

		/// <summary>
		/// Int32 GetWidth()
		/// </summary>
		protected RMethod r_MGetWidth;
		public virtual RMethod RMGetWidth
		{
			get
			{
				if(r_MGetWidth == null)
				{
					r_MGetWidth = new(this, "GetWidth", 0);
				}
				return r_MGetWidth;
			}
		}

		/// <summary>
		/// Int32 GetHeight()
		/// </summary>
		protected RMethod r_MGetHeight;
		public virtual RMethod RMGetHeight
		{
			get
			{
				if(r_MGetHeight == null)
				{
					r_MGetHeight = new(this, "GetHeight", 0);
				}
				return r_MGetHeight;
			}
		}

		/// <summary>
		/// Int32 GetDepth()
		/// </summary>
		protected RMethod r_MGetDepth;
		public virtual RMethod RMGetDepth
		{
			get
			{
				if(r_MGetDepth == null)
				{
					r_MGetDepth = new(this, "GetDepth", 0);
				}
				return r_MGetDepth;
			}
		}

		/// <summary>
		/// Void CreateSafetyHandle()
		/// </summary>
		protected RMethod r_MCreateSafetyHandle;
		public virtual RMethod RMCreateSafetyHandle
		{
			get
			{
				if(r_MCreateSafetyHandle == null)
				{
					r_MCreateSafetyHandle = new(this, "CreateSafetyHandle", 0);
				}
				return r_MCreateSafetyHandle;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetSafetyHandle()
		/// </summary>
		protected RMethod r_MGetSafetyHandle;
		public virtual RMethod RMGetSafetyHandle
		{
			get
			{
				if(r_MGetSafetyHandle == null)
				{
					r_MGetSafetyHandle = new(this, "GetSafetyHandle", 0);
				}
				return r_MGetSafetyHandle;
			}
		}

		/// <summary>
		/// Void SetScriptingCallback(System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MSetScriptingCallback_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMSetScriptingCallback_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MSetScriptingCallback_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MSetScriptingCallback_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "SetScriptingCallback", 0, typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MSetScriptingCallback_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// IntPtr GetDataRaw(Int32)
		/// </summary>
		protected RMethod r_MGetDataRaw_Int32;
		public virtual RMethod RMGetDataRaw_Int32
		{
			get
			{
				if(r_MGetDataRaw_Int32 == null)
				{
					r_MGetDataRaw_Int32 = new(this, "GetDataRaw", 0, typeof(System.Int32));
				}
				return r_MGetDataRaw_Int32;
			}
		}

		/// <summary>
		/// Void Update_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest ByRef)
		/// </summary>
		protected static RMethod r_MUpdate_Injected_Ref_AsyncGPUReadbackRequest;
		public static RMethod RMUpdate_Injected_Ref_AsyncGPUReadbackRequest
		{
			get
			{
				if(r_MUpdate_Injected_Ref_AsyncGPUReadbackRequest == null)
				{
					r_MUpdate_Injected_Ref_AsyncGPUReadbackRequest = new(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest), "Update_Injected", 0, typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest).MakeByRefType());
				}
				return r_MUpdate_Injected_Ref_AsyncGPUReadbackRequest;
			}
		}

		/// <summary>
		/// Void WaitForCompletion_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest ByRef)
		/// </summary>
		protected static RMethod r_MWaitForCompletion_Injected_Ref_AsyncGPUReadbackRequest;
		public static RMethod RMWaitForCompletion_Injected_Ref_AsyncGPUReadbackRequest
		{
			get
			{
				if(r_MWaitForCompletion_Injected_Ref_AsyncGPUReadbackRequest == null)
				{
					r_MWaitForCompletion_Injected_Ref_AsyncGPUReadbackRequest = new(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest), "WaitForCompletion_Injected", 0, typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest).MakeByRefType());
				}
				return r_MWaitForCompletion_Injected_Ref_AsyncGPUReadbackRequest;
			}
		}

		/// <summary>
		/// Boolean IsDone_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest ByRef)
		/// </summary>
		protected static RMethod r_MIsDone_Injected_Ref_AsyncGPUReadbackRequest;
		public static RMethod RMIsDone_Injected_Ref_AsyncGPUReadbackRequest
		{
			get
			{
				if(r_MIsDone_Injected_Ref_AsyncGPUReadbackRequest == null)
				{
					r_MIsDone_Injected_Ref_AsyncGPUReadbackRequest = new(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest), "IsDone_Injected", 0, typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest).MakeByRefType());
				}
				return r_MIsDone_Injected_Ref_AsyncGPUReadbackRequest;
			}
		}

		/// <summary>
		/// Boolean HasError_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest ByRef)
		/// </summary>
		protected static RMethod r_MHasError_Injected_Ref_AsyncGPUReadbackRequest;
		public static RMethod RMHasError_Injected_Ref_AsyncGPUReadbackRequest
		{
			get
			{
				if(r_MHasError_Injected_Ref_AsyncGPUReadbackRequest == null)
				{
					r_MHasError_Injected_Ref_AsyncGPUReadbackRequest = new(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest), "HasError_Injected", 0, typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest).MakeByRefType());
				}
				return r_MHasError_Injected_Ref_AsyncGPUReadbackRequest;
			}
		}

		/// <summary>
		/// Int32 GetLayerCount_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest ByRef)
		/// </summary>
		protected static RMethod r_MGetLayerCount_Injected_Ref_AsyncGPUReadbackRequest;
		public static RMethod RMGetLayerCount_Injected_Ref_AsyncGPUReadbackRequest
		{
			get
			{
				if(r_MGetLayerCount_Injected_Ref_AsyncGPUReadbackRequest == null)
				{
					r_MGetLayerCount_Injected_Ref_AsyncGPUReadbackRequest = new(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest), "GetLayerCount_Injected", 0, typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest).MakeByRefType());
				}
				return r_MGetLayerCount_Injected_Ref_AsyncGPUReadbackRequest;
			}
		}

		/// <summary>
		/// Int32 GetLayerDataSize_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest ByRef)
		/// </summary>
		protected static RMethod r_MGetLayerDataSize_Injected_Ref_AsyncGPUReadbackRequest;
		public static RMethod RMGetLayerDataSize_Injected_Ref_AsyncGPUReadbackRequest
		{
			get
			{
				if(r_MGetLayerDataSize_Injected_Ref_AsyncGPUReadbackRequest == null)
				{
					r_MGetLayerDataSize_Injected_Ref_AsyncGPUReadbackRequest = new(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest), "GetLayerDataSize_Injected", 0, typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest).MakeByRefType());
				}
				return r_MGetLayerDataSize_Injected_Ref_AsyncGPUReadbackRequest;
			}
		}

		/// <summary>
		/// Int32 GetWidth_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest ByRef)
		/// </summary>
		protected static RMethod r_MGetWidth_Injected_Ref_AsyncGPUReadbackRequest;
		public static RMethod RMGetWidth_Injected_Ref_AsyncGPUReadbackRequest
		{
			get
			{
				if(r_MGetWidth_Injected_Ref_AsyncGPUReadbackRequest == null)
				{
					r_MGetWidth_Injected_Ref_AsyncGPUReadbackRequest = new(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest), "GetWidth_Injected", 0, typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest).MakeByRefType());
				}
				return r_MGetWidth_Injected_Ref_AsyncGPUReadbackRequest;
			}
		}

		/// <summary>
		/// Int32 GetHeight_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest ByRef)
		/// </summary>
		protected static RMethod r_MGetHeight_Injected_Ref_AsyncGPUReadbackRequest;
		public static RMethod RMGetHeight_Injected_Ref_AsyncGPUReadbackRequest
		{
			get
			{
				if(r_MGetHeight_Injected_Ref_AsyncGPUReadbackRequest == null)
				{
					r_MGetHeight_Injected_Ref_AsyncGPUReadbackRequest = new(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest), "GetHeight_Injected", 0, typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest).MakeByRefType());
				}
				return r_MGetHeight_Injected_Ref_AsyncGPUReadbackRequest;
			}
		}

		/// <summary>
		/// Int32 GetDepth_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest ByRef)
		/// </summary>
		protected static RMethod r_MGetDepth_Injected_Ref_AsyncGPUReadbackRequest;
		public static RMethod RMGetDepth_Injected_Ref_AsyncGPUReadbackRequest
		{
			get
			{
				if(r_MGetDepth_Injected_Ref_AsyncGPUReadbackRequest == null)
				{
					r_MGetDepth_Injected_Ref_AsyncGPUReadbackRequest = new(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest), "GetDepth_Injected", 0, typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest).MakeByRefType());
				}
				return r_MGetDepth_Injected_Ref_AsyncGPUReadbackRequest;
			}
		}

		/// <summary>
		/// Void CreateSafetyHandle_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest ByRef)
		/// </summary>
		protected static RMethod r_MCreateSafetyHandle_Injected_Ref_AsyncGPUReadbackRequest;
		public static RMethod RMCreateSafetyHandle_Injected_Ref_AsyncGPUReadbackRequest
		{
			get
			{
				if(r_MCreateSafetyHandle_Injected_Ref_AsyncGPUReadbackRequest == null)
				{
					r_MCreateSafetyHandle_Injected_Ref_AsyncGPUReadbackRequest = new(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest), "CreateSafetyHandle_Injected", 0, typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest).MakeByRefType());
				}
				return r_MCreateSafetyHandle_Injected_Ref_AsyncGPUReadbackRequest;
			}
		}

		/// <summary>
		/// Void GetSafetyHandle_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest ByRef, Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_MGetSafetyHandle_Injected_Ref_AsyncGPUReadbackRequest_Out_AtomicSafetyHandle;
		public static RMethod RMGetSafetyHandle_Injected_Ref_AsyncGPUReadbackRequest_Out_AtomicSafetyHandle
		{
			get
			{
				if(r_MGetSafetyHandle_Injected_Ref_AsyncGPUReadbackRequest_Out_AtomicSafetyHandle == null)
				{
					r_MGetSafetyHandle_Injected_Ref_AsyncGPUReadbackRequest_Out_AtomicSafetyHandle = new(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest), "GetSafetyHandle_Injected", 0, typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest).MakeByRefType(), typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
				}
				return r_MGetSafetyHandle_Injected_Ref_AsyncGPUReadbackRequest_Out_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void SetScriptingCallback_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest ByRef, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected static RMethod r_MSetScriptingCallback_Injected_Ref_AsyncGPUReadbackRequest_Action_d_AsyncGPUReadbackRequest_p_;
		public static RMethod RMSetScriptingCallback_Injected_Ref_AsyncGPUReadbackRequest_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MSetScriptingCallback_Injected_Ref_AsyncGPUReadbackRequest_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MSetScriptingCallback_Injected_Ref_AsyncGPUReadbackRequest_Action_d_AsyncGPUReadbackRequest_p_ = new(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest), "SetScriptingCallback_Injected", 0, typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest).MakeByRefType(), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MSetScriptingCallback_Injected_Ref_AsyncGPUReadbackRequest_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// IntPtr GetDataRaw_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest ByRef, Int32)
		/// </summary>
		protected static RMethod r_MGetDataRaw_Injected_Ref_AsyncGPUReadbackRequest_Int32;
		public static RMethod RMGetDataRaw_Injected_Ref_AsyncGPUReadbackRequest_Int32
		{
			get
			{
				if(r_MGetDataRaw_Injected_Ref_AsyncGPUReadbackRequest_Int32 == null)
				{
					r_MGetDataRaw_Injected_Ref_AsyncGPUReadbackRequest_Int32 = new(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest), "GetDataRaw_Injected", 0, typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest).MakeByRefType(), typeof(System.Int32));
				}
				return r_MGetDataRaw_Injected_Ref_AsyncGPUReadbackRequest_Int32;
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


        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WaitForCompletion()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMWaitForCompletion.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> GetData<T>(System.Int32 @layer) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@layer};
            var ___result = RMGetData_GT_Int32.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>(___result);
        }


        public virtual System.Boolean IsDone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsDone.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasError()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHasError.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetLayerCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetLayerCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetLayerDataSize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetLayerDataSize.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetWidth()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetWidth.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHeight()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHeight.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetDepth()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDepth.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void CreateSafetyHandle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateSafetyHandle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetSafetyHandle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSafetyHandle.Invoke(___genericsType, ___parameters);

            return (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___result;
        }


        public virtual void SetScriptingCallback(System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback};
            var ___result = RMSetScriptingCallback_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IntPtr GetDataRaw(System.Int32 @layer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@layer};
            var ___result = RMGetDataRaw_Int32.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static void Update_Injected(ref UnityEngine.Rendering.AsyncGPUReadbackRequest @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RMUpdate_Injected_Ref_AsyncGPUReadbackRequest.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.AsyncGPUReadbackRequest)___parameters[0];

            
        }


        public static void WaitForCompletion_Injected(ref UnityEngine.Rendering.AsyncGPUReadbackRequest @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RMWaitForCompletion_Injected_Ref_AsyncGPUReadbackRequest.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.AsyncGPUReadbackRequest)___parameters[0];

            
        }


        public static System.Boolean IsDone_Injected(ref UnityEngine.Rendering.AsyncGPUReadbackRequest @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RMIsDone_Injected_Ref_AsyncGPUReadbackRequest.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.AsyncGPUReadbackRequest)___parameters[0];

            return (System.Boolean)___result;
        }


        public static System.Boolean HasError_Injected(ref UnityEngine.Rendering.AsyncGPUReadbackRequest @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RMHasError_Injected_Ref_AsyncGPUReadbackRequest.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.AsyncGPUReadbackRequest)___parameters[0];

            return (System.Boolean)___result;
        }


        public static System.Int32 GetLayerCount_Injected(ref UnityEngine.Rendering.AsyncGPUReadbackRequest @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RMGetLayerCount_Injected_Ref_AsyncGPUReadbackRequest.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.AsyncGPUReadbackRequest)___parameters[0];

            return (System.Int32)___result;
        }


        public static System.Int32 GetLayerDataSize_Injected(ref UnityEngine.Rendering.AsyncGPUReadbackRequest @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RMGetLayerDataSize_Injected_Ref_AsyncGPUReadbackRequest.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.AsyncGPUReadbackRequest)___parameters[0];

            return (System.Int32)___result;
        }


        public static System.Int32 GetWidth_Injected(ref UnityEngine.Rendering.AsyncGPUReadbackRequest @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RMGetWidth_Injected_Ref_AsyncGPUReadbackRequest.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.AsyncGPUReadbackRequest)___parameters[0];

            return (System.Int32)___result;
        }


        public static System.Int32 GetHeight_Injected(ref UnityEngine.Rendering.AsyncGPUReadbackRequest @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RMGetHeight_Injected_Ref_AsyncGPUReadbackRequest.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.AsyncGPUReadbackRequest)___parameters[0];

            return (System.Int32)___result;
        }


        public static System.Int32 GetDepth_Injected(ref UnityEngine.Rendering.AsyncGPUReadbackRequest @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RMGetDepth_Injected_Ref_AsyncGPUReadbackRequest.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.AsyncGPUReadbackRequest)___parameters[0];

            return (System.Int32)___result;
        }


        public static void CreateSafetyHandle_Injected(ref UnityEngine.Rendering.AsyncGPUReadbackRequest @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RMCreateSafetyHandle_Injected_Ref_AsyncGPUReadbackRequest.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.AsyncGPUReadbackRequest)___parameters[0];

            
        }


        public static void GetSafetyHandle_Injected(ref UnityEngine.Rendering.AsyncGPUReadbackRequest @_unity_self, out Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self, @ret};
            var ___result = RMGetSafetyHandle_Injected_Ref_AsyncGPUReadbackRequest_Out_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.AsyncGPUReadbackRequest)___parameters[0];
			@ret = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[1];

            
        }


        public static void SetScriptingCallback_Injected(ref UnityEngine.Rendering.AsyncGPUReadbackRequest @_unity_self, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self, @callback};
            var ___result = RMSetScriptingCallback_Injected_Ref_AsyncGPUReadbackRequest_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.AsyncGPUReadbackRequest)___parameters[0];

            
        }


        public static System.IntPtr GetDataRaw_Injected(ref UnityEngine.Rendering.AsyncGPUReadbackRequest @_unity_self, System.Int32 @layer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self, @layer};
            var ___result = RMGetDataRaw_Injected_Ref_AsyncGPUReadbackRequest_Int32.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.AsyncGPUReadbackRequest)___parameters[0];

            return (System.IntPtr)___result;
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
