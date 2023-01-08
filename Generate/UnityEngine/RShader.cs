using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Shader
	/// </summary>
    public partial class RShader : RMember //
    {

		/// <summary>
		/// UnityEngine.Rendering.ShaderHardwareTier globalShaderHardwareTier
		/// </summary>
		protected static RProperty r_globalShaderHardwareTier;
		public static RProperty RglobalShaderHardwareTier
		{
			get
			{
				if(r_globalShaderHardwareTier == null)
				{
					r_globalShaderHardwareTier = new(typeof(UnityEngine.Shader), "globalShaderHardwareTier", -1);
					r_globalShaderHardwareTier.SetBelong(null);
				}
				return r_globalShaderHardwareTier;
			}
		}

		/// <summary>
		/// Int32 maximumChunksOverride
		/// </summary>
		protected static RProperty r_maximumChunksOverride;
		public static RProperty RmaximumChunksOverride
		{
			get
			{
				if(r_maximumChunksOverride == null)
				{
					r_maximumChunksOverride = new(typeof(UnityEngine.Shader), "maximumChunksOverride", -1);
					r_maximumChunksOverride.SetBelong(null);
				}
				return r_maximumChunksOverride;
			}
		}

		/// <summary>
		/// Int32 maximumLOD
		/// </summary>
		protected RProperty r_maximumLOD;
		public virtual RProperty RmaximumLOD
		{
			get
			{
				if(r_maximumLOD == null)
				{
					r_maximumLOD = new(this, "maximumLOD", -1);
					r_maximumLOD.SetBelong(this.instance);
				}
				return r_maximumLOD;
			}
		}

		/// <summary>
		/// Int32 globalMaximumLOD
		/// </summary>
		protected static RProperty r_globalMaximumLOD;
		public static RProperty RglobalMaximumLOD
		{
			get
			{
				if(r_globalMaximumLOD == null)
				{
					r_globalMaximumLOD = new(typeof(UnityEngine.Shader), "globalMaximumLOD", -1);
					r_globalMaximumLOD.SetBelong(null);
				}
				return r_globalMaximumLOD;
			}
		}

		/// <summary>
		/// Boolean isSupported
		/// </summary>
		protected RProperty r_isSupported;
		public virtual RProperty RisSupported
		{
			get
			{
				if(r_isSupported == null)
				{
					r_isSupported = new(this, "isSupported", -1);
					r_isSupported.SetBelong(this.instance);
				}
				return r_isSupported;
			}
		}

		/// <summary>
		/// System.String globalRenderPipeline
		/// </summary>
		protected static RProperty r_globalRenderPipeline;
		public static RProperty RglobalRenderPipeline
		{
			get
			{
				if(r_globalRenderPipeline == null)
				{
					r_globalRenderPipeline = new(typeof(UnityEngine.Shader), "globalRenderPipeline", -1);
					r_globalRenderPipeline.SetBelong(null);
				}
				return r_globalRenderPipeline;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.GlobalKeyword[] enabledGlobalKeywords
		/// </summary>
		protected static RPropertyArray<RUnityEngine.RRendering.RGlobalKeyword> r_enabledGlobalKeywords;
		public static RPropertyArray<RUnityEngine.RRendering.RGlobalKeyword> RenabledGlobalKeywords
		{
			get
			{
				if(r_enabledGlobalKeywords == null)
				{
					r_enabledGlobalKeywords = new(typeof(UnityEngine.Shader), "enabledGlobalKeywords", -1);
					r_enabledGlobalKeywords.SetBelong(null);
				}
				return r_enabledGlobalKeywords;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.GlobalKeyword[] globalKeywords
		/// </summary>
		protected static RPropertyArray<RUnityEngine.RRendering.RGlobalKeyword> r_globalKeywords;
		public static RPropertyArray<RUnityEngine.RRendering.RGlobalKeyword> RglobalKeywords
		{
			get
			{
				if(r_globalKeywords == null)
				{
					r_globalKeywords = new(typeof(UnityEngine.Shader), "globalKeywords", -1);
					r_globalKeywords.SetBelong(null);
				}
				return r_globalKeywords;
			}
		}

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
		/// UnityEngine.DisableBatchingType disableBatching
		/// </summary>
		protected RProperty r_disableBatching;
		public virtual RProperty RdisableBatching
		{
			get
			{
				if(r_disableBatching == null)
				{
					r_disableBatching = new(this, "disableBatching", -1);
					r_disableBatching.SetBelong(this.instance);
				}
				return r_disableBatching;
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
		/// Int32 subshaderCount
		/// </summary>
		protected RProperty r_subshaderCount;
		public virtual RProperty RsubshaderCount
		{
			get
			{
				if(r_subshaderCount == null)
				{
					r_subshaderCount = new(this, "subshaderCount", -1);
					r_subshaderCount.SetBelong(this.instance);
				}
				return r_subshaderCount;
			}
		}

		/// <summary>
		/// System.String customEditor
		/// </summary>
		protected RProperty r_customEditor;
		public virtual RProperty RcustomEditor
		{
			get
			{
				if(r_customEditor == null)
				{
					r_customEditor = new(this, "customEditor", -1);
					r_customEditor.SetBelong(this.instance);
				}
				return r_customEditor;
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
		/// Void SetGlobalTexGenMode(System.String, UnityEngine.TexGenMode)
		/// </summary>
		protected static RMethod r_SetGlobalTexGenMode_String_TexGenMode;
		public static RMethod RSetGlobalTexGenMode_String_TexGenMode
		{
			get
			{
				if(r_SetGlobalTexGenMode_String_TexGenMode == null)
				{
					r_SetGlobalTexGenMode_String_TexGenMode = new(typeof(UnityEngine.Shader), "SetGlobalTexGenMode", 0, typeof(System.String), typeof(UnityEngine.TexGenMode));
					r_SetGlobalTexGenMode_String_TexGenMode.SetBelong(null);
				}
				return r_SetGlobalTexGenMode_String_TexGenMode;
			}
		}

		/// <summary>
		/// Void SetGlobalTextureMatrixName(System.String, System.String)
		/// </summary>
		protected static RMethod r_SetGlobalTextureMatrixName_String_String;
		public static RMethod RSetGlobalTextureMatrixName_String_String
		{
			get
			{
				if(r_SetGlobalTextureMatrixName_String_String == null)
				{
					r_SetGlobalTextureMatrixName_String_String = new(typeof(UnityEngine.Shader), "SetGlobalTextureMatrixName", 0, typeof(System.String), typeof(System.String));
					r_SetGlobalTextureMatrixName_String_String.SetBelong(null);
				}
				return r_SetGlobalTextureMatrixName_String_String;
			}
		}

		/// <summary>
		/// UnityEngine.Shader Find(System.String)
		/// </summary>
		protected static RMethod r_Find_String;
		public static RMethod RFind_String
		{
			get
			{
				if(r_Find_String == null)
				{
					r_Find_String = new(typeof(UnityEngine.Shader), "Find", 0, typeof(System.String));
					r_Find_String.SetBelong(null);
				}
				return r_Find_String;
			}
		}

		/// <summary>
		/// UnityEngine.Shader FindBuiltin(System.String)
		/// </summary>
		protected static RMethod r_FindBuiltin_String;
		public static RMethod RFindBuiltin_String
		{
			get
			{
				if(r_FindBuiltin_String == null)
				{
					r_FindBuiltin_String = new(typeof(UnityEngine.Shader), "FindBuiltin", 0, typeof(System.String));
					r_FindBuiltin_String.SetBelong(null);
				}
				return r_FindBuiltin_String;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.GlobalKeyword[] GetEnabledGlobalKeywords()
		/// </summary>
		protected static RMethod r_GetEnabledGlobalKeywords;
		public static RMethod RGetEnabledGlobalKeywords
		{
			get
			{
				if(r_GetEnabledGlobalKeywords == null)
				{
					r_GetEnabledGlobalKeywords = new(typeof(UnityEngine.Shader), "GetEnabledGlobalKeywords", 0);
					r_GetEnabledGlobalKeywords.SetBelong(null);
				}
				return r_GetEnabledGlobalKeywords;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.GlobalKeyword[] GetAllGlobalKeywords()
		/// </summary>
		protected static RMethod r_GetAllGlobalKeywords;
		public static RMethod RGetAllGlobalKeywords
		{
			get
			{
				if(r_GetAllGlobalKeywords == null)
				{
					r_GetAllGlobalKeywords = new(typeof(UnityEngine.Shader), "GetAllGlobalKeywords", 0);
					r_GetAllGlobalKeywords.SetBelong(null);
				}
				return r_GetAllGlobalKeywords;
			}
		}

		/// <summary>
		/// Void EnableKeyword(System.String)
		/// </summary>
		protected static RMethod r_EnableKeyword_String;
		public static RMethod REnableKeyword_String
		{
			get
			{
				if(r_EnableKeyword_String == null)
				{
					r_EnableKeyword_String = new(typeof(UnityEngine.Shader), "EnableKeyword", 0, typeof(System.String));
					r_EnableKeyword_String.SetBelong(null);
				}
				return r_EnableKeyword_String;
			}
		}

		/// <summary>
		/// Void DisableKeyword(System.String)
		/// </summary>
		protected static RMethod r_DisableKeyword_String;
		public static RMethod RDisableKeyword_String
		{
			get
			{
				if(r_DisableKeyword_String == null)
				{
					r_DisableKeyword_String = new(typeof(UnityEngine.Shader), "DisableKeyword", 0, typeof(System.String));
					r_DisableKeyword_String.SetBelong(null);
				}
				return r_DisableKeyword_String;
			}
		}

		/// <summary>
		/// Boolean IsKeywordEnabled(System.String)
		/// </summary>
		protected static RMethod r_IsKeywordEnabled_String;
		public static RMethod RIsKeywordEnabled_String
		{
			get
			{
				if(r_IsKeywordEnabled_String == null)
				{
					r_IsKeywordEnabled_String = new(typeof(UnityEngine.Shader), "IsKeywordEnabled", 0, typeof(System.String));
					r_IsKeywordEnabled_String.SetBelong(null);
				}
				return r_IsKeywordEnabled_String;
			}
		}

		/// <summary>
		/// Void EnableKeywordFast(UnityEngine.Rendering.GlobalKeyword)
		/// </summary>
		protected static RMethod r_EnableKeywordFast_GlobalKeyword;
		public static RMethod REnableKeywordFast_GlobalKeyword
		{
			get
			{
				if(r_EnableKeywordFast_GlobalKeyword == null)
				{
					r_EnableKeywordFast_GlobalKeyword = new(typeof(UnityEngine.Shader), "EnableKeywordFast", 0, typeof(UnityEngine.Rendering.GlobalKeyword));
					r_EnableKeywordFast_GlobalKeyword.SetBelong(null);
				}
				return r_EnableKeywordFast_GlobalKeyword;
			}
		}

		/// <summary>
		/// Void DisableKeywordFast(UnityEngine.Rendering.GlobalKeyword)
		/// </summary>
		protected static RMethod r_DisableKeywordFast_GlobalKeyword;
		public static RMethod RDisableKeywordFast_GlobalKeyword
		{
			get
			{
				if(r_DisableKeywordFast_GlobalKeyword == null)
				{
					r_DisableKeywordFast_GlobalKeyword = new(typeof(UnityEngine.Shader), "DisableKeywordFast", 0, typeof(UnityEngine.Rendering.GlobalKeyword));
					r_DisableKeywordFast_GlobalKeyword.SetBelong(null);
				}
				return r_DisableKeywordFast_GlobalKeyword;
			}
		}

		/// <summary>
		/// Void SetKeywordFast(UnityEngine.Rendering.GlobalKeyword, Boolean)
		/// </summary>
		protected static RMethod r_SetKeywordFast_GlobalKeyword_Boolean;
		public static RMethod RSetKeywordFast_GlobalKeyword_Boolean
		{
			get
			{
				if(r_SetKeywordFast_GlobalKeyword_Boolean == null)
				{
					r_SetKeywordFast_GlobalKeyword_Boolean = new(typeof(UnityEngine.Shader), "SetKeywordFast", 0, typeof(UnityEngine.Rendering.GlobalKeyword), typeof(System.Boolean));
					r_SetKeywordFast_GlobalKeyword_Boolean.SetBelong(null);
				}
				return r_SetKeywordFast_GlobalKeyword_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsKeywordEnabledFast(UnityEngine.Rendering.GlobalKeyword)
		/// </summary>
		protected static RMethod r_IsKeywordEnabledFast_GlobalKeyword;
		public static RMethod RIsKeywordEnabledFast_GlobalKeyword
		{
			get
			{
				if(r_IsKeywordEnabledFast_GlobalKeyword == null)
				{
					r_IsKeywordEnabledFast_GlobalKeyword = new(typeof(UnityEngine.Shader), "IsKeywordEnabledFast", 0, typeof(UnityEngine.Rendering.GlobalKeyword));
					r_IsKeywordEnabledFast_GlobalKeyword.SetBelong(null);
				}
				return r_IsKeywordEnabledFast_GlobalKeyword;
			}
		}

		/// <summary>
		/// Void EnableKeyword(UnityEngine.Rendering.GlobalKeyword ByRef)
		/// </summary>
		protected static RMethod r_EnableKeyword_In_GlobalKeyword;
		public static RMethod REnableKeyword_In_GlobalKeyword
		{
			get
			{
				if(r_EnableKeyword_In_GlobalKeyword == null)
				{
					r_EnableKeyword_In_GlobalKeyword = new(typeof(UnityEngine.Shader), "EnableKeyword", 0, typeof(UnityEngine.Rendering.GlobalKeyword).MakeByRefType());
					r_EnableKeyword_In_GlobalKeyword.SetBelong(null);
				}
				return r_EnableKeyword_In_GlobalKeyword;
			}
		}

		/// <summary>
		/// Void DisableKeyword(UnityEngine.Rendering.GlobalKeyword ByRef)
		/// </summary>
		protected static RMethod r_DisableKeyword_In_GlobalKeyword;
		public static RMethod RDisableKeyword_In_GlobalKeyword
		{
			get
			{
				if(r_DisableKeyword_In_GlobalKeyword == null)
				{
					r_DisableKeyword_In_GlobalKeyword = new(typeof(UnityEngine.Shader), "DisableKeyword", 0, typeof(UnityEngine.Rendering.GlobalKeyword).MakeByRefType());
					r_DisableKeyword_In_GlobalKeyword.SetBelong(null);
				}
				return r_DisableKeyword_In_GlobalKeyword;
			}
		}

		/// <summary>
		/// Void SetKeyword(UnityEngine.Rendering.GlobalKeyword ByRef, Boolean)
		/// </summary>
		protected static RMethod r_SetKeyword_In_GlobalKeyword_Boolean;
		public static RMethod RSetKeyword_In_GlobalKeyword_Boolean
		{
			get
			{
				if(r_SetKeyword_In_GlobalKeyword_Boolean == null)
				{
					r_SetKeyword_In_GlobalKeyword_Boolean = new(typeof(UnityEngine.Shader), "SetKeyword", 0, typeof(UnityEngine.Rendering.GlobalKeyword).MakeByRefType(), typeof(System.Boolean));
					r_SetKeyword_In_GlobalKeyword_Boolean.SetBelong(null);
				}
				return r_SetKeyword_In_GlobalKeyword_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsKeywordEnabled(UnityEngine.Rendering.GlobalKeyword ByRef)
		/// </summary>
		protected static RMethod r_IsKeywordEnabled_In_GlobalKeyword;
		public static RMethod RIsKeywordEnabled_In_GlobalKeyword
		{
			get
			{
				if(r_IsKeywordEnabled_In_GlobalKeyword == null)
				{
					r_IsKeywordEnabled_In_GlobalKeyword = new(typeof(UnityEngine.Shader), "IsKeywordEnabled", 0, typeof(UnityEngine.Rendering.GlobalKeyword).MakeByRefType());
					r_IsKeywordEnabled_In_GlobalKeyword.SetBelong(null);
				}
				return r_IsKeywordEnabled_In_GlobalKeyword;
			}
		}

		/// <summary>
		/// Void WarmupAllShaders()
		/// </summary>
		protected static RMethod r_WarmupAllShaders;
		public static RMethod RWarmupAllShaders
		{
			get
			{
				if(r_WarmupAllShaders == null)
				{
					r_WarmupAllShaders = new(typeof(UnityEngine.Shader), "WarmupAllShaders", 0);
					r_WarmupAllShaders.SetBelong(null);
				}
				return r_WarmupAllShaders;
			}
		}

		/// <summary>
		/// Int32 TagToID(System.String)
		/// </summary>
		protected static RMethod r_TagToID_String;
		public static RMethod RTagToID_String
		{
			get
			{
				if(r_TagToID_String == null)
				{
					r_TagToID_String = new(typeof(UnityEngine.Shader), "TagToID", 0, typeof(System.String));
					r_TagToID_String.SetBelong(null);
				}
				return r_TagToID_String;
			}
		}

		/// <summary>
		/// System.String IDToTag(Int32)
		/// </summary>
		protected static RMethod r_IDToTag_Int32;
		public static RMethod RIDToTag_Int32
		{
			get
			{
				if(r_IDToTag_Int32 == null)
				{
					r_IDToTag_Int32 = new(typeof(UnityEngine.Shader), "IDToTag", 0, typeof(System.Int32));
					r_IDToTag_Int32.SetBelong(null);
				}
				return r_IDToTag_Int32;
			}
		}

		/// <summary>
		/// Int32 PropertyToID(System.String)
		/// </summary>
		protected static RMethod r_PropertyToID_String;
		public static RMethod RPropertyToID_String
		{
			get
			{
				if(r_PropertyToID_String == null)
				{
					r_PropertyToID_String = new(typeof(UnityEngine.Shader), "PropertyToID", 0, typeof(System.String));
					r_PropertyToID_String.SetBelong(null);
				}
				return r_PropertyToID_String;
			}
		}

		/// <summary>
		/// UnityEngine.Shader GetDependency(System.String)
		/// </summary>
		protected RMethod r_GetDependency_String;
		public virtual RMethod RGetDependency_String
		{
			get
			{
				if(r_GetDependency_String == null)
				{
					r_GetDependency_String = new(this, "GetDependency", 0, typeof(System.String));
					r_GetDependency_String.SetBelong(this.instance);
				}
				return r_GetDependency_String;
			}
		}

		/// <summary>
		/// Int32 GetPassCountInSubshader(Int32)
		/// </summary>
		protected RMethod r_GetPassCountInSubshader_Int32;
		public virtual RMethod RGetPassCountInSubshader_Int32
		{
			get
			{
				if(r_GetPassCountInSubshader_Int32 == null)
				{
					r_GetPassCountInSubshader_Int32 = new(this, "GetPassCountInSubshader", 0, typeof(System.Int32));
					r_GetPassCountInSubshader_Int32.SetBelong(this.instance);
				}
				return r_GetPassCountInSubshader_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ShaderTagId FindPassTagValue(Int32, UnityEngine.Rendering.ShaderTagId)
		/// </summary>
		protected RMethod r_FindPassTagValue_Int32_ShaderTagId;
		public virtual RMethod RFindPassTagValue_Int32_ShaderTagId
		{
			get
			{
				if(r_FindPassTagValue_Int32_ShaderTagId == null)
				{
					r_FindPassTagValue_Int32_ShaderTagId = new(this, "FindPassTagValue", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.ShaderTagId));
					r_FindPassTagValue_Int32_ShaderTagId.SetBelong(this.instance);
				}
				return r_FindPassTagValue_Int32_ShaderTagId;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ShaderTagId FindPassTagValue(Int32, Int32, UnityEngine.Rendering.ShaderTagId)
		/// </summary>
		protected RMethod r_FindPassTagValue_Int32_Int32_ShaderTagId;
		public virtual RMethod RFindPassTagValue_Int32_Int32_ShaderTagId
		{
			get
			{
				if(r_FindPassTagValue_Int32_Int32_ShaderTagId == null)
				{
					r_FindPassTagValue_Int32_Int32_ShaderTagId = new(this, "FindPassTagValue", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.ShaderTagId));
					r_FindPassTagValue_Int32_Int32_ShaderTagId.SetBelong(this.instance);
				}
				return r_FindPassTagValue_Int32_Int32_ShaderTagId;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ShaderTagId FindSubshaderTagValue(Int32, UnityEngine.Rendering.ShaderTagId)
		/// </summary>
		protected RMethod r_FindSubshaderTagValue_Int32_ShaderTagId;
		public virtual RMethod RFindSubshaderTagValue_Int32_ShaderTagId
		{
			get
			{
				if(r_FindSubshaderTagValue_Int32_ShaderTagId == null)
				{
					r_FindSubshaderTagValue_Int32_ShaderTagId = new(this, "FindSubshaderTagValue", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.ShaderTagId));
					r_FindSubshaderTagValue_Int32_ShaderTagId.SetBelong(this.instance);
				}
				return r_FindSubshaderTagValue_Int32_ShaderTagId;
			}
		}

		/// <summary>
		/// Int32 Internal_FindPassTagValue(Int32, Int32)
		/// </summary>
		protected RMethod r_Internal_FindPassTagValue_Int32_Int32;
		public virtual RMethod RInternal_FindPassTagValue_Int32_Int32
		{
			get
			{
				if(r_Internal_FindPassTagValue_Int32_Int32 == null)
				{
					r_Internal_FindPassTagValue_Int32_Int32 = new(this, "Internal_FindPassTagValue", 0, typeof(System.Int32), typeof(System.Int32));
					r_Internal_FindPassTagValue_Int32_Int32.SetBelong(this.instance);
				}
				return r_Internal_FindPassTagValue_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 Internal_FindPassTagValueInSubShader(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_Internal_FindPassTagValueInSubShader_Int32_Int32_Int32;
		public virtual RMethod RInternal_FindPassTagValueInSubShader_Int32_Int32_Int32
		{
			get
			{
				if(r_Internal_FindPassTagValueInSubShader_Int32_Int32_Int32 == null)
				{
					r_Internal_FindPassTagValueInSubShader_Int32_Int32_Int32 = new(this, "Internal_FindPassTagValueInSubShader", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_Internal_FindPassTagValueInSubShader_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_Internal_FindPassTagValueInSubShader_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 Internal_FindSubshaderTagValue(Int32, Int32)
		/// </summary>
		protected RMethod r_Internal_FindSubshaderTagValue_Int32_Int32;
		public virtual RMethod RInternal_FindSubshaderTagValue_Int32_Int32
		{
			get
			{
				if(r_Internal_FindSubshaderTagValue_Int32_Int32 == null)
				{
					r_Internal_FindSubshaderTagValue_Int32_Int32 = new(this, "Internal_FindSubshaderTagValue", 0, typeof(System.Int32), typeof(System.Int32));
					r_Internal_FindSubshaderTagValue_Int32_Int32.SetBelong(this.instance);
				}
				return r_Internal_FindSubshaderTagValue_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Internal_GetCustomEditorForRenderPipeline(System.String, System.String ByRef)
		/// </summary>
		protected RMethod r_Internal_GetCustomEditorForRenderPipeline_String_Out_String;
		public virtual RMethod RInternal_GetCustomEditorForRenderPipeline_String_Out_String
		{
			get
			{
				if(r_Internal_GetCustomEditorForRenderPipeline_String_Out_String == null)
				{
					r_Internal_GetCustomEditorForRenderPipeline_String_Out_String = new(this, "Internal_GetCustomEditorForRenderPipeline", 0, typeof(System.String), typeof(System.String).MakeByRefType());
					r_Internal_GetCustomEditorForRenderPipeline_String_Out_String.SetBelong(this.instance);
				}
				return r_Internal_GetCustomEditorForRenderPipeline_String_Out_String;
			}
		}

		/// <summary>
		/// Void SetGlobalIntImpl(Int32, Int32)
		/// </summary>
		protected static RMethod r_SetGlobalIntImpl_Int32_Int32;
		public static RMethod RSetGlobalIntImpl_Int32_Int32
		{
			get
			{
				if(r_SetGlobalIntImpl_Int32_Int32 == null)
				{
					r_SetGlobalIntImpl_Int32_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalIntImpl", 0, typeof(System.Int32), typeof(System.Int32));
					r_SetGlobalIntImpl_Int32_Int32.SetBelong(null);
				}
				return r_SetGlobalIntImpl_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalFloatImpl(Int32, Single)
		/// </summary>
		protected static RMethod r_SetGlobalFloatImpl_Int32_Single;
		public static RMethod RSetGlobalFloatImpl_Int32_Single
		{
			get
			{
				if(r_SetGlobalFloatImpl_Int32_Single == null)
				{
					r_SetGlobalFloatImpl_Int32_Single = new(typeof(UnityEngine.Shader), "SetGlobalFloatImpl", 0, typeof(System.Int32), typeof(System.Single));
					r_SetGlobalFloatImpl_Int32_Single.SetBelong(null);
				}
				return r_SetGlobalFloatImpl_Int32_Single;
			}
		}

		/// <summary>
		/// Void SetGlobalVectorImpl(Int32, UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_SetGlobalVectorImpl_Int32_Vector4;
		public static RMethod RSetGlobalVectorImpl_Int32_Vector4
		{
			get
			{
				if(r_SetGlobalVectorImpl_Int32_Vector4 == null)
				{
					r_SetGlobalVectorImpl_Int32_Vector4 = new(typeof(UnityEngine.Shader), "SetGlobalVectorImpl", 0, typeof(System.Int32), typeof(UnityEngine.Vector4));
					r_SetGlobalVectorImpl_Int32_Vector4.SetBelong(null);
				}
				return r_SetGlobalVectorImpl_Int32_Vector4;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrixImpl(Int32, UnityEngine.Matrix4x4)
		/// </summary>
		protected static RMethod r_SetGlobalMatrixImpl_Int32_Matrix4x4;
		public static RMethod RSetGlobalMatrixImpl_Int32_Matrix4x4
		{
			get
			{
				if(r_SetGlobalMatrixImpl_Int32_Matrix4x4 == null)
				{
					r_SetGlobalMatrixImpl_Int32_Matrix4x4 = new(typeof(UnityEngine.Shader), "SetGlobalMatrixImpl", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4));
					r_SetGlobalMatrixImpl_Int32_Matrix4x4.SetBelong(null);
				}
				return r_SetGlobalMatrixImpl_Int32_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetGlobalTextureImpl(Int32, UnityEngine.Texture)
		/// </summary>
		protected static RMethod r_SetGlobalTextureImpl_Int32_Texture;
		public static RMethod RSetGlobalTextureImpl_Int32_Texture
		{
			get
			{
				if(r_SetGlobalTextureImpl_Int32_Texture == null)
				{
					r_SetGlobalTextureImpl_Int32_Texture = new(typeof(UnityEngine.Shader), "SetGlobalTextureImpl", 0, typeof(System.Int32), typeof(UnityEngine.Texture));
					r_SetGlobalTextureImpl_Int32_Texture.SetBelong(null);
				}
				return r_SetGlobalTextureImpl_Int32_Texture;
			}
		}

		/// <summary>
		/// Void SetGlobalRenderTextureImpl(Int32, UnityEngine.RenderTexture, UnityEngine.Rendering.RenderTextureSubElement)
		/// </summary>
		protected static RMethod r_SetGlobalRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement;
		public static RMethod RSetGlobalRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement
		{
			get
			{
				if(r_SetGlobalRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement == null)
				{
					r_SetGlobalRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement = new(typeof(UnityEngine.Shader), "SetGlobalRenderTextureImpl", 0, typeof(System.Int32), typeof(UnityEngine.RenderTexture), typeof(UnityEngine.Rendering.RenderTextureSubElement));
					r_SetGlobalRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement.SetBelong(null);
				}
				return r_SetGlobalRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement;
			}
		}

		/// <summary>
		/// Void SetGlobalBufferImpl(Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected static RMethod r_SetGlobalBufferImpl_Int32_ComputeBuffer;
		public static RMethod RSetGlobalBufferImpl_Int32_ComputeBuffer
		{
			get
			{
				if(r_SetGlobalBufferImpl_Int32_ComputeBuffer == null)
				{
					r_SetGlobalBufferImpl_Int32_ComputeBuffer = new(typeof(UnityEngine.Shader), "SetGlobalBufferImpl", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
					r_SetGlobalBufferImpl_Int32_ComputeBuffer.SetBelong(null);
				}
				return r_SetGlobalBufferImpl_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetGlobalGraphicsBufferImpl(Int32, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected static RMethod r_SetGlobalGraphicsBufferImpl_Int32_GraphicsBuffer;
		public static RMethod RSetGlobalGraphicsBufferImpl_Int32_GraphicsBuffer
		{
			get
			{
				if(r_SetGlobalGraphicsBufferImpl_Int32_GraphicsBuffer == null)
				{
					r_SetGlobalGraphicsBufferImpl_Int32_GraphicsBuffer = new(typeof(UnityEngine.Shader), "SetGlobalGraphicsBufferImpl", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer));
					r_SetGlobalGraphicsBufferImpl_Int32_GraphicsBuffer.SetBelong(null);
				}
				return r_SetGlobalGraphicsBufferImpl_Int32_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetGlobalConstantBufferImpl(Int32, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected static RMethod r_SetGlobalConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32;
		public static RMethod RSetGlobalConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_SetGlobalConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32 == null)
				{
					r_SetGlobalConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalConstantBufferImpl", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
					r_SetGlobalConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32.SetBelong(null);
				}
				return r_SetGlobalConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalConstantGraphicsBufferImpl(Int32, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected static RMethod r_SetGlobalConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32;
		public static RMethod RSetGlobalConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_SetGlobalConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32 == null)
				{
					r_SetGlobalConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalConstantGraphicsBufferImpl", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
					r_SetGlobalConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32.SetBelong(null);
				}
				return r_SetGlobalConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetGlobalIntImpl(Int32)
		/// </summary>
		protected static RMethod r_GetGlobalIntImpl_Int32;
		public static RMethod RGetGlobalIntImpl_Int32
		{
			get
			{
				if(r_GetGlobalIntImpl_Int32 == null)
				{
					r_GetGlobalIntImpl_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalIntImpl", 0, typeof(System.Int32));
					r_GetGlobalIntImpl_Int32.SetBelong(null);
				}
				return r_GetGlobalIntImpl_Int32;
			}
		}

		/// <summary>
		/// Single GetGlobalFloatImpl(Int32)
		/// </summary>
		protected static RMethod r_GetGlobalFloatImpl_Int32;
		public static RMethod RGetGlobalFloatImpl_Int32
		{
			get
			{
				if(r_GetGlobalFloatImpl_Int32 == null)
				{
					r_GetGlobalFloatImpl_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalFloatImpl", 0, typeof(System.Int32));
					r_GetGlobalFloatImpl_Int32.SetBelong(null);
				}
				return r_GetGlobalFloatImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 GetGlobalVectorImpl(Int32)
		/// </summary>
		protected static RMethod r_GetGlobalVectorImpl_Int32;
		public static RMethod RGetGlobalVectorImpl_Int32
		{
			get
			{
				if(r_GetGlobalVectorImpl_Int32 == null)
				{
					r_GetGlobalVectorImpl_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalVectorImpl", 0, typeof(System.Int32));
					r_GetGlobalVectorImpl_Int32.SetBelong(null);
				}
				return r_GetGlobalVectorImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 GetGlobalMatrixImpl(Int32)
		/// </summary>
		protected static RMethod r_GetGlobalMatrixImpl_Int32;
		public static RMethod RGetGlobalMatrixImpl_Int32
		{
			get
			{
				if(r_GetGlobalMatrixImpl_Int32 == null)
				{
					r_GetGlobalMatrixImpl_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalMatrixImpl", 0, typeof(System.Int32));
					r_GetGlobalMatrixImpl_Int32.SetBelong(null);
				}
				return r_GetGlobalMatrixImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Texture GetGlobalTextureImpl(Int32)
		/// </summary>
		protected static RMethod r_GetGlobalTextureImpl_Int32;
		public static RMethod RGetGlobalTextureImpl_Int32
		{
			get
			{
				if(r_GetGlobalTextureImpl_Int32 == null)
				{
					r_GetGlobalTextureImpl_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalTextureImpl", 0, typeof(System.Int32));
					r_GetGlobalTextureImpl_Int32.SetBelong(null);
				}
				return r_GetGlobalTextureImpl_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalFloatArrayImpl(Int32, Single[], Int32)
		/// </summary>
		protected static RMethod r_SetGlobalFloatArrayImpl_Int32_SingleArray_Int32;
		public static RMethod RSetGlobalFloatArrayImpl_Int32_SingleArray_Int32
		{
			get
			{
				if(r_SetGlobalFloatArrayImpl_Int32_SingleArray_Int32 == null)
				{
					r_SetGlobalFloatArrayImpl_Int32_SingleArray_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalFloatArrayImpl", 0, typeof(System.Int32), typeof(System.Single).MakeArrayType(), typeof(System.Int32));
					r_SetGlobalFloatArrayImpl_Int32_SingleArray_Int32.SetBelong(null);
				}
				return r_SetGlobalFloatArrayImpl_Int32_SingleArray_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalVectorArrayImpl(Int32, UnityEngine.Vector4[], Int32)
		/// </summary>
		protected static RMethod r_SetGlobalVectorArrayImpl_Int32_Vector4Array_Int32;
		public static RMethod RSetGlobalVectorArrayImpl_Int32_Vector4Array_Int32
		{
			get
			{
				if(r_SetGlobalVectorArrayImpl_Int32_Vector4Array_Int32 == null)
				{
					r_SetGlobalVectorArrayImpl_Int32_Vector4Array_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalVectorArrayImpl", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType(), typeof(System.Int32));
					r_SetGlobalVectorArrayImpl_Int32_Vector4Array_Int32.SetBelong(null);
				}
				return r_SetGlobalVectorArrayImpl_Int32_Vector4Array_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrixArrayImpl(Int32, UnityEngine.Matrix4x4[], Int32)
		/// </summary>
		protected static RMethod r_SetGlobalMatrixArrayImpl_Int32_Matrix4x4Array_Int32;
		public static RMethod RSetGlobalMatrixArrayImpl_Int32_Matrix4x4Array_Int32
		{
			get
			{
				if(r_SetGlobalMatrixArrayImpl_Int32_Matrix4x4Array_Int32 == null)
				{
					r_SetGlobalMatrixArrayImpl_Int32_Matrix4x4Array_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalMatrixArrayImpl", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType(), typeof(System.Int32));
					r_SetGlobalMatrixArrayImpl_Int32_Matrix4x4Array_Int32.SetBelong(null);
				}
				return r_SetGlobalMatrixArrayImpl_Int32_Matrix4x4Array_Int32;
			}
		}

		/// <summary>
		/// Single[] GetGlobalFloatArrayImpl(Int32)
		/// </summary>
		protected static RMethod r_GetGlobalFloatArrayImpl_Int32;
		public static RMethod RGetGlobalFloatArrayImpl_Int32
		{
			get
			{
				if(r_GetGlobalFloatArrayImpl_Int32 == null)
				{
					r_GetGlobalFloatArrayImpl_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalFloatArrayImpl", 0, typeof(System.Int32));
					r_GetGlobalFloatArrayImpl_Int32.SetBelong(null);
				}
				return r_GetGlobalFloatArrayImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4[] GetGlobalVectorArrayImpl(Int32)
		/// </summary>
		protected static RMethod r_GetGlobalVectorArrayImpl_Int32;
		public static RMethod RGetGlobalVectorArrayImpl_Int32
		{
			get
			{
				if(r_GetGlobalVectorArrayImpl_Int32 == null)
				{
					r_GetGlobalVectorArrayImpl_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalVectorArrayImpl", 0, typeof(System.Int32));
					r_GetGlobalVectorArrayImpl_Int32.SetBelong(null);
				}
				return r_GetGlobalVectorArrayImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4[] GetGlobalMatrixArrayImpl(Int32)
		/// </summary>
		protected static RMethod r_GetGlobalMatrixArrayImpl_Int32;
		public static RMethod RGetGlobalMatrixArrayImpl_Int32
		{
			get
			{
				if(r_GetGlobalMatrixArrayImpl_Int32 == null)
				{
					r_GetGlobalMatrixArrayImpl_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalMatrixArrayImpl", 0, typeof(System.Int32));
					r_GetGlobalMatrixArrayImpl_Int32.SetBelong(null);
				}
				return r_GetGlobalMatrixArrayImpl_Int32;
			}
		}

		/// <summary>
		/// Int32 GetGlobalFloatArrayCountImpl(Int32)
		/// </summary>
		protected static RMethod r_GetGlobalFloatArrayCountImpl_Int32;
		public static RMethod RGetGlobalFloatArrayCountImpl_Int32
		{
			get
			{
				if(r_GetGlobalFloatArrayCountImpl_Int32 == null)
				{
					r_GetGlobalFloatArrayCountImpl_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalFloatArrayCountImpl", 0, typeof(System.Int32));
					r_GetGlobalFloatArrayCountImpl_Int32.SetBelong(null);
				}
				return r_GetGlobalFloatArrayCountImpl_Int32;
			}
		}

		/// <summary>
		/// Int32 GetGlobalVectorArrayCountImpl(Int32)
		/// </summary>
		protected static RMethod r_GetGlobalVectorArrayCountImpl_Int32;
		public static RMethod RGetGlobalVectorArrayCountImpl_Int32
		{
			get
			{
				if(r_GetGlobalVectorArrayCountImpl_Int32 == null)
				{
					r_GetGlobalVectorArrayCountImpl_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalVectorArrayCountImpl", 0, typeof(System.Int32));
					r_GetGlobalVectorArrayCountImpl_Int32.SetBelong(null);
				}
				return r_GetGlobalVectorArrayCountImpl_Int32;
			}
		}

		/// <summary>
		/// Int32 GetGlobalMatrixArrayCountImpl(Int32)
		/// </summary>
		protected static RMethod r_GetGlobalMatrixArrayCountImpl_Int32;
		public static RMethod RGetGlobalMatrixArrayCountImpl_Int32
		{
			get
			{
				if(r_GetGlobalMatrixArrayCountImpl_Int32 == null)
				{
					r_GetGlobalMatrixArrayCountImpl_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalMatrixArrayCountImpl", 0, typeof(System.Int32));
					r_GetGlobalMatrixArrayCountImpl_Int32.SetBelong(null);
				}
				return r_GetGlobalMatrixArrayCountImpl_Int32;
			}
		}

		/// <summary>
		/// Void ExtractGlobalFloatArrayImpl(Int32, Single[])
		/// </summary>
		protected static RMethod r_ExtractGlobalFloatArrayImpl_Int32_SingleArray;
		public static RMethod RExtractGlobalFloatArrayImpl_Int32_SingleArray
		{
			get
			{
				if(r_ExtractGlobalFloatArrayImpl_Int32_SingleArray == null)
				{
					r_ExtractGlobalFloatArrayImpl_Int32_SingleArray = new(typeof(UnityEngine.Shader), "ExtractGlobalFloatArrayImpl", 0, typeof(System.Int32), typeof(System.Single).MakeArrayType());
					r_ExtractGlobalFloatArrayImpl_Int32_SingleArray.SetBelong(null);
				}
				return r_ExtractGlobalFloatArrayImpl_Int32_SingleArray;
			}
		}

		/// <summary>
		/// Void ExtractGlobalVectorArrayImpl(Int32, UnityEngine.Vector4[])
		/// </summary>
		protected static RMethod r_ExtractGlobalVectorArrayImpl_Int32_Vector4Array;
		public static RMethod RExtractGlobalVectorArrayImpl_Int32_Vector4Array
		{
			get
			{
				if(r_ExtractGlobalVectorArrayImpl_Int32_Vector4Array == null)
				{
					r_ExtractGlobalVectorArrayImpl_Int32_Vector4Array = new(typeof(UnityEngine.Shader), "ExtractGlobalVectorArrayImpl", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType());
					r_ExtractGlobalVectorArrayImpl_Int32_Vector4Array.SetBelong(null);
				}
				return r_ExtractGlobalVectorArrayImpl_Int32_Vector4Array;
			}
		}

		/// <summary>
		/// Void ExtractGlobalMatrixArrayImpl(Int32, UnityEngine.Matrix4x4[])
		/// </summary>
		protected static RMethod r_ExtractGlobalMatrixArrayImpl_Int32_Matrix4x4Array;
		public static RMethod RExtractGlobalMatrixArrayImpl_Int32_Matrix4x4Array
		{
			get
			{
				if(r_ExtractGlobalMatrixArrayImpl_Int32_Matrix4x4Array == null)
				{
					r_ExtractGlobalMatrixArrayImpl_Int32_Matrix4x4Array = new(typeof(UnityEngine.Shader), "ExtractGlobalMatrixArrayImpl", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType());
					r_ExtractGlobalMatrixArrayImpl_Int32_Matrix4x4Array.SetBelong(null);
				}
				return r_ExtractGlobalMatrixArrayImpl_Int32_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Void SetGlobalFloatArray(Int32, Single[], Int32)
		/// </summary>
		protected static RMethod r_SetGlobalFloatArray_Int32_SingleArray_Int32;
		public static RMethod RSetGlobalFloatArray_Int32_SingleArray_Int32
		{
			get
			{
				if(r_SetGlobalFloatArray_Int32_SingleArray_Int32 == null)
				{
					r_SetGlobalFloatArray_Int32_SingleArray_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalFloatArray", 0, typeof(System.Int32), typeof(System.Single).MakeArrayType(), typeof(System.Int32));
					r_SetGlobalFloatArray_Int32_SingleArray_Int32.SetBelong(null);
				}
				return r_SetGlobalFloatArray_Int32_SingleArray_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalVectorArray(Int32, UnityEngine.Vector4[], Int32)
		/// </summary>
		protected static RMethod r_SetGlobalVectorArray_Int32_Vector4Array_Int32;
		public static RMethod RSetGlobalVectorArray_Int32_Vector4Array_Int32
		{
			get
			{
				if(r_SetGlobalVectorArray_Int32_Vector4Array_Int32 == null)
				{
					r_SetGlobalVectorArray_Int32_Vector4Array_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalVectorArray", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType(), typeof(System.Int32));
					r_SetGlobalVectorArray_Int32_Vector4Array_Int32.SetBelong(null);
				}
				return r_SetGlobalVectorArray_Int32_Vector4Array_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrixArray(Int32, UnityEngine.Matrix4x4[], Int32)
		/// </summary>
		protected static RMethod r_SetGlobalMatrixArray_Int32_Matrix4x4Array_Int32;
		public static RMethod RSetGlobalMatrixArray_Int32_Matrix4x4Array_Int32
		{
			get
			{
				if(r_SetGlobalMatrixArray_Int32_Matrix4x4Array_Int32 == null)
				{
					r_SetGlobalMatrixArray_Int32_Matrix4x4Array_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalMatrixArray", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType(), typeof(System.Int32));
					r_SetGlobalMatrixArray_Int32_Matrix4x4Array_Int32.SetBelong(null);
				}
				return r_SetGlobalMatrixArray_Int32_Matrix4x4Array_Int32;
			}
		}

		/// <summary>
		/// Void ExtractGlobalFloatArray(Int32, System.Collections.Generic.List`1[System.Single])
		/// </summary>
		protected static RMethod r_ExtractGlobalFloatArray_Int32_List_d_Single_p_;
		public static RMethod RExtractGlobalFloatArray_Int32_List_d_Single_p_
		{
			get
			{
				if(r_ExtractGlobalFloatArray_Int32_List_d_Single_p_ == null)
				{
					r_ExtractGlobalFloatArray_Int32_List_d_Single_p_ = new(typeof(UnityEngine.Shader), "ExtractGlobalFloatArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Single)));
					r_ExtractGlobalFloatArray_Int32_List_d_Single_p_.SetBelong(null);
				}
				return r_ExtractGlobalFloatArray_Int32_List_d_Single_p_;
			}
		}

		/// <summary>
		/// Void ExtractGlobalVectorArray(Int32, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected static RMethod r_ExtractGlobalVectorArray_Int32_List_d_Vector4_p_;
		public static RMethod RExtractGlobalVectorArray_Int32_List_d_Vector4_p_
		{
			get
			{
				if(r_ExtractGlobalVectorArray_Int32_List_d_Vector4_p_ == null)
				{
					r_ExtractGlobalVectorArray_Int32_List_d_Vector4_p_ = new(typeof(UnityEngine.Shader), "ExtractGlobalVectorArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_ExtractGlobalVectorArray_Int32_List_d_Vector4_p_.SetBelong(null);
				}
				return r_ExtractGlobalVectorArray_Int32_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void ExtractGlobalMatrixArray(Int32, System.Collections.Generic.List`1[UnityEngine.Matrix4x4])
		/// </summary>
		protected static RMethod r_ExtractGlobalMatrixArray_Int32_List_d_Matrix4x4_p_;
		public static RMethod RExtractGlobalMatrixArray_Int32_List_d_Matrix4x4_p_
		{
			get
			{
				if(r_ExtractGlobalMatrixArray_Int32_List_d_Matrix4x4_p_ == null)
				{
					r_ExtractGlobalMatrixArray_Int32_List_d_Matrix4x4_p_ = new(typeof(UnityEngine.Shader), "ExtractGlobalMatrixArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Matrix4x4)));
					r_ExtractGlobalMatrixArray_Int32_List_d_Matrix4x4_p_.SetBelong(null);
				}
				return r_ExtractGlobalMatrixArray_Int32_List_d_Matrix4x4_p_;
			}
		}

		/// <summary>
		/// Void SetGlobalInt(System.String, Int32)
		/// </summary>
		protected static RMethod r_SetGlobalInt_String_Int32;
		public static RMethod RSetGlobalInt_String_Int32
		{
			get
			{
				if(r_SetGlobalInt_String_Int32 == null)
				{
					r_SetGlobalInt_String_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalInt", 0, typeof(System.String), typeof(System.Int32));
					r_SetGlobalInt_String_Int32.SetBelong(null);
				}
				return r_SetGlobalInt_String_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalInt(Int32, Int32)
		/// </summary>
		protected static RMethod r_SetGlobalInt_Int32_Int32;
		public static RMethod RSetGlobalInt_Int32_Int32
		{
			get
			{
				if(r_SetGlobalInt_Int32_Int32 == null)
				{
					r_SetGlobalInt_Int32_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalInt", 0, typeof(System.Int32), typeof(System.Int32));
					r_SetGlobalInt_Int32_Int32.SetBelong(null);
				}
				return r_SetGlobalInt_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalFloat(System.String, Single)
		/// </summary>
		protected static RMethod r_SetGlobalFloat_String_Single;
		public static RMethod RSetGlobalFloat_String_Single
		{
			get
			{
				if(r_SetGlobalFloat_String_Single == null)
				{
					r_SetGlobalFloat_String_Single = new(typeof(UnityEngine.Shader), "SetGlobalFloat", 0, typeof(System.String), typeof(System.Single));
					r_SetGlobalFloat_String_Single.SetBelong(null);
				}
				return r_SetGlobalFloat_String_Single;
			}
		}

		/// <summary>
		/// Void SetGlobalFloat(Int32, Single)
		/// </summary>
		protected static RMethod r_SetGlobalFloat_Int32_Single;
		public static RMethod RSetGlobalFloat_Int32_Single
		{
			get
			{
				if(r_SetGlobalFloat_Int32_Single == null)
				{
					r_SetGlobalFloat_Int32_Single = new(typeof(UnityEngine.Shader), "SetGlobalFloat", 0, typeof(System.Int32), typeof(System.Single));
					r_SetGlobalFloat_Int32_Single.SetBelong(null);
				}
				return r_SetGlobalFloat_Int32_Single;
			}
		}

		/// <summary>
		/// Void SetGlobalInteger(System.String, Int32)
		/// </summary>
		protected static RMethod r_SetGlobalInteger_String_Int32;
		public static RMethod RSetGlobalInteger_String_Int32
		{
			get
			{
				if(r_SetGlobalInteger_String_Int32 == null)
				{
					r_SetGlobalInteger_String_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalInteger", 0, typeof(System.String), typeof(System.Int32));
					r_SetGlobalInteger_String_Int32.SetBelong(null);
				}
				return r_SetGlobalInteger_String_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalInteger(Int32, Int32)
		/// </summary>
		protected static RMethod r_SetGlobalInteger_Int32_Int32;
		public static RMethod RSetGlobalInteger_Int32_Int32
		{
			get
			{
				if(r_SetGlobalInteger_Int32_Int32 == null)
				{
					r_SetGlobalInteger_Int32_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalInteger", 0, typeof(System.Int32), typeof(System.Int32));
					r_SetGlobalInteger_Int32_Int32.SetBelong(null);
				}
				return r_SetGlobalInteger_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalVector(System.String, UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_SetGlobalVector_String_Vector4;
		public static RMethod RSetGlobalVector_String_Vector4
		{
			get
			{
				if(r_SetGlobalVector_String_Vector4 == null)
				{
					r_SetGlobalVector_String_Vector4 = new(typeof(UnityEngine.Shader), "SetGlobalVector", 0, typeof(System.String), typeof(UnityEngine.Vector4));
					r_SetGlobalVector_String_Vector4.SetBelong(null);
				}
				return r_SetGlobalVector_String_Vector4;
			}
		}

		/// <summary>
		/// Void SetGlobalVector(Int32, UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_SetGlobalVector_Int32_Vector4;
		public static RMethod RSetGlobalVector_Int32_Vector4
		{
			get
			{
				if(r_SetGlobalVector_Int32_Vector4 == null)
				{
					r_SetGlobalVector_Int32_Vector4 = new(typeof(UnityEngine.Shader), "SetGlobalVector", 0, typeof(System.Int32), typeof(UnityEngine.Vector4));
					r_SetGlobalVector_Int32_Vector4.SetBelong(null);
				}
				return r_SetGlobalVector_Int32_Vector4;
			}
		}

		/// <summary>
		/// Void SetGlobalColor(System.String, UnityEngine.Color)
		/// </summary>
		protected static RMethod r_SetGlobalColor_String_Color;
		public static RMethod RSetGlobalColor_String_Color
		{
			get
			{
				if(r_SetGlobalColor_String_Color == null)
				{
					r_SetGlobalColor_String_Color = new(typeof(UnityEngine.Shader), "SetGlobalColor", 0, typeof(System.String), typeof(UnityEngine.Color));
					r_SetGlobalColor_String_Color.SetBelong(null);
				}
				return r_SetGlobalColor_String_Color;
			}
		}

		/// <summary>
		/// Void SetGlobalColor(Int32, UnityEngine.Color)
		/// </summary>
		protected static RMethod r_SetGlobalColor_Int32_Color;
		public static RMethod RSetGlobalColor_Int32_Color
		{
			get
			{
				if(r_SetGlobalColor_Int32_Color == null)
				{
					r_SetGlobalColor_Int32_Color = new(typeof(UnityEngine.Shader), "SetGlobalColor", 0, typeof(System.Int32), typeof(UnityEngine.Color));
					r_SetGlobalColor_Int32_Color.SetBelong(null);
				}
				return r_SetGlobalColor_Int32_Color;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrix(System.String, UnityEngine.Matrix4x4)
		/// </summary>
		protected static RMethod r_SetGlobalMatrix_String_Matrix4x4;
		public static RMethod RSetGlobalMatrix_String_Matrix4x4
		{
			get
			{
				if(r_SetGlobalMatrix_String_Matrix4x4 == null)
				{
					r_SetGlobalMatrix_String_Matrix4x4 = new(typeof(UnityEngine.Shader), "SetGlobalMatrix", 0, typeof(System.String), typeof(UnityEngine.Matrix4x4));
					r_SetGlobalMatrix_String_Matrix4x4.SetBelong(null);
				}
				return r_SetGlobalMatrix_String_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrix(Int32, UnityEngine.Matrix4x4)
		/// </summary>
		protected static RMethod r_SetGlobalMatrix_Int32_Matrix4x4;
		public static RMethod RSetGlobalMatrix_Int32_Matrix4x4
		{
			get
			{
				if(r_SetGlobalMatrix_Int32_Matrix4x4 == null)
				{
					r_SetGlobalMatrix_Int32_Matrix4x4 = new(typeof(UnityEngine.Shader), "SetGlobalMatrix", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4));
					r_SetGlobalMatrix_Int32_Matrix4x4.SetBelong(null);
				}
				return r_SetGlobalMatrix_Int32_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetGlobalTexture(System.String, UnityEngine.Texture)
		/// </summary>
		protected static RMethod r_SetGlobalTexture_String_Texture;
		public static RMethod RSetGlobalTexture_String_Texture
		{
			get
			{
				if(r_SetGlobalTexture_String_Texture == null)
				{
					r_SetGlobalTexture_String_Texture = new(typeof(UnityEngine.Shader), "SetGlobalTexture", 0, typeof(System.String), typeof(UnityEngine.Texture));
					r_SetGlobalTexture_String_Texture.SetBelong(null);
				}
				return r_SetGlobalTexture_String_Texture;
			}
		}

		/// <summary>
		/// Void SetGlobalTexture(Int32, UnityEngine.Texture)
		/// </summary>
		protected static RMethod r_SetGlobalTexture_Int32_Texture;
		public static RMethod RSetGlobalTexture_Int32_Texture
		{
			get
			{
				if(r_SetGlobalTexture_Int32_Texture == null)
				{
					r_SetGlobalTexture_Int32_Texture = new(typeof(UnityEngine.Shader), "SetGlobalTexture", 0, typeof(System.Int32), typeof(UnityEngine.Texture));
					r_SetGlobalTexture_Int32_Texture.SetBelong(null);
				}
				return r_SetGlobalTexture_Int32_Texture;
			}
		}

		/// <summary>
		/// Void SetGlobalTexture(System.String, UnityEngine.RenderTexture, UnityEngine.Rendering.RenderTextureSubElement)
		/// </summary>
		protected static RMethod r_SetGlobalTexture_String_RenderTexture_RenderTextureSubElement;
		public static RMethod RSetGlobalTexture_String_RenderTexture_RenderTextureSubElement
		{
			get
			{
				if(r_SetGlobalTexture_String_RenderTexture_RenderTextureSubElement == null)
				{
					r_SetGlobalTexture_String_RenderTexture_RenderTextureSubElement = new(typeof(UnityEngine.Shader), "SetGlobalTexture", 0, typeof(System.String), typeof(UnityEngine.RenderTexture), typeof(UnityEngine.Rendering.RenderTextureSubElement));
					r_SetGlobalTexture_String_RenderTexture_RenderTextureSubElement.SetBelong(null);
				}
				return r_SetGlobalTexture_String_RenderTexture_RenderTextureSubElement;
			}
		}

		/// <summary>
		/// Void SetGlobalTexture(Int32, UnityEngine.RenderTexture, UnityEngine.Rendering.RenderTextureSubElement)
		/// </summary>
		protected static RMethod r_SetGlobalTexture_Int32_RenderTexture_RenderTextureSubElement;
		public static RMethod RSetGlobalTexture_Int32_RenderTexture_RenderTextureSubElement
		{
			get
			{
				if(r_SetGlobalTexture_Int32_RenderTexture_RenderTextureSubElement == null)
				{
					r_SetGlobalTexture_Int32_RenderTexture_RenderTextureSubElement = new(typeof(UnityEngine.Shader), "SetGlobalTexture", 0, typeof(System.Int32), typeof(UnityEngine.RenderTexture), typeof(UnityEngine.Rendering.RenderTextureSubElement));
					r_SetGlobalTexture_Int32_RenderTexture_RenderTextureSubElement.SetBelong(null);
				}
				return r_SetGlobalTexture_Int32_RenderTexture_RenderTextureSubElement;
			}
		}

		/// <summary>
		/// Void SetGlobalBuffer(System.String, UnityEngine.ComputeBuffer)
		/// </summary>
		protected static RMethod r_SetGlobalBuffer_String_ComputeBuffer;
		public static RMethod RSetGlobalBuffer_String_ComputeBuffer
		{
			get
			{
				if(r_SetGlobalBuffer_String_ComputeBuffer == null)
				{
					r_SetGlobalBuffer_String_ComputeBuffer = new(typeof(UnityEngine.Shader), "SetGlobalBuffer", 0, typeof(System.String), typeof(UnityEngine.ComputeBuffer));
					r_SetGlobalBuffer_String_ComputeBuffer.SetBelong(null);
				}
				return r_SetGlobalBuffer_String_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetGlobalBuffer(Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected static RMethod r_SetGlobalBuffer_Int32_ComputeBuffer;
		public static RMethod RSetGlobalBuffer_Int32_ComputeBuffer
		{
			get
			{
				if(r_SetGlobalBuffer_Int32_ComputeBuffer == null)
				{
					r_SetGlobalBuffer_Int32_ComputeBuffer = new(typeof(UnityEngine.Shader), "SetGlobalBuffer", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
					r_SetGlobalBuffer_Int32_ComputeBuffer.SetBelong(null);
				}
				return r_SetGlobalBuffer_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetGlobalBuffer(System.String, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected static RMethod r_SetGlobalBuffer_String_GraphicsBuffer;
		public static RMethod RSetGlobalBuffer_String_GraphicsBuffer
		{
			get
			{
				if(r_SetGlobalBuffer_String_GraphicsBuffer == null)
				{
					r_SetGlobalBuffer_String_GraphicsBuffer = new(typeof(UnityEngine.Shader), "SetGlobalBuffer", 0, typeof(System.String), typeof(UnityEngine.GraphicsBuffer));
					r_SetGlobalBuffer_String_GraphicsBuffer.SetBelong(null);
				}
				return r_SetGlobalBuffer_String_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetGlobalBuffer(Int32, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected static RMethod r_SetGlobalBuffer_Int32_GraphicsBuffer;
		public static RMethod RSetGlobalBuffer_Int32_GraphicsBuffer
		{
			get
			{
				if(r_SetGlobalBuffer_Int32_GraphicsBuffer == null)
				{
					r_SetGlobalBuffer_Int32_GraphicsBuffer = new(typeof(UnityEngine.Shader), "SetGlobalBuffer", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer));
					r_SetGlobalBuffer_Int32_GraphicsBuffer.SetBelong(null);
				}
				return r_SetGlobalBuffer_Int32_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetGlobalConstantBuffer(System.String, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected static RMethod r_SetGlobalConstantBuffer_String_ComputeBuffer_Int32_Int32;
		public static RMethod RSetGlobalConstantBuffer_String_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_SetGlobalConstantBuffer_String_ComputeBuffer_Int32_Int32 == null)
				{
					r_SetGlobalConstantBuffer_String_ComputeBuffer_Int32_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalConstantBuffer", 0, typeof(System.String), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
					r_SetGlobalConstantBuffer_String_ComputeBuffer_Int32_Int32.SetBelong(null);
				}
				return r_SetGlobalConstantBuffer_String_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalConstantBuffer(Int32, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected static RMethod r_SetGlobalConstantBuffer_Int32_ComputeBuffer_Int32_Int32;
		public static RMethod RSetGlobalConstantBuffer_Int32_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_SetGlobalConstantBuffer_Int32_ComputeBuffer_Int32_Int32 == null)
				{
					r_SetGlobalConstantBuffer_Int32_ComputeBuffer_Int32_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalConstantBuffer", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
					r_SetGlobalConstantBuffer_Int32_ComputeBuffer_Int32_Int32.SetBelong(null);
				}
				return r_SetGlobalConstantBuffer_Int32_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalConstantBuffer(System.String, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected static RMethod r_SetGlobalConstantBuffer_String_GraphicsBuffer_Int32_Int32;
		public static RMethod RSetGlobalConstantBuffer_String_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_SetGlobalConstantBuffer_String_GraphicsBuffer_Int32_Int32 == null)
				{
					r_SetGlobalConstantBuffer_String_GraphicsBuffer_Int32_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalConstantBuffer", 0, typeof(System.String), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
					r_SetGlobalConstantBuffer_String_GraphicsBuffer_Int32_Int32.SetBelong(null);
				}
				return r_SetGlobalConstantBuffer_String_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalConstantBuffer(Int32, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected static RMethod r_SetGlobalConstantBuffer_Int32_GraphicsBuffer_Int32_Int32;
		public static RMethod RSetGlobalConstantBuffer_Int32_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_SetGlobalConstantBuffer_Int32_GraphicsBuffer_Int32_Int32 == null)
				{
					r_SetGlobalConstantBuffer_Int32_GraphicsBuffer_Int32_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalConstantBuffer", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
					r_SetGlobalConstantBuffer_Int32_GraphicsBuffer_Int32_Int32.SetBelong(null);
				}
				return r_SetGlobalConstantBuffer_Int32_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalFloatArray(System.String, System.Collections.Generic.List`1[System.Single])
		/// </summary>
		protected static RMethod r_SetGlobalFloatArray_String_List_d_Single_p_;
		public static RMethod RSetGlobalFloatArray_String_List_d_Single_p_
		{
			get
			{
				if(r_SetGlobalFloatArray_String_List_d_Single_p_ == null)
				{
					r_SetGlobalFloatArray_String_List_d_Single_p_ = new(typeof(UnityEngine.Shader), "SetGlobalFloatArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Single)));
					r_SetGlobalFloatArray_String_List_d_Single_p_.SetBelong(null);
				}
				return r_SetGlobalFloatArray_String_List_d_Single_p_;
			}
		}

		/// <summary>
		/// Void SetGlobalFloatArray(Int32, System.Collections.Generic.List`1[System.Single])
		/// </summary>
		protected static RMethod r_SetGlobalFloatArray_Int32_List_d_Single_p_;
		public static RMethod RSetGlobalFloatArray_Int32_List_d_Single_p_
		{
			get
			{
				if(r_SetGlobalFloatArray_Int32_List_d_Single_p_ == null)
				{
					r_SetGlobalFloatArray_Int32_List_d_Single_p_ = new(typeof(UnityEngine.Shader), "SetGlobalFloatArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Single)));
					r_SetGlobalFloatArray_Int32_List_d_Single_p_.SetBelong(null);
				}
				return r_SetGlobalFloatArray_Int32_List_d_Single_p_;
			}
		}

		/// <summary>
		/// Void SetGlobalFloatArray(System.String, Single[])
		/// </summary>
		protected static RMethod r_SetGlobalFloatArray_String_SingleArray;
		public static RMethod RSetGlobalFloatArray_String_SingleArray
		{
			get
			{
				if(r_SetGlobalFloatArray_String_SingleArray == null)
				{
					r_SetGlobalFloatArray_String_SingleArray = new(typeof(UnityEngine.Shader), "SetGlobalFloatArray", 0, typeof(System.String), typeof(System.Single).MakeArrayType());
					r_SetGlobalFloatArray_String_SingleArray.SetBelong(null);
				}
				return r_SetGlobalFloatArray_String_SingleArray;
			}
		}

		/// <summary>
		/// Void SetGlobalFloatArray(Int32, Single[])
		/// </summary>
		protected static RMethod r_SetGlobalFloatArray_Int32_SingleArray;
		public static RMethod RSetGlobalFloatArray_Int32_SingleArray
		{
			get
			{
				if(r_SetGlobalFloatArray_Int32_SingleArray == null)
				{
					r_SetGlobalFloatArray_Int32_SingleArray = new(typeof(UnityEngine.Shader), "SetGlobalFloatArray", 0, typeof(System.Int32), typeof(System.Single).MakeArrayType());
					r_SetGlobalFloatArray_Int32_SingleArray.SetBelong(null);
				}
				return r_SetGlobalFloatArray_Int32_SingleArray;
			}
		}

		/// <summary>
		/// Void SetGlobalVectorArray(System.String, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected static RMethod r_SetGlobalVectorArray_String_List_d_Vector4_p_;
		public static RMethod RSetGlobalVectorArray_String_List_d_Vector4_p_
		{
			get
			{
				if(r_SetGlobalVectorArray_String_List_d_Vector4_p_ == null)
				{
					r_SetGlobalVectorArray_String_List_d_Vector4_p_ = new(typeof(UnityEngine.Shader), "SetGlobalVectorArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_SetGlobalVectorArray_String_List_d_Vector4_p_.SetBelong(null);
				}
				return r_SetGlobalVectorArray_String_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void SetGlobalVectorArray(Int32, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected static RMethod r_SetGlobalVectorArray_Int32_List_d_Vector4_p_;
		public static RMethod RSetGlobalVectorArray_Int32_List_d_Vector4_p_
		{
			get
			{
				if(r_SetGlobalVectorArray_Int32_List_d_Vector4_p_ == null)
				{
					r_SetGlobalVectorArray_Int32_List_d_Vector4_p_ = new(typeof(UnityEngine.Shader), "SetGlobalVectorArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_SetGlobalVectorArray_Int32_List_d_Vector4_p_.SetBelong(null);
				}
				return r_SetGlobalVectorArray_Int32_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void SetGlobalVectorArray(System.String, UnityEngine.Vector4[])
		/// </summary>
		protected static RMethod r_SetGlobalVectorArray_String_Vector4Array;
		public static RMethod RSetGlobalVectorArray_String_Vector4Array
		{
			get
			{
				if(r_SetGlobalVectorArray_String_Vector4Array == null)
				{
					r_SetGlobalVectorArray_String_Vector4Array = new(typeof(UnityEngine.Shader), "SetGlobalVectorArray", 0, typeof(System.String), typeof(UnityEngine.Vector4).MakeArrayType());
					r_SetGlobalVectorArray_String_Vector4Array.SetBelong(null);
				}
				return r_SetGlobalVectorArray_String_Vector4Array;
			}
		}

		/// <summary>
		/// Void SetGlobalVectorArray(Int32, UnityEngine.Vector4[])
		/// </summary>
		protected static RMethod r_SetGlobalVectorArray_Int32_Vector4Array;
		public static RMethod RSetGlobalVectorArray_Int32_Vector4Array
		{
			get
			{
				if(r_SetGlobalVectorArray_Int32_Vector4Array == null)
				{
					r_SetGlobalVectorArray_Int32_Vector4Array = new(typeof(UnityEngine.Shader), "SetGlobalVectorArray", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType());
					r_SetGlobalVectorArray_Int32_Vector4Array.SetBelong(null);
				}
				return r_SetGlobalVectorArray_Int32_Vector4Array;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrixArray(System.String, System.Collections.Generic.List`1[UnityEngine.Matrix4x4])
		/// </summary>
		protected static RMethod r_SetGlobalMatrixArray_String_List_d_Matrix4x4_p_;
		public static RMethod RSetGlobalMatrixArray_String_List_d_Matrix4x4_p_
		{
			get
			{
				if(r_SetGlobalMatrixArray_String_List_d_Matrix4x4_p_ == null)
				{
					r_SetGlobalMatrixArray_String_List_d_Matrix4x4_p_ = new(typeof(UnityEngine.Shader), "SetGlobalMatrixArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Matrix4x4)));
					r_SetGlobalMatrixArray_String_List_d_Matrix4x4_p_.SetBelong(null);
				}
				return r_SetGlobalMatrixArray_String_List_d_Matrix4x4_p_;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrixArray(Int32, System.Collections.Generic.List`1[UnityEngine.Matrix4x4])
		/// </summary>
		protected static RMethod r_SetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_;
		public static RMethod RSetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_
		{
			get
			{
				if(r_SetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_ == null)
				{
					r_SetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_ = new(typeof(UnityEngine.Shader), "SetGlobalMatrixArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Matrix4x4)));
					r_SetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_.SetBelong(null);
				}
				return r_SetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrixArray(System.String, UnityEngine.Matrix4x4[])
		/// </summary>
		protected static RMethod r_SetGlobalMatrixArray_String_Matrix4x4Array;
		public static RMethod RSetGlobalMatrixArray_String_Matrix4x4Array
		{
			get
			{
				if(r_SetGlobalMatrixArray_String_Matrix4x4Array == null)
				{
					r_SetGlobalMatrixArray_String_Matrix4x4Array = new(typeof(UnityEngine.Shader), "SetGlobalMatrixArray", 0, typeof(System.String), typeof(UnityEngine.Matrix4x4).MakeArrayType());
					r_SetGlobalMatrixArray_String_Matrix4x4Array.SetBelong(null);
				}
				return r_SetGlobalMatrixArray_String_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrixArray(Int32, UnityEngine.Matrix4x4[])
		/// </summary>
		protected static RMethod r_SetGlobalMatrixArray_Int32_Matrix4x4Array;
		public static RMethod RSetGlobalMatrixArray_Int32_Matrix4x4Array
		{
			get
			{
				if(r_SetGlobalMatrixArray_Int32_Matrix4x4Array == null)
				{
					r_SetGlobalMatrixArray_Int32_Matrix4x4Array = new(typeof(UnityEngine.Shader), "SetGlobalMatrixArray", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType());
					r_SetGlobalMatrixArray_Int32_Matrix4x4Array.SetBelong(null);
				}
				return r_SetGlobalMatrixArray_Int32_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Int32 GetGlobalInt(System.String)
		/// </summary>
		protected static RMethod r_GetGlobalInt_String;
		public static RMethod RGetGlobalInt_String
		{
			get
			{
				if(r_GetGlobalInt_String == null)
				{
					r_GetGlobalInt_String = new(typeof(UnityEngine.Shader), "GetGlobalInt", 0, typeof(System.String));
					r_GetGlobalInt_String.SetBelong(null);
				}
				return r_GetGlobalInt_String;
			}
		}

		/// <summary>
		/// Int32 GetGlobalInt(Int32)
		/// </summary>
		protected static RMethod r_GetGlobalInt_Int32;
		public static RMethod RGetGlobalInt_Int32
		{
			get
			{
				if(r_GetGlobalInt_Int32 == null)
				{
					r_GetGlobalInt_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalInt", 0, typeof(System.Int32));
					r_GetGlobalInt_Int32.SetBelong(null);
				}
				return r_GetGlobalInt_Int32;
			}
		}

		/// <summary>
		/// Single GetGlobalFloat(System.String)
		/// </summary>
		protected static RMethod r_GetGlobalFloat_String;
		public static RMethod RGetGlobalFloat_String
		{
			get
			{
				if(r_GetGlobalFloat_String == null)
				{
					r_GetGlobalFloat_String = new(typeof(UnityEngine.Shader), "GetGlobalFloat", 0, typeof(System.String));
					r_GetGlobalFloat_String.SetBelong(null);
				}
				return r_GetGlobalFloat_String;
			}
		}

		/// <summary>
		/// Single GetGlobalFloat(Int32)
		/// </summary>
		protected static RMethod r_GetGlobalFloat_Int32;
		public static RMethod RGetGlobalFloat_Int32
		{
			get
			{
				if(r_GetGlobalFloat_Int32 == null)
				{
					r_GetGlobalFloat_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalFloat", 0, typeof(System.Int32));
					r_GetGlobalFloat_Int32.SetBelong(null);
				}
				return r_GetGlobalFloat_Int32;
			}
		}

		/// <summary>
		/// Int32 GetGlobalInteger(System.String)
		/// </summary>
		protected static RMethod r_GetGlobalInteger_String;
		public static RMethod RGetGlobalInteger_String
		{
			get
			{
				if(r_GetGlobalInteger_String == null)
				{
					r_GetGlobalInteger_String = new(typeof(UnityEngine.Shader), "GetGlobalInteger", 0, typeof(System.String));
					r_GetGlobalInteger_String.SetBelong(null);
				}
				return r_GetGlobalInteger_String;
			}
		}

		/// <summary>
		/// Int32 GetGlobalInteger(Int32)
		/// </summary>
		protected static RMethod r_GetGlobalInteger_Int32;
		public static RMethod RGetGlobalInteger_Int32
		{
			get
			{
				if(r_GetGlobalInteger_Int32 == null)
				{
					r_GetGlobalInteger_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalInteger", 0, typeof(System.Int32));
					r_GetGlobalInteger_Int32.SetBelong(null);
				}
				return r_GetGlobalInteger_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 GetGlobalVector(System.String)
		/// </summary>
		protected static RMethod r_GetGlobalVector_String;
		public static RMethod RGetGlobalVector_String
		{
			get
			{
				if(r_GetGlobalVector_String == null)
				{
					r_GetGlobalVector_String = new(typeof(UnityEngine.Shader), "GetGlobalVector", 0, typeof(System.String));
					r_GetGlobalVector_String.SetBelong(null);
				}
				return r_GetGlobalVector_String;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 GetGlobalVector(Int32)
		/// </summary>
		protected static RMethod r_GetGlobalVector_Int32;
		public static RMethod RGetGlobalVector_Int32
		{
			get
			{
				if(r_GetGlobalVector_Int32 == null)
				{
					r_GetGlobalVector_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalVector", 0, typeof(System.Int32));
					r_GetGlobalVector_Int32.SetBelong(null);
				}
				return r_GetGlobalVector_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetGlobalColor(System.String)
		/// </summary>
		protected static RMethod r_GetGlobalColor_String;
		public static RMethod RGetGlobalColor_String
		{
			get
			{
				if(r_GetGlobalColor_String == null)
				{
					r_GetGlobalColor_String = new(typeof(UnityEngine.Shader), "GetGlobalColor", 0, typeof(System.String));
					r_GetGlobalColor_String.SetBelong(null);
				}
				return r_GetGlobalColor_String;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetGlobalColor(Int32)
		/// </summary>
		protected static RMethod r_GetGlobalColor_Int32;
		public static RMethod RGetGlobalColor_Int32
		{
			get
			{
				if(r_GetGlobalColor_Int32 == null)
				{
					r_GetGlobalColor_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalColor", 0, typeof(System.Int32));
					r_GetGlobalColor_Int32.SetBelong(null);
				}
				return r_GetGlobalColor_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 GetGlobalMatrix(System.String)
		/// </summary>
		protected static RMethod r_GetGlobalMatrix_String;
		public static RMethod RGetGlobalMatrix_String
		{
			get
			{
				if(r_GetGlobalMatrix_String == null)
				{
					r_GetGlobalMatrix_String = new(typeof(UnityEngine.Shader), "GetGlobalMatrix", 0, typeof(System.String));
					r_GetGlobalMatrix_String.SetBelong(null);
				}
				return r_GetGlobalMatrix_String;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 GetGlobalMatrix(Int32)
		/// </summary>
		protected static RMethod r_GetGlobalMatrix_Int32;
		public static RMethod RGetGlobalMatrix_Int32
		{
			get
			{
				if(r_GetGlobalMatrix_Int32 == null)
				{
					r_GetGlobalMatrix_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalMatrix", 0, typeof(System.Int32));
					r_GetGlobalMatrix_Int32.SetBelong(null);
				}
				return r_GetGlobalMatrix_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Texture GetGlobalTexture(System.String)
		/// </summary>
		protected static RMethod r_GetGlobalTexture_String;
		public static RMethod RGetGlobalTexture_String
		{
			get
			{
				if(r_GetGlobalTexture_String == null)
				{
					r_GetGlobalTexture_String = new(typeof(UnityEngine.Shader), "GetGlobalTexture", 0, typeof(System.String));
					r_GetGlobalTexture_String.SetBelong(null);
				}
				return r_GetGlobalTexture_String;
			}
		}

		/// <summary>
		/// UnityEngine.Texture GetGlobalTexture(Int32)
		/// </summary>
		protected static RMethod r_GetGlobalTexture_Int32;
		public static RMethod RGetGlobalTexture_Int32
		{
			get
			{
				if(r_GetGlobalTexture_Int32 == null)
				{
					r_GetGlobalTexture_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalTexture", 0, typeof(System.Int32));
					r_GetGlobalTexture_Int32.SetBelong(null);
				}
				return r_GetGlobalTexture_Int32;
			}
		}

		/// <summary>
		/// Single[] GetGlobalFloatArray(System.String)
		/// </summary>
		protected static RMethod r_GetGlobalFloatArray_String;
		public static RMethod RGetGlobalFloatArray_String
		{
			get
			{
				if(r_GetGlobalFloatArray_String == null)
				{
					r_GetGlobalFloatArray_String = new(typeof(UnityEngine.Shader), "GetGlobalFloatArray", 0, typeof(System.String));
					r_GetGlobalFloatArray_String.SetBelong(null);
				}
				return r_GetGlobalFloatArray_String;
			}
		}

		/// <summary>
		/// Single[] GetGlobalFloatArray(Int32)
		/// </summary>
		protected static RMethod r_GetGlobalFloatArray_Int32;
		public static RMethod RGetGlobalFloatArray_Int32
		{
			get
			{
				if(r_GetGlobalFloatArray_Int32 == null)
				{
					r_GetGlobalFloatArray_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalFloatArray", 0, typeof(System.Int32));
					r_GetGlobalFloatArray_Int32.SetBelong(null);
				}
				return r_GetGlobalFloatArray_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4[] GetGlobalVectorArray(System.String)
		/// </summary>
		protected static RMethod r_GetGlobalVectorArray_String;
		public static RMethod RGetGlobalVectorArray_String
		{
			get
			{
				if(r_GetGlobalVectorArray_String == null)
				{
					r_GetGlobalVectorArray_String = new(typeof(UnityEngine.Shader), "GetGlobalVectorArray", 0, typeof(System.String));
					r_GetGlobalVectorArray_String.SetBelong(null);
				}
				return r_GetGlobalVectorArray_String;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4[] GetGlobalVectorArray(Int32)
		/// </summary>
		protected static RMethod r_GetGlobalVectorArray_Int32;
		public static RMethod RGetGlobalVectorArray_Int32
		{
			get
			{
				if(r_GetGlobalVectorArray_Int32 == null)
				{
					r_GetGlobalVectorArray_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalVectorArray", 0, typeof(System.Int32));
					r_GetGlobalVectorArray_Int32.SetBelong(null);
				}
				return r_GetGlobalVectorArray_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4[] GetGlobalMatrixArray(System.String)
		/// </summary>
		protected static RMethod r_GetGlobalMatrixArray_String;
		public static RMethod RGetGlobalMatrixArray_String
		{
			get
			{
				if(r_GetGlobalMatrixArray_String == null)
				{
					r_GetGlobalMatrixArray_String = new(typeof(UnityEngine.Shader), "GetGlobalMatrixArray", 0, typeof(System.String));
					r_GetGlobalMatrixArray_String.SetBelong(null);
				}
				return r_GetGlobalMatrixArray_String;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4[] GetGlobalMatrixArray(Int32)
		/// </summary>
		protected static RMethod r_GetGlobalMatrixArray_Int32;
		public static RMethod RGetGlobalMatrixArray_Int32
		{
			get
			{
				if(r_GetGlobalMatrixArray_Int32 == null)
				{
					r_GetGlobalMatrixArray_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalMatrixArray", 0, typeof(System.Int32));
					r_GetGlobalMatrixArray_Int32.SetBelong(null);
				}
				return r_GetGlobalMatrixArray_Int32;
			}
		}

		/// <summary>
		/// Void GetGlobalFloatArray(System.String, System.Collections.Generic.List`1[System.Single])
		/// </summary>
		protected static RMethod r_GetGlobalFloatArray_String_List_d_Single_p_;
		public static RMethod RGetGlobalFloatArray_String_List_d_Single_p_
		{
			get
			{
				if(r_GetGlobalFloatArray_String_List_d_Single_p_ == null)
				{
					r_GetGlobalFloatArray_String_List_d_Single_p_ = new(typeof(UnityEngine.Shader), "GetGlobalFloatArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Single)));
					r_GetGlobalFloatArray_String_List_d_Single_p_.SetBelong(null);
				}
				return r_GetGlobalFloatArray_String_List_d_Single_p_;
			}
		}

		/// <summary>
		/// Void GetGlobalFloatArray(Int32, System.Collections.Generic.List`1[System.Single])
		/// </summary>
		protected static RMethod r_GetGlobalFloatArray_Int32_List_d_Single_p_;
		public static RMethod RGetGlobalFloatArray_Int32_List_d_Single_p_
		{
			get
			{
				if(r_GetGlobalFloatArray_Int32_List_d_Single_p_ == null)
				{
					r_GetGlobalFloatArray_Int32_List_d_Single_p_ = new(typeof(UnityEngine.Shader), "GetGlobalFloatArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Single)));
					r_GetGlobalFloatArray_Int32_List_d_Single_p_.SetBelong(null);
				}
				return r_GetGlobalFloatArray_Int32_List_d_Single_p_;
			}
		}

		/// <summary>
		/// Void GetGlobalVectorArray(System.String, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected static RMethod r_GetGlobalVectorArray_String_List_d_Vector4_p_;
		public static RMethod RGetGlobalVectorArray_String_List_d_Vector4_p_
		{
			get
			{
				if(r_GetGlobalVectorArray_String_List_d_Vector4_p_ == null)
				{
					r_GetGlobalVectorArray_String_List_d_Vector4_p_ = new(typeof(UnityEngine.Shader), "GetGlobalVectorArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_GetGlobalVectorArray_String_List_d_Vector4_p_.SetBelong(null);
				}
				return r_GetGlobalVectorArray_String_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void GetGlobalVectorArray(Int32, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected static RMethod r_GetGlobalVectorArray_Int32_List_d_Vector4_p_;
		public static RMethod RGetGlobalVectorArray_Int32_List_d_Vector4_p_
		{
			get
			{
				if(r_GetGlobalVectorArray_Int32_List_d_Vector4_p_ == null)
				{
					r_GetGlobalVectorArray_Int32_List_d_Vector4_p_ = new(typeof(UnityEngine.Shader), "GetGlobalVectorArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_GetGlobalVectorArray_Int32_List_d_Vector4_p_.SetBelong(null);
				}
				return r_GetGlobalVectorArray_Int32_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void GetGlobalMatrixArray(System.String, System.Collections.Generic.List`1[UnityEngine.Matrix4x4])
		/// </summary>
		protected static RMethod r_GetGlobalMatrixArray_String_List_d_Matrix4x4_p_;
		public static RMethod RGetGlobalMatrixArray_String_List_d_Matrix4x4_p_
		{
			get
			{
				if(r_GetGlobalMatrixArray_String_List_d_Matrix4x4_p_ == null)
				{
					r_GetGlobalMatrixArray_String_List_d_Matrix4x4_p_ = new(typeof(UnityEngine.Shader), "GetGlobalMatrixArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Matrix4x4)));
					r_GetGlobalMatrixArray_String_List_d_Matrix4x4_p_.SetBelong(null);
				}
				return r_GetGlobalMatrixArray_String_List_d_Matrix4x4_p_;
			}
		}

		/// <summary>
		/// Void GetGlobalMatrixArray(Int32, System.Collections.Generic.List`1[UnityEngine.Matrix4x4])
		/// </summary>
		protected static RMethod r_GetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_;
		public static RMethod RGetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_
		{
			get
			{
				if(r_GetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_ == null)
				{
					r_GetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_ = new(typeof(UnityEngine.Shader), "GetGlobalMatrixArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Matrix4x4)));
					r_GetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_.SetBelong(null);
				}
				return r_GetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_;
			}
		}

		/// <summary>
		/// System.String GetPropertyName(UnityEngine.Shader, Int32)
		/// </summary>
		protected static RMethod r_GetPropertyName_Shader_Int32;
		public static RMethod RGetPropertyName_Shader_Int32
		{
			get
			{
				if(r_GetPropertyName_Shader_Int32 == null)
				{
					r_GetPropertyName_Shader_Int32 = new(typeof(UnityEngine.Shader), "GetPropertyName", 0, typeof(UnityEngine.Shader), typeof(System.Int32));
					r_GetPropertyName_Shader_Int32.SetBelong(null);
				}
				return r_GetPropertyName_Shader_Int32;
			}
		}

		/// <summary>
		/// Int32 GetPropertyNameId(UnityEngine.Shader, Int32)
		/// </summary>
		protected static RMethod r_GetPropertyNameId_Shader_Int32;
		public static RMethod RGetPropertyNameId_Shader_Int32
		{
			get
			{
				if(r_GetPropertyNameId_Shader_Int32 == null)
				{
					r_GetPropertyNameId_Shader_Int32 = new(typeof(UnityEngine.Shader), "GetPropertyNameId", 0, typeof(UnityEngine.Shader), typeof(System.Int32));
					r_GetPropertyNameId_Shader_Int32.SetBelong(null);
				}
				return r_GetPropertyNameId_Shader_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ShaderPropertyType GetPropertyType(UnityEngine.Shader, Int32)
		/// </summary>
		protected static RMethod r_GetPropertyType_Shader_Int32;
		public static RMethod RGetPropertyType_Shader_Int32
		{
			get
			{
				if(r_GetPropertyType_Shader_Int32 == null)
				{
					r_GetPropertyType_Shader_Int32 = new(typeof(UnityEngine.Shader), "GetPropertyType", 0, typeof(UnityEngine.Shader), typeof(System.Int32));
					r_GetPropertyType_Shader_Int32.SetBelong(null);
				}
				return r_GetPropertyType_Shader_Int32;
			}
		}

		/// <summary>
		/// System.String GetPropertyDescription(UnityEngine.Shader, Int32)
		/// </summary>
		protected static RMethod r_GetPropertyDescription_Shader_Int32;
		public static RMethod RGetPropertyDescription_Shader_Int32
		{
			get
			{
				if(r_GetPropertyDescription_Shader_Int32 == null)
				{
					r_GetPropertyDescription_Shader_Int32 = new(typeof(UnityEngine.Shader), "GetPropertyDescription", 0, typeof(UnityEngine.Shader), typeof(System.Int32));
					r_GetPropertyDescription_Shader_Int32.SetBelong(null);
				}
				return r_GetPropertyDescription_Shader_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ShaderPropertyFlags GetPropertyFlags(UnityEngine.Shader, Int32)
		/// </summary>
		protected static RMethod r_GetPropertyFlags_Shader_Int32;
		public static RMethod RGetPropertyFlags_Shader_Int32
		{
			get
			{
				if(r_GetPropertyFlags_Shader_Int32 == null)
				{
					r_GetPropertyFlags_Shader_Int32 = new(typeof(UnityEngine.Shader), "GetPropertyFlags", 0, typeof(UnityEngine.Shader), typeof(System.Int32));
					r_GetPropertyFlags_Shader_Int32.SetBelong(null);
				}
				return r_GetPropertyFlags_Shader_Int32;
			}
		}

		/// <summary>
		/// System.String[] GetPropertyAttributes(UnityEngine.Shader, Int32)
		/// </summary>
		protected static RMethod r_GetPropertyAttributes_Shader_Int32;
		public static RMethod RGetPropertyAttributes_Shader_Int32
		{
			get
			{
				if(r_GetPropertyAttributes_Shader_Int32 == null)
				{
					r_GetPropertyAttributes_Shader_Int32 = new(typeof(UnityEngine.Shader), "GetPropertyAttributes", 0, typeof(UnityEngine.Shader), typeof(System.Int32));
					r_GetPropertyAttributes_Shader_Int32.SetBelong(null);
				}
				return r_GetPropertyAttributes_Shader_Int32;
			}
		}

		/// <summary>
		/// Int32 GetPropertyDefaultIntValue(UnityEngine.Shader, Int32)
		/// </summary>
		protected static RMethod r_GetPropertyDefaultIntValue_Shader_Int32;
		public static RMethod RGetPropertyDefaultIntValue_Shader_Int32
		{
			get
			{
				if(r_GetPropertyDefaultIntValue_Shader_Int32 == null)
				{
					r_GetPropertyDefaultIntValue_Shader_Int32 = new(typeof(UnityEngine.Shader), "GetPropertyDefaultIntValue", 0, typeof(UnityEngine.Shader), typeof(System.Int32));
					r_GetPropertyDefaultIntValue_Shader_Int32.SetBelong(null);
				}
				return r_GetPropertyDefaultIntValue_Shader_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 GetPropertyDefaultValue(UnityEngine.Shader, Int32)
		/// </summary>
		protected static RMethod r_GetPropertyDefaultValue_Shader_Int32;
		public static RMethod RGetPropertyDefaultValue_Shader_Int32
		{
			get
			{
				if(r_GetPropertyDefaultValue_Shader_Int32 == null)
				{
					r_GetPropertyDefaultValue_Shader_Int32 = new(typeof(UnityEngine.Shader), "GetPropertyDefaultValue", 0, typeof(UnityEngine.Shader), typeof(System.Int32));
					r_GetPropertyDefaultValue_Shader_Int32.SetBelong(null);
				}
				return r_GetPropertyDefaultValue_Shader_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.TextureDimension GetPropertyTextureDimension(UnityEngine.Shader, Int32)
		/// </summary>
		protected static RMethod r_GetPropertyTextureDimension_Shader_Int32;
		public static RMethod RGetPropertyTextureDimension_Shader_Int32
		{
			get
			{
				if(r_GetPropertyTextureDimension_Shader_Int32 == null)
				{
					r_GetPropertyTextureDimension_Shader_Int32 = new(typeof(UnityEngine.Shader), "GetPropertyTextureDimension", 0, typeof(UnityEngine.Shader), typeof(System.Int32));
					r_GetPropertyTextureDimension_Shader_Int32.SetBelong(null);
				}
				return r_GetPropertyTextureDimension_Shader_Int32;
			}
		}

		/// <summary>
		/// System.String GetPropertyTextureDefaultName(UnityEngine.Shader, Int32)
		/// </summary>
		protected static RMethod r_GetPropertyTextureDefaultName_Shader_Int32;
		public static RMethod RGetPropertyTextureDefaultName_Shader_Int32
		{
			get
			{
				if(r_GetPropertyTextureDefaultName_Shader_Int32 == null)
				{
					r_GetPropertyTextureDefaultName_Shader_Int32 = new(typeof(UnityEngine.Shader), "GetPropertyTextureDefaultName", 0, typeof(UnityEngine.Shader), typeof(System.Int32));
					r_GetPropertyTextureDefaultName_Shader_Int32.SetBelong(null);
				}
				return r_GetPropertyTextureDefaultName_Shader_Int32;
			}
		}

		/// <summary>
		/// Boolean FindTextureStackImpl(UnityEngine.Shader, Int32, System.String ByRef, Int32 ByRef)
		/// </summary>
		protected static RMethod r_FindTextureStackImpl_Shader_Int32_Out_String_Out_Int32;
		public static RMethod RFindTextureStackImpl_Shader_Int32_Out_String_Out_Int32
		{
			get
			{
				if(r_FindTextureStackImpl_Shader_Int32_Out_String_Out_Int32 == null)
				{
					r_FindTextureStackImpl_Shader_Int32_Out_String_Out_Int32 = new(typeof(UnityEngine.Shader), "FindTextureStackImpl", 0, typeof(UnityEngine.Shader), typeof(System.Int32), typeof(System.String).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_FindTextureStackImpl_Shader_Int32_Out_String_Out_Int32.SetBelong(null);
				}
				return r_FindTextureStackImpl_Shader_Int32_Out_String_Out_Int32;
			}
		}

		/// <summary>
		/// Void CheckPropertyIndex(UnityEngine.Shader, Int32)
		/// </summary>
		protected static RMethod r_CheckPropertyIndex_Shader_Int32;
		public static RMethod RCheckPropertyIndex_Shader_Int32
		{
			get
			{
				if(r_CheckPropertyIndex_Shader_Int32 == null)
				{
					r_CheckPropertyIndex_Shader_Int32 = new(typeof(UnityEngine.Shader), "CheckPropertyIndex", 0, typeof(UnityEngine.Shader), typeof(System.Int32));
					r_CheckPropertyIndex_Shader_Int32.SetBelong(null);
				}
				return r_CheckPropertyIndex_Shader_Int32;
			}
		}

		/// <summary>
		/// Int32 GetPropertyCount()
		/// </summary>
		protected RMethod r_GetPropertyCount;
		public virtual RMethod RGetPropertyCount
		{
			get
			{
				if(r_GetPropertyCount == null)
				{
					r_GetPropertyCount = new(this, "GetPropertyCount", 0);
					r_GetPropertyCount.SetBelong(this.instance);
				}
				return r_GetPropertyCount;
			}
		}

		/// <summary>
		/// Int32 FindPropertyIndex(System.String)
		/// </summary>
		protected RMethod r_FindPropertyIndex_String;
		public virtual RMethod RFindPropertyIndex_String
		{
			get
			{
				if(r_FindPropertyIndex_String == null)
				{
					r_FindPropertyIndex_String = new(this, "FindPropertyIndex", 0, typeof(System.String));
					r_FindPropertyIndex_String.SetBelong(this.instance);
				}
				return r_FindPropertyIndex_String;
			}
		}

		/// <summary>
		/// System.String GetPropertyName(Int32)
		/// </summary>
		protected RMethod r_GetPropertyName_Int32;
		public virtual RMethod RGetPropertyName_Int32
		{
			get
			{
				if(r_GetPropertyName_Int32 == null)
				{
					r_GetPropertyName_Int32 = new(this, "GetPropertyName", 0, typeof(System.Int32));
					r_GetPropertyName_Int32.SetBelong(this.instance);
				}
				return r_GetPropertyName_Int32;
			}
		}

		/// <summary>
		/// Int32 GetPropertyNameId(Int32)
		/// </summary>
		protected RMethod r_GetPropertyNameId_Int32;
		public virtual RMethod RGetPropertyNameId_Int32
		{
			get
			{
				if(r_GetPropertyNameId_Int32 == null)
				{
					r_GetPropertyNameId_Int32 = new(this, "GetPropertyNameId", 0, typeof(System.Int32));
					r_GetPropertyNameId_Int32.SetBelong(this.instance);
				}
				return r_GetPropertyNameId_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ShaderPropertyType GetPropertyType(Int32)
		/// </summary>
		protected RMethod r_GetPropertyType_Int32;
		public virtual RMethod RGetPropertyType_Int32
		{
			get
			{
				if(r_GetPropertyType_Int32 == null)
				{
					r_GetPropertyType_Int32 = new(this, "GetPropertyType", 0, typeof(System.Int32));
					r_GetPropertyType_Int32.SetBelong(this.instance);
				}
				return r_GetPropertyType_Int32;
			}
		}

		/// <summary>
		/// System.String GetPropertyDescription(Int32)
		/// </summary>
		protected RMethod r_GetPropertyDescription_Int32;
		public virtual RMethod RGetPropertyDescription_Int32
		{
			get
			{
				if(r_GetPropertyDescription_Int32 == null)
				{
					r_GetPropertyDescription_Int32 = new(this, "GetPropertyDescription", 0, typeof(System.Int32));
					r_GetPropertyDescription_Int32.SetBelong(this.instance);
				}
				return r_GetPropertyDescription_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ShaderPropertyFlags GetPropertyFlags(Int32)
		/// </summary>
		protected RMethod r_GetPropertyFlags_Int32;
		public virtual RMethod RGetPropertyFlags_Int32
		{
			get
			{
				if(r_GetPropertyFlags_Int32 == null)
				{
					r_GetPropertyFlags_Int32 = new(this, "GetPropertyFlags", 0, typeof(System.Int32));
					r_GetPropertyFlags_Int32.SetBelong(this.instance);
				}
				return r_GetPropertyFlags_Int32;
			}
		}

		/// <summary>
		/// System.String[] GetPropertyAttributes(Int32)
		/// </summary>
		protected RMethod r_GetPropertyAttributes_Int32;
		public virtual RMethod RGetPropertyAttributes_Int32
		{
			get
			{
				if(r_GetPropertyAttributes_Int32 == null)
				{
					r_GetPropertyAttributes_Int32 = new(this, "GetPropertyAttributes", 0, typeof(System.Int32));
					r_GetPropertyAttributes_Int32.SetBelong(this.instance);
				}
				return r_GetPropertyAttributes_Int32;
			}
		}

		/// <summary>
		/// Single GetPropertyDefaultFloatValue(Int32)
		/// </summary>
		protected RMethod r_GetPropertyDefaultFloatValue_Int32;
		public virtual RMethod RGetPropertyDefaultFloatValue_Int32
		{
			get
			{
				if(r_GetPropertyDefaultFloatValue_Int32 == null)
				{
					r_GetPropertyDefaultFloatValue_Int32 = new(this, "GetPropertyDefaultFloatValue", 0, typeof(System.Int32));
					r_GetPropertyDefaultFloatValue_Int32.SetBelong(this.instance);
				}
				return r_GetPropertyDefaultFloatValue_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 GetPropertyDefaultVectorValue(Int32)
		/// </summary>
		protected RMethod r_GetPropertyDefaultVectorValue_Int32;
		public virtual RMethod RGetPropertyDefaultVectorValue_Int32
		{
			get
			{
				if(r_GetPropertyDefaultVectorValue_Int32 == null)
				{
					r_GetPropertyDefaultVectorValue_Int32 = new(this, "GetPropertyDefaultVectorValue", 0, typeof(System.Int32));
					r_GetPropertyDefaultVectorValue_Int32.SetBelong(this.instance);
				}
				return r_GetPropertyDefaultVectorValue_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetPropertyRangeLimits(Int32)
		/// </summary>
		protected RMethod r_GetPropertyRangeLimits_Int32;
		public virtual RMethod RGetPropertyRangeLimits_Int32
		{
			get
			{
				if(r_GetPropertyRangeLimits_Int32 == null)
				{
					r_GetPropertyRangeLimits_Int32 = new(this, "GetPropertyRangeLimits", 0, typeof(System.Int32));
					r_GetPropertyRangeLimits_Int32.SetBelong(this.instance);
				}
				return r_GetPropertyRangeLimits_Int32;
			}
		}

		/// <summary>
		/// Int32 GetPropertyDefaultIntValue(Int32)
		/// </summary>
		protected RMethod r_GetPropertyDefaultIntValue_Int32;
		public virtual RMethod RGetPropertyDefaultIntValue_Int32
		{
			get
			{
				if(r_GetPropertyDefaultIntValue_Int32 == null)
				{
					r_GetPropertyDefaultIntValue_Int32 = new(this, "GetPropertyDefaultIntValue", 0, typeof(System.Int32));
					r_GetPropertyDefaultIntValue_Int32.SetBelong(this.instance);
				}
				return r_GetPropertyDefaultIntValue_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.TextureDimension GetPropertyTextureDimension(Int32)
		/// </summary>
		protected RMethod r_GetPropertyTextureDimension_Int32;
		public virtual RMethod RGetPropertyTextureDimension_Int32
		{
			get
			{
				if(r_GetPropertyTextureDimension_Int32 == null)
				{
					r_GetPropertyTextureDimension_Int32 = new(this, "GetPropertyTextureDimension", 0, typeof(System.Int32));
					r_GetPropertyTextureDimension_Int32.SetBelong(this.instance);
				}
				return r_GetPropertyTextureDimension_Int32;
			}
		}

		/// <summary>
		/// System.String GetPropertyTextureDefaultName(Int32)
		/// </summary>
		protected RMethod r_GetPropertyTextureDefaultName_Int32;
		public virtual RMethod RGetPropertyTextureDefaultName_Int32
		{
			get
			{
				if(r_GetPropertyTextureDefaultName_Int32 == null)
				{
					r_GetPropertyTextureDefaultName_Int32 = new(this, "GetPropertyTextureDefaultName", 0, typeof(System.Int32));
					r_GetPropertyTextureDefaultName_Int32.SetBelong(this.instance);
				}
				return r_GetPropertyTextureDefaultName_Int32;
			}
		}

		/// <summary>
		/// Boolean FindTextureStack(Int32, System.String ByRef, Int32 ByRef)
		/// </summary>
		protected RMethod r_FindTextureStack_Int32_Out_String_Out_Int32;
		public virtual RMethod RFindTextureStack_Int32_Out_String_Out_Int32
		{
			get
			{
				if(r_FindTextureStack_Int32_Out_String_Out_Int32 == null)
				{
					r_FindTextureStack_Int32_Out_String_Out_Int32 = new(this, "FindTextureStack", 0, typeof(System.Int32), typeof(System.String).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_FindTextureStack_Int32_Out_String_Out_Int32.SetBelong(this.instance);
				}
				return r_FindTextureStack_Int32_Out_String_Out_Int32;
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
		/// Void EnableKeywordFast_Injected(UnityEngine.Rendering.GlobalKeyword ByRef)
		/// </summary>
		protected static RMethod r_EnableKeywordFast_Injected_Ref_GlobalKeyword;
		public static RMethod REnableKeywordFast_Injected_Ref_GlobalKeyword
		{
			get
			{
				if(r_EnableKeywordFast_Injected_Ref_GlobalKeyword == null)
				{
					r_EnableKeywordFast_Injected_Ref_GlobalKeyword = new(typeof(UnityEngine.Shader), "EnableKeywordFast_Injected", 0, typeof(UnityEngine.Rendering.GlobalKeyword).MakeByRefType());
					r_EnableKeywordFast_Injected_Ref_GlobalKeyword.SetBelong(null);
				}
				return r_EnableKeywordFast_Injected_Ref_GlobalKeyword;
			}
		}

		/// <summary>
		/// Void DisableKeywordFast_Injected(UnityEngine.Rendering.GlobalKeyword ByRef)
		/// </summary>
		protected static RMethod r_DisableKeywordFast_Injected_Ref_GlobalKeyword;
		public static RMethod RDisableKeywordFast_Injected_Ref_GlobalKeyword
		{
			get
			{
				if(r_DisableKeywordFast_Injected_Ref_GlobalKeyword == null)
				{
					r_DisableKeywordFast_Injected_Ref_GlobalKeyword = new(typeof(UnityEngine.Shader), "DisableKeywordFast_Injected", 0, typeof(UnityEngine.Rendering.GlobalKeyword).MakeByRefType());
					r_DisableKeywordFast_Injected_Ref_GlobalKeyword.SetBelong(null);
				}
				return r_DisableKeywordFast_Injected_Ref_GlobalKeyword;
			}
		}

		/// <summary>
		/// Void SetKeywordFast_Injected(UnityEngine.Rendering.GlobalKeyword ByRef, Boolean)
		/// </summary>
		protected static RMethod r_SetKeywordFast_Injected_Ref_GlobalKeyword_Boolean;
		public static RMethod RSetKeywordFast_Injected_Ref_GlobalKeyword_Boolean
		{
			get
			{
				if(r_SetKeywordFast_Injected_Ref_GlobalKeyword_Boolean == null)
				{
					r_SetKeywordFast_Injected_Ref_GlobalKeyword_Boolean = new(typeof(UnityEngine.Shader), "SetKeywordFast_Injected", 0, typeof(UnityEngine.Rendering.GlobalKeyword).MakeByRefType(), typeof(System.Boolean));
					r_SetKeywordFast_Injected_Ref_GlobalKeyword_Boolean.SetBelong(null);
				}
				return r_SetKeywordFast_Injected_Ref_GlobalKeyword_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsKeywordEnabledFast_Injected(UnityEngine.Rendering.GlobalKeyword ByRef)
		/// </summary>
		protected static RMethod r_IsKeywordEnabledFast_Injected_Ref_GlobalKeyword;
		public static RMethod RIsKeywordEnabledFast_Injected_Ref_GlobalKeyword
		{
			get
			{
				if(r_IsKeywordEnabledFast_Injected_Ref_GlobalKeyword == null)
				{
					r_IsKeywordEnabledFast_Injected_Ref_GlobalKeyword = new(typeof(UnityEngine.Shader), "IsKeywordEnabledFast_Injected", 0, typeof(UnityEngine.Rendering.GlobalKeyword).MakeByRefType());
					r_IsKeywordEnabledFast_Injected_Ref_GlobalKeyword.SetBelong(null);
				}
				return r_IsKeywordEnabledFast_Injected_Ref_GlobalKeyword;
			}
		}

		/// <summary>
		/// Void SetGlobalVectorImpl_Injected(Int32, UnityEngine.Vector4 ByRef)
		/// </summary>
		protected static RMethod r_SetGlobalVectorImpl_Injected_Int32_Ref_Vector4;
		public static RMethod RSetGlobalVectorImpl_Injected_Int32_Ref_Vector4
		{
			get
			{
				if(r_SetGlobalVectorImpl_Injected_Int32_Ref_Vector4 == null)
				{
					r_SetGlobalVectorImpl_Injected_Int32_Ref_Vector4 = new(typeof(UnityEngine.Shader), "SetGlobalVectorImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeByRefType());
					r_SetGlobalVectorImpl_Injected_Int32_Ref_Vector4.SetBelong(null);
				}
				return r_SetGlobalVectorImpl_Injected_Int32_Ref_Vector4;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrixImpl_Injected(Int32, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected static RMethod r_SetGlobalMatrixImpl_Injected_Int32_Ref_Matrix4x4;
		public static RMethod RSetGlobalMatrixImpl_Injected_Int32_Ref_Matrix4x4
		{
			get
			{
				if(r_SetGlobalMatrixImpl_Injected_Int32_Ref_Matrix4x4 == null)
				{
					r_SetGlobalMatrixImpl_Injected_Int32_Ref_Matrix4x4 = new(typeof(UnityEngine.Shader), "SetGlobalMatrixImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_SetGlobalMatrixImpl_Injected_Int32_Ref_Matrix4x4.SetBelong(null);
				}
				return r_SetGlobalMatrixImpl_Injected_Int32_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Void GetGlobalVectorImpl_Injected(Int32, UnityEngine.Vector4 ByRef)
		/// </summary>
		protected static RMethod r_GetGlobalVectorImpl_Injected_Int32_Out_Vector4;
		public static RMethod RGetGlobalVectorImpl_Injected_Int32_Out_Vector4
		{
			get
			{
				if(r_GetGlobalVectorImpl_Injected_Int32_Out_Vector4 == null)
				{
					r_GetGlobalVectorImpl_Injected_Int32_Out_Vector4 = new(typeof(UnityEngine.Shader), "GetGlobalVectorImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeByRefType());
					r_GetGlobalVectorImpl_Injected_Int32_Out_Vector4.SetBelong(null);
				}
				return r_GetGlobalVectorImpl_Injected_Int32_Out_Vector4;
			}
		}

		/// <summary>
		/// Void GetGlobalMatrixImpl_Injected(Int32, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected static RMethod r_GetGlobalMatrixImpl_Injected_Int32_Out_Matrix4x4;
		public static RMethod RGetGlobalMatrixImpl_Injected_Int32_Out_Matrix4x4
		{
			get
			{
				if(r_GetGlobalMatrixImpl_Injected_Int32_Out_Matrix4x4 == null)
				{
					r_GetGlobalMatrixImpl_Injected_Int32_Out_Matrix4x4 = new(typeof(UnityEngine.Shader), "GetGlobalMatrixImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_GetGlobalMatrixImpl_Injected_Int32_Out_Matrix4x4.SetBelong(null);
				}
				return r_GetGlobalMatrixImpl_Injected_Int32_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void GetPropertyDefaultValue_Injected(UnityEngine.Shader, Int32, UnityEngine.Vector4 ByRef)
		/// </summary>
		protected static RMethod r_GetPropertyDefaultValue_Injected_Shader_Int32_Out_Vector4;
		public static RMethod RGetPropertyDefaultValue_Injected_Shader_Int32_Out_Vector4
		{
			get
			{
				if(r_GetPropertyDefaultValue_Injected_Shader_Int32_Out_Vector4 == null)
				{
					r_GetPropertyDefaultValue_Injected_Shader_Int32_Out_Vector4 = new(typeof(UnityEngine.Shader), "GetPropertyDefaultValue_Injected", 0, typeof(UnityEngine.Shader), typeof(System.Int32), typeof(UnityEngine.Vector4).MakeByRefType());
					r_GetPropertyDefaultValue_Injected_Shader_Int32_Out_Vector4.SetBelong(null);
				}
				return r_GetPropertyDefaultValue_Injected_Shader_Int32_Out_Vector4;
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


        public RShader() : base("UnityEngine.Shader")
        {
        }

        public RShader(System.Object instance) : base("UnityEngine.Shader")
		{
            SetInstance(instance);
		}

        public RShader(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RShader(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static void SetGlobalTexGenMode(System.String @propertyName, UnityEngine.TexGenMode @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName, @mode};
            var ___result = RSetGlobalTexGenMode_String_TexGenMode.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalTextureMatrixName(System.String @propertyName, System.String @matrixName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName, @matrixName};
            var ___result = RSetGlobalTextureMatrixName_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Shader Find(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RFind_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Shader)___result;
        }


        public static UnityEngine.Shader FindBuiltin(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RFindBuiltin_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Shader)___result;
        }


        public static UnityEngine.Rendering.GlobalKeyword[] GetEnabledGlobalKeywords()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnabledGlobalKeywords.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.GlobalKeyword[])___result;
        }


        public static UnityEngine.Rendering.GlobalKeyword[] GetAllGlobalKeywords()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAllGlobalKeywords.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.GlobalKeyword[])___result;
        }


        public static void EnableKeyword(System.String @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = REnableKeyword_String.Invoke(___genericsType, ___parameters);

            
        }


        public static void DisableKeyword(System.String @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RDisableKeyword_String.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsKeywordEnabled(System.String @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RIsKeywordEnabled_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void EnableKeywordFast(UnityEngine.Rendering.GlobalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = REnableKeywordFast_GlobalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public static void DisableKeywordFast(UnityEngine.Rendering.GlobalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RDisableKeywordFast_GlobalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetKeywordFast(UnityEngine.Rendering.GlobalKeyword @keyword, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword, @value};
            var ___result = RSetKeywordFast_GlobalKeyword_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsKeywordEnabledFast(UnityEngine.Rendering.GlobalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RIsKeywordEnabledFast_GlobalKeyword.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void EnableKeyword(in UnityEngine.Rendering.GlobalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = REnableKeyword_In_GlobalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public static void DisableKeyword(in UnityEngine.Rendering.GlobalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RDisableKeyword_In_GlobalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetKeyword(in UnityEngine.Rendering.GlobalKeyword @keyword, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword, @value};
            var ___result = RSetKeyword_In_GlobalKeyword_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsKeywordEnabled(in UnityEngine.Rendering.GlobalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RIsKeywordEnabled_In_GlobalKeyword.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void WarmupAllShaders()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWarmupAllShaders.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 TagToID(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RTagToID_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.String IDToTag(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RIDToTag_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Int32 PropertyToID(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RPropertyToID_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.Shader GetDependency(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetDependency_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Shader)___result;
        }


        public virtual System.Int32 GetPassCountInSubshader(System.Int32 @subshaderIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@subshaderIndex};
            var ___result = RGetPassCountInSubshader_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.Rendering.ShaderTagId FindPassTagValue(System.Int32 @passIndex, UnityEngine.Rendering.ShaderTagId @tagName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@passIndex, @tagName};
            var ___result = RFindPassTagValue_Int32_ShaderTagId.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.ShaderTagId)___result;
        }


        public virtual UnityEngine.Rendering.ShaderTagId FindPassTagValue(System.Int32 @subshaderIndex, System.Int32 @passIndex, UnityEngine.Rendering.ShaderTagId @tagName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@subshaderIndex, @passIndex, @tagName};
            var ___result = RFindPassTagValue_Int32_Int32_ShaderTagId.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.ShaderTagId)___result;
        }


        public virtual UnityEngine.Rendering.ShaderTagId FindSubshaderTagValue(System.Int32 @subshaderIndex, UnityEngine.Rendering.ShaderTagId @tagName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@subshaderIndex, @tagName};
            var ___result = RFindSubshaderTagValue_Int32_ShaderTagId.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.ShaderTagId)___result;
        }


        public virtual System.Int32 Internal_FindPassTagValue(System.Int32 @passIndex, System.Int32 @tagName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@passIndex, @tagName};
            var ___result = RInternal_FindPassTagValue_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Internal_FindPassTagValueInSubShader(System.Int32 @subShaderIndex, System.Int32 @passIndex, System.Int32 @tagName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@subShaderIndex, @passIndex, @tagName};
            var ___result = RInternal_FindPassTagValueInSubShader_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Internal_FindSubshaderTagValue(System.Int32 @subShaderIndex, System.Int32 @tagName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@subShaderIndex, @tagName};
            var ___result = RInternal_FindSubshaderTagValue_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Internal_GetCustomEditorForRenderPipeline(System.String @renderPipelineType, out System.String @customEditor)
        {
			@customEditor = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renderPipelineType, @customEditor};
            var ___result = RInternal_GetCustomEditorForRenderPipeline_String_Out_String.Invoke(___genericsType, ___parameters);
			@customEditor = (System.String)___parameters[1];

            
        }


        public static void SetGlobalIntImpl(System.Int32 @name, System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetGlobalIntImpl_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalFloatImpl(System.Int32 @name, System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetGlobalFloatImpl_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalVectorImpl(System.Int32 @name, UnityEngine.Vector4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetGlobalVectorImpl_Int32_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalMatrixImpl(System.Int32 @name, UnityEngine.Matrix4x4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetGlobalMatrixImpl_Int32_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalTextureImpl(System.Int32 @name, UnityEngine.Texture @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetGlobalTextureImpl_Int32_Texture.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalRenderTextureImpl(System.Int32 @name, UnityEngine.RenderTexture @value, UnityEngine.Rendering.RenderTextureSubElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value, @element};
            var ___result = RSetGlobalRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalBufferImpl(System.Int32 @name, UnityEngine.ComputeBuffer @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetGlobalBufferImpl_Int32_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalGraphicsBufferImpl(System.Int32 @name, UnityEngine.GraphicsBuffer @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetGlobalGraphicsBufferImpl_Int32_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalConstantBufferImpl(System.Int32 @name, UnityEngine.ComputeBuffer @value, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value, @offset, @size};
            var ___result = RSetGlobalConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalConstantGraphicsBufferImpl(System.Int32 @name, UnityEngine.GraphicsBuffer @value, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value, @offset, @size};
            var ___result = RSetGlobalConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 GetGlobalIntImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetGlobalIntImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Single GetGlobalFloatImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetGlobalFloatImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static UnityEngine.Vector4 GetGlobalVectorImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetGlobalVectorImpl_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Matrix4x4 GetGlobalMatrixImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetGlobalMatrixImpl_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4)___result;
        }


        public static UnityEngine.Texture GetGlobalTextureImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetGlobalTextureImpl_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture)___result;
        }


        public static void SetGlobalFloatArrayImpl(System.Int32 @name, System.Single[] @values, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values, @count};
            var ___result = RSetGlobalFloatArrayImpl_Int32_SingleArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalVectorArrayImpl(System.Int32 @name, UnityEngine.Vector4[] @values, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values, @count};
            var ___result = RSetGlobalVectorArrayImpl_Int32_Vector4Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalMatrixArrayImpl(System.Int32 @name, UnityEngine.Matrix4x4[] @values, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values, @count};
            var ___result = RSetGlobalMatrixArrayImpl_Int32_Matrix4x4Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Single[] GetGlobalFloatArrayImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetGlobalFloatArrayImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single[])___result;
        }


        public static UnityEngine.Vector4[] GetGlobalVectorArrayImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetGlobalVectorArrayImpl_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4[])___result;
        }


        public static UnityEngine.Matrix4x4[] GetGlobalMatrixArrayImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetGlobalMatrixArrayImpl_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4[])___result;
        }


        public static System.Int32 GetGlobalFloatArrayCountImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetGlobalFloatArrayCountImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 GetGlobalVectorArrayCountImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetGlobalVectorArrayCountImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 GetGlobalMatrixArrayCountImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetGlobalMatrixArrayCountImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static void ExtractGlobalFloatArrayImpl(System.Int32 @name, System.Single[] @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RExtractGlobalFloatArrayImpl_Int32_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public static void ExtractGlobalVectorArrayImpl(System.Int32 @name, UnityEngine.Vector4[] @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RExtractGlobalVectorArrayImpl_Int32_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public static void ExtractGlobalMatrixArrayImpl(System.Int32 @name, UnityEngine.Matrix4x4[] @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RExtractGlobalMatrixArrayImpl_Int32_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalFloatArray(System.Int32 @name, System.Single[] @values, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values, @count};
            var ___result = RSetGlobalFloatArray_Int32_SingleArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalVectorArray(System.Int32 @name, UnityEngine.Vector4[] @values, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values, @count};
            var ___result = RSetGlobalVectorArray_Int32_Vector4Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalMatrixArray(System.Int32 @name, UnityEngine.Matrix4x4[] @values, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values, @count};
            var ___result = RSetGlobalMatrixArray_Int32_Matrix4x4Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void ExtractGlobalFloatArray(System.Int32 @name, System.Collections.Generic.List<System.Single> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RExtractGlobalFloatArray_Int32_List_d_Single_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void ExtractGlobalVectorArray(System.Int32 @name, System.Collections.Generic.List<UnityEngine.Vector4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RExtractGlobalVectorArray_Int32_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void ExtractGlobalMatrixArray(System.Int32 @name, System.Collections.Generic.List<UnityEngine.Matrix4x4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RExtractGlobalMatrixArray_Int32_List_d_Matrix4x4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalInt(System.String @name, System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetGlobalInt_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalInt(System.Int32 @nameID, System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetGlobalInt_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalFloat(System.String @name, System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetGlobalFloat_String_Single.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalFloat(System.Int32 @nameID, System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetGlobalFloat_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalInteger(System.String @name, System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetGlobalInteger_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalInteger(System.Int32 @nameID, System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetGlobalInteger_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalVector(System.String @name, UnityEngine.Vector4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetGlobalVector_String_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalVector(System.Int32 @nameID, UnityEngine.Vector4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetGlobalVector_Int32_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalColor(System.String @name, UnityEngine.Color @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetGlobalColor_String_Color.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalColor(System.Int32 @nameID, UnityEngine.Color @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetGlobalColor_Int32_Color.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalMatrix(System.String @name, UnityEngine.Matrix4x4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetGlobalMatrix_String_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalMatrix(System.Int32 @nameID, UnityEngine.Matrix4x4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetGlobalMatrix_Int32_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalTexture(System.String @name, UnityEngine.Texture @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetGlobalTexture_String_Texture.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalTexture(System.Int32 @nameID, UnityEngine.Texture @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetGlobalTexture_Int32_Texture.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalTexture(System.String @name, UnityEngine.RenderTexture @value, UnityEngine.Rendering.RenderTextureSubElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value, @element};
            var ___result = RSetGlobalTexture_String_RenderTexture_RenderTextureSubElement.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalTexture(System.Int32 @nameID, UnityEngine.RenderTexture @value, UnityEngine.Rendering.RenderTextureSubElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value, @element};
            var ___result = RSetGlobalTexture_Int32_RenderTexture_RenderTextureSubElement.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalBuffer(System.String @name, UnityEngine.ComputeBuffer @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetGlobalBuffer_String_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalBuffer(System.Int32 @nameID, UnityEngine.ComputeBuffer @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetGlobalBuffer_Int32_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalBuffer(System.String @name, UnityEngine.GraphicsBuffer @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetGlobalBuffer_String_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalBuffer(System.Int32 @nameID, UnityEngine.GraphicsBuffer @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RSetGlobalBuffer_Int32_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalConstantBuffer(System.String @name, UnityEngine.ComputeBuffer @value, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value, @offset, @size};
            var ___result = RSetGlobalConstantBuffer_String_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalConstantBuffer(System.Int32 @nameID, UnityEngine.ComputeBuffer @value, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value, @offset, @size};
            var ___result = RSetGlobalConstantBuffer_Int32_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalConstantBuffer(System.String @name, UnityEngine.GraphicsBuffer @value, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value, @offset, @size};
            var ___result = RSetGlobalConstantBuffer_String_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalConstantBuffer(System.Int32 @nameID, UnityEngine.GraphicsBuffer @value, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value, @offset, @size};
            var ___result = RSetGlobalConstantBuffer_Int32_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalFloatArray(System.String @name, System.Collections.Generic.List<System.Single> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RSetGlobalFloatArray_String_List_d_Single_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalFloatArray(System.Int32 @nameID, System.Collections.Generic.List<System.Single> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetGlobalFloatArray_Int32_List_d_Single_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalFloatArray(System.String @name, System.Single[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RSetGlobalFloatArray_String_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalFloatArray(System.Int32 @nameID, System.Single[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetGlobalFloatArray_Int32_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalVectorArray(System.String @name, System.Collections.Generic.List<UnityEngine.Vector4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RSetGlobalVectorArray_String_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalVectorArray(System.Int32 @nameID, System.Collections.Generic.List<UnityEngine.Vector4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetGlobalVectorArray_Int32_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalVectorArray(System.String @name, UnityEngine.Vector4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RSetGlobalVectorArray_String_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalVectorArray(System.Int32 @nameID, UnityEngine.Vector4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetGlobalVectorArray_Int32_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalMatrixArray(System.String @name, System.Collections.Generic.List<UnityEngine.Matrix4x4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RSetGlobalMatrixArray_String_List_d_Matrix4x4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalMatrixArray(System.Int32 @nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalMatrixArray(System.String @name, UnityEngine.Matrix4x4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RSetGlobalMatrixArray_String_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalMatrixArray(System.Int32 @nameID, UnityEngine.Matrix4x4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetGlobalMatrixArray_Int32_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 GetGlobalInt(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetGlobalInt_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 GetGlobalInt(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RGetGlobalInt_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Single GetGlobalFloat(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetGlobalFloat_String.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Single GetGlobalFloat(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RGetGlobalFloat_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Int32 GetGlobalInteger(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetGlobalInteger_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 GetGlobalInteger(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RGetGlobalInteger_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static UnityEngine.Vector4 GetGlobalVector(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetGlobalVector_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Vector4 GetGlobalVector(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RGetGlobalVector_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Color GetGlobalColor(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetGlobalColor_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public static UnityEngine.Color GetGlobalColor(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RGetGlobalColor_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public static UnityEngine.Matrix4x4 GetGlobalMatrix(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetGlobalMatrix_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4)___result;
        }


        public static UnityEngine.Matrix4x4 GetGlobalMatrix(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RGetGlobalMatrix_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4)___result;
        }


        public static UnityEngine.Texture GetGlobalTexture(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetGlobalTexture_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture)___result;
        }


        public static UnityEngine.Texture GetGlobalTexture(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RGetGlobalTexture_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture)___result;
        }


        public static System.Single[] GetGlobalFloatArray(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetGlobalFloatArray_String.Invoke(___genericsType, ___parameters);

            return (System.Single[])___result;
        }


        public static System.Single[] GetGlobalFloatArray(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RGetGlobalFloatArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single[])___result;
        }


        public static UnityEngine.Vector4[] GetGlobalVectorArray(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetGlobalVectorArray_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4[])___result;
        }


        public static UnityEngine.Vector4[] GetGlobalVectorArray(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RGetGlobalVectorArray_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4[])___result;
        }


        public static UnityEngine.Matrix4x4[] GetGlobalMatrixArray(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetGlobalMatrixArray_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4[])___result;
        }


        public static UnityEngine.Matrix4x4[] GetGlobalMatrixArray(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RGetGlobalMatrixArray_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4[])___result;
        }


        public static void GetGlobalFloatArray(System.String @name, System.Collections.Generic.List<System.Single> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RGetGlobalFloatArray_String_List_d_Single_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void GetGlobalFloatArray(System.Int32 @nameID, System.Collections.Generic.List<System.Single> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RGetGlobalFloatArray_Int32_List_d_Single_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void GetGlobalVectorArray(System.String @name, System.Collections.Generic.List<UnityEngine.Vector4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RGetGlobalVectorArray_String_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void GetGlobalVectorArray(System.Int32 @nameID, System.Collections.Generic.List<UnityEngine.Vector4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RGetGlobalVectorArray_Int32_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void GetGlobalMatrixArray(System.String @name, System.Collections.Generic.List<UnityEngine.Matrix4x4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RGetGlobalMatrixArray_String_List_d_Matrix4x4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void GetGlobalMatrixArray(System.Int32 @nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RGetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static System.String GetPropertyName(UnityEngine.Shader @shader, System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader, @propertyIndex};
            var ___result = RGetPropertyName_Shader_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Int32 GetPropertyNameId(UnityEngine.Shader @shader, System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader, @propertyIndex};
            var ___result = RGetPropertyNameId_Shader_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static UnityEngine.Rendering.ShaderPropertyType GetPropertyType(UnityEngine.Shader @shader, System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader, @propertyIndex};
            var ___result = RGetPropertyType_Shader_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.ShaderPropertyType)___result;
        }


        public static System.String GetPropertyDescription(UnityEngine.Shader @shader, System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader, @propertyIndex};
            var ___result = RGetPropertyDescription_Shader_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static UnityEngine.Rendering.ShaderPropertyFlags GetPropertyFlags(UnityEngine.Shader @shader, System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader, @propertyIndex};
            var ___result = RGetPropertyFlags_Shader_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.ShaderPropertyFlags)___result;
        }


        public static System.String[] GetPropertyAttributes(UnityEngine.Shader @shader, System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader, @propertyIndex};
            var ___result = RGetPropertyAttributes_Shader_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public static System.Int32 GetPropertyDefaultIntValue(UnityEngine.Shader @shader, System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader, @propertyIndex};
            var ___result = RGetPropertyDefaultIntValue_Shader_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static UnityEngine.Vector4 GetPropertyDefaultValue(UnityEngine.Shader @shader, System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader, @propertyIndex};
            var ___result = RGetPropertyDefaultValue_Shader_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Rendering.TextureDimension GetPropertyTextureDimension(UnityEngine.Shader @shader, System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader, @propertyIndex};
            var ___result = RGetPropertyTextureDimension_Shader_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.TextureDimension)___result;
        }


        public static System.String GetPropertyTextureDefaultName(UnityEngine.Shader @shader, System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader, @propertyIndex};
            var ___result = RGetPropertyTextureDefaultName_Shader_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Boolean FindTextureStackImpl(UnityEngine.Shader @s, System.Int32 @propertyIdx, out System.String @stackName, out System.Int32 @layerIndex)
        {
			@stackName = default;
			@layerIndex = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @propertyIdx, @stackName, @layerIndex};
            var ___result = RFindTextureStackImpl_Shader_Int32_Out_String_Out_Int32.Invoke(___genericsType, ___parameters);
			@stackName = (System.String)___parameters[2];
			@layerIndex = (System.Int32)___parameters[3];

            return (System.Boolean)___result;
        }


        public static void CheckPropertyIndex(UnityEngine.Shader @s, System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @propertyIndex};
            var ___result = RCheckPropertyIndex_Shader_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetPropertyCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPropertyCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 FindPropertyIndex(System.String @propertyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName};
            var ___result = RFindPropertyIndex_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String GetPropertyName(System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyIndex};
            var ___result = RGetPropertyName_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 GetPropertyNameId(System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyIndex};
            var ___result = RGetPropertyNameId_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.Rendering.ShaderPropertyType GetPropertyType(System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyIndex};
            var ___result = RGetPropertyType_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.ShaderPropertyType)___result;
        }


        public virtual System.String GetPropertyDescription(System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyIndex};
            var ___result = RGetPropertyDescription_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual UnityEngine.Rendering.ShaderPropertyFlags GetPropertyFlags(System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyIndex};
            var ___result = RGetPropertyFlags_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.ShaderPropertyFlags)___result;
        }


        public virtual System.String[] GetPropertyAttributes(System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyIndex};
            var ___result = RGetPropertyAttributes_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.Single GetPropertyDefaultFloatValue(System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyIndex};
            var ___result = RGetPropertyDefaultFloatValue_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual UnityEngine.Vector4 GetPropertyDefaultVectorValue(System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyIndex};
            var ___result = RGetPropertyDefaultVectorValue_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public virtual UnityEngine.Vector2 GetPropertyRangeLimits(System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyIndex};
            var ___result = RGetPropertyRangeLimits_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual System.Int32 GetPropertyDefaultIntValue(System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyIndex};
            var ___result = RGetPropertyDefaultIntValue_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.Rendering.TextureDimension GetPropertyTextureDimension(System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyIndex};
            var ___result = RGetPropertyTextureDimension_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.TextureDimension)___result;
        }


        public virtual System.String GetPropertyTextureDefaultName(System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyIndex};
            var ___result = RGetPropertyTextureDefaultName_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean FindTextureStack(System.Int32 @propertyIndex, out System.String @stackName, out System.Int32 @layerIndex)
        {
			@stackName = default;
			@layerIndex = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyIndex, @stackName, @layerIndex};
            var ___result = RFindTextureStack_Int32_Out_String_Out_Int32.Invoke(___genericsType, ___parameters);
			@stackName = (System.String)___parameters[1];
			@layerIndex = (System.Int32)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual void get_keywordSpace_Injected(out UnityEngine.Rendering.LocalKeywordSpace @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_keywordSpace_Injected_Out_LocalKeywordSpace.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Rendering.LocalKeywordSpace)___parameters[0];

            
        }


        public static void EnableKeywordFast_Injected(ref UnityEngine.Rendering.GlobalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = REnableKeywordFast_Injected_Ref_GlobalKeyword.Invoke(___genericsType, ___parameters);
			@keyword = (UnityEngine.Rendering.GlobalKeyword)___parameters[0];

            
        }


        public static void DisableKeywordFast_Injected(ref UnityEngine.Rendering.GlobalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RDisableKeywordFast_Injected_Ref_GlobalKeyword.Invoke(___genericsType, ___parameters);
			@keyword = (UnityEngine.Rendering.GlobalKeyword)___parameters[0];

            
        }


        public static void SetKeywordFast_Injected(ref UnityEngine.Rendering.GlobalKeyword @keyword, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword, @value};
            var ___result = RSetKeywordFast_Injected_Ref_GlobalKeyword_Boolean.Invoke(___genericsType, ___parameters);
			@keyword = (UnityEngine.Rendering.GlobalKeyword)___parameters[0];

            
        }


        public static System.Boolean IsKeywordEnabledFast_Injected(ref UnityEngine.Rendering.GlobalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RIsKeywordEnabledFast_Injected_Ref_GlobalKeyword.Invoke(___genericsType, ___parameters);
			@keyword = (UnityEngine.Rendering.GlobalKeyword)___parameters[0];

            return (System.Boolean)___result;
        }


        public static void SetGlobalVectorImpl_Injected(System.Int32 @name, ref UnityEngine.Vector4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetGlobalVectorImpl_Injected_Int32_Ref_Vector4.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Vector4)___parameters[1];

            
        }


        public static void SetGlobalMatrixImpl_Injected(System.Int32 @name, ref UnityEngine.Matrix4x4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetGlobalMatrixImpl_Injected_Int32_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Matrix4x4)___parameters[1];

            
        }


        public static void GetGlobalVectorImpl_Injected(System.Int32 @name, out UnityEngine.Vector4 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @ret};
            var ___result = RGetGlobalVectorImpl_Injected_Int32_Out_Vector4.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector4)___parameters[1];

            
        }


        public static void GetGlobalMatrixImpl_Injected(System.Int32 @name, out UnityEngine.Matrix4x4 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @ret};
            var ___result = RGetGlobalMatrixImpl_Injected_Int32_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Matrix4x4)___parameters[1];

            
        }


        public static void GetPropertyDefaultValue_Injected(UnityEngine.Shader @shader, System.Int32 @propertyIndex, out UnityEngine.Vector4 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader, @propertyIndex, @ret};
            var ___result = RGetPropertyDefaultValue_Injected_Shader_Int32_Out_Vector4.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector4)___parameters[2];

            
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


        public virtual System.Boolean Equals(System.Object @other)
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
