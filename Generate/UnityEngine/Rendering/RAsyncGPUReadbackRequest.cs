using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
	/// UnityEngine.Rendering.AsyncGPUReadbackRequest
	/// </summary>
    public partial class RAsyncGPUReadbackRequest : RMember //
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
		/// System.Int32 m_Version
		/// </summary>
		protected RField r_m_Version;
		public virtual RField Rm_Version
		{
			get
			{
				if(r_m_Version == null)
				{
					r_m_Version = new(this, "m_Version");
					r_m_Version.SetBelong(this.instance);
				}
				return r_m_Version;
			}
		}

		/// <summary>
		/// Boolean done
		/// </summary>
		protected RProperty r_done;
		public virtual RProperty Rdone
		{
			get
			{
				if(r_done == null)
				{
					r_done = new(this, "done", -1);
					r_done.SetBelong(this.instance);
				}
				return r_done;
			}
		}

		/// <summary>
		/// Boolean hasError
		/// </summary>
		protected RProperty r_hasError;
		public virtual RProperty RhasError
		{
			get
			{
				if(r_hasError == null)
				{
					r_hasError = new(this, "hasError", -1);
					r_hasError.SetBelong(this.instance);
				}
				return r_hasError;
			}
		}

		/// <summary>
		/// Int32 layerCount
		/// </summary>
		protected RProperty r_layerCount;
		public virtual RProperty RlayerCount
		{
			get
			{
				if(r_layerCount == null)
				{
					r_layerCount = new(this, "layerCount", -1);
					r_layerCount.SetBelong(this.instance);
				}
				return r_layerCount;
			}
		}

		/// <summary>
		/// Int32 layerDataSize
		/// </summary>
		protected RProperty r_layerDataSize;
		public virtual RProperty RlayerDataSize
		{
			get
			{
				if(r_layerDataSize == null)
				{
					r_layerDataSize = new(this, "layerDataSize", -1);
					r_layerDataSize.SetBelong(this.instance);
				}
				return r_layerDataSize;
			}
		}

		/// <summary>
		/// Int32 width
		/// </summary>
		protected RProperty r_width;
		public virtual RProperty Rwidth
		{
			get
			{
				if(r_width == null)
				{
					r_width = new(this, "width", -1);
					r_width.SetBelong(this.instance);
				}
				return r_width;
			}
		}

		/// <summary>
		/// Int32 height
		/// </summary>
		protected RProperty r_height;
		public virtual RProperty Rheight
		{
			get
			{
				if(r_height == null)
				{
					r_height = new(this, "height", -1);
					r_height.SetBelong(this.instance);
				}
				return r_height;
			}
		}

		/// <summary>
		/// Int32 depth
		/// </summary>
		protected RProperty r_depth;
		public virtual RProperty Rdepth
		{
			get
			{
				if(r_depth == null)
				{
					r_depth = new(this, "depth", -1);
					r_depth.SetBelong(this.instance);
				}
				return r_depth;
			}
		}

		/// <summary>
		/// Void Update()
		/// </summary>
		protected RMethod r_Update;
		public virtual RMethod RUpdate
		{
			get
			{
				if(r_Update == null)
				{
					r_Update = new(this, "Update", 0);
					r_Update.SetBelong(this.instance);
				}
				return r_Update;
			}
		}

		/// <summary>
		/// Void WaitForCompletion()
		/// </summary>
		protected RMethod r_WaitForCompletion;
		public virtual RMethod RWaitForCompletion
		{
			get
			{
				if(r_WaitForCompletion == null)
				{
					r_WaitForCompletion = new(this, "WaitForCompletion", 0);
					r_WaitForCompletion.SetBelong(this.instance);
				}
				return r_WaitForCompletion;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[T] GetData[T](Int32)
		/// </summary>
		protected RMethod r_GetData_GT_Int32;
		public virtual RMethod RGetData_GT_Int32
		{
			get
			{
				if(r_GetData_GT_Int32 == null)
				{
					r_GetData_GT_Int32 = new(this, "GetData", 1, typeof(System.Int32));
					r_GetData_GT_Int32.SetBelong(this.instance);
				}
				return r_GetData_GT_Int32;
			}
		}

		/// <summary>
		/// Boolean IsDone()
		/// </summary>
		protected RMethod r_IsDone;
		public virtual RMethod RIsDone
		{
			get
			{
				if(r_IsDone == null)
				{
					r_IsDone = new(this, "IsDone", 0);
					r_IsDone.SetBelong(this.instance);
				}
				return r_IsDone;
			}
		}

		/// <summary>
		/// Boolean HasError()
		/// </summary>
		protected RMethod r_HasError;
		public virtual RMethod RHasError
		{
			get
			{
				if(r_HasError == null)
				{
					r_HasError = new(this, "HasError", 0);
					r_HasError.SetBelong(this.instance);
				}
				return r_HasError;
			}
		}

		/// <summary>
		/// Int32 GetLayerCount()
		/// </summary>
		protected RMethod r_GetLayerCount;
		public virtual RMethod RGetLayerCount
		{
			get
			{
				if(r_GetLayerCount == null)
				{
					r_GetLayerCount = new(this, "GetLayerCount", 0);
					r_GetLayerCount.SetBelong(this.instance);
				}
				return r_GetLayerCount;
			}
		}

		/// <summary>
		/// Int32 GetLayerDataSize()
		/// </summary>
		protected RMethod r_GetLayerDataSize;
		public virtual RMethod RGetLayerDataSize
		{
			get
			{
				if(r_GetLayerDataSize == null)
				{
					r_GetLayerDataSize = new(this, "GetLayerDataSize", 0);
					r_GetLayerDataSize.SetBelong(this.instance);
				}
				return r_GetLayerDataSize;
			}
		}

		/// <summary>
		/// Int32 GetWidth()
		/// </summary>
		protected RMethod r_GetWidth;
		public virtual RMethod RGetWidth
		{
			get
			{
				if(r_GetWidth == null)
				{
					r_GetWidth = new(this, "GetWidth", 0);
					r_GetWidth.SetBelong(this.instance);
				}
				return r_GetWidth;
			}
		}

		/// <summary>
		/// Int32 GetHeight()
		/// </summary>
		protected RMethod r_GetHeight;
		public virtual RMethod RGetHeight
		{
			get
			{
				if(r_GetHeight == null)
				{
					r_GetHeight = new(this, "GetHeight", 0);
					r_GetHeight.SetBelong(this.instance);
				}
				return r_GetHeight;
			}
		}

		/// <summary>
		/// Int32 GetDepth()
		/// </summary>
		protected RMethod r_GetDepth;
		public virtual RMethod RGetDepth
		{
			get
			{
				if(r_GetDepth == null)
				{
					r_GetDepth = new(this, "GetDepth", 0);
					r_GetDepth.SetBelong(this.instance);
				}
				return r_GetDepth;
			}
		}

		/// <summary>
		/// Void CreateSafetyHandle()
		/// </summary>
		protected RMethod r_CreateSafetyHandle;
		public virtual RMethod RCreateSafetyHandle
		{
			get
			{
				if(r_CreateSafetyHandle == null)
				{
					r_CreateSafetyHandle = new(this, "CreateSafetyHandle", 0);
					r_CreateSafetyHandle.SetBelong(this.instance);
				}
				return r_CreateSafetyHandle;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetSafetyHandle()
		/// </summary>
		protected RMethod r_GetSafetyHandle;
		public virtual RMethod RGetSafetyHandle
		{
			get
			{
				if(r_GetSafetyHandle == null)
				{
					r_GetSafetyHandle = new(this, "GetSafetyHandle", 0);
					r_GetSafetyHandle.SetBelong(this.instance);
				}
				return r_GetSafetyHandle;
			}
		}

		/// <summary>
		/// Void SetScriptingCallback(System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_SetScriptingCallback_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RSetScriptingCallback_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_SetScriptingCallback_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_SetScriptingCallback_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "SetScriptingCallback", 0, typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_SetScriptingCallback_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_SetScriptingCallback_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// IntPtr GetDataRaw(Int32)
		/// </summary>
		protected RMethod r_GetDataRaw_Int32;
		public virtual RMethod RGetDataRaw_Int32
		{
			get
			{
				if(r_GetDataRaw_Int32 == null)
				{
					r_GetDataRaw_Int32 = new(this, "GetDataRaw", 0, typeof(System.Int32));
					r_GetDataRaw_Int32.SetBelong(this.instance);
				}
				return r_GetDataRaw_Int32;
			}
		}

		/// <summary>
		/// Void Update_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest ByRef)
		/// </summary>
		protected static RMethod r_Update_Injected_Ref_AsyncGPUReadbackRequest;
		public static RMethod RUpdate_Injected_Ref_AsyncGPUReadbackRequest
		{
			get
			{
				if(r_Update_Injected_Ref_AsyncGPUReadbackRequest == null)
				{
					r_Update_Injected_Ref_AsyncGPUReadbackRequest = new(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest), "Update_Injected", 0, typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest).MakeByRefType());
					r_Update_Injected_Ref_AsyncGPUReadbackRequest.SetBelong(null);
				}
				return r_Update_Injected_Ref_AsyncGPUReadbackRequest;
			}
		}

		/// <summary>
		/// Void WaitForCompletion_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest ByRef)
		/// </summary>
		protected static RMethod r_WaitForCompletion_Injected_Ref_AsyncGPUReadbackRequest;
		public static RMethod RWaitForCompletion_Injected_Ref_AsyncGPUReadbackRequest
		{
			get
			{
				if(r_WaitForCompletion_Injected_Ref_AsyncGPUReadbackRequest == null)
				{
					r_WaitForCompletion_Injected_Ref_AsyncGPUReadbackRequest = new(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest), "WaitForCompletion_Injected", 0, typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest).MakeByRefType());
					r_WaitForCompletion_Injected_Ref_AsyncGPUReadbackRequest.SetBelong(null);
				}
				return r_WaitForCompletion_Injected_Ref_AsyncGPUReadbackRequest;
			}
		}

		/// <summary>
		/// Boolean IsDone_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest ByRef)
		/// </summary>
		protected static RMethod r_IsDone_Injected_Ref_AsyncGPUReadbackRequest;
		public static RMethod RIsDone_Injected_Ref_AsyncGPUReadbackRequest
		{
			get
			{
				if(r_IsDone_Injected_Ref_AsyncGPUReadbackRequest == null)
				{
					r_IsDone_Injected_Ref_AsyncGPUReadbackRequest = new(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest), "IsDone_Injected", 0, typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest).MakeByRefType());
					r_IsDone_Injected_Ref_AsyncGPUReadbackRequest.SetBelong(null);
				}
				return r_IsDone_Injected_Ref_AsyncGPUReadbackRequest;
			}
		}

		/// <summary>
		/// Boolean HasError_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest ByRef)
		/// </summary>
		protected static RMethod r_HasError_Injected_Ref_AsyncGPUReadbackRequest;
		public static RMethod RHasError_Injected_Ref_AsyncGPUReadbackRequest
		{
			get
			{
				if(r_HasError_Injected_Ref_AsyncGPUReadbackRequest == null)
				{
					r_HasError_Injected_Ref_AsyncGPUReadbackRequest = new(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest), "HasError_Injected", 0, typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest).MakeByRefType());
					r_HasError_Injected_Ref_AsyncGPUReadbackRequest.SetBelong(null);
				}
				return r_HasError_Injected_Ref_AsyncGPUReadbackRequest;
			}
		}

		/// <summary>
		/// Int32 GetLayerCount_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest ByRef)
		/// </summary>
		protected static RMethod r_GetLayerCount_Injected_Ref_AsyncGPUReadbackRequest;
		public static RMethod RGetLayerCount_Injected_Ref_AsyncGPUReadbackRequest
		{
			get
			{
				if(r_GetLayerCount_Injected_Ref_AsyncGPUReadbackRequest == null)
				{
					r_GetLayerCount_Injected_Ref_AsyncGPUReadbackRequest = new(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest), "GetLayerCount_Injected", 0, typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest).MakeByRefType());
					r_GetLayerCount_Injected_Ref_AsyncGPUReadbackRequest.SetBelong(null);
				}
				return r_GetLayerCount_Injected_Ref_AsyncGPUReadbackRequest;
			}
		}

		/// <summary>
		/// Int32 GetLayerDataSize_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest ByRef)
		/// </summary>
		protected static RMethod r_GetLayerDataSize_Injected_Ref_AsyncGPUReadbackRequest;
		public static RMethod RGetLayerDataSize_Injected_Ref_AsyncGPUReadbackRequest
		{
			get
			{
				if(r_GetLayerDataSize_Injected_Ref_AsyncGPUReadbackRequest == null)
				{
					r_GetLayerDataSize_Injected_Ref_AsyncGPUReadbackRequest = new(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest), "GetLayerDataSize_Injected", 0, typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest).MakeByRefType());
					r_GetLayerDataSize_Injected_Ref_AsyncGPUReadbackRequest.SetBelong(null);
				}
				return r_GetLayerDataSize_Injected_Ref_AsyncGPUReadbackRequest;
			}
		}

		/// <summary>
		/// Int32 GetWidth_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest ByRef)
		/// </summary>
		protected static RMethod r_GetWidth_Injected_Ref_AsyncGPUReadbackRequest;
		public static RMethod RGetWidth_Injected_Ref_AsyncGPUReadbackRequest
		{
			get
			{
				if(r_GetWidth_Injected_Ref_AsyncGPUReadbackRequest == null)
				{
					r_GetWidth_Injected_Ref_AsyncGPUReadbackRequest = new(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest), "GetWidth_Injected", 0, typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest).MakeByRefType());
					r_GetWidth_Injected_Ref_AsyncGPUReadbackRequest.SetBelong(null);
				}
				return r_GetWidth_Injected_Ref_AsyncGPUReadbackRequest;
			}
		}

		/// <summary>
		/// Int32 GetHeight_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest ByRef)
		/// </summary>
		protected static RMethod r_GetHeight_Injected_Ref_AsyncGPUReadbackRequest;
		public static RMethod RGetHeight_Injected_Ref_AsyncGPUReadbackRequest
		{
			get
			{
				if(r_GetHeight_Injected_Ref_AsyncGPUReadbackRequest == null)
				{
					r_GetHeight_Injected_Ref_AsyncGPUReadbackRequest = new(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest), "GetHeight_Injected", 0, typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest).MakeByRefType());
					r_GetHeight_Injected_Ref_AsyncGPUReadbackRequest.SetBelong(null);
				}
				return r_GetHeight_Injected_Ref_AsyncGPUReadbackRequest;
			}
		}

		/// <summary>
		/// Int32 GetDepth_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest ByRef)
		/// </summary>
		protected static RMethod r_GetDepth_Injected_Ref_AsyncGPUReadbackRequest;
		public static RMethod RGetDepth_Injected_Ref_AsyncGPUReadbackRequest
		{
			get
			{
				if(r_GetDepth_Injected_Ref_AsyncGPUReadbackRequest == null)
				{
					r_GetDepth_Injected_Ref_AsyncGPUReadbackRequest = new(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest), "GetDepth_Injected", 0, typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest).MakeByRefType());
					r_GetDepth_Injected_Ref_AsyncGPUReadbackRequest.SetBelong(null);
				}
				return r_GetDepth_Injected_Ref_AsyncGPUReadbackRequest;
			}
		}

		/// <summary>
		/// Void CreateSafetyHandle_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest ByRef)
		/// </summary>
		protected static RMethod r_CreateSafetyHandle_Injected_Ref_AsyncGPUReadbackRequest;
		public static RMethod RCreateSafetyHandle_Injected_Ref_AsyncGPUReadbackRequest
		{
			get
			{
				if(r_CreateSafetyHandle_Injected_Ref_AsyncGPUReadbackRequest == null)
				{
					r_CreateSafetyHandle_Injected_Ref_AsyncGPUReadbackRequest = new(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest), "CreateSafetyHandle_Injected", 0, typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest).MakeByRefType());
					r_CreateSafetyHandle_Injected_Ref_AsyncGPUReadbackRequest.SetBelong(null);
				}
				return r_CreateSafetyHandle_Injected_Ref_AsyncGPUReadbackRequest;
			}
		}

		/// <summary>
		/// Void GetSafetyHandle_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest ByRef, Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_GetSafetyHandle_Injected_Ref_AsyncGPUReadbackRequest_Out_AtomicSafetyHandle;
		public static RMethod RGetSafetyHandle_Injected_Ref_AsyncGPUReadbackRequest_Out_AtomicSafetyHandle
		{
			get
			{
				if(r_GetSafetyHandle_Injected_Ref_AsyncGPUReadbackRequest_Out_AtomicSafetyHandle == null)
				{
					r_GetSafetyHandle_Injected_Ref_AsyncGPUReadbackRequest_Out_AtomicSafetyHandle = new(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest), "GetSafetyHandle_Injected", 0, typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest).MakeByRefType(), typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_GetSafetyHandle_Injected_Ref_AsyncGPUReadbackRequest_Out_AtomicSafetyHandle.SetBelong(null);
				}
				return r_GetSafetyHandle_Injected_Ref_AsyncGPUReadbackRequest_Out_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void SetScriptingCallback_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest ByRef, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected static RMethod r_SetScriptingCallback_Injected_Ref_AsyncGPUReadbackRequest_Action_d_AsyncGPUReadbackRequest_p_;
		public static RMethod RSetScriptingCallback_Injected_Ref_AsyncGPUReadbackRequest_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_SetScriptingCallback_Injected_Ref_AsyncGPUReadbackRequest_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_SetScriptingCallback_Injected_Ref_AsyncGPUReadbackRequest_Action_d_AsyncGPUReadbackRequest_p_ = new(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest), "SetScriptingCallback_Injected", 0, typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest).MakeByRefType(), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_SetScriptingCallback_Injected_Ref_AsyncGPUReadbackRequest_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(null);
				}
				return r_SetScriptingCallback_Injected_Ref_AsyncGPUReadbackRequest_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// IntPtr GetDataRaw_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest ByRef, Int32)
		/// </summary>
		protected static RMethod r_GetDataRaw_Injected_Ref_AsyncGPUReadbackRequest_Int32;
		public static RMethod RGetDataRaw_Injected_Ref_AsyncGPUReadbackRequest_Int32
		{
			get
			{
				if(r_GetDataRaw_Injected_Ref_AsyncGPUReadbackRequest_Int32 == null)
				{
					r_GetDataRaw_Injected_Ref_AsyncGPUReadbackRequest_Int32 = new(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest), "GetDataRaw_Injected", 0, typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest).MakeByRefType(), typeof(System.Int32));
					r_GetDataRaw_Injected_Ref_AsyncGPUReadbackRequest_Int32.SetBelong(null);
				}
				return r_GetDataRaw_Injected_Ref_AsyncGPUReadbackRequest_Int32;
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

        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WaitForCompletion()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWaitForCompletion.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetData<T>(System.Int32 @layer) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@layer};
            var ___result = RGetData_GT_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean IsDone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsDone.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasError()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHasError.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetLayerCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLayerCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetLayerDataSize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLayerDataSize.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetWidth()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetWidth.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHeight()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHeight.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetDepth()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDepth.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void CreateSafetyHandle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateSafetyHandle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetSafetyHandle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSafetyHandle.Invoke(___genericsType, ___parameters);

            return (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___result;
        }


        public virtual void SetScriptingCallback(System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback};
            var ___result = RSetScriptingCallback_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IntPtr GetDataRaw(System.Int32 @layer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@layer};
            var ___result = RGetDataRaw_Int32.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static void Update_Injected(ref UnityEngine.Rendering.AsyncGPUReadbackRequest @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RUpdate_Injected_Ref_AsyncGPUReadbackRequest.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.AsyncGPUReadbackRequest)___parameters[0];

            
        }


        public static void WaitForCompletion_Injected(ref UnityEngine.Rendering.AsyncGPUReadbackRequest @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RWaitForCompletion_Injected_Ref_AsyncGPUReadbackRequest.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.AsyncGPUReadbackRequest)___parameters[0];

            
        }


        public static System.Boolean IsDone_Injected(ref UnityEngine.Rendering.AsyncGPUReadbackRequest @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RIsDone_Injected_Ref_AsyncGPUReadbackRequest.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.AsyncGPUReadbackRequest)___parameters[0];

            return (System.Boolean)___result;
        }


        public static System.Boolean HasError_Injected(ref UnityEngine.Rendering.AsyncGPUReadbackRequest @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RHasError_Injected_Ref_AsyncGPUReadbackRequest.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.AsyncGPUReadbackRequest)___parameters[0];

            return (System.Boolean)___result;
        }


        public static System.Int32 GetLayerCount_Injected(ref UnityEngine.Rendering.AsyncGPUReadbackRequest @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RGetLayerCount_Injected_Ref_AsyncGPUReadbackRequest.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.AsyncGPUReadbackRequest)___parameters[0];

            return (System.Int32)___result;
        }


        public static System.Int32 GetLayerDataSize_Injected(ref UnityEngine.Rendering.AsyncGPUReadbackRequest @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RGetLayerDataSize_Injected_Ref_AsyncGPUReadbackRequest.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.AsyncGPUReadbackRequest)___parameters[0];

            return (System.Int32)___result;
        }


        public static System.Int32 GetWidth_Injected(ref UnityEngine.Rendering.AsyncGPUReadbackRequest @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RGetWidth_Injected_Ref_AsyncGPUReadbackRequest.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.AsyncGPUReadbackRequest)___parameters[0];

            return (System.Int32)___result;
        }


        public static System.Int32 GetHeight_Injected(ref UnityEngine.Rendering.AsyncGPUReadbackRequest @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RGetHeight_Injected_Ref_AsyncGPUReadbackRequest.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.AsyncGPUReadbackRequest)___parameters[0];

            return (System.Int32)___result;
        }


        public static System.Int32 GetDepth_Injected(ref UnityEngine.Rendering.AsyncGPUReadbackRequest @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RGetDepth_Injected_Ref_AsyncGPUReadbackRequest.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.AsyncGPUReadbackRequest)___parameters[0];

            return (System.Int32)___result;
        }


        public static void CreateSafetyHandle_Injected(ref UnityEngine.Rendering.AsyncGPUReadbackRequest @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RCreateSafetyHandle_Injected_Ref_AsyncGPUReadbackRequest.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.AsyncGPUReadbackRequest)___parameters[0];

            
        }


        public static void GetSafetyHandle_Injected(ref UnityEngine.Rendering.AsyncGPUReadbackRequest @_unity_self, out Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self, @ret};
            var ___result = RGetSafetyHandle_Injected_Ref_AsyncGPUReadbackRequest_Out_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.AsyncGPUReadbackRequest)___parameters[0];
			@ret = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[1];

            
        }


        public static void SetScriptingCallback_Injected(ref UnityEngine.Rendering.AsyncGPUReadbackRequest @_unity_self, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self, @callback};
            var ___result = RSetScriptingCallback_Injected_Ref_AsyncGPUReadbackRequest_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.AsyncGPUReadbackRequest)___parameters[0];

            
        }


        public static System.IntPtr GetDataRaw_Injected(ref UnityEngine.Rendering.AsyncGPUReadbackRequest @_unity_self, System.Int32 @layer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self, @layer};
            var ___result = RGetDataRaw_Injected_Ref_AsyncGPUReadbackRequest_Int32.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.AsyncGPUReadbackRequest)___parameters[0];

            return (System.IntPtr)___result;
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
