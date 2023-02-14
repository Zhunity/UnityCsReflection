
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Shader
	/// </summary>
    public partial class RShader : RMember //
    {

		/// <summary>
		/// UnityEngine.Rendering.ShaderHardwareTier globalShaderHardwareTier
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RShaderHardwareTier r_PglobalShaderHardwareTier;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RShaderHardwareTier RPglobalShaderHardwareTier
		{
			get
			{
				if(r_PglobalShaderHardwareTier == null)
				{
					r_PglobalShaderHardwareTier = new(typeof(UnityEngine.Shader), "globalShaderHardwareTier", -1);
					r_PglobalShaderHardwareTier.SetBelong(null);
				}
				return r_PglobalShaderHardwareTier;
			}
		}

		/// <summary>
		/// Int32 maximumChunksOverride
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_PmaximumChunksOverride;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RPmaximumChunksOverride
		{
			get
			{
				if(r_PmaximumChunksOverride == null)
				{
					r_PmaximumChunksOverride = new(typeof(UnityEngine.Shader), "maximumChunksOverride", -1);
					r_PmaximumChunksOverride.SetBelong(null);
				}
				return r_PmaximumChunksOverride;
			}
		}

		/// <summary>
		/// Int32 maximumLOD
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PmaximumLOD;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPmaximumLOD
		{
			get
			{
				if(r_PmaximumLOD == null)
				{
					r_PmaximumLOD = new(this, "maximumLOD", -1);
					r_PmaximumLOD.SetBelong(this.instance);
				}
				return r_PmaximumLOD;
			}
		}

		/// <summary>
		/// Int32 globalMaximumLOD
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_PglobalMaximumLOD;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RPglobalMaximumLOD
		{
			get
			{
				if(r_PglobalMaximumLOD == null)
				{
					r_PglobalMaximumLOD = new(typeof(UnityEngine.Shader), "globalMaximumLOD", -1);
					r_PglobalMaximumLOD.SetBelong(null);
				}
				return r_PglobalMaximumLOD;
			}
		}

		/// <summary>
		/// Boolean isSupported
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisSupported;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisSupported
		{
			get
			{
				if(r_PisSupported == null)
				{
					r_PisSupported = new(this, "isSupported", -1);
					r_PisSupported.SetBelong(this.instance);
				}
				return r_PisSupported;
			}
		}

		/// <summary>
		/// System.String globalRenderPipeline
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_PglobalRenderPipeline;
		public static Hvak.Editor.Refleaction.RSystem.RString RPglobalRenderPipeline
		{
			get
			{
				if(r_PglobalRenderPipeline == null)
				{
					r_PglobalRenderPipeline = new(typeof(UnityEngine.Shader), "globalRenderPipeline", -1);
					r_PglobalRenderPipeline.SetBelong(null);
				}
				return r_PglobalRenderPipeline;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.GlobalKeyword[] enabledGlobalKeywords
		/// </summary>
		protected static Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RRendering.RGlobalKeyword> r_PenabledGlobalKeywords;
		public static Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RRendering.RGlobalKeyword> RPenabledGlobalKeywords
		{
			get
			{
				if(r_PenabledGlobalKeywords == null)
				{
					r_PenabledGlobalKeywords = new(typeof(UnityEngine.Shader), "enabledGlobalKeywords", -1);
					r_PenabledGlobalKeywords.SetBelong(null);
				}
				return r_PenabledGlobalKeywords;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.GlobalKeyword[] globalKeywords
		/// </summary>
		protected static Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RRendering.RGlobalKeyword> r_PglobalKeywords;
		public static Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RRendering.RGlobalKeyword> RPglobalKeywords
		{
			get
			{
				if(r_PglobalKeywords == null)
				{
					r_PglobalKeywords = new(typeof(UnityEngine.Shader), "globalKeywords", -1);
					r_PglobalKeywords.SetBelong(null);
				}
				return r_PglobalKeywords;
			}
		}

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
					r_PrenderQueue.SetBelong(this.instance);
				}
				return r_PrenderQueue;
			}
		}

		/// <summary>
		/// UnityEngine.DisableBatchingType disableBatching
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RDisableBatchingType r_PdisableBatching;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RDisableBatchingType RPdisableBatching
		{
			get
			{
				if(r_PdisableBatching == null)
				{
					r_PdisableBatching = new(this, "disableBatching", -1);
					r_PdisableBatching.SetBelong(this.instance);
				}
				return r_PdisableBatching;
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
					r_PpassCount.SetBelong(this.instance);
				}
				return r_PpassCount;
			}
		}

		/// <summary>
		/// Int32 subshaderCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PsubshaderCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPsubshaderCount
		{
			get
			{
				if(r_PsubshaderCount == null)
				{
					r_PsubshaderCount = new(this, "subshaderCount", -1);
					r_PsubshaderCount.SetBelong(this.instance);
				}
				return r_PsubshaderCount;
			}
		}

		/// <summary>
		/// System.String customEditor
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PcustomEditor;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPcustomEditor
		{
			get
			{
				if(r_PcustomEditor == null)
				{
					r_PcustomEditor = new(this, "customEditor", -1);
					r_PcustomEditor.SetBelong(this.instance);
				}
				return r_PcustomEditor;
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
		/// Void SetGlobalTexGenMode(System.String, UnityEngine.TexGenMode)
		/// </summary>
		protected static RMethod r_MSetGlobalTexGenMode_String_TexGenMode;
		public static RMethod RMSetGlobalTexGenMode_String_TexGenMode
		{
			get
			{
				if(r_MSetGlobalTexGenMode_String_TexGenMode == null)
				{
					r_MSetGlobalTexGenMode_String_TexGenMode = new(typeof(UnityEngine.Shader), "SetGlobalTexGenMode", 0, typeof(System.String), typeof(UnityEngine.TexGenMode));
					r_MSetGlobalTexGenMode_String_TexGenMode.SetBelong(null);
				}
				return r_MSetGlobalTexGenMode_String_TexGenMode;
			}
		}

		/// <summary>
		/// Void SetGlobalTextureMatrixName(System.String, System.String)
		/// </summary>
		protected static RMethod r_MSetGlobalTextureMatrixName_String_String;
		public static RMethod RMSetGlobalTextureMatrixName_String_String
		{
			get
			{
				if(r_MSetGlobalTextureMatrixName_String_String == null)
				{
					r_MSetGlobalTextureMatrixName_String_String = new(typeof(UnityEngine.Shader), "SetGlobalTextureMatrixName", 0, typeof(System.String), typeof(System.String));
					r_MSetGlobalTextureMatrixName_String_String.SetBelong(null);
				}
				return r_MSetGlobalTextureMatrixName_String_String;
			}
		}

		/// <summary>
		/// UnityEngine.Shader Find(System.String)
		/// </summary>
		protected static RMethod r_MFind_String;
		public static RMethod RMFind_String
		{
			get
			{
				if(r_MFind_String == null)
				{
					r_MFind_String = new(typeof(UnityEngine.Shader), "Find", 0, typeof(System.String));
					r_MFind_String.SetBelong(null);
				}
				return r_MFind_String;
			}
		}

		/// <summary>
		/// UnityEngine.Shader FindBuiltin(System.String)
		/// </summary>
		protected static RMethod r_MFindBuiltin_String;
		public static RMethod RMFindBuiltin_String
		{
			get
			{
				if(r_MFindBuiltin_String == null)
				{
					r_MFindBuiltin_String = new(typeof(UnityEngine.Shader), "FindBuiltin", 0, typeof(System.String));
					r_MFindBuiltin_String.SetBelong(null);
				}
				return r_MFindBuiltin_String;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.GlobalKeyword[] GetEnabledGlobalKeywords()
		/// </summary>
		protected static RMethod r_MGetEnabledGlobalKeywords;
		public static RMethod RMGetEnabledGlobalKeywords
		{
			get
			{
				if(r_MGetEnabledGlobalKeywords == null)
				{
					r_MGetEnabledGlobalKeywords = new(typeof(UnityEngine.Shader), "GetEnabledGlobalKeywords", 0);
					r_MGetEnabledGlobalKeywords.SetBelong(null);
				}
				return r_MGetEnabledGlobalKeywords;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.GlobalKeyword[] GetAllGlobalKeywords()
		/// </summary>
		protected static RMethod r_MGetAllGlobalKeywords;
		public static RMethod RMGetAllGlobalKeywords
		{
			get
			{
				if(r_MGetAllGlobalKeywords == null)
				{
					r_MGetAllGlobalKeywords = new(typeof(UnityEngine.Shader), "GetAllGlobalKeywords", 0);
					r_MGetAllGlobalKeywords.SetBelong(null);
				}
				return r_MGetAllGlobalKeywords;
			}
		}

		/// <summary>
		/// Void EnableKeyword(System.String)
		/// </summary>
		protected static RMethod r_MEnableKeyword_String;
		public static RMethod RMEnableKeyword_String
		{
			get
			{
				if(r_MEnableKeyword_String == null)
				{
					r_MEnableKeyword_String = new(typeof(UnityEngine.Shader), "EnableKeyword", 0, typeof(System.String));
					r_MEnableKeyword_String.SetBelong(null);
				}
				return r_MEnableKeyword_String;
			}
		}

		/// <summary>
		/// Void DisableKeyword(System.String)
		/// </summary>
		protected static RMethod r_MDisableKeyword_String;
		public static RMethod RMDisableKeyword_String
		{
			get
			{
				if(r_MDisableKeyword_String == null)
				{
					r_MDisableKeyword_String = new(typeof(UnityEngine.Shader), "DisableKeyword", 0, typeof(System.String));
					r_MDisableKeyword_String.SetBelong(null);
				}
				return r_MDisableKeyword_String;
			}
		}

		/// <summary>
		/// Boolean IsKeywordEnabled(System.String)
		/// </summary>
		protected static RMethod r_MIsKeywordEnabled_String;
		public static RMethod RMIsKeywordEnabled_String
		{
			get
			{
				if(r_MIsKeywordEnabled_String == null)
				{
					r_MIsKeywordEnabled_String = new(typeof(UnityEngine.Shader), "IsKeywordEnabled", 0, typeof(System.String));
					r_MIsKeywordEnabled_String.SetBelong(null);
				}
				return r_MIsKeywordEnabled_String;
			}
		}

		/// <summary>
		/// Void EnableKeywordFast(UnityEngine.Rendering.GlobalKeyword)
		/// </summary>
		protected static RMethod r_MEnableKeywordFast_GlobalKeyword;
		public static RMethod RMEnableKeywordFast_GlobalKeyword
		{
			get
			{
				if(r_MEnableKeywordFast_GlobalKeyword == null)
				{
					r_MEnableKeywordFast_GlobalKeyword = new(typeof(UnityEngine.Shader), "EnableKeywordFast", 0, typeof(UnityEngine.Rendering.GlobalKeyword));
					r_MEnableKeywordFast_GlobalKeyword.SetBelong(null);
				}
				return r_MEnableKeywordFast_GlobalKeyword;
			}
		}

		/// <summary>
		/// Void DisableKeywordFast(UnityEngine.Rendering.GlobalKeyword)
		/// </summary>
		protected static RMethod r_MDisableKeywordFast_GlobalKeyword;
		public static RMethod RMDisableKeywordFast_GlobalKeyword
		{
			get
			{
				if(r_MDisableKeywordFast_GlobalKeyword == null)
				{
					r_MDisableKeywordFast_GlobalKeyword = new(typeof(UnityEngine.Shader), "DisableKeywordFast", 0, typeof(UnityEngine.Rendering.GlobalKeyword));
					r_MDisableKeywordFast_GlobalKeyword.SetBelong(null);
				}
				return r_MDisableKeywordFast_GlobalKeyword;
			}
		}

		/// <summary>
		/// Void SetKeywordFast(UnityEngine.Rendering.GlobalKeyword, Boolean)
		/// </summary>
		protected static RMethod r_MSetKeywordFast_GlobalKeyword_Boolean;
		public static RMethod RMSetKeywordFast_GlobalKeyword_Boolean
		{
			get
			{
				if(r_MSetKeywordFast_GlobalKeyword_Boolean == null)
				{
					r_MSetKeywordFast_GlobalKeyword_Boolean = new(typeof(UnityEngine.Shader), "SetKeywordFast", 0, typeof(UnityEngine.Rendering.GlobalKeyword), typeof(System.Boolean));
					r_MSetKeywordFast_GlobalKeyword_Boolean.SetBelong(null);
				}
				return r_MSetKeywordFast_GlobalKeyword_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsKeywordEnabledFast(UnityEngine.Rendering.GlobalKeyword)
		/// </summary>
		protected static RMethod r_MIsKeywordEnabledFast_GlobalKeyword;
		public static RMethod RMIsKeywordEnabledFast_GlobalKeyword
		{
			get
			{
				if(r_MIsKeywordEnabledFast_GlobalKeyword == null)
				{
					r_MIsKeywordEnabledFast_GlobalKeyword = new(typeof(UnityEngine.Shader), "IsKeywordEnabledFast", 0, typeof(UnityEngine.Rendering.GlobalKeyword));
					r_MIsKeywordEnabledFast_GlobalKeyword.SetBelong(null);
				}
				return r_MIsKeywordEnabledFast_GlobalKeyword;
			}
		}

		/// <summary>
		/// Void EnableKeyword(UnityEngine.Rendering.GlobalKeyword ByRef)
		/// </summary>
		protected static RMethod r_MEnableKeyword_In_GlobalKeyword;
		public static RMethod RMEnableKeyword_In_GlobalKeyword
		{
			get
			{
				if(r_MEnableKeyword_In_GlobalKeyword == null)
				{
					r_MEnableKeyword_In_GlobalKeyword = new(typeof(UnityEngine.Shader), "EnableKeyword", 0, typeof(UnityEngine.Rendering.GlobalKeyword).MakeByRefType());
					r_MEnableKeyword_In_GlobalKeyword.SetBelong(null);
				}
				return r_MEnableKeyword_In_GlobalKeyword;
			}
		}

		/// <summary>
		/// Void DisableKeyword(UnityEngine.Rendering.GlobalKeyword ByRef)
		/// </summary>
		protected static RMethod r_MDisableKeyword_In_GlobalKeyword;
		public static RMethod RMDisableKeyword_In_GlobalKeyword
		{
			get
			{
				if(r_MDisableKeyword_In_GlobalKeyword == null)
				{
					r_MDisableKeyword_In_GlobalKeyword = new(typeof(UnityEngine.Shader), "DisableKeyword", 0, typeof(UnityEngine.Rendering.GlobalKeyword).MakeByRefType());
					r_MDisableKeyword_In_GlobalKeyword.SetBelong(null);
				}
				return r_MDisableKeyword_In_GlobalKeyword;
			}
		}

		/// <summary>
		/// Void SetKeyword(UnityEngine.Rendering.GlobalKeyword ByRef, Boolean)
		/// </summary>
		protected static RMethod r_MSetKeyword_In_GlobalKeyword_Boolean;
		public static RMethod RMSetKeyword_In_GlobalKeyword_Boolean
		{
			get
			{
				if(r_MSetKeyword_In_GlobalKeyword_Boolean == null)
				{
					r_MSetKeyword_In_GlobalKeyword_Boolean = new(typeof(UnityEngine.Shader), "SetKeyword", 0, typeof(UnityEngine.Rendering.GlobalKeyword).MakeByRefType(), typeof(System.Boolean));
					r_MSetKeyword_In_GlobalKeyword_Boolean.SetBelong(null);
				}
				return r_MSetKeyword_In_GlobalKeyword_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsKeywordEnabled(UnityEngine.Rendering.GlobalKeyword ByRef)
		/// </summary>
		protected static RMethod r_MIsKeywordEnabled_In_GlobalKeyword;
		public static RMethod RMIsKeywordEnabled_In_GlobalKeyword
		{
			get
			{
				if(r_MIsKeywordEnabled_In_GlobalKeyword == null)
				{
					r_MIsKeywordEnabled_In_GlobalKeyword = new(typeof(UnityEngine.Shader), "IsKeywordEnabled", 0, typeof(UnityEngine.Rendering.GlobalKeyword).MakeByRefType());
					r_MIsKeywordEnabled_In_GlobalKeyword.SetBelong(null);
				}
				return r_MIsKeywordEnabled_In_GlobalKeyword;
			}
		}

		/// <summary>
		/// Void WarmupAllShaders()
		/// </summary>
		protected static RMethod r_MWarmupAllShaders;
		public static RMethod RMWarmupAllShaders
		{
			get
			{
				if(r_MWarmupAllShaders == null)
				{
					r_MWarmupAllShaders = new(typeof(UnityEngine.Shader), "WarmupAllShaders", 0);
					r_MWarmupAllShaders.SetBelong(null);
				}
				return r_MWarmupAllShaders;
			}
		}

		/// <summary>
		/// Int32 TagToID(System.String)
		/// </summary>
		protected static RMethod r_MTagToID_String;
		public static RMethod RMTagToID_String
		{
			get
			{
				if(r_MTagToID_String == null)
				{
					r_MTagToID_String = new(typeof(UnityEngine.Shader), "TagToID", 0, typeof(System.String));
					r_MTagToID_String.SetBelong(null);
				}
				return r_MTagToID_String;
			}
		}

		/// <summary>
		/// System.String IDToTag(Int32)
		/// </summary>
		protected static RMethod r_MIDToTag_Int32;
		public static RMethod RMIDToTag_Int32
		{
			get
			{
				if(r_MIDToTag_Int32 == null)
				{
					r_MIDToTag_Int32 = new(typeof(UnityEngine.Shader), "IDToTag", 0, typeof(System.Int32));
					r_MIDToTag_Int32.SetBelong(null);
				}
				return r_MIDToTag_Int32;
			}
		}

		/// <summary>
		/// Int32 PropertyToID(System.String)
		/// </summary>
		protected static RMethod r_MPropertyToID_String;
		public static RMethod RMPropertyToID_String
		{
			get
			{
				if(r_MPropertyToID_String == null)
				{
					r_MPropertyToID_String = new(typeof(UnityEngine.Shader), "PropertyToID", 0, typeof(System.String));
					r_MPropertyToID_String.SetBelong(null);
				}
				return r_MPropertyToID_String;
			}
		}

		/// <summary>
		/// UnityEngine.Shader GetDependency(System.String)
		/// </summary>
		protected RMethod r_MGetDependency_String;
		public virtual RMethod RMGetDependency_String
		{
			get
			{
				if(r_MGetDependency_String == null)
				{
					r_MGetDependency_String = new(this, "GetDependency", 0, typeof(System.String));
					r_MGetDependency_String.SetBelong(this.instance);
				}
				return r_MGetDependency_String;
			}
		}

		/// <summary>
		/// Int32 GetPassCountInSubshader(Int32)
		/// </summary>
		protected RMethod r_MGetPassCountInSubshader_Int32;
		public virtual RMethod RMGetPassCountInSubshader_Int32
		{
			get
			{
				if(r_MGetPassCountInSubshader_Int32 == null)
				{
					r_MGetPassCountInSubshader_Int32 = new(this, "GetPassCountInSubshader", 0, typeof(System.Int32));
					r_MGetPassCountInSubshader_Int32.SetBelong(this.instance);
				}
				return r_MGetPassCountInSubshader_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ShaderTagId FindPassTagValue(Int32, UnityEngine.Rendering.ShaderTagId)
		/// </summary>
		protected RMethod r_MFindPassTagValue_Int32_ShaderTagId;
		public virtual RMethod RMFindPassTagValue_Int32_ShaderTagId
		{
			get
			{
				if(r_MFindPassTagValue_Int32_ShaderTagId == null)
				{
					r_MFindPassTagValue_Int32_ShaderTagId = new(this, "FindPassTagValue", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.ShaderTagId));
					r_MFindPassTagValue_Int32_ShaderTagId.SetBelong(this.instance);
				}
				return r_MFindPassTagValue_Int32_ShaderTagId;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ShaderTagId FindPassTagValue(Int32, Int32, UnityEngine.Rendering.ShaderTagId)
		/// </summary>
		protected RMethod r_MFindPassTagValue_Int32_Int32_ShaderTagId;
		public virtual RMethod RMFindPassTagValue_Int32_Int32_ShaderTagId
		{
			get
			{
				if(r_MFindPassTagValue_Int32_Int32_ShaderTagId == null)
				{
					r_MFindPassTagValue_Int32_Int32_ShaderTagId = new(this, "FindPassTagValue", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.ShaderTagId));
					r_MFindPassTagValue_Int32_Int32_ShaderTagId.SetBelong(this.instance);
				}
				return r_MFindPassTagValue_Int32_Int32_ShaderTagId;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ShaderTagId FindSubshaderTagValue(Int32, UnityEngine.Rendering.ShaderTagId)
		/// </summary>
		protected RMethod r_MFindSubshaderTagValue_Int32_ShaderTagId;
		public virtual RMethod RMFindSubshaderTagValue_Int32_ShaderTagId
		{
			get
			{
				if(r_MFindSubshaderTagValue_Int32_ShaderTagId == null)
				{
					r_MFindSubshaderTagValue_Int32_ShaderTagId = new(this, "FindSubshaderTagValue", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.ShaderTagId));
					r_MFindSubshaderTagValue_Int32_ShaderTagId.SetBelong(this.instance);
				}
				return r_MFindSubshaderTagValue_Int32_ShaderTagId;
			}
		}

		/// <summary>
		/// Int32 Internal_FindPassTagValue(Int32, Int32)
		/// </summary>
		protected RMethod r_MInternal_FindPassTagValue_Int32_Int32;
		public virtual RMethod RMInternal_FindPassTagValue_Int32_Int32
		{
			get
			{
				if(r_MInternal_FindPassTagValue_Int32_Int32 == null)
				{
					r_MInternal_FindPassTagValue_Int32_Int32 = new(this, "Internal_FindPassTagValue", 0, typeof(System.Int32), typeof(System.Int32));
					r_MInternal_FindPassTagValue_Int32_Int32.SetBelong(this.instance);
				}
				return r_MInternal_FindPassTagValue_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 Internal_FindPassTagValueInSubShader(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MInternal_FindPassTagValueInSubShader_Int32_Int32_Int32;
		public virtual RMethod RMInternal_FindPassTagValueInSubShader_Int32_Int32_Int32
		{
			get
			{
				if(r_MInternal_FindPassTagValueInSubShader_Int32_Int32_Int32 == null)
				{
					r_MInternal_FindPassTagValueInSubShader_Int32_Int32_Int32 = new(this, "Internal_FindPassTagValueInSubShader", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_MInternal_FindPassTagValueInSubShader_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_MInternal_FindPassTagValueInSubShader_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 Internal_FindSubshaderTagValue(Int32, Int32)
		/// </summary>
		protected RMethod r_MInternal_FindSubshaderTagValue_Int32_Int32;
		public virtual RMethod RMInternal_FindSubshaderTagValue_Int32_Int32
		{
			get
			{
				if(r_MInternal_FindSubshaderTagValue_Int32_Int32 == null)
				{
					r_MInternal_FindSubshaderTagValue_Int32_Int32 = new(this, "Internal_FindSubshaderTagValue", 0, typeof(System.Int32), typeof(System.Int32));
					r_MInternal_FindSubshaderTagValue_Int32_Int32.SetBelong(this.instance);
				}
				return r_MInternal_FindSubshaderTagValue_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Internal_GetCustomEditorForRenderPipeline(System.String, System.String ByRef)
		/// </summary>
		protected RMethod r_MInternal_GetCustomEditorForRenderPipeline_String_Out_String;
		public virtual RMethod RMInternal_GetCustomEditorForRenderPipeline_String_Out_String
		{
			get
			{
				if(r_MInternal_GetCustomEditorForRenderPipeline_String_Out_String == null)
				{
					r_MInternal_GetCustomEditorForRenderPipeline_String_Out_String = new(this, "Internal_GetCustomEditorForRenderPipeline", 0, typeof(System.String), typeof(System.String).MakeByRefType());
					r_MInternal_GetCustomEditorForRenderPipeline_String_Out_String.SetBelong(this.instance);
				}
				return r_MInternal_GetCustomEditorForRenderPipeline_String_Out_String;
			}
		}

		/// <summary>
		/// Void SetGlobalIntImpl(Int32, Int32)
		/// </summary>
		protected static RMethod r_MSetGlobalIntImpl_Int32_Int32;
		public static RMethod RMSetGlobalIntImpl_Int32_Int32
		{
			get
			{
				if(r_MSetGlobalIntImpl_Int32_Int32 == null)
				{
					r_MSetGlobalIntImpl_Int32_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalIntImpl", 0, typeof(System.Int32), typeof(System.Int32));
					r_MSetGlobalIntImpl_Int32_Int32.SetBelong(null);
				}
				return r_MSetGlobalIntImpl_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalFloatImpl(Int32, Single)
		/// </summary>
		protected static RMethod r_MSetGlobalFloatImpl_Int32_Single;
		public static RMethod RMSetGlobalFloatImpl_Int32_Single
		{
			get
			{
				if(r_MSetGlobalFloatImpl_Int32_Single == null)
				{
					r_MSetGlobalFloatImpl_Int32_Single = new(typeof(UnityEngine.Shader), "SetGlobalFloatImpl", 0, typeof(System.Int32), typeof(System.Single));
					r_MSetGlobalFloatImpl_Int32_Single.SetBelong(null);
				}
				return r_MSetGlobalFloatImpl_Int32_Single;
			}
		}

		/// <summary>
		/// Void SetGlobalVectorImpl(Int32, UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_MSetGlobalVectorImpl_Int32_Vector4;
		public static RMethod RMSetGlobalVectorImpl_Int32_Vector4
		{
			get
			{
				if(r_MSetGlobalVectorImpl_Int32_Vector4 == null)
				{
					r_MSetGlobalVectorImpl_Int32_Vector4 = new(typeof(UnityEngine.Shader), "SetGlobalVectorImpl", 0, typeof(System.Int32), typeof(UnityEngine.Vector4));
					r_MSetGlobalVectorImpl_Int32_Vector4.SetBelong(null);
				}
				return r_MSetGlobalVectorImpl_Int32_Vector4;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrixImpl(Int32, UnityEngine.Matrix4x4)
		/// </summary>
		protected static RMethod r_MSetGlobalMatrixImpl_Int32_Matrix4x4;
		public static RMethod RMSetGlobalMatrixImpl_Int32_Matrix4x4
		{
			get
			{
				if(r_MSetGlobalMatrixImpl_Int32_Matrix4x4 == null)
				{
					r_MSetGlobalMatrixImpl_Int32_Matrix4x4 = new(typeof(UnityEngine.Shader), "SetGlobalMatrixImpl", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4));
					r_MSetGlobalMatrixImpl_Int32_Matrix4x4.SetBelong(null);
				}
				return r_MSetGlobalMatrixImpl_Int32_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetGlobalTextureImpl(Int32, UnityEngine.Texture)
		/// </summary>
		protected static RMethod r_MSetGlobalTextureImpl_Int32_Texture;
		public static RMethod RMSetGlobalTextureImpl_Int32_Texture
		{
			get
			{
				if(r_MSetGlobalTextureImpl_Int32_Texture == null)
				{
					r_MSetGlobalTextureImpl_Int32_Texture = new(typeof(UnityEngine.Shader), "SetGlobalTextureImpl", 0, typeof(System.Int32), typeof(UnityEngine.Texture));
					r_MSetGlobalTextureImpl_Int32_Texture.SetBelong(null);
				}
				return r_MSetGlobalTextureImpl_Int32_Texture;
			}
		}

		/// <summary>
		/// Void SetGlobalRenderTextureImpl(Int32, UnityEngine.RenderTexture, UnityEngine.Rendering.RenderTextureSubElement)
		/// </summary>
		protected static RMethod r_MSetGlobalRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement;
		public static RMethod RMSetGlobalRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement
		{
			get
			{
				if(r_MSetGlobalRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement == null)
				{
					r_MSetGlobalRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement = new(typeof(UnityEngine.Shader), "SetGlobalRenderTextureImpl", 0, typeof(System.Int32), typeof(UnityEngine.RenderTexture), typeof(UnityEngine.Rendering.RenderTextureSubElement));
					r_MSetGlobalRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement.SetBelong(null);
				}
				return r_MSetGlobalRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement;
			}
		}

		/// <summary>
		/// Void SetGlobalBufferImpl(Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected static RMethod r_MSetGlobalBufferImpl_Int32_ComputeBuffer;
		public static RMethod RMSetGlobalBufferImpl_Int32_ComputeBuffer
		{
			get
			{
				if(r_MSetGlobalBufferImpl_Int32_ComputeBuffer == null)
				{
					r_MSetGlobalBufferImpl_Int32_ComputeBuffer = new(typeof(UnityEngine.Shader), "SetGlobalBufferImpl", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
					r_MSetGlobalBufferImpl_Int32_ComputeBuffer.SetBelong(null);
				}
				return r_MSetGlobalBufferImpl_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetGlobalGraphicsBufferImpl(Int32, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected static RMethod r_MSetGlobalGraphicsBufferImpl_Int32_GraphicsBuffer;
		public static RMethod RMSetGlobalGraphicsBufferImpl_Int32_GraphicsBuffer
		{
			get
			{
				if(r_MSetGlobalGraphicsBufferImpl_Int32_GraphicsBuffer == null)
				{
					r_MSetGlobalGraphicsBufferImpl_Int32_GraphicsBuffer = new(typeof(UnityEngine.Shader), "SetGlobalGraphicsBufferImpl", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer));
					r_MSetGlobalGraphicsBufferImpl_Int32_GraphicsBuffer.SetBelong(null);
				}
				return r_MSetGlobalGraphicsBufferImpl_Int32_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetGlobalConstantBufferImpl(Int32, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected static RMethod r_MSetGlobalConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32;
		public static RMethod RMSetGlobalConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_MSetGlobalConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32 == null)
				{
					r_MSetGlobalConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalConstantBufferImpl", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
					r_MSetGlobalConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32.SetBelong(null);
				}
				return r_MSetGlobalConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalConstantGraphicsBufferImpl(Int32, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected static RMethod r_MSetGlobalConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32;
		public static RMethod RMSetGlobalConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_MSetGlobalConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32 == null)
				{
					r_MSetGlobalConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalConstantGraphicsBufferImpl", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
					r_MSetGlobalConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32.SetBelong(null);
				}
				return r_MSetGlobalConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetGlobalIntImpl(Int32)
		/// </summary>
		protected static RMethod r_MGetGlobalIntImpl_Int32;
		public static RMethod RMGetGlobalIntImpl_Int32
		{
			get
			{
				if(r_MGetGlobalIntImpl_Int32 == null)
				{
					r_MGetGlobalIntImpl_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalIntImpl", 0, typeof(System.Int32));
					r_MGetGlobalIntImpl_Int32.SetBelong(null);
				}
				return r_MGetGlobalIntImpl_Int32;
			}
		}

		/// <summary>
		/// Single GetGlobalFloatImpl(Int32)
		/// </summary>
		protected static RMethod r_MGetGlobalFloatImpl_Int32;
		public static RMethod RMGetGlobalFloatImpl_Int32
		{
			get
			{
				if(r_MGetGlobalFloatImpl_Int32 == null)
				{
					r_MGetGlobalFloatImpl_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalFloatImpl", 0, typeof(System.Int32));
					r_MGetGlobalFloatImpl_Int32.SetBelong(null);
				}
				return r_MGetGlobalFloatImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 GetGlobalVectorImpl(Int32)
		/// </summary>
		protected static RMethod r_MGetGlobalVectorImpl_Int32;
		public static RMethod RMGetGlobalVectorImpl_Int32
		{
			get
			{
				if(r_MGetGlobalVectorImpl_Int32 == null)
				{
					r_MGetGlobalVectorImpl_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalVectorImpl", 0, typeof(System.Int32));
					r_MGetGlobalVectorImpl_Int32.SetBelong(null);
				}
				return r_MGetGlobalVectorImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 GetGlobalMatrixImpl(Int32)
		/// </summary>
		protected static RMethod r_MGetGlobalMatrixImpl_Int32;
		public static RMethod RMGetGlobalMatrixImpl_Int32
		{
			get
			{
				if(r_MGetGlobalMatrixImpl_Int32 == null)
				{
					r_MGetGlobalMatrixImpl_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalMatrixImpl", 0, typeof(System.Int32));
					r_MGetGlobalMatrixImpl_Int32.SetBelong(null);
				}
				return r_MGetGlobalMatrixImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Texture GetGlobalTextureImpl(Int32)
		/// </summary>
		protected static RMethod r_MGetGlobalTextureImpl_Int32;
		public static RMethod RMGetGlobalTextureImpl_Int32
		{
			get
			{
				if(r_MGetGlobalTextureImpl_Int32 == null)
				{
					r_MGetGlobalTextureImpl_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalTextureImpl", 0, typeof(System.Int32));
					r_MGetGlobalTextureImpl_Int32.SetBelong(null);
				}
				return r_MGetGlobalTextureImpl_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalFloatArrayImpl(Int32, Single[], Int32)
		/// </summary>
		protected static RMethod r_MSetGlobalFloatArrayImpl_Int32_SingleArray_Int32;
		public static RMethod RMSetGlobalFloatArrayImpl_Int32_SingleArray_Int32
		{
			get
			{
				if(r_MSetGlobalFloatArrayImpl_Int32_SingleArray_Int32 == null)
				{
					r_MSetGlobalFloatArrayImpl_Int32_SingleArray_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalFloatArrayImpl", 0, typeof(System.Int32), typeof(System.Single).MakeArrayType(), typeof(System.Int32));
					r_MSetGlobalFloatArrayImpl_Int32_SingleArray_Int32.SetBelong(null);
				}
				return r_MSetGlobalFloatArrayImpl_Int32_SingleArray_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalVectorArrayImpl(Int32, UnityEngine.Vector4[], Int32)
		/// </summary>
		protected static RMethod r_MSetGlobalVectorArrayImpl_Int32_Vector4Array_Int32;
		public static RMethod RMSetGlobalVectorArrayImpl_Int32_Vector4Array_Int32
		{
			get
			{
				if(r_MSetGlobalVectorArrayImpl_Int32_Vector4Array_Int32 == null)
				{
					r_MSetGlobalVectorArrayImpl_Int32_Vector4Array_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalVectorArrayImpl", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType(), typeof(System.Int32));
					r_MSetGlobalVectorArrayImpl_Int32_Vector4Array_Int32.SetBelong(null);
				}
				return r_MSetGlobalVectorArrayImpl_Int32_Vector4Array_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrixArrayImpl(Int32, UnityEngine.Matrix4x4[], Int32)
		/// </summary>
		protected static RMethod r_MSetGlobalMatrixArrayImpl_Int32_Matrix4x4Array_Int32;
		public static RMethod RMSetGlobalMatrixArrayImpl_Int32_Matrix4x4Array_Int32
		{
			get
			{
				if(r_MSetGlobalMatrixArrayImpl_Int32_Matrix4x4Array_Int32 == null)
				{
					r_MSetGlobalMatrixArrayImpl_Int32_Matrix4x4Array_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalMatrixArrayImpl", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType(), typeof(System.Int32));
					r_MSetGlobalMatrixArrayImpl_Int32_Matrix4x4Array_Int32.SetBelong(null);
				}
				return r_MSetGlobalMatrixArrayImpl_Int32_Matrix4x4Array_Int32;
			}
		}

		/// <summary>
		/// Single[] GetGlobalFloatArrayImpl(Int32)
		/// </summary>
		protected static RMethod r_MGetGlobalFloatArrayImpl_Int32;
		public static RMethod RMGetGlobalFloatArrayImpl_Int32
		{
			get
			{
				if(r_MGetGlobalFloatArrayImpl_Int32 == null)
				{
					r_MGetGlobalFloatArrayImpl_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalFloatArrayImpl", 0, typeof(System.Int32));
					r_MGetGlobalFloatArrayImpl_Int32.SetBelong(null);
				}
				return r_MGetGlobalFloatArrayImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4[] GetGlobalVectorArrayImpl(Int32)
		/// </summary>
		protected static RMethod r_MGetGlobalVectorArrayImpl_Int32;
		public static RMethod RMGetGlobalVectorArrayImpl_Int32
		{
			get
			{
				if(r_MGetGlobalVectorArrayImpl_Int32 == null)
				{
					r_MGetGlobalVectorArrayImpl_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalVectorArrayImpl", 0, typeof(System.Int32));
					r_MGetGlobalVectorArrayImpl_Int32.SetBelong(null);
				}
				return r_MGetGlobalVectorArrayImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4[] GetGlobalMatrixArrayImpl(Int32)
		/// </summary>
		protected static RMethod r_MGetGlobalMatrixArrayImpl_Int32;
		public static RMethod RMGetGlobalMatrixArrayImpl_Int32
		{
			get
			{
				if(r_MGetGlobalMatrixArrayImpl_Int32 == null)
				{
					r_MGetGlobalMatrixArrayImpl_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalMatrixArrayImpl", 0, typeof(System.Int32));
					r_MGetGlobalMatrixArrayImpl_Int32.SetBelong(null);
				}
				return r_MGetGlobalMatrixArrayImpl_Int32;
			}
		}

		/// <summary>
		/// Int32 GetGlobalFloatArrayCountImpl(Int32)
		/// </summary>
		protected static RMethod r_MGetGlobalFloatArrayCountImpl_Int32;
		public static RMethod RMGetGlobalFloatArrayCountImpl_Int32
		{
			get
			{
				if(r_MGetGlobalFloatArrayCountImpl_Int32 == null)
				{
					r_MGetGlobalFloatArrayCountImpl_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalFloatArrayCountImpl", 0, typeof(System.Int32));
					r_MGetGlobalFloatArrayCountImpl_Int32.SetBelong(null);
				}
				return r_MGetGlobalFloatArrayCountImpl_Int32;
			}
		}

		/// <summary>
		/// Int32 GetGlobalVectorArrayCountImpl(Int32)
		/// </summary>
		protected static RMethod r_MGetGlobalVectorArrayCountImpl_Int32;
		public static RMethod RMGetGlobalVectorArrayCountImpl_Int32
		{
			get
			{
				if(r_MGetGlobalVectorArrayCountImpl_Int32 == null)
				{
					r_MGetGlobalVectorArrayCountImpl_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalVectorArrayCountImpl", 0, typeof(System.Int32));
					r_MGetGlobalVectorArrayCountImpl_Int32.SetBelong(null);
				}
				return r_MGetGlobalVectorArrayCountImpl_Int32;
			}
		}

		/// <summary>
		/// Int32 GetGlobalMatrixArrayCountImpl(Int32)
		/// </summary>
		protected static RMethod r_MGetGlobalMatrixArrayCountImpl_Int32;
		public static RMethod RMGetGlobalMatrixArrayCountImpl_Int32
		{
			get
			{
				if(r_MGetGlobalMatrixArrayCountImpl_Int32 == null)
				{
					r_MGetGlobalMatrixArrayCountImpl_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalMatrixArrayCountImpl", 0, typeof(System.Int32));
					r_MGetGlobalMatrixArrayCountImpl_Int32.SetBelong(null);
				}
				return r_MGetGlobalMatrixArrayCountImpl_Int32;
			}
		}

		/// <summary>
		/// Void ExtractGlobalFloatArrayImpl(Int32, Single[])
		/// </summary>
		protected static RMethod r_MExtractGlobalFloatArrayImpl_Int32_SingleArray;
		public static RMethod RMExtractGlobalFloatArrayImpl_Int32_SingleArray
		{
			get
			{
				if(r_MExtractGlobalFloatArrayImpl_Int32_SingleArray == null)
				{
					r_MExtractGlobalFloatArrayImpl_Int32_SingleArray = new(typeof(UnityEngine.Shader), "ExtractGlobalFloatArrayImpl", 0, typeof(System.Int32), typeof(System.Single).MakeArrayType());
					r_MExtractGlobalFloatArrayImpl_Int32_SingleArray.SetBelong(null);
				}
				return r_MExtractGlobalFloatArrayImpl_Int32_SingleArray;
			}
		}

		/// <summary>
		/// Void ExtractGlobalVectorArrayImpl(Int32, UnityEngine.Vector4[])
		/// </summary>
		protected static RMethod r_MExtractGlobalVectorArrayImpl_Int32_Vector4Array;
		public static RMethod RMExtractGlobalVectorArrayImpl_Int32_Vector4Array
		{
			get
			{
				if(r_MExtractGlobalVectorArrayImpl_Int32_Vector4Array == null)
				{
					r_MExtractGlobalVectorArrayImpl_Int32_Vector4Array = new(typeof(UnityEngine.Shader), "ExtractGlobalVectorArrayImpl", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType());
					r_MExtractGlobalVectorArrayImpl_Int32_Vector4Array.SetBelong(null);
				}
				return r_MExtractGlobalVectorArrayImpl_Int32_Vector4Array;
			}
		}

		/// <summary>
		/// Void ExtractGlobalMatrixArrayImpl(Int32, UnityEngine.Matrix4x4[])
		/// </summary>
		protected static RMethod r_MExtractGlobalMatrixArrayImpl_Int32_Matrix4x4Array;
		public static RMethod RMExtractGlobalMatrixArrayImpl_Int32_Matrix4x4Array
		{
			get
			{
				if(r_MExtractGlobalMatrixArrayImpl_Int32_Matrix4x4Array == null)
				{
					r_MExtractGlobalMatrixArrayImpl_Int32_Matrix4x4Array = new(typeof(UnityEngine.Shader), "ExtractGlobalMatrixArrayImpl", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType());
					r_MExtractGlobalMatrixArrayImpl_Int32_Matrix4x4Array.SetBelong(null);
				}
				return r_MExtractGlobalMatrixArrayImpl_Int32_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Void SetGlobalFloatArray(Int32, Single[], Int32)
		/// </summary>
		protected static RMethod r_MSetGlobalFloatArray_Int32_SingleArray_Int32;
		public static RMethod RMSetGlobalFloatArray_Int32_SingleArray_Int32
		{
			get
			{
				if(r_MSetGlobalFloatArray_Int32_SingleArray_Int32 == null)
				{
					r_MSetGlobalFloatArray_Int32_SingleArray_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalFloatArray", 0, typeof(System.Int32), typeof(System.Single).MakeArrayType(), typeof(System.Int32));
					r_MSetGlobalFloatArray_Int32_SingleArray_Int32.SetBelong(null);
				}
				return r_MSetGlobalFloatArray_Int32_SingleArray_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalVectorArray(Int32, UnityEngine.Vector4[], Int32)
		/// </summary>
		protected static RMethod r_MSetGlobalVectorArray_Int32_Vector4Array_Int32;
		public static RMethod RMSetGlobalVectorArray_Int32_Vector4Array_Int32
		{
			get
			{
				if(r_MSetGlobalVectorArray_Int32_Vector4Array_Int32 == null)
				{
					r_MSetGlobalVectorArray_Int32_Vector4Array_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalVectorArray", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType(), typeof(System.Int32));
					r_MSetGlobalVectorArray_Int32_Vector4Array_Int32.SetBelong(null);
				}
				return r_MSetGlobalVectorArray_Int32_Vector4Array_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrixArray(Int32, UnityEngine.Matrix4x4[], Int32)
		/// </summary>
		protected static RMethod r_MSetGlobalMatrixArray_Int32_Matrix4x4Array_Int32;
		public static RMethod RMSetGlobalMatrixArray_Int32_Matrix4x4Array_Int32
		{
			get
			{
				if(r_MSetGlobalMatrixArray_Int32_Matrix4x4Array_Int32 == null)
				{
					r_MSetGlobalMatrixArray_Int32_Matrix4x4Array_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalMatrixArray", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType(), typeof(System.Int32));
					r_MSetGlobalMatrixArray_Int32_Matrix4x4Array_Int32.SetBelong(null);
				}
				return r_MSetGlobalMatrixArray_Int32_Matrix4x4Array_Int32;
			}
		}

		/// <summary>
		/// Void ExtractGlobalFloatArray(Int32, System.Collections.Generic.List`1[System.Single])
		/// </summary>
		protected static RMethod r_MExtractGlobalFloatArray_Int32_List_d_Single_p_;
		public static RMethod RMExtractGlobalFloatArray_Int32_List_d_Single_p_
		{
			get
			{
				if(r_MExtractGlobalFloatArray_Int32_List_d_Single_p_ == null)
				{
					r_MExtractGlobalFloatArray_Int32_List_d_Single_p_ = new(typeof(UnityEngine.Shader), "ExtractGlobalFloatArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Single)));
					r_MExtractGlobalFloatArray_Int32_List_d_Single_p_.SetBelong(null);
				}
				return r_MExtractGlobalFloatArray_Int32_List_d_Single_p_;
			}
		}

		/// <summary>
		/// Void ExtractGlobalVectorArray(Int32, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected static RMethod r_MExtractGlobalVectorArray_Int32_List_d_Vector4_p_;
		public static RMethod RMExtractGlobalVectorArray_Int32_List_d_Vector4_p_
		{
			get
			{
				if(r_MExtractGlobalVectorArray_Int32_List_d_Vector4_p_ == null)
				{
					r_MExtractGlobalVectorArray_Int32_List_d_Vector4_p_ = new(typeof(UnityEngine.Shader), "ExtractGlobalVectorArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_MExtractGlobalVectorArray_Int32_List_d_Vector4_p_.SetBelong(null);
				}
				return r_MExtractGlobalVectorArray_Int32_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void ExtractGlobalMatrixArray(Int32, System.Collections.Generic.List`1[UnityEngine.Matrix4x4])
		/// </summary>
		protected static RMethod r_MExtractGlobalMatrixArray_Int32_List_d_Matrix4x4_p_;
		public static RMethod RMExtractGlobalMatrixArray_Int32_List_d_Matrix4x4_p_
		{
			get
			{
				if(r_MExtractGlobalMatrixArray_Int32_List_d_Matrix4x4_p_ == null)
				{
					r_MExtractGlobalMatrixArray_Int32_List_d_Matrix4x4_p_ = new(typeof(UnityEngine.Shader), "ExtractGlobalMatrixArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Matrix4x4)));
					r_MExtractGlobalMatrixArray_Int32_List_d_Matrix4x4_p_.SetBelong(null);
				}
				return r_MExtractGlobalMatrixArray_Int32_List_d_Matrix4x4_p_;
			}
		}

		/// <summary>
		/// Void SetGlobalInt(System.String, Int32)
		/// </summary>
		protected static RMethod r_MSetGlobalInt_String_Int32;
		public static RMethod RMSetGlobalInt_String_Int32
		{
			get
			{
				if(r_MSetGlobalInt_String_Int32 == null)
				{
					r_MSetGlobalInt_String_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalInt", 0, typeof(System.String), typeof(System.Int32));
					r_MSetGlobalInt_String_Int32.SetBelong(null);
				}
				return r_MSetGlobalInt_String_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalInt(Int32, Int32)
		/// </summary>
		protected static RMethod r_MSetGlobalInt_Int32_Int32;
		public static RMethod RMSetGlobalInt_Int32_Int32
		{
			get
			{
				if(r_MSetGlobalInt_Int32_Int32 == null)
				{
					r_MSetGlobalInt_Int32_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalInt", 0, typeof(System.Int32), typeof(System.Int32));
					r_MSetGlobalInt_Int32_Int32.SetBelong(null);
				}
				return r_MSetGlobalInt_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalFloat(System.String, Single)
		/// </summary>
		protected static RMethod r_MSetGlobalFloat_String_Single;
		public static RMethod RMSetGlobalFloat_String_Single
		{
			get
			{
				if(r_MSetGlobalFloat_String_Single == null)
				{
					r_MSetGlobalFloat_String_Single = new(typeof(UnityEngine.Shader), "SetGlobalFloat", 0, typeof(System.String), typeof(System.Single));
					r_MSetGlobalFloat_String_Single.SetBelong(null);
				}
				return r_MSetGlobalFloat_String_Single;
			}
		}

		/// <summary>
		/// Void SetGlobalFloat(Int32, Single)
		/// </summary>
		protected static RMethod r_MSetGlobalFloat_Int32_Single;
		public static RMethod RMSetGlobalFloat_Int32_Single
		{
			get
			{
				if(r_MSetGlobalFloat_Int32_Single == null)
				{
					r_MSetGlobalFloat_Int32_Single = new(typeof(UnityEngine.Shader), "SetGlobalFloat", 0, typeof(System.Int32), typeof(System.Single));
					r_MSetGlobalFloat_Int32_Single.SetBelong(null);
				}
				return r_MSetGlobalFloat_Int32_Single;
			}
		}

		/// <summary>
		/// Void SetGlobalInteger(System.String, Int32)
		/// </summary>
		protected static RMethod r_MSetGlobalInteger_String_Int32;
		public static RMethod RMSetGlobalInteger_String_Int32
		{
			get
			{
				if(r_MSetGlobalInteger_String_Int32 == null)
				{
					r_MSetGlobalInteger_String_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalInteger", 0, typeof(System.String), typeof(System.Int32));
					r_MSetGlobalInteger_String_Int32.SetBelong(null);
				}
				return r_MSetGlobalInteger_String_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalInteger(Int32, Int32)
		/// </summary>
		protected static RMethod r_MSetGlobalInteger_Int32_Int32;
		public static RMethod RMSetGlobalInteger_Int32_Int32
		{
			get
			{
				if(r_MSetGlobalInteger_Int32_Int32 == null)
				{
					r_MSetGlobalInteger_Int32_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalInteger", 0, typeof(System.Int32), typeof(System.Int32));
					r_MSetGlobalInteger_Int32_Int32.SetBelong(null);
				}
				return r_MSetGlobalInteger_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalVector(System.String, UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_MSetGlobalVector_String_Vector4;
		public static RMethod RMSetGlobalVector_String_Vector4
		{
			get
			{
				if(r_MSetGlobalVector_String_Vector4 == null)
				{
					r_MSetGlobalVector_String_Vector4 = new(typeof(UnityEngine.Shader), "SetGlobalVector", 0, typeof(System.String), typeof(UnityEngine.Vector4));
					r_MSetGlobalVector_String_Vector4.SetBelong(null);
				}
				return r_MSetGlobalVector_String_Vector4;
			}
		}

		/// <summary>
		/// Void SetGlobalVector(Int32, UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_MSetGlobalVector_Int32_Vector4;
		public static RMethod RMSetGlobalVector_Int32_Vector4
		{
			get
			{
				if(r_MSetGlobalVector_Int32_Vector4 == null)
				{
					r_MSetGlobalVector_Int32_Vector4 = new(typeof(UnityEngine.Shader), "SetGlobalVector", 0, typeof(System.Int32), typeof(UnityEngine.Vector4));
					r_MSetGlobalVector_Int32_Vector4.SetBelong(null);
				}
				return r_MSetGlobalVector_Int32_Vector4;
			}
		}

		/// <summary>
		/// Void SetGlobalColor(System.String, UnityEngine.Color)
		/// </summary>
		protected static RMethod r_MSetGlobalColor_String_Color;
		public static RMethod RMSetGlobalColor_String_Color
		{
			get
			{
				if(r_MSetGlobalColor_String_Color == null)
				{
					r_MSetGlobalColor_String_Color = new(typeof(UnityEngine.Shader), "SetGlobalColor", 0, typeof(System.String), typeof(UnityEngine.Color));
					r_MSetGlobalColor_String_Color.SetBelong(null);
				}
				return r_MSetGlobalColor_String_Color;
			}
		}

		/// <summary>
		/// Void SetGlobalColor(Int32, UnityEngine.Color)
		/// </summary>
		protected static RMethod r_MSetGlobalColor_Int32_Color;
		public static RMethod RMSetGlobalColor_Int32_Color
		{
			get
			{
				if(r_MSetGlobalColor_Int32_Color == null)
				{
					r_MSetGlobalColor_Int32_Color = new(typeof(UnityEngine.Shader), "SetGlobalColor", 0, typeof(System.Int32), typeof(UnityEngine.Color));
					r_MSetGlobalColor_Int32_Color.SetBelong(null);
				}
				return r_MSetGlobalColor_Int32_Color;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrix(System.String, UnityEngine.Matrix4x4)
		/// </summary>
		protected static RMethod r_MSetGlobalMatrix_String_Matrix4x4;
		public static RMethod RMSetGlobalMatrix_String_Matrix4x4
		{
			get
			{
				if(r_MSetGlobalMatrix_String_Matrix4x4 == null)
				{
					r_MSetGlobalMatrix_String_Matrix4x4 = new(typeof(UnityEngine.Shader), "SetGlobalMatrix", 0, typeof(System.String), typeof(UnityEngine.Matrix4x4));
					r_MSetGlobalMatrix_String_Matrix4x4.SetBelong(null);
				}
				return r_MSetGlobalMatrix_String_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrix(Int32, UnityEngine.Matrix4x4)
		/// </summary>
		protected static RMethod r_MSetGlobalMatrix_Int32_Matrix4x4;
		public static RMethod RMSetGlobalMatrix_Int32_Matrix4x4
		{
			get
			{
				if(r_MSetGlobalMatrix_Int32_Matrix4x4 == null)
				{
					r_MSetGlobalMatrix_Int32_Matrix4x4 = new(typeof(UnityEngine.Shader), "SetGlobalMatrix", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4));
					r_MSetGlobalMatrix_Int32_Matrix4x4.SetBelong(null);
				}
				return r_MSetGlobalMatrix_Int32_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetGlobalTexture(System.String, UnityEngine.Texture)
		/// </summary>
		protected static RMethod r_MSetGlobalTexture_String_Texture;
		public static RMethod RMSetGlobalTexture_String_Texture
		{
			get
			{
				if(r_MSetGlobalTexture_String_Texture == null)
				{
					r_MSetGlobalTexture_String_Texture = new(typeof(UnityEngine.Shader), "SetGlobalTexture", 0, typeof(System.String), typeof(UnityEngine.Texture));
					r_MSetGlobalTexture_String_Texture.SetBelong(null);
				}
				return r_MSetGlobalTexture_String_Texture;
			}
		}

		/// <summary>
		/// Void SetGlobalTexture(Int32, UnityEngine.Texture)
		/// </summary>
		protected static RMethod r_MSetGlobalTexture_Int32_Texture;
		public static RMethod RMSetGlobalTexture_Int32_Texture
		{
			get
			{
				if(r_MSetGlobalTexture_Int32_Texture == null)
				{
					r_MSetGlobalTexture_Int32_Texture = new(typeof(UnityEngine.Shader), "SetGlobalTexture", 0, typeof(System.Int32), typeof(UnityEngine.Texture));
					r_MSetGlobalTexture_Int32_Texture.SetBelong(null);
				}
				return r_MSetGlobalTexture_Int32_Texture;
			}
		}

		/// <summary>
		/// Void SetGlobalTexture(System.String, UnityEngine.RenderTexture, UnityEngine.Rendering.RenderTextureSubElement)
		/// </summary>
		protected static RMethod r_MSetGlobalTexture_String_RenderTexture_RenderTextureSubElement;
		public static RMethod RMSetGlobalTexture_String_RenderTexture_RenderTextureSubElement
		{
			get
			{
				if(r_MSetGlobalTexture_String_RenderTexture_RenderTextureSubElement == null)
				{
					r_MSetGlobalTexture_String_RenderTexture_RenderTextureSubElement = new(typeof(UnityEngine.Shader), "SetGlobalTexture", 0, typeof(System.String), typeof(UnityEngine.RenderTexture), typeof(UnityEngine.Rendering.RenderTextureSubElement));
					r_MSetGlobalTexture_String_RenderTexture_RenderTextureSubElement.SetBelong(null);
				}
				return r_MSetGlobalTexture_String_RenderTexture_RenderTextureSubElement;
			}
		}

		/// <summary>
		/// Void SetGlobalTexture(Int32, UnityEngine.RenderTexture, UnityEngine.Rendering.RenderTextureSubElement)
		/// </summary>
		protected static RMethod r_MSetGlobalTexture_Int32_RenderTexture_RenderTextureSubElement;
		public static RMethod RMSetGlobalTexture_Int32_RenderTexture_RenderTextureSubElement
		{
			get
			{
				if(r_MSetGlobalTexture_Int32_RenderTexture_RenderTextureSubElement == null)
				{
					r_MSetGlobalTexture_Int32_RenderTexture_RenderTextureSubElement = new(typeof(UnityEngine.Shader), "SetGlobalTexture", 0, typeof(System.Int32), typeof(UnityEngine.RenderTexture), typeof(UnityEngine.Rendering.RenderTextureSubElement));
					r_MSetGlobalTexture_Int32_RenderTexture_RenderTextureSubElement.SetBelong(null);
				}
				return r_MSetGlobalTexture_Int32_RenderTexture_RenderTextureSubElement;
			}
		}

		/// <summary>
		/// Void SetGlobalBuffer(System.String, UnityEngine.ComputeBuffer)
		/// </summary>
		protected static RMethod r_MSetGlobalBuffer_String_ComputeBuffer;
		public static RMethod RMSetGlobalBuffer_String_ComputeBuffer
		{
			get
			{
				if(r_MSetGlobalBuffer_String_ComputeBuffer == null)
				{
					r_MSetGlobalBuffer_String_ComputeBuffer = new(typeof(UnityEngine.Shader), "SetGlobalBuffer", 0, typeof(System.String), typeof(UnityEngine.ComputeBuffer));
					r_MSetGlobalBuffer_String_ComputeBuffer.SetBelong(null);
				}
				return r_MSetGlobalBuffer_String_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetGlobalBuffer(Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected static RMethod r_MSetGlobalBuffer_Int32_ComputeBuffer;
		public static RMethod RMSetGlobalBuffer_Int32_ComputeBuffer
		{
			get
			{
				if(r_MSetGlobalBuffer_Int32_ComputeBuffer == null)
				{
					r_MSetGlobalBuffer_Int32_ComputeBuffer = new(typeof(UnityEngine.Shader), "SetGlobalBuffer", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
					r_MSetGlobalBuffer_Int32_ComputeBuffer.SetBelong(null);
				}
				return r_MSetGlobalBuffer_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetGlobalBuffer(System.String, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected static RMethod r_MSetGlobalBuffer_String_GraphicsBuffer;
		public static RMethod RMSetGlobalBuffer_String_GraphicsBuffer
		{
			get
			{
				if(r_MSetGlobalBuffer_String_GraphicsBuffer == null)
				{
					r_MSetGlobalBuffer_String_GraphicsBuffer = new(typeof(UnityEngine.Shader), "SetGlobalBuffer", 0, typeof(System.String), typeof(UnityEngine.GraphicsBuffer));
					r_MSetGlobalBuffer_String_GraphicsBuffer.SetBelong(null);
				}
				return r_MSetGlobalBuffer_String_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetGlobalBuffer(Int32, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected static RMethod r_MSetGlobalBuffer_Int32_GraphicsBuffer;
		public static RMethod RMSetGlobalBuffer_Int32_GraphicsBuffer
		{
			get
			{
				if(r_MSetGlobalBuffer_Int32_GraphicsBuffer == null)
				{
					r_MSetGlobalBuffer_Int32_GraphicsBuffer = new(typeof(UnityEngine.Shader), "SetGlobalBuffer", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer));
					r_MSetGlobalBuffer_Int32_GraphicsBuffer.SetBelong(null);
				}
				return r_MSetGlobalBuffer_Int32_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetGlobalConstantBuffer(System.String, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected static RMethod r_MSetGlobalConstantBuffer_String_ComputeBuffer_Int32_Int32;
		public static RMethod RMSetGlobalConstantBuffer_String_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_MSetGlobalConstantBuffer_String_ComputeBuffer_Int32_Int32 == null)
				{
					r_MSetGlobalConstantBuffer_String_ComputeBuffer_Int32_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalConstantBuffer", 0, typeof(System.String), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
					r_MSetGlobalConstantBuffer_String_ComputeBuffer_Int32_Int32.SetBelong(null);
				}
				return r_MSetGlobalConstantBuffer_String_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalConstantBuffer(Int32, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected static RMethod r_MSetGlobalConstantBuffer_Int32_ComputeBuffer_Int32_Int32;
		public static RMethod RMSetGlobalConstantBuffer_Int32_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_MSetGlobalConstantBuffer_Int32_ComputeBuffer_Int32_Int32 == null)
				{
					r_MSetGlobalConstantBuffer_Int32_ComputeBuffer_Int32_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalConstantBuffer", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
					r_MSetGlobalConstantBuffer_Int32_ComputeBuffer_Int32_Int32.SetBelong(null);
				}
				return r_MSetGlobalConstantBuffer_Int32_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalConstantBuffer(System.String, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected static RMethod r_MSetGlobalConstantBuffer_String_GraphicsBuffer_Int32_Int32;
		public static RMethod RMSetGlobalConstantBuffer_String_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_MSetGlobalConstantBuffer_String_GraphicsBuffer_Int32_Int32 == null)
				{
					r_MSetGlobalConstantBuffer_String_GraphicsBuffer_Int32_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalConstantBuffer", 0, typeof(System.String), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
					r_MSetGlobalConstantBuffer_String_GraphicsBuffer_Int32_Int32.SetBelong(null);
				}
				return r_MSetGlobalConstantBuffer_String_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalConstantBuffer(Int32, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected static RMethod r_MSetGlobalConstantBuffer_Int32_GraphicsBuffer_Int32_Int32;
		public static RMethod RMSetGlobalConstantBuffer_Int32_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_MSetGlobalConstantBuffer_Int32_GraphicsBuffer_Int32_Int32 == null)
				{
					r_MSetGlobalConstantBuffer_Int32_GraphicsBuffer_Int32_Int32 = new(typeof(UnityEngine.Shader), "SetGlobalConstantBuffer", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
					r_MSetGlobalConstantBuffer_Int32_GraphicsBuffer_Int32_Int32.SetBelong(null);
				}
				return r_MSetGlobalConstantBuffer_Int32_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetGlobalFloatArray(System.String, System.Collections.Generic.List`1[System.Single])
		/// </summary>
		protected static RMethod r_MSetGlobalFloatArray_String_List_d_Single_p_;
		public static RMethod RMSetGlobalFloatArray_String_List_d_Single_p_
		{
			get
			{
				if(r_MSetGlobalFloatArray_String_List_d_Single_p_ == null)
				{
					r_MSetGlobalFloatArray_String_List_d_Single_p_ = new(typeof(UnityEngine.Shader), "SetGlobalFloatArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Single)));
					r_MSetGlobalFloatArray_String_List_d_Single_p_.SetBelong(null);
				}
				return r_MSetGlobalFloatArray_String_List_d_Single_p_;
			}
		}

		/// <summary>
		/// Void SetGlobalFloatArray(Int32, System.Collections.Generic.List`1[System.Single])
		/// </summary>
		protected static RMethod r_MSetGlobalFloatArray_Int32_List_d_Single_p_;
		public static RMethod RMSetGlobalFloatArray_Int32_List_d_Single_p_
		{
			get
			{
				if(r_MSetGlobalFloatArray_Int32_List_d_Single_p_ == null)
				{
					r_MSetGlobalFloatArray_Int32_List_d_Single_p_ = new(typeof(UnityEngine.Shader), "SetGlobalFloatArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Single)));
					r_MSetGlobalFloatArray_Int32_List_d_Single_p_.SetBelong(null);
				}
				return r_MSetGlobalFloatArray_Int32_List_d_Single_p_;
			}
		}

		/// <summary>
		/// Void SetGlobalFloatArray(System.String, Single[])
		/// </summary>
		protected static RMethod r_MSetGlobalFloatArray_String_SingleArray;
		public static RMethod RMSetGlobalFloatArray_String_SingleArray
		{
			get
			{
				if(r_MSetGlobalFloatArray_String_SingleArray == null)
				{
					r_MSetGlobalFloatArray_String_SingleArray = new(typeof(UnityEngine.Shader), "SetGlobalFloatArray", 0, typeof(System.String), typeof(System.Single).MakeArrayType());
					r_MSetGlobalFloatArray_String_SingleArray.SetBelong(null);
				}
				return r_MSetGlobalFloatArray_String_SingleArray;
			}
		}

		/// <summary>
		/// Void SetGlobalFloatArray(Int32, Single[])
		/// </summary>
		protected static RMethod r_MSetGlobalFloatArray_Int32_SingleArray;
		public static RMethod RMSetGlobalFloatArray_Int32_SingleArray
		{
			get
			{
				if(r_MSetGlobalFloatArray_Int32_SingleArray == null)
				{
					r_MSetGlobalFloatArray_Int32_SingleArray = new(typeof(UnityEngine.Shader), "SetGlobalFloatArray", 0, typeof(System.Int32), typeof(System.Single).MakeArrayType());
					r_MSetGlobalFloatArray_Int32_SingleArray.SetBelong(null);
				}
				return r_MSetGlobalFloatArray_Int32_SingleArray;
			}
		}

		/// <summary>
		/// Void SetGlobalVectorArray(System.String, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected static RMethod r_MSetGlobalVectorArray_String_List_d_Vector4_p_;
		public static RMethod RMSetGlobalVectorArray_String_List_d_Vector4_p_
		{
			get
			{
				if(r_MSetGlobalVectorArray_String_List_d_Vector4_p_ == null)
				{
					r_MSetGlobalVectorArray_String_List_d_Vector4_p_ = new(typeof(UnityEngine.Shader), "SetGlobalVectorArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_MSetGlobalVectorArray_String_List_d_Vector4_p_.SetBelong(null);
				}
				return r_MSetGlobalVectorArray_String_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void SetGlobalVectorArray(Int32, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected static RMethod r_MSetGlobalVectorArray_Int32_List_d_Vector4_p_;
		public static RMethod RMSetGlobalVectorArray_Int32_List_d_Vector4_p_
		{
			get
			{
				if(r_MSetGlobalVectorArray_Int32_List_d_Vector4_p_ == null)
				{
					r_MSetGlobalVectorArray_Int32_List_d_Vector4_p_ = new(typeof(UnityEngine.Shader), "SetGlobalVectorArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_MSetGlobalVectorArray_Int32_List_d_Vector4_p_.SetBelong(null);
				}
				return r_MSetGlobalVectorArray_Int32_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void SetGlobalVectorArray(System.String, UnityEngine.Vector4[])
		/// </summary>
		protected static RMethod r_MSetGlobalVectorArray_String_Vector4Array;
		public static RMethod RMSetGlobalVectorArray_String_Vector4Array
		{
			get
			{
				if(r_MSetGlobalVectorArray_String_Vector4Array == null)
				{
					r_MSetGlobalVectorArray_String_Vector4Array = new(typeof(UnityEngine.Shader), "SetGlobalVectorArray", 0, typeof(System.String), typeof(UnityEngine.Vector4).MakeArrayType());
					r_MSetGlobalVectorArray_String_Vector4Array.SetBelong(null);
				}
				return r_MSetGlobalVectorArray_String_Vector4Array;
			}
		}

		/// <summary>
		/// Void SetGlobalVectorArray(Int32, UnityEngine.Vector4[])
		/// </summary>
		protected static RMethod r_MSetGlobalVectorArray_Int32_Vector4Array;
		public static RMethod RMSetGlobalVectorArray_Int32_Vector4Array
		{
			get
			{
				if(r_MSetGlobalVectorArray_Int32_Vector4Array == null)
				{
					r_MSetGlobalVectorArray_Int32_Vector4Array = new(typeof(UnityEngine.Shader), "SetGlobalVectorArray", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType());
					r_MSetGlobalVectorArray_Int32_Vector4Array.SetBelong(null);
				}
				return r_MSetGlobalVectorArray_Int32_Vector4Array;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrixArray(System.String, System.Collections.Generic.List`1[UnityEngine.Matrix4x4])
		/// </summary>
		protected static RMethod r_MSetGlobalMatrixArray_String_List_d_Matrix4x4_p_;
		public static RMethod RMSetGlobalMatrixArray_String_List_d_Matrix4x4_p_
		{
			get
			{
				if(r_MSetGlobalMatrixArray_String_List_d_Matrix4x4_p_ == null)
				{
					r_MSetGlobalMatrixArray_String_List_d_Matrix4x4_p_ = new(typeof(UnityEngine.Shader), "SetGlobalMatrixArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Matrix4x4)));
					r_MSetGlobalMatrixArray_String_List_d_Matrix4x4_p_.SetBelong(null);
				}
				return r_MSetGlobalMatrixArray_String_List_d_Matrix4x4_p_;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrixArray(Int32, System.Collections.Generic.List`1[UnityEngine.Matrix4x4])
		/// </summary>
		protected static RMethod r_MSetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_;
		public static RMethod RMSetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_
		{
			get
			{
				if(r_MSetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_ == null)
				{
					r_MSetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_ = new(typeof(UnityEngine.Shader), "SetGlobalMatrixArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Matrix4x4)));
					r_MSetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_.SetBelong(null);
				}
				return r_MSetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrixArray(System.String, UnityEngine.Matrix4x4[])
		/// </summary>
		protected static RMethod r_MSetGlobalMatrixArray_String_Matrix4x4Array;
		public static RMethod RMSetGlobalMatrixArray_String_Matrix4x4Array
		{
			get
			{
				if(r_MSetGlobalMatrixArray_String_Matrix4x4Array == null)
				{
					r_MSetGlobalMatrixArray_String_Matrix4x4Array = new(typeof(UnityEngine.Shader), "SetGlobalMatrixArray", 0, typeof(System.String), typeof(UnityEngine.Matrix4x4).MakeArrayType());
					r_MSetGlobalMatrixArray_String_Matrix4x4Array.SetBelong(null);
				}
				return r_MSetGlobalMatrixArray_String_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrixArray(Int32, UnityEngine.Matrix4x4[])
		/// </summary>
		protected static RMethod r_MSetGlobalMatrixArray_Int32_Matrix4x4Array;
		public static RMethod RMSetGlobalMatrixArray_Int32_Matrix4x4Array
		{
			get
			{
				if(r_MSetGlobalMatrixArray_Int32_Matrix4x4Array == null)
				{
					r_MSetGlobalMatrixArray_Int32_Matrix4x4Array = new(typeof(UnityEngine.Shader), "SetGlobalMatrixArray", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType());
					r_MSetGlobalMatrixArray_Int32_Matrix4x4Array.SetBelong(null);
				}
				return r_MSetGlobalMatrixArray_Int32_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Int32 GetGlobalInt(System.String)
		/// </summary>
		protected static RMethod r_MGetGlobalInt_String;
		public static RMethod RMGetGlobalInt_String
		{
			get
			{
				if(r_MGetGlobalInt_String == null)
				{
					r_MGetGlobalInt_String = new(typeof(UnityEngine.Shader), "GetGlobalInt", 0, typeof(System.String));
					r_MGetGlobalInt_String.SetBelong(null);
				}
				return r_MGetGlobalInt_String;
			}
		}

		/// <summary>
		/// Int32 GetGlobalInt(Int32)
		/// </summary>
		protected static RMethod r_MGetGlobalInt_Int32;
		public static RMethod RMGetGlobalInt_Int32
		{
			get
			{
				if(r_MGetGlobalInt_Int32 == null)
				{
					r_MGetGlobalInt_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalInt", 0, typeof(System.Int32));
					r_MGetGlobalInt_Int32.SetBelong(null);
				}
				return r_MGetGlobalInt_Int32;
			}
		}

		/// <summary>
		/// Single GetGlobalFloat(System.String)
		/// </summary>
		protected static RMethod r_MGetGlobalFloat_String;
		public static RMethod RMGetGlobalFloat_String
		{
			get
			{
				if(r_MGetGlobalFloat_String == null)
				{
					r_MGetGlobalFloat_String = new(typeof(UnityEngine.Shader), "GetGlobalFloat", 0, typeof(System.String));
					r_MGetGlobalFloat_String.SetBelong(null);
				}
				return r_MGetGlobalFloat_String;
			}
		}

		/// <summary>
		/// Single GetGlobalFloat(Int32)
		/// </summary>
		protected static RMethod r_MGetGlobalFloat_Int32;
		public static RMethod RMGetGlobalFloat_Int32
		{
			get
			{
				if(r_MGetGlobalFloat_Int32 == null)
				{
					r_MGetGlobalFloat_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalFloat", 0, typeof(System.Int32));
					r_MGetGlobalFloat_Int32.SetBelong(null);
				}
				return r_MGetGlobalFloat_Int32;
			}
		}

		/// <summary>
		/// Int32 GetGlobalInteger(System.String)
		/// </summary>
		protected static RMethod r_MGetGlobalInteger_String;
		public static RMethod RMGetGlobalInteger_String
		{
			get
			{
				if(r_MGetGlobalInteger_String == null)
				{
					r_MGetGlobalInteger_String = new(typeof(UnityEngine.Shader), "GetGlobalInteger", 0, typeof(System.String));
					r_MGetGlobalInteger_String.SetBelong(null);
				}
				return r_MGetGlobalInteger_String;
			}
		}

		/// <summary>
		/// Int32 GetGlobalInteger(Int32)
		/// </summary>
		protected static RMethod r_MGetGlobalInteger_Int32;
		public static RMethod RMGetGlobalInteger_Int32
		{
			get
			{
				if(r_MGetGlobalInteger_Int32 == null)
				{
					r_MGetGlobalInteger_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalInteger", 0, typeof(System.Int32));
					r_MGetGlobalInteger_Int32.SetBelong(null);
				}
				return r_MGetGlobalInteger_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 GetGlobalVector(System.String)
		/// </summary>
		protected static RMethod r_MGetGlobalVector_String;
		public static RMethod RMGetGlobalVector_String
		{
			get
			{
				if(r_MGetGlobalVector_String == null)
				{
					r_MGetGlobalVector_String = new(typeof(UnityEngine.Shader), "GetGlobalVector", 0, typeof(System.String));
					r_MGetGlobalVector_String.SetBelong(null);
				}
				return r_MGetGlobalVector_String;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 GetGlobalVector(Int32)
		/// </summary>
		protected static RMethod r_MGetGlobalVector_Int32;
		public static RMethod RMGetGlobalVector_Int32
		{
			get
			{
				if(r_MGetGlobalVector_Int32 == null)
				{
					r_MGetGlobalVector_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalVector", 0, typeof(System.Int32));
					r_MGetGlobalVector_Int32.SetBelong(null);
				}
				return r_MGetGlobalVector_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetGlobalColor(System.String)
		/// </summary>
		protected static RMethod r_MGetGlobalColor_String;
		public static RMethod RMGetGlobalColor_String
		{
			get
			{
				if(r_MGetGlobalColor_String == null)
				{
					r_MGetGlobalColor_String = new(typeof(UnityEngine.Shader), "GetGlobalColor", 0, typeof(System.String));
					r_MGetGlobalColor_String.SetBelong(null);
				}
				return r_MGetGlobalColor_String;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetGlobalColor(Int32)
		/// </summary>
		protected static RMethod r_MGetGlobalColor_Int32;
		public static RMethod RMGetGlobalColor_Int32
		{
			get
			{
				if(r_MGetGlobalColor_Int32 == null)
				{
					r_MGetGlobalColor_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalColor", 0, typeof(System.Int32));
					r_MGetGlobalColor_Int32.SetBelong(null);
				}
				return r_MGetGlobalColor_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 GetGlobalMatrix(System.String)
		/// </summary>
		protected static RMethod r_MGetGlobalMatrix_String;
		public static RMethod RMGetGlobalMatrix_String
		{
			get
			{
				if(r_MGetGlobalMatrix_String == null)
				{
					r_MGetGlobalMatrix_String = new(typeof(UnityEngine.Shader), "GetGlobalMatrix", 0, typeof(System.String));
					r_MGetGlobalMatrix_String.SetBelong(null);
				}
				return r_MGetGlobalMatrix_String;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 GetGlobalMatrix(Int32)
		/// </summary>
		protected static RMethod r_MGetGlobalMatrix_Int32;
		public static RMethod RMGetGlobalMatrix_Int32
		{
			get
			{
				if(r_MGetGlobalMatrix_Int32 == null)
				{
					r_MGetGlobalMatrix_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalMatrix", 0, typeof(System.Int32));
					r_MGetGlobalMatrix_Int32.SetBelong(null);
				}
				return r_MGetGlobalMatrix_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Texture GetGlobalTexture(System.String)
		/// </summary>
		protected static RMethod r_MGetGlobalTexture_String;
		public static RMethod RMGetGlobalTexture_String
		{
			get
			{
				if(r_MGetGlobalTexture_String == null)
				{
					r_MGetGlobalTexture_String = new(typeof(UnityEngine.Shader), "GetGlobalTexture", 0, typeof(System.String));
					r_MGetGlobalTexture_String.SetBelong(null);
				}
				return r_MGetGlobalTexture_String;
			}
		}

		/// <summary>
		/// UnityEngine.Texture GetGlobalTexture(Int32)
		/// </summary>
		protected static RMethod r_MGetGlobalTexture_Int32;
		public static RMethod RMGetGlobalTexture_Int32
		{
			get
			{
				if(r_MGetGlobalTexture_Int32 == null)
				{
					r_MGetGlobalTexture_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalTexture", 0, typeof(System.Int32));
					r_MGetGlobalTexture_Int32.SetBelong(null);
				}
				return r_MGetGlobalTexture_Int32;
			}
		}

		/// <summary>
		/// Single[] GetGlobalFloatArray(System.String)
		/// </summary>
		protected static RMethod r_MGetGlobalFloatArray_String;
		public static RMethod RMGetGlobalFloatArray_String
		{
			get
			{
				if(r_MGetGlobalFloatArray_String == null)
				{
					r_MGetGlobalFloatArray_String = new(typeof(UnityEngine.Shader), "GetGlobalFloatArray", 0, typeof(System.String));
					r_MGetGlobalFloatArray_String.SetBelong(null);
				}
				return r_MGetGlobalFloatArray_String;
			}
		}

		/// <summary>
		/// Single[] GetGlobalFloatArray(Int32)
		/// </summary>
		protected static RMethod r_MGetGlobalFloatArray_Int32;
		public static RMethod RMGetGlobalFloatArray_Int32
		{
			get
			{
				if(r_MGetGlobalFloatArray_Int32 == null)
				{
					r_MGetGlobalFloatArray_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalFloatArray", 0, typeof(System.Int32));
					r_MGetGlobalFloatArray_Int32.SetBelong(null);
				}
				return r_MGetGlobalFloatArray_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4[] GetGlobalVectorArray(System.String)
		/// </summary>
		protected static RMethod r_MGetGlobalVectorArray_String;
		public static RMethod RMGetGlobalVectorArray_String
		{
			get
			{
				if(r_MGetGlobalVectorArray_String == null)
				{
					r_MGetGlobalVectorArray_String = new(typeof(UnityEngine.Shader), "GetGlobalVectorArray", 0, typeof(System.String));
					r_MGetGlobalVectorArray_String.SetBelong(null);
				}
				return r_MGetGlobalVectorArray_String;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4[] GetGlobalVectorArray(Int32)
		/// </summary>
		protected static RMethod r_MGetGlobalVectorArray_Int32;
		public static RMethod RMGetGlobalVectorArray_Int32
		{
			get
			{
				if(r_MGetGlobalVectorArray_Int32 == null)
				{
					r_MGetGlobalVectorArray_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalVectorArray", 0, typeof(System.Int32));
					r_MGetGlobalVectorArray_Int32.SetBelong(null);
				}
				return r_MGetGlobalVectorArray_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4[] GetGlobalMatrixArray(System.String)
		/// </summary>
		protected static RMethod r_MGetGlobalMatrixArray_String;
		public static RMethod RMGetGlobalMatrixArray_String
		{
			get
			{
				if(r_MGetGlobalMatrixArray_String == null)
				{
					r_MGetGlobalMatrixArray_String = new(typeof(UnityEngine.Shader), "GetGlobalMatrixArray", 0, typeof(System.String));
					r_MGetGlobalMatrixArray_String.SetBelong(null);
				}
				return r_MGetGlobalMatrixArray_String;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4[] GetGlobalMatrixArray(Int32)
		/// </summary>
		protected static RMethod r_MGetGlobalMatrixArray_Int32;
		public static RMethod RMGetGlobalMatrixArray_Int32
		{
			get
			{
				if(r_MGetGlobalMatrixArray_Int32 == null)
				{
					r_MGetGlobalMatrixArray_Int32 = new(typeof(UnityEngine.Shader), "GetGlobalMatrixArray", 0, typeof(System.Int32));
					r_MGetGlobalMatrixArray_Int32.SetBelong(null);
				}
				return r_MGetGlobalMatrixArray_Int32;
			}
		}

		/// <summary>
		/// Void GetGlobalFloatArray(System.String, System.Collections.Generic.List`1[System.Single])
		/// </summary>
		protected static RMethod r_MGetGlobalFloatArray_String_List_d_Single_p_;
		public static RMethod RMGetGlobalFloatArray_String_List_d_Single_p_
		{
			get
			{
				if(r_MGetGlobalFloatArray_String_List_d_Single_p_ == null)
				{
					r_MGetGlobalFloatArray_String_List_d_Single_p_ = new(typeof(UnityEngine.Shader), "GetGlobalFloatArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Single)));
					r_MGetGlobalFloatArray_String_List_d_Single_p_.SetBelong(null);
				}
				return r_MGetGlobalFloatArray_String_List_d_Single_p_;
			}
		}

		/// <summary>
		/// Void GetGlobalFloatArray(Int32, System.Collections.Generic.List`1[System.Single])
		/// </summary>
		protected static RMethod r_MGetGlobalFloatArray_Int32_List_d_Single_p_;
		public static RMethod RMGetGlobalFloatArray_Int32_List_d_Single_p_
		{
			get
			{
				if(r_MGetGlobalFloatArray_Int32_List_d_Single_p_ == null)
				{
					r_MGetGlobalFloatArray_Int32_List_d_Single_p_ = new(typeof(UnityEngine.Shader), "GetGlobalFloatArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Single)));
					r_MGetGlobalFloatArray_Int32_List_d_Single_p_.SetBelong(null);
				}
				return r_MGetGlobalFloatArray_Int32_List_d_Single_p_;
			}
		}

		/// <summary>
		/// Void GetGlobalVectorArray(System.String, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected static RMethod r_MGetGlobalVectorArray_String_List_d_Vector4_p_;
		public static RMethod RMGetGlobalVectorArray_String_List_d_Vector4_p_
		{
			get
			{
				if(r_MGetGlobalVectorArray_String_List_d_Vector4_p_ == null)
				{
					r_MGetGlobalVectorArray_String_List_d_Vector4_p_ = new(typeof(UnityEngine.Shader), "GetGlobalVectorArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_MGetGlobalVectorArray_String_List_d_Vector4_p_.SetBelong(null);
				}
				return r_MGetGlobalVectorArray_String_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void GetGlobalVectorArray(Int32, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected static RMethod r_MGetGlobalVectorArray_Int32_List_d_Vector4_p_;
		public static RMethod RMGetGlobalVectorArray_Int32_List_d_Vector4_p_
		{
			get
			{
				if(r_MGetGlobalVectorArray_Int32_List_d_Vector4_p_ == null)
				{
					r_MGetGlobalVectorArray_Int32_List_d_Vector4_p_ = new(typeof(UnityEngine.Shader), "GetGlobalVectorArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_MGetGlobalVectorArray_Int32_List_d_Vector4_p_.SetBelong(null);
				}
				return r_MGetGlobalVectorArray_Int32_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void GetGlobalMatrixArray(System.String, System.Collections.Generic.List`1[UnityEngine.Matrix4x4])
		/// </summary>
		protected static RMethod r_MGetGlobalMatrixArray_String_List_d_Matrix4x4_p_;
		public static RMethod RMGetGlobalMatrixArray_String_List_d_Matrix4x4_p_
		{
			get
			{
				if(r_MGetGlobalMatrixArray_String_List_d_Matrix4x4_p_ == null)
				{
					r_MGetGlobalMatrixArray_String_List_d_Matrix4x4_p_ = new(typeof(UnityEngine.Shader), "GetGlobalMatrixArray", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Matrix4x4)));
					r_MGetGlobalMatrixArray_String_List_d_Matrix4x4_p_.SetBelong(null);
				}
				return r_MGetGlobalMatrixArray_String_List_d_Matrix4x4_p_;
			}
		}

		/// <summary>
		/// Void GetGlobalMatrixArray(Int32, System.Collections.Generic.List`1[UnityEngine.Matrix4x4])
		/// </summary>
		protected static RMethod r_MGetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_;
		public static RMethod RMGetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_
		{
			get
			{
				if(r_MGetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_ == null)
				{
					r_MGetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_ = new(typeof(UnityEngine.Shader), "GetGlobalMatrixArray", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Matrix4x4)));
					r_MGetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_.SetBelong(null);
				}
				return r_MGetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_;
			}
		}

		/// <summary>
		/// System.String GetPropertyName(UnityEngine.Shader, Int32)
		/// </summary>
		protected static RMethod r_MGetPropertyName_Shader_Int32;
		public static RMethod RMGetPropertyName_Shader_Int32
		{
			get
			{
				if(r_MGetPropertyName_Shader_Int32 == null)
				{
					r_MGetPropertyName_Shader_Int32 = new(typeof(UnityEngine.Shader), "GetPropertyName", 0, typeof(UnityEngine.Shader), typeof(System.Int32));
					r_MGetPropertyName_Shader_Int32.SetBelong(null);
				}
				return r_MGetPropertyName_Shader_Int32;
			}
		}

		/// <summary>
		/// Int32 GetPropertyNameId(UnityEngine.Shader, Int32)
		/// </summary>
		protected static RMethod r_MGetPropertyNameId_Shader_Int32;
		public static RMethod RMGetPropertyNameId_Shader_Int32
		{
			get
			{
				if(r_MGetPropertyNameId_Shader_Int32 == null)
				{
					r_MGetPropertyNameId_Shader_Int32 = new(typeof(UnityEngine.Shader), "GetPropertyNameId", 0, typeof(UnityEngine.Shader), typeof(System.Int32));
					r_MGetPropertyNameId_Shader_Int32.SetBelong(null);
				}
				return r_MGetPropertyNameId_Shader_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ShaderPropertyType GetPropertyType(UnityEngine.Shader, Int32)
		/// </summary>
		protected static RMethod r_MGetPropertyType_Shader_Int32;
		public static RMethod RMGetPropertyType_Shader_Int32
		{
			get
			{
				if(r_MGetPropertyType_Shader_Int32 == null)
				{
					r_MGetPropertyType_Shader_Int32 = new(typeof(UnityEngine.Shader), "GetPropertyType", 0, typeof(UnityEngine.Shader), typeof(System.Int32));
					r_MGetPropertyType_Shader_Int32.SetBelong(null);
				}
				return r_MGetPropertyType_Shader_Int32;
			}
		}

		/// <summary>
		/// System.String GetPropertyDescription(UnityEngine.Shader, Int32)
		/// </summary>
		protected static RMethod r_MGetPropertyDescription_Shader_Int32;
		public static RMethod RMGetPropertyDescription_Shader_Int32
		{
			get
			{
				if(r_MGetPropertyDescription_Shader_Int32 == null)
				{
					r_MGetPropertyDescription_Shader_Int32 = new(typeof(UnityEngine.Shader), "GetPropertyDescription", 0, typeof(UnityEngine.Shader), typeof(System.Int32));
					r_MGetPropertyDescription_Shader_Int32.SetBelong(null);
				}
				return r_MGetPropertyDescription_Shader_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ShaderPropertyFlags GetPropertyFlags(UnityEngine.Shader, Int32)
		/// </summary>
		protected static RMethod r_MGetPropertyFlags_Shader_Int32;
		public static RMethod RMGetPropertyFlags_Shader_Int32
		{
			get
			{
				if(r_MGetPropertyFlags_Shader_Int32 == null)
				{
					r_MGetPropertyFlags_Shader_Int32 = new(typeof(UnityEngine.Shader), "GetPropertyFlags", 0, typeof(UnityEngine.Shader), typeof(System.Int32));
					r_MGetPropertyFlags_Shader_Int32.SetBelong(null);
				}
				return r_MGetPropertyFlags_Shader_Int32;
			}
		}

		/// <summary>
		/// System.String[] GetPropertyAttributes(UnityEngine.Shader, Int32)
		/// </summary>
		protected static RMethod r_MGetPropertyAttributes_Shader_Int32;
		public static RMethod RMGetPropertyAttributes_Shader_Int32
		{
			get
			{
				if(r_MGetPropertyAttributes_Shader_Int32 == null)
				{
					r_MGetPropertyAttributes_Shader_Int32 = new(typeof(UnityEngine.Shader), "GetPropertyAttributes", 0, typeof(UnityEngine.Shader), typeof(System.Int32));
					r_MGetPropertyAttributes_Shader_Int32.SetBelong(null);
				}
				return r_MGetPropertyAttributes_Shader_Int32;
			}
		}

		/// <summary>
		/// Int32 GetPropertyDefaultIntValue(UnityEngine.Shader, Int32)
		/// </summary>
		protected static RMethod r_MGetPropertyDefaultIntValue_Shader_Int32;
		public static RMethod RMGetPropertyDefaultIntValue_Shader_Int32
		{
			get
			{
				if(r_MGetPropertyDefaultIntValue_Shader_Int32 == null)
				{
					r_MGetPropertyDefaultIntValue_Shader_Int32 = new(typeof(UnityEngine.Shader), "GetPropertyDefaultIntValue", 0, typeof(UnityEngine.Shader), typeof(System.Int32));
					r_MGetPropertyDefaultIntValue_Shader_Int32.SetBelong(null);
				}
				return r_MGetPropertyDefaultIntValue_Shader_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 GetPropertyDefaultValue(UnityEngine.Shader, Int32)
		/// </summary>
		protected static RMethod r_MGetPropertyDefaultValue_Shader_Int32;
		public static RMethod RMGetPropertyDefaultValue_Shader_Int32
		{
			get
			{
				if(r_MGetPropertyDefaultValue_Shader_Int32 == null)
				{
					r_MGetPropertyDefaultValue_Shader_Int32 = new(typeof(UnityEngine.Shader), "GetPropertyDefaultValue", 0, typeof(UnityEngine.Shader), typeof(System.Int32));
					r_MGetPropertyDefaultValue_Shader_Int32.SetBelong(null);
				}
				return r_MGetPropertyDefaultValue_Shader_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.TextureDimension GetPropertyTextureDimension(UnityEngine.Shader, Int32)
		/// </summary>
		protected static RMethod r_MGetPropertyTextureDimension_Shader_Int32;
		public static RMethod RMGetPropertyTextureDimension_Shader_Int32
		{
			get
			{
				if(r_MGetPropertyTextureDimension_Shader_Int32 == null)
				{
					r_MGetPropertyTextureDimension_Shader_Int32 = new(typeof(UnityEngine.Shader), "GetPropertyTextureDimension", 0, typeof(UnityEngine.Shader), typeof(System.Int32));
					r_MGetPropertyTextureDimension_Shader_Int32.SetBelong(null);
				}
				return r_MGetPropertyTextureDimension_Shader_Int32;
			}
		}

		/// <summary>
		/// System.String GetPropertyTextureDefaultName(UnityEngine.Shader, Int32)
		/// </summary>
		protected static RMethod r_MGetPropertyTextureDefaultName_Shader_Int32;
		public static RMethod RMGetPropertyTextureDefaultName_Shader_Int32
		{
			get
			{
				if(r_MGetPropertyTextureDefaultName_Shader_Int32 == null)
				{
					r_MGetPropertyTextureDefaultName_Shader_Int32 = new(typeof(UnityEngine.Shader), "GetPropertyTextureDefaultName", 0, typeof(UnityEngine.Shader), typeof(System.Int32));
					r_MGetPropertyTextureDefaultName_Shader_Int32.SetBelong(null);
				}
				return r_MGetPropertyTextureDefaultName_Shader_Int32;
			}
		}

		/// <summary>
		/// Boolean FindTextureStackImpl(UnityEngine.Shader, Int32, System.String ByRef, Int32 ByRef)
		/// </summary>
		protected static RMethod r_MFindTextureStackImpl_Shader_Int32_Out_String_Out_Int32;
		public static RMethod RMFindTextureStackImpl_Shader_Int32_Out_String_Out_Int32
		{
			get
			{
				if(r_MFindTextureStackImpl_Shader_Int32_Out_String_Out_Int32 == null)
				{
					r_MFindTextureStackImpl_Shader_Int32_Out_String_Out_Int32 = new(typeof(UnityEngine.Shader), "FindTextureStackImpl", 0, typeof(UnityEngine.Shader), typeof(System.Int32), typeof(System.String).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_MFindTextureStackImpl_Shader_Int32_Out_String_Out_Int32.SetBelong(null);
				}
				return r_MFindTextureStackImpl_Shader_Int32_Out_String_Out_Int32;
			}
		}

		/// <summary>
		/// Void CheckPropertyIndex(UnityEngine.Shader, Int32)
		/// </summary>
		protected static RMethod r_MCheckPropertyIndex_Shader_Int32;
		public static RMethod RMCheckPropertyIndex_Shader_Int32
		{
			get
			{
				if(r_MCheckPropertyIndex_Shader_Int32 == null)
				{
					r_MCheckPropertyIndex_Shader_Int32 = new(typeof(UnityEngine.Shader), "CheckPropertyIndex", 0, typeof(UnityEngine.Shader), typeof(System.Int32));
					r_MCheckPropertyIndex_Shader_Int32.SetBelong(null);
				}
				return r_MCheckPropertyIndex_Shader_Int32;
			}
		}

		/// <summary>
		/// Int32 GetPropertyCount()
		/// </summary>
		protected RMethod r_MGetPropertyCount;
		public virtual RMethod RMGetPropertyCount
		{
			get
			{
				if(r_MGetPropertyCount == null)
				{
					r_MGetPropertyCount = new(this, "GetPropertyCount", 0);
					r_MGetPropertyCount.SetBelong(this.instance);
				}
				return r_MGetPropertyCount;
			}
		}

		/// <summary>
		/// Int32 FindPropertyIndex(System.String)
		/// </summary>
		protected RMethod r_MFindPropertyIndex_String;
		public virtual RMethod RMFindPropertyIndex_String
		{
			get
			{
				if(r_MFindPropertyIndex_String == null)
				{
					r_MFindPropertyIndex_String = new(this, "FindPropertyIndex", 0, typeof(System.String));
					r_MFindPropertyIndex_String.SetBelong(this.instance);
				}
				return r_MFindPropertyIndex_String;
			}
		}

		/// <summary>
		/// System.String GetPropertyName(Int32)
		/// </summary>
		protected RMethod r_MGetPropertyName_Int32;
		public virtual RMethod RMGetPropertyName_Int32
		{
			get
			{
				if(r_MGetPropertyName_Int32 == null)
				{
					r_MGetPropertyName_Int32 = new(this, "GetPropertyName", 0, typeof(System.Int32));
					r_MGetPropertyName_Int32.SetBelong(this.instance);
				}
				return r_MGetPropertyName_Int32;
			}
		}

		/// <summary>
		/// Int32 GetPropertyNameId(Int32)
		/// </summary>
		protected RMethod r_MGetPropertyNameId_Int32;
		public virtual RMethod RMGetPropertyNameId_Int32
		{
			get
			{
				if(r_MGetPropertyNameId_Int32 == null)
				{
					r_MGetPropertyNameId_Int32 = new(this, "GetPropertyNameId", 0, typeof(System.Int32));
					r_MGetPropertyNameId_Int32.SetBelong(this.instance);
				}
				return r_MGetPropertyNameId_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ShaderPropertyType GetPropertyType(Int32)
		/// </summary>
		protected RMethod r_MGetPropertyType_Int32;
		public virtual RMethod RMGetPropertyType_Int32
		{
			get
			{
				if(r_MGetPropertyType_Int32 == null)
				{
					r_MGetPropertyType_Int32 = new(this, "GetPropertyType", 0, typeof(System.Int32));
					r_MGetPropertyType_Int32.SetBelong(this.instance);
				}
				return r_MGetPropertyType_Int32;
			}
		}

		/// <summary>
		/// System.String GetPropertyDescription(Int32)
		/// </summary>
		protected RMethod r_MGetPropertyDescription_Int32;
		public virtual RMethod RMGetPropertyDescription_Int32
		{
			get
			{
				if(r_MGetPropertyDescription_Int32 == null)
				{
					r_MGetPropertyDescription_Int32 = new(this, "GetPropertyDescription", 0, typeof(System.Int32));
					r_MGetPropertyDescription_Int32.SetBelong(this.instance);
				}
				return r_MGetPropertyDescription_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ShaderPropertyFlags GetPropertyFlags(Int32)
		/// </summary>
		protected RMethod r_MGetPropertyFlags_Int32;
		public virtual RMethod RMGetPropertyFlags_Int32
		{
			get
			{
				if(r_MGetPropertyFlags_Int32 == null)
				{
					r_MGetPropertyFlags_Int32 = new(this, "GetPropertyFlags", 0, typeof(System.Int32));
					r_MGetPropertyFlags_Int32.SetBelong(this.instance);
				}
				return r_MGetPropertyFlags_Int32;
			}
		}

		/// <summary>
		/// System.String[] GetPropertyAttributes(Int32)
		/// </summary>
		protected RMethod r_MGetPropertyAttributes_Int32;
		public virtual RMethod RMGetPropertyAttributes_Int32
		{
			get
			{
				if(r_MGetPropertyAttributes_Int32 == null)
				{
					r_MGetPropertyAttributes_Int32 = new(this, "GetPropertyAttributes", 0, typeof(System.Int32));
					r_MGetPropertyAttributes_Int32.SetBelong(this.instance);
				}
				return r_MGetPropertyAttributes_Int32;
			}
		}

		/// <summary>
		/// Single GetPropertyDefaultFloatValue(Int32)
		/// </summary>
		protected RMethod r_MGetPropertyDefaultFloatValue_Int32;
		public virtual RMethod RMGetPropertyDefaultFloatValue_Int32
		{
			get
			{
				if(r_MGetPropertyDefaultFloatValue_Int32 == null)
				{
					r_MGetPropertyDefaultFloatValue_Int32 = new(this, "GetPropertyDefaultFloatValue", 0, typeof(System.Int32));
					r_MGetPropertyDefaultFloatValue_Int32.SetBelong(this.instance);
				}
				return r_MGetPropertyDefaultFloatValue_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 GetPropertyDefaultVectorValue(Int32)
		/// </summary>
		protected RMethod r_MGetPropertyDefaultVectorValue_Int32;
		public virtual RMethod RMGetPropertyDefaultVectorValue_Int32
		{
			get
			{
				if(r_MGetPropertyDefaultVectorValue_Int32 == null)
				{
					r_MGetPropertyDefaultVectorValue_Int32 = new(this, "GetPropertyDefaultVectorValue", 0, typeof(System.Int32));
					r_MGetPropertyDefaultVectorValue_Int32.SetBelong(this.instance);
				}
				return r_MGetPropertyDefaultVectorValue_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetPropertyRangeLimits(Int32)
		/// </summary>
		protected RMethod r_MGetPropertyRangeLimits_Int32;
		public virtual RMethod RMGetPropertyRangeLimits_Int32
		{
			get
			{
				if(r_MGetPropertyRangeLimits_Int32 == null)
				{
					r_MGetPropertyRangeLimits_Int32 = new(this, "GetPropertyRangeLimits", 0, typeof(System.Int32));
					r_MGetPropertyRangeLimits_Int32.SetBelong(this.instance);
				}
				return r_MGetPropertyRangeLimits_Int32;
			}
		}

		/// <summary>
		/// Int32 GetPropertyDefaultIntValue(Int32)
		/// </summary>
		protected RMethod r_MGetPropertyDefaultIntValue_Int32;
		public virtual RMethod RMGetPropertyDefaultIntValue_Int32
		{
			get
			{
				if(r_MGetPropertyDefaultIntValue_Int32 == null)
				{
					r_MGetPropertyDefaultIntValue_Int32 = new(this, "GetPropertyDefaultIntValue", 0, typeof(System.Int32));
					r_MGetPropertyDefaultIntValue_Int32.SetBelong(this.instance);
				}
				return r_MGetPropertyDefaultIntValue_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.TextureDimension GetPropertyTextureDimension(Int32)
		/// </summary>
		protected RMethod r_MGetPropertyTextureDimension_Int32;
		public virtual RMethod RMGetPropertyTextureDimension_Int32
		{
			get
			{
				if(r_MGetPropertyTextureDimension_Int32 == null)
				{
					r_MGetPropertyTextureDimension_Int32 = new(this, "GetPropertyTextureDimension", 0, typeof(System.Int32));
					r_MGetPropertyTextureDimension_Int32.SetBelong(this.instance);
				}
				return r_MGetPropertyTextureDimension_Int32;
			}
		}

		/// <summary>
		/// System.String GetPropertyTextureDefaultName(Int32)
		/// </summary>
		protected RMethod r_MGetPropertyTextureDefaultName_Int32;
		public virtual RMethod RMGetPropertyTextureDefaultName_Int32
		{
			get
			{
				if(r_MGetPropertyTextureDefaultName_Int32 == null)
				{
					r_MGetPropertyTextureDefaultName_Int32 = new(this, "GetPropertyTextureDefaultName", 0, typeof(System.Int32));
					r_MGetPropertyTextureDefaultName_Int32.SetBelong(this.instance);
				}
				return r_MGetPropertyTextureDefaultName_Int32;
			}
		}

		/// <summary>
		/// Boolean FindTextureStack(Int32, System.String ByRef, Int32 ByRef)
		/// </summary>
		protected RMethod r_MFindTextureStack_Int32_Out_String_Out_Int32;
		public virtual RMethod RMFindTextureStack_Int32_Out_String_Out_Int32
		{
			get
			{
				if(r_MFindTextureStack_Int32_Out_String_Out_Int32 == null)
				{
					r_MFindTextureStack_Int32_Out_String_Out_Int32 = new(this, "FindTextureStack", 0, typeof(System.Int32), typeof(System.String).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_MFindTextureStack_Int32_Out_String_Out_Int32.SetBelong(this.instance);
				}
				return r_MFindTextureStack_Int32_Out_String_Out_Int32;
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
		/// Void EnableKeywordFast_Injected(UnityEngine.Rendering.GlobalKeyword ByRef)
		/// </summary>
		protected static RMethod r_MEnableKeywordFast_Injected_Ref_GlobalKeyword;
		public static RMethod RMEnableKeywordFast_Injected_Ref_GlobalKeyword
		{
			get
			{
				if(r_MEnableKeywordFast_Injected_Ref_GlobalKeyword == null)
				{
					r_MEnableKeywordFast_Injected_Ref_GlobalKeyword = new(typeof(UnityEngine.Shader), "EnableKeywordFast_Injected", 0, typeof(UnityEngine.Rendering.GlobalKeyword).MakeByRefType());
					r_MEnableKeywordFast_Injected_Ref_GlobalKeyword.SetBelong(null);
				}
				return r_MEnableKeywordFast_Injected_Ref_GlobalKeyword;
			}
		}

		/// <summary>
		/// Void DisableKeywordFast_Injected(UnityEngine.Rendering.GlobalKeyword ByRef)
		/// </summary>
		protected static RMethod r_MDisableKeywordFast_Injected_Ref_GlobalKeyword;
		public static RMethod RMDisableKeywordFast_Injected_Ref_GlobalKeyword
		{
			get
			{
				if(r_MDisableKeywordFast_Injected_Ref_GlobalKeyword == null)
				{
					r_MDisableKeywordFast_Injected_Ref_GlobalKeyword = new(typeof(UnityEngine.Shader), "DisableKeywordFast_Injected", 0, typeof(UnityEngine.Rendering.GlobalKeyword).MakeByRefType());
					r_MDisableKeywordFast_Injected_Ref_GlobalKeyword.SetBelong(null);
				}
				return r_MDisableKeywordFast_Injected_Ref_GlobalKeyword;
			}
		}

		/// <summary>
		/// Void SetKeywordFast_Injected(UnityEngine.Rendering.GlobalKeyword ByRef, Boolean)
		/// </summary>
		protected static RMethod r_MSetKeywordFast_Injected_Ref_GlobalKeyword_Boolean;
		public static RMethod RMSetKeywordFast_Injected_Ref_GlobalKeyword_Boolean
		{
			get
			{
				if(r_MSetKeywordFast_Injected_Ref_GlobalKeyword_Boolean == null)
				{
					r_MSetKeywordFast_Injected_Ref_GlobalKeyword_Boolean = new(typeof(UnityEngine.Shader), "SetKeywordFast_Injected", 0, typeof(UnityEngine.Rendering.GlobalKeyword).MakeByRefType(), typeof(System.Boolean));
					r_MSetKeywordFast_Injected_Ref_GlobalKeyword_Boolean.SetBelong(null);
				}
				return r_MSetKeywordFast_Injected_Ref_GlobalKeyword_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsKeywordEnabledFast_Injected(UnityEngine.Rendering.GlobalKeyword ByRef)
		/// </summary>
		protected static RMethod r_MIsKeywordEnabledFast_Injected_Ref_GlobalKeyword;
		public static RMethod RMIsKeywordEnabledFast_Injected_Ref_GlobalKeyword
		{
			get
			{
				if(r_MIsKeywordEnabledFast_Injected_Ref_GlobalKeyword == null)
				{
					r_MIsKeywordEnabledFast_Injected_Ref_GlobalKeyword = new(typeof(UnityEngine.Shader), "IsKeywordEnabledFast_Injected", 0, typeof(UnityEngine.Rendering.GlobalKeyword).MakeByRefType());
					r_MIsKeywordEnabledFast_Injected_Ref_GlobalKeyword.SetBelong(null);
				}
				return r_MIsKeywordEnabledFast_Injected_Ref_GlobalKeyword;
			}
		}

		/// <summary>
		/// Void SetGlobalVectorImpl_Injected(Int32, UnityEngine.Vector4 ByRef)
		/// </summary>
		protected static RMethod r_MSetGlobalVectorImpl_Injected_Int32_Ref_Vector4;
		public static RMethod RMSetGlobalVectorImpl_Injected_Int32_Ref_Vector4
		{
			get
			{
				if(r_MSetGlobalVectorImpl_Injected_Int32_Ref_Vector4 == null)
				{
					r_MSetGlobalVectorImpl_Injected_Int32_Ref_Vector4 = new(typeof(UnityEngine.Shader), "SetGlobalVectorImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeByRefType());
					r_MSetGlobalVectorImpl_Injected_Int32_Ref_Vector4.SetBelong(null);
				}
				return r_MSetGlobalVectorImpl_Injected_Int32_Ref_Vector4;
			}
		}

		/// <summary>
		/// Void SetGlobalMatrixImpl_Injected(Int32, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected static RMethod r_MSetGlobalMatrixImpl_Injected_Int32_Ref_Matrix4x4;
		public static RMethod RMSetGlobalMatrixImpl_Injected_Int32_Ref_Matrix4x4
		{
			get
			{
				if(r_MSetGlobalMatrixImpl_Injected_Int32_Ref_Matrix4x4 == null)
				{
					r_MSetGlobalMatrixImpl_Injected_Int32_Ref_Matrix4x4 = new(typeof(UnityEngine.Shader), "SetGlobalMatrixImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_MSetGlobalMatrixImpl_Injected_Int32_Ref_Matrix4x4.SetBelong(null);
				}
				return r_MSetGlobalMatrixImpl_Injected_Int32_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Void GetGlobalVectorImpl_Injected(Int32, UnityEngine.Vector4 ByRef)
		/// </summary>
		protected static RMethod r_MGetGlobalVectorImpl_Injected_Int32_Out_Vector4;
		public static RMethod RMGetGlobalVectorImpl_Injected_Int32_Out_Vector4
		{
			get
			{
				if(r_MGetGlobalVectorImpl_Injected_Int32_Out_Vector4 == null)
				{
					r_MGetGlobalVectorImpl_Injected_Int32_Out_Vector4 = new(typeof(UnityEngine.Shader), "GetGlobalVectorImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeByRefType());
					r_MGetGlobalVectorImpl_Injected_Int32_Out_Vector4.SetBelong(null);
				}
				return r_MGetGlobalVectorImpl_Injected_Int32_Out_Vector4;
			}
		}

		/// <summary>
		/// Void GetGlobalMatrixImpl_Injected(Int32, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected static RMethod r_MGetGlobalMatrixImpl_Injected_Int32_Out_Matrix4x4;
		public static RMethod RMGetGlobalMatrixImpl_Injected_Int32_Out_Matrix4x4
		{
			get
			{
				if(r_MGetGlobalMatrixImpl_Injected_Int32_Out_Matrix4x4 == null)
				{
					r_MGetGlobalMatrixImpl_Injected_Int32_Out_Matrix4x4 = new(typeof(UnityEngine.Shader), "GetGlobalMatrixImpl_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_MGetGlobalMatrixImpl_Injected_Int32_Out_Matrix4x4.SetBelong(null);
				}
				return r_MGetGlobalMatrixImpl_Injected_Int32_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void GetPropertyDefaultValue_Injected(UnityEngine.Shader, Int32, UnityEngine.Vector4 ByRef)
		/// </summary>
		protected static RMethod r_MGetPropertyDefaultValue_Injected_Shader_Int32_Out_Vector4;
		public static RMethod RMGetPropertyDefaultValue_Injected_Shader_Int32_Out_Vector4
		{
			get
			{
				if(r_MGetPropertyDefaultValue_Injected_Shader_Int32_Out_Vector4 == null)
				{
					r_MGetPropertyDefaultValue_Injected_Shader_Int32_Out_Vector4 = new(typeof(UnityEngine.Shader), "GetPropertyDefaultValue_Injected", 0, typeof(UnityEngine.Shader), typeof(System.Int32), typeof(UnityEngine.Vector4).MakeByRefType());
					r_MGetPropertyDefaultValue_Injected_Shader_Int32_Out_Vector4.SetBelong(null);
				}
				return r_MGetPropertyDefaultValue_Injected_Shader_Int32_Out_Vector4;
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
            var ___result = RMSetGlobalTexGenMode_String_TexGenMode.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalTextureMatrixName(System.String @propertyName, System.String @matrixName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName, @matrixName};
            var ___result = RMSetGlobalTextureMatrixName_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Shader Find(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMFind_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Shader)___result;
        }


        public static UnityEngine.Shader FindBuiltin(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMFindBuiltin_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Shader)___result;
        }


        public static UnityEngine.Rendering.GlobalKeyword[] GetEnabledGlobalKeywords()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnabledGlobalKeywords.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.GlobalKeyword[])___result;
        }


        public static UnityEngine.Rendering.GlobalKeyword[] GetAllGlobalKeywords()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetAllGlobalKeywords.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.GlobalKeyword[])___result;
        }


        public static void EnableKeyword(System.String @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMEnableKeyword_String.Invoke(___genericsType, ___parameters);

            
        }


        public static void DisableKeyword(System.String @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMDisableKeyword_String.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsKeywordEnabled(System.String @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMIsKeywordEnabled_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void EnableKeywordFast(UnityEngine.Rendering.GlobalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMEnableKeywordFast_GlobalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public static void DisableKeywordFast(UnityEngine.Rendering.GlobalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMDisableKeywordFast_GlobalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetKeywordFast(UnityEngine.Rendering.GlobalKeyword @keyword, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword, @value};
            var ___result = RMSetKeywordFast_GlobalKeyword_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsKeywordEnabledFast(UnityEngine.Rendering.GlobalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMIsKeywordEnabledFast_GlobalKeyword.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void EnableKeyword(in UnityEngine.Rendering.GlobalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMEnableKeyword_In_GlobalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public static void DisableKeyword(in UnityEngine.Rendering.GlobalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMDisableKeyword_In_GlobalKeyword.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetKeyword(in UnityEngine.Rendering.GlobalKeyword @keyword, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword, @value};
            var ___result = RMSetKeyword_In_GlobalKeyword_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsKeywordEnabled(in UnityEngine.Rendering.GlobalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMIsKeywordEnabled_In_GlobalKeyword.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void WarmupAllShaders()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMWarmupAllShaders.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 TagToID(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMTagToID_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.String IDToTag(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMIDToTag_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Int32 PropertyToID(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMPropertyToID_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.Shader GetDependency(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetDependency_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Shader)___result;
        }


        public virtual System.Int32 GetPassCountInSubshader(System.Int32 @subshaderIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@subshaderIndex};
            var ___result = RMGetPassCountInSubshader_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.Rendering.ShaderTagId FindPassTagValue(System.Int32 @passIndex, UnityEngine.Rendering.ShaderTagId @tagName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@passIndex, @tagName};
            var ___result = RMFindPassTagValue_Int32_ShaderTagId.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.ShaderTagId)___result;
        }


        public virtual UnityEngine.Rendering.ShaderTagId FindPassTagValue(System.Int32 @subshaderIndex, System.Int32 @passIndex, UnityEngine.Rendering.ShaderTagId @tagName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@subshaderIndex, @passIndex, @tagName};
            var ___result = RMFindPassTagValue_Int32_Int32_ShaderTagId.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.ShaderTagId)___result;
        }


        public virtual UnityEngine.Rendering.ShaderTagId FindSubshaderTagValue(System.Int32 @subshaderIndex, UnityEngine.Rendering.ShaderTagId @tagName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@subshaderIndex, @tagName};
            var ___result = RMFindSubshaderTagValue_Int32_ShaderTagId.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.ShaderTagId)___result;
        }


        public virtual System.Int32 Internal_FindPassTagValue(System.Int32 @passIndex, System.Int32 @tagName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@passIndex, @tagName};
            var ___result = RMInternal_FindPassTagValue_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Internal_FindPassTagValueInSubShader(System.Int32 @subShaderIndex, System.Int32 @passIndex, System.Int32 @tagName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@subShaderIndex, @passIndex, @tagName};
            var ___result = RMInternal_FindPassTagValueInSubShader_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Internal_FindSubshaderTagValue(System.Int32 @subShaderIndex, System.Int32 @tagName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@subShaderIndex, @tagName};
            var ___result = RMInternal_FindSubshaderTagValue_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Internal_GetCustomEditorForRenderPipeline(System.String @renderPipelineType, out System.String @customEditor)
        {
			@customEditor = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renderPipelineType, @customEditor};
            var ___result = RMInternal_GetCustomEditorForRenderPipeline_String_Out_String.Invoke(___genericsType, ___parameters);
			@customEditor = (System.String)___parameters[1];

            
        }


        public static void SetGlobalIntImpl(System.Int32 @name, System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetGlobalIntImpl_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalFloatImpl(System.Int32 @name, System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetGlobalFloatImpl_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalVectorImpl(System.Int32 @name, UnityEngine.Vector4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetGlobalVectorImpl_Int32_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalMatrixImpl(System.Int32 @name, UnityEngine.Matrix4x4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetGlobalMatrixImpl_Int32_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalTextureImpl(System.Int32 @name, UnityEngine.Texture @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetGlobalTextureImpl_Int32_Texture.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalRenderTextureImpl(System.Int32 @name, UnityEngine.RenderTexture @value, UnityEngine.Rendering.RenderTextureSubElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value, @element};
            var ___result = RMSetGlobalRenderTextureImpl_Int32_RenderTexture_RenderTextureSubElement.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalBufferImpl(System.Int32 @name, UnityEngine.ComputeBuffer @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetGlobalBufferImpl_Int32_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalGraphicsBufferImpl(System.Int32 @name, UnityEngine.GraphicsBuffer @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetGlobalGraphicsBufferImpl_Int32_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalConstantBufferImpl(System.Int32 @name, UnityEngine.ComputeBuffer @value, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value, @offset, @size};
            var ___result = RMSetGlobalConstantBufferImpl_Int32_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalConstantGraphicsBufferImpl(System.Int32 @name, UnityEngine.GraphicsBuffer @value, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value, @offset, @size};
            var ___result = RMSetGlobalConstantGraphicsBufferImpl_Int32_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 GetGlobalIntImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetGlobalIntImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Single GetGlobalFloatImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetGlobalFloatImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static UnityEngine.Vector4 GetGlobalVectorImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetGlobalVectorImpl_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Matrix4x4 GetGlobalMatrixImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetGlobalMatrixImpl_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4)___result;
        }


        public static UnityEngine.Texture GetGlobalTextureImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetGlobalTextureImpl_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture)___result;
        }


        public static void SetGlobalFloatArrayImpl(System.Int32 @name, System.Single[] @values, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values, @count};
            var ___result = RMSetGlobalFloatArrayImpl_Int32_SingleArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalVectorArrayImpl(System.Int32 @name, UnityEngine.Vector4[] @values, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values, @count};
            var ___result = RMSetGlobalVectorArrayImpl_Int32_Vector4Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalMatrixArrayImpl(System.Int32 @name, UnityEngine.Matrix4x4[] @values, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values, @count};
            var ___result = RMSetGlobalMatrixArrayImpl_Int32_Matrix4x4Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Single[] GetGlobalFloatArrayImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetGlobalFloatArrayImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single[])___result;
        }


        public static UnityEngine.Vector4[] GetGlobalVectorArrayImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetGlobalVectorArrayImpl_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4[])___result;
        }


        public static UnityEngine.Matrix4x4[] GetGlobalMatrixArrayImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetGlobalMatrixArrayImpl_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4[])___result;
        }


        public static System.Int32 GetGlobalFloatArrayCountImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetGlobalFloatArrayCountImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 GetGlobalVectorArrayCountImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetGlobalVectorArrayCountImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 GetGlobalMatrixArrayCountImpl(System.Int32 @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetGlobalMatrixArrayCountImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static void ExtractGlobalFloatArrayImpl(System.Int32 @name, System.Single[] @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RMExtractGlobalFloatArrayImpl_Int32_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public static void ExtractGlobalVectorArrayImpl(System.Int32 @name, UnityEngine.Vector4[] @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RMExtractGlobalVectorArrayImpl_Int32_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public static void ExtractGlobalMatrixArrayImpl(System.Int32 @name, UnityEngine.Matrix4x4[] @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RMExtractGlobalMatrixArrayImpl_Int32_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalFloatArray(System.Int32 @name, System.Single[] @values, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values, @count};
            var ___result = RMSetGlobalFloatArray_Int32_SingleArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalVectorArray(System.Int32 @name, UnityEngine.Vector4[] @values, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values, @count};
            var ___result = RMSetGlobalVectorArray_Int32_Vector4Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalMatrixArray(System.Int32 @name, UnityEngine.Matrix4x4[] @values, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values, @count};
            var ___result = RMSetGlobalMatrixArray_Int32_Matrix4x4Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void ExtractGlobalFloatArray(System.Int32 @name, System.Collections.Generic.List<System.Single> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMExtractGlobalFloatArray_Int32_List_d_Single_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void ExtractGlobalVectorArray(System.Int32 @name, System.Collections.Generic.List<UnityEngine.Vector4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMExtractGlobalVectorArray_Int32_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void ExtractGlobalMatrixArray(System.Int32 @name, System.Collections.Generic.List<UnityEngine.Matrix4x4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMExtractGlobalMatrixArray_Int32_List_d_Matrix4x4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalInt(System.String @name, System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetGlobalInt_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalInt(System.Int32 @nameID, System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetGlobalInt_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalFloat(System.String @name, System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetGlobalFloat_String_Single.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalFloat(System.Int32 @nameID, System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetGlobalFloat_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalInteger(System.String @name, System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetGlobalInteger_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalInteger(System.Int32 @nameID, System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetGlobalInteger_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalVector(System.String @name, UnityEngine.Vector4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetGlobalVector_String_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalVector(System.Int32 @nameID, UnityEngine.Vector4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetGlobalVector_Int32_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalColor(System.String @name, UnityEngine.Color @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetGlobalColor_String_Color.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalColor(System.Int32 @nameID, UnityEngine.Color @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetGlobalColor_Int32_Color.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalMatrix(System.String @name, UnityEngine.Matrix4x4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetGlobalMatrix_String_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalMatrix(System.Int32 @nameID, UnityEngine.Matrix4x4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetGlobalMatrix_Int32_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalTexture(System.String @name, UnityEngine.Texture @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetGlobalTexture_String_Texture.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalTexture(System.Int32 @nameID, UnityEngine.Texture @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetGlobalTexture_Int32_Texture.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalTexture(System.String @name, UnityEngine.RenderTexture @value, UnityEngine.Rendering.RenderTextureSubElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value, @element};
            var ___result = RMSetGlobalTexture_String_RenderTexture_RenderTextureSubElement.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalTexture(System.Int32 @nameID, UnityEngine.RenderTexture @value, UnityEngine.Rendering.RenderTextureSubElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value, @element};
            var ___result = RMSetGlobalTexture_Int32_RenderTexture_RenderTextureSubElement.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalBuffer(System.String @name, UnityEngine.ComputeBuffer @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetGlobalBuffer_String_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalBuffer(System.Int32 @nameID, UnityEngine.ComputeBuffer @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetGlobalBuffer_Int32_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalBuffer(System.String @name, UnityEngine.GraphicsBuffer @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetGlobalBuffer_String_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalBuffer(System.Int32 @nameID, UnityEngine.GraphicsBuffer @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value};
            var ___result = RMSetGlobalBuffer_Int32_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalConstantBuffer(System.String @name, UnityEngine.ComputeBuffer @value, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value, @offset, @size};
            var ___result = RMSetGlobalConstantBuffer_String_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalConstantBuffer(System.Int32 @nameID, UnityEngine.ComputeBuffer @value, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value, @offset, @size};
            var ___result = RMSetGlobalConstantBuffer_Int32_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalConstantBuffer(System.String @name, UnityEngine.GraphicsBuffer @value, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value, @offset, @size};
            var ___result = RMSetGlobalConstantBuffer_String_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalConstantBuffer(System.Int32 @nameID, UnityEngine.GraphicsBuffer @value, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @value, @offset, @size};
            var ___result = RMSetGlobalConstantBuffer_Int32_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalFloatArray(System.String @name, System.Collections.Generic.List<System.Single> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMSetGlobalFloatArray_String_List_d_Single_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalFloatArray(System.Int32 @nameID, System.Collections.Generic.List<System.Single> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetGlobalFloatArray_Int32_List_d_Single_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalFloatArray(System.String @name, System.Single[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMSetGlobalFloatArray_String_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalFloatArray(System.Int32 @nameID, System.Single[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetGlobalFloatArray_Int32_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalVectorArray(System.String @name, System.Collections.Generic.List<UnityEngine.Vector4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMSetGlobalVectorArray_String_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalVectorArray(System.Int32 @nameID, System.Collections.Generic.List<UnityEngine.Vector4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetGlobalVectorArray_Int32_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalVectorArray(System.String @name, UnityEngine.Vector4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMSetGlobalVectorArray_String_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalVectorArray(System.Int32 @nameID, UnityEngine.Vector4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetGlobalVectorArray_Int32_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalMatrixArray(System.String @name, System.Collections.Generic.List<UnityEngine.Matrix4x4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMSetGlobalMatrixArray_String_List_d_Matrix4x4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalMatrixArray(System.Int32 @nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalMatrixArray(System.String @name, UnityEngine.Matrix4x4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMSetGlobalMatrixArray_String_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetGlobalMatrixArray(System.Int32 @nameID, UnityEngine.Matrix4x4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetGlobalMatrixArray_Int32_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 GetGlobalInt(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetGlobalInt_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 GetGlobalInt(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMGetGlobalInt_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Single GetGlobalFloat(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetGlobalFloat_String.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Single GetGlobalFloat(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMGetGlobalFloat_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Int32 GetGlobalInteger(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetGlobalInteger_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 GetGlobalInteger(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMGetGlobalInteger_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static UnityEngine.Vector4 GetGlobalVector(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetGlobalVector_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Vector4 GetGlobalVector(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMGetGlobalVector_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Color GetGlobalColor(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetGlobalColor_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public static UnityEngine.Color GetGlobalColor(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMGetGlobalColor_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public static UnityEngine.Matrix4x4 GetGlobalMatrix(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetGlobalMatrix_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4)___result;
        }


        public static UnityEngine.Matrix4x4 GetGlobalMatrix(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMGetGlobalMatrix_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4)___result;
        }


        public static UnityEngine.Texture GetGlobalTexture(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetGlobalTexture_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture)___result;
        }


        public static UnityEngine.Texture GetGlobalTexture(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMGetGlobalTexture_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture)___result;
        }


        public static System.Single[] GetGlobalFloatArray(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetGlobalFloatArray_String.Invoke(___genericsType, ___parameters);

            return (System.Single[])___result;
        }


        public static System.Single[] GetGlobalFloatArray(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMGetGlobalFloatArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single[])___result;
        }


        public static UnityEngine.Vector4[] GetGlobalVectorArray(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetGlobalVectorArray_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4[])___result;
        }


        public static UnityEngine.Vector4[] GetGlobalVectorArray(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMGetGlobalVectorArray_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4[])___result;
        }


        public static UnityEngine.Matrix4x4[] GetGlobalMatrixArray(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetGlobalMatrixArray_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4[])___result;
        }


        public static UnityEngine.Matrix4x4[] GetGlobalMatrixArray(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMGetGlobalMatrixArray_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4[])___result;
        }


        public static void GetGlobalFloatArray(System.String @name, System.Collections.Generic.List<System.Single> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMGetGlobalFloatArray_String_List_d_Single_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void GetGlobalFloatArray(System.Int32 @nameID, System.Collections.Generic.List<System.Single> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMGetGlobalFloatArray_Int32_List_d_Single_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void GetGlobalVectorArray(System.String @name, System.Collections.Generic.List<UnityEngine.Vector4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMGetGlobalVectorArray_String_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void GetGlobalVectorArray(System.Int32 @nameID, System.Collections.Generic.List<UnityEngine.Vector4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMGetGlobalVectorArray_Int32_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void GetGlobalMatrixArray(System.String @name, System.Collections.Generic.List<UnityEngine.Matrix4x4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMGetGlobalMatrixArray_String_List_d_Matrix4x4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void GetGlobalMatrixArray(System.Int32 @nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMGetGlobalMatrixArray_Int32_List_d_Matrix4x4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static System.String GetPropertyName(UnityEngine.Shader @shader, System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader, @propertyIndex};
            var ___result = RMGetPropertyName_Shader_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Int32 GetPropertyNameId(UnityEngine.Shader @shader, System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader, @propertyIndex};
            var ___result = RMGetPropertyNameId_Shader_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static UnityEngine.Rendering.ShaderPropertyType GetPropertyType(UnityEngine.Shader @shader, System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader, @propertyIndex};
            var ___result = RMGetPropertyType_Shader_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.ShaderPropertyType)___result;
        }


        public static System.String GetPropertyDescription(UnityEngine.Shader @shader, System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader, @propertyIndex};
            var ___result = RMGetPropertyDescription_Shader_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static UnityEngine.Rendering.ShaderPropertyFlags GetPropertyFlags(UnityEngine.Shader @shader, System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader, @propertyIndex};
            var ___result = RMGetPropertyFlags_Shader_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.ShaderPropertyFlags)___result;
        }


        public static System.String[] GetPropertyAttributes(UnityEngine.Shader @shader, System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader, @propertyIndex};
            var ___result = RMGetPropertyAttributes_Shader_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public static System.Int32 GetPropertyDefaultIntValue(UnityEngine.Shader @shader, System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader, @propertyIndex};
            var ___result = RMGetPropertyDefaultIntValue_Shader_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static UnityEngine.Vector4 GetPropertyDefaultValue(UnityEngine.Shader @shader, System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader, @propertyIndex};
            var ___result = RMGetPropertyDefaultValue_Shader_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Rendering.TextureDimension GetPropertyTextureDimension(UnityEngine.Shader @shader, System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader, @propertyIndex};
            var ___result = RMGetPropertyTextureDimension_Shader_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.TextureDimension)___result;
        }


        public static System.String GetPropertyTextureDefaultName(UnityEngine.Shader @shader, System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader, @propertyIndex};
            var ___result = RMGetPropertyTextureDefaultName_Shader_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Boolean FindTextureStackImpl(UnityEngine.Shader @s, System.Int32 @propertyIdx, out System.String @stackName, out System.Int32 @layerIndex)
        {
			@stackName = default;
			@layerIndex = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @propertyIdx, @stackName, @layerIndex};
            var ___result = RMFindTextureStackImpl_Shader_Int32_Out_String_Out_Int32.Invoke(___genericsType, ___parameters);
			@stackName = (System.String)___parameters[2];
			@layerIndex = (System.Int32)___parameters[3];

            return (System.Boolean)___result;
        }


        public static void CheckPropertyIndex(UnityEngine.Shader @s, System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @propertyIndex};
            var ___result = RMCheckPropertyIndex_Shader_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetPropertyCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPropertyCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 FindPropertyIndex(System.String @propertyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName};
            var ___result = RMFindPropertyIndex_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String GetPropertyName(System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyIndex};
            var ___result = RMGetPropertyName_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 GetPropertyNameId(System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyIndex};
            var ___result = RMGetPropertyNameId_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.Rendering.ShaderPropertyType GetPropertyType(System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyIndex};
            var ___result = RMGetPropertyType_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.ShaderPropertyType)___result;
        }


        public virtual System.String GetPropertyDescription(System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyIndex};
            var ___result = RMGetPropertyDescription_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual UnityEngine.Rendering.ShaderPropertyFlags GetPropertyFlags(System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyIndex};
            var ___result = RMGetPropertyFlags_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.ShaderPropertyFlags)___result;
        }


        public virtual System.String[] GetPropertyAttributes(System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyIndex};
            var ___result = RMGetPropertyAttributes_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.Single GetPropertyDefaultFloatValue(System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyIndex};
            var ___result = RMGetPropertyDefaultFloatValue_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual UnityEngine.Vector4 GetPropertyDefaultVectorValue(System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyIndex};
            var ___result = RMGetPropertyDefaultVectorValue_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public virtual UnityEngine.Vector2 GetPropertyRangeLimits(System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyIndex};
            var ___result = RMGetPropertyRangeLimits_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual System.Int32 GetPropertyDefaultIntValue(System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyIndex};
            var ___result = RMGetPropertyDefaultIntValue_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.Rendering.TextureDimension GetPropertyTextureDimension(System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyIndex};
            var ___result = RMGetPropertyTextureDimension_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.TextureDimension)___result;
        }


        public virtual System.String GetPropertyTextureDefaultName(System.Int32 @propertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyIndex};
            var ___result = RMGetPropertyTextureDefaultName_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean FindTextureStack(System.Int32 @propertyIndex, out System.String @stackName, out System.Int32 @layerIndex)
        {
			@stackName = default;
			@layerIndex = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyIndex, @stackName, @layerIndex};
            var ___result = RMFindTextureStack_Int32_Out_String_Out_Int32.Invoke(___genericsType, ___parameters);
			@stackName = (System.String)___parameters[1];
			@layerIndex = (System.Int32)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual void get_keywordSpace_Injected(out UnityEngine.Rendering.LocalKeywordSpace @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_keywordSpace_Injected_Out_LocalKeywordSpace.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Rendering.LocalKeywordSpace)___parameters[0];

            
        }


        public static void EnableKeywordFast_Injected(ref UnityEngine.Rendering.GlobalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMEnableKeywordFast_Injected_Ref_GlobalKeyword.Invoke(___genericsType, ___parameters);
			@keyword = (UnityEngine.Rendering.GlobalKeyword)___parameters[0];

            
        }


        public static void DisableKeywordFast_Injected(ref UnityEngine.Rendering.GlobalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMDisableKeywordFast_Injected_Ref_GlobalKeyword.Invoke(___genericsType, ___parameters);
			@keyword = (UnityEngine.Rendering.GlobalKeyword)___parameters[0];

            
        }


        public static void SetKeywordFast_Injected(ref UnityEngine.Rendering.GlobalKeyword @keyword, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword, @value};
            var ___result = RMSetKeywordFast_Injected_Ref_GlobalKeyword_Boolean.Invoke(___genericsType, ___parameters);
			@keyword = (UnityEngine.Rendering.GlobalKeyword)___parameters[0];

            
        }


        public static System.Boolean IsKeywordEnabledFast_Injected(ref UnityEngine.Rendering.GlobalKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMIsKeywordEnabledFast_Injected_Ref_GlobalKeyword.Invoke(___genericsType, ___parameters);
			@keyword = (UnityEngine.Rendering.GlobalKeyword)___parameters[0];

            return (System.Boolean)___result;
        }


        public static void SetGlobalVectorImpl_Injected(System.Int32 @name, ref UnityEngine.Vector4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetGlobalVectorImpl_Injected_Int32_Ref_Vector4.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Vector4)___parameters[1];

            
        }


        public static void SetGlobalMatrixImpl_Injected(System.Int32 @name, ref UnityEngine.Matrix4x4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetGlobalMatrixImpl_Injected_Int32_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Matrix4x4)___parameters[1];

            
        }


        public static void GetGlobalVectorImpl_Injected(System.Int32 @name, out UnityEngine.Vector4 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @ret};
            var ___result = RMGetGlobalVectorImpl_Injected_Int32_Out_Vector4.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector4)___parameters[1];

            
        }


        public static void GetGlobalMatrixImpl_Injected(System.Int32 @name, out UnityEngine.Matrix4x4 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @ret};
            var ___result = RMGetGlobalMatrixImpl_Injected_Int32_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Matrix4x4)___parameters[1];

            
        }


        public static void GetPropertyDefaultValue_Injected(UnityEngine.Shader @shader, System.Int32 @propertyIndex, out UnityEngine.Vector4 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader, @propertyIndex, @ret};
            var ___result = RMGetPropertyDefaultValue_Injected_Shader_Int32_Out_Vector4.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector4)___parameters[2];

            
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
