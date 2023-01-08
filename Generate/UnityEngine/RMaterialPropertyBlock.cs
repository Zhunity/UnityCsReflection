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
		/// Boolean isEmpty
		/// </summary>
		protected RProperty r_isEmpty;
		public virtual RProperty RisEmpty
		{
			get
			{
				if(r_isEmpty == null)
				{
					r_isEmpty = new(this, "isEmpty", -1);
					r_isEmpty.SetBelong(this.instance);
				}
				return r_isEmpty;
			}
		}

		/// <summary>
		/// Void AddFloat(System.String, Single)
		/// </summary>
		protected RMethod r_AddFloat_String_Single;
		public virtual RMethod RAddFloat_String_Single
		{
			get
			{
				if(r_AddFloat_String_Single == null)
				{
					r_AddFloat_String_Single = new(this, "AddFloat", 0, typeof(System.String), typeof(System.Single));
					r_AddFloat_String_Single.SetBelong(this.instance);
				}
				return r_AddFloat_String_Single;
			}
		}

		/// <summary>
		/// Void AddFloat(Int32, Single)
		/// </summary>
		protected RMethod r_AddFloat_Int32_Single;
		public virtual RMethod RAddFloat_Int32_Single
		{
			get
			{
				if(r_AddFloat_Int32_Single == null)
				{
					r_AddFloat_Int32_Single = new(this, "AddFloat", 0, typeof(System.Int32), typeof(System.Single));
					r_AddFloat_Int32_Single.SetBelong(this.instance);
				}
				return r_AddFloat_Int32_Single;
			}
		}

		/// <summary>
		/// Void AddVector(System.String, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_AddVector_String_Vector4;
		public virtual RMethod RAddVector_String_Vector4
		{
			get
			{
				if(r_AddVector_String_Vector4 == null)
				{
					r_AddVector_String_Vector4 = new(this, "AddVector", 0, typeof(System.String), typeof(UnityEngine.Vector4));
					r_AddVector_String_Vector4.SetBelong(this.instance);
				}
				return r_AddVector_String_Vector4;
			}
		}

		/// <summary>
		/// Void AddVector(Int32, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_AddVector_Int32_Vector4;
		public virtual RMethod RAddVector_Int32_Vector4
		{
			get
			{
				if(r_AddVector_Int32_Vector4 == null)
				{
					r_AddVector_Int32_Vector4 = new(this, "AddVector", 0, typeof(System.Int32), typeof(UnityEngine.Vector4));
					r_AddVector_Int32_Vector4.SetBelong(this.instance);
				}
				return r_AddVector_Int32_Vector4;
			}
		}

		/// <summary>
		/// Void AddColor(System.String, UnityEngine.Color)
		/// </summary>
		protected RMethod r_AddColor_String_Color;
		public virtual RMethod RAddColor_String_Color
		{
			get
			{
				if(r_AddColor_String_Color == null)
				{
					r_AddColor_String_Color = new(this, "AddColor", 0, typeof(System.String), typeof(UnityEngine.Color));
					r_AddColor_String_Color.SetBelong(this.instance);
				}
				return r_AddColor_String_Color;
			}
		}

		/// <summary>
		/// Void AddColor(Int32, UnityEngine.Color)
		/// </summary>
		protected RMethod r_AddColor_Int32_Color;
		public virtual RMethod RAddColor_Int32_Color
		{
			get
			{
				if(r_AddColor_Int32_Color == null)
				{
					r_AddColor_Int32_Color = new(this, "AddColor", 0, typeof(System.Int32), typeof(UnityEngine.Color));
					r_AddColor_Int32_Color.SetBelong(this.instance);
				}
				return r_AddColor_Int32_Color;
			}
		}

		/// <summary>
		/// Void AddMatrix(System.String, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_AddMatrix_String_Matrix4x4;
		public virtual RMethod RAddMatrix_String_Matrix4x4
		{
			get
			{
				if(r_AddMatrix_String_Matrix4x4 == null)
				{
					r_AddMatrix_String_Matrix4x4 = new(this, "AddMatrix", 0, typeof(System.String), typeof(UnityEngine.Matrix4x4));
					r_AddMatrix_String_Matrix4x4.SetBelong(this.instance);
				}
				return r_AddMatrix_String_Matrix4x4;
			}
		}

		/// <summary>
		/// Void AddMatrix(Int32, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_AddMatrix_Int32_Matrix4x4;
		public virtual RMethod RAddMatrix_Int32_Matrix4x4
		{
			get
			{
				if(r_AddMatrix_Int32_Matrix4x4 == null)
				{
					r_AddMatrix_Int32_Matrix4x4 = new(this, "AddMatrix", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4));
					r_AddMatrix_Int32_Matrix4x4.SetBelong(this.instance);
				}
				return r_AddMatrix_Int32_Matrix4x4;
			}
		}

		/// <summary>
		/// Void AddTexture(System.String, UnityEngine.Texture)
		/// </summary>
		protected RMethod r_AddTexture_String_Texture;
		public virtual RMethod RAddTexture_String_Texture
		{
			get
			{
				if(r_AddTexture_String_Texture == null)
				{
					r_AddTexture_String_Texture = new(this, "AddTexture", 0, typeof(System.String), typeof(UnityEngine.Texture));
					r_AddTexture_String_Texture.SetBelong(this.instance);
				}
				return r_AddTexture_String_Texture;
			}
		}

		/// <summary>
		/// Void AddTexture(Int32, UnityEngine.Texture)
		/// </summary>
		protected RMethod r_AddTexture_Int32_Texture;
		public virtual RMethod RAddTexture_Int32_Texture
		{
			get
			{
				if(r_AddTexture_Int32_Texture == null)
				{
					r_AddTexture_Int32_Texture = new(this, "AddTexture", 0, typeof(System.Int32), typeof(UnityEngine.Texture));
					r_AddTexture_Int32_Texture.SetBelong(this.instance);
				}
				return r_AddTexture_Int32_Texture;
			}
		}

		/// <summary>
		/// Int32 GetIntImpl(Int32)
		/// </summary>
		protected RMethod r_GetIntImpl_Int32;
		public virtual RMethod RGetIntImpl_Int32
		{
			get
			{
				if(r_GetIntImpl_Int32 == null)
				{
					r_GetIntImpl_Int32 = new(this, "GetIntImpl", 0, typeof(System.Int32));
					r_GetIntImpl_Int32.SetBelong(this.instance);
				}
				return r_GetIntImpl_Int32;
			}
		}

		/// <summary>
		/// Single GetFloatImpl(Int32)
		/// </summary>
		protected RMethod r_GetFloatImpl_Int32;
		public virtual RMethod RGetFloatImpl_Int32
		{
			get
			{
				if(r_GetFloatImpl_Int32 == null)
				{
					r_GetFloatImpl_Int32 = new(this, "GetFloatImpl", 0, typeof(System.Int32));
					r_GetFloatImpl_Int32.SetBelong(this.instance);
				}
				return r_GetFloatImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 GetVectorImpl(Int32)
		/// </summary>
		protected RMethod r_GetVectorImpl_Int32;
		public virtual RMethod RGetVectorImpl_Int32
		{
			get
			{
				if(r_GetVectorImpl_Int32 == null)
				{
					r_GetVectorImpl_Int32 = new(this, "GetVectorImpl", 0, typeof(System.Int32));
					r_GetVectorImpl_Int32.SetBelong(this.instance);
				}
				return r_GetVectorImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetColorImpl(Int32)
		/// </summary>
		protected RMethod r_GetColorImpl_Int32;
		public virtual RMethod RGetColorImpl_Int32
		{
			get
			{
				if(r_GetColorImpl_Int32 == null)
				{
					r_GetColorImpl_Int32 = new(this, "GetColorImpl", 0, typeof(System.Int32));
					r_GetColorImpl_Int32.SetBelong(this.instance);
				}
				return r_GetColorImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 GetMatrixImpl(Int32)
		/// </summary>
		protected RMethod r_GetMatrixImpl_Int32;
		public virtual RMethod RGetMatrixImpl_Int32
		{
			get
			{
				if(r_GetMatrixImpl_Int32 == null)
				{
					r_GetMatrixImpl_Int32 = new(this, "GetMatrixImpl", 0, typeof(System.Int32));
					r_GetMatrixImpl_Int32.SetBelong(this.instance);
				}
				return r_GetMatrixImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Texture GetTextureImpl(Int32)
		/// </summary>
		protected RMethod r_GetTextureImpl_Int32;
		public virtual RMethod RGetTextureImpl_Int32
		{
			get
			{
				if(r_GetTextureImpl_Int32 == null)
				{
					r_GetTextureImpl_Int32 = new(this, "GetTextureImpl", 0, typeof(System.Int32));
					r_GetTextureImpl_Int32.SetBelong(this.instance);
				}
				return r_GetTextureImpl_Int32;
			}
		}

		/// <summary>
		/// Boolean HasPropertyImpl(Int32)
		/// </summary>
		protected RMethod r_HasPropertyImpl_Int32;
		public virtual RMethod RHasPropertyImpl_Int32
		{
			get
			{
				if(r_HasPropertyImpl_Int32 == null)
				{
					r_HasPropertyImpl_Int32 = new(this, "HasPropertyImpl", 0, typeof(System.Int32));
					r_HasPropertyImpl_Int32.SetBelong(this.instance);
				}
				return r_HasPropertyImpl_Int32;
			}
		}

		/// <summary>
		/// Boolean HasFloatImpl(Int32)
		/// </summary>
		protected RMethod r_HasFloatImpl_Int32;
		public virtual RMethod RHasFloatImpl_Int32
		{
			get
			{
				if(r_HasFloatImpl_Int32 == null)
				{
					r_HasFloatImpl_Int32 = new(this, "HasFloatImpl", 0, typeof(System.Int32));
					r_HasFloatImpl_Int32.SetBelong(this.instance);
				}
				return r_HasFloatImpl_Int32;
			}
		}

		/// <summary>
		/// Boolean HasIntImpl(Int32)
		/// </summary>
		protected RMethod r_HasIntImpl_Int32;
		public virtual RMethod RHasIntImpl_Int32
		{
			get
			{
				if(r_HasIntImpl_Int32 == null)
				{
					r_HasIntImpl_Int32 = new(this, "HasIntImpl", 0, typeof(System.Int32));
					r_HasIntImpl_Int32.SetBelong(this.instance);
				}
				return r_HasIntImpl_Int32;
			}
		}

		/// <summary>
		/// Boolean HasTextureImpl(Int32)
		/// </summary>
		protected RMethod r_HasTextureImpl_Int32;
		public virtual RMethod RHasTextureImpl_Int32
		{
			get
			{
				if(r_HasTextureImpl_Int32 == null)
				{
					r_HasTextureImpl_Int32 = new(this, "HasTextureImpl", 0, typeof(System.Int32));
					r_HasTextureImpl_Int32.SetBelong(this.instance);
				}
				return r_HasTextureImpl_Int32;
			}
		}

		/// <summary>
		/// Boolean HasMatrixImpl(Int32)
		/// </summary>
		protected RMethod r_HasMatrixImpl_Int32;
		public virtual RMethod RHasMatrixImpl_Int32
		{
			get
			{
				if(r_HasMatrixImpl_Int32 == null)
				{
					r_HasMatrixImpl_Int32 = new(this, "HasMatrixImpl", 0, typeof(System.Int32));
					r_HasMatrixImpl_Int32.SetBelong(this.instance);
				}
				return r_HasMatrixImpl_Int32;
			}
		}

		/// <summary>
		/// Boolean HasVectorImpl(Int32)
		/// </summary>
		protected RMethod r_HasVectorImpl_Int32;
		public virtual RMethod RHasVectorImpl_Int32
		{
			get
			{
				if(r_HasVectorImpl_Int32 == null)
				{
					r_HasVectorImpl_Int32 = new(this, "HasVectorImpl", 0, typeof(System.Int32));
					r_HasVectorImpl_Int32.SetBelong(this.instance);
				}
				return r_HasVectorImpl_Int32;
			}
		}

		/// <summary>
		/// Boolean HasBufferImpl(Int32)
		/// </summary>
		protected RMethod r_HasBufferImpl_Int32;
		public virtual RMethod RHasBufferImpl_Int32
		{
			get
			{
				if(r_HasBufferImpl_Int32 == null)
				{
					r_HasBufferImpl_Int32 = new(this, "HasBufferImpl", 0, typeof(System.Int32));
					r_HasBufferImpl_Int32.SetBelong(this.instance);
				}
				return r_HasBufferImpl_Int32;
			}
		}

		/// <summary>
		/// Boolean HasConstantBufferImpl(Int32)
		/// </summary>
		protected RMethod r_HasConstantBufferImpl_Int32;
		public virtual RMethod RHasConstantBufferImpl_Int32
		{
			get
			{
				if(r_HasConstantBufferImpl_Int32 == null)
				{
					r_HasConstantBufferImpl_Int32 = new(this, "HasConstantBufferImpl", 0, typeof(System.Int32));
					r_HasConstantBufferImpl_Int32.SetBelong(this.instance);
				}
				return r_HasConstantBufferImpl_Int32;
			}
		}

		/// <summary>
		/// Void SetIntImpl(Int32, Int32)
		/// </summary>
		protected RMethod r_SetIntImpl_Int32_Int32;
		public virtual RMethod RSetIntImpl_Int32_Int32
		{
			get
			{
				if(r_SetIntImpl_Int32_Int32 == null)
				{
					r_SetIntImpl_Int32_Int32 = new(this, "SetIntImpl", 0, typeof(System.Int32), typeof(System.Int32));
					r_SetIntImpl_Int32_Int32.SetBelong(this.instance);
				}
				return r_SetIntImpl_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetFloatImpl(Int32, Single)
		/// </summary>
		protected RMethod r_SetFloatImpl_Int32_Single;
		public virtual RMethod RSetFloatImpl_Int32_Single
		{
			get
			{
				if(r_SetFloatImpl_Int32_Single == null)
				{
					r_SetFloatImpl_Int32_Single = new(this, "SetFloatImpl", 0, typeof(System.Int32), typeof(System.Single));
					r_SetFloatImpl_Int32_Single.SetBelong(this.instance);
				}
				return r_SetFloatImpl_Int32_Single;
			}
		}

		/// <summary>
		/// Void SetVectorImpl(Int32, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_SetVectorImpl_Int32_Vector4;
		public virtual RMethod RSetVectorImpl_Int32_Vector4
		{
			get
			{
				if(r_SetVectorImpl_Int32_Vector4 == null)
				{
					r_SetVectorImpl_Int32_Vector4 = new(this, "SetVectorImpl", 0, typeof(System.Int32), typeof(UnityEngine.Vector4));
					r_SetVectorImpl_Int32_Vector4.SetBelong(this.instance);
				}
				return r_SetVectorImpl_Int32_Vector4;
			}
		}

		/// <summary>
		/// Void SetColorImpl(Int32, UnityEngine.Color)
		/// </summary>
		protected RMethod r_SetColorImpl_Int32_Color;
		public virtual RMethod RSetColorImpl_Int32_Color
		{
			get
			{
				if(r_SetColorImpl_Int32_Color == null)
				{
					r_SetColorImpl_Int32_Color = new(this, "SetColorImpl", 0, typeof(System.Int32), typeof(UnityEngine.Color));
					r_SetColorImpl_Int32_Color.SetBelong(this.instance);
				}
				return r_SetColorImpl_Int32_Color;
			}
		}

		/// <summary>
		/// Void SetMatrixImpl(Int32, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_SetMatrixImpl_Int32_Matrix4x4;
		public virtual RMethod RSetMatrixImpl_Int32_Matrix4x4
		{
			get
			{
				if(r_SetMatrixImpl_Int32_Matrix4x4 == null)
				{
					r_SetMatrixImpl_Int32_Matrix4x4 = new(this, "SetMatrixImpl", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4));
					r_SetMatrixImpl_Int32_Matrix4x4.SetBelong(this.instance);
				}
				return r_SetMatrixImpl_Int32_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetTextureImpl(Int32, UnityEngine.Texture)
		/// </summary>
		protected RMethod r_SetTextureImpl_Int32_Texture;
		public virtual RMethod RSetTextureImpl_Int32_Texture
		{
			get
			{
				if(r_SetTextureImpl_Int32_Texture == null)
				{
					r_SetTextureImpl_Int32_Texture = new(this, "SetTextureImpl", 0, typeof(System.Int32), typeof(UnityEngine.Texture));
					r_SetTextureImpl_Int32_Texture.SetBelong(this.instance);
				}
				return r_SetTextureImpl_Int32_Texture;
			}
		}

		/// <summary>
		/// Void SetRenderTextureImpl(Int32, UnityEngine.RenderTexture, UnityEngine.Rendering.RenderTextureSubElement)
		/// </summary>
		protected RMethod r_SetRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement;
		public virtual RMethod RSetRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement
		{
			get
			{
				if(r_SetRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement == null)
				{
					r_SetRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement = new(this, "SetRenderTextureImpl", 0, typeof(System.Int32), typeof(UnityEngine.RenderTexture), typeof(UnityEngine.Rendering.RenderTextureSubElement));
					r_SetRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement.SetBelong(this.instance);
				}
				return r_SetRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement;
			}
		}

		/// <summary>
		/// Void SetBufferImpl(Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_SetBufferImpl_Int32_ComputeBuffer;
		public virtual RMethod RSetBufferImpl_Int32_ComputeBuffer
		{
			get
			{
				if(r_SetBufferImpl_Int32_ComputeBuffer == null)
				{
					r_SetBufferImpl_Int32_ComputeBuffer = new(this, "SetBufferImpl", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
					r_SetBufferImpl_Int32_ComputeBuffer.SetBelong(this.instance);
				}
				return r_SetBufferImpl_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetGraphicsBufferImpl(Int32, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_SetGraphicsBufferImpl_Int32_GraphicsBuffer;
		public virtual RMethod RSetGraphicsBufferImpl_Int32_GraphicsBuffer
		{
			get
			{
				if(r_SetGraphicsBufferImpl_Int32_GraphicsBuffer == null)
				{
					r_SetGraphicsBufferImpl_Int32_GraphicsBuffer = new(this, "SetGraphicsBufferImpl", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer));
					r_SetGraphicsBufferImpl_Int32_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_SetGraphicsBufferImpl_Int32_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetConstantBufferImpl(Int32, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_SetConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32;
		public virtual RMethod RSetConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_SetConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32 == null)
				{
					r_SetConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32 = new(this, "SetConstantBufferImpl", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
					r_SetConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_SetConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetConstantGraphicsBufferImpl(Int32, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_SetConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32;
		public virtual RMethod RSetConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_SetConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32 == null)
				{
					r_SetConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32 = new(this, "SetConstantGraphicsBufferImpl", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
					r_SetConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_SetConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetFloatArrayImpl(Int32, Single[], Int32)
		/// </summary>
		protected RMethod r_SetFloatArrayImpl_Int32_SingleArray_Int32;
		public virtual RMethod RSetFloatArrayImpl_Int32_SingleArray_Int32
		{
			get
			{
				if(r_SetFloatArrayImpl_Int32_SingleArray_Int32 == null)
				{
					r_SetFloatArrayImpl_Int32_SingleArray_Int32 = new(this, "SetFloatArrayImpl", 0, typeof(System.Int32), typeof(System.Single).MakeArrayType(), typeof(System.Int32));
					r_SetFloatArrayImpl_Int32_SingleArray_Int32.SetBelong(this.instance);
				}
				return r_SetFloatArrayImpl_Int32_SingleArray_Int32;
			}
		}

		/// <summary>
		/// Void SetVectorArrayImpl(Int32, UnityEngine.Vector4[], Int32)
		/// </summary>
		protected RMethod r_SetVectorArrayImpl_Int32_Vector4Array_Int32;
		public virtual RMethod RSetVectorArrayImpl_Int32_Vector4Array_Int32
		{
			get
			{
				if(r_SetVectorArrayImpl_Int32_Vector4Array_Int32 == null)
				{
					r_SetVectorArrayImpl_Int32_Vector4Array_Int32 = new(this, "SetVectorArrayImpl", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType(), typeof(System.Int32));
					r_SetVectorArrayImpl_Int32_Vector4Array_Int32.SetBelong(this.instance);
				}
				return r_SetVectorArrayImpl_Int32_Vector4Array_Int32;
			}
		}

		/// <summary>
		/// Void SetMatrixArrayImpl(Int32, UnityEngine.Matrix4x4[], Int32)
		/// </summary>
		protected RMethod r_SetMatrixArrayImpl_Int32_Matrix4x4Array_Int32;
		public virtual RMethod RSetMatrixArrayImpl_Int32_Matrix4x4Array_Int32
		{
			get
			{
				if(r_SetMatrixArrayImpl_Int32_Matrix4x4Array_Int32 == null)
				{
					r_SetMatrixArrayImpl_Int32_Matrix4x4Array_Int32 = new(this, "SetMatrixArrayImpl", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType(), typeof(System.Int32));
					r_SetMatrixArrayImpl_Int32_Matrix4x4Array_Int32.SetBelong(this.instance);
				}
				return r_SetMatrixArrayImpl_Int32_Matrix4x4Array_Int32;
			}
		}

		/// <summary>
		/// Single[] GetFloatArrayImpl(Int32)
		/// </summary>
		protected RMethod r_GetFloatArrayImpl_Int32;
		public virtual RMethod RGetFloatArrayImpl_Int32
		{
			get
			{
				if(r_GetFloatArrayImpl_Int32 == null)
				{
					r_GetFloatArrayImpl_Int32 = new(this, "GetFloatArrayImpl", 0, typeof(System.Int32));
					r_GetFloatArrayImpl_Int32.SetBelong(this.instance);
				}
				return r_GetFloatArrayImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4[] GetVectorArrayImpl(Int32)
		/// </summary>
		protected RMethod r_GetVectorArrayImpl_Int32;
		public virtual RMethod RGetVectorArrayImpl_Int32
		{
			get
			{
				if(r_GetVectorArrayImpl_Int32 == null)
				{
					r_GetVectorArrayImpl_Int32 = new(this, "GetVectorArrayImpl", 0, typeof(System.Int32));
					r_GetVectorArrayImpl_Int32.SetBelong(this.instance);
				}
				return r_GetVectorArrayImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4[] GetMatrixArrayImpl(Int32)
		/// </summary>
		protected RMethod r_GetMatrixArrayImpl_Int32;
		public virtual RMethod RGetMatrixArrayImpl_Int32
		{
			get
			{
				if(r_GetMatrixArrayImpl_Int32 == null)
				{
					r_GetMatrixArrayImpl_Int32 = new(this, "GetMatrixArrayImpl", 0, typeof(System.Int32));
					r_GetMatrixArrayImpl_Int32.SetBelong(this.instance);
				}
				return r_GetMatrixArrayImpl_Int32;
			}
		}

		/// <summary>
		/// Int32 GetFloatArrayCountImpl(Int32)
		/// </summary>
		protected RMethod r_GetFloatArrayCountImpl_Int32;
		public virtual RMethod RGetFloatArrayCountImpl_Int32
		{
			get
			{
				if(r_GetFloatArrayCountImpl_Int32 == null)
				{
					r_GetFloatArrayCountImpl_Int32 = new(this, "GetFloatArrayCountImpl", 0, typeof(System.Int32));
					r_GetFloatArrayCountImpl_Int32.SetBelong(this.instance);
				}
				return r_GetFloatArrayCountImpl_Int32;
			}
		}

		/// <summary>
		/// Int32 GetVectorArrayCountImpl(Int32)
		/// </summary>
		protected RMethod r_GetVectorArrayCountImpl_Int32;
		public virtual RMethod RGetVectorArrayCountImpl_Int32
		{
			get
			{
				if(r_GetVectorArrayCountImpl_Int32 == null)
				{
					r_GetVectorArrayCountImpl_Int32 = new(this, "GetVectorArrayCountImpl", 0, typeof(System.Int32));
					r_GetVectorArrayCountImpl_Int32.SetBelong(this.instance);
				}
				return r_GetVectorArrayCountImpl_Int32;
			}
		}

		/// <summary>
		/// Int32 GetMatrixArrayCountImpl(Int32)
		/// </summary>
		protected RMethod r_GetMatrixArrayCountImpl_Int32;
		public virtual RMethod RGetMatrixArrayCountImpl_Int32
		{
			get
			{
				if(r_GetMatrixArrayCountImpl_Int32 == null)
				{
					r_GetMatrixArrayCountImpl_Int32 = new(this, "GetMatrixArrayCountImpl", 0, typeof(System.Int32));
					r_GetMatrixArrayCountImpl_Int32.SetBelong(this.instance);
				}
				return r_GetMatrixArrayCountImpl_Int32;
			}
		}

		/// <summary>
		/// Void ExtractFloatArrayImpl(Int32, Single[])
		/// </summary>
		protected RMethod r_ExtractFloatArrayImpl_Int32_SingleArray;
		public virtual RMethod RExtractFloatArrayImpl_Int32_SingleArray
		{
			get
			{
				if(r_ExtractFloatArrayImpl_Int32_SingleArray == null)
				{
					r_ExtractFloatArrayImpl_Int32_SingleArray = new(this, "ExtractFloatArrayImpl", 0, typeof(System.Int32), typeof(System.Single).MakeArrayType());
					r_ExtractFloatArrayImpl_Int32_SingleArray.SetBelong(this.instance);
				}
				return r_ExtractFloatArrayImpl_Int32_SingleArray;
			}
		}

		/// <summary>
		/// Void ExtractVectorArrayImpl(Int32, UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_ExtractVectorArrayImpl_Int32_Vector4Array;
		public virtual RMethod RExtractVectorArrayImpl_Int32_Vector4Array
		{
			get
			{
				if(r_ExtractVectorArrayImpl_Int32_Vector4Array == null)
				{
					r_ExtractVectorArrayImpl_Int32_Vector4Array = new(this, "ExtractVectorArrayImpl", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType());
					r_ExtractVectorArrayImpl_Int32_Vector4Array.SetBelong(this.instance);
				}
				return r_ExtractVectorArrayImpl_Int32_Vector4Array;
			}
		}

		/// <summary>
		/// Void ExtractMatrixArrayImpl(Int32, UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_ExtractMatrixArrayImpl_Int32_Matrix4x4Array;
		public virtual RMethod RExtractMatrixArrayImpl_Int32_Matrix4x4Array
		{
			get
			{
				if(r_ExtractMatrixArrayImpl_Int32_Matrix4x4Array == null)
				{
					r_ExtractMatrixArrayImpl_Int32_Matrix4x4Array = new(this, "ExtractMatrixArrayImpl", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType());
					r_ExtractMatrixArrayImpl_Int32_Matrix4x4Array.SetBelong(this.instance);
				}
				return r_ExtractMatrixArrayImpl_Int32_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Void Internal_CopySHCoefficientArraysFrom(UnityEngine.MaterialPropertyBlock, UnityEngine.Rendering.SphericalHarmonicsL2[], Int32, Int32, Int32)
		/// </summary>
		protected static RMethod r_Internal_CopySHCoefficientArraysFrom_MaterialPropertyBlock_SphericalHarmonicsL2Array_Int32_Int32_Int32;
		public static RMethod RInternal_CopySHCoefficientArraysFrom_MaterialPropertyBlock_SphericalHarmonicsL2Array_Int32_Int32_Int32
		{
			get
			{
				if(r_Internal_CopySHCoefficientArraysFrom_MaterialPropertyBlock_SphericalHarmonicsL2Array_Int32_Int32_Int32 == null)
				{
					r_Internal_CopySHCoefficientArraysFrom_MaterialPropertyBlock_SphericalHarmonicsL2Array_Int32_Int32_Int32 = new(typeof(UnityEngine.MaterialPropertyBlock), "Internal_CopySHCoefficientArraysFrom", 0, typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.SphericalHarmonicsL2).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_Internal_CopySHCoefficientArraysFrom_MaterialPropertyBlock_SphericalHarmonicsL2Array_Int32_Int32_Int32.SetBelong(null);
				}
				return r_Internal_CopySHCoefficientArraysFrom_MaterialPropertyBlock_SphericalHarmonicsL2Array_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Internal_CopyProbeOcclusionArrayFrom(UnityEngine.MaterialPropertyBlock, UnityEngine.Vector4[], Int32, Int32, Int32)
		/// </summary>
		protected static RMethod r_Internal_CopyProbeOcclusionArrayFrom_MaterialPropertyBlock_Vector4Array_Int32_Int32_Int32;
		public static RMethod RInternal_CopyProbeOcclusionArrayFrom_MaterialPropertyBlock_Vector4Array_Int32_Int32_Int32
		{
			get
			{
				if(r_Internal_CopyProbeOcclusionArrayFrom_MaterialPropertyBlock_Vector4Array_Int32_Int32_Int32 == null)
				{
					r_Internal_CopyProbeOcclusionArrayFrom_MaterialPropertyBlock_Vector4Array_Int32_Int32_Int32 = new(typeof(UnityEngine.MaterialPropertyBlock), "Internal_CopyProbeOcclusionArrayFrom", 0, typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Vector4).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_Internal_CopyProbeOcclusionArrayFrom_MaterialPropertyBlock_Vector4Array_Int32_Int32_Int32.SetBelong(null);
				}
				return r_Internal_CopyProbeOcclusionArrayFrom_MaterialPropertyBlock_Vector4Array_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// IntPtr CreateImpl()
		/// </summary>
		protected static RMethod r_CreateImpl;
		public static RMethod RCreateImpl
		{
			get
			{
				if(r_CreateImpl == null)
				{
					r_CreateImpl = new(typeof(UnityEngine.MaterialPropertyBlock), "CreateImpl", 0);
					r_CreateImpl.SetBelong(null);
				}
				return r_CreateImpl;
			}
		}

		/// <summary>
		/// Void DestroyImpl(IntPtr)
		/// </summary>
		protected static RMethod r_DestroyImpl_IntPtr;
		public static RMethod RDestroyImpl_IntPtr
		{
			get
			{
				if(r_DestroyImpl_IntPtr == null)
				{
					r_DestroyImpl_IntPtr = new(typeof(UnityEngine.MaterialPropertyBlock), "DestroyImpl", 0, typeof(System.IntPtr));
					r_DestroyImpl_IntPtr.SetBelong(null);
				}
				return r_DestroyImpl_IntPtr;
			}
		}

		/// <summary>
		/// Void Clear(Boolean)
		/// </summary>
		protected RMethod r_Clear_Boolean;
		public virtual RMethod RClear_Boolean
		{
			get
			{
				if(r_Clear_Boolean == null)
				{
					r_Clear_Boolean = new(this, "Clear", 0, typeof(System.Boolean));
					r_Clear_Boolean.SetBelong(this.instance);
				}
				return r_Clear_Boolean;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_Clear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_Clear == null)
				{
					r_Clear = new(this, "Clear", 0);
					r_Clear.SetBelong(this.instance);
				}
				return r_Clear;
			}
		}

		/// <summary>
		/// Void SetFloatArray(Int32, Single[], Int32)
		/// </summary>
		protected RMethod r_SetFloatArray_Int32_SingleArray_Int32;
		public virtual RMethod RSetFloatArray_Int32_SingleArray_Int32
		{
			get
			{
				if(r_SetFloatArray_Int32_SingleArray_Int32 == null)
				{
					r_SetFloatArray_Int32_SingleArray_Int32 = new(this, "SetFloatArray", 0, typeof(System.Int32), typeof(System.Single).MakeArrayType(), typeof(System.Int32));
					r_SetFloatArray_Int32_SingleArray_Int32.SetBelong(this.instance);
				}
				return r_SetFloatArray_Int32_SingleArray_Int32;
			}
		}

		/// <summary>
		/// Void SetVectorArray(Int32, UnityEngine.Vector4[], Int32)
		/// </summary>
		protected RMethod r_SetVectorArray_Int32_Vector4Array_Int32;
		public virtual RMethod RSetVectorArray_Int32_Vector4Array_Int32
		{
			get
			{
				if(r_SetVectorArray_Int32_Vector4Array_Int32 == null)
				{
					r_SetVectorArray_Int32_Vector4Array_Int32 = new(this, "SetVectorArray", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType(), typeof(System.Int32));
					r_SetVectorArray_Int32_Vector4Array_Int32.SetBelong(this.instance);
				}
				return r_SetVectorArray_Int32_Vector4Array_Int32;
			}
		}

		/// <summary>
		/// Void SetMatrixArray(Int32, UnityEngine.Matrix4x4[], Int32)
		/// </summary>
		protected RMethod r_SetMatrixArray_Int32_Matrix4x4Array_Int32;
		public virtual RMethod RSetMatrixArray_Int32_Matrix4x4Array_Int32
		{
			get
			{
				if(r_SetMatrixArray_Int32_Matrix4x4Array_Int32 == null)
				{
					r_SetMatrixArray_Int32_Matrix4x4Array_Int32 = new(this, "SetMatrixArray", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType(), typeof(System.Int32));
					r_SetMatrixArray_Int32_Matrix4x4Array_Int32.SetBelong(this.instance);
				}
				return r_SetMatrixArray_Int32_Matrix4x4Array_Int32;
			}
		}

		/// <summary>
		/// Void ExtractFloatArray(Int32, System.Collections.Generic.List`1[System.Single])
		/// </summary>
		protected RMethod r_ExtractFloatArray_Int32_List_d_Single_p_;
		public virtual RMethod RExtractFloatArray_Int32_List_d_Single_p_
		{
			get
			{
				if(r_ExtractFloatArray_Int32_List_d_Single_p_ == null)
				{
					r_ExtractFloatArray_Int32_List_d_Single_p_ = new(this, "ExtractFloatArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Single)));
					r_ExtractFloatArray_Int32_List_d_Single_p_.SetBelong(this.instance);
				}
				return r_ExtractFloatArray_Int32_List_d_Single_p_;
			}
		}

		/// <summary>
		/// Void ExtractVectorArray(Int32, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_ExtractVectorArray_Int32_List_d_Vector4_p_;
		public virtual RMethod RExtractVectorArray_Int32_List_d_Vector4_p_
		{
			get
			{
				if(r_ExtractVectorArray_Int32_List_d_Vector4_p_ == null)
				{
					r_ExtractVectorArray_Int32_List_d_Vector4_p_ = new(this, "ExtractVectorArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_ExtractVectorArray_Int32_List_d_Vector4_p_.SetBelong(this.instance);
				}
				return r_ExtractVectorArray_Int32_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void ExtractMatrixArray(Int32, System.Collections.Generic.List`1[UnityEngine.Matrix4x4])
		/// </summary>
		protected RMethod r_ExtractMatrixArray_Int32_List_d_Matrix4x4_p_;
		public virtual RMethod RExtractMatrixArray_Int32_List_d_Matrix4x4_p_
		{
			get
			{
				if(r_ExtractMatrixArray_Int32_List_d_Matrix4x4_p_ == null)
				{
					r_ExtractMatrixArray_Int32_List_d_Matrix4x4_p_ = new(this, "ExtractMatrixArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Matrix4x4)));
					r_ExtractMatrixArray_Int32_List_d_Matrix4x4_p_.SetBelong(this.instance);
				}
				return r_ExtractMatrixArray_Int32_List_d_Matrix4x4_p_;
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
		/// Void Dispose()
		/// </summary>
		protected RMethod r_Dispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_Dispose == null)
				{
					r_Dispose = new(this, "Dispose", 0);
					r_Dispose.SetBelong(this.instance);
				}
				return r_Dispose;
			}
		}

		/// <summary>
		/// Void SetInt(System.String, Int32)
		/// </summary>
		protected RMethod r_SetInt_String_Int32;
		public virtual RMethod RSetInt_String_Int32
		{
			get
			{
				if(r_SetInt_String_Int32 == null)
				{
					r_SetInt_String_Int32 = new(this, "SetInt", 0, typeof(System.String), typeof(System.Int32));
					r_SetInt_String_Int32.SetBelong(this.instance);
				}
				return r_SetInt_String_Int32;
			}
		}

		/// <summary>
		/// Void SetInt(Int32, Int32)
		/// </summary>
		protected RMethod r_SetInt_Int32_Int32;
		public virtual RMethod RSetInt_Int32_Int32
		{
			get
			{
				if(r_SetInt_Int32_Int32 == null)
				{
					r_SetInt_Int32_Int32 = new(this, "SetInt", 0, typeof(System.Int32), typeof(System.Int32));
					r_SetInt_Int32_Int32.SetBelong(this.instance);
				}
				return r_SetInt_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetFloat(System.String, Single)
		/// </summary>
		protected RMethod r_SetFloat_String_Single;
		public virtual RMethod RSetFloat_String_Single
		{
			get
			{
				if(r_SetFloat_String_Single == null)
				{
					r_SetFloat_String_Single = new(this, "SetFloat", 0, typeof(System.String), typeof(System.Single));
					r_SetFloat_String_Single.SetBelong(this.instance);
				}
				return r_SetFloat_String_Single;
			}
		}

		/// <summary>
		/// Void SetFloat(Int32, Single)
		/// </summary>
		protected RMethod r_SetFloat_Int32_Single;
		public virtual RMethod RSetFloat_Int32_Single
		{
			get
			{
				if(r_SetFloat_Int32_Single == null)
				{
					r_SetFloat_Int32_Single = new(this, "SetFloat", 0, typeof(System.Int32), typeof(System.Single));
					r_SetFloat_Int32_Single.SetBelong(this.instance);
				}
				return r_SetFloat_Int32_Single;
			}
		}

		/// <summary>
		/// Void SetInteger(System.String, Int32)
		/// </summary>
		protected RMethod r_SetInteger_String_Int32;
		public virtual RMethod RSetInteger_String_Int32
		{
			get
			{
				if(r_SetInteger_String_Int32 == null)
				{
					r_SetInteger_String_Int32 = new(this, "SetInteger", 0, typeof(System.String), typeof(System.Int32));
					r_SetInteger_String_Int32.SetBelong(this.instance);
				}
				return r_SetInteger_String_Int32;
			}
		}

		/// <summary>
		/// Void SetInteger(Int32, Int32)
		/// </summary>
		protected RMethod r_SetInteger_Int32_Int32;
		public virtual RMethod RSetInteger_Int32_Int32
		{
			get
			{
				if(r_SetInteger_Int32_Int32 == null)
				{
					r_SetInteger_Int32_Int32 = new(this, "SetInteger", 0, typeof(System.Int32), typeof(System.Int32));
					r_SetInteger_Int32_Int32.SetBelong(this.instance);
				}
				return r_SetInteger_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetVector(System.String, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_SetVector_String_Vector4;
		public virtual RMethod RSetVector_String_Vector4
		{
			get
			{
				if(r_SetVector_String_Vector4 == null)
				{
					r_SetVector_String_Vector4 = new(this, "SetVector", 0, typeof(System.String), typeof(UnityEngine.Vector4));
					r_SetVector_String_Vector4.SetBelong(this.instance);
				}
				return r_SetVector_String_Vector4;
			}
		}

		/// <summary>
		/// Void SetVector(Int32, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_SetVector_Int32_Vector4;
		public virtual RMethod RSetVector_Int32_Vector4
		{
			get
			{
				if(r_SetVector_Int32_Vector4 == null)
				{
					r_SetVector_Int32_Vector4 = new(this, "SetVector", 0, typeof(System.Int32), typeof(UnityEngine.Vector4));
					r_SetVector_Int32_Vector4.SetBelong(this.instance);
				}
				return r_SetVector_Int32_Vector4;
			}
		}

		/// <summary>
		/// Void SetColor(System.String, UnityEngine.Color)
		/// </summary>
		protected RMethod r_SetColor_String_Color;
		public virtual RMethod RSetColor_String_Color
		{
			get
			{
				if(r_SetColor_String_Color == null)
				{
					r_SetColor_String_Color = new(this, "SetColor", 0, typeof(System.String), typeof(UnityEngine.Color));
					r_SetColor_String_Color.SetBelong(this.instance);
				}
				return r_SetColor_String_Color;
			}
		}

		/// <summary>
		/// Void SetColor(Int32, UnityEngine.Color)
		/// </summary>
		protected RMethod r_SetColor_Int32_Color;
		public virtual RMethod RSetColor_Int32_Color
		{
			get
			{
				if(r_SetColor_Int32_Color == null)
				{
					r_SetColor_Int32_Color = new(this, "SetColor", 0, typeof(System.Int32), typeof(UnityEngine.Color));
					r_SetColor_Int32_Color.SetBelong(this.instance);
				}
				return r_SetColor_Int32_Color;
			}
		}

		/// <summary>
		/// Void SetMatrix(System.String, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_SetMatrix_String_Matrix4x4;
		public virtual RMethod RSetMatrix_String_Matrix4x4
		{
			get
			{
				if(r_SetMatrix_String_Matrix4x4 == null)
				{
					r_SetMatrix_String_Matrix4x4 = new(this, "SetMatrix", 0, typeof(System.String), typeof(UnityEngine.Matrix4x4));
					r_SetMatrix_String_Matrix4x4.SetBelong(this.instance);
				}
				return r_SetMatrix_String_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetMatrix(Int32, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_SetMatrix_Int32_Matrix4x4;
		public virtual RMethod RSetMatrix_Int32_Matrix4x4
		{
			get
			{
				if(r_SetMatrix_Int32_Matrix4x4 == null)
				{
					r_SetMatrix_Int32_Matrix4x4 = new(this, "SetMatrix", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4));
					r_SetMatrix_Int32_Matrix4x4.SetBelong(this.instance);
				}
				return r_SetMatrix_Int32_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetBuffer(System.String, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_SetBuffer_String_ComputeBuffer;
		public virtual RMethod RSetBuffer_String_ComputeBuffer
		{
			get
			{
				if(r_SetBuffer_String_ComputeBuffer == null)
				{
					r_SetBuffer_String_ComputeBuffer = new(this, "SetBuffer", 0, typeof(System.String), typeof(UnityEngine.ComputeBuffer));
					r_SetBuffer_String_ComputeBuffer.SetBelong(this.instance);
				}
				return r_SetBuffer_String_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetBuffer(Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_SetBuffer_Int32_ComputeBuffer;
		public virtual RMethod RSetBuffer_Int32_ComputeBuffer
		{
			get
			{
				if(r_SetBuffer_Int32_ComputeBuffer == null)
				{
					r_SetBuffer_Int32_ComputeBuffer = new(this, "SetBuffer", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
					r_SetBuffer_Int32_ComputeBuffer.SetBelong(this.instance);
				}
				return r_SetBuffer_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetBuffer(System.String, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_SetBuffer_String_GraphicsBuffer;
		public virtual RMethod RSetBuffer_String_GraphicsBuffer
		{
			get
			{
				if(r_SetBuffer_String_GraphicsBuffer == null)
				{
					r_SetBuffer_String_GraphicsBuffer = new(this, "SetBuffer", 0, typeof(System.String), typeof(UnityEngine.GraphicsBuffer));
					r_SetBuffer_String_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_SetBuffer_String_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetBuffer(Int32, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_SetBuffer_Int32_GraphicsBuffer;
		public virtual RMethod RSetBuffer_Int32_GraphicsBuffer
		{
			get
			{
				if(r_SetBuffer_Int32_GraphicsBuffer == null)
				{
					r_SetBuffer_Int32_GraphicsBuffer = new(this, "SetBuffer", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer));
					r_SetBuffer_Int32_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_SetBuffer_Int32_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetTexture(System.String, UnityEngine.Texture)
		/// </summary>
		protected RMethod r_SetTexture_String_Texture;
		public virtual RMethod RSetTexture_String_Texture
		{
			get
			{
				if(r_SetTexture_String_Texture == null)
				{
					r_SetTexture_String_Texture = new(this, "SetTexture", 0, typeof(System.String), typeof(UnityEngine.Texture));
					r_SetTexture_String_Texture.SetBelong(this.instance);
				}
				return r_SetTexture_String_Texture;
			}
		}

		/// <summary>
		/// Void SetTexture(Int32, UnityEngine.Texture)
		/// </summary>
		protected RMethod r_SetTexture_Int32_Texture;
		public virtual RMethod RSetTexture_Int32_Texture
		{
			get
			{
				if(r_SetTexture_Int32_Texture == null)
				{
					r_SetTexture_Int32_Texture = new(this, "SetTexture", 0, typeof(System.Int32), typeof(UnityEngine.Texture));
					r_SetTexture_Int32_Texture.SetBelong(this.instance);
				}
				return r_SetTexture_Int32_Texture;
			}
		}

		/// <summary>
		/// Void SetTexture(System.String, UnityEngine.RenderTexture, UnityEngine.Rendering.RenderTextureSubElement)
		/// </summary>
		protected RMethod r_SetTexture_String_RenderTexture_RenderTextureSubElement;
		public virtual RMethod RSetTexture_String_RenderTexture_RenderTextureSubElement
		{
			get
			{
				if(r_SetTexture_String_RenderTexture_RenderTextureSubElement == null)
				{
					r_SetTexture_String_RenderTexture_RenderTextureSubElement = new(this, "SetTexture", 0, typeof(System.String), typeof(UnityEngine.RenderTexture), typeof(UnityEngine.Rendering.RenderTextureSubElement));
					r_SetTexture_String_RenderTexture_RenderTextureSubElement.SetBelong(this.instance);
				}
				return r_SetTexture_String_RenderTexture_RenderTextureSubElement;
			}
		}

		/// <summary>
		/// Void SetTexture(Int32, UnityEngine.RenderTexture, UnityEngine.Rendering.RenderTextureSubElement)
		/// </summary>
		protected RMethod r_SetTexture_Int32_RenderTexture_RenderTextureSubElement;
		public virtual RMethod RSetTexture_Int32_RenderTexture_RenderTextureSubElement
		{
			get
			{
				if(r_SetTexture_Int32_RenderTexture_RenderTextureSubElement == null)
				{
					r_SetTexture_Int32_RenderTexture_RenderTextureSubElement = new(this, "SetTexture", 0, typeof(System.Int32), typeof(UnityEngine.RenderTexture), typeof(UnityEngine.Rendering.RenderTextureSubElement));
					r_SetTexture_Int32_RenderTexture_RenderTextureSubElement.SetBelong(this.instance);
				}
				return r_SetTexture_Int32_RenderTexture_RenderTextureSubElement;
			}
		}

		/// <summary>
		/// Void SetConstantBuffer(System.String, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_SetConstantBuffer_String_ComputeBuffer_Int32_Int32;
		public virtual RMethod RSetConstantBuffer_String_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_SetConstantBuffer_String_ComputeBuffer_Int32_Int32 == null)
				{
					r_SetConstantBuffer_String_ComputeBuffer_Int32_Int32 = new(this, "SetConstantBuffer", 0, typeof(System.String), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
					r_SetConstantBuffer_String_ComputeBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_SetConstantBuffer_String_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetConstantBuffer(Int32, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_SetConstantBuffer_Int32_ComputeBuffer_Int32_Int32;
		public virtual RMethod RSetConstantBuffer_Int32_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_SetConstantBuffer_Int32_ComputeBuffer_Int32_Int32 == null)
				{
					r_SetConstantBuffer_Int32_ComputeBuffer_Int32_Int32 = new(this, "SetConstantBuffer", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
					r_SetConstantBuffer_Int32_ComputeBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_SetConstantBuffer_Int32_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetConstantBuffer(System.String, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_SetConstantBuffer_String_GraphicsBuffer_Int32_Int32;
		public virtual RMethod RSetConstantBuffer_String_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_SetConstantBuffer_String_GraphicsBuffer_Int32_Int32 == null)
				{
					r_SetConstantBuffer_String_GraphicsBuffer_Int32_Int32 = new(this, "SetConstantBuffer", 0, typeof(System.String), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
					r_SetConstantBuffer_String_GraphicsBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_SetConstantBuffer_String_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetConstantBuffer(Int32, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_SetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32;
		public virtual RMethod RSetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_SetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32 == null)
				{
					r_SetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32 = new(this, "SetConstantBuffer", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
					r_SetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_SetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetFloatArray(System.String, System.Collections.Generic.List`1[System.Single])
		/// </summary>
		protected RMethod r_SetFloatArray_String_List_d_Single_p_;
		public virtual RMethod RSetFloatArray_String_List_d_Single_p_
		{
			get
			{
				if(r_SetFloatArray_String_List_d_Single_p_ == null)
				{
					r_SetFloatArray_String_List_d_Single_p_ = new(this, "SetFloatArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Single)));
					r_SetFloatArray_String_List_d_Single_p_.SetBelong(this.instance);
				}
				return r_SetFloatArray_String_List_d_Single_p_;
			}
		}

		/// <summary>
		/// Void SetFloatArray(Int32, System.Collections.Generic.List`1[System.Single])
		/// </summary>
		protected RMethod r_SetFloatArray_Int32_List_d_Single_p_;
		public virtual RMethod RSetFloatArray_Int32_List_d_Single_p_
		{
			get
			{
				if(r_SetFloatArray_Int32_List_d_Single_p_ == null)
				{
					r_SetFloatArray_Int32_List_d_Single_p_ = new(this, "SetFloatArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Single)));
					r_SetFloatArray_Int32_List_d_Single_p_.SetBelong(this.instance);
				}
				return r_SetFloatArray_Int32_List_d_Single_p_;
			}
		}

		/// <summary>
		/// Void SetFloatArray(System.String, Single[])
		/// </summary>
		protected RMethod r_SetFloatArray_String_SingleArray;
		public virtual RMethod RSetFloatArray_String_SingleArray
		{
			get
			{
				if(r_SetFloatArray_String_SingleArray == null)
				{
					r_SetFloatArray_String_SingleArray = new(this, "SetFloatArray", 0, typeof(System.String), typeof(System.Single).MakeArrayType());
					r_SetFloatArray_String_SingleArray.SetBelong(this.instance);
				}
				return r_SetFloatArray_String_SingleArray;
			}
		}

		/// <summary>
		/// Void SetFloatArray(Int32, Single[])
		/// </summary>
		protected RMethod r_SetFloatArray_Int32_SingleArray;
		public virtual RMethod RSetFloatArray_Int32_SingleArray
		{
			get
			{
				if(r_SetFloatArray_Int32_SingleArray == null)
				{
					r_SetFloatArray_Int32_SingleArray = new(this, "SetFloatArray", 0, typeof(System.Int32), typeof(System.Single).MakeArrayType());
					r_SetFloatArray_Int32_SingleArray.SetBelong(this.instance);
				}
				return r_SetFloatArray_Int32_SingleArray;
			}
		}

		/// <summary>
		/// Void SetVectorArray(System.String, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_SetVectorArray_String_List_d_Vector4_p_;
		public virtual RMethod RSetVectorArray_String_List_d_Vector4_p_
		{
			get
			{
				if(r_SetVectorArray_String_List_d_Vector4_p_ == null)
				{
					r_SetVectorArray_String_List_d_Vector4_p_ = new(this, "SetVectorArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_SetVectorArray_String_List_d_Vector4_p_.SetBelong(this.instance);
				}
				return r_SetVectorArray_String_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void SetVectorArray(Int32, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_SetVectorArray_Int32_List_d_Vector4_p_;
		public virtual RMethod RSetVectorArray_Int32_List_d_Vector4_p_
		{
			get
			{
				if(r_SetVectorArray_Int32_List_d_Vector4_p_ == null)
				{
					r_SetVectorArray_Int32_List_d_Vector4_p_ = new(this, "SetVectorArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_SetVectorArray_Int32_List_d_Vector4_p_.SetBelong(this.instance);
				}
				return r_SetVectorArray_Int32_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void SetVectorArray(System.String, UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_SetVectorArray_String_Vector4Array;
		public virtual RMethod RSetVectorArray_String_Vector4Array
		{
			get
			{
				if(r_SetVectorArray_String_Vector4Array == null)
				{
					r_SetVectorArray_String_Vector4Array = new(this, "SetVectorArray", 0, typeof(System.String), typeof(UnityEngine.Vector4).MakeArrayType());
					r_SetVectorArray_String_Vector4Array.SetBelong(this.instance);
				}
				return r_SetVectorArray_String_Vector4Array;
			}
		}

		/// <summary>
		/// Void SetVectorArray(Int32, UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_SetVectorArray_Int32_Vector4Array;
		public virtual RMethod RSetVectorArray_Int32_Vector4Array
		{
			get
			{
				if(r_SetVectorArray_Int32_Vector4Array == null)
				{
					r_SetVectorArray_Int32_Vector4Array = new(this, "SetVectorArray", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType());
					r_SetVectorArray_Int32_Vector4Array.SetBelong(this.instance);
				}
				return r_SetVectorArray_Int32_Vector4Array;
			}
		}

		/// <summary>
		/// Void SetMatrixArray(System.String, System.Collections.Generic.List`1[UnityEngine.Matrix4x4])
		/// </summary>
		protected RMethod r_SetMatrixArray_String_List_d_Matrix4x4_p_;
		public virtual RMethod RSetMatrixArray_String_List_d_Matrix4x4_p_
		{
			get
			{
				if(r_SetMatrixArray_String_List_d_Matrix4x4_p_ == null)
				{
					r_SetMatrixArray_String_List_d_Matrix4x4_p_ = new(this, "SetMatrixArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Matrix4x4)));
					r_SetMatrixArray_String_List_d_Matrix4x4_p_.SetBelong(this.instance);
				}
				return r_SetMatrixArray_String_List_d_Matrix4x4_p_;
			}
		}

		/// <summary>
		/// Void SetMatrixArray(Int32, System.Collections.Generic.List`1[UnityEngine.Matrix4x4])
		/// </summary>
		protected RMethod r_SetMatrixArray_Int32_List_d_Matrix4x4_p_;
		public virtual RMethod RSetMatrixArray_Int32_List_d_Matrix4x4_p_
		{
			get
			{
				if(r_SetMatrixArray_Int32_List_d_Matrix4x4_p_ == null)
				{
					r_SetMatrixArray_Int32_List_d_Matrix4x4_p_ = new(this, "SetMatrixArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Matrix4x4)));
					r_SetMatrixArray_Int32_List_d_Matrix4x4_p_.SetBelong(this.instance);
				}
				return r_SetMatrixArray_Int32_List_d_Matrix4x4_p_;
			}
		}

		/// <summary>
		/// Void SetMatrixArray(System.String, UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_SetMatrixArray_String_Matrix4x4Array;
		public virtual RMethod RSetMatrixArray_String_Matrix4x4Array
		{
			get
			{
				if(r_SetMatrixArray_String_Matrix4x4Array == null)
				{
					r_SetMatrixArray_String_Matrix4x4Array = new(this, "SetMatrixArray", 0, typeof(System.String), typeof(UnityEngine.Matrix4x4).MakeArrayType());
					r_SetMatrixArray_String_Matrix4x4Array.SetBelong(this.instance);
				}
				return r_SetMatrixArray_String_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Void SetMatrixArray(Int32, UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_SetMatrixArray_Int32_Matrix4x4Array;
		public virtual RMethod RSetMatrixArray_Int32_Matrix4x4Array
		{
			get
			{
				if(r_SetMatrixArray_Int32_Matrix4x4Array == null)
				{
					r_SetMatrixArray_Int32_Matrix4x4Array = new(this, "SetMatrixArray", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType());
					r_SetMatrixArray_Int32_Matrix4x4Array.SetBelong(this.instance);
				}
				return r_SetMatrixArray_Int32_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Boolean HasProperty(System.String)
		/// </summary>
		protected RMethod r_HasProperty_String;
		public virtual RMethod RHasProperty_String
		{
			get
			{
				if(r_HasProperty_String == null)
				{
					r_HasProperty_String = new(this, "HasProperty", 0, typeof(System.String));
					r_HasProperty_String.SetBelong(this.instance);
				}
				return r_HasProperty_String;
			}
		}

		/// <summary>
		/// Boolean HasProperty(Int32)
		/// </summary>
		protected RMethod r_HasProperty_Int32;
		public virtual RMethod RHasProperty_Int32
		{
			get
			{
				if(r_HasProperty_Int32 == null)
				{
					r_HasProperty_Int32 = new(this, "HasProperty", 0, typeof(System.Int32));
					r_HasProperty_Int32.SetBelong(this.instance);
				}
				return r_HasProperty_Int32;
			}
		}

		/// <summary>
		/// Boolean HasInt(System.String)
		/// </summary>
		protected RMethod r_HasInt_String;
		public virtual RMethod RHasInt_String
		{
			get
			{
				if(r_HasInt_String == null)
				{
					r_HasInt_String = new(this, "HasInt", 0, typeof(System.String));
					r_HasInt_String.SetBelong(this.instance);
				}
				return r_HasInt_String;
			}
		}

		/// <summary>
		/// Boolean HasInt(Int32)
		/// </summary>
		protected RMethod r_HasInt_Int32;
		public virtual RMethod RHasInt_Int32
		{
			get
			{
				if(r_HasInt_Int32 == null)
				{
					r_HasInt_Int32 = new(this, "HasInt", 0, typeof(System.Int32));
					r_HasInt_Int32.SetBelong(this.instance);
				}
				return r_HasInt_Int32;
			}
		}

		/// <summary>
		/// Boolean HasFloat(System.String)
		/// </summary>
		protected RMethod r_HasFloat_String;
		public virtual RMethod RHasFloat_String
		{
			get
			{
				if(r_HasFloat_String == null)
				{
					r_HasFloat_String = new(this, "HasFloat", 0, typeof(System.String));
					r_HasFloat_String.SetBelong(this.instance);
				}
				return r_HasFloat_String;
			}
		}

		/// <summary>
		/// Boolean HasFloat(Int32)
		/// </summary>
		protected RMethod r_HasFloat_Int32;
		public virtual RMethod RHasFloat_Int32
		{
			get
			{
				if(r_HasFloat_Int32 == null)
				{
					r_HasFloat_Int32 = new(this, "HasFloat", 0, typeof(System.Int32));
					r_HasFloat_Int32.SetBelong(this.instance);
				}
				return r_HasFloat_Int32;
			}
		}

		/// <summary>
		/// Boolean HasInteger(System.String)
		/// </summary>
		protected RMethod r_HasInteger_String;
		public virtual RMethod RHasInteger_String
		{
			get
			{
				if(r_HasInteger_String == null)
				{
					r_HasInteger_String = new(this, "HasInteger", 0, typeof(System.String));
					r_HasInteger_String.SetBelong(this.instance);
				}
				return r_HasInteger_String;
			}
		}

		/// <summary>
		/// Boolean HasInteger(Int32)
		/// </summary>
		protected RMethod r_HasInteger_Int32;
		public virtual RMethod RHasInteger_Int32
		{
			get
			{
				if(r_HasInteger_Int32 == null)
				{
					r_HasInteger_Int32 = new(this, "HasInteger", 0, typeof(System.Int32));
					r_HasInteger_Int32.SetBelong(this.instance);
				}
				return r_HasInteger_Int32;
			}
		}

		/// <summary>
		/// Boolean HasTexture(System.String)
		/// </summary>
		protected RMethod r_HasTexture_String;
		public virtual RMethod RHasTexture_String
		{
			get
			{
				if(r_HasTexture_String == null)
				{
					r_HasTexture_String = new(this, "HasTexture", 0, typeof(System.String));
					r_HasTexture_String.SetBelong(this.instance);
				}
				return r_HasTexture_String;
			}
		}

		/// <summary>
		/// Boolean HasTexture(Int32)
		/// </summary>
		protected RMethod r_HasTexture_Int32;
		public virtual RMethod RHasTexture_Int32
		{
			get
			{
				if(r_HasTexture_Int32 == null)
				{
					r_HasTexture_Int32 = new(this, "HasTexture", 0, typeof(System.Int32));
					r_HasTexture_Int32.SetBelong(this.instance);
				}
				return r_HasTexture_Int32;
			}
		}

		/// <summary>
		/// Boolean HasMatrix(System.String)
		/// </summary>
		protected RMethod r_HasMatrix_String;
		public virtual RMethod RHasMatrix_String
		{
			get
			{
				if(r_HasMatrix_String == null)
				{
					r_HasMatrix_String = new(this, "HasMatrix", 0, typeof(System.String));
					r_HasMatrix_String.SetBelong(this.instance);
				}
				return r_HasMatrix_String;
			}
		}

		/// <summary>
		/// Boolean HasMatrix(Int32)
		/// </summary>
		protected RMethod r_HasMatrix_Int32;
		public virtual RMethod RHasMatrix_Int32
		{
			get
			{
				if(r_HasMatrix_Int32 == null)
				{
					r_HasMatrix_Int32 = new(this, "HasMatrix", 0, typeof(System.Int32));
					r_HasMatrix_Int32.SetBelong(this.instance);
				}
				return r_HasMatrix_Int32;
			}
		}

		/// <summary>
		/// Boolean HasVector(System.String)
		/// </summary>
		protected RMethod r_HasVector_String;
		public virtual RMethod RHasVector_String
		{
			get
			{
				if(r_HasVector_String == null)
				{
					r_HasVector_String = new(this, "HasVector", 0, typeof(System.String));
					r_HasVector_String.SetBelong(this.instance);
				}
				return r_HasVector_String;
			}
		}

		/// <summary>
		/// Boolean HasVector(Int32)
		/// </summary>
		protected RMethod r_HasVector_Int32;
		public virtual RMethod RHasVector_Int32
		{
			get
			{
				if(r_HasVector_Int32 == null)
				{
					r_HasVector_Int32 = new(this, "HasVector", 0, typeof(System.Int32));
					r_HasVector_Int32.SetBelong(this.instance);
				}
				return r_HasVector_Int32;
			}
		}

		/// <summary>
		/// Boolean HasColor(System.String)
		/// </summary>
		protected RMethod r_HasColor_String;
		public virtual RMethod RHasColor_String
		{
			get
			{
				if(r_HasColor_String == null)
				{
					r_HasColor_String = new(this, "HasColor", 0, typeof(System.String));
					r_HasColor_String.SetBelong(this.instance);
				}
				return r_HasColor_String;
			}
		}

		/// <summary>
		/// Boolean HasColor(Int32)
		/// </summary>
		protected RMethod r_HasColor_Int32;
		public virtual RMethod RHasColor_Int32
		{
			get
			{
				if(r_HasColor_Int32 == null)
				{
					r_HasColor_Int32 = new(this, "HasColor", 0, typeof(System.Int32));
					r_HasColor_Int32.SetBelong(this.instance);
				}
				return r_HasColor_Int32;
			}
		}

		/// <summary>
		/// Boolean HasBuffer(System.String)
		/// </summary>
		protected RMethod r_HasBuffer_String;
		public virtual RMethod RHasBuffer_String
		{
			get
			{
				if(r_HasBuffer_String == null)
				{
					r_HasBuffer_String = new(this, "HasBuffer", 0, typeof(System.String));
					r_HasBuffer_String.SetBelong(this.instance);
				}
				return r_HasBuffer_String;
			}
		}

		/// <summary>
		/// Boolean HasBuffer(Int32)
		/// </summary>
		protected RMethod r_HasBuffer_Int32;
		public virtual RMethod RHasBuffer_Int32
		{
			get
			{
				if(r_HasBuffer_Int32 == null)
				{
					r_HasBuffer_Int32 = new(this, "HasBuffer", 0, typeof(System.Int32));
					r_HasBuffer_Int32.SetBelong(this.instance);
				}
				return r_HasBuffer_Int32;
			}
		}

		/// <summary>
		/// Boolean HasConstantBuffer(System.String)
		/// </summary>
		protected RMethod r_HasConstantBuffer_String;
		public virtual RMethod RHasConstantBuffer_String
		{
			get
			{
				if(r_HasConstantBuffer_String == null)
				{
					r_HasConstantBuffer_String = new(this, "HasConstantBuffer", 0, typeof(System.String));
					r_HasConstantBuffer_String.SetBelong(this.instance);
				}
				return r_HasConstantBuffer_String;
			}
		}

		/// <summary>
		/// Boolean HasConstantBuffer(Int32)
		/// </summary>
		protected RMethod r_HasConstantBuffer_Int32;
		public virtual RMethod RHasConstantBuffer_Int32
		{
			get
			{
				if(r_HasConstantBuffer_Int32 == null)
				{
					r_HasConstantBuffer_Int32 = new(this, "HasConstantBuffer", 0, typeof(System.Int32));
					r_HasConstantBuffer_Int32.SetBelong(this.instance);
				}
				return r_HasConstantBuffer_Int32;
			}
		}

		/// <summary>
		/// Single GetFloat(System.String)
		/// </summary>
		protected RMethod r_GetFloat_String;
		public virtual RMethod RGetFloat_String
		{
			get
			{
				if(r_GetFloat_String == null)
				{
					r_GetFloat_String = new(this, "GetFloat", 0, typeof(System.String));
					r_GetFloat_String.SetBelong(this.instance);
				}
				return r_GetFloat_String;
			}
		}

		/// <summary>
		/// Single GetFloat(Int32)
		/// </summary>
		protected RMethod r_GetFloat_Int32;
		public virtual RMethod RGetFloat_Int32
		{
			get
			{
				if(r_GetFloat_Int32 == null)
				{
					r_GetFloat_Int32 = new(this, "GetFloat", 0, typeof(System.Int32));
					r_GetFloat_Int32.SetBelong(this.instance);
				}
				return r_GetFloat_Int32;
			}
		}

		/// <summary>
		/// Int32 GetInt(System.String)
		/// </summary>
		protected RMethod r_GetInt_String;
		public virtual RMethod RGetInt_String
		{
			get
			{
				if(r_GetInt_String == null)
				{
					r_GetInt_String = new(this, "GetInt", 0, typeof(System.String));
					r_GetInt_String.SetBelong(this.instance);
				}
				return r_GetInt_String;
			}
		}

		/// <summary>
		/// Int32 GetInt(Int32)
		/// </summary>
		protected RMethod r_GetInt_Int32;
		public virtual RMethod RGetInt_Int32
		{
			get
			{
				if(r_GetInt_Int32 == null)
				{
					r_GetInt_Int32 = new(this, "GetInt", 0, typeof(System.Int32));
					r_GetInt_Int32.SetBelong(this.instance);
				}
				return r_GetInt_Int32;
			}
		}

		/// <summary>
		/// Int32 GetInteger(System.String)
		/// </summary>
		protected RMethod r_GetInteger_String;
		public virtual RMethod RGetInteger_String
		{
			get
			{
				if(r_GetInteger_String == null)
				{
					r_GetInteger_String = new(this, "GetInteger", 0, typeof(System.String));
					r_GetInteger_String.SetBelong(this.instance);
				}
				return r_GetInteger_String;
			}
		}

		/// <summary>
		/// Int32 GetInteger(Int32)
		/// </summary>
		protected RMethod r_GetInteger_Int32;
		public virtual RMethod RGetInteger_Int32
		{
			get
			{
				if(r_GetInteger_Int32 == null)
				{
					r_GetInteger_Int32 = new(this, "GetInteger", 0, typeof(System.Int32));
					r_GetInteger_Int32.SetBelong(this.instance);
				}
				return r_GetInteger_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 GetVector(System.String)
		/// </summary>
		protected RMethod r_GetVector_String;
		public virtual RMethod RGetVector_String
		{
			get
			{
				if(r_GetVector_String == null)
				{
					r_GetVector_String = new(this, "GetVector", 0, typeof(System.String));
					r_GetVector_String.SetBelong(this.instance);
				}
				return r_GetVector_String;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 GetVector(Int32)
		/// </summary>
		protected RMethod r_GetVector_Int32;
		public virtual RMethod RGetVector_Int32
		{
			get
			{
				if(r_GetVector_Int32 == null)
				{
					r_GetVector_Int32 = new(this, "GetVector", 0, typeof(System.Int32));
					r_GetVector_Int32.SetBelong(this.instance);
				}
				return r_GetVector_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetColor(System.String)
		/// </summary>
		protected RMethod r_GetColor_String;
		public virtual RMethod RGetColor_String
		{
			get
			{
				if(r_GetColor_String == null)
				{
					r_GetColor_String = new(this, "GetColor", 0, typeof(System.String));
					r_GetColor_String.SetBelong(this.instance);
				}
				return r_GetColor_String;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetColor(Int32)
		/// </summary>
		protected RMethod r_GetColor_Int32;
		public virtual RMethod RGetColor_Int32
		{
			get
			{
				if(r_GetColor_Int32 == null)
				{
					r_GetColor_Int32 = new(this, "GetColor", 0, typeof(System.Int32));
					r_GetColor_Int32.SetBelong(this.instance);
				}
				return r_GetColor_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 GetMatrix(System.String)
		/// </summary>
		protected RMethod r_GetMatrix_String;
		public virtual RMethod RGetMatrix_String
		{
			get
			{
				if(r_GetMatrix_String == null)
				{
					r_GetMatrix_String = new(this, "GetMatrix", 0, typeof(System.String));
					r_GetMatrix_String.SetBelong(this.instance);
				}
				return r_GetMatrix_String;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 GetMatrix(Int32)
		/// </summary>
		protected RMethod r_GetMatrix_Int32;
		public virtual RMethod RGetMatrix_Int32
		{
			get
			{
				if(r_GetMatrix_Int32 == null)
				{
					r_GetMatrix_Int32 = new(this, "GetMatrix", 0, typeof(System.Int32));
					r_GetMatrix_Int32.SetBelong(this.instance);
				}
				return r_GetMatrix_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Texture GetTexture(System.String)
		/// </summary>
		protected RMethod r_GetTexture_String;
		public virtual RMethod RGetTexture_String
		{
			get
			{
				if(r_GetTexture_String == null)
				{
					r_GetTexture_String = new(this, "GetTexture", 0, typeof(System.String));
					r_GetTexture_String.SetBelong(this.instance);
				}
				return r_GetTexture_String;
			}
		}

		/// <summary>
		/// UnityEngine.Texture GetTexture(Int32)
		/// </summary>
		protected RMethod r_GetTexture_Int32;
		public virtual RMethod RGetTexture_Int32
		{
			get
			{
				if(r_GetTexture_Int32 == null)
				{
					r_GetTexture_Int32 = new(this, "GetTexture", 0, typeof(System.Int32));
					r_GetTexture_Int32.SetBelong(this.instance);
				}
				return r_GetTexture_Int32;
			}
		}

		/// <summary>
		/// Single[] GetFloatArray(System.String)
		/// </summary>
		protected RMethod r_GetFloatArray_String;
		public virtual RMethod RGetFloatArray_String
		{
			get
			{
				if(r_GetFloatArray_String == null)
				{
					r_GetFloatArray_String = new(this, "GetFloatArray", 0, typeof(System.String));
					r_GetFloatArray_String.SetBelong(this.instance);
				}
				return r_GetFloatArray_String;
			}
		}

		/// <summary>
		/// Single[] GetFloatArray(Int32)
		/// </summary>
		protected RMethod r_GetFloatArray_Int32;
		public virtual RMethod RGetFloatArray_Int32
		{
			get
			{
				if(r_GetFloatArray_Int32 == null)
				{
					r_GetFloatArray_Int32 = new(this, "GetFloatArray", 0, typeof(System.Int32));
					r_GetFloatArray_Int32.SetBelong(this.instance);
				}
				return r_GetFloatArray_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4[] GetVectorArray(System.String)
		/// </summary>
		protected RMethod r_GetVectorArray_String;
		public virtual RMethod RGetVectorArray_String
		{
			get
			{
				if(r_GetVectorArray_String == null)
				{
					r_GetVectorArray_String = new(this, "GetVectorArray", 0, typeof(System.String));
					r_GetVectorArray_String.SetBelong(this.instance);
				}
				return r_GetVectorArray_String;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4[] GetVectorArray(Int32)
		/// </summary>
		protected RMethod r_GetVectorArray_Int32;
		public virtual RMethod RGetVectorArray_Int32
		{
			get
			{
				if(r_GetVectorArray_Int32 == null)
				{
					r_GetVectorArray_Int32 = new(this, "GetVectorArray", 0, typeof(System.Int32));
					r_GetVectorArray_Int32.SetBelong(this.instance);
				}
				return r_GetVectorArray_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4[] GetMatrixArray(System.String)
		/// </summary>
		protected RMethod r_GetMatrixArray_String;
		public virtual RMethod RGetMatrixArray_String
		{
			get
			{
				if(r_GetMatrixArray_String == null)
				{
					r_GetMatrixArray_String = new(this, "GetMatrixArray", 0, typeof(System.String));
					r_GetMatrixArray_String.SetBelong(this.instance);
				}
				return r_GetMatrixArray_String;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4[] GetMatrixArray(Int32)
		/// </summary>
		protected RMethod r_GetMatrixArray_Int32;
		public virtual RMethod RGetMatrixArray_Int32
		{
			get
			{
				if(r_GetMatrixArray_Int32 == null)
				{
					r_GetMatrixArray_Int32 = new(this, "GetMatrixArray", 0, typeof(System.Int32));
					r_GetMatrixArray_Int32.SetBelong(this.instance);
				}
				return r_GetMatrixArray_Int32;
			}
		}

		/// <summary>
		/// Void GetFloatArray(System.String, System.Collections.Generic.List`1[System.Single])
		/// </summary>
		protected RMethod r_GetFloatArray_String_List_d_Single_p_;
		public virtual RMethod RGetFloatArray_String_List_d_Single_p_
		{
			get
			{
				if(r_GetFloatArray_String_List_d_Single_p_ == null)
				{
					r_GetFloatArray_String_List_d_Single_p_ = new(this, "GetFloatArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Single)));
					r_GetFloatArray_String_List_d_Single_p_.SetBelong(this.instance);
				}
				return r_GetFloatArray_String_List_d_Single_p_;
			}
		}

		/// <summary>
		/// Void GetFloatArray(Int32, System.Collections.Generic.List`1[System.Single])
		/// </summary>
		protected RMethod r_GetFloatArray_Int32_List_d_Single_p_;
		public virtual RMethod RGetFloatArray_Int32_List_d_Single_p_
		{
			get
			{
				if(r_GetFloatArray_Int32_List_d_Single_p_ == null)
				{
					r_GetFloatArray_Int32_List_d_Single_p_ = new(this, "GetFloatArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Single)));
					r_GetFloatArray_Int32_List_d_Single_p_.SetBelong(this.instance);
				}
				return r_GetFloatArray_Int32_List_d_Single_p_;
			}
		}

		/// <summary>
		/// Void GetVectorArray(System.String, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_GetVectorArray_String_List_d_Vector4_p_;
		public virtual RMethod RGetVectorArray_String_List_d_Vector4_p_
		{
			get
			{
				if(r_GetVectorArray_String_List_d_Vector4_p_ == null)
				{
					r_GetVectorArray_String_List_d_Vector4_p_ = new(this, "GetVectorArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_GetVectorArray_String_List_d_Vector4_p_.SetBelong(this.instance);
				}
				return r_GetVectorArray_String_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void GetVectorArray(Int32, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_GetVectorArray_Int32_List_d_Vector4_p_;
		public virtual RMethod RGetVectorArray_Int32_List_d_Vector4_p_
		{
			get
			{
				if(r_GetVectorArray_Int32_List_d_Vector4_p_ == null)
				{
					r_GetVectorArray_Int32_List_d_Vector4_p_ = new(this, "GetVectorArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_GetVectorArray_Int32_List_d_Vector4_p_.SetBelong(this.instance);
				}
				return r_GetVectorArray_Int32_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void GetMatrixArray(System.String, System.Collections.Generic.List`1[UnityEngine.Matrix4x4])
		/// </summary>
		protected RMethod r_GetMatrixArray_String_List_d_Matrix4x4_p_;
		public virtual RMethod RGetMatrixArray_String_List_d_Matrix4x4_p_
		{
			get
			{
				if(r_GetMatrixArray_String_List_d_Matrix4x4_p_ == null)
				{
					r_GetMatrixArray_String_List_d_Matrix4x4_p_ = new(this, "GetMatrixArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Matrix4x4)));
					r_GetMatrixArray_String_List_d_Matrix4x4_p_.SetBelong(this.instance);
				}
				return r_GetMatrixArray_String_List_d_Matrix4x4_p_;
			}
		}

		/// <summary>
		/// Void GetMatrixArray(Int32, System.Collections.Generic.List`1[UnityEngine.Matrix4x4])
		/// </summary>
		protected RMethod r_GetMatrixArray_Int32_List_d_Matrix4x4_p_;
		public virtual RMethod RGetMatrixArray_Int32_List_d_Matrix4x4_p_
		{
			get
			{
				if(r_GetMatrixArray_Int32_List_d_Matrix4x4_p_ == null)
				{
					r_GetMatrixArray_Int32_List_d_Matrix4x4_p_ = new(this, "GetMatrixArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Matrix4x4)));
					r_GetMatrixArray_Int32_List_d_Matrix4x4_p_.SetBelong(this.instance);
				}
				return r_GetMatrixArray_Int32_List_d_Matrix4x4_p_;
			}
		}

		/// <summary>
		/// Void CopySHCoefficientArraysFrom(System.Collections.Generic.List`1[UnityEngine.Rendering.SphericalHarmonicsL2])
		/// </summary>
		protected RMethod r_CopySHCoefficientArraysFrom_List_d_SphericalHarmonicsL2_p_;
		public virtual RMethod RCopySHCoefficientArraysFrom_List_d_SphericalHarmonicsL2_p_
		{
			get
			{
				if(r_CopySHCoefficientArraysFrom_List_d_SphericalHarmonicsL2_p_ == null)
				{
					r_CopySHCoefficientArraysFrom_List_d_SphericalHarmonicsL2_p_ = new(this, "CopySHCoefficientArraysFrom", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Rendering.SphericalHarmonicsL2)));
					r_CopySHCoefficientArraysFrom_List_d_SphericalHarmonicsL2_p_.SetBelong(this.instance);
				}
				return r_CopySHCoefficientArraysFrom_List_d_SphericalHarmonicsL2_p_;
			}
		}

		/// <summary>
		/// Void CopySHCoefficientArraysFrom(UnityEngine.Rendering.SphericalHarmonicsL2[])
		/// </summary>
		protected RMethod r_CopySHCoefficientArraysFrom_SphericalHarmonicsL2Array;
		public virtual RMethod RCopySHCoefficientArraysFrom_SphericalHarmonicsL2Array
		{
			get
			{
				if(r_CopySHCoefficientArraysFrom_SphericalHarmonicsL2Array == null)
				{
					r_CopySHCoefficientArraysFrom_SphericalHarmonicsL2Array = new(this, "CopySHCoefficientArraysFrom", 0, typeof(UnityEngine.Rendering.SphericalHarmonicsL2).MakeArrayType());
					r_CopySHCoefficientArraysFrom_SphericalHarmonicsL2Array.SetBelong(this.instance);
				}
				return r_CopySHCoefficientArraysFrom_SphericalHarmonicsL2Array;
			}
		}

		/// <summary>
		/// Void CopySHCoefficientArraysFrom(System.Collections.Generic.List`1[UnityEngine.Rendering.SphericalHarmonicsL2], Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_CopySHCoefficientArraysFrom_List_d_SphericalHarmonicsL2_p__Int32_Int32_Int32;
		public virtual RMethod RCopySHCoefficientArraysFrom_List_d_SphericalHarmonicsL2_p__Int32_Int32_Int32
		{
			get
			{
				if(r_CopySHCoefficientArraysFrom_List_d_SphericalHarmonicsL2_p__Int32_Int32_Int32 == null)
				{
					r_CopySHCoefficientArraysFrom_List_d_SphericalHarmonicsL2_p__Int32_Int32_Int32 = new(this, "CopySHCoefficientArraysFrom", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Rendering.SphericalHarmonicsL2)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_CopySHCoefficientArraysFrom_List_d_SphericalHarmonicsL2_p__Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_CopySHCoefficientArraysFrom_List_d_SphericalHarmonicsL2_p__Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void CopySHCoefficientArraysFrom(UnityEngine.Rendering.SphericalHarmonicsL2[], Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_CopySHCoefficientArraysFrom_SphericalHarmonicsL2Array_Int32_Int32_Int32;
		public virtual RMethod RCopySHCoefficientArraysFrom_SphericalHarmonicsL2Array_Int32_Int32_Int32
		{
			get
			{
				if(r_CopySHCoefficientArraysFrom_SphericalHarmonicsL2Array_Int32_Int32_Int32 == null)
				{
					r_CopySHCoefficientArraysFrom_SphericalHarmonicsL2Array_Int32_Int32_Int32 = new(this, "CopySHCoefficientArraysFrom", 0, typeof(UnityEngine.Rendering.SphericalHarmonicsL2).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_CopySHCoefficientArraysFrom_SphericalHarmonicsL2Array_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_CopySHCoefficientArraysFrom_SphericalHarmonicsL2Array_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void CopyProbeOcclusionArrayFrom(System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_CopyProbeOcclusionArrayFrom_List_d_Vector4_p_;
		public virtual RMethod RCopyProbeOcclusionArrayFrom_List_d_Vector4_p_
		{
			get
			{
				if(r_CopyProbeOcclusionArrayFrom_List_d_Vector4_p_ == null)
				{
					r_CopyProbeOcclusionArrayFrom_List_d_Vector4_p_ = new(this, "CopyProbeOcclusionArrayFrom", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_CopyProbeOcclusionArrayFrom_List_d_Vector4_p_.SetBelong(this.instance);
				}
				return r_CopyProbeOcclusionArrayFrom_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void CopyProbeOcclusionArrayFrom(UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_CopyProbeOcclusionArrayFrom_Vector4Array;
		public virtual RMethod RCopyProbeOcclusionArrayFrom_Vector4Array
		{
			get
			{
				if(r_CopyProbeOcclusionArrayFrom_Vector4Array == null)
				{
					r_CopyProbeOcclusionArrayFrom_Vector4Array = new(this, "CopyProbeOcclusionArrayFrom", 0, typeof(UnityEngine.Vector4).MakeArrayType());
					r_CopyProbeOcclusionArrayFrom_Vector4Array.SetBelong(this.instance);
				}
				return r_CopyProbeOcclusionArrayFrom_Vector4Array;
			}
		}

		/// <summary>
		/// Void CopyProbeOcclusionArrayFrom(System.Collections.Generic.List`1[UnityEngine.Vector4], Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_CopyProbeOcclusionArrayFrom_List_d_Vector4_p__Int32_Int32_Int32;
		public virtual RMethod RCopyProbeOcclusionArrayFrom_List_d_Vector4_p__Int32_Int32_Int32
		{
			get
			{
				if(r_CopyProbeOcclusionArrayFrom_List_d_Vector4_p__Int32_Int32_Int32 == null)
				{
					r_CopyProbeOcclusionArrayFrom_List_d_Vector4_p__Int32_Int32_Int32 = new(this, "CopyProbeOcclusionArrayFrom", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_CopyProbeOcclusionArrayFrom_List_d_Vector4_p__Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_CopyProbeOcclusionArrayFrom_List_d_Vector4_p__Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void CopyProbeOcclusionArrayFrom(UnityEngine.Vector4[], Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_CopyProbeOcclusionArrayFrom_Vector4Array_Int32_Int32_Int32;
		public virtual RMethod RCopyProbeOcclusionArrayFrom_Vector4Array_Int32_Int32_Int32
		{
			get
			{
				if(r_CopyProbeOcclusionArrayFrom_Vector4Array_Int32_Int32_Int32 == null)
				{
					r_CopyProbeOcclusionArrayFrom_Vector4Array_Int32_Int32_Int32 = new(this, "CopyProbeOcclusionArrayFrom", 0, typeof(UnityEngine.Vector4).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_CopyProbeOcclusionArrayFrom_Vector4Array_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_CopyProbeOcclusionArrayFrom_Vector4Array_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void GetVectorImpl_Injected(Int32, UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_GetVectorImpl_Injected_Int32_Out_Vector4;
		public virtual RMethod RGetVectorImpl_Injected_Int32_Out_Vector4
		{
			get
			{
				if(r_GetVectorImpl_Injected_Int32_Out_Vector4 == null)
				{
					r_GetVectorImpl_Injected_Int32_Out_Vector4 = new(this, "GetVectorImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeByRefType());
					r_GetVectorImpl_Injected_Int32_Out_Vector4.SetBelong(this.instance);
				}
				return r_GetVectorImpl_Injected_Int32_Out_Vector4;
			}
		}

		/// <summary>
		/// Void GetColorImpl_Injected(Int32, UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_GetColorImpl_Injected_Int32_Out_Color;
		public virtual RMethod RGetColorImpl_Injected_Int32_Out_Color
		{
			get
			{
				if(r_GetColorImpl_Injected_Int32_Out_Color == null)
				{
					r_GetColorImpl_Injected_Int32_Out_Color = new(this, "GetColorImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Color).MakeByRefType());
					r_GetColorImpl_Injected_Int32_Out_Color.SetBelong(this.instance);
				}
				return r_GetColorImpl_Injected_Int32_Out_Color;
			}
		}

		/// <summary>
		/// Void GetMatrixImpl_Injected(Int32, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_GetMatrixImpl_Injected_Int32_Out_Matrix4x4;
		public virtual RMethod RGetMatrixImpl_Injected_Int32_Out_Matrix4x4
		{
			get
			{
				if(r_GetMatrixImpl_Injected_Int32_Out_Matrix4x4 == null)
				{
					r_GetMatrixImpl_Injected_Int32_Out_Matrix4x4 = new(this, "GetMatrixImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_GetMatrixImpl_Injected_Int32_Out_Matrix4x4.SetBelong(this.instance);
				}
				return r_GetMatrixImpl_Injected_Int32_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetVectorImpl_Injected(Int32, UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_SetVectorImpl_Injected_Int32_Ref_Vector4;
		public virtual RMethod RSetVectorImpl_Injected_Int32_Ref_Vector4
		{
			get
			{
				if(r_SetVectorImpl_Injected_Int32_Ref_Vector4 == null)
				{
					r_SetVectorImpl_Injected_Int32_Ref_Vector4 = new(this, "SetVectorImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeByRefType());
					r_SetVectorImpl_Injected_Int32_Ref_Vector4.SetBelong(this.instance);
				}
				return r_SetVectorImpl_Injected_Int32_Ref_Vector4;
			}
		}

		/// <summary>
		/// Void SetColorImpl_Injected(Int32, UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_SetColorImpl_Injected_Int32_Ref_Color;
		public virtual RMethod RSetColorImpl_Injected_Int32_Ref_Color
		{
			get
			{
				if(r_SetColorImpl_Injected_Int32_Ref_Color == null)
				{
					r_SetColorImpl_Injected_Int32_Ref_Color = new(this, "SetColorImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Color).MakeByRefType());
					r_SetColorImpl_Injected_Int32_Ref_Color.SetBelong(this.instance);
				}
				return r_SetColorImpl_Injected_Int32_Ref_Color;
			}
		}

		/// <summary>
		/// Void SetMatrixImpl_Injected(Int32, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_SetMatrixImpl_Injected_Int32_Ref_Matrix4x4;
		public virtual RMethod RSetMatrixImpl_Injected_Int32_Ref_Matrix4x4
		{
			get
			{
				if(r_SetMatrixImpl_Injected_Int32_Ref_Matrix4x4 == null)
				{
					r_SetMatrixImpl_Injected_Int32_Ref_Matrix4x4 = new(this, "SetMatrixImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_SetMatrixImpl_Injected_Int32_Ref_Matrix4x4.SetBelong(this.instance);
				}
				return r_SetMatrixImpl_Injected_Int32_Ref_Matrix4x4;
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

        public virtual void AddFloat(System.String  @name, System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RAddFloat_String_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddFloat(System.Int32  @nameID, System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RAddFloat_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddVector(System.String  @name, UnityEngine.Vector4  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RAddVector_String_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddVector(System.Int32  @nameID, UnityEngine.Vector4  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RAddVector_Int32_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddColor(System.String  @name, UnityEngine.Color  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RAddColor_String_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddColor(System.Int32  @nameID, UnityEngine.Color  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RAddColor_Int32_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddMatrix(System.String  @name, UnityEngine.Matrix4x4  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RAddMatrix_String_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddMatrix(System.Int32  @nameID, UnityEngine.Matrix4x4  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RAddMatrix_Int32_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddTexture(System.String  @name, UnityEngine.Texture  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RAddTexture_String_Texture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddTexture(System.Int32  @nameID, UnityEngine.Texture  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RAddTexture_Int32_Texture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetIntImpl(System.Int32  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetIntImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Single GetFloatImpl(System.Int32  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetFloatImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual UnityEngine.Vector4 GetVectorImpl(System.Int32  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetVectorImpl_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public virtual UnityEngine.Color GetColorImpl(System.Int32  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetColorImpl_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual UnityEngine.Matrix4x4 GetMatrixImpl(System.Int32  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetMatrixImpl_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4)___result;
        }


        public virtual UnityEngine.Texture GetTextureImpl(System.Int32  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetTextureImpl_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture)___result;
        }


        public virtual System.Boolean HasPropertyImpl(System.Int32  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RHasPropertyImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasFloatImpl(System.Int32  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RHasFloatImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasIntImpl(System.Int32  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RHasIntImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasTextureImpl(System.Int32  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RHasTextureImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasMatrixImpl(System.Int32  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RHasMatrixImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasVectorImpl(System.Int32  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RHasVectorImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasBufferImpl(System.Int32  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RHasBufferImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasConstantBufferImpl(System.Int32  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RHasConstantBufferImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetIntImpl(System.Int32  @name, System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetIntImpl_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloatImpl(System.Int32  @name, System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetFloatImpl_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVectorImpl(System.Int32  @name, UnityEngine.Vector4  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetVectorImpl_Int32_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColorImpl(System.Int32  @name, UnityEngine.Color  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetColorImpl_Int32_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrixImpl(System.Int32  @name, UnityEngine.Matrix4x4  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetMatrixImpl_Int32_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTextureImpl(System.Int32  @name, UnityEngine.Texture  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetTextureImpl_Int32_Texture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTextureImpl(System.Int32  @name, UnityEngine.RenderTexture  @value, UnityEngine.Rendering.RenderTextureSubElement  @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value, @element};
            var ___result = RSetRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBufferImpl(System.Int32  @name, UnityEngine.ComputeBuffer  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetBufferImpl_Int32_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGraphicsBufferImpl(System.Int32  @name, UnityEngine.GraphicsBuffer  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetGraphicsBufferImpl_Int32_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantBufferImpl(System.Int32  @name, UnityEngine.ComputeBuffer  @value, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value, @offset, @size};
            var ___result = RSetConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantGraphicsBufferImpl(System.Int32  @name, UnityEngine.GraphicsBuffer  @value, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value, @offset, @size};
            var ___result = RSetConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloatArrayImpl(System.Int32  @name, System.Single[]  @values, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values, @count};
            var ___result = RSetFloatArrayImpl_Int32_SingleArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVectorArrayImpl(System.Int32  @name, UnityEngine.Vector4[]  @values, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values, @count};
            var ___result = RSetVectorArrayImpl_Int32_Vector4Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrixArrayImpl(System.Int32  @name, UnityEngine.Matrix4x4[]  @values, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values, @count};
            var ___result = RSetMatrixArrayImpl_Int32_Matrix4x4Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Single[] GetFloatArrayImpl(System.Int32  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetFloatArrayImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single[])___result;
        }


        public virtual UnityEngine.Vector4[] GetVectorArrayImpl(System.Int32  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetVectorArrayImpl_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4[])___result;
        }


        public virtual UnityEngine.Matrix4x4[] GetMatrixArrayImpl(System.Int32  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetMatrixArrayImpl_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4[])___result;
        }


        public virtual System.Int32 GetFloatArrayCountImpl(System.Int32  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetFloatArrayCountImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetVectorArrayCountImpl(System.Int32  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetVectorArrayCountImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetMatrixArrayCountImpl(System.Int32  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetMatrixArrayCountImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void ExtractFloatArrayImpl(System.Int32  @name, System.Single[]  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RExtractFloatArrayImpl_Int32_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExtractVectorArrayImpl(System.Int32  @name, UnityEngine.Vector4[]  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RExtractVectorArrayImpl_Int32_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExtractMatrixArrayImpl(System.Int32  @name, UnityEngine.Matrix4x4[]  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RExtractMatrixArrayImpl_Int32_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public static void Internal_CopySHCoefficientArraysFrom(UnityEngine.MaterialPropertyBlock  @properties, UnityEngine.Rendering.SphericalHarmonicsL2[]  @lightProbes, System.Int32  @sourceStart, System.Int32  @destStart, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@properties, @lightProbes, @sourceStart, @destStart, @count};
            var ___result = RInternal_CopySHCoefficientArraysFrom_MaterialPropertyBlock_SphericalHarmonicsL2Array_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Internal_CopyProbeOcclusionArrayFrom(UnityEngine.MaterialPropertyBlock  @properties, UnityEngine.Vector4[]  @occlusionProbes, System.Int32  @sourceStart, System.Int32  @destStart, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@properties, @occlusionProbes, @sourceStart, @destStart, @count};
            var ___result = RInternal_CopyProbeOcclusionArrayFrom_MaterialPropertyBlock_Vector4Array_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.IntPtr CreateImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateImpl.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static void DestroyImpl(System.IntPtr  @mpb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mpb};
            var ___result = RDestroyImpl_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear(System.Boolean  @keepMemory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keepMemory};
            var ___result = RClear_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloatArray(System.Int32  @name, System.Single[]  @values, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values, @count};
            var ___result = RSetFloatArray_Int32_SingleArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVectorArray(System.Int32  @name, UnityEngine.Vector4[]  @values, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values, @count};
            var ___result = RSetVectorArray_Int32_Vector4Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrixArray(System.Int32  @name, UnityEngine.Matrix4x4[]  @values, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values, @count};
            var ___result = RSetMatrixArray_Int32_Matrix4x4Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExtractFloatArray(System.Int32  @name, System.Collections.Generic.List<System.Single>  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RExtractFloatArray_Int32_List_d_Single_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExtractVectorArray(System.Int32  @name, System.Collections.Generic.List<UnityEngine.Vector4>  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RExtractVectorArray_Int32_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExtractMatrixArray(System.Int32  @name, System.Collections.Generic.List<UnityEngine.Matrix4x4>  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RExtractMatrixArray_Int32_List_d_Matrix4x4_p_.Invoke(___genericsType, ___parameters);

            
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


        public virtual void SetInt(System.String  @name, System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetInt_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInt(System.Int32  @nameID, System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetInt_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloat(System.String  @name, System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetFloat_String_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloat(System.Int32  @nameID, System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetFloat_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInteger(System.String  @name, System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetInteger_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInteger(System.Int32  @nameID, System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetInteger_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVector(System.String  @name, UnityEngine.Vector4  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetVector_String_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVector(System.Int32  @nameID, UnityEngine.Vector4  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetVector_Int32_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColor(System.String  @name, UnityEngine.Color  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetColor_String_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColor(System.Int32  @nameID, UnityEngine.Color  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetColor_Int32_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrix(System.String  @name, UnityEngine.Matrix4x4  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetMatrix_String_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrix(System.Int32  @nameID, UnityEngine.Matrix4x4  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetMatrix_Int32_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBuffer(System.String  @name, UnityEngine.ComputeBuffer  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetBuffer_String_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBuffer(System.Int32  @nameID, UnityEngine.ComputeBuffer  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetBuffer_Int32_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBuffer(System.String  @name, UnityEngine.GraphicsBuffer  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetBuffer_String_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBuffer(System.Int32  @nameID, UnityEngine.GraphicsBuffer  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetBuffer_Int32_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTexture(System.String  @name, UnityEngine.Texture  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetTexture_String_Texture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTexture(System.Int32  @nameID, UnityEngine.Texture  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetTexture_Int32_Texture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTexture(System.String  @name, UnityEngine.RenderTexture  @value, UnityEngine.Rendering.RenderTextureSubElement  @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value, @element};
            var ___result = RSetTexture_String_RenderTexture_RenderTextureSubElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTexture(System.Int32  @nameID, UnityEngine.RenderTexture  @value, UnityEngine.Rendering.RenderTextureSubElement  @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value, @element};
            var ___result = RSetTexture_Int32_RenderTexture_RenderTextureSubElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantBuffer(System.String  @name, UnityEngine.ComputeBuffer  @value, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value, @offset, @size};
            var ___result = RSetConstantBuffer_String_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantBuffer(System.Int32  @nameID, UnityEngine.ComputeBuffer  @value, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value, @offset, @size};
            var ___result = RSetConstantBuffer_Int32_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantBuffer(System.String  @name, UnityEngine.GraphicsBuffer  @value, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value, @offset, @size};
            var ___result = RSetConstantBuffer_String_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantBuffer(System.Int32  @nameID, UnityEngine.GraphicsBuffer  @value, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value, @offset, @size};
            var ___result = RSetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloatArray(System.String  @name, System.Collections.Generic.List<System.Single>  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RSetFloatArray_String_List_d_Single_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloatArray(System.Int32  @nameID, System.Collections.Generic.List<System.Single>  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetFloatArray_Int32_List_d_Single_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloatArray(System.String  @name, System.Single[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RSetFloatArray_String_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloatArray(System.Int32  @nameID, System.Single[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetFloatArray_Int32_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVectorArray(System.String  @name, System.Collections.Generic.List<UnityEngine.Vector4>  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RSetVectorArray_String_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVectorArray(System.Int32  @nameID, System.Collections.Generic.List<UnityEngine.Vector4>  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetVectorArray_Int32_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVectorArray(System.String  @name, UnityEngine.Vector4[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RSetVectorArray_String_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVectorArray(System.Int32  @nameID, UnityEngine.Vector4[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetVectorArray_Int32_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrixArray(System.String  @name, System.Collections.Generic.List<UnityEngine.Matrix4x4>  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RSetMatrixArray_String_List_d_Matrix4x4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrixArray(System.Int32  @nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4>  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetMatrixArray_Int32_List_d_Matrix4x4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrixArray(System.String  @name, UnityEngine.Matrix4x4[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RSetMatrixArray_String_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrixArray(System.Int32  @nameID, UnityEngine.Matrix4x4[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetMatrixArray_Int32_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasProperty(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RHasProperty_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasProperty(System.Int32  @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RHasProperty_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasInt(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RHasInt_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasInt(System.Int32  @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RHasInt_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasFloat(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RHasFloat_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasFloat(System.Int32  @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RHasFloat_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasInteger(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RHasInteger_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasInteger(System.Int32  @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RHasInteger_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasTexture(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RHasTexture_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasTexture(System.Int32  @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RHasTexture_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasMatrix(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RHasMatrix_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasMatrix(System.Int32  @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RHasMatrix_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasVector(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RHasVector_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasVector(System.Int32  @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RHasVector_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasColor(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RHasColor_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasColor(System.Int32  @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RHasColor_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasBuffer(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RHasBuffer_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasBuffer(System.Int32  @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RHasBuffer_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasConstantBuffer(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RHasConstantBuffer_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasConstantBuffer(System.Int32  @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RHasConstantBuffer_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Single GetFloat(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetFloat_String.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single GetFloat(System.Int32  @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RGetFloat_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Int32 GetInt(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetInt_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetInt(System.Int32  @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RGetInt_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetInteger(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetInteger_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetInteger(System.Int32  @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RGetInteger_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.Vector4 GetVector(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetVector_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public virtual UnityEngine.Vector4 GetVector(System.Int32  @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RGetVector_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public virtual UnityEngine.Color GetColor(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetColor_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual UnityEngine.Color GetColor(System.Int32  @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RGetColor_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual UnityEngine.Matrix4x4 GetMatrix(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetMatrix_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4)___result;
        }


        public virtual UnityEngine.Matrix4x4 GetMatrix(System.Int32  @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RGetMatrix_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4)___result;
        }


        public virtual UnityEngine.Texture GetTexture(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetTexture_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture)___result;
        }


        public virtual UnityEngine.Texture GetTexture(System.Int32  @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RGetTexture_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture)___result;
        }


        public virtual System.Single[] GetFloatArray(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetFloatArray_String.Invoke(___genericsType, ___parameters);

            return (System.Single[])___result;
        }


        public virtual System.Single[] GetFloatArray(System.Int32  @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RGetFloatArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single[])___result;
        }


        public virtual UnityEngine.Vector4[] GetVectorArray(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetVectorArray_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4[])___result;
        }


        public virtual UnityEngine.Vector4[] GetVectorArray(System.Int32  @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RGetVectorArray_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4[])___result;
        }


        public virtual UnityEngine.Matrix4x4[] GetMatrixArray(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetMatrixArray_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4[])___result;
        }


        public virtual UnityEngine.Matrix4x4[] GetMatrixArray(System.Int32  @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RGetMatrixArray_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4[])___result;
        }


        public virtual void GetFloatArray(System.String  @name, System.Collections.Generic.List<System.Single>  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RGetFloatArray_String_List_d_Single_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetFloatArray(System.Int32  @nameID, System.Collections.Generic.List<System.Single>  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RGetFloatArray_Int32_List_d_Single_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetVectorArray(System.String  @name, System.Collections.Generic.List<UnityEngine.Vector4>  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RGetVectorArray_String_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetVectorArray(System.Int32  @nameID, System.Collections.Generic.List<UnityEngine.Vector4>  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RGetVectorArray_Int32_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetMatrixArray(System.String  @name, System.Collections.Generic.List<UnityEngine.Matrix4x4>  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RGetMatrixArray_String_List_d_Matrix4x4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetMatrixArray(System.Int32  @nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4>  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RGetMatrixArray_Int32_List_d_Matrix4x4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopySHCoefficientArraysFrom(System.Collections.Generic.List<UnityEngine.Rendering.SphericalHarmonicsL2>  @lightProbes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lightProbes};
            var ___result = RCopySHCoefficientArraysFrom_List_d_SphericalHarmonicsL2_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopySHCoefficientArraysFrom(UnityEngine.Rendering.SphericalHarmonicsL2[]  @lightProbes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lightProbes};
            var ___result = RCopySHCoefficientArraysFrom_SphericalHarmonicsL2Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopySHCoefficientArraysFrom(System.Collections.Generic.List<UnityEngine.Rendering.SphericalHarmonicsL2>  @lightProbes, System.Int32  @sourceStart, System.Int32  @destStart, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lightProbes, @sourceStart, @destStart, @count};
            var ___result = RCopySHCoefficientArraysFrom_List_d_SphericalHarmonicsL2_p__Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopySHCoefficientArraysFrom(UnityEngine.Rendering.SphericalHarmonicsL2[]  @lightProbes, System.Int32  @sourceStart, System.Int32  @destStart, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lightProbes, @sourceStart, @destStart, @count};
            var ___result = RCopySHCoefficientArraysFrom_SphericalHarmonicsL2Array_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyProbeOcclusionArrayFrom(System.Collections.Generic.List<UnityEngine.Vector4>  @occlusionProbes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@occlusionProbes};
            var ___result = RCopyProbeOcclusionArrayFrom_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyProbeOcclusionArrayFrom(UnityEngine.Vector4[]  @occlusionProbes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@occlusionProbes};
            var ___result = RCopyProbeOcclusionArrayFrom_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyProbeOcclusionArrayFrom(System.Collections.Generic.List<UnityEngine.Vector4>  @occlusionProbes, System.Int32  @sourceStart, System.Int32  @destStart, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@occlusionProbes, @sourceStart, @destStart, @count};
            var ___result = RCopyProbeOcclusionArrayFrom_List_d_Vector4_p__Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyProbeOcclusionArrayFrom(UnityEngine.Vector4[]  @occlusionProbes, System.Int32  @sourceStart, System.Int32  @destStart, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@occlusionProbes, @sourceStart, @destStart, @count};
            var ___result = RCopyProbeOcclusionArrayFrom_Vector4Array_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetVectorImpl_Injected(System.Int32  @name, out UnityEngine.Vector4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @ret};
            var ___result = RGetVectorImpl_Injected_Int32_Out_Vector4.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector4)___parameters[1];

            
        }


        public virtual void GetColorImpl_Injected(System.Int32  @name, out UnityEngine.Color  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @ret};
            var ___result = RGetColorImpl_Injected_Int32_Out_Color.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Color)___parameters[1];

            
        }


        public virtual void GetMatrixImpl_Injected(System.Int32  @name, out UnityEngine.Matrix4x4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @ret};
            var ___result = RGetMatrixImpl_Injected_Int32_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Matrix4x4)___parameters[1];

            
        }


        public virtual void SetVectorImpl_Injected(System.Int32  @name, ref UnityEngine.Vector4  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetVectorImpl_Injected_Int32_Ref_Vector4.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector4)___parameters[1];

            
        }


        public virtual void SetColorImpl_Injected(System.Int32  @name, ref UnityEngine.Color  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetColorImpl_Injected_Int32_Ref_Color.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Color)___parameters[1];

            
        }


        public virtual void SetMatrixImpl_Injected(System.Int32  @name, ref UnityEngine.Matrix4x4  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetMatrixImpl_Injected_Int32_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Matrix4x4)___parameters[1];

            
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
