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
		protected static RMethod r_RCreate_String;
		public static RMethod RCreate_String
		{
			get
			{
				if(r_RCreate_String == null)
				{
					r_RCreate_String = new(typeof(UnityEngine.Material), "Create", 0, typeof(System.String));
					r_RCreate_String.SetBelong(null);
				}
				return r_RCreate_String;
			}
		}

		/// <summary>
		/// Void CreateWithShader(UnityEngine.Material, UnityEngine.Shader)
		/// </summary>
		protected static RMethod r_RCreateWithShader_Material_Shader;
		public static RMethod RCreateWithShader_Material_Shader
		{
			get
			{
				if(r_RCreateWithShader_Material_Shader == null)
				{
					r_RCreateWithShader_Material_Shader = new(typeof(UnityEngine.Material), "CreateWithShader", 0, typeof(UnityEngine.Material), typeof(UnityEngine.Shader));
					r_RCreateWithShader_Material_Shader.SetBelong(null);
				}
				return r_RCreateWithShader_Material_Shader;
			}
		}

		/// <summary>
		/// Void CreateWithMaterial(UnityEngine.Material, UnityEngine.Material)
		/// </summary>
		protected static RMethod r_RCreateWithMaterial_Material_Material;
		public static RMethod RCreateWithMaterial_Material_Material
		{
			get
			{
				if(r_RCreateWithMaterial_Material_Material == null)
				{
					r_RCreateWithMaterial_Material_Material = new(typeof(UnityEngine.Material), "CreateWithMaterial", 0, typeof(UnityEngine.Material), typeof(UnityEngine.Material));
					r_RCreateWithMaterial_Material_Material.SetBelong(null);
				}
				return r_RCreateWithMaterial_Material_Material;
			}
		}

		/// <summary>
		/// Void CreateWithString(UnityEngine.Material)
		/// </summary>
		protected static RMethod r_RCreateWithString_Material;
		public static RMethod RCreateWithString_Material
		{
			get
			{
				if(r_RCreateWithString_Material == null)
				{
					r_RCreateWithString_Material = new(typeof(UnityEngine.Material), "CreateWithString", 0, typeof(UnityEngine.Material));
					r_RCreateWithString_Material.SetBelong(null);
				}
				return r_RCreateWithString_Material;
			}
		}

		/// <summary>
		/// UnityEngine.Material GetDefaultMaterial()
		/// </summary>
		protected static RMethod r_RGetDefaultMaterial;
		public static RMethod RGetDefaultMaterial
		{
			get
			{
				if(r_RGetDefaultMaterial == null)
				{
					r_RGetDefaultMaterial = new(typeof(UnityEngine.Material), "GetDefaultMaterial", 0);
					r_RGetDefaultMaterial.SetBelong(null);
				}
				return r_RGetDefaultMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.Material GetDefaultParticleMaterial()
		/// </summary>
		protected static RMethod r_RGetDefaultParticleMaterial;
		public static RMethod RGetDefaultParticleMaterial
		{
			get
			{
				if(r_RGetDefaultParticleMaterial == null)
				{
					r_RGetDefaultParticleMaterial = new(typeof(UnityEngine.Material), "GetDefaultParticleMaterial", 0);
					r_RGetDefaultParticleMaterial.SetBelong(null);
				}
				return r_RGetDefaultParticleMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.Material GetDefaultLineMaterial()
		/// </summary>
		protected static RMethod r_RGetDefaultLineMaterial;
		public static RMethod RGetDefaultLineMaterial
		{
			get
			{
				if(r_RGetDefaultLineMaterial == null)
				{
					r_RGetDefaultLineMaterial = new(typeof(UnityEngine.Material), "GetDefaultLineMaterial", 0);
					r_RGetDefaultLineMaterial.SetBelong(null);
				}
				return r_RGetDefaultLineMaterial;
			}
		}

		/// <summary>
		/// Int32 GetFirstPropertyNameIdByAttribute(UnityEngine.Rendering.ShaderPropertyFlags)
		/// </summary>
		protected RMethod r_RGetFirstPropertyNameIdByAttribute_ShaderPropertyFlags;
		public virtual RMethod RGetFirstPropertyNameIdByAttribute_ShaderPropertyFlags
		{
			get
			{
				if(r_RGetFirstPropertyNameIdByAttribute_ShaderPropertyFlags == null)
				{
					r_RGetFirstPropertyNameIdByAttribute_ShaderPropertyFlags = new(this, "GetFirstPropertyNameIdByAttribute", 0, typeof(UnityEngine.Rendering.ShaderPropertyFlags));
					r_RGetFirstPropertyNameIdByAttribute_ShaderPropertyFlags.SetBelong(this.instance);
				}
				return r_RGetFirstPropertyNameIdByAttribute_ShaderPropertyFlags;
			}
		}

		/// <summary>
		/// Boolean HasProperty(Int32)
		/// </summary>
		protected RMethod r_RHasProperty_Int32;
		public virtual RMethod RHasProperty_Int32
		{
			get
			{
				if(r_RHasProperty_Int32 == null)
				{
					r_RHasProperty_Int32 = new(this, "HasProperty", 0, typeof(System.Int32));
					r_RHasProperty_Int32.SetBelong(this.instance);
				}
				return r_RHasProperty_Int32;
			}
		}

		/// <summary>
		/// Boolean HasProperty(System.String)
		/// </summary>
		protected RMethod r_RHasProperty_String;
		public virtual RMethod RHasProperty_String
		{
			get
			{
				if(r_RHasProperty_String == null)
				{
					r_RHasProperty_String = new(this, "HasProperty", 0, typeof(System.String));
					r_RHasProperty_String.SetBelong(this.instance);
				}
				return r_RHasProperty_String;
			}
		}

		/// <summary>
		/// Boolean HasFloatImpl(Int32)
		/// </summary>
		protected RMethod r_RHasFloatImpl_Int32;
		public virtual RMethod RHasFloatImpl_Int32
		{
			get
			{
				if(r_RHasFloatImpl_Int32 == null)
				{
					r_RHasFloatImpl_Int32 = new(this, "HasFloatImpl", 0, typeof(System.Int32));
					r_RHasFloatImpl_Int32.SetBelong(this.instance);
				}
				return r_RHasFloatImpl_Int32;
			}
		}

		/// <summary>
		/// Boolean HasFloat(System.String)
		/// </summary>
		protected RMethod r_RHasFloat_String;
		public virtual RMethod RHasFloat_String
		{
			get
			{
				if(r_RHasFloat_String == null)
				{
					r_RHasFloat_String = new(this, "HasFloat", 0, typeof(System.String));
					r_RHasFloat_String.SetBelong(this.instance);
				}
				return r_RHasFloat_String;
			}
		}

		/// <summary>
		/// Boolean HasFloat(Int32)
		/// </summary>
		protected RMethod r_RHasFloat_Int32;
		public virtual RMethod RHasFloat_Int32
		{
			get
			{
				if(r_RHasFloat_Int32 == null)
				{
					r_RHasFloat_Int32 = new(this, "HasFloat", 0, typeof(System.Int32));
					r_RHasFloat_Int32.SetBelong(this.instance);
				}
				return r_RHasFloat_Int32;
			}
		}

		/// <summary>
		/// Boolean HasInt(System.String)
		/// </summary>
		protected RMethod r_RHasInt_String;
		public virtual RMethod RHasInt_String
		{
			get
			{
				if(r_RHasInt_String == null)
				{
					r_RHasInt_String = new(this, "HasInt", 0, typeof(System.String));
					r_RHasInt_String.SetBelong(this.instance);
				}
				return r_RHasInt_String;
			}
		}

		/// <summary>
		/// Boolean HasInt(Int32)
		/// </summary>
		protected RMethod r_RHasInt_Int32;
		public virtual RMethod RHasInt_Int32
		{
			get
			{
				if(r_RHasInt_Int32 == null)
				{
					r_RHasInt_Int32 = new(this, "HasInt", 0, typeof(System.Int32));
					r_RHasInt_Int32.SetBelong(this.instance);
				}
				return r_RHasInt_Int32;
			}
		}

		/// <summary>
		/// Boolean HasIntImpl(Int32)
		/// </summary>
		protected RMethod r_RHasIntImpl_Int32;
		public virtual RMethod RHasIntImpl_Int32
		{
			get
			{
				if(r_RHasIntImpl_Int32 == null)
				{
					r_RHasIntImpl_Int32 = new(this, "HasIntImpl", 0, typeof(System.Int32));
					r_RHasIntImpl_Int32.SetBelong(this.instance);
				}
				return r_RHasIntImpl_Int32;
			}
		}

		/// <summary>
		/// Boolean HasInteger(System.String)
		/// </summary>
		protected RMethod r_RHasInteger_String;
		public virtual RMethod RHasInteger_String
		{
			get
			{
				if(r_RHasInteger_String == null)
				{
					r_RHasInteger_String = new(this, "HasInteger", 0, typeof(System.String));
					r_RHasInteger_String.SetBelong(this.instance);
				}
				return r_RHasInteger_String;
			}
		}

		/// <summary>
		/// Boolean HasInteger(Int32)
		/// </summary>
		protected RMethod r_RHasInteger_Int32;
		public virtual RMethod RHasInteger_Int32
		{
			get
			{
				if(r_RHasInteger_Int32 == null)
				{
					r_RHasInteger_Int32 = new(this, "HasInteger", 0, typeof(System.Int32));
					r_RHasInteger_Int32.SetBelong(this.instance);
				}
				return r_RHasInteger_Int32;
			}
		}

		/// <summary>
		/// Boolean HasTextureImpl(Int32)
		/// </summary>
		protected RMethod r_RHasTextureImpl_Int32;
		public virtual RMethod RHasTextureImpl_Int32
		{
			get
			{
				if(r_RHasTextureImpl_Int32 == null)
				{
					r_RHasTextureImpl_Int32 = new(this, "HasTextureImpl", 0, typeof(System.Int32));
					r_RHasTextureImpl_Int32.SetBelong(this.instance);
				}
				return r_RHasTextureImpl_Int32;
			}
		}

		/// <summary>
		/// Boolean HasTexture(System.String)
		/// </summary>
		protected RMethod r_RHasTexture_String;
		public virtual RMethod RHasTexture_String
		{
			get
			{
				if(r_RHasTexture_String == null)
				{
					r_RHasTexture_String = new(this, "HasTexture", 0, typeof(System.String));
					r_RHasTexture_String.SetBelong(this.instance);
				}
				return r_RHasTexture_String;
			}
		}

		/// <summary>
		/// Boolean HasTexture(Int32)
		/// </summary>
		protected RMethod r_RHasTexture_Int32;
		public virtual RMethod RHasTexture_Int32
		{
			get
			{
				if(r_RHasTexture_Int32 == null)
				{
					r_RHasTexture_Int32 = new(this, "HasTexture", 0, typeof(System.Int32));
					r_RHasTexture_Int32.SetBelong(this.instance);
				}
				return r_RHasTexture_Int32;
			}
		}

		/// <summary>
		/// Boolean HasMatrixImpl(Int32)
		/// </summary>
		protected RMethod r_RHasMatrixImpl_Int32;
		public virtual RMethod RHasMatrixImpl_Int32
		{
			get
			{
				if(r_RHasMatrixImpl_Int32 == null)
				{
					r_RHasMatrixImpl_Int32 = new(this, "HasMatrixImpl", 0, typeof(System.Int32));
					r_RHasMatrixImpl_Int32.SetBelong(this.instance);
				}
				return r_RHasMatrixImpl_Int32;
			}
		}

		/// <summary>
		/// Boolean HasMatrix(System.String)
		/// </summary>
		protected RMethod r_RHasMatrix_String;
		public virtual RMethod RHasMatrix_String
		{
			get
			{
				if(r_RHasMatrix_String == null)
				{
					r_RHasMatrix_String = new(this, "HasMatrix", 0, typeof(System.String));
					r_RHasMatrix_String.SetBelong(this.instance);
				}
				return r_RHasMatrix_String;
			}
		}

		/// <summary>
		/// Boolean HasMatrix(Int32)
		/// </summary>
		protected RMethod r_RHasMatrix_Int32;
		public virtual RMethod RHasMatrix_Int32
		{
			get
			{
				if(r_RHasMatrix_Int32 == null)
				{
					r_RHasMatrix_Int32 = new(this, "HasMatrix", 0, typeof(System.Int32));
					r_RHasMatrix_Int32.SetBelong(this.instance);
				}
				return r_RHasMatrix_Int32;
			}
		}

		/// <summary>
		/// Boolean HasVectorImpl(Int32)
		/// </summary>
		protected RMethod r_RHasVectorImpl_Int32;
		public virtual RMethod RHasVectorImpl_Int32
		{
			get
			{
				if(r_RHasVectorImpl_Int32 == null)
				{
					r_RHasVectorImpl_Int32 = new(this, "HasVectorImpl", 0, typeof(System.Int32));
					r_RHasVectorImpl_Int32.SetBelong(this.instance);
				}
				return r_RHasVectorImpl_Int32;
			}
		}

		/// <summary>
		/// Boolean HasVector(System.String)
		/// </summary>
		protected RMethod r_RHasVector_String;
		public virtual RMethod RHasVector_String
		{
			get
			{
				if(r_RHasVector_String == null)
				{
					r_RHasVector_String = new(this, "HasVector", 0, typeof(System.String));
					r_RHasVector_String.SetBelong(this.instance);
				}
				return r_RHasVector_String;
			}
		}

		/// <summary>
		/// Boolean HasVector(Int32)
		/// </summary>
		protected RMethod r_RHasVector_Int32;
		public virtual RMethod RHasVector_Int32
		{
			get
			{
				if(r_RHasVector_Int32 == null)
				{
					r_RHasVector_Int32 = new(this, "HasVector", 0, typeof(System.Int32));
					r_RHasVector_Int32.SetBelong(this.instance);
				}
				return r_RHasVector_Int32;
			}
		}

		/// <summary>
		/// Boolean HasColor(System.String)
		/// </summary>
		protected RMethod r_RHasColor_String;
		public virtual RMethod RHasColor_String
		{
			get
			{
				if(r_RHasColor_String == null)
				{
					r_RHasColor_String = new(this, "HasColor", 0, typeof(System.String));
					r_RHasColor_String.SetBelong(this.instance);
				}
				return r_RHasColor_String;
			}
		}

		/// <summary>
		/// Boolean HasColor(Int32)
		/// </summary>
		protected RMethod r_RHasColor_Int32;
		public virtual RMethod RHasColor_Int32
		{
			get
			{
				if(r_RHasColor_Int32 == null)
				{
					r_RHasColor_Int32 = new(this, "HasColor", 0, typeof(System.Int32));
					r_RHasColor_Int32.SetBelong(this.instance);
				}
				return r_RHasColor_Int32;
			}
		}

		/// <summary>
		/// Boolean HasBufferImpl(Int32)
		/// </summary>
		protected RMethod r_RHasBufferImpl_Int32;
		public virtual RMethod RHasBufferImpl_Int32
		{
			get
			{
				if(r_RHasBufferImpl_Int32 == null)
				{
					r_RHasBufferImpl_Int32 = new(this, "HasBufferImpl", 0, typeof(System.Int32));
					r_RHasBufferImpl_Int32.SetBelong(this.instance);
				}
				return r_RHasBufferImpl_Int32;
			}
		}

		/// <summary>
		/// Boolean HasBuffer(System.String)
		/// </summary>
		protected RMethod r_RHasBuffer_String;
		public virtual RMethod RHasBuffer_String
		{
			get
			{
				if(r_RHasBuffer_String == null)
				{
					r_RHasBuffer_String = new(this, "HasBuffer", 0, typeof(System.String));
					r_RHasBuffer_String.SetBelong(this.instance);
				}
				return r_RHasBuffer_String;
			}
		}

		/// <summary>
		/// Boolean HasBuffer(Int32)
		/// </summary>
		protected RMethod r_RHasBuffer_Int32;
		public virtual RMethod RHasBuffer_Int32
		{
			get
			{
				if(r_RHasBuffer_Int32 == null)
				{
					r_RHasBuffer_Int32 = new(this, "HasBuffer", 0, typeof(System.Int32));
					r_RHasBuffer_Int32.SetBelong(this.instance);
				}
				return r_RHasBuffer_Int32;
			}
		}

		/// <summary>
		/// Boolean HasConstantBufferImpl(Int32)
		/// </summary>
		protected RMethod r_RHasConstantBufferImpl_Int32;
		public virtual RMethod RHasConstantBufferImpl_Int32
		{
			get
			{
				if(r_RHasConstantBufferImpl_Int32 == null)
				{
					r_RHasConstantBufferImpl_Int32 = new(this, "HasConstantBufferImpl", 0, typeof(System.Int32));
					r_RHasConstantBufferImpl_Int32.SetBelong(this.instance);
				}
				return r_RHasConstantBufferImpl_Int32;
			}
		}

		/// <summary>
		/// Boolean HasConstantBuffer(System.String)
		/// </summary>
		protected RMethod r_RHasConstantBuffer_String;
		public virtual RMethod RHasConstantBuffer_String
		{
			get
			{
				if(r_RHasConstantBuffer_String == null)
				{
					r_RHasConstantBuffer_String = new(this, "HasConstantBuffer", 0, typeof(System.String));
					r_RHasConstantBuffer_String.SetBelong(this.instance);
				}
				return r_RHasConstantBuffer_String;
			}
		}

		/// <summary>
		/// Boolean HasConstantBuffer(Int32)
		/// </summary>
		protected RMethod r_RHasConstantBuffer_Int32;
		public virtual RMethod RHasConstantBuffer_Int32
		{
			get
			{
				if(r_RHasConstantBuffer_Int32 == null)
				{
					r_RHasConstantBuffer_Int32 = new(this, "HasConstantBuffer", 0, typeof(System.Int32));
					r_RHasConstantBuffer_Int32.SetBelong(this.instance);
				}
				return r_RHasConstantBuffer_Int32;
			}
		}

		/// <summary>
		/// Void EnableKeyword(System.String)
		/// </summary>
		protected RMethod r_REnableKeyword_String;
		public virtual RMethod REnableKeyword_String
		{
			get
			{
				if(r_REnableKeyword_String == null)
				{
					r_REnableKeyword_String = new(this, "EnableKeyword", 0, typeof(System.String));
					r_REnableKeyword_String.SetBelong(this.instance);
				}
				return r_REnableKeyword_String;
			}
		}

		/// <summary>
		/// Void DisableKeyword(System.String)
		/// </summary>
		protected RMethod r_RDisableKeyword_String;
		public virtual RMethod RDisableKeyword_String
		{
			get
			{
				if(r_RDisableKeyword_String == null)
				{
					r_RDisableKeyword_String = new(this, "DisableKeyword", 0, typeof(System.String));
					r_RDisableKeyword_String.SetBelong(this.instance);
				}
				return r_RDisableKeyword_String;
			}
		}

		/// <summary>
		/// Boolean IsKeywordEnabled(System.String)
		/// </summary>
		protected RMethod r_RIsKeywordEnabled_String;
		public virtual RMethod RIsKeywordEnabled_String
		{
			get
			{
				if(r_RIsKeywordEnabled_String == null)
				{
					r_RIsKeywordEnabled_String = new(this, "IsKeywordEnabled", 0, typeof(System.String));
					r_RIsKeywordEnabled_String.SetBelong(this.instance);
				}
				return r_RIsKeywordEnabled_String;
			}
		}

		/// <summary>
		/// Void EnableLocalKeyword(UnityEngine.Rendering.LocalKeyword)
		/// </summary>
		protected RMethod r_REnableLocalKeyword_LocalKeyword;
		public virtual RMethod REnableLocalKeyword_LocalKeyword
		{
			get
			{
				if(r_REnableLocalKeyword_LocalKeyword == null)
				{
					r_REnableLocalKeyword_LocalKeyword = new(this, "EnableLocalKeyword", 0, typeof(UnityEngine.Rendering.LocalKeyword));
					r_REnableLocalKeyword_LocalKeyword.SetBelong(this.instance);
				}
				return r_REnableLocalKeyword_LocalKeyword;
			}
		}

		/// <summary>
		/// Void DisableLocalKeyword(UnityEngine.Rendering.LocalKeyword)
		/// </summary>
		protected RMethod r_RDisableLocalKeyword_LocalKeyword;
		public virtual RMethod RDisableLocalKeyword_LocalKeyword
		{
			get
			{
				if(r_RDisableLocalKeyword_LocalKeyword == null)
				{
					r_RDisableLocalKeyword_LocalKeyword = new(this, "DisableLocalKeyword", 0, typeof(UnityEngine.Rendering.LocalKeyword));
					r_RDisableLocalKeyword_LocalKeyword.SetBelong(this.instance);
				}
				return r_RDisableLocalKeyword_LocalKeyword;
			}
		}

		/// <summary>
		/// Void SetLocalKeyword(UnityEngine.Rendering.LocalKeyword, Boolean)
		/// </summary>
		protected RMethod r_RSetLocalKeyword_LocalKeyword_Boolean;
		public virtual RMethod RSetLocalKeyword_LocalKeyword_Boolean
		{
			get
			{
				if(r_RSetLocalKeyword_LocalKeyword_Boolean == null)
				{
					r_RSetLocalKeyword_LocalKeyword_Boolean = new(this, "SetLocalKeyword", 0, typeof(UnityEngine.Rendering.LocalKeyword), typeof(System.Boolean));
					r_RSetLocalKeyword_LocalKeyword_Boolean.SetBelong(this.instance);
				}
				return r_RSetLocalKeyword_LocalKeyword_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsLocalKeywordEnabled(UnityEngine.Rendering.LocalKeyword)
		/// </summary>
		protected RMethod r_RIsLocalKeywordEnabled_LocalKeyword;
		public virtual RMethod RIsLocalKeywordEnabled_LocalKeyword
		{
			get
			{
				if(r_RIsLocalKeywordEnabled_LocalKeyword == null)
				{
					r_RIsLocalKeywordEnabled_LocalKeyword = new(this, "IsLocalKeywordEnabled", 0, typeof(UnityEngine.Rendering.LocalKeyword));
					r_RIsLocalKeywordEnabled_LocalKeyword.SetBelong(this.instance);
				}
				return r_RIsLocalKeywordEnabled_LocalKeyword;
			}
		}

		/// <summary>
		/// Void EnableKeyword(UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_REnableKeyword_In_LocalKeyword;
		public virtual RMethod REnableKeyword_In_LocalKeyword
		{
			get
			{
				if(r_REnableKeyword_In_LocalKeyword == null)
				{
					r_REnableKeyword_In_LocalKeyword = new(this, "EnableKeyword", 0, typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
					r_REnableKeyword_In_LocalKeyword.SetBelong(this.instance);
				}
				return r_REnableKeyword_In_LocalKeyword;
			}
		}

		/// <summary>
		/// Void DisableKeyword(UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_RDisableKeyword_In_LocalKeyword;
		public virtual RMethod RDisableKeyword_In_LocalKeyword
		{
			get
			{
				if(r_RDisableKeyword_In_LocalKeyword == null)
				{
					r_RDisableKeyword_In_LocalKeyword = new(this, "DisableKeyword", 0, typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
					r_RDisableKeyword_In_LocalKeyword.SetBelong(this.instance);
				}
				return r_RDisableKeyword_In_LocalKeyword;
			}
		}

		/// <summary>
		/// Void SetKeyword(UnityEngine.Rendering.LocalKeyword ByRef, Boolean)
		/// </summary>
		protected RMethod r_RSetKeyword_In_LocalKeyword_Boolean;
		public virtual RMethod RSetKeyword_In_LocalKeyword_Boolean
		{
			get
			{
				if(r_RSetKeyword_In_LocalKeyword_Boolean == null)
				{
					r_RSetKeyword_In_LocalKeyword_Boolean = new(this, "SetKeyword", 0, typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType(), typeof(System.Boolean));
					r_RSetKeyword_In_LocalKeyword_Boolean.SetBelong(this.instance);
				}
				return r_RSetKeyword_In_LocalKeyword_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsKeywordEnabled(UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_RIsKeywordEnabled_In_LocalKeyword;
		public virtual RMethod RIsKeywordEnabled_In_LocalKeyword
		{
			get
			{
				if(r_RIsKeywordEnabled_In_LocalKeyword == null)
				{
					r_RIsKeywordEnabled_In_LocalKeyword = new(this, "IsKeywordEnabled", 0, typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
					r_RIsKeywordEnabled_In_LocalKeyword.SetBelong(this.instance);
				}
				return r_RIsKeywordEnabled_In_LocalKeyword;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.LocalKeyword[] GetEnabledKeywords()
		/// </summary>
		protected RMethod r_RGetEnabledKeywords;
		public virtual RMethod RGetEnabledKeywords
		{
			get
			{
				if(r_RGetEnabledKeywords == null)
				{
					r_RGetEnabledKeywords = new(this, "GetEnabledKeywords", 0);
					r_RGetEnabledKeywords.SetBelong(this.instance);
				}
				return r_RGetEnabledKeywords;
			}
		}

		/// <summary>
		/// Void SetEnabledKeywords(UnityEngine.Rendering.LocalKeyword[])
		/// </summary>
		protected RMethod r_RSetEnabledKeywords_LocalKeywordArray;
		public virtual RMethod RSetEnabledKeywords_LocalKeywordArray
		{
			get
			{
				if(r_RSetEnabledKeywords_LocalKeywordArray == null)
				{
					r_RSetEnabledKeywords_LocalKeywordArray = new(this, "SetEnabledKeywords", 0, typeof(UnityEngine.Rendering.LocalKeyword).MakeArrayType());
					r_RSetEnabledKeywords_LocalKeywordArray.SetBelong(this.instance);
				}
				return r_RSetEnabledKeywords_LocalKeywordArray;
			}
		}

		/// <summary>
		/// Void SetShaderPassEnabled(System.String, Boolean)
		/// </summary>
		protected RMethod r_RSetShaderPassEnabled_String_Boolean;
		public virtual RMethod RSetShaderPassEnabled_String_Boolean
		{
			get
			{
				if(r_RSetShaderPassEnabled_String_Boolean == null)
				{
					r_RSetShaderPassEnabled_String_Boolean = new(this, "SetShaderPassEnabled", 0, typeof(System.String), typeof(System.Boolean));
					r_RSetShaderPassEnabled_String_Boolean.SetBelong(this.instance);
				}
				return r_RSetShaderPassEnabled_String_Boolean;
			}
		}

		/// <summary>
		/// Boolean GetShaderPassEnabled(System.String)
		/// </summary>
		protected RMethod r_RGetShaderPassEnabled_String;
		public virtual RMethod RGetShaderPassEnabled_String
		{
			get
			{
				if(r_RGetShaderPassEnabled_String == null)
				{
					r_RGetShaderPassEnabled_String = new(this, "GetShaderPassEnabled", 0, typeof(System.String));
					r_RGetShaderPassEnabled_String.SetBelong(this.instance);
				}
				return r_RGetShaderPassEnabled_String;
			}
		}

		/// <summary>
		/// System.String GetPassName(Int32)
		/// </summary>
		protected RMethod r_RGetPassName_Int32;
		public virtual RMethod RGetPassName_Int32
		{
			get
			{
				if(r_RGetPassName_Int32 == null)
				{
					r_RGetPassName_Int32 = new(this, "GetPassName", 0, typeof(System.Int32));
					r_RGetPassName_Int32.SetBelong(this.instance);
				}
				return r_RGetPassName_Int32;
			}
		}

		/// <summary>
		/// Int32 FindPass(System.String)
		/// </summary>
		protected RMethod r_RFindPass_String;
		public virtual RMethod RFindPass_String
		{
			get
			{
				if(r_RFindPass_String == null)
				{
					r_RFindPass_String = new(this, "FindPass", 0, typeof(System.String));
					r_RFindPass_String.SetBelong(this.instance);
				}
				return r_RFindPass_String;
			}
		}

		/// <summary>
		/// Void SetOverrideTag(System.String, System.String)
		/// </summary>
		protected RMethod r_RSetOverrideTag_String_String;
		public virtual RMethod RSetOverrideTag_String_String
		{
			get
			{
				if(r_RSetOverrideTag_String_String == null)
				{
					r_RSetOverrideTag_String_String = new(this, "SetOverrideTag", 0, typeof(System.String), typeof(System.String));
					r_RSetOverrideTag_String_String.SetBelong(this.instance);
				}
				return r_RSetOverrideTag_String_String;
			}
		}

		/// <summary>
		/// System.String GetTagImpl(System.String, Boolean, System.String)
		/// </summary>
		protected RMethod r_RGetTagImpl_String_Boolean_String;
		public virtual RMethod RGetTagImpl_String_Boolean_String
		{
			get
			{
				if(r_RGetTagImpl_String_Boolean_String == null)
				{
					r_RGetTagImpl_String_Boolean_String = new(this, "GetTagImpl", 0, typeof(System.String), typeof(System.Boolean), typeof(System.String));
					r_RGetTagImpl_String_Boolean_String.SetBelong(this.instance);
				}
				return r_RGetTagImpl_String_Boolean_String;
			}
		}

		/// <summary>
		/// System.String GetTag(System.String, Boolean, System.String)
		/// </summary>
		protected RMethod r_RGetTag_String_Boolean_String;
		public virtual RMethod RGetTag_String_Boolean_String
		{
			get
			{
				if(r_RGetTag_String_Boolean_String == null)
				{
					r_RGetTag_String_Boolean_String = new(this, "GetTag", 0, typeof(System.String), typeof(System.Boolean), typeof(System.String));
					r_RGetTag_String_Boolean_String.SetBelong(this.instance);
				}
				return r_RGetTag_String_Boolean_String;
			}
		}

		/// <summary>
		/// System.String GetTag(System.String, Boolean)
		/// </summary>
		protected RMethod r_RGetTag_String_Boolean;
		public virtual RMethod RGetTag_String_Boolean
		{
			get
			{
				if(r_RGetTag_String_Boolean == null)
				{
					r_RGetTag_String_Boolean = new(this, "GetTag", 0, typeof(System.String), typeof(System.Boolean));
					r_RGetTag_String_Boolean.SetBelong(this.instance);
				}
				return r_RGetTag_String_Boolean;
			}
		}

		/// <summary>
		/// Void Lerp(UnityEngine.Material, UnityEngine.Material, Single)
		/// </summary>
		protected RMethod r_RLerp_Material_Material_Single;
		public virtual RMethod RLerp_Material_Material_Single
		{
			get
			{
				if(r_RLerp_Material_Material_Single == null)
				{
					r_RLerp_Material_Material_Single = new(this, "Lerp", 0, typeof(UnityEngine.Material), typeof(UnityEngine.Material), typeof(System.Single));
					r_RLerp_Material_Material_Single.SetBelong(this.instance);
				}
				return r_RLerp_Material_Material_Single;
			}
		}

		/// <summary>
		/// Boolean SetPass(Int32)
		/// </summary>
		protected RMethod r_RSetPass_Int32;
		public virtual RMethod RSetPass_Int32
		{
			get
			{
				if(r_RSetPass_Int32 == null)
				{
					r_RSetPass_Int32 = new(this, "SetPass", 0, typeof(System.Int32));
					r_RSetPass_Int32.SetBelong(this.instance);
				}
				return r_RSetPass_Int32;
			}
		}

		/// <summary>
		/// Void CopyPropertiesFromMaterial(UnityEngine.Material)
		/// </summary>
		protected RMethod r_RCopyPropertiesFromMaterial_Material;
		public virtual RMethod RCopyPropertiesFromMaterial_Material
		{
			get
			{
				if(r_RCopyPropertiesFromMaterial_Material == null)
				{
					r_RCopyPropertiesFromMaterial_Material = new(this, "CopyPropertiesFromMaterial", 0, typeof(UnityEngine.Material));
					r_RCopyPropertiesFromMaterial_Material.SetBelong(this.instance);
				}
				return r_RCopyPropertiesFromMaterial_Material;
			}
		}

		/// <summary>
		/// System.String[] GetShaderKeywords()
		/// </summary>
		protected RMethod r_RGetShaderKeywords;
		public virtual RMethod RGetShaderKeywords
		{
			get
			{
				if(r_RGetShaderKeywords == null)
				{
					r_RGetShaderKeywords = new(this, "GetShaderKeywords", 0);
					r_RGetShaderKeywords.SetBelong(this.instance);
				}
				return r_RGetShaderKeywords;
			}
		}

		/// <summary>
		/// Void SetShaderKeywords(System.String[])
		/// </summary>
		protected RMethod r_RSetShaderKeywords_StringArray;
		public virtual RMethod RSetShaderKeywords_StringArray
		{
			get
			{
				if(r_RSetShaderKeywords_StringArray == null)
				{
					r_RSetShaderKeywords_StringArray = new(this, "SetShaderKeywords", 0, typeof(System.String).MakeArrayType());
					r_RSetShaderKeywords_StringArray.SetBelong(this.instance);
				}
				return r_RSetShaderKeywords_StringArray;
			}
		}

		/// <summary>
		/// System.String[] GetPropertyNamesImpl(Int32)
		/// </summary>
		protected RMethod r_RGetPropertyNamesImpl_Int32;
		public virtual RMethod RGetPropertyNamesImpl_Int32
		{
			get
			{
				if(r_RGetPropertyNamesImpl_Int32 == null)
				{
					r_RGetPropertyNamesImpl_Int32 = new(this, "GetPropertyNamesImpl", 0, typeof(System.Int32));
					r_RGetPropertyNamesImpl_Int32.SetBelong(this.instance);
				}
				return r_RGetPropertyNamesImpl_Int32;
			}
		}

		/// <summary>
		/// Int32 ComputeCRC()
		/// </summary>
		protected RMethod r_RComputeCRC;
		public virtual RMethod RComputeCRC
		{
			get
			{
				if(r_RComputeCRC == null)
				{
					r_RComputeCRC = new(this, "ComputeCRC", 0);
					r_RComputeCRC.SetBelong(this.instance);
				}
				return r_RComputeCRC;
			}
		}

		/// <summary>
		/// System.String[] GetTexturePropertyNames()
		/// </summary>
		protected RMethod r_RGetTexturePropertyNames;
		public virtual RMethod RGetTexturePropertyNames
		{
			get
			{
				if(r_RGetTexturePropertyNames == null)
				{
					r_RGetTexturePropertyNames = new(this, "GetTexturePropertyNames", 0);
					r_RGetTexturePropertyNames.SetBelong(this.instance);
				}
				return r_RGetTexturePropertyNames;
			}
		}

		/// <summary>
		/// Int32[] GetTexturePropertyNameIDs()
		/// </summary>
		protected RMethod r_RGetTexturePropertyNameIDs;
		public virtual RMethod RGetTexturePropertyNameIDs
		{
			get
			{
				if(r_RGetTexturePropertyNameIDs == null)
				{
					r_RGetTexturePropertyNameIDs = new(this, "GetTexturePropertyNameIDs", 0);
					r_RGetTexturePropertyNameIDs.SetBelong(this.instance);
				}
				return r_RGetTexturePropertyNameIDs;
			}
		}

		/// <summary>
		/// Void GetTexturePropertyNamesInternal(System.Object)
		/// </summary>
		protected RMethod r_RGetTexturePropertyNamesInternal_Object;
		public virtual RMethod RGetTexturePropertyNamesInternal_Object
		{
			get
			{
				if(r_RGetTexturePropertyNamesInternal_Object == null)
				{
					r_RGetTexturePropertyNamesInternal_Object = new(this, "GetTexturePropertyNamesInternal", 0, typeof(System.Object));
					r_RGetTexturePropertyNamesInternal_Object.SetBelong(this.instance);
				}
				return r_RGetTexturePropertyNamesInternal_Object;
			}
		}

		/// <summary>
		/// Void GetTexturePropertyNameIDsInternal(System.Object)
		/// </summary>
		protected RMethod r_RGetTexturePropertyNameIDsInternal_Object;
		public virtual RMethod RGetTexturePropertyNameIDsInternal_Object
		{
			get
			{
				if(r_RGetTexturePropertyNameIDsInternal_Object == null)
				{
					r_RGetTexturePropertyNameIDsInternal_Object = new(this, "GetTexturePropertyNameIDsInternal", 0, typeof(System.Object));
					r_RGetTexturePropertyNameIDsInternal_Object.SetBelong(this.instance);
				}
				return r_RGetTexturePropertyNameIDsInternal_Object;
			}
		}

		/// <summary>
		/// Void GetTexturePropertyNames(System.Collections.Generic.List`1[System.String])
		/// </summary>
		protected RMethod r_RGetTexturePropertyNames_List_d_String_p_;
		public virtual RMethod RGetTexturePropertyNames_List_d_String_p_
		{
			get
			{
				if(r_RGetTexturePropertyNames_List_d_String_p_ == null)
				{
					r_RGetTexturePropertyNames_List_d_String_p_ = new(this, "GetTexturePropertyNames", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.String)));
					r_RGetTexturePropertyNames_List_d_String_p_.SetBelong(this.instance);
				}
				return r_RGetTexturePropertyNames_List_d_String_p_;
			}
		}

		/// <summary>
		/// Void GetTexturePropertyNameIDs(System.Collections.Generic.List`1[System.Int32])
		/// </summary>
		protected RMethod r_RGetTexturePropertyNameIDs_List_d_Int32_p_;
		public virtual RMethod RGetTexturePropertyNameIDs_List_d_Int32_p_
		{
			get
			{
				if(r_RGetTexturePropertyNameIDs_List_d_Int32_p_ == null)
				{
					r_RGetTexturePropertyNameIDs_List_d_Int32_p_ = new(this, "GetTexturePropertyNameIDs", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)));
					r_RGetTexturePropertyNameIDs_List_d_Int32_p_.SetBelong(this.instance);
				}
				return r_RGetTexturePropertyNameIDs_List_d_Int32_p_;
			}
		}

		/// <summary>
		/// Void SetIntImpl(Int32, Int32)
		/// </summary>
		protected RMethod r_RSetIntImpl_Int32_Int32;
		public virtual RMethod RSetIntImpl_Int32_Int32
		{
			get
			{
				if(r_RSetIntImpl_Int32_Int32 == null)
				{
					r_RSetIntImpl_Int32_Int32 = new(this, "SetIntImpl", 0, typeof(System.Int32), typeof(System.Int32));
					r_RSetIntImpl_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetIntImpl_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetFloatImpl(Int32, Single)
		/// </summary>
		protected RMethod r_RSetFloatImpl_Int32_Single;
		public virtual RMethod RSetFloatImpl_Int32_Single
		{
			get
			{
				if(r_RSetFloatImpl_Int32_Single == null)
				{
					r_RSetFloatImpl_Int32_Single = new(this, "SetFloatImpl", 0, typeof(System.Int32), typeof(System.Single));
					r_RSetFloatImpl_Int32_Single.SetBelong(this.instance);
				}
				return r_RSetFloatImpl_Int32_Single;
			}
		}

		/// <summary>
		/// Void SetColorImpl(Int32, UnityEngine.Color)
		/// </summary>
		protected RMethod r_RSetColorImpl_Int32_Color;
		public virtual RMethod RSetColorImpl_Int32_Color
		{
			get
			{
				if(r_RSetColorImpl_Int32_Color == null)
				{
					r_RSetColorImpl_Int32_Color = new(this, "SetColorImpl", 0, typeof(System.Int32), typeof(UnityEngine.Color));
					r_RSetColorImpl_Int32_Color.SetBelong(this.instance);
				}
				return r_RSetColorImpl_Int32_Color;
			}
		}

		/// <summary>
		/// Void SetMatrixImpl(Int32, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_RSetMatrixImpl_Int32_Matrix4x4;
		public virtual RMethod RSetMatrixImpl_Int32_Matrix4x4
		{
			get
			{
				if(r_RSetMatrixImpl_Int32_Matrix4x4 == null)
				{
					r_RSetMatrixImpl_Int32_Matrix4x4 = new(this, "SetMatrixImpl", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4));
					r_RSetMatrixImpl_Int32_Matrix4x4.SetBelong(this.instance);
				}
				return r_RSetMatrixImpl_Int32_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetTextureImpl(Int32, UnityEngine.Texture)
		/// </summary>
		protected RMethod r_RSetTextureImpl_Int32_Texture;
		public virtual RMethod RSetTextureImpl_Int32_Texture
		{
			get
			{
				if(r_RSetTextureImpl_Int32_Texture == null)
				{
					r_RSetTextureImpl_Int32_Texture = new(this, "SetTextureImpl", 0, typeof(System.Int32), typeof(UnityEngine.Texture));
					r_RSetTextureImpl_Int32_Texture.SetBelong(this.instance);
				}
				return r_RSetTextureImpl_Int32_Texture;
			}
		}

		/// <summary>
		/// Void SetRenderTextureImpl(Int32, UnityEngine.RenderTexture, UnityEngine.Rendering.RenderTextureSubElement)
		/// </summary>
		protected RMethod r_RSetRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement;
		public virtual RMethod RSetRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement
		{
			get
			{
				if(r_RSetRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement == null)
				{
					r_RSetRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement = new(this, "SetRenderTextureImpl", 0, typeof(System.Int32), typeof(UnityEngine.RenderTexture), typeof(UnityEngine.Rendering.RenderTextureSubElement));
					r_RSetRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement.SetBelong(this.instance);
				}
				return r_RSetRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement;
			}
		}

		/// <summary>
		/// Void SetBufferImpl(Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_RSetBufferImpl_Int32_ComputeBuffer;
		public virtual RMethod RSetBufferImpl_Int32_ComputeBuffer
		{
			get
			{
				if(r_RSetBufferImpl_Int32_ComputeBuffer == null)
				{
					r_RSetBufferImpl_Int32_ComputeBuffer = new(this, "SetBufferImpl", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
					r_RSetBufferImpl_Int32_ComputeBuffer.SetBelong(this.instance);
				}
				return r_RSetBufferImpl_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetGraphicsBufferImpl(Int32, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_RSetGraphicsBufferImpl_Int32_GraphicsBuffer;
		public virtual RMethod RSetGraphicsBufferImpl_Int32_GraphicsBuffer
		{
			get
			{
				if(r_RSetGraphicsBufferImpl_Int32_GraphicsBuffer == null)
				{
					r_RSetGraphicsBufferImpl_Int32_GraphicsBuffer = new(this, "SetGraphicsBufferImpl", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer));
					r_RSetGraphicsBufferImpl_Int32_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_RSetGraphicsBufferImpl_Int32_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetConstantBufferImpl(Int32, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32;
		public virtual RMethod RSetConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_RSetConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32 == null)
				{
					r_RSetConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32 = new(this, "SetConstantBufferImpl", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
					r_RSetConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetConstantGraphicsBufferImpl(Int32, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32;
		public virtual RMethod RSetConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_RSetConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32 == null)
				{
					r_RSetConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32 = new(this, "SetConstantGraphicsBufferImpl", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
					r_RSetConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetIntImpl(Int32)
		/// </summary>
		protected RMethod r_RGetIntImpl_Int32;
		public virtual RMethod RGetIntImpl_Int32
		{
			get
			{
				if(r_RGetIntImpl_Int32 == null)
				{
					r_RGetIntImpl_Int32 = new(this, "GetIntImpl", 0, typeof(System.Int32));
					r_RGetIntImpl_Int32.SetBelong(this.instance);
				}
				return r_RGetIntImpl_Int32;
			}
		}

		/// <summary>
		/// Single GetFloatImpl(Int32)
		/// </summary>
		protected RMethod r_RGetFloatImpl_Int32;
		public virtual RMethod RGetFloatImpl_Int32
		{
			get
			{
				if(r_RGetFloatImpl_Int32 == null)
				{
					r_RGetFloatImpl_Int32 = new(this, "GetFloatImpl", 0, typeof(System.Int32));
					r_RGetFloatImpl_Int32.SetBelong(this.instance);
				}
				return r_RGetFloatImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetColorImpl(Int32)
		/// </summary>
		protected RMethod r_RGetColorImpl_Int32;
		public virtual RMethod RGetColorImpl_Int32
		{
			get
			{
				if(r_RGetColorImpl_Int32 == null)
				{
					r_RGetColorImpl_Int32 = new(this, "GetColorImpl", 0, typeof(System.Int32));
					r_RGetColorImpl_Int32.SetBelong(this.instance);
				}
				return r_RGetColorImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 GetMatrixImpl(Int32)
		/// </summary>
		protected RMethod r_RGetMatrixImpl_Int32;
		public virtual RMethod RGetMatrixImpl_Int32
		{
			get
			{
				if(r_RGetMatrixImpl_Int32 == null)
				{
					r_RGetMatrixImpl_Int32 = new(this, "GetMatrixImpl", 0, typeof(System.Int32));
					r_RGetMatrixImpl_Int32.SetBelong(this.instance);
				}
				return r_RGetMatrixImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Texture GetTextureImpl(Int32)
		/// </summary>
		protected RMethod r_RGetTextureImpl_Int32;
		public virtual RMethod RGetTextureImpl_Int32
		{
			get
			{
				if(r_RGetTextureImpl_Int32 == null)
				{
					r_RGetTextureImpl_Int32 = new(this, "GetTextureImpl", 0, typeof(System.Int32));
					r_RGetTextureImpl_Int32.SetBelong(this.instance);
				}
				return r_RGetTextureImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBufferHandle GetBufferImpl(Int32)
		/// </summary>
		protected RMethod r_RGetBufferImpl_Int32;
		public virtual RMethod RGetBufferImpl_Int32
		{
			get
			{
				if(r_RGetBufferImpl_Int32 == null)
				{
					r_RGetBufferImpl_Int32 = new(this, "GetBufferImpl", 0, typeof(System.Int32));
					r_RGetBufferImpl_Int32.SetBelong(this.instance);
				}
				return r_RGetBufferImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBufferHandle GetConstantBufferImpl(Int32)
		/// </summary>
		protected RMethod r_RGetConstantBufferImpl_Int32;
		public virtual RMethod RGetConstantBufferImpl_Int32
		{
			get
			{
				if(r_RGetConstantBufferImpl_Int32 == null)
				{
					r_RGetConstantBufferImpl_Int32 = new(this, "GetConstantBufferImpl", 0, typeof(System.Int32));
					r_RGetConstantBufferImpl_Int32.SetBelong(this.instance);
				}
				return r_RGetConstantBufferImpl_Int32;
			}
		}

		/// <summary>
		/// Void SetFloatArrayImpl(Int32, Single[], Int32)
		/// </summary>
		protected RMethod r_RSetFloatArrayImpl_Int32_SingleArray_Int32;
		public virtual RMethod RSetFloatArrayImpl_Int32_SingleArray_Int32
		{
			get
			{
				if(r_RSetFloatArrayImpl_Int32_SingleArray_Int32 == null)
				{
					r_RSetFloatArrayImpl_Int32_SingleArray_Int32 = new(this, "SetFloatArrayImpl", 0, typeof(System.Int32), typeof(System.Single).MakeArrayType(), typeof(System.Int32));
					r_RSetFloatArrayImpl_Int32_SingleArray_Int32.SetBelong(this.instance);
				}
				return r_RSetFloatArrayImpl_Int32_SingleArray_Int32;
			}
		}

		/// <summary>
		/// Void SetVectorArrayImpl(Int32, UnityEngine.Vector4[], Int32)
		/// </summary>
		protected RMethod r_RSetVectorArrayImpl_Int32_Vector4Array_Int32;
		public virtual RMethod RSetVectorArrayImpl_Int32_Vector4Array_Int32
		{
			get
			{
				if(r_RSetVectorArrayImpl_Int32_Vector4Array_Int32 == null)
				{
					r_RSetVectorArrayImpl_Int32_Vector4Array_Int32 = new(this, "SetVectorArrayImpl", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType(), typeof(System.Int32));
					r_RSetVectorArrayImpl_Int32_Vector4Array_Int32.SetBelong(this.instance);
				}
				return r_RSetVectorArrayImpl_Int32_Vector4Array_Int32;
			}
		}

		/// <summary>
		/// Void SetColorArrayImpl(Int32, UnityEngine.Color[], Int32)
		/// </summary>
		protected RMethod r_RSetColorArrayImpl_Int32_ColorArray_Int32;
		public virtual RMethod RSetColorArrayImpl_Int32_ColorArray_Int32
		{
			get
			{
				if(r_RSetColorArrayImpl_Int32_ColorArray_Int32 == null)
				{
					r_RSetColorArrayImpl_Int32_ColorArray_Int32 = new(this, "SetColorArrayImpl", 0, typeof(System.Int32), typeof(UnityEngine.Color).MakeArrayType(), typeof(System.Int32));
					r_RSetColorArrayImpl_Int32_ColorArray_Int32.SetBelong(this.instance);
				}
				return r_RSetColorArrayImpl_Int32_ColorArray_Int32;
			}
		}

		/// <summary>
		/// Void SetMatrixArrayImpl(Int32, UnityEngine.Matrix4x4[], Int32)
		/// </summary>
		protected RMethod r_RSetMatrixArrayImpl_Int32_Matrix4x4Array_Int32;
		public virtual RMethod RSetMatrixArrayImpl_Int32_Matrix4x4Array_Int32
		{
			get
			{
				if(r_RSetMatrixArrayImpl_Int32_Matrix4x4Array_Int32 == null)
				{
					r_RSetMatrixArrayImpl_Int32_Matrix4x4Array_Int32 = new(this, "SetMatrixArrayImpl", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType(), typeof(System.Int32));
					r_RSetMatrixArrayImpl_Int32_Matrix4x4Array_Int32.SetBelong(this.instance);
				}
				return r_RSetMatrixArrayImpl_Int32_Matrix4x4Array_Int32;
			}
		}

		/// <summary>
		/// Single[] GetFloatArrayImpl(Int32)
		/// </summary>
		protected RMethod r_RGetFloatArrayImpl_Int32;
		public virtual RMethod RGetFloatArrayImpl_Int32
		{
			get
			{
				if(r_RGetFloatArrayImpl_Int32 == null)
				{
					r_RGetFloatArrayImpl_Int32 = new(this, "GetFloatArrayImpl", 0, typeof(System.Int32));
					r_RGetFloatArrayImpl_Int32.SetBelong(this.instance);
				}
				return r_RGetFloatArrayImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4[] GetVectorArrayImpl(Int32)
		/// </summary>
		protected RMethod r_RGetVectorArrayImpl_Int32;
		public virtual RMethod RGetVectorArrayImpl_Int32
		{
			get
			{
				if(r_RGetVectorArrayImpl_Int32 == null)
				{
					r_RGetVectorArrayImpl_Int32 = new(this, "GetVectorArrayImpl", 0, typeof(System.Int32));
					r_RGetVectorArrayImpl_Int32.SetBelong(this.instance);
				}
				return r_RGetVectorArrayImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color[] GetColorArrayImpl(Int32)
		/// </summary>
		protected RMethod r_RGetColorArrayImpl_Int32;
		public virtual RMethod RGetColorArrayImpl_Int32
		{
			get
			{
				if(r_RGetColorArrayImpl_Int32 == null)
				{
					r_RGetColorArrayImpl_Int32 = new(this, "GetColorArrayImpl", 0, typeof(System.Int32));
					r_RGetColorArrayImpl_Int32.SetBelong(this.instance);
				}
				return r_RGetColorArrayImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4[] GetMatrixArrayImpl(Int32)
		/// </summary>
		protected RMethod r_RGetMatrixArrayImpl_Int32;
		public virtual RMethod RGetMatrixArrayImpl_Int32
		{
			get
			{
				if(r_RGetMatrixArrayImpl_Int32 == null)
				{
					r_RGetMatrixArrayImpl_Int32 = new(this, "GetMatrixArrayImpl", 0, typeof(System.Int32));
					r_RGetMatrixArrayImpl_Int32.SetBelong(this.instance);
				}
				return r_RGetMatrixArrayImpl_Int32;
			}
		}

		/// <summary>
		/// Int32 GetFloatArrayCountImpl(Int32)
		/// </summary>
		protected RMethod r_RGetFloatArrayCountImpl_Int32;
		public virtual RMethod RGetFloatArrayCountImpl_Int32
		{
			get
			{
				if(r_RGetFloatArrayCountImpl_Int32 == null)
				{
					r_RGetFloatArrayCountImpl_Int32 = new(this, "GetFloatArrayCountImpl", 0, typeof(System.Int32));
					r_RGetFloatArrayCountImpl_Int32.SetBelong(this.instance);
				}
				return r_RGetFloatArrayCountImpl_Int32;
			}
		}

		/// <summary>
		/// Int32 GetVectorArrayCountImpl(Int32)
		/// </summary>
		protected RMethod r_RGetVectorArrayCountImpl_Int32;
		public virtual RMethod RGetVectorArrayCountImpl_Int32
		{
			get
			{
				if(r_RGetVectorArrayCountImpl_Int32 == null)
				{
					r_RGetVectorArrayCountImpl_Int32 = new(this, "GetVectorArrayCountImpl", 0, typeof(System.Int32));
					r_RGetVectorArrayCountImpl_Int32.SetBelong(this.instance);
				}
				return r_RGetVectorArrayCountImpl_Int32;
			}
		}

		/// <summary>
		/// Int32 GetColorArrayCountImpl(Int32)
		/// </summary>
		protected RMethod r_RGetColorArrayCountImpl_Int32;
		public virtual RMethod RGetColorArrayCountImpl_Int32
		{
			get
			{
				if(r_RGetColorArrayCountImpl_Int32 == null)
				{
					r_RGetColorArrayCountImpl_Int32 = new(this, "GetColorArrayCountImpl", 0, typeof(System.Int32));
					r_RGetColorArrayCountImpl_Int32.SetBelong(this.instance);
				}
				return r_RGetColorArrayCountImpl_Int32;
			}
		}

		/// <summary>
		/// Int32 GetMatrixArrayCountImpl(Int32)
		/// </summary>
		protected RMethod r_RGetMatrixArrayCountImpl_Int32;
		public virtual RMethod RGetMatrixArrayCountImpl_Int32
		{
			get
			{
				if(r_RGetMatrixArrayCountImpl_Int32 == null)
				{
					r_RGetMatrixArrayCountImpl_Int32 = new(this, "GetMatrixArrayCountImpl", 0, typeof(System.Int32));
					r_RGetMatrixArrayCountImpl_Int32.SetBelong(this.instance);
				}
				return r_RGetMatrixArrayCountImpl_Int32;
			}
		}

		/// <summary>
		/// Void ExtractFloatArrayImpl(Int32, Single[])
		/// </summary>
		protected RMethod r_RExtractFloatArrayImpl_Int32_SingleArray;
		public virtual RMethod RExtractFloatArrayImpl_Int32_SingleArray
		{
			get
			{
				if(r_RExtractFloatArrayImpl_Int32_SingleArray == null)
				{
					r_RExtractFloatArrayImpl_Int32_SingleArray = new(this, "ExtractFloatArrayImpl", 0, typeof(System.Int32), typeof(System.Single).MakeArrayType());
					r_RExtractFloatArrayImpl_Int32_SingleArray.SetBelong(this.instance);
				}
				return r_RExtractFloatArrayImpl_Int32_SingleArray;
			}
		}

		/// <summary>
		/// Void ExtractVectorArrayImpl(Int32, UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_RExtractVectorArrayImpl_Int32_Vector4Array;
		public virtual RMethod RExtractVectorArrayImpl_Int32_Vector4Array
		{
			get
			{
				if(r_RExtractVectorArrayImpl_Int32_Vector4Array == null)
				{
					r_RExtractVectorArrayImpl_Int32_Vector4Array = new(this, "ExtractVectorArrayImpl", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType());
					r_RExtractVectorArrayImpl_Int32_Vector4Array.SetBelong(this.instance);
				}
				return r_RExtractVectorArrayImpl_Int32_Vector4Array;
			}
		}

		/// <summary>
		/// Void ExtractColorArrayImpl(Int32, UnityEngine.Color[])
		/// </summary>
		protected RMethod r_RExtractColorArrayImpl_Int32_ColorArray;
		public virtual RMethod RExtractColorArrayImpl_Int32_ColorArray
		{
			get
			{
				if(r_RExtractColorArrayImpl_Int32_ColorArray == null)
				{
					r_RExtractColorArrayImpl_Int32_ColorArray = new(this, "ExtractColorArrayImpl", 0, typeof(System.Int32), typeof(UnityEngine.Color).MakeArrayType());
					r_RExtractColorArrayImpl_Int32_ColorArray.SetBelong(this.instance);
				}
				return r_RExtractColorArrayImpl_Int32_ColorArray;
			}
		}

		/// <summary>
		/// Void ExtractMatrixArrayImpl(Int32, UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_RExtractMatrixArrayImpl_Int32_Matrix4x4Array;
		public virtual RMethod RExtractMatrixArrayImpl_Int32_Matrix4x4Array
		{
			get
			{
				if(r_RExtractMatrixArrayImpl_Int32_Matrix4x4Array == null)
				{
					r_RExtractMatrixArrayImpl_Int32_Matrix4x4Array = new(this, "ExtractMatrixArrayImpl", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType());
					r_RExtractMatrixArrayImpl_Int32_Matrix4x4Array.SetBelong(this.instance);
				}
				return r_RExtractMatrixArrayImpl_Int32_Matrix4x4Array;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 GetTextureScaleAndOffsetImpl(Int32)
		/// </summary>
		protected RMethod r_RGetTextureScaleAndOffsetImpl_Int32;
		public virtual RMethod RGetTextureScaleAndOffsetImpl_Int32
		{
			get
			{
				if(r_RGetTextureScaleAndOffsetImpl_Int32 == null)
				{
					r_RGetTextureScaleAndOffsetImpl_Int32 = new(this, "GetTextureScaleAndOffsetImpl", 0, typeof(System.Int32));
					r_RGetTextureScaleAndOffsetImpl_Int32.SetBelong(this.instance);
				}
				return r_RGetTextureScaleAndOffsetImpl_Int32;
			}
		}

		/// <summary>
		/// Void SetTextureOffsetImpl(Int32, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RSetTextureOffsetImpl_Int32_Vector2;
		public virtual RMethod RSetTextureOffsetImpl_Int32_Vector2
		{
			get
			{
				if(r_RSetTextureOffsetImpl_Int32_Vector2 == null)
				{
					r_RSetTextureOffsetImpl_Int32_Vector2 = new(this, "SetTextureOffsetImpl", 0, typeof(System.Int32), typeof(UnityEngine.Vector2));
					r_RSetTextureOffsetImpl_Int32_Vector2.SetBelong(this.instance);
				}
				return r_RSetTextureOffsetImpl_Int32_Vector2;
			}
		}

		/// <summary>
		/// Void SetTextureScaleImpl(Int32, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RSetTextureScaleImpl_Int32_Vector2;
		public virtual RMethod RSetTextureScaleImpl_Int32_Vector2
		{
			get
			{
				if(r_RSetTextureScaleImpl_Int32_Vector2 == null)
				{
					r_RSetTextureScaleImpl_Int32_Vector2 = new(this, "SetTextureScaleImpl", 0, typeof(System.Int32), typeof(UnityEngine.Vector2));
					r_RSetTextureScaleImpl_Int32_Vector2.SetBelong(this.instance);
				}
				return r_RSetTextureScaleImpl_Int32_Vector2;
			}
		}

		/// <summary>
		/// Boolean IsChildOf(UnityEngine.Material)
		/// </summary>
		protected RMethod r_RIsChildOf_Material;
		public virtual RMethod RIsChildOf_Material
		{
			get
			{
				if(r_RIsChildOf_Material == null)
				{
					r_RIsChildOf_Material = new(this, "IsChildOf", 0, typeof(UnityEngine.Material));
					r_RIsChildOf_Material.SetBelong(this.instance);
				}
				return r_RIsChildOf_Material;
			}
		}

		/// <summary>
		/// Void RevertAllPropertyOverrides()
		/// </summary>
		protected RMethod r_RRevertAllPropertyOverrides;
		public virtual RMethod RRevertAllPropertyOverrides
		{
			get
			{
				if(r_RRevertAllPropertyOverrides == null)
				{
					r_RRevertAllPropertyOverrides = new(this, "RevertAllPropertyOverrides", 0);
					r_RRevertAllPropertyOverrides.SetBelong(this.instance);
				}
				return r_RRevertAllPropertyOverrides;
			}
		}

		/// <summary>
		/// Boolean IsPropertyOverriden(Int32)
		/// </summary>
		protected RMethod r_RIsPropertyOverriden_Int32;
		public virtual RMethod RIsPropertyOverriden_Int32
		{
			get
			{
				if(r_RIsPropertyOverriden_Int32 == null)
				{
					r_RIsPropertyOverriden_Int32 = new(this, "IsPropertyOverriden", 0, typeof(System.Int32));
					r_RIsPropertyOverriden_Int32.SetBelong(this.instance);
				}
				return r_RIsPropertyOverriden_Int32;
			}
		}

		/// <summary>
		/// Boolean IsPropertyLocked(Int32)
		/// </summary>
		protected RMethod r_RIsPropertyLocked_Int32;
		public virtual RMethod RIsPropertyLocked_Int32
		{
			get
			{
				if(r_RIsPropertyLocked_Int32 == null)
				{
					r_RIsPropertyLocked_Int32 = new(this, "IsPropertyLocked", 0, typeof(System.Int32));
					r_RIsPropertyLocked_Int32.SetBelong(this.instance);
				}
				return r_RIsPropertyLocked_Int32;
			}
		}

		/// <summary>
		/// Boolean IsPropertyLockedByAncestor(Int32)
		/// </summary>
		protected RMethod r_RIsPropertyLockedByAncestor_Int32;
		public virtual RMethod RIsPropertyLockedByAncestor_Int32
		{
			get
			{
				if(r_RIsPropertyLockedByAncestor_Int32 == null)
				{
					r_RIsPropertyLockedByAncestor_Int32 = new(this, "IsPropertyLockedByAncestor", 0, typeof(System.Int32));
					r_RIsPropertyLockedByAncestor_Int32.SetBelong(this.instance);
				}
				return r_RIsPropertyLockedByAncestor_Int32;
			}
		}

		/// <summary>
		/// Boolean IsPropertyOverriden(System.String)
		/// </summary>
		protected RMethod r_RIsPropertyOverriden_String;
		public virtual RMethod RIsPropertyOverriden_String
		{
			get
			{
				if(r_RIsPropertyOverriden_String == null)
				{
					r_RIsPropertyOverriden_String = new(this, "IsPropertyOverriden", 0, typeof(System.String));
					r_RIsPropertyOverriden_String.SetBelong(this.instance);
				}
				return r_RIsPropertyOverriden_String;
			}
		}

		/// <summary>
		/// Boolean IsPropertyLocked(System.String)
		/// </summary>
		protected RMethod r_RIsPropertyLocked_String;
		public virtual RMethod RIsPropertyLocked_String
		{
			get
			{
				if(r_RIsPropertyLocked_String == null)
				{
					r_RIsPropertyLocked_String = new(this, "IsPropertyLocked", 0, typeof(System.String));
					r_RIsPropertyLocked_String.SetBelong(this.instance);
				}
				return r_RIsPropertyLocked_String;
			}
		}

		/// <summary>
		/// Boolean IsPropertyLockedByAncestor(System.String)
		/// </summary>
		protected RMethod r_RIsPropertyLockedByAncestor_String;
		public virtual RMethod RIsPropertyLockedByAncestor_String
		{
			get
			{
				if(r_RIsPropertyLockedByAncestor_String == null)
				{
					r_RIsPropertyLockedByAncestor_String = new(this, "IsPropertyLockedByAncestor", 0, typeof(System.String));
					r_RIsPropertyLockedByAncestor_String.SetBelong(this.instance);
				}
				return r_RIsPropertyLockedByAncestor_String;
			}
		}

		/// <summary>
		/// Void SetPropertyLock(Int32, Boolean)
		/// </summary>
		protected RMethod r_RSetPropertyLock_Int32_Boolean;
		public virtual RMethod RSetPropertyLock_Int32_Boolean
		{
			get
			{
				if(r_RSetPropertyLock_Int32_Boolean == null)
				{
					r_RSetPropertyLock_Int32_Boolean = new(this, "SetPropertyLock", 0, typeof(System.Int32), typeof(System.Boolean));
					r_RSetPropertyLock_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RSetPropertyLock_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void ApplyPropertyOverride(UnityEngine.Material, Int32, Boolean)
		/// </summary>
		protected RMethod r_RApplyPropertyOverride_Material_Int32_Boolean;
		public virtual RMethod RApplyPropertyOverride_Material_Int32_Boolean
		{
			get
			{
				if(r_RApplyPropertyOverride_Material_Int32_Boolean == null)
				{
					r_RApplyPropertyOverride_Material_Int32_Boolean = new(this, "ApplyPropertyOverride", 0, typeof(UnityEngine.Material), typeof(System.Int32), typeof(System.Boolean));
					r_RApplyPropertyOverride_Material_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RApplyPropertyOverride_Material_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void RevertPropertyOverride(Int32)
		/// </summary>
		protected RMethod r_RRevertPropertyOverride_Int32;
		public virtual RMethod RRevertPropertyOverride_Int32
		{
			get
			{
				if(r_RRevertPropertyOverride_Int32 == null)
				{
					r_RRevertPropertyOverride_Int32 = new(this, "RevertPropertyOverride", 0, typeof(System.Int32));
					r_RRevertPropertyOverride_Int32.SetBelong(this.instance);
				}
				return r_RRevertPropertyOverride_Int32;
			}
		}

		/// <summary>
		/// Void GetPropertyState(Int32, Boolean ByRef, Boolean ByRef, Boolean ByRef)
		/// </summary>
		protected RMethod r_RGetPropertyState_Int32_Out_Boolean_Out_Boolean_Out_Boolean;
		public virtual RMethod RGetPropertyState_Int32_Out_Boolean_Out_Boolean_Out_Boolean
		{
			get
			{
				if(r_RGetPropertyState_Int32_Out_Boolean_Out_Boolean_Out_Boolean == null)
				{
					r_RGetPropertyState_Int32_Out_Boolean_Out_Boolean_Out_Boolean = new(this, "GetPropertyState", 0, typeof(System.Int32), typeof(System.Boolean).MakeByRefType(), typeof(System.Boolean).MakeByRefType(), typeof(System.Boolean).MakeByRefType());
					r_RGetPropertyState_Int32_Out_Boolean_Out_Boolean_Out_Boolean.SetBelong(this.instance);
				}
				return r_RGetPropertyState_Int32_Out_Boolean_Out_Boolean_Out_Boolean;
			}
		}

		/// <summary>
		/// Void SetPropertyLock(System.String, Boolean)
		/// </summary>
		protected RMethod r_RSetPropertyLock_String_Boolean;
		public virtual RMethod RSetPropertyLock_String_Boolean
		{
			get
			{
				if(r_RSetPropertyLock_String_Boolean == null)
				{
					r_RSetPropertyLock_String_Boolean = new(this, "SetPropertyLock", 0, typeof(System.String), typeof(System.Boolean));
					r_RSetPropertyLock_String_Boolean.SetBelong(this.instance);
				}
				return r_RSetPropertyLock_String_Boolean;
			}
		}

		/// <summary>
		/// Void ApplyPropertyOverride(UnityEngine.Material, System.String, Boolean)
		/// </summary>
		protected RMethod r_RApplyPropertyOverride_Material_String_Boolean;
		public virtual RMethod RApplyPropertyOverride_Material_String_Boolean
		{
			get
			{
				if(r_RApplyPropertyOverride_Material_String_Boolean == null)
				{
					r_RApplyPropertyOverride_Material_String_Boolean = new(this, "ApplyPropertyOverride", 0, typeof(UnityEngine.Material), typeof(System.String), typeof(System.Boolean));
					r_RApplyPropertyOverride_Material_String_Boolean.SetBelong(this.instance);
				}
				return r_RApplyPropertyOverride_Material_String_Boolean;
			}
		}

		/// <summary>
		/// Void RevertPropertyOverride(System.String)
		/// </summary>
		protected RMethod r_RRevertPropertyOverride_String;
		public virtual RMethod RRevertPropertyOverride_String
		{
			get
			{
				if(r_RRevertPropertyOverride_String == null)
				{
					r_RRevertPropertyOverride_String = new(this, "RevertPropertyOverride", 0, typeof(System.String));
					r_RRevertPropertyOverride_String.SetBelong(this.instance);
				}
				return r_RRevertPropertyOverride_String;
			}
		}

		/// <summary>
		/// Void SetPropertyLock_Serialized(UnityEngine.MaterialSerializedProperty, Boolean)
		/// </summary>
		protected RMethod r_RSetPropertyLock_Serialized_MaterialSerializedProperty_Boolean;
		public virtual RMethod RSetPropertyLock_Serialized_MaterialSerializedProperty_Boolean
		{
			get
			{
				if(r_RSetPropertyLock_Serialized_MaterialSerializedProperty_Boolean == null)
				{
					r_RSetPropertyLock_Serialized_MaterialSerializedProperty_Boolean = new(this, "SetPropertyLock_Serialized", 0,  ReleactionUtils.GetType("UnityEngine.MaterialSerializedProperty"), typeof(System.Boolean));
					r_RSetPropertyLock_Serialized_MaterialSerializedProperty_Boolean.SetBelong(this.instance);
				}
				return r_RSetPropertyLock_Serialized_MaterialSerializedProperty_Boolean;
			}
		}

		/// <summary>
		/// Void ApplyPropertyOverride_Serialized(UnityEngine.Material, UnityEngine.MaterialSerializedProperty, Boolean)
		/// </summary>
		protected RMethod r_RApplyPropertyOverride_Serialized_Material_MaterialSerializedProperty_Boolean;
		public virtual RMethod RApplyPropertyOverride_Serialized_Material_MaterialSerializedProperty_Boolean
		{
			get
			{
				if(r_RApplyPropertyOverride_Serialized_Material_MaterialSerializedProperty_Boolean == null)
				{
					r_RApplyPropertyOverride_Serialized_Material_MaterialSerializedProperty_Boolean = new(this, "ApplyPropertyOverride_Serialized", 0, typeof(UnityEngine.Material),  ReleactionUtils.GetType("UnityEngine.MaterialSerializedProperty"), typeof(System.Boolean));
					r_RApplyPropertyOverride_Serialized_Material_MaterialSerializedProperty_Boolean.SetBelong(this.instance);
				}
				return r_RApplyPropertyOverride_Serialized_Material_MaterialSerializedProperty_Boolean;
			}
		}

		/// <summary>
		/// Void RevertPropertyOverride_Serialized(UnityEngine.MaterialSerializedProperty)
		/// </summary>
		protected RMethod r_RRevertPropertyOverride_Serialized_MaterialSerializedProperty;
		public virtual RMethod RRevertPropertyOverride_Serialized_MaterialSerializedProperty
		{
			get
			{
				if(r_RRevertPropertyOverride_Serialized_MaterialSerializedProperty == null)
				{
					r_RRevertPropertyOverride_Serialized_MaterialSerializedProperty = new(this, "RevertPropertyOverride_Serialized", 0,  ReleactionUtils.GetType("UnityEngine.MaterialSerializedProperty"));
					r_RRevertPropertyOverride_Serialized_MaterialSerializedProperty.SetBelong(this.instance);
				}
				return r_RRevertPropertyOverride_Serialized_MaterialSerializedProperty;
			}
		}

		/// <summary>
		/// Void GetPropertyState_Serialized(UnityEngine.MaterialSerializedProperty, Boolean ByRef, Boolean ByRef, Boolean ByRef)
		/// </summary>
		protected RMethod r_RGetPropertyState_Serialized_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean;
		public virtual RMethod RGetPropertyState_Serialized_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean
		{
			get
			{
				if(r_RGetPropertyState_Serialized_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean == null)
				{
					r_RGetPropertyState_Serialized_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean = new(this, "GetPropertyState_Serialized", 0,  ReleactionUtils.GetType("UnityEngine.MaterialSerializedProperty"), typeof(System.Boolean).MakeByRefType(), typeof(System.Boolean).MakeByRefType(), typeof(System.Boolean).MakeByRefType());
					r_RGetPropertyState_Serialized_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean.SetBelong(this.instance);
				}
				return r_RGetPropertyState_Serialized_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean;
			}
		}

		/// <summary>
		/// Void SetPropertyLock(UnityEngine.MaterialSerializedProperty, Boolean)
		/// </summary>
		protected RMethod r_RSetPropertyLock_MaterialSerializedProperty_Boolean;
		public virtual RMethod RSetPropertyLock_MaterialSerializedProperty_Boolean
		{
			get
			{
				if(r_RSetPropertyLock_MaterialSerializedProperty_Boolean == null)
				{
					r_RSetPropertyLock_MaterialSerializedProperty_Boolean = new(this, "SetPropertyLock", 0,  ReleactionUtils.GetType("UnityEngine.MaterialSerializedProperty"), typeof(System.Boolean));
					r_RSetPropertyLock_MaterialSerializedProperty_Boolean.SetBelong(this.instance);
				}
				return r_RSetPropertyLock_MaterialSerializedProperty_Boolean;
			}
		}

		/// <summary>
		/// Void ApplyPropertyOverride(UnityEngine.Material, UnityEngine.MaterialSerializedProperty, Boolean)
		/// </summary>
		protected RMethod r_RApplyPropertyOverride_Material_MaterialSerializedProperty_Boolean;
		public virtual RMethod RApplyPropertyOverride_Material_MaterialSerializedProperty_Boolean
		{
			get
			{
				if(r_RApplyPropertyOverride_Material_MaterialSerializedProperty_Boolean == null)
				{
					r_RApplyPropertyOverride_Material_MaterialSerializedProperty_Boolean = new(this, "ApplyPropertyOverride", 0, typeof(UnityEngine.Material),  ReleactionUtils.GetType("UnityEngine.MaterialSerializedProperty"), typeof(System.Boolean));
					r_RApplyPropertyOverride_Material_MaterialSerializedProperty_Boolean.SetBelong(this.instance);
				}
				return r_RApplyPropertyOverride_Material_MaterialSerializedProperty_Boolean;
			}
		}

		/// <summary>
		/// Void RevertPropertyOverride(UnityEngine.MaterialSerializedProperty)
		/// </summary>
		protected RMethod r_RRevertPropertyOverride_MaterialSerializedProperty;
		public virtual RMethod RRevertPropertyOverride_MaterialSerializedProperty
		{
			get
			{
				if(r_RRevertPropertyOverride_MaterialSerializedProperty == null)
				{
					r_RRevertPropertyOverride_MaterialSerializedProperty = new(this, "RevertPropertyOverride", 0,  ReleactionUtils.GetType("UnityEngine.MaterialSerializedProperty"));
					r_RRevertPropertyOverride_MaterialSerializedProperty.SetBelong(this.instance);
				}
				return r_RRevertPropertyOverride_MaterialSerializedProperty;
			}
		}

		/// <summary>
		/// Void GetPropertyState(UnityEngine.MaterialSerializedProperty, Boolean ByRef, Boolean ByRef, Boolean ByRef)
		/// </summary>
		protected RMethod r_RGetPropertyState_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean;
		public virtual RMethod RGetPropertyState_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean
		{
			get
			{
				if(r_RGetPropertyState_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean == null)
				{
					r_RGetPropertyState_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean = new(this, "GetPropertyState", 0,  ReleactionUtils.GetType("UnityEngine.MaterialSerializedProperty"), typeof(System.Boolean).MakeByRefType(), typeof(System.Boolean).MakeByRefType(), typeof(System.Boolean).MakeByRefType());
					r_RGetPropertyState_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean.SetBelong(this.instance);
				}
				return r_RGetPropertyState_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean;
			}
		}

		/// <summary>
		/// Void SetFloatArray(Int32, Single[], Int32)
		/// </summary>
		protected RMethod r_RSetFloatArray_Int32_SingleArray_Int32;
		public virtual RMethod RSetFloatArray_Int32_SingleArray_Int32
		{
			get
			{
				if(r_RSetFloatArray_Int32_SingleArray_Int32 == null)
				{
					r_RSetFloatArray_Int32_SingleArray_Int32 = new(this, "SetFloatArray", 0, typeof(System.Int32), typeof(System.Single).MakeArrayType(), typeof(System.Int32));
					r_RSetFloatArray_Int32_SingleArray_Int32.SetBelong(this.instance);
				}
				return r_RSetFloatArray_Int32_SingleArray_Int32;
			}
		}

		/// <summary>
		/// Void SetVectorArray(Int32, UnityEngine.Vector4[], Int32)
		/// </summary>
		protected RMethod r_RSetVectorArray_Int32_Vector4Array_Int32;
		public virtual RMethod RSetVectorArray_Int32_Vector4Array_Int32
		{
			get
			{
				if(r_RSetVectorArray_Int32_Vector4Array_Int32 == null)
				{
					r_RSetVectorArray_Int32_Vector4Array_Int32 = new(this, "SetVectorArray", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType(), typeof(System.Int32));
					r_RSetVectorArray_Int32_Vector4Array_Int32.SetBelong(this.instance);
				}
				return r_RSetVectorArray_Int32_Vector4Array_Int32;
			}
		}

		/// <summary>
		/// Void SetColorArray(Int32, UnityEngine.Color[], Int32)
		/// </summary>
		protected RMethod r_RSetColorArray_Int32_ColorArray_Int32;
		public virtual RMethod RSetColorArray_Int32_ColorArray_Int32
		{
			get
			{
				if(r_RSetColorArray_Int32_ColorArray_Int32 == null)
				{
					r_RSetColorArray_Int32_ColorArray_Int32 = new(this, "SetColorArray", 0, typeof(System.Int32), typeof(UnityEngine.Color).MakeArrayType(), typeof(System.Int32));
					r_RSetColorArray_Int32_ColorArray_Int32.SetBelong(this.instance);
				}
				return r_RSetColorArray_Int32_ColorArray_Int32;
			}
		}

		/// <summary>
		/// Void SetMatrixArray(Int32, UnityEngine.Matrix4x4[], Int32)
		/// </summary>
		protected RMethod r_RSetMatrixArray_Int32_Matrix4x4Array_Int32;
		public virtual RMethod RSetMatrixArray_Int32_Matrix4x4Array_Int32
		{
			get
			{
				if(r_RSetMatrixArray_Int32_Matrix4x4Array_Int32 == null)
				{
					r_RSetMatrixArray_Int32_Matrix4x4Array_Int32 = new(this, "SetMatrixArray", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType(), typeof(System.Int32));
					r_RSetMatrixArray_Int32_Matrix4x4Array_Int32.SetBelong(this.instance);
				}
				return r_RSetMatrixArray_Int32_Matrix4x4Array_Int32;
			}
		}

		/// <summary>
		/// Void ExtractFloatArray(Int32, System.Collections.Generic.List`1[System.Single])
		/// </summary>
		protected RMethod r_RExtractFloatArray_Int32_List_d_Single_p_;
		public virtual RMethod RExtractFloatArray_Int32_List_d_Single_p_
		{
			get
			{
				if(r_RExtractFloatArray_Int32_List_d_Single_p_ == null)
				{
					r_RExtractFloatArray_Int32_List_d_Single_p_ = new(this, "ExtractFloatArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Single)));
					r_RExtractFloatArray_Int32_List_d_Single_p_.SetBelong(this.instance);
				}
				return r_RExtractFloatArray_Int32_List_d_Single_p_;
			}
		}

		/// <summary>
		/// Void ExtractVectorArray(Int32, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_RExtractVectorArray_Int32_List_d_Vector4_p_;
		public virtual RMethod RExtractVectorArray_Int32_List_d_Vector4_p_
		{
			get
			{
				if(r_RExtractVectorArray_Int32_List_d_Vector4_p_ == null)
				{
					r_RExtractVectorArray_Int32_List_d_Vector4_p_ = new(this, "ExtractVectorArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_RExtractVectorArray_Int32_List_d_Vector4_p_.SetBelong(this.instance);
				}
				return r_RExtractVectorArray_Int32_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void ExtractColorArray(Int32, System.Collections.Generic.List`1[UnityEngine.Color])
		/// </summary>
		protected RMethod r_RExtractColorArray_Int32_List_d_Color_p_;
		public virtual RMethod RExtractColorArray_Int32_List_d_Color_p_
		{
			get
			{
				if(r_RExtractColorArray_Int32_List_d_Color_p_ == null)
				{
					r_RExtractColorArray_Int32_List_d_Color_p_ = new(this, "ExtractColorArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Color)));
					r_RExtractColorArray_Int32_List_d_Color_p_.SetBelong(this.instance);
				}
				return r_RExtractColorArray_Int32_List_d_Color_p_;
			}
		}

		/// <summary>
		/// Void ExtractMatrixArray(Int32, System.Collections.Generic.List`1[UnityEngine.Matrix4x4])
		/// </summary>
		protected RMethod r_RExtractMatrixArray_Int32_List_d_Matrix4x4_p_;
		public virtual RMethod RExtractMatrixArray_Int32_List_d_Matrix4x4_p_
		{
			get
			{
				if(r_RExtractMatrixArray_Int32_List_d_Matrix4x4_p_ == null)
				{
					r_RExtractMatrixArray_Int32_List_d_Matrix4x4_p_ = new(this, "ExtractMatrixArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Matrix4x4)));
					r_RExtractMatrixArray_Int32_List_d_Matrix4x4_p_.SetBelong(this.instance);
				}
				return r_RExtractMatrixArray_Int32_List_d_Matrix4x4_p_;
			}
		}

		/// <summary>
		/// Void SetInt(System.String, Int32)
		/// </summary>
		protected RMethod r_RSetInt_String_Int32;
		public virtual RMethod RSetInt_String_Int32
		{
			get
			{
				if(r_RSetInt_String_Int32 == null)
				{
					r_RSetInt_String_Int32 = new(this, "SetInt", 0, typeof(System.String), typeof(System.Int32));
					r_RSetInt_String_Int32.SetBelong(this.instance);
				}
				return r_RSetInt_String_Int32;
			}
		}

		/// <summary>
		/// Void SetInt(Int32, Int32)
		/// </summary>
		protected RMethod r_RSetInt_Int32_Int32;
		public virtual RMethod RSetInt_Int32_Int32
		{
			get
			{
				if(r_RSetInt_Int32_Int32 == null)
				{
					r_RSetInt_Int32_Int32 = new(this, "SetInt", 0, typeof(System.Int32), typeof(System.Int32));
					r_RSetInt_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetInt_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetFloat(System.String, Single)
		/// </summary>
		protected RMethod r_RSetFloat_String_Single;
		public virtual RMethod RSetFloat_String_Single
		{
			get
			{
				if(r_RSetFloat_String_Single == null)
				{
					r_RSetFloat_String_Single = new(this, "SetFloat", 0, typeof(System.String), typeof(System.Single));
					r_RSetFloat_String_Single.SetBelong(this.instance);
				}
				return r_RSetFloat_String_Single;
			}
		}

		/// <summary>
		/// Void SetFloat(Int32, Single)
		/// </summary>
		protected RMethod r_RSetFloat_Int32_Single;
		public virtual RMethod RSetFloat_Int32_Single
		{
			get
			{
				if(r_RSetFloat_Int32_Single == null)
				{
					r_RSetFloat_Int32_Single = new(this, "SetFloat", 0, typeof(System.Int32), typeof(System.Single));
					r_RSetFloat_Int32_Single.SetBelong(this.instance);
				}
				return r_RSetFloat_Int32_Single;
			}
		}

		/// <summary>
		/// Void SetInteger(System.String, Int32)
		/// </summary>
		protected RMethod r_RSetInteger_String_Int32;
		public virtual RMethod RSetInteger_String_Int32
		{
			get
			{
				if(r_RSetInteger_String_Int32 == null)
				{
					r_RSetInteger_String_Int32 = new(this, "SetInteger", 0, typeof(System.String), typeof(System.Int32));
					r_RSetInteger_String_Int32.SetBelong(this.instance);
				}
				return r_RSetInteger_String_Int32;
			}
		}

		/// <summary>
		/// Void SetInteger(Int32, Int32)
		/// </summary>
		protected RMethod r_RSetInteger_Int32_Int32;
		public virtual RMethod RSetInteger_Int32_Int32
		{
			get
			{
				if(r_RSetInteger_Int32_Int32 == null)
				{
					r_RSetInteger_Int32_Int32 = new(this, "SetInteger", 0, typeof(System.Int32), typeof(System.Int32));
					r_RSetInteger_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetInteger_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetColor(System.String, UnityEngine.Color)
		/// </summary>
		protected RMethod r_RSetColor_String_Color;
		public virtual RMethod RSetColor_String_Color
		{
			get
			{
				if(r_RSetColor_String_Color == null)
				{
					r_RSetColor_String_Color = new(this, "SetColor", 0, typeof(System.String), typeof(UnityEngine.Color));
					r_RSetColor_String_Color.SetBelong(this.instance);
				}
				return r_RSetColor_String_Color;
			}
		}

		/// <summary>
		/// Void SetColor(Int32, UnityEngine.Color)
		/// </summary>
		protected RMethod r_RSetColor_Int32_Color;
		public virtual RMethod RSetColor_Int32_Color
		{
			get
			{
				if(r_RSetColor_Int32_Color == null)
				{
					r_RSetColor_Int32_Color = new(this, "SetColor", 0, typeof(System.Int32), typeof(UnityEngine.Color));
					r_RSetColor_Int32_Color.SetBelong(this.instance);
				}
				return r_RSetColor_Int32_Color;
			}
		}

		/// <summary>
		/// Void SetVector(System.String, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_RSetVector_String_Vector4;
		public virtual RMethod RSetVector_String_Vector4
		{
			get
			{
				if(r_RSetVector_String_Vector4 == null)
				{
					r_RSetVector_String_Vector4 = new(this, "SetVector", 0, typeof(System.String), typeof(UnityEngine.Vector4));
					r_RSetVector_String_Vector4.SetBelong(this.instance);
				}
				return r_RSetVector_String_Vector4;
			}
		}

		/// <summary>
		/// Void SetVector(Int32, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_RSetVector_Int32_Vector4;
		public virtual RMethod RSetVector_Int32_Vector4
		{
			get
			{
				if(r_RSetVector_Int32_Vector4 == null)
				{
					r_RSetVector_Int32_Vector4 = new(this, "SetVector", 0, typeof(System.Int32), typeof(UnityEngine.Vector4));
					r_RSetVector_Int32_Vector4.SetBelong(this.instance);
				}
				return r_RSetVector_Int32_Vector4;
			}
		}

		/// <summary>
		/// Void SetMatrix(System.String, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_RSetMatrix_String_Matrix4x4;
		public virtual RMethod RSetMatrix_String_Matrix4x4
		{
			get
			{
				if(r_RSetMatrix_String_Matrix4x4 == null)
				{
					r_RSetMatrix_String_Matrix4x4 = new(this, "SetMatrix", 0, typeof(System.String), typeof(UnityEngine.Matrix4x4));
					r_RSetMatrix_String_Matrix4x4.SetBelong(this.instance);
				}
				return r_RSetMatrix_String_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetMatrix(Int32, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_RSetMatrix_Int32_Matrix4x4;
		public virtual RMethod RSetMatrix_Int32_Matrix4x4
		{
			get
			{
				if(r_RSetMatrix_Int32_Matrix4x4 == null)
				{
					r_RSetMatrix_Int32_Matrix4x4 = new(this, "SetMatrix", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4));
					r_RSetMatrix_Int32_Matrix4x4.SetBelong(this.instance);
				}
				return r_RSetMatrix_Int32_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetTexture(System.String, UnityEngine.Texture)
		/// </summary>
		protected RMethod r_RSetTexture_String_Texture;
		public virtual RMethod RSetTexture_String_Texture
		{
			get
			{
				if(r_RSetTexture_String_Texture == null)
				{
					r_RSetTexture_String_Texture = new(this, "SetTexture", 0, typeof(System.String), typeof(UnityEngine.Texture));
					r_RSetTexture_String_Texture.SetBelong(this.instance);
				}
				return r_RSetTexture_String_Texture;
			}
		}

		/// <summary>
		/// Void SetTexture(Int32, UnityEngine.Texture)
		/// </summary>
		protected RMethod r_RSetTexture_Int32_Texture;
		public virtual RMethod RSetTexture_Int32_Texture
		{
			get
			{
				if(r_RSetTexture_Int32_Texture == null)
				{
					r_RSetTexture_Int32_Texture = new(this, "SetTexture", 0, typeof(System.Int32), typeof(UnityEngine.Texture));
					r_RSetTexture_Int32_Texture.SetBelong(this.instance);
				}
				return r_RSetTexture_Int32_Texture;
			}
		}

		/// <summary>
		/// Void SetTexture(System.String, UnityEngine.RenderTexture, UnityEngine.Rendering.RenderTextureSubElement)
		/// </summary>
		protected RMethod r_RSetTexture_String_RenderTexture_RenderTextureSubElement;
		public virtual RMethod RSetTexture_String_RenderTexture_RenderTextureSubElement
		{
			get
			{
				if(r_RSetTexture_String_RenderTexture_RenderTextureSubElement == null)
				{
					r_RSetTexture_String_RenderTexture_RenderTextureSubElement = new(this, "SetTexture", 0, typeof(System.String), typeof(UnityEngine.RenderTexture), typeof(UnityEngine.Rendering.RenderTextureSubElement));
					r_RSetTexture_String_RenderTexture_RenderTextureSubElement.SetBelong(this.instance);
				}
				return r_RSetTexture_String_RenderTexture_RenderTextureSubElement;
			}
		}

		/// <summary>
		/// Void SetTexture(Int32, UnityEngine.RenderTexture, UnityEngine.Rendering.RenderTextureSubElement)
		/// </summary>
		protected RMethod r_RSetTexture_Int32_RenderTexture_RenderTextureSubElement;
		public virtual RMethod RSetTexture_Int32_RenderTexture_RenderTextureSubElement
		{
			get
			{
				if(r_RSetTexture_Int32_RenderTexture_RenderTextureSubElement == null)
				{
					r_RSetTexture_Int32_RenderTexture_RenderTextureSubElement = new(this, "SetTexture", 0, typeof(System.Int32), typeof(UnityEngine.RenderTexture), typeof(UnityEngine.Rendering.RenderTextureSubElement));
					r_RSetTexture_Int32_RenderTexture_RenderTextureSubElement.SetBelong(this.instance);
				}
				return r_RSetTexture_Int32_RenderTexture_RenderTextureSubElement;
			}
		}

		/// <summary>
		/// Void SetBuffer(System.String, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_RSetBuffer_String_ComputeBuffer;
		public virtual RMethod RSetBuffer_String_ComputeBuffer
		{
			get
			{
				if(r_RSetBuffer_String_ComputeBuffer == null)
				{
					r_RSetBuffer_String_ComputeBuffer = new(this, "SetBuffer", 0, typeof(System.String), typeof(UnityEngine.ComputeBuffer));
					r_RSetBuffer_String_ComputeBuffer.SetBelong(this.instance);
				}
				return r_RSetBuffer_String_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetBuffer(Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_RSetBuffer_Int32_ComputeBuffer;
		public virtual RMethod RSetBuffer_Int32_ComputeBuffer
		{
			get
			{
				if(r_RSetBuffer_Int32_ComputeBuffer == null)
				{
					r_RSetBuffer_Int32_ComputeBuffer = new(this, "SetBuffer", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
					r_RSetBuffer_Int32_ComputeBuffer.SetBelong(this.instance);
				}
				return r_RSetBuffer_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetBuffer(System.String, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_RSetBuffer_String_GraphicsBuffer;
		public virtual RMethod RSetBuffer_String_GraphicsBuffer
		{
			get
			{
				if(r_RSetBuffer_String_GraphicsBuffer == null)
				{
					r_RSetBuffer_String_GraphicsBuffer = new(this, "SetBuffer", 0, typeof(System.String), typeof(UnityEngine.GraphicsBuffer));
					r_RSetBuffer_String_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_RSetBuffer_String_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetBuffer(Int32, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_RSetBuffer_Int32_GraphicsBuffer;
		public virtual RMethod RSetBuffer_Int32_GraphicsBuffer
		{
			get
			{
				if(r_RSetBuffer_Int32_GraphicsBuffer == null)
				{
					r_RSetBuffer_Int32_GraphicsBuffer = new(this, "SetBuffer", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer));
					r_RSetBuffer_Int32_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_RSetBuffer_Int32_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetConstantBuffer(System.String, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetConstantBuffer_String_ComputeBuffer_Int32_Int32;
		public virtual RMethod RSetConstantBuffer_String_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_RSetConstantBuffer_String_ComputeBuffer_Int32_Int32 == null)
				{
					r_RSetConstantBuffer_String_ComputeBuffer_Int32_Int32 = new(this, "SetConstantBuffer", 0, typeof(System.String), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
					r_RSetConstantBuffer_String_ComputeBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetConstantBuffer_String_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetConstantBuffer(Int32, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetConstantBuffer_Int32_ComputeBuffer_Int32_Int32;
		public virtual RMethod RSetConstantBuffer_Int32_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_RSetConstantBuffer_Int32_ComputeBuffer_Int32_Int32 == null)
				{
					r_RSetConstantBuffer_Int32_ComputeBuffer_Int32_Int32 = new(this, "SetConstantBuffer", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
					r_RSetConstantBuffer_Int32_ComputeBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetConstantBuffer_Int32_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetConstantBuffer(System.String, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetConstantBuffer_String_GraphicsBuffer_Int32_Int32;
		public virtual RMethod RSetConstantBuffer_String_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_RSetConstantBuffer_String_GraphicsBuffer_Int32_Int32 == null)
				{
					r_RSetConstantBuffer_String_GraphicsBuffer_Int32_Int32 = new(this, "SetConstantBuffer", 0, typeof(System.String), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
					r_RSetConstantBuffer_String_GraphicsBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetConstantBuffer_String_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetConstantBuffer(Int32, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32;
		public virtual RMethod RSetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_RSetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32 == null)
				{
					r_RSetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32 = new(this, "SetConstantBuffer", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
					r_RSetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetFloatArray(System.String, System.Collections.Generic.List`1[System.Single])
		/// </summary>
		protected RMethod r_RSetFloatArray_String_List_d_Single_p_;
		public virtual RMethod RSetFloatArray_String_List_d_Single_p_
		{
			get
			{
				if(r_RSetFloatArray_String_List_d_Single_p_ == null)
				{
					r_RSetFloatArray_String_List_d_Single_p_ = new(this, "SetFloatArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Single)));
					r_RSetFloatArray_String_List_d_Single_p_.SetBelong(this.instance);
				}
				return r_RSetFloatArray_String_List_d_Single_p_;
			}
		}

		/// <summary>
		/// Void SetFloatArray(Int32, System.Collections.Generic.List`1[System.Single])
		/// </summary>
		protected RMethod r_RSetFloatArray_Int32_List_d_Single_p_;
		public virtual RMethod RSetFloatArray_Int32_List_d_Single_p_
		{
			get
			{
				if(r_RSetFloatArray_Int32_List_d_Single_p_ == null)
				{
					r_RSetFloatArray_Int32_List_d_Single_p_ = new(this, "SetFloatArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Single)));
					r_RSetFloatArray_Int32_List_d_Single_p_.SetBelong(this.instance);
				}
				return r_RSetFloatArray_Int32_List_d_Single_p_;
			}
		}

		/// <summary>
		/// Void SetFloatArray(System.String, Single[])
		/// </summary>
		protected RMethod r_RSetFloatArray_String_SingleArray;
		public virtual RMethod RSetFloatArray_String_SingleArray
		{
			get
			{
				if(r_RSetFloatArray_String_SingleArray == null)
				{
					r_RSetFloatArray_String_SingleArray = new(this, "SetFloatArray", 0, typeof(System.String), typeof(System.Single).MakeArrayType());
					r_RSetFloatArray_String_SingleArray.SetBelong(this.instance);
				}
				return r_RSetFloatArray_String_SingleArray;
			}
		}

		/// <summary>
		/// Void SetFloatArray(Int32, Single[])
		/// </summary>
		protected RMethod r_RSetFloatArray_Int32_SingleArray;
		public virtual RMethod RSetFloatArray_Int32_SingleArray
		{
			get
			{
				if(r_RSetFloatArray_Int32_SingleArray == null)
				{
					r_RSetFloatArray_Int32_SingleArray = new(this, "SetFloatArray", 0, typeof(System.Int32), typeof(System.Single).MakeArrayType());
					r_RSetFloatArray_Int32_SingleArray.SetBelong(this.instance);
				}
				return r_RSetFloatArray_Int32_SingleArray;
			}
		}

		/// <summary>
		/// Void SetColorArray(System.String, System.Collections.Generic.List`1[UnityEngine.Color])
		/// </summary>
		protected RMethod r_RSetColorArray_String_List_d_Color_p_;
		public virtual RMethod RSetColorArray_String_List_d_Color_p_
		{
			get
			{
				if(r_RSetColorArray_String_List_d_Color_p_ == null)
				{
					r_RSetColorArray_String_List_d_Color_p_ = new(this, "SetColorArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Color)));
					r_RSetColorArray_String_List_d_Color_p_.SetBelong(this.instance);
				}
				return r_RSetColorArray_String_List_d_Color_p_;
			}
		}

		/// <summary>
		/// Void SetColorArray(Int32, System.Collections.Generic.List`1[UnityEngine.Color])
		/// </summary>
		protected RMethod r_RSetColorArray_Int32_List_d_Color_p_;
		public virtual RMethod RSetColorArray_Int32_List_d_Color_p_
		{
			get
			{
				if(r_RSetColorArray_Int32_List_d_Color_p_ == null)
				{
					r_RSetColorArray_Int32_List_d_Color_p_ = new(this, "SetColorArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Color)));
					r_RSetColorArray_Int32_List_d_Color_p_.SetBelong(this.instance);
				}
				return r_RSetColorArray_Int32_List_d_Color_p_;
			}
		}

		/// <summary>
		/// Void SetColorArray(System.String, UnityEngine.Color[])
		/// </summary>
		protected RMethod r_RSetColorArray_String_ColorArray;
		public virtual RMethod RSetColorArray_String_ColorArray
		{
			get
			{
				if(r_RSetColorArray_String_ColorArray == null)
				{
					r_RSetColorArray_String_ColorArray = new(this, "SetColorArray", 0, typeof(System.String), typeof(UnityEngine.Color).MakeArrayType());
					r_RSetColorArray_String_ColorArray.SetBelong(this.instance);
				}
				return r_RSetColorArray_String_ColorArray;
			}
		}

		/// <summary>
		/// Void SetColorArray(Int32, UnityEngine.Color[])
		/// </summary>
		protected RMethod r_RSetColorArray_Int32_ColorArray;
		public virtual RMethod RSetColorArray_Int32_ColorArray
		{
			get
			{
				if(r_RSetColorArray_Int32_ColorArray == null)
				{
					r_RSetColorArray_Int32_ColorArray = new(this, "SetColorArray", 0, typeof(System.Int32), typeof(UnityEngine.Color).MakeArrayType());
					r_RSetColorArray_Int32_ColorArray.SetBelong(this.instance);
				}
				return r_RSetColorArray_Int32_ColorArray;
			}
		}

		/// <summary>
		/// Void SetVectorArray(System.String, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_RSetVectorArray_String_List_d_Vector4_p_;
		public virtual RMethod RSetVectorArray_String_List_d_Vector4_p_
		{
			get
			{
				if(r_RSetVectorArray_String_List_d_Vector4_p_ == null)
				{
					r_RSetVectorArray_String_List_d_Vector4_p_ = new(this, "SetVectorArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_RSetVectorArray_String_List_d_Vector4_p_.SetBelong(this.instance);
				}
				return r_RSetVectorArray_String_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void SetVectorArray(Int32, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_RSetVectorArray_Int32_List_d_Vector4_p_;
		public virtual RMethod RSetVectorArray_Int32_List_d_Vector4_p_
		{
			get
			{
				if(r_RSetVectorArray_Int32_List_d_Vector4_p_ == null)
				{
					r_RSetVectorArray_Int32_List_d_Vector4_p_ = new(this, "SetVectorArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_RSetVectorArray_Int32_List_d_Vector4_p_.SetBelong(this.instance);
				}
				return r_RSetVectorArray_Int32_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void SetVectorArray(System.String, UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_RSetVectorArray_String_Vector4Array;
		public virtual RMethod RSetVectorArray_String_Vector4Array
		{
			get
			{
				if(r_RSetVectorArray_String_Vector4Array == null)
				{
					r_RSetVectorArray_String_Vector4Array = new(this, "SetVectorArray", 0, typeof(System.String), typeof(UnityEngine.Vector4).MakeArrayType());
					r_RSetVectorArray_String_Vector4Array.SetBelong(this.instance);
				}
				return r_RSetVectorArray_String_Vector4Array;
			}
		}

		/// <summary>
		/// Void SetVectorArray(Int32, UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_RSetVectorArray_Int32_Vector4Array;
		public virtual RMethod RSetVectorArray_Int32_Vector4Array
		{
			get
			{
				if(r_RSetVectorArray_Int32_Vector4Array == null)
				{
					r_RSetVectorArray_Int32_Vector4Array = new(this, "SetVectorArray", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType());
					r_RSetVectorArray_Int32_Vector4Array.SetBelong(this.instance);
				}
				return r_RSetVectorArray_Int32_Vector4Array;
			}
		}

		/// <summary>
		/// Void SetMatrixArray(System.String, System.Collections.Generic.List`1[UnityEngine.Matrix4x4])
		/// </summary>
		protected RMethod r_RSetMatrixArray_String_List_d_Matrix4x4_p_;
		public virtual RMethod RSetMatrixArray_String_List_d_Matrix4x4_p_
		{
			get
			{
				if(r_RSetMatrixArray_String_List_d_Matrix4x4_p_ == null)
				{
					r_RSetMatrixArray_String_List_d_Matrix4x4_p_ = new(this, "SetMatrixArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Matrix4x4)));
					r_RSetMatrixArray_String_List_d_Matrix4x4_p_.SetBelong(this.instance);
				}
				return r_RSetMatrixArray_String_List_d_Matrix4x4_p_;
			}
		}

		/// <summary>
		/// Void SetMatrixArray(Int32, System.Collections.Generic.List`1[UnityEngine.Matrix4x4])
		/// </summary>
		protected RMethod r_RSetMatrixArray_Int32_List_d_Matrix4x4_p_;
		public virtual RMethod RSetMatrixArray_Int32_List_d_Matrix4x4_p_
		{
			get
			{
				if(r_RSetMatrixArray_Int32_List_d_Matrix4x4_p_ == null)
				{
					r_RSetMatrixArray_Int32_List_d_Matrix4x4_p_ = new(this, "SetMatrixArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Matrix4x4)));
					r_RSetMatrixArray_Int32_List_d_Matrix4x4_p_.SetBelong(this.instance);
				}
				return r_RSetMatrixArray_Int32_List_d_Matrix4x4_p_;
			}
		}

		/// <summary>
		/// Void SetMatrixArray(System.String, UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_RSetMatrixArray_String_Matrix4x4Array;
		public virtual RMethod RSetMatrixArray_String_Matrix4x4Array
		{
			get
			{
				if(r_RSetMatrixArray_String_Matrix4x4Array == null)
				{
					r_RSetMatrixArray_String_Matrix4x4Array = new(this, "SetMatrixArray", 0, typeof(System.String), typeof(UnityEngine.Matrix4x4).MakeArrayType());
					r_RSetMatrixArray_String_Matrix4x4Array.SetBelong(this.instance);
				}
				return r_RSetMatrixArray_String_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Void SetMatrixArray(Int32, UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_RSetMatrixArray_Int32_Matrix4x4Array;
		public virtual RMethod RSetMatrixArray_Int32_Matrix4x4Array
		{
			get
			{
				if(r_RSetMatrixArray_Int32_Matrix4x4Array == null)
				{
					r_RSetMatrixArray_Int32_Matrix4x4Array = new(this, "SetMatrixArray", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType());
					r_RSetMatrixArray_Int32_Matrix4x4Array.SetBelong(this.instance);
				}
				return r_RSetMatrixArray_Int32_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Int32 GetInt(System.String)
		/// </summary>
		protected RMethod r_RGetInt_String;
		public virtual RMethod RGetInt_String
		{
			get
			{
				if(r_RGetInt_String == null)
				{
					r_RGetInt_String = new(this, "GetInt", 0, typeof(System.String));
					r_RGetInt_String.SetBelong(this.instance);
				}
				return r_RGetInt_String;
			}
		}

		/// <summary>
		/// Int32 GetInt(Int32)
		/// </summary>
		protected RMethod r_RGetInt_Int32;
		public virtual RMethod RGetInt_Int32
		{
			get
			{
				if(r_RGetInt_Int32 == null)
				{
					r_RGetInt_Int32 = new(this, "GetInt", 0, typeof(System.Int32));
					r_RGetInt_Int32.SetBelong(this.instance);
				}
				return r_RGetInt_Int32;
			}
		}

		/// <summary>
		/// Single GetFloat(System.String)
		/// </summary>
		protected RMethod r_RGetFloat_String;
		public virtual RMethod RGetFloat_String
		{
			get
			{
				if(r_RGetFloat_String == null)
				{
					r_RGetFloat_String = new(this, "GetFloat", 0, typeof(System.String));
					r_RGetFloat_String.SetBelong(this.instance);
				}
				return r_RGetFloat_String;
			}
		}

		/// <summary>
		/// Single GetFloat(Int32)
		/// </summary>
		protected RMethod r_RGetFloat_Int32;
		public virtual RMethod RGetFloat_Int32
		{
			get
			{
				if(r_RGetFloat_Int32 == null)
				{
					r_RGetFloat_Int32 = new(this, "GetFloat", 0, typeof(System.Int32));
					r_RGetFloat_Int32.SetBelong(this.instance);
				}
				return r_RGetFloat_Int32;
			}
		}

		/// <summary>
		/// Int32 GetInteger(System.String)
		/// </summary>
		protected RMethod r_RGetInteger_String;
		public virtual RMethod RGetInteger_String
		{
			get
			{
				if(r_RGetInteger_String == null)
				{
					r_RGetInteger_String = new(this, "GetInteger", 0, typeof(System.String));
					r_RGetInteger_String.SetBelong(this.instance);
				}
				return r_RGetInteger_String;
			}
		}

		/// <summary>
		/// Int32 GetInteger(Int32)
		/// </summary>
		protected RMethod r_RGetInteger_Int32;
		public virtual RMethod RGetInteger_Int32
		{
			get
			{
				if(r_RGetInteger_Int32 == null)
				{
					r_RGetInteger_Int32 = new(this, "GetInteger", 0, typeof(System.Int32));
					r_RGetInteger_Int32.SetBelong(this.instance);
				}
				return r_RGetInteger_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetColor(System.String)
		/// </summary>
		protected RMethod r_RGetColor_String;
		public virtual RMethod RGetColor_String
		{
			get
			{
				if(r_RGetColor_String == null)
				{
					r_RGetColor_String = new(this, "GetColor", 0, typeof(System.String));
					r_RGetColor_String.SetBelong(this.instance);
				}
				return r_RGetColor_String;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetColor(Int32)
		/// </summary>
		protected RMethod r_RGetColor_Int32;
		public virtual RMethod RGetColor_Int32
		{
			get
			{
				if(r_RGetColor_Int32 == null)
				{
					r_RGetColor_Int32 = new(this, "GetColor", 0, typeof(System.Int32));
					r_RGetColor_Int32.SetBelong(this.instance);
				}
				return r_RGetColor_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 GetVector(System.String)
		/// </summary>
		protected RMethod r_RGetVector_String;
		public virtual RMethod RGetVector_String
		{
			get
			{
				if(r_RGetVector_String == null)
				{
					r_RGetVector_String = new(this, "GetVector", 0, typeof(System.String));
					r_RGetVector_String.SetBelong(this.instance);
				}
				return r_RGetVector_String;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 GetVector(Int32)
		/// </summary>
		protected RMethod r_RGetVector_Int32;
		public virtual RMethod RGetVector_Int32
		{
			get
			{
				if(r_RGetVector_Int32 == null)
				{
					r_RGetVector_Int32 = new(this, "GetVector", 0, typeof(System.Int32));
					r_RGetVector_Int32.SetBelong(this.instance);
				}
				return r_RGetVector_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 GetMatrix(System.String)
		/// </summary>
		protected RMethod r_RGetMatrix_String;
		public virtual RMethod RGetMatrix_String
		{
			get
			{
				if(r_RGetMatrix_String == null)
				{
					r_RGetMatrix_String = new(this, "GetMatrix", 0, typeof(System.String));
					r_RGetMatrix_String.SetBelong(this.instance);
				}
				return r_RGetMatrix_String;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 GetMatrix(Int32)
		/// </summary>
		protected RMethod r_RGetMatrix_Int32;
		public virtual RMethod RGetMatrix_Int32
		{
			get
			{
				if(r_RGetMatrix_Int32 == null)
				{
					r_RGetMatrix_Int32 = new(this, "GetMatrix", 0, typeof(System.Int32));
					r_RGetMatrix_Int32.SetBelong(this.instance);
				}
				return r_RGetMatrix_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Texture GetTexture(System.String)
		/// </summary>
		protected RMethod r_RGetTexture_String;
		public virtual RMethod RGetTexture_String
		{
			get
			{
				if(r_RGetTexture_String == null)
				{
					r_RGetTexture_String = new(this, "GetTexture", 0, typeof(System.String));
					r_RGetTexture_String.SetBelong(this.instance);
				}
				return r_RGetTexture_String;
			}
		}

		/// <summary>
		/// UnityEngine.Texture GetTexture(Int32)
		/// </summary>
		protected RMethod r_RGetTexture_Int32;
		public virtual RMethod RGetTexture_Int32
		{
			get
			{
				if(r_RGetTexture_Int32 == null)
				{
					r_RGetTexture_Int32 = new(this, "GetTexture", 0, typeof(System.Int32));
					r_RGetTexture_Int32.SetBelong(this.instance);
				}
				return r_RGetTexture_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBufferHandle GetBuffer(System.String)
		/// </summary>
		protected RMethod r_RGetBuffer_String;
		public virtual RMethod RGetBuffer_String
		{
			get
			{
				if(r_RGetBuffer_String == null)
				{
					r_RGetBuffer_String = new(this, "GetBuffer", 0, typeof(System.String));
					r_RGetBuffer_String.SetBelong(this.instance);
				}
				return r_RGetBuffer_String;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBufferHandle GetConstantBuffer(System.String)
		/// </summary>
		protected RMethod r_RGetConstantBuffer_String;
		public virtual RMethod RGetConstantBuffer_String
		{
			get
			{
				if(r_RGetConstantBuffer_String == null)
				{
					r_RGetConstantBuffer_String = new(this, "GetConstantBuffer", 0, typeof(System.String));
					r_RGetConstantBuffer_String.SetBelong(this.instance);
				}
				return r_RGetConstantBuffer_String;
			}
		}

		/// <summary>
		/// Single[] GetFloatArray(System.String)
		/// </summary>
		protected RMethod r_RGetFloatArray_String;
		public virtual RMethod RGetFloatArray_String
		{
			get
			{
				if(r_RGetFloatArray_String == null)
				{
					r_RGetFloatArray_String = new(this, "GetFloatArray", 0, typeof(System.String));
					r_RGetFloatArray_String.SetBelong(this.instance);
				}
				return r_RGetFloatArray_String;
			}
		}

		/// <summary>
		/// Single[] GetFloatArray(Int32)
		/// </summary>
		protected RMethod r_RGetFloatArray_Int32;
		public virtual RMethod RGetFloatArray_Int32
		{
			get
			{
				if(r_RGetFloatArray_Int32 == null)
				{
					r_RGetFloatArray_Int32 = new(this, "GetFloatArray", 0, typeof(System.Int32));
					r_RGetFloatArray_Int32.SetBelong(this.instance);
				}
				return r_RGetFloatArray_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color[] GetColorArray(System.String)
		/// </summary>
		protected RMethod r_RGetColorArray_String;
		public virtual RMethod RGetColorArray_String
		{
			get
			{
				if(r_RGetColorArray_String == null)
				{
					r_RGetColorArray_String = new(this, "GetColorArray", 0, typeof(System.String));
					r_RGetColorArray_String.SetBelong(this.instance);
				}
				return r_RGetColorArray_String;
			}
		}

		/// <summary>
		/// UnityEngine.Color[] GetColorArray(Int32)
		/// </summary>
		protected RMethod r_RGetColorArray_Int32;
		public virtual RMethod RGetColorArray_Int32
		{
			get
			{
				if(r_RGetColorArray_Int32 == null)
				{
					r_RGetColorArray_Int32 = new(this, "GetColorArray", 0, typeof(System.Int32));
					r_RGetColorArray_Int32.SetBelong(this.instance);
				}
				return r_RGetColorArray_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4[] GetVectorArray(System.String)
		/// </summary>
		protected RMethod r_RGetVectorArray_String;
		public virtual RMethod RGetVectorArray_String
		{
			get
			{
				if(r_RGetVectorArray_String == null)
				{
					r_RGetVectorArray_String = new(this, "GetVectorArray", 0, typeof(System.String));
					r_RGetVectorArray_String.SetBelong(this.instance);
				}
				return r_RGetVectorArray_String;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4[] GetVectorArray(Int32)
		/// </summary>
		protected RMethod r_RGetVectorArray_Int32;
		public virtual RMethod RGetVectorArray_Int32
		{
			get
			{
				if(r_RGetVectorArray_Int32 == null)
				{
					r_RGetVectorArray_Int32 = new(this, "GetVectorArray", 0, typeof(System.Int32));
					r_RGetVectorArray_Int32.SetBelong(this.instance);
				}
				return r_RGetVectorArray_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4[] GetMatrixArray(System.String)
		/// </summary>
		protected RMethod r_RGetMatrixArray_String;
		public virtual RMethod RGetMatrixArray_String
		{
			get
			{
				if(r_RGetMatrixArray_String == null)
				{
					r_RGetMatrixArray_String = new(this, "GetMatrixArray", 0, typeof(System.String));
					r_RGetMatrixArray_String.SetBelong(this.instance);
				}
				return r_RGetMatrixArray_String;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4[] GetMatrixArray(Int32)
		/// </summary>
		protected RMethod r_RGetMatrixArray_Int32;
		public virtual RMethod RGetMatrixArray_Int32
		{
			get
			{
				if(r_RGetMatrixArray_Int32 == null)
				{
					r_RGetMatrixArray_Int32 = new(this, "GetMatrixArray", 0, typeof(System.Int32));
					r_RGetMatrixArray_Int32.SetBelong(this.instance);
				}
				return r_RGetMatrixArray_Int32;
			}
		}

		/// <summary>
		/// Void GetFloatArray(System.String, System.Collections.Generic.List`1[System.Single])
		/// </summary>
		protected RMethod r_RGetFloatArray_String_List_d_Single_p_;
		public virtual RMethod RGetFloatArray_String_List_d_Single_p_
		{
			get
			{
				if(r_RGetFloatArray_String_List_d_Single_p_ == null)
				{
					r_RGetFloatArray_String_List_d_Single_p_ = new(this, "GetFloatArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Single)));
					r_RGetFloatArray_String_List_d_Single_p_.SetBelong(this.instance);
				}
				return r_RGetFloatArray_String_List_d_Single_p_;
			}
		}

		/// <summary>
		/// Void GetFloatArray(Int32, System.Collections.Generic.List`1[System.Single])
		/// </summary>
		protected RMethod r_RGetFloatArray_Int32_List_d_Single_p_;
		public virtual RMethod RGetFloatArray_Int32_List_d_Single_p_
		{
			get
			{
				if(r_RGetFloatArray_Int32_List_d_Single_p_ == null)
				{
					r_RGetFloatArray_Int32_List_d_Single_p_ = new(this, "GetFloatArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Single)));
					r_RGetFloatArray_Int32_List_d_Single_p_.SetBelong(this.instance);
				}
				return r_RGetFloatArray_Int32_List_d_Single_p_;
			}
		}

		/// <summary>
		/// Void GetColorArray(System.String, System.Collections.Generic.List`1[UnityEngine.Color])
		/// </summary>
		protected RMethod r_RGetColorArray_String_List_d_Color_p_;
		public virtual RMethod RGetColorArray_String_List_d_Color_p_
		{
			get
			{
				if(r_RGetColorArray_String_List_d_Color_p_ == null)
				{
					r_RGetColorArray_String_List_d_Color_p_ = new(this, "GetColorArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Color)));
					r_RGetColorArray_String_List_d_Color_p_.SetBelong(this.instance);
				}
				return r_RGetColorArray_String_List_d_Color_p_;
			}
		}

		/// <summary>
		/// Void GetColorArray(Int32, System.Collections.Generic.List`1[UnityEngine.Color])
		/// </summary>
		protected RMethod r_RGetColorArray_Int32_List_d_Color_p_;
		public virtual RMethod RGetColorArray_Int32_List_d_Color_p_
		{
			get
			{
				if(r_RGetColorArray_Int32_List_d_Color_p_ == null)
				{
					r_RGetColorArray_Int32_List_d_Color_p_ = new(this, "GetColorArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Color)));
					r_RGetColorArray_Int32_List_d_Color_p_.SetBelong(this.instance);
				}
				return r_RGetColorArray_Int32_List_d_Color_p_;
			}
		}

		/// <summary>
		/// Void GetVectorArray(System.String, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_RGetVectorArray_String_List_d_Vector4_p_;
		public virtual RMethod RGetVectorArray_String_List_d_Vector4_p_
		{
			get
			{
				if(r_RGetVectorArray_String_List_d_Vector4_p_ == null)
				{
					r_RGetVectorArray_String_List_d_Vector4_p_ = new(this, "GetVectorArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_RGetVectorArray_String_List_d_Vector4_p_.SetBelong(this.instance);
				}
				return r_RGetVectorArray_String_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void GetVectorArray(Int32, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_RGetVectorArray_Int32_List_d_Vector4_p_;
		public virtual RMethod RGetVectorArray_Int32_List_d_Vector4_p_
		{
			get
			{
				if(r_RGetVectorArray_Int32_List_d_Vector4_p_ == null)
				{
					r_RGetVectorArray_Int32_List_d_Vector4_p_ = new(this, "GetVectorArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_RGetVectorArray_Int32_List_d_Vector4_p_.SetBelong(this.instance);
				}
				return r_RGetVectorArray_Int32_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void GetMatrixArray(System.String, System.Collections.Generic.List`1[UnityEngine.Matrix4x4])
		/// </summary>
		protected RMethod r_RGetMatrixArray_String_List_d_Matrix4x4_p_;
		public virtual RMethod RGetMatrixArray_String_List_d_Matrix4x4_p_
		{
			get
			{
				if(r_RGetMatrixArray_String_List_d_Matrix4x4_p_ == null)
				{
					r_RGetMatrixArray_String_List_d_Matrix4x4_p_ = new(this, "GetMatrixArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Matrix4x4)));
					r_RGetMatrixArray_String_List_d_Matrix4x4_p_.SetBelong(this.instance);
				}
				return r_RGetMatrixArray_String_List_d_Matrix4x4_p_;
			}
		}

		/// <summary>
		/// Void GetMatrixArray(Int32, System.Collections.Generic.List`1[UnityEngine.Matrix4x4])
		/// </summary>
		protected RMethod r_RGetMatrixArray_Int32_List_d_Matrix4x4_p_;
		public virtual RMethod RGetMatrixArray_Int32_List_d_Matrix4x4_p_
		{
			get
			{
				if(r_RGetMatrixArray_Int32_List_d_Matrix4x4_p_ == null)
				{
					r_RGetMatrixArray_Int32_List_d_Matrix4x4_p_ = new(this, "GetMatrixArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Matrix4x4)));
					r_RGetMatrixArray_Int32_List_d_Matrix4x4_p_.SetBelong(this.instance);
				}
				return r_RGetMatrixArray_Int32_List_d_Matrix4x4_p_;
			}
		}

		/// <summary>
		/// Void SetTextureOffset(System.String, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RSetTextureOffset_String_Vector2;
		public virtual RMethod RSetTextureOffset_String_Vector2
		{
			get
			{
				if(r_RSetTextureOffset_String_Vector2 == null)
				{
					r_RSetTextureOffset_String_Vector2 = new(this, "SetTextureOffset", 0, typeof(System.String), typeof(UnityEngine.Vector2));
					r_RSetTextureOffset_String_Vector2.SetBelong(this.instance);
				}
				return r_RSetTextureOffset_String_Vector2;
			}
		}

		/// <summary>
		/// Void SetTextureOffset(Int32, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RSetTextureOffset_Int32_Vector2;
		public virtual RMethod RSetTextureOffset_Int32_Vector2
		{
			get
			{
				if(r_RSetTextureOffset_Int32_Vector2 == null)
				{
					r_RSetTextureOffset_Int32_Vector2 = new(this, "SetTextureOffset", 0, typeof(System.Int32), typeof(UnityEngine.Vector2));
					r_RSetTextureOffset_Int32_Vector2.SetBelong(this.instance);
				}
				return r_RSetTextureOffset_Int32_Vector2;
			}
		}

		/// <summary>
		/// Void SetTextureScale(System.String, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RSetTextureScale_String_Vector2;
		public virtual RMethod RSetTextureScale_String_Vector2
		{
			get
			{
				if(r_RSetTextureScale_String_Vector2 == null)
				{
					r_RSetTextureScale_String_Vector2 = new(this, "SetTextureScale", 0, typeof(System.String), typeof(UnityEngine.Vector2));
					r_RSetTextureScale_String_Vector2.SetBelong(this.instance);
				}
				return r_RSetTextureScale_String_Vector2;
			}
		}

		/// <summary>
		/// Void SetTextureScale(Int32, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RSetTextureScale_Int32_Vector2;
		public virtual RMethod RSetTextureScale_Int32_Vector2
		{
			get
			{
				if(r_RSetTextureScale_Int32_Vector2 == null)
				{
					r_RSetTextureScale_Int32_Vector2 = new(this, "SetTextureScale", 0, typeof(System.Int32), typeof(UnityEngine.Vector2));
					r_RSetTextureScale_Int32_Vector2.SetBelong(this.instance);
				}
				return r_RSetTextureScale_Int32_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetTextureOffset(System.String)
		/// </summary>
		protected RMethod r_RGetTextureOffset_String;
		public virtual RMethod RGetTextureOffset_String
		{
			get
			{
				if(r_RGetTextureOffset_String == null)
				{
					r_RGetTextureOffset_String = new(this, "GetTextureOffset", 0, typeof(System.String));
					r_RGetTextureOffset_String.SetBelong(this.instance);
				}
				return r_RGetTextureOffset_String;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetTextureOffset(Int32)
		/// </summary>
		protected RMethod r_RGetTextureOffset_Int32;
		public virtual RMethod RGetTextureOffset_Int32
		{
			get
			{
				if(r_RGetTextureOffset_Int32 == null)
				{
					r_RGetTextureOffset_Int32 = new(this, "GetTextureOffset", 0, typeof(System.Int32));
					r_RGetTextureOffset_Int32.SetBelong(this.instance);
				}
				return r_RGetTextureOffset_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetTextureScale(System.String)
		/// </summary>
		protected RMethod r_RGetTextureScale_String;
		public virtual RMethod RGetTextureScale_String
		{
			get
			{
				if(r_RGetTextureScale_String == null)
				{
					r_RGetTextureScale_String = new(this, "GetTextureScale", 0, typeof(System.String));
					r_RGetTextureScale_String.SetBelong(this.instance);
				}
				return r_RGetTextureScale_String;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetTextureScale(Int32)
		/// </summary>
		protected RMethod r_RGetTextureScale_Int32;
		public virtual RMethod RGetTextureScale_Int32
		{
			get
			{
				if(r_RGetTextureScale_Int32 == null)
				{
					r_RGetTextureScale_Int32 = new(this, "GetTextureScale", 0, typeof(System.Int32));
					r_RGetTextureScale_Int32.SetBelong(this.instance);
				}
				return r_RGetTextureScale_Int32;
			}
		}

		/// <summary>
		/// System.String[] GetPropertyNames(UnityEngine.MaterialPropertyType)
		/// </summary>
		protected RMethod r_RGetPropertyNames_MaterialPropertyType;
		public virtual RMethod RGetPropertyNames_MaterialPropertyType
		{
			get
			{
				if(r_RGetPropertyNames_MaterialPropertyType == null)
				{
					r_RGetPropertyNames_MaterialPropertyType = new(this, "GetPropertyNames", 0, typeof(UnityEngine.MaterialPropertyType));
					r_RGetPropertyNames_MaterialPropertyType.SetBelong(this.instance);
				}
				return r_RGetPropertyNames_MaterialPropertyType;
			}
		}

		/// <summary>
		/// Void EnableLocalKeyword_Injected(UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_REnableLocalKeyword_Injected_Ref_LocalKeyword;
		public virtual RMethod REnableLocalKeyword_Injected_Ref_LocalKeyword
		{
			get
			{
				if(r_REnableLocalKeyword_Injected_Ref_LocalKeyword == null)
				{
					r_REnableLocalKeyword_Injected_Ref_LocalKeyword = new(this, "EnableLocalKeyword_Injected", 0, typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
					r_REnableLocalKeyword_Injected_Ref_LocalKeyword.SetBelong(this.instance);
				}
				return r_REnableLocalKeyword_Injected_Ref_LocalKeyword;
			}
		}

		/// <summary>
		/// Void DisableLocalKeyword_Injected(UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_RDisableLocalKeyword_Injected_Ref_LocalKeyword;
		public virtual RMethod RDisableLocalKeyword_Injected_Ref_LocalKeyword
		{
			get
			{
				if(r_RDisableLocalKeyword_Injected_Ref_LocalKeyword == null)
				{
					r_RDisableLocalKeyword_Injected_Ref_LocalKeyword = new(this, "DisableLocalKeyword_Injected", 0, typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
					r_RDisableLocalKeyword_Injected_Ref_LocalKeyword.SetBelong(this.instance);
				}
				return r_RDisableLocalKeyword_Injected_Ref_LocalKeyword;
			}
		}

		/// <summary>
		/// Void SetLocalKeyword_Injected(UnityEngine.Rendering.LocalKeyword ByRef, Boolean)
		/// </summary>
		protected RMethod r_RSetLocalKeyword_Injected_Ref_LocalKeyword_Boolean;
		public virtual RMethod RSetLocalKeyword_Injected_Ref_LocalKeyword_Boolean
		{
			get
			{
				if(r_RSetLocalKeyword_Injected_Ref_LocalKeyword_Boolean == null)
				{
					r_RSetLocalKeyword_Injected_Ref_LocalKeyword_Boolean = new(this, "SetLocalKeyword_Injected", 0, typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType(), typeof(System.Boolean));
					r_RSetLocalKeyword_Injected_Ref_LocalKeyword_Boolean.SetBelong(this.instance);
				}
				return r_RSetLocalKeyword_Injected_Ref_LocalKeyword_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsLocalKeywordEnabled_Injected(UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected RMethod r_RIsLocalKeywordEnabled_Injected_Ref_LocalKeyword;
		public virtual RMethod RIsLocalKeywordEnabled_Injected_Ref_LocalKeyword
		{
			get
			{
				if(r_RIsLocalKeywordEnabled_Injected_Ref_LocalKeyword == null)
				{
					r_RIsLocalKeywordEnabled_Injected_Ref_LocalKeyword = new(this, "IsLocalKeywordEnabled_Injected", 0, typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
					r_RIsLocalKeywordEnabled_Injected_Ref_LocalKeyword.SetBelong(this.instance);
				}
				return r_RIsLocalKeywordEnabled_Injected_Ref_LocalKeyword;
			}
		}

		/// <summary>
		/// Void SetColorImpl_Injected(Int32, UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_RSetColorImpl_Injected_Int32_Ref_Color;
		public virtual RMethod RSetColorImpl_Injected_Int32_Ref_Color
		{
			get
			{
				if(r_RSetColorImpl_Injected_Int32_Ref_Color == null)
				{
					r_RSetColorImpl_Injected_Int32_Ref_Color = new(this, "SetColorImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Color).MakeByRefType());
					r_RSetColorImpl_Injected_Int32_Ref_Color.SetBelong(this.instance);
				}
				return r_RSetColorImpl_Injected_Int32_Ref_Color;
			}
		}

		/// <summary>
		/// Void SetMatrixImpl_Injected(Int32, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_RSetMatrixImpl_Injected_Int32_Ref_Matrix4x4;
		public virtual RMethod RSetMatrixImpl_Injected_Int32_Ref_Matrix4x4
		{
			get
			{
				if(r_RSetMatrixImpl_Injected_Int32_Ref_Matrix4x4 == null)
				{
					r_RSetMatrixImpl_Injected_Int32_Ref_Matrix4x4 = new(this, "SetMatrixImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_RSetMatrixImpl_Injected_Int32_Ref_Matrix4x4.SetBelong(this.instance);
				}
				return r_RSetMatrixImpl_Injected_Int32_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Void GetColorImpl_Injected(Int32, UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_RGetColorImpl_Injected_Int32_Out_Color;
		public virtual RMethod RGetColorImpl_Injected_Int32_Out_Color
		{
			get
			{
				if(r_RGetColorImpl_Injected_Int32_Out_Color == null)
				{
					r_RGetColorImpl_Injected_Int32_Out_Color = new(this, "GetColorImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Color).MakeByRefType());
					r_RGetColorImpl_Injected_Int32_Out_Color.SetBelong(this.instance);
				}
				return r_RGetColorImpl_Injected_Int32_Out_Color;
			}
		}

		/// <summary>
		/// Void GetMatrixImpl_Injected(Int32, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_RGetMatrixImpl_Injected_Int32_Out_Matrix4x4;
		public virtual RMethod RGetMatrixImpl_Injected_Int32_Out_Matrix4x4
		{
			get
			{
				if(r_RGetMatrixImpl_Injected_Int32_Out_Matrix4x4 == null)
				{
					r_RGetMatrixImpl_Injected_Int32_Out_Matrix4x4 = new(this, "GetMatrixImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_RGetMatrixImpl_Injected_Int32_Out_Matrix4x4.SetBelong(this.instance);
				}
				return r_RGetMatrixImpl_Injected_Int32_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void GetBufferImpl_Injected(Int32, UnityEngine.GraphicsBufferHandle ByRef)
		/// </summary>
		protected RMethod r_RGetBufferImpl_Injected_Int32_Out_GraphicsBufferHandle;
		public virtual RMethod RGetBufferImpl_Injected_Int32_Out_GraphicsBufferHandle
		{
			get
			{
				if(r_RGetBufferImpl_Injected_Int32_Out_GraphicsBufferHandle == null)
				{
					r_RGetBufferImpl_Injected_Int32_Out_GraphicsBufferHandle = new(this, "GetBufferImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBufferHandle).MakeByRefType());
					r_RGetBufferImpl_Injected_Int32_Out_GraphicsBufferHandle.SetBelong(this.instance);
				}
				return r_RGetBufferImpl_Injected_Int32_Out_GraphicsBufferHandle;
			}
		}

		/// <summary>
		/// Void GetConstantBufferImpl_Injected(Int32, UnityEngine.GraphicsBufferHandle ByRef)
		/// </summary>
		protected RMethod r_RGetConstantBufferImpl_Injected_Int32_Out_GraphicsBufferHandle;
		public virtual RMethod RGetConstantBufferImpl_Injected_Int32_Out_GraphicsBufferHandle
		{
			get
			{
				if(r_RGetConstantBufferImpl_Injected_Int32_Out_GraphicsBufferHandle == null)
				{
					r_RGetConstantBufferImpl_Injected_Int32_Out_GraphicsBufferHandle = new(this, "GetConstantBufferImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBufferHandle).MakeByRefType());
					r_RGetConstantBufferImpl_Injected_Int32_Out_GraphicsBufferHandle.SetBelong(this.instance);
				}
				return r_RGetConstantBufferImpl_Injected_Int32_Out_GraphicsBufferHandle;
			}
		}

		/// <summary>
		/// Void GetTextureScaleAndOffsetImpl_Injected(Int32, UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_RGetTextureScaleAndOffsetImpl_Injected_Int32_Out_Vector4;
		public virtual RMethod RGetTextureScaleAndOffsetImpl_Injected_Int32_Out_Vector4
		{
			get
			{
				if(r_RGetTextureScaleAndOffsetImpl_Injected_Int32_Out_Vector4 == null)
				{
					r_RGetTextureScaleAndOffsetImpl_Injected_Int32_Out_Vector4 = new(this, "GetTextureScaleAndOffsetImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeByRefType());
					r_RGetTextureScaleAndOffsetImpl_Injected_Int32_Out_Vector4.SetBelong(this.instance);
				}
				return r_RGetTextureScaleAndOffsetImpl_Injected_Int32_Out_Vector4;
			}
		}

		/// <summary>
		/// Void SetTextureOffsetImpl_Injected(Int32, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_RSetTextureOffsetImpl_Injected_Int32_Ref_Vector2;
		public virtual RMethod RSetTextureOffsetImpl_Injected_Int32_Ref_Vector2
		{
			get
			{
				if(r_RSetTextureOffsetImpl_Injected_Int32_Ref_Vector2 == null)
				{
					r_RSetTextureOffsetImpl_Injected_Int32_Ref_Vector2 = new(this, "SetTextureOffsetImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Vector2).MakeByRefType());
					r_RSetTextureOffsetImpl_Injected_Int32_Ref_Vector2.SetBelong(this.instance);
				}
				return r_RSetTextureOffsetImpl_Injected_Int32_Ref_Vector2;
			}
		}

		/// <summary>
		/// Void SetTextureScaleImpl_Injected(Int32, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_RSetTextureScaleImpl_Injected_Int32_Ref_Vector2;
		public virtual RMethod RSetTextureScaleImpl_Injected_Int32_Ref_Vector2
		{
			get
			{
				if(r_RSetTextureScaleImpl_Injected_Int32_Ref_Vector2 == null)
				{
					r_RSetTextureScaleImpl_Injected_Int32_Ref_Vector2 = new(this, "SetTextureScaleImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Vector2).MakeByRefType());
					r_RSetTextureScaleImpl_Injected_Int32_Ref_Vector2.SetBelong(this.instance);
				}
				return r_RSetTextureScaleImpl_Injected_Int32_Ref_Vector2;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_RGetInstanceID;
		public virtual RMethod RGetInstanceID
		{
			get
			{
				if(r_RGetInstanceID == null)
				{
					r_RGetInstanceID = new(this, "GetInstanceID", 0);
					r_RGetInstanceID.SetBelong(this.instance);
				}
				return r_RGetInstanceID;
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
