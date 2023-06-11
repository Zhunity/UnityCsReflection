
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
	/// UnityEngine.Rendering.CommandBuffer
	/// </summary>
    public partial class RCommandBuffer : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.Rendering.CommandBuffer);
            }
        }

        public RCommandBuffer() : base("UnityEngine.Rendering.CommandBuffer")
        {
        }

        public RCommandBuffer(System.Object instance) : base("UnityEngine.Rendering.CommandBuffer")
		{
            SetInstance(instance);
		}

        public RCommandBuffer(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCommandBuffer(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// Int32 sizeInBytes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PsizeInBytes;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPsizeInBytes
		{
			get
			{
				if(r_PsizeInBytes == null)
				{
					r_PsizeInBytes = new(this, "sizeInBytes", -1);
				}
				return r_PsizeInBytes;
			}
		}

		/// <summary>
		/// Void ConvertTexture(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_MConvertTexture_RenderTargetIdentifier_RenderTargetIdentifier;
		public virtual RMethod RMConvertTexture_RenderTargetIdentifier_RenderTargetIdentifier
		{
			get
			{
				if(r_MConvertTexture_RenderTargetIdentifier_RenderTargetIdentifier == null)
				{
					r_MConvertTexture_RenderTargetIdentifier_RenderTargetIdentifier = new(this, "ConvertTexture", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier));
				}
				return r_MConvertTexture_RenderTargetIdentifier_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void ConvertTexture(UnityEngine.Rendering.RenderTargetIdentifier, Int32, UnityEngine.Rendering.RenderTargetIdentifier, Int32)
		/// </summary>
		protected RMethod r_MConvertTexture_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32;
		public virtual RMethod RMConvertTexture_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32
		{
			get
			{
				if(r_MConvertTexture_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32 == null)
				{
					r_MConvertTexture_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32 = new(this, "ConvertTexture", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32));
				}
				return r_MConvertTexture_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32;
			}
		}

		/// <summary>
		/// Void WaitAllAsyncReadbackRequests()
		/// </summary>
		protected RMethod r_MWaitAllAsyncReadbackRequests;
		public virtual RMethod RMWaitAllAsyncReadbackRequests
		{
			get
			{
				if(r_MWaitAllAsyncReadbackRequests == null)
				{
					r_MWaitAllAsyncReadbackRequests = new(this, "WaitAllAsyncReadbackRequests", 0);
				}
				return r_MWaitAllAsyncReadbackRequests;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadback(UnityEngine.ComputeBuffer, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MRequestAsyncReadback_ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMRequestAsyncReadback_ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MRequestAsyncReadback_ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MRequestAsyncReadback_ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadback", 0, typeof(UnityEngine.ComputeBuffer),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MRequestAsyncReadback_ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadback(UnityEngine.GraphicsBuffer, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MRequestAsyncReadback_GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMRequestAsyncReadback_GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MRequestAsyncReadback_GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MRequestAsyncReadback_GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadback", 0, typeof(UnityEngine.GraphicsBuffer),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MRequestAsyncReadback_GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadback(UnityEngine.ComputeBuffer, Int32, Int32, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MRequestAsyncReadback_ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMRequestAsyncReadback_ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MRequestAsyncReadback_ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MRequestAsyncReadback_ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadback", 0, typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MRequestAsyncReadback_ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadback(UnityEngine.GraphicsBuffer, Int32, Int32, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MRequestAsyncReadback_GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMRequestAsyncReadback_GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MRequestAsyncReadback_GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MRequestAsyncReadback_GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadback", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MRequestAsyncReadback_GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadback(UnityEngine.Texture, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MRequestAsyncReadback_Texture_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMRequestAsyncReadback_Texture_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MRequestAsyncReadback_Texture_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MRequestAsyncReadback_Texture_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadback", 0, typeof(UnityEngine.Texture),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MRequestAsyncReadback_Texture_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadback(UnityEngine.Texture, Int32, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MRequestAsyncReadback_Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMRequestAsyncReadback_Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MRequestAsyncReadback_Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MRequestAsyncReadback_Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadback", 0, typeof(UnityEngine.Texture), typeof(System.Int32),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MRequestAsyncReadback_Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadback(UnityEngine.Texture, Int32, UnityEngine.TextureFormat, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MRequestAsyncReadback_Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMRequestAsyncReadback_Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MRequestAsyncReadback_Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MRequestAsyncReadback_Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadback", 0, typeof(UnityEngine.Texture), typeof(System.Int32), typeof(UnityEngine.TextureFormat),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MRequestAsyncReadback_Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadback(UnityEngine.Texture, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MRequestAsyncReadback_Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMRequestAsyncReadback_Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MRequestAsyncReadback_Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MRequestAsyncReadback_Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadback", 0, typeof(UnityEngine.Texture), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MRequestAsyncReadback_Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadback(UnityEngine.Texture, Int32, Int32, Int32, Int32, Int32, Int32, Int32, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadback", 0, typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadback(UnityEngine.Texture, Int32, Int32, Int32, Int32, Int32, Int32, Int32, UnityEngine.TextureFormat, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadback", 0, typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextureFormat),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadback(UnityEngine.Texture, Int32, Int32, Int32, Int32, Int32, Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadback", 0, typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeArray[T](Unity.Collections.NativeArray`1[T] ByRef, UnityEngine.ComputeBuffer, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeArray", 1,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.ComputeBuffer),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeArray[T](Unity.Collections.NativeArray`1[T] ByRef, UnityEngine.ComputeBuffer, Int32, Int32, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeArray", 1,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeArray[T](Unity.Collections.NativeArray`1[T] ByRef, UnityEngine.GraphicsBuffer, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeArray", 1,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.GraphicsBuffer),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeArray[T](Unity.Collections.NativeArray`1[T] ByRef, UnityEngine.GraphicsBuffer, Int32, Int32, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeArray", 1,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeArray[T](Unity.Collections.NativeArray`1[T] ByRef, UnityEngine.Texture, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeArray", 1,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.Texture),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeArray[T](Unity.Collections.NativeArray`1[T] ByRef, UnityEngine.Texture, Int32, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeArray", 1,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.Texture), typeof(System.Int32),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeArray[T](Unity.Collections.NativeArray`1[T] ByRef, UnityEngine.Texture, Int32, UnityEngine.TextureFormat, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeArray", 1,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.Texture), typeof(System.Int32), typeof(UnityEngine.TextureFormat),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeArray[T](Unity.Collections.NativeArray`1[T] ByRef, UnityEngine.Texture, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeArray", 1,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.Texture), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeArray[T](Unity.Collections.NativeArray`1[T] ByRef, UnityEngine.Texture, Int32, Int32, Int32, Int32, Int32, Int32, Int32, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeArray", 1,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeArray[T](Unity.Collections.NativeArray`1[T] ByRef, UnityEngine.Texture, Int32, Int32, Int32, Int32, Int32, Int32, Int32, UnityEngine.TextureFormat, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeArray", 1,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextureFormat),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeArray[T](Unity.Collections.NativeArray`1[T] ByRef, UnityEngine.Texture, Int32, Int32, Int32, Int32, Int32, Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeArray", 1,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeSlice[T](Unity.Collections.NativeSlice`1[T] ByRef, UnityEngine.ComputeBuffer, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeSlice", 1,  ReflectionUtils.GetType("Unity.Collections.NativeSlice`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.ComputeBuffer),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeSlice[T](Unity.Collections.NativeSlice`1[T] ByRef, UnityEngine.ComputeBuffer, Int32, Int32, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeSlice", 1,  ReflectionUtils.GetType("Unity.Collections.NativeSlice`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeSlice[T](Unity.Collections.NativeSlice`1[T] ByRef, UnityEngine.GraphicsBuffer, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeSlice", 1,  ReflectionUtils.GetType("Unity.Collections.NativeSlice`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.GraphicsBuffer),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeSlice[T](Unity.Collections.NativeSlice`1[T] ByRef, UnityEngine.GraphicsBuffer, Int32, Int32, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeSlice", 1,  ReflectionUtils.GetType("Unity.Collections.NativeSlice`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeSlice[T](Unity.Collections.NativeSlice`1[T] ByRef, UnityEngine.Texture, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeSlice", 1,  ReflectionUtils.GetType("Unity.Collections.NativeSlice`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.Texture),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeSlice[T](Unity.Collections.NativeSlice`1[T] ByRef, UnityEngine.Texture, Int32, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeSlice", 1,  ReflectionUtils.GetType("Unity.Collections.NativeSlice`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.Texture), typeof(System.Int32),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeSlice[T](Unity.Collections.NativeSlice`1[T] ByRef, UnityEngine.Texture, Int32, UnityEngine.TextureFormat, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeSlice", 1,  ReflectionUtils.GetType("Unity.Collections.NativeSlice`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.Texture), typeof(System.Int32), typeof(UnityEngine.TextureFormat),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeSlice[T](Unity.Collections.NativeSlice`1[T] ByRef, UnityEngine.Texture, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeSlice", 1,  ReflectionUtils.GetType("Unity.Collections.NativeSlice`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.Texture), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeSlice[T](Unity.Collections.NativeSlice`1[T] ByRef, UnityEngine.Texture, Int32, Int32, Int32, Int32, Int32, Int32, Int32, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeSlice", 1,  ReflectionUtils.GetType("Unity.Collections.NativeSlice`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeSlice[T](Unity.Collections.NativeSlice`1[T] ByRef, UnityEngine.Texture, Int32, Int32, Int32, Int32, Int32, Int32, Int32, UnityEngine.TextureFormat, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeSlice", 1,  ReflectionUtils.GetType("Unity.Collections.NativeSlice`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextureFormat),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeSlice[T](Unity.Collections.NativeSlice`1[T] ByRef, UnityEngine.Texture, Int32, Int32, Int32, Int32, Int32, Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RMRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeSlice", 1,  ReflectionUtils.GetType("Unity.Collections.NativeSlice`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
				}
				return r_MRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void Internal_RequestAsyncReadback_1(UnityEngine.ComputeBuffer, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest], UnityEngine.Rendering.AsyncRequestNativeArrayData*)
		/// </summary>
		protected RMethod r_MInternal_RequestAsyncReadback_1_ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
		public virtual RMethod RMInternal_RequestAsyncReadback_1_ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer
		{
			get
			{
				if(r_MInternal_RequestAsyncReadback_1_ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer == null)
				{
					r_MInternal_RequestAsyncReadback_1_ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer = new(this, "Internal_RequestAsyncReadback_1", 0, typeof(UnityEngine.ComputeBuffer),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)),  ReflectionUtils.GetType("UnityEngine.Rendering.AsyncRequestNativeArrayData").MakePointerType());
				}
				return r_MInternal_RequestAsyncReadback_1_ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
			}
		}

		/// <summary>
		/// Void Internal_RequestAsyncReadback_2(UnityEngine.ComputeBuffer, Int32, Int32, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest], UnityEngine.Rendering.AsyncRequestNativeArrayData*)
		/// </summary>
		protected RMethod r_MInternal_RequestAsyncReadback_2_ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
		public virtual RMethod RMInternal_RequestAsyncReadback_2_ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer
		{
			get
			{
				if(r_MInternal_RequestAsyncReadback_2_ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer == null)
				{
					r_MInternal_RequestAsyncReadback_2_ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer = new(this, "Internal_RequestAsyncReadback_2", 0, typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)),  ReflectionUtils.GetType("UnityEngine.Rendering.AsyncRequestNativeArrayData").MakePointerType());
				}
				return r_MInternal_RequestAsyncReadback_2_ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
			}
		}

		/// <summary>
		/// Void Internal_RequestAsyncReadback_3(UnityEngine.Texture, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest], UnityEngine.Rendering.AsyncRequestNativeArrayData*)
		/// </summary>
		protected RMethod r_MInternal_RequestAsyncReadback_3_Texture_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
		public virtual RMethod RMInternal_RequestAsyncReadback_3_Texture_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer
		{
			get
			{
				if(r_MInternal_RequestAsyncReadback_3_Texture_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer == null)
				{
					r_MInternal_RequestAsyncReadback_3_Texture_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer = new(this, "Internal_RequestAsyncReadback_3", 0, typeof(UnityEngine.Texture),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)),  ReflectionUtils.GetType("UnityEngine.Rendering.AsyncRequestNativeArrayData").MakePointerType());
				}
				return r_MInternal_RequestAsyncReadback_3_Texture_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
			}
		}

		/// <summary>
		/// Void Internal_RequestAsyncReadback_4(UnityEngine.Texture, Int32, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest], UnityEngine.Rendering.AsyncRequestNativeArrayData*)
		/// </summary>
		protected RMethod r_MInternal_RequestAsyncReadback_4_Texture_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
		public virtual RMethod RMInternal_RequestAsyncReadback_4_Texture_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer
		{
			get
			{
				if(r_MInternal_RequestAsyncReadback_4_Texture_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer == null)
				{
					r_MInternal_RequestAsyncReadback_4_Texture_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer = new(this, "Internal_RequestAsyncReadback_4", 0, typeof(UnityEngine.Texture), typeof(System.Int32),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)),  ReflectionUtils.GetType("UnityEngine.Rendering.AsyncRequestNativeArrayData").MakePointerType());
				}
				return r_MInternal_RequestAsyncReadback_4_Texture_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
			}
		}

		/// <summary>
		/// Void Internal_RequestAsyncReadback_5(UnityEngine.Texture, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest], UnityEngine.Rendering.AsyncRequestNativeArrayData*)
		/// </summary>
		protected RMethod r_MInternal_RequestAsyncReadback_5_Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
		public virtual RMethod RMInternal_RequestAsyncReadback_5_Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer
		{
			get
			{
				if(r_MInternal_RequestAsyncReadback_5_Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer == null)
				{
					r_MInternal_RequestAsyncReadback_5_Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer = new(this, "Internal_RequestAsyncReadback_5", 0, typeof(UnityEngine.Texture), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)),  ReflectionUtils.GetType("UnityEngine.Rendering.AsyncRequestNativeArrayData").MakePointerType());
				}
				return r_MInternal_RequestAsyncReadback_5_Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
			}
		}

		/// <summary>
		/// Void Internal_RequestAsyncReadback_6(UnityEngine.Texture, Int32, Int32, Int32, Int32, Int32, Int32, Int32, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest], UnityEngine.Rendering.AsyncRequestNativeArrayData*)
		/// </summary>
		protected RMethod r_MInternal_RequestAsyncReadback_6_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
		public virtual RMethod RMInternal_RequestAsyncReadback_6_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer
		{
			get
			{
				if(r_MInternal_RequestAsyncReadback_6_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer == null)
				{
					r_MInternal_RequestAsyncReadback_6_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer = new(this, "Internal_RequestAsyncReadback_6", 0, typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)),  ReflectionUtils.GetType("UnityEngine.Rendering.AsyncRequestNativeArrayData").MakePointerType());
				}
				return r_MInternal_RequestAsyncReadback_6_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
			}
		}

		/// <summary>
		/// Void Internal_RequestAsyncReadback_7(UnityEngine.Texture, Int32, Int32, Int32, Int32, Int32, Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest], UnityEngine.Rendering.AsyncRequestNativeArrayData*)
		/// </summary>
		protected RMethod r_MInternal_RequestAsyncReadback_7_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
		public virtual RMethod RMInternal_RequestAsyncReadback_7_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer
		{
			get
			{
				if(r_MInternal_RequestAsyncReadback_7_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer == null)
				{
					r_MInternal_RequestAsyncReadback_7_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer = new(this, "Internal_RequestAsyncReadback_7", 0, typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)),  ReflectionUtils.GetType("UnityEngine.Rendering.AsyncRequestNativeArrayData").MakePointerType());
				}
				return r_MInternal_RequestAsyncReadback_7_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
			}
		}

		/// <summary>
		/// Void Internal_RequestAsyncReadback_8(UnityEngine.GraphicsBuffer, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest], UnityEngine.Rendering.AsyncRequestNativeArrayData*)
		/// </summary>
		protected RMethod r_MInternal_RequestAsyncReadback_8_GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
		public virtual RMethod RMInternal_RequestAsyncReadback_8_GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer
		{
			get
			{
				if(r_MInternal_RequestAsyncReadback_8_GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer == null)
				{
					r_MInternal_RequestAsyncReadback_8_GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer = new(this, "Internal_RequestAsyncReadback_8", 0, typeof(UnityEngine.GraphicsBuffer),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)),  ReflectionUtils.GetType("UnityEngine.Rendering.AsyncRequestNativeArrayData").MakePointerType());
				}
				return r_MInternal_RequestAsyncReadback_8_GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
			}
		}

		/// <summary>
		/// Void Internal_RequestAsyncReadback_9(UnityEngine.GraphicsBuffer, Int32, Int32, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest], UnityEngine.Rendering.AsyncRequestNativeArrayData*)
		/// </summary>
		protected RMethod r_MInternal_RequestAsyncReadback_9_GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
		public virtual RMethod RMInternal_RequestAsyncReadback_9_GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer
		{
			get
			{
				if(r_MInternal_RequestAsyncReadback_9_GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer == null)
				{
					r_MInternal_RequestAsyncReadback_9_GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer = new(this, "Internal_RequestAsyncReadback_9", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)),  ReflectionUtils.GetType("UnityEngine.Rendering.AsyncRequestNativeArrayData").MakePointerType());
				}
				return r_MInternal_RequestAsyncReadback_9_GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
			}
		}

		/// <summary>
		/// Void SetInvertCulling(Boolean)
		/// </summary>
		protected RMethod r_MSetInvertCulling_Boolean;
		public virtual RMethod RMSetInvertCulling_Boolean
		{
			get
			{
				if(r_MSetInvertCulling_Boolean == null)
				{
					r_MSetInvertCulling_Boolean = new(this, "SetInvertCulling", 0, typeof(System.Boolean));
				}
				return r_MSetInvertCulling_Boolean;
			}
		}

		/// <summary>
		/// Void ConvertTexture_Internal(UnityEngine.Rendering.RenderTargetIdentifier, Int32, UnityEngine.Rendering.RenderTargetIdentifier, Int32)
		/// </summary>
		protected RMethod r_MConvertTexture_Internal_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32;
		public virtual RMethod RMConvertTexture_Internal_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32
		{
			get
			{
				if(r_MConvertTexture_Internal_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32 == null)
				{
					r_MConvertTexture_Internal_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32 = new(this, "ConvertTexture_Internal", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32));
				}
				return r_MConvertTexture_Internal_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32;
			}
		}

		/// <summary>
		/// Void Internal_SetSinglePassStereo(UnityEngine.Rendering.SinglePassStereoMode)
		/// </summary>
		protected RMethod r_MInternal_SetSinglePassStereo_SinglePassStereoMode;
		public virtual RMethod RMInternal_SetSinglePassStereo_SinglePassStereoMode
		{
			get
			{
				if(r_MInternal_SetSinglePassStereo_SinglePassStereoMode == null)
				{
					r_MInternal_SetSinglePassStereo_SinglePassStereoMode = new(this, "Internal_SetSinglePassStereo", 0, typeof(UnityEngine.Rendering.SinglePassStereoMode));
				}
				return r_MInternal_SetSinglePassStereo_SinglePassStereoMode;
			}
		}

		/// <summary>
		/// IntPtr InitBuffer()
		/// </summary>
		protected static RMethod r_MInitBuffer;
		public static RMethod RMInitBuffer
		{
			get
			{
				if(r_MInitBuffer == null)
				{
					r_MInitBuffer = new(typeof(UnityEngine.Rendering.CommandBuffer), "InitBuffer", 0);
				}
				return r_MInitBuffer;
			}
		}

		/// <summary>
		/// IntPtr CreateGPUFence_Internal(UnityEngine.Rendering.GraphicsFenceType, UnityEngine.Rendering.SynchronisationStageFlags)
		/// </summary>
		protected RMethod r_MCreateGPUFence_Internal_GraphicsFenceType_SynchronisationStageFlags;
		public virtual RMethod RMCreateGPUFence_Internal_GraphicsFenceType_SynchronisationStageFlags
		{
			get
			{
				if(r_MCreateGPUFence_Internal_GraphicsFenceType_SynchronisationStageFlags == null)
				{
					r_MCreateGPUFence_Internal_GraphicsFenceType_SynchronisationStageFlags = new(this, "CreateGPUFence_Internal", 0, typeof(UnityEngine.Rendering.GraphicsFenceType), typeof(UnityEngine.Rendering.SynchronisationStageFlags));
				}
				return r_MCreateGPUFence_Internal_GraphicsFenceType_SynchronisationStageFlags;
			}
		}

		/// <summary>
		/// Void WaitOnGPUFence_Internal(IntPtr, UnityEngine.Rendering.SynchronisationStageFlags)
		/// </summary>
		protected RMethod r_MWaitOnGPUFence_Internal_IntPtr_SynchronisationStageFlags;
		public virtual RMethod RMWaitOnGPUFence_Internal_IntPtr_SynchronisationStageFlags
		{
			get
			{
				if(r_MWaitOnGPUFence_Internal_IntPtr_SynchronisationStageFlags == null)
				{
					r_MWaitOnGPUFence_Internal_IntPtr_SynchronisationStageFlags = new(this, "WaitOnGPUFence_Internal", 0, typeof(System.IntPtr), typeof(UnityEngine.Rendering.SynchronisationStageFlags));
				}
				return r_MWaitOnGPUFence_Internal_IntPtr_SynchronisationStageFlags;
			}
		}

		/// <summary>
		/// Void ReleaseBuffer()
		/// </summary>
		protected RMethod r_MReleaseBuffer;
		public virtual RMethod RMReleaseBuffer
		{
			get
			{
				if(r_MReleaseBuffer == null)
				{
					r_MReleaseBuffer = new(this, "ReleaseBuffer", 0);
				}
				return r_MReleaseBuffer;
			}
		}

		/// <summary>
		/// Void SetComputeFloatParam(UnityEngine.ComputeShader, Int32, Single)
		/// </summary>
		protected RMethod r_MSetComputeFloatParam_ComputeShader_Int32_Single;
		public virtual RMethod RMSetComputeFloatParam_ComputeShader_Int32_Single
		{
			get
			{
				if(r_MSetComputeFloatParam_ComputeShader_Int32_Single == null)
				{
					r_MSetComputeFloatParam_ComputeShader_Int32_Single = new(this, "SetComputeFloatParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Single));
				}
				return r_MSetComputeFloatParam_ComputeShader_Int32_Single;
			}
		}

		/// <summary>
		/// Void SetComputeIntParam(UnityEngine.ComputeShader, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetComputeIntParam_ComputeShader_Int32_Int32;
		public virtual RMethod RMSetComputeIntParam_ComputeShader_Int32_Int32
		{
			get
			{
				if(r_MSetComputeIntParam_ComputeShader_Int32_Int32 == null)
				{
					r_MSetComputeIntParam_ComputeShader_Int32_Int32 = new(this, "SetComputeIntParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetComputeIntParam_ComputeShader_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetComputeVectorParam(UnityEngine.ComputeShader, Int32, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_MSetComputeVectorParam_ComputeShader_Int32_Vector4;
		public virtual RMethod RMSetComputeVectorParam_ComputeShader_Int32_Vector4
		{
			get
			{
				if(r_MSetComputeVectorParam_ComputeShader_Int32_Vector4 == null)
				{
					r_MSetComputeVectorParam_ComputeShader_Int32_Vector4 = new(this, "SetComputeVectorParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(UnityEngine.Vector4));
				}
				return r_MSetComputeVectorParam_ComputeShader_Int32_Vector4;
			}
		}

		/// <summary>
		/// Void SetComputeVectorArrayParam(UnityEngine.ComputeShader, Int32, UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_MSetComputeVectorArrayParam_ComputeShader_Int32_Vector4Array;
		public virtual RMethod RMSetComputeVectorArrayParam_ComputeShader_Int32_Vector4Array
		{
			get
			{
				if(r_MSetComputeVectorArrayParam_ComputeShader_Int32_Vector4Array == null)
				{
					r_MSetComputeVectorArrayParam_ComputeShader_Int32_Vector4Array = new(this, "SetComputeVectorArrayParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType());
				}
				return r_MSetComputeVectorArrayParam_ComputeShader_Int32_Vector4Array;
			}
		}

		/// <summary>
		/// Void SetComputeMatrixParam(UnityEngine.ComputeShader, Int32, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_MSetComputeMatrixParam_ComputeShader_Int32_Matrix4x4;
		public virtual RMethod RMSetComputeMatrixParam_ComputeShader_Int32_Matrix4x4
		{
			get
			{
				if(r_MSetComputeMatrixParam_ComputeShader_Int32_Matrix4x4 == null)
				{
					r_MSetComputeMatrixParam_ComputeShader_Int32_Matrix4x4 = new(this, "SetComputeMatrixParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(UnityEngine.Matrix4x4));
				}
				return r_MSetComputeMatrixParam_ComputeShader_Int32_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetComputeMatrixArrayParam(UnityEngine.ComputeShader, Int32, UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_MSetComputeMatrixArrayParam_ComputeShader_Int32_Matrix4x4Array;
		public virtual RMethod RMSetComputeMatrixArrayParam_ComputeShader_Int32_Matrix4x4Array
		{
			get
			{
				if(r_MSetComputeMatrixArrayParam_ComputeShader_Int32_Matrix4x4Array == null)
				{
					r_MSetComputeMatrixArrayParam_ComputeShader_Int32_Matrix4x4Array = new(this, "SetComputeMatrixArrayParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType());
				}
				return r_MSetComputeMatrixArrayParam_ComputeShader_Int32_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Void Internal_SetComputeFloats(UnityEngine.ComputeShader, Int32, Single[])
		/// </summary>
		protected RMethod r_MInternal_SetComputeFloats_ComputeShader_Int32_SingleArray;
		public virtual RMethod RMInternal_SetComputeFloats_ComputeShader_Int32_SingleArray
		{
			get
			{
				if(r_MInternal_SetComputeFloats_ComputeShader_Int32_SingleArray == null)
				{
					r_MInternal_SetComputeFloats_ComputeShader_Int32_SingleArray = new(this, "Internal_SetComputeFloats", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Single).MakeArrayType());
				}
				return r_MInternal_SetComputeFloats_ComputeShader_Int32_SingleArray;
			}
		}

		/// <summary>
		/// Void Internal_SetComputeInts(UnityEngine.ComputeShader, Int32, Int32[])
		/// </summary>
		protected RMethod r_MInternal_SetComputeInts_ComputeShader_Int32_Int32Array;
		public virtual RMethod RMInternal_SetComputeInts_ComputeShader_Int32_Int32Array
		{
			get
			{
				if(r_MInternal_SetComputeInts_ComputeShader_Int32_Int32Array == null)
				{
					r_MInternal_SetComputeInts_ComputeShader_Int32_Int32Array = new(this, "Internal_SetComputeInts", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Int32).MakeArrayType());
				}
				return r_MInternal_SetComputeInts_ComputeShader_Int32_Int32Array;
			}
		}

		/// <summary>
		/// Void Internal_SetComputeTextureParam(UnityEngine.ComputeShader, Int32, Int32, UnityEngine.Rendering.RenderTargetIdentifier ByRef, Int32, UnityEngine.Rendering.RenderTextureSubElement)
		/// </summary>
		protected RMethod r_MInternal_SetComputeTextureParam_ComputeShader_Int32_Int32_Ref_RenderTargetIdentifier_Int32_RenderTextureSubElement;
		public virtual RMethod RMInternal_SetComputeTextureParam_ComputeShader_Int32_Int32_Ref_RenderTargetIdentifier_Int32_RenderTextureSubElement
		{
			get
			{
				if(r_MInternal_SetComputeTextureParam_ComputeShader_Int32_Int32_Ref_RenderTargetIdentifier_Int32_RenderTextureSubElement == null)
				{
					r_MInternal_SetComputeTextureParam_ComputeShader_Int32_Int32_Ref_RenderTargetIdentifier_Int32_RenderTextureSubElement = new(this, "Internal_SetComputeTextureParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTextureSubElement));
				}
				return r_MInternal_SetComputeTextureParam_ComputeShader_Int32_Int32_Ref_RenderTargetIdentifier_Int32_RenderTextureSubElement;
			}
		}

		/// <summary>
		/// Void Internal_SetComputeBufferParam(UnityEngine.ComputeShader, Int32, Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_MInternal_SetComputeBufferParam_ComputeShader_Int32_Int32_ComputeBuffer;
		public virtual RMethod RMInternal_SetComputeBufferParam_ComputeShader_Int32_Int32_ComputeBuffer
		{
			get
			{
				if(r_MInternal_SetComputeBufferParam_ComputeShader_Int32_Int32_ComputeBuffer == null)
				{
					r_MInternal_SetComputeBufferParam_ComputeShader_Int32_Int32_ComputeBuffer = new(this, "Internal_SetComputeBufferParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
				}
				return r_MInternal_SetComputeBufferParam_ComputeShader_Int32_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void Internal_SetComputeGraphicsBufferHandleParam(UnityEngine.ComputeShader, Int32, Int32, UnityEngine.GraphicsBufferHandle)
		/// </summary>
		protected RMethod r_MInternal_SetComputeGraphicsBufferHandleParam_ComputeShader_Int32_Int32_GraphicsBufferHandle;
		public virtual RMethod RMInternal_SetComputeGraphicsBufferHandleParam_ComputeShader_Int32_Int32_GraphicsBufferHandle
		{
			get
			{
				if(r_MInternal_SetComputeGraphicsBufferHandleParam_ComputeShader_Int32_Int32_GraphicsBufferHandle == null)
				{
					r_MInternal_SetComputeGraphicsBufferHandleParam_ComputeShader_Int32_Int32_GraphicsBufferHandle = new(this, "Internal_SetComputeGraphicsBufferHandleParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.GraphicsBufferHandle));
				}
				return r_MInternal_SetComputeGraphicsBufferHandleParam_ComputeShader_Int32_Int32_GraphicsBufferHandle;
			}
		}

		/// <summary>
		/// Void Internal_SetComputeGraphicsBufferParam(UnityEngine.ComputeShader, Int32, Int32, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_MInternal_SetComputeGraphicsBufferParam_ComputeShader_Int32_Int32_GraphicsBuffer;
		public virtual RMethod RMInternal_SetComputeGraphicsBufferParam_ComputeShader_Int32_Int32_GraphicsBuffer
		{
			get
			{
				if(r_MInternal_SetComputeGraphicsBufferParam_ComputeShader_Int32_Int32_GraphicsBuffer == null)
				{
					r_MInternal_SetComputeGraphicsBufferParam_ComputeShader_Int32_Int32_GraphicsBuffer = new(this, "Internal_SetComputeGraphicsBufferParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer));
				}
				return r_MInternal_SetComputeGraphicsBufferParam_ComputeShader_Int32_Int32_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void Internal_SetComputeConstantComputeBufferParam(UnityEngine.ComputeShader, Int32, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_MInternal_SetComputeConstantComputeBufferParam_ComputeShader_Int32_ComputeBuffer_Int32_Int32;
		public virtual RMethod RMInternal_SetComputeConstantComputeBufferParam_ComputeShader_Int32_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_MInternal_SetComputeConstantComputeBufferParam_ComputeShader_Int32_ComputeBuffer_Int32_Int32 == null)
				{
					r_MInternal_SetComputeConstantComputeBufferParam_ComputeShader_Int32_ComputeBuffer_Int32_Int32 = new(this, "Internal_SetComputeConstantComputeBufferParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MInternal_SetComputeConstantComputeBufferParam_ComputeShader_Int32_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Internal_SetComputeConstantGraphicsBufferParam(UnityEngine.ComputeShader, Int32, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_MInternal_SetComputeConstantGraphicsBufferParam_ComputeShader_Int32_GraphicsBuffer_Int32_Int32;
		public virtual RMethod RMInternal_SetComputeConstantGraphicsBufferParam_ComputeShader_Int32_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_MInternal_SetComputeConstantGraphicsBufferParam_ComputeShader_Int32_GraphicsBuffer_Int32_Int32 == null)
				{
					r_MInternal_SetComputeConstantGraphicsBufferParam_ComputeShader_Int32_GraphicsBuffer_Int32_Int32 = new(this, "Internal_SetComputeConstantGraphicsBufferParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MInternal_SetComputeConstantGraphicsBufferParam_ComputeShader_Int32_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Internal_SetComputeParamsFromMaterial(UnityEngine.ComputeShader, Int32, UnityEngine.Material)
		/// </summary>
		protected RMethod r_MInternal_SetComputeParamsFromMaterial_ComputeShader_Int32_Material;
		public virtual RMethod RMInternal_SetComputeParamsFromMaterial_ComputeShader_Int32_Material
		{
			get
			{
				if(r_MInternal_SetComputeParamsFromMaterial_ComputeShader_Int32_Material == null)
				{
					r_MInternal_SetComputeParamsFromMaterial_ComputeShader_Int32_Material = new(this, "Internal_SetComputeParamsFromMaterial", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(UnityEngine.Material));
				}
				return r_MInternal_SetComputeParamsFromMaterial_ComputeShader_Int32_Material;
			}
		}

		/// <summary>
		/// Void Internal_DispatchCompute(UnityEngine.ComputeShader, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MInternal_DispatchCompute_ComputeShader_Int32_Int32_Int32_Int32;
		public virtual RMethod RMInternal_DispatchCompute_ComputeShader_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MInternal_DispatchCompute_ComputeShader_Int32_Int32_Int32_Int32 == null)
				{
					r_MInternal_DispatchCompute_ComputeShader_Int32_Int32_Int32_Int32 = new(this, "Internal_DispatchCompute", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MInternal_DispatchCompute_ComputeShader_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Internal_DispatchComputeIndirect(UnityEngine.ComputeShader, Int32, UnityEngine.ComputeBuffer, UInt32)
		/// </summary>
		protected RMethod r_MInternal_DispatchComputeIndirect_ComputeShader_Int32_ComputeBuffer_UInt32;
		public virtual RMethod RMInternal_DispatchComputeIndirect_ComputeShader_Int32_ComputeBuffer_UInt32
		{
			get
			{
				if(r_MInternal_DispatchComputeIndirect_ComputeShader_Int32_ComputeBuffer_UInt32 == null)
				{
					r_MInternal_DispatchComputeIndirect_ComputeShader_Int32_ComputeBuffer_UInt32 = new(this, "Internal_DispatchComputeIndirect", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.UInt32));
				}
				return r_MInternal_DispatchComputeIndirect_ComputeShader_Int32_ComputeBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void Internal_DispatchComputeIndirectGraphicsBuffer(UnityEngine.ComputeShader, Int32, UnityEngine.GraphicsBuffer, UInt32)
		/// </summary>
		protected RMethod r_MInternal_DispatchComputeIndirectGraphicsBuffer_ComputeShader_Int32_GraphicsBuffer_UInt32;
		public virtual RMethod RMInternal_DispatchComputeIndirectGraphicsBuffer_ComputeShader_Int32_GraphicsBuffer_UInt32
		{
			get
			{
				if(r_MInternal_DispatchComputeIndirectGraphicsBuffer_ComputeShader_Int32_GraphicsBuffer_UInt32 == null)
				{
					r_MInternal_DispatchComputeIndirectGraphicsBuffer_ComputeShader_Int32_GraphicsBuffer_UInt32 = new(this, "Internal_DispatchComputeIndirectGraphicsBuffer", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32));
				}
				return r_MInternal_DispatchComputeIndirectGraphicsBuffer_ComputeShader_Int32_GraphicsBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void Internal_SetRayTracingBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_MInternal_SetRayTracingBufferParam_RayTracingShader_Int32_ComputeBuffer;
		public virtual RMethod RMInternal_SetRayTracingBufferParam_RayTracingShader_Int32_ComputeBuffer
		{
			get
			{
				if(r_MInternal_SetRayTracingBufferParam_RayTracingShader_Int32_ComputeBuffer == null)
				{
					r_MInternal_SetRayTracingBufferParam_RayTracingShader_Int32_ComputeBuffer = new(this, "Internal_SetRayTracingBufferParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
				}
				return r_MInternal_SetRayTracingBufferParam_RayTracingShader_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void Internal_SetRayTracingConstantComputeBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_MInternal_SetRayTracingConstantComputeBufferParam_RayTracingShader_Int32_ComputeBuffer_Int32_Int32;
		public virtual RMethod RMInternal_SetRayTracingConstantComputeBufferParam_RayTracingShader_Int32_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_MInternal_SetRayTracingConstantComputeBufferParam_RayTracingShader_Int32_ComputeBuffer_Int32_Int32 == null)
				{
					r_MInternal_SetRayTracingConstantComputeBufferParam_RayTracingShader_Int32_ComputeBuffer_Int32_Int32 = new(this, "Internal_SetRayTracingConstantComputeBufferParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MInternal_SetRayTracingConstantComputeBufferParam_RayTracingShader_Int32_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Internal_SetRayTracingConstantGraphicsBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_MInternal_SetRayTracingConstantGraphicsBufferParam_RayTracingShader_Int32_GraphicsBuffer_Int32_Int32;
		public virtual RMethod RMInternal_SetRayTracingConstantGraphicsBufferParam_RayTracingShader_Int32_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_MInternal_SetRayTracingConstantGraphicsBufferParam_RayTracingShader_Int32_GraphicsBuffer_Int32_Int32 == null)
				{
					r_MInternal_SetRayTracingConstantGraphicsBufferParam_RayTracingShader_Int32_GraphicsBuffer_Int32_Int32 = new(this, "Internal_SetRayTracingConstantGraphicsBufferParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MInternal_SetRayTracingConstantGraphicsBufferParam_RayTracingShader_Int32_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Internal_SetRayTracingTextureParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.Rendering.RenderTargetIdentifier ByRef)
		/// </summary>
		protected RMethod r_MInternal_SetRayTracingTextureParam_RayTracingShader_Int32_Ref_RenderTargetIdentifier;
		public virtual RMethod RMInternal_SetRayTracingTextureParam_RayTracingShader_Int32_Ref_RenderTargetIdentifier
		{
			get
			{
				if(r_MInternal_SetRayTracingTextureParam_RayTracingShader_Int32_Ref_RenderTargetIdentifier == null)
				{
					r_MInternal_SetRayTracingTextureParam_RayTracingShader_Int32_Ref_RenderTargetIdentifier = new(this, "Internal_SetRayTracingTextureParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType());
				}
				return r_MInternal_SetRayTracingTextureParam_RayTracingShader_Int32_Ref_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void Internal_SetRayTracingFloatParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, Single)
		/// </summary>
		protected RMethod r_MInternal_SetRayTracingFloatParam_RayTracingShader_Int32_Single;
		public virtual RMethod RMInternal_SetRayTracingFloatParam_RayTracingShader_Int32_Single
		{
			get
			{
				if(r_MInternal_SetRayTracingFloatParam_RayTracingShader_Int32_Single == null)
				{
					r_MInternal_SetRayTracingFloatParam_RayTracingShader_Int32_Single = new(this, "Internal_SetRayTracingFloatParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(System.Single));
				}
				return r_MInternal_SetRayTracingFloatParam_RayTracingShader_Int32_Single;
			}
		}

		/// <summary>
		/// Void Internal_SetRayTracingIntParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, Int32)
		/// </summary>
		protected RMethod r_MInternal_SetRayTracingIntParam_RayTracingShader_Int32_Int32;
		public virtual RMethod RMInternal_SetRayTracingIntParam_RayTracingShader_Int32_Int32
		{
			get
			{
				if(r_MInternal_SetRayTracingIntParam_RayTracingShader_Int32_Int32 == null)
				{
					r_MInternal_SetRayTracingIntParam_RayTracingShader_Int32_Int32 = new(this, "Internal_SetRayTracingIntParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MInternal_SetRayTracingIntParam_RayTracingShader_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Internal_SetRayTracingVectorParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_MInternal_SetRayTracingVectorParam_RayTracingShader_Int32_Vector4;
		public virtual RMethod RMInternal_SetRayTracingVectorParam_RayTracingShader_Int32_Vector4
		{
			get
			{
				if(r_MInternal_SetRayTracingVectorParam_RayTracingShader_Int32_Vector4 == null)
				{
					r_MInternal_SetRayTracingVectorParam_RayTracingShader_Int32_Vector4 = new(this, "Internal_SetRayTracingVectorParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.Vector4));
				}
				return r_MInternal_SetRayTracingVectorParam_RayTracingShader_Int32_Vector4;
			}
		}

		/// <summary>
		/// Void Internal_SetRayTracingVectorArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_MInternal_SetRayTracingVectorArrayParam_RayTracingShader_Int32_Vector4Array;
		public virtual RMethod RMInternal_SetRayTracingVectorArrayParam_RayTracingShader_Int32_Vector4Array
		{
			get
			{
				if(r_MInternal_SetRayTracingVectorArrayParam_RayTracingShader_Int32_Vector4Array == null)
				{
					r_MInternal_SetRayTracingVectorArrayParam_RayTracingShader_Int32_Vector4Array = new(this, "Internal_SetRayTracingVectorArrayParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType());
				}
				return r_MInternal_SetRayTracingVectorArrayParam_RayTracingShader_Int32_Vector4Array;
			}
		}

		/// <summary>
		/// Void Internal_SetRayTracingMatrixParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_MInternal_SetRayTracingMatrixParam_RayTracingShader_Int32_Matrix4x4;
		public virtual RMethod RMInternal_SetRayTracingMatrixParam_RayTracingShader_Int32_Matrix4x4
		{
			get
			{
				if(r_MInternal_SetRayTracingMatrixParam_RayTracingShader_Int32_Matrix4x4 == null)
				{
					r_MInternal_SetRayTracingMatrixParam_RayTracingShader_Int32_Matrix4x4 = new(this, "Internal_SetRayTracingMatrixParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.Matrix4x4));
				}
				return r_MInternal_SetRayTracingMatrixParam_RayTracingShader_Int32_Matrix4x4;
			}
		}

		/// <summary>
		/// Void Internal_SetRayTracingMatrixArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_MInternal_SetRayTracingMatrixArrayParam_RayTracingShader_Int32_Matrix4x4Array;
		public virtual RMethod RMInternal_SetRayTracingMatrixArrayParam_RayTracingShader_Int32_Matrix4x4Array
		{
			get
			{
				if(r_MInternal_SetRayTracingMatrixArrayParam_RayTracingShader_Int32_Matrix4x4Array == null)
				{
					r_MInternal_SetRayTracingMatrixArrayParam_RayTracingShader_Int32_Matrix4x4Array = new(this, "Internal_SetRayTracingMatrixArrayParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType());
				}
				return r_MInternal_SetRayTracingMatrixArrayParam_RayTracingShader_Int32_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Void Internal_SetRayTracingFloats(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, Single[])
		/// </summary>
		protected RMethod r_MInternal_SetRayTracingFloats_RayTracingShader_Int32_SingleArray;
		public virtual RMethod RMInternal_SetRayTracingFloats_RayTracingShader_Int32_SingleArray
		{
			get
			{
				if(r_MInternal_SetRayTracingFloats_RayTracingShader_Int32_SingleArray == null)
				{
					r_MInternal_SetRayTracingFloats_RayTracingShader_Int32_SingleArray = new(this, "Internal_SetRayTracingFloats", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(System.Single).MakeArrayType());
				}
				return r_MInternal_SetRayTracingFloats_RayTracingShader_Int32_SingleArray;
			}
		}

		/// <summary>
		/// Void Internal_SetRayTracingInts(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, Int32[])
		/// </summary>
		protected RMethod r_MInternal_SetRayTracingInts_RayTracingShader_Int32_Int32Array;
		public virtual RMethod RMInternal_SetRayTracingInts_RayTracingShader_Int32_Int32Array
		{
			get
			{
				if(r_MInternal_SetRayTracingInts_RayTracingShader_Int32_Int32Array == null)
				{
					r_MInternal_SetRayTracingInts_RayTracingShader_Int32_Int32Array = new(this, "Internal_SetRayTracingInts", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(System.Int32).MakeArrayType());
				}
				return r_MInternal_SetRayTracingInts_RayTracingShader_Int32_Int32Array;
			}
		}

		/// <summary>
		/// Void Internal_BuildRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure, UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MInternal_BuildRayTracingAccelerationStructure_RayTracingAccelerationStructure_Vector3;
		public virtual RMethod RMInternal_BuildRayTracingAccelerationStructure_RayTracingAccelerationStructure_Vector3
		{
			get
			{
				if(r_MInternal_BuildRayTracingAccelerationStructure_RayTracingAccelerationStructure_Vector3 == null)
				{
					r_MInternal_BuildRayTracingAccelerationStructure_RayTracingAccelerationStructure_Vector3 = new(this, "Internal_BuildRayTracingAccelerationStructure", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure), typeof(UnityEngine.Vector3));
				}
				return r_MInternal_BuildRayTracingAccelerationStructure_RayTracingAccelerationStructure_Vector3;
			}
		}

		/// <summary>
		/// Void Internal_SetRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure)
		/// </summary>
		protected RMethod r_MInternal_SetRayTracingAccelerationStructure_RayTracingShader_Int32_RayTracingAccelerationStructure;
		public virtual RMethod RMInternal_SetRayTracingAccelerationStructure_RayTracingShader_Int32_RayTracingAccelerationStructure
		{
			get
			{
				if(r_MInternal_SetRayTracingAccelerationStructure_RayTracingShader_Int32_RayTracingAccelerationStructure == null)
				{
					r_MInternal_SetRayTracingAccelerationStructure_RayTracingShader_Int32_RayTracingAccelerationStructure = new(this, "Internal_SetRayTracingAccelerationStructure", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure));
				}
				return r_MInternal_SetRayTracingAccelerationStructure_RayTracingShader_Int32_RayTracingAccelerationStructure;
			}
		}

		/// <summary>
		/// Void SetRayTracingShaderPass(UnityEngine.Experimental.Rendering.RayTracingShader, System.String)
		/// </summary>
		protected RMethod r_MSetRayTracingShaderPass_RayTracingShader_String;
		public virtual RMethod RMSetRayTracingShaderPass_RayTracingShader_String
		{
			get
			{
				if(r_MSetRayTracingShaderPass_RayTracingShader_String == null)
				{
					r_MSetRayTracingShaderPass_RayTracingShader_String = new(this, "SetRayTracingShaderPass", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.String));
				}
				return r_MSetRayTracingShaderPass_RayTracingShader_String;
			}
		}

		/// <summary>
		/// Void Internal_DispatchRays(UnityEngine.Experimental.Rendering.RayTracingShader, System.String, UInt32, UInt32, UInt32, UnityEngine.Camera)
		/// </summary>
		protected RMethod r_MInternal_DispatchRays_RayTracingShader_String_UInt32_UInt32_UInt32_Camera;
		public virtual RMethod RMInternal_DispatchRays_RayTracingShader_String_UInt32_UInt32_UInt32_Camera
		{
			get
			{
				if(r_MInternal_DispatchRays_RayTracingShader_String_UInt32_UInt32_UInt32_Camera == null)
				{
					r_MInternal_DispatchRays_RayTracingShader_String_UInt32_UInt32_UInt32_Camera = new(this, "Internal_DispatchRays", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.String), typeof(System.UInt32), typeof(System.UInt32), typeof(System.UInt32), typeof(UnityEngine.Camera));
				}
				return r_MInternal_DispatchRays_RayTracingShader_String_UInt32_UInt32_UInt32_Camera;
			}
		}

		/// <summary>
		/// Void Internal_GenerateMips(UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_MInternal_GenerateMips_RenderTargetIdentifier;
		public virtual RMethod RMInternal_GenerateMips_RenderTargetIdentifier
		{
			get
			{
				if(r_MInternal_GenerateMips_RenderTargetIdentifier == null)
				{
					r_MInternal_GenerateMips_RenderTargetIdentifier = new(this, "Internal_GenerateMips", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier));
				}
				return r_MInternal_GenerateMips_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void Internal_ResolveAntiAliasedSurface(UnityEngine.RenderTexture, UnityEngine.RenderTexture)
		/// </summary>
		protected RMethod r_MInternal_ResolveAntiAliasedSurface_RenderTexture_RenderTexture;
		public virtual RMethod RMInternal_ResolveAntiAliasedSurface_RenderTexture_RenderTexture
		{
			get
			{
				if(r_MInternal_ResolveAntiAliasedSurface_RenderTexture_RenderTexture == null)
				{
					r_MInternal_ResolveAntiAliasedSurface_RenderTexture_RenderTexture = new(this, "Internal_ResolveAntiAliasedSurface", 0, typeof(UnityEngine.RenderTexture), typeof(UnityEngine.RenderTexture));
				}
				return r_MInternal_ResolveAntiAliasedSurface_RenderTexture_RenderTexture;
			}
		}

		/// <summary>
		/// Void CopyCounterValueCC(UnityEngine.ComputeBuffer, UnityEngine.ComputeBuffer, UInt32)
		/// </summary>
		protected RMethod r_MCopyCounterValueCC_ComputeBuffer_ComputeBuffer_UInt32;
		public virtual RMethod RMCopyCounterValueCC_ComputeBuffer_ComputeBuffer_UInt32
		{
			get
			{
				if(r_MCopyCounterValueCC_ComputeBuffer_ComputeBuffer_UInt32 == null)
				{
					r_MCopyCounterValueCC_ComputeBuffer_ComputeBuffer_UInt32 = new(this, "CopyCounterValueCC", 0, typeof(UnityEngine.ComputeBuffer), typeof(UnityEngine.ComputeBuffer), typeof(System.UInt32));
				}
				return r_MCopyCounterValueCC_ComputeBuffer_ComputeBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void CopyCounterValueGC(UnityEngine.GraphicsBuffer, UnityEngine.ComputeBuffer, UInt32)
		/// </summary>
		protected RMethod r_MCopyCounterValueGC_GraphicsBuffer_ComputeBuffer_UInt32;
		public virtual RMethod RMCopyCounterValueGC_GraphicsBuffer_ComputeBuffer_UInt32
		{
			get
			{
				if(r_MCopyCounterValueGC_GraphicsBuffer_ComputeBuffer_UInt32 == null)
				{
					r_MCopyCounterValueGC_GraphicsBuffer_ComputeBuffer_UInt32 = new(this, "CopyCounterValueGC", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.ComputeBuffer), typeof(System.UInt32));
				}
				return r_MCopyCounterValueGC_GraphicsBuffer_ComputeBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void CopyCounterValueCG(UnityEngine.ComputeBuffer, UnityEngine.GraphicsBuffer, UInt32)
		/// </summary>
		protected RMethod r_MCopyCounterValueCG_ComputeBuffer_GraphicsBuffer_UInt32;
		public virtual RMethod RMCopyCounterValueCG_ComputeBuffer_GraphicsBuffer_UInt32
		{
			get
			{
				if(r_MCopyCounterValueCG_ComputeBuffer_GraphicsBuffer_UInt32 == null)
				{
					r_MCopyCounterValueCG_ComputeBuffer_GraphicsBuffer_UInt32 = new(this, "CopyCounterValueCG", 0, typeof(UnityEngine.ComputeBuffer), typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32));
				}
				return r_MCopyCounterValueCG_ComputeBuffer_GraphicsBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void CopyCounterValueGG(UnityEngine.GraphicsBuffer, UnityEngine.GraphicsBuffer, UInt32)
		/// </summary>
		protected RMethod r_MCopyCounterValueGG_GraphicsBuffer_GraphicsBuffer_UInt32;
		public virtual RMethod RMCopyCounterValueGG_GraphicsBuffer_GraphicsBuffer_UInt32
		{
			get
			{
				if(r_MCopyCounterValueGG_GraphicsBuffer_GraphicsBuffer_UInt32 == null)
				{
					r_MCopyCounterValueGG_GraphicsBuffer_GraphicsBuffer_UInt32 = new(this, "CopyCounterValueGG", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32));
				}
				return r_MCopyCounterValueGG_GraphicsBuffer_GraphicsBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_MClear;
		public virtual RMethod RMClear
		{
			get
			{
				if(r_MClear == null)
				{
					r_MClear = new(this, "Clear", 0);
				}
				return r_MClear;
			}
		}

		/// <summary>
		/// Void Internal_DrawMesh(UnityEngine.Mesh, UnityEngine.Matrix4x4, UnityEngine.Material, Int32, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MInternal_DrawMesh_Mesh_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock;
		public virtual RMethod RMInternal_DrawMesh_Mesh_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_MInternal_DrawMesh_Mesh_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock == null)
				{
					r_MInternal_DrawMesh_Mesh_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock = new(this, "Internal_DrawMesh", 0, typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
				}
				return r_MInternal_DrawMesh_Mesh_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawRenderer(UnityEngine.Renderer, UnityEngine.Material, Int32, Int32)
		/// </summary>
		protected RMethod r_MInternal_DrawRenderer_Renderer_Material_Int32_Int32;
		public virtual RMethod RMInternal_DrawRenderer_Renderer_Material_Int32_Int32
		{
			get
			{
				if(r_MInternal_DrawRenderer_Renderer_Material_Int32_Int32 == null)
				{
					r_MInternal_DrawRenderer_Renderer_Material_Int32_Int32 = new(this, "Internal_DrawRenderer", 0, typeof(UnityEngine.Renderer), typeof(UnityEngine.Material), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MInternal_DrawRenderer_Renderer_Material_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Internal_DrawRendererList(UnityEngine.Rendering.RendererList)
		/// </summary>
		protected RMethod r_MInternal_DrawRendererList_RendererList;
		public virtual RMethod RMInternal_DrawRendererList_RendererList
		{
			get
			{
				if(r_MInternal_DrawRendererList_RendererList == null)
				{
					r_MInternal_DrawRendererList_RendererList = new(this, "Internal_DrawRendererList", 0, typeof(UnityEngine.Rendering.RendererList));
				}
				return r_MInternal_DrawRendererList_RendererList;
			}
		}

		/// <summary>
		/// Void Internal_DrawRenderer(UnityEngine.Renderer, UnityEngine.Material, Int32)
		/// </summary>
		protected RMethod r_MInternal_DrawRenderer_Renderer_Material_Int32;
		public virtual RMethod RMInternal_DrawRenderer_Renderer_Material_Int32
		{
			get
			{
				if(r_MInternal_DrawRenderer_Renderer_Material_Int32 == null)
				{
					r_MInternal_DrawRenderer_Renderer_Material_Int32 = new(this, "Internal_DrawRenderer", 0, typeof(UnityEngine.Renderer), typeof(UnityEngine.Material), typeof(System.Int32));
				}
				return r_MInternal_DrawRenderer_Renderer_Material_Int32;
			}
		}

		/// <summary>
		/// Void Internal_DrawRenderer(UnityEngine.Renderer, UnityEngine.Material)
		/// </summary>
		protected RMethod r_MInternal_DrawRenderer_Renderer_Material;
		public virtual RMethod RMInternal_DrawRenderer_Renderer_Material
		{
			get
			{
				if(r_MInternal_DrawRenderer_Renderer_Material == null)
				{
					r_MInternal_DrawRenderer_Renderer_Material = new(this, "Internal_DrawRenderer", 0, typeof(UnityEngine.Renderer), typeof(UnityEngine.Material));
				}
				return r_MInternal_DrawRenderer_Renderer_Material;
			}
		}

		/// <summary>
		/// Void Internal_DrawProcedural(UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, Int32, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MInternal_DrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock;
		public virtual RMethod RMInternal_DrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_MInternal_DrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock == null)
				{
					r_MInternal_DrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock = new(this, "Internal_DrawProcedural", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
				}
				return r_MInternal_DrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawProceduralIndexed(UnityEngine.GraphicsBuffer, UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, Int32, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MInternal_DrawProceduralIndexed_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock;
		public virtual RMethod RMInternal_DrawProceduralIndexed_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_MInternal_DrawProceduralIndexed_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock == null)
				{
					r_MInternal_DrawProceduralIndexed_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock = new(this, "Internal_DrawProceduralIndexed", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
				}
				return r_MInternal_DrawProceduralIndexed_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawProceduralIndirect(UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.ComputeBuffer, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MInternal_DrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock;
		public virtual RMethod RMInternal_DrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_MInternal_DrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock == null)
				{
					r_MInternal_DrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock = new(this, "Internal_DrawProceduralIndirect", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
				}
				return r_MInternal_DrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawProceduralIndexedIndirect(UnityEngine.GraphicsBuffer, UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.ComputeBuffer, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MInternal_DrawProceduralIndexedIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock;
		public virtual RMethod RMInternal_DrawProceduralIndexedIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_MInternal_DrawProceduralIndexedIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock == null)
				{
					r_MInternal_DrawProceduralIndexedIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock = new(this, "Internal_DrawProceduralIndexedIndirect", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
				}
				return r_MInternal_DrawProceduralIndexedIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawProceduralIndirectGraphicsBuffer(UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.GraphicsBuffer, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MInternal_DrawProceduralIndirectGraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock;
		public virtual RMethod RMInternal_DrawProceduralIndirectGraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_MInternal_DrawProceduralIndirectGraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock == null)
				{
					r_MInternal_DrawProceduralIndirectGraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock = new(this, "Internal_DrawProceduralIndirectGraphicsBuffer", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
				}
				return r_MInternal_DrawProceduralIndirectGraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawProceduralIndexedIndirectGraphicsBuffer(UnityEngine.GraphicsBuffer, UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.GraphicsBuffer, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MInternal_DrawProceduralIndexedIndirectGraphicsBuffer_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock;
		public virtual RMethod RMInternal_DrawProceduralIndexedIndirectGraphicsBuffer_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_MInternal_DrawProceduralIndexedIndirectGraphicsBuffer_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock == null)
				{
					r_MInternal_DrawProceduralIndexedIndirectGraphicsBuffer_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock = new(this, "Internal_DrawProceduralIndexedIndirectGraphicsBuffer", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
				}
				return r_MInternal_DrawProceduralIndexedIndirectGraphicsBuffer_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawMeshInstanced(UnityEngine.Mesh, Int32, UnityEngine.Material, Int32, UnityEngine.Matrix4x4[], Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MInternal_DrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32_MaterialPropertyBlock;
		public virtual RMethod RMInternal_DrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_MInternal_DrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32_MaterialPropertyBlock == null)
				{
					r_MInternal_DrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32_MaterialPropertyBlock = new(this, "Internal_DrawMeshInstanced", 0, typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType(), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
				}
				return r_MInternal_DrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawMeshInstancedProcedural(UnityEngine.Mesh, Int32, UnityEngine.Material, Int32, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MInternal_DrawMeshInstancedProcedural_Mesh_Int32_Material_Int32_Int32_MaterialPropertyBlock;
		public virtual RMethod RMInternal_DrawMeshInstancedProcedural_Mesh_Int32_Material_Int32_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_MInternal_DrawMeshInstancedProcedural_Mesh_Int32_Material_Int32_Int32_MaterialPropertyBlock == null)
				{
					r_MInternal_DrawMeshInstancedProcedural_Mesh_Int32_Material_Int32_Int32_MaterialPropertyBlock = new(this, "Internal_DrawMeshInstancedProcedural", 0, typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
				}
				return r_MInternal_DrawMeshInstancedProcedural_Mesh_Int32_Material_Int32_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawMeshInstancedIndirect(UnityEngine.Mesh, Int32, UnityEngine.Material, Int32, UnityEngine.ComputeBuffer, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MInternal_DrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32_MaterialPropertyBlock;
		public virtual RMethod RMInternal_DrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_MInternal_DrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32_MaterialPropertyBlock == null)
				{
					r_MInternal_DrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32_MaterialPropertyBlock = new(this, "Internal_DrawMeshInstancedIndirect", 0, typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
				}
				return r_MInternal_DrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawMeshInstancedIndirectGraphicsBuffer(UnityEngine.Mesh, Int32, UnityEngine.Material, Int32, UnityEngine.GraphicsBuffer, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MInternal_DrawMeshInstancedIndirectGraphicsBuffer_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32_MaterialPropertyBlock;
		public virtual RMethod RMInternal_DrawMeshInstancedIndirectGraphicsBuffer_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_MInternal_DrawMeshInstancedIndirectGraphicsBuffer_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32_MaterialPropertyBlock == null)
				{
					r_MInternal_DrawMeshInstancedIndirectGraphicsBuffer_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32_MaterialPropertyBlock = new(this, "Internal_DrawMeshInstancedIndirectGraphicsBuffer", 0, typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
				}
				return r_MInternal_DrawMeshInstancedIndirectGraphicsBuffer_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawOcclusionMesh(UnityEngine.RectInt)
		/// </summary>
		protected RMethod r_MInternal_DrawOcclusionMesh_RectInt;
		public virtual RMethod RMInternal_DrawOcclusionMesh_RectInt
		{
			get
			{
				if(r_MInternal_DrawOcclusionMesh_RectInt == null)
				{
					r_MInternal_DrawOcclusionMesh_RectInt = new(this, "Internal_DrawOcclusionMesh", 0, typeof(UnityEngine.RectInt));
				}
				return r_MInternal_DrawOcclusionMesh_RectInt;
			}
		}

		/// <summary>
		/// Void SetRandomWriteTarget_Texture(Int32, UnityEngine.Rendering.RenderTargetIdentifier ByRef)
		/// </summary>
		protected RMethod r_MSetRandomWriteTarget_Texture_Int32_Ref_RenderTargetIdentifier;
		public virtual RMethod RMSetRandomWriteTarget_Texture_Int32_Ref_RenderTargetIdentifier
		{
			get
			{
				if(r_MSetRandomWriteTarget_Texture_Int32_Ref_RenderTargetIdentifier == null)
				{
					r_MSetRandomWriteTarget_Texture_Int32_Ref_RenderTargetIdentifier = new(this, "SetRandomWriteTarget_Texture", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType());
				}
				return r_MSetRandomWriteTarget_Texture_Int32_Ref_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void SetRandomWriteTarget_Buffer(Int32, UnityEngine.ComputeBuffer, Boolean)
		/// </summary>
		protected RMethod r_MSetRandomWriteTarget_Buffer_Int32_ComputeBuffer_Boolean;
		public virtual RMethod RMSetRandomWriteTarget_Buffer_Int32_ComputeBuffer_Boolean
		{
			get
			{
				if(r_MSetRandomWriteTarget_Buffer_Int32_ComputeBuffer_Boolean == null)
				{
					r_MSetRandomWriteTarget_Buffer_Int32_ComputeBuffer_Boolean = new(this, "SetRandomWriteTarget_Buffer", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Boolean));
				}
				return r_MSetRandomWriteTarget_Buffer_Int32_ComputeBuffer_Boolean;
			}
		}

		/// <summary>
		/// Void SetRandomWriteTarget_GraphicsBuffer(Int32, UnityEngine.GraphicsBuffer, Boolean)
		/// </summary>
		protected RMethod r_MSetRandomWriteTarget_GraphicsBuffer_Int32_GraphicsBuffer_Boolean;
		public virtual RMethod RMSetRandomWriteTarget_GraphicsBuffer_Int32_GraphicsBuffer_Boolean
		{
			get
			{
				if(r_MSetRandomWriteTarget_GraphicsBuffer_Int32_GraphicsBuffer_Boolean == null)
				{
					r_MSetRandomWriteTarget_GraphicsBuffer_Int32_GraphicsBuffer_Boolean = new(this, "SetRandomWriteTarget_GraphicsBuffer", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Boolean));
				}
				return r_MSetRandomWriteTarget_GraphicsBuffer_Int32_GraphicsBuffer_Boolean;
			}
		}

		/// <summary>
		/// Void ClearRandomWriteTargets()
		/// </summary>
		protected RMethod r_MClearRandomWriteTargets;
		public virtual RMethod RMClearRandomWriteTargets
		{
			get
			{
				if(r_MClearRandomWriteTargets == null)
				{
					r_MClearRandomWriteTargets = new(this, "ClearRandomWriteTargets", 0);
				}
				return r_MClearRandomWriteTargets;
			}
		}

		/// <summary>
		/// Void SetViewport(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MSetViewport_Rect;
		public virtual RMethod RMSetViewport_Rect
		{
			get
			{
				if(r_MSetViewport_Rect == null)
				{
					r_MSetViewport_Rect = new(this, "SetViewport", 0, typeof(UnityEngine.Rect));
				}
				return r_MSetViewport_Rect;
			}
		}

		/// <summary>
		/// Void EnableScissorRect(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MEnableScissorRect_Rect;
		public virtual RMethod RMEnableScissorRect_Rect
		{
			get
			{
				if(r_MEnableScissorRect_Rect == null)
				{
					r_MEnableScissorRect_Rect = new(this, "EnableScissorRect", 0, typeof(UnityEngine.Rect));
				}
				return r_MEnableScissorRect_Rect;
			}
		}

		/// <summary>
		/// Void DisableScissorRect()
		/// </summary>
		protected RMethod r_MDisableScissorRect;
		public virtual RMethod RMDisableScissorRect
		{
			get
			{
				if(r_MDisableScissorRect == null)
				{
					r_MDisableScissorRect = new(this, "DisableScissorRect", 0);
				}
				return r_MDisableScissorRect;
			}
		}

		/// <summary>
		/// Void CopyTexture_Internal(UnityEngine.Rendering.RenderTargetIdentifier ByRef, Int32, Int32, Int32, Int32, Int32, Int32, UnityEngine.Rendering.RenderTargetIdentifier ByRef, Int32, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MCopyTexture_Internal_Ref_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32_Int32_Ref_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32;
		public virtual RMethod RMCopyTexture_Internal_Ref_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32_Int32_Ref_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MCopyTexture_Internal_Ref_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32_Int32_Ref_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32 == null)
				{
					r_MCopyTexture_Internal_Ref_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32_Int32_Ref_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32 = new(this, "CopyTexture_Internal", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MCopyTexture_Internal_Ref_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32_Int32_Ref_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Blit_Texture(UnityEngine.Texture, UnityEngine.Rendering.RenderTargetIdentifier ByRef, UnityEngine.Material, Int32, UnityEngine.Vector2, UnityEngine.Vector2, Int32, Int32)
		/// </summary>
		protected RMethod r_MBlit_Texture_Texture_Ref_RenderTargetIdentifier_Material_Int32_Vector2_Vector2_Int32_Int32;
		public virtual RMethod RMBlit_Texture_Texture_Ref_RenderTargetIdentifier_Material_Int32_Vector2_Vector2_Int32_Int32
		{
			get
			{
				if(r_MBlit_Texture_Texture_Ref_RenderTargetIdentifier_Material_Int32_Vector2_Vector2_Int32_Int32 == null)
				{
					r_MBlit_Texture_Texture_Ref_RenderTargetIdentifier_Material_Int32_Vector2_Vector2_Int32_Int32 = new(this, "Blit_Texture", 0, typeof(UnityEngine.Texture), typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MBlit_Texture_Texture_Ref_RenderTargetIdentifier_Material_Int32_Vector2_Vector2_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Blit_Identifier(UnityEngine.Rendering.RenderTargetIdentifier ByRef, UnityEngine.Rendering.RenderTargetIdentifier ByRef, UnityEngine.Material, Int32, UnityEngine.Vector2, UnityEngine.Vector2, Int32, Int32)
		/// </summary>
		protected RMethod r_MBlit_Identifier_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_Material_Int32_Vector2_Vector2_Int32_Int32;
		public virtual RMethod RMBlit_Identifier_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_Material_Int32_Vector2_Vector2_Int32_Int32
		{
			get
			{
				if(r_MBlit_Identifier_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_Material_Int32_Vector2_Vector2_Int32_Int32 == null)
				{
					r_MBlit_Identifier_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_Material_Int32_Vector2_Vector2_Int32_Int32 = new(this, "Blit_Identifier", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MBlit_Identifier_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_Material_Int32_Vector2_Vector2_Int32_Int32;
			}
		}

		/// <summary>
		/// Void GetTemporaryRT(Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.Experimental.Rendering.GraphicsFormat, Int32, Boolean, UnityEngine.RenderTextureMemoryless, Boolean)
		/// </summary>
		protected RMethod r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_RenderTextureMemoryless_Boolean;
		public virtual RMethod RMGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_RenderTextureMemoryless_Boolean
		{
			get
			{
				if(r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_RenderTextureMemoryless_Boolean == null)
				{
					r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_RenderTextureMemoryless_Boolean = new(this, "GetTemporaryRT", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Int32), typeof(System.Boolean), typeof(UnityEngine.RenderTextureMemoryless), typeof(System.Boolean));
				}
				return r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_RenderTextureMemoryless_Boolean;
			}
		}

		/// <summary>
		/// Void GetTemporaryRT(Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.Experimental.Rendering.GraphicsFormat, Int32, Boolean, UnityEngine.RenderTextureMemoryless)
		/// </summary>
		protected RMethod r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_RenderTextureMemoryless;
		public virtual RMethod RMGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_RenderTextureMemoryless
		{
			get
			{
				if(r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_RenderTextureMemoryless == null)
				{
					r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_RenderTextureMemoryless = new(this, "GetTemporaryRT", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Int32), typeof(System.Boolean), typeof(UnityEngine.RenderTextureMemoryless));
				}
				return r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_RenderTextureMemoryless;
			}
		}

		/// <summary>
		/// Void GetTemporaryRT(Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.Experimental.Rendering.GraphicsFormat, Int32, Boolean)
		/// </summary>
		protected RMethod r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean;
		public virtual RMethod RMGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean
		{
			get
			{
				if(r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean == null)
				{
					r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean = new(this, "GetTemporaryRT", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetTemporaryRT(Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.Experimental.Rendering.GraphicsFormat, Int32)
		/// </summary>
		protected RMethod r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32;
		public virtual RMethod RMGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32
		{
			get
			{
				if(r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32 == null)
				{
					r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32 = new(this, "GetTemporaryRT", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Int32));
				}
				return r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32;
			}
		}

		/// <summary>
		/// Void GetTemporaryRT(Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.Experimental.Rendering.GraphicsFormat)
		/// </summary>
		protected RMethod r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat;
		public virtual RMethod RMGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat
		{
			get
			{
				if(r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat == null)
				{
					r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat = new(this, "GetTemporaryRT", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat));
				}
				return r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat;
			}
		}

		/// <summary>
		/// Void GetTemporaryRT(Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite, Int32, Boolean, UnityEngine.RenderTextureMemoryless, Boolean)
		/// </summary>
		protected RMethod r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_RenderTextureMemoryless_Boolean;
		public virtual RMethod RMGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_RenderTextureMemoryless_Boolean
		{
			get
			{
				if(r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_RenderTextureMemoryless_Boolean == null)
				{
					r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_RenderTextureMemoryless_Boolean = new(this, "GetTemporaryRT", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.RenderTextureFormat), typeof(UnityEngine.RenderTextureReadWrite), typeof(System.Int32), typeof(System.Boolean), typeof(UnityEngine.RenderTextureMemoryless), typeof(System.Boolean));
				}
				return r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_RenderTextureMemoryless_Boolean;
			}
		}

		/// <summary>
		/// Void GetTemporaryRT(Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite, Int32, Boolean, UnityEngine.RenderTextureMemoryless)
		/// </summary>
		protected RMethod r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_RenderTextureMemoryless;
		public virtual RMethod RMGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_RenderTextureMemoryless
		{
			get
			{
				if(r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_RenderTextureMemoryless == null)
				{
					r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_RenderTextureMemoryless = new(this, "GetTemporaryRT", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.RenderTextureFormat), typeof(UnityEngine.RenderTextureReadWrite), typeof(System.Int32), typeof(System.Boolean), typeof(UnityEngine.RenderTextureMemoryless));
				}
				return r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_RenderTextureMemoryless;
			}
		}

		/// <summary>
		/// Void GetTemporaryRT(Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite, Int32, Boolean)
		/// </summary>
		protected RMethod r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean;
		public virtual RMethod RMGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean
		{
			get
			{
				if(r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean == null)
				{
					r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean = new(this, "GetTemporaryRT", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.RenderTextureFormat), typeof(UnityEngine.RenderTextureReadWrite), typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetTemporaryRT(Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite, Int32)
		/// </summary>
		protected RMethod r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32;
		public virtual RMethod RMGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32
		{
			get
			{
				if(r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32 == null)
				{
					r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32 = new(this, "GetTemporaryRT", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.RenderTextureFormat), typeof(UnityEngine.RenderTextureReadWrite), typeof(System.Int32));
				}
				return r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32;
			}
		}

		/// <summary>
		/// Void GetTemporaryRT(Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite)
		/// </summary>
		protected RMethod r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite;
		public virtual RMethod RMGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite
		{
			get
			{
				if(r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite == null)
				{
					r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite = new(this, "GetTemporaryRT", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.RenderTextureFormat), typeof(UnityEngine.RenderTextureReadWrite));
				}
				return r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite;
			}
		}

		/// <summary>
		/// Void GetTemporaryRT(Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.RenderTextureFormat)
		/// </summary>
		protected RMethod r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat;
		public virtual RMethod RMGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat
		{
			get
			{
				if(r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat == null)
				{
					r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat = new(this, "GetTemporaryRT", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.RenderTextureFormat));
				}
				return r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat;
			}
		}

		/// <summary>
		/// Void GetTemporaryRT(Int32, Int32, Int32, Int32, UnityEngine.FilterMode)
		/// </summary>
		protected RMethod r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode;
		public virtual RMethod RMGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode
		{
			get
			{
				if(r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode == null)
				{
					r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode = new(this, "GetTemporaryRT", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode));
				}
				return r_MGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode;
			}
		}

		/// <summary>
		/// Void GetTemporaryRT(Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MGetTemporaryRT_Int32_Int32_Int32_Int32;
		public virtual RMethod RMGetTemporaryRT_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MGetTemporaryRT_Int32_Int32_Int32_Int32 == null)
				{
					r_MGetTemporaryRT_Int32_Int32_Int32_Int32 = new(this, "GetTemporaryRT", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MGetTemporaryRT_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void GetTemporaryRT(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MGetTemporaryRT_Int32_Int32_Int32;
		public virtual RMethod RMGetTemporaryRT_Int32_Int32_Int32
		{
			get
			{
				if(r_MGetTemporaryRT_Int32_Int32_Int32 == null)
				{
					r_MGetTemporaryRT_Int32_Int32_Int32 = new(this, "GetTemporaryRT", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MGetTemporaryRT_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void GetTemporaryRTWithDescriptor(Int32, UnityEngine.RenderTextureDescriptor, UnityEngine.FilterMode)
		/// </summary>
		protected RMethod r_MGetTemporaryRTWithDescriptor_Int32_RenderTextureDescriptor_FilterMode;
		public virtual RMethod RMGetTemporaryRTWithDescriptor_Int32_RenderTextureDescriptor_FilterMode
		{
			get
			{
				if(r_MGetTemporaryRTWithDescriptor_Int32_RenderTextureDescriptor_FilterMode == null)
				{
					r_MGetTemporaryRTWithDescriptor_Int32_RenderTextureDescriptor_FilterMode = new(this, "GetTemporaryRTWithDescriptor", 0, typeof(System.Int32), typeof(UnityEngine.RenderTextureDescriptor), typeof(UnityEngine.FilterMode));
				}
				return r_MGetTemporaryRTWithDescriptor_Int32_RenderTextureDescriptor_FilterMode;
			}
		}

		/// <summary>
		/// Void GetTemporaryRT(Int32, UnityEngine.RenderTextureDescriptor, UnityEngine.FilterMode)
		/// </summary>
		protected RMethod r_MGetTemporaryRT_Int32_RenderTextureDescriptor_FilterMode;
		public virtual RMethod RMGetTemporaryRT_Int32_RenderTextureDescriptor_FilterMode
		{
			get
			{
				if(r_MGetTemporaryRT_Int32_RenderTextureDescriptor_FilterMode == null)
				{
					r_MGetTemporaryRT_Int32_RenderTextureDescriptor_FilterMode = new(this, "GetTemporaryRT", 0, typeof(System.Int32), typeof(UnityEngine.RenderTextureDescriptor), typeof(UnityEngine.FilterMode));
				}
				return r_MGetTemporaryRT_Int32_RenderTextureDescriptor_FilterMode;
			}
		}

		/// <summary>
		/// Void GetTemporaryRT(Int32, UnityEngine.RenderTextureDescriptor)
		/// </summary>
		protected RMethod r_MGetTemporaryRT_Int32_RenderTextureDescriptor;
		public virtual RMethod RMGetTemporaryRT_Int32_RenderTextureDescriptor
		{
			get
			{
				if(r_MGetTemporaryRT_Int32_RenderTextureDescriptor == null)
				{
					r_MGetTemporaryRT_Int32_RenderTextureDescriptor = new(this, "GetTemporaryRT", 0, typeof(System.Int32), typeof(UnityEngine.RenderTextureDescriptor));
				}
				return r_MGetTemporaryRT_Int32_RenderTextureDescriptor;
			}
		}

		/// <summary>
		/// Void GetTemporaryRTArray(Int32, Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.Experimental.Rendering.GraphicsFormat, Int32, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_Boolean;
		public virtual RMethod RMGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_Boolean
		{
			get
			{
				if(r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_Boolean == null)
				{
					r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_Boolean = new(this, "GetTemporaryRTArray", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Int32), typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void GetTemporaryRTArray(Int32, Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.Experimental.Rendering.GraphicsFormat, Int32, Boolean)
		/// </summary>
		protected RMethod r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean;
		public virtual RMethod RMGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean
		{
			get
			{
				if(r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean == null)
				{
					r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean = new(this, "GetTemporaryRTArray", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetTemporaryRTArray(Int32, Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.Experimental.Rendering.GraphicsFormat, Int32)
		/// </summary>
		protected RMethod r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32;
		public virtual RMethod RMGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32
		{
			get
			{
				if(r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32 == null)
				{
					r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32 = new(this, "GetTemporaryRTArray", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Int32));
				}
				return r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32;
			}
		}

		/// <summary>
		/// Void GetTemporaryRTArray(Int32, Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.Experimental.Rendering.GraphicsFormat)
		/// </summary>
		protected RMethod r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat;
		public virtual RMethod RMGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat
		{
			get
			{
				if(r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat == null)
				{
					r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat = new(this, "GetTemporaryRTArray", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat));
				}
				return r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat;
			}
		}

		/// <summary>
		/// Void GetTemporaryRTArray(Int32, Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite, Int32, Boolean)
		/// </summary>
		protected RMethod r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean;
		public virtual RMethod RMGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean
		{
			get
			{
				if(r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean == null)
				{
					r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean = new(this, "GetTemporaryRTArray", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.RenderTextureFormat), typeof(UnityEngine.RenderTextureReadWrite), typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetTemporaryRTArray(Int32, Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite, Int32)
		/// </summary>
		protected RMethod r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32;
		public virtual RMethod RMGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32
		{
			get
			{
				if(r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32 == null)
				{
					r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32 = new(this, "GetTemporaryRTArray", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.RenderTextureFormat), typeof(UnityEngine.RenderTextureReadWrite), typeof(System.Int32));
				}
				return r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32;
			}
		}

		/// <summary>
		/// Void GetTemporaryRTArray(Int32, Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite)
		/// </summary>
		protected RMethod r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite;
		public virtual RMethod RMGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite
		{
			get
			{
				if(r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite == null)
				{
					r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite = new(this, "GetTemporaryRTArray", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.RenderTextureFormat), typeof(UnityEngine.RenderTextureReadWrite));
				}
				return r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite;
			}
		}

		/// <summary>
		/// Void GetTemporaryRTArray(Int32, Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.RenderTextureFormat)
		/// </summary>
		protected RMethod r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat;
		public virtual RMethod RMGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat
		{
			get
			{
				if(r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat == null)
				{
					r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat = new(this, "GetTemporaryRTArray", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.RenderTextureFormat));
				}
				return r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat;
			}
		}

		/// <summary>
		/// Void GetTemporaryRTArray(Int32, Int32, Int32, Int32, Int32, UnityEngine.FilterMode)
		/// </summary>
		protected RMethod r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode;
		public virtual RMethod RMGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode
		{
			get
			{
				if(r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode == null)
				{
					r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode = new(this, "GetTemporaryRTArray", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode));
				}
				return r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode;
			}
		}

		/// <summary>
		/// Void GetTemporaryRTArray(Int32, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32;
		public virtual RMethod RMGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32 == null)
				{
					r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32 = new(this, "GetTemporaryRTArray", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void GetTemporaryRTArray(Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32;
		public virtual RMethod RMGetTemporaryRTArray_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32 == null)
				{
					r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32 = new(this, "GetTemporaryRTArray", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MGetTemporaryRTArray_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void ReleaseTemporaryRT(Int32)
		/// </summary>
		protected RMethod r_MReleaseTemporaryRT_Int32;
		public virtual RMethod RMReleaseTemporaryRT_Int32
		{
			get
			{
				if(r_MReleaseTemporaryRT_Int32 == null)
				{
					r_MReleaseTemporaryRT_Int32 = new(this, "ReleaseTemporaryRT", 0, typeof(System.Int32));
				}
				return r_MReleaseTemporaryRT_Int32;
			}
		}

		/// <summary>
		/// Void ClearRenderTarget(UnityEngine.Rendering.RTClearFlags, UnityEngine.Color, Single, UInt32)
		/// </summary>
		protected RMethod r_MClearRenderTarget_RTClearFlags_Color_Single_UInt32;
		public virtual RMethod RMClearRenderTarget_RTClearFlags_Color_Single_UInt32
		{
			get
			{
				if(r_MClearRenderTarget_RTClearFlags_Color_Single_UInt32 == null)
				{
					r_MClearRenderTarget_RTClearFlags_Color_Single_UInt32 = new(this, "ClearRenderTarget", 0, typeof(UnityEngine.Rendering.RTClearFlags), typeof(UnityEngine.Color), typeof(System.Single), typeof(System.UInt32));
				}
				return r_MClearRenderTarget_RTClearFlags_Color_Single_UInt32;
			}
		}

		/// <summary>
		/// Void ClearRenderTarget(Boolean, Boolean, UnityEngine.Color)
		/// </summary>
		protected RMethod r_MClearRenderTarget_Boolean_Boolean_Color;
		public virtual RMethod RMClearRenderTarget_Boolean_Boolean_Color
		{
			get
			{
				if(r_MClearRenderTarget_Boolean_Boolean_Color == null)
				{
					r_MClearRenderTarget_Boolean_Boolean_Color = new(this, "ClearRenderTarget", 0, typeof(System.Boolean), typeof(System.Boolean), typeof(UnityEngine.Color));
				}
				return r_MClearRenderTarget_Boolean_Boolean_Color;
			}
		}

		/// <summary>
		/// Void ClearRenderTarget(Boolean, Boolean, UnityEngine.Color, Single)
		/// </summary>
		protected RMethod r_MClearRenderTarget_Boolean_Boolean_Color_Single;
		public virtual RMethod RMClearRenderTarget_Boolean_Boolean_Color_Single
		{
			get
			{
				if(r_MClearRenderTarget_Boolean_Boolean_Color_Single == null)
				{
					r_MClearRenderTarget_Boolean_Boolean_Color_Single = new(this, "ClearRenderTarget", 0, typeof(System.Boolean), typeof(System.Boolean), typeof(UnityEngine.Color), typeof(System.Single));
				}
				return r_MClearRenderTarget_Boolean_Boolean_Color_Single;
			}
		}

		/// <summary>
		/// Void SetGlobalFloat(Int32, Single)
		/// </summary>
		protected RMethod r_MSetGlobalFloat_Int32_Single;
		public virtual RMethod RMSetGlobalFloat_Int32_Single
		{
			get
			{
				if(r_MSetGlobalFloat_Int32_Single == null)
				{
					r_MSetGlobalFloat_Int32_Single = new(this, "SetGlobalFloat", 0, typeof(System.Int32), typeof(System.Single));
				}
				return r_MSetGlobalFloat_Int32_Single;
			}
		}

		/// <summary>
		/// Void SetGlobalInt(Int32, Int32)
		/// </summary>
		protected RMethod r_MSetGlobalInt_Int32_Int32;
		public virtual RMethod RMSetGlobalInt_Int32_Int32
		{
			get
			{
				if(r_MSetGlobalInt_Int32_Int32 == null)
				{
					r_MSetGlobalInt_Int32_Int32 = new(this, "SetGlobalInt", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetGlobalInt_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalInteger(Int32, Int32)
		/// </summary>
		protected RMethod r_MSetGlobalInteger_Int32_Int32;
		public virtual RMethod RMSetGlobalInteger_Int32_Int32
		{
			get
			{
				if(r_MSetGlobalInteger_Int32_Int32 == null)
				{
					r_MSetGlobalInteger_Int32_Int32 = new(this, "SetGlobalInteger", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetGlobalInteger_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalVector(Int32, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_MSetGlobalVector_Int32_Vector4;
		public virtual RMethod RMSetGlobalVector_Int32_Vector4
		{
			get
			{
				if(r_MSetGlobalVector_Int32_Vector4 == null)
				{
					r_MSetGlobalVector_Int32_Vector4 = new(this, "SetGlobalVector", 0, typeof(System.Int32), typeof(UnityEngine.Vector4));
				}
				return r_MSetGlobalVector_Int32_Vector4;
			}
		}

		/// <summary>
		/// Void SetGlobalColor(Int32, UnityEngine.Color)
		/// </summary>
		protected RMethod r_MSetGlobalColor_Int32_Color;
		public virtual RMethod RMSetGlobalColor_Int32_Color
		{
			get
			{
				if(r_MSetGlobalColor_Int32_Color == null)
				{
					r_MSetGlobalColor_Int32_Color = new(this, "SetGlobalColor", 0, typeof(System.Int32), typeof(UnityEngine.Color));
				}
				return r_MSetGlobalColor_Int32_Color;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrix(Int32, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_MSetGlobalMatrix_Int32_Matrix4x4;
		public virtual RMethod RMSetGlobalMatrix_Int32_Matrix4x4
		{
			get
			{
				if(r_MSetGlobalMatrix_Int32_Matrix4x4 == null)
				{
					r_MSetGlobalMatrix_Int32_Matrix4x4 = new(this, "SetGlobalMatrix", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4));
				}
				return r_MSetGlobalMatrix_Int32_Matrix4x4;
			}
		}

		/// <summary>
		/// Void EnableShaderKeyword(System.String)
		/// </summary>
		protected RMethod r_MEnableShaderKeyword_String;
		public virtual RMethod RMEnableShaderKeyword_String
		{
			get
			{
				if(r_MEnableShaderKeyword_String == null)
				{
					r_MEnableShaderKeyword_String = new(this, "EnableShaderKeyword", 0, typeof(System.String));
				}
				return r_MEnableShaderKeyword_String;
			}
		}

		/// <summary>
		/// Void EnableGlobalKeyword(UnityEngine.Rendering.GlobalKeyword)
		/// </summary>
		protected RMethod r_MEnableGlobalKeyword_GlobalKeyword;
		public virtual RMethod RMEnableGlobalKeyword_GlobalKeyword
		{
			get
			{
				if(r_MEnableGlobalKeyword_GlobalKeyword == null)
				{
					r_MEnableGlobalKeyword_GlobalKeyword = new(this, "EnableGlobalKeyword", 0, typeof(UnityEngine.Rendering.GlobalKeyword));
				}
				return r_MEnableGlobalKeyword_GlobalKeyword;
			}
		}

		/// <summary>
		/// Void EnableMaterialKeyword(UnityEngine.Material, UnityEngine.Rendering.LocalKeyword)
		/// </summary>
		protected RMethod r_MEnableMaterialKeyword_Material_LocalKeyword;
		public virtual RMethod RMEnableMaterialKeyword_Material_LocalKeyword
		{
			get
			{
				if(r_MEnableMaterialKeyword_Material_LocalKeyword == null)
				{
					r_MEnableMaterialKeyword_Material_LocalKeyword = new(this, "EnableMaterialKeyword", 0, typeof(UnityEngine.Material), typeof(UnityEngine.Rendering.LocalKeyword));
				}
				return r_MEnableMaterialKeyword_Material_LocalKeyword;
			}
		}

		/// <summary>
		/// Void EnableComputeKeyword(UnityEngine.ComputeShader, UnityEngine.Rendering.LocalKeyword)
		/// </summary>
		protected RMethod r_MEnableComputeKeyword_ComputeShader_LocalKeyword;
		public virtual RMethod RMEnableComputeKeyword_ComputeShader_LocalKeyword
		{
			get
			{
				if(r_MEnableComputeKeyword_ComputeShader_LocalKeyword == null)
				{
					r_MEnableComputeKeyword_ComputeShader_LocalKeyword = new(this, "EnableComputeKeyword", 0, typeof(UnityEngine.ComputeShader), typeof(UnityEngine.Rendering.LocalKeyword));
				}
				return r_MEnableComputeKeyword_ComputeShader_LocalKeyword;
			}
		}

		/// <summary>
		/// Void EnableKeyword(UnityEngine.Rendering.GlobalKeyword ByRef)
		/// </summary>
		protected RMethod r_MEnableKeyword_In_GlobalKeyword;
		public virtual RMethod RMEnableKeyword_In_GlobalKeyword
		{
			get
			{
				if(r_MEnableKeyword_In_GlobalKeyword == null)
				{
					r_MEnableKeyword_In_GlobalKeyword = new(this, "EnableKeyword", 0, typeof(UnityEngine.Rendering.GlobalKeyword).MakeByRefType());
				}
				return r_MEnableKeyword_In_GlobalKeyword;
			}
		}

		/// <summary>
		/// Void EnableKeyword(UnityEngine.Material, UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_MEnableKeyword_Material_In_LocalKeyword;
		public virtual RMethod RMEnableKeyword_Material_In_LocalKeyword
		{
			get
			{
				if(r_MEnableKeyword_Material_In_LocalKeyword == null)
				{
					r_MEnableKeyword_Material_In_LocalKeyword = new(this, "EnableKeyword", 0, typeof(UnityEngine.Material), typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
				}
				return r_MEnableKeyword_Material_In_LocalKeyword;
			}
		}

		/// <summary>
		/// Void EnableKeyword(UnityEngine.ComputeShader, UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_MEnableKeyword_ComputeShader_In_LocalKeyword;
		public virtual RMethod RMEnableKeyword_ComputeShader_In_LocalKeyword
		{
			get
			{
				if(r_MEnableKeyword_ComputeShader_In_LocalKeyword == null)
				{
					r_MEnableKeyword_ComputeShader_In_LocalKeyword = new(this, "EnableKeyword", 0, typeof(UnityEngine.ComputeShader), typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
				}
				return r_MEnableKeyword_ComputeShader_In_LocalKeyword;
			}
		}

		/// <summary>
		/// Void DisableShaderKeyword(System.String)
		/// </summary>
		protected RMethod r_MDisableShaderKeyword_String;
		public virtual RMethod RMDisableShaderKeyword_String
		{
			get
			{
				if(r_MDisableShaderKeyword_String == null)
				{
					r_MDisableShaderKeyword_String = new(this, "DisableShaderKeyword", 0, typeof(System.String));
				}
				return r_MDisableShaderKeyword_String;
			}
		}

		/// <summary>
		/// Void DisableGlobalKeyword(UnityEngine.Rendering.GlobalKeyword)
		/// </summary>
		protected RMethod r_MDisableGlobalKeyword_GlobalKeyword;
		public virtual RMethod RMDisableGlobalKeyword_GlobalKeyword
		{
			get
			{
				if(r_MDisableGlobalKeyword_GlobalKeyword == null)
				{
					r_MDisableGlobalKeyword_GlobalKeyword = new(this, "DisableGlobalKeyword", 0, typeof(UnityEngine.Rendering.GlobalKeyword));
				}
				return r_MDisableGlobalKeyword_GlobalKeyword;
			}
		}

		/// <summary>
		/// Void DisableMaterialKeyword(UnityEngine.Material, UnityEngine.Rendering.LocalKeyword)
		/// </summary>
		protected RMethod r_MDisableMaterialKeyword_Material_LocalKeyword;
		public virtual RMethod RMDisableMaterialKeyword_Material_LocalKeyword
		{
			get
			{
				if(r_MDisableMaterialKeyword_Material_LocalKeyword == null)
				{
					r_MDisableMaterialKeyword_Material_LocalKeyword = new(this, "DisableMaterialKeyword", 0, typeof(UnityEngine.Material), typeof(UnityEngine.Rendering.LocalKeyword));
				}
				return r_MDisableMaterialKeyword_Material_LocalKeyword;
			}
		}

		/// <summary>
		/// Void DisableComputeKeyword(UnityEngine.ComputeShader, UnityEngine.Rendering.LocalKeyword)
		/// </summary>
		protected RMethod r_MDisableComputeKeyword_ComputeShader_LocalKeyword;
		public virtual RMethod RMDisableComputeKeyword_ComputeShader_LocalKeyword
		{
			get
			{
				if(r_MDisableComputeKeyword_ComputeShader_LocalKeyword == null)
				{
					r_MDisableComputeKeyword_ComputeShader_LocalKeyword = new(this, "DisableComputeKeyword", 0, typeof(UnityEngine.ComputeShader), typeof(UnityEngine.Rendering.LocalKeyword));
				}
				return r_MDisableComputeKeyword_ComputeShader_LocalKeyword;
			}
		}

		/// <summary>
		/// Void DisableKeyword(UnityEngine.Rendering.GlobalKeyword ByRef)
		/// </summary>
		protected RMethod r_MDisableKeyword_In_GlobalKeyword;
		public virtual RMethod RMDisableKeyword_In_GlobalKeyword
		{
			get
			{
				if(r_MDisableKeyword_In_GlobalKeyword == null)
				{
					r_MDisableKeyword_In_GlobalKeyword = new(this, "DisableKeyword", 0, typeof(UnityEngine.Rendering.GlobalKeyword).MakeByRefType());
				}
				return r_MDisableKeyword_In_GlobalKeyword;
			}
		}

		/// <summary>
		/// Void DisableKeyword(UnityEngine.Material, UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_MDisableKeyword_Material_In_LocalKeyword;
		public virtual RMethod RMDisableKeyword_Material_In_LocalKeyword
		{
			get
			{
				if(r_MDisableKeyword_Material_In_LocalKeyword == null)
				{
					r_MDisableKeyword_Material_In_LocalKeyword = new(this, "DisableKeyword", 0, typeof(UnityEngine.Material), typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
				}
				return r_MDisableKeyword_Material_In_LocalKeyword;
			}
		}

		/// <summary>
		/// Void DisableKeyword(UnityEngine.ComputeShader, UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_MDisableKeyword_ComputeShader_In_LocalKeyword;
		public virtual RMethod RMDisableKeyword_ComputeShader_In_LocalKeyword
		{
			get
			{
				if(r_MDisableKeyword_ComputeShader_In_LocalKeyword == null)
				{
					r_MDisableKeyword_ComputeShader_In_LocalKeyword = new(this, "DisableKeyword", 0, typeof(UnityEngine.ComputeShader), typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
				}
				return r_MDisableKeyword_ComputeShader_In_LocalKeyword;
			}
		}

		/// <summary>
		/// Void SetGlobalKeyword(UnityEngine.Rendering.GlobalKeyword, Boolean)
		/// </summary>
		protected RMethod r_MSetGlobalKeyword_GlobalKeyword_Boolean;
		public virtual RMethod RMSetGlobalKeyword_GlobalKeyword_Boolean
		{
			get
			{
				if(r_MSetGlobalKeyword_GlobalKeyword_Boolean == null)
				{
					r_MSetGlobalKeyword_GlobalKeyword_Boolean = new(this, "SetGlobalKeyword", 0, typeof(UnityEngine.Rendering.GlobalKeyword), typeof(System.Boolean));
				}
				return r_MSetGlobalKeyword_GlobalKeyword_Boolean;
			}
		}

		/// <summary>
		/// Void SetMaterialKeyword(UnityEngine.Material, UnityEngine.Rendering.LocalKeyword, Boolean)
		/// </summary>
		protected RMethod r_MSetMaterialKeyword_Material_LocalKeyword_Boolean;
		public virtual RMethod RMSetMaterialKeyword_Material_LocalKeyword_Boolean
		{
			get
			{
				if(r_MSetMaterialKeyword_Material_LocalKeyword_Boolean == null)
				{
					r_MSetMaterialKeyword_Material_LocalKeyword_Boolean = new(this, "SetMaterialKeyword", 0, typeof(UnityEngine.Material), typeof(UnityEngine.Rendering.LocalKeyword), typeof(System.Boolean));
				}
				return r_MSetMaterialKeyword_Material_LocalKeyword_Boolean;
			}
		}

		/// <summary>
		/// Void SetComputeKeyword(UnityEngine.ComputeShader, UnityEngine.Rendering.LocalKeyword, Boolean)
		/// </summary>
		protected RMethod r_MSetComputeKeyword_ComputeShader_LocalKeyword_Boolean;
		public virtual RMethod RMSetComputeKeyword_ComputeShader_LocalKeyword_Boolean
		{
			get
			{
				if(r_MSetComputeKeyword_ComputeShader_LocalKeyword_Boolean == null)
				{
					r_MSetComputeKeyword_ComputeShader_LocalKeyword_Boolean = new(this, "SetComputeKeyword", 0, typeof(UnityEngine.ComputeShader), typeof(UnityEngine.Rendering.LocalKeyword), typeof(System.Boolean));
				}
				return r_MSetComputeKeyword_ComputeShader_LocalKeyword_Boolean;
			}
		}

		/// <summary>
		/// Void SetKeyword(UnityEngine.Rendering.GlobalKeyword ByRef, Boolean)
		/// </summary>
		protected RMethod r_MSetKeyword_In_GlobalKeyword_Boolean;
		public virtual RMethod RMSetKeyword_In_GlobalKeyword_Boolean
		{
			get
			{
				if(r_MSetKeyword_In_GlobalKeyword_Boolean == null)
				{
					r_MSetKeyword_In_GlobalKeyword_Boolean = new(this, "SetKeyword", 0, typeof(UnityEngine.Rendering.GlobalKeyword).MakeByRefType(), typeof(System.Boolean));
				}
				return r_MSetKeyword_In_GlobalKeyword_Boolean;
			}
		}

		/// <summary>
		/// Void SetKeyword(UnityEngine.Material, UnityEngine.Rendering.LocalKeyword ByRef, Boolean)
		/// </summary>
		protected RMethod r_MSetKeyword_Material_In_LocalKeyword_Boolean;
		public virtual RMethod RMSetKeyword_Material_In_LocalKeyword_Boolean
		{
			get
			{
				if(r_MSetKeyword_Material_In_LocalKeyword_Boolean == null)
				{
					r_MSetKeyword_Material_In_LocalKeyword_Boolean = new(this, "SetKeyword", 0, typeof(UnityEngine.Material), typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType(), typeof(System.Boolean));
				}
				return r_MSetKeyword_Material_In_LocalKeyword_Boolean;
			}
		}

		/// <summary>
		/// Void SetKeyword(UnityEngine.ComputeShader, UnityEngine.Rendering.LocalKeyword ByRef, Boolean)
		/// </summary>
		protected RMethod r_MSetKeyword_ComputeShader_In_LocalKeyword_Boolean;
		public virtual RMethod RMSetKeyword_ComputeShader_In_LocalKeyword_Boolean
		{
			get
			{
				if(r_MSetKeyword_ComputeShader_In_LocalKeyword_Boolean == null)
				{
					r_MSetKeyword_ComputeShader_In_LocalKeyword_Boolean = new(this, "SetKeyword", 0, typeof(UnityEngine.ComputeShader), typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType(), typeof(System.Boolean));
				}
				return r_MSetKeyword_ComputeShader_In_LocalKeyword_Boolean;
			}
		}

		/// <summary>
		/// Void SetViewMatrix(UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_MSetViewMatrix_Matrix4x4;
		public virtual RMethod RMSetViewMatrix_Matrix4x4
		{
			get
			{
				if(r_MSetViewMatrix_Matrix4x4 == null)
				{
					r_MSetViewMatrix_Matrix4x4 = new(this, "SetViewMatrix", 0, typeof(UnityEngine.Matrix4x4));
				}
				return r_MSetViewMatrix_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetProjectionMatrix(UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_MSetProjectionMatrix_Matrix4x4;
		public virtual RMethod RMSetProjectionMatrix_Matrix4x4
		{
			get
			{
				if(r_MSetProjectionMatrix_Matrix4x4 == null)
				{
					r_MSetProjectionMatrix_Matrix4x4 = new(this, "SetProjectionMatrix", 0, typeof(UnityEngine.Matrix4x4));
				}
				return r_MSetProjectionMatrix_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetViewProjectionMatrices(UnityEngine.Matrix4x4, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_MSetViewProjectionMatrices_Matrix4x4_Matrix4x4;
		public virtual RMethod RMSetViewProjectionMatrices_Matrix4x4_Matrix4x4
		{
			get
			{
				if(r_MSetViewProjectionMatrices_Matrix4x4_Matrix4x4 == null)
				{
					r_MSetViewProjectionMatrices_Matrix4x4_Matrix4x4 = new(this, "SetViewProjectionMatrices", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Matrix4x4));
				}
				return r_MSetViewProjectionMatrices_Matrix4x4_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetGlobalDepthBias(Single, Single)
		/// </summary>
		protected RMethod r_MSetGlobalDepthBias_Single_Single;
		public virtual RMethod RMSetGlobalDepthBias_Single_Single
		{
			get
			{
				if(r_MSetGlobalDepthBias_Single_Single == null)
				{
					r_MSetGlobalDepthBias_Single_Single = new(this, "SetGlobalDepthBias", 0, typeof(System.Single), typeof(System.Single));
				}
				return r_MSetGlobalDepthBias_Single_Single;
			}
		}

		/// <summary>
		/// Void SetExecutionFlags(UnityEngine.Rendering.CommandBufferExecutionFlags)
		/// </summary>
		protected RMethod r_MSetExecutionFlags_CommandBufferExecutionFlags;
		public virtual RMethod RMSetExecutionFlags_CommandBufferExecutionFlags
		{
			get
			{
				if(r_MSetExecutionFlags_CommandBufferExecutionFlags == null)
				{
					r_MSetExecutionFlags_CommandBufferExecutionFlags = new(this, "SetExecutionFlags", 0, typeof(UnityEngine.Rendering.CommandBufferExecutionFlags));
				}
				return r_MSetExecutionFlags_CommandBufferExecutionFlags;
			}
		}

		/// <summary>
		/// Boolean ValidateAgainstExecutionFlags(UnityEngine.Rendering.CommandBufferExecutionFlags, UnityEngine.Rendering.CommandBufferExecutionFlags)
		/// </summary>
		protected RMethod r_MValidateAgainstExecutionFlags_CommandBufferExecutionFlags_CommandBufferExecutionFlags;
		public virtual RMethod RMValidateAgainstExecutionFlags_CommandBufferExecutionFlags_CommandBufferExecutionFlags
		{
			get
			{
				if(r_MValidateAgainstExecutionFlags_CommandBufferExecutionFlags_CommandBufferExecutionFlags == null)
				{
					r_MValidateAgainstExecutionFlags_CommandBufferExecutionFlags_CommandBufferExecutionFlags = new(this, "ValidateAgainstExecutionFlags", 0, typeof(UnityEngine.Rendering.CommandBufferExecutionFlags), typeof(UnityEngine.Rendering.CommandBufferExecutionFlags));
				}
				return r_MValidateAgainstExecutionFlags_CommandBufferExecutionFlags_CommandBufferExecutionFlags;
			}
		}

		/// <summary>
		/// Void SetGlobalFloatArrayListImpl(Int32, System.Object)
		/// </summary>
		protected RMethod r_MSetGlobalFloatArrayListImpl_Int32_Object;
		public virtual RMethod RMSetGlobalFloatArrayListImpl_Int32_Object
		{
			get
			{
				if(r_MSetGlobalFloatArrayListImpl_Int32_Object == null)
				{
					r_MSetGlobalFloatArrayListImpl_Int32_Object = new(this, "SetGlobalFloatArrayListImpl", 0, typeof(System.Int32), typeof(System.Object));
				}
				return r_MSetGlobalFloatArrayListImpl_Int32_Object;
			}
		}

		/// <summary>
		/// Void SetGlobalVectorArrayListImpl(Int32, System.Object)
		/// </summary>
		protected RMethod r_MSetGlobalVectorArrayListImpl_Int32_Object;
		public virtual RMethod RMSetGlobalVectorArrayListImpl_Int32_Object
		{
			get
			{
				if(r_MSetGlobalVectorArrayListImpl_Int32_Object == null)
				{
					r_MSetGlobalVectorArrayListImpl_Int32_Object = new(this, "SetGlobalVectorArrayListImpl", 0, typeof(System.Int32), typeof(System.Object));
				}
				return r_MSetGlobalVectorArrayListImpl_Int32_Object;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrixArrayListImpl(Int32, System.Object)
		/// </summary>
		protected RMethod r_MSetGlobalMatrixArrayListImpl_Int32_Object;
		public virtual RMethod RMSetGlobalMatrixArrayListImpl_Int32_Object
		{
			get
			{
				if(r_MSetGlobalMatrixArrayListImpl_Int32_Object == null)
				{
					r_MSetGlobalMatrixArrayListImpl_Int32_Object = new(this, "SetGlobalMatrixArrayListImpl", 0, typeof(System.Int32), typeof(System.Object));
				}
				return r_MSetGlobalMatrixArrayListImpl_Int32_Object;
			}
		}

		/// <summary>
		/// Void SetGlobalFloatArray(Int32, Single[])
		/// </summary>
		protected RMethod r_MSetGlobalFloatArray_Int32_SingleArray;
		public virtual RMethod RMSetGlobalFloatArray_Int32_SingleArray
		{
			get
			{
				if(r_MSetGlobalFloatArray_Int32_SingleArray == null)
				{
					r_MSetGlobalFloatArray_Int32_SingleArray = new(this, "SetGlobalFloatArray", 0, typeof(System.Int32), typeof(System.Single).MakeArrayType());
				}
				return r_MSetGlobalFloatArray_Int32_SingleArray;
			}
		}

		/// <summary>
		/// Void SetGlobalVectorArray(Int32, UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_MSetGlobalVectorArray_Int32_Vector4Array;
		public virtual RMethod RMSetGlobalVectorArray_Int32_Vector4Array
		{
			get
			{
				if(r_MSetGlobalVectorArray_Int32_Vector4Array == null)
				{
					r_MSetGlobalVectorArray_Int32_Vector4Array = new(this, "SetGlobalVectorArray", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType());
				}
				return r_MSetGlobalVectorArray_Int32_Vector4Array;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrixArray(Int32, UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_MSetGlobalMatrixArray_Int32_Matrix4x4Array;
		public virtual RMethod RMSetGlobalMatrixArray_Int32_Matrix4x4Array
		{
			get
			{
				if(r_MSetGlobalMatrixArray_Int32_Matrix4x4Array == null)
				{
					r_MSetGlobalMatrixArray_Int32_Matrix4x4Array = new(this, "SetGlobalMatrixArray", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType());
				}
				return r_MSetGlobalMatrixArray_Int32_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Void SetLateLatchProjectionMatrices(UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_MSetLateLatchProjectionMatrices_Matrix4x4Array;
		public virtual RMethod RMSetLateLatchProjectionMatrices_Matrix4x4Array
		{
			get
			{
				if(r_MSetLateLatchProjectionMatrices_Matrix4x4Array == null)
				{
					r_MSetLateLatchProjectionMatrices_Matrix4x4Array = new(this, "SetLateLatchProjectionMatrices", 0, typeof(UnityEngine.Matrix4x4).MakeArrayType());
				}
				return r_MSetLateLatchProjectionMatrices_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Void MarkLateLatchMatrixShaderPropertyID(UnityEngine.Rendering.CameraLateLatchMatrixType, Int32)
		/// </summary>
		protected RMethod r_MMarkLateLatchMatrixShaderPropertyID_CameraLateLatchMatrixType_Int32;
		public virtual RMethod RMMarkLateLatchMatrixShaderPropertyID_CameraLateLatchMatrixType_Int32
		{
			get
			{
				if(r_MMarkLateLatchMatrixShaderPropertyID_CameraLateLatchMatrixType_Int32 == null)
				{
					r_MMarkLateLatchMatrixShaderPropertyID_CameraLateLatchMatrixType_Int32 = new(this, "MarkLateLatchMatrixShaderPropertyID", 0, typeof(UnityEngine.Rendering.CameraLateLatchMatrixType), typeof(System.Int32));
				}
				return r_MMarkLateLatchMatrixShaderPropertyID_CameraLateLatchMatrixType_Int32;
			}
		}

		/// <summary>
		/// Void UnmarkLateLatchMatrix(UnityEngine.Rendering.CameraLateLatchMatrixType)
		/// </summary>
		protected RMethod r_MUnmarkLateLatchMatrix_CameraLateLatchMatrixType;
		public virtual RMethod RMUnmarkLateLatchMatrix_CameraLateLatchMatrixType
		{
			get
			{
				if(r_MUnmarkLateLatchMatrix_CameraLateLatchMatrixType == null)
				{
					r_MUnmarkLateLatchMatrix_CameraLateLatchMatrixType = new(this, "UnmarkLateLatchMatrix", 0, typeof(UnityEngine.Rendering.CameraLateLatchMatrixType));
				}
				return r_MUnmarkLateLatchMatrix_CameraLateLatchMatrixType;
			}
		}

		/// <summary>
		/// Void SetGlobalTexture_Impl(Int32, UnityEngine.Rendering.RenderTargetIdentifier ByRef, UnityEngine.Rendering.RenderTextureSubElement)
		/// </summary>
		protected RMethod r_MSetGlobalTexture_Impl_Int32_Ref_RenderTargetIdentifier_RenderTextureSubElement;
		public virtual RMethod RMSetGlobalTexture_Impl_Int32_Ref_RenderTargetIdentifier_RenderTextureSubElement
		{
			get
			{
				if(r_MSetGlobalTexture_Impl_Int32_Ref_RenderTargetIdentifier_RenderTextureSubElement == null)
				{
					r_MSetGlobalTexture_Impl_Int32_Ref_RenderTargetIdentifier_RenderTextureSubElement = new(this, "SetGlobalTexture_Impl", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(UnityEngine.Rendering.RenderTextureSubElement));
				}
				return r_MSetGlobalTexture_Impl_Int32_Ref_RenderTargetIdentifier_RenderTextureSubElement;
			}
		}

		/// <summary>
		/// Void SetGlobalBufferInternal(Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_MSetGlobalBufferInternal_Int32_ComputeBuffer;
		public virtual RMethod RMSetGlobalBufferInternal_Int32_ComputeBuffer
		{
			get
			{
				if(r_MSetGlobalBufferInternal_Int32_ComputeBuffer == null)
				{
					r_MSetGlobalBufferInternal_Int32_ComputeBuffer = new(this, "SetGlobalBufferInternal", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
				}
				return r_MSetGlobalBufferInternal_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetGlobalGraphicsBufferInternal(Int32, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_MSetGlobalGraphicsBufferInternal_Int32_GraphicsBuffer;
		public virtual RMethod RMSetGlobalGraphicsBufferInternal_Int32_GraphicsBuffer
		{
			get
			{
				if(r_MSetGlobalGraphicsBufferInternal_Int32_GraphicsBuffer == null)
				{
					r_MSetGlobalGraphicsBufferInternal_Int32_GraphicsBuffer = new(this, "SetGlobalGraphicsBufferInternal", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer));
				}
				return r_MSetGlobalGraphicsBufferInternal_Int32_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetShadowSamplingMode_Impl(UnityEngine.Rendering.RenderTargetIdentifier ByRef, UnityEngine.Rendering.ShadowSamplingMode)
		/// </summary>
		protected RMethod r_MSetShadowSamplingMode_Impl_Ref_RenderTargetIdentifier_ShadowSamplingMode;
		public virtual RMethod RMSetShadowSamplingMode_Impl_Ref_RenderTargetIdentifier_ShadowSamplingMode
		{
			get
			{
				if(r_MSetShadowSamplingMode_Impl_Ref_RenderTargetIdentifier_ShadowSamplingMode == null)
				{
					r_MSetShadowSamplingMode_Impl_Ref_RenderTargetIdentifier_ShadowSamplingMode = new(this, "SetShadowSamplingMode_Impl", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(UnityEngine.Rendering.ShadowSamplingMode));
				}
				return r_MSetShadowSamplingMode_Impl_Ref_RenderTargetIdentifier_ShadowSamplingMode;
			}
		}

		/// <summary>
		/// Void IssuePluginEventInternal(IntPtr, Int32)
		/// </summary>
		protected RMethod r_MIssuePluginEventInternal_IntPtr_Int32;
		public virtual RMethod RMIssuePluginEventInternal_IntPtr_Int32
		{
			get
			{
				if(r_MIssuePluginEventInternal_IntPtr_Int32 == null)
				{
					r_MIssuePluginEventInternal_IntPtr_Int32 = new(this, "IssuePluginEventInternal", 0, typeof(System.IntPtr), typeof(System.Int32));
				}
				return r_MIssuePluginEventInternal_IntPtr_Int32;
			}
		}

		/// <summary>
		/// Void BeginSample(System.String)
		/// </summary>
		protected RMethod r_MBeginSample_String;
		public virtual RMethod RMBeginSample_String
		{
			get
			{
				if(r_MBeginSample_String == null)
				{
					r_MBeginSample_String = new(this, "BeginSample", 0, typeof(System.String));
				}
				return r_MBeginSample_String;
			}
		}

		/// <summary>
		/// Void EndSample(System.String)
		/// </summary>
		protected RMethod r_MEndSample_String;
		public virtual RMethod RMEndSample_String
		{
			get
			{
				if(r_MEndSample_String == null)
				{
					r_MEndSample_String = new(this, "EndSample", 0, typeof(System.String));
				}
				return r_MEndSample_String;
			}
		}

		/// <summary>
		/// Void BeginSample(UnityEngine.Profiling.CustomSampler)
		/// </summary>
		protected RMethod r_MBeginSample_CustomSampler;
		public virtual RMethod RMBeginSample_CustomSampler
		{
			get
			{
				if(r_MBeginSample_CustomSampler == null)
				{
					r_MBeginSample_CustomSampler = new(this, "BeginSample", 0, typeof(UnityEngine.Profiling.CustomSampler));
				}
				return r_MBeginSample_CustomSampler;
			}
		}

		/// <summary>
		/// Void EndSample(UnityEngine.Profiling.CustomSampler)
		/// </summary>
		protected RMethod r_MEndSample_CustomSampler;
		public virtual RMethod RMEndSample_CustomSampler
		{
			get
			{
				if(r_MEndSample_CustomSampler == null)
				{
					r_MEndSample_CustomSampler = new(this, "EndSample", 0, typeof(UnityEngine.Profiling.CustomSampler));
				}
				return r_MEndSample_CustomSampler;
			}
		}

		/// <summary>
		/// Void BeginSample_CustomSampler(UnityEngine.Profiling.CustomSampler)
		/// </summary>
		protected RMethod r_MBeginSample_CustomSampler_CustomSampler;
		public virtual RMethod RMBeginSample_CustomSampler_CustomSampler
		{
			get
			{
				if(r_MBeginSample_CustomSampler_CustomSampler == null)
				{
					r_MBeginSample_CustomSampler_CustomSampler = new(this, "BeginSample_CustomSampler", 0, typeof(UnityEngine.Profiling.CustomSampler));
				}
				return r_MBeginSample_CustomSampler_CustomSampler;
			}
		}

		/// <summary>
		/// Void EndSample_CustomSampler(UnityEngine.Profiling.CustomSampler)
		/// </summary>
		protected RMethod r_MEndSample_CustomSampler_CustomSampler;
		public virtual RMethod RMEndSample_CustomSampler_CustomSampler
		{
			get
			{
				if(r_MEndSample_CustomSampler_CustomSampler == null)
				{
					r_MEndSample_CustomSampler_CustomSampler = new(this, "EndSample_CustomSampler", 0, typeof(UnityEngine.Profiling.CustomSampler));
				}
				return r_MEndSample_CustomSampler_CustomSampler;
			}
		}

		/// <summary>
		/// Void BeginSample(Unity.Profiling.ProfilerMarker)
		/// </summary>
		protected RMethod r_MBeginSample_ProfilerMarker;
		public virtual RMethod RMBeginSample_ProfilerMarker
		{
			get
			{
				if(r_MBeginSample_ProfilerMarker == null)
				{
					r_MBeginSample_ProfilerMarker = new(this, "BeginSample", 0, typeof(Unity.Profiling.ProfilerMarker));
				}
				return r_MBeginSample_ProfilerMarker;
			}
		}

		/// <summary>
		/// Void EndSample(Unity.Profiling.ProfilerMarker)
		/// </summary>
		protected RMethod r_MEndSample_ProfilerMarker;
		public virtual RMethod RMEndSample_ProfilerMarker
		{
			get
			{
				if(r_MEndSample_ProfilerMarker == null)
				{
					r_MEndSample_ProfilerMarker = new(this, "EndSample", 0, typeof(Unity.Profiling.ProfilerMarker));
				}
				return r_MEndSample_ProfilerMarker;
			}
		}

		/// <summary>
		/// Void BeginSample_ProfilerMarker(IntPtr)
		/// </summary>
		protected RMethod r_MBeginSample_ProfilerMarker_IntPtr;
		public virtual RMethod RMBeginSample_ProfilerMarker_IntPtr
		{
			get
			{
				if(r_MBeginSample_ProfilerMarker_IntPtr == null)
				{
					r_MBeginSample_ProfilerMarker_IntPtr = new(this, "BeginSample_ProfilerMarker", 0, typeof(System.IntPtr));
				}
				return r_MBeginSample_ProfilerMarker_IntPtr;
			}
		}

		/// <summary>
		/// Void EndSample_ProfilerMarker(IntPtr)
		/// </summary>
		protected RMethod r_MEndSample_ProfilerMarker_IntPtr;
		public virtual RMethod RMEndSample_ProfilerMarker_IntPtr
		{
			get
			{
				if(r_MEndSample_ProfilerMarker_IntPtr == null)
				{
					r_MEndSample_ProfilerMarker_IntPtr = new(this, "EndSample_ProfilerMarker", 0, typeof(System.IntPtr));
				}
				return r_MEndSample_ProfilerMarker_IntPtr;
			}
		}

		/// <summary>
		/// Void IssuePluginEventAndDataInternal(IntPtr, Int32, IntPtr)
		/// </summary>
		protected RMethod r_MIssuePluginEventAndDataInternal_IntPtr_Int32_IntPtr;
		public virtual RMethod RMIssuePluginEventAndDataInternal_IntPtr_Int32_IntPtr
		{
			get
			{
				if(r_MIssuePluginEventAndDataInternal_IntPtr_Int32_IntPtr == null)
				{
					r_MIssuePluginEventAndDataInternal_IntPtr_Int32_IntPtr = new(this, "IssuePluginEventAndDataInternal", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.IntPtr));
				}
				return r_MIssuePluginEventAndDataInternal_IntPtr_Int32_IntPtr;
			}
		}

		/// <summary>
		/// Void IssuePluginEventAndDataInternalWithFlags(IntPtr, Int32, UnityEngine.Rendering.CustomMarkerCallbackFlags, IntPtr)
		/// </summary>
		protected RMethod r_MIssuePluginEventAndDataInternalWithFlags_IntPtr_Int32_CustomMarkerCallbackFlags_IntPtr;
		public virtual RMethod RMIssuePluginEventAndDataInternalWithFlags_IntPtr_Int32_CustomMarkerCallbackFlags_IntPtr
		{
			get
			{
				if(r_MIssuePluginEventAndDataInternalWithFlags_IntPtr_Int32_CustomMarkerCallbackFlags_IntPtr == null)
				{
					r_MIssuePluginEventAndDataInternalWithFlags_IntPtr_Int32_CustomMarkerCallbackFlags_IntPtr = new(this, "IssuePluginEventAndDataInternalWithFlags", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(UnityEngine.Rendering.CustomMarkerCallbackFlags), typeof(System.IntPtr));
				}
				return r_MIssuePluginEventAndDataInternalWithFlags_IntPtr_Int32_CustomMarkerCallbackFlags_IntPtr;
			}
		}

		/// <summary>
		/// Void IssuePluginCustomBlitInternal(IntPtr, UInt32, UnityEngine.Rendering.RenderTargetIdentifier ByRef, UnityEngine.Rendering.RenderTargetIdentifier ByRef, UInt32, UInt32)
		/// </summary>
		protected RMethod r_MIssuePluginCustomBlitInternal_IntPtr_UInt32_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_UInt32_UInt32;
		public virtual RMethod RMIssuePluginCustomBlitInternal_IntPtr_UInt32_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_UInt32_UInt32
		{
			get
			{
				if(r_MIssuePluginCustomBlitInternal_IntPtr_UInt32_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_UInt32_UInt32 == null)
				{
					r_MIssuePluginCustomBlitInternal_IntPtr_UInt32_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_UInt32_UInt32 = new(this, "IssuePluginCustomBlitInternal", 0, typeof(System.IntPtr), typeof(System.UInt32), typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(System.UInt32), typeof(System.UInt32));
				}
				return r_MIssuePluginCustomBlitInternal_IntPtr_UInt32_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_UInt32_UInt32;
			}
		}

		/// <summary>
		/// Void IssuePluginCustomTextureUpdateInternal(IntPtr, UnityEngine.Texture, UInt32, Boolean)
		/// </summary>
		protected RMethod r_MIssuePluginCustomTextureUpdateInternal_IntPtr_Texture_UInt32_Boolean;
		public virtual RMethod RMIssuePluginCustomTextureUpdateInternal_IntPtr_Texture_UInt32_Boolean
		{
			get
			{
				if(r_MIssuePluginCustomTextureUpdateInternal_IntPtr_Texture_UInt32_Boolean == null)
				{
					r_MIssuePluginCustomTextureUpdateInternal_IntPtr_Texture_UInt32_Boolean = new(this, "IssuePluginCustomTextureUpdateInternal", 0, typeof(System.IntPtr), typeof(UnityEngine.Texture), typeof(System.UInt32), typeof(System.Boolean));
				}
				return r_MIssuePluginCustomTextureUpdateInternal_IntPtr_Texture_UInt32_Boolean;
			}
		}

		/// <summary>
		/// Void SetGlobalConstantBufferInternal(UnityEngine.ComputeBuffer, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetGlobalConstantBufferInternal_ComputeBuffer_Int32_Int32_Int32;
		public virtual RMethod RMSetGlobalConstantBufferInternal_ComputeBuffer_Int32_Int32_Int32
		{
			get
			{
				if(r_MSetGlobalConstantBufferInternal_ComputeBuffer_Int32_Int32_Int32 == null)
				{
					r_MSetGlobalConstantBufferInternal_ComputeBuffer_Int32_Int32_Int32 = new(this, "SetGlobalConstantBufferInternal", 0, typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetGlobalConstantBufferInternal_ComputeBuffer_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalConstantGraphicsBufferInternal(UnityEngine.GraphicsBuffer, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetGlobalConstantGraphicsBufferInternal_GraphicsBuffer_Int32_Int32_Int32;
		public virtual RMethod RMSetGlobalConstantGraphicsBufferInternal_GraphicsBuffer_Int32_Int32_Int32
		{
			get
			{
				if(r_MSetGlobalConstantGraphicsBufferInternal_GraphicsBuffer_Int32_Int32_Int32 == null)
				{
					r_MSetGlobalConstantGraphicsBufferInternal_GraphicsBuffer_Int32_Int32_Int32 = new(this, "SetGlobalConstantGraphicsBufferInternal", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetGlobalConstantGraphicsBufferInternal_GraphicsBuffer_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void IncrementUpdateCount(UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_MIncrementUpdateCount_RenderTargetIdentifier;
		public virtual RMethod RMIncrementUpdateCount_RenderTargetIdentifier
		{
			get
			{
				if(r_MIncrementUpdateCount_RenderTargetIdentifier == null)
				{
					r_MIncrementUpdateCount_RenderTargetIdentifier = new(this, "IncrementUpdateCount", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier));
				}
				return r_MIncrementUpdateCount_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void SetInstanceMultiplier(UInt32)
		/// </summary>
		protected RMethod r_MSetInstanceMultiplier_UInt32;
		public virtual RMethod RMSetInstanceMultiplier_UInt32
		{
			get
			{
				if(r_MSetInstanceMultiplier_UInt32 == null)
				{
					r_MSetInstanceMultiplier_UInt32 = new(this, "SetInstanceMultiplier", 0, typeof(System.UInt32));
				}
				return r_MSetInstanceMultiplier_UInt32;
			}
		}

		/// <summary>
		/// Void SetFoveatedRenderingMode(UnityEngine.Rendering.FoveatedRenderingMode)
		/// </summary>
		protected RMethod r_MSetFoveatedRenderingMode_FoveatedRenderingMode;
		public virtual RMethod RMSetFoveatedRenderingMode_FoveatedRenderingMode
		{
			get
			{
				if(r_MSetFoveatedRenderingMode_FoveatedRenderingMode == null)
				{
					r_MSetFoveatedRenderingMode_FoveatedRenderingMode = new(this, "SetFoveatedRenderingMode", 0, typeof(UnityEngine.Rendering.FoveatedRenderingMode));
				}
				return r_MSetFoveatedRenderingMode_FoveatedRenderingMode;
			}
		}

		/// <summary>
		/// Void ConfigureFoveatedRendering(IntPtr)
		/// </summary>
		protected RMethod r_MConfigureFoveatedRendering_IntPtr;
		public virtual RMethod RMConfigureFoveatedRendering_IntPtr
		{
			get
			{
				if(r_MConfigureFoveatedRendering_IntPtr == null)
				{
					r_MConfigureFoveatedRendering_IntPtr = new(this, "ConfigureFoveatedRendering", 0, typeof(System.IntPtr));
				}
				return r_MConfigureFoveatedRendering_IntPtr;
			}
		}

		/// <summary>
		/// Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_MSetRenderTarget_RenderTargetIdentifier;
		public virtual RMethod RMSetRenderTarget_RenderTargetIdentifier
		{
			get
			{
				if(r_MSetRenderTarget_RenderTargetIdentifier == null)
				{
					r_MSetRenderTarget_RenderTargetIdentifier = new(this, "SetRenderTarget", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier));
				}
				return r_MSetRenderTarget_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction)
		/// </summary>
		protected RMethod r_MSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction;
		public virtual RMethod RMSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction
		{
			get
			{
				if(r_MSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction == null)
				{
					r_MSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction = new(this, "SetRenderTarget", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction));
				}
				return r_MSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction;
			}
		}

		/// <summary>
		/// Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction)
		/// </summary>
		protected RMethod r_MSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction;
		public virtual RMethod RMSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction
		{
			get
			{
				if(r_MSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction == null)
				{
					r_MSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction = new(this, "SetRenderTarget", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction));
				}
				return r_MSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction;
			}
		}

		/// <summary>
		/// Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier, Int32)
		/// </summary>
		protected RMethod r_MSetRenderTarget_RenderTargetIdentifier_Int32;
		public virtual RMethod RMSetRenderTarget_RenderTargetIdentifier_Int32
		{
			get
			{
				if(r_MSetRenderTarget_RenderTargetIdentifier_Int32 == null)
				{
					r_MSetRenderTarget_RenderTargetIdentifier_Int32 = new(this, "SetRenderTarget", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32));
				}
				return r_MSetRenderTarget_RenderTargetIdentifier_Int32;
			}
		}

		/// <summary>
		/// Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier, Int32, UnityEngine.CubemapFace)
		/// </summary>
		protected RMethod r_MSetRenderTarget_RenderTargetIdentifier_Int32_CubemapFace;
		public virtual RMethod RMSetRenderTarget_RenderTargetIdentifier_Int32_CubemapFace
		{
			get
			{
				if(r_MSetRenderTarget_RenderTargetIdentifier_Int32_CubemapFace == null)
				{
					r_MSetRenderTarget_RenderTargetIdentifier_Int32_CubemapFace = new(this, "SetRenderTarget", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(UnityEngine.CubemapFace));
				}
				return r_MSetRenderTarget_RenderTargetIdentifier_Int32_CubemapFace;
			}
		}

		/// <summary>
		/// Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier, Int32, UnityEngine.CubemapFace, Int32)
		/// </summary>
		protected RMethod r_MSetRenderTarget_RenderTargetIdentifier_Int32_CubemapFace_Int32;
		public virtual RMethod RMSetRenderTarget_RenderTargetIdentifier_Int32_CubemapFace_Int32
		{
			get
			{
				if(r_MSetRenderTarget_RenderTargetIdentifier_Int32_CubemapFace_Int32 == null)
				{
					r_MSetRenderTarget_RenderTargetIdentifier_Int32_CubemapFace_Int32 = new(this, "SetRenderTarget", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(UnityEngine.CubemapFace), typeof(System.Int32));
				}
				return r_MSetRenderTarget_RenderTargetIdentifier_Int32_CubemapFace_Int32;
			}
		}

		/// <summary>
		/// Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_MSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier;
		public virtual RMethod RMSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier
		{
			get
			{
				if(r_MSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier == null)
				{
					r_MSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier = new(this, "SetRenderTarget", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier));
				}
				return r_MSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier, Int32)
		/// </summary>
		protected RMethod r_MSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32;
		public virtual RMethod RMSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32
		{
			get
			{
				if(r_MSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32 == null)
				{
					r_MSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32 = new(this, "SetRenderTarget", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32));
				}
				return r_MSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32;
			}
		}

		/// <summary>
		/// Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier, Int32, UnityEngine.CubemapFace)
		/// </summary>
		protected RMethod r_MSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32_CubemapFace;
		public virtual RMethod RMSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32_CubemapFace
		{
			get
			{
				if(r_MSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32_CubemapFace == null)
				{
					r_MSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32_CubemapFace = new(this, "SetRenderTarget", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(UnityEngine.CubemapFace));
				}
				return r_MSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32_CubemapFace;
			}
		}

		/// <summary>
		/// Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier, Int32, UnityEngine.CubemapFace, Int32)
		/// </summary>
		protected RMethod r_MSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32_CubemapFace_Int32;
		public virtual RMethod RMSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32_CubemapFace_Int32
		{
			get
			{
				if(r_MSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32_CubemapFace_Int32 == null)
				{
					r_MSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32_CubemapFace_Int32 = new(this, "SetRenderTarget", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(UnityEngine.CubemapFace), typeof(System.Int32));
				}
				return r_MSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32_CubemapFace_Int32;
			}
		}

		/// <summary>
		/// Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction)
		/// </summary>
		protected RMethod r_MSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction;
		public virtual RMethod RMSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction
		{
			get
			{
				if(r_MSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction == null)
				{
					r_MSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction = new(this, "SetRenderTarget", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction));
				}
				return r_MSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction;
			}
		}

		/// <summary>
		/// Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier[], UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_MSetRenderTarget_RenderTargetIdentifierArray_RenderTargetIdentifier;
		public virtual RMethod RMSetRenderTarget_RenderTargetIdentifierArray_RenderTargetIdentifier
		{
			get
			{
				if(r_MSetRenderTarget_RenderTargetIdentifierArray_RenderTargetIdentifier == null)
				{
					r_MSetRenderTarget_RenderTargetIdentifierArray_RenderTargetIdentifier = new(this, "SetRenderTarget", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeArrayType(), typeof(UnityEngine.Rendering.RenderTargetIdentifier));
				}
				return r_MSetRenderTarget_RenderTargetIdentifierArray_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier[], UnityEngine.Rendering.RenderTargetIdentifier, Int32, UnityEngine.CubemapFace, Int32)
		/// </summary>
		protected RMethod r_MSetRenderTarget_RenderTargetIdentifierArray_RenderTargetIdentifier_Int32_CubemapFace_Int32;
		public virtual RMethod RMSetRenderTarget_RenderTargetIdentifierArray_RenderTargetIdentifier_Int32_CubemapFace_Int32
		{
			get
			{
				if(r_MSetRenderTarget_RenderTargetIdentifierArray_RenderTargetIdentifier_Int32_CubemapFace_Int32 == null)
				{
					r_MSetRenderTarget_RenderTargetIdentifierArray_RenderTargetIdentifier_Int32_CubemapFace_Int32 = new(this, "SetRenderTarget", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeArrayType(), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(UnityEngine.CubemapFace), typeof(System.Int32));
				}
				return r_MSetRenderTarget_RenderTargetIdentifierArray_RenderTargetIdentifier_Int32_CubemapFace_Int32;
			}
		}

		/// <summary>
		/// Void SetRenderTarget(UnityEngine.Rendering.RenderTargetBinding, Int32, UnityEngine.CubemapFace, Int32)
		/// </summary>
		protected RMethod r_MSetRenderTarget_RenderTargetBinding_Int32_CubemapFace_Int32;
		public virtual RMethod RMSetRenderTarget_RenderTargetBinding_Int32_CubemapFace_Int32
		{
			get
			{
				if(r_MSetRenderTarget_RenderTargetBinding_Int32_CubemapFace_Int32 == null)
				{
					r_MSetRenderTarget_RenderTargetBinding_Int32_CubemapFace_Int32 = new(this, "SetRenderTarget", 0, typeof(UnityEngine.Rendering.RenderTargetBinding), typeof(System.Int32), typeof(UnityEngine.CubemapFace), typeof(System.Int32));
				}
				return r_MSetRenderTarget_RenderTargetBinding_Int32_CubemapFace_Int32;
			}
		}

		/// <summary>
		/// Void SetRenderTarget(UnityEngine.Rendering.RenderTargetBinding)
		/// </summary>
		protected RMethod r_MSetRenderTarget_RenderTargetBinding;
		public virtual RMethod RMSetRenderTarget_RenderTargetBinding
		{
			get
			{
				if(r_MSetRenderTarget_RenderTargetBinding == null)
				{
					r_MSetRenderTarget_RenderTargetBinding = new(this, "SetRenderTarget", 0, typeof(UnityEngine.Rendering.RenderTargetBinding));
				}
				return r_MSetRenderTarget_RenderTargetBinding;
			}
		}

		/// <summary>
		/// Void SetRenderTargetSingle_Internal(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction)
		/// </summary>
		protected RMethod r_MSetRenderTargetSingle_Internal_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction;
		public virtual RMethod RMSetRenderTargetSingle_Internal_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction
		{
			get
			{
				if(r_MSetRenderTargetSingle_Internal_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction == null)
				{
					r_MSetRenderTargetSingle_Internal_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction = new(this, "SetRenderTargetSingle_Internal", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction));
				}
				return r_MSetRenderTargetSingle_Internal_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction;
			}
		}

		/// <summary>
		/// Void SetRenderTargetColorDepth_Internal(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, UnityEngine.Rendering.RenderTargetFlags)
		/// </summary>
		protected RMethod r_MSetRenderTargetColorDepth_Internal_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags;
		public virtual RMethod RMSetRenderTargetColorDepth_Internal_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags
		{
			get
			{
				if(r_MSetRenderTargetColorDepth_Internal_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags == null)
				{
					r_MSetRenderTargetColorDepth_Internal_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags = new(this, "SetRenderTargetColorDepth_Internal", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction), typeof(UnityEngine.Rendering.RenderTargetFlags));
				}
				return r_MSetRenderTargetColorDepth_Internal_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags;
			}
		}

		/// <summary>
		/// Void SetRenderTargetMulti_Internal(UnityEngine.Rendering.RenderTargetIdentifier[], UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderBufferLoadAction[], UnityEngine.Rendering.RenderBufferStoreAction[], UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, UnityEngine.Rendering.RenderTargetFlags)
		/// </summary>
		protected RMethod r_MSetRenderTargetMulti_Internal_RenderTargetIdentifierArray_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags;
		public virtual RMethod RMSetRenderTargetMulti_Internal_RenderTargetIdentifierArray_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags
		{
			get
			{
				if(r_MSetRenderTargetMulti_Internal_RenderTargetIdentifierArray_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags == null)
				{
					r_MSetRenderTargetMulti_Internal_RenderTargetIdentifierArray_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags = new(this, "SetRenderTargetMulti_Internal", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeArrayType(), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderBufferLoadAction).MakeArrayType(), typeof(UnityEngine.Rendering.RenderBufferStoreAction).MakeArrayType(), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction), typeof(UnityEngine.Rendering.RenderTargetFlags));
				}
				return r_MSetRenderTargetMulti_Internal_RenderTargetIdentifierArray_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags;
			}
		}

		/// <summary>
		/// Void SetRenderTargetColorDepthSubtarget(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, Int32, UnityEngine.CubemapFace, Int32)
		/// </summary>
		protected RMethod r_MSetRenderTargetColorDepthSubtarget_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32;
		public virtual RMethod RMSetRenderTargetColorDepthSubtarget_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32
		{
			get
			{
				if(r_MSetRenderTargetColorDepthSubtarget_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32 == null)
				{
					r_MSetRenderTargetColorDepthSubtarget_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32 = new(this, "SetRenderTargetColorDepthSubtarget", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction), typeof(System.Int32), typeof(UnityEngine.CubemapFace), typeof(System.Int32));
				}
				return r_MSetRenderTargetColorDepthSubtarget_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32;
			}
		}

		/// <summary>
		/// Void SetRenderTargetMultiSubtarget(UnityEngine.Rendering.RenderTargetIdentifier[], UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderBufferLoadAction[], UnityEngine.Rendering.RenderBufferStoreAction[], UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, Int32, UnityEngine.CubemapFace, Int32)
		/// </summary>
		protected RMethod r_MSetRenderTargetMultiSubtarget_RenderTargetIdentifierArray_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32;
		public virtual RMethod RMSetRenderTargetMultiSubtarget_RenderTargetIdentifierArray_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32
		{
			get
			{
				if(r_MSetRenderTargetMultiSubtarget_RenderTargetIdentifierArray_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32 == null)
				{
					r_MSetRenderTargetMultiSubtarget_RenderTargetIdentifierArray_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32 = new(this, "SetRenderTargetMultiSubtarget", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeArrayType(), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderBufferLoadAction).MakeArrayType(), typeof(UnityEngine.Rendering.RenderBufferStoreAction).MakeArrayType(), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction), typeof(System.Int32), typeof(UnityEngine.CubemapFace), typeof(System.Int32));
				}
				return r_MSetRenderTargetMultiSubtarget_RenderTargetIdentifierArray_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32;
			}
		}

		/// <summary>
		/// Void Internal_ProcessVTFeedback(UnityEngine.Rendering.RenderTargetIdentifier, IntPtr, Int32, Int32, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MInternal_ProcessVTFeedback_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32;
		public virtual RMethod RMInternal_ProcessVTFeedback_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MInternal_ProcessVTFeedback_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32 == null)
				{
					r_MInternal_ProcessVTFeedback_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32 = new(this, "Internal_ProcessVTFeedback", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MInternal_ProcessVTFeedback_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetBufferData(UnityEngine.ComputeBuffer, System.Array)
		/// </summary>
		protected RMethod r_MSetBufferData_ComputeBuffer_Array;
		public virtual RMethod RMSetBufferData_ComputeBuffer_Array
		{
			get
			{
				if(r_MSetBufferData_ComputeBuffer_Array == null)
				{
					r_MSetBufferData_ComputeBuffer_Array = new(this, "SetBufferData", 0, typeof(UnityEngine.ComputeBuffer), typeof(System.Array));
				}
				return r_MSetBufferData_ComputeBuffer_Array;
			}
		}

		/// <summary>
		/// Void SetBufferData[T](UnityEngine.ComputeBuffer, System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_MSetBufferData_GT_ComputeBuffer_List_d_T_p_;
		public virtual RMethod RMSetBufferData_GT_ComputeBuffer_List_d_T_p_
		{
			get
			{
				if(r_MSetBufferData_GT_ComputeBuffer_List_d_T_p_ == null)
				{
					r_MSetBufferData_GT_ComputeBuffer_List_d_T_p_ = new(this, "SetBufferData", 1, typeof(UnityEngine.ComputeBuffer),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MSetBufferData_GT_ComputeBuffer_List_d_T_p_;
			}
		}

		/// <summary>
		/// Void SetBufferData[T](UnityEngine.ComputeBuffer, Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_MSetBufferData_GT_ComputeBuffer_NativeArray_d_T_p_;
		public virtual RMethod RMSetBufferData_GT_ComputeBuffer_NativeArray_d_T_p_
		{
			get
			{
				if(r_MSetBufferData_GT_ComputeBuffer_NativeArray_d_T_p_ == null)
				{
					r_MSetBufferData_GT_ComputeBuffer_NativeArray_d_T_p_ = new(this, "SetBufferData", 1, typeof(UnityEngine.ComputeBuffer),  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MSetBufferData_GT_ComputeBuffer_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void SetBufferData(UnityEngine.ComputeBuffer, System.Array, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetBufferData_ComputeBuffer_Array_Int32_Int32_Int32;
		public virtual RMethod RMSetBufferData_ComputeBuffer_Array_Int32_Int32_Int32
		{
			get
			{
				if(r_MSetBufferData_ComputeBuffer_Array_Int32_Int32_Int32 == null)
				{
					r_MSetBufferData_ComputeBuffer_Array_Int32_Int32_Int32 = new(this, "SetBufferData", 0, typeof(UnityEngine.ComputeBuffer), typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetBufferData_ComputeBuffer_Array_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetBufferData[T](UnityEngine.ComputeBuffer, System.Collections.Generic.List`1[T], Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetBufferData_GT_ComputeBuffer_List_d_T_p__Int32_Int32_Int32;
		public virtual RMethod RMSetBufferData_GT_ComputeBuffer_List_d_T_p__Int32_Int32_Int32
		{
			get
			{
				if(r_MSetBufferData_GT_ComputeBuffer_List_d_T_p__Int32_Int32_Int32 == null)
				{
					r_MSetBufferData_GT_ComputeBuffer_List_d_T_p__Int32_Int32_Int32 = new(this, "SetBufferData", 1, typeof(UnityEngine.ComputeBuffer),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetBufferData_GT_ComputeBuffer_List_d_T_p__Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetBufferData[T](UnityEngine.ComputeBuffer, Unity.Collections.NativeArray`1[T], Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetBufferData_GT_ComputeBuffer_NativeArray_d_T_p__Int32_Int32_Int32;
		public virtual RMethod RMSetBufferData_GT_ComputeBuffer_NativeArray_d_T_p__Int32_Int32_Int32
		{
			get
			{
				if(r_MSetBufferData_GT_ComputeBuffer_NativeArray_d_T_p__Int32_Int32_Int32 == null)
				{
					r_MSetBufferData_GT_ComputeBuffer_NativeArray_d_T_p__Int32_Int32_Int32 = new(this, "SetBufferData", 1, typeof(UnityEngine.ComputeBuffer),  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetBufferData_GT_ComputeBuffer_NativeArray_d_T_p__Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetBufferCounterValue(UnityEngine.ComputeBuffer, UInt32)
		/// </summary>
		protected RMethod r_MSetBufferCounterValue_ComputeBuffer_UInt32;
		public virtual RMethod RMSetBufferCounterValue_ComputeBuffer_UInt32
		{
			get
			{
				if(r_MSetBufferCounterValue_ComputeBuffer_UInt32 == null)
				{
					r_MSetBufferCounterValue_ComputeBuffer_UInt32 = new(this, "SetBufferCounterValue", 0, typeof(UnityEngine.ComputeBuffer), typeof(System.UInt32));
				}
				return r_MSetBufferCounterValue_ComputeBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void InternalSetComputeBufferNativeData(UnityEngine.ComputeBuffer, IntPtr, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MInternalSetComputeBufferNativeData_ComputeBuffer_IntPtr_Int32_Int32_Int32_Int32;
		public virtual RMethod RMInternalSetComputeBufferNativeData_ComputeBuffer_IntPtr_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MInternalSetComputeBufferNativeData_ComputeBuffer_IntPtr_Int32_Int32_Int32_Int32 == null)
				{
					r_MInternalSetComputeBufferNativeData_ComputeBuffer_IntPtr_Int32_Int32_Int32_Int32 = new(this, "InternalSetComputeBufferNativeData", 0, typeof(UnityEngine.ComputeBuffer), typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MInternalSetComputeBufferNativeData_ComputeBuffer_IntPtr_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void InternalSetComputeBufferData(UnityEngine.ComputeBuffer, System.Array, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MInternalSetComputeBufferData_ComputeBuffer_Array_Int32_Int32_Int32_Int32;
		public virtual RMethod RMInternalSetComputeBufferData_ComputeBuffer_Array_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MInternalSetComputeBufferData_ComputeBuffer_Array_Int32_Int32_Int32_Int32 == null)
				{
					r_MInternalSetComputeBufferData_ComputeBuffer_Array_Int32_Int32_Int32_Int32 = new(this, "InternalSetComputeBufferData", 0, typeof(UnityEngine.ComputeBuffer), typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MInternalSetComputeBufferData_ComputeBuffer_Array_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void InternalSetComputeBufferCounterValue(UnityEngine.ComputeBuffer, UInt32)
		/// </summary>
		protected RMethod r_MInternalSetComputeBufferCounterValue_ComputeBuffer_UInt32;
		public virtual RMethod RMInternalSetComputeBufferCounterValue_ComputeBuffer_UInt32
		{
			get
			{
				if(r_MInternalSetComputeBufferCounterValue_ComputeBuffer_UInt32 == null)
				{
					r_MInternalSetComputeBufferCounterValue_ComputeBuffer_UInt32 = new(this, "InternalSetComputeBufferCounterValue", 0, typeof(UnityEngine.ComputeBuffer), typeof(System.UInt32));
				}
				return r_MInternalSetComputeBufferCounterValue_ComputeBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void SetBufferData(UnityEngine.GraphicsBuffer, System.Array)
		/// </summary>
		protected RMethod r_MSetBufferData_GraphicsBuffer_Array;
		public virtual RMethod RMSetBufferData_GraphicsBuffer_Array
		{
			get
			{
				if(r_MSetBufferData_GraphicsBuffer_Array == null)
				{
					r_MSetBufferData_GraphicsBuffer_Array = new(this, "SetBufferData", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.Array));
				}
				return r_MSetBufferData_GraphicsBuffer_Array;
			}
		}

		/// <summary>
		/// Void SetBufferData[T](UnityEngine.GraphicsBuffer, System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_MSetBufferData_GT_GraphicsBuffer_List_d_T_p_;
		public virtual RMethod RMSetBufferData_GT_GraphicsBuffer_List_d_T_p_
		{
			get
			{
				if(r_MSetBufferData_GT_GraphicsBuffer_List_d_T_p_ == null)
				{
					r_MSetBufferData_GT_GraphicsBuffer_List_d_T_p_ = new(this, "SetBufferData", 1, typeof(UnityEngine.GraphicsBuffer),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MSetBufferData_GT_GraphicsBuffer_List_d_T_p_;
			}
		}

		/// <summary>
		/// Void SetBufferData[T](UnityEngine.GraphicsBuffer, Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_MSetBufferData_GT_GraphicsBuffer_NativeArray_d_T_p_;
		public virtual RMethod RMSetBufferData_GT_GraphicsBuffer_NativeArray_d_T_p_
		{
			get
			{
				if(r_MSetBufferData_GT_GraphicsBuffer_NativeArray_d_T_p_ == null)
				{
					r_MSetBufferData_GT_GraphicsBuffer_NativeArray_d_T_p_ = new(this, "SetBufferData", 1, typeof(UnityEngine.GraphicsBuffer),  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MSetBufferData_GT_GraphicsBuffer_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void SetBufferData(UnityEngine.GraphicsBuffer, System.Array, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetBufferData_GraphicsBuffer_Array_Int32_Int32_Int32;
		public virtual RMethod RMSetBufferData_GraphicsBuffer_Array_Int32_Int32_Int32
		{
			get
			{
				if(r_MSetBufferData_GraphicsBuffer_Array_Int32_Int32_Int32 == null)
				{
					r_MSetBufferData_GraphicsBuffer_Array_Int32_Int32_Int32 = new(this, "SetBufferData", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetBufferData_GraphicsBuffer_Array_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetBufferData[T](UnityEngine.GraphicsBuffer, System.Collections.Generic.List`1[T], Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetBufferData_GT_GraphicsBuffer_List_d_T_p__Int32_Int32_Int32;
		public virtual RMethod RMSetBufferData_GT_GraphicsBuffer_List_d_T_p__Int32_Int32_Int32
		{
			get
			{
				if(r_MSetBufferData_GT_GraphicsBuffer_List_d_T_p__Int32_Int32_Int32 == null)
				{
					r_MSetBufferData_GT_GraphicsBuffer_List_d_T_p__Int32_Int32_Int32 = new(this, "SetBufferData", 1, typeof(UnityEngine.GraphicsBuffer),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetBufferData_GT_GraphicsBuffer_List_d_T_p__Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetBufferData[T](UnityEngine.GraphicsBuffer, Unity.Collections.NativeArray`1[T], Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetBufferData_GT_GraphicsBuffer_NativeArray_d_T_p__Int32_Int32_Int32;
		public virtual RMethod RMSetBufferData_GT_GraphicsBuffer_NativeArray_d_T_p__Int32_Int32_Int32
		{
			get
			{
				if(r_MSetBufferData_GT_GraphicsBuffer_NativeArray_d_T_p__Int32_Int32_Int32 == null)
				{
					r_MSetBufferData_GT_GraphicsBuffer_NativeArray_d_T_p__Int32_Int32_Int32 = new(this, "SetBufferData", 1, typeof(UnityEngine.GraphicsBuffer),  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetBufferData_GT_GraphicsBuffer_NativeArray_d_T_p__Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetBufferCounterValue(UnityEngine.GraphicsBuffer, UInt32)
		/// </summary>
		protected RMethod r_MSetBufferCounterValue_GraphicsBuffer_UInt32;
		public virtual RMethod RMSetBufferCounterValue_GraphicsBuffer_UInt32
		{
			get
			{
				if(r_MSetBufferCounterValue_GraphicsBuffer_UInt32 == null)
				{
					r_MSetBufferCounterValue_GraphicsBuffer_UInt32 = new(this, "SetBufferCounterValue", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32));
				}
				return r_MSetBufferCounterValue_GraphicsBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void InternalSetGraphicsBufferNativeData(UnityEngine.GraphicsBuffer, IntPtr, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MInternalSetGraphicsBufferNativeData_GraphicsBuffer_IntPtr_Int32_Int32_Int32_Int32;
		public virtual RMethod RMInternalSetGraphicsBufferNativeData_GraphicsBuffer_IntPtr_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MInternalSetGraphicsBufferNativeData_GraphicsBuffer_IntPtr_Int32_Int32_Int32_Int32 == null)
				{
					r_MInternalSetGraphicsBufferNativeData_GraphicsBuffer_IntPtr_Int32_Int32_Int32_Int32 = new(this, "InternalSetGraphicsBufferNativeData", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MInternalSetGraphicsBufferNativeData_GraphicsBuffer_IntPtr_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void InternalSetGraphicsBufferData(UnityEngine.GraphicsBuffer, System.Array, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MInternalSetGraphicsBufferData_GraphicsBuffer_Array_Int32_Int32_Int32_Int32;
		public virtual RMethod RMInternalSetGraphicsBufferData_GraphicsBuffer_Array_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MInternalSetGraphicsBufferData_GraphicsBuffer_Array_Int32_Int32_Int32_Int32 == null)
				{
					r_MInternalSetGraphicsBufferData_GraphicsBuffer_Array_Int32_Int32_Int32_Int32 = new(this, "InternalSetGraphicsBufferData", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MInternalSetGraphicsBufferData_GraphicsBuffer_Array_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void InternalSetGraphicsBufferCounterValue(UnityEngine.GraphicsBuffer, UInt32)
		/// </summary>
		protected RMethod r_MInternalSetGraphicsBufferCounterValue_GraphicsBuffer_UInt32;
		public virtual RMethod RMInternalSetGraphicsBufferCounterValue_GraphicsBuffer_UInt32
		{
			get
			{
				if(r_MInternalSetGraphicsBufferCounterValue_GraphicsBuffer_UInt32 == null)
				{
					r_MInternalSetGraphicsBufferCounterValue_GraphicsBuffer_UInt32 = new(this, "InternalSetGraphicsBufferCounterValue", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32));
				}
				return r_MInternalSetGraphicsBufferCounterValue_GraphicsBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void CopyBufferImpl(UnityEngine.GraphicsBuffer, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_MCopyBufferImpl_GraphicsBuffer_GraphicsBuffer;
		public virtual RMethod RMCopyBufferImpl_GraphicsBuffer_GraphicsBuffer
		{
			get
			{
				if(r_MCopyBufferImpl_GraphicsBuffer_GraphicsBuffer == null)
				{
					r_MCopyBufferImpl_GraphicsBuffer_GraphicsBuffer = new(this, "CopyBufferImpl", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.GraphicsBuffer));
				}
				return r_MCopyBufferImpl_GraphicsBuffer_GraphicsBuffer;
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
				}
				return r_MDispose_Boolean;
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
				}
				return r_MRelease;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.GraphicsFence CreateAsyncGraphicsFence()
		/// </summary>
		protected RMethod r_MCreateAsyncGraphicsFence;
		public virtual RMethod RMCreateAsyncGraphicsFence
		{
			get
			{
				if(r_MCreateAsyncGraphicsFence == null)
				{
					r_MCreateAsyncGraphicsFence = new(this, "CreateAsyncGraphicsFence", 0);
				}
				return r_MCreateAsyncGraphicsFence;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.GraphicsFence CreateAsyncGraphicsFence(UnityEngine.Rendering.SynchronisationStage)
		/// </summary>
		protected RMethod r_MCreateAsyncGraphicsFence_SynchronisationStage;
		public virtual RMethod RMCreateAsyncGraphicsFence_SynchronisationStage
		{
			get
			{
				if(r_MCreateAsyncGraphicsFence_SynchronisationStage == null)
				{
					r_MCreateAsyncGraphicsFence_SynchronisationStage = new(this, "CreateAsyncGraphicsFence", 0, typeof(UnityEngine.Rendering.SynchronisationStage));
				}
				return r_MCreateAsyncGraphicsFence_SynchronisationStage;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.GraphicsFence CreateGraphicsFence(UnityEngine.Rendering.GraphicsFenceType, UnityEngine.Rendering.SynchronisationStageFlags)
		/// </summary>
		protected RMethod r_MCreateGraphicsFence_GraphicsFenceType_SynchronisationStageFlags;
		public virtual RMethod RMCreateGraphicsFence_GraphicsFenceType_SynchronisationStageFlags
		{
			get
			{
				if(r_MCreateGraphicsFence_GraphicsFenceType_SynchronisationStageFlags == null)
				{
					r_MCreateGraphicsFence_GraphicsFenceType_SynchronisationStageFlags = new(this, "CreateGraphicsFence", 0, typeof(UnityEngine.Rendering.GraphicsFenceType), typeof(UnityEngine.Rendering.SynchronisationStageFlags));
				}
				return r_MCreateGraphicsFence_GraphicsFenceType_SynchronisationStageFlags;
			}
		}

		/// <summary>
		/// Void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence)
		/// </summary>
		protected RMethod r_MWaitOnAsyncGraphicsFence_GraphicsFence;
		public virtual RMethod RMWaitOnAsyncGraphicsFence_GraphicsFence
		{
			get
			{
				if(r_MWaitOnAsyncGraphicsFence_GraphicsFence == null)
				{
					r_MWaitOnAsyncGraphicsFence_GraphicsFence = new(this, "WaitOnAsyncGraphicsFence", 0, typeof(UnityEngine.Rendering.GraphicsFence));
				}
				return r_MWaitOnAsyncGraphicsFence_GraphicsFence;
			}
		}

		/// <summary>
		/// Void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence, UnityEngine.Rendering.SynchronisationStage)
		/// </summary>
		protected RMethod r_MWaitOnAsyncGraphicsFence_GraphicsFence_SynchronisationStage;
		public virtual RMethod RMWaitOnAsyncGraphicsFence_GraphicsFence_SynchronisationStage
		{
			get
			{
				if(r_MWaitOnAsyncGraphicsFence_GraphicsFence_SynchronisationStage == null)
				{
					r_MWaitOnAsyncGraphicsFence_GraphicsFence_SynchronisationStage = new(this, "WaitOnAsyncGraphicsFence", 0, typeof(UnityEngine.Rendering.GraphicsFence), typeof(UnityEngine.Rendering.SynchronisationStage));
				}
				return r_MWaitOnAsyncGraphicsFence_GraphicsFence_SynchronisationStage;
			}
		}

		/// <summary>
		/// Void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence, UnityEngine.Rendering.SynchronisationStageFlags)
		/// </summary>
		protected RMethod r_MWaitOnAsyncGraphicsFence_GraphicsFence_SynchronisationStageFlags;
		public virtual RMethod RMWaitOnAsyncGraphicsFence_GraphicsFence_SynchronisationStageFlags
		{
			get
			{
				if(r_MWaitOnAsyncGraphicsFence_GraphicsFence_SynchronisationStageFlags == null)
				{
					r_MWaitOnAsyncGraphicsFence_GraphicsFence_SynchronisationStageFlags = new(this, "WaitOnAsyncGraphicsFence", 0, typeof(UnityEngine.Rendering.GraphicsFence), typeof(UnityEngine.Rendering.SynchronisationStageFlags));
				}
				return r_MWaitOnAsyncGraphicsFence_GraphicsFence_SynchronisationStageFlags;
			}
		}

		/// <summary>
		/// Void SetComputeFloatParam(UnityEngine.ComputeShader, System.String, Single)
		/// </summary>
		protected RMethod r_MSetComputeFloatParam_ComputeShader_String_Single;
		public virtual RMethod RMSetComputeFloatParam_ComputeShader_String_Single
		{
			get
			{
				if(r_MSetComputeFloatParam_ComputeShader_String_Single == null)
				{
					r_MSetComputeFloatParam_ComputeShader_String_Single = new(this, "SetComputeFloatParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.String), typeof(System.Single));
				}
				return r_MSetComputeFloatParam_ComputeShader_String_Single;
			}
		}

		/// <summary>
		/// Void SetComputeIntParam(UnityEngine.ComputeShader, System.String, Int32)
		/// </summary>
		protected RMethod r_MSetComputeIntParam_ComputeShader_String_Int32;
		public virtual RMethod RMSetComputeIntParam_ComputeShader_String_Int32
		{
			get
			{
				if(r_MSetComputeIntParam_ComputeShader_String_Int32 == null)
				{
					r_MSetComputeIntParam_ComputeShader_String_Int32 = new(this, "SetComputeIntParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.String), typeof(System.Int32));
				}
				return r_MSetComputeIntParam_ComputeShader_String_Int32;
			}
		}

		/// <summary>
		/// Void SetComputeVectorParam(UnityEngine.ComputeShader, System.String, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_MSetComputeVectorParam_ComputeShader_String_Vector4;
		public virtual RMethod RMSetComputeVectorParam_ComputeShader_String_Vector4
		{
			get
			{
				if(r_MSetComputeVectorParam_ComputeShader_String_Vector4 == null)
				{
					r_MSetComputeVectorParam_ComputeShader_String_Vector4 = new(this, "SetComputeVectorParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.String), typeof(UnityEngine.Vector4));
				}
				return r_MSetComputeVectorParam_ComputeShader_String_Vector4;
			}
		}

		/// <summary>
		/// Void SetComputeVectorArrayParam(UnityEngine.ComputeShader, System.String, UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_MSetComputeVectorArrayParam_ComputeShader_String_Vector4Array;
		public virtual RMethod RMSetComputeVectorArrayParam_ComputeShader_String_Vector4Array
		{
			get
			{
				if(r_MSetComputeVectorArrayParam_ComputeShader_String_Vector4Array == null)
				{
					r_MSetComputeVectorArrayParam_ComputeShader_String_Vector4Array = new(this, "SetComputeVectorArrayParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.String), typeof(UnityEngine.Vector4).MakeArrayType());
				}
				return r_MSetComputeVectorArrayParam_ComputeShader_String_Vector4Array;
			}
		}

		/// <summary>
		/// Void SetComputeMatrixParam(UnityEngine.ComputeShader, System.String, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_MSetComputeMatrixParam_ComputeShader_String_Matrix4x4;
		public virtual RMethod RMSetComputeMatrixParam_ComputeShader_String_Matrix4x4
		{
			get
			{
				if(r_MSetComputeMatrixParam_ComputeShader_String_Matrix4x4 == null)
				{
					r_MSetComputeMatrixParam_ComputeShader_String_Matrix4x4 = new(this, "SetComputeMatrixParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.String), typeof(UnityEngine.Matrix4x4));
				}
				return r_MSetComputeMatrixParam_ComputeShader_String_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetComputeMatrixArrayParam(UnityEngine.ComputeShader, System.String, UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_MSetComputeMatrixArrayParam_ComputeShader_String_Matrix4x4Array;
		public virtual RMethod RMSetComputeMatrixArrayParam_ComputeShader_String_Matrix4x4Array
		{
			get
			{
				if(r_MSetComputeMatrixArrayParam_ComputeShader_String_Matrix4x4Array == null)
				{
					r_MSetComputeMatrixArrayParam_ComputeShader_String_Matrix4x4Array = new(this, "SetComputeMatrixArrayParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.String), typeof(UnityEngine.Matrix4x4).MakeArrayType());
				}
				return r_MSetComputeMatrixArrayParam_ComputeShader_String_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Void SetComputeFloatParams(UnityEngine.ComputeShader, System.String, Single[])
		/// </summary>
		protected RMethod r_MSetComputeFloatParams_ComputeShader_String_SingleArray;
		public virtual RMethod RMSetComputeFloatParams_ComputeShader_String_SingleArray
		{
			get
			{
				if(r_MSetComputeFloatParams_ComputeShader_String_SingleArray == null)
				{
					r_MSetComputeFloatParams_ComputeShader_String_SingleArray = new(this, "SetComputeFloatParams", 0, typeof(UnityEngine.ComputeShader), typeof(System.String), typeof(System.Single).MakeArrayType());
				}
				return r_MSetComputeFloatParams_ComputeShader_String_SingleArray;
			}
		}

		/// <summary>
		/// Void SetComputeFloatParams(UnityEngine.ComputeShader, Int32, Single[])
		/// </summary>
		protected RMethod r_MSetComputeFloatParams_ComputeShader_Int32_SingleArray;
		public virtual RMethod RMSetComputeFloatParams_ComputeShader_Int32_SingleArray
		{
			get
			{
				if(r_MSetComputeFloatParams_ComputeShader_Int32_SingleArray == null)
				{
					r_MSetComputeFloatParams_ComputeShader_Int32_SingleArray = new(this, "SetComputeFloatParams", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Single).MakeArrayType());
				}
				return r_MSetComputeFloatParams_ComputeShader_Int32_SingleArray;
			}
		}

		/// <summary>
		/// Void SetComputeIntParams(UnityEngine.ComputeShader, System.String, Int32[])
		/// </summary>
		protected RMethod r_MSetComputeIntParams_ComputeShader_String_Int32Array;
		public virtual RMethod RMSetComputeIntParams_ComputeShader_String_Int32Array
		{
			get
			{
				if(r_MSetComputeIntParams_ComputeShader_String_Int32Array == null)
				{
					r_MSetComputeIntParams_ComputeShader_String_Int32Array = new(this, "SetComputeIntParams", 0, typeof(UnityEngine.ComputeShader), typeof(System.String), typeof(System.Int32).MakeArrayType());
				}
				return r_MSetComputeIntParams_ComputeShader_String_Int32Array;
			}
		}

		/// <summary>
		/// Void SetComputeIntParams(UnityEngine.ComputeShader, Int32, Int32[])
		/// </summary>
		protected RMethod r_MSetComputeIntParams_ComputeShader_Int32_Int32Array;
		public virtual RMethod RMSetComputeIntParams_ComputeShader_Int32_Int32Array
		{
			get
			{
				if(r_MSetComputeIntParams_ComputeShader_Int32_Int32Array == null)
				{
					r_MSetComputeIntParams_ComputeShader_Int32_Int32Array = new(this, "SetComputeIntParams", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Int32).MakeArrayType());
				}
				return r_MSetComputeIntParams_ComputeShader_Int32_Int32Array;
			}
		}

		/// <summary>
		/// Void SetComputeTextureParam(UnityEngine.ComputeShader, Int32, System.String, UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_MSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier;
		public virtual RMethod RMSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier
		{
			get
			{
				if(r_MSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier == null)
				{
					r_MSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier = new(this, "SetComputeTextureParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.String), typeof(UnityEngine.Rendering.RenderTargetIdentifier));
				}
				return r_MSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void SetComputeTextureParam(UnityEngine.ComputeShader, Int32, Int32, UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_MSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier;
		public virtual RMethod RMSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier
		{
			get
			{
				if(r_MSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier == null)
				{
					r_MSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier = new(this, "SetComputeTextureParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier));
				}
				return r_MSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void SetComputeTextureParam(UnityEngine.ComputeShader, Int32, System.String, UnityEngine.Rendering.RenderTargetIdentifier, Int32)
		/// </summary>
		protected RMethod r_MSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier_Int32;
		public virtual RMethod RMSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier_Int32
		{
			get
			{
				if(r_MSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier_Int32 == null)
				{
					r_MSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier_Int32 = new(this, "SetComputeTextureParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.String), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32));
				}
				return r_MSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier_Int32;
			}
		}

		/// <summary>
		/// Void SetComputeTextureParam(UnityEngine.ComputeShader, Int32, Int32, UnityEngine.Rendering.RenderTargetIdentifier, Int32)
		/// </summary>
		protected RMethod r_MSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier_Int32;
		public virtual RMethod RMSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier_Int32
		{
			get
			{
				if(r_MSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier_Int32 == null)
				{
					r_MSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier_Int32 = new(this, "SetComputeTextureParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32));
				}
				return r_MSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier_Int32;
			}
		}

		/// <summary>
		/// Void SetComputeTextureParam(UnityEngine.ComputeShader, Int32, System.String, UnityEngine.Rendering.RenderTargetIdentifier, Int32, UnityEngine.Rendering.RenderTextureSubElement)
		/// </summary>
		protected RMethod r_MSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier_Int32_RenderTextureSubElement;
		public virtual RMethod RMSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier_Int32_RenderTextureSubElement
		{
			get
			{
				if(r_MSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier_Int32_RenderTextureSubElement == null)
				{
					r_MSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier_Int32_RenderTextureSubElement = new(this, "SetComputeTextureParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.String), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTextureSubElement));
				}
				return r_MSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier_Int32_RenderTextureSubElement;
			}
		}

		/// <summary>
		/// Void SetComputeTextureParam(UnityEngine.ComputeShader, Int32, Int32, UnityEngine.Rendering.RenderTargetIdentifier, Int32, UnityEngine.Rendering.RenderTextureSubElement)
		/// </summary>
		protected RMethod r_MSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier_Int32_RenderTextureSubElement;
		public virtual RMethod RMSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier_Int32_RenderTextureSubElement
		{
			get
			{
				if(r_MSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier_Int32_RenderTextureSubElement == null)
				{
					r_MSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier_Int32_RenderTextureSubElement = new(this, "SetComputeTextureParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTextureSubElement));
				}
				return r_MSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier_Int32_RenderTextureSubElement;
			}
		}

		/// <summary>
		/// Void SetComputeBufferParam(UnityEngine.ComputeShader, Int32, Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_MSetComputeBufferParam_ComputeShader_Int32_Int32_ComputeBuffer;
		public virtual RMethod RMSetComputeBufferParam_ComputeShader_Int32_Int32_ComputeBuffer
		{
			get
			{
				if(r_MSetComputeBufferParam_ComputeShader_Int32_Int32_ComputeBuffer == null)
				{
					r_MSetComputeBufferParam_ComputeShader_Int32_Int32_ComputeBuffer = new(this, "SetComputeBufferParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
				}
				return r_MSetComputeBufferParam_ComputeShader_Int32_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetComputeBufferParam(UnityEngine.ComputeShader, Int32, System.String, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_MSetComputeBufferParam_ComputeShader_Int32_String_ComputeBuffer;
		public virtual RMethod RMSetComputeBufferParam_ComputeShader_Int32_String_ComputeBuffer
		{
			get
			{
				if(r_MSetComputeBufferParam_ComputeShader_Int32_String_ComputeBuffer == null)
				{
					r_MSetComputeBufferParam_ComputeShader_Int32_String_ComputeBuffer = new(this, "SetComputeBufferParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.String), typeof(UnityEngine.ComputeBuffer));
				}
				return r_MSetComputeBufferParam_ComputeShader_Int32_String_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetComputeBufferParam(UnityEngine.ComputeShader, Int32, Int32, UnityEngine.GraphicsBufferHandle)
		/// </summary>
		protected RMethod r_MSetComputeBufferParam_ComputeShader_Int32_Int32_GraphicsBufferHandle;
		public virtual RMethod RMSetComputeBufferParam_ComputeShader_Int32_Int32_GraphicsBufferHandle
		{
			get
			{
				if(r_MSetComputeBufferParam_ComputeShader_Int32_Int32_GraphicsBufferHandle == null)
				{
					r_MSetComputeBufferParam_ComputeShader_Int32_Int32_GraphicsBufferHandle = new(this, "SetComputeBufferParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.GraphicsBufferHandle));
				}
				return r_MSetComputeBufferParam_ComputeShader_Int32_Int32_GraphicsBufferHandle;
			}
		}

		/// <summary>
		/// Void SetComputeBufferParam(UnityEngine.ComputeShader, Int32, System.String, UnityEngine.GraphicsBufferHandle)
		/// </summary>
		protected RMethod r_MSetComputeBufferParam_ComputeShader_Int32_String_GraphicsBufferHandle;
		public virtual RMethod RMSetComputeBufferParam_ComputeShader_Int32_String_GraphicsBufferHandle
		{
			get
			{
				if(r_MSetComputeBufferParam_ComputeShader_Int32_String_GraphicsBufferHandle == null)
				{
					r_MSetComputeBufferParam_ComputeShader_Int32_String_GraphicsBufferHandle = new(this, "SetComputeBufferParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.String), typeof(UnityEngine.GraphicsBufferHandle));
				}
				return r_MSetComputeBufferParam_ComputeShader_Int32_String_GraphicsBufferHandle;
			}
		}

		/// <summary>
		/// Void SetComputeBufferParam(UnityEngine.ComputeShader, Int32, Int32, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_MSetComputeBufferParam_ComputeShader_Int32_Int32_GraphicsBuffer;
		public virtual RMethod RMSetComputeBufferParam_ComputeShader_Int32_Int32_GraphicsBuffer
		{
			get
			{
				if(r_MSetComputeBufferParam_ComputeShader_Int32_Int32_GraphicsBuffer == null)
				{
					r_MSetComputeBufferParam_ComputeShader_Int32_Int32_GraphicsBuffer = new(this, "SetComputeBufferParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer));
				}
				return r_MSetComputeBufferParam_ComputeShader_Int32_Int32_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetComputeBufferParam(UnityEngine.ComputeShader, Int32, System.String, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_MSetComputeBufferParam_ComputeShader_Int32_String_GraphicsBuffer;
		public virtual RMethod RMSetComputeBufferParam_ComputeShader_Int32_String_GraphicsBuffer
		{
			get
			{
				if(r_MSetComputeBufferParam_ComputeShader_Int32_String_GraphicsBuffer == null)
				{
					r_MSetComputeBufferParam_ComputeShader_Int32_String_GraphicsBuffer = new(this, "SetComputeBufferParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.String), typeof(UnityEngine.GraphicsBuffer));
				}
				return r_MSetComputeBufferParam_ComputeShader_Int32_String_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetComputeConstantBufferParam(UnityEngine.ComputeShader, Int32, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetComputeConstantBufferParam_ComputeShader_Int32_ComputeBuffer_Int32_Int32;
		public virtual RMethod RMSetComputeConstantBufferParam_ComputeShader_Int32_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_MSetComputeConstantBufferParam_ComputeShader_Int32_ComputeBuffer_Int32_Int32 == null)
				{
					r_MSetComputeConstantBufferParam_ComputeShader_Int32_ComputeBuffer_Int32_Int32 = new(this, "SetComputeConstantBufferParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetComputeConstantBufferParam_ComputeShader_Int32_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetComputeConstantBufferParam(UnityEngine.ComputeShader, System.String, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetComputeConstantBufferParam_ComputeShader_String_ComputeBuffer_Int32_Int32;
		public virtual RMethod RMSetComputeConstantBufferParam_ComputeShader_String_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_MSetComputeConstantBufferParam_ComputeShader_String_ComputeBuffer_Int32_Int32 == null)
				{
					r_MSetComputeConstantBufferParam_ComputeShader_String_ComputeBuffer_Int32_Int32 = new(this, "SetComputeConstantBufferParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.String), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetComputeConstantBufferParam_ComputeShader_String_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetComputeConstantBufferParam(UnityEngine.ComputeShader, Int32, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetComputeConstantBufferParam_ComputeShader_Int32_GraphicsBuffer_Int32_Int32;
		public virtual RMethod RMSetComputeConstantBufferParam_ComputeShader_Int32_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_MSetComputeConstantBufferParam_ComputeShader_Int32_GraphicsBuffer_Int32_Int32 == null)
				{
					r_MSetComputeConstantBufferParam_ComputeShader_Int32_GraphicsBuffer_Int32_Int32 = new(this, "SetComputeConstantBufferParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetComputeConstantBufferParam_ComputeShader_Int32_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetComputeConstantBufferParam(UnityEngine.ComputeShader, System.String, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetComputeConstantBufferParam_ComputeShader_String_GraphicsBuffer_Int32_Int32;
		public virtual RMethod RMSetComputeConstantBufferParam_ComputeShader_String_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_MSetComputeConstantBufferParam_ComputeShader_String_GraphicsBuffer_Int32_Int32 == null)
				{
					r_MSetComputeConstantBufferParam_ComputeShader_String_GraphicsBuffer_Int32_Int32 = new(this, "SetComputeConstantBufferParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.String), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetComputeConstantBufferParam_ComputeShader_String_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetComputeParamsFromMaterial(UnityEngine.ComputeShader, Int32, UnityEngine.Material)
		/// </summary>
		protected RMethod r_MSetComputeParamsFromMaterial_ComputeShader_Int32_Material;
		public virtual RMethod RMSetComputeParamsFromMaterial_ComputeShader_Int32_Material
		{
			get
			{
				if(r_MSetComputeParamsFromMaterial_ComputeShader_Int32_Material == null)
				{
					r_MSetComputeParamsFromMaterial_ComputeShader_Int32_Material = new(this, "SetComputeParamsFromMaterial", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(UnityEngine.Material));
				}
				return r_MSetComputeParamsFromMaterial_ComputeShader_Int32_Material;
			}
		}

		/// <summary>
		/// Void DispatchCompute(UnityEngine.ComputeShader, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MDispatchCompute_ComputeShader_Int32_Int32_Int32_Int32;
		public virtual RMethod RMDispatchCompute_ComputeShader_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MDispatchCompute_ComputeShader_Int32_Int32_Int32_Int32 == null)
				{
					r_MDispatchCompute_ComputeShader_Int32_Int32_Int32_Int32 = new(this, "DispatchCompute", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MDispatchCompute_ComputeShader_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void DispatchCompute(UnityEngine.ComputeShader, Int32, UnityEngine.ComputeBuffer, UInt32)
		/// </summary>
		protected RMethod r_MDispatchCompute_ComputeShader_Int32_ComputeBuffer_UInt32;
		public virtual RMethod RMDispatchCompute_ComputeShader_Int32_ComputeBuffer_UInt32
		{
			get
			{
				if(r_MDispatchCompute_ComputeShader_Int32_ComputeBuffer_UInt32 == null)
				{
					r_MDispatchCompute_ComputeShader_Int32_ComputeBuffer_UInt32 = new(this, "DispatchCompute", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.UInt32));
				}
				return r_MDispatchCompute_ComputeShader_Int32_ComputeBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void DispatchCompute(UnityEngine.ComputeShader, Int32, UnityEngine.GraphicsBuffer, UInt32)
		/// </summary>
		protected RMethod r_MDispatchCompute_ComputeShader_Int32_GraphicsBuffer_UInt32;
		public virtual RMethod RMDispatchCompute_ComputeShader_Int32_GraphicsBuffer_UInt32
		{
			get
			{
				if(r_MDispatchCompute_ComputeShader_Int32_GraphicsBuffer_UInt32 == null)
				{
					r_MDispatchCompute_ComputeShader_Int32_GraphicsBuffer_UInt32 = new(this, "DispatchCompute", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32));
				}
				return r_MDispatchCompute_ComputeShader_Int32_GraphicsBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void BuildRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure)
		/// </summary>
		protected RMethod r_MBuildRayTracingAccelerationStructure_RayTracingAccelerationStructure;
		public virtual RMethod RMBuildRayTracingAccelerationStructure_RayTracingAccelerationStructure
		{
			get
			{
				if(r_MBuildRayTracingAccelerationStructure_RayTracingAccelerationStructure == null)
				{
					r_MBuildRayTracingAccelerationStructure_RayTracingAccelerationStructure = new(this, "BuildRayTracingAccelerationStructure", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure));
				}
				return r_MBuildRayTracingAccelerationStructure_RayTracingAccelerationStructure;
			}
		}

		/// <summary>
		/// Void BuildRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure, UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MBuildRayTracingAccelerationStructure_RayTracingAccelerationStructure_Vector3;
		public virtual RMethod RMBuildRayTracingAccelerationStructure_RayTracingAccelerationStructure_Vector3
		{
			get
			{
				if(r_MBuildRayTracingAccelerationStructure_RayTracingAccelerationStructure_Vector3 == null)
				{
					r_MBuildRayTracingAccelerationStructure_RayTracingAccelerationStructure_Vector3 = new(this, "BuildRayTracingAccelerationStructure", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure), typeof(UnityEngine.Vector3));
				}
				return r_MBuildRayTracingAccelerationStructure_RayTracingAccelerationStructure_Vector3;
			}
		}

		/// <summary>
		/// Void SetRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingShader, System.String, UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure)
		/// </summary>
		protected RMethod r_MSetRayTracingAccelerationStructure_RayTracingShader_String_RayTracingAccelerationStructure;
		public virtual RMethod RMSetRayTracingAccelerationStructure_RayTracingShader_String_RayTracingAccelerationStructure
		{
			get
			{
				if(r_MSetRayTracingAccelerationStructure_RayTracingShader_String_RayTracingAccelerationStructure == null)
				{
					r_MSetRayTracingAccelerationStructure_RayTracingShader_String_RayTracingAccelerationStructure = new(this, "SetRayTracingAccelerationStructure", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.String), typeof(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure));
				}
				return r_MSetRayTracingAccelerationStructure_RayTracingShader_String_RayTracingAccelerationStructure;
			}
		}

		/// <summary>
		/// Void SetRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure)
		/// </summary>
		protected RMethod r_MSetRayTracingAccelerationStructure_RayTracingShader_Int32_RayTracingAccelerationStructure;
		public virtual RMethod RMSetRayTracingAccelerationStructure_RayTracingShader_Int32_RayTracingAccelerationStructure
		{
			get
			{
				if(r_MSetRayTracingAccelerationStructure_RayTracingShader_Int32_RayTracingAccelerationStructure == null)
				{
					r_MSetRayTracingAccelerationStructure_RayTracingShader_Int32_RayTracingAccelerationStructure = new(this, "SetRayTracingAccelerationStructure", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure));
				}
				return r_MSetRayTracingAccelerationStructure_RayTracingShader_Int32_RayTracingAccelerationStructure;
			}
		}

		/// <summary>
		/// Void SetRayTracingBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader, System.String, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_MSetRayTracingBufferParam_RayTracingShader_String_ComputeBuffer;
		public virtual RMethod RMSetRayTracingBufferParam_RayTracingShader_String_ComputeBuffer
		{
			get
			{
				if(r_MSetRayTracingBufferParam_RayTracingShader_String_ComputeBuffer == null)
				{
					r_MSetRayTracingBufferParam_RayTracingShader_String_ComputeBuffer = new(this, "SetRayTracingBufferParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.String), typeof(UnityEngine.ComputeBuffer));
				}
				return r_MSetRayTracingBufferParam_RayTracingShader_String_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetRayTracingBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_MSetRayTracingBufferParam_RayTracingShader_Int32_ComputeBuffer;
		public virtual RMethod RMSetRayTracingBufferParam_RayTracingShader_Int32_ComputeBuffer
		{
			get
			{
				if(r_MSetRayTracingBufferParam_RayTracingShader_Int32_ComputeBuffer == null)
				{
					r_MSetRayTracingBufferParam_RayTracingShader_Int32_ComputeBuffer = new(this, "SetRayTracingBufferParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
				}
				return r_MSetRayTracingBufferParam_RayTracingShader_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetRayTracingConstantBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetRayTracingConstantBufferParam_RayTracingShader_Int32_ComputeBuffer_Int32_Int32;
		public virtual RMethod RMSetRayTracingConstantBufferParam_RayTracingShader_Int32_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_MSetRayTracingConstantBufferParam_RayTracingShader_Int32_ComputeBuffer_Int32_Int32 == null)
				{
					r_MSetRayTracingConstantBufferParam_RayTracingShader_Int32_ComputeBuffer_Int32_Int32 = new(this, "SetRayTracingConstantBufferParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetRayTracingConstantBufferParam_RayTracingShader_Int32_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetRayTracingConstantBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader, System.String, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetRayTracingConstantBufferParam_RayTracingShader_String_ComputeBuffer_Int32_Int32;
		public virtual RMethod RMSetRayTracingConstantBufferParam_RayTracingShader_String_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_MSetRayTracingConstantBufferParam_RayTracingShader_String_ComputeBuffer_Int32_Int32 == null)
				{
					r_MSetRayTracingConstantBufferParam_RayTracingShader_String_ComputeBuffer_Int32_Int32 = new(this, "SetRayTracingConstantBufferParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.String), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetRayTracingConstantBufferParam_RayTracingShader_String_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetRayTracingConstantBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetRayTracingConstantBufferParam_RayTracingShader_Int32_GraphicsBuffer_Int32_Int32;
		public virtual RMethod RMSetRayTracingConstantBufferParam_RayTracingShader_Int32_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_MSetRayTracingConstantBufferParam_RayTracingShader_Int32_GraphicsBuffer_Int32_Int32 == null)
				{
					r_MSetRayTracingConstantBufferParam_RayTracingShader_Int32_GraphicsBuffer_Int32_Int32 = new(this, "SetRayTracingConstantBufferParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetRayTracingConstantBufferParam_RayTracingShader_Int32_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetRayTracingConstantBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader, System.String, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetRayTracingConstantBufferParam_RayTracingShader_String_GraphicsBuffer_Int32_Int32;
		public virtual RMethod RMSetRayTracingConstantBufferParam_RayTracingShader_String_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_MSetRayTracingConstantBufferParam_RayTracingShader_String_GraphicsBuffer_Int32_Int32 == null)
				{
					r_MSetRayTracingConstantBufferParam_RayTracingShader_String_GraphicsBuffer_Int32_Int32 = new(this, "SetRayTracingConstantBufferParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.String), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetRayTracingConstantBufferParam_RayTracingShader_String_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetRayTracingTextureParam(UnityEngine.Experimental.Rendering.RayTracingShader, System.String, UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_MSetRayTracingTextureParam_RayTracingShader_String_RenderTargetIdentifier;
		public virtual RMethod RMSetRayTracingTextureParam_RayTracingShader_String_RenderTargetIdentifier
		{
			get
			{
				if(r_MSetRayTracingTextureParam_RayTracingShader_String_RenderTargetIdentifier == null)
				{
					r_MSetRayTracingTextureParam_RayTracingShader_String_RenderTargetIdentifier = new(this, "SetRayTracingTextureParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.String), typeof(UnityEngine.Rendering.RenderTargetIdentifier));
				}
				return r_MSetRayTracingTextureParam_RayTracingShader_String_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void SetRayTracingTextureParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_MSetRayTracingTextureParam_RayTracingShader_Int32_RenderTargetIdentifier;
		public virtual RMethod RMSetRayTracingTextureParam_RayTracingShader_Int32_RenderTargetIdentifier
		{
			get
			{
				if(r_MSetRayTracingTextureParam_RayTracingShader_Int32_RenderTargetIdentifier == null)
				{
					r_MSetRayTracingTextureParam_RayTracingShader_Int32_RenderTargetIdentifier = new(this, "SetRayTracingTextureParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier));
				}
				return r_MSetRayTracingTextureParam_RayTracingShader_Int32_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void SetRayTracingFloatParam(UnityEngine.Experimental.Rendering.RayTracingShader, System.String, Single)
		/// </summary>
		protected RMethod r_MSetRayTracingFloatParam_RayTracingShader_String_Single;
		public virtual RMethod RMSetRayTracingFloatParam_RayTracingShader_String_Single
		{
			get
			{
				if(r_MSetRayTracingFloatParam_RayTracingShader_String_Single == null)
				{
					r_MSetRayTracingFloatParam_RayTracingShader_String_Single = new(this, "SetRayTracingFloatParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.String), typeof(System.Single));
				}
				return r_MSetRayTracingFloatParam_RayTracingShader_String_Single;
			}
		}

		/// <summary>
		/// Void SetRayTracingFloatParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, Single)
		/// </summary>
		protected RMethod r_MSetRayTracingFloatParam_RayTracingShader_Int32_Single;
		public virtual RMethod RMSetRayTracingFloatParam_RayTracingShader_Int32_Single
		{
			get
			{
				if(r_MSetRayTracingFloatParam_RayTracingShader_Int32_Single == null)
				{
					r_MSetRayTracingFloatParam_RayTracingShader_Int32_Single = new(this, "SetRayTracingFloatParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(System.Single));
				}
				return r_MSetRayTracingFloatParam_RayTracingShader_Int32_Single;
			}
		}

		/// <summary>
		/// Void SetRayTracingFloatParams(UnityEngine.Experimental.Rendering.RayTracingShader, System.String, Single[])
		/// </summary>
		protected RMethod r_MSetRayTracingFloatParams_RayTracingShader_String_SingleArray;
		public virtual RMethod RMSetRayTracingFloatParams_RayTracingShader_String_SingleArray
		{
			get
			{
				if(r_MSetRayTracingFloatParams_RayTracingShader_String_SingleArray == null)
				{
					r_MSetRayTracingFloatParams_RayTracingShader_String_SingleArray = new(this, "SetRayTracingFloatParams", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.String), typeof(System.Single).MakeArrayType());
				}
				return r_MSetRayTracingFloatParams_RayTracingShader_String_SingleArray;
			}
		}

		/// <summary>
		/// Void SetRayTracingFloatParams(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, Single[])
		/// </summary>
		protected RMethod r_MSetRayTracingFloatParams_RayTracingShader_Int32_SingleArray;
		public virtual RMethod RMSetRayTracingFloatParams_RayTracingShader_Int32_SingleArray
		{
			get
			{
				if(r_MSetRayTracingFloatParams_RayTracingShader_Int32_SingleArray == null)
				{
					r_MSetRayTracingFloatParams_RayTracingShader_Int32_SingleArray = new(this, "SetRayTracingFloatParams", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(System.Single).MakeArrayType());
				}
				return r_MSetRayTracingFloatParams_RayTracingShader_Int32_SingleArray;
			}
		}

		/// <summary>
		/// Void SetRayTracingIntParam(UnityEngine.Experimental.Rendering.RayTracingShader, System.String, Int32)
		/// </summary>
		protected RMethod r_MSetRayTracingIntParam_RayTracingShader_String_Int32;
		public virtual RMethod RMSetRayTracingIntParam_RayTracingShader_String_Int32
		{
			get
			{
				if(r_MSetRayTracingIntParam_RayTracingShader_String_Int32 == null)
				{
					r_MSetRayTracingIntParam_RayTracingShader_String_Int32 = new(this, "SetRayTracingIntParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.String), typeof(System.Int32));
				}
				return r_MSetRayTracingIntParam_RayTracingShader_String_Int32;
			}
		}

		/// <summary>
		/// Void SetRayTracingIntParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetRayTracingIntParam_RayTracingShader_Int32_Int32;
		public virtual RMethod RMSetRayTracingIntParam_RayTracingShader_Int32_Int32
		{
			get
			{
				if(r_MSetRayTracingIntParam_RayTracingShader_Int32_Int32 == null)
				{
					r_MSetRayTracingIntParam_RayTracingShader_Int32_Int32 = new(this, "SetRayTracingIntParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetRayTracingIntParam_RayTracingShader_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetRayTracingIntParams(UnityEngine.Experimental.Rendering.RayTracingShader, System.String, Int32[])
		/// </summary>
		protected RMethod r_MSetRayTracingIntParams_RayTracingShader_String_Int32Array;
		public virtual RMethod RMSetRayTracingIntParams_RayTracingShader_String_Int32Array
		{
			get
			{
				if(r_MSetRayTracingIntParams_RayTracingShader_String_Int32Array == null)
				{
					r_MSetRayTracingIntParams_RayTracingShader_String_Int32Array = new(this, "SetRayTracingIntParams", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.String), typeof(System.Int32).MakeArrayType());
				}
				return r_MSetRayTracingIntParams_RayTracingShader_String_Int32Array;
			}
		}

		/// <summary>
		/// Void SetRayTracingIntParams(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, Int32[])
		/// </summary>
		protected RMethod r_MSetRayTracingIntParams_RayTracingShader_Int32_Int32Array;
		public virtual RMethod RMSetRayTracingIntParams_RayTracingShader_Int32_Int32Array
		{
			get
			{
				if(r_MSetRayTracingIntParams_RayTracingShader_Int32_Int32Array == null)
				{
					r_MSetRayTracingIntParams_RayTracingShader_Int32_Int32Array = new(this, "SetRayTracingIntParams", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(System.Int32).MakeArrayType());
				}
				return r_MSetRayTracingIntParams_RayTracingShader_Int32_Int32Array;
			}
		}

		/// <summary>
		/// Void SetRayTracingVectorParam(UnityEngine.Experimental.Rendering.RayTracingShader, System.String, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_MSetRayTracingVectorParam_RayTracingShader_String_Vector4;
		public virtual RMethod RMSetRayTracingVectorParam_RayTracingShader_String_Vector4
		{
			get
			{
				if(r_MSetRayTracingVectorParam_RayTracingShader_String_Vector4 == null)
				{
					r_MSetRayTracingVectorParam_RayTracingShader_String_Vector4 = new(this, "SetRayTracingVectorParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.String), typeof(UnityEngine.Vector4));
				}
				return r_MSetRayTracingVectorParam_RayTracingShader_String_Vector4;
			}
		}

		/// <summary>
		/// Void SetRayTracingVectorParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_MSetRayTracingVectorParam_RayTracingShader_Int32_Vector4;
		public virtual RMethod RMSetRayTracingVectorParam_RayTracingShader_Int32_Vector4
		{
			get
			{
				if(r_MSetRayTracingVectorParam_RayTracingShader_Int32_Vector4 == null)
				{
					r_MSetRayTracingVectorParam_RayTracingShader_Int32_Vector4 = new(this, "SetRayTracingVectorParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.Vector4));
				}
				return r_MSetRayTracingVectorParam_RayTracingShader_Int32_Vector4;
			}
		}

		/// <summary>
		/// Void SetRayTracingVectorArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader, System.String, UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_MSetRayTracingVectorArrayParam_RayTracingShader_String_Vector4Array;
		public virtual RMethod RMSetRayTracingVectorArrayParam_RayTracingShader_String_Vector4Array
		{
			get
			{
				if(r_MSetRayTracingVectorArrayParam_RayTracingShader_String_Vector4Array == null)
				{
					r_MSetRayTracingVectorArrayParam_RayTracingShader_String_Vector4Array = new(this, "SetRayTracingVectorArrayParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.String), typeof(UnityEngine.Vector4).MakeArrayType());
				}
				return r_MSetRayTracingVectorArrayParam_RayTracingShader_String_Vector4Array;
			}
		}

		/// <summary>
		/// Void SetRayTracingVectorArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_MSetRayTracingVectorArrayParam_RayTracingShader_Int32_Vector4Array;
		public virtual RMethod RMSetRayTracingVectorArrayParam_RayTracingShader_Int32_Vector4Array
		{
			get
			{
				if(r_MSetRayTracingVectorArrayParam_RayTracingShader_Int32_Vector4Array == null)
				{
					r_MSetRayTracingVectorArrayParam_RayTracingShader_Int32_Vector4Array = new(this, "SetRayTracingVectorArrayParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType());
				}
				return r_MSetRayTracingVectorArrayParam_RayTracingShader_Int32_Vector4Array;
			}
		}

		/// <summary>
		/// Void SetRayTracingMatrixParam(UnityEngine.Experimental.Rendering.RayTracingShader, System.String, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_MSetRayTracingMatrixParam_RayTracingShader_String_Matrix4x4;
		public virtual RMethod RMSetRayTracingMatrixParam_RayTracingShader_String_Matrix4x4
		{
			get
			{
				if(r_MSetRayTracingMatrixParam_RayTracingShader_String_Matrix4x4 == null)
				{
					r_MSetRayTracingMatrixParam_RayTracingShader_String_Matrix4x4 = new(this, "SetRayTracingMatrixParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.String), typeof(UnityEngine.Matrix4x4));
				}
				return r_MSetRayTracingMatrixParam_RayTracingShader_String_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetRayTracingMatrixParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_MSetRayTracingMatrixParam_RayTracingShader_Int32_Matrix4x4;
		public virtual RMethod RMSetRayTracingMatrixParam_RayTracingShader_Int32_Matrix4x4
		{
			get
			{
				if(r_MSetRayTracingMatrixParam_RayTracingShader_Int32_Matrix4x4 == null)
				{
					r_MSetRayTracingMatrixParam_RayTracingShader_Int32_Matrix4x4 = new(this, "SetRayTracingMatrixParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.Matrix4x4));
				}
				return r_MSetRayTracingMatrixParam_RayTracingShader_Int32_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetRayTracingMatrixArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader, System.String, UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_MSetRayTracingMatrixArrayParam_RayTracingShader_String_Matrix4x4Array;
		public virtual RMethod RMSetRayTracingMatrixArrayParam_RayTracingShader_String_Matrix4x4Array
		{
			get
			{
				if(r_MSetRayTracingMatrixArrayParam_RayTracingShader_String_Matrix4x4Array == null)
				{
					r_MSetRayTracingMatrixArrayParam_RayTracingShader_String_Matrix4x4Array = new(this, "SetRayTracingMatrixArrayParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.String), typeof(UnityEngine.Matrix4x4).MakeArrayType());
				}
				return r_MSetRayTracingMatrixArrayParam_RayTracingShader_String_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Void SetRayTracingMatrixArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_MSetRayTracingMatrixArrayParam_RayTracingShader_Int32_Matrix4x4Array;
		public virtual RMethod RMSetRayTracingMatrixArrayParam_RayTracingShader_Int32_Matrix4x4Array
		{
			get
			{
				if(r_MSetRayTracingMatrixArrayParam_RayTracingShader_Int32_Matrix4x4Array == null)
				{
					r_MSetRayTracingMatrixArrayParam_RayTracingShader_Int32_Matrix4x4Array = new(this, "SetRayTracingMatrixArrayParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType());
				}
				return r_MSetRayTracingMatrixArrayParam_RayTracingShader_Int32_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Void DispatchRays(UnityEngine.Experimental.Rendering.RayTracingShader, System.String, UInt32, UInt32, UInt32, UnityEngine.Camera)
		/// </summary>
		protected RMethod r_MDispatchRays_RayTracingShader_String_UInt32_UInt32_UInt32_Camera;
		public virtual RMethod RMDispatchRays_RayTracingShader_String_UInt32_UInt32_UInt32_Camera
		{
			get
			{
				if(r_MDispatchRays_RayTracingShader_String_UInt32_UInt32_UInt32_Camera == null)
				{
					r_MDispatchRays_RayTracingShader_String_UInt32_UInt32_UInt32_Camera = new(this, "DispatchRays", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.String), typeof(System.UInt32), typeof(System.UInt32), typeof(System.UInt32), typeof(UnityEngine.Camera));
				}
				return r_MDispatchRays_RayTracingShader_String_UInt32_UInt32_UInt32_Camera;
			}
		}

		/// <summary>
		/// Void GenerateMips(UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_MGenerateMips_RenderTargetIdentifier;
		public virtual RMethod RMGenerateMips_RenderTargetIdentifier
		{
			get
			{
				if(r_MGenerateMips_RenderTargetIdentifier == null)
				{
					r_MGenerateMips_RenderTargetIdentifier = new(this, "GenerateMips", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier));
				}
				return r_MGenerateMips_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void GenerateMips(UnityEngine.RenderTexture)
		/// </summary>
		protected RMethod r_MGenerateMips_RenderTexture;
		public virtual RMethod RMGenerateMips_RenderTexture
		{
			get
			{
				if(r_MGenerateMips_RenderTexture == null)
				{
					r_MGenerateMips_RenderTexture = new(this, "GenerateMips", 0, typeof(UnityEngine.RenderTexture));
				}
				return r_MGenerateMips_RenderTexture;
			}
		}

		/// <summary>
		/// Void ResolveAntiAliasedSurface(UnityEngine.RenderTexture, UnityEngine.RenderTexture)
		/// </summary>
		protected RMethod r_MResolveAntiAliasedSurface_RenderTexture_RenderTexture;
		public virtual RMethod RMResolveAntiAliasedSurface_RenderTexture_RenderTexture
		{
			get
			{
				if(r_MResolveAntiAliasedSurface_RenderTexture_RenderTexture == null)
				{
					r_MResolveAntiAliasedSurface_RenderTexture_RenderTexture = new(this, "ResolveAntiAliasedSurface", 0, typeof(UnityEngine.RenderTexture), typeof(UnityEngine.RenderTexture));
				}
				return r_MResolveAntiAliasedSurface_RenderTexture_RenderTexture;
			}
		}

		/// <summary>
		/// Void DrawMesh(UnityEngine.Mesh, UnityEngine.Matrix4x4, UnityEngine.Material, Int32, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MDrawMesh_Mesh_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock;
		public virtual RMethod RMDrawMesh_Mesh_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_MDrawMesh_Mesh_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock == null)
				{
					r_MDrawMesh_Mesh_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock = new(this, "DrawMesh", 0, typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
				}
				return r_MDrawMesh_Mesh_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void DrawMesh(UnityEngine.Mesh, UnityEngine.Matrix4x4, UnityEngine.Material, Int32, Int32)
		/// </summary>
		protected RMethod r_MDrawMesh_Mesh_Matrix4x4_Material_Int32_Int32;
		public virtual RMethod RMDrawMesh_Mesh_Matrix4x4_Material_Int32_Int32
		{
			get
			{
				if(r_MDrawMesh_Mesh_Matrix4x4_Material_Int32_Int32 == null)
				{
					r_MDrawMesh_Mesh_Matrix4x4_Material_Int32_Int32 = new(this, "DrawMesh", 0, typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MDrawMesh_Mesh_Matrix4x4_Material_Int32_Int32;
			}
		}

		/// <summary>
		/// Void DrawMesh(UnityEngine.Mesh, UnityEngine.Matrix4x4, UnityEngine.Material, Int32)
		/// </summary>
		protected RMethod r_MDrawMesh_Mesh_Matrix4x4_Material_Int32;
		public virtual RMethod RMDrawMesh_Mesh_Matrix4x4_Material_Int32
		{
			get
			{
				if(r_MDrawMesh_Mesh_Matrix4x4_Material_Int32 == null)
				{
					r_MDrawMesh_Mesh_Matrix4x4_Material_Int32 = new(this, "DrawMesh", 0, typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32));
				}
				return r_MDrawMesh_Mesh_Matrix4x4_Material_Int32;
			}
		}

		/// <summary>
		/// Void DrawMesh(UnityEngine.Mesh, UnityEngine.Matrix4x4, UnityEngine.Material)
		/// </summary>
		protected RMethod r_MDrawMesh_Mesh_Matrix4x4_Material;
		public virtual RMethod RMDrawMesh_Mesh_Matrix4x4_Material
		{
			get
			{
				if(r_MDrawMesh_Mesh_Matrix4x4_Material == null)
				{
					r_MDrawMesh_Mesh_Matrix4x4_Material = new(this, "DrawMesh", 0, typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material));
				}
				return r_MDrawMesh_Mesh_Matrix4x4_Material;
			}
		}

		/// <summary>
		/// Void DrawRenderer(UnityEngine.Renderer, UnityEngine.Material, Int32, Int32)
		/// </summary>
		protected RMethod r_MDrawRenderer_Renderer_Material_Int32_Int32;
		public virtual RMethod RMDrawRenderer_Renderer_Material_Int32_Int32
		{
			get
			{
				if(r_MDrawRenderer_Renderer_Material_Int32_Int32 == null)
				{
					r_MDrawRenderer_Renderer_Material_Int32_Int32 = new(this, "DrawRenderer", 0, typeof(UnityEngine.Renderer), typeof(UnityEngine.Material), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MDrawRenderer_Renderer_Material_Int32_Int32;
			}
		}

		/// <summary>
		/// Void DrawRenderer(UnityEngine.Renderer, UnityEngine.Material, Int32)
		/// </summary>
		protected RMethod r_MDrawRenderer_Renderer_Material_Int32;
		public virtual RMethod RMDrawRenderer_Renderer_Material_Int32
		{
			get
			{
				if(r_MDrawRenderer_Renderer_Material_Int32 == null)
				{
					r_MDrawRenderer_Renderer_Material_Int32 = new(this, "DrawRenderer", 0, typeof(UnityEngine.Renderer), typeof(UnityEngine.Material), typeof(System.Int32));
				}
				return r_MDrawRenderer_Renderer_Material_Int32;
			}
		}

		/// <summary>
		/// Void DrawRenderer(UnityEngine.Renderer, UnityEngine.Material)
		/// </summary>
		protected RMethod r_MDrawRenderer_Renderer_Material;
		public virtual RMethod RMDrawRenderer_Renderer_Material
		{
			get
			{
				if(r_MDrawRenderer_Renderer_Material == null)
				{
					r_MDrawRenderer_Renderer_Material = new(this, "DrawRenderer", 0, typeof(UnityEngine.Renderer), typeof(UnityEngine.Material));
				}
				return r_MDrawRenderer_Renderer_Material;
			}
		}

		/// <summary>
		/// Void DrawRendererList(UnityEngine.Rendering.RendererList)
		/// </summary>
		protected RMethod r_MDrawRendererList_RendererList;
		public virtual RMethod RMDrawRendererList_RendererList
		{
			get
			{
				if(r_MDrawRendererList_RendererList == null)
				{
					r_MDrawRendererList_RendererList = new(this, "DrawRendererList", 0, typeof(UnityEngine.Rendering.RendererList));
				}
				return r_MDrawRendererList_RendererList;
			}
		}

		/// <summary>
		/// Void DrawProcedural(UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, Int32, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock;
		public virtual RMethod RMDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_MDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock == null)
				{
					r_MDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock = new(this, "DrawProcedural", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
				}
				return r_MDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void DrawProcedural(UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, Int32, Int32)
		/// </summary>
		protected RMethod r_MDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32;
		public virtual RMethod RMDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32
		{
			get
			{
				if(r_MDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32 == null)
				{
					r_MDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32 = new(this, "DrawProcedural", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32;
			}
		}

		/// <summary>
		/// Void DrawProcedural(UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, Int32)
		/// </summary>
		protected RMethod r_MDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32;
		public virtual RMethod RMDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32
		{
			get
			{
				if(r_MDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32 == null)
				{
					r_MDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32 = new(this, "DrawProcedural", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32));
				}
				return r_MDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32;
			}
		}

		/// <summary>
		/// Void DrawProcedural(UnityEngine.GraphicsBuffer, UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, Int32, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock;
		public virtual RMethod RMDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_MDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock == null)
				{
					r_MDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock = new(this, "DrawProcedural", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
				}
				return r_MDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void DrawProcedural(UnityEngine.GraphicsBuffer, UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, Int32, Int32)
		/// </summary>
		protected RMethod r_MDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32;
		public virtual RMethod RMDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32
		{
			get
			{
				if(r_MDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32 == null)
				{
					r_MDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32 = new(this, "DrawProcedural", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32;
			}
		}

		/// <summary>
		/// Void DrawProcedural(UnityEngine.GraphicsBuffer, UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, Int32)
		/// </summary>
		protected RMethod r_MDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32;
		public virtual RMethod RMDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32
		{
			get
			{
				if(r_MDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32 == null)
				{
					r_MDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32 = new(this, "DrawProcedural", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32));
				}
				return r_MDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32;
			}
		}

		/// <summary>
		/// Void DrawProceduralIndirect(UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.ComputeBuffer, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock;
		public virtual RMethod RMDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_MDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock == null)
				{
					r_MDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock = new(this, "DrawProceduralIndirect", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
				}
				return r_MDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void DrawProceduralIndirect(UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.ComputeBuffer, Int32)
		/// </summary>
		protected RMethod r_MDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32;
		public virtual RMethod RMDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32
		{
			get
			{
				if(r_MDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32 == null)
				{
					r_MDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32 = new(this, "DrawProceduralIndirect", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32));
				}
				return r_MDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32;
			}
		}

		/// <summary>
		/// Void DrawProceduralIndirect(UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_MDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer;
		public virtual RMethod RMDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer
		{
			get
			{
				if(r_MDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer == null)
				{
					r_MDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer = new(this, "DrawProceduralIndirect", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.ComputeBuffer));
				}
				return r_MDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void DrawProceduralIndirect(UnityEngine.GraphicsBuffer, UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.ComputeBuffer, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock;
		public virtual RMethod RMDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_MDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock == null)
				{
					r_MDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock = new(this, "DrawProceduralIndirect", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
				}
				return r_MDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void DrawProceduralIndirect(UnityEngine.GraphicsBuffer, UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.ComputeBuffer, Int32)
		/// </summary>
		protected RMethod r_MDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32;
		public virtual RMethod RMDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32
		{
			get
			{
				if(r_MDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32 == null)
				{
					r_MDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32 = new(this, "DrawProceduralIndirect", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32));
				}
				return r_MDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32;
			}
		}

		/// <summary>
		/// Void DrawProceduralIndirect(UnityEngine.GraphicsBuffer, UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_MDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer;
		public virtual RMethod RMDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer
		{
			get
			{
				if(r_MDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer == null)
				{
					r_MDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer = new(this, "DrawProceduralIndirect", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.ComputeBuffer));
				}
				return r_MDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void DrawProceduralIndirect(UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.GraphicsBuffer, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock;
		public virtual RMethod RMDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_MDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock == null)
				{
					r_MDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock = new(this, "DrawProceduralIndirect", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
				}
				return r_MDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void DrawProceduralIndirect(UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.GraphicsBuffer, Int32)
		/// </summary>
		protected RMethod r_MDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32;
		public virtual RMethod RMDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32
		{
			get
			{
				if(r_MDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32 == null)
				{
					r_MDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32 = new(this, "DrawProceduralIndirect", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32));
				}
				return r_MDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32;
			}
		}

		/// <summary>
		/// Void DrawProceduralIndirect(UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_MDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer;
		public virtual RMethod RMDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer
		{
			get
			{
				if(r_MDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer == null)
				{
					r_MDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer = new(this, "DrawProceduralIndirect", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.GraphicsBuffer));
				}
				return r_MDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void DrawProceduralIndirect(UnityEngine.GraphicsBuffer, UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.GraphicsBuffer, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock;
		public virtual RMethod RMDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_MDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock == null)
				{
					r_MDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock = new(this, "DrawProceduralIndirect", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
				}
				return r_MDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void DrawProceduralIndirect(UnityEngine.GraphicsBuffer, UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.GraphicsBuffer, Int32)
		/// </summary>
		protected RMethod r_MDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32;
		public virtual RMethod RMDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32
		{
			get
			{
				if(r_MDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32 == null)
				{
					r_MDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32 = new(this, "DrawProceduralIndirect", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32));
				}
				return r_MDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32;
			}
		}

		/// <summary>
		/// Void DrawProceduralIndirect(UnityEngine.GraphicsBuffer, UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_MDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer;
		public virtual RMethod RMDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer
		{
			get
			{
				if(r_MDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer == null)
				{
					r_MDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer = new(this, "DrawProceduralIndirect", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.GraphicsBuffer));
				}
				return r_MDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void DrawMeshInstanced(UnityEngine.Mesh, Int32, UnityEngine.Material, Int32, UnityEngine.Matrix4x4[], Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32_MaterialPropertyBlock;
		public virtual RMethod RMDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_MDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32_MaterialPropertyBlock == null)
				{
					r_MDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32_MaterialPropertyBlock = new(this, "DrawMeshInstanced", 0, typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType(), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
				}
				return r_MDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void DrawMeshInstanced(UnityEngine.Mesh, Int32, UnityEngine.Material, Int32, UnityEngine.Matrix4x4[], Int32)
		/// </summary>
		protected RMethod r_MDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32;
		public virtual RMethod RMDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32
		{
			get
			{
				if(r_MDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32 == null)
				{
					r_MDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32 = new(this, "DrawMeshInstanced", 0, typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType(), typeof(System.Int32));
				}
				return r_MDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32;
			}
		}

		/// <summary>
		/// Void DrawMeshInstanced(UnityEngine.Mesh, Int32, UnityEngine.Material, Int32, UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_MDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array;
		public virtual RMethod RMDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array
		{
			get
			{
				if(r_MDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array == null)
				{
					r_MDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array = new(this, "DrawMeshInstanced", 0, typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType());
				}
				return r_MDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Void DrawMeshInstancedProcedural(UnityEngine.Mesh, Int32, UnityEngine.Material, Int32, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MDrawMeshInstancedProcedural_Mesh_Int32_Material_Int32_Int32_MaterialPropertyBlock;
		public virtual RMethod RMDrawMeshInstancedProcedural_Mesh_Int32_Material_Int32_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_MDrawMeshInstancedProcedural_Mesh_Int32_Material_Int32_Int32_MaterialPropertyBlock == null)
				{
					r_MDrawMeshInstancedProcedural_Mesh_Int32_Material_Int32_Int32_MaterialPropertyBlock = new(this, "DrawMeshInstancedProcedural", 0, typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
				}
				return r_MDrawMeshInstancedProcedural_Mesh_Int32_Material_Int32_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void DrawMeshInstancedIndirect(UnityEngine.Mesh, Int32, UnityEngine.Material, Int32, UnityEngine.ComputeBuffer, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32_MaterialPropertyBlock;
		public virtual RMethod RMDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_MDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32_MaterialPropertyBlock == null)
				{
					r_MDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32_MaterialPropertyBlock = new(this, "DrawMeshInstancedIndirect", 0, typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
				}
				return r_MDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void DrawMeshInstancedIndirect(UnityEngine.Mesh, Int32, UnityEngine.Material, Int32, UnityEngine.ComputeBuffer, Int32)
		/// </summary>
		protected RMethod r_MDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32;
		public virtual RMethod RMDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32
		{
			get
			{
				if(r_MDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32 == null)
				{
					r_MDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32 = new(this, "DrawMeshInstancedIndirect", 0, typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32));
				}
				return r_MDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32;
			}
		}

		/// <summary>
		/// Void DrawMeshInstancedIndirect(UnityEngine.Mesh, Int32, UnityEngine.Material, Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_MDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer;
		public virtual RMethod RMDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer
		{
			get
			{
				if(r_MDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer == null)
				{
					r_MDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer = new(this, "DrawMeshInstancedIndirect", 0, typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
				}
				return r_MDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void DrawMeshInstancedIndirect(UnityEngine.Mesh, Int32, UnityEngine.Material, Int32, UnityEngine.GraphicsBuffer, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32_MaterialPropertyBlock;
		public virtual RMethod RMDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_MDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32_MaterialPropertyBlock == null)
				{
					r_MDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32_MaterialPropertyBlock = new(this, "DrawMeshInstancedIndirect", 0, typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
				}
				return r_MDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void DrawMeshInstancedIndirect(UnityEngine.Mesh, Int32, UnityEngine.Material, Int32, UnityEngine.GraphicsBuffer, Int32)
		/// </summary>
		protected RMethod r_MDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32;
		public virtual RMethod RMDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32
		{
			get
			{
				if(r_MDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32 == null)
				{
					r_MDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32 = new(this, "DrawMeshInstancedIndirect", 0, typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32));
				}
				return r_MDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32;
			}
		}

		/// <summary>
		/// Void DrawMeshInstancedIndirect(UnityEngine.Mesh, Int32, UnityEngine.Material, Int32, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_MDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer;
		public virtual RMethod RMDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer
		{
			get
			{
				if(r_MDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer == null)
				{
					r_MDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer = new(this, "DrawMeshInstancedIndirect", 0, typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer));
				}
				return r_MDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void DrawOcclusionMesh(UnityEngine.RectInt)
		/// </summary>
		protected RMethod r_MDrawOcclusionMesh_RectInt;
		public virtual RMethod RMDrawOcclusionMesh_RectInt
		{
			get
			{
				if(r_MDrawOcclusionMesh_RectInt == null)
				{
					r_MDrawOcclusionMesh_RectInt = new(this, "DrawOcclusionMesh", 0, typeof(UnityEngine.RectInt));
				}
				return r_MDrawOcclusionMesh_RectInt;
			}
		}

		/// <summary>
		/// Void SetRandomWriteTarget(Int32, UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_MSetRandomWriteTarget_Int32_RenderTargetIdentifier;
		public virtual RMethod RMSetRandomWriteTarget_Int32_RenderTargetIdentifier
		{
			get
			{
				if(r_MSetRandomWriteTarget_Int32_RenderTargetIdentifier == null)
				{
					r_MSetRandomWriteTarget_Int32_RenderTargetIdentifier = new(this, "SetRandomWriteTarget", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier));
				}
				return r_MSetRandomWriteTarget_Int32_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void SetRandomWriteTarget(Int32, UnityEngine.ComputeBuffer, Boolean)
		/// </summary>
		protected RMethod r_MSetRandomWriteTarget_Int32_ComputeBuffer_Boolean;
		public virtual RMethod RMSetRandomWriteTarget_Int32_ComputeBuffer_Boolean
		{
			get
			{
				if(r_MSetRandomWriteTarget_Int32_ComputeBuffer_Boolean == null)
				{
					r_MSetRandomWriteTarget_Int32_ComputeBuffer_Boolean = new(this, "SetRandomWriteTarget", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Boolean));
				}
				return r_MSetRandomWriteTarget_Int32_ComputeBuffer_Boolean;
			}
		}

		/// <summary>
		/// Void SetRandomWriteTarget(Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_MSetRandomWriteTarget_Int32_ComputeBuffer;
		public virtual RMethod RMSetRandomWriteTarget_Int32_ComputeBuffer
		{
			get
			{
				if(r_MSetRandomWriteTarget_Int32_ComputeBuffer == null)
				{
					r_MSetRandomWriteTarget_Int32_ComputeBuffer = new(this, "SetRandomWriteTarget", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
				}
				return r_MSetRandomWriteTarget_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetRandomWriteTarget(Int32, UnityEngine.GraphicsBuffer, Boolean)
		/// </summary>
		protected RMethod r_MSetRandomWriteTarget_Int32_GraphicsBuffer_Boolean;
		public virtual RMethod RMSetRandomWriteTarget_Int32_GraphicsBuffer_Boolean
		{
			get
			{
				if(r_MSetRandomWriteTarget_Int32_GraphicsBuffer_Boolean == null)
				{
					r_MSetRandomWriteTarget_Int32_GraphicsBuffer_Boolean = new(this, "SetRandomWriteTarget", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Boolean));
				}
				return r_MSetRandomWriteTarget_Int32_GraphicsBuffer_Boolean;
			}
		}

		/// <summary>
		/// Void SetRandomWriteTarget(Int32, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_MSetRandomWriteTarget_Int32_GraphicsBuffer;
		public virtual RMethod RMSetRandomWriteTarget_Int32_GraphicsBuffer
		{
			get
			{
				if(r_MSetRandomWriteTarget_Int32_GraphicsBuffer == null)
				{
					r_MSetRandomWriteTarget_Int32_GraphicsBuffer = new(this, "SetRandomWriteTarget", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer));
				}
				return r_MSetRandomWriteTarget_Int32_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void CopyCounterValue(UnityEngine.ComputeBuffer, UnityEngine.ComputeBuffer, UInt32)
		/// </summary>
		protected RMethod r_MCopyCounterValue_ComputeBuffer_ComputeBuffer_UInt32;
		public virtual RMethod RMCopyCounterValue_ComputeBuffer_ComputeBuffer_UInt32
		{
			get
			{
				if(r_MCopyCounterValue_ComputeBuffer_ComputeBuffer_UInt32 == null)
				{
					r_MCopyCounterValue_ComputeBuffer_ComputeBuffer_UInt32 = new(this, "CopyCounterValue", 0, typeof(UnityEngine.ComputeBuffer), typeof(UnityEngine.ComputeBuffer), typeof(System.UInt32));
				}
				return r_MCopyCounterValue_ComputeBuffer_ComputeBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void CopyCounterValue(UnityEngine.GraphicsBuffer, UnityEngine.ComputeBuffer, UInt32)
		/// </summary>
		protected RMethod r_MCopyCounterValue_GraphicsBuffer_ComputeBuffer_UInt32;
		public virtual RMethod RMCopyCounterValue_GraphicsBuffer_ComputeBuffer_UInt32
		{
			get
			{
				if(r_MCopyCounterValue_GraphicsBuffer_ComputeBuffer_UInt32 == null)
				{
					r_MCopyCounterValue_GraphicsBuffer_ComputeBuffer_UInt32 = new(this, "CopyCounterValue", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.ComputeBuffer), typeof(System.UInt32));
				}
				return r_MCopyCounterValue_GraphicsBuffer_ComputeBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void CopyCounterValue(UnityEngine.ComputeBuffer, UnityEngine.GraphicsBuffer, UInt32)
		/// </summary>
		protected RMethod r_MCopyCounterValue_ComputeBuffer_GraphicsBuffer_UInt32;
		public virtual RMethod RMCopyCounterValue_ComputeBuffer_GraphicsBuffer_UInt32
		{
			get
			{
				if(r_MCopyCounterValue_ComputeBuffer_GraphicsBuffer_UInt32 == null)
				{
					r_MCopyCounterValue_ComputeBuffer_GraphicsBuffer_UInt32 = new(this, "CopyCounterValue", 0, typeof(UnityEngine.ComputeBuffer), typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32));
				}
				return r_MCopyCounterValue_ComputeBuffer_GraphicsBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void CopyCounterValue(UnityEngine.GraphicsBuffer, UnityEngine.GraphicsBuffer, UInt32)
		/// </summary>
		protected RMethod r_MCopyCounterValue_GraphicsBuffer_GraphicsBuffer_UInt32;
		public virtual RMethod RMCopyCounterValue_GraphicsBuffer_GraphicsBuffer_UInt32
		{
			get
			{
				if(r_MCopyCounterValue_GraphicsBuffer_GraphicsBuffer_UInt32 == null)
				{
					r_MCopyCounterValue_GraphicsBuffer_GraphicsBuffer_UInt32 = new(this, "CopyCounterValue", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32));
				}
				return r_MCopyCounterValue_GraphicsBuffer_GraphicsBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void CopyTexture(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_MCopyTexture_RenderTargetIdentifier_RenderTargetIdentifier;
		public virtual RMethod RMCopyTexture_RenderTargetIdentifier_RenderTargetIdentifier
		{
			get
			{
				if(r_MCopyTexture_RenderTargetIdentifier_RenderTargetIdentifier == null)
				{
					r_MCopyTexture_RenderTargetIdentifier_RenderTargetIdentifier = new(this, "CopyTexture", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier));
				}
				return r_MCopyTexture_RenderTargetIdentifier_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void CopyTexture(UnityEngine.Rendering.RenderTargetIdentifier, Int32, UnityEngine.Rendering.RenderTargetIdentifier, Int32)
		/// </summary>
		protected RMethod r_MCopyTexture_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32;
		public virtual RMethod RMCopyTexture_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32
		{
			get
			{
				if(r_MCopyTexture_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32 == null)
				{
					r_MCopyTexture_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32 = new(this, "CopyTexture", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32));
				}
				return r_MCopyTexture_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32;
			}
		}

		/// <summary>
		/// Void CopyTexture(UnityEngine.Rendering.RenderTargetIdentifier, Int32, Int32, UnityEngine.Rendering.RenderTargetIdentifier, Int32, Int32)
		/// </summary>
		protected RMethod r_MCopyTexture_RenderTargetIdentifier_Int32_Int32_RenderTargetIdentifier_Int32_Int32;
		public virtual RMethod RMCopyTexture_RenderTargetIdentifier_Int32_Int32_RenderTargetIdentifier_Int32_Int32
		{
			get
			{
				if(r_MCopyTexture_RenderTargetIdentifier_Int32_Int32_RenderTargetIdentifier_Int32_Int32 == null)
				{
					r_MCopyTexture_RenderTargetIdentifier_Int32_Int32_RenderTargetIdentifier_Int32_Int32 = new(this, "CopyTexture", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MCopyTexture_RenderTargetIdentifier_Int32_Int32_RenderTargetIdentifier_Int32_Int32;
			}
		}

		/// <summary>
		/// Void CopyTexture(UnityEngine.Rendering.RenderTargetIdentifier, Int32, Int32, Int32, Int32, Int32, Int32, UnityEngine.Rendering.RenderTargetIdentifier, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MCopyTexture_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32_Int32_RenderTargetIdentifier_Int32_Int32_Int32_Int32;
		public virtual RMethod RMCopyTexture_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32_Int32_RenderTargetIdentifier_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MCopyTexture_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32_Int32_RenderTargetIdentifier_Int32_Int32_Int32_Int32 == null)
				{
					r_MCopyTexture_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32_Int32_RenderTargetIdentifier_Int32_Int32_Int32_Int32 = new(this, "CopyTexture", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MCopyTexture_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32_Int32_RenderTargetIdentifier_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Blit(UnityEngine.Texture, UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_MBlit_Texture_RenderTargetIdentifier;
		public virtual RMethod RMBlit_Texture_RenderTargetIdentifier
		{
			get
			{
				if(r_MBlit_Texture_RenderTargetIdentifier == null)
				{
					r_MBlit_Texture_RenderTargetIdentifier = new(this, "Blit", 0, typeof(UnityEngine.Texture), typeof(UnityEngine.Rendering.RenderTargetIdentifier));
				}
				return r_MBlit_Texture_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void Blit(UnityEngine.Texture, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MBlit_Texture_RenderTargetIdentifier_Vector2_Vector2;
		public virtual RMethod RMBlit_Texture_RenderTargetIdentifier_Vector2_Vector2
		{
			get
			{
				if(r_MBlit_Texture_RenderTargetIdentifier_Vector2_Vector2 == null)
				{
					r_MBlit_Texture_RenderTargetIdentifier_Vector2_Vector2 = new(this, "Blit", 0, typeof(UnityEngine.Texture), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
				}
				return r_MBlit_Texture_RenderTargetIdentifier_Vector2_Vector2;
			}
		}

		/// <summary>
		/// Void Blit(UnityEngine.Texture, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Material)
		/// </summary>
		protected RMethod r_MBlit_Texture_RenderTargetIdentifier_Material;
		public virtual RMethod RMBlit_Texture_RenderTargetIdentifier_Material
		{
			get
			{
				if(r_MBlit_Texture_RenderTargetIdentifier_Material == null)
				{
					r_MBlit_Texture_RenderTargetIdentifier_Material = new(this, "Blit", 0, typeof(UnityEngine.Texture), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Material));
				}
				return r_MBlit_Texture_RenderTargetIdentifier_Material;
			}
		}

		/// <summary>
		/// Void Blit(UnityEngine.Texture, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Material, Int32)
		/// </summary>
		protected RMethod r_MBlit_Texture_RenderTargetIdentifier_Material_Int32;
		public virtual RMethod RMBlit_Texture_RenderTargetIdentifier_Material_Int32
		{
			get
			{
				if(r_MBlit_Texture_RenderTargetIdentifier_Material_Int32 == null)
				{
					r_MBlit_Texture_RenderTargetIdentifier_Material_Int32 = new(this, "Blit", 0, typeof(UnityEngine.Texture), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Material), typeof(System.Int32));
				}
				return r_MBlit_Texture_RenderTargetIdentifier_Material_Int32;
			}
		}

		/// <summary>
		/// Void Blit(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_MBlit_RenderTargetIdentifier_RenderTargetIdentifier;
		public virtual RMethod RMBlit_RenderTargetIdentifier_RenderTargetIdentifier
		{
			get
			{
				if(r_MBlit_RenderTargetIdentifier_RenderTargetIdentifier == null)
				{
					r_MBlit_RenderTargetIdentifier_RenderTargetIdentifier = new(this, "Blit", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier));
				}
				return r_MBlit_RenderTargetIdentifier_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void Blit(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MBlit_RenderTargetIdentifier_RenderTargetIdentifier_Vector2_Vector2;
		public virtual RMethod RMBlit_RenderTargetIdentifier_RenderTargetIdentifier_Vector2_Vector2
		{
			get
			{
				if(r_MBlit_RenderTargetIdentifier_RenderTargetIdentifier_Vector2_Vector2 == null)
				{
					r_MBlit_RenderTargetIdentifier_RenderTargetIdentifier_Vector2_Vector2 = new(this, "Blit", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
				}
				return r_MBlit_RenderTargetIdentifier_RenderTargetIdentifier_Vector2_Vector2;
			}
		}

		/// <summary>
		/// Void Blit(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Material)
		/// </summary>
		protected RMethod r_MBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material;
		public virtual RMethod RMBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material
		{
			get
			{
				if(r_MBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material == null)
				{
					r_MBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material = new(this, "Blit", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Material));
				}
				return r_MBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material;
			}
		}

		/// <summary>
		/// Void Blit(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Material, Int32)
		/// </summary>
		protected RMethod r_MBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32;
		public virtual RMethod RMBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32
		{
			get
			{
				if(r_MBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32 == null)
				{
					r_MBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32 = new(this, "Blit", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Material), typeof(System.Int32));
				}
				return r_MBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32;
			}
		}

		/// <summary>
		/// Void Blit(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier, Int32, Int32)
		/// </summary>
		protected RMethod r_MBlit_RenderTargetIdentifier_RenderTargetIdentifier_Int32_Int32;
		public virtual RMethod RMBlit_RenderTargetIdentifier_RenderTargetIdentifier_Int32_Int32
		{
			get
			{
				if(r_MBlit_RenderTargetIdentifier_RenderTargetIdentifier_Int32_Int32 == null)
				{
					r_MBlit_RenderTargetIdentifier_RenderTargetIdentifier_Int32_Int32 = new(this, "Blit", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MBlit_RenderTargetIdentifier_RenderTargetIdentifier_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Blit(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Vector2, UnityEngine.Vector2, Int32, Int32)
		/// </summary>
		protected RMethod r_MBlit_RenderTargetIdentifier_RenderTargetIdentifier_Vector2_Vector2_Int32_Int32;
		public virtual RMethod RMBlit_RenderTargetIdentifier_RenderTargetIdentifier_Vector2_Vector2_Int32_Int32
		{
			get
			{
				if(r_MBlit_RenderTargetIdentifier_RenderTargetIdentifier_Vector2_Vector2_Int32_Int32 == null)
				{
					r_MBlit_RenderTargetIdentifier_RenderTargetIdentifier_Vector2_Vector2_Int32_Int32 = new(this, "Blit", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MBlit_RenderTargetIdentifier_RenderTargetIdentifier_Vector2_Vector2_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Blit(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Material, Int32, Int32)
		/// </summary>
		protected RMethod r_MBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_Int32;
		public virtual RMethod RMBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_Int32
		{
			get
			{
				if(r_MBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_Int32 == null)
				{
					r_MBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_Int32 = new(this, "Blit", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Material), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalFloat(System.String, Single)
		/// </summary>
		protected RMethod r_MSetGlobalFloat_String_Single;
		public virtual RMethod RMSetGlobalFloat_String_Single
		{
			get
			{
				if(r_MSetGlobalFloat_String_Single == null)
				{
					r_MSetGlobalFloat_String_Single = new(this, "SetGlobalFloat", 0, typeof(System.String), typeof(System.Single));
				}
				return r_MSetGlobalFloat_String_Single;
			}
		}

		/// <summary>
		/// Void SetGlobalInt(System.String, Int32)
		/// </summary>
		protected RMethod r_MSetGlobalInt_String_Int32;
		public virtual RMethod RMSetGlobalInt_String_Int32
		{
			get
			{
				if(r_MSetGlobalInt_String_Int32 == null)
				{
					r_MSetGlobalInt_String_Int32 = new(this, "SetGlobalInt", 0, typeof(System.String), typeof(System.Int32));
				}
				return r_MSetGlobalInt_String_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalInteger(System.String, Int32)
		/// </summary>
		protected RMethod r_MSetGlobalInteger_String_Int32;
		public virtual RMethod RMSetGlobalInteger_String_Int32
		{
			get
			{
				if(r_MSetGlobalInteger_String_Int32 == null)
				{
					r_MSetGlobalInteger_String_Int32 = new(this, "SetGlobalInteger", 0, typeof(System.String), typeof(System.Int32));
				}
				return r_MSetGlobalInteger_String_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalVector(System.String, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_MSetGlobalVector_String_Vector4;
		public virtual RMethod RMSetGlobalVector_String_Vector4
		{
			get
			{
				if(r_MSetGlobalVector_String_Vector4 == null)
				{
					r_MSetGlobalVector_String_Vector4 = new(this, "SetGlobalVector", 0, typeof(System.String), typeof(UnityEngine.Vector4));
				}
				return r_MSetGlobalVector_String_Vector4;
			}
		}

		/// <summary>
		/// Void SetGlobalColor(System.String, UnityEngine.Color)
		/// </summary>
		protected RMethod r_MSetGlobalColor_String_Color;
		public virtual RMethod RMSetGlobalColor_String_Color
		{
			get
			{
				if(r_MSetGlobalColor_String_Color == null)
				{
					r_MSetGlobalColor_String_Color = new(this, "SetGlobalColor", 0, typeof(System.String), typeof(UnityEngine.Color));
				}
				return r_MSetGlobalColor_String_Color;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrix(System.String, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_MSetGlobalMatrix_String_Matrix4x4;
		public virtual RMethod RMSetGlobalMatrix_String_Matrix4x4
		{
			get
			{
				if(r_MSetGlobalMatrix_String_Matrix4x4 == null)
				{
					r_MSetGlobalMatrix_String_Matrix4x4 = new(this, "SetGlobalMatrix", 0, typeof(System.String), typeof(UnityEngine.Matrix4x4));
				}
				return r_MSetGlobalMatrix_String_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetGlobalFloatArray(System.String, System.Collections.Generic.List`1[System.Single])
		/// </summary>
		protected RMethod r_MSetGlobalFloatArray_String_List_d_Single_p_;
		public virtual RMethod RMSetGlobalFloatArray_String_List_d_Single_p_
		{
			get
			{
				if(r_MSetGlobalFloatArray_String_List_d_Single_p_ == null)
				{
					r_MSetGlobalFloatArray_String_List_d_Single_p_ = new(this, "SetGlobalFloatArray", 0, typeof(System.String),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.Single)));
				}
				return r_MSetGlobalFloatArray_String_List_d_Single_p_;
			}
		}

		/// <summary>
		/// Void SetGlobalFloatArray(Int32, System.Collections.Generic.List`1[System.Single])
		/// </summary>
		protected RMethod r_MSetGlobalFloatArray_Int32_List_d_Single_p_;
		public virtual RMethod RMSetGlobalFloatArray_Int32_List_d_Single_p_
		{
			get
			{
				if(r_MSetGlobalFloatArray_Int32_List_d_Single_p_ == null)
				{
					r_MSetGlobalFloatArray_Int32_List_d_Single_p_ = new(this, "SetGlobalFloatArray", 0, typeof(System.Int32),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.Single)));
				}
				return r_MSetGlobalFloatArray_Int32_List_d_Single_p_;
			}
		}

		/// <summary>
		/// Void SetGlobalFloatArray(System.String, Single[])
		/// </summary>
		protected RMethod r_MSetGlobalFloatArray_String_SingleArray;
		public virtual RMethod RMSetGlobalFloatArray_String_SingleArray
		{
			get
			{
				if(r_MSetGlobalFloatArray_String_SingleArray == null)
				{
					r_MSetGlobalFloatArray_String_SingleArray = new(this, "SetGlobalFloatArray", 0, typeof(System.String), typeof(System.Single).MakeArrayType());
				}
				return r_MSetGlobalFloatArray_String_SingleArray;
			}
		}

		/// <summary>
		/// Void SetGlobalVectorArray(System.String, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_MSetGlobalVectorArray_String_List_d_Vector4_p_;
		public virtual RMethod RMSetGlobalVectorArray_String_List_d_Vector4_p_
		{
			get
			{
				if(r_MSetGlobalVectorArray_String_List_d_Vector4_p_ == null)
				{
					r_MSetGlobalVectorArray_String_List_d_Vector4_p_ = new(this, "SetGlobalVectorArray", 0, typeof(System.String),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Vector4)));
				}
				return r_MSetGlobalVectorArray_String_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void SetGlobalVectorArray(Int32, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_MSetGlobalVectorArray_Int32_List_d_Vector4_p_;
		public virtual RMethod RMSetGlobalVectorArray_Int32_List_d_Vector4_p_
		{
			get
			{
				if(r_MSetGlobalVectorArray_Int32_List_d_Vector4_p_ == null)
				{
					r_MSetGlobalVectorArray_Int32_List_d_Vector4_p_ = new(this, "SetGlobalVectorArray", 0, typeof(System.Int32),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Vector4)));
				}
				return r_MSetGlobalVectorArray_Int32_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void SetGlobalVectorArray(System.String, UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_MSetGlobalVectorArray_String_Vector4Array;
		public virtual RMethod RMSetGlobalVectorArray_String_Vector4Array
		{
			get
			{
				if(r_MSetGlobalVectorArray_String_Vector4Array == null)
				{
					r_MSetGlobalVectorArray_String_Vector4Array = new(this, "SetGlobalVectorArray", 0, typeof(System.String), typeof(UnityEngine.Vector4).MakeArrayType());
				}
				return r_MSetGlobalVectorArray_String_Vector4Array;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrixArray(System.String, System.Collections.Generic.List`1[UnityEngine.Matrix4x4])
		/// </summary>
		protected RMethod r_MSetGlobalMatrixArray_String_List_d_Matrix4x4_p_;
		public virtual RMethod RMSetGlobalMatrixArray_String_List_d_Matrix4x4_p_
		{
			get
			{
				if(r_MSetGlobalMatrixArray_String_List_d_Matrix4x4_p_ == null)
				{
					r_MSetGlobalMatrixArray_String_List_d_Matrix4x4_p_ = new(this, "SetGlobalMatrixArray", 0, typeof(System.String),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Matrix4x4)));
				}
				return r_MSetGlobalMatrixArray_String_List_d_Matrix4x4_p_;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrixArray(Int32, System.Collections.Generic.List`1[UnityEngine.Matrix4x4])
		/// </summary>
		protected RMethod r_MSetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_;
		public virtual RMethod RMSetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_
		{
			get
			{
				if(r_MSetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_ == null)
				{
					r_MSetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_ = new(this, "SetGlobalMatrixArray", 0, typeof(System.Int32),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Matrix4x4)));
				}
				return r_MSetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrixArray(System.String, UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_MSetGlobalMatrixArray_String_Matrix4x4Array;
		public virtual RMethod RMSetGlobalMatrixArray_String_Matrix4x4Array
		{
			get
			{
				if(r_MSetGlobalMatrixArray_String_Matrix4x4Array == null)
				{
					r_MSetGlobalMatrixArray_String_Matrix4x4Array = new(this, "SetGlobalMatrixArray", 0, typeof(System.String), typeof(UnityEngine.Matrix4x4).MakeArrayType());
				}
				return r_MSetGlobalMatrixArray_String_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Void SetGlobalTexture(System.String, UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_MSetGlobalTexture_String_RenderTargetIdentifier;
		public virtual RMethod RMSetGlobalTexture_String_RenderTargetIdentifier
		{
			get
			{
				if(r_MSetGlobalTexture_String_RenderTargetIdentifier == null)
				{
					r_MSetGlobalTexture_String_RenderTargetIdentifier = new(this, "SetGlobalTexture", 0, typeof(System.String), typeof(UnityEngine.Rendering.RenderTargetIdentifier));
				}
				return r_MSetGlobalTexture_String_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void SetGlobalTexture(Int32, UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_MSetGlobalTexture_Int32_RenderTargetIdentifier;
		public virtual RMethod RMSetGlobalTexture_Int32_RenderTargetIdentifier
		{
			get
			{
				if(r_MSetGlobalTexture_Int32_RenderTargetIdentifier == null)
				{
					r_MSetGlobalTexture_Int32_RenderTargetIdentifier = new(this, "SetGlobalTexture", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier));
				}
				return r_MSetGlobalTexture_Int32_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void SetGlobalTexture(System.String, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTextureSubElement)
		/// </summary>
		protected RMethod r_MSetGlobalTexture_String_RenderTargetIdentifier_RenderTextureSubElement;
		public virtual RMethod RMSetGlobalTexture_String_RenderTargetIdentifier_RenderTextureSubElement
		{
			get
			{
				if(r_MSetGlobalTexture_String_RenderTargetIdentifier_RenderTextureSubElement == null)
				{
					r_MSetGlobalTexture_String_RenderTargetIdentifier_RenderTextureSubElement = new(this, "SetGlobalTexture", 0, typeof(System.String), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTextureSubElement));
				}
				return r_MSetGlobalTexture_String_RenderTargetIdentifier_RenderTextureSubElement;
			}
		}

		/// <summary>
		/// Void SetGlobalTexture(Int32, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTextureSubElement)
		/// </summary>
		protected RMethod r_MSetGlobalTexture_Int32_RenderTargetIdentifier_RenderTextureSubElement;
		public virtual RMethod RMSetGlobalTexture_Int32_RenderTargetIdentifier_RenderTextureSubElement
		{
			get
			{
				if(r_MSetGlobalTexture_Int32_RenderTargetIdentifier_RenderTextureSubElement == null)
				{
					r_MSetGlobalTexture_Int32_RenderTargetIdentifier_RenderTextureSubElement = new(this, "SetGlobalTexture", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTextureSubElement));
				}
				return r_MSetGlobalTexture_Int32_RenderTargetIdentifier_RenderTextureSubElement;
			}
		}

		/// <summary>
		/// Void SetGlobalBuffer(System.String, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_MSetGlobalBuffer_String_ComputeBuffer;
		public virtual RMethod RMSetGlobalBuffer_String_ComputeBuffer
		{
			get
			{
				if(r_MSetGlobalBuffer_String_ComputeBuffer == null)
				{
					r_MSetGlobalBuffer_String_ComputeBuffer = new(this, "SetGlobalBuffer", 0, typeof(System.String), typeof(UnityEngine.ComputeBuffer));
				}
				return r_MSetGlobalBuffer_String_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetGlobalBuffer(Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_MSetGlobalBuffer_Int32_ComputeBuffer;
		public virtual RMethod RMSetGlobalBuffer_Int32_ComputeBuffer
		{
			get
			{
				if(r_MSetGlobalBuffer_Int32_ComputeBuffer == null)
				{
					r_MSetGlobalBuffer_Int32_ComputeBuffer = new(this, "SetGlobalBuffer", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
				}
				return r_MSetGlobalBuffer_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetGlobalBuffer(System.String, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_MSetGlobalBuffer_String_GraphicsBuffer;
		public virtual RMethod RMSetGlobalBuffer_String_GraphicsBuffer
		{
			get
			{
				if(r_MSetGlobalBuffer_String_GraphicsBuffer == null)
				{
					r_MSetGlobalBuffer_String_GraphicsBuffer = new(this, "SetGlobalBuffer", 0, typeof(System.String), typeof(UnityEngine.GraphicsBuffer));
				}
				return r_MSetGlobalBuffer_String_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetGlobalBuffer(Int32, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_MSetGlobalBuffer_Int32_GraphicsBuffer;
		public virtual RMethod RMSetGlobalBuffer_Int32_GraphicsBuffer
		{
			get
			{
				if(r_MSetGlobalBuffer_Int32_GraphicsBuffer == null)
				{
					r_MSetGlobalBuffer_Int32_GraphicsBuffer = new(this, "SetGlobalBuffer", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer));
				}
				return r_MSetGlobalBuffer_Int32_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetGlobalConstantBuffer_ComputeBuffer_Int32_Int32_Int32;
		public virtual RMethod RMSetGlobalConstantBuffer_ComputeBuffer_Int32_Int32_Int32
		{
			get
			{
				if(r_MSetGlobalConstantBuffer_ComputeBuffer_Int32_Int32_Int32 == null)
				{
					r_MSetGlobalConstantBuffer_ComputeBuffer_Int32_Int32_Int32 = new(this, "SetGlobalConstantBuffer", 0, typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetGlobalConstantBuffer_ComputeBuffer_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer, System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetGlobalConstantBuffer_ComputeBuffer_String_Int32_Int32;
		public virtual RMethod RMSetGlobalConstantBuffer_ComputeBuffer_String_Int32_Int32
		{
			get
			{
				if(r_MSetGlobalConstantBuffer_ComputeBuffer_String_Int32_Int32 == null)
				{
					r_MSetGlobalConstantBuffer_ComputeBuffer_String_Int32_Int32 = new(this, "SetGlobalConstantBuffer", 0, typeof(UnityEngine.ComputeBuffer), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetGlobalConstantBuffer_ComputeBuffer_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetGlobalConstantBuffer_GraphicsBuffer_Int32_Int32_Int32;
		public virtual RMethod RMSetGlobalConstantBuffer_GraphicsBuffer_Int32_Int32_Int32
		{
			get
			{
				if(r_MSetGlobalConstantBuffer_GraphicsBuffer_Int32_Int32_Int32 == null)
				{
					r_MSetGlobalConstantBuffer_GraphicsBuffer_Int32_Int32_Int32 = new(this, "SetGlobalConstantBuffer", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetGlobalConstantBuffer_GraphicsBuffer_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer, System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetGlobalConstantBuffer_GraphicsBuffer_String_Int32_Int32;
		public virtual RMethod RMSetGlobalConstantBuffer_GraphicsBuffer_String_Int32_Int32
		{
			get
			{
				if(r_MSetGlobalConstantBuffer_GraphicsBuffer_String_Int32_Int32 == null)
				{
					r_MSetGlobalConstantBuffer_GraphicsBuffer_String_Int32_Int32 = new(this, "SetGlobalConstantBuffer", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetGlobalConstantBuffer_GraphicsBuffer_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetShadowSamplingMode(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.ShadowSamplingMode)
		/// </summary>
		protected RMethod r_MSetShadowSamplingMode_RenderTargetIdentifier_ShadowSamplingMode;
		public virtual RMethod RMSetShadowSamplingMode_RenderTargetIdentifier_ShadowSamplingMode
		{
			get
			{
				if(r_MSetShadowSamplingMode_RenderTargetIdentifier_ShadowSamplingMode == null)
				{
					r_MSetShadowSamplingMode_RenderTargetIdentifier_ShadowSamplingMode = new(this, "SetShadowSamplingMode", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.ShadowSamplingMode));
				}
				return r_MSetShadowSamplingMode_RenderTargetIdentifier_ShadowSamplingMode;
			}
		}

		/// <summary>
		/// Void SetSinglePassStereo(UnityEngine.Rendering.SinglePassStereoMode)
		/// </summary>
		protected RMethod r_MSetSinglePassStereo_SinglePassStereoMode;
		public virtual RMethod RMSetSinglePassStereo_SinglePassStereoMode
		{
			get
			{
				if(r_MSetSinglePassStereo_SinglePassStereoMode == null)
				{
					r_MSetSinglePassStereo_SinglePassStereoMode = new(this, "SetSinglePassStereo", 0, typeof(UnityEngine.Rendering.SinglePassStereoMode));
				}
				return r_MSetSinglePassStereo_SinglePassStereoMode;
			}
		}

		/// <summary>
		/// Void IssuePluginEvent(IntPtr, Int32)
		/// </summary>
		protected RMethod r_MIssuePluginEvent_IntPtr_Int32;
		public virtual RMethod RMIssuePluginEvent_IntPtr_Int32
		{
			get
			{
				if(r_MIssuePluginEvent_IntPtr_Int32 == null)
				{
					r_MIssuePluginEvent_IntPtr_Int32 = new(this, "IssuePluginEvent", 0, typeof(System.IntPtr), typeof(System.Int32));
				}
				return r_MIssuePluginEvent_IntPtr_Int32;
			}
		}

		/// <summary>
		/// Void IssuePluginEventAndData(IntPtr, Int32, IntPtr)
		/// </summary>
		protected RMethod r_MIssuePluginEventAndData_IntPtr_Int32_IntPtr;
		public virtual RMethod RMIssuePluginEventAndData_IntPtr_Int32_IntPtr
		{
			get
			{
				if(r_MIssuePluginEventAndData_IntPtr_Int32_IntPtr == null)
				{
					r_MIssuePluginEventAndData_IntPtr_Int32_IntPtr = new(this, "IssuePluginEventAndData", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.IntPtr));
				}
				return r_MIssuePluginEventAndData_IntPtr_Int32_IntPtr;
			}
		}

		/// <summary>
		/// Void IssuePluginEventAndDataWithFlags(IntPtr, Int32, UnityEngine.Rendering.CustomMarkerCallbackFlags, IntPtr)
		/// </summary>
		protected RMethod r_MIssuePluginEventAndDataWithFlags_IntPtr_Int32_CustomMarkerCallbackFlags_IntPtr;
		public virtual RMethod RMIssuePluginEventAndDataWithFlags_IntPtr_Int32_CustomMarkerCallbackFlags_IntPtr
		{
			get
			{
				if(r_MIssuePluginEventAndDataWithFlags_IntPtr_Int32_CustomMarkerCallbackFlags_IntPtr == null)
				{
					r_MIssuePluginEventAndDataWithFlags_IntPtr_Int32_CustomMarkerCallbackFlags_IntPtr = new(this, "IssuePluginEventAndDataWithFlags", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(UnityEngine.Rendering.CustomMarkerCallbackFlags), typeof(System.IntPtr));
				}
				return r_MIssuePluginEventAndDataWithFlags_IntPtr_Int32_CustomMarkerCallbackFlags_IntPtr;
			}
		}

		/// <summary>
		/// Void IssuePluginCustomBlit(IntPtr, UInt32, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier, UInt32, UInt32)
		/// </summary>
		protected RMethod r_MIssuePluginCustomBlit_IntPtr_UInt32_RenderTargetIdentifier_RenderTargetIdentifier_UInt32_UInt32;
		public virtual RMethod RMIssuePluginCustomBlit_IntPtr_UInt32_RenderTargetIdentifier_RenderTargetIdentifier_UInt32_UInt32
		{
			get
			{
				if(r_MIssuePluginCustomBlit_IntPtr_UInt32_RenderTargetIdentifier_RenderTargetIdentifier_UInt32_UInt32 == null)
				{
					r_MIssuePluginCustomBlit_IntPtr_UInt32_RenderTargetIdentifier_RenderTargetIdentifier_UInt32_UInt32 = new(this, "IssuePluginCustomBlit", 0, typeof(System.IntPtr), typeof(System.UInt32), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.UInt32), typeof(System.UInt32));
				}
				return r_MIssuePluginCustomBlit_IntPtr_UInt32_RenderTargetIdentifier_RenderTargetIdentifier_UInt32_UInt32;
			}
		}

		/// <summary>
		/// Void IssuePluginCustomTextureUpdate(IntPtr, UnityEngine.Texture, UInt32)
		/// </summary>
		protected RMethod r_MIssuePluginCustomTextureUpdate_IntPtr_Texture_UInt32;
		public virtual RMethod RMIssuePluginCustomTextureUpdate_IntPtr_Texture_UInt32
		{
			get
			{
				if(r_MIssuePluginCustomTextureUpdate_IntPtr_Texture_UInt32 == null)
				{
					r_MIssuePluginCustomTextureUpdate_IntPtr_Texture_UInt32 = new(this, "IssuePluginCustomTextureUpdate", 0, typeof(System.IntPtr), typeof(UnityEngine.Texture), typeof(System.UInt32));
				}
				return r_MIssuePluginCustomTextureUpdate_IntPtr_Texture_UInt32;
			}
		}

		/// <summary>
		/// Void IssuePluginCustomTextureUpdateV1(IntPtr, UnityEngine.Texture, UInt32)
		/// </summary>
		protected RMethod r_MIssuePluginCustomTextureUpdateV1_IntPtr_Texture_UInt32;
		public virtual RMethod RMIssuePluginCustomTextureUpdateV1_IntPtr_Texture_UInt32
		{
			get
			{
				if(r_MIssuePluginCustomTextureUpdateV1_IntPtr_Texture_UInt32 == null)
				{
					r_MIssuePluginCustomTextureUpdateV1_IntPtr_Texture_UInt32 = new(this, "IssuePluginCustomTextureUpdateV1", 0, typeof(System.IntPtr), typeof(UnityEngine.Texture), typeof(System.UInt32));
				}
				return r_MIssuePluginCustomTextureUpdateV1_IntPtr_Texture_UInt32;
			}
		}

		/// <summary>
		/// Void IssuePluginCustomTextureUpdateV2(IntPtr, UnityEngine.Texture, UInt32)
		/// </summary>
		protected RMethod r_MIssuePluginCustomTextureUpdateV2_IntPtr_Texture_UInt32;
		public virtual RMethod RMIssuePluginCustomTextureUpdateV2_IntPtr_Texture_UInt32
		{
			get
			{
				if(r_MIssuePluginCustomTextureUpdateV2_IntPtr_Texture_UInt32 == null)
				{
					r_MIssuePluginCustomTextureUpdateV2_IntPtr_Texture_UInt32 = new(this, "IssuePluginCustomTextureUpdateV2", 0, typeof(System.IntPtr), typeof(UnityEngine.Texture), typeof(System.UInt32));
				}
				return r_MIssuePluginCustomTextureUpdateV2_IntPtr_Texture_UInt32;
			}
		}

		/// <summary>
		/// Void ProcessVTFeedback(UnityEngine.Rendering.RenderTargetIdentifier, IntPtr, Int32, Int32, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MProcessVTFeedback_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32;
		public virtual RMethod RMProcessVTFeedback_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MProcessVTFeedback_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32 == null)
				{
					r_MProcessVTFeedback_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32 = new(this, "ProcessVTFeedback", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MProcessVTFeedback_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void CopyBuffer(UnityEngine.GraphicsBuffer, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_MCopyBuffer_GraphicsBuffer_GraphicsBuffer;
		public virtual RMethod RMCopyBuffer_GraphicsBuffer_GraphicsBuffer
		{
			get
			{
				if(r_MCopyBuffer_GraphicsBuffer_GraphicsBuffer == null)
				{
					r_MCopyBuffer_GraphicsBuffer_GraphicsBuffer = new(this, "CopyBuffer", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.GraphicsBuffer));
				}
				return r_MCopyBuffer_GraphicsBuffer_GraphicsBuffer;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.GPUFence CreateGPUFence(UnityEngine.Rendering.SynchronisationStage)
		/// </summary>
		protected RMethod r_MCreateGPUFence_SynchronisationStage;
		public virtual RMethod RMCreateGPUFence_SynchronisationStage
		{
			get
			{
				if(r_MCreateGPUFence_SynchronisationStage == null)
				{
					r_MCreateGPUFence_SynchronisationStage = new(this, "CreateGPUFence", 0, typeof(UnityEngine.Rendering.SynchronisationStage));
				}
				return r_MCreateGPUFence_SynchronisationStage;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.GPUFence CreateGPUFence()
		/// </summary>
		protected RMethod r_MCreateGPUFence;
		public virtual RMethod RMCreateGPUFence
		{
			get
			{
				if(r_MCreateGPUFence == null)
				{
					r_MCreateGPUFence = new(this, "CreateGPUFence", 0);
				}
				return r_MCreateGPUFence;
			}
		}

		/// <summary>
		/// Void WaitOnGPUFence(UnityEngine.Rendering.GPUFence, UnityEngine.Rendering.SynchronisationStage)
		/// </summary>
		protected RMethod r_MWaitOnGPUFence_GPUFence_SynchronisationStage;
		public virtual RMethod RMWaitOnGPUFence_GPUFence_SynchronisationStage
		{
			get
			{
				if(r_MWaitOnGPUFence_GPUFence_SynchronisationStage == null)
				{
					r_MWaitOnGPUFence_GPUFence_SynchronisationStage = new(this, "WaitOnGPUFence", 0, typeof(UnityEngine.Rendering.GraphicsFence), typeof(UnityEngine.Rendering.SynchronisationStage));
				}
				return r_MWaitOnGPUFence_GPUFence_SynchronisationStage;
			}
		}

		/// <summary>
		/// Void WaitOnGPUFence(UnityEngine.Rendering.GPUFence)
		/// </summary>
		protected RMethod r_MWaitOnGPUFence_GPUFence;
		public virtual RMethod RMWaitOnGPUFence_GPUFence
		{
			get
			{
				if(r_MWaitOnGPUFence_GPUFence == null)
				{
					r_MWaitOnGPUFence_GPUFence = new(this, "WaitOnGPUFence", 0, typeof(UnityEngine.Rendering.GraphicsFence));
				}
				return r_MWaitOnGPUFence_GPUFence;
			}
		}

		/// <summary>
		/// Void SetComputeBufferData(UnityEngine.ComputeBuffer, System.Array)
		/// </summary>
		protected RMethod r_MSetComputeBufferData_ComputeBuffer_Array;
		public virtual RMethod RMSetComputeBufferData_ComputeBuffer_Array
		{
			get
			{
				if(r_MSetComputeBufferData_ComputeBuffer_Array == null)
				{
					r_MSetComputeBufferData_ComputeBuffer_Array = new(this, "SetComputeBufferData", 0, typeof(UnityEngine.ComputeBuffer), typeof(System.Array));
				}
				return r_MSetComputeBufferData_ComputeBuffer_Array;
			}
		}

		/// <summary>
		/// Void SetComputeBufferData[T](UnityEngine.ComputeBuffer, System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_MSetComputeBufferData_GT_ComputeBuffer_List_d_T_p_;
		public virtual RMethod RMSetComputeBufferData_GT_ComputeBuffer_List_d_T_p_
		{
			get
			{
				if(r_MSetComputeBufferData_GT_ComputeBuffer_List_d_T_p_ == null)
				{
					r_MSetComputeBufferData_GT_ComputeBuffer_List_d_T_p_ = new(this, "SetComputeBufferData", 1, typeof(UnityEngine.ComputeBuffer),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MSetComputeBufferData_GT_ComputeBuffer_List_d_T_p_;
			}
		}

		/// <summary>
		/// Void SetComputeBufferData[T](UnityEngine.ComputeBuffer, Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_MSetComputeBufferData_GT_ComputeBuffer_NativeArray_d_T_p_;
		public virtual RMethod RMSetComputeBufferData_GT_ComputeBuffer_NativeArray_d_T_p_
		{
			get
			{
				if(r_MSetComputeBufferData_GT_ComputeBuffer_NativeArray_d_T_p_ == null)
				{
					r_MSetComputeBufferData_GT_ComputeBuffer_NativeArray_d_T_p_ = new(this, "SetComputeBufferData", 1, typeof(UnityEngine.ComputeBuffer),  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MSetComputeBufferData_GT_ComputeBuffer_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void SetComputeBufferData(UnityEngine.ComputeBuffer, System.Array, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetComputeBufferData_ComputeBuffer_Array_Int32_Int32_Int32;
		public virtual RMethod RMSetComputeBufferData_ComputeBuffer_Array_Int32_Int32_Int32
		{
			get
			{
				if(r_MSetComputeBufferData_ComputeBuffer_Array_Int32_Int32_Int32 == null)
				{
					r_MSetComputeBufferData_ComputeBuffer_Array_Int32_Int32_Int32 = new(this, "SetComputeBufferData", 0, typeof(UnityEngine.ComputeBuffer), typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetComputeBufferData_ComputeBuffer_Array_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetComputeBufferData[T](UnityEngine.ComputeBuffer, System.Collections.Generic.List`1[T], Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetComputeBufferData_GT_ComputeBuffer_List_d_T_p__Int32_Int32_Int32;
		public virtual RMethod RMSetComputeBufferData_GT_ComputeBuffer_List_d_T_p__Int32_Int32_Int32
		{
			get
			{
				if(r_MSetComputeBufferData_GT_ComputeBuffer_List_d_T_p__Int32_Int32_Int32 == null)
				{
					r_MSetComputeBufferData_GT_ComputeBuffer_List_d_T_p__Int32_Int32_Int32 = new(this, "SetComputeBufferData", 1, typeof(UnityEngine.ComputeBuffer),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetComputeBufferData_GT_ComputeBuffer_List_d_T_p__Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetComputeBufferData[T](UnityEngine.ComputeBuffer, Unity.Collections.NativeArray`1[T], Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetComputeBufferData_GT_ComputeBuffer_NativeArray_d_T_p__Int32_Int32_Int32;
		public virtual RMethod RMSetComputeBufferData_GT_ComputeBuffer_NativeArray_d_T_p__Int32_Int32_Int32
		{
			get
			{
				if(r_MSetComputeBufferData_GT_ComputeBuffer_NativeArray_d_T_p__Int32_Int32_Int32 == null)
				{
					r_MSetComputeBufferData_GT_ComputeBuffer_NativeArray_d_T_p__Int32_Int32_Int32 = new(this, "SetComputeBufferData", 1, typeof(UnityEngine.ComputeBuffer),  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetComputeBufferData_GT_ComputeBuffer_NativeArray_d_T_p__Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetComputeBufferCounterValue(UnityEngine.ComputeBuffer, UInt32)
		/// </summary>
		protected RMethod r_MSetComputeBufferCounterValue_ComputeBuffer_UInt32;
		public virtual RMethod RMSetComputeBufferCounterValue_ComputeBuffer_UInt32
		{
			get
			{
				if(r_MSetComputeBufferCounterValue_ComputeBuffer_UInt32 == null)
				{
					r_MSetComputeBufferCounterValue_ComputeBuffer_UInt32 = new(this, "SetComputeBufferCounterValue", 0, typeof(UnityEngine.ComputeBuffer), typeof(System.UInt32));
				}
				return r_MSetComputeBufferCounterValue_ComputeBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void ConvertTexture_Internal_Injected(UnityEngine.Rendering.RenderTargetIdentifier ByRef, Int32, UnityEngine.Rendering.RenderTargetIdentifier ByRef, Int32)
		/// </summary>
		protected RMethod r_MConvertTexture_Internal_Injected_Ref_RenderTargetIdentifier_Int32_Ref_RenderTargetIdentifier_Int32;
		public virtual RMethod RMConvertTexture_Internal_Injected_Ref_RenderTargetIdentifier_Int32_Ref_RenderTargetIdentifier_Int32
		{
			get
			{
				if(r_MConvertTexture_Internal_Injected_Ref_RenderTargetIdentifier_Int32_Ref_RenderTargetIdentifier_Int32 == null)
				{
					r_MConvertTexture_Internal_Injected_Ref_RenderTargetIdentifier_Int32_Ref_RenderTargetIdentifier_Int32 = new(this, "ConvertTexture_Internal_Injected", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(System.Int32));
				}
				return r_MConvertTexture_Internal_Injected_Ref_RenderTargetIdentifier_Int32_Ref_RenderTargetIdentifier_Int32;
			}
		}

		/// <summary>
		/// Void SetComputeVectorParam_Injected(UnityEngine.ComputeShader, Int32, UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_MSetComputeVectorParam_Injected_ComputeShader_Int32_Ref_Vector4;
		public virtual RMethod RMSetComputeVectorParam_Injected_ComputeShader_Int32_Ref_Vector4
		{
			get
			{
				if(r_MSetComputeVectorParam_Injected_ComputeShader_Int32_Ref_Vector4 == null)
				{
					r_MSetComputeVectorParam_Injected_ComputeShader_Int32_Ref_Vector4 = new(this, "SetComputeVectorParam_Injected", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(UnityEngine.Vector4).MakeByRefType());
				}
				return r_MSetComputeVectorParam_Injected_ComputeShader_Int32_Ref_Vector4;
			}
		}

		/// <summary>
		/// Void SetComputeMatrixParam_Injected(UnityEngine.ComputeShader, Int32, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_MSetComputeMatrixParam_Injected_ComputeShader_Int32_Ref_Matrix4x4;
		public virtual RMethod RMSetComputeMatrixParam_Injected_ComputeShader_Int32_Ref_Matrix4x4
		{
			get
			{
				if(r_MSetComputeMatrixParam_Injected_ComputeShader_Int32_Ref_Matrix4x4 == null)
				{
					r_MSetComputeMatrixParam_Injected_ComputeShader_Int32_Ref_Matrix4x4 = new(this, "SetComputeMatrixParam_Injected", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeByRefType());
				}
				return r_MSetComputeMatrixParam_Injected_ComputeShader_Int32_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Void Internal_SetComputeGraphicsBufferHandleParam_Injected(UnityEngine.ComputeShader, Int32, Int32, UnityEngine.GraphicsBufferHandle ByRef)
		/// </summary>
		protected RMethod r_MInternal_SetComputeGraphicsBufferHandleParam_Injected_ComputeShader_Int32_Int32_Ref_GraphicsBufferHandle;
		public virtual RMethod RMInternal_SetComputeGraphicsBufferHandleParam_Injected_ComputeShader_Int32_Int32_Ref_GraphicsBufferHandle
		{
			get
			{
				if(r_MInternal_SetComputeGraphicsBufferHandleParam_Injected_ComputeShader_Int32_Int32_Ref_GraphicsBufferHandle == null)
				{
					r_MInternal_SetComputeGraphicsBufferHandleParam_Injected_ComputeShader_Int32_Int32_Ref_GraphicsBufferHandle = new(this, "Internal_SetComputeGraphicsBufferHandleParam_Injected", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.GraphicsBufferHandle).MakeByRefType());
				}
				return r_MInternal_SetComputeGraphicsBufferHandleParam_Injected_ComputeShader_Int32_Int32_Ref_GraphicsBufferHandle;
			}
		}

		/// <summary>
		/// Void Internal_SetRayTracingVectorParam_Injected(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_MInternal_SetRayTracingVectorParam_Injected_RayTracingShader_Int32_Ref_Vector4;
		public virtual RMethod RMInternal_SetRayTracingVectorParam_Injected_RayTracingShader_Int32_Ref_Vector4
		{
			get
			{
				if(r_MInternal_SetRayTracingVectorParam_Injected_RayTracingShader_Int32_Ref_Vector4 == null)
				{
					r_MInternal_SetRayTracingVectorParam_Injected_RayTracingShader_Int32_Ref_Vector4 = new(this, "Internal_SetRayTracingVectorParam_Injected", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.Vector4).MakeByRefType());
				}
				return r_MInternal_SetRayTracingVectorParam_Injected_RayTracingShader_Int32_Ref_Vector4;
			}
		}

		/// <summary>
		/// Void Internal_SetRayTracingMatrixParam_Injected(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_MInternal_SetRayTracingMatrixParam_Injected_RayTracingShader_Int32_Ref_Matrix4x4;
		public virtual RMethod RMInternal_SetRayTracingMatrixParam_Injected_RayTracingShader_Int32_Ref_Matrix4x4
		{
			get
			{
				if(r_MInternal_SetRayTracingMatrixParam_Injected_RayTracingShader_Int32_Ref_Matrix4x4 == null)
				{
					r_MInternal_SetRayTracingMatrixParam_Injected_RayTracingShader_Int32_Ref_Matrix4x4 = new(this, "Internal_SetRayTracingMatrixParam_Injected", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeByRefType());
				}
				return r_MInternal_SetRayTracingMatrixParam_Injected_RayTracingShader_Int32_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Void Internal_BuildRayTracingAccelerationStructure_Injected(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_MInternal_BuildRayTracingAccelerationStructure_Injected_RayTracingAccelerationStructure_Ref_Vector3;
		public virtual RMethod RMInternal_BuildRayTracingAccelerationStructure_Injected_RayTracingAccelerationStructure_Ref_Vector3
		{
			get
			{
				if(r_MInternal_BuildRayTracingAccelerationStructure_Injected_RayTracingAccelerationStructure_Ref_Vector3 == null)
				{
					r_MInternal_BuildRayTracingAccelerationStructure_Injected_RayTracingAccelerationStructure_Ref_Vector3 = new(this, "Internal_BuildRayTracingAccelerationStructure_Injected", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure), typeof(UnityEngine.Vector3).MakeByRefType());
				}
				return r_MInternal_BuildRayTracingAccelerationStructure_Injected_RayTracingAccelerationStructure_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void Internal_GenerateMips_Injected(UnityEngine.Rendering.RenderTargetIdentifier ByRef)
		/// </summary>
		protected RMethod r_MInternal_GenerateMips_Injected_Ref_RenderTargetIdentifier;
		public virtual RMethod RMInternal_GenerateMips_Injected_Ref_RenderTargetIdentifier
		{
			get
			{
				if(r_MInternal_GenerateMips_Injected_Ref_RenderTargetIdentifier == null)
				{
					r_MInternal_GenerateMips_Injected_Ref_RenderTargetIdentifier = new(this, "Internal_GenerateMips_Injected", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType());
				}
				return r_MInternal_GenerateMips_Injected_Ref_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void Internal_DrawMesh_Injected(UnityEngine.Mesh, UnityEngine.Matrix4x4 ByRef, UnityEngine.Material, Int32, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MInternal_DrawMesh_Injected_Mesh_Ref_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock;
		public virtual RMethod RMInternal_DrawMesh_Injected_Mesh_Ref_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_MInternal_DrawMesh_Injected_Mesh_Ref_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock == null)
				{
					r_MInternal_DrawMesh_Injected_Mesh_Ref_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock = new(this, "Internal_DrawMesh_Injected", 0, typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Material), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
				}
				return r_MInternal_DrawMesh_Injected_Mesh_Ref_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawRendererList_Injected(UnityEngine.Rendering.RendererList ByRef)
		/// </summary>
		protected RMethod r_MInternal_DrawRendererList_Injected_Ref_RendererList;
		public virtual RMethod RMInternal_DrawRendererList_Injected_Ref_RendererList
		{
			get
			{
				if(r_MInternal_DrawRendererList_Injected_Ref_RendererList == null)
				{
					r_MInternal_DrawRendererList_Injected_Ref_RendererList = new(this, "Internal_DrawRendererList_Injected", 0, typeof(UnityEngine.Rendering.RendererList).MakeByRefType());
				}
				return r_MInternal_DrawRendererList_Injected_Ref_RendererList;
			}
		}

		/// <summary>
		/// Void Internal_DrawProcedural_Injected(UnityEngine.Matrix4x4 ByRef, UnityEngine.Material, Int32, UnityEngine.MeshTopology, Int32, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MInternal_DrawProcedural_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock;
		public virtual RMethod RMInternal_DrawProcedural_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_MInternal_DrawProcedural_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock == null)
				{
					r_MInternal_DrawProcedural_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock = new(this, "Internal_DrawProcedural_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
				}
				return r_MInternal_DrawProcedural_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawProceduralIndexed_Injected(UnityEngine.GraphicsBuffer, UnityEngine.Matrix4x4 ByRef, UnityEngine.Material, Int32, UnityEngine.MeshTopology, Int32, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MInternal_DrawProceduralIndexed_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock;
		public virtual RMethod RMInternal_DrawProceduralIndexed_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_MInternal_DrawProceduralIndexed_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock == null)
				{
					r_MInternal_DrawProceduralIndexed_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock = new(this, "Internal_DrawProceduralIndexed_Injected", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
				}
				return r_MInternal_DrawProceduralIndexed_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawProceduralIndirect_Injected(UnityEngine.Matrix4x4 ByRef, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.ComputeBuffer, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MInternal_DrawProceduralIndirect_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock;
		public virtual RMethod RMInternal_DrawProceduralIndirect_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_MInternal_DrawProceduralIndirect_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock == null)
				{
					r_MInternal_DrawProceduralIndirect_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock = new(this, "Internal_DrawProceduralIndirect_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
				}
				return r_MInternal_DrawProceduralIndirect_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawProceduralIndexedIndirect_Injected(UnityEngine.GraphicsBuffer, UnityEngine.Matrix4x4 ByRef, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.ComputeBuffer, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MInternal_DrawProceduralIndexedIndirect_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock;
		public virtual RMethod RMInternal_DrawProceduralIndexedIndirect_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_MInternal_DrawProceduralIndexedIndirect_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock == null)
				{
					r_MInternal_DrawProceduralIndexedIndirect_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock = new(this, "Internal_DrawProceduralIndexedIndirect_Injected", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
				}
				return r_MInternal_DrawProceduralIndexedIndirect_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawProceduralIndirectGraphicsBuffer_Injected(UnityEngine.Matrix4x4 ByRef, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.GraphicsBuffer, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MInternal_DrawProceduralIndirectGraphicsBuffer_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock;
		public virtual RMethod RMInternal_DrawProceduralIndirectGraphicsBuffer_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_MInternal_DrawProceduralIndirectGraphicsBuffer_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock == null)
				{
					r_MInternal_DrawProceduralIndirectGraphicsBuffer_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock = new(this, "Internal_DrawProceduralIndirectGraphicsBuffer_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
				}
				return r_MInternal_DrawProceduralIndirectGraphicsBuffer_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected(UnityEngine.GraphicsBuffer, UnityEngine.Matrix4x4 ByRef, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.GraphicsBuffer, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MInternal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock;
		public virtual RMethod RMInternal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_MInternal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock == null)
				{
					r_MInternal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock = new(this, "Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
				}
				return r_MInternal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawOcclusionMesh_Injected(UnityEngine.RectInt ByRef)
		/// </summary>
		protected RMethod r_MInternal_DrawOcclusionMesh_Injected_Ref_RectInt;
		public virtual RMethod RMInternal_DrawOcclusionMesh_Injected_Ref_RectInt
		{
			get
			{
				if(r_MInternal_DrawOcclusionMesh_Injected_Ref_RectInt == null)
				{
					r_MInternal_DrawOcclusionMesh_Injected_Ref_RectInt = new(this, "Internal_DrawOcclusionMesh_Injected", 0, typeof(UnityEngine.RectInt).MakeByRefType());
				}
				return r_MInternal_DrawOcclusionMesh_Injected_Ref_RectInt;
			}
		}

		/// <summary>
		/// Void SetViewport_Injected(UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_MSetViewport_Injected_Ref_Rect;
		public virtual RMethod RMSetViewport_Injected_Ref_Rect
		{
			get
			{
				if(r_MSetViewport_Injected_Ref_Rect == null)
				{
					r_MSetViewport_Injected_Ref_Rect = new(this, "SetViewport_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType());
				}
				return r_MSetViewport_Injected_Ref_Rect;
			}
		}

		/// <summary>
		/// Void EnableScissorRect_Injected(UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_MEnableScissorRect_Injected_Ref_Rect;
		public virtual RMethod RMEnableScissorRect_Injected_Ref_Rect
		{
			get
			{
				if(r_MEnableScissorRect_Injected_Ref_Rect == null)
				{
					r_MEnableScissorRect_Injected_Ref_Rect = new(this, "EnableScissorRect_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType());
				}
				return r_MEnableScissorRect_Injected_Ref_Rect;
			}
		}

		/// <summary>
		/// Void Blit_Texture_Injected(UnityEngine.Texture, UnityEngine.Rendering.RenderTargetIdentifier ByRef, UnityEngine.Material, Int32, UnityEngine.Vector2 ByRef, UnityEngine.Vector2 ByRef, Int32, Int32)
		/// </summary>
		protected RMethod r_MBlit_Texture_Injected_Texture_Ref_RenderTargetIdentifier_Material_Int32_Ref_Vector2_Ref_Vector2_Int32_Int32;
		public virtual RMethod RMBlit_Texture_Injected_Texture_Ref_RenderTargetIdentifier_Material_Int32_Ref_Vector2_Ref_Vector2_Int32_Int32
		{
			get
			{
				if(r_MBlit_Texture_Injected_Texture_Ref_RenderTargetIdentifier_Material_Int32_Ref_Vector2_Ref_Vector2_Int32_Int32 == null)
				{
					r_MBlit_Texture_Injected_Texture_Ref_RenderTargetIdentifier_Material_Int32_Ref_Vector2_Ref_Vector2_Int32_Int32 = new(this, "Blit_Texture_Injected", 0, typeof(UnityEngine.Texture), typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Vector2).MakeByRefType(), typeof(UnityEngine.Vector2).MakeByRefType(), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MBlit_Texture_Injected_Texture_Ref_RenderTargetIdentifier_Material_Int32_Ref_Vector2_Ref_Vector2_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Blit_Identifier_Injected(UnityEngine.Rendering.RenderTargetIdentifier ByRef, UnityEngine.Rendering.RenderTargetIdentifier ByRef, UnityEngine.Material, Int32, UnityEngine.Vector2 ByRef, UnityEngine.Vector2 ByRef, Int32, Int32)
		/// </summary>
		protected RMethod r_MBlit_Identifier_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_Material_Int32_Ref_Vector2_Ref_Vector2_Int32_Int32;
		public virtual RMethod RMBlit_Identifier_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_Material_Int32_Ref_Vector2_Ref_Vector2_Int32_Int32
		{
			get
			{
				if(r_MBlit_Identifier_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_Material_Int32_Ref_Vector2_Ref_Vector2_Int32_Int32 == null)
				{
					r_MBlit_Identifier_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_Material_Int32_Ref_Vector2_Ref_Vector2_Int32_Int32 = new(this, "Blit_Identifier_Injected", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Vector2).MakeByRefType(), typeof(UnityEngine.Vector2).MakeByRefType(), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MBlit_Identifier_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_Material_Int32_Ref_Vector2_Ref_Vector2_Int32_Int32;
			}
		}

		/// <summary>
		/// Void GetTemporaryRTWithDescriptor_Injected(Int32, UnityEngine.RenderTextureDescriptor ByRef, UnityEngine.FilterMode)
		/// </summary>
		protected RMethod r_MGetTemporaryRTWithDescriptor_Injected_Int32_Ref_RenderTextureDescriptor_FilterMode;
		public virtual RMethod RMGetTemporaryRTWithDescriptor_Injected_Int32_Ref_RenderTextureDescriptor_FilterMode
		{
			get
			{
				if(r_MGetTemporaryRTWithDescriptor_Injected_Int32_Ref_RenderTextureDescriptor_FilterMode == null)
				{
					r_MGetTemporaryRTWithDescriptor_Injected_Int32_Ref_RenderTextureDescriptor_FilterMode = new(this, "GetTemporaryRTWithDescriptor_Injected", 0, typeof(System.Int32), typeof(UnityEngine.RenderTextureDescriptor).MakeByRefType(), typeof(UnityEngine.FilterMode));
				}
				return r_MGetTemporaryRTWithDescriptor_Injected_Int32_Ref_RenderTextureDescriptor_FilterMode;
			}
		}

		/// <summary>
		/// Void ClearRenderTarget_Injected(UnityEngine.Rendering.RTClearFlags, UnityEngine.Color ByRef, Single, UInt32)
		/// </summary>
		protected RMethod r_MClearRenderTarget_Injected_RTClearFlags_Ref_Color_Single_UInt32;
		public virtual RMethod RMClearRenderTarget_Injected_RTClearFlags_Ref_Color_Single_UInt32
		{
			get
			{
				if(r_MClearRenderTarget_Injected_RTClearFlags_Ref_Color_Single_UInt32 == null)
				{
					r_MClearRenderTarget_Injected_RTClearFlags_Ref_Color_Single_UInt32 = new(this, "ClearRenderTarget_Injected", 0, typeof(UnityEngine.Rendering.RTClearFlags), typeof(UnityEngine.Color).MakeByRefType(), typeof(System.Single), typeof(System.UInt32));
				}
				return r_MClearRenderTarget_Injected_RTClearFlags_Ref_Color_Single_UInt32;
			}
		}

		/// <summary>
		/// Void SetGlobalVector_Injected(Int32, UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_MSetGlobalVector_Injected_Int32_Ref_Vector4;
		public virtual RMethod RMSetGlobalVector_Injected_Int32_Ref_Vector4
		{
			get
			{
				if(r_MSetGlobalVector_Injected_Int32_Ref_Vector4 == null)
				{
					r_MSetGlobalVector_Injected_Int32_Ref_Vector4 = new(this, "SetGlobalVector_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeByRefType());
				}
				return r_MSetGlobalVector_Injected_Int32_Ref_Vector4;
			}
		}

		/// <summary>
		/// Void SetGlobalColor_Injected(Int32, UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_MSetGlobalColor_Injected_Int32_Ref_Color;
		public virtual RMethod RMSetGlobalColor_Injected_Int32_Ref_Color
		{
			get
			{
				if(r_MSetGlobalColor_Injected_Int32_Ref_Color == null)
				{
					r_MSetGlobalColor_Injected_Int32_Ref_Color = new(this, "SetGlobalColor_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Color).MakeByRefType());
				}
				return r_MSetGlobalColor_Injected_Int32_Ref_Color;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrix_Injected(Int32, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_MSetGlobalMatrix_Injected_Int32_Ref_Matrix4x4;
		public virtual RMethod RMSetGlobalMatrix_Injected_Int32_Ref_Matrix4x4
		{
			get
			{
				if(r_MSetGlobalMatrix_Injected_Int32_Ref_Matrix4x4 == null)
				{
					r_MSetGlobalMatrix_Injected_Int32_Ref_Matrix4x4 = new(this, "SetGlobalMatrix_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeByRefType());
				}
				return r_MSetGlobalMatrix_Injected_Int32_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Void EnableGlobalKeyword_Injected(UnityEngine.Rendering.GlobalKeyword ByRef)
		/// </summary>
		protected RMethod r_MEnableGlobalKeyword_Injected_Ref_GlobalKeyword;
		public virtual RMethod RMEnableGlobalKeyword_Injected_Ref_GlobalKeyword
		{
			get
			{
				if(r_MEnableGlobalKeyword_Injected_Ref_GlobalKeyword == null)
				{
					r_MEnableGlobalKeyword_Injected_Ref_GlobalKeyword = new(this, "EnableGlobalKeyword_Injected", 0, typeof(UnityEngine.Rendering.GlobalKeyword).MakeByRefType());
				}
				return r_MEnableGlobalKeyword_Injected_Ref_GlobalKeyword;
			}
		}

		/// <summary>
		/// Void EnableMaterialKeyword_Injected(UnityEngine.Material, UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_MEnableMaterialKeyword_Injected_Material_Ref_LocalKeyword;
		public virtual RMethod RMEnableMaterialKeyword_Injected_Material_Ref_LocalKeyword
		{
			get
			{
				if(r_MEnableMaterialKeyword_Injected_Material_Ref_LocalKeyword == null)
				{
					r_MEnableMaterialKeyword_Injected_Material_Ref_LocalKeyword = new(this, "EnableMaterialKeyword_Injected", 0, typeof(UnityEngine.Material), typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
				}
				return r_MEnableMaterialKeyword_Injected_Material_Ref_LocalKeyword;
			}
		}

		/// <summary>
		/// Void EnableComputeKeyword_Injected(UnityEngine.ComputeShader, UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_MEnableComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword;
		public virtual RMethod RMEnableComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword
		{
			get
			{
				if(r_MEnableComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword == null)
				{
					r_MEnableComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword = new(this, "EnableComputeKeyword_Injected", 0, typeof(UnityEngine.ComputeShader), typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
				}
				return r_MEnableComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword;
			}
		}

		/// <summary>
		/// Void DisableGlobalKeyword_Injected(UnityEngine.Rendering.GlobalKeyword ByRef)
		/// </summary>
		protected RMethod r_MDisableGlobalKeyword_Injected_Ref_GlobalKeyword;
		public virtual RMethod RMDisableGlobalKeyword_Injected_Ref_GlobalKeyword
		{
			get
			{
				if(r_MDisableGlobalKeyword_Injected_Ref_GlobalKeyword == null)
				{
					r_MDisableGlobalKeyword_Injected_Ref_GlobalKeyword = new(this, "DisableGlobalKeyword_Injected", 0, typeof(UnityEngine.Rendering.GlobalKeyword).MakeByRefType());
				}
				return r_MDisableGlobalKeyword_Injected_Ref_GlobalKeyword;
			}
		}

		/// <summary>
		/// Void DisableMaterialKeyword_Injected(UnityEngine.Material, UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_MDisableMaterialKeyword_Injected_Material_Ref_LocalKeyword;
		public virtual RMethod RMDisableMaterialKeyword_Injected_Material_Ref_LocalKeyword
		{
			get
			{
				if(r_MDisableMaterialKeyword_Injected_Material_Ref_LocalKeyword == null)
				{
					r_MDisableMaterialKeyword_Injected_Material_Ref_LocalKeyword = new(this, "DisableMaterialKeyword_Injected", 0, typeof(UnityEngine.Material), typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
				}
				return r_MDisableMaterialKeyword_Injected_Material_Ref_LocalKeyword;
			}
		}

		/// <summary>
		/// Void DisableComputeKeyword_Injected(UnityEngine.ComputeShader, UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_MDisableComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword;
		public virtual RMethod RMDisableComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword
		{
			get
			{
				if(r_MDisableComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword == null)
				{
					r_MDisableComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword = new(this, "DisableComputeKeyword_Injected", 0, typeof(UnityEngine.ComputeShader), typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
				}
				return r_MDisableComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword;
			}
		}

		/// <summary>
		/// Void SetGlobalKeyword_Injected(UnityEngine.Rendering.GlobalKeyword ByRef, Boolean)
		/// </summary>
		protected RMethod r_MSetGlobalKeyword_Injected_Ref_GlobalKeyword_Boolean;
		public virtual RMethod RMSetGlobalKeyword_Injected_Ref_GlobalKeyword_Boolean
		{
			get
			{
				if(r_MSetGlobalKeyword_Injected_Ref_GlobalKeyword_Boolean == null)
				{
					r_MSetGlobalKeyword_Injected_Ref_GlobalKeyword_Boolean = new(this, "SetGlobalKeyword_Injected", 0, typeof(UnityEngine.Rendering.GlobalKeyword).MakeByRefType(), typeof(System.Boolean));
				}
				return r_MSetGlobalKeyword_Injected_Ref_GlobalKeyword_Boolean;
			}
		}

		/// <summary>
		/// Void SetMaterialKeyword_Injected(UnityEngine.Material, UnityEngine.Rendering.LocalKeyword ByRef, Boolean)
		/// </summary>
		protected RMethod r_MSetMaterialKeyword_Injected_Material_Ref_LocalKeyword_Boolean;
		public virtual RMethod RMSetMaterialKeyword_Injected_Material_Ref_LocalKeyword_Boolean
		{
			get
			{
				if(r_MSetMaterialKeyword_Injected_Material_Ref_LocalKeyword_Boolean == null)
				{
					r_MSetMaterialKeyword_Injected_Material_Ref_LocalKeyword_Boolean = new(this, "SetMaterialKeyword_Injected", 0, typeof(UnityEngine.Material), typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType(), typeof(System.Boolean));
				}
				return r_MSetMaterialKeyword_Injected_Material_Ref_LocalKeyword_Boolean;
			}
		}

		/// <summary>
		/// Void SetComputeKeyword_Injected(UnityEngine.ComputeShader, UnityEngine.Rendering.LocalKeyword ByRef, Boolean)
		/// </summary>
		protected RMethod r_MSetComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword_Boolean;
		public virtual RMethod RMSetComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword_Boolean
		{
			get
			{
				if(r_MSetComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword_Boolean == null)
				{
					r_MSetComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword_Boolean = new(this, "SetComputeKeyword_Injected", 0, typeof(UnityEngine.ComputeShader), typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType(), typeof(System.Boolean));
				}
				return r_MSetComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword_Boolean;
			}
		}

		/// <summary>
		/// Void SetViewMatrix_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_MSetViewMatrix_Injected_Ref_Matrix4x4;
		public virtual RMethod RMSetViewMatrix_Injected_Ref_Matrix4x4
		{
			get
			{
				if(r_MSetViewMatrix_Injected_Ref_Matrix4x4 == null)
				{
					r_MSetViewMatrix_Injected_Ref_Matrix4x4 = new(this, "SetViewMatrix_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
				}
				return r_MSetViewMatrix_Injected_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetProjectionMatrix_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_MSetProjectionMatrix_Injected_Ref_Matrix4x4;
		public virtual RMethod RMSetProjectionMatrix_Injected_Ref_Matrix4x4
		{
			get
			{
				if(r_MSetProjectionMatrix_Injected_Ref_Matrix4x4 == null)
				{
					r_MSetProjectionMatrix_Injected_Ref_Matrix4x4 = new(this, "SetProjectionMatrix_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
				}
				return r_MSetProjectionMatrix_Injected_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetViewProjectionMatrices_Injected(UnityEngine.Matrix4x4 ByRef, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_MSetViewProjectionMatrices_Injected_Ref_Matrix4x4_Ref_Matrix4x4;
		public virtual RMethod RMSetViewProjectionMatrices_Injected_Ref_Matrix4x4_Ref_Matrix4x4
		{
			get
			{
				if(r_MSetViewProjectionMatrices_Injected_Ref_Matrix4x4_Ref_Matrix4x4 == null)
				{
					r_MSetViewProjectionMatrices_Injected_Ref_Matrix4x4_Ref_Matrix4x4 = new(this, "SetViewProjectionMatrices_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Matrix4x4).MakeByRefType());
				}
				return r_MSetViewProjectionMatrices_Injected_Ref_Matrix4x4_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Void IncrementUpdateCount_Injected(UnityEngine.Rendering.RenderTargetIdentifier ByRef)
		/// </summary>
		protected RMethod r_MIncrementUpdateCount_Injected_Ref_RenderTargetIdentifier;
		public virtual RMethod RMIncrementUpdateCount_Injected_Ref_RenderTargetIdentifier
		{
			get
			{
				if(r_MIncrementUpdateCount_Injected_Ref_RenderTargetIdentifier == null)
				{
					r_MIncrementUpdateCount_Injected_Ref_RenderTargetIdentifier = new(this, "IncrementUpdateCount_Injected", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType());
				}
				return r_MIncrementUpdateCount_Injected_Ref_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void SetRenderTargetSingle_Internal_Injected(UnityEngine.Rendering.RenderTargetIdentifier ByRef, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction)
		/// </summary>
		protected RMethod r_MSetRenderTargetSingle_Internal_Injected_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction;
		public virtual RMethod RMSetRenderTargetSingle_Internal_Injected_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction
		{
			get
			{
				if(r_MSetRenderTargetSingle_Internal_Injected_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction == null)
				{
					r_MSetRenderTargetSingle_Internal_Injected_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction = new(this, "SetRenderTargetSingle_Internal_Injected", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction));
				}
				return r_MSetRenderTargetSingle_Internal_Injected_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction;
			}
		}

		/// <summary>
		/// Void SetRenderTargetColorDepth_Internal_Injected(UnityEngine.Rendering.RenderTargetIdentifier ByRef, UnityEngine.Rendering.RenderTargetIdentifier ByRef, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, UnityEngine.Rendering.RenderTargetFlags)
		/// </summary>
		protected RMethod r_MSetRenderTargetColorDepth_Internal_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags;
		public virtual RMethod RMSetRenderTargetColorDepth_Internal_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags
		{
			get
			{
				if(r_MSetRenderTargetColorDepth_Internal_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags == null)
				{
					r_MSetRenderTargetColorDepth_Internal_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags = new(this, "SetRenderTargetColorDepth_Internal_Injected", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction), typeof(UnityEngine.Rendering.RenderTargetFlags));
				}
				return r_MSetRenderTargetColorDepth_Internal_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags;
			}
		}

		/// <summary>
		/// Void SetRenderTargetMulti_Internal_Injected(UnityEngine.Rendering.RenderTargetIdentifier[], UnityEngine.Rendering.RenderTargetIdentifier ByRef, UnityEngine.Rendering.RenderBufferLoadAction[], UnityEngine.Rendering.RenderBufferStoreAction[], UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, UnityEngine.Rendering.RenderTargetFlags)
		/// </summary>
		protected RMethod r_MSetRenderTargetMulti_Internal_Injected_RenderTargetIdentifierArray_Ref_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags;
		public virtual RMethod RMSetRenderTargetMulti_Internal_Injected_RenderTargetIdentifierArray_Ref_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags
		{
			get
			{
				if(r_MSetRenderTargetMulti_Internal_Injected_RenderTargetIdentifierArray_Ref_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags == null)
				{
					r_MSetRenderTargetMulti_Internal_Injected_RenderTargetIdentifierArray_Ref_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags = new(this, "SetRenderTargetMulti_Internal_Injected", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeArrayType(), typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(UnityEngine.Rendering.RenderBufferLoadAction).MakeArrayType(), typeof(UnityEngine.Rendering.RenderBufferStoreAction).MakeArrayType(), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction), typeof(UnityEngine.Rendering.RenderTargetFlags));
				}
				return r_MSetRenderTargetMulti_Internal_Injected_RenderTargetIdentifierArray_Ref_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags;
			}
		}

		/// <summary>
		/// Void SetRenderTargetColorDepthSubtarget_Injected(UnityEngine.Rendering.RenderTargetIdentifier ByRef, UnityEngine.Rendering.RenderTargetIdentifier ByRef, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, Int32, UnityEngine.CubemapFace, Int32)
		/// </summary>
		protected RMethod r_MSetRenderTargetColorDepthSubtarget_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32;
		public virtual RMethod RMSetRenderTargetColorDepthSubtarget_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32
		{
			get
			{
				if(r_MSetRenderTargetColorDepthSubtarget_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32 == null)
				{
					r_MSetRenderTargetColorDepthSubtarget_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32 = new(this, "SetRenderTargetColorDepthSubtarget_Injected", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction), typeof(System.Int32), typeof(UnityEngine.CubemapFace), typeof(System.Int32));
				}
				return r_MSetRenderTargetColorDepthSubtarget_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32;
			}
		}

		/// <summary>
		/// Void SetRenderTargetMultiSubtarget_Injected(UnityEngine.Rendering.RenderTargetIdentifier[], UnityEngine.Rendering.RenderTargetIdentifier ByRef, UnityEngine.Rendering.RenderBufferLoadAction[], UnityEngine.Rendering.RenderBufferStoreAction[], UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, Int32, UnityEngine.CubemapFace, Int32)
		/// </summary>
		protected RMethod r_MSetRenderTargetMultiSubtarget_Injected_RenderTargetIdentifierArray_Ref_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32;
		public virtual RMethod RMSetRenderTargetMultiSubtarget_Injected_RenderTargetIdentifierArray_Ref_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32
		{
			get
			{
				if(r_MSetRenderTargetMultiSubtarget_Injected_RenderTargetIdentifierArray_Ref_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32 == null)
				{
					r_MSetRenderTargetMultiSubtarget_Injected_RenderTargetIdentifierArray_Ref_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32 = new(this, "SetRenderTargetMultiSubtarget_Injected", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeArrayType(), typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(UnityEngine.Rendering.RenderBufferLoadAction).MakeArrayType(), typeof(UnityEngine.Rendering.RenderBufferStoreAction).MakeArrayType(), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction), typeof(System.Int32), typeof(UnityEngine.CubemapFace), typeof(System.Int32));
				}
				return r_MSetRenderTargetMultiSubtarget_Injected_RenderTargetIdentifierArray_Ref_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32;
			}
		}

		/// <summary>
		/// Void Internal_ProcessVTFeedback_Injected(UnityEngine.Rendering.RenderTargetIdentifier ByRef, IntPtr, Int32, Int32, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MInternal_ProcessVTFeedback_Injected_Ref_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32;
		public virtual RMethod RMInternal_ProcessVTFeedback_Injected_Ref_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MInternal_ProcessVTFeedback_Injected_Ref_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32 == null)
				{
					r_MInternal_ProcessVTFeedback_Injected_Ref_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32 = new(this, "Internal_ProcessVTFeedback_Injected", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MInternal_ProcessVTFeedback_Injected_Ref_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32;
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


        public virtual void ConvertTexture(UnityEngine.Rendering.RenderTargetIdentifier @src, UnityEngine.Rendering.RenderTargetIdentifier @dst)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst};
            var ___result = RMConvertTexture_RenderTargetIdentifier_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ConvertTexture(UnityEngine.Rendering.RenderTargetIdentifier @src, System.Int32 @srcElement, UnityEngine.Rendering.RenderTargetIdentifier @dst, System.Int32 @dstElement)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @srcElement, @dst, @dstElement};
            var ___result = RMConvertTexture_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WaitAllAsyncReadbackRequests()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMWaitAllAsyncReadbackRequests.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestAsyncReadback(UnityEngine.ComputeBuffer @src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @callback};
            var ___result = RMRequestAsyncReadback_ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestAsyncReadback(UnityEngine.GraphicsBuffer @src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @callback};
            var ___result = RMRequestAsyncReadback_GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestAsyncReadback(UnityEngine.ComputeBuffer @src, System.Int32 @size, System.Int32 @offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @size, @offset, @callback};
            var ___result = RMRequestAsyncReadback_ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestAsyncReadback(UnityEngine.GraphicsBuffer @src, System.Int32 @size, System.Int32 @offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @size, @offset, @callback};
            var ___result = RMRequestAsyncReadback_GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestAsyncReadback(UnityEngine.Texture @src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @callback};
            var ___result = RMRequestAsyncReadback_Texture_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestAsyncReadback(UnityEngine.Texture @src, System.Int32 @mipIndex, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @mipIndex, @callback};
            var ___result = RMRequestAsyncReadback_Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestAsyncReadback(UnityEngine.Texture @src, System.Int32 @mipIndex, UnityEngine.TextureFormat @dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @mipIndex, @dstFormat, @callback};
            var ___result = RMRequestAsyncReadback_Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestAsyncReadback(UnityEngine.Texture @src, System.Int32 @mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat @dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @mipIndex, @dstFormat, @callback};
            var ___result = RMRequestAsyncReadback_Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestAsyncReadback(UnityEngine.Texture @src, System.Int32 @mipIndex, System.Int32 @x, System.Int32 @width, System.Int32 @y, System.Int32 @height, System.Int32 @z, System.Int32 @depth, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @mipIndex, @x, @width, @y, @height, @z, @depth, @callback};
            var ___result = RMRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestAsyncReadback(UnityEngine.Texture @src, System.Int32 @mipIndex, System.Int32 @x, System.Int32 @width, System.Int32 @y, System.Int32 @height, System.Int32 @z, System.Int32 @depth, UnityEngine.TextureFormat @dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @mipIndex, @x, @width, @y, @height, @z, @depth, @dstFormat, @callback};
            var ___result = RMRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestAsyncReadback(UnityEngine.Texture @src, System.Int32 @mipIndex, System.Int32 @x, System.Int32 @width, System.Int32 @y, System.Int32 @height, System.Int32 @z, System.Int32 @depth, UnityEngine.Experimental.Rendering.GraphicsFormat @dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @mipIndex, @x, @width, @y, @height, @z, @depth, @dstFormat, @callback};
            var ___result = RMRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestAsyncReadbackIntoNativeArray<T>(ref Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @output, UnityEngine.ComputeBuffer @src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@output.Value, @src, @callback};
            var ___result = RMRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);
			@output = new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>(___parameters[0]);

            
        }


        public virtual void RequestAsyncReadbackIntoNativeArray<T>(ref Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @output, UnityEngine.ComputeBuffer @src, System.Int32 @size, System.Int32 @offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@output.Value, @src, @size, @offset, @callback};
            var ___result = RMRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);
			@output = new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>(___parameters[0]);

            
        }


        public virtual void RequestAsyncReadbackIntoNativeArray<T>(ref Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @output, UnityEngine.GraphicsBuffer @src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@output.Value, @src, @callback};
            var ___result = RMRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);
			@output = new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>(___parameters[0]);

            
        }


        public virtual void RequestAsyncReadbackIntoNativeArray<T>(ref Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @output, UnityEngine.GraphicsBuffer @src, System.Int32 @size, System.Int32 @offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@output.Value, @src, @size, @offset, @callback};
            var ___result = RMRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);
			@output = new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>(___parameters[0]);

            
        }


        public virtual void RequestAsyncReadbackIntoNativeArray<T>(ref Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @output, UnityEngine.Texture @src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@output.Value, @src, @callback};
            var ___result = RMRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);
			@output = new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>(___parameters[0]);

            
        }


        public virtual void RequestAsyncReadbackIntoNativeArray<T>(ref Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @output, UnityEngine.Texture @src, System.Int32 @mipIndex, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@output.Value, @src, @mipIndex, @callback};
            var ___result = RMRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);
			@output = new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>(___parameters[0]);

            
        }


        public virtual void RequestAsyncReadbackIntoNativeArray<T>(ref Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @output, UnityEngine.Texture @src, System.Int32 @mipIndex, UnityEngine.TextureFormat @dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@output.Value, @src, @mipIndex, @dstFormat, @callback};
            var ___result = RMRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);
			@output = new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>(___parameters[0]);

            
        }


        public virtual void RequestAsyncReadbackIntoNativeArray<T>(ref Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @output, UnityEngine.Texture @src, System.Int32 @mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat @dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@output.Value, @src, @mipIndex, @dstFormat, @callback};
            var ___result = RMRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);
			@output = new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>(___parameters[0]);

            
        }


        public virtual void RequestAsyncReadbackIntoNativeArray<T>(ref Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @output, UnityEngine.Texture @src, System.Int32 @mipIndex, System.Int32 @x, System.Int32 @width, System.Int32 @y, System.Int32 @height, System.Int32 @z, System.Int32 @depth, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@output.Value, @src, @mipIndex, @x, @width, @y, @height, @z, @depth, @callback};
            var ___result = RMRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);
			@output = new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>(___parameters[0]);

            
        }


        public virtual void RequestAsyncReadbackIntoNativeArray<T>(ref Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @output, UnityEngine.Texture @src, System.Int32 @mipIndex, System.Int32 @x, System.Int32 @width, System.Int32 @y, System.Int32 @height, System.Int32 @z, System.Int32 @depth, UnityEngine.TextureFormat @dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@output.Value, @src, @mipIndex, @x, @width, @y, @height, @z, @depth, @dstFormat, @callback};
            var ___result = RMRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);
			@output = new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>(___parameters[0]);

            
        }


        public virtual void RequestAsyncReadbackIntoNativeArray<T>(ref Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @output, UnityEngine.Texture @src, System.Int32 @mipIndex, System.Int32 @x, System.Int32 @width, System.Int32 @y, System.Int32 @height, System.Int32 @z, System.Int32 @depth, UnityEngine.Experimental.Rendering.GraphicsFormat @dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@output.Value, @src, @mipIndex, @x, @width, @y, @height, @z, @depth, @dstFormat, @callback};
            var ___result = RMRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);
			@output = new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>(___parameters[0]);

            
        }


        public virtual void RequestAsyncReadbackIntoNativeSlice<T>(ref Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType> @output, UnityEngine.ComputeBuffer @src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@output.Value, @src, @callback};
            var ___result = RMRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);
			@output = new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType>(___parameters[0]);

            
        }


        public virtual void RequestAsyncReadbackIntoNativeSlice<T>(ref Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType> @output, UnityEngine.ComputeBuffer @src, System.Int32 @size, System.Int32 @offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@output.Value, @src, @size, @offset, @callback};
            var ___result = RMRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);
			@output = new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType>(___parameters[0]);

            
        }


        public virtual void RequestAsyncReadbackIntoNativeSlice<T>(ref Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType> @output, UnityEngine.GraphicsBuffer @src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@output.Value, @src, @callback};
            var ___result = RMRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);
			@output = new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType>(___parameters[0]);

            
        }


        public virtual void RequestAsyncReadbackIntoNativeSlice<T>(ref Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType> @output, UnityEngine.GraphicsBuffer @src, System.Int32 @size, System.Int32 @offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@output.Value, @src, @size, @offset, @callback};
            var ___result = RMRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);
			@output = new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType>(___parameters[0]);

            
        }


        public virtual void RequestAsyncReadbackIntoNativeSlice<T>(ref Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType> @output, UnityEngine.Texture @src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@output.Value, @src, @callback};
            var ___result = RMRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);
			@output = new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType>(___parameters[0]);

            
        }


        public virtual void RequestAsyncReadbackIntoNativeSlice<T>(ref Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType> @output, UnityEngine.Texture @src, System.Int32 @mipIndex, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@output.Value, @src, @mipIndex, @callback};
            var ___result = RMRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);
			@output = new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType>(___parameters[0]);

            
        }


        public virtual void RequestAsyncReadbackIntoNativeSlice<T>(ref Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType> @output, UnityEngine.Texture @src, System.Int32 @mipIndex, UnityEngine.TextureFormat @dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@output.Value, @src, @mipIndex, @dstFormat, @callback};
            var ___result = RMRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);
			@output = new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType>(___parameters[0]);

            
        }


        public virtual void RequestAsyncReadbackIntoNativeSlice<T>(ref Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType> @output, UnityEngine.Texture @src, System.Int32 @mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat @dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@output.Value, @src, @mipIndex, @dstFormat, @callback};
            var ___result = RMRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);
			@output = new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType>(___parameters[0]);

            
        }


        public virtual void RequestAsyncReadbackIntoNativeSlice<T>(ref Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType> @output, UnityEngine.Texture @src, System.Int32 @mipIndex, System.Int32 @x, System.Int32 @width, System.Int32 @y, System.Int32 @height, System.Int32 @z, System.Int32 @depth, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@output.Value, @src, @mipIndex, @x, @width, @y, @height, @z, @depth, @callback};
            var ___result = RMRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);
			@output = new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType>(___parameters[0]);

            
        }


        public virtual void RequestAsyncReadbackIntoNativeSlice<T>(ref Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType> @output, UnityEngine.Texture @src, System.Int32 @mipIndex, System.Int32 @x, System.Int32 @width, System.Int32 @y, System.Int32 @height, System.Int32 @z, System.Int32 @depth, UnityEngine.TextureFormat @dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@output.Value, @src, @mipIndex, @x, @width, @y, @height, @z, @depth, @dstFormat, @callback};
            var ___result = RMRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);
			@output = new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType>(___parameters[0]);

            
        }


        public virtual void RequestAsyncReadbackIntoNativeSlice<T>(ref Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType> @output, UnityEngine.Texture @src, System.Int32 @mipIndex, System.Int32 @x, System.Int32 @width, System.Int32 @y, System.Int32 @height, System.Int32 @z, System.Int32 @depth, UnityEngine.Experimental.Rendering.GraphicsFormat @dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@output.Value, @src, @mipIndex, @x, @width, @y, @height, @z, @depth, @dstFormat, @callback};
            var ___result = RMRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);
			@output = new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType>(___parameters[0]);

            
        }


        public unsafe virtual void Internal_RequestAsyncReadback_1(UnityEngine.ComputeBuffer @src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback, Hvak.Editor.Refleaction.RTypePointer<Hvak.Editor.Refleaction.RUnityEngine.RRendering.RAsyncRequestNativeArrayData> @nativeArrayData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @callback, @nativeArrayData.Value};
            var ___result = RMInternal_RequestAsyncReadback_1_ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe virtual void Internal_RequestAsyncReadback_2(UnityEngine.ComputeBuffer @src, System.Int32 @size, System.Int32 @offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback, Hvak.Editor.Refleaction.RTypePointer<Hvak.Editor.Refleaction.RUnityEngine.RRendering.RAsyncRequestNativeArrayData> @nativeArrayData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @size, @offset, @callback, @nativeArrayData.Value};
            var ___result = RMInternal_RequestAsyncReadback_2_ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe virtual void Internal_RequestAsyncReadback_3(UnityEngine.Texture @src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback, Hvak.Editor.Refleaction.RTypePointer<Hvak.Editor.Refleaction.RUnityEngine.RRendering.RAsyncRequestNativeArrayData> @nativeArrayData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @callback, @nativeArrayData.Value};
            var ___result = RMInternal_RequestAsyncReadback_3_Texture_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe virtual void Internal_RequestAsyncReadback_4(UnityEngine.Texture @src, System.Int32 @mipIndex, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback, Hvak.Editor.Refleaction.RTypePointer<Hvak.Editor.Refleaction.RUnityEngine.RRendering.RAsyncRequestNativeArrayData> @nativeArrayData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @mipIndex, @callback, @nativeArrayData.Value};
            var ___result = RMInternal_RequestAsyncReadback_4_Texture_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe virtual void Internal_RequestAsyncReadback_5(UnityEngine.Texture @src, System.Int32 @mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat @dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback, Hvak.Editor.Refleaction.RTypePointer<Hvak.Editor.Refleaction.RUnityEngine.RRendering.RAsyncRequestNativeArrayData> @nativeArrayData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @mipIndex, @dstFormat, @callback, @nativeArrayData.Value};
            var ___result = RMInternal_RequestAsyncReadback_5_Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe virtual void Internal_RequestAsyncReadback_6(UnityEngine.Texture @src, System.Int32 @mipIndex, System.Int32 @x, System.Int32 @width, System.Int32 @y, System.Int32 @height, System.Int32 @z, System.Int32 @depth, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback, Hvak.Editor.Refleaction.RTypePointer<Hvak.Editor.Refleaction.RUnityEngine.RRendering.RAsyncRequestNativeArrayData> @nativeArrayData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @mipIndex, @x, @width, @y, @height, @z, @depth, @callback, @nativeArrayData.Value};
            var ___result = RMInternal_RequestAsyncReadback_6_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe virtual void Internal_RequestAsyncReadback_7(UnityEngine.Texture @src, System.Int32 @mipIndex, System.Int32 @x, System.Int32 @width, System.Int32 @y, System.Int32 @height, System.Int32 @z, System.Int32 @depth, UnityEngine.Experimental.Rendering.GraphicsFormat @dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback, Hvak.Editor.Refleaction.RTypePointer<Hvak.Editor.Refleaction.RUnityEngine.RRendering.RAsyncRequestNativeArrayData> @nativeArrayData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @mipIndex, @x, @width, @y, @height, @z, @depth, @dstFormat, @callback, @nativeArrayData.Value};
            var ___result = RMInternal_RequestAsyncReadback_7_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe virtual void Internal_RequestAsyncReadback_8(UnityEngine.GraphicsBuffer @src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback, Hvak.Editor.Refleaction.RTypePointer<Hvak.Editor.Refleaction.RUnityEngine.RRendering.RAsyncRequestNativeArrayData> @nativeArrayData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @callback, @nativeArrayData.Value};
            var ___result = RMInternal_RequestAsyncReadback_8_GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe virtual void Internal_RequestAsyncReadback_9(UnityEngine.GraphicsBuffer @src, System.Int32 @size, System.Int32 @offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> @callback, Hvak.Editor.Refleaction.RTypePointer<Hvak.Editor.Refleaction.RUnityEngine.RRendering.RAsyncRequestNativeArrayData> @nativeArrayData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @size, @offset, @callback, @nativeArrayData.Value};
            var ___result = RMInternal_RequestAsyncReadback_9_GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInvertCulling(System.Boolean @invertCulling)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@invertCulling};
            var ___result = RMSetInvertCulling_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ConvertTexture_Internal(UnityEngine.Rendering.RenderTargetIdentifier @src, System.Int32 @srcElement, UnityEngine.Rendering.RenderTargetIdentifier @dst, System.Int32 @dstElement)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @srcElement, @dst, @dstElement};
            var ___result = RMConvertTexture_Internal_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetSinglePassStereo(UnityEngine.Rendering.SinglePassStereoMode @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mode};
            var ___result = RMInternal_SetSinglePassStereo_SinglePassStereoMode.Invoke(___genericsType, ___parameters);

            
        }


        public static System.IntPtr InitBuffer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitBuffer.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual System.IntPtr CreateGPUFence_Internal(UnityEngine.Rendering.GraphicsFenceType @fenceType, UnityEngine.Rendering.SynchronisationStageFlags @stage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fenceType, @stage};
            var ___result = RMCreateGPUFence_Internal_GraphicsFenceType_SynchronisationStageFlags.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual void WaitOnGPUFence_Internal(System.IntPtr @fencePtr, UnityEngine.Rendering.SynchronisationStageFlags @stage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fencePtr, @stage};
            var ___result = RMWaitOnGPUFence_Internal_IntPtr_SynchronisationStageFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReleaseBuffer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReleaseBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeFloatParam(UnityEngine.ComputeShader @computeShader, System.Int32 @nameID, System.Single @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @nameID, @val};
            var ___result = RMSetComputeFloatParam_ComputeShader_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeIntParam(UnityEngine.ComputeShader @computeShader, System.Int32 @nameID, System.Int32 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @nameID, @val};
            var ___result = RMSetComputeIntParam_ComputeShader_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeVectorParam(UnityEngine.ComputeShader @computeShader, System.Int32 @nameID, UnityEngine.Vector4 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @nameID, @val};
            var ___result = RMSetComputeVectorParam_ComputeShader_Int32_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeVectorArrayParam(UnityEngine.ComputeShader @computeShader, System.Int32 @nameID, UnityEngine.Vector4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @nameID, @values};
            var ___result = RMSetComputeVectorArrayParam_ComputeShader_Int32_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeMatrixParam(UnityEngine.ComputeShader @computeShader, System.Int32 @nameID, UnityEngine.Matrix4x4 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @nameID, @val};
            var ___result = RMSetComputeMatrixParam_ComputeShader_Int32_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeMatrixArrayParam(UnityEngine.ComputeShader @computeShader, System.Int32 @nameID, UnityEngine.Matrix4x4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @nameID, @values};
            var ___result = RMSetComputeMatrixArrayParam_ComputeShader_Int32_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetComputeFloats(UnityEngine.ComputeShader @computeShader, System.Int32 @nameID, System.Single[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @nameID, @values};
            var ___result = RMInternal_SetComputeFloats_ComputeShader_Int32_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetComputeInts(UnityEngine.ComputeShader @computeShader, System.Int32 @nameID, System.Int32[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @nameID, @values};
            var ___result = RMInternal_SetComputeInts_ComputeShader_Int32_Int32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetComputeTextureParam(UnityEngine.ComputeShader @computeShader, System.Int32 @kernelIndex, System.Int32 @nameID, ref UnityEngine.Rendering.RenderTargetIdentifier @rt, System.Int32 @mipLevel, UnityEngine.Rendering.RenderTextureSubElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @nameID, @rt, @mipLevel, @element};
            var ___result = RMInternal_SetComputeTextureParam_ComputeShader_Int32_Int32_Ref_RenderTargetIdentifier_Int32_RenderTextureSubElement.Invoke(___genericsType, ___parameters);
			@rt = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[3];

            
        }


        public virtual void Internal_SetComputeBufferParam(UnityEngine.ComputeShader @computeShader, System.Int32 @kernelIndex, System.Int32 @nameID, UnityEngine.ComputeBuffer @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @nameID, @buffer};
            var ___result = RMInternal_SetComputeBufferParam_ComputeShader_Int32_Int32_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetComputeGraphicsBufferHandleParam(UnityEngine.ComputeShader @computeShader, System.Int32 @kernelIndex, System.Int32 @nameID, UnityEngine.GraphicsBufferHandle @bufferHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @nameID, @bufferHandle};
            var ___result = RMInternal_SetComputeGraphicsBufferHandleParam_ComputeShader_Int32_Int32_GraphicsBufferHandle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetComputeGraphicsBufferParam(UnityEngine.ComputeShader @computeShader, System.Int32 @kernelIndex, System.Int32 @nameID, UnityEngine.GraphicsBuffer @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @nameID, @buffer};
            var ___result = RMInternal_SetComputeGraphicsBufferParam_ComputeShader_Int32_Int32_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetComputeConstantComputeBufferParam(UnityEngine.ComputeShader @computeShader, System.Int32 @nameID, UnityEngine.ComputeBuffer @buffer, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @nameID, @buffer, @offset, @size};
            var ___result = RMInternal_SetComputeConstantComputeBufferParam_ComputeShader_Int32_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetComputeConstantGraphicsBufferParam(UnityEngine.ComputeShader @computeShader, System.Int32 @nameID, UnityEngine.GraphicsBuffer @buffer, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @nameID, @buffer, @offset, @size};
            var ___result = RMInternal_SetComputeConstantGraphicsBufferParam_ComputeShader_Int32_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetComputeParamsFromMaterial(UnityEngine.ComputeShader @computeShader, System.Int32 @kernelIndex, UnityEngine.Material @material)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @material};
            var ___result = RMInternal_SetComputeParamsFromMaterial_ComputeShader_Int32_Material.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DispatchCompute(UnityEngine.ComputeShader @computeShader, System.Int32 @kernelIndex, System.Int32 @threadGroupsX, System.Int32 @threadGroupsY, System.Int32 @threadGroupsZ)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @threadGroupsX, @threadGroupsY, @threadGroupsZ};
            var ___result = RMInternal_DispatchCompute_ComputeShader_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DispatchComputeIndirect(UnityEngine.ComputeShader @computeShader, System.Int32 @kernelIndex, UnityEngine.ComputeBuffer @indirectBuffer, System.UInt32 @argsOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @indirectBuffer, @argsOffset};
            var ___result = RMInternal_DispatchComputeIndirect_ComputeShader_Int32_ComputeBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DispatchComputeIndirectGraphicsBuffer(UnityEngine.ComputeShader @computeShader, System.Int32 @kernelIndex, UnityEngine.GraphicsBuffer @indirectBuffer, System.UInt32 @argsOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @indirectBuffer, @argsOffset};
            var ___result = RMInternal_DispatchComputeIndirectGraphicsBuffer_ComputeShader_Int32_GraphicsBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetRayTracingBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.Int32 @nameID, UnityEngine.ComputeBuffer @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @buffer};
            var ___result = RMInternal_SetRayTracingBufferParam_RayTracingShader_Int32_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetRayTracingConstantComputeBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.Int32 @nameID, UnityEngine.ComputeBuffer @buffer, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @buffer, @offset, @size};
            var ___result = RMInternal_SetRayTracingConstantComputeBufferParam_RayTracingShader_Int32_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetRayTracingConstantGraphicsBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.Int32 @nameID, UnityEngine.GraphicsBuffer @buffer, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @buffer, @offset, @size};
            var ___result = RMInternal_SetRayTracingConstantGraphicsBufferParam_RayTracingShader_Int32_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetRayTracingTextureParam(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.Int32 @nameID, ref UnityEngine.Rendering.RenderTargetIdentifier @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @rt};
            var ___result = RMInternal_SetRayTracingTextureParam_RayTracingShader_Int32_Ref_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);
			@rt = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[2];

            
        }


        public virtual void Internal_SetRayTracingFloatParam(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.Int32 @nameID, System.Single @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @val};
            var ___result = RMInternal_SetRayTracingFloatParam_RayTracingShader_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetRayTracingIntParam(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.Int32 @nameID, System.Int32 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @val};
            var ___result = RMInternal_SetRayTracingIntParam_RayTracingShader_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetRayTracingVectorParam(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.Int32 @nameID, UnityEngine.Vector4 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @val};
            var ___result = RMInternal_SetRayTracingVectorParam_RayTracingShader_Int32_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetRayTracingVectorArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.Int32 @nameID, UnityEngine.Vector4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @values};
            var ___result = RMInternal_SetRayTracingVectorArrayParam_RayTracingShader_Int32_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetRayTracingMatrixParam(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.Int32 @nameID, UnityEngine.Matrix4x4 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @val};
            var ___result = RMInternal_SetRayTracingMatrixParam_RayTracingShader_Int32_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetRayTracingMatrixArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.Int32 @nameID, UnityEngine.Matrix4x4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @values};
            var ___result = RMInternal_SetRayTracingMatrixArrayParam_RayTracingShader_Int32_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetRayTracingFloats(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.Int32 @nameID, System.Single[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @values};
            var ___result = RMInternal_SetRayTracingFloats_RayTracingShader_Int32_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetRayTracingInts(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.Int32 @nameID, System.Int32[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @values};
            var ___result = RMInternal_SetRayTracingInts_RayTracingShader_Int32_Int32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_BuildRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure @accelerationStructure, UnityEngine.Vector3 @relativeOrigin)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@accelerationStructure, @relativeOrigin};
            var ___result = RMInternal_BuildRayTracingAccelerationStructure_RayTracingAccelerationStructure_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.Int32 @nameID, UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure @accelerationStructure)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @accelerationStructure};
            var ___result = RMInternal_SetRayTracingAccelerationStructure_RayTracingShader_Int32_RayTracingAccelerationStructure.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingShaderPass(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.String @passName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @passName};
            var ___result = RMSetRayTracingShaderPass_RayTracingShader_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DispatchRays(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.String @rayGenShaderName, System.UInt32 @width, System.UInt32 @height, System.UInt32 @depth, UnityEngine.Camera @camera)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @rayGenShaderName, @width, @height, @depth, @camera};
            var ___result = RMInternal_DispatchRays_RayTracingShader_String_UInt32_UInt32_UInt32_Camera.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_GenerateMips(UnityEngine.Rendering.RenderTargetIdentifier @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt};
            var ___result = RMInternal_GenerateMips_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_ResolveAntiAliasedSurface(UnityEngine.RenderTexture @rt, UnityEngine.RenderTexture @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt, @target};
            var ___result = RMInternal_ResolveAntiAliasedSurface_RenderTexture_RenderTexture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyCounterValueCC(UnityEngine.ComputeBuffer @src, UnityEngine.ComputeBuffer @dst, System.UInt32 @dstOffsetBytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst, @dstOffsetBytes};
            var ___result = RMCopyCounterValueCC_ComputeBuffer_ComputeBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyCounterValueGC(UnityEngine.GraphicsBuffer @src, UnityEngine.ComputeBuffer @dst, System.UInt32 @dstOffsetBytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst, @dstOffsetBytes};
            var ___result = RMCopyCounterValueGC_GraphicsBuffer_ComputeBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyCounterValueCG(UnityEngine.ComputeBuffer @src, UnityEngine.GraphicsBuffer @dst, System.UInt32 @dstOffsetBytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst, @dstOffsetBytes};
            var ___result = RMCopyCounterValueCG_ComputeBuffer_GraphicsBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyCounterValueGG(UnityEngine.GraphicsBuffer @src, UnityEngine.GraphicsBuffer @dst, System.UInt32 @dstOffsetBytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst, @dstOffsetBytes};
            var ___result = RMCopyCounterValueGG_GraphicsBuffer_GraphicsBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawMesh(UnityEngine.Mesh @mesh, UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @submeshIndex, System.Int32 @shaderPass, UnityEngine.MaterialPropertyBlock @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @matrix, @material, @submeshIndex, @shaderPass, @properties};
            var ___result = RMInternal_DrawMesh_Mesh_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawRenderer(UnityEngine.Renderer @renderer, UnityEngine.Material @material, System.Int32 @submeshIndex, System.Int32 @shaderPass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renderer, @material, @submeshIndex, @shaderPass};
            var ___result = RMInternal_DrawRenderer_Renderer_Material_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawRendererList(UnityEngine.Rendering.RendererList @rendererList)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rendererList};
            var ___result = RMInternal_DrawRendererList_RendererList.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawRenderer(UnityEngine.Renderer @renderer, UnityEngine.Material @material, System.Int32 @submeshIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renderer, @material, @submeshIndex};
            var ___result = RMInternal_DrawRenderer_Renderer_Material_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawRenderer(UnityEngine.Renderer @renderer, UnityEngine.Material @material)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renderer, @material};
            var ___result = RMInternal_DrawRenderer_Renderer_Material.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawProcedural(UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.MeshTopology @topology, System.Int32 @vertexCount, System.Int32 @instanceCount, UnityEngine.MaterialPropertyBlock @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @material, @shaderPass, @topology, @vertexCount, @instanceCount, @properties};
            var ___result = RMInternal_DrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawProceduralIndexed(UnityEngine.GraphicsBuffer @indexBuffer, UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.MeshTopology @topology, System.Int32 @indexCount, System.Int32 @instanceCount, UnityEngine.MaterialPropertyBlock @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexBuffer, @matrix, @material, @shaderPass, @topology, @indexCount, @instanceCount, @properties};
            var ___result = RMInternal_DrawProceduralIndexed_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawProceduralIndirect(UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.MeshTopology @topology, UnityEngine.ComputeBuffer @bufferWithArgs, System.Int32 @argsOffset, UnityEngine.MaterialPropertyBlock @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @material, @shaderPass, @topology, @bufferWithArgs, @argsOffset, @properties};
            var ___result = RMInternal_DrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawProceduralIndexedIndirect(UnityEngine.GraphicsBuffer @indexBuffer, UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.MeshTopology @topology, UnityEngine.ComputeBuffer @bufferWithArgs, System.Int32 @argsOffset, UnityEngine.MaterialPropertyBlock @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexBuffer, @matrix, @material, @shaderPass, @topology, @bufferWithArgs, @argsOffset, @properties};
            var ___result = RMInternal_DrawProceduralIndexedIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawProceduralIndirectGraphicsBuffer(UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.MeshTopology @topology, UnityEngine.GraphicsBuffer @bufferWithArgs, System.Int32 @argsOffset, UnityEngine.MaterialPropertyBlock @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @material, @shaderPass, @topology, @bufferWithArgs, @argsOffset, @properties};
            var ___result = RMInternal_DrawProceduralIndirectGraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawProceduralIndexedIndirectGraphicsBuffer(UnityEngine.GraphicsBuffer @indexBuffer, UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.MeshTopology @topology, UnityEngine.GraphicsBuffer @bufferWithArgs, System.Int32 @argsOffset, UnityEngine.MaterialPropertyBlock @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexBuffer, @matrix, @material, @shaderPass, @topology, @bufferWithArgs, @argsOffset, @properties};
            var ___result = RMInternal_DrawProceduralIndexedIndirectGraphicsBuffer_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawMeshInstanced(UnityEngine.Mesh @mesh, System.Int32 @submeshIndex, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.Matrix4x4[] @matrices, System.Int32 @count, UnityEngine.MaterialPropertyBlock @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @submeshIndex, @material, @shaderPass, @matrices, @count, @properties};
            var ___result = RMInternal_DrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawMeshInstancedProcedural(UnityEngine.Mesh @mesh, System.Int32 @submeshIndex, UnityEngine.Material @material, System.Int32 @shaderPass, System.Int32 @count, UnityEngine.MaterialPropertyBlock @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @submeshIndex, @material, @shaderPass, @count, @properties};
            var ___result = RMInternal_DrawMeshInstancedProcedural_Mesh_Int32_Material_Int32_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawMeshInstancedIndirect(UnityEngine.Mesh @mesh, System.Int32 @submeshIndex, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.ComputeBuffer @bufferWithArgs, System.Int32 @argsOffset, UnityEngine.MaterialPropertyBlock @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @submeshIndex, @material, @shaderPass, @bufferWithArgs, @argsOffset, @properties};
            var ___result = RMInternal_DrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawMeshInstancedIndirectGraphicsBuffer(UnityEngine.Mesh @mesh, System.Int32 @submeshIndex, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.GraphicsBuffer @bufferWithArgs, System.Int32 @argsOffset, UnityEngine.MaterialPropertyBlock @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @submeshIndex, @material, @shaderPass, @bufferWithArgs, @argsOffset, @properties};
            var ___result = RMInternal_DrawMeshInstancedIndirectGraphicsBuffer_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawOcclusionMesh(UnityEngine.RectInt @normalizedCamViewport)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@normalizedCamViewport};
            var ___result = RMInternal_DrawOcclusionMesh_RectInt.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRandomWriteTarget_Texture(System.Int32 @index, ref UnityEngine.Rendering.RenderTargetIdentifier @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @rt};
            var ___result = RMSetRandomWriteTarget_Texture_Int32_Ref_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);
			@rt = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[1];

            
        }


        public virtual void SetRandomWriteTarget_Buffer(System.Int32 @index, UnityEngine.ComputeBuffer @uav, System.Boolean @preserveCounterValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @uav, @preserveCounterValue};
            var ___result = RMSetRandomWriteTarget_Buffer_Int32_ComputeBuffer_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRandomWriteTarget_GraphicsBuffer(System.Int32 @index, UnityEngine.GraphicsBuffer @uav, System.Boolean @preserveCounterValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @uav, @preserveCounterValue};
            var ___result = RMSetRandomWriteTarget_GraphicsBuffer_Int32_GraphicsBuffer_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearRandomWriteTargets()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearRandomWriteTargets.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetViewport(UnityEngine.Rect @pixelRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pixelRect};
            var ___result = RMSetViewport_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnableScissorRect(UnityEngine.Rect @scissor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scissor};
            var ___result = RMEnableScissorRect_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DisableScissorRect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDisableScissorRect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTexture_Internal(ref UnityEngine.Rendering.RenderTargetIdentifier @src, System.Int32 @srcElement, System.Int32 @srcMip, System.Int32 @srcX, System.Int32 @srcY, System.Int32 @srcWidth, System.Int32 @srcHeight, ref UnityEngine.Rendering.RenderTargetIdentifier @dst, System.Int32 @dstElement, System.Int32 @dstMip, System.Int32 @dstX, System.Int32 @dstY, System.Int32 @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @srcElement, @srcMip, @srcX, @srcY, @srcWidth, @srcHeight, @dst, @dstElement, @dstMip, @dstX, @dstY, @mode};
            var ___result = RMCopyTexture_Internal_Ref_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32_Int32_Ref_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);
			@src = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[0];
			@dst = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[7];

            
        }


        public virtual void Blit_Texture(UnityEngine.Texture @source, ref UnityEngine.Rendering.RenderTargetIdentifier @dest, UnityEngine.Material @mat, System.Int32 @pass, UnityEngine.Vector2 @scale, UnityEngine.Vector2 @offset, System.Int32 @sourceDepthSlice, System.Int32 @destDepthSlice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest, @mat, @pass, @scale, @offset, @sourceDepthSlice, @destDepthSlice};
            var ___result = RMBlit_Texture_Texture_Ref_RenderTargetIdentifier_Material_Int32_Vector2_Vector2_Int32_Int32.Invoke(___genericsType, ___parameters);
			@dest = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[1];

            
        }


        public virtual void Blit_Identifier(ref UnityEngine.Rendering.RenderTargetIdentifier @source, ref UnityEngine.Rendering.RenderTargetIdentifier @dest, UnityEngine.Material @mat, System.Int32 @pass, UnityEngine.Vector2 @scale, UnityEngine.Vector2 @offset, System.Int32 @sourceDepthSlice, System.Int32 @destDepthSlice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest, @mat, @pass, @scale, @offset, @sourceDepthSlice, @destDepthSlice};
            var ___result = RMBlit_Identifier_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_Material_Int32_Vector2_Vector2_Int32_Int32.Invoke(___genericsType, ___parameters);
			@source = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[0];
			@dest = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[1];

            
        }


        public virtual void GetTemporaryRT(System.Int32 @nameID, System.Int32 @width, System.Int32 @height, System.Int32 @depthBuffer, UnityEngine.FilterMode @filter, UnityEngine.Experimental.Rendering.GraphicsFormat @format, System.Int32 @antiAliasing, System.Boolean @enableRandomWrite, UnityEngine.RenderTextureMemoryless @memorylessMode, System.Boolean @useDynamicScale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @depthBuffer, @filter, @format, @antiAliasing, @enableRandomWrite, @memorylessMode, @useDynamicScale};
            var ___result = RMGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_RenderTextureMemoryless_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRT(System.Int32 @nameID, System.Int32 @width, System.Int32 @height, System.Int32 @depthBuffer, UnityEngine.FilterMode @filter, UnityEngine.Experimental.Rendering.GraphicsFormat @format, System.Int32 @antiAliasing, System.Boolean @enableRandomWrite, UnityEngine.RenderTextureMemoryless @memorylessMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @depthBuffer, @filter, @format, @antiAliasing, @enableRandomWrite, @memorylessMode};
            var ___result = RMGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_RenderTextureMemoryless.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRT(System.Int32 @nameID, System.Int32 @width, System.Int32 @height, System.Int32 @depthBuffer, UnityEngine.FilterMode @filter, UnityEngine.Experimental.Rendering.GraphicsFormat @format, System.Int32 @antiAliasing, System.Boolean @enableRandomWrite)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @depthBuffer, @filter, @format, @antiAliasing, @enableRandomWrite};
            var ___result = RMGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRT(System.Int32 @nameID, System.Int32 @width, System.Int32 @height, System.Int32 @depthBuffer, UnityEngine.FilterMode @filter, UnityEngine.Experimental.Rendering.GraphicsFormat @format, System.Int32 @antiAliasing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @depthBuffer, @filter, @format, @antiAliasing};
            var ___result = RMGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRT(System.Int32 @nameID, System.Int32 @width, System.Int32 @height, System.Int32 @depthBuffer, UnityEngine.FilterMode @filter, UnityEngine.Experimental.Rendering.GraphicsFormat @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @depthBuffer, @filter, @format};
            var ___result = RMGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRT(System.Int32 @nameID, System.Int32 @width, System.Int32 @height, System.Int32 @depthBuffer, UnityEngine.FilterMode @filter, UnityEngine.RenderTextureFormat @format, UnityEngine.RenderTextureReadWrite @readWrite, System.Int32 @antiAliasing, System.Boolean @enableRandomWrite, UnityEngine.RenderTextureMemoryless @memorylessMode, System.Boolean @useDynamicScale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @depthBuffer, @filter, @format, @readWrite, @antiAliasing, @enableRandomWrite, @memorylessMode, @useDynamicScale};
            var ___result = RMGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_RenderTextureMemoryless_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRT(System.Int32 @nameID, System.Int32 @width, System.Int32 @height, System.Int32 @depthBuffer, UnityEngine.FilterMode @filter, UnityEngine.RenderTextureFormat @format, UnityEngine.RenderTextureReadWrite @readWrite, System.Int32 @antiAliasing, System.Boolean @enableRandomWrite, UnityEngine.RenderTextureMemoryless @memorylessMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @depthBuffer, @filter, @format, @readWrite, @antiAliasing, @enableRandomWrite, @memorylessMode};
            var ___result = RMGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_RenderTextureMemoryless.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRT(System.Int32 @nameID, System.Int32 @width, System.Int32 @height, System.Int32 @depthBuffer, UnityEngine.FilterMode @filter, UnityEngine.RenderTextureFormat @format, UnityEngine.RenderTextureReadWrite @readWrite, System.Int32 @antiAliasing, System.Boolean @enableRandomWrite)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @depthBuffer, @filter, @format, @readWrite, @antiAliasing, @enableRandomWrite};
            var ___result = RMGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRT(System.Int32 @nameID, System.Int32 @width, System.Int32 @height, System.Int32 @depthBuffer, UnityEngine.FilterMode @filter, UnityEngine.RenderTextureFormat @format, UnityEngine.RenderTextureReadWrite @readWrite, System.Int32 @antiAliasing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @depthBuffer, @filter, @format, @readWrite, @antiAliasing};
            var ___result = RMGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRT(System.Int32 @nameID, System.Int32 @width, System.Int32 @height, System.Int32 @depthBuffer, UnityEngine.FilterMode @filter, UnityEngine.RenderTextureFormat @format, UnityEngine.RenderTextureReadWrite @readWrite)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @depthBuffer, @filter, @format, @readWrite};
            var ___result = RMGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRT(System.Int32 @nameID, System.Int32 @width, System.Int32 @height, System.Int32 @depthBuffer, UnityEngine.FilterMode @filter, UnityEngine.RenderTextureFormat @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @depthBuffer, @filter, @format};
            var ___result = RMGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRT(System.Int32 @nameID, System.Int32 @width, System.Int32 @height, System.Int32 @depthBuffer, UnityEngine.FilterMode @filter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @depthBuffer, @filter};
            var ___result = RMGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRT(System.Int32 @nameID, System.Int32 @width, System.Int32 @height, System.Int32 @depthBuffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @depthBuffer};
            var ___result = RMGetTemporaryRT_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRT(System.Int32 @nameID, System.Int32 @width, System.Int32 @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height};
            var ___result = RMGetTemporaryRT_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRTWithDescriptor(System.Int32 @nameID, UnityEngine.RenderTextureDescriptor @desc, UnityEngine.FilterMode @filter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @desc, @filter};
            var ___result = RMGetTemporaryRTWithDescriptor_Int32_RenderTextureDescriptor_FilterMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRT(System.Int32 @nameID, UnityEngine.RenderTextureDescriptor @desc, UnityEngine.FilterMode @filter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @desc, @filter};
            var ___result = RMGetTemporaryRT_Int32_RenderTextureDescriptor_FilterMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRT(System.Int32 @nameID, UnityEngine.RenderTextureDescriptor @desc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @desc};
            var ___result = RMGetTemporaryRT_Int32_RenderTextureDescriptor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRTArray(System.Int32 @nameID, System.Int32 @width, System.Int32 @height, System.Int32 @slices, System.Int32 @depthBuffer, UnityEngine.FilterMode @filter, UnityEngine.Experimental.Rendering.GraphicsFormat @format, System.Int32 @antiAliasing, System.Boolean @enableRandomWrite, System.Boolean @useDynamicScale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @slices, @depthBuffer, @filter, @format, @antiAliasing, @enableRandomWrite, @useDynamicScale};
            var ___result = RMGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRTArray(System.Int32 @nameID, System.Int32 @width, System.Int32 @height, System.Int32 @slices, System.Int32 @depthBuffer, UnityEngine.FilterMode @filter, UnityEngine.Experimental.Rendering.GraphicsFormat @format, System.Int32 @antiAliasing, System.Boolean @enableRandomWrite)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @slices, @depthBuffer, @filter, @format, @antiAliasing, @enableRandomWrite};
            var ___result = RMGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRTArray(System.Int32 @nameID, System.Int32 @width, System.Int32 @height, System.Int32 @slices, System.Int32 @depthBuffer, UnityEngine.FilterMode @filter, UnityEngine.Experimental.Rendering.GraphicsFormat @format, System.Int32 @antiAliasing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @slices, @depthBuffer, @filter, @format, @antiAliasing};
            var ___result = RMGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRTArray(System.Int32 @nameID, System.Int32 @width, System.Int32 @height, System.Int32 @slices, System.Int32 @depthBuffer, UnityEngine.FilterMode @filter, UnityEngine.Experimental.Rendering.GraphicsFormat @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @slices, @depthBuffer, @filter, @format};
            var ___result = RMGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRTArray(System.Int32 @nameID, System.Int32 @width, System.Int32 @height, System.Int32 @slices, System.Int32 @depthBuffer, UnityEngine.FilterMode @filter, UnityEngine.RenderTextureFormat @format, UnityEngine.RenderTextureReadWrite @readWrite, System.Int32 @antiAliasing, System.Boolean @enableRandomWrite)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @slices, @depthBuffer, @filter, @format, @readWrite, @antiAliasing, @enableRandomWrite};
            var ___result = RMGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRTArray(System.Int32 @nameID, System.Int32 @width, System.Int32 @height, System.Int32 @slices, System.Int32 @depthBuffer, UnityEngine.FilterMode @filter, UnityEngine.RenderTextureFormat @format, UnityEngine.RenderTextureReadWrite @readWrite, System.Int32 @antiAliasing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @slices, @depthBuffer, @filter, @format, @readWrite, @antiAliasing};
            var ___result = RMGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRTArray(System.Int32 @nameID, System.Int32 @width, System.Int32 @height, System.Int32 @slices, System.Int32 @depthBuffer, UnityEngine.FilterMode @filter, UnityEngine.RenderTextureFormat @format, UnityEngine.RenderTextureReadWrite @readWrite)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @slices, @depthBuffer, @filter, @format, @readWrite};
            var ___result = RMGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRTArray(System.Int32 @nameID, System.Int32 @width, System.Int32 @height, System.Int32 @slices, System.Int32 @depthBuffer, UnityEngine.FilterMode @filter, UnityEngine.RenderTextureFormat @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @slices, @depthBuffer, @filter, @format};
            var ___result = RMGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRTArray(System.Int32 @nameID, System.Int32 @width, System.Int32 @height, System.Int32 @slices, System.Int32 @depthBuffer, UnityEngine.FilterMode @filter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @slices, @depthBuffer, @filter};
            var ___result = RMGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRTArray(System.Int32 @nameID, System.Int32 @width, System.Int32 @height, System.Int32 @slices, System.Int32 @depthBuffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @slices, @depthBuffer};
            var ___result = RMGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRTArray(System.Int32 @nameID, System.Int32 @width, System.Int32 @height, System.Int32 @slices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @slices};
            var ___result = RMGetTemporaryRTArray_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReleaseTemporaryRT(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMReleaseTemporaryRT_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearRenderTarget(UnityEngine.Rendering.RTClearFlags @clearFlags, UnityEngine.Color @backgroundColor, System.Single @depth, System.UInt32 @stencil)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clearFlags, @backgroundColor, @depth, @stencil};
            var ___result = RMClearRenderTarget_RTClearFlags_Color_Single_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearRenderTarget(System.Boolean @clearDepth, System.Boolean @clearColor, UnityEngine.Color @backgroundColor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clearDepth, @clearColor, @backgroundColor};
            var ___result = RMClearRenderTarget_Boolean_Boolean_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearRenderTarget(System.Boolean @clearDepth, System.Boolean @clearColor, UnityEngine.Color @backgroundColor, System.Single @depth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clearDepth, @clearColor, @backgroundColor, @depth};
            var ___result = RMClearRenderTarget_Boolean_Boolean_Color_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalFloat(System.Int32 @nameID, System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetGlobalFloat_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalInt(System.Int32 @nameID, System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetGlobalInt_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalInteger(System.Int32 @nameID, System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetGlobalInteger_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalVector(System.Int32 @nameID, UnityEngine.Vector4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetGlobalVector_Int32_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalColor(System.Int32 @nameID, UnityEngine.Color @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetGlobalColor_Int32_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalMatrix(System.Int32 @nameID, UnityEngine.Matrix4x4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetGlobalMatrix_Int32_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnableShaderKeyword(System.String @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMEnableShaderKeyword_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnableGlobalKeyword(UnityEngine.Rendering.GlobalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMEnableGlobalKeyword_GlobalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnableMaterialKeyword(UnityEngine.Material @material, UnityEngine.Rendering.LocalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@material, @keyword};
            var ___result = RMEnableMaterialKeyword_Material_LocalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnableComputeKeyword(UnityEngine.ComputeShader @computeShader, UnityEngine.Rendering.LocalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @keyword};
            var ___result = RMEnableComputeKeyword_ComputeShader_LocalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnableKeyword(in UnityEngine.Rendering.GlobalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMEnableKeyword_In_GlobalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnableKeyword(UnityEngine.Material @material, in UnityEngine.Rendering.LocalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@material, @keyword};
            var ___result = RMEnableKeyword_Material_In_LocalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnableKeyword(UnityEngine.ComputeShader @computeShader, in UnityEngine.Rendering.LocalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @keyword};
            var ___result = RMEnableKeyword_ComputeShader_In_LocalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DisableShaderKeyword(System.String @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMDisableShaderKeyword_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DisableGlobalKeyword(UnityEngine.Rendering.GlobalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMDisableGlobalKeyword_GlobalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DisableMaterialKeyword(UnityEngine.Material @material, UnityEngine.Rendering.LocalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@material, @keyword};
            var ___result = RMDisableMaterialKeyword_Material_LocalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DisableComputeKeyword(UnityEngine.ComputeShader @computeShader, UnityEngine.Rendering.LocalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @keyword};
            var ___result = RMDisableComputeKeyword_ComputeShader_LocalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DisableKeyword(in UnityEngine.Rendering.GlobalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMDisableKeyword_In_GlobalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DisableKeyword(UnityEngine.Material @material, in UnityEngine.Rendering.LocalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@material, @keyword};
            var ___result = RMDisableKeyword_Material_In_LocalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DisableKeyword(UnityEngine.ComputeShader @computeShader, in UnityEngine.Rendering.LocalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @keyword};
            var ___result = RMDisableKeyword_ComputeShader_In_LocalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalKeyword(UnityEngine.Rendering.GlobalKeyword @keyword, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword, @value};
            var ___result = RMSetGlobalKeyword_GlobalKeyword_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMaterialKeyword(UnityEngine.Material @material, UnityEngine.Rendering.LocalKeyword @keyword, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@material, @keyword, @value};
            var ___result = RMSetMaterialKeyword_Material_LocalKeyword_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeKeyword(UnityEngine.ComputeShader @computeShader, UnityEngine.Rendering.LocalKeyword @keyword, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @keyword, @value};
            var ___result = RMSetComputeKeyword_ComputeShader_LocalKeyword_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetKeyword(in UnityEngine.Rendering.GlobalKeyword @keyword, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword, @value};
            var ___result = RMSetKeyword_In_GlobalKeyword_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetKeyword(UnityEngine.Material @material, in UnityEngine.Rendering.LocalKeyword @keyword, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@material, @keyword, @value};
            var ___result = RMSetKeyword_Material_In_LocalKeyword_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetKeyword(UnityEngine.ComputeShader @computeShader, in UnityEngine.Rendering.LocalKeyword @keyword, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @keyword, @value};
            var ___result = RMSetKeyword_ComputeShader_In_LocalKeyword_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetViewMatrix(UnityEngine.Matrix4x4 @view)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@view};
            var ___result = RMSetViewMatrix_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetProjectionMatrix(UnityEngine.Matrix4x4 @proj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@proj};
            var ___result = RMSetProjectionMatrix_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetViewProjectionMatrices(UnityEngine.Matrix4x4 @view, UnityEngine.Matrix4x4 @proj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@view, @proj};
            var ___result = RMSetViewProjectionMatrices_Matrix4x4_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalDepthBias(System.Single @bias, System.Single @slopeBias)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bias, @slopeBias};
            var ___result = RMSetGlobalDepthBias_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetExecutionFlags(UnityEngine.Rendering.CommandBufferExecutionFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flags};
            var ___result = RMSetExecutionFlags_CommandBufferExecutionFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ValidateAgainstExecutionFlags(UnityEngine.Rendering.CommandBufferExecutionFlags @requiredFlags, UnityEngine.Rendering.CommandBufferExecutionFlags @invalidFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@requiredFlags, @invalidFlags};
            var ___result = RMValidateAgainstExecutionFlags_CommandBufferExecutionFlags_CommandBufferExecutionFlags.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetGlobalFloatArrayListImpl(System.Int32 @nameID, System.Object @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetGlobalFloatArrayListImpl_Int32_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalVectorArrayListImpl(System.Int32 @nameID, System.Object @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetGlobalVectorArrayListImpl_Int32_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalMatrixArrayListImpl(System.Int32 @nameID, System.Object @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetGlobalMatrixArrayListImpl_Int32_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalFloatArray(System.Int32 @nameID, System.Single[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetGlobalFloatArray_Int32_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalVectorArray(System.Int32 @nameID, UnityEngine.Vector4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetGlobalVectorArray_Int32_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalMatrixArray(System.Int32 @nameID, UnityEngine.Matrix4x4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetGlobalMatrixArray_Int32_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetLateLatchProjectionMatrices(UnityEngine.Matrix4x4[] @projectionMat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@projectionMat};
            var ___result = RMSetLateLatchProjectionMatrices_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkLateLatchMatrixShaderPropertyID(UnityEngine.Rendering.CameraLateLatchMatrixType @matrixPropertyType, System.Int32 @shaderPropertyID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrixPropertyType, @shaderPropertyID};
            var ___result = RMMarkLateLatchMatrixShaderPropertyID_CameraLateLatchMatrixType_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnmarkLateLatchMatrix(UnityEngine.Rendering.CameraLateLatchMatrixType @matrixPropertyType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrixPropertyType};
            var ___result = RMUnmarkLateLatchMatrix_CameraLateLatchMatrixType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalTexture_Impl(System.Int32 @nameID, ref UnityEngine.Rendering.RenderTargetIdentifier @rt, UnityEngine.Rendering.RenderTextureSubElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @rt, @element};
            var ___result = RMSetGlobalTexture_Impl_Int32_Ref_RenderTargetIdentifier_RenderTextureSubElement.Invoke(___genericsType, ___parameters);
			@rt = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[1];

            
        }


        public virtual void SetGlobalBufferInternal(System.Int32 @nameID, UnityEngine.ComputeBuffer @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetGlobalBufferInternal_Int32_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalGraphicsBufferInternal(System.Int32 @nameID, UnityEngine.GraphicsBuffer @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetGlobalGraphicsBufferInternal_Int32_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetShadowSamplingMode_Impl(ref UnityEngine.Rendering.RenderTargetIdentifier @shadowmap, UnityEngine.Rendering.ShadowSamplingMode @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shadowmap, @mode};
            var ___result = RMSetShadowSamplingMode_Impl_Ref_RenderTargetIdentifier_ShadowSamplingMode.Invoke(___genericsType, ___parameters);
			@shadowmap = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[0];

            
        }


        public virtual void IssuePluginEventInternal(System.IntPtr @callback, System.Int32 @eventID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @eventID};
            var ___result = RMIssuePluginEventInternal_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BeginSample(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMBeginSample_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EndSample(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMEndSample_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BeginSample(UnityEngine.Profiling.CustomSampler @sampler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sampler};
            var ___result = RMBeginSample_CustomSampler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EndSample(UnityEngine.Profiling.CustomSampler @sampler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sampler};
            var ___result = RMEndSample_CustomSampler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BeginSample_CustomSampler(UnityEngine.Profiling.CustomSampler @sampler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sampler};
            var ___result = RMBeginSample_CustomSampler_CustomSampler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EndSample_CustomSampler(UnityEngine.Profiling.CustomSampler @sampler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sampler};
            var ___result = RMEndSample_CustomSampler_CustomSampler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BeginSample(Unity.Profiling.ProfilerMarker @marker)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@marker};
            var ___result = RMBeginSample_ProfilerMarker.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EndSample(Unity.Profiling.ProfilerMarker @marker)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@marker};
            var ___result = RMEndSample_ProfilerMarker.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BeginSample_ProfilerMarker(System.IntPtr @markerHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@markerHandle};
            var ___result = RMBeginSample_ProfilerMarker_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EndSample_ProfilerMarker(System.IntPtr @markerHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@markerHandle};
            var ___result = RMEndSample_ProfilerMarker_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IssuePluginEventAndDataInternal(System.IntPtr @callback, System.Int32 @eventID, System.IntPtr @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @eventID, @data};
            var ___result = RMIssuePluginEventAndDataInternal_IntPtr_Int32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IssuePluginEventAndDataInternalWithFlags(System.IntPtr @callback, System.Int32 @eventID, UnityEngine.Rendering.CustomMarkerCallbackFlags @flags, System.IntPtr @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @eventID, @flags, @data};
            var ___result = RMIssuePluginEventAndDataInternalWithFlags_IntPtr_Int32_CustomMarkerCallbackFlags_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IssuePluginCustomBlitInternal(System.IntPtr @callback, System.UInt32 @command, ref UnityEngine.Rendering.RenderTargetIdentifier @source, ref UnityEngine.Rendering.RenderTargetIdentifier @dest, System.UInt32 @commandParam, System.UInt32 @commandFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @command, @source, @dest, @commandParam, @commandFlags};
            var ___result = RMIssuePluginCustomBlitInternal_IntPtr_UInt32_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_UInt32_UInt32.Invoke(___genericsType, ___parameters);
			@source = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[2];
			@dest = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[3];

            
        }


        public virtual void IssuePluginCustomTextureUpdateInternal(System.IntPtr @callback, UnityEngine.Texture @targetTexture, System.UInt32 @userData, System.Boolean @useNewUnityRenderingExtTextureUpdateParamsV2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @targetTexture, @userData, @useNewUnityRenderingExtTextureUpdateParamsV2};
            var ___result = RMIssuePluginCustomTextureUpdateInternal_IntPtr_Texture_UInt32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalConstantBufferInternal(UnityEngine.ComputeBuffer @buffer, System.Int32 @nameID, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @nameID, @offset, @size};
            var ___result = RMSetGlobalConstantBufferInternal_ComputeBuffer_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalConstantGraphicsBufferInternal(UnityEngine.GraphicsBuffer @buffer, System.Int32 @nameID, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @nameID, @offset, @size};
            var ___result = RMSetGlobalConstantGraphicsBufferInternal_GraphicsBuffer_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IncrementUpdateCount(UnityEngine.Rendering.RenderTargetIdentifier @dest)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dest};
            var ___result = RMIncrementUpdateCount_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInstanceMultiplier(System.UInt32 @multiplier)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@multiplier};
            var ___result = RMSetInstanceMultiplier_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFoveatedRenderingMode(UnityEngine.Rendering.FoveatedRenderingMode @foveatedRenderingMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@foveatedRenderingMode};
            var ___result = RMSetFoveatedRenderingMode_FoveatedRenderingMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ConfigureFoveatedRendering(System.IntPtr @platformData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@platformData};
            var ___result = RMConfigureFoveatedRendering_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt};
            var ___result = RMSetRenderTarget_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier @rt, UnityEngine.Rendering.RenderBufferLoadAction @loadAction, UnityEngine.Rendering.RenderBufferStoreAction @storeAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt, @loadAction, @storeAction};
            var ___result = RMSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier @rt, UnityEngine.Rendering.RenderBufferLoadAction @colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction @colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction @depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction @depthStoreAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt, @colorLoadAction, @colorStoreAction, @depthLoadAction, @depthStoreAction};
            var ___result = RMSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier @rt, System.Int32 @mipLevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt, @mipLevel};
            var ___result = RMSetRenderTarget_RenderTargetIdentifier_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier @rt, System.Int32 @mipLevel, UnityEngine.CubemapFace @cubemapFace)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt, @mipLevel, @cubemapFace};
            var ___result = RMSetRenderTarget_RenderTargetIdentifier_Int32_CubemapFace.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier @rt, System.Int32 @mipLevel, UnityEngine.CubemapFace @cubemapFace, System.Int32 @depthSlice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt, @mipLevel, @cubemapFace, @depthSlice};
            var ___result = RMSetRenderTarget_RenderTargetIdentifier_Int32_CubemapFace_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier @color, UnityEngine.Rendering.RenderTargetIdentifier @depth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color, @depth};
            var ___result = RMSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier @color, UnityEngine.Rendering.RenderTargetIdentifier @depth, System.Int32 @mipLevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color, @depth, @mipLevel};
            var ___result = RMSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier @color, UnityEngine.Rendering.RenderTargetIdentifier @depth, System.Int32 @mipLevel, UnityEngine.CubemapFace @cubemapFace)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color, @depth, @mipLevel, @cubemapFace};
            var ___result = RMSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32_CubemapFace.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier @color, UnityEngine.Rendering.RenderTargetIdentifier @depth, System.Int32 @mipLevel, UnityEngine.CubemapFace @cubemapFace, System.Int32 @depthSlice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color, @depth, @mipLevel, @cubemapFace, @depthSlice};
            var ___result = RMSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32_CubemapFace_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier @color, UnityEngine.Rendering.RenderBufferLoadAction @colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction @colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier @depth, UnityEngine.Rendering.RenderBufferLoadAction @depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction @depthStoreAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color, @colorLoadAction, @colorStoreAction, @depth, @depthLoadAction, @depthStoreAction};
            var ___result = RMSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier[] @colors, UnityEngine.Rendering.RenderTargetIdentifier @depth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colors, @depth};
            var ___result = RMSetRenderTarget_RenderTargetIdentifierArray_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier[] @colors, UnityEngine.Rendering.RenderTargetIdentifier @depth, System.Int32 @mipLevel, UnityEngine.CubemapFace @cubemapFace, System.Int32 @depthSlice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colors, @depth, @mipLevel, @cubemapFace, @depthSlice};
            var ___result = RMSetRenderTarget_RenderTargetIdentifierArray_RenderTargetIdentifier_Int32_CubemapFace_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTarget(UnityEngine.Rendering.RenderTargetBinding @binding, System.Int32 @mipLevel, UnityEngine.CubemapFace @cubemapFace, System.Int32 @depthSlice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@binding, @mipLevel, @cubemapFace, @depthSlice};
            var ___result = RMSetRenderTarget_RenderTargetBinding_Int32_CubemapFace_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTarget(UnityEngine.Rendering.RenderTargetBinding @binding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@binding};
            var ___result = RMSetRenderTarget_RenderTargetBinding.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTargetSingle_Internal(UnityEngine.Rendering.RenderTargetIdentifier @rt, UnityEngine.Rendering.RenderBufferLoadAction @colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction @colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction @depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction @depthStoreAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt, @colorLoadAction, @colorStoreAction, @depthLoadAction, @depthStoreAction};
            var ___result = RMSetRenderTargetSingle_Internal_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTargetColorDepth_Internal(UnityEngine.Rendering.RenderTargetIdentifier @color, UnityEngine.Rendering.RenderTargetIdentifier @depth, UnityEngine.Rendering.RenderBufferLoadAction @colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction @colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction @depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction @depthStoreAction, UnityEngine.Rendering.RenderTargetFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color, @depth, @colorLoadAction, @colorStoreAction, @depthLoadAction, @depthStoreAction, @flags};
            var ___result = RMSetRenderTargetColorDepth_Internal_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTargetMulti_Internal(UnityEngine.Rendering.RenderTargetIdentifier[] @colors, UnityEngine.Rendering.RenderTargetIdentifier @depth, UnityEngine.Rendering.RenderBufferLoadAction[] @colorLoadActions, UnityEngine.Rendering.RenderBufferStoreAction[] @colorStoreActions, UnityEngine.Rendering.RenderBufferLoadAction @depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction @depthStoreAction, UnityEngine.Rendering.RenderTargetFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colors, @depth, @colorLoadActions, @colorStoreActions, @depthLoadAction, @depthStoreAction, @flags};
            var ___result = RMSetRenderTargetMulti_Internal_RenderTargetIdentifierArray_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTargetColorDepthSubtarget(UnityEngine.Rendering.RenderTargetIdentifier @color, UnityEngine.Rendering.RenderTargetIdentifier @depth, UnityEngine.Rendering.RenderBufferLoadAction @colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction @colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction @depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction @depthStoreAction, System.Int32 @mipLevel, UnityEngine.CubemapFace @cubemapFace, System.Int32 @depthSlice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color, @depth, @colorLoadAction, @colorStoreAction, @depthLoadAction, @depthStoreAction, @mipLevel, @cubemapFace, @depthSlice};
            var ___result = RMSetRenderTargetColorDepthSubtarget_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTargetMultiSubtarget(UnityEngine.Rendering.RenderTargetIdentifier[] @colors, UnityEngine.Rendering.RenderTargetIdentifier @depth, UnityEngine.Rendering.RenderBufferLoadAction[] @colorLoadActions, UnityEngine.Rendering.RenderBufferStoreAction[] @colorStoreActions, UnityEngine.Rendering.RenderBufferLoadAction @depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction @depthStoreAction, System.Int32 @mipLevel, UnityEngine.CubemapFace @cubemapFace, System.Int32 @depthSlice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colors, @depth, @colorLoadActions, @colorStoreActions, @depthLoadAction, @depthStoreAction, @mipLevel, @cubemapFace, @depthSlice};
            var ___result = RMSetRenderTargetMultiSubtarget_RenderTargetIdentifierArray_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_ProcessVTFeedback(UnityEngine.Rendering.RenderTargetIdentifier @rt, System.IntPtr @resolver, System.Int32 @slice, System.Int32 @x, System.Int32 @width, System.Int32 @y, System.Int32 @height, System.Int32 @mip)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt, @resolver, @slice, @x, @width, @y, @height, @mip};
            var ___result = RMInternal_ProcessVTFeedback_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBufferData(UnityEngine.ComputeBuffer @buffer, System.Array @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @data};
            var ___result = RMSetBufferData_ComputeBuffer_Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBufferData<T>(UnityEngine.ComputeBuffer @buffer, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RType> @data) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@buffer, @data.Value};
            var ___result = RMSetBufferData_GT_ComputeBuffer_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBufferData<T>(UnityEngine.ComputeBuffer @buffer, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @data) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@buffer, @data.Value};
            var ___result = RMSetBufferData_GT_ComputeBuffer_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBufferData(UnityEngine.ComputeBuffer @buffer, System.Array @data, System.Int32 @managedBufferStartIndex, System.Int32 @graphicsBufferStartIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @data, @managedBufferStartIndex, @graphicsBufferStartIndex, @count};
            var ___result = RMSetBufferData_ComputeBuffer_Array_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBufferData<T>(UnityEngine.ComputeBuffer @buffer, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RType> @data, System.Int32 @managedBufferStartIndex, System.Int32 @graphicsBufferStartIndex, System.Int32 @count) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@buffer, @data.Value, @managedBufferStartIndex, @graphicsBufferStartIndex, @count};
            var ___result = RMSetBufferData_GT_ComputeBuffer_List_d_T_p__Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBufferData<T>(UnityEngine.ComputeBuffer @buffer, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @data, System.Int32 @nativeBufferStartIndex, System.Int32 @graphicsBufferStartIndex, System.Int32 @count) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@buffer, @data.Value, @nativeBufferStartIndex, @graphicsBufferStartIndex, @count};
            var ___result = RMSetBufferData_GT_ComputeBuffer_NativeArray_d_T_p__Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBufferCounterValue(UnityEngine.ComputeBuffer @buffer, System.UInt32 @counterValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @counterValue};
            var ___result = RMSetBufferCounterValue_ComputeBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalSetComputeBufferNativeData(UnityEngine.ComputeBuffer @buffer, System.IntPtr @data, System.Int32 @nativeBufferStartIndex, System.Int32 @graphicsBufferStartIndex, System.Int32 @count, System.Int32 @elemSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @data, @nativeBufferStartIndex, @graphicsBufferStartIndex, @count, @elemSize};
            var ___result = RMInternalSetComputeBufferNativeData_ComputeBuffer_IntPtr_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalSetComputeBufferData(UnityEngine.ComputeBuffer @buffer, System.Array @data, System.Int32 @managedBufferStartIndex, System.Int32 @graphicsBufferStartIndex, System.Int32 @count, System.Int32 @elemSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @data, @managedBufferStartIndex, @graphicsBufferStartIndex, @count, @elemSize};
            var ___result = RMInternalSetComputeBufferData_ComputeBuffer_Array_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalSetComputeBufferCounterValue(UnityEngine.ComputeBuffer @buffer, System.UInt32 @counterValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @counterValue};
            var ___result = RMInternalSetComputeBufferCounterValue_ComputeBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBufferData(UnityEngine.GraphicsBuffer @buffer, System.Array @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @data};
            var ___result = RMSetBufferData_GraphicsBuffer_Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBufferData<T>(UnityEngine.GraphicsBuffer @buffer, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RType> @data) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@buffer, @data.Value};
            var ___result = RMSetBufferData_GT_GraphicsBuffer_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBufferData<T>(UnityEngine.GraphicsBuffer @buffer, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @data) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@buffer, @data.Value};
            var ___result = RMSetBufferData_GT_GraphicsBuffer_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBufferData(UnityEngine.GraphicsBuffer @buffer, System.Array @data, System.Int32 @managedBufferStartIndex, System.Int32 @graphicsBufferStartIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @data, @managedBufferStartIndex, @graphicsBufferStartIndex, @count};
            var ___result = RMSetBufferData_GraphicsBuffer_Array_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBufferData<T>(UnityEngine.GraphicsBuffer @buffer, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RType> @data, System.Int32 @managedBufferStartIndex, System.Int32 @graphicsBufferStartIndex, System.Int32 @count) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@buffer, @data.Value, @managedBufferStartIndex, @graphicsBufferStartIndex, @count};
            var ___result = RMSetBufferData_GT_GraphicsBuffer_List_d_T_p__Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBufferData<T>(UnityEngine.GraphicsBuffer @buffer, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @data, System.Int32 @nativeBufferStartIndex, System.Int32 @graphicsBufferStartIndex, System.Int32 @count) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@buffer, @data.Value, @nativeBufferStartIndex, @graphicsBufferStartIndex, @count};
            var ___result = RMSetBufferData_GT_GraphicsBuffer_NativeArray_d_T_p__Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBufferCounterValue(UnityEngine.GraphicsBuffer @buffer, System.UInt32 @counterValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @counterValue};
            var ___result = RMSetBufferCounterValue_GraphicsBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalSetGraphicsBufferNativeData(UnityEngine.GraphicsBuffer @buffer, System.IntPtr @data, System.Int32 @nativeBufferStartIndex, System.Int32 @graphicsBufferStartIndex, System.Int32 @count, System.Int32 @elemSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @data, @nativeBufferStartIndex, @graphicsBufferStartIndex, @count, @elemSize};
            var ___result = RMInternalSetGraphicsBufferNativeData_GraphicsBuffer_IntPtr_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalSetGraphicsBufferData(UnityEngine.GraphicsBuffer @buffer, System.Array @data, System.Int32 @managedBufferStartIndex, System.Int32 @graphicsBufferStartIndex, System.Int32 @count, System.Int32 @elemSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @data, @managedBufferStartIndex, @graphicsBufferStartIndex, @count, @elemSize};
            var ___result = RMInternalSetGraphicsBufferData_GraphicsBuffer_Array_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalSetGraphicsBufferCounterValue(UnityEngine.GraphicsBuffer @buffer, System.UInt32 @counterValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @counterValue};
            var ___result = RMInternalSetGraphicsBufferCounterValue_GraphicsBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyBufferImpl(UnityEngine.GraphicsBuffer @source, UnityEngine.GraphicsBuffer @dest)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest};
            var ___result = RMCopyBufferImpl_GraphicsBuffer_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
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


        public virtual void Release()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRelease.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rendering.GraphicsFence CreateAsyncGraphicsFence()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateAsyncGraphicsFence.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.GraphicsFence)___result;
        }


        public virtual UnityEngine.Rendering.GraphicsFence CreateAsyncGraphicsFence(UnityEngine.Rendering.SynchronisationStage @stage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stage};
            var ___result = RMCreateAsyncGraphicsFence_SynchronisationStage.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.GraphicsFence)___result;
        }


        public virtual UnityEngine.Rendering.GraphicsFence CreateGraphicsFence(UnityEngine.Rendering.GraphicsFenceType @fenceType, UnityEngine.Rendering.SynchronisationStageFlags @stage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fenceType, @stage};
            var ___result = RMCreateGraphicsFence_GraphicsFenceType_SynchronisationStageFlags.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.GraphicsFence)___result;
        }


        public virtual void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence @fence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fence};
            var ___result = RMWaitOnAsyncGraphicsFence_GraphicsFence.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence @fence, UnityEngine.Rendering.SynchronisationStage @stage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fence, @stage};
            var ___result = RMWaitOnAsyncGraphicsFence_GraphicsFence_SynchronisationStage.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence @fence, UnityEngine.Rendering.SynchronisationStageFlags @stage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fence, @stage};
            var ___result = RMWaitOnAsyncGraphicsFence_GraphicsFence_SynchronisationStageFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeFloatParam(UnityEngine.ComputeShader @computeShader, System.String @name, System.Single @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @name, @val};
            var ___result = RMSetComputeFloatParam_ComputeShader_String_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeIntParam(UnityEngine.ComputeShader @computeShader, System.String @name, System.Int32 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @name, @val};
            var ___result = RMSetComputeIntParam_ComputeShader_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeVectorParam(UnityEngine.ComputeShader @computeShader, System.String @name, UnityEngine.Vector4 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @name, @val};
            var ___result = RMSetComputeVectorParam_ComputeShader_String_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeVectorArrayParam(UnityEngine.ComputeShader @computeShader, System.String @name, UnityEngine.Vector4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @name, @values};
            var ___result = RMSetComputeVectorArrayParam_ComputeShader_String_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeMatrixParam(UnityEngine.ComputeShader @computeShader, System.String @name, UnityEngine.Matrix4x4 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @name, @val};
            var ___result = RMSetComputeMatrixParam_ComputeShader_String_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeMatrixArrayParam(UnityEngine.ComputeShader @computeShader, System.String @name, UnityEngine.Matrix4x4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @name, @values};
            var ___result = RMSetComputeMatrixArrayParam_ComputeShader_String_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeFloatParams(UnityEngine.ComputeShader @computeShader, System.String @name, System.Single[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @name, @values};
            var ___result = RMSetComputeFloatParams_ComputeShader_String_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeFloatParams(UnityEngine.ComputeShader @computeShader, System.Int32 @nameID, System.Single[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @nameID, @values};
            var ___result = RMSetComputeFloatParams_ComputeShader_Int32_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeIntParams(UnityEngine.ComputeShader @computeShader, System.String @name, System.Int32[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @name, @values};
            var ___result = RMSetComputeIntParams_ComputeShader_String_Int32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeIntParams(UnityEngine.ComputeShader @computeShader, System.Int32 @nameID, System.Int32[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @nameID, @values};
            var ___result = RMSetComputeIntParams_ComputeShader_Int32_Int32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeTextureParam(UnityEngine.ComputeShader @computeShader, System.Int32 @kernelIndex, System.String @name, UnityEngine.Rendering.RenderTargetIdentifier @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @name, @rt};
            var ___result = RMSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeTextureParam(UnityEngine.ComputeShader @computeShader, System.Int32 @kernelIndex, System.Int32 @nameID, UnityEngine.Rendering.RenderTargetIdentifier @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @nameID, @rt};
            var ___result = RMSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeTextureParam(UnityEngine.ComputeShader @computeShader, System.Int32 @kernelIndex, System.String @name, UnityEngine.Rendering.RenderTargetIdentifier @rt, System.Int32 @mipLevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @name, @rt, @mipLevel};
            var ___result = RMSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeTextureParam(UnityEngine.ComputeShader @computeShader, System.Int32 @kernelIndex, System.Int32 @nameID, UnityEngine.Rendering.RenderTargetIdentifier @rt, System.Int32 @mipLevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @nameID, @rt, @mipLevel};
            var ___result = RMSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeTextureParam(UnityEngine.ComputeShader @computeShader, System.Int32 @kernelIndex, System.String @name, UnityEngine.Rendering.RenderTargetIdentifier @rt, System.Int32 @mipLevel, UnityEngine.Rendering.RenderTextureSubElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @name, @rt, @mipLevel, @element};
            var ___result = RMSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier_Int32_RenderTextureSubElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeTextureParam(UnityEngine.ComputeShader @computeShader, System.Int32 @kernelIndex, System.Int32 @nameID, UnityEngine.Rendering.RenderTargetIdentifier @rt, System.Int32 @mipLevel, UnityEngine.Rendering.RenderTextureSubElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @nameID, @rt, @mipLevel, @element};
            var ___result = RMSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier_Int32_RenderTextureSubElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeBufferParam(UnityEngine.ComputeShader @computeShader, System.Int32 @kernelIndex, System.Int32 @nameID, UnityEngine.ComputeBuffer @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @nameID, @buffer};
            var ___result = RMSetComputeBufferParam_ComputeShader_Int32_Int32_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeBufferParam(UnityEngine.ComputeShader @computeShader, System.Int32 @kernelIndex, System.String @name, UnityEngine.ComputeBuffer @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @name, @buffer};
            var ___result = RMSetComputeBufferParam_ComputeShader_Int32_String_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeBufferParam(UnityEngine.ComputeShader @computeShader, System.Int32 @kernelIndex, System.Int32 @nameID, UnityEngine.GraphicsBufferHandle @bufferHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @nameID, @bufferHandle};
            var ___result = RMSetComputeBufferParam_ComputeShader_Int32_Int32_GraphicsBufferHandle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeBufferParam(UnityEngine.ComputeShader @computeShader, System.Int32 @kernelIndex, System.String @name, UnityEngine.GraphicsBufferHandle @bufferHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @name, @bufferHandle};
            var ___result = RMSetComputeBufferParam_ComputeShader_Int32_String_GraphicsBufferHandle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeBufferParam(UnityEngine.ComputeShader @computeShader, System.Int32 @kernelIndex, System.Int32 @nameID, UnityEngine.GraphicsBuffer @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @nameID, @buffer};
            var ___result = RMSetComputeBufferParam_ComputeShader_Int32_Int32_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeBufferParam(UnityEngine.ComputeShader @computeShader, System.Int32 @kernelIndex, System.String @name, UnityEngine.GraphicsBuffer @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @name, @buffer};
            var ___result = RMSetComputeBufferParam_ComputeShader_Int32_String_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeConstantBufferParam(UnityEngine.ComputeShader @computeShader, System.Int32 @nameID, UnityEngine.ComputeBuffer @buffer, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @nameID, @buffer, @offset, @size};
            var ___result = RMSetComputeConstantBufferParam_ComputeShader_Int32_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeConstantBufferParam(UnityEngine.ComputeShader @computeShader, System.String @name, UnityEngine.ComputeBuffer @buffer, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @name, @buffer, @offset, @size};
            var ___result = RMSetComputeConstantBufferParam_ComputeShader_String_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeConstantBufferParam(UnityEngine.ComputeShader @computeShader, System.Int32 @nameID, UnityEngine.GraphicsBuffer @buffer, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @nameID, @buffer, @offset, @size};
            var ___result = RMSetComputeConstantBufferParam_ComputeShader_Int32_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeConstantBufferParam(UnityEngine.ComputeShader @computeShader, System.String @name, UnityEngine.GraphicsBuffer @buffer, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @name, @buffer, @offset, @size};
            var ___result = RMSetComputeConstantBufferParam_ComputeShader_String_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeParamsFromMaterial(UnityEngine.ComputeShader @computeShader, System.Int32 @kernelIndex, UnityEngine.Material @material)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @material};
            var ___result = RMSetComputeParamsFromMaterial_ComputeShader_Int32_Material.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DispatchCompute(UnityEngine.ComputeShader @computeShader, System.Int32 @kernelIndex, System.Int32 @threadGroupsX, System.Int32 @threadGroupsY, System.Int32 @threadGroupsZ)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @threadGroupsX, @threadGroupsY, @threadGroupsZ};
            var ___result = RMDispatchCompute_ComputeShader_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DispatchCompute(UnityEngine.ComputeShader @computeShader, System.Int32 @kernelIndex, UnityEngine.ComputeBuffer @indirectBuffer, System.UInt32 @argsOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @indirectBuffer, @argsOffset};
            var ___result = RMDispatchCompute_ComputeShader_Int32_ComputeBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DispatchCompute(UnityEngine.ComputeShader @computeShader, System.Int32 @kernelIndex, UnityEngine.GraphicsBuffer @indirectBuffer, System.UInt32 @argsOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @indirectBuffer, @argsOffset};
            var ___result = RMDispatchCompute_ComputeShader_Int32_GraphicsBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BuildRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure @accelerationStructure)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@accelerationStructure};
            var ___result = RMBuildRayTracingAccelerationStructure_RayTracingAccelerationStructure.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BuildRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure @accelerationStructure, UnityEngine.Vector3 @relativeOrigin)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@accelerationStructure, @relativeOrigin};
            var ___result = RMBuildRayTracingAccelerationStructure_RayTracingAccelerationStructure_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.String @name, UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure @rayTracingAccelerationStructure)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @name, @rayTracingAccelerationStructure};
            var ___result = RMSetRayTracingAccelerationStructure_RayTracingShader_String_RayTracingAccelerationStructure.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.Int32 @nameID, UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure @rayTracingAccelerationStructure)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @rayTracingAccelerationStructure};
            var ___result = RMSetRayTracingAccelerationStructure_RayTracingShader_Int32_RayTracingAccelerationStructure.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.String @name, UnityEngine.ComputeBuffer @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @name, @buffer};
            var ___result = RMSetRayTracingBufferParam_RayTracingShader_String_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.Int32 @nameID, UnityEngine.ComputeBuffer @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @buffer};
            var ___result = RMSetRayTracingBufferParam_RayTracingShader_Int32_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingConstantBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.Int32 @nameID, UnityEngine.ComputeBuffer @buffer, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @buffer, @offset, @size};
            var ___result = RMSetRayTracingConstantBufferParam_RayTracingShader_Int32_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingConstantBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.String @name, UnityEngine.ComputeBuffer @buffer, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @name, @buffer, @offset, @size};
            var ___result = RMSetRayTracingConstantBufferParam_RayTracingShader_String_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingConstantBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.Int32 @nameID, UnityEngine.GraphicsBuffer @buffer, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @buffer, @offset, @size};
            var ___result = RMSetRayTracingConstantBufferParam_RayTracingShader_Int32_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingConstantBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.String @name, UnityEngine.GraphicsBuffer @buffer, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @name, @buffer, @offset, @size};
            var ___result = RMSetRayTracingConstantBufferParam_RayTracingShader_String_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingTextureParam(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.String @name, UnityEngine.Rendering.RenderTargetIdentifier @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @name, @rt};
            var ___result = RMSetRayTracingTextureParam_RayTracingShader_String_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingTextureParam(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.Int32 @nameID, UnityEngine.Rendering.RenderTargetIdentifier @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @rt};
            var ___result = RMSetRayTracingTextureParam_RayTracingShader_Int32_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingFloatParam(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.String @name, System.Single @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @name, @val};
            var ___result = RMSetRayTracingFloatParam_RayTracingShader_String_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingFloatParam(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.Int32 @nameID, System.Single @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @val};
            var ___result = RMSetRayTracingFloatParam_RayTracingShader_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingFloatParams(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.String @name, System.Single[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @name, @values};
            var ___result = RMSetRayTracingFloatParams_RayTracingShader_String_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingFloatParams(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.Int32 @nameID, System.Single[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @values};
            var ___result = RMSetRayTracingFloatParams_RayTracingShader_Int32_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingIntParam(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.String @name, System.Int32 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @name, @val};
            var ___result = RMSetRayTracingIntParam_RayTracingShader_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingIntParam(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.Int32 @nameID, System.Int32 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @val};
            var ___result = RMSetRayTracingIntParam_RayTracingShader_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingIntParams(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.String @name, System.Int32[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @name, @values};
            var ___result = RMSetRayTracingIntParams_RayTracingShader_String_Int32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingIntParams(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.Int32 @nameID, System.Int32[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @values};
            var ___result = RMSetRayTracingIntParams_RayTracingShader_Int32_Int32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingVectorParam(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.String @name, UnityEngine.Vector4 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @name, @val};
            var ___result = RMSetRayTracingVectorParam_RayTracingShader_String_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingVectorParam(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.Int32 @nameID, UnityEngine.Vector4 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @val};
            var ___result = RMSetRayTracingVectorParam_RayTracingShader_Int32_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingVectorArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.String @name, UnityEngine.Vector4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @name, @values};
            var ___result = RMSetRayTracingVectorArrayParam_RayTracingShader_String_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingVectorArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.Int32 @nameID, UnityEngine.Vector4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @values};
            var ___result = RMSetRayTracingVectorArrayParam_RayTracingShader_Int32_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingMatrixParam(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.String @name, UnityEngine.Matrix4x4 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @name, @val};
            var ___result = RMSetRayTracingMatrixParam_RayTracingShader_String_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingMatrixParam(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.Int32 @nameID, UnityEngine.Matrix4x4 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @val};
            var ___result = RMSetRayTracingMatrixParam_RayTracingShader_Int32_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingMatrixArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.String @name, UnityEngine.Matrix4x4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @name, @values};
            var ___result = RMSetRayTracingMatrixArrayParam_RayTracingShader_String_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingMatrixArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.Int32 @nameID, UnityEngine.Matrix4x4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @values};
            var ___result = RMSetRayTracingMatrixArrayParam_RayTracingShader_Int32_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DispatchRays(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.String @rayGenName, System.UInt32 @width, System.UInt32 @height, System.UInt32 @depth, UnityEngine.Camera @camera)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @rayGenName, @width, @height, @depth, @camera};
            var ___result = RMDispatchRays_RayTracingShader_String_UInt32_UInt32_UInt32_Camera.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GenerateMips(UnityEngine.Rendering.RenderTargetIdentifier @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt};
            var ___result = RMGenerateMips_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GenerateMips(UnityEngine.RenderTexture @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt};
            var ___result = RMGenerateMips_RenderTexture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResolveAntiAliasedSurface(UnityEngine.RenderTexture @rt, UnityEngine.RenderTexture @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt, @target};
            var ___result = RMResolveAntiAliasedSurface_RenderTexture_RenderTexture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawMesh(UnityEngine.Mesh @mesh, UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @submeshIndex, System.Int32 @shaderPass, UnityEngine.MaterialPropertyBlock @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @matrix, @material, @submeshIndex, @shaderPass, @properties};
            var ___result = RMDrawMesh_Mesh_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawMesh(UnityEngine.Mesh @mesh, UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @submeshIndex, System.Int32 @shaderPass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @matrix, @material, @submeshIndex, @shaderPass};
            var ___result = RMDrawMesh_Mesh_Matrix4x4_Material_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawMesh(UnityEngine.Mesh @mesh, UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @submeshIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @matrix, @material, @submeshIndex};
            var ___result = RMDrawMesh_Mesh_Matrix4x4_Material_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawMesh(UnityEngine.Mesh @mesh, UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @matrix, @material};
            var ___result = RMDrawMesh_Mesh_Matrix4x4_Material.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawRenderer(UnityEngine.Renderer @renderer, UnityEngine.Material @material, System.Int32 @submeshIndex, System.Int32 @shaderPass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renderer, @material, @submeshIndex, @shaderPass};
            var ___result = RMDrawRenderer_Renderer_Material_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawRenderer(UnityEngine.Renderer @renderer, UnityEngine.Material @material, System.Int32 @submeshIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renderer, @material, @submeshIndex};
            var ___result = RMDrawRenderer_Renderer_Material_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawRenderer(UnityEngine.Renderer @renderer, UnityEngine.Material @material)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renderer, @material};
            var ___result = RMDrawRenderer_Renderer_Material.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawRendererList(UnityEngine.Rendering.RendererList @rendererList)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rendererList};
            var ___result = RMDrawRendererList_RendererList.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProcedural(UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.MeshTopology @topology, System.Int32 @vertexCount, System.Int32 @instanceCount, UnityEngine.MaterialPropertyBlock @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @material, @shaderPass, @topology, @vertexCount, @instanceCount, @properties};
            var ___result = RMDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProcedural(UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.MeshTopology @topology, System.Int32 @vertexCount, System.Int32 @instanceCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @material, @shaderPass, @topology, @vertexCount, @instanceCount};
            var ___result = RMDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProcedural(UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.MeshTopology @topology, System.Int32 @vertexCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @material, @shaderPass, @topology, @vertexCount};
            var ___result = RMDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProcedural(UnityEngine.GraphicsBuffer @indexBuffer, UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.MeshTopology @topology, System.Int32 @indexCount, System.Int32 @instanceCount, UnityEngine.MaterialPropertyBlock @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexBuffer, @matrix, @material, @shaderPass, @topology, @indexCount, @instanceCount, @properties};
            var ___result = RMDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProcedural(UnityEngine.GraphicsBuffer @indexBuffer, UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.MeshTopology @topology, System.Int32 @indexCount, System.Int32 @instanceCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexBuffer, @matrix, @material, @shaderPass, @topology, @indexCount, @instanceCount};
            var ___result = RMDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProcedural(UnityEngine.GraphicsBuffer @indexBuffer, UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.MeshTopology @topology, System.Int32 @indexCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexBuffer, @matrix, @material, @shaderPass, @topology, @indexCount};
            var ___result = RMDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProceduralIndirect(UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.MeshTopology @topology, UnityEngine.ComputeBuffer @bufferWithArgs, System.Int32 @argsOffset, UnityEngine.MaterialPropertyBlock @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @material, @shaderPass, @topology, @bufferWithArgs, @argsOffset, @properties};
            var ___result = RMDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProceduralIndirect(UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.MeshTopology @topology, UnityEngine.ComputeBuffer @bufferWithArgs, System.Int32 @argsOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @material, @shaderPass, @topology, @bufferWithArgs, @argsOffset};
            var ___result = RMDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProceduralIndirect(UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.MeshTopology @topology, UnityEngine.ComputeBuffer @bufferWithArgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @material, @shaderPass, @topology, @bufferWithArgs};
            var ___result = RMDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProceduralIndirect(UnityEngine.GraphicsBuffer @indexBuffer, UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.MeshTopology @topology, UnityEngine.ComputeBuffer @bufferWithArgs, System.Int32 @argsOffset, UnityEngine.MaterialPropertyBlock @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexBuffer, @matrix, @material, @shaderPass, @topology, @bufferWithArgs, @argsOffset, @properties};
            var ___result = RMDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProceduralIndirect(UnityEngine.GraphicsBuffer @indexBuffer, UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.MeshTopology @topology, UnityEngine.ComputeBuffer @bufferWithArgs, System.Int32 @argsOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexBuffer, @matrix, @material, @shaderPass, @topology, @bufferWithArgs, @argsOffset};
            var ___result = RMDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProceduralIndirect(UnityEngine.GraphicsBuffer @indexBuffer, UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.MeshTopology @topology, UnityEngine.ComputeBuffer @bufferWithArgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexBuffer, @matrix, @material, @shaderPass, @topology, @bufferWithArgs};
            var ___result = RMDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProceduralIndirect(UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.MeshTopology @topology, UnityEngine.GraphicsBuffer @bufferWithArgs, System.Int32 @argsOffset, UnityEngine.MaterialPropertyBlock @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @material, @shaderPass, @topology, @bufferWithArgs, @argsOffset, @properties};
            var ___result = RMDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProceduralIndirect(UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.MeshTopology @topology, UnityEngine.GraphicsBuffer @bufferWithArgs, System.Int32 @argsOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @material, @shaderPass, @topology, @bufferWithArgs, @argsOffset};
            var ___result = RMDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProceduralIndirect(UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.MeshTopology @topology, UnityEngine.GraphicsBuffer @bufferWithArgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @material, @shaderPass, @topology, @bufferWithArgs};
            var ___result = RMDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProceduralIndirect(UnityEngine.GraphicsBuffer @indexBuffer, UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.MeshTopology @topology, UnityEngine.GraphicsBuffer @bufferWithArgs, System.Int32 @argsOffset, UnityEngine.MaterialPropertyBlock @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexBuffer, @matrix, @material, @shaderPass, @topology, @bufferWithArgs, @argsOffset, @properties};
            var ___result = RMDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProceduralIndirect(UnityEngine.GraphicsBuffer @indexBuffer, UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.MeshTopology @topology, UnityEngine.GraphicsBuffer @bufferWithArgs, System.Int32 @argsOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexBuffer, @matrix, @material, @shaderPass, @topology, @bufferWithArgs, @argsOffset};
            var ___result = RMDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProceduralIndirect(UnityEngine.GraphicsBuffer @indexBuffer, UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.MeshTopology @topology, UnityEngine.GraphicsBuffer @bufferWithArgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexBuffer, @matrix, @material, @shaderPass, @topology, @bufferWithArgs};
            var ___result = RMDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawMeshInstanced(UnityEngine.Mesh @mesh, System.Int32 @submeshIndex, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.Matrix4x4[] @matrices, System.Int32 @count, UnityEngine.MaterialPropertyBlock @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @submeshIndex, @material, @shaderPass, @matrices, @count, @properties};
            var ___result = RMDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawMeshInstanced(UnityEngine.Mesh @mesh, System.Int32 @submeshIndex, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.Matrix4x4[] @matrices, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @submeshIndex, @material, @shaderPass, @matrices, @count};
            var ___result = RMDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawMeshInstanced(UnityEngine.Mesh @mesh, System.Int32 @submeshIndex, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.Matrix4x4[] @matrices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @submeshIndex, @material, @shaderPass, @matrices};
            var ___result = RMDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawMeshInstancedProcedural(UnityEngine.Mesh @mesh, System.Int32 @submeshIndex, UnityEngine.Material @material, System.Int32 @shaderPass, System.Int32 @count, UnityEngine.MaterialPropertyBlock @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @submeshIndex, @material, @shaderPass, @count, @properties};
            var ___result = RMDrawMeshInstancedProcedural_Mesh_Int32_Material_Int32_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawMeshInstancedIndirect(UnityEngine.Mesh @mesh, System.Int32 @submeshIndex, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.ComputeBuffer @bufferWithArgs, System.Int32 @argsOffset, UnityEngine.MaterialPropertyBlock @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @submeshIndex, @material, @shaderPass, @bufferWithArgs, @argsOffset, @properties};
            var ___result = RMDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawMeshInstancedIndirect(UnityEngine.Mesh @mesh, System.Int32 @submeshIndex, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.ComputeBuffer @bufferWithArgs, System.Int32 @argsOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @submeshIndex, @material, @shaderPass, @bufferWithArgs, @argsOffset};
            var ___result = RMDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawMeshInstancedIndirect(UnityEngine.Mesh @mesh, System.Int32 @submeshIndex, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.ComputeBuffer @bufferWithArgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @submeshIndex, @material, @shaderPass, @bufferWithArgs};
            var ___result = RMDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawMeshInstancedIndirect(UnityEngine.Mesh @mesh, System.Int32 @submeshIndex, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.GraphicsBuffer @bufferWithArgs, System.Int32 @argsOffset, UnityEngine.MaterialPropertyBlock @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @submeshIndex, @material, @shaderPass, @bufferWithArgs, @argsOffset, @properties};
            var ___result = RMDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawMeshInstancedIndirect(UnityEngine.Mesh @mesh, System.Int32 @submeshIndex, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.GraphicsBuffer @bufferWithArgs, System.Int32 @argsOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @submeshIndex, @material, @shaderPass, @bufferWithArgs, @argsOffset};
            var ___result = RMDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawMeshInstancedIndirect(UnityEngine.Mesh @mesh, System.Int32 @submeshIndex, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.GraphicsBuffer @bufferWithArgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @submeshIndex, @material, @shaderPass, @bufferWithArgs};
            var ___result = RMDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawOcclusionMesh(UnityEngine.RectInt @normalizedCamViewport)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@normalizedCamViewport};
            var ___result = RMDrawOcclusionMesh_RectInt.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRandomWriteTarget(System.Int32 @index, UnityEngine.Rendering.RenderTargetIdentifier @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @rt};
            var ___result = RMSetRandomWriteTarget_Int32_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRandomWriteTarget(System.Int32 @index, UnityEngine.ComputeBuffer @buffer, System.Boolean @preserveCounterValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @buffer, @preserveCounterValue};
            var ___result = RMSetRandomWriteTarget_Int32_ComputeBuffer_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRandomWriteTarget(System.Int32 @index, UnityEngine.ComputeBuffer @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @buffer};
            var ___result = RMSetRandomWriteTarget_Int32_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRandomWriteTarget(System.Int32 @index, UnityEngine.GraphicsBuffer @buffer, System.Boolean @preserveCounterValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @buffer, @preserveCounterValue};
            var ___result = RMSetRandomWriteTarget_Int32_GraphicsBuffer_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRandomWriteTarget(System.Int32 @index, UnityEngine.GraphicsBuffer @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @buffer};
            var ___result = RMSetRandomWriteTarget_Int32_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyCounterValue(UnityEngine.ComputeBuffer @src, UnityEngine.ComputeBuffer @dst, System.UInt32 @dstOffsetBytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst, @dstOffsetBytes};
            var ___result = RMCopyCounterValue_ComputeBuffer_ComputeBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyCounterValue(UnityEngine.GraphicsBuffer @src, UnityEngine.ComputeBuffer @dst, System.UInt32 @dstOffsetBytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst, @dstOffsetBytes};
            var ___result = RMCopyCounterValue_GraphicsBuffer_ComputeBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyCounterValue(UnityEngine.ComputeBuffer @src, UnityEngine.GraphicsBuffer @dst, System.UInt32 @dstOffsetBytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst, @dstOffsetBytes};
            var ___result = RMCopyCounterValue_ComputeBuffer_GraphicsBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyCounterValue(UnityEngine.GraphicsBuffer @src, UnityEngine.GraphicsBuffer @dst, System.UInt32 @dstOffsetBytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst, @dstOffsetBytes};
            var ___result = RMCopyCounterValue_GraphicsBuffer_GraphicsBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTexture(UnityEngine.Rendering.RenderTargetIdentifier @src, UnityEngine.Rendering.RenderTargetIdentifier @dst)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst};
            var ___result = RMCopyTexture_RenderTargetIdentifier_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTexture(UnityEngine.Rendering.RenderTargetIdentifier @src, System.Int32 @srcElement, UnityEngine.Rendering.RenderTargetIdentifier @dst, System.Int32 @dstElement)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @srcElement, @dst, @dstElement};
            var ___result = RMCopyTexture_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTexture(UnityEngine.Rendering.RenderTargetIdentifier @src, System.Int32 @srcElement, System.Int32 @srcMip, UnityEngine.Rendering.RenderTargetIdentifier @dst, System.Int32 @dstElement, System.Int32 @dstMip)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @srcElement, @srcMip, @dst, @dstElement, @dstMip};
            var ___result = RMCopyTexture_RenderTargetIdentifier_Int32_Int32_RenderTargetIdentifier_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTexture(UnityEngine.Rendering.RenderTargetIdentifier @src, System.Int32 @srcElement, System.Int32 @srcMip, System.Int32 @srcX, System.Int32 @srcY, System.Int32 @srcWidth, System.Int32 @srcHeight, UnityEngine.Rendering.RenderTargetIdentifier @dst, System.Int32 @dstElement, System.Int32 @dstMip, System.Int32 @dstX, System.Int32 @dstY)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @srcElement, @srcMip, @srcX, @srcY, @srcWidth, @srcHeight, @dst, @dstElement, @dstMip, @dstX, @dstY};
            var ___result = RMCopyTexture_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32_Int32_RenderTargetIdentifier_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blit(UnityEngine.Texture @source, UnityEngine.Rendering.RenderTargetIdentifier @dest)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest};
            var ___result = RMBlit_Texture_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blit(UnityEngine.Texture @source, UnityEngine.Rendering.RenderTargetIdentifier @dest, UnityEngine.Vector2 @scale, UnityEngine.Vector2 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest, @scale, @offset};
            var ___result = RMBlit_Texture_RenderTargetIdentifier_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blit(UnityEngine.Texture @source, UnityEngine.Rendering.RenderTargetIdentifier @dest, UnityEngine.Material @mat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest, @mat};
            var ___result = RMBlit_Texture_RenderTargetIdentifier_Material.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blit(UnityEngine.Texture @source, UnityEngine.Rendering.RenderTargetIdentifier @dest, UnityEngine.Material @mat, System.Int32 @pass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest, @mat, @pass};
            var ___result = RMBlit_Texture_RenderTargetIdentifier_Material_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blit(UnityEngine.Rendering.RenderTargetIdentifier @source, UnityEngine.Rendering.RenderTargetIdentifier @dest)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest};
            var ___result = RMBlit_RenderTargetIdentifier_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blit(UnityEngine.Rendering.RenderTargetIdentifier @source, UnityEngine.Rendering.RenderTargetIdentifier @dest, UnityEngine.Vector2 @scale, UnityEngine.Vector2 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest, @scale, @offset};
            var ___result = RMBlit_RenderTargetIdentifier_RenderTargetIdentifier_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blit(UnityEngine.Rendering.RenderTargetIdentifier @source, UnityEngine.Rendering.RenderTargetIdentifier @dest, UnityEngine.Material @mat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest, @mat};
            var ___result = RMBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blit(UnityEngine.Rendering.RenderTargetIdentifier @source, UnityEngine.Rendering.RenderTargetIdentifier @dest, UnityEngine.Material @mat, System.Int32 @pass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest, @mat, @pass};
            var ___result = RMBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blit(UnityEngine.Rendering.RenderTargetIdentifier @source, UnityEngine.Rendering.RenderTargetIdentifier @dest, System.Int32 @sourceDepthSlice, System.Int32 @destDepthSlice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest, @sourceDepthSlice, @destDepthSlice};
            var ___result = RMBlit_RenderTargetIdentifier_RenderTargetIdentifier_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blit(UnityEngine.Rendering.RenderTargetIdentifier @source, UnityEngine.Rendering.RenderTargetIdentifier @dest, UnityEngine.Vector2 @scale, UnityEngine.Vector2 @offset, System.Int32 @sourceDepthSlice, System.Int32 @destDepthSlice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest, @scale, @offset, @sourceDepthSlice, @destDepthSlice};
            var ___result = RMBlit_RenderTargetIdentifier_RenderTargetIdentifier_Vector2_Vector2_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blit(UnityEngine.Rendering.RenderTargetIdentifier @source, UnityEngine.Rendering.RenderTargetIdentifier @dest, UnityEngine.Material @mat, System.Int32 @pass, System.Int32 @destDepthSlice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest, @mat, @pass, @destDepthSlice};
            var ___result = RMBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalFloat(System.String @name, System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetGlobalFloat_String_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalInt(System.String @name, System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetGlobalInt_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalInteger(System.String @name, System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetGlobalInteger_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalVector(System.String @name, UnityEngine.Vector4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetGlobalVector_String_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalColor(System.String @name, UnityEngine.Color @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetGlobalColor_String_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalMatrix(System.String @name, UnityEngine.Matrix4x4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetGlobalMatrix_String_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalFloatArray(System.String @propertyName, System.Collections.Generic.List<System.Single> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName, @values};
            var ___result = RMSetGlobalFloatArray_String_List_d_Single_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalFloatArray(System.Int32 @nameID, System.Collections.Generic.List<System.Single> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetGlobalFloatArray_Int32_List_d_Single_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalFloatArray(System.String @propertyName, System.Single[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName, @values};
            var ___result = RMSetGlobalFloatArray_String_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalVectorArray(System.String @propertyName, System.Collections.Generic.List<UnityEngine.Vector4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName, @values};
            var ___result = RMSetGlobalVectorArray_String_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalVectorArray(System.Int32 @nameID, System.Collections.Generic.List<UnityEngine.Vector4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetGlobalVectorArray_Int32_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalVectorArray(System.String @propertyName, UnityEngine.Vector4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName, @values};
            var ___result = RMSetGlobalVectorArray_String_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalMatrixArray(System.String @propertyName, System.Collections.Generic.List<UnityEngine.Matrix4x4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName, @values};
            var ___result = RMSetGlobalMatrixArray_String_List_d_Matrix4x4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalMatrixArray(System.Int32 @nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalMatrixArray(System.String @propertyName, UnityEngine.Matrix4x4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName, @values};
            var ___result = RMSetGlobalMatrixArray_String_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalTexture(System.String @name, UnityEngine.Rendering.RenderTargetIdentifier @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetGlobalTexture_String_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalTexture(System.Int32 @nameID, UnityEngine.Rendering.RenderTargetIdentifier @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetGlobalTexture_Int32_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalTexture(System.String @name, UnityEngine.Rendering.RenderTargetIdentifier @value, UnityEngine.Rendering.RenderTextureSubElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value, @element};
            var ___result = RMSetGlobalTexture_String_RenderTargetIdentifier_RenderTextureSubElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalTexture(System.Int32 @nameID, UnityEngine.Rendering.RenderTargetIdentifier @value, UnityEngine.Rendering.RenderTextureSubElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value, @element};
            var ___result = RMSetGlobalTexture_Int32_RenderTargetIdentifier_RenderTextureSubElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalBuffer(System.String @name, UnityEngine.ComputeBuffer @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetGlobalBuffer_String_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalBuffer(System.Int32 @nameID, UnityEngine.ComputeBuffer @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetGlobalBuffer_Int32_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalBuffer(System.String @name, UnityEngine.GraphicsBuffer @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetGlobalBuffer_String_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalBuffer(System.Int32 @nameID, UnityEngine.GraphicsBuffer @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetGlobalBuffer_Int32_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer @buffer, System.Int32 @nameID, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @nameID, @offset, @size};
            var ___result = RMSetGlobalConstantBuffer_ComputeBuffer_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer @buffer, System.String @name, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @name, @offset, @size};
            var ___result = RMSetGlobalConstantBuffer_ComputeBuffer_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer @buffer, System.Int32 @nameID, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @nameID, @offset, @size};
            var ___result = RMSetGlobalConstantBuffer_GraphicsBuffer_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer @buffer, System.String @name, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @name, @offset, @size};
            var ___result = RMSetGlobalConstantBuffer_GraphicsBuffer_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetShadowSamplingMode(UnityEngine.Rendering.RenderTargetIdentifier @shadowmap, UnityEngine.Rendering.ShadowSamplingMode @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shadowmap, @mode};
            var ___result = RMSetShadowSamplingMode_RenderTargetIdentifier_ShadowSamplingMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSinglePassStereo(UnityEngine.Rendering.SinglePassStereoMode @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mode};
            var ___result = RMSetSinglePassStereo_SinglePassStereoMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IssuePluginEvent(System.IntPtr @callback, System.Int32 @eventID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @eventID};
            var ___result = RMIssuePluginEvent_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IssuePluginEventAndData(System.IntPtr @callback, System.Int32 @eventID, System.IntPtr @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @eventID, @data};
            var ___result = RMIssuePluginEventAndData_IntPtr_Int32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IssuePluginEventAndDataWithFlags(System.IntPtr @callback, System.Int32 @eventID, UnityEngine.Rendering.CustomMarkerCallbackFlags @flags, System.IntPtr @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @eventID, @flags, @data};
            var ___result = RMIssuePluginEventAndDataWithFlags_IntPtr_Int32_CustomMarkerCallbackFlags_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IssuePluginCustomBlit(System.IntPtr @callback, System.UInt32 @command, UnityEngine.Rendering.RenderTargetIdentifier @source, UnityEngine.Rendering.RenderTargetIdentifier @dest, System.UInt32 @commandParam, System.UInt32 @commandFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @command, @source, @dest, @commandParam, @commandFlags};
            var ___result = RMIssuePluginCustomBlit_IntPtr_UInt32_RenderTargetIdentifier_RenderTargetIdentifier_UInt32_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IssuePluginCustomTextureUpdate(System.IntPtr @callback, UnityEngine.Texture @targetTexture, System.UInt32 @userData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @targetTexture, @userData};
            var ___result = RMIssuePluginCustomTextureUpdate_IntPtr_Texture_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IssuePluginCustomTextureUpdateV1(System.IntPtr @callback, UnityEngine.Texture @targetTexture, System.UInt32 @userData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @targetTexture, @userData};
            var ___result = RMIssuePluginCustomTextureUpdateV1_IntPtr_Texture_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IssuePluginCustomTextureUpdateV2(System.IntPtr @callback, UnityEngine.Texture @targetTexture, System.UInt32 @userData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @targetTexture, @userData};
            var ___result = RMIssuePluginCustomTextureUpdateV2_IntPtr_Texture_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessVTFeedback(UnityEngine.Rendering.RenderTargetIdentifier @rt, System.IntPtr @resolver, System.Int32 @slice, System.Int32 @x, System.Int32 @width, System.Int32 @y, System.Int32 @height, System.Int32 @mip)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt, @resolver, @slice, @x, @width, @y, @height, @mip};
            var ___result = RMProcessVTFeedback_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyBuffer(UnityEngine.GraphicsBuffer @source, UnityEngine.GraphicsBuffer @dest)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest};
            var ___result = RMCopyBuffer_GraphicsBuffer_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rendering.GraphicsFence CreateGPUFence(UnityEngine.Rendering.SynchronisationStage @stage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stage};
            var ___result = RMCreateGPUFence_SynchronisationStage.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.GraphicsFence)___result;
        }


        public virtual UnityEngine.Rendering.GraphicsFence CreateGPUFence()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateGPUFence.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.GraphicsFence)___result;
        }


        public virtual void WaitOnGPUFence(UnityEngine.Rendering.GraphicsFence @fence, UnityEngine.Rendering.SynchronisationStage @stage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fence, @stage};
            var ___result = RMWaitOnGPUFence_GPUFence_SynchronisationStage.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WaitOnGPUFence(UnityEngine.Rendering.GraphicsFence @fence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fence};
            var ___result = RMWaitOnGPUFence_GPUFence.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeBufferData(UnityEngine.ComputeBuffer @buffer, System.Array @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @data};
            var ___result = RMSetComputeBufferData_ComputeBuffer_Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeBufferData<T>(UnityEngine.ComputeBuffer @buffer, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RType> @data) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@buffer, @data.Value};
            var ___result = RMSetComputeBufferData_GT_ComputeBuffer_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeBufferData<T>(UnityEngine.ComputeBuffer @buffer, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @data) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@buffer, @data.Value};
            var ___result = RMSetComputeBufferData_GT_ComputeBuffer_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeBufferData(UnityEngine.ComputeBuffer @buffer, System.Array @data, System.Int32 @managedBufferStartIndex, System.Int32 @graphicsBufferStartIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @data, @managedBufferStartIndex, @graphicsBufferStartIndex, @count};
            var ___result = RMSetComputeBufferData_ComputeBuffer_Array_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeBufferData<T>(UnityEngine.ComputeBuffer @buffer, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RType> @data, System.Int32 @managedBufferStartIndex, System.Int32 @graphicsBufferStartIndex, System.Int32 @count) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@buffer, @data.Value, @managedBufferStartIndex, @graphicsBufferStartIndex, @count};
            var ___result = RMSetComputeBufferData_GT_ComputeBuffer_List_d_T_p__Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeBufferData<T>(UnityEngine.ComputeBuffer @buffer, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @data, System.Int32 @nativeBufferStartIndex, System.Int32 @graphicsBufferStartIndex, System.Int32 @count) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@buffer, @data.Value, @nativeBufferStartIndex, @graphicsBufferStartIndex, @count};
            var ___result = RMSetComputeBufferData_GT_ComputeBuffer_NativeArray_d_T_p__Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeBufferCounterValue(UnityEngine.ComputeBuffer @buffer, System.UInt32 @counterValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @counterValue};
            var ___result = RMSetComputeBufferCounterValue_ComputeBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ConvertTexture_Internal_Injected(ref UnityEngine.Rendering.RenderTargetIdentifier @src, System.Int32 @srcElement, ref UnityEngine.Rendering.RenderTargetIdentifier @dst, System.Int32 @dstElement)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @srcElement, @dst, @dstElement};
            var ___result = RMConvertTexture_Internal_Injected_Ref_RenderTargetIdentifier_Int32_Ref_RenderTargetIdentifier_Int32.Invoke(___genericsType, ___parameters);
			@src = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[0];
			@dst = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[2];

            
        }


        public virtual void SetComputeVectorParam_Injected(UnityEngine.ComputeShader @computeShader, System.Int32 @nameID, ref UnityEngine.Vector4 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @nameID, @val};
            var ___result = RMSetComputeVectorParam_Injected_ComputeShader_Int32_Ref_Vector4.Invoke(___genericsType, ___parameters);
			@val = (UnityEngine.Vector4)___parameters[2];

            
        }


        public virtual void SetComputeMatrixParam_Injected(UnityEngine.ComputeShader @computeShader, System.Int32 @nameID, ref UnityEngine.Matrix4x4 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @nameID, @val};
            var ___result = RMSetComputeMatrixParam_Injected_ComputeShader_Int32_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			@val = (UnityEngine.Matrix4x4)___parameters[2];

            
        }


        public virtual void Internal_SetComputeGraphicsBufferHandleParam_Injected(UnityEngine.ComputeShader @computeShader, System.Int32 @kernelIndex, System.Int32 @nameID, ref UnityEngine.GraphicsBufferHandle @bufferHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @nameID, @bufferHandle};
            var ___result = RMInternal_SetComputeGraphicsBufferHandleParam_Injected_ComputeShader_Int32_Int32_Ref_GraphicsBufferHandle.Invoke(___genericsType, ___parameters);
			@bufferHandle = (UnityEngine.GraphicsBufferHandle)___parameters[3];

            
        }


        public virtual void Internal_SetRayTracingVectorParam_Injected(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.Int32 @nameID, ref UnityEngine.Vector4 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @val};
            var ___result = RMInternal_SetRayTracingVectorParam_Injected_RayTracingShader_Int32_Ref_Vector4.Invoke(___genericsType, ___parameters);
			@val = (UnityEngine.Vector4)___parameters[2];

            
        }


        public virtual void Internal_SetRayTracingMatrixParam_Injected(UnityEngine.Experimental.Rendering.RayTracingShader @rayTracingShader, System.Int32 @nameID, ref UnityEngine.Matrix4x4 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @val};
            var ___result = RMInternal_SetRayTracingMatrixParam_Injected_RayTracingShader_Int32_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			@val = (UnityEngine.Matrix4x4)___parameters[2];

            
        }


        public virtual void Internal_BuildRayTracingAccelerationStructure_Injected(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure @accelerationStructure, ref UnityEngine.Vector3 @relativeOrigin)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@accelerationStructure, @relativeOrigin};
            var ___result = RMInternal_BuildRayTracingAccelerationStructure_Injected_RayTracingAccelerationStructure_Ref_Vector3.Invoke(___genericsType, ___parameters);
			@relativeOrigin = (UnityEngine.Vector3)___parameters[1];

            
        }


        public virtual void Internal_GenerateMips_Injected(ref UnityEngine.Rendering.RenderTargetIdentifier @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt};
            var ___result = RMInternal_GenerateMips_Injected_Ref_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);
			@rt = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[0];

            
        }


        public virtual void Internal_DrawMesh_Injected(UnityEngine.Mesh @mesh, ref UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @submeshIndex, System.Int32 @shaderPass, UnityEngine.MaterialPropertyBlock @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @matrix, @material, @submeshIndex, @shaderPass, @properties};
            var ___result = RMInternal_DrawMesh_Injected_Mesh_Ref_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);
			@matrix = (UnityEngine.Matrix4x4)___parameters[1];

            
        }


        public virtual void Internal_DrawRendererList_Injected(ref UnityEngine.Rendering.RendererList @rendererList)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rendererList};
            var ___result = RMInternal_DrawRendererList_Injected_Ref_RendererList.Invoke(___genericsType, ___parameters);
			@rendererList = (UnityEngine.Rendering.RendererList)___parameters[0];

            
        }


        public virtual void Internal_DrawProcedural_Injected(ref UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.MeshTopology @topology, System.Int32 @vertexCount, System.Int32 @instanceCount, UnityEngine.MaterialPropertyBlock @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @material, @shaderPass, @topology, @vertexCount, @instanceCount, @properties};
            var ___result = RMInternal_DrawProcedural_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);
			@matrix = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void Internal_DrawProceduralIndexed_Injected(UnityEngine.GraphicsBuffer @indexBuffer, ref UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.MeshTopology @topology, System.Int32 @indexCount, System.Int32 @instanceCount, UnityEngine.MaterialPropertyBlock @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexBuffer, @matrix, @material, @shaderPass, @topology, @indexCount, @instanceCount, @properties};
            var ___result = RMInternal_DrawProceduralIndexed_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);
			@matrix = (UnityEngine.Matrix4x4)___parameters[1];

            
        }


        public virtual void Internal_DrawProceduralIndirect_Injected(ref UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.MeshTopology @topology, UnityEngine.ComputeBuffer @bufferWithArgs, System.Int32 @argsOffset, UnityEngine.MaterialPropertyBlock @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @material, @shaderPass, @topology, @bufferWithArgs, @argsOffset, @properties};
            var ___result = RMInternal_DrawProceduralIndirect_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);
			@matrix = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void Internal_DrawProceduralIndexedIndirect_Injected(UnityEngine.GraphicsBuffer @indexBuffer, ref UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.MeshTopology @topology, UnityEngine.ComputeBuffer @bufferWithArgs, System.Int32 @argsOffset, UnityEngine.MaterialPropertyBlock @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexBuffer, @matrix, @material, @shaderPass, @topology, @bufferWithArgs, @argsOffset, @properties};
            var ___result = RMInternal_DrawProceduralIndexedIndirect_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);
			@matrix = (UnityEngine.Matrix4x4)___parameters[1];

            
        }


        public virtual void Internal_DrawProceduralIndirectGraphicsBuffer_Injected(ref UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.MeshTopology @topology, UnityEngine.GraphicsBuffer @bufferWithArgs, System.Int32 @argsOffset, UnityEngine.MaterialPropertyBlock @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @material, @shaderPass, @topology, @bufferWithArgs, @argsOffset, @properties};
            var ___result = RMInternal_DrawProceduralIndirectGraphicsBuffer_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);
			@matrix = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected(UnityEngine.GraphicsBuffer @indexBuffer, ref UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Int32 @shaderPass, UnityEngine.MeshTopology @topology, UnityEngine.GraphicsBuffer @bufferWithArgs, System.Int32 @argsOffset, UnityEngine.MaterialPropertyBlock @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexBuffer, @matrix, @material, @shaderPass, @topology, @bufferWithArgs, @argsOffset, @properties};
            var ___result = RMInternal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);
			@matrix = (UnityEngine.Matrix4x4)___parameters[1];

            
        }


        public virtual void Internal_DrawOcclusionMesh_Injected(ref UnityEngine.RectInt @normalizedCamViewport)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@normalizedCamViewport};
            var ___result = RMInternal_DrawOcclusionMesh_Injected_Ref_RectInt.Invoke(___genericsType, ___parameters);
			@normalizedCamViewport = (UnityEngine.RectInt)___parameters[0];

            
        }


        public virtual void SetViewport_Injected(ref UnityEngine.Rect @pixelRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pixelRect};
            var ___result = RMSetViewport_Injected_Ref_Rect.Invoke(___genericsType, ___parameters);
			@pixelRect = (UnityEngine.Rect)___parameters[0];

            
        }


        public virtual void EnableScissorRect_Injected(ref UnityEngine.Rect @scissor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scissor};
            var ___result = RMEnableScissorRect_Injected_Ref_Rect.Invoke(___genericsType, ___parameters);
			@scissor = (UnityEngine.Rect)___parameters[0];

            
        }


        public virtual void Blit_Texture_Injected(UnityEngine.Texture @source, ref UnityEngine.Rendering.RenderTargetIdentifier @dest, UnityEngine.Material @mat, System.Int32 @pass, ref UnityEngine.Vector2 @scale, ref UnityEngine.Vector2 @offset, System.Int32 @sourceDepthSlice, System.Int32 @destDepthSlice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest, @mat, @pass, @scale, @offset, @sourceDepthSlice, @destDepthSlice};
            var ___result = RMBlit_Texture_Injected_Texture_Ref_RenderTargetIdentifier_Material_Int32_Ref_Vector2_Ref_Vector2_Int32_Int32.Invoke(___genericsType, ___parameters);
			@dest = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[1];
			@scale = (UnityEngine.Vector2)___parameters[4];
			@offset = (UnityEngine.Vector2)___parameters[5];

            
        }


        public virtual void Blit_Identifier_Injected(ref UnityEngine.Rendering.RenderTargetIdentifier @source, ref UnityEngine.Rendering.RenderTargetIdentifier @dest, UnityEngine.Material @mat, System.Int32 @pass, ref UnityEngine.Vector2 @scale, ref UnityEngine.Vector2 @offset, System.Int32 @sourceDepthSlice, System.Int32 @destDepthSlice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest, @mat, @pass, @scale, @offset, @sourceDepthSlice, @destDepthSlice};
            var ___result = RMBlit_Identifier_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_Material_Int32_Ref_Vector2_Ref_Vector2_Int32_Int32.Invoke(___genericsType, ___parameters);
			@source = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[0];
			@dest = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[1];
			@scale = (UnityEngine.Vector2)___parameters[4];
			@offset = (UnityEngine.Vector2)___parameters[5];

            
        }


        public virtual void GetTemporaryRTWithDescriptor_Injected(System.Int32 @nameID, ref UnityEngine.RenderTextureDescriptor @desc, UnityEngine.FilterMode @filter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @desc, @filter};
            var ___result = RMGetTemporaryRTWithDescriptor_Injected_Int32_Ref_RenderTextureDescriptor_FilterMode.Invoke(___genericsType, ___parameters);
			@desc = (UnityEngine.RenderTextureDescriptor)___parameters[1];

            
        }


        public virtual void ClearRenderTarget_Injected(UnityEngine.Rendering.RTClearFlags @clearFlags, ref UnityEngine.Color @backgroundColor, System.Single @depth, System.UInt32 @stencil)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clearFlags, @backgroundColor, @depth, @stencil};
            var ___result = RMClearRenderTarget_Injected_RTClearFlags_Ref_Color_Single_UInt32.Invoke(___genericsType, ___parameters);
			@backgroundColor = (UnityEngine.Color)___parameters[1];

            
        }


        public virtual void SetGlobalVector_Injected(System.Int32 @nameID, ref UnityEngine.Vector4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetGlobalVector_Injected_Int32_Ref_Vector4.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Vector4)___parameters[1];

            
        }


        public virtual void SetGlobalColor_Injected(System.Int32 @nameID, ref UnityEngine.Color @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetGlobalColor_Injected_Int32_Ref_Color.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Color)___parameters[1];

            
        }


        public virtual void SetGlobalMatrix_Injected(System.Int32 @nameID, ref UnityEngine.Matrix4x4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetGlobalMatrix_Injected_Int32_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Matrix4x4)___parameters[1];

            
        }


        public virtual void EnableGlobalKeyword_Injected(ref UnityEngine.Rendering.GlobalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMEnableGlobalKeyword_Injected_Ref_GlobalKeyword.Invoke(___genericsType, ___parameters);
			@keyword = (UnityEngine.Rendering.GlobalKeyword)___parameters[0];

            
        }


        public virtual void EnableMaterialKeyword_Injected(UnityEngine.Material @material, ref UnityEngine.Rendering.LocalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@material, @keyword};
            var ___result = RMEnableMaterialKeyword_Injected_Material_Ref_LocalKeyword.Invoke(___genericsType, ___parameters);
			@keyword = (UnityEngine.Rendering.LocalKeyword)___parameters[1];

            
        }


        public virtual void EnableComputeKeyword_Injected(UnityEngine.ComputeShader @computeShader, ref UnityEngine.Rendering.LocalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @keyword};
            var ___result = RMEnableComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword.Invoke(___genericsType, ___parameters);
			@keyword = (UnityEngine.Rendering.LocalKeyword)___parameters[1];

            
        }


        public virtual void DisableGlobalKeyword_Injected(ref UnityEngine.Rendering.GlobalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMDisableGlobalKeyword_Injected_Ref_GlobalKeyword.Invoke(___genericsType, ___parameters);
			@keyword = (UnityEngine.Rendering.GlobalKeyword)___parameters[0];

            
        }


        public virtual void DisableMaterialKeyword_Injected(UnityEngine.Material @material, ref UnityEngine.Rendering.LocalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@material, @keyword};
            var ___result = RMDisableMaterialKeyword_Injected_Material_Ref_LocalKeyword.Invoke(___genericsType, ___parameters);
			@keyword = (UnityEngine.Rendering.LocalKeyword)___parameters[1];

            
        }


        public virtual void DisableComputeKeyword_Injected(UnityEngine.ComputeShader @computeShader, ref UnityEngine.Rendering.LocalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @keyword};
            var ___result = RMDisableComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword.Invoke(___genericsType, ___parameters);
			@keyword = (UnityEngine.Rendering.LocalKeyword)___parameters[1];

            
        }


        public virtual void SetGlobalKeyword_Injected(ref UnityEngine.Rendering.GlobalKeyword @keyword, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword, @value};
            var ___result = RMSetGlobalKeyword_Injected_Ref_GlobalKeyword_Boolean.Invoke(___genericsType, ___parameters);
			@keyword = (UnityEngine.Rendering.GlobalKeyword)___parameters[0];

            
        }


        public virtual void SetMaterialKeyword_Injected(UnityEngine.Material @material, ref UnityEngine.Rendering.LocalKeyword @keyword, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@material, @keyword, @value};
            var ___result = RMSetMaterialKeyword_Injected_Material_Ref_LocalKeyword_Boolean.Invoke(___genericsType, ___parameters);
			@keyword = (UnityEngine.Rendering.LocalKeyword)___parameters[1];

            
        }


        public virtual void SetComputeKeyword_Injected(UnityEngine.ComputeShader @computeShader, ref UnityEngine.Rendering.LocalKeyword @keyword, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @keyword, @value};
            var ___result = RMSetComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword_Boolean.Invoke(___genericsType, ___parameters);
			@keyword = (UnityEngine.Rendering.LocalKeyword)___parameters[1];

            
        }


        public virtual void SetViewMatrix_Injected(ref UnityEngine.Matrix4x4 @view)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@view};
            var ___result = RMSetViewMatrix_Injected_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			@view = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void SetProjectionMatrix_Injected(ref UnityEngine.Matrix4x4 @proj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@proj};
            var ___result = RMSetProjectionMatrix_Injected_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			@proj = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void SetViewProjectionMatrices_Injected(ref UnityEngine.Matrix4x4 @view, ref UnityEngine.Matrix4x4 @proj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@view, @proj};
            var ___result = RMSetViewProjectionMatrices_Injected_Ref_Matrix4x4_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			@view = (UnityEngine.Matrix4x4)___parameters[0];
			@proj = (UnityEngine.Matrix4x4)___parameters[1];

            
        }


        public virtual void IncrementUpdateCount_Injected(ref UnityEngine.Rendering.RenderTargetIdentifier @dest)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dest};
            var ___result = RMIncrementUpdateCount_Injected_Ref_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);
			@dest = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[0];

            
        }


        public virtual void SetRenderTargetSingle_Internal_Injected(ref UnityEngine.Rendering.RenderTargetIdentifier @rt, UnityEngine.Rendering.RenderBufferLoadAction @colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction @colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction @depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction @depthStoreAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt, @colorLoadAction, @colorStoreAction, @depthLoadAction, @depthStoreAction};
            var ___result = RMSetRenderTargetSingle_Internal_Injected_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction.Invoke(___genericsType, ___parameters);
			@rt = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[0];

            
        }


        public virtual void SetRenderTargetColorDepth_Internal_Injected(ref UnityEngine.Rendering.RenderTargetIdentifier @color, ref UnityEngine.Rendering.RenderTargetIdentifier @depth, UnityEngine.Rendering.RenderBufferLoadAction @colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction @colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction @depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction @depthStoreAction, UnityEngine.Rendering.RenderTargetFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color, @depth, @colorLoadAction, @colorStoreAction, @depthLoadAction, @depthStoreAction, @flags};
            var ___result = RMSetRenderTargetColorDepth_Internal_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags.Invoke(___genericsType, ___parameters);
			@color = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[0];
			@depth = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[1];

            
        }


        public virtual void SetRenderTargetMulti_Internal_Injected(UnityEngine.Rendering.RenderTargetIdentifier[] @colors, ref UnityEngine.Rendering.RenderTargetIdentifier @depth, UnityEngine.Rendering.RenderBufferLoadAction[] @colorLoadActions, UnityEngine.Rendering.RenderBufferStoreAction[] @colorStoreActions, UnityEngine.Rendering.RenderBufferLoadAction @depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction @depthStoreAction, UnityEngine.Rendering.RenderTargetFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colors, @depth, @colorLoadActions, @colorStoreActions, @depthLoadAction, @depthStoreAction, @flags};
            var ___result = RMSetRenderTargetMulti_Internal_Injected_RenderTargetIdentifierArray_Ref_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags.Invoke(___genericsType, ___parameters);
			@depth = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[1];

            
        }


        public virtual void SetRenderTargetColorDepthSubtarget_Injected(ref UnityEngine.Rendering.RenderTargetIdentifier @color, ref UnityEngine.Rendering.RenderTargetIdentifier @depth, UnityEngine.Rendering.RenderBufferLoadAction @colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction @colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction @depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction @depthStoreAction, System.Int32 @mipLevel, UnityEngine.CubemapFace @cubemapFace, System.Int32 @depthSlice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color, @depth, @colorLoadAction, @colorStoreAction, @depthLoadAction, @depthStoreAction, @mipLevel, @cubemapFace, @depthSlice};
            var ___result = RMSetRenderTargetColorDepthSubtarget_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32.Invoke(___genericsType, ___parameters);
			@color = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[0];
			@depth = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[1];

            
        }


        public virtual void SetRenderTargetMultiSubtarget_Injected(UnityEngine.Rendering.RenderTargetIdentifier[] @colors, ref UnityEngine.Rendering.RenderTargetIdentifier @depth, UnityEngine.Rendering.RenderBufferLoadAction[] @colorLoadActions, UnityEngine.Rendering.RenderBufferStoreAction[] @colorStoreActions, UnityEngine.Rendering.RenderBufferLoadAction @depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction @depthStoreAction, System.Int32 @mipLevel, UnityEngine.CubemapFace @cubemapFace, System.Int32 @depthSlice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colors, @depth, @colorLoadActions, @colorStoreActions, @depthLoadAction, @depthStoreAction, @mipLevel, @cubemapFace, @depthSlice};
            var ___result = RMSetRenderTargetMultiSubtarget_Injected_RenderTargetIdentifierArray_Ref_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32.Invoke(___genericsType, ___parameters);
			@depth = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[1];

            
        }


        public virtual void Internal_ProcessVTFeedback_Injected(ref UnityEngine.Rendering.RenderTargetIdentifier @rt, System.IntPtr @resolver, System.Int32 @slice, System.Int32 @x, System.Int32 @width, System.Int32 @y, System.Int32 @height, System.Int32 @mip)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt, @resolver, @slice, @x, @width, @y, @height, @mip};
            var ___result = RMInternal_ProcessVTFeedback_Injected_Ref_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);
			@rt = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[0];

            
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
