using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Material
	/// </summary>
    public partial class RMaterial : RMember //
    {

		/// <summary>
		/// UnityEngine.Shader shader
		/// </summary>
		protected RUnityEngine.RShader r_shader;
		public virtual RUnityEngine.RShader Rshader
		{
			get
			{
				if(r_shader == null)
				{
					r_shader = new(this, "shader", -1);
					r_shader.SetBelong(this.instance);
				}
				return r_shader;
			}
		}

		/// <summary>
		/// UnityEngine.Color color
		/// </summary>
		protected RUnityEngine.RColor r_color;
		public virtual RUnityEngine.RColor Rcolor
		{
			get
			{
				if(r_color == null)
				{
					r_color = new(this, "color", -1);
					r_color.SetBelong(this.instance);
				}
				return r_color;
			}
		}

		/// <summary>
		/// UnityEngine.Texture mainTexture
		/// </summary>
		protected RUnityEngine.RTexture r_mainTexture;
		public virtual RUnityEngine.RTexture RmainTexture
		{
			get
			{
				if(r_mainTexture == null)
				{
					r_mainTexture = new(this, "mainTexture", -1);
					r_mainTexture.SetBelong(this.instance);
				}
				return r_mainTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 mainTextureOffset
		/// </summary>
		protected RUnityEngine.RVector2 r_mainTextureOffset;
		public virtual RUnityEngine.RVector2 RmainTextureOffset
		{
			get
			{
				if(r_mainTextureOffset == null)
				{
					r_mainTextureOffset = new(this, "mainTextureOffset", -1);
					r_mainTextureOffset.SetBelong(this.instance);
				}
				return r_mainTextureOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 mainTextureScale
		/// </summary>
		protected RUnityEngine.RVector2 r_mainTextureScale;
		public virtual RUnityEngine.RVector2 RmainTextureScale
		{
			get
			{
				if(r_mainTextureScale == null)
				{
					r_mainTextureScale = new(this, "mainTextureScale", -1);
					r_mainTextureScale.SetBelong(this.instance);
				}
				return r_mainTextureScale;
			}
		}

		/// <summary>
		/// Int32 renderQueue
		/// </summary>
		protected RProperty r_renderQueue;
		public virtual RProperty RrenderQueue
		{
			get
			{
				if(r_renderQueue == null)
				{
					r_renderQueue = new(this, "renderQueue", -1);
					r_renderQueue.SetBelong(this.instance);
				}
				return r_renderQueue;
			}
		}

		/// <summary>
		/// Int32 rawRenderQueue
		/// </summary>
		protected RProperty r_rawRenderQueue;
		public virtual RProperty RrawRenderQueue
		{
			get
			{
				if(r_rawRenderQueue == null)
				{
					r_rawRenderQueue = new(this, "rawRenderQueue", -1);
					r_rawRenderQueue.SetBelong(this.instance);
				}
				return r_rawRenderQueue;
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
		/// UnityEngine.MaterialGlobalIlluminationFlags globalIlluminationFlags
		/// </summary>
		protected RProperty r_globalIlluminationFlags;
		public virtual RProperty RglobalIlluminationFlags
		{
			get
			{
				if(r_globalIlluminationFlags == null)
				{
					r_globalIlluminationFlags = new(this, "globalIlluminationFlags", -1);
					r_globalIlluminationFlags.SetBelong(this.instance);
				}
				return r_globalIlluminationFlags;
			}
		}

		/// <summary>
		/// Boolean doubleSidedGI
		/// </summary>
		protected RProperty r_doubleSidedGI;
		public virtual RProperty RdoubleSidedGI
		{
			get
			{
				if(r_doubleSidedGI == null)
				{
					r_doubleSidedGI = new(this, "doubleSidedGI", -1);
					r_doubleSidedGI.SetBelong(this.instance);
				}
				return r_doubleSidedGI;
			}
		}

		/// <summary>
		/// Boolean enableInstancing
		/// </summary>
		protected RProperty r_enableInstancing;
		public virtual RProperty RenableInstancing
		{
			get
			{
				if(r_enableInstancing == null)
				{
					r_enableInstancing = new(this, "enableInstancing", -1);
					r_enableInstancing.SetBelong(this.instance);
				}
				return r_enableInstancing;
			}
		}

		/// <summary>
		/// Int32 passCount
		/// </summary>
		protected RProperty r_passCount;
		public virtual RProperty RpassCount
		{
			get
			{
				if(r_passCount == null)
				{
					r_passCount = new(this, "passCount", -1);
					r_passCount.SetBelong(this.instance);
				}
				return r_passCount;
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
		/// UnityEngine.Material parent
		/// </summary>
		protected RUnityEngine.RMaterial r_parent;
		public virtual RUnityEngine.RMaterial Rparent
		{
			get
			{
				if(r_parent == null)
				{
					r_parent = new(this, "parent", -1);
					r_parent.SetBelong(this.instance);
				}
				return r_parent;
			}
		}

		/// <summary>
		/// Boolean isVariant
		/// </summary>
		protected RProperty r_isVariant;
		public virtual RProperty RisVariant
		{
			get
			{
				if(r_isVariant == null)
				{
					r_isVariant = new(this, "isVariant", -1);
					r_isVariant.SetBelong(this.instance);
				}
				return r_isVariant;
			}
		}

		/// <summary>
		/// Int32 overrideCount
		/// </summary>
		protected RProperty r_overrideCount;
		public virtual RProperty RoverrideCount
		{
			get
			{
				if(r_overrideCount == null)
				{
					r_overrideCount = new(this, "overrideCount", -1);
					r_overrideCount.SetBelong(this.instance);
				}
				return r_overrideCount;
			}
		}

		/// <summary>
		/// Int32 lockCount
		/// </summary>
		protected RProperty r_lockCount;
		public virtual RProperty RlockCount
		{
			get
			{
				if(r_lockCount == null)
				{
					r_lockCount = new(this, "lockCount", -1);
					r_lockCount.SetBelong(this.instance);
				}
				return r_lockCount;
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
		/// UnityEngine.Material Create(System.String)
		/// </summary>
		protected static RMethod r_Create_String;
		public static RMethod RCreate_String
		{
			get
			{
				if(r_Create_String == null)
				{
					r_Create_String = new(typeof(UnityEngine.Material), "Create", 0, typeof(System.String));
					r_Create_String.SetBelong(null);
				}
				return r_Create_String;
			}
		}

		/// <summary>
		/// Void CreateWithShader(UnityEngine.Material, UnityEngine.Shader)
		/// </summary>
		protected static RMethod r_CreateWithShader_Material_Shader;
		public static RMethod RCreateWithShader_Material_Shader
		{
			get
			{
				if(r_CreateWithShader_Material_Shader == null)
				{
					r_CreateWithShader_Material_Shader = new(typeof(UnityEngine.Material), "CreateWithShader", 0, typeof(UnityEngine.Material), typeof(UnityEngine.Shader));
					r_CreateWithShader_Material_Shader.SetBelong(null);
				}
				return r_CreateWithShader_Material_Shader;
			}
		}

		/// <summary>
		/// Void CreateWithMaterial(UnityEngine.Material, UnityEngine.Material)
		/// </summary>
		protected static RMethod r_CreateWithMaterial_Material_Material;
		public static RMethod RCreateWithMaterial_Material_Material
		{
			get
			{
				if(r_CreateWithMaterial_Material_Material == null)
				{
					r_CreateWithMaterial_Material_Material = new(typeof(UnityEngine.Material), "CreateWithMaterial", 0, typeof(UnityEngine.Material), typeof(UnityEngine.Material));
					r_CreateWithMaterial_Material_Material.SetBelong(null);
				}
				return r_CreateWithMaterial_Material_Material;
			}
		}

		/// <summary>
		/// Void CreateWithString(UnityEngine.Material)
		/// </summary>
		protected static RMethod r_CreateWithString_Material;
		public static RMethod RCreateWithString_Material
		{
			get
			{
				if(r_CreateWithString_Material == null)
				{
					r_CreateWithString_Material = new(typeof(UnityEngine.Material), "CreateWithString", 0, typeof(UnityEngine.Material));
					r_CreateWithString_Material.SetBelong(null);
				}
				return r_CreateWithString_Material;
			}
		}

		/// <summary>
		/// UnityEngine.Material GetDefaultMaterial()
		/// </summary>
		protected static RMethod r_GetDefaultMaterial;
		public static RMethod RGetDefaultMaterial
		{
			get
			{
				if(r_GetDefaultMaterial == null)
				{
					r_GetDefaultMaterial = new(typeof(UnityEngine.Material), "GetDefaultMaterial", 0);
					r_GetDefaultMaterial.SetBelong(null);
				}
				return r_GetDefaultMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.Material GetDefaultParticleMaterial()
		/// </summary>
		protected static RMethod r_GetDefaultParticleMaterial;
		public static RMethod RGetDefaultParticleMaterial
		{
			get
			{
				if(r_GetDefaultParticleMaterial == null)
				{
					r_GetDefaultParticleMaterial = new(typeof(UnityEngine.Material), "GetDefaultParticleMaterial", 0);
					r_GetDefaultParticleMaterial.SetBelong(null);
				}
				return r_GetDefaultParticleMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.Material GetDefaultLineMaterial()
		/// </summary>
		protected static RMethod r_GetDefaultLineMaterial;
		public static RMethod RGetDefaultLineMaterial
		{
			get
			{
				if(r_GetDefaultLineMaterial == null)
				{
					r_GetDefaultLineMaterial = new(typeof(UnityEngine.Material), "GetDefaultLineMaterial", 0);
					r_GetDefaultLineMaterial.SetBelong(null);
				}
				return r_GetDefaultLineMaterial;
			}
		}

		/// <summary>
		/// Int32 GetFirstPropertyNameIdByAttribute(UnityEngine.Rendering.ShaderPropertyFlags)
		/// </summary>
		protected RMethod r_GetFirstPropertyNameIdByAttribute_ShaderPropertyFlags;
		public virtual RMethod RGetFirstPropertyNameIdByAttribute_ShaderPropertyFlags
		{
			get
			{
				if(r_GetFirstPropertyNameIdByAttribute_ShaderPropertyFlags == null)
				{
					r_GetFirstPropertyNameIdByAttribute_ShaderPropertyFlags = new(this, "GetFirstPropertyNameIdByAttribute", 0, typeof(UnityEngine.Rendering.ShaderPropertyFlags));
					r_GetFirstPropertyNameIdByAttribute_ShaderPropertyFlags.SetBelong(this.instance);
				}
				return r_GetFirstPropertyNameIdByAttribute_ShaderPropertyFlags;
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
		/// Void SetShaderPassEnabled(System.String, Boolean)
		/// </summary>
		protected RMethod r_SetShaderPassEnabled_String_Boolean;
		public virtual RMethod RSetShaderPassEnabled_String_Boolean
		{
			get
			{
				if(r_SetShaderPassEnabled_String_Boolean == null)
				{
					r_SetShaderPassEnabled_String_Boolean = new(this, "SetShaderPassEnabled", 0, typeof(System.String), typeof(System.Boolean));
					r_SetShaderPassEnabled_String_Boolean.SetBelong(this.instance);
				}
				return r_SetShaderPassEnabled_String_Boolean;
			}
		}

		/// <summary>
		/// Boolean GetShaderPassEnabled(System.String)
		/// </summary>
		protected RMethod r_GetShaderPassEnabled_String;
		public virtual RMethod RGetShaderPassEnabled_String
		{
			get
			{
				if(r_GetShaderPassEnabled_String == null)
				{
					r_GetShaderPassEnabled_String = new(this, "GetShaderPassEnabled", 0, typeof(System.String));
					r_GetShaderPassEnabled_String.SetBelong(this.instance);
				}
				return r_GetShaderPassEnabled_String;
			}
		}

		/// <summary>
		/// System.String GetPassName(Int32)
		/// </summary>
		protected RMethod r_GetPassName_Int32;
		public virtual RMethod RGetPassName_Int32
		{
			get
			{
				if(r_GetPassName_Int32 == null)
				{
					r_GetPassName_Int32 = new(this, "GetPassName", 0, typeof(System.Int32));
					r_GetPassName_Int32.SetBelong(this.instance);
				}
				return r_GetPassName_Int32;
			}
		}

		/// <summary>
		/// Int32 FindPass(System.String)
		/// </summary>
		protected RMethod r_FindPass_String;
		public virtual RMethod RFindPass_String
		{
			get
			{
				if(r_FindPass_String == null)
				{
					r_FindPass_String = new(this, "FindPass", 0, typeof(System.String));
					r_FindPass_String.SetBelong(this.instance);
				}
				return r_FindPass_String;
			}
		}

		/// <summary>
		/// Void SetOverrideTag(System.String, System.String)
		/// </summary>
		protected RMethod r_SetOverrideTag_String_String;
		public virtual RMethod RSetOverrideTag_String_String
		{
			get
			{
				if(r_SetOverrideTag_String_String == null)
				{
					r_SetOverrideTag_String_String = new(this, "SetOverrideTag", 0, typeof(System.String), typeof(System.String));
					r_SetOverrideTag_String_String.SetBelong(this.instance);
				}
				return r_SetOverrideTag_String_String;
			}
		}

		/// <summary>
		/// System.String GetTagImpl(System.String, Boolean, System.String)
		/// </summary>
		protected RMethod r_GetTagImpl_String_Boolean_String;
		public virtual RMethod RGetTagImpl_String_Boolean_String
		{
			get
			{
				if(r_GetTagImpl_String_Boolean_String == null)
				{
					r_GetTagImpl_String_Boolean_String = new(this, "GetTagImpl", 0, typeof(System.String), typeof(System.Boolean), typeof(System.String));
					r_GetTagImpl_String_Boolean_String.SetBelong(this.instance);
				}
				return r_GetTagImpl_String_Boolean_String;
			}
		}

		/// <summary>
		/// System.String GetTag(System.String, Boolean, System.String)
		/// </summary>
		protected RMethod r_GetTag_String_Boolean_String;
		public virtual RMethod RGetTag_String_Boolean_String
		{
			get
			{
				if(r_GetTag_String_Boolean_String == null)
				{
					r_GetTag_String_Boolean_String = new(this, "GetTag", 0, typeof(System.String), typeof(System.Boolean), typeof(System.String));
					r_GetTag_String_Boolean_String.SetBelong(this.instance);
				}
				return r_GetTag_String_Boolean_String;
			}
		}

		/// <summary>
		/// System.String GetTag(System.String, Boolean)
		/// </summary>
		protected RMethod r_GetTag_String_Boolean;
		public virtual RMethod RGetTag_String_Boolean
		{
			get
			{
				if(r_GetTag_String_Boolean == null)
				{
					r_GetTag_String_Boolean = new(this, "GetTag", 0, typeof(System.String), typeof(System.Boolean));
					r_GetTag_String_Boolean.SetBelong(this.instance);
				}
				return r_GetTag_String_Boolean;
			}
		}

		/// <summary>
		/// Void Lerp(UnityEngine.Material, UnityEngine.Material, Single)
		/// </summary>
		protected RMethod r_Lerp_Material_Material_Single;
		public virtual RMethod RLerp_Material_Material_Single
		{
			get
			{
				if(r_Lerp_Material_Material_Single == null)
				{
					r_Lerp_Material_Material_Single = new(this, "Lerp", 0, typeof(UnityEngine.Material), typeof(UnityEngine.Material), typeof(System.Single));
					r_Lerp_Material_Material_Single.SetBelong(this.instance);
				}
				return r_Lerp_Material_Material_Single;
			}
		}

		/// <summary>
		/// Boolean SetPass(Int32)
		/// </summary>
		protected RMethod r_SetPass_Int32;
		public virtual RMethod RSetPass_Int32
		{
			get
			{
				if(r_SetPass_Int32 == null)
				{
					r_SetPass_Int32 = new(this, "SetPass", 0, typeof(System.Int32));
					r_SetPass_Int32.SetBelong(this.instance);
				}
				return r_SetPass_Int32;
			}
		}

		/// <summary>
		/// Void CopyPropertiesFromMaterial(UnityEngine.Material)
		/// </summary>
		protected RMethod r_CopyPropertiesFromMaterial_Material;
		public virtual RMethod RCopyPropertiesFromMaterial_Material
		{
			get
			{
				if(r_CopyPropertiesFromMaterial_Material == null)
				{
					r_CopyPropertiesFromMaterial_Material = new(this, "CopyPropertiesFromMaterial", 0, typeof(UnityEngine.Material));
					r_CopyPropertiesFromMaterial_Material.SetBelong(this.instance);
				}
				return r_CopyPropertiesFromMaterial_Material;
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
		/// System.String[] GetPropertyNamesImpl(Int32)
		/// </summary>
		protected RMethod r_GetPropertyNamesImpl_Int32;
		public virtual RMethod RGetPropertyNamesImpl_Int32
		{
			get
			{
				if(r_GetPropertyNamesImpl_Int32 == null)
				{
					r_GetPropertyNamesImpl_Int32 = new(this, "GetPropertyNamesImpl", 0, typeof(System.Int32));
					r_GetPropertyNamesImpl_Int32.SetBelong(this.instance);
				}
				return r_GetPropertyNamesImpl_Int32;
			}
		}

		/// <summary>
		/// Int32 ComputeCRC()
		/// </summary>
		protected RMethod r_ComputeCRC;
		public virtual RMethod RComputeCRC
		{
			get
			{
				if(r_ComputeCRC == null)
				{
					r_ComputeCRC = new(this, "ComputeCRC", 0);
					r_ComputeCRC.SetBelong(this.instance);
				}
				return r_ComputeCRC;
			}
		}

		/// <summary>
		/// System.String[] GetTexturePropertyNames()
		/// </summary>
		protected RMethod r_GetTexturePropertyNames;
		public virtual RMethod RGetTexturePropertyNames
		{
			get
			{
				if(r_GetTexturePropertyNames == null)
				{
					r_GetTexturePropertyNames = new(this, "GetTexturePropertyNames", 0);
					r_GetTexturePropertyNames.SetBelong(this.instance);
				}
				return r_GetTexturePropertyNames;
			}
		}

		/// <summary>
		/// Int32[] GetTexturePropertyNameIDs()
		/// </summary>
		protected RMethod r_GetTexturePropertyNameIDs;
		public virtual RMethod RGetTexturePropertyNameIDs
		{
			get
			{
				if(r_GetTexturePropertyNameIDs == null)
				{
					r_GetTexturePropertyNameIDs = new(this, "GetTexturePropertyNameIDs", 0);
					r_GetTexturePropertyNameIDs.SetBelong(this.instance);
				}
				return r_GetTexturePropertyNameIDs;
			}
		}

		/// <summary>
		/// Void GetTexturePropertyNamesInternal(System.Object)
		/// </summary>
		protected RMethod r_GetTexturePropertyNamesInternal_Object;
		public virtual RMethod RGetTexturePropertyNamesInternal_Object
		{
			get
			{
				if(r_GetTexturePropertyNamesInternal_Object == null)
				{
					r_GetTexturePropertyNamesInternal_Object = new(this, "GetTexturePropertyNamesInternal", 0, typeof(System.Object));
					r_GetTexturePropertyNamesInternal_Object.SetBelong(this.instance);
				}
				return r_GetTexturePropertyNamesInternal_Object;
			}
		}

		/// <summary>
		/// Void GetTexturePropertyNameIDsInternal(System.Object)
		/// </summary>
		protected RMethod r_GetTexturePropertyNameIDsInternal_Object;
		public virtual RMethod RGetTexturePropertyNameIDsInternal_Object
		{
			get
			{
				if(r_GetTexturePropertyNameIDsInternal_Object == null)
				{
					r_GetTexturePropertyNameIDsInternal_Object = new(this, "GetTexturePropertyNameIDsInternal", 0, typeof(System.Object));
					r_GetTexturePropertyNameIDsInternal_Object.SetBelong(this.instance);
				}
				return r_GetTexturePropertyNameIDsInternal_Object;
			}
		}

		/// <summary>
		/// Void GetTexturePropertyNames(System.Collections.Generic.List`1[System.String])
		/// </summary>
		protected RMethod r_GetTexturePropertyNames_List_d_String_p_;
		public virtual RMethod RGetTexturePropertyNames_List_d_String_p_
		{
			get
			{
				if(r_GetTexturePropertyNames_List_d_String_p_ == null)
				{
					r_GetTexturePropertyNames_List_d_String_p_ = new(this, "GetTexturePropertyNames", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.String)));
					r_GetTexturePropertyNames_List_d_String_p_.SetBelong(this.instance);
				}
				return r_GetTexturePropertyNames_List_d_String_p_;
			}
		}

		/// <summary>
		/// Void GetTexturePropertyNameIDs(System.Collections.Generic.List`1[System.Int32])
		/// </summary>
		protected RMethod r_GetTexturePropertyNameIDs_List_d_Int32_p_;
		public virtual RMethod RGetTexturePropertyNameIDs_List_d_Int32_p_
		{
			get
			{
				if(r_GetTexturePropertyNameIDs_List_d_Int32_p_ == null)
				{
					r_GetTexturePropertyNameIDs_List_d_Int32_p_ = new(this, "GetTexturePropertyNameIDs", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)));
					r_GetTexturePropertyNameIDs_List_d_Int32_p_.SetBelong(this.instance);
				}
				return r_GetTexturePropertyNameIDs_List_d_Int32_p_;
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
		/// UnityEngine.GraphicsBufferHandle GetBufferImpl(Int32)
		/// </summary>
		protected RMethod r_GetBufferImpl_Int32;
		public virtual RMethod RGetBufferImpl_Int32
		{
			get
			{
				if(r_GetBufferImpl_Int32 == null)
				{
					r_GetBufferImpl_Int32 = new(this, "GetBufferImpl", 0, typeof(System.Int32));
					r_GetBufferImpl_Int32.SetBelong(this.instance);
				}
				return r_GetBufferImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBufferHandle GetConstantBufferImpl(Int32)
		/// </summary>
		protected RMethod r_GetConstantBufferImpl_Int32;
		public virtual RMethod RGetConstantBufferImpl_Int32
		{
			get
			{
				if(r_GetConstantBufferImpl_Int32 == null)
				{
					r_GetConstantBufferImpl_Int32 = new(this, "GetConstantBufferImpl", 0, typeof(System.Int32));
					r_GetConstantBufferImpl_Int32.SetBelong(this.instance);
				}
				return r_GetConstantBufferImpl_Int32;
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
		/// Void SetColorArrayImpl(Int32, UnityEngine.Color[], Int32)
		/// </summary>
		protected RMethod r_SetColorArrayImpl_Int32_ColorArray_Int32;
		public virtual RMethod RSetColorArrayImpl_Int32_ColorArray_Int32
		{
			get
			{
				if(r_SetColorArrayImpl_Int32_ColorArray_Int32 == null)
				{
					r_SetColorArrayImpl_Int32_ColorArray_Int32 = new(this, "SetColorArrayImpl", 0, typeof(System.Int32), typeof(UnityEngine.Color).MakeArrayType(), typeof(System.Int32));
					r_SetColorArrayImpl_Int32_ColorArray_Int32.SetBelong(this.instance);
				}
				return r_SetColorArrayImpl_Int32_ColorArray_Int32;
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
		/// UnityEngine.Color[] GetColorArrayImpl(Int32)
		/// </summary>
		protected RMethod r_GetColorArrayImpl_Int32;
		public virtual RMethod RGetColorArrayImpl_Int32
		{
			get
			{
				if(r_GetColorArrayImpl_Int32 == null)
				{
					r_GetColorArrayImpl_Int32 = new(this, "GetColorArrayImpl", 0, typeof(System.Int32));
					r_GetColorArrayImpl_Int32.SetBelong(this.instance);
				}
				return r_GetColorArrayImpl_Int32;
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
		/// Int32 GetColorArrayCountImpl(Int32)
		/// </summary>
		protected RMethod r_GetColorArrayCountImpl_Int32;
		public virtual RMethod RGetColorArrayCountImpl_Int32
		{
			get
			{
				if(r_GetColorArrayCountImpl_Int32 == null)
				{
					r_GetColorArrayCountImpl_Int32 = new(this, "GetColorArrayCountImpl", 0, typeof(System.Int32));
					r_GetColorArrayCountImpl_Int32.SetBelong(this.instance);
				}
				return r_GetColorArrayCountImpl_Int32;
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
		/// Void ExtractColorArrayImpl(Int32, UnityEngine.Color[])
		/// </summary>
		protected RMethod r_ExtractColorArrayImpl_Int32_ColorArray;
		public virtual RMethod RExtractColorArrayImpl_Int32_ColorArray
		{
			get
			{
				if(r_ExtractColorArrayImpl_Int32_ColorArray == null)
				{
					r_ExtractColorArrayImpl_Int32_ColorArray = new(this, "ExtractColorArrayImpl", 0, typeof(System.Int32), typeof(UnityEngine.Color).MakeArrayType());
					r_ExtractColorArrayImpl_Int32_ColorArray.SetBelong(this.instance);
				}
				return r_ExtractColorArrayImpl_Int32_ColorArray;
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
		/// UnityEngine.Vector4 GetTextureScaleAndOffsetImpl(Int32)
		/// </summary>
		protected RMethod r_GetTextureScaleAndOffsetImpl_Int32;
		public virtual RMethod RGetTextureScaleAndOffsetImpl_Int32
		{
			get
			{
				if(r_GetTextureScaleAndOffsetImpl_Int32 == null)
				{
					r_GetTextureScaleAndOffsetImpl_Int32 = new(this, "GetTextureScaleAndOffsetImpl", 0, typeof(System.Int32));
					r_GetTextureScaleAndOffsetImpl_Int32.SetBelong(this.instance);
				}
				return r_GetTextureScaleAndOffsetImpl_Int32;
			}
		}

		/// <summary>
		/// Void SetTextureOffsetImpl(Int32, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_SetTextureOffsetImpl_Int32_Vector2;
		public virtual RMethod RSetTextureOffsetImpl_Int32_Vector2
		{
			get
			{
				if(r_SetTextureOffsetImpl_Int32_Vector2 == null)
				{
					r_SetTextureOffsetImpl_Int32_Vector2 = new(this, "SetTextureOffsetImpl", 0, typeof(System.Int32), typeof(UnityEngine.Vector2));
					r_SetTextureOffsetImpl_Int32_Vector2.SetBelong(this.instance);
				}
				return r_SetTextureOffsetImpl_Int32_Vector2;
			}
		}

		/// <summary>
		/// Void SetTextureScaleImpl(Int32, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_SetTextureScaleImpl_Int32_Vector2;
		public virtual RMethod RSetTextureScaleImpl_Int32_Vector2
		{
			get
			{
				if(r_SetTextureScaleImpl_Int32_Vector2 == null)
				{
					r_SetTextureScaleImpl_Int32_Vector2 = new(this, "SetTextureScaleImpl", 0, typeof(System.Int32), typeof(UnityEngine.Vector2));
					r_SetTextureScaleImpl_Int32_Vector2.SetBelong(this.instance);
				}
				return r_SetTextureScaleImpl_Int32_Vector2;
			}
		}

		/// <summary>
		/// Boolean IsChildOf(UnityEngine.Material)
		/// </summary>
		protected RMethod r_IsChildOf_Material;
		public virtual RMethod RIsChildOf_Material
		{
			get
			{
				if(r_IsChildOf_Material == null)
				{
					r_IsChildOf_Material = new(this, "IsChildOf", 0, typeof(UnityEngine.Material));
					r_IsChildOf_Material.SetBelong(this.instance);
				}
				return r_IsChildOf_Material;
			}
		}

		/// <summary>
		/// Void RevertAllPropertyOverrides()
		/// </summary>
		protected RMethod r_RevertAllPropertyOverrides;
		public virtual RMethod RRevertAllPropertyOverrides
		{
			get
			{
				if(r_RevertAllPropertyOverrides == null)
				{
					r_RevertAllPropertyOverrides = new(this, "RevertAllPropertyOverrides", 0);
					r_RevertAllPropertyOverrides.SetBelong(this.instance);
				}
				return r_RevertAllPropertyOverrides;
			}
		}

		/// <summary>
		/// Boolean IsPropertyOverriden(Int32)
		/// </summary>
		protected RMethod r_IsPropertyOverriden_Int32;
		public virtual RMethod RIsPropertyOverriden_Int32
		{
			get
			{
				if(r_IsPropertyOverriden_Int32 == null)
				{
					r_IsPropertyOverriden_Int32 = new(this, "IsPropertyOverriden", 0, typeof(System.Int32));
					r_IsPropertyOverriden_Int32.SetBelong(this.instance);
				}
				return r_IsPropertyOverriden_Int32;
			}
		}

		/// <summary>
		/// Boolean IsPropertyLocked(Int32)
		/// </summary>
		protected RMethod r_IsPropertyLocked_Int32;
		public virtual RMethod RIsPropertyLocked_Int32
		{
			get
			{
				if(r_IsPropertyLocked_Int32 == null)
				{
					r_IsPropertyLocked_Int32 = new(this, "IsPropertyLocked", 0, typeof(System.Int32));
					r_IsPropertyLocked_Int32.SetBelong(this.instance);
				}
				return r_IsPropertyLocked_Int32;
			}
		}

		/// <summary>
		/// Boolean IsPropertyLockedByAncestor(Int32)
		/// </summary>
		protected RMethod r_IsPropertyLockedByAncestor_Int32;
		public virtual RMethod RIsPropertyLockedByAncestor_Int32
		{
			get
			{
				if(r_IsPropertyLockedByAncestor_Int32 == null)
				{
					r_IsPropertyLockedByAncestor_Int32 = new(this, "IsPropertyLockedByAncestor", 0, typeof(System.Int32));
					r_IsPropertyLockedByAncestor_Int32.SetBelong(this.instance);
				}
				return r_IsPropertyLockedByAncestor_Int32;
			}
		}

		/// <summary>
		/// Boolean IsPropertyOverriden(System.String)
		/// </summary>
		protected RMethod r_IsPropertyOverriden_String;
		public virtual RMethod RIsPropertyOverriden_String
		{
			get
			{
				if(r_IsPropertyOverriden_String == null)
				{
					r_IsPropertyOverriden_String = new(this, "IsPropertyOverriden", 0, typeof(System.String));
					r_IsPropertyOverriden_String.SetBelong(this.instance);
				}
				return r_IsPropertyOverriden_String;
			}
		}

		/// <summary>
		/// Boolean IsPropertyLocked(System.String)
		/// </summary>
		protected RMethod r_IsPropertyLocked_String;
		public virtual RMethod RIsPropertyLocked_String
		{
			get
			{
				if(r_IsPropertyLocked_String == null)
				{
					r_IsPropertyLocked_String = new(this, "IsPropertyLocked", 0, typeof(System.String));
					r_IsPropertyLocked_String.SetBelong(this.instance);
				}
				return r_IsPropertyLocked_String;
			}
		}

		/// <summary>
		/// Boolean IsPropertyLockedByAncestor(System.String)
		/// </summary>
		protected RMethod r_IsPropertyLockedByAncestor_String;
		public virtual RMethod RIsPropertyLockedByAncestor_String
		{
			get
			{
				if(r_IsPropertyLockedByAncestor_String == null)
				{
					r_IsPropertyLockedByAncestor_String = new(this, "IsPropertyLockedByAncestor", 0, typeof(System.String));
					r_IsPropertyLockedByAncestor_String.SetBelong(this.instance);
				}
				return r_IsPropertyLockedByAncestor_String;
			}
		}

		/// <summary>
		/// Void SetPropertyLock(Int32, Boolean)
		/// </summary>
		protected RMethod r_SetPropertyLock_Int32_Boolean;
		public virtual RMethod RSetPropertyLock_Int32_Boolean
		{
			get
			{
				if(r_SetPropertyLock_Int32_Boolean == null)
				{
					r_SetPropertyLock_Int32_Boolean = new(this, "SetPropertyLock", 0, typeof(System.Int32), typeof(System.Boolean));
					r_SetPropertyLock_Int32_Boolean.SetBelong(this.instance);
				}
				return r_SetPropertyLock_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void ApplyPropertyOverride(UnityEngine.Material, Int32, Boolean)
		/// </summary>
		protected RMethod r_ApplyPropertyOverride_Material_Int32_Boolean;
		public virtual RMethod RApplyPropertyOverride_Material_Int32_Boolean
		{
			get
			{
				if(r_ApplyPropertyOverride_Material_Int32_Boolean == null)
				{
					r_ApplyPropertyOverride_Material_Int32_Boolean = new(this, "ApplyPropertyOverride", 0, typeof(UnityEngine.Material), typeof(System.Int32), typeof(System.Boolean));
					r_ApplyPropertyOverride_Material_Int32_Boolean.SetBelong(this.instance);
				}
				return r_ApplyPropertyOverride_Material_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void RevertPropertyOverride(Int32)
		/// </summary>
		protected RMethod r_RevertPropertyOverride_Int32;
		public virtual RMethod RRevertPropertyOverride_Int32
		{
			get
			{
				if(r_RevertPropertyOverride_Int32 == null)
				{
					r_RevertPropertyOverride_Int32 = new(this, "RevertPropertyOverride", 0, typeof(System.Int32));
					r_RevertPropertyOverride_Int32.SetBelong(this.instance);
				}
				return r_RevertPropertyOverride_Int32;
			}
		}

		/// <summary>
		/// Void GetPropertyState(Int32, Boolean ByRef, Boolean ByRef, Boolean ByRef)
		/// </summary>
		protected RMethod r_GetPropertyState_Int32_Out_Boolean_Out_Boolean_Out_Boolean;
		public virtual RMethod RGetPropertyState_Int32_Out_Boolean_Out_Boolean_Out_Boolean
		{
			get
			{
				if(r_GetPropertyState_Int32_Out_Boolean_Out_Boolean_Out_Boolean == null)
				{
					r_GetPropertyState_Int32_Out_Boolean_Out_Boolean_Out_Boolean = new(this, "GetPropertyState", 0, typeof(System.Int32), typeof(System.Boolean).MakeByRefType(), typeof(System.Boolean).MakeByRefType(), typeof(System.Boolean).MakeByRefType());
					r_GetPropertyState_Int32_Out_Boolean_Out_Boolean_Out_Boolean.SetBelong(this.instance);
				}
				return r_GetPropertyState_Int32_Out_Boolean_Out_Boolean_Out_Boolean;
			}
		}

		/// <summary>
		/// Void SetPropertyLock(System.String, Boolean)
		/// </summary>
		protected RMethod r_SetPropertyLock_String_Boolean;
		public virtual RMethod RSetPropertyLock_String_Boolean
		{
			get
			{
				if(r_SetPropertyLock_String_Boolean == null)
				{
					r_SetPropertyLock_String_Boolean = new(this, "SetPropertyLock", 0, typeof(System.String), typeof(System.Boolean));
					r_SetPropertyLock_String_Boolean.SetBelong(this.instance);
				}
				return r_SetPropertyLock_String_Boolean;
			}
		}

		/// <summary>
		/// Void ApplyPropertyOverride(UnityEngine.Material, System.String, Boolean)
		/// </summary>
		protected RMethod r_ApplyPropertyOverride_Material_String_Boolean;
		public virtual RMethod RApplyPropertyOverride_Material_String_Boolean
		{
			get
			{
				if(r_ApplyPropertyOverride_Material_String_Boolean == null)
				{
					r_ApplyPropertyOverride_Material_String_Boolean = new(this, "ApplyPropertyOverride", 0, typeof(UnityEngine.Material), typeof(System.String), typeof(System.Boolean));
					r_ApplyPropertyOverride_Material_String_Boolean.SetBelong(this.instance);
				}
				return r_ApplyPropertyOverride_Material_String_Boolean;
			}
		}

		/// <summary>
		/// Void RevertPropertyOverride(System.String)
		/// </summary>
		protected RMethod r_RevertPropertyOverride_String;
		public virtual RMethod RRevertPropertyOverride_String
		{
			get
			{
				if(r_RevertPropertyOverride_String == null)
				{
					r_RevertPropertyOverride_String = new(this, "RevertPropertyOverride", 0, typeof(System.String));
					r_RevertPropertyOverride_String.SetBelong(this.instance);
				}
				return r_RevertPropertyOverride_String;
			}
		}

		/// <summary>
		/// Void SetPropertyLock_Serialized(UnityEngine.MaterialSerializedProperty, Boolean)
		/// </summary>
		protected RMethod r_SetPropertyLock_Serialized_MaterialSerializedProperty_Boolean;
		public virtual RMethod RSetPropertyLock_Serialized_MaterialSerializedProperty_Boolean
		{
			get
			{
				if(r_SetPropertyLock_Serialized_MaterialSerializedProperty_Boolean == null)
				{
					r_SetPropertyLock_Serialized_MaterialSerializedProperty_Boolean = new(this, "SetPropertyLock_Serialized", 0,  ReflectionUtils.GetType("UnityEngine.MaterialSerializedProperty"), typeof(System.Boolean));
					r_SetPropertyLock_Serialized_MaterialSerializedProperty_Boolean.SetBelong(this.instance);
				}
				return r_SetPropertyLock_Serialized_MaterialSerializedProperty_Boolean;
			}
		}

		/// <summary>
		/// Void ApplyPropertyOverride_Serialized(UnityEngine.Material, UnityEngine.MaterialSerializedProperty, Boolean)
		/// </summary>
		protected RMethod r_ApplyPropertyOverride_Serialized_Material_MaterialSerializedProperty_Boolean;
		public virtual RMethod RApplyPropertyOverride_Serialized_Material_MaterialSerializedProperty_Boolean
		{
			get
			{
				if(r_ApplyPropertyOverride_Serialized_Material_MaterialSerializedProperty_Boolean == null)
				{
					r_ApplyPropertyOverride_Serialized_Material_MaterialSerializedProperty_Boolean = new(this, "ApplyPropertyOverride_Serialized", 0, typeof(UnityEngine.Material),  ReflectionUtils.GetType("UnityEngine.MaterialSerializedProperty"), typeof(System.Boolean));
					r_ApplyPropertyOverride_Serialized_Material_MaterialSerializedProperty_Boolean.SetBelong(this.instance);
				}
				return r_ApplyPropertyOverride_Serialized_Material_MaterialSerializedProperty_Boolean;
			}
		}

		/// <summary>
		/// Void RevertPropertyOverride_Serialized(UnityEngine.MaterialSerializedProperty)
		/// </summary>
		protected RMethod r_RevertPropertyOverride_Serialized_MaterialSerializedProperty;
		public virtual RMethod RRevertPropertyOverride_Serialized_MaterialSerializedProperty
		{
			get
			{
				if(r_RevertPropertyOverride_Serialized_MaterialSerializedProperty == null)
				{
					r_RevertPropertyOverride_Serialized_MaterialSerializedProperty = new(this, "RevertPropertyOverride_Serialized", 0,  ReflectionUtils.GetType("UnityEngine.MaterialSerializedProperty"));
					r_RevertPropertyOverride_Serialized_MaterialSerializedProperty.SetBelong(this.instance);
				}
				return r_RevertPropertyOverride_Serialized_MaterialSerializedProperty;
			}
		}

		/// <summary>
		/// Void GetPropertyState_Serialized(UnityEngine.MaterialSerializedProperty, Boolean ByRef, Boolean ByRef, Boolean ByRef)
		/// </summary>
		protected RMethod r_GetPropertyState_Serialized_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean;
		public virtual RMethod RGetPropertyState_Serialized_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean
		{
			get
			{
				if(r_GetPropertyState_Serialized_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean == null)
				{
					r_GetPropertyState_Serialized_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean = new(this, "GetPropertyState_Serialized", 0,  ReflectionUtils.GetType("UnityEngine.MaterialSerializedProperty"), typeof(System.Boolean).MakeByRefType(), typeof(System.Boolean).MakeByRefType(), typeof(System.Boolean).MakeByRefType());
					r_GetPropertyState_Serialized_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean.SetBelong(this.instance);
				}
				return r_GetPropertyState_Serialized_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean;
			}
		}

		/// <summary>
		/// Void SetPropertyLock(UnityEngine.MaterialSerializedProperty, Boolean)
		/// </summary>
		protected RMethod r_SetPropertyLock_MaterialSerializedProperty_Boolean;
		public virtual RMethod RSetPropertyLock_MaterialSerializedProperty_Boolean
		{
			get
			{
				if(r_SetPropertyLock_MaterialSerializedProperty_Boolean == null)
				{
					r_SetPropertyLock_MaterialSerializedProperty_Boolean = new(this, "SetPropertyLock", 0,  ReflectionUtils.GetType("UnityEngine.MaterialSerializedProperty"), typeof(System.Boolean));
					r_SetPropertyLock_MaterialSerializedProperty_Boolean.SetBelong(this.instance);
				}
				return r_SetPropertyLock_MaterialSerializedProperty_Boolean;
			}
		}

		/// <summary>
		/// Void ApplyPropertyOverride(UnityEngine.Material, UnityEngine.MaterialSerializedProperty, Boolean)
		/// </summary>
		protected RMethod r_ApplyPropertyOverride_Material_MaterialSerializedProperty_Boolean;
		public virtual RMethod RApplyPropertyOverride_Material_MaterialSerializedProperty_Boolean
		{
			get
			{
				if(r_ApplyPropertyOverride_Material_MaterialSerializedProperty_Boolean == null)
				{
					r_ApplyPropertyOverride_Material_MaterialSerializedProperty_Boolean = new(this, "ApplyPropertyOverride", 0, typeof(UnityEngine.Material),  ReflectionUtils.GetType("UnityEngine.MaterialSerializedProperty"), typeof(System.Boolean));
					r_ApplyPropertyOverride_Material_MaterialSerializedProperty_Boolean.SetBelong(this.instance);
				}
				return r_ApplyPropertyOverride_Material_MaterialSerializedProperty_Boolean;
			}
		}

		/// <summary>
		/// Void RevertPropertyOverride(UnityEngine.MaterialSerializedProperty)
		/// </summary>
		protected RMethod r_RevertPropertyOverride_MaterialSerializedProperty;
		public virtual RMethod RRevertPropertyOverride_MaterialSerializedProperty
		{
			get
			{
				if(r_RevertPropertyOverride_MaterialSerializedProperty == null)
				{
					r_RevertPropertyOverride_MaterialSerializedProperty = new(this, "RevertPropertyOverride", 0,  ReflectionUtils.GetType("UnityEngine.MaterialSerializedProperty"));
					r_RevertPropertyOverride_MaterialSerializedProperty.SetBelong(this.instance);
				}
				return r_RevertPropertyOverride_MaterialSerializedProperty;
			}
		}

		/// <summary>
		/// Void GetPropertyState(UnityEngine.MaterialSerializedProperty, Boolean ByRef, Boolean ByRef, Boolean ByRef)
		/// </summary>
		protected RMethod r_GetPropertyState_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean;
		public virtual RMethod RGetPropertyState_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean
		{
			get
			{
				if(r_GetPropertyState_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean == null)
				{
					r_GetPropertyState_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean = new(this, "GetPropertyState", 0,  ReflectionUtils.GetType("UnityEngine.MaterialSerializedProperty"), typeof(System.Boolean).MakeByRefType(), typeof(System.Boolean).MakeByRefType(), typeof(System.Boolean).MakeByRefType());
					r_GetPropertyState_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean.SetBelong(this.instance);
				}
				return r_GetPropertyState_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean;
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
		/// Void SetColorArray(Int32, UnityEngine.Color[], Int32)
		/// </summary>
		protected RMethod r_SetColorArray_Int32_ColorArray_Int32;
		public virtual RMethod RSetColorArray_Int32_ColorArray_Int32
		{
			get
			{
				if(r_SetColorArray_Int32_ColorArray_Int32 == null)
				{
					r_SetColorArray_Int32_ColorArray_Int32 = new(this, "SetColorArray", 0, typeof(System.Int32), typeof(UnityEngine.Color).MakeArrayType(), typeof(System.Int32));
					r_SetColorArray_Int32_ColorArray_Int32.SetBelong(this.instance);
				}
				return r_SetColorArray_Int32_ColorArray_Int32;
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
		/// Void ExtractColorArray(Int32, System.Collections.Generic.List`1[UnityEngine.Color])
		/// </summary>
		protected RMethod r_ExtractColorArray_Int32_List_d_Color_p_;
		public virtual RMethod RExtractColorArray_Int32_List_d_Color_p_
		{
			get
			{
				if(r_ExtractColorArray_Int32_List_d_Color_p_ == null)
				{
					r_ExtractColorArray_Int32_List_d_Color_p_ = new(this, "ExtractColorArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Color)));
					r_ExtractColorArray_Int32_List_d_Color_p_.SetBelong(this.instance);
				}
				return r_ExtractColorArray_Int32_List_d_Color_p_;
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
		/// Void SetColorArray(System.String, System.Collections.Generic.List`1[UnityEngine.Color])
		/// </summary>
		protected RMethod r_SetColorArray_String_List_d_Color_p_;
		public virtual RMethod RSetColorArray_String_List_d_Color_p_
		{
			get
			{
				if(r_SetColorArray_String_List_d_Color_p_ == null)
				{
					r_SetColorArray_String_List_d_Color_p_ = new(this, "SetColorArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Color)));
					r_SetColorArray_String_List_d_Color_p_.SetBelong(this.instance);
				}
				return r_SetColorArray_String_List_d_Color_p_;
			}
		}

		/// <summary>
		/// Void SetColorArray(Int32, System.Collections.Generic.List`1[UnityEngine.Color])
		/// </summary>
		protected RMethod r_SetColorArray_Int32_List_d_Color_p_;
		public virtual RMethod RSetColorArray_Int32_List_d_Color_p_
		{
			get
			{
				if(r_SetColorArray_Int32_List_d_Color_p_ == null)
				{
					r_SetColorArray_Int32_List_d_Color_p_ = new(this, "SetColorArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Color)));
					r_SetColorArray_Int32_List_d_Color_p_.SetBelong(this.instance);
				}
				return r_SetColorArray_Int32_List_d_Color_p_;
			}
		}

		/// <summary>
		/// Void SetColorArray(System.String, UnityEngine.Color[])
		/// </summary>
		protected RMethod r_SetColorArray_String_ColorArray;
		public virtual RMethod RSetColorArray_String_ColorArray
		{
			get
			{
				if(r_SetColorArray_String_ColorArray == null)
				{
					r_SetColorArray_String_ColorArray = new(this, "SetColorArray", 0, typeof(System.String), typeof(UnityEngine.Color).MakeArrayType());
					r_SetColorArray_String_ColorArray.SetBelong(this.instance);
				}
				return r_SetColorArray_String_ColorArray;
			}
		}

		/// <summary>
		/// Void SetColorArray(Int32, UnityEngine.Color[])
		/// </summary>
		protected RMethod r_SetColorArray_Int32_ColorArray;
		public virtual RMethod RSetColorArray_Int32_ColorArray
		{
			get
			{
				if(r_SetColorArray_Int32_ColorArray == null)
				{
					r_SetColorArray_Int32_ColorArray = new(this, "SetColorArray", 0, typeof(System.Int32), typeof(UnityEngine.Color).MakeArrayType());
					r_SetColorArray_Int32_ColorArray.SetBelong(this.instance);
				}
				return r_SetColorArray_Int32_ColorArray;
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
		/// UnityEngine.GraphicsBufferHandle GetBuffer(System.String)
		/// </summary>
		protected RMethod r_GetBuffer_String;
		public virtual RMethod RGetBuffer_String
		{
			get
			{
				if(r_GetBuffer_String == null)
				{
					r_GetBuffer_String = new(this, "GetBuffer", 0, typeof(System.String));
					r_GetBuffer_String.SetBelong(this.instance);
				}
				return r_GetBuffer_String;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBufferHandle GetConstantBuffer(System.String)
		/// </summary>
		protected RMethod r_GetConstantBuffer_String;
		public virtual RMethod RGetConstantBuffer_String
		{
			get
			{
				if(r_GetConstantBuffer_String == null)
				{
					r_GetConstantBuffer_String = new(this, "GetConstantBuffer", 0, typeof(System.String));
					r_GetConstantBuffer_String.SetBelong(this.instance);
				}
				return r_GetConstantBuffer_String;
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
		/// UnityEngine.Color[] GetColorArray(System.String)
		/// </summary>
		protected RMethod r_GetColorArray_String;
		public virtual RMethod RGetColorArray_String
		{
			get
			{
				if(r_GetColorArray_String == null)
				{
					r_GetColorArray_String = new(this, "GetColorArray", 0, typeof(System.String));
					r_GetColorArray_String.SetBelong(this.instance);
				}
				return r_GetColorArray_String;
			}
		}

		/// <summary>
		/// UnityEngine.Color[] GetColorArray(Int32)
		/// </summary>
		protected RMethod r_GetColorArray_Int32;
		public virtual RMethod RGetColorArray_Int32
		{
			get
			{
				if(r_GetColorArray_Int32 == null)
				{
					r_GetColorArray_Int32 = new(this, "GetColorArray", 0, typeof(System.Int32));
					r_GetColorArray_Int32.SetBelong(this.instance);
				}
				return r_GetColorArray_Int32;
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
		/// Void GetColorArray(System.String, System.Collections.Generic.List`1[UnityEngine.Color])
		/// </summary>
		protected RMethod r_GetColorArray_String_List_d_Color_p_;
		public virtual RMethod RGetColorArray_String_List_d_Color_p_
		{
			get
			{
				if(r_GetColorArray_String_List_d_Color_p_ == null)
				{
					r_GetColorArray_String_List_d_Color_p_ = new(this, "GetColorArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Color)));
					r_GetColorArray_String_List_d_Color_p_.SetBelong(this.instance);
				}
				return r_GetColorArray_String_List_d_Color_p_;
			}
		}

		/// <summary>
		/// Void GetColorArray(Int32, System.Collections.Generic.List`1[UnityEngine.Color])
		/// </summary>
		protected RMethod r_GetColorArray_Int32_List_d_Color_p_;
		public virtual RMethod RGetColorArray_Int32_List_d_Color_p_
		{
			get
			{
				if(r_GetColorArray_Int32_List_d_Color_p_ == null)
				{
					r_GetColorArray_Int32_List_d_Color_p_ = new(this, "GetColorArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Color)));
					r_GetColorArray_Int32_List_d_Color_p_.SetBelong(this.instance);
				}
				return r_GetColorArray_Int32_List_d_Color_p_;
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
		/// Void SetTextureOffset(System.String, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_SetTextureOffset_String_Vector2;
		public virtual RMethod RSetTextureOffset_String_Vector2
		{
			get
			{
				if(r_SetTextureOffset_String_Vector2 == null)
				{
					r_SetTextureOffset_String_Vector2 = new(this, "SetTextureOffset", 0, typeof(System.String), typeof(UnityEngine.Vector2));
					r_SetTextureOffset_String_Vector2.SetBelong(this.instance);
				}
				return r_SetTextureOffset_String_Vector2;
			}
		}

		/// <summary>
		/// Void SetTextureOffset(Int32, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_SetTextureOffset_Int32_Vector2;
		public virtual RMethod RSetTextureOffset_Int32_Vector2
		{
			get
			{
				if(r_SetTextureOffset_Int32_Vector2 == null)
				{
					r_SetTextureOffset_Int32_Vector2 = new(this, "SetTextureOffset", 0, typeof(System.Int32), typeof(UnityEngine.Vector2));
					r_SetTextureOffset_Int32_Vector2.SetBelong(this.instance);
				}
				return r_SetTextureOffset_Int32_Vector2;
			}
		}

		/// <summary>
		/// Void SetTextureScale(System.String, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_SetTextureScale_String_Vector2;
		public virtual RMethod RSetTextureScale_String_Vector2
		{
			get
			{
				if(r_SetTextureScale_String_Vector2 == null)
				{
					r_SetTextureScale_String_Vector2 = new(this, "SetTextureScale", 0, typeof(System.String), typeof(UnityEngine.Vector2));
					r_SetTextureScale_String_Vector2.SetBelong(this.instance);
				}
				return r_SetTextureScale_String_Vector2;
			}
		}

		/// <summary>
		/// Void SetTextureScale(Int32, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_SetTextureScale_Int32_Vector2;
		public virtual RMethod RSetTextureScale_Int32_Vector2
		{
			get
			{
				if(r_SetTextureScale_Int32_Vector2 == null)
				{
					r_SetTextureScale_Int32_Vector2 = new(this, "SetTextureScale", 0, typeof(System.Int32), typeof(UnityEngine.Vector2));
					r_SetTextureScale_Int32_Vector2.SetBelong(this.instance);
				}
				return r_SetTextureScale_Int32_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetTextureOffset(System.String)
		/// </summary>
		protected RMethod r_GetTextureOffset_String;
		public virtual RMethod RGetTextureOffset_String
		{
			get
			{
				if(r_GetTextureOffset_String == null)
				{
					r_GetTextureOffset_String = new(this, "GetTextureOffset", 0, typeof(System.String));
					r_GetTextureOffset_String.SetBelong(this.instance);
				}
				return r_GetTextureOffset_String;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetTextureOffset(Int32)
		/// </summary>
		protected RMethod r_GetTextureOffset_Int32;
		public virtual RMethod RGetTextureOffset_Int32
		{
			get
			{
				if(r_GetTextureOffset_Int32 == null)
				{
					r_GetTextureOffset_Int32 = new(this, "GetTextureOffset", 0, typeof(System.Int32));
					r_GetTextureOffset_Int32.SetBelong(this.instance);
				}
				return r_GetTextureOffset_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetTextureScale(System.String)
		/// </summary>
		protected RMethod r_GetTextureScale_String;
		public virtual RMethod RGetTextureScale_String
		{
			get
			{
				if(r_GetTextureScale_String == null)
				{
					r_GetTextureScale_String = new(this, "GetTextureScale", 0, typeof(System.String));
					r_GetTextureScale_String.SetBelong(this.instance);
				}
				return r_GetTextureScale_String;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetTextureScale(Int32)
		/// </summary>
		protected RMethod r_GetTextureScale_Int32;
		public virtual RMethod RGetTextureScale_Int32
		{
			get
			{
				if(r_GetTextureScale_Int32 == null)
				{
					r_GetTextureScale_Int32 = new(this, "GetTextureScale", 0, typeof(System.Int32));
					r_GetTextureScale_Int32.SetBelong(this.instance);
				}
				return r_GetTextureScale_Int32;
			}
		}

		/// <summary>
		/// System.String[] GetPropertyNames(UnityEngine.MaterialPropertyType)
		/// </summary>
		protected RMethod r_GetPropertyNames_MaterialPropertyType;
		public virtual RMethod RGetPropertyNames_MaterialPropertyType
		{
			get
			{
				if(r_GetPropertyNames_MaterialPropertyType == null)
				{
					r_GetPropertyNames_MaterialPropertyType = new(this, "GetPropertyNames", 0, typeof(UnityEngine.MaterialPropertyType));
					r_GetPropertyNames_MaterialPropertyType.SetBelong(this.instance);
				}
				return r_GetPropertyNames_MaterialPropertyType;
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
		/// Void GetBufferImpl_Injected(Int32, UnityEngine.GraphicsBufferHandle ByRef)
		/// </summary>
		protected RMethod r_GetBufferImpl_Injected_Int32_Out_GraphicsBufferHandle;
		public virtual RMethod RGetBufferImpl_Injected_Int32_Out_GraphicsBufferHandle
		{
			get
			{
				if(r_GetBufferImpl_Injected_Int32_Out_GraphicsBufferHandle == null)
				{
					r_GetBufferImpl_Injected_Int32_Out_GraphicsBufferHandle = new(this, "GetBufferImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBufferHandle).MakeByRefType());
					r_GetBufferImpl_Injected_Int32_Out_GraphicsBufferHandle.SetBelong(this.instance);
				}
				return r_GetBufferImpl_Injected_Int32_Out_GraphicsBufferHandle;
			}
		}

		/// <summary>
		/// Void GetConstantBufferImpl_Injected(Int32, UnityEngine.GraphicsBufferHandle ByRef)
		/// </summary>
		protected RMethod r_GetConstantBufferImpl_Injected_Int32_Out_GraphicsBufferHandle;
		public virtual RMethod RGetConstantBufferImpl_Injected_Int32_Out_GraphicsBufferHandle
		{
			get
			{
				if(r_GetConstantBufferImpl_Injected_Int32_Out_GraphicsBufferHandle == null)
				{
					r_GetConstantBufferImpl_Injected_Int32_Out_GraphicsBufferHandle = new(this, "GetConstantBufferImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBufferHandle).MakeByRefType());
					r_GetConstantBufferImpl_Injected_Int32_Out_GraphicsBufferHandle.SetBelong(this.instance);
				}
				return r_GetConstantBufferImpl_Injected_Int32_Out_GraphicsBufferHandle;
			}
		}

		/// <summary>
		/// Void GetTextureScaleAndOffsetImpl_Injected(Int32, UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_GetTextureScaleAndOffsetImpl_Injected_Int32_Out_Vector4;
		public virtual RMethod RGetTextureScaleAndOffsetImpl_Injected_Int32_Out_Vector4
		{
			get
			{
				if(r_GetTextureScaleAndOffsetImpl_Injected_Int32_Out_Vector4 == null)
				{
					r_GetTextureScaleAndOffsetImpl_Injected_Int32_Out_Vector4 = new(this, "GetTextureScaleAndOffsetImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeByRefType());
					r_GetTextureScaleAndOffsetImpl_Injected_Int32_Out_Vector4.SetBelong(this.instance);
				}
				return r_GetTextureScaleAndOffsetImpl_Injected_Int32_Out_Vector4;
			}
		}

		/// <summary>
		/// Void SetTextureOffsetImpl_Injected(Int32, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_SetTextureOffsetImpl_Injected_Int32_Ref_Vector2;
		public virtual RMethod RSetTextureOffsetImpl_Injected_Int32_Ref_Vector2
		{
			get
			{
				if(r_SetTextureOffsetImpl_Injected_Int32_Ref_Vector2 == null)
				{
					r_SetTextureOffsetImpl_Injected_Int32_Ref_Vector2 = new(this, "SetTextureOffsetImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Vector2).MakeByRefType());
					r_SetTextureOffsetImpl_Injected_Int32_Ref_Vector2.SetBelong(this.instance);
				}
				return r_SetTextureOffsetImpl_Injected_Int32_Ref_Vector2;
			}
		}

		/// <summary>
		/// Void SetTextureScaleImpl_Injected(Int32, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_SetTextureScaleImpl_Injected_Int32_Ref_Vector2;
		public virtual RMethod RSetTextureScaleImpl_Injected_Int32_Ref_Vector2
		{
			get
			{
				if(r_SetTextureScaleImpl_Injected_Int32_Ref_Vector2 == null)
				{
					r_SetTextureScaleImpl_Injected_Int32_Ref_Vector2 = new(this, "SetTextureScaleImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Vector2).MakeByRefType());
					r_SetTextureScaleImpl_Injected_Int32_Ref_Vector2.SetBelong(this.instance);
				}
				return r_SetTextureScaleImpl_Injected_Int32_Ref_Vector2;
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


        public RMaterial() : base("UnityEngine.Material")
        {
        }

        public RMaterial(System.Object instance) : base("UnityEngine.Material")
		{
            SetInstance(instance);
		}

        public RMaterial(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMaterial(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEngine.Material Create(System.String  @scriptContents)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scriptContents};
            var ___result = RCreate_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Material)___result;
        }


        public static void CreateWithShader(UnityEngine.Material  @self, UnityEngine.Shader  @shader)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @shader};
            var ___result = RCreateWithShader_Material_Shader.Invoke(___genericsType, ___parameters);

            
        }


        public static void CreateWithMaterial(UnityEngine.Material  @self, UnityEngine.Material  @source)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @source};
            var ___result = RCreateWithMaterial_Material_Material.Invoke(___genericsType, ___parameters);

            
        }


        public static void CreateWithString(UnityEngine.Material  @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RCreateWithString_Material.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Material GetDefaultMaterial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDefaultMaterial.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Material)___result;
        }


        public static UnityEngine.Material GetDefaultParticleMaterial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDefaultParticleMaterial.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Material)___result;
        }


        public static UnityEngine.Material GetDefaultLineMaterial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDefaultLineMaterial.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Material)___result;
        }


        public virtual System.Int32 GetFirstPropertyNameIdByAttribute(UnityEngine.Rendering.ShaderPropertyFlags  @attributeFlag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeFlag};
            var ___result = RGetFirstPropertyNameIdByAttribute_ShaderPropertyFlags.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean HasProperty(System.Int32  @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RHasProperty_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasProperty(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RHasProperty_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasFloatImpl(System.Int32  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RHasFloatImpl_Int32.Invoke(___genericsType, ___parameters);

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


        public virtual System.Boolean HasIntImpl(System.Int32  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RHasIntImpl_Int32.Invoke(___genericsType, ___parameters);

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


        public virtual System.Boolean HasTextureImpl(System.Int32  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RHasTextureImpl_Int32.Invoke(___genericsType, ___parameters);

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


        public virtual System.Boolean HasMatrixImpl(System.Int32  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RHasMatrixImpl_Int32.Invoke(___genericsType, ___parameters);

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


        public virtual System.Boolean HasVectorImpl(System.Int32  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RHasVectorImpl_Int32.Invoke(___genericsType, ___parameters);

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


        public virtual System.Boolean HasBufferImpl(System.Int32  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RHasBufferImpl_Int32.Invoke(___genericsType, ___parameters);

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


        public virtual System.Boolean HasConstantBufferImpl(System.Int32  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RHasConstantBufferImpl_Int32.Invoke(___genericsType, ___parameters);

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


        public virtual void SetShaderPassEnabled(System.String  @passName, System.Boolean  @enabled)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@passName, @enabled};
            var ___result = RSetShaderPassEnabled_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean GetShaderPassEnabled(System.String  @passName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@passName};
            var ___result = RGetShaderPassEnabled_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String GetPassName(System.Int32  @pass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pass};
            var ___result = RGetPassName_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 FindPass(System.String  @passName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@passName};
            var ___result = RFindPass_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void SetOverrideTag(System.String  @tag, System.String  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag, @val};
            var ___result = RSetOverrideTag_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetTagImpl(System.String  @tag, System.Boolean  @currentSubShaderOnly, System.String  @defaultValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag, @currentSubShaderOnly, @defaultValue};
            var ___result = RGetTagImpl_String_Boolean_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetTag(System.String  @tag, System.Boolean  @searchFallbacks, System.String  @defaultValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag, @searchFallbacks, @defaultValue};
            var ___result = RGetTag_String_Boolean_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetTag(System.String  @tag, System.Boolean  @searchFallbacks)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag, @searchFallbacks};
            var ___result = RGetTag_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Lerp(UnityEngine.Material  @start, UnityEngine.Material  @end, System.Single  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @end, @t};
            var ___result = RLerp_Material_Material_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SetPass(System.Int32  @pass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pass};
            var ___result = RSetPass_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CopyPropertiesFromMaterial(UnityEngine.Material  @mat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mat};
            var ___result = RCopyPropertiesFromMaterial_Material.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.String[] GetPropertyNamesImpl(System.Int32  @propertyType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyType};
            var ___result = RGetPropertyNamesImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.Int32 ComputeCRC()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RComputeCRC.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String[] GetTexturePropertyNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTexturePropertyNames.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.Int32[] GetTexturePropertyNameIDs()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTexturePropertyNameIDs.Invoke(___genericsType, ___parameters);

            return (System.Int32[])___result;
        }


        public virtual void GetTexturePropertyNamesInternal(System.Object  @outNames)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outNames};
            var ___result = RGetTexturePropertyNamesInternal_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTexturePropertyNameIDsInternal(System.Object  @outNames)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outNames};
            var ___result = RGetTexturePropertyNameIDsInternal_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTexturePropertyNames(System.Collections.Generic.List<System.String>  @outNames)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outNames};
            var ___result = RGetTexturePropertyNames_List_d_String_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTexturePropertyNameIDs(System.Collections.Generic.List<System.Int32>  @outNames)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outNames};
            var ___result = RGetTexturePropertyNameIDs_List_d_Int32_p_.Invoke(___genericsType, ___parameters);

            
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


        public virtual UnityEngine.GraphicsBufferHandle GetBufferImpl(System.Int32  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetBufferImpl_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GraphicsBufferHandle)___result;
        }


        public virtual UnityEngine.GraphicsBufferHandle GetConstantBufferImpl(System.Int32  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetConstantBufferImpl_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GraphicsBufferHandle)___result;
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


        public virtual void SetColorArrayImpl(System.Int32  @name, UnityEngine.Color[]  @values, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values, @count};
            var ___result = RSetColorArrayImpl_Int32_ColorArray_Int32.Invoke(___genericsType, ___parameters);

            
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


        public virtual UnityEngine.Color[] GetColorArrayImpl(System.Int32  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetColorArrayImpl_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color[])___result;
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


        public virtual System.Int32 GetColorArrayCountImpl(System.Int32  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetColorArrayCountImpl_Int32.Invoke(___genericsType, ___parameters);

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


        public virtual void ExtractColorArrayImpl(System.Int32  @name, UnityEngine.Color[]  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RExtractColorArrayImpl_Int32_ColorArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExtractMatrixArrayImpl(System.Int32  @name, UnityEngine.Matrix4x4[]  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RExtractMatrixArrayImpl_Int32_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector4 GetTextureScaleAndOffsetImpl(System.Int32  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetTextureScaleAndOffsetImpl_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public virtual void SetTextureOffsetImpl(System.Int32  @name, UnityEngine.Vector2  @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @offset};
            var ___result = RSetTextureOffsetImpl_Int32_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTextureScaleImpl(System.Int32  @name, UnityEngine.Vector2  @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @scale};
            var ___result = RSetTextureScaleImpl_Int32_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsChildOf(UnityEngine.Material  @ancestor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ancestor};
            var ___result = RIsChildOf_Material.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void RevertAllPropertyOverrides()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRevertAllPropertyOverrides.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsPropertyOverriden(System.Int32  @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RIsPropertyOverriden_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsPropertyLocked(System.Int32  @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RIsPropertyLocked_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsPropertyLockedByAncestor(System.Int32  @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RIsPropertyLockedByAncestor_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsPropertyOverriden(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RIsPropertyOverriden_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsPropertyLocked(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RIsPropertyLocked_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsPropertyLockedByAncestor(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RIsPropertyLockedByAncestor_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetPropertyLock(System.Int32  @nameID, System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetPropertyLock_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyOverride(UnityEngine.Material  @destination, System.Int32  @nameID, System.Boolean  @recordUndo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination, @nameID, @recordUndo};
            var ___result = RApplyPropertyOverride_Material_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RevertPropertyOverride(System.Int32  @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RRevertPropertyOverride_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetPropertyState(System.Int32  @nameID, out System.Boolean  @isOverriden, out System.Boolean  @isLockedInChildren, out System.Boolean  @isLockedByAncestor)
        {
			isOverriden = default;
			isLockedInChildren = default;
			isLockedByAncestor = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @isOverriden, @isLockedInChildren, @isLockedByAncestor};
            var ___result = RGetPropertyState_Int32_Out_Boolean_Out_Boolean_Out_Boolean.Invoke(___genericsType, ___parameters);
			isOverriden = (System.Boolean)___parameters[1];
			isLockedInChildren = (System.Boolean)___parameters[2];
			isLockedByAncestor = (System.Boolean)___parameters[3];

            
        }


        public virtual void SetPropertyLock(System.String  @name, System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetPropertyLock_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyOverride(UnityEngine.Material  @destination, System.String  @name, System.Boolean  @recordUndo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination, @name, @recordUndo};
            var ___result = RApplyPropertyOverride_Material_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RevertPropertyOverride(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RRevertPropertyOverride_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPropertyLock_Serialized(RType  @property, System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property.Value, @value};
            var ___result = RSetPropertyLock_Serialized_MaterialSerializedProperty_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyOverride_Serialized(UnityEngine.Material  @destination, RType  @property, System.Boolean  @recordUndo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination, @property.Value, @recordUndo};
            var ___result = RApplyPropertyOverride_Serialized_Material_MaterialSerializedProperty_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RevertPropertyOverride_Serialized(RType  @property)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property.Value};
            var ___result = RRevertPropertyOverride_Serialized_MaterialSerializedProperty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetPropertyState_Serialized(RType  @property, out System.Boolean  @isOverriden, out System.Boolean  @isLockedInChildren, out System.Boolean  @isLockedByAncestor)
        {
			isOverriden = default;
			isLockedInChildren = default;
			isLockedByAncestor = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property.Value, @isOverriden, @isLockedInChildren, @isLockedByAncestor};
            var ___result = RGetPropertyState_Serialized_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean.Invoke(___genericsType, ___parameters);
			isOverriden = (System.Boolean)___parameters[1];
			isLockedInChildren = (System.Boolean)___parameters[2];
			isLockedByAncestor = (System.Boolean)___parameters[3];

            
        }


        public virtual void SetPropertyLock(RType  @property, System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property.Value, @value};
            var ___result = RSetPropertyLock_MaterialSerializedProperty_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyOverride(UnityEngine.Material  @destination, RType  @property, System.Boolean  @recordUndo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination, @property.Value, @recordUndo};
            var ___result = RApplyPropertyOverride_Material_MaterialSerializedProperty_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RevertPropertyOverride(RType  @property)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property.Value};
            var ___result = RRevertPropertyOverride_MaterialSerializedProperty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetPropertyState(RType  @propertyName, out System.Boolean  @isOverriden, out System.Boolean  @isLockedInChildren, out System.Boolean  @isLockedByAncestor)
        {
			isOverriden = default;
			isLockedInChildren = default;
			isLockedByAncestor = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName.Value, @isOverriden, @isLockedInChildren, @isLockedByAncestor};
            var ___result = RGetPropertyState_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean.Invoke(___genericsType, ___parameters);
			isOverriden = (System.Boolean)___parameters[1];
			isLockedInChildren = (System.Boolean)___parameters[2];
			isLockedByAncestor = (System.Boolean)___parameters[3];

            
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


        public virtual void SetColorArray(System.Int32  @name, UnityEngine.Color[]  @values, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values, @count};
            var ___result = RSetColorArray_Int32_ColorArray_Int32.Invoke(___genericsType, ___parameters);

            
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


        public virtual void ExtractColorArray(System.Int32  @name, System.Collections.Generic.List<UnityEngine.Color>  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RExtractColorArray_Int32_List_d_Color_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExtractMatrixArray(System.Int32  @name, System.Collections.Generic.List<UnityEngine.Matrix4x4>  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RExtractMatrixArray_Int32_List_d_Matrix4x4_p_.Invoke(___genericsType, ___parameters);

            
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


        public virtual void SetColorArray(System.String  @name, System.Collections.Generic.List<UnityEngine.Color>  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RSetColorArray_String_List_d_Color_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColorArray(System.Int32  @nameID, System.Collections.Generic.List<UnityEngine.Color>  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetColorArray_Int32_List_d_Color_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColorArray(System.String  @name, UnityEngine.Color[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RSetColorArray_String_ColorArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColorArray(System.Int32  @nameID, UnityEngine.Color[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetColorArray_Int32_ColorArray.Invoke(___genericsType, ___parameters);

            
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


        public virtual UnityEngine.GraphicsBufferHandle GetBuffer(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetBuffer_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GraphicsBufferHandle)___result;
        }


        public virtual UnityEngine.GraphicsBufferHandle GetConstantBuffer(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetConstantBuffer_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GraphicsBufferHandle)___result;
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


        public virtual UnityEngine.Color[] GetColorArray(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetColorArray_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color[])___result;
        }


        public virtual UnityEngine.Color[] GetColorArray(System.Int32  @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RGetColorArray_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color[])___result;
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


        public virtual void GetColorArray(System.String  @name, System.Collections.Generic.List<UnityEngine.Color>  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RGetColorArray_String_List_d_Color_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetColorArray(System.Int32  @nameID, System.Collections.Generic.List<UnityEngine.Color>  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RGetColorArray_Int32_List_d_Color_p_.Invoke(___genericsType, ___parameters);

            
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


        public virtual void SetTextureOffset(System.String  @name, UnityEngine.Vector2  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetTextureOffset_String_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTextureOffset(System.Int32  @nameID, UnityEngine.Vector2  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetTextureOffset_Int32_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTextureScale(System.String  @name, UnityEngine.Vector2  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetTextureScale_String_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTextureScale(System.Int32  @nameID, UnityEngine.Vector2  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetTextureScale_Int32_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector2 GetTextureOffset(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetTextureOffset_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual UnityEngine.Vector2 GetTextureOffset(System.Int32  @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RGetTextureOffset_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual UnityEngine.Vector2 GetTextureScale(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetTextureScale_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual UnityEngine.Vector2 GetTextureScale(System.Int32  @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RGetTextureScale_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual System.String[] GetPropertyNames(UnityEngine.MaterialPropertyType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetPropertyNames_MaterialPropertyType.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
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


        public virtual void GetBufferImpl_Injected(System.Int32  @name, out UnityEngine.GraphicsBufferHandle  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @ret};
            var ___result = RGetBufferImpl_Injected_Int32_Out_GraphicsBufferHandle.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.GraphicsBufferHandle)___parameters[1];

            
        }


        public virtual void GetConstantBufferImpl_Injected(System.Int32  @name, out UnityEngine.GraphicsBufferHandle  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @ret};
            var ___result = RGetConstantBufferImpl_Injected_Int32_Out_GraphicsBufferHandle.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.GraphicsBufferHandle)___parameters[1];

            
        }


        public virtual void GetTextureScaleAndOffsetImpl_Injected(System.Int32  @name, out UnityEngine.Vector4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @ret};
            var ___result = RGetTextureScaleAndOffsetImpl_Injected_Int32_Out_Vector4.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector4)___parameters[1];

            
        }


        public virtual void SetTextureOffsetImpl_Injected(System.Int32  @name, ref UnityEngine.Vector2  @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @offset};
            var ___result = RSetTextureOffsetImpl_Injected_Int32_Ref_Vector2.Invoke(___genericsType, ___parameters);
			offset = (UnityEngine.Vector2)___parameters[1];

            
        }


        public virtual void SetTextureScaleImpl_Injected(System.Int32  @name, ref UnityEngine.Vector2  @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @scale};
            var ___result = RSetTextureScaleImpl_Injected_Int32_Ref_Vector2.Invoke(___genericsType, ___parameters);
			scale = (UnityEngine.Vector2)___parameters[1];

            
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
