
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.Material
	/// </summary>
    public partial class RMaterial : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.Material);
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


		/// <summary>
		/// UnityEngine.Shader shader
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RShader r_Pshader;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RShader RPshader
		{
			get
			{
				if(r_Pshader == null)
				{
					r_Pshader = new(this, "shader", -1);
				}
				return r_Pshader;
			}
		}

		/// <summary>
		/// UnityEngine.Color color
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_Pcolor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RPcolor
		{
			get
			{
				if(r_Pcolor == null)
				{
					r_Pcolor = new(this, "color", -1);
				}
				return r_Pcolor;
			}
		}

		/// <summary>
		/// UnityEngine.Texture mainTexture
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTexture r_PmainTexture;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTexture RPmainTexture
		{
			get
			{
				if(r_PmainTexture == null)
				{
					r_PmainTexture = new(this, "mainTexture", -1);
				}
				return r_PmainTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 mainTextureOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PmainTextureOffset;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPmainTextureOffset
		{
			get
			{
				if(r_PmainTextureOffset == null)
				{
					r_PmainTextureOffset = new(this, "mainTextureOffset", -1);
				}
				return r_PmainTextureOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 mainTextureScale
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PmainTextureScale;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPmainTextureScale
		{
			get
			{
				if(r_PmainTextureScale == null)
				{
					r_PmainTextureScale = new(this, "mainTextureScale", -1);
				}
				return r_PmainTextureScale;
			}
		}

		/// <summary>
		/// Int32 renderQueue
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PrenderQueue;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPrenderQueue
		{
			get
			{
				if(r_PrenderQueue == null)
				{
					r_PrenderQueue = new(this, "renderQueue", -1);
				}
				return r_PrenderQueue;
			}
		}

		/// <summary>
		/// Int32 rawRenderQueue
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PrawRenderQueue;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPrawRenderQueue
		{
			get
			{
				if(r_PrawRenderQueue == null)
				{
					r_PrawRenderQueue = new(this, "rawRenderQueue", -1);
				}
				return r_PrawRenderQueue;
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
				}
				return r_PenabledKeywords;
			}
		}

		/// <summary>
		/// UnityEngine.MaterialGlobalIlluminationFlags globalIlluminationFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMaterialGlobalIlluminationFlags r_PglobalIlluminationFlags;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMaterialGlobalIlluminationFlags RPglobalIlluminationFlags
		{
			get
			{
				if(r_PglobalIlluminationFlags == null)
				{
					r_PglobalIlluminationFlags = new(this, "globalIlluminationFlags", -1);
				}
				return r_PglobalIlluminationFlags;
			}
		}

		/// <summary>
		/// Boolean doubleSidedGI
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PdoubleSidedGI;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPdoubleSidedGI
		{
			get
			{
				if(r_PdoubleSidedGI == null)
				{
					r_PdoubleSidedGI = new(this, "doubleSidedGI", -1);
				}
				return r_PdoubleSidedGI;
			}
		}

		/// <summary>
		/// Boolean enableInstancing
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PenableInstancing;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPenableInstancing
		{
			get
			{
				if(r_PenableInstancing == null)
				{
					r_PenableInstancing = new(this, "enableInstancing", -1);
				}
				return r_PenableInstancing;
			}
		}

		/// <summary>
		/// Int32 passCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PpassCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPpassCount
		{
			get
			{
				if(r_PpassCount == null)
				{
					r_PpassCount = new(this, "passCount", -1);
				}
				return r_PpassCount;
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
				}
				return r_PshaderKeywords;
			}
		}

		/// <summary>
		/// UnityEngine.Material parent
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMaterial r_Pparent;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMaterial RPparent
		{
			get
			{
				if(r_Pparent == null)
				{
					r_Pparent = new(this, "parent", -1);
				}
				return r_Pparent;
			}
		}

		/// <summary>
		/// Boolean isVariant
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisVariant;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisVariant
		{
			get
			{
				if(r_PisVariant == null)
				{
					r_PisVariant = new(this, "isVariant", -1);
				}
				return r_PisVariant;
			}
		}

		/// <summary>
		/// Int32 overrideCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PoverrideCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPoverrideCount
		{
			get
			{
				if(r_PoverrideCount == null)
				{
					r_PoverrideCount = new(this, "overrideCount", -1);
				}
				return r_PoverrideCount;
			}
		}

		/// <summary>
		/// Int32 lockCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PlockCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPlockCount
		{
			get
			{
				if(r_PlockCount == null)
				{
					r_PlockCount = new(this, "lockCount", -1);
				}
				return r_PlockCount;
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
				}
				return r_PhideFlags;
			}
		}

		/// <summary>
		/// UnityEngine.Material Create(System.String)
		/// </summary>
		protected static RMethod r_MCreate_String;
		public static RMethod RMCreate_String
		{
			get
			{
				if(r_MCreate_String == null)
				{
					r_MCreate_String = new(Type, "Create", 0, typeof(System.String));
				}
				return r_MCreate_String;
			}
		}

		/// <summary>
		/// Void CreateWithShader(UnityEngine.Material, UnityEngine.Shader)
		/// </summary>
		protected static RMethod r_MCreateWithShader_Material_Shader;
		public static RMethod RMCreateWithShader_Material_Shader
		{
			get
			{
				if(r_MCreateWithShader_Material_Shader == null)
				{
					r_MCreateWithShader_Material_Shader = new(Type, "CreateWithShader", 0, typeof(UnityEngine.Material), typeof(UnityEngine.Shader));
				}
				return r_MCreateWithShader_Material_Shader;
			}
		}

		/// <summary>
		/// Void CreateWithMaterial(UnityEngine.Material, UnityEngine.Material)
		/// </summary>
		protected static RMethod r_MCreateWithMaterial_Material_Material;
		public static RMethod RMCreateWithMaterial_Material_Material
		{
			get
			{
				if(r_MCreateWithMaterial_Material_Material == null)
				{
					r_MCreateWithMaterial_Material_Material = new(Type, "CreateWithMaterial", 0, typeof(UnityEngine.Material), typeof(UnityEngine.Material));
				}
				return r_MCreateWithMaterial_Material_Material;
			}
		}

		/// <summary>
		/// Void CreateWithString(UnityEngine.Material)
		/// </summary>
		protected static RMethod r_MCreateWithString_Material;
		public static RMethod RMCreateWithString_Material
		{
			get
			{
				if(r_MCreateWithString_Material == null)
				{
					r_MCreateWithString_Material = new(Type, "CreateWithString", 0, typeof(UnityEngine.Material));
				}
				return r_MCreateWithString_Material;
			}
		}

		/// <summary>
		/// UnityEngine.Material GetDefaultMaterial()
		/// </summary>
		protected static RMethod r_MGetDefaultMaterial;
		public static RMethod RMGetDefaultMaterial
		{
			get
			{
				if(r_MGetDefaultMaterial == null)
				{
					r_MGetDefaultMaterial = new(Type, "GetDefaultMaterial", 0);
				}
				return r_MGetDefaultMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.Material GetDefaultParticleMaterial()
		/// </summary>
		protected static RMethod r_MGetDefaultParticleMaterial;
		public static RMethod RMGetDefaultParticleMaterial
		{
			get
			{
				if(r_MGetDefaultParticleMaterial == null)
				{
					r_MGetDefaultParticleMaterial = new(Type, "GetDefaultParticleMaterial", 0);
				}
				return r_MGetDefaultParticleMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.Material GetDefaultLineMaterial()
		/// </summary>
		protected static RMethod r_MGetDefaultLineMaterial;
		public static RMethod RMGetDefaultLineMaterial
		{
			get
			{
				if(r_MGetDefaultLineMaterial == null)
				{
					r_MGetDefaultLineMaterial = new(Type, "GetDefaultLineMaterial", 0);
				}
				return r_MGetDefaultLineMaterial;
			}
		}

		/// <summary>
		/// Int32 GetFirstPropertyNameIdByAttribute(UnityEngine.Rendering.ShaderPropertyFlags)
		/// </summary>
		protected RMethod r_MGetFirstPropertyNameIdByAttribute_ShaderPropertyFlags;
		public virtual RMethod RMGetFirstPropertyNameIdByAttribute_ShaderPropertyFlags
		{
			get
			{
				if(r_MGetFirstPropertyNameIdByAttribute_ShaderPropertyFlags == null)
				{
					r_MGetFirstPropertyNameIdByAttribute_ShaderPropertyFlags = new(this, "GetFirstPropertyNameIdByAttribute", 0, typeof(UnityEngine.Rendering.ShaderPropertyFlags));
				}
				return r_MGetFirstPropertyNameIdByAttribute_ShaderPropertyFlags;
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
				}
				return r_MHasProperty_Int32;
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
				}
				return r_MHasProperty_String;
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
				}
				return r_MHasFloatImpl_Int32;
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
				}
				return r_MHasFloat_Int32;
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
				}
				return r_MHasInt_Int32;
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
				}
				return r_MHasIntImpl_Int32;
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
				}
				return r_MHasInteger_Int32;
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
				}
				return r_MHasTextureImpl_Int32;
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
				}
				return r_MHasTexture_Int32;
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
				}
				return r_MHasMatrixImpl_Int32;
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
				}
				return r_MHasMatrix_Int32;
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
				}
				return r_MHasVectorImpl_Int32;
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
				}
				return r_MHasColor_Int32;
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
				}
				return r_MHasBufferImpl_Int32;
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
				}
				return r_MHasBuffer_Int32;
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
				}
				return r_MHasConstantBufferImpl_Int32;
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
				}
				return r_MHasConstantBuffer_Int32;
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
				}
				return r_MIsKeywordEnabled_In_LocalKeyword;
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
				}
				return r_MSetEnabledKeywords_LocalKeywordArray;
			}
		}

		/// <summary>
		/// Void SetShaderPassEnabled(System.String, Boolean)
		/// </summary>
		protected RMethod r_MSetShaderPassEnabled_String_Boolean;
		public virtual RMethod RMSetShaderPassEnabled_String_Boolean
		{
			get
			{
				if(r_MSetShaderPassEnabled_String_Boolean == null)
				{
					r_MSetShaderPassEnabled_String_Boolean = new(this, "SetShaderPassEnabled", 0, typeof(System.String), typeof(System.Boolean));
				}
				return r_MSetShaderPassEnabled_String_Boolean;
			}
		}

		/// <summary>
		/// Boolean GetShaderPassEnabled(System.String)
		/// </summary>
		protected RMethod r_MGetShaderPassEnabled_String;
		public virtual RMethod RMGetShaderPassEnabled_String
		{
			get
			{
				if(r_MGetShaderPassEnabled_String == null)
				{
					r_MGetShaderPassEnabled_String = new(this, "GetShaderPassEnabled", 0, typeof(System.String));
				}
				return r_MGetShaderPassEnabled_String;
			}
		}

		/// <summary>
		/// System.String GetPassName(Int32)
		/// </summary>
		protected RMethod r_MGetPassName_Int32;
		public virtual RMethod RMGetPassName_Int32
		{
			get
			{
				if(r_MGetPassName_Int32 == null)
				{
					r_MGetPassName_Int32 = new(this, "GetPassName", 0, typeof(System.Int32));
				}
				return r_MGetPassName_Int32;
			}
		}

		/// <summary>
		/// Int32 FindPass(System.String)
		/// </summary>
		protected RMethod r_MFindPass_String;
		public virtual RMethod RMFindPass_String
		{
			get
			{
				if(r_MFindPass_String == null)
				{
					r_MFindPass_String = new(this, "FindPass", 0, typeof(System.String));
				}
				return r_MFindPass_String;
			}
		}

		/// <summary>
		/// Void SetOverrideTag(System.String, System.String)
		/// </summary>
		protected RMethod r_MSetOverrideTag_String_String;
		public virtual RMethod RMSetOverrideTag_String_String
		{
			get
			{
				if(r_MSetOverrideTag_String_String == null)
				{
					r_MSetOverrideTag_String_String = new(this, "SetOverrideTag", 0, typeof(System.String), typeof(System.String));
				}
				return r_MSetOverrideTag_String_String;
			}
		}

		/// <summary>
		/// System.String GetTagImpl(System.String, Boolean, System.String)
		/// </summary>
		protected RMethod r_MGetTagImpl_String_Boolean_String;
		public virtual RMethod RMGetTagImpl_String_Boolean_String
		{
			get
			{
				if(r_MGetTagImpl_String_Boolean_String == null)
				{
					r_MGetTagImpl_String_Boolean_String = new(this, "GetTagImpl", 0, typeof(System.String), typeof(System.Boolean), typeof(System.String));
				}
				return r_MGetTagImpl_String_Boolean_String;
			}
		}

		/// <summary>
		/// System.String GetTag(System.String, Boolean, System.String)
		/// </summary>
		protected RMethod r_MGetTag_String_Boolean_String;
		public virtual RMethod RMGetTag_String_Boolean_String
		{
			get
			{
				if(r_MGetTag_String_Boolean_String == null)
				{
					r_MGetTag_String_Boolean_String = new(this, "GetTag", 0, typeof(System.String), typeof(System.Boolean), typeof(System.String));
				}
				return r_MGetTag_String_Boolean_String;
			}
		}

		/// <summary>
		/// System.String GetTag(System.String, Boolean)
		/// </summary>
		protected RMethod r_MGetTag_String_Boolean;
		public virtual RMethod RMGetTag_String_Boolean
		{
			get
			{
				if(r_MGetTag_String_Boolean == null)
				{
					r_MGetTag_String_Boolean = new(this, "GetTag", 0, typeof(System.String), typeof(System.Boolean));
				}
				return r_MGetTag_String_Boolean;
			}
		}

		/// <summary>
		/// Void Lerp(UnityEngine.Material, UnityEngine.Material, Single)
		/// </summary>
		protected RMethod r_MLerp_Material_Material_Single;
		public virtual RMethod RMLerp_Material_Material_Single
		{
			get
			{
				if(r_MLerp_Material_Material_Single == null)
				{
					r_MLerp_Material_Material_Single = new(this, "Lerp", 0, typeof(UnityEngine.Material), typeof(UnityEngine.Material), typeof(System.Single));
				}
				return r_MLerp_Material_Material_Single;
			}
		}

		/// <summary>
		/// Boolean SetPass(Int32)
		/// </summary>
		protected RMethod r_MSetPass_Int32;
		public virtual RMethod RMSetPass_Int32
		{
			get
			{
				if(r_MSetPass_Int32 == null)
				{
					r_MSetPass_Int32 = new(this, "SetPass", 0, typeof(System.Int32));
				}
				return r_MSetPass_Int32;
			}
		}

		/// <summary>
		/// Void CopyPropertiesFromMaterial(UnityEngine.Material)
		/// </summary>
		protected RMethod r_MCopyPropertiesFromMaterial_Material;
		public virtual RMethod RMCopyPropertiesFromMaterial_Material
		{
			get
			{
				if(r_MCopyPropertiesFromMaterial_Material == null)
				{
					r_MCopyPropertiesFromMaterial_Material = new(this, "CopyPropertiesFromMaterial", 0, typeof(UnityEngine.Material));
				}
				return r_MCopyPropertiesFromMaterial_Material;
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
				}
				return r_MSetShaderKeywords_StringArray;
			}
		}

		/// <summary>
		/// System.String[] GetPropertyNamesImpl(Int32)
		/// </summary>
		protected RMethod r_MGetPropertyNamesImpl_Int32;
		public virtual RMethod RMGetPropertyNamesImpl_Int32
		{
			get
			{
				if(r_MGetPropertyNamesImpl_Int32 == null)
				{
					r_MGetPropertyNamesImpl_Int32 = new(this, "GetPropertyNamesImpl", 0, typeof(System.Int32));
				}
				return r_MGetPropertyNamesImpl_Int32;
			}
		}

		/// <summary>
		/// Int32 ComputeCRC()
		/// </summary>
		protected RMethod r_MComputeCRC;
		public virtual RMethod RMComputeCRC
		{
			get
			{
				if(r_MComputeCRC == null)
				{
					r_MComputeCRC = new(this, "ComputeCRC", 0);
				}
				return r_MComputeCRC;
			}
		}

		/// <summary>
		/// System.String[] GetTexturePropertyNames()
		/// </summary>
		protected RMethod r_MGetTexturePropertyNames;
		public virtual RMethod RMGetTexturePropertyNames
		{
			get
			{
				if(r_MGetTexturePropertyNames == null)
				{
					r_MGetTexturePropertyNames = new(this, "GetTexturePropertyNames", 0);
				}
				return r_MGetTexturePropertyNames;
			}
		}

		/// <summary>
		/// Int32[] GetTexturePropertyNameIDs()
		/// </summary>
		protected RMethod r_MGetTexturePropertyNameIDs;
		public virtual RMethod RMGetTexturePropertyNameIDs
		{
			get
			{
				if(r_MGetTexturePropertyNameIDs == null)
				{
					r_MGetTexturePropertyNameIDs = new(this, "GetTexturePropertyNameIDs", 0);
				}
				return r_MGetTexturePropertyNameIDs;
			}
		}

		/// <summary>
		/// Void GetTexturePropertyNamesInternal(System.Object)
		/// </summary>
		protected RMethod r_MGetTexturePropertyNamesInternal_Object;
		public virtual RMethod RMGetTexturePropertyNamesInternal_Object
		{
			get
			{
				if(r_MGetTexturePropertyNamesInternal_Object == null)
				{
					r_MGetTexturePropertyNamesInternal_Object = new(this, "GetTexturePropertyNamesInternal", 0, typeof(System.Object));
				}
				return r_MGetTexturePropertyNamesInternal_Object;
			}
		}

		/// <summary>
		/// Void GetTexturePropertyNameIDsInternal(System.Object)
		/// </summary>
		protected RMethod r_MGetTexturePropertyNameIDsInternal_Object;
		public virtual RMethod RMGetTexturePropertyNameIDsInternal_Object
		{
			get
			{
				if(r_MGetTexturePropertyNameIDsInternal_Object == null)
				{
					r_MGetTexturePropertyNameIDsInternal_Object = new(this, "GetTexturePropertyNameIDsInternal", 0, typeof(System.Object));
				}
				return r_MGetTexturePropertyNameIDsInternal_Object;
			}
		}

		/// <summary>
		/// Void GetTexturePropertyNames(System.Collections.Generic.List`1[System.String])
		/// </summary>
		protected RMethod r_MGetTexturePropertyNames_List_d_String_p_;
		public virtual RMethod RMGetTexturePropertyNames_List_d_String_p_
		{
			get
			{
				if(r_MGetTexturePropertyNames_List_d_String_p_ == null)
				{
					r_MGetTexturePropertyNames_List_d_String_p_ = new(this, "GetTexturePropertyNames", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.String)));
				}
				return r_MGetTexturePropertyNames_List_d_String_p_;
			}
		}

		/// <summary>
		/// Void GetTexturePropertyNameIDs(System.Collections.Generic.List`1[System.Int32])
		/// </summary>
		protected RMethod r_MGetTexturePropertyNameIDs_List_d_Int32_p_;
		public virtual RMethod RMGetTexturePropertyNameIDs_List_d_Int32_p_
		{
			get
			{
				if(r_MGetTexturePropertyNameIDs_List_d_Int32_p_ == null)
				{
					r_MGetTexturePropertyNameIDs_List_d_Int32_p_ = new(this, "GetTexturePropertyNameIDs", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.Int32)));
				}
				return r_MGetTexturePropertyNameIDs_List_d_Int32_p_;
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
				}
				return r_MSetFloatImpl_Int32_Single;
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
				}
				return r_MSetConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32;
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
				}
				return r_MGetFloatImpl_Int32;
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
				}
				return r_MGetTextureImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBufferHandle GetBufferImpl(Int32)
		/// </summary>
		protected RMethod r_MGetBufferImpl_Int32;
		public virtual RMethod RMGetBufferImpl_Int32
		{
			get
			{
				if(r_MGetBufferImpl_Int32 == null)
				{
					r_MGetBufferImpl_Int32 = new(this, "GetBufferImpl", 0, typeof(System.Int32));
				}
				return r_MGetBufferImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBufferHandle GetConstantBufferImpl(Int32)
		/// </summary>
		protected RMethod r_MGetConstantBufferImpl_Int32;
		public virtual RMethod RMGetConstantBufferImpl_Int32
		{
			get
			{
				if(r_MGetConstantBufferImpl_Int32 == null)
				{
					r_MGetConstantBufferImpl_Int32 = new(this, "GetConstantBufferImpl", 0, typeof(System.Int32));
				}
				return r_MGetConstantBufferImpl_Int32;
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
				}
				return r_MSetVectorArrayImpl_Int32_Vector4Array_Int32;
			}
		}

		/// <summary>
		/// Void SetColorArrayImpl(Int32, UnityEngine.Color[], Int32)
		/// </summary>
		protected RMethod r_MSetColorArrayImpl_Int32_ColorArray_Int32;
		public virtual RMethod RMSetColorArrayImpl_Int32_ColorArray_Int32
		{
			get
			{
				if(r_MSetColorArrayImpl_Int32_ColorArray_Int32 == null)
				{
					r_MSetColorArrayImpl_Int32_ColorArray_Int32 = new(this, "SetColorArrayImpl", 0, typeof(System.Int32), typeof(UnityEngine.Color).MakeArrayType(), typeof(System.Int32));
				}
				return r_MSetColorArrayImpl_Int32_ColorArray_Int32;
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
				}
				return r_MGetVectorArrayImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color[] GetColorArrayImpl(Int32)
		/// </summary>
		protected RMethod r_MGetColorArrayImpl_Int32;
		public virtual RMethod RMGetColorArrayImpl_Int32
		{
			get
			{
				if(r_MGetColorArrayImpl_Int32 == null)
				{
					r_MGetColorArrayImpl_Int32 = new(this, "GetColorArrayImpl", 0, typeof(System.Int32));
				}
				return r_MGetColorArrayImpl_Int32;
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
				}
				return r_MGetVectorArrayCountImpl_Int32;
			}
		}

		/// <summary>
		/// Int32 GetColorArrayCountImpl(Int32)
		/// </summary>
		protected RMethod r_MGetColorArrayCountImpl_Int32;
		public virtual RMethod RMGetColorArrayCountImpl_Int32
		{
			get
			{
				if(r_MGetColorArrayCountImpl_Int32 == null)
				{
					r_MGetColorArrayCountImpl_Int32 = new(this, "GetColorArrayCountImpl", 0, typeof(System.Int32));
				}
				return r_MGetColorArrayCountImpl_Int32;
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
				}
				return r_MExtractVectorArrayImpl_Int32_Vector4Array;
			}
		}

		/// <summary>
		/// Void ExtractColorArrayImpl(Int32, UnityEngine.Color[])
		/// </summary>
		protected RMethod r_MExtractColorArrayImpl_Int32_ColorArray;
		public virtual RMethod RMExtractColorArrayImpl_Int32_ColorArray
		{
			get
			{
				if(r_MExtractColorArrayImpl_Int32_ColorArray == null)
				{
					r_MExtractColorArrayImpl_Int32_ColorArray = new(this, "ExtractColorArrayImpl", 0, typeof(System.Int32), typeof(UnityEngine.Color).MakeArrayType());
				}
				return r_MExtractColorArrayImpl_Int32_ColorArray;
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
				}
				return r_MExtractMatrixArrayImpl_Int32_Matrix4x4Array;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 GetTextureScaleAndOffsetImpl(Int32)
		/// </summary>
		protected RMethod r_MGetTextureScaleAndOffsetImpl_Int32;
		public virtual RMethod RMGetTextureScaleAndOffsetImpl_Int32
		{
			get
			{
				if(r_MGetTextureScaleAndOffsetImpl_Int32 == null)
				{
					r_MGetTextureScaleAndOffsetImpl_Int32 = new(this, "GetTextureScaleAndOffsetImpl", 0, typeof(System.Int32));
				}
				return r_MGetTextureScaleAndOffsetImpl_Int32;
			}
		}

		/// <summary>
		/// Void SetTextureOffsetImpl(Int32, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MSetTextureOffsetImpl_Int32_Vector2;
		public virtual RMethod RMSetTextureOffsetImpl_Int32_Vector2
		{
			get
			{
				if(r_MSetTextureOffsetImpl_Int32_Vector2 == null)
				{
					r_MSetTextureOffsetImpl_Int32_Vector2 = new(this, "SetTextureOffsetImpl", 0, typeof(System.Int32), typeof(UnityEngine.Vector2));
				}
				return r_MSetTextureOffsetImpl_Int32_Vector2;
			}
		}

		/// <summary>
		/// Void SetTextureScaleImpl(Int32, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MSetTextureScaleImpl_Int32_Vector2;
		public virtual RMethod RMSetTextureScaleImpl_Int32_Vector2
		{
			get
			{
				if(r_MSetTextureScaleImpl_Int32_Vector2 == null)
				{
					r_MSetTextureScaleImpl_Int32_Vector2 = new(this, "SetTextureScaleImpl", 0, typeof(System.Int32), typeof(UnityEngine.Vector2));
				}
				return r_MSetTextureScaleImpl_Int32_Vector2;
			}
		}

		/// <summary>
		/// Boolean IsChildOf(UnityEngine.Material)
		/// </summary>
		protected RMethod r_MIsChildOf_Material;
		public virtual RMethod RMIsChildOf_Material
		{
			get
			{
				if(r_MIsChildOf_Material == null)
				{
					r_MIsChildOf_Material = new(this, "IsChildOf", 0, typeof(UnityEngine.Material));
				}
				return r_MIsChildOf_Material;
			}
		}

		/// <summary>
		/// Void RevertAllPropertyOverrides()
		/// </summary>
		protected RMethod r_MRevertAllPropertyOverrides;
		public virtual RMethod RMRevertAllPropertyOverrides
		{
			get
			{
				if(r_MRevertAllPropertyOverrides == null)
				{
					r_MRevertAllPropertyOverrides = new(this, "RevertAllPropertyOverrides", 0);
				}
				return r_MRevertAllPropertyOverrides;
			}
		}

		/// <summary>
		/// Boolean IsPropertyOverriden(Int32)
		/// </summary>
		protected RMethod r_MIsPropertyOverriden_Int32;
		public virtual RMethod RMIsPropertyOverriden_Int32
		{
			get
			{
				if(r_MIsPropertyOverriden_Int32 == null)
				{
					r_MIsPropertyOverriden_Int32 = new(this, "IsPropertyOverriden", 0, typeof(System.Int32));
				}
				return r_MIsPropertyOverriden_Int32;
			}
		}

		/// <summary>
		/// Boolean IsPropertyLocked(Int32)
		/// </summary>
		protected RMethod r_MIsPropertyLocked_Int32;
		public virtual RMethod RMIsPropertyLocked_Int32
		{
			get
			{
				if(r_MIsPropertyLocked_Int32 == null)
				{
					r_MIsPropertyLocked_Int32 = new(this, "IsPropertyLocked", 0, typeof(System.Int32));
				}
				return r_MIsPropertyLocked_Int32;
			}
		}

		/// <summary>
		/// Boolean IsPropertyLockedByAncestor(Int32)
		/// </summary>
		protected RMethod r_MIsPropertyLockedByAncestor_Int32;
		public virtual RMethod RMIsPropertyLockedByAncestor_Int32
		{
			get
			{
				if(r_MIsPropertyLockedByAncestor_Int32 == null)
				{
					r_MIsPropertyLockedByAncestor_Int32 = new(this, "IsPropertyLockedByAncestor", 0, typeof(System.Int32));
				}
				return r_MIsPropertyLockedByAncestor_Int32;
			}
		}

		/// <summary>
		/// Boolean IsPropertyOverriden(System.String)
		/// </summary>
		protected RMethod r_MIsPropertyOverriden_String;
		public virtual RMethod RMIsPropertyOverriden_String
		{
			get
			{
				if(r_MIsPropertyOverriden_String == null)
				{
					r_MIsPropertyOverriden_String = new(this, "IsPropertyOverriden", 0, typeof(System.String));
				}
				return r_MIsPropertyOverriden_String;
			}
		}

		/// <summary>
		/// Boolean IsPropertyLocked(System.String)
		/// </summary>
		protected RMethod r_MIsPropertyLocked_String;
		public virtual RMethod RMIsPropertyLocked_String
		{
			get
			{
				if(r_MIsPropertyLocked_String == null)
				{
					r_MIsPropertyLocked_String = new(this, "IsPropertyLocked", 0, typeof(System.String));
				}
				return r_MIsPropertyLocked_String;
			}
		}

		/// <summary>
		/// Boolean IsPropertyLockedByAncestor(System.String)
		/// </summary>
		protected RMethod r_MIsPropertyLockedByAncestor_String;
		public virtual RMethod RMIsPropertyLockedByAncestor_String
		{
			get
			{
				if(r_MIsPropertyLockedByAncestor_String == null)
				{
					r_MIsPropertyLockedByAncestor_String = new(this, "IsPropertyLockedByAncestor", 0, typeof(System.String));
				}
				return r_MIsPropertyLockedByAncestor_String;
			}
		}

		/// <summary>
		/// Void SetPropertyLock(Int32, Boolean)
		/// </summary>
		protected RMethod r_MSetPropertyLock_Int32_Boolean;
		public virtual RMethod RMSetPropertyLock_Int32_Boolean
		{
			get
			{
				if(r_MSetPropertyLock_Int32_Boolean == null)
				{
					r_MSetPropertyLock_Int32_Boolean = new(this, "SetPropertyLock", 0, typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MSetPropertyLock_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void ApplyPropertyOverride(UnityEngine.Material, Int32, Boolean)
		/// </summary>
		protected RMethod r_MApplyPropertyOverride_Material_Int32_Boolean;
		public virtual RMethod RMApplyPropertyOverride_Material_Int32_Boolean
		{
			get
			{
				if(r_MApplyPropertyOverride_Material_Int32_Boolean == null)
				{
					r_MApplyPropertyOverride_Material_Int32_Boolean = new(this, "ApplyPropertyOverride", 0, typeof(UnityEngine.Material), typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MApplyPropertyOverride_Material_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void RevertPropertyOverride(Int32)
		/// </summary>
		protected RMethod r_MRevertPropertyOverride_Int32;
		public virtual RMethod RMRevertPropertyOverride_Int32
		{
			get
			{
				if(r_MRevertPropertyOverride_Int32 == null)
				{
					r_MRevertPropertyOverride_Int32 = new(this, "RevertPropertyOverride", 0, typeof(System.Int32));
				}
				return r_MRevertPropertyOverride_Int32;
			}
		}

		/// <summary>
		/// Void GetPropertyState(Int32, Boolean ByRef, Boolean ByRef, Boolean ByRef)
		/// </summary>
		protected RMethod r_MGetPropertyState_Int32_Out_Boolean_Out_Boolean_Out_Boolean;
		public virtual RMethod RMGetPropertyState_Int32_Out_Boolean_Out_Boolean_Out_Boolean
		{
			get
			{
				if(r_MGetPropertyState_Int32_Out_Boolean_Out_Boolean_Out_Boolean == null)
				{
					r_MGetPropertyState_Int32_Out_Boolean_Out_Boolean_Out_Boolean = new(this, "GetPropertyState", 0, typeof(System.Int32), typeof(System.Boolean).MakeByRefType(), typeof(System.Boolean).MakeByRefType(), typeof(System.Boolean).MakeByRefType());
				}
				return r_MGetPropertyState_Int32_Out_Boolean_Out_Boolean_Out_Boolean;
			}
		}

		/// <summary>
		/// Void SetPropertyLock(System.String, Boolean)
		/// </summary>
		protected RMethod r_MSetPropertyLock_String_Boolean;
		public virtual RMethod RMSetPropertyLock_String_Boolean
		{
			get
			{
				if(r_MSetPropertyLock_String_Boolean == null)
				{
					r_MSetPropertyLock_String_Boolean = new(this, "SetPropertyLock", 0, typeof(System.String), typeof(System.Boolean));
				}
				return r_MSetPropertyLock_String_Boolean;
			}
		}

		/// <summary>
		/// Void ApplyPropertyOverride(UnityEngine.Material, System.String, Boolean)
		/// </summary>
		protected RMethod r_MApplyPropertyOverride_Material_String_Boolean;
		public virtual RMethod RMApplyPropertyOverride_Material_String_Boolean
		{
			get
			{
				if(r_MApplyPropertyOverride_Material_String_Boolean == null)
				{
					r_MApplyPropertyOverride_Material_String_Boolean = new(this, "ApplyPropertyOverride", 0, typeof(UnityEngine.Material), typeof(System.String), typeof(System.Boolean));
				}
				return r_MApplyPropertyOverride_Material_String_Boolean;
			}
		}

		/// <summary>
		/// Void RevertPropertyOverride(System.String)
		/// </summary>
		protected RMethod r_MRevertPropertyOverride_String;
		public virtual RMethod RMRevertPropertyOverride_String
		{
			get
			{
				if(r_MRevertPropertyOverride_String == null)
				{
					r_MRevertPropertyOverride_String = new(this, "RevertPropertyOverride", 0, typeof(System.String));
				}
				return r_MRevertPropertyOverride_String;
			}
		}

		/// <summary>
		/// Void SetPropertyLock_Serialized(UnityEngine.MaterialSerializedProperty, Boolean)
		/// </summary>
		protected RMethod r_MSetPropertyLock_Serialized_MaterialSerializedProperty_Boolean;
		public virtual RMethod RMSetPropertyLock_Serialized_MaterialSerializedProperty_Boolean
		{
			get
			{
				if(r_MSetPropertyLock_Serialized_MaterialSerializedProperty_Boolean == null)
				{
					r_MSetPropertyLock_Serialized_MaterialSerializedProperty_Boolean = new(this, "SetPropertyLock_Serialized", 0,  ReflectionUtils.GetType("UnityEngine.MaterialSerializedProperty"), typeof(System.Boolean));
				}
				return r_MSetPropertyLock_Serialized_MaterialSerializedProperty_Boolean;
			}
		}

		/// <summary>
		/// Void ApplyPropertyOverride_Serialized(UnityEngine.Material, UnityEngine.MaterialSerializedProperty, Boolean)
		/// </summary>
		protected RMethod r_MApplyPropertyOverride_Serialized_Material_MaterialSerializedProperty_Boolean;
		public virtual RMethod RMApplyPropertyOverride_Serialized_Material_MaterialSerializedProperty_Boolean
		{
			get
			{
				if(r_MApplyPropertyOverride_Serialized_Material_MaterialSerializedProperty_Boolean == null)
				{
					r_MApplyPropertyOverride_Serialized_Material_MaterialSerializedProperty_Boolean = new(this, "ApplyPropertyOverride_Serialized", 0, typeof(UnityEngine.Material),  ReflectionUtils.GetType("UnityEngine.MaterialSerializedProperty"), typeof(System.Boolean));
				}
				return r_MApplyPropertyOverride_Serialized_Material_MaterialSerializedProperty_Boolean;
			}
		}

		/// <summary>
		/// Void RevertPropertyOverride_Serialized(UnityEngine.MaterialSerializedProperty)
		/// </summary>
		protected RMethod r_MRevertPropertyOverride_Serialized_MaterialSerializedProperty;
		public virtual RMethod RMRevertPropertyOverride_Serialized_MaterialSerializedProperty
		{
			get
			{
				if(r_MRevertPropertyOverride_Serialized_MaterialSerializedProperty == null)
				{
					r_MRevertPropertyOverride_Serialized_MaterialSerializedProperty = new(this, "RevertPropertyOverride_Serialized", 0,  ReflectionUtils.GetType("UnityEngine.MaterialSerializedProperty"));
				}
				return r_MRevertPropertyOverride_Serialized_MaterialSerializedProperty;
			}
		}

		/// <summary>
		/// Void GetPropertyState_Serialized(UnityEngine.MaterialSerializedProperty, Boolean ByRef, Boolean ByRef, Boolean ByRef)
		/// </summary>
		protected RMethod r_MGetPropertyState_Serialized_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean;
		public virtual RMethod RMGetPropertyState_Serialized_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean
		{
			get
			{
				if(r_MGetPropertyState_Serialized_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean == null)
				{
					r_MGetPropertyState_Serialized_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean = new(this, "GetPropertyState_Serialized", 0,  ReflectionUtils.GetType("UnityEngine.MaterialSerializedProperty"), typeof(System.Boolean).MakeByRefType(), typeof(System.Boolean).MakeByRefType(), typeof(System.Boolean).MakeByRefType());
				}
				return r_MGetPropertyState_Serialized_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean;
			}
		}

		/// <summary>
		/// Void SetPropertyLock(UnityEngine.MaterialSerializedProperty, Boolean)
		/// </summary>
		protected RMethod r_MSetPropertyLock_MaterialSerializedProperty_Boolean;
		public virtual RMethod RMSetPropertyLock_MaterialSerializedProperty_Boolean
		{
			get
			{
				if(r_MSetPropertyLock_MaterialSerializedProperty_Boolean == null)
				{
					r_MSetPropertyLock_MaterialSerializedProperty_Boolean = new(this, "SetPropertyLock", 0,  ReflectionUtils.GetType("UnityEngine.MaterialSerializedProperty"), typeof(System.Boolean));
				}
				return r_MSetPropertyLock_MaterialSerializedProperty_Boolean;
			}
		}

		/// <summary>
		/// Void ApplyPropertyOverride(UnityEngine.Material, UnityEngine.MaterialSerializedProperty, Boolean)
		/// </summary>
		protected RMethod r_MApplyPropertyOverride_Material_MaterialSerializedProperty_Boolean;
		public virtual RMethod RMApplyPropertyOverride_Material_MaterialSerializedProperty_Boolean
		{
			get
			{
				if(r_MApplyPropertyOverride_Material_MaterialSerializedProperty_Boolean == null)
				{
					r_MApplyPropertyOverride_Material_MaterialSerializedProperty_Boolean = new(this, "ApplyPropertyOverride", 0, typeof(UnityEngine.Material),  ReflectionUtils.GetType("UnityEngine.MaterialSerializedProperty"), typeof(System.Boolean));
				}
				return r_MApplyPropertyOverride_Material_MaterialSerializedProperty_Boolean;
			}
		}

		/// <summary>
		/// Void RevertPropertyOverride(UnityEngine.MaterialSerializedProperty)
		/// </summary>
		protected RMethod r_MRevertPropertyOverride_MaterialSerializedProperty;
		public virtual RMethod RMRevertPropertyOverride_MaterialSerializedProperty
		{
			get
			{
				if(r_MRevertPropertyOverride_MaterialSerializedProperty == null)
				{
					r_MRevertPropertyOverride_MaterialSerializedProperty = new(this, "RevertPropertyOverride", 0,  ReflectionUtils.GetType("UnityEngine.MaterialSerializedProperty"));
				}
				return r_MRevertPropertyOverride_MaterialSerializedProperty;
			}
		}

		/// <summary>
		/// Void GetPropertyState(UnityEngine.MaterialSerializedProperty, Boolean ByRef, Boolean ByRef, Boolean ByRef)
		/// </summary>
		protected RMethod r_MGetPropertyState_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean;
		public virtual RMethod RMGetPropertyState_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean
		{
			get
			{
				if(r_MGetPropertyState_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean == null)
				{
					r_MGetPropertyState_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean = new(this, "GetPropertyState", 0,  ReflectionUtils.GetType("UnityEngine.MaterialSerializedProperty"), typeof(System.Boolean).MakeByRefType(), typeof(System.Boolean).MakeByRefType(), typeof(System.Boolean).MakeByRefType());
				}
				return r_MGetPropertyState_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean;
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
				}
				return r_MSetVectorArray_Int32_Vector4Array_Int32;
			}
		}

		/// <summary>
		/// Void SetColorArray(Int32, UnityEngine.Color[], Int32)
		/// </summary>
		protected RMethod r_MSetColorArray_Int32_ColorArray_Int32;
		public virtual RMethod RMSetColorArray_Int32_ColorArray_Int32
		{
			get
			{
				if(r_MSetColorArray_Int32_ColorArray_Int32 == null)
				{
					r_MSetColorArray_Int32_ColorArray_Int32 = new(this, "SetColorArray", 0, typeof(System.Int32), typeof(UnityEngine.Color).MakeArrayType(), typeof(System.Int32));
				}
				return r_MSetColorArray_Int32_ColorArray_Int32;
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
					r_MExtractFloatArray_Int32_List_d_Single_p_ = new(this, "ExtractFloatArray", 0, typeof(System.Int32),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.Single)));
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
					r_MExtractVectorArray_Int32_List_d_Vector4_p_ = new(this, "ExtractVectorArray", 0, typeof(System.Int32),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Vector4)));
				}
				return r_MExtractVectorArray_Int32_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void ExtractColorArray(Int32, System.Collections.Generic.List`1[UnityEngine.Color])
		/// </summary>
		protected RMethod r_MExtractColorArray_Int32_List_d_Color_p_;
		public virtual RMethod RMExtractColorArray_Int32_List_d_Color_p_
		{
			get
			{
				if(r_MExtractColorArray_Int32_List_d_Color_p_ == null)
				{
					r_MExtractColorArray_Int32_List_d_Color_p_ = new(this, "ExtractColorArray", 0, typeof(System.Int32),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Color)));
				}
				return r_MExtractColorArray_Int32_List_d_Color_p_;
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
					r_MExtractMatrixArray_Int32_List_d_Matrix4x4_p_ = new(this, "ExtractMatrixArray", 0, typeof(System.Int32),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Matrix4x4)));
				}
				return r_MExtractMatrixArray_Int32_List_d_Matrix4x4_p_;
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
				}
				return r_MSetInteger_Int32_Int32;
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
				}
				return r_MSetColor_Int32_Color;
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
				}
				return r_MSetVector_Int32_Vector4;
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
				}
				return r_MSetMatrix_Int32_Matrix4x4;
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
				}
				return r_MSetTexture_Int32_RenderTexture_RenderTextureSubElement;
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
				}
				return r_MSetBuffer_Int32_GraphicsBuffer;
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
					r_MSetFloatArray_String_List_d_Single_p_ = new(this, "SetFloatArray", 0, typeof(System.String),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.Single)));
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
					r_MSetFloatArray_Int32_List_d_Single_p_ = new(this, "SetFloatArray", 0, typeof(System.Int32),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.Single)));
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
				}
				return r_MSetFloatArray_Int32_SingleArray;
			}
		}

		/// <summary>
		/// Void SetColorArray(System.String, System.Collections.Generic.List`1[UnityEngine.Color])
		/// </summary>
		protected RMethod r_MSetColorArray_String_List_d_Color_p_;
		public virtual RMethod RMSetColorArray_String_List_d_Color_p_
		{
			get
			{
				if(r_MSetColorArray_String_List_d_Color_p_ == null)
				{
					r_MSetColorArray_String_List_d_Color_p_ = new(this, "SetColorArray", 0, typeof(System.String),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Color)));
				}
				return r_MSetColorArray_String_List_d_Color_p_;
			}
		}

		/// <summary>
		/// Void SetColorArray(Int32, System.Collections.Generic.List`1[UnityEngine.Color])
		/// </summary>
		protected RMethod r_MSetColorArray_Int32_List_d_Color_p_;
		public virtual RMethod RMSetColorArray_Int32_List_d_Color_p_
		{
			get
			{
				if(r_MSetColorArray_Int32_List_d_Color_p_ == null)
				{
					r_MSetColorArray_Int32_List_d_Color_p_ = new(this, "SetColorArray", 0, typeof(System.Int32),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Color)));
				}
				return r_MSetColorArray_Int32_List_d_Color_p_;
			}
		}

		/// <summary>
		/// Void SetColorArray(System.String, UnityEngine.Color[])
		/// </summary>
		protected RMethod r_MSetColorArray_String_ColorArray;
		public virtual RMethod RMSetColorArray_String_ColorArray
		{
			get
			{
				if(r_MSetColorArray_String_ColorArray == null)
				{
					r_MSetColorArray_String_ColorArray = new(this, "SetColorArray", 0, typeof(System.String), typeof(UnityEngine.Color).MakeArrayType());
				}
				return r_MSetColorArray_String_ColorArray;
			}
		}

		/// <summary>
		/// Void SetColorArray(Int32, UnityEngine.Color[])
		/// </summary>
		protected RMethod r_MSetColorArray_Int32_ColorArray;
		public virtual RMethod RMSetColorArray_Int32_ColorArray
		{
			get
			{
				if(r_MSetColorArray_Int32_ColorArray == null)
				{
					r_MSetColorArray_Int32_ColorArray = new(this, "SetColorArray", 0, typeof(System.Int32), typeof(UnityEngine.Color).MakeArrayType());
				}
				return r_MSetColorArray_Int32_ColorArray;
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
					r_MSetVectorArray_String_List_d_Vector4_p_ = new(this, "SetVectorArray", 0, typeof(System.String),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Vector4)));
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
					r_MSetVectorArray_Int32_List_d_Vector4_p_ = new(this, "SetVectorArray", 0, typeof(System.Int32),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Vector4)));
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
					r_MSetMatrixArray_String_List_d_Matrix4x4_p_ = new(this, "SetMatrixArray", 0, typeof(System.String),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Matrix4x4)));
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
					r_MSetMatrixArray_Int32_List_d_Matrix4x4_p_ = new(this, "SetMatrixArray", 0, typeof(System.Int32),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Matrix4x4)));
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
				}
				return r_MSetMatrixArray_Int32_Matrix4x4Array;
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
				}
				return r_MGetInt_Int32;
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
				}
				return r_MGetFloat_Int32;
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
				}
				return r_MGetInteger_Int32;
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
				}
				return r_MGetColor_Int32;
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
				}
				return r_MGetVector_Int32;
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
				}
				return r_MGetTexture_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBufferHandle GetBuffer(System.String)
		/// </summary>
		protected RMethod r_MGetBuffer_String;
		public virtual RMethod RMGetBuffer_String
		{
			get
			{
				if(r_MGetBuffer_String == null)
				{
					r_MGetBuffer_String = new(this, "GetBuffer", 0, typeof(System.String));
				}
				return r_MGetBuffer_String;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBufferHandle GetConstantBuffer(System.String)
		/// </summary>
		protected RMethod r_MGetConstantBuffer_String;
		public virtual RMethod RMGetConstantBuffer_String
		{
			get
			{
				if(r_MGetConstantBuffer_String == null)
				{
					r_MGetConstantBuffer_String = new(this, "GetConstantBuffer", 0, typeof(System.String));
				}
				return r_MGetConstantBuffer_String;
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
				}
				return r_MGetFloatArray_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color[] GetColorArray(System.String)
		/// </summary>
		protected RMethod r_MGetColorArray_String;
		public virtual RMethod RMGetColorArray_String
		{
			get
			{
				if(r_MGetColorArray_String == null)
				{
					r_MGetColorArray_String = new(this, "GetColorArray", 0, typeof(System.String));
				}
				return r_MGetColorArray_String;
			}
		}

		/// <summary>
		/// UnityEngine.Color[] GetColorArray(Int32)
		/// </summary>
		protected RMethod r_MGetColorArray_Int32;
		public virtual RMethod RMGetColorArray_Int32
		{
			get
			{
				if(r_MGetColorArray_Int32 == null)
				{
					r_MGetColorArray_Int32 = new(this, "GetColorArray", 0, typeof(System.Int32));
				}
				return r_MGetColorArray_Int32;
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
					r_MGetFloatArray_String_List_d_Single_p_ = new(this, "GetFloatArray", 0, typeof(System.String),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.Single)));
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
					r_MGetFloatArray_Int32_List_d_Single_p_ = new(this, "GetFloatArray", 0, typeof(System.Int32),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.Single)));
				}
				return r_MGetFloatArray_Int32_List_d_Single_p_;
			}
		}

		/// <summary>
		/// Void GetColorArray(System.String, System.Collections.Generic.List`1[UnityEngine.Color])
		/// </summary>
		protected RMethod r_MGetColorArray_String_List_d_Color_p_;
		public virtual RMethod RMGetColorArray_String_List_d_Color_p_
		{
			get
			{
				if(r_MGetColorArray_String_List_d_Color_p_ == null)
				{
					r_MGetColorArray_String_List_d_Color_p_ = new(this, "GetColorArray", 0, typeof(System.String),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Color)));
				}
				return r_MGetColorArray_String_List_d_Color_p_;
			}
		}

		/// <summary>
		/// Void GetColorArray(Int32, System.Collections.Generic.List`1[UnityEngine.Color])
		/// </summary>
		protected RMethod r_MGetColorArray_Int32_List_d_Color_p_;
		public virtual RMethod RMGetColorArray_Int32_List_d_Color_p_
		{
			get
			{
				if(r_MGetColorArray_Int32_List_d_Color_p_ == null)
				{
					r_MGetColorArray_Int32_List_d_Color_p_ = new(this, "GetColorArray", 0, typeof(System.Int32),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Color)));
				}
				return r_MGetColorArray_Int32_List_d_Color_p_;
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
					r_MGetVectorArray_String_List_d_Vector4_p_ = new(this, "GetVectorArray", 0, typeof(System.String),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Vector4)));
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
					r_MGetVectorArray_Int32_List_d_Vector4_p_ = new(this, "GetVectorArray", 0, typeof(System.Int32),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Vector4)));
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
					r_MGetMatrixArray_String_List_d_Matrix4x4_p_ = new(this, "GetMatrixArray", 0, typeof(System.String),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Matrix4x4)));
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
					r_MGetMatrixArray_Int32_List_d_Matrix4x4_p_ = new(this, "GetMatrixArray", 0, typeof(System.Int32),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Matrix4x4)));
				}
				return r_MGetMatrixArray_Int32_List_d_Matrix4x4_p_;
			}
		}

		/// <summary>
		/// Void SetTextureOffset(System.String, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MSetTextureOffset_String_Vector2;
		public virtual RMethod RMSetTextureOffset_String_Vector2
		{
			get
			{
				if(r_MSetTextureOffset_String_Vector2 == null)
				{
					r_MSetTextureOffset_String_Vector2 = new(this, "SetTextureOffset", 0, typeof(System.String), typeof(UnityEngine.Vector2));
				}
				return r_MSetTextureOffset_String_Vector2;
			}
		}

		/// <summary>
		/// Void SetTextureOffset(Int32, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MSetTextureOffset_Int32_Vector2;
		public virtual RMethod RMSetTextureOffset_Int32_Vector2
		{
			get
			{
				if(r_MSetTextureOffset_Int32_Vector2 == null)
				{
					r_MSetTextureOffset_Int32_Vector2 = new(this, "SetTextureOffset", 0, typeof(System.Int32), typeof(UnityEngine.Vector2));
				}
				return r_MSetTextureOffset_Int32_Vector2;
			}
		}

		/// <summary>
		/// Void SetTextureScale(System.String, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MSetTextureScale_String_Vector2;
		public virtual RMethod RMSetTextureScale_String_Vector2
		{
			get
			{
				if(r_MSetTextureScale_String_Vector2 == null)
				{
					r_MSetTextureScale_String_Vector2 = new(this, "SetTextureScale", 0, typeof(System.String), typeof(UnityEngine.Vector2));
				}
				return r_MSetTextureScale_String_Vector2;
			}
		}

		/// <summary>
		/// Void SetTextureScale(Int32, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MSetTextureScale_Int32_Vector2;
		public virtual RMethod RMSetTextureScale_Int32_Vector2
		{
			get
			{
				if(r_MSetTextureScale_Int32_Vector2 == null)
				{
					r_MSetTextureScale_Int32_Vector2 = new(this, "SetTextureScale", 0, typeof(System.Int32), typeof(UnityEngine.Vector2));
				}
				return r_MSetTextureScale_Int32_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetTextureOffset(System.String)
		/// </summary>
		protected RMethod r_MGetTextureOffset_String;
		public virtual RMethod RMGetTextureOffset_String
		{
			get
			{
				if(r_MGetTextureOffset_String == null)
				{
					r_MGetTextureOffset_String = new(this, "GetTextureOffset", 0, typeof(System.String));
				}
				return r_MGetTextureOffset_String;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetTextureOffset(Int32)
		/// </summary>
		protected RMethod r_MGetTextureOffset_Int32;
		public virtual RMethod RMGetTextureOffset_Int32
		{
			get
			{
				if(r_MGetTextureOffset_Int32 == null)
				{
					r_MGetTextureOffset_Int32 = new(this, "GetTextureOffset", 0, typeof(System.Int32));
				}
				return r_MGetTextureOffset_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetTextureScale(System.String)
		/// </summary>
		protected RMethod r_MGetTextureScale_String;
		public virtual RMethod RMGetTextureScale_String
		{
			get
			{
				if(r_MGetTextureScale_String == null)
				{
					r_MGetTextureScale_String = new(this, "GetTextureScale", 0, typeof(System.String));
				}
				return r_MGetTextureScale_String;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetTextureScale(Int32)
		/// </summary>
		protected RMethod r_MGetTextureScale_Int32;
		public virtual RMethod RMGetTextureScale_Int32
		{
			get
			{
				if(r_MGetTextureScale_Int32 == null)
				{
					r_MGetTextureScale_Int32 = new(this, "GetTextureScale", 0, typeof(System.Int32));
				}
				return r_MGetTextureScale_Int32;
			}
		}

		/// <summary>
		/// System.String[] GetPropertyNames(UnityEngine.MaterialPropertyType)
		/// </summary>
		protected RMethod r_MGetPropertyNames_MaterialPropertyType;
		public virtual RMethod RMGetPropertyNames_MaterialPropertyType
		{
			get
			{
				if(r_MGetPropertyNames_MaterialPropertyType == null)
				{
					r_MGetPropertyNames_MaterialPropertyType = new(this, "GetPropertyNames", 0, typeof(UnityEngine.MaterialPropertyType));
				}
				return r_MGetPropertyNames_MaterialPropertyType;
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
				}
				return r_MIsLocalKeywordEnabled_Injected_Ref_LocalKeyword;
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
				}
				return r_MSetMatrixImpl_Injected_Int32_Ref_Matrix4x4;
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
				}
				return r_MGetMatrixImpl_Injected_Int32_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void GetBufferImpl_Injected(Int32, UnityEngine.GraphicsBufferHandle ByRef)
		/// </summary>
		protected RMethod r_MGetBufferImpl_Injected_Int32_Out_GraphicsBufferHandle;
		public virtual RMethod RMGetBufferImpl_Injected_Int32_Out_GraphicsBufferHandle
		{
			get
			{
				if(r_MGetBufferImpl_Injected_Int32_Out_GraphicsBufferHandle == null)
				{
					r_MGetBufferImpl_Injected_Int32_Out_GraphicsBufferHandle = new(this, "GetBufferImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBufferHandle).MakeByRefType());
				}
				return r_MGetBufferImpl_Injected_Int32_Out_GraphicsBufferHandle;
			}
		}

		/// <summary>
		/// Void GetConstantBufferImpl_Injected(Int32, UnityEngine.GraphicsBufferHandle ByRef)
		/// </summary>
		protected RMethod r_MGetConstantBufferImpl_Injected_Int32_Out_GraphicsBufferHandle;
		public virtual RMethod RMGetConstantBufferImpl_Injected_Int32_Out_GraphicsBufferHandle
		{
			get
			{
				if(r_MGetConstantBufferImpl_Injected_Int32_Out_GraphicsBufferHandle == null)
				{
					r_MGetConstantBufferImpl_Injected_Int32_Out_GraphicsBufferHandle = new(this, "GetConstantBufferImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBufferHandle).MakeByRefType());
				}
				return r_MGetConstantBufferImpl_Injected_Int32_Out_GraphicsBufferHandle;
			}
		}

		/// <summary>
		/// Void GetTextureScaleAndOffsetImpl_Injected(Int32, UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_MGetTextureScaleAndOffsetImpl_Injected_Int32_Out_Vector4;
		public virtual RMethod RMGetTextureScaleAndOffsetImpl_Injected_Int32_Out_Vector4
		{
			get
			{
				if(r_MGetTextureScaleAndOffsetImpl_Injected_Int32_Out_Vector4 == null)
				{
					r_MGetTextureScaleAndOffsetImpl_Injected_Int32_Out_Vector4 = new(this, "GetTextureScaleAndOffsetImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeByRefType());
				}
				return r_MGetTextureScaleAndOffsetImpl_Injected_Int32_Out_Vector4;
			}
		}

		/// <summary>
		/// Void SetTextureOffsetImpl_Injected(Int32, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_MSetTextureOffsetImpl_Injected_Int32_Ref_Vector2;
		public virtual RMethod RMSetTextureOffsetImpl_Injected_Int32_Ref_Vector2
		{
			get
			{
				if(r_MSetTextureOffsetImpl_Injected_Int32_Ref_Vector2 == null)
				{
					r_MSetTextureOffsetImpl_Injected_Int32_Ref_Vector2 = new(this, "SetTextureOffsetImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Vector2).MakeByRefType());
				}
				return r_MSetTextureOffsetImpl_Injected_Int32_Ref_Vector2;
			}
		}

		/// <summary>
		/// Void SetTextureScaleImpl_Injected(Int32, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_MSetTextureScaleImpl_Injected_Int32_Ref_Vector2;
		public virtual RMethod RMSetTextureScaleImpl_Injected_Int32_Ref_Vector2
		{
			get
			{
				if(r_MSetTextureScaleImpl_Injected_Int32_Ref_Vector2 == null)
				{
					r_MSetTextureScaleImpl_Injected_Int32_Ref_Vector2 = new(this, "SetTextureScaleImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Vector2).MakeByRefType());
				}
				return r_MSetTextureScaleImpl_Injected_Int32_Ref_Vector2;
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


        public static UnityEngine.Material Create(System.String @scriptContents)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scriptContents};
            var ___result = RMCreate_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Material>(___result);
        }


        public static void CreateWithShader(UnityEngine.Material @self, UnityEngine.Shader @shader)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @shader};
            var ___result = RMCreateWithShader_Material_Shader.Invoke(___genericsType, ___parameters);

            
        }


        public static void CreateWithMaterial(UnityEngine.Material @self, UnityEngine.Material @source)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @source};
            var ___result = RMCreateWithMaterial_Material_Material.Invoke(___genericsType, ___parameters);

            
        }


        public static void CreateWithString(UnityEngine.Material @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RMCreateWithString_Material.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Material GetDefaultMaterial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDefaultMaterial.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Material>(___result);
        }


        public static UnityEngine.Material GetDefaultParticleMaterial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDefaultParticleMaterial.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Material>(___result);
        }


        public static UnityEngine.Material GetDefaultLineMaterial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDefaultLineMaterial.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Material>(___result);
        }


        public virtual System.Int32 GetFirstPropertyNameIdByAttribute(UnityEngine.Rendering.ShaderPropertyFlags @attributeFlag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeFlag};
            var ___result = RMGetFirstPropertyNameIdByAttribute_ShaderPropertyFlags.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean HasProperty(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMHasProperty_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasProperty(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasProperty_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasFloatImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasFloatImpl_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasFloat(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasFloat_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasFloat(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMHasFloat_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasInt(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasInt_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasInt(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMHasInt_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasIntImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasIntImpl_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasInteger(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasInteger_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasInteger(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMHasInteger_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasTextureImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasTextureImpl_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasTexture(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasTexture_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasTexture(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMHasTexture_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasMatrixImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasMatrixImpl_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasMatrix(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasMatrix_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasMatrix(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMHasMatrix_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasVectorImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasVectorImpl_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasVector(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasVector_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasVector(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMHasVector_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasColor(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasColor_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasColor(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMHasColor_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasBufferImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasBufferImpl_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasBuffer(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasBuffer_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasBuffer(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMHasBuffer_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasConstantBufferImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasConstantBufferImpl_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasConstantBuffer(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMHasConstantBuffer_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasConstantBuffer(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMHasConstantBuffer_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual UnityEngine.Rendering.LocalKeyword[] GetEnabledKeywords()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnabledKeywords.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Rendering.LocalKeyword[]>(___result);
        }


        public virtual void SetEnabledKeywords(UnityEngine.Rendering.LocalKeyword[] @keywords)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keywords};
            var ___result = RMSetEnabledKeywords_LocalKeywordArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetShaderPassEnabled(System.String @passName, System.Boolean @enabled)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@passName, @enabled};
            var ___result = RMSetShaderPassEnabled_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean GetShaderPassEnabled(System.String @passName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@passName};
            var ___result = RMGetShaderPassEnabled_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.String GetPassName(System.Int32 @pass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pass};
            var ___result = RMGetPassName_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Int32 FindPass(System.String @passName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@passName};
            var ___result = RMFindPass_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual void SetOverrideTag(System.String @tag, System.String @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag, @val};
            var ___result = RMSetOverrideTag_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetTagImpl(System.String @tag, System.Boolean @currentSubShaderOnly, System.String @defaultValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag, @currentSubShaderOnly, @defaultValue};
            var ___result = RMGetTagImpl_String_Boolean_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String GetTag(System.String @tag, System.Boolean @searchFallbacks, System.String @defaultValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag, @searchFallbacks, @defaultValue};
            var ___result = RMGetTag_String_Boolean_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String GetTag(System.String @tag, System.Boolean @searchFallbacks)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag, @searchFallbacks};
            var ___result = RMGetTag_String_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual void Lerp(UnityEngine.Material @start, UnityEngine.Material @end, System.Single @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @end, @t};
            var ___result = RMLerp_Material_Material_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SetPass(System.Int32 @pass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pass};
            var ___result = RMSetPass_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void CopyPropertiesFromMaterial(UnityEngine.Material @mat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mat};
            var ___result = RMCopyPropertiesFromMaterial_Material.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String[] GetShaderKeywords()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetShaderKeywords.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String[]>(___result);
        }


        public virtual void SetShaderKeywords(System.String[] @names)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@names};
            var ___result = RMSetShaderKeywords_StringArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String[] GetPropertyNamesImpl(System.Int32 @propertyType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyType};
            var ___result = RMGetPropertyNamesImpl_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String[]>(___result);
        }


        public virtual System.Int32 ComputeCRC()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMComputeCRC.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String[] GetTexturePropertyNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTexturePropertyNames.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String[]>(___result);
        }


        public virtual System.Int32[] GetTexturePropertyNameIDs()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTexturePropertyNameIDs.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32[]>(___result);
        }


        public virtual void GetTexturePropertyNamesInternal(System.Object @outNames)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outNames};
            var ___result = RMGetTexturePropertyNamesInternal_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTexturePropertyNameIDsInternal(System.Object @outNames)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outNames};
            var ___result = RMGetTexturePropertyNameIDsInternal_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTexturePropertyNames(System.Collections.Generic.List<System.String> @outNames)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outNames};
            var ___result = RMGetTexturePropertyNames_List_d_String_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTexturePropertyNameIDs(System.Collections.Generic.List<System.Int32> @outNames)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outNames};
            var ___result = RMGetTexturePropertyNameIDs_List_d_Int32_p_.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Int32 GetIntImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetIntImpl_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Single GetFloatImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetFloatImpl_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public virtual UnityEngine.Color GetColorImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetColorImpl_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Color>(___result);
        }


        public virtual UnityEngine.Matrix4x4 GetMatrixImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetMatrixImpl_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Matrix4x4>(___result);
        }


        public virtual UnityEngine.Texture GetTextureImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetTextureImpl_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Texture>(___result);
        }


        public virtual UnityEngine.GraphicsBufferHandle GetBufferImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetBufferImpl_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.GraphicsBufferHandle>(___result);
        }


        public virtual UnityEngine.GraphicsBufferHandle GetConstantBufferImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetConstantBufferImpl_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.GraphicsBufferHandle>(___result);
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


        public virtual void SetColorArrayImpl(System.Int32 @name, UnityEngine.Color[] @values, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values, @count};
            var ___result = RMSetColorArrayImpl_Int32_ColorArray_Int32.Invoke(___genericsType, ___parameters);

            
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

            return ReflectionUtils.Convert<System.Single[]>(___result);
        }


        public virtual UnityEngine.Vector4[] GetVectorArrayImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetVectorArrayImpl_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector4[]>(___result);
        }


        public virtual UnityEngine.Color[] GetColorArrayImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetColorArrayImpl_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Color[]>(___result);
        }


        public virtual UnityEngine.Matrix4x4[] GetMatrixArrayImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetMatrixArrayImpl_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Matrix4x4[]>(___result);
        }


        public virtual System.Int32 GetFloatArrayCountImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetFloatArrayCountImpl_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetVectorArrayCountImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetVectorArrayCountImpl_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetColorArrayCountImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetColorArrayCountImpl_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetMatrixArrayCountImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetMatrixArrayCountImpl_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
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


        public virtual void ExtractColorArrayImpl(System.Int32 @name, UnityEngine.Color[] @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RMExtractColorArrayImpl_Int32_ColorArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExtractMatrixArrayImpl(System.Int32 @name, UnityEngine.Matrix4x4[] @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RMExtractMatrixArrayImpl_Int32_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector4 GetTextureScaleAndOffsetImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetTextureScaleAndOffsetImpl_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector4>(___result);
        }


        public virtual void SetTextureOffsetImpl(System.Int32 @name, UnityEngine.Vector2 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @offset};
            var ___result = RMSetTextureOffsetImpl_Int32_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTextureScaleImpl(System.Int32 @name, UnityEngine.Vector2 @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @scale};
            var ___result = RMSetTextureScaleImpl_Int32_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsChildOf(UnityEngine.Material @ancestor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ancestor};
            var ___result = RMIsChildOf_Material.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void RevertAllPropertyOverrides()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRevertAllPropertyOverrides.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsPropertyOverriden(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMIsPropertyOverriden_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean IsPropertyLocked(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMIsPropertyLocked_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean IsPropertyLockedByAncestor(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMIsPropertyLockedByAncestor_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean IsPropertyOverriden(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMIsPropertyOverriden_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean IsPropertyLocked(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMIsPropertyLocked_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean IsPropertyLockedByAncestor(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMIsPropertyLockedByAncestor_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void SetPropertyLock(System.Int32 @nameID, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetPropertyLock_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyOverride(UnityEngine.Material @destination, System.Int32 @nameID, System.Boolean @recordUndo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination, @nameID, @recordUndo};
            var ___result = RMApplyPropertyOverride_Material_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RevertPropertyOverride(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMRevertPropertyOverride_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetPropertyState(System.Int32 @nameID, out System.Boolean @isOverriden, out System.Boolean @isLockedInChildren, out System.Boolean @isLockedByAncestor)
        {
			@isOverriden = default;
			@isLockedInChildren = default;
			@isLockedByAncestor = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @isOverriden, @isLockedInChildren, @isLockedByAncestor};
            var ___result = RMGetPropertyState_Int32_Out_Boolean_Out_Boolean_Out_Boolean.Invoke(___genericsType, ___parameters);
			@isOverriden = ReflectionUtils.Convert<System.Boolean>(___parameters[1]);
			@isLockedInChildren = ReflectionUtils.Convert<System.Boolean>(___parameters[2]);
			@isLockedByAncestor = ReflectionUtils.Convert<System.Boolean>(___parameters[3]);

            
        }


        public virtual void SetPropertyLock(System.String @name, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetPropertyLock_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyOverride(UnityEngine.Material @destination, System.String @name, System.Boolean @recordUndo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination, @name, @recordUndo};
            var ___result = RMApplyPropertyOverride_Material_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RevertPropertyOverride(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMRevertPropertyOverride_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPropertyLock_Serialized(Hvak.Editor.Refleaction.RUnityEngine.RMaterialSerializedProperty @property, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property.Value, @value};
            var ___result = RMSetPropertyLock_Serialized_MaterialSerializedProperty_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyOverride_Serialized(UnityEngine.Material @destination, Hvak.Editor.Refleaction.RUnityEngine.RMaterialSerializedProperty @property, System.Boolean @recordUndo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination, @property.Value, @recordUndo};
            var ___result = RMApplyPropertyOverride_Serialized_Material_MaterialSerializedProperty_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RevertPropertyOverride_Serialized(Hvak.Editor.Refleaction.RUnityEngine.RMaterialSerializedProperty @property)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property.Value};
            var ___result = RMRevertPropertyOverride_Serialized_MaterialSerializedProperty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetPropertyState_Serialized(Hvak.Editor.Refleaction.RUnityEngine.RMaterialSerializedProperty @property, out System.Boolean @isOverriden, out System.Boolean @isLockedInChildren, out System.Boolean @isLockedByAncestor)
        {
			@isOverriden = default;
			@isLockedInChildren = default;
			@isLockedByAncestor = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property.Value, @isOverriden, @isLockedInChildren, @isLockedByAncestor};
            var ___result = RMGetPropertyState_Serialized_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean.Invoke(___genericsType, ___parameters);
			@isOverriden = ReflectionUtils.Convert<System.Boolean>(___parameters[1]);
			@isLockedInChildren = ReflectionUtils.Convert<System.Boolean>(___parameters[2]);
			@isLockedByAncestor = ReflectionUtils.Convert<System.Boolean>(___parameters[3]);

            
        }


        public virtual void SetPropertyLock(Hvak.Editor.Refleaction.RUnityEngine.RMaterialSerializedProperty @property, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property.Value, @value};
            var ___result = RMSetPropertyLock_MaterialSerializedProperty_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyOverride(UnityEngine.Material @destination, Hvak.Editor.Refleaction.RUnityEngine.RMaterialSerializedProperty @property, System.Boolean @recordUndo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination, @property.Value, @recordUndo};
            var ___result = RMApplyPropertyOverride_Material_MaterialSerializedProperty_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RevertPropertyOverride(Hvak.Editor.Refleaction.RUnityEngine.RMaterialSerializedProperty @property)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property.Value};
            var ___result = RMRevertPropertyOverride_MaterialSerializedProperty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetPropertyState(Hvak.Editor.Refleaction.RUnityEngine.RMaterialSerializedProperty @propertyName, out System.Boolean @isOverriden, out System.Boolean @isLockedInChildren, out System.Boolean @isLockedByAncestor)
        {
			@isOverriden = default;
			@isLockedInChildren = default;
			@isLockedByAncestor = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName.Value, @isOverriden, @isLockedInChildren, @isLockedByAncestor};
            var ___result = RMGetPropertyState_MaterialSerializedProperty_Out_Boolean_Out_Boolean_Out_Boolean.Invoke(___genericsType, ___parameters);
			@isOverriden = ReflectionUtils.Convert<System.Boolean>(___parameters[1]);
			@isLockedInChildren = ReflectionUtils.Convert<System.Boolean>(___parameters[2]);
			@isLockedByAncestor = ReflectionUtils.Convert<System.Boolean>(___parameters[3]);

            
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


        public virtual void SetColorArray(System.Int32 @name, UnityEngine.Color[] @values, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values, @count};
            var ___result = RMSetColorArray_Int32_ColorArray_Int32.Invoke(___genericsType, ___parameters);

            
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


        public virtual void ExtractColorArray(System.Int32 @name, System.Collections.Generic.List<UnityEngine.Color> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMExtractColorArray_Int32_List_d_Color_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExtractMatrixArray(System.Int32 @name, System.Collections.Generic.List<UnityEngine.Matrix4x4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMExtractMatrixArray_Int32_List_d_Matrix4x4_p_.Invoke(___genericsType, ___parameters);

            
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


        public virtual void SetColorArray(System.String @name, System.Collections.Generic.List<UnityEngine.Color> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMSetColorArray_String_List_d_Color_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColorArray(System.Int32 @nameID, System.Collections.Generic.List<UnityEngine.Color> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetColorArray_Int32_List_d_Color_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColorArray(System.String @name, UnityEngine.Color[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMSetColorArray_String_ColorArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColorArray(System.Int32 @nameID, UnityEngine.Color[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetColorArray_Int32_ColorArray.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Int32 GetInt(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetInt_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetInt(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMGetInt_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Single GetFloat(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetFloat_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public virtual System.Single GetFloat(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMGetFloat_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public virtual System.Int32 GetInteger(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetInteger_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetInteger(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMGetInteger_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual UnityEngine.Color GetColor(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetColor_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Color>(___result);
        }


        public virtual UnityEngine.Color GetColor(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMGetColor_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Color>(___result);
        }


        public virtual UnityEngine.Vector4 GetVector(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetVector_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector4>(___result);
        }


        public virtual UnityEngine.Vector4 GetVector(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMGetVector_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector4>(___result);
        }


        public virtual UnityEngine.Matrix4x4 GetMatrix(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetMatrix_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Matrix4x4>(___result);
        }


        public virtual UnityEngine.Matrix4x4 GetMatrix(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMGetMatrix_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Matrix4x4>(___result);
        }


        public virtual UnityEngine.Texture GetTexture(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetTexture_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Texture>(___result);
        }


        public virtual UnityEngine.Texture GetTexture(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMGetTexture_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Texture>(___result);
        }


        public virtual UnityEngine.GraphicsBufferHandle GetBuffer(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetBuffer_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.GraphicsBufferHandle>(___result);
        }


        public virtual UnityEngine.GraphicsBufferHandle GetConstantBuffer(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetConstantBuffer_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.GraphicsBufferHandle>(___result);
        }


        public virtual System.Single[] GetFloatArray(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetFloatArray_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single[]>(___result);
        }


        public virtual System.Single[] GetFloatArray(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMGetFloatArray_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single[]>(___result);
        }


        public virtual UnityEngine.Color[] GetColorArray(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetColorArray_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Color[]>(___result);
        }


        public virtual UnityEngine.Color[] GetColorArray(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMGetColorArray_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Color[]>(___result);
        }


        public virtual UnityEngine.Vector4[] GetVectorArray(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetVectorArray_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector4[]>(___result);
        }


        public virtual UnityEngine.Vector4[] GetVectorArray(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMGetVectorArray_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector4[]>(___result);
        }


        public virtual UnityEngine.Matrix4x4[] GetMatrixArray(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetMatrixArray_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Matrix4x4[]>(___result);
        }


        public virtual UnityEngine.Matrix4x4[] GetMatrixArray(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMGetMatrixArray_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Matrix4x4[]>(___result);
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


        public virtual void GetColorArray(System.String @name, System.Collections.Generic.List<UnityEngine.Color> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMGetColorArray_String_List_d_Color_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetColorArray(System.Int32 @nameID, System.Collections.Generic.List<UnityEngine.Color> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMGetColorArray_Int32_List_d_Color_p_.Invoke(___genericsType, ___parameters);

            
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


        public virtual void SetTextureOffset(System.String @name, UnityEngine.Vector2 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetTextureOffset_String_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTextureOffset(System.Int32 @nameID, UnityEngine.Vector2 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetTextureOffset_Int32_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTextureScale(System.String @name, UnityEngine.Vector2 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetTextureScale_String_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTextureScale(System.Int32 @nameID, UnityEngine.Vector2 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetTextureScale_Int32_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector2 GetTextureOffset(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetTextureOffset_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector2>(___result);
        }


        public virtual UnityEngine.Vector2 GetTextureOffset(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMGetTextureOffset_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector2>(___result);
        }


        public virtual UnityEngine.Vector2 GetTextureScale(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetTextureScale_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector2>(___result);
        }


        public virtual UnityEngine.Vector2 GetTextureScale(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMGetTextureScale_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector2>(___result);
        }


        public virtual System.String[] GetPropertyNames(UnityEngine.MaterialPropertyType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMGetPropertyNames_MaterialPropertyType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String[]>(___result);
        }


        public virtual void EnableLocalKeyword_Injected(ref UnityEngine.Rendering.LocalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMEnableLocalKeyword_Injected_Ref_LocalKeyword.Invoke(___genericsType, ___parameters);
			@keyword = ReflectionUtils.Convert<UnityEngine.Rendering.LocalKeyword>(___parameters[0]);

            
        }


        public virtual void DisableLocalKeyword_Injected(ref UnityEngine.Rendering.LocalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMDisableLocalKeyword_Injected_Ref_LocalKeyword.Invoke(___genericsType, ___parameters);
			@keyword = ReflectionUtils.Convert<UnityEngine.Rendering.LocalKeyword>(___parameters[0]);

            
        }


        public virtual void SetLocalKeyword_Injected(ref UnityEngine.Rendering.LocalKeyword @keyword, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword, @value};
            var ___result = RMSetLocalKeyword_Injected_Ref_LocalKeyword_Boolean.Invoke(___genericsType, ___parameters);
			@keyword = ReflectionUtils.Convert<UnityEngine.Rendering.LocalKeyword>(___parameters[0]);

            
        }


        public virtual System.Boolean IsLocalKeywordEnabled_Injected(ref UnityEngine.Rendering.LocalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMIsLocalKeywordEnabled_Injected_Ref_LocalKeyword.Invoke(___genericsType, ___parameters);
			@keyword = ReflectionUtils.Convert<UnityEngine.Rendering.LocalKeyword>(___parameters[0]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void SetColorImpl_Injected(System.Int32 @name, ref UnityEngine.Color @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetColorImpl_Injected_Int32_Ref_Color.Invoke(___genericsType, ___parameters);
			@value = ReflectionUtils.Convert<UnityEngine.Color>(___parameters[1]);

            
        }


        public virtual void SetMatrixImpl_Injected(System.Int32 @name, ref UnityEngine.Matrix4x4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetMatrixImpl_Injected_Int32_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			@value = ReflectionUtils.Convert<UnityEngine.Matrix4x4>(___parameters[1]);

            
        }


        public virtual void GetColorImpl_Injected(System.Int32 @name, out UnityEngine.Color @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @ret};
            var ___result = RMGetColorImpl_Injected_Int32_Out_Color.Invoke(___genericsType, ___parameters);
			@ret = ReflectionUtils.Convert<UnityEngine.Color>(___parameters[1]);

            
        }


        public virtual void GetMatrixImpl_Injected(System.Int32 @name, out UnityEngine.Matrix4x4 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @ret};
            var ___result = RMGetMatrixImpl_Injected_Int32_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			@ret = ReflectionUtils.Convert<UnityEngine.Matrix4x4>(___parameters[1]);

            
        }


        public virtual void GetBufferImpl_Injected(System.Int32 @name, out UnityEngine.GraphicsBufferHandle @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @ret};
            var ___result = RMGetBufferImpl_Injected_Int32_Out_GraphicsBufferHandle.Invoke(___genericsType, ___parameters);
			@ret = ReflectionUtils.Convert<UnityEngine.GraphicsBufferHandle>(___parameters[1]);

            
        }


        public virtual void GetConstantBufferImpl_Injected(System.Int32 @name, out UnityEngine.GraphicsBufferHandle @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @ret};
            var ___result = RMGetConstantBufferImpl_Injected_Int32_Out_GraphicsBufferHandle.Invoke(___genericsType, ___parameters);
			@ret = ReflectionUtils.Convert<UnityEngine.GraphicsBufferHandle>(___parameters[1]);

            
        }


        public virtual void GetTextureScaleAndOffsetImpl_Injected(System.Int32 @name, out UnityEngine.Vector4 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @ret};
            var ___result = RMGetTextureScaleAndOffsetImpl_Injected_Int32_Out_Vector4.Invoke(___genericsType, ___parameters);
			@ret = ReflectionUtils.Convert<UnityEngine.Vector4>(___parameters[1]);

            
        }


        public virtual void SetTextureOffsetImpl_Injected(System.Int32 @name, ref UnityEngine.Vector2 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @offset};
            var ___result = RMSetTextureOffsetImpl_Injected_Int32_Ref_Vector2.Invoke(___genericsType, ___parameters);
			@offset = ReflectionUtils.Convert<UnityEngine.Vector2>(___parameters[1]);

            
        }


        public virtual void SetTextureScaleImpl_Injected(System.Int32 @name, ref UnityEngine.Vector2 @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @scale};
            var ___result = RMSetTextureScaleImpl_Injected_Int32_Ref_Vector2.Invoke(___genericsType, ___parameters);
			@scale = ReflectionUtils.Convert<UnityEngine.Vector2>(___parameters[1]);

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetInstanceID.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
