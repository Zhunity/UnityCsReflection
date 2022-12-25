using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
	/// UnityEngine.Rendering.CommandBuffer
	/// </summary>
    public partial class RCommandBuffer : RMember //
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
		/// System.String name
		/// </summary>
		protected RProperty r_name;
		public virtual RProperty Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name", -1);
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// Int32 sizeInBytes
		/// </summary>
		protected RProperty r_sizeInBytes;
		public virtual RProperty RsizeInBytes
		{
			get
			{
				if(r_sizeInBytes == null)
				{
					r_sizeInBytes = new(this, "sizeInBytes", -1);
					r_sizeInBytes.SetBelong(this.instance);
				}
				return r_sizeInBytes;
			}
		}

		/// <summary>
		/// Void ConvertTexture(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_RConvertTexture_RenderTargetIdentifier_RenderTargetIdentifier;
		public virtual RMethod RConvertTexture_RenderTargetIdentifier_RenderTargetIdentifier
		{
			get
			{
				if(r_RConvertTexture_RenderTargetIdentifier_RenderTargetIdentifier == null)
				{
					r_RConvertTexture_RenderTargetIdentifier_RenderTargetIdentifier = new(this, "ConvertTexture", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier));
					r_RConvertTexture_RenderTargetIdentifier_RenderTargetIdentifier.SetBelong(this.instance);
				}
				return r_RConvertTexture_RenderTargetIdentifier_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void ConvertTexture(UnityEngine.Rendering.RenderTargetIdentifier, Int32, UnityEngine.Rendering.RenderTargetIdentifier, Int32)
		/// </summary>
		protected RMethod r_RConvertTexture_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32;
		public virtual RMethod RConvertTexture_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32
		{
			get
			{
				if(r_RConvertTexture_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32 == null)
				{
					r_RConvertTexture_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32 = new(this, "ConvertTexture", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32));
					r_RConvertTexture_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32.SetBelong(this.instance);
				}
				return r_RConvertTexture_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32;
			}
		}

		/// <summary>
		/// Void WaitAllAsyncReadbackRequests()
		/// </summary>
		protected RMethod r_RWaitAllAsyncReadbackRequests;
		public virtual RMethod RWaitAllAsyncReadbackRequests
		{
			get
			{
				if(r_RWaitAllAsyncReadbackRequests == null)
				{
					r_RWaitAllAsyncReadbackRequests = new(this, "WaitAllAsyncReadbackRequests", 0);
					r_RWaitAllAsyncReadbackRequests.SetBelong(this.instance);
				}
				return r_RWaitAllAsyncReadbackRequests;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadback(UnityEngine.ComputeBuffer, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_RRequestAsyncReadback_ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RRequestAsyncReadback_ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_RRequestAsyncReadback_ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_RRequestAsyncReadback_ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadback", 0, typeof(UnityEngine.ComputeBuffer), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_RRequestAsyncReadback_ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_RRequestAsyncReadback_ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadback(UnityEngine.GraphicsBuffer, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_RRequestAsyncReadback_GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RRequestAsyncReadback_GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_RRequestAsyncReadback_GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_RRequestAsyncReadback_GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadback", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_RRequestAsyncReadback_GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_RRequestAsyncReadback_GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadback(UnityEngine.ComputeBuffer, Int32, Int32, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_RRequestAsyncReadback_ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RRequestAsyncReadback_ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_RRequestAsyncReadback_ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_RRequestAsyncReadback_ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadback", 0, typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_RRequestAsyncReadback_ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_RRequestAsyncReadback_ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadback(UnityEngine.GraphicsBuffer, Int32, Int32, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_RRequestAsyncReadback_GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RRequestAsyncReadback_GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_RRequestAsyncReadback_GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_RRequestAsyncReadback_GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadback", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_RRequestAsyncReadback_GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_RRequestAsyncReadback_GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadback(UnityEngine.Texture, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_RRequestAsyncReadback_Texture_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RRequestAsyncReadback_Texture_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_RRequestAsyncReadback_Texture_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_RRequestAsyncReadback_Texture_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadback", 0, typeof(UnityEngine.Texture), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_RRequestAsyncReadback_Texture_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_RRequestAsyncReadback_Texture_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadback(UnityEngine.Texture, Int32, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_RRequestAsyncReadback_Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RRequestAsyncReadback_Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_RRequestAsyncReadback_Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_RRequestAsyncReadback_Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadback", 0, typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_RRequestAsyncReadback_Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_RRequestAsyncReadback_Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadback(UnityEngine.Texture, Int32, UnityEngine.TextureFormat, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_RRequestAsyncReadback_Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RRequestAsyncReadback_Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_RRequestAsyncReadback_Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_RRequestAsyncReadback_Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadback", 0, typeof(UnityEngine.Texture), typeof(System.Int32), typeof(UnityEngine.TextureFormat), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_RRequestAsyncReadback_Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_RRequestAsyncReadback_Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadback(UnityEngine.Texture, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_RRequestAsyncReadback_Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RRequestAsyncReadback_Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_RRequestAsyncReadback_Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_RRequestAsyncReadback_Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadback", 0, typeof(UnityEngine.Texture), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_RRequestAsyncReadback_Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_RRequestAsyncReadback_Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadback(UnityEngine.Texture, Int32, Int32, Int32, Int32, Int32, Int32, Int32, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_RRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_RRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_RRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadback", 0, typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_RRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_RRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadback(UnityEngine.Texture, Int32, Int32, Int32, Int32, Int32, Int32, Int32, UnityEngine.TextureFormat, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_RRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_RRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_RRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadback", 0, typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextureFormat), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_RRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_RRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadback(UnityEngine.Texture, Int32, Int32, Int32, Int32, Int32, Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_RRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_RRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_RRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadback", 0, typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_RRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_RRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeArray[T](Unity.Collections.NativeArray`1[T] ByRef, UnityEngine.ComputeBuffer, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeArray", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.ComputeBuffer), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeArray[T](Unity.Collections.NativeArray`1[T] ByRef, UnityEngine.ComputeBuffer, Int32, Int32, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeArray", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeArray[T](Unity.Collections.NativeArray`1[T] ByRef, UnityEngine.GraphicsBuffer, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeArray", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.GraphicsBuffer), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeArray[T](Unity.Collections.NativeArray`1[T] ByRef, UnityEngine.GraphicsBuffer, Int32, Int32, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeArray", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeArray[T](Unity.Collections.NativeArray`1[T] ByRef, UnityEngine.Texture, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeArray", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.Texture), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeArray[T](Unity.Collections.NativeArray`1[T] ByRef, UnityEngine.Texture, Int32, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeArray", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeArray[T](Unity.Collections.NativeArray`1[T] ByRef, UnityEngine.Texture, Int32, UnityEngine.TextureFormat, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeArray", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.Texture), typeof(System.Int32), typeof(UnityEngine.TextureFormat), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeArray[T](Unity.Collections.NativeArray`1[T] ByRef, UnityEngine.Texture, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeArray", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.Texture), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeArray[T](Unity.Collections.NativeArray`1[T] ByRef, UnityEngine.Texture, Int32, Int32, Int32, Int32, Int32, Int32, Int32, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeArray", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeArray[T](Unity.Collections.NativeArray`1[T] ByRef, UnityEngine.Texture, Int32, Int32, Int32, Int32, Int32, Int32, Int32, UnityEngine.TextureFormat, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeArray", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextureFormat), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeArray[T](Unity.Collections.NativeArray`1[T] ByRef, UnityEngine.Texture, Int32, Int32, Int32, Int32, Int32, Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeArray", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_RRequestAsyncReadbackIntoNativeArray_GT_Ref_NativeArray_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeSlice[T](Unity.Collections.NativeSlice`1[T] ByRef, UnityEngine.ComputeBuffer, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeSlice", 1, typeof(Unity.Collections.NativeSlice<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.ComputeBuffer), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeSlice[T](Unity.Collections.NativeSlice`1[T] ByRef, UnityEngine.ComputeBuffer, Int32, Int32, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeSlice", 1, typeof(Unity.Collections.NativeSlice<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeSlice[T](Unity.Collections.NativeSlice`1[T] ByRef, UnityEngine.GraphicsBuffer, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeSlice", 1, typeof(Unity.Collections.NativeSlice<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.GraphicsBuffer), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeSlice[T](Unity.Collections.NativeSlice`1[T] ByRef, UnityEngine.GraphicsBuffer, Int32, Int32, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeSlice", 1, typeof(Unity.Collections.NativeSlice<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeSlice[T](Unity.Collections.NativeSlice`1[T] ByRef, UnityEngine.Texture, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeSlice", 1, typeof(Unity.Collections.NativeSlice<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.Texture), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeSlice[T](Unity.Collections.NativeSlice`1[T] ByRef, UnityEngine.Texture, Int32, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeSlice", 1, typeof(Unity.Collections.NativeSlice<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeSlice[T](Unity.Collections.NativeSlice`1[T] ByRef, UnityEngine.Texture, Int32, UnityEngine.TextureFormat, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeSlice", 1, typeof(Unity.Collections.NativeSlice<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.Texture), typeof(System.Int32), typeof(UnityEngine.TextureFormat), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeSlice[T](Unity.Collections.NativeSlice`1[T] ByRef, UnityEngine.Texture, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeSlice", 1, typeof(Unity.Collections.NativeSlice<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.Texture), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeSlice[T](Unity.Collections.NativeSlice`1[T] ByRef, UnityEngine.Texture, Int32, Int32, Int32, Int32, Int32, Int32, Int32, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeSlice", 1, typeof(Unity.Collections.NativeSlice<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeSlice[T](Unity.Collections.NativeSlice`1[T] ByRef, UnityEngine.Texture, Int32, Int32, Int32, Int32, Int32, Int32, Int32, UnityEngine.TextureFormat, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeSlice", 1, typeof(Unity.Collections.NativeSlice<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextureFormat), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void RequestAsyncReadbackIntoNativeSlice[T](Unity.Collections.NativeSlice`1[T] ByRef, UnityEngine.Texture, Int32, Int32, Int32, Int32, Int32, Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest])
		/// </summary>
		protected RMethod r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_;
		public virtual RMethod RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_
		{
			get
			{
				if(r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_ == null)
				{
					r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_ = new(this, "RequestAsyncReadbackIntoNativeSlice", 1, typeof(Unity.Collections.NativeSlice<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(), typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)));
					r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_.SetBelong(this.instance);
				}
				return r_RRequestAsyncReadbackIntoNativeSlice_GT_Ref_NativeSlice_d_T_p__Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_;
			}
		}

		/// <summary>
		/// Void Internal_RequestAsyncReadback_1(UnityEngine.ComputeBuffer, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest], UnityEngine.Rendering.AsyncRequestNativeArrayData*)
		/// </summary>
		protected RMethod r_RInternal_RequestAsyncReadback_1_ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
		public virtual RMethod RInternal_RequestAsyncReadback_1_ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer
		{
			get
			{
				if(r_RInternal_RequestAsyncReadback_1_ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer == null)
				{
					r_RInternal_RequestAsyncReadback_1_ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer = new(this, "Internal_RequestAsyncReadback_1", 0, typeof(UnityEngine.ComputeBuffer), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)),  ReleactionUtils.GetType("UnityEngine.Rendering.AsyncRequestNativeArrayData").MakePointerType());
					r_RInternal_RequestAsyncReadback_1_ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer.SetBelong(this.instance);
				}
				return r_RInternal_RequestAsyncReadback_1_ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
			}
		}

		/// <summary>
		/// Void Internal_RequestAsyncReadback_2(UnityEngine.ComputeBuffer, Int32, Int32, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest], UnityEngine.Rendering.AsyncRequestNativeArrayData*)
		/// </summary>
		protected RMethod r_RInternal_RequestAsyncReadback_2_ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
		public virtual RMethod RInternal_RequestAsyncReadback_2_ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer
		{
			get
			{
				if(r_RInternal_RequestAsyncReadback_2_ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer == null)
				{
					r_RInternal_RequestAsyncReadback_2_ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer = new(this, "Internal_RequestAsyncReadback_2", 0, typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)),  ReleactionUtils.GetType("UnityEngine.Rendering.AsyncRequestNativeArrayData").MakePointerType());
					r_RInternal_RequestAsyncReadback_2_ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer.SetBelong(this.instance);
				}
				return r_RInternal_RequestAsyncReadback_2_ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
			}
		}

		/// <summary>
		/// Void Internal_RequestAsyncReadback_3(UnityEngine.Texture, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest], UnityEngine.Rendering.AsyncRequestNativeArrayData*)
		/// </summary>
		protected RMethod r_RInternal_RequestAsyncReadback_3_Texture_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
		public virtual RMethod RInternal_RequestAsyncReadback_3_Texture_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer
		{
			get
			{
				if(r_RInternal_RequestAsyncReadback_3_Texture_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer == null)
				{
					r_RInternal_RequestAsyncReadback_3_Texture_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer = new(this, "Internal_RequestAsyncReadback_3", 0, typeof(UnityEngine.Texture), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)),  ReleactionUtils.GetType("UnityEngine.Rendering.AsyncRequestNativeArrayData").MakePointerType());
					r_RInternal_RequestAsyncReadback_3_Texture_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer.SetBelong(this.instance);
				}
				return r_RInternal_RequestAsyncReadback_3_Texture_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
			}
		}

		/// <summary>
		/// Void Internal_RequestAsyncReadback_4(UnityEngine.Texture, Int32, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest], UnityEngine.Rendering.AsyncRequestNativeArrayData*)
		/// </summary>
		protected RMethod r_RInternal_RequestAsyncReadback_4_Texture_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
		public virtual RMethod RInternal_RequestAsyncReadback_4_Texture_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer
		{
			get
			{
				if(r_RInternal_RequestAsyncReadback_4_Texture_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer == null)
				{
					r_RInternal_RequestAsyncReadback_4_Texture_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer = new(this, "Internal_RequestAsyncReadback_4", 0, typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)),  ReleactionUtils.GetType("UnityEngine.Rendering.AsyncRequestNativeArrayData").MakePointerType());
					r_RInternal_RequestAsyncReadback_4_Texture_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer.SetBelong(this.instance);
				}
				return r_RInternal_RequestAsyncReadback_4_Texture_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
			}
		}

		/// <summary>
		/// Void Internal_RequestAsyncReadback_5(UnityEngine.Texture, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest], UnityEngine.Rendering.AsyncRequestNativeArrayData*)
		/// </summary>
		protected RMethod r_RInternal_RequestAsyncReadback_5_Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
		public virtual RMethod RInternal_RequestAsyncReadback_5_Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer
		{
			get
			{
				if(r_RInternal_RequestAsyncReadback_5_Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer == null)
				{
					r_RInternal_RequestAsyncReadback_5_Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer = new(this, "Internal_RequestAsyncReadback_5", 0, typeof(UnityEngine.Texture), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)),  ReleactionUtils.GetType("UnityEngine.Rendering.AsyncRequestNativeArrayData").MakePointerType());
					r_RInternal_RequestAsyncReadback_5_Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer.SetBelong(this.instance);
				}
				return r_RInternal_RequestAsyncReadback_5_Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
			}
		}

		/// <summary>
		/// Void Internal_RequestAsyncReadback_6(UnityEngine.Texture, Int32, Int32, Int32, Int32, Int32, Int32, Int32, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest], UnityEngine.Rendering.AsyncRequestNativeArrayData*)
		/// </summary>
		protected RMethod r_RInternal_RequestAsyncReadback_6_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
		public virtual RMethod RInternal_RequestAsyncReadback_6_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer
		{
			get
			{
				if(r_RInternal_RequestAsyncReadback_6_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer == null)
				{
					r_RInternal_RequestAsyncReadback_6_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer = new(this, "Internal_RequestAsyncReadback_6", 0, typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)),  ReleactionUtils.GetType("UnityEngine.Rendering.AsyncRequestNativeArrayData").MakePointerType());
					r_RInternal_RequestAsyncReadback_6_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer.SetBelong(this.instance);
				}
				return r_RInternal_RequestAsyncReadback_6_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
			}
		}

		/// <summary>
		/// Void Internal_RequestAsyncReadback_7(UnityEngine.Texture, Int32, Int32, Int32, Int32, Int32, Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest], UnityEngine.Rendering.AsyncRequestNativeArrayData*)
		/// </summary>
		protected RMethod r_RInternal_RequestAsyncReadback_7_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
		public virtual RMethod RInternal_RequestAsyncReadback_7_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer
		{
			get
			{
				if(r_RInternal_RequestAsyncReadback_7_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer == null)
				{
					r_RInternal_RequestAsyncReadback_7_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer = new(this, "Internal_RequestAsyncReadback_7", 0, typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)),  ReleactionUtils.GetType("UnityEngine.Rendering.AsyncRequestNativeArrayData").MakePointerType());
					r_RInternal_RequestAsyncReadback_7_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer.SetBelong(this.instance);
				}
				return r_RInternal_RequestAsyncReadback_7_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
			}
		}

		/// <summary>
		/// Void Internal_RequestAsyncReadback_8(UnityEngine.GraphicsBuffer, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest], UnityEngine.Rendering.AsyncRequestNativeArrayData*)
		/// </summary>
		protected RMethod r_RInternal_RequestAsyncReadback_8_GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
		public virtual RMethod RInternal_RequestAsyncReadback_8_GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer
		{
			get
			{
				if(r_RInternal_RequestAsyncReadback_8_GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer == null)
				{
					r_RInternal_RequestAsyncReadback_8_GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer = new(this, "Internal_RequestAsyncReadback_8", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)),  ReleactionUtils.GetType("UnityEngine.Rendering.AsyncRequestNativeArrayData").MakePointerType());
					r_RInternal_RequestAsyncReadback_8_GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer.SetBelong(this.instance);
				}
				return r_RInternal_RequestAsyncReadback_8_GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
			}
		}

		/// <summary>
		/// Void Internal_RequestAsyncReadback_9(UnityEngine.GraphicsBuffer, Int32, Int32, System.Action`1[UnityEngine.Rendering.AsyncGPUReadbackRequest], UnityEngine.Rendering.AsyncRequestNativeArrayData*)
		/// </summary>
		protected RMethod r_RInternal_RequestAsyncReadback_9_GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
		public virtual RMethod RInternal_RequestAsyncReadback_9_GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer
		{
			get
			{
				if(r_RInternal_RequestAsyncReadback_9_GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer == null)
				{
					r_RInternal_RequestAsyncReadback_9_GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer = new(this, "Internal_RequestAsyncReadback_9", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest)),  ReleactionUtils.GetType("UnityEngine.Rendering.AsyncRequestNativeArrayData").MakePointerType());
					r_RInternal_RequestAsyncReadback_9_GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer.SetBelong(this.instance);
				}
				return r_RInternal_RequestAsyncReadback_9_GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p__AsyncRequestNativeArrayDataPointer;
			}
		}

		/// <summary>
		/// Void SetInvertCulling(Boolean)
		/// </summary>
		protected RMethod r_RSetInvertCulling_Boolean;
		public virtual RMethod RSetInvertCulling_Boolean
		{
			get
			{
				if(r_RSetInvertCulling_Boolean == null)
				{
					r_RSetInvertCulling_Boolean = new(this, "SetInvertCulling", 0, typeof(System.Boolean));
					r_RSetInvertCulling_Boolean.SetBelong(this.instance);
				}
				return r_RSetInvertCulling_Boolean;
			}
		}

		/// <summary>
		/// Void ConvertTexture_Internal(UnityEngine.Rendering.RenderTargetIdentifier, Int32, UnityEngine.Rendering.RenderTargetIdentifier, Int32)
		/// </summary>
		protected RMethod r_RConvertTexture_Internal_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32;
		public virtual RMethod RConvertTexture_Internal_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32
		{
			get
			{
				if(r_RConvertTexture_Internal_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32 == null)
				{
					r_RConvertTexture_Internal_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32 = new(this, "ConvertTexture_Internal", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32));
					r_RConvertTexture_Internal_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32.SetBelong(this.instance);
				}
				return r_RConvertTexture_Internal_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32;
			}
		}

		/// <summary>
		/// Void Internal_SetSinglePassStereo(UnityEngine.Rendering.SinglePassStereoMode)
		/// </summary>
		protected RMethod r_RInternal_SetSinglePassStereo_SinglePassStereoMode;
		public virtual RMethod RInternal_SetSinglePassStereo_SinglePassStereoMode
		{
			get
			{
				if(r_RInternal_SetSinglePassStereo_SinglePassStereoMode == null)
				{
					r_RInternal_SetSinglePassStereo_SinglePassStereoMode = new(this, "Internal_SetSinglePassStereo", 0, typeof(UnityEngine.Rendering.SinglePassStereoMode));
					r_RInternal_SetSinglePassStereo_SinglePassStereoMode.SetBelong(this.instance);
				}
				return r_RInternal_SetSinglePassStereo_SinglePassStereoMode;
			}
		}

		/// <summary>
		/// IntPtr InitBuffer()
		/// </summary>
		protected static RMethod r_RInitBuffer;
		public static RMethod RInitBuffer
		{
			get
			{
				if(r_RInitBuffer == null)
				{
					r_RInitBuffer = new(typeof(UnityEngine.Rendering.CommandBuffer), "InitBuffer", 0);
					r_RInitBuffer.SetBelong(null);
				}
				return r_RInitBuffer;
			}
		}

		/// <summary>
		/// IntPtr CreateGPUFence_Internal(UnityEngine.Rendering.GraphicsFenceType, UnityEngine.Rendering.SynchronisationStageFlags)
		/// </summary>
		protected RMethod r_RCreateGPUFence_Internal_GraphicsFenceType_SynchronisationStageFlags;
		public virtual RMethod RCreateGPUFence_Internal_GraphicsFenceType_SynchronisationStageFlags
		{
			get
			{
				if(r_RCreateGPUFence_Internal_GraphicsFenceType_SynchronisationStageFlags == null)
				{
					r_RCreateGPUFence_Internal_GraphicsFenceType_SynchronisationStageFlags = new(this, "CreateGPUFence_Internal", 0, typeof(UnityEngine.Rendering.GraphicsFenceType), typeof(UnityEngine.Rendering.SynchronisationStageFlags));
					r_RCreateGPUFence_Internal_GraphicsFenceType_SynchronisationStageFlags.SetBelong(this.instance);
				}
				return r_RCreateGPUFence_Internal_GraphicsFenceType_SynchronisationStageFlags;
			}
		}

		/// <summary>
		/// Void WaitOnGPUFence_Internal(IntPtr, UnityEngine.Rendering.SynchronisationStageFlags)
		/// </summary>
		protected RMethod r_RWaitOnGPUFence_Internal_IntPtr_SynchronisationStageFlags;
		public virtual RMethod RWaitOnGPUFence_Internal_IntPtr_SynchronisationStageFlags
		{
			get
			{
				if(r_RWaitOnGPUFence_Internal_IntPtr_SynchronisationStageFlags == null)
				{
					r_RWaitOnGPUFence_Internal_IntPtr_SynchronisationStageFlags = new(this, "WaitOnGPUFence_Internal", 0, typeof(System.IntPtr), typeof(UnityEngine.Rendering.SynchronisationStageFlags));
					r_RWaitOnGPUFence_Internal_IntPtr_SynchronisationStageFlags.SetBelong(this.instance);
				}
				return r_RWaitOnGPUFence_Internal_IntPtr_SynchronisationStageFlags;
			}
		}

		/// <summary>
		/// Void ReleaseBuffer()
		/// </summary>
		protected RMethod r_RReleaseBuffer;
		public virtual RMethod RReleaseBuffer
		{
			get
			{
				if(r_RReleaseBuffer == null)
				{
					r_RReleaseBuffer = new(this, "ReleaseBuffer", 0);
					r_RReleaseBuffer.SetBelong(this.instance);
				}
				return r_RReleaseBuffer;
			}
		}

		/// <summary>
		/// Void SetComputeFloatParam(UnityEngine.ComputeShader, Int32, Single)
		/// </summary>
		protected RMethod r_RSetComputeFloatParam_ComputeShader_Int32_Single;
		public virtual RMethod RSetComputeFloatParam_ComputeShader_Int32_Single
		{
			get
			{
				if(r_RSetComputeFloatParam_ComputeShader_Int32_Single == null)
				{
					r_RSetComputeFloatParam_ComputeShader_Int32_Single = new(this, "SetComputeFloatParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Single));
					r_RSetComputeFloatParam_ComputeShader_Int32_Single.SetBelong(this.instance);
				}
				return r_RSetComputeFloatParam_ComputeShader_Int32_Single;
			}
		}

		/// <summary>
		/// Void SetComputeIntParam(UnityEngine.ComputeShader, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetComputeIntParam_ComputeShader_Int32_Int32;
		public virtual RMethod RSetComputeIntParam_ComputeShader_Int32_Int32
		{
			get
			{
				if(r_RSetComputeIntParam_ComputeShader_Int32_Int32 == null)
				{
					r_RSetComputeIntParam_ComputeShader_Int32_Int32 = new(this, "SetComputeIntParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Int32));
					r_RSetComputeIntParam_ComputeShader_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetComputeIntParam_ComputeShader_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetComputeVectorParam(UnityEngine.ComputeShader, Int32, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_RSetComputeVectorParam_ComputeShader_Int32_Vector4;
		public virtual RMethod RSetComputeVectorParam_ComputeShader_Int32_Vector4
		{
			get
			{
				if(r_RSetComputeVectorParam_ComputeShader_Int32_Vector4 == null)
				{
					r_RSetComputeVectorParam_ComputeShader_Int32_Vector4 = new(this, "SetComputeVectorParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(UnityEngine.Vector4));
					r_RSetComputeVectorParam_ComputeShader_Int32_Vector4.SetBelong(this.instance);
				}
				return r_RSetComputeVectorParam_ComputeShader_Int32_Vector4;
			}
		}

		/// <summary>
		/// Void SetComputeVectorArrayParam(UnityEngine.ComputeShader, Int32, UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_RSetComputeVectorArrayParam_ComputeShader_Int32_Vector4Array;
		public virtual RMethod RSetComputeVectorArrayParam_ComputeShader_Int32_Vector4Array
		{
			get
			{
				if(r_RSetComputeVectorArrayParam_ComputeShader_Int32_Vector4Array == null)
				{
					r_RSetComputeVectorArrayParam_ComputeShader_Int32_Vector4Array = new(this, "SetComputeVectorArrayParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType());
					r_RSetComputeVectorArrayParam_ComputeShader_Int32_Vector4Array.SetBelong(this.instance);
				}
				return r_RSetComputeVectorArrayParam_ComputeShader_Int32_Vector4Array;
			}
		}

		/// <summary>
		/// Void SetComputeMatrixParam(UnityEngine.ComputeShader, Int32, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_RSetComputeMatrixParam_ComputeShader_Int32_Matrix4x4;
		public virtual RMethod RSetComputeMatrixParam_ComputeShader_Int32_Matrix4x4
		{
			get
			{
				if(r_RSetComputeMatrixParam_ComputeShader_Int32_Matrix4x4 == null)
				{
					r_RSetComputeMatrixParam_ComputeShader_Int32_Matrix4x4 = new(this, "SetComputeMatrixParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(UnityEngine.Matrix4x4));
					r_RSetComputeMatrixParam_ComputeShader_Int32_Matrix4x4.SetBelong(this.instance);
				}
				return r_RSetComputeMatrixParam_ComputeShader_Int32_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetComputeMatrixArrayParam(UnityEngine.ComputeShader, Int32, UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_RSetComputeMatrixArrayParam_ComputeShader_Int32_Matrix4x4Array;
		public virtual RMethod RSetComputeMatrixArrayParam_ComputeShader_Int32_Matrix4x4Array
		{
			get
			{
				if(r_RSetComputeMatrixArrayParam_ComputeShader_Int32_Matrix4x4Array == null)
				{
					r_RSetComputeMatrixArrayParam_ComputeShader_Int32_Matrix4x4Array = new(this, "SetComputeMatrixArrayParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType());
					r_RSetComputeMatrixArrayParam_ComputeShader_Int32_Matrix4x4Array.SetBelong(this.instance);
				}
				return r_RSetComputeMatrixArrayParam_ComputeShader_Int32_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Void Internal_SetComputeFloats(UnityEngine.ComputeShader, Int32, Single[])
		/// </summary>
		protected RMethod r_RInternal_SetComputeFloats_ComputeShader_Int32_SingleArray;
		public virtual RMethod RInternal_SetComputeFloats_ComputeShader_Int32_SingleArray
		{
			get
			{
				if(r_RInternal_SetComputeFloats_ComputeShader_Int32_SingleArray == null)
				{
					r_RInternal_SetComputeFloats_ComputeShader_Int32_SingleArray = new(this, "Internal_SetComputeFloats", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Single).MakeArrayType());
					r_RInternal_SetComputeFloats_ComputeShader_Int32_SingleArray.SetBelong(this.instance);
				}
				return r_RInternal_SetComputeFloats_ComputeShader_Int32_SingleArray;
			}
		}

		/// <summary>
		/// Void Internal_SetComputeInts(UnityEngine.ComputeShader, Int32, Int32[])
		/// </summary>
		protected RMethod r_RInternal_SetComputeInts_ComputeShader_Int32_Int32Array;
		public virtual RMethod RInternal_SetComputeInts_ComputeShader_Int32_Int32Array
		{
			get
			{
				if(r_RInternal_SetComputeInts_ComputeShader_Int32_Int32Array == null)
				{
					r_RInternal_SetComputeInts_ComputeShader_Int32_Int32Array = new(this, "Internal_SetComputeInts", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Int32).MakeArrayType());
					r_RInternal_SetComputeInts_ComputeShader_Int32_Int32Array.SetBelong(this.instance);
				}
				return r_RInternal_SetComputeInts_ComputeShader_Int32_Int32Array;
			}
		}

		/// <summary>
		/// Void Internal_SetComputeTextureParam(UnityEngine.ComputeShader, Int32, Int32, UnityEngine.Rendering.RenderTargetIdentifier ByRef, Int32, UnityEngine.Rendering.RenderTextureSubElement)
		/// </summary>
		protected RMethod r_RInternal_SetComputeTextureParam_ComputeShader_Int32_Int32_Ref_RenderTargetIdentifier_Int32_RenderTextureSubElement;
		public virtual RMethod RInternal_SetComputeTextureParam_ComputeShader_Int32_Int32_Ref_RenderTargetIdentifier_Int32_RenderTextureSubElement
		{
			get
			{
				if(r_RInternal_SetComputeTextureParam_ComputeShader_Int32_Int32_Ref_RenderTargetIdentifier_Int32_RenderTextureSubElement == null)
				{
					r_RInternal_SetComputeTextureParam_ComputeShader_Int32_Int32_Ref_RenderTargetIdentifier_Int32_RenderTextureSubElement = new(this, "Internal_SetComputeTextureParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTextureSubElement));
					r_RInternal_SetComputeTextureParam_ComputeShader_Int32_Int32_Ref_RenderTargetIdentifier_Int32_RenderTextureSubElement.SetBelong(this.instance);
				}
				return r_RInternal_SetComputeTextureParam_ComputeShader_Int32_Int32_Ref_RenderTargetIdentifier_Int32_RenderTextureSubElement;
			}
		}

		/// <summary>
		/// Void Internal_SetComputeBufferParam(UnityEngine.ComputeShader, Int32, Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_RInternal_SetComputeBufferParam_ComputeShader_Int32_Int32_ComputeBuffer;
		public virtual RMethod RInternal_SetComputeBufferParam_ComputeShader_Int32_Int32_ComputeBuffer
		{
			get
			{
				if(r_RInternal_SetComputeBufferParam_ComputeShader_Int32_Int32_ComputeBuffer == null)
				{
					r_RInternal_SetComputeBufferParam_ComputeShader_Int32_Int32_ComputeBuffer = new(this, "Internal_SetComputeBufferParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
					r_RInternal_SetComputeBufferParam_ComputeShader_Int32_Int32_ComputeBuffer.SetBelong(this.instance);
				}
				return r_RInternal_SetComputeBufferParam_ComputeShader_Int32_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void Internal_SetComputeGraphicsBufferHandleParam(UnityEngine.ComputeShader, Int32, Int32, UnityEngine.GraphicsBufferHandle)
		/// </summary>
		protected RMethod r_RInternal_SetComputeGraphicsBufferHandleParam_ComputeShader_Int32_Int32_GraphicsBufferHandle;
		public virtual RMethod RInternal_SetComputeGraphicsBufferHandleParam_ComputeShader_Int32_Int32_GraphicsBufferHandle
		{
			get
			{
				if(r_RInternal_SetComputeGraphicsBufferHandleParam_ComputeShader_Int32_Int32_GraphicsBufferHandle == null)
				{
					r_RInternal_SetComputeGraphicsBufferHandleParam_ComputeShader_Int32_Int32_GraphicsBufferHandle = new(this, "Internal_SetComputeGraphicsBufferHandleParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.GraphicsBufferHandle));
					r_RInternal_SetComputeGraphicsBufferHandleParam_ComputeShader_Int32_Int32_GraphicsBufferHandle.SetBelong(this.instance);
				}
				return r_RInternal_SetComputeGraphicsBufferHandleParam_ComputeShader_Int32_Int32_GraphicsBufferHandle;
			}
		}

		/// <summary>
		/// Void Internal_SetComputeGraphicsBufferParam(UnityEngine.ComputeShader, Int32, Int32, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_RInternal_SetComputeGraphicsBufferParam_ComputeShader_Int32_Int32_GraphicsBuffer;
		public virtual RMethod RInternal_SetComputeGraphicsBufferParam_ComputeShader_Int32_Int32_GraphicsBuffer
		{
			get
			{
				if(r_RInternal_SetComputeGraphicsBufferParam_ComputeShader_Int32_Int32_GraphicsBuffer == null)
				{
					r_RInternal_SetComputeGraphicsBufferParam_ComputeShader_Int32_Int32_GraphicsBuffer = new(this, "Internal_SetComputeGraphicsBufferParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer));
					r_RInternal_SetComputeGraphicsBufferParam_ComputeShader_Int32_Int32_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_RInternal_SetComputeGraphicsBufferParam_ComputeShader_Int32_Int32_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void Internal_SetComputeConstantComputeBufferParam(UnityEngine.ComputeShader, Int32, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_RInternal_SetComputeConstantComputeBufferParam_ComputeShader_Int32_ComputeBuffer_Int32_Int32;
		public virtual RMethod RInternal_SetComputeConstantComputeBufferParam_ComputeShader_Int32_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_RInternal_SetComputeConstantComputeBufferParam_ComputeShader_Int32_ComputeBuffer_Int32_Int32 == null)
				{
					r_RInternal_SetComputeConstantComputeBufferParam_ComputeShader_Int32_ComputeBuffer_Int32_Int32 = new(this, "Internal_SetComputeConstantComputeBufferParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
					r_RInternal_SetComputeConstantComputeBufferParam_ComputeShader_Int32_ComputeBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_RInternal_SetComputeConstantComputeBufferParam_ComputeShader_Int32_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Internal_SetComputeConstantGraphicsBufferParam(UnityEngine.ComputeShader, Int32, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_RInternal_SetComputeConstantGraphicsBufferParam_ComputeShader_Int32_GraphicsBuffer_Int32_Int32;
		public virtual RMethod RInternal_SetComputeConstantGraphicsBufferParam_ComputeShader_Int32_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_RInternal_SetComputeConstantGraphicsBufferParam_ComputeShader_Int32_GraphicsBuffer_Int32_Int32 == null)
				{
					r_RInternal_SetComputeConstantGraphicsBufferParam_ComputeShader_Int32_GraphicsBuffer_Int32_Int32 = new(this, "Internal_SetComputeConstantGraphicsBufferParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
					r_RInternal_SetComputeConstantGraphicsBufferParam_ComputeShader_Int32_GraphicsBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_RInternal_SetComputeConstantGraphicsBufferParam_ComputeShader_Int32_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Internal_SetComputeParamsFromMaterial(UnityEngine.ComputeShader, Int32, UnityEngine.Material)
		/// </summary>
		protected RMethod r_RInternal_SetComputeParamsFromMaterial_ComputeShader_Int32_Material;
		public virtual RMethod RInternal_SetComputeParamsFromMaterial_ComputeShader_Int32_Material
		{
			get
			{
				if(r_RInternal_SetComputeParamsFromMaterial_ComputeShader_Int32_Material == null)
				{
					r_RInternal_SetComputeParamsFromMaterial_ComputeShader_Int32_Material = new(this, "Internal_SetComputeParamsFromMaterial", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(UnityEngine.Material));
					r_RInternal_SetComputeParamsFromMaterial_ComputeShader_Int32_Material.SetBelong(this.instance);
				}
				return r_RInternal_SetComputeParamsFromMaterial_ComputeShader_Int32_Material;
			}
		}

		/// <summary>
		/// Void Internal_DispatchCompute(UnityEngine.ComputeShader, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RInternal_DispatchCompute_ComputeShader_Int32_Int32_Int32_Int32;
		public virtual RMethod RInternal_DispatchCompute_ComputeShader_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_RInternal_DispatchCompute_ComputeShader_Int32_Int32_Int32_Int32 == null)
				{
					r_RInternal_DispatchCompute_ComputeShader_Int32_Int32_Int32_Int32 = new(this, "Internal_DispatchCompute", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RInternal_DispatchCompute_ComputeShader_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RInternal_DispatchCompute_ComputeShader_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Internal_DispatchComputeIndirect(UnityEngine.ComputeShader, Int32, UnityEngine.ComputeBuffer, UInt32)
		/// </summary>
		protected RMethod r_RInternal_DispatchComputeIndirect_ComputeShader_Int32_ComputeBuffer_UInt32;
		public virtual RMethod RInternal_DispatchComputeIndirect_ComputeShader_Int32_ComputeBuffer_UInt32
		{
			get
			{
				if(r_RInternal_DispatchComputeIndirect_ComputeShader_Int32_ComputeBuffer_UInt32 == null)
				{
					r_RInternal_DispatchComputeIndirect_ComputeShader_Int32_ComputeBuffer_UInt32 = new(this, "Internal_DispatchComputeIndirect", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.UInt32));
					r_RInternal_DispatchComputeIndirect_ComputeShader_Int32_ComputeBuffer_UInt32.SetBelong(this.instance);
				}
				return r_RInternal_DispatchComputeIndirect_ComputeShader_Int32_ComputeBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void Internal_DispatchComputeIndirectGraphicsBuffer(UnityEngine.ComputeShader, Int32, UnityEngine.GraphicsBuffer, UInt32)
		/// </summary>
		protected RMethod r_RInternal_DispatchComputeIndirectGraphicsBuffer_ComputeShader_Int32_GraphicsBuffer_UInt32;
		public virtual RMethod RInternal_DispatchComputeIndirectGraphicsBuffer_ComputeShader_Int32_GraphicsBuffer_UInt32
		{
			get
			{
				if(r_RInternal_DispatchComputeIndirectGraphicsBuffer_ComputeShader_Int32_GraphicsBuffer_UInt32 == null)
				{
					r_RInternal_DispatchComputeIndirectGraphicsBuffer_ComputeShader_Int32_GraphicsBuffer_UInt32 = new(this, "Internal_DispatchComputeIndirectGraphicsBuffer", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32));
					r_RInternal_DispatchComputeIndirectGraphicsBuffer_ComputeShader_Int32_GraphicsBuffer_UInt32.SetBelong(this.instance);
				}
				return r_RInternal_DispatchComputeIndirectGraphicsBuffer_ComputeShader_Int32_GraphicsBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void Internal_SetRayTracingBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_RInternal_SetRayTracingBufferParam_RayTracingShader_Int32_ComputeBuffer;
		public virtual RMethod RInternal_SetRayTracingBufferParam_RayTracingShader_Int32_ComputeBuffer
		{
			get
			{
				if(r_RInternal_SetRayTracingBufferParam_RayTracingShader_Int32_ComputeBuffer == null)
				{
					r_RInternal_SetRayTracingBufferParam_RayTracingShader_Int32_ComputeBuffer = new(this, "Internal_SetRayTracingBufferParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
					r_RInternal_SetRayTracingBufferParam_RayTracingShader_Int32_ComputeBuffer.SetBelong(this.instance);
				}
				return r_RInternal_SetRayTracingBufferParam_RayTracingShader_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void Internal_SetRayTracingConstantComputeBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_RInternal_SetRayTracingConstantComputeBufferParam_RayTracingShader_Int32_ComputeBuffer_Int32_Int32;
		public virtual RMethod RInternal_SetRayTracingConstantComputeBufferParam_RayTracingShader_Int32_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_RInternal_SetRayTracingConstantComputeBufferParam_RayTracingShader_Int32_ComputeBuffer_Int32_Int32 == null)
				{
					r_RInternal_SetRayTracingConstantComputeBufferParam_RayTracingShader_Int32_ComputeBuffer_Int32_Int32 = new(this, "Internal_SetRayTracingConstantComputeBufferParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
					r_RInternal_SetRayTracingConstantComputeBufferParam_RayTracingShader_Int32_ComputeBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_RInternal_SetRayTracingConstantComputeBufferParam_RayTracingShader_Int32_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Internal_SetRayTracingConstantGraphicsBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_RInternal_SetRayTracingConstantGraphicsBufferParam_RayTracingShader_Int32_GraphicsBuffer_Int32_Int32;
		public virtual RMethod RInternal_SetRayTracingConstantGraphicsBufferParam_RayTracingShader_Int32_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_RInternal_SetRayTracingConstantGraphicsBufferParam_RayTracingShader_Int32_GraphicsBuffer_Int32_Int32 == null)
				{
					r_RInternal_SetRayTracingConstantGraphicsBufferParam_RayTracingShader_Int32_GraphicsBuffer_Int32_Int32 = new(this, "Internal_SetRayTracingConstantGraphicsBufferParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
					r_RInternal_SetRayTracingConstantGraphicsBufferParam_RayTracingShader_Int32_GraphicsBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_RInternal_SetRayTracingConstantGraphicsBufferParam_RayTracingShader_Int32_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Internal_SetRayTracingTextureParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.Rendering.RenderTargetIdentifier ByRef)
		/// </summary>
		protected RMethod r_RInternal_SetRayTracingTextureParam_RayTracingShader_Int32_Ref_RenderTargetIdentifier;
		public virtual RMethod RInternal_SetRayTracingTextureParam_RayTracingShader_Int32_Ref_RenderTargetIdentifier
		{
			get
			{
				if(r_RInternal_SetRayTracingTextureParam_RayTracingShader_Int32_Ref_RenderTargetIdentifier == null)
				{
					r_RInternal_SetRayTracingTextureParam_RayTracingShader_Int32_Ref_RenderTargetIdentifier = new(this, "Internal_SetRayTracingTextureParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType());
					r_RInternal_SetRayTracingTextureParam_RayTracingShader_Int32_Ref_RenderTargetIdentifier.SetBelong(this.instance);
				}
				return r_RInternal_SetRayTracingTextureParam_RayTracingShader_Int32_Ref_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void Internal_SetRayTracingFloatParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, Single)
		/// </summary>
		protected RMethod r_RInternal_SetRayTracingFloatParam_RayTracingShader_Int32_Single;
		public virtual RMethod RInternal_SetRayTracingFloatParam_RayTracingShader_Int32_Single
		{
			get
			{
				if(r_RInternal_SetRayTracingFloatParam_RayTracingShader_Int32_Single == null)
				{
					r_RInternal_SetRayTracingFloatParam_RayTracingShader_Int32_Single = new(this, "Internal_SetRayTracingFloatParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(System.Single));
					r_RInternal_SetRayTracingFloatParam_RayTracingShader_Int32_Single.SetBelong(this.instance);
				}
				return r_RInternal_SetRayTracingFloatParam_RayTracingShader_Int32_Single;
			}
		}

		/// <summary>
		/// Void Internal_SetRayTracingIntParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, Int32)
		/// </summary>
		protected RMethod r_RInternal_SetRayTracingIntParam_RayTracingShader_Int32_Int32;
		public virtual RMethod RInternal_SetRayTracingIntParam_RayTracingShader_Int32_Int32
		{
			get
			{
				if(r_RInternal_SetRayTracingIntParam_RayTracingShader_Int32_Int32 == null)
				{
					r_RInternal_SetRayTracingIntParam_RayTracingShader_Int32_Int32 = new(this, "Internal_SetRayTracingIntParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(System.Int32));
					r_RInternal_SetRayTracingIntParam_RayTracingShader_Int32_Int32.SetBelong(this.instance);
				}
				return r_RInternal_SetRayTracingIntParam_RayTracingShader_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Internal_SetRayTracingVectorParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_RInternal_SetRayTracingVectorParam_RayTracingShader_Int32_Vector4;
		public virtual RMethod RInternal_SetRayTracingVectorParam_RayTracingShader_Int32_Vector4
		{
			get
			{
				if(r_RInternal_SetRayTracingVectorParam_RayTracingShader_Int32_Vector4 == null)
				{
					r_RInternal_SetRayTracingVectorParam_RayTracingShader_Int32_Vector4 = new(this, "Internal_SetRayTracingVectorParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.Vector4));
					r_RInternal_SetRayTracingVectorParam_RayTracingShader_Int32_Vector4.SetBelong(this.instance);
				}
				return r_RInternal_SetRayTracingVectorParam_RayTracingShader_Int32_Vector4;
			}
		}

		/// <summary>
		/// Void Internal_SetRayTracingVectorArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_RInternal_SetRayTracingVectorArrayParam_RayTracingShader_Int32_Vector4Array;
		public virtual RMethod RInternal_SetRayTracingVectorArrayParam_RayTracingShader_Int32_Vector4Array
		{
			get
			{
				if(r_RInternal_SetRayTracingVectorArrayParam_RayTracingShader_Int32_Vector4Array == null)
				{
					r_RInternal_SetRayTracingVectorArrayParam_RayTracingShader_Int32_Vector4Array = new(this, "Internal_SetRayTracingVectorArrayParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType());
					r_RInternal_SetRayTracingVectorArrayParam_RayTracingShader_Int32_Vector4Array.SetBelong(this.instance);
				}
				return r_RInternal_SetRayTracingVectorArrayParam_RayTracingShader_Int32_Vector4Array;
			}
		}

		/// <summary>
		/// Void Internal_SetRayTracingMatrixParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_RInternal_SetRayTracingMatrixParam_RayTracingShader_Int32_Matrix4x4;
		public virtual RMethod RInternal_SetRayTracingMatrixParam_RayTracingShader_Int32_Matrix4x4
		{
			get
			{
				if(r_RInternal_SetRayTracingMatrixParam_RayTracingShader_Int32_Matrix4x4 == null)
				{
					r_RInternal_SetRayTracingMatrixParam_RayTracingShader_Int32_Matrix4x4 = new(this, "Internal_SetRayTracingMatrixParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.Matrix4x4));
					r_RInternal_SetRayTracingMatrixParam_RayTracingShader_Int32_Matrix4x4.SetBelong(this.instance);
				}
				return r_RInternal_SetRayTracingMatrixParam_RayTracingShader_Int32_Matrix4x4;
			}
		}

		/// <summary>
		/// Void Internal_SetRayTracingMatrixArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_RInternal_SetRayTracingMatrixArrayParam_RayTracingShader_Int32_Matrix4x4Array;
		public virtual RMethod RInternal_SetRayTracingMatrixArrayParam_RayTracingShader_Int32_Matrix4x4Array
		{
			get
			{
				if(r_RInternal_SetRayTracingMatrixArrayParam_RayTracingShader_Int32_Matrix4x4Array == null)
				{
					r_RInternal_SetRayTracingMatrixArrayParam_RayTracingShader_Int32_Matrix4x4Array = new(this, "Internal_SetRayTracingMatrixArrayParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType());
					r_RInternal_SetRayTracingMatrixArrayParam_RayTracingShader_Int32_Matrix4x4Array.SetBelong(this.instance);
				}
				return r_RInternal_SetRayTracingMatrixArrayParam_RayTracingShader_Int32_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Void Internal_SetRayTracingFloats(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, Single[])
		/// </summary>
		protected RMethod r_RInternal_SetRayTracingFloats_RayTracingShader_Int32_SingleArray;
		public virtual RMethod RInternal_SetRayTracingFloats_RayTracingShader_Int32_SingleArray
		{
			get
			{
				if(r_RInternal_SetRayTracingFloats_RayTracingShader_Int32_SingleArray == null)
				{
					r_RInternal_SetRayTracingFloats_RayTracingShader_Int32_SingleArray = new(this, "Internal_SetRayTracingFloats", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(System.Single).MakeArrayType());
					r_RInternal_SetRayTracingFloats_RayTracingShader_Int32_SingleArray.SetBelong(this.instance);
				}
				return r_RInternal_SetRayTracingFloats_RayTracingShader_Int32_SingleArray;
			}
		}

		/// <summary>
		/// Void Internal_SetRayTracingInts(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, Int32[])
		/// </summary>
		protected RMethod r_RInternal_SetRayTracingInts_RayTracingShader_Int32_Int32Array;
		public virtual RMethod RInternal_SetRayTracingInts_RayTracingShader_Int32_Int32Array
		{
			get
			{
				if(r_RInternal_SetRayTracingInts_RayTracingShader_Int32_Int32Array == null)
				{
					r_RInternal_SetRayTracingInts_RayTracingShader_Int32_Int32Array = new(this, "Internal_SetRayTracingInts", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(System.Int32).MakeArrayType());
					r_RInternal_SetRayTracingInts_RayTracingShader_Int32_Int32Array.SetBelong(this.instance);
				}
				return r_RInternal_SetRayTracingInts_RayTracingShader_Int32_Int32Array;
			}
		}

		/// <summary>
		/// Void Internal_BuildRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure, UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RInternal_BuildRayTracingAccelerationStructure_RayTracingAccelerationStructure_Vector3;
		public virtual RMethod RInternal_BuildRayTracingAccelerationStructure_RayTracingAccelerationStructure_Vector3
		{
			get
			{
				if(r_RInternal_BuildRayTracingAccelerationStructure_RayTracingAccelerationStructure_Vector3 == null)
				{
					r_RInternal_BuildRayTracingAccelerationStructure_RayTracingAccelerationStructure_Vector3 = new(this, "Internal_BuildRayTracingAccelerationStructure", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure), typeof(UnityEngine.Vector3));
					r_RInternal_BuildRayTracingAccelerationStructure_RayTracingAccelerationStructure_Vector3.SetBelong(this.instance);
				}
				return r_RInternal_BuildRayTracingAccelerationStructure_RayTracingAccelerationStructure_Vector3;
			}
		}

		/// <summary>
		/// Void Internal_SetRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure)
		/// </summary>
		protected RMethod r_RInternal_SetRayTracingAccelerationStructure_RayTracingShader_Int32_RayTracingAccelerationStructure;
		public virtual RMethod RInternal_SetRayTracingAccelerationStructure_RayTracingShader_Int32_RayTracingAccelerationStructure
		{
			get
			{
				if(r_RInternal_SetRayTracingAccelerationStructure_RayTracingShader_Int32_RayTracingAccelerationStructure == null)
				{
					r_RInternal_SetRayTracingAccelerationStructure_RayTracingShader_Int32_RayTracingAccelerationStructure = new(this, "Internal_SetRayTracingAccelerationStructure", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure));
					r_RInternal_SetRayTracingAccelerationStructure_RayTracingShader_Int32_RayTracingAccelerationStructure.SetBelong(this.instance);
				}
				return r_RInternal_SetRayTracingAccelerationStructure_RayTracingShader_Int32_RayTracingAccelerationStructure;
			}
		}

		/// <summary>
		/// Void SetRayTracingShaderPass(UnityEngine.Experimental.Rendering.RayTracingShader, System.String)
		/// </summary>
		protected RMethod r_RSetRayTracingShaderPass_RayTracingShader_String;
		public virtual RMethod RSetRayTracingShaderPass_RayTracingShader_String
		{
			get
			{
				if(r_RSetRayTracingShaderPass_RayTracingShader_String == null)
				{
					r_RSetRayTracingShaderPass_RayTracingShader_String = new(this, "SetRayTracingShaderPass", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.String));
					r_RSetRayTracingShaderPass_RayTracingShader_String.SetBelong(this.instance);
				}
				return r_RSetRayTracingShaderPass_RayTracingShader_String;
			}
		}

		/// <summary>
		/// Void Internal_DispatchRays(UnityEngine.Experimental.Rendering.RayTracingShader, System.String, UInt32, UInt32, UInt32, UnityEngine.Camera)
		/// </summary>
		protected RMethod r_RInternal_DispatchRays_RayTracingShader_String_UInt32_UInt32_UInt32_Camera;
		public virtual RMethod RInternal_DispatchRays_RayTracingShader_String_UInt32_UInt32_UInt32_Camera
		{
			get
			{
				if(r_RInternal_DispatchRays_RayTracingShader_String_UInt32_UInt32_UInt32_Camera == null)
				{
					r_RInternal_DispatchRays_RayTracingShader_String_UInt32_UInt32_UInt32_Camera = new(this, "Internal_DispatchRays", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.String), typeof(System.UInt32), typeof(System.UInt32), typeof(System.UInt32), typeof(UnityEngine.Camera));
					r_RInternal_DispatchRays_RayTracingShader_String_UInt32_UInt32_UInt32_Camera.SetBelong(this.instance);
				}
				return r_RInternal_DispatchRays_RayTracingShader_String_UInt32_UInt32_UInt32_Camera;
			}
		}

		/// <summary>
		/// Void Internal_GenerateMips(UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_RInternal_GenerateMips_RenderTargetIdentifier;
		public virtual RMethod RInternal_GenerateMips_RenderTargetIdentifier
		{
			get
			{
				if(r_RInternal_GenerateMips_RenderTargetIdentifier == null)
				{
					r_RInternal_GenerateMips_RenderTargetIdentifier = new(this, "Internal_GenerateMips", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier));
					r_RInternal_GenerateMips_RenderTargetIdentifier.SetBelong(this.instance);
				}
				return r_RInternal_GenerateMips_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void Internal_ResolveAntiAliasedSurface(UnityEngine.RenderTexture, UnityEngine.RenderTexture)
		/// </summary>
		protected RMethod r_RInternal_ResolveAntiAliasedSurface_RenderTexture_RenderTexture;
		public virtual RMethod RInternal_ResolveAntiAliasedSurface_RenderTexture_RenderTexture
		{
			get
			{
				if(r_RInternal_ResolveAntiAliasedSurface_RenderTexture_RenderTexture == null)
				{
					r_RInternal_ResolveAntiAliasedSurface_RenderTexture_RenderTexture = new(this, "Internal_ResolveAntiAliasedSurface", 0, typeof(UnityEngine.RenderTexture), typeof(UnityEngine.RenderTexture));
					r_RInternal_ResolveAntiAliasedSurface_RenderTexture_RenderTexture.SetBelong(this.instance);
				}
				return r_RInternal_ResolveAntiAliasedSurface_RenderTexture_RenderTexture;
			}
		}

		/// <summary>
		/// Void CopyCounterValueCC(UnityEngine.ComputeBuffer, UnityEngine.ComputeBuffer, UInt32)
		/// </summary>
		protected RMethod r_RCopyCounterValueCC_ComputeBuffer_ComputeBuffer_UInt32;
		public virtual RMethod RCopyCounterValueCC_ComputeBuffer_ComputeBuffer_UInt32
		{
			get
			{
				if(r_RCopyCounterValueCC_ComputeBuffer_ComputeBuffer_UInt32 == null)
				{
					r_RCopyCounterValueCC_ComputeBuffer_ComputeBuffer_UInt32 = new(this, "CopyCounterValueCC", 0, typeof(UnityEngine.ComputeBuffer), typeof(UnityEngine.ComputeBuffer), typeof(System.UInt32));
					r_RCopyCounterValueCC_ComputeBuffer_ComputeBuffer_UInt32.SetBelong(this.instance);
				}
				return r_RCopyCounterValueCC_ComputeBuffer_ComputeBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void CopyCounterValueGC(UnityEngine.GraphicsBuffer, UnityEngine.ComputeBuffer, UInt32)
		/// </summary>
		protected RMethod r_RCopyCounterValueGC_GraphicsBuffer_ComputeBuffer_UInt32;
		public virtual RMethod RCopyCounterValueGC_GraphicsBuffer_ComputeBuffer_UInt32
		{
			get
			{
				if(r_RCopyCounterValueGC_GraphicsBuffer_ComputeBuffer_UInt32 == null)
				{
					r_RCopyCounterValueGC_GraphicsBuffer_ComputeBuffer_UInt32 = new(this, "CopyCounterValueGC", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.ComputeBuffer), typeof(System.UInt32));
					r_RCopyCounterValueGC_GraphicsBuffer_ComputeBuffer_UInt32.SetBelong(this.instance);
				}
				return r_RCopyCounterValueGC_GraphicsBuffer_ComputeBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void CopyCounterValueCG(UnityEngine.ComputeBuffer, UnityEngine.GraphicsBuffer, UInt32)
		/// </summary>
		protected RMethod r_RCopyCounterValueCG_ComputeBuffer_GraphicsBuffer_UInt32;
		public virtual RMethod RCopyCounterValueCG_ComputeBuffer_GraphicsBuffer_UInt32
		{
			get
			{
				if(r_RCopyCounterValueCG_ComputeBuffer_GraphicsBuffer_UInt32 == null)
				{
					r_RCopyCounterValueCG_ComputeBuffer_GraphicsBuffer_UInt32 = new(this, "CopyCounterValueCG", 0, typeof(UnityEngine.ComputeBuffer), typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32));
					r_RCopyCounterValueCG_ComputeBuffer_GraphicsBuffer_UInt32.SetBelong(this.instance);
				}
				return r_RCopyCounterValueCG_ComputeBuffer_GraphicsBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void CopyCounterValueGG(UnityEngine.GraphicsBuffer, UnityEngine.GraphicsBuffer, UInt32)
		/// </summary>
		protected RMethod r_RCopyCounterValueGG_GraphicsBuffer_GraphicsBuffer_UInt32;
		public virtual RMethod RCopyCounterValueGG_GraphicsBuffer_GraphicsBuffer_UInt32
		{
			get
			{
				if(r_RCopyCounterValueGG_GraphicsBuffer_GraphicsBuffer_UInt32 == null)
				{
					r_RCopyCounterValueGG_GraphicsBuffer_GraphicsBuffer_UInt32 = new(this, "CopyCounterValueGG", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32));
					r_RCopyCounterValueGG_GraphicsBuffer_GraphicsBuffer_UInt32.SetBelong(this.instance);
				}
				return r_RCopyCounterValueGG_GraphicsBuffer_GraphicsBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_RClear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_RClear == null)
				{
					r_RClear = new(this, "Clear", 0);
					r_RClear.SetBelong(this.instance);
				}
				return r_RClear;
			}
		}

		/// <summary>
		/// Void Internal_DrawMesh(UnityEngine.Mesh, UnityEngine.Matrix4x4, UnityEngine.Material, Int32, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_RInternal_DrawMesh_Mesh_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock;
		public virtual RMethod RInternal_DrawMesh_Mesh_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_RInternal_DrawMesh_Mesh_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock == null)
				{
					r_RInternal_DrawMesh_Mesh_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock = new(this, "Internal_DrawMesh", 0, typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
					r_RInternal_DrawMesh_Mesh_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_RInternal_DrawMesh_Mesh_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawRenderer(UnityEngine.Renderer, UnityEngine.Material, Int32, Int32)
		/// </summary>
		protected RMethod r_RInternal_DrawRenderer_Renderer_Material_Int32_Int32;
		public virtual RMethod RInternal_DrawRenderer_Renderer_Material_Int32_Int32
		{
			get
			{
				if(r_RInternal_DrawRenderer_Renderer_Material_Int32_Int32 == null)
				{
					r_RInternal_DrawRenderer_Renderer_Material_Int32_Int32 = new(this, "Internal_DrawRenderer", 0, typeof(UnityEngine.Renderer), typeof(UnityEngine.Material), typeof(System.Int32), typeof(System.Int32));
					r_RInternal_DrawRenderer_Renderer_Material_Int32_Int32.SetBelong(this.instance);
				}
				return r_RInternal_DrawRenderer_Renderer_Material_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Internal_DrawRendererList(UnityEngine.Rendering.RendererList)
		/// </summary>
		protected RMethod r_RInternal_DrawRendererList_RendererList;
		public virtual RMethod RInternal_DrawRendererList_RendererList
		{
			get
			{
				if(r_RInternal_DrawRendererList_RendererList == null)
				{
					r_RInternal_DrawRendererList_RendererList = new(this, "Internal_DrawRendererList", 0, typeof(UnityEngine.Rendering.RendererList));
					r_RInternal_DrawRendererList_RendererList.SetBelong(this.instance);
				}
				return r_RInternal_DrawRendererList_RendererList;
			}
		}

		/// <summary>
		/// Void Internal_DrawRenderer(UnityEngine.Renderer, UnityEngine.Material, Int32)
		/// </summary>
		protected RMethod r_RInternal_DrawRenderer_Renderer_Material_Int32;
		public virtual RMethod RInternal_DrawRenderer_Renderer_Material_Int32
		{
			get
			{
				if(r_RInternal_DrawRenderer_Renderer_Material_Int32 == null)
				{
					r_RInternal_DrawRenderer_Renderer_Material_Int32 = new(this, "Internal_DrawRenderer", 0, typeof(UnityEngine.Renderer), typeof(UnityEngine.Material), typeof(System.Int32));
					r_RInternal_DrawRenderer_Renderer_Material_Int32.SetBelong(this.instance);
				}
				return r_RInternal_DrawRenderer_Renderer_Material_Int32;
			}
		}

		/// <summary>
		/// Void Internal_DrawRenderer(UnityEngine.Renderer, UnityEngine.Material)
		/// </summary>
		protected RMethod r_RInternal_DrawRenderer_Renderer_Material;
		public virtual RMethod RInternal_DrawRenderer_Renderer_Material
		{
			get
			{
				if(r_RInternal_DrawRenderer_Renderer_Material == null)
				{
					r_RInternal_DrawRenderer_Renderer_Material = new(this, "Internal_DrawRenderer", 0, typeof(UnityEngine.Renderer), typeof(UnityEngine.Material));
					r_RInternal_DrawRenderer_Renderer_Material.SetBelong(this.instance);
				}
				return r_RInternal_DrawRenderer_Renderer_Material;
			}
		}

		/// <summary>
		/// Void Internal_DrawProcedural(UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, Int32, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_RInternal_DrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock;
		public virtual RMethod RInternal_DrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_RInternal_DrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock == null)
				{
					r_RInternal_DrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock = new(this, "Internal_DrawProcedural", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
					r_RInternal_DrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_RInternal_DrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawProceduralIndexed(UnityEngine.GraphicsBuffer, UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, Int32, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_RInternal_DrawProceduralIndexed_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock;
		public virtual RMethod RInternal_DrawProceduralIndexed_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_RInternal_DrawProceduralIndexed_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock == null)
				{
					r_RInternal_DrawProceduralIndexed_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock = new(this, "Internal_DrawProceduralIndexed", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
					r_RInternal_DrawProceduralIndexed_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_RInternal_DrawProceduralIndexed_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawProceduralIndirect(UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.ComputeBuffer, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_RInternal_DrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock;
		public virtual RMethod RInternal_DrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_RInternal_DrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock == null)
				{
					r_RInternal_DrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock = new(this, "Internal_DrawProceduralIndirect", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
					r_RInternal_DrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_RInternal_DrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawProceduralIndexedIndirect(UnityEngine.GraphicsBuffer, UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.ComputeBuffer, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_RInternal_DrawProceduralIndexedIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock;
		public virtual RMethod RInternal_DrawProceduralIndexedIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_RInternal_DrawProceduralIndexedIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock == null)
				{
					r_RInternal_DrawProceduralIndexedIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock = new(this, "Internal_DrawProceduralIndexedIndirect", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
					r_RInternal_DrawProceduralIndexedIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_RInternal_DrawProceduralIndexedIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawProceduralIndirectGraphicsBuffer(UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.GraphicsBuffer, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_RInternal_DrawProceduralIndirectGraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock;
		public virtual RMethod RInternal_DrawProceduralIndirectGraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_RInternal_DrawProceduralIndirectGraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock == null)
				{
					r_RInternal_DrawProceduralIndirectGraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock = new(this, "Internal_DrawProceduralIndirectGraphicsBuffer", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
					r_RInternal_DrawProceduralIndirectGraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_RInternal_DrawProceduralIndirectGraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawProceduralIndexedIndirectGraphicsBuffer(UnityEngine.GraphicsBuffer, UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.GraphicsBuffer, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_RInternal_DrawProceduralIndexedIndirectGraphicsBuffer_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock;
		public virtual RMethod RInternal_DrawProceduralIndexedIndirectGraphicsBuffer_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_RInternal_DrawProceduralIndexedIndirectGraphicsBuffer_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock == null)
				{
					r_RInternal_DrawProceduralIndexedIndirectGraphicsBuffer_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock = new(this, "Internal_DrawProceduralIndexedIndirectGraphicsBuffer", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
					r_RInternal_DrawProceduralIndexedIndirectGraphicsBuffer_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_RInternal_DrawProceduralIndexedIndirectGraphicsBuffer_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawMeshInstanced(UnityEngine.Mesh, Int32, UnityEngine.Material, Int32, UnityEngine.Matrix4x4[], Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_RInternal_DrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32_MaterialPropertyBlock;
		public virtual RMethod RInternal_DrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_RInternal_DrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32_MaterialPropertyBlock == null)
				{
					r_RInternal_DrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32_MaterialPropertyBlock = new(this, "Internal_DrawMeshInstanced", 0, typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType(), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
					r_RInternal_DrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_RInternal_DrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawMeshInstancedProcedural(UnityEngine.Mesh, Int32, UnityEngine.Material, Int32, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_RInternal_DrawMeshInstancedProcedural_Mesh_Int32_Material_Int32_Int32_MaterialPropertyBlock;
		public virtual RMethod RInternal_DrawMeshInstancedProcedural_Mesh_Int32_Material_Int32_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_RInternal_DrawMeshInstancedProcedural_Mesh_Int32_Material_Int32_Int32_MaterialPropertyBlock == null)
				{
					r_RInternal_DrawMeshInstancedProcedural_Mesh_Int32_Material_Int32_Int32_MaterialPropertyBlock = new(this, "Internal_DrawMeshInstancedProcedural", 0, typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
					r_RInternal_DrawMeshInstancedProcedural_Mesh_Int32_Material_Int32_Int32_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_RInternal_DrawMeshInstancedProcedural_Mesh_Int32_Material_Int32_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawMeshInstancedIndirect(UnityEngine.Mesh, Int32, UnityEngine.Material, Int32, UnityEngine.ComputeBuffer, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_RInternal_DrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32_MaterialPropertyBlock;
		public virtual RMethod RInternal_DrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_RInternal_DrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32_MaterialPropertyBlock == null)
				{
					r_RInternal_DrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32_MaterialPropertyBlock = new(this, "Internal_DrawMeshInstancedIndirect", 0, typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
					r_RInternal_DrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_RInternal_DrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawMeshInstancedIndirectGraphicsBuffer(UnityEngine.Mesh, Int32, UnityEngine.Material, Int32, UnityEngine.GraphicsBuffer, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_RInternal_DrawMeshInstancedIndirectGraphicsBuffer_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32_MaterialPropertyBlock;
		public virtual RMethod RInternal_DrawMeshInstancedIndirectGraphicsBuffer_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_RInternal_DrawMeshInstancedIndirectGraphicsBuffer_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32_MaterialPropertyBlock == null)
				{
					r_RInternal_DrawMeshInstancedIndirectGraphicsBuffer_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32_MaterialPropertyBlock = new(this, "Internal_DrawMeshInstancedIndirectGraphicsBuffer", 0, typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
					r_RInternal_DrawMeshInstancedIndirectGraphicsBuffer_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_RInternal_DrawMeshInstancedIndirectGraphicsBuffer_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawOcclusionMesh(UnityEngine.RectInt)
		/// </summary>
		protected RMethod r_RInternal_DrawOcclusionMesh_RectInt;
		public virtual RMethod RInternal_DrawOcclusionMesh_RectInt
		{
			get
			{
				if(r_RInternal_DrawOcclusionMesh_RectInt == null)
				{
					r_RInternal_DrawOcclusionMesh_RectInt = new(this, "Internal_DrawOcclusionMesh", 0, typeof(UnityEngine.RectInt));
					r_RInternal_DrawOcclusionMesh_RectInt.SetBelong(this.instance);
				}
				return r_RInternal_DrawOcclusionMesh_RectInt;
			}
		}

		/// <summary>
		/// Void SetRandomWriteTarget_Texture(Int32, UnityEngine.Rendering.RenderTargetIdentifier ByRef)
		/// </summary>
		protected RMethod r_RSetRandomWriteTarget_Texture_Int32_Ref_RenderTargetIdentifier;
		public virtual RMethod RSetRandomWriteTarget_Texture_Int32_Ref_RenderTargetIdentifier
		{
			get
			{
				if(r_RSetRandomWriteTarget_Texture_Int32_Ref_RenderTargetIdentifier == null)
				{
					r_RSetRandomWriteTarget_Texture_Int32_Ref_RenderTargetIdentifier = new(this, "SetRandomWriteTarget_Texture", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType());
					r_RSetRandomWriteTarget_Texture_Int32_Ref_RenderTargetIdentifier.SetBelong(this.instance);
				}
				return r_RSetRandomWriteTarget_Texture_Int32_Ref_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void SetRandomWriteTarget_Buffer(Int32, UnityEngine.ComputeBuffer, Boolean)
		/// </summary>
		protected RMethod r_RSetRandomWriteTarget_Buffer_Int32_ComputeBuffer_Boolean;
		public virtual RMethod RSetRandomWriteTarget_Buffer_Int32_ComputeBuffer_Boolean
		{
			get
			{
				if(r_RSetRandomWriteTarget_Buffer_Int32_ComputeBuffer_Boolean == null)
				{
					r_RSetRandomWriteTarget_Buffer_Int32_ComputeBuffer_Boolean = new(this, "SetRandomWriteTarget_Buffer", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Boolean));
					r_RSetRandomWriteTarget_Buffer_Int32_ComputeBuffer_Boolean.SetBelong(this.instance);
				}
				return r_RSetRandomWriteTarget_Buffer_Int32_ComputeBuffer_Boolean;
			}
		}

		/// <summary>
		/// Void SetRandomWriteTarget_GraphicsBuffer(Int32, UnityEngine.GraphicsBuffer, Boolean)
		/// </summary>
		protected RMethod r_RSetRandomWriteTarget_GraphicsBuffer_Int32_GraphicsBuffer_Boolean;
		public virtual RMethod RSetRandomWriteTarget_GraphicsBuffer_Int32_GraphicsBuffer_Boolean
		{
			get
			{
				if(r_RSetRandomWriteTarget_GraphicsBuffer_Int32_GraphicsBuffer_Boolean == null)
				{
					r_RSetRandomWriteTarget_GraphicsBuffer_Int32_GraphicsBuffer_Boolean = new(this, "SetRandomWriteTarget_GraphicsBuffer", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Boolean));
					r_RSetRandomWriteTarget_GraphicsBuffer_Int32_GraphicsBuffer_Boolean.SetBelong(this.instance);
				}
				return r_RSetRandomWriteTarget_GraphicsBuffer_Int32_GraphicsBuffer_Boolean;
			}
		}

		/// <summary>
		/// Void ClearRandomWriteTargets()
		/// </summary>
		protected RMethod r_RClearRandomWriteTargets;
		public virtual RMethod RClearRandomWriteTargets
		{
			get
			{
				if(r_RClearRandomWriteTargets == null)
				{
					r_RClearRandomWriteTargets = new(this, "ClearRandomWriteTargets", 0);
					r_RClearRandomWriteTargets.SetBelong(this.instance);
				}
				return r_RClearRandomWriteTargets;
			}
		}

		/// <summary>
		/// Void SetViewport(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_RSetViewport_Rect;
		public virtual RMethod RSetViewport_Rect
		{
			get
			{
				if(r_RSetViewport_Rect == null)
				{
					r_RSetViewport_Rect = new(this, "SetViewport", 0, typeof(UnityEngine.Rect));
					r_RSetViewport_Rect.SetBelong(this.instance);
				}
				return r_RSetViewport_Rect;
			}
		}

		/// <summary>
		/// Void EnableScissorRect(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_REnableScissorRect_Rect;
		public virtual RMethod REnableScissorRect_Rect
		{
			get
			{
				if(r_REnableScissorRect_Rect == null)
				{
					r_REnableScissorRect_Rect = new(this, "EnableScissorRect", 0, typeof(UnityEngine.Rect));
					r_REnableScissorRect_Rect.SetBelong(this.instance);
				}
				return r_REnableScissorRect_Rect;
			}
		}

		/// <summary>
		/// Void DisableScissorRect()
		/// </summary>
		protected RMethod r_RDisableScissorRect;
		public virtual RMethod RDisableScissorRect
		{
			get
			{
				if(r_RDisableScissorRect == null)
				{
					r_RDisableScissorRect = new(this, "DisableScissorRect", 0);
					r_RDisableScissorRect.SetBelong(this.instance);
				}
				return r_RDisableScissorRect;
			}
		}

		/// <summary>
		/// Void CopyTexture_Internal(UnityEngine.Rendering.RenderTargetIdentifier ByRef, Int32, Int32, Int32, Int32, Int32, Int32, UnityEngine.Rendering.RenderTargetIdentifier ByRef, Int32, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RCopyTexture_Internal_Ref_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32_Int32_Ref_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32;
		public virtual RMethod RCopyTexture_Internal_Ref_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32_Int32_Ref_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_RCopyTexture_Internal_Ref_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32_Int32_Ref_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32 == null)
				{
					r_RCopyTexture_Internal_Ref_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32_Int32_Ref_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32 = new(this, "CopyTexture_Internal", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RCopyTexture_Internal_Ref_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32_Int32_Ref_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RCopyTexture_Internal_Ref_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32_Int32_Ref_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Blit_Texture(UnityEngine.Texture, UnityEngine.Rendering.RenderTargetIdentifier ByRef, UnityEngine.Material, Int32, UnityEngine.Vector2, UnityEngine.Vector2, Int32, Int32)
		/// </summary>
		protected RMethod r_RBlit_Texture_Texture_Ref_RenderTargetIdentifier_Material_Int32_Vector2_Vector2_Int32_Int32;
		public virtual RMethod RBlit_Texture_Texture_Ref_RenderTargetIdentifier_Material_Int32_Vector2_Vector2_Int32_Int32
		{
			get
			{
				if(r_RBlit_Texture_Texture_Ref_RenderTargetIdentifier_Material_Int32_Vector2_Vector2_Int32_Int32 == null)
				{
					r_RBlit_Texture_Texture_Ref_RenderTargetIdentifier_Material_Int32_Vector2_Vector2_Int32_Int32 = new(this, "Blit_Texture", 0, typeof(UnityEngine.Texture), typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Int32), typeof(System.Int32));
					r_RBlit_Texture_Texture_Ref_RenderTargetIdentifier_Material_Int32_Vector2_Vector2_Int32_Int32.SetBelong(this.instance);
				}
				return r_RBlit_Texture_Texture_Ref_RenderTargetIdentifier_Material_Int32_Vector2_Vector2_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Blit_Identifier(UnityEngine.Rendering.RenderTargetIdentifier ByRef, UnityEngine.Rendering.RenderTargetIdentifier ByRef, UnityEngine.Material, Int32, UnityEngine.Vector2, UnityEngine.Vector2, Int32, Int32)
		/// </summary>
		protected RMethod r_RBlit_Identifier_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_Material_Int32_Vector2_Vector2_Int32_Int32;
		public virtual RMethod RBlit_Identifier_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_Material_Int32_Vector2_Vector2_Int32_Int32
		{
			get
			{
				if(r_RBlit_Identifier_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_Material_Int32_Vector2_Vector2_Int32_Int32 == null)
				{
					r_RBlit_Identifier_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_Material_Int32_Vector2_Vector2_Int32_Int32 = new(this, "Blit_Identifier", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Int32), typeof(System.Int32));
					r_RBlit_Identifier_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_Material_Int32_Vector2_Vector2_Int32_Int32.SetBelong(this.instance);
				}
				return r_RBlit_Identifier_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_Material_Int32_Vector2_Vector2_Int32_Int32;
			}
		}

		/// <summary>
		/// Void GetTemporaryRT(Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.Experimental.Rendering.GraphicsFormat, Int32, Boolean, UnityEngine.RenderTextureMemoryless, Boolean)
		/// </summary>
		protected RMethod r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_RenderTextureMemoryless_Boolean;
		public virtual RMethod RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_RenderTextureMemoryless_Boolean
		{
			get
			{
				if(r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_RenderTextureMemoryless_Boolean == null)
				{
					r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_RenderTextureMemoryless_Boolean = new(this, "GetTemporaryRT", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Int32), typeof(System.Boolean), typeof(UnityEngine.RenderTextureMemoryless), typeof(System.Boolean));
					r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_RenderTextureMemoryless_Boolean.SetBelong(this.instance);
				}
				return r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_RenderTextureMemoryless_Boolean;
			}
		}

		/// <summary>
		/// Void GetTemporaryRT(Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.Experimental.Rendering.GraphicsFormat, Int32, Boolean, UnityEngine.RenderTextureMemoryless)
		/// </summary>
		protected RMethod r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_RenderTextureMemoryless;
		public virtual RMethod RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_RenderTextureMemoryless
		{
			get
			{
				if(r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_RenderTextureMemoryless == null)
				{
					r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_RenderTextureMemoryless = new(this, "GetTemporaryRT", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Int32), typeof(System.Boolean), typeof(UnityEngine.RenderTextureMemoryless));
					r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_RenderTextureMemoryless.SetBelong(this.instance);
				}
				return r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_RenderTextureMemoryless;
			}
		}

		/// <summary>
		/// Void GetTemporaryRT(Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.Experimental.Rendering.GraphicsFormat, Int32, Boolean)
		/// </summary>
		protected RMethod r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean;
		public virtual RMethod RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean
		{
			get
			{
				if(r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean == null)
				{
					r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean = new(this, "GetTemporaryRT", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Int32), typeof(System.Boolean));
					r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetTemporaryRT(Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.Experimental.Rendering.GraphicsFormat, Int32)
		/// </summary>
		protected RMethod r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32;
		public virtual RMethod RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32
		{
			get
			{
				if(r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32 == null)
				{
					r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32 = new(this, "GetTemporaryRT", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Int32));
					r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32.SetBelong(this.instance);
				}
				return r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32;
			}
		}

		/// <summary>
		/// Void GetTemporaryRT(Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.Experimental.Rendering.GraphicsFormat)
		/// </summary>
		protected RMethod r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat;
		public virtual RMethod RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat
		{
			get
			{
				if(r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat == null)
				{
					r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat = new(this, "GetTemporaryRT", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat));
					r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat.SetBelong(this.instance);
				}
				return r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat;
			}
		}

		/// <summary>
		/// Void GetTemporaryRT(Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite, Int32, Boolean, UnityEngine.RenderTextureMemoryless, Boolean)
		/// </summary>
		protected RMethod r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_RenderTextureMemoryless_Boolean;
		public virtual RMethod RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_RenderTextureMemoryless_Boolean
		{
			get
			{
				if(r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_RenderTextureMemoryless_Boolean == null)
				{
					r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_RenderTextureMemoryless_Boolean = new(this, "GetTemporaryRT", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.RenderTextureFormat), typeof(UnityEngine.RenderTextureReadWrite), typeof(System.Int32), typeof(System.Boolean), typeof(UnityEngine.RenderTextureMemoryless), typeof(System.Boolean));
					r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_RenderTextureMemoryless_Boolean.SetBelong(this.instance);
				}
				return r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_RenderTextureMemoryless_Boolean;
			}
		}

		/// <summary>
		/// Void GetTemporaryRT(Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite, Int32, Boolean, UnityEngine.RenderTextureMemoryless)
		/// </summary>
		protected RMethod r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_RenderTextureMemoryless;
		public virtual RMethod RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_RenderTextureMemoryless
		{
			get
			{
				if(r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_RenderTextureMemoryless == null)
				{
					r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_RenderTextureMemoryless = new(this, "GetTemporaryRT", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.RenderTextureFormat), typeof(UnityEngine.RenderTextureReadWrite), typeof(System.Int32), typeof(System.Boolean), typeof(UnityEngine.RenderTextureMemoryless));
					r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_RenderTextureMemoryless.SetBelong(this.instance);
				}
				return r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_RenderTextureMemoryless;
			}
		}

		/// <summary>
		/// Void GetTemporaryRT(Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite, Int32, Boolean)
		/// </summary>
		protected RMethod r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean;
		public virtual RMethod RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean
		{
			get
			{
				if(r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean == null)
				{
					r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean = new(this, "GetTemporaryRT", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.RenderTextureFormat), typeof(UnityEngine.RenderTextureReadWrite), typeof(System.Int32), typeof(System.Boolean));
					r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetTemporaryRT(Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite, Int32)
		/// </summary>
		protected RMethod r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32;
		public virtual RMethod RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32
		{
			get
			{
				if(r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32 == null)
				{
					r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32 = new(this, "GetTemporaryRT", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.RenderTextureFormat), typeof(UnityEngine.RenderTextureReadWrite), typeof(System.Int32));
					r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32.SetBelong(this.instance);
				}
				return r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32;
			}
		}

		/// <summary>
		/// Void GetTemporaryRT(Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite)
		/// </summary>
		protected RMethod r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite;
		public virtual RMethod RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite
		{
			get
			{
				if(r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite == null)
				{
					r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite = new(this, "GetTemporaryRT", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.RenderTextureFormat), typeof(UnityEngine.RenderTextureReadWrite));
					r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite.SetBelong(this.instance);
				}
				return r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite;
			}
		}

		/// <summary>
		/// Void GetTemporaryRT(Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.RenderTextureFormat)
		/// </summary>
		protected RMethod r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat;
		public virtual RMethod RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat
		{
			get
			{
				if(r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat == null)
				{
					r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat = new(this, "GetTemporaryRT", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.RenderTextureFormat));
					r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat.SetBelong(this.instance);
				}
				return r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat;
			}
		}

		/// <summary>
		/// Void GetTemporaryRT(Int32, Int32, Int32, Int32, UnityEngine.FilterMode)
		/// </summary>
		protected RMethod r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode;
		public virtual RMethod RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode
		{
			get
			{
				if(r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode == null)
				{
					r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode = new(this, "GetTemporaryRT", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode));
					r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode.SetBelong(this.instance);
				}
				return r_RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode;
			}
		}

		/// <summary>
		/// Void GetTemporaryRT(Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RGetTemporaryRT_Int32_Int32_Int32_Int32;
		public virtual RMethod RGetTemporaryRT_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_RGetTemporaryRT_Int32_Int32_Int32_Int32 == null)
				{
					r_RGetTemporaryRT_Int32_Int32_Int32_Int32 = new(this, "GetTemporaryRT", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RGetTemporaryRT_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RGetTemporaryRT_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void GetTemporaryRT(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RGetTemporaryRT_Int32_Int32_Int32;
		public virtual RMethod RGetTemporaryRT_Int32_Int32_Int32
		{
			get
			{
				if(r_RGetTemporaryRT_Int32_Int32_Int32 == null)
				{
					r_RGetTemporaryRT_Int32_Int32_Int32 = new(this, "GetTemporaryRT", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RGetTemporaryRT_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RGetTemporaryRT_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void GetTemporaryRTWithDescriptor(Int32, UnityEngine.RenderTextureDescriptor, UnityEngine.FilterMode)
		/// </summary>
		protected RMethod r_RGetTemporaryRTWithDescriptor_Int32_RenderTextureDescriptor_FilterMode;
		public virtual RMethod RGetTemporaryRTWithDescriptor_Int32_RenderTextureDescriptor_FilterMode
		{
			get
			{
				if(r_RGetTemporaryRTWithDescriptor_Int32_RenderTextureDescriptor_FilterMode == null)
				{
					r_RGetTemporaryRTWithDescriptor_Int32_RenderTextureDescriptor_FilterMode = new(this, "GetTemporaryRTWithDescriptor", 0, typeof(System.Int32), typeof(UnityEngine.RenderTextureDescriptor), typeof(UnityEngine.FilterMode));
					r_RGetTemporaryRTWithDescriptor_Int32_RenderTextureDescriptor_FilterMode.SetBelong(this.instance);
				}
				return r_RGetTemporaryRTWithDescriptor_Int32_RenderTextureDescriptor_FilterMode;
			}
		}

		/// <summary>
		/// Void GetTemporaryRT(Int32, UnityEngine.RenderTextureDescriptor, UnityEngine.FilterMode)
		/// </summary>
		protected RMethod r_RGetTemporaryRT_Int32_RenderTextureDescriptor_FilterMode;
		public virtual RMethod RGetTemporaryRT_Int32_RenderTextureDescriptor_FilterMode
		{
			get
			{
				if(r_RGetTemporaryRT_Int32_RenderTextureDescriptor_FilterMode == null)
				{
					r_RGetTemporaryRT_Int32_RenderTextureDescriptor_FilterMode = new(this, "GetTemporaryRT", 0, typeof(System.Int32), typeof(UnityEngine.RenderTextureDescriptor), typeof(UnityEngine.FilterMode));
					r_RGetTemporaryRT_Int32_RenderTextureDescriptor_FilterMode.SetBelong(this.instance);
				}
				return r_RGetTemporaryRT_Int32_RenderTextureDescriptor_FilterMode;
			}
		}

		/// <summary>
		/// Void GetTemporaryRT(Int32, UnityEngine.RenderTextureDescriptor)
		/// </summary>
		protected RMethod r_RGetTemporaryRT_Int32_RenderTextureDescriptor;
		public virtual RMethod RGetTemporaryRT_Int32_RenderTextureDescriptor
		{
			get
			{
				if(r_RGetTemporaryRT_Int32_RenderTextureDescriptor == null)
				{
					r_RGetTemporaryRT_Int32_RenderTextureDescriptor = new(this, "GetTemporaryRT", 0, typeof(System.Int32), typeof(UnityEngine.RenderTextureDescriptor));
					r_RGetTemporaryRT_Int32_RenderTextureDescriptor.SetBelong(this.instance);
				}
				return r_RGetTemporaryRT_Int32_RenderTextureDescriptor;
			}
		}

		/// <summary>
		/// Void GetTemporaryRTArray(Int32, Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.Experimental.Rendering.GraphicsFormat, Int32, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_Boolean;
		public virtual RMethod RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_Boolean
		{
			get
			{
				if(r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_Boolean == null)
				{
					r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_Boolean = new(this, "GetTemporaryRTArray", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Int32), typeof(System.Boolean), typeof(System.Boolean));
					r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void GetTemporaryRTArray(Int32, Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.Experimental.Rendering.GraphicsFormat, Int32, Boolean)
		/// </summary>
		protected RMethod r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean;
		public virtual RMethod RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean
		{
			get
			{
				if(r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean == null)
				{
					r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean = new(this, "GetTemporaryRTArray", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Int32), typeof(System.Boolean));
					r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetTemporaryRTArray(Int32, Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.Experimental.Rendering.GraphicsFormat, Int32)
		/// </summary>
		protected RMethod r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32;
		public virtual RMethod RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32
		{
			get
			{
				if(r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32 == null)
				{
					r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32 = new(this, "GetTemporaryRTArray", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Int32));
					r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32.SetBelong(this.instance);
				}
				return r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32;
			}
		}

		/// <summary>
		/// Void GetTemporaryRTArray(Int32, Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.Experimental.Rendering.GraphicsFormat)
		/// </summary>
		protected RMethod r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat;
		public virtual RMethod RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat
		{
			get
			{
				if(r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat == null)
				{
					r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat = new(this, "GetTemporaryRTArray", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat));
					r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat.SetBelong(this.instance);
				}
				return r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat;
			}
		}

		/// <summary>
		/// Void GetTemporaryRTArray(Int32, Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite, Int32, Boolean)
		/// </summary>
		protected RMethod r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean;
		public virtual RMethod RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean
		{
			get
			{
				if(r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean == null)
				{
					r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean = new(this, "GetTemporaryRTArray", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.RenderTextureFormat), typeof(UnityEngine.RenderTextureReadWrite), typeof(System.Int32), typeof(System.Boolean));
					r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetTemporaryRTArray(Int32, Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite, Int32)
		/// </summary>
		protected RMethod r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32;
		public virtual RMethod RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32
		{
			get
			{
				if(r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32 == null)
				{
					r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32 = new(this, "GetTemporaryRTArray", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.RenderTextureFormat), typeof(UnityEngine.RenderTextureReadWrite), typeof(System.Int32));
					r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32.SetBelong(this.instance);
				}
				return r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32;
			}
		}

		/// <summary>
		/// Void GetTemporaryRTArray(Int32, Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite)
		/// </summary>
		protected RMethod r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite;
		public virtual RMethod RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite
		{
			get
			{
				if(r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite == null)
				{
					r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite = new(this, "GetTemporaryRTArray", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.RenderTextureFormat), typeof(UnityEngine.RenderTextureReadWrite));
					r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite.SetBelong(this.instance);
				}
				return r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite;
			}
		}

		/// <summary>
		/// Void GetTemporaryRTArray(Int32, Int32, Int32, Int32, Int32, UnityEngine.FilterMode, UnityEngine.RenderTextureFormat)
		/// </summary>
		protected RMethod r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat;
		public virtual RMethod RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat
		{
			get
			{
				if(r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat == null)
				{
					r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat = new(this, "GetTemporaryRTArray", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.RenderTextureFormat));
					r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat.SetBelong(this.instance);
				}
				return r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat;
			}
		}

		/// <summary>
		/// Void GetTemporaryRTArray(Int32, Int32, Int32, Int32, Int32, UnityEngine.FilterMode)
		/// </summary>
		protected RMethod r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode;
		public virtual RMethod RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode
		{
			get
			{
				if(r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode == null)
				{
					r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode = new(this, "GetTemporaryRTArray", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode));
					r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode.SetBelong(this.instance);
				}
				return r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode;
			}
		}

		/// <summary>
		/// Void GetTemporaryRTArray(Int32, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32;
		public virtual RMethod RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32 == null)
				{
					r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32 = new(this, "GetTemporaryRTArray", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void GetTemporaryRTArray(Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32;
		public virtual RMethod RGetTemporaryRTArray_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32 == null)
				{
					r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32 = new(this, "GetTemporaryRTArray", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RGetTemporaryRTArray_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void ReleaseTemporaryRT(Int32)
		/// </summary>
		protected RMethod r_RReleaseTemporaryRT_Int32;
		public virtual RMethod RReleaseTemporaryRT_Int32
		{
			get
			{
				if(r_RReleaseTemporaryRT_Int32 == null)
				{
					r_RReleaseTemporaryRT_Int32 = new(this, "ReleaseTemporaryRT", 0, typeof(System.Int32));
					r_RReleaseTemporaryRT_Int32.SetBelong(this.instance);
				}
				return r_RReleaseTemporaryRT_Int32;
			}
		}

		/// <summary>
		/// Void ClearRenderTarget(UnityEngine.Rendering.RTClearFlags, UnityEngine.Color, Single, UInt32)
		/// </summary>
		protected RMethod r_RClearRenderTarget_RTClearFlags_Color_Single_UInt32;
		public virtual RMethod RClearRenderTarget_RTClearFlags_Color_Single_UInt32
		{
			get
			{
				if(r_RClearRenderTarget_RTClearFlags_Color_Single_UInt32 == null)
				{
					r_RClearRenderTarget_RTClearFlags_Color_Single_UInt32 = new(this, "ClearRenderTarget", 0, typeof(UnityEngine.Rendering.RTClearFlags), typeof(UnityEngine.Color), typeof(System.Single), typeof(System.UInt32));
					r_RClearRenderTarget_RTClearFlags_Color_Single_UInt32.SetBelong(this.instance);
				}
				return r_RClearRenderTarget_RTClearFlags_Color_Single_UInt32;
			}
		}

		/// <summary>
		/// Void ClearRenderTarget(Boolean, Boolean, UnityEngine.Color)
		/// </summary>
		protected RMethod r_RClearRenderTarget_Boolean_Boolean_Color;
		public virtual RMethod RClearRenderTarget_Boolean_Boolean_Color
		{
			get
			{
				if(r_RClearRenderTarget_Boolean_Boolean_Color == null)
				{
					r_RClearRenderTarget_Boolean_Boolean_Color = new(this, "ClearRenderTarget", 0, typeof(System.Boolean), typeof(System.Boolean), typeof(UnityEngine.Color));
					r_RClearRenderTarget_Boolean_Boolean_Color.SetBelong(this.instance);
				}
				return r_RClearRenderTarget_Boolean_Boolean_Color;
			}
		}

		/// <summary>
		/// Void ClearRenderTarget(Boolean, Boolean, UnityEngine.Color, Single)
		/// </summary>
		protected RMethod r_RClearRenderTarget_Boolean_Boolean_Color_Single;
		public virtual RMethod RClearRenderTarget_Boolean_Boolean_Color_Single
		{
			get
			{
				if(r_RClearRenderTarget_Boolean_Boolean_Color_Single == null)
				{
					r_RClearRenderTarget_Boolean_Boolean_Color_Single = new(this, "ClearRenderTarget", 0, typeof(System.Boolean), typeof(System.Boolean), typeof(UnityEngine.Color), typeof(System.Single));
					r_RClearRenderTarget_Boolean_Boolean_Color_Single.SetBelong(this.instance);
				}
				return r_RClearRenderTarget_Boolean_Boolean_Color_Single;
			}
		}

		/// <summary>
		/// Void SetGlobalFloat(Int32, Single)
		/// </summary>
		protected RMethod r_RSetGlobalFloat_Int32_Single;
		public virtual RMethod RSetGlobalFloat_Int32_Single
		{
			get
			{
				if(r_RSetGlobalFloat_Int32_Single == null)
				{
					r_RSetGlobalFloat_Int32_Single = new(this, "SetGlobalFloat", 0, typeof(System.Int32), typeof(System.Single));
					r_RSetGlobalFloat_Int32_Single.SetBelong(this.instance);
				}
				return r_RSetGlobalFloat_Int32_Single;
			}
		}

		/// <summary>
		/// Void SetGlobalInt(Int32, Int32)
		/// </summary>
		protected RMethod r_RSetGlobalInt_Int32_Int32;
		public virtual RMethod RSetGlobalInt_Int32_Int32
		{
			get
			{
				if(r_RSetGlobalInt_Int32_Int32 == null)
				{
					r_RSetGlobalInt_Int32_Int32 = new(this, "SetGlobalInt", 0, typeof(System.Int32), typeof(System.Int32));
					r_RSetGlobalInt_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetGlobalInt_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalInteger(Int32, Int32)
		/// </summary>
		protected RMethod r_RSetGlobalInteger_Int32_Int32;
		public virtual RMethod RSetGlobalInteger_Int32_Int32
		{
			get
			{
				if(r_RSetGlobalInteger_Int32_Int32 == null)
				{
					r_RSetGlobalInteger_Int32_Int32 = new(this, "SetGlobalInteger", 0, typeof(System.Int32), typeof(System.Int32));
					r_RSetGlobalInteger_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetGlobalInteger_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalVector(Int32, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_RSetGlobalVector_Int32_Vector4;
		public virtual RMethod RSetGlobalVector_Int32_Vector4
		{
			get
			{
				if(r_RSetGlobalVector_Int32_Vector4 == null)
				{
					r_RSetGlobalVector_Int32_Vector4 = new(this, "SetGlobalVector", 0, typeof(System.Int32), typeof(UnityEngine.Vector4));
					r_RSetGlobalVector_Int32_Vector4.SetBelong(this.instance);
				}
				return r_RSetGlobalVector_Int32_Vector4;
			}
		}

		/// <summary>
		/// Void SetGlobalColor(Int32, UnityEngine.Color)
		/// </summary>
		protected RMethod r_RSetGlobalColor_Int32_Color;
		public virtual RMethod RSetGlobalColor_Int32_Color
		{
			get
			{
				if(r_RSetGlobalColor_Int32_Color == null)
				{
					r_RSetGlobalColor_Int32_Color = new(this, "SetGlobalColor", 0, typeof(System.Int32), typeof(UnityEngine.Color));
					r_RSetGlobalColor_Int32_Color.SetBelong(this.instance);
				}
				return r_RSetGlobalColor_Int32_Color;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrix(Int32, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_RSetGlobalMatrix_Int32_Matrix4x4;
		public virtual RMethod RSetGlobalMatrix_Int32_Matrix4x4
		{
			get
			{
				if(r_RSetGlobalMatrix_Int32_Matrix4x4 == null)
				{
					r_RSetGlobalMatrix_Int32_Matrix4x4 = new(this, "SetGlobalMatrix", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4));
					r_RSetGlobalMatrix_Int32_Matrix4x4.SetBelong(this.instance);
				}
				return r_RSetGlobalMatrix_Int32_Matrix4x4;
			}
		}

		/// <summary>
		/// Void EnableShaderKeyword(System.String)
		/// </summary>
		protected RMethod r_REnableShaderKeyword_String;
		public virtual RMethod REnableShaderKeyword_String
		{
			get
			{
				if(r_REnableShaderKeyword_String == null)
				{
					r_REnableShaderKeyword_String = new(this, "EnableShaderKeyword", 0, typeof(System.String));
					r_REnableShaderKeyword_String.SetBelong(this.instance);
				}
				return r_REnableShaderKeyword_String;
			}
		}

		/// <summary>
		/// Void EnableGlobalKeyword(UnityEngine.Rendering.GlobalKeyword)
		/// </summary>
		protected RMethod r_REnableGlobalKeyword_GlobalKeyword;
		public virtual RMethod REnableGlobalKeyword_GlobalKeyword
		{
			get
			{
				if(r_REnableGlobalKeyword_GlobalKeyword == null)
				{
					r_REnableGlobalKeyword_GlobalKeyword = new(this, "EnableGlobalKeyword", 0, typeof(UnityEngine.Rendering.GlobalKeyword));
					r_REnableGlobalKeyword_GlobalKeyword.SetBelong(this.instance);
				}
				return r_REnableGlobalKeyword_GlobalKeyword;
			}
		}

		/// <summary>
		/// Void EnableMaterialKeyword(UnityEngine.Material, UnityEngine.Rendering.LocalKeyword)
		/// </summary>
		protected RMethod r_REnableMaterialKeyword_Material_LocalKeyword;
		public virtual RMethod REnableMaterialKeyword_Material_LocalKeyword
		{
			get
			{
				if(r_REnableMaterialKeyword_Material_LocalKeyword == null)
				{
					r_REnableMaterialKeyword_Material_LocalKeyword = new(this, "EnableMaterialKeyword", 0, typeof(UnityEngine.Material), typeof(UnityEngine.Rendering.LocalKeyword));
					r_REnableMaterialKeyword_Material_LocalKeyword.SetBelong(this.instance);
				}
				return r_REnableMaterialKeyword_Material_LocalKeyword;
			}
		}

		/// <summary>
		/// Void EnableComputeKeyword(UnityEngine.ComputeShader, UnityEngine.Rendering.LocalKeyword)
		/// </summary>
		protected RMethod r_REnableComputeKeyword_ComputeShader_LocalKeyword;
		public virtual RMethod REnableComputeKeyword_ComputeShader_LocalKeyword
		{
			get
			{
				if(r_REnableComputeKeyword_ComputeShader_LocalKeyword == null)
				{
					r_REnableComputeKeyword_ComputeShader_LocalKeyword = new(this, "EnableComputeKeyword", 0, typeof(UnityEngine.ComputeShader), typeof(UnityEngine.Rendering.LocalKeyword));
					r_REnableComputeKeyword_ComputeShader_LocalKeyword.SetBelong(this.instance);
				}
				return r_REnableComputeKeyword_ComputeShader_LocalKeyword;
			}
		}

		/// <summary>
		/// Void EnableKeyword(UnityEngine.Rendering.GlobalKeyword ByRef)
		/// </summary>
		protected RMethod r_REnableKeyword_In_GlobalKeyword;
		public virtual RMethod REnableKeyword_In_GlobalKeyword
		{
			get
			{
				if(r_REnableKeyword_In_GlobalKeyword == null)
				{
					r_REnableKeyword_In_GlobalKeyword = new(this, "EnableKeyword", 0, typeof(UnityEngine.Rendering.GlobalKeyword).MakeByRefType());
					r_REnableKeyword_In_GlobalKeyword.SetBelong(this.instance);
				}
				return r_REnableKeyword_In_GlobalKeyword;
			}
		}

		/// <summary>
		/// Void EnableKeyword(UnityEngine.Material, UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_REnableKeyword_Material_In_LocalKeyword;
		public virtual RMethod REnableKeyword_Material_In_LocalKeyword
		{
			get
			{
				if(r_REnableKeyword_Material_In_LocalKeyword == null)
				{
					r_REnableKeyword_Material_In_LocalKeyword = new(this, "EnableKeyword", 0, typeof(UnityEngine.Material), typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
					r_REnableKeyword_Material_In_LocalKeyword.SetBelong(this.instance);
				}
				return r_REnableKeyword_Material_In_LocalKeyword;
			}
		}

		/// <summary>
		/// Void EnableKeyword(UnityEngine.ComputeShader, UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_REnableKeyword_ComputeShader_In_LocalKeyword;
		public virtual RMethod REnableKeyword_ComputeShader_In_LocalKeyword
		{
			get
			{
				if(r_REnableKeyword_ComputeShader_In_LocalKeyword == null)
				{
					r_REnableKeyword_ComputeShader_In_LocalKeyword = new(this, "EnableKeyword", 0, typeof(UnityEngine.ComputeShader), typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
					r_REnableKeyword_ComputeShader_In_LocalKeyword.SetBelong(this.instance);
				}
				return r_REnableKeyword_ComputeShader_In_LocalKeyword;
			}
		}

		/// <summary>
		/// Void DisableShaderKeyword(System.String)
		/// </summary>
		protected RMethod r_RDisableShaderKeyword_String;
		public virtual RMethod RDisableShaderKeyword_String
		{
			get
			{
				if(r_RDisableShaderKeyword_String == null)
				{
					r_RDisableShaderKeyword_String = new(this, "DisableShaderKeyword", 0, typeof(System.String));
					r_RDisableShaderKeyword_String.SetBelong(this.instance);
				}
				return r_RDisableShaderKeyword_String;
			}
		}

		/// <summary>
		/// Void DisableGlobalKeyword(UnityEngine.Rendering.GlobalKeyword)
		/// </summary>
		protected RMethod r_RDisableGlobalKeyword_GlobalKeyword;
		public virtual RMethod RDisableGlobalKeyword_GlobalKeyword
		{
			get
			{
				if(r_RDisableGlobalKeyword_GlobalKeyword == null)
				{
					r_RDisableGlobalKeyword_GlobalKeyword = new(this, "DisableGlobalKeyword", 0, typeof(UnityEngine.Rendering.GlobalKeyword));
					r_RDisableGlobalKeyword_GlobalKeyword.SetBelong(this.instance);
				}
				return r_RDisableGlobalKeyword_GlobalKeyword;
			}
		}

		/// <summary>
		/// Void DisableMaterialKeyword(UnityEngine.Material, UnityEngine.Rendering.LocalKeyword)
		/// </summary>
		protected RMethod r_RDisableMaterialKeyword_Material_LocalKeyword;
		public virtual RMethod RDisableMaterialKeyword_Material_LocalKeyword
		{
			get
			{
				if(r_RDisableMaterialKeyword_Material_LocalKeyword == null)
				{
					r_RDisableMaterialKeyword_Material_LocalKeyword = new(this, "DisableMaterialKeyword", 0, typeof(UnityEngine.Material), typeof(UnityEngine.Rendering.LocalKeyword));
					r_RDisableMaterialKeyword_Material_LocalKeyword.SetBelong(this.instance);
				}
				return r_RDisableMaterialKeyword_Material_LocalKeyword;
			}
		}

		/// <summary>
		/// Void DisableComputeKeyword(UnityEngine.ComputeShader, UnityEngine.Rendering.LocalKeyword)
		/// </summary>
		protected RMethod r_RDisableComputeKeyword_ComputeShader_LocalKeyword;
		public virtual RMethod RDisableComputeKeyword_ComputeShader_LocalKeyword
		{
			get
			{
				if(r_RDisableComputeKeyword_ComputeShader_LocalKeyword == null)
				{
					r_RDisableComputeKeyword_ComputeShader_LocalKeyword = new(this, "DisableComputeKeyword", 0, typeof(UnityEngine.ComputeShader), typeof(UnityEngine.Rendering.LocalKeyword));
					r_RDisableComputeKeyword_ComputeShader_LocalKeyword.SetBelong(this.instance);
				}
				return r_RDisableComputeKeyword_ComputeShader_LocalKeyword;
			}
		}

		/// <summary>
		/// Void DisableKeyword(UnityEngine.Rendering.GlobalKeyword ByRef)
		/// </summary>
		protected RMethod r_RDisableKeyword_In_GlobalKeyword;
		public virtual RMethod RDisableKeyword_In_GlobalKeyword
		{
			get
			{
				if(r_RDisableKeyword_In_GlobalKeyword == null)
				{
					r_RDisableKeyword_In_GlobalKeyword = new(this, "DisableKeyword", 0, typeof(UnityEngine.Rendering.GlobalKeyword).MakeByRefType());
					r_RDisableKeyword_In_GlobalKeyword.SetBelong(this.instance);
				}
				return r_RDisableKeyword_In_GlobalKeyword;
			}
		}

		/// <summary>
		/// Void DisableKeyword(UnityEngine.Material, UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_RDisableKeyword_Material_In_LocalKeyword;
		public virtual RMethod RDisableKeyword_Material_In_LocalKeyword
		{
			get
			{
				if(r_RDisableKeyword_Material_In_LocalKeyword == null)
				{
					r_RDisableKeyword_Material_In_LocalKeyword = new(this, "DisableKeyword", 0, typeof(UnityEngine.Material), typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
					r_RDisableKeyword_Material_In_LocalKeyword.SetBelong(this.instance);
				}
				return r_RDisableKeyword_Material_In_LocalKeyword;
			}
		}

		/// <summary>
		/// Void DisableKeyword(UnityEngine.ComputeShader, UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_RDisableKeyword_ComputeShader_In_LocalKeyword;
		public virtual RMethod RDisableKeyword_ComputeShader_In_LocalKeyword
		{
			get
			{
				if(r_RDisableKeyword_ComputeShader_In_LocalKeyword == null)
				{
					r_RDisableKeyword_ComputeShader_In_LocalKeyword = new(this, "DisableKeyword", 0, typeof(UnityEngine.ComputeShader), typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
					r_RDisableKeyword_ComputeShader_In_LocalKeyword.SetBelong(this.instance);
				}
				return r_RDisableKeyword_ComputeShader_In_LocalKeyword;
			}
		}

		/// <summary>
		/// Void SetGlobalKeyword(UnityEngine.Rendering.GlobalKeyword, Boolean)
		/// </summary>
		protected RMethod r_RSetGlobalKeyword_GlobalKeyword_Boolean;
		public virtual RMethod RSetGlobalKeyword_GlobalKeyword_Boolean
		{
			get
			{
				if(r_RSetGlobalKeyword_GlobalKeyword_Boolean == null)
				{
					r_RSetGlobalKeyword_GlobalKeyword_Boolean = new(this, "SetGlobalKeyword", 0, typeof(UnityEngine.Rendering.GlobalKeyword), typeof(System.Boolean));
					r_RSetGlobalKeyword_GlobalKeyword_Boolean.SetBelong(this.instance);
				}
				return r_RSetGlobalKeyword_GlobalKeyword_Boolean;
			}
		}

		/// <summary>
		/// Void SetMaterialKeyword(UnityEngine.Material, UnityEngine.Rendering.LocalKeyword, Boolean)
		/// </summary>
		protected RMethod r_RSetMaterialKeyword_Material_LocalKeyword_Boolean;
		public virtual RMethod RSetMaterialKeyword_Material_LocalKeyword_Boolean
		{
			get
			{
				if(r_RSetMaterialKeyword_Material_LocalKeyword_Boolean == null)
				{
					r_RSetMaterialKeyword_Material_LocalKeyword_Boolean = new(this, "SetMaterialKeyword", 0, typeof(UnityEngine.Material), typeof(UnityEngine.Rendering.LocalKeyword), typeof(System.Boolean));
					r_RSetMaterialKeyword_Material_LocalKeyword_Boolean.SetBelong(this.instance);
				}
				return r_RSetMaterialKeyword_Material_LocalKeyword_Boolean;
			}
		}

		/// <summary>
		/// Void SetComputeKeyword(UnityEngine.ComputeShader, UnityEngine.Rendering.LocalKeyword, Boolean)
		/// </summary>
		protected RMethod r_RSetComputeKeyword_ComputeShader_LocalKeyword_Boolean;
		public virtual RMethod RSetComputeKeyword_ComputeShader_LocalKeyword_Boolean
		{
			get
			{
				if(r_RSetComputeKeyword_ComputeShader_LocalKeyword_Boolean == null)
				{
					r_RSetComputeKeyword_ComputeShader_LocalKeyword_Boolean = new(this, "SetComputeKeyword", 0, typeof(UnityEngine.ComputeShader), typeof(UnityEngine.Rendering.LocalKeyword), typeof(System.Boolean));
					r_RSetComputeKeyword_ComputeShader_LocalKeyword_Boolean.SetBelong(this.instance);
				}
				return r_RSetComputeKeyword_ComputeShader_LocalKeyword_Boolean;
			}
		}

		/// <summary>
		/// Void SetKeyword(UnityEngine.Rendering.GlobalKeyword ByRef, Boolean)
		/// </summary>
		protected RMethod r_RSetKeyword_In_GlobalKeyword_Boolean;
		public virtual RMethod RSetKeyword_In_GlobalKeyword_Boolean
		{
			get
			{
				if(r_RSetKeyword_In_GlobalKeyword_Boolean == null)
				{
					r_RSetKeyword_In_GlobalKeyword_Boolean = new(this, "SetKeyword", 0, typeof(UnityEngine.Rendering.GlobalKeyword).MakeByRefType(), typeof(System.Boolean));
					r_RSetKeyword_In_GlobalKeyword_Boolean.SetBelong(this.instance);
				}
				return r_RSetKeyword_In_GlobalKeyword_Boolean;
			}
		}

		/// <summary>
		/// Void SetKeyword(UnityEngine.Material, UnityEngine.Rendering.LocalKeyword ByRef, Boolean)
		/// </summary>
		protected RMethod r_RSetKeyword_Material_In_LocalKeyword_Boolean;
		public virtual RMethod RSetKeyword_Material_In_LocalKeyword_Boolean
		{
			get
			{
				if(r_RSetKeyword_Material_In_LocalKeyword_Boolean == null)
				{
					r_RSetKeyword_Material_In_LocalKeyword_Boolean = new(this, "SetKeyword", 0, typeof(UnityEngine.Material), typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType(), typeof(System.Boolean));
					r_RSetKeyword_Material_In_LocalKeyword_Boolean.SetBelong(this.instance);
				}
				return r_RSetKeyword_Material_In_LocalKeyword_Boolean;
			}
		}

		/// <summary>
		/// Void SetKeyword(UnityEngine.ComputeShader, UnityEngine.Rendering.LocalKeyword ByRef, Boolean)
		/// </summary>
		protected RMethod r_RSetKeyword_ComputeShader_In_LocalKeyword_Boolean;
		public virtual RMethod RSetKeyword_ComputeShader_In_LocalKeyword_Boolean
		{
			get
			{
				if(r_RSetKeyword_ComputeShader_In_LocalKeyword_Boolean == null)
				{
					r_RSetKeyword_ComputeShader_In_LocalKeyword_Boolean = new(this, "SetKeyword", 0, typeof(UnityEngine.ComputeShader), typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType(), typeof(System.Boolean));
					r_RSetKeyword_ComputeShader_In_LocalKeyword_Boolean.SetBelong(this.instance);
				}
				return r_RSetKeyword_ComputeShader_In_LocalKeyword_Boolean;
			}
		}

		/// <summary>
		/// Void SetViewMatrix(UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_RSetViewMatrix_Matrix4x4;
		public virtual RMethod RSetViewMatrix_Matrix4x4
		{
			get
			{
				if(r_RSetViewMatrix_Matrix4x4 == null)
				{
					r_RSetViewMatrix_Matrix4x4 = new(this, "SetViewMatrix", 0, typeof(UnityEngine.Matrix4x4));
					r_RSetViewMatrix_Matrix4x4.SetBelong(this.instance);
				}
				return r_RSetViewMatrix_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetProjectionMatrix(UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_RSetProjectionMatrix_Matrix4x4;
		public virtual RMethod RSetProjectionMatrix_Matrix4x4
		{
			get
			{
				if(r_RSetProjectionMatrix_Matrix4x4 == null)
				{
					r_RSetProjectionMatrix_Matrix4x4 = new(this, "SetProjectionMatrix", 0, typeof(UnityEngine.Matrix4x4));
					r_RSetProjectionMatrix_Matrix4x4.SetBelong(this.instance);
				}
				return r_RSetProjectionMatrix_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetViewProjectionMatrices(UnityEngine.Matrix4x4, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_RSetViewProjectionMatrices_Matrix4x4_Matrix4x4;
		public virtual RMethod RSetViewProjectionMatrices_Matrix4x4_Matrix4x4
		{
			get
			{
				if(r_RSetViewProjectionMatrices_Matrix4x4_Matrix4x4 == null)
				{
					r_RSetViewProjectionMatrices_Matrix4x4_Matrix4x4 = new(this, "SetViewProjectionMatrices", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Matrix4x4));
					r_RSetViewProjectionMatrices_Matrix4x4_Matrix4x4.SetBelong(this.instance);
				}
				return r_RSetViewProjectionMatrices_Matrix4x4_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetGlobalDepthBias(Single, Single)
		/// </summary>
		protected RMethod r_RSetGlobalDepthBias_Single_Single;
		public virtual RMethod RSetGlobalDepthBias_Single_Single
		{
			get
			{
				if(r_RSetGlobalDepthBias_Single_Single == null)
				{
					r_RSetGlobalDepthBias_Single_Single = new(this, "SetGlobalDepthBias", 0, typeof(System.Single), typeof(System.Single));
					r_RSetGlobalDepthBias_Single_Single.SetBelong(this.instance);
				}
				return r_RSetGlobalDepthBias_Single_Single;
			}
		}

		/// <summary>
		/// Void SetExecutionFlags(UnityEngine.Rendering.CommandBufferExecutionFlags)
		/// </summary>
		protected RMethod r_RSetExecutionFlags_CommandBufferExecutionFlags;
		public virtual RMethod RSetExecutionFlags_CommandBufferExecutionFlags
		{
			get
			{
				if(r_RSetExecutionFlags_CommandBufferExecutionFlags == null)
				{
					r_RSetExecutionFlags_CommandBufferExecutionFlags = new(this, "SetExecutionFlags", 0, typeof(UnityEngine.Rendering.CommandBufferExecutionFlags));
					r_RSetExecutionFlags_CommandBufferExecutionFlags.SetBelong(this.instance);
				}
				return r_RSetExecutionFlags_CommandBufferExecutionFlags;
			}
		}

		/// <summary>
		/// Boolean ValidateAgainstExecutionFlags(UnityEngine.Rendering.CommandBufferExecutionFlags, UnityEngine.Rendering.CommandBufferExecutionFlags)
		/// </summary>
		protected RMethod r_RValidateAgainstExecutionFlags_CommandBufferExecutionFlags_CommandBufferExecutionFlags;
		public virtual RMethod RValidateAgainstExecutionFlags_CommandBufferExecutionFlags_CommandBufferExecutionFlags
		{
			get
			{
				if(r_RValidateAgainstExecutionFlags_CommandBufferExecutionFlags_CommandBufferExecutionFlags == null)
				{
					r_RValidateAgainstExecutionFlags_CommandBufferExecutionFlags_CommandBufferExecutionFlags = new(this, "ValidateAgainstExecutionFlags", 0, typeof(UnityEngine.Rendering.CommandBufferExecutionFlags), typeof(UnityEngine.Rendering.CommandBufferExecutionFlags));
					r_RValidateAgainstExecutionFlags_CommandBufferExecutionFlags_CommandBufferExecutionFlags.SetBelong(this.instance);
				}
				return r_RValidateAgainstExecutionFlags_CommandBufferExecutionFlags_CommandBufferExecutionFlags;
			}
		}

		/// <summary>
		/// Void SetGlobalFloatArrayListImpl(Int32, System.Object)
		/// </summary>
		protected RMethod r_RSetGlobalFloatArrayListImpl_Int32_Object;
		public virtual RMethod RSetGlobalFloatArrayListImpl_Int32_Object
		{
			get
			{
				if(r_RSetGlobalFloatArrayListImpl_Int32_Object == null)
				{
					r_RSetGlobalFloatArrayListImpl_Int32_Object = new(this, "SetGlobalFloatArrayListImpl", 0, typeof(System.Int32), typeof(System.Object));
					r_RSetGlobalFloatArrayListImpl_Int32_Object.SetBelong(this.instance);
				}
				return r_RSetGlobalFloatArrayListImpl_Int32_Object;
			}
		}

		/// <summary>
		/// Void SetGlobalVectorArrayListImpl(Int32, System.Object)
		/// </summary>
		protected RMethod r_RSetGlobalVectorArrayListImpl_Int32_Object;
		public virtual RMethod RSetGlobalVectorArrayListImpl_Int32_Object
		{
			get
			{
				if(r_RSetGlobalVectorArrayListImpl_Int32_Object == null)
				{
					r_RSetGlobalVectorArrayListImpl_Int32_Object = new(this, "SetGlobalVectorArrayListImpl", 0, typeof(System.Int32), typeof(System.Object));
					r_RSetGlobalVectorArrayListImpl_Int32_Object.SetBelong(this.instance);
				}
				return r_RSetGlobalVectorArrayListImpl_Int32_Object;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrixArrayListImpl(Int32, System.Object)
		/// </summary>
		protected RMethod r_RSetGlobalMatrixArrayListImpl_Int32_Object;
		public virtual RMethod RSetGlobalMatrixArrayListImpl_Int32_Object
		{
			get
			{
				if(r_RSetGlobalMatrixArrayListImpl_Int32_Object == null)
				{
					r_RSetGlobalMatrixArrayListImpl_Int32_Object = new(this, "SetGlobalMatrixArrayListImpl", 0, typeof(System.Int32), typeof(System.Object));
					r_RSetGlobalMatrixArrayListImpl_Int32_Object.SetBelong(this.instance);
				}
				return r_RSetGlobalMatrixArrayListImpl_Int32_Object;
			}
		}

		/// <summary>
		/// Void SetGlobalFloatArray(Int32, Single[])
		/// </summary>
		protected RMethod r_RSetGlobalFloatArray_Int32_SingleArray;
		public virtual RMethod RSetGlobalFloatArray_Int32_SingleArray
		{
			get
			{
				if(r_RSetGlobalFloatArray_Int32_SingleArray == null)
				{
					r_RSetGlobalFloatArray_Int32_SingleArray = new(this, "SetGlobalFloatArray", 0, typeof(System.Int32), typeof(System.Single).MakeArrayType());
					r_RSetGlobalFloatArray_Int32_SingleArray.SetBelong(this.instance);
				}
				return r_RSetGlobalFloatArray_Int32_SingleArray;
			}
		}

		/// <summary>
		/// Void SetGlobalVectorArray(Int32, UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_RSetGlobalVectorArray_Int32_Vector4Array;
		public virtual RMethod RSetGlobalVectorArray_Int32_Vector4Array
		{
			get
			{
				if(r_RSetGlobalVectorArray_Int32_Vector4Array == null)
				{
					r_RSetGlobalVectorArray_Int32_Vector4Array = new(this, "SetGlobalVectorArray", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType());
					r_RSetGlobalVectorArray_Int32_Vector4Array.SetBelong(this.instance);
				}
				return r_RSetGlobalVectorArray_Int32_Vector4Array;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrixArray(Int32, UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_RSetGlobalMatrixArray_Int32_Matrix4x4Array;
		public virtual RMethod RSetGlobalMatrixArray_Int32_Matrix4x4Array
		{
			get
			{
				if(r_RSetGlobalMatrixArray_Int32_Matrix4x4Array == null)
				{
					r_RSetGlobalMatrixArray_Int32_Matrix4x4Array = new(this, "SetGlobalMatrixArray", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType());
					r_RSetGlobalMatrixArray_Int32_Matrix4x4Array.SetBelong(this.instance);
				}
				return r_RSetGlobalMatrixArray_Int32_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Void SetLateLatchProjectionMatrices(UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_RSetLateLatchProjectionMatrices_Matrix4x4Array;
		public virtual RMethod RSetLateLatchProjectionMatrices_Matrix4x4Array
		{
			get
			{
				if(r_RSetLateLatchProjectionMatrices_Matrix4x4Array == null)
				{
					r_RSetLateLatchProjectionMatrices_Matrix4x4Array = new(this, "SetLateLatchProjectionMatrices", 0, typeof(UnityEngine.Matrix4x4).MakeArrayType());
					r_RSetLateLatchProjectionMatrices_Matrix4x4Array.SetBelong(this.instance);
				}
				return r_RSetLateLatchProjectionMatrices_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Void MarkLateLatchMatrixShaderPropertyID(UnityEngine.Rendering.CameraLateLatchMatrixType, Int32)
		/// </summary>
		protected RMethod r_RMarkLateLatchMatrixShaderPropertyID_CameraLateLatchMatrixType_Int32;
		public virtual RMethod RMarkLateLatchMatrixShaderPropertyID_CameraLateLatchMatrixType_Int32
		{
			get
			{
				if(r_RMarkLateLatchMatrixShaderPropertyID_CameraLateLatchMatrixType_Int32 == null)
				{
					r_RMarkLateLatchMatrixShaderPropertyID_CameraLateLatchMatrixType_Int32 = new(this, "MarkLateLatchMatrixShaderPropertyID", 0, typeof(UnityEngine.Rendering.CameraLateLatchMatrixType), typeof(System.Int32));
					r_RMarkLateLatchMatrixShaderPropertyID_CameraLateLatchMatrixType_Int32.SetBelong(this.instance);
				}
				return r_RMarkLateLatchMatrixShaderPropertyID_CameraLateLatchMatrixType_Int32;
			}
		}

		/// <summary>
		/// Void UnmarkLateLatchMatrix(UnityEngine.Rendering.CameraLateLatchMatrixType)
		/// </summary>
		protected RMethod r_RUnmarkLateLatchMatrix_CameraLateLatchMatrixType;
		public virtual RMethod RUnmarkLateLatchMatrix_CameraLateLatchMatrixType
		{
			get
			{
				if(r_RUnmarkLateLatchMatrix_CameraLateLatchMatrixType == null)
				{
					r_RUnmarkLateLatchMatrix_CameraLateLatchMatrixType = new(this, "UnmarkLateLatchMatrix", 0, typeof(UnityEngine.Rendering.CameraLateLatchMatrixType));
					r_RUnmarkLateLatchMatrix_CameraLateLatchMatrixType.SetBelong(this.instance);
				}
				return r_RUnmarkLateLatchMatrix_CameraLateLatchMatrixType;
			}
		}

		/// <summary>
		/// Void SetGlobalTexture_Impl(Int32, UnityEngine.Rendering.RenderTargetIdentifier ByRef, UnityEngine.Rendering.RenderTextureSubElement)
		/// </summary>
		protected RMethod r_RSetGlobalTexture_Impl_Int32_Ref_RenderTargetIdentifier_RenderTextureSubElement;
		public virtual RMethod RSetGlobalTexture_Impl_Int32_Ref_RenderTargetIdentifier_RenderTextureSubElement
		{
			get
			{
				if(r_RSetGlobalTexture_Impl_Int32_Ref_RenderTargetIdentifier_RenderTextureSubElement == null)
				{
					r_RSetGlobalTexture_Impl_Int32_Ref_RenderTargetIdentifier_RenderTextureSubElement = new(this, "SetGlobalTexture_Impl", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(UnityEngine.Rendering.RenderTextureSubElement));
					r_RSetGlobalTexture_Impl_Int32_Ref_RenderTargetIdentifier_RenderTextureSubElement.SetBelong(this.instance);
				}
				return r_RSetGlobalTexture_Impl_Int32_Ref_RenderTargetIdentifier_RenderTextureSubElement;
			}
		}

		/// <summary>
		/// Void SetGlobalBufferInternal(Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_RSetGlobalBufferInternal_Int32_ComputeBuffer;
		public virtual RMethod RSetGlobalBufferInternal_Int32_ComputeBuffer
		{
			get
			{
				if(r_RSetGlobalBufferInternal_Int32_ComputeBuffer == null)
				{
					r_RSetGlobalBufferInternal_Int32_ComputeBuffer = new(this, "SetGlobalBufferInternal", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
					r_RSetGlobalBufferInternal_Int32_ComputeBuffer.SetBelong(this.instance);
				}
				return r_RSetGlobalBufferInternal_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetGlobalGraphicsBufferInternal(Int32, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_RSetGlobalGraphicsBufferInternal_Int32_GraphicsBuffer;
		public virtual RMethod RSetGlobalGraphicsBufferInternal_Int32_GraphicsBuffer
		{
			get
			{
				if(r_RSetGlobalGraphicsBufferInternal_Int32_GraphicsBuffer == null)
				{
					r_RSetGlobalGraphicsBufferInternal_Int32_GraphicsBuffer = new(this, "SetGlobalGraphicsBufferInternal", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer));
					r_RSetGlobalGraphicsBufferInternal_Int32_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_RSetGlobalGraphicsBufferInternal_Int32_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetShadowSamplingMode_Impl(UnityEngine.Rendering.RenderTargetIdentifier ByRef, UnityEngine.Rendering.ShadowSamplingMode)
		/// </summary>
		protected RMethod r_RSetShadowSamplingMode_Impl_Ref_RenderTargetIdentifier_ShadowSamplingMode;
		public virtual RMethod RSetShadowSamplingMode_Impl_Ref_RenderTargetIdentifier_ShadowSamplingMode
		{
			get
			{
				if(r_RSetShadowSamplingMode_Impl_Ref_RenderTargetIdentifier_ShadowSamplingMode == null)
				{
					r_RSetShadowSamplingMode_Impl_Ref_RenderTargetIdentifier_ShadowSamplingMode = new(this, "SetShadowSamplingMode_Impl", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(UnityEngine.Rendering.ShadowSamplingMode));
					r_RSetShadowSamplingMode_Impl_Ref_RenderTargetIdentifier_ShadowSamplingMode.SetBelong(this.instance);
				}
				return r_RSetShadowSamplingMode_Impl_Ref_RenderTargetIdentifier_ShadowSamplingMode;
			}
		}

		/// <summary>
		/// Void IssuePluginEventInternal(IntPtr, Int32)
		/// </summary>
		protected RMethod r_RIssuePluginEventInternal_IntPtr_Int32;
		public virtual RMethod RIssuePluginEventInternal_IntPtr_Int32
		{
			get
			{
				if(r_RIssuePluginEventInternal_IntPtr_Int32 == null)
				{
					r_RIssuePluginEventInternal_IntPtr_Int32 = new(this, "IssuePluginEventInternal", 0, typeof(System.IntPtr), typeof(System.Int32));
					r_RIssuePluginEventInternal_IntPtr_Int32.SetBelong(this.instance);
				}
				return r_RIssuePluginEventInternal_IntPtr_Int32;
			}
		}

		/// <summary>
		/// Void BeginSample(System.String)
		/// </summary>
		protected RMethod r_RBeginSample_String;
		public virtual RMethod RBeginSample_String
		{
			get
			{
				if(r_RBeginSample_String == null)
				{
					r_RBeginSample_String = new(this, "BeginSample", 0, typeof(System.String));
					r_RBeginSample_String.SetBelong(this.instance);
				}
				return r_RBeginSample_String;
			}
		}

		/// <summary>
		/// Void EndSample(System.String)
		/// </summary>
		protected RMethod r_REndSample_String;
		public virtual RMethod REndSample_String
		{
			get
			{
				if(r_REndSample_String == null)
				{
					r_REndSample_String = new(this, "EndSample", 0, typeof(System.String));
					r_REndSample_String.SetBelong(this.instance);
				}
				return r_REndSample_String;
			}
		}

		/// <summary>
		/// Void BeginSample(UnityEngine.Profiling.CustomSampler)
		/// </summary>
		protected RMethod r_RBeginSample_CustomSampler;
		public virtual RMethod RBeginSample_CustomSampler
		{
			get
			{
				if(r_RBeginSample_CustomSampler == null)
				{
					r_RBeginSample_CustomSampler = new(this, "BeginSample", 0, typeof(UnityEngine.Profiling.CustomSampler));
					r_RBeginSample_CustomSampler.SetBelong(this.instance);
				}
				return r_RBeginSample_CustomSampler;
			}
		}

		/// <summary>
		/// Void EndSample(UnityEngine.Profiling.CustomSampler)
		/// </summary>
		protected RMethod r_REndSample_CustomSampler;
		public virtual RMethod REndSample_CustomSampler
		{
			get
			{
				if(r_REndSample_CustomSampler == null)
				{
					r_REndSample_CustomSampler = new(this, "EndSample", 0, typeof(UnityEngine.Profiling.CustomSampler));
					r_REndSample_CustomSampler.SetBelong(this.instance);
				}
				return r_REndSample_CustomSampler;
			}
		}

		/// <summary>
		/// Void BeginSample_CustomSampler(UnityEngine.Profiling.CustomSampler)
		/// </summary>
		protected RMethod r_RBeginSample_CustomSampler_CustomSampler;
		public virtual RMethod RBeginSample_CustomSampler_CustomSampler
		{
			get
			{
				if(r_RBeginSample_CustomSampler_CustomSampler == null)
				{
					r_RBeginSample_CustomSampler_CustomSampler = new(this, "BeginSample_CustomSampler", 0, typeof(UnityEngine.Profiling.CustomSampler));
					r_RBeginSample_CustomSampler_CustomSampler.SetBelong(this.instance);
				}
				return r_RBeginSample_CustomSampler_CustomSampler;
			}
		}

		/// <summary>
		/// Void EndSample_CustomSampler(UnityEngine.Profiling.CustomSampler)
		/// </summary>
		protected RMethod r_REndSample_CustomSampler_CustomSampler;
		public virtual RMethod REndSample_CustomSampler_CustomSampler
		{
			get
			{
				if(r_REndSample_CustomSampler_CustomSampler == null)
				{
					r_REndSample_CustomSampler_CustomSampler = new(this, "EndSample_CustomSampler", 0, typeof(UnityEngine.Profiling.CustomSampler));
					r_REndSample_CustomSampler_CustomSampler.SetBelong(this.instance);
				}
				return r_REndSample_CustomSampler_CustomSampler;
			}
		}

		/// <summary>
		/// Void BeginSample(Unity.Profiling.ProfilerMarker)
		/// </summary>
		protected RMethod r_RBeginSample_ProfilerMarker;
		public virtual RMethod RBeginSample_ProfilerMarker
		{
			get
			{
				if(r_RBeginSample_ProfilerMarker == null)
				{
					r_RBeginSample_ProfilerMarker = new(this, "BeginSample", 0, typeof(Unity.Profiling.ProfilerMarker));
					r_RBeginSample_ProfilerMarker.SetBelong(this.instance);
				}
				return r_RBeginSample_ProfilerMarker;
			}
		}

		/// <summary>
		/// Void EndSample(Unity.Profiling.ProfilerMarker)
		/// </summary>
		protected RMethod r_REndSample_ProfilerMarker;
		public virtual RMethod REndSample_ProfilerMarker
		{
			get
			{
				if(r_REndSample_ProfilerMarker == null)
				{
					r_REndSample_ProfilerMarker = new(this, "EndSample", 0, typeof(Unity.Profiling.ProfilerMarker));
					r_REndSample_ProfilerMarker.SetBelong(this.instance);
				}
				return r_REndSample_ProfilerMarker;
			}
		}

		/// <summary>
		/// Void BeginSample_ProfilerMarker(IntPtr)
		/// </summary>
		protected RMethod r_RBeginSample_ProfilerMarker_IntPtr;
		public virtual RMethod RBeginSample_ProfilerMarker_IntPtr
		{
			get
			{
				if(r_RBeginSample_ProfilerMarker_IntPtr == null)
				{
					r_RBeginSample_ProfilerMarker_IntPtr = new(this, "BeginSample_ProfilerMarker", 0, typeof(System.IntPtr));
					r_RBeginSample_ProfilerMarker_IntPtr.SetBelong(this.instance);
				}
				return r_RBeginSample_ProfilerMarker_IntPtr;
			}
		}

		/// <summary>
		/// Void EndSample_ProfilerMarker(IntPtr)
		/// </summary>
		protected RMethod r_REndSample_ProfilerMarker_IntPtr;
		public virtual RMethod REndSample_ProfilerMarker_IntPtr
		{
			get
			{
				if(r_REndSample_ProfilerMarker_IntPtr == null)
				{
					r_REndSample_ProfilerMarker_IntPtr = new(this, "EndSample_ProfilerMarker", 0, typeof(System.IntPtr));
					r_REndSample_ProfilerMarker_IntPtr.SetBelong(this.instance);
				}
				return r_REndSample_ProfilerMarker_IntPtr;
			}
		}

		/// <summary>
		/// Void IssuePluginEventAndDataInternal(IntPtr, Int32, IntPtr)
		/// </summary>
		protected RMethod r_RIssuePluginEventAndDataInternal_IntPtr_Int32_IntPtr;
		public virtual RMethod RIssuePluginEventAndDataInternal_IntPtr_Int32_IntPtr
		{
			get
			{
				if(r_RIssuePluginEventAndDataInternal_IntPtr_Int32_IntPtr == null)
				{
					r_RIssuePluginEventAndDataInternal_IntPtr_Int32_IntPtr = new(this, "IssuePluginEventAndDataInternal", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.IntPtr));
					r_RIssuePluginEventAndDataInternal_IntPtr_Int32_IntPtr.SetBelong(this.instance);
				}
				return r_RIssuePluginEventAndDataInternal_IntPtr_Int32_IntPtr;
			}
		}

		/// <summary>
		/// Void IssuePluginEventAndDataInternalWithFlags(IntPtr, Int32, UnityEngine.Rendering.CustomMarkerCallbackFlags, IntPtr)
		/// </summary>
		protected RMethod r_RIssuePluginEventAndDataInternalWithFlags_IntPtr_Int32_CustomMarkerCallbackFlags_IntPtr;
		public virtual RMethod RIssuePluginEventAndDataInternalWithFlags_IntPtr_Int32_CustomMarkerCallbackFlags_IntPtr
		{
			get
			{
				if(r_RIssuePluginEventAndDataInternalWithFlags_IntPtr_Int32_CustomMarkerCallbackFlags_IntPtr == null)
				{
					r_RIssuePluginEventAndDataInternalWithFlags_IntPtr_Int32_CustomMarkerCallbackFlags_IntPtr = new(this, "IssuePluginEventAndDataInternalWithFlags", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(UnityEngine.Rendering.CustomMarkerCallbackFlags), typeof(System.IntPtr));
					r_RIssuePluginEventAndDataInternalWithFlags_IntPtr_Int32_CustomMarkerCallbackFlags_IntPtr.SetBelong(this.instance);
				}
				return r_RIssuePluginEventAndDataInternalWithFlags_IntPtr_Int32_CustomMarkerCallbackFlags_IntPtr;
			}
		}

		/// <summary>
		/// Void IssuePluginCustomBlitInternal(IntPtr, UInt32, UnityEngine.Rendering.RenderTargetIdentifier ByRef, UnityEngine.Rendering.RenderTargetIdentifier ByRef, UInt32, UInt32)
		/// </summary>
		protected RMethod r_RIssuePluginCustomBlitInternal_IntPtr_UInt32_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_UInt32_UInt32;
		public virtual RMethod RIssuePluginCustomBlitInternal_IntPtr_UInt32_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_UInt32_UInt32
		{
			get
			{
				if(r_RIssuePluginCustomBlitInternal_IntPtr_UInt32_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_UInt32_UInt32 == null)
				{
					r_RIssuePluginCustomBlitInternal_IntPtr_UInt32_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_UInt32_UInt32 = new(this, "IssuePluginCustomBlitInternal", 0, typeof(System.IntPtr), typeof(System.UInt32), typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(System.UInt32), typeof(System.UInt32));
					r_RIssuePluginCustomBlitInternal_IntPtr_UInt32_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_UInt32_UInt32.SetBelong(this.instance);
				}
				return r_RIssuePluginCustomBlitInternal_IntPtr_UInt32_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_UInt32_UInt32;
			}
		}

		/// <summary>
		/// Void IssuePluginCustomTextureUpdateInternal(IntPtr, UnityEngine.Texture, UInt32, Boolean)
		/// </summary>
		protected RMethod r_RIssuePluginCustomTextureUpdateInternal_IntPtr_Texture_UInt32_Boolean;
		public virtual RMethod RIssuePluginCustomTextureUpdateInternal_IntPtr_Texture_UInt32_Boolean
		{
			get
			{
				if(r_RIssuePluginCustomTextureUpdateInternal_IntPtr_Texture_UInt32_Boolean == null)
				{
					r_RIssuePluginCustomTextureUpdateInternal_IntPtr_Texture_UInt32_Boolean = new(this, "IssuePluginCustomTextureUpdateInternal", 0, typeof(System.IntPtr), typeof(UnityEngine.Texture), typeof(System.UInt32), typeof(System.Boolean));
					r_RIssuePluginCustomTextureUpdateInternal_IntPtr_Texture_UInt32_Boolean.SetBelong(this.instance);
				}
				return r_RIssuePluginCustomTextureUpdateInternal_IntPtr_Texture_UInt32_Boolean;
			}
		}

		/// <summary>
		/// Void SetGlobalConstantBufferInternal(UnityEngine.ComputeBuffer, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetGlobalConstantBufferInternal_ComputeBuffer_Int32_Int32_Int32;
		public virtual RMethod RSetGlobalConstantBufferInternal_ComputeBuffer_Int32_Int32_Int32
		{
			get
			{
				if(r_RSetGlobalConstantBufferInternal_ComputeBuffer_Int32_Int32_Int32 == null)
				{
					r_RSetGlobalConstantBufferInternal_ComputeBuffer_Int32_Int32_Int32 = new(this, "SetGlobalConstantBufferInternal", 0, typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RSetGlobalConstantBufferInternal_ComputeBuffer_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetGlobalConstantBufferInternal_ComputeBuffer_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalConstantGraphicsBufferInternal(UnityEngine.GraphicsBuffer, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetGlobalConstantGraphicsBufferInternal_GraphicsBuffer_Int32_Int32_Int32;
		public virtual RMethod RSetGlobalConstantGraphicsBufferInternal_GraphicsBuffer_Int32_Int32_Int32
		{
			get
			{
				if(r_RSetGlobalConstantGraphicsBufferInternal_GraphicsBuffer_Int32_Int32_Int32 == null)
				{
					r_RSetGlobalConstantGraphicsBufferInternal_GraphicsBuffer_Int32_Int32_Int32 = new(this, "SetGlobalConstantGraphicsBufferInternal", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RSetGlobalConstantGraphicsBufferInternal_GraphicsBuffer_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetGlobalConstantGraphicsBufferInternal_GraphicsBuffer_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void IncrementUpdateCount(UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_RIncrementUpdateCount_RenderTargetIdentifier;
		public virtual RMethod RIncrementUpdateCount_RenderTargetIdentifier
		{
			get
			{
				if(r_RIncrementUpdateCount_RenderTargetIdentifier == null)
				{
					r_RIncrementUpdateCount_RenderTargetIdentifier = new(this, "IncrementUpdateCount", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier));
					r_RIncrementUpdateCount_RenderTargetIdentifier.SetBelong(this.instance);
				}
				return r_RIncrementUpdateCount_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void SetInstanceMultiplier(UInt32)
		/// </summary>
		protected RMethod r_RSetInstanceMultiplier_UInt32;
		public virtual RMethod RSetInstanceMultiplier_UInt32
		{
			get
			{
				if(r_RSetInstanceMultiplier_UInt32 == null)
				{
					r_RSetInstanceMultiplier_UInt32 = new(this, "SetInstanceMultiplier", 0, typeof(System.UInt32));
					r_RSetInstanceMultiplier_UInt32.SetBelong(this.instance);
				}
				return r_RSetInstanceMultiplier_UInt32;
			}
		}

		/// <summary>
		/// Void SetFoveatedRenderingMode(UnityEngine.Rendering.FoveatedRenderingMode)
		/// </summary>
		protected RMethod r_RSetFoveatedRenderingMode_FoveatedRenderingMode;
		public virtual RMethod RSetFoveatedRenderingMode_FoveatedRenderingMode
		{
			get
			{
				if(r_RSetFoveatedRenderingMode_FoveatedRenderingMode == null)
				{
					r_RSetFoveatedRenderingMode_FoveatedRenderingMode = new(this, "SetFoveatedRenderingMode", 0, typeof(UnityEngine.Rendering.FoveatedRenderingMode));
					r_RSetFoveatedRenderingMode_FoveatedRenderingMode.SetBelong(this.instance);
				}
				return r_RSetFoveatedRenderingMode_FoveatedRenderingMode;
			}
		}

		/// <summary>
		/// Void ConfigureFoveatedRendering(IntPtr)
		/// </summary>
		protected RMethod r_RConfigureFoveatedRendering_IntPtr;
		public virtual RMethod RConfigureFoveatedRendering_IntPtr
		{
			get
			{
				if(r_RConfigureFoveatedRendering_IntPtr == null)
				{
					r_RConfigureFoveatedRendering_IntPtr = new(this, "ConfigureFoveatedRendering", 0, typeof(System.IntPtr));
					r_RConfigureFoveatedRendering_IntPtr.SetBelong(this.instance);
				}
				return r_RConfigureFoveatedRendering_IntPtr;
			}
		}

		/// <summary>
		/// Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_RSetRenderTarget_RenderTargetIdentifier;
		public virtual RMethod RSetRenderTarget_RenderTargetIdentifier
		{
			get
			{
				if(r_RSetRenderTarget_RenderTargetIdentifier == null)
				{
					r_RSetRenderTarget_RenderTargetIdentifier = new(this, "SetRenderTarget", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier));
					r_RSetRenderTarget_RenderTargetIdentifier.SetBelong(this.instance);
				}
				return r_RSetRenderTarget_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction)
		/// </summary>
		protected RMethod r_RSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction;
		public virtual RMethod RSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction
		{
			get
			{
				if(r_RSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction == null)
				{
					r_RSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction = new(this, "SetRenderTarget", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction));
					r_RSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction.SetBelong(this.instance);
				}
				return r_RSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction;
			}
		}

		/// <summary>
		/// Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction)
		/// </summary>
		protected RMethod r_RSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction;
		public virtual RMethod RSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction
		{
			get
			{
				if(r_RSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction == null)
				{
					r_RSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction = new(this, "SetRenderTarget", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction));
					r_RSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction.SetBelong(this.instance);
				}
				return r_RSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction;
			}
		}

		/// <summary>
		/// Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier, Int32)
		/// </summary>
		protected RMethod r_RSetRenderTarget_RenderTargetIdentifier_Int32;
		public virtual RMethod RSetRenderTarget_RenderTargetIdentifier_Int32
		{
			get
			{
				if(r_RSetRenderTarget_RenderTargetIdentifier_Int32 == null)
				{
					r_RSetRenderTarget_RenderTargetIdentifier_Int32 = new(this, "SetRenderTarget", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32));
					r_RSetRenderTarget_RenderTargetIdentifier_Int32.SetBelong(this.instance);
				}
				return r_RSetRenderTarget_RenderTargetIdentifier_Int32;
			}
		}

		/// <summary>
		/// Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier, Int32, UnityEngine.CubemapFace)
		/// </summary>
		protected RMethod r_RSetRenderTarget_RenderTargetIdentifier_Int32_CubemapFace;
		public virtual RMethod RSetRenderTarget_RenderTargetIdentifier_Int32_CubemapFace
		{
			get
			{
				if(r_RSetRenderTarget_RenderTargetIdentifier_Int32_CubemapFace == null)
				{
					r_RSetRenderTarget_RenderTargetIdentifier_Int32_CubemapFace = new(this, "SetRenderTarget", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(UnityEngine.CubemapFace));
					r_RSetRenderTarget_RenderTargetIdentifier_Int32_CubemapFace.SetBelong(this.instance);
				}
				return r_RSetRenderTarget_RenderTargetIdentifier_Int32_CubemapFace;
			}
		}

		/// <summary>
		/// Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier, Int32, UnityEngine.CubemapFace, Int32)
		/// </summary>
		protected RMethod r_RSetRenderTarget_RenderTargetIdentifier_Int32_CubemapFace_Int32;
		public virtual RMethod RSetRenderTarget_RenderTargetIdentifier_Int32_CubemapFace_Int32
		{
			get
			{
				if(r_RSetRenderTarget_RenderTargetIdentifier_Int32_CubemapFace_Int32 == null)
				{
					r_RSetRenderTarget_RenderTargetIdentifier_Int32_CubemapFace_Int32 = new(this, "SetRenderTarget", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(UnityEngine.CubemapFace), typeof(System.Int32));
					r_RSetRenderTarget_RenderTargetIdentifier_Int32_CubemapFace_Int32.SetBelong(this.instance);
				}
				return r_RSetRenderTarget_RenderTargetIdentifier_Int32_CubemapFace_Int32;
			}
		}

		/// <summary>
		/// Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_RSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier;
		public virtual RMethod RSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier
		{
			get
			{
				if(r_RSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier == null)
				{
					r_RSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier = new(this, "SetRenderTarget", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier));
					r_RSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier.SetBelong(this.instance);
				}
				return r_RSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier, Int32)
		/// </summary>
		protected RMethod r_RSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32;
		public virtual RMethod RSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32
		{
			get
			{
				if(r_RSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32 == null)
				{
					r_RSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32 = new(this, "SetRenderTarget", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32));
					r_RSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32.SetBelong(this.instance);
				}
				return r_RSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32;
			}
		}

		/// <summary>
		/// Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier, Int32, UnityEngine.CubemapFace)
		/// </summary>
		protected RMethod r_RSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32_CubemapFace;
		public virtual RMethod RSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32_CubemapFace
		{
			get
			{
				if(r_RSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32_CubemapFace == null)
				{
					r_RSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32_CubemapFace = new(this, "SetRenderTarget", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(UnityEngine.CubemapFace));
					r_RSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32_CubemapFace.SetBelong(this.instance);
				}
				return r_RSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32_CubemapFace;
			}
		}

		/// <summary>
		/// Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier, Int32, UnityEngine.CubemapFace, Int32)
		/// </summary>
		protected RMethod r_RSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32_CubemapFace_Int32;
		public virtual RMethod RSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32_CubemapFace_Int32
		{
			get
			{
				if(r_RSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32_CubemapFace_Int32 == null)
				{
					r_RSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32_CubemapFace_Int32 = new(this, "SetRenderTarget", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(UnityEngine.CubemapFace), typeof(System.Int32));
					r_RSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32_CubemapFace_Int32.SetBelong(this.instance);
				}
				return r_RSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32_CubemapFace_Int32;
			}
		}

		/// <summary>
		/// Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction)
		/// </summary>
		protected RMethod r_RSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction;
		public virtual RMethod RSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction
		{
			get
			{
				if(r_RSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction == null)
				{
					r_RSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction = new(this, "SetRenderTarget", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction));
					r_RSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction.SetBelong(this.instance);
				}
				return r_RSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction;
			}
		}

		/// <summary>
		/// Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier[], UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_RSetRenderTarget_RenderTargetIdentifierArray_RenderTargetIdentifier;
		public virtual RMethod RSetRenderTarget_RenderTargetIdentifierArray_RenderTargetIdentifier
		{
			get
			{
				if(r_RSetRenderTarget_RenderTargetIdentifierArray_RenderTargetIdentifier == null)
				{
					r_RSetRenderTarget_RenderTargetIdentifierArray_RenderTargetIdentifier = new(this, "SetRenderTarget", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeArrayType(), typeof(UnityEngine.Rendering.RenderTargetIdentifier));
					r_RSetRenderTarget_RenderTargetIdentifierArray_RenderTargetIdentifier.SetBelong(this.instance);
				}
				return r_RSetRenderTarget_RenderTargetIdentifierArray_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier[], UnityEngine.Rendering.RenderTargetIdentifier, Int32, UnityEngine.CubemapFace, Int32)
		/// </summary>
		protected RMethod r_RSetRenderTarget_RenderTargetIdentifierArray_RenderTargetIdentifier_Int32_CubemapFace_Int32;
		public virtual RMethod RSetRenderTarget_RenderTargetIdentifierArray_RenderTargetIdentifier_Int32_CubemapFace_Int32
		{
			get
			{
				if(r_RSetRenderTarget_RenderTargetIdentifierArray_RenderTargetIdentifier_Int32_CubemapFace_Int32 == null)
				{
					r_RSetRenderTarget_RenderTargetIdentifierArray_RenderTargetIdentifier_Int32_CubemapFace_Int32 = new(this, "SetRenderTarget", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeArrayType(), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(UnityEngine.CubemapFace), typeof(System.Int32));
					r_RSetRenderTarget_RenderTargetIdentifierArray_RenderTargetIdentifier_Int32_CubemapFace_Int32.SetBelong(this.instance);
				}
				return r_RSetRenderTarget_RenderTargetIdentifierArray_RenderTargetIdentifier_Int32_CubemapFace_Int32;
			}
		}

		/// <summary>
		/// Void SetRenderTarget(UnityEngine.Rendering.RenderTargetBinding, Int32, UnityEngine.CubemapFace, Int32)
		/// </summary>
		protected RMethod r_RSetRenderTarget_RenderTargetBinding_Int32_CubemapFace_Int32;
		public virtual RMethod RSetRenderTarget_RenderTargetBinding_Int32_CubemapFace_Int32
		{
			get
			{
				if(r_RSetRenderTarget_RenderTargetBinding_Int32_CubemapFace_Int32 == null)
				{
					r_RSetRenderTarget_RenderTargetBinding_Int32_CubemapFace_Int32 = new(this, "SetRenderTarget", 0, typeof(UnityEngine.Rendering.RenderTargetBinding), typeof(System.Int32), typeof(UnityEngine.CubemapFace), typeof(System.Int32));
					r_RSetRenderTarget_RenderTargetBinding_Int32_CubemapFace_Int32.SetBelong(this.instance);
				}
				return r_RSetRenderTarget_RenderTargetBinding_Int32_CubemapFace_Int32;
			}
		}

		/// <summary>
		/// Void SetRenderTarget(UnityEngine.Rendering.RenderTargetBinding)
		/// </summary>
		protected RMethod r_RSetRenderTarget_RenderTargetBinding;
		public virtual RMethod RSetRenderTarget_RenderTargetBinding
		{
			get
			{
				if(r_RSetRenderTarget_RenderTargetBinding == null)
				{
					r_RSetRenderTarget_RenderTargetBinding = new(this, "SetRenderTarget", 0, typeof(UnityEngine.Rendering.RenderTargetBinding));
					r_RSetRenderTarget_RenderTargetBinding.SetBelong(this.instance);
				}
				return r_RSetRenderTarget_RenderTargetBinding;
			}
		}

		/// <summary>
		/// Void SetRenderTargetSingle_Internal(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction)
		/// </summary>
		protected RMethod r_RSetRenderTargetSingle_Internal_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction;
		public virtual RMethod RSetRenderTargetSingle_Internal_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction
		{
			get
			{
				if(r_RSetRenderTargetSingle_Internal_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction == null)
				{
					r_RSetRenderTargetSingle_Internal_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction = new(this, "SetRenderTargetSingle_Internal", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction));
					r_RSetRenderTargetSingle_Internal_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction.SetBelong(this.instance);
				}
				return r_RSetRenderTargetSingle_Internal_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction;
			}
		}

		/// <summary>
		/// Void SetRenderTargetColorDepth_Internal(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, UnityEngine.Rendering.RenderTargetFlags)
		/// </summary>
		protected RMethod r_RSetRenderTargetColorDepth_Internal_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags;
		public virtual RMethod RSetRenderTargetColorDepth_Internal_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags
		{
			get
			{
				if(r_RSetRenderTargetColorDepth_Internal_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags == null)
				{
					r_RSetRenderTargetColorDepth_Internal_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags = new(this, "SetRenderTargetColorDepth_Internal", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction), typeof(UnityEngine.Rendering.RenderTargetFlags));
					r_RSetRenderTargetColorDepth_Internal_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags.SetBelong(this.instance);
				}
				return r_RSetRenderTargetColorDepth_Internal_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags;
			}
		}

		/// <summary>
		/// Void SetRenderTargetMulti_Internal(UnityEngine.Rendering.RenderTargetIdentifier[], UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderBufferLoadAction[], UnityEngine.Rendering.RenderBufferStoreAction[], UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, UnityEngine.Rendering.RenderTargetFlags)
		/// </summary>
		protected RMethod r_RSetRenderTargetMulti_Internal_RenderTargetIdentifierArray_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags;
		public virtual RMethod RSetRenderTargetMulti_Internal_RenderTargetIdentifierArray_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags
		{
			get
			{
				if(r_RSetRenderTargetMulti_Internal_RenderTargetIdentifierArray_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags == null)
				{
					r_RSetRenderTargetMulti_Internal_RenderTargetIdentifierArray_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags = new(this, "SetRenderTargetMulti_Internal", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeArrayType(), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderBufferLoadAction).MakeArrayType(), typeof(UnityEngine.Rendering.RenderBufferStoreAction).MakeArrayType(), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction), typeof(UnityEngine.Rendering.RenderTargetFlags));
					r_RSetRenderTargetMulti_Internal_RenderTargetIdentifierArray_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags.SetBelong(this.instance);
				}
				return r_RSetRenderTargetMulti_Internal_RenderTargetIdentifierArray_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags;
			}
		}

		/// <summary>
		/// Void SetRenderTargetColorDepthSubtarget(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, Int32, UnityEngine.CubemapFace, Int32)
		/// </summary>
		protected RMethod r_RSetRenderTargetColorDepthSubtarget_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32;
		public virtual RMethod RSetRenderTargetColorDepthSubtarget_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32
		{
			get
			{
				if(r_RSetRenderTargetColorDepthSubtarget_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32 == null)
				{
					r_RSetRenderTargetColorDepthSubtarget_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32 = new(this, "SetRenderTargetColorDepthSubtarget", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction), typeof(System.Int32), typeof(UnityEngine.CubemapFace), typeof(System.Int32));
					r_RSetRenderTargetColorDepthSubtarget_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32.SetBelong(this.instance);
				}
				return r_RSetRenderTargetColorDepthSubtarget_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32;
			}
		}

		/// <summary>
		/// Void SetRenderTargetMultiSubtarget(UnityEngine.Rendering.RenderTargetIdentifier[], UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderBufferLoadAction[], UnityEngine.Rendering.RenderBufferStoreAction[], UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, Int32, UnityEngine.CubemapFace, Int32)
		/// </summary>
		protected RMethod r_RSetRenderTargetMultiSubtarget_RenderTargetIdentifierArray_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32;
		public virtual RMethod RSetRenderTargetMultiSubtarget_RenderTargetIdentifierArray_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32
		{
			get
			{
				if(r_RSetRenderTargetMultiSubtarget_RenderTargetIdentifierArray_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32 == null)
				{
					r_RSetRenderTargetMultiSubtarget_RenderTargetIdentifierArray_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32 = new(this, "SetRenderTargetMultiSubtarget", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeArrayType(), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderBufferLoadAction).MakeArrayType(), typeof(UnityEngine.Rendering.RenderBufferStoreAction).MakeArrayType(), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction), typeof(System.Int32), typeof(UnityEngine.CubemapFace), typeof(System.Int32));
					r_RSetRenderTargetMultiSubtarget_RenderTargetIdentifierArray_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32.SetBelong(this.instance);
				}
				return r_RSetRenderTargetMultiSubtarget_RenderTargetIdentifierArray_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32;
			}
		}

		/// <summary>
		/// Void Internal_ProcessVTFeedback(UnityEngine.Rendering.RenderTargetIdentifier, IntPtr, Int32, Int32, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RInternal_ProcessVTFeedback_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32;
		public virtual RMethod RInternal_ProcessVTFeedback_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_RInternal_ProcessVTFeedback_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32 == null)
				{
					r_RInternal_ProcessVTFeedback_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32 = new(this, "Internal_ProcessVTFeedback", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RInternal_ProcessVTFeedback_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RInternal_ProcessVTFeedback_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetBufferData(UnityEngine.ComputeBuffer, System.Array)
		/// </summary>
		protected RMethod r_RSetBufferData_ComputeBuffer_Array;
		public virtual RMethod RSetBufferData_ComputeBuffer_Array
		{
			get
			{
				if(r_RSetBufferData_ComputeBuffer_Array == null)
				{
					r_RSetBufferData_ComputeBuffer_Array = new(this, "SetBufferData", 0, typeof(UnityEngine.ComputeBuffer), typeof(System.Array));
					r_RSetBufferData_ComputeBuffer_Array.SetBelong(this.instance);
				}
				return r_RSetBufferData_ComputeBuffer_Array;
			}
		}

		/// <summary>
		/// Void SetBufferData[T](UnityEngine.ComputeBuffer, System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_RSetBufferData_GT_ComputeBuffer_List_d_T_p_;
		public virtual RMethod RSetBufferData_GT_ComputeBuffer_List_d_T_p_
		{
			get
			{
				if(r_RSetBufferData_GT_ComputeBuffer_List_d_T_p_ == null)
				{
					r_RSetBufferData_GT_ComputeBuffer_List_d_T_p_ = new(this, "SetBufferData", 1, typeof(UnityEngine.ComputeBuffer), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RSetBufferData_GT_ComputeBuffer_List_d_T_p_.SetBelong(this.instance);
				}
				return r_RSetBufferData_GT_ComputeBuffer_List_d_T_p_;
			}
		}

		/// <summary>
		/// Void SetBufferData[T](UnityEngine.ComputeBuffer, Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_RSetBufferData_GT_ComputeBuffer_NativeArray_d_T_p_;
		public virtual RMethod RSetBufferData_GT_ComputeBuffer_NativeArray_d_T_p_
		{
			get
			{
				if(r_RSetBufferData_GT_ComputeBuffer_NativeArray_d_T_p_ == null)
				{
					r_RSetBufferData_GT_ComputeBuffer_NativeArray_d_T_p_ = new(this, "SetBufferData", 1, typeof(UnityEngine.ComputeBuffer), typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RSetBufferData_GT_ComputeBuffer_NativeArray_d_T_p_.SetBelong(this.instance);
				}
				return r_RSetBufferData_GT_ComputeBuffer_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void SetBufferData(UnityEngine.ComputeBuffer, System.Array, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetBufferData_ComputeBuffer_Array_Int32_Int32_Int32;
		public virtual RMethod RSetBufferData_ComputeBuffer_Array_Int32_Int32_Int32
		{
			get
			{
				if(r_RSetBufferData_ComputeBuffer_Array_Int32_Int32_Int32 == null)
				{
					r_RSetBufferData_ComputeBuffer_Array_Int32_Int32_Int32 = new(this, "SetBufferData", 0, typeof(UnityEngine.ComputeBuffer), typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RSetBufferData_ComputeBuffer_Array_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetBufferData_ComputeBuffer_Array_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetBufferData[T](UnityEngine.ComputeBuffer, System.Collections.Generic.List`1[T], Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetBufferData_GT_ComputeBuffer_List_d_T_p__Int32_Int32_Int32;
		public virtual RMethod RSetBufferData_GT_ComputeBuffer_List_d_T_p__Int32_Int32_Int32
		{
			get
			{
				if(r_RSetBufferData_GT_ComputeBuffer_List_d_T_p__Int32_Int32_Int32 == null)
				{
					r_RSetBufferData_GT_ComputeBuffer_List_d_T_p__Int32_Int32_Int32 = new(this, "SetBufferData", 1, typeof(UnityEngine.ComputeBuffer), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RSetBufferData_GT_ComputeBuffer_List_d_T_p__Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetBufferData_GT_ComputeBuffer_List_d_T_p__Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetBufferData[T](UnityEngine.ComputeBuffer, Unity.Collections.NativeArray`1[T], Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetBufferData_GT_ComputeBuffer_NativeArray_d_T_p__Int32_Int32_Int32;
		public virtual RMethod RSetBufferData_GT_ComputeBuffer_NativeArray_d_T_p__Int32_Int32_Int32
		{
			get
			{
				if(r_RSetBufferData_GT_ComputeBuffer_NativeArray_d_T_p__Int32_Int32_Int32 == null)
				{
					r_RSetBufferData_GT_ComputeBuffer_NativeArray_d_T_p__Int32_Int32_Int32 = new(this, "SetBufferData", 1, typeof(UnityEngine.ComputeBuffer), typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RSetBufferData_GT_ComputeBuffer_NativeArray_d_T_p__Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetBufferData_GT_ComputeBuffer_NativeArray_d_T_p__Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetBufferCounterValue(UnityEngine.ComputeBuffer, UInt32)
		/// </summary>
		protected RMethod r_RSetBufferCounterValue_ComputeBuffer_UInt32;
		public virtual RMethod RSetBufferCounterValue_ComputeBuffer_UInt32
		{
			get
			{
				if(r_RSetBufferCounterValue_ComputeBuffer_UInt32 == null)
				{
					r_RSetBufferCounterValue_ComputeBuffer_UInt32 = new(this, "SetBufferCounterValue", 0, typeof(UnityEngine.ComputeBuffer), typeof(System.UInt32));
					r_RSetBufferCounterValue_ComputeBuffer_UInt32.SetBelong(this.instance);
				}
				return r_RSetBufferCounterValue_ComputeBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void InternalSetComputeBufferNativeData(UnityEngine.ComputeBuffer, IntPtr, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RInternalSetComputeBufferNativeData_ComputeBuffer_IntPtr_Int32_Int32_Int32_Int32;
		public virtual RMethod RInternalSetComputeBufferNativeData_ComputeBuffer_IntPtr_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_RInternalSetComputeBufferNativeData_ComputeBuffer_IntPtr_Int32_Int32_Int32_Int32 == null)
				{
					r_RInternalSetComputeBufferNativeData_ComputeBuffer_IntPtr_Int32_Int32_Int32_Int32 = new(this, "InternalSetComputeBufferNativeData", 0, typeof(UnityEngine.ComputeBuffer), typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RInternalSetComputeBufferNativeData_ComputeBuffer_IntPtr_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RInternalSetComputeBufferNativeData_ComputeBuffer_IntPtr_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void InternalSetComputeBufferData(UnityEngine.ComputeBuffer, System.Array, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RInternalSetComputeBufferData_ComputeBuffer_Array_Int32_Int32_Int32_Int32;
		public virtual RMethod RInternalSetComputeBufferData_ComputeBuffer_Array_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_RInternalSetComputeBufferData_ComputeBuffer_Array_Int32_Int32_Int32_Int32 == null)
				{
					r_RInternalSetComputeBufferData_ComputeBuffer_Array_Int32_Int32_Int32_Int32 = new(this, "InternalSetComputeBufferData", 0, typeof(UnityEngine.ComputeBuffer), typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RInternalSetComputeBufferData_ComputeBuffer_Array_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RInternalSetComputeBufferData_ComputeBuffer_Array_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void InternalSetComputeBufferCounterValue(UnityEngine.ComputeBuffer, UInt32)
		/// </summary>
		protected RMethod r_RInternalSetComputeBufferCounterValue_ComputeBuffer_UInt32;
		public virtual RMethod RInternalSetComputeBufferCounterValue_ComputeBuffer_UInt32
		{
			get
			{
				if(r_RInternalSetComputeBufferCounterValue_ComputeBuffer_UInt32 == null)
				{
					r_RInternalSetComputeBufferCounterValue_ComputeBuffer_UInt32 = new(this, "InternalSetComputeBufferCounterValue", 0, typeof(UnityEngine.ComputeBuffer), typeof(System.UInt32));
					r_RInternalSetComputeBufferCounterValue_ComputeBuffer_UInt32.SetBelong(this.instance);
				}
				return r_RInternalSetComputeBufferCounterValue_ComputeBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void SetBufferData(UnityEngine.GraphicsBuffer, System.Array)
		/// </summary>
		protected RMethod r_RSetBufferData_GraphicsBuffer_Array;
		public virtual RMethod RSetBufferData_GraphicsBuffer_Array
		{
			get
			{
				if(r_RSetBufferData_GraphicsBuffer_Array == null)
				{
					r_RSetBufferData_GraphicsBuffer_Array = new(this, "SetBufferData", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.Array));
					r_RSetBufferData_GraphicsBuffer_Array.SetBelong(this.instance);
				}
				return r_RSetBufferData_GraphicsBuffer_Array;
			}
		}

		/// <summary>
		/// Void SetBufferData[T](UnityEngine.GraphicsBuffer, System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_RSetBufferData_GT_GraphicsBuffer_List_d_T_p_;
		public virtual RMethod RSetBufferData_GT_GraphicsBuffer_List_d_T_p_
		{
			get
			{
				if(r_RSetBufferData_GT_GraphicsBuffer_List_d_T_p_ == null)
				{
					r_RSetBufferData_GT_GraphicsBuffer_List_d_T_p_ = new(this, "SetBufferData", 1, typeof(UnityEngine.GraphicsBuffer), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RSetBufferData_GT_GraphicsBuffer_List_d_T_p_.SetBelong(this.instance);
				}
				return r_RSetBufferData_GT_GraphicsBuffer_List_d_T_p_;
			}
		}

		/// <summary>
		/// Void SetBufferData[T](UnityEngine.GraphicsBuffer, Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_RSetBufferData_GT_GraphicsBuffer_NativeArray_d_T_p_;
		public virtual RMethod RSetBufferData_GT_GraphicsBuffer_NativeArray_d_T_p_
		{
			get
			{
				if(r_RSetBufferData_GT_GraphicsBuffer_NativeArray_d_T_p_ == null)
				{
					r_RSetBufferData_GT_GraphicsBuffer_NativeArray_d_T_p_ = new(this, "SetBufferData", 1, typeof(UnityEngine.GraphicsBuffer), typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RSetBufferData_GT_GraphicsBuffer_NativeArray_d_T_p_.SetBelong(this.instance);
				}
				return r_RSetBufferData_GT_GraphicsBuffer_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void SetBufferData(UnityEngine.GraphicsBuffer, System.Array, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetBufferData_GraphicsBuffer_Array_Int32_Int32_Int32;
		public virtual RMethod RSetBufferData_GraphicsBuffer_Array_Int32_Int32_Int32
		{
			get
			{
				if(r_RSetBufferData_GraphicsBuffer_Array_Int32_Int32_Int32 == null)
				{
					r_RSetBufferData_GraphicsBuffer_Array_Int32_Int32_Int32 = new(this, "SetBufferData", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RSetBufferData_GraphicsBuffer_Array_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetBufferData_GraphicsBuffer_Array_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetBufferData[T](UnityEngine.GraphicsBuffer, System.Collections.Generic.List`1[T], Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetBufferData_GT_GraphicsBuffer_List_d_T_p__Int32_Int32_Int32;
		public virtual RMethod RSetBufferData_GT_GraphicsBuffer_List_d_T_p__Int32_Int32_Int32
		{
			get
			{
				if(r_RSetBufferData_GT_GraphicsBuffer_List_d_T_p__Int32_Int32_Int32 == null)
				{
					r_RSetBufferData_GT_GraphicsBuffer_List_d_T_p__Int32_Int32_Int32 = new(this, "SetBufferData", 1, typeof(UnityEngine.GraphicsBuffer), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RSetBufferData_GT_GraphicsBuffer_List_d_T_p__Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetBufferData_GT_GraphicsBuffer_List_d_T_p__Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetBufferData[T](UnityEngine.GraphicsBuffer, Unity.Collections.NativeArray`1[T], Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetBufferData_GT_GraphicsBuffer_NativeArray_d_T_p__Int32_Int32_Int32;
		public virtual RMethod RSetBufferData_GT_GraphicsBuffer_NativeArray_d_T_p__Int32_Int32_Int32
		{
			get
			{
				if(r_RSetBufferData_GT_GraphicsBuffer_NativeArray_d_T_p__Int32_Int32_Int32 == null)
				{
					r_RSetBufferData_GT_GraphicsBuffer_NativeArray_d_T_p__Int32_Int32_Int32 = new(this, "SetBufferData", 1, typeof(UnityEngine.GraphicsBuffer), typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RSetBufferData_GT_GraphicsBuffer_NativeArray_d_T_p__Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetBufferData_GT_GraphicsBuffer_NativeArray_d_T_p__Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetBufferCounterValue(UnityEngine.GraphicsBuffer, UInt32)
		/// </summary>
		protected RMethod r_RSetBufferCounterValue_GraphicsBuffer_UInt32;
		public virtual RMethod RSetBufferCounterValue_GraphicsBuffer_UInt32
		{
			get
			{
				if(r_RSetBufferCounterValue_GraphicsBuffer_UInt32 == null)
				{
					r_RSetBufferCounterValue_GraphicsBuffer_UInt32 = new(this, "SetBufferCounterValue", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32));
					r_RSetBufferCounterValue_GraphicsBuffer_UInt32.SetBelong(this.instance);
				}
				return r_RSetBufferCounterValue_GraphicsBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void InternalSetGraphicsBufferNativeData(UnityEngine.GraphicsBuffer, IntPtr, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RInternalSetGraphicsBufferNativeData_GraphicsBuffer_IntPtr_Int32_Int32_Int32_Int32;
		public virtual RMethod RInternalSetGraphicsBufferNativeData_GraphicsBuffer_IntPtr_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_RInternalSetGraphicsBufferNativeData_GraphicsBuffer_IntPtr_Int32_Int32_Int32_Int32 == null)
				{
					r_RInternalSetGraphicsBufferNativeData_GraphicsBuffer_IntPtr_Int32_Int32_Int32_Int32 = new(this, "InternalSetGraphicsBufferNativeData", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RInternalSetGraphicsBufferNativeData_GraphicsBuffer_IntPtr_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RInternalSetGraphicsBufferNativeData_GraphicsBuffer_IntPtr_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void InternalSetGraphicsBufferData(UnityEngine.GraphicsBuffer, System.Array, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RInternalSetGraphicsBufferData_GraphicsBuffer_Array_Int32_Int32_Int32_Int32;
		public virtual RMethod RInternalSetGraphicsBufferData_GraphicsBuffer_Array_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_RInternalSetGraphicsBufferData_GraphicsBuffer_Array_Int32_Int32_Int32_Int32 == null)
				{
					r_RInternalSetGraphicsBufferData_GraphicsBuffer_Array_Int32_Int32_Int32_Int32 = new(this, "InternalSetGraphicsBufferData", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RInternalSetGraphicsBufferData_GraphicsBuffer_Array_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RInternalSetGraphicsBufferData_GraphicsBuffer_Array_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void InternalSetGraphicsBufferCounterValue(UnityEngine.GraphicsBuffer, UInt32)
		/// </summary>
		protected RMethod r_RInternalSetGraphicsBufferCounterValue_GraphicsBuffer_UInt32;
		public virtual RMethod RInternalSetGraphicsBufferCounterValue_GraphicsBuffer_UInt32
		{
			get
			{
				if(r_RInternalSetGraphicsBufferCounterValue_GraphicsBuffer_UInt32 == null)
				{
					r_RInternalSetGraphicsBufferCounterValue_GraphicsBuffer_UInt32 = new(this, "InternalSetGraphicsBufferCounterValue", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32));
					r_RInternalSetGraphicsBufferCounterValue_GraphicsBuffer_UInt32.SetBelong(this.instance);
				}
				return r_RInternalSetGraphicsBufferCounterValue_GraphicsBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void CopyBufferImpl(UnityEngine.GraphicsBuffer, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_RCopyBufferImpl_GraphicsBuffer_GraphicsBuffer;
		public virtual RMethod RCopyBufferImpl_GraphicsBuffer_GraphicsBuffer
		{
			get
			{
				if(r_RCopyBufferImpl_GraphicsBuffer_GraphicsBuffer == null)
				{
					r_RCopyBufferImpl_GraphicsBuffer_GraphicsBuffer = new(this, "CopyBufferImpl", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.GraphicsBuffer));
					r_RCopyBufferImpl_GraphicsBuffer_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_RCopyBufferImpl_GraphicsBuffer_GraphicsBuffer;
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
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_RDispose_Boolean;
		public virtual RMethod RDispose_Boolean
		{
			get
			{
				if(r_RDispose_Boolean == null)
				{
					r_RDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_RDispose_Boolean.SetBelong(this.instance);
				}
				return r_RDispose_Boolean;
			}
		}

		/// <summary>
		/// Void Release()
		/// </summary>
		protected RMethod r_RRelease;
		public virtual RMethod RRelease
		{
			get
			{
				if(r_RRelease == null)
				{
					r_RRelease = new(this, "Release", 0);
					r_RRelease.SetBelong(this.instance);
				}
				return r_RRelease;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.GraphicsFence CreateAsyncGraphicsFence()
		/// </summary>
		protected RMethod r_RCreateAsyncGraphicsFence;
		public virtual RMethod RCreateAsyncGraphicsFence
		{
			get
			{
				if(r_RCreateAsyncGraphicsFence == null)
				{
					r_RCreateAsyncGraphicsFence = new(this, "CreateAsyncGraphicsFence", 0);
					r_RCreateAsyncGraphicsFence.SetBelong(this.instance);
				}
				return r_RCreateAsyncGraphicsFence;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.GraphicsFence CreateAsyncGraphicsFence(UnityEngine.Rendering.SynchronisationStage)
		/// </summary>
		protected RMethod r_RCreateAsyncGraphicsFence_SynchronisationStage;
		public virtual RMethod RCreateAsyncGraphicsFence_SynchronisationStage
		{
			get
			{
				if(r_RCreateAsyncGraphicsFence_SynchronisationStage == null)
				{
					r_RCreateAsyncGraphicsFence_SynchronisationStage = new(this, "CreateAsyncGraphicsFence", 0, typeof(UnityEngine.Rendering.SynchronisationStage));
					r_RCreateAsyncGraphicsFence_SynchronisationStage.SetBelong(this.instance);
				}
				return r_RCreateAsyncGraphicsFence_SynchronisationStage;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.GraphicsFence CreateGraphicsFence(UnityEngine.Rendering.GraphicsFenceType, UnityEngine.Rendering.SynchronisationStageFlags)
		/// </summary>
		protected RMethod r_RCreateGraphicsFence_GraphicsFenceType_SynchronisationStageFlags;
		public virtual RMethod RCreateGraphicsFence_GraphicsFenceType_SynchronisationStageFlags
		{
			get
			{
				if(r_RCreateGraphicsFence_GraphicsFenceType_SynchronisationStageFlags == null)
				{
					r_RCreateGraphicsFence_GraphicsFenceType_SynchronisationStageFlags = new(this, "CreateGraphicsFence", 0, typeof(UnityEngine.Rendering.GraphicsFenceType), typeof(UnityEngine.Rendering.SynchronisationStageFlags));
					r_RCreateGraphicsFence_GraphicsFenceType_SynchronisationStageFlags.SetBelong(this.instance);
				}
				return r_RCreateGraphicsFence_GraphicsFenceType_SynchronisationStageFlags;
			}
		}

		/// <summary>
		/// Void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence)
		/// </summary>
		protected RMethod r_RWaitOnAsyncGraphicsFence_GraphicsFence;
		public virtual RMethod RWaitOnAsyncGraphicsFence_GraphicsFence
		{
			get
			{
				if(r_RWaitOnAsyncGraphicsFence_GraphicsFence == null)
				{
					r_RWaitOnAsyncGraphicsFence_GraphicsFence = new(this, "WaitOnAsyncGraphicsFence", 0, typeof(UnityEngine.Rendering.GraphicsFence));
					r_RWaitOnAsyncGraphicsFence_GraphicsFence.SetBelong(this.instance);
				}
				return r_RWaitOnAsyncGraphicsFence_GraphicsFence;
			}
		}

		/// <summary>
		/// Void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence, UnityEngine.Rendering.SynchronisationStage)
		/// </summary>
		protected RMethod r_RWaitOnAsyncGraphicsFence_GraphicsFence_SynchronisationStage;
		public virtual RMethod RWaitOnAsyncGraphicsFence_GraphicsFence_SynchronisationStage
		{
			get
			{
				if(r_RWaitOnAsyncGraphicsFence_GraphicsFence_SynchronisationStage == null)
				{
					r_RWaitOnAsyncGraphicsFence_GraphicsFence_SynchronisationStage = new(this, "WaitOnAsyncGraphicsFence", 0, typeof(UnityEngine.Rendering.GraphicsFence), typeof(UnityEngine.Rendering.SynchronisationStage));
					r_RWaitOnAsyncGraphicsFence_GraphicsFence_SynchronisationStage.SetBelong(this.instance);
				}
				return r_RWaitOnAsyncGraphicsFence_GraphicsFence_SynchronisationStage;
			}
		}

		/// <summary>
		/// Void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence, UnityEngine.Rendering.SynchronisationStageFlags)
		/// </summary>
		protected RMethod r_RWaitOnAsyncGraphicsFence_GraphicsFence_SynchronisationStageFlags;
		public virtual RMethod RWaitOnAsyncGraphicsFence_GraphicsFence_SynchronisationStageFlags
		{
			get
			{
				if(r_RWaitOnAsyncGraphicsFence_GraphicsFence_SynchronisationStageFlags == null)
				{
					r_RWaitOnAsyncGraphicsFence_GraphicsFence_SynchronisationStageFlags = new(this, "WaitOnAsyncGraphicsFence", 0, typeof(UnityEngine.Rendering.GraphicsFence), typeof(UnityEngine.Rendering.SynchronisationStageFlags));
					r_RWaitOnAsyncGraphicsFence_GraphicsFence_SynchronisationStageFlags.SetBelong(this.instance);
				}
				return r_RWaitOnAsyncGraphicsFence_GraphicsFence_SynchronisationStageFlags;
			}
		}

		/// <summary>
		/// Void SetComputeFloatParam(UnityEngine.ComputeShader, System.String, Single)
		/// </summary>
		protected RMethod r_RSetComputeFloatParam_ComputeShader_String_Single;
		public virtual RMethod RSetComputeFloatParam_ComputeShader_String_Single
		{
			get
			{
				if(r_RSetComputeFloatParam_ComputeShader_String_Single == null)
				{
					r_RSetComputeFloatParam_ComputeShader_String_Single = new(this, "SetComputeFloatParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.String), typeof(System.Single));
					r_RSetComputeFloatParam_ComputeShader_String_Single.SetBelong(this.instance);
				}
				return r_RSetComputeFloatParam_ComputeShader_String_Single;
			}
		}

		/// <summary>
		/// Void SetComputeIntParam(UnityEngine.ComputeShader, System.String, Int32)
		/// </summary>
		protected RMethod r_RSetComputeIntParam_ComputeShader_String_Int32;
		public virtual RMethod RSetComputeIntParam_ComputeShader_String_Int32
		{
			get
			{
				if(r_RSetComputeIntParam_ComputeShader_String_Int32 == null)
				{
					r_RSetComputeIntParam_ComputeShader_String_Int32 = new(this, "SetComputeIntParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.String), typeof(System.Int32));
					r_RSetComputeIntParam_ComputeShader_String_Int32.SetBelong(this.instance);
				}
				return r_RSetComputeIntParam_ComputeShader_String_Int32;
			}
		}

		/// <summary>
		/// Void SetComputeVectorParam(UnityEngine.ComputeShader, System.String, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_RSetComputeVectorParam_ComputeShader_String_Vector4;
		public virtual RMethod RSetComputeVectorParam_ComputeShader_String_Vector4
		{
			get
			{
				if(r_RSetComputeVectorParam_ComputeShader_String_Vector4 == null)
				{
					r_RSetComputeVectorParam_ComputeShader_String_Vector4 = new(this, "SetComputeVectorParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.String), typeof(UnityEngine.Vector4));
					r_RSetComputeVectorParam_ComputeShader_String_Vector4.SetBelong(this.instance);
				}
				return r_RSetComputeVectorParam_ComputeShader_String_Vector4;
			}
		}

		/// <summary>
		/// Void SetComputeVectorArrayParam(UnityEngine.ComputeShader, System.String, UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_RSetComputeVectorArrayParam_ComputeShader_String_Vector4Array;
		public virtual RMethod RSetComputeVectorArrayParam_ComputeShader_String_Vector4Array
		{
			get
			{
				if(r_RSetComputeVectorArrayParam_ComputeShader_String_Vector4Array == null)
				{
					r_RSetComputeVectorArrayParam_ComputeShader_String_Vector4Array = new(this, "SetComputeVectorArrayParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.String), typeof(UnityEngine.Vector4).MakeArrayType());
					r_RSetComputeVectorArrayParam_ComputeShader_String_Vector4Array.SetBelong(this.instance);
				}
				return r_RSetComputeVectorArrayParam_ComputeShader_String_Vector4Array;
			}
		}

		/// <summary>
		/// Void SetComputeMatrixParam(UnityEngine.ComputeShader, System.String, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_RSetComputeMatrixParam_ComputeShader_String_Matrix4x4;
		public virtual RMethod RSetComputeMatrixParam_ComputeShader_String_Matrix4x4
		{
			get
			{
				if(r_RSetComputeMatrixParam_ComputeShader_String_Matrix4x4 == null)
				{
					r_RSetComputeMatrixParam_ComputeShader_String_Matrix4x4 = new(this, "SetComputeMatrixParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.String), typeof(UnityEngine.Matrix4x4));
					r_RSetComputeMatrixParam_ComputeShader_String_Matrix4x4.SetBelong(this.instance);
				}
				return r_RSetComputeMatrixParam_ComputeShader_String_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetComputeMatrixArrayParam(UnityEngine.ComputeShader, System.String, UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_RSetComputeMatrixArrayParam_ComputeShader_String_Matrix4x4Array;
		public virtual RMethod RSetComputeMatrixArrayParam_ComputeShader_String_Matrix4x4Array
		{
			get
			{
				if(r_RSetComputeMatrixArrayParam_ComputeShader_String_Matrix4x4Array == null)
				{
					r_RSetComputeMatrixArrayParam_ComputeShader_String_Matrix4x4Array = new(this, "SetComputeMatrixArrayParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.String), typeof(UnityEngine.Matrix4x4).MakeArrayType());
					r_RSetComputeMatrixArrayParam_ComputeShader_String_Matrix4x4Array.SetBelong(this.instance);
				}
				return r_RSetComputeMatrixArrayParam_ComputeShader_String_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Void SetComputeFloatParams(UnityEngine.ComputeShader, System.String, Single[])
		/// </summary>
		protected RMethod r_RSetComputeFloatParams_ComputeShader_String_SingleArray;
		public virtual RMethod RSetComputeFloatParams_ComputeShader_String_SingleArray
		{
			get
			{
				if(r_RSetComputeFloatParams_ComputeShader_String_SingleArray == null)
				{
					r_RSetComputeFloatParams_ComputeShader_String_SingleArray = new(this, "SetComputeFloatParams", 0, typeof(UnityEngine.ComputeShader), typeof(System.String), typeof(System.Single).MakeArrayType());
					r_RSetComputeFloatParams_ComputeShader_String_SingleArray.SetBelong(this.instance);
				}
				return r_RSetComputeFloatParams_ComputeShader_String_SingleArray;
			}
		}

		/// <summary>
		/// Void SetComputeFloatParams(UnityEngine.ComputeShader, Int32, Single[])
		/// </summary>
		protected RMethod r_RSetComputeFloatParams_ComputeShader_Int32_SingleArray;
		public virtual RMethod RSetComputeFloatParams_ComputeShader_Int32_SingleArray
		{
			get
			{
				if(r_RSetComputeFloatParams_ComputeShader_Int32_SingleArray == null)
				{
					r_RSetComputeFloatParams_ComputeShader_Int32_SingleArray = new(this, "SetComputeFloatParams", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Single).MakeArrayType());
					r_RSetComputeFloatParams_ComputeShader_Int32_SingleArray.SetBelong(this.instance);
				}
				return r_RSetComputeFloatParams_ComputeShader_Int32_SingleArray;
			}
		}

		/// <summary>
		/// Void SetComputeIntParams(UnityEngine.ComputeShader, System.String, Int32[])
		/// </summary>
		protected RMethod r_RSetComputeIntParams_ComputeShader_String_Int32Array;
		public virtual RMethod RSetComputeIntParams_ComputeShader_String_Int32Array
		{
			get
			{
				if(r_RSetComputeIntParams_ComputeShader_String_Int32Array == null)
				{
					r_RSetComputeIntParams_ComputeShader_String_Int32Array = new(this, "SetComputeIntParams", 0, typeof(UnityEngine.ComputeShader), typeof(System.String), typeof(System.Int32).MakeArrayType());
					r_RSetComputeIntParams_ComputeShader_String_Int32Array.SetBelong(this.instance);
				}
				return r_RSetComputeIntParams_ComputeShader_String_Int32Array;
			}
		}

		/// <summary>
		/// Void SetComputeIntParams(UnityEngine.ComputeShader, Int32, Int32[])
		/// </summary>
		protected RMethod r_RSetComputeIntParams_ComputeShader_Int32_Int32Array;
		public virtual RMethod RSetComputeIntParams_ComputeShader_Int32_Int32Array
		{
			get
			{
				if(r_RSetComputeIntParams_ComputeShader_Int32_Int32Array == null)
				{
					r_RSetComputeIntParams_ComputeShader_Int32_Int32Array = new(this, "SetComputeIntParams", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Int32).MakeArrayType());
					r_RSetComputeIntParams_ComputeShader_Int32_Int32Array.SetBelong(this.instance);
				}
				return r_RSetComputeIntParams_ComputeShader_Int32_Int32Array;
			}
		}

		/// <summary>
		/// Void SetComputeTextureParam(UnityEngine.ComputeShader, Int32, System.String, UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_RSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier;
		public virtual RMethod RSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier
		{
			get
			{
				if(r_RSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier == null)
				{
					r_RSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier = new(this, "SetComputeTextureParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.String), typeof(UnityEngine.Rendering.RenderTargetIdentifier));
					r_RSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier.SetBelong(this.instance);
				}
				return r_RSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void SetComputeTextureParam(UnityEngine.ComputeShader, Int32, Int32, UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_RSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier;
		public virtual RMethod RSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier
		{
			get
			{
				if(r_RSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier == null)
				{
					r_RSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier = new(this, "SetComputeTextureParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier));
					r_RSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier.SetBelong(this.instance);
				}
				return r_RSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void SetComputeTextureParam(UnityEngine.ComputeShader, Int32, System.String, UnityEngine.Rendering.RenderTargetIdentifier, Int32)
		/// </summary>
		protected RMethod r_RSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier_Int32;
		public virtual RMethod RSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier_Int32
		{
			get
			{
				if(r_RSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier_Int32 == null)
				{
					r_RSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier_Int32 = new(this, "SetComputeTextureParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.String), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32));
					r_RSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier_Int32.SetBelong(this.instance);
				}
				return r_RSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier_Int32;
			}
		}

		/// <summary>
		/// Void SetComputeTextureParam(UnityEngine.ComputeShader, Int32, Int32, UnityEngine.Rendering.RenderTargetIdentifier, Int32)
		/// </summary>
		protected RMethod r_RSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier_Int32;
		public virtual RMethod RSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier_Int32
		{
			get
			{
				if(r_RSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier_Int32 == null)
				{
					r_RSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier_Int32 = new(this, "SetComputeTextureParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32));
					r_RSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier_Int32.SetBelong(this.instance);
				}
				return r_RSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier_Int32;
			}
		}

		/// <summary>
		/// Void SetComputeTextureParam(UnityEngine.ComputeShader, Int32, System.String, UnityEngine.Rendering.RenderTargetIdentifier, Int32, UnityEngine.Rendering.RenderTextureSubElement)
		/// </summary>
		protected RMethod r_RSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier_Int32_RenderTextureSubElement;
		public virtual RMethod RSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier_Int32_RenderTextureSubElement
		{
			get
			{
				if(r_RSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier_Int32_RenderTextureSubElement == null)
				{
					r_RSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier_Int32_RenderTextureSubElement = new(this, "SetComputeTextureParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.String), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTextureSubElement));
					r_RSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier_Int32_RenderTextureSubElement.SetBelong(this.instance);
				}
				return r_RSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier_Int32_RenderTextureSubElement;
			}
		}

		/// <summary>
		/// Void SetComputeTextureParam(UnityEngine.ComputeShader, Int32, Int32, UnityEngine.Rendering.RenderTargetIdentifier, Int32, UnityEngine.Rendering.RenderTextureSubElement)
		/// </summary>
		protected RMethod r_RSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier_Int32_RenderTextureSubElement;
		public virtual RMethod RSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier_Int32_RenderTextureSubElement
		{
			get
			{
				if(r_RSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier_Int32_RenderTextureSubElement == null)
				{
					r_RSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier_Int32_RenderTextureSubElement = new(this, "SetComputeTextureParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTextureSubElement));
					r_RSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier_Int32_RenderTextureSubElement.SetBelong(this.instance);
				}
				return r_RSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier_Int32_RenderTextureSubElement;
			}
		}

		/// <summary>
		/// Void SetComputeBufferParam(UnityEngine.ComputeShader, Int32, Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_RSetComputeBufferParam_ComputeShader_Int32_Int32_ComputeBuffer;
		public virtual RMethod RSetComputeBufferParam_ComputeShader_Int32_Int32_ComputeBuffer
		{
			get
			{
				if(r_RSetComputeBufferParam_ComputeShader_Int32_Int32_ComputeBuffer == null)
				{
					r_RSetComputeBufferParam_ComputeShader_Int32_Int32_ComputeBuffer = new(this, "SetComputeBufferParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
					r_RSetComputeBufferParam_ComputeShader_Int32_Int32_ComputeBuffer.SetBelong(this.instance);
				}
				return r_RSetComputeBufferParam_ComputeShader_Int32_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetComputeBufferParam(UnityEngine.ComputeShader, Int32, System.String, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_RSetComputeBufferParam_ComputeShader_Int32_String_ComputeBuffer;
		public virtual RMethod RSetComputeBufferParam_ComputeShader_Int32_String_ComputeBuffer
		{
			get
			{
				if(r_RSetComputeBufferParam_ComputeShader_Int32_String_ComputeBuffer == null)
				{
					r_RSetComputeBufferParam_ComputeShader_Int32_String_ComputeBuffer = new(this, "SetComputeBufferParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.String), typeof(UnityEngine.ComputeBuffer));
					r_RSetComputeBufferParam_ComputeShader_Int32_String_ComputeBuffer.SetBelong(this.instance);
				}
				return r_RSetComputeBufferParam_ComputeShader_Int32_String_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetComputeBufferParam(UnityEngine.ComputeShader, Int32, Int32, UnityEngine.GraphicsBufferHandle)
		/// </summary>
		protected RMethod r_RSetComputeBufferParam_ComputeShader_Int32_Int32_GraphicsBufferHandle;
		public virtual RMethod RSetComputeBufferParam_ComputeShader_Int32_Int32_GraphicsBufferHandle
		{
			get
			{
				if(r_RSetComputeBufferParam_ComputeShader_Int32_Int32_GraphicsBufferHandle == null)
				{
					r_RSetComputeBufferParam_ComputeShader_Int32_Int32_GraphicsBufferHandle = new(this, "SetComputeBufferParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.GraphicsBufferHandle));
					r_RSetComputeBufferParam_ComputeShader_Int32_Int32_GraphicsBufferHandle.SetBelong(this.instance);
				}
				return r_RSetComputeBufferParam_ComputeShader_Int32_Int32_GraphicsBufferHandle;
			}
		}

		/// <summary>
		/// Void SetComputeBufferParam(UnityEngine.ComputeShader, Int32, System.String, UnityEngine.GraphicsBufferHandle)
		/// </summary>
		protected RMethod r_RSetComputeBufferParam_ComputeShader_Int32_String_GraphicsBufferHandle;
		public virtual RMethod RSetComputeBufferParam_ComputeShader_Int32_String_GraphicsBufferHandle
		{
			get
			{
				if(r_RSetComputeBufferParam_ComputeShader_Int32_String_GraphicsBufferHandle == null)
				{
					r_RSetComputeBufferParam_ComputeShader_Int32_String_GraphicsBufferHandle = new(this, "SetComputeBufferParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.String), typeof(UnityEngine.GraphicsBufferHandle));
					r_RSetComputeBufferParam_ComputeShader_Int32_String_GraphicsBufferHandle.SetBelong(this.instance);
				}
				return r_RSetComputeBufferParam_ComputeShader_Int32_String_GraphicsBufferHandle;
			}
		}

		/// <summary>
		/// Void SetComputeBufferParam(UnityEngine.ComputeShader, Int32, Int32, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_RSetComputeBufferParam_ComputeShader_Int32_Int32_GraphicsBuffer;
		public virtual RMethod RSetComputeBufferParam_ComputeShader_Int32_Int32_GraphicsBuffer
		{
			get
			{
				if(r_RSetComputeBufferParam_ComputeShader_Int32_Int32_GraphicsBuffer == null)
				{
					r_RSetComputeBufferParam_ComputeShader_Int32_Int32_GraphicsBuffer = new(this, "SetComputeBufferParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer));
					r_RSetComputeBufferParam_ComputeShader_Int32_Int32_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_RSetComputeBufferParam_ComputeShader_Int32_Int32_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetComputeBufferParam(UnityEngine.ComputeShader, Int32, System.String, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_RSetComputeBufferParam_ComputeShader_Int32_String_GraphicsBuffer;
		public virtual RMethod RSetComputeBufferParam_ComputeShader_Int32_String_GraphicsBuffer
		{
			get
			{
				if(r_RSetComputeBufferParam_ComputeShader_Int32_String_GraphicsBuffer == null)
				{
					r_RSetComputeBufferParam_ComputeShader_Int32_String_GraphicsBuffer = new(this, "SetComputeBufferParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.String), typeof(UnityEngine.GraphicsBuffer));
					r_RSetComputeBufferParam_ComputeShader_Int32_String_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_RSetComputeBufferParam_ComputeShader_Int32_String_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetComputeConstantBufferParam(UnityEngine.ComputeShader, Int32, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetComputeConstantBufferParam_ComputeShader_Int32_ComputeBuffer_Int32_Int32;
		public virtual RMethod RSetComputeConstantBufferParam_ComputeShader_Int32_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_RSetComputeConstantBufferParam_ComputeShader_Int32_ComputeBuffer_Int32_Int32 == null)
				{
					r_RSetComputeConstantBufferParam_ComputeShader_Int32_ComputeBuffer_Int32_Int32 = new(this, "SetComputeConstantBufferParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
					r_RSetComputeConstantBufferParam_ComputeShader_Int32_ComputeBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetComputeConstantBufferParam_ComputeShader_Int32_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetComputeConstantBufferParam(UnityEngine.ComputeShader, System.String, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetComputeConstantBufferParam_ComputeShader_String_ComputeBuffer_Int32_Int32;
		public virtual RMethod RSetComputeConstantBufferParam_ComputeShader_String_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_RSetComputeConstantBufferParam_ComputeShader_String_ComputeBuffer_Int32_Int32 == null)
				{
					r_RSetComputeConstantBufferParam_ComputeShader_String_ComputeBuffer_Int32_Int32 = new(this, "SetComputeConstantBufferParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.String), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
					r_RSetComputeConstantBufferParam_ComputeShader_String_ComputeBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetComputeConstantBufferParam_ComputeShader_String_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetComputeConstantBufferParam(UnityEngine.ComputeShader, Int32, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetComputeConstantBufferParam_ComputeShader_Int32_GraphicsBuffer_Int32_Int32;
		public virtual RMethod RSetComputeConstantBufferParam_ComputeShader_Int32_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_RSetComputeConstantBufferParam_ComputeShader_Int32_GraphicsBuffer_Int32_Int32 == null)
				{
					r_RSetComputeConstantBufferParam_ComputeShader_Int32_GraphicsBuffer_Int32_Int32 = new(this, "SetComputeConstantBufferParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
					r_RSetComputeConstantBufferParam_ComputeShader_Int32_GraphicsBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetComputeConstantBufferParam_ComputeShader_Int32_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetComputeConstantBufferParam(UnityEngine.ComputeShader, System.String, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetComputeConstantBufferParam_ComputeShader_String_GraphicsBuffer_Int32_Int32;
		public virtual RMethod RSetComputeConstantBufferParam_ComputeShader_String_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_RSetComputeConstantBufferParam_ComputeShader_String_GraphicsBuffer_Int32_Int32 == null)
				{
					r_RSetComputeConstantBufferParam_ComputeShader_String_GraphicsBuffer_Int32_Int32 = new(this, "SetComputeConstantBufferParam", 0, typeof(UnityEngine.ComputeShader), typeof(System.String), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
					r_RSetComputeConstantBufferParam_ComputeShader_String_GraphicsBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetComputeConstantBufferParam_ComputeShader_String_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetComputeParamsFromMaterial(UnityEngine.ComputeShader, Int32, UnityEngine.Material)
		/// </summary>
		protected RMethod r_RSetComputeParamsFromMaterial_ComputeShader_Int32_Material;
		public virtual RMethod RSetComputeParamsFromMaterial_ComputeShader_Int32_Material
		{
			get
			{
				if(r_RSetComputeParamsFromMaterial_ComputeShader_Int32_Material == null)
				{
					r_RSetComputeParamsFromMaterial_ComputeShader_Int32_Material = new(this, "SetComputeParamsFromMaterial", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(UnityEngine.Material));
					r_RSetComputeParamsFromMaterial_ComputeShader_Int32_Material.SetBelong(this.instance);
				}
				return r_RSetComputeParamsFromMaterial_ComputeShader_Int32_Material;
			}
		}

		/// <summary>
		/// Void DispatchCompute(UnityEngine.ComputeShader, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RDispatchCompute_ComputeShader_Int32_Int32_Int32_Int32;
		public virtual RMethod RDispatchCompute_ComputeShader_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_RDispatchCompute_ComputeShader_Int32_Int32_Int32_Int32 == null)
				{
					r_RDispatchCompute_ComputeShader_Int32_Int32_Int32_Int32 = new(this, "DispatchCompute", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RDispatchCompute_ComputeShader_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RDispatchCompute_ComputeShader_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void DispatchCompute(UnityEngine.ComputeShader, Int32, UnityEngine.ComputeBuffer, UInt32)
		/// </summary>
		protected RMethod r_RDispatchCompute_ComputeShader_Int32_ComputeBuffer_UInt32;
		public virtual RMethod RDispatchCompute_ComputeShader_Int32_ComputeBuffer_UInt32
		{
			get
			{
				if(r_RDispatchCompute_ComputeShader_Int32_ComputeBuffer_UInt32 == null)
				{
					r_RDispatchCompute_ComputeShader_Int32_ComputeBuffer_UInt32 = new(this, "DispatchCompute", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.UInt32));
					r_RDispatchCompute_ComputeShader_Int32_ComputeBuffer_UInt32.SetBelong(this.instance);
				}
				return r_RDispatchCompute_ComputeShader_Int32_ComputeBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void DispatchCompute(UnityEngine.ComputeShader, Int32, UnityEngine.GraphicsBuffer, UInt32)
		/// </summary>
		protected RMethod r_RDispatchCompute_ComputeShader_Int32_GraphicsBuffer_UInt32;
		public virtual RMethod RDispatchCompute_ComputeShader_Int32_GraphicsBuffer_UInt32
		{
			get
			{
				if(r_RDispatchCompute_ComputeShader_Int32_GraphicsBuffer_UInt32 == null)
				{
					r_RDispatchCompute_ComputeShader_Int32_GraphicsBuffer_UInt32 = new(this, "DispatchCompute", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32));
					r_RDispatchCompute_ComputeShader_Int32_GraphicsBuffer_UInt32.SetBelong(this.instance);
				}
				return r_RDispatchCompute_ComputeShader_Int32_GraphicsBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void BuildRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure)
		/// </summary>
		protected RMethod r_RBuildRayTracingAccelerationStructure_RayTracingAccelerationStructure;
		public virtual RMethod RBuildRayTracingAccelerationStructure_RayTracingAccelerationStructure
		{
			get
			{
				if(r_RBuildRayTracingAccelerationStructure_RayTracingAccelerationStructure == null)
				{
					r_RBuildRayTracingAccelerationStructure_RayTracingAccelerationStructure = new(this, "BuildRayTracingAccelerationStructure", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure));
					r_RBuildRayTracingAccelerationStructure_RayTracingAccelerationStructure.SetBelong(this.instance);
				}
				return r_RBuildRayTracingAccelerationStructure_RayTracingAccelerationStructure;
			}
		}

		/// <summary>
		/// Void BuildRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure, UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RBuildRayTracingAccelerationStructure_RayTracingAccelerationStructure_Vector3;
		public virtual RMethod RBuildRayTracingAccelerationStructure_RayTracingAccelerationStructure_Vector3
		{
			get
			{
				if(r_RBuildRayTracingAccelerationStructure_RayTracingAccelerationStructure_Vector3 == null)
				{
					r_RBuildRayTracingAccelerationStructure_RayTracingAccelerationStructure_Vector3 = new(this, "BuildRayTracingAccelerationStructure", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure), typeof(UnityEngine.Vector3));
					r_RBuildRayTracingAccelerationStructure_RayTracingAccelerationStructure_Vector3.SetBelong(this.instance);
				}
				return r_RBuildRayTracingAccelerationStructure_RayTracingAccelerationStructure_Vector3;
			}
		}

		/// <summary>
		/// Void SetRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingShader, System.String, UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure)
		/// </summary>
		protected RMethod r_RSetRayTracingAccelerationStructure_RayTracingShader_String_RayTracingAccelerationStructure;
		public virtual RMethod RSetRayTracingAccelerationStructure_RayTracingShader_String_RayTracingAccelerationStructure
		{
			get
			{
				if(r_RSetRayTracingAccelerationStructure_RayTracingShader_String_RayTracingAccelerationStructure == null)
				{
					r_RSetRayTracingAccelerationStructure_RayTracingShader_String_RayTracingAccelerationStructure = new(this, "SetRayTracingAccelerationStructure", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.String), typeof(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure));
					r_RSetRayTracingAccelerationStructure_RayTracingShader_String_RayTracingAccelerationStructure.SetBelong(this.instance);
				}
				return r_RSetRayTracingAccelerationStructure_RayTracingShader_String_RayTracingAccelerationStructure;
			}
		}

		/// <summary>
		/// Void SetRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure)
		/// </summary>
		protected RMethod r_RSetRayTracingAccelerationStructure_RayTracingShader_Int32_RayTracingAccelerationStructure;
		public virtual RMethod RSetRayTracingAccelerationStructure_RayTracingShader_Int32_RayTracingAccelerationStructure
		{
			get
			{
				if(r_RSetRayTracingAccelerationStructure_RayTracingShader_Int32_RayTracingAccelerationStructure == null)
				{
					r_RSetRayTracingAccelerationStructure_RayTracingShader_Int32_RayTracingAccelerationStructure = new(this, "SetRayTracingAccelerationStructure", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure));
					r_RSetRayTracingAccelerationStructure_RayTracingShader_Int32_RayTracingAccelerationStructure.SetBelong(this.instance);
				}
				return r_RSetRayTracingAccelerationStructure_RayTracingShader_Int32_RayTracingAccelerationStructure;
			}
		}

		/// <summary>
		/// Void SetRayTracingBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader, System.String, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_RSetRayTracingBufferParam_RayTracingShader_String_ComputeBuffer;
		public virtual RMethod RSetRayTracingBufferParam_RayTracingShader_String_ComputeBuffer
		{
			get
			{
				if(r_RSetRayTracingBufferParam_RayTracingShader_String_ComputeBuffer == null)
				{
					r_RSetRayTracingBufferParam_RayTracingShader_String_ComputeBuffer = new(this, "SetRayTracingBufferParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.String), typeof(UnityEngine.ComputeBuffer));
					r_RSetRayTracingBufferParam_RayTracingShader_String_ComputeBuffer.SetBelong(this.instance);
				}
				return r_RSetRayTracingBufferParam_RayTracingShader_String_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetRayTracingBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_RSetRayTracingBufferParam_RayTracingShader_Int32_ComputeBuffer;
		public virtual RMethod RSetRayTracingBufferParam_RayTracingShader_Int32_ComputeBuffer
		{
			get
			{
				if(r_RSetRayTracingBufferParam_RayTracingShader_Int32_ComputeBuffer == null)
				{
					r_RSetRayTracingBufferParam_RayTracingShader_Int32_ComputeBuffer = new(this, "SetRayTracingBufferParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
					r_RSetRayTracingBufferParam_RayTracingShader_Int32_ComputeBuffer.SetBelong(this.instance);
				}
				return r_RSetRayTracingBufferParam_RayTracingShader_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetRayTracingConstantBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetRayTracingConstantBufferParam_RayTracingShader_Int32_ComputeBuffer_Int32_Int32;
		public virtual RMethod RSetRayTracingConstantBufferParam_RayTracingShader_Int32_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_RSetRayTracingConstantBufferParam_RayTracingShader_Int32_ComputeBuffer_Int32_Int32 == null)
				{
					r_RSetRayTracingConstantBufferParam_RayTracingShader_Int32_ComputeBuffer_Int32_Int32 = new(this, "SetRayTracingConstantBufferParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
					r_RSetRayTracingConstantBufferParam_RayTracingShader_Int32_ComputeBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetRayTracingConstantBufferParam_RayTracingShader_Int32_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetRayTracingConstantBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader, System.String, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetRayTracingConstantBufferParam_RayTracingShader_String_ComputeBuffer_Int32_Int32;
		public virtual RMethod RSetRayTracingConstantBufferParam_RayTracingShader_String_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_RSetRayTracingConstantBufferParam_RayTracingShader_String_ComputeBuffer_Int32_Int32 == null)
				{
					r_RSetRayTracingConstantBufferParam_RayTracingShader_String_ComputeBuffer_Int32_Int32 = new(this, "SetRayTracingConstantBufferParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.String), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
					r_RSetRayTracingConstantBufferParam_RayTracingShader_String_ComputeBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetRayTracingConstantBufferParam_RayTracingShader_String_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetRayTracingConstantBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetRayTracingConstantBufferParam_RayTracingShader_Int32_GraphicsBuffer_Int32_Int32;
		public virtual RMethod RSetRayTracingConstantBufferParam_RayTracingShader_Int32_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_RSetRayTracingConstantBufferParam_RayTracingShader_Int32_GraphicsBuffer_Int32_Int32 == null)
				{
					r_RSetRayTracingConstantBufferParam_RayTracingShader_Int32_GraphicsBuffer_Int32_Int32 = new(this, "SetRayTracingConstantBufferParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
					r_RSetRayTracingConstantBufferParam_RayTracingShader_Int32_GraphicsBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetRayTracingConstantBufferParam_RayTracingShader_Int32_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetRayTracingConstantBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader, System.String, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetRayTracingConstantBufferParam_RayTracingShader_String_GraphicsBuffer_Int32_Int32;
		public virtual RMethod RSetRayTracingConstantBufferParam_RayTracingShader_String_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_RSetRayTracingConstantBufferParam_RayTracingShader_String_GraphicsBuffer_Int32_Int32 == null)
				{
					r_RSetRayTracingConstantBufferParam_RayTracingShader_String_GraphicsBuffer_Int32_Int32 = new(this, "SetRayTracingConstantBufferParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.String), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
					r_RSetRayTracingConstantBufferParam_RayTracingShader_String_GraphicsBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetRayTracingConstantBufferParam_RayTracingShader_String_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetRayTracingTextureParam(UnityEngine.Experimental.Rendering.RayTracingShader, System.String, UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_RSetRayTracingTextureParam_RayTracingShader_String_RenderTargetIdentifier;
		public virtual RMethod RSetRayTracingTextureParam_RayTracingShader_String_RenderTargetIdentifier
		{
			get
			{
				if(r_RSetRayTracingTextureParam_RayTracingShader_String_RenderTargetIdentifier == null)
				{
					r_RSetRayTracingTextureParam_RayTracingShader_String_RenderTargetIdentifier = new(this, "SetRayTracingTextureParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.String), typeof(UnityEngine.Rendering.RenderTargetIdentifier));
					r_RSetRayTracingTextureParam_RayTracingShader_String_RenderTargetIdentifier.SetBelong(this.instance);
				}
				return r_RSetRayTracingTextureParam_RayTracingShader_String_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void SetRayTracingTextureParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_RSetRayTracingTextureParam_RayTracingShader_Int32_RenderTargetIdentifier;
		public virtual RMethod RSetRayTracingTextureParam_RayTracingShader_Int32_RenderTargetIdentifier
		{
			get
			{
				if(r_RSetRayTracingTextureParam_RayTracingShader_Int32_RenderTargetIdentifier == null)
				{
					r_RSetRayTracingTextureParam_RayTracingShader_Int32_RenderTargetIdentifier = new(this, "SetRayTracingTextureParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier));
					r_RSetRayTracingTextureParam_RayTracingShader_Int32_RenderTargetIdentifier.SetBelong(this.instance);
				}
				return r_RSetRayTracingTextureParam_RayTracingShader_Int32_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void SetRayTracingFloatParam(UnityEngine.Experimental.Rendering.RayTracingShader, System.String, Single)
		/// </summary>
		protected RMethod r_RSetRayTracingFloatParam_RayTracingShader_String_Single;
		public virtual RMethod RSetRayTracingFloatParam_RayTracingShader_String_Single
		{
			get
			{
				if(r_RSetRayTracingFloatParam_RayTracingShader_String_Single == null)
				{
					r_RSetRayTracingFloatParam_RayTracingShader_String_Single = new(this, "SetRayTracingFloatParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.String), typeof(System.Single));
					r_RSetRayTracingFloatParam_RayTracingShader_String_Single.SetBelong(this.instance);
				}
				return r_RSetRayTracingFloatParam_RayTracingShader_String_Single;
			}
		}

		/// <summary>
		/// Void SetRayTracingFloatParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, Single)
		/// </summary>
		protected RMethod r_RSetRayTracingFloatParam_RayTracingShader_Int32_Single;
		public virtual RMethod RSetRayTracingFloatParam_RayTracingShader_Int32_Single
		{
			get
			{
				if(r_RSetRayTracingFloatParam_RayTracingShader_Int32_Single == null)
				{
					r_RSetRayTracingFloatParam_RayTracingShader_Int32_Single = new(this, "SetRayTracingFloatParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(System.Single));
					r_RSetRayTracingFloatParam_RayTracingShader_Int32_Single.SetBelong(this.instance);
				}
				return r_RSetRayTracingFloatParam_RayTracingShader_Int32_Single;
			}
		}

		/// <summary>
		/// Void SetRayTracingFloatParams(UnityEngine.Experimental.Rendering.RayTracingShader, System.String, Single[])
		/// </summary>
		protected RMethod r_RSetRayTracingFloatParams_RayTracingShader_String_SingleArray;
		public virtual RMethod RSetRayTracingFloatParams_RayTracingShader_String_SingleArray
		{
			get
			{
				if(r_RSetRayTracingFloatParams_RayTracingShader_String_SingleArray == null)
				{
					r_RSetRayTracingFloatParams_RayTracingShader_String_SingleArray = new(this, "SetRayTracingFloatParams", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.String), typeof(System.Single).MakeArrayType());
					r_RSetRayTracingFloatParams_RayTracingShader_String_SingleArray.SetBelong(this.instance);
				}
				return r_RSetRayTracingFloatParams_RayTracingShader_String_SingleArray;
			}
		}

		/// <summary>
		/// Void SetRayTracingFloatParams(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, Single[])
		/// </summary>
		protected RMethod r_RSetRayTracingFloatParams_RayTracingShader_Int32_SingleArray;
		public virtual RMethod RSetRayTracingFloatParams_RayTracingShader_Int32_SingleArray
		{
			get
			{
				if(r_RSetRayTracingFloatParams_RayTracingShader_Int32_SingleArray == null)
				{
					r_RSetRayTracingFloatParams_RayTracingShader_Int32_SingleArray = new(this, "SetRayTracingFloatParams", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(System.Single).MakeArrayType());
					r_RSetRayTracingFloatParams_RayTracingShader_Int32_SingleArray.SetBelong(this.instance);
				}
				return r_RSetRayTracingFloatParams_RayTracingShader_Int32_SingleArray;
			}
		}

		/// <summary>
		/// Void SetRayTracingIntParam(UnityEngine.Experimental.Rendering.RayTracingShader, System.String, Int32)
		/// </summary>
		protected RMethod r_RSetRayTracingIntParam_RayTracingShader_String_Int32;
		public virtual RMethod RSetRayTracingIntParam_RayTracingShader_String_Int32
		{
			get
			{
				if(r_RSetRayTracingIntParam_RayTracingShader_String_Int32 == null)
				{
					r_RSetRayTracingIntParam_RayTracingShader_String_Int32 = new(this, "SetRayTracingIntParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.String), typeof(System.Int32));
					r_RSetRayTracingIntParam_RayTracingShader_String_Int32.SetBelong(this.instance);
				}
				return r_RSetRayTracingIntParam_RayTracingShader_String_Int32;
			}
		}

		/// <summary>
		/// Void SetRayTracingIntParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetRayTracingIntParam_RayTracingShader_Int32_Int32;
		public virtual RMethod RSetRayTracingIntParam_RayTracingShader_Int32_Int32
		{
			get
			{
				if(r_RSetRayTracingIntParam_RayTracingShader_Int32_Int32 == null)
				{
					r_RSetRayTracingIntParam_RayTracingShader_Int32_Int32 = new(this, "SetRayTracingIntParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(System.Int32));
					r_RSetRayTracingIntParam_RayTracingShader_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetRayTracingIntParam_RayTracingShader_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetRayTracingIntParams(UnityEngine.Experimental.Rendering.RayTracingShader, System.String, Int32[])
		/// </summary>
		protected RMethod r_RSetRayTracingIntParams_RayTracingShader_String_Int32Array;
		public virtual RMethod RSetRayTracingIntParams_RayTracingShader_String_Int32Array
		{
			get
			{
				if(r_RSetRayTracingIntParams_RayTracingShader_String_Int32Array == null)
				{
					r_RSetRayTracingIntParams_RayTracingShader_String_Int32Array = new(this, "SetRayTracingIntParams", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.String), typeof(System.Int32).MakeArrayType());
					r_RSetRayTracingIntParams_RayTracingShader_String_Int32Array.SetBelong(this.instance);
				}
				return r_RSetRayTracingIntParams_RayTracingShader_String_Int32Array;
			}
		}

		/// <summary>
		/// Void SetRayTracingIntParams(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, Int32[])
		/// </summary>
		protected RMethod r_RSetRayTracingIntParams_RayTracingShader_Int32_Int32Array;
		public virtual RMethod RSetRayTracingIntParams_RayTracingShader_Int32_Int32Array
		{
			get
			{
				if(r_RSetRayTracingIntParams_RayTracingShader_Int32_Int32Array == null)
				{
					r_RSetRayTracingIntParams_RayTracingShader_Int32_Int32Array = new(this, "SetRayTracingIntParams", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(System.Int32).MakeArrayType());
					r_RSetRayTracingIntParams_RayTracingShader_Int32_Int32Array.SetBelong(this.instance);
				}
				return r_RSetRayTracingIntParams_RayTracingShader_Int32_Int32Array;
			}
		}

		/// <summary>
		/// Void SetRayTracingVectorParam(UnityEngine.Experimental.Rendering.RayTracingShader, System.String, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_RSetRayTracingVectorParam_RayTracingShader_String_Vector4;
		public virtual RMethod RSetRayTracingVectorParam_RayTracingShader_String_Vector4
		{
			get
			{
				if(r_RSetRayTracingVectorParam_RayTracingShader_String_Vector4 == null)
				{
					r_RSetRayTracingVectorParam_RayTracingShader_String_Vector4 = new(this, "SetRayTracingVectorParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.String), typeof(UnityEngine.Vector4));
					r_RSetRayTracingVectorParam_RayTracingShader_String_Vector4.SetBelong(this.instance);
				}
				return r_RSetRayTracingVectorParam_RayTracingShader_String_Vector4;
			}
		}

		/// <summary>
		/// Void SetRayTracingVectorParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_RSetRayTracingVectorParam_RayTracingShader_Int32_Vector4;
		public virtual RMethod RSetRayTracingVectorParam_RayTracingShader_Int32_Vector4
		{
			get
			{
				if(r_RSetRayTracingVectorParam_RayTracingShader_Int32_Vector4 == null)
				{
					r_RSetRayTracingVectorParam_RayTracingShader_Int32_Vector4 = new(this, "SetRayTracingVectorParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.Vector4));
					r_RSetRayTracingVectorParam_RayTracingShader_Int32_Vector4.SetBelong(this.instance);
				}
				return r_RSetRayTracingVectorParam_RayTracingShader_Int32_Vector4;
			}
		}

		/// <summary>
		/// Void SetRayTracingVectorArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader, System.String, UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_RSetRayTracingVectorArrayParam_RayTracingShader_String_Vector4Array;
		public virtual RMethod RSetRayTracingVectorArrayParam_RayTracingShader_String_Vector4Array
		{
			get
			{
				if(r_RSetRayTracingVectorArrayParam_RayTracingShader_String_Vector4Array == null)
				{
					r_RSetRayTracingVectorArrayParam_RayTracingShader_String_Vector4Array = new(this, "SetRayTracingVectorArrayParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.String), typeof(UnityEngine.Vector4).MakeArrayType());
					r_RSetRayTracingVectorArrayParam_RayTracingShader_String_Vector4Array.SetBelong(this.instance);
				}
				return r_RSetRayTracingVectorArrayParam_RayTracingShader_String_Vector4Array;
			}
		}

		/// <summary>
		/// Void SetRayTracingVectorArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_RSetRayTracingVectorArrayParam_RayTracingShader_Int32_Vector4Array;
		public virtual RMethod RSetRayTracingVectorArrayParam_RayTracingShader_Int32_Vector4Array
		{
			get
			{
				if(r_RSetRayTracingVectorArrayParam_RayTracingShader_Int32_Vector4Array == null)
				{
					r_RSetRayTracingVectorArrayParam_RayTracingShader_Int32_Vector4Array = new(this, "SetRayTracingVectorArrayParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType());
					r_RSetRayTracingVectorArrayParam_RayTracingShader_Int32_Vector4Array.SetBelong(this.instance);
				}
				return r_RSetRayTracingVectorArrayParam_RayTracingShader_Int32_Vector4Array;
			}
		}

		/// <summary>
		/// Void SetRayTracingMatrixParam(UnityEngine.Experimental.Rendering.RayTracingShader, System.String, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_RSetRayTracingMatrixParam_RayTracingShader_String_Matrix4x4;
		public virtual RMethod RSetRayTracingMatrixParam_RayTracingShader_String_Matrix4x4
		{
			get
			{
				if(r_RSetRayTracingMatrixParam_RayTracingShader_String_Matrix4x4 == null)
				{
					r_RSetRayTracingMatrixParam_RayTracingShader_String_Matrix4x4 = new(this, "SetRayTracingMatrixParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.String), typeof(UnityEngine.Matrix4x4));
					r_RSetRayTracingMatrixParam_RayTracingShader_String_Matrix4x4.SetBelong(this.instance);
				}
				return r_RSetRayTracingMatrixParam_RayTracingShader_String_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetRayTracingMatrixParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_RSetRayTracingMatrixParam_RayTracingShader_Int32_Matrix4x4;
		public virtual RMethod RSetRayTracingMatrixParam_RayTracingShader_Int32_Matrix4x4
		{
			get
			{
				if(r_RSetRayTracingMatrixParam_RayTracingShader_Int32_Matrix4x4 == null)
				{
					r_RSetRayTracingMatrixParam_RayTracingShader_Int32_Matrix4x4 = new(this, "SetRayTracingMatrixParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.Matrix4x4));
					r_RSetRayTracingMatrixParam_RayTracingShader_Int32_Matrix4x4.SetBelong(this.instance);
				}
				return r_RSetRayTracingMatrixParam_RayTracingShader_Int32_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetRayTracingMatrixArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader, System.String, UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_RSetRayTracingMatrixArrayParam_RayTracingShader_String_Matrix4x4Array;
		public virtual RMethod RSetRayTracingMatrixArrayParam_RayTracingShader_String_Matrix4x4Array
		{
			get
			{
				if(r_RSetRayTracingMatrixArrayParam_RayTracingShader_String_Matrix4x4Array == null)
				{
					r_RSetRayTracingMatrixArrayParam_RayTracingShader_String_Matrix4x4Array = new(this, "SetRayTracingMatrixArrayParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.String), typeof(UnityEngine.Matrix4x4).MakeArrayType());
					r_RSetRayTracingMatrixArrayParam_RayTracingShader_String_Matrix4x4Array.SetBelong(this.instance);
				}
				return r_RSetRayTracingMatrixArrayParam_RayTracingShader_String_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Void SetRayTracingMatrixArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_RSetRayTracingMatrixArrayParam_RayTracingShader_Int32_Matrix4x4Array;
		public virtual RMethod RSetRayTracingMatrixArrayParam_RayTracingShader_Int32_Matrix4x4Array
		{
			get
			{
				if(r_RSetRayTracingMatrixArrayParam_RayTracingShader_Int32_Matrix4x4Array == null)
				{
					r_RSetRayTracingMatrixArrayParam_RayTracingShader_Int32_Matrix4x4Array = new(this, "SetRayTracingMatrixArrayParam", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType());
					r_RSetRayTracingMatrixArrayParam_RayTracingShader_Int32_Matrix4x4Array.SetBelong(this.instance);
				}
				return r_RSetRayTracingMatrixArrayParam_RayTracingShader_Int32_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Void DispatchRays(UnityEngine.Experimental.Rendering.RayTracingShader, System.String, UInt32, UInt32, UInt32, UnityEngine.Camera)
		/// </summary>
		protected RMethod r_RDispatchRays_RayTracingShader_String_UInt32_UInt32_UInt32_Camera;
		public virtual RMethod RDispatchRays_RayTracingShader_String_UInt32_UInt32_UInt32_Camera
		{
			get
			{
				if(r_RDispatchRays_RayTracingShader_String_UInt32_UInt32_UInt32_Camera == null)
				{
					r_RDispatchRays_RayTracingShader_String_UInt32_UInt32_UInt32_Camera = new(this, "DispatchRays", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.String), typeof(System.UInt32), typeof(System.UInt32), typeof(System.UInt32), typeof(UnityEngine.Camera));
					r_RDispatchRays_RayTracingShader_String_UInt32_UInt32_UInt32_Camera.SetBelong(this.instance);
				}
				return r_RDispatchRays_RayTracingShader_String_UInt32_UInt32_UInt32_Camera;
			}
		}

		/// <summary>
		/// Void GenerateMips(UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_RGenerateMips_RenderTargetIdentifier;
		public virtual RMethod RGenerateMips_RenderTargetIdentifier
		{
			get
			{
				if(r_RGenerateMips_RenderTargetIdentifier == null)
				{
					r_RGenerateMips_RenderTargetIdentifier = new(this, "GenerateMips", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier));
					r_RGenerateMips_RenderTargetIdentifier.SetBelong(this.instance);
				}
				return r_RGenerateMips_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void GenerateMips(UnityEngine.RenderTexture)
		/// </summary>
		protected RMethod r_RGenerateMips_RenderTexture;
		public virtual RMethod RGenerateMips_RenderTexture
		{
			get
			{
				if(r_RGenerateMips_RenderTexture == null)
				{
					r_RGenerateMips_RenderTexture = new(this, "GenerateMips", 0, typeof(UnityEngine.RenderTexture));
					r_RGenerateMips_RenderTexture.SetBelong(this.instance);
				}
				return r_RGenerateMips_RenderTexture;
			}
		}

		/// <summary>
		/// Void ResolveAntiAliasedSurface(UnityEngine.RenderTexture, UnityEngine.RenderTexture)
		/// </summary>
		protected RMethod r_RResolveAntiAliasedSurface_RenderTexture_RenderTexture;
		public virtual RMethod RResolveAntiAliasedSurface_RenderTexture_RenderTexture
		{
			get
			{
				if(r_RResolveAntiAliasedSurface_RenderTexture_RenderTexture == null)
				{
					r_RResolveAntiAliasedSurface_RenderTexture_RenderTexture = new(this, "ResolveAntiAliasedSurface", 0, typeof(UnityEngine.RenderTexture), typeof(UnityEngine.RenderTexture));
					r_RResolveAntiAliasedSurface_RenderTexture_RenderTexture.SetBelong(this.instance);
				}
				return r_RResolveAntiAliasedSurface_RenderTexture_RenderTexture;
			}
		}

		/// <summary>
		/// Void DrawMesh(UnityEngine.Mesh, UnityEngine.Matrix4x4, UnityEngine.Material, Int32, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_RDrawMesh_Mesh_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock;
		public virtual RMethod RDrawMesh_Mesh_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_RDrawMesh_Mesh_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock == null)
				{
					r_RDrawMesh_Mesh_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock = new(this, "DrawMesh", 0, typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
					r_RDrawMesh_Mesh_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_RDrawMesh_Mesh_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void DrawMesh(UnityEngine.Mesh, UnityEngine.Matrix4x4, UnityEngine.Material, Int32, Int32)
		/// </summary>
		protected RMethod r_RDrawMesh_Mesh_Matrix4x4_Material_Int32_Int32;
		public virtual RMethod RDrawMesh_Mesh_Matrix4x4_Material_Int32_Int32
		{
			get
			{
				if(r_RDrawMesh_Mesh_Matrix4x4_Material_Int32_Int32 == null)
				{
					r_RDrawMesh_Mesh_Matrix4x4_Material_Int32_Int32 = new(this, "DrawMesh", 0, typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(System.Int32));
					r_RDrawMesh_Mesh_Matrix4x4_Material_Int32_Int32.SetBelong(this.instance);
				}
				return r_RDrawMesh_Mesh_Matrix4x4_Material_Int32_Int32;
			}
		}

		/// <summary>
		/// Void DrawMesh(UnityEngine.Mesh, UnityEngine.Matrix4x4, UnityEngine.Material, Int32)
		/// </summary>
		protected RMethod r_RDrawMesh_Mesh_Matrix4x4_Material_Int32;
		public virtual RMethod RDrawMesh_Mesh_Matrix4x4_Material_Int32
		{
			get
			{
				if(r_RDrawMesh_Mesh_Matrix4x4_Material_Int32 == null)
				{
					r_RDrawMesh_Mesh_Matrix4x4_Material_Int32 = new(this, "DrawMesh", 0, typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32));
					r_RDrawMesh_Mesh_Matrix4x4_Material_Int32.SetBelong(this.instance);
				}
				return r_RDrawMesh_Mesh_Matrix4x4_Material_Int32;
			}
		}

		/// <summary>
		/// Void DrawMesh(UnityEngine.Mesh, UnityEngine.Matrix4x4, UnityEngine.Material)
		/// </summary>
		protected RMethod r_RDrawMesh_Mesh_Matrix4x4_Material;
		public virtual RMethod RDrawMesh_Mesh_Matrix4x4_Material
		{
			get
			{
				if(r_RDrawMesh_Mesh_Matrix4x4_Material == null)
				{
					r_RDrawMesh_Mesh_Matrix4x4_Material = new(this, "DrawMesh", 0, typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material));
					r_RDrawMesh_Mesh_Matrix4x4_Material.SetBelong(this.instance);
				}
				return r_RDrawMesh_Mesh_Matrix4x4_Material;
			}
		}

		/// <summary>
		/// Void DrawRenderer(UnityEngine.Renderer, UnityEngine.Material, Int32, Int32)
		/// </summary>
		protected RMethod r_RDrawRenderer_Renderer_Material_Int32_Int32;
		public virtual RMethod RDrawRenderer_Renderer_Material_Int32_Int32
		{
			get
			{
				if(r_RDrawRenderer_Renderer_Material_Int32_Int32 == null)
				{
					r_RDrawRenderer_Renderer_Material_Int32_Int32 = new(this, "DrawRenderer", 0, typeof(UnityEngine.Renderer), typeof(UnityEngine.Material), typeof(System.Int32), typeof(System.Int32));
					r_RDrawRenderer_Renderer_Material_Int32_Int32.SetBelong(this.instance);
				}
				return r_RDrawRenderer_Renderer_Material_Int32_Int32;
			}
		}

		/// <summary>
		/// Void DrawRenderer(UnityEngine.Renderer, UnityEngine.Material, Int32)
		/// </summary>
		protected RMethod r_RDrawRenderer_Renderer_Material_Int32;
		public virtual RMethod RDrawRenderer_Renderer_Material_Int32
		{
			get
			{
				if(r_RDrawRenderer_Renderer_Material_Int32 == null)
				{
					r_RDrawRenderer_Renderer_Material_Int32 = new(this, "DrawRenderer", 0, typeof(UnityEngine.Renderer), typeof(UnityEngine.Material), typeof(System.Int32));
					r_RDrawRenderer_Renderer_Material_Int32.SetBelong(this.instance);
				}
				return r_RDrawRenderer_Renderer_Material_Int32;
			}
		}

		/// <summary>
		/// Void DrawRenderer(UnityEngine.Renderer, UnityEngine.Material)
		/// </summary>
		protected RMethod r_RDrawRenderer_Renderer_Material;
		public virtual RMethod RDrawRenderer_Renderer_Material
		{
			get
			{
				if(r_RDrawRenderer_Renderer_Material == null)
				{
					r_RDrawRenderer_Renderer_Material = new(this, "DrawRenderer", 0, typeof(UnityEngine.Renderer), typeof(UnityEngine.Material));
					r_RDrawRenderer_Renderer_Material.SetBelong(this.instance);
				}
				return r_RDrawRenderer_Renderer_Material;
			}
		}

		/// <summary>
		/// Void DrawRendererList(UnityEngine.Rendering.RendererList)
		/// </summary>
		protected RMethod r_RDrawRendererList_RendererList;
		public virtual RMethod RDrawRendererList_RendererList
		{
			get
			{
				if(r_RDrawRendererList_RendererList == null)
				{
					r_RDrawRendererList_RendererList = new(this, "DrawRendererList", 0, typeof(UnityEngine.Rendering.RendererList));
					r_RDrawRendererList_RendererList.SetBelong(this.instance);
				}
				return r_RDrawRendererList_RendererList;
			}
		}

		/// <summary>
		/// Void DrawProcedural(UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, Int32, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_RDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock;
		public virtual RMethod RDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_RDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock == null)
				{
					r_RDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock = new(this, "DrawProcedural", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
					r_RDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_RDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void DrawProcedural(UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, Int32, Int32)
		/// </summary>
		protected RMethod r_RDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32;
		public virtual RMethod RDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32
		{
			get
			{
				if(r_RDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32 == null)
				{
					r_RDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32 = new(this, "DrawProcedural", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Int32));
					r_RDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32.SetBelong(this.instance);
				}
				return r_RDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32;
			}
		}

		/// <summary>
		/// Void DrawProcedural(UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, Int32)
		/// </summary>
		protected RMethod r_RDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32;
		public virtual RMethod RDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32
		{
			get
			{
				if(r_RDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32 == null)
				{
					r_RDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32 = new(this, "DrawProcedural", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32));
					r_RDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32.SetBelong(this.instance);
				}
				return r_RDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32;
			}
		}

		/// <summary>
		/// Void DrawProcedural(UnityEngine.GraphicsBuffer, UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, Int32, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_RDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock;
		public virtual RMethod RDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_RDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock == null)
				{
					r_RDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock = new(this, "DrawProcedural", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
					r_RDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_RDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void DrawProcedural(UnityEngine.GraphicsBuffer, UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, Int32, Int32)
		/// </summary>
		protected RMethod r_RDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32;
		public virtual RMethod RDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32
		{
			get
			{
				if(r_RDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32 == null)
				{
					r_RDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32 = new(this, "DrawProcedural", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Int32));
					r_RDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32.SetBelong(this.instance);
				}
				return r_RDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32;
			}
		}

		/// <summary>
		/// Void DrawProcedural(UnityEngine.GraphicsBuffer, UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, Int32)
		/// </summary>
		protected RMethod r_RDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32;
		public virtual RMethod RDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32
		{
			get
			{
				if(r_RDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32 == null)
				{
					r_RDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32 = new(this, "DrawProcedural", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32));
					r_RDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32.SetBelong(this.instance);
				}
				return r_RDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32;
			}
		}

		/// <summary>
		/// Void DrawProceduralIndirect(UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.ComputeBuffer, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock;
		public virtual RMethod RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock == null)
				{
					r_RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock = new(this, "DrawProceduralIndirect", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
					r_RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void DrawProceduralIndirect(UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.ComputeBuffer, Int32)
		/// </summary>
		protected RMethod r_RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32;
		public virtual RMethod RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32
		{
			get
			{
				if(r_RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32 == null)
				{
					r_RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32 = new(this, "DrawProceduralIndirect", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32));
					r_RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32.SetBelong(this.instance);
				}
				return r_RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32;
			}
		}

		/// <summary>
		/// Void DrawProceduralIndirect(UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer;
		public virtual RMethod RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer
		{
			get
			{
				if(r_RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer == null)
				{
					r_RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer = new(this, "DrawProceduralIndirect", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.ComputeBuffer));
					r_RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer.SetBelong(this.instance);
				}
				return r_RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void DrawProceduralIndirect(UnityEngine.GraphicsBuffer, UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.ComputeBuffer, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock;
		public virtual RMethod RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock == null)
				{
					r_RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock = new(this, "DrawProceduralIndirect", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
					r_RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void DrawProceduralIndirect(UnityEngine.GraphicsBuffer, UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.ComputeBuffer, Int32)
		/// </summary>
		protected RMethod r_RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32;
		public virtual RMethod RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32
		{
			get
			{
				if(r_RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32 == null)
				{
					r_RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32 = new(this, "DrawProceduralIndirect", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32));
					r_RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32.SetBelong(this.instance);
				}
				return r_RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32;
			}
		}

		/// <summary>
		/// Void DrawProceduralIndirect(UnityEngine.GraphicsBuffer, UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer;
		public virtual RMethod RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer
		{
			get
			{
				if(r_RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer == null)
				{
					r_RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer = new(this, "DrawProceduralIndirect", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.ComputeBuffer));
					r_RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer.SetBelong(this.instance);
				}
				return r_RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void DrawProceduralIndirect(UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.GraphicsBuffer, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock;
		public virtual RMethod RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock == null)
				{
					r_RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock = new(this, "DrawProceduralIndirect", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
					r_RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void DrawProceduralIndirect(UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.GraphicsBuffer, Int32)
		/// </summary>
		protected RMethod r_RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32;
		public virtual RMethod RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32
		{
			get
			{
				if(r_RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32 == null)
				{
					r_RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32 = new(this, "DrawProceduralIndirect", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32));
					r_RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32.SetBelong(this.instance);
				}
				return r_RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32;
			}
		}

		/// <summary>
		/// Void DrawProceduralIndirect(UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer;
		public virtual RMethod RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer
		{
			get
			{
				if(r_RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer == null)
				{
					r_RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer = new(this, "DrawProceduralIndirect", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.GraphicsBuffer));
					r_RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void DrawProceduralIndirect(UnityEngine.GraphicsBuffer, UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.GraphicsBuffer, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock;
		public virtual RMethod RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock == null)
				{
					r_RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock = new(this, "DrawProceduralIndirect", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
					r_RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void DrawProceduralIndirect(UnityEngine.GraphicsBuffer, UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.GraphicsBuffer, Int32)
		/// </summary>
		protected RMethod r_RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32;
		public virtual RMethod RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32
		{
			get
			{
				if(r_RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32 == null)
				{
					r_RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32 = new(this, "DrawProceduralIndirect", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32));
					r_RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32.SetBelong(this.instance);
				}
				return r_RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32;
			}
		}

		/// <summary>
		/// Void DrawProceduralIndirect(UnityEngine.GraphicsBuffer, UnityEngine.Matrix4x4, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer;
		public virtual RMethod RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer
		{
			get
			{
				if(r_RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer == null)
				{
					r_RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer = new(this, "DrawProceduralIndirect", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.GraphicsBuffer));
					r_RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void DrawMeshInstanced(UnityEngine.Mesh, Int32, UnityEngine.Material, Int32, UnityEngine.Matrix4x4[], Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_RDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32_MaterialPropertyBlock;
		public virtual RMethod RDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_RDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32_MaterialPropertyBlock == null)
				{
					r_RDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32_MaterialPropertyBlock = new(this, "DrawMeshInstanced", 0, typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType(), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
					r_RDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_RDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void DrawMeshInstanced(UnityEngine.Mesh, Int32, UnityEngine.Material, Int32, UnityEngine.Matrix4x4[], Int32)
		/// </summary>
		protected RMethod r_RDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32;
		public virtual RMethod RDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32
		{
			get
			{
				if(r_RDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32 == null)
				{
					r_RDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32 = new(this, "DrawMeshInstanced", 0, typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType(), typeof(System.Int32));
					r_RDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32.SetBelong(this.instance);
				}
				return r_RDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32;
			}
		}

		/// <summary>
		/// Void DrawMeshInstanced(UnityEngine.Mesh, Int32, UnityEngine.Material, Int32, UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_RDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array;
		public virtual RMethod RDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array
		{
			get
			{
				if(r_RDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array == null)
				{
					r_RDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array = new(this, "DrawMeshInstanced", 0, typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType());
					r_RDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array.SetBelong(this.instance);
				}
				return r_RDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Void DrawMeshInstancedProcedural(UnityEngine.Mesh, Int32, UnityEngine.Material, Int32, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_RDrawMeshInstancedProcedural_Mesh_Int32_Material_Int32_Int32_MaterialPropertyBlock;
		public virtual RMethod RDrawMeshInstancedProcedural_Mesh_Int32_Material_Int32_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_RDrawMeshInstancedProcedural_Mesh_Int32_Material_Int32_Int32_MaterialPropertyBlock == null)
				{
					r_RDrawMeshInstancedProcedural_Mesh_Int32_Material_Int32_Int32_MaterialPropertyBlock = new(this, "DrawMeshInstancedProcedural", 0, typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
					r_RDrawMeshInstancedProcedural_Mesh_Int32_Material_Int32_Int32_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_RDrawMeshInstancedProcedural_Mesh_Int32_Material_Int32_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void DrawMeshInstancedIndirect(UnityEngine.Mesh, Int32, UnityEngine.Material, Int32, UnityEngine.ComputeBuffer, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32_MaterialPropertyBlock;
		public virtual RMethod RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32_MaterialPropertyBlock == null)
				{
					r_RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32_MaterialPropertyBlock = new(this, "DrawMeshInstancedIndirect", 0, typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
					r_RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void DrawMeshInstancedIndirect(UnityEngine.Mesh, Int32, UnityEngine.Material, Int32, UnityEngine.ComputeBuffer, Int32)
		/// </summary>
		protected RMethod r_RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32;
		public virtual RMethod RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32
		{
			get
			{
				if(r_RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32 == null)
				{
					r_RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32 = new(this, "DrawMeshInstancedIndirect", 0, typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32));
					r_RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32.SetBelong(this.instance);
				}
				return r_RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32;
			}
		}

		/// <summary>
		/// Void DrawMeshInstancedIndirect(UnityEngine.Mesh, Int32, UnityEngine.Material, Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer;
		public virtual RMethod RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer
		{
			get
			{
				if(r_RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer == null)
				{
					r_RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer = new(this, "DrawMeshInstancedIndirect", 0, typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
					r_RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer.SetBelong(this.instance);
				}
				return r_RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void DrawMeshInstancedIndirect(UnityEngine.Mesh, Int32, UnityEngine.Material, Int32, UnityEngine.GraphicsBuffer, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32_MaterialPropertyBlock;
		public virtual RMethod RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32_MaterialPropertyBlock == null)
				{
					r_RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32_MaterialPropertyBlock = new(this, "DrawMeshInstancedIndirect", 0, typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
					r_RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void DrawMeshInstancedIndirect(UnityEngine.Mesh, Int32, UnityEngine.Material, Int32, UnityEngine.GraphicsBuffer, Int32)
		/// </summary>
		protected RMethod r_RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32;
		public virtual RMethod RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32
		{
			get
			{
				if(r_RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32 == null)
				{
					r_RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32 = new(this, "DrawMeshInstancedIndirect", 0, typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32));
					r_RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32.SetBelong(this.instance);
				}
				return r_RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32;
			}
		}

		/// <summary>
		/// Void DrawMeshInstancedIndirect(UnityEngine.Mesh, Int32, UnityEngine.Material, Int32, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer;
		public virtual RMethod RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer
		{
			get
			{
				if(r_RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer == null)
				{
					r_RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer = new(this, "DrawMeshInstancedIndirect", 0, typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer));
					r_RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void DrawOcclusionMesh(UnityEngine.RectInt)
		/// </summary>
		protected RMethod r_RDrawOcclusionMesh_RectInt;
		public virtual RMethod RDrawOcclusionMesh_RectInt
		{
			get
			{
				if(r_RDrawOcclusionMesh_RectInt == null)
				{
					r_RDrawOcclusionMesh_RectInt = new(this, "DrawOcclusionMesh", 0, typeof(UnityEngine.RectInt));
					r_RDrawOcclusionMesh_RectInt.SetBelong(this.instance);
				}
				return r_RDrawOcclusionMesh_RectInt;
			}
		}

		/// <summary>
		/// Void SetRandomWriteTarget(Int32, UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_RSetRandomWriteTarget_Int32_RenderTargetIdentifier;
		public virtual RMethod RSetRandomWriteTarget_Int32_RenderTargetIdentifier
		{
			get
			{
				if(r_RSetRandomWriteTarget_Int32_RenderTargetIdentifier == null)
				{
					r_RSetRandomWriteTarget_Int32_RenderTargetIdentifier = new(this, "SetRandomWriteTarget", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier));
					r_RSetRandomWriteTarget_Int32_RenderTargetIdentifier.SetBelong(this.instance);
				}
				return r_RSetRandomWriteTarget_Int32_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void SetRandomWriteTarget(Int32, UnityEngine.ComputeBuffer, Boolean)
		/// </summary>
		protected RMethod r_RSetRandomWriteTarget_Int32_ComputeBuffer_Boolean;
		public virtual RMethod RSetRandomWriteTarget_Int32_ComputeBuffer_Boolean
		{
			get
			{
				if(r_RSetRandomWriteTarget_Int32_ComputeBuffer_Boolean == null)
				{
					r_RSetRandomWriteTarget_Int32_ComputeBuffer_Boolean = new(this, "SetRandomWriteTarget", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Boolean));
					r_RSetRandomWriteTarget_Int32_ComputeBuffer_Boolean.SetBelong(this.instance);
				}
				return r_RSetRandomWriteTarget_Int32_ComputeBuffer_Boolean;
			}
		}

		/// <summary>
		/// Void SetRandomWriteTarget(Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_RSetRandomWriteTarget_Int32_ComputeBuffer;
		public virtual RMethod RSetRandomWriteTarget_Int32_ComputeBuffer
		{
			get
			{
				if(r_RSetRandomWriteTarget_Int32_ComputeBuffer == null)
				{
					r_RSetRandomWriteTarget_Int32_ComputeBuffer = new(this, "SetRandomWriteTarget", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
					r_RSetRandomWriteTarget_Int32_ComputeBuffer.SetBelong(this.instance);
				}
				return r_RSetRandomWriteTarget_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetRandomWriteTarget(Int32, UnityEngine.GraphicsBuffer, Boolean)
		/// </summary>
		protected RMethod r_RSetRandomWriteTarget_Int32_GraphicsBuffer_Boolean;
		public virtual RMethod RSetRandomWriteTarget_Int32_GraphicsBuffer_Boolean
		{
			get
			{
				if(r_RSetRandomWriteTarget_Int32_GraphicsBuffer_Boolean == null)
				{
					r_RSetRandomWriteTarget_Int32_GraphicsBuffer_Boolean = new(this, "SetRandomWriteTarget", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Boolean));
					r_RSetRandomWriteTarget_Int32_GraphicsBuffer_Boolean.SetBelong(this.instance);
				}
				return r_RSetRandomWriteTarget_Int32_GraphicsBuffer_Boolean;
			}
		}

		/// <summary>
		/// Void SetRandomWriteTarget(Int32, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_RSetRandomWriteTarget_Int32_GraphicsBuffer;
		public virtual RMethod RSetRandomWriteTarget_Int32_GraphicsBuffer
		{
			get
			{
				if(r_RSetRandomWriteTarget_Int32_GraphicsBuffer == null)
				{
					r_RSetRandomWriteTarget_Int32_GraphicsBuffer = new(this, "SetRandomWriteTarget", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer));
					r_RSetRandomWriteTarget_Int32_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_RSetRandomWriteTarget_Int32_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void CopyCounterValue(UnityEngine.ComputeBuffer, UnityEngine.ComputeBuffer, UInt32)
		/// </summary>
		protected RMethod r_RCopyCounterValue_ComputeBuffer_ComputeBuffer_UInt32;
		public virtual RMethod RCopyCounterValue_ComputeBuffer_ComputeBuffer_UInt32
		{
			get
			{
				if(r_RCopyCounterValue_ComputeBuffer_ComputeBuffer_UInt32 == null)
				{
					r_RCopyCounterValue_ComputeBuffer_ComputeBuffer_UInt32 = new(this, "CopyCounterValue", 0, typeof(UnityEngine.ComputeBuffer), typeof(UnityEngine.ComputeBuffer), typeof(System.UInt32));
					r_RCopyCounterValue_ComputeBuffer_ComputeBuffer_UInt32.SetBelong(this.instance);
				}
				return r_RCopyCounterValue_ComputeBuffer_ComputeBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void CopyCounterValue(UnityEngine.GraphicsBuffer, UnityEngine.ComputeBuffer, UInt32)
		/// </summary>
		protected RMethod r_RCopyCounterValue_GraphicsBuffer_ComputeBuffer_UInt32;
		public virtual RMethod RCopyCounterValue_GraphicsBuffer_ComputeBuffer_UInt32
		{
			get
			{
				if(r_RCopyCounterValue_GraphicsBuffer_ComputeBuffer_UInt32 == null)
				{
					r_RCopyCounterValue_GraphicsBuffer_ComputeBuffer_UInt32 = new(this, "CopyCounterValue", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.ComputeBuffer), typeof(System.UInt32));
					r_RCopyCounterValue_GraphicsBuffer_ComputeBuffer_UInt32.SetBelong(this.instance);
				}
				return r_RCopyCounterValue_GraphicsBuffer_ComputeBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void CopyCounterValue(UnityEngine.ComputeBuffer, UnityEngine.GraphicsBuffer, UInt32)
		/// </summary>
		protected RMethod r_RCopyCounterValue_ComputeBuffer_GraphicsBuffer_UInt32;
		public virtual RMethod RCopyCounterValue_ComputeBuffer_GraphicsBuffer_UInt32
		{
			get
			{
				if(r_RCopyCounterValue_ComputeBuffer_GraphicsBuffer_UInt32 == null)
				{
					r_RCopyCounterValue_ComputeBuffer_GraphicsBuffer_UInt32 = new(this, "CopyCounterValue", 0, typeof(UnityEngine.ComputeBuffer), typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32));
					r_RCopyCounterValue_ComputeBuffer_GraphicsBuffer_UInt32.SetBelong(this.instance);
				}
				return r_RCopyCounterValue_ComputeBuffer_GraphicsBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void CopyCounterValue(UnityEngine.GraphicsBuffer, UnityEngine.GraphicsBuffer, UInt32)
		/// </summary>
		protected RMethod r_RCopyCounterValue_GraphicsBuffer_GraphicsBuffer_UInt32;
		public virtual RMethod RCopyCounterValue_GraphicsBuffer_GraphicsBuffer_UInt32
		{
			get
			{
				if(r_RCopyCounterValue_GraphicsBuffer_GraphicsBuffer_UInt32 == null)
				{
					r_RCopyCounterValue_GraphicsBuffer_GraphicsBuffer_UInt32 = new(this, "CopyCounterValue", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32));
					r_RCopyCounterValue_GraphicsBuffer_GraphicsBuffer_UInt32.SetBelong(this.instance);
				}
				return r_RCopyCounterValue_GraphicsBuffer_GraphicsBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void CopyTexture(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_RCopyTexture_RenderTargetIdentifier_RenderTargetIdentifier;
		public virtual RMethod RCopyTexture_RenderTargetIdentifier_RenderTargetIdentifier
		{
			get
			{
				if(r_RCopyTexture_RenderTargetIdentifier_RenderTargetIdentifier == null)
				{
					r_RCopyTexture_RenderTargetIdentifier_RenderTargetIdentifier = new(this, "CopyTexture", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier));
					r_RCopyTexture_RenderTargetIdentifier_RenderTargetIdentifier.SetBelong(this.instance);
				}
				return r_RCopyTexture_RenderTargetIdentifier_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void CopyTexture(UnityEngine.Rendering.RenderTargetIdentifier, Int32, UnityEngine.Rendering.RenderTargetIdentifier, Int32)
		/// </summary>
		protected RMethod r_RCopyTexture_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32;
		public virtual RMethod RCopyTexture_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32
		{
			get
			{
				if(r_RCopyTexture_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32 == null)
				{
					r_RCopyTexture_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32 = new(this, "CopyTexture", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32));
					r_RCopyTexture_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32.SetBelong(this.instance);
				}
				return r_RCopyTexture_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32;
			}
		}

		/// <summary>
		/// Void CopyTexture(UnityEngine.Rendering.RenderTargetIdentifier, Int32, Int32, UnityEngine.Rendering.RenderTargetIdentifier, Int32, Int32)
		/// </summary>
		protected RMethod r_RCopyTexture_RenderTargetIdentifier_Int32_Int32_RenderTargetIdentifier_Int32_Int32;
		public virtual RMethod RCopyTexture_RenderTargetIdentifier_Int32_Int32_RenderTargetIdentifier_Int32_Int32
		{
			get
			{
				if(r_RCopyTexture_RenderTargetIdentifier_Int32_Int32_RenderTargetIdentifier_Int32_Int32 == null)
				{
					r_RCopyTexture_RenderTargetIdentifier_Int32_Int32_RenderTargetIdentifier_Int32_Int32 = new(this, "CopyTexture", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(System.Int32));
					r_RCopyTexture_RenderTargetIdentifier_Int32_Int32_RenderTargetIdentifier_Int32_Int32.SetBelong(this.instance);
				}
				return r_RCopyTexture_RenderTargetIdentifier_Int32_Int32_RenderTargetIdentifier_Int32_Int32;
			}
		}

		/// <summary>
		/// Void CopyTexture(UnityEngine.Rendering.RenderTargetIdentifier, Int32, Int32, Int32, Int32, Int32, Int32, UnityEngine.Rendering.RenderTargetIdentifier, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RCopyTexture_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32_Int32_RenderTargetIdentifier_Int32_Int32_Int32_Int32;
		public virtual RMethod RCopyTexture_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32_Int32_RenderTargetIdentifier_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_RCopyTexture_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32_Int32_RenderTargetIdentifier_Int32_Int32_Int32_Int32 == null)
				{
					r_RCopyTexture_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32_Int32_RenderTargetIdentifier_Int32_Int32_Int32_Int32 = new(this, "CopyTexture", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RCopyTexture_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32_Int32_RenderTargetIdentifier_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RCopyTexture_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32_Int32_RenderTargetIdentifier_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Blit(UnityEngine.Texture, UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_RBlit_Texture_RenderTargetIdentifier;
		public virtual RMethod RBlit_Texture_RenderTargetIdentifier
		{
			get
			{
				if(r_RBlit_Texture_RenderTargetIdentifier == null)
				{
					r_RBlit_Texture_RenderTargetIdentifier = new(this, "Blit", 0, typeof(UnityEngine.Texture), typeof(UnityEngine.Rendering.RenderTargetIdentifier));
					r_RBlit_Texture_RenderTargetIdentifier.SetBelong(this.instance);
				}
				return r_RBlit_Texture_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void Blit(UnityEngine.Texture, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RBlit_Texture_RenderTargetIdentifier_Vector2_Vector2;
		public virtual RMethod RBlit_Texture_RenderTargetIdentifier_Vector2_Vector2
		{
			get
			{
				if(r_RBlit_Texture_RenderTargetIdentifier_Vector2_Vector2 == null)
				{
					r_RBlit_Texture_RenderTargetIdentifier_Vector2_Vector2 = new(this, "Blit", 0, typeof(UnityEngine.Texture), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_RBlit_Texture_RenderTargetIdentifier_Vector2_Vector2.SetBelong(this.instance);
				}
				return r_RBlit_Texture_RenderTargetIdentifier_Vector2_Vector2;
			}
		}

		/// <summary>
		/// Void Blit(UnityEngine.Texture, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Material)
		/// </summary>
		protected RMethod r_RBlit_Texture_RenderTargetIdentifier_Material;
		public virtual RMethod RBlit_Texture_RenderTargetIdentifier_Material
		{
			get
			{
				if(r_RBlit_Texture_RenderTargetIdentifier_Material == null)
				{
					r_RBlit_Texture_RenderTargetIdentifier_Material = new(this, "Blit", 0, typeof(UnityEngine.Texture), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Material));
					r_RBlit_Texture_RenderTargetIdentifier_Material.SetBelong(this.instance);
				}
				return r_RBlit_Texture_RenderTargetIdentifier_Material;
			}
		}

		/// <summary>
		/// Void Blit(UnityEngine.Texture, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Material, Int32)
		/// </summary>
		protected RMethod r_RBlit_Texture_RenderTargetIdentifier_Material_Int32;
		public virtual RMethod RBlit_Texture_RenderTargetIdentifier_Material_Int32
		{
			get
			{
				if(r_RBlit_Texture_RenderTargetIdentifier_Material_Int32 == null)
				{
					r_RBlit_Texture_RenderTargetIdentifier_Material_Int32 = new(this, "Blit", 0, typeof(UnityEngine.Texture), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Material), typeof(System.Int32));
					r_RBlit_Texture_RenderTargetIdentifier_Material_Int32.SetBelong(this.instance);
				}
				return r_RBlit_Texture_RenderTargetIdentifier_Material_Int32;
			}
		}

		/// <summary>
		/// Void Blit(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier;
		public virtual RMethod RBlit_RenderTargetIdentifier_RenderTargetIdentifier
		{
			get
			{
				if(r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier == null)
				{
					r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier = new(this, "Blit", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier));
					r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier.SetBelong(this.instance);
				}
				return r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void Blit(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Vector2_Vector2;
		public virtual RMethod RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Vector2_Vector2
		{
			get
			{
				if(r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Vector2_Vector2 == null)
				{
					r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Vector2_Vector2 = new(this, "Blit", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Vector2_Vector2.SetBelong(this.instance);
				}
				return r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Vector2_Vector2;
			}
		}

		/// <summary>
		/// Void Blit(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Material)
		/// </summary>
		protected RMethod r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material;
		public virtual RMethod RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material
		{
			get
			{
				if(r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material == null)
				{
					r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material = new(this, "Blit", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Material));
					r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material.SetBelong(this.instance);
				}
				return r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material;
			}
		}

		/// <summary>
		/// Void Blit(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Material, Int32)
		/// </summary>
		protected RMethod r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32;
		public virtual RMethod RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32
		{
			get
			{
				if(r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32 == null)
				{
					r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32 = new(this, "Blit", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Material), typeof(System.Int32));
					r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32.SetBelong(this.instance);
				}
				return r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32;
			}
		}

		/// <summary>
		/// Void Blit(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier, Int32, Int32)
		/// </summary>
		protected RMethod r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Int32_Int32;
		public virtual RMethod RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Int32_Int32
		{
			get
			{
				if(r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Int32_Int32 == null)
				{
					r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Int32_Int32 = new(this, "Blit", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(System.Int32));
					r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Int32_Int32.SetBelong(this.instance);
				}
				return r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Blit(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Vector2, UnityEngine.Vector2, Int32, Int32)
		/// </summary>
		protected RMethod r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Vector2_Vector2_Int32_Int32;
		public virtual RMethod RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Vector2_Vector2_Int32_Int32
		{
			get
			{
				if(r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Vector2_Vector2_Int32_Int32 == null)
				{
					r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Vector2_Vector2_Int32_Int32 = new(this, "Blit", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Int32), typeof(System.Int32));
					r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Vector2_Vector2_Int32_Int32.SetBelong(this.instance);
				}
				return r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Vector2_Vector2_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Blit(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Material, Int32, Int32)
		/// </summary>
		protected RMethod r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_Int32;
		public virtual RMethod RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_Int32
		{
			get
			{
				if(r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_Int32 == null)
				{
					r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_Int32 = new(this, "Blit", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Material), typeof(System.Int32), typeof(System.Int32));
					r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_Int32.SetBelong(this.instance);
				}
				return r_RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalFloat(System.String, Single)
		/// </summary>
		protected RMethod r_RSetGlobalFloat_String_Single;
		public virtual RMethod RSetGlobalFloat_String_Single
		{
			get
			{
				if(r_RSetGlobalFloat_String_Single == null)
				{
					r_RSetGlobalFloat_String_Single = new(this, "SetGlobalFloat", 0, typeof(System.String), typeof(System.Single));
					r_RSetGlobalFloat_String_Single.SetBelong(this.instance);
				}
				return r_RSetGlobalFloat_String_Single;
			}
		}

		/// <summary>
		/// Void SetGlobalInt(System.String, Int32)
		/// </summary>
		protected RMethod r_RSetGlobalInt_String_Int32;
		public virtual RMethod RSetGlobalInt_String_Int32
		{
			get
			{
				if(r_RSetGlobalInt_String_Int32 == null)
				{
					r_RSetGlobalInt_String_Int32 = new(this, "SetGlobalInt", 0, typeof(System.String), typeof(System.Int32));
					r_RSetGlobalInt_String_Int32.SetBelong(this.instance);
				}
				return r_RSetGlobalInt_String_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalInteger(System.String, Int32)
		/// </summary>
		protected RMethod r_RSetGlobalInteger_String_Int32;
		public virtual RMethod RSetGlobalInteger_String_Int32
		{
			get
			{
				if(r_RSetGlobalInteger_String_Int32 == null)
				{
					r_RSetGlobalInteger_String_Int32 = new(this, "SetGlobalInteger", 0, typeof(System.String), typeof(System.Int32));
					r_RSetGlobalInteger_String_Int32.SetBelong(this.instance);
				}
				return r_RSetGlobalInteger_String_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalVector(System.String, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_RSetGlobalVector_String_Vector4;
		public virtual RMethod RSetGlobalVector_String_Vector4
		{
			get
			{
				if(r_RSetGlobalVector_String_Vector4 == null)
				{
					r_RSetGlobalVector_String_Vector4 = new(this, "SetGlobalVector", 0, typeof(System.String), typeof(UnityEngine.Vector4));
					r_RSetGlobalVector_String_Vector4.SetBelong(this.instance);
				}
				return r_RSetGlobalVector_String_Vector4;
			}
		}

		/// <summary>
		/// Void SetGlobalColor(System.String, UnityEngine.Color)
		/// </summary>
		protected RMethod r_RSetGlobalColor_String_Color;
		public virtual RMethod RSetGlobalColor_String_Color
		{
			get
			{
				if(r_RSetGlobalColor_String_Color == null)
				{
					r_RSetGlobalColor_String_Color = new(this, "SetGlobalColor", 0, typeof(System.String), typeof(UnityEngine.Color));
					r_RSetGlobalColor_String_Color.SetBelong(this.instance);
				}
				return r_RSetGlobalColor_String_Color;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrix(System.String, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_RSetGlobalMatrix_String_Matrix4x4;
		public virtual RMethod RSetGlobalMatrix_String_Matrix4x4
		{
			get
			{
				if(r_RSetGlobalMatrix_String_Matrix4x4 == null)
				{
					r_RSetGlobalMatrix_String_Matrix4x4 = new(this, "SetGlobalMatrix", 0, typeof(System.String), typeof(UnityEngine.Matrix4x4));
					r_RSetGlobalMatrix_String_Matrix4x4.SetBelong(this.instance);
				}
				return r_RSetGlobalMatrix_String_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetGlobalFloatArray(System.String, System.Collections.Generic.List`1[System.Single])
		/// </summary>
		protected RMethod r_RSetGlobalFloatArray_String_List_d_Single_p_;
		public virtual RMethod RSetGlobalFloatArray_String_List_d_Single_p_
		{
			get
			{
				if(r_RSetGlobalFloatArray_String_List_d_Single_p_ == null)
				{
					r_RSetGlobalFloatArray_String_List_d_Single_p_ = new(this, "SetGlobalFloatArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Single)));
					r_RSetGlobalFloatArray_String_List_d_Single_p_.SetBelong(this.instance);
				}
				return r_RSetGlobalFloatArray_String_List_d_Single_p_;
			}
		}

		/// <summary>
		/// Void SetGlobalFloatArray(Int32, System.Collections.Generic.List`1[System.Single])
		/// </summary>
		protected RMethod r_RSetGlobalFloatArray_Int32_List_d_Single_p_;
		public virtual RMethod RSetGlobalFloatArray_Int32_List_d_Single_p_
		{
			get
			{
				if(r_RSetGlobalFloatArray_Int32_List_d_Single_p_ == null)
				{
					r_RSetGlobalFloatArray_Int32_List_d_Single_p_ = new(this, "SetGlobalFloatArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Single)));
					r_RSetGlobalFloatArray_Int32_List_d_Single_p_.SetBelong(this.instance);
				}
				return r_RSetGlobalFloatArray_Int32_List_d_Single_p_;
			}
		}

		/// <summary>
		/// Void SetGlobalFloatArray(System.String, Single[])
		/// </summary>
		protected RMethod r_RSetGlobalFloatArray_String_SingleArray;
		public virtual RMethod RSetGlobalFloatArray_String_SingleArray
		{
			get
			{
				if(r_RSetGlobalFloatArray_String_SingleArray == null)
				{
					r_RSetGlobalFloatArray_String_SingleArray = new(this, "SetGlobalFloatArray", 0, typeof(System.String), typeof(System.Single).MakeArrayType());
					r_RSetGlobalFloatArray_String_SingleArray.SetBelong(this.instance);
				}
				return r_RSetGlobalFloatArray_String_SingleArray;
			}
		}

		/// <summary>
		/// Void SetGlobalVectorArray(System.String, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_RSetGlobalVectorArray_String_List_d_Vector4_p_;
		public virtual RMethod RSetGlobalVectorArray_String_List_d_Vector4_p_
		{
			get
			{
				if(r_RSetGlobalVectorArray_String_List_d_Vector4_p_ == null)
				{
					r_RSetGlobalVectorArray_String_List_d_Vector4_p_ = new(this, "SetGlobalVectorArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_RSetGlobalVectorArray_String_List_d_Vector4_p_.SetBelong(this.instance);
				}
				return r_RSetGlobalVectorArray_String_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void SetGlobalVectorArray(Int32, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_RSetGlobalVectorArray_Int32_List_d_Vector4_p_;
		public virtual RMethod RSetGlobalVectorArray_Int32_List_d_Vector4_p_
		{
			get
			{
				if(r_RSetGlobalVectorArray_Int32_List_d_Vector4_p_ == null)
				{
					r_RSetGlobalVectorArray_Int32_List_d_Vector4_p_ = new(this, "SetGlobalVectorArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_RSetGlobalVectorArray_Int32_List_d_Vector4_p_.SetBelong(this.instance);
				}
				return r_RSetGlobalVectorArray_Int32_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void SetGlobalVectorArray(System.String, UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_RSetGlobalVectorArray_String_Vector4Array;
		public virtual RMethod RSetGlobalVectorArray_String_Vector4Array
		{
			get
			{
				if(r_RSetGlobalVectorArray_String_Vector4Array == null)
				{
					r_RSetGlobalVectorArray_String_Vector4Array = new(this, "SetGlobalVectorArray", 0, typeof(System.String), typeof(UnityEngine.Vector4).MakeArrayType());
					r_RSetGlobalVectorArray_String_Vector4Array.SetBelong(this.instance);
				}
				return r_RSetGlobalVectorArray_String_Vector4Array;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrixArray(System.String, System.Collections.Generic.List`1[UnityEngine.Matrix4x4])
		/// </summary>
		protected RMethod r_RSetGlobalMatrixArray_String_List_d_Matrix4x4_p_;
		public virtual RMethod RSetGlobalMatrixArray_String_List_d_Matrix4x4_p_
		{
			get
			{
				if(r_RSetGlobalMatrixArray_String_List_d_Matrix4x4_p_ == null)
				{
					r_RSetGlobalMatrixArray_String_List_d_Matrix4x4_p_ = new(this, "SetGlobalMatrixArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Matrix4x4)));
					r_RSetGlobalMatrixArray_String_List_d_Matrix4x4_p_.SetBelong(this.instance);
				}
				return r_RSetGlobalMatrixArray_String_List_d_Matrix4x4_p_;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrixArray(Int32, System.Collections.Generic.List`1[UnityEngine.Matrix4x4])
		/// </summary>
		protected RMethod r_RSetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_;
		public virtual RMethod RSetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_
		{
			get
			{
				if(r_RSetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_ == null)
				{
					r_RSetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_ = new(this, "SetGlobalMatrixArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Matrix4x4)));
					r_RSetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_.SetBelong(this.instance);
				}
				return r_RSetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrixArray(System.String, UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_RSetGlobalMatrixArray_String_Matrix4x4Array;
		public virtual RMethod RSetGlobalMatrixArray_String_Matrix4x4Array
		{
			get
			{
				if(r_RSetGlobalMatrixArray_String_Matrix4x4Array == null)
				{
					r_RSetGlobalMatrixArray_String_Matrix4x4Array = new(this, "SetGlobalMatrixArray", 0, typeof(System.String), typeof(UnityEngine.Matrix4x4).MakeArrayType());
					r_RSetGlobalMatrixArray_String_Matrix4x4Array.SetBelong(this.instance);
				}
				return r_RSetGlobalMatrixArray_String_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Void SetGlobalTexture(System.String, UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_RSetGlobalTexture_String_RenderTargetIdentifier;
		public virtual RMethod RSetGlobalTexture_String_RenderTargetIdentifier
		{
			get
			{
				if(r_RSetGlobalTexture_String_RenderTargetIdentifier == null)
				{
					r_RSetGlobalTexture_String_RenderTargetIdentifier = new(this, "SetGlobalTexture", 0, typeof(System.String), typeof(UnityEngine.Rendering.RenderTargetIdentifier));
					r_RSetGlobalTexture_String_RenderTargetIdentifier.SetBelong(this.instance);
				}
				return r_RSetGlobalTexture_String_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void SetGlobalTexture(Int32, UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_RSetGlobalTexture_Int32_RenderTargetIdentifier;
		public virtual RMethod RSetGlobalTexture_Int32_RenderTargetIdentifier
		{
			get
			{
				if(r_RSetGlobalTexture_Int32_RenderTargetIdentifier == null)
				{
					r_RSetGlobalTexture_Int32_RenderTargetIdentifier = new(this, "SetGlobalTexture", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier));
					r_RSetGlobalTexture_Int32_RenderTargetIdentifier.SetBelong(this.instance);
				}
				return r_RSetGlobalTexture_Int32_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void SetGlobalTexture(System.String, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTextureSubElement)
		/// </summary>
		protected RMethod r_RSetGlobalTexture_String_RenderTargetIdentifier_RenderTextureSubElement;
		public virtual RMethod RSetGlobalTexture_String_RenderTargetIdentifier_RenderTextureSubElement
		{
			get
			{
				if(r_RSetGlobalTexture_String_RenderTargetIdentifier_RenderTextureSubElement == null)
				{
					r_RSetGlobalTexture_String_RenderTargetIdentifier_RenderTextureSubElement = new(this, "SetGlobalTexture", 0, typeof(System.String), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTextureSubElement));
					r_RSetGlobalTexture_String_RenderTargetIdentifier_RenderTextureSubElement.SetBelong(this.instance);
				}
				return r_RSetGlobalTexture_String_RenderTargetIdentifier_RenderTextureSubElement;
			}
		}

		/// <summary>
		/// Void SetGlobalTexture(Int32, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTextureSubElement)
		/// </summary>
		protected RMethod r_RSetGlobalTexture_Int32_RenderTargetIdentifier_RenderTextureSubElement;
		public virtual RMethod RSetGlobalTexture_Int32_RenderTargetIdentifier_RenderTextureSubElement
		{
			get
			{
				if(r_RSetGlobalTexture_Int32_RenderTargetIdentifier_RenderTextureSubElement == null)
				{
					r_RSetGlobalTexture_Int32_RenderTargetIdentifier_RenderTextureSubElement = new(this, "SetGlobalTexture", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTextureSubElement));
					r_RSetGlobalTexture_Int32_RenderTargetIdentifier_RenderTextureSubElement.SetBelong(this.instance);
				}
				return r_RSetGlobalTexture_Int32_RenderTargetIdentifier_RenderTextureSubElement;
			}
		}

		/// <summary>
		/// Void SetGlobalBuffer(System.String, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_RSetGlobalBuffer_String_ComputeBuffer;
		public virtual RMethod RSetGlobalBuffer_String_ComputeBuffer
		{
			get
			{
				if(r_RSetGlobalBuffer_String_ComputeBuffer == null)
				{
					r_RSetGlobalBuffer_String_ComputeBuffer = new(this, "SetGlobalBuffer", 0, typeof(System.String), typeof(UnityEngine.ComputeBuffer));
					r_RSetGlobalBuffer_String_ComputeBuffer.SetBelong(this.instance);
				}
				return r_RSetGlobalBuffer_String_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetGlobalBuffer(Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_RSetGlobalBuffer_Int32_ComputeBuffer;
		public virtual RMethod RSetGlobalBuffer_Int32_ComputeBuffer
		{
			get
			{
				if(r_RSetGlobalBuffer_Int32_ComputeBuffer == null)
				{
					r_RSetGlobalBuffer_Int32_ComputeBuffer = new(this, "SetGlobalBuffer", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
					r_RSetGlobalBuffer_Int32_ComputeBuffer.SetBelong(this.instance);
				}
				return r_RSetGlobalBuffer_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetGlobalBuffer(System.String, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_RSetGlobalBuffer_String_GraphicsBuffer;
		public virtual RMethod RSetGlobalBuffer_String_GraphicsBuffer
		{
			get
			{
				if(r_RSetGlobalBuffer_String_GraphicsBuffer == null)
				{
					r_RSetGlobalBuffer_String_GraphicsBuffer = new(this, "SetGlobalBuffer", 0, typeof(System.String), typeof(UnityEngine.GraphicsBuffer));
					r_RSetGlobalBuffer_String_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_RSetGlobalBuffer_String_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetGlobalBuffer(Int32, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_RSetGlobalBuffer_Int32_GraphicsBuffer;
		public virtual RMethod RSetGlobalBuffer_Int32_GraphicsBuffer
		{
			get
			{
				if(r_RSetGlobalBuffer_Int32_GraphicsBuffer == null)
				{
					r_RSetGlobalBuffer_Int32_GraphicsBuffer = new(this, "SetGlobalBuffer", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer));
					r_RSetGlobalBuffer_Int32_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_RSetGlobalBuffer_Int32_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetGlobalConstantBuffer_ComputeBuffer_Int32_Int32_Int32;
		public virtual RMethod RSetGlobalConstantBuffer_ComputeBuffer_Int32_Int32_Int32
		{
			get
			{
				if(r_RSetGlobalConstantBuffer_ComputeBuffer_Int32_Int32_Int32 == null)
				{
					r_RSetGlobalConstantBuffer_ComputeBuffer_Int32_Int32_Int32 = new(this, "SetGlobalConstantBuffer", 0, typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RSetGlobalConstantBuffer_ComputeBuffer_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetGlobalConstantBuffer_ComputeBuffer_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer, System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetGlobalConstantBuffer_ComputeBuffer_String_Int32_Int32;
		public virtual RMethod RSetGlobalConstantBuffer_ComputeBuffer_String_Int32_Int32
		{
			get
			{
				if(r_RSetGlobalConstantBuffer_ComputeBuffer_String_Int32_Int32 == null)
				{
					r_RSetGlobalConstantBuffer_ComputeBuffer_String_Int32_Int32 = new(this, "SetGlobalConstantBuffer", 0, typeof(UnityEngine.ComputeBuffer), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_RSetGlobalConstantBuffer_ComputeBuffer_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetGlobalConstantBuffer_ComputeBuffer_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetGlobalConstantBuffer_GraphicsBuffer_Int32_Int32_Int32;
		public virtual RMethod RSetGlobalConstantBuffer_GraphicsBuffer_Int32_Int32_Int32
		{
			get
			{
				if(r_RSetGlobalConstantBuffer_GraphicsBuffer_Int32_Int32_Int32 == null)
				{
					r_RSetGlobalConstantBuffer_GraphicsBuffer_Int32_Int32_Int32 = new(this, "SetGlobalConstantBuffer", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RSetGlobalConstantBuffer_GraphicsBuffer_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetGlobalConstantBuffer_GraphicsBuffer_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer, System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetGlobalConstantBuffer_GraphicsBuffer_String_Int32_Int32;
		public virtual RMethod RSetGlobalConstantBuffer_GraphicsBuffer_String_Int32_Int32
		{
			get
			{
				if(r_RSetGlobalConstantBuffer_GraphicsBuffer_String_Int32_Int32 == null)
				{
					r_RSetGlobalConstantBuffer_GraphicsBuffer_String_Int32_Int32 = new(this, "SetGlobalConstantBuffer", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_RSetGlobalConstantBuffer_GraphicsBuffer_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetGlobalConstantBuffer_GraphicsBuffer_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetShadowSamplingMode(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.ShadowSamplingMode)
		/// </summary>
		protected RMethod r_RSetShadowSamplingMode_RenderTargetIdentifier_ShadowSamplingMode;
		public virtual RMethod RSetShadowSamplingMode_RenderTargetIdentifier_ShadowSamplingMode
		{
			get
			{
				if(r_RSetShadowSamplingMode_RenderTargetIdentifier_ShadowSamplingMode == null)
				{
					r_RSetShadowSamplingMode_RenderTargetIdentifier_ShadowSamplingMode = new(this, "SetShadowSamplingMode", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.ShadowSamplingMode));
					r_RSetShadowSamplingMode_RenderTargetIdentifier_ShadowSamplingMode.SetBelong(this.instance);
				}
				return r_RSetShadowSamplingMode_RenderTargetIdentifier_ShadowSamplingMode;
			}
		}

		/// <summary>
		/// Void SetSinglePassStereo(UnityEngine.Rendering.SinglePassStereoMode)
		/// </summary>
		protected RMethod r_RSetSinglePassStereo_SinglePassStereoMode;
		public virtual RMethod RSetSinglePassStereo_SinglePassStereoMode
		{
			get
			{
				if(r_RSetSinglePassStereo_SinglePassStereoMode == null)
				{
					r_RSetSinglePassStereo_SinglePassStereoMode = new(this, "SetSinglePassStereo", 0, typeof(UnityEngine.Rendering.SinglePassStereoMode));
					r_RSetSinglePassStereo_SinglePassStereoMode.SetBelong(this.instance);
				}
				return r_RSetSinglePassStereo_SinglePassStereoMode;
			}
		}

		/// <summary>
		/// Void IssuePluginEvent(IntPtr, Int32)
		/// </summary>
		protected RMethod r_RIssuePluginEvent_IntPtr_Int32;
		public virtual RMethod RIssuePluginEvent_IntPtr_Int32
		{
			get
			{
				if(r_RIssuePluginEvent_IntPtr_Int32 == null)
				{
					r_RIssuePluginEvent_IntPtr_Int32 = new(this, "IssuePluginEvent", 0, typeof(System.IntPtr), typeof(System.Int32));
					r_RIssuePluginEvent_IntPtr_Int32.SetBelong(this.instance);
				}
				return r_RIssuePluginEvent_IntPtr_Int32;
			}
		}

		/// <summary>
		/// Void IssuePluginEventAndData(IntPtr, Int32, IntPtr)
		/// </summary>
		protected RMethod r_RIssuePluginEventAndData_IntPtr_Int32_IntPtr;
		public virtual RMethod RIssuePluginEventAndData_IntPtr_Int32_IntPtr
		{
			get
			{
				if(r_RIssuePluginEventAndData_IntPtr_Int32_IntPtr == null)
				{
					r_RIssuePluginEventAndData_IntPtr_Int32_IntPtr = new(this, "IssuePluginEventAndData", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.IntPtr));
					r_RIssuePluginEventAndData_IntPtr_Int32_IntPtr.SetBelong(this.instance);
				}
				return r_RIssuePluginEventAndData_IntPtr_Int32_IntPtr;
			}
		}

		/// <summary>
		/// Void IssuePluginEventAndDataWithFlags(IntPtr, Int32, UnityEngine.Rendering.CustomMarkerCallbackFlags, IntPtr)
		/// </summary>
		protected RMethod r_RIssuePluginEventAndDataWithFlags_IntPtr_Int32_CustomMarkerCallbackFlags_IntPtr;
		public virtual RMethod RIssuePluginEventAndDataWithFlags_IntPtr_Int32_CustomMarkerCallbackFlags_IntPtr
		{
			get
			{
				if(r_RIssuePluginEventAndDataWithFlags_IntPtr_Int32_CustomMarkerCallbackFlags_IntPtr == null)
				{
					r_RIssuePluginEventAndDataWithFlags_IntPtr_Int32_CustomMarkerCallbackFlags_IntPtr = new(this, "IssuePluginEventAndDataWithFlags", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(UnityEngine.Rendering.CustomMarkerCallbackFlags), typeof(System.IntPtr));
					r_RIssuePluginEventAndDataWithFlags_IntPtr_Int32_CustomMarkerCallbackFlags_IntPtr.SetBelong(this.instance);
				}
				return r_RIssuePluginEventAndDataWithFlags_IntPtr_Int32_CustomMarkerCallbackFlags_IntPtr;
			}
		}

		/// <summary>
		/// Void IssuePluginCustomBlit(IntPtr, UInt32, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier, UInt32, UInt32)
		/// </summary>
		protected RMethod r_RIssuePluginCustomBlit_IntPtr_UInt32_RenderTargetIdentifier_RenderTargetIdentifier_UInt32_UInt32;
		public virtual RMethod RIssuePluginCustomBlit_IntPtr_UInt32_RenderTargetIdentifier_RenderTargetIdentifier_UInt32_UInt32
		{
			get
			{
				if(r_RIssuePluginCustomBlit_IntPtr_UInt32_RenderTargetIdentifier_RenderTargetIdentifier_UInt32_UInt32 == null)
				{
					r_RIssuePluginCustomBlit_IntPtr_UInt32_RenderTargetIdentifier_RenderTargetIdentifier_UInt32_UInt32 = new(this, "IssuePluginCustomBlit", 0, typeof(System.IntPtr), typeof(System.UInt32), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.UInt32), typeof(System.UInt32));
					r_RIssuePluginCustomBlit_IntPtr_UInt32_RenderTargetIdentifier_RenderTargetIdentifier_UInt32_UInt32.SetBelong(this.instance);
				}
				return r_RIssuePluginCustomBlit_IntPtr_UInt32_RenderTargetIdentifier_RenderTargetIdentifier_UInt32_UInt32;
			}
		}

		/// <summary>
		/// Void IssuePluginCustomTextureUpdate(IntPtr, UnityEngine.Texture, UInt32)
		/// </summary>
		protected RMethod r_RIssuePluginCustomTextureUpdate_IntPtr_Texture_UInt32;
		public virtual RMethod RIssuePluginCustomTextureUpdate_IntPtr_Texture_UInt32
		{
			get
			{
				if(r_RIssuePluginCustomTextureUpdate_IntPtr_Texture_UInt32 == null)
				{
					r_RIssuePluginCustomTextureUpdate_IntPtr_Texture_UInt32 = new(this, "IssuePluginCustomTextureUpdate", 0, typeof(System.IntPtr), typeof(UnityEngine.Texture), typeof(System.UInt32));
					r_RIssuePluginCustomTextureUpdate_IntPtr_Texture_UInt32.SetBelong(this.instance);
				}
				return r_RIssuePluginCustomTextureUpdate_IntPtr_Texture_UInt32;
			}
		}

		/// <summary>
		/// Void IssuePluginCustomTextureUpdateV1(IntPtr, UnityEngine.Texture, UInt32)
		/// </summary>
		protected RMethod r_RIssuePluginCustomTextureUpdateV1_IntPtr_Texture_UInt32;
		public virtual RMethod RIssuePluginCustomTextureUpdateV1_IntPtr_Texture_UInt32
		{
			get
			{
				if(r_RIssuePluginCustomTextureUpdateV1_IntPtr_Texture_UInt32 == null)
				{
					r_RIssuePluginCustomTextureUpdateV1_IntPtr_Texture_UInt32 = new(this, "IssuePluginCustomTextureUpdateV1", 0, typeof(System.IntPtr), typeof(UnityEngine.Texture), typeof(System.UInt32));
					r_RIssuePluginCustomTextureUpdateV1_IntPtr_Texture_UInt32.SetBelong(this.instance);
				}
				return r_RIssuePluginCustomTextureUpdateV1_IntPtr_Texture_UInt32;
			}
		}

		/// <summary>
		/// Void IssuePluginCustomTextureUpdateV2(IntPtr, UnityEngine.Texture, UInt32)
		/// </summary>
		protected RMethod r_RIssuePluginCustomTextureUpdateV2_IntPtr_Texture_UInt32;
		public virtual RMethod RIssuePluginCustomTextureUpdateV2_IntPtr_Texture_UInt32
		{
			get
			{
				if(r_RIssuePluginCustomTextureUpdateV2_IntPtr_Texture_UInt32 == null)
				{
					r_RIssuePluginCustomTextureUpdateV2_IntPtr_Texture_UInt32 = new(this, "IssuePluginCustomTextureUpdateV2", 0, typeof(System.IntPtr), typeof(UnityEngine.Texture), typeof(System.UInt32));
					r_RIssuePluginCustomTextureUpdateV2_IntPtr_Texture_UInt32.SetBelong(this.instance);
				}
				return r_RIssuePluginCustomTextureUpdateV2_IntPtr_Texture_UInt32;
			}
		}

		/// <summary>
		/// Void ProcessVTFeedback(UnityEngine.Rendering.RenderTargetIdentifier, IntPtr, Int32, Int32, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RProcessVTFeedback_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32;
		public virtual RMethod RProcessVTFeedback_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_RProcessVTFeedback_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32 == null)
				{
					r_RProcessVTFeedback_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32 = new(this, "ProcessVTFeedback", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RProcessVTFeedback_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RProcessVTFeedback_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void CopyBuffer(UnityEngine.GraphicsBuffer, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_RCopyBuffer_GraphicsBuffer_GraphicsBuffer;
		public virtual RMethod RCopyBuffer_GraphicsBuffer_GraphicsBuffer
		{
			get
			{
				if(r_RCopyBuffer_GraphicsBuffer_GraphicsBuffer == null)
				{
					r_RCopyBuffer_GraphicsBuffer_GraphicsBuffer = new(this, "CopyBuffer", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.GraphicsBuffer));
					r_RCopyBuffer_GraphicsBuffer_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_RCopyBuffer_GraphicsBuffer_GraphicsBuffer;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.GPUFence CreateGPUFence(UnityEngine.Rendering.SynchronisationStage)
		/// </summary>
		protected RMethod r_RCreateGPUFence_SynchronisationStage;
		public virtual RMethod RCreateGPUFence_SynchronisationStage
		{
			get
			{
				if(r_RCreateGPUFence_SynchronisationStage == null)
				{
					r_RCreateGPUFence_SynchronisationStage = new(this, "CreateGPUFence", 0, typeof(UnityEngine.Rendering.SynchronisationStage));
					r_RCreateGPUFence_SynchronisationStage.SetBelong(this.instance);
				}
				return r_RCreateGPUFence_SynchronisationStage;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.GPUFence CreateGPUFence()
		/// </summary>
		protected RMethod r_RCreateGPUFence;
		public virtual RMethod RCreateGPUFence
		{
			get
			{
				if(r_RCreateGPUFence == null)
				{
					r_RCreateGPUFence = new(this, "CreateGPUFence", 0);
					r_RCreateGPUFence.SetBelong(this.instance);
				}
				return r_RCreateGPUFence;
			}
		}

		/// <summary>
		/// Void WaitOnGPUFence(UnityEngine.Rendering.GPUFence, UnityEngine.Rendering.SynchronisationStage)
		/// </summary>
		protected RMethod r_RWaitOnGPUFence_GPUFence_SynchronisationStage;
		public virtual RMethod RWaitOnGPUFence_GPUFence_SynchronisationStage
		{
			get
			{
				if(r_RWaitOnGPUFence_GPUFence_SynchronisationStage == null)
				{
					r_RWaitOnGPUFence_GPUFence_SynchronisationStage = new(this, "WaitOnGPUFence", 0, typeof(UnityEngine.Rendering.GraphicsFence), typeof(UnityEngine.Rendering.SynchronisationStage));
					r_RWaitOnGPUFence_GPUFence_SynchronisationStage.SetBelong(this.instance);
				}
				return r_RWaitOnGPUFence_GPUFence_SynchronisationStage;
			}
		}

		/// <summary>
		/// Void WaitOnGPUFence(UnityEngine.Rendering.GPUFence)
		/// </summary>
		protected RMethod r_RWaitOnGPUFence_GPUFence;
		public virtual RMethod RWaitOnGPUFence_GPUFence
		{
			get
			{
				if(r_RWaitOnGPUFence_GPUFence == null)
				{
					r_RWaitOnGPUFence_GPUFence = new(this, "WaitOnGPUFence", 0, typeof(UnityEngine.Rendering.GraphicsFence));
					r_RWaitOnGPUFence_GPUFence.SetBelong(this.instance);
				}
				return r_RWaitOnGPUFence_GPUFence;
			}
		}

		/// <summary>
		/// Void SetComputeBufferData(UnityEngine.ComputeBuffer, System.Array)
		/// </summary>
		protected RMethod r_RSetComputeBufferData_ComputeBuffer_Array;
		public virtual RMethod RSetComputeBufferData_ComputeBuffer_Array
		{
			get
			{
				if(r_RSetComputeBufferData_ComputeBuffer_Array == null)
				{
					r_RSetComputeBufferData_ComputeBuffer_Array = new(this, "SetComputeBufferData", 0, typeof(UnityEngine.ComputeBuffer), typeof(System.Array));
					r_RSetComputeBufferData_ComputeBuffer_Array.SetBelong(this.instance);
				}
				return r_RSetComputeBufferData_ComputeBuffer_Array;
			}
		}

		/// <summary>
		/// Void SetComputeBufferData[T](UnityEngine.ComputeBuffer, System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_RSetComputeBufferData_GT_ComputeBuffer_List_d_T_p_;
		public virtual RMethod RSetComputeBufferData_GT_ComputeBuffer_List_d_T_p_
		{
			get
			{
				if(r_RSetComputeBufferData_GT_ComputeBuffer_List_d_T_p_ == null)
				{
					r_RSetComputeBufferData_GT_ComputeBuffer_List_d_T_p_ = new(this, "SetComputeBufferData", 1, typeof(UnityEngine.ComputeBuffer), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RSetComputeBufferData_GT_ComputeBuffer_List_d_T_p_.SetBelong(this.instance);
				}
				return r_RSetComputeBufferData_GT_ComputeBuffer_List_d_T_p_;
			}
		}

		/// <summary>
		/// Void SetComputeBufferData[T](UnityEngine.ComputeBuffer, Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_RSetComputeBufferData_GT_ComputeBuffer_NativeArray_d_T_p_;
		public virtual RMethod RSetComputeBufferData_GT_ComputeBuffer_NativeArray_d_T_p_
		{
			get
			{
				if(r_RSetComputeBufferData_GT_ComputeBuffer_NativeArray_d_T_p_ == null)
				{
					r_RSetComputeBufferData_GT_ComputeBuffer_NativeArray_d_T_p_ = new(this, "SetComputeBufferData", 1, typeof(UnityEngine.ComputeBuffer), typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RSetComputeBufferData_GT_ComputeBuffer_NativeArray_d_T_p_.SetBelong(this.instance);
				}
				return r_RSetComputeBufferData_GT_ComputeBuffer_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void SetComputeBufferData(UnityEngine.ComputeBuffer, System.Array, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetComputeBufferData_ComputeBuffer_Array_Int32_Int32_Int32;
		public virtual RMethod RSetComputeBufferData_ComputeBuffer_Array_Int32_Int32_Int32
		{
			get
			{
				if(r_RSetComputeBufferData_ComputeBuffer_Array_Int32_Int32_Int32 == null)
				{
					r_RSetComputeBufferData_ComputeBuffer_Array_Int32_Int32_Int32 = new(this, "SetComputeBufferData", 0, typeof(UnityEngine.ComputeBuffer), typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RSetComputeBufferData_ComputeBuffer_Array_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetComputeBufferData_ComputeBuffer_Array_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetComputeBufferData[T](UnityEngine.ComputeBuffer, System.Collections.Generic.List`1[T], Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetComputeBufferData_GT_ComputeBuffer_List_d_T_p__Int32_Int32_Int32;
		public virtual RMethod RSetComputeBufferData_GT_ComputeBuffer_List_d_T_p__Int32_Int32_Int32
		{
			get
			{
				if(r_RSetComputeBufferData_GT_ComputeBuffer_List_d_T_p__Int32_Int32_Int32 == null)
				{
					r_RSetComputeBufferData_GT_ComputeBuffer_List_d_T_p__Int32_Int32_Int32 = new(this, "SetComputeBufferData", 1, typeof(UnityEngine.ComputeBuffer), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RSetComputeBufferData_GT_ComputeBuffer_List_d_T_p__Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetComputeBufferData_GT_ComputeBuffer_List_d_T_p__Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetComputeBufferData[T](UnityEngine.ComputeBuffer, Unity.Collections.NativeArray`1[T], Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetComputeBufferData_GT_ComputeBuffer_NativeArray_d_T_p__Int32_Int32_Int32;
		public virtual RMethod RSetComputeBufferData_GT_ComputeBuffer_NativeArray_d_T_p__Int32_Int32_Int32
		{
			get
			{
				if(r_RSetComputeBufferData_GT_ComputeBuffer_NativeArray_d_T_p__Int32_Int32_Int32 == null)
				{
					r_RSetComputeBufferData_GT_ComputeBuffer_NativeArray_d_T_p__Int32_Int32_Int32 = new(this, "SetComputeBufferData", 1, typeof(UnityEngine.ComputeBuffer), typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RSetComputeBufferData_GT_ComputeBuffer_NativeArray_d_T_p__Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetComputeBufferData_GT_ComputeBuffer_NativeArray_d_T_p__Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetComputeBufferCounterValue(UnityEngine.ComputeBuffer, UInt32)
		/// </summary>
		protected RMethod r_RSetComputeBufferCounterValue_ComputeBuffer_UInt32;
		public virtual RMethod RSetComputeBufferCounterValue_ComputeBuffer_UInt32
		{
			get
			{
				if(r_RSetComputeBufferCounterValue_ComputeBuffer_UInt32 == null)
				{
					r_RSetComputeBufferCounterValue_ComputeBuffer_UInt32 = new(this, "SetComputeBufferCounterValue", 0, typeof(UnityEngine.ComputeBuffer), typeof(System.UInt32));
					r_RSetComputeBufferCounterValue_ComputeBuffer_UInt32.SetBelong(this.instance);
				}
				return r_RSetComputeBufferCounterValue_ComputeBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void ConvertTexture_Internal_Injected(UnityEngine.Rendering.RenderTargetIdentifier ByRef, Int32, UnityEngine.Rendering.RenderTargetIdentifier ByRef, Int32)
		/// </summary>
		protected RMethod r_RConvertTexture_Internal_Injected_Ref_RenderTargetIdentifier_Int32_Ref_RenderTargetIdentifier_Int32;
		public virtual RMethod RConvertTexture_Internal_Injected_Ref_RenderTargetIdentifier_Int32_Ref_RenderTargetIdentifier_Int32
		{
			get
			{
				if(r_RConvertTexture_Internal_Injected_Ref_RenderTargetIdentifier_Int32_Ref_RenderTargetIdentifier_Int32 == null)
				{
					r_RConvertTexture_Internal_Injected_Ref_RenderTargetIdentifier_Int32_Ref_RenderTargetIdentifier_Int32 = new(this, "ConvertTexture_Internal_Injected", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(System.Int32));
					r_RConvertTexture_Internal_Injected_Ref_RenderTargetIdentifier_Int32_Ref_RenderTargetIdentifier_Int32.SetBelong(this.instance);
				}
				return r_RConvertTexture_Internal_Injected_Ref_RenderTargetIdentifier_Int32_Ref_RenderTargetIdentifier_Int32;
			}
		}

		/// <summary>
		/// Void SetComputeVectorParam_Injected(UnityEngine.ComputeShader, Int32, UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_RSetComputeVectorParam_Injected_ComputeShader_Int32_Ref_Vector4;
		public virtual RMethod RSetComputeVectorParam_Injected_ComputeShader_Int32_Ref_Vector4
		{
			get
			{
				if(r_RSetComputeVectorParam_Injected_ComputeShader_Int32_Ref_Vector4 == null)
				{
					r_RSetComputeVectorParam_Injected_ComputeShader_Int32_Ref_Vector4 = new(this, "SetComputeVectorParam_Injected", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(UnityEngine.Vector4).MakeByRefType());
					r_RSetComputeVectorParam_Injected_ComputeShader_Int32_Ref_Vector4.SetBelong(this.instance);
				}
				return r_RSetComputeVectorParam_Injected_ComputeShader_Int32_Ref_Vector4;
			}
		}

		/// <summary>
		/// Void SetComputeMatrixParam_Injected(UnityEngine.ComputeShader, Int32, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_RSetComputeMatrixParam_Injected_ComputeShader_Int32_Ref_Matrix4x4;
		public virtual RMethod RSetComputeMatrixParam_Injected_ComputeShader_Int32_Ref_Matrix4x4
		{
			get
			{
				if(r_RSetComputeMatrixParam_Injected_ComputeShader_Int32_Ref_Matrix4x4 == null)
				{
					r_RSetComputeMatrixParam_Injected_ComputeShader_Int32_Ref_Matrix4x4 = new(this, "SetComputeMatrixParam_Injected", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_RSetComputeMatrixParam_Injected_ComputeShader_Int32_Ref_Matrix4x4.SetBelong(this.instance);
				}
				return r_RSetComputeMatrixParam_Injected_ComputeShader_Int32_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Void Internal_SetComputeGraphicsBufferHandleParam_Injected(UnityEngine.ComputeShader, Int32, Int32, UnityEngine.GraphicsBufferHandle ByRef)
		/// </summary>
		protected RMethod r_RInternal_SetComputeGraphicsBufferHandleParam_Injected_ComputeShader_Int32_Int32_Ref_GraphicsBufferHandle;
		public virtual RMethod RInternal_SetComputeGraphicsBufferHandleParam_Injected_ComputeShader_Int32_Int32_Ref_GraphicsBufferHandle
		{
			get
			{
				if(r_RInternal_SetComputeGraphicsBufferHandleParam_Injected_ComputeShader_Int32_Int32_Ref_GraphicsBufferHandle == null)
				{
					r_RInternal_SetComputeGraphicsBufferHandleParam_Injected_ComputeShader_Int32_Int32_Ref_GraphicsBufferHandle = new(this, "Internal_SetComputeGraphicsBufferHandleParam_Injected", 0, typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.GraphicsBufferHandle).MakeByRefType());
					r_RInternal_SetComputeGraphicsBufferHandleParam_Injected_ComputeShader_Int32_Int32_Ref_GraphicsBufferHandle.SetBelong(this.instance);
				}
				return r_RInternal_SetComputeGraphicsBufferHandleParam_Injected_ComputeShader_Int32_Int32_Ref_GraphicsBufferHandle;
			}
		}

		/// <summary>
		/// Void Internal_SetRayTracingVectorParam_Injected(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_RInternal_SetRayTracingVectorParam_Injected_RayTracingShader_Int32_Ref_Vector4;
		public virtual RMethod RInternal_SetRayTracingVectorParam_Injected_RayTracingShader_Int32_Ref_Vector4
		{
			get
			{
				if(r_RInternal_SetRayTracingVectorParam_Injected_RayTracingShader_Int32_Ref_Vector4 == null)
				{
					r_RInternal_SetRayTracingVectorParam_Injected_RayTracingShader_Int32_Ref_Vector4 = new(this, "Internal_SetRayTracingVectorParam_Injected", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.Vector4).MakeByRefType());
					r_RInternal_SetRayTracingVectorParam_Injected_RayTracingShader_Int32_Ref_Vector4.SetBelong(this.instance);
				}
				return r_RInternal_SetRayTracingVectorParam_Injected_RayTracingShader_Int32_Ref_Vector4;
			}
		}

		/// <summary>
		/// Void Internal_SetRayTracingMatrixParam_Injected(UnityEngine.Experimental.Rendering.RayTracingShader, Int32, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_RInternal_SetRayTracingMatrixParam_Injected_RayTracingShader_Int32_Ref_Matrix4x4;
		public virtual RMethod RInternal_SetRayTracingMatrixParam_Injected_RayTracingShader_Int32_Ref_Matrix4x4
		{
			get
			{
				if(r_RInternal_SetRayTracingMatrixParam_Injected_RayTracingShader_Int32_Ref_Matrix4x4 == null)
				{
					r_RInternal_SetRayTracingMatrixParam_Injected_RayTracingShader_Int32_Ref_Matrix4x4 = new(this, "Internal_SetRayTracingMatrixParam_Injected", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingShader), typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_RInternal_SetRayTracingMatrixParam_Injected_RayTracingShader_Int32_Ref_Matrix4x4.SetBelong(this.instance);
				}
				return r_RInternal_SetRayTracingMatrixParam_Injected_RayTracingShader_Int32_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Void Internal_BuildRayTracingAccelerationStructure_Injected(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_RInternal_BuildRayTracingAccelerationStructure_Injected_RayTracingAccelerationStructure_Ref_Vector3;
		public virtual RMethod RInternal_BuildRayTracingAccelerationStructure_Injected_RayTracingAccelerationStructure_Ref_Vector3
		{
			get
			{
				if(r_RInternal_BuildRayTracingAccelerationStructure_Injected_RayTracingAccelerationStructure_Ref_Vector3 == null)
				{
					r_RInternal_BuildRayTracingAccelerationStructure_Injected_RayTracingAccelerationStructure_Ref_Vector3 = new(this, "Internal_BuildRayTracingAccelerationStructure_Injected", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure), typeof(UnityEngine.Vector3).MakeByRefType());
					r_RInternal_BuildRayTracingAccelerationStructure_Injected_RayTracingAccelerationStructure_Ref_Vector3.SetBelong(this.instance);
				}
				return r_RInternal_BuildRayTracingAccelerationStructure_Injected_RayTracingAccelerationStructure_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void Internal_GenerateMips_Injected(UnityEngine.Rendering.RenderTargetIdentifier ByRef)
		/// </summary>
		protected RMethod r_RInternal_GenerateMips_Injected_Ref_RenderTargetIdentifier;
		public virtual RMethod RInternal_GenerateMips_Injected_Ref_RenderTargetIdentifier
		{
			get
			{
				if(r_RInternal_GenerateMips_Injected_Ref_RenderTargetIdentifier == null)
				{
					r_RInternal_GenerateMips_Injected_Ref_RenderTargetIdentifier = new(this, "Internal_GenerateMips_Injected", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType());
					r_RInternal_GenerateMips_Injected_Ref_RenderTargetIdentifier.SetBelong(this.instance);
				}
				return r_RInternal_GenerateMips_Injected_Ref_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void Internal_DrawMesh_Injected(UnityEngine.Mesh, UnityEngine.Matrix4x4 ByRef, UnityEngine.Material, Int32, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_RInternal_DrawMesh_Injected_Mesh_Ref_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock;
		public virtual RMethod RInternal_DrawMesh_Injected_Mesh_Ref_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_RInternal_DrawMesh_Injected_Mesh_Ref_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock == null)
				{
					r_RInternal_DrawMesh_Injected_Mesh_Ref_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock = new(this, "Internal_DrawMesh_Injected", 0, typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Material), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
					r_RInternal_DrawMesh_Injected_Mesh_Ref_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_RInternal_DrawMesh_Injected_Mesh_Ref_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawRendererList_Injected(UnityEngine.Rendering.RendererList ByRef)
		/// </summary>
		protected RMethod r_RInternal_DrawRendererList_Injected_Ref_RendererList;
		public virtual RMethod RInternal_DrawRendererList_Injected_Ref_RendererList
		{
			get
			{
				if(r_RInternal_DrawRendererList_Injected_Ref_RendererList == null)
				{
					r_RInternal_DrawRendererList_Injected_Ref_RendererList = new(this, "Internal_DrawRendererList_Injected", 0, typeof(UnityEngine.Rendering.RendererList).MakeByRefType());
					r_RInternal_DrawRendererList_Injected_Ref_RendererList.SetBelong(this.instance);
				}
				return r_RInternal_DrawRendererList_Injected_Ref_RendererList;
			}
		}

		/// <summary>
		/// Void Internal_DrawProcedural_Injected(UnityEngine.Matrix4x4 ByRef, UnityEngine.Material, Int32, UnityEngine.MeshTopology, Int32, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_RInternal_DrawProcedural_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock;
		public virtual RMethod RInternal_DrawProcedural_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_RInternal_DrawProcedural_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock == null)
				{
					r_RInternal_DrawProcedural_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock = new(this, "Internal_DrawProcedural_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
					r_RInternal_DrawProcedural_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_RInternal_DrawProcedural_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawProceduralIndexed_Injected(UnityEngine.GraphicsBuffer, UnityEngine.Matrix4x4 ByRef, UnityEngine.Material, Int32, UnityEngine.MeshTopology, Int32, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_RInternal_DrawProceduralIndexed_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock;
		public virtual RMethod RInternal_DrawProceduralIndexed_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_RInternal_DrawProceduralIndexed_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock == null)
				{
					r_RInternal_DrawProceduralIndexed_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock = new(this, "Internal_DrawProceduralIndexed_Injected", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
					r_RInternal_DrawProceduralIndexed_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_RInternal_DrawProceduralIndexed_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawProceduralIndirect_Injected(UnityEngine.Matrix4x4 ByRef, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.ComputeBuffer, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_RInternal_DrawProceduralIndirect_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock;
		public virtual RMethod RInternal_DrawProceduralIndirect_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_RInternal_DrawProceduralIndirect_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock == null)
				{
					r_RInternal_DrawProceduralIndirect_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock = new(this, "Internal_DrawProceduralIndirect_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
					r_RInternal_DrawProceduralIndirect_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_RInternal_DrawProceduralIndirect_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawProceduralIndexedIndirect_Injected(UnityEngine.GraphicsBuffer, UnityEngine.Matrix4x4 ByRef, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.ComputeBuffer, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_RInternal_DrawProceduralIndexedIndirect_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock;
		public virtual RMethod RInternal_DrawProceduralIndexedIndirect_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_RInternal_DrawProceduralIndexedIndirect_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock == null)
				{
					r_RInternal_DrawProceduralIndexedIndirect_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock = new(this, "Internal_DrawProceduralIndexedIndirect_Injected", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
					r_RInternal_DrawProceduralIndexedIndirect_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_RInternal_DrawProceduralIndexedIndirect_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawProceduralIndirectGraphicsBuffer_Injected(UnityEngine.Matrix4x4 ByRef, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.GraphicsBuffer, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_RInternal_DrawProceduralIndirectGraphicsBuffer_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock;
		public virtual RMethod RInternal_DrawProceduralIndirectGraphicsBuffer_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_RInternal_DrawProceduralIndirectGraphicsBuffer_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock == null)
				{
					r_RInternal_DrawProceduralIndirectGraphicsBuffer_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock = new(this, "Internal_DrawProceduralIndirectGraphicsBuffer_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
					r_RInternal_DrawProceduralIndirectGraphicsBuffer_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_RInternal_DrawProceduralIndirectGraphicsBuffer_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected(UnityEngine.GraphicsBuffer, UnityEngine.Matrix4x4 ByRef, UnityEngine.Material, Int32, UnityEngine.MeshTopology, UnityEngine.GraphicsBuffer, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_RInternal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock;
		public virtual RMethod RInternal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_RInternal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock == null)
				{
					r_RInternal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock = new(this, "Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected", 0, typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
					r_RInternal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_RInternal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_DrawOcclusionMesh_Injected(UnityEngine.RectInt ByRef)
		/// </summary>
		protected RMethod r_RInternal_DrawOcclusionMesh_Injected_Ref_RectInt;
		public virtual RMethod RInternal_DrawOcclusionMesh_Injected_Ref_RectInt
		{
			get
			{
				if(r_RInternal_DrawOcclusionMesh_Injected_Ref_RectInt == null)
				{
					r_RInternal_DrawOcclusionMesh_Injected_Ref_RectInt = new(this, "Internal_DrawOcclusionMesh_Injected", 0, typeof(UnityEngine.RectInt).MakeByRefType());
					r_RInternal_DrawOcclusionMesh_Injected_Ref_RectInt.SetBelong(this.instance);
				}
				return r_RInternal_DrawOcclusionMesh_Injected_Ref_RectInt;
			}
		}

		/// <summary>
		/// Void SetViewport_Injected(UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_RSetViewport_Injected_Ref_Rect;
		public virtual RMethod RSetViewport_Injected_Ref_Rect
		{
			get
			{
				if(r_RSetViewport_Injected_Ref_Rect == null)
				{
					r_RSetViewport_Injected_Ref_Rect = new(this, "SetViewport_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType());
					r_RSetViewport_Injected_Ref_Rect.SetBelong(this.instance);
				}
				return r_RSetViewport_Injected_Ref_Rect;
			}
		}

		/// <summary>
		/// Void EnableScissorRect_Injected(UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_REnableScissorRect_Injected_Ref_Rect;
		public virtual RMethod REnableScissorRect_Injected_Ref_Rect
		{
			get
			{
				if(r_REnableScissorRect_Injected_Ref_Rect == null)
				{
					r_REnableScissorRect_Injected_Ref_Rect = new(this, "EnableScissorRect_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType());
					r_REnableScissorRect_Injected_Ref_Rect.SetBelong(this.instance);
				}
				return r_REnableScissorRect_Injected_Ref_Rect;
			}
		}

		/// <summary>
		/// Void Blit_Texture_Injected(UnityEngine.Texture, UnityEngine.Rendering.RenderTargetIdentifier ByRef, UnityEngine.Material, Int32, UnityEngine.Vector2 ByRef, UnityEngine.Vector2 ByRef, Int32, Int32)
		/// </summary>
		protected RMethod r_RBlit_Texture_Injected_Texture_Ref_RenderTargetIdentifier_Material_Int32_Ref_Vector2_Ref_Vector2_Int32_Int32;
		public virtual RMethod RBlit_Texture_Injected_Texture_Ref_RenderTargetIdentifier_Material_Int32_Ref_Vector2_Ref_Vector2_Int32_Int32
		{
			get
			{
				if(r_RBlit_Texture_Injected_Texture_Ref_RenderTargetIdentifier_Material_Int32_Ref_Vector2_Ref_Vector2_Int32_Int32 == null)
				{
					r_RBlit_Texture_Injected_Texture_Ref_RenderTargetIdentifier_Material_Int32_Ref_Vector2_Ref_Vector2_Int32_Int32 = new(this, "Blit_Texture_Injected", 0, typeof(UnityEngine.Texture), typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Vector2).MakeByRefType(), typeof(UnityEngine.Vector2).MakeByRefType(), typeof(System.Int32), typeof(System.Int32));
					r_RBlit_Texture_Injected_Texture_Ref_RenderTargetIdentifier_Material_Int32_Ref_Vector2_Ref_Vector2_Int32_Int32.SetBelong(this.instance);
				}
				return r_RBlit_Texture_Injected_Texture_Ref_RenderTargetIdentifier_Material_Int32_Ref_Vector2_Ref_Vector2_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Blit_Identifier_Injected(UnityEngine.Rendering.RenderTargetIdentifier ByRef, UnityEngine.Rendering.RenderTargetIdentifier ByRef, UnityEngine.Material, Int32, UnityEngine.Vector2 ByRef, UnityEngine.Vector2 ByRef, Int32, Int32)
		/// </summary>
		protected RMethod r_RBlit_Identifier_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_Material_Int32_Ref_Vector2_Ref_Vector2_Int32_Int32;
		public virtual RMethod RBlit_Identifier_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_Material_Int32_Ref_Vector2_Ref_Vector2_Int32_Int32
		{
			get
			{
				if(r_RBlit_Identifier_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_Material_Int32_Ref_Vector2_Ref_Vector2_Int32_Int32 == null)
				{
					r_RBlit_Identifier_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_Material_Int32_Ref_Vector2_Ref_Vector2_Int32_Int32 = new(this, "Blit_Identifier_Injected", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Vector2).MakeByRefType(), typeof(UnityEngine.Vector2).MakeByRefType(), typeof(System.Int32), typeof(System.Int32));
					r_RBlit_Identifier_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_Material_Int32_Ref_Vector2_Ref_Vector2_Int32_Int32.SetBelong(this.instance);
				}
				return r_RBlit_Identifier_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_Material_Int32_Ref_Vector2_Ref_Vector2_Int32_Int32;
			}
		}

		/// <summary>
		/// Void GetTemporaryRTWithDescriptor_Injected(Int32, UnityEngine.RenderTextureDescriptor ByRef, UnityEngine.FilterMode)
		/// </summary>
		protected RMethod r_RGetTemporaryRTWithDescriptor_Injected_Int32_Ref_RenderTextureDescriptor_FilterMode;
		public virtual RMethod RGetTemporaryRTWithDescriptor_Injected_Int32_Ref_RenderTextureDescriptor_FilterMode
		{
			get
			{
				if(r_RGetTemporaryRTWithDescriptor_Injected_Int32_Ref_RenderTextureDescriptor_FilterMode == null)
				{
					r_RGetTemporaryRTWithDescriptor_Injected_Int32_Ref_RenderTextureDescriptor_FilterMode = new(this, "GetTemporaryRTWithDescriptor_Injected", 0, typeof(System.Int32), typeof(UnityEngine.RenderTextureDescriptor).MakeByRefType(), typeof(UnityEngine.FilterMode));
					r_RGetTemporaryRTWithDescriptor_Injected_Int32_Ref_RenderTextureDescriptor_FilterMode.SetBelong(this.instance);
				}
				return r_RGetTemporaryRTWithDescriptor_Injected_Int32_Ref_RenderTextureDescriptor_FilterMode;
			}
		}

		/// <summary>
		/// Void ClearRenderTarget_Injected(UnityEngine.Rendering.RTClearFlags, UnityEngine.Color ByRef, Single, UInt32)
		/// </summary>
		protected RMethod r_RClearRenderTarget_Injected_RTClearFlags_Ref_Color_Single_UInt32;
		public virtual RMethod RClearRenderTarget_Injected_RTClearFlags_Ref_Color_Single_UInt32
		{
			get
			{
				if(r_RClearRenderTarget_Injected_RTClearFlags_Ref_Color_Single_UInt32 == null)
				{
					r_RClearRenderTarget_Injected_RTClearFlags_Ref_Color_Single_UInt32 = new(this, "ClearRenderTarget_Injected", 0, typeof(UnityEngine.Rendering.RTClearFlags), typeof(UnityEngine.Color).MakeByRefType(), typeof(System.Single), typeof(System.UInt32));
					r_RClearRenderTarget_Injected_RTClearFlags_Ref_Color_Single_UInt32.SetBelong(this.instance);
				}
				return r_RClearRenderTarget_Injected_RTClearFlags_Ref_Color_Single_UInt32;
			}
		}

		/// <summary>
		/// Void SetGlobalVector_Injected(Int32, UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_RSetGlobalVector_Injected_Int32_Ref_Vector4;
		public virtual RMethod RSetGlobalVector_Injected_Int32_Ref_Vector4
		{
			get
			{
				if(r_RSetGlobalVector_Injected_Int32_Ref_Vector4 == null)
				{
					r_RSetGlobalVector_Injected_Int32_Ref_Vector4 = new(this, "SetGlobalVector_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeByRefType());
					r_RSetGlobalVector_Injected_Int32_Ref_Vector4.SetBelong(this.instance);
				}
				return r_RSetGlobalVector_Injected_Int32_Ref_Vector4;
			}
		}

		/// <summary>
		/// Void SetGlobalColor_Injected(Int32, UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_RSetGlobalColor_Injected_Int32_Ref_Color;
		public virtual RMethod RSetGlobalColor_Injected_Int32_Ref_Color
		{
			get
			{
				if(r_RSetGlobalColor_Injected_Int32_Ref_Color == null)
				{
					r_RSetGlobalColor_Injected_Int32_Ref_Color = new(this, "SetGlobalColor_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Color).MakeByRefType());
					r_RSetGlobalColor_Injected_Int32_Ref_Color.SetBelong(this.instance);
				}
				return r_RSetGlobalColor_Injected_Int32_Ref_Color;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrix_Injected(Int32, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_RSetGlobalMatrix_Injected_Int32_Ref_Matrix4x4;
		public virtual RMethod RSetGlobalMatrix_Injected_Int32_Ref_Matrix4x4
		{
			get
			{
				if(r_RSetGlobalMatrix_Injected_Int32_Ref_Matrix4x4 == null)
				{
					r_RSetGlobalMatrix_Injected_Int32_Ref_Matrix4x4 = new(this, "SetGlobalMatrix_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_RSetGlobalMatrix_Injected_Int32_Ref_Matrix4x4.SetBelong(this.instance);
				}
				return r_RSetGlobalMatrix_Injected_Int32_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Void EnableGlobalKeyword_Injected(UnityEngine.Rendering.GlobalKeyword ByRef)
		/// </summary>
		protected RMethod r_REnableGlobalKeyword_Injected_Ref_GlobalKeyword;
		public virtual RMethod REnableGlobalKeyword_Injected_Ref_GlobalKeyword
		{
			get
			{
				if(r_REnableGlobalKeyword_Injected_Ref_GlobalKeyword == null)
				{
					r_REnableGlobalKeyword_Injected_Ref_GlobalKeyword = new(this, "EnableGlobalKeyword_Injected", 0, typeof(UnityEngine.Rendering.GlobalKeyword).MakeByRefType());
					r_REnableGlobalKeyword_Injected_Ref_GlobalKeyword.SetBelong(this.instance);
				}
				return r_REnableGlobalKeyword_Injected_Ref_GlobalKeyword;
			}
		}

		/// <summary>
		/// Void EnableMaterialKeyword_Injected(UnityEngine.Material, UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_REnableMaterialKeyword_Injected_Material_Ref_LocalKeyword;
		public virtual RMethod REnableMaterialKeyword_Injected_Material_Ref_LocalKeyword
		{
			get
			{
				if(r_REnableMaterialKeyword_Injected_Material_Ref_LocalKeyword == null)
				{
					r_REnableMaterialKeyword_Injected_Material_Ref_LocalKeyword = new(this, "EnableMaterialKeyword_Injected", 0, typeof(UnityEngine.Material), typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
					r_REnableMaterialKeyword_Injected_Material_Ref_LocalKeyword.SetBelong(this.instance);
				}
				return r_REnableMaterialKeyword_Injected_Material_Ref_LocalKeyword;
			}
		}

		/// <summary>
		/// Void EnableComputeKeyword_Injected(UnityEngine.ComputeShader, UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_REnableComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword;
		public virtual RMethod REnableComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword
		{
			get
			{
				if(r_REnableComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword == null)
				{
					r_REnableComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword = new(this, "EnableComputeKeyword_Injected", 0, typeof(UnityEngine.ComputeShader), typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
					r_REnableComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword.SetBelong(this.instance);
				}
				return r_REnableComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword;
			}
		}

		/// <summary>
		/// Void DisableGlobalKeyword_Injected(UnityEngine.Rendering.GlobalKeyword ByRef)
		/// </summary>
		protected RMethod r_RDisableGlobalKeyword_Injected_Ref_GlobalKeyword;
		public virtual RMethod RDisableGlobalKeyword_Injected_Ref_GlobalKeyword
		{
			get
			{
				if(r_RDisableGlobalKeyword_Injected_Ref_GlobalKeyword == null)
				{
					r_RDisableGlobalKeyword_Injected_Ref_GlobalKeyword = new(this, "DisableGlobalKeyword_Injected", 0, typeof(UnityEngine.Rendering.GlobalKeyword).MakeByRefType());
					r_RDisableGlobalKeyword_Injected_Ref_GlobalKeyword.SetBelong(this.instance);
				}
				return r_RDisableGlobalKeyword_Injected_Ref_GlobalKeyword;
			}
		}

		/// <summary>
		/// Void DisableMaterialKeyword_Injected(UnityEngine.Material, UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_RDisableMaterialKeyword_Injected_Material_Ref_LocalKeyword;
		public virtual RMethod RDisableMaterialKeyword_Injected_Material_Ref_LocalKeyword
		{
			get
			{
				if(r_RDisableMaterialKeyword_Injected_Material_Ref_LocalKeyword == null)
				{
					r_RDisableMaterialKeyword_Injected_Material_Ref_LocalKeyword = new(this, "DisableMaterialKeyword_Injected", 0, typeof(UnityEngine.Material), typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
					r_RDisableMaterialKeyword_Injected_Material_Ref_LocalKeyword.SetBelong(this.instance);
				}
				return r_RDisableMaterialKeyword_Injected_Material_Ref_LocalKeyword;
			}
		}

		/// <summary>
		/// Void DisableComputeKeyword_Injected(UnityEngine.ComputeShader, UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_RDisableComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword;
		public virtual RMethod RDisableComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword
		{
			get
			{
				if(r_RDisableComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword == null)
				{
					r_RDisableComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword = new(this, "DisableComputeKeyword_Injected", 0, typeof(UnityEngine.ComputeShader), typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
					r_RDisableComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword.SetBelong(this.instance);
				}
				return r_RDisableComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword;
			}
		}

		/// <summary>
		/// Void SetGlobalKeyword_Injected(UnityEngine.Rendering.GlobalKeyword ByRef, Boolean)
		/// </summary>
		protected RMethod r_RSetGlobalKeyword_Injected_Ref_GlobalKeyword_Boolean;
		public virtual RMethod RSetGlobalKeyword_Injected_Ref_GlobalKeyword_Boolean
		{
			get
			{
				if(r_RSetGlobalKeyword_Injected_Ref_GlobalKeyword_Boolean == null)
				{
					r_RSetGlobalKeyword_Injected_Ref_GlobalKeyword_Boolean = new(this, "SetGlobalKeyword_Injected", 0, typeof(UnityEngine.Rendering.GlobalKeyword).MakeByRefType(), typeof(System.Boolean));
					r_RSetGlobalKeyword_Injected_Ref_GlobalKeyword_Boolean.SetBelong(this.instance);
				}
				return r_RSetGlobalKeyword_Injected_Ref_GlobalKeyword_Boolean;
			}
		}

		/// <summary>
		/// Void SetMaterialKeyword_Injected(UnityEngine.Material, UnityEngine.Rendering.LocalKeyword ByRef, Boolean)
		/// </summary>
		protected RMethod r_RSetMaterialKeyword_Injected_Material_Ref_LocalKeyword_Boolean;
		public virtual RMethod RSetMaterialKeyword_Injected_Material_Ref_LocalKeyword_Boolean
		{
			get
			{
				if(r_RSetMaterialKeyword_Injected_Material_Ref_LocalKeyword_Boolean == null)
				{
					r_RSetMaterialKeyword_Injected_Material_Ref_LocalKeyword_Boolean = new(this, "SetMaterialKeyword_Injected", 0, typeof(UnityEngine.Material), typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType(), typeof(System.Boolean));
					r_RSetMaterialKeyword_Injected_Material_Ref_LocalKeyword_Boolean.SetBelong(this.instance);
				}
				return r_RSetMaterialKeyword_Injected_Material_Ref_LocalKeyword_Boolean;
			}
		}

		/// <summary>
		/// Void SetComputeKeyword_Injected(UnityEngine.ComputeShader, UnityEngine.Rendering.LocalKeyword ByRef, Boolean)
		/// </summary>
		protected RMethod r_RSetComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword_Boolean;
		public virtual RMethod RSetComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword_Boolean
		{
			get
			{
				if(r_RSetComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword_Boolean == null)
				{
					r_RSetComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword_Boolean = new(this, "SetComputeKeyword_Injected", 0, typeof(UnityEngine.ComputeShader), typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType(), typeof(System.Boolean));
					r_RSetComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword_Boolean.SetBelong(this.instance);
				}
				return r_RSetComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword_Boolean;
			}
		}

		/// <summary>
		/// Void SetViewMatrix_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_RSetViewMatrix_Injected_Ref_Matrix4x4;
		public virtual RMethod RSetViewMatrix_Injected_Ref_Matrix4x4
		{
			get
			{
				if(r_RSetViewMatrix_Injected_Ref_Matrix4x4 == null)
				{
					r_RSetViewMatrix_Injected_Ref_Matrix4x4 = new(this, "SetViewMatrix_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_RSetViewMatrix_Injected_Ref_Matrix4x4.SetBelong(this.instance);
				}
				return r_RSetViewMatrix_Injected_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetProjectionMatrix_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_RSetProjectionMatrix_Injected_Ref_Matrix4x4;
		public virtual RMethod RSetProjectionMatrix_Injected_Ref_Matrix4x4
		{
			get
			{
				if(r_RSetProjectionMatrix_Injected_Ref_Matrix4x4 == null)
				{
					r_RSetProjectionMatrix_Injected_Ref_Matrix4x4 = new(this, "SetProjectionMatrix_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_RSetProjectionMatrix_Injected_Ref_Matrix4x4.SetBelong(this.instance);
				}
				return r_RSetProjectionMatrix_Injected_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetViewProjectionMatrices_Injected(UnityEngine.Matrix4x4 ByRef, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_RSetViewProjectionMatrices_Injected_Ref_Matrix4x4_Ref_Matrix4x4;
		public virtual RMethod RSetViewProjectionMatrices_Injected_Ref_Matrix4x4_Ref_Matrix4x4
		{
			get
			{
				if(r_RSetViewProjectionMatrices_Injected_Ref_Matrix4x4_Ref_Matrix4x4 == null)
				{
					r_RSetViewProjectionMatrices_Injected_Ref_Matrix4x4_Ref_Matrix4x4 = new(this, "SetViewProjectionMatrices_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_RSetViewProjectionMatrices_Injected_Ref_Matrix4x4_Ref_Matrix4x4.SetBelong(this.instance);
				}
				return r_RSetViewProjectionMatrices_Injected_Ref_Matrix4x4_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Void IncrementUpdateCount_Injected(UnityEngine.Rendering.RenderTargetIdentifier ByRef)
		/// </summary>
		protected RMethod r_RIncrementUpdateCount_Injected_Ref_RenderTargetIdentifier;
		public virtual RMethod RIncrementUpdateCount_Injected_Ref_RenderTargetIdentifier
		{
			get
			{
				if(r_RIncrementUpdateCount_Injected_Ref_RenderTargetIdentifier == null)
				{
					r_RIncrementUpdateCount_Injected_Ref_RenderTargetIdentifier = new(this, "IncrementUpdateCount_Injected", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType());
					r_RIncrementUpdateCount_Injected_Ref_RenderTargetIdentifier.SetBelong(this.instance);
				}
				return r_RIncrementUpdateCount_Injected_Ref_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Void SetRenderTargetSingle_Internal_Injected(UnityEngine.Rendering.RenderTargetIdentifier ByRef, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction)
		/// </summary>
		protected RMethod r_RSetRenderTargetSingle_Internal_Injected_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction;
		public virtual RMethod RSetRenderTargetSingle_Internal_Injected_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction
		{
			get
			{
				if(r_RSetRenderTargetSingle_Internal_Injected_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction == null)
				{
					r_RSetRenderTargetSingle_Internal_Injected_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction = new(this, "SetRenderTargetSingle_Internal_Injected", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction));
					r_RSetRenderTargetSingle_Internal_Injected_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction.SetBelong(this.instance);
				}
				return r_RSetRenderTargetSingle_Internal_Injected_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction;
			}
		}

		/// <summary>
		/// Void SetRenderTargetColorDepth_Internal_Injected(UnityEngine.Rendering.RenderTargetIdentifier ByRef, UnityEngine.Rendering.RenderTargetIdentifier ByRef, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, UnityEngine.Rendering.RenderTargetFlags)
		/// </summary>
		protected RMethod r_RSetRenderTargetColorDepth_Internal_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags;
		public virtual RMethod RSetRenderTargetColorDepth_Internal_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags
		{
			get
			{
				if(r_RSetRenderTargetColorDepth_Internal_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags == null)
				{
					r_RSetRenderTargetColorDepth_Internal_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags = new(this, "SetRenderTargetColorDepth_Internal_Injected", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction), typeof(UnityEngine.Rendering.RenderTargetFlags));
					r_RSetRenderTargetColorDepth_Internal_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags.SetBelong(this.instance);
				}
				return r_RSetRenderTargetColorDepth_Internal_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags;
			}
		}

		/// <summary>
		/// Void SetRenderTargetMulti_Internal_Injected(UnityEngine.Rendering.RenderTargetIdentifier[], UnityEngine.Rendering.RenderTargetIdentifier ByRef, UnityEngine.Rendering.RenderBufferLoadAction[], UnityEngine.Rendering.RenderBufferStoreAction[], UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, UnityEngine.Rendering.RenderTargetFlags)
		/// </summary>
		protected RMethod r_RSetRenderTargetMulti_Internal_Injected_RenderTargetIdentifierArray_Ref_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags;
		public virtual RMethod RSetRenderTargetMulti_Internal_Injected_RenderTargetIdentifierArray_Ref_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags
		{
			get
			{
				if(r_RSetRenderTargetMulti_Internal_Injected_RenderTargetIdentifierArray_Ref_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags == null)
				{
					r_RSetRenderTargetMulti_Internal_Injected_RenderTargetIdentifierArray_Ref_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags = new(this, "SetRenderTargetMulti_Internal_Injected", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeArrayType(), typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(UnityEngine.Rendering.RenderBufferLoadAction).MakeArrayType(), typeof(UnityEngine.Rendering.RenderBufferStoreAction).MakeArrayType(), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction), typeof(UnityEngine.Rendering.RenderTargetFlags));
					r_RSetRenderTargetMulti_Internal_Injected_RenderTargetIdentifierArray_Ref_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags.SetBelong(this.instance);
				}
				return r_RSetRenderTargetMulti_Internal_Injected_RenderTargetIdentifierArray_Ref_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags;
			}
		}

		/// <summary>
		/// Void SetRenderTargetColorDepthSubtarget_Injected(UnityEngine.Rendering.RenderTargetIdentifier ByRef, UnityEngine.Rendering.RenderTargetIdentifier ByRef, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, Int32, UnityEngine.CubemapFace, Int32)
		/// </summary>
		protected RMethod r_RSetRenderTargetColorDepthSubtarget_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32;
		public virtual RMethod RSetRenderTargetColorDepthSubtarget_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32
		{
			get
			{
				if(r_RSetRenderTargetColorDepthSubtarget_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32 == null)
				{
					r_RSetRenderTargetColorDepthSubtarget_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32 = new(this, "SetRenderTargetColorDepthSubtarget_Injected", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction), typeof(System.Int32), typeof(UnityEngine.CubemapFace), typeof(System.Int32));
					r_RSetRenderTargetColorDepthSubtarget_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32.SetBelong(this.instance);
				}
				return r_RSetRenderTargetColorDepthSubtarget_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32;
			}
		}

		/// <summary>
		/// Void SetRenderTargetMultiSubtarget_Injected(UnityEngine.Rendering.RenderTargetIdentifier[], UnityEngine.Rendering.RenderTargetIdentifier ByRef, UnityEngine.Rendering.RenderBufferLoadAction[], UnityEngine.Rendering.RenderBufferStoreAction[], UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, Int32, UnityEngine.CubemapFace, Int32)
		/// </summary>
		protected RMethod r_RSetRenderTargetMultiSubtarget_Injected_RenderTargetIdentifierArray_Ref_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32;
		public virtual RMethod RSetRenderTargetMultiSubtarget_Injected_RenderTargetIdentifierArray_Ref_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32
		{
			get
			{
				if(r_RSetRenderTargetMultiSubtarget_Injected_RenderTargetIdentifierArray_Ref_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32 == null)
				{
					r_RSetRenderTargetMultiSubtarget_Injected_RenderTargetIdentifierArray_Ref_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32 = new(this, "SetRenderTargetMultiSubtarget_Injected", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeArrayType(), typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(UnityEngine.Rendering.RenderBufferLoadAction).MakeArrayType(), typeof(UnityEngine.Rendering.RenderBufferStoreAction).MakeArrayType(), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction), typeof(System.Int32), typeof(UnityEngine.CubemapFace), typeof(System.Int32));
					r_RSetRenderTargetMultiSubtarget_Injected_RenderTargetIdentifierArray_Ref_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32.SetBelong(this.instance);
				}
				return r_RSetRenderTargetMultiSubtarget_Injected_RenderTargetIdentifierArray_Ref_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32;
			}
		}

		/// <summary>
		/// Void Internal_ProcessVTFeedback_Injected(UnityEngine.Rendering.RenderTargetIdentifier ByRef, IntPtr, Int32, Int32, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RInternal_ProcessVTFeedback_Injected_Ref_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32;
		public virtual RMethod RInternal_ProcessVTFeedback_Injected_Ref_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_RInternal_ProcessVTFeedback_Injected_Ref_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32 == null)
				{
					r_RInternal_ProcessVTFeedback_Injected_Ref_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32 = new(this, "Internal_ProcessVTFeedback_Injected", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier).MakeByRefType(), typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RInternal_ProcessVTFeedback_Injected_Ref_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RInternal_ProcessVTFeedback_Injected_Ref_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32;
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

        public virtual void ConvertTexture(UnityEngine.Rendering.RenderTargetIdentifier  @src, UnityEngine.Rendering.RenderTargetIdentifier  @dst)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst};
            var ___result = RConvertTexture_RenderTargetIdentifier_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ConvertTexture(UnityEngine.Rendering.RenderTargetIdentifier  @src, System.Int32  @srcElement, UnityEngine.Rendering.RenderTargetIdentifier  @dst, System.Int32  @dstElement)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @srcElement, @dst, @dstElement};
            var ___result = RConvertTexture_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WaitAllAsyncReadbackRequests()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWaitAllAsyncReadbackRequests.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestAsyncReadback(UnityEngine.ComputeBuffer  @src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest>  @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @callback};
            var ___result = RRequestAsyncReadback_ComputeBuffer_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestAsyncReadback(UnityEngine.GraphicsBuffer  @src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest>  @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @callback};
            var ___result = RRequestAsyncReadback_GraphicsBuffer_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestAsyncReadback(UnityEngine.ComputeBuffer  @src, System.Int32  @size, System.Int32  @offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest>  @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @size, @offset, @callback};
            var ___result = RRequestAsyncReadback_ComputeBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestAsyncReadback(UnityEngine.GraphicsBuffer  @src, System.Int32  @size, System.Int32  @offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest>  @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @size, @offset, @callback};
            var ___result = RRequestAsyncReadback_GraphicsBuffer_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestAsyncReadback(UnityEngine.Texture  @src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest>  @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @callback};
            var ___result = RRequestAsyncReadback_Texture_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestAsyncReadback(UnityEngine.Texture  @src, System.Int32  @mipIndex, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest>  @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @mipIndex, @callback};
            var ___result = RRequestAsyncReadback_Texture_Int32_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestAsyncReadback(UnityEngine.Texture  @src, System.Int32  @mipIndex, UnityEngine.TextureFormat  @dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest>  @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @mipIndex, @dstFormat, @callback};
            var ___result = RRequestAsyncReadback_Texture_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestAsyncReadback(UnityEngine.Texture  @src, System.Int32  @mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat  @dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest>  @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @mipIndex, @dstFormat, @callback};
            var ___result = RRequestAsyncReadback_Texture_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestAsyncReadback(UnityEngine.Texture  @src, System.Int32  @mipIndex, System.Int32  @x, System.Int32  @width, System.Int32  @y, System.Int32  @height, System.Int32  @z, System.Int32  @depth, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest>  @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @mipIndex, @x, @width, @y, @height, @z, @depth, @callback};
            var ___result = RRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestAsyncReadback(UnityEngine.Texture  @src, System.Int32  @mipIndex, System.Int32  @x, System.Int32  @width, System.Int32  @y, System.Int32  @height, System.Int32  @z, System.Int32  @depth, UnityEngine.TextureFormat  @dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest>  @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @mipIndex, @x, @width, @y, @height, @z, @depth, @dstFormat, @callback};
            var ___result = RRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TextureFormat_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestAsyncReadback(UnityEngine.Texture  @src, System.Int32  @mipIndex, System.Int32  @x, System.Int32  @width, System.Int32  @y, System.Int32  @height, System.Int32  @z, System.Int32  @depth, UnityEngine.Experimental.Rendering.GraphicsFormat  @dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest>  @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @mipIndex, @x, @width, @y, @height, @z, @depth, @dstFormat, @callback};
            var ___result = RRequestAsyncReadback_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_GraphicsFormat_Action_d_AsyncGPUReadbackRequest_p_.Invoke(___genericsType, ___parameters);

            
        }

































        public virtual void SetInvertCulling(System.Boolean  @invertCulling)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@invertCulling};
            var ___result = RSetInvertCulling_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ConvertTexture_Internal(UnityEngine.Rendering.RenderTargetIdentifier  @src, System.Int32  @srcElement, UnityEngine.Rendering.RenderTargetIdentifier  @dst, System.Int32  @dstElement)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @srcElement, @dst, @dstElement};
            var ___result = RConvertTexture_Internal_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetSinglePassStereo(UnityEngine.Rendering.SinglePassStereoMode  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mode};
            var ___result = RInternal_SetSinglePassStereo_SinglePassStereoMode.Invoke(___genericsType, ___parameters);

            
        }


        public static System.IntPtr InitBuffer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitBuffer.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual System.IntPtr CreateGPUFence_Internal(UnityEngine.Rendering.GraphicsFenceType  @fenceType, UnityEngine.Rendering.SynchronisationStageFlags  @stage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fenceType, @stage};
            var ___result = RCreateGPUFence_Internal_GraphicsFenceType_SynchronisationStageFlags.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual void WaitOnGPUFence_Internal(System.IntPtr  @fencePtr, UnityEngine.Rendering.SynchronisationStageFlags  @stage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fencePtr, @stage};
            var ___result = RWaitOnGPUFence_Internal_IntPtr_SynchronisationStageFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReleaseBuffer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReleaseBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeFloatParam(UnityEngine.ComputeShader  @computeShader, System.Int32  @nameID, System.Single  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @nameID, @val};
            var ___result = RSetComputeFloatParam_ComputeShader_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeIntParam(UnityEngine.ComputeShader  @computeShader, System.Int32  @nameID, System.Int32  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @nameID, @val};
            var ___result = RSetComputeIntParam_ComputeShader_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeVectorParam(UnityEngine.ComputeShader  @computeShader, System.Int32  @nameID, UnityEngine.Vector4  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @nameID, @val};
            var ___result = RSetComputeVectorParam_ComputeShader_Int32_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeVectorArrayParam(UnityEngine.ComputeShader  @computeShader, System.Int32  @nameID, UnityEngine.Vector4[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @nameID, @values};
            var ___result = RSetComputeVectorArrayParam_ComputeShader_Int32_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeMatrixParam(UnityEngine.ComputeShader  @computeShader, System.Int32  @nameID, UnityEngine.Matrix4x4  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @nameID, @val};
            var ___result = RSetComputeMatrixParam_ComputeShader_Int32_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeMatrixArrayParam(UnityEngine.ComputeShader  @computeShader, System.Int32  @nameID, UnityEngine.Matrix4x4[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @nameID, @values};
            var ___result = RSetComputeMatrixArrayParam_ComputeShader_Int32_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetComputeFloats(UnityEngine.ComputeShader  @computeShader, System.Int32  @nameID, System.Single[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @nameID, @values};
            var ___result = RInternal_SetComputeFloats_ComputeShader_Int32_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetComputeInts(UnityEngine.ComputeShader  @computeShader, System.Int32  @nameID, System.Int32[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @nameID, @values};
            var ___result = RInternal_SetComputeInts_ComputeShader_Int32_Int32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetComputeTextureParam(UnityEngine.ComputeShader  @computeShader, System.Int32  @kernelIndex, System.Int32  @nameID, ref UnityEngine.Rendering.RenderTargetIdentifier  @rt, System.Int32  @mipLevel, UnityEngine.Rendering.RenderTextureSubElement  @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @nameID, @rt, @mipLevel, @element};
            var ___result = RInternal_SetComputeTextureParam_ComputeShader_Int32_Int32_Ref_RenderTargetIdentifier_Int32_RenderTextureSubElement.Invoke(___genericsType, ___parameters);
			rt = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[3];

            
        }


        public virtual void Internal_SetComputeBufferParam(UnityEngine.ComputeShader  @computeShader, System.Int32  @kernelIndex, System.Int32  @nameID, UnityEngine.ComputeBuffer  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @nameID, @buffer};
            var ___result = RInternal_SetComputeBufferParam_ComputeShader_Int32_Int32_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetComputeGraphicsBufferHandleParam(UnityEngine.ComputeShader  @computeShader, System.Int32  @kernelIndex, System.Int32  @nameID, UnityEngine.GraphicsBufferHandle  @bufferHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @nameID, @bufferHandle};
            var ___result = RInternal_SetComputeGraphicsBufferHandleParam_ComputeShader_Int32_Int32_GraphicsBufferHandle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetComputeGraphicsBufferParam(UnityEngine.ComputeShader  @computeShader, System.Int32  @kernelIndex, System.Int32  @nameID, UnityEngine.GraphicsBuffer  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @nameID, @buffer};
            var ___result = RInternal_SetComputeGraphicsBufferParam_ComputeShader_Int32_Int32_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetComputeConstantComputeBufferParam(UnityEngine.ComputeShader  @computeShader, System.Int32  @nameID, UnityEngine.ComputeBuffer  @buffer, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @nameID, @buffer, @offset, @size};
            var ___result = RInternal_SetComputeConstantComputeBufferParam_ComputeShader_Int32_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetComputeConstantGraphicsBufferParam(UnityEngine.ComputeShader  @computeShader, System.Int32  @nameID, UnityEngine.GraphicsBuffer  @buffer, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @nameID, @buffer, @offset, @size};
            var ___result = RInternal_SetComputeConstantGraphicsBufferParam_ComputeShader_Int32_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetComputeParamsFromMaterial(UnityEngine.ComputeShader  @computeShader, System.Int32  @kernelIndex, UnityEngine.Material  @material)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @material};
            var ___result = RInternal_SetComputeParamsFromMaterial_ComputeShader_Int32_Material.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DispatchCompute(UnityEngine.ComputeShader  @computeShader, System.Int32  @kernelIndex, System.Int32  @threadGroupsX, System.Int32  @threadGroupsY, System.Int32  @threadGroupsZ)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @threadGroupsX, @threadGroupsY, @threadGroupsZ};
            var ___result = RInternal_DispatchCompute_ComputeShader_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DispatchComputeIndirect(UnityEngine.ComputeShader  @computeShader, System.Int32  @kernelIndex, UnityEngine.ComputeBuffer  @indirectBuffer, System.UInt32  @argsOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @indirectBuffer, @argsOffset};
            var ___result = RInternal_DispatchComputeIndirect_ComputeShader_Int32_ComputeBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DispatchComputeIndirectGraphicsBuffer(UnityEngine.ComputeShader  @computeShader, System.Int32  @kernelIndex, UnityEngine.GraphicsBuffer  @indirectBuffer, System.UInt32  @argsOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @indirectBuffer, @argsOffset};
            var ___result = RInternal_DispatchComputeIndirectGraphicsBuffer_ComputeShader_Int32_GraphicsBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetRayTracingBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.Int32  @nameID, UnityEngine.ComputeBuffer  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @buffer};
            var ___result = RInternal_SetRayTracingBufferParam_RayTracingShader_Int32_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetRayTracingConstantComputeBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.Int32  @nameID, UnityEngine.ComputeBuffer  @buffer, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @buffer, @offset, @size};
            var ___result = RInternal_SetRayTracingConstantComputeBufferParam_RayTracingShader_Int32_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetRayTracingConstantGraphicsBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.Int32  @nameID, UnityEngine.GraphicsBuffer  @buffer, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @buffer, @offset, @size};
            var ___result = RInternal_SetRayTracingConstantGraphicsBufferParam_RayTracingShader_Int32_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetRayTracingTextureParam(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.Int32  @nameID, ref UnityEngine.Rendering.RenderTargetIdentifier  @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @rt};
            var ___result = RInternal_SetRayTracingTextureParam_RayTracingShader_Int32_Ref_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);
			rt = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[2];

            
        }


        public virtual void Internal_SetRayTracingFloatParam(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.Int32  @nameID, System.Single  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @val};
            var ___result = RInternal_SetRayTracingFloatParam_RayTracingShader_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetRayTracingIntParam(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.Int32  @nameID, System.Int32  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @val};
            var ___result = RInternal_SetRayTracingIntParam_RayTracingShader_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetRayTracingVectorParam(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.Int32  @nameID, UnityEngine.Vector4  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @val};
            var ___result = RInternal_SetRayTracingVectorParam_RayTracingShader_Int32_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetRayTracingVectorArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.Int32  @nameID, UnityEngine.Vector4[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @values};
            var ___result = RInternal_SetRayTracingVectorArrayParam_RayTracingShader_Int32_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetRayTracingMatrixParam(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.Int32  @nameID, UnityEngine.Matrix4x4  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @val};
            var ___result = RInternal_SetRayTracingMatrixParam_RayTracingShader_Int32_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetRayTracingMatrixArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.Int32  @nameID, UnityEngine.Matrix4x4[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @values};
            var ___result = RInternal_SetRayTracingMatrixArrayParam_RayTracingShader_Int32_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetRayTracingFloats(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.Int32  @nameID, System.Single[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @values};
            var ___result = RInternal_SetRayTracingFloats_RayTracingShader_Int32_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetRayTracingInts(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.Int32  @nameID, System.Int32[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @values};
            var ___result = RInternal_SetRayTracingInts_RayTracingShader_Int32_Int32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_BuildRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure  @accelerationStructure, UnityEngine.Vector3  @relativeOrigin)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@accelerationStructure, @relativeOrigin};
            var ___result = RInternal_BuildRayTracingAccelerationStructure_RayTracingAccelerationStructure_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.Int32  @nameID, UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure  @accelerationStructure)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @accelerationStructure};
            var ___result = RInternal_SetRayTracingAccelerationStructure_RayTracingShader_Int32_RayTracingAccelerationStructure.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingShaderPass(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.String  @passName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @passName};
            var ___result = RSetRayTracingShaderPass_RayTracingShader_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DispatchRays(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.String  @rayGenShaderName, System.UInt32  @width, System.UInt32  @height, System.UInt32  @depth, UnityEngine.Camera  @camera)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @rayGenShaderName, @width, @height, @depth, @camera};
            var ___result = RInternal_DispatchRays_RayTracingShader_String_UInt32_UInt32_UInt32_Camera.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_GenerateMips(UnityEngine.Rendering.RenderTargetIdentifier  @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt};
            var ___result = RInternal_GenerateMips_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_ResolveAntiAliasedSurface(UnityEngine.RenderTexture  @rt, UnityEngine.RenderTexture  @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt, @target};
            var ___result = RInternal_ResolveAntiAliasedSurface_RenderTexture_RenderTexture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyCounterValueCC(UnityEngine.ComputeBuffer  @src, UnityEngine.ComputeBuffer  @dst, System.UInt32  @dstOffsetBytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst, @dstOffsetBytes};
            var ___result = RCopyCounterValueCC_ComputeBuffer_ComputeBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyCounterValueGC(UnityEngine.GraphicsBuffer  @src, UnityEngine.ComputeBuffer  @dst, System.UInt32  @dstOffsetBytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst, @dstOffsetBytes};
            var ___result = RCopyCounterValueGC_GraphicsBuffer_ComputeBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyCounterValueCG(UnityEngine.ComputeBuffer  @src, UnityEngine.GraphicsBuffer  @dst, System.UInt32  @dstOffsetBytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst, @dstOffsetBytes};
            var ___result = RCopyCounterValueCG_ComputeBuffer_GraphicsBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyCounterValueGG(UnityEngine.GraphicsBuffer  @src, UnityEngine.GraphicsBuffer  @dst, System.UInt32  @dstOffsetBytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst, @dstOffsetBytes};
            var ___result = RCopyCounterValueGG_GraphicsBuffer_GraphicsBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawMesh(UnityEngine.Mesh  @mesh, UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @submeshIndex, System.Int32  @shaderPass, UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @matrix, @material, @submeshIndex, @shaderPass, @properties};
            var ___result = RInternal_DrawMesh_Mesh_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawRenderer(UnityEngine.Renderer  @renderer, UnityEngine.Material  @material, System.Int32  @submeshIndex, System.Int32  @shaderPass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renderer, @material, @submeshIndex, @shaderPass};
            var ___result = RInternal_DrawRenderer_Renderer_Material_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawRendererList(UnityEngine.Rendering.RendererList  @rendererList)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rendererList};
            var ___result = RInternal_DrawRendererList_RendererList.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawRenderer(UnityEngine.Renderer  @renderer, UnityEngine.Material  @material, System.Int32  @submeshIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renderer, @material, @submeshIndex};
            var ___result = RInternal_DrawRenderer_Renderer_Material_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawRenderer(UnityEngine.Renderer  @renderer, UnityEngine.Material  @material)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renderer, @material};
            var ___result = RInternal_DrawRenderer_Renderer_Material.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawProcedural(UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.MeshTopology  @topology, System.Int32  @vertexCount, System.Int32  @instanceCount, UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @material, @shaderPass, @topology, @vertexCount, @instanceCount, @properties};
            var ___result = RInternal_DrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawProceduralIndexed(UnityEngine.GraphicsBuffer  @indexBuffer, UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.MeshTopology  @topology, System.Int32  @indexCount, System.Int32  @instanceCount, UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexBuffer, @matrix, @material, @shaderPass, @topology, @indexCount, @instanceCount, @properties};
            var ___result = RInternal_DrawProceduralIndexed_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawProceduralIndirect(UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.MeshTopology  @topology, UnityEngine.ComputeBuffer  @bufferWithArgs, System.Int32  @argsOffset, UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @material, @shaderPass, @topology, @bufferWithArgs, @argsOffset, @properties};
            var ___result = RInternal_DrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawProceduralIndexedIndirect(UnityEngine.GraphicsBuffer  @indexBuffer, UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.MeshTopology  @topology, UnityEngine.ComputeBuffer  @bufferWithArgs, System.Int32  @argsOffset, UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexBuffer, @matrix, @material, @shaderPass, @topology, @bufferWithArgs, @argsOffset, @properties};
            var ___result = RInternal_DrawProceduralIndexedIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawProceduralIndirectGraphicsBuffer(UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.MeshTopology  @topology, UnityEngine.GraphicsBuffer  @bufferWithArgs, System.Int32  @argsOffset, UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @material, @shaderPass, @topology, @bufferWithArgs, @argsOffset, @properties};
            var ___result = RInternal_DrawProceduralIndirectGraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawProceduralIndexedIndirectGraphicsBuffer(UnityEngine.GraphicsBuffer  @indexBuffer, UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.MeshTopology  @topology, UnityEngine.GraphicsBuffer  @bufferWithArgs, System.Int32  @argsOffset, UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexBuffer, @matrix, @material, @shaderPass, @topology, @bufferWithArgs, @argsOffset, @properties};
            var ___result = RInternal_DrawProceduralIndexedIndirectGraphicsBuffer_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawMeshInstanced(UnityEngine.Mesh  @mesh, System.Int32  @submeshIndex, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.Matrix4x4[]  @matrices, System.Int32  @count, UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @submeshIndex, @material, @shaderPass, @matrices, @count, @properties};
            var ___result = RInternal_DrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawMeshInstancedProcedural(UnityEngine.Mesh  @mesh, System.Int32  @submeshIndex, UnityEngine.Material  @material, System.Int32  @shaderPass, System.Int32  @count, UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @submeshIndex, @material, @shaderPass, @count, @properties};
            var ___result = RInternal_DrawMeshInstancedProcedural_Mesh_Int32_Material_Int32_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawMeshInstancedIndirect(UnityEngine.Mesh  @mesh, System.Int32  @submeshIndex, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.ComputeBuffer  @bufferWithArgs, System.Int32  @argsOffset, UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @submeshIndex, @material, @shaderPass, @bufferWithArgs, @argsOffset, @properties};
            var ___result = RInternal_DrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawMeshInstancedIndirectGraphicsBuffer(UnityEngine.Mesh  @mesh, System.Int32  @submeshIndex, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.GraphicsBuffer  @bufferWithArgs, System.Int32  @argsOffset, UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @submeshIndex, @material, @shaderPass, @bufferWithArgs, @argsOffset, @properties};
            var ___result = RInternal_DrawMeshInstancedIndirectGraphicsBuffer_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawOcclusionMesh(UnityEngine.RectInt  @normalizedCamViewport)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@normalizedCamViewport};
            var ___result = RInternal_DrawOcclusionMesh_RectInt.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRandomWriteTarget_Texture(System.Int32  @index, ref UnityEngine.Rendering.RenderTargetIdentifier  @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @rt};
            var ___result = RSetRandomWriteTarget_Texture_Int32_Ref_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);
			rt = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[1];

            
        }


        public virtual void SetRandomWriteTarget_Buffer(System.Int32  @index, UnityEngine.ComputeBuffer  @uav, System.Boolean  @preserveCounterValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @uav, @preserveCounterValue};
            var ___result = RSetRandomWriteTarget_Buffer_Int32_ComputeBuffer_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRandomWriteTarget_GraphicsBuffer(System.Int32  @index, UnityEngine.GraphicsBuffer  @uav, System.Boolean  @preserveCounterValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @uav, @preserveCounterValue};
            var ___result = RSetRandomWriteTarget_GraphicsBuffer_Int32_GraphicsBuffer_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearRandomWriteTargets()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearRandomWriteTargets.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetViewport(UnityEngine.Rect  @pixelRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pixelRect};
            var ___result = RSetViewport_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnableScissorRect(UnityEngine.Rect  @scissor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scissor};
            var ___result = REnableScissorRect_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DisableScissorRect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDisableScissorRect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTexture_Internal(ref UnityEngine.Rendering.RenderTargetIdentifier  @src, System.Int32  @srcElement, System.Int32  @srcMip, System.Int32  @srcX, System.Int32  @srcY, System.Int32  @srcWidth, System.Int32  @srcHeight, ref UnityEngine.Rendering.RenderTargetIdentifier  @dst, System.Int32  @dstElement, System.Int32  @dstMip, System.Int32  @dstX, System.Int32  @dstY, System.Int32  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @srcElement, @srcMip, @srcX, @srcY, @srcWidth, @srcHeight, @dst, @dstElement, @dstMip, @dstX, @dstY, @mode};
            var ___result = RCopyTexture_Internal_Ref_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32_Int32_Ref_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);
			src = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[0];
			dst = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[7];

            
        }


        public virtual void Blit_Texture(UnityEngine.Texture  @source, ref UnityEngine.Rendering.RenderTargetIdentifier  @dest, UnityEngine.Material  @mat, System.Int32  @pass, UnityEngine.Vector2  @scale, UnityEngine.Vector2  @offset, System.Int32  @sourceDepthSlice, System.Int32  @destDepthSlice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest, @mat, @pass, @scale, @offset, @sourceDepthSlice, @destDepthSlice};
            var ___result = RBlit_Texture_Texture_Ref_RenderTargetIdentifier_Material_Int32_Vector2_Vector2_Int32_Int32.Invoke(___genericsType, ___parameters);
			dest = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[1];

            
        }


        public virtual void Blit_Identifier(ref UnityEngine.Rendering.RenderTargetIdentifier  @source, ref UnityEngine.Rendering.RenderTargetIdentifier  @dest, UnityEngine.Material  @mat, System.Int32  @pass, UnityEngine.Vector2  @scale, UnityEngine.Vector2  @offset, System.Int32  @sourceDepthSlice, System.Int32  @destDepthSlice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest, @mat, @pass, @scale, @offset, @sourceDepthSlice, @destDepthSlice};
            var ___result = RBlit_Identifier_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_Material_Int32_Vector2_Vector2_Int32_Int32.Invoke(___genericsType, ___parameters);
			source = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[0];
			dest = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[1];

            
        }


        public virtual void GetTemporaryRT(System.Int32  @nameID, System.Int32  @width, System.Int32  @height, System.Int32  @depthBuffer, UnityEngine.FilterMode  @filter, UnityEngine.Experimental.Rendering.GraphicsFormat  @format, System.Int32  @antiAliasing, System.Boolean  @enableRandomWrite, UnityEngine.RenderTextureMemoryless  @memorylessMode, System.Boolean  @useDynamicScale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @depthBuffer, @filter, @format, @antiAliasing, @enableRandomWrite, @memorylessMode, @useDynamicScale};
            var ___result = RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_RenderTextureMemoryless_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRT(System.Int32  @nameID, System.Int32  @width, System.Int32  @height, System.Int32  @depthBuffer, UnityEngine.FilterMode  @filter, UnityEngine.Experimental.Rendering.GraphicsFormat  @format, System.Int32  @antiAliasing, System.Boolean  @enableRandomWrite, UnityEngine.RenderTextureMemoryless  @memorylessMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @depthBuffer, @filter, @format, @antiAliasing, @enableRandomWrite, @memorylessMode};
            var ___result = RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_RenderTextureMemoryless.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRT(System.Int32  @nameID, System.Int32  @width, System.Int32  @height, System.Int32  @depthBuffer, UnityEngine.FilterMode  @filter, UnityEngine.Experimental.Rendering.GraphicsFormat  @format, System.Int32  @antiAliasing, System.Boolean  @enableRandomWrite)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @depthBuffer, @filter, @format, @antiAliasing, @enableRandomWrite};
            var ___result = RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRT(System.Int32  @nameID, System.Int32  @width, System.Int32  @height, System.Int32  @depthBuffer, UnityEngine.FilterMode  @filter, UnityEngine.Experimental.Rendering.GraphicsFormat  @format, System.Int32  @antiAliasing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @depthBuffer, @filter, @format, @antiAliasing};
            var ___result = RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRT(System.Int32  @nameID, System.Int32  @width, System.Int32  @height, System.Int32  @depthBuffer, UnityEngine.FilterMode  @filter, UnityEngine.Experimental.Rendering.GraphicsFormat  @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @depthBuffer, @filter, @format};
            var ___result = RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRT(System.Int32  @nameID, System.Int32  @width, System.Int32  @height, System.Int32  @depthBuffer, UnityEngine.FilterMode  @filter, UnityEngine.RenderTextureFormat  @format, UnityEngine.RenderTextureReadWrite  @readWrite, System.Int32  @antiAliasing, System.Boolean  @enableRandomWrite, UnityEngine.RenderTextureMemoryless  @memorylessMode, System.Boolean  @useDynamicScale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @depthBuffer, @filter, @format, @readWrite, @antiAliasing, @enableRandomWrite, @memorylessMode, @useDynamicScale};
            var ___result = RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_RenderTextureMemoryless_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRT(System.Int32  @nameID, System.Int32  @width, System.Int32  @height, System.Int32  @depthBuffer, UnityEngine.FilterMode  @filter, UnityEngine.RenderTextureFormat  @format, UnityEngine.RenderTextureReadWrite  @readWrite, System.Int32  @antiAliasing, System.Boolean  @enableRandomWrite, UnityEngine.RenderTextureMemoryless  @memorylessMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @depthBuffer, @filter, @format, @readWrite, @antiAliasing, @enableRandomWrite, @memorylessMode};
            var ___result = RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_RenderTextureMemoryless.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRT(System.Int32  @nameID, System.Int32  @width, System.Int32  @height, System.Int32  @depthBuffer, UnityEngine.FilterMode  @filter, UnityEngine.RenderTextureFormat  @format, UnityEngine.RenderTextureReadWrite  @readWrite, System.Int32  @antiAliasing, System.Boolean  @enableRandomWrite)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @depthBuffer, @filter, @format, @readWrite, @antiAliasing, @enableRandomWrite};
            var ___result = RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRT(System.Int32  @nameID, System.Int32  @width, System.Int32  @height, System.Int32  @depthBuffer, UnityEngine.FilterMode  @filter, UnityEngine.RenderTextureFormat  @format, UnityEngine.RenderTextureReadWrite  @readWrite, System.Int32  @antiAliasing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @depthBuffer, @filter, @format, @readWrite, @antiAliasing};
            var ___result = RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRT(System.Int32  @nameID, System.Int32  @width, System.Int32  @height, System.Int32  @depthBuffer, UnityEngine.FilterMode  @filter, UnityEngine.RenderTextureFormat  @format, UnityEngine.RenderTextureReadWrite  @readWrite)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @depthBuffer, @filter, @format, @readWrite};
            var ___result = RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRT(System.Int32  @nameID, System.Int32  @width, System.Int32  @height, System.Int32  @depthBuffer, UnityEngine.FilterMode  @filter, UnityEngine.RenderTextureFormat  @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @depthBuffer, @filter, @format};
            var ___result = RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRT(System.Int32  @nameID, System.Int32  @width, System.Int32  @height, System.Int32  @depthBuffer, UnityEngine.FilterMode  @filter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @depthBuffer, @filter};
            var ___result = RGetTemporaryRT_Int32_Int32_Int32_Int32_FilterMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRT(System.Int32  @nameID, System.Int32  @width, System.Int32  @height, System.Int32  @depthBuffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @depthBuffer};
            var ___result = RGetTemporaryRT_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRT(System.Int32  @nameID, System.Int32  @width, System.Int32  @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height};
            var ___result = RGetTemporaryRT_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRTWithDescriptor(System.Int32  @nameID, UnityEngine.RenderTextureDescriptor  @desc, UnityEngine.FilterMode  @filter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @desc, @filter};
            var ___result = RGetTemporaryRTWithDescriptor_Int32_RenderTextureDescriptor_FilterMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRT(System.Int32  @nameID, UnityEngine.RenderTextureDescriptor  @desc, UnityEngine.FilterMode  @filter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @desc, @filter};
            var ___result = RGetTemporaryRT_Int32_RenderTextureDescriptor_FilterMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRT(System.Int32  @nameID, UnityEngine.RenderTextureDescriptor  @desc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @desc};
            var ___result = RGetTemporaryRT_Int32_RenderTextureDescriptor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRTArray(System.Int32  @nameID, System.Int32  @width, System.Int32  @height, System.Int32  @slices, System.Int32  @depthBuffer, UnityEngine.FilterMode  @filter, UnityEngine.Experimental.Rendering.GraphicsFormat  @format, System.Int32  @antiAliasing, System.Boolean  @enableRandomWrite, System.Boolean  @useDynamicScale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @slices, @depthBuffer, @filter, @format, @antiAliasing, @enableRandomWrite, @useDynamicScale};
            var ___result = RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRTArray(System.Int32  @nameID, System.Int32  @width, System.Int32  @height, System.Int32  @slices, System.Int32  @depthBuffer, UnityEngine.FilterMode  @filter, UnityEngine.Experimental.Rendering.GraphicsFormat  @format, System.Int32  @antiAliasing, System.Boolean  @enableRandomWrite)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @slices, @depthBuffer, @filter, @format, @antiAliasing, @enableRandomWrite};
            var ___result = RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRTArray(System.Int32  @nameID, System.Int32  @width, System.Int32  @height, System.Int32  @slices, System.Int32  @depthBuffer, UnityEngine.FilterMode  @filter, UnityEngine.Experimental.Rendering.GraphicsFormat  @format, System.Int32  @antiAliasing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @slices, @depthBuffer, @filter, @format, @antiAliasing};
            var ___result = RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRTArray(System.Int32  @nameID, System.Int32  @width, System.Int32  @height, System.Int32  @slices, System.Int32  @depthBuffer, UnityEngine.FilterMode  @filter, UnityEngine.Experimental.Rendering.GraphicsFormat  @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @slices, @depthBuffer, @filter, @format};
            var ___result = RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRTArray(System.Int32  @nameID, System.Int32  @width, System.Int32  @height, System.Int32  @slices, System.Int32  @depthBuffer, UnityEngine.FilterMode  @filter, UnityEngine.RenderTextureFormat  @format, UnityEngine.RenderTextureReadWrite  @readWrite, System.Int32  @antiAliasing, System.Boolean  @enableRandomWrite)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @slices, @depthBuffer, @filter, @format, @readWrite, @antiAliasing, @enableRandomWrite};
            var ___result = RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRTArray(System.Int32  @nameID, System.Int32  @width, System.Int32  @height, System.Int32  @slices, System.Int32  @depthBuffer, UnityEngine.FilterMode  @filter, UnityEngine.RenderTextureFormat  @format, UnityEngine.RenderTextureReadWrite  @readWrite, System.Int32  @antiAliasing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @slices, @depthBuffer, @filter, @format, @readWrite, @antiAliasing};
            var ___result = RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRTArray(System.Int32  @nameID, System.Int32  @width, System.Int32  @height, System.Int32  @slices, System.Int32  @depthBuffer, UnityEngine.FilterMode  @filter, UnityEngine.RenderTextureFormat  @format, UnityEngine.RenderTextureReadWrite  @readWrite)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @slices, @depthBuffer, @filter, @format, @readWrite};
            var ___result = RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRTArray(System.Int32  @nameID, System.Int32  @width, System.Int32  @height, System.Int32  @slices, System.Int32  @depthBuffer, UnityEngine.FilterMode  @filter, UnityEngine.RenderTextureFormat  @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @slices, @depthBuffer, @filter, @format};
            var ___result = RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRTArray(System.Int32  @nameID, System.Int32  @width, System.Int32  @height, System.Int32  @slices, System.Int32  @depthBuffer, UnityEngine.FilterMode  @filter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @slices, @depthBuffer, @filter};
            var ___result = RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32_FilterMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRTArray(System.Int32  @nameID, System.Int32  @width, System.Int32  @height, System.Int32  @slices, System.Int32  @depthBuffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @slices, @depthBuffer};
            var ___result = RGetTemporaryRTArray_Int32_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTemporaryRTArray(System.Int32  @nameID, System.Int32  @width, System.Int32  @height, System.Int32  @slices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @width, @height, @slices};
            var ___result = RGetTemporaryRTArray_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReleaseTemporaryRT(System.Int32  @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RReleaseTemporaryRT_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearRenderTarget(UnityEngine.Rendering.RTClearFlags  @clearFlags, UnityEngine.Color  @backgroundColor, System.Single  @depth, System.UInt32  @stencil)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clearFlags, @backgroundColor, @depth, @stencil};
            var ___result = RClearRenderTarget_RTClearFlags_Color_Single_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearRenderTarget(System.Boolean  @clearDepth, System.Boolean  @clearColor, UnityEngine.Color  @backgroundColor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clearDepth, @clearColor, @backgroundColor};
            var ___result = RClearRenderTarget_Boolean_Boolean_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearRenderTarget(System.Boolean  @clearDepth, System.Boolean  @clearColor, UnityEngine.Color  @backgroundColor, System.Single  @depth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clearDepth, @clearColor, @backgroundColor, @depth};
            var ___result = RClearRenderTarget_Boolean_Boolean_Color_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalFloat(System.Int32  @nameID, System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetGlobalFloat_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalInt(System.Int32  @nameID, System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetGlobalInt_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalInteger(System.Int32  @nameID, System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetGlobalInteger_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalVector(System.Int32  @nameID, UnityEngine.Vector4  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetGlobalVector_Int32_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalColor(System.Int32  @nameID, UnityEngine.Color  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetGlobalColor_Int32_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalMatrix(System.Int32  @nameID, UnityEngine.Matrix4x4  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetGlobalMatrix_Int32_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnableShaderKeyword(System.String  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = REnableShaderKeyword_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnableGlobalKeyword(UnityEngine.Rendering.GlobalKeyword  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = REnableGlobalKeyword_GlobalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnableMaterialKeyword(UnityEngine.Material  @material, UnityEngine.Rendering.LocalKeyword  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@material, @keyword};
            var ___result = REnableMaterialKeyword_Material_LocalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnableComputeKeyword(UnityEngine.ComputeShader  @computeShader, UnityEngine.Rendering.LocalKeyword  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @keyword};
            var ___result = REnableComputeKeyword_ComputeShader_LocalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnableKeyword(in UnityEngine.Rendering.GlobalKeyword  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = REnableKeyword_In_GlobalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnableKeyword(UnityEngine.Material  @material, in UnityEngine.Rendering.LocalKeyword  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@material, @keyword};
            var ___result = REnableKeyword_Material_In_LocalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnableKeyword(UnityEngine.ComputeShader  @computeShader, in UnityEngine.Rendering.LocalKeyword  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @keyword};
            var ___result = REnableKeyword_ComputeShader_In_LocalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DisableShaderKeyword(System.String  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RDisableShaderKeyword_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DisableGlobalKeyword(UnityEngine.Rendering.GlobalKeyword  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RDisableGlobalKeyword_GlobalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DisableMaterialKeyword(UnityEngine.Material  @material, UnityEngine.Rendering.LocalKeyword  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@material, @keyword};
            var ___result = RDisableMaterialKeyword_Material_LocalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DisableComputeKeyword(UnityEngine.ComputeShader  @computeShader, UnityEngine.Rendering.LocalKeyword  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @keyword};
            var ___result = RDisableComputeKeyword_ComputeShader_LocalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DisableKeyword(in UnityEngine.Rendering.GlobalKeyword  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RDisableKeyword_In_GlobalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DisableKeyword(UnityEngine.Material  @material, in UnityEngine.Rendering.LocalKeyword  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@material, @keyword};
            var ___result = RDisableKeyword_Material_In_LocalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DisableKeyword(UnityEngine.ComputeShader  @computeShader, in UnityEngine.Rendering.LocalKeyword  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @keyword};
            var ___result = RDisableKeyword_ComputeShader_In_LocalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalKeyword(UnityEngine.Rendering.GlobalKeyword  @keyword, System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword, @value};
            var ___result = RSetGlobalKeyword_GlobalKeyword_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMaterialKeyword(UnityEngine.Material  @material, UnityEngine.Rendering.LocalKeyword  @keyword, System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@material, @keyword, @value};
            var ___result = RSetMaterialKeyword_Material_LocalKeyword_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeKeyword(UnityEngine.ComputeShader  @computeShader, UnityEngine.Rendering.LocalKeyword  @keyword, System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @keyword, @value};
            var ___result = RSetComputeKeyword_ComputeShader_LocalKeyword_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetKeyword(in UnityEngine.Rendering.GlobalKeyword  @keyword, System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword, @value};
            var ___result = RSetKeyword_In_GlobalKeyword_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetKeyword(UnityEngine.Material  @material, in UnityEngine.Rendering.LocalKeyword  @keyword, System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@material, @keyword, @value};
            var ___result = RSetKeyword_Material_In_LocalKeyword_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetKeyword(UnityEngine.ComputeShader  @computeShader, in UnityEngine.Rendering.LocalKeyword  @keyword, System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @keyword, @value};
            var ___result = RSetKeyword_ComputeShader_In_LocalKeyword_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetViewMatrix(UnityEngine.Matrix4x4  @view)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@view};
            var ___result = RSetViewMatrix_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetProjectionMatrix(UnityEngine.Matrix4x4  @proj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@proj};
            var ___result = RSetProjectionMatrix_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetViewProjectionMatrices(UnityEngine.Matrix4x4  @view, UnityEngine.Matrix4x4  @proj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@view, @proj};
            var ___result = RSetViewProjectionMatrices_Matrix4x4_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalDepthBias(System.Single  @bias, System.Single  @slopeBias)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bias, @slopeBias};
            var ___result = RSetGlobalDepthBias_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetExecutionFlags(UnityEngine.Rendering.CommandBufferExecutionFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flags};
            var ___result = RSetExecutionFlags_CommandBufferExecutionFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ValidateAgainstExecutionFlags(UnityEngine.Rendering.CommandBufferExecutionFlags  @requiredFlags, UnityEngine.Rendering.CommandBufferExecutionFlags  @invalidFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@requiredFlags, @invalidFlags};
            var ___result = RValidateAgainstExecutionFlags_CommandBufferExecutionFlags_CommandBufferExecutionFlags.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetGlobalFloatArrayListImpl(System.Int32  @nameID, System.Object  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetGlobalFloatArrayListImpl_Int32_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalVectorArrayListImpl(System.Int32  @nameID, System.Object  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetGlobalVectorArrayListImpl_Int32_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalMatrixArrayListImpl(System.Int32  @nameID, System.Object  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetGlobalMatrixArrayListImpl_Int32_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalFloatArray(System.Int32  @nameID, System.Single[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetGlobalFloatArray_Int32_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalVectorArray(System.Int32  @nameID, UnityEngine.Vector4[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetGlobalVectorArray_Int32_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalMatrixArray(System.Int32  @nameID, UnityEngine.Matrix4x4[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetGlobalMatrixArray_Int32_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetLateLatchProjectionMatrices(UnityEngine.Matrix4x4[]  @projectionMat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@projectionMat};
            var ___result = RSetLateLatchProjectionMatrices_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkLateLatchMatrixShaderPropertyID(UnityEngine.Rendering.CameraLateLatchMatrixType  @matrixPropertyType, System.Int32  @shaderPropertyID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrixPropertyType, @shaderPropertyID};
            var ___result = RMarkLateLatchMatrixShaderPropertyID_CameraLateLatchMatrixType_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnmarkLateLatchMatrix(UnityEngine.Rendering.CameraLateLatchMatrixType  @matrixPropertyType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrixPropertyType};
            var ___result = RUnmarkLateLatchMatrix_CameraLateLatchMatrixType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalTexture_Impl(System.Int32  @nameID, ref UnityEngine.Rendering.RenderTargetIdentifier  @rt, UnityEngine.Rendering.RenderTextureSubElement  @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @rt, @element};
            var ___result = RSetGlobalTexture_Impl_Int32_Ref_RenderTargetIdentifier_RenderTextureSubElement.Invoke(___genericsType, ___parameters);
			rt = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[1];

            
        }


        public virtual void SetGlobalBufferInternal(System.Int32  @nameID, UnityEngine.ComputeBuffer  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetGlobalBufferInternal_Int32_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalGraphicsBufferInternal(System.Int32  @nameID, UnityEngine.GraphicsBuffer  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetGlobalGraphicsBufferInternal_Int32_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetShadowSamplingMode_Impl(ref UnityEngine.Rendering.RenderTargetIdentifier  @shadowmap, UnityEngine.Rendering.ShadowSamplingMode  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shadowmap, @mode};
            var ___result = RSetShadowSamplingMode_Impl_Ref_RenderTargetIdentifier_ShadowSamplingMode.Invoke(___genericsType, ___parameters);
			shadowmap = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[0];

            
        }


        public virtual void IssuePluginEventInternal(System.IntPtr  @callback, System.Int32  @eventID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @eventID};
            var ___result = RIssuePluginEventInternal_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BeginSample(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RBeginSample_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EndSample(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = REndSample_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BeginSample(UnityEngine.Profiling.CustomSampler  @sampler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sampler};
            var ___result = RBeginSample_CustomSampler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EndSample(UnityEngine.Profiling.CustomSampler  @sampler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sampler};
            var ___result = REndSample_CustomSampler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BeginSample_CustomSampler(UnityEngine.Profiling.CustomSampler  @sampler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sampler};
            var ___result = RBeginSample_CustomSampler_CustomSampler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EndSample_CustomSampler(UnityEngine.Profiling.CustomSampler  @sampler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sampler};
            var ___result = REndSample_CustomSampler_CustomSampler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BeginSample(Unity.Profiling.ProfilerMarker  @marker)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@marker};
            var ___result = RBeginSample_ProfilerMarker.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EndSample(Unity.Profiling.ProfilerMarker  @marker)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@marker};
            var ___result = REndSample_ProfilerMarker.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BeginSample_ProfilerMarker(System.IntPtr  @markerHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@markerHandle};
            var ___result = RBeginSample_ProfilerMarker_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EndSample_ProfilerMarker(System.IntPtr  @markerHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@markerHandle};
            var ___result = REndSample_ProfilerMarker_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IssuePluginEventAndDataInternal(System.IntPtr  @callback, System.Int32  @eventID, System.IntPtr  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @eventID, @data};
            var ___result = RIssuePluginEventAndDataInternal_IntPtr_Int32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IssuePluginEventAndDataInternalWithFlags(System.IntPtr  @callback, System.Int32  @eventID, UnityEngine.Rendering.CustomMarkerCallbackFlags  @flags, System.IntPtr  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @eventID, @flags, @data};
            var ___result = RIssuePluginEventAndDataInternalWithFlags_IntPtr_Int32_CustomMarkerCallbackFlags_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IssuePluginCustomBlitInternal(System.IntPtr  @callback, System.UInt32  @command, ref UnityEngine.Rendering.RenderTargetIdentifier  @source, ref UnityEngine.Rendering.RenderTargetIdentifier  @dest, System.UInt32  @commandParam, System.UInt32  @commandFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @command, @source, @dest, @commandParam, @commandFlags};
            var ___result = RIssuePluginCustomBlitInternal_IntPtr_UInt32_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_UInt32_UInt32.Invoke(___genericsType, ___parameters);
			source = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[2];
			dest = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[3];

            
        }


        public virtual void IssuePluginCustomTextureUpdateInternal(System.IntPtr  @callback, UnityEngine.Texture  @targetTexture, System.UInt32  @userData, System.Boolean  @useNewUnityRenderingExtTextureUpdateParamsV2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @targetTexture, @userData, @useNewUnityRenderingExtTextureUpdateParamsV2};
            var ___result = RIssuePluginCustomTextureUpdateInternal_IntPtr_Texture_UInt32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalConstantBufferInternal(UnityEngine.ComputeBuffer  @buffer, System.Int32  @nameID, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @nameID, @offset, @size};
            var ___result = RSetGlobalConstantBufferInternal_ComputeBuffer_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalConstantGraphicsBufferInternal(UnityEngine.GraphicsBuffer  @buffer, System.Int32  @nameID, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @nameID, @offset, @size};
            var ___result = RSetGlobalConstantGraphicsBufferInternal_GraphicsBuffer_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IncrementUpdateCount(UnityEngine.Rendering.RenderTargetIdentifier  @dest)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dest};
            var ___result = RIncrementUpdateCount_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInstanceMultiplier(System.UInt32  @multiplier)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@multiplier};
            var ___result = RSetInstanceMultiplier_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFoveatedRenderingMode(UnityEngine.Rendering.FoveatedRenderingMode  @foveatedRenderingMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@foveatedRenderingMode};
            var ___result = RSetFoveatedRenderingMode_FoveatedRenderingMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ConfigureFoveatedRendering(System.IntPtr  @platformData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@platformData};
            var ___result = RConfigureFoveatedRendering_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier  @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt};
            var ___result = RSetRenderTarget_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier  @rt, UnityEngine.Rendering.RenderBufferLoadAction  @loadAction, UnityEngine.Rendering.RenderBufferStoreAction  @storeAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt, @loadAction, @storeAction};
            var ___result = RSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier  @rt, UnityEngine.Rendering.RenderBufferLoadAction  @colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction  @colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction  @depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction  @depthStoreAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt, @colorLoadAction, @colorStoreAction, @depthLoadAction, @depthStoreAction};
            var ___result = RSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier  @rt, System.Int32  @mipLevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt, @mipLevel};
            var ___result = RSetRenderTarget_RenderTargetIdentifier_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier  @rt, System.Int32  @mipLevel, UnityEngine.CubemapFace  @cubemapFace)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt, @mipLevel, @cubemapFace};
            var ___result = RSetRenderTarget_RenderTargetIdentifier_Int32_CubemapFace.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier  @rt, System.Int32  @mipLevel, UnityEngine.CubemapFace  @cubemapFace, System.Int32  @depthSlice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt, @mipLevel, @cubemapFace, @depthSlice};
            var ___result = RSetRenderTarget_RenderTargetIdentifier_Int32_CubemapFace_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier  @color, UnityEngine.Rendering.RenderTargetIdentifier  @depth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color, @depth};
            var ___result = RSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier  @color, UnityEngine.Rendering.RenderTargetIdentifier  @depth, System.Int32  @mipLevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color, @depth, @mipLevel};
            var ___result = RSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier  @color, UnityEngine.Rendering.RenderTargetIdentifier  @depth, System.Int32  @mipLevel, UnityEngine.CubemapFace  @cubemapFace)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color, @depth, @mipLevel, @cubemapFace};
            var ___result = RSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32_CubemapFace.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier  @color, UnityEngine.Rendering.RenderTargetIdentifier  @depth, System.Int32  @mipLevel, UnityEngine.CubemapFace  @cubemapFace, System.Int32  @depthSlice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color, @depth, @mipLevel, @cubemapFace, @depthSlice};
            var ___result = RSetRenderTarget_RenderTargetIdentifier_RenderTargetIdentifier_Int32_CubemapFace_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier  @color, UnityEngine.Rendering.RenderBufferLoadAction  @colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction  @colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier  @depth, UnityEngine.Rendering.RenderBufferLoadAction  @depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction  @depthStoreAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color, @colorLoadAction, @colorStoreAction, @depth, @depthLoadAction, @depthStoreAction};
            var ___result = RSetRenderTarget_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier[]  @colors, UnityEngine.Rendering.RenderTargetIdentifier  @depth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colors, @depth};
            var ___result = RSetRenderTarget_RenderTargetIdentifierArray_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier[]  @colors, UnityEngine.Rendering.RenderTargetIdentifier  @depth, System.Int32  @mipLevel, UnityEngine.CubemapFace  @cubemapFace, System.Int32  @depthSlice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colors, @depth, @mipLevel, @cubemapFace, @depthSlice};
            var ___result = RSetRenderTarget_RenderTargetIdentifierArray_RenderTargetIdentifier_Int32_CubemapFace_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTarget(UnityEngine.Rendering.RenderTargetBinding  @binding, System.Int32  @mipLevel, UnityEngine.CubemapFace  @cubemapFace, System.Int32  @depthSlice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@binding, @mipLevel, @cubemapFace, @depthSlice};
            var ___result = RSetRenderTarget_RenderTargetBinding_Int32_CubemapFace_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTarget(UnityEngine.Rendering.RenderTargetBinding  @binding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@binding};
            var ___result = RSetRenderTarget_RenderTargetBinding.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTargetSingle_Internal(UnityEngine.Rendering.RenderTargetIdentifier  @rt, UnityEngine.Rendering.RenderBufferLoadAction  @colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction  @colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction  @depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction  @depthStoreAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt, @colorLoadAction, @colorStoreAction, @depthLoadAction, @depthStoreAction};
            var ___result = RSetRenderTargetSingle_Internal_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTargetColorDepth_Internal(UnityEngine.Rendering.RenderTargetIdentifier  @color, UnityEngine.Rendering.RenderTargetIdentifier  @depth, UnityEngine.Rendering.RenderBufferLoadAction  @colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction  @colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction  @depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction  @depthStoreAction, UnityEngine.Rendering.RenderTargetFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color, @depth, @colorLoadAction, @colorStoreAction, @depthLoadAction, @depthStoreAction, @flags};
            var ___result = RSetRenderTargetColorDepth_Internal_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTargetMulti_Internal(UnityEngine.Rendering.RenderTargetIdentifier[]  @colors, UnityEngine.Rendering.RenderTargetIdentifier  @depth, UnityEngine.Rendering.RenderBufferLoadAction[]  @colorLoadActions, UnityEngine.Rendering.RenderBufferStoreAction[]  @colorStoreActions, UnityEngine.Rendering.RenderBufferLoadAction  @depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction  @depthStoreAction, UnityEngine.Rendering.RenderTargetFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colors, @depth, @colorLoadActions, @colorStoreActions, @depthLoadAction, @depthStoreAction, @flags};
            var ___result = RSetRenderTargetMulti_Internal_RenderTargetIdentifierArray_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTargetColorDepthSubtarget(UnityEngine.Rendering.RenderTargetIdentifier  @color, UnityEngine.Rendering.RenderTargetIdentifier  @depth, UnityEngine.Rendering.RenderBufferLoadAction  @colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction  @colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction  @depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction  @depthStoreAction, System.Int32  @mipLevel, UnityEngine.CubemapFace  @cubemapFace, System.Int32  @depthSlice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color, @depth, @colorLoadAction, @colorStoreAction, @depthLoadAction, @depthStoreAction, @mipLevel, @cubemapFace, @depthSlice};
            var ___result = RSetRenderTargetColorDepthSubtarget_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTargetMultiSubtarget(UnityEngine.Rendering.RenderTargetIdentifier[]  @colors, UnityEngine.Rendering.RenderTargetIdentifier  @depth, UnityEngine.Rendering.RenderBufferLoadAction[]  @colorLoadActions, UnityEngine.Rendering.RenderBufferStoreAction[]  @colorStoreActions, UnityEngine.Rendering.RenderBufferLoadAction  @depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction  @depthStoreAction, System.Int32  @mipLevel, UnityEngine.CubemapFace  @cubemapFace, System.Int32  @depthSlice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colors, @depth, @colorLoadActions, @colorStoreActions, @depthLoadAction, @depthStoreAction, @mipLevel, @cubemapFace, @depthSlice};
            var ___result = RSetRenderTargetMultiSubtarget_RenderTargetIdentifierArray_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_ProcessVTFeedback(UnityEngine.Rendering.RenderTargetIdentifier  @rt, System.IntPtr  @resolver, System.Int32  @slice, System.Int32  @x, System.Int32  @width, System.Int32  @y, System.Int32  @height, System.Int32  @mip)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt, @resolver, @slice, @x, @width, @y, @height, @mip};
            var ___result = RInternal_ProcessVTFeedback_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBufferData(UnityEngine.ComputeBuffer  @buffer, System.Array  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @data};
            var ___result = RSetBufferData_ComputeBuffer_Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBufferData<T>(UnityEngine.ComputeBuffer  @buffer, System.Collections.Generic.List<T>  @data) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@buffer, @data};
            var ___result = RSetBufferData_GT_ComputeBuffer_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void SetBufferData(UnityEngine.ComputeBuffer  @buffer, System.Array  @data, System.Int32  @managedBufferStartIndex, System.Int32  @graphicsBufferStartIndex, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @data, @managedBufferStartIndex, @graphicsBufferStartIndex, @count};
            var ___result = RSetBufferData_ComputeBuffer_Array_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBufferData<T>(UnityEngine.ComputeBuffer  @buffer, System.Collections.Generic.List<T>  @data, System.Int32  @managedBufferStartIndex, System.Int32  @graphicsBufferStartIndex, System.Int32  @count) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@buffer, @data, @managedBufferStartIndex, @graphicsBufferStartIndex, @count};
            var ___result = RSetBufferData_GT_ComputeBuffer_List_d_T_p__Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void SetBufferCounterValue(UnityEngine.ComputeBuffer  @buffer, System.UInt32  @counterValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @counterValue};
            var ___result = RSetBufferCounterValue_ComputeBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalSetComputeBufferNativeData(UnityEngine.ComputeBuffer  @buffer, System.IntPtr  @data, System.Int32  @nativeBufferStartIndex, System.Int32  @graphicsBufferStartIndex, System.Int32  @count, System.Int32  @elemSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @data, @nativeBufferStartIndex, @graphicsBufferStartIndex, @count, @elemSize};
            var ___result = RInternalSetComputeBufferNativeData_ComputeBuffer_IntPtr_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalSetComputeBufferData(UnityEngine.ComputeBuffer  @buffer, System.Array  @data, System.Int32  @managedBufferStartIndex, System.Int32  @graphicsBufferStartIndex, System.Int32  @count, System.Int32  @elemSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @data, @managedBufferStartIndex, @graphicsBufferStartIndex, @count, @elemSize};
            var ___result = RInternalSetComputeBufferData_ComputeBuffer_Array_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalSetComputeBufferCounterValue(UnityEngine.ComputeBuffer  @buffer, System.UInt32  @counterValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @counterValue};
            var ___result = RInternalSetComputeBufferCounterValue_ComputeBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBufferData(UnityEngine.GraphicsBuffer  @buffer, System.Array  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @data};
            var ___result = RSetBufferData_GraphicsBuffer_Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBufferData<T>(UnityEngine.GraphicsBuffer  @buffer, System.Collections.Generic.List<T>  @data) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@buffer, @data};
            var ___result = RSetBufferData_GT_GraphicsBuffer_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void SetBufferData(UnityEngine.GraphicsBuffer  @buffer, System.Array  @data, System.Int32  @managedBufferStartIndex, System.Int32  @graphicsBufferStartIndex, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @data, @managedBufferStartIndex, @graphicsBufferStartIndex, @count};
            var ___result = RSetBufferData_GraphicsBuffer_Array_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBufferData<T>(UnityEngine.GraphicsBuffer  @buffer, System.Collections.Generic.List<T>  @data, System.Int32  @managedBufferStartIndex, System.Int32  @graphicsBufferStartIndex, System.Int32  @count) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@buffer, @data, @managedBufferStartIndex, @graphicsBufferStartIndex, @count};
            var ___result = RSetBufferData_GT_GraphicsBuffer_List_d_T_p__Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void SetBufferCounterValue(UnityEngine.GraphicsBuffer  @buffer, System.UInt32  @counterValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @counterValue};
            var ___result = RSetBufferCounterValue_GraphicsBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalSetGraphicsBufferNativeData(UnityEngine.GraphicsBuffer  @buffer, System.IntPtr  @data, System.Int32  @nativeBufferStartIndex, System.Int32  @graphicsBufferStartIndex, System.Int32  @count, System.Int32  @elemSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @data, @nativeBufferStartIndex, @graphicsBufferStartIndex, @count, @elemSize};
            var ___result = RInternalSetGraphicsBufferNativeData_GraphicsBuffer_IntPtr_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalSetGraphicsBufferData(UnityEngine.GraphicsBuffer  @buffer, System.Array  @data, System.Int32  @managedBufferStartIndex, System.Int32  @graphicsBufferStartIndex, System.Int32  @count, System.Int32  @elemSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @data, @managedBufferStartIndex, @graphicsBufferStartIndex, @count, @elemSize};
            var ___result = RInternalSetGraphicsBufferData_GraphicsBuffer_Array_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalSetGraphicsBufferCounterValue(UnityEngine.GraphicsBuffer  @buffer, System.UInt32  @counterValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @counterValue};
            var ___result = RInternalSetGraphicsBufferCounterValue_GraphicsBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyBufferImpl(UnityEngine.GraphicsBuffer  @source, UnityEngine.GraphicsBuffer  @dest)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest};
            var ___result = RCopyBufferImpl_GraphicsBuffer_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean  @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Release()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRelease.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rendering.GraphicsFence CreateAsyncGraphicsFence()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateAsyncGraphicsFence.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.GraphicsFence)___result;
        }


        public virtual UnityEngine.Rendering.GraphicsFence CreateAsyncGraphicsFence(UnityEngine.Rendering.SynchronisationStage  @stage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stage};
            var ___result = RCreateAsyncGraphicsFence_SynchronisationStage.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.GraphicsFence)___result;
        }


        public virtual UnityEngine.Rendering.GraphicsFence CreateGraphicsFence(UnityEngine.Rendering.GraphicsFenceType  @fenceType, UnityEngine.Rendering.SynchronisationStageFlags  @stage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fenceType, @stage};
            var ___result = RCreateGraphicsFence_GraphicsFenceType_SynchronisationStageFlags.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.GraphicsFence)___result;
        }


        public virtual void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence  @fence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fence};
            var ___result = RWaitOnAsyncGraphicsFence_GraphicsFence.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence  @fence, UnityEngine.Rendering.SynchronisationStage  @stage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fence, @stage};
            var ___result = RWaitOnAsyncGraphicsFence_GraphicsFence_SynchronisationStage.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence  @fence, UnityEngine.Rendering.SynchronisationStageFlags  @stage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fence, @stage};
            var ___result = RWaitOnAsyncGraphicsFence_GraphicsFence_SynchronisationStageFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeFloatParam(UnityEngine.ComputeShader  @computeShader, System.String  @name, System.Single  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @name, @val};
            var ___result = RSetComputeFloatParam_ComputeShader_String_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeIntParam(UnityEngine.ComputeShader  @computeShader, System.String  @name, System.Int32  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @name, @val};
            var ___result = RSetComputeIntParam_ComputeShader_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeVectorParam(UnityEngine.ComputeShader  @computeShader, System.String  @name, UnityEngine.Vector4  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @name, @val};
            var ___result = RSetComputeVectorParam_ComputeShader_String_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeVectorArrayParam(UnityEngine.ComputeShader  @computeShader, System.String  @name, UnityEngine.Vector4[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @name, @values};
            var ___result = RSetComputeVectorArrayParam_ComputeShader_String_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeMatrixParam(UnityEngine.ComputeShader  @computeShader, System.String  @name, UnityEngine.Matrix4x4  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @name, @val};
            var ___result = RSetComputeMatrixParam_ComputeShader_String_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeMatrixArrayParam(UnityEngine.ComputeShader  @computeShader, System.String  @name, UnityEngine.Matrix4x4[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @name, @values};
            var ___result = RSetComputeMatrixArrayParam_ComputeShader_String_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeFloatParams(UnityEngine.ComputeShader  @computeShader, System.String  @name, System.Single[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @name, @values};
            var ___result = RSetComputeFloatParams_ComputeShader_String_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeFloatParams(UnityEngine.ComputeShader  @computeShader, System.Int32  @nameID, System.Single[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @nameID, @values};
            var ___result = RSetComputeFloatParams_ComputeShader_Int32_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeIntParams(UnityEngine.ComputeShader  @computeShader, System.String  @name, System.Int32[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @name, @values};
            var ___result = RSetComputeIntParams_ComputeShader_String_Int32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeIntParams(UnityEngine.ComputeShader  @computeShader, System.Int32  @nameID, System.Int32[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @nameID, @values};
            var ___result = RSetComputeIntParams_ComputeShader_Int32_Int32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeTextureParam(UnityEngine.ComputeShader  @computeShader, System.Int32  @kernelIndex, System.String  @name, UnityEngine.Rendering.RenderTargetIdentifier  @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @name, @rt};
            var ___result = RSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeTextureParam(UnityEngine.ComputeShader  @computeShader, System.Int32  @kernelIndex, System.Int32  @nameID, UnityEngine.Rendering.RenderTargetIdentifier  @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @nameID, @rt};
            var ___result = RSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeTextureParam(UnityEngine.ComputeShader  @computeShader, System.Int32  @kernelIndex, System.String  @name, UnityEngine.Rendering.RenderTargetIdentifier  @rt, System.Int32  @mipLevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @name, @rt, @mipLevel};
            var ___result = RSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeTextureParam(UnityEngine.ComputeShader  @computeShader, System.Int32  @kernelIndex, System.Int32  @nameID, UnityEngine.Rendering.RenderTargetIdentifier  @rt, System.Int32  @mipLevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @nameID, @rt, @mipLevel};
            var ___result = RSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeTextureParam(UnityEngine.ComputeShader  @computeShader, System.Int32  @kernelIndex, System.String  @name, UnityEngine.Rendering.RenderTargetIdentifier  @rt, System.Int32  @mipLevel, UnityEngine.Rendering.RenderTextureSubElement  @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @name, @rt, @mipLevel, @element};
            var ___result = RSetComputeTextureParam_ComputeShader_Int32_String_RenderTargetIdentifier_Int32_RenderTextureSubElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeTextureParam(UnityEngine.ComputeShader  @computeShader, System.Int32  @kernelIndex, System.Int32  @nameID, UnityEngine.Rendering.RenderTargetIdentifier  @rt, System.Int32  @mipLevel, UnityEngine.Rendering.RenderTextureSubElement  @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @nameID, @rt, @mipLevel, @element};
            var ___result = RSetComputeTextureParam_ComputeShader_Int32_Int32_RenderTargetIdentifier_Int32_RenderTextureSubElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeBufferParam(UnityEngine.ComputeShader  @computeShader, System.Int32  @kernelIndex, System.Int32  @nameID, UnityEngine.ComputeBuffer  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @nameID, @buffer};
            var ___result = RSetComputeBufferParam_ComputeShader_Int32_Int32_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeBufferParam(UnityEngine.ComputeShader  @computeShader, System.Int32  @kernelIndex, System.String  @name, UnityEngine.ComputeBuffer  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @name, @buffer};
            var ___result = RSetComputeBufferParam_ComputeShader_Int32_String_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeBufferParam(UnityEngine.ComputeShader  @computeShader, System.Int32  @kernelIndex, System.Int32  @nameID, UnityEngine.GraphicsBufferHandle  @bufferHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @nameID, @bufferHandle};
            var ___result = RSetComputeBufferParam_ComputeShader_Int32_Int32_GraphicsBufferHandle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeBufferParam(UnityEngine.ComputeShader  @computeShader, System.Int32  @kernelIndex, System.String  @name, UnityEngine.GraphicsBufferHandle  @bufferHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @name, @bufferHandle};
            var ___result = RSetComputeBufferParam_ComputeShader_Int32_String_GraphicsBufferHandle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeBufferParam(UnityEngine.ComputeShader  @computeShader, System.Int32  @kernelIndex, System.Int32  @nameID, UnityEngine.GraphicsBuffer  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @nameID, @buffer};
            var ___result = RSetComputeBufferParam_ComputeShader_Int32_Int32_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeBufferParam(UnityEngine.ComputeShader  @computeShader, System.Int32  @kernelIndex, System.String  @name, UnityEngine.GraphicsBuffer  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @name, @buffer};
            var ___result = RSetComputeBufferParam_ComputeShader_Int32_String_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeConstantBufferParam(UnityEngine.ComputeShader  @computeShader, System.Int32  @nameID, UnityEngine.ComputeBuffer  @buffer, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @nameID, @buffer, @offset, @size};
            var ___result = RSetComputeConstantBufferParam_ComputeShader_Int32_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeConstantBufferParam(UnityEngine.ComputeShader  @computeShader, System.String  @name, UnityEngine.ComputeBuffer  @buffer, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @name, @buffer, @offset, @size};
            var ___result = RSetComputeConstantBufferParam_ComputeShader_String_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeConstantBufferParam(UnityEngine.ComputeShader  @computeShader, System.Int32  @nameID, UnityEngine.GraphicsBuffer  @buffer, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @nameID, @buffer, @offset, @size};
            var ___result = RSetComputeConstantBufferParam_ComputeShader_Int32_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeConstantBufferParam(UnityEngine.ComputeShader  @computeShader, System.String  @name, UnityEngine.GraphicsBuffer  @buffer, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @name, @buffer, @offset, @size};
            var ___result = RSetComputeConstantBufferParam_ComputeShader_String_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeParamsFromMaterial(UnityEngine.ComputeShader  @computeShader, System.Int32  @kernelIndex, UnityEngine.Material  @material)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @material};
            var ___result = RSetComputeParamsFromMaterial_ComputeShader_Int32_Material.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DispatchCompute(UnityEngine.ComputeShader  @computeShader, System.Int32  @kernelIndex, System.Int32  @threadGroupsX, System.Int32  @threadGroupsY, System.Int32  @threadGroupsZ)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @threadGroupsX, @threadGroupsY, @threadGroupsZ};
            var ___result = RDispatchCompute_ComputeShader_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DispatchCompute(UnityEngine.ComputeShader  @computeShader, System.Int32  @kernelIndex, UnityEngine.ComputeBuffer  @indirectBuffer, System.UInt32  @argsOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @indirectBuffer, @argsOffset};
            var ___result = RDispatchCompute_ComputeShader_Int32_ComputeBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DispatchCompute(UnityEngine.ComputeShader  @computeShader, System.Int32  @kernelIndex, UnityEngine.GraphicsBuffer  @indirectBuffer, System.UInt32  @argsOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @indirectBuffer, @argsOffset};
            var ___result = RDispatchCompute_ComputeShader_Int32_GraphicsBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BuildRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure  @accelerationStructure)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@accelerationStructure};
            var ___result = RBuildRayTracingAccelerationStructure_RayTracingAccelerationStructure.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BuildRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure  @accelerationStructure, UnityEngine.Vector3  @relativeOrigin)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@accelerationStructure, @relativeOrigin};
            var ___result = RBuildRayTracingAccelerationStructure_RayTracingAccelerationStructure_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.String  @name, UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure  @rayTracingAccelerationStructure)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @name, @rayTracingAccelerationStructure};
            var ___result = RSetRayTracingAccelerationStructure_RayTracingShader_String_RayTracingAccelerationStructure.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.Int32  @nameID, UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure  @rayTracingAccelerationStructure)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @rayTracingAccelerationStructure};
            var ___result = RSetRayTracingAccelerationStructure_RayTracingShader_Int32_RayTracingAccelerationStructure.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.String  @name, UnityEngine.ComputeBuffer  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @name, @buffer};
            var ___result = RSetRayTracingBufferParam_RayTracingShader_String_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.Int32  @nameID, UnityEngine.ComputeBuffer  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @buffer};
            var ___result = RSetRayTracingBufferParam_RayTracingShader_Int32_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingConstantBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.Int32  @nameID, UnityEngine.ComputeBuffer  @buffer, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @buffer, @offset, @size};
            var ___result = RSetRayTracingConstantBufferParam_RayTracingShader_Int32_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingConstantBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.String  @name, UnityEngine.ComputeBuffer  @buffer, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @name, @buffer, @offset, @size};
            var ___result = RSetRayTracingConstantBufferParam_RayTracingShader_String_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingConstantBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.Int32  @nameID, UnityEngine.GraphicsBuffer  @buffer, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @buffer, @offset, @size};
            var ___result = RSetRayTracingConstantBufferParam_RayTracingShader_Int32_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingConstantBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.String  @name, UnityEngine.GraphicsBuffer  @buffer, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @name, @buffer, @offset, @size};
            var ___result = RSetRayTracingConstantBufferParam_RayTracingShader_String_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingTextureParam(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.String  @name, UnityEngine.Rendering.RenderTargetIdentifier  @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @name, @rt};
            var ___result = RSetRayTracingTextureParam_RayTracingShader_String_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingTextureParam(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.Int32  @nameID, UnityEngine.Rendering.RenderTargetIdentifier  @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @rt};
            var ___result = RSetRayTracingTextureParam_RayTracingShader_Int32_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingFloatParam(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.String  @name, System.Single  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @name, @val};
            var ___result = RSetRayTracingFloatParam_RayTracingShader_String_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingFloatParam(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.Int32  @nameID, System.Single  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @val};
            var ___result = RSetRayTracingFloatParam_RayTracingShader_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingFloatParams(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.String  @name, System.Single[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @name, @values};
            var ___result = RSetRayTracingFloatParams_RayTracingShader_String_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingFloatParams(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.Int32  @nameID, System.Single[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @values};
            var ___result = RSetRayTracingFloatParams_RayTracingShader_Int32_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingIntParam(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.String  @name, System.Int32  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @name, @val};
            var ___result = RSetRayTracingIntParam_RayTracingShader_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingIntParam(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.Int32  @nameID, System.Int32  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @val};
            var ___result = RSetRayTracingIntParam_RayTracingShader_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingIntParams(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.String  @name, System.Int32[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @name, @values};
            var ___result = RSetRayTracingIntParams_RayTracingShader_String_Int32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingIntParams(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.Int32  @nameID, System.Int32[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @values};
            var ___result = RSetRayTracingIntParams_RayTracingShader_Int32_Int32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingVectorParam(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.String  @name, UnityEngine.Vector4  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @name, @val};
            var ___result = RSetRayTracingVectorParam_RayTracingShader_String_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingVectorParam(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.Int32  @nameID, UnityEngine.Vector4  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @val};
            var ___result = RSetRayTracingVectorParam_RayTracingShader_Int32_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingVectorArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.String  @name, UnityEngine.Vector4[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @name, @values};
            var ___result = RSetRayTracingVectorArrayParam_RayTracingShader_String_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingVectorArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.Int32  @nameID, UnityEngine.Vector4[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @values};
            var ___result = RSetRayTracingVectorArrayParam_RayTracingShader_Int32_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingMatrixParam(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.String  @name, UnityEngine.Matrix4x4  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @name, @val};
            var ___result = RSetRayTracingMatrixParam_RayTracingShader_String_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingMatrixParam(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.Int32  @nameID, UnityEngine.Matrix4x4  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @val};
            var ___result = RSetRayTracingMatrixParam_RayTracingShader_Int32_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingMatrixArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.String  @name, UnityEngine.Matrix4x4[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @name, @values};
            var ___result = RSetRayTracingMatrixArrayParam_RayTracingShader_String_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRayTracingMatrixArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.Int32  @nameID, UnityEngine.Matrix4x4[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @values};
            var ___result = RSetRayTracingMatrixArrayParam_RayTracingShader_Int32_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DispatchRays(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.String  @rayGenName, System.UInt32  @width, System.UInt32  @height, System.UInt32  @depth, UnityEngine.Camera  @camera)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @rayGenName, @width, @height, @depth, @camera};
            var ___result = RDispatchRays_RayTracingShader_String_UInt32_UInt32_UInt32_Camera.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GenerateMips(UnityEngine.Rendering.RenderTargetIdentifier  @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt};
            var ___result = RGenerateMips_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GenerateMips(UnityEngine.RenderTexture  @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt};
            var ___result = RGenerateMips_RenderTexture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResolveAntiAliasedSurface(UnityEngine.RenderTexture  @rt, UnityEngine.RenderTexture  @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt, @target};
            var ___result = RResolveAntiAliasedSurface_RenderTexture_RenderTexture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawMesh(UnityEngine.Mesh  @mesh, UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @submeshIndex, System.Int32  @shaderPass, UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @matrix, @material, @submeshIndex, @shaderPass, @properties};
            var ___result = RDrawMesh_Mesh_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawMesh(UnityEngine.Mesh  @mesh, UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @submeshIndex, System.Int32  @shaderPass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @matrix, @material, @submeshIndex, @shaderPass};
            var ___result = RDrawMesh_Mesh_Matrix4x4_Material_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawMesh(UnityEngine.Mesh  @mesh, UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @submeshIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @matrix, @material, @submeshIndex};
            var ___result = RDrawMesh_Mesh_Matrix4x4_Material_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawMesh(UnityEngine.Mesh  @mesh, UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @matrix, @material};
            var ___result = RDrawMesh_Mesh_Matrix4x4_Material.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawRenderer(UnityEngine.Renderer  @renderer, UnityEngine.Material  @material, System.Int32  @submeshIndex, System.Int32  @shaderPass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renderer, @material, @submeshIndex, @shaderPass};
            var ___result = RDrawRenderer_Renderer_Material_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawRenderer(UnityEngine.Renderer  @renderer, UnityEngine.Material  @material, System.Int32  @submeshIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renderer, @material, @submeshIndex};
            var ___result = RDrawRenderer_Renderer_Material_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawRenderer(UnityEngine.Renderer  @renderer, UnityEngine.Material  @material)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renderer, @material};
            var ___result = RDrawRenderer_Renderer_Material.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawRendererList(UnityEngine.Rendering.RendererList  @rendererList)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rendererList};
            var ___result = RDrawRendererList_RendererList.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProcedural(UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.MeshTopology  @topology, System.Int32  @vertexCount, System.Int32  @instanceCount, UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @material, @shaderPass, @topology, @vertexCount, @instanceCount, @properties};
            var ___result = RDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProcedural(UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.MeshTopology  @topology, System.Int32  @vertexCount, System.Int32  @instanceCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @material, @shaderPass, @topology, @vertexCount, @instanceCount};
            var ___result = RDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProcedural(UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.MeshTopology  @topology, System.Int32  @vertexCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @material, @shaderPass, @topology, @vertexCount};
            var ___result = RDrawProcedural_Matrix4x4_Material_Int32_MeshTopology_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProcedural(UnityEngine.GraphicsBuffer  @indexBuffer, UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.MeshTopology  @topology, System.Int32  @indexCount, System.Int32  @instanceCount, UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexBuffer, @matrix, @material, @shaderPass, @topology, @indexCount, @instanceCount, @properties};
            var ___result = RDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProcedural(UnityEngine.GraphicsBuffer  @indexBuffer, UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.MeshTopology  @topology, System.Int32  @indexCount, System.Int32  @instanceCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexBuffer, @matrix, @material, @shaderPass, @topology, @indexCount, @instanceCount};
            var ___result = RDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProcedural(UnityEngine.GraphicsBuffer  @indexBuffer, UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.MeshTopology  @topology, System.Int32  @indexCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexBuffer, @matrix, @material, @shaderPass, @topology, @indexCount};
            var ___result = RDrawProcedural_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProceduralIndirect(UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.MeshTopology  @topology, UnityEngine.ComputeBuffer  @bufferWithArgs, System.Int32  @argsOffset, UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @material, @shaderPass, @topology, @bufferWithArgs, @argsOffset, @properties};
            var ___result = RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProceduralIndirect(UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.MeshTopology  @topology, UnityEngine.ComputeBuffer  @bufferWithArgs, System.Int32  @argsOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @material, @shaderPass, @topology, @bufferWithArgs, @argsOffset};
            var ___result = RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProceduralIndirect(UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.MeshTopology  @topology, UnityEngine.ComputeBuffer  @bufferWithArgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @material, @shaderPass, @topology, @bufferWithArgs};
            var ___result = RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProceduralIndirect(UnityEngine.GraphicsBuffer  @indexBuffer, UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.MeshTopology  @topology, UnityEngine.ComputeBuffer  @bufferWithArgs, System.Int32  @argsOffset, UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexBuffer, @matrix, @material, @shaderPass, @topology, @bufferWithArgs, @argsOffset, @properties};
            var ___result = RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProceduralIndirect(UnityEngine.GraphicsBuffer  @indexBuffer, UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.MeshTopology  @topology, UnityEngine.ComputeBuffer  @bufferWithArgs, System.Int32  @argsOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexBuffer, @matrix, @material, @shaderPass, @topology, @bufferWithArgs, @argsOffset};
            var ___result = RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProceduralIndirect(UnityEngine.GraphicsBuffer  @indexBuffer, UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.MeshTopology  @topology, UnityEngine.ComputeBuffer  @bufferWithArgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexBuffer, @matrix, @material, @shaderPass, @topology, @bufferWithArgs};
            var ___result = RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProceduralIndirect(UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.MeshTopology  @topology, UnityEngine.GraphicsBuffer  @bufferWithArgs, System.Int32  @argsOffset, UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @material, @shaderPass, @topology, @bufferWithArgs, @argsOffset, @properties};
            var ___result = RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProceduralIndirect(UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.MeshTopology  @topology, UnityEngine.GraphicsBuffer  @bufferWithArgs, System.Int32  @argsOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @material, @shaderPass, @topology, @bufferWithArgs, @argsOffset};
            var ___result = RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProceduralIndirect(UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.MeshTopology  @topology, UnityEngine.GraphicsBuffer  @bufferWithArgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @material, @shaderPass, @topology, @bufferWithArgs};
            var ___result = RDrawProceduralIndirect_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProceduralIndirect(UnityEngine.GraphicsBuffer  @indexBuffer, UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.MeshTopology  @topology, UnityEngine.GraphicsBuffer  @bufferWithArgs, System.Int32  @argsOffset, UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexBuffer, @matrix, @material, @shaderPass, @topology, @bufferWithArgs, @argsOffset, @properties};
            var ___result = RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProceduralIndirect(UnityEngine.GraphicsBuffer  @indexBuffer, UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.MeshTopology  @topology, UnityEngine.GraphicsBuffer  @bufferWithArgs, System.Int32  @argsOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexBuffer, @matrix, @material, @shaderPass, @topology, @bufferWithArgs, @argsOffset};
            var ___result = RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawProceduralIndirect(UnityEngine.GraphicsBuffer  @indexBuffer, UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.MeshTopology  @topology, UnityEngine.GraphicsBuffer  @bufferWithArgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexBuffer, @matrix, @material, @shaderPass, @topology, @bufferWithArgs};
            var ___result = RDrawProceduralIndirect_GraphicsBuffer_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawMeshInstanced(UnityEngine.Mesh  @mesh, System.Int32  @submeshIndex, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.Matrix4x4[]  @matrices, System.Int32  @count, UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @submeshIndex, @material, @shaderPass, @matrices, @count, @properties};
            var ___result = RDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawMeshInstanced(UnityEngine.Mesh  @mesh, System.Int32  @submeshIndex, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.Matrix4x4[]  @matrices, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @submeshIndex, @material, @shaderPass, @matrices, @count};
            var ___result = RDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawMeshInstanced(UnityEngine.Mesh  @mesh, System.Int32  @submeshIndex, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.Matrix4x4[]  @matrices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @submeshIndex, @material, @shaderPass, @matrices};
            var ___result = RDrawMeshInstanced_Mesh_Int32_Material_Int32_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawMeshInstancedProcedural(UnityEngine.Mesh  @mesh, System.Int32  @submeshIndex, UnityEngine.Material  @material, System.Int32  @shaderPass, System.Int32  @count, UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @submeshIndex, @material, @shaderPass, @count, @properties};
            var ___result = RDrawMeshInstancedProcedural_Mesh_Int32_Material_Int32_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawMeshInstancedIndirect(UnityEngine.Mesh  @mesh, System.Int32  @submeshIndex, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.ComputeBuffer  @bufferWithArgs, System.Int32  @argsOffset, UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @submeshIndex, @material, @shaderPass, @bufferWithArgs, @argsOffset, @properties};
            var ___result = RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawMeshInstancedIndirect(UnityEngine.Mesh  @mesh, System.Int32  @submeshIndex, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.ComputeBuffer  @bufferWithArgs, System.Int32  @argsOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @submeshIndex, @material, @shaderPass, @bufferWithArgs, @argsOffset};
            var ___result = RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawMeshInstancedIndirect(UnityEngine.Mesh  @mesh, System.Int32  @submeshIndex, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.ComputeBuffer  @bufferWithArgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @submeshIndex, @material, @shaderPass, @bufferWithArgs};
            var ___result = RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawMeshInstancedIndirect(UnityEngine.Mesh  @mesh, System.Int32  @submeshIndex, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.GraphicsBuffer  @bufferWithArgs, System.Int32  @argsOffset, UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @submeshIndex, @material, @shaderPass, @bufferWithArgs, @argsOffset, @properties};
            var ___result = RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawMeshInstancedIndirect(UnityEngine.Mesh  @mesh, System.Int32  @submeshIndex, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.GraphicsBuffer  @bufferWithArgs, System.Int32  @argsOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @submeshIndex, @material, @shaderPass, @bufferWithArgs, @argsOffset};
            var ___result = RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawMeshInstancedIndirect(UnityEngine.Mesh  @mesh, System.Int32  @submeshIndex, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.GraphicsBuffer  @bufferWithArgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @submeshIndex, @material, @shaderPass, @bufferWithArgs};
            var ___result = RDrawMeshInstancedIndirect_Mesh_Int32_Material_Int32_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawOcclusionMesh(UnityEngine.RectInt  @normalizedCamViewport)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@normalizedCamViewport};
            var ___result = RDrawOcclusionMesh_RectInt.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRandomWriteTarget(System.Int32  @index, UnityEngine.Rendering.RenderTargetIdentifier  @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @rt};
            var ___result = RSetRandomWriteTarget_Int32_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRandomWriteTarget(System.Int32  @index, UnityEngine.ComputeBuffer  @buffer, System.Boolean  @preserveCounterValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @buffer, @preserveCounterValue};
            var ___result = RSetRandomWriteTarget_Int32_ComputeBuffer_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRandomWriteTarget(System.Int32  @index, UnityEngine.ComputeBuffer  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @buffer};
            var ___result = RSetRandomWriteTarget_Int32_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRandomWriteTarget(System.Int32  @index, UnityEngine.GraphicsBuffer  @buffer, System.Boolean  @preserveCounterValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @buffer, @preserveCounterValue};
            var ___result = RSetRandomWriteTarget_Int32_GraphicsBuffer_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRandomWriteTarget(System.Int32  @index, UnityEngine.GraphicsBuffer  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @buffer};
            var ___result = RSetRandomWriteTarget_Int32_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyCounterValue(UnityEngine.ComputeBuffer  @src, UnityEngine.ComputeBuffer  @dst, System.UInt32  @dstOffsetBytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst, @dstOffsetBytes};
            var ___result = RCopyCounterValue_ComputeBuffer_ComputeBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyCounterValue(UnityEngine.GraphicsBuffer  @src, UnityEngine.ComputeBuffer  @dst, System.UInt32  @dstOffsetBytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst, @dstOffsetBytes};
            var ___result = RCopyCounterValue_GraphicsBuffer_ComputeBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyCounterValue(UnityEngine.ComputeBuffer  @src, UnityEngine.GraphicsBuffer  @dst, System.UInt32  @dstOffsetBytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst, @dstOffsetBytes};
            var ___result = RCopyCounterValue_ComputeBuffer_GraphicsBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyCounterValue(UnityEngine.GraphicsBuffer  @src, UnityEngine.GraphicsBuffer  @dst, System.UInt32  @dstOffsetBytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst, @dstOffsetBytes};
            var ___result = RCopyCounterValue_GraphicsBuffer_GraphicsBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTexture(UnityEngine.Rendering.RenderTargetIdentifier  @src, UnityEngine.Rendering.RenderTargetIdentifier  @dst)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst};
            var ___result = RCopyTexture_RenderTargetIdentifier_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTexture(UnityEngine.Rendering.RenderTargetIdentifier  @src, System.Int32  @srcElement, UnityEngine.Rendering.RenderTargetIdentifier  @dst, System.Int32  @dstElement)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @srcElement, @dst, @dstElement};
            var ___result = RCopyTexture_RenderTargetIdentifier_Int32_RenderTargetIdentifier_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTexture(UnityEngine.Rendering.RenderTargetIdentifier  @src, System.Int32  @srcElement, System.Int32  @srcMip, UnityEngine.Rendering.RenderTargetIdentifier  @dst, System.Int32  @dstElement, System.Int32  @dstMip)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @srcElement, @srcMip, @dst, @dstElement, @dstMip};
            var ___result = RCopyTexture_RenderTargetIdentifier_Int32_Int32_RenderTargetIdentifier_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTexture(UnityEngine.Rendering.RenderTargetIdentifier  @src, System.Int32  @srcElement, System.Int32  @srcMip, System.Int32  @srcX, System.Int32  @srcY, System.Int32  @srcWidth, System.Int32  @srcHeight, UnityEngine.Rendering.RenderTargetIdentifier  @dst, System.Int32  @dstElement, System.Int32  @dstMip, System.Int32  @dstX, System.Int32  @dstY)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @srcElement, @srcMip, @srcX, @srcY, @srcWidth, @srcHeight, @dst, @dstElement, @dstMip, @dstX, @dstY};
            var ___result = RCopyTexture_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32_Int32_RenderTargetIdentifier_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blit(UnityEngine.Texture  @source, UnityEngine.Rendering.RenderTargetIdentifier  @dest)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest};
            var ___result = RBlit_Texture_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blit(UnityEngine.Texture  @source, UnityEngine.Rendering.RenderTargetIdentifier  @dest, UnityEngine.Vector2  @scale, UnityEngine.Vector2  @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest, @scale, @offset};
            var ___result = RBlit_Texture_RenderTargetIdentifier_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blit(UnityEngine.Texture  @source, UnityEngine.Rendering.RenderTargetIdentifier  @dest, UnityEngine.Material  @mat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest, @mat};
            var ___result = RBlit_Texture_RenderTargetIdentifier_Material.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blit(UnityEngine.Texture  @source, UnityEngine.Rendering.RenderTargetIdentifier  @dest, UnityEngine.Material  @mat, System.Int32  @pass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest, @mat, @pass};
            var ___result = RBlit_Texture_RenderTargetIdentifier_Material_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blit(UnityEngine.Rendering.RenderTargetIdentifier  @source, UnityEngine.Rendering.RenderTargetIdentifier  @dest)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest};
            var ___result = RBlit_RenderTargetIdentifier_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blit(UnityEngine.Rendering.RenderTargetIdentifier  @source, UnityEngine.Rendering.RenderTargetIdentifier  @dest, UnityEngine.Vector2  @scale, UnityEngine.Vector2  @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest, @scale, @offset};
            var ___result = RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blit(UnityEngine.Rendering.RenderTargetIdentifier  @source, UnityEngine.Rendering.RenderTargetIdentifier  @dest, UnityEngine.Material  @mat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest, @mat};
            var ___result = RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blit(UnityEngine.Rendering.RenderTargetIdentifier  @source, UnityEngine.Rendering.RenderTargetIdentifier  @dest, UnityEngine.Material  @mat, System.Int32  @pass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest, @mat, @pass};
            var ___result = RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blit(UnityEngine.Rendering.RenderTargetIdentifier  @source, UnityEngine.Rendering.RenderTargetIdentifier  @dest, System.Int32  @sourceDepthSlice, System.Int32  @destDepthSlice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest, @sourceDepthSlice, @destDepthSlice};
            var ___result = RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blit(UnityEngine.Rendering.RenderTargetIdentifier  @source, UnityEngine.Rendering.RenderTargetIdentifier  @dest, UnityEngine.Vector2  @scale, UnityEngine.Vector2  @offset, System.Int32  @sourceDepthSlice, System.Int32  @destDepthSlice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest, @scale, @offset, @sourceDepthSlice, @destDepthSlice};
            var ___result = RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Vector2_Vector2_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blit(UnityEngine.Rendering.RenderTargetIdentifier  @source, UnityEngine.Rendering.RenderTargetIdentifier  @dest, UnityEngine.Material  @mat, System.Int32  @pass, System.Int32  @destDepthSlice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest, @mat, @pass, @destDepthSlice};
            var ___result = RBlit_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalFloat(System.String  @name, System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetGlobalFloat_String_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalInt(System.String  @name, System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetGlobalInt_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalInteger(System.String  @name, System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetGlobalInteger_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalVector(System.String  @name, UnityEngine.Vector4  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetGlobalVector_String_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalColor(System.String  @name, UnityEngine.Color  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetGlobalColor_String_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalMatrix(System.String  @name, UnityEngine.Matrix4x4  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetGlobalMatrix_String_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalFloatArray(System.String  @propertyName, System.Collections.Generic.List<System.Single>  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName, @values};
            var ___result = RSetGlobalFloatArray_String_List_d_Single_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalFloatArray(System.Int32  @nameID, System.Collections.Generic.List<System.Single>  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetGlobalFloatArray_Int32_List_d_Single_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalFloatArray(System.String  @propertyName, System.Single[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName, @values};
            var ___result = RSetGlobalFloatArray_String_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalVectorArray(System.String  @propertyName, System.Collections.Generic.List<UnityEngine.Vector4>  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName, @values};
            var ___result = RSetGlobalVectorArray_String_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalVectorArray(System.Int32  @nameID, System.Collections.Generic.List<UnityEngine.Vector4>  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetGlobalVectorArray_Int32_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalVectorArray(System.String  @propertyName, UnityEngine.Vector4[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName, @values};
            var ___result = RSetGlobalVectorArray_String_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalMatrixArray(System.String  @propertyName, System.Collections.Generic.List<UnityEngine.Matrix4x4>  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName, @values};
            var ___result = RSetGlobalMatrixArray_String_List_d_Matrix4x4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalMatrixArray(System.Int32  @nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4>  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalMatrixArray(System.String  @propertyName, UnityEngine.Matrix4x4[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName, @values};
            var ___result = RSetGlobalMatrixArray_String_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalTexture(System.String  @name, UnityEngine.Rendering.RenderTargetIdentifier  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetGlobalTexture_String_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalTexture(System.Int32  @nameID, UnityEngine.Rendering.RenderTargetIdentifier  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetGlobalTexture_Int32_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalTexture(System.String  @name, UnityEngine.Rendering.RenderTargetIdentifier  @value, UnityEngine.Rendering.RenderTextureSubElement  @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value, @element};
            var ___result = RSetGlobalTexture_String_RenderTargetIdentifier_RenderTextureSubElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalTexture(System.Int32  @nameID, UnityEngine.Rendering.RenderTargetIdentifier  @value, UnityEngine.Rendering.RenderTextureSubElement  @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value, @element};
            var ___result = RSetGlobalTexture_Int32_RenderTargetIdentifier_RenderTextureSubElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalBuffer(System.String  @name, UnityEngine.ComputeBuffer  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetGlobalBuffer_String_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalBuffer(System.Int32  @nameID, UnityEngine.ComputeBuffer  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetGlobalBuffer_Int32_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalBuffer(System.String  @name, UnityEngine.GraphicsBuffer  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetGlobalBuffer_String_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalBuffer(System.Int32  @nameID, UnityEngine.GraphicsBuffer  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetGlobalBuffer_Int32_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer  @buffer, System.Int32  @nameID, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @nameID, @offset, @size};
            var ___result = RSetGlobalConstantBuffer_ComputeBuffer_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer  @buffer, System.String  @name, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @name, @offset, @size};
            var ___result = RSetGlobalConstantBuffer_ComputeBuffer_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer  @buffer, System.Int32  @nameID, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @nameID, @offset, @size};
            var ___result = RSetGlobalConstantBuffer_GraphicsBuffer_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer  @buffer, System.String  @name, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @name, @offset, @size};
            var ___result = RSetGlobalConstantBuffer_GraphicsBuffer_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetShadowSamplingMode(UnityEngine.Rendering.RenderTargetIdentifier  @shadowmap, UnityEngine.Rendering.ShadowSamplingMode  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shadowmap, @mode};
            var ___result = RSetShadowSamplingMode_RenderTargetIdentifier_ShadowSamplingMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSinglePassStereo(UnityEngine.Rendering.SinglePassStereoMode  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mode};
            var ___result = RSetSinglePassStereo_SinglePassStereoMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IssuePluginEvent(System.IntPtr  @callback, System.Int32  @eventID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @eventID};
            var ___result = RIssuePluginEvent_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IssuePluginEventAndData(System.IntPtr  @callback, System.Int32  @eventID, System.IntPtr  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @eventID, @data};
            var ___result = RIssuePluginEventAndData_IntPtr_Int32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IssuePluginEventAndDataWithFlags(System.IntPtr  @callback, System.Int32  @eventID, UnityEngine.Rendering.CustomMarkerCallbackFlags  @flags, System.IntPtr  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @eventID, @flags, @data};
            var ___result = RIssuePluginEventAndDataWithFlags_IntPtr_Int32_CustomMarkerCallbackFlags_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IssuePluginCustomBlit(System.IntPtr  @callback, System.UInt32  @command, UnityEngine.Rendering.RenderTargetIdentifier  @source, UnityEngine.Rendering.RenderTargetIdentifier  @dest, System.UInt32  @commandParam, System.UInt32  @commandFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @command, @source, @dest, @commandParam, @commandFlags};
            var ___result = RIssuePluginCustomBlit_IntPtr_UInt32_RenderTargetIdentifier_RenderTargetIdentifier_UInt32_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IssuePluginCustomTextureUpdate(System.IntPtr  @callback, UnityEngine.Texture  @targetTexture, System.UInt32  @userData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @targetTexture, @userData};
            var ___result = RIssuePluginCustomTextureUpdate_IntPtr_Texture_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IssuePluginCustomTextureUpdateV1(System.IntPtr  @callback, UnityEngine.Texture  @targetTexture, System.UInt32  @userData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @targetTexture, @userData};
            var ___result = RIssuePluginCustomTextureUpdateV1_IntPtr_Texture_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IssuePluginCustomTextureUpdateV2(System.IntPtr  @callback, UnityEngine.Texture  @targetTexture, System.UInt32  @userData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @targetTexture, @userData};
            var ___result = RIssuePluginCustomTextureUpdateV2_IntPtr_Texture_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessVTFeedback(UnityEngine.Rendering.RenderTargetIdentifier  @rt, System.IntPtr  @resolver, System.Int32  @slice, System.Int32  @x, System.Int32  @width, System.Int32  @y, System.Int32  @height, System.Int32  @mip)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt, @resolver, @slice, @x, @width, @y, @height, @mip};
            var ___result = RProcessVTFeedback_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyBuffer(UnityEngine.GraphicsBuffer  @source, UnityEngine.GraphicsBuffer  @dest)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest};
            var ___result = RCopyBuffer_GraphicsBuffer_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rendering.GraphicsFence CreateGPUFence(UnityEngine.Rendering.SynchronisationStage  @stage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stage};
            var ___result = RCreateGPUFence_SynchronisationStage.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.GraphicsFence)___result;
        }


        public virtual UnityEngine.Rendering.GraphicsFence CreateGPUFence()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateGPUFence.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.GraphicsFence)___result;
        }


        public virtual void WaitOnGPUFence(UnityEngine.Rendering.GraphicsFence  @fence, UnityEngine.Rendering.SynchronisationStage  @stage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fence, @stage};
            var ___result = RWaitOnGPUFence_GPUFence_SynchronisationStage.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WaitOnGPUFence(UnityEngine.Rendering.GraphicsFence  @fence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fence};
            var ___result = RWaitOnGPUFence_GPUFence.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeBufferData(UnityEngine.ComputeBuffer  @buffer, System.Array  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @data};
            var ___result = RSetComputeBufferData_ComputeBuffer_Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeBufferData<T>(UnityEngine.ComputeBuffer  @buffer, System.Collections.Generic.List<T>  @data) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@buffer, @data};
            var ___result = RSetComputeBufferData_GT_ComputeBuffer_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void SetComputeBufferData(UnityEngine.ComputeBuffer  @buffer, System.Array  @data, System.Int32  @managedBufferStartIndex, System.Int32  @graphicsBufferStartIndex, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @data, @managedBufferStartIndex, @graphicsBufferStartIndex, @count};
            var ___result = RSetComputeBufferData_ComputeBuffer_Array_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputeBufferData<T>(UnityEngine.ComputeBuffer  @buffer, System.Collections.Generic.List<T>  @data, System.Int32  @managedBufferStartIndex, System.Int32  @graphicsBufferStartIndex, System.Int32  @count) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@buffer, @data, @managedBufferStartIndex, @graphicsBufferStartIndex, @count};
            var ___result = RSetComputeBufferData_GT_ComputeBuffer_List_d_T_p__Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void SetComputeBufferCounterValue(UnityEngine.ComputeBuffer  @buffer, System.UInt32  @counterValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @counterValue};
            var ___result = RSetComputeBufferCounterValue_ComputeBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ConvertTexture_Internal_Injected(ref UnityEngine.Rendering.RenderTargetIdentifier  @src, System.Int32  @srcElement, ref UnityEngine.Rendering.RenderTargetIdentifier  @dst, System.Int32  @dstElement)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @srcElement, @dst, @dstElement};
            var ___result = RConvertTexture_Internal_Injected_Ref_RenderTargetIdentifier_Int32_Ref_RenderTargetIdentifier_Int32.Invoke(___genericsType, ___parameters);
			src = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[0];
			dst = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[2];

            
        }


        public virtual void SetComputeVectorParam_Injected(UnityEngine.ComputeShader  @computeShader, System.Int32  @nameID, ref UnityEngine.Vector4  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @nameID, @val};
            var ___result = RSetComputeVectorParam_Injected_ComputeShader_Int32_Ref_Vector4.Invoke(___genericsType, ___parameters);
			val = (UnityEngine.Vector4)___parameters[2];

            
        }


        public virtual void SetComputeMatrixParam_Injected(UnityEngine.ComputeShader  @computeShader, System.Int32  @nameID, ref UnityEngine.Matrix4x4  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @nameID, @val};
            var ___result = RSetComputeMatrixParam_Injected_ComputeShader_Int32_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			val = (UnityEngine.Matrix4x4)___parameters[2];

            
        }


        public virtual void Internal_SetComputeGraphicsBufferHandleParam_Injected(UnityEngine.ComputeShader  @computeShader, System.Int32  @kernelIndex, System.Int32  @nameID, ref UnityEngine.GraphicsBufferHandle  @bufferHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @kernelIndex, @nameID, @bufferHandle};
            var ___result = RInternal_SetComputeGraphicsBufferHandleParam_Injected_ComputeShader_Int32_Int32_Ref_GraphicsBufferHandle.Invoke(___genericsType, ___parameters);
			bufferHandle = (UnityEngine.GraphicsBufferHandle)___parameters[3];

            
        }


        public virtual void Internal_SetRayTracingVectorParam_Injected(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.Int32  @nameID, ref UnityEngine.Vector4  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @val};
            var ___result = RInternal_SetRayTracingVectorParam_Injected_RayTracingShader_Int32_Ref_Vector4.Invoke(___genericsType, ___parameters);
			val = (UnityEngine.Vector4)___parameters[2];

            
        }


        public virtual void Internal_SetRayTracingMatrixParam_Injected(UnityEngine.Experimental.Rendering.RayTracingShader  @rayTracingShader, System.Int32  @nameID, ref UnityEngine.Matrix4x4  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayTracingShader, @nameID, @val};
            var ___result = RInternal_SetRayTracingMatrixParam_Injected_RayTracingShader_Int32_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			val = (UnityEngine.Matrix4x4)___parameters[2];

            
        }


        public virtual void Internal_BuildRayTracingAccelerationStructure_Injected(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure  @accelerationStructure, ref UnityEngine.Vector3  @relativeOrigin)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@accelerationStructure, @relativeOrigin};
            var ___result = RInternal_BuildRayTracingAccelerationStructure_Injected_RayTracingAccelerationStructure_Ref_Vector3.Invoke(___genericsType, ___parameters);
			relativeOrigin = (UnityEngine.Vector3)___parameters[1];

            
        }


        public virtual void Internal_GenerateMips_Injected(ref UnityEngine.Rendering.RenderTargetIdentifier  @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt};
            var ___result = RInternal_GenerateMips_Injected_Ref_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);
			rt = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[0];

            
        }


        public virtual void Internal_DrawMesh_Injected(UnityEngine.Mesh  @mesh, ref UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @submeshIndex, System.Int32  @shaderPass, UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @matrix, @material, @submeshIndex, @shaderPass, @properties};
            var ___result = RInternal_DrawMesh_Injected_Mesh_Ref_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);
			matrix = (UnityEngine.Matrix4x4)___parameters[1];

            
        }


        public virtual void Internal_DrawRendererList_Injected(ref UnityEngine.Rendering.RendererList  @rendererList)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rendererList};
            var ___result = RInternal_DrawRendererList_Injected_Ref_RendererList.Invoke(___genericsType, ___parameters);
			rendererList = (UnityEngine.Rendering.RendererList)___parameters[0];

            
        }


        public virtual void Internal_DrawProcedural_Injected(ref UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.MeshTopology  @topology, System.Int32  @vertexCount, System.Int32  @instanceCount, UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @material, @shaderPass, @topology, @vertexCount, @instanceCount, @properties};
            var ___result = RInternal_DrawProcedural_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);
			matrix = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void Internal_DrawProceduralIndexed_Injected(UnityEngine.GraphicsBuffer  @indexBuffer, ref UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.MeshTopology  @topology, System.Int32  @indexCount, System.Int32  @instanceCount, UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexBuffer, @matrix, @material, @shaderPass, @topology, @indexCount, @instanceCount, @properties};
            var ___result = RInternal_DrawProceduralIndexed_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_Int32_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);
			matrix = (UnityEngine.Matrix4x4)___parameters[1];

            
        }


        public virtual void Internal_DrawProceduralIndirect_Injected(ref UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.MeshTopology  @topology, UnityEngine.ComputeBuffer  @bufferWithArgs, System.Int32  @argsOffset, UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @material, @shaderPass, @topology, @bufferWithArgs, @argsOffset, @properties};
            var ___result = RInternal_DrawProceduralIndirect_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);
			matrix = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void Internal_DrawProceduralIndexedIndirect_Injected(UnityEngine.GraphicsBuffer  @indexBuffer, ref UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.MeshTopology  @topology, UnityEngine.ComputeBuffer  @bufferWithArgs, System.Int32  @argsOffset, UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexBuffer, @matrix, @material, @shaderPass, @topology, @bufferWithArgs, @argsOffset, @properties};
            var ___result = RInternal_DrawProceduralIndexedIndirect_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_ComputeBuffer_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);
			matrix = (UnityEngine.Matrix4x4)___parameters[1];

            
        }


        public virtual void Internal_DrawProceduralIndirectGraphicsBuffer_Injected(ref UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.MeshTopology  @topology, UnityEngine.GraphicsBuffer  @bufferWithArgs, System.Int32  @argsOffset, UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @material, @shaderPass, @topology, @bufferWithArgs, @argsOffset, @properties};
            var ___result = RInternal_DrawProceduralIndirectGraphicsBuffer_Injected_Ref_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);
			matrix = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected(UnityEngine.GraphicsBuffer  @indexBuffer, ref UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Int32  @shaderPass, UnityEngine.MeshTopology  @topology, UnityEngine.GraphicsBuffer  @bufferWithArgs, System.Int32  @argsOffset, UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexBuffer, @matrix, @material, @shaderPass, @topology, @bufferWithArgs, @argsOffset, @properties};
            var ___result = RInternal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected_GraphicsBuffer_Ref_Matrix4x4_Material_Int32_MeshTopology_GraphicsBuffer_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);
			matrix = (UnityEngine.Matrix4x4)___parameters[1];

            
        }


        public virtual void Internal_DrawOcclusionMesh_Injected(ref UnityEngine.RectInt  @normalizedCamViewport)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@normalizedCamViewport};
            var ___result = RInternal_DrawOcclusionMesh_Injected_Ref_RectInt.Invoke(___genericsType, ___parameters);
			normalizedCamViewport = (UnityEngine.RectInt)___parameters[0];

            
        }


        public virtual void SetViewport_Injected(ref UnityEngine.Rect  @pixelRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pixelRect};
            var ___result = RSetViewport_Injected_Ref_Rect.Invoke(___genericsType, ___parameters);
			pixelRect = (UnityEngine.Rect)___parameters[0];

            
        }


        public virtual void EnableScissorRect_Injected(ref UnityEngine.Rect  @scissor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scissor};
            var ___result = REnableScissorRect_Injected_Ref_Rect.Invoke(___genericsType, ___parameters);
			scissor = (UnityEngine.Rect)___parameters[0];

            
        }


        public virtual void Blit_Texture_Injected(UnityEngine.Texture  @source, ref UnityEngine.Rendering.RenderTargetIdentifier  @dest, UnityEngine.Material  @mat, System.Int32  @pass, ref UnityEngine.Vector2  @scale, ref UnityEngine.Vector2  @offset, System.Int32  @sourceDepthSlice, System.Int32  @destDepthSlice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest, @mat, @pass, @scale, @offset, @sourceDepthSlice, @destDepthSlice};
            var ___result = RBlit_Texture_Injected_Texture_Ref_RenderTargetIdentifier_Material_Int32_Ref_Vector2_Ref_Vector2_Int32_Int32.Invoke(___genericsType, ___parameters);
			dest = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[1];
			scale = (UnityEngine.Vector2)___parameters[4];
			offset = (UnityEngine.Vector2)___parameters[5];

            
        }


        public virtual void Blit_Identifier_Injected(ref UnityEngine.Rendering.RenderTargetIdentifier  @source, ref UnityEngine.Rendering.RenderTargetIdentifier  @dest, UnityEngine.Material  @mat, System.Int32  @pass, ref UnityEngine.Vector2  @scale, ref UnityEngine.Vector2  @offset, System.Int32  @sourceDepthSlice, System.Int32  @destDepthSlice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest, @mat, @pass, @scale, @offset, @sourceDepthSlice, @destDepthSlice};
            var ___result = RBlit_Identifier_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_Material_Int32_Ref_Vector2_Ref_Vector2_Int32_Int32.Invoke(___genericsType, ___parameters);
			source = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[0];
			dest = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[1];
			scale = (UnityEngine.Vector2)___parameters[4];
			offset = (UnityEngine.Vector2)___parameters[5];

            
        }


        public virtual void GetTemporaryRTWithDescriptor_Injected(System.Int32  @nameID, ref UnityEngine.RenderTextureDescriptor  @desc, UnityEngine.FilterMode  @filter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @desc, @filter};
            var ___result = RGetTemporaryRTWithDescriptor_Injected_Int32_Ref_RenderTextureDescriptor_FilterMode.Invoke(___genericsType, ___parameters);
			desc = (UnityEngine.RenderTextureDescriptor)___parameters[1];

            
        }


        public virtual void ClearRenderTarget_Injected(UnityEngine.Rendering.RTClearFlags  @clearFlags, ref UnityEngine.Color  @backgroundColor, System.Single  @depth, System.UInt32  @stencil)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clearFlags, @backgroundColor, @depth, @stencil};
            var ___result = RClearRenderTarget_Injected_RTClearFlags_Ref_Color_Single_UInt32.Invoke(___genericsType, ___parameters);
			backgroundColor = (UnityEngine.Color)___parameters[1];

            
        }


        public virtual void SetGlobalVector_Injected(System.Int32  @nameID, ref UnityEngine.Vector4  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetGlobalVector_Injected_Int32_Ref_Vector4.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector4)___parameters[1];

            
        }


        public virtual void SetGlobalColor_Injected(System.Int32  @nameID, ref UnityEngine.Color  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetGlobalColor_Injected_Int32_Ref_Color.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Color)___parameters[1];

            
        }


        public virtual void SetGlobalMatrix_Injected(System.Int32  @nameID, ref UnityEngine.Matrix4x4  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetGlobalMatrix_Injected_Int32_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Matrix4x4)___parameters[1];

            
        }


        public virtual void EnableGlobalKeyword_Injected(ref UnityEngine.Rendering.GlobalKeyword  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = REnableGlobalKeyword_Injected_Ref_GlobalKeyword.Invoke(___genericsType, ___parameters);
			keyword = (UnityEngine.Rendering.GlobalKeyword)___parameters[0];

            
        }


        public virtual void EnableMaterialKeyword_Injected(UnityEngine.Material  @material, ref UnityEngine.Rendering.LocalKeyword  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@material, @keyword};
            var ___result = REnableMaterialKeyword_Injected_Material_Ref_LocalKeyword.Invoke(___genericsType, ___parameters);
			keyword = (UnityEngine.Rendering.LocalKeyword)___parameters[1];

            
        }


        public virtual void EnableComputeKeyword_Injected(UnityEngine.ComputeShader  @computeShader, ref UnityEngine.Rendering.LocalKeyword  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @keyword};
            var ___result = REnableComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword.Invoke(___genericsType, ___parameters);
			keyword = (UnityEngine.Rendering.LocalKeyword)___parameters[1];

            
        }


        public virtual void DisableGlobalKeyword_Injected(ref UnityEngine.Rendering.GlobalKeyword  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RDisableGlobalKeyword_Injected_Ref_GlobalKeyword.Invoke(___genericsType, ___parameters);
			keyword = (UnityEngine.Rendering.GlobalKeyword)___parameters[0];

            
        }


        public virtual void DisableMaterialKeyword_Injected(UnityEngine.Material  @material, ref UnityEngine.Rendering.LocalKeyword  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@material, @keyword};
            var ___result = RDisableMaterialKeyword_Injected_Material_Ref_LocalKeyword.Invoke(___genericsType, ___parameters);
			keyword = (UnityEngine.Rendering.LocalKeyword)___parameters[1];

            
        }


        public virtual void DisableComputeKeyword_Injected(UnityEngine.ComputeShader  @computeShader, ref UnityEngine.Rendering.LocalKeyword  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @keyword};
            var ___result = RDisableComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword.Invoke(___genericsType, ___parameters);
			keyword = (UnityEngine.Rendering.LocalKeyword)___parameters[1];

            
        }


        public virtual void SetGlobalKeyword_Injected(ref UnityEngine.Rendering.GlobalKeyword  @keyword, System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword, @value};
            var ___result = RSetGlobalKeyword_Injected_Ref_GlobalKeyword_Boolean.Invoke(___genericsType, ___parameters);
			keyword = (UnityEngine.Rendering.GlobalKeyword)___parameters[0];

            
        }


        public virtual void SetMaterialKeyword_Injected(UnityEngine.Material  @material, ref UnityEngine.Rendering.LocalKeyword  @keyword, System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@material, @keyword, @value};
            var ___result = RSetMaterialKeyword_Injected_Material_Ref_LocalKeyword_Boolean.Invoke(___genericsType, ___parameters);
			keyword = (UnityEngine.Rendering.LocalKeyword)___parameters[1];

            
        }


        public virtual void SetComputeKeyword_Injected(UnityEngine.ComputeShader  @computeShader, ref UnityEngine.Rendering.LocalKeyword  @keyword, System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computeShader, @keyword, @value};
            var ___result = RSetComputeKeyword_Injected_ComputeShader_Ref_LocalKeyword_Boolean.Invoke(___genericsType, ___parameters);
			keyword = (UnityEngine.Rendering.LocalKeyword)___parameters[1];

            
        }


        public virtual void SetViewMatrix_Injected(ref UnityEngine.Matrix4x4  @view)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@view};
            var ___result = RSetViewMatrix_Injected_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			view = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void SetProjectionMatrix_Injected(ref UnityEngine.Matrix4x4  @proj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@proj};
            var ___result = RSetProjectionMatrix_Injected_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			proj = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void SetViewProjectionMatrices_Injected(ref UnityEngine.Matrix4x4  @view, ref UnityEngine.Matrix4x4  @proj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@view, @proj};
            var ___result = RSetViewProjectionMatrices_Injected_Ref_Matrix4x4_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			view = (UnityEngine.Matrix4x4)___parameters[0];
			proj = (UnityEngine.Matrix4x4)___parameters[1];

            
        }


        public virtual void IncrementUpdateCount_Injected(ref UnityEngine.Rendering.RenderTargetIdentifier  @dest)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dest};
            var ___result = RIncrementUpdateCount_Injected_Ref_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);
			dest = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[0];

            
        }


        public virtual void SetRenderTargetSingle_Internal_Injected(ref UnityEngine.Rendering.RenderTargetIdentifier  @rt, UnityEngine.Rendering.RenderBufferLoadAction  @colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction  @colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction  @depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction  @depthStoreAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt, @colorLoadAction, @colorStoreAction, @depthLoadAction, @depthStoreAction};
            var ___result = RSetRenderTargetSingle_Internal_Injected_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction.Invoke(___genericsType, ___parameters);
			rt = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[0];

            
        }


        public virtual void SetRenderTargetColorDepth_Internal_Injected(ref UnityEngine.Rendering.RenderTargetIdentifier  @color, ref UnityEngine.Rendering.RenderTargetIdentifier  @depth, UnityEngine.Rendering.RenderBufferLoadAction  @colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction  @colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction  @depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction  @depthStoreAction, UnityEngine.Rendering.RenderTargetFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color, @depth, @colorLoadAction, @colorStoreAction, @depthLoadAction, @depthStoreAction, @flags};
            var ___result = RSetRenderTargetColorDepth_Internal_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags.Invoke(___genericsType, ___parameters);
			color = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[0];
			depth = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[1];

            
        }


        public virtual void SetRenderTargetMulti_Internal_Injected(UnityEngine.Rendering.RenderTargetIdentifier[]  @colors, ref UnityEngine.Rendering.RenderTargetIdentifier  @depth, UnityEngine.Rendering.RenderBufferLoadAction[]  @colorLoadActions, UnityEngine.Rendering.RenderBufferStoreAction[]  @colorStoreActions, UnityEngine.Rendering.RenderBufferLoadAction  @depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction  @depthStoreAction, UnityEngine.Rendering.RenderTargetFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colors, @depth, @colorLoadActions, @colorStoreActions, @depthLoadAction, @depthStoreAction, @flags};
            var ___result = RSetRenderTargetMulti_Internal_Injected_RenderTargetIdentifierArray_Ref_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags.Invoke(___genericsType, ___parameters);
			depth = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[1];

            
        }


        public virtual void SetRenderTargetColorDepthSubtarget_Injected(ref UnityEngine.Rendering.RenderTargetIdentifier  @color, ref UnityEngine.Rendering.RenderTargetIdentifier  @depth, UnityEngine.Rendering.RenderBufferLoadAction  @colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction  @colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction  @depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction  @depthStoreAction, System.Int32  @mipLevel, UnityEngine.CubemapFace  @cubemapFace, System.Int32  @depthSlice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color, @depth, @colorLoadAction, @colorStoreAction, @depthLoadAction, @depthStoreAction, @mipLevel, @cubemapFace, @depthSlice};
            var ___result = RSetRenderTargetColorDepthSubtarget_Injected_Ref_RenderTargetIdentifier_Ref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32.Invoke(___genericsType, ___parameters);
			color = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[0];
			depth = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[1];

            
        }


        public virtual void SetRenderTargetMultiSubtarget_Injected(UnityEngine.Rendering.RenderTargetIdentifier[]  @colors, ref UnityEngine.Rendering.RenderTargetIdentifier  @depth, UnityEngine.Rendering.RenderBufferLoadAction[]  @colorLoadActions, UnityEngine.Rendering.RenderBufferStoreAction[]  @colorStoreActions, UnityEngine.Rendering.RenderBufferLoadAction  @depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction  @depthStoreAction, System.Int32  @mipLevel, UnityEngine.CubemapFace  @cubemapFace, System.Int32  @depthSlice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colors, @depth, @colorLoadActions, @colorStoreActions, @depthLoadAction, @depthStoreAction, @mipLevel, @cubemapFace, @depthSlice};
            var ___result = RSetRenderTargetMultiSubtarget_Injected_RenderTargetIdentifierArray_Ref_RenderTargetIdentifier_RenderBufferLoadActionArray_RenderBufferStoreActionArray_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32.Invoke(___genericsType, ___parameters);
			depth = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[1];

            
        }


        public virtual void Internal_ProcessVTFeedback_Injected(ref UnityEngine.Rendering.RenderTargetIdentifier  @rt, System.IntPtr  @resolver, System.Int32  @slice, System.Int32  @x, System.Int32  @width, System.Int32  @y, System.Int32  @height, System.Int32  @mip)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt, @resolver, @slice, @x, @width, @y, @height, @mip};
            var ___result = RInternal_ProcessVTFeedback_Injected_Ref_RenderTargetIdentifier_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);
			rt = (UnityEngine.Rendering.RenderTargetIdentifier)___parameters[0];

            
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
