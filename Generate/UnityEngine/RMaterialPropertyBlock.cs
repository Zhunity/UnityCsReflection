using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.MaterialPropertyBlock
	/// </summary>
    public partial class RMaterialPropertyBlock : RMember //
    {

		/// <summary>
		/// System.IntPtr m_Ptr
		/// </summary>
		protected RSystem.RIntPtr r_Fm_Ptr;
		public virtual RSystem.RIntPtr RFm_Ptr
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
		/// Boolean isEmpty
		/// </summary>
		protected RSystem.RBoolean r_PisEmpty;
		public virtual RSystem.RBoolean RPisEmpty
		{
			get
			{
				if(r_PisEmpty == null)
				{
					r_PisEmpty = new(this, "isEmpty", -1);
					r_PisEmpty.SetBelong(this.instance);
				}
				return r_PisEmpty;
			}
		}

		/// <summary>
		/// Void AddFloat(System.String, Single)
		/// </summary>
		protected RMethod r_MAddFloat_String_Single;
		public virtual RMethod RMAddFloat_String_Single
		{
			get
			{
				if(r_MAddFloat_String_Single == null)
				{
					r_MAddFloat_String_Single = new(this, "AddFloat", 0, typeof(System.String), typeof(System.Single));
					r_MAddFloat_String_Single.SetBelong(this.instance);
				}
				return r_MAddFloat_String_Single;
			}
		}

		/// <summary>
		/// Void AddFloat(Int32, Single)
		/// </summary>
		protected RMethod r_MAddFloat_Int32_Single;
		public virtual RMethod RMAddFloat_Int32_Single
		{
			get
			{
				if(r_MAddFloat_Int32_Single == null)
				{
					r_MAddFloat_Int32_Single = new(this, "AddFloat", 0, typeof(System.Int32), typeof(System.Single));
					r_MAddFloat_Int32_Single.SetBelong(this.instance);
				}
				return r_MAddFloat_Int32_Single;
			}
		}

		/// <summary>
		/// Void AddVector(System.String, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_MAddVector_String_Vector4;
		public virtual RMethod RMAddVector_String_Vector4
		{
			get
			{
				if(r_MAddVector_String_Vector4 == null)
				{
					r_MAddVector_String_Vector4 = new(this, "AddVector", 0, typeof(System.String), typeof(UnityEngine.Vector4));
					r_MAddVector_String_Vector4.SetBelong(this.instance);
				}
				return r_MAddVector_String_Vector4;
			}
		}

		/// <summary>
		/// Void AddVector(Int32, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_MAddVector_Int32_Vector4;
		public virtual RMethod RMAddVector_Int32_Vector4
		{
			get
			{
				if(r_MAddVector_Int32_Vector4 == null)
				{
					r_MAddVector_Int32_Vector4 = new(this, "AddVector", 0, typeof(System.Int32), typeof(UnityEngine.Vector4));
					r_MAddVector_Int32_Vector4.SetBelong(this.instance);
				}
				return r_MAddVector_Int32_Vector4;
			}
		}

		/// <summary>
		/// Void AddColor(System.String, UnityEngine.Color)
		/// </summary>
		protected RMethod r_MAddColor_String_Color;
		public virtual RMethod RMAddColor_String_Color
		{
			get
			{
				if(r_MAddColor_String_Color == null)
				{
					r_MAddColor_String_Color = new(this, "AddColor", 0, typeof(System.String), typeof(UnityEngine.Color));
					r_MAddColor_String_Color.SetBelong(this.instance);
				}
				return r_MAddColor_String_Color;
			}
		}

		/// <summary>
		/// Void AddColor(Int32, UnityEngine.Color)
		/// </summary>
		protected RMethod r_MAddColor_Int32_Color;
		public virtual RMethod RMAddColor_Int32_Color
		{
			get
			{
				if(r_MAddColor_Int32_Color == null)
				{
					r_MAddColor_Int32_Color = new(this, "AddColor", 0, typeof(System.Int32), typeof(UnityEngine.Color));
					r_MAddColor_Int32_Color.SetBelong(this.instance);
				}
				return r_MAddColor_Int32_Color;
			}
		}

		/// <summary>
		/// Void AddMatrix(System.String, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_MAddMatrix_String_Matrix4x4;
		public virtual RMethod RMAddMatrix_String_Matrix4x4
		{
			get
			{
				if(r_MAddMatrix_String_Matrix4x4 == null)
				{
					r_MAddMatrix_String_Matrix4x4 = new(this, "AddMatrix", 0, typeof(System.String), typeof(UnityEngine.Matrix4x4));
					r_MAddMatrix_String_Matrix4x4.SetBelong(this.instance);
				}
				return r_MAddMatrix_String_Matrix4x4;
			}
		}

		/// <summary>
		/// Void AddMatrix(Int32, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_MAddMatrix_Int32_Matrix4x4;
		public virtual RMethod RMAddMatrix_Int32_Matrix4x4
		{
			get
			{
				if(r_MAddMatrix_Int32_Matrix4x4 == null)
				{
					r_MAddMatrix_Int32_Matrix4x4 = new(this, "AddMatrix", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4));
					r_MAddMatrix_Int32_Matrix4x4.SetBelong(this.instance);
				}
				return r_MAddMatrix_Int32_Matrix4x4;
			}
		}

		/// <summary>
		/// Void AddTexture(System.String, UnityEngine.Texture)
		/// </summary>
		protected RMethod r_MAddTexture_String_Texture;
		public virtual RMethod RMAddTexture_String_Texture
		{
			get
			{
				if(r_MAddTexture_String_Texture == null)
				{
					r_MAddTexture_String_Texture = new(this, "AddTexture", 0, typeof(System.String), typeof(UnityEngine.Texture));
					r_MAddTexture_String_Texture.SetBelong(this.instance);
				}
				return r_MAddTexture_String_Texture;
			}
		}

		/// <summary>
		/// Void AddTexture(Int32, UnityEngine.Texture)
		/// </summary>
		protected RMethod r_MAddTexture_Int32_Texture;
		public virtual RMethod RMAddTexture_Int32_Texture
		{
			get
			{
				if(r_MAddTexture_Int32_Texture == null)
				{
					r_MAddTexture_Int32_Texture = new(this, "AddTexture", 0, typeof(System.Int32), typeof(UnityEngine.Texture));
					r_MAddTexture_Int32_Texture.SetBelong(this.instance);
				}
				return r_MAddTexture_Int32_Texture;
			}
		}

		/// <summary>
		/// Int32 GetIntImpl(Int32)
		/// </summary>
		protected RMethod r_MGetIntImpl_Int32;
		public virtual RMethod RMGetIntImpl_Int32
		{
			get
			{
				if(r_MGetIntImpl_Int32 == null)
				{
					r_MGetIntImpl_Int32 = new(this, "GetIntImpl", 0, typeof(System.Int32));
					r_MGetIntImpl_Int32.SetBelong(this.instance);
				}
				return r_MGetIntImpl_Int32;
			}
		}

		/// <summary>
		/// Single GetFloatImpl(Int32)
		/// </summary>
		protected RMethod r_MGetFloatImpl_Int32;
		public virtual RMethod RMGetFloatImpl_Int32
		{
			get
			{
				if(r_MGetFloatImpl_Int32 == null)
				{
					r_MGetFloatImpl_Int32 = new(this, "GetFloatImpl", 0, typeof(System.Int32));
					r_MGetFloatImpl_Int32.SetBelong(this.instance);
				}
				return r_MGetFloatImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 GetVectorImpl(Int32)
		/// </summary>
		protected RMethod r_MGetVectorImpl_Int32;
		public virtual RMethod RMGetVectorImpl_Int32
		{
			get
			{
				if(r_MGetVectorImpl_Int32 == null)
				{
					r_MGetVectorImpl_Int32 = new(this, "GetVectorImpl", 0, typeof(System.Int32));
					r_MGetVectorImpl_Int32.SetBelong(this.instance);
				}
				return r_MGetVectorImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetColorImpl(Int32)
		/// </summary>
		protected RMethod r_MGetColorImpl_Int32;
		public virtual RMethod RMGetColorImpl_Int32
		{
			get
			{
				if(r_MGetColorImpl_Int32 == null)
				{
					r_MGetColorImpl_Int32 = new(this, "GetColorImpl", 0, typeof(System.Int32));
					r_MGetColorImpl_Int32.SetBelong(this.instance);
				}
				return r_MGetColorImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 GetMatrixImpl(Int32)
		/// </summary>
		protected RMethod r_MGetMatrixImpl_Int32;
		public virtual RMethod RMGetMatrixImpl_Int32
		{
			get
			{
				if(r_MGetMatrixImpl_Int32 == null)
				{
					r_MGetMatrixImpl_Int32 = new(this, "GetMatrixImpl", 0, typeof(System.Int32));
					r_MGetMatrixImpl_Int32.SetBelong(this.instance);
				}
				return r_MGetMatrixImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Texture GetTextureImpl(Int32)
		/// </summary>
		protected RMethod r_MGetTextureImpl_Int32;
		public virtual RMethod RMGetTextureImpl_Int32
		{
			get
			{
				if(r_MGetTextureImpl_Int32 == null)
				{
					r_MGetTextureImpl_Int32 = new(this, "GetTextureImpl", 0, typeof(System.Int32));
					r_MGetTextureImpl_Int32.SetBelong(this.instance);
				}
				return r_MGetTextureImpl_Int32;
			}
		}

		/// <summary>
		/// Boolean HasPropertyImpl(Int32)
		/// </summary>
		protected RMethod r_MHasPropertyImpl_Int32;
		public virtual RMethod RMHasPropertyImpl_Int32
		{
			get
			{
				if(r_MHasPropertyImpl_Int32 == null)
				{
					r_MHasPropertyImpl_Int32 = new(this, "HasPropertyImpl", 0, typeof(System.Int32));
					r_MHasPropertyImpl_Int32.SetBelong(this.instance);
				}
				return r_MHasPropertyImpl_Int32;
			}
		}

		/// <summary>
		/// Boolean HasFloatImpl(Int32)
		/// </summary>
		protected RMethod r_MHasFloatImpl_Int32;
		public virtual RMethod RMHasFloatImpl_Int32
		{
			get
			{
				if(r_MHasFloatImpl_Int32 == null)
				{
					r_MHasFloatImpl_Int32 = new(this, "HasFloatImpl", 0, typeof(System.Int32));
					r_MHasFloatImpl_Int32.SetBelong(this.instance);
				}
				return r_MHasFloatImpl_Int32;
			}
		}

		/// <summary>
		/// Boolean HasIntImpl(Int32)
		/// </summary>
		protected RMethod r_MHasIntImpl_Int32;
		public virtual RMethod RMHasIntImpl_Int32
		{
			get
			{
				if(r_MHasIntImpl_Int32 == null)
				{
					r_MHasIntImpl_Int32 = new(this, "HasIntImpl", 0, typeof(System.Int32));
					r_MHasIntImpl_Int32.SetBelong(this.instance);
				}
				return r_MHasIntImpl_Int32;
			}
		}

		/// <summary>
		/// Boolean HasTextureImpl(Int32)
		/// </summary>
		protected RMethod r_MHasTextureImpl_Int32;
		public virtual RMethod RMHasTextureImpl_Int32
		{
			get
			{
				if(r_MHasTextureImpl_Int32 == null)
				{
					r_MHasTextureImpl_Int32 = new(this, "HasTextureImpl", 0, typeof(System.Int32));
					r_MHasTextureImpl_Int32.SetBelong(this.instance);
				}
				return r_MHasTextureImpl_Int32;
			}
		}

		/// <summary>
		/// Boolean HasMatrixImpl(Int32)
		/// </summary>
		protected RMethod r_MHasMatrixImpl_Int32;
		public virtual RMethod RMHasMatrixImpl_Int32
		{
			get
			{
				if(r_MHasMatrixImpl_Int32 == null)
				{
					r_MHasMatrixImpl_Int32 = new(this, "HasMatrixImpl", 0, typeof(System.Int32));
					r_MHasMatrixImpl_Int32.SetBelong(this.instance);
				}
				return r_MHasMatrixImpl_Int32;
			}
		}

		/// <summary>
		/// Boolean HasVectorImpl(Int32)
		/// </summary>
		protected RMethod r_MHasVectorImpl_Int32;
		public virtual RMethod RMHasVectorImpl_Int32
		{
			get
			{
				if(r_MHasVectorImpl_Int32 == null)
				{
					r_MHasVectorImpl_Int32 = new(this, "HasVectorImpl", 0, typeof(System.Int32));
					r_MHasVectorImpl_Int32.SetBelong(this.instance);
				}
				return r_MHasVectorImpl_Int32;
			}
		}

		/// <summary>
		/// Boolean HasBufferImpl(Int32)
		/// </summary>
		protected RMethod r_MHasBufferImpl_Int32;
		public virtual RMethod RMHasBufferImpl_Int32
		{
			get
			{
				if(r_MHasBufferImpl_Int32 == null)
				{
					r_MHasBufferImpl_Int32 = new(this, "HasBufferImpl", 0, typeof(System.Int32));
					r_MHasBufferImpl_Int32.SetBelong(this.instance);
				}
				return r_MHasBufferImpl_Int32;
			}
		}

		/// <summary>
		/// Boolean HasConstantBufferImpl(Int32)
		/// </summary>
		protected RMethod r_MHasConstantBufferImpl_Int32;
		public virtual RMethod RMHasConstantBufferImpl_Int32
		{
			get
			{
				if(r_MHasConstantBufferImpl_Int32 == null)
				{
					r_MHasConstantBufferImpl_Int32 = new(this, "HasConstantBufferImpl", 0, typeof(System.Int32));
					r_MHasConstantBufferImpl_Int32.SetBelong(this.instance);
				}
				return r_MHasConstantBufferImpl_Int32;
			}
		}

		/// <summary>
		/// Void SetIntImpl(Int32, Int32)
		/// </summary>
		protected RMethod r_MSetIntImpl_Int32_Int32;
		public virtual RMethod RMSetIntImpl_Int32_Int32
		{
			get
			{
				if(r_MSetIntImpl_Int32_Int32 == null)
				{
					r_MSetIntImpl_Int32_Int32 = new(this, "SetIntImpl", 0, typeof(System.Int32), typeof(System.Int32));
					r_MSetIntImpl_Int32_Int32.SetBelong(this.instance);
				}
				return r_MSetIntImpl_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetFloatImpl(Int32, Single)
		/// </summary>
		protected RMethod r_MSetFloatImpl_Int32_Single;
		public virtual RMethod RMSetFloatImpl_Int32_Single
		{
			get
			{
				if(r_MSetFloatImpl_Int32_Single == null)
				{
					r_MSetFloatImpl_Int32_Single = new(this, "SetFloatImpl", 0, typeof(System.Int32), typeof(System.Single));
					r_MSetFloatImpl_Int32_Single.SetBelong(this.instance);
				}
				return r_MSetFloatImpl_Int32_Single;
			}
		}

		/// <summary>
		/// Void SetVectorImpl(Int32, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_MSetVectorImpl_Int32_Vector4;
		public virtual RMethod RMSetVectorImpl_Int32_Vector4
		{
			get
			{
				if(r_MSetVectorImpl_Int32_Vector4 == null)
				{
					r_MSetVectorImpl_Int32_Vector4 = new(this, "SetVectorImpl", 0, typeof(System.Int32), typeof(UnityEngine.Vector4));
					r_MSetVectorImpl_Int32_Vector4.SetBelong(this.instance);
				}
				return r_MSetVectorImpl_Int32_Vector4;
			}
		}

		/// <summary>
		/// Void SetColorImpl(Int32, UnityEngine.Color)
		/// </summary>
		protected RMethod r_MSetColorImpl_Int32_Color;
		public virtual RMethod RMSetColorImpl_Int32_Color
		{
			get
			{
				if(r_MSetColorImpl_Int32_Color == null)
				{
					r_MSetColorImpl_Int32_Color = new(this, "SetColorImpl", 0, typeof(System.Int32), typeof(UnityEngine.Color));
					r_MSetColorImpl_Int32_Color.SetBelong(this.instance);
				}
				return r_MSetColorImpl_Int32_Color;
			}
		}

		/// <summary>
		/// Void SetMatrixImpl(Int32, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_MSetMatrixImpl_Int32_Matrix4x4;
		public virtual RMethod RMSetMatrixImpl_Int32_Matrix4x4
		{
			get
			{
				if(r_MSetMatrixImpl_Int32_Matrix4x4 == null)
				{
					r_MSetMatrixImpl_Int32_Matrix4x4 = new(this, "SetMatrixImpl", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4));
					r_MSetMatrixImpl_Int32_Matrix4x4.SetBelong(this.instance);
				}
				return r_MSetMatrixImpl_Int32_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetTextureImpl(Int32, UnityEngine.Texture)
		/// </summary>
		protected RMethod r_MSetTextureImpl_Int32_Texture;
		public virtual RMethod RMSetTextureImpl_Int32_Texture
		{
			get
			{
				if(r_MSetTextureImpl_Int32_Texture == null)
				{
					r_MSetTextureImpl_Int32_Texture = new(this, "SetTextureImpl", 0, typeof(System.Int32), typeof(UnityEngine.Texture));
					r_MSetTextureImpl_Int32_Texture.SetBelong(this.instance);
				}
				return r_MSetTextureImpl_Int32_Texture;
			}
		}

		/// <summary>
		/// Void SetRenderTextureImpl(Int32, UnityEngine.RenderTexture, UnityEngine.Rendering.RenderTextureSubElement)
		/// </summary>
		protected RMethod r_MSetRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement;
		public virtual RMethod RMSetRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement
		{
			get
			{
				if(r_MSetRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement == null)
				{
					r_MSetRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement = new(this, "SetRenderTextureImpl", 0, typeof(System.Int32), typeof(UnityEngine.RenderTexture), typeof(UnityEngine.Rendering.RenderTextureSubElement));
					r_MSetRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement.SetBelong(this.instance);
				}
				return r_MSetRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement;
			}
		}

		/// <summary>
		/// Void SetBufferImpl(Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_MSetBufferImpl_Int32_ComputeBuffer;
		public virtual RMethod RMSetBufferImpl_Int32_ComputeBuffer
		{
			get
			{
				if(r_MSetBufferImpl_Int32_ComputeBuffer == null)
				{
					r_MSetBufferImpl_Int32_ComputeBuffer = new(this, "SetBufferImpl", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
					r_MSetBufferImpl_Int32_ComputeBuffer.SetBelong(this.instance);
				}
				return r_MSetBufferImpl_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetGraphicsBufferImpl(Int32, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_MSetGraphicsBufferImpl_Int32_GraphicsBuffer;
		public virtual RMethod RMSetGraphicsBufferImpl_Int32_GraphicsBuffer
		{
			get
			{
				if(r_MSetGraphicsBufferImpl_Int32_GraphicsBuffer == null)
				{
					r_MSetGraphicsBufferImpl_Int32_GraphicsBuffer = new(this, "SetGraphicsBufferImpl", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer));
					r_MSetGraphicsBufferImpl_Int32_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_MSetGraphicsBufferImpl_Int32_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetConstantBufferImpl(Int32, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32;
		public virtual RMethod RMSetConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_MSetConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32 == null)
				{
					r_MSetConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32 = new(this, "SetConstantBufferImpl", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
					r_MSetConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_MSetConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetConstantGraphicsBufferImpl(Int32, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32;
		public virtual RMethod RMSetConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_MSetConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32 == null)
				{
					r_MSetConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32 = new(this, "SetConstantGraphicsBufferImpl", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
					r_MSetConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_MSetConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetFloatArrayImpl(Int32, Single[], Int32)
		/// </summary>
		protected RMethod r_MSetFloatArrayImpl_Int32_SingleArray_Int32;
		public virtual RMethod RMSetFloatArrayImpl_Int32_SingleArray_Int32
		{
			get
			{
				if(r_MSetFloatArrayImpl_Int32_SingleArray_Int32 == null)
				{
					r_MSetFloatArrayImpl_Int32_SingleArray_Int32 = new(this, "SetFloatArrayImpl", 0, typeof(System.Int32), typeof(System.Single).MakeArrayType(), typeof(System.Int32));
					r_MSetFloatArrayImpl_Int32_SingleArray_Int32.SetBelong(this.instance);
				}
				return r_MSetFloatArrayImpl_Int32_SingleArray_Int32;
			}
		}

		/// <summary>
		/// Void SetVectorArrayImpl(Int32, UnityEngine.Vector4[], Int32)
		/// </summary>
		protected RMethod r_MSetVectorArrayImpl_Int32_Vector4Array_Int32;
		public virtual RMethod RMSetVectorArrayImpl_Int32_Vector4Array_Int32
		{
			get
			{
				if(r_MSetVectorArrayImpl_Int32_Vector4Array_Int32 == null)
				{
					r_MSetVectorArrayImpl_Int32_Vector4Array_Int32 = new(this, "SetVectorArrayImpl", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType(), typeof(System.Int32));
					r_MSetVectorArrayImpl_Int32_Vector4Array_Int32.SetBelong(this.instance);
				}
				return r_MSetVectorArrayImpl_Int32_Vector4Array_Int32;
			}
		}

		/// <summary>
		/// Void SetMatrixArrayImpl(Int32, UnityEngine.Matrix4x4[], Int32)
		/// </summary>
		protected RMethod r_MSetMatrixArrayImpl_Int32_Matrix4x4Array_Int32;
		public virtual RMethod RMSetMatrixArrayImpl_Int32_Matrix4x4Array_Int32
		{
			get
			{
				if(r_MSetMatrixArrayImpl_Int32_Matrix4x4Array_Int32 == null)
				{
					r_MSetMatrixArrayImpl_Int32_Matrix4x4Array_Int32 = new(this, "SetMatrixArrayImpl", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType(), typeof(System.Int32));
					r_MSetMatrixArrayImpl_Int32_Matrix4x4Array_Int32.SetBelong(this.instance);
				}
				return r_MSetMatrixArrayImpl_Int32_Matrix4x4Array_Int32;
			}
		}

		/// <summary>
		/// Single[] GetFloatArrayImpl(Int32)
		/// </summary>
		protected RMethod r_MGetFloatArrayImpl_Int32;
		public virtual RMethod RMGetFloatArrayImpl_Int32
		{
			get
			{
				if(r_MGetFloatArrayImpl_Int32 == null)
				{
					r_MGetFloatArrayImpl_Int32 = new(this, "GetFloatArrayImpl", 0, typeof(System.Int32));
					r_MGetFloatArrayImpl_Int32.SetBelong(this.instance);
				}
				return r_MGetFloatArrayImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4[] GetVectorArrayImpl(Int32)
		/// </summary>
		protected RMethod r_MGetVectorArrayImpl_Int32;
		public virtual RMethod RMGetVectorArrayImpl_Int32
		{
			get
			{
				if(r_MGetVectorArrayImpl_Int32 == null)
				{
					r_MGetVectorArrayImpl_Int32 = new(this, "GetVectorArrayImpl", 0, typeof(System.Int32));
					r_MGetVectorArrayImpl_Int32.SetBelong(this.instance);
				}
				return r_MGetVectorArrayImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4[] GetMatrixArrayImpl(Int32)
		/// </summary>
		protected RMethod r_MGetMatrixArrayImpl_Int32;
		public virtual RMethod RMGetMatrixArrayImpl_Int32
		{
			get
			{
				if(r_MGetMatrixArrayImpl_Int32 == null)
				{
					r_MGetMatrixArrayImpl_Int32 = new(this, "GetMatrixArrayImpl", 0, typeof(System.Int32));
					r_MGetMatrixArrayImpl_Int32.SetBelong(this.instance);
				}
				return r_MGetMatrixArrayImpl_Int32;
			}
		}

		/// <summary>
		/// Int32 GetFloatArrayCountImpl(Int32)
		/// </summary>
		protected RMethod r_MGetFloatArrayCountImpl_Int32;
		public virtual RMethod RMGetFloatArrayCountImpl_Int32
		{
			get
			{
				if(r_MGetFloatArrayCountImpl_Int32 == null)
				{
					r_MGetFloatArrayCountImpl_Int32 = new(this, "GetFloatArrayCountImpl", 0, typeof(System.Int32));
					r_MGetFloatArrayCountImpl_Int32.SetBelong(this.instance);
				}
				return r_MGetFloatArrayCountImpl_Int32;
			}
		}

		/// <summary>
		/// Int32 GetVectorArrayCountImpl(Int32)
		/// </summary>
		protected RMethod r_MGetVectorArrayCountImpl_Int32;
		public virtual RMethod RMGetVectorArrayCountImpl_Int32
		{
			get
			{
				if(r_MGetVectorArrayCountImpl_Int32 == null)
				{
					r_MGetVectorArrayCountImpl_Int32 = new(this, "GetVectorArrayCountImpl", 0, typeof(System.Int32));
					r_MGetVectorArrayCountImpl_Int32.SetBelong(this.instance);
				}
				return r_MGetVectorArrayCountImpl_Int32;
			}
		}

		/// <summary>
		/// Int32 GetMatrixArrayCountImpl(Int32)
		/// </summary>
		protected RMethod r_MGetMatrixArrayCountImpl_Int32;
		public virtual RMethod RMGetMatrixArrayCountImpl_Int32
		{
			get
			{
				if(r_MGetMatrixArrayCountImpl_Int32 == null)
				{
					r_MGetMatrixArrayCountImpl_Int32 = new(this, "GetMatrixArrayCountImpl", 0, typeof(System.Int32));
					r_MGetMatrixArrayCountImpl_Int32.SetBelong(this.instance);
				}
				return r_MGetMatrixArrayCountImpl_Int32;
			}
		}

		/// <summary>
		/// Void ExtractFloatArrayImpl(Int32, Single[])
		/// </summary>
		protected RMethod r_MExtractFloatArrayImpl_Int32_SingleArray;
		public virtual RMethod RMExtractFloatArrayImpl_Int32_SingleArray
		{
			get
			{
				if(r_MExtractFloatArrayImpl_Int32_SingleArray == null)
				{
					r_MExtractFloatArrayImpl_Int32_SingleArray = new(this, "ExtractFloatArrayImpl", 0, typeof(System.Int32), typeof(System.Single).MakeArrayType());
					r_MExtractFloatArrayImpl_Int32_SingleArray.SetBelong(this.instance);
				}
				return r_MExtractFloatArrayImpl_Int32_SingleArray;
			}
		}

		/// <summary>
		/// Void ExtractVectorArrayImpl(Int32, UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_MExtractVectorArrayImpl_Int32_Vector4Array;
		public virtual RMethod RMExtractVectorArrayImpl_Int32_Vector4Array
		{
			get
			{
				if(r_MExtractVectorArrayImpl_Int32_Vector4Array == null)
				{
					r_MExtractVectorArrayImpl_Int32_Vector4Array = new(this, "ExtractVectorArrayImpl", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType());
					r_MExtractVectorArrayImpl_Int32_Vector4Array.SetBelong(this.instance);
				}
				return r_MExtractVectorArrayImpl_Int32_Vector4Array;
			}
		}

		/// <summary>
		/// Void ExtractMatrixArrayImpl(Int32, UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_MExtractMatrixArrayImpl_Int32_Matrix4x4Array;
		public virtual RMethod RMExtractMatrixArrayImpl_Int32_Matrix4x4Array
		{
			get
			{
				if(r_MExtractMatrixArrayImpl_Int32_Matrix4x4Array == null)
				{
					r_MExtractMatrixArrayImpl_Int32_Matrix4x4Array = new(this, "ExtractMatrixArrayImpl", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType());
					r_MExtractMatrixArrayImpl_Int32_Matrix4x4Array.SetBelong(this.instance);
				}
				return r_MExtractMatrixArrayImpl_Int32_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Void Internal_CopySHCoefficientArraysFrom(UnityEngine.MaterialPropertyBlock, UnityEngine.Rendering.SphericalHarmonicsL2[], Int32, Int32, Int32)
		/// </summary>
		protected static RMethod r_MInternal_CopySHCoefficientArraysFrom_MaterialPropertyBlock_SphericalHarmonicsL2Array_Int32_Int32_Int32;
		public static RMethod RMInternal_CopySHCoefficientArraysFrom_MaterialPropertyBlock_SphericalHarmonicsL2Array_Int32_Int32_Int32
		{
			get
			{
				if(r_MInternal_CopySHCoefficientArraysFrom_MaterialPropertyBlock_SphericalHarmonicsL2Array_Int32_Int32_Int32 == null)
				{
					r_MInternal_CopySHCoefficientArraysFrom_MaterialPropertyBlock_SphericalHarmonicsL2Array_Int32_Int32_Int32 = new(typeof(UnityEngine.MaterialPropertyBlock), "Internal_CopySHCoefficientArraysFrom", 0, typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.SphericalHarmonicsL2).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_MInternal_CopySHCoefficientArraysFrom_MaterialPropertyBlock_SphericalHarmonicsL2Array_Int32_Int32_Int32.SetBelong(null);
				}
				return r_MInternal_CopySHCoefficientArraysFrom_MaterialPropertyBlock_SphericalHarmonicsL2Array_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Internal_CopyProbeOcclusionArrayFrom(UnityEngine.MaterialPropertyBlock, UnityEngine.Vector4[], Int32, Int32, Int32)
		/// </summary>
		protected static RMethod r_MInternal_CopyProbeOcclusionArrayFrom_MaterialPropertyBlock_Vector4Array_Int32_Int32_Int32;
		public static RMethod RMInternal_CopyProbeOcclusionArrayFrom_MaterialPropertyBlock_Vector4Array_Int32_Int32_Int32
		{
			get
			{
				if(r_MInternal_CopyProbeOcclusionArrayFrom_MaterialPropertyBlock_Vector4Array_Int32_Int32_Int32 == null)
				{
					r_MInternal_CopyProbeOcclusionArrayFrom_MaterialPropertyBlock_Vector4Array_Int32_Int32_Int32 = new(typeof(UnityEngine.MaterialPropertyBlock), "Internal_CopyProbeOcclusionArrayFrom", 0, typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Vector4).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_MInternal_CopyProbeOcclusionArrayFrom_MaterialPropertyBlock_Vector4Array_Int32_Int32_Int32.SetBelong(null);
				}
				return r_MInternal_CopyProbeOcclusionArrayFrom_MaterialPropertyBlock_Vector4Array_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// IntPtr CreateImpl()
		/// </summary>
		protected static RMethod r_MCreateImpl;
		public static RMethod RMCreateImpl
		{
			get
			{
				if(r_MCreateImpl == null)
				{
					r_MCreateImpl = new(typeof(UnityEngine.MaterialPropertyBlock), "CreateImpl", 0);
					r_MCreateImpl.SetBelong(null);
				}
				return r_MCreateImpl;
			}
		}

		/// <summary>
		/// Void DestroyImpl(IntPtr)
		/// </summary>
		protected static RMethod r_MDestroyImpl_IntPtr;
		public static RMethod RMDestroyImpl_IntPtr
		{
			get
			{
				if(r_MDestroyImpl_IntPtr == null)
				{
					r_MDestroyImpl_IntPtr = new(typeof(UnityEngine.MaterialPropertyBlock), "DestroyImpl", 0, typeof(System.IntPtr));
					r_MDestroyImpl_IntPtr.SetBelong(null);
				}
				return r_MDestroyImpl_IntPtr;
			}
		}

		/// <summary>
		/// Void Clear(Boolean)
		/// </summary>
		protected RMethod r_MClear_Boolean;
		public virtual RMethod RMClear_Boolean
		{
			get
			{
				if(r_MClear_Boolean == null)
				{
					r_MClear_Boolean = new(this, "Clear", 0, typeof(System.Boolean));
					r_MClear_Boolean.SetBelong(this.instance);
				}
				return r_MClear_Boolean;
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
					r_MClear.SetBelong(this.instance);
				}
				return r_MClear;
			}
		}

		/// <summary>
		/// Void SetFloatArray(Int32, Single[], Int32)
		/// </summary>
		protected RMethod r_MSetFloatArray_Int32_SingleArray_Int32;
		public virtual RMethod RMSetFloatArray_Int32_SingleArray_Int32
		{
			get
			{
				if(r_MSetFloatArray_Int32_SingleArray_Int32 == null)
				{
					r_MSetFloatArray_Int32_SingleArray_Int32 = new(this, "SetFloatArray", 0, typeof(System.Int32), typeof(System.Single).MakeArrayType(), typeof(System.Int32));
					r_MSetFloatArray_Int32_SingleArray_Int32.SetBelong(this.instance);
				}
				return r_MSetFloatArray_Int32_SingleArray_Int32;
			}
		}

		/// <summary>
		/// Void SetVectorArray(Int32, UnityEngine.Vector4[], Int32)
		/// </summary>
		protected RMethod r_MSetVectorArray_Int32_Vector4Array_Int32;
		public virtual RMethod RMSetVectorArray_Int32_Vector4Array_Int32
		{
			get
			{
				if(r_MSetVectorArray_Int32_Vector4Array_Int32 == null)
				{
					r_MSetVectorArray_Int32_Vector4Array_Int32 = new(this, "SetVectorArray", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType(), typeof(System.Int32));
					r_MSetVectorArray_Int32_Vector4Array_Int32.SetBelong(this.instance);
				}
				return r_MSetVectorArray_Int32_Vector4Array_Int32;
			}
		}

		/// <summary>
		/// Void SetMatrixArray(Int32, UnityEngine.Matrix4x4[], Int32)
		/// </summary>
		protected RMethod r_MSetMatrixArray_Int32_Matrix4x4Array_Int32;
		public virtual RMethod RMSetMatrixArray_Int32_Matrix4x4Array_Int32
		{
			get
			{
				if(r_MSetMatrixArray_Int32_Matrix4x4Array_Int32 == null)
				{
					r_MSetMatrixArray_Int32_Matrix4x4Array_Int32 = new(this, "SetMatrixArray", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType(), typeof(System.Int32));
					r_MSetMatrixArray_Int32_Matrix4x4Array_Int32.SetBelong(this.instance);
				}
				return r_MSetMatrixArray_Int32_Matrix4x4Array_Int32;
			}
		}

		/// <summary>
		/// Void ExtractFloatArray(Int32, System.Collections.Generic.List`1[System.Single])
		/// </summary>
		protected RMethod r_MExtractFloatArray_Int32_List_d_Single_p_;
		public virtual RMethod RMExtractFloatArray_Int32_List_d_Single_p_
		{
			get
			{
				if(r_MExtractFloatArray_Int32_List_d_Single_p_ == null)
				{
					r_MExtractFloatArray_Int32_List_d_Single_p_ = new(this, "ExtractFloatArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Single)));
					r_MExtractFloatArray_Int32_List_d_Single_p_.SetBelong(this.instance);
				}
				return r_MExtractFloatArray_Int32_List_d_Single_p_;
			}
		}

		/// <summary>
		/// Void ExtractVectorArray(Int32, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_MExtractVectorArray_Int32_List_d_Vector4_p_;
		public virtual RMethod RMExtractVectorArray_Int32_List_d_Vector4_p_
		{
			get
			{
				if(r_MExtractVectorArray_Int32_List_d_Vector4_p_ == null)
				{
					r_MExtractVectorArray_Int32_List_d_Vector4_p_ = new(this, "ExtractVectorArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_MExtractVectorArray_Int32_List_d_Vector4_p_.SetBelong(this.instance);
				}
				return r_MExtractVectorArray_Int32_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void ExtractMatrixArray(Int32, System.Collections.Generic.List`1[UnityEngine.Matrix4x4])
		/// </summary>
		protected RMethod r_MExtractMatrixArray_Int32_List_d_Matrix4x4_p_;
		public virtual RMethod RMExtractMatrixArray_Int32_List_d_Matrix4x4_p_
		{
			get
			{
				if(r_MExtractMatrixArray_Int32_List_d_Matrix4x4_p_ == null)
				{
					r_MExtractMatrixArray_Int32_List_d_Matrix4x4_p_ = new(this, "ExtractMatrixArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Matrix4x4)));
					r_MExtractMatrixArray_Int32_List_d_Matrix4x4_p_.SetBelong(this.instance);
				}
				return r_MExtractMatrixArray_Int32_List_d_Matrix4x4_p_;
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
		/// Void SetInt(System.String, Int32)
		/// </summary>
		protected RMethod r_MSetInt_String_Int32;
		public virtual RMethod RMSetInt_String_Int32
		{
			get
			{
				if(r_MSetInt_String_Int32 == null)
				{
					r_MSetInt_String_Int32 = new(this, "SetInt", 0, typeof(System.String), typeof(System.Int32));
					r_MSetInt_String_Int32.SetBelong(this.instance);
				}
				return r_MSetInt_String_Int32;
			}
		}

		/// <summary>
		/// Void SetInt(Int32, Int32)
		/// </summary>
		protected RMethod r_MSetInt_Int32_Int32;
		public virtual RMethod RMSetInt_Int32_Int32
		{
			get
			{
				if(r_MSetInt_Int32_Int32 == null)
				{
					r_MSetInt_Int32_Int32 = new(this, "SetInt", 0, typeof(System.Int32), typeof(System.Int32));
					r_MSetInt_Int32_Int32.SetBelong(this.instance);
				}
				return r_MSetInt_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetFloat(System.String, Single)
		/// </summary>
		protected RMethod r_MSetFloat_String_Single;
		public virtual RMethod RMSetFloat_String_Single
		{
			get
			{
				if(r_MSetFloat_String_Single == null)
				{
					r_MSetFloat_String_Single = new(this, "SetFloat", 0, typeof(System.String), typeof(System.Single));
					r_MSetFloat_String_Single.SetBelong(this.instance);
				}
				return r_MSetFloat_String_Single;
			}
		}

		/// <summary>
		/// Void SetFloat(Int32, Single)
		/// </summary>
		protected RMethod r_MSetFloat_Int32_Single;
		public virtual RMethod RMSetFloat_Int32_Single
		{
			get
			{
				if(r_MSetFloat_Int32_Single == null)
				{
					r_MSetFloat_Int32_Single = new(this, "SetFloat", 0, typeof(System.Int32), typeof(System.Single));
					r_MSetFloat_Int32_Single.SetBelong(this.instance);
				}
				return r_MSetFloat_Int32_Single;
			}
		}

		/// <summary>
		/// Void SetInteger(System.String, Int32)
		/// </summary>
		protected RMethod r_MSetInteger_String_Int32;
		public virtual RMethod RMSetInteger_String_Int32
		{
			get
			{
				if(r_MSetInteger_String_Int32 == null)
				{
					r_MSetInteger_String_Int32 = new(this, "SetInteger", 0, typeof(System.String), typeof(System.Int32));
					r_MSetInteger_String_Int32.SetBelong(this.instance);
				}
				return r_MSetInteger_String_Int32;
			}
		}

		/// <summary>
		/// Void SetInteger(Int32, Int32)
		/// </summary>
		protected RMethod r_MSetInteger_Int32_Int32;
		public virtual RMethod RMSetInteger_Int32_Int32
		{
			get
			{
				if(r_MSetInteger_Int32_Int32 == null)
				{
					r_MSetInteger_Int32_Int32 = new(this, "SetInteger", 0, typeof(System.Int32), typeof(System.Int32));
					r_MSetInteger_Int32_Int32.SetBelong(this.instance);
				}
				return r_MSetInteger_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetVector(System.String, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_MSetVector_String_Vector4;
		public virtual RMethod RMSetVector_String_Vector4
		{
			get
			{
				if(r_MSetVector_String_Vector4 == null)
				{
					r_MSetVector_String_Vector4 = new(this, "SetVector", 0, typeof(System.String), typeof(UnityEngine.Vector4));
					r_MSetVector_String_Vector4.SetBelong(this.instance);
				}
				return r_MSetVector_String_Vector4;
			}
		}

		/// <summary>
		/// Void SetVector(Int32, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_MSetVector_Int32_Vector4;
		public virtual RMethod RMSetVector_Int32_Vector4
		{
			get
			{
				if(r_MSetVector_Int32_Vector4 == null)
				{
					r_MSetVector_Int32_Vector4 = new(this, "SetVector", 0, typeof(System.Int32), typeof(UnityEngine.Vector4));
					r_MSetVector_Int32_Vector4.SetBelong(this.instance);
				}
				return r_MSetVector_Int32_Vector4;
			}
		}

		/// <summary>
		/// Void SetColor(System.String, UnityEngine.Color)
		/// </summary>
		protected RMethod r_MSetColor_String_Color;
		public virtual RMethod RMSetColor_String_Color
		{
			get
			{
				if(r_MSetColor_String_Color == null)
				{
					r_MSetColor_String_Color = new(this, "SetColor", 0, typeof(System.String), typeof(UnityEngine.Color));
					r_MSetColor_String_Color.SetBelong(this.instance);
				}
				return r_MSetColor_String_Color;
			}
		}

		/// <summary>
		/// Void SetColor(Int32, UnityEngine.Color)
		/// </summary>
		protected RMethod r_MSetColor_Int32_Color;
		public virtual RMethod RMSetColor_Int32_Color
		{
			get
			{
				if(r_MSetColor_Int32_Color == null)
				{
					r_MSetColor_Int32_Color = new(this, "SetColor", 0, typeof(System.Int32), typeof(UnityEngine.Color));
					r_MSetColor_Int32_Color.SetBelong(this.instance);
				}
				return r_MSetColor_Int32_Color;
			}
		}

		/// <summary>
		/// Void SetMatrix(System.String, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_MSetMatrix_String_Matrix4x4;
		public virtual RMethod RMSetMatrix_String_Matrix4x4
		{
			get
			{
				if(r_MSetMatrix_String_Matrix4x4 == null)
				{
					r_MSetMatrix_String_Matrix4x4 = new(this, "SetMatrix", 0, typeof(System.String), typeof(UnityEngine.Matrix4x4));
					r_MSetMatrix_String_Matrix4x4.SetBelong(this.instance);
				}
				return r_MSetMatrix_String_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetMatrix(Int32, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_MSetMatrix_Int32_Matrix4x4;
		public virtual RMethod RMSetMatrix_Int32_Matrix4x4
		{
			get
			{
				if(r_MSetMatrix_Int32_Matrix4x4 == null)
				{
					r_MSetMatrix_Int32_Matrix4x4 = new(this, "SetMatrix", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4));
					r_MSetMatrix_Int32_Matrix4x4.SetBelong(this.instance);
				}
				return r_MSetMatrix_Int32_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetBuffer(System.String, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_MSetBuffer_String_ComputeBuffer;
		public virtual RMethod RMSetBuffer_String_ComputeBuffer
		{
			get
			{
				if(r_MSetBuffer_String_ComputeBuffer == null)
				{
					r_MSetBuffer_String_ComputeBuffer = new(this, "SetBuffer", 0, typeof(System.String), typeof(UnityEngine.ComputeBuffer));
					r_MSetBuffer_String_ComputeBuffer.SetBelong(this.instance);
				}
				return r_MSetBuffer_String_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetBuffer(Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_MSetBuffer_Int32_ComputeBuffer;
		public virtual RMethod RMSetBuffer_Int32_ComputeBuffer
		{
			get
			{
				if(r_MSetBuffer_Int32_ComputeBuffer == null)
				{
					r_MSetBuffer_Int32_ComputeBuffer = new(this, "SetBuffer", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
					r_MSetBuffer_Int32_ComputeBuffer.SetBelong(this.instance);
				}
				return r_MSetBuffer_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetBuffer(System.String, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_MSetBuffer_String_GraphicsBuffer;
		public virtual RMethod RMSetBuffer_String_GraphicsBuffer
		{
			get
			{
				if(r_MSetBuffer_String_GraphicsBuffer == null)
				{
					r_MSetBuffer_String_GraphicsBuffer = new(this, "SetBuffer", 0, typeof(System.String), typeof(UnityEngine.GraphicsBuffer));
					r_MSetBuffer_String_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_MSetBuffer_String_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetBuffer(Int32, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_MSetBuffer_Int32_GraphicsBuffer;
		public virtual RMethod RMSetBuffer_Int32_GraphicsBuffer
		{
			get
			{
				if(r_MSetBuffer_Int32_GraphicsBuffer == null)
				{
					r_MSetBuffer_Int32_GraphicsBuffer = new(this, "SetBuffer", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer));
					r_MSetBuffer_Int32_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_MSetBuffer_Int32_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetTexture(System.String, UnityEngine.Texture)
		/// </summary>
		protected RMethod r_MSetTexture_String_Texture;
		public virtual RMethod RMSetTexture_String_Texture
		{
			get
			{
				if(r_MSetTexture_String_Texture == null)
				{
					r_MSetTexture_String_Texture = new(this, "SetTexture", 0, typeof(System.String), typeof(UnityEngine.Texture));
					r_MSetTexture_String_Texture.SetBelong(this.instance);
				}
				return r_MSetTexture_String_Texture;
			}
		}

		/// <summary>
		/// Void SetTexture(Int32, UnityEngine.Texture)
		/// </summary>
		protected RMethod r_MSetTexture_Int32_Texture;
		public virtual RMethod RMSetTexture_Int32_Texture
		{
			get
			{
				if(r_MSetTexture_Int32_Texture == null)
				{
					r_MSetTexture_Int32_Texture = new(this, "SetTexture", 0, typeof(System.Int32), typeof(UnityEngine.Texture));
					r_MSetTexture_Int32_Texture.SetBelong(this.instance);
				}
				return r_MSetTexture_Int32_Texture;
			}
		}

		/// <summary>
		/// Void SetTexture(System.String, UnityEngine.RenderTexture, UnityEngine.Rendering.RenderTextureSubElement)
		/// </summary>
		protected RMethod r_MSetTexture_String_RenderTexture_RenderTextureSubElement;
		public virtual RMethod RMSetTexture_String_RenderTexture_RenderTextureSubElement
		{
			get
			{
				if(r_MSetTexture_String_RenderTexture_RenderTextureSubElement == null)
				{
					r_MSetTexture_String_RenderTexture_RenderTextureSubElement = new(this, "SetTexture", 0, typeof(System.String), typeof(UnityEngine.RenderTexture), typeof(UnityEngine.Rendering.RenderTextureSubElement));
					r_MSetTexture_String_RenderTexture_RenderTextureSubElement.SetBelong(this.instance);
				}
				return r_MSetTexture_String_RenderTexture_RenderTextureSubElement;
			}
		}

		/// <summary>
		/// Void SetTexture(Int32, UnityEngine.RenderTexture, UnityEngine.Rendering.RenderTextureSubElement)
		/// </summary>
		protected RMethod r_MSetTexture_Int32_RenderTexture_RenderTextureSubElement;
		public virtual RMethod RMSetTexture_Int32_RenderTexture_RenderTextureSubElement
		{
			get
			{
				if(r_MSetTexture_Int32_RenderTexture_RenderTextureSubElement == null)
				{
					r_MSetTexture_Int32_RenderTexture_RenderTextureSubElement = new(this, "SetTexture", 0, typeof(System.Int32), typeof(UnityEngine.RenderTexture), typeof(UnityEngine.Rendering.RenderTextureSubElement));
					r_MSetTexture_Int32_RenderTexture_RenderTextureSubElement.SetBelong(this.instance);
				}
				return r_MSetTexture_Int32_RenderTexture_RenderTextureSubElement;
			}
		}

		/// <summary>
		/// Void SetConstantBuffer(System.String, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetConstantBuffer_String_ComputeBuffer_Int32_Int32;
		public virtual RMethod RMSetConstantBuffer_String_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_MSetConstantBuffer_String_ComputeBuffer_Int32_Int32 == null)
				{
					r_MSetConstantBuffer_String_ComputeBuffer_Int32_Int32 = new(this, "SetConstantBuffer", 0, typeof(System.String), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
					r_MSetConstantBuffer_String_ComputeBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_MSetConstantBuffer_String_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetConstantBuffer(Int32, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetConstantBuffer_Int32_ComputeBuffer_Int32_Int32;
		public virtual RMethod RMSetConstantBuffer_Int32_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_MSetConstantBuffer_Int32_ComputeBuffer_Int32_Int32 == null)
				{
					r_MSetConstantBuffer_Int32_ComputeBuffer_Int32_Int32 = new(this, "SetConstantBuffer", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
					r_MSetConstantBuffer_Int32_ComputeBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_MSetConstantBuffer_Int32_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetConstantBuffer(System.String, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetConstantBuffer_String_GraphicsBuffer_Int32_Int32;
		public virtual RMethod RMSetConstantBuffer_String_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_MSetConstantBuffer_String_GraphicsBuffer_Int32_Int32 == null)
				{
					r_MSetConstantBuffer_String_GraphicsBuffer_Int32_Int32 = new(this, "SetConstantBuffer", 0, typeof(System.String), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
					r_MSetConstantBuffer_String_GraphicsBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_MSetConstantBuffer_String_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetConstantBuffer(Int32, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32;
		public virtual RMethod RMSetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_MSetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32 == null)
				{
					r_MSetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32 = new(this, "SetConstantBuffer", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
					r_MSetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_MSetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetFloatArray(System.String, System.Collections.Generic.List`1[System.Single])
		/// </summary>
		protected RMethod r_MSetFloatArray_String_List_d_Single_p_;
		public virtual RMethod RMSetFloatArray_String_List_d_Single_p_
		{
			get
			{
				if(r_MSetFloatArray_String_List_d_Single_p_ == null)
				{
					r_MSetFloatArray_String_List_d_Single_p_ = new(this, "SetFloatArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Single)));
					r_MSetFloatArray_String_List_d_Single_p_.SetBelong(this.instance);
				}
				return r_MSetFloatArray_String_List_d_Single_p_;
			}
		}

		/// <summary>
		/// Void SetFloatArray(Int32, System.Collections.Generic.List`1[System.Single])
		/// </summary>
		protected RMethod r_MSetFloatArray_Int32_List_d_Single_p_;
		public virtual RMethod RMSetFloatArray_Int32_List_d_Single_p_
		{
			get
			{
				if(r_MSetFloatArray_Int32_List_d_Single_p_ == null)
				{
					r_MSetFloatArray_Int32_List_d_Single_p_ = new(this, "SetFloatArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Single)));
					r_MSetFloatArray_Int32_List_d_Single_p_.SetBelong(this.instance);
				}
				return r_MSetFloatArray_Int32_List_d_Single_p_;
			}
		}

		/// <summary>
		/// Void SetFloatArray(System.String, Single[])
		/// </summary>
		protected RMethod r_MSetFloatArray_String_SingleArray;
		public virtual RMethod RMSetFloatArray_String_SingleArray
		{
			get
			{
				if(r_MSetFloatArray_String_SingleArray == null)
				{
					r_MSetFloatArray_String_SingleArray = new(this, "SetFloatArray", 0, typeof(System.String), typeof(System.Single).MakeArrayType());
					r_MSetFloatArray_String_SingleArray.SetBelong(this.instance);
				}
				return r_MSetFloatArray_String_SingleArray;
			}
		}

		/// <summary>
		/// Void SetFloatArray(Int32, Single[])
		/// </summary>
		protected RMethod r_MSetFloatArray_Int32_SingleArray;
		public virtual RMethod RMSetFloatArray_Int32_SingleArray
		{
			get
			{
				if(r_MSetFloatArray_Int32_SingleArray == null)
				{
					r_MSetFloatArray_Int32_SingleArray = new(this, "SetFloatArray", 0, typeof(System.Int32), typeof(System.Single).MakeArrayType());
					r_MSetFloatArray_Int32_SingleArray.SetBelong(this.instance);
				}
				return r_MSetFloatArray_Int32_SingleArray;
			}
		}

		/// <summary>
		/// Void SetVectorArray(System.String, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_MSetVectorArray_String_List_d_Vector4_p_;
		public virtual RMethod RMSetVectorArray_String_List_d_Vector4_p_
		{
			get
			{
				if(r_MSetVectorArray_String_List_d_Vector4_p_ == null)
				{
					r_MSetVectorArray_String_List_d_Vector4_p_ = new(this, "SetVectorArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_MSetVectorArray_String_List_d_Vector4_p_.SetBelong(this.instance);
				}
				return r_MSetVectorArray_String_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void SetVectorArray(Int32, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_MSetVectorArray_Int32_List_d_Vector4_p_;
		public virtual RMethod RMSetVectorArray_Int32_List_d_Vector4_p_
		{
			get
			{
				if(r_MSetVectorArray_Int32_List_d_Vector4_p_ == null)
				{
					r_MSetVectorArray_Int32_List_d_Vector4_p_ = new(this, "SetVectorArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_MSetVectorArray_Int32_List_d_Vector4_p_.SetBelong(this.instance);
				}
				return r_MSetVectorArray_Int32_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void SetVectorArray(System.String, UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_MSetVectorArray_String_Vector4Array;
		public virtual RMethod RMSetVectorArray_String_Vector4Array
		{
			get
			{
				if(r_MSetVectorArray_String_Vector4Array == null)
				{
					r_MSetVectorArray_String_Vector4Array = new(this, "SetVectorArray", 0, typeof(System.String), typeof(UnityEngine.Vector4).MakeArrayType());
					r_MSetVectorArray_String_Vector4Array.SetBelong(this.instance);
				}
				return r_MSetVectorArray_String_Vector4Array;
			}
		}

		/// <summary>
		/// Void SetVectorArray(Int32, UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_MSetVectorArray_Int32_Vector4Array;
		public virtual RMethod RMSetVectorArray_Int32_Vector4Array
		{
			get
			{
				if(r_MSetVectorArray_Int32_Vector4Array == null)
				{
					r_MSetVectorArray_Int32_Vector4Array = new(this, "SetVectorArray", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType());
					r_MSetVectorArray_Int32_Vector4Array.SetBelong(this.instance);
				}
				return r_MSetVectorArray_Int32_Vector4Array;
			}
		}

		/// <summary>
		/// Void SetMatrixArray(System.String, System.Collections.Generic.List`1[UnityEngine.Matrix4x4])
		/// </summary>
		protected RMethod r_MSetMatrixArray_String_List_d_Matrix4x4_p_;
		public virtual RMethod RMSetMatrixArray_String_List_d_Matrix4x4_p_
		{
			get
			{
				if(r_MSetMatrixArray_String_List_d_Matrix4x4_p_ == null)
				{
					r_MSetMatrixArray_String_List_d_Matrix4x4_p_ = new(this, "SetMatrixArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Matrix4x4)));
					r_MSetMatrixArray_String_List_d_Matrix4x4_p_.SetBelong(this.instance);
				}
				return r_MSetMatrixArray_String_List_d_Matrix4x4_p_;
			}
		}

		/// <summary>
		/// Void SetMatrixArray(Int32, System.Collections.Generic.List`1[UnityEngine.Matrix4x4])
		/// </summary>
		protected RMethod r_MSetMatrixArray_Int32_List_d_Matrix4x4_p_;
		public virtual RMethod RMSetMatrixArray_Int32_List_d_Matrix4x4_p_
		{
			get
			{
				if(r_MSetMatrixArray_Int32_List_d_Matrix4x4_p_ == null)
				{
					r_MSetMatrixArray_Int32_List_d_Matrix4x4_p_ = new(this, "SetMatrixArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Matrix4x4)));
					r_MSetMatrixArray_Int32_List_d_Matrix4x4_p_.SetBelong(this.instance);
				}
				return r_MSetMatrixArray_Int32_List_d_Matrix4x4_p_;
			}
		}

		/// <summary>
		/// Void SetMatrixArray(System.String, UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_MSetMatrixArray_String_Matrix4x4Array;
		public virtual RMethod RMSetMatrixArray_String_Matrix4x4Array
		{
			get
			{
				if(r_MSetMatrixArray_String_Matrix4x4Array == null)
				{
					r_MSetMatrixArray_String_Matrix4x4Array = new(this, "SetMatrixArray", 0, typeof(System.String), typeof(UnityEngine.Matrix4x4).MakeArrayType());
					r_MSetMatrixArray_String_Matrix4x4Array.SetBelong(this.instance);
				}
				return r_MSetMatrixArray_String_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Void SetMatrixArray(Int32, UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_MSetMatrixArray_Int32_Matrix4x4Array;
		public virtual RMethod RMSetMatrixArray_Int32_Matrix4x4Array
		{
			get
			{
				if(r_MSetMatrixArray_Int32_Matrix4x4Array == null)
				{
					r_MSetMatrixArray_Int32_Matrix4x4Array = new(this, "SetMatrixArray", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType());
					r_MSetMatrixArray_Int32_Matrix4x4Array.SetBelong(this.instance);
				}
				return r_MSetMatrixArray_Int32_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Boolean HasProperty(System.String)
		/// </summary>
		protected RMethod r_MHasProperty_String;
		public virtual RMethod RMHasProperty_String
		{
			get
			{
				if(r_MHasProperty_String == null)
				{
					r_MHasProperty_String = new(this, "HasProperty", 0, typeof(System.String));
					r_MHasProperty_String.SetBelong(this.instance);
				}
				return r_MHasProperty_String;
			}
		}

		/// <summary>
		/// Boolean HasProperty(Int32)
		/// </summary>
		protected RMethod r_MHasProperty_Int32;
		public virtual RMethod RMHasProperty_Int32
		{
			get
			{
				if(r_MHasProperty_Int32 == null)
				{
					r_MHasProperty_Int32 = new(this, "HasProperty", 0, typeof(System.Int32));
					r_MHasProperty_Int32.SetBelong(this.instance);
				}
				return r_MHasProperty_Int32;
			}
		}

		/// <summary>
		/// Boolean HasInt(System.String)
		/// </summary>
		protected RMethod r_MHasInt_String;
		public virtual RMethod RMHasInt_String
		{
			get
			{
				if(r_MHasInt_String == null)
				{
					r_MHasInt_String = new(this, "HasInt", 0, typeof(System.String));
					r_MHasInt_String.SetBelong(this.instance);
				}
				return r_MHasInt_String;
			}
		}

		/// <summary>
		/// Boolean HasInt(Int32)
		/// </summary>
		protected RMethod r_MHasInt_Int32;
		public virtual RMethod RMHasInt_Int32
		{
			get
			{
				if(r_MHasInt_Int32 == null)
				{
					r_MHasInt_Int32 = new(this, "HasInt", 0, typeof(System.Int32));
					r_MHasInt_Int32.SetBelong(this.instance);
				}
				return r_MHasInt_Int32;
			}
		}

		/// <summary>
		/// Boolean HasFloat(System.String)
		/// </summary>
		protected RMethod r_MHasFloat_String;
		public virtual RMethod RMHasFloat_String
		{
			get
			{
				if(r_MHasFloat_String == null)
				{
					r_MHasFloat_String = new(this, "HasFloat", 0, typeof(System.String));
					r_MHasFloat_String.SetBelong(this.instance);
				}
				return r_MHasFloat_String;
			}
		}

		/// <summary>
		/// Boolean HasFloat(Int32)
		/// </summary>
		protected RMethod r_MHasFloat_Int32;
		public virtual RMethod RMHasFloat_Int32
		{
			get
			{
				if(r_MHasFloat_Int32 == null)
				{
					r_MHasFloat_Int32 = new(this, "HasFloat", 0, typeof(System.Int32));
					r_MHasFloat_Int32.SetBelong(this.instance);
				}
				return r_MHasFloat_Int32;
			}
		}

		/// <summary>
		/// Boolean HasInteger(System.String)
		/// </summary>
		protected RMethod r_MHasInteger_String;
		public virtual RMethod RMHasInteger_String
		{
			get
			{
				if(r_MHasInteger_String == null)
				{
					r_MHasInteger_String = new(this, "HasInteger", 0, typeof(System.String));
					r_MHasInteger_String.SetBelong(this.instance);
				}
				return r_MHasInteger_String;
			}
		}

		/// <summary>
		/// Boolean HasInteger(Int32)
		/// </summary>
		protected RMethod r_MHasInteger_Int32;
		public virtual RMethod RMHasInteger_Int32
		{
			get
			{
				if(r_MHasInteger_Int32 == null)
				{
					r_MHasInteger_Int32 = new(this, "HasInteger", 0, typeof(System.Int32));
					r_MHasInteger_Int32.SetBelong(this.instance);
				}
				return r_MHasInteger_Int32;
			}
		}

		/// <summary>
		/// Boolean HasTexture(System.String)
		/// </summary>
		protected RMethod r_MHasTexture_String;
		public virtual RMethod RMHasTexture_String
		{
			get
			{
				if(r_MHasTexture_String == null)
				{
					r_MHasTexture_String = new(this, "HasTexture", 0, typeof(System.String));
					r_MHasTexture_String.SetBelong(this.instance);
				}
				return r_MHasTexture_String;
			}
		}

		/// <summary>
		/// Boolean HasTexture(Int32)
		/// </summary>
		protected RMethod r_MHasTexture_Int32;
		public virtual RMethod RMHasTexture_Int32
		{
			get
			{
				if(r_MHasTexture_Int32 == null)
				{
					r_MHasTexture_Int32 = new(this, "HasTexture", 0, typeof(System.Int32));
					r_MHasTexture_Int32.SetBelong(this.instance);
				}
				return r_MHasTexture_Int32;
			}
		}

		/// <summary>
		/// Boolean HasMatrix(System.String)
		/// </summary>
		protected RMethod r_MHasMatrix_String;
		public virtual RMethod RMHasMatrix_String
		{
			get
			{
				if(r_MHasMatrix_String == null)
				{
					r_MHasMatrix_String = new(this, "HasMatrix", 0, typeof(System.String));
					r_MHasMatrix_String.SetBelong(this.instance);
				}
				return r_MHasMatrix_String;
			}
		}

		/// <summary>
		/// Boolean HasMatrix(Int32)
		/// </summary>
		protected RMethod r_MHasMatrix_Int32;
		public virtual RMethod RMHasMatrix_Int32
		{
			get
			{
				if(r_MHasMatrix_Int32 == null)
				{
					r_MHasMatrix_Int32 = new(this, "HasMatrix", 0, typeof(System.Int32));
					r_MHasMatrix_Int32.SetBelong(this.instance);
				}
				return r_MHasMatrix_Int32;
			}
		}

		/// <summary>
		/// Boolean HasVector(System.String)
		/// </summary>
		protected RMethod r_MHasVector_String;
		public virtual RMethod RMHasVector_String
		{
			get
			{
				if(r_MHasVector_String == null)
				{
					r_MHasVector_String = new(this, "HasVector", 0, typeof(System.String));
					r_MHasVector_String.SetBelong(this.instance);
				}
				return r_MHasVector_String;
			}
		}

		/// <summary>
		/// Boolean HasVector(Int32)
		/// </summary>
		protected RMethod r_MHasVector_Int32;
		public virtual RMethod RMHasVector_Int32
		{
			get
			{
				if(r_MHasVector_Int32 == null)
				{
					r_MHasVector_Int32 = new(this, "HasVector", 0, typeof(System.Int32));
					r_MHasVector_Int32.SetBelong(this.instance);
				}
				return r_MHasVector_Int32;
			}
		}

		/// <summary>
		/// Boolean HasColor(System.String)
		/// </summary>
		protected RMethod r_MHasColor_String;
		public virtual RMethod RMHasColor_String
		{
			get
			{
				if(r_MHasColor_String == null)
				{
					r_MHasColor_String = new(this, "HasColor", 0, typeof(System.String));
					r_MHasColor_String.SetBelong(this.instance);
				}
				return r_MHasColor_String;
			}
		}

		/// <summary>
		/// Boolean HasColor(Int32)
		/// </summary>
		protected RMethod r_MHasColor_Int32;
		public virtual RMethod RMHasColor_Int32
		{
			get
			{
				if(r_MHasColor_Int32 == null)
				{
					r_MHasColor_Int32 = new(this, "HasColor", 0, typeof(System.Int32));
					r_MHasColor_Int32.SetBelong(this.instance);
				}
				return r_MHasColor_Int32;
			}
		}

		/// <summary>
		/// Boolean HasBuffer(System.String)
		/// </summary>
		protected RMethod r_MHasBuffer_String;
		public virtual RMethod RMHasBuffer_String
		{
			get
			{
				if(r_MHasBuffer_String == null)
				{
					r_MHasBuffer_String = new(this, "HasBuffer", 0, typeof(System.String));
					r_MHasBuffer_String.SetBelong(this.instance);
				}
				return r_MHasBuffer_String;
			}
		}

		/// <summary>
		/// Boolean HasBuffer(Int32)
		/// </summary>
		protected RMethod r_MHasBuffer_Int32;
		public virtual RMethod RMHasBuffer_Int32
		{
			get
			{
				if(r_MHasBuffer_Int32 == null)
				{
					r_MHasBuffer_Int32 = new(this, "HasBuffer", 0, typeof(System.Int32));
					r_MHasBuffer_Int32.SetBelong(this.instance);
				}
				return r_MHasBuffer_Int32;
			}
		}

		/// <summary>
		/// Boolean HasConstantBuffer(System.String)
		/// </summary>
		protected RMethod r_MHasConstantBuffer_String;
		public virtual RMethod RMHasConstantBuffer_String
		{
			get
			{
				if(r_MHasConstantBuffer_String == null)
				{
					r_MHasConstantBuffer_String = new(this, "HasConstantBuffer", 0, typeof(System.String));
					r_MHasConstantBuffer_String.SetBelong(this.instance);
				}
				return r_MHasConstantBuffer_String;
			}
		}

		/// <summary>
		/// Boolean HasConstantBuffer(Int32)
		/// </summary>
		protected RMethod r_MHasConstantBuffer_Int32;
		public virtual RMethod RMHasConstantBuffer_Int32
		{
			get
			{
				if(r_MHasConstantBuffer_Int32 == null)
				{
					r_MHasConstantBuffer_Int32 = new(this, "HasConstantBuffer", 0, typeof(System.Int32));
					r_MHasConstantBuffer_Int32.SetBelong(this.instance);
				}
				return r_MHasConstantBuffer_Int32;
			}
		}

		/// <summary>
		/// Single GetFloat(System.String)
		/// </summary>
		protected RMethod r_MGetFloat_String;
		public virtual RMethod RMGetFloat_String
		{
			get
			{
				if(r_MGetFloat_String == null)
				{
					r_MGetFloat_String = new(this, "GetFloat", 0, typeof(System.String));
					r_MGetFloat_String.SetBelong(this.instance);
				}
				return r_MGetFloat_String;
			}
		}

		/// <summary>
		/// Single GetFloat(Int32)
		/// </summary>
		protected RMethod r_MGetFloat_Int32;
		public virtual RMethod RMGetFloat_Int32
		{
			get
			{
				if(r_MGetFloat_Int32 == null)
				{
					r_MGetFloat_Int32 = new(this, "GetFloat", 0, typeof(System.Int32));
					r_MGetFloat_Int32.SetBelong(this.instance);
				}
				return r_MGetFloat_Int32;
			}
		}

		/// <summary>
		/// Int32 GetInt(System.String)
		/// </summary>
		protected RMethod r_MGetInt_String;
		public virtual RMethod RMGetInt_String
		{
			get
			{
				if(r_MGetInt_String == null)
				{
					r_MGetInt_String = new(this, "GetInt", 0, typeof(System.String));
					r_MGetInt_String.SetBelong(this.instance);
				}
				return r_MGetInt_String;
			}
		}

		/// <summary>
		/// Int32 GetInt(Int32)
		/// </summary>
		protected RMethod r_MGetInt_Int32;
		public virtual RMethod RMGetInt_Int32
		{
			get
			{
				if(r_MGetInt_Int32 == null)
				{
					r_MGetInt_Int32 = new(this, "GetInt", 0, typeof(System.Int32));
					r_MGetInt_Int32.SetBelong(this.instance);
				}
				return r_MGetInt_Int32;
			}
		}

		/// <summary>
		/// Int32 GetInteger(System.String)
		/// </summary>
		protected RMethod r_MGetInteger_String;
		public virtual RMethod RMGetInteger_String
		{
			get
			{
				if(r_MGetInteger_String == null)
				{
					r_MGetInteger_String = new(this, "GetInteger", 0, typeof(System.String));
					r_MGetInteger_String.SetBelong(this.instance);
				}
				return r_MGetInteger_String;
			}
		}

		/// <summary>
		/// Int32 GetInteger(Int32)
		/// </summary>
		protected RMethod r_MGetInteger_Int32;
		public virtual RMethod RMGetInteger_Int32
		{
			get
			{
				if(r_MGetInteger_Int32 == null)
				{
					r_MGetInteger_Int32 = new(this, "GetInteger", 0, typeof(System.Int32));
					r_MGetInteger_Int32.SetBelong(this.instance);
				}
				return r_MGetInteger_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 GetVector(System.String)
		/// </summary>
		protected RMethod r_MGetVector_String;
		public virtual RMethod RMGetVector_String
		{
			get
			{
				if(r_MGetVector_String == null)
				{
					r_MGetVector_String = new(this, "GetVector", 0, typeof(System.String));
					r_MGetVector_String.SetBelong(this.instance);
				}
				return r_MGetVector_String;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 GetVector(Int32)
		/// </summary>
		protected RMethod r_MGetVector_Int32;
		public virtual RMethod RMGetVector_Int32
		{
			get
			{
				if(r_MGetVector_Int32 == null)
				{
					r_MGetVector_Int32 = new(this, "GetVector", 0, typeof(System.Int32));
					r_MGetVector_Int32.SetBelong(this.instance);
				}
				return r_MGetVector_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetColor(System.String)
		/// </summary>
		protected RMethod r_MGetColor_String;
		public virtual RMethod RMGetColor_String
		{
			get
			{
				if(r_MGetColor_String == null)
				{
					r_MGetColor_String = new(this, "GetColor", 0, typeof(System.String));
					r_MGetColor_String.SetBelong(this.instance);
				}
				return r_MGetColor_String;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetColor(Int32)
		/// </summary>
		protected RMethod r_MGetColor_Int32;
		public virtual RMethod RMGetColor_Int32
		{
			get
			{
				if(r_MGetColor_Int32 == null)
				{
					r_MGetColor_Int32 = new(this, "GetColor", 0, typeof(System.Int32));
					r_MGetColor_Int32.SetBelong(this.instance);
				}
				return r_MGetColor_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 GetMatrix(System.String)
		/// </summary>
		protected RMethod r_MGetMatrix_String;
		public virtual RMethod RMGetMatrix_String
		{
			get
			{
				if(r_MGetMatrix_String == null)
				{
					r_MGetMatrix_String = new(this, "GetMatrix", 0, typeof(System.String));
					r_MGetMatrix_String.SetBelong(this.instance);
				}
				return r_MGetMatrix_String;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 GetMatrix(Int32)
		/// </summary>
		protected RMethod r_MGetMatrix_Int32;
		public virtual RMethod RMGetMatrix_Int32
		{
			get
			{
				if(r_MGetMatrix_Int32 == null)
				{
					r_MGetMatrix_Int32 = new(this, "GetMatrix", 0, typeof(System.Int32));
					r_MGetMatrix_Int32.SetBelong(this.instance);
				}
				return r_MGetMatrix_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Texture GetTexture(System.String)
		/// </summary>
		protected RMethod r_MGetTexture_String;
		public virtual RMethod RMGetTexture_String
		{
			get
			{
				if(r_MGetTexture_String == null)
				{
					r_MGetTexture_String = new(this, "GetTexture", 0, typeof(System.String));
					r_MGetTexture_String.SetBelong(this.instance);
				}
				return r_MGetTexture_String;
			}
		}

		/// <summary>
		/// UnityEngine.Texture GetTexture(Int32)
		/// </summary>
		protected RMethod r_MGetTexture_Int32;
		public virtual RMethod RMGetTexture_Int32
		{
			get
			{
				if(r_MGetTexture_Int32 == null)
				{
					r_MGetTexture_Int32 = new(this, "GetTexture", 0, typeof(System.Int32));
					r_MGetTexture_Int32.SetBelong(this.instance);
				}
				return r_MGetTexture_Int32;
			}
		}

		/// <summary>
		/// Single[] GetFloatArray(System.String)
		/// </summary>
		protected RMethod r_MGetFloatArray_String;
		public virtual RMethod RMGetFloatArray_String
		{
			get
			{
				if(r_MGetFloatArray_String == null)
				{
					r_MGetFloatArray_String = new(this, "GetFloatArray", 0, typeof(System.String));
					r_MGetFloatArray_String.SetBelong(this.instance);
				}
				return r_MGetFloatArray_String;
			}
		}

		/// <summary>
		/// Single[] GetFloatArray(Int32)
		/// </summary>
		protected RMethod r_MGetFloatArray_Int32;
		public virtual RMethod RMGetFloatArray_Int32
		{
			get
			{
				if(r_MGetFloatArray_Int32 == null)
				{
					r_MGetFloatArray_Int32 = new(this, "GetFloatArray", 0, typeof(System.Int32));
					r_MGetFloatArray_Int32.SetBelong(this.instance);
				}
				return r_MGetFloatArray_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4[] GetVectorArray(System.String)
		/// </summary>
		protected RMethod r_MGetVectorArray_String;
		public virtual RMethod RMGetVectorArray_String
		{
			get
			{
				if(r_MGetVectorArray_String == null)
				{
					r_MGetVectorArray_String = new(this, "GetVectorArray", 0, typeof(System.String));
					r_MGetVectorArray_String.SetBelong(this.instance);
				}
				return r_MGetVectorArray_String;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4[] GetVectorArray(Int32)
		/// </summary>
		protected RMethod r_MGetVectorArray_Int32;
		public virtual RMethod RMGetVectorArray_Int32
		{
			get
			{
				if(r_MGetVectorArray_Int32 == null)
				{
					r_MGetVectorArray_Int32 = new(this, "GetVectorArray", 0, typeof(System.Int32));
					r_MGetVectorArray_Int32.SetBelong(this.instance);
				}
				return r_MGetVectorArray_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4[] GetMatrixArray(System.String)
		/// </summary>
		protected RMethod r_MGetMatrixArray_String;
		public virtual RMethod RMGetMatrixArray_String
		{
			get
			{
				if(r_MGetMatrixArray_String == null)
				{
					r_MGetMatrixArray_String = new(this, "GetMatrixArray", 0, typeof(System.String));
					r_MGetMatrixArray_String.SetBelong(this.instance);
				}
				return r_MGetMatrixArray_String;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4[] GetMatrixArray(Int32)
		/// </summary>
		protected RMethod r_MGetMatrixArray_Int32;
		public virtual RMethod RMGetMatrixArray_Int32
		{
			get
			{
				if(r_MGetMatrixArray_Int32 == null)
				{
					r_MGetMatrixArray_Int32 = new(this, "GetMatrixArray", 0, typeof(System.Int32));
					r_MGetMatrixArray_Int32.SetBelong(this.instance);
				}
				return r_MGetMatrixArray_Int32;
			}
		}

		/// <summary>
		/// Void GetFloatArray(System.String, System.Collections.Generic.List`1[System.Single])
		/// </summary>
		protected RMethod r_MGetFloatArray_String_List_d_Single_p_;
		public virtual RMethod RMGetFloatArray_String_List_d_Single_p_
		{
			get
			{
				if(r_MGetFloatArray_String_List_d_Single_p_ == null)
				{
					r_MGetFloatArray_String_List_d_Single_p_ = new(this, "GetFloatArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Single)));
					r_MGetFloatArray_String_List_d_Single_p_.SetBelong(this.instance);
				}
				return r_MGetFloatArray_String_List_d_Single_p_;
			}
		}

		/// <summary>
		/// Void GetFloatArray(Int32, System.Collections.Generic.List`1[System.Single])
		/// </summary>
		protected RMethod r_MGetFloatArray_Int32_List_d_Single_p_;
		public virtual RMethod RMGetFloatArray_Int32_List_d_Single_p_
		{
			get
			{
				if(r_MGetFloatArray_Int32_List_d_Single_p_ == null)
				{
					r_MGetFloatArray_Int32_List_d_Single_p_ = new(this, "GetFloatArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Single)));
					r_MGetFloatArray_Int32_List_d_Single_p_.SetBelong(this.instance);
				}
				return r_MGetFloatArray_Int32_List_d_Single_p_;
			}
		}

		/// <summary>
		/// Void GetVectorArray(System.String, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_MGetVectorArray_String_List_d_Vector4_p_;
		public virtual RMethod RMGetVectorArray_String_List_d_Vector4_p_
		{
			get
			{
				if(r_MGetVectorArray_String_List_d_Vector4_p_ == null)
				{
					r_MGetVectorArray_String_List_d_Vector4_p_ = new(this, "GetVectorArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_MGetVectorArray_String_List_d_Vector4_p_.SetBelong(this.instance);
				}
				return r_MGetVectorArray_String_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void GetVectorArray(Int32, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_MGetVectorArray_Int32_List_d_Vector4_p_;
		public virtual RMethod RMGetVectorArray_Int32_List_d_Vector4_p_
		{
			get
			{
				if(r_MGetVectorArray_Int32_List_d_Vector4_p_ == null)
				{
					r_MGetVectorArray_Int32_List_d_Vector4_p_ = new(this, "GetVectorArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_MGetVectorArray_Int32_List_d_Vector4_p_.SetBelong(this.instance);
				}
				return r_MGetVectorArray_Int32_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void GetMatrixArray(System.String, System.Collections.Generic.List`1[UnityEngine.Matrix4x4])
		/// </summary>
		protected RMethod r_MGetMatrixArray_String_List_d_Matrix4x4_p_;
		public virtual RMethod RMGetMatrixArray_String_List_d_Matrix4x4_p_
		{
			get
			{
				if(r_MGetMatrixArray_String_List_d_Matrix4x4_p_ == null)
				{
					r_MGetMatrixArray_String_List_d_Matrix4x4_p_ = new(this, "GetMatrixArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Matrix4x4)));
					r_MGetMatrixArray_String_List_d_Matrix4x4_p_.SetBelong(this.instance);
				}
				return r_MGetMatrixArray_String_List_d_Matrix4x4_p_;
			}
		}

		/// <summary>
		/// Void GetMatrixArray(Int32, System.Collections.Generic.List`1[UnityEngine.Matrix4x4])
		/// </summary>
		protected RMethod r_MGetMatrixArray_Int32_List_d_Matrix4x4_p_;
		public virtual RMethod RMGetMatrixArray_Int32_List_d_Matrix4x4_p_
		{
			get
			{
				if(r_MGetMatrixArray_Int32_List_d_Matrix4x4_p_ == null)
				{
					r_MGetMatrixArray_Int32_List_d_Matrix4x4_p_ = new(this, "GetMatrixArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Matrix4x4)));
					r_MGetMatrixArray_Int32_List_d_Matrix4x4_p_.SetBelong(this.instance);
				}
				return r_MGetMatrixArray_Int32_List_d_Matrix4x4_p_;
			}
		}

		/// <summary>
		/// Void CopySHCoefficientArraysFrom(System.Collections.Generic.List`1[UnityEngine.Rendering.SphericalHarmonicsL2])
		/// </summary>
		protected RMethod r_MCopySHCoefficientArraysFrom_List_d_SphericalHarmonicsL2_p_;
		public virtual RMethod RMCopySHCoefficientArraysFrom_List_d_SphericalHarmonicsL2_p_
		{
			get
			{
				if(r_MCopySHCoefficientArraysFrom_List_d_SphericalHarmonicsL2_p_ == null)
				{
					r_MCopySHCoefficientArraysFrom_List_d_SphericalHarmonicsL2_p_ = new(this, "CopySHCoefficientArraysFrom", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Rendering.SphericalHarmonicsL2)));
					r_MCopySHCoefficientArraysFrom_List_d_SphericalHarmonicsL2_p_.SetBelong(this.instance);
				}
				return r_MCopySHCoefficientArraysFrom_List_d_SphericalHarmonicsL2_p_;
			}
		}

		/// <summary>
		/// Void CopySHCoefficientArraysFrom(UnityEngine.Rendering.SphericalHarmonicsL2[])
		/// </summary>
		protected RMethod r_MCopySHCoefficientArraysFrom_SphericalHarmonicsL2Array;
		public virtual RMethod RMCopySHCoefficientArraysFrom_SphericalHarmonicsL2Array
		{
			get
			{
				if(r_MCopySHCoefficientArraysFrom_SphericalHarmonicsL2Array == null)
				{
					r_MCopySHCoefficientArraysFrom_SphericalHarmonicsL2Array = new(this, "CopySHCoefficientArraysFrom", 0, typeof(UnityEngine.Rendering.SphericalHarmonicsL2).MakeArrayType());
					r_MCopySHCoefficientArraysFrom_SphericalHarmonicsL2Array.SetBelong(this.instance);
				}
				return r_MCopySHCoefficientArraysFrom_SphericalHarmonicsL2Array;
			}
		}

		/// <summary>
		/// Void CopySHCoefficientArraysFrom(System.Collections.Generic.List`1[UnityEngine.Rendering.SphericalHarmonicsL2], Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MCopySHCoefficientArraysFrom_List_d_SphericalHarmonicsL2_p__Int32_Int32_Int32;
		public virtual RMethod RMCopySHCoefficientArraysFrom_List_d_SphericalHarmonicsL2_p__Int32_Int32_Int32
		{
			get
			{
				if(r_MCopySHCoefficientArraysFrom_List_d_SphericalHarmonicsL2_p__Int32_Int32_Int32 == null)
				{
					r_MCopySHCoefficientArraysFrom_List_d_SphericalHarmonicsL2_p__Int32_Int32_Int32 = new(this, "CopySHCoefficientArraysFrom", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Rendering.SphericalHarmonicsL2)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_MCopySHCoefficientArraysFrom_List_d_SphericalHarmonicsL2_p__Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_MCopySHCoefficientArraysFrom_List_d_SphericalHarmonicsL2_p__Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void CopySHCoefficientArraysFrom(UnityEngine.Rendering.SphericalHarmonicsL2[], Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MCopySHCoefficientArraysFrom_SphericalHarmonicsL2Array_Int32_Int32_Int32;
		public virtual RMethod RMCopySHCoefficientArraysFrom_SphericalHarmonicsL2Array_Int32_Int32_Int32
		{
			get
			{
				if(r_MCopySHCoefficientArraysFrom_SphericalHarmonicsL2Array_Int32_Int32_Int32 == null)
				{
					r_MCopySHCoefficientArraysFrom_SphericalHarmonicsL2Array_Int32_Int32_Int32 = new(this, "CopySHCoefficientArraysFrom", 0, typeof(UnityEngine.Rendering.SphericalHarmonicsL2).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_MCopySHCoefficientArraysFrom_SphericalHarmonicsL2Array_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_MCopySHCoefficientArraysFrom_SphericalHarmonicsL2Array_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void CopyProbeOcclusionArrayFrom(System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_MCopyProbeOcclusionArrayFrom_List_d_Vector4_p_;
		public virtual RMethod RMCopyProbeOcclusionArrayFrom_List_d_Vector4_p_
		{
			get
			{
				if(r_MCopyProbeOcclusionArrayFrom_List_d_Vector4_p_ == null)
				{
					r_MCopyProbeOcclusionArrayFrom_List_d_Vector4_p_ = new(this, "CopyProbeOcclusionArrayFrom", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_MCopyProbeOcclusionArrayFrom_List_d_Vector4_p_.SetBelong(this.instance);
				}
				return r_MCopyProbeOcclusionArrayFrom_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void CopyProbeOcclusionArrayFrom(UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_MCopyProbeOcclusionArrayFrom_Vector4Array;
		public virtual RMethod RMCopyProbeOcclusionArrayFrom_Vector4Array
		{
			get
			{
				if(r_MCopyProbeOcclusionArrayFrom_Vector4Array == null)
				{
					r_MCopyProbeOcclusionArrayFrom_Vector4Array = new(this, "CopyProbeOcclusionArrayFrom", 0, typeof(UnityEngine.Vector4).MakeArrayType());
					r_MCopyProbeOcclusionArrayFrom_Vector4Array.SetBelong(this.instance);
				}
				return r_MCopyProbeOcclusionArrayFrom_Vector4Array;
			}
		}

		/// <summary>
		/// Void CopyProbeOcclusionArrayFrom(System.Collections.Generic.List`1[UnityEngine.Vector4], Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MCopyProbeOcclusionArrayFrom_List_d_Vector4_p__Int32_Int32_Int32;
		public virtual RMethod RMCopyProbeOcclusionArrayFrom_List_d_Vector4_p__Int32_Int32_Int32
		{
			get
			{
				if(r_MCopyProbeOcclusionArrayFrom_List_d_Vector4_p__Int32_Int32_Int32 == null)
				{
					r_MCopyProbeOcclusionArrayFrom_List_d_Vector4_p__Int32_Int32_Int32 = new(this, "CopyProbeOcclusionArrayFrom", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_MCopyProbeOcclusionArrayFrom_List_d_Vector4_p__Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_MCopyProbeOcclusionArrayFrom_List_d_Vector4_p__Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void CopyProbeOcclusionArrayFrom(UnityEngine.Vector4[], Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MCopyProbeOcclusionArrayFrom_Vector4Array_Int32_Int32_Int32;
		public virtual RMethod RMCopyProbeOcclusionArrayFrom_Vector4Array_Int32_Int32_Int32
		{
			get
			{
				if(r_MCopyProbeOcclusionArrayFrom_Vector4Array_Int32_Int32_Int32 == null)
				{
					r_MCopyProbeOcclusionArrayFrom_Vector4Array_Int32_Int32_Int32 = new(this, "CopyProbeOcclusionArrayFrom", 0, typeof(UnityEngine.Vector4).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_MCopyProbeOcclusionArrayFrom_Vector4Array_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_MCopyProbeOcclusionArrayFrom_Vector4Array_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void GetVectorImpl_Injected(Int32, UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_MGetVectorImpl_Injected_Int32_Out_Vector4;
		public virtual RMethod RMGetVectorImpl_Injected_Int32_Out_Vector4
		{
			get
			{
				if(r_MGetVectorImpl_Injected_Int32_Out_Vector4 == null)
				{
					r_MGetVectorImpl_Injected_Int32_Out_Vector4 = new(this, "GetVectorImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeByRefType());
					r_MGetVectorImpl_Injected_Int32_Out_Vector4.SetBelong(this.instance);
				}
				return r_MGetVectorImpl_Injected_Int32_Out_Vector4;
			}
		}

		/// <summary>
		/// Void GetColorImpl_Injected(Int32, UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_MGetColorImpl_Injected_Int32_Out_Color;
		public virtual RMethod RMGetColorImpl_Injected_Int32_Out_Color
		{
			get
			{
				if(r_MGetColorImpl_Injected_Int32_Out_Color == null)
				{
					r_MGetColorImpl_Injected_Int32_Out_Color = new(this, "GetColorImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Color).MakeByRefType());
					r_MGetColorImpl_Injected_Int32_Out_Color.SetBelong(this.instance);
				}
				return r_MGetColorImpl_Injected_Int32_Out_Color;
			}
		}

		/// <summary>
		/// Void GetMatrixImpl_Injected(Int32, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_MGetMatrixImpl_Injected_Int32_Out_Matrix4x4;
		public virtual RMethod RMGetMatrixImpl_Injected_Int32_Out_Matrix4x4
		{
			get
			{
				if(r_MGetMatrixImpl_Injected_Int32_Out_Matrix4x4 == null)
				{
					r_MGetMatrixImpl_Injected_Int32_Out_Matrix4x4 = new(this, "GetMatrixImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_MGetMatrixImpl_Injected_Int32_Out_Matrix4x4.SetBelong(this.instance);
				}
				return r_MGetMatrixImpl_Injected_Int32_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetVectorImpl_Injected(Int32, UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_MSetVectorImpl_Injected_Int32_Ref_Vector4;
		public virtual RMethod RMSetVectorImpl_Injected_Int32_Ref_Vector4
		{
			get
			{
				if(r_MSetVectorImpl_Injected_Int32_Ref_Vector4 == null)
				{
					r_MSetVectorImpl_Injected_Int32_Ref_Vector4 = new(this, "SetVectorImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeByRefType());
					r_MSetVectorImpl_Injected_Int32_Ref_Vector4.SetBelong(this.instance);
				}
				return r_MSetVectorImpl_Injected_Int32_Ref_Vector4;
			}
		}

		/// <summary>
		/// Void SetColorImpl_Injected(Int32, UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_MSetColorImpl_Injected_Int32_Ref_Color;
		public virtual RMethod RMSetColorImpl_Injected_Int32_Ref_Color
		{
			get
			{
				if(r_MSetColorImpl_Injected_Int32_Ref_Color == null)
				{
					r_MSetColorImpl_Injected_Int32_Ref_Color = new(this, "SetColorImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Color).MakeByRefType());
					r_MSetColorImpl_Injected_Int32_Ref_Color.SetBelong(this.instance);
				}
				return r_MSetColorImpl_Injected_Int32_Ref_Color;
			}
		}

		/// <summary>
		/// Void SetMatrixImpl_Injected(Int32, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_MSetMatrixImpl_Injected_Int32_Ref_Matrix4x4;
		public virtual RMethod RMSetMatrixImpl_Injected_Int32_Ref_Matrix4x4
		{
			get
			{
				if(r_MSetMatrixImpl_Injected_Int32_Ref_Matrix4x4 == null)
				{
					r_MSetMatrixImpl_Injected_Int32_Ref_Matrix4x4 = new(this, "SetMatrixImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_MSetMatrixImpl_Injected_Int32_Ref_Matrix4x4.SetBelong(this.instance);
				}
				return r_MSetMatrixImpl_Injected_Int32_Ref_Matrix4x4;
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


        public RMaterialPropertyBlock() : base("UnityEngine.MaterialPropertyBlock")
        {
        }

        public RMaterialPropertyBlock(System.Object instance) : base("UnityEngine.MaterialPropertyBlock")
		{
            SetInstance(instance);
		}

        public RMaterialPropertyBlock(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMaterialPropertyBlock(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void AddFloat(System.String @name, System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMAddFloat_String_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddFloat(System.Int32 @nameID, System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMAddFloat_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddVector(System.String @name, UnityEngine.Vector4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMAddVector_String_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddVector(System.Int32 @nameID, UnityEngine.Vector4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMAddVector_Int32_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddColor(System.String @name, UnityEngine.Color @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMAddColor_String_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddColor(System.Int32 @nameID, UnityEngine.Color @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMAddColor_Int32_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddMatrix(System.String @name, UnityEngine.Matrix4x4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMAddMatrix_String_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddMatrix(System.Int32 @nameID, UnityEngine.Matrix4x4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMAddMatrix_Int32_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddTexture(System.String @name, UnityEngine.Texture @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMAddTexture_String_Texture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddTexture(System.Int32 @nameID, UnityEngine.Texture @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMAddTexture_Int32_Texture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetIntImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetIntImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Single GetFloatImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetFloatImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual UnityEngine.Vector4 GetVectorImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetVectorImpl_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public virtual UnityEngine.Color GetColorImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetColorImpl_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual UnityEngine.Matrix4x4 GetMatrixImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetMatrixImpl_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4)___result;
        }


        public virtual UnityEngine.Texture GetTextureImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetTextureImpl_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture)___result;
        }


        public virtual System.Boolean HasPropertyImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasPropertyImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasFloatImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasFloatImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasIntImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasIntImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasTextureImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasTextureImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasMatrixImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasMatrixImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasVectorImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasVectorImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasBufferImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasBufferImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasConstantBufferImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasConstantBufferImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetIntImpl(System.Int32 @name, System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetIntImpl_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloatImpl(System.Int32 @name, System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetFloatImpl_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVectorImpl(System.Int32 @name, UnityEngine.Vector4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetVectorImpl_Int32_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColorImpl(System.Int32 @name, UnityEngine.Color @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetColorImpl_Int32_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrixImpl(System.Int32 @name, UnityEngine.Matrix4x4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetMatrixImpl_Int32_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTextureImpl(System.Int32 @name, UnityEngine.Texture @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetTextureImpl_Int32_Texture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTextureImpl(System.Int32 @name, UnityEngine.RenderTexture @value, UnityEngine.Rendering.RenderTextureSubElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value, @element};
            var ___result = RMSetRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBufferImpl(System.Int32 @name, UnityEngine.ComputeBuffer @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetBufferImpl_Int32_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGraphicsBufferImpl(System.Int32 @name, UnityEngine.GraphicsBuffer @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetGraphicsBufferImpl_Int32_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantBufferImpl(System.Int32 @name, UnityEngine.ComputeBuffer @value, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value, @offset, @size};
            var ___result = RMSetConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantGraphicsBufferImpl(System.Int32 @name, UnityEngine.GraphicsBuffer @value, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value, @offset, @size};
            var ___result = RMSetConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloatArrayImpl(System.Int32 @name, System.Single[] @values, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values, @count};
            var ___result = RMSetFloatArrayImpl_Int32_SingleArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVectorArrayImpl(System.Int32 @name, UnityEngine.Vector4[] @values, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values, @count};
            var ___result = RMSetVectorArrayImpl_Int32_Vector4Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrixArrayImpl(System.Int32 @name, UnityEngine.Matrix4x4[] @values, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values, @count};
            var ___result = RMSetMatrixArrayImpl_Int32_Matrix4x4Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Single[] GetFloatArrayImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetFloatArrayImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single[])___result;
        }


        public virtual UnityEngine.Vector4[] GetVectorArrayImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetVectorArrayImpl_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4[])___result;
        }


        public virtual UnityEngine.Matrix4x4[] GetMatrixArrayImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetMatrixArrayImpl_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4[])___result;
        }


        public virtual System.Int32 GetFloatArrayCountImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetFloatArrayCountImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetVectorArrayCountImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetVectorArrayCountImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetMatrixArrayCountImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetMatrixArrayCountImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void ExtractFloatArrayImpl(System.Int32 @name, System.Single[] @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RMExtractFloatArrayImpl_Int32_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExtractVectorArrayImpl(System.Int32 @name, UnityEngine.Vector4[] @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RMExtractVectorArrayImpl_Int32_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExtractMatrixArrayImpl(System.Int32 @name, UnityEngine.Matrix4x4[] @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RMExtractMatrixArrayImpl_Int32_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public static void Internal_CopySHCoefficientArraysFrom(UnityEngine.MaterialPropertyBlock @properties, UnityEngine.Rendering.SphericalHarmonicsL2[] @lightProbes, System.Int32 @sourceStart, System.Int32 @destStart, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@properties, @lightProbes, @sourceStart, @destStart, @count};
            var ___result = RMInternal_CopySHCoefficientArraysFrom_MaterialPropertyBlock_SphericalHarmonicsL2Array_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Internal_CopyProbeOcclusionArrayFrom(UnityEngine.MaterialPropertyBlock @properties, UnityEngine.Vector4[] @occlusionProbes, System.Int32 @sourceStart, System.Int32 @destStart, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@properties, @occlusionProbes, @sourceStart, @destStart, @count};
            var ___result = RMInternal_CopyProbeOcclusionArrayFrom_MaterialPropertyBlock_Vector4Array_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.IntPtr CreateImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateImpl.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static void DestroyImpl(System.IntPtr @mpb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mpb};
            var ___result = RMDestroyImpl_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear(System.Boolean @keepMemory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keepMemory};
            var ___result = RMClear_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloatArray(System.Int32 @name, System.Single[] @values, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values, @count};
            var ___result = RMSetFloatArray_Int32_SingleArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVectorArray(System.Int32 @name, UnityEngine.Vector4[] @values, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values, @count};
            var ___result = RMSetVectorArray_Int32_Vector4Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrixArray(System.Int32 @name, UnityEngine.Matrix4x4[] @values, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values, @count};
            var ___result = RMSetMatrixArray_Int32_Matrix4x4Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExtractFloatArray(System.Int32 @name, System.Collections.Generic.List<System.Single> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMExtractFloatArray_Int32_List_d_Single_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExtractVectorArray(System.Int32 @name, System.Collections.Generic.List<UnityEngine.Vector4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMExtractVectorArray_Int32_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExtractMatrixArray(System.Int32 @name, System.Collections.Generic.List<UnityEngine.Matrix4x4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMExtractMatrixArray_Int32_List_d_Matrix4x4_p_.Invoke(___genericsType, ___parameters);

            
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


        public virtual void SetInt(System.String @name, System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetInt_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInt(System.Int32 @nameID, System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetInt_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloat(System.String @name, System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetFloat_String_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloat(System.Int32 @nameID, System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetFloat_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInteger(System.String @name, System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetInteger_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInteger(System.Int32 @nameID, System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetInteger_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVector(System.String @name, UnityEngine.Vector4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetVector_String_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVector(System.Int32 @nameID, UnityEngine.Vector4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetVector_Int32_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColor(System.String @name, UnityEngine.Color @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetColor_String_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColor(System.Int32 @nameID, UnityEngine.Color @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetColor_Int32_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrix(System.String @name, UnityEngine.Matrix4x4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetMatrix_String_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrix(System.Int32 @nameID, UnityEngine.Matrix4x4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetMatrix_Int32_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBuffer(System.String @name, UnityEngine.ComputeBuffer @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetBuffer_String_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBuffer(System.Int32 @nameID, UnityEngine.ComputeBuffer @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetBuffer_Int32_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBuffer(System.String @name, UnityEngine.GraphicsBuffer @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetBuffer_String_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBuffer(System.Int32 @nameID, UnityEngine.GraphicsBuffer @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetBuffer_Int32_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTexture(System.String @name, UnityEngine.Texture @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetTexture_String_Texture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTexture(System.Int32 @nameID, UnityEngine.Texture @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetTexture_Int32_Texture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTexture(System.String @name, UnityEngine.RenderTexture @value, UnityEngine.Rendering.RenderTextureSubElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value, @element};
            var ___result = RMSetTexture_String_RenderTexture_RenderTextureSubElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTexture(System.Int32 @nameID, UnityEngine.RenderTexture @value, UnityEngine.Rendering.RenderTextureSubElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value, @element};
            var ___result = RMSetTexture_Int32_RenderTexture_RenderTextureSubElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantBuffer(System.String @name, UnityEngine.ComputeBuffer @value, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value, @offset, @size};
            var ___result = RMSetConstantBuffer_String_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantBuffer(System.Int32 @nameID, UnityEngine.ComputeBuffer @value, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value, @offset, @size};
            var ___result = RMSetConstantBuffer_Int32_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantBuffer(System.String @name, UnityEngine.GraphicsBuffer @value, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value, @offset, @size};
            var ___result = RMSetConstantBuffer_String_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantBuffer(System.Int32 @nameID, UnityEngine.GraphicsBuffer @value, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value, @offset, @size};
            var ___result = RMSetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloatArray(System.String @name, System.Collections.Generic.List<System.Single> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMSetFloatArray_String_List_d_Single_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloatArray(System.Int32 @nameID, System.Collections.Generic.List<System.Single> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetFloatArray_Int32_List_d_Single_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloatArray(System.String @name, System.Single[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMSetFloatArray_String_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloatArray(System.Int32 @nameID, System.Single[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetFloatArray_Int32_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVectorArray(System.String @name, System.Collections.Generic.List<UnityEngine.Vector4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMSetVectorArray_String_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVectorArray(System.Int32 @nameID, System.Collections.Generic.List<UnityEngine.Vector4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetVectorArray_Int32_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVectorArray(System.String @name, UnityEngine.Vector4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMSetVectorArray_String_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVectorArray(System.Int32 @nameID, UnityEngine.Vector4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetVectorArray_Int32_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrixArray(System.String @name, System.Collections.Generic.List<UnityEngine.Matrix4x4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMSetMatrixArray_String_List_d_Matrix4x4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrixArray(System.Int32 @nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetMatrixArray_Int32_List_d_Matrix4x4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrixArray(System.String @name, UnityEngine.Matrix4x4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMSetMatrixArray_String_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrixArray(System.Int32 @nameID, UnityEngine.Matrix4x4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetMatrixArray_Int32_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasProperty(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasProperty_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasProperty(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMHasProperty_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasInt(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasInt_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasInt(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMHasInt_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasFloat(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasFloat_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasFloat(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMHasFloat_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasInteger(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasInteger_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasInteger(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMHasInteger_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasTexture(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasTexture_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasTexture(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMHasTexture_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasMatrix(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasMatrix_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasMatrix(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMHasMatrix_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasVector(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasVector_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasVector(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMHasVector_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasColor(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasColor_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasColor(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMHasColor_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasBuffer(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasBuffer_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasBuffer(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMHasBuffer_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasConstantBuffer(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasConstantBuffer_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasConstantBuffer(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMHasConstantBuffer_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Single GetFloat(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetFloat_String.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single GetFloat(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMGetFloat_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Int32 GetInt(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetInt_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetInt(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMGetInt_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetInteger(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetInteger_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetInteger(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMGetInteger_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.Vector4 GetVector(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetVector_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public virtual UnityEngine.Vector4 GetVector(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMGetVector_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public virtual UnityEngine.Color GetColor(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetColor_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual UnityEngine.Color GetColor(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMGetColor_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual UnityEngine.Matrix4x4 GetMatrix(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetMatrix_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4)___result;
        }


        public virtual UnityEngine.Matrix4x4 GetMatrix(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMGetMatrix_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4)___result;
        }


        public virtual UnityEngine.Texture GetTexture(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetTexture_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture)___result;
        }


        public virtual UnityEngine.Texture GetTexture(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMGetTexture_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture)___result;
        }


        public virtual System.Single[] GetFloatArray(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetFloatArray_String.Invoke(___genericsType, ___parameters);

            return (System.Single[])___result;
        }


        public virtual System.Single[] GetFloatArray(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMGetFloatArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single[])___result;
        }


        public virtual UnityEngine.Vector4[] GetVectorArray(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetVectorArray_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4[])___result;
        }


        public virtual UnityEngine.Vector4[] GetVectorArray(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMGetVectorArray_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4[])___result;
        }


        public virtual UnityEngine.Matrix4x4[] GetMatrixArray(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetMatrixArray_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4[])___result;
        }


        public virtual UnityEngine.Matrix4x4[] GetMatrixArray(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMGetMatrixArray_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4[])___result;
        }


        public virtual void GetFloatArray(System.String @name, System.Collections.Generic.List<System.Single> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMGetFloatArray_String_List_d_Single_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetFloatArray(System.Int32 @nameID, System.Collections.Generic.List<System.Single> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMGetFloatArray_Int32_List_d_Single_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetVectorArray(System.String @name, System.Collections.Generic.List<UnityEngine.Vector4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMGetVectorArray_String_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetVectorArray(System.Int32 @nameID, System.Collections.Generic.List<UnityEngine.Vector4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMGetVectorArray_Int32_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetMatrixArray(System.String @name, System.Collections.Generic.List<UnityEngine.Matrix4x4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMGetMatrixArray_String_List_d_Matrix4x4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetMatrixArray(System.Int32 @nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMGetMatrixArray_Int32_List_d_Matrix4x4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopySHCoefficientArraysFrom(System.Collections.Generic.List<UnityEngine.Rendering.SphericalHarmonicsL2> @lightProbes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lightProbes};
            var ___result = RMCopySHCoefficientArraysFrom_List_d_SphericalHarmonicsL2_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopySHCoefficientArraysFrom(UnityEngine.Rendering.SphericalHarmonicsL2[] @lightProbes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lightProbes};
            var ___result = RMCopySHCoefficientArraysFrom_SphericalHarmonicsL2Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopySHCoefficientArraysFrom(System.Collections.Generic.List<UnityEngine.Rendering.SphericalHarmonicsL2> @lightProbes, System.Int32 @sourceStart, System.Int32 @destStart, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lightProbes, @sourceStart, @destStart, @count};
            var ___result = RMCopySHCoefficientArraysFrom_List_d_SphericalHarmonicsL2_p__Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopySHCoefficientArraysFrom(UnityEngine.Rendering.SphericalHarmonicsL2[] @lightProbes, System.Int32 @sourceStart, System.Int32 @destStart, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lightProbes, @sourceStart, @destStart, @count};
            var ___result = RMCopySHCoefficientArraysFrom_SphericalHarmonicsL2Array_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyProbeOcclusionArrayFrom(System.Collections.Generic.List<UnityEngine.Vector4> @occlusionProbes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@occlusionProbes};
            var ___result = RMCopyProbeOcclusionArrayFrom_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyProbeOcclusionArrayFrom(UnityEngine.Vector4[] @occlusionProbes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@occlusionProbes};
            var ___result = RMCopyProbeOcclusionArrayFrom_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyProbeOcclusionArrayFrom(System.Collections.Generic.List<UnityEngine.Vector4> @occlusionProbes, System.Int32 @sourceStart, System.Int32 @destStart, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@occlusionProbes, @sourceStart, @destStart, @count};
            var ___result = RMCopyProbeOcclusionArrayFrom_List_d_Vector4_p__Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyProbeOcclusionArrayFrom(UnityEngine.Vector4[] @occlusionProbes, System.Int32 @sourceStart, System.Int32 @destStart, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@occlusionProbes, @sourceStart, @destStart, @count};
            var ___result = RMCopyProbeOcclusionArrayFrom_Vector4Array_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetVectorImpl_Injected(System.Int32 @name, out UnityEngine.Vector4 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @ret};
            var ___result = RMGetVectorImpl_Injected_Int32_Out_Vector4.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector4)___parameters[1];

            
        }


        public virtual void GetColorImpl_Injected(System.Int32 @name, out UnityEngine.Color @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @ret};
            var ___result = RMGetColorImpl_Injected_Int32_Out_Color.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Color)___parameters[1];

            
        }


        public virtual void GetMatrixImpl_Injected(System.Int32 @name, out UnityEngine.Matrix4x4 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @ret};
            var ___result = RMGetMatrixImpl_Injected_Int32_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Matrix4x4)___parameters[1];

            
        }


        public virtual void SetVectorImpl_Injected(System.Int32 @name, ref UnityEngine.Vector4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetVectorImpl_Injected_Int32_Ref_Vector4.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Vector4)___parameters[1];

            
        }


        public virtual void SetColorImpl_Injected(System.Int32 @name, ref UnityEngine.Color @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetColorImpl_Injected_Int32_Ref_Color.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Color)___parameters[1];

            
        }


        public virtual void SetMatrixImpl_Injected(System.Int32 @name, ref UnityEngine.Matrix4x4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetMatrixImpl_Injected_Int32_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Matrix4x4)___parameters[1];

            
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
