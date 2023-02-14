
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.ComputeShader
	/// </summary>
    public partial class RComputeShader : RMember //
    {

		/// <summary>
		/// UnityEngine.Rendering.LocalKeywordSpace keywordSpace
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRendering.RLocalKeywordSpace r_PkeywordSpace;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRendering.RLocalKeywordSpace RPkeywordSpace
		{
			get
			{
				if(r_PkeywordSpace == null)
				{
					r_PkeywordSpace = new(this, "keywordSpace", -1);
					r_PkeywordSpace.SetBelong(this.instance);
				}
				return r_PkeywordSpace;
			}
		}

		/// <summary>
		/// System.String[] shaderKeywords
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_PshaderKeywords;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPshaderKeywords
		{
			get
			{
				if(r_PshaderKeywords == null)
				{
					r_PshaderKeywords = new(this, "shaderKeywords", -1);
					r_PshaderKeywords.SetBelong(this.instance);
				}
				return r_PshaderKeywords;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.LocalKeyword[] enabledKeywords
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RRendering.RLocalKeyword> r_PenabledKeywords;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RRendering.RLocalKeyword> RPenabledKeywords
		{
			get
			{
				if(r_PenabledKeywords == null)
				{
					r_PenabledKeywords = new(this, "enabledKeywords", -1);
					r_PenabledKeywords.SetBelong(this.instance);
				}
				return r_PenabledKeywords;
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
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RHideFlags r_PhideFlags;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RHideFlags RPhideFlags
		{
			get
			{
				if(r_PhideFlags == null)
				{
					r_PhideFlags = new(this, "hideFlags", -1);
					r_PhideFlags.SetBelong(this.instance);
				}
				return r_PhideFlags;
			}
		}

		/// <summary>
		/// Int32 FindKernel(System.String)
		/// </summary>
		protected RMethod r_MFindKernel_String;
		public virtual RMethod RMFindKernel_String
		{
			get
			{
				if(r_MFindKernel_String == null)
				{
					r_MFindKernel_String = new(this, "FindKernel", 0, typeof(System.String));
					r_MFindKernel_String.SetBelong(this.instance);
				}
				return r_MFindKernel_String;
			}
		}

		/// <summary>
		/// Boolean HasKernel(System.String)
		/// </summary>
		protected RMethod r_MHasKernel_String;
		public virtual RMethod RMHasKernel_String
		{
			get
			{
				if(r_MHasKernel_String == null)
				{
					r_MHasKernel_String = new(this, "HasKernel", 0, typeof(System.String));
					r_MHasKernel_String.SetBelong(this.instance);
				}
				return r_MHasKernel_String;
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
		/// Void SetIntArray(Int32, Int32[])
		/// </summary>
		protected RMethod r_MSetIntArray_Int32_Int32Array;
		public virtual RMethod RMSetIntArray_Int32_Int32Array
		{
			get
			{
				if(r_MSetIntArray_Int32_Int32Array == null)
				{
					r_MSetIntArray_Int32_Int32Array = new(this, "SetIntArray", 0, typeof(System.Int32), typeof(System.Int32).MakeArrayType());
					r_MSetIntArray_Int32_Int32Array.SetBelong(this.instance);
				}
				return r_MSetIntArray_Int32_Int32Array;
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
		/// Void SetTexture(Int32, Int32, UnityEngine.Texture, Int32)
		/// </summary>
		protected RMethod r_MSetTexture_Int32_Int32_Texture_Int32;
		public virtual RMethod RMSetTexture_Int32_Int32_Texture_Int32
		{
			get
			{
				if(r_MSetTexture_Int32_Int32_Texture_Int32 == null)
				{
					r_MSetTexture_Int32_Int32_Texture_Int32 = new(this, "SetTexture", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Texture), typeof(System.Int32));
					r_MSetTexture_Int32_Int32_Texture_Int32.SetBelong(this.instance);
				}
				return r_MSetTexture_Int32_Int32_Texture_Int32;
			}
		}

		/// <summary>
		/// Void SetRenderTexture(Int32, Int32, UnityEngine.RenderTexture, Int32, UnityEngine.Rendering.RenderTextureSubElement)
		/// </summary>
		protected RMethod r_MSetRenderTexture_Int32_Int32_RenderTexture_Int32_RenderTextureSubElement;
		public virtual RMethod RMSetRenderTexture_Int32_Int32_RenderTexture_Int32_RenderTextureSubElement
		{
			get
			{
				if(r_MSetRenderTexture_Int32_Int32_RenderTexture_Int32_RenderTextureSubElement == null)
				{
					r_MSetRenderTexture_Int32_Int32_RenderTexture_Int32_RenderTextureSubElement = new(this, "SetRenderTexture", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.RenderTexture), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTextureSubElement));
					r_MSetRenderTexture_Int32_Int32_RenderTexture_Int32_RenderTextureSubElement.SetBelong(this.instance);
				}
				return r_MSetRenderTexture_Int32_Int32_RenderTexture_Int32_RenderTextureSubElement;
			}
		}

		/// <summary>
		/// Void SetTextureFromGlobal(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetTextureFromGlobal_Int32_Int32_Int32;
		public virtual RMethod RMSetTextureFromGlobal_Int32_Int32_Int32
		{
			get
			{
				if(r_MSetTextureFromGlobal_Int32_Int32_Int32 == null)
				{
					r_MSetTextureFromGlobal_Int32_Int32_Int32 = new(this, "SetTextureFromGlobal", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_MSetTextureFromGlobal_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_MSetTextureFromGlobal_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Internal_SetBuffer(Int32, Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_MInternal_SetBuffer_Int32_Int32_ComputeBuffer;
		public virtual RMethod RMInternal_SetBuffer_Int32_Int32_ComputeBuffer
		{
			get
			{
				if(r_MInternal_SetBuffer_Int32_Int32_ComputeBuffer == null)
				{
					r_MInternal_SetBuffer_Int32_Int32_ComputeBuffer = new(this, "Internal_SetBuffer", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
					r_MInternal_SetBuffer_Int32_Int32_ComputeBuffer.SetBelong(this.instance);
				}
				return r_MInternal_SetBuffer_Int32_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void Internal_SetGraphicsBuffer(Int32, Int32, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_MInternal_SetGraphicsBuffer_Int32_Int32_GraphicsBuffer;
		public virtual RMethod RMInternal_SetGraphicsBuffer_Int32_Int32_GraphicsBuffer
		{
			get
			{
				if(r_MInternal_SetGraphicsBuffer_Int32_Int32_GraphicsBuffer == null)
				{
					r_MInternal_SetGraphicsBuffer_Int32_Int32_GraphicsBuffer = new(this, "Internal_SetGraphicsBuffer", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer));
					r_MInternal_SetGraphicsBuffer_Int32_Int32_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_MInternal_SetGraphicsBuffer_Int32_Int32_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetBuffer(Int32, Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_MSetBuffer_Int32_Int32_ComputeBuffer;
		public virtual RMethod RMSetBuffer_Int32_Int32_ComputeBuffer
		{
			get
			{
				if(r_MSetBuffer_Int32_Int32_ComputeBuffer == null)
				{
					r_MSetBuffer_Int32_Int32_ComputeBuffer = new(this, "SetBuffer", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
					r_MSetBuffer_Int32_Int32_ComputeBuffer.SetBelong(this.instance);
				}
				return r_MSetBuffer_Int32_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetBuffer(Int32, Int32, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_MSetBuffer_Int32_Int32_GraphicsBuffer;
		public virtual RMethod RMSetBuffer_Int32_Int32_GraphicsBuffer
		{
			get
			{
				if(r_MSetBuffer_Int32_Int32_GraphicsBuffer == null)
				{
					r_MSetBuffer_Int32_Int32_GraphicsBuffer = new(this, "SetBuffer", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer));
					r_MSetBuffer_Int32_Int32_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_MSetBuffer_Int32_Int32_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetConstantComputeBuffer(Int32, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetConstantComputeBuffer_Int32_ComputeBuffer_Int32_Int32;
		public virtual RMethod RMSetConstantComputeBuffer_Int32_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_MSetConstantComputeBuffer_Int32_ComputeBuffer_Int32_Int32 == null)
				{
					r_MSetConstantComputeBuffer_Int32_ComputeBuffer_Int32_Int32 = new(this, "SetConstantComputeBuffer", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
					r_MSetConstantComputeBuffer_Int32_ComputeBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_MSetConstantComputeBuffer_Int32_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetConstantGraphicsBuffer(Int32, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetConstantGraphicsBuffer_Int32_GraphicsBuffer_Int32_Int32;
		public virtual RMethod RMSetConstantGraphicsBuffer_Int32_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_MSetConstantGraphicsBuffer_Int32_GraphicsBuffer_Int32_Int32 == null)
				{
					r_MSetConstantGraphicsBuffer_Int32_GraphicsBuffer_Int32_Int32 = new(this, "SetConstantGraphicsBuffer", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
					r_MSetConstantGraphicsBuffer_Int32_GraphicsBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_MSetConstantGraphicsBuffer_Int32_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void GetKernelThreadGroupSizes(Int32, UInt32 ByRef, UInt32 ByRef, UInt32 ByRef)
		/// </summary>
		protected RMethod r_MGetKernelThreadGroupSizes_Int32_Out_UInt32_Out_UInt32_Out_UInt32;
		public virtual RMethod RMGetKernelThreadGroupSizes_Int32_Out_UInt32_Out_UInt32_Out_UInt32
		{
			get
			{
				if(r_MGetKernelThreadGroupSizes_Int32_Out_UInt32_Out_UInt32_Out_UInt32 == null)
				{
					r_MGetKernelThreadGroupSizes_Int32_Out_UInt32_Out_UInt32_Out_UInt32 = new(this, "GetKernelThreadGroupSizes", 0, typeof(System.Int32), typeof(System.UInt32).MakeByRefType(), typeof(System.UInt32).MakeByRefType(), typeof(System.UInt32).MakeByRefType());
					r_MGetKernelThreadGroupSizes_Int32_Out_UInt32_Out_UInt32_Out_UInt32.SetBelong(this.instance);
				}
				return r_MGetKernelThreadGroupSizes_Int32_Out_UInt32_Out_UInt32_Out_UInt32;
			}
		}

		/// <summary>
		/// Void Dispatch(Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MDispatch_Int32_Int32_Int32_Int32;
		public virtual RMethod RMDispatch_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MDispatch_Int32_Int32_Int32_Int32 == null)
				{
					r_MDispatch_Int32_Int32_Int32_Int32 = new(this, "Dispatch", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_MDispatch_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_MDispatch_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Internal_DispatchIndirect(Int32, UnityEngine.ComputeBuffer, UInt32)
		/// </summary>
		protected RMethod r_MInternal_DispatchIndirect_Int32_ComputeBuffer_UInt32;
		public virtual RMethod RMInternal_DispatchIndirect_Int32_ComputeBuffer_UInt32
		{
			get
			{
				if(r_MInternal_DispatchIndirect_Int32_ComputeBuffer_UInt32 == null)
				{
					r_MInternal_DispatchIndirect_Int32_ComputeBuffer_UInt32 = new(this, "Internal_DispatchIndirect", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.UInt32));
					r_MInternal_DispatchIndirect_Int32_ComputeBuffer_UInt32.SetBelong(this.instance);
				}
				return r_MInternal_DispatchIndirect_Int32_ComputeBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void Internal_DispatchIndirectGraphicsBuffer(Int32, UnityEngine.GraphicsBuffer, UInt32)
		/// </summary>
		protected RMethod r_MInternal_DispatchIndirectGraphicsBuffer_Int32_GraphicsBuffer_UInt32;
		public virtual RMethod RMInternal_DispatchIndirectGraphicsBuffer_Int32_GraphicsBuffer_UInt32
		{
			get
			{
				if(r_MInternal_DispatchIndirectGraphicsBuffer_Int32_GraphicsBuffer_UInt32 == null)
				{
					r_MInternal_DispatchIndirectGraphicsBuffer_Int32_GraphicsBuffer_UInt32 = new(this, "Internal_DispatchIndirectGraphicsBuffer", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32));
					r_MInternal_DispatchIndirectGraphicsBuffer_Int32_GraphicsBuffer_UInt32.SetBelong(this.instance);
				}
				return r_MInternal_DispatchIndirectGraphicsBuffer_Int32_GraphicsBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void EnableKeyword(System.String)
		/// </summary>
		protected RMethod r_MEnableKeyword_String;
		public virtual RMethod RMEnableKeyword_String
		{
			get
			{
				if(r_MEnableKeyword_String == null)
				{
					r_MEnableKeyword_String = new(this, "EnableKeyword", 0, typeof(System.String));
					r_MEnableKeyword_String.SetBelong(this.instance);
				}
				return r_MEnableKeyword_String;
			}
		}

		/// <summary>
		/// Void DisableKeyword(System.String)
		/// </summary>
		protected RMethod r_MDisableKeyword_String;
		public virtual RMethod RMDisableKeyword_String
		{
			get
			{
				if(r_MDisableKeyword_String == null)
				{
					r_MDisableKeyword_String = new(this, "DisableKeyword", 0, typeof(System.String));
					r_MDisableKeyword_String.SetBelong(this.instance);
				}
				return r_MDisableKeyword_String;
			}
		}

		/// <summary>
		/// Boolean IsKeywordEnabled(System.String)
		/// </summary>
		protected RMethod r_MIsKeywordEnabled_String;
		public virtual RMethod RMIsKeywordEnabled_String
		{
			get
			{
				if(r_MIsKeywordEnabled_String == null)
				{
					r_MIsKeywordEnabled_String = new(this, "IsKeywordEnabled", 0, typeof(System.String));
					r_MIsKeywordEnabled_String.SetBelong(this.instance);
				}
				return r_MIsKeywordEnabled_String;
			}
		}

		/// <summary>
		/// Void EnableLocalKeyword(UnityEngine.Rendering.LocalKeyword)
		/// </summary>
		protected RMethod r_MEnableLocalKeyword_LocalKeyword;
		public virtual RMethod RMEnableLocalKeyword_LocalKeyword
		{
			get
			{
				if(r_MEnableLocalKeyword_LocalKeyword == null)
				{
					r_MEnableLocalKeyword_LocalKeyword = new(this, "EnableLocalKeyword", 0, typeof(UnityEngine.Rendering.LocalKeyword));
					r_MEnableLocalKeyword_LocalKeyword.SetBelong(this.instance);
				}
				return r_MEnableLocalKeyword_LocalKeyword;
			}
		}

		/// <summary>
		/// Void DisableLocalKeyword(UnityEngine.Rendering.LocalKeyword)
		/// </summary>
		protected RMethod r_MDisableLocalKeyword_LocalKeyword;
		public virtual RMethod RMDisableLocalKeyword_LocalKeyword
		{
			get
			{
				if(r_MDisableLocalKeyword_LocalKeyword == null)
				{
					r_MDisableLocalKeyword_LocalKeyword = new(this, "DisableLocalKeyword", 0, typeof(UnityEngine.Rendering.LocalKeyword));
					r_MDisableLocalKeyword_LocalKeyword.SetBelong(this.instance);
				}
				return r_MDisableLocalKeyword_LocalKeyword;
			}
		}

		/// <summary>
		/// Void SetLocalKeyword(UnityEngine.Rendering.LocalKeyword, Boolean)
		/// </summary>
		protected RMethod r_MSetLocalKeyword_LocalKeyword_Boolean;
		public virtual RMethod RMSetLocalKeyword_LocalKeyword_Boolean
		{
			get
			{
				if(r_MSetLocalKeyword_LocalKeyword_Boolean == null)
				{
					r_MSetLocalKeyword_LocalKeyword_Boolean = new(this, "SetLocalKeyword", 0, typeof(UnityEngine.Rendering.LocalKeyword), typeof(System.Boolean));
					r_MSetLocalKeyword_LocalKeyword_Boolean.SetBelong(this.instance);
				}
				return r_MSetLocalKeyword_LocalKeyword_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsLocalKeywordEnabled(UnityEngine.Rendering.LocalKeyword)
		/// </summary>
		protected RMethod r_MIsLocalKeywordEnabled_LocalKeyword;
		public virtual RMethod RMIsLocalKeywordEnabled_LocalKeyword
		{
			get
			{
				if(r_MIsLocalKeywordEnabled_LocalKeyword == null)
				{
					r_MIsLocalKeywordEnabled_LocalKeyword = new(this, "IsLocalKeywordEnabled", 0, typeof(UnityEngine.Rendering.LocalKeyword));
					r_MIsLocalKeywordEnabled_LocalKeyword.SetBelong(this.instance);
				}
				return r_MIsLocalKeywordEnabled_LocalKeyword;
			}
		}

		/// <summary>
		/// Void EnableKeyword(UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_MEnableKeyword_In_LocalKeyword;
		public virtual RMethod RMEnableKeyword_In_LocalKeyword
		{
			get
			{
				if(r_MEnableKeyword_In_LocalKeyword == null)
				{
					r_MEnableKeyword_In_LocalKeyword = new(this, "EnableKeyword", 0, typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
					r_MEnableKeyword_In_LocalKeyword.SetBelong(this.instance);
				}
				return r_MEnableKeyword_In_LocalKeyword;
			}
		}

		/// <summary>
		/// Void DisableKeyword(UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_MDisableKeyword_In_LocalKeyword;
		public virtual RMethod RMDisableKeyword_In_LocalKeyword
		{
			get
			{
				if(r_MDisableKeyword_In_LocalKeyword == null)
				{
					r_MDisableKeyword_In_LocalKeyword = new(this, "DisableKeyword", 0, typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
					r_MDisableKeyword_In_LocalKeyword.SetBelong(this.instance);
				}
				return r_MDisableKeyword_In_LocalKeyword;
			}
		}

		/// <summary>
		/// Void SetKeyword(UnityEngine.Rendering.LocalKeyword ByRef, Boolean)
		/// </summary>
		protected RMethod r_MSetKeyword_In_LocalKeyword_Boolean;
		public virtual RMethod RMSetKeyword_In_LocalKeyword_Boolean
		{
			get
			{
				if(r_MSetKeyword_In_LocalKeyword_Boolean == null)
				{
					r_MSetKeyword_In_LocalKeyword_Boolean = new(this, "SetKeyword", 0, typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType(), typeof(System.Boolean));
					r_MSetKeyword_In_LocalKeyword_Boolean.SetBelong(this.instance);
				}
				return r_MSetKeyword_In_LocalKeyword_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsKeywordEnabled(UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_MIsKeywordEnabled_In_LocalKeyword;
		public virtual RMethod RMIsKeywordEnabled_In_LocalKeyword
		{
			get
			{
				if(r_MIsKeywordEnabled_In_LocalKeyword == null)
				{
					r_MIsKeywordEnabled_In_LocalKeyword = new(this, "IsKeywordEnabled", 0, typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
					r_MIsKeywordEnabled_In_LocalKeyword.SetBelong(this.instance);
				}
				return r_MIsKeywordEnabled_In_LocalKeyword;
			}
		}

		/// <summary>
		/// Boolean IsSupported(Int32)
		/// </summary>
		protected RMethod r_MIsSupported_Int32;
		public virtual RMethod RMIsSupported_Int32
		{
			get
			{
				if(r_MIsSupported_Int32 == null)
				{
					r_MIsSupported_Int32 = new(this, "IsSupported", 0, typeof(System.Int32));
					r_MIsSupported_Int32.SetBelong(this.instance);
				}
				return r_MIsSupported_Int32;
			}
		}

		/// <summary>
		/// System.String[] GetShaderKeywords()
		/// </summary>
		protected RMethod r_MGetShaderKeywords;
		public virtual RMethod RMGetShaderKeywords
		{
			get
			{
				if(r_MGetShaderKeywords == null)
				{
					r_MGetShaderKeywords = new(this, "GetShaderKeywords", 0);
					r_MGetShaderKeywords.SetBelong(this.instance);
				}
				return r_MGetShaderKeywords;
			}
		}

		/// <summary>
		/// Void SetShaderKeywords(System.String[])
		/// </summary>
		protected RMethod r_MSetShaderKeywords_StringArray;
		public virtual RMethod RMSetShaderKeywords_StringArray
		{
			get
			{
				if(r_MSetShaderKeywords_StringArray == null)
				{
					r_MSetShaderKeywords_StringArray = new(this, "SetShaderKeywords", 0, typeof(System.String).MakeArrayType());
					r_MSetShaderKeywords_StringArray.SetBelong(this.instance);
				}
				return r_MSetShaderKeywords_StringArray;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.LocalKeyword[] GetEnabledKeywords()
		/// </summary>
		protected RMethod r_MGetEnabledKeywords;
		public virtual RMethod RMGetEnabledKeywords
		{
			get
			{
				if(r_MGetEnabledKeywords == null)
				{
					r_MGetEnabledKeywords = new(this, "GetEnabledKeywords", 0);
					r_MGetEnabledKeywords.SetBelong(this.instance);
				}
				return r_MGetEnabledKeywords;
			}
		}

		/// <summary>
		/// Void SetEnabledKeywords(UnityEngine.Rendering.LocalKeyword[])
		/// </summary>
		protected RMethod r_MSetEnabledKeywords_LocalKeywordArray;
		public virtual RMethod RMSetEnabledKeywords_LocalKeywordArray
		{
			get
			{
				if(r_MSetEnabledKeywords_LocalKeywordArray == null)
				{
					r_MSetEnabledKeywords_LocalKeywordArray = new(this, "SetEnabledKeywords", 0, typeof(UnityEngine.Rendering.LocalKeyword).MakeArrayType());
					r_MSetEnabledKeywords_LocalKeywordArray.SetBelong(this.instance);
				}
				return r_MSetEnabledKeywords_LocalKeywordArray;
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
		/// Void SetFloats(System.String, Single[])
		/// </summary>
		protected RMethod r_MSetFloats_String_SingleArray;
		public virtual RMethod RMSetFloats_String_SingleArray
		{
			get
			{
				if(r_MSetFloats_String_SingleArray == null)
				{
					r_MSetFloats_String_SingleArray = new(this, "SetFloats", 0, typeof(System.String), typeof(System.Single).MakeArrayType());
					r_MSetFloats_String_SingleArray.SetBelong(this.instance);
				}
				return r_MSetFloats_String_SingleArray;
			}
		}

		/// <summary>
		/// Void SetFloats(Int32, Single[])
		/// </summary>
		protected RMethod r_MSetFloats_Int32_SingleArray;
		public virtual RMethod RMSetFloats_Int32_SingleArray
		{
			get
			{
				if(r_MSetFloats_Int32_SingleArray == null)
				{
					r_MSetFloats_Int32_SingleArray = new(this, "SetFloats", 0, typeof(System.Int32), typeof(System.Single).MakeArrayType());
					r_MSetFloats_Int32_SingleArray.SetBelong(this.instance);
				}
				return r_MSetFloats_Int32_SingleArray;
			}
		}

		/// <summary>
		/// Void SetInts(System.String, Int32[])
		/// </summary>
		protected RMethod r_MSetInts_String_Int32Array;
		public virtual RMethod RMSetInts_String_Int32Array
		{
			get
			{
				if(r_MSetInts_String_Int32Array == null)
				{
					r_MSetInts_String_Int32Array = new(this, "SetInts", 0, typeof(System.String), typeof(System.Int32).MakeArrayType());
					r_MSetInts_String_Int32Array.SetBelong(this.instance);
				}
				return r_MSetInts_String_Int32Array;
			}
		}

		/// <summary>
		/// Void SetInts(Int32, Int32[])
		/// </summary>
		protected RMethod r_MSetInts_Int32_Int32Array;
		public virtual RMethod RMSetInts_Int32_Int32Array
		{
			get
			{
				if(r_MSetInts_Int32_Int32Array == null)
				{
					r_MSetInts_Int32_Int32Array = new(this, "SetInts", 0, typeof(System.Int32), typeof(System.Int32).MakeArrayType());
					r_MSetInts_Int32_Int32Array.SetBelong(this.instance);
				}
				return r_MSetInts_Int32_Int32Array;
			}
		}

		/// <summary>
		/// Void SetBool(System.String, Boolean)
		/// </summary>
		protected RMethod r_MSetBool_String_Boolean;
		public virtual RMethod RMSetBool_String_Boolean
		{
			get
			{
				if(r_MSetBool_String_Boolean == null)
				{
					r_MSetBool_String_Boolean = new(this, "SetBool", 0, typeof(System.String), typeof(System.Boolean));
					r_MSetBool_String_Boolean.SetBelong(this.instance);
				}
				return r_MSetBool_String_Boolean;
			}
		}

		/// <summary>
		/// Void SetBool(Int32, Boolean)
		/// </summary>
		protected RMethod r_MSetBool_Int32_Boolean;
		public virtual RMethod RMSetBool_Int32_Boolean
		{
			get
			{
				if(r_MSetBool_Int32_Boolean == null)
				{
					r_MSetBool_Int32_Boolean = new(this, "SetBool", 0, typeof(System.Int32), typeof(System.Boolean));
					r_MSetBool_Int32_Boolean.SetBelong(this.instance);
				}
				return r_MSetBool_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void SetTexture(Int32, Int32, UnityEngine.Texture)
		/// </summary>
		protected RMethod r_MSetTexture_Int32_Int32_Texture;
		public virtual RMethod RMSetTexture_Int32_Int32_Texture
		{
			get
			{
				if(r_MSetTexture_Int32_Int32_Texture == null)
				{
					r_MSetTexture_Int32_Int32_Texture = new(this, "SetTexture", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Texture));
					r_MSetTexture_Int32_Int32_Texture.SetBelong(this.instance);
				}
				return r_MSetTexture_Int32_Int32_Texture;
			}
		}

		/// <summary>
		/// Void SetTexture(Int32, System.String, UnityEngine.Texture)
		/// </summary>
		protected RMethod r_MSetTexture_Int32_String_Texture;
		public virtual RMethod RMSetTexture_Int32_String_Texture
		{
			get
			{
				if(r_MSetTexture_Int32_String_Texture == null)
				{
					r_MSetTexture_Int32_String_Texture = new(this, "SetTexture", 0, typeof(System.Int32), typeof(System.String), typeof(UnityEngine.Texture));
					r_MSetTexture_Int32_String_Texture.SetBelong(this.instance);
				}
				return r_MSetTexture_Int32_String_Texture;
			}
		}

		/// <summary>
		/// Void SetTexture(Int32, System.String, UnityEngine.Texture, Int32)
		/// </summary>
		protected RMethod r_MSetTexture_Int32_String_Texture_Int32;
		public virtual RMethod RMSetTexture_Int32_String_Texture_Int32
		{
			get
			{
				if(r_MSetTexture_Int32_String_Texture_Int32 == null)
				{
					r_MSetTexture_Int32_String_Texture_Int32 = new(this, "SetTexture", 0, typeof(System.Int32), typeof(System.String), typeof(UnityEngine.Texture), typeof(System.Int32));
					r_MSetTexture_Int32_String_Texture_Int32.SetBelong(this.instance);
				}
				return r_MSetTexture_Int32_String_Texture_Int32;
			}
		}

		/// <summary>
		/// Void SetTexture(Int32, Int32, UnityEngine.RenderTexture, Int32, UnityEngine.Rendering.RenderTextureSubElement)
		/// </summary>
		protected RMethod r_MSetTexture_Int32_Int32_RenderTexture_Int32_RenderTextureSubElement;
		public virtual RMethod RMSetTexture_Int32_Int32_RenderTexture_Int32_RenderTextureSubElement
		{
			get
			{
				if(r_MSetTexture_Int32_Int32_RenderTexture_Int32_RenderTextureSubElement == null)
				{
					r_MSetTexture_Int32_Int32_RenderTexture_Int32_RenderTextureSubElement = new(this, "SetTexture", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.RenderTexture), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTextureSubElement));
					r_MSetTexture_Int32_Int32_RenderTexture_Int32_RenderTextureSubElement.SetBelong(this.instance);
				}
				return r_MSetTexture_Int32_Int32_RenderTexture_Int32_RenderTextureSubElement;
			}
		}

		/// <summary>
		/// Void SetTexture(Int32, System.String, UnityEngine.RenderTexture, Int32, UnityEngine.Rendering.RenderTextureSubElement)
		/// </summary>
		protected RMethod r_MSetTexture_Int32_String_RenderTexture_Int32_RenderTextureSubElement;
		public virtual RMethod RMSetTexture_Int32_String_RenderTexture_Int32_RenderTextureSubElement
		{
			get
			{
				if(r_MSetTexture_Int32_String_RenderTexture_Int32_RenderTextureSubElement == null)
				{
					r_MSetTexture_Int32_String_RenderTexture_Int32_RenderTextureSubElement = new(this, "SetTexture", 0, typeof(System.Int32), typeof(System.String), typeof(UnityEngine.RenderTexture), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTextureSubElement));
					r_MSetTexture_Int32_String_RenderTexture_Int32_RenderTextureSubElement.SetBelong(this.instance);
				}
				return r_MSetTexture_Int32_String_RenderTexture_Int32_RenderTextureSubElement;
			}
		}

		/// <summary>
		/// Void SetTextureFromGlobal(Int32, System.String, System.String)
		/// </summary>
		protected RMethod r_MSetTextureFromGlobal_Int32_String_String;
		public virtual RMethod RMSetTextureFromGlobal_Int32_String_String
		{
			get
			{
				if(r_MSetTextureFromGlobal_Int32_String_String == null)
				{
					r_MSetTextureFromGlobal_Int32_String_String = new(this, "SetTextureFromGlobal", 0, typeof(System.Int32), typeof(System.String), typeof(System.String));
					r_MSetTextureFromGlobal_Int32_String_String.SetBelong(this.instance);
				}
				return r_MSetTextureFromGlobal_Int32_String_String;
			}
		}

		/// <summary>
		/// Void SetBuffer(Int32, System.String, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_MSetBuffer_Int32_String_ComputeBuffer;
		public virtual RMethod RMSetBuffer_Int32_String_ComputeBuffer
		{
			get
			{
				if(r_MSetBuffer_Int32_String_ComputeBuffer == null)
				{
					r_MSetBuffer_Int32_String_ComputeBuffer = new(this, "SetBuffer", 0, typeof(System.Int32), typeof(System.String), typeof(UnityEngine.ComputeBuffer));
					r_MSetBuffer_Int32_String_ComputeBuffer.SetBelong(this.instance);
				}
				return r_MSetBuffer_Int32_String_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetBuffer(Int32, System.String, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_MSetBuffer_Int32_String_GraphicsBuffer;
		public virtual RMethod RMSetBuffer_Int32_String_GraphicsBuffer
		{
			get
			{
				if(r_MSetBuffer_Int32_String_GraphicsBuffer == null)
				{
					r_MSetBuffer_Int32_String_GraphicsBuffer = new(this, "SetBuffer", 0, typeof(System.Int32), typeof(System.String), typeof(UnityEngine.GraphicsBuffer));
					r_MSetBuffer_Int32_String_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_MSetBuffer_Int32_String_GraphicsBuffer;
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
		/// Void DispatchIndirect(Int32, UnityEngine.ComputeBuffer, UInt32)
		/// </summary>
		protected RMethod r_MDispatchIndirect_Int32_ComputeBuffer_UInt32;
		public virtual RMethod RMDispatchIndirect_Int32_ComputeBuffer_UInt32
		{
			get
			{
				if(r_MDispatchIndirect_Int32_ComputeBuffer_UInt32 == null)
				{
					r_MDispatchIndirect_Int32_ComputeBuffer_UInt32 = new(this, "DispatchIndirect", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.UInt32));
					r_MDispatchIndirect_Int32_ComputeBuffer_UInt32.SetBelong(this.instance);
				}
				return r_MDispatchIndirect_Int32_ComputeBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void DispatchIndirect(Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_MDispatchIndirect_Int32_ComputeBuffer;
		public virtual RMethod RMDispatchIndirect_Int32_ComputeBuffer
		{
			get
			{
				if(r_MDispatchIndirect_Int32_ComputeBuffer == null)
				{
					r_MDispatchIndirect_Int32_ComputeBuffer = new(this, "DispatchIndirect", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
					r_MDispatchIndirect_Int32_ComputeBuffer.SetBelong(this.instance);
				}
				return r_MDispatchIndirect_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void DispatchIndirect(Int32, UnityEngine.GraphicsBuffer, UInt32)
		/// </summary>
		protected RMethod r_MDispatchIndirect_Int32_GraphicsBuffer_UInt32;
		public virtual RMethod RMDispatchIndirect_Int32_GraphicsBuffer_UInt32
		{
			get
			{
				if(r_MDispatchIndirect_Int32_GraphicsBuffer_UInt32 == null)
				{
					r_MDispatchIndirect_Int32_GraphicsBuffer_UInt32 = new(this, "DispatchIndirect", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32));
					r_MDispatchIndirect_Int32_GraphicsBuffer_UInt32.SetBelong(this.instance);
				}
				return r_MDispatchIndirect_Int32_GraphicsBuffer_UInt32;
			}
		}

		/// <summary>
		/// Void DispatchIndirect(Int32, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_MDispatchIndirect_Int32_GraphicsBuffer;
		public virtual RMethod RMDispatchIndirect_Int32_GraphicsBuffer
		{
			get
			{
				if(r_MDispatchIndirect_Int32_GraphicsBuffer == null)
				{
					r_MDispatchIndirect_Int32_GraphicsBuffer = new(this, "DispatchIndirect", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer));
					r_MDispatchIndirect_Int32_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_MDispatchIndirect_Int32_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetVector_Injected(Int32, UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_MSetVector_Injected_Int32_Ref_Vector4;
		public virtual RMethod RMSetVector_Injected_Int32_Ref_Vector4
		{
			get
			{
				if(r_MSetVector_Injected_Int32_Ref_Vector4 == null)
				{
					r_MSetVector_Injected_Int32_Ref_Vector4 = new(this, "SetVector_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeByRefType());
					r_MSetVector_Injected_Int32_Ref_Vector4.SetBelong(this.instance);
				}
				return r_MSetVector_Injected_Int32_Ref_Vector4;
			}
		}

		/// <summary>
		/// Void SetMatrix_Injected(Int32, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_MSetMatrix_Injected_Int32_Ref_Matrix4x4;
		public virtual RMethod RMSetMatrix_Injected_Int32_Ref_Matrix4x4
		{
			get
			{
				if(r_MSetMatrix_Injected_Int32_Ref_Matrix4x4 == null)
				{
					r_MSetMatrix_Injected_Int32_Ref_Matrix4x4 = new(this, "SetMatrix_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_MSetMatrix_Injected_Int32_Ref_Matrix4x4.SetBelong(this.instance);
				}
				return r_MSetMatrix_Injected_Int32_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Void get_keywordSpace_Injected(UnityEngine.Rendering.LocalKeywordSpace ByRef)
		/// </summary>
		protected RMethod r_Mget_keywordSpace_Injected_Out_LocalKeywordSpace;
		public virtual RMethod RMget_keywordSpace_Injected_Out_LocalKeywordSpace
		{
			get
			{
				if(r_Mget_keywordSpace_Injected_Out_LocalKeywordSpace == null)
				{
					r_Mget_keywordSpace_Injected_Out_LocalKeywordSpace = new(this, "get_keywordSpace_Injected", 0, typeof(UnityEngine.Rendering.LocalKeywordSpace).MakeByRefType());
					r_Mget_keywordSpace_Injected_Out_LocalKeywordSpace.SetBelong(this.instance);
				}
				return r_Mget_keywordSpace_Injected_Out_LocalKeywordSpace;
			}
		}

		/// <summary>
		/// Void EnableLocalKeyword_Injected(UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_MEnableLocalKeyword_Injected_Ref_LocalKeyword;
		public virtual RMethod RMEnableLocalKeyword_Injected_Ref_LocalKeyword
		{
			get
			{
				if(r_MEnableLocalKeyword_Injected_Ref_LocalKeyword == null)
				{
					r_MEnableLocalKeyword_Injected_Ref_LocalKeyword = new(this, "EnableLocalKeyword_Injected", 0, typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
					r_MEnableLocalKeyword_Injected_Ref_LocalKeyword.SetBelong(this.instance);
				}
				return r_MEnableLocalKeyword_Injected_Ref_LocalKeyword;
			}
		}

		/// <summary>
		/// Void DisableLocalKeyword_Injected(UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_MDisableLocalKeyword_Injected_Ref_LocalKeyword;
		public virtual RMethod RMDisableLocalKeyword_Injected_Ref_LocalKeyword
		{
			get
			{
				if(r_MDisableLocalKeyword_Injected_Ref_LocalKeyword == null)
				{
					r_MDisableLocalKeyword_Injected_Ref_LocalKeyword = new(this, "DisableLocalKeyword_Injected", 0, typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
					r_MDisableLocalKeyword_Injected_Ref_LocalKeyword.SetBelong(this.instance);
				}
				return r_MDisableLocalKeyword_Injected_Ref_LocalKeyword;
			}
		}

		/// <summary>
		/// Void SetLocalKeyword_Injected(UnityEngine.Rendering.LocalKeyword ByRef, Boolean)
		/// </summary>
		protected RMethod r_MSetLocalKeyword_Injected_Ref_LocalKeyword_Boolean;
		public virtual RMethod RMSetLocalKeyword_Injected_Ref_LocalKeyword_Boolean
		{
			get
			{
				if(r_MSetLocalKeyword_Injected_Ref_LocalKeyword_Boolean == null)
				{
					r_MSetLocalKeyword_Injected_Ref_LocalKeyword_Boolean = new(this, "SetLocalKeyword_Injected", 0, typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType(), typeof(System.Boolean));
					r_MSetLocalKeyword_Injected_Ref_LocalKeyword_Boolean.SetBelong(this.instance);
				}
				return r_MSetLocalKeyword_Injected_Ref_LocalKeyword_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsLocalKeywordEnabled_Injected(UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_MIsLocalKeywordEnabled_Injected_Ref_LocalKeyword;
		public virtual RMethod RMIsLocalKeywordEnabled_Injected_Ref_LocalKeyword
		{
			get
			{
				if(r_MIsLocalKeywordEnabled_Injected_Ref_LocalKeyword == null)
				{
					r_MIsLocalKeywordEnabled_Injected_Ref_LocalKeyword = new(this, "IsLocalKeywordEnabled_Injected", 0, typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
					r_MIsLocalKeywordEnabled_Injected_Ref_LocalKeyword.SetBelong(this.instance);
				}
				return r_MIsLocalKeywordEnabled_Injected_Ref_LocalKeyword;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_MGetInstanceID;
		public virtual RMethod RMGetInstanceID
		{
			get
			{
				if(r_MGetInstanceID == null)
				{
					r_MGetInstanceID = new(this, "GetInstanceID", 0);
					r_MGetInstanceID.SetBelong(this.instance);
				}
				return r_MGetInstanceID;
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

        public virtual System.Int32 FindKernel(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMFindKernel_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean HasKernel(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasKernel_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetFloat(System.Int32 @nameID, System.Single @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @val};
            var ___result = RMSetFloat_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInt(System.Int32 @nameID, System.Int32 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @val};
            var ___result = RMSetInt_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVector(System.Int32 @nameID, UnityEngine.Vector4 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @val};
            var ___result = RMSetVector_Int32_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrix(System.Int32 @nameID, UnityEngine.Matrix4x4 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @val};
            var ___result = RMSetMatrix_Int32_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloatArray(System.Int32 @nameID, System.Single[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetFloatArray_Int32_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetIntArray(System.Int32 @nameID, System.Int32[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetIntArray_Int32_Int32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVectorArray(System.Int32 @nameID, UnityEngine.Vector4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetVectorArray_Int32_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrixArray(System.Int32 @nameID, UnityEngine.Matrix4x4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetMatrixArray_Int32_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTexture(System.Int32 @kernelIndex, System.Int32 @nameID, UnityEngine.Texture @texture, System.Int32 @mipLevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @nameID, @texture, @mipLevel};
            var ___result = RMSetTexture_Int32_Int32_Texture_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRenderTexture(System.Int32 @kernelIndex, System.Int32 @nameID, UnityEngine.RenderTexture @texture, System.Int32 @mipLevel, UnityEngine.Rendering.RenderTextureSubElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @nameID, @texture, @mipLevel, @element};
            var ___result = RMSetRenderTexture_Int32_Int32_RenderTexture_Int32_RenderTextureSubElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTextureFromGlobal(System.Int32 @kernelIndex, System.Int32 @nameID, System.Int32 @globalTextureNameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @nameID, @globalTextureNameID};
            var ___result = RMSetTextureFromGlobal_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetBuffer(System.Int32 @kernelIndex, System.Int32 @nameID, UnityEngine.ComputeBuffer @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @nameID, @buffer};
            var ___result = RMInternal_SetBuffer_Int32_Int32_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetGraphicsBuffer(System.Int32 @kernelIndex, System.Int32 @nameID, UnityEngine.GraphicsBuffer @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @nameID, @buffer};
            var ___result = RMInternal_SetGraphicsBuffer_Int32_Int32_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBuffer(System.Int32 @kernelIndex, System.Int32 @nameID, UnityEngine.ComputeBuffer @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @nameID, @buffer};
            var ___result = RMSetBuffer_Int32_Int32_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBuffer(System.Int32 @kernelIndex, System.Int32 @nameID, UnityEngine.GraphicsBuffer @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @nameID, @buffer};
            var ___result = RMSetBuffer_Int32_Int32_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantComputeBuffer(System.Int32 @nameID, UnityEngine.ComputeBuffer @buffer, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @buffer, @offset, @size};
            var ___result = RMSetConstantComputeBuffer_Int32_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantGraphicsBuffer(System.Int32 @nameID, UnityEngine.GraphicsBuffer @buffer, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @buffer, @offset, @size};
            var ___result = RMSetConstantGraphicsBuffer_Int32_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetKernelThreadGroupSizes(System.Int32 @kernelIndex, out System.UInt32 @x, out System.UInt32 @y, out System.UInt32 @z)
        {
			@x = default;
			@y = default;
			@z = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @x, @y, @z};
            var ___result = RMGetKernelThreadGroupSizes_Int32_Out_UInt32_Out_UInt32_Out_UInt32.Invoke(___genericsType, ___parameters);
			@x = (System.UInt32)___parameters[1];
			@y = (System.UInt32)___parameters[2];
			@z = (System.UInt32)___parameters[3];

            
        }


        public virtual void Dispatch(System.Int32 @kernelIndex, System.Int32 @threadGroupsX, System.Int32 @threadGroupsY, System.Int32 @threadGroupsZ)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @threadGroupsX, @threadGroupsY, @threadGroupsZ};
            var ___result = RMDispatch_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DispatchIndirect(System.Int32 @kernelIndex, UnityEngine.ComputeBuffer @argsBuffer, System.UInt32 @argsOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @argsBuffer, @argsOffset};
            var ___result = RMInternal_DispatchIndirect_Int32_ComputeBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DispatchIndirectGraphicsBuffer(System.Int32 @kernelIndex, UnityEngine.GraphicsBuffer @argsBuffer, System.UInt32 @argsOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @argsBuffer, @argsOffset};
            var ___result = RMInternal_DispatchIndirectGraphicsBuffer_Int32_GraphicsBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnableKeyword(System.String @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMEnableKeyword_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DisableKeyword(System.String @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMDisableKeyword_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsKeywordEnabled(System.String @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMIsKeywordEnabled_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void EnableLocalKeyword(UnityEngine.Rendering.LocalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMEnableLocalKeyword_LocalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DisableLocalKeyword(UnityEngine.Rendering.LocalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMDisableLocalKeyword_LocalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetLocalKeyword(UnityEngine.Rendering.LocalKeyword @keyword, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword, @value};
            var ___result = RMSetLocalKeyword_LocalKeyword_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsLocalKeywordEnabled(UnityEngine.Rendering.LocalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMIsLocalKeywordEnabled_LocalKeyword.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void EnableKeyword(in UnityEngine.Rendering.LocalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMEnableKeyword_In_LocalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DisableKeyword(in UnityEngine.Rendering.LocalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMDisableKeyword_In_LocalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetKeyword(in UnityEngine.Rendering.LocalKeyword @keyword, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword, @value};
            var ___result = RMSetKeyword_In_LocalKeyword_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsKeywordEnabled(in UnityEngine.Rendering.LocalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMIsKeywordEnabled_In_LocalKeyword.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsSupported(System.Int32 @kernelIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex};
            var ___result = RMIsSupported_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String[] GetShaderKeywords()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetShaderKeywords.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual void SetShaderKeywords(System.String[] @names)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@names};
            var ___result = RMSetShaderKeywords_StringArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rendering.LocalKeyword[] GetEnabledKeywords()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnabledKeywords.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.LocalKeyword[])___result;
        }


        public virtual void SetEnabledKeywords(UnityEngine.Rendering.LocalKeyword[] @keywords)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keywords};
            var ___result = RMSetEnabledKeywords_LocalKeywordArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloat(System.String @name, System.Single @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RMSetFloat_String_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInt(System.String @name, System.Int32 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RMSetInt_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVector(System.String @name, UnityEngine.Vector4 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RMSetVector_String_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrix(System.String @name, UnityEngine.Matrix4x4 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RMSetMatrix_String_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVectorArray(System.String @name, UnityEngine.Vector4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMSetVectorArray_String_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrixArray(System.String @name, UnityEngine.Matrix4x4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMSetMatrixArray_String_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloats(System.String @name, System.Single[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMSetFloats_String_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloats(System.Int32 @nameID, System.Single[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetFloats_Int32_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInts(System.String @name, System.Int32[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMSetInts_String_Int32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInts(System.Int32 @nameID, System.Int32[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetInts_Int32_Int32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBool(System.String @name, System.Boolean @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RMSetBool_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBool(System.Int32 @nameID, System.Boolean @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @val};
            var ___result = RMSetBool_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTexture(System.Int32 @kernelIndex, System.Int32 @nameID, UnityEngine.Texture @texture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @nameID, @texture};
            var ___result = RMSetTexture_Int32_Int32_Texture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTexture(System.Int32 @kernelIndex, System.String @name, UnityEngine.Texture @texture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @name, @texture};
            var ___result = RMSetTexture_Int32_String_Texture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTexture(System.Int32 @kernelIndex, System.String @name, UnityEngine.Texture @texture, System.Int32 @mipLevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @name, @texture, @mipLevel};
            var ___result = RMSetTexture_Int32_String_Texture_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTexture(System.Int32 @kernelIndex, System.Int32 @nameID, UnityEngine.RenderTexture @texture, System.Int32 @mipLevel, UnityEngine.Rendering.RenderTextureSubElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @nameID, @texture, @mipLevel, @element};
            var ___result = RMSetTexture_Int32_Int32_RenderTexture_Int32_RenderTextureSubElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTexture(System.Int32 @kernelIndex, System.String @name, UnityEngine.RenderTexture @texture, System.Int32 @mipLevel, UnityEngine.Rendering.RenderTextureSubElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @name, @texture, @mipLevel, @element};
            var ___result = RMSetTexture_Int32_String_RenderTexture_Int32_RenderTextureSubElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTextureFromGlobal(System.Int32 @kernelIndex, System.String @name, System.String @globalTextureName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @name, @globalTextureName};
            var ___result = RMSetTextureFromGlobal_Int32_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBuffer(System.Int32 @kernelIndex, System.String @name, UnityEngine.ComputeBuffer @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @name, @buffer};
            var ___result = RMSetBuffer_Int32_String_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBuffer(System.Int32 @kernelIndex, System.String @name, UnityEngine.GraphicsBuffer @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @name, @buffer};
            var ___result = RMSetBuffer_Int32_String_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantBuffer(System.Int32 @nameID, UnityEngine.ComputeBuffer @buffer, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @buffer, @offset, @size};
            var ___result = RMSetConstantBuffer_Int32_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantBuffer(System.String @name, UnityEngine.ComputeBuffer @buffer, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @buffer, @offset, @size};
            var ___result = RMSetConstantBuffer_String_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantBuffer(System.Int32 @nameID, UnityEngine.GraphicsBuffer @buffer, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @buffer, @offset, @size};
            var ___result = RMSetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantBuffer(System.String @name, UnityEngine.GraphicsBuffer @buffer, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @buffer, @offset, @size};
            var ___result = RMSetConstantBuffer_String_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DispatchIndirect(System.Int32 @kernelIndex, UnityEngine.ComputeBuffer @argsBuffer, System.UInt32 @argsOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @argsBuffer, @argsOffset};
            var ___result = RMDispatchIndirect_Int32_ComputeBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DispatchIndirect(System.Int32 @kernelIndex, UnityEngine.ComputeBuffer @argsBuffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @argsBuffer};
            var ___result = RMDispatchIndirect_Int32_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DispatchIndirect(System.Int32 @kernelIndex, UnityEngine.GraphicsBuffer @argsBuffer, System.UInt32 @argsOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @argsBuffer, @argsOffset};
            var ___result = RMDispatchIndirect_Int32_GraphicsBuffer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DispatchIndirect(System.Int32 @kernelIndex, UnityEngine.GraphicsBuffer @argsBuffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kernelIndex, @argsBuffer};
            var ___result = RMDispatchIndirect_Int32_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVector_Injected(System.Int32 @nameID, ref UnityEngine.Vector4 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @val};
            var ___result = RMSetVector_Injected_Int32_Ref_Vector4.Invoke(___genericsType, ___parameters);
			@val = (UnityEngine.Vector4)___parameters[1];

            
        }


        public virtual void SetMatrix_Injected(System.Int32 @nameID, ref UnityEngine.Matrix4x4 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @val};
            var ___result = RMSetMatrix_Injected_Int32_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			@val = (UnityEngine.Matrix4x4)___parameters[1];

            
        }


        public virtual void get_keywordSpace_Injected(out UnityEngine.Rendering.LocalKeywordSpace @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_keywordSpace_Injected_Out_LocalKeywordSpace.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Rendering.LocalKeywordSpace)___parameters[0];

            
        }


        public virtual void EnableLocalKeyword_Injected(ref UnityEngine.Rendering.LocalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMEnableLocalKeyword_Injected_Ref_LocalKeyword.Invoke(___genericsType, ___parameters);
			@keyword = (UnityEngine.Rendering.LocalKeyword)___parameters[0];

            
        }


        public virtual void DisableLocalKeyword_Injected(ref UnityEngine.Rendering.LocalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMDisableLocalKeyword_Injected_Ref_LocalKeyword.Invoke(___genericsType, ___parameters);
			@keyword = (UnityEngine.Rendering.LocalKeyword)___parameters[0];

            
        }


        public virtual void SetLocalKeyword_Injected(ref UnityEngine.Rendering.LocalKeyword @keyword, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword, @value};
            var ___result = RMSetLocalKeyword_Injected_Ref_LocalKeyword_Boolean.Invoke(___genericsType, ___parameters);
			@keyword = (UnityEngine.Rendering.LocalKeyword)___parameters[0];

            
        }


        public virtual System.Boolean IsLocalKeywordEnabled_Injected(ref UnityEngine.Rendering.LocalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMIsLocalKeywordEnabled_Injected_Ref_LocalKeyword.Invoke(___genericsType, ___parameters);
			@keyword = (UnityEngine.Rendering.LocalKeyword)___parameters[0];

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
