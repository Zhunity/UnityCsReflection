using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.ComputeShader
	/// </summary>
    public partial class RComputeShader : RMember //
    {

		/// <summary>
		/// UnityEngine.Rendering.LocalKeywordSpace keywordSpace
		/// </summary>
		protected RUnityEngine.RRendering.RLocalKeywordSpace r_keywordSpace;
		public virtual RUnityEngine.RRendering.RLocalKeywordSpace RkeywordSpace
		{
			get
			{
				if(r_keywordSpace == null)
				{
					r_keywordSpace = new(this, "keywordSpace", -1);
					r_keywordSpace.SetBelong(this.instance);
				}
				return r_keywordSpace;
			}
		}

		/// <summary>
		/// System.String[] shaderKeywords
		/// </summary>
		protected RPropertyArray<RProperty> r_shaderKeywords;
		public virtual RPropertyArray<RProperty> RshaderKeywords
		{
			get
			{
				if(r_shaderKeywords == null)
				{
					r_shaderKeywords = new(this, "shaderKeywords", -1);
					r_shaderKeywords.SetBelong(this.instance);
				}
				return r_shaderKeywords;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.LocalKeyword[] enabledKeywords
		/// </summary>
		protected RPropertyArray<RUnityEngine.RRendering.RLocalKeyword> r_enabledKeywords;
		public virtual RPropertyArray<RUnityEngine.RRendering.RLocalKeyword> RenabledKeywords
		{
			get
			{
				if(r_enabledKeywords == null)
				{
					r_enabledKeywords = new(this, "enabledKeywords", -1);
					r_enabledKeywords.SetBelong(this.instance);
				}
				return r_enabledKeywords;
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
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected RProperty r_hideFlags;
		public virtual RProperty RhideFlags
		{
			get
			{
				if(r_hideFlags == null)
				{
					r_hideFlags = new(this, "hideFlags", -1);
					r_hideFlags.SetBelong(this.instance);
				}
				return r_hideFlags;
			}
		}

		/// <summary>
		/// Int32 FindKernel(System.String)
		/// </summary>
		protected RMethod r_FindKernel_String;
		public virtual RMethod RFindKernel_String
		{
			get
			{
				if(r_FindKernel_String == null)
				{
					r_FindKernel_String = new(this, "FindKernel", 0, typeof(System.String));
					r_FindKernel_String.SetBelong(this.instance);
				}
				return r_FindKernel_String;
			}
		}

		/// <summary>
		/// Boolean HasKernel(System.String)
		/// </summary>
		protected RMethod r_HasKernel_String;
		public virtual RMethod RHasKernel_String
		{
			get
			{
				if(r_HasKernel_String == null)
				{
					r_HasKernel_String = new(this, "HasKernel", 0, typeof(System.String));
					r_HasKernel_String.SetBelong(this.instance);
				}
				return r_HasKernel_String;
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
		/// Void SetIntArray(Int32, Int32[])
		/// </summary>
		protected RMethod r_SetIntArray_Int32_Int32Array;
		public virtual RMethod RSetIntArray_Int32_Int32Array
		{
			get
			{
				if(r_SetIntArray_Int32_Int32Array == null)
				{
					r_SetIntArray_Int32_Int32Array = new(this, "SetIntArray", 0, typeof(System.Int32), typeof(System.Int32).MakeArrayType());
					r_SetIntArray_Int32_Int32Array.SetBelong(this.instance);
				}
				return r_SetIntArray_Int32_Int32Array;
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
		/// Void SetTexture(Int32, Int32, UnityEngine.Texture, Int32)
		/// </summary>
		protected RMethod r_SetTexture_Int32_Int32_Texture_Int32;
		public virtual RMethod RSetTexture_Int32_Int32_Texture_Int32
		{
			get
			{
				if(r_SetTexture_Int32_Int32_Texture_Int32 == null)
				{
					r_SetTexture_Int32_Int32_Texture_Int32 = new(this, "SetTexture", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Texture), typeof(System.Int32));
					r_SetTexture_Int32_Int32_Texture_Int32.SetBelong(this.instance);
				}
				return r_SetTexture_Int32_Int32_Texture_Int32;
			}
		}

		/// <summary>
		/// Void SetRenderTexture(Int32, Int32, UnityEngine.RenderTexture, Int32, UnityEngine.Rendering.RenderTextureSubElement)
		/// </summary>
		protected RMethod r_SetRenderTexture_Int32_Int32_RenderTexture_Int32_RenderTextureSubElement;
		public virtual RMethod RSetRenderTexture_Int32_Int32_RenderTexture_Int32_RenderTextureSubElement
		{
			get
			{
				if(r_SetRenderTexture_Int32_Int32_RenderTexture_Int32_RenderTextureSubElement == null)
				{
					r_SetRenderTexture_Int32_Int32_RenderTexture_Int32_RenderTextureSubElement = new(this, "SetRenderTexture", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.RenderTexture), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTextureSubElement));
					r_SetRenderTexture_Int32_Int32_RenderTexture_Int32_RenderTextureSubElement.SetBelong(this.instance);
				}
				return r_SetRenderTexture_Int32_Int32_RenderTexture_Int32_RenderTextureSubElement;
			}
		}

		/// <summary>
		/// Void SetTextureFromGlobal(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_SetTextureFromGlobal_Int32_Int32_Int32;
		public virtual RMethod RSetTextureFromGlobal_Int32_Int32_Int32
		{
			get
			{
				if(r_SetTextureFromGlobal_Int32_Int32_Int32 == null)
				{
					r_SetTextureFromGlobal_Int32_Int32_Int32 = new(this, "SetTextureFromGlobal", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_SetTextureFromGlobal_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_SetTextureFromGlobal_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Internal_SetBuffer(Int32, Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_Internal_SetBuffer_Int32_Int32_ComputeBuffer;
		public virtual RMethod RInternal_SetBuffer_Int32_Int32_ComputeBuffer
		{
			get
			{
				if(r_Internal_SetBuffer_Int32_Int32_ComputeBuffer == null)
				{
					r_Internal_SetBuffer_Int32_Int32_ComputeBuffer = new(this, "Internal_SetBuffer", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
					r_Internal_SetBuffer_Int32_Int32_ComputeBuffer.SetBelong(this.instance);
				}
				return r_Internal_SetBuffer_Int32_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void Internal_SetGraphicsBuffer(Int32, Int32, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_Internal_SetGraphicsBuffer_Int32_Int32_GraphicsBuffer;
		public virtual RMethod RInternal_SetGraphicsBuffer_Int32_Int32_GraphicsBuffer
		{
			get
			{
				if(r_Internal_SetGraphicsBuffer_Int32_Int32_GraphicsBuffer == null)
				{
					r_Internal_SetGraphicsBuffer_Int32_Int32_GraphicsBuffer = new(this, "Internal_SetGraphicsBuffer", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer));
					r_Internal_SetGraphicsBuffer_Int32_Int32_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_Internal_SetGraphicsBuffer_Int32_Int32_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetBuffer(Int32, Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_SetBuffer_Int32_Int32_ComputeBuffer;
		public virtual RMethod RSetBuffer_Int32_Int32_ComputeBuffer
		{
			get
			{
				if(r_SetBuffer_Int32_Int32_ComputeBuffer == null)
				{
					r_SetBuffer_Int32_Int32_ComputeBuffer = new(this, "SetBuffer", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
					r_SetBuffer_Int32_Int32_ComputeBuffer.SetBelong(this.instance);
				}
				return r_SetBuffer_Int32_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetBuffer(Int32, Int32, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_SetBuffer_Int32_Int32_GraphicsBuffer;
		public virtual RMethod RSetBuffer_Int32_Int32_GraphicsBuffer
		{
			get
			{
				if(r_SetBuffer_Int32_Int32_GraphicsBuffer == null)
				{
					r_SetBuffer_Int32_Int32_GraphicsBuffer = new(this, "SetBuffer", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer));
					r_SetBuffer_Int32_Int32_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_SetBuffer_Int32_Int32_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetConstantComputeBuffer(Int32, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_SetConstantComputeBuffer_Int32_ComputeBuffer_Int32_Int32;
		public virtual RMethod RSetConstantComputeBuffer_Int32_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_SetConstantComputeBuffer_Int32_ComputeBuffer_Int32_Int32 == null)
				{
					r_SetConstantComputeBuffer_Int32_ComputeBuffer_Int32_Int32 = new(this, "SetConstantComputeBuffer", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
					r_SetConstantComputeBuffer_Int32_ComputeBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_SetConstantComputeBuffer_Int32_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetConstantGraphicsBuffer(Int32, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_SetConstantGraphicsBuffer_Int32_GraphicsBuffer_Int32_Int32;
		public virtual RMethod RSetConstantGraphicsBuffer_Int32_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_SetConstantGraphicsBuffer_Int32_GraphicsBuffer_Int32_Int32 == null)
				{
					r_SetConstantGraphicsBuffer_Int32_GraphicsBuffer_Int32_Int32 = new(this, "SetConstantGraphicsBuffer", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
					r_SetConstantGraphicsBuffer_Int32_GraphicsBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_SetConstantGraphicsBuffer_Int32_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void GetKernelThreadGroupSizes(Int32, UInt32 ByRef, UInt32 ByRef, UInt32 ByRef)
		/// </summary>
		protected RMethod r_GetKernelThreadGroupSizes_Int32_Out_UInt32_Out_UInt32_Out_UInt32;
		public virtual RMethod RGetKernelThreadGroupSizes_Int32_Out_UInt32_Out_UInt32_Out_UInt32
		{
			get
			{
				if(r_GetKernelThreadGroupSizes_Int32_Out_UInt32_Out_UInt32_Out_UInt32 == null)
				{
					r_GetKernelThreadGroupSizes_Int32_Out_UInt32_Out_UInt32_Out_UInt32 = new(this, "GetKernelThreadGroupSizes", 0, typeof(System.Int32), typeof(System.UInt32).MakeByRefType(), typeof(System.UInt32).MakeByRefType(), typeof(System.UInt32).MakeByRefType());
					r_GetKernelThreadGroupSizes_Int32_Out_UInt32_Out_UInt32_Out_UInt32.SetBelong(this.instance);
				}
				return r_GetKernelThreadGroupSizes_Int32_Out_UInt32_Out_UInt32_Out_UInt32;
			}
		}

		/// <summary>
		/// Void Dispatch(Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_Dispatch_Int32_Int32_Int32_Int32;
		public virtual RMethod RDispatch_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_Dispatch_Int32_Int32_Int32_Int32 == null)
				{
					r_Dispatch_Int32_Int32_Int32_Int32 = new(this, "Dispatch", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_Dispatch_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_Dispatch_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Internal_DispatchIndirect(Int32, UnityEngine.ComputeBuffer, UInt32)
		/// </summary>
		protected RMethod r_Internal_DispatchIndirect_Int32_ComputeBuffer_UInt32;
		public virtual RMethod RInternal_DispatchIndirect_Int32_ComputeBuffer_UInt32
		{
			get
			{
				if(r_Internal_DispatchIndirect_Int32_ComputeBuffer_UInt32 == null)
				{
					r_Internal_DispatchIndirect_Int32_ComputeBuffer_UInt32 = new(this, "Internal_DispatchIndirect", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.UInt32));
					r_Internal_DispatchIndirect_Int32_ComputeBuffer_UInt32.SetBelong(this.instance);
				}
				return r_Internal_DispatchIndirect_Int32_ComputeBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void Internal_DispatchIndirectGraphicsBuffer(Int32, UnityEngine.GraphicsBuffer, UInt32)
		/// </summary>
		protected RMethod r_Internal_DispatchIndirectGraphicsBuffer_Int32_GraphicsBuffer_UInt32;
		public virtual RMethod RInternal_DispatchIndirectGraphicsBuffer_Int32_GraphicsBuffer_UInt32
		{
			get
			{
				if(r_Internal_DispatchIndirectGraphicsBuffer_Int32_GraphicsBuffer_UInt32 == null)
				{
					r_Internal_DispatchIndirectGraphicsBuffer_Int32_GraphicsBuffer_UInt32 = new(this, "Internal_DispatchIndirectGraphicsBuffer", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32));
					r_Internal_DispatchIndirectGraphicsBuffer_Int32_GraphicsBuffer_UInt32.SetBelong(this.instance);
				}
				return r_Internal_DispatchIndirectGraphicsBuffer_Int32_GraphicsBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void EnableKeyword(System.String)
		/// </summary>
		protected RMethod r_EnableKeyword_String;
		public virtual RMethod REnableKeyword_String
		{
			get
			{
				if(r_EnableKeyword_String == null)
				{
					r_EnableKeyword_String = new(this, "EnableKeyword", 0, typeof(System.String));
					r_EnableKeyword_String.SetBelong(this.instance);
				}
				return r_EnableKeyword_String;
			}
		}

		/// <summary>
		/// Void DisableKeyword(System.String)
		/// </summary>
		protected RMethod r_DisableKeyword_String;
		public virtual RMethod RDisableKeyword_String
		{
			get
			{
				if(r_DisableKeyword_String == null)
				{
					r_DisableKeyword_String = new(this, "DisableKeyword", 0, typeof(System.String));
					r_DisableKeyword_String.SetBelong(this.instance);
				}
				return r_DisableKeyword_String;
			}
		}

		/// <summary>
		/// Boolean IsKeywordEnabled(System.String)
		/// </summary>
		protected RMethod r_IsKeywordEnabled_String;
		public virtual RMethod RIsKeywordEnabled_String
		{
			get
			{
				if(r_IsKeywordEnabled_String == null)
				{
					r_IsKeywordEnabled_String = new(this, "IsKeywordEnabled", 0, typeof(System.String));
					r_IsKeywordEnabled_String.SetBelong(this.instance);
				}
				return r_IsKeywordEnabled_String;
			}
		}

		/// <summary>
		/// Void EnableLocalKeyword(UnityEngine.Rendering.LocalKeyword)
		/// </summary>
		protected RMethod r_EnableLocalKeyword_LocalKeyword;
		public virtual RMethod REnableLocalKeyword_LocalKeyword
		{
			get
			{
				if(r_EnableLocalKeyword_LocalKeyword == null)
				{
					r_EnableLocalKeyword_LocalKeyword = new(this, "EnableLocalKeyword", 0, typeof(UnityEngine.Rendering.LocalKeyword));
					r_EnableLocalKeyword_LocalKeyword.SetBelong(this.instance);
				}
				return r_EnableLocalKeyword_LocalKeyword;
			}
		}

		/// <summary>
		/// Void DisableLocalKeyword(UnityEngine.Rendering.LocalKeyword)
		/// </summary>
		protected RMethod r_DisableLocalKeyword_LocalKeyword;
		public virtual RMethod RDisableLocalKeyword_LocalKeyword
		{
			get
			{
				if(r_DisableLocalKeyword_LocalKeyword == null)
				{
					r_DisableLocalKeyword_LocalKeyword = new(this, "DisableLocalKeyword", 0, typeof(UnityEngine.Rendering.LocalKeyword));
					r_DisableLocalKeyword_LocalKeyword.SetBelong(this.instance);
				}
				return r_DisableLocalKeyword_LocalKeyword;
			}
		}

		/// <summary>
		/// Void SetLocalKeyword(UnityEngine.Rendering.LocalKeyword, Boolean)
		/// </summary>
		protected RMethod r_SetLocalKeyword_LocalKeyword_Boolean;
		public virtual RMethod RSetLocalKeyword_LocalKeyword_Boolean
		{
			get
			{
				if(r_SetLocalKeyword_LocalKeyword_Boolean == null)
				{
					r_SetLocalKeyword_LocalKeyword_Boolean = new(this, "SetLocalKeyword", 0, typeof(UnityEngine.Rendering.LocalKeyword), typeof(System.Boolean));
					r_SetLocalKeyword_LocalKeyword_Boolean.SetBelong(this.instance);
				}
				return r_SetLocalKeyword_LocalKeyword_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsLocalKeywordEnabled(UnityEngine.Rendering.LocalKeyword)
		/// </summary>
		protected RMethod r_IsLocalKeywordEnabled_LocalKeyword;
		public virtual RMethod RIsLocalKeywordEnabled_LocalKeyword
		{
			get
			{
				if(r_IsLocalKeywordEnabled_LocalKeyword == null)
				{
					r_IsLocalKeywordEnabled_LocalKeyword = new(this, "IsLocalKeywordEnabled", 0, typeof(UnityEngine.Rendering.LocalKeyword));
					r_IsLocalKeywordEnabled_LocalKeyword.SetBelong(this.instance);
				}
				return r_IsLocalKeywordEnabled_LocalKeyword;
			}
		}

		/// <summary>
		/// Void EnableKeyword(UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_EnableKeyword_In_LocalKeyword;
		public virtual RMethod REnableKeyword_In_LocalKeyword
		{
			get
			{
				if(r_EnableKeyword_In_LocalKeyword == null)
				{
					r_EnableKeyword_In_LocalKeyword = new(this, "EnableKeyword", 0, typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
					r_EnableKeyword_In_LocalKeyword.SetBelong(this.instance);
				}
				return r_EnableKeyword_In_LocalKeyword;
			}
		}

		/// <summary>
		/// Void DisableKeyword(UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_DisableKeyword_In_LocalKeyword;
		public virtual RMethod RDisableKeyword_In_LocalKeyword
		{
			get
			{
				if(r_DisableKeyword_In_LocalKeyword == null)
				{
					r_DisableKeyword_In_LocalKeyword = new(this, "DisableKeyword", 0, typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
					r_DisableKeyword_In_LocalKeyword.SetBelong(this.instance);
				}
				return r_DisableKeyword_In_LocalKeyword;
			}
		}

		/// <summary>
		/// Void SetKeyword(UnityEngine.Rendering.LocalKeyword ByRef, Boolean)
		/// </summary>
		protected RMethod r_SetKeyword_In_LocalKeyword_Boolean;
		public virtual RMethod RSetKeyword_In_LocalKeyword_Boolean
		{
			get
			{
				if(r_SetKeyword_In_LocalKeyword_Boolean == null)
				{
					r_SetKeyword_In_LocalKeyword_Boolean = new(this, "SetKeyword", 0, typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType(), typeof(System.Boolean));
					r_SetKeyword_In_LocalKeyword_Boolean.SetBelong(this.instance);
				}
				return r_SetKeyword_In_LocalKeyword_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsKeywordEnabled(UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_IsKeywordEnabled_In_LocalKeyword;
		public virtual RMethod RIsKeywordEnabled_In_LocalKeyword
		{
			get
			{
				if(r_IsKeywordEnabled_In_LocalKeyword == null)
				{
					r_IsKeywordEnabled_In_LocalKeyword = new(this, "IsKeywordEnabled", 0, typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
					r_IsKeywordEnabled_In_LocalKeyword.SetBelong(this.instance);
				}
				return r_IsKeywordEnabled_In_LocalKeyword;
			}
		}

		/// <summary>
		/// Boolean IsSupported(Int32)
		/// </summary>
		protected RMethod r_IsSupported_Int32;
		public virtual RMethod RIsSupported_Int32
		{
			get
			{
				if(r_IsSupported_Int32 == null)
				{
					r_IsSupported_Int32 = new(this, "IsSupported", 0, typeof(System.Int32));
					r_IsSupported_Int32.SetBelong(this.instance);
				}
				return r_IsSupported_Int32;
			}
		}

		/// <summary>
		/// System.String[] GetShaderKeywords()
		/// </summary>
		protected RMethod r_GetShaderKeywords;
		public virtual RMethod RGetShaderKeywords
		{
			get
			{
				if(r_GetShaderKeywords == null)
				{
					r_GetShaderKeywords = new(this, "GetShaderKeywords", 0);
					r_GetShaderKeywords.SetBelong(this.instance);
				}
				return r_GetShaderKeywords;
			}
		}

		/// <summary>
		/// Void SetShaderKeywords(System.String[])
		/// </summary>
		protected RMethod r_SetShaderKeywords_StringArray;
		public virtual RMethod RSetShaderKeywords_StringArray
		{
			get
			{
				if(r_SetShaderKeywords_StringArray == null)
				{
					r_SetShaderKeywords_StringArray = new(this, "SetShaderKeywords", 0, typeof(System.String).MakeArrayType());
					r_SetShaderKeywords_StringArray.SetBelong(this.instance);
				}
				return r_SetShaderKeywords_StringArray;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.LocalKeyword[] GetEnabledKeywords()
		/// </summary>
		protected RMethod r_GetEnabledKeywords;
		public virtual RMethod RGetEnabledKeywords
		{
			get
			{
				if(r_GetEnabledKeywords == null)
				{
					r_GetEnabledKeywords = new(this, "GetEnabledKeywords", 0);
					r_GetEnabledKeywords.SetBelong(this.instance);
				}
				return r_GetEnabledKeywords;
			}
		}

		/// <summary>
		/// Void SetEnabledKeywords(UnityEngine.Rendering.LocalKeyword[])
		/// </summary>
		protected RMethod r_SetEnabledKeywords_LocalKeywordArray;
		public virtual RMethod RSetEnabledKeywords_LocalKeywordArray
		{
			get
			{
				if(r_SetEnabledKeywords_LocalKeywordArray == null)
				{
					r_SetEnabledKeywords_LocalKeywordArray = new(this, "SetEnabledKeywords", 0, typeof(UnityEngine.Rendering.LocalKeyword).MakeArrayType());
					r_SetEnabledKeywords_LocalKeywordArray.SetBelong(this.instance);
				}
				return r_SetEnabledKeywords_LocalKeywordArray;
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
		/// Void SetFloats(System.String, Single[])
		/// </summary>
		protected RMethod r_SetFloats_String_SingleArray;
		public virtual RMethod RSetFloats_String_SingleArray
		{
			get
			{
				if(r_SetFloats_String_SingleArray == null)
				{
					r_SetFloats_String_SingleArray = new(this, "SetFloats", 0, typeof(System.String), typeof(System.Single).MakeArrayType());
					r_SetFloats_String_SingleArray.SetBelong(this.instance);
				}
				return r_SetFloats_String_SingleArray;
			}
		}

		/// <summary>
		/// Void SetFloats(Int32, Single[])
		/// </summary>
		protected RMethod r_SetFloats_Int32_SingleArray;
		public virtual RMethod RSetFloats_Int32_SingleArray
		{
			get
			{
				if(r_SetFloats_Int32_SingleArray == null)
				{
					r_SetFloats_Int32_SingleArray = new(this, "SetFloats", 0, typeof(System.Int32), typeof(System.Single).MakeArrayType());
					r_SetFloats_Int32_SingleArray.SetBelong(this.instance);
				}
				return r_SetFloats_Int32_SingleArray;
			}
		}

		/// <summary>
		/// Void SetInts(System.String, Int32[])
		/// </summary>
		protected RMethod r_SetInts_String_Int32Array;
		public virtual RMethod RSetInts_String_Int32Array
		{
			get
			{
				if(r_SetInts_String_Int32Array == null)
				{
					r_SetInts_String_Int32Array = new(this, "SetInts", 0, typeof(System.String), typeof(System.Int32).MakeArrayType());
					r_SetInts_String_Int32Array.SetBelong(this.instance);
				}
				return r_SetInts_String_Int32Array;
			}
		}

		/// <summary>
		/// Void SetInts(Int32, Int32[])
		/// </summary>
		protected RMethod r_SetInts_Int32_Int32Array;
		public virtual RMethod RSetInts_Int32_Int32Array
		{
			get
			{
				if(r_SetInts_Int32_Int32Array == null)
				{
					r_SetInts_Int32_Int32Array = new(this, "SetInts", 0, typeof(System.Int32), typeof(System.Int32).MakeArrayType());
					r_SetInts_Int32_Int32Array.SetBelong(this.instance);
				}
				return r_SetInts_Int32_Int32Array;
			}
		}

		/// <summary>
		/// Void SetBool(System.String, Boolean)
		/// </summary>
		protected RMethod r_SetBool_String_Boolean;
		public virtual RMethod RSetBool_String_Boolean
		{
			get
			{
				if(r_SetBool_String_Boolean == null)
				{
					r_SetBool_String_Boolean = new(this, "SetBool", 0, typeof(System.String), typeof(System.Boolean));
					r_SetBool_String_Boolean.SetBelong(this.instance);
				}
				return r_SetBool_String_Boolean;
			}
		}

		/// <summary>
		/// Void SetBool(Int32, Boolean)
		/// </summary>
		protected RMethod r_SetBool_Int32_Boolean;
		public virtual RMethod RSetBool_Int32_Boolean
		{
			get
			{
				if(r_SetBool_Int32_Boolean == null)
				{
					r_SetBool_Int32_Boolean = new(this, "SetBool", 0, typeof(System.Int32), typeof(System.Boolean));
					r_SetBool_Int32_Boolean.SetBelong(this.instance);
				}
				return r_SetBool_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void SetTexture(Int32, Int32, UnityEngine.Texture)
		/// </summary>
		protected RMethod r_SetTexture_Int32_Int32_Texture;
		public virtual RMethod RSetTexture_Int32_Int32_Texture
		{
			get
			{
				if(r_SetTexture_Int32_Int32_Texture == null)
				{
					r_SetTexture_Int32_Int32_Texture = new(this, "SetTexture", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Texture));
					r_SetTexture_Int32_Int32_Texture.SetBelong(this.instance);
				}
				return r_SetTexture_Int32_Int32_Texture;
			}
		}

		/// <summary>
		/// Void SetTexture(Int32, System.String, UnityEngine.Texture)
		/// </summary>
		protected RMethod r_SetTexture_Int32_String_Texture;
		public virtual RMethod RSetTexture_Int32_String_Texture
		{
			get
			{
				if(r_SetTexture_Int32_String_Texture == null)
				{
					r_SetTexture_Int32_String_Texture = new(this, "SetTexture", 0, typeof(System.Int32), typeof(System.String), typeof(UnityEngine.Texture));
					r_SetTexture_Int32_String_Texture.SetBelong(this.instance);
				}
				return r_SetTexture_Int32_String_Texture;
			}
		}

		/// <summary>
		/// Void SetTexture(Int32, System.String, UnityEngine.Texture, Int32)
		/// </summary>
		protected RMethod r_SetTexture_Int32_String_Texture_Int32;
		public virtual RMethod RSetTexture_Int32_String_Texture_Int32
		{
			get
			{
				if(r_SetTexture_Int32_String_Texture_Int32 == null)
				{
					r_SetTexture_Int32_String_Texture_Int32 = new(this, "SetTexture", 0, typeof(System.Int32), typeof(System.String), typeof(UnityEngine.Texture), typeof(System.Int32));
					r_SetTexture_Int32_String_Texture_Int32.SetBelong(this.instance);
				}
				return r_SetTexture_Int32_String_Texture_Int32;
			}
		}

		/// <summary>
		/// Void SetTexture(Int32, Int32, UnityEngine.RenderTexture, Int32, UnityEngine.Rendering.RenderTextureSubElement)
		/// </summary>
		protected RMethod r_SetTexture_Int32_Int32_RenderTexture_Int32_RenderTextureSubElement;
		public virtual RMethod RSetTexture_Int32_Int32_RenderTexture_Int32_RenderTextureSubElement
		{
			get
			{
				if(r_SetTexture_Int32_Int32_RenderTexture_Int32_RenderTextureSubElement == null)
				{
					r_SetTexture_Int32_Int32_RenderTexture_Int32_RenderTextureSubElement = new(this, "SetTexture", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.RenderTexture), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTextureSubElement));
					r_SetTexture_Int32_Int32_RenderTexture_Int32_RenderTextureSubElement.SetBelong(this.instance);
				}
				return r_SetTexture_Int32_Int32_RenderTexture_Int32_RenderTextureSubElement;
			}
		}

		/// <summary>
		/// Void SetTexture(Int32, System.String, UnityEngine.RenderTexture, Int32, UnityEngine.Rendering.RenderTextureSubElement)
		/// </summary>
		protected RMethod r_SetTexture_Int32_String_RenderTexture_Int32_RenderTextureSubElement;
		public virtual RMethod RSetTexture_Int32_String_RenderTexture_Int32_RenderTextureSubElement
		{
			get
			{
				if(r_SetTexture_Int32_String_RenderTexture_Int32_RenderTextureSubElement == null)
				{
					r_SetTexture_Int32_String_RenderTexture_Int32_RenderTextureSubElement = new(this, "SetTexture", 0, typeof(System.Int32), typeof(System.String), typeof(UnityEngine.RenderTexture), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTextureSubElement));
					r_SetTexture_Int32_String_RenderTexture_Int32_RenderTextureSubElement.SetBelong(this.instance);
				}
				return r_SetTexture_Int32_String_RenderTexture_Int32_RenderTextureSubElement;
			}
		}

		/// <summary>
		/// Void SetTextureFromGlobal(Int32, System.String, System.String)
		/// </summary>
		protected RMethod r_SetTextureFromGlobal_Int32_String_String;
		public virtual RMethod RSetTextureFromGlobal_Int32_String_String
		{
			get
			{
				if(r_SetTextureFromGlobal_Int32_String_String == null)
				{
					r_SetTextureFromGlobal_Int32_String_String = new(this, "SetTextureFromGlobal", 0, typeof(System.Int32), typeof(System.String), typeof(System.String));
					r_SetTextureFromGlobal_Int32_String_String.SetBelong(this.instance);
				}
				return r_SetTextureFromGlobal_Int32_String_String;
			}
		}

		/// <summary>
		/// Void SetBuffer(Int32, System.String, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_SetBuffer_Int32_String_ComputeBuffer;
		public virtual RMethod RSetBuffer_Int32_String_ComputeBuffer
		{
			get
			{
				if(r_SetBuffer_Int32_String_ComputeBuffer == null)
				{
					r_SetBuffer_Int32_String_ComputeBuffer = new(this, "SetBuffer", 0, typeof(System.Int32), typeof(System.String), typeof(UnityEngine.ComputeBuffer));
					r_SetBuffer_Int32_String_ComputeBuffer.SetBelong(this.instance);
				}
				return r_SetBuffer_Int32_String_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetBuffer(Int32, System.String, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_SetBuffer_Int32_String_GraphicsBuffer;
		public virtual RMethod RSetBuffer_Int32_String_GraphicsBuffer
		{
			get
			{
				if(r_SetBuffer_Int32_String_GraphicsBuffer == null)
				{
					r_SetBuffer_Int32_String_GraphicsBuffer = new(this, "SetBuffer", 0, typeof(System.Int32), typeof(System.String), typeof(UnityEngine.GraphicsBuffer));
					r_SetBuffer_Int32_String_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_SetBuffer_Int32_String_GraphicsBuffer;
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
		/// Void DispatchIndirect(Int32, UnityEngine.ComputeBuffer, UInt32)
		/// </summary>
		protected RMethod r_DispatchIndirect_Int32_ComputeBuffer_UInt32;
		public virtual RMethod RDispatchIndirect_Int32_ComputeBuffer_UInt32
		{
			get
			{
				if(r_DispatchIndirect_Int32_ComputeBuffer_UInt32 == null)
				{
					r_DispatchIndirect_Int32_ComputeBuffer_UInt32 = new(this, "DispatchIndirect", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.UInt32));
					r_DispatchIndirect_Int32_ComputeBuffer_UInt32.SetBelong(this.instance);
				}
				return r_DispatchIndirect_Int32_ComputeBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void DispatchIndirect(Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_DispatchIndirect_Int32_ComputeBuffer;
		public virtual RMethod RDispatchIndirect_Int32_ComputeBuffer
		{
			get
			{
				if(r_DispatchIndirect_Int32_ComputeBuffer == null)
				{
					r_DispatchIndirect_Int32_ComputeBuffer = new(this, "DispatchIndirect", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
					r_DispatchIndirect_Int32_ComputeBuffer.SetBelong(this.instance);
				}
				return r_DispatchIndirect_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void DispatchIndirect(Int32, UnityEngine.GraphicsBuffer, UInt32)
		/// </summary>
		protected RMethod r_DispatchIndirect_Int32_GraphicsBuffer_UInt32;
		public virtual RMethod RDispatchIndirect_Int32_GraphicsBuffer_UInt32
		{
			get
			{
				if(r_DispatchIndirect_Int32_GraphicsBuffer_UInt32 == null)
				{
					r_DispatchIndirect_Int32_GraphicsBuffer_UInt32 = new(this, "DispatchIndirect", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32));
					r_DispatchIndirect_Int32_GraphicsBuffer_UInt32.SetBelong(this.instance);
				}
				return r_DispatchIndirect_Int32_GraphicsBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void DispatchIndirect(Int32, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_DispatchIndirect_Int32_GraphicsBuffer;
		public virtual RMethod RDispatchIndirect_Int32_GraphicsBuffer
		{
			get
			{
				if(r_DispatchIndirect_Int32_GraphicsBuffer == null)
				{
					r_DispatchIndirect_Int32_GraphicsBuffer = new(this, "DispatchIndirect", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer));
					r_DispatchIndirect_Int32_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_DispatchIndirect_Int32_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetVector_Injected(Int32, UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_SetVector_Injected_Int32_Ref_Vector4;
		public virtual RMethod RSetVector_Injected_Int32_Ref_Vector4
		{
			get
			{
				if(r_SetVector_Injected_Int32_Ref_Vector4 == null)
				{
					r_SetVector_Injected_Int32_Ref_Vector4 = new(this, "SetVector_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeByRefType());
					r_SetVector_Injected_Int32_Ref_Vector4.SetBelong(this.instance);
				}
				return r_SetVector_Injected_Int32_Ref_Vector4;
			}
		}

		/// <summary>
		/// Void SetMatrix_Injected(Int32, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_SetMatrix_Injected_Int32_Ref_Matrix4x4;
		public virtual RMethod RSetMatrix_Injected_Int32_Ref_Matrix4x4
		{
			get
			{
				if(r_SetMatrix_Injected_Int32_Ref_Matrix4x4 == null)
				{
					r_SetMatrix_Injected_Int32_Ref_Matrix4x4 = new(this, "SetMatrix_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_SetMatrix_Injected_Int32_Ref_Matrix4x4.SetBelong(this.instance);
				}
				return r_SetMatrix_Injected_Int32_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Void get_keywordSpace_Injected(UnityEngine.Rendering.LocalKeywordSpace ByRef)
		/// </summary>
		protected RMethod r_get_keywordSpace_Injected_Out_LocalKeywordSpace;
		public virtual RMethod Rget_keywordSpace_Injected_Out_LocalKeywordSpace
		{
			get
			{
				if(r_get_keywordSpace_Injected_Out_LocalKeywordSpace == null)
				{
					r_get_keywordSpace_Injected_Out_LocalKeywordSpace = new(this, "get_keywordSpace_Injected", 0, typeof(UnityEngine.Rendering.LocalKeywordSpace).MakeByRefType());
					r_get_keywordSpace_Injected_Out_LocalKeywordSpace.SetBelong(this.instance);
				}
				return r_get_keywordSpace_Injected_Out_LocalKeywordSpace;
			}
		}

		/// <summary>
		/// Void EnableLocalKeyword_Injected(UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_EnableLocalKeyword_Injected_Ref_LocalKeyword;
		public virtual RMethod REnableLocalKeyword_Injected_Ref_LocalKeyword
		{
			get
			{
				if(r_EnableLocalKeyword_Injected_Ref_LocalKeyword == null)
				{
					r_EnableLocalKeyword_Injected_Ref_LocalKeyword = new(this, "EnableLocalKeyword_Injected", 0, typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
					r_EnableLocalKeyword_Injected_Ref_LocalKeyword.SetBelong(this.instance);
				}
				return r_EnableLocalKeyword_Injected_Ref_LocalKeyword;
			}
		}

		/// <summary>
		/// Void DisableLocalKeyword_Injected(UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_DisableLocalKeyword_Injected_Ref_LocalKeyword;
		public virtual RMethod RDisableLocalKeyword_Injected_Ref_LocalKeyword
		{
			get
			{
				if(r_DisableLocalKeyword_Injected_Ref_LocalKeyword == null)
				{
					r_DisableLocalKeyword_Injected_Ref_LocalKeyword = new(this, "DisableLocalKeyword_Injected", 0, typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
					r_DisableLocalKeyword_Injected_Ref_LocalKeyword.SetBelong(this.instance);
				}
				return r_DisableLocalKeyword_Injected_Ref_LocalKeyword;
			}
		}

		/// <summary>
		/// Void SetLocalKeyword_Injected(UnityEngine.Rendering.LocalKeyword ByRef, Boolean)
		/// </summary>
		protected RMethod r_SetLocalKeyword_Injected_Ref_LocalKeyword_Boolean;
		public virtual RMethod RSetLocalKeyword_Injected_Ref_LocalKeyword_Boolean
		{
			get
			{
				if(r_SetLocalKeyword_Injected_Ref_LocalKeyword_Boolean == null)
				{
					r_SetLocalKeyword_Injected_Ref_LocalKeyword_Boolean = new(this, "SetLocalKeyword_Injected", 0, typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType(), typeof(System.Boolean));
					r_SetLocalKeyword_Injected_Ref_LocalKeyword_Boolean.SetBelong(this.instance);
				}
				return r_SetLocalKeyword_Injected_Ref_LocalKeyword_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsLocalKeywordEnabled_Injected(UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_IsLocalKeywordEnabled_Injected_Ref_LocalKeyword;
		public virtual RMethod RIsLocalKeywordEnabled_Injected_Ref_LocalKeyword
		{
			get
			{
				if(r_IsLocalKeywordEnabled_Injected_Ref_LocalKeyword == null)
				{
					r_IsLocalKeywordEnabled_Injected_Ref_LocalKeyword = new(this, "IsLocalKeywordEnabled_Injected", 0, typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
					r_IsLocalKeywordEnabled_Injected_Ref_LocalKeyword.SetBelong(this.instance);
				}
				return r_IsLocalKeywordEnabled_Injected_Ref_LocalKeyword;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_GetInstanceID;
		public virtual RMethod RGetInstanceID
		{
			get
			{
				if(r_GetInstanceID == null)
				{
					r_GetInstanceID = new(this, "GetInstanceID", 0);
					r_GetInstanceID.SetBelong(this.instance);
				}
				return r_GetInstanceID;
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


        public RComputeShader() : base("UnityEngine.ComputeShader")
        {
        }

        public RComputeShader(System.Object instance) : base("UnityEngine.ComputeShader")
		{
            SetInstance(instance);
		}

        public RComputeShader(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RComputeShader(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int32 FindKernel(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RFindKernel_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean HasKernel(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RHasKernel_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetFloat(System.Int32  @nameID, System.Single  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @val};
            var ___result = RSetFloat_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInt(System.Int32  @nameID, System.Int32  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @val};
            var ___result = RSetInt_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVector(System.Int32  @nameID, UnityEngine.Vector4  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @val};
            var ___result = RSetVector_Int32_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrix(System.Int32  @nameID, UnityEngine.Matrix4x4  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @val};
            var ___result = RSetMatrix_Int32_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloatArray(System.Int32  @nameID, System.Single[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetFloatArray_Int32_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetIntArray(System.Int32  @nameID, System.Int32[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetIntArray_Int32_Int32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVectorArray(System.Int32  @nameID, UnityEngine.Vector4[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetVectorArray_Int32_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrixArray(System.Int32  @nameID, UnityEngine.Matrix4x4[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetMatrixArray_Int32_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTexture(System.Int32  @kernelIndex, System.Int32  @nameID, UnityEngine.Texture  @texture, System.Int32  @mipLevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @nameID, @texture, @mipLevel};
            var ___result = RSetTexture_Int32_Int32_Texture_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTexture(System.Int32  @kernelIndex, System.Int32  @nameID, UnityEngine.RenderTexture  @texture, System.Int32  @mipLevel, UnityEngine.Rendering.RenderTextureSubElement  @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @nameID, @texture, @mipLevel, @element};
            var ___result = RSetRenderTexture_Int32_Int32_RenderTexture_Int32_RenderTextureSubElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTextureFromGlobal(System.Int32  @kernelIndex, System.Int32  @nameID, System.Int32  @globalTextureNameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @nameID, @globalTextureNameID};
            var ___result = RSetTextureFromGlobal_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetBuffer(System.Int32  @kernelIndex, System.Int32  @nameID, UnityEngine.ComputeBuffer  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @nameID, @buffer};
            var ___result = RInternal_SetBuffer_Int32_Int32_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetGraphicsBuffer(System.Int32  @kernelIndex, System.Int32  @nameID, UnityEngine.GraphicsBuffer  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @nameID, @buffer};
            var ___result = RInternal_SetGraphicsBuffer_Int32_Int32_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBuffer(System.Int32  @kernelIndex, System.Int32  @nameID, UnityEngine.ComputeBuffer  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @nameID, @buffer};
            var ___result = RSetBuffer_Int32_Int32_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBuffer(System.Int32  @kernelIndex, System.Int32  @nameID, UnityEngine.GraphicsBuffer  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @nameID, @buffer};
            var ___result = RSetBuffer_Int32_Int32_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantComputeBuffer(System.Int32  @nameID, UnityEngine.ComputeBuffer  @buffer, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @buffer, @offset, @size};
            var ___result = RSetConstantComputeBuffer_Int32_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantGraphicsBuffer(System.Int32  @nameID, UnityEngine.GraphicsBuffer  @buffer, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @buffer, @offset, @size};
            var ___result = RSetConstantGraphicsBuffer_Int32_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetKernelThreadGroupSizes(System.Int32  @kernelIndex, out System.UInt32  @x, out System.UInt32  @y, out System.UInt32  @z)
        {
			x = default;
			y = default;
			z = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @x, @y, @z};
            var ___result = RGetKernelThreadGroupSizes_Int32_Out_UInt32_Out_UInt32_Out_UInt32.Invoke(___genericsType, ___parameters);
			x = (System.UInt32)___parameters[1];
			y = (System.UInt32)___parameters[2];
			z = (System.UInt32)___parameters[3];

            
        }


        public virtual void Dispatch(System.Int32  @kernelIndex, System.Int32  @threadGroupsX, System.Int32  @threadGroupsY, System.Int32  @threadGroupsZ)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @threadGroupsX, @threadGroupsY, @threadGroupsZ};
            var ___result = RDispatch_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DispatchIndirect(System.Int32  @kernelIndex, UnityEngine.ComputeBuffer  @argsBuffer, System.UInt32  @argsOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @argsBuffer, @argsOffset};
            var ___result = RInternal_DispatchIndirect_Int32_ComputeBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DispatchIndirectGraphicsBuffer(System.Int32  @kernelIndex, UnityEngine.GraphicsBuffer  @argsBuffer, System.UInt32  @argsOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @argsBuffer, @argsOffset};
            var ___result = RInternal_DispatchIndirectGraphicsBuffer_Int32_GraphicsBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnableKeyword(System.String  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = REnableKeyword_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DisableKeyword(System.String  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RDisableKeyword_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsKeywordEnabled(System.String  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RIsKeywordEnabled_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void EnableLocalKeyword(UnityEngine.Rendering.LocalKeyword  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = REnableLocalKeyword_LocalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DisableLocalKeyword(UnityEngine.Rendering.LocalKeyword  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RDisableLocalKeyword_LocalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetLocalKeyword(UnityEngine.Rendering.LocalKeyword  @keyword, System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword, @value};
            var ___result = RSetLocalKeyword_LocalKeyword_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsLocalKeywordEnabled(UnityEngine.Rendering.LocalKeyword  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RIsLocalKeywordEnabled_LocalKeyword.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void EnableKeyword(in UnityEngine.Rendering.LocalKeyword  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = REnableKeyword_In_LocalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DisableKeyword(in UnityEngine.Rendering.LocalKeyword  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RDisableKeyword_In_LocalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetKeyword(in UnityEngine.Rendering.LocalKeyword  @keyword, System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword, @value};
            var ___result = RSetKeyword_In_LocalKeyword_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsKeywordEnabled(in UnityEngine.Rendering.LocalKeyword  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RIsKeywordEnabled_In_LocalKeyword.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsSupported(System.Int32  @kernelIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex};
            var ___result = RIsSupported_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String[] GetShaderKeywords()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetShaderKeywords.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual void SetShaderKeywords(System.String[]  @names)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@names};
            var ___result = RSetShaderKeywords_StringArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rendering.LocalKeyword[] GetEnabledKeywords()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnabledKeywords.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.LocalKeyword[])___result;
        }


        public virtual void SetEnabledKeywords(UnityEngine.Rendering.LocalKeyword[]  @keywords)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keywords};
            var ___result = RSetEnabledKeywords_LocalKeywordArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloat(System.String  @name, System.Single  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RSetFloat_String_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInt(System.String  @name, System.Int32  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RSetInt_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVector(System.String  @name, UnityEngine.Vector4  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RSetVector_String_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrix(System.String  @name, UnityEngine.Matrix4x4  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RSetMatrix_String_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVectorArray(System.String  @name, UnityEngine.Vector4[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RSetVectorArray_String_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrixArray(System.String  @name, UnityEngine.Matrix4x4[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RSetMatrixArray_String_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloats(System.String  @name, System.Single[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RSetFloats_String_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloats(System.Int32  @nameID, System.Single[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetFloats_Int32_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInts(System.String  @name, System.Int32[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RSetInts_String_Int32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInts(System.Int32  @nameID, System.Int32[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetInts_Int32_Int32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBool(System.String  @name, System.Boolean  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RSetBool_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBool(System.Int32  @nameID, System.Boolean  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @val};
            var ___result = RSetBool_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTexture(System.Int32  @kernelIndex, System.Int32  @nameID, UnityEngine.Texture  @texture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @nameID, @texture};
            var ___result = RSetTexture_Int32_Int32_Texture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTexture(System.Int32  @kernelIndex, System.String  @name, UnityEngine.Texture  @texture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @name, @texture};
            var ___result = RSetTexture_Int32_String_Texture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTexture(System.Int32  @kernelIndex, System.String  @name, UnityEngine.Texture  @texture, System.Int32  @mipLevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @name, @texture, @mipLevel};
            var ___result = RSetTexture_Int32_String_Texture_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTexture(System.Int32  @kernelIndex, System.Int32  @nameID, UnityEngine.RenderTexture  @texture, System.Int32  @mipLevel, UnityEngine.Rendering.RenderTextureSubElement  @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @nameID, @texture, @mipLevel, @element};
            var ___result = RSetTexture_Int32_Int32_RenderTexture_Int32_RenderTextureSubElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTexture(System.Int32  @kernelIndex, System.String  @name, UnityEngine.RenderTexture  @texture, System.Int32  @mipLevel, UnityEngine.Rendering.RenderTextureSubElement  @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @name, @texture, @mipLevel, @element};
            var ___result = RSetTexture_Int32_String_RenderTexture_Int32_RenderTextureSubElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTextureFromGlobal(System.Int32  @kernelIndex, System.String  @name, System.String  @globalTextureName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @name, @globalTextureName};
            var ___result = RSetTextureFromGlobal_Int32_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBuffer(System.Int32  @kernelIndex, System.String  @name, UnityEngine.ComputeBuffer  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @name, @buffer};
            var ___result = RSetBuffer_Int32_String_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBuffer(System.Int32  @kernelIndex, System.String  @name, UnityEngine.GraphicsBuffer  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @name, @buffer};
            var ___result = RSetBuffer_Int32_String_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantBuffer(System.Int32  @nameID, UnityEngine.ComputeBuffer  @buffer, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @buffer, @offset, @size};
            var ___result = RSetConstantBuffer_Int32_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantBuffer(System.String  @name, UnityEngine.ComputeBuffer  @buffer, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @buffer, @offset, @size};
            var ___result = RSetConstantBuffer_String_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantBuffer(System.Int32  @nameID, UnityEngine.GraphicsBuffer  @buffer, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @buffer, @offset, @size};
            var ___result = RSetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantBuffer(System.String  @name, UnityEngine.GraphicsBuffer  @buffer, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @buffer, @offset, @size};
            var ___result = RSetConstantBuffer_String_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DispatchIndirect(System.Int32  @kernelIndex, UnityEngine.ComputeBuffer  @argsBuffer, System.UInt32  @argsOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @argsBuffer, @argsOffset};
            var ___result = RDispatchIndirect_Int32_ComputeBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DispatchIndirect(System.Int32  @kernelIndex, UnityEngine.ComputeBuffer  @argsBuffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @argsBuffer};
            var ___result = RDispatchIndirect_Int32_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DispatchIndirect(System.Int32  @kernelIndex, UnityEngine.GraphicsBuffer  @argsBuffer, System.UInt32  @argsOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @argsBuffer, @argsOffset};
            var ___result = RDispatchIndirect_Int32_GraphicsBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DispatchIndirect(System.Int32  @kernelIndex, UnityEngine.GraphicsBuffer  @argsBuffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @argsBuffer};
            var ___result = RDispatchIndirect_Int32_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVector_Injected(System.Int32  @nameID, ref UnityEngine.Vector4  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @val};
            var ___result = RSetVector_Injected_Int32_Ref_Vector4.Invoke(___genericsType, ___parameters);
			val = (UnityEngine.Vector4)___parameters[1];

            
        }


        public virtual void SetMatrix_Injected(System.Int32  @nameID, ref UnityEngine.Matrix4x4  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @val};
            var ___result = RSetMatrix_Injected_Int32_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			val = (UnityEngine.Matrix4x4)___parameters[1];

            
        }


        public virtual void get_keywordSpace_Injected(out UnityEngine.Rendering.LocalKeywordSpace  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_keywordSpace_Injected_Out_LocalKeywordSpace.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Rendering.LocalKeywordSpace)___parameters[0];

            
        }


        public virtual void EnableLocalKeyword_Injected(ref UnityEngine.Rendering.LocalKeyword  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = REnableLocalKeyword_Injected_Ref_LocalKeyword.Invoke(___genericsType, ___parameters);
			keyword = (UnityEngine.Rendering.LocalKeyword)___parameters[0];

            
        }


        public virtual void DisableLocalKeyword_Injected(ref UnityEngine.Rendering.LocalKeyword  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RDisableLocalKeyword_Injected_Ref_LocalKeyword.Invoke(___genericsType, ___parameters);
			keyword = (UnityEngine.Rendering.LocalKeyword)___parameters[0];

            
        }


        public virtual void SetLocalKeyword_Injected(ref UnityEngine.Rendering.LocalKeyword  @keyword, System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword, @value};
            var ___result = RSetLocalKeyword_Injected_Ref_LocalKeyword_Boolean.Invoke(___genericsType, ___parameters);
			keyword = (UnityEngine.Rendering.LocalKeyword)___parameters[0];

            
        }


        public virtual System.Boolean IsLocalKeywordEnabled_Injected(ref UnityEngine.Rendering.LocalKeyword  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RIsLocalKeywordEnabled_Injected_Ref_LocalKeyword.Invoke(___genericsType, ___parameters);
			keyword = (UnityEngine.Rendering.LocalKeyword)___parameters[0];

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
